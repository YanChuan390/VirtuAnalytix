#define UNITY
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using ExitGames.Client.Photon.LoadBalancing;
using ExitGames.Client.Photon.Voice;
using Microsoft.Win32.SafeHandles;
using POpusCodec;
using POpusCodec.Enums;
using UnityEngine;

[assembly: CompilationRelaxations(8)]
[assembly: RuntimeCompatibility(WrapNonExceptionThrows = true)]
[assembly: Debuggable(DebuggableAttribute.DebuggingModes.IgnoreSymbolStoreSequencePoints)]
[assembly: AssemblyVersion("0.0.0.0")]
public class AndroidAudioInAEC : IAudioPusher<short>, IAudioSource, IDisposable
{
	private class DataCallback : AndroidJavaProxy
	{
		private Action<short[]> callback;

		private IntPtr javaBuf;

		private int cntFrame;

		private int cntShort;

		public DataCallback(Action<short[]> callback, IntPtr javaBuf)
			: base("com.exitgames.photon.audioinaec.AudioInAEC$DataCallback")
		{
			this.callback = callback;
			this.javaBuf = javaBuf;
		}

		public void OnData()
		{
			short[] array = AndroidJNI.FromShortArray(javaBuf);
			cntFrame++;
			cntShort += array.Length;
			callback(array);
		}

		public void OnStop()
		{
			AndroidJNI.DeleteGlobalRef(javaBuf);
		}
	}

	private AndroidJavaObject audioIn;

	private IntPtr javaBuf;

	private DataCallback callback;

	public int Channels => 1;

	public int SamplingRate => 44100;

	public void SetCallback(Action<short[]> callback, LocalVoice localVoice)
	{
		if (audioIn != null)
		{
			Dispose();
		}
		int frameSize = ((LocalVoiceFramed)localVoice).FrameSize;
		javaBuf = AndroidJNI.NewGlobalRef(AndroidJNI.NewShortArray(frameSize));
		this.callback = new DataCallback(callback, javaBuf);
		audioIn = new AndroidJavaObject("com.exitgames.photon.audioinaec.AudioInAEC");
		bool flag = audioIn.Call<bool>("AECIsAvailable", Array.Empty<object>());
		int num = audioIn.Call<int>("GetMinBufferSize", new object[2] { SamplingRate, Channels });
		UnityEngine.Debug.LogFormat("AndroidAudioInAEC: AndroidJavaObject created: aecAvailable: {0}, minBufSize: {1}", flag, num);
		AndroidJavaObject @static = new AndroidJavaClass("com.unity3d.player.UnityPlayer").GetStatic<AndroidJavaObject>("currentActivity");
		IntPtr methodID = AndroidJNI.GetMethodID(audioIn.GetRawClass(), "SetBuffer", "([S)Z");
		bool flag2 = AndroidJNI.CallBooleanMethod(audioIn.GetRawObject(), methodID, new jvalue[1]
		{
			new jvalue
			{
				l = javaBuf
			}
		});
		if (flag2)
		{
			flag2 = audioIn.Call<bool>("Start", new object[6]
			{
				@static,
				this.callback,
				SamplingRate,
				Channels,
				num * 4,
				flag
			});
		}
		UnityEngine.Debug.LogFormat("AndroidAudioInAEC: AndroidJavaObject started: {0}, buffer size: {1}, sampling rate: {2}, channels: {3}, record buffer size: {4}, aec: {5}", flag2, frameSize, SamplingRate, Channels, num * 4, flag);
	}

	public void Dispose()
	{
		audioIn.Call<bool>("Stop", Array.Empty<object>());
	}
}
public class AudioClipWrapper : IAudioReader<float>, IDataReader<float>, IDisposable, IAudioSource
{
	private AudioClip audioClip;

	private int readPos;

	private float startTime;

	private bool playing = true;

	public bool Loop { get; set; }

	public int SamplingRate => audioClip.frequency;

	public int Channels => audioClip.channels;

	public AudioClipWrapper(AudioClip audioClip)
	{
		this.audioClip = audioClip;
		startTime = Time.time;
	}

	public bool Read(float[] buffer)
	{
		if (!playing)
		{
			return false;
		}
		int num = (int)((Time.time - startTime) * (float)audioClip.frequency);
		int num2 = buffer.Length / audioClip.channels;
		if (num > readPos + num2)
		{
			audioClip.GetData(buffer, readPos);
			readPos += num2;
			if (readPos >= audioClip.samples)
			{
				if (Loop)
				{
					readPos = 0;
					startTime = Time.time;
				}
				else
				{
					playing = false;
				}
			}
			return true;
		}
		return false;
	}

	public void Dispose()
	{
	}
}
public class AudioOutCapture : MonoBehaviour
{
	public event Action<float[], int> OnAudioFrame;

	private void OnAudioFilterRead(float[] frame, int channels)
	{
		if (this.OnAudioFrame != null)
		{
			this.OnAudioFrame(frame, channels);
		}
	}
}
public class AudioStreamPlayer : IAudioOut
{
	private const int maxPlayLagMs = 100;

	private int maxPlayLagSamples;

	private int playDelaySamples;

	private int bufferSamples;

	private int channels;

	private int frameSize;

	private int frameSamples;

	private int streamSamplePos;

	private int streamSamplePosAvg;

	private AudioSource source;

	private string logPrefix;

	private bool debugInfo;

	private int sourceTimeSamplesPrev;

	private int playLoopCount;

	private Queue<float[]> frameQueue = new Queue<float[]>();

	public const int FRAME_POOL_CAPACITY = 50;

	private PrimitiveArrayPool<float> framePool = new PrimitiveArrayPool<float>(50, "AudioStreamPlayer");

	public int CurrentBufferLag { get; private set; }

	public AudioSource AudioSource => source;

	private int playSamplePos
	{
		get
		{
			if (!(source.clip != null))
			{
				return 0;
			}
			return playLoopCount * bufferSamples + source.timeSamples;
		}
		set
		{
			if (source.clip != null)
			{
				int num = value % bufferSamples;
				if (num < 0)
				{
					num += bufferSamples;
				}
				source.timeSamples = num;
				playLoopCount = value / bufferSamples;
				sourceTimeSamplesPrev = source.timeSamples;
			}
		}
	}

	public bool IsPlaying => source.isPlaying;

	public AudioStreamPlayer(AudioSource audioSource, string logPrefix, bool debugInfo)
	{
		source = audioSource;
		this.logPrefix = logPrefix;
		this.debugInfo = debugInfo;
	}

	public void Start(int frequency, int channels, int frameSamples, int playDelayMs)
	{
		bufferSamples = (100 + playDelayMs) * frequency / 1000 + frameSamples + frequency;
		this.channels = channels;
		this.frameSamples = frameSamples;
		frameSize = frameSamples * channels;
		maxPlayLagSamples = 100 * frequency / 1000 + this.frameSamples;
		playDelaySamples = playDelayMs * frequency / 1000 + this.frameSamples;
		CurrentBufferLag = playDelaySamples;
		streamSamplePosAvg = playDelaySamples;
		source.loop = true;
		source.clip = AudioClip.Create("AudioStreamPlayer", bufferSamples, channels, frequency, stream: false);
		streamSamplePos = 0;
		playSamplePos = 0;
		source.Play();
		source.Pause();
		framePool.Init(frameSize);
	}

	public void Service()
	{
		if (!(source.clip != null))
		{
			return;
		}
		lock (frameQueue)
		{
			while (frameQueue.Count > 0)
			{
				float[] array = frameQueue.Dequeue();
				source.clip.SetData(array, streamSamplePos % bufferSamples);
				framePool.Release(array);
				streamSamplePos += array.Length / channels;
			}
		}
		if (source.isPlaying)
		{
			if (source.timeSamples < sourceTimeSamplesPrev)
			{
				playLoopCount++;
			}
			sourceTimeSamplesPrev = source.timeSamples;
		}
		int num = playSamplePos;
		CurrentBufferLag = (CurrentBufferLag * 39 + (streamSamplePos - num)) / 40;
		streamSamplePosAvg = num + CurrentBufferLag;
		if (streamSamplePosAvg > streamSamplePos)
		{
			streamSamplePosAvg = streamSamplePos;
		}
		if (num < streamSamplePos - playDelaySamples && !source.isPlaying)
		{
			source.UnPause();
		}
		if (num > streamSamplePos - frameSamples && source.isPlaying)
		{
			if (debugInfo)
			{
				UnityEngine.Debug.LogWarningFormat("{0} player overrun: {1}/{2}({3}) = {4}", logPrefix, num, streamSamplePos, streamSamplePosAvg, streamSamplePos - num);
			}
			source.Pause();
			num = (playSamplePos = streamSamplePos);
			CurrentBufferLag = playDelaySamples;
		}
		if (!source.isPlaying)
		{
			return;
		}
		int num3 = streamSamplePos - playDelaySamples - maxPlayLagSamples;
		if (num < num3)
		{
			if (debugInfo)
			{
				UnityEngine.Debug.LogWarningFormat("{0} player underrun: {1}/{2}({3}) = {4}", logPrefix, num, streamSamplePos, streamSamplePosAvg, streamSamplePos - num);
			}
			num = streamSamplePos - playDelaySamples;
			playSamplePos = num;
			CurrentBufferLag = playDelaySamples;
		}
	}

	public void OnAudioFrame(float[] frame)
	{
		if (frame.Length == 0)
		{
			return;
		}
		if (frame.Length != frameSize)
		{
			UnityEngine.Debug.LogErrorFormat("{0} Audio frames are not of  size: {1} != {2}", logPrefix, frame.Length, frameSize);
			return;
		}
		float[] array = framePool.AcquireOrCreate();
		Buffer.BlockCopy(frame, 0, array, 0, frameSize * 4);
		lock (frameQueue)
		{
			frameQueue.Enqueue(array);
		}
	}

	public void Stop()
	{
		source.Stop();
		source.clip = null;
	}
}
public class IOSAudioForceToSpeaker : MonoBehaviour
{
	private void PhotonVoiceCreated()
	{
	}
}
public class MicWrapper : IAudioReader<float>, IDataReader<float>, IDisposable, IAudioSource
{
	private AudioClip mic;

	private string device;

	private int micPrevPos;

	private int micLoopCnt;

	private int readAbsPos;

	public int SamplingRate => mic.frequency;

	public int Channels => mic.channels;

	public MicWrapper(string device, int suggestedFrequency)
	{
		if (Microphone.devices.Length >= 1)
		{
			this.device = device;
			Microphone.GetDeviceCaps(device, out var minFreq, out var maxFreq);
			int frequency = suggestedFrequency;
			if (suggestedFrequency < minFreq || (maxFreq != 0 && suggestedFrequency > maxFreq))
			{
				UnityEngine.Debug.LogWarningFormat("[PV] MicWrapper does not support suggested frequency {0} (min: {1}, max: {2}). Setting to {2}", suggestedFrequency, minFreq, maxFreq);
				frequency = maxFreq;
			}
			mic = Microphone.Start(device, loop: true, 1, frequency);
		}
	}

	public void Dispose()
	{
		Microphone.End(device);
	}

	public bool Read(float[] buffer)
	{
		int position = Microphone.GetPosition(device);
		if (position < micPrevPos)
		{
			micLoopCnt++;
		}
		micPrevPos = position;
		int num = micLoopCnt * mic.samples + position;
		int num2 = buffer.Length / mic.channels;
		int num3 = readAbsPos + num2;
		if (num3 < num)
		{
			mic.GetData(buffer, readAbsPos % mic.samples);
			readAbsPos = num3;
			return true;
		}
		return false;
	}
}
public class SpeexDSP : MonoBehaviour
{
	private class Logger : ExitGames.Client.Photon.Voice.ILogger
	{
		public void LogError(string fmt, params object[] args)
		{
			UnityEngine.Debug.LogErrorFormat(fmt, args);
		}

		public void LogWarning(string fmt, params object[] args)
		{
			UnityEngine.Debug.LogWarningFormat(fmt, args);
		}

		public void LogInfo(string fmt, params object[] args)
		{
			UnityEngine.Debug.LogFormat(fmt, args);
		}

		public void LogDebug(string fmt, params object[] args)
		{
			UnityEngine.Debug.LogFormat(fmt, args);
		}
	}

	[Header("Platforms")]
	public bool Windows = true;

	public bool Mac = true;

	[Header("Effects")]
	[Tooltip("Acoustic Echo Cancellation")]
	public bool AEC = true;

	public int AECPlaybackDelayMs = 100;

	public int AECFilterLengthMs = 200;

	public bool Denoise = true;

	[Tooltip("Automatic Gain Control")]
	public bool AGC = true;

	[Range(1f, 32768f)]
	public float AGCLevel = 20000f;

	public int AECPlayDelayCurrentFrames;

	public bool AECLatencyDetect;

	private SpeexProcessor proc;

	private bool prevAEC;

	private int aecLDState;

	private float aecLDStart;

	private AudioSource aecLDPing;

	public SpeexProcessor Processor => proc;

	public bool Active { get; private set; }

	public void ResetAEC()
	{
		if (proc != null)
		{
			proc.ResetAEC();
		}
	}

	private void Awake()
	{
		switch (Application.platform)
		{
		case RuntimePlatform.WindowsPlayer:
		case RuntimePlatform.WindowsEditor:
			Active = Windows;
			break;
		case RuntimePlatform.OSXEditor:
		case RuntimePlatform.OSXPlayer:
			Active = Mac;
			break;
		}
	}

	private void Start()
	{
	}

	private void UpdateProcProps()
	{
		if (proc == null)
		{
			return;
		}
		if (prevAEC != AEC)
		{
			setOutputListener(AEC);
			prevAEC = AEC;
		}
		proc.AEC = AEC;
		proc.AECFilterLengthMs = AECFilterLengthMs;
		proc.AECPlaybackDelayMs = AECPlaybackDelayMs;
		proc.Denoise = Denoise;
		proc.AGC = AGC;
		proc.AGCLevel = AGCLevel;
		AECPlayDelayCurrentFrames = proc.AECurrentPlayDelayFrames;
		if (proc.AECLatencyDetect == AECLatencyDetect)
		{
			return;
		}
		if (AECLatencyDetect)
		{
			aecLDState = 0;
			if (aecLDPing == null)
			{
				InitAECLatencyDetect();
			}
		}
		proc.AECLatencyDetect = AECLatencyDetect;
	}

	private void setOutputListener(bool set)
	{
		AudioListener audioListener = UnityEngine.Object.FindObjectOfType<AudioListener>();
		if (!(audioListener != null))
		{
			return;
		}
		AudioOutCapture audioOutCapture = audioListener.gameObject.GetComponent<AudioOutCapture>();
		if (audioOutCapture != null)
		{
			audioOutCapture.OnAudioFrame -= proc.OnAudioOutFrame;
		}
		if (set)
		{
			if (audioOutCapture == null)
			{
				audioOutCapture = audioListener.gameObject.AddComponent<AudioOutCapture>();
			}
			audioOutCapture.OnAudioFrame += proc.OnAudioOutFrame;
		}
	}

	private void Update()
	{
		UpdateProcProps();
		if (proc == null)
		{
			return;
		}
		if (Time.frameCount % 10 == 0)
		{
			proc.PrintInfo();
		}
		if (AECLatencyDetect)
		{
			float time = Time.time;
			if (aecLDState == 0)
			{
				aecLDState = 1;
				aecLDStart = time;
			}
			float num = time - aecLDStart;
			if (aecLDState == 1 && num > 1f)
			{
				aecLDState = 2;
				proc.AECLatecnyDetectCaliberate();
			}
			if (aecLDState == 2 && num > 4f)
			{
				aecLDState = 3;
				aecLDPing.Play();
			}
			if (aecLDState == 3 && num > 5f)
			{
				aecLDState = 0;
			}
		}
	}

	private void InitAECLatencyDetect()
	{
		int num = 200;
		int outputSampleRate = AudioSettings.outputSampleRate;
		aecLDPing = base.gameObject.AddComponent<AudioSource>();
		aecLDPing.clip = AudioClip.Create("AEC ping", outputSampleRate * num / 1000, 2, outputSampleRate, stream: false);
		aecLDPing.loop = false;
		float[] array = new float[aecLDPing.clip.frequency * 2];
		for (int i = 0; i < aecLDPing.clip.frequency; i++)
		{
			array[2 * i] = (array[2 * i + 1] = (float)Math.Sin((float)i / 4f));
		}
		aecLDPing.clip.SetData(array, 0);
	}

	private void PhotonVoiceCreated(LocalVoice localVoice)
	{
		if (Active)
		{
			if (localVoice.Info.Channels != 1)
			{
				throw new Exception("SpeexProcessor: only mono audio signals supported.");
			}
			if (!(localVoice is LocalVoiceAudioShort))
			{
				throw new Exception("SpeexProcessor: only short audio voice supported (Set PhotonVoiceRecorder.TypeConvert option).");
			}
			LocalVoiceAudioShort localVoiceAudioShort = (LocalVoiceAudioShort)localVoice;
			int playChannels = new Dictionary<AudioSpeakerMode, int>
			{
				{
					AudioSpeakerMode.Mono,
					1
				},
				{
					AudioSpeakerMode.Stereo,
					2
				},
				{
					AudioSpeakerMode.Quad,
					4
				},
				{
					AudioSpeakerMode.Surround,
					5
				},
				{
					AudioSpeakerMode.Mode5point1,
					6
				},
				{
					AudioSpeakerMode.Mode7point1,
					8
				},
				{
					AudioSpeakerMode.Prologic,
					0
				}
			}[AudioSettings.speakerMode];
			AudioSettings.GetDSPBufferSize(out var bufferLength, out var _);
			proc = new SpeexProcessor(new Logger(), () => (long)(AudioSettings.dspTime * 1000.0), localVoiceAudioShort.FrameSize, localVoice.Info.SourceSamplingRate, localVoice.Info.Channels, AudioSettings.outputSampleRate, playChannels, bufferLength);
			localVoiceAudioShort.AddPreProcessor(proc);
			UpdateProcProps();
			UnityEngine.Debug.Log("SpeexDSP initialized.");
		}
	}

	private void PhotonVoiceRemoved()
	{
		reset();
	}

	private void OnDestroy()
	{
		reset();
	}

	private void reset()
	{
		if (proc != null)
		{
			setOutputListener(set: false);
			proc.Dispose();
			proc = null;
		}
	}
}
public class iTween : MonoBehaviour
{
	private delegate float EasingFunction(float start, float end, float Value);

	private delegate void ApplyTween();

	public enum EaseType
	{
		easeInQuad,
		easeOutQuad,
		easeInOutQuad,
		easeInCubic,
		easeOutCubic,
		easeInOutCubic,
		easeInQuart,
		easeOutQuart,
		easeInOutQuart,
		easeInQuint,
		easeOutQuint,
		easeInOutQuint,
		easeInSine,
		easeOutSine,
		easeInOutSine,
		easeInExpo,
		easeOutExpo,
		easeInOutExpo,
		easeInCirc,
		easeOutCirc,
		easeInOutCirc,
		linear,
		spring,
		easeInBounce,
		easeOutBounce,
		easeInOutBounce,
		easeInBack,
		easeOutBack,
		easeInOutBack,
		easeInElastic,
		easeOutElastic,
		easeInOutElastic,
		punch
	}

	public enum LoopType
	{
		none,
		loop,
		pingPong
	}

	public enum NamedValueColor
	{
		_Color,
		_SpecColor,
		_Emission,
		_ReflectColor
	}

	public static class Defaults
	{
		public static float time = 1f;

		public static float delay = 0f;

		public static NamedValueColor namedColorValue = NamedValueColor._Color;

		public static LoopType loopType = LoopType.none;

		public static EaseType easeType = EaseType.easeOutExpo;

		public static float lookSpeed = 3f;

		public static bool isLocal = false;

		public static Space space = Space.Self;

		public static bool orientToPath = false;

		public static Color color = Color.white;

		public static float updateTimePercentage = 0.05f;

		public static float updateTime = 1f * updateTimePercentage;

		public static int cameraFadeDepth = 999999;

		public static float lookAhead = 0.05f;

		public static bool useRealTime = false;

		public static Vector3 up = Vector3.up;
	}

	private class CRSpline
	{
		public Vector3[] pts;

		public CRSpline(params Vector3[] pts)
		{
			this.pts = new Vector3[pts.Length];
			Array.Copy(pts, this.pts, pts.Length);
		}

		public Vector3 Interp(float t)
		{
			int num = pts.Length - 3;
			int num2 = Mathf.Min(Mathf.FloorToInt(t * (float)num), num - 1);
			float num3 = t * (float)num - (float)num2;
			Vector3 vector = pts[num2];
			Vector3 vector2 = pts[num2 + 1];
			Vector3 vector3 = pts[num2 + 2];
			Vector3 vector4 = pts[num2 + 3];
			return 0.5f * ((-vector + 3f * vector2 - 3f * vector3 + vector4) * (num3 * num3 * num3) + (2f * vector - 5f * vector2 + 4f * vector3 - vector4) * (num3 * num3) + (-vector + vector3) * num3 + 2f * vector2);
		}
	}

	public static List<Hashtable> tweens = new List<Hashtable>();

	private static GameObject cameraFade;

	public string id;

	public string type;

	public string method;

	public EaseType easeType;

	public float time;

	public float delay;

	public LoopType loopType;

	public bool isRunning;

	public bool isPaused;

	public string _name;

	private float runningTime;

	private float percentage;

	private float delayStarted;

	private bool kinematic;

	private bool isLocal;

	private bool loop;

	private bool reverse;

	private bool wasPaused;

	private bool physics;

	private Hashtable tweenArguments;

	private Space space;

	private EasingFunction ease;

	private ApplyTween apply;

	private AudioSource audioSource;

	private Vector3[] vector3s;

	private Vector2[] vector2s;

	private Color[,] colors;

	private float[] floats;

	private Rect[] rects;

	private CRSpline path;

	private Vector3 preUpdate;

	private Vector3 postUpdate;

	private NamedValueColor namedcolorvalue;

	private float lastRealTime;

	private bool useRealTime;

	private Transform thisTransform;

	public static void Init(GameObject target)
	{
		MoveBy(target, Vector3.zero, 0f);
	}

	public static void CameraFadeFrom(float amount, float time)
	{
		if ((bool)cameraFade)
		{
			CameraFadeFrom(Hash("amount", amount, "time", time));
		}
		else
		{
			UnityEngine.Debug.LogError("iTween Error: You must first add a camera fade object with CameraFadeAdd() before atttempting to use camera fading.");
		}
	}

	public static void CameraFadeFrom(Hashtable args)
	{
		if ((bool)cameraFade)
		{
			ColorFrom(cameraFade, args);
		}
		else
		{
			UnityEngine.Debug.LogError("iTween Error: You must first add a camera fade object with CameraFadeAdd() before atttempting to use camera fading.");
		}
	}

	public static void CameraFadeTo(float amount, float time)
	{
		if ((bool)cameraFade)
		{
			CameraFadeTo(Hash("amount", amount, "time", time));
		}
		else
		{
			UnityEngine.Debug.LogError("iTween Error: You must first add a camera fade object with CameraFadeAdd() before atttempting to use camera fading.");
		}
	}

	public static void CameraFadeTo(Hashtable args)
	{
		if ((bool)cameraFade)
		{
			ColorTo(cameraFade, args);
		}
		else
		{
			UnityEngine.Debug.LogError("iTween Error: You must first add a camera fade object with CameraFadeAdd() before atttempting to use camera fading.");
		}
	}

	public static void ValueTo(GameObject target, Hashtable args)
	{
		args = CleanArgs(args);
		if (!args.Contains("onupdate") || !args.Contains("from") || !args.Contains("to"))
		{
			UnityEngine.Debug.LogError("iTween Error: ValueTo() requires an 'onupdate' callback function and a 'from' and 'to' property.  The supplied 'onupdate' callback must accept a single argument that is the same type as the supplied 'from' and 'to' properties!");
			return;
		}
		args["type"] = "value";
		if (args["from"].GetType() == typeof(Vector2))
		{
			args["method"] = "vector2";
		}
		else if (args["from"].GetType() == typeof(Vector3))
		{
			args["method"] = "vector3";
		}
		else if (args["from"].GetType() == typeof(Rect))
		{
			args["method"] = "rect";
		}
		else if (args["from"].GetType() == typeof(float))
		{
			args["method"] = "float";
		}
		else
		{
			if (!(args["from"].GetType() == typeof(Color)))
			{
				UnityEngine.Debug.LogError("iTween Error: ValueTo() only works with interpolating Vector3s, Vector2s, floats, ints, Rects and Colors!");
				return;
			}
			args["method"] = "color";
		}
		if (!args.Contains("easetype"))
		{
			args.Add("easetype", EaseType.linear);
		}
		Launch(target, args);
	}

	public static void FadeFrom(GameObject target, float alpha, float time)
	{
		FadeFrom(target, Hash("alpha", alpha, "time", time));
	}

	public static void FadeFrom(GameObject target, Hashtable args)
	{
		ColorFrom(target, args);
	}

	public static void FadeTo(GameObject target, float alpha, float time)
	{
		FadeTo(target, Hash("alpha", alpha, "time", time));
	}

	public static void FadeTo(GameObject target, Hashtable args)
	{
		ColorTo(target, args);
	}

	public static void ColorFrom(GameObject target, Color color, float time)
	{
		ColorFrom(target, Hash("color", color, "time", time));
	}

	public static void ColorFrom(GameObject target, Hashtable args)
	{
		Color color = default(Color);
		Color color2 = default(Color);
		args = CleanArgs(args);
		if (!args.Contains("includechildren") || (bool)args["includechildren"])
		{
			foreach (Transform item in target.transform)
			{
				Hashtable hashtable = (Hashtable)args.Clone();
				hashtable["ischild"] = true;
				ColorFrom(item.gameObject, hashtable);
			}
		}
		if (!args.Contains("easetype"))
		{
			args.Add("easetype", EaseType.linear);
		}
		if ((bool)target.GetComponent<GUITexture>())
		{
			color2 = (color = target.GetComponent<GUITexture>().color);
		}
		else if ((bool)target.GetComponent<GUIText>())
		{
			color2 = (color = target.GetComponent<GUIText>().material.color);
		}
		else if ((bool)target.GetComponent<Renderer>())
		{
			color2 = (color = target.GetComponent<Renderer>().material.color);
		}
		else if ((bool)target.GetComponent<Light>())
		{
			color2 = (color = target.GetComponent<Light>().color);
		}
		if (args.Contains("color"))
		{
			color = (Color)args["color"];
		}
		else
		{
			if (args.Contains("r"))
			{
				color.r = (float)args["r"];
			}
			if (args.Contains("g"))
			{
				color.g = (float)args["g"];
			}
			if (args.Contains("b"))
			{
				color.b = (float)args["b"];
			}
			if (args.Contains("a"))
			{
				color.a = (float)args["a"];
			}
		}
		if (args.Contains("amount"))
		{
			color.a = (float)args["amount"];
			args.Remove("amount");
		}
		else if (args.Contains("alpha"))
		{
			color.a = (float)args["alpha"];
			args.Remove("alpha");
		}
		if ((bool)target.GetComponent<GUITexture>())
		{
			target.GetComponent<GUITexture>().color = color;
		}
		else if ((bool)target.GetComponent<GUIText>())
		{
			target.GetComponent<GUIText>().material.color = color;
		}
		else if ((bool)target.GetComponent<Renderer>())
		{
			target.GetComponent<Renderer>().material.color = color;
		}
		else if ((bool)target.GetComponent<Light>())
		{
			target.GetComponent<Light>().color = color;
		}
		args["color"] = color2;
		args["type"] = "color";
		args["method"] = "to";
		Launch(target, args);
	}

	public static void ColorTo(GameObject target, Color color, float time)
	{
		ColorTo(target, Hash("color", color, "time", time));
	}

	public static void ColorTo(GameObject target, Hashtable args)
	{
		args = CleanArgs(args);
		if (!args.Contains("includechildren") || (bool)args["includechildren"])
		{
			foreach (Transform item in target.transform)
			{
				Hashtable hashtable = (Hashtable)args.Clone();
				hashtable["ischild"] = true;
				ColorTo(item.gameObject, hashtable);
			}
		}
		if (!args.Contains("easetype"))
		{
			args.Add("easetype", EaseType.linear);
		}
		args["type"] = "color";
		args["method"] = "to";
		Launch(target, args);
	}

	public static void AudioFrom(GameObject target, float volume, float pitch, float time)
	{
		AudioFrom(target, Hash("volume", volume, "pitch", pitch, "time", time));
	}

	public static void AudioFrom(GameObject target, Hashtable args)
	{
		args = CleanArgs(args);
		AudioSource audioSource;
		if (args.Contains("audiosource"))
		{
			audioSource = (AudioSource)args["audiosource"];
		}
		else
		{
			if (!target.GetComponent<AudioSource>())
			{
				UnityEngine.Debug.LogError("iTween Error: AudioFrom requires an AudioSource.");
				return;
			}
			audioSource = target.GetComponent<AudioSource>();
		}
		Vector2 vector = default(Vector2);
		Vector2 vector2 = default(Vector2);
		vector.x = (vector2.x = audioSource.volume);
		vector.y = (vector2.y = audioSource.pitch);
		if (args.Contains("volume"))
		{
			vector2.x = (float)args["volume"];
		}
		if (args.Contains("pitch"))
		{
			vector2.y = (float)args["pitch"];
		}
		audioSource.volume = vector2.x;
		audioSource.pitch = vector2.y;
		args["volume"] = vector.x;
		args["pitch"] = vector.y;
		if (!args.Contains("easetype"))
		{
			args.Add("easetype", EaseType.linear);
		}
		args["type"] = "audio";
		args["method"] = "to";
		Launch(target, args);
	}

	public static void AudioTo(GameObject target, float volume, float pitch, float time)
	{
		AudioTo(target, Hash("volume", volume, "pitch", pitch, "time", time));
	}

	public static void AudioTo(GameObject target, Hashtable args)
	{
		args = CleanArgs(args);
		if (!args.Contains("easetype"))
		{
			args.Add("easetype", EaseType.linear);
		}
		args["type"] = "audio";
		args["method"] = "to";
		Launch(target, args);
	}

	public static void Stab(GameObject target, AudioClip audioclip, float delay)
	{
		Stab(target, Hash("audioclip", audioclip, "delay", delay));
	}

	public static void Stab(GameObject target, Hashtable args)
	{
		args = CleanArgs(args);
		args["type"] = "stab";
		Launch(target, args);
	}

	public static void LookFrom(GameObject target, Vector3 looktarget, float time)
	{
		LookFrom(target, Hash("looktarget", looktarget, "time", time));
	}

	public static void LookFrom(GameObject target, Hashtable args)
	{
		args = CleanArgs(args);
		Vector3 eulerAngles = target.transform.eulerAngles;
		if (args["looktarget"].GetType() == typeof(Transform))
		{
			target.transform.LookAt((Transform)args["looktarget"], ((Vector3?)args["up"]) ?? Defaults.up);
		}
		else if (args["looktarget"].GetType() == typeof(Vector3))
		{
			target.transform.LookAt((Vector3)args["looktarget"], ((Vector3?)args["up"]) ?? Defaults.up);
		}
		if (args.Contains("axis"))
		{
			Vector3 eulerAngles2 = target.transform.eulerAngles;
			switch ((string)args["axis"])
			{
			case "x":
				eulerAngles2.y = eulerAngles.y;
				eulerAngles2.z = eulerAngles.z;
				break;
			case "y":
				eulerAngles2.x = eulerAngles.x;
				eulerAngles2.z = eulerAngles.z;
				break;
			case "z":
				eulerAngles2.x = eulerAngles.x;
				eulerAngles2.y = eulerAngles.y;
				break;
			}
			target.transform.eulerAngles = eulerAngles2;
		}
		args["rotation"] = eulerAngles;
		args["type"] = "rotate";
		args["method"] = "to";
		Launch(target, args);
	}

	public static void LookTo(GameObject target, Vector3 looktarget, float time)
	{
		LookTo(target, Hash("looktarget", looktarget, "time", time));
	}

	public static void LookTo(GameObject target, Hashtable args)
	{
		args = CleanArgs(args);
		if (args.Contains("looktarget") && args["looktarget"].GetType() == typeof(Transform))
		{
			Transform transform = (Transform)args["looktarget"];
			args["position"] = new Vector3(transform.position.x, transform.position.y, transform.position.z);
			args["rotation"] = new Vector3(transform.eulerAngles.x, transform.eulerAngles.y, transform.eulerAngles.z);
		}
		args["type"] = "look";
		args["method"] = "to";
		Launch(target, args);
	}

	public static void MoveTo(GameObject target, Vector3 position, float time)
	{
		MoveTo(target, Hash("position", position, "time", time));
	}

	public static void MoveTo(GameObject target, Hashtable args)
	{
		args = CleanArgs(args);
		if (args.Contains("position") && args["position"].GetType() == typeof(Transform))
		{
			Transform transform = (Transform)args["position"];
			args["position"] = new Vector3(transform.position.x, transform.position.y, transform.position.z);
			args["rotation"] = new Vector3(transform.eulerAngles.x, transform.eulerAngles.y, transform.eulerAngles.z);
			args["scale"] = new Vector3(transform.localScale.x, transform.localScale.y, transform.localScale.z);
		}
		args["type"] = "move";
		args["method"] = "to";
		Launch(target, args);
	}

	public static void MoveFrom(GameObject target, Vector3 position, float time)
	{
		MoveFrom(target, Hash("position", position, "time", time));
	}

	public static void MoveFrom(GameObject target, Hashtable args)
	{
		args = CleanArgs(args);
		bool flag = ((!args.Contains("islocal")) ? Defaults.isLocal : ((bool)args["islocal"]));
		if (args.Contains("path"))
		{
			Vector3[] array2;
			if (args["path"].GetType() == typeof(Vector3[]))
			{
				Vector3[] array = (Vector3[])args["path"];
				array2 = new Vector3[array.Length];
				Array.Copy(array, array2, array.Length);
			}
			else
			{
				Transform[] array3 = (Transform[])args["path"];
				array2 = new Vector3[array3.Length];
				for (int i = 0; i < array3.Length; i++)
				{
					array2[i] = array3[i].position;
				}
			}
			if (array2[array2.Length - 1] != target.transform.position)
			{
				Vector3[] array4 = new Vector3[array2.Length + 1];
				Array.Copy(array2, array4, array2.Length);
				if (flag)
				{
					array4[array4.Length - 1] = target.transform.localPosition;
					target.transform.localPosition = array4[0];
				}
				else
				{
					array4[array4.Length - 1] = target.transform.position;
					target.transform.position = array4[0];
				}
				args["path"] = array4;
			}
			else
			{
				if (flag)
				{
					target.transform.localPosition = array2[0];
				}
				else
				{
					target.transform.position = array2[0];
				}
				args["path"] = array2;
			}
		}
		else
		{
			Vector3 vector;
			Vector3 vector2 = ((!flag) ? (vector = target.transform.position) : (vector = target.transform.localPosition));
			if (args.Contains("position"))
			{
				if (args["position"].GetType() == typeof(Transform))
				{
					vector = ((Transform)args["position"]).position;
				}
				else if (args["position"].GetType() == typeof(Vector3))
				{
					vector = (Vector3)args["position"];
				}
			}
			else
			{
				if (args.Contains("x"))
				{
					vector.x = (float)args["x"];
				}
				if (args.Contains("y"))
				{
					vector.y = (float)args["y"];
				}
				if (args.Contains("z"))
				{
					vector.z = (float)args["z"];
				}
			}
			if (flag)
			{
				target.transform.localPosition = vector;
			}
			else
			{
				target.transform.position = vector;
			}
			args["position"] = vector2;
		}
		args["type"] = "move";
		args["method"] = "to";
		Launch(target, args);
	}

	public static void MoveAdd(GameObject target, Vector3 amount, float time)
	{
		MoveAdd(target, Hash("amount", amount, "time", time));
	}

	public static void MoveAdd(GameObject target, Hashtable args)
	{
		args = CleanArgs(args);
		args["type"] = "move";
		args["method"] = "add";
		Launch(target, args);
	}

	public static void MoveBy(GameObject target, Vector3 amount, float time)
	{
		MoveBy(target, Hash("amount", amount, "time", time));
	}

	public static void MoveBy(GameObject target, Hashtable args)
	{
		args = CleanArgs(args);
		args["type"] = "move";
		args["method"] = "by";
		Launch(target, args);
	}

	public static void ScaleTo(GameObject target, Vector3 scale, float time)
	{
		ScaleTo(target, Hash("scale", scale, "time", time));
	}

	public static void ScaleTo(GameObject target, Hashtable args)
	{
		args = CleanArgs(args);
		if (args.Contains("scale") && args["scale"].GetType() == typeof(Transform))
		{
			Transform transform = (Transform)args["scale"];
			args["position"] = new Vector3(transform.position.x, transform.position.y, transform.position.z);
			args["rotation"] = new Vector3(transform.eulerAngles.x, transform.eulerAngles.y, transform.eulerAngles.z);
			args["scale"] = new Vector3(transform.localScale.x, transform.localScale.y, transform.localScale.z);
		}
		args["type"] = "scale";
		args["method"] = "to";
		Launch(target, args);
	}

	public static void ScaleFrom(GameObject target, Vector3 scale, float time)
	{
		ScaleFrom(target, Hash("scale", scale, "time", time));
	}

	public static void ScaleFrom(GameObject target, Hashtable args)
	{
		args = CleanArgs(args);
		Vector3 localScale;
		Vector3 vector = (localScale = target.transform.localScale);
		if (args.Contains("scale"))
		{
			if (args["scale"].GetType() == typeof(Transform))
			{
				localScale = ((Transform)args["scale"]).localScale;
			}
			else if (args["scale"].GetType() == typeof(Vector3))
			{
				localScale = (Vector3)args["scale"];
			}
		}
		else
		{
			if (args.Contains("x"))
			{
				localScale.x = (float)args["x"];
			}
			if (args.Contains("y"))
			{
				localScale.y = (float)args["y"];
			}
			if (args.Contains("z"))
			{
				localScale.z = (float)args["z"];
			}
		}
		target.transform.localScale = localScale;
		args["scale"] = vector;
		args["type"] = "scale";
		args["method"] = "to";
		Launch(target, args);
	}

	public static void ScaleAdd(GameObject target, Vector3 amount, float time)
	{
		ScaleAdd(target, Hash("amount", amount, "time", time));
	}

	public static void ScaleAdd(GameObject target, Hashtable args)
	{
		args = CleanArgs(args);
		args["type"] = "scale";
		args["method"] = "add";
		Launch(target, args);
	}

	public static void ScaleBy(GameObject target, Vector3 amount, float time)
	{
		ScaleBy(target, Hash("amount", amount, "time", time));
	}

	public static void ScaleBy(GameObject target, Hashtable args)
	{
		args = CleanArgs(args);
		args["type"] = "scale";
		args["method"] = "by";
		Launch(target, args);
	}

	public static void RotateTo(GameObject target, Vector3 rotation, float time)
	{
		RotateTo(target, Hash("rotation", rotation, "time", time));
	}

	public static void RotateTo(GameObject target, Hashtable args)
	{
		args = CleanArgs(args);
		if (args.Contains("rotation") && args["rotation"].GetType() == typeof(Transform))
		{
			Transform transform = (Transform)args["rotation"];
			args["position"] = new Vector3(transform.position.x, transform.position.y, transform.position.z);
			args["rotation"] = new Vector3(transform.eulerAngles.x, transform.eulerAngles.y, transform.eulerAngles.z);
			args["scale"] = new Vector3(transform.localScale.x, transform.localScale.y, transform.localScale.z);
		}
		args["type"] = "rotate";
		args["method"] = "to";
		Launch(target, args);
	}

	public static void RotateFrom(GameObject target, Vector3 rotation, float time)
	{
		RotateFrom(target, Hash("rotation", rotation, "time", time));
	}

	public static void RotateFrom(GameObject target, Hashtable args)
	{
		args = CleanArgs(args);
		bool flag = ((!args.Contains("islocal")) ? Defaults.isLocal : ((bool)args["islocal"]));
		Vector3 vector;
		Vector3 vector2 = ((!flag) ? (vector = target.transform.eulerAngles) : (vector = target.transform.localEulerAngles));
		if (args.Contains("rotation"))
		{
			if (args["rotation"].GetType() == typeof(Transform))
			{
				vector = ((Transform)args["rotation"]).eulerAngles;
			}
			else if (args["rotation"].GetType() == typeof(Vector3))
			{
				vector = (Vector3)args["rotation"];
			}
		}
		else
		{
			if (args.Contains("x"))
			{
				vector.x = (float)args["x"];
			}
			if (args.Contains("y"))
			{
				vector.y = (float)args["y"];
			}
			if (args.Contains("z"))
			{
				vector.z = (float)args["z"];
			}
		}
		if (flag)
		{
			target.transform.localEulerAngles = vector;
		}
		else
		{
			target.transform.eulerAngles = vector;
		}
		args["rotation"] = vector2;
		args["type"] = "rotate";
		args["method"] = "to";
		Launch(target, args);
	}

	public static void RotateAdd(GameObject target, Vector3 amount, float time)
	{
		RotateAdd(target, Hash("amount", amount, "time", time));
	}

	public static void RotateAdd(GameObject target, Hashtable args)
	{
		args = CleanArgs(args);
		args["type"] = "rotate";
		args["method"] = "add";
		Launch(target, args);
	}

	public static void RotateBy(GameObject target, Vector3 amount, float time)
	{
		RotateBy(target, Hash("amount", amount, "time", time));
	}

	public static void RotateBy(GameObject target, Hashtable args)
	{
		args = CleanArgs(args);
		args["type"] = "rotate";
		args["method"] = "by";
		Launch(target, args);
	}

	public static void ShakePosition(GameObject target, Vector3 amount, float time)
	{
		ShakePosition(target, Hash("amount", amount, "time", time));
	}

	public static void ShakePosition(GameObject target, Hashtable args)
	{
		args = CleanArgs(args);
		args["type"] = "shake";
		args["method"] = "position";
		Launch(target, args);
	}

	public static void ShakeScale(GameObject target, Vector3 amount, float time)
	{
		ShakeScale(target, Hash("amount", amount, "time", time));
	}

	public static void ShakeScale(GameObject target, Hashtable args)
	{
		args = CleanArgs(args);
		args["type"] = "shake";
		args["method"] = "scale";
		Launch(target, args);
	}

	public static void ShakeRotation(GameObject target, Vector3 amount, float time)
	{
		ShakeRotation(target, Hash("amount", amount, "time", time));
	}

	public static void ShakeRotation(GameObject target, Hashtable args)
	{
		args = CleanArgs(args);
		args["type"] = "shake";
		args["method"] = "rotation";
		Launch(target, args);
	}

	public static void PunchPosition(GameObject target, Vector3 amount, float time)
	{
		PunchPosition(target, Hash("amount", amount, "time", time));
	}

	public static void PunchPosition(GameObject target, Hashtable args)
	{
		args = CleanArgs(args);
		args["type"] = "punch";
		args["method"] = "position";
		args["easetype"] = EaseType.punch;
		Launch(target, args);
	}

	public static void PunchRotation(GameObject target, Vector3 amount, float time)
	{
		PunchRotation(target, Hash("amount", amount, "time", time));
	}

	public static void PunchRotation(GameObject target, Hashtable args)
	{
		args = CleanArgs(args);
		args["type"] = "punch";
		args["method"] = "rotation";
		args["easetype"] = EaseType.punch;
		Launch(target, args);
	}

	public static void PunchScale(GameObject target, Vector3 amount, float time)
	{
		PunchScale(target, Hash("amount", amount, "time", time));
	}

	public static void PunchScale(GameObject target, Hashtable args)
	{
		args = CleanArgs(args);
		args["type"] = "punch";
		args["method"] = "scale";
		args["easetype"] = EaseType.punch;
		Launch(target, args);
	}

	private void GenerateTargets()
	{
		switch (type)
		{
		case "value":
			switch (method)
			{
			case "float":
				GenerateFloatTargets();
				apply = ApplyFloatTargets;
				break;
			case "vector2":
				GenerateVector2Targets();
				apply = ApplyVector2Targets;
				break;
			case "vector3":
				GenerateVector3Targets();
				apply = ApplyVector3Targets;
				break;
			case "color":
				GenerateColorTargets();
				apply = ApplyColorTargets;
				break;
			case "rect":
				GenerateRectTargets();
				apply = ApplyRectTargets;
				break;
			}
			break;
		case "color":
		{
			string text = method;
			if (text == "to")
			{
				GenerateColorToTargets();
				apply = ApplyColorToTargets;
			}
			break;
		}
		case "audio":
		{
			string text = method;
			if (text == "to")
			{
				GenerateAudioToTargets();
				apply = ApplyAudioToTargets;
			}
			break;
		}
		case "move":
			switch (method)
			{
			case "to":
				if (tweenArguments.Contains("path"))
				{
					GenerateMoveToPathTargets();
					apply = ApplyMoveToPathTargets;
				}
				else
				{
					GenerateMoveToTargets();
					apply = ApplyMoveToTargets;
				}
				break;
			case "by":
			case "add":
				GenerateMoveByTargets();
				apply = ApplyMoveByTargets;
				break;
			}
			break;
		case "scale":
			switch (method)
			{
			case "to":
				GenerateScaleToTargets();
				apply = ApplyScaleToTargets;
				break;
			case "by":
				GenerateScaleByTargets();
				apply = ApplyScaleToTargets;
				break;
			case "add":
				GenerateScaleAddTargets();
				apply = ApplyScaleToTargets;
				break;
			}
			break;
		case "rotate":
			switch (method)
			{
			case "to":
				GenerateRotateToTargets();
				apply = ApplyRotateToTargets;
				break;
			case "add":
				GenerateRotateAddTargets();
				apply = ApplyRotateAddTargets;
				break;
			case "by":
				GenerateRotateByTargets();
				apply = ApplyRotateAddTargets;
				break;
			}
			break;
		case "shake":
			switch (method)
			{
			case "position":
				GenerateShakePositionTargets();
				apply = ApplyShakePositionTargets;
				break;
			case "scale":
				GenerateShakeScaleTargets();
				apply = ApplyShakeScaleTargets;
				break;
			case "rotation":
				GenerateShakeRotationTargets();
				apply = ApplyShakeRotationTargets;
				break;
			}
			break;
		case "punch":
			switch (method)
			{
			case "position":
				GeneratePunchPositionTargets();
				apply = ApplyPunchPositionTargets;
				break;
			case "rotation":
				GeneratePunchRotationTargets();
				apply = ApplyPunchRotationTargets;
				break;
			case "scale":
				GeneratePunchScaleTargets();
				apply = ApplyPunchScaleTargets;
				break;
			}
			break;
		case "look":
		{
			string text = method;
			if (text == "to")
			{
				GenerateLookToTargets();
				apply = ApplyLookToTargets;
			}
			break;
		}
		case "stab":
			GenerateStabTargets();
			apply = ApplyStabTargets;
			break;
		}
	}

	private void GenerateRectTargets()
	{
		rects = new Rect[3];
		rects[0] = (Rect)tweenArguments["from"];
		rects[1] = (Rect)tweenArguments["to"];
	}

	private void GenerateColorTargets()
	{
		colors = new Color[1, 3];
		colors[0, 0] = (Color)tweenArguments["from"];
		colors[0, 1] = (Color)tweenArguments["to"];
	}

	private void GenerateVector3Targets()
	{
		vector3s = new Vector3[3];
		vector3s[0] = (Vector3)tweenArguments["from"];
		vector3s[1] = (Vector3)tweenArguments["to"];
		if (tweenArguments.Contains("speed"))
		{
			float num = Math.Abs(Vector3.Distance(vector3s[0], vector3s[1]));
			time = num / (float)tweenArguments["speed"];
		}
	}

	private void GenerateVector2Targets()
	{
		vector2s = new Vector2[3];
		vector2s[0] = (Vector2)tweenArguments["from"];
		vector2s[1] = (Vector2)tweenArguments["to"];
		if (tweenArguments.Contains("speed"))
		{
			Vector3 a = new Vector3(vector2s[0].x, vector2s[0].y, 0f);
			Vector3 b = new Vector3(vector2s[1].x, vector2s[1].y, 0f);
			float num = Math.Abs(Vector3.Distance(a, b));
			time = num / (float)tweenArguments["speed"];
		}
	}

	private void GenerateFloatTargets()
	{
		floats = new float[3];
		floats[0] = (float)tweenArguments["from"];
		floats[1] = (float)tweenArguments["to"];
		if (tweenArguments.Contains("speed"))
		{
			float num = Math.Abs(floats[0] - floats[1]);
			time = num / (float)tweenArguments["speed"];
		}
	}

	private void GenerateColorToTargets()
	{
		if ((bool)GetComponent<GUITexture>())
		{
			colors = new Color[1, 3];
			colors[0, 0] = (colors[0, 1] = GetComponent<GUITexture>().color);
		}
		else if ((bool)GetComponent<GUIText>())
		{
			colors = new Color[1, 3];
			colors[0, 0] = (colors[0, 1] = GetComponent<GUIText>().material.color);
		}
		else if ((bool)GetComponent<Renderer>())
		{
			colors = new Color[GetComponent<Renderer>().materials.Length, 3];
			for (int i = 0; i < GetComponent<Renderer>().materials.Length; i++)
			{
				colors[i, 0] = GetComponent<Renderer>().materials[i].GetColor(namedcolorvalue.ToString());
				colors[i, 1] = GetComponent<Renderer>().materials[i].GetColor(namedcolorvalue.ToString());
			}
		}
		else if ((bool)GetComponent<Light>())
		{
			colors = new Color[1, 3];
			colors[0, 0] = (colors[0, 1] = GetComponent<Light>().color);
		}
		else
		{
			colors = new Color[1, 3];
		}
		if (tweenArguments.Contains("color"))
		{
			for (int j = 0; j < colors.GetLength(0); j++)
			{
				colors[j, 1] = (Color)tweenArguments["color"];
			}
		}
		else
		{
			if (tweenArguments.Contains("r"))
			{
				for (int k = 0; k < colors.GetLength(0); k++)
				{
					colors[k, 1].r = (float)tweenArguments["r"];
				}
			}
			if (tweenArguments.Contains("g"))
			{
				for (int l = 0; l < colors.GetLength(0); l++)
				{
					colors[l, 1].g = (float)tweenArguments["g"];
				}
			}
			if (tweenArguments.Contains("b"))
			{
				for (int m = 0; m < colors.GetLength(0); m++)
				{
					colors[m, 1].b = (float)tweenArguments["b"];
				}
			}
			if (tweenArguments.Contains("a"))
			{
				for (int n = 0; n < colors.GetLength(0); n++)
				{
					colors[n, 1].a = (float)tweenArguments["a"];
				}
			}
		}
		if (tweenArguments.Contains("amount"))
		{
			for (int num = 0; num < colors.GetLength(0); num++)
			{
				colors[num, 1].a = (float)tweenArguments["amount"];
			}
		}
		else if (tweenArguments.Contains("alpha"))
		{
			for (int num2 = 0; num2 < colors.GetLength(0); num2++)
			{
				colors[num2, 1].a = (float)tweenArguments["alpha"];
			}
		}
	}

	private void GenerateAudioToTargets()
	{
		vector2s = new Vector2[3];
		if (tweenArguments.Contains("audiosource"))
		{
			audioSource = (AudioSource)tweenArguments["audiosource"];
		}
		else if ((bool)GetComponent<AudioSource>())
		{
			audioSource = GetComponent<AudioSource>();
		}
		else
		{
			UnityEngine.Debug.LogError("iTween Error: AudioTo requires an AudioSource.");
			Dispose();
		}
		vector2s[0] = (vector2s[1] = new Vector2(audioSource.volume, audioSource.pitch));
		if (tweenArguments.Contains("volume"))
		{
			vector2s[1].x = (float)tweenArguments["volume"];
		}
		if (tweenArguments.Contains("pitch"))
		{
			vector2s[1].y = (float)tweenArguments["pitch"];
		}
	}

	private void GenerateStabTargets()
	{
		if (tweenArguments.Contains("audiosource"))
		{
			audioSource = (AudioSource)tweenArguments["audiosource"];
		}
		else if ((bool)GetComponent<AudioSource>())
		{
			audioSource = GetComponent<AudioSource>();
		}
		else
		{
			base.gameObject.AddComponent<AudioSource>();
			audioSource = GetComponent<AudioSource>();
			audioSource.playOnAwake = false;
		}
		audioSource.clip = (AudioClip)tweenArguments["audioclip"];
		if (tweenArguments.Contains("pitch"))
		{
			audioSource.pitch = (float)tweenArguments["pitch"];
		}
		if (tweenArguments.Contains("volume"))
		{
			audioSource.volume = (float)tweenArguments["volume"];
		}
		time = audioSource.clip.length / audioSource.pitch;
	}

	private void GenerateLookToTargets()
	{
		vector3s = new Vector3[3];
		vector3s[0] = thisTransform.eulerAngles;
		if (tweenArguments.Contains("looktarget"))
		{
			if (tweenArguments["looktarget"].GetType() == typeof(Transform))
			{
				thisTransform.LookAt((Transform)tweenArguments["looktarget"], ((Vector3?)tweenArguments["up"]) ?? Defaults.up);
			}
			else if (tweenArguments["looktarget"].GetType() == typeof(Vector3))
			{
				thisTransform.LookAt((Vector3)tweenArguments["looktarget"], ((Vector3?)tweenArguments["up"]) ?? Defaults.up);
			}
		}
		else
		{
			UnityEngine.Debug.LogError("iTween Error: LookTo needs a 'looktarget' property!");
			Dispose();
		}
		vector3s[1] = thisTransform.eulerAngles;
		thisTransform.eulerAngles = vector3s[0];
		if (tweenArguments.Contains("axis"))
		{
			switch ((string)tweenArguments["axis"])
			{
			case "x":
				vector3s[1].y = vector3s[0].y;
				vector3s[1].z = vector3s[0].z;
				break;
			case "y":
				vector3s[1].x = vector3s[0].x;
				vector3s[1].z = vector3s[0].z;
				break;
			case "z":
				vector3s[1].x = vector3s[0].x;
				vector3s[1].y = vector3s[0].y;
				break;
			}
		}
		vector3s[1] = new Vector3(clerp(vector3s[0].x, vector3s[1].x, 1f), clerp(vector3s[0].y, vector3s[1].y, 1f), clerp(vector3s[0].z, vector3s[1].z, 1f));
		if (tweenArguments.Contains("speed"))
		{
			float num = Math.Abs(Vector3.Distance(vector3s[0], vector3s[1]));
			time = num / (float)tweenArguments["speed"];
		}
	}

	private void GenerateMoveToPathTargets()
	{
		Vector3[] array2;
		if (tweenArguments["path"].GetType() == typeof(Vector3[]))
		{
			Vector3[] array = (Vector3[])tweenArguments["path"];
			if (array.Length == 1)
			{
				UnityEngine.Debug.LogError("iTween Error: Attempting a path movement with MoveTo requires an array of more than 1 entry!");
				Dispose();
			}
			array2 = new Vector3[array.Length];
			Array.Copy(array, array2, array.Length);
		}
		else
		{
			Transform[] array3 = (Transform[])tweenArguments["path"];
			if (array3.Length == 1)
			{
				UnityEngine.Debug.LogError("iTween Error: Attempting a path movement with MoveTo requires an array of more than 1 entry!");
				Dispose();
			}
			array2 = new Vector3[array3.Length];
			for (int i = 0; i < array3.Length; i++)
			{
				array2[i] = array3[i].position;
			}
		}
		bool flag;
		int num;
		if (thisTransform.position != array2[0])
		{
			if (!tweenArguments.Contains("movetopath") || (bool)tweenArguments["movetopath"])
			{
				flag = true;
				num = 3;
			}
			else
			{
				flag = false;
				num = 2;
			}
		}
		else
		{
			flag = false;
			num = 2;
		}
		vector3s = new Vector3[array2.Length + num];
		if (flag)
		{
			vector3s[1] = thisTransform.position;
			num = 2;
		}
		else
		{
			num = 1;
		}
		Array.Copy(array2, 0, vector3s, num, array2.Length);
		vector3s[0] = vector3s[1] + (vector3s[1] - vector3s[2]);
		vector3s[vector3s.Length - 1] = vector3s[vector3s.Length - 2] + (vector3s[vector3s.Length - 2] - vector3s[vector3s.Length - 3]);
		if (vector3s[1] == vector3s[vector3s.Length - 2])
		{
			Vector3[] array4 = new Vector3[vector3s.Length];
			Array.Copy(vector3s, array4, vector3s.Length);
			array4[0] = array4[array4.Length - 3];
			array4[array4.Length - 1] = array4[2];
			vector3s = new Vector3[array4.Length];
			Array.Copy(array4, vector3s, array4.Length);
		}
		path = new CRSpline(vector3s);
		if (tweenArguments.Contains("speed"))
		{
			float num2 = PathLength(vector3s);
			time = num2 / (float)tweenArguments["speed"];
		}
	}

	private void GenerateMoveToTargets()
	{
		vector3s = new Vector3[3];
		if (isLocal)
		{
			vector3s[0] = (vector3s[1] = thisTransform.localPosition);
		}
		else
		{
			vector3s[0] = (vector3s[1] = thisTransform.position);
		}
		if (tweenArguments.Contains("position"))
		{
			if (tweenArguments["position"].GetType() == typeof(Transform))
			{
				Transform transform = (Transform)tweenArguments["position"];
				vector3s[1] = transform.position;
			}
			else if (tweenArguments["position"].GetType() == typeof(Vector3))
			{
				vector3s[1] = (Vector3)tweenArguments["position"];
			}
		}
		else
		{
			if (tweenArguments.Contains("x"))
			{
				vector3s[1].x = (float)tweenArguments["x"];
			}
			if (tweenArguments.Contains("y"))
			{
				vector3s[1].y = (float)tweenArguments["y"];
			}
			if (tweenArguments.Contains("z"))
			{
				vector3s[1].z = (float)tweenArguments["z"];
			}
		}
		if (tweenArguments.Contains("orienttopath") && (bool)tweenArguments["orienttopath"])
		{
			tweenArguments["looktarget"] = vector3s[1];
		}
		if (tweenArguments.Contains("speed"))
		{
			float num = Math.Abs(Vector3.Distance(vector3s[0], vector3s[1]));
			time = num / (float)tweenArguments["speed"];
		}
	}

	private void GenerateMoveByTargets()
	{
		vector3s = new Vector3[6];
		vector3s[4] = thisTransform.eulerAngles;
		vector3s[0] = (vector3s[1] = (vector3s[3] = thisTransform.position));
		if (tweenArguments.Contains("amount"))
		{
			vector3s[1] = vector3s[0] + (Vector3)tweenArguments["amount"];
		}
		else
		{
			if (tweenArguments.Contains("x"))
			{
				vector3s[1].x = vector3s[0].x + (float)tweenArguments["x"];
			}
			if (tweenArguments.Contains("y"))
			{
				vector3s[1].y = vector3s[0].y + (float)tweenArguments["y"];
			}
			if (tweenArguments.Contains("z"))
			{
				vector3s[1].z = vector3s[0].z + (float)tweenArguments["z"];
			}
		}
		thisTransform.Translate(vector3s[1], space);
		vector3s[5] = thisTransform.position;
		thisTransform.position = vector3s[0];
		if (tweenArguments.Contains("orienttopath") && (bool)tweenArguments["orienttopath"])
		{
			tweenArguments["looktarget"] = vector3s[1];
		}
		if (tweenArguments.Contains("speed"))
		{
			float num = Math.Abs(Vector3.Distance(vector3s[0], vector3s[1]));
			time = num / (float)tweenArguments["speed"];
		}
	}

	private void GenerateScaleToTargets()
	{
		vector3s = new Vector3[3];
		vector3s[0] = (vector3s[1] = thisTransform.localScale);
		if (tweenArguments.Contains("scale"))
		{
			if (tweenArguments["scale"].GetType() == typeof(Transform))
			{
				Transform transform = (Transform)tweenArguments["scale"];
				vector3s[1] = transform.localScale;
			}
			else if (tweenArguments["scale"].GetType() == typeof(Vector3))
			{
				vector3s[1] = (Vector3)tweenArguments["scale"];
			}
		}
		else
		{
			if (tweenArguments.Contains("x"))
			{
				vector3s[1].x = (float)tweenArguments["x"];
			}
			if (tweenArguments.Contains("y"))
			{
				vector3s[1].y = (float)tweenArguments["y"];
			}
			if (tweenArguments.Contains("z"))
			{
				vector3s[1].z = (float)tweenArguments["z"];
			}
		}
		if (tweenArguments.Contains("speed"))
		{
			float num = Math.Abs(Vector3.Distance(vector3s[0], vector3s[1]));
			time = num / (float)tweenArguments["speed"];
		}
	}

	private void GenerateScaleByTargets()
	{
		vector3s = new Vector3[3];
		vector3s[0] = (vector3s[1] = thisTransform.localScale);
		if (tweenArguments.Contains("amount"))
		{
			vector3s[1] = Vector3.Scale(vector3s[1], (Vector3)tweenArguments["amount"]);
		}
		else
		{
			if (tweenArguments.Contains("x"))
			{
				vector3s[1].x *= (float)tweenArguments["x"];
			}
			if (tweenArguments.Contains("y"))
			{
				vector3s[1].y *= (float)tweenArguments["y"];
			}
			if (tweenArguments.Contains("z"))
			{
				vector3s[1].z *= (float)tweenArguments["z"];
			}
		}
		if (tweenArguments.Contains("speed"))
		{
			float num = Math.Abs(Vector3.Distance(vector3s[0], vector3s[1]));
			time = num / (float)tweenArguments["speed"];
		}
	}

	private void GenerateScaleAddTargets()
	{
		vector3s = new Vector3[3];
		vector3s[0] = (vector3s[1] = thisTransform.localScale);
		if (tweenArguments.Contains("amount"))
		{
			vector3s[1] += (Vector3)tweenArguments["amount"];
		}
		else
		{
			if (tweenArguments.Contains("x"))
			{
				vector3s[1].x += (float)tweenArguments["x"];
			}
			if (tweenArguments.Contains("y"))
			{
				vector3s[1].y += (float)tweenArguments["y"];
			}
			if (tweenArguments.Contains("z"))
			{
				vector3s[1].z += (float)tweenArguments["z"];
			}
		}
		if (tweenArguments.Contains("speed"))
		{
			float num = Math.Abs(Vector3.Distance(vector3s[0], vector3s[1]));
			time = num / (float)tweenArguments["speed"];
		}
	}

	private void GenerateRotateToTargets()
	{
		vector3s = new Vector3[3];
		if (isLocal)
		{
			vector3s[0] = (vector3s[1] = thisTransform.localEulerAngles);
		}
		else
		{
			vector3s[0] = (vector3s[1] = thisTransform.eulerAngles);
		}
		if (tweenArguments.Contains("rotation"))
		{
			if (tweenArguments["rotation"].GetType() == typeof(Transform))
			{
				Transform transform = (Transform)tweenArguments["rotation"];
				vector3s[1] = transform.eulerAngles;
			}
			else if (tweenArguments["rotation"].GetType() == typeof(Vector3))
			{
				vector3s[1] = (Vector3)tweenArguments["rotation"];
			}
		}
		else
		{
			if (tweenArguments.Contains("x"))
			{
				vector3s[1].x = (float)tweenArguments["x"];
			}
			if (tweenArguments.Contains("y"))
			{
				vector3s[1].y = (float)tweenArguments["y"];
			}
			if (tweenArguments.Contains("z"))
			{
				vector3s[1].z = (float)tweenArguments["z"];
			}
		}
		vector3s[1] = new Vector3(clerp(vector3s[0].x, vector3s[1].x, 1f), clerp(vector3s[0].y, vector3s[1].y, 1f), clerp(vector3s[0].z, vector3s[1].z, 1f));
		if (tweenArguments.Contains("speed"))
		{
			float num = Math.Abs(Vector3.Distance(vector3s[0], vector3s[1]));
			time = num / (float)tweenArguments["speed"];
		}
	}

	private void GenerateRotateAddTargets()
	{
		vector3s = new Vector3[5];
		vector3s[0] = (vector3s[1] = (vector3s[3] = thisTransform.eulerAngles));
		if (tweenArguments.Contains("amount"))
		{
			vector3s[1] += (Vector3)tweenArguments["amount"];
		}
		else
		{
			if (tweenArguments.Contains("x"))
			{
				vector3s[1].x += (float)tweenArguments["x"];
			}
			if (tweenArguments.Contains("y"))
			{
				vector3s[1].y += (float)tweenArguments["y"];
			}
			if (tweenArguments.Contains("z"))
			{
				vector3s[1].z += (float)tweenArguments["z"];
			}
		}
		if (tweenArguments.Contains("speed"))
		{
			float num = Math.Abs(Vector3.Distance(vector3s[0], vector3s[1]));
			time = num / (float)tweenArguments["speed"];
		}
	}

	private void GenerateRotateByTargets()
	{
		vector3s = new Vector3[4];
		vector3s[0] = (vector3s[1] = (vector3s[3] = thisTransform.eulerAngles));
		if (tweenArguments.Contains("amount"))
		{
			vector3s[1] += Vector3.Scale((Vector3)tweenArguments["amount"], new Vector3(360f, 360f, 360f));
		}
		else
		{
			if (tweenArguments.Contains("x"))
			{
				vector3s[1].x += 360f * (float)tweenArguments["x"];
			}
			if (tweenArguments.Contains("y"))
			{
				vector3s[1].y += 360f * (float)tweenArguments["y"];
			}
			if (tweenArguments.Contains("z"))
			{
				vector3s[1].z += 360f * (float)tweenArguments["z"];
			}
		}
		if (tweenArguments.Contains("speed"))
		{
			float num = Math.Abs(Vector3.Distance(vector3s[0], vector3s[1]));
			time = num / (float)tweenArguments["speed"];
		}
	}

	private void GenerateShakePositionTargets()
	{
		vector3s = new Vector3[4];
		vector3s[3] = thisTransform.eulerAngles;
		vector3s[0] = thisTransform.position;
		if (tweenArguments.Contains("amount"))
		{
			vector3s[1] = (Vector3)tweenArguments["amount"];
			return;
		}
		if (tweenArguments.Contains("x"))
		{
			vector3s[1].x = (float)tweenArguments["x"];
		}
		if (tweenArguments.Contains("y"))
		{
			vector3s[1].y = (float)tweenArguments["y"];
		}
		if (tweenArguments.Contains("z"))
		{
			vector3s[1].z = (float)tweenArguments["z"];
		}
	}

	private void GenerateShakeScaleTargets()
	{
		vector3s = new Vector3[3];
		vector3s[0] = thisTransform.localScale;
		if (tweenArguments.Contains("amount"))
		{
			vector3s[1] = (Vector3)tweenArguments["amount"];
			return;
		}
		if (tweenArguments.Contains("x"))
		{
			vector3s[1].x = (float)tweenArguments["x"];
		}
		if (tweenArguments.Contains("y"))
		{
			vector3s[1].y = (float)tweenArguments["y"];
		}
		if (tweenArguments.Contains("z"))
		{
			vector3s[1].z = (float)tweenArguments["z"];
		}
	}

	private void GenerateShakeRotationTargets()
	{
		vector3s = new Vector3[3];
		vector3s[0] = thisTransform.eulerAngles;
		if (tweenArguments.Contains("amount"))
		{
			vector3s[1] = (Vector3)tweenArguments["amount"];
			return;
		}
		if (tweenArguments.Contains("x"))
		{
			vector3s[1].x = (float)tweenArguments["x"];
		}
		if (tweenArguments.Contains("y"))
		{
			vector3s[1].y = (float)tweenArguments["y"];
		}
		if (tweenArguments.Contains("z"))
		{
			vector3s[1].z = (float)tweenArguments["z"];
		}
	}

	private void GeneratePunchPositionTargets()
	{
		vector3s = new Vector3[5];
		vector3s[4] = thisTransform.eulerAngles;
		vector3s[0] = thisTransform.position;
		vector3s[1] = (vector3s[3] = Vector3.zero);
		if (tweenArguments.Contains("amount"))
		{
			vector3s[1] = (Vector3)tweenArguments["amount"];
			return;
		}
		if (tweenArguments.Contains("x"))
		{
			vector3s[1].x = (float)tweenArguments["x"];
		}
		if (tweenArguments.Contains("y"))
		{
			vector3s[1].y = (float)tweenArguments["y"];
		}
		if (tweenArguments.Contains("z"))
		{
			vector3s[1].z = (float)tweenArguments["z"];
		}
	}

	private void GeneratePunchRotationTargets()
	{
		vector3s = new Vector3[4];
		vector3s[0] = thisTransform.eulerAngles;
		vector3s[1] = (vector3s[3] = Vector3.zero);
		if (tweenArguments.Contains("amount"))
		{
			vector3s[1] = (Vector3)tweenArguments["amount"];
			return;
		}
		if (tweenArguments.Contains("x"))
		{
			vector3s[1].x = (float)tweenArguments["x"];
		}
		if (tweenArguments.Contains("y"))
		{
			vector3s[1].y = (float)tweenArguments["y"];
		}
		if (tweenArguments.Contains("z"))
		{
			vector3s[1].z = (float)tweenArguments["z"];
		}
	}

	private void GeneratePunchScaleTargets()
	{
		vector3s = new Vector3[3];
		vector3s[0] = thisTransform.localScale;
		vector3s[1] = Vector3.zero;
		if (tweenArguments.Contains("amount"))
		{
			vector3s[1] = (Vector3)tweenArguments["amount"];
			return;
		}
		if (tweenArguments.Contains("x"))
		{
			vector3s[1].x = (float)tweenArguments["x"];
		}
		if (tweenArguments.Contains("y"))
		{
			vector3s[1].y = (float)tweenArguments["y"];
		}
		if (tweenArguments.Contains("z"))
		{
			vector3s[1].z = (float)tweenArguments["z"];
		}
	}

	private void ApplyRectTargets()
	{
		rects[2].x = ease(rects[0].x, rects[1].x, percentage);
		rects[2].y = ease(rects[0].y, rects[1].y, percentage);
		rects[2].width = ease(rects[0].width, rects[1].width, percentage);
		rects[2].height = ease(rects[0].height, rects[1].height, percentage);
		tweenArguments["onupdateparams"] = rects[2];
		if (percentage == 1f)
		{
			tweenArguments["onupdateparams"] = rects[1];
		}
	}

	private void ApplyColorTargets()
	{
		colors[0, 2].r = ease(colors[0, 0].r, colors[0, 1].r, percentage);
		colors[0, 2].g = ease(colors[0, 0].g, colors[0, 1].g, percentage);
		colors[0, 2].b = ease(colors[0, 0].b, colors[0, 1].b, percentage);
		colors[0, 2].a = ease(colors[0, 0].a, colors[0, 1].a, percentage);
		tweenArguments["onupdateparams"] = colors[0, 2];
		if (percentage == 1f)
		{
			tweenArguments["onupdateparams"] = colors[0, 1];
		}
	}

	private void ApplyVector3Targets()
	{
		vector3s[2].x = ease(vector3s[0].x, vector3s[1].x, percentage);
		vector3s[2].y = ease(vector3s[0].y, vector3s[1].y, percentage);
		vector3s[2].z = ease(vector3s[0].z, vector3s[1].z, percentage);
		tweenArguments["onupdateparams"] = vector3s[2];
		if (percentage == 1f)
		{
			tweenArguments["onupdateparams"] = vector3s[1];
		}
	}

	private void ApplyVector2Targets()
	{
		vector2s[2].x = ease(vector2s[0].x, vector2s[1].x, percentage);
		vector2s[2].y = ease(vector2s[0].y, vector2s[1].y, percentage);
		tweenArguments["onupdateparams"] = vector2s[2];
		if (percentage == 1f)
		{
			tweenArguments["onupdateparams"] = vector2s[1];
		}
	}

	private void ApplyFloatTargets()
	{
		floats[2] = ease(floats[0], floats[1], percentage);
		tweenArguments["onupdateparams"] = floats[2];
		if (percentage == 1f)
		{
			tweenArguments["onupdateparams"] = floats[1];
		}
	}

	private void ApplyColorToTargets()
	{
		for (int i = 0; i < colors.GetLength(0); i++)
		{
			colors[i, 2].r = ease(colors[i, 0].r, colors[i, 1].r, percentage);
			colors[i, 2].g = ease(colors[i, 0].g, colors[i, 1].g, percentage);
			colors[i, 2].b = ease(colors[i, 0].b, colors[i, 1].b, percentage);
			colors[i, 2].a = ease(colors[i, 0].a, colors[i, 1].a, percentage);
		}
		if ((bool)GetComponent<GUITexture>())
		{
			GetComponent<GUITexture>().color = colors[0, 2];
		}
		else if ((bool)GetComponent<GUIText>())
		{
			GetComponent<GUIText>().material.color = colors[0, 2];
		}
		else if ((bool)GetComponent<Renderer>())
		{
			for (int j = 0; j < colors.GetLength(0); j++)
			{
				GetComponent<Renderer>().materials[j].SetColor(namedcolorvalue.ToString(), colors[j, 2]);
			}
		}
		else if ((bool)GetComponent<Light>())
		{
			GetComponent<Light>().color = colors[0, 2];
		}
		if (percentage != 1f)
		{
			return;
		}
		if ((bool)GetComponent<GUITexture>())
		{
			GetComponent<GUITexture>().color = colors[0, 1];
		}
		else if ((bool)GetComponent<GUIText>())
		{
			GetComponent<GUIText>().material.color = colors[0, 1];
		}
		else if ((bool)GetComponent<Renderer>())
		{
			for (int k = 0; k < colors.GetLength(0); k++)
			{
				GetComponent<Renderer>().materials[k].SetColor(namedcolorvalue.ToString(), colors[k, 1]);
			}
		}
		else if ((bool)GetComponent<Light>())
		{
			GetComponent<Light>().color = colors[0, 1];
		}
	}

	private void ApplyAudioToTargets()
	{
		vector2s[2].x = ease(vector2s[0].x, vector2s[1].x, percentage);
		vector2s[2].y = ease(vector2s[0].y, vector2s[1].y, percentage);
		audioSource.volume = vector2s[2].x;
		audioSource.pitch = vector2s[2].y;
		if (percentage == 1f)
		{
			audioSource.volume = vector2s[1].x;
			audioSource.pitch = vector2s[1].y;
		}
	}

	private void ApplyStabTargets()
	{
	}

	private void ApplyMoveToPathTargets()
	{
		preUpdate = thisTransform.position;
		float value = ease(0f, 1f, percentage);
		if (isLocal)
		{
			thisTransform.localPosition = path.Interp(Mathf.Clamp(value, 0f, 1f));
		}
		else
		{
			thisTransform.position = path.Interp(Mathf.Clamp(value, 0f, 1f));
		}
		if (tweenArguments.Contains("orienttopath") && (bool)tweenArguments["orienttopath"])
		{
			float num = ((!tweenArguments.Contains("lookahead")) ? Defaults.lookAhead : ((float)tweenArguments["lookahead"]));
			float value2 = ease(0f, 1f, Mathf.Min(1f, percentage + num));
			tweenArguments["looktarget"] = path.Interp(Mathf.Clamp(value2, 0f, 1f));
		}
		postUpdate = thisTransform.position;
		if (physics)
		{
			thisTransform.position = preUpdate;
			GetComponent<Rigidbody>().MovePosition(postUpdate);
		}
	}

	private void ApplyMoveToTargets()
	{
		preUpdate = thisTransform.position;
		vector3s[2].x = ease(vector3s[0].x, vector3s[1].x, percentage);
		vector3s[2].y = ease(vector3s[0].y, vector3s[1].y, percentage);
		vector3s[2].z = ease(vector3s[0].z, vector3s[1].z, percentage);
		if (isLocal)
		{
			thisTransform.localPosition = vector3s[2];
		}
		else
		{
			thisTransform.position = vector3s[2];
		}
		if (percentage == 1f)
		{
			if (isLocal)
			{
				thisTransform.localPosition = vector3s[1];
			}
			else
			{
				thisTransform.position = vector3s[1];
			}
		}
		postUpdate = thisTransform.position;
		if (physics)
		{
			thisTransform.position = preUpdate;
			GetComponent<Rigidbody>().MovePosition(postUpdate);
		}
	}

	private void ApplyMoveByTargets()
	{
		preUpdate = thisTransform.position;
		Vector3 eulerAngles = default(Vector3);
		if (tweenArguments.Contains("looktarget"))
		{
			eulerAngles = thisTransform.eulerAngles;
			thisTransform.eulerAngles = vector3s[4];
		}
		vector3s[2].x = ease(vector3s[0].x, vector3s[1].x, percentage);
		vector3s[2].y = ease(vector3s[0].y, vector3s[1].y, percentage);
		vector3s[2].z = ease(vector3s[0].z, vector3s[1].z, percentage);
		thisTransform.Translate(vector3s[2] - vector3s[3], space);
		vector3s[3] = vector3s[2];
		if (tweenArguments.Contains("looktarget"))
		{
			thisTransform.eulerAngles = eulerAngles;
		}
		postUpdate = thisTransform.position;
		if (physics)
		{
			thisTransform.position = preUpdate;
			GetComponent<Rigidbody>().MovePosition(postUpdate);
		}
	}

	private void ApplyScaleToTargets()
	{
		vector3s[2].x = ease(vector3s[0].x, vector3s[1].x, percentage);
		vector3s[2].y = ease(vector3s[0].y, vector3s[1].y, percentage);
		vector3s[2].z = ease(vector3s[0].z, vector3s[1].z, percentage);
		thisTransform.localScale = vector3s[2];
		if (percentage == 1f)
		{
			thisTransform.localScale = vector3s[1];
		}
	}

	private void ApplyLookToTargets()
	{
		vector3s[2].x = ease(vector3s[0].x, vector3s[1].x, percentage);
		vector3s[2].y = ease(vector3s[0].y, vector3s[1].y, percentage);
		vector3s[2].z = ease(vector3s[0].z, vector3s[1].z, percentage);
		if (isLocal)
		{
			thisTransform.localRotation = Quaternion.Euler(vector3s[2]);
		}
		else
		{
			thisTransform.rotation = Quaternion.Euler(vector3s[2]);
		}
	}

	private void ApplyRotateToTargets()
	{
		preUpdate = thisTransform.eulerAngles;
		vector3s[2].x = ease(vector3s[0].x, vector3s[1].x, percentage);
		vector3s[2].y = ease(vector3s[0].y, vector3s[1].y, percentage);
		vector3s[2].z = ease(vector3s[0].z, vector3s[1].z, percentage);
		if (isLocal)
		{
			thisTransform.localRotation = Quaternion.Euler(vector3s[2]);
		}
		else
		{
			thisTransform.rotation = Quaternion.Euler(vector3s[2]);
		}
		if (percentage == 1f)
		{
			if (isLocal)
			{
				thisTransform.localRotation = Quaternion.Euler(vector3s[1]);
			}
			else
			{
				thisTransform.rotation = Quaternion.Euler(vector3s[1]);
			}
		}
		postUpdate = thisTransform.eulerAngles;
		if (physics)
		{
			thisTransform.eulerAngles = preUpdate;
			GetComponent<Rigidbody>().MoveRotation(Quaternion.Euler(postUpdate));
		}
	}

	private void ApplyRotateAddTargets()
	{
		preUpdate = thisTransform.eulerAngles;
		vector3s[2].x = ease(vector3s[0].x, vector3s[1].x, percentage);
		vector3s[2].y = ease(vector3s[0].y, vector3s[1].y, percentage);
		vector3s[2].z = ease(vector3s[0].z, vector3s[1].z, percentage);
		thisTransform.Rotate(vector3s[2] - vector3s[3], space);
		vector3s[3] = vector3s[2];
		postUpdate = thisTransform.eulerAngles;
		if (physics)
		{
			thisTransform.eulerAngles = preUpdate;
			GetComponent<Rigidbody>().MoveRotation(Quaternion.Euler(postUpdate));
		}
	}

	private void ApplyShakePositionTargets()
	{
		if (isLocal)
		{
			preUpdate = thisTransform.localPosition;
		}
		else
		{
			preUpdate = thisTransform.position;
		}
		Vector3 eulerAngles = default(Vector3);
		if (tweenArguments.Contains("looktarget"))
		{
			eulerAngles = thisTransform.eulerAngles;
			thisTransform.eulerAngles = vector3s[3];
		}
		if (percentage == 0f)
		{
			thisTransform.Translate(vector3s[1], space);
		}
		if (isLocal)
		{
			thisTransform.localPosition = vector3s[0];
		}
		else
		{
			thisTransform.position = vector3s[0];
		}
		float num = 1f - percentage;
		vector3s[2].x = UnityEngine.Random.Range((0f - vector3s[1].x) * num, vector3s[1].x * num);
		vector3s[2].y = UnityEngine.Random.Range((0f - vector3s[1].y) * num, vector3s[1].y * num);
		vector3s[2].z = UnityEngine.Random.Range((0f - vector3s[1].z) * num, vector3s[1].z * num);
		if (isLocal)
		{
			thisTransform.localPosition += vector3s[2];
		}
		else
		{
			thisTransform.position += vector3s[2];
		}
		if (tweenArguments.Contains("looktarget"))
		{
			thisTransform.eulerAngles = eulerAngles;
		}
		postUpdate = thisTransform.position;
		if (physics)
		{
			thisTransform.position = preUpdate;
			GetComponent<Rigidbody>().MovePosition(postUpdate);
		}
	}

	private void ApplyShakeScaleTargets()
	{
		if (percentage == 0f)
		{
			thisTransform.localScale = vector3s[1];
		}
		thisTransform.localScale = vector3s[0];
		float num = 1f - percentage;
		vector3s[2].x = UnityEngine.Random.Range((0f - vector3s[1].x) * num, vector3s[1].x * num);
		vector3s[2].y = UnityEngine.Random.Range((0f - vector3s[1].y) * num, vector3s[1].y * num);
		vector3s[2].z = UnityEngine.Random.Range((0f - vector3s[1].z) * num, vector3s[1].z * num);
		thisTransform.localScale += vector3s[2];
	}

	private void ApplyShakeRotationTargets()
	{
		preUpdate = thisTransform.eulerAngles;
		if (percentage == 0f)
		{
			thisTransform.Rotate(vector3s[1], space);
		}
		thisTransform.eulerAngles = vector3s[0];
		float num = 1f - percentage;
		vector3s[2].x = UnityEngine.Random.Range((0f - vector3s[1].x) * num, vector3s[1].x * num);
		vector3s[2].y = UnityEngine.Random.Range((0f - vector3s[1].y) * num, vector3s[1].y * num);
		vector3s[2].z = UnityEngine.Random.Range((0f - vector3s[1].z) * num, vector3s[1].z * num);
		thisTransform.Rotate(vector3s[2], space);
		postUpdate = thisTransform.eulerAngles;
		if (physics)
		{
			thisTransform.eulerAngles = preUpdate;
			GetComponent<Rigidbody>().MoveRotation(Quaternion.Euler(postUpdate));
		}
	}

	private void ApplyPunchPositionTargets()
	{
		preUpdate = thisTransform.position;
		Vector3 eulerAngles = default(Vector3);
		if (tweenArguments.Contains("looktarget"))
		{
			eulerAngles = thisTransform.eulerAngles;
			thisTransform.eulerAngles = vector3s[4];
		}
		if (vector3s[1].x > 0f)
		{
			vector3s[2].x = punch(vector3s[1].x, percentage);
		}
		else if (vector3s[1].x < 0f)
		{
			vector3s[2].x = 0f - punch(Mathf.Abs(vector3s[1].x), percentage);
		}
		if (vector3s[1].y > 0f)
		{
			vector3s[2].y = punch(vector3s[1].y, percentage);
		}
		else if (vector3s[1].y < 0f)
		{
			vector3s[2].y = 0f - punch(Mathf.Abs(vector3s[1].y), percentage);
		}
		if (vector3s[1].z > 0f)
		{
			vector3s[2].z = punch(vector3s[1].z, percentage);
		}
		else if (vector3s[1].z < 0f)
		{
			vector3s[2].z = 0f - punch(Mathf.Abs(vector3s[1].z), percentage);
		}
		thisTransform.Translate(vector3s[2] - vector3s[3], space);
		vector3s[3] = vector3s[2];
		if (tweenArguments.Contains("looktarget"))
		{
			thisTransform.eulerAngles = eulerAngles;
		}
		postUpdate = thisTransform.position;
		if (physics)
		{
			thisTransform.position = preUpdate;
			GetComponent<Rigidbody>().MovePosition(postUpdate);
		}
	}

	private void ApplyPunchRotationTargets()
	{
		preUpdate = thisTransform.eulerAngles;
		if (vector3s[1].x > 0f)
		{
			vector3s[2].x = punch(vector3s[1].x, percentage);
		}
		else if (vector3s[1].x < 0f)
		{
			vector3s[2].x = 0f - punch(Mathf.Abs(vector3s[1].x), percentage);
		}
		if (vector3s[1].y > 0f)
		{
			vector3s[2].y = punch(vector3s[1].y, percentage);
		}
		else if (vector3s[1].y < 0f)
		{
			vector3s[2].y = 0f - punch(Mathf.Abs(vector3s[1].y), percentage);
		}
		if (vector3s[1].z > 0f)
		{
			vector3s[2].z = punch(vector3s[1].z, percentage);
		}
		else if (vector3s[1].z < 0f)
		{
			vector3s[2].z = 0f - punch(Mathf.Abs(vector3s[1].z), percentage);
		}
		thisTransform.Rotate(vector3s[2] - vector3s[3], space);
		vector3s[3] = vector3s[2];
		postUpdate = thisTransform.eulerAngles;
		if (physics)
		{
			thisTransform.eulerAngles = preUpdate;
			GetComponent<Rigidbody>().MoveRotation(Quaternion.Euler(postUpdate));
		}
	}

	private void ApplyPunchScaleTargets()
	{
		if (vector3s[1].x > 0f)
		{
			vector3s[2].x = punch(vector3s[1].x, percentage);
		}
		else if (vector3s[1].x < 0f)
		{
			vector3s[2].x = 0f - punch(Mathf.Abs(vector3s[1].x), percentage);
		}
		if (vector3s[1].y > 0f)
		{
			vector3s[2].y = punch(vector3s[1].y, percentage);
		}
		else if (vector3s[1].y < 0f)
		{
			vector3s[2].y = 0f - punch(Mathf.Abs(vector3s[1].y), percentage);
		}
		if (vector3s[1].z > 0f)
		{
			vector3s[2].z = punch(vector3s[1].z, percentage);
		}
		else if (vector3s[1].z < 0f)
		{
			vector3s[2].z = 0f - punch(Mathf.Abs(vector3s[1].z), percentage);
		}
		thisTransform.localScale = vector3s[0] + vector3s[2];
	}

	private IEnumerator TweenDelay()
	{
		delayStarted = Time.time;
		yield return new WaitForSeconds(delay);
		if (wasPaused)
		{
			wasPaused = false;
			TweenStart();
		}
	}

	private void TweenStart()
	{
		CallBack("onstart");
		if (!loop)
		{
			ConflictCheck();
			GenerateTargets();
		}
		if (type == "stab")
		{
			audioSource.PlayOneShot(audioSource.clip);
		}
		if (type == "move" || type == "scale" || type == "rotate" || type == "punch" || type == "shake" || type == "curve" || type == "look")
		{
			EnableKinematic();
		}
		isRunning = true;
	}

	private IEnumerator TweenRestart()
	{
		if (delay > 0f)
		{
			delayStarted = Time.time;
			yield return new WaitForSeconds(delay);
		}
		loop = true;
		TweenStart();
	}

	private void TweenUpdate()
	{
		apply();
		CallBack("onupdate");
		UpdatePercentage();
	}

	private void TweenComplete()
	{
		isRunning = false;
		if (percentage > 0.5f)
		{
			percentage = 1f;
		}
		else
		{
			percentage = 0f;
		}
		apply();
		if (type == "value")
		{
			CallBack("onupdate");
		}
		if (loopType == LoopType.none)
		{
			Dispose();
		}
		else
		{
			TweenLoop();
		}
		CallBack("oncomplete");
	}

	private void TweenLoop()
	{
		DisableKinematic();
		switch (loopType)
		{
		case LoopType.loop:
			percentage = 0f;
			runningTime = 0f;
			apply();
			StartCoroutine("TweenRestart");
			break;
		case LoopType.pingPong:
			reverse = !reverse;
			runningTime = 0f;
			StartCoroutine("TweenRestart");
			break;
		}
	}

	public static Rect RectUpdate(Rect currentValue, Rect targetValue, float speed)
	{
		return new Rect(FloatUpdate(currentValue.x, targetValue.x, speed), FloatUpdate(currentValue.y, targetValue.y, speed), FloatUpdate(currentValue.width, targetValue.width, speed), FloatUpdate(currentValue.height, targetValue.height, speed));
	}

	public static Vector3 Vector3Update(Vector3 currentValue, Vector3 targetValue, float speed)
	{
		Vector3 vector = targetValue - currentValue;
		currentValue += vector * speed * Time.deltaTime;
		return currentValue;
	}

	public static Vector2 Vector2Update(Vector2 currentValue, Vector2 targetValue, float speed)
	{
		Vector2 vector = targetValue - currentValue;
		currentValue += vector * speed * Time.deltaTime;
		return currentValue;
	}

	public static float FloatUpdate(float currentValue, float targetValue, float speed)
	{
		float num = targetValue - currentValue;
		currentValue += num * speed * Time.deltaTime;
		return currentValue;
	}

	public static void FadeUpdate(GameObject target, Hashtable args)
	{
		args["a"] = args["alpha"];
		ColorUpdate(target, args);
	}

	public static void FadeUpdate(GameObject target, float alpha, float time)
	{
		FadeUpdate(target, Hash("alpha", alpha, "time", time));
	}

	public static void ColorUpdate(GameObject target, Hashtable args)
	{
		CleanArgs(args);
		Color[] array = new Color[4];
		if (!args.Contains("includechildren") || (bool)args["includechildren"])
		{
			foreach (Transform item in target.transform)
			{
				ColorUpdate(item.gameObject, args);
			}
		}
		float num;
		if (args.Contains("time"))
		{
			num = (float)args["time"];
			num *= Defaults.updateTimePercentage;
		}
		else
		{
			num = Defaults.updateTime;
		}
		if ((bool)target.GetComponent<GUITexture>())
		{
			array[0] = (array[1] = target.GetComponent<GUITexture>().color);
		}
		else if ((bool)target.GetComponent<GUIText>())
		{
			array[0] = (array[1] = target.GetComponent<GUIText>().material.color);
		}
		else if ((bool)target.GetComponent<Renderer>())
		{
			array[0] = (array[1] = target.GetComponent<Renderer>().material.color);
		}
		else if ((bool)target.GetComponent<Light>())
		{
			array[0] = (array[1] = target.GetComponent<Light>().color);
		}
		if (args.Contains("color"))
		{
			array[1] = (Color)args["color"];
		}
		else
		{
			if (args.Contains("r"))
			{
				array[1].r = (float)args["r"];
			}
			if (args.Contains("g"))
			{
				array[1].g = (float)args["g"];
			}
			if (args.Contains("b"))
			{
				array[1].b = (float)args["b"];
			}
			if (args.Contains("a"))
			{
				array[1].a = (float)args["a"];
			}
		}
		array[3].r = Mathf.SmoothDamp(array[0].r, array[1].r, ref array[2].r, num);
		array[3].g = Mathf.SmoothDamp(array[0].g, array[1].g, ref array[2].g, num);
		array[3].b = Mathf.SmoothDamp(array[0].b, array[1].b, ref array[2].b, num);
		array[3].a = Mathf.SmoothDamp(array[0].a, array[1].a, ref array[2].a, num);
		if ((bool)target.GetComponent<GUITexture>())
		{
			target.GetComponent<GUITexture>().color = array[3];
		}
		else if ((bool)target.GetComponent<GUIText>())
		{
			target.GetComponent<GUIText>().material.color = array[3];
		}
		else if ((bool)target.GetComponent<Renderer>())
		{
			target.GetComponent<Renderer>().material.color = array[3];
		}
		else if ((bool)target.GetComponent<Light>())
		{
			target.GetComponent<Light>().color = array[3];
		}
	}

	public static void ColorUpdate(GameObject target, Color color, float time)
	{
		ColorUpdate(target, Hash("color", color, "time", time));
	}

	public static void AudioUpdate(GameObject target, Hashtable args)
	{
		CleanArgs(args);
		Vector2[] array = new Vector2[4];
		float num;
		if (args.Contains("time"))
		{
			num = (float)args["time"];
			num *= Defaults.updateTimePercentage;
		}
		else
		{
			num = Defaults.updateTime;
		}
		AudioSource audioSource;
		if (args.Contains("audiosource"))
		{
			audioSource = (AudioSource)args["audiosource"];
		}
		else
		{
			if (!target.GetComponent<AudioSource>())
			{
				UnityEngine.Debug.LogError("iTween Error: AudioUpdate requires an AudioSource.");
				return;
			}
			audioSource = target.GetComponent<AudioSource>();
		}
		array[0] = (array[1] = new Vector2(audioSource.volume, audioSource.pitch));
		if (args.Contains("volume"))
		{
			array[1].x = (float)args["volume"];
		}
		if (args.Contains("pitch"))
		{
			array[1].y = (float)args["pitch"];
		}
		array[3].x = Mathf.SmoothDampAngle(array[0].x, array[1].x, ref array[2].x, num);
		array[3].y = Mathf.SmoothDampAngle(array[0].y, array[1].y, ref array[2].y, num);
		audioSource.volume = array[3].x;
		audioSource.pitch = array[3].y;
	}

	public static void AudioUpdate(GameObject target, float volume, float pitch, float time)
	{
		AudioUpdate(target, Hash("volume", volume, "pitch", pitch, "time", time));
	}

	public static void RotateUpdate(GameObject target, Hashtable args)
	{
		CleanArgs(args);
		Vector3[] array = new Vector3[4];
		Vector3 eulerAngles = target.transform.eulerAngles;
		float num;
		if (args.Contains("time"))
		{
			num = (float)args["time"];
			num *= Defaults.updateTimePercentage;
		}
		else
		{
			num = Defaults.updateTime;
		}
		bool flag = ((!args.Contains("islocal")) ? Defaults.isLocal : ((bool)args["islocal"]));
		if (flag)
		{
			array[0] = target.transform.localEulerAngles;
		}
		else
		{
			array[0] = target.transform.eulerAngles;
		}
		if (args.Contains("rotation"))
		{
			if (args["rotation"].GetType() == typeof(Transform))
			{
				Transform transform = (Transform)args["rotation"];
				array[1] = transform.eulerAngles;
			}
			else if (args["rotation"].GetType() == typeof(Vector3))
			{
				array[1] = (Vector3)args["rotation"];
			}
		}
		array[3].x = Mathf.SmoothDampAngle(array[0].x, array[1].x, ref array[2].x, num);
		array[3].y = Mathf.SmoothDampAngle(array[0].y, array[1].y, ref array[2].y, num);
		array[3].z = Mathf.SmoothDampAngle(array[0].z, array[1].z, ref array[2].z, num);
		if (flag)
		{
			target.transform.localEulerAngles = array[3];
		}
		else
		{
			target.transform.eulerAngles = array[3];
		}
		if (target.GetComponent<Rigidbody>() != null)
		{
			Vector3 eulerAngles2 = target.transform.eulerAngles;
			target.transform.eulerAngles = eulerAngles;
			target.GetComponent<Rigidbody>().MoveRotation(Quaternion.Euler(eulerAngles2));
		}
	}

	public static void RotateUpdate(GameObject target, Vector3 rotation, float time)
	{
		RotateUpdate(target, Hash("rotation", rotation, "time", time));
	}

	public static void ScaleUpdate(GameObject target, Hashtable args)
	{
		CleanArgs(args);
		Vector3[] array = new Vector3[4];
		float num;
		if (args.Contains("time"))
		{
			num = (float)args["time"];
			num *= Defaults.updateTimePercentage;
		}
		else
		{
			num = Defaults.updateTime;
		}
		array[0] = (array[1] = target.transform.localScale);
		if (args.Contains("scale"))
		{
			if (args["scale"].GetType() == typeof(Transform))
			{
				Transform transform = (Transform)args["scale"];
				array[1] = transform.localScale;
			}
			else if (args["scale"].GetType() == typeof(Vector3))
			{
				array[1] = (Vector3)args["scale"];
			}
		}
		else
		{
			if (args.Contains("x"))
			{
				array[1].x = (float)args["x"];
			}
			if (args.Contains("y"))
			{
				array[1].y = (float)args["y"];
			}
			if (args.Contains("z"))
			{
				array[1].z = (float)args["z"];
			}
		}
		array[3].x = Mathf.SmoothDamp(array[0].x, array[1].x, ref array[2].x, num);
		array[3].y = Mathf.SmoothDamp(array[0].y, array[1].y, ref array[2].y, num);
		array[3].z = Mathf.SmoothDamp(array[0].z, array[1].z, ref array[2].z, num);
		target.transform.localScale = array[3];
	}

	public static void ScaleUpdate(GameObject target, Vector3 scale, float time)
	{
		ScaleUpdate(target, Hash("scale", scale, "time", time));
	}

	public static void MoveUpdate(GameObject target, Hashtable args)
	{
		CleanArgs(args);
		Vector3[] array = new Vector3[4];
		Vector3 position = target.transform.position;
		float num;
		if (args.Contains("time"))
		{
			num = (float)args["time"];
			num *= Defaults.updateTimePercentage;
		}
		else
		{
			num = Defaults.updateTime;
		}
		bool flag = ((!args.Contains("islocal")) ? Defaults.isLocal : ((bool)args["islocal"]));
		if (flag)
		{
			array[0] = (array[1] = target.transform.localPosition);
		}
		else
		{
			array[0] = (array[1] = target.transform.position);
		}
		if (args.Contains("position"))
		{
			if (args["position"].GetType() == typeof(Transform))
			{
				Transform transform = (Transform)args["position"];
				array[1] = transform.position;
			}
			else if (args["position"].GetType() == typeof(Vector3))
			{
				array[1] = (Vector3)args["position"];
			}
		}
		else
		{
			if (args.Contains("x"))
			{
				array[1].x = (float)args["x"];
			}
			if (args.Contains("y"))
			{
				array[1].y = (float)args["y"];
			}
			if (args.Contains("z"))
			{
				array[1].z = (float)args["z"];
			}
		}
		array[3].x = Mathf.SmoothDamp(array[0].x, array[1].x, ref array[2].x, num);
		array[3].y = Mathf.SmoothDamp(array[0].y, array[1].y, ref array[2].y, num);
		array[3].z = Mathf.SmoothDamp(array[0].z, array[1].z, ref array[2].z, num);
		if (args.Contains("orienttopath") && (bool)args["orienttopath"])
		{
			args["looktarget"] = array[3];
		}
		if (args.Contains("looktarget"))
		{
			LookUpdate(target, args);
		}
		if (flag)
		{
			target.transform.localPosition = array[3];
		}
		else
		{
			target.transform.position = array[3];
		}
		if (target.GetComponent<Rigidbody>() != null)
		{
			Vector3 position2 = target.transform.position;
			target.transform.position = position;
			target.GetComponent<Rigidbody>().MovePosition(position2);
		}
	}

	public static void MoveUpdate(GameObject target, Vector3 position, float time)
	{
		MoveUpdate(target, Hash("position", position, "time", time));
	}

	public static void LookUpdate(GameObject target, Hashtable args)
	{
		CleanArgs(args);
		Vector3[] array = new Vector3[5];
		float num;
		if (args.Contains("looktime"))
		{
			num = (float)args["looktime"];
			num *= Defaults.updateTimePercentage;
		}
		else if (args.Contains("time"))
		{
			num = (float)args["time"] * 0.15f;
			num *= Defaults.updateTimePercentage;
		}
		else
		{
			num = Defaults.updateTime;
		}
		array[0] = target.transform.eulerAngles;
		if (args.Contains("looktarget"))
		{
			if (args["looktarget"].GetType() == typeof(Transform))
			{
				target.transform.LookAt((Transform)args["looktarget"], ((Vector3?)args["up"]) ?? Defaults.up);
			}
			else if (args["looktarget"].GetType() == typeof(Vector3))
			{
				target.transform.LookAt((Vector3)args["looktarget"], ((Vector3?)args["up"]) ?? Defaults.up);
			}
			array[1] = target.transform.eulerAngles;
			target.transform.eulerAngles = array[0];
			array[3].x = Mathf.SmoothDampAngle(array[0].x, array[1].x, ref array[2].x, num);
			array[3].y = Mathf.SmoothDampAngle(array[0].y, array[1].y, ref array[2].y, num);
			array[3].z = Mathf.SmoothDampAngle(array[0].z, array[1].z, ref array[2].z, num);
			target.transform.eulerAngles = array[3];
			if (args.Contains("axis"))
			{
				array[4] = target.transform.eulerAngles;
				switch ((string)args["axis"])
				{
				case "x":
					array[4].y = array[0].y;
					array[4].z = array[0].z;
					break;
				case "y":
					array[4].x = array[0].x;
					array[4].z = array[0].z;
					break;
				case "z":
					array[4].x = array[0].x;
					array[4].y = array[0].y;
					break;
				}
				target.transform.eulerAngles = array[4];
			}
		}
		else
		{
			UnityEngine.Debug.LogError("iTween Error: LookUpdate needs a 'looktarget' property!");
		}
	}

	public static void LookUpdate(GameObject target, Vector3 looktarget, float time)
	{
		LookUpdate(target, Hash("looktarget", looktarget, "time", time));
	}

	public static float PathLength(Transform[] path)
	{
		Vector3[] array = new Vector3[path.Length];
		float num = 0f;
		for (int i = 0; i < path.Length; i++)
		{
			array[i] = path[i].position;
		}
		Vector3[] pts = PathControlPointGenerator(array);
		Vector3 a = Interp(pts, 0f);
		int num2 = path.Length * 20;
		for (int j = 1; j <= num2; j++)
		{
			float t = (float)j / (float)num2;
			Vector3 vector = Interp(pts, t);
			num += Vector3.Distance(a, vector);
			a = vector;
		}
		return num;
	}

	public static float PathLength(Vector3[] path)
	{
		float num = 0f;
		Vector3[] pts = PathControlPointGenerator(path);
		Vector3 a = Interp(pts, 0f);
		int num2 = path.Length * 20;
		for (int i = 1; i <= num2; i++)
		{
			float t = (float)i / (float)num2;
			Vector3 vector = Interp(pts, t);
			num += Vector3.Distance(a, vector);
			a = vector;
		}
		return num;
	}

	public static Texture2D CameraTexture(Color color)
	{
		Texture2D texture2D = new Texture2D(Screen.width, Screen.height, TextureFormat.ARGB32, mipChain: false);
		Color[] array = new Color[Screen.width * Screen.height];
		for (int i = 0; i < array.Length; i++)
		{
			array[i] = color;
		}
		texture2D.SetPixels(array);
		texture2D.Apply();
		return texture2D;
	}

	public static void PutOnPath(GameObject target, Vector3[] path, float percent)
	{
		target.transform.position = Interp(PathControlPointGenerator(path), percent);
	}

	public static void PutOnPath(Transform target, Vector3[] path, float percent)
	{
		target.position = Interp(PathControlPointGenerator(path), percent);
	}

	public static void PutOnPath(GameObject target, Transform[] path, float percent)
	{
		Vector3[] array = new Vector3[path.Length];
		for (int i = 0; i < path.Length; i++)
		{
			array[i] = path[i].position;
		}
		target.transform.position = Interp(PathControlPointGenerator(array), percent);
	}

	public static void PutOnPath(Transform target, Transform[] path, float percent)
	{
		Vector3[] array = new Vector3[path.Length];
		for (int i = 0; i < path.Length; i++)
		{
			array[i] = path[i].position;
		}
		target.position = Interp(PathControlPointGenerator(array), percent);
	}

	public static Vector3 PointOnPath(Transform[] path, float percent)
	{
		Vector3[] array = new Vector3[path.Length];
		for (int i = 0; i < path.Length; i++)
		{
			array[i] = path[i].position;
		}
		return Interp(PathControlPointGenerator(array), percent);
	}

	public static void DrawLine(Vector3[] line)
	{
		if (line.Length != 0)
		{
			DrawLineHelper(line, Defaults.color, "gizmos");
		}
	}

	public static void DrawLine(Vector3[] line, Color color)
	{
		if (line.Length != 0)
		{
			DrawLineHelper(line, color, "gizmos");
		}
	}

	public static void DrawLine(Transform[] line)
	{
		if (line.Length != 0)
		{
			Vector3[] array = new Vector3[line.Length];
			for (int i = 0; i < line.Length; i++)
			{
				array[i] = line[i].position;
			}
			DrawLineHelper(array, Defaults.color, "gizmos");
		}
	}

	public static void DrawLine(Transform[] line, Color color)
	{
		if (line.Length != 0)
		{
			Vector3[] array = new Vector3[line.Length];
			for (int i = 0; i < line.Length; i++)
			{
				array[i] = line[i].position;
			}
			DrawLineHelper(array, color, "gizmos");
		}
	}

	public static void DrawLineGizmos(Vector3[] line)
	{
		if (line.Length != 0)
		{
			DrawLineHelper(line, Defaults.color, "gizmos");
		}
	}

	public static void DrawLineGizmos(Vector3[] line, Color color)
	{
		if (line.Length != 0)
		{
			DrawLineHelper(line, color, "gizmos");
		}
	}

	public static void DrawLineGizmos(Transform[] line)
	{
		if (line.Length != 0)
		{
			Vector3[] array = new Vector3[line.Length];
			for (int i = 0; i < line.Length; i++)
			{
				array[i] = line[i].position;
			}
			DrawLineHelper(array, Defaults.color, "gizmos");
		}
	}

	public static void DrawLineGizmos(Transform[] line, Color color)
	{
		if (line.Length != 0)
		{
			Vector3[] array = new Vector3[line.Length];
			for (int i = 0; i < line.Length; i++)
			{
				array[i] = line[i].position;
			}
			DrawLineHelper(array, color, "gizmos");
		}
	}

	public static void DrawLineHandles(Vector3[] line)
	{
		if (line.Length != 0)
		{
			DrawLineHelper(line, Defaults.color, "handles");
		}
	}

	public static void DrawLineHandles(Vector3[] line, Color color)
	{
		if (line.Length != 0)
		{
			DrawLineHelper(line, color, "handles");
		}
	}

	public static void DrawLineHandles(Transform[] line)
	{
		if (line.Length != 0)
		{
			Vector3[] array = new Vector3[line.Length];
			for (int i = 0; i < line.Length; i++)
			{
				array[i] = line[i].position;
			}
			DrawLineHelper(array, Defaults.color, "handles");
		}
	}

	public static void DrawLineHandles(Transform[] line, Color color)
	{
		if (line.Length != 0)
		{
			Vector3[] array = new Vector3[line.Length];
			for (int i = 0; i < line.Length; i++)
			{
				array[i] = line[i].position;
			}
			DrawLineHelper(array, color, "handles");
		}
	}

	public static Vector3 PointOnPath(Vector3[] path, float percent)
	{
		return Interp(PathControlPointGenerator(path), percent);
	}

	public static void DrawPath(Vector3[] path)
	{
		if (path.Length != 0)
		{
			DrawPathHelper(path, Defaults.color, "gizmos");
		}
	}

	public static void DrawPath(Vector3[] path, Color color)
	{
		if (path.Length != 0)
		{
			DrawPathHelper(path, color, "gizmos");
		}
	}

	public static void DrawPath(Transform[] path)
	{
		if (path.Length != 0)
		{
			Vector3[] array = new Vector3[path.Length];
			for (int i = 0; i < path.Length; i++)
			{
				array[i] = path[i].position;
			}
			DrawPathHelper(array, Defaults.color, "gizmos");
		}
	}

	public static void DrawPath(Transform[] path, Color color)
	{
		if (path.Length != 0)
		{
			Vector3[] array = new Vector3[path.Length];
			for (int i = 0; i < path.Length; i++)
			{
				array[i] = path[i].position;
			}
			DrawPathHelper(array, color, "gizmos");
		}
	}

	public static void DrawPathGizmos(Vector3[] path)
	{
		if (path.Length != 0)
		{
			DrawPathHelper(path, Defaults.color, "gizmos");
		}
	}

	public static void DrawPathGizmos(Vector3[] path, Color color)
	{
		if (path.Length != 0)
		{
			DrawPathHelper(path, color, "gizmos");
		}
	}

	public static void DrawPathGizmos(Transform[] path)
	{
		if (path.Length != 0)
		{
			Vector3[] array = new Vector3[path.Length];
			for (int i = 0; i < path.Length; i++)
			{
				array[i] = path[i].position;
			}
			DrawPathHelper(array, Defaults.color, "gizmos");
		}
	}

	public static void DrawPathGizmos(Transform[] path, Color color)
	{
		if (path.Length != 0)
		{
			Vector3[] array = new Vector3[path.Length];
			for (int i = 0; i < path.Length; i++)
			{
				array[i] = path[i].position;
			}
			DrawPathHelper(array, color, "gizmos");
		}
	}

	public static void DrawPathHandles(Vector3[] path)
	{
		if (path.Length != 0)
		{
			DrawPathHelper(path, Defaults.color, "handles");
		}
	}

	public static void DrawPathHandles(Vector3[] path, Color color)
	{
		if (path.Length != 0)
		{
			DrawPathHelper(path, color, "handles");
		}
	}

	public static void DrawPathHandles(Transform[] path)
	{
		if (path.Length != 0)
		{
			Vector3[] array = new Vector3[path.Length];
			for (int i = 0; i < path.Length; i++)
			{
				array[i] = path[i].position;
			}
			DrawPathHelper(array, Defaults.color, "handles");
		}
	}

	public static void DrawPathHandles(Transform[] path, Color color)
	{
		if (path.Length != 0)
		{
			Vector3[] array = new Vector3[path.Length];
			for (int i = 0; i < path.Length; i++)
			{
				array[i] = path[i].position;
			}
			DrawPathHelper(array, color, "handles");
		}
	}

	public static void CameraFadeDepth(int depth)
	{
		if ((bool)cameraFade)
		{
			cameraFade.transform.position = new Vector3(cameraFade.transform.position.x, cameraFade.transform.position.y, depth);
		}
	}

	public static void CameraFadeDestroy()
	{
		if ((bool)cameraFade)
		{
			UnityEngine.Object.Destroy(cameraFade);
		}
	}

	public static void CameraFadeSwap(Texture2D texture)
	{
		if ((bool)cameraFade)
		{
			cameraFade.GetComponent<GUITexture>().texture = texture;
		}
	}

	public static GameObject CameraFadeAdd(Texture2D texture, int depth)
	{
		if ((bool)cameraFade)
		{
			return null;
		}
		cameraFade = new GameObject("iTween Camera Fade");
		cameraFade.transform.position = new Vector3(0.5f, 0.5f, depth);
		cameraFade.AddComponent<GUITexture>();
		cameraFade.GetComponent<GUITexture>().texture = texture;
		cameraFade.GetComponent<GUITexture>().color = new Color(0.5f, 0.5f, 0.5f, 0f);
		return cameraFade;
	}

	public static GameObject CameraFadeAdd(Texture2D texture)
	{
		if ((bool)cameraFade)
		{
			return null;
		}
		cameraFade = new GameObject("iTween Camera Fade");
		cameraFade.transform.position = new Vector3(0.5f, 0.5f, Defaults.cameraFadeDepth);
		cameraFade.AddComponent<GUITexture>();
		cameraFade.GetComponent<GUITexture>().texture = texture;
		cameraFade.GetComponent<GUITexture>().color = new Color(0.5f, 0.5f, 0.5f, 0f);
		return cameraFade;
	}

	public static GameObject CameraFadeAdd()
	{
		if ((bool)cameraFade)
		{
			return null;
		}
		cameraFade = new GameObject("iTween Camera Fade");
		cameraFade.transform.position = new Vector3(0.5f, 0.5f, Defaults.cameraFadeDepth);
		cameraFade.AddComponent<GUITexture>();
		cameraFade.GetComponent<GUITexture>().texture = CameraTexture(Color.black);
		cameraFade.GetComponent<GUITexture>().color = new Color(0.5f, 0.5f, 0.5f, 0f);
		return cameraFade;
	}

	public static void Resume(GameObject target)
	{
		Component[] components = target.GetComponents<iTween>();
		components = components;
		for (int i = 0; i < components.Length; i++)
		{
			((iTween)components[i]).enabled = true;
		}
	}

	public static void Resume(GameObject target, bool includechildren)
	{
		Resume(target);
		if (!includechildren)
		{
			return;
		}
		foreach (Transform item in target.transform)
		{
			Resume(item.gameObject, includechildren: true);
		}
	}

	public static void Resume(GameObject target, string type)
	{
		Component[] components = target.GetComponents<iTween>();
		components = components;
		for (int i = 0; i < components.Length; i++)
		{
			iTween iTween2 = (iTween)components[i];
			if ((iTween2.type + iTween2.method).Substring(0, type.Length).ToLower() == type.ToLower())
			{
				iTween2.enabled = true;
			}
		}
	}

	public static void Resume(GameObject target, string type, bool includechildren)
	{
		Component[] components = target.GetComponents<iTween>();
		components = components;
		for (int i = 0; i < components.Length; i++)
		{
			iTween iTween2 = (iTween)components[i];
			if ((iTween2.type + iTween2.method).Substring(0, type.Length).ToLower() == type.ToLower())
			{
				iTween2.enabled = true;
			}
		}
		if (!includechildren)
		{
			return;
		}
		foreach (Transform item in target.transform)
		{
			Resume(item.gameObject, type, includechildren: true);
		}
	}

	public static void Resume()
	{
		for (int i = 0; i < tweens.Count; i++)
		{
			Resume((GameObject)tweens[i]["target"]);
		}
	}

	public static void Resume(string type)
	{
		ArrayList arrayList = new ArrayList();
		for (int i = 0; i < tweens.Count; i++)
		{
			GameObject value = (GameObject)tweens[i]["target"];
			arrayList.Insert(arrayList.Count, value);
		}
		for (int j = 0; j < arrayList.Count; j++)
		{
			Resume((GameObject)arrayList[j], type);
		}
	}

	public static void Pause(GameObject target)
	{
		Component[] components = target.GetComponents<iTween>();
		components = components;
		for (int i = 0; i < components.Length; i++)
		{
			iTween iTween2 = (iTween)components[i];
			if (iTween2.delay > 0f)
			{
				iTween2.delay -= Time.time - iTween2.delayStarted;
				iTween2.StopCoroutine("TweenDelay");
			}
			iTween2.isPaused = true;
			iTween2.enabled = false;
		}
	}

	public static void Pause(GameObject target, bool includechildren)
	{
		Pause(target);
		if (!includechildren)
		{
			return;
		}
		foreach (Transform item in target.transform)
		{
			Pause(item.gameObject, includechildren: true);
		}
	}

	public static void Pause(GameObject target, string type)
	{
		Component[] components = target.GetComponents<iTween>();
		components = components;
		for (int i = 0; i < components.Length; i++)
		{
			iTween iTween2 = (iTween)components[i];
			if ((iTween2.type + iTween2.method).Substring(0, type.Length).ToLower() == type.ToLower())
			{
				if (iTween2.delay > 0f)
				{
					iTween2.delay -= Time.time - iTween2.delayStarted;
					iTween2.StopCoroutine("TweenDelay");
				}
				iTween2.isPaused = true;
				iTween2.enabled = false;
			}
		}
	}

	public static void Pause(GameObject target, string type, bool includechildren)
	{
		Component[] components = target.GetComponents<iTween>();
		components = components;
		for (int i = 0; i < components.Length; i++)
		{
			iTween iTween2 = (iTween)components[i];
			if ((iTween2.type + iTween2.method).Substring(0, type.Length).ToLower() == type.ToLower())
			{
				if (iTween2.delay > 0f)
				{
					iTween2.delay -= Time.time - iTween2.delayStarted;
					iTween2.StopCoroutine("TweenDelay");
				}
				iTween2.isPaused = true;
				iTween2.enabled = false;
			}
		}
		if (!includechildren)
		{
			return;
		}
		foreach (Transform item in target.transform)
		{
			Pause(item.gameObject, type, includechildren: true);
		}
	}

	public static void Pause()
	{
		for (int i = 0; i < tweens.Count; i++)
		{
			Pause((GameObject)tweens[i]["target"]);
		}
	}

	public static void Pause(string type)
	{
		ArrayList arrayList = new ArrayList();
		for (int i = 0; i < tweens.Count; i++)
		{
			GameObject value = (GameObject)tweens[i]["target"];
			arrayList.Insert(arrayList.Count, value);
		}
		for (int j = 0; j < arrayList.Count; j++)
		{
			Pause((GameObject)arrayList[j], type);
		}
	}

	public static int Count()
	{
		return tweens.Count;
	}

	public static int Count(string type)
	{
		int num = 0;
		for (int i = 0; i < tweens.Count; i++)
		{
			Hashtable hashtable = tweens[i];
			if (((string)hashtable["type"] + (string)hashtable["method"]).Substring(0, type.Length).ToLower() == type.ToLower())
			{
				num++;
			}
		}
		return num;
	}

	public static int Count(GameObject target)
	{
		Component[] components = target.GetComponents<iTween>();
		return components.Length;
	}

	public static int Count(GameObject target, string type)
	{
		int num = 0;
		Component[] components = target.GetComponents<iTween>();
		components = components;
		for (int i = 0; i < components.Length; i++)
		{
			iTween iTween2 = (iTween)components[i];
			if ((iTween2.type + iTween2.method).Substring(0, type.Length).ToLower() == type.ToLower())
			{
				num++;
			}
		}
		return num;
	}

	public static void Stop()
	{
		for (int i = 0; i < tweens.Count; i++)
		{
			Stop((GameObject)tweens[i]["target"]);
		}
		tweens.Clear();
	}

	public static void Stop(string type)
	{
		ArrayList arrayList = new ArrayList();
		for (int i = 0; i < tweens.Count; i++)
		{
			GameObject value = (GameObject)tweens[i]["target"];
			arrayList.Insert(arrayList.Count, value);
		}
		for (int j = 0; j < arrayList.Count; j++)
		{
			Stop((GameObject)arrayList[j], type);
		}
	}

	public static void StopByName(string name)
	{
		ArrayList arrayList = new ArrayList();
		for (int i = 0; i < tweens.Count; i++)
		{
			GameObject value = (GameObject)tweens[i]["target"];
			arrayList.Insert(arrayList.Count, value);
		}
		for (int j = 0; j < arrayList.Count; j++)
		{
			StopByName((GameObject)arrayList[j], name);
		}
	}

	public static void Stop(GameObject target)
	{
		Component[] components = target.GetComponents<iTween>();
		components = components;
		for (int i = 0; i < components.Length; i++)
		{
			((iTween)components[i]).Dispose();
		}
	}

	public static void Stop(GameObject target, bool includechildren)
	{
		Stop(target);
		if (!includechildren)
		{
			return;
		}
		foreach (Transform item in target.transform)
		{
			Stop(item.gameObject, includechildren: true);
		}
	}

	public static void Stop(GameObject target, string type)
	{
		Component[] components = target.GetComponents<iTween>();
		components = components;
		for (int i = 0; i < components.Length; i++)
		{
			iTween iTween2 = (iTween)components[i];
			if ((iTween2.type + iTween2.method).Substring(0, type.Length).ToLower() == type.ToLower())
			{
				iTween2.Dispose();
			}
		}
	}

	public static void StopByName(GameObject target, string name)
	{
		Component[] components = target.GetComponents<iTween>();
		components = components;
		for (int i = 0; i < components.Length; i++)
		{
			iTween iTween2 = (iTween)components[i];
			if (iTween2._name == name)
			{
				iTween2.Dispose();
			}
		}
	}

	public static void Stop(GameObject target, string type, bool includechildren)
	{
		Component[] components = target.GetComponents<iTween>();
		components = components;
		for (int i = 0; i < components.Length; i++)
		{
			iTween iTween2 = (iTween)components[i];
			if ((iTween2.type + iTween2.method).Substring(0, type.Length).ToLower() == type.ToLower())
			{
				iTween2.Dispose();
			}
		}
		if (!includechildren)
		{
			return;
		}
		foreach (Transform item in target.transform)
		{
			Stop(item.gameObject, type, includechildren: true);
		}
	}

	public static void StopByName(GameObject target, string name, bool includechildren)
	{
		Component[] components = target.GetComponents<iTween>();
		components = components;
		for (int i = 0; i < components.Length; i++)
		{
			iTween iTween2 = (iTween)components[i];
			if (iTween2._name == name)
			{
				iTween2.Dispose();
			}
		}
		if (!includechildren)
		{
			return;
		}
		foreach (Transform item in target.transform)
		{
			StopByName(item.gameObject, name, includechildren: true);
		}
	}

	public static Hashtable Hash(params object[] args)
	{
		Hashtable hashtable = new Hashtable(args.Length / 2);
		if (args.Length % 2 != 0)
		{
			UnityEngine.Debug.LogError("Tween Error: Hash requires an even number of arguments!");
			return null;
		}
		for (int i = 0; i < args.Length - 1; i += 2)
		{
			hashtable.Add(args[i], args[i + 1]);
		}
		return hashtable;
	}

	private iTween(Hashtable h)
	{
		tweenArguments = h;
	}

	private void Awake()
	{
		thisTransform = base.transform;
		RetrieveArgs();
		lastRealTime = Time.realtimeSinceStartup;
	}

	private IEnumerator Start()
	{
		if (delay > 0f)
		{
			yield return StartCoroutine("TweenDelay");
		}
		TweenStart();
	}

	private void Update()
	{
		if (!isRunning || physics)
		{
			return;
		}
		if (!reverse)
		{
			if (percentage < 1f)
			{
				TweenUpdate();
			}
			else
			{
				TweenComplete();
			}
		}
		else if (percentage > 0f)
		{
			TweenUpdate();
		}
		else
		{
			TweenComplete();
		}
	}

	private void FixedUpdate()
	{
		if (!isRunning || !physics)
		{
			return;
		}
		if (!reverse)
		{
			if (percentage < 1f)
			{
				TweenUpdate();
			}
			else
			{
				TweenComplete();
			}
		}
		else if (percentage > 0f)
		{
			TweenUpdate();
		}
		else
		{
			TweenComplete();
		}
	}

	private void LateUpdate()
	{
		if (tweenArguments.Contains("looktarget") && isRunning && (type == "move" || type == "shake" || type == "punch"))
		{
			LookUpdate(base.gameObject, tweenArguments);
		}
	}

	private void OnEnable()
	{
		if (isRunning)
		{
			EnableKinematic();
		}
		if (isPaused)
		{
			isPaused = false;
			if (delay > 0f)
			{
				wasPaused = true;
				ResumeDelay();
			}
		}
	}

	private void OnDisable()
	{
		DisableKinematic();
	}

	private static void DrawLineHelper(Vector3[] line, Color color, string method)
	{
		Gizmos.color = color;
		for (int i = 0; i < line.Length - 1; i++)
		{
			if (method == "gizmos")
			{
				Gizmos.DrawLine(line[i], line[i + 1]);
			}
			else if (method == "handles")
			{
				UnityEngine.Debug.LogError("iTween Error: Drawing a line with Handles is temporarily disabled because of compatability issues with Unity 2.6!");
			}
		}
	}

	private static void DrawPathHelper(Vector3[] path, Color color, string method)
	{
		Vector3[] pts = PathControlPointGenerator(path);
		Vector3 to = Interp(pts, 0f);
		Gizmos.color = color;
		int num = path.Length * 20;
		for (int i = 1; i <= num; i++)
		{
			float t = (float)i / (float)num;
			Vector3 vector = Interp(pts, t);
			if (method == "gizmos")
			{
				Gizmos.DrawLine(vector, to);
			}
			else if (method == "handles")
			{
				UnityEngine.Debug.LogError("iTween Error: Drawing a path with Handles is temporarily disabled because of compatability issues with Unity 2.6!");
			}
			to = vector;
		}
	}

	private static Vector3[] PathControlPointGenerator(Vector3[] path)
	{
		int num = 2;
		Vector3[] array = new Vector3[path.Length + num];
		Array.Copy(path, 0, array, 1, path.Length);
		array[0] = array[1] + (array[1] - array[2]);
		array[array.Length - 1] = array[array.Length - 2] + (array[array.Length - 2] - array[array.Length - 3]);
		if (array[1] == array[array.Length - 2])
		{
			Vector3[] array2 = new Vector3[array.Length];
			Array.Copy(array, array2, array.Length);
			array2[0] = array2[array2.Length - 3];
			array2[array2.Length - 1] = array2[2];
			array = new Vector3[array2.Length];
			Array.Copy(array2, array, array2.Length);
		}
		return array;
	}

	private static Vector3 Interp(Vector3[] pts, float t)
	{
		int num = pts.Length - 3;
		int num2 = Mathf.Min(Mathf.FloorToInt(t * (float)num), num - 1);
		float num3 = t * (float)num - (float)num2;
		Vector3 vector = pts[num2];
		Vector3 vector2 = pts[num2 + 1];
		Vector3 vector3 = pts[num2 + 2];
		Vector3 vector4 = pts[num2 + 3];
		return 0.5f * ((-vector + 3f * vector2 - 3f * vector3 + vector4) * (num3 * num3 * num3) + (2f * vector - 5f * vector2 + 4f * vector3 - vector4) * (num3 * num3) + (-vector + vector3) * num3 + 2f * vector2);
	}

	private static void Launch(GameObject target, Hashtable args)
	{
		if (!args.Contains("id"))
		{
			args["id"] = GenerateID();
		}
		if (!args.Contains("target"))
		{
			args["target"] = target;
		}
		tweens.Insert(0, args);
		if ((bool)target)
		{
			target.AddComponent<iTween>();
		}
	}

	private static Hashtable CleanArgs(Hashtable args)
	{
		Hashtable hashtable = new Hashtable(args.Count);
		Hashtable hashtable2 = new Hashtable(args.Count);
		foreach (DictionaryEntry arg in args)
		{
			hashtable.Add(arg.Key, arg.Value);
		}
		foreach (DictionaryEntry item in hashtable)
		{
			if (item.Value.GetType() == typeof(int))
			{
				float num = (int)item.Value;
				args[item.Key] = num;
			}
			if (item.Value.GetType() == typeof(double))
			{
				float num2 = (float)(double)item.Value;
				args[item.Key] = num2;
			}
		}
		foreach (DictionaryEntry arg2 in args)
		{
			hashtable2.Add(arg2.Key.ToString().ToLower(), arg2.Value);
		}
		args = hashtable2;
		return args;
	}

	private static string GenerateID()
	{
		return Guid.NewGuid().ToString();
	}

	private void RetrieveArgs()
	{
		foreach (Hashtable tween in tweens)
		{
			if ((GameObject)tween["target"] == base.gameObject)
			{
				tweenArguments = tween;
				break;
			}
		}
		id = (string)tweenArguments["id"];
		type = (string)tweenArguments["type"];
		_name = (string)tweenArguments["name"];
		method = (string)tweenArguments["method"];
		if (tweenArguments.Contains("time"))
		{
			time = (float)tweenArguments["time"];
		}
		else
		{
			time = Defaults.time;
		}
		if (GetComponent<Rigidbody>() != null)
		{
			physics = true;
		}
		if (tweenArguments.Contains("delay"))
		{
			delay = (float)tweenArguments["delay"];
		}
		else
		{
			delay = Defaults.delay;
		}
		if (tweenArguments.Contains("namedcolorvalue"))
		{
			if (tweenArguments["namedcolorvalue"].GetType() == typeof(NamedValueColor))
			{
				namedcolorvalue = (NamedValueColor)tweenArguments["namedcolorvalue"];
			}
			else
			{
				try
				{
					namedcolorvalue = (NamedValueColor)Enum.Parse(typeof(NamedValueColor), (string)tweenArguments["namedcolorvalue"], ignoreCase: true);
				}
				catch
				{
					UnityEngine.Debug.LogWarning("iTween: Unsupported namedcolorvalue supplied! Default will be used.");
					namedcolorvalue = NamedValueColor._Color;
				}
			}
		}
		else
		{
			namedcolorvalue = Defaults.namedColorValue;
		}
		if (tweenArguments.Contains("looptype"))
		{
			if (tweenArguments["looptype"].GetType() == typeof(LoopType))
			{
				loopType = (LoopType)tweenArguments["looptype"];
			}
			else
			{
				try
				{
					loopType = (LoopType)Enum.Parse(typeof(LoopType), (string)tweenArguments["looptype"], ignoreCase: true);
				}
				catch
				{
					UnityEngine.Debug.LogWarning("iTween: Unsupported loopType supplied! Default will be used.");
					loopType = LoopType.none;
				}
			}
		}
		else
		{
			loopType = LoopType.none;
		}
		if (tweenArguments.Contains("easetype"))
		{
			if (tweenArguments["easetype"].GetType() == typeof(EaseType))
			{
				easeType = (EaseType)tweenArguments["easetype"];
			}
			else
			{
				try
				{
					easeType = (EaseType)Enum.Parse(typeof(EaseType), (string)tweenArguments["easetype"], ignoreCase: true);
				}
				catch
				{
					UnityEngine.Debug.LogWarning("iTween: Unsupported easeType supplied! Default will be used.");
					easeType = Defaults.easeType;
				}
			}
		}
		else
		{
			easeType = Defaults.easeType;
		}
		if (tweenArguments.Contains("space"))
		{
			if (tweenArguments["space"].GetType() == typeof(Space))
			{
				space = (Space)tweenArguments["space"];
			}
			else
			{
				try
				{
					space = (Space)Enum.Parse(typeof(Space), (string)tweenArguments["space"], ignoreCase: true);
				}
				catch
				{
					UnityEngine.Debug.LogWarning("iTween: Unsupported space supplied! Default will be used.");
					space = Defaults.space;
				}
			}
		}
		else
		{
			space = Defaults.space;
		}
		if (tweenArguments.Contains("islocal"))
		{
			isLocal = (bool)tweenArguments["islocal"];
		}
		else
		{
			isLocal = Defaults.isLocal;
		}
		if (tweenArguments.Contains("ignoretimescale"))
		{
			useRealTime = (bool)tweenArguments["ignoretimescale"];
		}
		else
		{
			useRealTime = Defaults.useRealTime;
		}
		GetEasingFunction();
	}

	private void GetEasingFunction()
	{
		switch (easeType)
		{
		case EaseType.easeInQuad:
			ease = easeInQuad;
			break;
		case EaseType.easeOutQuad:
			ease = easeOutQuad;
			break;
		case EaseType.easeInOutQuad:
			ease = easeInOutQuad;
			break;
		case EaseType.easeInCubic:
			ease = easeInCubic;
			break;
		case EaseType.easeOutCubic:
			ease = easeOutCubic;
			break;
		case EaseType.easeInOutCubic:
			ease = easeInOutCubic;
			break;
		case EaseType.easeInQuart:
			ease = easeInQuart;
			break;
		case EaseType.easeOutQuart:
			ease = easeOutQuart;
			break;
		case EaseType.easeInOutQuart:
			ease = easeInOutQuart;
			break;
		case EaseType.easeInQuint:
			ease = easeInQuint;
			break;
		case EaseType.easeOutQuint:
			ease = easeOutQuint;
			break;
		case EaseType.easeInOutQuint:
			ease = easeInOutQuint;
			break;
		case EaseType.easeInSine:
			ease = easeInSine;
			break;
		case EaseType.easeOutSine:
			ease = easeOutSine;
			break;
		case EaseType.easeInOutSine:
			ease = easeInOutSine;
			break;
		case EaseType.easeInExpo:
			ease = easeInExpo;
			break;
		case EaseType.easeOutExpo:
			ease = easeOutExpo;
			break;
		case EaseType.easeInOutExpo:
			ease = easeInOutExpo;
			break;
		case EaseType.easeInCirc:
			ease = easeInCirc;
			break;
		case EaseType.easeOutCirc:
			ease = easeOutCirc;
			break;
		case EaseType.easeInOutCirc:
			ease = easeInOutCirc;
			break;
		case EaseType.linear:
			ease = linear;
			break;
		case EaseType.spring:
			ease = spring;
			break;
		case EaseType.easeInBounce:
			ease = easeInBounce;
			break;
		case EaseType.easeOutBounce:
			ease = easeOutBounce;
			break;
		case EaseType.easeInOutBounce:
			ease = easeInOutBounce;
			break;
		case EaseType.easeInBack:
			ease = easeInBack;
			break;
		case EaseType.easeOutBack:
			ease = easeOutBack;
			break;
		case EaseType.easeInOutBack:
			ease = easeInOutBack;
			break;
		case EaseType.easeInElastic:
			ease = easeInElastic;
			break;
		case EaseType.easeOutElastic:
			ease = easeOutElastic;
			break;
		case EaseType.easeInOutElastic:
			ease = easeInOutElastic;
			break;
		}
	}

	private void UpdatePercentage()
	{
		if (useRealTime)
		{
			runningTime += Time.realtimeSinceStartup - lastRealTime;
		}
		else
		{
			runningTime += Time.deltaTime;
		}
		if (reverse)
		{
			percentage = 1f - runningTime / time;
		}
		else
		{
			percentage = runningTime / time;
		}
		lastRealTime = Time.realtimeSinceStartup;
	}

	private void CallBack(string callbackType)
	{
		if (tweenArguments.Contains(callbackType) && !tweenArguments.Contains("ischild"))
		{
			GameObject gameObject = ((!tweenArguments.Contains(callbackType + "target")) ? base.gameObject : ((GameObject)tweenArguments[callbackType + "target"]));
			if (tweenArguments[callbackType].GetType() == typeof(string))
			{
				gameObject.SendMessage((string)tweenArguments[callbackType], tweenArguments[callbackType + "params"], SendMessageOptions.DontRequireReceiver);
				return;
			}
			UnityEngine.Debug.LogError("iTween Error: Callback method references must be passed as a String!");
			UnityEngine.Object.Destroy(this);
		}
	}

	private void Dispose()
	{
		for (int i = 0; i < tweens.Count; i++)
		{
			if ((string)tweens[i]["id"] == id)
			{
				tweens.RemoveAt(i);
				break;
			}
		}
		UnityEngine.Object.Destroy(this);
	}

	private void ConflictCheck()
	{
		Component[] components = GetComponents<iTween>();
		components = components;
		for (int i = 0; i < components.Length; i++)
		{
			iTween iTween2 = (iTween)components[i];
			if (iTween2.type == "value")
			{
				break;
			}
			if (!iTween2.isRunning || !(iTween2.type == type))
			{
				continue;
			}
			if (iTween2.method != method)
			{
				break;
			}
			if (iTween2.tweenArguments.Count != tweenArguments.Count)
			{
				iTween2.Dispose();
				break;
			}
			foreach (DictionaryEntry tweenArgument in tweenArguments)
			{
				if (!iTween2.tweenArguments.Contains(tweenArgument.Key))
				{
					iTween2.Dispose();
					return;
				}
				if (!iTween2.tweenArguments[tweenArgument.Key].Equals(tweenArguments[tweenArgument.Key]) && (string)tweenArgument.Key != "id")
				{
					iTween2.Dispose();
					return;
				}
			}
			Dispose();
		}
	}

	private void EnableKinematic()
	{
	}

	private void DisableKinematic()
	{
	}

	private void ResumeDelay()
	{
		StartCoroutine("TweenDelay");
	}

	private float linear(float start, float end, float value)
	{
		return Mathf.Lerp(start, end, value);
	}

	private float clerp(float start, float end, float value)
	{
		float num = 0f;
		float num2 = 360f;
		float num3 = Mathf.Abs((num2 - num) * 0.5f);
		float num4 = 0f;
		float num5 = 0f;
		if (end - start < 0f - num3)
		{
			num5 = (num2 - start + end) * value;
			return start + num5;
		}
		if (end - start > num3)
		{
			num5 = (0f - (num2 - end + start)) * value;
			return start + num5;
		}
		return start + (end - start) * value;
	}

	private float spring(float start, float end, float value)
	{
		value = Mathf.Clamp01(value);
		value = (Mathf.Sin(value * (float)Math.PI * (0.2f + 2.5f * value * value * value)) * Mathf.Pow(1f - value, 2.2f) + value) * (1f + 1.2f * (1f - value));
		return start + (end - start) * value;
	}

	private float easeInQuad(float start, float end, float value)
	{
		end -= start;
		return end * value * value + start;
	}

	private float easeOutQuad(float start, float end, float value)
	{
		end -= start;
		return (0f - end) * value * (value - 2f) + start;
	}

	private float easeInOutQuad(float start, float end, float value)
	{
		value /= 0.5f;
		end -= start;
		if (value < 1f)
		{
			return end * 0.5f * value * value + start;
		}
		value -= 1f;
		return (0f - end) * 0.5f * (value * (value - 2f) - 1f) + start;
	}

	private float easeInCubic(float start, float end, float value)
	{
		end -= start;
		return end * value * value * value + start;
	}

	private float easeOutCubic(float start, float end, float value)
	{
		value -= 1f;
		end -= start;
		return end * (value * value * value + 1f) + start;
	}

	private float easeInOutCubic(float start, float end, float value)
	{
		value /= 0.5f;
		end -= start;
		if (value < 1f)
		{
			return end * 0.5f * value * value * value + start;
		}
		value -= 2f;
		return end * 0.5f * (value * value * value + 2f) + start;
	}

	private float easeInQuart(float start, float end, float value)
	{
		end -= start;
		return end * value * value * value * value + start;
	}

	private float easeOutQuart(float start, float end, float value)
	{
		value -= 1f;
		end -= start;
		return (0f - end) * (value * value * value * value - 1f) + start;
	}

	private float easeInOutQuart(float start, float end, float value)
	{
		value /= 0.5f;
		end -= start;
		if (value < 1f)
		{
			return end * 0.5f * value * value * value * value + start;
		}
		value -= 2f;
		return (0f - end) * 0.5f * (value * value * value * value - 2f) + start;
	}

	private float easeInQuint(float start, float end, float value)
	{
		end -= start;
		return end * value * value * value * value * value + start;
	}

	private float easeOutQuint(float start, float end, float value)
	{
		value -= 1f;
		end -= start;
		return end * (value * value * value * value * value + 1f) + start;
	}

	private float easeInOutQuint(float start, float end, float value)
	{
		value /= 0.5f;
		end -= start;
		if (value < 1f)
		{
			return end * 0.5f * value * value * value * value * value + start;
		}
		value -= 2f;
		return end * 0.5f * (value * value * value * value * value + 2f) + start;
	}

	private float easeInSine(float start, float end, float value)
	{
		end -= start;
		return (0f - end) * Mathf.Cos(value * ((float)Math.PI / 2f)) + end + start;
	}

	private float easeOutSine(float start, float end, float value)
	{
		end -= start;
		return end * Mathf.Sin(value * ((float)Math.PI / 2f)) + start;
	}

	private float easeInOutSine(float start, float end, float value)
	{
		end -= start;
		return (0f - end) * 0.5f * (Mathf.Cos((float)Math.PI * value) - 1f) + start;
	}

	private float easeInExpo(float start, float end, float value)
	{
		end -= start;
		return end * Mathf.Pow(2f, 10f * (value - 1f)) + start;
	}

	private float easeOutExpo(float start, float end, float value)
	{
		end -= start;
		return end * (0f - Mathf.Pow(2f, -10f * value) + 1f) + start;
	}

	private float easeInOutExpo(float start, float end, float value)
	{
		value /= 0.5f;
		end -= start;
		if (value < 1f)
		{
			return end * 0.5f * Mathf.Pow(2f, 10f * (value - 1f)) + start;
		}
		value -= 1f;
		return end * 0.5f * (0f - Mathf.Pow(2f, -10f * value) + 2f) + start;
	}

	private float easeInCirc(float start, float end, float value)
	{
		end -= start;
		return (0f - end) * (Mathf.Sqrt(1f - value * value) - 1f) + start;
	}

	private float easeOutCirc(float start, float end, float value)
	{
		value -= 1f;
		end -= start;
		return end * Mathf.Sqrt(1f - value * value) + start;
	}

	private float easeInOutCirc(float start, float end, float value)
	{
		value /= 0.5f;
		end -= start;
		if (value < 1f)
		{
			return (0f - end) * 0.5f * (Mathf.Sqrt(1f - value * value) - 1f) + start;
		}
		value -= 2f;
		return end * 0.5f * (Mathf.Sqrt(1f - value * value) + 1f) + start;
	}

	private float easeInBounce(float start, float end, float value)
	{
		end -= start;
		float num = 1f;
		return end - easeOutBounce(0f, end, num - value) + start;
	}

	private float easeOutBounce(float start, float end, float value)
	{
		value /= 1f;
		end -= start;
		if (value < 0.36363637f)
		{
			return end * (7.5625f * value * value) + start;
		}
		if (value < 0.72727275f)
		{
			value -= 0.54545456f;
			return end * (7.5625f * value * value + 0.75f) + start;
		}
		if ((double)value < 0.9090909090909091)
		{
			value -= 0.8181818f;
			return end * (7.5625f * value * value + 0.9375f) + start;
		}
		value -= 21f / 22f;
		return end * (7.5625f * value * value + 63f / 64f) + start;
	}

	private float easeInOutBounce(float start, float end, float value)
	{
		end -= start;
		float num = 1f;
		if (value < num * 0.5f)
		{
			return easeInBounce(0f, end, value * 2f) * 0.5f + start;
		}
		return easeOutBounce(0f, end, value * 2f - num) * 0.5f + end * 0.5f + start;
	}

	private float easeInBack(float start, float end, float value)
	{
		end -= start;
		value /= 1f;
		float num = 1.70158f;
		return end * value * value * ((num + 1f) * value - num) + start;
	}

	private float easeOutBack(float start, float end, float value)
	{
		float num = 1.70158f;
		end -= start;
		value -= 1f;
		return end * (value * value * ((num + 1f) * value + num) + 1f) + start;
	}

	private float easeInOutBack(float start, float end, float value)
	{
		float num = 1.70158f;
		end -= start;
		value /= 0.5f;
		if (value < 1f)
		{
			num *= 1.525f;
			return end * 0.5f * (value * value * ((num + 1f) * value - num)) + start;
		}
		value -= 2f;
		num *= 1.525f;
		return end * 0.5f * (value * value * ((num + 1f) * value + num) + 2f) + start;
	}

	private float punch(float amplitude, float value)
	{
		float num = 9f;
		if (value == 0f)
		{
			return 0f;
		}
		if (value == 1f)
		{
			return 0f;
		}
		float num2 = 0.3f;
		num = num2 / ((float)Math.PI * 2f) * Mathf.Asin(0f);
		return amplitude * Mathf.Pow(2f, -10f * value) * Mathf.Sin((value * 1f - num) * ((float)Math.PI * 2f) / num2);
	}

	private float easeInElastic(float start, float end, float value)
	{
		end -= start;
		float num = 1f;
		float num2 = num * 0.3f;
		float num3 = 0f;
		float num4 = 0f;
		if (value == 0f)
		{
			return start;
		}
		if ((value /= num) == 1f)
		{
			return start + end;
		}
		if (num4 == 0f || num4 < Mathf.Abs(end))
		{
			num4 = end;
			num3 = num2 / 4f;
		}
		else
		{
			num3 = num2 / ((float)Math.PI * 2f) * Mathf.Asin(end / num4);
		}
		return 0f - num4 * Mathf.Pow(2f, 10f * (value -= 1f)) * Mathf.Sin((value * num - num3) * ((float)Math.PI * 2f) / num2) + start;
	}

	private float easeOutElastic(float start, float end, float value)
	{
		end -= start;
		float num = 1f;
		float num2 = num * 0.3f;
		float num3 = 0f;
		float num4 = 0f;
		if (value == 0f)
		{
			return start;
		}
		if ((value /= num) == 1f)
		{
			return start + end;
		}
		if (num4 == 0f || num4 < Mathf.Abs(end))
		{
			num4 = end;
			num3 = num2 * 0.25f;
		}
		else
		{
			num3 = num2 / ((float)Math.PI * 2f) * Mathf.Asin(end / num4);
		}
		return num4 * Mathf.Pow(2f, -10f * value) * Mathf.Sin((value * num - num3) * ((float)Math.PI * 2f) / num2) + end + start;
	}

	private float easeInOutElastic(float start, float end, float value)
	{
		end -= start;
		float num = 1f;
		float num2 = num * 0.3f;
		float num3 = 0f;
		float num4 = 0f;
		if (value == 0f)
		{
			return start;
		}
		if ((value /= num * 0.5f) == 2f)
		{
			return start + end;
		}
		if (num4 == 0f || num4 < Mathf.Abs(end))
		{
			num4 = end;
			num3 = num2 / 4f;
		}
		else
		{
			num3 = num2 / ((float)Math.PI * 2f) * Mathf.Asin(end / num4);
		}
		if (value < 1f)
		{
			return -0.5f * (num4 * Mathf.Pow(2f, 10f * (value -= 1f)) * Mathf.Sin((value * num - num3) * ((float)Math.PI * 2f) / num2)) + start;
		}
		return num4 * Mathf.Pow(2f, -10f * (value -= 1f)) * Mathf.Sin((value * num - num3) * ((float)Math.PI * 2f) / num2) * 0.5f + end + start;
	}
}
public class MoveSample : MonoBehaviour
{
	private void Start()
	{
		iTween.MoveBy(base.gameObject, iTween.Hash("x", 2, "easeType", "easeInOutExpo", "loopType", "pingPong", "delay", 0.1));
	}
}
public class RotateSample : MonoBehaviour
{
	private void Start()
	{
		iTween.RotateBy(base.gameObject, iTween.Hash("x", 0.25, "easeType", "easeInOutBack", "loopType", "pingPong", "delay", 0.4));
	}
}
public class SampleInfo : MonoBehaviour
{
	private void OnGUI()
	{
		GUILayout.Label("iTween can spin, shake, punch, move, handle audio, fade color and transparency \nand much more with each task needing only one line of code.");
		GUILayout.BeginHorizontal();
		GUILayout.Label("iTween works with C#, JavaScript and Boo. For full documentation and examples visit:");
		if (GUILayout.Button("http://itween.pixelplacement.com"))
		{
			Application.OpenURL("http://itween.pixelplacement.com");
		}
		GUILayout.EndHorizontal();
	}
}
public class ScreenshotManager : MonoBehaviour
{
	public static ScreenshotManager instance;

	public static int ScreenShotNumber
	{
		get
		{
			return PlayerPrefs.GetInt("screenShotNumber");
		}
		set
		{
			PlayerPrefs.SetInt("screenShotNumber", value);
		}
	}

	public static event Action<string> ScreenshotFinishedSaving;

	public static event Action<string> ImageFinishedSaving;

	public static IEnumerator Save(string fileName, string albumName = "MyScreenshots", bool callback = false)
	{
		GameObject go = new GameObject
		{
			name = "Screenshot"
		};
		ScreenshotManager instance = go.AddComponent<ScreenshotManager>();
		bool photoSaved = false;
		string text = DateTime.Now.ToString("dd-MM-yy");
		ScreenShotNumber++;
		string text2 = fileName + "_" + ScreenShotNumber + "_" + text + ".png";
		UnityEngine.Debug.Log("Save screenshot " + text2);
		_ = Application.persistentDataPath + "/" + text2;
		if (Application.platform == RuntimePlatform.Android)
		{
			string text3 = Path.Combine(albumName, text2);
			string path = Path.Combine(Application.persistentDataPath, text3);
			Directory.CreateDirectory(Path.GetDirectoryName(path));
			ScreenCapture.CaptureScreenshot(text3);
			AndroidJavaClass obj = new AndroidJavaClass("com.ryanwebb.androidscreenshot.MainActivity");
			while (!photoSaved)
			{
				photoSaved = obj.CallStatic<bool>("addImageToGallery", new object[1] { path });
				yield return instance.StartCoroutine(Wait(0.5f));
			}
		}
		else
		{
			ScreenCapture.CaptureScreenshot(text2);
		}
		UnityEngine.Object.Destroy(go);
	}

	public static IEnumerator SaveExisting(byte[] bytes, string fileName, bool callback = false)
	{
		GameObject go = new GameObject
		{
			name = "Screenshot"
		};
		ScreenshotManager instance = go.AddComponent<ScreenshotManager>();
		bool photoSaved = false;
		UnityEngine.Debug.Log("Save existing file to gallery " + fileName);
		string path = Application.persistentDataPath + "/" + fileName + ".png";
		if (Application.platform == RuntimePlatform.Android)
		{
			AndroidJavaClass obj = new AndroidJavaClass("com.ryanwebb.androidscreenshot.MainActivity");
			File.WriteAllBytes(path, bytes);
			while (!photoSaved)
			{
				photoSaved = obj.CallStatic<bool>("addImageToGallery", new object[1] { path });
				yield return instance.StartCoroutine(Wait(0.5f));
			}
		}
		if (callback)
		{
			ScreenshotManager.ImageFinishedSaving(path);
		}
		UnityEngine.Object.Destroy(go);
	}

	public static IEnumerator Wait(float delay)
	{
		float pauseTarget = Time.realtimeSinceStartup + delay;
		while (Time.realtimeSinceStartup < pauseTarget)
		{
			yield return null;
		}
	}
}
namespace wvr
{
	public class Interop
	{
		[DllImport("wvr_api", CallingConvention = CallingConvention.Cdecl)]
		public static extern bool WVR_PollEventQueue(ref WVR_Event_t e);

		[DllImport("wvr_api", CallingConvention = CallingConvention.Cdecl)]
		public static extern int WVR_GetInputDeviceCapability(WVR_DeviceType type, WVR_InputType inputType);

		[DllImport("wvr_api", CallingConvention = CallingConvention.Cdecl)]
		public static extern bool WVR_GetInputDeviceState(WVR_DeviceType type, uint inputMask, ref uint buttons, ref uint touches, [In][Out] WVR_AnalogState_t[] analogArray, uint analogArrayCount);

		[DllImport("wvr_api", CallingConvention = CallingConvention.Cdecl)]
		public static extern int WVR_GetInputTypeCount(WVR_DeviceType type, WVR_InputType inputType);

		[DllImport("wvr_api", CallingConvention = CallingConvention.Cdecl)]
		public static extern bool WVR_GetInputButtonState(WVR_DeviceType type, WVR_InputId id);

		[DllImport("wvr_api", CallingConvention = CallingConvention.Cdecl)]
		public static extern bool WVR_GetInputTouchState(WVR_DeviceType type, WVR_InputId id);

		[DllImport("wvr_api", CallingConvention = CallingConvention.Cdecl)]
		public static extern WVR_Axis_t WVR_GetInputAnalogAxis(WVR_DeviceType type, WVR_InputId id);

		[DllImport("wvr_api", CallingConvention = CallingConvention.Cdecl)]
		public static extern void WVR_GetPoseState(WVR_DeviceType type, WVR_PoseOriginModel originModel, uint predictedMilliSec, ref WVR_PoseState_t poseState);

		[DllImport("wvr_api", CallingConvention = CallingConvention.Cdecl)]
		public static extern void WVR_GetSyncPose(WVR_PoseOriginModel originModel, [In][Out] WVR_DevicePosePair_t[] poseArray, uint pairArrayCount);

		[DllImport("wvr_api", CallingConvention = CallingConvention.Cdecl)]
		public static extern bool WVR_IsDeviceConnected(WVR_DeviceType type);

		[DllImport("wvr_api", CallingConvention = CallingConvention.Cdecl)]
		public static extern void WVR_TriggerVibrator(WVR_DeviceType type, WVR_InputId id, ushort durationMicroSec);

		[DllImport("wvr_api", CallingConvention = CallingConvention.Cdecl)]
		public static extern void WVR_TriggerRecenter();

		[DllImport("wvr_api", CallingConvention = CallingConvention.Cdecl)]
		public static extern WVR_Arena_t WVR_GetArena();

		[DllImport("wvr_api", CallingConvention = CallingConvention.Cdecl)]
		public static extern bool WVR_SetArena(ref WVR_Arena_t arena);

		[DllImport("wvr_api", CallingConvention = CallingConvention.Cdecl)]
		public static extern WVR_ArenaVisible WVR_GetArenaVisible();

		[DllImport("wvr_api", CallingConvention = CallingConvention.Cdecl)]
		public static extern void WVR_SetArenaVisible(WVR_ArenaVisible config);

		[DllImport("wvr_api", CallingConvention = CallingConvention.Cdecl)]
		public static extern bool WVR_IsOverArenaRange();

		[DllImport("wvr_api", CallingConvention = CallingConvention.Cdecl)]
		public static extern float WVR_GetDeviceBatteryPercentage(WVR_DeviceType type);

		[DllImport("wvr_api", CallingConvention = CallingConvention.Cdecl)]
		public static extern WVR_BatteryStatus WVR_GetBatteryStatus(WVR_DeviceType type);

		[DllImport("wvr_api", CallingConvention = CallingConvention.Cdecl)]
		public static extern WVR_ChargeStatus WVR_GetChargeStatus(WVR_DeviceType type);

		[DllImport("wvr_api", CallingConvention = CallingConvention.Cdecl)]
		public static extern WVR_BatteryTemperatureStatus WVR_GetBatteryTemperatureStatus(WVR_DeviceType type);

		[DllImport("wvr_api", CallingConvention = CallingConvention.Cdecl)]
		public static extern float WVR_GetBatteryTemperature(WVR_DeviceType type);

		[DllImport("wvr_api", CallingConvention = CallingConvention.Cdecl)]
		public static extern WVR_InitError WVR_Init(WVR_AppType eType);

		[DllImport("wvr_api", CallingConvention = CallingConvention.Cdecl)]
		public static extern void WVR_Quit();

		[DllImport("wvr_api", CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr WVR_GetInitErrorString(WVR_InitError error);

		[DllImport("wvr_api", CallingConvention = CallingConvention.Cdecl)]
		public static extern uint WVR_GetWaveRuntimeVersion();

		[DllImport("wvr_api", CallingConvention = CallingConvention.Cdecl)]
		public static extern uint WVR_GetWaveSDKVersion();

		[DllImport("wvr_api", CallingConvention = CallingConvention.Cdecl)]
		public static extern bool WVR_IsInputFocusCapturedBySystem();

		[DllImport("wvr_api", CallingConvention = CallingConvention.Cdecl)]
		internal static extern WVR_RenderError WVR_RenderInit(ref WVR_RenderInitParams_t param);

		[DllImport("wvr_api", CallingConvention = CallingConvention.Cdecl)]
		public static extern bool WVR_StartCamera(ref WVR_CameraInfo_t info);

		[DllImport("wvr_api", CallingConvention = CallingConvention.Cdecl)]
		public static extern void WVR_StopCamera();

		[DllImport("wvr_api", CallingConvention = CallingConvention.Cdecl)]
		public static extern bool WVR_UpdateTexture(uint textureid);

		[DllImport("wvr_api", CallingConvention = CallingConvention.Cdecl)]
		public static extern bool WVR_GetCameraIntrinsic(WVR_CameraPosition position, ref WVR_CameraIntrinsic_t intrinsic);

		[DllImport("wvr_api", CallingConvention = CallingConvention.Cdecl)]
		public static extern bool WVR_IsDeviceSuspend(WVR_DeviceType type);

		[DllImport("wvr_api", CallingConvention = CallingConvention.Cdecl)]
		public static extern void WVR_ConvertMatrixQuaternion(ref WVR_Matrix4f_t mat, ref WVR_Quatf_t quat, bool m2q);

		[DllImport("wvr_api", CallingConvention = CallingConvention.Cdecl)]
		public static extern WVR_NumDoF WVR_GetDegreeOfFreedom(WVR_DeviceType type);

		[DllImport("wvr_api", CallingConvention = CallingConvention.Cdecl)]
		public static extern void WVR_SetParameters(WVR_DeviceType type, IntPtr pchValue);

		[DllImport("wvr_api", CallingConvention = CallingConvention.Cdecl)]
		public static extern uint WVR_GetParameters(WVR_DeviceType type, IntPtr pchValue, IntPtr retValue, uint unBufferSize);

		[DllImport("wvr_api", CallingConvention = CallingConvention.Cdecl)]
		public static extern WVR_DeviceType WVR_GetDefaultControllerRole();

		[DllImport("wvr_api", CallingConvention = CallingConvention.Cdecl)]
		public static extern void WVR_GetRenderTargetSize(ref uint width, ref uint height);

		[DllImport("wvr_api", CallingConvention = CallingConvention.Cdecl)]
		public static extern WVR_Matrix4f_t WVR_GetProjection(WVR_Eye eye, float near, float far);

		[DllImport("wvr_api", CallingConvention = CallingConvention.Cdecl)]
		public static extern void WVR_GetClippingPlaneBoundary(WVR_Eye eye, ref float left, ref float right, ref float top, ref float bottom);

		[DllImport("wvr_api", CallingConvention = CallingConvention.Cdecl)]
		public static extern WVR_Matrix4f_t WVR_GetTransformFromEyeToHead(WVR_Eye eye, WVR_NumDoF dof);

		[DllImport("wvr_api", CallingConvention = CallingConvention.Cdecl)]
		public static extern WVR_SubmitError WVR_SubmitFrame(WVR_Eye eye, ref WVR_TextureParams_t param, ref WVR_PoseState_t pose, WVR_SubmitExtend extendMethod);

		[DllImport("wvr_api", CallingConvention = CallingConvention.Cdecl)]
		public static extern bool WVR_RequestScreenshot(uint width, uint height, WVR_ScreenshotMode mode, IntPtr filename);

		[DllImport("wvr_api", CallingConvention = CallingConvention.Cdecl)]
		public static extern void WVR_RenderMask(WVR_Eye eye);

		[DllImport("wvr_api", CallingConvention = CallingConvention.Cdecl)]
		public static extern bool WVR_GetRenderProps(ref WVR_RenderProps_t props);

		[DllImport("wvr_api", CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr WVR_ObtainTextureQueue(WVR_TextureTarget target, WVR_TextureFormat format, WVR_TextureType type, uint width, uint height, int level);

		[DllImport("wvr_api", CallingConvention = CallingConvention.Cdecl)]
		public static extern uint WVR_GetTextureQueueLength(IntPtr handle);

		[DllImport("wvr_api", CallingConvention = CallingConvention.Cdecl)]
		public static extern WVR_TextureParams_t WVR_GetTexture(IntPtr handle, int index);

		[DllImport("wvr_api", CallingConvention = CallingConvention.Cdecl)]
		public static extern int WVR_GetAvailableTextureIndex(IntPtr handle);

		[DllImport("wvr_api", CallingConvention = CallingConvention.Cdecl)]
		public static extern void WVR_ReleaseTextureQueue(IntPtr handle);
	}
	public enum WVR_AppType
	{
		WVR_AppType_VRContent = 1,
		WVR_AppType_NonVRContent
	}
	public enum WVR_InitError
	{
		WVR_InitError_None,
		WVR_InitError_Unknown,
		WVR_InitError_NotInitialized
	}
	public enum WVR_EventType
	{
		WVR_EventType_Quit = 99,
		WVR_EventType_DeviceConnected = 100,
		WVR_EventType_DeviceDisconnected = 101,
		WVR_EventType_DeviceStatusUpdate = 102,
		WVR_EventType_IpdChanged = 105,
		WVR_EventType_DeviceSuspend = 106,
		WVR_EventType_DeviceResume = 107,
		WVR_EventType_DeviceRoleChanged = 108,
		WVR_EventType_BatteryStatus_Update = 30004,
		WVR_EventType_ChargeStatus_Update = 30005,
		WVR_EventType_DeviceErrorStatus_Update = 30006,
		WVR_EventType_BatteryTemperatureStatus_Update = 30007,
		WVR_EventType_RecenterSuccess = 30010,
		WVR_EventType_RecenterFail = 30011,
		WVR_EventType_RecenterSuccess_3DoF = 30012,
		WVR_EventType_RecenterFail_3DoF = 30013,
		WVR_EventType_TouchpadSwipe_LeftToRight = 30014,
		WVR_EventType_TouchpadSwipe_RightToLeft = 30015,
		WVR_EventType_TouchpadSwipe_DownToUp = 30016,
		WVR_EventType_TouchpadSwipe_UpToDown = 30017,
		WVR_EventType_Settings_Controller = 30022,
		WVR_EventType_TrackingModeChanged = 30106,
		WVR_EventType_ButtonPressed = 200,
		WVR_EventType_ButtonUnpressed = 201,
		WVR_EventType_TouchTapped = 202,
		WVR_EventType_TouchUntapped = 203
	}
	public enum WVR_DeviceType
	{
		WVR_DeviceType_HMD = 1,
		WVR_DeviceType_Controller_Right,
		WVR_DeviceType_Controller_Left
	}
	public enum WVR_InputType
	{
		WVR_InputType_Button = 1,
		WVR_InputType_Touch = 2,
		WVR_InputType_Analog = 4
	}
	public enum WVR_BatteryStatus
	{
		WVR_BatteryStatus_Unknown,
		WVR_BatteryStatus_Normal,
		WVR_BatteryStatus_Low,
		WVR_BatteryStatus_UltraLow
	}
	public enum WVR_ChargeStatus
	{
		WVR_ChargeStatus_Unknown,
		WVR_ChargeStatus_Discharging,
		WVR_ChargeStatus_Charging,
		WVR_ChargeStatus_Full
	}
	public enum WVR_BatteryTemperatureStatus
	{
		WVR_BatteryTemperature_Unknown,
		WVR_BatteryTemperature_Normal,
		WVR_BatteryTemperature_Overheat,
		WVR_BatteryTemperature_UltraOverheat
	}
	public enum WVR_DeviceErrorStatus
	{
		WVR_DeviceErrorStatus_None = 0,
		WVR_DeviceErrorStatus_BatteryOverheat = 1,
		WVR_DeviceErrorStatus_BatteryOverheatRestore = 2,
		WVR_DeviceErrorStatus_BatteryOvervoltage = 4,
		WVR_DeviceErrorStatus_BatteryOvervoltageRestore = 8,
		WVR_DeviceErrorStatus_DeviceConnectFail = 0x10,
		WVR_DeviceErrorStatus_DeviceConnectRestore = 0x20,
		WVR_DeviceErrorStatus_DeviceLostTracking = 0x40,
		WVR_DeviceErrorStatus_DeviceLostTrackingRestore = 0x80,
		WVR_DeviceErrorStatus_ChargeFail = 0x100,
		WVR_DeviceErrorStatus_ChargeRestore = 0x200
	}
	public enum WVR_InputId
	{
		WVR_InputId_0 = 0,
		WVR_InputId_1 = 1,
		WVR_InputId_2 = 2,
		WVR_InputId_3 = 3,
		WVR_InputId_4 = 4,
		WVR_InputId_5 = 5,
		WVR_InputId_6 = 6,
		WVR_InputId_7 = 7,
		WVR_InputId_8 = 8,
		WVR_InputId_9 = 9,
		WVR_InputId_16 = 16,
		WVR_InputId_17 = 17,
		WVR_InputId_Alias1_System = 0,
		WVR_InputId_Alias1_Menu = 1,
		WVR_InputId_Alias1_Grip = 2,
		WVR_InputId_Alias1_DPad_Left = 3,
		WVR_InputId_Alias1_DPad_Up = 4,
		WVR_InputId_Alias1_DPad_Right = 5,
		WVR_InputId_Alias1_DPad_Down = 6,
		WVR_InputId_Alias1_Volume_Up = 7,
		WVR_InputId_Alias1_Volume_Down = 8,
		WVR_InputId_Alias1_Bumper = 9,
		WVR_InputId_Alias1_Touchpad = 16,
		WVR_InputId_Alias1_Trigger = 17,
		WVR_InputId_Max = 32
	}
	public enum WVR_AnalogType
	{
		WVR_AnalogType_None,
		WVR_AnalogType_TouchPad,
		WVR_AnalogType_Trigger
	}
	public enum WVR_PoseOriginModel
	{
		WVR_PoseOriginModel_OriginOnHead,
		WVR_PoseOriginModel_OriginOnGround,
		WVR_PoseOriginModel_OriginOnTrackingObserver,
		WVR_PoseOriginModel_OriginOnHead_3DoF
	}
	public enum WVR_ArenaVisible
	{
		WVR_ArenaVisible_Auto,
		WVR_ArenaVisible_ForceOn,
		WVR_ArenaVisible_ForceOff
	}
	public enum WVR_GraphicsApiType
	{
		WVR_GraphicsApiType_OpenGL = 1
	}
	public enum WVR_ScreenshotMode
	{
		WVR_ScreenshotMode_Default,
		WVR_ScreenshotMode_Raw
	}
	public enum WVR_SubmitError
	{
		WVR_SubmitError_None = 0,
		WVR_SubmitError_InvalidTexture = 400,
		WVR_SubmitError_ThreadStop = 401,
		WVR_SubmitError_BufferSubmitFailed = 402,
		WVR_SubmitError_Max = 65535
	}
	public enum WVR_SubmitExtend
	{
		WVR_SubmitExtend_Default
	}
	public enum WVR_Eye
	{
		WVR_Eye_Left,
		WVR_Eye_Right
	}
	public enum WVR_TextureTarget
	{
		WVR_TextureTarget_2D,
		WVR_TextureTarget_2D_ARRAY
	}
	public enum WVR_TextureFormat
	{
		WVR_TextureFormat_RGBA
	}
	public enum WVR_TextureType
	{
		WVR_TextureType_UnsignedByte
	}
	public enum WVR_RenderError
	{
		WVR_RenderError_None = 0,
		WVR_RenderError_RuntimeInitFailed = 410,
		WVR_RenderError_ContextSetupFailed = 411,
		WVR_RenderError_DisplaySetupFailed = 412,
		WVR_RenderError_LibNotSupported = 413,
		WVR_RenderError_NullPtr = 414,
		WVR_RenderError_Max = 65535
	}
	public enum WVR_RenderConfig
	{
		WVR_RenderConfig_Default = 0,
		WVR_RenderConfig_Direct_Mode = 1,
		WVR_RenderConfig_MSAA = 2,
		WVR_RenderConfig_Vertical_Sync = 16,
		WVR_RenderConfig_Timewarp = 256,
		WVR_RenderConfig_Timewarp_Asynchronous = 768
	}
	public enum WVR_CameraImageType
	{
		WVR_CameraImageType_Invalid,
		WVR_CameraImageType_SingleEye,
		WVR_CameraImageType_DualEye
	}
	public enum WVR_CameraImageFormat
	{
		WVR_CameraImageFormat_Invalid,
		WVR_CameraImageFormat_YUV_420,
		WVR_CameraImageFormat_Grayscale
	}
	public enum WVR_CameraPosition
	{
		WVR_CameraPosition_Invalid,
		WVR_CameraPosition_left,
		WVR_CameraPosition_Right
	}
	public enum WVR_OverlayError
	{
		WVR_OverlayError_None = 0,
		WVR_OverlayError_UnknownOverlay = 10,
		WVR_OverlayError_OverlayUnavailable = 11,
		WVR_OverlayError_InvalidParameter = 20
	}
	public enum WVR_OverlayTransformType
	{
		WVR_OverlayTransformType_None,
		WVR_OverlayTransformType_Absolute,
		WVR_OverlayTransformType_Fixed
	}
	public enum WVR_NumDoF
	{
		WVR_NumDoF_3DoF,
		WVR_NumDoF_6DoF
	}
	public enum WVR_ArenaShape
	{
		WVR_ArenaShape_None,
		WVR_ArenaShape_Rectangle,
		WVR_ArenaShape_Round
	}
	public struct WVR_RenderInitParams_t
	{
		public WVR_GraphicsApiType graphicsApi;

		public ulong renderConfig;
	}
	public struct WVR_Matrix4f_t
	{
		public float m0;

		public float m1;

		public float m2;

		public float m3;

		public float m4;

		public float m5;

		public float m6;

		public float m7;

		public float m8;

		public float m9;

		public float m10;

		public float m11;

		public float m12;

		public float m13;

		public float m14;

		public float m15;
	}
	public struct WVR_Vector2f_t
	{
		public float v0;

		public float v1;
	}
	public struct WVR_Vector3f_t
	{
		public float v0;

		public float v1;

		public float v2;
	}
	public struct WVR_CameraIntrinsic_t
	{
		public WVR_Vector2f_t focalLength;

		public WVR_Vector2f_t principalPoint;
	}
	public struct WVR_CameraInfo_t
	{
		public WVR_CameraImageType imgType;

		public WVR_CameraImageFormat imgFormat;

		public uint width;

		public uint height;

		public uint size;
	}
	public struct WVR_Quatf_t
	{
		public float w;

		public float x;

		public float y;

		public float z;
	}
	[StructLayout(LayoutKind.Explicit)]
	public struct WVR_PoseState_t
	{
		[FieldOffset(0)]
		public bool IsValidPose;

		[FieldOffset(4)]
		public WVR_Matrix4f_t PoseMatrix;

		[FieldOffset(68)]
		public WVR_Vector3f_t Velocity;

		[FieldOffset(80)]
		public WVR_Vector3f_t AngularVelocity;

		[FieldOffset(92)]
		public bool Is6DoFPose;

		[FieldOffset(96)]
		public long PoseTimestamp_ns;

		[FieldOffset(104)]
		public WVR_Vector3f_t Acceleration;

		[FieldOffset(116)]
		public WVR_Vector3f_t AngularAcceleration;

		[FieldOffset(128)]
		public float PredictedMilliSec;

		[FieldOffset(132)]
		public WVR_PoseOriginModel OriginModel;
	}
	[StructLayout(LayoutKind.Explicit)]
	public struct WVR_DevicePosePair_t
	{
		[FieldOffset(0)]
		public WVR_DeviceType type;

		[FieldOffset(8)]
		public WVR_PoseState_t pose;
	}
	public struct WVR_Hexagon_t
	{
		public WVR_Vector3f_t vCorners0;

		public WVR_Vector3f_t vCorners1;

		public WVR_Vector3f_t vCorners2;

		public WVR_Vector3f_t vCorners3;

		public WVR_Vector3f_t vCorners4;

		public WVR_Vector3f_t vCorners5;
	}
	public struct WVR_TextureParams_t
	{
		public IntPtr id;
	}
	public struct WVR_RenderProps_t
	{
		public float refreshRate;

		public bool hasExternal;
	}
	public struct WVR_CommonEvent_t
	{
		public WVR_EventType type;

		public long timestamp;
	}
	public struct WVR_DeviceEvent_t
	{
		public WVR_CommonEvent_t common;

		public WVR_DeviceType type;
	}
	public struct WVR_InputEvent_t
	{
		public WVR_DeviceEvent_t device;

		public WVR_InputId inputId;
	}
	public struct WVR_ErrorStatusEvent_t
	{
		public WVR_DeviceEvent_t device;

		public WVR_DeviceErrorStatus status;
	}
	public struct WVR_IPDEvent_t
	{
		public WVR_CommonEvent_t common;

		public float ipdMeters;
	}
	public struct WVR_TrackingModeEvent_t
	{
		public WVR_CommonEvent_t common;

		public WVR_NumDoF trackingMode;
	}
	[StructLayout(LayoutKind.Explicit)]
	public struct WVR_Event_t
	{
		[FieldOffset(0)]
		public WVR_CommonEvent_t common;

		[FieldOffset(0)]
		public WVR_DeviceEvent_t device;

		[FieldOffset(0)]
		public WVR_InputEvent_t input;

		[FieldOffset(0)]
		public WVR_ErrorStatusEvent_t error;

		[FieldOffset(0)]
		public WVR_IPDEvent_t ipd;

		[FieldOffset(0)]
		public WVR_TrackingModeEvent_t trmode;
	}
	public struct WVR_Axis_t
	{
		public float x;

		public float y;
	}
	[StructLayout(LayoutKind.Explicit)]
	public struct WVR_AnalogState_t
	{
		[FieldOffset(0)]
		public WVR_InputId id;

		[FieldOffset(4)]
		public WVR_AnalogType type;

		[FieldOffset(8)]
		public WVR_Axis_t axis;
	}
	[StructLayout(LayoutKind.Explicit)]
	public struct WVR_Pose_t
	{
		[FieldOffset(0)]
		public WVR_Vector3f_t position;

		[FieldOffset(12)]
		public WVR_Quatf_t rotation;
	}
	public struct WVR_OverlayPosition_t
	{
		public float x;

		public float y;

		public float z;
	}
	public struct WVR_OverlayBlendColor_t
	{
		public float r;

		public float g;

		public float b;
	}
	public struct WVR_OverlayTexture_t
	{
		public uint textureId;

		public uint width;

		public uint height;
	}
	public struct WVR_ArenaRectangle_t
	{
		public float width;

		public float length;
	}
	public struct WVR_ArenaRound_t
	{
		public float diameter;
	}
	[StructLayout(LayoutKind.Explicit)]
	public struct WVR_ArenaArea_t
	{
		[FieldOffset(0)]
		public WVR_ArenaRectangle_t rectangle;

		[FieldOffset(0)]
		public WVR_ArenaRound_t round;
	}
	public struct WVR_Arena_t
	{
		public WVR_ArenaShape shape;

		public WVR_ArenaArea_t area;
	}
	public delegate void WVR_OverlayInputEventCallback(int overlayId, WVR_EventType type, WVR_InputId inputId);
	public struct WVR_OverlayInputEvent_t
	{
		public int overlayId;

		public IntPtr callback;
	}
}
namespace Steamworks
{
	public static class SteamAppList
	{
		public static uint GetNumInstalledApps()
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamAppList_GetNumInstalledApps();
		}

		public static uint GetInstalledApps(AppId_t[] pvecAppID, uint unMaxAppIDs)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamAppList_GetInstalledApps(pvecAppID, unMaxAppIDs);
		}

		public static int GetAppName(AppId_t nAppID, out string pchName, int cchNameMax)
		{
			InteropHelp.TestIfAvailableClient();
			IntPtr intPtr = Marshal.AllocHGlobal(cchNameMax);
			int num = NativeMethods.ISteamAppList_GetAppName(nAppID, intPtr, cchNameMax);
			pchName = ((num != -1) ? InteropHelp.PtrToStringUTF8(intPtr) : null);
			Marshal.FreeHGlobal(intPtr);
			return num;
		}

		public static int GetAppInstallDir(AppId_t nAppID, out string pchDirectory, int cchNameMax)
		{
			InteropHelp.TestIfAvailableClient();
			IntPtr intPtr = Marshal.AllocHGlobal(cchNameMax);
			int num = NativeMethods.ISteamAppList_GetAppInstallDir(nAppID, intPtr, cchNameMax);
			pchDirectory = ((num != -1) ? InteropHelp.PtrToStringUTF8(intPtr) : null);
			Marshal.FreeHGlobal(intPtr);
			return num;
		}

		public static int GetAppBuildId(AppId_t nAppID)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamAppList_GetAppBuildId(nAppID);
		}
	}
	public static class SteamApps
	{
		public static bool BIsSubscribed()
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamApps_BIsSubscribed();
		}

		public static bool BIsLowViolence()
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamApps_BIsLowViolence();
		}

		public static bool BIsCybercafe()
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamApps_BIsCybercafe();
		}

		public static bool BIsVACBanned()
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamApps_BIsVACBanned();
		}

		public static string GetCurrentGameLanguage()
		{
			InteropHelp.TestIfAvailableClient();
			return InteropHelp.PtrToStringUTF8(NativeMethods.ISteamApps_GetCurrentGameLanguage());
		}

		public static string GetAvailableGameLanguages()
		{
			InteropHelp.TestIfAvailableClient();
			return InteropHelp.PtrToStringUTF8(NativeMethods.ISteamApps_GetAvailableGameLanguages());
		}

		public static bool BIsSubscribedApp(AppId_t appID)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamApps_BIsSubscribedApp(appID);
		}

		public static bool BIsDlcInstalled(AppId_t appID)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamApps_BIsDlcInstalled(appID);
		}

		public static uint GetEarliestPurchaseUnixTime(AppId_t nAppID)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamApps_GetEarliestPurchaseUnixTime(nAppID);
		}

		public static bool BIsSubscribedFromFreeWeekend()
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamApps_BIsSubscribedFromFreeWeekend();
		}

		public static int GetDLCCount()
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamApps_GetDLCCount();
		}

		public static bool BGetDLCDataByIndex(int iDLC, out AppId_t pAppID, out bool pbAvailable, out string pchName, int cchNameBufferSize)
		{
			InteropHelp.TestIfAvailableClient();
			IntPtr intPtr = Marshal.AllocHGlobal(cchNameBufferSize);
			bool flag = NativeMethods.ISteamApps_BGetDLCDataByIndex(iDLC, out pAppID, out pbAvailable, intPtr, cchNameBufferSize);
			pchName = (flag ? InteropHelp.PtrToStringUTF8(intPtr) : null);
			Marshal.FreeHGlobal(intPtr);
			return flag;
		}

		public static void InstallDLC(AppId_t nAppID)
		{
			InteropHelp.TestIfAvailableClient();
			NativeMethods.ISteamApps_InstallDLC(nAppID);
		}

		public static void UninstallDLC(AppId_t nAppID)
		{
			InteropHelp.TestIfAvailableClient();
			NativeMethods.ISteamApps_UninstallDLC(nAppID);
		}

		public static void RequestAppProofOfPurchaseKey(AppId_t nAppID)
		{
			InteropHelp.TestIfAvailableClient();
			NativeMethods.ISteamApps_RequestAppProofOfPurchaseKey(nAppID);
		}

		public static bool GetCurrentBetaName(out string pchName, int cchNameBufferSize)
		{
			InteropHelp.TestIfAvailableClient();
			IntPtr intPtr = Marshal.AllocHGlobal(cchNameBufferSize);
			bool flag = NativeMethods.ISteamApps_GetCurrentBetaName(intPtr, cchNameBufferSize);
			pchName = (flag ? InteropHelp.PtrToStringUTF8(intPtr) : null);
			Marshal.FreeHGlobal(intPtr);
			return flag;
		}

		public static bool MarkContentCorrupt(bool bMissingFilesOnly)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamApps_MarkContentCorrupt(bMissingFilesOnly);
		}

		public static uint GetInstalledDepots(AppId_t appID, DepotId_t[] pvecDepots, uint cMaxDepots)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamApps_GetInstalledDepots(appID, pvecDepots, cMaxDepots);
		}

		public static uint GetAppInstallDir(AppId_t appID, out string pchFolder, uint cchFolderBufferSize)
		{
			InteropHelp.TestIfAvailableClient();
			IntPtr intPtr = Marshal.AllocHGlobal((int)cchFolderBufferSize);
			uint num = NativeMethods.ISteamApps_GetAppInstallDir(appID, intPtr, cchFolderBufferSize);
			pchFolder = ((num != 0) ? InteropHelp.PtrToStringUTF8(intPtr) : null);
			Marshal.FreeHGlobal(intPtr);
			return num;
		}

		public static bool BIsAppInstalled(AppId_t appID)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamApps_BIsAppInstalled(appID);
		}

		public static CSteamID GetAppOwner()
		{
			InteropHelp.TestIfAvailableClient();
			return (CSteamID)NativeMethods.ISteamApps_GetAppOwner();
		}

		public static string GetLaunchQueryParam(string pchKey)
		{
			InteropHelp.TestIfAvailableClient();
			using InteropHelp.UTF8StringHandle pchKey2 = new InteropHelp.UTF8StringHandle(pchKey);
			return InteropHelp.PtrToStringUTF8(NativeMethods.ISteamApps_GetLaunchQueryParam(pchKey2));
		}

		public static bool GetDlcDownloadProgress(AppId_t nAppID, out ulong punBytesDownloaded, out ulong punBytesTotal)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamApps_GetDlcDownloadProgress(nAppID, out punBytesDownloaded, out punBytesTotal);
		}

		public static int GetAppBuildId()
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamApps_GetAppBuildId();
		}
	}
	public static class SteamClient
	{
		public static HSteamPipe CreateSteamPipe()
		{
			InteropHelp.TestIfAvailableClient();
			return (HSteamPipe)NativeMethods.ISteamClient_CreateSteamPipe();
		}

		public static bool BReleaseSteamPipe(HSteamPipe hSteamPipe)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamClient_BReleaseSteamPipe(hSteamPipe);
		}

		public static HSteamUser ConnectToGlobalUser(HSteamPipe hSteamPipe)
		{
			InteropHelp.TestIfAvailableClient();
			return (HSteamUser)NativeMethods.ISteamClient_ConnectToGlobalUser(hSteamPipe);
		}

		public static HSteamUser CreateLocalUser(out HSteamPipe phSteamPipe, EAccountType eAccountType)
		{
			InteropHelp.TestIfAvailableClient();
			return (HSteamUser)NativeMethods.ISteamClient_CreateLocalUser(out phSteamPipe, eAccountType);
		}

		public static void ReleaseUser(HSteamPipe hSteamPipe, HSteamUser hUser)
		{
			InteropHelp.TestIfAvailableClient();
			NativeMethods.ISteamClient_ReleaseUser(hSteamPipe, hUser);
		}

		public static IntPtr GetISteamUser(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion)
		{
			InteropHelp.TestIfAvailableClient();
			using InteropHelp.UTF8StringHandle pchVersion2 = new InteropHelp.UTF8StringHandle(pchVersion);
			return NativeMethods.ISteamClient_GetISteamUser(hSteamUser, hSteamPipe, pchVersion2);
		}

		public static IntPtr GetISteamGameServer(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion)
		{
			InteropHelp.TestIfAvailableClient();
			using InteropHelp.UTF8StringHandle pchVersion2 = new InteropHelp.UTF8StringHandle(pchVersion);
			return NativeMethods.ISteamClient_GetISteamGameServer(hSteamUser, hSteamPipe, pchVersion2);
		}

		public static void SetLocalIPBinding(uint unIP, ushort usPort)
		{
			InteropHelp.TestIfAvailableClient();
			NativeMethods.ISteamClient_SetLocalIPBinding(unIP, usPort);
		}

		public static IntPtr GetISteamFriends(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion)
		{
			InteropHelp.TestIfAvailableClient();
			using InteropHelp.UTF8StringHandle pchVersion2 = new InteropHelp.UTF8StringHandle(pchVersion);
			return NativeMethods.ISteamClient_GetISteamFriends(hSteamUser, hSteamPipe, pchVersion2);
		}

		public static IntPtr GetISteamUtils(HSteamPipe hSteamPipe, string pchVersion)
		{
			InteropHelp.TestIfAvailableClient();
			using InteropHelp.UTF8StringHandle pchVersion2 = new InteropHelp.UTF8StringHandle(pchVersion);
			return NativeMethods.ISteamClient_GetISteamUtils(hSteamPipe, pchVersion2);
		}

		public static IntPtr GetISteamMatchmaking(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion)
		{
			InteropHelp.TestIfAvailableClient();
			using InteropHelp.UTF8StringHandle pchVersion2 = new InteropHelp.UTF8StringHandle(pchVersion);
			return NativeMethods.ISteamClient_GetISteamMatchmaking(hSteamUser, hSteamPipe, pchVersion2);
		}

		public static IntPtr GetISteamMatchmakingServers(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion)
		{
			InteropHelp.TestIfAvailableClient();
			using InteropHelp.UTF8StringHandle pchVersion2 = new InteropHelp.UTF8StringHandle(pchVersion);
			return NativeMethods.ISteamClient_GetISteamMatchmakingServers(hSteamUser, hSteamPipe, pchVersion2);
		}

		public static IntPtr GetISteamGenericInterface(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion)
		{
			InteropHelp.TestIfAvailableClient();
			using InteropHelp.UTF8StringHandle pchVersion2 = new InteropHelp.UTF8StringHandle(pchVersion);
			return NativeMethods.ISteamClient_GetISteamGenericInterface(hSteamUser, hSteamPipe, pchVersion2);
		}

		public static IntPtr GetISteamUserStats(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion)
		{
			InteropHelp.TestIfAvailableClient();
			using InteropHelp.UTF8StringHandle pchVersion2 = new InteropHelp.UTF8StringHandle(pchVersion);
			return NativeMethods.ISteamClient_GetISteamUserStats(hSteamUser, hSteamPipe, pchVersion2);
		}

		public static IntPtr GetISteamGameServerStats(HSteamUser hSteamuser, HSteamPipe hSteamPipe, string pchVersion)
		{
			InteropHelp.TestIfAvailableClient();
			using InteropHelp.UTF8StringHandle pchVersion2 = new InteropHelp.UTF8StringHandle(pchVersion);
			return NativeMethods.ISteamClient_GetISteamGameServerStats(hSteamuser, hSteamPipe, pchVersion2);
		}

		public static IntPtr GetISteamApps(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion)
		{
			InteropHelp.TestIfAvailableClient();
			using InteropHelp.UTF8StringHandle pchVersion2 = new InteropHelp.UTF8StringHandle(pchVersion);
			return NativeMethods.ISteamClient_GetISteamApps(hSteamUser, hSteamPipe, pchVersion2);
		}

		public static IntPtr GetISteamNetworking(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion)
		{
			InteropHelp.TestIfAvailableClient();
			using InteropHelp.UTF8StringHandle pchVersion2 = new InteropHelp.UTF8StringHandle(pchVersion);
			return NativeMethods.ISteamClient_GetISteamNetworking(hSteamUser, hSteamPipe, pchVersion2);
		}

		public static IntPtr GetISteamRemoteStorage(HSteamUser hSteamuser, HSteamPipe hSteamPipe, string pchVersion)
		{
			InteropHelp.TestIfAvailableClient();
			using InteropHelp.UTF8StringHandle pchVersion2 = new InteropHelp.UTF8StringHandle(pchVersion);
			return NativeMethods.ISteamClient_GetISteamRemoteStorage(hSteamuser, hSteamPipe, pchVersion2);
		}

		public static IntPtr GetISteamScreenshots(HSteamUser hSteamuser, HSteamPipe hSteamPipe, string pchVersion)
		{
			InteropHelp.TestIfAvailableClient();
			using InteropHelp.UTF8StringHandle pchVersion2 = new InteropHelp.UTF8StringHandle(pchVersion);
			return NativeMethods.ISteamClient_GetISteamScreenshots(hSteamuser, hSteamPipe, pchVersion2);
		}

		public static void RunFrame()
		{
			InteropHelp.TestIfAvailableClient();
			NativeMethods.ISteamClient_RunFrame();
		}

		public static uint GetIPCCallCount()
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamClient_GetIPCCallCount();
		}

		public static void SetWarningMessageHook(SteamAPIWarningMessageHook_t pFunction)
		{
			InteropHelp.TestIfAvailableClient();
			NativeMethods.ISteamClient_SetWarningMessageHook(pFunction);
		}

		public static bool BShutdownIfAllPipesClosed()
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamClient_BShutdownIfAllPipesClosed();
		}

		public static IntPtr GetISteamHTTP(HSteamUser hSteamuser, HSteamPipe hSteamPipe, string pchVersion)
		{
			InteropHelp.TestIfAvailableClient();
			using InteropHelp.UTF8StringHandle pchVersion2 = new InteropHelp.UTF8StringHandle(pchVersion);
			return NativeMethods.ISteamClient_GetISteamHTTP(hSteamuser, hSteamPipe, pchVersion2);
		}

		public static IntPtr GetISteamUnifiedMessages(HSteamUser hSteamuser, HSteamPipe hSteamPipe, string pchVersion)
		{
			InteropHelp.TestIfAvailableClient();
			using InteropHelp.UTF8StringHandle pchVersion2 = new InteropHelp.UTF8StringHandle(pchVersion);
			return NativeMethods.ISteamClient_GetISteamUnifiedMessages(hSteamuser, hSteamPipe, pchVersion2);
		}

		public static IntPtr GetISteamController(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion)
		{
			InteropHelp.TestIfAvailableClient();
			using InteropHelp.UTF8StringHandle pchVersion2 = new InteropHelp.UTF8StringHandle(pchVersion);
			return NativeMethods.ISteamClient_GetISteamController(hSteamUser, hSteamPipe, pchVersion2);
		}

		public static IntPtr GetISteamUGC(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion)
		{
			InteropHelp.TestIfAvailableClient();
			using InteropHelp.UTF8StringHandle pchVersion2 = new InteropHelp.UTF8StringHandle(pchVersion);
			return NativeMethods.ISteamClient_GetISteamUGC(hSteamUser, hSteamPipe, pchVersion2);
		}

		public static IntPtr GetISteamAppList(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion)
		{
			InteropHelp.TestIfAvailableClient();
			using InteropHelp.UTF8StringHandle pchVersion2 = new InteropHelp.UTF8StringHandle(pchVersion);
			return NativeMethods.ISteamClient_GetISteamAppList(hSteamUser, hSteamPipe, pchVersion2);
		}

		public static IntPtr GetISteamMusic(HSteamUser hSteamuser, HSteamPipe hSteamPipe, string pchVersion)
		{
			InteropHelp.TestIfAvailableClient();
			using InteropHelp.UTF8StringHandle pchVersion2 = new InteropHelp.UTF8StringHandle(pchVersion);
			return NativeMethods.ISteamClient_GetISteamMusic(hSteamuser, hSteamPipe, pchVersion2);
		}

		public static IntPtr GetISteamMusicRemote(HSteamUser hSteamuser, HSteamPipe hSteamPipe, string pchVersion)
		{
			InteropHelp.TestIfAvailableClient();
			using InteropHelp.UTF8StringHandle pchVersion2 = new InteropHelp.UTF8StringHandle(pchVersion);
			return NativeMethods.ISteamClient_GetISteamMusicRemote(hSteamuser, hSteamPipe, pchVersion2);
		}

		public static IntPtr GetISteamHTMLSurface(HSteamUser hSteamuser, HSteamPipe hSteamPipe, string pchVersion)
		{
			InteropHelp.TestIfAvailableClient();
			using InteropHelp.UTF8StringHandle pchVersion2 = new InteropHelp.UTF8StringHandle(pchVersion);
			return NativeMethods.ISteamClient_GetISteamHTMLSurface(hSteamuser, hSteamPipe, pchVersion2);
		}

		public static void Set_SteamAPI_CPostAPIResultInProcess(SteamAPI_PostAPIResultInProcess_t func)
		{
			InteropHelp.TestIfAvailableClient();
			NativeMethods.ISteamClient_Set_SteamAPI_CPostAPIResultInProcess(func);
		}

		public static void Remove_SteamAPI_CPostAPIResultInProcess(SteamAPI_PostAPIResultInProcess_t func)
		{
			InteropHelp.TestIfAvailableClient();
			NativeMethods.ISteamClient_Remove_SteamAPI_CPostAPIResultInProcess(func);
		}

		public static void Set_SteamAPI_CCheckCallbackRegisteredInProcess(SteamAPI_CheckCallbackRegistered_t func)
		{
			InteropHelp.TestIfAvailableClient();
			NativeMethods.ISteamClient_Set_SteamAPI_CCheckCallbackRegisteredInProcess(func);
		}

		public static IntPtr GetISteamInventory(HSteamUser hSteamuser, HSteamPipe hSteamPipe, string pchVersion)
		{
			InteropHelp.TestIfAvailableClient();
			using InteropHelp.UTF8StringHandle pchVersion2 = new InteropHelp.UTF8StringHandle(pchVersion);
			return NativeMethods.ISteamClient_GetISteamInventory(hSteamuser, hSteamPipe, pchVersion2);
		}

		public static IntPtr GetISteamVideo(HSteamUser hSteamuser, HSteamPipe hSteamPipe, string pchVersion)
		{
			InteropHelp.TestIfAvailableClient();
			using InteropHelp.UTF8StringHandle pchVersion2 = new InteropHelp.UTF8StringHandle(pchVersion);
			return NativeMethods.ISteamClient_GetISteamVideo(hSteamuser, hSteamPipe, pchVersion2);
		}
	}
	public static class SteamController
	{
		public static bool Init(string pchAbsolutePathToControllerConfigVDF)
		{
			InteropHelp.TestIfAvailableClient();
			using InteropHelp.UTF8StringHandle pchAbsolutePathToControllerConfigVDF2 = new InteropHelp.UTF8StringHandle(pchAbsolutePathToControllerConfigVDF);
			return NativeMethods.ISteamController_Init(pchAbsolutePathToControllerConfigVDF2);
		}

		public static bool Shutdown()
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamController_Shutdown();
		}

		public static void RunFrame()
		{
			InteropHelp.TestIfAvailableClient();
			NativeMethods.ISteamController_RunFrame();
		}

		public static bool GetControllerState(uint unControllerIndex, out SteamControllerState_t pState)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamController_GetControllerState(unControllerIndex, out pState);
		}

		public static void TriggerHapticPulse(uint unControllerIndex, ESteamControllerPad eTargetPad, ushort usDurationMicroSec)
		{
			InteropHelp.TestIfAvailableClient();
			NativeMethods.ISteamController_TriggerHapticPulse(unControllerIndex, eTargetPad, usDurationMicroSec);
		}

		public static void SetOverrideMode(string pchMode)
		{
			InteropHelp.TestIfAvailableClient();
			using InteropHelp.UTF8StringHandle pchMode2 = new InteropHelp.UTF8StringHandle(pchMode);
			NativeMethods.ISteamController_SetOverrideMode(pchMode2);
		}
	}
	public static class SteamFriends
	{
		public static string GetPersonaName()
		{
			InteropHelp.TestIfAvailableClient();
			return InteropHelp.PtrToStringUTF8(NativeMethods.ISteamFriends_GetPersonaName());
		}

		public static SteamAPICall_t SetPersonaName(string pchPersonaName)
		{
			InteropHelp.TestIfAvailableClient();
			using InteropHelp.UTF8StringHandle pchPersonaName2 = new InteropHelp.UTF8StringHandle(pchPersonaName);
			return (SteamAPICall_t)NativeMethods.ISteamFriends_SetPersonaName(pchPersonaName2);
		}

		public static EPersonaState GetPersonaState()
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamFriends_GetPersonaState();
		}

		public static int GetFriendCount(EFriendFlags iFriendFlags)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamFriends_GetFriendCount(iFriendFlags);
		}

		public static CSteamID GetFriendByIndex(int iFriend, EFriendFlags iFriendFlags)
		{
			InteropHelp.TestIfAvailableClient();
			return (CSteamID)NativeMethods.ISteamFriends_GetFriendByIndex(iFriend, iFriendFlags);
		}

		public static EFriendRelationship GetFriendRelationship(CSteamID steamIDFriend)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamFriends_GetFriendRelationship(steamIDFriend);
		}

		public static EPersonaState GetFriendPersonaState(CSteamID steamIDFriend)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamFriends_GetFriendPersonaState(steamIDFriend);
		}

		public static string GetFriendPersonaName(CSteamID steamIDFriend)
		{
			InteropHelp.TestIfAvailableClient();
			return InteropHelp.PtrToStringUTF8(NativeMethods.ISteamFriends_GetFriendPersonaName(steamIDFriend));
		}

		public static bool GetFriendGamePlayed(CSteamID steamIDFriend, out FriendGameInfo_t pFriendGameInfo)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamFriends_GetFriendGamePlayed(steamIDFriend, out pFriendGameInfo);
		}

		public static string GetFriendPersonaNameHistory(CSteamID steamIDFriend, int iPersonaName)
		{
			InteropHelp.TestIfAvailableClient();
			return InteropHelp.PtrToStringUTF8(NativeMethods.ISteamFriends_GetFriendPersonaNameHistory(steamIDFriend, iPersonaName));
		}

		public static int GetFriendSteamLevel(CSteamID steamIDFriend)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamFriends_GetFriendSteamLevel(steamIDFriend);
		}

		public static string GetPlayerNickname(CSteamID steamIDPlayer)
		{
			InteropHelp.TestIfAvailableClient();
			return InteropHelp.PtrToStringUTF8(NativeMethods.ISteamFriends_GetPlayerNickname(steamIDPlayer));
		}

		public static int GetFriendsGroupCount()
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamFriends_GetFriendsGroupCount();
		}

		public static FriendsGroupID_t GetFriendsGroupIDByIndex(int iFG)
		{
			InteropHelp.TestIfAvailableClient();
			return (FriendsGroupID_t)NativeMethods.ISteamFriends_GetFriendsGroupIDByIndex(iFG);
		}

		public static string GetFriendsGroupName(FriendsGroupID_t friendsGroupID)
		{
			InteropHelp.TestIfAvailableClient();
			return InteropHelp.PtrToStringUTF8(NativeMethods.ISteamFriends_GetFriendsGroupName(friendsGroupID));
		}

		public static int GetFriendsGroupMembersCount(FriendsGroupID_t friendsGroupID)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamFriends_GetFriendsGroupMembersCount(friendsGroupID);
		}

		public static void GetFriendsGroupMembersList(FriendsGroupID_t friendsGroupID, CSteamID[] pOutSteamIDMembers, int nMembersCount)
		{
			InteropHelp.TestIfAvailableClient();
			NativeMethods.ISteamFriends_GetFriendsGroupMembersList(friendsGroupID, pOutSteamIDMembers, nMembersCount);
		}

		public static bool HasFriend(CSteamID steamIDFriend, EFriendFlags iFriendFlags)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamFriends_HasFriend(steamIDFriend, iFriendFlags);
		}

		public static int GetClanCount()
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamFriends_GetClanCount();
		}

		public static CSteamID GetClanByIndex(int iClan)
		{
			InteropHelp.TestIfAvailableClient();
			return (CSteamID)NativeMethods.ISteamFriends_GetClanByIndex(iClan);
		}

		public static string GetClanName(CSteamID steamIDClan)
		{
			InteropHelp.TestIfAvailableClient();
			return InteropHelp.PtrToStringUTF8(NativeMethods.ISteamFriends_GetClanName(steamIDClan));
		}

		public static string GetClanTag(CSteamID steamIDClan)
		{
			InteropHelp.TestIfAvailableClient();
			return InteropHelp.PtrToStringUTF8(NativeMethods.ISteamFriends_GetClanTag(steamIDClan));
		}

		public static bool GetClanActivityCounts(CSteamID steamIDClan, out int pnOnline, out int pnInGame, out int pnChatting)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamFriends_GetClanActivityCounts(steamIDClan, out pnOnline, out pnInGame, out pnChatting);
		}

		public static SteamAPICall_t DownloadClanActivityCounts(CSteamID[] psteamIDClans, int cClansToRequest)
		{
			InteropHelp.TestIfAvailableClient();
			return (SteamAPICall_t)NativeMethods.ISteamFriends_DownloadClanActivityCounts(psteamIDClans, cClansToRequest);
		}

		public static int GetFriendCountFromSource(CSteamID steamIDSource)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamFriends_GetFriendCountFromSource(steamIDSource);
		}

		public static CSteamID GetFriendFromSourceByIndex(CSteamID steamIDSource, int iFriend)
		{
			InteropHelp.TestIfAvailableClient();
			return (CSteamID)NativeMethods.ISteamFriends_GetFriendFromSourceByIndex(steamIDSource, iFriend);
		}

		public static bool IsUserInSource(CSteamID steamIDUser, CSteamID steamIDSource)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamFriends_IsUserInSource(steamIDUser, steamIDSource);
		}

		public static void SetInGameVoiceSpeaking(CSteamID steamIDUser, bool bSpeaking)
		{
			InteropHelp.TestIfAvailableClient();
			NativeMethods.ISteamFriends_SetInGameVoiceSpeaking(steamIDUser, bSpeaking);
		}

		public static void ActivateGameOverlay(string pchDialog)
		{
			InteropHelp.TestIfAvailableClient();
			using InteropHelp.UTF8StringHandle pchDialog2 = new InteropHelp.UTF8StringHandle(pchDialog);
			NativeMethods.ISteamFriends_ActivateGameOverlay(pchDialog2);
		}

		public static void ActivateGameOverlayToUser(string pchDialog, CSteamID steamID)
		{
			InteropHelp.TestIfAvailableClient();
			using InteropHelp.UTF8StringHandle pchDialog2 = new InteropHelp.UTF8StringHandle(pchDialog);
			NativeMethods.ISteamFriends_ActivateGameOverlayToUser(pchDialog2, steamID);
		}

		public static void ActivateGameOverlayToWebPage(string pchURL)
		{
			InteropHelp.TestIfAvailableClient();
			using InteropHelp.UTF8StringHandle pchURL2 = new InteropHelp.UTF8StringHandle(pchURL);
			NativeMethods.ISteamFriends_ActivateGameOverlayToWebPage(pchURL2);
		}

		public static void ActivateGameOverlayToStore(AppId_t nAppID, EOverlayToStoreFlag eFlag)
		{
			InteropHelp.TestIfAvailableClient();
			NativeMethods.ISteamFriends_ActivateGameOverlayToStore(nAppID, eFlag);
		}

		public static void SetPlayedWith(CSteamID steamIDUserPlayedWith)
		{
			InteropHelp.TestIfAvailableClient();
			NativeMethods.ISteamFriends_SetPlayedWith(steamIDUserPlayedWith);
		}

		public static void ActivateGameOverlayInviteDialog(CSteamID steamIDLobby)
		{
			InteropHelp.TestIfAvailableClient();
			NativeMethods.ISteamFriends_ActivateGameOverlayInviteDialog(steamIDLobby);
		}

		public static int GetSmallFriendAvatar(CSteamID steamIDFriend)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamFriends_GetSmallFriendAvatar(steamIDFriend);
		}

		public static int GetMediumFriendAvatar(CSteamID steamIDFriend)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamFriends_GetMediumFriendAvatar(steamIDFriend);
		}

		public static int GetLargeFriendAvatar(CSteamID steamIDFriend)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamFriends_GetLargeFriendAvatar(steamIDFriend);
		}

		public static bool RequestUserInformation(CSteamID steamIDUser, bool bRequireNameOnly)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamFriends_RequestUserInformation(steamIDUser, bRequireNameOnly);
		}

		public static SteamAPICall_t RequestClanOfficerList(CSteamID steamIDClan)
		{
			InteropHelp.TestIfAvailableClient();
			return (SteamAPICall_t)NativeMethods.ISteamFriends_RequestClanOfficerList(steamIDClan);
		}

		public static CSteamID GetClanOwner(CSteamID steamIDClan)
		{
			InteropHelp.TestIfAvailableClient();
			return (CSteamID)NativeMethods.ISteamFriends_GetClanOwner(steamIDClan);
		}

		public static int GetClanOfficerCount(CSteamID steamIDClan)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamFriends_GetClanOfficerCount(steamIDClan);
		}

		public static CSteamID GetClanOfficerByIndex(CSteamID steamIDClan, int iOfficer)
		{
			InteropHelp.TestIfAvailableClient();
			return (CSteamID)NativeMethods.ISteamFriends_GetClanOfficerByIndex(steamIDClan, iOfficer);
		}

		public static uint GetUserRestrictions()
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamFriends_GetUserRestrictions();
		}

		public static bool SetRichPresence(string pchKey, string pchValue)
		{
			InteropHelp.TestIfAvailableClient();
			using InteropHelp.UTF8StringHandle pchKey2 = new InteropHelp.UTF8StringHandle(pchKey);
			using InteropHelp.UTF8StringHandle pchValue2 = new InteropHelp.UTF8StringHandle(pchValue);
			return NativeMethods.ISteamFriends_SetRichPresence(pchKey2, pchValue2);
		}

		public static void ClearRichPresence()
		{
			InteropHelp.TestIfAvailableClient();
			NativeMethods.ISteamFriends_ClearRichPresence();
		}

		public static string GetFriendRichPresence(CSteamID steamIDFriend, string pchKey)
		{
			InteropHelp.TestIfAvailableClient();
			using InteropHelp.UTF8StringHandle pchKey2 = new InteropHelp.UTF8StringHandle(pchKey);
			return InteropHelp.PtrToStringUTF8(NativeMethods.ISteamFriends_GetFriendRichPresence(steamIDFriend, pchKey2));
		}

		public static int GetFriendRichPresenceKeyCount(CSteamID steamIDFriend)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamFriends_GetFriendRichPresenceKeyCount(steamIDFriend);
		}

		public static string GetFriendRichPresenceKeyByIndex(CSteamID steamIDFriend, int iKey)
		{
			InteropHelp.TestIfAvailableClient();
			return InteropHelp.PtrToStringUTF8(NativeMethods.ISteamFriends_GetFriendRichPresenceKeyByIndex(steamIDFriend, iKey));
		}

		public static void RequestFriendRichPresence(CSteamID steamIDFriend)
		{
			InteropHelp.TestIfAvailableClient();
			NativeMethods.ISteamFriends_RequestFriendRichPresence(steamIDFriend);
		}

		public static bool InviteUserToGame(CSteamID steamIDFriend, string pchConnectString)
		{
			InteropHelp.TestIfAvailableClient();
			using InteropHelp.UTF8StringHandle pchConnectString2 = new InteropHelp.UTF8StringHandle(pchConnectString);
			return NativeMethods.ISteamFriends_InviteUserToGame(steamIDFriend, pchConnectString2);
		}

		public static int GetCoplayFriendCount()
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamFriends_GetCoplayFriendCount();
		}

		public static CSteamID GetCoplayFriend(int iCoplayFriend)
		{
			InteropHelp.TestIfAvailableClient();
			return (CSteamID)NativeMethods.ISteamFriends_GetCoplayFriend(iCoplayFriend);
		}

		public static int GetFriendCoplayTime(CSteamID steamIDFriend)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamFriends_GetFriendCoplayTime(steamIDFriend);
		}

		public static AppId_t GetFriendCoplayGame(CSteamID steamIDFriend)
		{
			InteropHelp.TestIfAvailableClient();
			return (AppId_t)NativeMethods.ISteamFriends_GetFriendCoplayGame(steamIDFriend);
		}

		public static SteamAPICall_t JoinClanChatRoom(CSteamID steamIDClan)
		{
			InteropHelp.TestIfAvailableClient();
			return (SteamAPICall_t)NativeMethods.ISteamFriends_JoinClanChatRoom(steamIDClan);
		}

		public static bool LeaveClanChatRoom(CSteamID steamIDClan)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamFriends_LeaveClanChatRoom(steamIDClan);
		}

		public static int GetClanChatMemberCount(CSteamID steamIDClan)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamFriends_GetClanChatMemberCount(steamIDClan);
		}

		public static CSteamID GetChatMemberByIndex(CSteamID steamIDClan, int iUser)
		{
			InteropHelp.TestIfAvailableClient();
			return (CSteamID)NativeMethods.ISteamFriends_GetChatMemberByIndex(steamIDClan, iUser);
		}

		public static bool SendClanChatMessage(CSteamID steamIDClanChat, string pchText)
		{
			InteropHelp.TestIfAvailableClient();
			using InteropHelp.UTF8StringHandle pchText2 = new InteropHelp.UTF8StringHandle(pchText);
			return NativeMethods.ISteamFriends_SendClanChatMessage(steamIDClanChat, pchText2);
		}

		public static int GetClanChatMessage(CSteamID steamIDClanChat, int iMessage, out string prgchText, int cchTextMax, out EChatEntryType peChatEntryType, out CSteamID psteamidChatter)
		{
			InteropHelp.TestIfAvailableClient();
			IntPtr intPtr = Marshal.AllocHGlobal(cchTextMax);
			int num = NativeMethods.ISteamFriends_GetClanChatMessage(steamIDClanChat, iMessage, intPtr, cchTextMax, out peChatEntryType, out psteamidChatter);
			prgchText = ((num != 0) ? InteropHelp.PtrToStringUTF8(intPtr) : null);
			Marshal.FreeHGlobal(intPtr);
			return num;
		}

		public static bool IsClanChatAdmin(CSteamID steamIDClanChat, CSteamID steamIDUser)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamFriends_IsClanChatAdmin(steamIDClanChat, steamIDUser);
		}

		public static bool IsClanChatWindowOpenInSteam(CSteamID steamIDClanChat)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamFriends_IsClanChatWindowOpenInSteam(steamIDClanChat);
		}

		public static bool OpenClanChatWindowInSteam(CSteamID steamIDClanChat)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamFriends_OpenClanChatWindowInSteam(steamIDClanChat);
		}

		public static bool CloseClanChatWindowInSteam(CSteamID steamIDClanChat)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamFriends_CloseClanChatWindowInSteam(steamIDClanChat);
		}

		public static bool SetListenForFriendsMessages(bool bInterceptEnabled)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamFriends_SetListenForFriendsMessages(bInterceptEnabled);
		}

		public static bool ReplyToFriendMessage(CSteamID steamIDFriend, string pchMsgToSend)
		{
			InteropHelp.TestIfAvailableClient();
			using InteropHelp.UTF8StringHandle pchMsgToSend2 = new InteropHelp.UTF8StringHandle(pchMsgToSend);
			return NativeMethods.ISteamFriends_ReplyToFriendMessage(steamIDFriend, pchMsgToSend2);
		}

		public static int GetFriendMessage(CSteamID steamIDFriend, int iMessageID, out string pvData, int cubData, out EChatEntryType peChatEntryType)
		{
			InteropHelp.TestIfAvailableClient();
			IntPtr intPtr = Marshal.AllocHGlobal(cubData);
			int num = NativeMethods.ISteamFriends_GetFriendMessage(steamIDFriend, iMessageID, intPtr, cubData, out peChatEntryType);
			pvData = ((num != 0) ? InteropHelp.PtrToStringUTF8(intPtr) : null);
			Marshal.FreeHGlobal(intPtr);
			return num;
		}

		public static SteamAPICall_t GetFollowerCount(CSteamID steamID)
		{
			InteropHelp.TestIfAvailableClient();
			return (SteamAPICall_t)NativeMethods.ISteamFriends_GetFollowerCount(steamID);
		}

		public static SteamAPICall_t IsFollowing(CSteamID steamID)
		{
			InteropHelp.TestIfAvailableClient();
			return (SteamAPICall_t)NativeMethods.ISteamFriends_IsFollowing(steamID);
		}

		public static SteamAPICall_t EnumerateFollowingList(uint unStartIndex)
		{
			InteropHelp.TestIfAvailableClient();
			return (SteamAPICall_t)NativeMethods.ISteamFriends_EnumerateFollowingList(unStartIndex);
		}
	}
	public static class SteamGameServer
	{
		public static bool InitGameServer(uint unIP, ushort usGamePort, ushort usQueryPort, uint unFlags, AppId_t nGameAppId, string pchVersionString)
		{
			InteropHelp.TestIfAvailableGameServer();
			using InteropHelp.UTF8StringHandle pchVersionString2 = new InteropHelp.UTF8StringHandle(pchVersionString);
			return NativeMethods.ISteamGameServer_InitGameServer(unIP, usGamePort, usQueryPort, unFlags, nGameAppId, pchVersionString2);
		}

		public static void SetProduct(string pszProduct)
		{
			InteropHelp.TestIfAvailableGameServer();
			using InteropHelp.UTF8StringHandle pszProduct2 = new InteropHelp.UTF8StringHandle(pszProduct);
			NativeMethods.ISteamGameServer_SetProduct(pszProduct2);
		}

		public static void SetGameDescription(string pszGameDescription)
		{
			InteropHelp.TestIfAvailableGameServer();
			using InteropHelp.UTF8StringHandle pszGameDescription2 = new InteropHelp.UTF8StringHandle(pszGameDescription);
			NativeMethods.ISteamGameServer_SetGameDescription(pszGameDescription2);
		}

		public static void SetModDir(string pszModDir)
		{
			InteropHelp.TestIfAvailableGameServer();
			using InteropHelp.UTF8StringHandle pszModDir2 = new InteropHelp.UTF8StringHandle(pszModDir);
			NativeMethods.ISteamGameServer_SetModDir(pszModDir2);
		}

		public static void SetDedicatedServer(bool bDedicated)
		{
			InteropHelp.TestIfAvailableGameServer();
			NativeMethods.ISteamGameServer_SetDedicatedServer(bDedicated);
		}

		public static void LogOn(string pszToken)
		{
			InteropHelp.TestIfAvailableGameServer();
			using InteropHelp.UTF8StringHandle pszToken2 = new InteropHelp.UTF8StringHandle(pszToken);
			NativeMethods.ISteamGameServer_LogOn(pszToken2);
		}

		public static void LogOnAnonymous()
		{
			InteropHelp.TestIfAvailableGameServer();
			NativeMethods.ISteamGameServer_LogOnAnonymous();
		}

		public static void LogOff()
		{
			InteropHelp.TestIfAvailableGameServer();
			NativeMethods.ISteamGameServer_LogOff();
		}

		public static bool BLoggedOn()
		{
			InteropHelp.TestIfAvailableGameServer();
			return NativeMethods.ISteamGameServer_BLoggedOn();
		}

		public static bool BSecure()
		{
			InteropHelp.TestIfAvailableGameServer();
			return NativeMethods.ISteamGameServer_BSecure();
		}

		public static CSteamID GetSteamID()
		{
			InteropHelp.TestIfAvailableGameServer();
			return (CSteamID)NativeMethods.ISteamGameServer_GetSteamID();
		}

		public static bool WasRestartRequested()
		{
			InteropHelp.TestIfAvailableGameServer();
			return NativeMethods.ISteamGameServer_WasRestartRequested();
		}

		public static void SetMaxPlayerCount(int cPlayersMax)
		{
			InteropHelp.TestIfAvailableGameServer();
			NativeMethods.ISteamGameServer_SetMaxPlayerCount(cPlayersMax);
		}

		public static void SetBotPlayerCount(int cBotplayers)
		{
			InteropHelp.TestIfAvailableGameServer();
			NativeMethods.ISteamGameServer_SetBotPlayerCount(cBotplayers);
		}

		public static void SetServerName(string pszServerName)
		{
			InteropHelp.TestIfAvailableGameServer();
			using InteropHelp.UTF8StringHandle pszServerName2 = new InteropHelp.UTF8StringHandle(pszServerName);
			NativeMethods.ISteamGameServer_SetServerName(pszServerName2);
		}

		public static void SetMapName(string pszMapName)
		{
			InteropHelp.TestIfAvailableGameServer();
			using InteropHelp.UTF8StringHandle pszMapName2 = new InteropHelp.UTF8StringHandle(pszMapName);
			NativeMethods.ISteamGameServer_SetMapName(pszMapName2);
		}

		public static void SetPasswordProtected(bool bPasswordProtected)
		{
			InteropHelp.TestIfAvailableGameServer();
			NativeMethods.ISteamGameServer_SetPasswordProtected(bPasswordProtected);
		}

		public static void SetSpectatorPort(ushort unSpectatorPort)
		{
			InteropHelp.TestIfAvailableGameServer();
			NativeMethods.ISteamGameServer_SetSpectatorPort(unSpectatorPort);
		}

		public static void SetSpectatorServerName(string pszSpectatorServerName)
		{
			InteropHelp.TestIfAvailableGameServer();
			using InteropHelp.UTF8StringHandle pszSpectatorServerName2 = new InteropHelp.UTF8StringHandle(pszSpectatorServerName);
			NativeMethods.ISteamGameServer_SetSpectatorServerName(pszSpectatorServerName2);
		}

		public static void ClearAllKeyValues()
		{
			InteropHelp.TestIfAvailableGameServer();
			NativeMethods.ISteamGameServer_ClearAllKeyValues();
		}

		public static void SetKeyValue(string pKey, string pValue)
		{
			InteropHelp.TestIfAvailableGameServer();
			using InteropHelp.UTF8StringHandle pKey2 = new InteropHelp.UTF8StringHandle(pKey);
			using InteropHelp.UTF8StringHandle pValue2 = new InteropHelp.UTF8StringHandle(pValue);
			NativeMethods.ISteamGameServer_SetKeyValue(pKey2, pValue2);
		}

		public static void SetGameTags(string pchGameTags)
		{
			InteropHelp.TestIfAvailableGameServer();
			using InteropHelp.UTF8StringHandle pchGameTags2 = new InteropHelp.UTF8StringHandle(pchGameTags);
			NativeMethods.ISteamGameServer_SetGameTags(pchGameTags2);
		}

		public static void SetGameData(string pchGameData)
		{
			InteropHelp.TestIfAvailableGameServer();
			using InteropHelp.UTF8StringHandle pchGameData2 = new InteropHelp.UTF8StringHandle(pchGameData);
			NativeMethods.ISteamGameServer_SetGameData(pchGameData2);
		}

		public static void SetRegion(string pszRegion)
		{
			InteropHelp.TestIfAvailableGameServer();
			using InteropHelp.UTF8StringHandle pszRegion2 = new InteropHelp.UTF8StringHandle(pszRegion);
			NativeMethods.ISteamGameServer_SetRegion(pszRegion2);
		}

		public static bool SendUserConnectAndAuthenticate(uint unIPClient, byte[] pvAuthBlob, uint cubAuthBlobSize, out CSteamID pSteamIDUser)
		{
			InteropHelp.TestIfAvailableGameServer();
			return NativeMethods.ISteamGameServer_SendUserConnectAndAuthenticate(unIPClient, pvAuthBlob, cubAuthBlobSize, out pSteamIDUser);
		}

		public static CSteamID CreateUnauthenticatedUserConnection()
		{
			InteropHelp.TestIfAvailableGameServer();
			return (CSteamID)NativeMethods.ISteamGameServer_CreateUnauthenticatedUserConnection();
		}

		public static void SendUserDisconnect(CSteamID steamIDUser)
		{
			InteropHelp.TestIfAvailableGameServer();
			NativeMethods.ISteamGameServer_SendUserDisconnect(steamIDUser);
		}

		public static bool BUpdateUserData(CSteamID steamIDUser, string pchPlayerName, uint uScore)
		{
			InteropHelp.TestIfAvailableGameServer();
			using InteropHelp.UTF8StringHandle pchPlayerName2 = new InteropHelp.UTF8StringHandle(pchPlayerName);
			return NativeMethods.ISteamGameServer_BUpdateUserData(steamIDUser, pchPlayerName2, uScore);
		}

		public static HAuthTicket GetAuthSessionTicket(byte[] pTicket, int cbMaxTicket, out uint pcbTicket)
		{
			InteropHelp.TestIfAvailableGameServer();
			return (HAuthTicket)NativeMethods.ISteamGameServer_GetAuthSessionTicket(pTicket, cbMaxTicket, out pcbTicket);
		}

		public static EBeginAuthSessionResult BeginAuthSession(byte[] pAuthTicket, int cbAuthTicket, CSteamID steamID)
		{
			InteropHelp.TestIfAvailableGameServer();
			return NativeMethods.ISteamGameServer_BeginAuthSession(pAuthTicket, cbAuthTicket, steamID);
		}

		public static void EndAuthSession(CSteamID steamID)
		{
			InteropHelp.TestIfAvailableGameServer();
			NativeMethods.ISteamGameServer_EndAuthSession(steamID);
		}

		public static void CancelAuthTicket(HAuthTicket hAuthTicket)
		{
			InteropHelp.TestIfAvailableGameServer();
			NativeMethods.ISteamGameServer_CancelAuthTicket(hAuthTicket);
		}

		public static EUserHasLicenseForAppResult UserHasLicenseForApp(CSteamID steamID, AppId_t appID)
		{
			InteropHelp.TestIfAvailableGameServer();
			return NativeMethods.ISteamGameServer_UserHasLicenseForApp(steamID, appID);
		}

		public static bool RequestUserGroupStatus(CSteamID steamIDUser, CSteamID steamIDGroup)
		{
			InteropHelp.TestIfAvailableGameServer();
			return NativeMethods.ISteamGameServer_RequestUserGroupStatus(steamIDUser, steamIDGroup);
		}

		public static void GetGameplayStats()
		{
			InteropHelp.TestIfAvailableGameServer();
			NativeMethods.ISteamGameServer_GetGameplayStats();
		}

		public static SteamAPICall_t GetServerReputation()
		{
			InteropHelp.TestIfAvailableGameServer();
			return (SteamAPICall_t)NativeMethods.ISteamGameServer_GetServerReputation();
		}

		public static uint GetPublicIP()
		{
			InteropHelp.TestIfAvailableGameServer();
			return NativeMethods.ISteamGameServer_GetPublicIP();
		}

		public static bool HandleIncomingPacket(byte[] pData, int cbData, uint srcIP, ushort srcPort)
		{
			InteropHelp.TestIfAvailableGameServer();
			return NativeMethods.ISteamGameServer_HandleIncomingPacket(pData, cbData, srcIP, srcPort);
		}

		public static int GetNextOutgoingPacket(byte[] pOut, int cbMaxOut, out uint pNetAdr, out ushort pPort)
		{
			InteropHelp.TestIfAvailableGameServer();
			return NativeMethods.ISteamGameServer_GetNextOutgoingPacket(pOut, cbMaxOut, out pNetAdr, out pPort);
		}

		public static void EnableHeartbeats(bool bActive)
		{
			InteropHelp.TestIfAvailableGameServer();
			NativeMethods.ISteamGameServer_EnableHeartbeats(bActive);
		}

		public static void SetHeartbeatInterval(int iHeartbeatInterval)
		{
			InteropHelp.TestIfAvailableGameServer();
			NativeMethods.ISteamGameServer_SetHeartbeatInterval(iHeartbeatInterval);
		}

		public static void ForceHeartbeat()
		{
			InteropHelp.TestIfAvailableGameServer();
			NativeMethods.ISteamGameServer_ForceHeartbeat();
		}

		public static SteamAPICall_t AssociateWithClan(CSteamID steamIDClan)
		{
			InteropHelp.TestIfAvailableGameServer();
			return (SteamAPICall_t)NativeMethods.ISteamGameServer_AssociateWithClan(steamIDClan);
		}

		public static SteamAPICall_t ComputeNewPlayerCompatibility(CSteamID steamIDNewPlayer)
		{
			InteropHelp.TestIfAvailableGameServer();
			return (SteamAPICall_t)NativeMethods.ISteamGameServer_ComputeNewPlayerCompatibility(steamIDNewPlayer);
		}
	}
	public static class SteamGameServerHTTP
	{
		public static HTTPRequestHandle CreateHTTPRequest(EHTTPMethod eHTTPRequestMethod, string pchAbsoluteURL)
		{
			InteropHelp.TestIfAvailableGameServer();
			using InteropHelp.UTF8StringHandle pchAbsoluteURL2 = new InteropHelp.UTF8StringHandle(pchAbsoluteURL);
			return (HTTPRequestHandle)NativeMethods.ISteamGameServerHTTP_CreateHTTPRequest(eHTTPRequestMethod, pchAbsoluteURL2);
		}

		public static bool SetHTTPRequestContextValue(HTTPRequestHandle hRequest, ulong ulContextValue)
		{
			InteropHelp.TestIfAvailableGameServer();
			return NativeMethods.ISteamGameServerHTTP_SetHTTPRequestContextValue(hRequest, ulContextValue);
		}

		public static bool SetHTTPRequestNetworkActivityTimeout(HTTPRequestHandle hRequest, uint unTimeoutSeconds)
		{
			InteropHelp.TestIfAvailableGameServer();
			return NativeMethods.ISteamGameServerHTTP_SetHTTPRequestNetworkActivityTimeout(hRequest, unTimeoutSeconds);
		}

		public static bool SetHTTPRequestHeaderValue(HTTPRequestHandle hRequest, string pchHeaderName, string pchHeaderValue)
		{
			InteropHelp.TestIfAvailableGameServer();
			using InteropHelp.UTF8StringHandle pchHeaderName2 = new InteropHelp.UTF8StringHandle(pchHeaderName);
			using InteropHelp.UTF8StringHandle pchHeaderValue2 = new InteropHelp.UTF8StringHandle(pchHeaderValue);
			return NativeMethods.ISteamGameServerHTTP_SetHTTPRequestHeaderValue(hRequest, pchHeaderName2, pchHeaderValue2);
		}

		public static bool SetHTTPRequestGetOrPostParameter(HTTPRequestHandle hRequest, string pchParamName, string pchParamValue)
		{
			InteropHelp.TestIfAvailableGameServer();
			using InteropHelp.UTF8StringHandle pchParamName2 = new InteropHelp.UTF8StringHandle(pchParamName);
			using InteropHelp.UTF8StringHandle pchParamValue2 = new InteropHelp.UTF8StringHandle(pchParamValue);
			return NativeMethods.ISteamGameServerHTTP_SetHTTPRequestGetOrPostParameter(hRequest, pchParamName2, pchParamValue2);
		}

		public static bool SendHTTPRequest(HTTPRequestHandle hRequest, out SteamAPICall_t pCallHandle)
		{
			InteropHelp.TestIfAvailableGameServer();
			return NativeMethods.ISteamGameServerHTTP_SendHTTPRequest(hRequest, out pCallHandle);
		}

		public static bool SendHTTPRequestAndStreamResponse(HTTPRequestHandle hRequest, out SteamAPICall_t pCallHandle)
		{
			InteropHelp.TestIfAvailableGameServer();
			return NativeMethods.ISteamGameServerHTTP_SendHTTPRequestAndStreamResponse(hRequest, out pCallHandle);
		}

		public static bool DeferHTTPRequest(HTTPRequestHandle hRequest)
		{
			InteropHelp.TestIfAvailableGameServer();
			return NativeMethods.ISteamGameServerHTTP_DeferHTTPRequest(hRequest);
		}

		public static bool PrioritizeHTTPRequest(HTTPRequestHandle hRequest)
		{
			InteropHelp.TestIfAvailableGameServer();
			return NativeMethods.ISteamGameServerHTTP_PrioritizeHTTPRequest(hRequest);
		}

		public static bool GetHTTPResponseHeaderSize(HTTPRequestHandle hRequest, string pchHeaderName, out uint unResponseHeaderSize)
		{
			InteropHelp.TestIfAvailableGameServer();
			using InteropHelp.UTF8StringHandle pchHeaderName2 = new InteropHelp.UTF8StringHandle(pchHeaderName);
			return NativeMethods.ISteamGameServerHTTP_GetHTTPResponseHeaderSize(hRequest, pchHeaderName2, out unResponseHeaderSize);
		}

		public static bool GetHTTPResponseHeaderValue(HTTPRequestHandle hRequest, string pchHeaderName, byte[] pHeaderValueBuffer, uint unBufferSize)
		{
			InteropHelp.TestIfAvailableGameServer();
			using InteropHelp.UTF8StringHandle pchHeaderName2 = new InteropHelp.UTF8StringHandle(pchHeaderName);
			return NativeMethods.ISteamGameServerHTTP_GetHTTPResponseHeaderValue(hRequest, pchHeaderName2, pHeaderValueBuffer, unBufferSize);
		}

		public static bool GetHTTPResponseBodySize(HTTPRequestHandle hRequest, out uint unBodySize)
		{
			InteropHelp.TestIfAvailableGameServer();
			return NativeMethods.ISteamGameServerHTTP_GetHTTPResponseBodySize(hRequest, out unBodySize);
		}

		public static bool GetHTTPResponseBodyData(HTTPRequestHandle hRequest, byte[] pBodyDataBuffer, uint unBufferSize)
		{
			InteropHelp.TestIfAvailableGameServer();
			return NativeMethods.ISteamGameServerHTTP_GetHTTPResponseBodyData(hRequest, pBodyDataBuffer, unBufferSize);
		}

		public static bool GetHTTPStreamingResponseBodyData(HTTPRequestHandle hRequest, uint cOffset, byte[] pBodyDataBuffer, uint unBufferSize)
		{
			InteropHelp.TestIfAvailableGameServer();
			return NativeMethods.ISteamGameServerHTTP_GetHTTPStreamingResponseBodyData(hRequest, cOffset, pBodyDataBuffer, unBufferSize);
		}

		public static bool ReleaseHTTPRequest(HTTPRequestHandle hRequest)
		{
			InteropHelp.TestIfAvailableGameServer();
			return NativeMethods.ISteamGameServerHTTP_ReleaseHTTPRequest(hRequest);
		}

		public static bool GetHTTPDownloadProgressPct(HTTPRequestHandle hRequest, out float pflPercentOut)
		{
			InteropHelp.TestIfAvailableGameServer();
			return NativeMethods.ISteamGameServerHTTP_GetHTTPDownloadProgressPct(hRequest, out pflPercentOut);
		}

		public static bool SetHTTPRequestRawPostBody(HTTPRequestHandle hRequest, string pchContentType, byte[] pubBody, uint unBodyLen)
		{
			InteropHelp.TestIfAvailableGameServer();
			using InteropHelp.UTF8StringHandle pchContentType2 = new InteropHelp.UTF8StringHandle(pchContentType);
			return NativeMethods.ISteamGameServerHTTP_SetHTTPRequestRawPostBody(hRequest, pchContentType2, pubBody, unBodyLen);
		}

		public static HTTPCookieContainerHandle CreateCookieContainer(bool bAllowResponsesToModify)
		{
			InteropHelp.TestIfAvailableGameServer();
			return (HTTPCookieContainerHandle)NativeMethods.ISteamGameServerHTTP_CreateCookieContainer(bAllowResponsesToModify);
		}

		public static bool ReleaseCookieContainer(HTTPCookieContainerHandle hCookieContainer)
		{
			InteropHelp.TestIfAvailableGameServer();
			return NativeMethods.ISteamGameServerHTTP_ReleaseCookieContainer(hCookieContainer);
		}

		public static bool SetCookie(HTTPCookieContainerHandle hCookieContainer, string pchHost, string pchUrl, string pchCookie)
		{
			InteropHelp.TestIfAvailableGameServer();
			using InteropHelp.UTF8StringHandle pchHost2 = new InteropHelp.UTF8StringHandle(pchHost);
			using InteropHelp.UTF8StringHandle pchUrl2 = new InteropHelp.UTF8StringHandle(pchUrl);
			using InteropHelp.UTF8StringHandle pchCookie2 = new InteropHelp.UTF8StringHandle(pchCookie);
			return NativeMethods.ISteamGameServerHTTP_SetCookie(hCookieContainer, pchHost2, pchUrl2, pchCookie2);
		}

		public static bool SetHTTPRequestCookieContainer(HTTPRequestHandle hRequest, HTTPCookieContainerHandle hCookieContainer)
		{
			InteropHelp.TestIfAvailableGameServer();
			return NativeMethods.ISteamGameServerHTTP_SetHTTPRequestCookieContainer(hRequest, hCookieContainer);
		}

		public static bool SetHTTPRequestUserAgentInfo(HTTPRequestHandle hRequest, string pchUserAgentInfo)
		{
			InteropHelp.TestIfAvailableGameServer();
			using InteropHelp.UTF8StringHandle pchUserAgentInfo2 = new InteropHelp.UTF8StringHandle(pchUserAgentInfo);
			return NativeMethods.ISteamGameServerHTTP_SetHTTPRequestUserAgentInfo(hRequest, pchUserAgentInfo2);
		}

		public static bool SetHTTPRequestRequiresVerifiedCertificate(HTTPRequestHandle hRequest, bool bRequireVerifiedCertificate)
		{
			InteropHelp.TestIfAvailableGameServer();
			return NativeMethods.ISteamGameServerHTTP_SetHTTPRequestRequiresVerifiedCertificate(hRequest, bRequireVerifiedCertificate);
		}

		public static bool SetHTTPRequestAbsoluteTimeoutMS(HTTPRequestHandle hRequest, uint unMilliseconds)
		{
			InteropHelp.TestIfAvailableGameServer();
			return NativeMethods.ISteamGameServerHTTP_SetHTTPRequestAbsoluteTimeoutMS(hRequest, unMilliseconds);
		}

		public static bool GetHTTPRequestWasTimedOut(HTTPRequestHandle hRequest, out bool pbWasTimedOut)
		{
			InteropHelp.TestIfAvailableGameServer();
			return NativeMethods.ISteamGameServerHTTP_GetHTTPRequestWasTimedOut(hRequest, out pbWasTimedOut);
		}
	}
	public static class SteamGameServerInventory
	{
		public static EResult GetResultStatus(SteamInventoryResult_t resultHandle)
		{
			InteropHelp.TestIfAvailableGameServer();
			return NativeMethods.ISteamGameServerInventory_GetResultStatus(resultHandle);
		}

		public static bool GetResultItems(SteamInventoryResult_t resultHandle, SteamItemDetails_t[] pOutItemsArray, ref uint punOutItemsArraySize)
		{
			InteropHelp.TestIfAvailableGameServer();
			return NativeMethods.ISteamGameServerInventory_GetResultItems(resultHandle, pOutItemsArray, ref punOutItemsArraySize);
		}

		public static uint GetResultTimestamp(SteamInventoryResult_t resultHandle)
		{
			InteropHelp.TestIfAvailableGameServer();
			return NativeMethods.ISteamGameServerInventory_GetResultTimestamp(resultHandle);
		}

		public static bool CheckResultSteamID(SteamInventoryResult_t resultHandle, CSteamID steamIDExpected)
		{
			InteropHelp.TestIfAvailableGameServer();
			return NativeMethods.ISteamGameServerInventory_CheckResultSteamID(resultHandle, steamIDExpected);
		}

		public static void DestroyResult(SteamInventoryResult_t resultHandle)
		{
			InteropHelp.TestIfAvailableGameServer();
			NativeMethods.ISteamGameServerInventory_DestroyResult(resultHandle);
		}

		public static bool GetAllItems(out SteamInventoryResult_t pResultHandle)
		{
			InteropHelp.TestIfAvailableGameServer();
			return NativeMethods.ISteamGameServerInventory_GetAllItems(out pResultHandle);
		}

		public static bool GetItemsByID(out SteamInventoryResult_t pResultHandle, SteamItemInstanceID_t[] pInstanceIDs, uint unCountInstanceIDs)
		{
			InteropHelp.TestIfAvailableGameServer();
			return NativeMethods.ISteamGameServerInventory_GetItemsByID(out pResultHandle, pInstanceIDs, unCountInstanceIDs);
		}

		public static bool SerializeResult(SteamInventoryResult_t resultHandle, byte[] pOutBuffer, out uint punOutBufferSize)
		{
			InteropHelp.TestIfAvailableGameServer();
			return NativeMethods.ISteamGameServerInventory_SerializeResult(resultHandle, pOutBuffer, out punOutBufferSize);
		}

		public static bool DeserializeResult(out SteamInventoryResult_t pOutResultHandle, byte[] pBuffer, uint unBufferSize, bool bRESERVED_MUST_BE_FALSE = false)
		{
			InteropHelp.TestIfAvailableGameServer();
			return NativeMethods.ISteamGameServerInventory_DeserializeResult(out pOutResultHandle, pBuffer, unBufferSize, bRESERVED_MUST_BE_FALSE);
		}

		public static bool GenerateItems(out SteamInventoryResult_t pResultHandle, SteamItemDef_t[] pArrayItemDefs, uint[] punArrayQuantity, uint unArrayLength)
		{
			InteropHelp.TestIfAvailableGameServer();
			return NativeMethods.ISteamGameServerInventory_GenerateItems(out pResultHandle, pArrayItemDefs, punArrayQuantity, unArrayLength);
		}

		public static bool GrantPromoItems(out SteamInventoryResult_t pResultHandle)
		{
			InteropHelp.TestIfAvailableGameServer();
			return NativeMethods.ISteamGameServerInventory_GrantPromoItems(out pResultHandle);
		}

		public static bool AddPromoItem(out SteamInventoryResult_t pResultHandle, SteamItemDef_t itemDef)
		{
			InteropHelp.TestIfAvailableGameServer();
			return NativeMethods.ISteamGameServerInventory_AddPromoItem(out pResultHandle, itemDef);
		}

		public static bool AddPromoItems(out SteamInventoryResult_t pResultHandle, SteamItemDef_t[] pArrayItemDefs, uint unArrayLength)
		{
			InteropHelp.TestIfAvailableGameServer();
			return NativeMethods.ISteamGameServerInventory_AddPromoItems(out pResultHandle, pArrayItemDefs, unArrayLength);
		}

		public static bool ConsumeItem(out SteamInventoryResult_t pResultHandle, SteamItemInstanceID_t itemConsume, uint unQuantity)
		{
			InteropHelp.TestIfAvailableGameServer();
			return NativeMethods.ISteamGameServerInventory_ConsumeItem(out pResultHandle, itemConsume, unQuantity);
		}

		public static bool ExchangeItems(out SteamInventoryResult_t pResultHandle, SteamItemDef_t[] pArrayGenerate, uint[] punArrayGenerateQuantity, uint unArrayGenerateLength, SteamItemInstanceID_t[] pArrayDestroy, uint[] punArrayDestroyQuantity, uint unArrayDestroyLength)
		{
			InteropHelp.TestIfAvailableGameServer();
			return NativeMethods.ISteamGameServerInventory_ExchangeItems(out pResultHandle, pArrayGenerate, punArrayGenerateQuantity, unArrayGenerateLength, pArrayDestroy, punArrayDestroyQuantity, unArrayDestroyLength);
		}

		public static bool TransferItemQuantity(out SteamInventoryResult_t pResultHandle, SteamItemInstanceID_t itemIdSource, uint unQuantity, SteamItemInstanceID_t itemIdDest)
		{
			InteropHelp.TestIfAvailableGameServer();
			return NativeMethods.ISteamGameServerInventory_TransferItemQuantity(out pResultHandle, itemIdSource, unQuantity, itemIdDest);
		}

		public static void SendItemDropHeartbeat()
		{
			InteropHelp.TestIfAvailableGameServer();
			NativeMethods.ISteamGameServerInventory_SendItemDropHeartbeat();
		}

		public static bool TriggerItemDrop(out SteamInventoryResult_t pResultHandle, SteamItemDef_t dropListDefinition)
		{
			InteropHelp.TestIfAvailableGameServer();
			return NativeMethods.ISteamGameServerInventory_TriggerItemDrop(out pResultHandle, dropListDefinition);
		}

		public static bool TradeItems(out SteamInventoryResult_t pResultHandle, CSteamID steamIDTradePartner, SteamItemInstanceID_t[] pArrayGive, uint[] pArrayGiveQuantity, uint nArrayGiveLength, SteamItemInstanceID_t[] pArrayGet, uint[] pArrayGetQuantity, uint nArrayGetLength)
		{
			InteropHelp.TestIfAvailableGameServer();
			return NativeMethods.ISteamGameServerInventory_TradeItems(out pResultHandle, steamIDTradePartner, pArrayGive, pArrayGiveQuantity, nArrayGiveLength, pArrayGet, pArrayGetQuantity, nArrayGetLength);
		}

		public static bool LoadItemDefinitions()
		{
			InteropHelp.TestIfAvailableGameServer();
			return NativeMethods.ISteamGameServerInventory_LoadItemDefinitions();
		}

		public static bool GetItemDefinitionIDs(SteamItemDef_t[] pItemDefIDs, out uint punItemDefIDsArraySize)
		{
			InteropHelp.TestIfAvailableGameServer();
			return NativeMethods.ISteamGameServerInventory_GetItemDefinitionIDs(pItemDefIDs, out punItemDefIDsArraySize);
		}

		public static bool GetItemDefinitionProperty(SteamItemDef_t iDefinition, string pchPropertyName, out string pchValueBuffer, ref uint punValueBufferSize)
		{
			InteropHelp.TestIfAvailableGameServer();
			IntPtr intPtr = Marshal.AllocHGlobal((int)punValueBufferSize);
			using InteropHelp.UTF8StringHandle pchPropertyName2 = new InteropHelp.UTF8StringHandle(pchPropertyName);
			bool flag = NativeMethods.ISteamGameServerInventory_GetItemDefinitionProperty(iDefinition, pchPropertyName2, intPtr, ref punValueBufferSize);
			pchValueBuffer = (flag ? InteropHelp.PtrToStringUTF8(intPtr) : null);
			Marshal.FreeHGlobal(intPtr);
			return flag;
		}
	}
	public static class SteamGameServerNetworking
	{
		public static bool SendP2PPacket(CSteamID steamIDRemote, byte[] pubData, uint cubData, EP2PSend eP2PSendType, int nChannel = 0)
		{
			InteropHelp.TestIfAvailableGameServer();
			return NativeMethods.ISteamGameServerNetworking_SendP2PPacket(steamIDRemote, pubData, cubData, eP2PSendType, nChannel);
		}

		public static bool IsP2PPacketAvailable(out uint pcubMsgSize, int nChannel = 0)
		{
			InteropHelp.TestIfAvailableGameServer();
			return NativeMethods.ISteamGameServerNetworking_IsP2PPacketAvailable(out pcubMsgSize, nChannel);
		}

		public static bool ReadP2PPacket(byte[] pubDest, uint cubDest, out uint pcubMsgSize, out CSteamID psteamIDRemote, int nChannel = 0)
		{
			InteropHelp.TestIfAvailableGameServer();
			return NativeMethods.ISteamGameServerNetworking_ReadP2PPacket(pubDest, cubDest, out pcubMsgSize, out psteamIDRemote, nChannel);
		}

		public static bool AcceptP2PSessionWithUser(CSteamID steamIDRemote)
		{
			InteropHelp.TestIfAvailableGameServer();
			return NativeMethods.ISteamGameServerNetworking_AcceptP2PSessionWithUser(steamIDRemote);
		}

		public static bool CloseP2PSessionWithUser(CSteamID steamIDRemote)
		{
			InteropHelp.TestIfAvailableGameServer();
			return NativeMethods.ISteamGameServerNetworking_CloseP2PSessionWithUser(steamIDRemote);
		}

		public static bool CloseP2PChannelWithUser(CSteamID steamIDRemote, int nChannel)
		{
			InteropHelp.TestIfAvailableGameServer();
			return NativeMethods.ISteamGameServerNetworking_CloseP2PChannelWithUser(steamIDRemote, nChannel);
		}

		public static bool GetP2PSessionState(CSteamID steamIDRemote, out P2PSessionState_t pConnectionState)
		{
			InteropHelp.TestIfAvailableGameServer();
			return NativeMethods.ISteamGameServerNetworking_GetP2PSessionState(steamIDRemote, out pConnectionState);
		}

		public static bool AllowP2PPacketRelay(bool bAllow)
		{
			InteropHelp.TestIfAvailableGameServer();
			return NativeMethods.ISteamGameServerNetworking_AllowP2PPacketRelay(bAllow);
		}

		public static SNetListenSocket_t CreateListenSocket(int nVirtualP2PPort, uint nIP, ushort nPort, bool bAllowUseOfPacketRelay)
		{
			InteropHelp.TestIfAvailableGameServer();
			return (SNetListenSocket_t)NativeMethods.ISteamGameServerNetworking_CreateListenSocket(nVirtualP2PPort, nIP, nPort, bAllowUseOfPacketRelay);
		}

		public static SNetSocket_t CreateP2PConnectionSocket(CSteamID steamIDTarget, int nVirtualPort, int nTimeoutSec, bool bAllowUseOfPacketRelay)
		{
			InteropHelp.TestIfAvailableGameServer();
			return (SNetSocket_t)NativeMethods.ISteamGameServerNetworking_CreateP2PConnectionSocket(steamIDTarget, nVirtualPort, nTimeoutSec, bAllowUseOfPacketRelay);
		}

		public static SNetSocket_t CreateConnectionSocket(uint nIP, ushort nPort, int nTimeoutSec)
		{
			InteropHelp.TestIfAvailableGameServer();
			return (SNetSocket_t)NativeMethods.ISteamGameServerNetworking_CreateConnectionSocket(nIP, nPort, nTimeoutSec);
		}

		public static bool DestroySocket(SNetSocket_t hSocket, bool bNotifyRemoteEnd)
		{
			InteropHelp.TestIfAvailableGameServer();
			return NativeMethods.ISteamGameServerNetworking_DestroySocket(hSocket, bNotifyRemoteEnd);
		}

		public static bool DestroyListenSocket(SNetListenSocket_t hSocket, bool bNotifyRemoteEnd)
		{
			InteropHelp.TestIfAvailableGameServer();
			return NativeMethods.ISteamGameServerNetworking_DestroyListenSocket(hSocket, bNotifyRemoteEnd);
		}

		public static bool SendDataOnSocket(SNetSocket_t hSocket, IntPtr pubData, uint cubData, bool bReliable)
		{
			InteropHelp.TestIfAvailableGameServer();
			return NativeMethods.ISteamGameServerNetworking_SendDataOnSocket(hSocket, pubData, cubData, bReliable);
		}

		public static bool IsDataAvailableOnSocket(SNetSocket_t hSocket, out uint pcubMsgSize)
		{
			InteropHelp.TestIfAvailableGameServer();
			return NativeMethods.ISteamGameServerNetworking_IsDataAvailableOnSocket(hSocket, out pcubMsgSize);
		}

		public static bool RetrieveDataFromSocket(SNetSocket_t hSocket, IntPtr pubDest, uint cubDest, out uint pcubMsgSize)
		{
			InteropHelp.TestIfAvailableGameServer();
			return NativeMethods.ISteamGameServerNetworking_RetrieveDataFromSocket(hSocket, pubDest, cubDest, out pcubMsgSize);
		}

		public static bool IsDataAvailable(SNetListenSocket_t hListenSocket, out uint pcubMsgSize, out SNetSocket_t phSocket)
		{
			InteropHelp.TestIfAvailableGameServer();
			return NativeMethods.ISteamGameServerNetworking_IsDataAvailable(hListenSocket, out pcubMsgSize, out phSocket);
		}

		public static bool RetrieveData(SNetListenSocket_t hListenSocket, IntPtr pubDest, uint cubDest, out uint pcubMsgSize, out SNetSocket_t phSocket)
		{
			InteropHelp.TestIfAvailableGameServer();
			return NativeMethods.ISteamGameServerNetworking_RetrieveData(hListenSocket, pubDest, cubDest, out pcubMsgSize, out phSocket);
		}

		public static bool GetSocketInfo(SNetSocket_t hSocket, out CSteamID pSteamIDRemote, out int peSocketStatus, out uint punIPRemote, out ushort punPortRemote)
		{
			InteropHelp.TestIfAvailableGameServer();
			return NativeMethods.ISteamGameServerNetworking_GetSocketInfo(hSocket, out pSteamIDRemote, out peSocketStatus, out punIPRemote, out punPortRemote);
		}

		public static bool GetListenSocketInfo(SNetListenSocket_t hListenSocket, out uint pnIP, out ushort pnPort)
		{
			InteropHelp.TestIfAvailableGameServer();
			return NativeMethods.ISteamGameServerNetworking_GetListenSocketInfo(hListenSocket, out pnIP, out pnPort);
		}

		public static ESNetSocketConnectionType GetSocketConnectionType(SNetSocket_t hSocket)
		{
			InteropHelp.TestIfAvailableGameServer();
			return NativeMethods.ISteamGameServerNetworking_GetSocketConnectionType(hSocket);
		}

		public static int GetMaxPacketSize(SNetSocket_t hSocket)
		{
			InteropHelp.TestIfAvailableGameServer();
			return NativeMethods.ISteamGameServerNetworking_GetMaxPacketSize(hSocket);
		}
	}
	public static class SteamGameServerStats
	{
		public static SteamAPICall_t RequestUserStats(CSteamID steamIDUser)
		{
			InteropHelp.TestIfAvailableGameServer();
			return (SteamAPICall_t)NativeMethods.ISteamGameServerStats_RequestUserStats(steamIDUser);
		}

		public static bool GetUserStat(CSteamID steamIDUser, string pchName, out int pData)
		{
			InteropHelp.TestIfAvailableGameServer();
			using InteropHelp.UTF8StringHandle pchName2 = new InteropHelp.UTF8StringHandle(pchName);
			return NativeMethods.ISteamGameServerStats_GetUserStat(steamIDUser, pchName2, out pData);
		}

		public static bool GetUserStat(CSteamID steamIDUser, string pchName, out float pData)
		{
			InteropHelp.TestIfAvailableGameServer();
			using InteropHelp.UTF8StringHandle pchName2 = new InteropHelp.UTF8StringHandle(pchName);
			return NativeMethods.ISteamGameServerStats_GetUserStat_(steamIDUser, pchName2, out pData);
		}

		public static bool GetUserAchievement(CSteamID steamIDUser, string pchName, out bool pbAchieved)
		{
			InteropHelp.TestIfAvailableGameServer();
			using InteropHelp.UTF8StringHandle pchName2 = new InteropHelp.UTF8StringHandle(pchName);
			return NativeMethods.ISteamGameServerStats_GetUserAchievement(steamIDUser, pchName2, out pbAchieved);
		}

		public static bool SetUserStat(CSteamID steamIDUser, string pchName, int nData)
		{
			InteropHelp.TestIfAvailableGameServer();
			using InteropHelp.UTF8StringHandle pchName2 = new InteropHelp.UTF8StringHandle(pchName);
			return NativeMethods.ISteamGameServerStats_SetUserStat(steamIDUser, pchName2, nData);
		}

		public static bool SetUserStat(CSteamID steamIDUser, string pchName, float fData)
		{
			InteropHelp.TestIfAvailableGameServer();
			using InteropHelp.UTF8StringHandle pchName2 = new InteropHelp.UTF8StringHandle(pchName);
			return NativeMethods.ISteamGameServerStats_SetUserStat_(steamIDUser, pchName2, fData);
		}

		public static bool UpdateUserAvgRateStat(CSteamID steamIDUser, string pchName, float flCountThisSession, double dSessionLength)
		{
			InteropHelp.TestIfAvailableGameServer();
			using InteropHelp.UTF8StringHandle pchName2 = new InteropHelp.UTF8StringHandle(pchName);
			return NativeMethods.ISteamGameServerStats_UpdateUserAvgRateStat(steamIDUser, pchName2, flCountThisSession, dSessionLength);
		}

		public static bool SetUserAchievement(CSteamID steamIDUser, string pchName)
		{
			InteropHelp.TestIfAvailableGameServer();
			using InteropHelp.UTF8StringHandle pchName2 = new InteropHelp.UTF8StringHandle(pchName);
			return NativeMethods.ISteamGameServerStats_SetUserAchievement(steamIDUser, pchName2);
		}

		public static bool ClearUserAchievement(CSteamID steamIDUser, string pchName)
		{
			InteropHelp.TestIfAvailableGameServer();
			using InteropHelp.UTF8StringHandle pchName2 = new InteropHelp.UTF8StringHandle(pchName);
			return NativeMethods.ISteamGameServerStats_ClearUserAchievement(steamIDUser, pchName2);
		}

		public static SteamAPICall_t StoreUserStats(CSteamID steamIDUser)
		{
			InteropHelp.TestIfAvailableGameServer();
			return (SteamAPICall_t)NativeMethods.ISteamGameServerStats_StoreUserStats(steamIDUser);
		}
	}
	public static class SteamGameServerUGC
	{
		public static UGCQueryHandle_t CreateQueryUserUGCRequest(AccountID_t unAccountID, EUserUGCList eListType, EUGCMatchingUGCType eMatchingUGCType, EUserUGCListSortOrder eSortOrder, AppId_t nCreatorAppID, AppId_t nConsumerAppID, uint unPage)
		{
			InteropHelp.TestIfAvailableGameServer();
			return (UGCQueryHandle_t)NativeMethods.ISteamGameServerUGC_CreateQueryUserUGCRequest(unAccountID, eListType, eMatchingUGCType, eSortOrder, nCreatorAppID, nConsumerAppID, unPage);
		}

		public static UGCQueryHandle_t CreateQueryAllUGCRequest(EUGCQuery eQueryType, EUGCMatchingUGCType eMatchingeMatchingUGCTypeFileType, AppId_t nCreatorAppID, AppId_t nConsumerAppID, uint unPage)
		{
			InteropHelp.TestIfAvailableGameServer();
			return (UGCQueryHandle_t)NativeMethods.ISteamGameServerUGC_CreateQueryAllUGCRequest(eQueryType, eMatchingeMatchingUGCTypeFileType, nCreatorAppID, nConsumerAppID, unPage);
		}

		public static UGCQueryHandle_t CreateQueryUGCDetailsRequest(PublishedFileId_t[] pvecPublishedFileID, uint unNumPublishedFileIDs)
		{
			InteropHelp.TestIfAvailableGameServer();
			return (UGCQueryHandle_t)NativeMethods.ISteamGameServerUGC_CreateQueryUGCDetailsRequest(pvecPublishedFileID, unNumPublishedFileIDs);
		}

		public static SteamAPICall_t SendQueryUGCRequest(UGCQueryHandle_t handle)
		{
			InteropHelp.TestIfAvailableGameServer();
			return (SteamAPICall_t)NativeMethods.ISteamGameServerUGC_SendQueryUGCRequest(handle);
		}

		public static bool GetQueryUGCResult(UGCQueryHandle_t handle, uint index, out SteamUGCDetails_t pDetails)
		{
			InteropHelp.TestIfAvailableGameServer();
			return NativeMethods.ISteamGameServerUGC_GetQueryUGCResult(handle, index, out pDetails);
		}

		public static bool GetQueryUGCPreviewURL(UGCQueryHandle_t handle, uint index, out string pchURL, uint cchURLSize)
		{
			InteropHelp.TestIfAvailableGameServer();
			IntPtr intPtr = Marshal.AllocHGlobal((int)cchURLSize);
			bool flag = NativeMethods.ISteamGameServerUGC_GetQueryUGCPreviewURL(handle, index, intPtr, cchURLSize);
			pchURL = (flag ? InteropHelp.PtrToStringUTF8(intPtr) : null);
			Marshal.FreeHGlobal(intPtr);
			return flag;
		}

		public static bool GetQueryUGCMetadata(UGCQueryHandle_t handle, uint index, out string pchMetadata, uint cchMetadatasize)
		{
			InteropHelp.TestIfAvailableGameServer();
			IntPtr intPtr = Marshal.AllocHGlobal((int)cchMetadatasize);
			bool flag = NativeMethods.ISteamGameServerUGC_GetQueryUGCMetadata(handle, index, intPtr, cchMetadatasize);
			pchMetadata = (flag ? InteropHelp.PtrToStringUTF8(intPtr) : null);
			Marshal.FreeHGlobal(intPtr);
			return flag;
		}

		public static bool GetQueryUGCChildren(UGCQueryHandle_t handle, uint index, PublishedFileId_t[] pvecPublishedFileID, uint cMaxEntries)
		{
			InteropHelp.TestIfAvailableGameServer();
			return NativeMethods.ISteamGameServerUGC_GetQueryUGCChildren(handle, index, pvecPublishedFileID, cMaxEntries);
		}

		public static bool GetQueryUGCStatistic(UGCQueryHandle_t handle, uint index, EItemStatistic eStatType, out uint pStatValue)
		{
			InteropHelp.TestIfAvailableGameServer();
			return NativeMethods.ISteamGameServerUGC_GetQueryUGCStatistic(handle, index, eStatType, out pStatValue);
		}

		public static uint GetQueryUGCNumAdditionalPreviews(UGCQueryHandle_t handle, uint index)
		{
			InteropHelp.TestIfAvailableGameServer();
			return NativeMethods.ISteamGameServerUGC_GetQueryUGCNumAdditionalPreviews(handle, index);
		}

		public static bool GetQueryUGCAdditionalPreview(UGCQueryHandle_t handle, uint index, uint previewIndex, out string pchURLOrVideoID, uint cchURLSize, out bool pbIsImage)
		{
			InteropHelp.TestIfAvailableGameServer();
			IntPtr intPtr = Marshal.AllocHGlobal((int)cchURLSize);
			bool flag = NativeMethods.ISteamGameServerUGC_GetQueryUGCAdditionalPreview(handle, index, previewIndex, intPtr, cchURLSize, out pbIsImage);
			pchURLOrVideoID = (flag ? InteropHelp.PtrToStringUTF8(intPtr) : null);
			Marshal.FreeHGlobal(intPtr);
			return flag;
		}

		public static uint GetQueryUGCNumKeyValueTags(UGCQueryHandle_t handle, uint index)
		{
			InteropHelp.TestIfAvailableGameServer();
			return NativeMethods.ISteamGameServerUGC_GetQueryUGCNumKeyValueTags(handle, index);
		}

		public static bool GetQueryUGCKeyValueTag(UGCQueryHandle_t handle, uint index, uint keyValueTagIndex, out string pchKey, uint cchKeySize, out string pchValue, uint cchValueSize)
		{
			InteropHelp.TestIfAvailableGameServer();
			IntPtr intPtr = Marshal.AllocHGlobal((int)cchKeySize);
			IntPtr intPtr2 = Marshal.AllocHGlobal((int)cchValueSize);
			bool flag = NativeMethods.ISteamGameServerUGC_GetQueryUGCKeyValueTag(handle, index, keyValueTagIndex, intPtr, cchKeySize, intPtr2, cchValueSize);
			pchKey = (flag ? InteropHelp.PtrToStringUTF8(intPtr) : null);
			Marshal.FreeHGlobal(intPtr);
			pchValue = (flag ? InteropHelp.PtrToStringUTF8(intPtr2) : null);
			Marshal.FreeHGlobal(intPtr2);
			return flag;
		}

		public static bool ReleaseQueryUGCRequest(UGCQueryHandle_t handle)
		{
			InteropHelp.TestIfAvailableGameServer();
			return NativeMethods.ISteamGameServerUGC_ReleaseQueryUGCRequest(handle);
		}

		public static bool AddRequiredTag(UGCQueryHandle_t handle, string pTagName)
		{
			InteropHelp.TestIfAvailableGameServer();
			using InteropHelp.UTF8StringHandle pTagName2 = new InteropHelp.UTF8StringHandle(pTagName);
			return NativeMethods.ISteamGameServerUGC_AddRequiredTag(handle, pTagName2);
		}

		public static bool AddExcludedTag(UGCQueryHandle_t handle, string pTagName)
		{
			InteropHelp.TestIfAvailableGameServer();
			using InteropHelp.UTF8StringHandle pTagName2 = new InteropHelp.UTF8StringHandle(pTagName);
			return NativeMethods.ISteamGameServerUGC_AddExcludedTag(handle, pTagName2);
		}

		public static bool SetReturnKeyValueTags(UGCQueryHandle_t handle, bool bReturnKeyValueTags)
		{
			InteropHelp.TestIfAvailableGameServer();
			return NativeMethods.ISteamGameServerUGC_SetReturnKeyValueTags(handle, bReturnKeyValueTags);
		}

		public static bool SetReturnLongDescription(UGCQueryHandle_t handle, bool bReturnLongDescription)
		{
			InteropHelp.TestIfAvailableGameServer();
			return NativeMethods.ISteamGameServerUGC_SetReturnLongDescription(handle, bReturnLongDescription);
		}

		public static bool SetReturnMetadata(UGCQueryHandle_t handle, bool bReturnMetadata)
		{
			InteropHelp.TestIfAvailableGameServer();
			return NativeMethods.ISteamGameServerUGC_SetReturnMetadata(handle, bReturnMetadata);
		}

		public static bool SetReturnChildren(UGCQueryHandle_t handle, bool bReturnChildren)
		{
			InteropHelp.TestIfAvailableGameServer();
			return NativeMethods.ISteamGameServerUGC_SetReturnChildren(handle, bReturnChildren);
		}

		public static bool SetReturnAdditionalPreviews(UGCQueryHandle_t handle, bool bReturnAdditionalPreviews)
		{
			InteropHelp.TestIfAvailableGameServer();
			return NativeMethods.ISteamGameServerUGC_SetReturnAdditionalPreviews(handle, bReturnAdditionalPreviews);
		}

		public static bool SetReturnTotalOnly(UGCQueryHandle_t handle, bool bReturnTotalOnly)
		{
			InteropHelp.TestIfAvailableGameServer();
			return NativeMethods.ISteamGameServerUGC_SetReturnTotalOnly(handle, bReturnTotalOnly);
		}

		public static bool SetLanguage(UGCQueryHandle_t handle, string pchLanguage)
		{
			InteropHelp.TestIfAvailableGameServer();
			using InteropHelp.UTF8StringHandle pchLanguage2 = new InteropHelp.UTF8StringHandle(pchLanguage);
			return NativeMethods.ISteamGameServerUGC_SetLanguage(handle, pchLanguage2);
		}

		public static bool SetAllowCachedResponse(UGCQueryHandle_t handle, uint unMaxAgeSeconds)
		{
			InteropHelp.TestIfAvailableGameServer();
			return NativeMethods.ISteamGameServerUGC_SetAllowCachedResponse(handle, unMaxAgeSeconds);
		}

		public static bool SetCloudFileNameFilter(UGCQueryHandle_t handle, string pMatchCloudFileName)
		{
			InteropHelp.TestIfAvailableGameServer();
			using InteropHelp.UTF8StringHandle pMatchCloudFileName2 = new InteropHelp.UTF8StringHandle(pMatchCloudFileName);
			return NativeMethods.ISteamGameServerUGC_SetCloudFileNameFilter(handle, pMatchCloudFileName2);
		}

		public static bool SetMatchAnyTag(UGCQueryHandle_t handle, bool bMatchAnyTag)
		{
			InteropHelp.TestIfAvailableGameServer();
			return NativeMethods.ISteamGameServerUGC_SetMatchAnyTag(handle, bMatchAnyTag);
		}

		public static bool SetSearchText(UGCQueryHandle_t handle, string pSearchText)
		{
			InteropHelp.TestIfAvailableGameServer();
			using InteropHelp.UTF8StringHandle pSearchText2 = new InteropHelp.UTF8StringHandle(pSearchText);
			return NativeMethods.ISteamGameServerUGC_SetSearchText(handle, pSearchText2);
		}

		public static bool SetRankedByTrendDays(UGCQueryHandle_t handle, uint unDays)
		{
			InteropHelp.TestIfAvailableGameServer();
			return NativeMethods.ISteamGameServerUGC_SetRankedByTrendDays(handle, unDays);
		}

		public static bool AddRequiredKeyValueTag(UGCQueryHandle_t handle, string pKey, string pValue)
		{
			InteropHelp.TestIfAvailableGameServer();
			using InteropHelp.UTF8StringHandle pKey2 = new InteropHelp.UTF8StringHandle(pKey);
			using InteropHelp.UTF8StringHandle pValue2 = new InteropHelp.UTF8StringHandle(pValue);
			return NativeMethods.ISteamGameServerUGC_AddRequiredKeyValueTag(handle, pKey2, pValue2);
		}

		public static SteamAPICall_t RequestUGCDetails(PublishedFileId_t nPublishedFileID, uint unMaxAgeSeconds)
		{
			InteropHelp.TestIfAvailableGameServer();
			return (SteamAPICall_t)NativeMethods.ISteamGameServerUGC_RequestUGCDetails(nPublishedFileID, unMaxAgeSeconds);
		}

		public static SteamAPICall_t CreateItem(AppId_t nConsumerAppId, EWorkshopFileType eFileType)
		{
			InteropHelp.TestIfAvailableGameServer();
			return (SteamAPICall_t)NativeMethods.ISteamGameServerUGC_CreateItem(nConsumerAppId, eFileType);
		}

		public static UGCUpdateHandle_t StartItemUpdate(AppId_t nConsumerAppId, PublishedFileId_t nPublishedFileID)
		{
			InteropHelp.TestIfAvailableGameServer();
			return (UGCUpdateHandle_t)NativeMethods.ISteamGameServerUGC_StartItemUpdate(nConsumerAppId, nPublishedFileID);
		}

		public static bool SetItemTitle(UGCUpdateHandle_t handle, string pchTitle)
		{
			InteropHelp.TestIfAvailableGameServer();
			using InteropHelp.UTF8StringHandle pchTitle2 = new InteropHelp.UTF8StringHandle(pchTitle);
			return NativeMethods.ISteamGameServerUGC_SetItemTitle(handle, pchTitle2);
		}

		public static bool SetItemDescription(UGCUpdateHandle_t handle, string pchDescription)
		{
			InteropHelp.TestIfAvailableGameServer();
			using InteropHelp.UTF8StringHandle pchDescription2 = new InteropHelp.UTF8StringHandle(pchDescription);
			return NativeMethods.ISteamGameServerUGC_SetItemDescription(handle, pchDescription2);
		}

		public static bool SetItemUpdateLanguage(UGCUpdateHandle_t handle, string pchLanguage)
		{
			InteropHelp.TestIfAvailableGameServer();
			using InteropHelp.UTF8StringHandle pchLanguage2 = new InteropHelp.UTF8StringHandle(pchLanguage);
			return NativeMethods.ISteamGameServerUGC_SetItemUpdateLanguage(handle, pchLanguage2);
		}

		public static bool SetItemMetadata(UGCUpdateHandle_t handle, string pchMetaData)
		{
			InteropHelp.TestIfAvailableGameServer();
			using InteropHelp.UTF8StringHandle pchMetaData2 = new InteropHelp.UTF8StringHandle(pchMetaData);
			return NativeMethods.ISteamGameServerUGC_SetItemMetadata(handle, pchMetaData2);
		}

		public static bool SetItemVisibility(UGCUpdateHandle_t handle, ERemoteStoragePublishedFileVisibility eVisibility)
		{
			InteropHelp.TestIfAvailableGameServer();
			return NativeMethods.ISteamGameServerUGC_SetItemVisibility(handle, eVisibility);
		}

		public static bool SetItemTags(UGCUpdateHandle_t updateHandle, IList<string> pTags)
		{
			InteropHelp.TestIfAvailableGameServer();
			return NativeMethods.ISteamGameServerUGC_SetItemTags(updateHandle, new InteropHelp.SteamParamStringArray(pTags));
		}

		public static bool SetItemContent(UGCUpdateHandle_t handle, string pszContentFolder)
		{
			InteropHelp.TestIfAvailableGameServer();
			using InteropHelp.UTF8StringHandle pszContentFolder2 = new InteropHelp.UTF8StringHandle(pszContentFolder);
			return NativeMethods.ISteamGameServerUGC_SetItemContent(handle, pszContentFolder2);
		}

		public static bool SetItemPreview(UGCUpdateHandle_t handle, string pszPreviewFile)
		{
			InteropHelp.TestIfAvailableGameServer();
			using InteropHelp.UTF8StringHandle pszPreviewFile2 = new InteropHelp.UTF8StringHandle(pszPreviewFile);
			return NativeMethods.ISteamGameServerUGC_SetItemPreview(handle, pszPreviewFile2);
		}

		public static bool RemoveItemKeyValueTags(UGCUpdateHandle_t handle, string pchKey)
		{
			InteropHelp.TestIfAvailableGameServer();
			using InteropHelp.UTF8StringHandle pchKey2 = new InteropHelp.UTF8StringHandle(pchKey);
			return NativeMethods.ISteamGameServerUGC_RemoveItemKeyValueTags(handle, pchKey2);
		}

		public static bool AddItemKeyValueTag(UGCUpdateHandle_t handle, string pchKey, string pchValue)
		{
			InteropHelp.TestIfAvailableGameServer();
			using InteropHelp.UTF8StringHandle pchKey2 = new InteropHelp.UTF8StringHandle(pchKey);
			using InteropHelp.UTF8StringHandle pchValue2 = new InteropHelp.UTF8StringHandle(pchValue);
			return NativeMethods.ISteamGameServerUGC_AddItemKeyValueTag(handle, pchKey2, pchValue2);
		}

		public static SteamAPICall_t SubmitItemUpdate(UGCUpdateHandle_t handle, string pchChangeNote)
		{
			InteropHelp.TestIfAvailableGameServer();
			using InteropHelp.UTF8StringHandle pchChangeNote2 = new InteropHelp.UTF8StringHandle(pchChangeNote);
			return (SteamAPICall_t)NativeMethods.ISteamGameServerUGC_SubmitItemUpdate(handle, pchChangeNote2);
		}

		public static EItemUpdateStatus GetItemUpdateProgress(UGCUpdateHandle_t handle, out ulong punBytesProcessed, out ulong punBytesTotal)
		{
			InteropHelp.TestIfAvailableGameServer();
			return NativeMethods.ISteamGameServerUGC_GetItemUpdateProgress(handle, out punBytesProcessed, out punBytesTotal);
		}

		public static SteamAPICall_t SetUserItemVote(PublishedFileId_t nPublishedFileID, bool bVoteUp)
		{
			InteropHelp.TestIfAvailableGameServer();
			return (SteamAPICall_t)NativeMethods.ISteamGameServerUGC_SetUserItemVote(nPublishedFileID, bVoteUp);
		}

		public static SteamAPICall_t GetUserItemVote(PublishedFileId_t nPublishedFileID)
		{
			InteropHelp.TestIfAvailableGameServer();
			return (SteamAPICall_t)NativeMethods.ISteamGameServerUGC_GetUserItemVote(nPublishedFileID);
		}

		public static SteamAPICall_t AddItemToFavorites(AppId_t nAppId, PublishedFileId_t nPublishedFileID)
		{
			InteropHelp.TestIfAvailableGameServer();
			return (SteamAPICall_t)NativeMethods.ISteamGameServerUGC_AddItemToFavorites(nAppId, nPublishedFileID);
		}

		public static SteamAPICall_t RemoveItemFromFavorites(AppId_t nAppId, PublishedFileId_t nPublishedFileID)
		{
			InteropHelp.TestIfAvailableGameServer();
			return (SteamAPICall_t)NativeMethods.ISteamGameServerUGC_RemoveItemFromFavorites(nAppId, nPublishedFileID);
		}

		public static SteamAPICall_t SubscribeItem(PublishedFileId_t nPublishedFileID)
		{
			InteropHelp.TestIfAvailableGameServer();
			return (SteamAPICall_t)NativeMethods.ISteamGameServerUGC_SubscribeItem(nPublishedFileID);
		}

		public static SteamAPICall_t UnsubscribeItem(PublishedFileId_t nPublishedFileID)
		{
			InteropHelp.TestIfAvailableGameServer();
			return (SteamAPICall_t)NativeMethods.ISteamGameServerUGC_UnsubscribeItem(nPublishedFileID);
		}

		public static uint GetNumSubscribedItems()
		{
			InteropHelp.TestIfAvailableGameServer();
			return NativeMethods.ISteamGameServerUGC_GetNumSubscribedItems();
		}

		public static uint GetSubscribedItems(PublishedFileId_t[] pvecPublishedFileID, uint cMaxEntries)
		{
			InteropHelp.TestIfAvailableGameServer();
			return NativeMethods.ISteamGameServerUGC_GetSubscribedItems(pvecPublishedFileID, cMaxEntries);
		}

		public static uint GetItemState(PublishedFileId_t nPublishedFileID)
		{
			InteropHelp.TestIfAvailableGameServer();
			return NativeMethods.ISteamGameServerUGC_GetItemState(nPublishedFileID);
		}

		public static bool GetItemInstallInfo(PublishedFileId_t nPublishedFileID, out ulong punSizeOnDisk, out string pchFolder, uint cchFolderSize, out uint punTimeStamp)
		{
			InteropHelp.TestIfAvailableGameServer();
			IntPtr intPtr = Marshal.AllocHGlobal((int)cchFolderSize);
			bool flag = NativeMethods.ISteamGameServerUGC_GetItemInstallInfo(nPublishedFileID, out punSizeOnDisk, intPtr, cchFolderSize, out punTimeStamp);
			pchFolder = (flag ? InteropHelp.PtrToStringUTF8(intPtr) : null);
			Marshal.FreeHGlobal(intPtr);
			return flag;
		}

		public static bool GetItemDownloadInfo(PublishedFileId_t nPublishedFileID, out ulong punBytesDownloaded, out ulong punBytesTotal)
		{
			InteropHelp.TestIfAvailableGameServer();
			return NativeMethods.ISteamGameServerUGC_GetItemDownloadInfo(nPublishedFileID, out punBytesDownloaded, out punBytesTotal);
		}

		public static bool DownloadItem(PublishedFileId_t nPublishedFileID, bool bHighPriority)
		{
			InteropHelp.TestIfAvailableGameServer();
			return NativeMethods.ISteamGameServerUGC_DownloadItem(nPublishedFileID, bHighPriority);
		}
	}
	public static class SteamGameServerUtils
	{
		public static uint GetSecondsSinceAppActive()
		{
			InteropHelp.TestIfAvailableGameServer();
			return NativeMethods.ISteamGameServerUtils_GetSecondsSinceAppActive();
		}

		public static uint GetSecondsSinceComputerActive()
		{
			InteropHelp.TestIfAvailableGameServer();
			return NativeMethods.ISteamGameServerUtils_GetSecondsSinceComputerActive();
		}

		public static EUniverse GetConnectedUniverse()
		{
			InteropHelp.TestIfAvailableGameServer();
			return NativeMethods.ISteamGameServerUtils_GetConnectedUniverse();
		}

		public static uint GetServerRealTime()
		{
			InteropHelp.TestIfAvailableGameServer();
			return NativeMethods.ISteamGameServerUtils_GetServerRealTime();
		}

		public static string GetIPCountry()
		{
			InteropHelp.TestIfAvailableGameServer();
			return InteropHelp.PtrToStringUTF8(NativeMethods.ISteamGameServerUtils_GetIPCountry());
		}

		public static bool GetImageSize(int iImage, out uint pnWidth, out uint pnHeight)
		{
			InteropHelp.TestIfAvailableGameServer();
			return NativeMethods.ISteamGameServerUtils_GetImageSize(iImage, out pnWidth, out pnHeight);
		}

		public static bool GetImageRGBA(int iImage, byte[] pubDest, int nDestBufferSize)
		{
			InteropHelp.TestIfAvailableGameServer();
			return NativeMethods.ISteamGameServerUtils_GetImageRGBA(iImage, pubDest, nDestBufferSize);
		}

		public static bool GetCSERIPPort(out uint unIP, out ushort usPort)
		{
			InteropHelp.TestIfAvailableGameServer();
			return NativeMethods.ISteamGameServerUtils_GetCSERIPPort(out unIP, out usPort);
		}

		public static byte GetCurrentBatteryPower()
		{
			InteropHelp.TestIfAvailableGameServer();
			return NativeMethods.ISteamGameServerUtils_GetCurrentBatteryPower();
		}

		public static AppId_t GetAppID()
		{
			InteropHelp.TestIfAvailableGameServer();
			return (AppId_t)NativeMethods.ISteamGameServerUtils_GetAppID();
		}

		public static void SetOverlayNotificationPosition(ENotificationPosition eNotificationPosition)
		{
			InteropHelp.TestIfAvailableGameServer();
			NativeMethods.ISteamGameServerUtils_SetOverlayNotificationPosition(eNotificationPosition);
		}

		public static bool IsAPICallCompleted(SteamAPICall_t hSteamAPICall, out bool pbFailed)
		{
			InteropHelp.TestIfAvailableGameServer();
			return NativeMethods.ISteamGameServerUtils_IsAPICallCompleted(hSteamAPICall, out pbFailed);
		}

		public static ESteamAPICallFailure GetAPICallFailureReason(SteamAPICall_t hSteamAPICall)
		{
			InteropHelp.TestIfAvailableGameServer();
			return NativeMethods.ISteamGameServerUtils_GetAPICallFailureReason(hSteamAPICall);
		}

		public static bool GetAPICallResult(SteamAPICall_t hSteamAPICall, IntPtr pCallback, int cubCallback, int iCallbackExpected, out bool pbFailed)
		{
			InteropHelp.TestIfAvailableGameServer();
			return NativeMethods.ISteamGameServerUtils_GetAPICallResult(hSteamAPICall, pCallback, cubCallback, iCallbackExpected, out pbFailed);
		}

		public static void RunFrame()
		{
			InteropHelp.TestIfAvailableGameServer();
			NativeMethods.ISteamGameServerUtils_RunFrame();
		}

		public static uint GetIPCCallCount()
		{
			InteropHelp.TestIfAvailableGameServer();
			return NativeMethods.ISteamGameServerUtils_GetIPCCallCount();
		}

		public static void SetWarningMessageHook(SteamAPIWarningMessageHook_t pFunction)
		{
			InteropHelp.TestIfAvailableGameServer();
			NativeMethods.ISteamGameServerUtils_SetWarningMessageHook(pFunction);
		}

		public static bool IsOverlayEnabled()
		{
			InteropHelp.TestIfAvailableGameServer();
			return NativeMethods.ISteamGameServerUtils_IsOverlayEnabled();
		}

		public static bool BOverlayNeedsPresent()
		{
			InteropHelp.TestIfAvailableGameServer();
			return NativeMethods.ISteamGameServerUtils_BOverlayNeedsPresent();
		}

		public static SteamAPICall_t CheckFileSignature(string szFileName)
		{
			InteropHelp.TestIfAvailableGameServer();
			using InteropHelp.UTF8StringHandle szFileName2 = new InteropHelp.UTF8StringHandle(szFileName);
			return (SteamAPICall_t)NativeMethods.ISteamGameServerUtils_CheckFileSignature(szFileName2);
		}

		public static bool ShowGamepadTextInput(EGamepadTextInputMode eInputMode, EGamepadTextInputLineMode eLineInputMode, string pchDescription, uint unCharMax, string pchExistingText)
		{
			InteropHelp.TestIfAvailableGameServer();
			using InteropHelp.UTF8StringHandle pchDescription2 = new InteropHelp.UTF8StringHandle(pchDescription);
			using InteropHelp.UTF8StringHandle pchExistingText2 = new InteropHelp.UTF8StringHandle(pchExistingText);
			return NativeMethods.ISteamGameServerUtils_ShowGamepadTextInput(eInputMode, eLineInputMode, pchDescription2, unCharMax, pchExistingText2);
		}

		public static uint GetEnteredGamepadTextLength()
		{
			InteropHelp.TestIfAvailableGameServer();
			return NativeMethods.ISteamGameServerUtils_GetEnteredGamepadTextLength();
		}

		public static bool GetEnteredGamepadTextInput(out string pchText, uint cchText)
		{
			InteropHelp.TestIfAvailableGameServer();
			IntPtr intPtr = Marshal.AllocHGlobal((int)cchText);
			bool flag = NativeMethods.ISteamGameServerUtils_GetEnteredGamepadTextInput(intPtr, cchText);
			pchText = (flag ? InteropHelp.PtrToStringUTF8(intPtr) : null);
			Marshal.FreeHGlobal(intPtr);
			return flag;
		}

		public static string GetSteamUILanguage()
		{
			InteropHelp.TestIfAvailableGameServer();
			return InteropHelp.PtrToStringUTF8(NativeMethods.ISteamGameServerUtils_GetSteamUILanguage());
		}

		public static bool IsSteamRunningInVR()
		{
			InteropHelp.TestIfAvailableGameServer();
			return NativeMethods.ISteamGameServerUtils_IsSteamRunningInVR();
		}

		public static void SetOverlayNotificationInset(int nHorizontalInset, int nVerticalInset)
		{
			InteropHelp.TestIfAvailableGameServer();
			NativeMethods.ISteamGameServerUtils_SetOverlayNotificationInset(nHorizontalInset, nVerticalInset);
		}
	}
	public static class SteamHTMLSurface
	{
		public static bool Init()
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamHTMLSurface_Init();
		}

		public static bool Shutdown()
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamHTMLSurface_Shutdown();
		}

		public static SteamAPICall_t CreateBrowser(string pchUserAgent, string pchUserCSS)
		{
			InteropHelp.TestIfAvailableClient();
			using InteropHelp.UTF8StringHandle pchUserAgent2 = new InteropHelp.UTF8StringHandle(pchUserAgent);
			using InteropHelp.UTF8StringHandle pchUserCSS2 = new InteropHelp.UTF8StringHandle(pchUserCSS);
			return (SteamAPICall_t)NativeMethods.ISteamHTMLSurface_CreateBrowser(pchUserAgent2, pchUserCSS2);
		}

		public static void RemoveBrowser(HHTMLBrowser unBrowserHandle)
		{
			InteropHelp.TestIfAvailableClient();
			NativeMethods.ISteamHTMLSurface_RemoveBrowser(unBrowserHandle);
		}

		public static void LoadURL(HHTMLBrowser unBrowserHandle, string pchURL, string pchPostData)
		{
			InteropHelp.TestIfAvailableClient();
			using InteropHelp.UTF8StringHandle pchURL2 = new InteropHelp.UTF8StringHandle(pchURL);
			using InteropHelp.UTF8StringHandle pchPostData2 = new InteropHelp.UTF8StringHandle(pchPostData);
			NativeMethods.ISteamHTMLSurface_LoadURL(unBrowserHandle, pchURL2, pchPostData2);
		}

		public static void SetSize(HHTMLBrowser unBrowserHandle, uint unWidth, uint unHeight)
		{
			InteropHelp.TestIfAvailableClient();
			NativeMethods.ISteamHTMLSurface_SetSize(unBrowserHandle, unWidth, unHeight);
		}

		public static void StopLoad(HHTMLBrowser unBrowserHandle)
		{
			InteropHelp.TestIfAvailableClient();
			NativeMethods.ISteamHTMLSurface_StopLoad(unBrowserHandle);
		}

		public static void Reload(HHTMLBrowser unBrowserHandle)
		{
			InteropHelp.TestIfAvailableClient();
			NativeMethods.ISteamHTMLSurface_Reload(unBrowserHandle);
		}

		public static void GoBack(HHTMLBrowser unBrowserHandle)
		{
			InteropHelp.TestIfAvailableClient();
			NativeMethods.ISteamHTMLSurface_GoBack(unBrowserHandle);
		}

		public static void GoForward(HHTMLBrowser unBrowserHandle)
		{
			InteropHelp.TestIfAvailableClient();
			NativeMethods.ISteamHTMLSurface_GoForward(unBrowserHandle);
		}

		public static void AddHeader(HHTMLBrowser unBrowserHandle, string pchKey, string pchValue)
		{
			InteropHelp.TestIfAvailableClient();
			using InteropHelp.UTF8StringHandle pchKey2 = new InteropHelp.UTF8StringHandle(pchKey);
			using InteropHelp.UTF8StringHandle pchValue2 = new InteropHelp.UTF8StringHandle(pchValue);
			NativeMethods.ISteamHTMLSurface_AddHeader(unBrowserHandle, pchKey2, pchValue2);
		}

		public static void ExecuteJavascript(HHTMLBrowser unBrowserHandle, string pchScript)
		{
			InteropHelp.TestIfAvailableClient();
			using InteropHelp.UTF8StringHandle pchScript2 = new InteropHelp.UTF8StringHandle(pchScript);
			NativeMethods.ISteamHTMLSurface_ExecuteJavascript(unBrowserHandle, pchScript2);
		}

		public static void MouseUp(HHTMLBrowser unBrowserHandle, EHTMLMouseButton eMouseButton)
		{
			InteropHelp.TestIfAvailableClient();
			NativeMethods.ISteamHTMLSurface_MouseUp(unBrowserHandle, eMouseButton);
		}

		public static void MouseDown(HHTMLBrowser unBrowserHandle, EHTMLMouseButton eMouseButton)
		{
			InteropHelp.TestIfAvailableClient();
			NativeMethods.ISteamHTMLSurface_MouseDown(unBrowserHandle, eMouseButton);
		}

		public static void MouseDoubleClick(HHTMLBrowser unBrowserHandle, EHTMLMouseButton eMouseButton)
		{
			InteropHelp.TestIfAvailableClient();
			NativeMethods.ISteamHTMLSurface_MouseDoubleClick(unBrowserHandle, eMouseButton);
		}

		public static void MouseMove(HHTMLBrowser unBrowserHandle, int x, int y)
		{
			InteropHelp.TestIfAvailableClient();
			NativeMethods.ISteamHTMLSurface_MouseMove(unBrowserHandle, x, y);
		}

		public static void MouseWheel(HHTMLBrowser unBrowserHandle, int nDelta)
		{
			InteropHelp.TestIfAvailableClient();
			NativeMethods.ISteamHTMLSurface_MouseWheel(unBrowserHandle, nDelta);
		}

		public static void KeyDown(HHTMLBrowser unBrowserHandle, uint nNativeKeyCode, EHTMLKeyModifiers eHTMLKeyModifiers)
		{
			InteropHelp.TestIfAvailableClient();
			NativeMethods.ISteamHTMLSurface_KeyDown(unBrowserHandle, nNativeKeyCode, eHTMLKeyModifiers);
		}

		public static void KeyUp(HHTMLBrowser unBrowserHandle, uint nNativeKeyCode, EHTMLKeyModifiers eHTMLKeyModifiers)
		{
			InteropHelp.TestIfAvailableClient();
			NativeMethods.ISteamHTMLSurface_KeyUp(unBrowserHandle, nNativeKeyCode, eHTMLKeyModifiers);
		}

		public static void KeyChar(HHTMLBrowser unBrowserHandle, uint cUnicodeChar, EHTMLKeyModifiers eHTMLKeyModifiers)
		{
			InteropHelp.TestIfAvailableClient();
			NativeMethods.ISteamHTMLSurface_KeyChar(unBrowserHandle, cUnicodeChar, eHTMLKeyModifiers);
		}

		public static void SetHorizontalScroll(HHTMLBrowser unBrowserHandle, uint nAbsolutePixelScroll)
		{
			InteropHelp.TestIfAvailableClient();
			NativeMethods.ISteamHTMLSurface_SetHorizontalScroll(unBrowserHandle, nAbsolutePixelScroll);
		}

		public static void SetVerticalScroll(HHTMLBrowser unBrowserHandle, uint nAbsolutePixelScroll)
		{
			InteropHelp.TestIfAvailableClient();
			NativeMethods.ISteamHTMLSurface_SetVerticalScroll(unBrowserHandle, nAbsolutePixelScroll);
		}

		public static void SetKeyFocus(HHTMLBrowser unBrowserHandle, bool bHasKeyFocus)
		{
			InteropHelp.TestIfAvailableClient();
			NativeMethods.ISteamHTMLSurface_SetKeyFocus(unBrowserHandle, bHasKeyFocus);
		}

		public static void ViewSource(HHTMLBrowser unBrowserHandle)
		{
			InteropHelp.TestIfAvailableClient();
			NativeMethods.ISteamHTMLSurface_ViewSource(unBrowserHandle);
		}

		public static void CopyToClipboard(HHTMLBrowser unBrowserHandle)
		{
			InteropHelp.TestIfAvailableClient();
			NativeMethods.ISteamHTMLSurface_CopyToClipboard(unBrowserHandle);
		}

		public static void PasteFromClipboard(HHTMLBrowser unBrowserHandle)
		{
			InteropHelp.TestIfAvailableClient();
			NativeMethods.ISteamHTMLSurface_PasteFromClipboard(unBrowserHandle);
		}

		public static void Find(HHTMLBrowser unBrowserHandle, string pchSearchStr, bool bCurrentlyInFind, bool bReverse)
		{
			InteropHelp.TestIfAvailableClient();
			using InteropHelp.UTF8StringHandle pchSearchStr2 = new InteropHelp.UTF8StringHandle(pchSearchStr);
			NativeMethods.ISteamHTMLSurface_Find(unBrowserHandle, pchSearchStr2, bCurrentlyInFind, bReverse);
		}

		public static void StopFind(HHTMLBrowser unBrowserHandle)
		{
			InteropHelp.TestIfAvailableClient();
			NativeMethods.ISteamHTMLSurface_StopFind(unBrowserHandle);
		}

		public static void GetLinkAtPosition(HHTMLBrowser unBrowserHandle, int x, int y)
		{
			InteropHelp.TestIfAvailableClient();
			NativeMethods.ISteamHTMLSurface_GetLinkAtPosition(unBrowserHandle, x, y);
		}

		public static void SetCookie(string pchHostname, string pchKey, string pchValue, string pchPath = "/", uint nExpires = 0u, bool bSecure = false, bool bHTTPOnly = false)
		{
			InteropHelp.TestIfAvailableClient();
			using InteropHelp.UTF8StringHandle pchHostname2 = new InteropHelp.UTF8StringHandle(pchHostname);
			using InteropHelp.UTF8StringHandle pchKey2 = new InteropHelp.UTF8StringHandle(pchKey);
			using InteropHelp.UTF8StringHandle pchValue2 = new InteropHelp.UTF8StringHandle(pchValue);
			using InteropHelp.UTF8StringHandle pchPath2 = new InteropHelp.UTF8StringHandle(pchPath);
			NativeMethods.ISteamHTMLSurface_SetCookie(pchHostname2, pchKey2, pchValue2, pchPath2, nExpires, bSecure, bHTTPOnly);
		}

		public static void SetPageScaleFactor(HHTMLBrowser unBrowserHandle, float flZoom, int nPointX, int nPointY)
		{
			InteropHelp.TestIfAvailableClient();
			NativeMethods.ISteamHTMLSurface_SetPageScaleFactor(unBrowserHandle, flZoom, nPointX, nPointY);
		}

		public static void SetBackgroundMode(HHTMLBrowser unBrowserHandle, bool bBackgroundMode)
		{
			InteropHelp.TestIfAvailableClient();
			NativeMethods.ISteamHTMLSurface_SetBackgroundMode(unBrowserHandle, bBackgroundMode);
		}

		public static void AllowStartRequest(HHTMLBrowser unBrowserHandle, bool bAllowed)
		{
			InteropHelp.TestIfAvailableClient();
			NativeMethods.ISteamHTMLSurface_AllowStartRequest(unBrowserHandle, bAllowed);
		}

		public static void JSDialogResponse(HHTMLBrowser unBrowserHandle, bool bResult)
		{
			InteropHelp.TestIfAvailableClient();
			NativeMethods.ISteamHTMLSurface_JSDialogResponse(unBrowserHandle, bResult);
		}

		public static void FileLoadDialogResponse(HHTMLBrowser unBrowserHandle, IntPtr pchSelectedFiles)
		{
			InteropHelp.TestIfAvailableClient();
			NativeMethods.ISteamHTMLSurface_FileLoadDialogResponse(unBrowserHandle, pchSelectedFiles);
		}
	}
	public static class SteamHTTP
	{
		public static HTTPRequestHandle CreateHTTPRequest(EHTTPMethod eHTTPRequestMethod, string pchAbsoluteURL)
		{
			InteropHelp.TestIfAvailableClient();
			using InteropHelp.UTF8StringHandle pchAbsoluteURL2 = new InteropHelp.UTF8StringHandle(pchAbsoluteURL);
			return (HTTPRequestHandle)NativeMethods.ISteamHTTP_CreateHTTPRequest(eHTTPRequestMethod, pchAbsoluteURL2);
		}

		public static bool SetHTTPRequestContextValue(HTTPRequestHandle hRequest, ulong ulContextValue)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamHTTP_SetHTTPRequestContextValue(hRequest, ulContextValue);
		}

		public static bool SetHTTPRequestNetworkActivityTimeout(HTTPRequestHandle hRequest, uint unTimeoutSeconds)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamHTTP_SetHTTPRequestNetworkActivityTimeout(hRequest, unTimeoutSeconds);
		}

		public static bool SetHTTPRequestHeaderValue(HTTPRequestHandle hRequest, string pchHeaderName, string pchHeaderValue)
		{
			InteropHelp.TestIfAvailableClient();
			using InteropHelp.UTF8StringHandle pchHeaderName2 = new InteropHelp.UTF8StringHandle(pchHeaderName);
			using InteropHelp.UTF8StringHandle pchHeaderValue2 = new InteropHelp.UTF8StringHandle(pchHeaderValue);
			return NativeMethods.ISteamHTTP_SetHTTPRequestHeaderValue(hRequest, pchHeaderName2, pchHeaderValue2);
		}

		public static bool SetHTTPRequestGetOrPostParameter(HTTPRequestHandle hRequest, string pchParamName, string pchParamValue)
		{
			InteropHelp.TestIfAvailableClient();
			using InteropHelp.UTF8StringHandle pchParamName2 = new InteropHelp.UTF8StringHandle(pchParamName);
			using InteropHelp.UTF8StringHandle pchParamValue2 = new InteropHelp.UTF8StringHandle(pchParamValue);
			return NativeMethods.ISteamHTTP_SetHTTPRequestGetOrPostParameter(hRequest, pchParamName2, pchParamValue2);
		}

		public static bool SendHTTPRequest(HTTPRequestHandle hRequest, out SteamAPICall_t pCallHandle)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamHTTP_SendHTTPRequest(hRequest, out pCallHandle);
		}

		public static bool SendHTTPRequestAndStreamResponse(HTTPRequestHandle hRequest, out SteamAPICall_t pCallHandle)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamHTTP_SendHTTPRequestAndStreamResponse(hRequest, out pCallHandle);
		}

		public static bool DeferHTTPRequest(HTTPRequestHandle hRequest)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamHTTP_DeferHTTPRequest(hRequest);
		}

		public static bool PrioritizeHTTPRequest(HTTPRequestHandle hRequest)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamHTTP_PrioritizeHTTPRequest(hRequest);
		}

		public static bool GetHTTPResponseHeaderSize(HTTPRequestHandle hRequest, string pchHeaderName, out uint unResponseHeaderSize)
		{
			InteropHelp.TestIfAvailableClient();
			using InteropHelp.UTF8StringHandle pchHeaderName2 = new InteropHelp.UTF8StringHandle(pchHeaderName);
			return NativeMethods.ISteamHTTP_GetHTTPResponseHeaderSize(hRequest, pchHeaderName2, out unResponseHeaderSize);
		}

		public static bool GetHTTPResponseHeaderValue(HTTPRequestHandle hRequest, string pchHeaderName, byte[] pHeaderValueBuffer, uint unBufferSize)
		{
			InteropHelp.TestIfAvailableClient();
			using InteropHelp.UTF8StringHandle pchHeaderName2 = new InteropHelp.UTF8StringHandle(pchHeaderName);
			return NativeMethods.ISteamHTTP_GetHTTPResponseHeaderValue(hRequest, pchHeaderName2, pHeaderValueBuffer, unBufferSize);
		}

		public static bool GetHTTPResponseBodySize(HTTPRequestHandle hRequest, out uint unBodySize)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamHTTP_GetHTTPResponseBodySize(hRequest, out unBodySize);
		}

		public static bool GetHTTPResponseBodyData(HTTPRequestHandle hRequest, byte[] pBodyDataBuffer, uint unBufferSize)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamHTTP_GetHTTPResponseBodyData(hRequest, pBodyDataBuffer, unBufferSize);
		}

		public static bool GetHTTPStreamingResponseBodyData(HTTPRequestHandle hRequest, uint cOffset, byte[] pBodyDataBuffer, uint unBufferSize)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamHTTP_GetHTTPStreamingResponseBodyData(hRequest, cOffset, pBodyDataBuffer, unBufferSize);
		}

		public static bool ReleaseHTTPRequest(HTTPRequestHandle hRequest)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamHTTP_ReleaseHTTPRequest(hRequest);
		}

		public static bool GetHTTPDownloadProgressPct(HTTPRequestHandle hRequest, out float pflPercentOut)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamHTTP_GetHTTPDownloadProgressPct(hRequest, out pflPercentOut);
		}

		public static bool SetHTTPRequestRawPostBody(HTTPRequestHandle hRequest, string pchContentType, byte[] pubBody, uint unBodyLen)
		{
			InteropHelp.TestIfAvailableClient();
			using InteropHelp.UTF8StringHandle pchContentType2 = new InteropHelp.UTF8StringHandle(pchContentType);
			return NativeMethods.ISteamHTTP_SetHTTPRequestRawPostBody(hRequest, pchContentType2, pubBody, unBodyLen);
		}

		public static HTTPCookieContainerHandle CreateCookieContainer(bool bAllowResponsesToModify)
		{
			InteropHelp.TestIfAvailableClient();
			return (HTTPCookieContainerHandle)NativeMethods.ISteamHTTP_CreateCookieContainer(bAllowResponsesToModify);
		}

		public static bool ReleaseCookieContainer(HTTPCookieContainerHandle hCookieContainer)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamHTTP_ReleaseCookieContainer(hCookieContainer);
		}

		public static bool SetCookie(HTTPCookieContainerHandle hCookieContainer, string pchHost, string pchUrl, string pchCookie)
		{
			InteropHelp.TestIfAvailableClient();
			using InteropHelp.UTF8StringHandle pchHost2 = new InteropHelp.UTF8StringHandle(pchHost);
			using InteropHelp.UTF8StringHandle pchUrl2 = new InteropHelp.UTF8StringHandle(pchUrl);
			using InteropHelp.UTF8StringHandle pchCookie2 = new InteropHelp.UTF8StringHandle(pchCookie);
			return NativeMethods.ISteamHTTP_SetCookie(hCookieContainer, pchHost2, pchUrl2, pchCookie2);
		}

		public static bool SetHTTPRequestCookieContainer(HTTPRequestHandle hRequest, HTTPCookieContainerHandle hCookieContainer)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamHTTP_SetHTTPRequestCookieContainer(hRequest, hCookieContainer);
		}

		public static bool SetHTTPRequestUserAgentInfo(HTTPRequestHandle hRequest, string pchUserAgentInfo)
		{
			InteropHelp.TestIfAvailableClient();
			using InteropHelp.UTF8StringHandle pchUserAgentInfo2 = new InteropHelp.UTF8StringHandle(pchUserAgentInfo);
			return NativeMethods.ISteamHTTP_SetHTTPRequestUserAgentInfo(hRequest, pchUserAgentInfo2);
		}

		public static bool SetHTTPRequestRequiresVerifiedCertificate(HTTPRequestHandle hRequest, bool bRequireVerifiedCertificate)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamHTTP_SetHTTPRequestRequiresVerifiedCertificate(hRequest, bRequireVerifiedCertificate);
		}

		public static bool SetHTTPRequestAbsoluteTimeoutMS(HTTPRequestHandle hRequest, uint unMilliseconds)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamHTTP_SetHTTPRequestAbsoluteTimeoutMS(hRequest, unMilliseconds);
		}

		public static bool GetHTTPRequestWasTimedOut(HTTPRequestHandle hRequest, out bool pbWasTimedOut)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamHTTP_GetHTTPRequestWasTimedOut(hRequest, out pbWasTimedOut);
		}
	}
	public static class SteamInventory
	{
		public static EResult GetResultStatus(SteamInventoryResult_t resultHandle)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamInventory_GetResultStatus(resultHandle);
		}

		public static bool GetResultItems(SteamInventoryResult_t resultHandle, SteamItemDetails_t[] pOutItemsArray, ref uint punOutItemsArraySize)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamInventory_GetResultItems(resultHandle, pOutItemsArray, ref punOutItemsArraySize);
		}

		public static uint GetResultTimestamp(SteamInventoryResult_t resultHandle)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamInventory_GetResultTimestamp(resultHandle);
		}

		public static bool CheckResultSteamID(SteamInventoryResult_t resultHandle, CSteamID steamIDExpected)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamInventory_CheckResultSteamID(resultHandle, steamIDExpected);
		}

		public static void DestroyResult(SteamInventoryResult_t resultHandle)
		{
			InteropHelp.TestIfAvailableClient();
			NativeMethods.ISteamInventory_DestroyResult(resultHandle);
		}

		public static bool GetAllItems(out SteamInventoryResult_t pResultHandle)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamInventory_GetAllItems(out pResultHandle);
		}

		public static bool GetItemsByID(out SteamInventoryResult_t pResultHandle, SteamItemInstanceID_t[] pInstanceIDs, uint unCountInstanceIDs)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamInventory_GetItemsByID(out pResultHandle, pInstanceIDs, unCountInstanceIDs);
		}

		public static bool SerializeResult(SteamInventoryResult_t resultHandle, byte[] pOutBuffer, out uint punOutBufferSize)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamInventory_SerializeResult(resultHandle, pOutBuffer, out punOutBufferSize);
		}

		public static bool DeserializeResult(out SteamInventoryResult_t pOutResultHandle, byte[] pBuffer, uint unBufferSize, bool bRESERVED_MUST_BE_FALSE = false)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamInventory_DeserializeResult(out pOutResultHandle, pBuffer, unBufferSize, bRESERVED_MUST_BE_FALSE);
		}

		public static bool GenerateItems(out SteamInventoryResult_t pResultHandle, SteamItemDef_t[] pArrayItemDefs, uint[] punArrayQuantity, uint unArrayLength)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamInventory_GenerateItems(out pResultHandle, pArrayItemDefs, punArrayQuantity, unArrayLength);
		}

		public static bool GrantPromoItems(out SteamInventoryResult_t pResultHandle)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamInventory_GrantPromoItems(out pResultHandle);
		}

		public static bool AddPromoItem(out SteamInventoryResult_t pResultHandle, SteamItemDef_t itemDef)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamInventory_AddPromoItem(out pResultHandle, itemDef);
		}

		public static bool AddPromoItems(out SteamInventoryResult_t pResultHandle, SteamItemDef_t[] pArrayItemDefs, uint unArrayLength)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamInventory_AddPromoItems(out pResultHandle, pArrayItemDefs, unArrayLength);
		}

		public static bool ConsumeItem(out SteamInventoryResult_t pResultHandle, SteamItemInstanceID_t itemConsume, uint unQuantity)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamInventory_ConsumeItem(out pResultHandle, itemConsume, unQuantity);
		}

		public static bool ExchangeItems(out SteamInventoryResult_t pResultHandle, SteamItemDef_t[] pArrayGenerate, uint[] punArrayGenerateQuantity, uint unArrayGenerateLength, SteamItemInstanceID_t[] pArrayDestroy, uint[] punArrayDestroyQuantity, uint unArrayDestroyLength)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamInventory_ExchangeItems(out pResultHandle, pArrayGenerate, punArrayGenerateQuantity, unArrayGenerateLength, pArrayDestroy, punArrayDestroyQuantity, unArrayDestroyLength);
		}

		public static bool TransferItemQuantity(out SteamInventoryResult_t pResultHandle, SteamItemInstanceID_t itemIdSource, uint unQuantity, SteamItemInstanceID_t itemIdDest)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamInventory_TransferItemQuantity(out pResultHandle, itemIdSource, unQuantity, itemIdDest);
		}

		public static void SendItemDropHeartbeat()
		{
			InteropHelp.TestIfAvailableClient();
			NativeMethods.ISteamInventory_SendItemDropHeartbeat();
		}

		public static bool TriggerItemDrop(out SteamInventoryResult_t pResultHandle, SteamItemDef_t dropListDefinition)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamInventory_TriggerItemDrop(out pResultHandle, dropListDefinition);
		}

		public static bool TradeItems(out SteamInventoryResult_t pResultHandle, CSteamID steamIDTradePartner, SteamItemInstanceID_t[] pArrayGive, uint[] pArrayGiveQuantity, uint nArrayGiveLength, SteamItemInstanceID_t[] pArrayGet, uint[] pArrayGetQuantity, uint nArrayGetLength)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamInventory_TradeItems(out pResultHandle, steamIDTradePartner, pArrayGive, pArrayGiveQuantity, nArrayGiveLength, pArrayGet, pArrayGetQuantity, nArrayGetLength);
		}

		public static bool LoadItemDefinitions()
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamInventory_LoadItemDefinitions();
		}

		public static bool GetItemDefinitionIDs(SteamItemDef_t[] pItemDefIDs, out uint punItemDefIDsArraySize)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamInventory_GetItemDefinitionIDs(pItemDefIDs, out punItemDefIDsArraySize);
		}

		public static bool GetItemDefinitionProperty(SteamItemDef_t iDefinition, string pchPropertyName, out string pchValueBuffer, ref uint punValueBufferSize)
		{
			InteropHelp.TestIfAvailableClient();
			IntPtr intPtr = Marshal.AllocHGlobal((int)punValueBufferSize);
			using InteropHelp.UTF8StringHandle pchPropertyName2 = new InteropHelp.UTF8StringHandle(pchPropertyName);
			bool flag = NativeMethods.ISteamInventory_GetItemDefinitionProperty(iDefinition, pchPropertyName2, intPtr, ref punValueBufferSize);
			pchValueBuffer = (flag ? InteropHelp.PtrToStringUTF8(intPtr) : null);
			Marshal.FreeHGlobal(intPtr);
			return flag;
		}
	}
	public static class SteamMatchmaking
	{
		public static int GetFavoriteGameCount()
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamMatchmaking_GetFavoriteGameCount();
		}

		public static bool GetFavoriteGame(int iGame, out AppId_t pnAppID, out uint pnIP, out ushort pnConnPort, out ushort pnQueryPort, out uint punFlags, out uint pRTime32LastPlayedOnServer)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamMatchmaking_GetFavoriteGame(iGame, out pnAppID, out pnIP, out pnConnPort, out pnQueryPort, out punFlags, out pRTime32LastPlayedOnServer);
		}

		public static int AddFavoriteGame(AppId_t nAppID, uint nIP, ushort nConnPort, ushort nQueryPort, uint unFlags, uint rTime32LastPlayedOnServer)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamMatchmaking_AddFavoriteGame(nAppID, nIP, nConnPort, nQueryPort, unFlags, rTime32LastPlayedOnServer);
		}

		public static bool RemoveFavoriteGame(AppId_t nAppID, uint nIP, ushort nConnPort, ushort nQueryPort, uint unFlags)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamMatchmaking_RemoveFavoriteGame(nAppID, nIP, nConnPort, nQueryPort, unFlags);
		}

		public static SteamAPICall_t RequestLobbyList()
		{
			InteropHelp.TestIfAvailableClient();
			return (SteamAPICall_t)NativeMethods.ISteamMatchmaking_RequestLobbyList();
		}

		public static void AddRequestLobbyListStringFilter(string pchKeyToMatch, string pchValueToMatch, ELobbyComparison eComparisonType)
		{
			InteropHelp.TestIfAvailableClient();
			using InteropHelp.UTF8StringHandle pchKeyToMatch2 = new InteropHelp.UTF8StringHandle(pchKeyToMatch);
			using InteropHelp.UTF8StringHandle pchValueToMatch2 = new InteropHelp.UTF8StringHandle(pchValueToMatch);
			NativeMethods.ISteamMatchmaking_AddRequestLobbyListStringFilter(pchKeyToMatch2, pchValueToMatch2, eComparisonType);
		}

		public static void AddRequestLobbyListNumericalFilter(string pchKeyToMatch, int nValueToMatch, ELobbyComparison eComparisonType)
		{
			InteropHelp.TestIfAvailableClient();
			using InteropHelp.UTF8StringHandle pchKeyToMatch2 = new InteropHelp.UTF8StringHandle(pchKeyToMatch);
			NativeMethods.ISteamMatchmaking_AddRequestLobbyListNumericalFilter(pchKeyToMatch2, nValueToMatch, eComparisonType);
		}

		public static void AddRequestLobbyListNearValueFilter(string pchKeyToMatch, int nValueToBeCloseTo)
		{
			InteropHelp.TestIfAvailableClient();
			using InteropHelp.UTF8StringHandle pchKeyToMatch2 = new InteropHelp.UTF8StringHandle(pchKeyToMatch);
			NativeMethods.ISteamMatchmaking_AddRequestLobbyListNearValueFilter(pchKeyToMatch2, nValueToBeCloseTo);
		}

		public static void AddRequestLobbyListFilterSlotsAvailable(int nSlotsAvailable)
		{
			InteropHelp.TestIfAvailableClient();
			NativeMethods.ISteamMatchmaking_AddRequestLobbyListFilterSlotsAvailable(nSlotsAvailable);
		}

		public static void AddRequestLobbyListDistanceFilter(ELobbyDistanceFilter eLobbyDistanceFilter)
		{
			InteropHelp.TestIfAvailableClient();
			NativeMethods.ISteamMatchmaking_AddRequestLobbyListDistanceFilter(eLobbyDistanceFilter);
		}

		public static void AddRequestLobbyListResultCountFilter(int cMaxResults)
		{
			InteropHelp.TestIfAvailableClient();
			NativeMethods.ISteamMatchmaking_AddRequestLobbyListResultCountFilter(cMaxResults);
		}

		public static void AddRequestLobbyListCompatibleMembersFilter(CSteamID steamIDLobby)
		{
			InteropHelp.TestIfAvailableClient();
			NativeMethods.ISteamMatchmaking_AddRequestLobbyListCompatibleMembersFilter(steamIDLobby);
		}

		public static CSteamID GetLobbyByIndex(int iLobby)
		{
			InteropHelp.TestIfAvailableClient();
			return (CSteamID)NativeMethods.ISteamMatchmaking_GetLobbyByIndex(iLobby);
		}

		public static SteamAPICall_t CreateLobby(ELobbyType eLobbyType, int cMaxMembers)
		{
			InteropHelp.TestIfAvailableClient();
			return (SteamAPICall_t)NativeMethods.ISteamMatchmaking_CreateLobby(eLobbyType, cMaxMembers);
		}

		public static SteamAPICall_t JoinLobby(CSteamID steamIDLobby)
		{
			InteropHelp.TestIfAvailableClient();
			return (SteamAPICall_t)NativeMethods.ISteamMatchmaking_JoinLobby(steamIDLobby);
		}

		public static void LeaveLobby(CSteamID steamIDLobby)
		{
			InteropHelp.TestIfAvailableClient();
			NativeMethods.ISteamMatchmaking_LeaveLobby(steamIDLobby);
		}

		public static bool InviteUserToLobby(CSteamID steamIDLobby, CSteamID steamIDInvitee)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamMatchmaking_InviteUserToLobby(steamIDLobby, steamIDInvitee);
		}

		public static int GetNumLobbyMembers(CSteamID steamIDLobby)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamMatchmaking_GetNumLobbyMembers(steamIDLobby);
		}

		public static CSteamID GetLobbyMemberByIndex(CSteamID steamIDLobby, int iMember)
		{
			InteropHelp.TestIfAvailableClient();
			return (CSteamID)NativeMethods.ISteamMatchmaking_GetLobbyMemberByIndex(steamIDLobby, iMember);
		}

		public static string GetLobbyData(CSteamID steamIDLobby, string pchKey)
		{
			InteropHelp.TestIfAvailableClient();
			using InteropHelp.UTF8StringHandle pchKey2 = new InteropHelp.UTF8StringHandle(pchKey);
			return InteropHelp.PtrToStringUTF8(NativeMethods.ISteamMatchmaking_GetLobbyData(steamIDLobby, pchKey2));
		}

		public static bool SetLobbyData(CSteamID steamIDLobby, string pchKey, string pchValue)
		{
			InteropHelp.TestIfAvailableClient();
			using InteropHelp.UTF8StringHandle pchKey2 = new InteropHelp.UTF8StringHandle(pchKey);
			using InteropHelp.UTF8StringHandle pchValue2 = new InteropHelp.UTF8StringHandle(pchValue);
			return NativeMethods.ISteamMatchmaking_SetLobbyData(steamIDLobby, pchKey2, pchValue2);
		}

		public static int GetLobbyDataCount(CSteamID steamIDLobby)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamMatchmaking_GetLobbyDataCount(steamIDLobby);
		}

		public static bool GetLobbyDataByIndex(CSteamID steamIDLobby, int iLobbyData, out string pchKey, int cchKeyBufferSize, out string pchValue, int cchValueBufferSize)
		{
			InteropHelp.TestIfAvailableClient();
			IntPtr intPtr = Marshal.AllocHGlobal(cchKeyBufferSize);
			IntPtr intPtr2 = Marshal.AllocHGlobal(cchValueBufferSize);
			bool flag = NativeMethods.ISteamMatchmaking_GetLobbyDataByIndex(steamIDLobby, iLobbyData, intPtr, cchKeyBufferSize, intPtr2, cchValueBufferSize);
			pchKey = (flag ? InteropHelp.PtrToStringUTF8(intPtr) : null);
			Marshal.FreeHGlobal(intPtr);
			pchValue = (flag ? InteropHelp.PtrToStringUTF8(intPtr2) : null);
			Marshal.FreeHGlobal(intPtr2);
			return flag;
		}

		public static bool DeleteLobbyData(CSteamID steamIDLobby, string pchKey)
		{
			InteropHelp.TestIfAvailableClient();
			using InteropHelp.UTF8StringHandle pchKey2 = new InteropHelp.UTF8StringHandle(pchKey);
			return NativeMethods.ISteamMatchmaking_DeleteLobbyData(steamIDLobby, pchKey2);
		}

		public static string GetLobbyMemberData(CSteamID steamIDLobby, CSteamID steamIDUser, string pchKey)
		{
			InteropHelp.TestIfAvailableClient();
			using InteropHelp.UTF8StringHandle pchKey2 = new InteropHelp.UTF8StringHandle(pchKey);
			return InteropHelp.PtrToStringUTF8(NativeMethods.ISteamMatchmaking_GetLobbyMemberData(steamIDLobby, steamIDUser, pchKey2));
		}

		public static void SetLobbyMemberData(CSteamID steamIDLobby, string pchKey, string pchValue)
		{
			InteropHelp.TestIfAvailableClient();
			using InteropHelp.UTF8StringHandle pchKey2 = new InteropHelp.UTF8StringHandle(pchKey);
			using InteropHelp.UTF8StringHandle pchValue2 = new InteropHelp.UTF8StringHandle(pchValue);
			NativeMethods.ISteamMatchmaking_SetLobbyMemberData(steamIDLobby, pchKey2, pchValue2);
		}

		public static bool SendLobbyChatMsg(CSteamID steamIDLobby, byte[] pvMsgBody, int cubMsgBody)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamMatchmaking_SendLobbyChatMsg(steamIDLobby, pvMsgBody, cubMsgBody);
		}

		public static int GetLobbyChatEntry(CSteamID steamIDLobby, int iChatID, out CSteamID pSteamIDUser, byte[] pvData, int cubData, out EChatEntryType peChatEntryType)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamMatchmaking_GetLobbyChatEntry(steamIDLobby, iChatID, out pSteamIDUser, pvData, cubData, out peChatEntryType);
		}

		public static bool RequestLobbyData(CSteamID steamIDLobby)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamMatchmaking_RequestLobbyData(steamIDLobby);
		}

		public static void SetLobbyGameServer(CSteamID steamIDLobby, uint unGameServerIP, ushort unGameServerPort, CSteamID steamIDGameServer)
		{
			InteropHelp.TestIfAvailableClient();
			NativeMethods.ISteamMatchmaking_SetLobbyGameServer(steamIDLobby, unGameServerIP, unGameServerPort, steamIDGameServer);
		}

		public static bool GetLobbyGameServer(CSteamID steamIDLobby, out uint punGameServerIP, out ushort punGameServerPort, out CSteamID psteamIDGameServer)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamMatchmaking_GetLobbyGameServer(steamIDLobby, out punGameServerIP, out punGameServerPort, out psteamIDGameServer);
		}

		public static bool SetLobbyMemberLimit(CSteamID steamIDLobby, int cMaxMembers)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamMatchmaking_SetLobbyMemberLimit(steamIDLobby, cMaxMembers);
		}

		public static int GetLobbyMemberLimit(CSteamID steamIDLobby)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamMatchmaking_GetLobbyMemberLimit(steamIDLobby);
		}

		public static bool SetLobbyType(CSteamID steamIDLobby, ELobbyType eLobbyType)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamMatchmaking_SetLobbyType(steamIDLobby, eLobbyType);
		}

		public static bool SetLobbyJoinable(CSteamID steamIDLobby, bool bLobbyJoinable)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamMatchmaking_SetLobbyJoinable(steamIDLobby, bLobbyJoinable);
		}

		public static CSteamID GetLobbyOwner(CSteamID steamIDLobby)
		{
			InteropHelp.TestIfAvailableClient();
			return (CSteamID)NativeMethods.ISteamMatchmaking_GetLobbyOwner(steamIDLobby);
		}

		public static bool SetLobbyOwner(CSteamID steamIDLobby, CSteamID steamIDNewOwner)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamMatchmaking_SetLobbyOwner(steamIDLobby, steamIDNewOwner);
		}

		public static bool SetLinkedLobby(CSteamID steamIDLobby, CSteamID steamIDLobbyDependent)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamMatchmaking_SetLinkedLobby(steamIDLobby, steamIDLobbyDependent);
		}
	}
	public static class SteamMatchmakingServers
	{
		public static HServerListRequest RequestInternetServerList(AppId_t iApp, MatchMakingKeyValuePair_t[] ppchFilters, uint nFilters, ISteamMatchmakingServerListResponse pRequestServersResponse)
		{
			InteropHelp.TestIfAvailableClient();
			return (HServerListRequest)NativeMethods.ISteamMatchmakingServers_RequestInternetServerList(iApp, new MMKVPMarshaller(ppchFilters), nFilters, (IntPtr)pRequestServersResponse);
		}

		public static HServerListRequest RequestLANServerList(AppId_t iApp, ISteamMatchmakingServerListResponse pRequestServersResponse)
		{
			InteropHelp.TestIfAvailableClient();
			return (HServerListRequest)NativeMethods.ISteamMatchmakingServers_RequestLANServerList(iApp, (IntPtr)pRequestServersResponse);
		}

		public static HServerListRequest RequestFriendsServerList(AppId_t iApp, MatchMakingKeyValuePair_t[] ppchFilters, uint nFilters, ISteamMatchmakingServerListResponse pRequestServersResponse)
		{
			InteropHelp.TestIfAvailableClient();
			return (HServerListRequest)NativeMethods.ISteamMatchmakingServers_RequestFriendsServerList(iApp, new MMKVPMarshaller(ppchFilters), nFilters, (IntPtr)pRequestServersResponse);
		}

		public static HServerListRequest RequestFavoritesServerList(AppId_t iApp, MatchMakingKeyValuePair_t[] ppchFilters, uint nFilters, ISteamMatchmakingServerListResponse pRequestServersResponse)
		{
			InteropHelp.TestIfAvailableClient();
			return (HServerListRequest)NativeMethods.ISteamMatchmakingServers_RequestFavoritesServerList(iApp, new MMKVPMarshaller(ppchFilters), nFilters, (IntPtr)pRequestServersResponse);
		}

		public static HServerListRequest RequestHistoryServerList(AppId_t iApp, MatchMakingKeyValuePair_t[] ppchFilters, uint nFilters, ISteamMatchmakingServerListResponse pRequestServersResponse)
		{
			InteropHelp.TestIfAvailableClient();
			return (HServerListRequest)NativeMethods.ISteamMatchmakingServers_RequestHistoryServerList(iApp, new MMKVPMarshaller(ppchFilters), nFilters, (IntPtr)pRequestServersResponse);
		}

		public static HServerListRequest RequestSpectatorServerList(AppId_t iApp, MatchMakingKeyValuePair_t[] ppchFilters, uint nFilters, ISteamMatchmakingServerListResponse pRequestServersResponse)
		{
			InteropHelp.TestIfAvailableClient();
			return (HServerListRequest)NativeMethods.ISteamMatchmakingServers_RequestSpectatorServerList(iApp, new MMKVPMarshaller(ppchFilters), nFilters, (IntPtr)pRequestServersResponse);
		}

		public static void ReleaseRequest(HServerListRequest hServerListRequest)
		{
			InteropHelp.TestIfAvailableClient();
			NativeMethods.ISteamMatchmakingServers_ReleaseRequest(hServerListRequest);
		}

		public static gameserveritem_t GetServerDetails(HServerListRequest hRequest, int iServer)
		{
			InteropHelp.TestIfAvailableClient();
			return (gameserveritem_t)Marshal.PtrToStructure(NativeMethods.ISteamMatchmakingServers_GetServerDetails(hRequest, iServer), typeof(gameserveritem_t));
		}

		public static void CancelQuery(HServerListRequest hRequest)
		{
			InteropHelp.TestIfAvailableClient();
			NativeMethods.ISteamMatchmakingServers_CancelQuery(hRequest);
		}

		public static void RefreshQuery(HServerListRequest hRequest)
		{
			InteropHelp.TestIfAvailableClient();
			NativeMethods.ISteamMatchmakingServers_RefreshQuery(hRequest);
		}

		public static bool IsRefreshing(HServerListRequest hRequest)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamMatchmakingServers_IsRefreshing(hRequest);
		}

		public static int GetServerCount(HServerListRequest hRequest)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamMatchmakingServers_GetServerCount(hRequest);
		}

		public static void RefreshServer(HServerListRequest hRequest, int iServer)
		{
			InteropHelp.TestIfAvailableClient();
			NativeMethods.ISteamMatchmakingServers_RefreshServer(hRequest, iServer);
		}

		public static HServerQuery PingServer(uint unIP, ushort usPort, ISteamMatchmakingPingResponse pRequestServersResponse)
		{
			InteropHelp.TestIfAvailableClient();
			return (HServerQuery)NativeMethods.ISteamMatchmakingServers_PingServer(unIP, usPort, (IntPtr)pRequestServersResponse);
		}

		public static HServerQuery PlayerDetails(uint unIP, ushort usPort, ISteamMatchmakingPlayersResponse pRequestServersResponse)
		{
			InteropHelp.TestIfAvailableClient();
			return (HServerQuery)NativeMethods.ISteamMatchmakingServers_PlayerDetails(unIP, usPort, (IntPtr)pRequestServersResponse);
		}

		public static HServerQuery ServerRules(uint unIP, ushort usPort, ISteamMatchmakingRulesResponse pRequestServersResponse)
		{
			InteropHelp.TestIfAvailableClient();
			return (HServerQuery)NativeMethods.ISteamMatchmakingServers_ServerRules(unIP, usPort, (IntPtr)pRequestServersResponse);
		}

		public static void CancelServerQuery(HServerQuery hServerQuery)
		{
			InteropHelp.TestIfAvailableClient();
			NativeMethods.ISteamMatchmakingServers_CancelServerQuery(hServerQuery);
		}
	}
	public static class SteamMusic
	{
		public static bool BIsEnabled()
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamMusic_BIsEnabled();
		}

		public static bool BIsPlaying()
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamMusic_BIsPlaying();
		}

		public static AudioPlayback_Status GetPlaybackStatus()
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamMusic_GetPlaybackStatus();
		}

		public static void Play()
		{
			InteropHelp.TestIfAvailableClient();
			NativeMethods.ISteamMusic_Play();
		}

		public static void Pause()
		{
			InteropHelp.TestIfAvailableClient();
			NativeMethods.ISteamMusic_Pause();
		}

		public static void PlayPrevious()
		{
			InteropHelp.TestIfAvailableClient();
			NativeMethods.ISteamMusic_PlayPrevious();
		}

		public static void PlayNext()
		{
			InteropHelp.TestIfAvailableClient();
			NativeMethods.ISteamMusic_PlayNext();
		}

		public static void SetVolume(float flVolume)
		{
			InteropHelp.TestIfAvailableClient();
			NativeMethods.ISteamMusic_SetVolume(flVolume);
		}

		public static float GetVolume()
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamMusic_GetVolume();
		}
	}
	public static class SteamMusicRemote
	{
		public static bool RegisterSteamMusicRemote(string pchName)
		{
			InteropHelp.TestIfAvailableClient();
			using InteropHelp.UTF8StringHandle pchName2 = new InteropHelp.UTF8StringHandle(pchName);
			return NativeMethods.ISteamMusicRemote_RegisterSteamMusicRemote(pchName2);
		}

		public static bool DeregisterSteamMusicRemote()
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamMusicRemote_DeregisterSteamMusicRemote();
		}

		public static bool BIsCurrentMusicRemote()
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamMusicRemote_BIsCurrentMusicRemote();
		}

		public static bool BActivationSuccess(bool bValue)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamMusicRemote_BActivationSuccess(bValue);
		}

		public static bool SetDisplayName(string pchDisplayName)
		{
			InteropHelp.TestIfAvailableClient();
			using InteropHelp.UTF8StringHandle pchDisplayName2 = new InteropHelp.UTF8StringHandle(pchDisplayName);
			return NativeMethods.ISteamMusicRemote_SetDisplayName(pchDisplayName2);
		}

		public static bool SetPNGIcon_64x64(byte[] pvBuffer, uint cbBufferLength)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamMusicRemote_SetPNGIcon_64x64(pvBuffer, cbBufferLength);
		}

		public static bool EnablePlayPrevious(bool bValue)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamMusicRemote_EnablePlayPrevious(bValue);
		}

		public static bool EnablePlayNext(bool bValue)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamMusicRemote_EnablePlayNext(bValue);
		}

		public static bool EnableShuffled(bool bValue)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamMusicRemote_EnableShuffled(bValue);
		}

		public static bool EnableLooped(bool bValue)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamMusicRemote_EnableLooped(bValue);
		}

		public static bool EnableQueue(bool bValue)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamMusicRemote_EnableQueue(bValue);
		}

		public static bool EnablePlaylists(bool bValue)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamMusicRemote_EnablePlaylists(bValue);
		}

		public static bool UpdatePlaybackStatus(AudioPlayback_Status nStatus)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamMusicRemote_UpdatePlaybackStatus(nStatus);
		}

		public static bool UpdateShuffled(bool bValue)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamMusicRemote_UpdateShuffled(bValue);
		}

		public static bool UpdateLooped(bool bValue)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamMusicRemote_UpdateLooped(bValue);
		}

		public static bool UpdateVolume(float flValue)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamMusicRemote_UpdateVolume(flValue);
		}

		public static bool CurrentEntryWillChange()
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamMusicRemote_CurrentEntryWillChange();
		}

		public static bool CurrentEntryIsAvailable(bool bAvailable)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamMusicRemote_CurrentEntryIsAvailable(bAvailable);
		}

		public static bool UpdateCurrentEntryText(string pchText)
		{
			InteropHelp.TestIfAvailableClient();
			using InteropHelp.UTF8StringHandle pchText2 = new InteropHelp.UTF8StringHandle(pchText);
			return NativeMethods.ISteamMusicRemote_UpdateCurrentEntryText(pchText2);
		}

		public static bool UpdateCurrentEntryElapsedSeconds(int nValue)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamMusicRemote_UpdateCurrentEntryElapsedSeconds(nValue);
		}

		public static bool UpdateCurrentEntryCoverArt(byte[] pvBuffer, uint cbBufferLength)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamMusicRemote_UpdateCurrentEntryCoverArt(pvBuffer, cbBufferLength);
		}

		public static bool CurrentEntryDidChange()
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamMusicRemote_CurrentEntryDidChange();
		}

		public static bool QueueWillChange()
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamMusicRemote_QueueWillChange();
		}

		public static bool ResetQueueEntries()
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamMusicRemote_ResetQueueEntries();
		}

		public static bool SetQueueEntry(int nID, int nPosition, string pchEntryText)
		{
			InteropHelp.TestIfAvailableClient();
			using InteropHelp.UTF8StringHandle pchEntryText2 = new InteropHelp.UTF8StringHandle(pchEntryText);
			return NativeMethods.ISteamMusicRemote_SetQueueEntry(nID, nPosition, pchEntryText2);
		}

		public static bool SetCurrentQueueEntry(int nID)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamMusicRemote_SetCurrentQueueEntry(nID);
		}

		public static bool QueueDidChange()
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamMusicRemote_QueueDidChange();
		}

		public static bool PlaylistWillChange()
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamMusicRemote_PlaylistWillChange();
		}

		public static bool ResetPlaylistEntries()
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamMusicRemote_ResetPlaylistEntries();
		}

		public static bool SetPlaylistEntry(int nID, int nPosition, string pchEntryText)
		{
			InteropHelp.TestIfAvailableClient();
			using InteropHelp.UTF8StringHandle pchEntryText2 = new InteropHelp.UTF8StringHandle(pchEntryText);
			return NativeMethods.ISteamMusicRemote_SetPlaylistEntry(nID, nPosition, pchEntryText2);
		}

		public static bool SetCurrentPlaylistEntry(int nID)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamMusicRemote_SetCurrentPlaylistEntry(nID);
		}

		public static bool PlaylistDidChange()
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamMusicRemote_PlaylistDidChange();
		}
	}
	public static class SteamNetworking
	{
		public static bool SendP2PPacket(CSteamID steamIDRemote, byte[] pubData, uint cubData, EP2PSend eP2PSendType, int nChannel = 0)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamNetworking_SendP2PPacket(steamIDRemote, pubData, cubData, eP2PSendType, nChannel);
		}

		public static bool IsP2PPacketAvailable(out uint pcubMsgSize, int nChannel = 0)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamNetworking_IsP2PPacketAvailable(out pcubMsgSize, nChannel);
		}

		public static bool ReadP2PPacket(byte[] pubDest, uint cubDest, out uint pcubMsgSize, out CSteamID psteamIDRemote, int nChannel = 0)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamNetworking_ReadP2PPacket(pubDest, cubDest, out pcubMsgSize, out psteamIDRemote, nChannel);
		}

		public static bool AcceptP2PSessionWithUser(CSteamID steamIDRemote)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamNetworking_AcceptP2PSessionWithUser(steamIDRemote);
		}

		public static bool CloseP2PSessionWithUser(CSteamID steamIDRemote)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamNetworking_CloseP2PSessionWithUser(steamIDRemote);
		}

		public static bool CloseP2PChannelWithUser(CSteamID steamIDRemote, int nChannel)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamNetworking_CloseP2PChannelWithUser(steamIDRemote, nChannel);
		}

		public static bool GetP2PSessionState(CSteamID steamIDRemote, out P2PSessionState_t pConnectionState)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamNetworking_GetP2PSessionState(steamIDRemote, out pConnectionState);
		}

		public static bool AllowP2PPacketRelay(bool bAllow)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamNetworking_AllowP2PPacketRelay(bAllow);
		}

		public static SNetListenSocket_t CreateListenSocket(int nVirtualP2PPort, uint nIP, ushort nPort, bool bAllowUseOfPacketRelay)
		{
			InteropHelp.TestIfAvailableClient();
			return (SNetListenSocket_t)NativeMethods.ISteamNetworking_CreateListenSocket(nVirtualP2PPort, nIP, nPort, bAllowUseOfPacketRelay);
		}

		public static SNetSocket_t CreateP2PConnectionSocket(CSteamID steamIDTarget, int nVirtualPort, int nTimeoutSec, bool bAllowUseOfPacketRelay)
		{
			InteropHelp.TestIfAvailableClient();
			return (SNetSocket_t)NativeMethods.ISteamNetworking_CreateP2PConnectionSocket(steamIDTarget, nVirtualPort, nTimeoutSec, bAllowUseOfPacketRelay);
		}

		public static SNetSocket_t CreateConnectionSocket(uint nIP, ushort nPort, int nTimeoutSec)
		{
			InteropHelp.TestIfAvailableClient();
			return (SNetSocket_t)NativeMethods.ISteamNetworking_CreateConnectionSocket(nIP, nPort, nTimeoutSec);
		}

		public static bool DestroySocket(SNetSocket_t hSocket, bool bNotifyRemoteEnd)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamNetworking_DestroySocket(hSocket, bNotifyRemoteEnd);
		}

		public static bool DestroyListenSocket(SNetListenSocket_t hSocket, bool bNotifyRemoteEnd)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamNetworking_DestroyListenSocket(hSocket, bNotifyRemoteEnd);
		}

		public static bool SendDataOnSocket(SNetSocket_t hSocket, IntPtr pubData, uint cubData, bool bReliable)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamNetworking_SendDataOnSocket(hSocket, pubData, cubData, bReliable);
		}

		public static bool IsDataAvailableOnSocket(SNetSocket_t hSocket, out uint pcubMsgSize)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamNetworking_IsDataAvailableOnSocket(hSocket, out pcubMsgSize);
		}

		public static bool RetrieveDataFromSocket(SNetSocket_t hSocket, IntPtr pubDest, uint cubDest, out uint pcubMsgSize)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamNetworking_RetrieveDataFromSocket(hSocket, pubDest, cubDest, out pcubMsgSize);
		}

		public static bool IsDataAvailable(SNetListenSocket_t hListenSocket, out uint pcubMsgSize, out SNetSocket_t phSocket)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamNetworking_IsDataAvailable(hListenSocket, out pcubMsgSize, out phSocket);
		}

		public static bool RetrieveData(SNetListenSocket_t hListenSocket, IntPtr pubDest, uint cubDest, out uint pcubMsgSize, out SNetSocket_t phSocket)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamNetworking_RetrieveData(hListenSocket, pubDest, cubDest, out pcubMsgSize, out phSocket);
		}

		public static bool GetSocketInfo(SNetSocket_t hSocket, out CSteamID pSteamIDRemote, out int peSocketStatus, out uint punIPRemote, out ushort punPortRemote)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamNetworking_GetSocketInfo(hSocket, out pSteamIDRemote, out peSocketStatus, out punIPRemote, out punPortRemote);
		}

		public static bool GetListenSocketInfo(SNetListenSocket_t hListenSocket, out uint pnIP, out ushort pnPort)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamNetworking_GetListenSocketInfo(hListenSocket, out pnIP, out pnPort);
		}

		public static ESNetSocketConnectionType GetSocketConnectionType(SNetSocket_t hSocket)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamNetworking_GetSocketConnectionType(hSocket);
		}

		public static int GetMaxPacketSize(SNetSocket_t hSocket)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamNetworking_GetMaxPacketSize(hSocket);
		}
	}
	public static class SteamRemoteStorage
	{
		public static bool FileWrite(string pchFile, byte[] pvData, int cubData)
		{
			InteropHelp.TestIfAvailableClient();
			using InteropHelp.UTF8StringHandle pchFile2 = new InteropHelp.UTF8StringHandle(pchFile);
			return NativeMethods.ISteamRemoteStorage_FileWrite(pchFile2, pvData, cubData);
		}

		public static int FileRead(string pchFile, byte[] pvData, int cubDataToRead)
		{
			InteropHelp.TestIfAvailableClient();
			using InteropHelp.UTF8StringHandle pchFile2 = new InteropHelp.UTF8StringHandle(pchFile);
			return NativeMethods.ISteamRemoteStorage_FileRead(pchFile2, pvData, cubDataToRead);
		}

		public static bool FileForget(string pchFile)
		{
			InteropHelp.TestIfAvailableClient();
			using InteropHelp.UTF8StringHandle pchFile2 = new InteropHelp.UTF8StringHandle(pchFile);
			return NativeMethods.ISteamRemoteStorage_FileForget(pchFile2);
		}

		public static bool FileDelete(string pchFile)
		{
			InteropHelp.TestIfAvailableClient();
			using InteropHelp.UTF8StringHandle pchFile2 = new InteropHelp.UTF8StringHandle(pchFile);
			return NativeMethods.ISteamRemoteStorage_FileDelete(pchFile2);
		}

		public static SteamAPICall_t FileShare(string pchFile)
		{
			InteropHelp.TestIfAvailableClient();
			using InteropHelp.UTF8StringHandle pchFile2 = new InteropHelp.UTF8StringHandle(pchFile);
			return (SteamAPICall_t)NativeMethods.ISteamRemoteStorage_FileShare(pchFile2);
		}

		public static bool SetSyncPlatforms(string pchFile, ERemoteStoragePlatform eRemoteStoragePlatform)
		{
			InteropHelp.TestIfAvailableClient();
			using InteropHelp.UTF8StringHandle pchFile2 = new InteropHelp.UTF8StringHandle(pchFile);
			return NativeMethods.ISteamRemoteStorage_SetSyncPlatforms(pchFile2, eRemoteStoragePlatform);
		}

		public static UGCFileWriteStreamHandle_t FileWriteStreamOpen(string pchFile)
		{
			InteropHelp.TestIfAvailableClient();
			using InteropHelp.UTF8StringHandle pchFile2 = new InteropHelp.UTF8StringHandle(pchFile);
			return (UGCFileWriteStreamHandle_t)NativeMethods.ISteamRemoteStorage_FileWriteStreamOpen(pchFile2);
		}

		public static bool FileWriteStreamWriteChunk(UGCFileWriteStreamHandle_t writeHandle, byte[] pvData, int cubData)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamRemoteStorage_FileWriteStreamWriteChunk(writeHandle, pvData, cubData);
		}

		public static bool FileWriteStreamClose(UGCFileWriteStreamHandle_t writeHandle)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamRemoteStorage_FileWriteStreamClose(writeHandle);
		}

		public static bool FileWriteStreamCancel(UGCFileWriteStreamHandle_t writeHandle)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamRemoteStorage_FileWriteStreamCancel(writeHandle);
		}

		public static bool FileExists(string pchFile)
		{
			InteropHelp.TestIfAvailableClient();
			using InteropHelp.UTF8StringHandle pchFile2 = new InteropHelp.UTF8StringHandle(pchFile);
			return NativeMethods.ISteamRemoteStorage_FileExists(pchFile2);
		}

		public static bool FilePersisted(string pchFile)
		{
			InteropHelp.TestIfAvailableClient();
			using InteropHelp.UTF8StringHandle pchFile2 = new InteropHelp.UTF8StringHandle(pchFile);
			return NativeMethods.ISteamRemoteStorage_FilePersisted(pchFile2);
		}

		public static int GetFileSize(string pchFile)
		{
			InteropHelp.TestIfAvailableClient();
			using InteropHelp.UTF8StringHandle pchFile2 = new InteropHelp.UTF8StringHandle(pchFile);
			return NativeMethods.ISteamRemoteStorage_GetFileSize(pchFile2);
		}

		public static long GetFileTimestamp(string pchFile)
		{
			InteropHelp.TestIfAvailableClient();
			using InteropHelp.UTF8StringHandle pchFile2 = new InteropHelp.UTF8StringHandle(pchFile);
			return NativeMethods.ISteamRemoteStorage_GetFileTimestamp(pchFile2);
		}

		public static ERemoteStoragePlatform GetSyncPlatforms(string pchFile)
		{
			InteropHelp.TestIfAvailableClient();
			using InteropHelp.UTF8StringHandle pchFile2 = new InteropHelp.UTF8StringHandle(pchFile);
			return NativeMethods.ISteamRemoteStorage_GetSyncPlatforms(pchFile2);
		}

		public static int GetFileCount()
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamRemoteStorage_GetFileCount();
		}

		public static string GetFileNameAndSize(int iFile, out int pnFileSizeInBytes)
		{
			InteropHelp.TestIfAvailableClient();
			return InteropHelp.PtrToStringUTF8(NativeMethods.ISteamRemoteStorage_GetFileNameAndSize(iFile, out pnFileSizeInBytes));
		}

		public static bool GetQuota(out int pnTotalBytes, out int puAvailableBytes)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamRemoteStorage_GetQuota(out pnTotalBytes, out puAvailableBytes);
		}

		public static bool IsCloudEnabledForAccount()
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamRemoteStorage_IsCloudEnabledForAccount();
		}

		public static bool IsCloudEnabledForApp()
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamRemoteStorage_IsCloudEnabledForApp();
		}

		public static void SetCloudEnabledForApp(bool bEnabled)
		{
			InteropHelp.TestIfAvailableClient();
			NativeMethods.ISteamRemoteStorage_SetCloudEnabledForApp(bEnabled);
		}

		public static SteamAPICall_t UGCDownload(UGCHandle_t hContent, uint unPriority)
		{
			InteropHelp.TestIfAvailableClient();
			return (SteamAPICall_t)NativeMethods.ISteamRemoteStorage_UGCDownload(hContent, unPriority);
		}

		public static bool GetUGCDownloadProgress(UGCHandle_t hContent, out int pnBytesDownloaded, out int pnBytesExpected)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamRemoteStorage_GetUGCDownloadProgress(hContent, out pnBytesDownloaded, out pnBytesExpected);
		}

		public static bool GetUGCDetails(UGCHandle_t hContent, out AppId_t pnAppID, out string ppchName, out int pnFileSizeInBytes, out CSteamID pSteamIDOwner)
		{
			InteropHelp.TestIfAvailableClient();
			IntPtr ppchName2;
			bool flag = NativeMethods.ISteamRemoteStorage_GetUGCDetails(hContent, out pnAppID, out ppchName2, out pnFileSizeInBytes, out pSteamIDOwner);
			ppchName = (flag ? InteropHelp.PtrToStringUTF8(ppchName2) : null);
			return flag;
		}

		public static int UGCRead(UGCHandle_t hContent, byte[] pvData, int cubDataToRead, uint cOffset, EUGCReadAction eAction)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamRemoteStorage_UGCRead(hContent, pvData, cubDataToRead, cOffset, eAction);
		}

		public static int GetCachedUGCCount()
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamRemoteStorage_GetCachedUGCCount();
		}

		public static UGCHandle_t GetCachedUGCHandle(int iCachedContent)
		{
			InteropHelp.TestIfAvailableClient();
			return (UGCHandle_t)NativeMethods.ISteamRemoteStorage_GetCachedUGCHandle(iCachedContent);
		}

		public static SteamAPICall_t PublishWorkshopFile(string pchFile, string pchPreviewFile, AppId_t nConsumerAppId, string pchTitle, string pchDescription, ERemoteStoragePublishedFileVisibility eVisibility, IList<string> pTags, EWorkshopFileType eWorkshopFileType)
		{
			InteropHelp.TestIfAvailableClient();
			using InteropHelp.UTF8StringHandle pchFile2 = new InteropHelp.UTF8StringHandle(pchFile);
			using InteropHelp.UTF8StringHandle pchPreviewFile2 = new InteropHelp.UTF8StringHandle(pchPreviewFile);
			using InteropHelp.UTF8StringHandle pchTitle2 = new InteropHelp.UTF8StringHandle(pchTitle);
			using InteropHelp.UTF8StringHandle pchDescription2 = new InteropHelp.UTF8StringHandle(pchDescription);
			return (SteamAPICall_t)NativeMethods.ISteamRemoteStorage_PublishWorkshopFile(pchFile2, pchPreviewFile2, nConsumerAppId, pchTitle2, pchDescription2, eVisibility, new InteropHelp.SteamParamStringArray(pTags), eWorkshopFileType);
		}

		public static PublishedFileUpdateHandle_t CreatePublishedFileUpdateRequest(PublishedFileId_t unPublishedFileId)
		{
			InteropHelp.TestIfAvailableClient();
			return (PublishedFileUpdateHandle_t)NativeMethods.ISteamRemoteStorage_CreatePublishedFileUpdateRequest(unPublishedFileId);
		}

		public static bool UpdatePublishedFileFile(PublishedFileUpdateHandle_t updateHandle, string pchFile)
		{
			InteropHelp.TestIfAvailableClient();
			using InteropHelp.UTF8StringHandle pchFile2 = new InteropHelp.UTF8StringHandle(pchFile);
			return NativeMethods.ISteamRemoteStorage_UpdatePublishedFileFile(updateHandle, pchFile2);
		}

		public static bool UpdatePublishedFilePreviewFile(PublishedFileUpdateHandle_t updateHandle, string pchPreviewFile)
		{
			InteropHelp.TestIfAvailableClient();
			using InteropHelp.UTF8StringHandle pchPreviewFile2 = new InteropHelp.UTF8StringHandle(pchPreviewFile);
			return NativeMethods.ISteamRemoteStorage_UpdatePublishedFilePreviewFile(updateHandle, pchPreviewFile2);
		}

		public static bool UpdatePublishedFileTitle(PublishedFileUpdateHandle_t updateHandle, string pchTitle)
		{
			InteropHelp.TestIfAvailableClient();
			using InteropHelp.UTF8StringHandle pchTitle2 = new InteropHelp.UTF8StringHandle(pchTitle);
			return NativeMethods.ISteamRemoteStorage_UpdatePublishedFileTitle(updateHandle, pchTitle2);
		}

		public static bool UpdatePublishedFileDescription(PublishedFileUpdateHandle_t updateHandle, string pchDescription)
		{
			InteropHelp.TestIfAvailableClient();
			using InteropHelp.UTF8StringHandle pchDescription2 = new InteropHelp.UTF8StringHandle(pchDescription);
			return NativeMethods.ISteamRemoteStorage_UpdatePublishedFileDescription(updateHandle, pchDescription2);
		}

		public static bool UpdatePublishedFileVisibility(PublishedFileUpdateHandle_t updateHandle, ERemoteStoragePublishedFileVisibility eVisibility)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamRemoteStorage_UpdatePublishedFileVisibility(updateHandle, eVisibility);
		}

		public static bool UpdatePublishedFileTags(PublishedFileUpdateHandle_t updateHandle, IList<string> pTags)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamRemoteStorage_UpdatePublishedFileTags(updateHandle, new InteropHelp.SteamParamStringArray(pTags));
		}

		public static SteamAPICall_t CommitPublishedFileUpdate(PublishedFileUpdateHandle_t updateHandle)
		{
			InteropHelp.TestIfAvailableClient();
			return (SteamAPICall_t)NativeMethods.ISteamRemoteStorage_CommitPublishedFileUpdate(updateHandle);
		}

		public static SteamAPICall_t GetPublishedFileDetails(PublishedFileId_t unPublishedFileId, uint unMaxSecondsOld)
		{
			InteropHelp.TestIfAvailableClient();
			return (SteamAPICall_t)NativeMethods.ISteamRemoteStorage_GetPublishedFileDetails(unPublishedFileId, unMaxSecondsOld);
		}

		public static SteamAPICall_t DeletePublishedFile(PublishedFileId_t unPublishedFileId)
		{
			InteropHelp.TestIfAvailableClient();
			return (SteamAPICall_t)NativeMethods.ISteamRemoteStorage_DeletePublishedFile(unPublishedFileId);
		}

		public static SteamAPICall_t EnumerateUserPublishedFiles(uint unStartIndex)
		{
			InteropHelp.TestIfAvailableClient();
			return (SteamAPICall_t)NativeMethods.ISteamRemoteStorage_EnumerateUserPublishedFiles(unStartIndex);
		}

		public static SteamAPICall_t SubscribePublishedFile(PublishedFileId_t unPublishedFileId)
		{
			InteropHelp.TestIfAvailableClient();
			return (SteamAPICall_t)NativeMethods.ISteamRemoteStorage_SubscribePublishedFile(unPublishedFileId);
		}

		public static SteamAPICall_t EnumerateUserSubscribedFiles(uint unStartIndex)
		{
			InteropHelp.TestIfAvailableClient();
			return (SteamAPICall_t)NativeMethods.ISteamRemoteStorage_EnumerateUserSubscribedFiles(unStartIndex);
		}

		public static SteamAPICall_t UnsubscribePublishedFile(PublishedFileId_t unPublishedFileId)
		{
			InteropHelp.TestIfAvailableClient();
			return (SteamAPICall_t)NativeMethods.ISteamRemoteStorage_UnsubscribePublishedFile(unPublishedFileId);
		}

		public static bool UpdatePublishedFileSetChangeDescription(PublishedFileUpdateHandle_t updateHandle, string pchChangeDescription)
		{
			InteropHelp.TestIfAvailableClient();
			using InteropHelp.UTF8StringHandle pchChangeDescription2 = new InteropHelp.UTF8StringHandle(pchChangeDescription);
			return NativeMethods.ISteamRemoteStorage_UpdatePublishedFileSetChangeDescription(updateHandle, pchChangeDescription2);
		}

		public static SteamAPICall_t GetPublishedItemVoteDetails(PublishedFileId_t unPublishedFileId)
		{
			InteropHelp.TestIfAvailableClient();
			return (SteamAPICall_t)NativeMethods.ISteamRemoteStorage_GetPublishedItemVoteDetails(unPublishedFileId);
		}

		public static SteamAPICall_t UpdateUserPublishedItemVote(PublishedFileId_t unPublishedFileId, bool bVoteUp)
		{
			InteropHelp.TestIfAvailableClient();
			return (SteamAPICall_t)NativeMethods.ISteamRemoteStorage_UpdateUserPublishedItemVote(unPublishedFileId, bVoteUp);
		}

		public static SteamAPICall_t GetUserPublishedItemVoteDetails(PublishedFileId_t unPublishedFileId)
		{
			InteropHelp.TestIfAvailableClient();
			return (SteamAPICall_t)NativeMethods.ISteamRemoteStorage_GetUserPublishedItemVoteDetails(unPublishedFileId);
		}

		public static SteamAPICall_t EnumerateUserSharedWorkshopFiles(CSteamID steamId, uint unStartIndex, IList<string> pRequiredTags, IList<string> pExcludedTags)
		{
			InteropHelp.TestIfAvailableClient();
			return (SteamAPICall_t)NativeMethods.ISteamRemoteStorage_EnumerateUserSharedWorkshopFiles(steamId, unStartIndex, new InteropHelp.SteamParamStringArray(pRequiredTags), new InteropHelp.SteamParamStringArray(pExcludedTags));
		}

		public static SteamAPICall_t PublishVideo(EWorkshopVideoProvider eVideoProvider, string pchVideoAccount, string pchVideoIdentifier, string pchPreviewFile, AppId_t nConsumerAppId, string pchTitle, string pchDescription, ERemoteStoragePublishedFileVisibility eVisibility, IList<string> pTags)
		{
			InteropHelp.TestIfAvailableClient();
			using InteropHelp.UTF8StringHandle pchVideoAccount2 = new InteropHelp.UTF8StringHandle(pchVideoAccount);
			using InteropHelp.UTF8StringHandle pchVideoIdentifier2 = new InteropHelp.UTF8StringHandle(pchVideoIdentifier);
			using InteropHelp.UTF8StringHandle pchPreviewFile2 = new InteropHelp.UTF8StringHandle(pchPreviewFile);
			using InteropHelp.UTF8StringHandle pchTitle2 = new InteropHelp.UTF8StringHandle(pchTitle);
			using InteropHelp.UTF8StringHandle pchDescription2 = new InteropHelp.UTF8StringHandle(pchDescription);
			return (SteamAPICall_t)NativeMethods.ISteamRemoteStorage_PublishVideo(eVideoProvider, pchVideoAccount2, pchVideoIdentifier2, pchPreviewFile2, nConsumerAppId, pchTitle2, pchDescription2, eVisibility, new InteropHelp.SteamParamStringArray(pTags));
		}

		public static SteamAPICall_t SetUserPublishedFileAction(PublishedFileId_t unPublishedFileId, EWorkshopFileAction eAction)
		{
			InteropHelp.TestIfAvailableClient();
			return (SteamAPICall_t)NativeMethods.ISteamRemoteStorage_SetUserPublishedFileAction(unPublishedFileId, eAction);
		}

		public static SteamAPICall_t EnumeratePublishedFilesByUserAction(EWorkshopFileAction eAction, uint unStartIndex)
		{
			InteropHelp.TestIfAvailableClient();
			return (SteamAPICall_t)NativeMethods.ISteamRemoteStorage_EnumeratePublishedFilesByUserAction(eAction, unStartIndex);
		}

		public static SteamAPICall_t EnumeratePublishedWorkshopFiles(EWorkshopEnumerationType eEnumerationType, uint unStartIndex, uint unCount, uint unDays, IList<string> pTags, IList<string> pUserTags)
		{
			InteropHelp.TestIfAvailableClient();
			return (SteamAPICall_t)NativeMethods.ISteamRemoteStorage_EnumeratePublishedWorkshopFiles(eEnumerationType, unStartIndex, unCount, unDays, new InteropHelp.SteamParamStringArray(pTags), new InteropHelp.SteamParamStringArray(pUserTags));
		}

		public static SteamAPICall_t UGCDownloadToLocation(UGCHandle_t hContent, string pchLocation, uint unPriority)
		{
			InteropHelp.TestIfAvailableClient();
			using InteropHelp.UTF8StringHandle pchLocation2 = new InteropHelp.UTF8StringHandle(pchLocation);
			return (SteamAPICall_t)NativeMethods.ISteamRemoteStorage_UGCDownloadToLocation(hContent, pchLocation2, unPriority);
		}
	}
	public static class SteamScreenshots
	{
		public static ScreenshotHandle WriteScreenshot(byte[] pubRGB, uint cubRGB, int nWidth, int nHeight)
		{
			InteropHelp.TestIfAvailableClient();
			return (ScreenshotHandle)NativeMethods.ISteamScreenshots_WriteScreenshot(pubRGB, cubRGB, nWidth, nHeight);
		}

		public static ScreenshotHandle AddScreenshotToLibrary(string pchFilename, string pchThumbnailFilename, int nWidth, int nHeight)
		{
			InteropHelp.TestIfAvailableClient();
			using InteropHelp.UTF8StringHandle pchFilename2 = new InteropHelp.UTF8StringHandle(pchFilename);
			using InteropHelp.UTF8StringHandle pchThumbnailFilename2 = new InteropHelp.UTF8StringHandle(pchThumbnailFilename);
			return (ScreenshotHandle)NativeMethods.ISteamScreenshots_AddScreenshotToLibrary(pchFilename2, pchThumbnailFilename2, nWidth, nHeight);
		}

		public static void TriggerScreenshot()
		{
			InteropHelp.TestIfAvailableClient();
			NativeMethods.ISteamScreenshots_TriggerScreenshot();
		}

		public static void HookScreenshots(bool bHook)
		{
			InteropHelp.TestIfAvailableClient();
			NativeMethods.ISteamScreenshots_HookScreenshots(bHook);
		}

		public static bool SetLocation(ScreenshotHandle hScreenshot, string pchLocation)
		{
			InteropHelp.TestIfAvailableClient();
			using InteropHelp.UTF8StringHandle pchLocation2 = new InteropHelp.UTF8StringHandle(pchLocation);
			return NativeMethods.ISteamScreenshots_SetLocation(hScreenshot, pchLocation2);
		}

		public static bool TagUser(ScreenshotHandle hScreenshot, CSteamID steamID)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamScreenshots_TagUser(hScreenshot, steamID);
		}

		public static bool TagPublishedFile(ScreenshotHandle hScreenshot, PublishedFileId_t unPublishedFileID)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamScreenshots_TagPublishedFile(hScreenshot, unPublishedFileID);
		}
	}
	public static class SteamUGC
	{
		public static UGCQueryHandle_t CreateQueryUserUGCRequest(AccountID_t unAccountID, EUserUGCList eListType, EUGCMatchingUGCType eMatchingUGCType, EUserUGCListSortOrder eSortOrder, AppId_t nCreatorAppID, AppId_t nConsumerAppID, uint unPage)
		{
			InteropHelp.TestIfAvailableClient();
			return (UGCQueryHandle_t)NativeMethods.ISteamUGC_CreateQueryUserUGCRequest(unAccountID, eListType, eMatchingUGCType, eSortOrder, nCreatorAppID, nConsumerAppID, unPage);
		}

		public static UGCQueryHandle_t CreateQueryAllUGCRequest(EUGCQuery eQueryType, EUGCMatchingUGCType eMatchingeMatchingUGCTypeFileType, AppId_t nCreatorAppID, AppId_t nConsumerAppID, uint unPage)
		{
			InteropHelp.TestIfAvailableClient();
			return (UGCQueryHandle_t)NativeMethods.ISteamUGC_CreateQueryAllUGCRequest(eQueryType, eMatchingeMatchingUGCTypeFileType, nCreatorAppID, nConsumerAppID, unPage);
		}

		public static UGCQueryHandle_t CreateQueryUGCDetailsRequest(PublishedFileId_t[] pvecPublishedFileID, uint unNumPublishedFileIDs)
		{
			InteropHelp.TestIfAvailableClient();
			return (UGCQueryHandle_t)NativeMethods.ISteamUGC_CreateQueryUGCDetailsRequest(pvecPublishedFileID, unNumPublishedFileIDs);
		}

		public static SteamAPICall_t SendQueryUGCRequest(UGCQueryHandle_t handle)
		{
			InteropHelp.TestIfAvailableClient();
			return (SteamAPICall_t)NativeMethods.ISteamUGC_SendQueryUGCRequest(handle);
		}

		public static bool GetQueryUGCResult(UGCQueryHandle_t handle, uint index, out SteamUGCDetails_t pDetails)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamUGC_GetQueryUGCResult(handle, index, out pDetails);
		}

		public static bool GetQueryUGCPreviewURL(UGCQueryHandle_t handle, uint index, out string pchURL, uint cchURLSize)
		{
			InteropHelp.TestIfAvailableClient();
			IntPtr intPtr = Marshal.AllocHGlobal((int)cchURLSize);
			bool flag = NativeMethods.ISteamUGC_GetQueryUGCPreviewURL(handle, index, intPtr, cchURLSize);
			pchURL = (flag ? InteropHelp.PtrToStringUTF8(intPtr) : null);
			Marshal.FreeHGlobal(intPtr);
			return flag;
		}

		public static bool GetQueryUGCMetadata(UGCQueryHandle_t handle, uint index, out string pchMetadata, uint cchMetadatasize)
		{
			InteropHelp.TestIfAvailableClient();
			IntPtr intPtr = Marshal.AllocHGlobal((int)cchMetadatasize);
			bool flag = NativeMethods.ISteamUGC_GetQueryUGCMetadata(handle, index, intPtr, cchMetadatasize);
			pchMetadata = (flag ? InteropHelp.PtrToStringUTF8(intPtr) : null);
			Marshal.FreeHGlobal(intPtr);
			return flag;
		}

		public static bool GetQueryUGCChildren(UGCQueryHandle_t handle, uint index, PublishedFileId_t[] pvecPublishedFileID, uint cMaxEntries)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamUGC_GetQueryUGCChildren(handle, index, pvecPublishedFileID, cMaxEntries);
		}

		public static bool GetQueryUGCStatistic(UGCQueryHandle_t handle, uint index, EItemStatistic eStatType, out uint pStatValue)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamUGC_GetQueryUGCStatistic(handle, index, eStatType, out pStatValue);
		}

		public static uint GetQueryUGCNumAdditionalPreviews(UGCQueryHandle_t handle, uint index)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamUGC_GetQueryUGCNumAdditionalPreviews(handle, index);
		}

		public static bool GetQueryUGCAdditionalPreview(UGCQueryHandle_t handle, uint index, uint previewIndex, out string pchURLOrVideoID, uint cchURLSize, out bool pbIsImage)
		{
			InteropHelp.TestIfAvailableClient();
			IntPtr intPtr = Marshal.AllocHGlobal((int)cchURLSize);
			bool flag = NativeMethods.ISteamUGC_GetQueryUGCAdditionalPreview(handle, index, previewIndex, intPtr, cchURLSize, out pbIsImage);
			pchURLOrVideoID = (flag ? InteropHelp.PtrToStringUTF8(intPtr) : null);
			Marshal.FreeHGlobal(intPtr);
			return flag;
		}

		public static uint GetQueryUGCNumKeyValueTags(UGCQueryHandle_t handle, uint index)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamUGC_GetQueryUGCNumKeyValueTags(handle, index);
		}

		public static bool GetQueryUGCKeyValueTag(UGCQueryHandle_t handle, uint index, uint keyValueTagIndex, out string pchKey, uint cchKeySize, out string pchValue, uint cchValueSize)
		{
			InteropHelp.TestIfAvailableClient();
			IntPtr intPtr = Marshal.AllocHGlobal((int)cchKeySize);
			IntPtr intPtr2 = Marshal.AllocHGlobal((int)cchValueSize);
			bool flag = NativeMethods.ISteamUGC_GetQueryUGCKeyValueTag(handle, index, keyValueTagIndex, intPtr, cchKeySize, intPtr2, cchValueSize);
			pchKey = (flag ? InteropHelp.PtrToStringUTF8(intPtr) : null);
			Marshal.FreeHGlobal(intPtr);
			pchValue = (flag ? InteropHelp.PtrToStringUTF8(intPtr2) : null);
			Marshal.FreeHGlobal(intPtr2);
			return flag;
		}

		public static bool ReleaseQueryUGCRequest(UGCQueryHandle_t handle)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamUGC_ReleaseQueryUGCRequest(handle);
		}

		public static bool AddRequiredTag(UGCQueryHandle_t handle, string pTagName)
		{
			InteropHelp.TestIfAvailableClient();
			using InteropHelp.UTF8StringHandle pTagName2 = new InteropHelp.UTF8StringHandle(pTagName);
			return NativeMethods.ISteamUGC_AddRequiredTag(handle, pTagName2);
		}

		public static bool AddExcludedTag(UGCQueryHandle_t handle, string pTagName)
		{
			InteropHelp.TestIfAvailableClient();
			using InteropHelp.UTF8StringHandle pTagName2 = new InteropHelp.UTF8StringHandle(pTagName);
			return NativeMethods.ISteamUGC_AddExcludedTag(handle, pTagName2);
		}

		public static bool SetReturnKeyValueTags(UGCQueryHandle_t handle, bool bReturnKeyValueTags)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamUGC_SetReturnKeyValueTags(handle, bReturnKeyValueTags);
		}

		public static bool SetReturnLongDescription(UGCQueryHandle_t handle, bool bReturnLongDescription)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamUGC_SetReturnLongDescription(handle, bReturnLongDescription);
		}

		public static bool SetReturnMetadata(UGCQueryHandle_t handle, bool bReturnMetadata)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamUGC_SetReturnMetadata(handle, bReturnMetadata);
		}

		public static bool SetReturnChildren(UGCQueryHandle_t handle, bool bReturnChildren)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamUGC_SetReturnChildren(handle, bReturnChildren);
		}

		public static bool SetReturnAdditionalPreviews(UGCQueryHandle_t handle, bool bReturnAdditionalPreviews)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamUGC_SetReturnAdditionalPreviews(handle, bReturnAdditionalPreviews);
		}

		public static bool SetReturnTotalOnly(UGCQueryHandle_t handle, bool bReturnTotalOnly)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamUGC_SetReturnTotalOnly(handle, bReturnTotalOnly);
		}

		public static bool SetLanguage(UGCQueryHandle_t handle, string pchLanguage)
		{
			InteropHelp.TestIfAvailableClient();
			using InteropHelp.UTF8StringHandle pchLanguage2 = new InteropHelp.UTF8StringHandle(pchLanguage);
			return NativeMethods.ISteamUGC_SetLanguage(handle, pchLanguage2);
		}

		public static bool SetAllowCachedResponse(UGCQueryHandle_t handle, uint unMaxAgeSeconds)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamUGC_SetAllowCachedResponse(handle, unMaxAgeSeconds);
		}

		public static bool SetCloudFileNameFilter(UGCQueryHandle_t handle, string pMatchCloudFileName)
		{
			InteropHelp.TestIfAvailableClient();
			using InteropHelp.UTF8StringHandle pMatchCloudFileName2 = new InteropHelp.UTF8StringHandle(pMatchCloudFileName);
			return NativeMethods.ISteamUGC_SetCloudFileNameFilter(handle, pMatchCloudFileName2);
		}

		public static bool SetMatchAnyTag(UGCQueryHandle_t handle, bool bMatchAnyTag)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamUGC_SetMatchAnyTag(handle, bMatchAnyTag);
		}

		public static bool SetSearchText(UGCQueryHandle_t handle, string pSearchText)
		{
			InteropHelp.TestIfAvailableClient();
			using InteropHelp.UTF8StringHandle pSearchText2 = new InteropHelp.UTF8StringHandle(pSearchText);
			return NativeMethods.ISteamUGC_SetSearchText(handle, pSearchText2);
		}

		public static bool SetRankedByTrendDays(UGCQueryHandle_t handle, uint unDays)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamUGC_SetRankedByTrendDays(handle, unDays);
		}

		public static bool AddRequiredKeyValueTag(UGCQueryHandle_t handle, string pKey, string pValue)
		{
			InteropHelp.TestIfAvailableClient();
			using InteropHelp.UTF8StringHandle pKey2 = new InteropHelp.UTF8StringHandle(pKey);
			using InteropHelp.UTF8StringHandle pValue2 = new InteropHelp.UTF8StringHandle(pValue);
			return NativeMethods.ISteamUGC_AddRequiredKeyValueTag(handle, pKey2, pValue2);
		}

		public static SteamAPICall_t RequestUGCDetails(PublishedFileId_t nPublishedFileID, uint unMaxAgeSeconds)
		{
			InteropHelp.TestIfAvailableClient();
			return (SteamAPICall_t)NativeMethods.ISteamUGC_RequestUGCDetails(nPublishedFileID, unMaxAgeSeconds);
		}

		public static SteamAPICall_t CreateItem(AppId_t nConsumerAppId, EWorkshopFileType eFileType)
		{
			InteropHelp.TestIfAvailableClient();
			return (SteamAPICall_t)NativeMethods.ISteamUGC_CreateItem(nConsumerAppId, eFileType);
		}

		public static UGCUpdateHandle_t StartItemUpdate(AppId_t nConsumerAppId, PublishedFileId_t nPublishedFileID)
		{
			InteropHelp.TestIfAvailableClient();
			return (UGCUpdateHandle_t)NativeMethods.ISteamUGC_StartItemUpdate(nConsumerAppId, nPublishedFileID);
		}

		public static bool SetItemTitle(UGCUpdateHandle_t handle, string pchTitle)
		{
			InteropHelp.TestIfAvailableClient();
			using InteropHelp.UTF8StringHandle pchTitle2 = new InteropHelp.UTF8StringHandle(pchTitle);
			return NativeMethods.ISteamUGC_SetItemTitle(handle, pchTitle2);
		}

		public static bool SetItemDescription(UGCUpdateHandle_t handle, string pchDescription)
		{
			InteropHelp.TestIfAvailableClient();
			using InteropHelp.UTF8StringHandle pchDescription2 = new InteropHelp.UTF8StringHandle(pchDescription);
			return NativeMethods.ISteamUGC_SetItemDescription(handle, pchDescription2);
		}

		public static bool SetItemUpdateLanguage(UGCUpdateHandle_t handle, string pchLanguage)
		{
			InteropHelp.TestIfAvailableClient();
			using InteropHelp.UTF8StringHandle pchLanguage2 = new InteropHelp.UTF8StringHandle(pchLanguage);
			return NativeMethods.ISteamUGC_SetItemUpdateLanguage(handle, pchLanguage2);
		}

		public static bool SetItemMetadata(UGCUpdateHandle_t handle, string pchMetaData)
		{
			InteropHelp.TestIfAvailableClient();
			using InteropHelp.UTF8StringHandle pchMetaData2 = new InteropHelp.UTF8StringHandle(pchMetaData);
			return NativeMethods.ISteamUGC_SetItemMetadata(handle, pchMetaData2);
		}

		public static bool SetItemVisibility(UGCUpdateHandle_t handle, ERemoteStoragePublishedFileVisibility eVisibility)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamUGC_SetItemVisibility(handle, eVisibility);
		}

		public static bool SetItemTags(UGCUpdateHandle_t updateHandle, IList<string> pTags)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamUGC_SetItemTags(updateHandle, new InteropHelp.SteamParamStringArray(pTags));
		}

		public static bool SetItemContent(UGCUpdateHandle_t handle, string pszContentFolder)
		{
			InteropHelp.TestIfAvailableClient();
			using InteropHelp.UTF8StringHandle pszContentFolder2 = new InteropHelp.UTF8StringHandle(pszContentFolder);
			return NativeMethods.ISteamUGC_SetItemContent(handle, pszContentFolder2);
		}

		public static bool SetItemPreview(UGCUpdateHandle_t handle, string pszPreviewFile)
		{
			InteropHelp.TestIfAvailableClient();
			using InteropHelp.UTF8StringHandle pszPreviewFile2 = new InteropHelp.UTF8StringHandle(pszPreviewFile);
			return NativeMethods.ISteamUGC_SetItemPreview(handle, pszPreviewFile2);
		}

		public static bool RemoveItemKeyValueTags(UGCUpdateHandle_t handle, string pchKey)
		{
			InteropHelp.TestIfAvailableClient();
			using InteropHelp.UTF8StringHandle pchKey2 = new InteropHelp.UTF8StringHandle(pchKey);
			return NativeMethods.ISteamUGC_RemoveItemKeyValueTags(handle, pchKey2);
		}

		public static bool AddItemKeyValueTag(UGCUpdateHandle_t handle, string pchKey, string pchValue)
		{
			InteropHelp.TestIfAvailableClient();
			using InteropHelp.UTF8StringHandle pchKey2 = new InteropHelp.UTF8StringHandle(pchKey);
			using InteropHelp.UTF8StringHandle pchValue2 = new InteropHelp.UTF8StringHandle(pchValue);
			return NativeMethods.ISteamUGC_AddItemKeyValueTag(handle, pchKey2, pchValue2);
		}

		public static SteamAPICall_t SubmitItemUpdate(UGCUpdateHandle_t handle, string pchChangeNote)
		{
			InteropHelp.TestIfAvailableClient();
			using InteropHelp.UTF8StringHandle pchChangeNote2 = new InteropHelp.UTF8StringHandle(pchChangeNote);
			return (SteamAPICall_t)NativeMethods.ISteamUGC_SubmitItemUpdate(handle, pchChangeNote2);
		}

		public static EItemUpdateStatus GetItemUpdateProgress(UGCUpdateHandle_t handle, out ulong punBytesProcessed, out ulong punBytesTotal)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamUGC_GetItemUpdateProgress(handle, out punBytesProcessed, out punBytesTotal);
		}

		public static SteamAPICall_t SetUserItemVote(PublishedFileId_t nPublishedFileID, bool bVoteUp)
		{
			InteropHelp.TestIfAvailableClient();
			return (SteamAPICall_t)NativeMethods.ISteamUGC_SetUserItemVote(nPublishedFileID, bVoteUp);
		}

		public static SteamAPICall_t GetUserItemVote(PublishedFileId_t nPublishedFileID)
		{
			InteropHelp.TestIfAvailableClient();
			return (SteamAPICall_t)NativeMethods.ISteamUGC_GetUserItemVote(nPublishedFileID);
		}

		public static SteamAPICall_t AddItemToFavorites(AppId_t nAppId, PublishedFileId_t nPublishedFileID)
		{
			InteropHelp.TestIfAvailableClient();
			return (SteamAPICall_t)NativeMethods.ISteamUGC_AddItemToFavorites(nAppId, nPublishedFileID);
		}

		public static SteamAPICall_t RemoveItemFromFavorites(AppId_t nAppId, PublishedFileId_t nPublishedFileID)
		{
			InteropHelp.TestIfAvailableClient();
			return (SteamAPICall_t)NativeMethods.ISteamUGC_RemoveItemFromFavorites(nAppId, nPublishedFileID);
		}

		public static SteamAPICall_t SubscribeItem(PublishedFileId_t nPublishedFileID)
		{
			InteropHelp.TestIfAvailableClient();
			return (SteamAPICall_t)NativeMethods.ISteamUGC_SubscribeItem(nPublishedFileID);
		}

		public static SteamAPICall_t UnsubscribeItem(PublishedFileId_t nPublishedFileID)
		{
			InteropHelp.TestIfAvailableClient();
			return (SteamAPICall_t)NativeMethods.ISteamUGC_UnsubscribeItem(nPublishedFileID);
		}

		public static uint GetNumSubscribedItems()
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamUGC_GetNumSubscribedItems();
		}

		public static uint GetSubscribedItems(PublishedFileId_t[] pvecPublishedFileID, uint cMaxEntries)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamUGC_GetSubscribedItems(pvecPublishedFileID, cMaxEntries);
		}

		public static uint GetItemState(PublishedFileId_t nPublishedFileID)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamUGC_GetItemState(nPublishedFileID);
		}

		public static bool GetItemInstallInfo(PublishedFileId_t nPublishedFileID, out ulong punSizeOnDisk, out string pchFolder, uint cchFolderSize, out uint punTimeStamp)
		{
			InteropHelp.TestIfAvailableClient();
			IntPtr intPtr = Marshal.AllocHGlobal((int)cchFolderSize);
			bool flag = NativeMethods.ISteamUGC_GetItemInstallInfo(nPublishedFileID, out punSizeOnDisk, intPtr, cchFolderSize, out punTimeStamp);
			pchFolder = (flag ? InteropHelp.PtrToStringUTF8(intPtr) : null);
			Marshal.FreeHGlobal(intPtr);
			return flag;
		}

		public static bool GetItemDownloadInfo(PublishedFileId_t nPublishedFileID, out ulong punBytesDownloaded, out ulong punBytesTotal)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamUGC_GetItemDownloadInfo(nPublishedFileID, out punBytesDownloaded, out punBytesTotal);
		}

		public static bool DownloadItem(PublishedFileId_t nPublishedFileID, bool bHighPriority)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamUGC_DownloadItem(nPublishedFileID, bHighPriority);
		}
	}
	public static class SteamUnifiedMessages
	{
		public static ClientUnifiedMessageHandle SendMethod(string pchServiceMethod, byte[] pRequestBuffer, uint unRequestBufferSize, ulong unContext)
		{
			InteropHelp.TestIfAvailableClient();
			using InteropHelp.UTF8StringHandle pchServiceMethod2 = new InteropHelp.UTF8StringHandle(pchServiceMethod);
			return (ClientUnifiedMessageHandle)NativeMethods.ISteamUnifiedMessages_SendMethod(pchServiceMethod2, pRequestBuffer, unRequestBufferSize, unContext);
		}

		public static bool GetMethodResponseInfo(ClientUnifiedMessageHandle hHandle, out uint punResponseSize, out EResult peResult)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamUnifiedMessages_GetMethodResponseInfo(hHandle, out punResponseSize, out peResult);
		}

		public static bool GetMethodResponseData(ClientUnifiedMessageHandle hHandle, byte[] pResponseBuffer, uint unResponseBufferSize, bool bAutoRelease)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamUnifiedMessages_GetMethodResponseData(hHandle, pResponseBuffer, unResponseBufferSize, bAutoRelease);
		}

		public static bool ReleaseMethod(ClientUnifiedMessageHandle hHandle)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamUnifiedMessages_ReleaseMethod(hHandle);
		}

		public static bool SendNotification(string pchServiceNotification, byte[] pNotificationBuffer, uint unNotificationBufferSize)
		{
			InteropHelp.TestIfAvailableClient();
			using InteropHelp.UTF8StringHandle pchServiceNotification2 = new InteropHelp.UTF8StringHandle(pchServiceNotification);
			return NativeMethods.ISteamUnifiedMessages_SendNotification(pchServiceNotification2, pNotificationBuffer, unNotificationBufferSize);
		}
	}
	public static class SteamUser
	{
		public static HSteamUser GetHSteamUser()
		{
			InteropHelp.TestIfAvailableClient();
			return (HSteamUser)NativeMethods.ISteamUser_GetHSteamUser();
		}

		public static bool BLoggedOn()
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamUser_BLoggedOn();
		}

		public static CSteamID GetSteamID()
		{
			InteropHelp.TestIfAvailableClient();
			return (CSteamID)NativeMethods.ISteamUser_GetSteamID();
		}

		public static int InitiateGameConnection(byte[] pAuthBlob, int cbMaxAuthBlob, CSteamID steamIDGameServer, uint unIPServer, ushort usPortServer, bool bSecure)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamUser_InitiateGameConnection(pAuthBlob, cbMaxAuthBlob, steamIDGameServer, unIPServer, usPortServer, bSecure);
		}

		public static void TerminateGameConnection(uint unIPServer, ushort usPortServer)
		{
			InteropHelp.TestIfAvailableClient();
			NativeMethods.ISteamUser_TerminateGameConnection(unIPServer, usPortServer);
		}

		public static void TrackAppUsageEvent(CGameID gameID, int eAppUsageEvent, string pchExtraInfo = "")
		{
			InteropHelp.TestIfAvailableClient();
			using InteropHelp.UTF8StringHandle pchExtraInfo2 = new InteropHelp.UTF8StringHandle(pchExtraInfo);
			NativeMethods.ISteamUser_TrackAppUsageEvent(gameID, eAppUsageEvent, pchExtraInfo2);
		}

		public static bool GetUserDataFolder(out string pchBuffer, int cubBuffer)
		{
			InteropHelp.TestIfAvailableClient();
			IntPtr intPtr = Marshal.AllocHGlobal(cubBuffer);
			bool flag = NativeMethods.ISteamUser_GetUserDataFolder(intPtr, cubBuffer);
			pchBuffer = (flag ? InteropHelp.PtrToStringUTF8(intPtr) : null);
			Marshal.FreeHGlobal(intPtr);
			return flag;
		}

		public static void StartVoiceRecording()
		{
			InteropHelp.TestIfAvailableClient();
			NativeMethods.ISteamUser_StartVoiceRecording();
		}

		public static void StopVoiceRecording()
		{
			InteropHelp.TestIfAvailableClient();
			NativeMethods.ISteamUser_StopVoiceRecording();
		}

		public static EVoiceResult GetAvailableVoice(out uint pcbCompressed, out uint pcbUncompressed, uint nUncompressedVoiceDesiredSampleRate)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamUser_GetAvailableVoice(out pcbCompressed, out pcbUncompressed, nUncompressedVoiceDesiredSampleRate);
		}

		public static EVoiceResult GetVoice(bool bWantCompressed, byte[] pDestBuffer, uint cbDestBufferSize, out uint nBytesWritten, bool bWantUncompressed, byte[] pUncompressedDestBuffer, uint cbUncompressedDestBufferSize, out uint nUncompressBytesWritten, uint nUncompressedVoiceDesiredSampleRate)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamUser_GetVoice(bWantCompressed, pDestBuffer, cbDestBufferSize, out nBytesWritten, bWantUncompressed, pUncompressedDestBuffer, cbUncompressedDestBufferSize, out nUncompressBytesWritten, nUncompressedVoiceDesiredSampleRate);
		}

		public static EVoiceResult DecompressVoice(byte[] pCompressed, uint cbCompressed, byte[] pDestBuffer, uint cbDestBufferSize, out uint nBytesWritten, uint nDesiredSampleRate)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamUser_DecompressVoice(pCompressed, cbCompressed, pDestBuffer, cbDestBufferSize, out nBytesWritten, nDesiredSampleRate);
		}

		public static uint GetVoiceOptimalSampleRate()
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamUser_GetVoiceOptimalSampleRate();
		}

		public static HAuthTicket GetAuthSessionTicket(byte[] pTicket, int cbMaxTicket, out uint pcbTicket)
		{
			InteropHelp.TestIfAvailableClient();
			return (HAuthTicket)NativeMethods.ISteamUser_GetAuthSessionTicket(pTicket, cbMaxTicket, out pcbTicket);
		}

		public static EBeginAuthSessionResult BeginAuthSession(byte[] pAuthTicket, int cbAuthTicket, CSteamID steamID)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamUser_BeginAuthSession(pAuthTicket, cbAuthTicket, steamID);
		}

		public static void EndAuthSession(CSteamID steamID)
		{
			InteropHelp.TestIfAvailableClient();
			NativeMethods.ISteamUser_EndAuthSession(steamID);
		}

		public static void CancelAuthTicket(HAuthTicket hAuthTicket)
		{
			InteropHelp.TestIfAvailableClient();
			NativeMethods.ISteamUser_CancelAuthTicket(hAuthTicket);
		}

		public static EUserHasLicenseForAppResult UserHasLicenseForApp(CSteamID steamID, AppId_t appID)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamUser_UserHasLicenseForApp(steamID, appID);
		}

		public static bool BIsBehindNAT()
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamUser_BIsBehindNAT();
		}

		public static void AdvertiseGame(CSteamID steamIDGameServer, uint unIPServer, ushort usPortServer)
		{
			InteropHelp.TestIfAvailableClient();
			NativeMethods.ISteamUser_AdvertiseGame(steamIDGameServer, unIPServer, usPortServer);
		}

		public static SteamAPICall_t RequestEncryptedAppTicket(byte[] pDataToInclude, int cbDataToInclude)
		{
			InteropHelp.TestIfAvailableClient();
			return (SteamAPICall_t)NativeMethods.ISteamUser_RequestEncryptedAppTicket(pDataToInclude, cbDataToInclude);
		}

		public static bool GetEncryptedAppTicket(byte[] pTicket, int cbMaxTicket, out uint pcbTicket)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamUser_GetEncryptedAppTicket(pTicket, cbMaxTicket, out pcbTicket);
		}

		public static int GetGameBadgeLevel(int nSeries, bool bFoil)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamUser_GetGameBadgeLevel(nSeries, bFoil);
		}

		public static int GetPlayerSteamLevel()
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamUser_GetPlayerSteamLevel();
		}

		public static SteamAPICall_t RequestStoreAuthURL(string pchRedirectURL)
		{
			InteropHelp.TestIfAvailableClient();
			using InteropHelp.UTF8StringHandle pchRedirectURL2 = new InteropHelp.UTF8StringHandle(pchRedirectURL);
			return (SteamAPICall_t)NativeMethods.ISteamUser_RequestStoreAuthURL(pchRedirectURL2);
		}
	}
	public static class SteamUserStats
	{
		public static bool RequestCurrentStats()
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamUserStats_RequestCurrentStats();
		}

		public static bool GetStat(string pchName, out int pData)
		{
			InteropHelp.TestIfAvailableClient();
			using InteropHelp.UTF8StringHandle pchName2 = new InteropHelp.UTF8StringHandle(pchName);
			return NativeMethods.ISteamUserStats_GetStat(pchName2, out pData);
		}

		public static bool GetStat(string pchName, out float pData)
		{
			InteropHelp.TestIfAvailableClient();
			using InteropHelp.UTF8StringHandle pchName2 = new InteropHelp.UTF8StringHandle(pchName);
			return NativeMethods.ISteamUserStats_GetStat_(pchName2, out pData);
		}

		public static bool SetStat(string pchName, int nData)
		{
			InteropHelp.TestIfAvailableClient();
			using InteropHelp.UTF8StringHandle pchName2 = new InteropHelp.UTF8StringHandle(pchName);
			return NativeMethods.ISteamUserStats_SetStat(pchName2, nData);
		}

		public static bool SetStat(string pchName, float fData)
		{
			InteropHelp.TestIfAvailableClient();
			using InteropHelp.UTF8StringHandle pchName2 = new InteropHelp.UTF8StringHandle(pchName);
			return NativeMethods.ISteamUserStats_SetStat_(pchName2, fData);
		}

		public static bool UpdateAvgRateStat(string pchName, float flCountThisSession, double dSessionLength)
		{
			InteropHelp.TestIfAvailableClient();
			using InteropHelp.UTF8StringHandle pchName2 = new InteropHelp.UTF8StringHandle(pchName);
			return NativeMethods.ISteamUserStats_UpdateAvgRateStat(pchName2, flCountThisSession, dSessionLength);
		}

		public static bool GetAchievement(string pchName, out bool pbAchieved)
		{
			InteropHelp.TestIfAvailableClient();
			using InteropHelp.UTF8StringHandle pchName2 = new InteropHelp.UTF8StringHandle(pchName);
			return NativeMethods.ISteamUserStats_GetAchievement(pchName2, out pbAchieved);
		}

		public static bool SetAchievement(string pchName)
		{
			InteropHelp.TestIfAvailableClient();
			using InteropHelp.UTF8StringHandle pchName2 = new InteropHelp.UTF8StringHandle(pchName);
			return NativeMethods.ISteamUserStats_SetAchievement(pchName2);
		}

		public static bool ClearAchievement(string pchName)
		{
			InteropHelp.TestIfAvailableClient();
			using InteropHelp.UTF8StringHandle pchName2 = new InteropHelp.UTF8StringHandle(pchName);
			return NativeMethods.ISteamUserStats_ClearAchievement(pchName2);
		}

		public static bool GetAchievementAndUnlockTime(string pchName, out bool pbAchieved, out uint punUnlockTime)
		{
			InteropHelp.TestIfAvailableClient();
			using InteropHelp.UTF8StringHandle pchName2 = new InteropHelp.UTF8StringHandle(pchName);
			return NativeMethods.ISteamUserStats_GetAchievementAndUnlockTime(pchName2, out pbAchieved, out punUnlockTime);
		}

		public static bool StoreStats()
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamUserStats_StoreStats();
		}

		public static int GetAchievementIcon(string pchName)
		{
			InteropHelp.TestIfAvailableClient();
			using InteropHelp.UTF8StringHandle pchName2 = new InteropHelp.UTF8StringHandle(pchName);
			return NativeMethods.ISteamUserStats_GetAchievementIcon(pchName2);
		}

		public static string GetAchievementDisplayAttribute(string pchName, string pchKey)
		{
			InteropHelp.TestIfAvailableClient();
			using InteropHelp.UTF8StringHandle pchName2 = new InteropHelp.UTF8StringHandle(pchName);
			using InteropHelp.UTF8StringHandle pchKey2 = new InteropHelp.UTF8StringHandle(pchKey);
			return InteropHelp.PtrToStringUTF8(NativeMethods.ISteamUserStats_GetAchievementDisplayAttribute(pchName2, pchKey2));
		}

		public static bool IndicateAchievementProgress(string pchName, uint nCurProgress, uint nMaxProgress)
		{
			InteropHelp.TestIfAvailableClient();
			using InteropHelp.UTF8StringHandle pchName2 = new InteropHelp.UTF8StringHandle(pchName);
			return NativeMethods.ISteamUserStats_IndicateAchievementProgress(pchName2, nCurProgress, nMaxProgress);
		}

		public static uint GetNumAchievements()
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamUserStats_GetNumAchievements();
		}

		public static string GetAchievementName(uint iAchievement)
		{
			InteropHelp.TestIfAvailableClient();
			return InteropHelp.PtrToStringUTF8(NativeMethods.ISteamUserStats_GetAchievementName(iAchievement));
		}

		public static SteamAPICall_t RequestUserStats(CSteamID steamIDUser)
		{
			InteropHelp.TestIfAvailableClient();
			return (SteamAPICall_t)NativeMethods.ISteamUserStats_RequestUserStats(steamIDUser);
		}

		public static bool GetUserStat(CSteamID steamIDUser, string pchName, out int pData)
		{
			InteropHelp.TestIfAvailableClient();
			using InteropHelp.UTF8StringHandle pchName2 = new InteropHelp.UTF8StringHandle(pchName);
			return NativeMethods.ISteamUserStats_GetUserStat(steamIDUser, pchName2, out pData);
		}

		public static bool GetUserStat(CSteamID steamIDUser, string pchName, out float pData)
		{
			InteropHelp.TestIfAvailableClient();
			using InteropHelp.UTF8StringHandle pchName2 = new InteropHelp.UTF8StringHandle(pchName);
			return NativeMethods.ISteamUserStats_GetUserStat_(steamIDUser, pchName2, out pData);
		}

		public static bool GetUserAchievement(CSteamID steamIDUser, string pchName, out bool pbAchieved)
		{
			InteropHelp.TestIfAvailableClient();
			using InteropHelp.UTF8StringHandle pchName2 = new InteropHelp.UTF8StringHandle(pchName);
			return NativeMethods.ISteamUserStats_GetUserAchievement(steamIDUser, pchName2, out pbAchieved);
		}

		public static bool GetUserAchievementAndUnlockTime(CSteamID steamIDUser, string pchName, out bool pbAchieved, out uint punUnlockTime)
		{
			InteropHelp.TestIfAvailableClient();
			using InteropHelp.UTF8StringHandle pchName2 = new InteropHelp.UTF8StringHandle(pchName);
			return NativeMethods.ISteamUserStats_GetUserAchievementAndUnlockTime(steamIDUser, pchName2, out pbAchieved, out punUnlockTime);
		}

		public static bool ResetAllStats(bool bAchievementsToo)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamUserStats_ResetAllStats(bAchievementsToo);
		}

		public static SteamAPICall_t FindOrCreateLeaderboard(string pchLeaderboardName, ELeaderboardSortMethod eLeaderboardSortMethod, ELeaderboardDisplayType eLeaderboardDisplayType)
		{
			InteropHelp.TestIfAvailableClient();
			using InteropHelp.UTF8StringHandle pchLeaderboardName2 = new InteropHelp.UTF8StringHandle(pchLeaderboardName);
			return (SteamAPICall_t)NativeMethods.ISteamUserStats_FindOrCreateLeaderboard(pchLeaderboardName2, eLeaderboardSortMethod, eLeaderboardDisplayType);
		}

		public static SteamAPICall_t FindLeaderboard(string pchLeaderboardName)
		{
			InteropHelp.TestIfAvailableClient();
			using InteropHelp.UTF8StringHandle pchLeaderboardName2 = new InteropHelp.UTF8StringHandle(pchLeaderboardName);
			return (SteamAPICall_t)NativeMethods.ISteamUserStats_FindLeaderboard(pchLeaderboardName2);
		}

		public static string GetLeaderboardName(SteamLeaderboard_t hSteamLeaderboard)
		{
			InteropHelp.TestIfAvailableClient();
			return InteropHelp.PtrToStringUTF8(NativeMethods.ISteamUserStats_GetLeaderboardName(hSteamLeaderboard));
		}

		public static int GetLeaderboardEntryCount(SteamLeaderboard_t hSteamLeaderboard)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamUserStats_GetLeaderboardEntryCount(hSteamLeaderboard);
		}

		public static ELeaderboardSortMethod GetLeaderboardSortMethod(SteamLeaderboard_t hSteamLeaderboard)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamUserStats_GetLeaderboardSortMethod(hSteamLeaderboard);
		}

		public static ELeaderboardDisplayType GetLeaderboardDisplayType(SteamLeaderboard_t hSteamLeaderboard)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamUserStats_GetLeaderboardDisplayType(hSteamLeaderboard);
		}

		public static SteamAPICall_t DownloadLeaderboardEntries(SteamLeaderboard_t hSteamLeaderboard, ELeaderboardDataRequest eLeaderboardDataRequest, int nRangeStart, int nRangeEnd)
		{
			InteropHelp.TestIfAvailableClient();
			return (SteamAPICall_t)NativeMethods.ISteamUserStats_DownloadLeaderboardEntries(hSteamLeaderboard, eLeaderboardDataRequest, nRangeStart, nRangeEnd);
		}

		public static SteamAPICall_t DownloadLeaderboardEntriesForUsers(SteamLeaderboard_t hSteamLeaderboard, CSteamID[] prgUsers, int cUsers)
		{
			InteropHelp.TestIfAvailableClient();
			return (SteamAPICall_t)NativeMethods.ISteamUserStats_DownloadLeaderboardEntriesForUsers(hSteamLeaderboard, prgUsers, cUsers);
		}

		public static bool GetDownloadedLeaderboardEntry(SteamLeaderboardEntries_t hSteamLeaderboardEntries, int index, out LeaderboardEntry_t pLeaderboardEntry, int[] pDetails, int cDetailsMax)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamUserStats_GetDownloadedLeaderboardEntry(hSteamLeaderboardEntries, index, out pLeaderboardEntry, pDetails, cDetailsMax);
		}

		public static SteamAPICall_t UploadLeaderboardScore(SteamLeaderboard_t hSteamLeaderboard, ELeaderboardUploadScoreMethod eLeaderboardUploadScoreMethod, int nScore, int[] pScoreDetails, int cScoreDetailsCount)
		{
			InteropHelp.TestIfAvailableClient();
			return (SteamAPICall_t)NativeMethods.ISteamUserStats_UploadLeaderboardScore(hSteamLeaderboard, eLeaderboardUploadScoreMethod, nScore, pScoreDetails, cScoreDetailsCount);
		}

		public static SteamAPICall_t AttachLeaderboardUGC(SteamLeaderboard_t hSteamLeaderboard, UGCHandle_t hUGC)
		{
			InteropHelp.TestIfAvailableClient();
			return (SteamAPICall_t)NativeMethods.ISteamUserStats_AttachLeaderboardUGC(hSteamLeaderboard, hUGC);
		}

		public static SteamAPICall_t GetNumberOfCurrentPlayers()
		{
			InteropHelp.TestIfAvailableClient();
			return (SteamAPICall_t)NativeMethods.ISteamUserStats_GetNumberOfCurrentPlayers();
		}

		public static SteamAPICall_t RequestGlobalAchievementPercentages()
		{
			InteropHelp.TestIfAvailableClient();
			return (SteamAPICall_t)NativeMethods.ISteamUserStats_RequestGlobalAchievementPercentages();
		}

		public static int GetMostAchievedAchievementInfo(out string pchName, uint unNameBufLen, out float pflPercent, out bool pbAchieved)
		{
			InteropHelp.TestIfAvailableClient();
			IntPtr intPtr = Marshal.AllocHGlobal((int)unNameBufLen);
			int num = NativeMethods.ISteamUserStats_GetMostAchievedAchievementInfo(intPtr, unNameBufLen, out pflPercent, out pbAchieved);
			pchName = ((num != -1) ? InteropHelp.PtrToStringUTF8(intPtr) : null);
			Marshal.FreeHGlobal(intPtr);
			return num;
		}

		public static int GetNextMostAchievedAchievementInfo(int iIteratorPrevious, out string pchName, uint unNameBufLen, out float pflPercent, out bool pbAchieved)
		{
			InteropHelp.TestIfAvailableClient();
			IntPtr intPtr = Marshal.AllocHGlobal((int)unNameBufLen);
			int num = NativeMethods.ISteamUserStats_GetNextMostAchievedAchievementInfo(iIteratorPrevious, intPtr, unNameBufLen, out pflPercent, out pbAchieved);
			pchName = ((num != -1) ? InteropHelp.PtrToStringUTF8(intPtr) : null);
			Marshal.FreeHGlobal(intPtr);
			return num;
		}

		public static bool GetAchievementAchievedPercent(string pchName, out float pflPercent)
		{
			InteropHelp.TestIfAvailableClient();
			using InteropHelp.UTF8StringHandle pchName2 = new InteropHelp.UTF8StringHandle(pchName);
			return NativeMethods.ISteamUserStats_GetAchievementAchievedPercent(pchName2, out pflPercent);
		}

		public static SteamAPICall_t RequestGlobalStats(int nHistoryDays)
		{
			InteropHelp.TestIfAvailableClient();
			return (SteamAPICall_t)NativeMethods.ISteamUserStats_RequestGlobalStats(nHistoryDays);
		}

		public static bool GetGlobalStat(string pchStatName, out long pData)
		{
			InteropHelp.TestIfAvailableClient();
			using InteropHelp.UTF8StringHandle pchStatName2 = new InteropHelp.UTF8StringHandle(pchStatName);
			return NativeMethods.ISteamUserStats_GetGlobalStat(pchStatName2, out pData);
		}

		public static bool GetGlobalStat(string pchStatName, out double pData)
		{
			InteropHelp.TestIfAvailableClient();
			using InteropHelp.UTF8StringHandle pchStatName2 = new InteropHelp.UTF8StringHandle(pchStatName);
			return NativeMethods.ISteamUserStats_GetGlobalStat_(pchStatName2, out pData);
		}

		public static int GetGlobalStatHistory(string pchStatName, long[] pData, uint cubData)
		{
			InteropHelp.TestIfAvailableClient();
			using InteropHelp.UTF8StringHandle pchStatName2 = new InteropHelp.UTF8StringHandle(pchStatName);
			return NativeMethods.ISteamUserStats_GetGlobalStatHistory(pchStatName2, pData, cubData);
		}

		public static int GetGlobalStatHistory(string pchStatName, double[] pData, uint cubData)
		{
			InteropHelp.TestIfAvailableClient();
			using InteropHelp.UTF8StringHandle pchStatName2 = new InteropHelp.UTF8StringHandle(pchStatName);
			return NativeMethods.ISteamUserStats_GetGlobalStatHistory_(pchStatName2, pData, cubData);
		}
	}
	public static class SteamUtils
	{
		public static uint GetSecondsSinceAppActive()
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamUtils_GetSecondsSinceAppActive();
		}

		public static uint GetSecondsSinceComputerActive()
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamUtils_GetSecondsSinceComputerActive();
		}

		public static EUniverse GetConnectedUniverse()
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamUtils_GetConnectedUniverse();
		}

		public static uint GetServerRealTime()
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamUtils_GetServerRealTime();
		}

		public static string GetIPCountry()
		{
			InteropHelp.TestIfAvailableClient();
			return InteropHelp.PtrToStringUTF8(NativeMethods.ISteamUtils_GetIPCountry());
		}

		public static bool GetImageSize(int iImage, out uint pnWidth, out uint pnHeight)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamUtils_GetImageSize(iImage, out pnWidth, out pnHeight);
		}

		public static bool GetImageRGBA(int iImage, byte[] pubDest, int nDestBufferSize)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamUtils_GetImageRGBA(iImage, pubDest, nDestBufferSize);
		}

		public static bool GetCSERIPPort(out uint unIP, out ushort usPort)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamUtils_GetCSERIPPort(out unIP, out usPort);
		}

		public static byte GetCurrentBatteryPower()
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamUtils_GetCurrentBatteryPower();
		}

		public static AppId_t GetAppID()
		{
			InteropHelp.TestIfAvailableClient();
			return (AppId_t)NativeMethods.ISteamUtils_GetAppID();
		}

		public static void SetOverlayNotificationPosition(ENotificationPosition eNotificationPosition)
		{
			InteropHelp.TestIfAvailableClient();
			NativeMethods.ISteamUtils_SetOverlayNotificationPosition(eNotificationPosition);
		}

		public static bool IsAPICallCompleted(SteamAPICall_t hSteamAPICall, out bool pbFailed)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamUtils_IsAPICallCompleted(hSteamAPICall, out pbFailed);
		}

		public static ESteamAPICallFailure GetAPICallFailureReason(SteamAPICall_t hSteamAPICall)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamUtils_GetAPICallFailureReason(hSteamAPICall);
		}

		public static bool GetAPICallResult(SteamAPICall_t hSteamAPICall, IntPtr pCallback, int cubCallback, int iCallbackExpected, out bool pbFailed)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamUtils_GetAPICallResult(hSteamAPICall, pCallback, cubCallback, iCallbackExpected, out pbFailed);
		}

		public static void RunFrame()
		{
			InteropHelp.TestIfAvailableClient();
			NativeMethods.ISteamUtils_RunFrame();
		}

		public static uint GetIPCCallCount()
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamUtils_GetIPCCallCount();
		}

		public static void SetWarningMessageHook(SteamAPIWarningMessageHook_t pFunction)
		{
			InteropHelp.TestIfAvailableClient();
			NativeMethods.ISteamUtils_SetWarningMessageHook(pFunction);
		}

		public static bool IsOverlayEnabled()
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamUtils_IsOverlayEnabled();
		}

		public static bool BOverlayNeedsPresent()
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamUtils_BOverlayNeedsPresent();
		}

		public static SteamAPICall_t CheckFileSignature(string szFileName)
		{
			InteropHelp.TestIfAvailableClient();
			using InteropHelp.UTF8StringHandle szFileName2 = new InteropHelp.UTF8StringHandle(szFileName);
			return (SteamAPICall_t)NativeMethods.ISteamUtils_CheckFileSignature(szFileName2);
		}

		public static bool ShowGamepadTextInput(EGamepadTextInputMode eInputMode, EGamepadTextInputLineMode eLineInputMode, string pchDescription, uint unCharMax, string pchExistingText)
		{
			InteropHelp.TestIfAvailableClient();
			using InteropHelp.UTF8StringHandle pchDescription2 = new InteropHelp.UTF8StringHandle(pchDescription);
			using InteropHelp.UTF8StringHandle pchExistingText2 = new InteropHelp.UTF8StringHandle(pchExistingText);
			return NativeMethods.ISteamUtils_ShowGamepadTextInput(eInputMode, eLineInputMode, pchDescription2, unCharMax, pchExistingText2);
		}

		public static uint GetEnteredGamepadTextLength()
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamUtils_GetEnteredGamepadTextLength();
		}

		public static bool GetEnteredGamepadTextInput(out string pchText, uint cchText)
		{
			InteropHelp.TestIfAvailableClient();
			IntPtr intPtr = Marshal.AllocHGlobal((int)cchText);
			bool flag = NativeMethods.ISteamUtils_GetEnteredGamepadTextInput(intPtr, cchText);
			pchText = (flag ? InteropHelp.PtrToStringUTF8(intPtr) : null);
			Marshal.FreeHGlobal(intPtr);
			return flag;
		}

		public static string GetSteamUILanguage()
		{
			InteropHelp.TestIfAvailableClient();
			return InteropHelp.PtrToStringUTF8(NativeMethods.ISteamUtils_GetSteamUILanguage());
		}

		public static bool IsSteamRunningInVR()
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamUtils_IsSteamRunningInVR();
		}

		public static void SetOverlayNotificationInset(int nHorizontalInset, int nVerticalInset)
		{
			InteropHelp.TestIfAvailableClient();
			NativeMethods.ISteamUtils_SetOverlayNotificationInset(nHorizontalInset, nVerticalInset);
		}
	}
	public static class SteamVideo
	{
		public static void GetVideoURL(AppId_t unVideoAppID)
		{
			InteropHelp.TestIfAvailableClient();
			NativeMethods.ISteamVideo_GetVideoURL(unVideoAppID);
		}

		public static bool IsBroadcasting(out int pnNumViewers)
		{
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamVideo_IsBroadcasting(out pnNumViewers);
		}
	}
	internal static class NativeMethods
	{
		internal const string NativeLibraryName = "CSteamworks";

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl, EntryPoint = "Shutdown")]
		public static extern void SteamAPI_Shutdown();

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl, EntryPoint = "IsSteamRunning")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool SteamAPI_IsSteamRunning();

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl, EntryPoint = "RestartAppIfNecessary")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool SteamAPI_RestartAppIfNecessary(AppId_t unOwnAppID);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl, EntryPoint = "WriteMiniDump")]
		public static extern void SteamAPI_WriteMiniDump(uint uStructuredExceptionCode, IntPtr pvExceptionInfo, uint uBuildID);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SetMiniDumpComment")]
		public static extern void SteamAPI_SetMiniDumpComment(InteropHelp.UTF8StringHandle pchMsg);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamClient_")]
		public static extern IntPtr SteamClient();

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl, EntryPoint = "InitSafe")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool SteamAPI_InitSafe();

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl, EntryPoint = "RunCallbacks")]
		public static extern void SteamAPI_RunCallbacks();

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl, EntryPoint = "RegisterCallback")]
		public static extern void SteamAPI_RegisterCallback(IntPtr pCallback, int iCallback);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl, EntryPoint = "UnregisterCallback")]
		public static extern void SteamAPI_UnregisterCallback(IntPtr pCallback);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl, EntryPoint = "RegisterCallResult")]
		public static extern void SteamAPI_RegisterCallResult(IntPtr pCallback, ulong hAPICall);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl, EntryPoint = "UnregisterCallResult")]
		public static extern void SteamAPI_UnregisterCallResult(IntPtr pCallback, ulong hAPICall);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl, EntryPoint = "Steam_RunCallbacks_")]
		public static extern void Steam_RunCallbacks(HSteamPipe hSteamPipe, [MarshalAs(UnmanagedType.I1)] bool bGameServerCallbacks);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl, EntryPoint = "Steam_RegisterInterfaceFuncs_")]
		public static extern void Steam_RegisterInterfaceFuncs(IntPtr hModule);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl, EntryPoint = "Steam_GetHSteamUserCurrent_")]
		public static extern int Steam_GetHSteamUserCurrent();

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl, EntryPoint = "GetSteamInstallPath")]
		public static extern int SteamAPI_GetSteamInstallPath();

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl, EntryPoint = "GetHSteamPipe_")]
		public static extern int SteamAPI_GetHSteamPipe();

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SetTryCatchCallbacks")]
		public static extern void SteamAPI_SetTryCatchCallbacks([MarshalAs(UnmanagedType.I1)] bool bTryCatchCallbacks);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl, EntryPoint = "GetHSteamUser_")]
		public static extern int SteamAPI_GetHSteamUser();

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl, EntryPoint = "UseBreakpadCrashHandler")]
		public static extern void SteamAPI_UseBreakpadCrashHandler(InteropHelp.UTF8StringHandle pchVersion, InteropHelp.UTF8StringHandle pchDate, InteropHelp.UTF8StringHandle pchTime, [MarshalAs(UnmanagedType.I1)] bool bFullMemoryDumps, IntPtr pvContext, IntPtr m_pfnPreMinidumpCallback);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr SteamUser();

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr SteamFriends();

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr SteamUtils();

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr SteamMatchmaking();

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr SteamUserStats();

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr SteamApps();

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr SteamNetworking();

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr SteamMatchmakingServers();

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr SteamRemoteStorage();

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr SteamScreenshots();

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr SteamHTTP();

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr SteamUnifiedMessages();

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr SteamController();

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr SteamUGC();

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr SteamAppList();

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr SteamMusic();

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr SteamMusicRemote();

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr SteamHTMLSurface();

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr SteamInventory();

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr SteamVideo();

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl, EntryPoint = "GameServer_InitSafe")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool SteamGameServer_InitSafe(uint unIP, ushort usSteamPort, ushort usGamePort, ushort usQueryPort, EServerMode eServerMode, InteropHelp.UTF8StringHandle pchVersionString);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl, EntryPoint = "GameServer_Shutdown")]
		public static extern void SteamGameServer_Shutdown();

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl, EntryPoint = "GameServer_RunCallbacks")]
		public static extern void SteamGameServer_RunCallbacks();

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl, EntryPoint = "GameServer_BSecure")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool SteamGameServer_BSecure();

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl, EntryPoint = "GameServer_GetSteamID")]
		public static extern ulong SteamGameServer_GetSteamID();

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl, EntryPoint = "GameServer_GetHSteamPipe")]
		public static extern int SteamGameServer_GetHSteamPipe();

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl, EntryPoint = "GameServer_GetHSteamUser")]
		public static extern int SteamGameServer_GetHSteamUser();

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr SteamClientGameServer();

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr SteamGameServer();

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr SteamGameServerUtils();

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr SteamGameServerNetworking();

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr SteamGameServerStats();

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr SteamGameServerHTTP();

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr SteamGameServerInventory();

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr SteamGameServerUGC();

		[DllImport("sdkencryptedappticket", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamEncryptedAppTicket_BDecryptTicket")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool BDecryptTicket([In][Out] byte[] rgubTicketEncrypted, uint cubTicketEncrypted, [In][Out] byte[] rgubTicketDecrypted, ref uint pcubTicketDecrypted, [MarshalAs(UnmanagedType.LPArray, SizeConst = 32)] byte[] rgubKey, int cubKey);

		[DllImport("sdkencryptedappticket", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamEncryptedAppTicket_BIsTicketForApp")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool BIsTicketForApp([In][Out] byte[] rgubTicketDecrypted, uint cubTicketDecrypted, AppId_t nAppID);

		[DllImport("sdkencryptedappticket", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamEncryptedAppTicket_GetTicketIssueTime")]
		public static extern uint GetTicketIssueTime([In][Out] byte[] rgubTicketDecrypted, uint cubTicketDecrypted);

		[DllImport("sdkencryptedappticket", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamEncryptedAppTicket_GetTicketSteamID")]
		public static extern void GetTicketSteamID([In][Out] byte[] rgubTicketDecrypted, uint cubTicketDecrypted, out CSteamID psteamID);

		[DllImport("sdkencryptedappticket", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamEncryptedAppTicket_GetTicketAppID")]
		public static extern uint GetTicketAppID([In][Out] byte[] rgubTicketDecrypted, uint cubTicketDecrypted);

		[DllImport("sdkencryptedappticket", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamEncryptedAppTicket_BUserOwnsAppInTicket")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool BUserOwnsAppInTicket([In][Out] byte[] rgubTicketDecrypted, uint cubTicketDecrypted, AppId_t nAppID);

		[DllImport("sdkencryptedappticket", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamEncryptedAppTicket_BUserIsVacBanned")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool BUserIsVacBanned([In][Out] byte[] rgubTicketDecrypted, uint cubTicketDecrypted);

		[DllImport("sdkencryptedappticket", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SteamEncryptedAppTicket_GetUserVariableData")]
		public static extern IntPtr GetUserVariableData([In][Out] byte[] rgubTicketDecrypted, uint cubTicketDecrypted, out uint pcubUserData);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern uint ISteamAppList_GetNumInstalledApps();

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern uint ISteamAppList_GetInstalledApps([In][Out] AppId_t[] pvecAppID, uint unMaxAppIDs);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern int ISteamAppList_GetAppName(AppId_t nAppID, IntPtr pchName, int cchNameMax);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern int ISteamAppList_GetAppInstallDir(AppId_t nAppID, IntPtr pchDirectory, int cchNameMax);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern int ISteamAppList_GetAppBuildId(AppId_t nAppID);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamApps_BIsSubscribed();

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamApps_BIsLowViolence();

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamApps_BIsCybercafe();

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamApps_BIsVACBanned();

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr ISteamApps_GetCurrentGameLanguage();

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr ISteamApps_GetAvailableGameLanguages();

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamApps_BIsSubscribedApp(AppId_t appID);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamApps_BIsDlcInstalled(AppId_t appID);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern uint ISteamApps_GetEarliestPurchaseUnixTime(AppId_t nAppID);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamApps_BIsSubscribedFromFreeWeekend();

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern int ISteamApps_GetDLCCount();

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamApps_BGetDLCDataByIndex(int iDLC, out AppId_t pAppID, out bool pbAvailable, IntPtr pchName, int cchNameBufferSize);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ISteamApps_InstallDLC(AppId_t nAppID);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ISteamApps_UninstallDLC(AppId_t nAppID);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ISteamApps_RequestAppProofOfPurchaseKey(AppId_t nAppID);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamApps_GetCurrentBetaName(IntPtr pchName, int cchNameBufferSize);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamApps_MarkContentCorrupt([MarshalAs(UnmanagedType.I1)] bool bMissingFilesOnly);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern uint ISteamApps_GetInstalledDepots(AppId_t appID, [In][Out] DepotId_t[] pvecDepots, uint cMaxDepots);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern uint ISteamApps_GetAppInstallDir(AppId_t appID, IntPtr pchFolder, uint cchFolderBufferSize);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamApps_BIsAppInstalled(AppId_t appID);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern ulong ISteamApps_GetAppOwner();

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr ISteamApps_GetLaunchQueryParam(InteropHelp.UTF8StringHandle pchKey);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamApps_GetDlcDownloadProgress(AppId_t nAppID, out ulong punBytesDownloaded, out ulong punBytesTotal);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern int ISteamApps_GetAppBuildId();

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern int ISteamClient_CreateSteamPipe();

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamClient_BReleaseSteamPipe(HSteamPipe hSteamPipe);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern int ISteamClient_ConnectToGlobalUser(HSteamPipe hSteamPipe);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern int ISteamClient_CreateLocalUser(out HSteamPipe phSteamPipe, EAccountType eAccountType);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ISteamClient_ReleaseUser(HSteamPipe hSteamPipe, HSteamUser hUser);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr ISteamClient_GetISteamUser(HSteamUser hSteamUser, HSteamPipe hSteamPipe, InteropHelp.UTF8StringHandle pchVersion);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr ISteamClient_GetISteamGameServer(HSteamUser hSteamUser, HSteamPipe hSteamPipe, InteropHelp.UTF8StringHandle pchVersion);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ISteamClient_SetLocalIPBinding(uint unIP, ushort usPort);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr ISteamClient_GetISteamFriends(HSteamUser hSteamUser, HSteamPipe hSteamPipe, InteropHelp.UTF8StringHandle pchVersion);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr ISteamClient_GetISteamUtils(HSteamPipe hSteamPipe, InteropHelp.UTF8StringHandle pchVersion);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr ISteamClient_GetISteamMatchmaking(HSteamUser hSteamUser, HSteamPipe hSteamPipe, InteropHelp.UTF8StringHandle pchVersion);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr ISteamClient_GetISteamMatchmakingServers(HSteamUser hSteamUser, HSteamPipe hSteamPipe, InteropHelp.UTF8StringHandle pchVersion);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr ISteamClient_GetISteamGenericInterface(HSteamUser hSteamUser, HSteamPipe hSteamPipe, InteropHelp.UTF8StringHandle pchVersion);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr ISteamClient_GetISteamUserStats(HSteamUser hSteamUser, HSteamPipe hSteamPipe, InteropHelp.UTF8StringHandle pchVersion);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr ISteamClient_GetISteamGameServerStats(HSteamUser hSteamuser, HSteamPipe hSteamPipe, InteropHelp.UTF8StringHandle pchVersion);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr ISteamClient_GetISteamApps(HSteamUser hSteamUser, HSteamPipe hSteamPipe, InteropHelp.UTF8StringHandle pchVersion);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr ISteamClient_GetISteamNetworking(HSteamUser hSteamUser, HSteamPipe hSteamPipe, InteropHelp.UTF8StringHandle pchVersion);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr ISteamClient_GetISteamRemoteStorage(HSteamUser hSteamuser, HSteamPipe hSteamPipe, InteropHelp.UTF8StringHandle pchVersion);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr ISteamClient_GetISteamScreenshots(HSteamUser hSteamuser, HSteamPipe hSteamPipe, InteropHelp.UTF8StringHandle pchVersion);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ISteamClient_RunFrame();

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern uint ISteamClient_GetIPCCallCount();

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ISteamClient_SetWarningMessageHook(SteamAPIWarningMessageHook_t pFunction);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamClient_BShutdownIfAllPipesClosed();

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr ISteamClient_GetISteamHTTP(HSteamUser hSteamuser, HSteamPipe hSteamPipe, InteropHelp.UTF8StringHandle pchVersion);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr ISteamClient_GetISteamUnifiedMessages(HSteamUser hSteamuser, HSteamPipe hSteamPipe, InteropHelp.UTF8StringHandle pchVersion);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr ISteamClient_GetISteamController(HSteamUser hSteamUser, HSteamPipe hSteamPipe, InteropHelp.UTF8StringHandle pchVersion);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr ISteamClient_GetISteamUGC(HSteamUser hSteamUser, HSteamPipe hSteamPipe, InteropHelp.UTF8StringHandle pchVersion);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr ISteamClient_GetISteamAppList(HSteamUser hSteamUser, HSteamPipe hSteamPipe, InteropHelp.UTF8StringHandle pchVersion);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr ISteamClient_GetISteamMusic(HSteamUser hSteamuser, HSteamPipe hSteamPipe, InteropHelp.UTF8StringHandle pchVersion);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr ISteamClient_GetISteamMusicRemote(HSteamUser hSteamuser, HSteamPipe hSteamPipe, InteropHelp.UTF8StringHandle pchVersion);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr ISteamClient_GetISteamHTMLSurface(HSteamUser hSteamuser, HSteamPipe hSteamPipe, InteropHelp.UTF8StringHandle pchVersion);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ISteamClient_Set_SteamAPI_CPostAPIResultInProcess(SteamAPI_PostAPIResultInProcess_t func);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ISteamClient_Remove_SteamAPI_CPostAPIResultInProcess(SteamAPI_PostAPIResultInProcess_t func);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ISteamClient_Set_SteamAPI_CCheckCallbackRegisteredInProcess(SteamAPI_CheckCallbackRegistered_t func);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr ISteamClient_GetISteamInventory(HSteamUser hSteamuser, HSteamPipe hSteamPipe, InteropHelp.UTF8StringHandle pchVersion);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr ISteamClient_GetISteamVideo(HSteamUser hSteamuser, HSteamPipe hSteamPipe, InteropHelp.UTF8StringHandle pchVersion);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamController_Init(InteropHelp.UTF8StringHandle pchAbsolutePathToControllerConfigVDF);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamController_Shutdown();

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ISteamController_RunFrame();

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamController_GetControllerState(uint unControllerIndex, out SteamControllerState_t pState);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ISteamController_TriggerHapticPulse(uint unControllerIndex, ESteamControllerPad eTargetPad, ushort usDurationMicroSec);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ISteamController_SetOverrideMode(InteropHelp.UTF8StringHandle pchMode);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr ISteamFriends_GetPersonaName();

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern ulong ISteamFriends_SetPersonaName(InteropHelp.UTF8StringHandle pchPersonaName);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern EPersonaState ISteamFriends_GetPersonaState();

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern int ISteamFriends_GetFriendCount(EFriendFlags iFriendFlags);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern ulong ISteamFriends_GetFriendByIndex(int iFriend, EFriendFlags iFriendFlags);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern EFriendRelationship ISteamFriends_GetFriendRelationship(CSteamID steamIDFriend);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern EPersonaState ISteamFriends_GetFriendPersonaState(CSteamID steamIDFriend);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr ISteamFriends_GetFriendPersonaName(CSteamID steamIDFriend);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamFriends_GetFriendGamePlayed(CSteamID steamIDFriend, out FriendGameInfo_t pFriendGameInfo);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr ISteamFriends_GetFriendPersonaNameHistory(CSteamID steamIDFriend, int iPersonaName);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern int ISteamFriends_GetFriendSteamLevel(CSteamID steamIDFriend);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr ISteamFriends_GetPlayerNickname(CSteamID steamIDPlayer);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern int ISteamFriends_GetFriendsGroupCount();

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern short ISteamFriends_GetFriendsGroupIDByIndex(int iFG);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr ISteamFriends_GetFriendsGroupName(FriendsGroupID_t friendsGroupID);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern int ISteamFriends_GetFriendsGroupMembersCount(FriendsGroupID_t friendsGroupID);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ISteamFriends_GetFriendsGroupMembersList(FriendsGroupID_t friendsGroupID, [In][Out] CSteamID[] pOutSteamIDMembers, int nMembersCount);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamFriends_HasFriend(CSteamID steamIDFriend, EFriendFlags iFriendFlags);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern int ISteamFriends_GetClanCount();

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern ulong ISteamFriends_GetClanByIndex(int iClan);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr ISteamFriends_GetClanName(CSteamID steamIDClan);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr ISteamFriends_GetClanTag(CSteamID steamIDClan);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamFriends_GetClanActivityCounts(CSteamID steamIDClan, out int pnOnline, out int pnInGame, out int pnChatting);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern ulong ISteamFriends_DownloadClanActivityCounts([In][Out] CSteamID[] psteamIDClans, int cClansToRequest);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern int ISteamFriends_GetFriendCountFromSource(CSteamID steamIDSource);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern ulong ISteamFriends_GetFriendFromSourceByIndex(CSteamID steamIDSource, int iFriend);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamFriends_IsUserInSource(CSteamID steamIDUser, CSteamID steamIDSource);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ISteamFriends_SetInGameVoiceSpeaking(CSteamID steamIDUser, [MarshalAs(UnmanagedType.I1)] bool bSpeaking);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ISteamFriends_ActivateGameOverlay(InteropHelp.UTF8StringHandle pchDialog);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ISteamFriends_ActivateGameOverlayToUser(InteropHelp.UTF8StringHandle pchDialog, CSteamID steamID);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ISteamFriends_ActivateGameOverlayToWebPage(InteropHelp.UTF8StringHandle pchURL);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ISteamFriends_ActivateGameOverlayToStore(AppId_t nAppID, EOverlayToStoreFlag eFlag);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ISteamFriends_SetPlayedWith(CSteamID steamIDUserPlayedWith);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ISteamFriends_ActivateGameOverlayInviteDialog(CSteamID steamIDLobby);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern int ISteamFriends_GetSmallFriendAvatar(CSteamID steamIDFriend);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern int ISteamFriends_GetMediumFriendAvatar(CSteamID steamIDFriend);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern int ISteamFriends_GetLargeFriendAvatar(CSteamID steamIDFriend);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamFriends_RequestUserInformation(CSteamID steamIDUser, [MarshalAs(UnmanagedType.I1)] bool bRequireNameOnly);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern ulong ISteamFriends_RequestClanOfficerList(CSteamID steamIDClan);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern ulong ISteamFriends_GetClanOwner(CSteamID steamIDClan);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern int ISteamFriends_GetClanOfficerCount(CSteamID steamIDClan);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern ulong ISteamFriends_GetClanOfficerByIndex(CSteamID steamIDClan, int iOfficer);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern uint ISteamFriends_GetUserRestrictions();

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamFriends_SetRichPresence(InteropHelp.UTF8StringHandle pchKey, InteropHelp.UTF8StringHandle pchValue);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ISteamFriends_ClearRichPresence();

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr ISteamFriends_GetFriendRichPresence(CSteamID steamIDFriend, InteropHelp.UTF8StringHandle pchKey);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern int ISteamFriends_GetFriendRichPresenceKeyCount(CSteamID steamIDFriend);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr ISteamFriends_GetFriendRichPresenceKeyByIndex(CSteamID steamIDFriend, int iKey);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ISteamFriends_RequestFriendRichPresence(CSteamID steamIDFriend);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamFriends_InviteUserToGame(CSteamID steamIDFriend, InteropHelp.UTF8StringHandle pchConnectString);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern int ISteamFriends_GetCoplayFriendCount();

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern ulong ISteamFriends_GetCoplayFriend(int iCoplayFriend);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern int ISteamFriends_GetFriendCoplayTime(CSteamID steamIDFriend);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern uint ISteamFriends_GetFriendCoplayGame(CSteamID steamIDFriend);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern ulong ISteamFriends_JoinClanChatRoom(CSteamID steamIDClan);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamFriends_LeaveClanChatRoom(CSteamID steamIDClan);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern int ISteamFriends_GetClanChatMemberCount(CSteamID steamIDClan);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern ulong ISteamFriends_GetChatMemberByIndex(CSteamID steamIDClan, int iUser);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamFriends_SendClanChatMessage(CSteamID steamIDClanChat, InteropHelp.UTF8StringHandle pchText);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern int ISteamFriends_GetClanChatMessage(CSteamID steamIDClanChat, int iMessage, IntPtr prgchText, int cchTextMax, out EChatEntryType peChatEntryType, out CSteamID psteamidChatter);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamFriends_IsClanChatAdmin(CSteamID steamIDClanChat, CSteamID steamIDUser);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamFriends_IsClanChatWindowOpenInSteam(CSteamID steamIDClanChat);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamFriends_OpenClanChatWindowInSteam(CSteamID steamIDClanChat);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamFriends_CloseClanChatWindowInSteam(CSteamID steamIDClanChat);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamFriends_SetListenForFriendsMessages([MarshalAs(UnmanagedType.I1)] bool bInterceptEnabled);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamFriends_ReplyToFriendMessage(CSteamID steamIDFriend, InteropHelp.UTF8StringHandle pchMsgToSend);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern int ISteamFriends_GetFriendMessage(CSteamID steamIDFriend, int iMessageID, IntPtr pvData, int cubData, out EChatEntryType peChatEntryType);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern ulong ISteamFriends_GetFollowerCount(CSteamID steamID);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern ulong ISteamFriends_IsFollowing(CSteamID steamID);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern ulong ISteamFriends_EnumerateFollowingList(uint unStartIndex);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamGameServer_InitGameServer(uint unIP, ushort usGamePort, ushort usQueryPort, uint unFlags, AppId_t nGameAppId, InteropHelp.UTF8StringHandle pchVersionString);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ISteamGameServer_SetProduct(InteropHelp.UTF8StringHandle pszProduct);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ISteamGameServer_SetGameDescription(InteropHelp.UTF8StringHandle pszGameDescription);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ISteamGameServer_SetModDir(InteropHelp.UTF8StringHandle pszModDir);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ISteamGameServer_SetDedicatedServer([MarshalAs(UnmanagedType.I1)] bool bDedicated);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ISteamGameServer_LogOn(InteropHelp.UTF8StringHandle pszToken);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ISteamGameServer_LogOnAnonymous();

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ISteamGameServer_LogOff();

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamGameServer_BLoggedOn();

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamGameServer_BSecure();

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern ulong ISteamGameServer_GetSteamID();

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamGameServer_WasRestartRequested();

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ISteamGameServer_SetMaxPlayerCount(int cPlayersMax);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ISteamGameServer_SetBotPlayerCount(int cBotplayers);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ISteamGameServer_SetServerName(InteropHelp.UTF8StringHandle pszServerName);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ISteamGameServer_SetMapName(InteropHelp.UTF8StringHandle pszMapName);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ISteamGameServer_SetPasswordProtected([MarshalAs(UnmanagedType.I1)] bool bPasswordProtected);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ISteamGameServer_SetSpectatorPort(ushort unSpectatorPort);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ISteamGameServer_SetSpectatorServerName(InteropHelp.UTF8StringHandle pszSpectatorServerName);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ISteamGameServer_ClearAllKeyValues();

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ISteamGameServer_SetKeyValue(InteropHelp.UTF8StringHandle pKey, InteropHelp.UTF8StringHandle pValue);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ISteamGameServer_SetGameTags(InteropHelp.UTF8StringHandle pchGameTags);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ISteamGameServer_SetGameData(InteropHelp.UTF8StringHandle pchGameData);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ISteamGameServer_SetRegion(InteropHelp.UTF8StringHandle pszRegion);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamGameServer_SendUserConnectAndAuthenticate(uint unIPClient, [In][Out] byte[] pvAuthBlob, uint cubAuthBlobSize, out CSteamID pSteamIDUser);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern ulong ISteamGameServer_CreateUnauthenticatedUserConnection();

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ISteamGameServer_SendUserDisconnect(CSteamID steamIDUser);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamGameServer_BUpdateUserData(CSteamID steamIDUser, InteropHelp.UTF8StringHandle pchPlayerName, uint uScore);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern uint ISteamGameServer_GetAuthSessionTicket([In][Out] byte[] pTicket, int cbMaxTicket, out uint pcbTicket);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern EBeginAuthSessionResult ISteamGameServer_BeginAuthSession([In][Out] byte[] pAuthTicket, int cbAuthTicket, CSteamID steamID);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ISteamGameServer_EndAuthSession(CSteamID steamID);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ISteamGameServer_CancelAuthTicket(HAuthTicket hAuthTicket);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern EUserHasLicenseForAppResult ISteamGameServer_UserHasLicenseForApp(CSteamID steamID, AppId_t appID);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamGameServer_RequestUserGroupStatus(CSteamID steamIDUser, CSteamID steamIDGroup);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ISteamGameServer_GetGameplayStats();

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern ulong ISteamGameServer_GetServerReputation();

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern uint ISteamGameServer_GetPublicIP();

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamGameServer_HandleIncomingPacket([In][Out] byte[] pData, int cbData, uint srcIP, ushort srcPort);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern int ISteamGameServer_GetNextOutgoingPacket([In][Out] byte[] pOut, int cbMaxOut, out uint pNetAdr, out ushort pPort);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ISteamGameServer_EnableHeartbeats([MarshalAs(UnmanagedType.I1)] bool bActive);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ISteamGameServer_SetHeartbeatInterval(int iHeartbeatInterval);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ISteamGameServer_ForceHeartbeat();

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern ulong ISteamGameServer_AssociateWithClan(CSteamID steamIDClan);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern ulong ISteamGameServer_ComputeNewPlayerCompatibility(CSteamID steamIDNewPlayer);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern ulong ISteamGameServerStats_RequestUserStats(CSteamID steamIDUser);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamGameServerStats_GetUserStat(CSteamID steamIDUser, InteropHelp.UTF8StringHandle pchName, out int pData);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamGameServerStats_GetUserStat_(CSteamID steamIDUser, InteropHelp.UTF8StringHandle pchName, out float pData);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamGameServerStats_GetUserAchievement(CSteamID steamIDUser, InteropHelp.UTF8StringHandle pchName, out bool pbAchieved);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamGameServerStats_SetUserStat(CSteamID steamIDUser, InteropHelp.UTF8StringHandle pchName, int nData);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamGameServerStats_SetUserStat_(CSteamID steamIDUser, InteropHelp.UTF8StringHandle pchName, float fData);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamGameServerStats_UpdateUserAvgRateStat(CSteamID steamIDUser, InteropHelp.UTF8StringHandle pchName, float flCountThisSession, double dSessionLength);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamGameServerStats_SetUserAchievement(CSteamID steamIDUser, InteropHelp.UTF8StringHandle pchName);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamGameServerStats_ClearUserAchievement(CSteamID steamIDUser, InteropHelp.UTF8StringHandle pchName);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern ulong ISteamGameServerStats_StoreUserStats(CSteamID steamIDUser);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamHTMLSurface_Init();

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamHTMLSurface_Shutdown();

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern ulong ISteamHTMLSurface_CreateBrowser(InteropHelp.UTF8StringHandle pchUserAgent, InteropHelp.UTF8StringHandle pchUserCSS);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ISteamHTMLSurface_RemoveBrowser(HHTMLBrowser unBrowserHandle);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ISteamHTMLSurface_LoadURL(HHTMLBrowser unBrowserHandle, InteropHelp.UTF8StringHandle pchURL, InteropHelp.UTF8StringHandle pchPostData);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ISteamHTMLSurface_SetSize(HHTMLBrowser unBrowserHandle, uint unWidth, uint unHeight);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ISteamHTMLSurface_StopLoad(HHTMLBrowser unBrowserHandle);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ISteamHTMLSurface_Reload(HHTMLBrowser unBrowserHandle);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ISteamHTMLSurface_GoBack(HHTMLBrowser unBrowserHandle);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ISteamHTMLSurface_GoForward(HHTMLBrowser unBrowserHandle);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ISteamHTMLSurface_AddHeader(HHTMLBrowser unBrowserHandle, InteropHelp.UTF8StringHandle pchKey, InteropHelp.UTF8StringHandle pchValue);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ISteamHTMLSurface_ExecuteJavascript(HHTMLBrowser unBrowserHandle, InteropHelp.UTF8StringHandle pchScript);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ISteamHTMLSurface_MouseUp(HHTMLBrowser unBrowserHandle, EHTMLMouseButton eMouseButton);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ISteamHTMLSurface_MouseDown(HHTMLBrowser unBrowserHandle, EHTMLMouseButton eMouseButton);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ISteamHTMLSurface_MouseDoubleClick(HHTMLBrowser unBrowserHandle, EHTMLMouseButton eMouseButton);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ISteamHTMLSurface_MouseMove(HHTMLBrowser unBrowserHandle, int x, int y);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ISteamHTMLSurface_MouseWheel(HHTMLBrowser unBrowserHandle, int nDelta);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ISteamHTMLSurface_KeyDown(HHTMLBrowser unBrowserHandle, uint nNativeKeyCode, EHTMLKeyModifiers eHTMLKeyModifiers);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ISteamHTMLSurface_KeyUp(HHTMLBrowser unBrowserHandle, uint nNativeKeyCode, EHTMLKeyModifiers eHTMLKeyModifiers);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ISteamHTMLSurface_KeyChar(HHTMLBrowser unBrowserHandle, uint cUnicodeChar, EHTMLKeyModifiers eHTMLKeyModifiers);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ISteamHTMLSurface_SetHorizontalScroll(HHTMLBrowser unBrowserHandle, uint nAbsolutePixelScroll);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ISteamHTMLSurface_SetVerticalScroll(HHTMLBrowser unBrowserHandle, uint nAbsolutePixelScroll);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ISteamHTMLSurface_SetKeyFocus(HHTMLBrowser unBrowserHandle, [MarshalAs(UnmanagedType.I1)] bool bHasKeyFocus);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ISteamHTMLSurface_ViewSource(HHTMLBrowser unBrowserHandle);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ISteamHTMLSurface_CopyToClipboard(HHTMLBrowser unBrowserHandle);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ISteamHTMLSurface_PasteFromClipboard(HHTMLBrowser unBrowserHandle);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ISteamHTMLSurface_Find(HHTMLBrowser unBrowserHandle, InteropHelp.UTF8StringHandle pchSearchStr, [MarshalAs(UnmanagedType.I1)] bool bCurrentlyInFind, [MarshalAs(UnmanagedType.I1)] bool bReverse);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ISteamHTMLSurface_StopFind(HHTMLBrowser unBrowserHandle);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ISteamHTMLSurface_GetLinkAtPosition(HHTMLBrowser unBrowserHandle, int x, int y);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ISteamHTMLSurface_SetCookie(InteropHelp.UTF8StringHandle pchHostname, InteropHelp.UTF8StringHandle pchKey, InteropHelp.UTF8StringHandle pchValue, InteropHelp.UTF8StringHandle pchPath, uint nExpires, [MarshalAs(UnmanagedType.I1)] bool bSecure, [MarshalAs(UnmanagedType.I1)] bool bHTTPOnly);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ISteamHTMLSurface_SetPageScaleFactor(HHTMLBrowser unBrowserHandle, float flZoom, int nPointX, int nPointY);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ISteamHTMLSurface_SetBackgroundMode(HHTMLBrowser unBrowserHandle, [MarshalAs(UnmanagedType.I1)] bool bBackgroundMode);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ISteamHTMLSurface_AllowStartRequest(HHTMLBrowser unBrowserHandle, [MarshalAs(UnmanagedType.I1)] bool bAllowed);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ISteamHTMLSurface_JSDialogResponse(HHTMLBrowser unBrowserHandle, [MarshalAs(UnmanagedType.I1)] bool bResult);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ISteamHTMLSurface_FileLoadDialogResponse(HHTMLBrowser unBrowserHandle, IntPtr pchSelectedFiles);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern uint ISteamHTTP_CreateHTTPRequest(EHTTPMethod eHTTPRequestMethod, InteropHelp.UTF8StringHandle pchAbsoluteURL);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamHTTP_SetHTTPRequestContextValue(HTTPRequestHandle hRequest, ulong ulContextValue);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamHTTP_SetHTTPRequestNetworkActivityTimeout(HTTPRequestHandle hRequest, uint unTimeoutSeconds);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamHTTP_SetHTTPRequestHeaderValue(HTTPRequestHandle hRequest, InteropHelp.UTF8StringHandle pchHeaderName, InteropHelp.UTF8StringHandle pchHeaderValue);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamHTTP_SetHTTPRequestGetOrPostParameter(HTTPRequestHandle hRequest, InteropHelp.UTF8StringHandle pchParamName, InteropHelp.UTF8StringHandle pchParamValue);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamHTTP_SendHTTPRequest(HTTPRequestHandle hRequest, out SteamAPICall_t pCallHandle);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamHTTP_SendHTTPRequestAndStreamResponse(HTTPRequestHandle hRequest, out SteamAPICall_t pCallHandle);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamHTTP_DeferHTTPRequest(HTTPRequestHandle hRequest);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamHTTP_PrioritizeHTTPRequest(HTTPRequestHandle hRequest);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamHTTP_GetHTTPResponseHeaderSize(HTTPRequestHandle hRequest, InteropHelp.UTF8StringHandle pchHeaderName, out uint unResponseHeaderSize);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamHTTP_GetHTTPResponseHeaderValue(HTTPRequestHandle hRequest, InteropHelp.UTF8StringHandle pchHeaderName, [In][Out] byte[] pHeaderValueBuffer, uint unBufferSize);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamHTTP_GetHTTPResponseBodySize(HTTPRequestHandle hRequest, out uint unBodySize);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamHTTP_GetHTTPResponseBodyData(HTTPRequestHandle hRequest, [In][Out] byte[] pBodyDataBuffer, uint unBufferSize);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamHTTP_GetHTTPStreamingResponseBodyData(HTTPRequestHandle hRequest, uint cOffset, [In][Out] byte[] pBodyDataBuffer, uint unBufferSize);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamHTTP_ReleaseHTTPRequest(HTTPRequestHandle hRequest);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamHTTP_GetHTTPDownloadProgressPct(HTTPRequestHandle hRequest, out float pflPercentOut);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamHTTP_SetHTTPRequestRawPostBody(HTTPRequestHandle hRequest, InteropHelp.UTF8StringHandle pchContentType, [In][Out] byte[] pubBody, uint unBodyLen);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern uint ISteamHTTP_CreateCookieContainer([MarshalAs(UnmanagedType.I1)] bool bAllowResponsesToModify);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamHTTP_ReleaseCookieContainer(HTTPCookieContainerHandle hCookieContainer);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamHTTP_SetCookie(HTTPCookieContainerHandle hCookieContainer, InteropHelp.UTF8StringHandle pchHost, InteropHelp.UTF8StringHandle pchUrl, InteropHelp.UTF8StringHandle pchCookie);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamHTTP_SetHTTPRequestCookieContainer(HTTPRequestHandle hRequest, HTTPCookieContainerHandle hCookieContainer);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamHTTP_SetHTTPRequestUserAgentInfo(HTTPRequestHandle hRequest, InteropHelp.UTF8StringHandle pchUserAgentInfo);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamHTTP_SetHTTPRequestRequiresVerifiedCertificate(HTTPRequestHandle hRequest, [MarshalAs(UnmanagedType.I1)] bool bRequireVerifiedCertificate);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamHTTP_SetHTTPRequestAbsoluteTimeoutMS(HTTPRequestHandle hRequest, uint unMilliseconds);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamHTTP_GetHTTPRequestWasTimedOut(HTTPRequestHandle hRequest, out bool pbWasTimedOut);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern EResult ISteamInventory_GetResultStatus(SteamInventoryResult_t resultHandle);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamInventory_GetResultItems(SteamInventoryResult_t resultHandle, [In][Out] SteamItemDetails_t[] pOutItemsArray, ref uint punOutItemsArraySize);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern uint ISteamInventory_GetResultTimestamp(SteamInventoryResult_t resultHandle);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamInventory_CheckResultSteamID(SteamInventoryResult_t resultHandle, CSteamID steamIDExpected);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ISteamInventory_DestroyResult(SteamInventoryResult_t resultHandle);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamInventory_GetAllItems(out SteamInventoryResult_t pResultHandle);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamInventory_GetItemsByID(out SteamInventoryResult_t pResultHandle, [In][Out] SteamItemInstanceID_t[] pInstanceIDs, uint unCountInstanceIDs);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamInventory_SerializeResult(SteamInventoryResult_t resultHandle, [In][Out] byte[] pOutBuffer, out uint punOutBufferSize);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamInventory_DeserializeResult(out SteamInventoryResult_t pOutResultHandle, [In][Out] byte[] pBuffer, uint unBufferSize, [MarshalAs(UnmanagedType.I1)] bool bRESERVED_MUST_BE_FALSE);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamInventory_GenerateItems(out SteamInventoryResult_t pResultHandle, [In][Out] SteamItemDef_t[] pArrayItemDefs, [In][Out] uint[] punArrayQuantity, uint unArrayLength);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamInventory_GrantPromoItems(out SteamInventoryResult_t pResultHandle);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamInventory_AddPromoItem(out SteamInventoryResult_t pResultHandle, SteamItemDef_t itemDef);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamInventory_AddPromoItems(out SteamInventoryResult_t pResultHandle, [In][Out] SteamItemDef_t[] pArrayItemDefs, uint unArrayLength);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamInventory_ConsumeItem(out SteamInventoryResult_t pResultHandle, SteamItemInstanceID_t itemConsume, uint unQuantity);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamInventory_ExchangeItems(out SteamInventoryResult_t pResultHandle, [In][Out] SteamItemDef_t[] pArrayGenerate, [In][Out] uint[] punArrayGenerateQuantity, uint unArrayGenerateLength, [In][Out] SteamItemInstanceID_t[] pArrayDestroy, [In][Out] uint[] punArrayDestroyQuantity, uint unArrayDestroyLength);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamInventory_TransferItemQuantity(out SteamInventoryResult_t pResultHandle, SteamItemInstanceID_t itemIdSource, uint unQuantity, SteamItemInstanceID_t itemIdDest);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ISteamInventory_SendItemDropHeartbeat();

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamInventory_TriggerItemDrop(out SteamInventoryResult_t pResultHandle, SteamItemDef_t dropListDefinition);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamInventory_TradeItems(out SteamInventoryResult_t pResultHandle, CSteamID steamIDTradePartner, [In][Out] SteamItemInstanceID_t[] pArrayGive, [In][Out] uint[] pArrayGiveQuantity, uint nArrayGiveLength, [In][Out] SteamItemInstanceID_t[] pArrayGet, [In][Out] uint[] pArrayGetQuantity, uint nArrayGetLength);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamInventory_LoadItemDefinitions();

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamInventory_GetItemDefinitionIDs([In][Out] SteamItemDef_t[] pItemDefIDs, out uint punItemDefIDsArraySize);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamInventory_GetItemDefinitionProperty(SteamItemDef_t iDefinition, InteropHelp.UTF8StringHandle pchPropertyName, IntPtr pchValueBuffer, ref uint punValueBufferSize);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern int ISteamMatchmaking_GetFavoriteGameCount();

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamMatchmaking_GetFavoriteGame(int iGame, out AppId_t pnAppID, out uint pnIP, out ushort pnConnPort, out ushort pnQueryPort, out uint punFlags, out uint pRTime32LastPlayedOnServer);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern int ISteamMatchmaking_AddFavoriteGame(AppId_t nAppID, uint nIP, ushort nConnPort, ushort nQueryPort, uint unFlags, uint rTime32LastPlayedOnServer);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamMatchmaking_RemoveFavoriteGame(AppId_t nAppID, uint nIP, ushort nConnPort, ushort nQueryPort, uint unFlags);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern ulong ISteamMatchmaking_RequestLobbyList();

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ISteamMatchmaking_AddRequestLobbyListStringFilter(InteropHelp.UTF8StringHandle pchKeyToMatch, InteropHelp.UTF8StringHandle pchValueToMatch, ELobbyComparison eComparisonType);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ISteamMatchmaking_AddRequestLobbyListNumericalFilter(InteropHelp.UTF8StringHandle pchKeyToMatch, int nValueToMatch, ELobbyComparison eComparisonType);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ISteamMatchmaking_AddRequestLobbyListNearValueFilter(InteropHelp.UTF8StringHandle pchKeyToMatch, int nValueToBeCloseTo);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ISteamMatchmaking_AddRequestLobbyListFilterSlotsAvailable(int nSlotsAvailable);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ISteamMatchmaking_AddRequestLobbyListDistanceFilter(ELobbyDistanceFilter eLobbyDistanceFilter);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ISteamMatchmaking_AddRequestLobbyListResultCountFilter(int cMaxResults);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ISteamMatchmaking_AddRequestLobbyListCompatibleMembersFilter(CSteamID steamIDLobby);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern ulong ISteamMatchmaking_GetLobbyByIndex(int iLobby);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern ulong ISteamMatchmaking_CreateLobby(ELobbyType eLobbyType, int cMaxMembers);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern ulong ISteamMatchmaking_JoinLobby(CSteamID steamIDLobby);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ISteamMatchmaking_LeaveLobby(CSteamID steamIDLobby);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamMatchmaking_InviteUserToLobby(CSteamID steamIDLobby, CSteamID steamIDInvitee);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern int ISteamMatchmaking_GetNumLobbyMembers(CSteamID steamIDLobby);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern ulong ISteamMatchmaking_GetLobbyMemberByIndex(CSteamID steamIDLobby, int iMember);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr ISteamMatchmaking_GetLobbyData(CSteamID steamIDLobby, InteropHelp.UTF8StringHandle pchKey);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamMatchmaking_SetLobbyData(CSteamID steamIDLobby, InteropHelp.UTF8StringHandle pchKey, InteropHelp.UTF8StringHandle pchValue);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern int ISteamMatchmaking_GetLobbyDataCount(CSteamID steamIDLobby);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamMatchmaking_GetLobbyDataByIndex(CSteamID steamIDLobby, int iLobbyData, IntPtr pchKey, int cchKeyBufferSize, IntPtr pchValue, int cchValueBufferSize);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamMatchmaking_DeleteLobbyData(CSteamID steamIDLobby, InteropHelp.UTF8StringHandle pchKey);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr ISteamMatchmaking_GetLobbyMemberData(CSteamID steamIDLobby, CSteamID steamIDUser, InteropHelp.UTF8StringHandle pchKey);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ISteamMatchmaking_SetLobbyMemberData(CSteamID steamIDLobby, InteropHelp.UTF8StringHandle pchKey, InteropHelp.UTF8StringHandle pchValue);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamMatchmaking_SendLobbyChatMsg(CSteamID steamIDLobby, [In][Out] byte[] pvMsgBody, int cubMsgBody);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern int ISteamMatchmaking_GetLobbyChatEntry(CSteamID steamIDLobby, int iChatID, out CSteamID pSteamIDUser, [In][Out] byte[] pvData, int cubData, out EChatEntryType peChatEntryType);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamMatchmaking_RequestLobbyData(CSteamID steamIDLobby);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ISteamMatchmaking_SetLobbyGameServer(CSteamID steamIDLobby, uint unGameServerIP, ushort unGameServerPort, CSteamID steamIDGameServer);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamMatchmaking_GetLobbyGameServer(CSteamID steamIDLobby, out uint punGameServerIP, out ushort punGameServerPort, out CSteamID psteamIDGameServer);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamMatchmaking_SetLobbyMemberLimit(CSteamID steamIDLobby, int cMaxMembers);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern int ISteamMatchmaking_GetLobbyMemberLimit(CSteamID steamIDLobby);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamMatchmaking_SetLobbyType(CSteamID steamIDLobby, ELobbyType eLobbyType);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamMatchmaking_SetLobbyJoinable(CSteamID steamIDLobby, [MarshalAs(UnmanagedType.I1)] bool bLobbyJoinable);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern ulong ISteamMatchmaking_GetLobbyOwner(CSteamID steamIDLobby);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamMatchmaking_SetLobbyOwner(CSteamID steamIDLobby, CSteamID steamIDNewOwner);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamMatchmaking_SetLinkedLobby(CSteamID steamIDLobby, CSteamID steamIDLobbyDependent);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr ISteamMatchmakingServers_RequestInternetServerList(AppId_t iApp, IntPtr ppchFilters, uint nFilters, IntPtr pRequestServersResponse);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr ISteamMatchmakingServers_RequestLANServerList(AppId_t iApp, IntPtr pRequestServersResponse);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr ISteamMatchmakingServers_RequestFriendsServerList(AppId_t iApp, IntPtr ppchFilters, uint nFilters, IntPtr pRequestServersResponse);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr ISteamMatchmakingServers_RequestFavoritesServerList(AppId_t iApp, IntPtr ppchFilters, uint nFilters, IntPtr pRequestServersResponse);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr ISteamMatchmakingServers_RequestHistoryServerList(AppId_t iApp, IntPtr ppchFilters, uint nFilters, IntPtr pRequestServersResponse);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr ISteamMatchmakingServers_RequestSpectatorServerList(AppId_t iApp, IntPtr ppchFilters, uint nFilters, IntPtr pRequestServersResponse);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ISteamMatchmakingServers_ReleaseRequest(HServerListRequest hServerListRequest);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr ISteamMatchmakingServers_GetServerDetails(HServerListRequest hRequest, int iServer);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ISteamMatchmakingServers_CancelQuery(HServerListRequest hRequest);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ISteamMatchmakingServers_RefreshQuery(HServerListRequest hRequest);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamMatchmakingServers_IsRefreshing(HServerListRequest hRequest);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern int ISteamMatchmakingServers_GetServerCount(HServerListRequest hRequest);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ISteamMatchmakingServers_RefreshServer(HServerListRequest hRequest, int iServer);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern int ISteamMatchmakingServers_PingServer(uint unIP, ushort usPort, IntPtr pRequestServersResponse);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern int ISteamMatchmakingServers_PlayerDetails(uint unIP, ushort usPort, IntPtr pRequestServersResponse);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern int ISteamMatchmakingServers_ServerRules(uint unIP, ushort usPort, IntPtr pRequestServersResponse);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ISteamMatchmakingServers_CancelServerQuery(HServerQuery hServerQuery);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamMusic_BIsEnabled();

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamMusic_BIsPlaying();

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern AudioPlayback_Status ISteamMusic_GetPlaybackStatus();

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ISteamMusic_Play();

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ISteamMusic_Pause();

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ISteamMusic_PlayPrevious();

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ISteamMusic_PlayNext();

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ISteamMusic_SetVolume(float flVolume);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern float ISteamMusic_GetVolume();

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamMusicRemote_RegisterSteamMusicRemote(InteropHelp.UTF8StringHandle pchName);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamMusicRemote_DeregisterSteamMusicRemote();

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamMusicRemote_BIsCurrentMusicRemote();

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamMusicRemote_BActivationSuccess([MarshalAs(UnmanagedType.I1)] bool bValue);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamMusicRemote_SetDisplayName(InteropHelp.UTF8StringHandle pchDisplayName);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamMusicRemote_SetPNGIcon_64x64([In][Out] byte[] pvBuffer, uint cbBufferLength);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamMusicRemote_EnablePlayPrevious([MarshalAs(UnmanagedType.I1)] bool bValue);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamMusicRemote_EnablePlayNext([MarshalAs(UnmanagedType.I1)] bool bValue);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamMusicRemote_EnableShuffled([MarshalAs(UnmanagedType.I1)] bool bValue);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamMusicRemote_EnableLooped([MarshalAs(UnmanagedType.I1)] bool bValue);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamMusicRemote_EnableQueue([MarshalAs(UnmanagedType.I1)] bool bValue);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamMusicRemote_EnablePlaylists([MarshalAs(UnmanagedType.I1)] bool bValue);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamMusicRemote_UpdatePlaybackStatus(AudioPlayback_Status nStatus);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamMusicRemote_UpdateShuffled([MarshalAs(UnmanagedType.I1)] bool bValue);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamMusicRemote_UpdateLooped([MarshalAs(UnmanagedType.I1)] bool bValue);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamMusicRemote_UpdateVolume(float flValue);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamMusicRemote_CurrentEntryWillChange();

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamMusicRemote_CurrentEntryIsAvailable([MarshalAs(UnmanagedType.I1)] bool bAvailable);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamMusicRemote_UpdateCurrentEntryText(InteropHelp.UTF8StringHandle pchText);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamMusicRemote_UpdateCurrentEntryElapsedSeconds(int nValue);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamMusicRemote_UpdateCurrentEntryCoverArt([In][Out] byte[] pvBuffer, uint cbBufferLength);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamMusicRemote_CurrentEntryDidChange();

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamMusicRemote_QueueWillChange();

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamMusicRemote_ResetQueueEntries();

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamMusicRemote_SetQueueEntry(int nID, int nPosition, InteropHelp.UTF8StringHandle pchEntryText);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamMusicRemote_SetCurrentQueueEntry(int nID);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamMusicRemote_QueueDidChange();

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamMusicRemote_PlaylistWillChange();

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamMusicRemote_ResetPlaylistEntries();

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamMusicRemote_SetPlaylistEntry(int nID, int nPosition, InteropHelp.UTF8StringHandle pchEntryText);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamMusicRemote_SetCurrentPlaylistEntry(int nID);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamMusicRemote_PlaylistDidChange();

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamNetworking_SendP2PPacket(CSteamID steamIDRemote, [In][Out] byte[] pubData, uint cubData, EP2PSend eP2PSendType, int nChannel);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamNetworking_IsP2PPacketAvailable(out uint pcubMsgSize, int nChannel);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamNetworking_ReadP2PPacket([In][Out] byte[] pubDest, uint cubDest, out uint pcubMsgSize, out CSteamID psteamIDRemote, int nChannel);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamNetworking_AcceptP2PSessionWithUser(CSteamID steamIDRemote);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamNetworking_CloseP2PSessionWithUser(CSteamID steamIDRemote);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamNetworking_CloseP2PChannelWithUser(CSteamID steamIDRemote, int nChannel);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamNetworking_GetP2PSessionState(CSteamID steamIDRemote, out P2PSessionState_t pConnectionState);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamNetworking_AllowP2PPacketRelay([MarshalAs(UnmanagedType.I1)] bool bAllow);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern uint ISteamNetworking_CreateListenSocket(int nVirtualP2PPort, uint nIP, ushort nPort, [MarshalAs(UnmanagedType.I1)] bool bAllowUseOfPacketRelay);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern uint ISteamNetworking_CreateP2PConnectionSocket(CSteamID steamIDTarget, int nVirtualPort, int nTimeoutSec, [MarshalAs(UnmanagedType.I1)] bool bAllowUseOfPacketRelay);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern uint ISteamNetworking_CreateConnectionSocket(uint nIP, ushort nPort, int nTimeoutSec);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamNetworking_DestroySocket(SNetSocket_t hSocket, [MarshalAs(UnmanagedType.I1)] bool bNotifyRemoteEnd);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamNetworking_DestroyListenSocket(SNetListenSocket_t hSocket, [MarshalAs(UnmanagedType.I1)] bool bNotifyRemoteEnd);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamNetworking_SendDataOnSocket(SNetSocket_t hSocket, IntPtr pubData, uint cubData, [MarshalAs(UnmanagedType.I1)] bool bReliable);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamNetworking_IsDataAvailableOnSocket(SNetSocket_t hSocket, out uint pcubMsgSize);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamNetworking_RetrieveDataFromSocket(SNetSocket_t hSocket, IntPtr pubDest, uint cubDest, out uint pcubMsgSize);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamNetworking_IsDataAvailable(SNetListenSocket_t hListenSocket, out uint pcubMsgSize, out SNetSocket_t phSocket);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamNetworking_RetrieveData(SNetListenSocket_t hListenSocket, IntPtr pubDest, uint cubDest, out uint pcubMsgSize, out SNetSocket_t phSocket);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamNetworking_GetSocketInfo(SNetSocket_t hSocket, out CSteamID pSteamIDRemote, out int peSocketStatus, out uint punIPRemote, out ushort punPortRemote);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamNetworking_GetListenSocketInfo(SNetListenSocket_t hListenSocket, out uint pnIP, out ushort pnPort);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern ESNetSocketConnectionType ISteamNetworking_GetSocketConnectionType(SNetSocket_t hSocket);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern int ISteamNetworking_GetMaxPacketSize(SNetSocket_t hSocket);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamRemoteStorage_FileWrite(InteropHelp.UTF8StringHandle pchFile, [In][Out] byte[] pvData, int cubData);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern int ISteamRemoteStorage_FileRead(InteropHelp.UTF8StringHandle pchFile, [In][Out] byte[] pvData, int cubDataToRead);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamRemoteStorage_FileForget(InteropHelp.UTF8StringHandle pchFile);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamRemoteStorage_FileDelete(InteropHelp.UTF8StringHandle pchFile);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern ulong ISteamRemoteStorage_FileShare(InteropHelp.UTF8StringHandle pchFile);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamRemoteStorage_SetSyncPlatforms(InteropHelp.UTF8StringHandle pchFile, ERemoteStoragePlatform eRemoteStoragePlatform);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern ulong ISteamRemoteStorage_FileWriteStreamOpen(InteropHelp.UTF8StringHandle pchFile);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamRemoteStorage_FileWriteStreamWriteChunk(UGCFileWriteStreamHandle_t writeHandle, [In][Out] byte[] pvData, int cubData);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamRemoteStorage_FileWriteStreamClose(UGCFileWriteStreamHandle_t writeHandle);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamRemoteStorage_FileWriteStreamCancel(UGCFileWriteStreamHandle_t writeHandle);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamRemoteStorage_FileExists(InteropHelp.UTF8StringHandle pchFile);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamRemoteStorage_FilePersisted(InteropHelp.UTF8StringHandle pchFile);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern int ISteamRemoteStorage_GetFileSize(InteropHelp.UTF8StringHandle pchFile);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern long ISteamRemoteStorage_GetFileTimestamp(InteropHelp.UTF8StringHandle pchFile);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern ERemoteStoragePlatform ISteamRemoteStorage_GetSyncPlatforms(InteropHelp.UTF8StringHandle pchFile);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern int ISteamRemoteStorage_GetFileCount();

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr ISteamRemoteStorage_GetFileNameAndSize(int iFile, out int pnFileSizeInBytes);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamRemoteStorage_GetQuota(out int pnTotalBytes, out int puAvailableBytes);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamRemoteStorage_IsCloudEnabledForAccount();

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamRemoteStorage_IsCloudEnabledForApp();

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ISteamRemoteStorage_SetCloudEnabledForApp([MarshalAs(UnmanagedType.I1)] bool bEnabled);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern ulong ISteamRemoteStorage_UGCDownload(UGCHandle_t hContent, uint unPriority);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamRemoteStorage_GetUGCDownloadProgress(UGCHandle_t hContent, out int pnBytesDownloaded, out int pnBytesExpected);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamRemoteStorage_GetUGCDetails(UGCHandle_t hContent, out AppId_t pnAppID, out IntPtr ppchName, out int pnFileSizeInBytes, out CSteamID pSteamIDOwner);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern int ISteamRemoteStorage_UGCRead(UGCHandle_t hContent, [In][Out] byte[] pvData, int cubDataToRead, uint cOffset, EUGCReadAction eAction);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern int ISteamRemoteStorage_GetCachedUGCCount();

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern ulong ISteamRemoteStorage_GetCachedUGCHandle(int iCachedContent);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern ulong ISteamRemoteStorage_PublishWorkshopFile(InteropHelp.UTF8StringHandle pchFile, InteropHelp.UTF8StringHandle pchPreviewFile, AppId_t nConsumerAppId, InteropHelp.UTF8StringHandle pchTitle, InteropHelp.UTF8StringHandle pchDescription, ERemoteStoragePublishedFileVisibility eVisibility, IntPtr pTags, EWorkshopFileType eWorkshopFileType);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern ulong ISteamRemoteStorage_CreatePublishedFileUpdateRequest(PublishedFileId_t unPublishedFileId);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamRemoteStorage_UpdatePublishedFileFile(PublishedFileUpdateHandle_t updateHandle, InteropHelp.UTF8StringHandle pchFile);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamRemoteStorage_UpdatePublishedFilePreviewFile(PublishedFileUpdateHandle_t updateHandle, InteropHelp.UTF8StringHandle pchPreviewFile);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamRemoteStorage_UpdatePublishedFileTitle(PublishedFileUpdateHandle_t updateHandle, InteropHelp.UTF8StringHandle pchTitle);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamRemoteStorage_UpdatePublishedFileDescription(PublishedFileUpdateHandle_t updateHandle, InteropHelp.UTF8StringHandle pchDescription);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamRemoteStorage_UpdatePublishedFileVisibility(PublishedFileUpdateHandle_t updateHandle, ERemoteStoragePublishedFileVisibility eVisibility);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamRemoteStorage_UpdatePublishedFileTags(PublishedFileUpdateHandle_t updateHandle, IntPtr pTags);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern ulong ISteamRemoteStorage_CommitPublishedFileUpdate(PublishedFileUpdateHandle_t updateHandle);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern ulong ISteamRemoteStorage_GetPublishedFileDetails(PublishedFileId_t unPublishedFileId, uint unMaxSecondsOld);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern ulong ISteamRemoteStorage_DeletePublishedFile(PublishedFileId_t unPublishedFileId);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern ulong ISteamRemoteStorage_EnumerateUserPublishedFiles(uint unStartIndex);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern ulong ISteamRemoteStorage_SubscribePublishedFile(PublishedFileId_t unPublishedFileId);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern ulong ISteamRemoteStorage_EnumerateUserSubscribedFiles(uint unStartIndex);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern ulong ISteamRemoteStorage_UnsubscribePublishedFile(PublishedFileId_t unPublishedFileId);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamRemoteStorage_UpdatePublishedFileSetChangeDescription(PublishedFileUpdateHandle_t updateHandle, InteropHelp.UTF8StringHandle pchChangeDescription);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern ulong ISteamRemoteStorage_GetPublishedItemVoteDetails(PublishedFileId_t unPublishedFileId);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern ulong ISteamRemoteStorage_UpdateUserPublishedItemVote(PublishedFileId_t unPublishedFileId, [MarshalAs(UnmanagedType.I1)] bool bVoteUp);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern ulong ISteamRemoteStorage_GetUserPublishedItemVoteDetails(PublishedFileId_t unPublishedFileId);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern ulong ISteamRemoteStorage_EnumerateUserSharedWorkshopFiles(CSteamID steamId, uint unStartIndex, IntPtr pRequiredTags, IntPtr pExcludedTags);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern ulong ISteamRemoteStorage_PublishVideo(EWorkshopVideoProvider eVideoProvider, InteropHelp.UTF8StringHandle pchVideoAccount, InteropHelp.UTF8StringHandle pchVideoIdentifier, InteropHelp.UTF8StringHandle pchPreviewFile, AppId_t nConsumerAppId, InteropHelp.UTF8StringHandle pchTitle, InteropHelp.UTF8StringHandle pchDescription, ERemoteStoragePublishedFileVisibility eVisibility, IntPtr pTags);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern ulong ISteamRemoteStorage_SetUserPublishedFileAction(PublishedFileId_t unPublishedFileId, EWorkshopFileAction eAction);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern ulong ISteamRemoteStorage_EnumeratePublishedFilesByUserAction(EWorkshopFileAction eAction, uint unStartIndex);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern ulong ISteamRemoteStorage_EnumeratePublishedWorkshopFiles(EWorkshopEnumerationType eEnumerationType, uint unStartIndex, uint unCount, uint unDays, IntPtr pTags, IntPtr pUserTags);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern ulong ISteamRemoteStorage_UGCDownloadToLocation(UGCHandle_t hContent, InteropHelp.UTF8StringHandle pchLocation, uint unPriority);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern uint ISteamScreenshots_WriteScreenshot([In][Out] byte[] pubRGB, uint cubRGB, int nWidth, int nHeight);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern uint ISteamScreenshots_AddScreenshotToLibrary(InteropHelp.UTF8StringHandle pchFilename, InteropHelp.UTF8StringHandle pchThumbnailFilename, int nWidth, int nHeight);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ISteamScreenshots_TriggerScreenshot();

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ISteamScreenshots_HookScreenshots([MarshalAs(UnmanagedType.I1)] bool bHook);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamScreenshots_SetLocation(ScreenshotHandle hScreenshot, InteropHelp.UTF8StringHandle pchLocation);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamScreenshots_TagUser(ScreenshotHandle hScreenshot, CSteamID steamID);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamScreenshots_TagPublishedFile(ScreenshotHandle hScreenshot, PublishedFileId_t unPublishedFileID);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern ulong ISteamUGC_CreateQueryUserUGCRequest(AccountID_t unAccountID, EUserUGCList eListType, EUGCMatchingUGCType eMatchingUGCType, EUserUGCListSortOrder eSortOrder, AppId_t nCreatorAppID, AppId_t nConsumerAppID, uint unPage);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern ulong ISteamUGC_CreateQueryAllUGCRequest(EUGCQuery eQueryType, EUGCMatchingUGCType eMatchingeMatchingUGCTypeFileType, AppId_t nCreatorAppID, AppId_t nConsumerAppID, uint unPage);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern ulong ISteamUGC_CreateQueryUGCDetailsRequest([In][Out] PublishedFileId_t[] pvecPublishedFileID, uint unNumPublishedFileIDs);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern ulong ISteamUGC_SendQueryUGCRequest(UGCQueryHandle_t handle);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamUGC_GetQueryUGCResult(UGCQueryHandle_t handle, uint index, out SteamUGCDetails_t pDetails);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamUGC_GetQueryUGCPreviewURL(UGCQueryHandle_t handle, uint index, IntPtr pchURL, uint cchURLSize);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamUGC_GetQueryUGCMetadata(UGCQueryHandle_t handle, uint index, IntPtr pchMetadata, uint cchMetadatasize);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamUGC_GetQueryUGCChildren(UGCQueryHandle_t handle, uint index, [In][Out] PublishedFileId_t[] pvecPublishedFileID, uint cMaxEntries);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamUGC_GetQueryUGCStatistic(UGCQueryHandle_t handle, uint index, EItemStatistic eStatType, out uint pStatValue);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern uint ISteamUGC_GetQueryUGCNumAdditionalPreviews(UGCQueryHandle_t handle, uint index);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamUGC_GetQueryUGCAdditionalPreview(UGCQueryHandle_t handle, uint index, uint previewIndex, IntPtr pchURLOrVideoID, uint cchURLSize, out bool pbIsImage);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern uint ISteamUGC_GetQueryUGCNumKeyValueTags(UGCQueryHandle_t handle, uint index);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamUGC_GetQueryUGCKeyValueTag(UGCQueryHandle_t handle, uint index, uint keyValueTagIndex, IntPtr pchKey, uint cchKeySize, IntPtr pchValue, uint cchValueSize);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamUGC_ReleaseQueryUGCRequest(UGCQueryHandle_t handle);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamUGC_AddRequiredTag(UGCQueryHandle_t handle, InteropHelp.UTF8StringHandle pTagName);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamUGC_AddExcludedTag(UGCQueryHandle_t handle, InteropHelp.UTF8StringHandle pTagName);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamUGC_SetReturnKeyValueTags(UGCQueryHandle_t handle, [MarshalAs(UnmanagedType.I1)] bool bReturnKeyValueTags);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamUGC_SetReturnLongDescription(UGCQueryHandle_t handle, [MarshalAs(UnmanagedType.I1)] bool bReturnLongDescription);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamUGC_SetReturnMetadata(UGCQueryHandle_t handle, [MarshalAs(UnmanagedType.I1)] bool bReturnMetadata);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamUGC_SetReturnChildren(UGCQueryHandle_t handle, [MarshalAs(UnmanagedType.I1)] bool bReturnChildren);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamUGC_SetReturnAdditionalPreviews(UGCQueryHandle_t handle, [MarshalAs(UnmanagedType.I1)] bool bReturnAdditionalPreviews);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamUGC_SetReturnTotalOnly(UGCQueryHandle_t handle, [MarshalAs(UnmanagedType.I1)] bool bReturnTotalOnly);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamUGC_SetLanguage(UGCQueryHandle_t handle, InteropHelp.UTF8StringHandle pchLanguage);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamUGC_SetAllowCachedResponse(UGCQueryHandle_t handle, uint unMaxAgeSeconds);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamUGC_SetCloudFileNameFilter(UGCQueryHandle_t handle, InteropHelp.UTF8StringHandle pMatchCloudFileName);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamUGC_SetMatchAnyTag(UGCQueryHandle_t handle, [MarshalAs(UnmanagedType.I1)] bool bMatchAnyTag);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamUGC_SetSearchText(UGCQueryHandle_t handle, InteropHelp.UTF8StringHandle pSearchText);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamUGC_SetRankedByTrendDays(UGCQueryHandle_t handle, uint unDays);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamUGC_AddRequiredKeyValueTag(UGCQueryHandle_t handle, InteropHelp.UTF8StringHandle pKey, InteropHelp.UTF8StringHandle pValue);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern ulong ISteamUGC_RequestUGCDetails(PublishedFileId_t nPublishedFileID, uint unMaxAgeSeconds);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern ulong ISteamUGC_CreateItem(AppId_t nConsumerAppId, EWorkshopFileType eFileType);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern ulong ISteamUGC_StartItemUpdate(AppId_t nConsumerAppId, PublishedFileId_t nPublishedFileID);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamUGC_SetItemTitle(UGCUpdateHandle_t handle, InteropHelp.UTF8StringHandle pchTitle);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamUGC_SetItemDescription(UGCUpdateHandle_t handle, InteropHelp.UTF8StringHandle pchDescription);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamUGC_SetItemUpdateLanguage(UGCUpdateHandle_t handle, InteropHelp.UTF8StringHandle pchLanguage);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamUGC_SetItemMetadata(UGCUpdateHandle_t handle, InteropHelp.UTF8StringHandle pchMetaData);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamUGC_SetItemVisibility(UGCUpdateHandle_t handle, ERemoteStoragePublishedFileVisibility eVisibility);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamUGC_SetItemTags(UGCUpdateHandle_t updateHandle, IntPtr pTags);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamUGC_SetItemContent(UGCUpdateHandle_t handle, InteropHelp.UTF8StringHandle pszContentFolder);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamUGC_SetItemPreview(UGCUpdateHandle_t handle, InteropHelp.UTF8StringHandle pszPreviewFile);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamUGC_RemoveItemKeyValueTags(UGCUpdateHandle_t handle, InteropHelp.UTF8StringHandle pchKey);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamUGC_AddItemKeyValueTag(UGCUpdateHandle_t handle, InteropHelp.UTF8StringHandle pchKey, InteropHelp.UTF8StringHandle pchValue);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern ulong ISteamUGC_SubmitItemUpdate(UGCUpdateHandle_t handle, InteropHelp.UTF8StringHandle pchChangeNote);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern EItemUpdateStatus ISteamUGC_GetItemUpdateProgress(UGCUpdateHandle_t handle, out ulong punBytesProcessed, out ulong punBytesTotal);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern ulong ISteamUGC_SetUserItemVote(PublishedFileId_t nPublishedFileID, [MarshalAs(UnmanagedType.I1)] bool bVoteUp);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern ulong ISteamUGC_GetUserItemVote(PublishedFileId_t nPublishedFileID);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern ulong ISteamUGC_AddItemToFavorites(AppId_t nAppId, PublishedFileId_t nPublishedFileID);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern ulong ISteamUGC_RemoveItemFromFavorites(AppId_t nAppId, PublishedFileId_t nPublishedFileID);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern ulong ISteamUGC_SubscribeItem(PublishedFileId_t nPublishedFileID);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern ulong ISteamUGC_UnsubscribeItem(PublishedFileId_t nPublishedFileID);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern uint ISteamUGC_GetNumSubscribedItems();

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern uint ISteamUGC_GetSubscribedItems([In][Out] PublishedFileId_t[] pvecPublishedFileID, uint cMaxEntries);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern uint ISteamUGC_GetItemState(PublishedFileId_t nPublishedFileID);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamUGC_GetItemInstallInfo(PublishedFileId_t nPublishedFileID, out ulong punSizeOnDisk, IntPtr pchFolder, uint cchFolderSize, out uint punTimeStamp);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamUGC_GetItemDownloadInfo(PublishedFileId_t nPublishedFileID, out ulong punBytesDownloaded, out ulong punBytesTotal);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamUGC_DownloadItem(PublishedFileId_t nPublishedFileID, [MarshalAs(UnmanagedType.I1)] bool bHighPriority);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern ulong ISteamUnifiedMessages_SendMethod(InteropHelp.UTF8StringHandle pchServiceMethod, [In][Out] byte[] pRequestBuffer, uint unRequestBufferSize, ulong unContext);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamUnifiedMessages_GetMethodResponseInfo(ClientUnifiedMessageHandle hHandle, out uint punResponseSize, out EResult peResult);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamUnifiedMessages_GetMethodResponseData(ClientUnifiedMessageHandle hHandle, [In][Out] byte[] pResponseBuffer, uint unResponseBufferSize, [MarshalAs(UnmanagedType.I1)] bool bAutoRelease);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamUnifiedMessages_ReleaseMethod(ClientUnifiedMessageHandle hHandle);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamUnifiedMessages_SendNotification(InteropHelp.UTF8StringHandle pchServiceNotification, [In][Out] byte[] pNotificationBuffer, uint unNotificationBufferSize);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern int ISteamUser_GetHSteamUser();

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamUser_BLoggedOn();

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern ulong ISteamUser_GetSteamID();

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern int ISteamUser_InitiateGameConnection([In][Out] byte[] pAuthBlob, int cbMaxAuthBlob, CSteamID steamIDGameServer, uint unIPServer, ushort usPortServer, [MarshalAs(UnmanagedType.I1)] bool bSecure);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ISteamUser_TerminateGameConnection(uint unIPServer, ushort usPortServer);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ISteamUser_TrackAppUsageEvent(CGameID gameID, int eAppUsageEvent, InteropHelp.UTF8StringHandle pchExtraInfo);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamUser_GetUserDataFolder(IntPtr pchBuffer, int cubBuffer);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ISteamUser_StartVoiceRecording();

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ISteamUser_StopVoiceRecording();

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern EVoiceResult ISteamUser_GetAvailableVoice(out uint pcbCompressed, out uint pcbUncompressed, uint nUncompressedVoiceDesiredSampleRate);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern EVoiceResult ISteamUser_GetVoice([MarshalAs(UnmanagedType.I1)] bool bWantCompressed, [In][Out] byte[] pDestBuffer, uint cbDestBufferSize, out uint nBytesWritten, [MarshalAs(UnmanagedType.I1)] bool bWantUncompressed, [In][Out] byte[] pUncompressedDestBuffer, uint cbUncompressedDestBufferSize, out uint nUncompressBytesWritten, uint nUncompressedVoiceDesiredSampleRate);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern EVoiceResult ISteamUser_DecompressVoice([In][Out] byte[] pCompressed, uint cbCompressed, [In][Out] byte[] pDestBuffer, uint cbDestBufferSize, out uint nBytesWritten, uint nDesiredSampleRate);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern uint ISteamUser_GetVoiceOptimalSampleRate();

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern uint ISteamUser_GetAuthSessionTicket([In][Out] byte[] pTicket, int cbMaxTicket, out uint pcbTicket);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern EBeginAuthSessionResult ISteamUser_BeginAuthSession([In][Out] byte[] pAuthTicket, int cbAuthTicket, CSteamID steamID);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ISteamUser_EndAuthSession(CSteamID steamID);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ISteamUser_CancelAuthTicket(HAuthTicket hAuthTicket);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern EUserHasLicenseForAppResult ISteamUser_UserHasLicenseForApp(CSteamID steamID, AppId_t appID);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamUser_BIsBehindNAT();

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ISteamUser_AdvertiseGame(CSteamID steamIDGameServer, uint unIPServer, ushort usPortServer);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern ulong ISteamUser_RequestEncryptedAppTicket([In][Out] byte[] pDataToInclude, int cbDataToInclude);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamUser_GetEncryptedAppTicket([In][Out] byte[] pTicket, int cbMaxTicket, out uint pcbTicket);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern int ISteamUser_GetGameBadgeLevel(int nSeries, [MarshalAs(UnmanagedType.I1)] bool bFoil);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern int ISteamUser_GetPlayerSteamLevel();

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern ulong ISteamUser_RequestStoreAuthURL(InteropHelp.UTF8StringHandle pchRedirectURL);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamUserStats_RequestCurrentStats();

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamUserStats_GetStat(InteropHelp.UTF8StringHandle pchName, out int pData);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamUserStats_GetStat_(InteropHelp.UTF8StringHandle pchName, out float pData);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamUserStats_SetStat(InteropHelp.UTF8StringHandle pchName, int nData);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamUserStats_SetStat_(InteropHelp.UTF8StringHandle pchName, float fData);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamUserStats_UpdateAvgRateStat(InteropHelp.UTF8StringHandle pchName, float flCountThisSession, double dSessionLength);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamUserStats_GetAchievement(InteropHelp.UTF8StringHandle pchName, out bool pbAchieved);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamUserStats_SetAchievement(InteropHelp.UTF8StringHandle pchName);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamUserStats_ClearAchievement(InteropHelp.UTF8StringHandle pchName);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamUserStats_GetAchievementAndUnlockTime(InteropHelp.UTF8StringHandle pchName, out bool pbAchieved, out uint punUnlockTime);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamUserStats_StoreStats();

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern int ISteamUserStats_GetAchievementIcon(InteropHelp.UTF8StringHandle pchName);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr ISteamUserStats_GetAchievementDisplayAttribute(InteropHelp.UTF8StringHandle pchName, InteropHelp.UTF8StringHandle pchKey);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamUserStats_IndicateAchievementProgress(InteropHelp.UTF8StringHandle pchName, uint nCurProgress, uint nMaxProgress);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern uint ISteamUserStats_GetNumAchievements();

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr ISteamUserStats_GetAchievementName(uint iAchievement);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern ulong ISteamUserStats_RequestUserStats(CSteamID steamIDUser);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamUserStats_GetUserStat(CSteamID steamIDUser, InteropHelp.UTF8StringHandle pchName, out int pData);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamUserStats_GetUserStat_(CSteamID steamIDUser, InteropHelp.UTF8StringHandle pchName, out float pData);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamUserStats_GetUserAchievement(CSteamID steamIDUser, InteropHelp.UTF8StringHandle pchName, out bool pbAchieved);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamUserStats_GetUserAchievementAndUnlockTime(CSteamID steamIDUser, InteropHelp.UTF8StringHandle pchName, out bool pbAchieved, out uint punUnlockTime);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamUserStats_ResetAllStats([MarshalAs(UnmanagedType.I1)] bool bAchievementsToo);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern ulong ISteamUserStats_FindOrCreateLeaderboard(InteropHelp.UTF8StringHandle pchLeaderboardName, ELeaderboardSortMethod eLeaderboardSortMethod, ELeaderboardDisplayType eLeaderboardDisplayType);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern ulong ISteamUserStats_FindLeaderboard(InteropHelp.UTF8StringHandle pchLeaderboardName);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr ISteamUserStats_GetLeaderboardName(SteamLeaderboard_t hSteamLeaderboard);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern int ISteamUserStats_GetLeaderboardEntryCount(SteamLeaderboard_t hSteamLeaderboard);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern ELeaderboardSortMethod ISteamUserStats_GetLeaderboardSortMethod(SteamLeaderboard_t hSteamLeaderboard);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern ELeaderboardDisplayType ISteamUserStats_GetLeaderboardDisplayType(SteamLeaderboard_t hSteamLeaderboard);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern ulong ISteamUserStats_DownloadLeaderboardEntries(SteamLeaderboard_t hSteamLeaderboard, ELeaderboardDataRequest eLeaderboardDataRequest, int nRangeStart, int nRangeEnd);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern ulong ISteamUserStats_DownloadLeaderboardEntriesForUsers(SteamLeaderboard_t hSteamLeaderboard, [In][Out] CSteamID[] prgUsers, int cUsers);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamUserStats_GetDownloadedLeaderboardEntry(SteamLeaderboardEntries_t hSteamLeaderboardEntries, int index, out LeaderboardEntry_t pLeaderboardEntry, [In][Out] int[] pDetails, int cDetailsMax);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern ulong ISteamUserStats_UploadLeaderboardScore(SteamLeaderboard_t hSteamLeaderboard, ELeaderboardUploadScoreMethod eLeaderboardUploadScoreMethod, int nScore, [In][Out] int[] pScoreDetails, int cScoreDetailsCount);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern ulong ISteamUserStats_AttachLeaderboardUGC(SteamLeaderboard_t hSteamLeaderboard, UGCHandle_t hUGC);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern ulong ISteamUserStats_GetNumberOfCurrentPlayers();

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern ulong ISteamUserStats_RequestGlobalAchievementPercentages();

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern int ISteamUserStats_GetMostAchievedAchievementInfo(IntPtr pchName, uint unNameBufLen, out float pflPercent, out bool pbAchieved);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern int ISteamUserStats_GetNextMostAchievedAchievementInfo(int iIteratorPrevious, IntPtr pchName, uint unNameBufLen, out float pflPercent, out bool pbAchieved);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamUserStats_GetAchievementAchievedPercent(InteropHelp.UTF8StringHandle pchName, out float pflPercent);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern ulong ISteamUserStats_RequestGlobalStats(int nHistoryDays);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamUserStats_GetGlobalStat(InteropHelp.UTF8StringHandle pchStatName, out long pData);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamUserStats_GetGlobalStat_(InteropHelp.UTF8StringHandle pchStatName, out double pData);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern int ISteamUserStats_GetGlobalStatHistory(InteropHelp.UTF8StringHandle pchStatName, [In][Out] long[] pData, uint cubData);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern int ISteamUserStats_GetGlobalStatHistory_(InteropHelp.UTF8StringHandle pchStatName, [In][Out] double[] pData, uint cubData);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern uint ISteamUtils_GetSecondsSinceAppActive();

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern uint ISteamUtils_GetSecondsSinceComputerActive();

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern EUniverse ISteamUtils_GetConnectedUniverse();

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern uint ISteamUtils_GetServerRealTime();

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr ISteamUtils_GetIPCountry();

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamUtils_GetImageSize(int iImage, out uint pnWidth, out uint pnHeight);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamUtils_GetImageRGBA(int iImage, [In][Out] byte[] pubDest, int nDestBufferSize);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamUtils_GetCSERIPPort(out uint unIP, out ushort usPort);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte ISteamUtils_GetCurrentBatteryPower();

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern uint ISteamUtils_GetAppID();

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ISteamUtils_SetOverlayNotificationPosition(ENotificationPosition eNotificationPosition);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamUtils_IsAPICallCompleted(SteamAPICall_t hSteamAPICall, out bool pbFailed);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern ESteamAPICallFailure ISteamUtils_GetAPICallFailureReason(SteamAPICall_t hSteamAPICall);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamUtils_GetAPICallResult(SteamAPICall_t hSteamAPICall, IntPtr pCallback, int cubCallback, int iCallbackExpected, out bool pbFailed);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ISteamUtils_RunFrame();

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern uint ISteamUtils_GetIPCCallCount();

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ISteamUtils_SetWarningMessageHook(SteamAPIWarningMessageHook_t pFunction);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamUtils_IsOverlayEnabled();

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamUtils_BOverlayNeedsPresent();

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern ulong ISteamUtils_CheckFileSignature(InteropHelp.UTF8StringHandle szFileName);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamUtils_ShowGamepadTextInput(EGamepadTextInputMode eInputMode, EGamepadTextInputLineMode eLineInputMode, InteropHelp.UTF8StringHandle pchDescription, uint unCharMax, InteropHelp.UTF8StringHandle pchExistingText);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern uint ISteamUtils_GetEnteredGamepadTextLength();

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamUtils_GetEnteredGamepadTextInput(IntPtr pchText, uint cchText);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr ISteamUtils_GetSteamUILanguage();

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamUtils_IsSteamRunningInVR();

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ISteamUtils_SetOverlayNotificationInset(int nHorizontalInset, int nVerticalInset);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ISteamVideo_GetVideoURL(AppId_t unVideoAppID);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamVideo_IsBroadcasting(out int pnNumViewers);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern uint ISteamGameServerHTTP_CreateHTTPRequest(EHTTPMethod eHTTPRequestMethod, InteropHelp.UTF8StringHandle pchAbsoluteURL);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamGameServerHTTP_SetHTTPRequestContextValue(HTTPRequestHandle hRequest, ulong ulContextValue);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamGameServerHTTP_SetHTTPRequestNetworkActivityTimeout(HTTPRequestHandle hRequest, uint unTimeoutSeconds);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamGameServerHTTP_SetHTTPRequestHeaderValue(HTTPRequestHandle hRequest, InteropHelp.UTF8StringHandle pchHeaderName, InteropHelp.UTF8StringHandle pchHeaderValue);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamGameServerHTTP_SetHTTPRequestGetOrPostParameter(HTTPRequestHandle hRequest, InteropHelp.UTF8StringHandle pchParamName, InteropHelp.UTF8StringHandle pchParamValue);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamGameServerHTTP_SendHTTPRequest(HTTPRequestHandle hRequest, out SteamAPICall_t pCallHandle);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamGameServerHTTP_SendHTTPRequestAndStreamResponse(HTTPRequestHandle hRequest, out SteamAPICall_t pCallHandle);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamGameServerHTTP_DeferHTTPRequest(HTTPRequestHandle hRequest);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamGameServerHTTP_PrioritizeHTTPRequest(HTTPRequestHandle hRequest);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamGameServerHTTP_GetHTTPResponseHeaderSize(HTTPRequestHandle hRequest, InteropHelp.UTF8StringHandle pchHeaderName, out uint unResponseHeaderSize);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamGameServerHTTP_GetHTTPResponseHeaderValue(HTTPRequestHandle hRequest, InteropHelp.UTF8StringHandle pchHeaderName, [In][Out] byte[] pHeaderValueBuffer, uint unBufferSize);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamGameServerHTTP_GetHTTPResponseBodySize(HTTPRequestHandle hRequest, out uint unBodySize);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamGameServerHTTP_GetHTTPResponseBodyData(HTTPRequestHandle hRequest, [In][Out] byte[] pBodyDataBuffer, uint unBufferSize);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamGameServerHTTP_GetHTTPStreamingResponseBodyData(HTTPRequestHandle hRequest, uint cOffset, [In][Out] byte[] pBodyDataBuffer, uint unBufferSize);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamGameServerHTTP_ReleaseHTTPRequest(HTTPRequestHandle hRequest);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamGameServerHTTP_GetHTTPDownloadProgressPct(HTTPRequestHandle hRequest, out float pflPercentOut);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamGameServerHTTP_SetHTTPRequestRawPostBody(HTTPRequestHandle hRequest, InteropHelp.UTF8StringHandle pchContentType, [In][Out] byte[] pubBody, uint unBodyLen);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern uint ISteamGameServerHTTP_CreateCookieContainer([MarshalAs(UnmanagedType.I1)] bool bAllowResponsesToModify);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamGameServerHTTP_ReleaseCookieContainer(HTTPCookieContainerHandle hCookieContainer);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamGameServerHTTP_SetCookie(HTTPCookieContainerHandle hCookieContainer, InteropHelp.UTF8StringHandle pchHost, InteropHelp.UTF8StringHandle pchUrl, InteropHelp.UTF8StringHandle pchCookie);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamGameServerHTTP_SetHTTPRequestCookieContainer(HTTPRequestHandle hRequest, HTTPCookieContainerHandle hCookieContainer);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamGameServerHTTP_SetHTTPRequestUserAgentInfo(HTTPRequestHandle hRequest, InteropHelp.UTF8StringHandle pchUserAgentInfo);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamGameServerHTTP_SetHTTPRequestRequiresVerifiedCertificate(HTTPRequestHandle hRequest, [MarshalAs(UnmanagedType.I1)] bool bRequireVerifiedCertificate);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamGameServerHTTP_SetHTTPRequestAbsoluteTimeoutMS(HTTPRequestHandle hRequest, uint unMilliseconds);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamGameServerHTTP_GetHTTPRequestWasTimedOut(HTTPRequestHandle hRequest, out bool pbWasTimedOut);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern EResult ISteamGameServerInventory_GetResultStatus(SteamInventoryResult_t resultHandle);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamGameServerInventory_GetResultItems(SteamInventoryResult_t resultHandle, [In][Out] SteamItemDetails_t[] pOutItemsArray, ref uint punOutItemsArraySize);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern uint ISteamGameServerInventory_GetResultTimestamp(SteamInventoryResult_t resultHandle);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamGameServerInventory_CheckResultSteamID(SteamInventoryResult_t resultHandle, CSteamID steamIDExpected);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ISteamGameServerInventory_DestroyResult(SteamInventoryResult_t resultHandle);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamGameServerInventory_GetAllItems(out SteamInventoryResult_t pResultHandle);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamGameServerInventory_GetItemsByID(out SteamInventoryResult_t pResultHandle, [In][Out] SteamItemInstanceID_t[] pInstanceIDs, uint unCountInstanceIDs);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamGameServerInventory_SerializeResult(SteamInventoryResult_t resultHandle, [In][Out] byte[] pOutBuffer, out uint punOutBufferSize);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamGameServerInventory_DeserializeResult(out SteamInventoryResult_t pOutResultHandle, [In][Out] byte[] pBuffer, uint unBufferSize, [MarshalAs(UnmanagedType.I1)] bool bRESERVED_MUST_BE_FALSE);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamGameServerInventory_GenerateItems(out SteamInventoryResult_t pResultHandle, [In][Out] SteamItemDef_t[] pArrayItemDefs, [In][Out] uint[] punArrayQuantity, uint unArrayLength);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamGameServerInventory_GrantPromoItems(out SteamInventoryResult_t pResultHandle);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamGameServerInventory_AddPromoItem(out SteamInventoryResult_t pResultHandle, SteamItemDef_t itemDef);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamGameServerInventory_AddPromoItems(out SteamInventoryResult_t pResultHandle, [In][Out] SteamItemDef_t[] pArrayItemDefs, uint unArrayLength);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamGameServerInventory_ConsumeItem(out SteamInventoryResult_t pResultHandle, SteamItemInstanceID_t itemConsume, uint unQuantity);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamGameServerInventory_ExchangeItems(out SteamInventoryResult_t pResultHandle, [In][Out] SteamItemDef_t[] pArrayGenerate, [In][Out] uint[] punArrayGenerateQuantity, uint unArrayGenerateLength, [In][Out] SteamItemInstanceID_t[] pArrayDestroy, [In][Out] uint[] punArrayDestroyQuantity, uint unArrayDestroyLength);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamGameServerInventory_TransferItemQuantity(out SteamInventoryResult_t pResultHandle, SteamItemInstanceID_t itemIdSource, uint unQuantity, SteamItemInstanceID_t itemIdDest);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ISteamGameServerInventory_SendItemDropHeartbeat();

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamGameServerInventory_TriggerItemDrop(out SteamInventoryResult_t pResultHandle, SteamItemDef_t dropListDefinition);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamGameServerInventory_TradeItems(out SteamInventoryResult_t pResultHandle, CSteamID steamIDTradePartner, [In][Out] SteamItemInstanceID_t[] pArrayGive, [In][Out] uint[] pArrayGiveQuantity, uint nArrayGiveLength, [In][Out] SteamItemInstanceID_t[] pArrayGet, [In][Out] uint[] pArrayGetQuantity, uint nArrayGetLength);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamGameServerInventory_LoadItemDefinitions();

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamGameServerInventory_GetItemDefinitionIDs([In][Out] SteamItemDef_t[] pItemDefIDs, out uint punItemDefIDsArraySize);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamGameServerInventory_GetItemDefinitionProperty(SteamItemDef_t iDefinition, InteropHelp.UTF8StringHandle pchPropertyName, IntPtr pchValueBuffer, ref uint punValueBufferSize);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamGameServerNetworking_SendP2PPacket(CSteamID steamIDRemote, [In][Out] byte[] pubData, uint cubData, EP2PSend eP2PSendType, int nChannel);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamGameServerNetworking_IsP2PPacketAvailable(out uint pcubMsgSize, int nChannel);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamGameServerNetworking_ReadP2PPacket([In][Out] byte[] pubDest, uint cubDest, out uint pcubMsgSize, out CSteamID psteamIDRemote, int nChannel);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamGameServerNetworking_AcceptP2PSessionWithUser(CSteamID steamIDRemote);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamGameServerNetworking_CloseP2PSessionWithUser(CSteamID steamIDRemote);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamGameServerNetworking_CloseP2PChannelWithUser(CSteamID steamIDRemote, int nChannel);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamGameServerNetworking_GetP2PSessionState(CSteamID steamIDRemote, out P2PSessionState_t pConnectionState);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamGameServerNetworking_AllowP2PPacketRelay([MarshalAs(UnmanagedType.I1)] bool bAllow);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern uint ISteamGameServerNetworking_CreateListenSocket(int nVirtualP2PPort, uint nIP, ushort nPort, [MarshalAs(UnmanagedType.I1)] bool bAllowUseOfPacketRelay);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern uint ISteamGameServerNetworking_CreateP2PConnectionSocket(CSteamID steamIDTarget, int nVirtualPort, int nTimeoutSec, [MarshalAs(UnmanagedType.I1)] bool bAllowUseOfPacketRelay);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern uint ISteamGameServerNetworking_CreateConnectionSocket(uint nIP, ushort nPort, int nTimeoutSec);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamGameServerNetworking_DestroySocket(SNetSocket_t hSocket, [MarshalAs(UnmanagedType.I1)] bool bNotifyRemoteEnd);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamGameServerNetworking_DestroyListenSocket(SNetListenSocket_t hSocket, [MarshalAs(UnmanagedType.I1)] bool bNotifyRemoteEnd);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamGameServerNetworking_SendDataOnSocket(SNetSocket_t hSocket, IntPtr pubData, uint cubData, [MarshalAs(UnmanagedType.I1)] bool bReliable);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamGameServerNetworking_IsDataAvailableOnSocket(SNetSocket_t hSocket, out uint pcubMsgSize);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamGameServerNetworking_RetrieveDataFromSocket(SNetSocket_t hSocket, IntPtr pubDest, uint cubDest, out uint pcubMsgSize);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamGameServerNetworking_IsDataAvailable(SNetListenSocket_t hListenSocket, out uint pcubMsgSize, out SNetSocket_t phSocket);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamGameServerNetworking_RetrieveData(SNetListenSocket_t hListenSocket, IntPtr pubDest, uint cubDest, out uint pcubMsgSize, out SNetSocket_t phSocket);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamGameServerNetworking_GetSocketInfo(SNetSocket_t hSocket, out CSteamID pSteamIDRemote, out int peSocketStatus, out uint punIPRemote, out ushort punPortRemote);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamGameServerNetworking_GetListenSocketInfo(SNetListenSocket_t hListenSocket, out uint pnIP, out ushort pnPort);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern ESNetSocketConnectionType ISteamGameServerNetworking_GetSocketConnectionType(SNetSocket_t hSocket);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern int ISteamGameServerNetworking_GetMaxPacketSize(SNetSocket_t hSocket);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern ulong ISteamGameServerUGC_CreateQueryUserUGCRequest(AccountID_t unAccountID, EUserUGCList eListType, EUGCMatchingUGCType eMatchingUGCType, EUserUGCListSortOrder eSortOrder, AppId_t nCreatorAppID, AppId_t nConsumerAppID, uint unPage);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern ulong ISteamGameServerUGC_CreateQueryAllUGCRequest(EUGCQuery eQueryType, EUGCMatchingUGCType eMatchingeMatchingUGCTypeFileType, AppId_t nCreatorAppID, AppId_t nConsumerAppID, uint unPage);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern ulong ISteamGameServerUGC_CreateQueryUGCDetailsRequest([In][Out] PublishedFileId_t[] pvecPublishedFileID, uint unNumPublishedFileIDs);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern ulong ISteamGameServerUGC_SendQueryUGCRequest(UGCQueryHandle_t handle);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamGameServerUGC_GetQueryUGCResult(UGCQueryHandle_t handle, uint index, out SteamUGCDetails_t pDetails);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamGameServerUGC_GetQueryUGCPreviewURL(UGCQueryHandle_t handle, uint index, IntPtr pchURL, uint cchURLSize);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamGameServerUGC_GetQueryUGCMetadata(UGCQueryHandle_t handle, uint index, IntPtr pchMetadata, uint cchMetadatasize);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamGameServerUGC_GetQueryUGCChildren(UGCQueryHandle_t handle, uint index, [In][Out] PublishedFileId_t[] pvecPublishedFileID, uint cMaxEntries);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamGameServerUGC_GetQueryUGCStatistic(UGCQueryHandle_t handle, uint index, EItemStatistic eStatType, out uint pStatValue);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern uint ISteamGameServerUGC_GetQueryUGCNumAdditionalPreviews(UGCQueryHandle_t handle, uint index);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamGameServerUGC_GetQueryUGCAdditionalPreview(UGCQueryHandle_t handle, uint index, uint previewIndex, IntPtr pchURLOrVideoID, uint cchURLSize, out bool pbIsImage);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern uint ISteamGameServerUGC_GetQueryUGCNumKeyValueTags(UGCQueryHandle_t handle, uint index);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamGameServerUGC_GetQueryUGCKeyValueTag(UGCQueryHandle_t handle, uint index, uint keyValueTagIndex, IntPtr pchKey, uint cchKeySize, IntPtr pchValue, uint cchValueSize);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamGameServerUGC_ReleaseQueryUGCRequest(UGCQueryHandle_t handle);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamGameServerUGC_AddRequiredTag(UGCQueryHandle_t handle, InteropHelp.UTF8StringHandle pTagName);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamGameServerUGC_AddExcludedTag(UGCQueryHandle_t handle, InteropHelp.UTF8StringHandle pTagName);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamGameServerUGC_SetReturnKeyValueTags(UGCQueryHandle_t handle, [MarshalAs(UnmanagedType.I1)] bool bReturnKeyValueTags);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamGameServerUGC_SetReturnLongDescription(UGCQueryHandle_t handle, [MarshalAs(UnmanagedType.I1)] bool bReturnLongDescription);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamGameServerUGC_SetReturnMetadata(UGCQueryHandle_t handle, [MarshalAs(UnmanagedType.I1)] bool bReturnMetadata);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamGameServerUGC_SetReturnChildren(UGCQueryHandle_t handle, [MarshalAs(UnmanagedType.I1)] bool bReturnChildren);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamGameServerUGC_SetReturnAdditionalPreviews(UGCQueryHandle_t handle, [MarshalAs(UnmanagedType.I1)] bool bReturnAdditionalPreviews);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamGameServerUGC_SetReturnTotalOnly(UGCQueryHandle_t handle, [MarshalAs(UnmanagedType.I1)] bool bReturnTotalOnly);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamGameServerUGC_SetLanguage(UGCQueryHandle_t handle, InteropHelp.UTF8StringHandle pchLanguage);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamGameServerUGC_SetAllowCachedResponse(UGCQueryHandle_t handle, uint unMaxAgeSeconds);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamGameServerUGC_SetCloudFileNameFilter(UGCQueryHandle_t handle, InteropHelp.UTF8StringHandle pMatchCloudFileName);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamGameServerUGC_SetMatchAnyTag(UGCQueryHandle_t handle, [MarshalAs(UnmanagedType.I1)] bool bMatchAnyTag);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamGameServerUGC_SetSearchText(UGCQueryHandle_t handle, InteropHelp.UTF8StringHandle pSearchText);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamGameServerUGC_SetRankedByTrendDays(UGCQueryHandle_t handle, uint unDays);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamGameServerUGC_AddRequiredKeyValueTag(UGCQueryHandle_t handle, InteropHelp.UTF8StringHandle pKey, InteropHelp.UTF8StringHandle pValue);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern ulong ISteamGameServerUGC_RequestUGCDetails(PublishedFileId_t nPublishedFileID, uint unMaxAgeSeconds);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern ulong ISteamGameServerUGC_CreateItem(AppId_t nConsumerAppId, EWorkshopFileType eFileType);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern ulong ISteamGameServerUGC_StartItemUpdate(AppId_t nConsumerAppId, PublishedFileId_t nPublishedFileID);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamGameServerUGC_SetItemTitle(UGCUpdateHandle_t handle, InteropHelp.UTF8StringHandle pchTitle);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamGameServerUGC_SetItemDescription(UGCUpdateHandle_t handle, InteropHelp.UTF8StringHandle pchDescription);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamGameServerUGC_SetItemUpdateLanguage(UGCUpdateHandle_t handle, InteropHelp.UTF8StringHandle pchLanguage);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamGameServerUGC_SetItemMetadata(UGCUpdateHandle_t handle, InteropHelp.UTF8StringHandle pchMetaData);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamGameServerUGC_SetItemVisibility(UGCUpdateHandle_t handle, ERemoteStoragePublishedFileVisibility eVisibility);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamGameServerUGC_SetItemTags(UGCUpdateHandle_t updateHandle, IntPtr pTags);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamGameServerUGC_SetItemContent(UGCUpdateHandle_t handle, InteropHelp.UTF8StringHandle pszContentFolder);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamGameServerUGC_SetItemPreview(UGCUpdateHandle_t handle, InteropHelp.UTF8StringHandle pszPreviewFile);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamGameServerUGC_RemoveItemKeyValueTags(UGCUpdateHandle_t handle, InteropHelp.UTF8StringHandle pchKey);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamGameServerUGC_AddItemKeyValueTag(UGCUpdateHandle_t handle, InteropHelp.UTF8StringHandle pchKey, InteropHelp.UTF8StringHandle pchValue);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern ulong ISteamGameServerUGC_SubmitItemUpdate(UGCUpdateHandle_t handle, InteropHelp.UTF8StringHandle pchChangeNote);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern EItemUpdateStatus ISteamGameServerUGC_GetItemUpdateProgress(UGCUpdateHandle_t handle, out ulong punBytesProcessed, out ulong punBytesTotal);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern ulong ISteamGameServerUGC_SetUserItemVote(PublishedFileId_t nPublishedFileID, [MarshalAs(UnmanagedType.I1)] bool bVoteUp);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern ulong ISteamGameServerUGC_GetUserItemVote(PublishedFileId_t nPublishedFileID);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern ulong ISteamGameServerUGC_AddItemToFavorites(AppId_t nAppId, PublishedFileId_t nPublishedFileID);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern ulong ISteamGameServerUGC_RemoveItemFromFavorites(AppId_t nAppId, PublishedFileId_t nPublishedFileID);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern ulong ISteamGameServerUGC_SubscribeItem(PublishedFileId_t nPublishedFileID);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern ulong ISteamGameServerUGC_UnsubscribeItem(PublishedFileId_t nPublishedFileID);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern uint ISteamGameServerUGC_GetNumSubscribedItems();

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern uint ISteamGameServerUGC_GetSubscribedItems([In][Out] PublishedFileId_t[] pvecPublishedFileID, uint cMaxEntries);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern uint ISteamGameServerUGC_GetItemState(PublishedFileId_t nPublishedFileID);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamGameServerUGC_GetItemInstallInfo(PublishedFileId_t nPublishedFileID, out ulong punSizeOnDisk, IntPtr pchFolder, uint cchFolderSize, out uint punTimeStamp);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamGameServerUGC_GetItemDownloadInfo(PublishedFileId_t nPublishedFileID, out ulong punBytesDownloaded, out ulong punBytesTotal);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamGameServerUGC_DownloadItem(PublishedFileId_t nPublishedFileID, [MarshalAs(UnmanagedType.I1)] bool bHighPriority);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern uint ISteamGameServerUtils_GetSecondsSinceAppActive();

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern uint ISteamGameServerUtils_GetSecondsSinceComputerActive();

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern EUniverse ISteamGameServerUtils_GetConnectedUniverse();

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern uint ISteamGameServerUtils_GetServerRealTime();

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr ISteamGameServerUtils_GetIPCountry();

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamGameServerUtils_GetImageSize(int iImage, out uint pnWidth, out uint pnHeight);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamGameServerUtils_GetImageRGBA(int iImage, [In][Out] byte[] pubDest, int nDestBufferSize);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamGameServerUtils_GetCSERIPPort(out uint unIP, out ushort usPort);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte ISteamGameServerUtils_GetCurrentBatteryPower();

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern uint ISteamGameServerUtils_GetAppID();

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ISteamGameServerUtils_SetOverlayNotificationPosition(ENotificationPosition eNotificationPosition);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamGameServerUtils_IsAPICallCompleted(SteamAPICall_t hSteamAPICall, out bool pbFailed);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern ESteamAPICallFailure ISteamGameServerUtils_GetAPICallFailureReason(SteamAPICall_t hSteamAPICall);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamGameServerUtils_GetAPICallResult(SteamAPICall_t hSteamAPICall, IntPtr pCallback, int cubCallback, int iCallbackExpected, out bool pbFailed);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ISteamGameServerUtils_RunFrame();

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern uint ISteamGameServerUtils_GetIPCCallCount();

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ISteamGameServerUtils_SetWarningMessageHook(SteamAPIWarningMessageHook_t pFunction);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamGameServerUtils_IsOverlayEnabled();

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamGameServerUtils_BOverlayNeedsPresent();

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern ulong ISteamGameServerUtils_CheckFileSignature(InteropHelp.UTF8StringHandle szFileName);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamGameServerUtils_ShowGamepadTextInput(EGamepadTextInputMode eInputMode, EGamepadTextInputLineMode eLineInputMode, InteropHelp.UTF8StringHandle pchDescription, uint unCharMax, InteropHelp.UTF8StringHandle pchExistingText);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern uint ISteamGameServerUtils_GetEnteredGamepadTextLength();

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamGameServerUtils_GetEnteredGamepadTextInput(IntPtr pchText, uint cchText);

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr ISteamGameServerUtils_GetSteamUILanguage();

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool ISteamGameServerUtils_IsSteamRunningInVR();

		[DllImport("CSteamworks", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ISteamGameServerUtils_SetOverlayNotificationInset(int nHorizontalInset, int nVerticalInset);
	}
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	[CallbackIdentity(3901)]
	public struct SteamAppInstalled_t
	{
		public const int k_iCallback = 3901;

		public AppId_t m_nAppID;
	}
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	[CallbackIdentity(3902)]
	public struct SteamAppUninstalled_t
	{
		public const int k_iCallback = 3902;

		public AppId_t m_nAppID;
	}
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	[CallbackIdentity(1005)]
	public struct DlcInstalled_t
	{
		public const int k_iCallback = 1005;

		public AppId_t m_nAppID;
	}
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	[CallbackIdentity(1008)]
	public struct RegisterActivationCodeResponse_t
	{
		public const int k_iCallback = 1008;

		public ERegisterActivationCodeResult m_eResult;

		public uint m_unPackageRegistered;
	}
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	[CallbackIdentity(1013)]
	public struct AppProofOfPurchaseKeyResponse_t
	{
		public const int k_iCallback = 1013;

		public EResult m_eResult;

		public uint m_nAppID;

		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
		public string m_rgchKey;
	}
	[StructLayout(LayoutKind.Sequential, Pack = 8, Size = 1)]
	[CallbackIdentity(1014)]
	public struct NewLaunchQueryParameters_t
	{
		public const int k_iCallback = 1014;
	}
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	[CallbackIdentity(304)]
	public struct PersonaStateChange_t
	{
		public const int k_iCallback = 304;

		public ulong m_ulSteamID;

		public EPersonaChange m_nChangeFlags;
	}
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	[CallbackIdentity(331)]
	public struct GameOverlayActivated_t
	{
		public const int k_iCallback = 331;

		public byte m_bActive;
	}
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	[CallbackIdentity(332)]
	public struct GameServerChangeRequested_t
	{
		public const int k_iCallback = 332;

		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
		public string m_rgchServer;

		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
		public string m_rgchPassword;
	}
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	[CallbackIdentity(333)]
	public struct GameLobbyJoinRequested_t
	{
		public const int k_iCallback = 333;

		public CSteamID m_steamIDLobby;

		public CSteamID m_steamIDFriend;
	}
	[StructLayout(LayoutKind.Sequential, Pack = 4)]
	[CallbackIdentity(334)]
	public struct AvatarImageLoaded_t
	{
		public const int k_iCallback = 334;

		public CSteamID m_steamID;

		public int m_iImage;

		public int m_iWide;

		public int m_iTall;
	}
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	[CallbackIdentity(335)]
	public struct ClanOfficerListResponse_t
	{
		public const int k_iCallback = 335;

		public CSteamID m_steamIDClan;

		public int m_cOfficers;

		public byte m_bSuccess;
	}
	[StructLayout(LayoutKind.Sequential, Pack = 4)]
	[CallbackIdentity(336)]
	public struct FriendRichPresenceUpdate_t
	{
		public const int k_iCallback = 336;

		public CSteamID m_steamIDFriend;

		public AppId_t m_nAppID;
	}
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	[CallbackIdentity(337)]
	public struct GameRichPresenceJoinRequested_t
	{
		public const int k_iCallback = 337;

		public CSteamID m_steamIDFriend;

		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 256)]
		public string m_rgchConnect;
	}
	[StructLayout(LayoutKind.Sequential, Pack = 4)]
	[CallbackIdentity(338)]
	public struct GameConnectedClanChatMsg_t
	{
		public const int k_iCallback = 338;

		public CSteamID m_steamIDClanChat;

		public CSteamID m_steamIDUser;

		public int m_iMessageID;
	}
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	[CallbackIdentity(339)]
	public struct GameConnectedChatJoin_t
	{
		public const int k_iCallback = 339;

		public CSteamID m_steamIDClanChat;

		public CSteamID m_steamIDUser;
	}
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	[CallbackIdentity(340)]
	public struct GameConnectedChatLeave_t
	{
		public const int k_iCallback = 340;

		public CSteamID m_steamIDClanChat;

		public CSteamID m_steamIDUser;

		[MarshalAs(UnmanagedType.I1)]
		public bool m_bKicked;

		[MarshalAs(UnmanagedType.I1)]
		public bool m_bDropped;
	}
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	[CallbackIdentity(341)]
	public struct DownloadClanActivityCountsResult_t
	{
		public const int k_iCallback = 341;

		[MarshalAs(UnmanagedType.I1)]
		public bool m_bSuccess;
	}
	[StructLayout(LayoutKind.Sequential, Pack = 4)]
	[CallbackIdentity(342)]
	public struct JoinClanChatRoomCompletionResult_t
	{
		public const int k_iCallback = 342;

		public CSteamID m_steamIDClanChat;

		public EChatRoomEnterResponse m_eChatRoomEnterResponse;
	}
	[StructLayout(LayoutKind.Sequential, Pack = 4)]
	[CallbackIdentity(343)]
	public struct GameConnectedFriendChatMsg_t
	{
		public const int k_iCallback = 343;

		public CSteamID m_steamIDUser;

		public int m_iMessageID;
	}
	[StructLayout(LayoutKind.Sequential, Pack = 4)]
	[CallbackIdentity(344)]
	public struct FriendsGetFollowerCount_t
	{
		public const int k_iCallback = 344;

		public EResult m_eResult;

		public CSteamID m_steamID;

		public int m_nCount;
	}
	[StructLayout(LayoutKind.Sequential, Pack = 4)]
	[CallbackIdentity(345)]
	public struct FriendsIsFollowing_t
	{
		public const int k_iCallback = 345;

		public EResult m_eResult;

		public CSteamID m_steamID;

		[MarshalAs(UnmanagedType.I1)]
		public bool m_bIsFollowing;
	}
	[StructLayout(LayoutKind.Sequential, Pack = 4)]
	[CallbackIdentity(346)]
	public struct FriendsEnumerateFollowingList_t
	{
		public const int k_iCallback = 346;

		public EResult m_eResult;

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 50)]
		public CSteamID[] m_rgSteamID;

		public int m_nResultsReturned;

		public int m_nTotalResultCount;
	}
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	[CallbackIdentity(347)]
	public struct SetPersonaNameResponse_t
	{
		public const int k_iCallback = 347;

		[MarshalAs(UnmanagedType.I1)]
		public bool m_bSuccess;

		[MarshalAs(UnmanagedType.I1)]
		public bool m_bLocalSuccess;

		public EResult m_result;
	}
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	[CallbackIdentity(1701)]
	public struct GCMessageAvailable_t
	{
		public const int k_iCallback = 1701;

		public uint m_nMessageSize;
	}
	[StructLayout(LayoutKind.Sequential, Pack = 8, Size = 1)]
	[CallbackIdentity(1702)]
	public struct GCMessageFailed_t
	{
		public const int k_iCallback = 1702;
	}
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	[CallbackIdentity(201)]
	public struct GSClientApprove_t
	{
		public const int k_iCallback = 201;

		public CSteamID m_SteamID;

		public CSteamID m_OwnerSteamID;
	}
	[StructLayout(LayoutKind.Sequential, Pack = 4)]
	[CallbackIdentity(202)]
	public struct GSClientDeny_t
	{
		public const int k_iCallback = 202;

		public CSteamID m_SteamID;

		public EDenyReason m_eDenyReason;

		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
		public string m_rgchOptionalText;
	}
	[StructLayout(LayoutKind.Sequential, Pack = 4)]
	[CallbackIdentity(203)]
	public struct GSClientKick_t
	{
		public const int k_iCallback = 203;

		public CSteamID m_SteamID;

		public EDenyReason m_eDenyReason;
	}
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	[CallbackIdentity(206)]
	public struct GSClientAchievementStatus_t
	{
		public const int k_iCallback = 206;

		public ulong m_SteamID;

		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
		public string m_pchAchievement;

		[MarshalAs(UnmanagedType.I1)]
		public bool m_bUnlocked;
	}
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	[CallbackIdentity(115)]
	public struct GSPolicyResponse_t
	{
		public const int k_iCallback = 115;

		public byte m_bSecure;
	}
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	[CallbackIdentity(207)]
	public struct GSGameplayStats_t
	{
		public const int k_iCallback = 207;

		public EResult m_eResult;

		public int m_nRank;

		public uint m_unTotalConnects;

		public uint m_unTotalMinutesPlayed;
	}
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	[CallbackIdentity(208)]
	public struct GSClientGroupStatus_t
	{
		public const int k_iCallback = 208;

		public CSteamID m_SteamIDUser;

		public CSteamID m_SteamIDGroup;

		[MarshalAs(UnmanagedType.I1)]
		public bool m_bMember;

		[MarshalAs(UnmanagedType.I1)]
		public bool m_bOfficer;
	}
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	[CallbackIdentity(209)]
	public struct GSReputation_t
	{
		public const int k_iCallback = 209;

		public EResult m_eResult;

		public uint m_unReputationScore;

		[MarshalAs(UnmanagedType.I1)]
		public bool m_bBanned;

		public uint m_unBannedIP;

		public ushort m_usBannedPort;

		public ulong m_ulBannedGameID;

		public uint m_unBanExpires;
	}
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	[CallbackIdentity(210)]
	public struct AssociateWithClanResult_t
	{
		public const int k_iCallback = 210;

		public EResult m_eResult;
	}
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	[CallbackIdentity(211)]
	public struct ComputeNewPlayerCompatibilityResult_t
	{
		public const int k_iCallback = 211;

		public EResult m_eResult;

		public int m_cPlayersThatDontLikeCandidate;

		public int m_cPlayersThatCandidateDoesntLike;

		public int m_cClanPlayersThatDontLikeCandidate;

		public CSteamID m_SteamIDCandidate;
	}
	[StructLayout(LayoutKind.Sequential, Pack = 4)]
	[CallbackIdentity(1800)]
	public struct GSStatsReceived_t
	{
		public const int k_iCallback = 1800;

		public EResult m_eResult;

		public CSteamID m_steamIDUser;
	}
	[StructLayout(LayoutKind.Sequential, Pack = 4)]
	[CallbackIdentity(1801)]
	public struct GSStatsStored_t
	{
		public const int k_iCallback = 1801;

		public EResult m_eResult;

		public CSteamID m_steamIDUser;
	}
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	[CallbackIdentity(1108)]
	public struct GSStatsUnloaded_t
	{
		public const int k_iCallback = 1108;

		public CSteamID m_steamIDUser;
	}
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	[CallbackIdentity(4501)]
	public struct HTML_BrowserReady_t
	{
		public const int k_iCallback = 4501;

		public HHTMLBrowser unBrowserHandle;
	}
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	[CallbackIdentity(4502)]
	public struct HTML_NeedsPaint_t
	{
		public const int k_iCallback = 4502;

		public HHTMLBrowser unBrowserHandle;

		public IntPtr pBGRA;

		public uint unWide;

		public uint unTall;

		public uint unUpdateX;

		public uint unUpdateY;

		public uint unUpdateWide;

		public uint unUpdateTall;

		public uint unScrollX;

		public uint unScrollY;

		public float flPageScale;

		public uint unPageSerial;
	}
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	[CallbackIdentity(4503)]
	public struct HTML_StartRequest_t
	{
		public const int k_iCallback = 4503;

		public HHTMLBrowser unBrowserHandle;

		public string pchURL;

		public string pchTarget;

		public string pchPostData;

		[MarshalAs(UnmanagedType.I1)]
		public bool bIsRedirect;
	}
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	[CallbackIdentity(4504)]
	public struct HTML_CloseBrowser_t
	{
		public const int k_iCallback = 4504;

		public HHTMLBrowser unBrowserHandle;
	}
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	[CallbackIdentity(4505)]
	public struct HTML_URLChanged_t
	{
		public const int k_iCallback = 4505;

		public HHTMLBrowser unBrowserHandle;

		public string pchURL;

		public string pchPostData;

		[MarshalAs(UnmanagedType.I1)]
		public bool bIsRedirect;

		public string pchPageTitle;

		[MarshalAs(UnmanagedType.I1)]
		public bool bNewNavigation;
	}
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	[CallbackIdentity(4506)]
	public struct HTML_FinishedRequest_t
	{
		public const int k_iCallback = 4506;

		public HHTMLBrowser unBrowserHandle;

		public string pchURL;

		public string pchPageTitle;
	}
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	[CallbackIdentity(4507)]
	public struct HTML_OpenLinkInNewTab_t
	{
		public const int k_iCallback = 4507;

		public HHTMLBrowser unBrowserHandle;

		public string pchURL;
	}
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	[CallbackIdentity(4508)]
	public struct HTML_ChangedTitle_t
	{
		public const int k_iCallback = 4508;

		public HHTMLBrowser unBrowserHandle;

		public string pchTitle;
	}
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	[CallbackIdentity(4509)]
	public struct HTML_SearchResults_t
	{
		public const int k_iCallback = 4509;

		public HHTMLBrowser unBrowserHandle;

		public uint unResults;

		public uint unCurrentMatch;
	}
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	[CallbackIdentity(4510)]
	public struct HTML_CanGoBackAndForward_t
	{
		public const int k_iCallback = 4510;

		public HHTMLBrowser unBrowserHandle;

		[MarshalAs(UnmanagedType.I1)]
		public bool bCanGoBack;

		[MarshalAs(UnmanagedType.I1)]
		public bool bCanGoForward;
	}
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	[CallbackIdentity(4511)]
	public struct HTML_HorizontalScroll_t
	{
		public const int k_iCallback = 4511;

		public HHTMLBrowser unBrowserHandle;

		public uint unScrollMax;

		public uint unScrollCurrent;

		public float flPageScale;

		[MarshalAs(UnmanagedType.I1)]
		public bool bVisible;

		public uint unPageSize;
	}
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	[CallbackIdentity(4512)]
	public struct HTML_VerticalScroll_t
	{
		public const int k_iCallback = 4512;

		public HHTMLBrowser unBrowserHandle;

		public uint unScrollMax;

		public uint unScrollCurrent;

		public float flPageScale;

		[MarshalAs(UnmanagedType.I1)]
		public bool bVisible;

		public uint unPageSize;
	}
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	[CallbackIdentity(4513)]
	public struct HTML_LinkAtPosition_t
	{
		public const int k_iCallback = 4513;

		public HHTMLBrowser unBrowserHandle;

		public uint x;

		public uint y;

		public string pchURL;

		[MarshalAs(UnmanagedType.I1)]
		public bool bInput;

		[MarshalAs(UnmanagedType.I1)]
		public bool bLiveLink;
	}
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	[CallbackIdentity(4514)]
	public struct HTML_JSAlert_t
	{
		public const int k_iCallback = 4514;

		public HHTMLBrowser unBrowserHandle;

		public string pchMessage;
	}
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	[CallbackIdentity(4515)]
	public struct HTML_JSConfirm_t
	{
		public const int k_iCallback = 4515;

		public HHTMLBrowser unBrowserHandle;

		public string pchMessage;
	}
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	[CallbackIdentity(4516)]
	public struct HTML_FileOpenDialog_t
	{
		public const int k_iCallback = 4516;

		public HHTMLBrowser unBrowserHandle;

		public string pchTitle;

		public string pchInitialFile;
	}
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	[CallbackIdentity(4521)]
	public struct HTML_NewWindow_t
	{
		public const int k_iCallback = 4521;

		public HHTMLBrowser unBrowserHandle;

		public string pchURL;

		public uint unX;

		public uint unY;

		public uint unWide;

		public uint unTall;

		public HHTMLBrowser unNewWindow_BrowserHandle;
	}
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	[CallbackIdentity(4522)]
	public struct HTML_SetCursor_t
	{
		public const int k_iCallback = 4522;

		public HHTMLBrowser unBrowserHandle;

		public uint eMouseCursor;
	}
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	[CallbackIdentity(4523)]
	public struct HTML_StatusText_t
	{
		public const int k_iCallback = 4523;

		public HHTMLBrowser unBrowserHandle;

		public string pchMsg;
	}
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	[CallbackIdentity(4524)]
	public struct HTML_ShowToolTip_t
	{
		public const int k_iCallback = 4524;

		public HHTMLBrowser unBrowserHandle;

		public string pchMsg;
	}
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	[CallbackIdentity(4525)]
	public struct HTML_UpdateToolTip_t
	{
		public const int k_iCallback = 4525;

		public HHTMLBrowser unBrowserHandle;

		public string pchMsg;
	}
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	[CallbackIdentity(4526)]
	public struct HTML_HideToolTip_t
	{
		public const int k_iCallback = 4526;

		public HHTMLBrowser unBrowserHandle;
	}
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	[CallbackIdentity(2101)]
	public struct HTTPRequestCompleted_t
	{
		public const int k_iCallback = 2101;

		public HTTPRequestHandle m_hRequest;

		public ulong m_ulContextValue;

		[MarshalAs(UnmanagedType.I1)]
		public bool m_bRequestSuccessful;

		public EHTTPStatusCode m_eStatusCode;

		public uint m_unBodySize;
	}
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	[CallbackIdentity(2102)]
	public struct HTTPRequestHeadersReceived_t
	{
		public const int k_iCallback = 2102;

		public HTTPRequestHandle m_hRequest;

		public ulong m_ulContextValue;
	}
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	[CallbackIdentity(2103)]
	public struct HTTPRequestDataReceived_t
	{
		public const int k_iCallback = 2103;

		public HTTPRequestHandle m_hRequest;

		public ulong m_ulContextValue;

		public uint m_cOffset;

		public uint m_cBytesReceived;
	}
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	[CallbackIdentity(4700)]
	public struct SteamInventoryResultReady_t
	{
		public const int k_iCallback = 4700;

		public SteamInventoryResult_t m_handle;

		public EResult m_result;
	}
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	[CallbackIdentity(4701)]
	public struct SteamInventoryFullUpdate_t
	{
		public const int k_iCallback = 4701;

		public SteamInventoryResult_t m_handle;
	}
	[StructLayout(LayoutKind.Sequential, Pack = 8, Size = 1)]
	[CallbackIdentity(4702)]
	public struct SteamInventoryDefinitionUpdate_t
	{
		public const int k_iCallback = 4702;
	}
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	[CallbackIdentity(502)]
	public struct FavoritesListChanged_t
	{
		public const int k_iCallback = 502;

		public uint m_nIP;

		public uint m_nQueryPort;

		public uint m_nConnPort;

		public uint m_nAppID;

		public uint m_nFlags;

		[MarshalAs(UnmanagedType.I1)]
		public bool m_bAdd;

		public AccountID_t m_unAccountId;
	}
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	[CallbackIdentity(503)]
	public struct LobbyInvite_t
	{
		public const int k_iCallback = 503;

		public ulong m_ulSteamIDUser;

		public ulong m_ulSteamIDLobby;

		public ulong m_ulGameID;
	}
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	[CallbackIdentity(504)]
	public struct LobbyEnter_t
	{
		public const int k_iCallback = 504;

		public ulong m_ulSteamIDLobby;

		public uint m_rgfChatPermissions;

		[MarshalAs(UnmanagedType.I1)]
		public bool m_bLocked;

		public uint m_EChatRoomEnterResponse;
	}
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	[CallbackIdentity(505)]
	public struct LobbyDataUpdate_t
	{
		public const int k_iCallback = 505;

		public ulong m_ulSteamIDLobby;

		public ulong m_ulSteamIDMember;

		public byte m_bSuccess;
	}
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	[CallbackIdentity(506)]
	public struct LobbyChatUpdate_t
	{
		public const int k_iCallback = 506;

		public ulong m_ulSteamIDLobby;

		public ulong m_ulSteamIDUserChanged;

		public ulong m_ulSteamIDMakingChange;

		public uint m_rgfChatMemberStateChange;
	}
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	[CallbackIdentity(507)]
	public struct LobbyChatMsg_t
	{
		public const int k_iCallback = 507;

		public ulong m_ulSteamIDLobby;

		public ulong m_ulSteamIDUser;

		public byte m_eChatEntryType;

		public uint m_iChatID;
	}
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	[CallbackIdentity(509)]
	public struct LobbyGameCreated_t
	{
		public const int k_iCallback = 509;

		public ulong m_ulSteamIDLobby;

		public ulong m_ulSteamIDGameServer;

		public uint m_unIP;

		public ushort m_usPort;
	}
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	[CallbackIdentity(510)]
	public struct LobbyMatchList_t
	{
		public const int k_iCallback = 510;

		public uint m_nLobbiesMatching;
	}
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	[CallbackIdentity(512)]
	public struct LobbyKicked_t
	{
		public const int k_iCallback = 512;

		public ulong m_ulSteamIDLobby;

		public ulong m_ulSteamIDAdmin;

		public byte m_bKickedDueToDisconnect;
	}
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	[CallbackIdentity(513)]
	public struct LobbyCreated_t
	{
		public const int k_iCallback = 513;

		public EResult m_eResult;

		public ulong m_ulSteamIDLobby;
	}
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	[CallbackIdentity(516)]
	public struct FavoritesListAccountsUpdated_t
	{
		public const int k_iCallback = 516;

		public EResult m_eResult;
	}
	[StructLayout(LayoutKind.Sequential, Pack = 8, Size = 1)]
	[CallbackIdentity(4001)]
	public struct PlaybackStatusHasChanged_t
	{
		public const int k_iCallback = 4001;
	}
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	[CallbackIdentity(4002)]
	public struct VolumeHasChanged_t
	{
		public const int k_iCallback = 4002;

		public float m_flNewVolume;
	}
	[StructLayout(LayoutKind.Sequential, Pack = 8, Size = 1)]
	[CallbackIdentity(4101)]
	public struct MusicPlayerRemoteWillActivate_t
	{
		public const int k_iCallback = 4101;
	}
	[StructLayout(LayoutKind.Sequential, Pack = 8, Size = 1)]
	[CallbackIdentity(4102)]
	public struct MusicPlayerRemoteWillDeactivate_t
	{
		public const int k_iCallback = 4102;
	}
	[StructLayout(LayoutKind.Sequential, Pack = 8, Size = 1)]
	[CallbackIdentity(4103)]
	public struct MusicPlayerRemoteToFront_t
	{
		public const int k_iCallback = 4103;
	}
	[StructLayout(LayoutKind.Sequential, Pack = 8, Size = 1)]
	[CallbackIdentity(4104)]
	public struct MusicPlayerWillQuit_t
	{
		public const int k_iCallback = 4104;
	}
	[StructLayout(LayoutKind.Sequential, Pack = 8, Size = 1)]
	[CallbackIdentity(4105)]
	public struct MusicPlayerWantsPlay_t
	{
		public const int k_iCallback = 4105;
	}
	[StructLayout(LayoutKind.Sequential, Pack = 8, Size = 1)]
	[CallbackIdentity(4106)]
	public struct MusicPlayerWantsPause_t
	{
		public const int k_iCallback = 4106;
	}
	[StructLayout(LayoutKind.Sequential, Pack = 8, Size = 1)]
	[CallbackIdentity(4107)]
	public struct MusicPlayerWantsPlayPrevious_t
	{
		public const int k_iCallback = 4107;
	}
	[StructLayout(LayoutKind.Sequential, Pack = 8, Size = 1)]
	[CallbackIdentity(4108)]
	public struct MusicPlayerWantsPlayNext_t
	{
		public const int k_iCallback = 4108;
	}
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	[CallbackIdentity(4109)]
	public struct MusicPlayerWantsShuffled_t
	{
		public const int k_iCallback = 4109;

		[MarshalAs(UnmanagedType.I1)]
		public bool m_bShuffled;
	}
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	[CallbackIdentity(4110)]
	public struct MusicPlayerWantsLooped_t
	{
		public const int k_iCallback = 4110;

		[MarshalAs(UnmanagedType.I1)]
		public bool m_bLooped;
	}
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	[CallbackIdentity(4011)]
	public struct MusicPlayerWantsVolume_t
	{
		public const int k_iCallback = 4011;

		public float m_flNewVolume;
	}
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	[CallbackIdentity(4012)]
	public struct MusicPlayerSelectsQueueEntry_t
	{
		public const int k_iCallback = 4012;

		public int nID;
	}
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	[CallbackIdentity(4013)]
	public struct MusicPlayerSelectsPlaylistEntry_t
	{
		public const int k_iCallback = 4013;

		public int nID;
	}
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	[CallbackIdentity(4114)]
	public struct MusicPlayerWantsPlayingRepeatStatus_t
	{
		public const int k_iCallback = 4114;

		public int m_nPlayingRepeatStatus;
	}
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	[CallbackIdentity(1202)]
	public struct P2PSessionRequest_t
	{
		public const int k_iCallback = 1202;

		public CSteamID m_steamIDRemote;
	}
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	[CallbackIdentity(1203)]
	public struct P2PSessionConnectFail_t
	{
		public const int k_iCallback = 1203;

		public CSteamID m_steamIDRemote;

		public byte m_eP2PSessionError;
	}
	[StructLayout(LayoutKind.Sequential, Pack = 4)]
	[CallbackIdentity(1201)]
	public struct SocketStatusCallback_t
	{
		public const int k_iCallback = 1201;

		public SNetSocket_t m_hSocket;

		public SNetListenSocket_t m_hListenSocket;

		public CSteamID m_steamIDRemote;

		public int m_eSNetSocketState;
	}
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	[CallbackIdentity(1301)]
	public struct RemoteStorageAppSyncedClient_t
	{
		public const int k_iCallback = 1301;

		public AppId_t m_nAppID;

		public EResult m_eResult;

		public int m_unNumDownloads;
	}
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	[CallbackIdentity(1302)]
	public struct RemoteStorageAppSyncedServer_t
	{
		public const int k_iCallback = 1302;

		public AppId_t m_nAppID;

		public EResult m_eResult;

		public int m_unNumUploads;
	}
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	[CallbackIdentity(1303)]
	public struct RemoteStorageAppSyncProgress_t
	{
		public const int k_iCallback = 1303;

		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 260)]
		public string m_rgchCurrentFile;

		public AppId_t m_nAppID;

		public uint m_uBytesTransferredThisChunk;

		public double m_dAppPercentComplete;

		[MarshalAs(UnmanagedType.I1)]
		public bool m_bUploading;
	}
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	[CallbackIdentity(1305)]
	public struct RemoteStorageAppSyncStatusCheck_t
	{
		public const int k_iCallback = 1305;

		public AppId_t m_nAppID;

		public EResult m_eResult;
	}
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	[CallbackIdentity(1306)]
	public struct RemoteStorageConflictResolution_t
	{
		public const int k_iCallback = 1306;

		public AppId_t m_nAppID;

		public EResult m_eResult;
	}
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	[CallbackIdentity(1307)]
	public struct RemoteStorageFileShareResult_t
	{
		public const int k_iCallback = 1307;

		public EResult m_eResult;

		public UGCHandle_t m_hFile;

		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 260)]
		public string m_rgchFilename;
	}
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	[CallbackIdentity(1309)]
	public struct RemoteStoragePublishFileResult_t
	{
		public const int k_iCallback = 1309;

		public EResult m_eResult;

		public PublishedFileId_t m_nPublishedFileId;

		[MarshalAs(UnmanagedType.I1)]
		public bool m_bUserNeedsToAcceptWorkshopLegalAgreement;
	}
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	[CallbackIdentity(1311)]
	public struct RemoteStorageDeletePublishedFileResult_t
	{
		public const int k_iCallback = 1311;

		public EResult m_eResult;

		public PublishedFileId_t m_nPublishedFileId;
	}
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	[CallbackIdentity(1312)]
	public struct RemoteStorageEnumerateUserPublishedFilesResult_t
	{
		public const int k_iCallback = 1312;

		public EResult m_eResult;

		public int m_nResultsReturned;

		public int m_nTotalResultCount;

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 50)]
		public PublishedFileId_t[] m_rgPublishedFileId;
	}
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	[CallbackIdentity(1313)]
	public struct RemoteStorageSubscribePublishedFileResult_t
	{
		public const int k_iCallback = 1313;

		public EResult m_eResult;

		public PublishedFileId_t m_nPublishedFileId;
	}
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	[CallbackIdentity(1314)]
	public struct RemoteStorageEnumerateUserSubscribedFilesResult_t
	{
		public const int k_iCallback = 1314;

		public EResult m_eResult;

		public int m_nResultsReturned;

		public int m_nTotalResultCount;

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 50)]
		public PublishedFileId_t[] m_rgPublishedFileId;

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 50)]
		public uint[] m_rgRTimeSubscribed;
	}
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	[CallbackIdentity(1315)]
	public struct RemoteStorageUnsubscribePublishedFileResult_t
	{
		public const int k_iCallback = 1315;

		public EResult m_eResult;

		public PublishedFileId_t m_nPublishedFileId;
	}
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	[CallbackIdentity(1316)]
	public struct RemoteStorageUpdatePublishedFileResult_t
	{
		public const int k_iCallback = 1316;

		public EResult m_eResult;

		public PublishedFileId_t m_nPublishedFileId;

		[MarshalAs(UnmanagedType.I1)]
		public bool m_bUserNeedsToAcceptWorkshopLegalAgreement;
	}
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	[CallbackIdentity(1317)]
	public struct RemoteStorageDownloadUGCResult_t
	{
		public const int k_iCallback = 1317;

		public EResult m_eResult;

		public UGCHandle_t m_hFile;

		public AppId_t m_nAppID;

		public int m_nSizeInBytes;

		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 260)]
		public string m_pchFileName;

		public ulong m_ulSteamIDOwner;
	}
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	[CallbackIdentity(1318)]
	public struct RemoteStorageGetPublishedFileDetailsResult_t
	{
		public const int k_iCallback = 1318;

		public EResult m_eResult;

		public PublishedFileId_t m_nPublishedFileId;

		public AppId_t m_nCreatorAppID;

		public AppId_t m_nConsumerAppID;

		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 129)]
		public string m_rgchTitle;

		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 8000)]
		public string m_rgchDescription;

		public UGCHandle_t m_hFile;

		public UGCHandle_t m_hPreviewFile;

		public ulong m_ulSteamIDOwner;

		public uint m_rtimeCreated;

		public uint m_rtimeUpdated;

		public ERemoteStoragePublishedFileVisibility m_eVisibility;

		[MarshalAs(UnmanagedType.I1)]
		public bool m_bBanned;

		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 1025)]
		public string m_rgchTags;

		[MarshalAs(UnmanagedType.I1)]
		public bool m_bTagsTruncated;

		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 260)]
		public string m_pchFileName;

		public int m_nFileSize;

		public int m_nPreviewFileSize;

		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 256)]
		public string m_rgchURL;

		public EWorkshopFileType m_eFileType;

		[MarshalAs(UnmanagedType.I1)]
		public bool m_bAcceptedForUse;
	}
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	[CallbackIdentity(1319)]
	public struct RemoteStorageEnumerateWorkshopFilesResult_t
	{
		public const int k_iCallback = 1319;

		public EResult m_eResult;

		public int m_nResultsReturned;

		public int m_nTotalResultCount;

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 50)]
		public PublishedFileId_t[] m_rgPublishedFileId;

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 50)]
		public float[] m_rgScore;

		public AppId_t m_nAppId;

		public uint m_unStartIndex;
	}
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	[CallbackIdentity(1320)]
	public struct RemoteStorageGetPublishedItemVoteDetailsResult_t
	{
		public const int k_iCallback = 1320;

		public EResult m_eResult;

		public PublishedFileId_t m_unPublishedFileId;

		public int m_nVotesFor;

		public int m_nVotesAgainst;

		public int m_nReports;

		public float m_fScore;
	}
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	[CallbackIdentity(1321)]
	public struct RemoteStoragePublishedFileSubscribed_t
	{
		public const int k_iCallback = 1321;

		public PublishedFileId_t m_nPublishedFileId;

		public AppId_t m_nAppID;
	}
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	[CallbackIdentity(1322)]
	public struct RemoteStoragePublishedFileUnsubscribed_t
	{
		public const int k_iCallback = 1322;

		public PublishedFileId_t m_nPublishedFileId;

		public AppId_t m_nAppID;
	}
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	[CallbackIdentity(1323)]
	public struct RemoteStoragePublishedFileDeleted_t
	{
		public const int k_iCallback = 1323;

		public PublishedFileId_t m_nPublishedFileId;

		public AppId_t m_nAppID;
	}
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	[CallbackIdentity(1324)]
	public struct RemoteStorageUpdateUserPublishedItemVoteResult_t
	{
		public const int k_iCallback = 1324;

		public EResult m_eResult;

		public PublishedFileId_t m_nPublishedFileId;
	}
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	[CallbackIdentity(1325)]
	public struct RemoteStorageUserVoteDetails_t
	{
		public const int k_iCallback = 1325;

		public EResult m_eResult;

		public PublishedFileId_t m_nPublishedFileId;

		public EWorkshopVote m_eVote;
	}
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	[CallbackIdentity(1326)]
	public struct RemoteStorageEnumerateUserSharedWorkshopFilesResult_t
	{
		public const int k_iCallback = 1326;

		public EResult m_eResult;

		public int m_nResultsReturned;

		public int m_nTotalResultCount;

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 50)]
		public PublishedFileId_t[] m_rgPublishedFileId;
	}
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	[CallbackIdentity(1327)]
	public struct RemoteStorageSetUserPublishedFileActionResult_t
	{
		public const int k_iCallback = 1327;

		public EResult m_eResult;

		public PublishedFileId_t m_nPublishedFileId;

		public EWorkshopFileAction m_eAction;
	}
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	[CallbackIdentity(1328)]
	public struct RemoteStorageEnumeratePublishedFilesByUserActionResult_t
	{
		public const int k_iCallback = 1328;

		public EResult m_eResult;

		public EWorkshopFileAction m_eAction;

		public int m_nResultsReturned;

		public int m_nTotalResultCount;

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 50)]
		public PublishedFileId_t[] m_rgPublishedFileId;

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 50)]
		public uint[] m_rgRTimeUpdated;
	}
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	[CallbackIdentity(1329)]
	public struct RemoteStoragePublishFileProgress_t
	{
		public const int k_iCallback = 1329;

		public double m_dPercentFile;

		[MarshalAs(UnmanagedType.I1)]
		public bool m_bPreview;
	}
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	[CallbackIdentity(1330)]
	public struct RemoteStoragePublishedFileUpdated_t
	{
		public const int k_iCallback = 1330;

		public PublishedFileId_t m_nPublishedFileId;

		public AppId_t m_nAppID;

		public UGCHandle_t m_hFile;
	}
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	[CallbackIdentity(2301)]
	public struct ScreenshotReady_t
	{
		public const int k_iCallback = 2301;

		public ScreenshotHandle m_hLocal;

		public EResult m_eResult;
	}
	[StructLayout(LayoutKind.Sequential, Pack = 8, Size = 1)]
	[CallbackIdentity(2302)]
	public struct ScreenshotRequested_t
	{
		public const int k_iCallback = 2302;
	}
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	[CallbackIdentity(3401)]
	public struct SteamUGCQueryCompleted_t
	{
		public const int k_iCallback = 3401;

		public UGCQueryHandle_t m_handle;

		public EResult m_eResult;

		public uint m_unNumResultsReturned;

		public uint m_unTotalMatchingResults;

		[MarshalAs(UnmanagedType.I1)]
		public bool m_bCachedData;
	}
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	[CallbackIdentity(3402)]
	public struct SteamUGCRequestUGCDetailsResult_t
	{
		public const int k_iCallback = 3402;

		public SteamUGCDetails_t m_details;

		[MarshalAs(UnmanagedType.I1)]
		public bool m_bCachedData;
	}
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	[CallbackIdentity(3403)]
	public struct CreateItemResult_t
	{
		public const int k_iCallback = 3403;

		public EResult m_eResult;

		public PublishedFileId_t m_nPublishedFileId;

		[MarshalAs(UnmanagedType.I1)]
		public bool m_bUserNeedsToAcceptWorkshopLegalAgreement;
	}
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	[CallbackIdentity(3404)]
	public struct SubmitItemUpdateResult_t
	{
		public const int k_iCallback = 3404;

		public EResult m_eResult;

		[MarshalAs(UnmanagedType.I1)]
		public bool m_bUserNeedsToAcceptWorkshopLegalAgreement;
	}
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	[CallbackIdentity(3405)]
	public struct ItemInstalled_t
	{
		public const int k_iCallback = 3405;

		public AppId_t m_unAppID;

		public PublishedFileId_t m_nPublishedFileId;
	}
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	[CallbackIdentity(3406)]
	public struct DownloadItemResult_t
	{
		public const int k_iCallback = 3406;

		public AppId_t m_unAppID;

		public PublishedFileId_t m_nPublishedFileId;

		public EResult m_eResult;
	}
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	[CallbackIdentity(3407)]
	public struct UserFavoriteItemsListChanged_t
	{
		public const int k_iCallback = 3407;

		public PublishedFileId_t m_nPublishedFileId;

		public EResult m_eResult;

		[MarshalAs(UnmanagedType.I1)]
		public bool m_bWasAddRequest;
	}
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	[CallbackIdentity(3408)]
	public struct SetUserItemVoteResult_t
	{
		public const int k_iCallback = 3408;

		public PublishedFileId_t m_nPublishedFileId;

		public EResult m_eResult;

		[MarshalAs(UnmanagedType.I1)]
		public bool m_bVoteUp;
	}
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	[CallbackIdentity(3409)]
	public struct GetUserItemVoteResult_t
	{
		public const int k_iCallback = 3409;

		public PublishedFileId_t m_nPublishedFileId;

		public EResult m_eResult;

		[MarshalAs(UnmanagedType.I1)]
		public bool m_bVotedUp;

		[MarshalAs(UnmanagedType.I1)]
		public bool m_bVotedDown;

		[MarshalAs(UnmanagedType.I1)]
		public bool m_bVoteSkipped;
	}
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	[CallbackIdentity(2501)]
	public struct SteamUnifiedMessagesSendMethodResult_t
	{
		public const int k_iCallback = 2501;

		public ClientUnifiedMessageHandle m_hHandle;

		public ulong m_unContext;

		public EResult m_eResult;

		public uint m_unResponseSize;
	}
	[StructLayout(LayoutKind.Sequential, Pack = 8, Size = 1)]
	[CallbackIdentity(101)]
	public struct SteamServersConnected_t
	{
		public const int k_iCallback = 101;
	}
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	[CallbackIdentity(102)]
	public struct SteamServerConnectFailure_t
	{
		public const int k_iCallback = 102;

		public EResult m_eResult;
	}
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	[CallbackIdentity(103)]
	public struct SteamServersDisconnected_t
	{
		public const int k_iCallback = 103;

		public EResult m_eResult;
	}
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	[CallbackIdentity(113)]
	public struct ClientGameServerDeny_t
	{
		public const int k_iCallback = 113;

		public uint m_uAppID;

		public uint m_unGameServerIP;

		public ushort m_usGameServerPort;

		public ushort m_bSecure;

		public uint m_uReason;
	}
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	[CallbackIdentity(117)]
	public struct IPCFailure_t
	{
		public const int k_iCallback = 117;

		public byte m_eFailureType;
	}
	[StructLayout(LayoutKind.Sequential, Pack = 8, Size = 1)]
	[CallbackIdentity(125)]
	public struct LicensesUpdated_t
	{
		public const int k_iCallback = 125;
	}
	[StructLayout(LayoutKind.Sequential, Pack = 4)]
	[CallbackIdentity(143)]
	public struct ValidateAuthTicketResponse_t
	{
		public const int k_iCallback = 143;

		public CSteamID m_SteamID;

		public EAuthSessionResponse m_eAuthSessionResponse;

		public CSteamID m_OwnerSteamID;
	}
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	[CallbackIdentity(152)]
	public struct MicroTxnAuthorizationResponse_t
	{
		public const int k_iCallback = 152;

		public uint m_unAppID;

		public ulong m_ulOrderID;

		public byte m_bAuthorized;
	}
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	[CallbackIdentity(154)]
	public struct EncryptedAppTicketResponse_t
	{
		public const int k_iCallback = 154;

		public EResult m_eResult;
	}
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	[CallbackIdentity(163)]
	public struct GetAuthSessionTicketResponse_t
	{
		public const int k_iCallback = 163;

		public HAuthTicket m_hAuthTicket;

		public EResult m_eResult;
	}
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	[CallbackIdentity(164)]
	public struct GameWebCallback_t
	{
		public const int k_iCallback = 164;

		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 256)]
		public string m_szURL;
	}
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	[CallbackIdentity(165)]
	public struct StoreAuthURLResponse_t
	{
		public const int k_iCallback = 165;

		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 512)]
		public string m_szURL;
	}
	[StructLayout(LayoutKind.Explicit, Pack = 8)]
	[CallbackIdentity(1101)]
	public struct UserStatsReceived_t
	{
		public const int k_iCallback = 1101;

		[FieldOffset(0)]
		public ulong m_nGameID;

		[FieldOffset(8)]
		public EResult m_eResult;

		[FieldOffset(12)]
		public CSteamID m_steamIDUser;
	}
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	[CallbackIdentity(1102)]
	public struct UserStatsStored_t
	{
		public const int k_iCallback = 1102;

		public ulong m_nGameID;

		public EResult m_eResult;
	}
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	[CallbackIdentity(1103)]
	public struct UserAchievementStored_t
	{
		public const int k_iCallback = 1103;

		public ulong m_nGameID;

		[MarshalAs(UnmanagedType.I1)]
		public bool m_bGroupAchievement;

		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
		public string m_rgchAchievementName;

		public uint m_nCurProgress;

		public uint m_nMaxProgress;
	}
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	[CallbackIdentity(1104)]
	public struct LeaderboardFindResult_t
	{
		public const int k_iCallback = 1104;

		public SteamLeaderboard_t m_hSteamLeaderboard;

		public byte m_bLeaderboardFound;
	}
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	[CallbackIdentity(1105)]
	public struct LeaderboardScoresDownloaded_t
	{
		public const int k_iCallback = 1105;

		public SteamLeaderboard_t m_hSteamLeaderboard;

		public SteamLeaderboardEntries_t m_hSteamLeaderboardEntries;

		public int m_cEntryCount;
	}
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	[CallbackIdentity(1106)]
	public struct LeaderboardScoreUploaded_t
	{
		public const int k_iCallback = 1106;

		public byte m_bSuccess;

		public SteamLeaderboard_t m_hSteamLeaderboard;

		public int m_nScore;

		public byte m_bScoreChanged;

		public int m_nGlobalRankNew;

		public int m_nGlobalRankPrevious;
	}
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	[CallbackIdentity(1107)]
	public struct NumberOfCurrentPlayers_t
	{
		public const int k_iCallback = 1107;

		public byte m_bSuccess;

		public int m_cPlayers;
	}
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	[CallbackIdentity(1108)]
	public struct UserStatsUnloaded_t
	{
		public const int k_iCallback = 1108;

		public CSteamID m_steamIDUser;
	}
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	[CallbackIdentity(1109)]
	public struct UserAchievementIconFetched_t
	{
		public const int k_iCallback = 1109;

		public CGameID m_nGameID;

		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
		public string m_rgchAchievementName;

		[MarshalAs(UnmanagedType.I1)]
		public bool m_bAchieved;

		public int m_nIconHandle;
	}
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	[CallbackIdentity(1110)]
	public struct GlobalAchievementPercentagesReady_t
	{
		public const int k_iCallback = 1110;

		public ulong m_nGameID;

		public EResult m_eResult;
	}
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	[CallbackIdentity(1111)]
	public struct LeaderboardUGCSet_t
	{
		public const int k_iCallback = 1111;

		public EResult m_eResult;

		public SteamLeaderboard_t m_hSteamLeaderboard;
	}
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	[CallbackIdentity(1112)]
	public struct GlobalStatsReceived_t
	{
		public const int k_iCallback = 1112;

		public ulong m_nGameID;

		public EResult m_eResult;
	}
	[StructLayout(LayoutKind.Sequential, Pack = 8, Size = 1)]
	[CallbackIdentity(701)]
	public struct IPCountry_t
	{
		public const int k_iCallback = 701;
	}
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	[CallbackIdentity(702)]
	public struct LowBatteryPower_t
	{
		public const int k_iCallback = 702;

		public byte m_nMinutesBatteryLeft;
	}
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	[CallbackIdentity(703)]
	public struct SteamAPICallCompleted_t
	{
		public const int k_iCallback = 703;

		public SteamAPICall_t m_hAsyncCall;
	}
	[StructLayout(LayoutKind.Sequential, Pack = 8, Size = 1)]
	[CallbackIdentity(704)]
	public struct SteamShutdown_t
	{
		public const int k_iCallback = 704;
	}
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	[CallbackIdentity(705)]
	public struct CheckFileSignature_t
	{
		public const int k_iCallback = 705;

		public ECheckFileSignature m_eCheckFileSignature;
	}
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	[CallbackIdentity(714)]
	public struct GamepadTextInputDismissed_t
	{
		public const int k_iCallback = 714;

		[MarshalAs(UnmanagedType.I1)]
		public bool m_bSubmitted;

		public uint m_unSubmittedText;
	}
	[StructLayout(LayoutKind.Sequential, Pack = 8, Size = 1)]
	[CallbackIdentity(4604)]
	public struct BroadcastUploadStart_t
	{
		public const int k_iCallback = 4604;
	}
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	[CallbackIdentity(4605)]
	public struct BroadcastUploadStop_t
	{
		public const int k_iCallback = 4605;

		public EBroadcastUploadResult m_eResult;
	}
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	[CallbackIdentity(4611)]
	public struct GetVideoURLResult_t
	{
		public const int k_iCallback = 4611;

		public EResult m_eResult;

		public AppId_t m_unVideoAppID;

		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 256)]
		public string m_rgchURL;
	}
	public static class Constants
	{
		public const string STEAMAPPLIST_INTERFACE_VERSION = "STEAMAPPLIST_INTERFACE_VERSION001";

		public const string STEAMAPPS_INTERFACE_VERSION = "STEAMAPPS_INTERFACE_VERSION007";

		public const string STEAMAPPTICKET_INTERFACE_VERSION = "STEAMAPPTICKET_INTERFACE_VERSION001";

		public const string STEAMCLIENT_INTERFACE_VERSION = "SteamClient017";

		public const string STEAMCONTROLLER_INTERFACE_VERSION = "STEAMCONTROLLER_INTERFACE_VERSION";

		public const string STEAMFRIENDS_INTERFACE_VERSION = "SteamFriends015";

		public const string STEAMGAMECOORDINATOR_INTERFACE_VERSION = "SteamGameCoordinator001";

		public const string STEAMGAMESERVER_INTERFACE_VERSION = "SteamGameServer012";

		public const string STEAMGAMESERVERSTATS_INTERFACE_VERSION = "SteamGameServerStats001";

		public const string STEAMHTMLSURFACE_INTERFACE_VERSION = "STEAMHTMLSURFACE_INTERFACE_VERSION_003";

		public const string STEAMHTTP_INTERFACE_VERSION = "STEAMHTTP_INTERFACE_VERSION002";

		public const string STEAMINVENTORY_INTERFACE_VERSION = "STEAMINVENTORY_INTERFACE_V001";

		public const string STEAMMATCHMAKING_INTERFACE_VERSION = "SteamMatchMaking009";

		public const string STEAMMATCHMAKINGSERVERS_INTERFACE_VERSION = "SteamMatchMakingServers002";

		public const string STEAMMUSIC_INTERFACE_VERSION = "STEAMMUSIC_INTERFACE_VERSION001";

		public const string STEAMMUSICREMOTE_INTERFACE_VERSION = "STEAMMUSICREMOTE_INTERFACE_VERSION001";

		public const string STEAMNETWORKING_INTERFACE_VERSION = "SteamNetworking005";

		public const string STEAMREMOTESTORAGE_INTERFACE_VERSION = "STEAMREMOTESTORAGE_INTERFACE_VERSION012";

		public const string STEAMSCREENSHOTS_INTERFACE_VERSION = "STEAMSCREENSHOTS_INTERFACE_VERSION002";

		public const string STEAMUGC_INTERFACE_VERSION = "STEAMUGC_INTERFACE_VERSION007";

		public const string STEAMUNIFIEDMESSAGES_INTERFACE_VERSION = "STEAMUNIFIEDMESSAGES_INTERFACE_VERSION001";

		public const string STEAMUSER_INTERFACE_VERSION = "SteamUser018";

		public const string STEAMUSERSTATS_INTERFACE_VERSION = "STEAMUSERSTATS_INTERFACE_VERSION011";

		public const string STEAMUTILS_INTERFACE_VERSION = "SteamUtils007";

		public const string STEAMVIDEO_INTERFACE_VERSION = "STEAMVIDEO_INTERFACE_V001";

		public const int k_cubAppProofOfPurchaseKeyMax = 64;

		public const int k_iSteamUserCallbacks = 100;

		public const int k_iSteamGameServerCallbacks = 200;

		public const int k_iSteamFriendsCallbacks = 300;

		public const int k_iSteamBillingCallbacks = 400;

		public const int k_iSteamMatchmakingCallbacks = 500;

		public const int k_iSteamContentServerCallbacks = 600;

		public const int k_iSteamUtilsCallbacks = 700;

		public const int k_iClientFriendsCallbacks = 800;

		public const int k_iClientUserCallbacks = 900;

		public const int k_iSteamAppsCallbacks = 1000;

		public const int k_iSteamUserStatsCallbacks = 1100;

		public const int k_iSteamNetworkingCallbacks = 1200;

		public const int k_iClientRemoteStorageCallbacks = 1300;

		public const int k_iClientDepotBuilderCallbacks = 1400;

		public const int k_iSteamGameServerItemsCallbacks = 1500;

		public const int k_iClientUtilsCallbacks = 1600;

		public const int k_iSteamGameCoordinatorCallbacks = 1700;

		public const int k_iSteamGameServerStatsCallbacks = 1800;

		public const int k_iSteam2AsyncCallbacks = 1900;

		public const int k_iSteamGameStatsCallbacks = 2000;

		public const int k_iClientHTTPCallbacks = 2100;

		public const int k_iClientScreenshotsCallbacks = 2200;

		public const int k_iSteamScreenshotsCallbacks = 2300;

		public const int k_iClientAudioCallbacks = 2400;

		public const int k_iClientUnifiedMessagesCallbacks = 2500;

		public const int k_iSteamStreamLauncherCallbacks = 2600;

		public const int k_iClientControllerCallbacks = 2700;

		public const int k_iSteamControllerCallbacks = 2800;

		public const int k_iClientParentalSettingsCallbacks = 2900;

		public const int k_iClientDeviceAuthCallbacks = 3000;

		public const int k_iClientNetworkDeviceManagerCallbacks = 3100;

		public const int k_iClientMusicCallbacks = 3200;

		public const int k_iClientRemoteClientManagerCallbacks = 3300;

		public const int k_iClientUGCCallbacks = 3400;

		public const int k_iSteamStreamClientCallbacks = 3500;

		public const int k_IClientProductBuilderCallbacks = 3600;

		public const int k_iClientShortcutsCallbacks = 3700;

		public const int k_iClientRemoteControlManagerCallbacks = 3800;

		public const int k_iSteamAppListCallbacks = 3900;

		public const int k_iSteamMusicCallbacks = 4000;

		public const int k_iSteamMusicRemoteCallbacks = 4100;

		public const int k_iClientVRCallbacks = 4200;

		public const int k_iClientReservedCallbacks = 4300;

		public const int k_iSteamReservedCallbacks = 4400;

		public const int k_iSteamHTMLSurfaceCallbacks = 4500;

		public const int k_iClientVideoCallbacks = 4600;

		public const int k_iClientInventoryCallbacks = 4700;

		public const int k_cchMaxFriendsGroupName = 64;

		public const int k_cFriendsGroupLimit = 100;

		public const int k_cEnumerateFollowersMax = 50;

		public const int k_cchPersonaNameMax = 128;

		public const int k_cwchPersonaNameMax = 32;

		public const int k_cubChatMetadataMax = 8192;

		public const int k_cchMaxRichPresenceKeys = 20;

		public const int k_cchMaxRichPresenceKeyLength = 64;

		public const int k_cchMaxRichPresenceValueLength = 256;

		public const int k_unServerFlagNone = 0;

		public const int k_unServerFlagActive = 1;

		public const int k_unServerFlagSecure = 2;

		public const int k_unServerFlagDedicated = 4;

		public const int k_unServerFlagLinux = 8;

		public const int k_unServerFlagPassworded = 16;

		public const int k_unServerFlagPrivate = 32;

		public const int k_unFavoriteFlagNone = 0;

		public const int k_unFavoriteFlagFavorite = 1;

		public const int k_unFavoriteFlagHistory = 2;

		public const int k_unMaxCloudFileChunkSize = 104857600;

		public const int k_cchPublishedDocumentTitleMax = 129;

		public const int k_cchPublishedDocumentDescriptionMax = 8000;

		public const int k_cchPublishedDocumentChangeDescriptionMax = 8000;

		public const int k_unEnumeratePublishedFilesMaxResults = 50;

		public const int k_cchTagListMax = 1025;

		public const int k_cchFilenameMax = 260;

		public const int k_cchPublishedFileURLMax = 256;

		public const int k_nScreenshotMaxTaggedUsers = 32;

		public const int k_nScreenshotMaxTaggedPublishedFiles = 32;

		public const int k_cubUFSTagTypeMax = 255;

		public const int k_cubUFSTagValueMax = 255;

		public const int k_ScreenshotThumbWidth = 200;

		public const int kNumUGCResultsPerPage = 50;

		public const int k_cchDeveloperMetadataMax = 5000;

		public const int k_cchStatNameMax = 128;

		public const int k_cchLeaderboardNameMax = 128;

		public const int k_cLeaderboardDetailsMax = 64;

		public const int k_cbMaxGameServerGameDir = 32;

		public const int k_cbMaxGameServerMapName = 32;

		public const int k_cbMaxGameServerGameDescription = 64;

		public const int k_cbMaxGameServerName = 64;

		public const int k_cbMaxGameServerTags = 128;

		public const int k_cbMaxGameServerGameData = 2048;

		public const int k_unSteamAccountIDMask = -1;

		public const int k_unSteamAccountInstanceMask = 1048575;

		public const int k_unSteamUserDesktopInstance = 1;

		public const int k_unSteamUserConsoleInstance = 2;

		public const int k_unSteamUserWebInstance = 4;

		public const int k_cchGameExtraInfoMax = 64;

		public const int k_nSteamEncryptedAppTicketSymmetricKeyLen = 32;

		public const int k_cubSaltSize = 8;

		public const ulong k_GIDNil = ulong.MaxValue;

		public const ulong k_TxnIDNil = ulong.MaxValue;

		public const ulong k_TxnIDUnknown = 0uL;

		public const int k_uPackageIdFreeSub = 0;

		public const int k_uPackageIdInvalid = -1;

		public const ulong k_ulAssetClassIdInvalid = 0uL;

		public const int k_uPhysicalItemIdInvalid = 0;

		public const int k_uCellIDInvalid = -1;

		public const int k_uPartnerIdInvalid = 0;

		public const int MAX_STEAM_CONTROLLERS = 16;

		public const int STEAM_RIGHT_TRIGGER_MASK = 1;

		public const int STEAM_LEFT_TRIGGER_MASK = 2;

		public const int STEAM_RIGHT_BUMPER_MASK = 4;

		public const int STEAM_LEFT_BUMPER_MASK = 8;

		public const int STEAM_BUTTON_0_MASK = 16;

		public const int STEAM_BUTTON_1_MASK = 32;

		public const int STEAM_BUTTON_2_MASK = 64;

		public const int STEAM_BUTTON_3_MASK = 128;

		public const int STEAM_TOUCH_0_MASK = 256;

		public const int STEAM_TOUCH_1_MASK = 512;

		public const int STEAM_TOUCH_2_MASK = 1024;

		public const int STEAM_TOUCH_3_MASK = 2048;

		public const int STEAM_BUTTON_MENU_MASK = 4096;

		public const int STEAM_BUTTON_STEAM_MASK = 8192;

		public const int STEAM_BUTTON_ESCAPE_MASK = 16384;

		public const int STEAM_BUTTON_BACK_LEFT_MASK = 32768;

		public const int STEAM_BUTTON_BACK_RIGHT_MASK = 65536;

		public const int STEAM_BUTTON_LEFTPAD_CLICKED_MASK = 131072;

		public const int STEAM_BUTTON_RIGHTPAD_CLICKED_MASK = 262144;

		public const int STEAM_LEFTPAD_FINGERDOWN_MASK = 524288;

		public const int STEAM_RIGHTPAD_FINGERDOWN_MASK = 1048576;

		public const int STEAM_JOYSTICK_BUTTON_MASK = 4194304;

		public const short MASTERSERVERUPDATERPORT_USEGAMESOCKETSHARE = -1;

		public const int INVALID_HTTPREQUEST_HANDLE = 0;

		public const byte k_nMaxLobbyKeyLength = byte.MaxValue;

		public const int k_SteamMusicNameMaxLength = 255;

		public const int k_SteamMusicPNGMaxLength = 65535;

		public const int QUERY_PORT_NOT_INITIALIZED = 65535;

		public const int QUERY_PORT_ERROR = 65534;
	}
	public enum ERegisterActivationCodeResult
	{
		k_ERegisterActivationCodeResultOK,
		k_ERegisterActivationCodeResultFail,
		k_ERegisterActivationCodeResultAlreadyRegistered,
		k_ERegisterActivationCodeResultTimeout,
		k_ERegisterActivationCodeAlreadyOwned
	}
	public enum ESteamControllerPad
	{
		k_ESteamControllerPad_Left,
		k_ESteamControllerPad_Right
	}
	public enum EFriendRelationship
	{
		k_EFriendRelationshipNone,
		k_EFriendRelationshipBlocked,
		k_EFriendRelationshipRequestRecipient,
		k_EFriendRelationshipFriend,
		k_EFriendRelationshipRequestInitiator,
		k_EFriendRelationshipIgnored,
		k_EFriendRelationshipIgnoredFriend,
		k_EFriendRelationshipSuggested,
		k_EFriendRelationshipMax
	}
	public enum EPersonaState
	{
		k_EPersonaStateOffline,
		k_EPersonaStateOnline,
		k_EPersonaStateBusy,
		k_EPersonaStateAway,
		k_EPersonaStateSnooze,
		k_EPersonaStateLookingToTrade,
		k_EPersonaStateLookingToPlay,
		k_EPersonaStateMax
	}
	[Flags]
	public enum EFriendFlags
	{
		k_EFriendFlagNone = 0,
		k_EFriendFlagBlocked = 1,
		k_EFriendFlagFriendshipRequested = 2,
		k_EFriendFlagImmediate = 4,
		k_EFriendFlagClanMember = 8,
		k_EFriendFlagOnGameServer = 0x10,
		k_EFriendFlagRequestingFriendship = 0x80,
		k_EFriendFlagRequestingInfo = 0x100,
		k_EFriendFlagIgnored = 0x200,
		k_EFriendFlagIgnoredFriend = 0x400,
		k_EFriendFlagSuggested = 0x800,
		k_EFriendFlagAll = 0xFFFF
	}
	public enum EUserRestriction
	{
		k_nUserRestrictionNone = 0,
		k_nUserRestrictionUnknown = 1,
		k_nUserRestrictionAnyChat = 2,
		k_nUserRestrictionVoiceChat = 4,
		k_nUserRestrictionGroupChat = 8,
		k_nUserRestrictionRating = 0x10,
		k_nUserRestrictionGameInvites = 0x20,
		k_nUserRestrictionTrading = 0x40
	}
	public enum EOverlayToStoreFlag
	{
		k_EOverlayToStoreFlag_None,
		k_EOverlayToStoreFlag_AddToCart,
		k_EOverlayToStoreFlag_AddToCartAndShow
	}
	[Flags]
	public enum EPersonaChange
	{
		k_EPersonaChangeName = 1,
		k_EPersonaChangeStatus = 2,
		k_EPersonaChangeComeOnline = 4,
		k_EPersonaChangeGoneOffline = 8,
		k_EPersonaChangeGamePlayed = 0x10,
		k_EPersonaChangeGameServer = 0x20,
		k_EPersonaChangeAvatar = 0x40,
		k_EPersonaChangeJoinedSource = 0x80,
		k_EPersonaChangeLeftSource = 0x100,
		k_EPersonaChangeRelationshipChanged = 0x200,
		k_EPersonaChangeNameFirstSet = 0x400,
		k_EPersonaChangeFacebookInfo = 0x800,
		k_EPersonaChangeNickname = 0x1000,
		k_EPersonaChangeSteamLevel = 0x2000
	}
	public enum EGCResults
	{
		k_EGCResultOK,
		k_EGCResultNoMessage,
		k_EGCResultBufferTooSmall,
		k_EGCResultNotLoggedOn,
		k_EGCResultInvalidMessage
	}
	public enum EHTMLMouseButton
	{
		eHTMLMouseButton_Left,
		eHTMLMouseButton_Right,
		eHTMLMouseButton_Middle
	}
	public enum EMouseCursor
	{
		dc_user,
		dc_none,
		dc_arrow,
		dc_ibeam,
		dc_hourglass,
		dc_waitarrow,
		dc_crosshair,
		dc_up,
		dc_sizenw,
		dc_sizese,
		dc_sizene,
		dc_sizesw,
		dc_sizew,
		dc_sizee,
		dc_sizen,
		dc_sizes,
		dc_sizewe,
		dc_sizens,
		dc_sizeall,
		dc_no,
		dc_hand,
		dc_blank,
		dc_middle_pan,
		dc_north_pan,
		dc_north_east_pan,
		dc_east_pan,
		dc_south_east_pan,
		dc_south_pan,
		dc_south_west_pan,
		dc_west_pan,
		dc_north_west_pan,
		dc_alias,
		dc_cell,
		dc_colresize,
		dc_copycur,
		dc_verticaltext,
		dc_rowresize,
		dc_zoomin,
		dc_zoomout,
		dc_help,
		dc_custom,
		dc_last
	}
	[Flags]
	public enum EHTMLKeyModifiers
	{
		k_eHTMLKeyModifier_None = 0,
		k_eHTMLKeyModifier_AltDown = 1,
		k_eHTMLKeyModifier_CtrlDown = 2,
		k_eHTMLKeyModifier_ShiftDown = 4
	}
	[Flags]
	public enum ESteamItemFlags
	{
		k_ESteamItemNoTrade = 1,
		k_ESteamItemRemoved = 0x100,
		k_ESteamItemConsumed = 0x200
	}
	public enum ELobbyType
	{
		k_ELobbyTypePrivate,
		k_ELobbyTypeFriendsOnly,
		k_ELobbyTypePublic,
		k_ELobbyTypeInvisible
	}
	public enum ELobbyComparison
	{
		k_ELobbyComparisonEqualToOrLessThan = -2,
		k_ELobbyComparisonLessThan,
		k_ELobbyComparisonEqual,
		k_ELobbyComparisonGreaterThan,
		k_ELobbyComparisonEqualToOrGreaterThan,
		k_ELobbyComparisonNotEqual
	}
	public enum ELobbyDistanceFilter
	{
		k_ELobbyDistanceFilterClose,
		k_ELobbyDistanceFilterDefault,
		k_ELobbyDistanceFilterFar,
		k_ELobbyDistanceFilterWorldwide
	}
	[Flags]
	public enum EChatMemberStateChange
	{
		k_EChatMemberStateChangeEntered = 1,
		k_EChatMemberStateChangeLeft = 2,
		k_EChatMemberStateChangeDisconnected = 4,
		k_EChatMemberStateChangeKicked = 8,
		k_EChatMemberStateChangeBanned = 0x10
	}
	public enum AudioPlayback_Status
	{
		AudioPlayback_Undefined,
		AudioPlayback_Playing,
		AudioPlayback_Paused,
		AudioPlayback_Idle
	}
	public enum EP2PSessionError
	{
		k_EP2PSessionErrorNone,
		k_EP2PSessionErrorNotRunningApp,
		k_EP2PSessionErrorNoRightsToApp,
		k_EP2PSessionErrorDestinationNotLoggedIn,
		k_EP2PSessionErrorTimeout,
		k_EP2PSessionErrorMax
	}
	public enum EP2PSend
	{
		k_EP2PSendUnreliable,
		k_EP2PSendUnreliableNoDelay,
		k_EP2PSendReliable,
		k_EP2PSendReliableWithBuffering
	}
	public enum ESNetSocketState
	{
		k_ESNetSocketStateInvalid = 0,
		k_ESNetSocketStateConnected = 1,
		k_ESNetSocketStateInitiated = 10,
		k_ESNetSocketStateLocalCandidatesFound = 11,
		k_ESNetSocketStateReceivedRemoteCandidates = 12,
		k_ESNetSocketStateChallengeHandshake = 15,
		k_ESNetSocketStateDisconnecting = 21,
		k_ESNetSocketStateLocalDisconnect = 22,
		k_ESNetSocketStateTimeoutDuringConnect = 23,
		k_ESNetSocketStateRemoteEndDisconnected = 24,
		k_ESNetSocketStateConnectionBroken = 25
	}
	public enum ESNetSocketConnectionType
	{
		k_ESNetSocketConnectionTypeNotConnected,
		k_ESNetSocketConnectionTypeUDP,
		k_ESNetSocketConnectionTypeUDPRelay
	}
	public enum EResolveConflict
	{
		k_EResolveConflictKeepClient = 1,
		k_EResolveConflictKeepServer
	}
	[Flags]
	public enum ERemoteStoragePlatform
	{
		k_ERemoteStoragePlatformNone = 0,
		k_ERemoteStoragePlatformWindows = 1,
		k_ERemoteStoragePlatformOSX = 2,
		k_ERemoteStoragePlatformPS3 = 4,
		k_ERemoteStoragePlatformLinux = 8,
		k_ERemoteStoragePlatformReserved2 = 0x10,
		k_ERemoteStoragePlatformAll = -1
	}
	public enum ERemoteStoragePublishedFileVisibility
	{
		k_ERemoteStoragePublishedFileVisibilityPublic,
		k_ERemoteStoragePublishedFileVisibilityFriendsOnly,
		k_ERemoteStoragePublishedFileVisibilityPrivate
	}
	public enum EWorkshopFileType
	{
		k_EWorkshopFileTypeFirst = 0,
		k_EWorkshopFileTypeCommunity = 0,
		k_EWorkshopFileTypeMicrotransaction = 1,
		k_EWorkshopFileTypeCollection = 2,
		k_EWorkshopFileTypeArt = 3,
		k_EWorkshopFileTypeVideo = 4,
		k_EWorkshopFileTypeScreenshot = 5,
		k_EWorkshopFileTypeGame = 6,
		k_EWorkshopFileTypeSoftware = 7,
		k_EWorkshopFileTypeConcept = 8,
		k_EWorkshopFileTypeWebGuide = 9,
		k_EWorkshopFileTypeIntegratedGuide = 10,
		k_EWorkshopFileTypeMerch = 11,
		k_EWorkshopFileTypeControllerBinding = 12,
		k_EWorkshopFileTypeSteamworksAccessInvite = 13,
		k_EWorkshopFileTypeSteamVideo = 14,
		k_EWorkshopFileTypeGameManagedItem = 15,
		k_EWorkshopFileTypeMax = 16
	}
	public enum EWorkshopVote
	{
		k_EWorkshopVoteUnvoted,
		k_EWorkshopVoteFor,
		k_EWorkshopVoteAgainst,
		k_EWorkshopVoteLater
	}
	public enum EWorkshopFileAction
	{
		k_EWorkshopFileActionPlayed,
		k_EWorkshopFileActionCompleted
	}
	public enum EWorkshopEnumerationType
	{
		k_EWorkshopEnumerationTypeRankedByVote,
		k_EWorkshopEnumerationTypeRecent,
		k_EWorkshopEnumerationTypeTrending,
		k_EWorkshopEnumerationTypeFavoritesOfFriends,
		k_EWorkshopEnumerationTypeVotedByFriends,
		k_EWorkshopEnumerationTypeContentByFriends,
		k_EWorkshopEnumerationTypeRecentFromFollowedUsers
	}
	public enum EWorkshopVideoProvider
	{
		k_EWorkshopVideoProviderNone,
		k_EWorkshopVideoProviderYoutube
	}
	public enum EUGCReadAction
	{
		k_EUGCRead_ContinueReadingUntilFinished,
		k_EUGCRead_ContinueReading,
		k_EUGCRead_Close
	}
	public enum EUGCMatchingUGCType
	{
		k_EUGCMatchingUGCType_Items,
		k_EUGCMatchingUGCType_Items_Mtx,
		k_EUGCMatchingUGCType_Items_ReadyToUse,
		k_EUGCMatchingUGCType_Collections,
		k_EUGCMatchingUGCType_Artwork,
		k_EUGCMatchingUGCType_Videos,
		k_EUGCMatchingUGCType_Screenshots,
		k_EUGCMatchingUGCType_AllGuides,
		k_EUGCMatchingUGCType_WebGuides,
		k_EUGCMatchingUGCType_IntegratedGuides,
		k_EUGCMatchingUGCType_UsableInGame,
		k_EUGCMatchingUGCType_ControllerBindings,
		k_EUGCMatchingUGCType_GameManagedItems
	}
	public enum EUserUGCList
	{
		k_EUserUGCList_Published,
		k_EUserUGCList_VotedOn,
		k_EUserUGCList_VotedUp,
		k_EUserUGCList_VotedDown,
		k_EUserUGCList_WillVoteLater,
		k_EUserUGCList_Favorited,
		k_EUserUGCList_Subscribed,
		k_EUserUGCList_UsedOrPlayed,
		k_EUserUGCList_Followed
	}
	public enum EUserUGCListSortOrder
	{
		k_EUserUGCListSortOrder_CreationOrderDesc,
		k_EUserUGCListSortOrder_CreationOrderAsc,
		k_EUserUGCListSortOrder_TitleAsc,
		k_EUserUGCListSortOrder_LastUpdatedDesc,
		k_EUserUGCListSortOrder_SubscriptionDateDesc,
		k_EUserUGCListSortOrder_VoteScoreDesc,
		k_EUserUGCListSortOrder_ForModeration
	}
	public enum EUGCQuery
	{
		k_EUGCQuery_RankedByVote,
		k_EUGCQuery_RankedByPublicationDate,
		k_EUGCQuery_AcceptedForGameRankedByAcceptanceDate,
		k_EUGCQuery_RankedByTrend,
		k_EUGCQuery_FavoritedByFriendsRankedByPublicationDate,
		k_EUGCQuery_CreatedByFriendsRankedByPublicationDate,
		k_EUGCQuery_RankedByNumTimesReported,
		k_EUGCQuery_CreatedByFollowedUsersRankedByPublicationDate,
		k_EUGCQuery_NotYetRated,
		k_EUGCQuery_RankedByTotalVotesAsc,
		k_EUGCQuery_RankedByVotesUp,
		k_EUGCQuery_RankedByTextSearch,
		k_EUGCQuery_RankedByTotalUniqueSubscriptions
	}
	public enum EItemUpdateStatus
	{
		k_EItemUpdateStatusInvalid,
		k_EItemUpdateStatusPreparingConfig,
		k_EItemUpdateStatusPreparingContent,
		k_EItemUpdateStatusUploadingContent,
		k_EItemUpdateStatusUploadingPreviewFile,
		k_EItemUpdateStatusCommittingChanges
	}
	[Flags]
	public enum EItemState
	{
		k_EItemStateNone = 0,
		k_EItemStateSubscribed = 1,
		k_EItemStateLegacyItem = 2,
		k_EItemStateInstalled = 4,
		k_EItemStateNeedsUpdate = 8,
		k_EItemStateDownloading = 0x10,
		k_EItemStateDownloadPending = 0x20
	}
	public enum EItemStatistic
	{
		k_EItemStatistic_NumSubscriptions,
		k_EItemStatistic_NumFavorites,
		k_EItemStatistic_NumFollowers,
		k_EItemStatistic_NumUniqueSubscriptions,
		k_EItemStatistic_NumUniqueFavorites,
		k_EItemStatistic_NumUniqueFollowers,
		k_EItemStatistic_NumUniqueWebsiteViews,
		k_EItemStatistic_ReportScore
	}
	public enum EFailureType
	{
		k_EFailureFlushedCallbackQueue,
		k_EFailurePipeFail
	}
	public enum ELeaderboardDataRequest
	{
		k_ELeaderboardDataRequestGlobal,
		k_ELeaderboardDataRequestGlobalAroundUser,
		k_ELeaderboardDataRequestFriends,
		k_ELeaderboardDataRequestUsers
	}
	public enum ELeaderboardSortMethod
	{
		k_ELeaderboardSortMethodNone,
		k_ELeaderboardSortMethodAscending,
		k_ELeaderboardSortMethodDescending
	}
	public enum ELeaderboardDisplayType
	{
		k_ELeaderboardDisplayTypeNone,
		k_ELeaderboardDisplayTypeNumeric,
		k_ELeaderboardDisplayTypeTimeSeconds,
		k_ELeaderboardDisplayTypeTimeMilliSeconds
	}
	public enum ELeaderboardUploadScoreMethod
	{
		k_ELeaderboardUploadScoreMethodNone,
		k_ELeaderboardUploadScoreMethodKeepBest,
		k_ELeaderboardUploadScoreMethodForceUpdate
	}
	public enum ESteamAPICallFailure
	{
		k_ESteamAPICallFailureNone = -1,
		k_ESteamAPICallFailureSteamGone,
		k_ESteamAPICallFailureNetworkFailure,
		k_ESteamAPICallFailureInvalidHandle,
		k_ESteamAPICallFailureMismatchedCallback
	}
	public enum EGamepadTextInputMode
	{
		k_EGamepadTextInputModeNormal,
		k_EGamepadTextInputModePassword
	}
	public enum EGamepadTextInputLineMode
	{
		k_EGamepadTextInputLineModeSingleLine,
		k_EGamepadTextInputLineModeMultipleLines
	}
	public enum ECheckFileSignature
	{
		k_ECheckFileSignatureInvalidSignature,
		k_ECheckFileSignatureValidSignature,
		k_ECheckFileSignatureFileNotFound,
		k_ECheckFileSignatureNoSignaturesFoundForThisApp,
		k_ECheckFileSignatureNoSignaturesFoundForThisFile
	}
	public enum EMatchMakingServerResponse
	{
		eServerResponded,
		eServerFailedToRespond,
		eNoServersListedOnMasterServer
	}
	public enum EServerMode
	{
		eServerModeInvalid,
		eServerModeNoAuthentication,
		eServerModeAuthentication,
		eServerModeAuthenticationAndSecure
	}
	public enum EResult
	{
		k_EResultOK = 1,
		k_EResultFail = 2,
		k_EResultNoConnection = 3,
		k_EResultInvalidPassword = 5,
		k_EResultLoggedInElsewhere = 6,
		k_EResultInvalidProtocolVer = 7,
		k_EResultInvalidParam = 8,
		k_EResultFileNotFound = 9,
		k_EResultBusy = 10,
		k_EResultInvalidState = 11,
		k_EResultInvalidName = 12,
		k_EResultInvalidEmail = 13,
		k_EResultDuplicateName = 14,
		k_EResultAccessDenied = 15,
		k_EResultTimeout = 16,
		k_EResultBanned = 17,
		k_EResultAccountNotFound = 18,
		k_EResultInvalidSteamID = 19,
		k_EResultServiceUnavailable = 20,
		k_EResultNotLoggedOn = 21,
		k_EResultPending = 22,
		k_EResultEncryptionFailure = 23,
		k_EResultInsufficientPrivilege = 24,
		k_EResultLimitExceeded = 25,
		k_EResultRevoked = 26,
		k_EResultExpired = 27,
		k_EResultAlreadyRedeemed = 28,
		k_EResultDuplicateRequest = 29,
		k_EResultAlreadyOwned = 30,
		k_EResultIPNotFound = 31,
		k_EResultPersistFailed = 32,
		k_EResultLockingFailed = 33,
		k_EResultLogonSessionReplaced = 34,
		k_EResultConnectFailed = 35,
		k_EResultHandshakeFailed = 36,
		k_EResultIOFailure = 37,
		k_EResultRemoteDisconnect = 38,
		k_EResultShoppingCartNotFound = 39,
		k_EResultBlocked = 40,
		k_EResultIgnored = 41,
		k_EResultNoMatch = 42,
		k_EResultAccountDisabled = 43,
		k_EResultServiceReadOnly = 44,
		k_EResultAccountNotFeatured = 45,
		k_EResultAdministratorOK = 46,
		k_EResultContentVersion = 47,
		k_EResultTryAnotherCM = 48,
		k_EResultPasswordRequiredToKickSession = 49,
		k_EResultAlreadyLoggedInElsewhere = 50,
		k_EResultSuspended = 51,
		k_EResultCancelled = 52,
		k_EResultDataCorruption = 53,
		k_EResultDiskFull = 54,
		k_EResultRemoteCallFailed = 55,
		k_EResultPasswordUnset = 56,
		k_EResultExternalAccountUnlinked = 57,
		k_EResultPSNTicketInvalid = 58,
		k_EResultExternalAccountAlreadyLinked = 59,
		k_EResultRemoteFileConflict = 60,
		k_EResultIllegalPassword = 61,
		k_EResultSameAsPreviousValue = 62,
		k_EResultAccountLogonDenied = 63,
		k_EResultCannotUseOldPassword = 64,
		k_EResultInvalidLoginAuthCode = 65,
		k_EResultAccountLogonDeniedNoMail = 66,
		k_EResultHardwareNotCapableOfIPT = 67,
		k_EResultIPTInitError = 68,
		k_EResultParentalControlRestricted = 69,
		k_EResultFacebookQueryError = 70,
		k_EResultExpiredLoginAuthCode = 71,
		k_EResultIPLoginRestrictionFailed = 72,
		k_EResultAccountLockedDown = 73,
		k_EResultAccountLogonDeniedVerifiedEmailRequired = 74,
		k_EResultNoMatchingURL = 75,
		k_EResultBadResponse = 76,
		k_EResultRequirePasswordReEntry = 77,
		k_EResultValueOutOfRange = 78,
		k_EResultUnexpectedError = 79,
		k_EResultDisabled = 80,
		k_EResultInvalidCEGSubmission = 81,
		k_EResultRestrictedDevice = 82,
		k_EResultRegionLocked = 83,
		k_EResultRateLimitExceeded = 84,
		k_EResultAccountLoginDeniedNeedTwoFactor = 85,
		k_EResultItemDeleted = 86,
		k_EResultAccountLoginDeniedThrottle = 87,
		k_EResultTwoFactorCodeMismatch = 88,
		k_EResultTwoFactorActivationCodeMismatch = 89,
		k_EResultAccountAssociatedToMultiplePartners = 90,
		k_EResultNotModified = 91,
		k_EResultNoMobileDevice = 92,
		k_EResultTimeNotSynced = 93,
		k_EResultSmsCodeFailed = 94,
		k_EResultAccountLimitExceeded = 95,
		k_EResultAccountActivityLimitExceeded = 96,
		k_EResultPhoneActivityLimitExceeded = 97,
		k_EResultRefundToWallet = 98,
		k_EResultEmailSendFailure = 99,
		k_EResultNotSettled = 100
	}
	public enum EVoiceResult
	{
		k_EVoiceResultOK,
		k_EVoiceResultNotInitialized,
		k_EVoiceResultNotRecording,
		k_EVoiceResultNoData,
		k_EVoiceResultBufferTooSmall,
		k_EVoiceResultDataCorrupted,
		k_EVoiceResultRestricted,
		k_EVoiceResultUnsupportedCodec,
		k_EVoiceResultReceiverOutOfDate,
		k_EVoiceResultReceiverDidNotAnswer
	}
	public enum EDenyReason
	{
		k_EDenyInvalid,
		k_EDenyInvalidVersion,
		k_EDenyGeneric,
		k_EDenyNotLoggedOn,
		k_EDenyNoLicense,
		k_EDenyCheater,
		k_EDenyLoggedInElseWhere,
		k_EDenyUnknownText,
		k_EDenyIncompatibleAnticheat,
		k_EDenyMemoryCorruption,
		k_EDenyIncompatibleSoftware,
		k_EDenySteamConnectionLost,
		k_EDenySteamConnectionError,
		k_EDenySteamResponseTimedOut,
		k_EDenySteamValidationStalled,
		k_EDenySteamOwnerLeftGuestUser
	}
	public enum EBeginAuthSessionResult
	{
		k_EBeginAuthSessionResultOK,
		k_EBeginAuthSessionResultInvalidTicket,
		k_EBeginAuthSessionResultDuplicateRequest,
		k_EBeginAuthSessionResultInvalidVersion,
		k_EBeginAuthSessionResultGameMismatch,
		k_EBeginAuthSessionResultExpiredTicket
	}
	public enum EAuthSessionResponse
	{
		k_EAuthSessionResponseOK,
		k_EAuthSessionResponseUserNotConnectedToSteam,
		k_EAuthSessionResponseNoLicenseOrExpired,
		k_EAuthSessionResponseVACBanned,
		k_EAuthSessionResponseLoggedInElseWhere,
		k_EAuthSessionResponseVACCheckTimedOut,
		k_EAuthSessionResponseAuthTicketCanceled,
		k_EAuthSessionResponseAuthTicketInvalidAlreadyUsed,
		k_EAuthSessionResponseAuthTicketInvalid,
		k_EAuthSessionResponsePublisherIssuedBan
	}
	public enum EUserHasLicenseForAppResult
	{
		k_EUserHasLicenseResultHasLicense,
		k_EUserHasLicenseResultDoesNotHaveLicense,
		k_EUserHasLicenseResultNoAuth
	}
	public enum EAccountType
	{
		k_EAccountTypeInvalid,
		k_EAccountTypeIndividual,
		k_EAccountTypeMultiseat,
		k_EAccountTypeGameServer,
		k_EAccountTypeAnonGameServer,
		k_EAccountTypePending,
		k_EAccountTypeContentServer,
		k_EAccountTypeClan,
		k_EAccountTypeChat,
		k_EAccountTypeConsoleUser,
		k_EAccountTypeAnonUser,
		k_EAccountTypeMax
	}
	public enum EAppReleaseState
	{
		k_EAppReleaseState_Unknown,
		k_EAppReleaseState_Unavailable,
		k_EAppReleaseState_Prerelease,
		k_EAppReleaseState_PreloadOnly,
		k_EAppReleaseState_Released
	}
	[Flags]
	public enum EAppOwnershipFlags
	{
		k_EAppOwnershipFlags_None = 0,
		k_EAppOwnershipFlags_OwnsLicense = 1,
		k_EAppOwnershipFlags_FreeLicense = 2,
		k_EAppOwnershipFlags_RegionRestricted = 4,
		k_EAppOwnershipFlags_LowViolence = 8,
		k_EAppOwnershipFlags_InvalidPlatform = 0x10,
		k_EAppOwnershipFlags_SharedLicense = 0x20,
		k_EAppOwnershipFlags_FreeWeekend = 0x40,
		k_EAppOwnershipFlags_RetailLicense = 0x80,
		k_EAppOwnershipFlags_LicenseLocked = 0x100,
		k_EAppOwnershipFlags_LicensePending = 0x200,
		k_EAppOwnershipFlags_LicenseExpired = 0x400,
		k_EAppOwnershipFlags_LicensePermanent = 0x800,
		k_EAppOwnershipFlags_LicenseRecurring = 0x1000,
		k_EAppOwnershipFlags_LicenseCanceled = 0x2000,
		k_EAppOwnershipFlags_AutoGrant = 0x4000
	}
	[Flags]
	public enum EAppType
	{
		k_EAppType_Invalid = 0,
		k_EAppType_Game = 1,
		k_EAppType_Application = 2,
		k_EAppType_Tool = 4,
		k_EAppType_Demo = 8,
		k_EAppType_Media_DEPRECATED = 0x10,
		k_EAppType_DLC = 0x20,
		k_EAppType_Guide = 0x40,
		k_EAppType_Driver = 0x80,
		k_EAppType_Config = 0x100,
		k_EAppType_Hardware = 0x200,
		k_EAppType_Video = 0x800,
		k_EAppType_Plugin = 0x1000,
		k_EAppType_Music = 0x2000,
		k_EAppType_Shortcut = 0x40000000,
		k_EAppType_DepotOnly = -2147483647
	}
	public enum ESteamUserStatType
	{
		k_ESteamUserStatTypeINVALID,
		k_ESteamUserStatTypeINT,
		k_ESteamUserStatTypeFLOAT,
		k_ESteamUserStatTypeAVGRATE,
		k_ESteamUserStatTypeACHIEVEMENTS,
		k_ESteamUserStatTypeGROUPACHIEVEMENTS,
		k_ESteamUserStatTypeMAX
	}
	public enum EChatEntryType
	{
		k_EChatEntryTypeInvalid = 0,
		k_EChatEntryTypeChatMsg = 1,
		k_EChatEntryTypeTyping = 2,
		k_EChatEntryTypeInviteGame = 3,
		k_EChatEntryTypeEmote = 4,
		k_EChatEntryTypeLeftConversation = 6,
		k_EChatEntryTypeEntered = 7,
		k_EChatEntryTypeWasKicked = 8,
		k_EChatEntryTypeWasBanned = 9,
		k_EChatEntryTypeDisconnected = 10,
		k_EChatEntryTypeHistoricalChat = 11,
		k_EChatEntryTypeReserved1 = 12,
		k_EChatEntryTypeReserved2 = 13,
		k_EChatEntryTypeLinkBlocked = 14
	}
	public enum EChatRoomEnterResponse
	{
		k_EChatRoomEnterResponseSuccess = 1,
		k_EChatRoomEnterResponseDoesntExist,
		k_EChatRoomEnterResponseNotAllowed,
		k_EChatRoomEnterResponseFull,
		k_EChatRoomEnterResponseError,
		k_EChatRoomEnterResponseBanned,
		k_EChatRoomEnterResponseLimited,
		k_EChatRoomEnterResponseClanDisabled,
		k_EChatRoomEnterResponseCommunityBan,
		k_EChatRoomEnterResponseMemberBlockedYou,
		k_EChatRoomEnterResponseYouBlockedMember
	}
	[Flags]
	public enum EChatSteamIDInstanceFlags
	{
		k_EChatAccountInstanceMask = 0xFFF,
		k_EChatInstanceFlagClan = 0x80000,
		k_EChatInstanceFlagLobby = 0x40000,
		k_EChatInstanceFlagMMSLobby = 0x20000
	}
	[Flags]
	public enum EMarketingMessageFlags
	{
		k_EMarketingMessageFlagsNone = 0,
		k_EMarketingMessageFlagsHighPriority = 1,
		k_EMarketingMessageFlagsPlatformWindows = 2,
		k_EMarketingMessageFlagsPlatformMac = 4,
		k_EMarketingMessageFlagsPlatformLinux = 8,
		k_EMarketingMessageFlagsPlatformRestrictions = 0xE
	}
	public enum ENotificationPosition
	{
		k_EPositionTopLeft,
		k_EPositionTopRight,
		k_EPositionBottomLeft,
		k_EPositionBottomRight
	}
	public enum EBroadcastUploadResult
	{
		k_EBroadcastUploadResultNone,
		k_EBroadcastUploadResultOK,
		k_EBroadcastUploadResultInitFailed,
		k_EBroadcastUploadResultFrameFailed,
		k_EBroadcastUploadResultTimeout,
		k_EBroadcastUploadResultBandwidthExceeded,
		k_EBroadcastUploadResultLowFPS,
		k_EBroadcastUploadResultMissingKeyFrames,
		k_EBroadcastUploadResultNoConnection,
		k_EBroadcastUploadResultRelayFailed,
		k_EBroadcastUploadResultSettingsChanged,
		k_EBroadcastUploadResultMissingAudio,
		k_EBroadcastUploadResultTooFarBehind
	}
	public enum EHTTPMethod
	{
		k_EHTTPMethodInvalid,
		k_EHTTPMethodGET,
		k_EHTTPMethodHEAD,
		k_EHTTPMethodPOST,
		k_EHTTPMethodPUT,
		k_EHTTPMethodDELETE,
		k_EHTTPMethodOPTIONS
	}
	public enum EHTTPStatusCode
	{
		k_EHTTPStatusCodeInvalid = 0,
		k_EHTTPStatusCode100Continue = 100,
		k_EHTTPStatusCode101SwitchingProtocols = 101,
		k_EHTTPStatusCode200OK = 200,
		k_EHTTPStatusCode201Created = 201,
		k_EHTTPStatusCode202Accepted = 202,
		k_EHTTPStatusCode203NonAuthoritative = 203,
		k_EHTTPStatusCode204NoContent = 204,
		k_EHTTPStatusCode205ResetContent = 205,
		k_EHTTPStatusCode206PartialContent = 206,
		k_EHTTPStatusCode300MultipleChoices = 300,
		k_EHTTPStatusCode301MovedPermanently = 301,
		k_EHTTPStatusCode302Found = 302,
		k_EHTTPStatusCode303SeeOther = 303,
		k_EHTTPStatusCode304NotModified = 304,
		k_EHTTPStatusCode305UseProxy = 305,
		k_EHTTPStatusCode307TemporaryRedirect = 307,
		k_EHTTPStatusCode400BadRequest = 400,
		k_EHTTPStatusCode401Unauthorized = 401,
		k_EHTTPStatusCode402PaymentRequired = 402,
		k_EHTTPStatusCode403Forbidden = 403,
		k_EHTTPStatusCode404NotFound = 404,
		k_EHTTPStatusCode405MethodNotAllowed = 405,
		k_EHTTPStatusCode406NotAcceptable = 406,
		k_EHTTPStatusCode407ProxyAuthRequired = 407,
		k_EHTTPStatusCode408RequestTimeout = 408,
		k_EHTTPStatusCode409Conflict = 409,
		k_EHTTPStatusCode410Gone = 410,
		k_EHTTPStatusCode411LengthRequired = 411,
		k_EHTTPStatusCode412PreconditionFailed = 412,
		k_EHTTPStatusCode413RequestEntityTooLarge = 413,
		k_EHTTPStatusCode414RequestURITooLong = 414,
		k_EHTTPStatusCode415UnsupportedMediaType = 415,
		k_EHTTPStatusCode416RequestedRangeNotSatisfiable = 416,
		k_EHTTPStatusCode417ExpectationFailed = 417,
		k_EHTTPStatusCode4xxUnknown = 418,
		k_EHTTPStatusCode429TooManyRequests = 429,
		k_EHTTPStatusCode500InternalServerError = 500,
		k_EHTTPStatusCode501NotImplemented = 501,
		k_EHTTPStatusCode502BadGateway = 502,
		k_EHTTPStatusCode503ServiceUnavailable = 503,
		k_EHTTPStatusCode504GatewayTimeout = 504,
		k_EHTTPStatusCode505HTTPVersionNotSupported = 505,
		k_EHTTPStatusCode5xxUnknown = 599
	}
	public enum EUniverse
	{
		k_EUniverseInvalid,
		k_EUniversePublic,
		k_EUniverseBeta,
		k_EUniverseInternal,
		k_EUniverseDev,
		k_EUniverseMax
	}
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct SteamControllerState_t
	{
		public uint unPacketNum;

		public ulong ulButtons;

		public short sLeftPadX;

		public short sLeftPadY;

		public short sRightPadX;

		public short sRightPadY;
	}
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	public struct FriendGameInfo_t
	{
		public CGameID m_gameID;

		public uint m_unGameIP;

		public ushort m_usGamePort;

		public ushort m_usQueryPort;

		public CSteamID m_steamIDLobby;
	}
	public struct FriendSessionStateInfo_t
	{
		public uint m_uiOnlineSessionInstances;

		public byte m_uiPublishedToFriendsSessionInstance;
	}
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	public struct SteamItemDetails_t
	{
		public SteamItemInstanceID_t m_itemId;

		public SteamItemDef_t m_iDefinition;

		public ushort m_unQuantity;

		public ushort m_unFlags;
	}
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	public struct P2PSessionState_t
	{
		public byte m_bConnectionActive;

		public byte m_bConnecting;

		public byte m_eP2PSessionError;

		public byte m_bUsingRelay;

		public int m_nBytesQueuedForSend;

		public int m_nPacketsQueuedForSend;

		public uint m_nRemoteIP;

		public ushort m_nRemotePort;
	}
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	public struct SteamParamStringArray_t
	{
		public IntPtr m_ppStrings;

		public int m_nNumStrings;
	}
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	public struct SteamUGCDetails_t
	{
		public PublishedFileId_t m_nPublishedFileId;

		public EResult m_eResult;

		public EWorkshopFileType m_eFileType;

		public AppId_t m_nCreatorAppID;

		public AppId_t m_nConsumerAppID;

		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 129)]
		public string m_rgchTitle;

		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 8000)]
		public string m_rgchDescription;

		public ulong m_ulSteamIDOwner;

		public uint m_rtimeCreated;

		public uint m_rtimeUpdated;

		public uint m_rtimeAddedToUserList;

		public ERemoteStoragePublishedFileVisibility m_eVisibility;

		[MarshalAs(UnmanagedType.I1)]
		public bool m_bBanned;

		[MarshalAs(UnmanagedType.I1)]
		public bool m_bAcceptedForUse;

		[MarshalAs(UnmanagedType.I1)]
		public bool m_bTagsTruncated;

		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 1025)]
		public string m_rgchTags;

		public UGCHandle_t m_hFile;

		public UGCHandle_t m_hPreviewFile;

		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 260)]
		public string m_pchFileName;

		public int m_nFileSize;

		public int m_nPreviewFileSize;

		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 256)]
		public string m_rgchURL;

		public uint m_unVotesUp;

		public uint m_unVotesDown;

		public float m_flScore;

		public uint m_unNumChildren;
	}
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	public struct CallbackMsg_t
	{
		public int m_hSteamUser;

		public int m_iCallback;

		public IntPtr m_pubParam;

		public int m_cubParam;
	}
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	public struct LeaderboardEntry_t
	{
		public CSteamID m_steamIDUser;

		public int m_nGlobalRank;

		public int m_nScore;

		public int m_cDetails;

		public UGCHandle_t m_hUGC;
	}
	public struct MatchMakingKeyValuePair_t
	{
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 256)]
		public string m_szKey;

		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 256)]
		public string m_szValue;

		private MatchMakingKeyValuePair_t(string strKey, string strValue)
		{
			m_szKey = strKey;
			m_szValue = strValue;
		}
	}
	public static class CallbackDispatcher
	{
		public static void ExceptionHandler(Exception e)
		{
			Console.WriteLine(e.Message);
		}
	}
	public sealed class Callback<T>
	{
		public delegate void DispatchDelegate(T param);

		private CCallbackBaseVTable VTable;

		private IntPtr m_pVTable = IntPtr.Zero;

		private CCallbackBase m_CCallbackBase;

		private GCHandle m_pCCallbackBase;

		private bool m_bGameServer;

		private readonly int m_size = Marshal.SizeOf(typeof(T));

		private event DispatchDelegate m_Func;

		public static Callback<T> Create(DispatchDelegate func)
		{
			return new Callback<T>(func);
		}

		public static Callback<T> CreateGameServer(DispatchDelegate func)
		{
			return new Callback<T>(func, bGameServer: true);
		}

		public Callback(DispatchDelegate func, bool bGameServer = false)
		{
			m_bGameServer = bGameServer;
			BuildCCallbackBase();
			Register(func);
		}

		~Callback()
		{
			Unregister();
			if (m_pVTable != IntPtr.Zero)
			{
				Marshal.FreeHGlobal(m_pVTable);
			}
			if (m_pCCallbackBase.IsAllocated)
			{
				m_pCCallbackBase.Free();
			}
		}

		public void Register(DispatchDelegate func)
		{
			if (func == null)
			{
				throw new Exception("Callback function must not be null.");
			}
			if ((m_CCallbackBase.m_nCallbackFlags & 1) == 1)
			{
				Unregister();
			}
			if (m_bGameServer)
			{
				SetGameserverFlag();
			}
			this.m_Func = func;
			NativeMethods.SteamAPI_RegisterCallback(m_pCCallbackBase.AddrOfPinnedObject(), CallbackIdentities.GetCallbackIdentity(typeof(T)));
		}

		public void Unregister()
		{
			NativeMethods.SteamAPI_UnregisterCallback(m_pCCallbackBase.AddrOfPinnedObject());
		}

		public void SetGameserverFlag()
		{
			m_CCallbackBase.m_nCallbackFlags |= 2;
		}

		private void OnRunCallback(IntPtr thisptr, IntPtr pvParam)
		{
			try
			{
				this.m_Func((T)Marshal.PtrToStructure(pvParam, typeof(T)));
			}
			catch (Exception e)
			{
				CallbackDispatcher.ExceptionHandler(e);
			}
		}

		private void OnRunCallResult(IntPtr thisptr, IntPtr pvParam, bool bFailed, ulong hSteamAPICall)
		{
			try
			{
				this.m_Func((T)Marshal.PtrToStructure(pvParam, typeof(T)));
			}
			catch (Exception e)
			{
				CallbackDispatcher.ExceptionHandler(e);
			}
		}

		private int OnGetCallbackSizeBytes(IntPtr thisptr)
		{
			return m_size;
		}

		private void BuildCCallbackBase()
		{
			VTable = new CCallbackBaseVTable
			{
				m_RunCallResult = OnRunCallResult,
				m_RunCallback = OnRunCallback,
				m_GetCallbackSizeBytes = OnGetCallbackSizeBytes
			};
			m_pVTable = Marshal.AllocHGlobal(Marshal.SizeOf(typeof(CCallbackBaseVTable)));
			Marshal.StructureToPtr(VTable, m_pVTable, fDeleteOld: false);
			m_CCallbackBase = new CCallbackBase
			{
				m_vfptr = m_pVTable,
				m_nCallbackFlags = 0,
				m_iCallback = CallbackIdentities.GetCallbackIdentity(typeof(T))
			};
			m_pCCallbackBase = GCHandle.Alloc(m_CCallbackBase, GCHandleType.Pinned);
		}
	}
	public sealed class CallResult<T>
	{
		public delegate void APIDispatchDelegate(T param, bool bIOFailure);

		private CCallbackBaseVTable VTable;

		private IntPtr m_pVTable = IntPtr.Zero;

		private CCallbackBase m_CCallbackBase;

		private GCHandle m_pCCallbackBase;

		private SteamAPICall_t m_hAPICall = SteamAPICall_t.Invalid;

		private readonly int m_size = Marshal.SizeOf(typeof(T));

		public SteamAPICall_t Handle => m_hAPICall;

		private event APIDispatchDelegate m_Func;

		public static CallResult<T> Create(APIDispatchDelegate func = null)
		{
			return new CallResult<T>(func);
		}

		public CallResult(APIDispatchDelegate func = null)
		{
			this.m_Func = func;
			BuildCCallbackBase();
		}

		~CallResult()
		{
			Cancel();
			if (m_pVTable != IntPtr.Zero)
			{
				Marshal.FreeHGlobal(m_pVTable);
			}
			if (m_pCCallbackBase.IsAllocated)
			{
				m_pCCallbackBase.Free();
			}
		}

		public void Set(SteamAPICall_t hAPICall, APIDispatchDelegate func = null)
		{
			if (func != null)
			{
				this.m_Func = func;
			}
			if (this.m_Func == null)
			{
				throw new Exception("CallResult function was null, you must either set it in the CallResult Constructor or in Set()");
			}
			if (m_hAPICall != SteamAPICall_t.Invalid)
			{
				NativeMethods.SteamAPI_UnregisterCallResult(m_pCCallbackBase.AddrOfPinnedObject(), (ulong)m_hAPICall);
			}
			m_hAPICall = hAPICall;
			if (hAPICall != SteamAPICall_t.Invalid)
			{
				NativeMethods.SteamAPI_RegisterCallResult(m_pCCallbackBase.AddrOfPinnedObject(), (ulong)hAPICall);
			}
		}

		public bool IsActive()
		{
			return m_hAPICall != SteamAPICall_t.Invalid;
		}

		public void Cancel()
		{
			if (m_hAPICall != SteamAPICall_t.Invalid)
			{
				NativeMethods.SteamAPI_UnregisterCallResult(m_pCCallbackBase.AddrOfPinnedObject(), (ulong)m_hAPICall);
				m_hAPICall = SteamAPICall_t.Invalid;
			}
		}

		public void SetGameserverFlag()
		{
			m_CCallbackBase.m_nCallbackFlags |= 2;
		}

		private void OnRunCallback(IntPtr thisptr, IntPtr pvParam)
		{
			m_hAPICall = SteamAPICall_t.Invalid;
			try
			{
				this.m_Func((T)Marshal.PtrToStructure(pvParam, typeof(T)), bIOFailure: false);
			}
			catch (Exception e)
			{
				CallbackDispatcher.ExceptionHandler(e);
			}
		}

		private void OnRunCallResult(IntPtr thisptr, IntPtr pvParam, bool bFailed, ulong hSteamAPICall)
		{
			SteamAPICall_t steamAPICall_t = (SteamAPICall_t)hSteamAPICall;
			if (steamAPICall_t == m_hAPICall)
			{
				try
				{
					this.m_Func((T)Marshal.PtrToStructure(pvParam, typeof(T)), bFailed);
				}
				catch (Exception e)
				{
					CallbackDispatcher.ExceptionHandler(e);
				}
				if (steamAPICall_t == m_hAPICall)
				{
					m_hAPICall = SteamAPICall_t.Invalid;
				}
			}
		}

		private int OnGetCallbackSizeBytes(IntPtr thisptr)
		{
			return m_size;
		}

		private void BuildCCallbackBase()
		{
			VTable = new CCallbackBaseVTable
			{
				m_RunCallback = OnRunCallback,
				m_RunCallResult = OnRunCallResult,
				m_GetCallbackSizeBytes = OnGetCallbackSizeBytes
			};
			m_pVTable = Marshal.AllocHGlobal(Marshal.SizeOf(typeof(CCallbackBaseVTable)));
			Marshal.StructureToPtr(VTable, m_pVTable, fDeleteOld: false);
			m_CCallbackBase = new CCallbackBase
			{
				m_vfptr = m_pVTable,
				m_nCallbackFlags = 0,
				m_iCallback = CallbackIdentities.GetCallbackIdentity(typeof(T))
			};
			m_pCCallbackBase = GCHandle.Alloc(m_CCallbackBase, GCHandleType.Pinned);
		}
	}
	[StructLayout(LayoutKind.Sequential)]
	internal class CCallbackBase
	{
		public const byte k_ECallbackFlagsRegistered = 1;

		public const byte k_ECallbackFlagsGameServer = 2;

		public IntPtr m_vfptr;

		public byte m_nCallbackFlags;

		public int m_iCallback;
	}
	[StructLayout(LayoutKind.Sequential)]
	internal class CCallbackBaseVTable
	{
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void RunCBDel(IntPtr thisptr, IntPtr pvParam);

		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void RunCRDel(IntPtr thisptr, IntPtr pvParam, [MarshalAs(UnmanagedType.I1)] bool bIOFailure, ulong hSteamAPICall);

		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate int GetCallbackSizeBytesDel(IntPtr thisptr);

		private const CallingConvention cc = CallingConvention.Cdecl;

		[NonSerialized]
		[MarshalAs(UnmanagedType.FunctionPtr)]
		public RunCBDel m_RunCallback;

		[NonSerialized]
		[MarshalAs(UnmanagedType.FunctionPtr)]
		public RunCRDel m_RunCallResult;

		[NonSerialized]
		[MarshalAs(UnmanagedType.FunctionPtr)]
		public GetCallbackSizeBytesDel m_GetCallbackSizeBytes;
	}
	internal class CallbackIdentities
	{
		public static int GetCallbackIdentity(Type callbackStruct)
		{
			object[] customAttributes = callbackStruct.GetCustomAttributes(typeof(CallbackIdentityAttribute), inherit: false);
			int num = 0;
			if (num < customAttributes.Length)
			{
				return ((CallbackIdentityAttribute)customAttributes[num]).Identity;
			}
			throw new Exception("Callback number not found for struct " + callbackStruct);
		}
	}
	[AttributeUsage(AttributeTargets.Struct, AllowMultiple = false)]
	internal class CallbackIdentityAttribute : Attribute
	{
		public int Identity { get; set; }

		public CallbackIdentityAttribute(int callbackNum)
		{
			Identity = callbackNum;
		}
	}
	public class InteropHelp
	{
		public class UTF8StringHandle : SafeHandleZeroOrMinusOneIsInvalid
		{
			public UTF8StringHandle(string str)
				: base(ownsHandle: true)
			{
				if (str == null)
				{
					SetHandle(IntPtr.Zero);
					return;
				}
				byte[] array = new byte[Encoding.UTF8.GetByteCount(str) + 1];
				Encoding.UTF8.GetBytes(str, 0, str.Length, array, 0);
				IntPtr destination = Marshal.AllocHGlobal(array.Length);
				Marshal.Copy(array, 0, destination, array.Length);
				SetHandle(destination);
			}

			protected override bool ReleaseHandle()
			{
				if (!IsInvalid)
				{
					Marshal.FreeHGlobal(handle);
				}
				return true;
			}
		}

		public class SteamParamStringArray
		{
			private IntPtr[] m_Strings;

			private IntPtr m_ptrStrings;

			private IntPtr m_pSteamParamStringArray;

			public SteamParamStringArray(IList<string> strings)
			{
				if (strings == null)
				{
					m_pSteamParamStringArray = IntPtr.Zero;
					return;
				}
				m_Strings = new IntPtr[strings.Count];
				for (int i = 0; i < strings.Count; i++)
				{
					byte[] array = new byte[Encoding.UTF8.GetByteCount(strings[i]) + 1];
					Encoding.UTF8.GetBytes(strings[i], 0, strings[i].Length, array, 0);
					m_Strings[i] = Marshal.AllocHGlobal(array.Length);
					Marshal.Copy(array, 0, m_Strings[i], array.Length);
				}
				m_ptrStrings = Marshal.AllocHGlobal(Marshal.SizeOf(typeof(IntPtr)) * m_Strings.Length);
				SteamParamStringArray_t structure = new SteamParamStringArray_t
				{
					m_ppStrings = m_ptrStrings,
					m_nNumStrings = m_Strings.Length
				};
				Marshal.Copy(m_Strings, 0, structure.m_ppStrings, m_Strings.Length);
				m_pSteamParamStringArray = Marshal.AllocHGlobal(Marshal.SizeOf(typeof(SteamParamStringArray_t)));
				Marshal.StructureToPtr(structure, m_pSteamParamStringArray, fDeleteOld: false);
			}

			~SteamParamStringArray()
			{
				IntPtr[] strings = m_Strings;
				int i = 0;
				for (; i < strings.Length; i++)
				{
					Marshal.FreeHGlobal(strings[i]);
				}
				if (m_ptrStrings != IntPtr.Zero)
				{
					Marshal.FreeHGlobal(m_ptrStrings);
				}
				if (m_pSteamParamStringArray != IntPtr.Zero)
				{
					Marshal.FreeHGlobal(m_pSteamParamStringArray);
				}
			}

			public static implicit operator IntPtr(SteamParamStringArray that)
			{
				return that.m_pSteamParamStringArray;
			}
		}

		public static void TestIfPlatformSupported()
		{
			throw new InvalidOperationException("Steamworks functions can only be called on platforms that Steam is available on.");
		}

		public static void TestIfAvailableClient()
		{
			TestIfPlatformSupported();
			if (NativeMethods.SteamClient() == IntPtr.Zero)
			{
				throw new InvalidOperationException("Steamworks is not initialized.");
			}
		}

		public static void TestIfAvailableGameServer()
		{
			TestIfPlatformSupported();
			if (NativeMethods.SteamClientGameServer() == IntPtr.Zero)
			{
				throw new InvalidOperationException("Steamworks is not initialized.");
			}
		}

		public static string PtrToStringUTF8(IntPtr nativeUtf8)
		{
			if (nativeUtf8 == IntPtr.Zero)
			{
				return string.Empty;
			}
			int i;
			for (i = 0; Marshal.ReadByte(nativeUtf8, i) != 0; i++)
			{
			}
			if (i == 0)
			{
				return string.Empty;
			}
			byte[] array = new byte[i];
			Marshal.Copy(nativeUtf8, array, 0, array.Length);
			return Encoding.UTF8.GetString(array);
		}
	}
	public class MMKVPMarshaller
	{
		private IntPtr m_pNativeArray;

		private IntPtr m_pArrayEntries;

		public MMKVPMarshaller(MatchMakingKeyValuePair_t[] filters)
		{
			if (filters != null)
			{
				int num = Marshal.SizeOf(typeof(MatchMakingKeyValuePair_t));
				m_pNativeArray = Marshal.AllocHGlobal(Marshal.SizeOf(typeof(IntPtr)) * filters.Length);
				m_pArrayEntries = Marshal.AllocHGlobal(num * filters.Length);
				for (int i = 0; i < filters.Length; i++)
				{
					Marshal.StructureToPtr(filters[i], new IntPtr(m_pArrayEntries.ToInt64() + i * num), fDeleteOld: false);
				}
				Marshal.WriteIntPtr(m_pNativeArray, m_pArrayEntries);
			}
		}

		~MMKVPMarshaller()
		{
			if (m_pArrayEntries != IntPtr.Zero)
			{
				Marshal.FreeHGlobal(m_pArrayEntries);
			}
			if (m_pNativeArray != IntPtr.Zero)
			{
				Marshal.FreeHGlobal(m_pNativeArray);
			}
		}

		public static implicit operator IntPtr(MMKVPMarshaller that)
		{
			return that.m_pNativeArray;
		}
	}
	public class DllCheck
	{
		[DllImport("kernel32.dll")]
		public static extern IntPtr GetModuleHandle(string lpModuleName);

		[DllImport("kernel32.dll", CharSet = CharSet.Auto)]
		private static extern int GetModuleFileName(IntPtr hModule, StringBuilder strFullPath, int nSize);

		public static bool Test()
		{
			return true;
		}

		private static bool CheckSteamAPIDLL()
		{
			return true;
		}
	}
	public class ISteamMatchmakingServerListResponse
	{
		public delegate void ServerResponded(HServerListRequest hRequest, int iServer);

		public delegate void ServerFailedToRespond(HServerListRequest hRequest, int iServer);

		public delegate void RefreshComplete(HServerListRequest hRequest, EMatchMakingServerResponse response);

		[UnmanagedFunctionPointer(CallingConvention.ThisCall)]
		private delegate void InternalServerResponded(IntPtr thisptr, HServerListRequest hRequest, int iServer);

		[UnmanagedFunctionPointer(CallingConvention.ThisCall)]
		private delegate void InternalServerFailedToRespond(IntPtr thisptr, HServerListRequest hRequest, int iServer);

		[UnmanagedFunctionPointer(CallingConvention.ThisCall)]
		private delegate void InternalRefreshComplete(IntPtr thisptr, HServerListRequest hRequest, EMatchMakingServerResponse response);

		[StructLayout(LayoutKind.Sequential)]
		private class VTable
		{
			[NonSerialized]
			[MarshalAs(UnmanagedType.FunctionPtr)]
			public InternalServerResponded m_VTServerResponded;

			[NonSerialized]
			[MarshalAs(UnmanagedType.FunctionPtr)]
			public InternalServerFailedToRespond m_VTServerFailedToRespond;

			[NonSerialized]
			[MarshalAs(UnmanagedType.FunctionPtr)]
			public InternalRefreshComplete m_VTRefreshComplete;
		}

		private VTable m_VTable;

		private IntPtr m_pVTable;

		private GCHandle m_pGCHandle;

		private ServerResponded m_ServerResponded;

		private ServerFailedToRespond m_ServerFailedToRespond;

		private RefreshComplete m_RefreshComplete;

		public ISteamMatchmakingServerListResponse(ServerResponded onServerResponded, ServerFailedToRespond onServerFailedToRespond, RefreshComplete onRefreshComplete)
		{
			if (onServerResponded == null || onServerFailedToRespond == null || onRefreshComplete == null)
			{
				throw new ArgumentNullException();
			}
			m_ServerResponded = onServerResponded;
			m_ServerFailedToRespond = onServerFailedToRespond;
			m_RefreshComplete = onRefreshComplete;
			m_VTable = new VTable
			{
				m_VTServerResponded = InternalOnServerResponded,
				m_VTServerFailedToRespond = InternalOnServerFailedToRespond,
				m_VTRefreshComplete = InternalOnRefreshComplete
			};
			m_pVTable = Marshal.AllocHGlobal(Marshal.SizeOf(typeof(VTable)));
			Marshal.StructureToPtr(m_VTable, m_pVTable, fDeleteOld: false);
			m_pGCHandle = GCHandle.Alloc(m_pVTable, GCHandleType.Pinned);
		}

		~ISteamMatchmakingServerListResponse()
		{
			if (m_pVTable != IntPtr.Zero)
			{
				Marshal.FreeHGlobal(m_pVTable);
			}
			if (m_pGCHandle.IsAllocated)
			{
				m_pGCHandle.Free();
			}
		}

		private void InternalOnServerResponded(IntPtr thisptr, HServerListRequest hRequest, int iServer)
		{
			m_ServerResponded(hRequest, iServer);
		}

		private void InternalOnServerFailedToRespond(IntPtr thisptr, HServerListRequest hRequest, int iServer)
		{
			m_ServerFailedToRespond(hRequest, iServer);
		}

		private void InternalOnRefreshComplete(IntPtr thisptr, HServerListRequest hRequest, EMatchMakingServerResponse response)
		{
			m_RefreshComplete(hRequest, response);
		}

		public static explicit operator IntPtr(ISteamMatchmakingServerListResponse that)
		{
			return that.m_pGCHandle.AddrOfPinnedObject();
		}
	}
	public class ISteamMatchmakingPingResponse
	{
		public delegate void ServerResponded(gameserveritem_t server);

		public delegate void ServerFailedToRespond();

		[UnmanagedFunctionPointer(CallingConvention.ThisCall)]
		private delegate void InternalServerResponded(IntPtr thisptr, gameserveritem_t server);

		[UnmanagedFunctionPointer(CallingConvention.ThisCall)]
		private delegate void InternalServerFailedToRespond(IntPtr thisptr);

		[StructLayout(LayoutKind.Sequential)]
		private class VTable
		{
			[NonSerialized]
			[MarshalAs(UnmanagedType.FunctionPtr)]
			public InternalServerResponded m_VTServerResponded;

			[NonSerialized]
			[MarshalAs(UnmanagedType.FunctionPtr)]
			public InternalServerFailedToRespond m_VTServerFailedToRespond;
		}

		private VTable m_VTable;

		private IntPtr m_pVTable;

		private GCHandle m_pGCHandle;

		private ServerResponded m_ServerResponded;

		private ServerFailedToRespond m_ServerFailedToRespond;

		public ISteamMatchmakingPingResponse(ServerResponded onServerResponded, ServerFailedToRespond onServerFailedToRespond)
		{
			if (onServerResponded == null || onServerFailedToRespond == null)
			{
				throw new ArgumentNullException();
			}
			m_ServerResponded = onServerResponded;
			m_ServerFailedToRespond = onServerFailedToRespond;
			m_VTable = new VTable
			{
				m_VTServerResponded = InternalOnServerResponded,
				m_VTServerFailedToRespond = InternalOnServerFailedToRespond
			};
			m_pVTable = Marshal.AllocHGlobal(Marshal.SizeOf(typeof(VTable)));
			Marshal.StructureToPtr(m_VTable, m_pVTable, fDeleteOld: false);
			m_pGCHandle = GCHandle.Alloc(m_pVTable, GCHandleType.Pinned);
		}

		~ISteamMatchmakingPingResponse()
		{
			if (m_pVTable != IntPtr.Zero)
			{
				Marshal.FreeHGlobal(m_pVTable);
			}
			if (m_pGCHandle.IsAllocated)
			{
				m_pGCHandle.Free();
			}
		}

		private void InternalOnServerResponded(IntPtr thisptr, gameserveritem_t server)
		{
			m_ServerResponded(server);
		}

		private void InternalOnServerFailedToRespond(IntPtr thisptr)
		{
			m_ServerFailedToRespond();
		}

		public static explicit operator IntPtr(ISteamMatchmakingPingResponse that)
		{
			return that.m_pGCHandle.AddrOfPinnedObject();
		}
	}
	public class ISteamMatchmakingPlayersResponse
	{
		public delegate void AddPlayerToList(string pchName, int nScore, float flTimePlayed);

		public delegate void PlayersFailedToRespond();

		public delegate void PlayersRefreshComplete();

		[UnmanagedFunctionPointer(CallingConvention.ThisCall)]
		public delegate void InternalAddPlayerToList(IntPtr thisptr, IntPtr pchName, int nScore, float flTimePlayed);

		[UnmanagedFunctionPointer(CallingConvention.ThisCall)]
		public delegate void InternalPlayersFailedToRespond(IntPtr thisptr);

		[UnmanagedFunctionPointer(CallingConvention.ThisCall)]
		public delegate void InternalPlayersRefreshComplete(IntPtr thisptr);

		[StructLayout(LayoutKind.Sequential)]
		private class VTable
		{
			[NonSerialized]
			[MarshalAs(UnmanagedType.FunctionPtr)]
			public InternalAddPlayerToList m_VTAddPlayerToList;

			[NonSerialized]
			[MarshalAs(UnmanagedType.FunctionPtr)]
			public InternalPlayersFailedToRespond m_VTPlayersFailedToRespond;

			[NonSerialized]
			[MarshalAs(UnmanagedType.FunctionPtr)]
			public InternalPlayersRefreshComplete m_VTPlayersRefreshComplete;
		}

		private VTable m_VTable;

		private IntPtr m_pVTable;

		private GCHandle m_pGCHandle;

		private AddPlayerToList m_AddPlayerToList;

		private PlayersFailedToRespond m_PlayersFailedToRespond;

		private PlayersRefreshComplete m_PlayersRefreshComplete;

		public ISteamMatchmakingPlayersResponse(AddPlayerToList onAddPlayerToList, PlayersFailedToRespond onPlayersFailedToRespond, PlayersRefreshComplete onPlayersRefreshComplete)
		{
			if (onAddPlayerToList == null || onPlayersFailedToRespond == null || onPlayersRefreshComplete == null)
			{
				throw new ArgumentNullException();
			}
			m_AddPlayerToList = onAddPlayerToList;
			m_PlayersFailedToRespond = onPlayersFailedToRespond;
			m_PlayersRefreshComplete = onPlayersRefreshComplete;
			m_VTable = new VTable
			{
				m_VTAddPlayerToList = InternalOnAddPlayerToList,
				m_VTPlayersFailedToRespond = InternalOnPlayersFailedToRespond,
				m_VTPlayersRefreshComplete = InternalOnPlayersRefreshComplete
			};
			m_pVTable = Marshal.AllocHGlobal(Marshal.SizeOf(typeof(VTable)));
			Marshal.StructureToPtr(m_VTable, m_pVTable, fDeleteOld: false);
			m_pGCHandle = GCHandle.Alloc(m_pVTable, GCHandleType.Pinned);
		}

		~ISteamMatchmakingPlayersResponse()
		{
			if (m_pVTable != IntPtr.Zero)
			{
				Marshal.FreeHGlobal(m_pVTable);
			}
			if (m_pGCHandle.IsAllocated)
			{
				m_pGCHandle.Free();
			}
		}

		private void InternalOnAddPlayerToList(IntPtr thisptr, IntPtr pchName, int nScore, float flTimePlayed)
		{
			m_AddPlayerToList(InteropHelp.PtrToStringUTF8(pchName), nScore, flTimePlayed);
		}

		private void InternalOnPlayersFailedToRespond(IntPtr thisptr)
		{
			m_PlayersFailedToRespond();
		}

		private void InternalOnPlayersRefreshComplete(IntPtr thisptr)
		{
			m_PlayersRefreshComplete();
		}

		public static explicit operator IntPtr(ISteamMatchmakingPlayersResponse that)
		{
			return that.m_pGCHandle.AddrOfPinnedObject();
		}
	}
	public class ISteamMatchmakingRulesResponse
	{
		public delegate void RulesResponded(string pchRule, string pchValue);

		public delegate void RulesFailedToRespond();

		public delegate void RulesRefreshComplete();

		[UnmanagedFunctionPointer(CallingConvention.ThisCall)]
		public delegate void InternalRulesResponded(IntPtr thisptr, IntPtr pchRule, IntPtr pchValue);

		[UnmanagedFunctionPointer(CallingConvention.ThisCall)]
		public delegate void InternalRulesFailedToRespond(IntPtr thisptr);

		[UnmanagedFunctionPointer(CallingConvention.ThisCall)]
		public delegate void InternalRulesRefreshComplete(IntPtr thisptr);

		[StructLayout(LayoutKind.Sequential)]
		private class VTable
		{
			[NonSerialized]
			[MarshalAs(UnmanagedType.FunctionPtr)]
			public InternalRulesResponded m_VTRulesResponded;

			[NonSerialized]
			[MarshalAs(UnmanagedType.FunctionPtr)]
			public InternalRulesFailedToRespond m_VTRulesFailedToRespond;

			[NonSerialized]
			[MarshalAs(UnmanagedType.FunctionPtr)]
			public InternalRulesRefreshComplete m_VTRulesRefreshComplete;
		}

		private VTable m_VTable;

		private IntPtr m_pVTable;

		private GCHandle m_pGCHandle;

		private RulesResponded m_RulesResponded;

		private RulesFailedToRespond m_RulesFailedToRespond;

		private RulesRefreshComplete m_RulesRefreshComplete;

		public ISteamMatchmakingRulesResponse(RulesResponded onRulesResponded, RulesFailedToRespond onRulesFailedToRespond, RulesRefreshComplete onRulesRefreshComplete)
		{
			if (onRulesResponded == null || onRulesFailedToRespond == null || onRulesRefreshComplete == null)
			{
				throw new ArgumentNullException();
			}
			m_RulesResponded = onRulesResponded;
			m_RulesFailedToRespond = onRulesFailedToRespond;
			m_RulesRefreshComplete = onRulesRefreshComplete;
			m_VTable = new VTable
			{
				m_VTRulesResponded = InternalOnRulesResponded,
				m_VTRulesFailedToRespond = InternalOnRulesFailedToRespond,
				m_VTRulesRefreshComplete = InternalOnRulesRefreshComplete
			};
			m_pVTable = Marshal.AllocHGlobal(Marshal.SizeOf(typeof(VTable)));
			Marshal.StructureToPtr(m_VTable, m_pVTable, fDeleteOld: false);
			m_pGCHandle = GCHandle.Alloc(m_pVTable, GCHandleType.Pinned);
		}

		~ISteamMatchmakingRulesResponse()
		{
			if (m_pVTable != IntPtr.Zero)
			{
				Marshal.FreeHGlobal(m_pVTable);
			}
			if (m_pGCHandle.IsAllocated)
			{
				m_pGCHandle.Free();
			}
		}

		private void InternalOnRulesResponded(IntPtr thisptr, IntPtr pchRule, IntPtr pchValue)
		{
			m_RulesResponded(InteropHelp.PtrToStringUTF8(pchRule), InteropHelp.PtrToStringUTF8(pchValue));
		}

		private void InternalOnRulesFailedToRespond(IntPtr thisptr)
		{
			m_RulesFailedToRespond();
		}

		private void InternalOnRulesRefreshComplete(IntPtr thisptr)
		{
			m_RulesRefreshComplete();
		}

		public static explicit operator IntPtr(ISteamMatchmakingRulesResponse that)
		{
			return that.m_pGCHandle.AddrOfPinnedObject();
		}
	}
	public static class Packsize
	{
		[StructLayout(LayoutKind.Sequential, Pack = 8)]
		private struct ValvePackingSentinel_t
		{
			private uint m_u32;

			private ulong m_u64;

			private ushort m_u16;

			private double m_d;
		}

		public const int value = 8;

		public static bool Test()
		{
			int num = Marshal.SizeOf(typeof(ValvePackingSentinel_t));
			int num2 = Marshal.SizeOf(typeof(RemoteStorageEnumerateUserSubscribedFilesResult_t));
			if (num != 32 || num2 != 616)
			{
				return false;
			}
			return true;
		}
	}
	public static class Version
	{
		public const string SteamworksNETVersion = "7.0.0";

		public const string SteamworksSDKVersion = "1.34";

		public const string SteamAPIDLLVersion = "02.89.45.04";

		public const int SteamAPIDLLSize = 186560;

		public const int SteamAPI64DLLSize = 206760;
	}
	public static class SteamAPI
	{
		public static bool RestartAppIfNecessary(AppId_t unOwnAppID)
		{
			InteropHelp.TestIfPlatformSupported();
			return NativeMethods.SteamAPI_RestartAppIfNecessary(unOwnAppID);
		}

		public static bool InitSafe()
		{
			return Init();
		}

		public static bool Init()
		{
			InteropHelp.TestIfPlatformSupported();
			return NativeMethods.SteamAPI_InitSafe();
		}

		public static void Shutdown()
		{
			InteropHelp.TestIfPlatformSupported();
			NativeMethods.SteamAPI_Shutdown();
		}

		public static void RunCallbacks()
		{
			InteropHelp.TestIfPlatformSupported();
			NativeMethods.SteamAPI_RunCallbacks();
		}

		public static bool IsSteamRunning()
		{
			InteropHelp.TestIfPlatformSupported();
			return NativeMethods.SteamAPI_IsSteamRunning();
		}

		public static HSteamUser GetHSteamUserCurrent()
		{
			InteropHelp.TestIfPlatformSupported();
			return (HSteamUser)NativeMethods.Steam_GetHSteamUserCurrent();
		}

		public static HSteamPipe GetHSteamPipe()
		{
			InteropHelp.TestIfPlatformSupported();
			return (HSteamPipe)NativeMethods.SteamAPI_GetHSteamPipe();
		}

		public static HSteamUser GetHSteamUser()
		{
			InteropHelp.TestIfPlatformSupported();
			return (HSteamUser)NativeMethods.SteamAPI_GetHSteamUser();
		}
	}
	public static class GameServer
	{
		public static bool InitSafe(uint unIP, ushort usSteamPort, ushort usGamePort, ushort usQueryPort, EServerMode eServerMode, string pchVersionString)
		{
			InteropHelp.TestIfPlatformSupported();
			using InteropHelp.UTF8StringHandle pchVersionString2 = new InteropHelp.UTF8StringHandle(pchVersionString);
			return NativeMethods.SteamGameServer_InitSafe(unIP, usSteamPort, usGamePort, usQueryPort, eServerMode, pchVersionString2);
		}

		public static bool Init(uint unIP, ushort usSteamPort, ushort usGamePort, ushort usQueryPort, EServerMode eServerMode, string pchVersionString)
		{
			InteropHelp.TestIfPlatformSupported();
			using InteropHelp.UTF8StringHandle pchVersionString2 = new InteropHelp.UTF8StringHandle(pchVersionString);
			return NativeMethods.SteamGameServer_InitSafe(unIP, usSteamPort, usGamePort, usQueryPort, eServerMode, pchVersionString2);
		}

		public static void Shutdown()
		{
			InteropHelp.TestIfPlatformSupported();
			NativeMethods.SteamGameServer_Shutdown();
		}

		public static void RunCallbacks()
		{
			InteropHelp.TestIfPlatformSupported();
			NativeMethods.SteamGameServer_RunCallbacks();
		}

		public static bool BSecure()
		{
			InteropHelp.TestIfPlatformSupported();
			return NativeMethods.SteamGameServer_BSecure();
		}

		public static CSteamID GetSteamID()
		{
			InteropHelp.TestIfPlatformSupported();
			return (CSteamID)NativeMethods.SteamGameServer_GetSteamID();
		}

		public static HSteamPipe GetHSteamPipe()
		{
			InteropHelp.TestIfPlatformSupported();
			return (HSteamPipe)NativeMethods.SteamGameServer_GetHSteamPipe();
		}

		public static HSteamUser GetHSteamUser()
		{
			InteropHelp.TestIfPlatformSupported();
			return (HSteamUser)NativeMethods.SteamGameServer_GetHSteamUser();
		}
	}
	public static class SteamEncryptedAppTicket
	{
		public static bool BDecryptTicket(byte[] rgubTicketEncrypted, uint cubTicketEncrypted, byte[] rgubTicketDecrypted, ref uint pcubTicketDecrypted, byte[] rgubKey, int cubKey)
		{
			InteropHelp.TestIfPlatformSupported();
			return NativeMethods.BDecryptTicket(rgubTicketEncrypted, cubTicketEncrypted, rgubTicketDecrypted, ref pcubTicketDecrypted, rgubKey, cubKey);
		}

		public static bool BIsTicketForApp(byte[] rgubTicketDecrypted, uint cubTicketDecrypted, AppId_t nAppID)
		{
			InteropHelp.TestIfPlatformSupported();
			return NativeMethods.BIsTicketForApp(rgubTicketDecrypted, cubTicketDecrypted, nAppID);
		}

		public static uint GetTicketIssueTime(byte[] rgubTicketDecrypted, uint cubTicketDecrypted)
		{
			InteropHelp.TestIfPlatformSupported();
			return NativeMethods.GetTicketIssueTime(rgubTicketDecrypted, cubTicketDecrypted);
		}

		public static void GetTicketSteamID(byte[] rgubTicketDecrypted, uint cubTicketDecrypted, out CSteamID psteamID)
		{
			InteropHelp.TestIfPlatformSupported();
			NativeMethods.GetTicketSteamID(rgubTicketDecrypted, cubTicketDecrypted, out psteamID);
		}

		public static uint GetTicketAppID(byte[] rgubTicketDecrypted, uint cubTicketDecrypted)
		{
			InteropHelp.TestIfPlatformSupported();
			return NativeMethods.GetTicketAppID(rgubTicketDecrypted, cubTicketDecrypted);
		}

		public static bool BUserOwnsAppInTicket(byte[] rgubTicketDecrypted, uint cubTicketDecrypted, AppId_t nAppID)
		{
			InteropHelp.TestIfPlatformSupported();
			return NativeMethods.BUserOwnsAppInTicket(rgubTicketDecrypted, cubTicketDecrypted, nAppID);
		}

		public static bool BUserIsVacBanned(byte[] rgubTicketDecrypted, uint cubTicketDecrypted)
		{
			InteropHelp.TestIfPlatformSupported();
			return NativeMethods.BUserIsVacBanned(rgubTicketDecrypted, cubTicketDecrypted);
		}

		public static byte[] GetUserVariableData(byte[] rgubTicketDecrypted, uint cubTicketDecrypted, out uint pcubUserData)
		{
			InteropHelp.TestIfPlatformSupported();
			IntPtr userVariableData = NativeMethods.GetUserVariableData(rgubTicketDecrypted, cubTicketDecrypted, out pcubUserData);
			byte[] array = new byte[pcubUserData];
			Marshal.Copy(userVariableData, array, 0, (int)pcubUserData);
			return array;
		}
	}
	[StructLayout(LayoutKind.Sequential, Pack = 4, Size = 372)]
	public class gameserveritem_t
	{
		public servernetadr_t m_NetAdr;

		public int m_nPing;

		[MarshalAs(UnmanagedType.I1)]
		public bool m_bHadSuccessfulResponse;

		[MarshalAs(UnmanagedType.I1)]
		public bool m_bDoNotRefresh;

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
		private byte[] m_szGameDir;

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
		private byte[] m_szMap;

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
		private byte[] m_szGameDescription;

		public uint m_nAppID;

		public int m_nPlayers;

		public int m_nMaxPlayers;

		public int m_nBotPlayers;

		[MarshalAs(UnmanagedType.I1)]
		public bool m_bPassword;

		[MarshalAs(UnmanagedType.I1)]
		public bool m_bSecure;

		public uint m_ulTimeLastPlayed;

		public int m_nServerVersion;

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
		private byte[] m_szServerName;

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)]
		private byte[] m_szGameTags;

		public CSteamID m_steamID;

		public string GetGameDir()
		{
			return Encoding.UTF8.GetString(m_szGameDir, 0, Array.IndexOf(m_szGameDir, (byte)0));
		}

		public void SetGameDir(string dir)
		{
			m_szGameDir = Encoding.UTF8.GetBytes(dir + "\0");
		}

		public string GetMap()
		{
			return Encoding.UTF8.GetString(m_szMap, 0, Array.IndexOf(m_szMap, (byte)0));
		}

		public void SetMap(string map)
		{
			m_szMap = Encoding.UTF8.GetBytes(map + "\0");
		}

		public string GetGameDescription()
		{
			return Encoding.UTF8.GetString(m_szGameDescription, 0, Array.IndexOf(m_szGameDescription, (byte)0));
		}

		public void SetGameDescription(string desc)
		{
			m_szGameDescription = Encoding.UTF8.GetBytes(desc + "\0");
		}

		public string GetServerName()
		{
			if (m_szServerName[0] == 0)
			{
				return m_NetAdr.GetConnectionAddressString();
			}
			return Encoding.UTF8.GetString(m_szServerName, 0, Array.IndexOf(m_szServerName, (byte)0));
		}

		public void SetServerName(string name)
		{
			m_szServerName = Encoding.UTF8.GetBytes(name + "\0");
		}

		public string GetGameTags()
		{
			return Encoding.UTF8.GetString(m_szGameTags, 0, Array.IndexOf(m_szGameTags, (byte)0));
		}

		public void SetGameTags(string tags)
		{
			m_szGameTags = Encoding.UTF8.GetBytes(tags + "\0");
		}
	}
	public struct servernetadr_t
	{
		private ushort m_usConnectionPort;

		private ushort m_usQueryPort;

		private uint m_unIP;

		public void Init(uint ip, ushort usQueryPort, ushort usConnectionPort)
		{
			m_unIP = ip;
			m_usQueryPort = usQueryPort;
			m_usConnectionPort = usConnectionPort;
		}

		public ushort GetQueryPort()
		{
			return m_usQueryPort;
		}

		public void SetQueryPort(ushort usPort)
		{
			m_usQueryPort = usPort;
		}

		public ushort GetConnectionPort()
		{
			return m_usConnectionPort;
		}

		public void SetConnectionPort(ushort usPort)
		{
			m_usConnectionPort = usPort;
		}

		public uint GetIP()
		{
			return m_unIP;
		}

		public void SetIP(uint unIP)
		{
			m_unIP = unIP;
		}

		public string GetConnectionAddressString()
		{
			return ToString(m_unIP, m_usConnectionPort);
		}

		public string GetQueryAddressString()
		{
			return ToString(m_unIP, m_usQueryPort);
		}

		public static string ToString(uint unIP, ushort usPort)
		{
			return $"{(ulong)(unIP >> 24) & 0xFFuL}.{(ulong)(unIP >> 16) & 0xFFuL}.{(ulong)(unIP >> 8) & 0xFFuL}.{(ulong)unIP & 0xFFuL}:{usPort}";
		}

		public static bool operator <(servernetadr_t x, servernetadr_t y)
		{
			if (x.m_unIP >= y.m_unIP)
			{
				if (x.m_unIP == y.m_unIP)
				{
					return x.m_usQueryPort < y.m_usQueryPort;
				}
				return false;
			}
			return true;
		}

		public static bool operator >(servernetadr_t x, servernetadr_t y)
		{
			if (x.m_unIP <= y.m_unIP)
			{
				if (x.m_unIP == y.m_unIP)
				{
					return x.m_usQueryPort > y.m_usQueryPort;
				}
				return false;
			}
			return true;
		}

		public override bool Equals(object other)
		{
			if (other is servernetadr_t)
			{
				return this == (servernetadr_t)other;
			}
			return false;
		}

		public override int GetHashCode()
		{
			return m_unIP.GetHashCode() + m_usQueryPort.GetHashCode() + m_usConnectionPort.GetHashCode();
		}

		public static bool operator ==(servernetadr_t x, servernetadr_t y)
		{
			if (x.m_unIP == y.m_unIP && x.m_usQueryPort == y.m_usQueryPort)
			{
				return x.m_usConnectionPort == y.m_usConnectionPort;
			}
			return false;
		}

		public static bool operator !=(servernetadr_t x, servernetadr_t y)
		{
			return !(x == y);
		}

		public bool Equals(servernetadr_t other)
		{
			if (m_unIP == other.m_unIP && m_usQueryPort == other.m_usQueryPort)
			{
				return m_usConnectionPort == other.m_usConnectionPort;
			}
			return false;
		}

		public int CompareTo(servernetadr_t other)
		{
			return m_unIP.CompareTo(other.m_unIP) + m_usQueryPort.CompareTo(other.m_usQueryPort) + m_usConnectionPort.CompareTo(other.m_usConnectionPort);
		}
	}
	public struct HSteamPipe : IEquatable<HSteamPipe>, IComparable<HSteamPipe>
	{
		public int m_HSteamPipe;

		public HSteamPipe(int value)
		{
			m_HSteamPipe = value;
		}

		public override string ToString()
		{
			return m_HSteamPipe.ToString();
		}

		public override bool Equals(object other)
		{
			if (other is HSteamPipe)
			{
				return this == (HSteamPipe)other;
			}
			return false;
		}

		public override int GetHashCode()
		{
			return m_HSteamPipe.GetHashCode();
		}

		public static bool operator ==(HSteamPipe x, HSteamPipe y)
		{
			return x.m_HSteamPipe == y.m_HSteamPipe;
		}

		public static bool operator !=(HSteamPipe x, HSteamPipe y)
		{
			return !(x == y);
		}

		public static explicit operator HSteamPipe(int value)
		{
			return new HSteamPipe(value);
		}

		public static explicit operator int(HSteamPipe that)
		{
			return that.m_HSteamPipe;
		}

		public bool Equals(HSteamPipe other)
		{
			return m_HSteamPipe == other.m_HSteamPipe;
		}

		public int CompareTo(HSteamPipe other)
		{
			return m_HSteamPipe.CompareTo(other.m_HSteamPipe);
		}
	}
	public struct HSteamUser : IEquatable<HSteamUser>, IComparable<HSteamUser>
	{
		public int m_HSteamUser;

		public HSteamUser(int value)
		{
			m_HSteamUser = value;
		}

		public override string ToString()
		{
			return m_HSteamUser.ToString();
		}

		public override bool Equals(object other)
		{
			if (other is HSteamUser)
			{
				return this == (HSteamUser)other;
			}
			return false;
		}

		public override int GetHashCode()
		{
			return m_HSteamUser.GetHashCode();
		}

		public static bool operator ==(HSteamUser x, HSteamUser y)
		{
			return x.m_HSteamUser == y.m_HSteamUser;
		}

		public static bool operator !=(HSteamUser x, HSteamUser y)
		{
			return !(x == y);
		}

		public static explicit operator HSteamUser(int value)
		{
			return new HSteamUser(value);
		}

		public static explicit operator int(HSteamUser that)
		{
			return that.m_HSteamUser;
		}

		public bool Equals(HSteamUser other)
		{
			return m_HSteamUser == other.m_HSteamUser;
		}

		public int CompareTo(HSteamUser other)
		{
			return m_HSteamUser.CompareTo(other.m_HSteamUser);
		}
	}
	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	public delegate void SteamAPI_CheckCallbackRegistered_t(int iCallbackNum);
	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	public delegate void SteamAPI_PostAPIResultInProcess_t(SteamAPICall_t callHandle, IntPtr pUnknown, uint unCallbackSize, int iCallbackNum);
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate void SteamAPIWarningMessageHook_t(int nSeverity, StringBuilder pchDebugText);
	public struct CGameID : IEquatable<CGameID>, IComparable<CGameID>
	{
		public enum EGameIDType
		{
			k_EGameIDTypeApp,
			k_EGameIDTypeGameMod,
			k_EGameIDTypeShortcut,
			k_EGameIDTypeP2P
		}

		public ulong m_GameID;

		public CGameID(ulong GameID)
		{
			m_GameID = GameID;
		}

		public CGameID(AppId_t nAppID)
		{
			m_GameID = 0uL;
			SetAppID(nAppID);
		}

		public CGameID(AppId_t nAppID, uint nModID)
		{
			m_GameID = 0uL;
			SetAppID(nAppID);
			SetType(EGameIDType.k_EGameIDTypeGameMod);
			SetModID(nModID);
		}

		public bool IsSteamApp()
		{
			return Type() == EGameIDType.k_EGameIDTypeApp;
		}

		public bool IsMod()
		{
			return Type() == EGameIDType.k_EGameIDTypeGameMod;
		}

		public bool IsShortcut()
		{
			return Type() == EGameIDType.k_EGameIDTypeShortcut;
		}

		public bool IsP2PFile()
		{
			return Type() == EGameIDType.k_EGameIDTypeP2P;
		}

		public AppId_t AppID()
		{
			return new AppId_t((uint)(m_GameID & 0xFFFFFF));
		}

		public EGameIDType Type()
		{
			return (EGameIDType)((m_GameID >> 24) & 0xFF);
		}

		public uint ModID()
		{
			return (uint)((m_GameID >> 32) & 0xFFFFFFFFu);
		}

		public bool IsValid()
		{
			switch (Type())
			{
			case EGameIDType.k_EGameIDTypeApp:
				return AppID() != AppId_t.Invalid;
			case EGameIDType.k_EGameIDTypeGameMod:
				if (AppID() != AppId_t.Invalid)
				{
					return (ModID() & 0x80000000u) != 0;
				}
				return false;
			case EGameIDType.k_EGameIDTypeShortcut:
				return (ModID() & 0x80000000u) != 0;
			case EGameIDType.k_EGameIDTypeP2P:
				if (AppID() == AppId_t.Invalid)
				{
					return (ModID() & 0x80000000u) != 0;
				}
				return false;
			default:
				return false;
			}
		}

		public void Reset()
		{
			m_GameID = 0uL;
		}

		public void Set(ulong GameID)
		{
			m_GameID = GameID;
		}

		private void SetAppID(AppId_t other)
		{
			m_GameID = (m_GameID & 0xFFFFFFFFFF000000uL) | ((ulong)(uint)other & 0xFFFFFFuL);
		}

		private void SetType(EGameIDType other)
		{
			m_GameID = (m_GameID & 0xFFFFFFFF00FFFFFFuL) | (((ulong)other & 0xFFuL) << 24);
		}

		private void SetModID(uint other)
		{
			m_GameID = (m_GameID & 0xFFFFFFFFu) | (((ulong)other & 0xFFFFFFFFuL) << 32);
		}

		public override string ToString()
		{
			return m_GameID.ToString();
		}

		public override bool Equals(object other)
		{
			if (other is CGameID)
			{
				return this == (CGameID)other;
			}
			return false;
		}

		public override int GetHashCode()
		{
			return m_GameID.GetHashCode();
		}

		public static bool operator ==(CGameID x, CGameID y)
		{
			return x.m_GameID == y.m_GameID;
		}

		public static bool operator !=(CGameID x, CGameID y)
		{
			return !(x == y);
		}

		public static explicit operator CGameID(ulong value)
		{
			return new CGameID(value);
		}

		public static explicit operator ulong(CGameID that)
		{
			return that.m_GameID;
		}

		public bool Equals(CGameID other)
		{
			return m_GameID == other.m_GameID;
		}

		public int CompareTo(CGameID other)
		{
			return m_GameID.CompareTo(other.m_GameID);
		}
	}
	public struct CSteamID : IEquatable<CSteamID>, IComparable<CSteamID>
	{
		public static readonly CSteamID Nil = default(CSteamID);

		public static readonly CSteamID OutofDateGS = new CSteamID(new AccountID_t(0u), 0u, EUniverse.k_EUniverseInvalid, EAccountType.k_EAccountTypeInvalid);

		public static readonly CSteamID LanModeGS = new CSteamID(new AccountID_t(0u), 0u, EUniverse.k_EUniversePublic, EAccountType.k_EAccountTypeInvalid);

		public static readonly CSteamID NotInitYetGS = new CSteamID(new AccountID_t(1u), 0u, EUniverse.k_EUniverseInvalid, EAccountType.k_EAccountTypeInvalid);

		public static readonly CSteamID NonSteamGS = new CSteamID(new AccountID_t(2u), 0u, EUniverse.k_EUniverseInvalid, EAccountType.k_EAccountTypeInvalid);

		public ulong m_SteamID;

		public CSteamID(AccountID_t unAccountID, EUniverse eUniverse, EAccountType eAccountType)
		{
			m_SteamID = 0uL;
			Set(unAccountID, eUniverse, eAccountType);
		}

		public CSteamID(AccountID_t unAccountID, uint unAccountInstance, EUniverse eUniverse, EAccountType eAccountType)
		{
			m_SteamID = 0uL;
			InstancedSet(unAccountID, unAccountInstance, eUniverse, eAccountType);
		}

		public CSteamID(ulong ulSteamID)
		{
			m_SteamID = ulSteamID;
		}

		public void Set(AccountID_t unAccountID, EUniverse eUniverse, EAccountType eAccountType)
		{
			SetAccountID(unAccountID);
			SetEUniverse(eUniverse);
			SetEAccountType(eAccountType);
			if (eAccountType == EAccountType.k_EAccountTypeClan || eAccountType == EAccountType.k_EAccountTypeGameServer)
			{
				SetAccountInstance(0u);
			}
			else
			{
				SetAccountInstance(1u);
			}
		}

		public void InstancedSet(AccountID_t unAccountID, uint unInstance, EUniverse eUniverse, EAccountType eAccountType)
		{
			SetAccountID(unAccountID);
			SetEUniverse(eUniverse);
			SetEAccountType(eAccountType);
			SetAccountInstance(unInstance);
		}

		public void Clear()
		{
			m_SteamID = 0uL;
		}

		public void CreateBlankAnonLogon(EUniverse eUniverse)
		{
			SetAccountID(new AccountID_t(0u));
			SetEUniverse(eUniverse);
			SetEAccountType(EAccountType.k_EAccountTypeAnonGameServer);
			SetAccountInstance(0u);
		}

		public void CreateBlankAnonUserLogon(EUniverse eUniverse)
		{
			SetAccountID(new AccountID_t(0u));
			SetEUniverse(eUniverse);
			SetEAccountType(EAccountType.k_EAccountTypeAnonUser);
			SetAccountInstance(0u);
		}

		public bool BBlankAnonAccount()
		{
			if (GetAccountID() == new AccountID_t(0u) && BAnonAccount())
			{
				return GetUnAccountInstance() == 0;
			}
			return false;
		}

		public bool BGameServerAccount()
		{
			if (GetEAccountType() != EAccountType.k_EAccountTypeGameServer)
			{
				return GetEAccountType() == EAccountType.k_EAccountTypeAnonGameServer;
			}
			return true;
		}

		public bool BPersistentGameServerAccount()
		{
			return GetEAccountType() == EAccountType.k_EAccountTypeGameServer;
		}

		public bool BAnonGameServerAccount()
		{
			return GetEAccountType() == EAccountType.k_EAccountTypeAnonGameServer;
		}

		public bool BContentServerAccount()
		{
			return GetEAccountType() == EAccountType.k_EAccountTypeContentServer;
		}

		public bool BClanAccount()
		{
			return GetEAccountType() == EAccountType.k_EAccountTypeClan;
		}

		public bool BChatAccount()
		{
			return GetEAccountType() == EAccountType.k_EAccountTypeChat;
		}

		public bool IsLobby()
		{
			if (GetEAccountType() == EAccountType.k_EAccountTypeChat)
			{
				return (GetUnAccountInstance() & 0x40000) != 0;
			}
			return false;
		}

		public bool BIndividualAccount()
		{
			if (GetEAccountType() != EAccountType.k_EAccountTypeIndividual)
			{
				return GetEAccountType() == EAccountType.k_EAccountTypeConsoleUser;
			}
			return true;
		}

		public bool BAnonAccount()
		{
			if (GetEAccountType() != EAccountType.k_EAccountTypeAnonUser)
			{
				return GetEAccountType() == EAccountType.k_EAccountTypeAnonGameServer;
			}
			return true;
		}

		public bool BAnonUserAccount()
		{
			return GetEAccountType() == EAccountType.k_EAccountTypeAnonUser;
		}

		public bool BConsoleUserAccount()
		{
			return GetEAccountType() == EAccountType.k_EAccountTypeConsoleUser;
		}

		public void SetAccountID(AccountID_t other)
		{
			m_SteamID = (m_SteamID & 0xFFFFFFFF00000000uL) | ((ulong)(uint)other & 0xFFFFFFFFuL);
		}

		public void SetAccountInstance(uint other)
		{
			m_SteamID = (m_SteamID & 0xFFF00000FFFFFFFFuL) | (((ulong)other & 0xFFFFFuL) << 32);
		}

		public void SetEAccountType(EAccountType other)
		{
			m_SteamID = (m_SteamID & 0xFF0FFFFFFFFFFFFFuL) | (((ulong)other & 0xFuL) << 52);
		}

		public void SetEUniverse(EUniverse other)
		{
			m_SteamID = (m_SteamID & 0xFFFFFFFFFFFFFFuL) | (((ulong)other & 0xFFuL) << 56);
		}

		public void ClearIndividualInstance()
		{
			if (BIndividualAccount())
			{
				SetAccountInstance(0u);
			}
		}

		public bool HasNoIndividualInstance()
		{
			if (BIndividualAccount())
			{
				return GetUnAccountInstance() == 0;
			}
			return false;
		}

		public AccountID_t GetAccountID()
		{
			return new AccountID_t((uint)(m_SteamID & 0xFFFFFFFFu));
		}

		public uint GetUnAccountInstance()
		{
			return (uint)((m_SteamID >> 32) & 0xFFFFF);
		}

		public EAccountType GetEAccountType()
		{
			return (EAccountType)((m_SteamID >> 52) & 0xF);
		}

		public EUniverse GetEUniverse()
		{
			return (EUniverse)((m_SteamID >> 56) & 0xFF);
		}

		public bool IsValid()
		{
			if (GetEAccountType() <= EAccountType.k_EAccountTypeInvalid || GetEAccountType() >= EAccountType.k_EAccountTypeMax)
			{
				return false;
			}
			if (GetEUniverse() <= EUniverse.k_EUniverseInvalid || GetEUniverse() >= EUniverse.k_EUniverseMax)
			{
				return false;
			}
			if (GetEAccountType() == EAccountType.k_EAccountTypeIndividual && (GetAccountID() == new AccountID_t(0u) || GetUnAccountInstance() > 4))
			{
				return false;
			}
			if (GetEAccountType() == EAccountType.k_EAccountTypeClan && (GetAccountID() == new AccountID_t(0u) || GetUnAccountInstance() != 0))
			{
				return false;
			}
			if (GetEAccountType() == EAccountType.k_EAccountTypeGameServer && GetAccountID() == new AccountID_t(0u))
			{
				return false;
			}
			return true;
		}

		public override string ToString()
		{
			return m_SteamID.ToString();
		}

		public override bool Equals(object other)
		{
			if (other is CSteamID)
			{
				return this == (CSteamID)other;
			}
			return false;
		}

		public override int GetHashCode()
		{
			return m_SteamID.GetHashCode();
		}

		public static bool operator ==(CSteamID x, CSteamID y)
		{
			return x.m_SteamID == y.m_SteamID;
		}

		public static bool operator !=(CSteamID x, CSteamID y)
		{
			return !(x == y);
		}

		public static explicit operator CSteamID(ulong value)
		{
			return new CSteamID(value);
		}

		public static explicit operator ulong(CSteamID that)
		{
			return that.m_SteamID;
		}

		public bool Equals(CSteamID other)
		{
			return m_SteamID == other.m_SteamID;
		}

		public int CompareTo(CSteamID other)
		{
			return m_SteamID.CompareTo(other.m_SteamID);
		}
	}
	public struct HAuthTicket : IEquatable<HAuthTicket>, IComparable<HAuthTicket>
	{
		public static readonly HAuthTicket Invalid = new HAuthTicket(0u);

		public uint m_HAuthTicket;

		public HAuthTicket(uint value)
		{
			m_HAuthTicket = value;
		}

		public override string ToString()
		{
			return m_HAuthTicket.ToString();
		}

		public override bool Equals(object other)
		{
			if (other is HAuthTicket)
			{
				return this == (HAuthTicket)other;
			}
			return false;
		}

		public override int GetHashCode()
		{
			return m_HAuthTicket.GetHashCode();
		}

		public static bool operator ==(HAuthTicket x, HAuthTicket y)
		{
			return x.m_HAuthTicket == y.m_HAuthTicket;
		}

		public static bool operator !=(HAuthTicket x, HAuthTicket y)
		{
			return !(x == y);
		}

		public static explicit operator HAuthTicket(uint value)
		{
			return new HAuthTicket(value);
		}

		public static explicit operator uint(HAuthTicket that)
		{
			return that.m_HAuthTicket;
		}

		public bool Equals(HAuthTicket other)
		{
			return m_HAuthTicket == other.m_HAuthTicket;
		}

		public int CompareTo(HAuthTicket other)
		{
			return m_HAuthTicket.CompareTo(other.m_HAuthTicket);
		}
	}
	public struct FriendsGroupID_t : IEquatable<FriendsGroupID_t>, IComparable<FriendsGroupID_t>
	{
		public static readonly FriendsGroupID_t Invalid = new FriendsGroupID_t(-1);

		public short m_FriendsGroupID;

		public FriendsGroupID_t(short value)
		{
			m_FriendsGroupID = value;
		}

		public override string ToString()
		{
			return m_FriendsGroupID.ToString();
		}

		public override bool Equals(object other)
		{
			if (other is FriendsGroupID_t)
			{
				return this == (FriendsGroupID_t)other;
			}
			return false;
		}

		public override int GetHashCode()
		{
			return m_FriendsGroupID.GetHashCode();
		}

		public static bool operator ==(FriendsGroupID_t x, FriendsGroupID_t y)
		{
			return x.m_FriendsGroupID == y.m_FriendsGroupID;
		}

		public static bool operator !=(FriendsGroupID_t x, FriendsGroupID_t y)
		{
			return !(x == y);
		}

		public static explicit operator FriendsGroupID_t(short value)
		{
			return new FriendsGroupID_t(value);
		}

		public static explicit operator short(FriendsGroupID_t that)
		{
			return that.m_FriendsGroupID;
		}

		public bool Equals(FriendsGroupID_t other)
		{
			return m_FriendsGroupID == other.m_FriendsGroupID;
		}

		public int CompareTo(FriendsGroupID_t other)
		{
			return m_FriendsGroupID.CompareTo(other.m_FriendsGroupID);
		}
	}
	public struct HHTMLBrowser : IEquatable<HHTMLBrowser>, IComparable<HHTMLBrowser>
	{
		public static readonly HHTMLBrowser Invalid = new HHTMLBrowser(0u);

		public uint m_HHTMLBrowser;

		public HHTMLBrowser(uint value)
		{
			m_HHTMLBrowser = value;
		}

		public override string ToString()
		{
			return m_HHTMLBrowser.ToString();
		}

		public override bool Equals(object other)
		{
			if (other is HHTMLBrowser)
			{
				return this == (HHTMLBrowser)other;
			}
			return false;
		}

		public override int GetHashCode()
		{
			return m_HHTMLBrowser.GetHashCode();
		}

		public static bool operator ==(HHTMLBrowser x, HHTMLBrowser y)
		{
			return x.m_HHTMLBrowser == y.m_HHTMLBrowser;
		}

		public static bool operator !=(HHTMLBrowser x, HHTMLBrowser y)
		{
			return !(x == y);
		}

		public static explicit operator HHTMLBrowser(uint value)
		{
			return new HHTMLBrowser(value);
		}

		public static explicit operator uint(HHTMLBrowser that)
		{
			return that.m_HHTMLBrowser;
		}

		public bool Equals(HHTMLBrowser other)
		{
			return m_HHTMLBrowser == other.m_HHTMLBrowser;
		}

		public int CompareTo(HHTMLBrowser other)
		{
			return m_HHTMLBrowser.CompareTo(other.m_HHTMLBrowser);
		}
	}
	public struct HTTPCookieContainerHandle : IEquatable<HTTPCookieContainerHandle>, IComparable<HTTPCookieContainerHandle>
	{
		public static readonly HTTPCookieContainerHandle Invalid = new HTTPCookieContainerHandle(0u);

		public uint m_HTTPCookieContainerHandle;

		public HTTPCookieContainerHandle(uint value)
		{
			m_HTTPCookieContainerHandle = value;
		}

		public override string ToString()
		{
			return m_HTTPCookieContainerHandle.ToString();
		}

		public override bool Equals(object other)
		{
			if (other is HTTPCookieContainerHandle)
			{
				return this == (HTTPCookieContainerHandle)other;
			}
			return false;
		}

		public override int GetHashCode()
		{
			return m_HTTPCookieContainerHandle.GetHashCode();
		}

		public static bool operator ==(HTTPCookieContainerHandle x, HTTPCookieContainerHandle y)
		{
			return x.m_HTTPCookieContainerHandle == y.m_HTTPCookieContainerHandle;
		}

		public static bool operator !=(HTTPCookieContainerHandle x, HTTPCookieContainerHandle y)
		{
			return !(x == y);
		}

		public static explicit operator HTTPCookieContainerHandle(uint value)
		{
			return new HTTPCookieContainerHandle(value);
		}

		public static explicit operator uint(HTTPCookieContainerHandle that)
		{
			return that.m_HTTPCookieContainerHandle;
		}

		public bool Equals(HTTPCookieContainerHandle other)
		{
			return m_HTTPCookieContainerHandle == other.m_HTTPCookieContainerHandle;
		}

		public int CompareTo(HTTPCookieContainerHandle other)
		{
			return m_HTTPCookieContainerHandle.CompareTo(other.m_HTTPCookieContainerHandle);
		}
	}
	public struct HTTPRequestHandle : IEquatable<HTTPRequestHandle>, IComparable<HTTPRequestHandle>
	{
		public static readonly HTTPRequestHandle Invalid = new HTTPRequestHandle(0u);

		public uint m_HTTPRequestHandle;

		public HTTPRequestHandle(uint value)
		{
			m_HTTPRequestHandle = value;
		}

		public override string ToString()
		{
			return m_HTTPRequestHandle.ToString();
		}

		public override bool Equals(object other)
		{
			if (other is HTTPRequestHandle)
			{
				return this == (HTTPRequestHandle)other;
			}
			return false;
		}

		public override int GetHashCode()
		{
			return m_HTTPRequestHandle.GetHashCode();
		}

		public static bool operator ==(HTTPRequestHandle x, HTTPRequestHandle y)
		{
			return x.m_HTTPRequestHandle == y.m_HTTPRequestHandle;
		}

		public static bool operator !=(HTTPRequestHandle x, HTTPRequestHandle y)
		{
			return !(x == y);
		}

		public static explicit operator HTTPRequestHandle(uint value)
		{
			return new HTTPRequestHandle(value);
		}

		public static explicit operator uint(HTTPRequestHandle that)
		{
			return that.m_HTTPRequestHandle;
		}

		public bool Equals(HTTPRequestHandle other)
		{
			return m_HTTPRequestHandle == other.m_HTTPRequestHandle;
		}

		public int CompareTo(HTTPRequestHandle other)
		{
			return m_HTTPRequestHandle.CompareTo(other.m_HTTPRequestHandle);
		}
	}
	public struct SteamInventoryResult_t : IEquatable<SteamInventoryResult_t>, IComparable<SteamInventoryResult_t>
	{
		public static readonly SteamInventoryResult_t Invalid = new SteamInventoryResult_t(-1);

		public int m_SteamInventoryResult;

		public SteamInventoryResult_t(int value)
		{
			m_SteamInventoryResult = value;
		}

		public override string ToString()
		{
			return m_SteamInventoryResult.ToString();
		}

		public override bool Equals(object other)
		{
			if (other is SteamInventoryResult_t)
			{
				return this == (SteamInventoryResult_t)other;
			}
			return false;
		}

		public override int GetHashCode()
		{
			return m_SteamInventoryResult.GetHashCode();
		}

		public static bool operator ==(SteamInventoryResult_t x, SteamInventoryResult_t y)
		{
			return x.m_SteamInventoryResult == y.m_SteamInventoryResult;
		}

		public static bool operator !=(SteamInventoryResult_t x, SteamInventoryResult_t y)
		{
			return !(x == y);
		}

		public static explicit operator SteamInventoryResult_t(int value)
		{
			return new SteamInventoryResult_t(value);
		}

		public static explicit operator int(SteamInventoryResult_t that)
		{
			return that.m_SteamInventoryResult;
		}

		public bool Equals(SteamInventoryResult_t other)
		{
			return m_SteamInventoryResult == other.m_SteamInventoryResult;
		}

		public int CompareTo(SteamInventoryResult_t other)
		{
			return m_SteamInventoryResult.CompareTo(other.m_SteamInventoryResult);
		}
	}
	public struct SteamItemDef_t : IEquatable<SteamItemDef_t>, IComparable<SteamItemDef_t>
	{
		public int m_SteamItemDef;

		public SteamItemDef_t(int value)
		{
			m_SteamItemDef = value;
		}

		public override string ToString()
		{
			return m_SteamItemDef.ToString();
		}

		public override bool Equals(object other)
		{
			if (other is SteamItemDef_t)
			{
				return this == (SteamItemDef_t)other;
			}
			return false;
		}

		public override int GetHashCode()
		{
			return m_SteamItemDef.GetHashCode();
		}

		public static bool operator ==(SteamItemDef_t x, SteamItemDef_t y)
		{
			return x.m_SteamItemDef == y.m_SteamItemDef;
		}

		public static bool operator !=(SteamItemDef_t x, SteamItemDef_t y)
		{
			return !(x == y);
		}

		public static explicit operator SteamItemDef_t(int value)
		{
			return new SteamItemDef_t(value);
		}

		public static explicit operator int(SteamItemDef_t that)
		{
			return that.m_SteamItemDef;
		}

		public bool Equals(SteamItemDef_t other)
		{
			return m_SteamItemDef == other.m_SteamItemDef;
		}

		public int CompareTo(SteamItemDef_t other)
		{
			return m_SteamItemDef.CompareTo(other.m_SteamItemDef);
		}
	}
	public struct SteamItemInstanceID_t : IEquatable<SteamItemInstanceID_t>, IComparable<SteamItemInstanceID_t>
	{
		public static readonly SteamItemInstanceID_t Invalid = new SteamItemInstanceID_t(ulong.MaxValue);

		public ulong m_SteamItemInstanceID;

		public SteamItemInstanceID_t(ulong value)
		{
			m_SteamItemInstanceID = value;
		}

		public override string ToString()
		{
			return m_SteamItemInstanceID.ToString();
		}

		public override bool Equals(object other)
		{
			if (other is SteamItemInstanceID_t)
			{
				return this == (SteamItemInstanceID_t)other;
			}
			return false;
		}

		public override int GetHashCode()
		{
			return m_SteamItemInstanceID.GetHashCode();
		}

		public static bool operator ==(SteamItemInstanceID_t x, SteamItemInstanceID_t y)
		{
			return x.m_SteamItemInstanceID == y.m_SteamItemInstanceID;
		}

		public static bool operator !=(SteamItemInstanceID_t x, SteamItemInstanceID_t y)
		{
			return !(x == y);
		}

		public static explicit operator SteamItemInstanceID_t(ulong value)
		{
			return new SteamItemInstanceID_t(value);
		}

		public static explicit operator ulong(SteamItemInstanceID_t that)
		{
			return that.m_SteamItemInstanceID;
		}

		public bool Equals(SteamItemInstanceID_t other)
		{
			return m_SteamItemInstanceID == other.m_SteamItemInstanceID;
		}

		public int CompareTo(SteamItemInstanceID_t other)
		{
			return m_SteamItemInstanceID.CompareTo(other.m_SteamItemInstanceID);
		}
	}
	public struct HServerListRequest : IEquatable<HServerListRequest>
	{
		public static readonly HServerListRequest Invalid = new HServerListRequest(IntPtr.Zero);

		public IntPtr m_HServerListRequest;

		public HServerListRequest(IntPtr value)
		{
			m_HServerListRequest = value;
		}

		public override string ToString()
		{
			return m_HServerListRequest.ToString();
		}

		public override bool Equals(object other)
		{
			if (other is HServerListRequest)
			{
				return this == (HServerListRequest)other;
			}
			return false;
		}

		public override int GetHashCode()
		{
			return m_HServerListRequest.GetHashCode();
		}

		public static bool operator ==(HServerListRequest x, HServerListRequest y)
		{
			return x.m_HServerListRequest == y.m_HServerListRequest;
		}

		public static bool operator !=(HServerListRequest x, HServerListRequest y)
		{
			return !(x == y);
		}

		public static explicit operator HServerListRequest(IntPtr value)
		{
			return new HServerListRequest(value);
		}

		public static explicit operator IntPtr(HServerListRequest that)
		{
			return that.m_HServerListRequest;
		}

		public bool Equals(HServerListRequest other)
		{
			return m_HServerListRequest == other.m_HServerListRequest;
		}
	}
	public struct HServerQuery : IEquatable<HServerQuery>, IComparable<HServerQuery>
	{
		public static readonly HServerQuery Invalid = new HServerQuery(-1);

		public int m_HServerQuery;

		public HServerQuery(int value)
		{
			m_HServerQuery = value;
		}

		public override string ToString()
		{
			return m_HServerQuery.ToString();
		}

		public override bool Equals(object other)
		{
			if (other is HServerQuery)
			{
				return this == (HServerQuery)other;
			}
			return false;
		}

		public override int GetHashCode()
		{
			return m_HServerQuery.GetHashCode();
		}

		public static bool operator ==(HServerQuery x, HServerQuery y)
		{
			return x.m_HServerQuery == y.m_HServerQuery;
		}

		public static bool operator !=(HServerQuery x, HServerQuery y)
		{
			return !(x == y);
		}

		public static explicit operator HServerQuery(int value)
		{
			return new HServerQuery(value);
		}

		public static explicit operator int(HServerQuery that)
		{
			return that.m_HServerQuery;
		}

		public bool Equals(HServerQuery other)
		{
			return m_HServerQuery == other.m_HServerQuery;
		}

		public int CompareTo(HServerQuery other)
		{
			return m_HServerQuery.CompareTo(other.m_HServerQuery);
		}
	}
	public struct SNetListenSocket_t : IEquatable<SNetListenSocket_t>, IComparable<SNetListenSocket_t>
	{
		public uint m_SNetListenSocket;

		public SNetListenSocket_t(uint value)
		{
			m_SNetListenSocket = value;
		}

		public override string ToString()
		{
			return m_SNetListenSocket.ToString();
		}

		public override bool Equals(object other)
		{
			if (other is SNetListenSocket_t)
			{
				return this == (SNetListenSocket_t)other;
			}
			return false;
		}

		public override int GetHashCode()
		{
			return m_SNetListenSocket.GetHashCode();
		}

		public static bool operator ==(SNetListenSocket_t x, SNetListenSocket_t y)
		{
			return x.m_SNetListenSocket == y.m_SNetListenSocket;
		}

		public static bool operator !=(SNetListenSocket_t x, SNetListenSocket_t y)
		{
			return !(x == y);
		}

		public static explicit operator SNetListenSocket_t(uint value)
		{
			return new SNetListenSocket_t(value);
		}

		public static explicit operator uint(SNetListenSocket_t that)
		{
			return that.m_SNetListenSocket;
		}

		public bool Equals(SNetListenSocket_t other)
		{
			return m_SNetListenSocket == other.m_SNetListenSocket;
		}

		public int CompareTo(SNetListenSocket_t other)
		{
			return m_SNetListenSocket.CompareTo(other.m_SNetListenSocket);
		}
	}
	public struct SNetSocket_t : IEquatable<SNetSocket_t>, IComparable<SNetSocket_t>
	{
		public uint m_SNetSocket;

		public SNetSocket_t(uint value)
		{
			m_SNetSocket = value;
		}

		public override string ToString()
		{
			return m_SNetSocket.ToString();
		}

		public override bool Equals(object other)
		{
			if (other is SNetSocket_t)
			{
				return this == (SNetSocket_t)other;
			}
			return false;
		}

		public override int GetHashCode()
		{
			return m_SNetSocket.GetHashCode();
		}

		public static bool operator ==(SNetSocket_t x, SNetSocket_t y)
		{
			return x.m_SNetSocket == y.m_SNetSocket;
		}

		public static bool operator !=(SNetSocket_t x, SNetSocket_t y)
		{
			return !(x == y);
		}

		public static explicit operator SNetSocket_t(uint value)
		{
			return new SNetSocket_t(value);
		}

		public static explicit operator uint(SNetSocket_t that)
		{
			return that.m_SNetSocket;
		}

		public bool Equals(SNetSocket_t other)
		{
			return m_SNetSocket == other.m_SNetSocket;
		}

		public int CompareTo(SNetSocket_t other)
		{
			return m_SNetSocket.CompareTo(other.m_SNetSocket);
		}
	}
	public struct PublishedFileId_t : IEquatable<PublishedFileId_t>, IComparable<PublishedFileId_t>
	{
		public static readonly PublishedFileId_t Invalid = new PublishedFileId_t(0uL);

		public ulong m_PublishedFileId;

		public PublishedFileId_t(ulong value)
		{
			m_PublishedFileId = value;
		}

		public override string ToString()
		{
			return m_PublishedFileId.ToString();
		}

		public override bool Equals(object other)
		{
			if (other is PublishedFileId_t)
			{
				return this == (PublishedFileId_t)other;
			}
			return false;
		}

		public override int GetHashCode()
		{
			return m_PublishedFileId.GetHashCode();
		}

		public static bool operator ==(PublishedFileId_t x, PublishedFileId_t y)
		{
			return x.m_PublishedFileId == y.m_PublishedFileId;
		}

		public static bool operator !=(PublishedFileId_t x, PublishedFileId_t y)
		{
			return !(x == y);
		}

		public static explicit operator PublishedFileId_t(ulong value)
		{
			return new PublishedFileId_t(value);
		}

		public static explicit operator ulong(PublishedFileId_t that)
		{
			return that.m_PublishedFileId;
		}

		public bool Equals(PublishedFileId_t other)
		{
			return m_PublishedFileId == other.m_PublishedFileId;
		}

		public int CompareTo(PublishedFileId_t other)
		{
			return m_PublishedFileId.CompareTo(other.m_PublishedFileId);
		}
	}
	public struct PublishedFileUpdateHandle_t : IEquatable<PublishedFileUpdateHandle_t>, IComparable<PublishedFileUpdateHandle_t>
	{
		public static readonly PublishedFileUpdateHandle_t Invalid = new PublishedFileUpdateHandle_t(ulong.MaxValue);

		public ulong m_PublishedFileUpdateHandle;

		public PublishedFileUpdateHandle_t(ulong value)
		{
			m_PublishedFileUpdateHandle = value;
		}

		public override string ToString()
		{
			return m_PublishedFileUpdateHandle.ToString();
		}

		public override bool Equals(object other)
		{
			if (other is PublishedFileUpdateHandle_t)
			{
				return this == (PublishedFileUpdateHandle_t)other;
			}
			return false;
		}

		public override int GetHashCode()
		{
			return m_PublishedFileUpdateHandle.GetHashCode();
		}

		public static bool operator ==(PublishedFileUpdateHandle_t x, PublishedFileUpdateHandle_t y)
		{
			return x.m_PublishedFileUpdateHandle == y.m_PublishedFileUpdateHandle;
		}

		public static bool operator !=(PublishedFileUpdateHandle_t x, PublishedFileUpdateHandle_t y)
		{
			return !(x == y);
		}

		public static explicit operator PublishedFileUpdateHandle_t(ulong value)
		{
			return new PublishedFileUpdateHandle_t(value);
		}

		public static explicit operator ulong(PublishedFileUpdateHandle_t that)
		{
			return that.m_PublishedFileUpdateHandle;
		}

		public bool Equals(PublishedFileUpdateHandle_t other)
		{
			return m_PublishedFileUpdateHandle == other.m_PublishedFileUpdateHandle;
		}

		public int CompareTo(PublishedFileUpdateHandle_t other)
		{
			return m_PublishedFileUpdateHandle.CompareTo(other.m_PublishedFileUpdateHandle);
		}
	}
	public struct UGCFileWriteStreamHandle_t : IEquatable<UGCFileWriteStreamHandle_t>, IComparable<UGCFileWriteStreamHandle_t>
	{
		public static readonly UGCFileWriteStreamHandle_t Invalid = new UGCFileWriteStreamHandle_t(ulong.MaxValue);

		public ulong m_UGCFileWriteStreamHandle;

		public UGCFileWriteStreamHandle_t(ulong value)
		{
			m_UGCFileWriteStreamHandle = value;
		}

		public override string ToString()
		{
			return m_UGCFileWriteStreamHandle.ToString();
		}

		public override bool Equals(object other)
		{
			if (other is UGCFileWriteStreamHandle_t)
			{
				return this == (UGCFileWriteStreamHandle_t)other;
			}
			return false;
		}

		public override int GetHashCode()
		{
			return m_UGCFileWriteStreamHandle.GetHashCode();
		}

		public static bool operator ==(UGCFileWriteStreamHandle_t x, UGCFileWriteStreamHandle_t y)
		{
			return x.m_UGCFileWriteStreamHandle == y.m_UGCFileWriteStreamHandle;
		}

		public static bool operator !=(UGCFileWriteStreamHandle_t x, UGCFileWriteStreamHandle_t y)
		{
			return !(x == y);
		}

		public static explicit operator UGCFileWriteStreamHandle_t(ulong value)
		{
			return new UGCFileWriteStreamHandle_t(value);
		}

		public static explicit operator ulong(UGCFileWriteStreamHandle_t that)
		{
			return that.m_UGCFileWriteStreamHandle;
		}

		public bool Equals(UGCFileWriteStreamHandle_t other)
		{
			return m_UGCFileWriteStreamHandle == other.m_UGCFileWriteStreamHandle;
		}

		public int CompareTo(UGCFileWriteStreamHandle_t other)
		{
			return m_UGCFileWriteStreamHandle.CompareTo(other.m_UGCFileWriteStreamHandle);
		}
	}
	public struct UGCHandle_t : IEquatable<UGCHandle_t>, IComparable<UGCHandle_t>
	{
		public static readonly UGCHandle_t Invalid = new UGCHandle_t(ulong.MaxValue);

		public ulong m_UGCHandle;

		public UGCHandle_t(ulong value)
		{
			m_UGCHandle = value;
		}

		public override string ToString()
		{
			return m_UGCHandle.ToString();
		}

		public override bool Equals(object other)
		{
			if (other is UGCHandle_t)
			{
				return this == (UGCHandle_t)other;
			}
			return false;
		}

		public override int GetHashCode()
		{
			return m_UGCHandle.GetHashCode();
		}

		public static bool operator ==(UGCHandle_t x, UGCHandle_t y)
		{
			return x.m_UGCHandle == y.m_UGCHandle;
		}

		public static bool operator !=(UGCHandle_t x, UGCHandle_t y)
		{
			return !(x == y);
		}

		public static explicit operator UGCHandle_t(ulong value)
		{
			return new UGCHandle_t(value);
		}

		public static explicit operator ulong(UGCHandle_t that)
		{
			return that.m_UGCHandle;
		}

		public bool Equals(UGCHandle_t other)
		{
			return m_UGCHandle == other.m_UGCHandle;
		}

		public int CompareTo(UGCHandle_t other)
		{
			return m_UGCHandle.CompareTo(other.m_UGCHandle);
		}
	}
	public struct ScreenshotHandle : IEquatable<ScreenshotHandle>, IComparable<ScreenshotHandle>
	{
		public static readonly ScreenshotHandle Invalid = new ScreenshotHandle(0u);

		public uint m_ScreenshotHandle;

		public ScreenshotHandle(uint value)
		{
			m_ScreenshotHandle = value;
		}

		public override string ToString()
		{
			return m_ScreenshotHandle.ToString();
		}

		public override bool Equals(object other)
		{
			if (other is ScreenshotHandle)
			{
				return this == (ScreenshotHandle)other;
			}
			return false;
		}

		public override int GetHashCode()
		{
			return m_ScreenshotHandle.GetHashCode();
		}

		public static bool operator ==(ScreenshotHandle x, ScreenshotHandle y)
		{
			return x.m_ScreenshotHandle == y.m_ScreenshotHandle;
		}

		public static bool operator !=(ScreenshotHandle x, ScreenshotHandle y)
		{
			return !(x == y);
		}

		public static explicit operator ScreenshotHandle(uint value)
		{
			return new ScreenshotHandle(value);
		}

		public static explicit operator uint(ScreenshotHandle that)
		{
			return that.m_ScreenshotHandle;
		}

		public bool Equals(ScreenshotHandle other)
		{
			return m_ScreenshotHandle == other.m_ScreenshotHandle;
		}

		public int CompareTo(ScreenshotHandle other)
		{
			return m_ScreenshotHandle.CompareTo(other.m_ScreenshotHandle);
		}
	}
	public struct AccountID_t : IEquatable<AccountID_t>, IComparable<AccountID_t>
	{
		public uint m_AccountID;

		public AccountID_t(uint value)
		{
			m_AccountID = value;
		}

		public override string ToString()
		{
			return m_AccountID.ToString();
		}

		public override bool Equals(object other)
		{
			if (other is AccountID_t)
			{
				return this == (AccountID_t)other;
			}
			return false;
		}

		public override int GetHashCode()
		{
			return m_AccountID.GetHashCode();
		}

		public static bool operator ==(AccountID_t x, AccountID_t y)
		{
			return x.m_AccountID == y.m_AccountID;
		}

		public static bool operator !=(AccountID_t x, AccountID_t y)
		{
			return !(x == y);
		}

		public static explicit operator AccountID_t(uint value)
		{
			return new AccountID_t(value);
		}

		public static explicit operator uint(AccountID_t that)
		{
			return that.m_AccountID;
		}

		public bool Equals(AccountID_t other)
		{
			return m_AccountID == other.m_AccountID;
		}

		public int CompareTo(AccountID_t other)
		{
			return m_AccountID.CompareTo(other.m_AccountID);
		}
	}
	public struct AppId_t : IEquatable<AppId_t>, IComparable<AppId_t>
	{
		public static readonly AppId_t Invalid = new AppId_t(0u);

		public uint m_AppId;

		public AppId_t(uint value)
		{
			m_AppId = value;
		}

		public override string ToString()
		{
			return m_AppId.ToString();
		}

		public override bool Equals(object other)
		{
			if (other is AppId_t)
			{
				return this == (AppId_t)other;
			}
			return false;
		}

		public override int GetHashCode()
		{
			return m_AppId.GetHashCode();
		}

		public static bool operator ==(AppId_t x, AppId_t y)
		{
			return x.m_AppId == y.m_AppId;
		}

		public static bool operator !=(AppId_t x, AppId_t y)
		{
			return !(x == y);
		}

		public static explicit operator AppId_t(uint value)
		{
			return new AppId_t(value);
		}

		public static explicit operator uint(AppId_t that)
		{
			return that.m_AppId;
		}

		public bool Equals(AppId_t other)
		{
			return m_AppId == other.m_AppId;
		}

		public int CompareTo(AppId_t other)
		{
			return m_AppId.CompareTo(other.m_AppId);
		}
	}
	public struct DepotId_t : IEquatable<DepotId_t>, IComparable<DepotId_t>
	{
		public static readonly DepotId_t Invalid = new DepotId_t(0u);

		public uint m_DepotId;

		public DepotId_t(uint value)
		{
			m_DepotId = value;
		}

		public override string ToString()
		{
			return m_DepotId.ToString();
		}

		public override bool Equals(object other)
		{
			if (other is DepotId_t)
			{
				return this == (DepotId_t)other;
			}
			return false;
		}

		public override int GetHashCode()
		{
			return m_DepotId.GetHashCode();
		}

		public static bool operator ==(DepotId_t x, DepotId_t y)
		{
			return x.m_DepotId == y.m_DepotId;
		}

		public static bool operator !=(DepotId_t x, DepotId_t y)
		{
			return !(x == y);
		}

		public static explicit operator DepotId_t(uint value)
		{
			return new DepotId_t(value);
		}

		public static explicit operator uint(DepotId_t that)
		{
			return that.m_DepotId;
		}

		public bool Equals(DepotId_t other)
		{
			return m_DepotId == other.m_DepotId;
		}

		public int CompareTo(DepotId_t other)
		{
			return m_DepotId.CompareTo(other.m_DepotId);
		}
	}
	public struct ManifestId_t : IEquatable<ManifestId_t>, IComparable<ManifestId_t>
	{
		public static readonly ManifestId_t Invalid = new ManifestId_t(0uL);

		public ulong m_ManifestId;

		public ManifestId_t(ulong value)
		{
			m_ManifestId = value;
		}

		public override string ToString()
		{
			return m_ManifestId.ToString();
		}

		public override bool Equals(object other)
		{
			if (other is ManifestId_t)
			{
				return this == (ManifestId_t)other;
			}
			return false;
		}

		public override int GetHashCode()
		{
			return m_ManifestId.GetHashCode();
		}

		public static bool operator ==(ManifestId_t x, ManifestId_t y)
		{
			return x.m_ManifestId == y.m_ManifestId;
		}

		public static bool operator !=(ManifestId_t x, ManifestId_t y)
		{
			return !(x == y);
		}

		public static explicit operator ManifestId_t(ulong value)
		{
			return new ManifestId_t(value);
		}

		public static explicit operator ulong(ManifestId_t that)
		{
			return that.m_ManifestId;
		}

		public bool Equals(ManifestId_t other)
		{
			return m_ManifestId == other.m_ManifestId;
		}

		public int CompareTo(ManifestId_t other)
		{
			return m_ManifestId.CompareTo(other.m_ManifestId);
		}
	}
	public struct SteamAPICall_t : IEquatable<SteamAPICall_t>, IComparable<SteamAPICall_t>
	{
		public static readonly SteamAPICall_t Invalid = new SteamAPICall_t(0uL);

		public ulong m_SteamAPICall;

		public SteamAPICall_t(ulong value)
		{
			m_SteamAPICall = value;
		}

		public override string ToString()
		{
			return m_SteamAPICall.ToString();
		}

		public override bool Equals(object other)
		{
			if (other is SteamAPICall_t)
			{
				return this == (SteamAPICall_t)other;
			}
			return false;
		}

		public override int GetHashCode()
		{
			return m_SteamAPICall.GetHashCode();
		}

		public static bool operator ==(SteamAPICall_t x, SteamAPICall_t y)
		{
			return x.m_SteamAPICall == y.m_SteamAPICall;
		}

		public static bool operator !=(SteamAPICall_t x, SteamAPICall_t y)
		{
			return !(x == y);
		}

		public static explicit operator SteamAPICall_t(ulong value)
		{
			return new SteamAPICall_t(value);
		}

		public static explicit operator ulong(SteamAPICall_t that)
		{
			return that.m_SteamAPICall;
		}

		public bool Equals(SteamAPICall_t other)
		{
			return m_SteamAPICall == other.m_SteamAPICall;
		}

		public int CompareTo(SteamAPICall_t other)
		{
			return m_SteamAPICall.CompareTo(other.m_SteamAPICall);
		}
	}
	public struct UGCQueryHandle_t : IEquatable<UGCQueryHandle_t>, IComparable<UGCQueryHandle_t>
	{
		public static readonly UGCQueryHandle_t Invalid = new UGCQueryHandle_t(ulong.MaxValue);

		public ulong m_UGCQueryHandle;

		public UGCQueryHandle_t(ulong value)
		{
			m_UGCQueryHandle = value;
		}

		public override string ToString()
		{
			return m_UGCQueryHandle.ToString();
		}

		public override bool Equals(object other)
		{
			if (other is UGCQueryHandle_t)
			{
				return this == (UGCQueryHandle_t)other;
			}
			return false;
		}

		public override int GetHashCode()
		{
			return m_UGCQueryHandle.GetHashCode();
		}

		public static bool operator ==(UGCQueryHandle_t x, UGCQueryHandle_t y)
		{
			return x.m_UGCQueryHandle == y.m_UGCQueryHandle;
		}

		public static bool operator !=(UGCQueryHandle_t x, UGCQueryHandle_t y)
		{
			return !(x == y);
		}

		public static explicit operator UGCQueryHandle_t(ulong value)
		{
			return new UGCQueryHandle_t(value);
		}

		public static explicit operator ulong(UGCQueryHandle_t that)
		{
			return that.m_UGCQueryHandle;
		}

		public bool Equals(UGCQueryHandle_t other)
		{
			return m_UGCQueryHandle == other.m_UGCQueryHandle;
		}

		public int CompareTo(UGCQueryHandle_t other)
		{
			return m_UGCQueryHandle.CompareTo(other.m_UGCQueryHandle);
		}
	}
	public struct UGCUpdateHandle_t : IEquatable<UGCUpdateHandle_t>, IComparable<UGCUpdateHandle_t>
	{
		public static readonly UGCUpdateHandle_t Invalid = new UGCUpdateHandle_t(ulong.MaxValue);

		public ulong m_UGCUpdateHandle;

		public UGCUpdateHandle_t(ulong value)
		{
			m_UGCUpdateHandle = value;
		}

		public override string ToString()
		{
			return m_UGCUpdateHandle.ToString();
		}

		public override bool Equals(object other)
		{
			if (other is UGCUpdateHandle_t)
			{
				return this == (UGCUpdateHandle_t)other;
			}
			return false;
		}

		public override int GetHashCode()
		{
			return m_UGCUpdateHandle.GetHashCode();
		}

		public static bool operator ==(UGCUpdateHandle_t x, UGCUpdateHandle_t y)
		{
			return x.m_UGCUpdateHandle == y.m_UGCUpdateHandle;
		}

		public static bool operator !=(UGCUpdateHandle_t x, UGCUpdateHandle_t y)
		{
			return !(x == y);
		}

		public static explicit operator UGCUpdateHandle_t(ulong value)
		{
			return new UGCUpdateHandle_t(value);
		}

		public static explicit operator ulong(UGCUpdateHandle_t that)
		{
			return that.m_UGCUpdateHandle;
		}

		public bool Equals(UGCUpdateHandle_t other)
		{
			return m_UGCUpdateHandle == other.m_UGCUpdateHandle;
		}

		public int CompareTo(UGCUpdateHandle_t other)
		{
			return m_UGCUpdateHandle.CompareTo(other.m_UGCUpdateHandle);
		}
	}
	public struct ClientUnifiedMessageHandle : IEquatable<ClientUnifiedMessageHandle>, IComparable<ClientUnifiedMessageHandle>
	{
		public static readonly ClientUnifiedMessageHandle Invalid = new ClientUnifiedMessageHandle(0uL);

		public ulong m_ClientUnifiedMessageHandle;

		public ClientUnifiedMessageHandle(ulong value)
		{
			m_ClientUnifiedMessageHandle = value;
		}

		public override string ToString()
		{
			return m_ClientUnifiedMessageHandle.ToString();
		}

		public override bool Equals(object other)
		{
			if (other is ClientUnifiedMessageHandle)
			{
				return this == (ClientUnifiedMessageHandle)other;
			}
			return false;
		}

		public override int GetHashCode()
		{
			return m_ClientUnifiedMessageHandle.GetHashCode();
		}

		public static bool operator ==(ClientUnifiedMessageHandle x, ClientUnifiedMessageHandle y)
		{
			return x.m_ClientUnifiedMessageHandle == y.m_ClientUnifiedMessageHandle;
		}

		public static bool operator !=(ClientUnifiedMessageHandle x, ClientUnifiedMessageHandle y)
		{
			return !(x == y);
		}

		public static explicit operator ClientUnifiedMessageHandle(ulong value)
		{
			return new ClientUnifiedMessageHandle(value);
		}

		public static explicit operator ulong(ClientUnifiedMessageHandle that)
		{
			return that.m_ClientUnifiedMessageHandle;
		}

		public bool Equals(ClientUnifiedMessageHandle other)
		{
			return m_ClientUnifiedMessageHandle == other.m_ClientUnifiedMessageHandle;
		}

		public int CompareTo(ClientUnifiedMessageHandle other)
		{
			return m_ClientUnifiedMessageHandle.CompareTo(other.m_ClientUnifiedMessageHandle);
		}
	}
	public struct SteamLeaderboard_t : IEquatable<SteamLeaderboard_t>, IComparable<SteamLeaderboard_t>
	{
		public ulong m_SteamLeaderboard;

		public SteamLeaderboard_t(ulong value)
		{
			m_SteamLeaderboard = value;
		}

		public override string ToString()
		{
			return m_SteamLeaderboard.ToString();
		}

		public override bool Equals(object other)
		{
			if (other is SteamLeaderboard_t)
			{
				return this == (SteamLeaderboard_t)other;
			}
			return false;
		}

		public override int GetHashCode()
		{
			return m_SteamLeaderboard.GetHashCode();
		}

		public static bool operator ==(SteamLeaderboard_t x, SteamLeaderboard_t y)
		{
			return x.m_SteamLeaderboard == y.m_SteamLeaderboard;
		}

		public static bool operator !=(SteamLeaderboard_t x, SteamLeaderboard_t y)
		{
			return !(x == y);
		}

		public static explicit operator SteamLeaderboard_t(ulong value)
		{
			return new SteamLeaderboard_t(value);
		}

		public static explicit operator ulong(SteamLeaderboard_t that)
		{
			return that.m_SteamLeaderboard;
		}

		public bool Equals(SteamLeaderboard_t other)
		{
			return m_SteamLeaderboard == other.m_SteamLeaderboard;
		}

		public int CompareTo(SteamLeaderboard_t other)
		{
			return m_SteamLeaderboard.CompareTo(other.m_SteamLeaderboard);
		}
	}
	public struct SteamLeaderboardEntries_t : IEquatable<SteamLeaderboardEntries_t>, IComparable<SteamLeaderboardEntries_t>
	{
		public ulong m_SteamLeaderboardEntries;

		public SteamLeaderboardEntries_t(ulong value)
		{
			m_SteamLeaderboardEntries = value;
		}

		public override string ToString()
		{
			return m_SteamLeaderboardEntries.ToString();
		}

		public override bool Equals(object other)
		{
			if (other is SteamLeaderboardEntries_t)
			{
				return this == (SteamLeaderboardEntries_t)other;
			}
			return false;
		}

		public override int GetHashCode()
		{
			return m_SteamLeaderboardEntries.GetHashCode();
		}

		public static bool operator ==(SteamLeaderboardEntries_t x, SteamLeaderboardEntries_t y)
		{
			return x.m_SteamLeaderboardEntries == y.m_SteamLeaderboardEntries;
		}

		public static bool operator !=(SteamLeaderboardEntries_t x, SteamLeaderboardEntries_t y)
		{
			return !(x == y);
		}

		public static explicit operator SteamLeaderboardEntries_t(ulong value)
		{
			return new SteamLeaderboardEntries_t(value);
		}

		public static explicit operator ulong(SteamLeaderboardEntries_t that)
		{
			return that.m_SteamLeaderboardEntries;
		}

		public bool Equals(SteamLeaderboardEntries_t other)
		{
			return m_SteamLeaderboardEntries == other.m_SteamLeaderboardEntries;
		}

		public int CompareTo(SteamLeaderboardEntries_t other)
		{
			return m_SteamLeaderboardEntries.CompareTo(other.m_SteamLeaderboardEntries);
		}
	}
}
namespace SimpleJSON
{
	public enum JSONNodeType
	{
		Array = 1,
		Object,
		String,
		Number,
		NullValue,
		Boolean,
		None
	}
	public enum JSONTextMode
	{
		Compact,
		Indent
	}
	public abstract class JSONNode
	{
		internal static StringBuilder m_EscapeBuilder = new StringBuilder();

		public virtual JSONNode this[int aIndex]
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public virtual JSONNode this[string aKey]
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public virtual string Value
		{
			get
			{
				return "";
			}
			set
			{
			}
		}

		public virtual int Count => 0;

		public virtual bool IsNumber => false;

		public virtual bool IsString => false;

		public virtual bool IsBoolean => false;

		public virtual bool IsNull => false;

		public virtual bool IsArray => false;

		public virtual bool IsObject => false;

		public virtual IEnumerable<JSONNode> Children
		{
			get
			{
				yield break;
			}
		}

		public IEnumerable<JSONNode> DeepChildren
		{
			get
			{
				foreach (JSONNode child in Children)
				{
					foreach (JSONNode deepChild in child.DeepChildren)
					{
						yield return deepChild;
					}
				}
			}
		}

		public abstract JSONNodeType Tag { get; }

		public virtual double AsDouble
		{
			get
			{
				double result = 0.0;
				if (double.TryParse(Value, out result))
				{
					return result;
				}
				return 0.0;
			}
			set
			{
				Value = value.ToString();
			}
		}

		public virtual int AsInt
		{
			get
			{
				return (int)AsDouble;
			}
			set
			{
				AsDouble = value;
			}
		}

		public virtual float AsFloat
		{
			get
			{
				return (float)AsDouble;
			}
			set
			{
				AsDouble = value;
			}
		}

		public virtual bool AsBool
		{
			get
			{
				bool result = false;
				if (bool.TryParse(Value, out result))
				{
					return result;
				}
				return !string.IsNullOrEmpty(Value);
			}
			set
			{
				Value = (value ? "true" : "false");
			}
		}

		public virtual JSONArray AsArray => this as JSONArray;

		public virtual JSONObject AsObject => this as JSONObject;

		public virtual void Add(string aKey, JSONNode aItem)
		{
		}

		public virtual void Add(JSONNode aItem)
		{
			Add("", aItem);
		}

		public virtual JSONNode Remove(string aKey)
		{
			return null;
		}

		public virtual JSONNode Remove(int aIndex)
		{
			return null;
		}

		public virtual JSONNode Remove(JSONNode aNode)
		{
			return aNode;
		}

		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			WriteToStringBuilder(stringBuilder, 0, 0, JSONTextMode.Compact);
			return stringBuilder.ToString();
		}

		public virtual string ToString(int aIndent)
		{
			StringBuilder stringBuilder = new StringBuilder();
			WriteToStringBuilder(stringBuilder, 0, aIndent, JSONTextMode.Indent);
			return stringBuilder.ToString();
		}

		internal abstract void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode);

		public static implicit operator JSONNode(string s)
		{
			return new JSONString(s);
		}

		public static implicit operator string(JSONNode d)
		{
			if (!(d == null))
			{
				return d.Value;
			}
			return null;
		}

		public static implicit operator JSONNode(double n)
		{
			return new JSONNumber(n);
		}

		public static implicit operator double(JSONNode d)
		{
			if (!(d == null))
			{
				return d.AsDouble;
			}
			return 0.0;
		}

		public static implicit operator JSONNode(float n)
		{
			return new JSONNumber(n);
		}

		public static implicit operator float(JSONNode d)
		{
			if (!(d == null))
			{
				return d.AsFloat;
			}
			return 0f;
		}

		public static implicit operator JSONNode(int n)
		{
			return new JSONNumber(n);
		}

		public static implicit operator int(JSONNode d)
		{
			if (!(d == null))
			{
				return d.AsInt;
			}
			return 0;
		}

		public static implicit operator JSONNode(bool b)
		{
			return new JSONBool(b);
		}

		public static implicit operator bool(JSONNode d)
		{
			if (!(d == null))
			{
				return d.AsBool;
			}
			return false;
		}

		public static bool operator ==(JSONNode a, object b)
		{
			if ((object)a == b)
			{
				return true;
			}
			bool num = a is JSONNull || (object)a == null || a is JSONLazyCreator;
			bool flag = b is JSONNull || b == null || b is JSONLazyCreator;
			if (num && flag)
			{
				return true;
			}
			return a.Equals(b);
		}

		public static bool operator !=(JSONNode a, object b)
		{
			return !(a == b);
		}

		public override bool Equals(object obj)
		{
			return (object)this == obj;
		}

		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		internal static string Escape(string aText)
		{
			m_EscapeBuilder.Length = 0;
			if (m_EscapeBuilder.Capacity < aText.Length + aText.Length / 10)
			{
				m_EscapeBuilder.Capacity = aText.Length + aText.Length / 10;
			}
			foreach (char c in aText)
			{
				switch (c)
				{
				case '\\':
					m_EscapeBuilder.Append("\\\\");
					break;
				case '"':
					m_EscapeBuilder.Append("\\\"");
					break;
				case '\n':
					m_EscapeBuilder.Append("\\n");
					break;
				case '\r':
					m_EscapeBuilder.Append("\\r");
					break;
				case '\t':
					m_EscapeBuilder.Append("\\t");
					break;
				case '\b':
					m_EscapeBuilder.Append("\\b");
					break;
				case '\f':
					m_EscapeBuilder.Append("\\f");
					break;
				default:
					m_EscapeBuilder.Append(c);
					break;
				}
			}
			string result = m_EscapeBuilder.ToString();
			m_EscapeBuilder.Length = 0;
			return result;
		}

		private static void ParseElement(JSONNode ctx, string token, string tokenName, bool quoted)
		{
			if (quoted)
			{
				ctx.Add(tokenName, token);
				return;
			}
			string text = token.ToLower();
			switch (text)
			{
			case "false":
			case "true":
				ctx.Add(tokenName, text == "true");
				return;
			case "null":
				ctx.Add(tokenName, null);
				return;
			}
			if (double.TryParse(token, out var result))
			{
				ctx.Add(tokenName, result);
			}
			else
			{
				ctx.Add(tokenName, token);
			}
		}

		public static JSONNode Parse(string aJSON)
		{
			Stack<JSONNode> stack = new Stack<JSONNode>();
			JSONNode jSONNode = null;
			int i = 0;
			StringBuilder stringBuilder = new StringBuilder();
			string text = "";
			bool flag = false;
			bool flag2 = false;
			for (; i < aJSON.Length; i++)
			{
				switch (aJSON[i])
				{
				case '{':
					if (flag)
					{
						stringBuilder.Append(aJSON[i]);
						break;
					}
					stack.Push(new JSONObject());
					if (jSONNode != null)
					{
						jSONNode.Add(text, stack.Peek());
					}
					text = "";
					stringBuilder.Length = 0;
					jSONNode = stack.Peek();
					break;
				case '[':
					if (flag)
					{
						stringBuilder.Append(aJSON[i]);
						break;
					}
					stack.Push(new JSONArray());
					if (jSONNode != null)
					{
						jSONNode.Add(text, stack.Peek());
					}
					text = "";
					stringBuilder.Length = 0;
					jSONNode = stack.Peek();
					break;
				case ']':
				case '}':
					if (flag)
					{
						stringBuilder.Append(aJSON[i]);
						break;
					}
					if (stack.Count == 0)
					{
						throw new Exception("JSON Parse: Too many closing brackets");
					}
					stack.Pop();
					if (stringBuilder.Length > 0 || flag2)
					{
						ParseElement(jSONNode, stringBuilder.ToString(), text, flag2);
						flag2 = false;
					}
					text = "";
					stringBuilder.Length = 0;
					if (stack.Count > 0)
					{
						jSONNode = stack.Peek();
					}
					break;
				case ':':
					if (flag)
					{
						stringBuilder.Append(aJSON[i]);
						break;
					}
					text = stringBuilder.ToString();
					stringBuilder.Length = 0;
					flag2 = false;
					break;
				case '"':
					flag = !flag;
					flag2 = flag2 || flag;
					break;
				case ',':
					if (flag)
					{
						stringBuilder.Append(aJSON[i]);
						break;
					}
					if (stringBuilder.Length > 0 || flag2)
					{
						ParseElement(jSONNode, stringBuilder.ToString(), text, flag2);
						flag2 = false;
					}
					text = "";
					stringBuilder.Length = 0;
					flag2 = false;
					break;
				case '\t':
				case ' ':
					if (flag)
					{
						stringBuilder.Append(aJSON[i]);
					}
					break;
				case '\\':
					i++;
					if (flag)
					{
						char c = aJSON[i];
						switch (c)
						{
						case 't':
							stringBuilder.Append('\t');
							break;
						case 'r':
							stringBuilder.Append('\r');
							break;
						case 'n':
							stringBuilder.Append('\n');
							break;
						case 'b':
							stringBuilder.Append('\b');
							break;
						case 'f':
							stringBuilder.Append('\f');
							break;
						case 'u':
						{
							string s = aJSON.Substring(i + 1, 4);
							stringBuilder.Append((char)int.Parse(s, NumberStyles.AllowHexSpecifier));
							i += 4;
							break;
						}
						default:
							stringBuilder.Append(c);
							break;
						}
					}
					break;
				default:
					stringBuilder.Append(aJSON[i]);
					break;
				case '\n':
				case '\r':
					break;
				}
			}
			if (flag)
			{
				throw new Exception("JSON Parse: Quotation marks seems to be messed up.");
			}
			return jSONNode;
		}

		public virtual void Serialize(BinaryWriter aWriter)
		{
		}

		public void SaveToStream(Stream aData)
		{
			BinaryWriter aWriter = new BinaryWriter(aData);
			Serialize(aWriter);
		}

		public void SaveToCompressedStream(Stream aData)
		{
			throw new Exception("Can't use compressed functions. You need include the SharpZipLib and uncomment the define at the top of SimpleJSON");
		}

		public void SaveToCompressedFile(string aFileName)
		{
			throw new Exception("Can't use compressed functions. You need include the SharpZipLib and uncomment the define at the top of SimpleJSON");
		}

		public string SaveToCompressedBase64()
		{
			throw new Exception("Can't use compressed functions. You need include the SharpZipLib and uncomment the define at the top of SimpleJSON");
		}

		public void SaveToFile(string aFileName)
		{
			Directory.CreateDirectory(new FileInfo(aFileName).Directory.FullName);
			using FileStream aData = File.OpenWrite(aFileName);
			SaveToStream(aData);
		}

		public string SaveToBase64()
		{
			using MemoryStream memoryStream = new MemoryStream();
			SaveToStream(memoryStream);
			memoryStream.Position = 0L;
			return Convert.ToBase64String(memoryStream.ToArray());
		}

		public static JSONNode Deserialize(BinaryReader aReader)
		{
			JSONNodeType jSONNodeType = (JSONNodeType)aReader.ReadByte();
			switch (jSONNodeType)
			{
			case JSONNodeType.Array:
			{
				int num2 = aReader.ReadInt32();
				JSONArray jSONArray = new JSONArray();
				for (int j = 0; j < num2; j++)
				{
					jSONArray.Add(Deserialize(aReader));
				}
				return jSONArray;
			}
			case JSONNodeType.Object:
			{
				int num = aReader.ReadInt32();
				JSONObject jSONObject = new JSONObject();
				for (int i = 0; i < num; i++)
				{
					string aKey = aReader.ReadString();
					JSONNode aItem = Deserialize(aReader);
					jSONObject.Add(aKey, aItem);
				}
				return jSONObject;
			}
			case JSONNodeType.String:
				return new JSONString(aReader.ReadString());
			case JSONNodeType.Number:
				return new JSONNumber(aReader.ReadDouble());
			case JSONNodeType.Boolean:
				return new JSONBool(aReader.ReadBoolean());
			case JSONNodeType.NullValue:
				return new JSONNull();
			default:
				throw new Exception("Error deserializing JSON. Unknown tag: " + jSONNodeType);
			}
		}

		public static JSONNode LoadFromCompressedFile(string aFileName)
		{
			throw new Exception("Can't use compressed functions. You need include the SharpZipLib and uncomment the define at the top of SimpleJSON");
		}

		public static JSONNode LoadFromCompressedStream(Stream aData)
		{
			throw new Exception("Can't use compressed functions. You need include the SharpZipLib and uncomment the define at the top of SimpleJSON");
		}

		public static JSONNode LoadFromCompressedBase64(string aBase64)
		{
			throw new Exception("Can't use compressed functions. You need include the SharpZipLib and uncomment the define at the top of SimpleJSON");
		}

		public static JSONNode LoadFromStream(Stream aData)
		{
			using BinaryReader aReader = new BinaryReader(aData);
			return Deserialize(aReader);
		}

		public static JSONNode LoadFromFile(string aFileName)
		{
			using FileStream aData = File.OpenRead(aFileName);
			return LoadFromStream(aData);
		}

		public static JSONNode LoadFromBase64(string aBase64)
		{
			return LoadFromStream(new MemoryStream(Convert.FromBase64String(aBase64))
			{
				Position = 0L
			});
		}
	}
	public class JSONArray : JSONNode, IEnumerable
	{
		private List<JSONNode> m_List = new List<JSONNode>();

		public bool inline;

		public override JSONNodeType Tag => JSONNodeType.Array;

		public override bool IsArray => true;

		public override JSONNode this[int aIndex]
		{
			get
			{
				if (aIndex < 0 || aIndex >= m_List.Count)
				{
					return new JSONLazyCreator(this);
				}
				return m_List[aIndex];
			}
			set
			{
				if (value == null)
				{
					value = new JSONNull();
				}
				if (aIndex < 0 || aIndex >= m_List.Count)
				{
					m_List.Add(value);
				}
				else
				{
					m_List[aIndex] = value;
				}
			}
		}

		public override JSONNode this[string aKey]
		{
			get
			{
				return new JSONLazyCreator(this);
			}
			set
			{
				if (value == null)
				{
					value = new JSONNull();
				}
				m_List.Add(value);
			}
		}

		public override int Count => m_List.Count;

		public override IEnumerable<JSONNode> Children
		{
			get
			{
				foreach (JSONNode item in m_List)
				{
					yield return item;
				}
			}
		}

		public override void Add(string aKey, JSONNode aItem)
		{
			if (aItem == null)
			{
				aItem = new JSONNull();
			}
			m_List.Add(aItem);
		}

		public override JSONNode Remove(int aIndex)
		{
			if (aIndex < 0 || aIndex >= m_List.Count)
			{
				return null;
			}
			JSONNode result = m_List[aIndex];
			m_List.RemoveAt(aIndex);
			return result;
		}

		public override JSONNode Remove(JSONNode aNode)
		{
			m_List.Remove(aNode);
			return aNode;
		}

		public IEnumerator GetEnumerator()
		{
			foreach (JSONNode item in m_List)
			{
				yield return item;
			}
		}

		public override void Serialize(BinaryWriter aWriter)
		{
			aWriter.Write((byte)1);
			aWriter.Write(m_List.Count);
			for (int i = 0; i < m_List.Count; i++)
			{
				m_List[i].Serialize(aWriter);
			}
		}

		internal override void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode)
		{
			aSB.Append('[');
			int count = m_List.Count;
			if (inline)
			{
				aMode = JSONTextMode.Compact;
			}
			for (int i = 0; i < count; i++)
			{
				if (i > 0)
				{
					aSB.Append(',');
				}
				if (aMode == JSONTextMode.Indent)
				{
					aSB.AppendLine();
				}
				if (aMode == JSONTextMode.Indent)
				{
					aSB.Append(' ', aIndent + aIndentInc);
				}
				m_List[i].WriteToStringBuilder(aSB, aIndent + aIndentInc, aIndentInc, aMode);
			}
			if (aMode == JSONTextMode.Indent)
			{
				aSB.AppendLine().Append(' ', aIndent);
			}
			aSB.Append(']');
		}
	}
	public class JSONObject : JSONNode, IEnumerable
	{
		private Dictionary<string, JSONNode> m_Dict = new Dictionary<string, JSONNode>();

		public bool inline;

		public override JSONNodeType Tag => JSONNodeType.Object;

		public override bool IsObject => true;

		public override JSONNode this[string aKey]
		{
			get
			{
				if (m_Dict.ContainsKey(aKey))
				{
					return m_Dict[aKey];
				}
				return new JSONLazyCreator(this, aKey);
			}
			set
			{
				if (value == null)
				{
					value = new JSONNull();
				}
				if (m_Dict.ContainsKey(aKey))
				{
					m_Dict[aKey] = value;
				}
				else
				{
					m_Dict.Add(aKey, value);
				}
			}
		}

		public override JSONNode this[int aIndex]
		{
			get
			{
				if (aIndex < 0 || aIndex >= m_Dict.Count)
				{
					return null;
				}
				return m_Dict.ElementAt(aIndex).Value;
			}
			set
			{
				if (value == null)
				{
					value = new JSONNull();
				}
				if (aIndex >= 0 && aIndex < m_Dict.Count)
				{
					string key = m_Dict.ElementAt(aIndex).Key;
					m_Dict[key] = value;
				}
			}
		}

		public override int Count => m_Dict.Count;

		public override IEnumerable<JSONNode> Children
		{
			get
			{
				foreach (KeyValuePair<string, JSONNode> item in m_Dict)
				{
					yield return item.Value;
				}
			}
		}

		public override void Add(string aKey, JSONNode aItem)
		{
			if (aItem == null)
			{
				aItem = new JSONNull();
			}
			if (!string.IsNullOrEmpty(aKey))
			{
				if (m_Dict.ContainsKey(aKey))
				{
					m_Dict[aKey] = aItem;
				}
				else
				{
					m_Dict.Add(aKey, aItem);
				}
			}
			else
			{
				m_Dict.Add(Guid.NewGuid().ToString(), aItem);
			}
		}

		public override JSONNode Remove(string aKey)
		{
			if (!m_Dict.ContainsKey(aKey))
			{
				return null;
			}
			JSONNode result = m_Dict[aKey];
			m_Dict.Remove(aKey);
			return result;
		}

		public override JSONNode Remove(int aIndex)
		{
			if (aIndex < 0 || aIndex >= m_Dict.Count)
			{
				return null;
			}
			KeyValuePair<string, JSONNode> keyValuePair = m_Dict.ElementAt(aIndex);
			m_Dict.Remove(keyValuePair.Key);
			return keyValuePair.Value;
		}

		public override JSONNode Remove(JSONNode aNode)
		{
			try
			{
				KeyValuePair<string, JSONNode> keyValuePair = m_Dict.Where((KeyValuePair<string, JSONNode> k) => k.Value == aNode).First();
				m_Dict.Remove(keyValuePair.Key);
				return aNode;
			}
			catch
			{
				return null;
			}
		}

		public IEnumerator GetEnumerator()
		{
			foreach (KeyValuePair<string, JSONNode> item in m_Dict)
			{
				yield return item;
			}
		}

		public override void Serialize(BinaryWriter aWriter)
		{
			aWriter.Write((byte)2);
			aWriter.Write(m_Dict.Count);
			foreach (string key in m_Dict.Keys)
			{
				aWriter.Write(key);
				m_Dict[key].Serialize(aWriter);
			}
		}

		internal override void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode)
		{
			aSB.Append('{');
			bool flag = true;
			if (inline)
			{
				aMode = JSONTextMode.Compact;
			}
			foreach (KeyValuePair<string, JSONNode> item in m_Dict)
			{
				if (!flag)
				{
					aSB.Append(',');
				}
				flag = false;
				if (aMode == JSONTextMode.Indent)
				{
					aSB.AppendLine();
				}
				if (aMode == JSONTextMode.Indent)
				{
					aSB.Append(' ', aIndent + aIndentInc);
				}
				aSB.Append('"').Append(JSONNode.Escape(item.Key)).Append('"');
				if (aMode == JSONTextMode.Compact)
				{
					aSB.Append(':');
				}
				else
				{
					aSB.Append(" : ");
				}
				item.Value.WriteToStringBuilder(aSB, aIndent + aIndentInc, aIndentInc, aMode);
			}
			if (aMode == JSONTextMode.Indent)
			{
				aSB.AppendLine().Append(' ', aIndent);
			}
			aSB.Append('}');
		}
	}
	public class JSONString : JSONNode
	{
		private string m_Data;

		public override JSONNodeType Tag => JSONNodeType.String;

		public override bool IsString => true;

		public override string Value
		{
			get
			{
				return m_Data;
			}
			set
			{
				m_Data = value;
			}
		}

		public JSONString(string aData)
		{
			m_Data = aData;
		}

		public override void Serialize(BinaryWriter aWriter)
		{
			aWriter.Write((byte)3);
			aWriter.Write(m_Data);
		}

		internal override void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode)
		{
			aSB.Append('"').Append(JSONNode.Escape(m_Data)).Append('"');
		}

		public override bool Equals(object obj)
		{
			if (base.Equals(obj))
			{
				return true;
			}
			if (obj is string text)
			{
				return m_Data == text;
			}
			JSONString jSONString = obj as JSONString;
			if (jSONString != null)
			{
				return m_Data == jSONString.m_Data;
			}
			return false;
		}

		public override int GetHashCode()
		{
			return m_Data.GetHashCode();
		}
	}
	public class JSONNumber : JSONNode
	{
		private double m_Data;

		public override JSONNodeType Tag => JSONNodeType.Number;

		public override bool IsNumber => true;

		public override string Value
		{
			get
			{
				return m_Data.ToString();
			}
			set
			{
				if (double.TryParse(value, out var result))
				{
					m_Data = result;
				}
			}
		}

		public override double AsDouble
		{
			get
			{
				return m_Data;
			}
			set
			{
				m_Data = value;
			}
		}

		public JSONNumber(double aData)
		{
			m_Data = aData;
		}

		public JSONNumber(string aData)
		{
			Value = aData;
		}

		public override void Serialize(BinaryWriter aWriter)
		{
			aWriter.Write((byte)4);
			aWriter.Write(m_Data);
		}

		internal override void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode)
		{
			aSB.Append(m_Data);
		}

		private static bool IsNumeric(object value)
		{
			if (!(value is int) && !(value is uint) && !(value is float) && !(value is double) && !(value is decimal) && !(value is long) && !(value is ulong) && !(value is short) && !(value is ushort) && !(value is sbyte))
			{
				return value is byte;
			}
			return true;
		}

		public override bool Equals(object obj)
		{
			if (obj == null)
			{
				return false;
			}
			if (base.Equals(obj))
			{
				return true;
			}
			JSONNumber jSONNumber = obj as JSONNumber;
			if (jSONNumber != null)
			{
				return m_Data == jSONNumber.m_Data;
			}
			if (IsNumeric(obj))
			{
				return Convert.ToDouble(obj) == m_Data;
			}
			return false;
		}

		public override int GetHashCode()
		{
			return m_Data.GetHashCode();
		}
	}
	public class JSONBool : JSONNode
	{
		private bool m_Data;

		public override JSONNodeType Tag => JSONNodeType.Boolean;

		public override bool IsBoolean => true;

		public override string Value
		{
			get
			{
				return m_Data.ToString();
			}
			set
			{
				if (bool.TryParse(value, out var result))
				{
					m_Data = result;
				}
			}
		}

		public override bool AsBool
		{
			get
			{
				return m_Data;
			}
			set
			{
				m_Data = value;
			}
		}

		public JSONBool(bool aData)
		{
			m_Data = aData;
		}

		public JSONBool(string aData)
		{
			Value = aData;
		}

		public override void Serialize(BinaryWriter aWriter)
		{
			aWriter.Write((byte)6);
			aWriter.Write(m_Data);
		}

		internal override void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode)
		{
			aSB.Append(m_Data ? "true" : "false");
		}

		public override bool Equals(object obj)
		{
			if (obj == null)
			{
				return false;
			}
			if (obj is bool)
			{
				return m_Data == (bool)obj;
			}
			return false;
		}

		public override int GetHashCode()
		{
			return m_Data.GetHashCode();
		}
	}
	public class JSONNull : JSONNode
	{
		public override JSONNodeType Tag => JSONNodeType.NullValue;

		public override bool IsNull => true;

		public override string Value
		{
			get
			{
				return "null";
			}
			set
			{
			}
		}

		public override bool AsBool
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public override bool Equals(object obj)
		{
			if ((object)this == obj)
			{
				return true;
			}
			return obj is JSONNull;
		}

		public override int GetHashCode()
		{
			return 0;
		}

		public override void Serialize(BinaryWriter aWriter)
		{
			aWriter.Write((byte)5);
		}

		internal override void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode)
		{
			aSB.Append("null");
		}
	}
	internal class JSONLazyCreator : JSONNode
	{
		private JSONNode m_Node;

		private string m_Key;

		public override JSONNodeType Tag => JSONNodeType.None;

		public override JSONNode this[int aIndex]
		{
			get
			{
				return new JSONLazyCreator(this);
			}
			set
			{
				JSONArray jSONArray = new JSONArray();
				jSONArray.Add(value);
				Set(jSONArray);
			}
		}

		public override JSONNode this[string aKey]
		{
			get
			{
				return new JSONLazyCreator(this, aKey);
			}
			set
			{
				JSONObject jSONObject = new JSONObject();
				jSONObject.Add(aKey, value);
				Set(jSONObject);
			}
		}

		public override int AsInt
		{
			get
			{
				JSONNumber aVal = new JSONNumber(0.0);
				Set(aVal);
				return 0;
			}
			set
			{
				JSONNumber aVal = new JSONNumber(value);
				Set(aVal);
			}
		}

		public override float AsFloat
		{
			get
			{
				JSONNumber aVal = new JSONNumber(0.0);
				Set(aVal);
				return 0f;
			}
			set
			{
				JSONNumber aVal = new JSONNumber(value);
				Set(aVal);
			}
		}

		public override double AsDouble
		{
			get
			{
				JSONNumber aVal = new JSONNumber(0.0);
				Set(aVal);
				return 0.0;
			}
			set
			{
				JSONNumber aVal = new JSONNumber(value);
				Set(aVal);
			}
		}

		public override bool AsBool
		{
			get
			{
				JSONBool aVal = new JSONBool(aData: false);
				Set(aVal);
				return false;
			}
			set
			{
				JSONBool aVal = new JSONBool(value);
				Set(aVal);
			}
		}

		public override JSONArray AsArray
		{
			get
			{
				JSONArray jSONArray = new JSONArray();
				Set(jSONArray);
				return jSONArray;
			}
		}

		public override JSONObject AsObject
		{
			get
			{
				JSONObject jSONObject = new JSONObject();
				Set(jSONObject);
				return jSONObject;
			}
		}

		public JSONLazyCreator(JSONNode aNode)
		{
			m_Node = aNode;
			m_Key = null;
		}

		public JSONLazyCreator(JSONNode aNode, string aKey)
		{
			m_Node = aNode;
			m_Key = aKey;
		}

		private void Set(JSONNode aVal)
		{
			if (m_Key == null)
			{
				m_Node.Add(aVal);
			}
			else
			{
				m_Node.Add(m_Key, aVal);
			}
			m_Node = null;
		}

		public override void Add(JSONNode aItem)
		{
			JSONArray jSONArray = new JSONArray();
			jSONArray.Add(aItem);
			Set(jSONArray);
		}

		public override void Add(string aKey, JSONNode aItem)
		{
			JSONObject jSONObject = new JSONObject();
			jSONObject.Add(aKey, aItem);
			Set(jSONObject);
		}

		public static bool operator ==(JSONLazyCreator a, object b)
		{
			if (b == null)
			{
				return true;
			}
			return (object)a == b;
		}

		public static bool operator !=(JSONLazyCreator a, object b)
		{
			return !(a == b);
		}

		public override bool Equals(object obj)
		{
			if (obj == null)
			{
				return true;
			}
			return (object)this == obj;
		}

		public override int GetHashCode()
		{
			return 0;
		}

		internal override void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode)
		{
			aSB.Append("null");
		}
	}
	public static class JSON
	{
		public static JSONNode Parse(string aJSON)
		{
			return JSONNode.Parse(aJSON);
		}
	}
}
namespace POpusCodec
{
	public class OpusDecoder : IDisposable
	{
		private IntPtr _handle = IntPtr.Zero;

		private string _version = string.Empty;

		private const int MaxFrameSize = 5760;

		private bool _previousPacketInvalid = true;

		private int _channelCount;

		private static readonly float[] EmptyBufferFloat = new float[0];

		private static readonly short[] EmptyBufferShort = new short[0];

		private Bandwidth? _previousPacketBandwidth;

		private float[] bufferFloat;

		private short[] bufferShort;

		public string Version => _version;

		public Bandwidth? PreviousPacketBandwidth => _previousPacketBandwidth;

		public OpusDecoder(SamplingRate outputSamplingRateHz, Channels numChannels)
		{
			if (outputSamplingRateHz != SamplingRate.Sampling08000 && outputSamplingRateHz != SamplingRate.Sampling12000 && outputSamplingRateHz != SamplingRate.Sampling16000 && outputSamplingRateHz != SamplingRate.Sampling24000 && outputSamplingRateHz != SamplingRate.Sampling48000)
			{
				throw new ArgumentOutOfRangeException("outputSamplingRateHz", string.Concat("Must use one of the pre-defined sampling rates (", outputSamplingRateHz, ")"));
			}
			if (numChannels != Channels.Mono && numChannels != Channels.Stereo)
			{
				throw new ArgumentOutOfRangeException("numChannels", "Must be Mono or Stereo");
			}
			_channelCount = (int)numChannels;
			_handle = Wrapper.opus_decoder_create(outputSamplingRateHz, numChannels);
			_version = Marshal.PtrToStringAnsi(Wrapper.opus_get_version_string());
			if (_handle == IntPtr.Zero)
			{
				throw new OpusException(OpusStatusCode.AllocFail, "Memory was not allocated for the encoder");
			}
		}

		public float[] DecodePacketFloat(byte[] packetData)
		{
			if (bufferFloat == null && packetData == null)
			{
				return EmptyBufferFloat;
			}
			int num = 0;
			float[] array = ((bufferFloat != null) ? bufferFloat : new float[5760 * _channelCount]);
			num = Wrapper.opus_decode(_handle, packetData, array, 0, _channelCount);
			if (packetData == null)
			{
				_previousPacketInvalid = false;
			}
			else
			{
				int num2 = Wrapper.opus_packet_get_bandwidth(packetData);
				_previousPacketInvalid = num2 == -4;
			}
			if (num == 0)
			{
				return EmptyBufferFloat;
			}
			if (bufferFloat == null)
			{
				bufferFloat = new float[num * _channelCount];
				Buffer.BlockCopy(array, 0, bufferFloat, 0, num * 4);
			}
			return bufferFloat;
		}

		public short[] DecodePacketShort(byte[] packetData)
		{
			if (bufferShort == null && packetData == null)
			{
				return EmptyBufferShort;
			}
			int num = 0;
			short[] array = ((bufferShort != null) ? bufferShort : new short[5760 * _channelCount]);
			num = Wrapper.opus_decode(_handle, packetData, array, 0, _channelCount);
			if (packetData == null)
			{
				_previousPacketInvalid = false;
			}
			else
			{
				int num2 = Wrapper.opus_packet_get_bandwidth(packetData);
				_previousPacketInvalid = num2 == -4;
			}
			if (num == 0)
			{
				return EmptyBufferShort;
			}
			if (bufferShort == null)
			{
				bufferShort = new short[num * _channelCount];
				Buffer.BlockCopy(array, 0, bufferShort, 0, num * 2);
			}
			return bufferShort;
		}

		public void Dispose()
		{
			if (_handle != IntPtr.Zero)
			{
				Wrapper.opus_decoder_destroy(_handle);
				_handle = IntPtr.Zero;
			}
		}
	}
	public class OpusEncoder : IDisposable
	{
		public const int BitrateMax = -1;

		private IntPtr _handle = IntPtr.Zero;

		private string _version = string.Empty;

		private const int RecommendedMaxPacketSize = 4000;

		private int _frameSizePerChannel = 960;

		private SamplingRate _inputSamplingRate = SamplingRate.Sampling48000;

		private Channels _inputChannels = Channels.Stereo;

		private readonly byte[] writePacket = new byte[4000];

		private static readonly ArraySegment<byte> EmptyBuffer = new ArraySegment<byte>(new byte[0]);

		private Delay _encoderDelay = Delay.Delay20ms;

		public SamplingRate InputSamplingRate => _inputSamplingRate;

		public Channels InputChannels => _inputChannels;

		public string Version => _version;

		public Delay EncoderDelay
		{
			get
			{
				return _encoderDelay;
			}
			set
			{
				_encoderDelay = value;
				_frameSizePerChannel = (int)((decimal)((int)_inputSamplingRate / 1000) * (decimal)(int)_encoderDelay / 2m);
			}
		}

		public int FrameSizePerChannel => _frameSizePerChannel;

		public int Bitrate
		{
			get
			{
				return Wrapper.get_opus_encoder_ctl(_handle, OpusCtlGetRequest.Bitrate);
			}
			set
			{
				Wrapper.set_opus_encoder_ctl(_handle, OpusCtlSetRequest.Bitrate, value);
			}
		}

		public Bandwidth MaxBandwidth
		{
			get
			{
				return (Bandwidth)Wrapper.get_opus_encoder_ctl(_handle, OpusCtlGetRequest.MaxBandwidth);
			}
			set
			{
				Wrapper.set_opus_encoder_ctl(_handle, OpusCtlSetRequest.MaxBandwidth, (int)value);
			}
		}

		public Complexity Complexity
		{
			get
			{
				return (Complexity)Wrapper.get_opus_encoder_ctl(_handle, OpusCtlGetRequest.Complexity);
			}
			set
			{
				Wrapper.set_opus_encoder_ctl(_handle, OpusCtlSetRequest.Complexity, (int)value);
			}
		}

		public int ExpectedPacketLossPercentage
		{
			get
			{
				return Wrapper.get_opus_encoder_ctl(_handle, OpusCtlGetRequest.PacketLossPercentage);
			}
			set
			{
				Wrapper.set_opus_encoder_ctl(_handle, OpusCtlSetRequest.PacketLossPercentage, value);
			}
		}

		public SignalHint SignalHint
		{
			get
			{
				return (SignalHint)Wrapper.get_opus_encoder_ctl(_handle, OpusCtlGetRequest.Signal);
			}
			set
			{
				Wrapper.set_opus_encoder_ctl(_handle, OpusCtlSetRequest.Signal, (int)value);
			}
		}

		public ForceChannels ForceChannels
		{
			get
			{
				return (ForceChannels)Wrapper.get_opus_encoder_ctl(_handle, OpusCtlGetRequest.ForceChannels);
			}
			set
			{
				Wrapper.set_opus_encoder_ctl(_handle, OpusCtlSetRequest.ForceChannels, (int)value);
			}
		}

		public bool UseInbandFEC
		{
			get
			{
				return Wrapper.get_opus_encoder_ctl(_handle, OpusCtlGetRequest.InbandFec) == 1;
			}
			set
			{
				Wrapper.set_opus_encoder_ctl(_handle, OpusCtlSetRequest.InbandFec, value ? 1 : 0);
			}
		}

		public bool UseUnconstrainedVBR
		{
			get
			{
				return Wrapper.get_opus_encoder_ctl(_handle, OpusCtlGetRequest.VBRConstraint) == 0;
			}
			set
			{
				Wrapper.set_opus_encoder_ctl(_handle, OpusCtlSetRequest.VBRConstraint, (!value) ? 1 : 0);
			}
		}

		public bool DtxEnabled
		{
			get
			{
				return Wrapper.get_opus_encoder_ctl(_handle, OpusCtlGetRequest.Dtx) == 1;
			}
			set
			{
				Wrapper.set_opus_encoder_ctl(_handle, OpusCtlSetRequest.Dtx, value ? 1 : 0);
			}
		}

		public OpusEncoder(SamplingRate inputSamplingRateHz, Channels numChannels, int bitrate, OpusApplicationType applicationType, Delay encoderDelay)
		{
			if (inputSamplingRateHz != SamplingRate.Sampling08000 && inputSamplingRateHz != SamplingRate.Sampling12000 && inputSamplingRateHz != SamplingRate.Sampling16000 && inputSamplingRateHz != SamplingRate.Sampling24000 && inputSamplingRateHz != SamplingRate.Sampling48000)
			{
				throw new ArgumentOutOfRangeException("inputSamplingRateHz", string.Concat("Must use one of the pre-defined sampling rates(", inputSamplingRateHz, ")"));
			}
			if (numChannels != Channels.Mono && numChannels != Channels.Stereo)
			{
				throw new ArgumentOutOfRangeException("numChannels", "Must be Mono or Stereo");
			}
			if (applicationType != OpusApplicationType.Audio && applicationType != OpusApplicationType.RestrictedLowDelay && applicationType != OpusApplicationType.Voip)
			{
				throw new ArgumentOutOfRangeException("applicationType", string.Concat("Must use one of the pre-defined application types (", applicationType, ")"));
			}
			if (encoderDelay != Delay.Delay10ms && encoderDelay != Delay.Delay20ms && encoderDelay != Delay.Delay2dot5ms && encoderDelay != Delay.Delay40ms && encoderDelay != Delay.Delay5ms && encoderDelay != Delay.Delay60ms)
			{
				throw new ArgumentOutOfRangeException("encoderDelay", string.Concat("Must use one of the pre-defined delay values (", encoderDelay, ")"));
			}
			_inputSamplingRate = inputSamplingRateHz;
			_inputChannels = numChannels;
			_handle = Wrapper.opus_encoder_create(inputSamplingRateHz, numChannels, applicationType);
			_version = Marshal.PtrToStringAnsi(Wrapper.opus_get_version_string());
			if (_handle == IntPtr.Zero)
			{
				throw new OpusException(OpusStatusCode.AllocFail, "Memory was not allocated for the encoder");
			}
			EncoderDelay = encoderDelay;
			Bitrate = bitrate;
		}

		public ArraySegment<byte> Encode(float[] pcmSamples)
		{
			int num = Wrapper.opus_encode(_handle, pcmSamples, _frameSizePerChannel, writePacket);
			if (num <= 1)
			{
				return EmptyBuffer;
			}
			return new ArraySegment<byte>(writePacket, 0, num);
		}

		public ArraySegment<byte> Encode(short[] pcmSamples)
		{
			int num = Wrapper.opus_encode(_handle, pcmSamples, _frameSizePerChannel, writePacket);
			if (num <= 1)
			{
				return EmptyBuffer;
			}
			return new ArraySegment<byte>(writePacket, 0, num);
		}

		public void Dispose()
		{
			if (_handle != IntPtr.Zero)
			{
				Wrapper.opus_encoder_destroy(_handle);
				_handle = IntPtr.Zero;
			}
		}
	}
	public class OpusException : Exception
	{
		private OpusStatusCode _statusCode;

		public OpusStatusCode StatusCode => _statusCode;

		public OpusException(OpusStatusCode statusCode, string message)
			: base(message)
		{
			_statusCode = statusCode;
		}
	}
	internal class Wrapper
	{
		private const string lib_name = "opus_egpv";

		[DllImport("opus_egpv", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		private static extern int opus_encoder_get_size(Channels channels);

		[DllImport("opus_egpv", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		private static extern OpusStatusCode opus_encoder_init(IntPtr st, SamplingRate Fs, Channels channels, OpusApplicationType application);

		[DllImport("opus_egpv", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern IntPtr opus_get_version_string();

		[DllImport("opus_egpv", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		private static extern int opus_encode(IntPtr st, short[] pcm, int frame_size, byte[] data, int max_data_bytes);

		[DllImport("opus_egpv", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		private static extern int opus_encode_float(IntPtr st, float[] pcm, int frame_size, byte[] data, int max_data_bytes);

		[DllImport("opus_egpv", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		private static extern int opus_encoder_ctl_set(IntPtr st, OpusCtlSetRequest request, int value);

		[DllImport("opus_egpv", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		private static extern int opus_encoder_ctl_get(IntPtr st, OpusCtlGetRequest request, ref int value);

		[DllImport("opus_egpv", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		private static extern int opus_decoder_ctl_set(IntPtr st, OpusCtlSetRequest request, int value);

		[DllImport("opus_egpv", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		private static extern int opus_decoder_ctl_get(IntPtr st, OpusCtlGetRequest request, ref int value);

		[DllImport("opus_egpv", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		private static extern int opus_decoder_get_size(Channels channels);

		[DllImport("opus_egpv", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		private static extern OpusStatusCode opus_decoder_init(IntPtr st, SamplingRate Fs, Channels channels);

		[DllImport("opus_egpv", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		private static extern int opus_decode(IntPtr st, byte[] data, int len, short[] pcm, int frame_size, int decode_fec);

		[DllImport("opus_egpv", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		private static extern int opus_decode_float(IntPtr st, byte[] data, int len, float[] pcm, int frame_size, int decode_fec);

		[DllImport("opus_egpv", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int opus_packet_get_bandwidth(byte[] data);

		[DllImport("opus_egpv", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int opus_packet_get_nb_channels(byte[] data);

		[DllImport("opus_egpv", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		private static extern IntPtr opus_strerror(OpusStatusCode error);

		public static IntPtr opus_encoder_create(SamplingRate Fs, Channels channels, OpusApplicationType application)
		{
			IntPtr intPtr = Marshal.AllocHGlobal(opus_encoder_get_size(channels));
			OpusStatusCode statusCode = opus_encoder_init(intPtr, Fs, channels, application);
			try
			{
				HandleStatusCode(statusCode);
				return intPtr;
			}
			catch (Exception ex)
			{
				if (intPtr != IntPtr.Zero)
				{
					opus_encoder_destroy(intPtr);
					intPtr = IntPtr.Zero;
				}
				throw ex;
			}
		}

		public static int opus_encode(IntPtr st, short[] pcm, int frame_size, byte[] data)
		{
			if (st == IntPtr.Zero)
			{
				throw new ObjectDisposedException("OpusEncoder");
			}
			int num = opus_encode(st, pcm, frame_size, data, data.Length);
			if (num <= 0)
			{
				HandleStatusCode((OpusStatusCode)num);
			}
			return num;
		}

		public static int opus_encode(IntPtr st, float[] pcm, int frame_size, byte[] data)
		{
			if (st == IntPtr.Zero)
			{
				throw new ObjectDisposedException("OpusEncoder");
			}
			int num = opus_encode_float(st, pcm, frame_size, data, data.Length);
			if (num <= 0)
			{
				HandleStatusCode((OpusStatusCode)num);
			}
			return num;
		}

		public static void opus_encoder_destroy(IntPtr st)
		{
			Marshal.FreeHGlobal(st);
		}

		public static int get_opus_encoder_ctl(IntPtr st, OpusCtlGetRequest request)
		{
			if (st == IntPtr.Zero)
			{
				throw new ObjectDisposedException("OpusEncoder");
			}
			int value = 0;
			HandleStatusCode((OpusStatusCode)opus_encoder_ctl_get(st, request, ref value));
			return value;
		}

		public static void set_opus_encoder_ctl(IntPtr st, OpusCtlSetRequest request, int value)
		{
			if (st == IntPtr.Zero)
			{
				throw new ObjectDisposedException("OpusEncoder");
			}
			HandleStatusCode((OpusStatusCode)opus_encoder_ctl_set(st, request, value));
		}

		public static int get_opus_decoder_ctl(IntPtr st, OpusCtlGetRequest request)
		{
			if (st == IntPtr.Zero)
			{
				throw new ObjectDisposedException("OpusDcoder");
			}
			int value = 0;
			HandleStatusCode((OpusStatusCode)opus_decoder_ctl_get(st, request, ref value));
			return value;
		}

		public static void set_opus_decoder_ctl(IntPtr st, OpusCtlSetRequest request, int value)
		{
			if (st == IntPtr.Zero)
			{
				throw new ObjectDisposedException("OpusDecoder");
			}
			HandleStatusCode((OpusStatusCode)opus_decoder_ctl_set(st, request, value));
		}

		public static IntPtr opus_decoder_create(SamplingRate Fs, Channels channels)
		{
			IntPtr intPtr = Marshal.AllocHGlobal(opus_decoder_get_size(channels));
			OpusStatusCode statusCode = opus_decoder_init(intPtr, Fs, channels);
			try
			{
				HandleStatusCode(statusCode);
				return intPtr;
			}
			catch (Exception ex)
			{
				if (intPtr != IntPtr.Zero)
				{
					opus_decoder_destroy(intPtr);
					intPtr = IntPtr.Zero;
				}
				throw ex;
			}
		}

		public static void opus_decoder_destroy(IntPtr st)
		{
			Marshal.FreeHGlobal(st);
		}

		public static int opus_decode(IntPtr st, byte[] data, short[] pcm, int decode_fec, int channels)
		{
			if (st == IntPtr.Zero)
			{
				throw new ObjectDisposedException("OpusDecoder");
			}
			int num = 0;
			num = ((data == null) ? opus_decode(st, null, 0, pcm, pcm.Length / channels, decode_fec) : opus_decode(st, data, data.Length, pcm, pcm.Length / channels, decode_fec));
			if (num == -4)
			{
				return 0;
			}
			if (num <= 0)
			{
				HandleStatusCode((OpusStatusCode)num);
			}
			return num;
		}

		public static int opus_decode(IntPtr st, byte[] data, float[] pcm, int decode_fec, int channels)
		{
			if (st == IntPtr.Zero)
			{
				throw new ObjectDisposedException("OpusDecoder");
			}
			int num = 0;
			num = ((data == null) ? opus_decode_float(st, null, 0, pcm, pcm.Length / channels, decode_fec) : opus_decode_float(st, data, data.Length, pcm, pcm.Length / channels, decode_fec));
			if (num == -4)
			{
				return 0;
			}
			if (num <= 0)
			{
				HandleStatusCode((OpusStatusCode)num);
			}
			return num;
		}

		private static void HandleStatusCode(OpusStatusCode statusCode)
		{
			if (statusCode != 0)
			{
				throw new OpusException(statusCode, Marshal.PtrToStringAnsi(opus_strerror(statusCode)));
			}
		}
	}
}
namespace POpusCodec.Enums
{
	public enum Bandwidth
	{
		Narrowband = 1101,
		Mediumband,
		Wideband,
		SuperWideband,
		Fullband
	}
	public enum Channels
	{
		Mono = 1,
		Stereo
	}
	public enum Complexity
	{
		Complexity0,
		Complexity1,
		Complexity2,
		Complexity3,
		Complexity4,
		Complexity5,
		Complexity6,
		Complexity7,
		Complexity8,
		Complexity9,
		Complexity10
	}
	public enum Delay
	{
		Delay2dot5ms = 5,
		Delay5ms = 10,
		Delay10ms = 20,
		Delay20ms = 40,
		Delay40ms = 80,
		Delay60ms = 120
	}
	public enum ForceChannels
	{
		NoForce = -1000,
		Mono = 1,
		Stereo = 2
	}
	public enum OpusApplicationType
	{
		Voip = 2048,
		Audio = 2049,
		RestrictedLowDelay = 2051
	}
	internal enum OpusCtlGetRequest
	{
		Application = 4001,
		Bitrate = 4003,
		MaxBandwidth = 4005,
		VBR = 4007,
		Bandwidth = 4009,
		Complexity = 4011,
		InbandFec = 4013,
		PacketLossPercentage = 4015,
		Dtx = 4017,
		VBRConstraint = 4021,
		ForceChannels = 4023,
		Signal = 4025,
		LookAhead = 4027,
		SampleRate = 4029,
		FinalRange = 4031,
		Pitch = 4033,
		Gain = 4035,
		LsbDepth = 4037,
		LastPacketDurationRequest = 4039
	}
	internal enum OpusCtlSetRequest
	{
		Application = 4000,
		Bitrate = 4002,
		MaxBandwidth = 4004,
		VBR = 4006,
		Bandwidth = 4008,
		Complexity = 4010,
		InbandFec = 4012,
		PacketLossPercentage = 4014,
		Dtx = 4016,
		VBRConstraint = 4020,
		ForceChannels = 4022,
		Signal = 4024,
		Gain = 4034,
		LsbDepth = 4036
	}
	public enum OpusStatusCode
	{
		OK = 0,
		BadArguments = -1,
		BufferTooSmall = -2,
		InternalError = -3,
		InvalidPacket = -4,
		Unimplemented = -5,
		InvalidState = -6,
		AllocFail = -7
	}
	public enum SamplingRate
	{
		Sampling08000 = 8000,
		Sampling12000 = 12000,
		Sampling16000 = 16000,
		Sampling24000 = 24000,
		Sampling48000 = 48000
	}
	public enum SignalHint
	{
		Auto = -1000,
		Voice = 3001,
		Music = 3002
	}
}
namespace ExitGames.Client.Photon.Voice
{
	public static class AudioUtil
	{
		public class Resampler<T> : LocalVoiceFramed<T>.IProcessor, IDisposable
		{
			protected T[] frameResampled;

			private int channels;

			public Resampler(int dstSize, int channels)
			{
				frameResampled = new T[dstSize];
				this.channels = channels;
			}

			public T[] Process(T[] buf)
			{
				Resample(buf, frameResampled, frameResampled.Length, channels);
				return frameResampled;
			}

			public void Dispose()
			{
			}
		}

		public interface ILevelMeter
		{
			float CurrentAvgAmp { get; }

			float CurrentPeakAmp { get; }

			float AccumAvgPeakAmp { get; }

			void ResetAccumAvgPeakAmp();
		}

		public class LevelMetterDummy : ILevelMeter
		{
			public float CurrentAvgAmp => 0f;

			public float CurrentPeakAmp => 0f;

			public float AccumAvgPeakAmp => 0f;

			public void ResetAccumAvgPeakAmp()
			{
			}
		}

		public abstract class LevelMeter<T> : LocalVoiceFramed<T>.IProcessor, IDisposable, ILevelMeter
		{
			protected float ampSum;

			protected float ampPeak;

			protected int bufferSize;

			protected float[] buffer;

			protected int prevValuesPtr;

			protected float accumAvgPeakAmpSum;

			protected int accumAvgPeakAmpCount;

			public float CurrentAvgAmp => ampSum / (float)bufferSize;

			public float CurrentPeakAmp { get; protected set; }

			public float AccumAvgPeakAmp
			{
				get
				{
					if (accumAvgPeakAmpCount != 0)
					{
						return accumAvgPeakAmpSum / (float)accumAvgPeakAmpCount;
					}
					return 0f;
				}
			}

			internal LevelMeter(int samplingRate, int numChannels)
			{
				bufferSize = samplingRate * numChannels / 2;
				buffer = new float[bufferSize];
			}

			public void ResetAccumAvgPeakAmp()
			{
				accumAvgPeakAmpSum = 0f;
				accumAvgPeakAmpCount = 0;
				ampPeak = 0f;
			}

			public abstract T[] Process(T[] buf);

			public void Dispose()
			{
			}
		}

		public class LevelMeterFloat : LevelMeter<float>
		{
			public LevelMeterFloat(int samplingRate, int numChannels)
				: base(samplingRate, numChannels)
			{
			}

			public override float[] Process(float[] buf)
			{
				for (int i = 0; i < buf.Length; i++)
				{
					float num = buf[i];
					if (num < 0f)
					{
						num = 0f - num;
					}
					ampSum = ampSum + num - buffer[prevValuesPtr];
					buffer[prevValuesPtr] = num;
					if (ampPeak < num)
					{
						ampPeak = num;
					}
					if (prevValuesPtr == 0)
					{
						base.CurrentPeakAmp = ampPeak;
						ampPeak = 0f;
						accumAvgPeakAmpSum += base.CurrentPeakAmp;
						accumAvgPeakAmpCount++;
					}
					prevValuesPtr = (prevValuesPtr + 1) % bufferSize;
				}
				return buf;
			}
		}

		public class LevelMeterShort : LevelMeter<short>
		{
			public LevelMeterShort(int samplingRate, int numChannels)
				: base(samplingRate, numChannels)
			{
			}

			public override short[] Process(short[] buf)
			{
				for (int i = 0; i < buf.Length; i++)
				{
					short num = buf[i];
					if (num < 0)
					{
						num = (short)(-num);
					}
					ampSum = ampSum + (float)num - buffer[prevValuesPtr];
					buffer[prevValuesPtr] = num;
					if (ampPeak < (float)num)
					{
						ampPeak = num;
					}
					if (prevValuesPtr == 0)
					{
						base.CurrentPeakAmp = ampPeak;
						ampPeak = 0f;
						accumAvgPeakAmpSum += base.CurrentPeakAmp;
						accumAvgPeakAmpCount++;
					}
					prevValuesPtr = (prevValuesPtr + 1) % bufferSize;
				}
				return buf;
			}
		}

		public interface IVoiceDetector
		{
			bool On { get; set; }

			float Threshold { get; set; }

			bool Detected { get; }

			DateTime DetectedTime { get; }

			int ActivityDelayMs { get; set; }

			event Action OnDetected;
		}

		public class VoiceDetectorCalibration<T> : LocalVoiceFramed<T>.IProcessor, IDisposable
		{
			private IVoiceDetector voiceDetector;

			private ILevelMeter levelMeter;

			private int valuesPerSec;

			protected int voiceDetectorCalibrateCount;

			public bool VoiceDetectorCalibrating => voiceDetectorCalibrateCount > 0;

			public VoiceDetectorCalibration(IVoiceDetector voiceDetector, ILevelMeter levelMeter, int samplingRate, int channels)
			{
				valuesPerSec = samplingRate * channels;
				this.voiceDetector = voiceDetector;
				this.levelMeter = levelMeter;
			}

			public void VoiceDetectorCalibrate(int durationMs)
			{
				voiceDetectorCalibrateCount = valuesPerSec * durationMs / 1000;
				levelMeter.ResetAccumAvgPeakAmp();
			}

			public T[] Process(T[] buf)
			{
				if (voiceDetectorCalibrateCount != 0)
				{
					voiceDetectorCalibrateCount -= buf.Length;
					if (voiceDetectorCalibrateCount <= 0)
					{
						voiceDetectorCalibrateCount = 0;
						voiceDetector.Threshold = levelMeter.AccumAvgPeakAmp * 2f;
					}
				}
				return buf;
			}

			public void Dispose()
			{
			}
		}

		public class VoiceDetectorDummy : IVoiceDetector
		{
			public bool On
			{
				get
				{
					return false;
				}
				set
				{
				}
			}

			public float Threshold
			{
				get
				{
					return 0f;
				}
				set
				{
				}
			}

			public bool Detected => false;

			public int ActivityDelayMs
			{
				get
				{
					return 0;
				}
				set
				{
				}
			}

			public DateTime DetectedTime { get; private set; }

			public event Action OnDetected;
		}

		public abstract class VoiceDetector<T> : LocalVoiceFramed<T>.IProcessor, IDisposable, IVoiceDetector
		{
			private bool detected;

			protected int activityDelay;

			protected int autoSilenceCounter;

			protected int valuesCountPerSec;

			protected int activityDelayValuesCount;

			public bool On { get; set; }

			public float Threshold { get; set; }

			public bool Detected
			{
				get
				{
					return detected;
				}
				protected set
				{
					if (detected != value)
					{
						detected = value;
						DetectedTime = DateTime.Now;
						if (detected && this.OnDetected != null)
						{
							this.OnDetected();
						}
					}
				}
			}

			public DateTime DetectedTime { get; private set; }

			public int ActivityDelayMs
			{
				get
				{
					return activityDelay;
				}
				set
				{
					activityDelay = value;
					activityDelayValuesCount = value * valuesCountPerSec / 1000;
				}
			}

			public event Action OnDetected;

			internal VoiceDetector(int samplingRate, int numChannels)
			{
				valuesCountPerSec = samplingRate * numChannels;
				ActivityDelayMs = 500;
				On = true;
			}

			public abstract T[] Process(T[] buf);

			public void Dispose()
			{
			}
		}

		public class VoiceDetectorFloat : VoiceDetector<float>
		{
			public VoiceDetectorFloat(int samplingRate, int numChannels)
				: base(samplingRate, numChannels)
			{
				base.Threshold = 0.01f;
			}

			public override float[] Process(float[] buffer)
			{
				if (base.On)
				{
					for (int i = 0; i < buffer.Length; i++)
					{
						if (buffer[i] > base.Threshold)
						{
							base.Detected = true;
							autoSilenceCounter = 0;
						}
						else
						{
							autoSilenceCounter++;
						}
					}
					if (autoSilenceCounter > activityDelayValuesCount)
					{
						base.Detected = false;
					}
					if (!base.Detected)
					{
						return null;
					}
					return buffer;
				}
				return buffer;
			}
		}

		public class VoiceDetectorShort : VoiceDetector<short>
		{
			internal VoiceDetectorShort(int samplingRate, int numChannels)
				: base(samplingRate, numChannels)
			{
				base.Threshold = 327.66998f;
			}

			public override short[] Process(short[] buffer)
			{
				if (base.On)
				{
					for (int i = 0; i < buffer.Length; i++)
					{
						if ((float)buffer[i] > base.Threshold)
						{
							base.Detected = true;
							autoSilenceCounter = 0;
						}
						else
						{
							autoSilenceCounter++;
						}
					}
					if (autoSilenceCounter > activityDelayValuesCount)
					{
						base.Detected = false;
					}
					if (!base.Detected)
					{
						return null;
					}
					return buffer;
				}
				return buffer;
			}
		}

		public class VoiceLevelDetectCalibrate<T> : LocalVoiceFramed<T>.IProcessor, IDisposable
		{
			private VoiceDetectorCalibration<T> c;

			public ILevelMeter Level { get; private set; }

			public IVoiceDetector Detector { get; private set; }

			public VoiceLevelDetectCalibrate(int samplingRate, int channels)
			{
				T[] array = new T[1];
				if (array[0] is float)
				{
					Level = new LevelMeterFloat(samplingRate, channels);
					Detector = new VoiceDetectorFloat(samplingRate, channels);
				}
				else
				{
					if (!(array[0] is short))
					{
						throw new Exception("VoiceLevelDetectCalibrate: type not supported: " + array[0].GetType());
					}
					Level = new LevelMeterShort(samplingRate, channels);
					Detector = new VoiceDetectorShort(samplingRate, channels);
				}
				c = new VoiceDetectorCalibration<T>(Detector, Level, samplingRate, channels);
			}

			public void Calibrate(int durationMs)
			{
				c.VoiceDetectorCalibrate(durationMs);
			}

			public T[] Process(T[] buf)
			{
				buf = (Level as LocalVoiceFramed<T>.IProcessor).Process(buf);
				buf = ((LocalVoiceFramed<T>.IProcessor)c).Process(buf);
				buf = (Detector as LocalVoiceFramed<T>.IProcessor).Process(buf);
				return buf;
			}

			public void Dispose()
			{
				(Level as LocalVoiceFramed<T>.IProcessor).Dispose();
				(Detector as LocalVoiceFramed<T>.IProcessor).Dispose();
				c.Dispose();
			}
		}

		public static void Resample<T>(T[] src, T[] dst, int dstCount, int channels)
		{
			switch (channels)
			{
			case 1:
			{
				for (int i = 0; i < dstCount; i++)
				{
					dst[i] = src[i * src.Length / dstCount];
				}
				return;
			}
			case 2:
			{
				for (int j = 0; j < dstCount / 2; j++)
				{
					int num = j * src.Length / dstCount;
					int num2 = j * 2;
					int num3 = num * 2;
					dst[num2++] = src[num3++];
					dst[num2] = src[num3];
				}
				return;
			}
			}
			for (int k = 0; k < dstCount / channels; k++)
			{
				int num4 = k * src.Length / dstCount;
				int num5 = k * channels;
				int num6 = num4 * channels;
				for (int l = 0; l < channels; l++)
				{
					dst[num5++] = src[num6++];
				}
			}
		}

		public static void ResampleAndConvert(short[] src, float[] dst, int dstCount, int channels)
		{
			switch (channels)
			{
			case 1:
			{
				for (int i = 0; i < dstCount; i++)
				{
					dst[i] = (float)src[i * src.Length / dstCount] * 32767f;
				}
				return;
			}
			case 2:
			{
				for (int j = 0; j < dstCount / 2; j++)
				{
					int num = j * src.Length / dstCount;
					int num2 = j * 2;
					int num3 = num * 2;
					dst[num2++] = (float)src[num3++] * 32767f;
					dst[num2] = (float)src[num3] * 32767f;
				}
				return;
			}
			}
			for (int k = 0; k < dstCount / channels; k++)
			{
				int num4 = k * src.Length / dstCount;
				int num5 = k * channels;
				int num6 = num4 * channels;
				for (int l = 0; l < channels; l++)
				{
					dst[num5++] = (float)src[num6++] * 32767f;
				}
			}
		}

		public static void ResampleAndConvert(float[] src, short[] dst, int dstCount, int channels)
		{
			switch (channels)
			{
			case 1:
			{
				for (int i = 0; i < dstCount; i++)
				{
					dst[i] = (short)(src[i * src.Length / dstCount] * 32767f);
				}
				return;
			}
			case 2:
			{
				for (int j = 0; j < dstCount / 2; j++)
				{
					int num = j * src.Length / dstCount;
					int num2 = j * 2;
					int num3 = num * 2;
					dst[num2++] = (short)(src[num3++] * 32767f);
					dst[num2] = (short)(src[num3] * 32767f);
				}
				return;
			}
			}
			for (int k = 0; k < dstCount / channels; k++)
			{
				int num4 = k * src.Length / dstCount;
				int num5 = k * channels;
				int num6 = num4 * channels;
				for (int l = 0; l < channels; l++)
				{
					dst[num5++] = (short)(src[num6++] * 32767f);
				}
			}
		}

		public static void Convert(float[] src, short[] dst, int dstCount)
		{
			for (int i = 0; i < dstCount; i++)
			{
				dst[i] = (short)(src[i] * 32767f);
			}
		}

		public static void Convert(short[] src, float[] dst, int dstCount)
		{
			for (int i = 0; i < dstCount; i++)
			{
				dst[i] = (float)src[i] / 32767f;
			}
		}

		public static void ForceToStereo<T>(T[] src, T[] dst, int srcChannels)
		{
			int num = 0;
			for (int i = 0; i < dst.Length - 1; i += 2)
			{
				dst[i] = src[num];
				dst[i + 1] = ((srcChannels > 1) ? src[num + 1] : src[num]);
				num += srcChannels;
			}
		}

		internal static string tostr<T>(T[] x, int lim = 10)
		{
			StringBuilder stringBuilder = new StringBuilder();
			for (int i = 0; i < ((x.Length < lim) ? x.Length : lim); i++)
			{
				stringBuilder.Append("-");
				stringBuilder.Append(x[i]);
			}
			return stringBuilder.ToString();
		}
	}
	public interface IAudioOut
	{
		bool IsPlaying { get; }

		int CurrentBufferLag { get; }

		void Start(int frequency, int channels, int frameSamplesPerChannel, int playDelayMs);

		void Stop();

		void OnAudioFrame(float[] frame);

		void Service();
	}
	public abstract class ObjectPool<TType, TInfo> : IDisposable
	{
		protected int capacity;

		protected TInfo info;

		private TType[] freeObj = new TType[0];

		protected int pos;

		protected string name;

		private bool inited;

		internal string LogPrefix => "[ObjectPool] [" + name + "]";

		public TInfo Info => info;

		protected abstract TType createObject(TInfo info);

		protected abstract void destroyObject(TType obj);

		protected abstract bool infosMatch(TInfo i0, TInfo i1);

		public ObjectPool(int capacity, string name)
		{
			this.capacity = capacity;
			this.name = name;
		}

		public ObjectPool(int capacity, string name, TInfo info)
		{
			this.capacity = capacity;
			this.name = name;
			Init(info);
		}

		public void Init(TInfo info)
		{
			lock (this)
			{
				while (pos > 0)
				{
					destroyObject(freeObj[--pos]);
				}
				this.info = info;
				freeObj = new TType[capacity];
				inited = true;
			}
		}

		public TType AcquireOrCreate()
		{
			lock (this)
			{
				if (pos > 0)
				{
					return freeObj[--pos];
				}
				if (!inited)
				{
					throw new Exception(LogPrefix + " not initialized");
				}
			}
			return createObject(info);
		}

		public TType AcquireOrCreate(TInfo info)
		{
			if (!infosMatch(this.info, info))
			{
				Init(info);
			}
			return AcquireOrCreate();
		}

		public virtual bool Release(TType obj, TInfo objInfo)
		{
			if (infosMatch(info, objInfo))
			{
				lock (this)
				{
					if (pos < freeObj.Length)
					{
						freeObj[pos++] = obj;
						return true;
					}
				}
			}
			destroyObject(obj);
			return false;
		}

		public virtual bool Release(TType obj)
		{
			lock (this)
			{
				if (pos < freeObj.Length)
				{
					freeObj[pos++] = obj;
					return true;
				}
			}
			destroyObject(obj);
			return false;
		}

		public void Dispose()
		{
			lock (this)
			{
				while (pos > 0)
				{
					destroyObject(freeObj[--pos]);
				}
				freeObj = new TType[0];
			}
		}
	}
	public class PrimitiveArrayPool<T> : ObjectPool<T[], int>
	{
		public PrimitiveArrayPool(int capacity, string name)
			: base(capacity, name)
		{
		}

		public PrimitiveArrayPool(int capacity, string name, int info)
			: base(capacity, name, info)
		{
		}

		protected override T[] createObject(int info)
		{
			return new T[info];
		}

		protected override void destroyObject(T[] obj)
		{
		}

		protected override bool infosMatch(int i0, int i1)
		{
			return i0 == i1;
		}
	}
	public class ImageBufferNativePool<T> : ObjectPool<T, ImageBufferInfo> where T : ImageBufferNative
	{
		public delegate T Factory(ImageBufferNativePool<T> pool, ImageBufferInfo info);

		private Factory factory;

		public ImageBufferNativePool(int capacity, Factory factory, string name)
			: base(capacity, name)
		{
			this.factory = factory;
		}

		public ImageBufferNativePool(int capacity, Factory factory, string name, ImageBufferInfo info)
			: base(capacity, name, info)
		{
			this.factory = factory;
		}

		protected override T createObject(ImageBufferInfo info)
		{
			return factory(this, info);
		}

		protected override void destroyObject(T obj)
		{
			obj.Dispose();
		}

		protected override bool infosMatch(ImageBufferInfo i0, ImageBufferInfo i1)
		{
			if (i0 == null)
			{
				return i1 == null;
			}
			if (i1 == null)
			{
				return i0 == null;
			}
			if (i0.Height != i1.Height)
			{
				return false;
			}
			int[] stride = i0.Stride;
			int[] stride2 = i1.Stride;
			if (stride.Length != stride2.Length)
			{
				return false;
			}
			switch (i0.Stride.Length)
			{
			case 1:
				return stride[0] == stride2[0];
			case 2:
				if (stride[0] == stride2[0])
				{
					return stride[1] == stride2[1];
				}
				return false;
			case 3:
				if (stride[0] == stride2[0] && stride[1] == stride2[1])
				{
					return stride[2] == stride2[2];
				}
				return false;
			default:
			{
				for (int j = 0; j < stride.Length; j++)
				{
					if (stride[j] != stride2[j])
					{
						return false;
					}
				}
				return true;
			}
			}
		}
	}
	public class OpusCodec
	{
		public enum FrameDuration
		{
			Frame2dot5ms = 2500,
			Frame5ms = 5000,
			Frame10ms = 10000,
			Frame20ms = 20000,
			Frame40ms = 40000,
			Frame60ms = 60000
		}

		public static class EncoderFactory
		{
			public static IEncoder Create(VoiceInfo i, LocalVoice localVoice)
			{
				if (localVoice.GetType() == typeof(LocalVoiceAudioFloat))
				{
					return new EncoderFloat(i);
				}
				if (localVoice.GetType() == typeof(LocalVoiceAudioShort))
				{
					return new EncoderShort(i);
				}
				throw new UnsupportedCodecException(i.Codec, localVoice);
			}
		}

		public abstract class Encoder<T> : IEncoderDataFlowDirect<T>, IEncoderDataFlow<T>, IEncoder, IDisposable
		{
			protected OpusEncoder encoder;

			protected bool disposed;

			protected Encoder(VoiceInfo i)
			{
				encoder = new OpusEncoder((SamplingRate)i.SamplingRate, (Channels)i.Channels, i.Bitrate, OpusApplicationType.Voip, (Delay)(i.FrameDurationUs * 2 / 1000));
			}

			public void Dispose()
			{
				lock (this)
				{
					encoder.Dispose();
					disposed = true;
				}
			}

			public abstract ArraySegment<byte> EncodeAndGetOutput(T[] buf);
		}

		public class EncoderFloat : Encoder<float>
		{
			private static readonly ArraySegment<byte> EmptyBuffer = new ArraySegment<byte>(new byte[0]);

			internal EncoderFloat(VoiceInfo i)
				: base(i)
			{
			}

			public override ArraySegment<byte> EncodeAndGetOutput(float[] buf)
			{
				lock (this)
				{
					if (disposed)
					{
						return EmptyBuffer;
					}
					return encoder.Encode(buf);
				}
			}
		}

		public class EncoderShort : Encoder<short>
		{
			private static readonly ArraySegment<byte> EmptyBuffer = new ArraySegment<byte>(new byte[0]);

			internal EncoderShort(VoiceInfo i)
				: base(i)
			{
			}

			public override ArraySegment<byte> EncodeAndGetOutput(short[] buf)
			{
				lock (this)
				{
					if (disposed)
					{
						return EmptyBuffer;
					}
					return encoder.Encode(buf);
				}
			}
		}

		public class Decoder : IDecoderDirect, IDecoder, IDisposable
		{
			private OpusDecoder decoder;

			public void Open(VoiceInfo i)
			{
				decoder = new OpusDecoder((SamplingRate)i.SamplingRate, (Channels)i.Channels);
			}

			public byte[] DecodeToByte(byte[] buf)
			{
				throw new NotImplementedException();
			}

			public float[] DecodeToFloat(byte[] buf)
			{
				return decoder.DecodePacketFloat(buf);
			}

			public short[] DecodeToShort(byte[] buf)
			{
				return decoder.DecodePacketShort(buf);
			}

			public void Dispose()
			{
				decoder.Dispose();
			}
		}

		public class Util
		{
			internal static int bestEncoderSampleRate(int f)
			{
				int num = int.MaxValue;
				int result = 48000;
				foreach (object value in Enum.GetValues(typeof(SamplingRate)))
				{
					int num2 = Math.Abs((int)value - f);
					if (num2 < num)
					{
						num = num2;
						result = (int)value;
					}
				}
				return result;
			}
		}
	}
	public class SpeexProcessor : SpeexLib, LocalVoiceFramed<short>.IProcessor, IDisposable
	{
		public struct AECLatencyResultType
		{
			public int LatencyMs;

			public int LatencyDelayedMs;

			public bool PlayDetected;

			public bool PlayDelayedDetected;

			public bool RecDetected;
		}

		private bool _AEC;

		private int _AECPlaybackDelayMs;

		private bool _AECLatencyDetect;

		private int frameSamples;

		private int samplingRate;

		private int channels;

		private int playDelayFrames;

		private int playDelayMaxFrames;

		private IntPtr stEcho;

		private IntPtr st;

		private bool disposed;

		private short[] resultBuf;

		private PrimitiveArrayPool<short> playbackBufPool;

		private Queue<short[]> playBufQueue = new Queue<short[]>();

		private Framer<float> playFramer;

		private int playSamplingRate;

		private int playChannels;

		private ILogger logger;

		private Func<long> clockMs;

		private AudioUtil.VoiceLevelDetectCalibrate<float> detectPlay;

		private AudioUtil.VoiceLevelDetectCalibrate<short> detectPlayCorr;

		private AudioUtil.VoiceLevelDetectCalibrate<short> detectRec;

		private long detectTimePlay;

		private long detectTimePlayDelayed;

		private long detectTimeRec;

		private int frameCntRec;

		private int frameCntPlay;

		public bool AEC
		{
			get
			{
				return _AEC;
			}
			set
			{
				if (_AEC != value)
				{
					_AEC = value;
					playBufQueue.Clear();
				}
			}
		}

		public int AECFilterLengthMs { get; set; }

		public int AECPlaybackDelayMs
		{
			get
			{
				return _AECPlaybackDelayMs;
			}
			set
			{
				if (_AECPlaybackDelayMs != value)
				{
					_AECPlaybackDelayMs = value;
					InitPlayDelay(value);
				}
			}
		}

		public int AECurrentPlayDelayFrames => playBufQueue.Count;

		public bool AECLatencyDetect
		{
			get
			{
				return _AECLatencyDetect;
			}
			set
			{
				if (_AECLatencyDetect != value)
				{
					_AECLatencyDetect = value;
					if (detectPlay == null)
					{
						InitLatencyDetect();
					}
				}
			}
		}

		public AECLatencyResultType AECLatencyResult
		{
			get
			{
				AECLatencyResultType result = default(AECLatencyResultType);
				result.LatencyMs = (int)(detectTimeRec - detectTimePlay);
				result.LatencyDelayedMs = (int)(detectTimeRec - detectTimePlayDelayed);
				result.PlayDetected = detectPlay != null && detectPlay.Detector.Detected;
				result.PlayDelayedDetected = detectPlayCorr != null && detectPlayCorr.Detector.Detected;
				result.RecDetected = detectRec != null && detectRec.Detector.Detected;
				return result;
			}
		}

		public bool Denoise
		{
			get
			{
				return getBool(1);
			}
			set
			{
				set(0, value);
			}
		}

		public bool AGC
		{
			get
			{
				return getBool(3);
			}
			set
			{
				set(2, value);
			}
		}

		public float AGCLevel
		{
			get
			{
				return getFloat(7);
			}
			set
			{
				set(6, value);
			}
		}

		public void ResetAEC()
		{
			lock (this)
			{
				DestroyEchoState();
			}
		}

		public void AECLatecnyDetectCaliberate()
		{
			detectPlayCorr.Calibrate(2000);
			detectPlay.Calibrate(2000);
			detectRec.Calibrate(2000);
		}

		private void set(int param, bool val)
		{
			int value = (val ? 1 : 0);
			SpeexLib.speex_preprocess_ctl(st, param, ref value);
		}

		private void set(int param, float val)
		{
			SpeexLib.speex_preprocess_ctl(st, param, ref val);
		}

		private bool getBool(int param)
		{
			int value = 0;
			SpeexLib.speex_preprocess_ctl(st, param, ref value);
			return value != 0;
		}

		private float getFloat(int param)
		{
			float value = 0f;
			SpeexLib.speex_preprocess_ctl(st, param, ref value);
			return value;
		}

		public SpeexProcessor(ILogger logger, Func<long> clockMs, int frameSize, int samplingRate, int channels, int playSamplingRate, int playChannels, int playBufSize)
		{
			this.clockMs = ((clockMs == null) ? ((Func<long>)(() => DateTime.Now.Millisecond)) : clockMs);
			this.logger = logger;
			frameSamples = frameSize / channels;
			this.samplingRate = samplingRate;
			this.channels = channels;
			this.playSamplingRate = playSamplingRate;
			this.playChannels = playChannels;
			resultBuf = new short[frameSize];
			st = SpeexLib.speex_preprocess_state_init(frameSamples, samplingRate);
			logger.LogInfo("SpeexProcessor state: create sampling rate {0}, frame samples {1}", samplingRate, frameSamples);
		}

		private void InitLatencyDetect()
		{
			detectPlay = new AudioUtil.VoiceLevelDetectCalibrate<float>(playSamplingRate, playChannels);
			detectPlayCorr = new AudioUtil.VoiceLevelDetectCalibrate<short>(playSamplingRate, playChannels);
			detectRec = new AudioUtil.VoiceLevelDetectCalibrate<short>(samplingRate, channels);
			detectPlay.Detector.OnDetected += delegate
			{
				detectTimePlay = clockMs();
			};
			detectPlayCorr.Detector.OnDetected += delegate
			{
				detectTimePlayDelayed = clockMs();
			};
			detectRec.Detector.OnDetected += delegate
			{
				detectTimeRec = clockMs();
			};
		}

		public void InitAEC()
		{
			lock (this)
			{
				if (!disposed)
				{
					playFramer = new Framer<float>(frameSamples * playSamplingRate / samplingRate * playChannels);
					InitPlayDelay(AECPlaybackDelayMs);
					int num = samplingRate * AECFilterLengthMs / 1000;
					DestroyEchoState();
					stEcho = SpeexLib.speex_echo_state_init_mc(frameSamples, num, channels, playChannels);
					SpeexLib.speex_echo_ctl(stEcho, 24, ref samplingRate);
					SpeexLib.speex_preprocess_ctl(st, 24, stEcho);
					logger.LogInfo("SpeexProcessor AEC: create sampling rate {0}, frame samples {1}, filter length {2}ms={3}frames, mic channels {4}, out channels {5}, playback delay {6}ms={7}:{8}frames", samplingRate, frameSamples, AECFilterLengthMs, num, channels, playChannels, AECPlaybackDelayMs, playDelayFrames, playDelayMaxFrames);
					logger.LogInfo("SpeexProcessor AEC: output sampling rate {0}", playSamplingRate);
					if (playSamplingRate != samplingRate)
					{
						logger.LogWarning("SpeexProcessor AEC: output sampling rate {0} != {1} capture sampling rate. For better AEC, set audio source (microphone) and audio output samping rates to the same value.", playSamplingRate, samplingRate);
					}
				}
			}
		}

		private void InitPlayDelay(int ms)
		{
			playDelayFrames = ms * samplingRate / frameSamples / 1000;
			playDelayMaxFrames = playDelayFrames * 3;
			playbackBufPool = new PrimitiveArrayPool<short>(playDelayMaxFrames, "Speex playback pool", frameSamples * playChannels);
		}

		public short[] Process(short[] buf)
		{
			if (disposed)
			{
				return buf;
			}
			if (_AECLatencyDetect)
			{
				detectRec.Process(buf);
			}
			if (AEC)
			{
				if (stEcho == IntPtr.Zero)
				{
					InitAEC();
				}
				lock (playBufQueue)
				{
					frameCntRec++;
					if (playBufQueue.Count > playDelayFrames)
					{
						short[] array = playBufQueue.Dequeue();
						SpeexLib.speex_echo_cancellation(stEcho, buf, array, resultBuf);
						if (_AECLatencyDetect)
						{
							detectPlayCorr.Process(array);
						}
						playbackBufPool.Release(array);
						buf = resultBuf;
					}
					else
					{
						logger.LogWarning("SpeexProcessor AEC: playbackBufQueue underrun: {0}", playBufQueue.Count);
					}
				}
			}
			SpeexLib.speex_preprocess_run(st, buf);
			return buf;
		}

		public void OnAudioOutFrame(float[] data, int outChannels)
		{
			if (disposed)
			{
				return;
			}
			lock (this)
			{
				if (stEcho == IntPtr.Zero)
				{
					return;
				}
			}
			if (outChannels != playChannels)
			{
				logger.LogError("SpeexProcessor AEC: OnAudioOutFrame channel count {0} != {1} AudioSettings.speakerMode channel count.", outChannels, playChannels);
				return;
			}
			if (_AECLatencyDetect)
			{
				detectPlay.Process(data);
			}
			foreach (float[] item in playFramer.Frame(data))
			{
				lock (playBufQueue)
				{
					if (playBufQueue.Count > playDelayMaxFrames)
					{
						logger.LogWarning("SpeexProcessor AEC: playbackBufQueue overrun: {0}", playBufQueue.Count);
						while (playBufQueue.Count > playDelayMaxFrames)
						{
							playbackBufPool.Release(playBufQueue.Dequeue());
						}
					}
				}
				short[] array = playbackBufPool.AcquireOrCreate();
				if (item.Length != array.Length)
				{
					AudioUtil.ResampleAndConvert(item, array, array.Length, outChannels);
				}
				else
				{
					AudioUtil.Convert(item, array, array.Length);
				}
				lock (playBufQueue)
				{
					playBufQueue.Enqueue(array);
					frameCntPlay++;
				}
			}
		}

		public void PrintInfo()
		{
		}

		private void DestroyEchoState()
		{
			if (stEcho != IntPtr.Zero)
			{
				SpeexLib.speex_preprocess_ctl(st, 24, IntPtr.Zero);
				SpeexLib.speex_echo_state_destroy(stEcho);
				stEcho = IntPtr.Zero;
			}
		}

		public void Dispose()
		{
			lock (this)
			{
				if (!disposed)
				{
					disposed = true;
					if (st != IntPtr.Zero)
					{
						SpeexLib.speex_preprocess_state_destroy(st);
					}
					DestroyEchoState();
				}
			}
		}
	}
	public class SpeexLib
	{
		private const string lib_name = "libspeexdsp";

		public const int SPEEX_PREPROCESS_SET_DENOISE = 0;

		public const int SPEEX_PREPROCESS_GET_DENOISE = 1;

		public const int SPEEX_PREPROCESS_SET_AGC = 2;

		public const int SPEEX_PREPROCESS_GET_AGC = 3;

		public const int SPEEX_PREPROCESS_SET_VAD = 4;

		public const int SPEEX_PREPROCESS_GET_VAD = 5;

		public const int SPEEX_PREPROCESS_SET_AGC_LEVEL = 6;

		public const int SPEEX_PREPROCESS_GET_AGC_LEVEL = 7;

		public const int SPEEX_PREPROCESS_SET_DEREVERB = 8;

		public const int SPEEX_PREPROCESS_GET_DEREVERB = 9;

		public const int SPEEX_PREPROCESS_SET_DEREVERB_LEVEL = 10;

		public const int SPEEX_PREPROCESS_GET_DEREVERB_LEVEL = 11;

		public const int SPEEX_PREPROCESS_SET_DEREVERB_DECAY = 12;

		public const int SPEEX_PREPROCESS_GET_DEREVERB_DECAY = 13;

		public const int SPEEX_PREPROCESS_SET_PROB_START = 14;

		public const int SPEEX_PREPROCESS_GET_PROB_START = 15;

		public const int SPEEX_PREPROCESS_SET_PROB_CONTINUE = 16;

		public const int SPEEX_PREPROCESS_GET_PROB_CONTINUE = 17;

		public const int SPEEX_PREPROCESS_SET_NOISE_SUPPRESS = 18;

		public const int SPEEX_PREPROCESS_GET_NOISE_SUPPRESS = 19;

		public const int SPEEX_PREPROCESS_SET_ECHO_SUPPRESS = 20;

		public const int SPEEX_PREPROCESS_GET_ECHO_SUPPRESS = 21;

		public const int SPEEX_PREPROCESS_SET_ECHO_SUPPRESS_ACTIVE = 22;

		public const int SPEEX_PREPROCESS_GET_ECHO_SUPPRESS_ACTIVE = 23;

		public const int SPEEX_PREPROCESS_SET_ECHO_STATE = 24;

		public const int SPEEX_PREPROCESS_GET_ECHO_STATE = 25;

		public const int SPEEX_PREPROCESS_SET_AGC_INCREMENT = 26;

		public const int SPEEX_PREPROCESS_GET_AGC_INCREMENT = 27;

		public const int SPEEX_PREPROCESS_SET_AGC_DECREMENT = 28;

		public const int SPEEX_PREPROCESS_GET_AGC_DECREMENT = 29;

		public const int SPEEX_PREPROCESS_SET_AGC_MAX_GAIN = 30;

		public const int SPEEX_PREPROCESS_GET_AGC_MAX_GAIN = 31;

		public const int SPEEX_PREPROCESS_GET_AGC_LOUDNESS = 33;

		public const int SPEEX_PREPROCESS_GET_AGC_GAIN = 35;

		public const int SPEEX_PREPROCESS_GET_PSD_SIZE = 37;

		public const int SPEEX_PREPROCESS_GET_PSD = 39;

		public const int SPEEX_PREPROCESS_GET_NOISE_PSD_SIZE = 41;

		public const int SPEEX_PREPROCESS_GET_NOISE_PSD = 43;

		public const int SPEEX_PREPROCESS_GET_PROB = 45;

		public const int SPEEX_PREPROCESS_SET_AGC_TARGET = 46;

		public const int SPEEX_PREPROCESS_GET_AGC_TARGET = 47;

		public const int SPEEX_ECHO_GET_FRAME_SIZE = 3;

		public const int SPEEX_ECHO_SET_SAMPLING_RATE = 24;

		public const int SPEEX_ECHO_GET_SAMPLING_RATE = 25;

		public const int SPEEX_ECHO_GET_IMPULSE_RESPONSE_SIZE = 27;

		public const int SPEEX_ECHO_GET_IMPULSE_RESPONSE = 29;

		[DllImport("libspeexdsp", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern IntPtr speex_preprocess_state_init(int frame_size, int sampling_rate);

		[DllImport("libspeexdsp", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern void speex_preprocess_state_destroy(IntPtr st);

		[DllImport("libspeexdsp", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int speex_preprocess_run(IntPtr st, short[] x);

		[DllImport("libspeexdsp", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int speex_preprocess_ctl(IntPtr st, int request, IntPtr ptr);

		public static int speex_preprocess_ctl(IntPtr st, int request, ref int value)
		{
			IntPtr intPtr = Marshal.AllocCoTaskMem(4);
			int[] array = new int[1] { value };
			Marshal.Copy(array, 0, intPtr, 1);
			int result = speex_preprocess_ctl(st, request, intPtr);
			Marshal.Copy(intPtr, array, 0, 1);
			value = array[0];
			Marshal.FreeCoTaskMem(intPtr);
			return result;
		}

		public static int speex_preprocess_ctl(IntPtr st, int request, ref float value)
		{
			IntPtr intPtr = Marshal.AllocCoTaskMem(4);
			float[] array = new float[1] { value };
			Marshal.Copy(array, 0, intPtr, 1);
			int result = speex_preprocess_ctl(st, request, intPtr);
			Marshal.Copy(intPtr, array, 0, 1);
			Marshal.FreeCoTaskMem(intPtr);
			return result;
		}

		[DllImport("libspeexdsp", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern IntPtr speex_echo_state_init(int frame_size, int filter_length);

		[DllImport("libspeexdsp", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern IntPtr speex_echo_state_init_mc(int frame_size, int filter_length, int nb_mic, int nb_speakers);

		[DllImport("libspeexdsp", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern void speex_echo_state_destroy(IntPtr st);

		[DllImport("libspeexdsp", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern void speex_echo_cancellation(IntPtr st, short[] rec, short[] play, short[] outBuf);

		[DllImport("libspeexdsp", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern void speex_echo_capture(IntPtr st, short[] rec, short[] outBuf);

		[DllImport("libspeexdsp", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern void speex_echo_playback(IntPtr st, short[] play);

		[DllImport("libspeexdsp", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern void speex_echo_state_reset(IntPtr st);

		[DllImport("libspeexdsp", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int speex_echo_ctl(IntPtr st, int request, IntPtr ptr);

		public static int speex_echo_ctl(IntPtr st, int request, ref int value)
		{
			IntPtr intPtr = Marshal.AllocCoTaskMem(4);
			int[] array = new int[1] { value };
			Marshal.Copy(array, 0, intPtr, 1);
			int result = speex_echo_ctl(st, request, intPtr);
			Marshal.Copy(intPtr, array, 0, 1);
			value = array[0];
			Marshal.FreeCoTaskMem(intPtr);
			return result;
		}

		public static int speex_echo_ctl(IntPtr st, int request, ref float value)
		{
			IntPtr intPtr = Marshal.AllocCoTaskMem(4);
			float[] array = new float[1] { value };
			Marshal.Copy(array, 0, intPtr, 1);
			int result = speex_echo_ctl(st, request, intPtr);
			Marshal.Copy(intPtr, array, 0, 1);
			value = array[0];
			Marshal.FreeCoTaskMem(intPtr);
			return result;
		}
	}
	public interface IDataReader<T> : IDisposable
	{
		bool Read(T[] buffer);
	}
	public interface IServiceable
	{
		void Service(LocalVoice localVoice);
	}
	public class LocalVoice : IDisposable
	{
		public const int DATA_POOL_CAPACITY = 50;

		private bool debugEchoMode;

		internal VoiceInfo info;

		protected IEncoder encoder;

		internal byte id;

		internal int channelId;

		internal byte evNumber;

		protected VoiceClient voiceClient;

		protected volatile bool disposed;

		protected object disposeLock = new object();

		private int noTransmitCnt;

		internal Dictionary<byte, int> eventTimestamps = new Dictionary<byte, int>();

		public byte Group { get; set; }

		public VoiceInfo Info => info;

		public bool Transmit { get; set; }

		public bool IsTransmitting { get; protected set; }

		public int FramesSent { get; private set; }

		public int FramesSentBytes { get; private set; }

		public bool Reliable { get; set; }

		public bool Encrypt { get; set; }

		public object LocalUserObject { get; set; }

		public IServiceable LocalUserServiceable { get; set; }

		public bool DebugEchoMode
		{
			get
			{
				return debugEchoMode;
			}
			set
			{
				if (debugEchoMode != value)
				{
					debugEchoMode = value;
					if (voiceClient != null && voiceClient.frontend != null)
					{
						voiceClient.frontend.SetDebugEchoMode(this);
					}
				}
			}
		}

		internal string Name => "Local v#" + id + " ch#" + voiceClient.channelStr(channelId);

		internal string LogPrefix => "[PV] " + Name;

		internal LocalVoice()
		{
		}

		internal LocalVoice(VoiceClient voiceClient, IEncoder encoder, byte id, VoiceInfo voiceInfo, int channelId)
		{
			this.encoder = encoder;
			Transmit = true;
			info = voiceInfo;
			this.channelId = channelId;
			this.voiceClient = voiceClient;
			this.id = id;
		}

		protected void resetNoTransmitCnt()
		{
			noTransmitCnt = 10;
		}

		internal virtual void service()
		{
			if (voiceClient.frontend.IsChannelJoined(channelId) && Transmit && encoder is IEncoderQueued)
			{
				foreach (ArraySegment<byte> item in ((IEncoderQueued)encoder).GetOutput())
				{
					sendFrame(item);
				}
			}
			if (noTransmitCnt == 0)
			{
				IsTransmitting = false;
			}
			else
			{
				IsTransmitting = true;
				noTransmitCnt--;
			}
			if (LocalUserServiceable != null)
			{
				LocalUserServiceable.Service(this);
			}
		}

		internal void sendFrame(ArraySegment<byte> compressed)
		{
			FramesSent++;
			FramesSentBytes += compressed.Count;
			voiceClient.frontend.SendFrame(compressed, evNumber, id, channelId, this);
			eventTimestamps[evNumber] = Environment.TickCount;
			evNumber++;
			resetNoTransmitCnt();
		}

		public void RemoveSelf()
		{
			voiceClient.RemoveLocalVoice(this);
		}

		public virtual void Dispose()
		{
			if (!disposed)
			{
				if (encoder != null)
				{
					encoder.Dispose();
				}
				disposed = true;
			}
		}
	}
	public struct RemoteVoiceOptions
	{
		public Action<byte[]> OnDecodedFrameByteAction { get; set; }

		public Action<float[]> OnDecodedFrameFloatAction { get; set; }

		public Action<short[]> OnDecodedFrameShortAction { get; set; }

		public Action OnRemoteVoiceRemoveAction { get; set; }

		public object LocalUserObject { get; set; }

		public IDecoder Decoder { get; set; }
	}
	internal class RemoteVoice : IDisposable
	{
		internal RemoteVoiceOptions options;

		private int channelId;

		private int playerId;

		private byte voiceId;

		private volatile bool disposed;

		private object disposeLock = new object();

		internal byte lastEvNumber;

		private VoiceClient voiceClient;

		private Queue<byte[]> frameQueue = new Queue<byte[]>();

		private AutoResetEvent frameQueueReady = new AutoResetEvent(initialState: false);

		internal VoiceInfo Info { get; private set; }

		protected string Name => "Remote v#" + voiceId + " ch#" + voiceClient.channelStr(channelId) + " p#" + playerId;

		protected string LogPrefix => "[PV] " + Name;

		internal RemoteVoice(VoiceClient client, RemoteVoiceOptions options, int channelId, int playerId, byte voiceId, VoiceInfo info, byte lastEventNumber)
		{
			this.options = options;
			voiceClient = client;
			this.channelId = channelId;
			this.playerId = playerId;
			this.voiceId = voiceId;
			Info = info;
			lastEvNumber = lastEventNumber;
			if (this.options.Decoder == null)
			{
				voiceClient.frontend.LogError(LogPrefix + ": decoder is null");
				disposed = true;
				return;
			}
			Thread thread = new Thread((ThreadStart)delegate
			{
				decodeThread(this.options.Decoder);
			});
			thread.Name = LogPrefix + " decode";
			thread.Start();
		}

		private static byte byteDiff(byte latest, byte last)
		{
			return (byte)(latest - (last + 1));
		}

		internal void receiveBytes(byte[] receivedBytes, byte evNumber)
		{
			if (evNumber != lastEvNumber)
			{
				int num = byteDiff(evNumber, lastEvNumber);
				if (num != 0)
				{
					voiceClient.frontend.LogDebug(LogPrefix + " evNumer: " + evNumber + " playerVoice.lastEvNumber: " + lastEvNumber + " missing: " + num + " r/b " + receivedBytes.Length);
				}
				lastEvNumber = evNumber;
				receiveNullFrames(num);
				voiceClient.FramesLost += num;
			}
			receiveFrame(receivedBytes);
		}

		private void receiveFrame(byte[] frame)
		{
			lock (disposeLock)
			{
				if (!disposed)
				{
					lock (frameQueue)
					{
						frameQueue.Enqueue(frame);
					}
					frameQueueReady.Set();
				}
			}
		}

		private void receiveNullFrames(int count)
		{
			lock (disposeLock)
			{
				if (disposed)
				{
					return;
				}
				lock (frameQueue)
				{
					for (int i = 0; i < count; i++)
					{
						frameQueue.Enqueue(null);
					}
				}
				frameQueueReady.Set();
			}
		}

		private void decodeThread(IDecoder decoder)
		{
			voiceClient.frontend.LogInfo(LogPrefix + ": Starting decode thread");
			try
			{
				decoder.Open(Info);
				while (!disposed)
				{
					frameQueueReady.WaitOne();
					while (!disposed)
					{
						byte[] frame = null;
						bool flag = false;
						lock (frameQueue)
						{
							if (frameQueue.Count > 0)
							{
								flag = true;
								frame = frameQueue.Dequeue();
							}
						}
						if (!flag)
						{
							break;
						}
						decodeFrame(decoder, frame);
					}
				}
			}
			catch (Exception ex)
			{
				voiceClient.frontend.LogError(LogPrefix + ": Exception in decode thread: " + ex);
				throw ex;
			}
			finally
			{
				lock (disposeLock)
				{
					disposed = true;
				}
				frameQueueReady.Close();
				lock (frameQueue)
				{
					frameQueue.Clear();
				}
				decoder.Dispose();
				voiceClient.frontend.LogInfo(LogPrefix + ": Exiting decode thread");
			}
		}

		private void decodeFrame(IDecoder decoder, byte[] frame)
		{
			if (decoder is IDecoderDirect)
			{
				if (options.OnDecodedFrameByteAction != null)
				{
					byte[] obj = decodeFrameToByte(frame);
					options.OnDecodedFrameByteAction(obj);
				}
				if (options.OnDecodedFrameShortAction != null)
				{
					short[] obj2 = decodeFrameToShort(frame);
					options.OnDecodedFrameShortAction(obj2);
				}
				if (options.OnDecodedFrameFloatAction != null)
				{
					float[] obj3 = decodeFrameToFloat(frame);
					options.OnDecodedFrameFloatAction(obj3);
				}
			}
			else
			{
				((IDecoderQueued)decoder).Decode(frame);
			}
		}

		internal byte[] decodeFrameToByte(byte[] buffer)
		{
			byte[] array;
			if (buffer == null)
			{
				array = ((IDecoderDirect)options.Decoder).DecodeToByte(null);
				voiceClient.frontend.LogDebug(LogPrefix + " lost packet decoded length: " + array.Length);
			}
			else
			{
				array = ((IDecoderDirect)options.Decoder).DecodeToByte(buffer);
			}
			return array;
		}

		internal short[] decodeFrameToShort(byte[] buffer)
		{
			short[] array;
			if (buffer == null)
			{
				array = ((IDecoderDirect)options.Decoder).DecodeToShort(null);
				voiceClient.frontend.LogDebug(LogPrefix + " lost packet decoded length: " + array.Length);
			}
			else
			{
				array = ((IDecoderDirect)options.Decoder).DecodeToShort(buffer);
			}
			return array;
		}

		internal float[] decodeFrameToFloat(byte[] buffer)
		{
			float[] array;
			if (buffer == null)
			{
				array = ((IDecoderDirect)options.Decoder).DecodeToFloat(null);
				voiceClient.frontend.LogDebug(LogPrefix + " lost packet decoded length: " + array.Length);
			}
			else
			{
				array = ((IDecoderDirect)options.Decoder).DecodeToFloat(buffer);
			}
			return array;
		}

		internal void removeAndDispose()
		{
			if (options.OnRemoteVoiceRemoveAction != null)
			{
				options.OnRemoteVoiceRemoveAction();
			}
			Dispose();
		}

		public void Dispose()
		{
			lock (disposeLock)
			{
				if (!disposed)
				{
					disposed = true;
					frameQueueReady.Set();
				}
			}
		}
	}
	public interface IAudioSource : IDisposable
	{
		int SamplingRate { get; }

		int Channels { get; }
	}
	public interface IAudioReader<T> : IDataReader<T>, IDisposable, IAudioSource
	{
	}
	public interface IAudioPusher<T> : IAudioSource, IDisposable
	{
		void SetCallback(Action<T[]> callback, LocalVoice localVoice);
	}
	public interface ILocalVoiceAudio
	{
		AudioUtil.IVoiceDetector VoiceDetector { get; }

		AudioUtil.ILevelMeter LevelMeter { get; }

		bool VoiceDetectorCalibrating { get; }

		void VoiceDetectorCalibrate(int durationMs);
	}
	public static class LocalVoiceAudio
	{
		public static LocalVoiceAudioDummy Dummy = new LocalVoiceAudioDummy();

		public static LocalVoiceAudio<T> Create<T>(VoiceClient voiceClient, byte voiceId, IEncoder encoder, VoiceInfo voiceInfo, int channelId)
		{
			if (typeof(T) == typeof(float))
			{
				if (encoder == null || encoder is IEncoderDataFlow<float>)
				{
					return new LocalVoiceAudioFloat(voiceClient, encoder as IEncoderDataFlow<float>, voiceId, voiceInfo, channelId) as LocalVoiceAudio<T>;
				}
				throw new Exception("[PV] CreateLocalVoice: encoder for IFrameStream<float> is not IBufferEncoder<float>: " + encoder.GetType());
			}
			if (typeof(T) == typeof(short))
			{
				if (encoder == null || encoder is IEncoderDataFlow<short>)
				{
					return new LocalVoiceAudioShort(voiceClient, encoder as IEncoderDataFlow<short>, voiceId, voiceInfo, channelId) as LocalVoiceAudio<T>;
				}
				throw new Exception("[PV] CreateLocalVoice: encoder for IFrameStream<short> is not IBufferEncoder<short>: " + encoder.GetType());
			}
			throw new UnsupportedSampleTypeException(typeof(T));
		}
	}
	public abstract class LocalVoiceAudio<T> : LocalVoiceFramed<T>, ILocalVoiceAudio
	{
		protected AudioUtil.VoiceDetector<T> voiceDetector;

		protected AudioUtil.VoiceDetectorCalibration<T> voiceDetectorCalibration;

		protected AudioUtil.LevelMeter<T> levelMeter;

		protected int channels;

		protected int sourceSamplingRateHz;

		protected bool resampleSource;

		public virtual AudioUtil.IVoiceDetector VoiceDetector => voiceDetector;

		public virtual AudioUtil.ILevelMeter LevelMeter => levelMeter;

		public bool VoiceDetectorCalibrating => voiceDetectorCalibration.VoiceDetectorCalibrating;

		public void VoiceDetectorCalibrate(int durationMs)
		{
			voiceDetectorCalibration.VoiceDetectorCalibrate(durationMs);
		}

		internal LocalVoiceAudio(VoiceClient voiceClient, IEncoderDataFlow<T> encoder, byte id, VoiceInfo voiceInfo, int channelId)
			: base(voiceClient, (IEncoder)encoder, id, voiceInfo, channelId, (voiceInfo.SamplingRate != 0) ? (voiceInfo.FrameSize * voiceInfo.SourceSamplingRate / voiceInfo.SamplingRate) : voiceInfo.FrameSize)
		{
			if (base.encoder == null)
			{
				base.encoder = VoiceCodec.CreateDefaultEncoder(voiceInfo, this);
			}
			channels = voiceInfo.Channels;
			sourceSamplingRateHz = voiceInfo.SourceSamplingRate;
			if (sourceSamplingRateHz != voiceInfo.SamplingRate)
			{
				resampleSource = true;
				base.voiceClient.frontend.LogWarning("[PV] Local voice #" + base.id + " audio source frequency " + sourceSamplingRateHz + " and encoder sampling rate " + voiceInfo.SamplingRate + " do not match. Resampling will occur before encoding.");
			}
		}

		protected void initBuiltinProcessors()
		{
			if (resampleSource)
			{
				AddPostProcessor(new AudioUtil.Resampler<T>(info.FrameSize, channels));
			}
			voiceDetectorCalibration = new AudioUtil.VoiceDetectorCalibration<T>(voiceDetector, levelMeter, info.SamplingRate, channels);
			AddPostProcessor(levelMeter, voiceDetectorCalibration, voiceDetector);
		}
	}
	public class LocalVoiceAudioDummy : LocalVoice, ILocalVoiceAudio
	{
		private AudioUtil.VoiceDetectorDummy voiceDetector;

		private AudioUtil.LevelMetterDummy levelMeter;

		public AudioUtil.IVoiceDetector VoiceDetector => voiceDetector;

		public AudioUtil.ILevelMeter LevelMeter => levelMeter;

		public bool VoiceDetectorCalibrating => false;

		public void VoiceDetectorCalibrate(int durationMs)
		{
		}

		public LocalVoiceAudioDummy()
		{
			voiceDetector = new AudioUtil.VoiceDetectorDummy();
			levelMeter = new AudioUtil.LevelMetterDummy();
		}
	}
	public class LocalVoiceAudioFloat : LocalVoiceAudio<float>
	{
		internal LocalVoiceAudioFloat(VoiceClient voiceClient, IEncoderDataFlow<float> encoder, byte id, VoiceInfo voiceInfo, int channelId)
			: base(voiceClient, encoder, id, voiceInfo, channelId)
		{
			levelMeter = new AudioUtil.LevelMeterFloat(info.SamplingRate, info.Channels);
			voiceDetector = new AudioUtil.VoiceDetectorFloat(info.SamplingRate, info.Channels);
			initBuiltinProcessors();
		}
	}
	public class LocalVoiceAudioShort : LocalVoiceAudio<short>
	{
		internal LocalVoiceAudioShort(VoiceClient voiceClient, IEncoderDataFlow<short> encoder, byte id, VoiceInfo voiceInfo, int channelId)
			: base(voiceClient, encoder, id, voiceInfo, channelId)
		{
			levelMeter = new AudioUtil.LevelMeterShort(info.SamplingRate, info.Channels);
			voiceDetector = new AudioUtil.VoiceDetectorShort(info.SamplingRate, info.Channels);
			initBuiltinProcessors();
		}
	}
	internal enum EventSubcode : byte
	{
		VoiceInfo = 1,
		VoiceRemove,
		Frame
	}
	internal enum EventParam : byte
	{
		VoiceId = 1,
		SamplingRate = 2,
		Channels = 3,
		FrameDurationUs = 4,
		Bitrate = 5,
		UserData = 10,
		EventNumber = 11,
		Codec = 12
	}
	public interface ILogger
	{
		void LogError(string fmt, params object[] args);

		void LogWarning(string fmt, params object[] args);

		void LogInfo(string fmt, params object[] args);

		void LogDebug(string fmt, params object[] args);
	}
	internal interface IVoiceFrontend : ILogger
	{
		int AssignChannel(VoiceInfo v);

		bool IsChannelJoined(int channelId);

		void SendVoicesInfo(IEnumerable<LocalVoice> voices, int channelId, int targetPlayerId);

		void SendVoiceRemove(LocalVoice voice, int channelId, int targetPlayerId);

		void SendFrame(ArraySegment<byte> data, byte evNumber, byte voiceId, int channelId, LocalVoice localVoice);

		string ChannelIdStr(int channelId);

		string PlayerIdStr(int playerId);

		void SetDebugEchoMode(LocalVoice v);
	}
	public class VoiceClient : IDisposable
	{
		public delegate void RemoteVoiceInfoDelegate(int channelId, int playerId, byte voiceId, VoiceInfo voiceInfo, ref RemoteVoiceOptions options);

		internal IVoiceFrontend frontend;

		private int prevRtt;

		public const int ChannelAuto = -1;

		private byte globalGroup;

		private byte voiceIdCnt;

		private Dictionary<byte, LocalVoice> localVoices = new Dictionary<byte, LocalVoice>();

		private Dictionary<int, List<LocalVoice>> localVoicesPerChannel = new Dictionary<int, List<LocalVoice>>();

		private Dictionary<int, Dictionary<int, Dictionary<byte, RemoteVoice>>> remoteVoices = new Dictionary<int, Dictionary<int, Dictionary<byte, RemoteVoice>>>();

		private System.Random rnd = new System.Random();

		public int FramesLost { get; internal set; }

		public int FramesReceived { get; private set; }

		public int FramesSent
		{
			get
			{
				int num = 0;
				foreach (KeyValuePair<byte, LocalVoice> localVoice in localVoices)
				{
					num += localVoice.Value.FramesSent;
				}
				return num;
			}
		}

		public int FramesSentBytes
		{
			get
			{
				int num = 0;
				foreach (KeyValuePair<byte, LocalVoice> localVoice in localVoices)
				{
					num += localVoice.Value.FramesSentBytes;
				}
				return num;
			}
		}

		public int RoundTripTime { get; private set; }

		public int RoundTripTimeVariance { get; private set; }

		public bool SuppressInfoDuplicateWarning { get; set; }

		public RemoteVoiceInfoDelegate OnRemoteVoiceInfoAction { get; set; }

		public int DebugLostPercent { get; set; }

		public IEnumerable<LocalVoice> LocalVoices
		{
			get
			{
				LocalVoice[] array = new LocalVoice[localVoices.Count];
				localVoices.Values.CopyTo(array, 0);
				return array;
			}
		}

		public IEnumerable<RemoteVoiceInfo> RemoteVoiceInfos
		{
			get
			{
				foreach (KeyValuePair<int, Dictionary<int, Dictionary<byte, RemoteVoice>>> channelVoices in remoteVoices)
				{
					foreach (KeyValuePair<int, Dictionary<byte, RemoteVoice>> playerVoices in channelVoices.Value)
					{
						foreach (KeyValuePair<byte, RemoteVoice> item in playerVoices.Value)
						{
							yield return new RemoteVoiceInfo(channelVoices.Key, playerVoices.Key, item.Key, item.Value.Info, item.Value.options.LocalUserObject);
						}
					}
				}
			}
		}

		public IEnumerable<object> RemoteVoiceLocalUserObjects
		{
			get
			{
				foreach (KeyValuePair<int, Dictionary<int, Dictionary<byte, RemoteVoice>>> remoteVoice in remoteVoices)
				{
					foreach (KeyValuePair<int, Dictionary<byte, RemoteVoice>> item in remoteVoice.Value)
					{
						foreach (KeyValuePair<byte, RemoteVoice> item2 in item.Value)
						{
							yield return item2.Value.options.LocalUserObject;
						}
					}
				}
			}
		}

		internal byte GlobalGroup
		{
			get
			{
				return globalGroup;
			}
			set
			{
				globalGroup = value;
				foreach (KeyValuePair<byte, LocalVoice> localVoice in localVoices)
				{
					localVoice.Value.Group = globalGroup;
				}
			}
		}

		public IEnumerable<LocalVoice> LocalVoicesInChannel(int channelId)
		{
			if (localVoicesPerChannel.TryGetValue(channelId, out var value))
			{
				LocalVoice[] array = new LocalVoice[value.Count];
				value.CopyTo(array, 0);
				return array;
			}
			return new LocalVoice[0];
		}

		internal VoiceClient(IVoiceFrontend frontend)
		{
			this.frontend = frontend;
		}

		public void Service()
		{
			foreach (KeyValuePair<byte, LocalVoice> localVoice in localVoices)
			{
				localVoice.Value.service();
			}
		}

		private LocalVoice createLocalVoice(VoiceInfo voiceInfo, int channelId, Func<byte, int, LocalVoice> voiceFactory)
		{
			if (channelId == -1)
			{
				channelId = frontend.AssignChannel(voiceInfo);
			}
			byte newVoiceId = getNewVoiceId();
			if (newVoiceId != 0)
			{
				LocalVoice localVoice = voiceFactory(newVoiceId, channelId);
				if (localVoice != null)
				{
					addVoice(newVoiceId, channelId, localVoice);
					frontend.LogInfo(localVoice.LogPrefix + " added enc: " + localVoice.info.ToString());
					return localVoice;
				}
			}
			return null;
		}

		public LocalVoice CreateLocalVoice(VoiceInfo voiceInfo, int channelId = -1, IEncoder encoder = null)
		{
			return createLocalVoice(voiceInfo, channelId, (byte vId, int chId) => new LocalVoice(this, encoder, vId, voiceInfo, chId));
		}

		public LocalVoiceFramed<T> CreateLocalVoiceFramed<T>(VoiceInfo voiceInfo, int frameSize, int channelId = -1, IEncoderDataFlow<T> encoder = null)
		{
			return (LocalVoiceFramed<T>)createLocalVoice(voiceInfo, channelId, (byte vId, int chId) => new LocalVoiceFramed<T>(this, encoder, vId, voiceInfo, chId, frameSize));
		}

		public LocalVoiceAudio<T> CreateLocalVoiceAudio<T>(VoiceInfo voiceInfo, int channelId = -1, IEncoderDataFlow<T> encoder = null)
		{
			return (LocalVoiceAudio<T>)createLocalVoice(voiceInfo, channelId, (byte vId, int chId) => LocalVoiceAudio.Create<T>(this, vId, encoder, voiceInfo, chId));
		}

		private byte getNewVoiceId()
		{
			byte result = 0;
			if (voiceIdCnt == byte.MaxValue)
			{
				bool[] array = new bool[256];
				foreach (KeyValuePair<byte, LocalVoice> localVoice in localVoices)
				{
					array[localVoice.Value.id] = true;
				}
				for (byte b = 1; b != 0; b++)
				{
					if (!array[b])
					{
						result = b;
						break;
					}
				}
			}
			else
			{
				voiceIdCnt++;
				result = voiceIdCnt;
			}
			return result;
		}

		private void addVoice(byte newId, int channelId, LocalVoice v)
		{
			localVoices[newId] = v;
			if (!localVoicesPerChannel.TryGetValue(channelId, out var value))
			{
				value = new List<LocalVoice>();
				localVoicesPerChannel[channelId] = value;
			}
			value.Add(v);
			if (frontend.IsChannelJoined(channelId))
			{
				frontend.SendVoicesInfo(new List<LocalVoice> { v }, channelId, 0);
			}
			v.Group = GlobalGroup;
		}

		public void RemoveLocalVoice(LocalVoice voice)
		{
			localVoices.Remove(voice.id);
			localVoicesPerChannel[voice.channelId].Remove(voice);
			if (frontend.IsChannelJoined(voice.channelId))
			{
				frontend.SendVoiceRemove(voice, voice.channelId, 0);
			}
			voice.Dispose();
			frontend.LogInfo(voice.LogPrefix + " removed");
		}

		internal void sendVoicesInfo(int targetPlayerId)
		{
			foreach (int key in localVoicesPerChannel.Keys)
			{
				sendChannelVoicesInfo(key, targetPlayerId);
			}
		}

		internal void sendChannelVoicesInfo(int channelId, int targetPlayerId)
		{
			if (frontend.IsChannelJoined(channelId) && localVoicesPerChannel.TryGetValue(channelId, out var value))
			{
				frontend.SendVoicesInfo(value, channelId, targetPlayerId);
			}
		}

		internal void onVoiceEvent(object content0, int channelId, int playerId, int localPlayerId)
		{
			object[] array = (object[])content0;
			if ((byte)array[0] == 0)
			{
				switch ((byte)array[1])
				{
				case 1:
					onVoiceInfo(channelId, playerId, array[2]);
					break;
				case 2:
					onVoiceRemove(channelId, playerId, array[2]);
					break;
				default:
					frontend.LogError("[PV] Unknown sevent subcode " + array[1]);
					break;
				}
				return;
			}
			byte b = (byte)array[0];
			byte b2 = (byte)array[1];
			byte[] receivedBytes = (byte[])array[2];
			if (playerId == localPlayerId && localVoices.TryGetValue(b, out var value) && value.eventTimestamps.TryGetValue(b2, out var value2))
			{
				int num = Environment.TickCount - value2;
				int num2 = num - prevRtt;
				prevRtt = num;
				if (num2 < 0)
				{
					num2 = -num2;
				}
				RoundTripTimeVariance = (num2 + RoundTripTimeVariance * 19) / 20;
				RoundTripTime = (num + RoundTripTime * 19) / 20;
			}
			onFrame(channelId, playerId, b, b2, receivedBytes);
		}

		internal object[] buildVoicesInfo(IEnumerable<LocalVoice> voicesToSend, bool logInfo)
		{
			object[] array = new object[voicesToSend.Count()];
			object[] result = new object[3]
			{
				(byte)0,
				EventSubcode.VoiceInfo,
				array
			};
			int num = 0;
			foreach (LocalVoice item in voicesToSend)
			{
				array[num] = new Dictionary<byte, object>
				{
					{ 1, item.id },
					{
						12,
						item.info.Codec
					},
					{
						2,
						item.info.SamplingRate
					},
					{
						3,
						item.info.Channels
					},
					{
						4,
						item.info.FrameDurationUs
					},
					{
						5,
						item.info.Bitrate
					},
					{
						10,
						item.info.UserData
					},
					{ 11, item.evNumber }
				};
				num++;
				if (logInfo)
				{
					frontend.LogInfo(item.LogPrefix + " Sending info: " + item.info.ToString() + " ev=" + item.evNumber);
				}
			}
			return result;
		}

		internal object[] buildVoiceRemoveMessage(LocalVoice v)
		{
			byte[] array = new byte[1] { v.id };
			object[] result = new object[3]
			{
				(byte)0,
				EventSubcode.VoiceRemove,
				array
			};
			frontend.LogInfo(v.LogPrefix + " remove sent");
			return result;
		}

		internal void clearRemoteVoices()
		{
			foreach (KeyValuePair<int, Dictionary<int, Dictionary<byte, RemoteVoice>>> remoteVoice in remoteVoices)
			{
				foreach (KeyValuePair<int, Dictionary<byte, RemoteVoice>> item in remoteVoice.Value)
				{
					foreach (KeyValuePair<byte, RemoteVoice> item2 in item.Value)
					{
						item2.Value.removeAndDispose();
					}
				}
			}
			remoteVoices.Clear();
			frontend.LogInfo("[PV] Remote voices cleared");
		}

		internal void clearRemoteVoicesInChannel(int channelId)
		{
			Dictionary<int, Dictionary<byte, RemoteVoice>> value = null;
			if (remoteVoices.TryGetValue(channelId, out value))
			{
				foreach (KeyValuePair<int, Dictionary<byte, RemoteVoice>> item in value)
				{
					foreach (KeyValuePair<byte, RemoteVoice> item2 in item.Value)
					{
						item2.Value.removeAndDispose();
					}
				}
				remoteVoices.Remove(channelId);
			}
			frontend.LogInfo("[PV] Remote voices for channel " + channelStr(channelId) + " cleared");
		}

		private void onVoiceInfo(int channelId, int playerId, object payload)
		{
			Dictionary<int, Dictionary<byte, RemoteVoice>> value = null;
			if (!remoteVoices.TryGetValue(channelId, out value))
			{
				value = new Dictionary<int, Dictionary<byte, RemoteVoice>>();
				remoteVoices[channelId] = value;
			}
			Dictionary<byte, RemoteVoice> value2 = null;
			if (!value.TryGetValue(playerId, out value2))
			{
				value2 = (value[playerId] = new Dictionary<byte, RemoteVoice>());
			}
			object[] array = (object[])payload;
			for (int i = 0; i < array.Length; i++)
			{
				Dictionary<byte, object> dictionary2 = (Dictionary<byte, object>)array[i];
				byte b = (byte)dictionary2[1];
				if (!value2.ContainsKey(b))
				{
					byte b2 = (byte)dictionary2[11];
					VoiceInfo voiceInfo = VoiceInfo.CreateFromEventPayload(dictionary2);
					frontend.LogInfo("[PV] ch#" + channelStr(channelId) + " p#" + playerStr(playerId) + " v#" + b + " Info received: " + voiceInfo.ToString() + " ev=" + b2);
					RemoteVoiceOptions options = default(RemoteVoiceOptions);
					options.Decoder = VoiceCodec.CreateDefaultDecoder(channelId, playerId, b, voiceInfo);
					if (OnRemoteVoiceInfoAction != null)
					{
						OnRemoteVoiceInfoAction(channelId, playerId, b, voiceInfo, ref options);
					}
					value2[b] = new RemoteVoice(this, options, channelId, playerId, b, voiceInfo, b2);
				}
				else if (!SuppressInfoDuplicateWarning)
				{
					frontend.LogWarning("[PV] Info duplicate for voice #" + b + " of player " + playerStr(playerId) + " at channel " + channelStr(channelId));
				}
			}
		}

		private void onVoiceRemove(int channelId, int playerId, object payload)
		{
			byte[] array = (byte[])payload;
			Dictionary<int, Dictionary<byte, RemoteVoice>> value = null;
			if (remoteVoices.TryGetValue(channelId, out value))
			{
				Dictionary<byte, RemoteVoice> value2 = null;
				if (value.TryGetValue(playerId, out value2))
				{
					byte[] array2 = array;
					foreach (byte b in array2)
					{
						if (value2.TryGetValue(b, out var value3))
						{
							value2.Remove(b);
							frontend.LogInfo("[PV] Remote voice #" + b + " of player " + playerStr(playerId) + " at channel " + channelStr(channelId) + " removed");
							value3.removeAndDispose();
						}
						else
						{
							frontend.LogWarning("[PV] Remote voice #" + b + " of player " + playerStr(playerId) + " at channel " + channelStr(channelId) + " not found when trying to remove");
						}
					}
				}
				else
				{
					frontend.LogWarning("[PV] Remote voice list of player " + playerStr(playerId) + " at channel " + channelStr(channelId) + " not found when trying to remove voice(s)");
				}
			}
			else
			{
				frontend.LogWarning("[PV] Remote voice list of channel " + channelStr(channelId) + " not found when trying to remove voice(s)");
			}
		}

		private void onFrame(int channelId, int playerId, byte voiceId, byte evNumber, byte[] receivedBytes)
		{
			if (DebugLostPercent > 0 && rnd.Next(100) < DebugLostPercent)
			{
				frontend.LogWarning("[PV] Debug Lost Sim: 1 packet dropped");
				return;
			}
			FramesReceived++;
			Dictionary<int, Dictionary<byte, RemoteVoice>> value = null;
			if (remoteVoices.TryGetValue(channelId, out value))
			{
				Dictionary<byte, RemoteVoice> value2 = null;
				if (value.TryGetValue(playerId, out value2))
				{
					RemoteVoice value3 = null;
					if (value2.TryGetValue(voiceId, out value3))
					{
						value3.receiveBytes(receivedBytes, evNumber);
						return;
					}
					frontend.LogWarning("[PV] Frame event for not inited voice #" + voiceId + " of player " + playerStr(playerId) + " at channel " + channelStr(channelId));
				}
				else
				{
					frontend.LogWarning("[PV] Frame event for voice #" + voiceId + " of not inited player " + playerStr(playerId) + " at channel " + channelStr(channelId));
				}
			}
			else
			{
				frontend.LogWarning("[PV] Frame event for voice #" + voiceId + " of not inited channel " + channelStr(channelId));
			}
		}

		internal bool removePlayerVoices(int playerId)
		{
			foreach (int key in remoteVoices.Keys)
			{
				removePlayerVoices(key, playerId);
			}
			return true;
		}

		internal bool removePlayerVoices(int channelId, int playerId)
		{
			Dictionary<int, Dictionary<byte, RemoteVoice>> value = null;
			if (remoteVoices.TryGetValue(channelId, out value))
			{
				Dictionary<byte, RemoteVoice> value2 = null;
				if (value.TryGetValue(playerId, out value2))
				{
					value.Remove(playerId);
					foreach (KeyValuePair<byte, RemoteVoice> item in value2)
					{
						item.Value.removeAndDispose();
					}
					return true;
				}
				return false;
			}
			return false;
		}

		internal string channelStr(int channelId)
		{
			string text = frontend.ChannelIdStr(channelId);
			if (text != null)
			{
				return channelId + "(" + text + ")";
			}
			return channelId.ToString();
		}

		internal string playerStr(int playerId)
		{
			string text = frontend.PlayerIdStr(playerId);
			if (text != null)
			{
				return playerId + "(" + text + ")";
			}
			return playerId.ToString();
		}

		public void Dispose()
		{
			foreach (KeyValuePair<byte, LocalVoice> localVoice in localVoices)
			{
				localVoice.Value.Dispose();
			}
			foreach (KeyValuePair<int, Dictionary<int, Dictionary<byte, RemoteVoice>>> remoteVoice in remoteVoices)
			{
				foreach (KeyValuePair<int, Dictionary<byte, RemoteVoice>> item in remoteVoice.Value)
				{
					foreach (KeyValuePair<byte, RemoteVoice> item2 in item.Value)
					{
						item2.Value.Dispose();
					}
				}
			}
		}
	}
	public interface IEncoder : IDisposable
	{
	}
	public interface IEncoderDataFlow<T> : IEncoder, IDisposable
	{
	}
	public interface IEncoderDataFlowDirect<T> : IEncoderDataFlow<T>, IEncoder, IDisposable
	{
		ArraySegment<byte> EncodeAndGetOutput(T[] buf);
	}
	public interface IEncoderNativeImageDirect : IEncoder, IDisposable
	{
		IEnumerable<ArraySegment<byte>> EncodeAndGetOutput(IntPtr[] buf, int width, int height, int[] stride, ImageFormat imageFormat, Rotation rotation, Flip flip);
	}
	public interface IEncoderQueued : IEncoder, IDisposable
	{
		IEnumerable<ArraySegment<byte>> GetOutput();
	}
	public interface IDecoder : IDisposable
	{
		void Open(VoiceInfo info);
	}
	public interface IDecoderDirect : IDecoder, IDisposable
	{
		byte[] DecodeToByte(byte[] buf);

		float[] DecodeToFloat(byte[] buf);

		short[] DecodeToShort(byte[] buf);
	}
	public interface IDecoderQueued : IDecoder, IDisposable
	{
		void Decode(byte[] buf);
	}
	public delegate void OnImageOutputNative(IntPtr buf, int width, int height, int stride);
	public interface IDecoderQueuedOutputImageNative : IDecoderQueued, IDecoder, IDisposable
	{
		ImageFormat OutputImageFormat { get; set; }

		Flip OutputImageFlip { get; set; }

		Func<int, int, IntPtr> OutputImageBufferGetter { get; set; }

		OnImageOutputNative OnOutputImage { get; set; }
	}
	internal class UnsupportedSampleTypeException : Exception
	{
		public UnsupportedSampleTypeException(Type t)
			: base("[PV] unsupported sample type: " + t)
		{
		}
	}
	internal class UnsupportedCodecException : Exception
	{
		public UnsupportedCodecException(Codec codec, LocalVoice voice)
			: base(string.Concat("[PV] unsupported codec: ", codec, " at voice ", voice.GetType()))
		{
		}
	}
	public enum Codec
	{
		AudioOpus = 11
	}
	public enum ImageFormat
	{
		I420,
		YV12,
		Android420,
		RGBA,
		ABGR,
		BGRA,
		ARGB
	}
	public enum Rotation
	{
		Rotate0 = 0,
		Rotate90 = 90,
		Rotate180 = 180,
		Rotate270 = 270
	}
	public enum Flip
	{
		None,
		Vertical,
		Horizontal
	}
	public class ImageBufferInfo
	{
		public int Width { get; private set; }

		public int Height { get; private set; }

		public int[] Stride { get; private set; }

		public ImageFormat Format { get; private set; }

		public Rotation Rotation { get; set; }

		public Flip Flip { get; set; }

		public ImageBufferInfo(int width, int height, int[] stride, ImageFormat format)
		{
			Width = width;
			Height = height;
			Stride = stride;
			Format = format;
		}
	}
	public class ImageBufferNative
	{
		public ImageBufferInfo Info { get; protected set; }

		public IntPtr[] Planes { get; protected set; }

		public ImageBufferNative(ImageBufferInfo info)
		{
			Info = info;
		}

		public virtual void Release()
		{
		}

		public virtual void Dispose()
		{
		}
	}
	public class ImageBufferNativeAlloc : ImageBufferNative, IDisposable
	{
		private ImageBufferNativePool<ImageBufferNativeAlloc> pool;

		public ImageBufferNativeAlloc(ImageBufferNativePool<ImageBufferNativeAlloc> pool, ImageBufferInfo info)
			: base(info)
		{
			this.pool = pool;
			base.Planes = new IntPtr[info.Stride.Length];
			for (int i = 0; i < info.Stride.Length; i++)
			{
				base.Planes[i] = Marshal.AllocHGlobal(info.Stride[i] * info.Height);
			}
		}

		public override void Release()
		{
			if (pool != null)
			{
				pool.Release(this);
			}
		}

		public override void Dispose()
		{
			for (int i = 0; i < base.Info.Stride.Length; i++)
			{
				Marshal.FreeHGlobal(base.Planes[i]);
			}
		}
	}
	public class ImageBufferNativeGCHandleSinglePlane : ImageBufferNative, IDisposable
	{
		private ImageBufferNativePool<ImageBufferNativeGCHandleSinglePlane> pool;

		private GCHandle planeHandle;

		public ImageBufferNativeGCHandleSinglePlane(ImageBufferNativePool<ImageBufferNativeGCHandleSinglePlane> pool, ImageBufferInfo info)
			: base(info)
		{
			if (info.Stride.Length != 1)
			{
				throw new Exception("ImageBufferNativeGCHandleSinglePlane wrong plane count " + info.Stride.Length);
			}
			this.pool = pool;
			base.Planes = new IntPtr[1];
		}

		public void PinPlane(byte[] plane)
		{
			planeHandle = GCHandle.Alloc(plane, GCHandleType.Pinned);
			base.Planes[0] = planeHandle.AddrOfPinnedObject();
		}

		public override void Release()
		{
			planeHandle.Free();
			if (pool != null)
			{
				pool.Release(this);
			}
		}

		public override void Dispose()
		{
		}
	}
	internal static class VoiceCodec
	{
		internal static IEncoder CreateDefaultEncoder(VoiceInfo info, LocalVoice localVoice)
		{
			Codec codec = info.Codec;
			if (codec == Codec.AudioOpus)
			{
				return OpusCodec.EncoderFactory.Create(info, localVoice);
			}
			throw new UnsupportedCodecException(info.Codec, localVoice);
		}

		internal static IDecoder CreateDefaultDecoder(int channelId, int playerId, byte voiceId, VoiceInfo info)
		{
			Codec codec = info.Codec;
			if (codec == Codec.AudioOpus)
			{
				return new OpusCodec.Decoder();
			}
			return null;
		}
	}
	public class Framer<T>
	{
		private T[] frame;

		private int sizeofT;

		private int framePos;

		public Framer(int frameSize)
		{
			frame = new T[frameSize];
			T[] array = new T[1];
			if (array[0] is byte)
			{
				sizeofT = 1;
				return;
			}
			if (array[0] is short)
			{
				sizeofT = 2;
				return;
			}
			if (array[0] is float)
			{
				sizeofT = 4;
				return;
			}
			throw new Exception("Input data type is not supported: " + array[0].GetType());
		}

		public int Count(int bufLen)
		{
			return (bufLen + framePos) / frame.Length;
		}

		public IEnumerable<T[]> Frame(T[] buf)
		{
			int s = frame.Length;
			if (s == buf.Length && framePos == 0)
			{
				yield return buf;
				yield break;
			}
			int bufPos = 0;
			while (bufPos + s - framePos <= buf.Length)
			{
				int num = s - framePos;
				Buffer.BlockCopy(buf, bufPos * sizeofT, frame, framePos * sizeofT, num * sizeofT);
				bufPos += num;
				framePos = 0;
				yield return frame;
			}
			if (bufPos != buf.Length)
			{
				int num2 = buf.Length - bufPos;
				Buffer.BlockCopy(buf, bufPos * sizeofT, frame, framePos * sizeofT, num2 * sizeofT);
				framePos += num2;
			}
		}
	}
	public class LocalVoiceFramed : LocalVoice
	{
		public int FrameSize { get; private set; }

		internal LocalVoiceFramed(VoiceClient voiceClient, IEncoder encoder, byte id, VoiceInfo voiceInfo, int channelId, int frameSize)
			: base(voiceClient, encoder, id, voiceInfo, channelId)
		{
			FrameSize = frameSize;
		}
	}
	public class LocalVoiceFramed<T> : LocalVoiceFramed
	{
		public interface IProcessor : IDisposable
		{
			T[] Process(T[] buf);
		}

		private Framer<T> framer;

		private int preProcessorsCnt;

		private List<IProcessor> processors = new List<IProcessor>();

		private bool dataEncodeThreadStarted;

		private Queue<T[]> pushDataQueue = new Queue<T[]>();

		private AutoResetEvent pushDataQueueReady = new AutoResetEvent(initialState: false);

		private PrimitiveArrayPool<T> pushDataBufferPool;

		private int framesSkipped;

		private bool exitThread;

		public PrimitiveArrayPool<T> PushDataBufferPool => pushDataBufferPool;

		public bool PushDataAsyncReady
		{
			get
			{
				lock (pushDataQueue)
				{
					return pushDataQueue.Count < 49;
				}
			}
		}

		internal T[] processFrame(T[] buf)
		{
			lock (processors)
			{
				foreach (IProcessor processor in processors)
				{
					buf = processor.Process(buf);
					if (buf == null)
					{
						break;
					}
				}
			}
			return buf;
		}

		public void AddPostProcessor(params IProcessor[] processors)
		{
			lock (this.processors)
			{
				foreach (IProcessor item in processors)
				{
					this.processors.Add(item);
				}
			}
		}

		public void AddPreProcessor(params IProcessor[] processors)
		{
			lock (this.processors)
			{
				foreach (IProcessor item in processors)
				{
					this.processors.Insert(preProcessorsCnt++, item);
				}
			}
		}

		public void ClearProcessors()
		{
			lock (processors)
			{
				processors.Clear();
				preProcessorsCnt = 0;
			}
		}

		internal LocalVoiceFramed(VoiceClient voiceClient, IEncoder encoder, byte id, VoiceInfo voiceInfo, int channelId, int frameSize)
			: base(voiceClient, encoder, id, voiceInfo, channelId, frameSize)
		{
			framer = new Framer<T>(base.FrameSize);
			pushDataBufferPool = new PrimitiveArrayPool<T>(50, base.Name + " Data");
			PushDataBufferPool.Init(base.FrameSize);
		}

		public void PushDataAsync(T[] buf)
		{
			if (disposed)
			{
				return;
			}
			if (!dataEncodeThreadStarted)
			{
				voiceClient.frontend.LogInfo(base.LogPrefix + ": Starting data encode thread");
				Thread thread = new Thread(PushDataAsyncThread);
				thread.Start();
				thread.Name = base.LogPrefix + " data encode";
				dataEncodeThreadStarted = true;
			}
			if (PushDataAsyncReady)
			{
				lock (pushDataQueue)
				{
					pushDataQueue.Enqueue(buf);
				}
				pushDataQueueReady.Set();
			}
			else
			{
				PushDataBufferPool.Release(buf, buf.Length);
				framesSkipped++;
				voiceClient.frontend.LogWarning(base.LogPrefix + ": PushData queue overflow. Frames skipped: " + framesSkipped);
			}
		}

		private void PushDataAsyncThread()
		{
			try
			{
				while (!exitThread)
				{
					pushDataQueueReady.WaitOne();
					while (!exitThread)
					{
						T[] array = null;
						lock (pushDataQueue)
						{
							if (pushDataQueue.Count > 0)
							{
								array = pushDataQueue.Dequeue();
							}
						}
						if (array == null)
						{
							break;
						}
						PushData(array);
						PushDataBufferPool.Release(array, array.Length);
					}
				}
			}
			catch (Exception ex)
			{
				voiceClient.frontend.LogError(base.LogPrefix + ": Exception in encode thread: " + ex);
				throw ex;
			}
			finally
			{
				lock (disposeLock)
				{
					disposed = true;
				}
				PushDataBufferPool.Dispose();
				pushDataQueueReady.Close();
				voiceClient.frontend.LogInfo(base.LogPrefix + ": Exiting data encode thread");
			}
		}

		public void PushData(T[] buf)
		{
			if (!voiceClient.frontend.IsChannelJoined(channelId) || !base.Transmit)
			{
				return;
			}
			if (encoder is IEncoderDataFlowDirect<T>)
			{
				lock (disposeLock)
				{
					if (!disposed)
					{
						foreach (T[] item in framer.Frame(buf))
						{
							T[] array = processFrame(item);
							if (array != null)
							{
								sendFrame(((IEncoderDataFlowDirect<T>)encoder).EncodeAndGetOutput(array));
							}
						}
						return;
					}
					return;
				}
			}
			throw new Exception(base.LogPrefix + ": PushData(T[]) called on encoder of unsupported type " + ((encoder == null) ? "null" : encoder.GetType().ToString()));
		}

		public override void Dispose()
		{
			exitThread = true;
			lock (disposeLock)
			{
				if (!disposed)
				{
					lock (processors)
					{
						foreach (IProcessor processor in processors)
						{
							processor.Dispose();
						}
					}
					base.Dispose();
					pushDataQueueReady.Set();
				}
			}
			base.Dispose();
		}
	}
	public struct VoiceInfo
	{
		public Codec Codec { get; set; }

		public int SamplingRate { get; set; }

		public int SourceSamplingRate { get; set; }

		public int Channels { get; set; }

		public int FrameDurationUs { get; set; }

		public int Bitrate { get; set; }

		public object UserData { get; set; }

		public int FrameDurationSamples => (int)((long)SamplingRate * (long)FrameDurationUs / 1000000);

		public int FrameSize => FrameDurationSamples * Channels;

		public int Width { get; set; }

		public int Height { get; set; }

		public static VoiceInfo CreateAudioOpus(SamplingRate samplingRate, int sourceSamplingRate, int channels, OpusCodec.FrameDuration frameDurationUs, int bitrate, object userdata = null)
		{
			VoiceInfo result = default(VoiceInfo);
			result.Codec = Codec.AudioOpus;
			result.SamplingRate = (int)samplingRate;
			result.SourceSamplingRate = sourceSamplingRate;
			result.Channels = channels;
			result.FrameDurationUs = (int)frameDurationUs;
			result.Bitrate = bitrate;
			result.UserData = userdata;
			return result;
		}

		public override string ToString()
		{
			return string.Concat("c=", Codec, " f=", SamplingRate, " ch=", Channels, " d=", FrameDurationUs, " s=", FrameSize, " b=", Bitrate, " w=", Width, " h=", Height, " ud=", UserData);
		}

		internal static VoiceInfo CreateFromEventPayload(Dictionary<byte, object> h)
		{
			VoiceInfo result = default(VoiceInfo);
			result.SamplingRate = (int)h[2];
			result.Channels = (int)h[3];
			result.FrameDurationUs = (int)h[4];
			result.Bitrate = (int)h[5];
			result.UserData = h[10];
			result.Codec = (Codec)h[12];
			return result;
		}
	}
	public class RemoteVoiceInfo
	{
		public VoiceInfo Info { get; private set; }

		public int ChannelId { get; private set; }

		public int PlayerId { get; private set; }

		public byte VoiceId { get; private set; }

		public object LocalUserObject { get; private set; }

		internal RemoteVoiceInfo(int channelId, int playerId, byte voiceId, VoiceInfo info, object localUserObject)
		{
			ChannelId = channelId;
			PlayerId = playerId;
			VoiceId = voiceId;
			Info = info;
			LocalUserObject = localUserObject;
		}
	}
	public abstract class BufferReaderPushAdapterBase<T> : IServiceable
	{
		protected IDataReader<T> reader;

		public abstract void Service(LocalVoice localVoice);

		public BufferReaderPushAdapterBase(IDataReader<T> reader)
		{
			this.reader = reader;
		}

		public void Dispose()
		{
			reader.Dispose();
		}
	}
	public class BufferReaderPushAdapter<T> : BufferReaderPushAdapterBase<T>
	{
		protected T[] buffer;

		public BufferReaderPushAdapter(LocalVoice localVoice, IDataReader<T> reader)
			: base(reader)
		{
			buffer = new T[((LocalVoiceFramed<T>)localVoice).FrameSize];
		}

		public override void Service(LocalVoice localVoice)
		{
			while (reader.Read(buffer))
			{
				((LocalVoiceFramed<T>)localVoice).PushData(buffer);
			}
		}
	}
	public class BufferReaderPushAdapterAsyncPool<T> : BufferReaderPushAdapterBase<T>
	{
		public BufferReaderPushAdapterAsyncPool(LocalVoice localVoice, IDataReader<T> reader)
			: base(reader)
		{
		}

		public override void Service(LocalVoice localVoice)
		{
			LocalVoiceFramed<T> localVoiceFramed = (LocalVoiceFramed<T>)localVoice;
			T[] array = localVoiceFramed.PushDataBufferPool.AcquireOrCreate();
			while (reader.Read(array))
			{
				localVoiceFramed.PushDataAsync(array);
				array = localVoiceFramed.PushDataBufferPool.AcquireOrCreate();
			}
			localVoiceFramed.PushDataBufferPool.Release(array, array.Length);
		}
	}
	public class BufferReaderPushAdapterAsyncPoolCopy<T> : BufferReaderPushAdapterBase<T>
	{
		protected T[] buffer;

		public BufferReaderPushAdapterAsyncPoolCopy(LocalVoice localVoice, IDataReader<T> reader)
			: base(reader)
		{
			buffer = new T[((LocalVoiceFramed)localVoice).FrameSize];
		}

		public override void Service(LocalVoice localVoice)
		{
			while (reader.Read(buffer))
			{
				LocalVoiceFramed<T> obj = (LocalVoiceFramed<T>)localVoice;
				T[] array = obj.PushDataBufferPool.AcquireOrCreate();
				Array.Copy(buffer, array, buffer.Length);
				obj.PushDataAsync(array);
			}
		}
	}
	public class BufferReaderPushAdapterAsyncPoolFloatToShort : BufferReaderPushAdapterBase<float>
	{
		private float[] buffer;

		public BufferReaderPushAdapterAsyncPoolFloatToShort(LocalVoice localVoice, IDataReader<float> reader)
			: base(reader)
		{
			buffer = new float[((LocalVoiceFramed<short>)localVoice).FrameSize];
		}

		public override void Service(LocalVoice localVoice)
		{
			LocalVoiceFramed<short> localVoiceFramed = (LocalVoiceFramed<short>)localVoice;
			short[] array = localVoiceFramed.PushDataBufferPool.AcquireOrCreate();
			while (reader.Read(buffer))
			{
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = (short)(buffer[i] * 32767f);
				}
				localVoiceFramed.PushDataAsync(array);
				array = localVoiceFramed.PushDataBufferPool.AcquireOrCreate();
			}
			localVoiceFramed.PushDataBufferPool.Release(array, array.Length);
		}
	}
	internal class VoiceEventCode
	{
		public const byte Code0 = 201;

		public static byte GetCode(int channelID)
		{
			return (byte)(201 + channelID);
		}

		public static bool TryGetChannelID(byte evCode, int maxChannels, out byte channelID)
		{
			if (evCode >= 201 && evCode < 201 + maxChannels)
			{
				channelID = (byte)(evCode - 201);
				return true;
			}
			channelID = 0;
			return false;
		}
	}
	public class LoadBalancingFrontend : LoadBalancingClient, IVoiceFrontend, ILogger, IDisposable
	{
		protected VoiceClient voiceClient;

		private object sendLock = new object();

		public VoiceClient VoiceClient => voiceClient;

		public new Action<EventData> OnEventAction { get; set; }

		public new Action<ClientState> OnStateChangeAction { get; set; }

		public byte GlobalAudioGroup
		{
			get
			{
				return voiceClient.GlobalGroup;
			}
			set
			{
				voiceClient.GlobalGroup = value;
				if (base.State == ClientState.Joined)
				{
					if (voiceClient.GlobalGroup != 0)
					{
						loadBalancingPeer.OpChangeGroups(new byte[0], new byte[1] { voiceClient.GlobalGroup });
					}
					else
					{
						loadBalancingPeer.OpChangeGroups(new byte[0], null);
					}
				}
			}
		}

		public void LogError(string fmt, params object[] args)
		{
			DebugReturn(DebugLevel.ERROR, string.Format(fmt, args));
		}

		public void LogWarning(string fmt, params object[] args)
		{
			DebugReturn(DebugLevel.WARNING, string.Format(fmt, args));
		}

		public void LogInfo(string fmt, params object[] args)
		{
			DebugReturn(DebugLevel.INFO, string.Format(fmt, args));
		}

		public void LogDebug(string fmt, params object[] args)
		{
			DebugReturn(DebugLevel.ALL, string.Format(fmt, args));
		}

		public int AssignChannel(VoiceInfo v)
		{
			return 1 + Array.IndexOf(Enum.GetValues(typeof(Codec)), v.Codec);
		}

		public bool IsChannelJoined(int channelId)
		{
			return base.State == ClientState.Joined;
		}

		public void SetDebugEchoMode(LocalVoice v)
		{
			if (base.State == ClientState.Joined)
			{
				if (v.DebugEchoMode)
				{
					SendVoicesInfo(new List<LocalVoice> { v }, v.channelId, base.LocalPlayer.ID);
				}
				else
				{
					SendVoiceRemove(v, v.channelId, base.LocalPlayer.ID);
				}
			}
		}

		public LoadBalancingFrontend(ConnectionProtocol connectionProtocol = ConnectionProtocol.Udp)
			: base(connectionProtocol)
		{
			base.OnEventAction += onEventActionVoiceClient;
			base.OnStateChangeAction += onStateChangeVoiceClient;
			voiceClient = new VoiceClient(this);
			int num = Enum.GetValues(typeof(Codec)).Length + 1;
			if (loadBalancingPeer.ChannelCount < num)
			{
				loadBalancingPeer.ChannelCount = (byte)num;
			}
		}

		public new void Service()
		{
			base.Service();
			voiceClient.Service();
		}

		public virtual bool ChangeAudioGroups(byte[] groupsToRemove, byte[] groupsToAdd)
		{
			return loadBalancingPeer.OpChangeGroups(groupsToRemove, groupsToAdd);
		}

		public void SendVoicesInfo(IEnumerable<LocalVoice> voices, int channelId, int targetPlayerId)
		{
			object customEventContent = voiceClient.buildVoicesInfo(voices, logInfo: true);
			SendOptions sendOptions = default(SendOptions);
			sendOptions.Reliability = true;
			sendOptions.Channel = (byte)channelId;
			SendOptions sendOptions2 = sendOptions;
			RaiseEventOptions raiseEventOptions = new RaiseEventOptions();
			if (targetPlayerId != 0)
			{
				raiseEventOptions.TargetActors = new int[1] { targetPlayerId };
			}
			lock (sendLock)
			{
				OpRaiseEvent(VoiceEventCode.GetCode(channelId), customEventContent, raiseEventOptions, sendOptions2);
			}
			if (targetPlayerId == 0)
			{
				SendDebugEchoVoicesInfo(channelId);
			}
		}

		public void SendDebugEchoVoicesInfo(int channelId)
		{
			IEnumerable<LocalVoice> enumerable = voiceClient.LocalVoices.Where((LocalVoice x) => x.DebugEchoMode);
			if (enumerable.Count() > 0)
			{
				SendVoicesInfo(enumerable, channelId, base.LocalPlayer.ID);
			}
		}

		public void SendVoiceRemove(LocalVoice voice, int channelId, int targetPlayerId)
		{
			object customEventContent = voiceClient.buildVoiceRemoveMessage(voice);
			SendOptions sendOptions = default(SendOptions);
			sendOptions.Reliability = true;
			sendOptions.Channel = (byte)channelId;
			SendOptions sendOptions2 = sendOptions;
			RaiseEventOptions raiseEventOptions = new RaiseEventOptions();
			if (targetPlayerId != 0)
			{
				raiseEventOptions.TargetActors = new int[1] { targetPlayerId };
			}
			lock (sendLock)
			{
				if (voice.DebugEchoMode)
				{
					raiseEventOptions.Receivers = ReceiverGroup.All;
				}
				OpRaiseEvent(VoiceEventCode.GetCode(channelId), customEventContent, raiseEventOptions, sendOptions2);
			}
		}

		public void SendFrame(ArraySegment<byte> data, byte evNumber, byte voiceId, int channelId, LocalVoice localVoice)
		{
			object[] customEventContent = new object[3] { voiceId, evNumber, data };
			SendOptions sendOptions = default(SendOptions);
			sendOptions.Reliability = localVoice.Reliable;
			sendOptions.Channel = (byte)channelId;
			sendOptions.Encrypt = localVoice.Encrypt;
			SendOptions sendOptions2 = sendOptions;
			RaiseEventOptions raiseEventOptions = new RaiseEventOptions();
			if (localVoice.DebugEchoMode)
			{
				raiseEventOptions.Receivers = ReceiverGroup.All;
			}
			raiseEventOptions.InterestGroup = localVoice.Group;
			lock (sendLock)
			{
				OpRaiseEvent(VoiceEventCode.GetCode(channelId), customEventContent, raiseEventOptions, sendOptions2);
			}
			loadBalancingPeer.SendOutgoingCommands();
		}

		public string ChannelIdStr(int channelId)
		{
			return null;
		}

		public string PlayerIdStr(int playerId)
		{
			return null;
		}

		private void onEventActionVoiceClient(EventData ev)
		{
			if (VoiceEventCode.TryGetChannelID(ev.Code, loadBalancingPeer.ChannelCount, out var channelID))
			{
				voiceClient.onVoiceEvent(ev[245], channelID, (int)ev[254], base.LocalPlayer.ID);
			}
			else
			{
				switch (ev.Code)
				{
				case byte.MaxValue:
				{
					int num = (int)ev[254];
					if (num != base.LocalPlayer.ID)
					{
						voiceClient.sendVoicesInfo(num);
					}
					break;
				}
				case 254:
				{
					int num = (int)ev[254];
					if (num == base.LocalPlayer.ID)
					{
						voiceClient.clearRemoteVoices();
					}
					else
					{
						onPlayerLeave(num);
					}
					break;
				}
				}
			}
			if (OnEventAction != null)
			{
				OnEventAction(ev);
			}
		}

		private void onStateChangeVoiceClient(ClientState state)
		{
			switch (state)
			{
			case ClientState.Joined:
				voiceClient.clearRemoteVoices();
				voiceClient.sendVoicesInfo(0);
				if (voiceClient.GlobalGroup != 0)
				{
					loadBalancingPeer.OpChangeGroups(new byte[0], new byte[1] { voiceClient.GlobalGroup });
				}
				break;
			case ClientState.Disconnected:
				voiceClient.clearRemoteVoices();
				break;
			}
			if (OnStateChangeAction != null)
			{
				OnStateChangeAction(state);
			}
		}

		private void onPlayerLeave(int playerId)
		{
			if (voiceClient.removePlayerVoices(playerId))
			{
				DebugReturn(DebugLevel.INFO, "[PV] Player " + playerId + " voices removed on leave");
			}
			else
			{
				DebugReturn(DebugLevel.WARNING, "[PV] Voices of player " + playerId + " not found when trying to remove on player leave");
			}
		}

		public void Dispose()
		{
			voiceClient.Dispose();
		}
	}
	public class AudioInEnumerator : IDisposable
	{
		public readonly bool IsSupported;

		public int Count => 0;

		public void Refresh()
		{
		}

		public string NameAtIndex(int i)
		{
			return null;
		}

		public int IDAtIndex(int i)
		{
			return -1;
		}

		public bool IDIsValid(int id)
		{
			return id >= -1;
		}

		public void Dispose()
		{
		}
	}
}
namespace ExitGames.Client.Photon.LoadBalancing
{
	public static class Extensions
	{
		public static void Merge(this IDictionary target, IDictionary addHash)
		{
			if (addHash == null || target.Equals(addHash))
			{
				return;
			}
			foreach (object key in addHash.Keys)
			{
				target[key] = addHash[key];
			}
		}

		public static void MergeStringKeys(this IDictionary target, IDictionary addHash)
		{
			if (addHash == null || target.Equals(addHash))
			{
				return;
			}
			foreach (object key in addHash.Keys)
			{
				if (key is string)
				{
					target[key] = addHash[key];
				}
			}
		}

		public static string ToStringFull(this IDictionary origin)
		{
			return SupportClass.DictionaryToString(origin, includeTypes: false);
		}

		public static string ToStringFull(this object[] data)
		{
			if (data == null)
			{
				return "null";
			}
			string[] array = new string[data.Length];
			for (int i = 0; i < data.Length; i++)
			{
				object obj = data[i];
				array[i] = ((obj != null) ? obj.ToString() : "null");
			}
			return string.Join(", ", array);
		}

		public static Hashtable StripToStringKeys(this IDictionary original)
		{
			Hashtable hashtable = new Hashtable();
			if (original != null)
			{
				foreach (object key in original.Keys)
				{
					if (key is string)
					{
						hashtable[key] = original[key];
					}
				}
			}
			return hashtable;
		}

		public static void StripKeysWithNullValues(this IDictionary original)
		{
			object[] array = new object[original.Count];
			original.Keys.CopyTo(array, 0);
			foreach (object key in array)
			{
				if (original[key] == null)
				{
					original.Remove(key);
				}
			}
		}

		public static bool Contains(this int[] target, int nr)
		{
			if (target == null)
			{
				return false;
			}
			for (int i = 0; i < target.Length; i++)
			{
				if (target[i] == nr)
				{
					return true;
				}
			}
			return false;
		}
	}
	public class FriendInfo
	{
		[Obsolete("Use UserId.")]
		public string Name => UserId;

		public string UserId { get; protected internal set; }

		public bool IsOnline { get; protected internal set; }

		public string Room { get; protected internal set; }

		public bool IsInRoom
		{
			get
			{
				if (IsOnline)
				{
					return !string.IsNullOrEmpty(Room);
				}
				return false;
			}
		}

		public override string ToString()
		{
			return string.Format("{0}\t is: {1}", UserId, (!IsOnline) ? "offline" : (IsInRoom ? "playing" : "on master"));
		}
	}
	public enum ClientState
	{
		PeerCreated = 0,
		Authenticating = 1,
		Authenticated = 2,
		JoinedLobby = 3,
		DisconnectingFromMasterserver = 4,
		ConnectingToGameserver = 5,
		ConnectedToGameserver = 6,
		Joining = 7,
		Joined = 8,
		Leaving = 9,
		DisconnectingFromGameserver = 10,
		ConnectingToMasterserver = 11,
		Disconnecting = 12,
		Disconnected = 13,
		ConnectedToMasterserver = 14,
		[Obsolete("Renamed to ConnectedToMasterserver.")]
		ConnectedToMaster = 14,
		ConnectingToNameServer = 15,
		ConnectedToNameServer = 16,
		DisconnectingFromNameServer = 17
	}
	internal enum JoinType
	{
		CreateRoom,
		JoinRoom,
		JoinRandomRoom,
		JoinOrCreateRoom
	}
	public enum DisconnectCause
	{
		None,
		DisconnectByServerUserLimit,
		ExceptionOnConnect,
		DisconnectByServer,
		TimeoutDisconnect,
		Exception,
		InvalidAuthentication,
		MaxCcuReached,
		InvalidRegion,
		OperationNotAllowedInCurrentState,
		CustomAuthenticationFailed,
		DisconnectByServerLogic,
		AuthenticationTicketExpired
	}
	public enum ServerConnection
	{
		MasterServer,
		GameServer,
		NameServer
	}
	public enum EncryptionMode
	{
		PayloadEncryption = 0,
		DatagramEncryption = 10,
		DatagramEncryptionRandomSequence = 11
	}
	public static class EncryptionDataParameters
	{
		public const byte Mode = 0;

		public const byte Secret1 = 1;

		public const byte Secret2 = 2;
	}
	public class LoadBalancingClient : IPhotonPeerListener
	{
		public LoadBalancingPeer loadBalancingPeer;

		public AuthModeOption AuthMode;

		public EncryptionMode EncryptionMode;

		private ConnectionProtocol ExpectedProtocol;

		public string NameServerHost = "ns.exitgames.com";

		public string NameServerHttp = "http://ns.exitgames.com:80/photon/n";

		private static readonly Dictionary<ConnectionProtocol, int> ProtocolToNameServerPort = new Dictionary<ConnectionProtocol, int>
		{
			{
				ConnectionProtocol.Udp,
				5058
			},
			{
				ConnectionProtocol.Tcp,
				4533
			},
			{
				ConnectionProtocol.WebSocket,
				9093
			},
			{
				ConnectionProtocol.WebSocketSecure,
				19093
			}
		};

		private ClientState state;

		private bool inLobby;

		private bool autoJoinLobby = true;

		public bool EnableLobbyStatistics;

		private List<TypedLobbyInfo> lobbyStatistics = new List<TypedLobbyInfo>();

		public Dictionary<string, RoomInfo> RoomInfoList = new Dictionary<string, RoomInfo>();

		public Room CurrentRoom;

		private JoinType lastJoinType;

		protected internal EnterRoomParams enterRoomParamsCache;

		private bool didAuthenticate;

		private string[] friendListRequested;

		private int friendListTimestamp;

		private bool isFetchingFriendList;

		private byte[] encryptionSecret;

		public string AppVersion { get; set; }

		public string AppId { get; set; }

		public AuthenticationValues AuthValues { get; set; }

		public ConnectionProtocol TransportProtocol
		{
			get
			{
				return loadBalancingPeer.TransportProtocol;
			}
			set
			{
				if (loadBalancingPeer == null || loadBalancingPeer.PeerState != 0)
				{
					DebugReturn(DebugLevel.WARNING, "Can't set TransportProtocol. Disconnect first! " + ((loadBalancingPeer != null) ? ("PeerState: " + loadBalancingPeer.PeerState) : "loadBalancingPeer is null."));
				}
				else
				{
					loadBalancingPeer.TransportProtocol = value;
				}
			}
		}

		public Dictionary<ConnectionProtocol, Type> SocketImplementationConfig => loadBalancingPeer.SocketImplementationConfig;

		private string TokenForInit
		{
			get
			{
				if (AuthMode == AuthModeOption.Auth)
				{
					return null;
				}
				if (AuthValues == null)
				{
					return null;
				}
				return AuthValues.Token;
			}
		}

		public bool IsUsingNameServer { get; protected internal set; }

		public string NameServerAddress => GetNameServerAddress();

		public string CurrentServerAddress => loadBalancingPeer.ServerAddress;

		public string MasterServerAddress { get; protected internal set; }

		public string GameServerAddress { get; protected internal set; }

		public ServerConnection Server { get; private set; }

		public ClientState State
		{
			get
			{
				return state;
			}
			protected internal set
			{
				state = value;
				if (this.OnStateChangeAction != null)
				{
					this.OnStateChangeAction(state);
				}
			}
		}

		public bool IsConnected
		{
			get
			{
				if (loadBalancingPeer != null && State != 0)
				{
					return State != ClientState.Disconnected;
				}
				return false;
			}
		}

		public bool IsConnectedAndReady
		{
			get
			{
				if (loadBalancingPeer == null)
				{
					return false;
				}
				switch (State)
				{
				case ClientState.PeerCreated:
				case ClientState.Authenticating:
				case ClientState.ConnectingToGameserver:
				case ClientState.Joining:
				case ClientState.Leaving:
				case ClientState.ConnectingToMasterserver:
				case ClientState.Disconnecting:
				case ClientState.Disconnected:
				case ClientState.ConnectingToNameServer:
					return false;
				default:
					return true;
				}
			}
		}

		public DisconnectCause DisconnectedCause { get; protected set; }

		public TypedLobby CurrentLobby { get; protected internal set; }

		public bool AutoJoinLobby
		{
			get
			{
				return autoJoinLobby;
			}
			set
			{
				autoJoinLobby = value;
			}
		}

		public List<TypedLobbyInfo> LobbyStatistics
		{
			get
			{
				return lobbyStatistics;
			}
			private set
			{
				lobbyStatistics = value;
			}
		}

		public Player LocalPlayer { get; internal set; }

		public string NickName
		{
			get
			{
				return LocalPlayer.NickName;
			}
			set
			{
				if (LocalPlayer != null)
				{
					LocalPlayer.NickName = value;
				}
			}
		}

		public string UserId
		{
			get
			{
				if (AuthValues != null)
				{
					return AuthValues.UserId;
				}
				return null;
			}
			set
			{
				if (AuthValues == null)
				{
					AuthValues = new AuthenticationValues();
				}
				AuthValues.UserId = value;
			}
		}

		public int PlayersOnMasterCount { get; internal set; }

		public int PlayersInRoomsCount { get; internal set; }

		public int RoomsCount { get; internal set; }

		public List<FriendInfo> FriendList { get; private set; }

		public int FriendListAge
		{
			get
			{
				if (!isFetchingFriendList && friendListTimestamp != 0)
				{
					return Environment.TickCount - friendListTimestamp;
				}
				return 0;
			}
		}

		protected bool IsAuthorizeSecretAvailable
		{
			get
			{
				if (AuthValues != null)
				{
					return !string.IsNullOrEmpty(AuthValues.Token);
				}
				return false;
			}
		}

		public string[] AvailableRegions { get; private set; }

		public string[] AvailableRegionsServers { get; private set; }

		public string CloudRegion { get; private set; }

		public event Action<ClientState> OnStateChangeAction;

		public event Action<EventData> OnEventAction;

		public event Action<OperationResponse> OnOpResponseAction;

		public LoadBalancingClient(ConnectionProtocol protocol = ConnectionProtocol.Udp)
		{
			loadBalancingPeer = new LoadBalancingPeer(this, protocol);
			LocalPlayer = CreatePlayer(string.Empty, -1, isLocal: true, null);
			State = ClientState.PeerCreated;
		}

		public LoadBalancingClient(string masterAddress, string appId, string gameVersion, ConnectionProtocol protocol = ConnectionProtocol.Udp)
			: this(protocol)
		{
			MasterServerAddress = masterAddress;
			AppId = appId;
			AppVersion = gameVersion;
		}

		private string GetNameServerAddress()
		{
			int value = 0;
			ProtocolToNameServerPort.TryGetValue(loadBalancingPeer.TransportProtocol, out value);
			switch (loadBalancingPeer.TransportProtocol)
			{
			case ConnectionProtocol.Udp:
			case ConnectionProtocol.Tcp:
				return $"{NameServerHost}:{value}";
			case ConnectionProtocol.WebSocket:
				return $"ws://{NameServerHost}:{value}";
			case ConnectionProtocol.WebSocketSecure:
				return $"wss://{NameServerHost}:{value}";
			default:
				throw new ArgumentOutOfRangeException();
			}
		}

		public bool Connect(string masterServerAddress, string appId, string appVersion, string nickName, AuthenticationValues authValues)
		{
			if (!string.IsNullOrEmpty(masterServerAddress))
			{
				MasterServerAddress = masterServerAddress;
			}
			if (!string.IsNullOrEmpty(appId))
			{
				AppId = appId;
			}
			if (!string.IsNullOrEmpty(appVersion))
			{
				AppVersion = appVersion;
			}
			if (!string.IsNullOrEmpty(nickName))
			{
				NickName = nickName;
			}
			AuthValues = authValues;
			return Connect();
		}

		public virtual bool Connect()
		{
			DisconnectedCause = DisconnectCause.None;
			if (loadBalancingPeer.Connect(MasterServerAddress, AppId, TokenForInit))
			{
				State = ClientState.ConnectingToMasterserver;
				return true;
			}
			return false;
		}

		public bool ConnectToNameServer()
		{
			IsUsingNameServer = true;
			CloudRegion = null;
			if (AuthMode == AuthModeOption.AuthOnceWss)
			{
				ExpectedProtocol = loadBalancingPeer.TransportProtocol;
				loadBalancingPeer.TransportProtocol = ConnectionProtocol.WebSocketSecure;
			}
			if (!loadBalancingPeer.Connect(NameServerAddress, "NameServer", TokenForInit))
			{
				return false;
			}
			State = ClientState.ConnectingToNameServer;
			return true;
		}

		public bool ConnectToRegionMaster(string region)
		{
			IsUsingNameServer = true;
			if (State == ClientState.ConnectedToNameServer)
			{
				CloudRegion = region;
				return CallAuthenticate();
			}
			loadBalancingPeer.Disconnect();
			CloudRegion = region;
			if (AuthMode == AuthModeOption.AuthOnceWss)
			{
				ExpectedProtocol = loadBalancingPeer.TransportProtocol;
				loadBalancingPeer.TransportProtocol = ConnectionProtocol.WebSocketSecure;
			}
			if (!loadBalancingPeer.Connect(NameServerAddress, "NameServer", null))
			{
				return false;
			}
			State = ClientState.ConnectingToNameServer;
			return true;
		}

		public void Disconnect()
		{
			if (State != ClientState.Disconnected)
			{
				State = ClientState.Disconnecting;
				loadBalancingPeer.Disconnect();
			}
		}

		private bool CallAuthenticate()
		{
			if (AuthMode == AuthModeOption.Auth)
			{
				return loadBalancingPeer.OpAuthenticate(AppId, AppVersion, AuthValues, CloudRegion, EnableLobbyStatistics && Server == ServerConnection.MasterServer);
			}
			return loadBalancingPeer.OpAuthenticateOnce(AppId, AppVersion, AuthValues, CloudRegion, EncryptionMode, ExpectedProtocol);
		}

		public void Service()
		{
			if (loadBalancingPeer != null)
			{
				loadBalancingPeer.Service();
			}
		}

		private void DisconnectToReconnect()
		{
			switch (Server)
			{
			case ServerConnection.NameServer:
				State = ClientState.DisconnectingFromNameServer;
				break;
			case ServerConnection.MasterServer:
				State = ClientState.DisconnectingFromMasterserver;
				break;
			case ServerConnection.GameServer:
				State = ClientState.DisconnectingFromGameserver;
				break;
			}
			loadBalancingPeer.Disconnect();
		}

		private bool ConnectToGameServer()
		{
			if (loadBalancingPeer.Connect(GameServerAddress, AppId, TokenForInit))
			{
				State = ClientState.ConnectingToGameserver;
				return true;
			}
			return false;
		}

		public bool OpGetRegions()
		{
			if (Server != ServerConnection.NameServer)
			{
				return false;
			}
			bool num = loadBalancingPeer.OpGetRegions(AppId);
			if (num)
			{
				AvailableRegions = null;
			}
			return num;
		}

		public bool OpFindFriends(string[] friendsToFind)
		{
			if (loadBalancingPeer == null)
			{
				DebugReturn(DebugLevel.ERROR, "OpFindFriends aborted: loadBalancingPeer is null.");
				return false;
			}
			if (isFetchingFriendList || Server != 0)
			{
				DebugReturn(DebugLevel.WARNING, "OpFindFriends skipped: already fetching friends list.");
				return false;
			}
			if (friendsToFind == null || friendsToFind.Length == 0)
			{
				DebugReturn(DebugLevel.ERROR, "OpFindFriends skipped: friendsToFind array is null or empty.");
				return false;
			}
			List<string> list = new List<string>(friendsToFind.Length);
			for (int i = 0; i < friendsToFind.Length; i++)
			{
				string text = friendsToFind[i];
				if (string.IsNullOrEmpty(text))
				{
					DebugReturn(DebugLevel.WARNING, $"friendsToFind array contains a null or empty UserId, element at position {i} skipped.");
				}
				else if (text.Equals(UserId))
				{
					DebugReturn(DebugLevel.WARNING, $"friendsToFind array contains local player's UserId \"{text}\", element at position {i} skipped.");
				}
				else if (list.Contains(text))
				{
					DebugReturn(DebugLevel.WARNING, $"friendsToFind array contains duplicate UserId \"{text}\", element at position {i} skipped.");
				}
				else
				{
					list.Add(text);
				}
			}
			if (list.Count == 0)
			{
				DebugReturn(DebugLevel.ERROR, "OpFindFriends skipped: friends list to find is empty.");
				return false;
			}
			isFetchingFriendList = true;
			friendListRequested = list.ToArray();
			return loadBalancingPeer.OpFindFriends(friendsToFind);
		}

		public bool OpJoinLobby(TypedLobby lobby)
		{
			if (lobby == null)
			{
				lobby = TypedLobby.Default;
			}
			bool num = loadBalancingPeer.OpJoinLobby(lobby);
			if (num)
			{
				CurrentLobby = lobby;
			}
			return num;
		}

		public bool OpLeaveLobby()
		{
			return loadBalancingPeer.OpLeaveLobby();
		}

		public bool OpJoinRandomRoom(Hashtable expectedCustomRoomProperties, byte expectedMaxPlayers, string[] expectedUsers = null)
		{
			return OpJoinRandomRoom(expectedCustomRoomProperties, expectedMaxPlayers, MatchmakingMode.FillRoom, TypedLobby.Default, null, expectedUsers);
		}

		public bool OpJoinRandomRoom(Hashtable expectedCustomRoomProperties, byte expectedMaxPlayers, MatchmakingMode matchmakingMode)
		{
			return OpJoinRandomRoom(expectedCustomRoomProperties, expectedMaxPlayers, matchmakingMode, TypedLobby.Default, null);
		}

		public bool OpJoinRandomRoom(Hashtable expectedCustomRoomProperties, byte expectedMaxPlayers, MatchmakingMode matchmakingMode, TypedLobby lobby, string sqlLobbyFilter, string[] expectedUsers = null)
		{
			if (lobby == null)
			{
				lobby = TypedLobby.Default;
			}
			State = ClientState.Joining;
			lastJoinType = JoinType.JoinRandomRoom;
			CurrentLobby = lobby;
			enterRoomParamsCache = new EnterRoomParams();
			enterRoomParamsCache.Lobby = lobby;
			enterRoomParamsCache.ExpectedUsers = expectedUsers;
			OpJoinRandomRoomParams opJoinRandomRoomParams = new OpJoinRandomRoomParams();
			opJoinRandomRoomParams.ExpectedCustomRoomProperties = expectedCustomRoomProperties;
			opJoinRandomRoomParams.ExpectedMaxPlayers = expectedMaxPlayers;
			opJoinRandomRoomParams.MatchingType = matchmakingMode;
			opJoinRandomRoomParams.TypedLobby = lobby;
			opJoinRandomRoomParams.SqlLobbyFilter = sqlLobbyFilter;
			opJoinRandomRoomParams.ExpectedUsers = expectedUsers;
			return loadBalancingPeer.OpJoinRandomRoom(opJoinRandomRoomParams);
		}

		public bool OpJoinRoom(string roomName, string[] expectedUsers = null)
		{
			State = ClientState.Joining;
			lastJoinType = JoinType.JoinRoom;
			bool onGameServer = Server == ServerConnection.GameServer;
			EnterRoomParams enterRoomParams = (enterRoomParamsCache = new EnterRoomParams());
			enterRoomParams.RoomName = roomName;
			enterRoomParams.OnGameServer = onGameServer;
			enterRoomParams.ExpectedUsers = expectedUsers;
			return loadBalancingPeer.OpJoinRoom(enterRoomParams);
		}

		public bool OpReJoinRoom(string roomName)
		{
			State = ClientState.Joining;
			lastJoinType = JoinType.JoinRoom;
			bool onGameServer = Server == ServerConnection.GameServer;
			EnterRoomParams enterRoomParams = (enterRoomParamsCache = new EnterRoomParams());
			enterRoomParams.RoomName = roomName;
			enterRoomParams.OnGameServer = onGameServer;
			enterRoomParams.RejoinOnly = true;
			return loadBalancingPeer.OpJoinRoom(enterRoomParams);
		}

		public bool OpJoinOrCreateRoom(string roomName, RoomOptions roomOptions, TypedLobby lobby, string[] expectedUsers = null)
		{
			State = ClientState.Joining;
			lastJoinType = JoinType.JoinOrCreateRoom;
			CurrentLobby = lobby;
			bool onGameServer = Server == ServerConnection.GameServer;
			EnterRoomParams enterRoomParams = (enterRoomParamsCache = new EnterRoomParams());
			enterRoomParams.RoomName = roomName;
			enterRoomParams.RoomOptions = roomOptions;
			enterRoomParams.Lobby = lobby;
			enterRoomParams.CreateIfNotExists = true;
			enterRoomParams.OnGameServer = onGameServer;
			enterRoomParams.ExpectedUsers = expectedUsers;
			return loadBalancingPeer.OpJoinRoom(enterRoomParams);
		}

		public bool OpCreateRoom(string roomName, RoomOptions roomOptions, TypedLobby lobby, string[] expectedUsers = null)
		{
			State = ClientState.Joining;
			lastJoinType = JoinType.CreateRoom;
			CurrentLobby = lobby;
			bool onGameServer = Server == ServerConnection.GameServer;
			EnterRoomParams enterRoomParams = (enterRoomParamsCache = new EnterRoomParams());
			enterRoomParams.RoomName = roomName;
			enterRoomParams.RoomOptions = roomOptions;
			enterRoomParams.Lobby = lobby;
			enterRoomParams.OnGameServer = onGameServer;
			enterRoomParams.ExpectedUsers = expectedUsers;
			return loadBalancingPeer.OpCreateRoom(enterRoomParams);
		}

		public bool OpLeaveRoom()
		{
			return OpLeaveRoom(becomeInactive: false);
		}

		public bool OpLeaveRoom(bool becomeInactive, bool sendAuthCookie = false)
		{
			if (CurrentRoom == null || Server != ServerConnection.GameServer || State == ClientState.DisconnectingFromGameserver)
			{
				return false;
			}
			State = ClientState.Leaving;
			return loadBalancingPeer.OpLeaveRoom(becomeInactive, sendAuthCookie);
		}

		public bool OpGetGameList(TypedLobby typedLobby, string sqlLobbyFilter)
		{
			return loadBalancingPeer.OpGetGameList(typedLobby, sqlLobbyFilter);
		}

		public bool OpSetCustomPropertiesOfActor(int actorNr, Hashtable propertiesToSet, Hashtable expectedProperties = null, WebFlags webFlags = null)
		{
			if (CurrentRoom == null)
			{
				if (expectedProperties == null && webFlags == null && LocalPlayer != null && LocalPlayer.ID == actorNr)
				{
					LocalPlayer.SetCustomProperties(propertiesToSet);
					return true;
				}
				if ((int)loadBalancingPeer.DebugOut >= 1)
				{
					DebugReturn(DebugLevel.ERROR, "OpSetCustomPropertiesOfActor() failed. To use expectedProperties or webForward, you have to be in a room. State: " + State);
				}
				return false;
			}
			Hashtable hashtable = new Hashtable();
			hashtable.MergeStringKeys(propertiesToSet);
			return OpSetPropertiesOfActor(actorNr, hashtable, expectedProperties, webFlags);
		}

		[Obsolete("Use the overload with WebFlags.")]
		public bool OpSetCustomPropertiesOfActor(int actorNr, Hashtable propertiesToSet, Hashtable expectedProperties, bool webForward)
		{
			return OpSetCustomPropertiesOfActor(actorNr, propertiesToSet, expectedProperties, webForward ? new WebFlags(1) : null);
		}

		protected internal bool OpSetPropertiesOfActor(int actorNr, Hashtable actorProperties, Hashtable expectedProperties = null, WebFlags webFlags = null)
		{
			if (CurrentRoom == null)
			{
				if ((int)loadBalancingPeer.DebugOut >= 1)
				{
					DebugReturn(DebugLevel.ERROR, "OpSetPropertiesOfActor() failed because this client is not in a room currently. State: " + State);
				}
				return false;
			}
			if (expectedProperties == null || expectedProperties.Count == 0)
			{
				CurrentRoom.GetPlayer(actorNr)?.InternalCacheProperties(actorProperties);
			}
			return loadBalancingPeer.OpSetPropertiesOfActor(actorNr, actorProperties, expectedProperties, webFlags);
		}

		public bool OpSetCustomPropertiesOfRoom(Hashtable propertiesToSet, Hashtable expectedProperties = null, WebFlags webFlags = null)
		{
			Hashtable hashtable = new Hashtable();
			hashtable.MergeStringKeys(propertiesToSet);
			return OpSetPropertiesOfRoom(hashtable, expectedProperties, webFlags);
		}

		[Obsolete("Use the overload with WebFlags.")]
		public bool OpSetCustomPropertiesOfRoom(Hashtable propertiesToSet, Hashtable expectedProperties, bool webForward)
		{
			return OpSetCustomPropertiesOfRoom(propertiesToSet, expectedProperties, webForward ? new WebFlags(1) : null);
		}

		protected internal bool OpSetPropertiesOfRoom(Hashtable gameProperties, Hashtable expectedProperties = null, WebFlags webFlags = null)
		{
			if (CurrentRoom == null)
			{
				if ((int)loadBalancingPeer.DebugOut >= 1)
				{
					DebugReturn(DebugLevel.ERROR, "OpSetPropertiesOfRoom() failed because this client is not in a room currently. State: " + State);
				}
				return false;
			}
			if (expectedProperties == null || expectedProperties.Count == 0)
			{
				CurrentRoom.InternalCacheProperties(gameProperties);
			}
			return loadBalancingPeer.OpSetPropertiesOfRoom(gameProperties, expectedProperties, webFlags);
		}

		public virtual bool OpRaiseEvent(byte eventCode, object customEventContent, RaiseEventOptions raiseEventOptions, SendOptions sendOptions)
		{
			if (loadBalancingPeer == null)
			{
				return false;
			}
			return loadBalancingPeer.OpRaiseEvent(eventCode, customEventContent, raiseEventOptions, sendOptions);
		}

		[Obsolete("Use OpRaiseEvent(byte eventCode, object customEventContent, RaiseEventOptions raiseEventOptions) instead. Parameter 'sendReliable' moved to: RaiseEventOptions.SendOptions.")]
		public virtual bool OpRaiseEvent(byte eventCode, object customEventContent, bool sendReliable, RaiseEventOptions raiseEventOptions)
		{
			if (loadBalancingPeer == null)
			{
				return false;
			}
			return loadBalancingPeer.OpRaiseEvent(eventCode, customEventContent, raiseEventOptions, new SendOptions
			{
				Reliability = sendReliable,
				Channel = raiseEventOptions.SequenceChannel
			});
		}

		public virtual bool OpChangeGroups(byte[] groupsToRemove, byte[] groupsToAdd)
		{
			if (loadBalancingPeer == null)
			{
				return false;
			}
			return loadBalancingPeer.OpChangeGroups(groupsToRemove, groupsToAdd);
		}

		private void ReadoutProperties(Hashtable gameProperties, Hashtable actorProperties, int targetActorNr)
		{
			if (CurrentRoom != null && gameProperties != null)
			{
				CurrentRoom.InternalCacheProperties(gameProperties);
			}
			if (actorProperties == null || actorProperties.Count <= 0)
			{
				return;
			}
			if (targetActorNr > 0)
			{
				Player player = CurrentRoom.GetPlayer(targetActorNr);
				if (player != null)
				{
					Hashtable properties = ReadoutPropertiesForActorNr(actorProperties, targetActorNr);
					player.InternalCacheProperties(properties);
				}
				return;
			}
			foreach (object key in actorProperties.Keys)
			{
				int num = (int)key;
				Hashtable hashtable = (Hashtable)actorProperties[key];
				string actorName = (string)hashtable[byte.MaxValue];
				Player player2 = CurrentRoom.GetPlayer(num);
				if (player2 == null)
				{
					player2 = CreatePlayer(actorName, num, isLocal: false, hashtable);
					CurrentRoom.StorePlayer(player2);
				}
				player2.InternalCacheProperties(hashtable);
			}
		}

		private Hashtable ReadoutPropertiesForActorNr(Hashtable actorProperties, int actorNr)
		{
			if (actorProperties.ContainsKey(actorNr))
			{
				return (Hashtable)actorProperties[actorNr];
			}
			return actorProperties;
		}

		protected internal void ChangeLocalID(int newID)
		{
			if (LocalPlayer == null)
			{
				DebugReturn(DebugLevel.WARNING, $"Local actor is null or not in mActors! mLocalActor: {LocalPlayer} mActors==null: {CurrentRoom.Players == null} newID: {newID}");
			}
			if (CurrentRoom == null)
			{
				LocalPlayer.ChangeLocalID(newID);
				LocalPlayer.RoomReference = null;
			}
			else
			{
				CurrentRoom.RemovePlayer(LocalPlayer);
				LocalPlayer.ChangeLocalID(newID);
				CurrentRoom.StorePlayer(LocalPlayer);
			}
		}

		private void CleanCachedValues()
		{
			ChangeLocalID(-1);
			isFetchingFriendList = false;
			if (Server == ServerConnection.GameServer || State == ClientState.Disconnecting || State == ClientState.PeerCreated)
			{
				CurrentRoom = null;
			}
			if (Server == ServerConnection.MasterServer || State == ClientState.Disconnecting || State == ClientState.PeerCreated)
			{
				RoomInfoList.Clear();
			}
		}

		private void GameEnteredOnGameServer(OperationResponse operationResponse)
		{
			CurrentRoom = CreateRoom(enterRoomParamsCache.RoomName, enterRoomParamsCache.RoomOptions);
			CurrentRoom.LoadBalancingClient = this;
			CurrentRoom.IsLocalClientInside = true;
			int newID = (int)operationResponse[254];
			ChangeLocalID(newID);
			if (operationResponse.Parameters.ContainsKey(252))
			{
				int[] actorsInGame = (int[])operationResponse.Parameters[252];
				UpdatedActorList(actorsInGame);
			}
			Hashtable actorProperties = (Hashtable)operationResponse[249];
			Hashtable gameProperties = (Hashtable)operationResponse[248];
			ReadoutProperties(gameProperties, actorProperties, 0);
			State = ClientState.Joined;
			byte operationCode = operationResponse.OperationCode;
			if ((uint)(operationCode - 225) > 1u)
			{
				_ = 227;
			}
		}

		private void UpdatedActorList(int[] actorsInGame)
		{
			if (actorsInGame == null)
			{
				return;
			}
			foreach (int num in actorsInGame)
			{
				if (CurrentRoom.GetPlayer(num) == null)
				{
					CurrentRoom.StorePlayer(CreatePlayer(string.Empty, num, isLocal: false, null));
				}
			}
		}

		protected internal virtual Player CreatePlayer(string actorName, int actorNumber, bool isLocal, Hashtable actorProperties)
		{
			return new Player(actorName, actorNumber, isLocal, actorProperties);
		}

		protected internal virtual Room CreateRoom(string roomName, RoomOptions opt)
		{
			return new Room(roomName, opt);
		}

		public virtual void DebugReturn(DebugLevel level, string message)
		{
			if (loadBalancingPeer.DebugOut == DebugLevel.ALL || (int)level <= (int)loadBalancingPeer.DebugOut)
			{
				switch (level)
				{
				case DebugLevel.ERROR:
					UnityEngine.Debug.LogError(message);
					break;
				case DebugLevel.WARNING:
					UnityEngine.Debug.LogWarning(message);
					break;
				case DebugLevel.INFO:
					UnityEngine.Debug.Log(message);
					break;
				case DebugLevel.ALL:
					UnityEngine.Debug.Log(message);
					break;
				}
			}
		}

		public virtual void OnOperationResponse(OperationResponse operationResponse)
		{
			if (operationResponse.Parameters.ContainsKey(221))
			{
				if (AuthValues == null)
				{
					AuthValues = new AuthenticationValues();
				}
				AuthValues.Token = operationResponse[221] as string;
			}
			switch (operationResponse.OperationCode)
			{
			case 230:
			case 231:
				if (operationResponse.ReturnCode != 0)
				{
					DebugReturn(DebugLevel.ERROR, string.Concat(operationResponse.ToStringFull(), " Server: ", Server, " Address: ", loadBalancingPeer.ServerAddress));
					switch (operationResponse.ReturnCode)
					{
					case short.MaxValue:
						DisconnectedCause = DisconnectCause.InvalidAuthentication;
						break;
					case 32755:
						DisconnectedCause = DisconnectCause.CustomAuthenticationFailed;
						break;
					case 32756:
						DisconnectedCause = DisconnectCause.InvalidRegion;
						break;
					case 32757:
						DisconnectedCause = DisconnectCause.MaxCcuReached;
						break;
					case -3:
						DisconnectedCause = DisconnectCause.OperationNotAllowedInCurrentState;
						break;
					}
					State = ClientState.Disconnecting;
					Disconnect();
					break;
				}
				if (Server == ServerConnection.NameServer || Server == ServerConnection.MasterServer)
				{
					if (operationResponse.Parameters.ContainsKey(225))
					{
						string text2 = (string)operationResponse.Parameters[225];
						if (!string.IsNullOrEmpty(text2))
						{
							UserId = text2;
							DebugReturn(DebugLevel.INFO, $"Received your UserID from server. Updating local value to: {UserId}");
						}
					}
					if (operationResponse.Parameters.ContainsKey(202))
					{
						NickName = (string)operationResponse.Parameters[202];
						DebugReturn(DebugLevel.INFO, $"Received your NickName from server. Updating local value to: {NickName}");
					}
					if (operationResponse.Parameters.ContainsKey(192))
					{
						SetupEncryption((Dictionary<byte, object>)operationResponse.Parameters[192]);
					}
				}
				if (Server == ServerConnection.NameServer)
				{
					MasterServerAddress = operationResponse[230] as string;
					if (AuthMode == AuthModeOption.AuthOnceWss)
					{
						DebugReturn(DebugLevel.INFO, $"Due to AuthOnceWss, switching TransportProtocol to ExpectedProtocol: {ExpectedProtocol}.");
						loadBalancingPeer.TransportProtocol = ExpectedProtocol;
					}
					DisconnectToReconnect();
				}
				else if (Server == ServerConnection.MasterServer)
				{
					State = ClientState.ConnectedToMasterserver;
					if (AuthMode != 0)
					{
						loadBalancingPeer.OpSettings(EnableLobbyStatistics);
					}
					if (AutoJoinLobby)
					{
						loadBalancingPeer.OpJoinLobby(CurrentLobby);
					}
				}
				else if (Server == ServerConnection.GameServer)
				{
					State = ClientState.Joining;
					enterRoomParamsCache.PlayerProperties = LocalPlayer.AllProperties;
					enterRoomParamsCache.OnGameServer = true;
					if (lastJoinType == JoinType.JoinRoom || lastJoinType == JoinType.JoinRandomRoom || lastJoinType == JoinType.JoinOrCreateRoom)
					{
						loadBalancingPeer.OpJoinRoom(enterRoomParamsCache);
					}
					else if (lastJoinType == JoinType.CreateRoom)
					{
						loadBalancingPeer.OpCreateRoom(enterRoomParamsCache);
					}
				}
				break;
			case 220:
				AvailableRegions = operationResponse[210] as string[];
				AvailableRegionsServers = operationResponse[230] as string[];
				break;
			case 225:
			case 226:
			case 227:
			{
				if (operationResponse.ReturnCode != 0)
				{
					if (Server == ServerConnection.GameServer)
					{
						DisconnectToReconnect();
					}
					else
					{
						State = (inLobby ? ClientState.JoinedLobby : ClientState.ConnectedToMasterserver);
					}
					break;
				}
				if (Server == ServerConnection.GameServer)
				{
					GameEnteredOnGameServer(operationResponse);
					break;
				}
				GameServerAddress = (string)operationResponse[230];
				string text3 = operationResponse[byte.MaxValue] as string;
				if (!string.IsNullOrEmpty(text3))
				{
					enterRoomParamsCache.RoomName = text3;
				}
				DisconnectToReconnect();
				break;
			}
			case 217:
			{
				if (operationResponse.ReturnCode != 0)
				{
					DebugReturn(DebugLevel.ERROR, "GetGameList failed: " + operationResponse.ToStringFull());
					break;
				}
				RoomInfoList = new Dictionary<string, RoomInfo>();
				Hashtable hashtable = (Hashtable)operationResponse[222];
				foreach (string key in hashtable.Keys)
				{
					RoomInfo value = new RoomInfo(key, (Hashtable)hashtable[key]);
					RoomInfoList[key] = value;
				}
				break;
			}
			case 229:
				State = ClientState.JoinedLobby;
				inLobby = true;
				break;
			case 228:
				State = ClientState.ConnectedToMasterserver;
				inLobby = false;
				break;
			case 254:
				DisconnectToReconnect();
				break;
			case 222:
			{
				if (operationResponse.ReturnCode != 0)
				{
					DebugReturn(DebugLevel.ERROR, "OpFindFriends failed: " + operationResponse.ToStringFull());
					isFetchingFriendList = false;
					break;
				}
				bool[] array = operationResponse[1] as bool[];
				string[] array2 = operationResponse[2] as string[];
				List<FriendInfo> list = new List<FriendInfo>(friendListRequested.Length);
				for (int i = 0; i < friendListRequested.Length; i++)
				{
					FriendInfo friendInfo = new FriendInfo();
					friendInfo.UserId = friendListRequested[i];
					friendInfo.Room = array2[i];
					friendInfo.IsOnline = array[i];
					list.Insert(i, friendInfo);
				}
				FriendList = list;
				friendListRequested = null;
				isFetchingFriendList = false;
				friendListTimestamp = Environment.TickCount;
				if (friendListTimestamp == 0)
				{
					friendListTimestamp = 1;
				}
				break;
			}
			}
			if (this.OnOpResponseAction != null)
			{
				this.OnOpResponseAction(operationResponse);
			}
		}

		public virtual void OnStatusChanged(StatusCode statusCode)
		{
			switch (statusCode)
			{
			case StatusCode.Connect:
				inLobby = false;
				if (State == ClientState.ConnectingToNameServer)
				{
					if ((int)loadBalancingPeer.DebugOut >= 5)
					{
						DebugReturn(DebugLevel.ALL, "Connected to nameserver.");
					}
					Server = ServerConnection.NameServer;
					if (AuthValues != null)
					{
						AuthValues.Token = null;
					}
				}
				if (State == ClientState.ConnectingToGameserver)
				{
					if ((int)loadBalancingPeer.DebugOut >= 5)
					{
						DebugReturn(DebugLevel.ALL, "Connected to gameserver.");
					}
					Server = ServerConnection.GameServer;
				}
				if (State == ClientState.ConnectingToMasterserver)
				{
					if ((int)loadBalancingPeer.DebugOut >= 5)
					{
						DebugReturn(DebugLevel.ALL, "Connected to masterserver.");
					}
					Server = ServerConnection.MasterServer;
				}
				if (loadBalancingPeer.TransportProtocol != ConnectionProtocol.WebSocketSecure)
				{
					if (Server == ServerConnection.NameServer || AuthMode == AuthModeOption.Auth)
					{
						loadBalancingPeer.EstablishEncryption();
					}
					break;
				}
				goto case StatusCode.EncryptionEstablished;
			case StatusCode.EncryptionEstablished:
				if (Server == ServerConnection.NameServer)
				{
					State = ClientState.ConnectedToNameServer;
				}
				if ((Server == ServerConnection.NameServer || (AuthMode != AuthModeOption.AuthOnce && AuthMode != AuthModeOption.AuthOnceWss)) && !didAuthenticate && (!IsUsingNameServer || CloudRegion != null))
				{
					didAuthenticate = CallAuthenticate();
					if (didAuthenticate)
					{
						State = ClientState.Authenticating;
					}
					else
					{
						DebugReturn(DebugLevel.ERROR, "Error calling OpAuthenticate! Did not work. Check log output, AuthValues and if you're connected. State: " + State);
					}
				}
				break;
			case StatusCode.Disconnect:
				CleanCachedValues();
				didAuthenticate = false;
				inLobby = false;
				switch (State)
				{
				case ClientState.PeerCreated:
				case ClientState.Disconnecting:
					if (AuthValues != null)
					{
						AuthValues.Token = null;
					}
					State = ClientState.Disconnected;
					break;
				case ClientState.DisconnectingFromGameserver:
				case ClientState.DisconnectingFromNameServer:
					Connect();
					break;
				case ClientState.DisconnectingFromMasterserver:
					ConnectToGameServer();
					break;
				default:
				{
					string text = "";
					DebugReturn(DebugLevel.WARNING, string.Concat("Got a unexpected Disconnect in LoadBalancingClient State: ", State, ". Server: ", Server, " Trace: ", text));
					if (AuthValues != null)
					{
						AuthValues.Token = null;
					}
					State = ClientState.Disconnected;
					break;
				}
				}
				break;
			case StatusCode.DisconnectByServerUserLimit:
				DebugReturn(DebugLevel.ERROR, "The Photon license's CCU Limit was reached. Server rejected this connection. Wait and re-try.");
				if (AuthValues != null)
				{
					AuthValues.Token = null;
				}
				DisconnectedCause = DisconnectCause.DisconnectByServerUserLimit;
				State = ClientState.Disconnected;
				break;
			case StatusCode.SecurityExceptionOnConnect:
			case StatusCode.ExceptionOnConnect:
				if (AuthValues != null)
				{
					AuthValues.Token = null;
				}
				DisconnectedCause = DisconnectCause.ExceptionOnConnect;
				State = ClientState.Disconnected;
				break;
			case StatusCode.DisconnectByServerTimeout:
				if (AuthValues != null)
				{
					AuthValues.Token = null;
				}
				DisconnectedCause = DisconnectCause.DisconnectByServer;
				State = ClientState.Disconnected;
				break;
			case StatusCode.DisconnectByServerLogic:
				if (AuthValues != null)
				{
					AuthValues.Token = null;
				}
				DisconnectedCause = DisconnectCause.DisconnectByServerLogic;
				State = ClientState.Disconnected;
				break;
			case StatusCode.TimeoutDisconnect:
				if (AuthValues != null)
				{
					AuthValues.Token = null;
				}
				DisconnectedCause = DisconnectCause.TimeoutDisconnect;
				State = ClientState.Disconnected;
				break;
			case StatusCode.Exception:
			case StatusCode.ExceptionOnReceive:
				if (AuthValues != null)
				{
					AuthValues.Token = null;
				}
				DisconnectedCause = DisconnectCause.Exception;
				State = ClientState.Disconnected;
				break;
			}
		}

		public virtual void OnEvent(EventData photonEvent)
		{
			int num = 0;
			Player player = null;
			if (photonEvent.Parameters.ContainsKey(254))
			{
				num = (int)photonEvent[254];
				if (CurrentRoom != null)
				{
					player = CurrentRoom.GetPlayer(num);
				}
			}
			switch (photonEvent.Code)
			{
			case 229:
			case 230:
			{
				if (photonEvent.Code == 230)
				{
					RoomInfoList = new Dictionary<string, RoomInfo>();
				}
				Hashtable hashtable2 = (Hashtable)photonEvent[222];
				foreach (string key in hashtable2.Keys)
				{
					RoomInfo roomInfo = new RoomInfo(key, (Hashtable)hashtable2[key]);
					if (roomInfo.removedFromList)
					{
						RoomInfoList.Remove(key);
					}
					else
					{
						RoomInfoList[key] = roomInfo;
					}
				}
				break;
			}
			case byte.MaxValue:
			{
				Hashtable hashtable = (Hashtable)photonEvent[249];
				if (player == null)
				{
					Player player2 = CreatePlayer(string.Empty, num, isLocal: false, hashtable);
					CurrentRoom.StorePlayer(player2);
				}
				else
				{
					player.InternalCacheProperties(hashtable);
					player.IsInactive = false;
				}
				if (num == LocalPlayer.ID)
				{
					int[] actorsInGame = (int[])photonEvent[252];
					UpdatedActorList(actorsInGame);
				}
				break;
			}
			case 254:
			{
				bool flag = false;
				if (photonEvent.Parameters.ContainsKey(233))
				{
					flag = (bool)photonEvent.Parameters[233];
				}
				if (flag)
				{
					player.IsInactive = true;
				}
				else
				{
					CurrentRoom.RemovePlayer(num);
				}
				if (photonEvent.Parameters.ContainsKey(203))
				{
					int num2 = (int)photonEvent[203];
					if (num2 != 0)
					{
						CurrentRoom.masterClientId = num2;
					}
				}
				break;
			}
			case 253:
			{
				int num3 = 0;
				if (photonEvent.Parameters.ContainsKey(253))
				{
					num3 = (int)photonEvent[253];
				}
				Hashtable gameProperties = null;
				Hashtable actorProperties = null;
				if (num3 == 0)
				{
					gameProperties = (Hashtable)photonEvent[251];
				}
				else
				{
					actorProperties = (Hashtable)photonEvent[251];
				}
				ReadoutProperties(gameProperties, actorProperties, num3);
				break;
			}
			case 226:
				PlayersInRoomsCount = (int)photonEvent[229];
				RoomsCount = (int)photonEvent[228];
				PlayersOnMasterCount = (int)photonEvent[227];
				break;
			case 224:
			{
				string[] array = photonEvent[213] as string[];
				byte[] array2 = photonEvent[212] as byte[];
				int[] array3 = photonEvent[229] as int[];
				int[] array4 = photonEvent[228] as int[];
				lobbyStatistics.Clear();
				for (int i = 0; i < array.Length; i++)
				{
					TypedLobbyInfo typedLobbyInfo = new TypedLobbyInfo();
					typedLobbyInfo.Name = array[i];
					typedLobbyInfo.Type = (LobbyType)array2[i];
					typedLobbyInfo.PlayerCount = array3[i];
					typedLobbyInfo.RoomCount = array4[i];
					lobbyStatistics.Add(typedLobbyInfo);
				}
				break;
			}
			case 251:
				if (this.OnEventAction != null)
				{
					this.OnEventAction(photonEvent);
				}
				break;
			case 223:
				if (AuthValues == null)
				{
					AuthValues = new AuthenticationValues();
				}
				AuthValues.Token = photonEvent[221] as string;
				break;
			}
			if (this.OnEventAction != null)
			{
				this.OnEventAction(photonEvent);
			}
		}

		public virtual void OnMessage(object message)
		{
			DebugReturn(DebugLevel.ALL, $"got OnMessage {message}");
		}

		private void SetupEncryption(Dictionary<byte, object> encryptionData)
		{
			EncryptionMode encryptionMode = (EncryptionMode)(byte)encryptionData[0];
			switch (encryptionMode)
			{
			case EncryptionMode.PayloadEncryption:
			{
				byte[] secret = (byte[])encryptionData[1];
				loadBalancingPeer.InitPayloadEncryption(secret);
				break;
			}
			case EncryptionMode.DatagramEncryption:
			case EncryptionMode.DatagramEncryptionRandomSequence:
			{
				byte[] array = (byte[])encryptionData[1];
				byte[] hmacSecret = (byte[])encryptionData[2];
				loadBalancingPeer.InitDatagramEncryption(array, hmacSecret, encryptionMode == EncryptionMode.DatagramEncryptionRandomSequence);
				break;
			}
			default:
				throw new ArgumentOutOfRangeException();
			}
		}

		public bool OpWebRpc(string uriPath, object parameters, bool sendAuthCookie = false)
		{
			Dictionary<byte, object> dictionary = new Dictionary<byte, object>();
			dictionary.Add(209, uriPath);
			dictionary.Add(208, parameters);
			if (sendAuthCookie)
			{
				dictionary.Add(234, (byte)2);
			}
			return loadBalancingPeer.SendOperation(219, dictionary, new SendOptions
			{
				Reliability = true
			});
		}
	}
	public class LoadBalancingPeer : PhotonPeer
	{
		private enum RoomOptionBit
		{
			CheckUserOnJoin = 1,
			DeleteCacheOnLeave = 2,
			SuppressRoomEvents = 4,
			PublishUserId = 8,
			DeleteNullProps = 0x10,
			BroadcastPropsChangeToAll = 0x20
		}

		protected internal static Type PingImplementation;

		private readonly Dictionary<byte, object> opParameters = new Dictionary<byte, object>();

		public LoadBalancingPeer(ConnectionProtocol protocolType)
			: base(protocolType)
		{
			ConfigUnitySockets();
		}

		public LoadBalancingPeer(IPhotonPeerListener listener, ConnectionProtocol protocolType)
			: this(protocolType)
		{
			base.Listener = listener;
		}

		[Conditional("UNITY")]
		private void ConfigUnitySockets()
		{
			PingImplementation = typeof(PingMono);
			Type type = Type.GetType("ExitGames.Client.Photon.SocketWebTcpThread, Assembly-CSharp", throwOnError: false);
			type = type ?? Type.GetType("ExitGames.Client.Photon.SocketWebTcpThread, Assembly-CSharp-firstpass", throwOnError: false);
			type = type ?? Type.GetType("ExitGames.Client.Photon.SocketWebTcpCoroutine, Assembly-CSharp", throwOnError: false);
			type = type ?? Type.GetType("ExitGames.Client.Photon.SocketWebTcpCoroutine, Assembly-CSharp-firstpass", throwOnError: false);
			if (type != null)
			{
				SocketImplementationConfig[ConnectionProtocol.WebSocket] = type;
				SocketImplementationConfig[ConnectionProtocol.WebSocketSecure] = type;
			}
		}

		public virtual bool OpGetRegions(string appId)
		{
			Dictionary<byte, object> dictionary = new Dictionary<byte, object>();
			dictionary[224] = appId;
			return SendOperation(220, dictionary, new SendOptions
			{
				Reliability = true,
				Encrypt = true
			});
		}

		public virtual bool OpJoinLobby(TypedLobby lobby = null)
		{
			if ((int)DebugOut >= 3)
			{
				base.Listener.DebugReturn(DebugLevel.INFO, "OpJoinLobby()");
			}
			Dictionary<byte, object> dictionary = null;
			if (lobby != null && !lobby.IsDefault)
			{
				dictionary = new Dictionary<byte, object>();
				dictionary[213] = lobby.Name;
				dictionary[212] = (byte)lobby.Type;
			}
			return SendOperation(229, dictionary, new SendOptions
			{
				Reliability = true
			});
		}

		public virtual bool OpLeaveLobby()
		{
			if ((int)DebugOut >= 3)
			{
				base.Listener.DebugReturn(DebugLevel.INFO, "OpLeaveLobby()");
			}
			return SendOperation(228, null, new SendOptions
			{
				Reliability = true
			});
		}

		private void RoomOptionsToOpParameters(Dictionary<byte, object> op, RoomOptions roomOptions)
		{
			if (roomOptions == null)
			{
				roomOptions = new RoomOptions();
			}
			Hashtable hashtable = new Hashtable();
			hashtable[(byte)253] = roomOptions.IsOpen;
			hashtable[(byte)254] = roomOptions.IsVisible;
			hashtable[(byte)250] = ((roomOptions.CustomRoomPropertiesForLobby == null) ? new string[0] : roomOptions.CustomRoomPropertiesForLobby);
			hashtable.MergeStringKeys(roomOptions.CustomRoomProperties);
			if (roomOptions.MaxPlayers > 0)
			{
				hashtable[byte.MaxValue] = roomOptions.MaxPlayers;
			}
			op[248] = hashtable;
			int num = 0;
			op[241] = roomOptions.CleanupCacheOnLeave;
			num |= 2;
			if (!roomOptions.CleanupCacheOnLeave)
			{
				hashtable[(byte)249] = false;
			}
			num |= 1;
			op[232] = true;
			if (roomOptions.PlayerTtl > 0 || roomOptions.PlayerTtl == -1)
			{
				num |= 1;
				op[232] = true;
				op[235] = roomOptions.PlayerTtl;
			}
			if (roomOptions.EmptyRoomTtl > 0)
			{
				op[236] = roomOptions.EmptyRoomTtl;
			}
			if (roomOptions.SuppressRoomEvents)
			{
				num |= 4;
				op[237] = true;
			}
			if (roomOptions.Plugins != null)
			{
				op[204] = roomOptions.Plugins;
			}
			if (roomOptions.PublishUserId)
			{
				num |= 8;
				op[239] = true;
			}
			if (roomOptions.DeleteNullProperties)
			{
				num |= 0x10;
			}
			op[191] = num;
		}

		public virtual bool OpCreateRoom(EnterRoomParams opParams)
		{
			if ((int)DebugOut >= 3)
			{
				base.Listener.DebugReturn(DebugLevel.INFO, "OpCreateRoom()");
			}
			Dictionary<byte, object> dictionary = new Dictionary<byte, object>();
			if (!string.IsNullOrEmpty(opParams.RoomName))
			{
				dictionary[byte.MaxValue] = opParams.RoomName;
			}
			if (opParams.Lobby != null && !string.IsNullOrEmpty(opParams.Lobby.Name))
			{
				dictionary[213] = opParams.Lobby.Name;
				dictionary[212] = (byte)opParams.Lobby.Type;
			}
			if (opParams.ExpectedUsers != null && opParams.ExpectedUsers.Length != 0)
			{
				dictionary[238] = opParams.ExpectedUsers;
			}
			if (opParams.OnGameServer)
			{
				if (opParams.PlayerProperties != null && opParams.PlayerProperties.Count > 0)
				{
					dictionary[249] = opParams.PlayerProperties;
					dictionary[250] = true;
				}
				RoomOptionsToOpParameters(dictionary, opParams.RoomOptions);
			}
			return SendOperation(227, dictionary, new SendOptions
			{
				Reliability = true
			});
		}

		public virtual bool OpJoinRoom(EnterRoomParams opParams)
		{
			if ((int)DebugOut >= 3)
			{
				base.Listener.DebugReturn(DebugLevel.INFO, "OpJoinRoom()");
			}
			Dictionary<byte, object> dictionary = new Dictionary<byte, object>();
			if (!string.IsNullOrEmpty(opParams.RoomName))
			{
				dictionary[byte.MaxValue] = opParams.RoomName;
			}
			if (opParams.CreateIfNotExists)
			{
				dictionary[215] = (byte)1;
				if (opParams.Lobby != null)
				{
					dictionary[213] = opParams.Lobby.Name;
					dictionary[212] = (byte)opParams.Lobby.Type;
				}
			}
			if (opParams.RejoinOnly)
			{
				dictionary[215] = (byte)3;
			}
			if (opParams.ExpectedUsers != null && opParams.ExpectedUsers.Length != 0)
			{
				dictionary[238] = opParams.ExpectedUsers;
			}
			if (opParams.OnGameServer)
			{
				if (opParams.PlayerProperties != null && opParams.PlayerProperties.Count > 0)
				{
					dictionary[249] = opParams.PlayerProperties;
					dictionary[250] = true;
				}
				if (opParams.CreateIfNotExists)
				{
					RoomOptionsToOpParameters(dictionary, opParams.RoomOptions);
				}
			}
			return SendOperation(226, dictionary, new SendOptions
			{
				Reliability = true
			});
		}

		public virtual bool OpJoinRandomRoom(OpJoinRandomRoomParams opJoinRandomRoomParams)
		{
			if ((int)DebugOut >= 3)
			{
				base.Listener.DebugReturn(DebugLevel.INFO, "OpJoinRandomRoom()");
			}
			Hashtable hashtable = new Hashtable();
			hashtable.MergeStringKeys(opJoinRandomRoomParams.ExpectedCustomRoomProperties);
			if (opJoinRandomRoomParams.ExpectedMaxPlayers > 0)
			{
				hashtable[byte.MaxValue] = opJoinRandomRoomParams.ExpectedMaxPlayers;
			}
			Dictionary<byte, object> dictionary = new Dictionary<byte, object>();
			if (hashtable.Count > 0)
			{
				dictionary[248] = hashtable;
			}
			if (opJoinRandomRoomParams.MatchingType != 0)
			{
				dictionary[223] = (byte)opJoinRandomRoomParams.MatchingType;
			}
			if (opJoinRandomRoomParams.TypedLobby != null && !string.IsNullOrEmpty(opJoinRandomRoomParams.TypedLobby.Name))
			{
				dictionary[213] = opJoinRandomRoomParams.TypedLobby.Name;
				dictionary[212] = (byte)opJoinRandomRoomParams.TypedLobby.Type;
			}
			if (!string.IsNullOrEmpty(opJoinRandomRoomParams.SqlLobbyFilter))
			{
				dictionary[245] = opJoinRandomRoomParams.SqlLobbyFilter;
			}
			if (opJoinRandomRoomParams.ExpectedUsers != null && opJoinRandomRoomParams.ExpectedUsers.Length != 0)
			{
				dictionary[238] = opJoinRandomRoomParams.ExpectedUsers;
			}
			return SendOperation(225, dictionary, new SendOptions
			{
				Reliability = true
			});
		}

		public virtual bool OpLeaveRoom(bool becomeInactive, bool sendAuthCookie = false)
		{
			Dictionary<byte, object> dictionary = new Dictionary<byte, object>();
			if (becomeInactive)
			{
				dictionary[233] = true;
			}
			if (sendAuthCookie)
			{
				dictionary[234] = 2;
			}
			return SendOperation(254, dictionary, new SendOptions
			{
				Reliability = true
			});
		}

		public virtual bool OpGetGameList(TypedLobby lobby, string queryData)
		{
			if ((int)DebugOut >= 3)
			{
				base.Listener.DebugReturn(DebugLevel.INFO, "OpGetGameList()");
			}
			if (lobby == null)
			{
				if ((int)DebugOut >= 3)
				{
					base.Listener.DebugReturn(DebugLevel.INFO, "OpGetGameList not sent. Lobby cannot be null.");
				}
				return false;
			}
			if (lobby.Type != LobbyType.SqlLobby)
			{
				if ((int)DebugOut >= 3)
				{
					base.Listener.DebugReturn(DebugLevel.INFO, "OpGetGameList not sent. LobbyType must be SqlLobby.");
				}
				return false;
			}
			Dictionary<byte, object> dictionary = new Dictionary<byte, object>();
			dictionary[213] = lobby.Name;
			dictionary[212] = (byte)lobby.Type;
			dictionary[245] = queryData;
			return SendOperation(217, dictionary, new SendOptions
			{
				Reliability = true
			});
		}

		public virtual bool OpFindFriends(string[] friendsToFind)
		{
			Dictionary<byte, object> dictionary = new Dictionary<byte, object>();
			if (friendsToFind != null && friendsToFind.Length != 0)
			{
				dictionary[1] = friendsToFind;
			}
			return SendOperation(222, dictionary, new SendOptions
			{
				Reliability = true
			});
		}

		public bool OpSetCustomPropertiesOfActor(int actorNr, Hashtable actorProperties)
		{
			return OpSetPropertiesOfActor(actorNr, actorProperties.StripToStringKeys());
		}

		protected internal bool OpSetPropertiesOfActor(int actorNr, Hashtable actorProperties, Hashtable expectedProperties = null, WebFlags webflags = null)
		{
			if ((int)DebugOut >= 3)
			{
				base.Listener.DebugReturn(DebugLevel.INFO, "OpSetPropertiesOfActor()");
			}
			if (actorNr <= 0 || actorProperties == null)
			{
				if ((int)DebugOut >= 3)
				{
					base.Listener.DebugReturn(DebugLevel.INFO, "OpSetPropertiesOfActor not sent. ActorNr must be > 0 and actorProperties != null.");
				}
				return false;
			}
			Dictionary<byte, object> dictionary = new Dictionary<byte, object>();
			dictionary.Add(251, actorProperties);
			dictionary.Add(254, actorNr);
			dictionary.Add(250, true);
			if (expectedProperties != null && expectedProperties.Count != 0)
			{
				dictionary.Add(231, expectedProperties);
			}
			if (webflags != null && webflags.HttpForward)
			{
				dictionary[234] = webflags.WebhookFlags;
			}
			return SendOperation(252, dictionary, new SendOptions
			{
				Reliability = true
			});
		}

		protected void OpSetPropertyOfRoom(byte propCode, object value)
		{
			Hashtable hashtable = new Hashtable();
			hashtable[propCode] = value;
			OpSetPropertiesOfRoom(hashtable);
		}

		public bool OpSetCustomPropertiesOfRoom(Hashtable gameProperties)
		{
			return OpSetPropertiesOfRoom(gameProperties.StripToStringKeys());
		}

		protected internal bool OpSetPropertiesOfRoom(Hashtable gameProperties, Hashtable expectedProperties = null, WebFlags webflags = null)
		{
			if ((int)DebugOut >= 3)
			{
				base.Listener.DebugReturn(DebugLevel.INFO, "OpSetPropertiesOfRoom()");
			}
			Dictionary<byte, object> dictionary = new Dictionary<byte, object>();
			dictionary.Add(251, gameProperties);
			dictionary.Add(250, true);
			if (expectedProperties != null && expectedProperties.Count != 0)
			{
				dictionary.Add(231, expectedProperties);
			}
			if (webflags != null && webflags.HttpForward)
			{
				dictionary[234] = webflags.WebhookFlags;
			}
			return SendOperation(252, dictionary, new SendOptions
			{
				Reliability = true
			});
		}

		public virtual bool OpAuthenticate(string appId, string appVersion, AuthenticationValues authValues, string regionCode, bool getLobbyStatistics)
		{
			if ((int)DebugOut >= 3)
			{
				base.Listener.DebugReturn(DebugLevel.INFO, "OpAuthenticate()");
			}
			Dictionary<byte, object> dictionary = new Dictionary<byte, object>();
			if (getLobbyStatistics)
			{
				dictionary[211] = true;
			}
			if (authValues != null && authValues.Token != null)
			{
				dictionary[221] = authValues.Token;
				return SendOperation(230, dictionary, new SendOptions
				{
					Reliability = true
				});
			}
			dictionary[220] = appVersion;
			dictionary[224] = appId;
			if (!string.IsNullOrEmpty(regionCode))
			{
				dictionary[210] = regionCode;
			}
			if (authValues != null)
			{
				if (!string.IsNullOrEmpty(authValues.UserId))
				{
					dictionary[225] = authValues.UserId;
				}
				if (authValues.AuthType != CustomAuthenticationType.None)
				{
					dictionary[217] = (byte)authValues.AuthType;
					if (!string.IsNullOrEmpty(authValues.Token))
					{
						dictionary[221] = authValues.Token;
					}
					else
					{
						if (!string.IsNullOrEmpty(authValues.AuthGetParameters))
						{
							dictionary[216] = authValues.AuthGetParameters;
						}
						if (authValues.AuthPostData != null)
						{
							dictionary[214] = authValues.AuthPostData;
						}
					}
				}
			}
			return SendOperation(230, dictionary, new SendOptions
			{
				Reliability = true,
				Encrypt = base.IsEncryptionAvailable
			});
		}

		public virtual bool OpAuthenticateOnce(string appId, string appVersion, AuthenticationValues authValues, string regionCode, EncryptionMode encryptionMode, ConnectionProtocol expectedProtocol)
		{
			if ((int)DebugOut >= 3)
			{
				base.Listener.DebugReturn(DebugLevel.INFO, "OpAuthenticate()");
			}
			Dictionary<byte, object> dictionary = new Dictionary<byte, object>();
			if (authValues != null && authValues.Token != null)
			{
				dictionary[221] = authValues.Token;
				return SendOperation(231, dictionary, new SendOptions
				{
					Reliability = true
				});
			}
			dictionary[195] = (byte)expectedProtocol;
			dictionary[193] = (byte)encryptionMode;
			dictionary[220] = appVersion;
			dictionary[224] = appId;
			if (!string.IsNullOrEmpty(regionCode))
			{
				dictionary[210] = regionCode;
			}
			if (authValues != null)
			{
				if (!string.IsNullOrEmpty(authValues.UserId))
				{
					dictionary[225] = authValues.UserId;
				}
				if (authValues.AuthType != CustomAuthenticationType.None)
				{
					dictionary[217] = (byte)authValues.AuthType;
					if (!string.IsNullOrEmpty(authValues.Token))
					{
						dictionary[221] = authValues.Token;
					}
					else
					{
						if (!string.IsNullOrEmpty(authValues.AuthGetParameters))
						{
							dictionary[216] = authValues.AuthGetParameters;
						}
						if (authValues.AuthPostData != null)
						{
							dictionary[214] = authValues.AuthPostData;
						}
					}
				}
			}
			return SendOperation(231, dictionary, new SendOptions
			{
				Reliability = true,
				Encrypt = base.IsEncryptionAvailable
			});
		}

		public virtual bool OpChangeGroups(byte[] groupsToRemove, byte[] groupsToAdd)
		{
			if ((int)DebugOut >= 5)
			{
				base.Listener.DebugReturn(DebugLevel.ALL, "OpChangeGroups()");
			}
			Dictionary<byte, object> dictionary = new Dictionary<byte, object>();
			if (groupsToRemove != null)
			{
				dictionary[239] = groupsToRemove;
			}
			if (groupsToAdd != null)
			{
				dictionary[238] = groupsToAdd;
			}
			return SendOperation(248, dictionary, new SendOptions
			{
				Reliability = true
			});
		}

		public virtual bool OpRaiseEvent(byte eventCode, object customEventContent, RaiseEventOptions raiseEventOptions, SendOptions sendOptions)
		{
			opParameters.Clear();
			opParameters[244] = eventCode;
			if (customEventContent != null)
			{
				opParameters[245] = customEventContent;
			}
			if (raiseEventOptions == null)
			{
				raiseEventOptions = RaiseEventOptions.Default;
			}
			else
			{
				if (raiseEventOptions.CachingOption != 0)
				{
					opParameters[247] = (byte)raiseEventOptions.CachingOption;
				}
				if (raiseEventOptions.Receivers != 0)
				{
					opParameters[246] = (byte)raiseEventOptions.Receivers;
				}
				if (raiseEventOptions.InterestGroup != 0)
				{
					opParameters[240] = raiseEventOptions.InterestGroup;
				}
				if (raiseEventOptions.TargetActors != null)
				{
					opParameters[252] = raiseEventOptions.TargetActors;
				}
				if (raiseEventOptions.Flags.HttpForward)
				{
					opParameters[234] = raiseEventOptions.Flags.WebhookFlags;
				}
			}
			return SendOperation(253, opParameters, sendOptions);
		}

		public virtual bool OpSettings(bool receiveLobbyStats)
		{
			if ((int)DebugOut >= 5)
			{
				base.Listener.DebugReturn(DebugLevel.ALL, "OpSettings()");
			}
			opParameters.Clear();
			if (receiveLobbyStats)
			{
				opParameters[0] = receiveLobbyStats;
			}
			if (opParameters.Count == 0)
			{
				return true;
			}
			return SendOperation(218, opParameters, new SendOptions
			{
				Reliability = true
			});
		}
	}
	public class OpJoinRandomRoomParams
	{
		public Hashtable ExpectedCustomRoomProperties;

		public byte ExpectedMaxPlayers;

		public MatchmakingMode MatchingType;

		public TypedLobby TypedLobby;

		public string SqlLobbyFilter;

		public string[] ExpectedUsers;
	}
	public class EnterRoomParams
	{
		public string RoomName;

		public RoomOptions RoomOptions;

		public TypedLobby Lobby;

		public Hashtable PlayerProperties;

		public bool OnGameServer = true;

		public bool CreateIfNotExists;

		public bool RejoinOnly;

		public string[] ExpectedUsers;
	}
	public class ErrorCode
	{
		public const int Ok = 0;

		public const int OperationNotAllowedInCurrentState = -3;

		[Obsolete("Use InvalidOperation.")]
		public const int InvalidOperationCode = -2;

		public const int InvalidOperation = -2;

		public const int InternalServerError = -1;

		public const int InvalidAuthentication = 32767;

		public const int GameIdAlreadyExists = 32766;

		public const int GameFull = 32765;

		public const int GameClosed = 32764;

		[Obsolete("No longer used, cause random matchmaking is no longer a process.")]
		public const int AlreadyMatched = 32763;

		public const int ServerFull = 32762;

		public const int UserBlocked = 32761;

		public const int NoRandomMatchFound = 32760;

		public const int GameDoesNotExist = 32758;

		public const int MaxCcuReached = 32757;

		public const int InvalidRegion = 32756;

		public const int CustomAuthenticationFailed = 32755;

		public const int AuthenticationTicketExpired = 32753;

		public const int PluginReportedError = 32752;

		public const int PluginMismatch = 32751;

		public const int JoinFailedPeerAlreadyJoined = 32750;

		public const int JoinFailedFoundInactiveJoiner = 32749;

		public const int JoinFailedWithRejoinerNotFound = 32748;

		public const int JoinFailedFoundExcludedUserId = 32747;

		public const int JoinFailedFoundActiveJoiner = 32746;

		public const int HttpLimitReached = 32745;

		public const int ExternalHttpCallFailed = 32744;

		public const int SlotError = 32742;

		public const int InvalidEncryptionParameters = 32741;
	}
	public class ActorProperties
	{
		public const byte PlayerName = byte.MaxValue;

		public const byte IsInactive = 254;

		public const byte UserId = 253;
	}
	public class GamePropertyKey
	{
		public const byte MaxPlayers = byte.MaxValue;

		public const byte IsVisible = 254;

		public const byte IsOpen = 253;

		public const byte PlayerCount = 252;

		public const byte Removed = 251;

		public const byte PropsListedInLobby = 250;

		public const byte CleanupCacheOnLeave = 249;

		public const byte MasterClientId = 248;

		public const byte ExpectedUsers = 247;
	}
	public class EventCode
	{
		public const byte GameList = 230;

		public const byte GameListUpdate = 229;

		public const byte QueueState = 228;

		public const byte Match = 227;

		public const byte AppStats = 226;

		public const byte LobbyStats = 224;

		[Obsolete("TCP routing was removed after becoming obsolete.")]
		public const byte AzureNodeInfo = 210;

		public const byte Join = byte.MaxValue;

		public const byte Leave = 254;

		public const byte PropertiesChanged = 253;

		[Obsolete("Use PropertiesChanged now.")]
		public const byte SetProperties = 253;

		public const byte ErrorInfo = 251;

		public const byte CacheSliceChanged = 250;

		public const byte AuthEvent = 223;
	}
	public class ParameterCode
	{
		public const byte SuppressRoomEvents = 237;

		public const byte EmptyRoomTTL = 236;

		public const byte PlayerTTL = 235;

		public const byte EventForward = 234;

		[Obsolete("Use: IsInactive")]
		public const byte IsComingBack = 233;

		public const byte IsInactive = 233;

		public const byte CheckUserOnJoin = 232;

		public const byte ExpectedValues = 231;

		public const byte Address = 230;

		public const byte PeerCount = 229;

		public const byte GameCount = 228;

		public const byte MasterPeerCount = 227;

		public const byte UserId = 225;

		public const byte ApplicationId = 224;

		public const byte Position = 223;

		public const byte MatchMakingType = 223;

		public const byte GameList = 222;

		public const byte Secret = 221;

		public const byte AppVersion = 220;

		[Obsolete("TCP routing was removed after becoming obsolete.")]
		public const byte AzureNodeInfo = 210;

		[Obsolete("TCP routing was removed after becoming obsolete.")]
		public const byte AzureLocalNodeId = 209;

		[Obsolete("TCP routing was removed after becoming obsolete.")]
		public const byte AzureMasterNodeId = 208;

		public const byte RoomName = byte.MaxValue;

		public const byte Broadcast = 250;

		public const byte ActorList = 252;

		public const byte ActorNr = 254;

		public const byte PlayerProperties = 249;

		public const byte CustomEventContent = 245;

		public const byte Data = 245;

		public const byte Code = 244;

		public const byte GameProperties = 248;

		public const byte Properties = 251;

		public const byte TargetActorNr = 253;

		public const byte ReceiverGroup = 246;

		public const byte Cache = 247;

		public const byte CleanupCacheOnLeave = 241;

		public const byte Group = 240;

		public const byte Remove = 239;

		public const byte PublishUserId = 239;

		public const byte Add = 238;

		public const byte Info = 218;

		public const byte ClientAuthenticationType = 217;

		public const byte ClientAuthenticationParams = 216;

		public const byte JoinMode = 215;

		public const byte ClientAuthenticationData = 214;

		public const byte MasterClientId = 203;

		public const byte FindFriendsRequestList = 1;

		public const byte FindFriendsResponseOnlineList = 1;

		public const byte FindFriendsResponseRoomIdList = 2;

		public const byte LobbyName = 213;

		public const byte LobbyType = 212;

		public const byte LobbyStats = 211;

		public const byte Region = 210;

		public const byte UriPath = 209;

		public const byte WebRpcParameters = 208;

		public const byte WebRpcReturnCode = 207;

		public const byte WebRpcReturnMessage = 206;

		public const byte CacheSliceIndex = 205;

		public const byte Plugins = 204;

		public const byte NickName = 202;

		public const byte PluginName = 201;

		public const byte PluginVersion = 200;

		public const byte ExpectedProtocol = 195;

		public const byte CustomInitData = 194;

		public const byte EncryptionMode = 193;

		public const byte EncryptionData = 192;

		public const byte RoomOptionFlags = 191;
	}
	public class OperationCode
	{
		[Obsolete("Exchanging encrpytion keys is done internally in the lib now. Don't expect this operation-result.")]
		public const byte ExchangeKeysForEncryption = 250;

		[Obsolete]
		public const byte Join = byte.MaxValue;

		public const byte AuthenticateOnce = 231;

		public const byte Authenticate = 230;

		public const byte JoinLobby = 229;

		public const byte LeaveLobby = 228;

		public const byte CreateGame = 227;

		public const byte JoinGame = 226;

		public const byte JoinRandomGame = 225;

		public const byte Leave = 254;

		public const byte RaiseEvent = 253;

		public const byte SetProperties = 252;

		public const byte GetProperties = 251;

		public const byte ChangeGroups = 248;

		public const byte FindFriends = 222;

		public const byte GetLobbyStats = 221;

		public const byte GetRegions = 220;

		public const byte WebRpc = 219;

		public const byte ServerSettings = 218;

		public const byte GetGameList = 217;
	}
	public enum JoinMode : byte
	{
		Default,
		CreateIfNotExists,
		JoinOrRejoin,
		RejoinOnly
	}
	public enum MatchmakingMode : byte
	{
		FillRoom,
		SerialMatching,
		RandomMatching
	}
	public enum ReceiverGroup : byte
	{
		Others,
		All,
		MasterClient
	}
	public enum EventCaching : byte
	{
		DoNotCache = 0,
		[Obsolete]
		MergeCache = 1,
		[Obsolete]
		ReplaceCache = 2,
		[Obsolete]
		RemoveCache = 3,
		AddToRoomCache = 4,
		AddToRoomCacheGlobal = 5,
		RemoveFromRoomCache = 6,
		RemoveFromRoomCacheForActorsLeft = 7,
		SliceIncreaseIndex = 10,
		SliceSetIndex = 11,
		SlicePurgeIndex = 12,
		SlicePurgeUpToIndex = 13
	}
	[Flags]
	public enum PropertyTypeFlag : byte
	{
		None = 0,
		Game = 1,
		Actor = 2,
		GameAndActor = 3
	}
	public class RoomOptions
	{
		private bool isVisible = true;

		private bool isOpen = true;

		public byte MaxPlayers;

		public int PlayerTtl;

		public int EmptyRoomTtl;

		private bool cleanupCacheOnLeave = true;

		public Hashtable CustomRoomProperties;

		public string[] CustomRoomPropertiesForLobby = new string[0];

		public string[] Plugins;

		public bool IsVisible
		{
			get
			{
				return isVisible;
			}
			set
			{
				isVisible = value;
			}
		}

		public bool IsOpen
		{
			get
			{
				return isOpen;
			}
			set
			{
				isOpen = value;
			}
		}

		public bool CleanupCacheOnLeave
		{
			get
			{
				return cleanupCacheOnLeave;
			}
			set
			{
				cleanupCacheOnLeave = value;
			}
		}

		public bool SuppressRoomEvents { get; set; }

		public bool PublishUserId { get; set; }

		public bool DeleteNullProperties { get; set; }
	}
	public class RaiseEventOptions
	{
		public static readonly RaiseEventOptions Default = new RaiseEventOptions();

		public EventCaching CachingOption;

		public byte InterestGroup;

		public int[] TargetActors;

		public ReceiverGroup Receivers;

		[Obsolete("Not used where SendOptions are a parameter too. Use SendOptions.Channel instead.")]
		public byte SequenceChannel;

		public WebFlags Flags = WebFlags.Default;
	}
	public enum LobbyType : byte
	{
		Default = 0,
		SqlLobby = 2,
		AsyncRandomLobby = 3
	}
	public class TypedLobby
	{
		public string Name;

		public LobbyType Type;

		public static readonly TypedLobby Default = new TypedLobby();

		public bool IsDefault
		{
			get
			{
				if (Type == LobbyType.Default)
				{
					return string.IsNullOrEmpty(Name);
				}
				return false;
			}
		}

		public TypedLobby()
		{
			Name = string.Empty;
			Type = LobbyType.Default;
		}

		public TypedLobby(string name, LobbyType type)
		{
			Name = name;
			Type = type;
		}

		public override string ToString()
		{
			return $"lobby '{Name}'[{Type}]";
		}
	}
	public class TypedLobbyInfo : TypedLobby
	{
		public int PlayerCount;

		public int RoomCount;

		public override string ToString()
		{
			return $"TypedLobbyInfo '{Name}'[{Type}] rooms: {RoomCount} players: {PlayerCount}";
		}
	}
	public enum AuthModeOption
	{
		Auth,
		AuthOnce,
		AuthOnceWss
	}
	public enum CustomAuthenticationType : byte
	{
		Custom = 0,
		Steam = 1,
		Facebook = 2,
		Oculus = 3,
		PlayStation = 4,
		Xbox = 5,
		None = byte.MaxValue
	}
	public class AuthenticationValues
	{
		private CustomAuthenticationType authType = CustomAuthenticationType.None;

		public CustomAuthenticationType AuthType
		{
			get
			{
				return authType;
			}
			set
			{
				authType = value;
			}
		}

		public string AuthGetParameters { get; set; }

		public object AuthPostData { get; private set; }

		public string Token { get; set; }

		public string UserId { get; set; }

		public AuthenticationValues()
		{
		}

		public AuthenticationValues(string userId)
		{
			UserId = userId;
		}

		public virtual void SetAuthPostData(string stringData)
		{
			AuthPostData = (string.IsNullOrEmpty(stringData) ? null : stringData);
		}

		public virtual void SetAuthPostData(byte[] byteData)
		{
			AuthPostData = byteData;
		}

		public virtual void AddAuthParameter(string key, string value)
		{
			string text = (string.IsNullOrEmpty(AuthGetParameters) ? "" : "&");
			AuthGetParameters = $"{AuthGetParameters}{text}{Uri.EscapeDataString(key)}={Uri.EscapeDataString(value)}";
		}

		public override string ToString()
		{
			return $"AuthenticationValues UserId: {UserId}, GetParameters: {AuthGetParameters} Token available: {Token != null}";
		}
	}
	public abstract class PhotonPing : IDisposable
	{
		public string DebugString = "";

		public bool Successful;

		protected internal bool GotResult;

		protected internal int PingLength = 13;

		protected internal byte[] PingBytes = new byte[13]
		{
			125, 125, 125, 125, 125, 125, 125, 125, 125, 125,
			125, 125, 0
		};

		protected internal byte PingId;

		public virtual bool StartPing(string ip)
		{
			throw new NotImplementedException();
		}

		public virtual bool Done()
		{
			throw new NotImplementedException();
		}

		public virtual void Dispose()
		{
			throw new NotImplementedException();
		}

		protected internal void Init()
		{
			GotResult = false;
			Successful = false;
			PingId = (byte)(Environment.TickCount % 255);
		}
	}
	public class PingMono : PhotonPing
	{
		private Socket sock;

		public override bool StartPing(string ip)
		{
			Init();
			try
			{
				if (ip.Contains("."))
				{
					sock = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
				}
				else
				{
					sock = new Socket(AddressFamily.InterNetworkV6, SocketType.Dgram, ProtocolType.Udp);
				}
				sock.ReceiveTimeout = 5000;
				sock.Connect(ip, 5055);
				PingBytes[PingBytes.Length - 1] = PingId;
				sock.Send(PingBytes);
				PingBytes[PingBytes.Length - 1] = (byte)(PingId - 1);
			}
			catch (Exception value)
			{
				sock = null;
				Console.WriteLine(value);
			}
			return false;
		}

		public override bool Done()
		{
			if (GotResult || sock == null)
			{
				return true;
			}
			if (sock.Available <= 0)
			{
				return false;
			}
			int num = sock.Receive(PingBytes, SocketFlags.None);
			if (PingBytes[PingBytes.Length - 1] != PingId || num != PingLength)
			{
				DebugString += " ReplyMatch is false! ";
			}
			Successful = num == PingBytes.Length && PingBytes[PingBytes.Length - 1] == PingId;
			GotResult = true;
			return true;
		}

		public override void Dispose()
		{
			try
			{
				sock.Close();
			}
			catch
			{
			}
			sock = null;
		}
	}
	public class Player
	{
		private int actorID = -1;

		public readonly bool IsLocal;

		private string nickName;

		public object TagObject;

		protected internal Room RoomReference { get; set; }

		public int ID => actorID;

		public string NickName
		{
			get
			{
				return nickName;
			}
			set
			{
				if (string.IsNullOrEmpty(nickName) || !nickName.Equals(value))
				{
					nickName = value;
					if (IsLocal && RoomReference != null && RoomReference.IsLocalClientInside)
					{
						SetPlayerNameProperty();
					}
				}
			}
		}

		public string UserId { get; internal set; }

		public bool IsMasterClient
		{
			get
			{
				if (RoomReference == null)
				{
					return false;
				}
				return ID == RoomReference.MasterClientId;
			}
		}

		public bool IsInactive { get; set; }

		public Hashtable CustomProperties { get; private set; }

		public Hashtable AllProperties
		{
			get
			{
				Hashtable hashtable = new Hashtable();
				hashtable.Merge(CustomProperties);
				hashtable[byte.MaxValue] = nickName;
				return hashtable;
			}
		}

		protected internal Player(string nickName, int actorID, bool isLocal)
			: this(nickName, actorID, isLocal, null)
		{
		}

		protected internal Player(string nickName, int actorID, bool isLocal, Hashtable playerProperties)
		{
			IsLocal = isLocal;
			this.actorID = actorID;
			NickName = nickName;
			CustomProperties = new Hashtable();
			InternalCacheProperties(playerProperties);
		}

		public Player Get(int id)
		{
			if (RoomReference == null)
			{
				return null;
			}
			return RoomReference.GetPlayer(id);
		}

		public Player GetNext()
		{
			return GetNextFor(ID);
		}

		public Player GetNextFor(Player currentPlayer)
		{
			if (currentPlayer == null)
			{
				return null;
			}
			return GetNextFor(currentPlayer.ID);
		}

		public Player GetNextFor(int currentPlayerId)
		{
			if (RoomReference == null || RoomReference.Players == null || RoomReference.Players.Count < 2)
			{
				return null;
			}
			Dictionary<int, Player> players = RoomReference.Players;
			int num = int.MaxValue;
			int num2 = currentPlayerId;
			foreach (int key in players.Keys)
			{
				if (key < num2)
				{
					num2 = key;
				}
				else if (key > currentPlayerId && key < num)
				{
					num = key;
				}
			}
			if (num == int.MaxValue)
			{
				return players[num2];
			}
			return players[num];
		}

		public virtual void InternalCacheProperties(Hashtable properties)
		{
			if (properties == null || properties.Count == 0 || CustomProperties.Equals(properties))
			{
				return;
			}
			if (properties.ContainsKey(byte.MaxValue))
			{
				string text = (string)properties[byte.MaxValue];
				if (text != null)
				{
					if (IsLocal)
					{
						if (!text.Equals(nickName))
						{
							SetPlayerNameProperty();
						}
					}
					else
					{
						NickName = text;
					}
				}
			}
			if (properties.ContainsKey((byte)253))
			{
				UserId = (string)properties[(byte)253];
			}
			if (properties.ContainsKey((byte)254))
			{
				IsInactive = (bool)properties[(byte)254];
			}
			CustomProperties.MergeStringKeys(properties);
			CustomProperties.StripKeysWithNullValues();
		}

		public override string ToString()
		{
			return NickName + " " + SupportClass.DictionaryToString(CustomProperties);
		}

		public string ToStringFull()
		{
			return string.Format("#{0:00} '{1}'{2} {3}", ID, NickName, IsInactive ? " (inactive)" : "", CustomProperties.ToStringFull());
		}

		public override bool Equals(object p)
		{
			if (p is Player player)
			{
				return GetHashCode() == player.GetHashCode();
			}
			return false;
		}

		public override int GetHashCode()
		{
			return ID;
		}

		protected internal void ChangeLocalID(int newID)
		{
			if (IsLocal)
			{
				actorID = newID;
			}
		}

		public void SetCustomProperties(Hashtable propertiesToSet, Hashtable expectedValues = null, WebFlags webFlags = null)
		{
			if (propertiesToSet != null)
			{
				Hashtable hashtable = propertiesToSet.StripToStringKeys();
				Hashtable hashtable2 = expectedValues.StripToStringKeys();
				if (hashtable2 == null || hashtable2.Count == 0)
				{
					CustomProperties.Merge(hashtable);
					CustomProperties.StripKeysWithNullValues();
				}
				if (RoomReference != null && RoomReference.IsLocalClientInside)
				{
					RoomReference.LoadBalancingClient.loadBalancingPeer.OpSetPropertiesOfActor(actorID, hashtable, hashtable2, webFlags);
				}
			}
		}

		private void SetPlayerNameProperty()
		{
			if (RoomReference != null && RoomReference.IsLocalClientInside)
			{
				Hashtable hashtable = new Hashtable();
				hashtable[byte.MaxValue] = nickName;
				RoomReference.LoadBalancingClient.loadBalancingPeer.OpSetPropertiesOfActor(ID, hashtable);
			}
		}
	}
	public class Room : RoomInfo
	{
		protected internal int PlayerTTL;

		protected internal int RoomTTL;

		private Dictionary<int, Player> players = new Dictionary<int, Player>();

		protected internal LoadBalancingClient LoadBalancingClient { get; set; }

		public new string Name
		{
			get
			{
				return name;
			}
			internal set
			{
				name = value;
			}
		}

		public new bool IsOpen
		{
			get
			{
				return isOpen;
			}
			set
			{
				if (!base.IsLocalClientInside)
				{
					LoadBalancingClient.DebugReturn(DebugLevel.WARNING, "Can't set room properties when not in that room.");
				}
				if (value != isOpen)
				{
					LoadBalancingClient.OpSetPropertiesOfRoom(new Hashtable { 
					{
						(byte)253,
						value
					} });
				}
				isOpen = value;
			}
		}

		public new bool IsVisible
		{
			get
			{
				return isVisible;
			}
			set
			{
				if (!base.IsLocalClientInside)
				{
					LoadBalancingClient.DebugReturn(DebugLevel.WARNING, "Can't set room properties when not in that room.");
				}
				if (value != isVisible)
				{
					LoadBalancingClient.OpSetPropertiesOfRoom(new Hashtable { 
					{
						(byte)254,
						value
					} });
				}
				isVisible = value;
			}
		}

		public new byte MaxPlayers
		{
			get
			{
				return maxPlayers;
			}
			set
			{
				if (!base.IsLocalClientInside)
				{
					LoadBalancingClient.DebugReturn(DebugLevel.WARNING, "Can't set room properties when not in that room.");
				}
				if (value != maxPlayers)
				{
					LoadBalancingClient.OpSetPropertiesOfRoom(new Hashtable { 
					{
						byte.MaxValue,
						value
					} });
				}
				maxPlayers = value;
			}
		}

		public new byte PlayerCount
		{
			get
			{
				if (Players == null)
				{
					return 0;
				}
				return (byte)Players.Count;
			}
		}

		public Dictionary<int, Player> Players
		{
			get
			{
				return players;
			}
			private set
			{
				players = value;
			}
		}

		public string[] ExpectedUsers => expectedUsers;

		public int MasterClientId => masterClientId;

		public string[] PropertiesListedInLobby
		{
			get
			{
				return propertiesListedInLobby;
			}
			private set
			{
				propertiesListedInLobby = value;
			}
		}

		public bool AutoCleanUp => autoCleanUp;

		protected internal Room(string roomName, RoomOptions options)
			: base(roomName, options?.CustomRoomProperties)
		{
			if (options != null)
			{
				isVisible = options.IsVisible;
				isOpen = options.IsOpen;
				maxPlayers = options.MaxPlayers;
				propertiesListedInLobby = options.CustomRoomPropertiesForLobby;
				PlayerTTL = options.PlayerTtl;
				RoomTTL = options.EmptyRoomTtl;
			}
		}

		public virtual void SetCustomProperties(Hashtable propertiesToSet, Hashtable expectedProperties = null, WebFlags webFlags = null)
		{
			Hashtable hashtable = propertiesToSet.StripToStringKeys();
			if (expectedProperties == null || expectedProperties.Count == 0)
			{
				base.CustomProperties.Merge(hashtable);
				base.CustomProperties.StripKeysWithNullValues();
			}
			if (base.IsLocalClientInside)
			{
				LoadBalancingClient.loadBalancingPeer.OpSetPropertiesOfRoom(hashtable, expectedProperties, webFlags);
			}
		}

		public void SetPropertiesListedInLobby(string[] propertiesListedInLobby)
		{
			Hashtable hashtable = new Hashtable();
			hashtable[(byte)250] = propertiesListedInLobby;
			if (LoadBalancingClient.OpSetPropertiesOfRoom(hashtable))
			{
				base.propertiesListedInLobby = propertiesListedInLobby;
			}
		}

		protected internal virtual void RemovePlayer(Player player)
		{
			Players.Remove(player.ID);
			player.RoomReference = null;
		}

		protected internal virtual void RemovePlayer(int id)
		{
			RemovePlayer(GetPlayer(id));
		}

		public bool SetMasterClient(Player masterClientPlayer)
		{
			if (!base.IsLocalClientInside)
			{
				LoadBalancingClient.DebugReturn(DebugLevel.WARNING, "SetMasterClient can only be called for the current room (being in one).");
				return false;
			}
			Hashtable gameProperties = new Hashtable { 
			{
				(byte)248,
				masterClientPlayer.ID
			} };
			Hashtable expectedProperties = new Hashtable { 
			{
				(byte)248,
				MasterClientId
			} };
			return LoadBalancingClient.OpSetPropertiesOfRoom(gameProperties, expectedProperties);
		}

		public virtual bool AddPlayer(Player player)
		{
			if (!Players.ContainsKey(player.ID))
			{
				StorePlayer(player);
				return true;
			}
			return false;
		}

		public virtual Player StorePlayer(Player player)
		{
			Players[player.ID] = player;
			player.RoomReference = this;
			if (MasterClientId == 0 || player.ID < MasterClientId)
			{
				masterClientId = player.ID;
			}
			return player;
		}

		public virtual Player GetPlayer(int id)
		{
			Player value = null;
			Players.TryGetValue(id, out value);
			return value;
		}

		public void ClearExpectedUsers()
		{
			Hashtable hashtable = new Hashtable();
			hashtable[(byte)247] = new string[0];
			Hashtable hashtable2 = new Hashtable();
			hashtable2[(byte)247] = ExpectedUsers;
			LoadBalancingClient.OpSetPropertiesOfRoom(hashtable, hashtable2);
		}

		public override string ToString()
		{
			return string.Format("Room: '{0}' {1},{2} {4}/{3} players.", name, isVisible ? "visible" : "hidden", isOpen ? "open" : "closed", maxPlayers, PlayerCount);
		}

		public new string ToStringFull()
		{
			return string.Format("Room: '{0}' {1},{2} {4}/{3} players.\ncustomProps: {5}", name, isVisible ? "visible" : "hidden", isOpen ? "open" : "closed", maxPlayers, PlayerCount, base.CustomProperties.ToStringFull());
		}
	}
	public class RoomInfo
	{
		protected internal bool removedFromList;

		private Hashtable customProperties = new Hashtable();

		protected byte maxPlayers;

		protected string[] expectedUsers;

		protected bool isOpen = true;

		protected bool isVisible = true;

		protected bool autoCleanUp = true;

		protected string name;

		protected internal int masterClientId;

		protected string[] propertiesListedInLobby;

		public Hashtable CustomProperties => customProperties;

		public string Name => name;

		public int PlayerCount { get; private set; }

		public bool IsLocalClientInside { get; set; }

		public byte MaxPlayers => maxPlayers;

		public bool IsOpen => isOpen;

		public bool IsVisible => isVisible;

		protected internal RoomInfo(string roomName, Hashtable roomProperties)
		{
			InternalCacheProperties(roomProperties);
			name = roomName;
		}

		public override bool Equals(object other)
		{
			if (other is RoomInfo roomInfo)
			{
				return Name.Equals(roomInfo.name);
			}
			return false;
		}

		public override int GetHashCode()
		{
			return name.GetHashCode();
		}

		public override string ToString()
		{
			return string.Format("Room: '{0}' {1},{2} {4}/{3} players.", name, isVisible ? "visible" : "hidden", isOpen ? "open" : "closed", maxPlayers, PlayerCount);
		}

		public string ToStringFull()
		{
			return string.Format("Room: '{0}' {1},{2} {4}/{3} players.\ncustomProps: {5}", name, isVisible ? "visible" : "hidden", isOpen ? "open" : "closed", maxPlayers, PlayerCount, customProperties.ToStringFull());
		}

		protected internal virtual void InternalCacheProperties(Hashtable propertiesToCache)
		{
			if (propertiesToCache == null || propertiesToCache.Count == 0 || customProperties.Equals(propertiesToCache))
			{
				return;
			}
			if (propertiesToCache.ContainsKey((byte)251))
			{
				removedFromList = (bool)propertiesToCache[(byte)251];
				if (removedFromList)
				{
					return;
				}
			}
			if (propertiesToCache.ContainsKey(byte.MaxValue))
			{
				maxPlayers = (byte)propertiesToCache[byte.MaxValue];
			}
			if (propertiesToCache.ContainsKey((byte)253))
			{
				isOpen = (bool)propertiesToCache[(byte)253];
			}
			if (propertiesToCache.ContainsKey((byte)254))
			{
				isVisible = (bool)propertiesToCache[(byte)254];
			}
			if (propertiesToCache.ContainsKey((byte)252))
			{
				PlayerCount = (byte)propertiesToCache[(byte)252];
			}
			if (propertiesToCache.ContainsKey((byte)249))
			{
				autoCleanUp = (bool)propertiesToCache[(byte)249];
			}
			if (propertiesToCache.ContainsKey((byte)248))
			{
				masterClientId = (int)propertiesToCache[(byte)248];
			}
			if (propertiesToCache.ContainsKey((byte)250))
			{
				propertiesListedInLobby = propertiesToCache[(byte)250] as string[];
			}
			if (propertiesToCache.ContainsKey((byte)247))
			{
				expectedUsers = (string[])propertiesToCache[(byte)247];
			}
			customProperties.MergeStringKeys(propertiesToCache);
			customProperties.StripKeysWithNullValues();
		}
	}
	public class WebRpcResponse
	{
		public string Name { get; private set; }

		public int ReturnCode { get; private set; }

		public string DebugMessage { get; private set; }

		public Dictionary<string, object> Parameters { get; private set; }

		public WebRpcResponse(OperationResponse response)
		{
			response.Parameters.TryGetValue(209, out var value);
			Name = value as string;
			response.Parameters.TryGetValue(207, out value);
			ReturnCode = ((value != null) ? ((byte)value) : (-1));
			response.Parameters.TryGetValue(208, out value);
			Parameters = value as Dictionary<string, object>;
			response.Parameters.TryGetValue(206, out value);
			DebugMessage = value as string;
		}

		public string ToStringFull()
		{
			return string.Format("{0}={2}: {1} \"{3}\"", Name, SupportClass.DictionaryToString(Parameters), ReturnCode, DebugMessage);
		}
	}
	public class WebFlags
	{
		public static readonly WebFlags Default = new WebFlags(0);

		public byte WebhookFlags;

		public const byte HttpForwardConst = 1;

		public const byte SendAuthCookieConst = 2;

		public const byte SendSyncConst = 4;

		public const byte SendStateConst = 8;

		public bool HttpForward
		{
			get
			{
				return (WebhookFlags & 1) != 0;
			}
			set
			{
				if (value)
				{
					WebhookFlags |= 1;
				}
				else
				{
					WebhookFlags = (byte)(WebhookFlags & 0xFFFFFFFEu);
				}
			}
		}

		public bool SendAuthCookie
		{
			get
			{
				return (WebhookFlags & 2) != 0;
			}
			set
			{
				if (value)
				{
					WebhookFlags |= 2;
				}
				else
				{
					WebhookFlags = (byte)(WebhookFlags & 0xFFFFFFFDu);
				}
			}
		}

		public bool SendSync
		{
			get
			{
				return (WebhookFlags & 4) != 0;
			}
			set
			{
				if (value)
				{
					WebhookFlags |= 4;
				}
				else
				{
					WebhookFlags = (byte)(WebhookFlags & 0xFFFFFFFBu);
				}
			}
		}

		public bool SendState
		{
			get
			{
				return (WebhookFlags & 8) != 0;
			}
			set
			{
				if (value)
				{
					WebhookFlags |= 8;
				}
				else
				{
					WebhookFlags = (byte)(WebhookFlags & 0xFFFFFFF7u);
				}
			}
		}

		public WebFlags(byte webhookFlags)
		{
			WebhookFlags = webhookFlags;
		}
	}
}
