using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using ExitGames.Client.Photon.LoadBalancing;
using ExitGames.Client.Photon.Voice;
using Il2CppDummyDll;
using POpusCodec;
using POpusCodec.Enums;
using RootMotion.FinalIK;
using UnityEngine;
using UnityEngine.UI;

[assembly: AssemblyVersion("0.0.0.0")]
[Token(Token = "0x2000002")]
public class AndroidAudioInAEC : IAudioPusher<short>, IAudioSource, IDisposable
{
	[Token(Token = "0x2000129")]
	private class DataCallback : AndroidJavaProxy
	{
		[Token(Token = "0x40007D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Action<short[]> callback;

		[Token(Token = "0x40007D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private IntPtr javaBuf;

		[Token(Token = "0x40007D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private int cntFrame;

		[Token(Token = "0x40007DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private int cntShort;

		[Token(Token = "0x6000933")]
		[Address(RVA = "0x132962C", Offset = "0x132962C", VA = "0x132962C")]
		public DataCallback(Action<short[]> callback, IntPtr javaBuf)
		{
		}

		[Token(Token = "0x6000934")]
		[Address(RVA = "0x13296C8", Offset = "0x13296C8", VA = "0x13296C8")]
		public void OnData()
		{
		}

		[Token(Token = "0x6000935")]
		[Address(RVA = "0x1329764", Offset = "0x1329764", VA = "0x1329764")]
		public void OnStop()
		{
		}
	}

	[Token(Token = "0x4000001")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private AndroidJavaObject audioIn;

	[Token(Token = "0x4000002")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private IntPtr javaBuf;

	[Token(Token = "0x4000003")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private DataCallback callback;

	[Token(Token = "0x17000001")]
	public int Channels
	{
		[Token(Token = "0x6000003")]
		[Address(RVA = "0x13296C0", Offset = "0x13296C0", VA = "0x13296C0", Slot = "6")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000002")]
	public int SamplingRate
	{
		[Token(Token = "0x6000004")]
		[Address(RVA = "0x13296B8", Offset = "0x13296B8", VA = "0x13296B8", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x6000001")]
	[Address(RVA = "0x1328B6C", Offset = "0x1328B6C", VA = "0x1328B6C")]
	public AndroidAudioInAEC()
	{
	}

	[Token(Token = "0x6000002")]
	[Address(RVA = "0x1328B74", Offset = "0x1328B74", VA = "0x1328B74", Slot = "4")]
	public void SetCallback(Action<short[]> callback, LocalVoice localVoice)
	{
	}

	[Token(Token = "0x6000005")]
	[Address(RVA = "0x13295A0", Offset = "0x13295A0", VA = "0x13295A0", Slot = "7")]
	public void Dispose()
	{
	}
}
[Token(Token = "0x2000003")]
public class AudioClipWrapper : IAudioReader<float>, IDataReader<float>, IDisposable, IAudioSource
{
	[Token(Token = "0x4000004")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private AudioClip audioClip;

	[Token(Token = "0x4000005")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private int readPos;

	[Token(Token = "0x4000006")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	private float startTime;

	[Token(Token = "0x4000007")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9D60DC", Offset = "0x9D60DC")]
	private bool <Loop>k__BackingField;

	[Token(Token = "0x4000008")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
	private bool playing;

	[Token(Token = "0x17000003")]
	public bool Loop
	{
		[Token(Token = "0x6000006")]
		[Address(RVA = "0x1329770", Offset = "0x1329770", VA = "0x1329770")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DD3F8", Offset = "0x9DD3F8")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000007")]
		[Address(RVA = "0x1329778", Offset = "0x1329778", VA = "0x1329778")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DD408", Offset = "0x9DD408")]
		set
		{
		}
	}

	[Token(Token = "0x17000004")]
	public int SamplingRate
	{
		[Token(Token = "0x600000A")]
		[Address(RVA = "0x1329904", Offset = "0x1329904", VA = "0x1329904", Slot = "6")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000005")]
	public int Channels
	{
		[Token(Token = "0x600000B")]
		[Address(RVA = "0x1329934", Offset = "0x1329934", VA = "0x1329934", Slot = "7")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x6000008")]
	[Address(RVA = "0x1329784", Offset = "0x1329784", VA = "0x1329784")]
	public AudioClipWrapper(AudioClip audioClip)
	{
	}

	[Token(Token = "0x6000009")]
	[Address(RVA = "0x13297C4", Offset = "0x13297C4", VA = "0x13297C4", Slot = "4")]
	public bool Read(float[] buffer)
	{
		return default(bool);
	}

	[Token(Token = "0x600000C")]
	[Address(RVA = "0x1329964", Offset = "0x1329964", VA = "0x1329964", Slot = "5")]
	public void Dispose()
	{
	}
}
[Token(Token = "0x2000004")]
public class AudioOutCapture : MonoBehaviour
{
	[Token(Token = "0x14000001")]
	public event Action<float[], int> OnAudioFrame
	{
		[Token(Token = "0x600000D")]
		[Address(RVA = "0x1329968", Offset = "0x1329968", VA = "0x1329968")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DD418", Offset = "0x9DD418")]
		add
		{
		}
		[Token(Token = "0x600000E")]
		[Address(RVA = "0x1329A10", Offset = "0x1329A10", VA = "0x1329A10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DD428", Offset = "0x9DD428")]
		remove
		{
		}
	}

	[Token(Token = "0x600000F")]
	[Address(RVA = "0x1329AB8", Offset = "0x1329AB8", VA = "0x1329AB8")]
	private void OnAudioFilterRead(float[] frame, int channels)
	{
	}

	[Token(Token = "0x6000010")]
	[Address(RVA = "0x1329B34", Offset = "0x1329B34", VA = "0x1329B34")]
	public AudioOutCapture()
	{
	}
}
[Token(Token = "0x2000005")]
public class AudioStreamPlayer : IAudioOut
{
	[Token(Token = "0x400000A")]
	private const int maxPlayLagMs = 100;

	[Token(Token = "0x400000B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private int maxPlayLagSamples;

	[Token(Token = "0x400000C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	private int playDelaySamples;

	[Token(Token = "0x400000D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private int bufferSamples;

	[Token(Token = "0x400000E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	private int channels;

	[Token(Token = "0x400000F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private int frameSize;

	[Token(Token = "0x4000010")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	private int frameSamples;

	[Token(Token = "0x4000011")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private int streamSamplePos;

	[Token(Token = "0x4000012")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9D60FC", Offset = "0x9D60FC")]
	private int <CurrentBufferLag>k__BackingField;

	[Token(Token = "0x4000013")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private int streamSamplePosAvg;

	[Token(Token = "0x4000014")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private AudioSource source;

	[Token(Token = "0x4000015")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private string logPrefix;

	[Token(Token = "0x4000016")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private bool debugInfo;

	[Token(Token = "0x4000017")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	private int sourceTimeSamplesPrev;

	[Token(Token = "0x4000018")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private int playLoopCount;

	[Token(Token = "0x4000019")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private Queue<float[]> frameQueue;

	[Token(Token = "0x400001A")]
	public const int FRAME_POOL_CAPACITY = 50;

	[Token(Token = "0x400001B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private PrimitiveArrayPool<float> framePool;

	[Token(Token = "0x17000006")]
	public int CurrentBufferLag
	{
		[Token(Token = "0x6000011")]
		[Address(RVA = "0x1329B3C", Offset = "0x1329B3C", VA = "0x1329B3C", Slot = "9")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DD438", Offset = "0x9DD438")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6000012")]
		[Address(RVA = "0x1329B44", Offset = "0x1329B44", VA = "0x1329B44")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DD448", Offset = "0x9DD448")]
		private set
		{
		}
	}

	[Token(Token = "0x17000007")]
	public AudioSource AudioSource
	{
		[Token(Token = "0x6000013")]
		[Address(RVA = "0x1329B4C", Offset = "0x1329B4C", VA = "0x1329B4C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000008")]
	private int playSamplePos
	{
		[Token(Token = "0x6000015")]
		[Address(RVA = "0x1329C28", Offset = "0x1329C28", VA = "0x1329C28")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6000016")]
		[Address(RVA = "0x1329CF8", Offset = "0x1329CF8", VA = "0x1329CF8")]
		set
		{
		}
	}

	[Token(Token = "0x17000009")]
	public bool IsPlaying
	{
		[Token(Token = "0x6000017")]
		[Address(RVA = "0x1329E00", Offset = "0x1329E00", VA = "0x1329E00", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6000014")]
	[Address(RVA = "0x1329B54", Offset = "0x1329B54", VA = "0x1329B54")]
	public AudioStreamPlayer(AudioSource audioSource, string logPrefix, bool debugInfo)
	{
	}

	[Token(Token = "0x6000018")]
	[Address(RVA = "0x1329E30", Offset = "0x1329E30", VA = "0x1329E30", Slot = "5")]
	public void Start(int frequency, int channels, int frameSamples, int playDelayMs)
	{
	}

	[Token(Token = "0x6000019")]
	[Address(RVA = "0x1329FD8", Offset = "0x1329FD8", VA = "0x1329FD8", Slot = "8")]
	public void Service()
	{
	}

	[Token(Token = "0x600001A")]
	[Address(RVA = "0x132A828", Offset = "0x132A828", VA = "0x132A828", Slot = "7")]
	public void OnAudioFrame(float[] frame)
	{
	}

	[Token(Token = "0x600001B")]
	[Address(RVA = "0x132AAF0", Offset = "0x132AAF0", VA = "0x132AAF0", Slot = "6")]
	public void Stop()
	{
	}
}
[Token(Token = "0x2000006")]
public class IOSAudioForceToSpeaker : MonoBehaviour
{
	[Token(Token = "0x600001C")]
	[Address(RVA = "0x1261FD8", Offset = "0x1261FD8", VA = "0x1261FD8")]
	private void PhotonVoiceCreated()
	{
	}

	[Token(Token = "0x600001D")]
	[Address(RVA = "0x1261FDC", Offset = "0x1261FDC", VA = "0x1261FDC")]
	public IOSAudioForceToSpeaker()
	{
	}
}
[Token(Token = "0x2000007")]
public class MicWrapper : IAudioReader<float>, IDataReader<float>, IDisposable, IAudioSource
{
	[Token(Token = "0x400001C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private AudioClip mic;

	[Token(Token = "0x400001D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private string device;

	[Token(Token = "0x400001E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private int micPrevPos;

	[Token(Token = "0x400001F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	private int micLoopCnt;

	[Token(Token = "0x4000020")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private int readAbsPos;

	[Token(Token = "0x1700000A")]
	public int SamplingRate
	{
		[Token(Token = "0x600001F")]
		[Address(RVA = "0x1262244", Offset = "0x1262244", VA = "0x1262244", Slot = "6")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x1700000B")]
	public int Channels
	{
		[Token(Token = "0x6000020")]
		[Address(RVA = "0x1262274", Offset = "0x1262274", VA = "0x1262274", Slot = "7")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x600001E")]
	[Address(RVA = "0x1261FE4", Offset = "0x1261FE4", VA = "0x1261FE4")]
	public MicWrapper(string device, int suggestedFrequency)
	{
	}

	[Token(Token = "0x6000021")]
	[Address(RVA = "0x12622A4", Offset = "0x12622A4", VA = "0x12622A4", Slot = "5")]
	public void Dispose()
	{
	}

	[Token(Token = "0x6000022")]
	[Address(RVA = "0x12622B0", Offset = "0x12622B0", VA = "0x12622B0", Slot = "4")]
	public bool Read(float[] buffer)
	{
		return default(bool);
	}
}
[Token(Token = "0x2000008")]
public class SpeexDSP : MonoBehaviour
{
	[Token(Token = "0x200012A")]
	private class Logger : ExitGames.Client.Photon.Voice.ILogger
	{
		[Token(Token = "0x6000936")]
		[Address(RVA = "0x1D87F1C", Offset = "0x1D87F1C", VA = "0x1D87F1C", Slot = "4")]
		public void LogError(string fmt, params object[] args)
		{
		}

		[Token(Token = "0x6000937")]
		[Address(RVA = "0x1D87F94", Offset = "0x1D87F94", VA = "0x1D87F94", Slot = "5")]
		public void LogWarning(string fmt, params object[] args)
		{
		}

		[Token(Token = "0x6000938")]
		[Address(RVA = "0x1D8800C", Offset = "0x1D8800C", VA = "0x1D8800C", Slot = "6")]
		public void LogInfo(string fmt, params object[] args)
		{
		}

		[Token(Token = "0x6000939")]
		[Address(RVA = "0x1D88084", Offset = "0x1D88084", VA = "0x1D88084", Slot = "7")]
		public void LogDebug(string fmt, params object[] args)
		{
		}

		[Token(Token = "0x600093A")]
		[Address(RVA = "0x1D87DF0", Offset = "0x1D87DF0", VA = "0x1D87DF0")]
		public Logger()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x200012B")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9D5F5C", Offset = "0x9D5F5C")]
	private sealed class <>c
	{
		[Token(Token = "0x40007DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly <>c <>9;

		[Token(Token = "0x40007DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static Func<long> <>9__29_0;

		[Token(Token = "0x600093C")]
		[Address(RVA = "0x1D87EEC", Offset = "0x1D87EEC", VA = "0x1D87EEC")]
		public <>c()
		{
		}

		[Token(Token = "0x600093D")]
		[Address(RVA = "0x1D87EF4", Offset = "0x1D87EF4", VA = "0x1D87EF4")]
		internal long <PhotonVoiceCreated>b__29_0()
		{
			return default(long);
		}
	}

	[Token(Token = "0x4000021")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9D610C", Offset = "0x9D610C")]
	public bool Windows;

	[Token(Token = "0x4000022")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
	public bool Mac;

	[Token(Token = "0x4000023")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9D6144", Offset = "0x9D6144")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9D6144", Offset = "0x9D6144")]
	public bool AEC;

	[Token(Token = "0x4000024")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public int AECPlaybackDelayMs;

	[Token(Token = "0x4000025")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public int AECFilterLengthMs;

	[Token(Token = "0x4000026")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public bool Denoise;

	[Token(Token = "0x4000027")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x25")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9D61A4", Offset = "0x9D61A4")]
	public bool AGC;

	[Token(Token = "0x4000028")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9D61DC", Offset = "0x9D61DC")]
	public float AGCLevel;

	[Token(Token = "0x4000029")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public int AECPlayDelayCurrentFrames;

	[Token(Token = "0x400002A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public bool AECLatencyDetect;

	[Token(Token = "0x400002B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private SpeexProcessor proc;

	[Token(Token = "0x400002C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9D61F8", Offset = "0x9D61F8")]
	private bool <Active>k__BackingField;

	[Token(Token = "0x400002D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x41")]
	private bool prevAEC;

	[Token(Token = "0x400002E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	private int aecLDState;

	[Token(Token = "0x400002F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private float aecLDStart;

	[Token(Token = "0x4000030")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private AudioSource aecLDPing;

	[Token(Token = "0x1700000C")]
	public SpeexProcessor Processor
	{
		[Token(Token = "0x6000023")]
		[Address(RVA = "0x1D86FCC", Offset = "0x1D86FCC", VA = "0x1D86FCC")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700000D")]
	public bool Active
	{
		[Token(Token = "0x6000024")]
		[Address(RVA = "0x1D86FD4", Offset = "0x1D86FD4", VA = "0x1D86FD4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DD458", Offset = "0x9DD458")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000025")]
		[Address(RVA = "0x1D86FDC", Offset = "0x1D86FDC", VA = "0x1D86FDC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DD468", Offset = "0x9DD468")]
		private set
		{
		}
	}

	[Token(Token = "0x6000026")]
	[Address(RVA = "0x1D86FE8", Offset = "0x1D86FE8", VA = "0x1D86FE8")]
	public void ResetAEC()
	{
	}

	[Token(Token = "0x6000027")]
	[Address(RVA = "0x1D86FFC", Offset = "0x1D86FFC", VA = "0x1D86FFC")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000028")]
	[Address(RVA = "0x1D8704C", Offset = "0x1D8704C", VA = "0x1D8704C")]
	private void Start()
	{
	}

	[Token(Token = "0x6000029")]
	[Address(RVA = "0x1D87050", Offset = "0x1D87050", VA = "0x1D87050")]
	private void UpdateProcProps()
	{
	}

	[Token(Token = "0x600002A")]
	[Address(RVA = "0x1D87298", Offset = "0x1D87298", VA = "0x1D87298")]
	private void setOutputListener(bool set)
	{
	}

	[Token(Token = "0x600002B")]
	[Address(RVA = "0x1D87760", Offset = "0x1D87760", VA = "0x1D87760")]
	private void Update()
	{
	}

	[Token(Token = "0x600002C")]
	[Address(RVA = "0x1D874CC", Offset = "0x1D874CC", VA = "0x1D874CC")]
	private void InitAECLatencyDetect()
	{
	}

	[Token(Token = "0x600002D")]
	[Address(RVA = "0x1D8789C", Offset = "0x1D8789C", VA = "0x1D8789C")]
	private void PhotonVoiceCreated(LocalVoice localVoice)
	{
	}

	[Token(Token = "0x600002E")]
	[Address(RVA = "0x1D87DF8", Offset = "0x1D87DF8", VA = "0x1D87DF8")]
	private void PhotonVoiceRemoved()
	{
	}

	[Token(Token = "0x600002F")]
	[Address(RVA = "0x1D87E4C", Offset = "0x1D87E4C", VA = "0x1D87E4C")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6000030")]
	[Address(RVA = "0x1D87DFC", Offset = "0x1D87DFC", VA = "0x1D87DFC")]
	private void reset()
	{
	}

	[Token(Token = "0x6000031")]
	[Address(RVA = "0x1D87E50", Offset = "0x1D87E50", VA = "0x1D87E50")]
	public SpeexDSP()
	{
	}
}
[Token(Token = "0x2000009")]
public class BulletHole : MonoBehaviour
{
	[Token(Token = "0x200012C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9D5F6C", Offset = "0x9D5F6C")]
	private sealed class <DestroyDelayed>d__2 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40007DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40007DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40007DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public BulletHole <>4__this;

		[Token(Token = "0x1700017D")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000941")]
			[Address(RVA = "0x132AD20", Offset = "0x132AD20", VA = "0x132AD20", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700017E")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000943")]
			[Address(RVA = "0x132AD90", Offset = "0x132AD90", VA = "0x132AD90", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600093E")]
		[Address(RVA = "0x132ABE4", Offset = "0x132ABE4", VA = "0x132ABE4")]
		[DebuggerHidden]
		public <DestroyDelayed>d__2(int <>1__state)
		{
		}

		[Token(Token = "0x600093F")]
		[Address(RVA = "0x132AC20", Offset = "0x132AC20", VA = "0x132AC20", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000940")]
		[Address(RVA = "0x132AC24", Offset = "0x132AC24", VA = "0x132AC24", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000942")]
		[Address(RVA = "0x132AD28", Offset = "0x132AD28", VA = "0x132AD28", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000031")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float lifeTime;

	[Token(Token = "0x6000032")]
	[Address(RVA = "0x132AB44", Offset = "0x132AB44", VA = "0x132AB44")]
	private void Start()
	{
	}

	[Token(Token = "0x6000033")]
	[Address(RVA = "0x132AB70", Offset = "0x132AB70", VA = "0x132AB70")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9DD478", Offset = "0x9DD478")]
	private IEnumerator DestroyDelayed()
	{
		return null;
	}

	[Token(Token = "0x6000034")]
	[Address(RVA = "0x132AC10", Offset = "0x132AC10", VA = "0x132AC10")]
	public BulletHole()
	{
	}
}
namespace SimpleJSON
{
	[Token(Token = "0x200000A")]
	public enum JSONNodeType
	{
		[Token(Token = "0x4000033")]
		Array = 1,
		[Token(Token = "0x4000034")]
		Object = 2,
		[Token(Token = "0x4000035")]
		String = 3,
		[Token(Token = "0x4000036")]
		Number = 4,
		[Token(Token = "0x4000037")]
		NullValue = 5,
		[Token(Token = "0x4000038")]
		Boolean = 6,
		[Token(Token = "0x4000039")]
		None = 7,
		[Token(Token = "0x400003A")]
		Custom = 255
	}
	[Token(Token = "0x200000B")]
	public enum JSONTextMode
	{
		[Token(Token = "0x400003C")]
		Compact,
		[Token(Token = "0x400003D")]
		Indent
	}
	[Token(Token = "0x200000C")]
	[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0x9D4DDC", Offset = "0x9D4DDC")]
	public abstract class JSONNode
	{
		[Token(Token = "0x200012D")]
		public struct Enumerator
		{
			[Token(Token = "0x20001B1")]
			private enum Type
			{
				[Token(Token = "0x4000A78")]
				None,
				[Token(Token = "0x4000A79")]
				Array,
				[Token(Token = "0x4000A7A")]
				Object
			}

			[Token(Token = "0x40007E0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private Type type;

			[Token(Token = "0x40007E1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private Dictionary<string, JSONNode>.Enumerator m_Object;

			[Token(Token = "0x40007E2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private List<JSONNode>.Enumerator m_Array;

			[Token(Token = "0x1700017F")]
			public bool IsValid
			{
				[Token(Token = "0x6000944")]
				[Address(RVA = "0xAB6470", Offset = "0xAB6470", VA = "0xAB6470")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x17000180")]
			public KeyValuePair<string, JSONNode> Current
			{
				[Token(Token = "0x6000947")]
				[Address(RVA = "0xAB6504", Offset = "0xAB6504", VA = "0xAB6504")]
				get
				{
					return default(KeyValuePair<string, JSONNode>);
				}
			}

			[Token(Token = "0x6000945")]
			[Address(RVA = "0xAB6480", Offset = "0xAB6480", VA = "0xAB6480")]
			public Enumerator(List<JSONNode>.Enumerator aArrayEnum)
			{
			}

			[Token(Token = "0x6000946")]
			[Address(RVA = "0xAB64C0", Offset = "0xAB64C0", VA = "0xAB64C0")]
			public Enumerator(Dictionary<string, JSONNode>.Enumerator aDictEnum)
			{
			}

			[Token(Token = "0x6000948")]
			[Address(RVA = "0xAB650C", Offset = "0xAB650C", VA = "0xAB650C")]
			public bool MoveNext()
			{
				return default(bool);
			}
		}

		[Token(Token = "0x200012E")]
		public struct ValueEnumerator
		{
			[Token(Token = "0x40007E3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private Enumerator m_Enumerator;

			[Token(Token = "0x17000181")]
			public JSONNode Current
			{
				[Token(Token = "0x600094C")]
				[Address(RVA = "0xAB671C", Offset = "0xAB671C", VA = "0xAB671C")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000949")]
			[Address(RVA = "0xAB6674", Offset = "0xAB6674", VA = "0xAB6674")]
			public ValueEnumerator(List<JSONNode>.Enumerator aArrayEnum)
			{
			}

			[Token(Token = "0x600094A")]
			[Address(RVA = "0xAB66B8", Offset = "0xAB66B8", VA = "0xAB66B8")]
			public ValueEnumerator(Dictionary<string, JSONNode>.Enumerator aDictEnum)
			{
			}

			[Token(Token = "0x600094B")]
			[Address(RVA = "0xAB6700", Offset = "0xAB6700", VA = "0xAB6700")]
			public ValueEnumerator(Enumerator aEnumerator)
			{
			}

			[Token(Token = "0x600094D")]
			[Address(RVA = "0xAB6724", Offset = "0xAB6724", VA = "0xAB6724")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600094E")]
			[Address(RVA = "0xAB672C", Offset = "0xAB672C", VA = "0xAB672C")]
			public ValueEnumerator GetEnumerator()
			{
				return default(ValueEnumerator);
			}
		}

		[Token(Token = "0x200012F")]
		public struct KeyEnumerator
		{
			[Token(Token = "0x40007E4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private Enumerator m_Enumerator;

			[Token(Token = "0x17000182")]
			public string Current
			{
				[Token(Token = "0x6000952")]
				[Address(RVA = "0xAB6608", Offset = "0xAB6608", VA = "0xAB6608")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600094F")]
			[Address(RVA = "0xAB6560", Offset = "0xAB6560", VA = "0xAB6560")]
			public KeyEnumerator(List<JSONNode>.Enumerator aArrayEnum)
			{
			}

			[Token(Token = "0x6000950")]
			[Address(RVA = "0xAB65A4", Offset = "0xAB65A4", VA = "0xAB65A4")]
			public KeyEnumerator(Dictionary<string, JSONNode>.Enumerator aDictEnum)
			{
			}

			[Token(Token = "0x6000951")]
			[Address(RVA = "0xAB65EC", Offset = "0xAB65EC", VA = "0xAB65EC")]
			public KeyEnumerator(Enumerator aEnumerator)
			{
			}

			[Token(Token = "0x6000953")]
			[Address(RVA = "0xAB6610", Offset = "0xAB6610", VA = "0xAB6610")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000954")]
			[Address(RVA = "0xAB6618", Offset = "0xAB6618", VA = "0xAB6618")]
			public KeyEnumerator GetEnumerator()
			{
				return default(KeyEnumerator);
			}
		}

		[Token(Token = "0x2000130")]
		public class LinqEnumerator : IEnumerator<KeyValuePair<string, JSONNode>>, IEnumerator, IDisposable, IEnumerable<KeyValuePair<string, JSONNode>>, IEnumerable
		{
			[Token(Token = "0x40007E5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private JSONNode m_Node;

			[Token(Token = "0x40007E6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private Enumerator m_Enumerator;

			[Token(Token = "0x17000183")]
			public KeyValuePair<string, JSONNode> Current
			{
				[Token(Token = "0x6000956")]
				[Address(RVA = "0x1D84AC0", Offset = "0x1D84AC0", VA = "0x1D84AC0", Slot = "4")]
				get
				{
					return default(KeyValuePair<string, JSONNode>);
				}
			}

			[Token(Token = "0x17000184")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000957")]
				[Address(RVA = "0x1D84AC8", Offset = "0x1D84AC8", VA = "0x1D84AC8", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000955")]
			[Address(RVA = "0x1D849F0", Offset = "0x1D849F0", VA = "0x1D849F0")]
			internal LinqEnumerator(JSONNode aNode)
			{
			}

			[Token(Token = "0x6000958")]
			[Address(RVA = "0x1D84B34", Offset = "0x1D84B34", VA = "0x1D84B34", Slot = "6")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000959")]
			[Address(RVA = "0x1D84B3C", Offset = "0x1D84B3C", VA = "0x1D84B3C", Slot = "5")]
			public void Dispose()
			{
			}

			[Token(Token = "0x600095A")]
			[Address(RVA = "0x1D84B5C", Offset = "0x1D84B5C", VA = "0x1D84B5C", Slot = "9")]
			public IEnumerator<KeyValuePair<string, JSONNode>> GetEnumerator()
			{
				return null;
			}

			[Token(Token = "0x600095B")]
			[Address(RVA = "0x1D84BC0", Offset = "0x1D84BC0", VA = "0x1D84BC0", Slot = "8")]
			public void Reset()
			{
			}

			[Token(Token = "0x600095C")]
			[Address(RVA = "0x1D84C78", Offset = "0x1D84C78", VA = "0x1D84C78", Slot = "10")]
			private IEnumerator System.Collections.IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Token(Token = "0x2000131")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9D5F7C", Offset = "0x9D5F7C")]
		private sealed class <get_Children>d__40 : IEnumerable<JSONNode>, IEnumerable, IEnumerator<JSONNode>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40007E7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40007E8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private JSONNode <>2__current;

			[Token(Token = "0x40007E9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private int <>l__initialThreadId;

			[Token(Token = "0x17000185")]
			private JSONNode System.Collections.Generic.IEnumerator<SimpleJSON.JSONNode>.Current
			{
				[Token(Token = "0x6000960")]
				[Address(RVA = "0x1D83E2C", Offset = "0x1D83E2C", VA = "0x1D83E2C", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000186")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000962")]
				[Address(RVA = "0x1D83E9C", Offset = "0x1D83E9C", VA = "0x1D83E9C", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600095D")]
			[Address(RVA = "0x1D83DD8", Offset = "0x1D83DD8", VA = "0x1D83DD8")]
			[DebuggerHidden]
			public <get_Children>d__40(int <>1__state)
			{
			}

			[Token(Token = "0x600095E")]
			[Address(RVA = "0x1D83E10", Offset = "0x1D83E10", VA = "0x1D83E10", Slot = "7")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600095F")]
			[Address(RVA = "0x1D83E14", Offset = "0x1D83E14", VA = "0x1D83E14", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000961")]
			[Address(RVA = "0x1D83E34", Offset = "0x1D83E34", VA = "0x1D83E34", Slot = "10")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}

			[Token(Token = "0x6000963")]
			[Address(RVA = "0x1D83EA4", Offset = "0x1D83EA4", VA = "0x1D83EA4", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<JSONNode> System.Collections.Generic.IEnumerable<SimpleJSON.JSONNode>.GetEnumerator()
			{
				return null;
			}

			[Token(Token = "0x6000964")]
			[Address(RVA = "0x1D83F3C", Offset = "0x1D83F3C", VA = "0x1D83F3C", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator System.Collections.IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Token(Token = "0x2000132")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9D5F8C", Offset = "0x9D5F8C")]
		private sealed class <get_DeepChildren>d__42 : IEnumerable<JSONNode>, IEnumerable, IEnumerator<JSONNode>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40007EA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40007EB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private JSONNode <>2__current;

			[Token(Token = "0x40007EC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private int <>l__initialThreadId;

			[Token(Token = "0x40007ED")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public JSONNode <>4__this;

			[Token(Token = "0x40007EE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private IEnumerator<JSONNode> <>7__wrap1;

			[Token(Token = "0x40007EF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private IEnumerator<JSONNode> <>7__wrap2;

			[Token(Token = "0x17000187")]
			private JSONNode System.Collections.Generic.IEnumerator<SimpleJSON.JSONNode>.Current
			{
				[Token(Token = "0x600096A")]
				[Address(RVA = "0x1D845B0", Offset = "0x1D845B0", VA = "0x1D845B0", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000188")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600096C")]
				[Address(RVA = "0x1D84620", Offset = "0x1D84620", VA = "0x1D84620", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000965")]
			[Address(RVA = "0x1D83F40", Offset = "0x1D83F40", VA = "0x1D83F40")]
			[DebuggerHidden]
			public <get_DeepChildren>d__42(int <>1__state)
			{
			}

			[Token(Token = "0x6000966")]
			[Address(RVA = "0x1D83F78", Offset = "0x1D83F78", VA = "0x1D83F78", Slot = "7")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000967")]
			[Address(RVA = "0x1D84170", Offset = "0x1D84170", VA = "0x1D84170", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000968")]
			[Address(RVA = "0x1D840B0", Offset = "0x1D840B0", VA = "0x1D840B0")]
			private void <>m__Finally1()
			{
			}

			[Token(Token = "0x6000969")]
			[Address(RVA = "0x1D83FF0", Offset = "0x1D83FF0", VA = "0x1D83FF0")]
			private void <>m__Finally2()
			{
			}

			[Token(Token = "0x600096B")]
			[Address(RVA = "0x1D845B8", Offset = "0x1D845B8", VA = "0x1D845B8", Slot = "10")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}

			[Token(Token = "0x600096D")]
			[Address(RVA = "0x1D84628", Offset = "0x1D84628", VA = "0x1D84628", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<JSONNode> System.Collections.Generic.IEnumerable<SimpleJSON.JSONNode>.GetEnumerator()
			{
				return null;
			}

			[Token(Token = "0x600096E")]
			[Address(RVA = "0x1D846D8", Offset = "0x1D846D8", VA = "0x1D846D8", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator System.Collections.IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Token(Token = "0x400003E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static bool forceASCII;

		[Token(Token = "0x400003F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1")]
		public static bool longAsString;

		[Token(Token = "0x4000040")]
		[ThreadStatic]
		private static StringBuilder m_EscapeBuilder;

		[Token(Token = "0x4000041")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public static JSONContainerType VectorContainerType;

		[Token(Token = "0x4000042")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static JSONContainerType QuaternionContainerType;

		[Token(Token = "0x4000043")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public static JSONContainerType RectContainerType;

		[Token(Token = "0x1700000E")]
		public abstract JSONNodeType Tag
		{
			[Token(Token = "0x6000035")]
			get;
		}

		[Token(Token = "0x1700000F")]
		public virtual JSONNode Item
		{
			[Token(Token = "0x6000036")]
			[Address(RVA = "0xEEEE80", Offset = "0xEEEE80", VA = "0xEEEE80", Slot = "5")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000037")]
			[Address(RVA = "0xEEEE88", Offset = "0xEEEE88", VA = "0xEEEE88", Slot = "6")]
			set
			{
			}
		}

		[Token(Token = "0x17000010")]
		public virtual JSONNode Item
		{
			[Token(Token = "0x6000038")]
			[Address(RVA = "0xEEEE8C", Offset = "0xEEEE8C", VA = "0xEEEE8C", Slot = "7")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000039")]
			[Address(RVA = "0xEEEE94", Offset = "0xEEEE94", VA = "0xEEEE94", Slot = "8")]
			set
			{
			}
		}

		[Token(Token = "0x17000011")]
		public virtual string Value
		{
			[Token(Token = "0x600003A")]
			[Address(RVA = "0xEEEE98", Offset = "0xEEEE98", VA = "0xEEEE98", Slot = "9")]
			get
			{
				return null;
			}
			[Token(Token = "0x600003B")]
			[Address(RVA = "0xEEEEE0", Offset = "0xEEEEE0", VA = "0xEEEEE0", Slot = "10")]
			set
			{
			}
		}

		[Token(Token = "0x17000012")]
		public virtual int Count
		{
			[Token(Token = "0x600003C")]
			[Address(RVA = "0xEEEEE4", Offset = "0xEEEEE4", VA = "0xEEEEE4", Slot = "11")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000013")]
		public virtual bool IsNumber
		{
			[Token(Token = "0x600003D")]
			[Address(RVA = "0xEEEEEC", Offset = "0xEEEEEC", VA = "0xEEEEEC", Slot = "12")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000014")]
		public virtual bool IsString
		{
			[Token(Token = "0x600003E")]
			[Address(RVA = "0xEEEEF4", Offset = "0xEEEEF4", VA = "0xEEEEF4", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000015")]
		public virtual bool IsBoolean
		{
			[Token(Token = "0x600003F")]
			[Address(RVA = "0xEEEEFC", Offset = "0xEEEEFC", VA = "0xEEEEFC", Slot = "14")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000016")]
		public virtual bool IsNull
		{
			[Token(Token = "0x6000040")]
			[Address(RVA = "0xEEEF04", Offset = "0xEEEF04", VA = "0xEEEF04", Slot = "15")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000017")]
		public virtual bool IsArray
		{
			[Token(Token = "0x6000041")]
			[Address(RVA = "0xEEEF0C", Offset = "0xEEEF0C", VA = "0xEEEF0C", Slot = "16")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000018")]
		public virtual bool IsObject
		{
			[Token(Token = "0x6000042")]
			[Address(RVA = "0xEEEF14", Offset = "0xEEEF14", VA = "0xEEEF14", Slot = "17")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000019")]
		public virtual bool Inline
		{
			[Token(Token = "0x6000043")]
			[Address(RVA = "0xEEEF1C", Offset = "0xEEEF1C", VA = "0xEEEF1C", Slot = "18")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000044")]
			[Address(RVA = "0xEEEF24", Offset = "0xEEEF24", VA = "0xEEEF24", Slot = "19")]
			set
			{
			}
		}

		[Token(Token = "0x1700001A")]
		public virtual IEnumerable<JSONNode> Children
		{
			[Token(Token = "0x600004A")]
			[Address(RVA = "0xEEEFB0", Offset = "0xEEEFB0", VA = "0xEEEFB0", Slot = "25")]
			[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9DD4DC", Offset = "0x9DD4DC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700001B")]
		public IEnumerable<JSONNode> DeepChildren
		{
			[Token(Token = "0x600004B")]
			[Address(RVA = "0xEEF010", Offset = "0xEEF010", VA = "0xEEF010")]
			[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9DD540", Offset = "0x9DD540")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700001C")]
		public IEnumerable<KeyValuePair<string, JSONNode>> Linq
		{
			[Token(Token = "0x6000050")]
			[Address(RVA = "0xEEF1C0", Offset = "0xEEF1C0", VA = "0xEEF1C0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700001D")]
		public KeyEnumerator Keys
		{
			[Token(Token = "0x6000051")]
			[Address(RVA = "0xEEF224", Offset = "0xEEF224", VA = "0xEEF224")]
			get
			{
				return default(KeyEnumerator);
			}
		}

		[Token(Token = "0x1700001E")]
		public ValueEnumerator Values
		{
			[Token(Token = "0x6000052")]
			[Address(RVA = "0xEEF28C", Offset = "0xEEF28C", VA = "0xEEF28C")]
			get
			{
				return default(ValueEnumerator);
			}
		}

		[Token(Token = "0x1700001F")]
		public virtual double AsDouble
		{
			[Token(Token = "0x6000053")]
			[Address(RVA = "0xEEF2F4", Offset = "0xEEF2F4", VA = "0xEEF2F4", Slot = "29")]
			get
			{
				return default(double);
			}
			[Token(Token = "0x6000054")]
			[Address(RVA = "0xEEF3D0", Offset = "0xEEF3D0", VA = "0xEEF3D0", Slot = "30")]
			set
			{
			}
		}

		[Token(Token = "0x17000020")]
		public virtual int AsInt
		{
			[Token(Token = "0x6000055")]
			[Address(RVA = "0xEEF468", Offset = "0xEEF468", VA = "0xEEF468", Slot = "31")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000056")]
			[Address(RVA = "0xEEF48C", Offset = "0xEEF48C", VA = "0xEEF48C", Slot = "32")]
			set
			{
			}
		}

		[Token(Token = "0x17000021")]
		public virtual float AsFloat
		{
			[Token(Token = "0x6000057")]
			[Address(RVA = "0xEEF4A4", Offset = "0xEEF4A4", VA = "0xEEF4A4", Slot = "33")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000058")]
			[Address(RVA = "0xEEF4C8", Offset = "0xEEF4C8", VA = "0xEEF4C8", Slot = "34")]
			set
			{
			}
		}

		[Token(Token = "0x17000022")]
		public virtual bool AsBool
		{
			[Token(Token = "0x6000059")]
			[Address(RVA = "0xEEF4DC", Offset = "0xEEF4DC", VA = "0xEEF4DC", Slot = "35")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600005A")]
			[Address(RVA = "0xEEF5A4", Offset = "0xEEF5A4", VA = "0xEEF5A4", Slot = "36")]
			set
			{
			}
		}

		[Token(Token = "0x17000023")]
		public virtual long AsLong
		{
			[Token(Token = "0x600005B")]
			[Address(RVA = "0xEEF628", Offset = "0xEEF628", VA = "0xEEF628", Slot = "37")]
			get
			{
				return default(long);
			}
			[Token(Token = "0x600005C")]
			[Address(RVA = "0xEEF668", Offset = "0xEEF668", VA = "0xEEF668", Slot = "38")]
			set
			{
			}
		}

		[Token(Token = "0x17000024")]
		public virtual JSONArray AsArray
		{
			[Token(Token = "0x600005D")]
			[Address(RVA = "0xEEF6A8", Offset = "0xEEF6A8", VA = "0xEEF6A8", Slot = "39")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000025")]
		public virtual JSONObject AsObject
		{
			[Token(Token = "0x600005E")]
			[Address(RVA = "0xEEF728", Offset = "0xEEF728", VA = "0xEEF728", Slot = "40")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000026")]
		internal static StringBuilder EscapeBuilder
		{
			[Token(Token = "0x6000070")]
			[Address(RVA = "0xEEFF14", Offset = "0xEEFF14", VA = "0xEEFF14")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000045")]
		[Address(RVA = "0xEEEF28", Offset = "0xEEEF28", VA = "0xEEEF28", Slot = "20")]
		public virtual void Add(string aKey, JSONNode aItem)
		{
		}

		[Token(Token = "0x6000046")]
		[Address(RVA = "0xEEEF2C", Offset = "0xEEEF2C", VA = "0xEEEF2C", Slot = "21")]
		public virtual void Add(JSONNode aItem)
		{
		}

		[Token(Token = "0x6000047")]
		[Address(RVA = "0xEEEF98", Offset = "0xEEEF98", VA = "0xEEEF98", Slot = "22")]
		public virtual JSONNode Remove(string aKey)
		{
			return null;
		}

		[Token(Token = "0x6000048")]
		[Address(RVA = "0xEEEFA0", Offset = "0xEEEFA0", VA = "0xEEEFA0", Slot = "23")]
		public virtual JSONNode Remove(int aIndex)
		{
			return null;
		}

		[Token(Token = "0x6000049")]
		[Address(RVA = "0xEEEFA8", Offset = "0xEEEFA8", VA = "0xEEEFA8", Slot = "24")]
		public virtual JSONNode Remove(JSONNode aNode)
		{
			return null;
		}

		[Token(Token = "0x600004C")]
		[Address(RVA = "0xEEF084", Offset = "0xEEF084", VA = "0xEEF084", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x600004D")]
		[Address(RVA = "0xEEF11C", Offset = "0xEEF11C", VA = "0xEEF11C", Slot = "26")]
		public virtual string ToString(int aIndent)
		{
			return null;
		}

		[Token(Token = "0x600004E")]
		internal abstract void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode);

		[Token(Token = "0x600004F")]
		public abstract Enumerator GetEnumerator();

		[Token(Token = "0x600005F")]
		[Address(RVA = "0xEEF7A8", Offset = "0xEEF7A8", VA = "0xEEF7A8")]
		public static implicit operator JSONNode(string s)
		{
			return null;
		}

		[Token(Token = "0x6000060")]
		[Address(RVA = "0xEEF80C", Offset = "0xEEF80C", VA = "0xEEF80C")]
		public static implicit operator string(JSONNode d)
		{
			return null;
		}

		[Token(Token = "0x6000061")]
		[Address(RVA = "0xEEF8A4", Offset = "0xEEF8A4", VA = "0xEEF8A4")]
		public static implicit operator JSONNode(double n)
		{
			return null;
		}

		[Token(Token = "0x6000062")]
		[Address(RVA = "0xEEF910", Offset = "0xEEF910", VA = "0xEEF910")]
		public static implicit operator double(JSONNode d)
		{
			return default(double);
		}

		[Token(Token = "0x6000063")]
		[Address(RVA = "0xEEF9AC", Offset = "0xEEF9AC", VA = "0xEEF9AC")]
		public static implicit operator JSONNode(float n)
		{
			return null;
		}

		[Token(Token = "0x6000064")]
		[Address(RVA = "0xEEFA18", Offset = "0xEEFA18", VA = "0xEEFA18")]
		public static implicit operator float(JSONNode d)
		{
			return default(float);
		}

		[Token(Token = "0x6000065")]
		[Address(RVA = "0xEEFAB4", Offset = "0xEEFAB4", VA = "0xEEFAB4")]
		public static implicit operator JSONNode(int n)
		{
			return null;
		}

		[Token(Token = "0x6000066")]
		[Address(RVA = "0xEEFB18", Offset = "0xEEFB18", VA = "0xEEFB18")]
		public static implicit operator int(JSONNode d)
		{
			return default(int);
		}

		[Token(Token = "0x6000067")]
		[Address(RVA = "0xEEFBB4", Offset = "0xEEFBB4", VA = "0xEEFBB4")]
		public static implicit operator JSONNode(long n)
		{
			return null;
		}

		[Token(Token = "0x6000068")]
		[Address(RVA = "0xEEFC8C", Offset = "0xEEFC8C", VA = "0xEEFC8C")]
		public static implicit operator long(JSONNode d)
		{
			return default(long);
		}

		[Token(Token = "0x6000069")]
		[Address(RVA = "0xEEFD28", Offset = "0xEEFD28", VA = "0xEEFD28")]
		public static implicit operator JSONNode(bool b)
		{
			return null;
		}

		[Token(Token = "0x600006A")]
		[Address(RVA = "0xEEFD88", Offset = "0xEEFD88", VA = "0xEEFD88")]
		public static implicit operator bool(JSONNode d)
		{
			return default(bool);
		}

		[Token(Token = "0x600006B")]
		[Address(RVA = "0xEEFE24", Offset = "0xEEFE24", VA = "0xEEFE24")]
		public static implicit operator JSONNode(KeyValuePair<string, JSONNode> aKeyValue)
		{
			return null;
		}

		[Token(Token = "0x600006C")]
		[Address(RVA = "0xEED2EC", Offset = "0xEED2EC", VA = "0xEED2EC")]
		public static bool operator ==(JSONNode a, object b)
		{
			return default(bool);
		}

		[Token(Token = "0x600006D")]
		[Address(RVA = "0xEEFE80", Offset = "0xEEFE80", VA = "0xEEFE80")]
		public static bool operator !=(JSONNode a, object b)
		{
			return default(bool);
		}

		[Token(Token = "0x600006E")]
		[Address(RVA = "0xEEFF00", Offset = "0xEEFF00", VA = "0xEEFF00", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x600006F")]
		[Address(RVA = "0xEEFF0C", Offset = "0xEEFF0C", VA = "0xEEFF0C", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x6000071")]
		[Address(RVA = "0xEEFFE4", Offset = "0xEEFFE4", VA = "0xEEFFE4")]
		internal static string Escape(string aText)
		{
			return null;
		}

		[Token(Token = "0x6000072")]
		[Address(RVA = "0xEF03F8", Offset = "0xEF03F8", VA = "0xEF03F8")]
		private static JSONNode ParseElement(string token, bool quoted)
		{
			return null;
		}

		[Token(Token = "0x6000073")]
		[Address(RVA = "0xEEC798", Offset = "0xEEC798", VA = "0xEEC798")]
		public static JSONNode Parse(string aJSON)
		{
			return null;
		}

		[Token(Token = "0x6000074")]
		public abstract void SerializeBinary(BinaryWriter aWriter);

		[Token(Token = "0x6000075")]
		[Address(RVA = "0xEF0604", Offset = "0xEF0604", VA = "0xEF0604")]
		public void SaveToBinaryStream(Stream aData)
		{
		}

		[Token(Token = "0x6000076")]
		[Address(RVA = "0xEF0684", Offset = "0xEF0684", VA = "0xEF0684")]
		public void SaveToCompressedStream(Stream aData)
		{
		}

		[Token(Token = "0x6000077")]
		[Address(RVA = "0xEF06F8", Offset = "0xEF06F8", VA = "0xEF06F8")]
		public void SaveToCompressedFile(string aFileName)
		{
		}

		[Token(Token = "0x6000078")]
		[Address(RVA = "0xEF076C", Offset = "0xEF076C", VA = "0xEF076C")]
		public string SaveToCompressedBase64()
		{
			return null;
		}

		[Token(Token = "0x6000079")]
		[Address(RVA = "0xEF07E0", Offset = "0xEF07E0", VA = "0xEF07E0")]
		public void SaveToBinaryFile(string aFileName)
		{
		}

		[Token(Token = "0x600007A")]
		[Address(RVA = "0xEF0964", Offset = "0xEF0964", VA = "0xEF0964")]
		public string SaveToBinaryBase64()
		{
			return null;
		}

		[Token(Token = "0x600007B")]
		[Address(RVA = "0xEF0B00", Offset = "0xEF0B00", VA = "0xEF0B00")]
		public static JSONNode DeserializeBinary(BinaryReader aReader)
		{
			return null;
		}

		[Token(Token = "0x600007C")]
		[Address(RVA = "0xEF0E48", Offset = "0xEF0E48", VA = "0xEF0E48")]
		public static JSONNode LoadFromCompressedFile(string aFileName)
		{
			return null;
		}

		[Token(Token = "0x600007D")]
		[Address(RVA = "0xEF0EBC", Offset = "0xEF0EBC", VA = "0xEF0EBC")]
		public static JSONNode LoadFromCompressedStream(Stream aData)
		{
			return null;
		}

		[Token(Token = "0x600007E")]
		[Address(RVA = "0xEF0F30", Offset = "0xEF0F30", VA = "0xEF0F30")]
		public static JSONNode LoadFromCompressedBase64(string aBase64)
		{
			return null;
		}

		[Token(Token = "0x600007F")]
		[Address(RVA = "0xEF0FA4", Offset = "0xEF0FA4", VA = "0xEF0FA4")]
		public static JSONNode LoadFromBinaryStream(Stream aData)
		{
			return null;
		}

		[Token(Token = "0x6000080")]
		[Address(RVA = "0xEF10F4", Offset = "0xEF10F4", VA = "0xEF10F4")]
		public static JSONNode LoadFromBinaryFile(string aFileName)
		{
			return null;
		}

		[Token(Token = "0x6000081")]
		[Address(RVA = "0xEF1238", Offset = "0xEF1238", VA = "0xEF1238")]
		public static JSONNode LoadFromBinaryBase64(string aBase64)
		{
			return null;
		}

		[Token(Token = "0x6000082")]
		[Address(RVA = "0xEF1310", Offset = "0xEF1310", VA = "0xEF1310")]
		private static JSONNode GetContainer(JSONContainerType aType)
		{
			return null;
		}

		[Token(Token = "0x6000083")]
		[Address(RVA = "0xEF1390", Offset = "0xEF1390", VA = "0xEF1390")]
		public static implicit operator JSONNode(Vector2 aVec)
		{
			return null;
		}

		[Token(Token = "0x6000084")]
		[Address(RVA = "0xEF1594", Offset = "0xEF1594", VA = "0xEF1594")]
		public static implicit operator JSONNode(Vector3 aVec)
		{
			return null;
		}

		[Token(Token = "0x6000085")]
		[Address(RVA = "0xEF1834", Offset = "0xEF1834", VA = "0xEF1834")]
		public static implicit operator JSONNode(Vector4 aVec)
		{
			return null;
		}

		[Token(Token = "0x6000086")]
		[Address(RVA = "0xEF1B60", Offset = "0xEF1B60", VA = "0xEF1B60")]
		public static implicit operator JSONNode(Quaternion aRot)
		{
			return null;
		}

		[Token(Token = "0x6000087")]
		[Address(RVA = "0xEF1E8C", Offset = "0xEF1E8C", VA = "0xEF1E8C")]
		public static implicit operator JSONNode(Rect aRect)
		{
			return null;
		}

		[Token(Token = "0x6000088")]
		[Address(RVA = "0xEF223C", Offset = "0xEF223C", VA = "0xEF223C")]
		public static implicit operator JSONNode(RectOffset aRect)
		{
			return null;
		}

		[Token(Token = "0x6000089")]
		[Address(RVA = "0xEF260C", Offset = "0xEF260C", VA = "0xEF260C")]
		public static implicit operator Vector2(JSONNode aNode)
		{
			return default(Vector2);
		}

		[Token(Token = "0x600008A")]
		[Address(RVA = "0xEF26A0", Offset = "0xEF26A0", VA = "0xEF26A0")]
		public static implicit operator Vector3(JSONNode aNode)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600008B")]
		[Address(RVA = "0xEF2734", Offset = "0xEF2734", VA = "0xEF2734")]
		public static implicit operator Vector4(JSONNode aNode)
		{
			return default(Vector4);
		}

		[Token(Token = "0x600008C")]
		[Address(RVA = "0xEF27C8", Offset = "0xEF27C8", VA = "0xEF27C8")]
		public static implicit operator Quaternion(JSONNode aNode)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600008D")]
		[Address(RVA = "0xEF285C", Offset = "0xEF285C", VA = "0xEF285C")]
		public static implicit operator Rect(JSONNode aNode)
		{
			return default(Rect);
		}

		[Token(Token = "0x600008E")]
		[Address(RVA = "0xEF28A8", Offset = "0xEF28A8", VA = "0xEF28A8")]
		public static implicit operator RectOffset(JSONNode aNode)
		{
			return null;
		}

		[Token(Token = "0x600008F")]
		[Address(RVA = "0xEF2934", Offset = "0xEF2934", VA = "0xEF2934")]
		public Vector2 ReadVector2(Vector2 aDefault)
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000090")]
		[Address(RVA = "0xEF2AAC", Offset = "0xEF2AAC", VA = "0xEF2AAC")]
		public Vector2 ReadVector2(string aXName, string aYName)
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000091")]
		[Address(RVA = "0xEF2634", Offset = "0xEF2634", VA = "0xEF2634")]
		public Vector2 ReadVector2()
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000092")]
		[Address(RVA = "0xEF143C", Offset = "0xEF143C", VA = "0xEF143C")]
		public JSONNode WriteVector2(Vector2 aVec, string aXName = "x", string aYName = "y")
		{
			return null;
		}

		[Token(Token = "0x6000093")]
		[Address(RVA = "0xEF2BD4", Offset = "0xEF2BD4", VA = "0xEF2BD4")]
		public Vector3 ReadVector3(Vector3 aDefault)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000094")]
		[Address(RVA = "0xEF2DE0", Offset = "0xEF2DE0", VA = "0xEF2DE0")]
		public Vector3 ReadVector3(string aXName, string aYName, string aZName)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000095")]
		[Address(RVA = "0xEF26C8", Offset = "0xEF26C8", VA = "0xEF26C8")]
		public Vector3 ReadVector3()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000096")]
		[Address(RVA = "0xEF165C", Offset = "0xEF165C", VA = "0xEF165C")]
		public JSONNode WriteVector3(Vector3 aVec, string aXName = "x", string aYName = "y", string aZName = "z")
		{
			return null;
		}

		[Token(Token = "0x6000097")]
		[Address(RVA = "0xEF2F64", Offset = "0xEF2F64", VA = "0xEF2F64")]
		public Vector4 ReadVector4(Vector4 aDefault)
		{
			return default(Vector4);
		}

		[Token(Token = "0x6000098")]
		[Address(RVA = "0xEF275C", Offset = "0xEF275C", VA = "0xEF275C")]
		public Vector4 ReadVector4()
		{
			return default(Vector4);
		}

		[Token(Token = "0x6000099")]
		[Address(RVA = "0xEF18E0", Offset = "0xEF18E0", VA = "0xEF18E0")]
		public JSONNode WriteVector4(Vector4 aVec)
		{
			return null;
		}

		[Token(Token = "0x600009A")]
		[Address(RVA = "0xEF31EC", Offset = "0xEF31EC", VA = "0xEF31EC")]
		public Quaternion ReadQuaternion(Quaternion aDefault)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600009B")]
		[Address(RVA = "0xEF27F0", Offset = "0xEF27F0", VA = "0xEF27F0")]
		public Quaternion ReadQuaternion()
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600009C")]
		[Address(RVA = "0xEF1C0C", Offset = "0xEF1C0C", VA = "0xEF1C0C")]
		public JSONNode WriteQuaternion(Quaternion aRot)
		{
			return null;
		}

		[Token(Token = "0x600009D")]
		[Address(RVA = "0xEF3474", Offset = "0xEF3474", VA = "0xEF3474")]
		public Rect ReadRect(Rect aDefault)
		{
			return default(Rect);
		}

		[Token(Token = "0x600009E")]
		[Address(RVA = "0xEF2894", Offset = "0xEF2894", VA = "0xEF2894")]
		public Rect ReadRect()
		{
			return default(Rect);
		}

		[Token(Token = "0x600009F")]
		[Address(RVA = "0xEF1F38", Offset = "0xEF1F38", VA = "0xEF1F38")]
		public JSONNode WriteRect(Rect aRect)
		{
			return null;
		}

		[Token(Token = "0x60000A0")]
		[Address(RVA = "0xEF36FC", Offset = "0xEF36FC", VA = "0xEF36FC")]
		public RectOffset ReadRectOffset(RectOffset aDefault)
		{
			return null;
		}

		[Token(Token = "0x60000A1")]
		[Address(RVA = "0xEF28D0", Offset = "0xEF28D0", VA = "0xEF28D0")]
		public RectOffset ReadRectOffset()
		{
			return null;
		}

		[Token(Token = "0x60000A2")]
		[Address(RVA = "0xEF22C0", Offset = "0xEF22C0", VA = "0xEF22C0")]
		public JSONNode WriteRectOffset(RectOffset aRect)
		{
			return null;
		}

		[Token(Token = "0x60000A3")]
		[Address(RVA = "0xEF39A0", Offset = "0xEF39A0", VA = "0xEF39A0")]
		public Matrix4x4 ReadMatrix()
		{
			return default(Matrix4x4);
		}

		[Token(Token = "0x60000A4")]
		[Address(RVA = "0xEF3AB8", Offset = "0xEF3AB8", VA = "0xEF3AB8")]
		public JSONNode WriteMatrix(Matrix4x4 aMatrix)
		{
			return null;
		}

		[Token(Token = "0x60000A5")]
		[Address(RVA = "0xEEDC9C", Offset = "0xEEDC9C", VA = "0xEEDC9C")]
		protected JSONNode()
		{
		}
	}
	[Token(Token = "0x200000D")]
	[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0x9D4E14", Offset = "0x9D4E14")]
	public class JSONArray : JSONNode
	{
		[Token(Token = "0x2000133")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9D5F9C", Offset = "0x9D5F9C")]
		private sealed class <get_Children>d__22 : IEnumerable<JSONNode>, IEnumerable, IEnumerator<JSONNode>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40007F0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40007F1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private JSONNode <>2__current;

			[Token(Token = "0x40007F2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private int <>l__initialThreadId;

			[Token(Token = "0x40007F3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public JSONArray <>4__this;

			[Token(Token = "0x40007F4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private List<JSONNode>.Enumerator <>7__wrap1;

			[Token(Token = "0x17000189")]
			private JSONNode System.Collections.Generic.IEnumerator<SimpleJSON.JSONNode>.Current
			{
				[Token(Token = "0x6000973")]
				[Address(RVA = "0xEEDE8C", Offset = "0xEEDE8C", VA = "0xEEDE8C", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700018A")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000975")]
				[Address(RVA = "0xEEDEFC", Offset = "0xEEDEFC", VA = "0xEEDEFC", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600096F")]
			[Address(RVA = "0xEED8AC", Offset = "0xEED8AC", VA = "0xEED8AC")]
			[DebuggerHidden]
			public <get_Children>d__22(int <>1__state)
			{
			}

			[Token(Token = "0x6000970")]
			[Address(RVA = "0xEEDCA4", Offset = "0xEEDCA4", VA = "0xEEDCA4", Slot = "7")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000971")]
			[Address(RVA = "0xEEDD18", Offset = "0xEEDD18", VA = "0xEEDD18", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000972")]
			[Address(RVA = "0xEEDCC0", Offset = "0xEEDCC0", VA = "0xEEDCC0")]
			private void <>m__Finally1()
			{
			}

			[Token(Token = "0x6000974")]
			[Address(RVA = "0xEEDE94", Offset = "0xEEDE94", VA = "0xEEDE94", Slot = "10")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}

			[Token(Token = "0x6000976")]
			[Address(RVA = "0xEEDF04", Offset = "0xEEDF04", VA = "0xEEDF04", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<JSONNode> System.Collections.Generic.IEnumerable<SimpleJSON.JSONNode>.GetEnumerator()
			{
				return null;
			}

			[Token(Token = "0x6000977")]
			[Address(RVA = "0xEEDFB4", Offset = "0xEEDFB4", VA = "0xEEDFB4", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator System.Collections.IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Token(Token = "0x4000044")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private List<JSONNode> m_List;

		[Token(Token = "0x4000045")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private bool inline;

		[Token(Token = "0x17000027")]
		public override bool Inline
		{
			[Token(Token = "0x60000A7")]
			[Address(RVA = "0xEECFAC", Offset = "0xEECFAC", VA = "0xEECFAC", Slot = "18")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60000A8")]
			[Address(RVA = "0xEECFB4", Offset = "0xEECFB4", VA = "0xEECFB4", Slot = "19")]
			set
			{
			}
		}

		[Token(Token = "0x17000028")]
		public override JSONNodeType Tag
		{
			[Token(Token = "0x60000A9")]
			[Address(RVA = "0xEECFC0", Offset = "0xEECFC0", VA = "0xEECFC0", Slot = "4")]
			get
			{
				return default(JSONNodeType);
			}
		}

		[Token(Token = "0x17000029")]
		public override bool IsArray
		{
			[Token(Token = "0x60000AA")]
			[Address(RVA = "0xEECFC8", Offset = "0xEECFC8", VA = "0xEECFC8", Slot = "16")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700002A")]
		public override JSONNode Item
		{
			[Token(Token = "0x60000AC")]
			[Address(RVA = "0xEED06C", Offset = "0xEED06C", VA = "0xEED06C", Slot = "5")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000AD")]
			[Address(RVA = "0xEED1B4", Offset = "0xEED1B4", VA = "0xEED1B4", Slot = "6")]
			set
			{
			}
		}

		[Token(Token = "0x1700002B")]
		public override JSONNode Item
		{
			[Token(Token = "0x60000AE")]
			[Address(RVA = "0xEED47C", Offset = "0xEED47C", VA = "0xEED47C", Slot = "7")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000AF")]
			[Address(RVA = "0xEED4DC", Offset = "0xEED4DC", VA = "0xEED4DC", Slot = "8")]
			set
			{
			}
		}

		[Token(Token = "0x1700002C")]
		public override int Count
		{
			[Token(Token = "0x60000B0")]
			[Address(RVA = "0xEED5A8", Offset = "0xEED5A8", VA = "0xEED5A8", Slot = "11")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700002D")]
		public override IEnumerable<JSONNode> Children
		{
			[Token(Token = "0x60000B4")]
			[Address(RVA = "0xEED828", Offset = "0xEED828", VA = "0xEED828", Slot = "25")]
			[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9DD5A4", Offset = "0x9DD5A4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60000AB")]
		[Address(RVA = "0xEECFD0", Offset = "0xEECFD0", VA = "0xEECFD0", Slot = "28")]
		public override Enumerator GetEnumerator()
		{
			return default(Enumerator);
		}

		[Token(Token = "0x60000B1")]
		[Address(RVA = "0xEED608", Offset = "0xEED608", VA = "0xEED608", Slot = "20")]
		public override void Add(string aKey, JSONNode aItem)
		{
		}

		[Token(Token = "0x60000B2")]
		[Address(RVA = "0xEED6D4", Offset = "0xEED6D4", VA = "0xEED6D4", Slot = "23")]
		public override JSONNode Remove(int aIndex)
		{
			return null;
		}

		[Token(Token = "0x60000B3")]
		[Address(RVA = "0xEED7B0", Offset = "0xEED7B0", VA = "0xEED7B0", Slot = "24")]
		public override JSONNode Remove(JSONNode aNode)
		{
			return null;
		}

		[Token(Token = "0x60000B5")]
		[Address(RVA = "0xEED8E4", Offset = "0xEED8E4", VA = "0xEED8E4", Slot = "27")]
		internal override void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode)
		{
		}

		[Token(Token = "0x60000B6")]
		[Address(RVA = "0xEEDAE0", Offset = "0xEEDAE0", VA = "0xEEDAE0", Slot = "41")]
		public override void SerializeBinary(BinaryWriter aWriter)
		{
		}

		[Token(Token = "0x60000B7")]
		[Address(RVA = "0xEEDC0C", Offset = "0xEEDC0C", VA = "0xEEDC0C")]
		public JSONArray()
		{
		}
	}
	[Token(Token = "0x200000E")]
	[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0x9D4E4C", Offset = "0x9D4E4C")]
	public class JSONObject : JSONNode
	{
		[Token(Token = "0x2000134")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9D5FAC", Offset = "0x9D5FAC")]
		private sealed class <>c__DisplayClass21_0
		{
			[Token(Token = "0x40007F5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public JSONNode aNode;

			[Token(Token = "0x6000978")]
			[Address(RVA = "0x1D86188", Offset = "0x1D86188", VA = "0x1D86188")]
			public <>c__DisplayClass21_0()
			{
			}

			[Token(Token = "0x6000979")]
			[Address(RVA = "0x1D86890", Offset = "0x1D86890", VA = "0x1D86890")]
			internal bool <Remove>b__0(KeyValuePair<string, JSONNode> k)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x2000135")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9D5FBC", Offset = "0x9D5FBC")]
		private sealed class <get_Children>d__23 : IEnumerable<JSONNode>, IEnumerable, IEnumerator<JSONNode>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40007F6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40007F7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private JSONNode <>2__current;

			[Token(Token = "0x40007F8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private int <>l__initialThreadId;

			[Token(Token = "0x40007F9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public JSONObject <>4__this;

			[Token(Token = "0x40007FA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private Dictionary<string, JSONNode>.Enumerator <>7__wrap1;

			[Token(Token = "0x1700018B")]
			private JSONNode System.Collections.Generic.IEnumerator<SimpleJSON.JSONNode>.Current
			{
				[Token(Token = "0x600097E")]
				[Address(RVA = "0x1D86B48", Offset = "0x1D86B48", VA = "0x1D86B48", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700018C")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000980")]
				[Address(RVA = "0x1D86BB8", Offset = "0x1D86BB8", VA = "0x1D86BB8", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600097A")]
			[Address(RVA = "0x1D86214", Offset = "0x1D86214", VA = "0x1D86214")]
			[DebuggerHidden]
			public <get_Children>d__23(int <>1__state)
			{
			}

			[Token(Token = "0x600097B")]
			[Address(RVA = "0x1D86930", Offset = "0x1D86930", VA = "0x1D86930", Slot = "7")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600097C")]
			[Address(RVA = "0x1D869A4", Offset = "0x1D869A4", VA = "0x1D869A4", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600097D")]
			[Address(RVA = "0x1D8694C", Offset = "0x1D8694C", VA = "0x1D8694C")]
			private void <>m__Finally1()
			{
			}

			[Token(Token = "0x600097F")]
			[Address(RVA = "0x1D86B50", Offset = "0x1D86B50", VA = "0x1D86B50", Slot = "10")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}

			[Token(Token = "0x6000981")]
			[Address(RVA = "0x1D86BC0", Offset = "0x1D86BC0", VA = "0x1D86BC0", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<JSONNode> System.Collections.Generic.IEnumerable<SimpleJSON.JSONNode>.GetEnumerator()
			{
				return null;
			}

			[Token(Token = "0x6000982")]
			[Address(RVA = "0x1D86C70", Offset = "0x1D86C70", VA = "0x1D86C70", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator System.Collections.IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Token(Token = "0x4000046")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private Dictionary<string, JSONNode> m_Dict;

		[Token(Token = "0x4000047")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private bool inline;

		[Token(Token = "0x1700002E")]
		public override bool Inline
		{
			[Token(Token = "0x60000B8")]
			[Address(RVA = "0x1D8571C", Offset = "0x1D8571C", VA = "0x1D8571C", Slot = "18")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60000B9")]
			[Address(RVA = "0x1D85724", Offset = "0x1D85724", VA = "0x1D85724", Slot = "19")]
			set
			{
			}
		}

		[Token(Token = "0x1700002F")]
		public override JSONNodeType Tag
		{
			[Token(Token = "0x60000BA")]
			[Address(RVA = "0x1D85730", Offset = "0x1D85730", VA = "0x1D85730", Slot = "4")]
			get
			{
				return default(JSONNodeType);
			}
		}

		[Token(Token = "0x17000030")]
		public override bool IsObject
		{
			[Token(Token = "0x60000BB")]
			[Address(RVA = "0x1D85738", Offset = "0x1D85738", VA = "0x1D85738", Slot = "17")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000031")]
		public override JSONNode Item
		{
			[Token(Token = "0x60000BD")]
			[Address(RVA = "0x1D857E4", Offset = "0x1D857E4", VA = "0x1D857E4", Slot = "7")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000BE")]
			[Address(RVA = "0x1D858B8", Offset = "0x1D858B8", VA = "0x1D858B8", Slot = "8")]
			set
			{
			}
		}

		[Token(Token = "0x17000032")]
		public override JSONNode Item
		{
			[Token(Token = "0x60000BF")]
			[Address(RVA = "0x1D859E8", Offset = "0x1D859E8", VA = "0x1D859E8", Slot = "5")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000C0")]
			[Address(RVA = "0x1D85AAC", Offset = "0x1D85AAC", VA = "0x1D85AAC", Slot = "6")]
			set
			{
			}
		}

		[Token(Token = "0x17000033")]
		public override int Count
		{
			[Token(Token = "0x60000C1")]
			[Address(RVA = "0x1D85BFC", Offset = "0x1D85BFC", VA = "0x1D85BFC", Slot = "11")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000034")]
		public override IEnumerable<JSONNode> Children
		{
			[Token(Token = "0x60000C6")]
			[Address(RVA = "0x1D86190", Offset = "0x1D86190", VA = "0x1D86190", Slot = "25")]
			[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9DD608", Offset = "0x9DD608")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60000BC")]
		[Address(RVA = "0x1D85740", Offset = "0x1D85740", VA = "0x1D85740", Slot = "28")]
		public override Enumerator GetEnumerator()
		{
			return default(Enumerator);
		}

		[Token(Token = "0x60000C2")]
		[Address(RVA = "0x1D85C5C", Offset = "0x1D85C5C", VA = "0x1D85C5C", Slot = "20")]
		public override void Add(string aKey, JSONNode aItem)
		{
		}

		[Token(Token = "0x60000C3")]
		[Address(RVA = "0x1D85DFC", Offset = "0x1D85DFC", VA = "0x1D85DFC", Slot = "22")]
		public override JSONNode Remove(string aKey)
		{
			return null;
		}

		[Token(Token = "0x60000C4")]
		[Address(RVA = "0x1D85ED4", Offset = "0x1D85ED4", VA = "0x1D85ED4", Slot = "23")]
		public override JSONNode Remove(int aIndex)
		{
			return null;
		}

		[Token(Token = "0x60000C5")]
		[Address(RVA = "0x1D85FD4", Offset = "0x1D85FD4", VA = "0x1D85FD4", Slot = "24")]
		public override JSONNode Remove(JSONNode aNode)
		{
			return null;
		}

		[Token(Token = "0x60000C7")]
		[Address(RVA = "0x1D8624C", Offset = "0x1D8624C", VA = "0x1D8624C", Slot = "27")]
		internal override void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode)
		{
		}

		[Token(Token = "0x60000C8")]
		[Address(RVA = "0x1D865F4", Offset = "0x1D865F4", VA = "0x1D865F4", Slot = "41")]
		public override void SerializeBinary(BinaryWriter aWriter)
		{
		}

		[Token(Token = "0x60000C9")]
		[Address(RVA = "0x1D86800", Offset = "0x1D86800", VA = "0x1D86800")]
		public JSONObject()
		{
		}
	}
	[Token(Token = "0x200000F")]
	public class JSONString : JSONNode
	{
		[Token(Token = "0x4000048")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private string m_Data;

		[Token(Token = "0x17000035")]
		public override JSONNodeType Tag
		{
			[Token(Token = "0x60000CA")]
			[Address(RVA = "0x1D86C74", Offset = "0x1D86C74", VA = "0x1D86C74", Slot = "4")]
			get
			{
				return default(JSONNodeType);
			}
		}

		[Token(Token = "0x17000036")]
		public override bool IsString
		{
			[Token(Token = "0x60000CB")]
			[Address(RVA = "0x1D86C7C", Offset = "0x1D86C7C", VA = "0x1D86C7C", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000037")]
		public override string Value
		{
			[Token(Token = "0x60000CD")]
			[Address(RVA = "0x1D86CA4", Offset = "0x1D86CA4", VA = "0x1D86CA4", Slot = "9")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000CE")]
			[Address(RVA = "0x1D86CAC", Offset = "0x1D86CAC", VA = "0x1D86CAC", Slot = "10")]
			set
			{
			}
		}

		[Token(Token = "0x60000CC")]
		[Address(RVA = "0x1D86C84", Offset = "0x1D86C84", VA = "0x1D86C84", Slot = "28")]
		public override Enumerator GetEnumerator()
		{
			return default(Enumerator);
		}

		[Token(Token = "0x60000CF")]
		[Address(RVA = "0x1D86CB4", Offset = "0x1D86CB4", VA = "0x1D86CB4")]
		public JSONString(string aData)
		{
		}

		[Token(Token = "0x60000D0")]
		[Address(RVA = "0x1D86D30", Offset = "0x1D86D30", VA = "0x1D86D30", Slot = "27")]
		internal override void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode)
		{
		}

		[Token(Token = "0x60000D1")]
		[Address(RVA = "0x1D86E08", Offset = "0x1D86E08", VA = "0x1D86E08", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x60000D2")]
		[Address(RVA = "0x1D86F34", Offset = "0x1D86F34", VA = "0x1D86F34", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x60000D3")]
		[Address(RVA = "0x1D86F68", Offset = "0x1D86F68", VA = "0x1D86F68", Slot = "41")]
		public override void SerializeBinary(BinaryWriter aWriter)
		{
		}
	}
	[Token(Token = "0x2000010")]
	public class JSONNumber : JSONNode
	{
		[Token(Token = "0x4000049")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private double m_Data;

		[Token(Token = "0x17000038")]
		public override JSONNodeType Tag
		{
			[Token(Token = "0x60000D4")]
			[Address(RVA = "0x1D85148", Offset = "0x1D85148", VA = "0x1D85148", Slot = "4")]
			get
			{
				return default(JSONNodeType);
			}
		}

		[Token(Token = "0x17000039")]
		public override bool IsNumber
		{
			[Token(Token = "0x60000D5")]
			[Address(RVA = "0x1D85150", Offset = "0x1D85150", VA = "0x1D85150", Slot = "12")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700003A")]
		public override string Value
		{
			[Token(Token = "0x60000D7")]
			[Address(RVA = "0x1D85178", Offset = "0x1D85178", VA = "0x1D85178", Slot = "9")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000D8")]
			[Address(RVA = "0x1D851F0", Offset = "0x1D851F0", VA = "0x1D851F0", Slot = "10")]
			set
			{
			}
		}

		[Token(Token = "0x1700003B")]
		public override double AsDouble
		{
			[Token(Token = "0x60000D9")]
			[Address(RVA = "0x1D852B4", Offset = "0x1D852B4", VA = "0x1D852B4", Slot = "29")]
			get
			{
				return default(double);
			}
			[Token(Token = "0x60000DA")]
			[Address(RVA = "0x1D852BC", Offset = "0x1D852BC", VA = "0x1D852BC", Slot = "30")]
			set
			{
			}
		}

		[Token(Token = "0x1700003C")]
		public override long AsLong
		{
			[Token(Token = "0x60000DB")]
			[Address(RVA = "0x1D852C4", Offset = "0x1D852C4", VA = "0x1D852C4", Slot = "37")]
			get
			{
				return default(long);
			}
			[Token(Token = "0x60000DC")]
			[Address(RVA = "0x1D852D0", Offset = "0x1D852D0", VA = "0x1D852D0", Slot = "38")]
			set
			{
			}
		}

		[Token(Token = "0x60000D6")]
		[Address(RVA = "0x1D85158", Offset = "0x1D85158", VA = "0x1D85158", Slot = "28")]
		public override Enumerator GetEnumerator()
		{
			return default(Enumerator);
		}

		[Token(Token = "0x60000DD")]
		[Address(RVA = "0x1D852DC", Offset = "0x1D852DC", VA = "0x1D852DC")]
		public JSONNumber(double aData)
		{
		}

		[Token(Token = "0x60000DE")]
		[Address(RVA = "0x1D85358", Offset = "0x1D85358", VA = "0x1D85358")]
		public JSONNumber(string aData)
		{
		}

		[Token(Token = "0x60000DF")]
		[Address(RVA = "0x1D853E0", Offset = "0x1D853E0", VA = "0x1D853E0", Slot = "27")]
		internal override void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode)
		{
		}

		[Token(Token = "0x60000E0")]
		[Address(RVA = "0x1D85428", Offset = "0x1D85428", VA = "0x1D85428")]
		private static bool IsNumeric(object value)
		{
			return default(bool);
		}

		[Token(Token = "0x60000E1")]
		[Address(RVA = "0x1D85558", Offset = "0x1D85558", VA = "0x1D85558", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x60000E2")]
		[Address(RVA = "0x1D856A4", Offset = "0x1D856A4", VA = "0x1D856A4", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x60000E3")]
		[Address(RVA = "0x1D856B0", Offset = "0x1D856B0", VA = "0x1D856B0", Slot = "41")]
		public override void SerializeBinary(BinaryWriter aWriter)
		{
		}
	}
	[Token(Token = "0x2000011")]
	public class JSONBool : JSONNode
	{
		[Token(Token = "0x400004A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private bool m_Data;

		[Token(Token = "0x1700003D")]
		public override JSONNodeType Tag
		{
			[Token(Token = "0x60000E4")]
			[Address(RVA = "0xEEDFB8", Offset = "0xEEDFB8", VA = "0xEEDFB8", Slot = "4")]
			get
			{
				return default(JSONNodeType);
			}
		}

		[Token(Token = "0x1700003E")]
		public override bool IsBoolean
		{
			[Token(Token = "0x60000E5")]
			[Address(RVA = "0xEEDFC0", Offset = "0xEEDFC0", VA = "0xEEDFC0", Slot = "14")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700003F")]
		public override string Value
		{
			[Token(Token = "0x60000E7")]
			[Address(RVA = "0xEEDFE8", Offset = "0xEEDFE8", VA = "0xEEDFE8", Slot = "9")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000E8")]
			[Address(RVA = "0xEEDFF4", Offset = "0xEEDFF4", VA = "0xEEDFF4", Slot = "10")]
			set
			{
			}
		}

		[Token(Token = "0x17000040")]
		public override bool AsBool
		{
			[Token(Token = "0x60000E9")]
			[Address(RVA = "0xEEE080", Offset = "0xEEE080", VA = "0xEEE080", Slot = "35")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60000EA")]
			[Address(RVA = "0xEEE088", Offset = "0xEEE088", VA = "0xEEE088", Slot = "36")]
			set
			{
			}
		}

		[Token(Token = "0x60000E6")]
		[Address(RVA = "0xEEDFC8", Offset = "0xEEDFC8", VA = "0xEEDFC8", Slot = "28")]
		public override Enumerator GetEnumerator()
		{
			return default(Enumerator);
		}

		[Token(Token = "0x60000EB")]
		[Address(RVA = "0xEEE094", Offset = "0xEEE094", VA = "0xEEE094")]
		public JSONBool(bool aData)
		{
		}

		[Token(Token = "0x60000EC")]
		[Address(RVA = "0xEEE114", Offset = "0xEEE114", VA = "0xEEE114")]
		public JSONBool(string aData)
		{
		}

		[Token(Token = "0x60000ED")]
		[Address(RVA = "0xEEE19C", Offset = "0xEEE19C", VA = "0xEEE19C", Slot = "27")]
		internal override void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode)
		{
		}

		[Token(Token = "0x60000EE")]
		[Address(RVA = "0xEEE220", Offset = "0xEEE220", VA = "0xEEE220", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x60000EF")]
		[Address(RVA = "0xEEE2A8", Offset = "0xEEE2A8", VA = "0xEEE2A8", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x60000F0")]
		[Address(RVA = "0xEEE2B4", Offset = "0xEEE2B4", VA = "0xEEE2B4", Slot = "41")]
		public override void SerializeBinary(BinaryWriter aWriter)
		{
		}
	}
	[Token(Token = "0x2000012")]
	public class JSONNull : JSONNode
	{
		[Token(Token = "0x400004B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static JSONNull m_StaticInstance;

		[Token(Token = "0x400004C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static bool reuseSameInstance;

		[Token(Token = "0x17000041")]
		public override JSONNodeType Tag
		{
			[Token(Token = "0x60000F3")]
			[Address(RVA = "0x1D84F14", Offset = "0x1D84F14", VA = "0x1D84F14", Slot = "4")]
			get
			{
				return default(JSONNodeType);
			}
		}

		[Token(Token = "0x17000042")]
		public override bool IsNull
		{
			[Token(Token = "0x60000F4")]
			[Address(RVA = "0x1D84F1C", Offset = "0x1D84F1C", VA = "0x1D84F1C", Slot = "15")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000043")]
		public override string Value
		{
			[Token(Token = "0x60000F6")]
			[Address(RVA = "0x1D84F44", Offset = "0x1D84F44", VA = "0x1D84F44", Slot = "9")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000F7")]
			[Address(RVA = "0x1D84F8C", Offset = "0x1D84F8C", VA = "0x1D84F8C", Slot = "10")]
			set
			{
			}
		}

		[Token(Token = "0x17000044")]
		public override bool AsBool
		{
			[Token(Token = "0x60000F8")]
			[Address(RVA = "0x1D84F90", Offset = "0x1D84F90", VA = "0x1D84F90", Slot = "35")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60000F9")]
			[Address(RVA = "0x1D84F98", Offset = "0x1D84F98", VA = "0x1D84F98", Slot = "36")]
			set
			{
			}
		}

		[Token(Token = "0x60000F1")]
		[Address(RVA = "0x1D84E0C", Offset = "0x1D84E0C", VA = "0x1D84E0C")]
		public static JSONNull CreateOrGet()
		{
			return null;
		}

		[Token(Token = "0x60000F2")]
		[Address(RVA = "0x1D84EAC", Offset = "0x1D84EAC", VA = "0x1D84EAC")]
		private JSONNull()
		{
		}

		[Token(Token = "0x60000F5")]
		[Address(RVA = "0x1D84F24", Offset = "0x1D84F24", VA = "0x1D84F24", Slot = "28")]
		public override Enumerator GetEnumerator()
		{
			return default(Enumerator);
		}

		[Token(Token = "0x60000FA")]
		[Address(RVA = "0x1D84F9C", Offset = "0x1D84F9C", VA = "0x1D84F9C", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x60000FB")]
		[Address(RVA = "0x1D85038", Offset = "0x1D85038", VA = "0x1D85038", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x60000FC")]
		[Address(RVA = "0x1D85040", Offset = "0x1D85040", VA = "0x1D85040", Slot = "27")]
		internal override void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode)
		{
		}

		[Token(Token = "0x60000FD")]
		[Address(RVA = "0x1D850A0", Offset = "0x1D850A0", VA = "0x1D850A0", Slot = "41")]
		public override void SerializeBinary(BinaryWriter aWriter)
		{
		}
	}
	[Token(Token = "0x2000013")]
	[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0x9D4E84", Offset = "0x9D4E84")]
	internal class JSONLazyCreator : JSONNode
	{
		[Token(Token = "0x400004D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private JSONNode m_Node;

		[Token(Token = "0x400004E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private string m_Key;

		[Token(Token = "0x17000045")]
		public override JSONNodeType Tag
		{
			[Token(Token = "0x60000FF")]
			[Address(RVA = "0xEEE318", Offset = "0xEEE318", VA = "0xEEE318", Slot = "4")]
			get
			{
				return default(JSONNodeType);
			}
		}

		[Token(Token = "0x17000046")]
		public override JSONNode Item
		{
			[Token(Token = "0x6000104")]
			[Address(RVA = "0xEEE3C0", Offset = "0xEEE3C0", VA = "0xEEE3C0", Slot = "5")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000105")]
			[Address(RVA = "0xEEE420", Offset = "0xEEE420", VA = "0xEEE420", Slot = "6")]
			set
			{
			}
		}

		[Token(Token = "0x17000047")]
		public override JSONNode Item
		{
			[Token(Token = "0x6000106")]
			[Address(RVA = "0xEEE4BC", Offset = "0xEEE4BC", VA = "0xEEE4BC", Slot = "7")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000107")]
			[Address(RVA = "0xEEE52C", Offset = "0xEEE52C", VA = "0xEEE52C", Slot = "8")]
			set
			{
			}
		}

		[Token(Token = "0x17000048")]
		public override int AsInt
		{
			[Token(Token = "0x600010E")]
			[Address(RVA = "0xEEE768", Offset = "0xEEE768", VA = "0xEEE768", Slot = "31")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600010F")]
			[Address(RVA = "0xEEE7E4", Offset = "0xEEE7E4", VA = "0xEEE7E4", Slot = "32")]
			set
			{
			}
		}

		[Token(Token = "0x17000049")]
		public override float AsFloat
		{
			[Token(Token = "0x6000110")]
			[Address(RVA = "0xEEE864", Offset = "0xEEE864", VA = "0xEEE864", Slot = "33")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000111")]
			[Address(RVA = "0xEEE8E0", Offset = "0xEEE8E0", VA = "0xEEE8E0", Slot = "34")]
			set
			{
			}
		}

		[Token(Token = "0x1700004A")]
		public override double AsDouble
		{
			[Token(Token = "0x6000112")]
			[Address(RVA = "0xEEE960", Offset = "0xEEE960", VA = "0xEEE960", Slot = "29")]
			get
			{
				return default(double);
			}
			[Token(Token = "0x6000113")]
			[Address(RVA = "0xEEE9DC", Offset = "0xEEE9DC", VA = "0xEEE9DC", Slot = "30")]
			set
			{
			}
		}

		[Token(Token = "0x1700004B")]
		public override long AsLong
		{
			[Token(Token = "0x6000114")]
			[Address(RVA = "0xEEEA5C", Offset = "0xEEEA5C", VA = "0xEEEA5C", Slot = "37")]
			get
			{
				return default(long);
			}
			[Token(Token = "0x6000115")]
			[Address(RVA = "0xEEEB3C", Offset = "0xEEEB3C", VA = "0xEEEB3C", Slot = "38")]
			set
			{
			}
		}

		[Token(Token = "0x1700004C")]
		public override bool AsBool
		{
			[Token(Token = "0x6000116")]
			[Address(RVA = "0xEEEC4C", Offset = "0xEEEC4C", VA = "0xEEEC4C", Slot = "35")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000117")]
			[Address(RVA = "0xEEECC4", Offset = "0xEEECC4", VA = "0xEEECC4", Slot = "36")]
			set
			{
			}
		}

		[Token(Token = "0x1700004D")]
		public override JSONArray AsArray
		{
			[Token(Token = "0x6000118")]
			[Address(RVA = "0xEEED40", Offset = "0xEEED40", VA = "0xEEED40", Slot = "39")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700004E")]
		public override JSONObject AsObject
		{
			[Token(Token = "0x6000119")]
			[Address(RVA = "0xEEEDAC", Offset = "0xEEEDAC", VA = "0xEEEDAC", Slot = "40")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000100")]
		[Address(RVA = "0xEEE320", Offset = "0xEEE320", VA = "0xEEE320", Slot = "28")]
		public override Enumerator GetEnumerator()
		{
			return default(Enumerator);
		}

		[Token(Token = "0x6000101")]
		[Address(RVA = "0xEED138", Offset = "0xEED138", VA = "0xEED138")]
		public JSONLazyCreator(JSONNode aNode)
		{
		}

		[Token(Token = "0x6000102")]
		[Address(RVA = "0xEEE340", Offset = "0xEEE340", VA = "0xEEE340")]
		public JSONLazyCreator(JSONNode aNode, string aKey)
		{
		}

		[Token(Token = "0x6000103")]
		private T Set<T>(T aVal) where T : JSONNode
		{
			return null;
		}

		[Token(Token = "0x6000108")]
		[Address(RVA = "0xEEE5D4", Offset = "0xEEE5D4", VA = "0xEEE5D4", Slot = "21")]
		public override void Add(JSONNode aItem)
		{
		}

		[Token(Token = "0x6000109")]
		[Address(RVA = "0xEEE670", Offset = "0xEEE670", VA = "0xEEE670", Slot = "20")]
		public override void Add(string aKey, JSONNode aItem)
		{
		}

		[Token(Token = "0x600010A")]
		[Address(RVA = "0xEEE718", Offset = "0xEEE718", VA = "0xEEE718")]
		public static bool operator ==(JSONLazyCreator a, object b)
		{
			return default(bool);
		}

		[Token(Token = "0x600010B")]
		[Address(RVA = "0xEEE730", Offset = "0xEEE730", VA = "0xEEE730")]
		public static bool operator !=(JSONLazyCreator a, object b)
		{
			return default(bool);
		}

		[Token(Token = "0x600010C")]
		[Address(RVA = "0xEEE748", Offset = "0xEEE748", VA = "0xEEE748", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x600010D")]
		[Address(RVA = "0xEEE760", Offset = "0xEEE760", VA = "0xEEE760", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x600011A")]
		[Address(RVA = "0xEEEE1C", Offset = "0xEEEE1C", VA = "0xEEEE1C", Slot = "27")]
		internal override void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode)
		{
		}

		[Token(Token = "0x600011B")]
		[Address(RVA = "0xEEEE7C", Offset = "0xEEEE7C", VA = "0xEEEE7C", Slot = "41")]
		public override void SerializeBinary(BinaryWriter aWriter)
		{
		}
	}
	[Token(Token = "0x2000014")]
	public static class JSON
	{
		[Token(Token = "0x600011C")]
		[Address(RVA = "0xEEC734", Offset = "0xEEC734", VA = "0xEEC734")]
		public static JSONNode Parse(string aJSON)
		{
			return null;
		}
	}
	[Token(Token = "0x2000015")]
	public enum JSONContainerType
	{
		[Token(Token = "0x4000050")]
		Array,
		[Token(Token = "0x4000051")]
		Object
	}
}
namespace RootMotion
{
	[Token(Token = "0x2000016")]
	public class CameraController : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000136")]
		public enum UpdateMode
		{
			[Token(Token = "0x40007FC")]
			Update,
			[Token(Token = "0x40007FD")]
			FixedUpdate,
			[Token(Token = "0x40007FE")]
			LateUpdate
		}

		[Token(Token = "0x4000052")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform target;

		[Token(Token = "0x4000053")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform rotationSpace;

		[Token(Token = "0x4000054")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public UpdateMode updateMode;

		[Token(Token = "0x4000055")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public bool lockCursor;

		[Token(Token = "0x4000056")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2D")]
		public bool smoothFollow;

		[Token(Token = "0x4000057")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float followSpeed;

		[Token(Token = "0x4000058")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float distance;

		[Token(Token = "0x4000059")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float minDistance;

		[Token(Token = "0x400005A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float maxDistance;

		[Token(Token = "0x400005B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float zoomSpeed;

		[Token(Token = "0x400005C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float zoomSensitivity;

		[Token(Token = "0x400005D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float rotationSensitivity;

		[Token(Token = "0x400005E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public float yMinLimit;

		[Token(Token = "0x400005F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public float yMaxLimit;

		[Token(Token = "0x4000060")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public Vector3 offset;

		[Token(Token = "0x4000061")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public bool rotateAlways;

		[Token(Token = "0x4000062")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x61")]
		public bool rotateOnLeftButton;

		[Token(Token = "0x4000063")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x62")]
		public bool rotateOnRightButton;

		[Token(Token = "0x4000064")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x63")]
		public bool rotateOnMiddleButton;

		[Token(Token = "0x4000065")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9D6218", Offset = "0x9D6218")]
		private float <x>k__BackingField;

		[Token(Token = "0x4000066")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9D6228", Offset = "0x9D6228")]
		private float <y>k__BackingField;

		[Token(Token = "0x4000067")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9D6238", Offset = "0x9D6238")]
		private float <distanceTarget>k__BackingField;

		[Token(Token = "0x4000068")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Vector3 targetDistance;

		[Token(Token = "0x4000069")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private Vector3 position;

		[Token(Token = "0x400006A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Quaternion rotation;

		[Token(Token = "0x400006B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Vector3 smoothPosition;

		[Token(Token = "0x400006C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Camera cam;

		[Token(Token = "0x400006D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Quaternion r;

		[Token(Token = "0x400006E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private Vector3 lastUp;

		[Token(Token = "0x1700004F")]
		public float x
		{
			[Token(Token = "0x600011D")]
			[Address(RVA = "0x126D39C", Offset = "0x126D39C", VA = "0x126D39C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DD66C", Offset = "0x9DD66C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600011E")]
			[Address(RVA = "0x126D3A4", Offset = "0x126D3A4", VA = "0x126D3A4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DD67C", Offset = "0x9DD67C")]
			private set
			{
			}
		}

		[Token(Token = "0x17000050")]
		public float y
		{
			[Token(Token = "0x600011F")]
			[Address(RVA = "0x126D3AC", Offset = "0x126D3AC", VA = "0x126D3AC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DD68C", Offset = "0x9DD68C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000120")]
			[Address(RVA = "0x126D3B4", Offset = "0x126D3B4", VA = "0x126D3B4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DD69C", Offset = "0x9DD69C")]
			private set
			{
			}
		}

		[Token(Token = "0x17000051")]
		public float distanceTarget
		{
			[Token(Token = "0x6000121")]
			[Address(RVA = "0x126D3BC", Offset = "0x126D3BC", VA = "0x126D3BC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DD6AC", Offset = "0x9DD6AC")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000122")]
			[Address(RVA = "0x126D3C4", Offset = "0x126D3C4", VA = "0x126D3C4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DD6BC", Offset = "0x9DD6BC")]
			private set
			{
			}
		}

		[Token(Token = "0x17000052")]
		private float zoomAdd
		{
			[Token(Token = "0x600012A")]
			[Address(RVA = "0x126D860", Offset = "0x126D860", VA = "0x126D860")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x6000123")]
		[Address(RVA = "0x126D3CC", Offset = "0x126D3CC", VA = "0x126D3CC", Slot = "4")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x6000124")]
		[Address(RVA = "0x126D508", Offset = "0x126D508", VA = "0x126D508", Slot = "5")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x6000125")]
		[Address(RVA = "0x126D56C", Offset = "0x126D56C", VA = "0x126D56C", Slot = "6")]
		protected virtual void FixedUpdate()
		{
		}

		[Token(Token = "0x6000126")]
		[Address(RVA = "0x126D5AC", Offset = "0x126D5AC", VA = "0x126D5AC", Slot = "7")]
		protected virtual void LateUpdate()
		{
		}

		[Token(Token = "0x6000127")]
		[Address(RVA = "0x126D5F0", Offset = "0x126D5F0", VA = "0x126D5F0")]
		public void UpdateInput()
		{
		}

		[Token(Token = "0x6000128")]
		[Address(RVA = "0x126D544", Offset = "0x126D544", VA = "0x126D544")]
		public void UpdateTransform()
		{
		}

		[Token(Token = "0x6000129")]
		[Address(RVA = "0x126D8D4", Offset = "0x126D8D4", VA = "0x126D8D4")]
		public void UpdateTransform(float deltaTime)
		{
		}

		[Token(Token = "0x600012B")]
		[Address(RVA = "0x126D7B0", Offset = "0x126D7B0", VA = "0x126D7B0")]
		private float ClampAngle(float angle, float min, float max)
		{
			return default(float);
		}

		[Token(Token = "0x600012C")]
		[Address(RVA = "0x126DDA0", Offset = "0x126DDA0", VA = "0x126DDA0")]
		public CameraController()
		{
		}
	}
	[Token(Token = "0x2000017")]
	public class CameraControllerFPS : MonoBehaviour
	{
		[Token(Token = "0x400006F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float rotationSensitivity;

		[Token(Token = "0x4000070")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float yMinLimit;

		[Token(Token = "0x4000071")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float yMaxLimit;

		[Token(Token = "0x4000072")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private float x;

		[Token(Token = "0x4000073")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float y;

		[Token(Token = "0x600012D")]
		[Address(RVA = "0x126DE94", Offset = "0x126DE94", VA = "0x126DE94")]
		private void Awake()
		{
		}

		[Token(Token = "0x600012E")]
		[Address(RVA = "0x126DED4", Offset = "0x126DED4", VA = "0x126DED4")]
		public void LateUpdate()
		{
		}

		[Token(Token = "0x600012F")]
		[Address(RVA = "0x126E0B0", Offset = "0x126E0B0", VA = "0x126E0B0")]
		private float ClampAngle(float angle, float min, float max)
		{
			return default(float);
		}

		[Token(Token = "0x6000130")]
		[Address(RVA = "0x126E160", Offset = "0x126E160", VA = "0x126E160")]
		public CameraControllerFPS()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000018")]
	public enum Axis
	{
		[Token(Token = "0x4000075")]
		X,
		[Token(Token = "0x4000076")]
		Y,
		[Token(Token = "0x4000077")]
		Z
	}
	[Token(Token = "0x2000019")]
	public class AxisTools
	{
		[Token(Token = "0x6000131")]
		[Address(RVA = "0x12649BC", Offset = "0x12649BC", VA = "0x12649BC")]
		public static Vector3 ToVector3(Axis axis)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000132")]
		[Address(RVA = "0x1264A7C", Offset = "0x1264A7C", VA = "0x1264A7C")]
		public static Axis ToAxis(Vector3 v)
		{
			return default(Axis);
		}

		[Token(Token = "0x6000133")]
		[Address(RVA = "0x1264B28", Offset = "0x1264B28", VA = "0x1264B28")]
		public static Axis GetAxisToPoint(Transform t, Vector3 worldPosition)
		{
			return default(Axis);
		}

		[Token(Token = "0x6000134")]
		[Address(RVA = "0x1264D10", Offset = "0x1264D10", VA = "0x1264D10")]
		public static Axis GetAxisToDirection(Transform t, Vector3 direction)
		{
			return default(Axis);
		}

		[Token(Token = "0x6000135")]
		[Address(RVA = "0x1264C44", Offset = "0x1264C44", VA = "0x1264C44")]
		public static Vector3 GetAxisVectorToPoint(Transform t, Vector3 worldPosition)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000136")]
		[Address(RVA = "0x1264E2C", Offset = "0x1264E2C", VA = "0x1264E2C")]
		public static Vector3 GetAxisVectorToDirection(Transform t, Vector3 direction)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000137")]
		[Address(RVA = "0x1265074", Offset = "0x1265074", VA = "0x1265074")]
		public AxisTools()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200001A")]
	public class BipedLimbOrientations
	{
		[Serializable]
		[Token(Token = "0x2000137")]
		public class LimbOrientation
		{
			[Token(Token = "0x40007FF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Vector3 upperBoneForwardAxis;

			[Token(Token = "0x4000800")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public Vector3 lowerBoneForwardAxis;

			[Token(Token = "0x4000801")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Vector3 lastBoneLeftAxis;

			[Token(Token = "0x6000983")]
			[Address(RVA = "0x126533C", Offset = "0x126533C", VA = "0x126533C")]
			public LimbOrientation(Vector3 upperBoneForwardAxis, Vector3 lowerBoneForwardAxis, Vector3 lastBoneLeftAxis)
			{
			}
		}

		[Token(Token = "0x4000078")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public LimbOrientation leftArm;

		[Token(Token = "0x4000079")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public LimbOrientation rightArm;

		[Token(Token = "0x400007A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public LimbOrientation leftLeg;

		[Token(Token = "0x400007B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public LimbOrientation rightLeg;

		[Token(Token = "0x17000053")]
		public static BipedLimbOrientations UMA
		{
			[Token(Token = "0x6000139")]
			[Address(RVA = "0x12650C8", Offset = "0x12650C8", VA = "0x12650C8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000054")]
		public static BipedLimbOrientations MaxBiped
		{
			[Token(Token = "0x600013A")]
			[Address(RVA = "0x12653B8", Offset = "0x12653B8", VA = "0x12653B8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000138")]
		[Address(RVA = "0x126507C", Offset = "0x126507C", VA = "0x126507C")]
		public BipedLimbOrientations(LimbOrientation leftArm, LimbOrientation rightArm, LimbOrientation leftLeg, LimbOrientation rightLeg)
		{
		}
	}
	[Token(Token = "0x200001B")]
	public static class BipedNaming
	{
		[Serializable]
		[Token(Token = "0x2000138")]
		public enum BoneType
		{
			[Token(Token = "0x4000803")]
			Unassigned,
			[Token(Token = "0x4000804")]
			Spine,
			[Token(Token = "0x4000805")]
			Head,
			[Token(Token = "0x4000806")]
			Arm,
			[Token(Token = "0x4000807")]
			Leg,
			[Token(Token = "0x4000808")]
			Tail,
			[Token(Token = "0x4000809")]
			Eye
		}

		[Serializable]
		[Token(Token = "0x2000139")]
		public enum BoneSide
		{
			[Token(Token = "0x400080B")]
			Center,
			[Token(Token = "0x400080C")]
			Left,
			[Token(Token = "0x400080D")]
			Right
		}

		[Token(Token = "0x400007C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static string[] typeLeft;

		[Token(Token = "0x400007D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static string[] typeRight;

		[Token(Token = "0x400007E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static string[] typeSpine;

		[Token(Token = "0x400007F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public static string[] typeHead;

		[Token(Token = "0x4000080")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public static string[] typeArm;

		[Token(Token = "0x4000081")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public static string[] typeLeg;

		[Token(Token = "0x4000082")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public static string[] typeTail;

		[Token(Token = "0x4000083")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public static string[] typeEye;

		[Token(Token = "0x4000084")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public static string[] typeExclude;

		[Token(Token = "0x4000085")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public static string[] typeExcludeSpine;

		[Token(Token = "0x4000086")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public static string[] typeExcludeHead;

		[Token(Token = "0x4000087")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public static string[] typeExcludeArm;

		[Token(Token = "0x4000088")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public static string[] typeExcludeLeg;

		[Token(Token = "0x4000089")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public static string[] typeExcludeTail;

		[Token(Token = "0x400008A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public static string[] typeExcludeEye;

		[Token(Token = "0x400008B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public static string[] pelvis;

		[Token(Token = "0x400008C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public static string[] hand;

		[Token(Token = "0x400008D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public static string[] foot;

		[Token(Token = "0x600013B")]
		[Address(RVA = "0x126562C", Offset = "0x126562C", VA = "0x126562C")]
		public static Transform[] GetBonesOfType(BoneType boneType, Transform[] bones)
		{
			return null;
		}

		[Token(Token = "0x600013C")]
		[Address(RVA = "0x1265970", Offset = "0x1265970", VA = "0x1265970")]
		public static Transform[] GetBonesOfSide(BoneSide boneSide, Transform[] bones)
		{
			return null;
		}

		[Token(Token = "0x600013D")]
		[Address(RVA = "0x1265C04", Offset = "0x1265C04", VA = "0x1265C04")]
		public static Transform[] GetBonesOfTypeAndSide(BoneType boneType, BoneSide boneSide, Transform[] bones)
		{
			return null;
		}

		[Token(Token = "0x600013E")]
		[Address(RVA = "0x1265C88", Offset = "0x1265C88", VA = "0x1265C88")]
		public static Transform GetFirstBoneOfTypeAndSide(BoneType boneType, BoneSide boneSide, Transform[] bones)
		{
			return null;
		}

		[Token(Token = "0x600013F")]
		[Address(RVA = "0x1265D3C", Offset = "0x1265D3C", VA = "0x1265D3C")]
		public static Transform GetNamingMatch(Transform[] transforms, params string[][] namings)
		{
			return null;
		}

		[Token(Token = "0x6000140")]
		[Address(RVA = "0x1265820", Offset = "0x1265820", VA = "0x1265820")]
		public static BoneType GetBoneType(string boneName)
		{
			return default(BoneType);
		}

		[Token(Token = "0x6000141")]
		[Address(RVA = "0x1265B64", Offset = "0x1265B64", VA = "0x1265B64")]
		public static BoneSide GetBoneSide(string boneName)
		{
			return default(BoneSide);
		}

		[Token(Token = "0x6000142")]
		[Address(RVA = "0x1266590", Offset = "0x1266590", VA = "0x1266590")]
		public static Transform GetBone(Transform[] transforms, BoneType boneType, BoneSide boneSide = BoneSide.Center, params string[][] namings)
		{
			return null;
		}

		[Token(Token = "0x6000143")]
		[Address(RVA = "0x12663A8", Offset = "0x12663A8", VA = "0x12663A8")]
		private static bool isLeft(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000144")]
		[Address(RVA = "0x126649C", Offset = "0x126649C", VA = "0x126649C")]
		private static bool isRight(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000145")]
		[Address(RVA = "0x1265F70", Offset = "0x1265F70", VA = "0x1265F70")]
		private static bool isSpine(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000146")]
		[Address(RVA = "0x1266024", Offset = "0x1266024", VA = "0x1266024")]
		private static bool isHead(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000147")]
		[Address(RVA = "0x12660D8", Offset = "0x12660D8", VA = "0x12660D8")]
		private static bool isArm(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000148")]
		[Address(RVA = "0x126618C", Offset = "0x126618C", VA = "0x126618C")]
		private static bool isLeg(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000149")]
		[Address(RVA = "0x1266240", Offset = "0x1266240", VA = "0x1266240")]
		private static bool isTail(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x600014A")]
		[Address(RVA = "0x12662F4", Offset = "0x12662F4", VA = "0x12662F4")]
		private static bool isEye(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x600014B")]
		[Address(RVA = "0x126680C", Offset = "0x126680C", VA = "0x126680C")]
		private static bool isTypeExclude(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x600014C")]
		[Address(RVA = "0x1265E7C", Offset = "0x1265E7C", VA = "0x1265E7C")]
		private static bool matchesNaming(string boneName, string[] namingConvention)
		{
			return default(bool);
		}

		[Token(Token = "0x600014D")]
		[Address(RVA = "0x1266774", Offset = "0x1266774", VA = "0x1266774")]
		private static bool excludesNaming(string boneName, string[] namingConvention)
		{
			return default(bool);
		}

		[Token(Token = "0x600014E")]
		[Address(RVA = "0x126687C", Offset = "0x126687C", VA = "0x126687C")]
		private static bool matchesLastLetter(string boneName, string[] namingConvention)
		{
			return default(bool);
		}

		[Token(Token = "0x600014F")]
		[Address(RVA = "0x1266950", Offset = "0x1266950", VA = "0x1266950")]
		private static bool LastLetterIs(string boneName, string letter)
		{
			return default(bool);
		}

		[Token(Token = "0x6000150")]
		[Address(RVA = "0x12666E0", Offset = "0x12666E0", VA = "0x12666E0")]
		private static string firstLetter(string boneName)
		{
			return null;
		}

		[Token(Token = "0x6000151")]
		[Address(RVA = "0x1266620", Offset = "0x1266620", VA = "0x1266620")]
		private static string lastLetter(string boneName)
		{
			return null;
		}
	}
	[Serializable]
	[Token(Token = "0x200001C")]
	public class BipedReferences
	{
		[Token(Token = "0x200013A")]
		public struct AutoDetectParams
		{
			[Token(Token = "0x400080E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public bool legsParentInSpine;

			[Token(Token = "0x400080F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1")]
			public bool includeEyes;

			[Token(Token = "0x1700018D")]
			public static AutoDetectParams Default
			{
				[Token(Token = "0x6000985")]
				[Address(RVA = "0x126D394", Offset = "0x126D394", VA = "0x126D394")]
				get
				{
					return default(AutoDetectParams);
				}
			}

			[Token(Token = "0x6000984")]
			[Address(RVA = "0xA97BC8", Offset = "0xA97BC8", VA = "0xA97BC8")]
			public AutoDetectParams(bool legsParentInSpine, bool includeEyes)
			{
			}
		}

		[Token(Token = "0x400008E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform root;

		[Token(Token = "0x400008F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform pelvis;

		[Token(Token = "0x4000090")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform leftThigh;

		[Token(Token = "0x4000091")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform leftCalf;

		[Token(Token = "0x4000092")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Transform leftFoot;

		[Token(Token = "0x4000093")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Transform rightThigh;

		[Token(Token = "0x4000094")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Transform rightCalf;

		[Token(Token = "0x4000095")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Transform rightFoot;

		[Token(Token = "0x4000096")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Transform leftUpperArm;

		[Token(Token = "0x4000097")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform leftForearm;

		[Token(Token = "0x4000098")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Transform leftHand;

		[Token(Token = "0x4000099")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Transform rightUpperArm;

		[Token(Token = "0x400009A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Transform rightForearm;

		[Token(Token = "0x400009B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Transform rightHand;

		[Token(Token = "0x400009C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public Transform head;

		[Token(Token = "0x400009D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public Transform[] spine;

		[Token(Token = "0x400009E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public Transform[] eyes;

		[Token(Token = "0x17000055")]
		public virtual bool isFilled
		{
			[Token(Token = "0x6000153")]
			[Address(RVA = "0x1269434", Offset = "0x1269434", VA = "0x1269434", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000056")]
		public bool isEmpty
		{
			[Token(Token = "0x6000154")]
			[Address(RVA = "0x1269838", Offset = "0x1269838", VA = "0x1269838")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000155")]
		[Address(RVA = "0x1269848", Offset = "0x1269848", VA = "0x1269848", Slot = "5")]
		public virtual bool IsEmpty(bool includeRoot)
		{
			return default(bool);
		}

		[Token(Token = "0x6000156")]
		[Address(RVA = "0x1269C8C", Offset = "0x1269C8C", VA = "0x1269C8C", Slot = "6")]
		public virtual bool Contains(Transform t, bool ignoreRoot = false)
		{
			return default(bool);
		}

		[Token(Token = "0x6000157")]
		[Address(RVA = "0x126A0D4", Offset = "0x126A0D4", VA = "0x126A0D4")]
		public static bool AutoDetectReferences(ref BipedReferences references, Transform root, AutoDetectParams autoDetectParams)
		{
			return default(bool);
		}

		[Token(Token = "0x6000158")]
		[Address(RVA = "0x126A91C", Offset = "0x126A91C", VA = "0x126A91C")]
		public static void DetectReferencesByNaming(ref BipedReferences references, Transform root, AutoDetectParams autoDetectParams)
		{
		}

		[Token(Token = "0x6000159")]
		[Address(RVA = "0x126A358", Offset = "0x126A358", VA = "0x126A358")]
		public static void AssignHumanoidReferences(ref BipedReferences references, Animator animator, AutoDetectParams autoDetectParams)
		{
		}

		[Token(Token = "0x600015A")]
		[Address(RVA = "0x126B400", Offset = "0x126B400", VA = "0x126B400")]
		public static bool SetupError(BipedReferences references, ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x600015B")]
		[Address(RVA = "0x126B4F8", Offset = "0x126B4F8", VA = "0x126B4F8")]
		public static bool SetupWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x600015C")]
		[Address(RVA = "0x126BB28", Offset = "0x126BB28", VA = "0x126BB28")]
		private static bool IsNeckBone(Transform bone, Transform leftUpperArm)
		{
			return default(bool);
		}

		[Token(Token = "0x600015D")]
		[Address(RVA = "0x126B8F8", Offset = "0x126B8F8", VA = "0x126B8F8")]
		private static bool AddBoneToEyes(Transform bone, ref BipedReferences references, AutoDetectParams autoDetectParams)
		{
			return default(bool);
		}

		[Token(Token = "0x600015E")]
		[Address(RVA = "0x126B740", Offset = "0x126B740", VA = "0x126B740")]
		private static bool AddBoneToSpine(Transform bone, ref BipedReferences references, AutoDetectParams autoDetectParams)
		{
			return default(bool);
		}

		[Token(Token = "0x600015F")]
		[Address(RVA = "0x126B5D0", Offset = "0x126B5D0", VA = "0x126B5D0")]
		private static void DetectLimb(BipedNaming.BoneType boneType, BipedNaming.BoneSide boneSide, ref Transform firstBone, ref Transform secondBone, ref Transform lastBone, Transform[] transforms)
		{
		}

		[Token(Token = "0x6000160")]
		[Address(RVA = "0x126BA10", Offset = "0x126BA10", VA = "0x126BA10")]
		private static void AddBoneToHierarchy(ref Transform[] bones, Transform transform)
		{
		}

		[Token(Token = "0x6000161")]
		[Address(RVA = "0x126BC34", Offset = "0x126BC34", VA = "0x126BC34")]
		private static bool LimbError(Transform bone1, Transform bone2, Transform bone3, ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000162")]
		[Address(RVA = "0x126CA24", Offset = "0x126CA24", VA = "0x126CA24")]
		private static bool LimbWarning(Transform bone1, Transform bone2, Transform bone3, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000163")]
		[Address(RVA = "0x126C388", Offset = "0x126C388", VA = "0x126C388")]
		private static bool SpineError(BipedReferences references, ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000164")]
		[Address(RVA = "0x126CDDC", Offset = "0x126CDDC", VA = "0x126CDDC")]
		private static bool SpineWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000165")]
		[Address(RVA = "0x126C80C", Offset = "0x126C80C", VA = "0x126C80C")]
		private static bool EyesError(BipedReferences references, ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000166")]
		[Address(RVA = "0x126CDE4", Offset = "0x126CDE4", VA = "0x126CDE4")]
		private static bool EyesWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000167")]
		[Address(RVA = "0x126CDEC", Offset = "0x126CDEC", VA = "0x126CDEC")]
		private static bool RootHeightWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000168")]
		[Address(RVA = "0x126CFF8", Offset = "0x126CFF8", VA = "0x126CFF8")]
		private static bool FacingAxisWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000169")]
		[Address(RVA = "0x126D25C", Offset = "0x126D25C", VA = "0x126D25C")]
		private static float GetVerticalOffset(Vector3 p1, Vector3 p2, Quaternion rotation)
		{
			return default(float);
		}

		[Token(Token = "0x600016A")]
		[Address(RVA = "0x126A2E8", Offset = "0x126A2E8", VA = "0x126A2E8")]
		public BipedReferences()
		{
		}
	}
	[Token(Token = "0x200001D")]
	public class Comments : MonoBehaviour
	{
		[Token(Token = "0x400009F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Multiline]
		public string text;

		[Token(Token = "0x600016B")]
		[Address(RVA = "0x126E17C", Offset = "0x126E17C", VA = "0x126E17C")]
		public Comments()
		{
		}
	}
	[Token(Token = "0x200001E")]
	public class DemoGUIMessage : MonoBehaviour
	{
		[Token(Token = "0x40000A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string text;

		[Token(Token = "0x40000A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Color color;

		[Token(Token = "0x600016C")]
		[Address(RVA = "0x126E184", Offset = "0x126E184", VA = "0x126E184")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x600016D")]
		[Address(RVA = "0x126E244", Offset = "0x126E244", VA = "0x126E244")]
		public DemoGUIMessage()
		{
		}
	}
	[Token(Token = "0x200001F")]
	public class Hierarchy
	{
		[Token(Token = "0x600016E")]
		[Address(RVA = "0xEE8300", Offset = "0xEE8300", VA = "0xEE8300")]
		public static bool HierarchyIsValid(Transform[] bones)
		{
			return default(bool);
		}

		[Token(Token = "0x600016F")]
		[Address(RVA = "0xEE8534", Offset = "0xEE8534", VA = "0xEE8534")]
		public static UnityEngine.Object ContainsDuplicate(UnityEngine.Object[] objects)
		{
			return null;
		}

		[Token(Token = "0x6000170")]
		[Address(RVA = "0xEE83B0", Offset = "0xEE83B0", VA = "0xEE83B0")]
		public static bool IsAncestor(Transform transform, Transform ancestor)
		{
			return default(bool);
		}

		[Token(Token = "0x6000171")]
		[Address(RVA = "0xEE8680", Offset = "0xEE8680", VA = "0xEE8680")]
		public static bool ContainsChild(Transform transform, Transform child)
		{
			return default(bool);
		}

		[Token(Token = "0x6000172")]
		[Address(RVA = "0xEE87A8", Offset = "0xEE87A8", VA = "0xEE87A8")]
		public static void AddAncestors(Transform transform, Transform blocker, ref Transform[] array)
		{
		}

		[Token(Token = "0x6000173")]
		[Address(RVA = "0xEE8AF8", Offset = "0xEE8AF8", VA = "0xEE8AF8")]
		public static Transform GetAncestor(Transform transform, int minChildCount)
		{
			return null;
		}

		[Token(Token = "0x6000174")]
		[Address(RVA = "0xEE8C3C", Offset = "0xEE8C3C", VA = "0xEE8C3C")]
		public static Transform GetFirstCommonAncestor(Transform t1, Transform t2)
		{
			return null;
		}

		[Token(Token = "0x6000175")]
		[Address(RVA = "0xEE8DE8", Offset = "0xEE8DE8", VA = "0xEE8DE8")]
		public static Transform GetFirstCommonAncestor(Transform[] transforms)
		{
			return null;
		}

		[Token(Token = "0x6000176")]
		[Address(RVA = "0xEE91D0", Offset = "0xEE91D0", VA = "0xEE91D0")]
		public static Transform GetFirstCommonAncestorRecursive(Transform transform, Transform[] transforms)
		{
			return null;
		}

		[Token(Token = "0x6000177")]
		[Address(RVA = "0xEE8F9C", Offset = "0xEE8F9C", VA = "0xEE8F9C")]
		public static bool IsCommonAncestor(Transform transform, Transform[] transforms)
		{
			return default(bool);
		}

		[Token(Token = "0x6000178")]
		[Address(RVA = "0xEE9380", Offset = "0xEE9380", VA = "0xEE9380")]
		public Hierarchy()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000020")]
	public enum InterpolationMode
	{
		[Token(Token = "0x40000A3")]
		None,
		[Token(Token = "0x40000A4")]
		InOutCubic,
		[Token(Token = "0x40000A5")]
		InOutQuintic,
		[Token(Token = "0x40000A6")]
		InOutSine,
		[Token(Token = "0x40000A7")]
		InQuintic,
		[Token(Token = "0x40000A8")]
		InQuartic,
		[Token(Token = "0x40000A9")]
		InCubic,
		[Token(Token = "0x40000AA")]
		InQuadratic,
		[Token(Token = "0x40000AB")]
		InElastic,
		[Token(Token = "0x40000AC")]
		InElasticSmall,
		[Token(Token = "0x40000AD")]
		InElasticBig,
		[Token(Token = "0x40000AE")]
		InSine,
		[Token(Token = "0x40000AF")]
		InBack,
		[Token(Token = "0x40000B0")]
		OutQuintic,
		[Token(Token = "0x40000B1")]
		OutQuartic,
		[Token(Token = "0x40000B2")]
		OutCubic,
		[Token(Token = "0x40000B3")]
		OutInCubic,
		[Token(Token = "0x40000B4")]
		OutInQuartic,
		[Token(Token = "0x40000B5")]
		OutElastic,
		[Token(Token = "0x40000B6")]
		OutElasticSmall,
		[Token(Token = "0x40000B7")]
		OutElasticBig,
		[Token(Token = "0x40000B8")]
		OutSine,
		[Token(Token = "0x40000B9")]
		OutBack,
		[Token(Token = "0x40000BA")]
		OutBackCubic,
		[Token(Token = "0x40000BB")]
		OutBackQuartic,
		[Token(Token = "0x40000BC")]
		BackInCubic,
		[Token(Token = "0x40000BD")]
		BackInQuartic
	}
	[Token(Token = "0x2000021")]
	public class Interp
	{
		[Token(Token = "0x6000179")]
		[Address(RVA = "0xED5214", Offset = "0xED5214", VA = "0xED5214")]
		public static float Float(float t, InterpolationMode mode)
		{
			return default(float);
		}

		[Token(Token = "0x600017A")]
		[Address(RVA = "0xEE9A88", Offset = "0xEE9A88", VA = "0xEE9A88")]
		public static Vector3 V3(Vector3 v1, Vector3 v2, float t, InterpolationMode mode)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600017B")]
		[Address(RVA = "0xEE9B90", Offset = "0xEE9B90", VA = "0xEE9B90")]
		public static float LerpValue(float value, float target, float increaseSpeed, float decreaseSpeed)
		{
			return default(float);
		}

		[Token(Token = "0x600017C")]
		[Address(RVA = "0xEE9388", Offset = "0xEE9388", VA = "0xEE9388")]
		private static float None(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600017D")]
		[Address(RVA = "0xEE9394", Offset = "0xEE9394", VA = "0xEE9394")]
		private static float InOutCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600017E")]
		[Address(RVA = "0xEE93BC", Offset = "0xEE93BC", VA = "0xEE93BC")]
		private static float InOutQuintic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600017F")]
		[Address(RVA = "0xEE93F8", Offset = "0xEE93F8", VA = "0xEE93F8")]
		private static float InQuintic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000180")]
		[Address(RVA = "0xEE9410", Offset = "0xEE9410", VA = "0xEE9410")]
		private static float InQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000181")]
		[Address(RVA = "0xEE9424", Offset = "0xEE9424", VA = "0xEE9424")]
		private static float InCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000182")]
		[Address(RVA = "0xEE9438", Offset = "0xEE9438", VA = "0xEE9438")]
		private static float InQuadratic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000183")]
		[Address(RVA = "0xEE9448", Offset = "0xEE9448", VA = "0xEE9448")]
		private static float OutQuintic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000184")]
		[Address(RVA = "0xEE9490", Offset = "0xEE9490", VA = "0xEE9490")]
		private static float OutQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000185")]
		[Address(RVA = "0xEE94C8", Offset = "0xEE94C8", VA = "0xEE94C8")]
		private static float OutCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000186")]
		[Address(RVA = "0xEE94F0", Offset = "0xEE94F0", VA = "0xEE94F0")]
		private static float OutInCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000187")]
		[Address(RVA = "0xEE9C8C", Offset = "0xEE9C8C", VA = "0xEE9C8C")]
		private static float OutInQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000188")]
		[Address(RVA = "0xEE9524", Offset = "0xEE9524", VA = "0xEE9524")]
		private static float BackInCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000189")]
		[Address(RVA = "0xEE954C", Offset = "0xEE954C", VA = "0xEE954C")]
		private static float BackInQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600018A")]
		[Address(RVA = "0xEE957C", Offset = "0xEE957C", VA = "0xEE957C")]
		private static float OutBackCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600018B")]
		[Address(RVA = "0xEE95B0", Offset = "0xEE95B0", VA = "0xEE95B0")]
		private static float OutBackQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600018C")]
		[Address(RVA = "0xEE95F4", Offset = "0xEE95F4", VA = "0xEE95F4")]
		private static float OutElasticSmall(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600018D")]
		[Address(RVA = "0xEE9658", Offset = "0xEE9658", VA = "0xEE9658")]
		private static float OutElasticBig(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600018E")]
		[Address(RVA = "0xEE96BC", Offset = "0xEE96BC", VA = "0xEE96BC")]
		private static float InElasticSmall(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600018F")]
		[Address(RVA = "0xEE9710", Offset = "0xEE9710", VA = "0xEE9710")]
		private static float InElasticBig(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000190")]
		[Address(RVA = "0xEE9764", Offset = "0xEE9764", VA = "0xEE9764")]
		private static float InSine(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000191")]
		[Address(RVA = "0xEE97FC", Offset = "0xEE97FC", VA = "0xEE97FC")]
		private static float OutSine(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000192")]
		[Address(RVA = "0xEE9890", Offset = "0xEE9890", VA = "0xEE9890")]
		private static float InOutSine(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000193")]
		[Address(RVA = "0xEE9CC0", Offset = "0xEE9CC0", VA = "0xEE9CC0")]
		private static float InElastic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000194")]
		[Address(RVA = "0xEE9934", Offset = "0xEE9934", VA = "0xEE9934")]
		private static float OutElastic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000195")]
		[Address(RVA = "0xEE9A18", Offset = "0xEE9A18", VA = "0xEE9A18")]
		private static float InBack(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000196")]
		[Address(RVA = "0xEE9A48", Offset = "0xEE9A48", VA = "0xEE9A48")]
		private static float OutBack(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000197")]
		[Address(RVA = "0xEE9DA8", Offset = "0xEE9DA8", VA = "0xEE9DA8")]
		public Interp()
		{
		}
	}
	[Token(Token = "0x2000022")]
	public class LargeHeader : PropertyAttribute
	{
		[Token(Token = "0x40000BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string name;

		[Token(Token = "0x40000BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string color;

		[Token(Token = "0x6000198")]
		[Address(RVA = "0xEE9DB0", Offset = "0xEE9DB0", VA = "0xEE9DB0")]
		public LargeHeader(string name)
		{
		}

		[Token(Token = "0x6000199")]
		[Address(RVA = "0xEE9E20", Offset = "0xEE9E20", VA = "0xEE9E20")]
		public LargeHeader(string name, string color)
		{
		}
	}
	[Token(Token = "0x2000023")]
	public static class LayerMaskExtensions
	{
		[Token(Token = "0x600019A")]
		[Address(RVA = "0xEE9E90", Offset = "0xEE9E90", VA = "0xEE9E90")]
		public static bool Contains(LayerMask mask, int layer)
		{
			return default(bool);
		}

		[Token(Token = "0x600019B")]
		[Address(RVA = "0xEE9EEC", Offset = "0xEE9EEC", VA = "0xEE9EEC")]
		public static LayerMask Create(params string[] layerNames)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x600019C")]
		[Address(RVA = "0xEE9FC4", Offset = "0xEE9FC4", VA = "0xEE9FC4")]
		public static LayerMask Create(params int[] layerNumbers)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x600019D")]
		[Address(RVA = "0xEE9F04", Offset = "0xEE9F04", VA = "0xEE9F04")]
		public static LayerMask NamesToMask(params string[] layerNames)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x600019E")]
		[Address(RVA = "0xEE9FDC", Offset = "0xEE9FDC", VA = "0xEE9FDC")]
		public static LayerMask LayerNumbersToMask(params int[] layerNumbers)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x600019F")]
		[Address(RVA = "0xEEA08C", Offset = "0xEEA08C", VA = "0xEEA08C")]
		public static LayerMask Inverse(this LayerMask original)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60001A0")]
		[Address(RVA = "0xEEA0B8", Offset = "0xEEA0B8", VA = "0xEEA0B8")]
		public static LayerMask AddToMask(this LayerMask original, params string[] layerNames)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60001A1")]
		[Address(RVA = "0xEEA108", Offset = "0xEEA108", VA = "0xEEA108")]
		public static LayerMask RemoveFromMask(this LayerMask original, params string[] layerNames)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60001A2")]
		[Address(RVA = "0xEEA174", Offset = "0xEEA174", VA = "0xEEA174")]
		public static string[] MaskToNames(this LayerMask original)
		{
			return null;
		}

		[Token(Token = "0x60001A3")]
		[Address(RVA = "0xEEA274", Offset = "0xEEA274", VA = "0xEEA274")]
		public static int[] MaskToNumbers(this LayerMask original)
		{
			return null;
		}

		[Token(Token = "0x60001A4")]
		[Address(RVA = "0xEEA358", Offset = "0xEEA358", VA = "0xEEA358")]
		public static string MaskToString(this LayerMask original)
		{
			return null;
		}

		[Token(Token = "0x60001A5")]
		[Address(RVA = "0xEEA3B8", Offset = "0xEEA3B8", VA = "0xEEA3B8")]
		public static string MaskToString(this LayerMask original, string delimiter)
		{
			return null;
		}
	}
	[Token(Token = "0x2000024")]
	public static class QuaTools
	{
		[Token(Token = "0x60001A6")]
		[Address(RVA = "0xEEA3E8", Offset = "0xEEA3E8", VA = "0xEEA3E8")]
		public static Quaternion Lerp(Quaternion fromRotation, Quaternion toRotation, float weight)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60001A7")]
		[Address(RVA = "0xEEA534", Offset = "0xEEA534", VA = "0xEEA534")]
		public static Quaternion Slerp(Quaternion fromRotation, Quaternion toRotation, float weight)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60001A8")]
		[Address(RVA = "0xEEA680", Offset = "0xEEA680", VA = "0xEEA680")]
		public static Quaternion LinearBlend(Quaternion q, float weight)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60001A9")]
		[Address(RVA = "0xEEA794", Offset = "0xEEA794", VA = "0xEEA794")]
		public static Quaternion SphericalBlend(Quaternion q, float weight)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60001AA")]
		[Address(RVA = "0xEDBD8C", Offset = "0xEDBD8C", VA = "0xEDBD8C")]
		public static Quaternion FromToAroundAxis(Vector3 fromDirection, Vector3 toDirection, Vector3 axis)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60001AB")]
		[Address(RVA = "0xEEA8A8", Offset = "0xEEA8A8", VA = "0xEEA8A8")]
		public static Quaternion RotationToLocalSpace(Quaternion space, Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60001AC")]
		[Address(RVA = "0xEE088C", Offset = "0xEE088C", VA = "0xEE088C")]
		public static Quaternion FromToRotation(Quaternion from, Quaternion to)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60001AD")]
		[Address(RVA = "0xEEA978", Offset = "0xEEA978", VA = "0xEEA978")]
		public static Vector3 GetAxis(Vector3 v)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60001AE")]
		[Address(RVA = "0xEEABFC", Offset = "0xEEABFC", VA = "0xEEABFC")]
		public static Quaternion ClampRotation(Quaternion rotation, float clampWeight, int clampSmoothing)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60001AF")]
		[Address(RVA = "0xEEAE10", Offset = "0xEEAE10", VA = "0xEEAE10")]
		public static float ClampAngle(float angle, float clampWeight, int clampSmoothing)
		{
			return default(float);
		}
	}
	[Token(Token = "0x2000025")]
	public abstract class Singleton<T> : MonoBehaviour where T : Singleton<T>
	{
		[Token(Token = "0x40000C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static T sInstance;

		[Token(Token = "0x17000057")]
		public static T instance
		{
			[Token(Token = "0x60001B0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001B1")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x60001B2")]
		protected Singleton()
		{
		}
	}
	[Token(Token = "0x2000026")]
	public class SolverManager : MonoBehaviour
	{
		[Token(Token = "0x40000C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9D6258", Offset = "0x9D6258")]
		public bool fixTransforms;

		[Token(Token = "0x40000C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Animator animator;

		[Token(Token = "0x40000C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Animation legacy;

		[Token(Token = "0x40000C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private bool updateFrame;

		[Token(Token = "0x40000C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
		private bool componentInitiated;

		[Token(Token = "0x40000C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x32")]
		private bool skipSolverUpdate;

		[Token(Token = "0x17000058")]
		private bool animatePhysics
		{
			[Token(Token = "0x60001BA")]
			[Address(RVA = "0xEEB0C8", Offset = "0xEEB0C8", VA = "0xEEB0C8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000059")]
		private bool isAnimated
		{
			[Token(Token = "0x60001BE")]
			[Address(RVA = "0xEEB41C", Offset = "0xEEB41C", VA = "0xEEB41C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60001B4")]
		[Address(RVA = "0xEEAF90", Offset = "0xEEAF90", VA = "0xEEAF90")]
		public void Disable()
		{
		}

		[Token(Token = "0x60001B5")]
		[Address(RVA = "0xEEB028", Offset = "0xEEB028", VA = "0xEEB028", Slot = "4")]
		protected virtual void InitiateSolver()
		{
		}

		[Token(Token = "0x60001B6")]
		[Address(RVA = "0xEEB02C", Offset = "0xEEB02C", VA = "0xEEB02C", Slot = "5")]
		protected virtual void UpdateSolver()
		{
		}

		[Token(Token = "0x60001B7")]
		[Address(RVA = "0xEEB030", Offset = "0xEEB030", VA = "0xEEB030", Slot = "6")]
		protected virtual void FixTransforms()
		{
		}

		[Token(Token = "0x60001B8")]
		[Address(RVA = "0xEEB034", Offset = "0xEEB034", VA = "0xEEB034")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60001B9")]
		[Address(RVA = "0xEEB0C4", Offset = "0xEEB0C4", VA = "0xEEB0C4")]
		private void Start()
		{
		}

		[Token(Token = "0x60001BB")]
		[Address(RVA = "0xEEB06C", Offset = "0xEEB06C", VA = "0xEEB06C")]
		private void Initiate()
		{
		}

		[Token(Token = "0x60001BC")]
		[Address(RVA = "0xEEB3CC", Offset = "0xEEB3CC", VA = "0xEEB3CC")]
		private void Update()
		{
		}

		[Token(Token = "0x60001BD")]
		[Address(RVA = "0xEEB1CC", Offset = "0xEEB1CC", VA = "0xEEB1CC")]
		private void FindAnimatorRecursive(Transform t, bool findInChildren)
		{
		}

		[Token(Token = "0x60001BF")]
		[Address(RVA = "0xEEB4D8", Offset = "0xEEB4D8", VA = "0xEEB4D8")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60001C0")]
		[Address(RVA = "0xEEB534", Offset = "0xEEB534", VA = "0xEEB534")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60001C1")]
		[Address(RVA = "0xEEB594", Offset = "0xEEB594", VA = "0xEEB594")]
		public void UpdateSolverExternal()
		{
		}

		[Token(Token = "0x60001C2")]
		[Address(RVA = "0xEDE830", Offset = "0xEDE830", VA = "0xEDE830")]
		public SolverManager()
		{
		}
	}
	[Token(Token = "0x2000027")]
	public class TriggerEventBroadcaster : MonoBehaviour
	{
		[Token(Token = "0x40000C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject target;

		[Token(Token = "0x60001C3")]
		[Address(RVA = "0xEEB5DC", Offset = "0xEEB5DC", VA = "0xEEB5DC")]
		private void OnTriggerEnter(Collider collider)
		{
		}

		[Token(Token = "0x60001C4")]
		[Address(RVA = "0xEEB69C", Offset = "0xEEB69C", VA = "0xEEB69C")]
		private void OnTriggerStay(Collider collider)
		{
		}

		[Token(Token = "0x60001C5")]
		[Address(RVA = "0xEEB75C", Offset = "0xEEB75C", VA = "0xEEB75C")]
		private void OnTriggerExit(Collider collider)
		{
		}

		[Token(Token = "0x60001C6")]
		[Address(RVA = "0xEEB81C", Offset = "0xEEB81C", VA = "0xEEB81C")]
		public TriggerEventBroadcaster()
		{
		}
	}
	[Token(Token = "0x2000028")]
	public static class V3Tools
	{
		[Token(Token = "0x60001C7")]
		[Address(RVA = "0xEEB824", Offset = "0xEEB824", VA = "0xEEB824")]
		public static Vector3 Lerp(Vector3 fromVector, Vector3 toVector, float weight)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60001C8")]
		[Address(RVA = "0xEEB91C", Offset = "0xEEB91C", VA = "0xEEB91C")]
		public static Vector3 Slerp(Vector3 fromVector, Vector3 toVector, float weight)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60001C9")]
		[Address(RVA = "0xEEBA14", Offset = "0xEEBA14", VA = "0xEEBA14")]
		public static Vector3 ExtractVertical(Vector3 v, Vector3 verticalAxis, float weight)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60001CA")]
		[Address(RVA = "0xEEBB0C", Offset = "0xEEBB0C", VA = "0xEEBB0C")]
		public static Vector3 ExtractHorizontal(Vector3 v, Vector3 normal, float weight)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60001CB")]
		[Address(RVA = "0xEEBC0C", Offset = "0xEEBC0C", VA = "0xEEBC0C")]
		public static Vector3 ClampDirection(Vector3 direction, Vector3 normalDirection, float clampWeight, int clampSmoothing, out bool changed)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60001CC")]
		[Address(RVA = "0xEEBE48", Offset = "0xEEBE48", VA = "0xEEBE48")]
		public static Vector3 ClampDirection(Vector3 direction, Vector3 normalDirection, float clampWeight, int clampSmoothing, out float clampValue)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60001CD")]
		[Address(RVA = "0xEEC098", Offset = "0xEEC098", VA = "0xEEC098")]
		public static Vector3 LineToPlane(Vector3 origin, Vector3 direction, Vector3 planeNormal, Vector3 planePoint)
		{
			return default(Vector3);
		}
	}
	[Token(Token = "0x2000029")]
	public static class Warning
	{
		[Token(Token = "0x200013B")]
		public delegate void Logger(string message);

		[Token(Token = "0x40000C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static bool logged;

		[Token(Token = "0x60001CE")]
		[Address(RVA = "0xEEC2A8", Offset = "0xEEC2A8", VA = "0xEEC2A8")]
		public static void Log(string message, Logger logger, bool logInEditMode = false)
		{
		}

		[Token(Token = "0x60001CF")]
		[Address(RVA = "0xED4250", Offset = "0xED4250", VA = "0xED4250")]
		public static void Log(string message, Transform context, bool logInEditMode = false)
		{
		}
	}
}
namespace RootMotion.FinalIK
{
	[Token(Token = "0x200002A")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x9D4ECC", Offset = "0x9D4ECC")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x9D4ECC", Offset = "0x9D4ECC")]
	public class BipedIK : SolverManager
	{
		[Token(Token = "0x40000C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public BipedReferences references;

		[Token(Token = "0x40000CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public BipedIKSolvers solvers;

		[Token(Token = "0x60001D0")]
		[Address(RVA = "0xF79B70", Offset = "0xF79B70", VA = "0xF79B70")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9DD73C", Offset = "0x9DD73C")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x60001D1")]
		[Address(RVA = "0xF79BBC", Offset = "0xF79BBC", VA = "0xF79BBC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9DD774", Offset = "0x9DD774")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x60001D2")]
		[Address(RVA = "0xF79C08", Offset = "0xF79C08", VA = "0xF79C08")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9DD7AC", Offset = "0x9DD7AC")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60001D3")]
		[Address(RVA = "0xF79C54", Offset = "0xF79C54", VA = "0xF79C54")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9DD7E4", Offset = "0x9DD7E4")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60001D4")]
		[Address(RVA = "0xF79CA0", Offset = "0xF79CA0", VA = "0xF79CA0")]
		public float GetIKPositionWeight(AvatarIKGoal goal)
		{
			return default(float);
		}

		[Token(Token = "0x60001D5")]
		[Address(RVA = "0xF79D70", Offset = "0xF79D70", VA = "0xF79D70")]
		public float GetIKRotationWeight(AvatarIKGoal goal)
		{
			return default(float);
		}

		[Token(Token = "0x60001D6")]
		[Address(RVA = "0xF79DA0", Offset = "0xF79DA0", VA = "0xF79DA0")]
		public void SetIKPositionWeight(AvatarIKGoal goal, float weight)
		{
		}

		[Token(Token = "0x60001D7")]
		[Address(RVA = "0xF79DE0", Offset = "0xF79DE0", VA = "0xF79DE0")]
		public void SetIKRotationWeight(AvatarIKGoal goal, float weight)
		{
		}

		[Token(Token = "0x60001D8")]
		[Address(RVA = "0xF79E20", Offset = "0xF79E20", VA = "0xF79E20")]
		public void SetIKPosition(AvatarIKGoal goal, Vector3 IKPosition)
		{
		}

		[Token(Token = "0x60001D9")]
		[Address(RVA = "0xF79E78", Offset = "0xF79E78", VA = "0xF79E78")]
		public void SetIKRotation(AvatarIKGoal goal, Quaternion IKRotation)
		{
		}

		[Token(Token = "0x60001DA")]
		[Address(RVA = "0xF79ED8", Offset = "0xF79ED8", VA = "0xF79ED8")]
		public Vector3 GetIKPosition(AvatarIKGoal goal)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60001DB")]
		[Address(RVA = "0xF79F0C", Offset = "0xF79F0C", VA = "0xF79F0C")]
		public Quaternion GetIKRotation(AvatarIKGoal goal)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60001DC")]
		[Address(RVA = "0xF79F3C", Offset = "0xF79F3C", VA = "0xF79F3C")]
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight, float clampWeight, float clampWeightHead, float clampWeightEyes)
		{
		}

		[Token(Token = "0x60001DD")]
		[Address(RVA = "0xF79FD4", Offset = "0xF79FD4", VA = "0xF79FD4")]
		public void SetLookAtPosition(Vector3 lookAtPosition)
		{
		}

		[Token(Token = "0x60001DE")]
		[Address(RVA = "0xF7A03C", Offset = "0xF7A03C", VA = "0xF7A03C")]
		public void SetSpinePosition(Vector3 spinePosition)
		{
		}

		[Token(Token = "0x60001DF")]
		[Address(RVA = "0xF7A0A4", Offset = "0xF7A0A4", VA = "0xF7A0A4")]
		public void SetSpineWeight(float weight)
		{
		}

		[Token(Token = "0x60001E0")]
		[Address(RVA = "0xF79CD0", Offset = "0xF79CD0", VA = "0xF79CD0")]
		public IKSolverLimb GetGoalIK(AvatarIKGoal goal)
		{
			return null;
		}

		[Token(Token = "0x60001E1")]
		[Address(RVA = "0xF7A0F4", Offset = "0xF7A0F4", VA = "0xF7A0F4")]
		public void InitiateBipedIK()
		{
		}

		[Token(Token = "0x60001E2")]
		[Address(RVA = "0xF7A100", Offset = "0xF7A100", VA = "0xF7A100")]
		public void UpdateBipedIK()
		{
		}

		[Token(Token = "0x60001E3")]
		[Address(RVA = "0xF7A10C", Offset = "0xF7A10C", VA = "0xF7A10C")]
		public void SetToDefaults()
		{
		}

		[Token(Token = "0x60001E4")]
		[Address(RVA = "0xF7A558", Offset = "0xF7A558", VA = "0xF7A558", Slot = "6")]
		protected override void FixTransforms()
		{
		}

		[Token(Token = "0x60001E5")]
		[Address(RVA = "0xF7A650", Offset = "0xF7A650", VA = "0xF7A650", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x60001E6")]
		[Address(RVA = "0xF7AB94", Offset = "0xF7AB94", VA = "0xF7AB94", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x60001E7")]
		[Address(RVA = "0xF7B1B4", Offset = "0xF7B1B4", VA = "0xF7B1B4")]
		public void LogWarning(string message)
		{
		}

		[Token(Token = "0x60001E8")]
		[Address(RVA = "0xF7B1E8", Offset = "0xF7B1E8", VA = "0xF7B1E8")]
		public BipedIK()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200002B")]
	public class BipedIKSolvers
	{
		[Token(Token = "0x40000CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public IKSolverLimb leftFoot;

		[Token(Token = "0x40000CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public IKSolverLimb rightFoot;

		[Token(Token = "0x40000CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public IKSolverLimb leftHand;

		[Token(Token = "0x40000CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public IKSolverLimb rightHand;

		[Token(Token = "0x40000CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public IKSolverFABRIK spine;

		[Token(Token = "0x40000D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverLookAt lookAt;

		[Token(Token = "0x40000D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public IKSolverAim aim;

		[Token(Token = "0x40000D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Constraints pelvis;

		[Token(Token = "0x40000D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private IKSolverLimb[] _limbs;

		[Token(Token = "0x40000D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private IKSolver[] _ikSolvers;

		[Token(Token = "0x1700005A")]
		public IKSolverLimb[] limbs
		{
			[Token(Token = "0x60001E9")]
			[Address(RVA = "0xF7A3A0", Offset = "0xF7A3A0", VA = "0xF7A3A0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700005B")]
		public IKSolver[] ikSolvers
		{
			[Token(Token = "0x60001EA")]
			[Address(RVA = "0xF7B3B4", Offset = "0xF7B3B4", VA = "0xF7B3B4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001EB")]
		[Address(RVA = "0xF7A8D8", Offset = "0xF7A8D8", VA = "0xF7A8D8")]
		public void AssignReferences(BipedReferences references)
		{
		}

		[Token(Token = "0x60001EC")]
		[Address(RVA = "0xF7B26C", Offset = "0xF7B26C", VA = "0xF7B26C")]
		public BipedIKSolvers()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200002C")]
	public abstract class Constraint
	{
		[Token(Token = "0x40000D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform transform;

		[Token(Token = "0x40000D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float weight;

		[Token(Token = "0x1700005C")]
		public bool isValid
		{
			[Token(Token = "0x60001ED")]
			[Address(RVA = "0xF7BACC", Offset = "0xF7BACC", VA = "0xF7BACC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60001EE")]
		public abstract void UpdateConstraint();

		[Token(Token = "0x60001EF")]
		[Address(RVA = "0xF7BB3C", Offset = "0xF7BB3C", VA = "0xF7BB3C")]
		protected Constraint()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200002D")]
	public class ConstraintPosition : Constraint
	{
		[Token(Token = "0x40000D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Vector3 position;

		[Token(Token = "0x60001F0")]
		[Address(RVA = "0xF7BB44", Offset = "0xF7BB44", VA = "0xF7BB44", Slot = "4")]
		public override void UpdateConstraint()
		{
		}

		[Token(Token = "0x60001F1")]
		[Address(RVA = "0xF7BC78", Offset = "0xF7BC78", VA = "0xF7BC78")]
		public ConstraintPosition()
		{
		}

		[Token(Token = "0x60001F2")]
		[Address(RVA = "0xF7BC80", Offset = "0xF7BC80", VA = "0xF7BC80")]
		public ConstraintPosition(Transform transform)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200002E")]
	public class ConstraintPositionOffset : Constraint
	{
		[Token(Token = "0x40000D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Vector3 offset;

		[Token(Token = "0x40000D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Vector3 defaultLocalPosition;

		[Token(Token = "0x40000DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private Vector3 lastLocalPosition;

		[Token(Token = "0x40000DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private bool initiated;

		[Token(Token = "0x1700005D")]
		private bool positionChanged
		{
			[Token(Token = "0x60001F6")]
			[Address(RVA = "0xF7BED8", Offset = "0xF7BED8", VA = "0xF7BED8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60001F3")]
		[Address(RVA = "0xF7BCAC", Offset = "0xF7BCAC", VA = "0xF7BCAC", Slot = "4")]
		public override void UpdateConstraint()
		{
		}

		[Token(Token = "0x60001F4")]
		[Address(RVA = "0xF7BF9C", Offset = "0xF7BF9C", VA = "0xF7BF9C")]
		public ConstraintPositionOffset()
		{
		}

		[Token(Token = "0x60001F5")]
		[Address(RVA = "0xF7BFA4", Offset = "0xF7BFA4", VA = "0xF7BFA4")]
		public ConstraintPositionOffset(Transform transform)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200002F")]
	public class ConstraintRotation : Constraint
	{
		[Token(Token = "0x40000DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Quaternion rotation;

		[Token(Token = "0x60001F7")]
		[Address(RVA = "0xF7BFD0", Offset = "0xF7BFD0", VA = "0xF7BFD0", Slot = "4")]
		public override void UpdateConstraint()
		{
		}

		[Token(Token = "0x60001F8")]
		[Address(RVA = "0xF7C128", Offset = "0xF7C128", VA = "0xF7C128")]
		public ConstraintRotation()
		{
		}

		[Token(Token = "0x60001F9")]
		[Address(RVA = "0xF7C130", Offset = "0xF7C130", VA = "0xF7C130")]
		public ConstraintRotation(Transform transform)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000030")]
	public class ConstraintRotationOffset : Constraint
	{
		[Token(Token = "0x40000DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Quaternion offset;

		[Token(Token = "0x40000DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private Quaternion defaultRotation;

		[Token(Token = "0x40000DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private Quaternion defaultLocalRotation;

		[Token(Token = "0x40000E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Quaternion lastLocalRotation;

		[Token(Token = "0x40000E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private Quaternion defaultTargetLocalRotation;

		[Token(Token = "0x40000E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private bool initiated;

		[Token(Token = "0x1700005E")]
		private bool rotationChanged
		{
			[Token(Token = "0x60001FD")]
			[Address(RVA = "0xF7C39C", Offset = "0xF7C39C", VA = "0xF7C39C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60001FA")]
		[Address(RVA = "0xF7C15C", Offset = "0xF7C15C", VA = "0xF7C15C", Slot = "4")]
		public override void UpdateConstraint()
		{
		}

		[Token(Token = "0x60001FB")]
		[Address(RVA = "0xF7C474", Offset = "0xF7C474", VA = "0xF7C474")]
		public ConstraintRotationOffset()
		{
		}

		[Token(Token = "0x60001FC")]
		[Address(RVA = "0xF7C47C", Offset = "0xF7C47C", VA = "0xF7C47C")]
		public ConstraintRotationOffset(Transform transform)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000031")]
	public class Constraints
	{
		[Token(Token = "0x40000E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform transform;

		[Token(Token = "0x40000E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Vector3 positionOffset;

		[Token(Token = "0x40000E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public Vector3 position;

		[Token(Token = "0x40000E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9D6290", Offset = "0x9D6290")]
		public float positionWeight;

		[Token(Token = "0x40000E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public Vector3 rotationOffset;

		[Token(Token = "0x40000E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Vector3 rotation;

		[Token(Token = "0x40000E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9D62A8", Offset = "0x9D62A8")]
		public float rotationWeight;

		[Token(Token = "0x60001FE")]
		[Address(RVA = "0xF7C4A8", Offset = "0xF7C4A8", VA = "0xF7C4A8")]
		public bool IsValid()
		{
			return default(bool);
		}

		[Token(Token = "0x60001FF")]
		[Address(RVA = "0xF7AB1C", Offset = "0xF7AB1C", VA = "0xF7AB1C")]
		public void Initiate(Transform transform)
		{
		}

		[Token(Token = "0x6000200")]
		[Address(RVA = "0xF7AE30", Offset = "0xF7AE30", VA = "0xF7AE30")]
		public void Update()
		{
		}

		[Token(Token = "0x6000201")]
		[Address(RVA = "0xF7B650", Offset = "0xF7B650", VA = "0xF7B650")]
		public Constraints()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000032")]
	public class Finger
	{
		[Token(Token = "0x40000EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9D62C0", Offset = "0x9D62C0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9D62C0", Offset = "0x9D62C0")]
		public float weight;

		[Token(Token = "0x40000EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9D6314", Offset = "0x9D6314")]
		public Transform bone1;

		[Token(Token = "0x40000EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9D634C", Offset = "0x9D634C")]
		public Transform bone2;

		[Token(Token = "0x40000ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9D6384", Offset = "0x9D6384")]
		public Transform bone3;

		[Token(Token = "0x40000EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9D63BC", Offset = "0x9D63BC")]
		public Transform tip;

		[Token(Token = "0x40000EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9D63F4", Offset = "0x9D63F4")]
		public Transform target;

		[Token(Token = "0x40000F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9D642C", Offset = "0x9D642C")]
		private bool <initiated>k__BackingField;

		[Token(Token = "0x40000F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private IKSolverLimb solver;

		[Token(Token = "0x40000F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Quaternion bone3RelativeToTarget;

		[Token(Token = "0x40000F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Vector3 bone3DefaultLocalPosition;

		[Token(Token = "0x40000F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private Quaternion bone3DefaultLocalRotation;

		[Token(Token = "0x1700005F")]
		public bool initiated
		{
			[Token(Token = "0x6000202")]
			[Address(RVA = "0xF866D8", Offset = "0xF866D8", VA = "0xF866D8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DD81C", Offset = "0x9DD81C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000203")]
			[Address(RVA = "0xF866E0", Offset = "0xF866E0", VA = "0xF866E0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DD82C", Offset = "0x9DD82C")]
			private set
			{
			}
		}

		[Token(Token = "0x17000060")]
		public Vector3 IKPosition
		{
			[Token(Token = "0x6000204")]
			[Address(RVA = "0xF866EC", Offset = "0xF866EC", VA = "0xF866EC")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000205")]
			[Address(RVA = "0xF8671C", Offset = "0xF8671C", VA = "0xF8671C")]
			set
			{
			}
		}

		[Token(Token = "0x17000061")]
		public Quaternion IKRotation
		{
			[Token(Token = "0x6000206")]
			[Address(RVA = "0xF86768", Offset = "0xF86768", VA = "0xF86768")]
			get
			{
				return default(Quaternion);
			}
			[Token(Token = "0x6000207")]
			[Address(RVA = "0xF86798", Offset = "0xF86798", VA = "0xF86798")]
			set
			{
			}
		}

		[Token(Token = "0x6000208")]
		[Address(RVA = "0xF867E8", Offset = "0xF867E8", VA = "0xF867E8")]
		public bool IsValid(ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000209")]
		[Address(RVA = "0xF868E8", Offset = "0xF868E8", VA = "0xF868E8")]
		public void Initiate(Transform hand, int index)
		{
		}

		[Token(Token = "0x600020A")]
		[Address(RVA = "0xF86C08", Offset = "0xF86C08", VA = "0xF86C08")]
		public void FixTransforms()
		{
		}

		[Token(Token = "0x600020B")]
		[Address(RVA = "0xF86D2C", Offset = "0xF86D2C", VA = "0xF86D2C")]
		public void Update(float masterWeight)
		{
		}

		[Token(Token = "0x600020C")]
		[Address(RVA = "0xF8706C", Offset = "0xF8706C", VA = "0xF8706C")]
		public Finger()
		{
		}
	}
	[Token(Token = "0x2000033")]
	public class FingerRig : SolverManager
	{
		[Token(Token = "0x40000F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9D643C", Offset = "0x9D643C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9D643C", Offset = "0x9D643C")]
		public float weight;

		[Token(Token = "0x40000F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Finger[] fingers;

		[Token(Token = "0x40000F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9D6490", Offset = "0x9D6490")]
		private bool <initiated>k__BackingField;

		[Token(Token = "0x17000062")]
		public bool initiated
		{
			[Token(Token = "0x600020D")]
			[Address(RVA = "0xF8707C", Offset = "0xF8707C", VA = "0xF8707C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DD83C", Offset = "0x9DD83C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600020E")]
			[Address(RVA = "0xF87084", Offset = "0xF87084", VA = "0xF87084")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DD84C", Offset = "0x9DD84C")]
			private set
			{
			}
		}

		[Token(Token = "0x600020F")]
		[Address(RVA = "0xF87090", Offset = "0xF87090", VA = "0xF87090")]
		public bool IsValid(ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000210")]
		[Address(RVA = "0xF87124", Offset = "0xF87124", VA = "0xF87124")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9DD85C", Offset = "0x9DD85C")]
		public void AutoDetect()
		{
		}

		[Token(Token = "0x6000211")]
		[Address(RVA = "0xF8756C", Offset = "0xF8756C", VA = "0xF8756C")]
		public void AddFinger(Transform bone1, Transform bone2, Transform bone3, Transform tip, [Optional] Transform target)
		{
		}

		[Token(Token = "0x6000212")]
		[Address(RVA = "0xF87780", Offset = "0xF87780", VA = "0xF87780")]
		public void RemoveFinger(int index)
		{
		}

		[Token(Token = "0x6000213")]
		[Address(RVA = "0xF87420", Offset = "0xF87420", VA = "0xF87420")]
		private void AddChildrenRecursive(Transform parent, ref Transform[] array)
		{
		}

		[Token(Token = "0x6000214")]
		[Address(RVA = "0xF87978", Offset = "0xF87978", VA = "0xF87978", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x6000215")]
		[Address(RVA = "0xF87A80", Offset = "0xF87A80", VA = "0xF87A80")]
		public void UpdateFingerSolvers()
		{
		}

		[Token(Token = "0x6000216")]
		[Address(RVA = "0xF87B20", Offset = "0xF87B20", VA = "0xF87B20")]
		public void FixFingerTransforms()
		{
		}

		[Token(Token = "0x6000217")]
		[Address(RVA = "0xF87BA0", Offset = "0xF87BA0", VA = "0xF87BA0", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x6000218")]
		[Address(RVA = "0xF87BA4", Offset = "0xF87BA4", VA = "0xF87BA4", Slot = "6")]
		protected override void FixTransforms()
		{
		}

		[Token(Token = "0x6000219")]
		[Address(RVA = "0xF87BA8", Offset = "0xF87BA8", VA = "0xF87BA8")]
		public FingerRig()
		{
		}
	}
	[Token(Token = "0x2000034")]
	public abstract class Grounder : MonoBehaviour
	{
		[Token(Token = "0x200013C")]
		public delegate void GrounderDelegate();

		[Token(Token = "0x40000F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9D64A0", Offset = "0x9D64A0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9D64A0", Offset = "0x9D64A0")]
		public float weight;

		[Token(Token = "0x40000F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9D64F4", Offset = "0x9D64F4")]
		public Grounding solver;

		[Token(Token = "0x40000FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public GrounderDelegate OnPreGrounder;

		[Token(Token = "0x40000FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public GrounderDelegate OnPostGrounder;

		[Token(Token = "0x40000FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		protected bool initiated;

		[Token(Token = "0x600021A")]
		public abstract void ResetPosition();

		[Token(Token = "0x600021B")]
		[Address(RVA = "0x16FE6A0", Offset = "0x16FE6A0", VA = "0x16FE6A0")]
		protected Vector3 GetSpineOffsetTarget()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600021C")]
		[Address(RVA = "0x16FE9F0", Offset = "0x16FE9F0", VA = "0x16FE9F0")]
		protected void LogWarning(string message)
		{
		}

		[Token(Token = "0x600021D")]
		[Address(RVA = "0x16FE828", Offset = "0x16FE828", VA = "0x16FE828")]
		private Vector3 GetLegSpineBendVector(Grounding.Leg leg)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600021E")]
		[Address(RVA = "0x16FEA24", Offset = "0x16FEA24", VA = "0x16FEA24")]
		private Vector3 GetLegSpineTangent(Grounding.Leg leg)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600021F")]
		protected abstract void OpenUserManual();

		[Token(Token = "0x6000220")]
		protected abstract void OpenScriptReference();

		[Token(Token = "0x6000221")]
		[Address(RVA = "0x16FECA4", Offset = "0x16FECA4", VA = "0x16FECA4")]
		protected Grounder()
		{
		}
	}
	[Token(Token = "0x2000035")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x9D4F2C", Offset = "0x9D4F2C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x9D4F2C", Offset = "0x9D4F2C")]
	public class GrounderBipedIK : Grounder
	{
		[Token(Token = "0x40000FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9D652C", Offset = "0x9D652C")]
		public BipedIK ik;

		[Token(Token = "0x40000FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9D6564", Offset = "0x9D6564")]
		public float spineBend;

		[Token(Token = "0x40000FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9D659C", Offset = "0x9D659C")]
		public float spineSpeed;

		[Token(Token = "0x4000100")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Transform[] feet;

		[Token(Token = "0x4000101")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Quaternion[] footRotations;

		[Token(Token = "0x4000102")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Vector3 animatedPelvisLocalPosition;

		[Token(Token = "0x4000103")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private Vector3 solvedPelvisLocalPosition;

		[Token(Token = "0x4000104")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Vector3 spineOffset;

		[Token(Token = "0x4000105")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private float lastWeight;

		[Token(Token = "0x6000222")]
		[Address(RVA = "0x16FF00C", Offset = "0x16FF00C", VA = "0x16FF00C", Slot = "5")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9DD894", Offset = "0x9DD894")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000223")]
		[Address(RVA = "0x16FF058", Offset = "0x16FF058", VA = "0x16FF058", Slot = "6")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9DD8CC", Offset = "0x9DD8CC")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000224")]
		[Address(RVA = "0x16FF0A4", Offset = "0x16FF0A4", VA = "0x16FF0A4", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x6000225")]
		[Address(RVA = "0x16FF1D4", Offset = "0x16FF1D4", VA = "0x16FF1D4")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x6000226")]
		[Address(RVA = "0x16FF2C8", Offset = "0x16FF2C8", VA = "0x16FF2C8")]
		private void Update()
		{
		}

		[Token(Token = "0x6000227")]
		[Address(RVA = "0x16FF37C", Offset = "0x16FF37C", VA = "0x16FF37C")]
		private void Initiate()
		{
		}

		[Token(Token = "0x6000228")]
		[Address(RVA = "0x16FFAAC", Offset = "0x16FFAAC", VA = "0x16FFAAC")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000229")]
		[Address(RVA = "0x16FFB38", Offset = "0x16FFB38", VA = "0x16FFB38")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x600022A")]
		[Address(RVA = "0x1700530", Offset = "0x1700530", VA = "0x1700530")]
		private void SetLegIK(IKSolverLimb limb, int index)
		{
		}

		[Token(Token = "0x600022B")]
		[Address(RVA = "0x170071C", Offset = "0x170071C", VA = "0x170071C")]
		private void OnPostSolverUpdate()
		{
		}

		[Token(Token = "0x600022C")]
		[Address(RVA = "0x1700998", Offset = "0x1700998", VA = "0x1700998")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600022D")]
		[Address(RVA = "0x1700B60", Offset = "0x1700B60", VA = "0x1700B60")]
		public GrounderBipedIK()
		{
		}
	}
	[Token(Token = "0x2000036")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x9D4F8C", Offset = "0x9D4F8C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x9D4F8C", Offset = "0x9D4F8C")]
	public class GrounderFBBIK : Grounder
	{
		[Serializable]
		[Token(Token = "0x200013D")]
		public class SpineEffector
		{
			[Token(Token = "0x4000810")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9DAADC", Offset = "0x9DAADC")]
			public FullBodyBipedEffector effectorType;

			[Token(Token = "0x4000811")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9DAB14", Offset = "0x9DAB14")]
			public float horizontalWeight;

			[Token(Token = "0x4000812")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9DAB4C", Offset = "0x9DAB4C")]
			public float verticalWeight;

			[Token(Token = "0x600098E")]
			[Address(RVA = "0x1701CBC", Offset = "0x1701CBC", VA = "0x1701CBC")]
			public SpineEffector()
			{
			}
		}

		[Token(Token = "0x4000106")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9D65D4", Offset = "0x9D65D4")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x4000107")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9D660C", Offset = "0x9D660C")]
		public float spineBend;

		[Token(Token = "0x4000108")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9D6644", Offset = "0x9D6644")]
		public float spineSpeed;

		[Token(Token = "0x4000109")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public SpineEffector[] spine;

		[Token(Token = "0x400010A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Transform[] feet;

		[Token(Token = "0x400010B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Vector3 spineOffset;

		[Token(Token = "0x400010C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private bool firstSolve;

		[Token(Token = "0x600022E")]
		[Address(RVA = "0x1700BE0", Offset = "0x1700BE0", VA = "0x1700BE0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9DD904", Offset = "0x9DD904")]
		private void OpenTutorial()
		{
		}

		[Token(Token = "0x600022F")]
		[Address(RVA = "0x1700C2C", Offset = "0x1700C2C", VA = "0x1700C2C", Slot = "5")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9DD93C", Offset = "0x9DD93C")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000230")]
		[Address(RVA = "0x1700C78", Offset = "0x1700C78", VA = "0x1700C78", Slot = "6")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9DD974", Offset = "0x9DD974")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000231")]
		[Address(RVA = "0x1700CC4", Offset = "0x1700CC4", VA = "0x1700CC4", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x6000232")]
		[Address(RVA = "0x1700D4C", Offset = "0x1700D4C", VA = "0x1700D4C")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x6000233")]
		[Address(RVA = "0x1700DF0", Offset = "0x1700DF0", VA = "0x1700DF0")]
		private void Update()
		{
		}

		[Token(Token = "0x6000234")]
		[Address(RVA = "0x17011AC", Offset = "0x17011AC", VA = "0x17011AC")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000235")]
		[Address(RVA = "0x17011B8", Offset = "0x17011B8", VA = "0x17011B8")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000236")]
		[Address(RVA = "0x1700EAC", Offset = "0x1700EAC", VA = "0x1700EAC")]
		private void Initiate()
		{
		}

		[Token(Token = "0x6000237")]
		[Address(RVA = "0x17011C4", Offset = "0x17011C4", VA = "0x17011C4")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x6000238")]
		[Address(RVA = "0x17017DC", Offset = "0x17017DC", VA = "0x17017DC")]
		private void SetLegIK(IKEffector effector, Grounding.Leg leg)
		{
		}

		[Token(Token = "0x6000239")]
		[Address(RVA = "0x17019E8", Offset = "0x17019E8", VA = "0x17019E8")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x600023A")]
		[Address(RVA = "0x1701B20", Offset = "0x1701B20", VA = "0x1701B20")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600023B")]
		[Address(RVA = "0x1701C3C", Offset = "0x1701C3C", VA = "0x1701C3C")]
		public GrounderFBBIK()
		{
		}
	}
	[Token(Token = "0x2000037")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x9D4FEC", Offset = "0x9D4FEC")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x9D4FEC", Offset = "0x9D4FEC")]
	public class GrounderIK : Grounder
	{
		[Token(Token = "0x400010D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public IK[] legs;

		[Token(Token = "0x400010E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9D667C", Offset = "0x9D667C")]
		public Transform pelvis;

		[Token(Token = "0x400010F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9D66B4", Offset = "0x9D66B4")]
		public Transform characterRoot;

		[Token(Token = "0x4000110")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9D66EC", Offset = "0x9D66EC")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9D66EC", Offset = "0x9D66EC")]
		public float rootRotationWeight;

		[Token(Token = "0x4000111")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9D6740", Offset = "0x9D6740")]
		public float rootRotationSpeed;

		[Token(Token = "0x4000112")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9D6778", Offset = "0x9D6778")]
		public float maxRootRotationAngle;

		[Token(Token = "0x4000113")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Transform[] feet;

		[Token(Token = "0x4000114")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Quaternion[] footRotations;

		[Token(Token = "0x4000115")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Vector3 animatedPelvisLocalPosition;

		[Token(Token = "0x4000116")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private Vector3 solvedPelvisLocalPosition;

		[Token(Token = "0x4000117")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private int solvedFeet;

		[Token(Token = "0x4000118")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private bool solved;

		[Token(Token = "0x4000119")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private float lastWeight;

		[Token(Token = "0x600023C")]
		[Address(RVA = "0x1701CCC", Offset = "0x1701CCC", VA = "0x1701CCC", Slot = "5")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9DD9AC", Offset = "0x9DD9AC")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x600023D")]
		[Address(RVA = "0x1701D18", Offset = "0x1701D18", VA = "0x1701D18", Slot = "6")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9DD9E4", Offset = "0x9DD9E4")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x600023E")]
		[Address(RVA = "0x1701D64", Offset = "0x1701D64", VA = "0x1701D64", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x600023F")]
		[Address(RVA = "0x1701D90", Offset = "0x1701D90", VA = "0x1701D90")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x6000240")]
		[Address(RVA = "0x1701F90", Offset = "0x1701F90", VA = "0x1701F90")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000241")]
		[Address(RVA = "0x17020DC", Offset = "0x17020DC", VA = "0x17020DC")]
		private void Update()
		{
		}

		[Token(Token = "0x6000242")]
		[Address(RVA = "0x17027EC", Offset = "0x17027EC", VA = "0x17027EC")]
		private void Initiate()
		{
		}

		[Token(Token = "0x6000243")]
		[Address(RVA = "0x1702C9C", Offset = "0x1702C9C", VA = "0x1702C9C")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x6000244")]
		[Address(RVA = "0x1702F7C", Offset = "0x1702F7C", VA = "0x1702F7C")]
		private void SetLegIK(int index)
		{
		}

		[Token(Token = "0x6000245")]
		[Address(RVA = "0x170317C", Offset = "0x170317C", VA = "0x170317C")]
		private void OnPostSolverUpdate()
		{
		}

		[Token(Token = "0x6000246")]
		[Address(RVA = "0x17033F4", Offset = "0x17033F4", VA = "0x17033F4")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000247")]
		[Address(RVA = "0x1703610", Offset = "0x1703610", VA = "0x1703610")]
		public GrounderIK()
		{
		}
	}
	[Token(Token = "0x2000038")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x9D504C", Offset = "0x9D504C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x9D504C", Offset = "0x9D504C")]
	public class GrounderQuadruped : Grounder
	{
		[Token(Token = "0x200013E")]
		public struct Foot
		{
			[Token(Token = "0x4000813")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public IKSolver solver;

			[Token(Token = "0x4000814")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public Transform transform;

			[Token(Token = "0x4000815")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Quaternion rotation;

			[Token(Token = "0x4000816")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Grounding.Leg leg;

			[Token(Token = "0x600098F")]
			[Address(RVA = "0xAA0F58", Offset = "0xAA0F58", VA = "0xAA0F58")]
			public Foot(IKSolver solver, Transform transform)
			{
			}
		}

		[Token(Token = "0x400011A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9D67B0", Offset = "0x9D67B0")]
		public Grounding forelegSolver;

		[Token(Token = "0x400011B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9D67E8", Offset = "0x9D67E8")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9D67E8", Offset = "0x9D67E8")]
		public float rootRotationWeight;

		[Token(Token = "0x400011C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9D683C", Offset = "0x9D683C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9D683C", Offset = "0x9D683C")]
		public float minRootRotation;

		[Token(Token = "0x400011D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9D6894", Offset = "0x9D6894")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9D6894", Offset = "0x9D6894")]
		public float maxRootRotation;

		[Token(Token = "0x400011E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9D68EC", Offset = "0x9D68EC")]
		public float rootRotationSpeed;

		[Token(Token = "0x400011F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9D6924", Offset = "0x9D6924")]
		public float maxLegOffset;

		[Token(Token = "0x4000120")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9D695C", Offset = "0x9D695C")]
		public float maxForeLegOffset;

		[Token(Token = "0x4000121")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9D6994", Offset = "0x9D6994")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9D6994", Offset = "0x9D6994")]
		public float maintainHeadRotationWeight;

		[Token(Token = "0x4000122")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9D69E8", Offset = "0x9D69E8")]
		public Transform characterRoot;

		[Token(Token = "0x4000123")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9D6A20", Offset = "0x9D6A20")]
		public Transform pelvis;

		[Token(Token = "0x4000124")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9D6A58", Offset = "0x9D6A58")]
		public Transform lastSpineBone;

		[Token(Token = "0x4000125")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9D6A90", Offset = "0x9D6A90")]
		public Transform head;

		[Token(Token = "0x4000126")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public IK[] legs;

		[Token(Token = "0x4000127")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public IK[] forelegs;

		[Token(Token = "0x4000128")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		[HideInInspector]
		public Vector3 gravity;

		[Token(Token = "0x4000129")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Foot[] feet;

		[Token(Token = "0x400012A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Vector3 animatedPelvisLocalPosition;

		[Token(Token = "0x400012B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		private Quaternion animatedPelvisLocalRotation;

		[Token(Token = "0x400012C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		private Quaternion animatedHeadLocalRotation;

		[Token(Token = "0x400012D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		private Vector3 solvedPelvisLocalPosition;

		[Token(Token = "0x400012E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private Quaternion solvedPelvisLocalRotation;

		[Token(Token = "0x400012F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private Quaternion solvedHeadLocalRotation;

		[Token(Token = "0x4000130")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private int solvedFeet;

		[Token(Token = "0x4000131")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10C")]
		private bool solved;

		[Token(Token = "0x4000132")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private float angle;

		[Token(Token = "0x4000133")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private Transform forefeetRoot;

		[Token(Token = "0x4000134")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private Quaternion headRotation;

		[Token(Token = "0x4000135")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private float lastWeight;

		[Token(Token = "0x6000248")]
		[Address(RVA = "0x1703690", Offset = "0x1703690", VA = "0x1703690", Slot = "5")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9DDA1C", Offset = "0x9DDA1C")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000249")]
		[Address(RVA = "0x17036DC", Offset = "0x17036DC", VA = "0x17036DC", Slot = "6")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9DDA54", Offset = "0x9DDA54")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x600024A")]
		[Address(RVA = "0x1703728", Offset = "0x1703728", VA = "0x1703728", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x600024B")]
		[Address(RVA = "0x1703770", Offset = "0x1703770", VA = "0x1703770")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x600024C")]
		[Address(RVA = "0x17038AC", Offset = "0x17038AC", VA = "0x17038AC")]
		private bool IsReadyToInitiateLegs(IK[] ikComponents)
		{
			return default(bool);
		}

		[Token(Token = "0x600024D")]
		[Address(RVA = "0x1703A64", Offset = "0x1703A64", VA = "0x1703A64")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600024E")]
		[Address(RVA = "0x1703B44", Offset = "0x1703B44", VA = "0x1703B44")]
		private void Update()
		{
		}

		[Token(Token = "0x600024F")]
		[Address(RVA = "0x1703BFC", Offset = "0x1703BFC", VA = "0x1703BFC")]
		private void Initiate()
		{
		}

		[Token(Token = "0x6000250")]
		[Address(RVA = "0x1703FE0", Offset = "0x1703FE0", VA = "0x1703FE0")]
		private Transform[] InitiateFeet(IK[] ikComponents, ref Foot[] f, int indexOffset)
		{
			return null;
		}

		[Token(Token = "0x6000251")]
		[Address(RVA = "0x1704470", Offset = "0x1704470", VA = "0x1704470")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000252")]
		[Address(RVA = "0x17045BC", Offset = "0x17045BC", VA = "0x17045BC")]
		private void RootRotation()
		{
		}

		[Token(Token = "0x6000253")]
		[Address(RVA = "0x17049DC", Offset = "0x17049DC", VA = "0x17049DC")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x6000254")]
		[Address(RVA = "0x17053FC", Offset = "0x17053FC", VA = "0x17053FC")]
		private void UpdateForefeetRoot()
		{
		}

		[Token(Token = "0x6000255")]
		[Address(RVA = "0x1705760", Offset = "0x1705760", VA = "0x1705760")]
		private void SetFootIK(Foot foot, float maxOffset)
		{
		}

		[Token(Token = "0x6000256")]
		[Address(RVA = "0x17058F4", Offset = "0x17058F4", VA = "0x17058F4")]
		private void OnPostSolverUpdate()
		{
		}

		[Token(Token = "0x6000257")]
		[Address(RVA = "0x1705CEC", Offset = "0x1705CEC", VA = "0x1705CEC")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000258")]
		[Address(RVA = "0x1705D30", Offset = "0x1705D30", VA = "0x1705D30")]
		private void DestroyLegs(IK[] ikComponents)
		{
		}

		[Token(Token = "0x6000259")]
		[Address(RVA = "0x1705F44", Offset = "0x1705F44", VA = "0x1705F44")]
		public GrounderQuadruped()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000039")]
	public class Grounding
	{
		[Serializable]
		[Token(Token = "0x200013F")]
		public enum Quality
		{
			[Token(Token = "0x4000818")]
			Fastest,
			[Token(Token = "0x4000819")]
			Simple,
			[Token(Token = "0x400081A")]
			Best
		}

		[Token(Token = "0x2000140")]
		public class Leg
		{
			[Token(Token = "0x400081B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DAB84", Offset = "0x9DAB84")]
			private bool <isGrounded>k__BackingField;

			[Token(Token = "0x400081C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DAB94", Offset = "0x9DAB94")]
			private Vector3 <IKPosition>k__BackingField;

			[Token(Token = "0x400081D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DABA4", Offset = "0x9DABA4")]
			private Quaternion <rotationOffset>k__BackingField;

			[Token(Token = "0x400081E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DABB4", Offset = "0x9DABB4")]
			private bool <initiated>k__BackingField;

			[Token(Token = "0x400081F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DABC4", Offset = "0x9DABC4")]
			private float <heightFromGround>k__BackingField;

			[Token(Token = "0x4000820")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DABD4", Offset = "0x9DABD4")]
			private Vector3 <velocity>k__BackingField;

			[Token(Token = "0x4000821")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DABE4", Offset = "0x9DABE4")]
			private Transform <transform>k__BackingField;

			[Token(Token = "0x4000822")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DABF4", Offset = "0x9DABF4")]
			private float <IKOffset>k__BackingField;

			[Token(Token = "0x4000823")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private Grounding grounding;

			[Token(Token = "0x4000824")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private float lastTime;

			[Token(Token = "0x4000825")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			private float deltaTime;

			[Token(Token = "0x4000826")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			private Vector3 lastPosition;

			[Token(Token = "0x4000827")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
			private Quaternion toHitNormal;

			[Token(Token = "0x4000828")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
			private Quaternion r;

			[Token(Token = "0x4000829")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
			private RaycastHit heelHit;

			[Token(Token = "0x400082A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
			private Vector3 up;

			[Token(Token = "0x1700018E")]
			public bool isGrounded
			{
				[Token(Token = "0x6000990")]
				[Address(RVA = "0x170709C", Offset = "0x170709C", VA = "0x170709C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E0374", Offset = "0x9E0374")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6000991")]
				[Address(RVA = "0x1707870", Offset = "0x1707870", VA = "0x1707870")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E0384", Offset = "0x9E0384")]
				private set
				{
				}
			}

			[Token(Token = "0x1700018F")]
			public Vector3 IKPosition
			{
				[Token(Token = "0x6000992")]
				[Address(RVA = "0x16FEC90", Offset = "0x16FEC90", VA = "0x16FEC90")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E0394", Offset = "0x9E0394")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000993")]
				[Address(RVA = "0x170787C", Offset = "0x170787C", VA = "0x170787C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E03A4", Offset = "0x9E03A4")]
				private set
				{
				}
			}

			[Token(Token = "0x17000190")]
			public Quaternion rotationOffset
			{
				[Token(Token = "0x6000994")]
				[Address(RVA = "0x170098C", Offset = "0x170098C", VA = "0x170098C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E03B4", Offset = "0x9E03B4")]
				get
				{
					return default(Quaternion);
				}
				[Token(Token = "0x6000995")]
				[Address(RVA = "0x1707888", Offset = "0x1707888", VA = "0x1707888")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E03C4", Offset = "0x9E03C4")]
				private set
				{
				}
			}

			[Token(Token = "0x17000191")]
			public bool initiated
			{
				[Token(Token = "0x6000996")]
				[Address(RVA = "0x1707894", Offset = "0x1707894", VA = "0x1707894")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E03D4", Offset = "0x9E03D4")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6000997")]
				[Address(RVA = "0x170789C", Offset = "0x170789C", VA = "0x170789C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E03E4", Offset = "0x9E03E4")]
				private set
				{
				}
			}

			[Token(Token = "0x17000192")]
			public float heightFromGround
			{
				[Token(Token = "0x6000998")]
				[Address(RVA = "0x17078A8", Offset = "0x17078A8", VA = "0x17078A8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E03F4", Offset = "0x9E03F4")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000999")]
				[Address(RVA = "0x17078B0", Offset = "0x17078B0", VA = "0x17078B0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E0404", Offset = "0x9E0404")]
				private set
				{
				}
			}

			[Token(Token = "0x17000193")]
			public Vector3 velocity
			{
				[Token(Token = "0x600099A")]
				[Address(RVA = "0x17078B8", Offset = "0x17078B8", VA = "0x17078B8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E0414", Offset = "0x9E0414")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x600099B")]
				[Address(RVA = "0x17078C4", Offset = "0x17078C4", VA = "0x17078C4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E0424", Offset = "0x9E0424")]
				private set
				{
				}
			}

			[Token(Token = "0x17000194")]
			public Transform transform
			{
				[Token(Token = "0x600099C")]
				[Address(RVA = "0x16FEC9C", Offset = "0x16FEC9C", VA = "0x16FEC9C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E0434", Offset = "0x9E0434")]
				get
				{
					return null;
				}
				[Token(Token = "0x600099D")]
				[Address(RVA = "0x17078D0", Offset = "0x17078D0", VA = "0x17078D0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E0444", Offset = "0x9E0444")]
				private set
				{
				}
			}

			[Token(Token = "0x17000195")]
			public float IKOffset
			{
				[Token(Token = "0x600099E")]
				[Address(RVA = "0x1707094", Offset = "0x1707094", VA = "0x1707094")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E0454", Offset = "0x9E0454")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x600099F")]
				[Address(RVA = "0x17078D8", Offset = "0x17078D8", VA = "0x17078D8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E0464", Offset = "0x9E0464")]
				private set
				{
				}
			}

			[Token(Token = "0x17000196")]
			public float stepHeightFromGround
			{
				[Token(Token = "0x60009A4")]
				[Address(RVA = "0x1708250", Offset = "0x1708250", VA = "0x1708250")]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x17000197")]
			private float rootYOffset
			{
				[Token(Token = "0x60009AD")]
				[Address(RVA = "0x17085D4", Offset = "0x17085D4", VA = "0x17085D4")]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x60009A0")]
			[Address(RVA = "0x170664C", Offset = "0x170664C", VA = "0x170664C")]
			public void Initiate(Grounding grounding, Transform transform)
			{
			}

			[Token(Token = "0x60009A1")]
			[Address(RVA = "0x17078E0", Offset = "0x17078E0", VA = "0x17078E0")]
			public void OnEnable()
			{
			}

			[Token(Token = "0x60009A2")]
			[Address(RVA = "0x1707454", Offset = "0x1707454", VA = "0x1707454")]
			public void Reset()
			{
			}

			[Token(Token = "0x60009A3")]
			[Address(RVA = "0x170672C", Offset = "0x170672C", VA = "0x170672C")]
			public void Process()
			{
			}

			[Token(Token = "0x60009A5")]
			[Address(RVA = "0x1707F58", Offset = "0x1707F58", VA = "0x1707F58")]
			private RaycastHit GetCapsuleHit(Vector3 offsetFromHeel)
			{
				return default(RaycastHit);
			}

			[Token(Token = "0x60009A6")]
			[Address(RVA = "0x1707934", Offset = "0x1707934", VA = "0x1707934")]
			private RaycastHit GetRaycastHit(Vector3 offsetFromHeel)
			{
				return default(RaycastHit);
			}

			[Token(Token = "0x60009A7")]
			[Address(RVA = "0x1708414", Offset = "0x1708414", VA = "0x1708414")]
			private Vector3 RotateNormal(Vector3 normal)
			{
				return default(Vector3);
			}

			[Token(Token = "0x60009A8")]
			[Address(RVA = "0x1707BDC", Offset = "0x1707BDC", VA = "0x1707BDC")]
			private void SetFootToPoint(Vector3 normal, Vector3 point)
			{
			}

			[Token(Token = "0x60009A9")]
			[Address(RVA = "0x1707CE4", Offset = "0x1707CE4", VA = "0x1707CE4")]
			private void SetFootToPlane(Vector3 planeNormal, Vector3 planePoint, Vector3 heelHitPoint)
			{
			}

			[Token(Token = "0x60009AA")]
			[Address(RVA = "0x1708524", Offset = "0x1708524", VA = "0x1708524")]
			private float GetHeightFromGround(Vector3 hitPoint)
			{
				return default(float);
			}

			[Token(Token = "0x60009AB")]
			[Address(RVA = "0x1708300", Offset = "0x1708300", VA = "0x1708300")]
			private void RotateFoot()
			{
			}

			[Token(Token = "0x60009AC")]
			[Address(RVA = "0x1708740", Offset = "0x1708740", VA = "0x1708740")]
			private Quaternion GetRotationOffsetTarget()
			{
				return default(Quaternion);
			}

			[Token(Token = "0x60009AE")]
			[Address(RVA = "0x17065CC", Offset = "0x17065CC", VA = "0x17065CC")]
			public Leg()
			{
			}
		}

		[Token(Token = "0x2000141")]
		public class Pelvis
		{
			[Token(Token = "0x400082B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DAC04", Offset = "0x9DAC04")]
			private Vector3 <IKOffset>k__BackingField;

			[Token(Token = "0x400082C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DAC14", Offset = "0x9DAC14")]
			private float <heightOffset>k__BackingField;

			[Token(Token = "0x400082D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private Grounding grounding;

			[Token(Token = "0x400082E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private Vector3 lastRootPosition;

			[Token(Token = "0x400082F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private float damperF;

			[Token(Token = "0x4000830")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private bool initiated;

			[Token(Token = "0x4000831")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private float lastTime;

			[Token(Token = "0x17000198")]
			public Vector3 IKOffset
			{
				[Token(Token = "0x60009AF")]
				[Address(RVA = "0x1700524", Offset = "0x1700524", VA = "0x1700524")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E0474", Offset = "0x9E0474")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x60009B0")]
				[Address(RVA = "0x17088B8", Offset = "0x17088B8", VA = "0x17088B8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E0484", Offset = "0x9E0484")]
				private set
				{
				}
			}

			[Token(Token = "0x17000199")]
			public float heightOffset
			{
				[Token(Token = "0x60009B1")]
				[Address(RVA = "0x1705758", Offset = "0x1705758", VA = "0x1705758")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E0494", Offset = "0x9E0494")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x60009B2")]
				[Address(RVA = "0x17088C4", Offset = "0x17088C4", VA = "0x17088C4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E04A4", Offset = "0x9E04A4")]
				private set
				{
				}
			}

			[Token(Token = "0x60009B3")]
			[Address(RVA = "0x1706704", Offset = "0x1706704", VA = "0x1706704")]
			public void Initiate(Grounding grounding)
			{
			}

			[Token(Token = "0x60009B4")]
			[Address(RVA = "0x1707388", Offset = "0x1707388", VA = "0x1707388")]
			public void Reset()
			{
			}

			[Token(Token = "0x60009B5")]
			[Address(RVA = "0x17088CC", Offset = "0x17088CC", VA = "0x17088CC")]
			public void OnEnable()
			{
			}

			[Token(Token = "0x60009B6")]
			[Address(RVA = "0x17070A4", Offset = "0x17070A4", VA = "0x17070A4")]
			public void Process(float lowestOffset, float highestOffset, bool isGrounded)
			{
			}

			[Token(Token = "0x60009B7")]
			[Address(RVA = "0x1706644", Offset = "0x1706644", VA = "0x1706644")]
			public Pelvis()
			{
			}
		}

		[Token(Token = "0x4000136")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9D6AD8", Offset = "0x9D6AD8")]
		public LayerMask layers;

		[Token(Token = "0x4000137")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9D6B10", Offset = "0x9D6B10")]
		public float maxStep;

		[Token(Token = "0x4000138")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9D6B48", Offset = "0x9D6B48")]
		public float heightOffset;

		[Token(Token = "0x4000139")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9D6B80", Offset = "0x9D6B80")]
		public float footSpeed;

		[Token(Token = "0x400013A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9D6BB8", Offset = "0x9D6BB8")]
		public float footRadius;

		[Token(Token = "0x400013B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9D6BF0", Offset = "0x9D6BF0")]
		public float prediction;

		[Token(Token = "0x400013C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9D6C28", Offset = "0x9D6C28")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9D6C28", Offset = "0x9D6C28")]
		public float footRotationWeight;

		[Token(Token = "0x400013D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9D6C7C", Offset = "0x9D6C7C")]
		public float footRotationSpeed;

		[Token(Token = "0x400013E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9D6CB4", Offset = "0x9D6CB4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9D6CB4", Offset = "0x9D6CB4")]
		public float maxFootRotationAngle;

		[Token(Token = "0x400013F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9D6D0C", Offset = "0x9D6D0C")]
		public bool rotateSolver;

		[Token(Token = "0x4000140")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9D6D44", Offset = "0x9D6D44")]
		public float pelvisSpeed;

		[Token(Token = "0x4000141")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9D6D7C", Offset = "0x9D6D7C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9D6D7C", Offset = "0x9D6D7C")]
		public float pelvisDamper;

		[Token(Token = "0x4000142")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9D6DD0", Offset = "0x9D6DD0")]
		public float lowerPelvisWeight;

		[Token(Token = "0x4000143")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9D6E08", Offset = "0x9D6E08")]
		public float liftPelvisWeight;

		[Token(Token = "0x4000144")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9D6E40", Offset = "0x9D6E40")]
		public float rootSphereCastRadius;

		[Token(Token = "0x4000145")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9D6E78", Offset = "0x9D6E78")]
		public Quality quality;

		[Token(Token = "0x4000146")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9D6EB0", Offset = "0x9D6EB0")]
		private Leg[] <legs>k__BackingField;

		[Token(Token = "0x4000147")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9D6EC0", Offset = "0x9D6EC0")]
		private Pelvis <pelvis>k__BackingField;

		[Token(Token = "0x4000148")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9D6ED0", Offset = "0x9D6ED0")]
		private bool <isGrounded>k__BackingField;

		[Token(Token = "0x4000149")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9D6EE0", Offset = "0x9D6EE0")]
		private Transform <root>k__BackingField;

		[Token(Token = "0x400014A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9D6EF0", Offset = "0x9D6EF0")]
		private RaycastHit <rootHit>k__BackingField;

		[Token(Token = "0x400014B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private bool initiated;

		[Token(Token = "0x17000063")]
		public Leg[] legs
		{
			[Token(Token = "0x600025A")]
			[Address(RVA = "0x16FE820", Offset = "0x16FE820", VA = "0x16FE820")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DDA8C", Offset = "0x9DDA8C")]
			get
			{
				return null;
			}
			[Token(Token = "0x600025B")]
			[Address(RVA = "0x1706050", Offset = "0x1706050", VA = "0x1706050")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DDA9C", Offset = "0x9DDA9C")]
			private set
			{
			}
		}

		[Token(Token = "0x17000064")]
		public Pelvis pelvis
		{
			[Token(Token = "0x600025C")]
			[Address(RVA = "0x170051C", Offset = "0x170051C", VA = "0x170051C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DDAAC", Offset = "0x9DDAAC")]
			get
			{
				return null;
			}
			[Token(Token = "0x600025D")]
			[Address(RVA = "0x1706058", Offset = "0x1706058", VA = "0x1706058")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DDABC", Offset = "0x9DDABC")]
			private set
			{
			}
		}

		[Token(Token = "0x17000065")]
		public bool isGrounded
		{
			[Token(Token = "0x600025E")]
			[Address(RVA = "0x1706060", Offset = "0x1706060", VA = "0x1706060")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DDACC", Offset = "0x9DDACC")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600025F")]
			[Address(RVA = "0x1706068", Offset = "0x1706068", VA = "0x1706068")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DDADC", Offset = "0x9DDADC")]
			private set
			{
			}
		}

		[Token(Token = "0x17000066")]
		public Transform root
		{
			[Token(Token = "0x6000260")]
			[Address(RVA = "0x16FEC88", Offset = "0x16FEC88", VA = "0x16FEC88")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DDAEC", Offset = "0x9DDAEC")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000261")]
			[Address(RVA = "0x1706074", Offset = "0x1706074", VA = "0x1706074")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DDAFC", Offset = "0x9DDAFC")]
			private set
			{
			}
		}

		[Token(Token = "0x17000067")]
		public RaycastHit rootHit
		{
			[Token(Token = "0x6000262")]
			[Address(RVA = "0x17049C0", Offset = "0x17049C0", VA = "0x17049C0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DDB0C", Offset = "0x9DDB0C")]
			get
			{
				return default(RaycastHit);
			}
			[Token(Token = "0x6000263")]
			[Address(RVA = "0x170607C", Offset = "0x170607C", VA = "0x170607C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DDB1C", Offset = "0x9DDB1C")]
			private set
			{
			}
		}

		[Token(Token = "0x17000068")]
		public bool rootGrounded
		{
			[Token(Token = "0x6000264")]
			[Address(RVA = "0x1706098", Offset = "0x1706098", VA = "0x1706098")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000069")]
		public Vector3 up
		{
			[Token(Token = "0x600026C")]
			[Address(RVA = "0x1700688", Offset = "0x1700688", VA = "0x1700688")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x1700006A")]
		private bool useRootRotation
		{
			[Token(Token = "0x600026F")]
			[Address(RVA = "0x170751C", Offset = "0x170751C", VA = "0x170751C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000265")]
		[Address(RVA = "0x17060F0", Offset = "0x17060F0", VA = "0x17060F0")]
		public RaycastHit GetRootHit(float maxDistanceMlp = 10f)
		{
			return default(RaycastHit);
		}

		[Token(Token = "0x6000266")]
		[Address(RVA = "0x17064F0", Offset = "0x17064F0", VA = "0x17064F0")]
		public bool IsValid(ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000267")]
		[Address(RVA = "0x16FF7B0", Offset = "0x16FF7B0", VA = "0x16FF7B0")]
		public void Initiate(Transform root, Transform[] feet)
		{
		}

		[Token(Token = "0x6000268")]
		[Address(RVA = "0x170027C", Offset = "0x170027C", VA = "0x170027C")]
		public void Update()
		{
		}

		[Token(Token = "0x6000269")]
		[Address(RVA = "0x1702578", Offset = "0x1702578", VA = "0x1702578")]
		public Vector3 GetLegsPlaneNormal()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600026A")]
		[Address(RVA = "0x16FF12C", Offset = "0x16FF12C", VA = "0x16FF12C")]
		public void Reset()
		{
		}

		[Token(Token = "0x600026B")]
		[Address(RVA = "0x1706714", Offset = "0x1706714", VA = "0x1706714")]
		public void LogWarning(string message)
		{
		}

		[Token(Token = "0x600026D")]
		[Address(RVA = "0x17075F4", Offset = "0x17075F4", VA = "0x17075F4")]
		public float GetVerticalOffset(Vector3 p1, Vector3 p2)
		{
			return default(float);
		}

		[Token(Token = "0x600026E")]
		[Address(RVA = "0x1707764", Offset = "0x1707764", VA = "0x1707764")]
		public Vector3 Flatten(Vector3 v)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000270")]
		[Address(RVA = "0x16FED58", Offset = "0x16FED58", VA = "0x16FED58")]
		public Grounding()
		{
		}
	}
	[Token(Token = "0x200003A")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x9D50AC", Offset = "0x9D50AC")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x9D50AC", Offset = "0x9D50AC")]
	public class AimIK : IK
	{
		[Token(Token = "0x400014C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverAim solver;

		[Token(Token = "0x6000271")]
		[Address(RVA = "0xF78D1C", Offset = "0xF78D1C", VA = "0xF78D1C", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9DDB2C", Offset = "0x9DDB2C")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000272")]
		[Address(RVA = "0xF78D68", Offset = "0xF78D68", VA = "0xF78D68", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9DDB64", Offset = "0x9DDB64")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000273")]
		[Address(RVA = "0xF78DB4", Offset = "0xF78DB4", VA = "0xF78DB4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9DDB9C", Offset = "0x9DDB9C")]
		private void OpenSetupTutorial()
		{
		}

		[Token(Token = "0x6000274")]
		[Address(RVA = "0xF78E00", Offset = "0xF78E00", VA = "0xF78E00")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9DDBD4", Offset = "0x9DDBD4")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000275")]
		[Address(RVA = "0xF78E4C", Offset = "0xF78E4C", VA = "0xF78E4C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9DDC0C", Offset = "0x9DDC0C")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000276")]
		[Address(RVA = "0xF78E98", Offset = "0xF78E98", VA = "0xF78E98", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000277")]
		[Address(RVA = "0xF78EA0", Offset = "0xF78EA0", VA = "0xF78EA0")]
		public AimIK()
		{
		}
	}
	[Token(Token = "0x200003B")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x9D510C", Offset = "0x9D510C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x9D510C", Offset = "0x9D510C")]
	public class CCDIK : IK
	{
		[Token(Token = "0x400014D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverCCD solver;

		[Token(Token = "0x6000278")]
		[Address(RVA = "0xF7B92C", Offset = "0xF7B92C", VA = "0xF7B92C", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9DDC44", Offset = "0x9DDC44")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000279")]
		[Address(RVA = "0xF7B978", Offset = "0xF7B978", VA = "0xF7B978", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9DDC7C", Offset = "0x9DDC7C")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x600027A")]
		[Address(RVA = "0xF7B9C4", Offset = "0xF7B9C4", VA = "0xF7B9C4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9DDCB4", Offset = "0x9DDCB4")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600027B")]
		[Address(RVA = "0xF7BA10", Offset = "0xF7BA10", VA = "0xF7BA10")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9DDCEC", Offset = "0x9DDCEC")]
		private void ASThread()
		{
		}

		[Token(Token = "0x600027C")]
		[Address(RVA = "0xF7BA5C", Offset = "0xF7BA5C", VA = "0xF7BA5C", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x600027D")]
		[Address(RVA = "0xF7BA64", Offset = "0xF7BA64", VA = "0xF7BA64")]
		public CCDIK()
		{
		}
	}
	[Token(Token = "0x200003C")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x9D516C", Offset = "0x9D516C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x9D516C", Offset = "0x9D516C")]
	public class FABRIK : IK
	{
		[Token(Token = "0x400014E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverFABRIK solver;

		[Token(Token = "0x600027E")]
		[Address(RVA = "0xF7C518", Offset = "0xF7C518", VA = "0xF7C518", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9DDD24", Offset = "0x9DDD24")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x600027F")]
		[Address(RVA = "0xF7C564", Offset = "0xF7C564", VA = "0xF7C564", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9DDD5C", Offset = "0x9DDD5C")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000280")]
		[Address(RVA = "0xF7C5B0", Offset = "0xF7C5B0", VA = "0xF7C5B0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9DDD94", Offset = "0x9DDD94")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000281")]
		[Address(RVA = "0xF7C5FC", Offset = "0xF7C5FC", VA = "0xF7C5FC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9DDDCC", Offset = "0x9DDDCC")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000282")]
		[Address(RVA = "0xF7C648", Offset = "0xF7C648", VA = "0xF7C648", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000283")]
		[Address(RVA = "0xF7C650", Offset = "0xF7C650", VA = "0xF7C650")]
		public FABRIK()
		{
		}
	}
	[Token(Token = "0x200003D")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x9D51CC", Offset = "0x9D51CC")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x9D51CC", Offset = "0x9D51CC")]
	public class FABRIKRoot : IK
	{
		[Token(Token = "0x400014F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverFABRIKRoot solver;

		[Token(Token = "0x6000284")]
		[Address(RVA = "0xF7CFB4", Offset = "0xF7CFB4", VA = "0xF7CFB4", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9DDE04", Offset = "0x9DDE04")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000285")]
		[Address(RVA = "0xF7D000", Offset = "0xF7D000", VA = "0xF7D000", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9DDE3C", Offset = "0x9DDE3C")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000286")]
		[Address(RVA = "0xF7D04C", Offset = "0xF7D04C", VA = "0xF7D04C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9DDE74", Offset = "0x9DDE74")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000287")]
		[Address(RVA = "0xF7D098", Offset = "0xF7D098", VA = "0xF7D098")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9DDEAC", Offset = "0x9DDEAC")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000288")]
		[Address(RVA = "0xF7D0E4", Offset = "0xF7D0E4", VA = "0xF7D0E4", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000289")]
		[Address(RVA = "0xF7D0EC", Offset = "0xF7D0EC", VA = "0xF7D0EC")]
		public FABRIKRoot()
		{
		}
	}
	[Token(Token = "0x200003E")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x9D522C", Offset = "0x9D522C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x9D522C", Offset = "0x9D522C")]
	public class FullBodyBipedIK : IK
	{
		[Token(Token = "0x4000150")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public BipedReferences references;

		[Token(Token = "0x4000151")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public IKSolverFullBodyBiped solver;

		[Token(Token = "0x600028A")]
		[Address(RVA = "0x16FD348", Offset = "0x16FD348", VA = "0x16FD348", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9DDEE4", Offset = "0x9DDEE4")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x600028B")]
		[Address(RVA = "0x16FD394", Offset = "0x16FD394", VA = "0x16FD394", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9DDF1C", Offset = "0x9DDF1C")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x600028C")]
		[Address(RVA = "0x16FD3E0", Offset = "0x16FD3E0", VA = "0x16FD3E0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9DDF54", Offset = "0x9DDF54")]
		private void OpenSetupTutorial()
		{
		}

		[Token(Token = "0x600028D")]
		[Address(RVA = "0x16FD42C", Offset = "0x16FD42C", VA = "0x16FD42C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9DDF8C", Offset = "0x9DDF8C")]
		private void OpenInspectorTutorial()
		{
		}

		[Token(Token = "0x600028E")]
		[Address(RVA = "0x16FD478", Offset = "0x16FD478", VA = "0x16FD478")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9DDFC4", Offset = "0x9DDFC4")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600028F")]
		[Address(RVA = "0x16FD4C4", Offset = "0x16FD4C4", VA = "0x16FD4C4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9DDFFC", Offset = "0x9DDFFC")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000290")]
		[Address(RVA = "0x16FD510", Offset = "0x16FD510", VA = "0x16FD510")]
		public void SetReferences(BipedReferences references, Transform rootNode)
		{
		}

		[Token(Token = "0x6000291")]
		[Address(RVA = "0x16FD55C", Offset = "0x16FD55C", VA = "0x16FD55C", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000292")]
		[Address(RVA = "0x16FD564", Offset = "0x16FD564", VA = "0x16FD564")]
		public bool ReferencesError(ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000293")]
		[Address(RVA = "0x16FD788", Offset = "0x16FD788", VA = "0x16FD788")]
		public bool ReferencesWarning(ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000294")]
		[Address(RVA = "0x16FDB78", Offset = "0x16FDB78", VA = "0x16FDB78")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9DE034", Offset = "0x9DE034")]
		private void Reinitiate()
		{
		}

		[Token(Token = "0x6000295")]
		[Address(RVA = "0x16FDBB8", Offset = "0x16FDBB8", VA = "0x16FDBB8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9DE06C", Offset = "0x9DE06C")]
		private void AutoDetectReferences()
		{
		}

		[Token(Token = "0x6000296")]
		[Address(RVA = "0x16FDCCC", Offset = "0x16FDCCC", VA = "0x16FDCCC")]
		public FullBodyBipedIK()
		{
		}
	}
	[Token(Token = "0x200003F")]
	public abstract class IK : SolverManager
	{
		[Token(Token = "0x6000297")]
		public abstract IKSolver GetIKSolver();

		[Token(Token = "0x6000298")]
		[Address(RVA = "0x170BCF8", Offset = "0x170BCF8", VA = "0x170BCF8", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x6000299")]
		[Address(RVA = "0x170BDFC", Offset = "0x170BDFC", VA = "0x170BDFC", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x600029A")]
		[Address(RVA = "0x170BFC8", Offset = "0x170BFC8", VA = "0x170BFC8", Slot = "6")]
		protected override void FixTransforms()
		{
		}

		[Token(Token = "0x600029B")]
		protected abstract void OpenUserManual();

		[Token(Token = "0x600029C")]
		protected abstract void OpenScriptReference();

		[Token(Token = "0x600029D")]
		[Address(RVA = "0x16FDD54", Offset = "0x16FDD54", VA = "0x16FDD54")]
		protected IK()
		{
		}
	}
	[Token(Token = "0x2000040")]
	public class IKExecutionOrder : MonoBehaviour
	{
		[Token(Token = "0x4000152")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public IK[] IKComponents;

		[Token(Token = "0x600029E")]
		[Address(RVA = "0x170F7D8", Offset = "0x170F7D8", VA = "0x170F7D8")]
		private void Start()
		{
		}

		[Token(Token = "0x600029F")]
		[Address(RVA = "0x170F878", Offset = "0x170F878", VA = "0x170F878")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60002A0")]
		[Address(RVA = "0x170F92C", Offset = "0x170F92C", VA = "0x170F92C")]
		public IKExecutionOrder()
		{
		}
	}
	[Token(Token = "0x2000041")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x9D528C", Offset = "0x9D528C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x9D528C", Offset = "0x9D528C")]
	public class LimbIK : IK
	{
		[Token(Token = "0x4000153")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverLimb solver;

		[Token(Token = "0x60002A1")]
		[Address(RVA = "0xEDD044", Offset = "0xEDD044", VA = "0xEDD044", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9DE0A4", Offset = "0x9DE0A4")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60002A2")]
		[Address(RVA = "0xEDD090", Offset = "0xEDD090", VA = "0xEDD090", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9DE0DC", Offset = "0x9DE0DC")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60002A3")]
		[Address(RVA = "0xEDD0DC", Offset = "0xEDD0DC", VA = "0xEDD0DC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9DE114", Offset = "0x9DE114")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60002A4")]
		[Address(RVA = "0xEDD128", Offset = "0xEDD128", VA = "0xEDD128")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9DE14C", Offset = "0x9DE14C")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60002A5")]
		[Address(RVA = "0xEDD174", Offset = "0xEDD174", VA = "0xEDD174", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x60002A6")]
		[Address(RVA = "0xEDD17C", Offset = "0xEDD17C", VA = "0xEDD17C")]
		public LimbIK()
		{
		}
	}
	[Token(Token = "0x2000042")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x9D52EC", Offset = "0x9D52EC")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x9D52EC", Offset = "0x9D52EC")]
	public class LookAtIK : IK
	{
		[Token(Token = "0x4000154")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverLookAt solver;

		[Token(Token = "0x60002A7")]
		[Address(RVA = "0xEDD1E4", Offset = "0xEDD1E4", VA = "0xEDD1E4", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9DE184", Offset = "0x9DE184")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60002A8")]
		[Address(RVA = "0xEDD230", Offset = "0xEDD230", VA = "0xEDD230", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9DE1BC", Offset = "0x9DE1BC")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60002A9")]
		[Address(RVA = "0xEDD27C", Offset = "0xEDD27C", VA = "0xEDD27C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9DE1F4", Offset = "0x9DE1F4")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60002AA")]
		[Address(RVA = "0xEDD2C8", Offset = "0xEDD2C8", VA = "0xEDD2C8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9DE22C", Offset = "0x9DE22C")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60002AB")]
		[Address(RVA = "0xEDD314", Offset = "0xEDD314", VA = "0xEDD314", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x60002AC")]
		[Address(RVA = "0xEDD31C", Offset = "0xEDD31C", VA = "0xEDD31C")]
		public LookAtIK()
		{
		}
	}
	[Token(Token = "0x2000043")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x9D534C", Offset = "0x9D534C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x9D534C", Offset = "0x9D534C")]
	public class TrigonometricIK : IK
	{
		[Token(Token = "0x4000155")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverTrigonometric solver;

		[Token(Token = "0x60002AD")]
		[Address(RVA = "0xEE6488", Offset = "0xEE6488", VA = "0xEE6488", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9DE264", Offset = "0x9DE264")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60002AE")]
		[Address(RVA = "0xEE64D4", Offset = "0xEE64D4", VA = "0xEE64D4", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9DE29C", Offset = "0x9DE29C")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60002AF")]
		[Address(RVA = "0xEE6520", Offset = "0xEE6520", VA = "0xEE6520")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9DE2D4", Offset = "0x9DE2D4")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60002B0")]
		[Address(RVA = "0xEE656C", Offset = "0xEE656C", VA = "0xEE656C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9DE30C", Offset = "0x9DE30C")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60002B1")]
		[Address(RVA = "0xEE65B8", Offset = "0xEE65B8", VA = "0xEE65B8", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x60002B2")]
		[Address(RVA = "0xEE65C0", Offset = "0xEE65C0", VA = "0xEE65C0")]
		public TrigonometricIK()
		{
		}
	}
	[Token(Token = "0x2000044")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x9D53AC", Offset = "0x9D53AC")]
	public class VRIK : IK
	{
		[Serializable]
		[Token(Token = "0x2000142")]
		public class References
		{
			[Token(Token = "0x4000832")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform root;

			[Token(Token = "0x4000833")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Transform pelvis;

			[Token(Token = "0x4000834")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Transform spine;

			[Token(Token = "0x4000835")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Transform chest;

			[Token(Token = "0x4000836")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Transform neck;

			[Token(Token = "0x4000837")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Transform head;

			[Token(Token = "0x4000838")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public Transform leftShoulder;

			[Token(Token = "0x4000839")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public Transform leftUpperArm;

			[Token(Token = "0x400083A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public Transform leftForearm;

			[Token(Token = "0x400083B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public Transform leftHand;

			[Token(Token = "0x400083C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			public Transform rightShoulder;

			[Token(Token = "0x400083D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			public Transform rightUpperArm;

			[Token(Token = "0x400083E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			public Transform rightForearm;

			[Token(Token = "0x400083F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			public Transform rightHand;

			[Token(Token = "0x4000840")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			public Transform leftThigh;

			[Token(Token = "0x4000841")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
			public Transform leftCalf;

			[Token(Token = "0x4000842")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			public Transform leftFoot;

			[Token(Token = "0x4000843")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			public Transform leftToes;

			[Token(Token = "0x4000844")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			public Transform rightThigh;

			[Token(Token = "0x4000845")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
			public Transform rightCalf;

			[Token(Token = "0x4000846")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
			public Transform rightFoot;

			[Token(Token = "0x4000847")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
			public Transform rightToes;

			[Token(Token = "0x1700019A")]
			public bool isFilled
			{
				[Token(Token = "0x60009B9")]
				[Address(RVA = "0xEE77EC", Offset = "0xEE77EC", VA = "0xEE77EC")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x1700019B")]
			public bool isEmpty
			{
				[Token(Token = "0x60009BA")]
				[Address(RVA = "0xEE7370", Offset = "0xEE7370", VA = "0xEE7370")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x60009B8")]
			[Address(RVA = "0xEE7C08", Offset = "0xEE7C08", VA = "0xEE7C08")]
			public Transform[] GetTransforms()
			{
				return null;
			}

			[Token(Token = "0x60009BB")]
			[Address(RVA = "0xEE6D18", Offset = "0xEE6D18", VA = "0xEE6D18")]
			public static bool AutoDetectReferences(Transform root, out References references)
			{
				return default(bool);
			}

			[Token(Token = "0x60009BC")]
			[Address(RVA = "0xEE7C00", Offset = "0xEE7C00", VA = "0xEE7C00")]
			public References()
			{
			}
		}

		[Token(Token = "0x4000156")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "ContextMenuItemAttribute", RVA = "0x9D6F00", Offset = "0x9D6F00")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9D6F00", Offset = "0x9D6F00")]
		public References references;

		[Token(Token = "0x4000157")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9D6F7C", Offset = "0x9D6F7C")]
		public IKSolverVR solver;

		[Token(Token = "0x60002B3")]
		[Address(RVA = "0xEE6C18", Offset = "0xEE6C18", VA = "0xEE6C18", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9DE344", Offset = "0x9DE344")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60002B4")]
		[Address(RVA = "0xEE6C84", Offset = "0xEE6C84", VA = "0xEE6C84", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9DE37C", Offset = "0x9DE37C")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60002B5")]
		[Address(RVA = "0xEE6CF0", Offset = "0xEE6CF0", VA = "0xEE6CF0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9DE3B4", Offset = "0x9DE3B4")]
		public void AutoDetectReferences()
		{
		}

		[Token(Token = "0x60002B6")]
		[Address(RVA = "0xEE7294", Offset = "0xEE7294", VA = "0xEE7294")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9DE3EC", Offset = "0x9DE3EC")]
		public void GuessHandOrientations()
		{
		}

		[Token(Token = "0x60002B7")]
		[Address(RVA = "0xEE72CC", Offset = "0xEE72CC", VA = "0xEE72CC", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x60002B8")]
		[Address(RVA = "0xEE72D4", Offset = "0xEE72D4", VA = "0xEE72D4", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x60002B9")]
		[Address(RVA = "0xEE7B78", Offset = "0xEE7B78", VA = "0xEE7B78")]
		public VRIK()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000045")]
	public class FABRIKChain
	{
		[Token(Token = "0x4000158")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public FABRIK ik;

		[Token(Token = "0x4000159")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9D6FB4", Offset = "0x9D6FB4")]
		public float pull;

		[Token(Token = "0x400015A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9D6FCC", Offset = "0x9D6FCC")]
		public float pin;

		[Token(Token = "0x400015B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public int[] children;

		[Token(Token = "0x60002BA")]
		[Address(RVA = "0xF7C6B8", Offset = "0xF7C6B8", VA = "0xF7C6B8")]
		public bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60002BB")]
		[Address(RVA = "0xF7C790", Offset = "0xF7C790", VA = "0xF7C790")]
		public void Initiate()
		{
		}

		[Token(Token = "0x60002BC")]
		[Address(RVA = "0xF7C7C4", Offset = "0xF7C7C4", VA = "0xF7C7C4")]
		public void Stage1(FABRIKChain[] chain)
		{
		}

		[Token(Token = "0x60002BD")]
		[Address(RVA = "0xF7CD44", Offset = "0xF7CD44", VA = "0xF7CD44")]
		public void Stage2(Vector3 rootPosition, FABRIKChain[] chain)
		{
		}

		[Token(Token = "0x60002BE")]
		[Address(RVA = "0xF7C94C", Offset = "0xF7C94C", VA = "0xF7C94C")]
		private Vector3 GetCentroid(FABRIKChain[] chain)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002BF")]
		[Address(RVA = "0xF7CF4C", Offset = "0xF7CF4C", VA = "0xF7CF4C")]
		public FABRIKChain()
		{
		}
	}
	[Token(Token = "0x2000046")]
	public class FBBIKArmBending : MonoBehaviour
	{
		[Token(Token = "0x400015C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x400015D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Vector3 bendDirectionOffsetLeft;

		[Token(Token = "0x400015E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public Vector3 bendDirectionOffsetRight;

		[Token(Token = "0x400015F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Vector3 characterSpaceBendOffsetLeft;

		[Token(Token = "0x4000160")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public Vector3 characterSpaceBendOffsetRight;

		[Token(Token = "0x4000161")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Quaternion leftHandTargetRotation;

		[Token(Token = "0x4000162")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Quaternion rightHandTargetRotation;

		[Token(Token = "0x4000163")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private bool initiated;

		[Token(Token = "0x60002C0")]
		[Address(RVA = "0xF7D154", Offset = "0xF7D154", VA = "0xF7D154")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60002C1")]
		[Address(RVA = "0xF7D880", Offset = "0xF7D880", VA = "0xF7D880")]
		private void OnPostFBBIK()
		{
		}

		[Token(Token = "0x60002C2")]
		[Address(RVA = "0xF7DB54", Offset = "0xF7DB54", VA = "0xF7DB54")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60002C3")]
		[Address(RVA = "0xF7DC78", Offset = "0xF7DC78", VA = "0xF7DC78")]
		public FBBIKArmBending()
		{
		}
	}
	[Token(Token = "0x2000047")]
	public class FBBIKHeadEffector : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000143")]
		public class BendBone
		{
			[Token(Token = "0x4000848")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9DAC24", Offset = "0x9DAC24")]
			public Transform transform;

			[Token(Token = "0x4000849")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9DAC5C", Offset = "0x9DAC5C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9DAC5C", Offset = "0x9DAC5C")]
			public float weight;

			[Token(Token = "0x400084A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			private Quaternion defaultLocalRotation;

			[Token(Token = "0x60009BD")]
			[Address(RVA = "0xF81E6C", Offset = "0xF81E6C", VA = "0xF81E6C")]
			public BendBone()
			{
			}

			[Token(Token = "0x60009BE")]
			[Address(RVA = "0xF81EEC", Offset = "0xF81EEC", VA = "0xF81EEC")]
			public BendBone(Transform transform, float weight)
			{
			}

			[Token(Token = "0x60009BF")]
			[Address(RVA = "0xF7E7D4", Offset = "0xF7E7D4", VA = "0xF7E7D4")]
			public void StoreDefaultLocalState()
			{
			}

			[Token(Token = "0x60009C0")]
			[Address(RVA = "0xF7EE30", Offset = "0xF7EE30", VA = "0xF7EE30")]
			public void FixTransforms()
			{
			}
		}

		[Token(Token = "0x4000164")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9D6FE4", Offset = "0x9D6FE4")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x4000165")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x9D701C", Offset = "0x9D701C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9D701C", Offset = "0x9D701C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9D701C", Offset = "0x9D701C")]
		public float positionWeight;

		[Token(Token = "0x4000166")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9D7094", Offset = "0x9D7094")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9D7094", Offset = "0x9D7094")]
		public float bodyWeight;

		[Token(Token = "0x4000167")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9D70E8", Offset = "0x9D70E8")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9D70E8", Offset = "0x9D70E8")]
		public float thighWeight;

		[Token(Token = "0x4000168")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9D713C", Offset = "0x9D713C")]
		public bool handsPullBody;

		[Token(Token = "0x4000169")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x9D7174", Offset = "0x9D7174")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9D7174", Offset = "0x9D7174")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9D7174", Offset = "0x9D7174")]
		public float rotationWeight;

		[Token(Token = "0x400016A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9D71EC", Offset = "0x9D71EC")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9D71EC", Offset = "0x9D71EC")]
		public float bodyClampWeight;

		[Token(Token = "0x400016B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9D7240", Offset = "0x9D7240")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9D7240", Offset = "0x9D7240")]
		public float headClampWeight;

		[Token(Token = "0x400016C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9D7294", Offset = "0x9D7294")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9D7294", Offset = "0x9D7294")]
		public float bendWeight;

		[Token(Token = "0x400016D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9D72E8", Offset = "0x9D72E8")]
		public BendBone[] bendBones;

		[Token(Token = "0x400016E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x9D7320", Offset = "0x9D7320")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9D7320", Offset = "0x9D7320")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9D7320", Offset = "0x9D7320")]
		public float CCDWeight;

		[Token(Token = "0x400016F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9D7398", Offset = "0x9D7398")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9D7398", Offset = "0x9D7398")]
		public float roll;

		[Token(Token = "0x4000170")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9D73EC", Offset = "0x9D73EC")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9D73EC", Offset = "0x9D73EC")]
		public float damper;

		[Token(Token = "0x4000171")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9D7444", Offset = "0x9D7444")]
		public Transform[] CCDBones;

		[Token(Token = "0x4000172")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x9D747C", Offset = "0x9D747C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9D747C", Offset = "0x9D747C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9D747C", Offset = "0x9D747C")]
		public float postStretchWeight;

		[Token(Token = "0x4000173")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9D74F4", Offset = "0x9D74F4")]
		public float maxStretch;

		[Token(Token = "0x4000174")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9D752C", Offset = "0x9D752C")]
		public float stretchDamper;

		[Token(Token = "0x4000175")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9D7564", Offset = "0x9D7564")]
		public bool fixHead;

		[Token(Token = "0x4000176")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9D759C", Offset = "0x9D759C")]
		public Transform[] stretchBones;

		[Token(Token = "0x4000177")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x9D75D4", Offset = "0x9D75D4")]
		public Vector3 chestDirection;

		[Token(Token = "0x4000178")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9D760C", Offset = "0x9D760C")]
		public float chestDirectionWeight;

		[Token(Token = "0x4000179")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public Transform[] chestBones;

		[Token(Token = "0x400017A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public IKSolver.UpdateDelegate OnPostHeadEffectorFK;

		[Token(Token = "0x400017B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Vector3 offset;

		[Token(Token = "0x400017C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		private Vector3 headToBody;

		[Token(Token = "0x400017D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Vector3 shoulderCenterToHead;

		[Token(Token = "0x400017E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		private Vector3 headToLeftThigh;

		[Token(Token = "0x400017F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private Vector3 headToRightThigh;

		[Token(Token = "0x4000180")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		private Vector3 leftShoulderPos;

		[Token(Token = "0x4000181")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private Vector3 rightShoulderPos;

		[Token(Token = "0x4000182")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
		private float shoulderDist;

		[Token(Token = "0x4000183")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private float leftShoulderDist;

		[Token(Token = "0x4000184")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
		private float rightShoulderDist;

		[Token(Token = "0x4000185")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private Quaternion chestRotation;

		[Token(Token = "0x4000186")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private Quaternion headRotationRelativeToRoot;

		[Token(Token = "0x4000187")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private Quaternion[] ccdDefaultLocalRotations;

		[Token(Token = "0x4000188")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private Vector3 headLocalPosition;

		[Token(Token = "0x4000189")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x12C")]
		private Quaternion headLocalRotation;

		[Token(Token = "0x400018A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		private Vector3[] stretchLocalPositions;

		[Token(Token = "0x400018B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		private Quaternion[] stretchLocalRotations;

		[Token(Token = "0x400018C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		private Vector3[] chestLocalPositions;

		[Token(Token = "0x400018D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		private Quaternion[] chestLocalRotations;

		[Token(Token = "0x400018E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		private int bendBonesCount;

		[Token(Token = "0x400018F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x164")]
		private int ccdBonesCount;

		[Token(Token = "0x4000190")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		private int stretchBonesCount;

		[Token(Token = "0x4000191")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x16C")]
		private int chestBonesCount;

		[Token(Token = "0x60002C4")]
		[Address(RVA = "0xF7DC80", Offset = "0xF7DC80", VA = "0xF7DC80")]
		private void Awake()
		{
		}

		[Token(Token = "0x60002C5")]
		[Address(RVA = "0xF7E0DC", Offset = "0xF7E0DC", VA = "0xF7E0DC")]
		private void OnStoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60002C6")]
		[Address(RVA = "0xF7E814", Offset = "0xF7E814", VA = "0xF7E814")]
		private void OnFixTransforms()
		{
		}

		[Token(Token = "0x60002C7")]
		[Address(RVA = "0xF7EE88", Offset = "0xF7EE88", VA = "0xF7EE88")]
		private void OnPreRead()
		{
		}

		[Token(Token = "0x60002C8")]
		[Address(RVA = "0xF7FB5C", Offset = "0xF7FB5C", VA = "0xF7FB5C")]
		private void SpineBend()
		{
		}

		[Token(Token = "0x60002C9")]
		[Address(RVA = "0xF7FFCC", Offset = "0xF7FFCC", VA = "0xF7FFCC")]
		private void CCDPass()
		{
		}

		[Token(Token = "0x60002CA")]
		[Address(RVA = "0xF804AC", Offset = "0xF804AC", VA = "0xF804AC")]
		private void Iterate(int iteration)
		{
		}

		[Token(Token = "0x60002CB")]
		[Address(RVA = "0xF81214", Offset = "0xF81214", VA = "0xF81214")]
		private void OnPostUpdate()
		{
		}

		[Token(Token = "0x60002CC")]
		[Address(RVA = "0xF7F7D0", Offset = "0xF7F7D0", VA = "0xF7F7D0")]
		private void ChestDirection()
		{
		}

		[Token(Token = "0x60002CD")]
		[Address(RVA = "0xF8151C", Offset = "0xF8151C", VA = "0xF8151C")]
		private void PostStretching()
		{
		}

		[Token(Token = "0x60002CE")]
		[Address(RVA = "0xF81094", Offset = "0xF81094", VA = "0xF81094")]
		private void LerpSolverPosition(IKEffector effector, Vector3 position, float weight, Vector3 offset)
		{
		}

		[Token(Token = "0x60002CF")]
		[Address(RVA = "0xF80EF8", Offset = "0xF80EF8", VA = "0xF80EF8")]
		private void Solve(ref Vector3 pos1, ref Vector3 pos2, float nominalDistance)
		{
		}

		[Token(Token = "0x60002D0")]
		[Address(RVA = "0xF81980", Offset = "0xF81980", VA = "0xF81980")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60002D1")]
		[Address(RVA = "0xF81CFC", Offset = "0xF81CFC", VA = "0xF81CFC")]
		public FBBIKHeadEffector()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000048")]
	public class FBIKChain
	{
		[Serializable]
		[Token(Token = "0x2000144")]
		public class ChildConstraint
		{
			[Token(Token = "0x400084B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float pushElasticity;

			[Token(Token = "0x400084C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public float pullElasticity;

			[Token(Token = "0x400084D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[SerializeField]
			private Transform bone1;

			[Token(Token = "0x400084E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[SerializeField]
			private Transform bone2;

			[Token(Token = "0x400084F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DACD0", Offset = "0x9DACD0")]
			private float <nominalDistance>k__BackingField;

			[Token(Token = "0x4000850")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DACE0", Offset = "0x9DACE0")]
			private bool <isRigid>k__BackingField;

			[Token(Token = "0x4000851")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private float crossFade;

			[Token(Token = "0x4000852")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private float inverseCrossFade;

			[Token(Token = "0x4000853")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private int chain1Index;

			[Token(Token = "0x4000854")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private int chain2Index;

			[Token(Token = "0x1700019C")]
			public float nominalDistance
			{
				[Token(Token = "0x60009C1")]
				[Address(RVA = "0xF86668", Offset = "0xF86668", VA = "0xF86668")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E04B4", Offset = "0x9E04B4")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x60009C2")]
				[Address(RVA = "0xF86670", Offset = "0xF86670", VA = "0xF86670")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E04C4", Offset = "0x9E04C4")]
				private set
				{
				}
			}

			[Token(Token = "0x1700019D")]
			public bool isRigid
			{
				[Token(Token = "0x60009C3")]
				[Address(RVA = "0xF86678", Offset = "0xF86678", VA = "0xF86678")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E04D4", Offset = "0x9E04D4")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x60009C4")]
				[Address(RVA = "0xF86680", Offset = "0xF86680", VA = "0xF86680")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E04E4", Offset = "0x9E04E4")]
				private set
				{
				}
			}

			[Token(Token = "0x60009C5")]
			[Address(RVA = "0xF8668C", Offset = "0xF8668C", VA = "0xF8668C")]
			public ChildConstraint(Transform bone1, Transform bone2, float pushElasticity = 0f, float pullElasticity = 0f)
			{
			}

			[Token(Token = "0x60009C6")]
			[Address(RVA = "0xF830F4", Offset = "0xF830F4", VA = "0xF830F4")]
			public void Initiate(IKSolverFullBody solver)
			{
			}

			[Token(Token = "0x60009C7")]
			[Address(RVA = "0xF83A78", Offset = "0xF83A78", VA = "0xF83A78")]
			public void OnPreSolve(IKSolverFullBody solver)
			{
			}

			[Token(Token = "0x60009C8")]
			[Address(RVA = "0xF8621C", Offset = "0xF8621C", VA = "0xF8621C")]
			public void Solve(IKSolverFullBody solver)
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000145")]
		public enum Smoothing
		{
			[Token(Token = "0x4000856")]
			None,
			[Token(Token = "0x4000857")]
			Exponential,
			[Token(Token = "0x4000858")]
			Cubic
		}

		[Token(Token = "0x4000192")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9D7624", Offset = "0x9D7624")]
		public float pin;

		[Token(Token = "0x4000193")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9D763C", Offset = "0x9D763C")]
		public float pull;

		[Token(Token = "0x4000194")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9D7654", Offset = "0x9D7654")]
		public float push;

		[Token(Token = "0x4000195")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9D766C", Offset = "0x9D766C")]
		public float pushParent;

		[Token(Token = "0x4000196")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9D7684", Offset = "0x9D7684")]
		public float reach;

		[Token(Token = "0x4000197")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public Smoothing reachSmoothing;

		[Token(Token = "0x4000198")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Smoothing pushSmoothing;

		[Token(Token = "0x4000199")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public IKSolver.Node[] nodes;

		[Token(Token = "0x400019A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public int[] children;

		[Token(Token = "0x400019B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public ChildConstraint[] childConstraints;

		[Token(Token = "0x400019C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public IKConstraintBend bendConstraint;

		[Token(Token = "0x400019D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private float rootLength;

		[Token(Token = "0x400019E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private bool initiated;

		[Token(Token = "0x400019F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private float length;

		[Token(Token = "0x40001A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private float distance;

		[Token(Token = "0x40001A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private IKSolver.Point p;

		[Token(Token = "0x40001A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private float reachForce;

		[Token(Token = "0x40001A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private float pullParentSum;

		[Token(Token = "0x40001A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private float[] crossFades;

		[Token(Token = "0x40001A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private float sqrMag1;

		[Token(Token = "0x40001A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private float sqrMag2;

		[Token(Token = "0x40001A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private float sqrMagDif;

		[Token(Token = "0x40001A8")]
		private const float maxLimbLength = 0.99999f;

		[Token(Token = "0x60002D2")]
		[Address(RVA = "0xF81F90", Offset = "0xF81F90", VA = "0xF81F90")]
		public FBIKChain()
		{
		}

		[Token(Token = "0x60002D3")]
		[Address(RVA = "0xF8205C", Offset = "0xF8205C", VA = "0xF8205C")]
		public FBIKChain(float pin, float pull, params Transform[] nodeTransforms)
		{
		}

		[Token(Token = "0x60002D4")]
		[Address(RVA = "0xF82168", Offset = "0xF82168", VA = "0xF82168")]
		public void SetNodes(params Transform[] boneTransforms)
		{
		}

		[Token(Token = "0x60002D5")]
		[Address(RVA = "0xF822B8", Offset = "0xF822B8", VA = "0xF822B8")]
		public int GetNodeIndex(Transform boneTransform)
		{
			return default(int);
		}

		[Token(Token = "0x60002D6")]
		[Address(RVA = "0xF823B8", Offset = "0xF823B8", VA = "0xF823B8")]
		public bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60002D7")]
		[Address(RVA = "0xF824D8", Offset = "0xF824D8", VA = "0xF824D8")]
		public void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60002D8")]
		[Address(RVA = "0xF8316C", Offset = "0xF8316C", VA = "0xF8316C")]
		public void ReadPose(IKSolverFullBody solver, bool fullBody)
		{
		}

		[Token(Token = "0x60002D9")]
		[Address(RVA = "0xF8276C", Offset = "0xF8276C", VA = "0xF8276C")]
		private void CalculateBoneLengths(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60002DA")]
		[Address(RVA = "0xF83D58", Offset = "0xF83D58", VA = "0xF83D58")]
		public void Reach(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60002DB")]
		[Address(RVA = "0xF84230", Offset = "0xF84230", VA = "0xF84230")]
		public Vector3 Push(IKSolverFullBody solver)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002DC")]
		[Address(RVA = "0xF84760", Offset = "0xF84760", VA = "0xF84760")]
		public void SolveTrigonometric(IKSolverFullBody solver, bool calculateBendDirection = false)
		{
		}

		[Token(Token = "0x60002DD")]
		[Address(RVA = "0xF84E74", Offset = "0xF84E74", VA = "0xF84E74")]
		public void Stage1(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60002DE")]
		[Address(RVA = "0xF85964", Offset = "0xF85964", VA = "0xF85964")]
		public void Stage2(IKSolverFullBody solver, Vector3 position)
		{
		}

		[Token(Token = "0x60002DF")]
		[Address(RVA = "0xF85E14", Offset = "0xF85E14", VA = "0xF85E14")]
		public void SolveConstraintSystems(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60002E0")]
		[Address(RVA = "0xF8585C", Offset = "0xF8585C", VA = "0xF8585C")]
		private Vector3 SolveFABRIKJoint(Vector3 pos1, Vector3 pos2, float length)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002E1")]
		[Address(RVA = "0xF84C5C", Offset = "0xF84C5C", VA = "0xF84C5C")]
		protected Vector3 GetDirToBendPoint(Vector3 direction, Vector3 bendDirection, float directionMagnitude)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002E2")]
		[Address(RVA = "0xF857B4", Offset = "0xF857B4", VA = "0xF857B4")]
		private void SolveChildConstraints(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60002E3")]
		[Address(RVA = "0xF86038", Offset = "0xF86038", VA = "0xF86038")]
		private void SolveLinearConstraint(IKSolver.Node node1, IKSolver.Node node2, float crossFade, float distance)
		{
		}

		[Token(Token = "0x60002E4")]
		[Address(RVA = "0xF8556C", Offset = "0xF8556C", VA = "0xF8556C")]
		public void ForwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x60002E5")]
		[Address(RVA = "0xF85B88", Offset = "0xF85B88", VA = "0xF85B88")]
		private void BackwardReach(Vector3 position)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000049")]
	public class IKConstraintBend
	{
		[Token(Token = "0x40001A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform bone1;

		[Token(Token = "0x40001AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform bone2;

		[Token(Token = "0x40001AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform bone3;

		[Token(Token = "0x40001AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform bendGoal;

		[Token(Token = "0x40001AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Vector3 direction;

		[Token(Token = "0x40001AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public Quaternion rotationOffset;

		[Token(Token = "0x40001AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9D769C", Offset = "0x9D769C")]
		public float weight;

		[Token(Token = "0x40001B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Vector3 defaultLocalDirection;

		[Token(Token = "0x40001B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public Vector3 defaultChildDirection;

		[NonSerialized]
		[Token(Token = "0x40001B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public float clampF;

		[Token(Token = "0x40001B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private int chainIndex1;

		[Token(Token = "0x40001B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private int nodeIndex1;

		[Token(Token = "0x40001B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private int chainIndex2;

		[Token(Token = "0x40001B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private int nodeIndex2;

		[Token(Token = "0x40001B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private int chainIndex3;

		[Token(Token = "0x40001B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private int nodeIndex3;

		[Token(Token = "0x40001B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9D76B4", Offset = "0x9D76B4")]
		private bool <initiated>k__BackingField;

		[Token(Token = "0x1700006B")]
		public bool initiated
		{
			[Token(Token = "0x60002E7")]
			[Address(RVA = "0x170C218", Offset = "0x170C218", VA = "0x170C218")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DE424", Offset = "0x9DE424")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60002E8")]
			[Address(RVA = "0x170C220", Offset = "0x170C220", VA = "0x170C220")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DE434", Offset = "0x9DE434")]
			private set
			{
			}
		}

		[Token(Token = "0x60002E6")]
		[Address(RVA = "0x170C038", Offset = "0x170C038", VA = "0x170C038")]
		public bool IsValid(IKSolverFullBody solver, Warning.Logger logger)
		{
			return default(bool);
		}

		[Token(Token = "0x60002E9")]
		[Address(RVA = "0x170C22C", Offset = "0x170C22C", VA = "0x170C22C")]
		public IKConstraintBend()
		{
		}

		[Token(Token = "0x60002EA")]
		[Address(RVA = "0x170C2B0", Offset = "0x170C2B0", VA = "0x170C2B0")]
		public IKConstraintBend(Transform bone1, Transform bone2, Transform bone3)
		{
		}

		[Token(Token = "0x60002EB")]
		[Address(RVA = "0x170C35C", Offset = "0x170C35C", VA = "0x170C35C")]
		public void SetBones(Transform bone1, Transform bone2, Transform bone3)
		{
		}

		[Token(Token = "0x60002EC")]
		[Address(RVA = "0x170C368", Offset = "0x170C368", VA = "0x170C368")]
		public void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60002ED")]
		[Address(RVA = "0x170C91C", Offset = "0x170C91C", VA = "0x170C91C")]
		public void SetLimbOrientation(Vector3 upper, Vector3 lower, Vector3 last)
		{
		}

		[Token(Token = "0x60002EE")]
		[Address(RVA = "0x170CB4C", Offset = "0x170CB4C", VA = "0x170CB4C")]
		public void LimitBend(float solverWeight, float positionWeight)
		{
		}

		[Token(Token = "0x60002EF")]
		[Address(RVA = "0x170D0C4", Offset = "0x170D0C4", VA = "0x170D0C4")]
		public Vector3 GetDir(IKSolverFullBody solver)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002F0")]
		[Address(RVA = "0x170C67C", Offset = "0x170C67C", VA = "0x170C67C")]
		private Vector3 OrthoToLimb(IKSolverFullBody solver, Vector3 tangent)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002F1")]
		[Address(RVA = "0x170C7CC", Offset = "0x170C7CC", VA = "0x170C7CC")]
		private Vector3 OrthoToBone1(IKSolverFullBody solver, Vector3 tangent)
		{
			return default(Vector3);
		}
	}
	[Serializable]
	[Token(Token = "0x200004A")]
	public class IKEffector
	{
		[Token(Token = "0x40001BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform bone;

		[Token(Token = "0x40001BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform target;

		[Token(Token = "0x40001BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9D76C4", Offset = "0x9D76C4")]
		public float positionWeight;

		[Token(Token = "0x40001BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9D76DC", Offset = "0x9D76DC")]
		public float rotationWeight;

		[Token(Token = "0x40001BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Vector3 position;

		[Token(Token = "0x40001BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public Quaternion rotation;

		[Token(Token = "0x40001C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public Vector3 positionOffset;

		[Token(Token = "0x40001C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9D76F4", Offset = "0x9D76F4")]
		private bool <isEndEffector>k__BackingField;

		[Token(Token = "0x40001C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x51")]
		public bool effectChildNodes;

		[Token(Token = "0x40001C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9D7704", Offset = "0x9D7704")]
		public float maintainRelativePositionWeight;

		[Token(Token = "0x40001C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform[] childBones;

		[Token(Token = "0x40001C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Transform planeBone1;

		[Token(Token = "0x40001C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Transform planeBone2;

		[Token(Token = "0x40001C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Transform planeBone3;

		[Token(Token = "0x40001C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Quaternion planeRotationOffset;

		[Token(Token = "0x40001C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private float posW;

		[Token(Token = "0x40001CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private float rotW;

		[Token(Token = "0x40001CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Vector3[] localPositions;

		[Token(Token = "0x40001CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private bool usePlaneNodes;

		[Token(Token = "0x40001CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private Quaternion animatedPlaneRotation;

		[Token(Token = "0x40001CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		private Vector3 animatedPosition;

		[Token(Token = "0x40001CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private bool firstUpdate;

		[Token(Token = "0x40001D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		private int chainIndex;

		[Token(Token = "0x40001D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private int nodeIndex;

		[Token(Token = "0x40001D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private int plane1ChainIndex;

		[Token(Token = "0x40001D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private int plane1NodeIndex;

		[Token(Token = "0x40001D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		private int plane2ChainIndex;

		[Token(Token = "0x40001D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private int plane2NodeIndex;

		[Token(Token = "0x40001D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		private int plane3ChainIndex;

		[Token(Token = "0x40001D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private int plane3NodeIndex;

		[Token(Token = "0x40001D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private int[] childChainIndexes;

		[Token(Token = "0x40001D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private int[] childNodeIndexes;

		[Token(Token = "0x1700006C")]
		public bool isEndEffector
		{
			[Token(Token = "0x60002F3")]
			[Address(RVA = "0x170D7EC", Offset = "0x170D7EC", VA = "0x170D7EC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DE444", Offset = "0x9DE444")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60002F4")]
			[Address(RVA = "0x170D7F4", Offset = "0x170D7F4", VA = "0x170D7F4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DE454", Offset = "0x9DE454")]
			private set
			{
			}
		}

		[Token(Token = "0x60002F2")]
		[Address(RVA = "0x170D73C", Offset = "0x170D73C", VA = "0x170D73C")]
		public IKSolver.Node GetNode(IKSolverFullBody solver)
		{
			return null;
		}

		[Token(Token = "0x60002F5")]
		[Address(RVA = "0x170D800", Offset = "0x170D800", VA = "0x170D800")]
		public void PinToBone(float positionWeight, float rotationWeight)
		{
		}

		[Token(Token = "0x60002F6")]
		[Address(RVA = "0x170D8E8", Offset = "0x170D8E8", VA = "0x170D8E8")]
		public IKEffector()
		{
		}

		[Token(Token = "0x60002F7")]
		[Address(RVA = "0x170DA24", Offset = "0x170DA24", VA = "0x170DA24")]
		public IKEffector(Transform bone, Transform[] childBones)
		{
		}

		[Token(Token = "0x60002F8")]
		[Address(RVA = "0x170DB7C", Offset = "0x170DB7C", VA = "0x170DB7C")]
		public bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60002F9")]
		[Address(RVA = "0x170DED4", Offset = "0x170DED4", VA = "0x170DED4")]
		public void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60002FA")]
		[Address(RVA = "0x170E284", Offset = "0x170E284", VA = "0x170E284")]
		public void ResetOffset(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60002FB")]
		[Address(RVA = "0x170E460", Offset = "0x170E460", VA = "0x170E460")]
		public void SetToTarget()
		{
		}

		[Token(Token = "0x60002FC")]
		[Address(RVA = "0x170E520", Offset = "0x170E520", VA = "0x170E520")]
		public void OnPreSolve(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60002FD")]
		[Address(RVA = "0x170ED24", Offset = "0x170ED24", VA = "0x170ED24")]
		public void OnPostWrite()
		{
		}

		[Token(Token = "0x60002FE")]
		[Address(RVA = "0x170ED94", Offset = "0x170ED94", VA = "0x170ED94")]
		private Quaternion GetPlaneRotation(IKSolverFullBody solver)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60002FF")]
		[Address(RVA = "0x170F000", Offset = "0x170F000", VA = "0x170F000")]
		public void Update(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000300")]
		[Address(RVA = "0x170F470", Offset = "0x170F470", VA = "0x170F470")]
		private Vector3 GetPosition(IKSolverFullBody solver, out Quaternion planeRotationOffset)
		{
			return default(Vector3);
		}
	}
	[Serializable]
	[Token(Token = "0x200004B")]
	public class IKMapping
	{
		[Serializable]
		[Token(Token = "0x2000146")]
		public class BoneMap
		{
			[Token(Token = "0x4000859")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform transform;

			[Token(Token = "0x400085A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public int chainIndex;

			[Token(Token = "0x400085B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public int nodeIndex;

			[Token(Token = "0x400085C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Vector3 defaultLocalPosition;

			[Token(Token = "0x400085D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public Quaternion defaultLocalRotation;

			[Token(Token = "0x400085E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public Vector3 localSwingAxis;

			[Token(Token = "0x400085F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public Vector3 localTwistAxis;

			[Token(Token = "0x4000860")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			public Vector3 planePosition;

			[Token(Token = "0x4000861")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			public Vector3 ikPosition;

			[Token(Token = "0x4000862")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
			public Quaternion defaultLocalTargetRotation;

			[Token(Token = "0x4000863")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
			private Quaternion maintainRotation;

			[Token(Token = "0x4000864")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
			public float length;

			[Token(Token = "0x4000865")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			public Quaternion animatedRotation;

			[Token(Token = "0x4000866")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			private Transform planeBone1;

			[Token(Token = "0x4000867")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
			private Transform planeBone2;

			[Token(Token = "0x4000868")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
			private Transform planeBone3;

			[Token(Token = "0x4000869")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
			private int plane1ChainIndex;

			[Token(Token = "0x400086A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
			private int plane1NodeIndex;

			[Token(Token = "0x400086B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
			private int plane2ChainIndex;

			[Token(Token = "0x400086C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
			private int plane2NodeIndex;

			[Token(Token = "0x400086D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
			private int plane3ChainIndex;

			[Token(Token = "0x400086E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
			private int plane3NodeIndex;

			[Token(Token = "0x1700019E")]
			public Vector3 swingDirection
			{
				[Token(Token = "0x60009CA")]
				[Address(RVA = "0x170FBDC", Offset = "0x170FBDC", VA = "0x170FBDC")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x1700019F")]
			public bool isNodeBone
			{
				[Token(Token = "0x60009CD")]
				[Address(RVA = "0x170FDA4", Offset = "0x170FDA4", VA = "0x170FDA4")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x170001A0")]
			private Quaternion lastAnimatedTargetRotation
			{
				[Token(Token = "0x60009E1")]
				[Address(RVA = "0x171045C", Offset = "0x171045C", VA = "0x171045C")]
				get
				{
					return default(Quaternion);
				}
			}

			[Token(Token = "0x60009C9")]
			[Address(RVA = "0x170FB88", Offset = "0x170FB88", VA = "0x170FB88")]
			public void Initiate(Transform transform, IKSolverFullBody solver)
			{
			}

			[Token(Token = "0x60009CB")]
			[Address(RVA = "0x170FCB0", Offset = "0x170FCB0", VA = "0x170FCB0")]
			public void StoreDefaultLocalState()
			{
			}

			[Token(Token = "0x60009CC")]
			[Address(RVA = "0x170FD14", Offset = "0x170FD14", VA = "0x170FD14")]
			public void FixTransform(bool position)
			{
			}

			[Token(Token = "0x60009CE")]
			[Address(RVA = "0x170FDB4", Offset = "0x170FDB4", VA = "0x170FDB4")]
			public void SetLength(BoneMap nextBone)
			{
			}

			[Token(Token = "0x60009CF")]
			[Address(RVA = "0x170FEB8", Offset = "0x170FEB8", VA = "0x170FEB8")]
			public void SetLocalSwingAxis(BoneMap swingTarget)
			{
			}

			[Token(Token = "0x60009D0")]
			[Address(RVA = "0x170FEC0", Offset = "0x170FEC0", VA = "0x170FEC0")]
			public void SetLocalSwingAxis(BoneMap bone1, BoneMap bone2)
			{
			}

			[Token(Token = "0x60009D1")]
			[Address(RVA = "0x1710078", Offset = "0x1710078", VA = "0x1710078")]
			public void SetLocalTwistAxis(Vector3 twistDirection, Vector3 normalDirection)
			{
			}

			[Token(Token = "0x60009D2")]
			[Address(RVA = "0x171018C", Offset = "0x171018C", VA = "0x171018C")]
			public void SetPlane(IKSolverFullBody solver, Transform planeBone1, Transform planeBone2, Transform planeBone3)
			{
			}

			[Token(Token = "0x60009D3")]
			[Address(RVA = "0x171028C", Offset = "0x171028C", VA = "0x171028C")]
			public void UpdatePlane(bool rotation, bool position)
			{
			}

			[Token(Token = "0x60009D4")]
			[Address(RVA = "0x17106D0", Offset = "0x17106D0", VA = "0x17106D0")]
			public void SetIKPosition()
			{
			}

			[Token(Token = "0x60009D5")]
			[Address(RVA = "0x1710710", Offset = "0x1710710", VA = "0x1710710")]
			public void MaintainRotation()
			{
			}

			[Token(Token = "0x60009D6")]
			[Address(RVA = "0x1710750", Offset = "0x1710750", VA = "0x1710750")]
			public void SetToIKPosition()
			{
			}

			[Token(Token = "0x60009D7")]
			[Address(RVA = "0x17107A4", Offset = "0x17107A4", VA = "0x17107A4")]
			public void FixToNode(IKSolverFullBody solver, float weight, [Optional] IKSolver.Node fixNode)
			{
			}

			[Token(Token = "0x60009D8")]
			[Address(RVA = "0x1710918", Offset = "0x1710918", VA = "0x1710918")]
			public Vector3 GetPlanePosition(IKSolverFullBody solver)
			{
				return default(Vector3);
			}

			[Token(Token = "0x60009D9")]
			[Address(RVA = "0x1710CD8", Offset = "0x1710CD8", VA = "0x1710CD8")]
			public void PositionToPlane(IKSolverFullBody solver)
			{
			}

			[Token(Token = "0x60009DA")]
			[Address(RVA = "0x1710D34", Offset = "0x1710D34", VA = "0x1710D34")]
			public void RotateToPlane(IKSolverFullBody solver, float weight)
			{
			}

			[Token(Token = "0x60009DB")]
			[Address(RVA = "0x1710F04", Offset = "0x1710F04", VA = "0x1710F04")]
			public void Swing(Vector3 swingTarget, float weight)
			{
			}

			[Token(Token = "0x60009DC")]
			[Address(RVA = "0x1710F7C", Offset = "0x1710F7C", VA = "0x1710F7C")]
			public void Swing(Vector3 pos1, Vector3 pos2, float weight)
			{
			}

			[Token(Token = "0x60009DD")]
			[Address(RVA = "0x1711218", Offset = "0x1711218", VA = "0x1711218")]
			public void Twist(Vector3 twistDirection, Vector3 normalDirection, float weight)
			{
			}

			[Token(Token = "0x60009DE")]
			[Address(RVA = "0x1711498", Offset = "0x1711498", VA = "0x1711498")]
			public void RotateToMaintain(float weight)
			{
			}

			[Token(Token = "0x60009DF")]
			[Address(RVA = "0x17115E0", Offset = "0x17115E0", VA = "0x17115E0")]
			public void RotateToEffector(IKSolverFullBody solver, float weight)
			{
			}

			[Token(Token = "0x60009E0")]
			[Address(RVA = "0x1710A7C", Offset = "0x1710A7C", VA = "0x1710A7C")]
			private Quaternion GetTargetRotation(IKSolverFullBody solver)
			{
				return default(Quaternion);
			}

			[Token(Token = "0x60009E2")]
			[Address(RVA = "0x1711800", Offset = "0x1711800", VA = "0x1711800")]
			public BoneMap()
			{
			}
		}

		[Token(Token = "0x6000301")]
		[Address(RVA = "0x170F934", Offset = "0x170F934", VA = "0x170F934", Slot = "4")]
		public virtual bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000302")]
		[Address(RVA = "0x170F93C", Offset = "0x170F93C", VA = "0x170F93C", Slot = "5")]
		public virtual void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000303")]
		[Address(RVA = "0x170F940", Offset = "0x170F940", VA = "0x170F940")]
		protected bool BoneIsValid(Transform bone, IKSolver solver, ref string message, [Optional] Warning.Logger logger)
		{
			return default(bool);
		}

		[Token(Token = "0x6000304")]
		[Address(RVA = "0x170FA78", Offset = "0x170FA78", VA = "0x170FA78")]
		protected Vector3 SolveFABRIKJoint(Vector3 pos1, Vector3 pos2, float length)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000305")]
		[Address(RVA = "0x170FB80", Offset = "0x170FB80", VA = "0x170FB80")]
		public IKMapping()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200004C")]
	public class IKMappingBone : IKMapping
	{
		[Token(Token = "0x40001DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform bone;

		[Token(Token = "0x40001DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9D771C", Offset = "0x9D771C")]
		public float maintainRotationWeight;

		[Token(Token = "0x40001DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private BoneMap boneMap;

		[Token(Token = "0x6000306")]
		[Address(RVA = "0x1711818", Offset = "0x1711818", VA = "0x1711818", Slot = "4")]
		public override bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000307")]
		[Address(RVA = "0x17118B8", Offset = "0x17118B8", VA = "0x17118B8")]
		public IKMappingBone()
		{
		}

		[Token(Token = "0x6000308")]
		[Address(RVA = "0x171193C", Offset = "0x171193C", VA = "0x171193C")]
		public IKMappingBone(Transform bone)
		{
		}

		[Token(Token = "0x6000309")]
		[Address(RVA = "0x17119D4", Offset = "0x17119D4", VA = "0x17119D4")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x600030A")]
		[Address(RVA = "0x1711A00", Offset = "0x1711A00", VA = "0x1711A00")]
		public void FixTransforms()
		{
		}

		[Token(Token = "0x600030B")]
		[Address(RVA = "0x1711A30", Offset = "0x1711A30", VA = "0x1711A30", Slot = "5")]
		public override void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x600030C")]
		[Address(RVA = "0x1711ADC", Offset = "0x1711ADC", VA = "0x1711ADC")]
		public void ReadPose()
		{
		}

		[Token(Token = "0x600030D")]
		[Address(RVA = "0x1711B08", Offset = "0x1711B08", VA = "0x1711B08")]
		public void WritePose(float solverWeight)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200004D")]
	public class IKMappingLimb : IKMapping
	{
		[Serializable]
		[Token(Token = "0x2000147")]
		public enum BoneMapType
		{
			[Token(Token = "0x4000870")]
			Parent,
			[Token(Token = "0x4000871")]
			Bone1,
			[Token(Token = "0x4000872")]
			Bone2,
			[Token(Token = "0x4000873")]
			Bone3
		}

		[Token(Token = "0x40001DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform parentBone;

		[Token(Token = "0x40001DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform bone1;

		[Token(Token = "0x40001DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform bone2;

		[Token(Token = "0x40001E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform bone3;

		[Token(Token = "0x40001E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9D7734", Offset = "0x9D7734")]
		public float maintainRotationWeight;

		[Token(Token = "0x40001E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9D774C", Offset = "0x9D774C")]
		public float weight;

		[Token(Token = "0x40001E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private BoneMap boneMapParent;

		[Token(Token = "0x40001E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private BoneMap boneMap1;

		[Token(Token = "0x40001E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private BoneMap boneMap2;

		[Token(Token = "0x40001E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private BoneMap boneMap3;

		[Token(Token = "0x600030E")]
		[Address(RVA = "0x1711B48", Offset = "0x1711B48", VA = "0x1711B48", Slot = "4")]
		public override bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x600030F")]
		[Address(RVA = "0x1711BCC", Offset = "0x1711BCC", VA = "0x1711BCC")]
		public BoneMap GetBoneMap(BoneMapType boneMap)
		{
			return null;
		}

		[Token(Token = "0x6000310")]
		[Address(RVA = "0x1711CA0", Offset = "0x1711CA0", VA = "0x1711CA0")]
		public void SetLimbOrientation(Vector3 upper, Vector3 lower)
		{
		}

		[Token(Token = "0x6000311")]
		[Address(RVA = "0x1712070", Offset = "0x1712070", VA = "0x1712070")]
		public IKMappingLimb()
		{
		}

		[Token(Token = "0x6000312")]
		[Address(RVA = "0x1712170", Offset = "0x1712170", VA = "0x1712170")]
		public IKMappingLimb(Transform bone1, Transform bone2, Transform bone3, [Optional] Transform parentBone)
		{
		}

		[Token(Token = "0x6000313")]
		[Address(RVA = "0x171229C", Offset = "0x171229C", VA = "0x171229C")]
		public void SetBones(Transform bone1, Transform bone2, Transform bone3, [Optional] Transform parentBone)
		{
		}

		[Token(Token = "0x6000314")]
		[Address(RVA = "0x17122A8", Offset = "0x17122A8", VA = "0x17122A8")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000315")]
		[Address(RVA = "0x171237C", Offset = "0x171237C", VA = "0x171237C")]
		public void FixTransforms()
		{
		}

		[Token(Token = "0x6000316")]
		[Address(RVA = "0x1712460", Offset = "0x1712460", VA = "0x1712460", Slot = "5")]
		public override void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000317")]
		[Address(RVA = "0x171277C", Offset = "0x171277C", VA = "0x171277C")]
		public void ReadPose()
		{
		}

		[Token(Token = "0x6000318")]
		[Address(RVA = "0x1712854", Offset = "0x1712854", VA = "0x1712854")]
		public void WritePose(IKSolverFullBody solver, bool fullBody)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200004E")]
	public class IKMappingSpine : IKMapping
	{
		[Token(Token = "0x40001E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform[] spineBones;

		[Token(Token = "0x40001E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform leftUpperArmBone;

		[Token(Token = "0x40001E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform rightUpperArmBone;

		[Token(Token = "0x40001EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform leftThighBone;

		[Token(Token = "0x40001EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Transform rightThighBone;

		[Token(Token = "0x40001EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9D7764", Offset = "0x9D7764")]
		public int iterations;

		[Token(Token = "0x40001ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9D777C", Offset = "0x9D777C")]
		public float twistWeight;

		[Token(Token = "0x40001EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private int rootNodeIndex;

		[Token(Token = "0x40001EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private BoneMap[] spine;

		[Token(Token = "0x40001F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private BoneMap leftUpperArm;

		[Token(Token = "0x40001F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private BoneMap rightUpperArm;

		[Token(Token = "0x40001F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private BoneMap leftThigh;

		[Token(Token = "0x40001F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private BoneMap rightThigh;

		[Token(Token = "0x40001F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private bool useFABRIK;

		[Token(Token = "0x6000319")]
		[Address(RVA = "0x1712A44", Offset = "0x1712A44", VA = "0x1712A44", Slot = "4")]
		public override bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x600031A")]
		[Address(RVA = "0x1712D68", Offset = "0x1712D68", VA = "0x1712D68")]
		public IKMappingSpine()
		{
		}

		[Token(Token = "0x600031B")]
		[Address(RVA = "0x1712E84", Offset = "0x1712E84", VA = "0x1712E84")]
		public IKMappingSpine(Transform[] spineBones, Transform leftUpperArmBone, Transform rightUpperArmBone, Transform leftThighBone, Transform rightThighBone)
		{
		}

		[Token(Token = "0x600031C")]
		[Address(RVA = "0x1712FD4", Offset = "0x1712FD4", VA = "0x1712FD4")]
		public void SetBones(Transform[] spineBones, Transform leftUpperArmBone, Transform rightUpperArmBone, Transform leftThighBone, Transform rightThighBone)
		{
		}

		[Token(Token = "0x600031D")]
		[Address(RVA = "0x1712FE4", Offset = "0x1712FE4", VA = "0x1712FE4")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x600031E")]
		[Address(RVA = "0x171307C", Offset = "0x171307C", VA = "0x171307C")]
		public void FixTransforms()
		{
		}

		[Token(Token = "0x600031F")]
		[Address(RVA = "0x171314C", Offset = "0x171314C", VA = "0x171314C", Slot = "5")]
		public override void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000320")]
		[Address(RVA = "0x1713B70", Offset = "0x1713B70", VA = "0x1713B70")]
		private bool UseFABRIK()
		{
			return default(bool);
		}

		[Token(Token = "0x6000321")]
		[Address(RVA = "0x1713BBC", Offset = "0x1713BBC", VA = "0x1713BBC")]
		public void ReadPose()
		{
		}

		[Token(Token = "0x6000322")]
		[Address(RVA = "0x17140A0", Offset = "0x17140A0", VA = "0x17140A0")]
		public void WritePose(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000323")]
		[Address(RVA = "0x17146E4", Offset = "0x17146E4", VA = "0x17146E4")]
		public void ForwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x6000324")]
		[Address(RVA = "0x1714940", Offset = "0x1714940", VA = "0x1714940")]
		private void BackwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x6000325")]
		[Address(RVA = "0x1714B54", Offset = "0x1714B54", VA = "0x1714B54")]
		private void MapToSolverPositions(IKSolverFullBody solver)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200004F")]
	public abstract class IKSolver
	{
		[Serializable]
		[Token(Token = "0x2000148")]
		public class Point
		{
			[Token(Token = "0x4000874")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform transform;

			[Token(Token = "0x4000875")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9DACF0", Offset = "0x9DACF0")]
			public float weight;

			[Token(Token = "0x4000876")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public Vector3 solverPosition;

			[Token(Token = "0x4000877")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Quaternion solverRotation;

			[Token(Token = "0x4000878")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Vector3 defaultLocalPosition;

			[Token(Token = "0x4000879")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			public Quaternion defaultLocalRotation;

			[Token(Token = "0x60009E3")]
			[Address(RVA = "0x1716E20", Offset = "0x1716E20", VA = "0x1716E20")]
			public void StoreDefaultLocalState()
			{
			}

			[Token(Token = "0x60009E4")]
			[Address(RVA = "0x1716E84", Offset = "0x1716E84", VA = "0x1716E84")]
			public void FixTransform()
			{
			}

			[Token(Token = "0x60009E5")]
			[Address(RVA = "0x1717054", Offset = "0x1717054", VA = "0x1717054")]
			public void UpdateSolverPosition()
			{
			}

			[Token(Token = "0x60009E6")]
			[Address(RVA = "0x1717094", Offset = "0x1717094", VA = "0x1717094")]
			public void UpdateSolverLocalPosition()
			{
			}

			[Token(Token = "0x60009E7")]
			[Address(RVA = "0x17170D4", Offset = "0x17170D4", VA = "0x17170D4")]
			public void UpdateSolverState()
			{
			}

			[Token(Token = "0x60009E8")]
			[Address(RVA = "0x1717138", Offset = "0x1717138", VA = "0x1717138")]
			public void UpdateSolverLocalState()
			{
			}

			[Token(Token = "0x60009E9")]
			[Address(RVA = "0x1716910", Offset = "0x1716910", VA = "0x1716910")]
			public Point()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000149")]
		public class Bone : Point
		{
			[Token(Token = "0x400087A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			public float length;

			[Token(Token = "0x400087B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public float sqrMag;

			[Token(Token = "0x400087C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			public Vector3 axis;

			[Token(Token = "0x400087D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			private RotationLimit _rotationLimit;

			[Token(Token = "0x400087E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			private bool isLimited;

			[Token(Token = "0x170001A1")]
			public RotationLimit rotationLimit
			{
				[Token(Token = "0x60009EA")]
				[Address(RVA = "0x1715D04", Offset = "0x1715D04", VA = "0x1715D04")]
				get
				{
					return null;
				}
				[Token(Token = "0x60009EB")]
				[Address(RVA = "0x1715E00", Offset = "0x1715E00", VA = "0x1715E00")]
				set
				{
				}
			}

			[Token(Token = "0x60009EC")]
			[Address(RVA = "0x1715E88", Offset = "0x1715E88", VA = "0x1715E88")]
			public void Swing(Vector3 swingTarget, float weight = 1f)
			{
			}

			[Token(Token = "0x60009ED")]
			[Address(RVA = "0x1716190", Offset = "0x1716190", VA = "0x1716190")]
			public static void SolverSwing(Bone[] bones, int index, Vector3 swingTarget, float weight = 1f)
			{
			}

			[Token(Token = "0x60009EE")]
			[Address(RVA = "0x1716588", Offset = "0x1716588", VA = "0x1716588")]
			public void Swing2D(Vector3 swingTarget, float weight = 1f)
			{
			}

			[Token(Token = "0x60009EF")]
			[Address(RVA = "0x1716838", Offset = "0x1716838", VA = "0x1716838")]
			public void SetToSolverPosition()
			{
			}

			[Token(Token = "0x60009F0")]
			[Address(RVA = "0x171688C", Offset = "0x171688C", VA = "0x171688C")]
			public Bone()
			{
			}

			[Token(Token = "0x60009F1")]
			[Address(RVA = "0x1716990", Offset = "0x1716990", VA = "0x1716990")]
			public Bone(Transform transform)
			{
			}

			[Token(Token = "0x60009F2")]
			[Address(RVA = "0x1716A28", Offset = "0x1716A28", VA = "0x1716A28")]
			public Bone(Transform transform, float weight)
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200014A")]
		public class Node : Point
		{
			[Token(Token = "0x400087F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			public float length;

			[Token(Token = "0x4000880")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public float effectorPositionWeight;

			[Token(Token = "0x4000881")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			public float effectorRotationWeight;

			[Token(Token = "0x4000882")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			public Vector3 offset;

			[Token(Token = "0x60009F3")]
			[Address(RVA = "0x1716DBC", Offset = "0x1716DBC", VA = "0x1716DBC")]
			public Node()
			{
			}

			[Token(Token = "0x60009F4")]
			[Address(RVA = "0x1716DC0", Offset = "0x1716DC0", VA = "0x1716DC0")]
			public Node(Transform transform)
			{
			}

			[Token(Token = "0x60009F5")]
			[Address(RVA = "0x1716DE8", Offset = "0x1716DE8", VA = "0x1716DE8")]
			public Node(Transform transform, float weight)
			{
			}
		}

		[Token(Token = "0x200014B")]
		public delegate void UpdateDelegate();

		[Token(Token = "0x200014C")]
		public delegate void IterationDelegate(int i);

		[Token(Token = "0x40001F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[HideInInspector]
		public Vector3 IKPosition;

		[Token(Token = "0x40001F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9D77A4", Offset = "0x9D77A4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9D77A4", Offset = "0x9D77A4")]
		public float IKPositionWeight;

		[Token(Token = "0x40001F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9D77F8", Offset = "0x9D77F8")]
		private bool <initiated>k__BackingField;

		[Token(Token = "0x40001F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public UpdateDelegate OnPreInitiate;

		[Token(Token = "0x40001F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public UpdateDelegate OnPostInitiate;

		[Token(Token = "0x40001FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public UpdateDelegate OnPreUpdate;

		[Token(Token = "0x40001FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public UpdateDelegate OnPostUpdate;

		[Token(Token = "0x40001FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		protected bool firstInitiation;

		[Token(Token = "0x40001FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		[HideInInspector]
		protected Transform root;

		[Token(Token = "0x1700006D")]
		public bool initiated
		{
			[Token(Token = "0x600032F")]
			[Address(RVA = "0x16FF2C0", Offset = "0x16FF2C0", VA = "0x16FF2C0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DE464", Offset = "0x9DE464")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000330")]
			[Address(RVA = "0x1715300", Offset = "0x1715300", VA = "0x1715300")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DE474", Offset = "0x9DE474")]
			private set
			{
			}
		}

		[Token(Token = "0x6000326")]
		[Address(RVA = "0x1715068", Offset = "0x1715068", VA = "0x1715068")]
		public bool IsValid()
		{
			return default(bool);
		}

		[Token(Token = "0x6000327")]
		public abstract bool IsValid(ref string message);

		[Token(Token = "0x6000328")]
		[Address(RVA = "0x170BE7C", Offset = "0x170BE7C", VA = "0x170BE7C")]
		public void Initiate(Transform root)
		{
		}

		[Token(Token = "0x6000329")]
		[Address(RVA = "0x170BD94", Offset = "0x170BD94", VA = "0x170BD94")]
		public void Update()
		{
		}

		[Token(Token = "0x600032A")]
		[Address(RVA = "0x171530C", Offset = "0x171530C", VA = "0x171530C", Slot = "5")]
		public virtual Vector3 GetIKPosition()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600032B")]
		[Address(RVA = "0x1715318", Offset = "0x1715318", VA = "0x1715318")]
		public void SetIKPosition(Vector3 position)
		{
		}

		[Token(Token = "0x600032C")]
		[Address(RVA = "0x1715324", Offset = "0x1715324", VA = "0x1715324")]
		public float GetIKPositionWeight()
		{
			return default(float);
		}

		[Token(Token = "0x600032D")]
		[Address(RVA = "0x171532C", Offset = "0x171532C", VA = "0x171532C")]
		public void SetIKPositionWeight(float weight)
		{
		}

		[Token(Token = "0x600032E")]
		[Address(RVA = "0x170A5FC", Offset = "0x170A5FC", VA = "0x170A5FC")]
		public Transform GetRoot()
		{
			return null;
		}

		[Token(Token = "0x6000331")]
		public abstract Point[] GetPoints();

		[Token(Token = "0x6000332")]
		public abstract Point GetPoint(Transform transform);

		[Token(Token = "0x6000333")]
		public abstract void FixTransforms();

		[Token(Token = "0x6000334")]
		public abstract void StoreDefaultLocalState();

		[Token(Token = "0x6000335")]
		protected abstract void OnInitiate();

		[Token(Token = "0x6000336")]
		protected abstract void OnUpdate();

		[Token(Token = "0x6000337")]
		[Address(RVA = "0x17153B0", Offset = "0x17153B0", VA = "0x17153B0")]
		protected void LogWarning(string message)
		{
		}

		[Token(Token = "0x6000338")]
		[Address(RVA = "0x17153C8", Offset = "0x17153C8", VA = "0x17153C8")]
		public static Transform ContainsDuplicateBone(Bone[] bones)
		{
			return null;
		}

		[Token(Token = "0x6000339")]
		[Address(RVA = "0x1715544", Offset = "0x1715544", VA = "0x1715544")]
		public static bool HierarchyIsValid(Bone[] bones)
		{
			return default(bool);
		}

		[Token(Token = "0x600033A")]
		[Address(RVA = "0x1715618", Offset = "0x1715618", VA = "0x1715618")]
		protected static float PreSolveBones(ref Bone[] bones)
		{
			return default(float);
		}

		[Token(Token = "0x600033B")]
		[Address(RVA = "0x1715CEC", Offset = "0x1715CEC", VA = "0x1715CEC")]
		protected IKSolver()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000050")]
	public class IKSolverAim : IKSolverHeuristic
	{
		[Token(Token = "0x40001FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public Transform transform;

		[Token(Token = "0x40001FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public Vector3 axis;

		[Token(Token = "0x4000200")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		public Vector3 poleAxis;

		[Token(Token = "0x4000201")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public Vector3 polePosition;

		[Token(Token = "0x4000202")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9D7840", Offset = "0x9D7840")]
		public float poleWeight;

		[Token(Token = "0x4000203")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public Transform poleTarget;

		[Token(Token = "0x4000204")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9D7858", Offset = "0x9D7858")]
		public float clampWeight;

		[Token(Token = "0x4000205")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9D7870", Offset = "0x9D7870")]
		public int clampSmoothing;

		[Token(Token = "0x4000206")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public IterationDelegate OnPreIteration;

		[Token(Token = "0x4000207")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private float step;

		[Token(Token = "0x4000208")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		private Vector3 clampedIKPosition;

		[Token(Token = "0x4000209")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private RotationLimit transformLimit;

		[Token(Token = "0x400020A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private Transform lastTransform;

		[Token(Token = "0x1700006E")]
		public Vector3 transformAxis
		{
			[Token(Token = "0x600033D")]
			[Address(RVA = "0x17172E4", Offset = "0x17172E4", VA = "0x17172E4")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x1700006F")]
		public Vector3 transformPoleAxis
		{
			[Token(Token = "0x600033E")]
			[Address(RVA = "0x17173B8", Offset = "0x17173B8", VA = "0x17173B8")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000070")]
		protected override int minBones
		{
			[Token(Token = "0x6000341")]
			[Address(RVA = "0x17183A4", Offset = "0x17183A4", VA = "0x17183A4", Slot = "12")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000071")]
		protected override Vector3 localDirection
		{
			[Token(Token = "0x6000345")]
			[Address(RVA = "0x1718A34", Offset = "0x1718A34", VA = "0x1718A34", Slot = "15")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x600033C")]
		[Address(RVA = "0x17171DC", Offset = "0x17171DC", VA = "0x17171DC")]
		public float GetAngle()
		{
			return default(float);
		}

		[Token(Token = "0x600033F")]
		[Address(RVA = "0x171748C", Offset = "0x171748C", VA = "0x171748C", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000340")]
		[Address(RVA = "0x1717794", Offset = "0x1717794", VA = "0x1717794", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000342")]
		[Address(RVA = "0x17181C8", Offset = "0x17181C8", VA = "0x17181C8")]
		private void Solve()
		{
		}

		[Token(Token = "0x6000343")]
		[Address(RVA = "0x1717DA0", Offset = "0x1717DA0", VA = "0x1717DA0")]
		private Vector3 GetClampedIKPosition()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000344")]
		[Address(RVA = "0x17183AC", Offset = "0x17183AC", VA = "0x17183AC")]
		private void RotateToTarget(Vector3 targetPosition, Bone bone, float weight)
		{
		}

		[Token(Token = "0x6000346")]
		[Address(RVA = "0x1718B3C", Offset = "0x1718B3C", VA = "0x1718B3C")]
		public IKSolverAim()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000051")]
	public class IKSolverCCD : IKSolverHeuristic
	{
		[Token(Token = "0x400020B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public IterationDelegate OnPreIteration;

		[Token(Token = "0x6000347")]
		[Address(RVA = "0x1718BD4", Offset = "0x1718BD4", VA = "0x1718BD4")]
		public void FadeOutBoneWeights()
		{
		}

		[Token(Token = "0x6000348")]
		[Address(RVA = "0x1718D2C", Offset = "0x1718D2C", VA = "0x1718D2C", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000349")]
		[Address(RVA = "0x1718DE0", Offset = "0x1718DE0", VA = "0x1718DE0", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x600034A")]
		[Address(RVA = "0x1719138", Offset = "0x1719138", VA = "0x1719138")]
		private void Solve(Vector3 targetPosition)
		{
		}

		[Token(Token = "0x600034B")]
		[Address(RVA = "0x1719C04", Offset = "0x1719C04", VA = "0x1719C04")]
		public IKSolverCCD()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000052")]
	public class IKSolverFABRIK : IKSolverHeuristic
	{
		[Token(Token = "0x400020C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public IterationDelegate OnPreIteration;

		[Token(Token = "0x400020D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private bool[] limitedBones;

		[Token(Token = "0x400020E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Vector3[] solverLocalPositions;

		[Token(Token = "0x17000072")]
		protected override bool boneLengthCanBeZero
		{
			[Token(Token = "0x6000351")]
			[Address(RVA = "0x171B60C", Offset = "0x171B60C", VA = "0x171B60C", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600034C")]
		[Address(RVA = "0x1719C0C", Offset = "0x1719C0C", VA = "0x1719C0C")]
		public void SolveForward(Vector3 position)
		{
		}

		[Token(Token = "0x600034D")]
		[Address(RVA = "0x171A824", Offset = "0x171A824", VA = "0x171A824")]
		public void SolveBackward(Vector3 position)
		{
		}

		[Token(Token = "0x600034E")]
		[Address(RVA = "0x171A95C", Offset = "0x171A95C", VA = "0x171A95C", Slot = "5")]
		public override Vector3 GetIKPosition()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600034F")]
		[Address(RVA = "0x171AA00", Offset = "0x171AA00", VA = "0x171AA00", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000350")]
		[Address(RVA = "0x171B25C", Offset = "0x171B25C", VA = "0x171B25C", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000352")]
		[Address(RVA = "0x171B614", Offset = "0x171B614", VA = "0x171B614")]
		private Vector3 SolveJoint(Vector3 pos1, Vector3 pos2, float length)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000353")]
		[Address(RVA = "0x1719CE0", Offset = "0x1719CE0", VA = "0x1719CE0")]
		private void OnPreSolve()
		{
		}

		[Token(Token = "0x6000354")]
		[Address(RVA = "0x171A908", Offset = "0x171A908", VA = "0x171A908")]
		private void OnPostSolve()
		{
		}

		[Token(Token = "0x6000355")]
		[Address(RVA = "0x171B594", Offset = "0x171B594", VA = "0x171B594")]
		private void Solve(Vector3 targetPosition)
		{
		}

		[Token(Token = "0x6000356")]
		[Address(RVA = "0x171A478", Offset = "0x171A478", VA = "0x171A478")]
		private void ForwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x6000357")]
		[Address(RVA = "0x171C2D8", Offset = "0x171C2D8", VA = "0x171C2D8")]
		private void SolverMove(int index, Vector3 offset)
		{
		}

		[Token(Token = "0x6000358")]
		[Address(RVA = "0x171C400", Offset = "0x171C400", VA = "0x171C400")]
		private void SolverRotate(int index, Quaternion rotation, bool recursive)
		{
		}

		[Token(Token = "0x6000359")]
		[Address(RVA = "0x171C598", Offset = "0x171C598", VA = "0x171C598")]
		private void SolverRotateChildren(int index, Quaternion rotation)
		{
		}

		[Token(Token = "0x600035A")]
		[Address(RVA = "0x171C730", Offset = "0x171C730", VA = "0x171C730")]
		private void SolverMoveChildrenAroundPoint(int index, Quaternion rotation)
		{
		}

		[Token(Token = "0x600035B")]
		[Address(RVA = "0x171AEC4", Offset = "0x171AEC4", VA = "0x171AEC4")]
		private Quaternion GetParentSolverRotation(int index)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600035C")]
		[Address(RVA = "0x171B090", Offset = "0x171B090", VA = "0x171B090")]
		private Vector3 GetParentSolverPosition(int index)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600035D")]
		[Address(RVA = "0x171C9D0", Offset = "0x171C9D0", VA = "0x171C9D0")]
		private Quaternion GetLimitedRotation(int index, Quaternion q, out bool changed)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600035E")]
		[Address(RVA = "0x171BAF8", Offset = "0x171BAF8", VA = "0x171BAF8")]
		private void LimitForward(int rotateBone, int limitBone)
		{
		}

		[Token(Token = "0x600035F")]
		[Address(RVA = "0x171A8F8", Offset = "0x171A8F8", VA = "0x171A8F8")]
		private void BackwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x6000360")]
		[Address(RVA = "0x171D4D8", Offset = "0x171D4D8", VA = "0x171D4D8")]
		private void BackwardReachUnlimited(Vector3 position)
		{
		}

		[Token(Token = "0x6000361")]
		[Address(RVA = "0x171CBC8", Offset = "0x171CBC8", VA = "0x171CBC8")]
		private void BackwardReachLimited(Vector3 position)
		{
		}

		[Token(Token = "0x6000362")]
		[Address(RVA = "0x171B72C", Offset = "0x171B72C", VA = "0x171B72C")]
		private void MapToSolverPositions()
		{
		}

		[Token(Token = "0x6000363")]
		[Address(RVA = "0x171B90C", Offset = "0x171B90C", VA = "0x171B90C")]
		private void MapToSolverPositionsLimited()
		{
		}

		[Token(Token = "0x6000364")]
		[Address(RVA = "0x171D6F0", Offset = "0x171D6F0", VA = "0x171D6F0")]
		public IKSolverFABRIK()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000053")]
	public class IKSolverFABRIKRoot : IKSolver
	{
		[Token(Token = "0x400020F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public int iterations;

		[Token(Token = "0x4000210")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9D7888", Offset = "0x9D7888")]
		public float rootPin;

		[Token(Token = "0x4000211")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public FABRIKChain[] chains;

		[Token(Token = "0x4000212")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private bool zeroWeightApplied;

		[Token(Token = "0x4000213")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private bool[] isRoot;

		[Token(Token = "0x4000214")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Vector3 rootDefaultPosition;

		[Token(Token = "0x6000365")]
		[Address(RVA = "0x171D768", Offset = "0x171D768", VA = "0x171D768", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000366")]
		[Address(RVA = "0x171E6C4", Offset = "0x171E6C4", VA = "0x171E6C4", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000367")]
		[Address(RVA = "0x171E7A8", Offset = "0x171E7A8", VA = "0x171E7A8", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x6000368")]
		[Address(RVA = "0x171E8A8", Offset = "0x171E8A8", VA = "0x171E8A8", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000369")]
		[Address(RVA = "0x171EA14", Offset = "0x171EA14", VA = "0x171EA14")]
		private bool IsRoot(int index)
		{
			return default(bool);
		}

		[Token(Token = "0x600036A")]
		[Address(RVA = "0x171EB6C", Offset = "0x171EB6C", VA = "0x171EB6C", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x600036B")]
		[Address(RVA = "0x171F2C4", Offset = "0x171F2C4", VA = "0x171F2C4", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x600036C")]
		[Address(RVA = "0x171F550", Offset = "0x171F550", VA = "0x171F550", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x600036D")]
		[Address(RVA = "0x171F398", Offset = "0x171F398", VA = "0x171F398")]
		private void AddPointsToArray(ref Point[] array, FABRIKChain chain)
		{
		}

		[Token(Token = "0x600036E")]
		[Address(RVA = "0x171EEA0", Offset = "0x171EEA0", VA = "0x171EEA0")]
		private Vector3 GetCentroid()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600036F")]
		[Address(RVA = "0x171F628", Offset = "0x171F628", VA = "0x171F628")]
		public IKSolverFABRIKRoot()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000054")]
	public class IKSolverFullBody : IKSolver
	{
		[Token(Token = "0x4000215")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9D78A0", Offset = "0x9D78A0")]
		public int iterations;

		[Token(Token = "0x4000216")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public FBIKChain[] chain;

		[Token(Token = "0x4000217")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public IKEffector[] effectors;

		[Token(Token = "0x4000218")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public IKMappingSpine spineMapping;

		[Token(Token = "0x4000219")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public IKMappingBone[] boneMappings;

		[Token(Token = "0x400021A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public IKMappingLimb[] limbMappings;

		[Token(Token = "0x400021B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public bool FABRIKPass;

		[Token(Token = "0x400021C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public UpdateDelegate OnPreRead;

		[Token(Token = "0x400021D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public UpdateDelegate OnPreSolve;

		[Token(Token = "0x400021E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public IterationDelegate OnPreIteration;

		[Token(Token = "0x400021F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public IterationDelegate OnPostIteration;

		[Token(Token = "0x4000220")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public UpdateDelegate OnPreBend;

		[Token(Token = "0x4000221")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public UpdateDelegate OnPostSolve;

		[Token(Token = "0x4000222")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public UpdateDelegate OnStoreDefaultLocalState;

		[Token(Token = "0x4000223")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public UpdateDelegate OnFixTransforms;

		[Token(Token = "0x6000370")]
		[Address(RVA = "0x1874200", Offset = "0x1874200", VA = "0x1874200")]
		public IKEffector GetEffector(Transform t)
		{
			return null;
		}

		[Token(Token = "0x6000371")]
		[Address(RVA = "0x1874334", Offset = "0x1874334", VA = "0x1874334")]
		public FBIKChain GetChain(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x6000372")]
		[Address(RVA = "0x18743A0", Offset = "0x18743A0", VA = "0x18743A0")]
		public int GetChainIndex(Transform transform)
		{
			return default(int);
		}

		[Token(Token = "0x6000373")]
		[Address(RVA = "0x1874554", Offset = "0x1874554", VA = "0x1874554")]
		public Node GetNode(int chainIndex, int nodeIndex)
		{
			return null;
		}

		[Token(Token = "0x6000374")]
		[Address(RVA = "0x18745F8", Offset = "0x18745F8", VA = "0x18745F8")]
		public void GetChainAndNodeIndexes(Transform transform, out int chainIndex, out int nodeIndex)
		{
		}

		[Token(Token = "0x6000375")]
		[Address(RVA = "0x187469C", Offset = "0x187469C", VA = "0x187469C", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x6000376")]
		[Address(RVA = "0x18748FC", Offset = "0x18748FC", VA = "0x18748FC", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x6000377")]
		[Address(RVA = "0x1874B24", Offset = "0x1874B24", VA = "0x1874B24", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000378")]
		[Address(RVA = "0x1874DCC", Offset = "0x1874DCC", VA = "0x1874DCC", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000379")]
		[Address(RVA = "0x1874F18", Offset = "0x1874F18", VA = "0x1874F18", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x600037A")]
		[Address(RVA = "0x1875070", Offset = "0x1875070", VA = "0x1875070", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x600037B")]
		[Address(RVA = "0x1875274", Offset = "0x1875274", VA = "0x1875274", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x600037C")]
		[Address(RVA = "0x18754C0", Offset = "0x18754C0", VA = "0x18754C0", Slot = "12")]
		protected virtual void ReadPose()
		{
		}

		[Token(Token = "0x600037D")]
		[Address(RVA = "0x1875918", Offset = "0x1875918", VA = "0x1875918", Slot = "13")]
		protected virtual void Solve()
		{
		}

		[Token(Token = "0x600037E")]
		[Address(RVA = "0x1875F08", Offset = "0x1875F08", VA = "0x1875F08", Slot = "14")]
		protected virtual void ApplyBendConstraints()
		{
		}

		[Token(Token = "0x600037F")]
		[Address(RVA = "0x1875F6C", Offset = "0x1875F6C", VA = "0x1875F6C", Slot = "15")]
		protected virtual void WritePose()
		{
		}

		[Token(Token = "0x6000380")]
		[Address(RVA = "0x18760D8", Offset = "0x18760D8", VA = "0x18760D8")]
		public IKSolverFullBody()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000055")]
	public enum FullBodyBipedEffector
	{
		[Token(Token = "0x4000225")]
		Body,
		[Token(Token = "0x4000226")]
		LeftShoulder,
		[Token(Token = "0x4000227")]
		RightShoulder,
		[Token(Token = "0x4000228")]
		LeftThigh,
		[Token(Token = "0x4000229")]
		RightThigh,
		[Token(Token = "0x400022A")]
		LeftHand,
		[Token(Token = "0x400022B")]
		RightHand,
		[Token(Token = "0x400022C")]
		LeftFoot,
		[Token(Token = "0x400022D")]
		RightFoot
	}
	[Serializable]
	[Token(Token = "0x2000056")]
	public enum FullBodyBipedChain
	{
		[Token(Token = "0x400022F")]
		LeftArm,
		[Token(Token = "0x4000230")]
		RightArm,
		[Token(Token = "0x4000231")]
		LeftLeg,
		[Token(Token = "0x4000232")]
		RightLeg
	}
	[Serializable]
	[Token(Token = "0x2000057")]
	public class IKSolverFullBodyBiped : IKSolverFullBody
	{
		[Token(Token = "0x4000233")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public Transform rootNode;

		[Token(Token = "0x4000234")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9D78B8", Offset = "0x9D78B8")]
		public float spineStiffness;

		[Token(Token = "0x4000235")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9D78D0", Offset = "0x9D78D0")]
		public float pullBodyVertical;

		[Token(Token = "0x4000236")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9D78E8", Offset = "0x9D78E8")]
		public float pullBodyHorizontal;

		[Token(Token = "0x4000237")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9D7900", Offset = "0x9D7900")]
		private Vector3 <pullBodyOffset>k__BackingField;

		[Token(Token = "0x4000238")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private Vector3 offset;

		[Token(Token = "0x17000073")]
		public IKEffector bodyEffector
		{
			[Token(Token = "0x6000381")]
			[Address(RVA = "0x18761B0", Offset = "0x18761B0", VA = "0x18761B0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000074")]
		public IKEffector leftShoulderEffector
		{
			[Token(Token = "0x6000382")]
			[Address(RVA = "0x18763C8", Offset = "0x18763C8", VA = "0x18763C8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000075")]
		public IKEffector rightShoulderEffector
		{
			[Token(Token = "0x6000383")]
			[Address(RVA = "0x18763D0", Offset = "0x18763D0", VA = "0x18763D0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000076")]
		public IKEffector leftThighEffector
		{
			[Token(Token = "0x6000384")]
			[Address(RVA = "0x18763D8", Offset = "0x18763D8", VA = "0x18763D8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000077")]
		public IKEffector rightThighEffector
		{
			[Token(Token = "0x6000385")]
			[Address(RVA = "0x18763E0", Offset = "0x18763E0", VA = "0x18763E0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000078")]
		public IKEffector leftHandEffector
		{
			[Token(Token = "0x6000386")]
			[Address(RVA = "0x18763E8", Offset = "0x18763E8", VA = "0x18763E8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000079")]
		public IKEffector rightHandEffector
		{
			[Token(Token = "0x6000387")]
			[Address(RVA = "0x18763F0", Offset = "0x18763F0", VA = "0x18763F0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700007A")]
		public IKEffector leftFootEffector
		{
			[Token(Token = "0x6000388")]
			[Address(RVA = "0x18763F8", Offset = "0x18763F8", VA = "0x18763F8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700007B")]
		public IKEffector rightFootEffector
		{
			[Token(Token = "0x6000389")]
			[Address(RVA = "0x1876400", Offset = "0x1876400", VA = "0x1876400")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700007C")]
		public FBIKChain leftArmChain
		{
			[Token(Token = "0x600038A")]
			[Address(RVA = "0x1876408", Offset = "0x1876408", VA = "0x1876408")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700007D")]
		public FBIKChain rightArmChain
		{
			[Token(Token = "0x600038B")]
			[Address(RVA = "0x1876450", Offset = "0x1876450", VA = "0x1876450")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700007E")]
		public FBIKChain leftLegChain
		{
			[Token(Token = "0x600038C")]
			[Address(RVA = "0x1876498", Offset = "0x1876498", VA = "0x1876498")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700007F")]
		public FBIKChain rightLegChain
		{
			[Token(Token = "0x600038D")]
			[Address(RVA = "0x18764E0", Offset = "0x18764E0", VA = "0x18764E0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000080")]
		public IKMappingLimb leftArmMapping
		{
			[Token(Token = "0x600038E")]
			[Address(RVA = "0x1876528", Offset = "0x1876528", VA = "0x1876528")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000081")]
		public IKMappingLimb rightArmMapping
		{
			[Token(Token = "0x600038F")]
			[Address(RVA = "0x187656C", Offset = "0x187656C", VA = "0x187656C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000082")]
		public IKMappingLimb leftLegMapping
		{
			[Token(Token = "0x6000390")]
			[Address(RVA = "0x18765B4", Offset = "0x18765B4", VA = "0x18765B4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000083")]
		public IKMappingLimb rightLegMapping
		{
			[Token(Token = "0x6000391")]
			[Address(RVA = "0x18765FC", Offset = "0x18765FC", VA = "0x18765FC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000084")]
		public IKMappingBone headMapping
		{
			[Token(Token = "0x6000392")]
			[Address(RVA = "0x1876644", Offset = "0x1876644", VA = "0x1876644")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000085")]
		public Vector3 pullBodyOffset
		{
			[Token(Token = "0x60003A2")]
			[Address(RVA = "0x1879668", Offset = "0x1879668", VA = "0x1879668")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DE484", Offset = "0x9DE484")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60003A3")]
			[Address(RVA = "0x1879674", Offset = "0x1879674", VA = "0x1879674")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DE494", Offset = "0x9DE494")]
			private set
			{
			}
		}

		[Token(Token = "0x6000393")]
		[Address(RVA = "0x1876688", Offset = "0x1876688", VA = "0x1876688")]
		public void SetChainWeights(FullBodyBipedChain c, float pull, float reach = 0f)
		{
		}

		[Token(Token = "0x6000394")]
		[Address(RVA = "0x1876800", Offset = "0x1876800", VA = "0x1876800")]
		public void SetEffectorWeights(FullBodyBipedEffector effector, float positionWeight, float rotationWeight)
		{
		}

		[Token(Token = "0x6000395")]
		[Address(RVA = "0x18766F0", Offset = "0x18766F0", VA = "0x18766F0")]
		public FBIKChain GetChain(FullBodyBipedChain c)
		{
			return null;
		}

		[Token(Token = "0x6000396")]
		[Address(RVA = "0x18768F0", Offset = "0x18768F0", VA = "0x18768F0")]
		public FBIKChain GetChain(FullBodyBipedEffector effector)
		{
			return null;
		}

		[Token(Token = "0x6000397")]
		[Address(RVA = "0x18761B8", Offset = "0x18761B8", VA = "0x18761B8")]
		public IKEffector GetEffector(FullBodyBipedEffector effector)
		{
			return null;
		}

		[Token(Token = "0x6000398")]
		[Address(RVA = "0x1876A30", Offset = "0x1876A30", VA = "0x1876A30")]
		public IKEffector GetEndEffector(FullBodyBipedChain c)
		{
			return null;
		}

		[Token(Token = "0x6000399")]
		[Address(RVA = "0x1876B40", Offset = "0x1876B40", VA = "0x1876B40")]
		public IKMappingLimb GetLimbMapping(FullBodyBipedChain chain)
		{
			return null;
		}

		[Token(Token = "0x600039A")]
		[Address(RVA = "0x1876C4C", Offset = "0x1876C4C", VA = "0x1876C4C")]
		public IKMappingLimb GetLimbMapping(FullBodyBipedEffector effector)
		{
			return null;
		}

		[Token(Token = "0x600039B")]
		[Address(RVA = "0x1876D58", Offset = "0x1876D58", VA = "0x1876D58")]
		public IKMappingSpine GetSpineMapping()
		{
			return null;
		}

		[Token(Token = "0x600039C")]
		[Address(RVA = "0x1876D60", Offset = "0x1876D60", VA = "0x1876D60")]
		public IKMappingBone GetHeadMapping()
		{
			return null;
		}

		[Token(Token = "0x600039D")]
		[Address(RVA = "0x1876DA4", Offset = "0x1876DA4", VA = "0x1876DA4")]
		public IKConstraintBend GetBendConstraint(FullBodyBipedChain limb)
		{
			return null;
		}

		[Token(Token = "0x600039E")]
		[Address(RVA = "0x1876EC8", Offset = "0x1876EC8", VA = "0x1876EC8", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x600039F")]
		[Address(RVA = "0x1877194", Offset = "0x1877194", VA = "0x1877194")]
		public void SetToReferences(BipedReferences references, [Optional] Transform rootNode)
		{
		}

		[Token(Token = "0x60003A0")]
		[Address(RVA = "0x1878DC8", Offset = "0x1878DC8", VA = "0x1878DC8")]
		public static Transform DetectRootNodeBone(BipedReferences references)
		{
			return null;
		}

		[Token(Token = "0x60003A1")]
		[Address(RVA = "0x1879360", Offset = "0x1879360", VA = "0x1879360")]
		public void SetLimbOrientations(BipedLimbOrientations o)
		{
		}

		[Token(Token = "0x60003A4")]
		[Address(RVA = "0x1879420", Offset = "0x1879420", VA = "0x1879420")]
		private void SetLimbOrientation(FullBodyBipedChain chain, BipedLimbOrientations.LimbOrientation limbOrientation)
		{
		}

		[Token(Token = "0x60003A5")]
		[Address(RVA = "0x1879190", Offset = "0x1879190", VA = "0x1879190")]
		private static Transform GetLeftClavicle(BipedReferences references)
		{
			return null;
		}

		[Token(Token = "0x60003A6")]
		[Address(RVA = "0x1879278", Offset = "0x1879278", VA = "0x1879278")]
		private static Transform GetRightClavicle(BipedReferences references)
		{
			return null;
		}

		[Token(Token = "0x60003A7")]
		[Address(RVA = "0x1879680", Offset = "0x1879680", VA = "0x1879680")]
		private static bool Contains(Transform[] array, Transform transform)
		{
			return default(bool);
		}

		[Token(Token = "0x60003A8")]
		[Address(RVA = "0x1879758", Offset = "0x1879758", VA = "0x1879758", Slot = "12")]
		protected override void ReadPose()
		{
		}

		[Token(Token = "0x60003A9")]
		[Address(RVA = "0x1879954", Offset = "0x1879954", VA = "0x1879954")]
		private void PullBody()
		{
		}

		[Token(Token = "0x60003AA")]
		[Address(RVA = "0x1879B14", Offset = "0x1879B14", VA = "0x1879B14")]
		private Vector3 GetBodyOffset()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003AB")]
		[Address(RVA = "0x1879D1C", Offset = "0x1879D1C", VA = "0x1879D1C")]
		private Vector3 GetHandBodyPull(IKEffector effector, FBIKChain arm, Vector3 offset)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003AC")]
		[Address(RVA = "0x1879F90", Offset = "0x1879F90", VA = "0x1879F90", Slot = "14")]
		protected override void ApplyBendConstraints()
		{
		}

		[Token(Token = "0x60003AD")]
		[Address(RVA = "0x187A4A8", Offset = "0x187A4A8", VA = "0x187A4A8", Slot = "15")]
		protected override void WritePose()
		{
		}

		[Token(Token = "0x60003AE")]
		[Address(RVA = "0x187A5E4", Offset = "0x187A5E4", VA = "0x187A5E4")]
		public IKSolverFullBodyBiped()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000058")]
	public class IKSolverHeuristic : IKSolver
	{
		[Token(Token = "0x4000239")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform target;

		[Token(Token = "0x400023A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public float tolerance;

		[Token(Token = "0x400023B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public int maxIterations;

		[Token(Token = "0x400023C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public bool useRotationLimits;

		[Token(Token = "0x400023D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x69")]
		public bool XY;

		[Token(Token = "0x400023E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Bone[] bones;

		[Token(Token = "0x400023F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		protected Vector3 lastLocalDirection;

		[Token(Token = "0x4000240")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		protected float chainLength;

		[Token(Token = "0x17000086")]
		protected virtual int minBones
		{
			[Token(Token = "0x60003B6")]
			[Address(RVA = "0x187B074", Offset = "0x187B074", VA = "0x187B074", Slot = "12")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000087")]
		protected virtual bool boneLengthCanBeZero
		{
			[Token(Token = "0x60003B7")]
			[Address(RVA = "0x187B07C", Offset = "0x187B07C", VA = "0x187B07C", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000088")]
		protected virtual bool allowCommonParent
		{
			[Token(Token = "0x60003B8")]
			[Address(RVA = "0x187B084", Offset = "0x187B084", VA = "0x187B084", Slot = "14")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000089")]
		protected virtual Vector3 localDirection
		{
			[Token(Token = "0x60003BC")]
			[Address(RVA = "0x187B8CC", Offset = "0x187B8CC", VA = "0x187B8CC", Slot = "15")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x1700008A")]
		protected float positionOffset
		{
			[Token(Token = "0x60003BD")]
			[Address(RVA = "0x187BAAC", Offset = "0x187BAAC", VA = "0x187BAAC")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x60003AF")]
		[Address(RVA = "0x187A5F0", Offset = "0x187A5F0", VA = "0x187A5F0")]
		public bool SetChain(Transform[] hierarchy, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x60003B0")]
		[Address(RVA = "0x187A808", Offset = "0x187A808", VA = "0x187A808")]
		public void AddBone(Transform bone)
		{
		}

		[Token(Token = "0x60003B1")]
		[Address(RVA = "0x187A9D4", Offset = "0x187A9D4", VA = "0x187A9D4", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60003B2")]
		[Address(RVA = "0x187AA70", Offset = "0x187AA70", VA = "0x187AA70", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x60003B3")]
		[Address(RVA = "0x187AB18", Offset = "0x187AB18", VA = "0x187AB18", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60003B4")]
		[Address(RVA = "0x187AF38", Offset = "0x187AF38", VA = "0x187AF38", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x60003B5")]
		[Address(RVA = "0x187AF40", Offset = "0x187AF40", VA = "0x187AF40", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x60003B9")]
		[Address(RVA = "0x187B08C", Offset = "0x187B08C", VA = "0x187B08C", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x60003BA")]
		[Address(RVA = "0x187B090", Offset = "0x187B090", VA = "0x187B090", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x60003BB")]
		[Address(RVA = "0x187B094", Offset = "0x187B094", VA = "0x187B094")]
		protected void InitiateBones()
		{
		}

		[Token(Token = "0x60003BE")]
		[Address(RVA = "0x187BB70", Offset = "0x187BB70", VA = "0x187BB70")]
		protected Vector3 GetSingularityOffset()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003BF")]
		[Address(RVA = "0x187C040", Offset = "0x187C040", VA = "0x187C040")]
		private bool SingularityDetected()
		{
			return default(bool);
		}

		[Token(Token = "0x60003C0")]
		[Address(RVA = "0x187C3B8", Offset = "0x187C3B8", VA = "0x187C3B8")]
		public IKSolverHeuristic()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000059")]
	public class IKSolverLimb : IKSolverTrigonometric
	{
		[Serializable]
		[Token(Token = "0x200014D")]
		public enum BendModifier
		{
			[Token(Token = "0x4000884")]
			Animation,
			[Token(Token = "0x4000885")]
			Target,
			[Token(Token = "0x4000886")]
			Parent,
			[Token(Token = "0x4000887")]
			Arm,
			[Token(Token = "0x4000888")]
			Goal
		}

		[Serializable]
		[Token(Token = "0x200014E")]
		public struct AxisDirection
		{
			[Token(Token = "0x4000889")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Vector3 direction;

			[Token(Token = "0x400088A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public Vector3 axis;

			[Token(Token = "0x400088B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float dot;

			[Token(Token = "0x60009FE")]
			[Address(RVA = "0xAA6318", Offset = "0xAA6318", VA = "0xAA6318")]
			public AxisDirection(Vector3 direction, Vector3 axis)
			{
			}
		}

		[Token(Token = "0x4000241")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public AvatarIKGoal goal;

		[Token(Token = "0x4000242")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		public BendModifier bendModifier;

		[Token(Token = "0x4000243")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9D7910", Offset = "0x9D7910")]
		public float maintainRotationWeight;

		[Token(Token = "0x4000244")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9D7928", Offset = "0x9D7928")]
		public float bendModifierWeight;

		[Token(Token = "0x4000245")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public Transform bendGoal;

		[Token(Token = "0x4000246")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private bool maintainBendFor1Frame;

		[Token(Token = "0x4000247")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC1")]
		private bool maintainRotationFor1Frame;

		[Token(Token = "0x4000248")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private Quaternion defaultRootRotation;

		[Token(Token = "0x4000249")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		private Quaternion parentDefaultRotation;

		[Token(Token = "0x400024A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		private Quaternion bone3RotationBeforeSolve;

		[Token(Token = "0x400024B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
		private Quaternion maintainRotation;

		[Token(Token = "0x400024C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
		private Quaternion bone3DefaultRotation;

		[Token(Token = "0x400024D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x114")]
		private Vector3 _bendNormal;

		[Token(Token = "0x400024E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private Vector3 animationNormal;

		[Token(Token = "0x400024F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private AxisDirection[] axisDirectionsLeft;

		[Token(Token = "0x4000250")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		private AxisDirection[] axisDirectionsRight;

		[Token(Token = "0x1700008B")]
		private AxisDirection[] axisDirections
		{
			[Token(Token = "0x60003C8")]
			[Address(RVA = "0x187DE1C", Offset = "0x187DE1C", VA = "0x187DE1C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60003C1")]
		[Address(RVA = "0x187C428", Offset = "0x187C428", VA = "0x187C428")]
		public void MaintainRotation()
		{
		}

		[Token(Token = "0x60003C2")]
		[Address(RVA = "0x187C48C", Offset = "0x187C48C", VA = "0x187C48C")]
		public void MaintainBend()
		{
		}

		[Token(Token = "0x60003C3")]
		[Address(RVA = "0x187C5B4", Offset = "0x187C5B4", VA = "0x187C5B4", Slot = "12")]
		protected override void OnInitiateVirtual()
		{
		}

		[Token(Token = "0x60003C4")]
		[Address(RVA = "0x187CD38", Offset = "0x187CD38", VA = "0x187CD38", Slot = "13")]
		protected override void OnUpdateVirtual()
		{
		}

		[Token(Token = "0x60003C5")]
		[Address(RVA = "0x187DA9C", Offset = "0x187DA9C", VA = "0x187DA9C", Slot = "14")]
		protected override void OnPostSolveVirtual()
		{
		}

		[Token(Token = "0x60003C6")]
		[Address(RVA = "0x187DC40", Offset = "0x187DC40", VA = "0x187DC40")]
		public IKSolverLimb()
		{
		}

		[Token(Token = "0x60003C7")]
		[Address(RVA = "0x187DD94", Offset = "0x187DD94", VA = "0x187DD94")]
		public IKSolverLimb(AvatarIKGoal goal)
		{
		}

		[Token(Token = "0x60003C9")]
		[Address(RVA = "0x187C9F4", Offset = "0x187C9F4", VA = "0x187C9F4")]
		private void StoreAxisDirections(ref AxisDirection[] axisDirections)
		{
		}

		[Token(Token = "0x60003CA")]
		[Address(RVA = "0x187CE74", Offset = "0x187CE74", VA = "0x187CE74")]
		private Vector3 GetModifiedBendNormal()
		{
			return default(Vector3);
		}
	}
	[Serializable]
	[Token(Token = "0x200005A")]
	public class IKSolverLookAt : IKSolver
	{
		[Serializable]
		[Token(Token = "0x200014F")]
		public class LookAtBone : Bone
		{
			[Token(Token = "0x170001A2")]
			public Vector3 forward
			{
				[Token(Token = "0x6000A03")]
				[Address(RVA = "0x1880364", Offset = "0x1880364", VA = "0x1880364")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x60009FF")]
			[Address(RVA = "0x1880BB8", Offset = "0x1880BB8", VA = "0x1880BB8")]
			public LookAtBone()
			{
			}

			[Token(Token = "0x6000A00")]
			[Address(RVA = "0x187F3F4", Offset = "0x187F3F4", VA = "0x187F3F4")]
			public LookAtBone(Transform transform)
			{
			}

			[Token(Token = "0x6000A01")]
			[Address(RVA = "0x187F838", Offset = "0x187F838", VA = "0x187F838")]
			public void Initiate(Transform root)
			{
			}

			[Token(Token = "0x6000A02")]
			[Address(RVA = "0x1880828", Offset = "0x1880828", VA = "0x1880828")]
			public void LookAt(Vector3 direction, float weight)
			{
			}
		}

		[Token(Token = "0x4000251")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform target;

		[Token(Token = "0x4000252")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public LookAtBone[] spine;

		[Token(Token = "0x4000253")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public LookAtBone head;

		[Token(Token = "0x4000254")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public LookAtBone[] eyes;

		[Token(Token = "0x4000255")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9D7940", Offset = "0x9D7940")]
		public float bodyWeight;

		[Token(Token = "0x4000256")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9D7958", Offset = "0x9D7958")]
		public float headWeight;

		[Token(Token = "0x4000257")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9D7970", Offset = "0x9D7970")]
		public float eyesWeight;

		[Token(Token = "0x4000258")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9D7988", Offset = "0x9D7988")]
		public float clampWeight;

		[Token(Token = "0x4000259")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9D79A0", Offset = "0x9D79A0")]
		public float clampWeightHead;

		[Token(Token = "0x400025A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9D79B8", Offset = "0x9D79B8")]
		public float clampWeightEyes;

		[Token(Token = "0x400025B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9D79D0", Offset = "0x9D79D0")]
		public int clampSmoothing;

		[Token(Token = "0x400025C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public AnimationCurve spineWeightCurve;

		[Token(Token = "0x400025D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private Vector3[] spineForwards;

		[Token(Token = "0x400025E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Vector3[] headForwards;

		[Token(Token = "0x400025F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Vector3[] eyeForward;

		[Token(Token = "0x1700008C")]
		private bool spineIsValid
		{
			[Token(Token = "0x60003D9")]
			[Address(RVA = "0x187E8CC", Offset = "0x187E8CC", VA = "0x187E8CC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700008D")]
		private bool spineIsEmpty
		{
			[Token(Token = "0x60003DA")]
			[Address(RVA = "0x187EB6C", Offset = "0x187EB6C", VA = "0x187EB6C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700008E")]
		private bool headIsValid
		{
			[Token(Token = "0x60003DC")]
			[Address(RVA = "0x187EA14", Offset = "0x187EA14", VA = "0x187EA14")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700008F")]
		private bool headIsEmpty
		{
			[Token(Token = "0x60003DD")]
			[Address(RVA = "0x187EBA0", Offset = "0x187EBA0", VA = "0x187EBA0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000090")]
		private bool eyesIsValid
		{
			[Token(Token = "0x60003DF")]
			[Address(RVA = "0x187EA24", Offset = "0x187EA24", VA = "0x187EA24")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000091")]
		private bool eyesIsEmpty
		{
			[Token(Token = "0x60003E0")]
			[Address(RVA = "0x187EC20", Offset = "0x187EC20", VA = "0x187EC20")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60003CB")]
		[Address(RVA = "0x187DE98", Offset = "0x187DE98", VA = "0x187DE98")]
		public void SetLookAtWeight(float weight)
		{
		}

		[Token(Token = "0x60003CC")]
		[Address(RVA = "0x187DF1C", Offset = "0x187DF1C", VA = "0x187DF1C")]
		public void SetLookAtWeight(float weight, float bodyWeight)
		{
		}

		[Token(Token = "0x60003CD")]
		[Address(RVA = "0x187DFC8", Offset = "0x187DFC8", VA = "0x187DFC8")]
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight)
		{
		}

		[Token(Token = "0x60003CE")]
		[Address(RVA = "0x187E090", Offset = "0x187E090", VA = "0x187E090")]
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight)
		{
		}

		[Token(Token = "0x60003CF")]
		[Address(RVA = "0x187E17C", Offset = "0x187E17C", VA = "0x187E17C")]
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight, float clampWeight)
		{
		}

		[Token(Token = "0x60003D0")]
		[Address(RVA = "0x187E288", Offset = "0x187E288", VA = "0x187E288")]
		public void SetLookAtWeight(float weight, float bodyWeight = 0f, float headWeight = 1f, float eyesWeight = 0.5f, float clampWeight = 0.5f, float clampWeightHead = 0.5f, float clampWeightEyes = 0.3f)
		{
		}

		[Token(Token = "0x60003D1")]
		[Address(RVA = "0x187E3D0", Offset = "0x187E3D0", VA = "0x187E3D0", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60003D2")]
		[Address(RVA = "0x187E570", Offset = "0x187E570", VA = "0x187E570", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x60003D3")]
		[Address(RVA = "0x187E71C", Offset = "0x187E71C", VA = "0x187E71C", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60003D4")]
		[Address(RVA = "0x187EC54", Offset = "0x187EC54", VA = "0x187EC54", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x60003D5")]
		[Address(RVA = "0x187EF64", Offset = "0x187EF64", VA = "0x187EF64", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x60003D6")]
		[Address(RVA = "0x187F124", Offset = "0x187F124", VA = "0x187F124")]
		public bool SetChain(Transform[] spine, Transform head, Transform[] eyes, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x60003D7")]
		[Address(RVA = "0x187F420", Offset = "0x187F420", VA = "0x187F420", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x60003D8")]
		[Address(RVA = "0x187F984", Offset = "0x187F984", VA = "0x187F984", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x60003DB")]
		[Address(RVA = "0x187FA90", Offset = "0x187FA90", VA = "0x187FA90")]
		private void SolveSpine()
		{
		}

		[Token(Token = "0x60003DE")]
		[Address(RVA = "0x187FD64", Offset = "0x187FD64", VA = "0x187FD64")]
		private void SolveHead()
		{
		}

		[Token(Token = "0x60003E1")]
		[Address(RVA = "0x1880060", Offset = "0x1880060", VA = "0x1880060")]
		private void SolveEyes()
		{
		}

		[Token(Token = "0x60003E2")]
		[Address(RVA = "0x1880438", Offset = "0x1880438", VA = "0x1880438")]
		private Vector3[] GetForwards(ref Vector3[] forwards, Vector3 baseForward, Vector3 targetForward, int bones, float clamp)
		{
			return null;
		}

		[Token(Token = "0x60003E3")]
		[Address(RVA = "0x187F1D8", Offset = "0x187F1D8", VA = "0x187F1D8")]
		private void SetBones(Transform[] array, ref LookAtBone[] bones)
		{
		}

		[Token(Token = "0x60003E4")]
		[Address(RVA = "0x18809C0", Offset = "0x18809C0", VA = "0x18809C0")]
		public IKSolverLookAt()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200005B")]
	public class IKSolverTrigonometric : IKSolver
	{
		[Serializable]
		[Token(Token = "0x2000150")]
		public class TrigonometricBone : Bone
		{
			[Token(Token = "0x400088C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
			private Quaternion targetToLocalSpace;

			[Token(Token = "0x400088D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
			private Vector3 defaultLocalBendNormal;

			[Token(Token = "0x6000A04")]
			[Address(RVA = "0x1882588", Offset = "0x1882588", VA = "0x1882588")]
			public void Initiate(Vector3 childPosition, Vector3 bendNormal)
			{
			}

			[Token(Token = "0x6000A05")]
			[Address(RVA = "0x1883418", Offset = "0x1883418", VA = "0x1883418")]
			public Quaternion GetRotation(Vector3 direction, Vector3 bendNormal)
			{
				return default(Quaternion);
			}

			[Token(Token = "0x6000A06")]
			[Address(RVA = "0x187C4E0", Offset = "0x187C4E0", VA = "0x187C4E0")]
			public Vector3 GetBendNormalFromCurrentRotation()
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000A07")]
			[Address(RVA = "0x18834E0", Offset = "0x18834E0", VA = "0x18834E0")]
			public TrigonometricBone()
			{
			}
		}

		[Token(Token = "0x4000260")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform target;

		[Token(Token = "0x4000261")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9D79E8", Offset = "0x9D79E8")]
		public float IKRotationWeight;

		[Token(Token = "0x4000262")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public Quaternion IKRotation;

		[Token(Token = "0x4000263")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		public Vector3 bendNormal;

		[Token(Token = "0x4000264")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public TrigonometricBone bone1;

		[Token(Token = "0x4000265")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public TrigonometricBone bone2;

		[Token(Token = "0x4000266")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public TrigonometricBone bone3;

		[Token(Token = "0x4000267")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		protected Vector3 weightIKPosition;

		[Token(Token = "0x4000268")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		protected bool directHierarchy;

		[Token(Token = "0x60003E5")]
		[Address(RVA = "0x1880BC0", Offset = "0x1880BC0", VA = "0x1880BC0")]
		public void SetBendGoalPosition(Vector3 goalPosition, float weight)
		{
		}

		[Token(Token = "0x60003E6")]
		[Address(RVA = "0x1880DE4", Offset = "0x1880DE4", VA = "0x1880DE4")]
		public void SetBendPlaneToCurrent()
		{
		}

		[Token(Token = "0x60003E7")]
		[Address(RVA = "0x1880FEC", Offset = "0x1880FEC", VA = "0x1880FEC")]
		public void SetIKRotation(Quaternion rotation)
		{
		}

		[Token(Token = "0x60003E8")]
		[Address(RVA = "0x1880FF8", Offset = "0x1880FF8", VA = "0x1880FF8")]
		public void SetIKRotationWeight(float weight)
		{
		}

		[Token(Token = "0x60003E9")]
		[Address(RVA = "0x188107C", Offset = "0x188107C", VA = "0x188107C")]
		public Quaternion GetIKRotation()
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60003EA")]
		[Address(RVA = "0x1881088", Offset = "0x1881088", VA = "0x1881088")]
		public float GetIKRotationWeight()
		{
			return default(float);
		}

		[Token(Token = "0x60003EB")]
		[Address(RVA = "0x1881090", Offset = "0x1881090", VA = "0x1881090", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x60003EC")]
		[Address(RVA = "0x18811E4", Offset = "0x18811E4", VA = "0x18811E4", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x60003ED")]
		[Address(RVA = "0x1881318", Offset = "0x1881318", VA = "0x1881318", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60003EE")]
		[Address(RVA = "0x1881384", Offset = "0x1881384", VA = "0x1881384", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x60003EF")]
		[Address(RVA = "0x18813F0", Offset = "0x18813F0", VA = "0x18813F0", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60003F0")]
		[Address(RVA = "0x18818A4", Offset = "0x18818A4", VA = "0x18818A4")]
		public bool SetChain(Transform bone1, Transform bone2, Transform bone3, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x60003F1")]
		[Address(RVA = "0x1881934", Offset = "0x1881934", VA = "0x1881934")]
		public static void Solve(Transform bone1, Transform bone2, Transform bone3, Vector3 targetPosition, Vector3 bendNormal, float weight)
		{
		}

		[Token(Token = "0x60003F2")]
		[Address(RVA = "0x1881FC0", Offset = "0x1881FC0", VA = "0x1881FC0")]
		private static Vector3 GetDirectionToBendPoint(Vector3 direction, float directionMag, Vector3 bendDirection, float sqrMag1, float sqrMag2)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003F3")]
		[Address(RVA = "0x18821D8", Offset = "0x18821D8", VA = "0x18821D8", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x60003F4")]
		[Address(RVA = "0x188244C", Offset = "0x188244C", VA = "0x188244C")]
		private bool IsDirectHierarchy()
		{
			return default(bool);
		}

		[Token(Token = "0x60003F5")]
		[Address(RVA = "0x1882334", Offset = "0x1882334", VA = "0x1882334")]
		private void InitiateBones()
		{
		}

		[Token(Token = "0x60003F6")]
		[Address(RVA = "0x1882748", Offset = "0x1882748", VA = "0x1882748", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x60003F7")]
		[Address(RVA = "0x18834D4", Offset = "0x18834D4", VA = "0x18834D4", Slot = "12")]
		protected virtual void OnInitiateVirtual()
		{
		}

		[Token(Token = "0x60003F8")]
		[Address(RVA = "0x18834D8", Offset = "0x18834D8", VA = "0x18834D8", Slot = "13")]
		protected virtual void OnUpdateVirtual()
		{
		}

		[Token(Token = "0x60003F9")]
		[Address(RVA = "0x18834DC", Offset = "0x18834DC", VA = "0x18834DC", Slot = "14")]
		protected virtual void OnPostSolveVirtual()
		{
		}

		[Token(Token = "0x60003FA")]
		[Address(RVA = "0x18830E0", Offset = "0x18830E0", VA = "0x18830E0")]
		protected Vector3 GetBendDirection(Vector3 IKPosition, Vector3 bendNormal)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003FB")]
		[Address(RVA = "0x187DCB4", Offset = "0x187DCB4", VA = "0x187DCB4")]
		public IKSolverTrigonometric()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200005C")]
	public class IKSolverVR : IKSolver
	{
		[Serializable]
		[Token(Token = "0x2000151")]
		public class Arm : BodyPart
		{
			[Serializable]
			[Token(Token = "0x20001B2")]
			public enum ShoulderRotationMode
			{
				[Token(Token = "0x4000A7C")]
				YawPitch,
				[Token(Token = "0x4000A7D")]
				FromTo
			}

			[Token(Token = "0x400088E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9DAD08", Offset = "0x9DAD08")]
			public Transform target;

			[Token(Token = "0x400088F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9DAD40", Offset = "0x9DAD40")]
			public Transform bendGoal;

			[Token(Token = "0x4000890")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9DAD78", Offset = "0x9DAD78")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9DAD78", Offset = "0x9DAD78")]
			public float positionWeight;

			[Token(Token = "0x4000891")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9DADCC", Offset = "0x9DADCC")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9DADCC", Offset = "0x9DADCC")]
			public float rotationWeight;

			[Token(Token = "0x4000892")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9DAE20", Offset = "0x9DAE20")]
			public ShoulderRotationMode shoulderRotationMode;

			[Token(Token = "0x4000893")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9DAE58", Offset = "0x9DAE58")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9DAE58", Offset = "0x9DAE58")]
			public float shoulderRotationWeight;

			[Token(Token = "0x4000894")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9DAEAC", Offset = "0x9DAEAC")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9DAEAC", Offset = "0x9DAEAC")]
			public float bendGoalWeight;

			[Token(Token = "0x4000895")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9DAF00", Offset = "0x9DAF00")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9DAF00", Offset = "0x9DAF00")]
			public float swivelOffset;

			[Token(Token = "0x4000896")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9DAF5C", Offset = "0x9DAF5C")]
			public Vector3 wristToPalmAxis;

			[Token(Token = "0x4000897")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9DAF94", Offset = "0x9DAF94")]
			public Vector3 palmToThumbAxis;

			[Token(Token = "0x4000898")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
			[HideInInspector]
			public Vector3 IKPosition;

			[Token(Token = "0x4000899")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
			[HideInInspector]
			public Quaternion IKRotation;

			[Token(Token = "0x400089A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
			[HideInInspector]
			public Vector3 bendDirection;

			[Token(Token = "0x400089B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
			[HideInInspector]
			public Vector3 handPositionOffset;

			[Token(Token = "0x400089C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DB00C", Offset = "0x9DB00C")]
			private Vector3 <position>k__BackingField;

			[Token(Token = "0x400089D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DB01C", Offset = "0x9DB01C")]
			private Quaternion <rotation>k__BackingField;

			[Token(Token = "0x400089E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
			private bool hasShoulder;

			[Token(Token = "0x400089F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
			private Vector3 chestForwardAxis;

			[Token(Token = "0x40008A0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
			private Vector3 chestUpAxis;

			[Token(Token = "0x40008A1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
			private Quaternion chestRotation;

			[Token(Token = "0x40008A2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
			private Vector3 chestForward;

			[Token(Token = "0x40008A3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
			private Vector3 chestUp;

			[Token(Token = "0x40008A4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x11C")]
			private Quaternion forearmRelToUpperArm;

			[Token(Token = "0x40008A5")]
			private const float yawOffsetAngle = 45f;

			[Token(Token = "0x40008A6")]
			private const float pitchOffsetAngle = -30f;

			[Token(Token = "0x170001A3")]
			public Vector3 position
			{
				[Token(Token = "0x6000A08")]
				[Address(RVA = "0x188C640", Offset = "0x188C640", VA = "0x188C640")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E04F4", Offset = "0x9E04F4")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000A09")]
				[Address(RVA = "0x188C64C", Offset = "0x188C64C", VA = "0x188C64C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E0504", Offset = "0x9E0504")]
				private set
				{
				}
			}

			[Token(Token = "0x170001A4")]
			public Quaternion rotation
			{
				[Token(Token = "0x6000A0A")]
				[Address(RVA = "0x188C658", Offset = "0x188C658", VA = "0x188C658")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E0514", Offset = "0x9E0514")]
				get
				{
					return default(Quaternion);
				}
				[Token(Token = "0x6000A0B")]
				[Address(RVA = "0x188C664", Offset = "0x188C664", VA = "0x188C664")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E0524", Offset = "0x9E0524")]
				private set
				{
				}
			}

			[Token(Token = "0x170001A5")]
			private VirtualBone shoulder
			{
				[Token(Token = "0x6000A0C")]
				[Address(RVA = "0x188C670", Offset = "0x188C670", VA = "0x188C670")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170001A6")]
			private VirtualBone upperArm
			{
				[Token(Token = "0x6000A0D")]
				[Address(RVA = "0x188C6B4", Offset = "0x188C6B4", VA = "0x188C6B4")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170001A7")]
			private VirtualBone forearm
			{
				[Token(Token = "0x6000A0E")]
				[Address(RVA = "0x188C6FC", Offset = "0x188C6FC", VA = "0x188C6FC")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170001A8")]
			private VirtualBone hand
			{
				[Token(Token = "0x6000A0F")]
				[Address(RVA = "0x188C744", Offset = "0x188C744", VA = "0x188C744")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000A10")]
			[Address(RVA = "0x188C78C", Offset = "0x188C78C", VA = "0x188C78C", Slot = "4")]
			protected override void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasNeck, bool hasShoulders, bool hasToes, int rootIndex, int index)
			{
			}

			[Token(Token = "0x6000A11")]
			[Address(RVA = "0x188D254", Offset = "0x188D254", VA = "0x188D254", Slot = "5")]
			public override void PreSolve()
			{
			}

			[Token(Token = "0x6000A12")]
			[Address(RVA = "0x188D49C", Offset = "0x188D49C", VA = "0x188D49C", Slot = "7")]
			public override void ApplyOffsets()
			{
			}

			[Token(Token = "0x6000A13")]
			[Address(RVA = "0x188A774", Offset = "0x188A774", VA = "0x188A774")]
			public void Solve(bool isLeft)
			{
			}

			[Token(Token = "0x6000A14")]
			[Address(RVA = "0x188E8AC", Offset = "0x188E8AC", VA = "0x188E8AC", Slot = "8")]
			public override void ResetOffsets()
			{
			}

			[Token(Token = "0x6000A15")]
			[Address(RVA = "0x188E91C", Offset = "0x188E91C", VA = "0x188E91C", Slot = "6")]
			public override void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations)
			{
			}

			[Token(Token = "0x6000A16")]
			[Address(RVA = "0x188D548", Offset = "0x188D548", VA = "0x188D548")]
			private float DamperValue(float value, float min, float max, float weight = 1f)
			{
				return default(float);
			}

			[Token(Token = "0x6000A17")]
			[Address(RVA = "0x188D938", Offset = "0x188D938", VA = "0x188D938")]
			private Vector3 GetBendNormal(Vector3 dir)
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000A18")]
			[Address(RVA = "0x188EAD4", Offset = "0x188EAD4", VA = "0x188EAD4")]
			private void Visualize(VirtualBone bone1, VirtualBone bone2, VirtualBone bone3, Color color)
			{
			}

			[Token(Token = "0x6000A19")]
			[Address(RVA = "0x188C45C", Offset = "0x188C45C", VA = "0x188C45C")]
			public Arm()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000152")]
		public abstract class BodyPart
		{
			[Token(Token = "0x40008A7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DB02C", Offset = "0x9DB02C")]
			private float <sqrMag>k__BackingField;

			[Token(Token = "0x40008A8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DB03C", Offset = "0x9DB03C")]
			private float <mag>k__BackingField;

			[Token(Token = "0x40008A9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[HideInInspector]
			public VirtualBone[] bones;

			[Token(Token = "0x40008AA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			protected bool initiated;

			[Token(Token = "0x40008AB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			protected Vector3 rootPosition;

			[Token(Token = "0x40008AC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			protected Quaternion rootRotation;

			[Token(Token = "0x40008AD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			protected int index;

			[Token(Token = "0x170001A9")]
			public float sqrMag
			{
				[Token(Token = "0x6000A1F")]
				[Address(RVA = "0x188ECC4", Offset = "0x188ECC4", VA = "0x188ECC4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E0534", Offset = "0x9E0534")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000A20")]
				[Address(RVA = "0x188ECCC", Offset = "0x188ECCC", VA = "0x188ECCC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E0544", Offset = "0x9E0544")]
				private set
				{
				}
			}

			[Token(Token = "0x170001AA")]
			public float mag
			{
				[Token(Token = "0x6000A21")]
				[Address(RVA = "0x188D620", Offset = "0x188D620", VA = "0x188D620")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E0554", Offset = "0x9E0554")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000A22")]
				[Address(RVA = "0x188ECD4", Offset = "0x188ECD4", VA = "0x188ECD4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E0564", Offset = "0x9E0564")]
				private set
				{
				}
			}

			[Token(Token = "0x6000A1A")]
			protected abstract void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasNeck, bool hasShoulders, bool hasToes, int rootIndex, int index);

			[Token(Token = "0x6000A1B")]
			public abstract void PreSolve();

			[Token(Token = "0x6000A1C")]
			public abstract void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations);

			[Token(Token = "0x6000A1D")]
			public abstract void ApplyOffsets();

			[Token(Token = "0x6000A1E")]
			public abstract void ResetOffsets();

			[Token(Token = "0x6000A23")]
			[Address(RVA = "0x1887CA4", Offset = "0x1887CA4", VA = "0x1887CA4")]
			public void Read(Vector3[] positions, Quaternion[] rotations, bool hasNeck, bool hasShoulders, bool hasToes, int rootIndex, int index)
			{
			}

			[Token(Token = "0x6000A24")]
			[Address(RVA = "0x188F220", Offset = "0x188F220", VA = "0x188F220")]
			public void MovePosition(Vector3 position)
			{
			}

			[Token(Token = "0x6000A25")]
			[Address(RVA = "0x188F3B8", Offset = "0x188F3B8", VA = "0x188F3B8")]
			public void MoveRotation(Quaternion rotation)
			{
			}

			[Token(Token = "0x6000A26")]
			[Address(RVA = "0x188F740", Offset = "0x188F740", VA = "0x188F740")]
			public void Translate(Vector3 position, Quaternion rotation)
			{
			}

			[Token(Token = "0x6000A27")]
			[Address(RVA = "0x188A1A4", Offset = "0x188A1A4", VA = "0x188A1A4")]
			public void TranslateRoot(Vector3 newRootPos, Quaternion newRootRot)
			{
			}

			[Token(Token = "0x6000A28")]
			[Address(RVA = "0x188E694", Offset = "0x188E694", VA = "0x188E694")]
			public void RotateTo(VirtualBone bone, Quaternion rotation, float weight = 1f)
			{
			}

			[Token(Token = "0x6000A29")]
			[Address(RVA = "0x188F794", Offset = "0x188F794", VA = "0x188F794")]
			public void Visualize(Color color)
			{
			}

			[Token(Token = "0x6000A2A")]
			[Address(RVA = "0x188F934", Offset = "0x188F934", VA = "0x188F934")]
			public void Visualize()
			{
			}

			[Token(Token = "0x6000A2B")]
			[Address(RVA = "0x188EC2C", Offset = "0x188EC2C", VA = "0x188EC2C")]
			protected BodyPart()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000153")]
		public class Footstep
		{
			[Token(Token = "0x40008AE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float stepSpeed;

			[Token(Token = "0x40008AF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public Vector3 characterSpaceOffset;

			[Token(Token = "0x40008B0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DB05C", Offset = "0x9DB05C")]
			private Vector3 <position>k__BackingField;

			[Token(Token = "0x40008B1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DB06C", Offset = "0x9DB06C")]
			private Quaternion <rotation>k__BackingField;

			[Token(Token = "0x40008B2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DB07C", Offset = "0x9DB07C")]
			private Quaternion <stepToRootRot>k__BackingField;

			[Token(Token = "0x40008B3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DB08C", Offset = "0x9DB08C")]
			private float <stepProgress>k__BackingField;

			[Token(Token = "0x40008B4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DB09C", Offset = "0x9DB09C")]
			private Vector3 <stepFrom>k__BackingField;

			[Token(Token = "0x40008B5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			public Vector3 stepTo;

			[Token(Token = "0x40008B6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			private Quaternion stepFromRot;

			[Token(Token = "0x40008B7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			private Quaternion stepToRot;

			[Token(Token = "0x40008B8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
			private Quaternion footRelativeToRoot;

			[Token(Token = "0x170001AB")]
			public Vector3 position
			{
				[Token(Token = "0x6000A2C")]
				[Address(RVA = "0x188F95C", Offset = "0x188F95C", VA = "0x188F95C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E0574", Offset = "0x9E0574")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000A2D")]
				[Address(RVA = "0x188F968", Offset = "0x188F968", VA = "0x188F968")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E0584", Offset = "0x9E0584")]
				private set
				{
				}
			}

			[Token(Token = "0x170001AC")]
			public Quaternion rotation
			{
				[Token(Token = "0x6000A2E")]
				[Address(RVA = "0x188F974", Offset = "0x188F974", VA = "0x188F974")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E0594", Offset = "0x9E0594")]
				get
				{
					return default(Quaternion);
				}
				[Token(Token = "0x6000A2F")]
				[Address(RVA = "0x188F980", Offset = "0x188F980", VA = "0x188F980")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E05A4", Offset = "0x9E05A4")]
				private set
				{
				}
			}

			[Token(Token = "0x170001AD")]
			public Quaternion stepToRootRot
			{
				[Token(Token = "0x6000A30")]
				[Address(RVA = "0x188F98C", Offset = "0x188F98C", VA = "0x188F98C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E05B4", Offset = "0x9E05B4")]
				get
				{
					return default(Quaternion);
				}
				[Token(Token = "0x6000A31")]
				[Address(RVA = "0x188F998", Offset = "0x188F998", VA = "0x188F998")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E05C4", Offset = "0x9E05C4")]
				private set
				{
				}
			}

			[Token(Token = "0x170001AE")]
			public bool isStepping
			{
				[Token(Token = "0x6000A32")]
				[Address(RVA = "0x188F9A4", Offset = "0x188F9A4", VA = "0x188F9A4")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x170001AF")]
			public float stepProgress
			{
				[Token(Token = "0x6000A33")]
				[Address(RVA = "0x188F9B8", Offset = "0x188F9B8", VA = "0x188F9B8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E05D4", Offset = "0x9E05D4")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000A34")]
				[Address(RVA = "0x188F9C0", Offset = "0x188F9C0", VA = "0x188F9C0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E05E4", Offset = "0x9E05E4")]
				private set
				{
				}
			}

			[Token(Token = "0x170001B0")]
			public Vector3 stepFrom
			{
				[Token(Token = "0x6000A35")]
				[Address(RVA = "0x188F9C8", Offset = "0x188F9C8", VA = "0x188F9C8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E05F4", Offset = "0x9E05F4")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000A36")]
				[Address(RVA = "0x188F9D4", Offset = "0x188F9D4", VA = "0x188F9D4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E0604", Offset = "0x9E0604")]
				private set
				{
				}
			}

			[Token(Token = "0x6000A37")]
			[Address(RVA = "0x188F9E0", Offset = "0x188F9E0", VA = "0x188F9E0")]
			public Footstep(Quaternion rootRotation, Vector3 footPosition, Quaternion footRotation, Vector3 characterSpaceOffset)
			{
			}

			[Token(Token = "0x6000A38")]
			[Address(RVA = "0x188FAF0", Offset = "0x188FAF0", VA = "0x188FAF0")]
			public void Reset(Quaternion rootRotation, Vector3 footPosition, Quaternion footRotation)
			{
			}

			[Token(Token = "0x6000A39")]
			[Address(RVA = "0x188FC20", Offset = "0x188FC20", VA = "0x188FC20")]
			public void StepTo(Vector3 p, Quaternion rootRotation)
			{
			}

			[Token(Token = "0x6000A3A")]
			[Address(RVA = "0x188FD2C", Offset = "0x188FD2C", VA = "0x188FD2C")]
			public void Update(InterpolationMode interpolation)
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000154")]
		public class Leg : BodyPart
		{
			[Token(Token = "0x40008B9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9DB0AC", Offset = "0x9DB0AC")]
			public Transform target;

			[Token(Token = "0x40008BA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9DB0E4", Offset = "0x9DB0E4")]
			public Transform bendGoal;

			[Token(Token = "0x40008BB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9DB11C", Offset = "0x9DB11C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9DB11C", Offset = "0x9DB11C")]
			public float positionWeight;

			[Token(Token = "0x40008BC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9DB170", Offset = "0x9DB170")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9DB170", Offset = "0x9DB170")]
			public float rotationWeight;

			[Token(Token = "0x40008BD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9DB1C4", Offset = "0x9DB1C4")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9DB1C4", Offset = "0x9DB1C4")]
			public float bendGoalWeight;

			[Token(Token = "0x40008BE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9DB218", Offset = "0x9DB218")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9DB218", Offset = "0x9DB218")]
			public float swivelOffset;

			[Token(Token = "0x40008BF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DB274", Offset = "0x9DB274")]
			private Vector3 <IKPosition>k__BackingField;

			[Token(Token = "0x40008C0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DB284", Offset = "0x9DB284")]
			private Quaternion <IKRotation>k__BackingField;

			[Token(Token = "0x40008C1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
			[HideInInspector]
			public Vector3 footPositionOffset;

			[Token(Token = "0x40008C2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			[HideInInspector]
			public Vector3 heelPositionOffset;

			[Token(Token = "0x40008C3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
			[HideInInspector]
			public Quaternion footRotationOffset;

			[Token(Token = "0x40008C4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
			[HideInInspector]
			public float currentMag;

			[Token(Token = "0x40008C5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DB2D4", Offset = "0x9DB2D4")]
			private Vector3 <position>k__BackingField;

			[Token(Token = "0x40008C6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DB2E4", Offset = "0x9DB2E4")]
			private Quaternion <rotation>k__BackingField;

			[Token(Token = "0x40008C7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DB2F4", Offset = "0x9DB2F4")]
			private bool <hasToes>k__BackingField;

			[Token(Token = "0x40008C8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DB304", Offset = "0x9DB304")]
			private Vector3 <thighRelativeToPelvis>k__BackingField;

			[Token(Token = "0x40008C9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
			private Vector3 footPosition;

			[Token(Token = "0x40008CA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
			private Quaternion footRotation;

			[Token(Token = "0x40008CB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
			private Vector3 bendNormal;

			[Token(Token = "0x40008CC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
			private Quaternion calfRelToThigh;

			[Token(Token = "0x170001B1")]
			public Vector3 IKPosition
			{
				[Token(Token = "0x6000A3B")]
				[Address(RVA = "0x188FECC", Offset = "0x188FECC", VA = "0x188FECC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E0614", Offset = "0x9E0614")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000A3C")]
				[Address(RVA = "0x188FED8", Offset = "0x188FED8", VA = "0x188FED8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E0624", Offset = "0x9E0624")]
				private set
				{
				}
			}

			[Token(Token = "0x170001B2")]
			public Quaternion IKRotation
			{
				[Token(Token = "0x6000A3D")]
				[Address(RVA = "0x188FEE4", Offset = "0x188FEE4", VA = "0x188FEE4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E0634", Offset = "0x9E0634")]
				get
				{
					return default(Quaternion);
				}
				[Token(Token = "0x6000A3E")]
				[Address(RVA = "0x188FEF0", Offset = "0x188FEF0", VA = "0x188FEF0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E0644", Offset = "0x9E0644")]
				private set
				{
				}
			}

			[Token(Token = "0x170001B3")]
			public Vector3 position
			{
				[Token(Token = "0x6000A3F")]
				[Address(RVA = "0x188A008", Offset = "0x188A008", VA = "0x188A008")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E0654", Offset = "0x9E0654")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000A40")]
				[Address(RVA = "0x188FEFC", Offset = "0x188FEFC", VA = "0x188FEFC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E0664", Offset = "0x9E0664")]
				private set
				{
				}
			}

			[Token(Token = "0x170001B4")]
			public Quaternion rotation
			{
				[Token(Token = "0x6000A41")]
				[Address(RVA = "0x188FF08", Offset = "0x188FF08", VA = "0x188FF08")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E0674", Offset = "0x9E0674")]
				get
				{
					return default(Quaternion);
				}
				[Token(Token = "0x6000A42")]
				[Address(RVA = "0x188FF14", Offset = "0x188FF14", VA = "0x188FF14")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E0684", Offset = "0x9E0684")]
				private set
				{
				}
			}

			[Token(Token = "0x170001B5")]
			public bool hasToes
			{
				[Token(Token = "0x6000A43")]
				[Address(RVA = "0x188FF20", Offset = "0x188FF20", VA = "0x188FF20")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E0694", Offset = "0x9E0694")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6000A44")]
				[Address(RVA = "0x188FF28", Offset = "0x188FF28", VA = "0x188FF28")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E06A4", Offset = "0x9E06A4")]
				private set
				{
				}
			}

			[Token(Token = "0x170001B6")]
			public VirtualBone thigh
			{
				[Token(Token = "0x6000A45")]
				[Address(RVA = "0x188FF34", Offset = "0x188FF34", VA = "0x188FF34")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170001B7")]
			private VirtualBone calf
			{
				[Token(Token = "0x6000A46")]
				[Address(RVA = "0x188FF78", Offset = "0x188FF78", VA = "0x188FF78")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170001B8")]
			private VirtualBone foot
			{
				[Token(Token = "0x6000A47")]
				[Address(RVA = "0x188FFC0", Offset = "0x188FFC0", VA = "0x188FFC0")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170001B9")]
			private VirtualBone toes
			{
				[Token(Token = "0x6000A48")]
				[Address(RVA = "0x1890008", Offset = "0x1890008", VA = "0x1890008")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170001BA")]
			public VirtualBone lastBone
			{
				[Token(Token = "0x6000A49")]
				[Address(RVA = "0x1889FAC", Offset = "0x1889FAC", VA = "0x1889FAC")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170001BB")]
			public Vector3 thighRelativeToPelvis
			{
				[Token(Token = "0x6000A4A")]
				[Address(RVA = "0x1890050", Offset = "0x1890050", VA = "0x1890050")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E06B4", Offset = "0x9E06B4")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000A4B")]
				[Address(RVA = "0x189005C", Offset = "0x189005C", VA = "0x189005C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E06C4", Offset = "0x9E06C4")]
				private set
				{
				}
			}

			[Token(Token = "0x6000A4C")]
			[Address(RVA = "0x1890068", Offset = "0x1890068", VA = "0x1890068", Slot = "4")]
			protected override void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasNeck, bool hasShoulders, bool hasToes, int rootIndex, int index)
			{
			}

			[Token(Token = "0x6000A4D")]
			[Address(RVA = "0x1890728", Offset = "0x1890728", VA = "0x1890728", Slot = "5")]
			public override void PreSolve()
			{
			}

			[Token(Token = "0x6000A4E")]
			[Address(RVA = "0x1890E94", Offset = "0x1890E94", VA = "0x1890E94", Slot = "7")]
			public override void ApplyOffsets()
			{
			}

			[Token(Token = "0x6000A4F")]
			[Address(RVA = "0x1890D90", Offset = "0x1890D90", VA = "0x1890D90")]
			private void ApplyPositionOffset(Vector3 offset, float weight)
			{
			}

			[Token(Token = "0x6000A50")]
			[Address(RVA = "0x1890B68", Offset = "0x1890B68", VA = "0x1890B68")]
			private void ApplyRotationOffset(Quaternion offset, float weight)
			{
			}

			[Token(Token = "0x6000A51")]
			[Address(RVA = "0x188A39C", Offset = "0x188A39C", VA = "0x188A39C")]
			public void Solve()
			{
			}

			[Token(Token = "0x6000A52")]
			[Address(RVA = "0x18914AC", Offset = "0x18914AC", VA = "0x18914AC", Slot = "6")]
			public override void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations)
			{
			}

			[Token(Token = "0x6000A53")]
			[Address(RVA = "0x1891660", Offset = "0x1891660", VA = "0x1891660", Slot = "8")]
			public override void ResetOffsets()
			{
			}

			[Token(Token = "0x6000A54")]
			[Address(RVA = "0x188C530", Offset = "0x188C530", VA = "0x188C530")]
			public Leg()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000155")]
		public class Locomotion
		{
			[Token(Token = "0x40008CD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9DB314", Offset = "0x9DB314")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9DB314", Offset = "0x9DB314")]
			public float weight;

			[Token(Token = "0x40008CE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9DB368", Offset = "0x9DB368")]
			public float footDistance;

			[Token(Token = "0x40008CF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9DB3A0", Offset = "0x9DB3A0")]
			public float stepThreshold;

			[Token(Token = "0x40008D0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9DB3D8", Offset = "0x9DB3D8")]
			public float angleThreshold;

			[Token(Token = "0x40008D1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9DB410", Offset = "0x9DB410")]
			public float comAngleMlp;

			[Token(Token = "0x40008D2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9DB448", Offset = "0x9DB448")]
			public float maxVelocity;

			[Token(Token = "0x40008D3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9DB480", Offset = "0x9DB480")]
			public float velocityFactor;

			[Token(Token = "0x40008D4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9DB4B8", Offset = "0x9DB4B8")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9DB4B8", Offset = "0x9DB4B8")]
			public float maxLegStretch;

			[Token(Token = "0x40008D5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9DB510", Offset = "0x9DB510")]
			public float rootSpeed;

			[Token(Token = "0x40008D6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9DB548", Offset = "0x9DB548")]
			public float stepSpeed;

			[Token(Token = "0x40008D7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9DB580", Offset = "0x9DB580")]
			public AnimationCurve stepHeight;

			[Token(Token = "0x40008D8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9DB5B8", Offset = "0x9DB5B8")]
			public AnimationCurve heelHeight;

			[Token(Token = "0x40008D9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9DB5F0", Offset = "0x9DB5F0")]
			public InterpolationMode stepInterpolation;

			[Token(Token = "0x40008DA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9DB628", Offset = "0x9DB628")]
			public Vector3 offset;

			[Token(Token = "0x40008DB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[HideInInspector]
			public bool blockingEnabled;

			[Token(Token = "0x40008DC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			[HideInInspector]
			public LayerMask blockingLayers;

			[Token(Token = "0x40008DD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[HideInInspector]
			public float raycastRadius;

			[Token(Token = "0x40008DE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			[HideInInspector]
			public float raycastHeight;

			[Token(Token = "0x40008DF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DB6A0", Offset = "0x9DB6A0")]
			private Vector3 <centerOfMass>k__BackingField;

			[Token(Token = "0x40008E0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			private Footstep[] footsteps;

			[Token(Token = "0x40008E1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			private Vector3 lastComPosition;

			[Token(Token = "0x40008E2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
			private Vector3 comVelocity;

			[Token(Token = "0x40008E3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			private int leftFootIndex;

			[Token(Token = "0x40008E4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
			private int rightFootIndex;

			[Token(Token = "0x170001BC")]
			public Vector3 centerOfMass
			{
				[Token(Token = "0x6000A55")]
				[Address(RVA = "0x1891710", Offset = "0x1891710", VA = "0x1891710")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E06D4", Offset = "0x9E06D4")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000A56")]
				[Address(RVA = "0x189171C", Offset = "0x189171C", VA = "0x189171C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E06E4", Offset = "0x9E06E4")]
				private set
				{
				}
			}

			[Token(Token = "0x6000A57")]
			[Address(RVA = "0x1887DD8", Offset = "0x1887DD8", VA = "0x1887DD8")]
			public void Initiate(Vector3[] positions, Quaternion[] rotations, bool hasToes)
			{
			}

			[Token(Token = "0x6000A58")]
			[Address(RVA = "0x1885380", Offset = "0x1885380", VA = "0x1885380")]
			public void Reset(Vector3[] positions, Quaternion[] rotations)
			{
			}

			[Token(Token = "0x6000A59")]
			[Address(RVA = "0x1888608", Offset = "0x1888608", VA = "0x1888608")]
			public void Solve(VirtualBone rootBone, Spine spine, Leg leftLeg, Leg rightLeg, Arm leftArm, Arm rightArm, out Vector3 leftFootPosition, out Vector3 rightFootPosition, out Quaternion leftFootRotation, out Quaternion rightFootRotation, out float leftFootOffset, out float rightFootOffset, out float leftHeelOffset, out float rightHeelOffset)
			{
			}

			[Token(Token = "0x6000A5A")]
			[Address(RVA = "0x1891778", Offset = "0x1891778", VA = "0x1891778")]
			private bool StepBlocked(Vector3 fromPosition, Vector3 toPosition, Vector3 rootPosition)
			{
				return default(bool);
			}

			[Token(Token = "0x6000A5B")]
			[Address(RVA = "0x189191C", Offset = "0x189191C", VA = "0x189191C")]
			private bool CanStep()
			{
				return default(bool);
			}

			[Token(Token = "0x6000A5C")]
			[Address(RVA = "0x18919C4", Offset = "0x18919C4", VA = "0x18919C4")]
			private static bool GetLineSphereCollision(Vector3 lineStart, Vector3 lineEnd, Vector3 sphereCenter, float sphereRadius)
			{
				return default(bool);
			}

			[Token(Token = "0x6000A5D")]
			[Address(RVA = "0x188C5A4", Offset = "0x188C5A4", VA = "0x188C5A4")]
			public Locomotion()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000156")]
		public class Spine : BodyPart
		{
			[Token(Token = "0x40008E5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9DB6B0", Offset = "0x9DB6B0")]
			public Transform headTarget;

			[Token(Token = "0x40008E6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9DB6E8", Offset = "0x9DB6E8")]
			public Transform pelvisTarget;

			[Token(Token = "0x40008E7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9DB720", Offset = "0x9DB720")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9DB720", Offset = "0x9DB720")]
			public float positionWeight;

			[Token(Token = "0x40008E8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9DB774", Offset = "0x9DB774")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9DB774", Offset = "0x9DB774")]
			public float rotationWeight;

			[Token(Token = "0x40008E9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9DB7C8", Offset = "0x9DB7C8")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9DB7C8", Offset = "0x9DB7C8")]
			public float pelvisPositionWeight;

			[Token(Token = "0x40008EA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9DB81C", Offset = "0x9DB81C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9DB81C", Offset = "0x9DB81C")]
			public float bodyPosStiffness;

			[Token(Token = "0x40008EB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9DB870", Offset = "0x9DB870")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9DB870", Offset = "0x9DB870")]
			public float bodyRotStiffness;

			[Token(Token = "0x40008EC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9DB8C4", Offset = "0x9DB8C4")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9DB8C4", Offset = "0x9DB8C4")]
			public float chestRotationWeight;

			[Token(Token = "0x40008ED")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9DB918", Offset = "0x9DB918")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9DB918", Offset = "0x9DB918")]
			public float chestClampWeight;

			[Token(Token = "0x40008EE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9DB96C", Offset = "0x9DB96C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9DB96C", Offset = "0x9DB96C")]
			public float headClampWeight;

			[Token(Token = "0x40008EF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9DB9C0", Offset = "0x9DB9C0")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9DB9C0", Offset = "0x9DB9C0")]
			public float maintainPelvisPosition;

			[Token(Token = "0x40008F0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9DBA14", Offset = "0x9DBA14")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9DBA14", Offset = "0x9DBA14")]
			public float maxRootAngle;

			[Token(Token = "0x40008F1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DBA6C", Offset = "0x9DBA6C")]
			private Vector3 <IKPositionHead>k__BackingField;

			[Token(Token = "0x40008F2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DBA7C", Offset = "0x9DBA7C")]
			private Quaternion <IKRotationHead>k__BackingField;

			[Token(Token = "0x40008F3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DBA8C", Offset = "0x9DBA8C")]
			private Vector3 <IKPositionPelvis>k__BackingField;

			[Token(Token = "0x40008F4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
			[HideInInspector]
			public Vector3 pelvisPositionOffset;

			[Token(Token = "0x40008F5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
			[HideInInspector]
			public Vector3 chestPositionOffset;

			[Token(Token = "0x40008F6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
			[HideInInspector]
			public Vector3 headPositionOffset;

			[Token(Token = "0x40008F7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
			[HideInInspector]
			public Quaternion pelvisRotationOffset;

			[Token(Token = "0x40008F8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
			[HideInInspector]
			public Quaternion chestRotationOffset;

			[Token(Token = "0x40008F9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
			[HideInInspector]
			public Quaternion headRotationOffset;

			[Token(Token = "0x40008FA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xFC")]
			[HideInInspector]
			public Vector3 faceDirection;

			[Token(Token = "0x40008FB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DBB0C", Offset = "0x9DBB0C")]
			private Quaternion <anchorRotation>k__BackingField;

			[Token(Token = "0x40008FC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
			private Vector3 headPosition;

			[Token(Token = "0x40008FD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x124")]
			private Quaternion headRotation;

			[Token(Token = "0x40008FE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x134")]
			private Quaternion anchorRelativeToHead;

			[Token(Token = "0x40008FF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x144")]
			private Quaternion pelvisRelativeRotation;

			[Token(Token = "0x4000900")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x154")]
			private Quaternion chestRelativeRotation;

			[Token(Token = "0x4000901")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x164")]
			private Vector3 headDeltaPosition;

			[Token(Token = "0x4000902")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
			private Quaternion pelvisDeltaRotation;

			[Token(Token = "0x4000903")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
			private Quaternion chestTargetRotation;

			[Token(Token = "0x4000904")]
			private const int pelvisIndex = 0;

			[Token(Token = "0x4000905")]
			private const int spineIndex = 1;

			[Token(Token = "0x4000906")]
			private const int chestIndex = 2;

			[Token(Token = "0x4000907")]
			private const int neckIndex = 3;

			[Token(Token = "0x4000908")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
			private int headIndex;

			[Token(Token = "0x4000909")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x194")]
			private float length;

			[Token(Token = "0x400090A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
			private bool hasNeck;

			[Token(Token = "0x400090B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x19C")]
			private float headHeight;

			[Token(Token = "0x170001BD")]
			public Vector3 IKPositionHead
			{
				[Token(Token = "0x6000A5E")]
				[Address(RVA = "0x1891B90", Offset = "0x1891B90", VA = "0x1891B90")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E06F4", Offset = "0x9E06F4")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000A5F")]
				[Address(RVA = "0x1891B9C", Offset = "0x1891B9C", VA = "0x1891B9C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E0704", Offset = "0x9E0704")]
				private set
				{
				}
			}

			[Token(Token = "0x170001BE")]
			public Quaternion IKRotationHead
			{
				[Token(Token = "0x6000A60")]
				[Address(RVA = "0x1891BA8", Offset = "0x1891BA8", VA = "0x1891BA8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E0714", Offset = "0x9E0714")]
				get
				{
					return default(Quaternion);
				}
				[Token(Token = "0x6000A61")]
				[Address(RVA = "0x1891BB4", Offset = "0x1891BB4", VA = "0x1891BB4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E0724", Offset = "0x9E0724")]
				private set
				{
				}
			}

			[Token(Token = "0x170001BF")]
			public Vector3 IKPositionPelvis
			{
				[Token(Token = "0x6000A62")]
				[Address(RVA = "0x1891BC0", Offset = "0x1891BC0", VA = "0x1891BC0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E0734", Offset = "0x9E0734")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000A63")]
				[Address(RVA = "0x1891BCC", Offset = "0x1891BCC", VA = "0x1891BCC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E0744", Offset = "0x9E0744")]
				private set
				{
				}
			}

			[Token(Token = "0x170001C0")]
			public VirtualBone pelvis
			{
				[Token(Token = "0x6000A64")]
				[Address(RVA = "0x1885740", Offset = "0x1885740", VA = "0x1885740")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170001C1")]
			public VirtualBone firstSpineBone
			{
				[Token(Token = "0x6000A65")]
				[Address(RVA = "0x1891BD8", Offset = "0x1891BD8", VA = "0x1891BD8")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170001C2")]
			public VirtualBone chest
			{
				[Token(Token = "0x6000A66")]
				[Address(RVA = "0x188A72C", Offset = "0x188A72C", VA = "0x188A72C")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170001C3")]
			private VirtualBone neck
			{
				[Token(Token = "0x6000A67")]
				[Address(RVA = "0x1891C20", Offset = "0x1891C20", VA = "0x1891C20")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170001C4")]
			public VirtualBone head
			{
				[Token(Token = "0x6000A68")]
				[Address(RVA = "0x1891728", Offset = "0x1891728", VA = "0x1891728")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170001C5")]
			public Quaternion anchorRotation
			{
				[Token(Token = "0x6000A69")]
				[Address(RVA = "0x1891C68", Offset = "0x1891C68", VA = "0x1891C68")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E0754", Offset = "0x9E0754")]
				get
				{
					return default(Quaternion);
				}
				[Token(Token = "0x6000A6A")]
				[Address(RVA = "0x1891C7C", Offset = "0x1891C7C", VA = "0x1891C7C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E0764", Offset = "0x9E0764")]
				private set
				{
				}
			}

			[Token(Token = "0x6000A6B")]
			[Address(RVA = "0x1891C90", Offset = "0x1891C90", VA = "0x1891C90", Slot = "4")]
			protected override void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasNeck, bool hasShoulders, bool hasToes, int rootIndex, int index)
			{
			}

			[Token(Token = "0x6000A6C")]
			[Address(RVA = "0x18926C8", Offset = "0x18926C8", VA = "0x18926C8", Slot = "5")]
			public override void PreSolve()
			{
			}

			[Token(Token = "0x6000A6D")]
			[Address(RVA = "0x189286C", Offset = "0x189286C", VA = "0x189286C", Slot = "7")]
			public override void ApplyOffsets()
			{
			}

			[Token(Token = "0x6000A6E")]
			[Address(RVA = "0x1892AE8", Offset = "0x1892AE8", VA = "0x1892AE8")]
			private void CalculateChestTargetRotation(Arm[] arms)
			{
			}

			[Token(Token = "0x6000A6F")]
			[Address(RVA = "0x18881C0", Offset = "0x18881C0", VA = "0x18881C0")]
			public void Solve(VirtualBone rootBone, Leg[] legs, Arm[] arms)
			{
			}

			[Token(Token = "0x6000A70")]
			[Address(RVA = "0x1893D10", Offset = "0x1893D10", VA = "0x1893D10")]
			private void SolvePelvis()
			{
			}

			[Token(Token = "0x6000A71")]
			[Address(RVA = "0x18940DC", Offset = "0x18940DC", VA = "0x18940DC", Slot = "6")]
			public override void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations)
			{
			}

			[Token(Token = "0x6000A72")]
			[Address(RVA = "0x1894440", Offset = "0x1894440", VA = "0x1894440", Slot = "8")]
			public override void ResetOffsets()
			{
			}

			[Token(Token = "0x6000A73")]
			[Address(RVA = "0x1893038", Offset = "0x1893038", VA = "0x1893038")]
			private void AdjustChestByOffset(ref Quaternion chestTargetRotation)
			{
			}

			[Token(Token = "0x6000A74")]
			[Address(RVA = "0x1892CEC", Offset = "0x1892CEC", VA = "0x1892CEC")]
			private void AdjustChestByHands(ref Quaternion chestTargetRotation, Arm[] arms)
			{
			}

			[Token(Token = "0x6000A75")]
			[Address(RVA = "0x188A014", Offset = "0x188A014", VA = "0x188A014")]
			public void InverseTranslateToHead(Leg[] legs, bool limited, bool useCurrentLegMag, Vector3 offset, float w)
			{
			}

			[Token(Token = "0x6000A76")]
			[Address(RVA = "0x1893104", Offset = "0x1893104", VA = "0x1893104")]
			private void TranslatePelvis(Leg[] legs, Vector3 deltaPosition, Quaternion deltaRotation, float w)
			{
			}

			[Token(Token = "0x6000A77")]
			[Address(RVA = "0x1894520", Offset = "0x1894520", VA = "0x1894520")]
			private Vector3 LimitPelvisPosition(Leg[] legs, Vector3 pelvisPosition, bool useCurrentLegMag, int it = 2)
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000A78")]
			[Address(RVA = "0x1893A70", Offset = "0x1893A70", VA = "0x1893A70")]
			private void Bend(VirtualBone[] bones, int firstIndex, int lastIndex, Quaternion targetRotation, float clampWeight, bool uniformWeight, float w)
			{
			}

			[Token(Token = "0x6000A79")]
			[Address(RVA = "0x188C308", Offset = "0x188C308", VA = "0x188C308")]
			public Spine()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000157")]
		public enum PositionOffset
		{
			[Token(Token = "0x400090D")]
			Pelvis,
			[Token(Token = "0x400090E")]
			Chest,
			[Token(Token = "0x400090F")]
			Head,
			[Token(Token = "0x4000910")]
			LeftHand,
			[Token(Token = "0x4000911")]
			RightHand,
			[Token(Token = "0x4000912")]
			LeftFoot,
			[Token(Token = "0x4000913")]
			RightFoot,
			[Token(Token = "0x4000914")]
			LeftHeel,
			[Token(Token = "0x4000915")]
			RightHeel
		}

		[Serializable]
		[Token(Token = "0x2000158")]
		public enum RotationOffset
		{
			[Token(Token = "0x4000917")]
			Pelvis,
			[Token(Token = "0x4000918")]
			Chest,
			[Token(Token = "0x4000919")]
			Head
		}

		[Serializable]
		[Token(Token = "0x2000159")]
		public class VirtualBone
		{
			[Token(Token = "0x400091A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Vector3 readPosition;

			[Token(Token = "0x400091B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public Quaternion readRotation;

			[Token(Token = "0x400091C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public Vector3 solverPosition;

			[Token(Token = "0x400091D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Quaternion solverRotation;

			[Token(Token = "0x400091E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public float length;

			[Token(Token = "0x400091F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			public float sqrMag;

			[Token(Token = "0x4000920")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public Vector3 axis;

			[Token(Token = "0x6000A7A")]
			[Address(RVA = "0x1887C00", Offset = "0x1887C00", VA = "0x1887C00")]
			public VirtualBone(Vector3 position, Quaternion rotation)
			{
			}

			[Token(Token = "0x6000A7B")]
			[Address(RVA = "0x1887C84", Offset = "0x1887C84", VA = "0x1887C84")]
			public void Read(Vector3 position, Quaternion rotation)
			{
			}

			[Token(Token = "0x6000A7C")]
			[Address(RVA = "0x18948C8", Offset = "0x18948C8", VA = "0x18948C8")]
			public static void SwingRotation(VirtualBone[] bones, int index, Vector3 swingTarget, float weight = 1f)
			{
			}

			[Token(Token = "0x6000A7D")]
			[Address(RVA = "0x188ECDC", Offset = "0x188ECDC", VA = "0x188ECDC")]
			public static float PreSolve(ref VirtualBone[] bones)
			{
				return default(float);
			}

			[Token(Token = "0x6000A7E")]
			[Address(RVA = "0x188F4B4", Offset = "0x188F4B4", VA = "0x188F4B4")]
			public static void RotateAroundPoint(VirtualBone[] bones, int index, Vector3 point, Quaternion rotation)
			{
			}

			[Token(Token = "0x6000A7F")]
			[Address(RVA = "0x1894C04", Offset = "0x1894C04", VA = "0x1894C04")]
			public static void RotateBy(VirtualBone[] bones, int index, Quaternion rotation)
			{
			}

			[Token(Token = "0x6000A80")]
			[Address(RVA = "0x188D628", Offset = "0x188D628", VA = "0x188D628")]
			public static void RotateBy(VirtualBone[] bones, Quaternion rotation)
			{
			}

			[Token(Token = "0x6000A81")]
			[Address(RVA = "0x1894F0C", Offset = "0x1894F0C", VA = "0x1894F0C")]
			public static void RotateTo(VirtualBone[] bones, int index, Quaternion rotation)
			{
			}

			[Token(Token = "0x6000A82")]
			[Address(RVA = "0x188DF70", Offset = "0x188DF70", VA = "0x188DF70")]
			public static void SolveTrigonometric(VirtualBone[] bones, int first, int second, int third, Vector3 targetPosition, Vector3 bendNormal, float weight)
			{
			}

			[Token(Token = "0x6000A83")]
			[Address(RVA = "0x189500C", Offset = "0x189500C", VA = "0x189500C")]
			private static Vector3 GetDirectionToBendPoint(Vector3 direction, float directionMag, Vector3 bendDirection, float sqrMag1, float sqrMag2)
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000A84")]
			[Address(RVA = "0x18934B0", Offset = "0x18934B0", VA = "0x18934B0")]
			public static void SolveFABRIK(VirtualBone[] bones, Vector3 startPosition, Vector3 targetPosition, float weight, float minNormalizedTargetDistance, int iterations, float length)
			{
			}

			[Token(Token = "0x6000A85")]
			[Address(RVA = "0x1895224", Offset = "0x1895224", VA = "0x1895224")]
			private static Vector3 SolveFABRIKJoint(Vector3 pos1, Vector3 pos2, float length)
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000A86")]
			[Address(RVA = "0x189532C", Offset = "0x189532C", VA = "0x189532C")]
			public static void SolveCCD(VirtualBone[] bones, Vector3 targetPosition, float weight, int iterations)
			{
			}
		}

		[Token(Token = "0x4000269")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Transform[] solverTransforms;

		[Token(Token = "0x400026A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private bool hasNeck;

		[Token(Token = "0x400026B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x61")]
		private bool hasShoulders;

		[Token(Token = "0x400026C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x62")]
		private bool hasToes;

		[Token(Token = "0x400026D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Vector3[] readPositions;

		[Token(Token = "0x400026E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Quaternion[] readRotations;

		[Token(Token = "0x400026F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Vector3[] solvedPositions;

		[Token(Token = "0x4000270")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Quaternion[] solvedRotations;

		[Token(Token = "0x4000271")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Vector3 defaultPelvisLocalPosition;

		[Token(Token = "0x4000272")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Quaternion[] defaultLocalRotations;

		[Token(Token = "0x4000273")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private Vector3 rootV;

		[Token(Token = "0x4000274")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		private Vector3 rootVelocity;

		[Token(Token = "0x4000275")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private Vector3 bodyOffset;

		[Token(Token = "0x4000276")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9D7A00", Offset = "0x9D7A00")]
		public bool plantFeet;

		[Token(Token = "0x4000277")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9D7A38", Offset = "0x9D7A38")]
		private VirtualBone <rootBone>k__BackingField;

		[Token(Token = "0x4000278")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9D7A48", Offset = "0x9D7A48")]
		public Spine spine;

		[Token(Token = "0x4000279")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9D7A80", Offset = "0x9D7A80")]
		public Arm leftArm;

		[Token(Token = "0x400027A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9D7AB8", Offset = "0x9D7AB8")]
		public Arm rightArm;

		[Token(Token = "0x400027B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9D7AF0", Offset = "0x9D7AF0")]
		public Leg leftLeg;

		[Token(Token = "0x400027C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9D7B28", Offset = "0x9D7B28")]
		public Leg rightLeg;

		[Token(Token = "0x400027D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9D7B60", Offset = "0x9D7B60")]
		public Locomotion locomotion;

		[Token(Token = "0x400027E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private Leg[] legs;

		[Token(Token = "0x400027F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private Arm[] arms;

		[Token(Token = "0x4000280")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private Vector3 headPosition;

		[Token(Token = "0x4000281")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11C")]
		private Vector3 headDeltaPosition;

		[Token(Token = "0x4000282")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		private Vector3 raycastOriginPelvis;

		[Token(Token = "0x4000283")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x134")]
		private Vector3 lastOffset;

		[Token(Token = "0x4000284")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		private Vector3 debugPos1;

		[Token(Token = "0x4000285")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14C")]
		private Vector3 debugPos2;

		[Token(Token = "0x4000286")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		private Vector3 debugPos3;

		[Token(Token = "0x4000287")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x164")]
		private Vector3 debugPos4;

		[Token(Token = "0x17000092")]
		[HideInInspector]
		public VirtualBone rootBone
		{
			[Token(Token = "0x6000414")]
			[Address(RVA = "0x1885378", Offset = "0x1885378", VA = "0x1885378")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DE4A4", Offset = "0x9DE4A4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000415")]
			[Address(RVA = "0x1887C7C", Offset = "0x1887C7C", VA = "0x1887C7C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DE4B4", Offset = "0x9DE4B4")]
			private set
			{
			}
		}

		[Token(Token = "0x60003FC")]
		[Address(RVA = "0x18834E8", Offset = "0x18834E8", VA = "0x18834E8")]
		public void SetToReferences(VRIK.References references)
		{
		}

		[Token(Token = "0x60003FD")]
		[Address(RVA = "0x18839C4", Offset = "0x18839C4", VA = "0x18839C4")]
		public void GuessHandOrientations(VRIK.References references, bool onlyIfZero)
		{
		}

		[Token(Token = "0x60003FE")]
		[Address(RVA = "0x18837E0", Offset = "0x18837E0", VA = "0x18837E0")]
		public void DefaultAnimationCurves()
		{
		}

		[Token(Token = "0x60003FF")]
		[Address(RVA = "0x18845B4", Offset = "0x18845B4", VA = "0x18845B4")]
		public void AddPositionOffset(PositionOffset positionOffset, Vector3 value)
		{
		}

		[Token(Token = "0x6000400")]
		[Address(RVA = "0x1884750", Offset = "0x1884750", VA = "0x1884750")]
		public void AddRotationOffset(RotationOffset rotationOffset, Vector3 value)
		{
		}

		[Token(Token = "0x6000401")]
		[Address(RVA = "0x18847F4", Offset = "0x18847F4", VA = "0x18847F4")]
		public void AddRotationOffset(RotationOffset rotationOffset, Quaternion value)
		{
		}

		[Token(Token = "0x6000402")]
		[Address(RVA = "0x1884938", Offset = "0x1884938", VA = "0x1884938")]
		public void Reset()
		{
		}

		[Token(Token = "0x6000403")]
		[Address(RVA = "0x1885784", Offset = "0x1885784", VA = "0x1885784", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000404")]
		[Address(RVA = "0x188596C", Offset = "0x188596C", VA = "0x188596C", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x6000405")]
		[Address(RVA = "0x1885B58", Offset = "0x1885B58", VA = "0x1885B58", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x6000406")]
		[Address(RVA = "0x1885BCC", Offset = "0x1885BCC", VA = "0x1885BCC", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x6000407")]
		[Address(RVA = "0x1885C40", Offset = "0x1885C40", VA = "0x1885C40", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000408")]
		[Address(RVA = "0x1885E70", Offset = "0x1885E70", VA = "0x1885E70")]
		private Vector3 GetNormal(Transform[] transforms)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000409")]
		[Address(RVA = "0x1883D70", Offset = "0x1883D70", VA = "0x1883D70")]
		private Vector3 GuessWristToPalmAxis(Transform hand, Transform forearm)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600040A")]
		[Address(RVA = "0x1883F60", Offset = "0x1883F60", VA = "0x1883F60")]
		private Vector3 GuessPalmToThumbAxis(Transform hand, Transform forearm)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600040B")]
		[Address(RVA = "0x188443C", Offset = "0x188443C", VA = "0x188443C")]
		private static Keyframe[] GetSineKeyframes(float mag)
		{
			return null;
		}

		[Token(Token = "0x600040C")]
		[Address(RVA = "0x1884AC8", Offset = "0x1884AC8", VA = "0x1884AC8")]
		private void UpdateSolverTransforms()
		{
		}

		[Token(Token = "0x600040D")]
		[Address(RVA = "0x18861B4", Offset = "0x18861B4", VA = "0x18861B4", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x600040E")]
		[Address(RVA = "0x18861E8", Offset = "0x18861E8", VA = "0x18861E8", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x600040F")]
		[Address(RVA = "0x18877EC", Offset = "0x18877EC", VA = "0x18877EC")]
		private void WriteTransforms()
		{
		}

		[Token(Token = "0x6000410")]
		[Address(RVA = "0x1884CEC", Offset = "0x1884CEC", VA = "0x1884CEC")]
		private void Read(Vector3[] positions, Quaternion[] rotations, bool hasNeck, bool hasShoulders, bool hasToes)
		{
		}

		[Token(Token = "0x6000411")]
		[Address(RVA = "0x1886250", Offset = "0x1886250", VA = "0x1886250")]
		private void Solve()
		{
		}

		[Token(Token = "0x6000412")]
		[Address(RVA = "0x1887AE0", Offset = "0x1887AE0", VA = "0x1887AE0")]
		private Vector3 GetPosition(int index)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000413")]
		[Address(RVA = "0x1887BA8", Offset = "0x1887BA8", VA = "0x1887BA8")]
		private Quaternion GetRotation(int index)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000416")]
		[Address(RVA = "0x1887618", Offset = "0x1887618", VA = "0x1887618")]
		private void Write()
		{
		}

		[Token(Token = "0x6000417")]
		[Address(RVA = "0x188BA70", Offset = "0x188BA70", VA = "0x188BA70")]
		private Vector3 GetPelvisOffset()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000418")]
		[Address(RVA = "0x188C170", Offset = "0x188C170", VA = "0x188C170")]
		public IKSolverVR()
		{
		}
	}
	[Token(Token = "0x200005D")]
	public class TwistRelaxer : MonoBehaviour
	{
		[Token(Token = "0x4000288")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9D7B98", Offset = "0x9D7B98")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9D7B98", Offset = "0x9D7B98")]
		public float weight;

		[Token(Token = "0x4000289")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9D7BEC", Offset = "0x9D7BEC")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9D7BEC", Offset = "0x9D7BEC")]
		public float parentChildCrossfade;

		[Token(Token = "0x400028A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9D7C40", Offset = "0x9D7C40")]
		public Transform parent;

		[Token(Token = "0x400028B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9D7C78", Offset = "0x9D7C78")]
		public Transform child;

		[Token(Token = "0x400028C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9D7CB0", Offset = "0x9D7CB0")]
		public Vector3 twistAxis;

		[Token(Token = "0x400028D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9D7CE8", Offset = "0x9D7CE8")]
		public Vector3 axis;

		[Token(Token = "0x400028E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Vector3 axisRelativeToParentDefault;

		[Token(Token = "0x400028F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private Vector3 axisRelativeToChildDefault;

		[Token(Token = "0x6000419")]
		[Address(RVA = "0xEE6628", Offset = "0xEE6628", VA = "0xEE6628")]
		public void Relax()
		{
		}

		[Token(Token = "0x600041A")]
		[Address(RVA = "0xEE6A14", Offset = "0xEE6A14", VA = "0xEE6A14")]
		private void Start()
		{
		}

		[Token(Token = "0x600041B")]
		[Address(RVA = "0xEE6B80", Offset = "0xEE6B80", VA = "0xEE6B80")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600041C")]
		[Address(RVA = "0xEE6B84", Offset = "0xEE6B84", VA = "0xEE6B84")]
		public TwistRelaxer()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200005E")]
	public class InteractionEffector
	{
		[Token(Token = "0x4000290")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9D7D20", Offset = "0x9D7D20")]
		private FullBodyBipedEffector <effectorType>k__BackingField;

		[Token(Token = "0x4000291")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9D7D30", Offset = "0x9D7D30")]
		private bool <isPaused>k__BackingField;

		[Token(Token = "0x4000292")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9D7D40", Offset = "0x9D7D40")]
		private InteractionObject <interactionObject>k__BackingField;

		[Token(Token = "0x4000293")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Poser poser;

		[Token(Token = "0x4000294")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private IKEffector effector;

		[Token(Token = "0x4000295")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float timer;

		[Token(Token = "0x4000296")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private float length;

		[Token(Token = "0x4000297")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private float weight;

		[Token(Token = "0x4000298")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private float fadeInSpeed;

		[Token(Token = "0x4000299")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private float defaultPositionWeight;

		[Token(Token = "0x400029A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private float defaultRotationWeight;

		[Token(Token = "0x400029B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float defaultPull;

		[Token(Token = "0x400029C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private float defaultReach;

		[Token(Token = "0x400029D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private float defaultPush;

		[Token(Token = "0x400029E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private float defaultPushParent;

		[Token(Token = "0x400029F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private float resetTimer;

		[Token(Token = "0x40002A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private bool positionWeightUsed;

		[Token(Token = "0x40002A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5D")]
		private bool rotationWeightUsed;

		[Token(Token = "0x40002A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5E")]
		private bool pullUsed;

		[Token(Token = "0x40002A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5F")]
		private bool reachUsed;

		[Token(Token = "0x40002A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private bool pushUsed;

		[Token(Token = "0x40002A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x61")]
		private bool pushParentUsed;

		[Token(Token = "0x40002A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x62")]
		private bool pickedUp;

		[Token(Token = "0x40002A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x63")]
		private bool defaults;

		[Token(Token = "0x40002A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private bool pickUpOnPostFBBIK;

		[Token(Token = "0x40002A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Vector3 pickUpPosition;

		[Token(Token = "0x40002AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private Vector3 pausePositionRelative;

		[Token(Token = "0x40002AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Quaternion pickUpRotation;

		[Token(Token = "0x40002AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Quaternion pauseRotationRelative;

		[Token(Token = "0x40002AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private InteractionTarget interactionTarget;

		[Token(Token = "0x40002AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Transform target;

		[Token(Token = "0x40002AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private List<bool> triggered;

		[Token(Token = "0x40002B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private InteractionSystem interactionSystem;

		[Token(Token = "0x40002B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private bool started;

		[Token(Token = "0x17000093")]
		public FullBodyBipedEffector effectorType
		{
			[Token(Token = "0x600041D")]
			[Address(RVA = "0xED0BEC", Offset = "0xED0BEC", VA = "0xED0BEC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DE4C4", Offset = "0x9DE4C4")]
			get
			{
				return default(FullBodyBipedEffector);
			}
			[Token(Token = "0x600041E")]
			[Address(RVA = "0xED0BF4", Offset = "0xED0BF4", VA = "0xED0BF4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DE4D4", Offset = "0x9DE4D4")]
			private set
			{
			}
		}

		[Token(Token = "0x17000094")]
		public bool isPaused
		{
			[Token(Token = "0x600041F")]
			[Address(RVA = "0xED0BFC", Offset = "0xED0BFC", VA = "0xED0BFC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DE4E4", Offset = "0x9DE4E4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000420")]
			[Address(RVA = "0xED0C04", Offset = "0xED0C04", VA = "0xED0C04")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DE4F4", Offset = "0x9DE4F4")]
			private set
			{
			}
		}

		[Token(Token = "0x17000095")]
		public InteractionObject interactionObject
		{
			[Token(Token = "0x6000421")]
			[Address(RVA = "0xED0C10", Offset = "0xED0C10", VA = "0xED0C10")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DE504", Offset = "0x9DE504")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000422")]
			[Address(RVA = "0xED0C18", Offset = "0xED0C18", VA = "0xED0C18")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DE514", Offset = "0x9DE514")]
			private set
			{
			}
		}

		[Token(Token = "0x17000096")]
		public bool inInteraction
		{
			[Token(Token = "0x6000423")]
			[Address(RVA = "0xED0C20", Offset = "0xED0C20", VA = "0xED0C20")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000097")]
		public float progress
		{
			[Token(Token = "0x600042C")]
			[Address(RVA = "0xED44A8", Offset = "0xED44A8", VA = "0xED44A8")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x6000424")]
		[Address(RVA = "0xED0C90", Offset = "0xED0C90", VA = "0xED0C90")]
		public InteractionEffector(FullBodyBipedEffector effectorType)
		{
		}

		[Token(Token = "0x6000425")]
		[Address(RVA = "0xED0D14", Offset = "0xED0D14", VA = "0xED0D14")]
		public void Initiate(InteractionSystem interactionSystem)
		{
		}

		[Token(Token = "0x6000426")]
		[Address(RVA = "0xED0DF0", Offset = "0xED0DF0", VA = "0xED0DF0")]
		private void StoreDefaults()
		{
		}

		[Token(Token = "0x6000427")]
		[Address(RVA = "0xED1024", Offset = "0xED1024", VA = "0xED1024")]
		public bool ResetToDefaults(float speed)
		{
			return default(bool);
		}

		[Token(Token = "0x6000428")]
		[Address(RVA = "0xED15A0", Offset = "0xED15A0", VA = "0xED15A0")]
		public bool Pause()
		{
			return default(bool);
		}

		[Token(Token = "0x6000429")]
		[Address(RVA = "0xED19B8", Offset = "0xED19B8", VA = "0xED19B8")]
		public bool Resume()
		{
			return default(bool);
		}

		[Token(Token = "0x600042A")]
		[Address(RVA = "0xED1A44", Offset = "0xED1A44", VA = "0xED1A44")]
		public bool Start(InteractionObject interactionObject, string tag, float fadeInTime, bool interrupt)
		{
			return default(bool);
		}

		[Token(Token = "0x600042B")]
		[Address(RVA = "0xED2850", Offset = "0xED2850", VA = "0xED2850")]
		public void Update(Transform root, float speed)
		{
		}

		[Token(Token = "0x600042D")]
		[Address(RVA = "0xED37A4", Offset = "0xED37A4", VA = "0xED37A4")]
		private void TriggerUntriggeredEvents(bool checkTime, out bool pickUp, out bool pause)
		{
		}

		[Token(Token = "0x600042E")]
		[Address(RVA = "0xED3C68", Offset = "0xED3C68", VA = "0xED3C68")]
		private void PickUp(Transform root)
		{
		}

		[Token(Token = "0x600042F")]
		[Address(RVA = "0xED4308", Offset = "0xED4308", VA = "0xED4308")]
		public bool Stop()
		{
			return default(bool);
		}

		[Token(Token = "0x6000430")]
		[Address(RVA = "0xED49BC", Offset = "0xED49BC", VA = "0xED49BC")]
		public void OnPostFBBIK()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200005F")]
	public class InteractionLookAt
	{
		[Token(Token = "0x40002B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9D7D50", Offset = "0x9D7D50")]
		public LookAtIK ik;

		[Token(Token = "0x40002B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9D7D88", Offset = "0x9D7D88")]
		public float lerpSpeed;

		[Token(Token = "0x40002B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9D7DC0", Offset = "0x9D7DC0")]
		public float weightSpeed;

		[Token(Token = "0x40002B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[HideInInspector]
		public bool isPaused;

		[Token(Token = "0x40002B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Transform lookAtTarget;

		[Token(Token = "0x40002B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float stopLookTime;

		[Token(Token = "0x40002B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private float weight;

		[Token(Token = "0x40002B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private bool firstFBBIKSolve;

		[Token(Token = "0x6000431")]
		[Address(RVA = "0xED4D24", Offset = "0xED4D24", VA = "0xED4D24")]
		public void Look(Transform target, float time)
		{
		}

		[Token(Token = "0x6000432")]
		[Address(RVA = "0xED4F30", Offset = "0xED4F30", VA = "0xED4F30")]
		public void Update()
		{
		}

		[Token(Token = "0x6000433")]
		[Address(RVA = "0xED5584", Offset = "0xED5584", VA = "0xED5584")]
		public void SolveSpine()
		{
		}

		[Token(Token = "0x6000434")]
		[Address(RVA = "0xED5718", Offset = "0xED5718", VA = "0xED5718")]
		public void SolveHead()
		{
		}

		[Token(Token = "0x6000435")]
		[Address(RVA = "0xED583C", Offset = "0xED583C", VA = "0xED583C")]
		public InteractionLookAt()
		{
		}
	}
	[Token(Token = "0x2000060")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x9D53E4", Offset = "0x9D53E4")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x9D53E4", Offset = "0x9D53E4")]
	public class InteractionObject : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x200015A")]
		public class InteractionEvent
		{
			[Token(Token = "0x4000921")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9DBB1C", Offset = "0x9DBB1C")]
			public float time;

			[Token(Token = "0x4000922")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9DBB54", Offset = "0x9DBB54")]
			public bool pause;

			[Token(Token = "0x4000923")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x15")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9DBB8C", Offset = "0x9DBB8C")]
			public bool pickUp;

			[Token(Token = "0x4000924")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9DBBC4", Offset = "0x9DBBC4")]
			public AnimatorEvent[] animations;

			[Token(Token = "0x4000925")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9DBBFC", Offset = "0x9DBBFC")]
			public Message[] messages;

			[Token(Token = "0x6000A87")]
			[Address(RVA = "0xED44E4", Offset = "0xED44E4", VA = "0xED44E4")]
			public void Activate(Transform t)
			{
			}

			[Token(Token = "0x6000A88")]
			[Address(RVA = "0xED7054", Offset = "0xED7054", VA = "0xED7054")]
			public InteractionEvent()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200015B")]
		public class Message
		{
			[Token(Token = "0x4000926")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9DBC34", Offset = "0x9DBC34")]
			public string function;

			[Token(Token = "0x4000927")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9DBC6C", Offset = "0x9DBC6C")]
			public GameObject recipient;

			[Token(Token = "0x4000928")]
			private const string empty = "";

			[Token(Token = "0x6000A89")]
			[Address(RVA = "0xED6F58", Offset = "0xED6F58", VA = "0xED6F58")]
			public void Send(Transform t)
			{
			}

			[Token(Token = "0x6000A8A")]
			[Address(RVA = "0xED705C", Offset = "0xED705C", VA = "0xED705C")]
			public Message()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200015C")]
		public class AnimatorEvent
		{
			[Token(Token = "0x4000929")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9DBCA4", Offset = "0x9DBCA4")]
			public Animator animator;

			[Token(Token = "0x400092A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9DBCDC", Offset = "0x9DBCDC")]
			public Animation animation;

			[Token(Token = "0x400092B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9DBD14", Offset = "0x9DBD14")]
			public string animationState;

			[Token(Token = "0x400092C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9DBD4C", Offset = "0x9DBD4C")]
			public float crossfadeTime;

			[Token(Token = "0x400092D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9DBD84", Offset = "0x9DBD84")]
			public int layer;

			[Token(Token = "0x400092E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9DBDBC", Offset = "0x9DBDBC")]
			public bool resetNormalizedTime;

			[Token(Token = "0x400092F")]
			private const string empty = "";

			[Token(Token = "0x6000A8B")]
			[Address(RVA = "0xED6C34", Offset = "0xED6C34", VA = "0xED6C34")]
			public void Activate(bool pickUp)
			{
			}

			[Token(Token = "0x6000A8C")]
			[Address(RVA = "0xED6D30", Offset = "0xED6D30", VA = "0xED6D30")]
			private void Activate(Animator animator)
			{
			}

			[Token(Token = "0x6000A8D")]
			[Address(RVA = "0xED6E18", Offset = "0xED6E18", VA = "0xED6E18")]
			private void Activate(Animation animation)
			{
			}

			[Token(Token = "0x6000A8E")]
			[Address(RVA = "0xED6F44", Offset = "0xED6F44", VA = "0xED6F44")]
			public AnimatorEvent()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200015D")]
		public class WeightCurve
		{
			[Serializable]
			[Token(Token = "0x20001B3")]
			public enum Type
			{
				[Token(Token = "0x4000A7F")]
				PositionWeight,
				[Token(Token = "0x4000A80")]
				RotationWeight,
				[Token(Token = "0x4000A81")]
				PositionOffsetX,
				[Token(Token = "0x4000A82")]
				PositionOffsetY,
				[Token(Token = "0x4000A83")]
				PositionOffsetZ,
				[Token(Token = "0x4000A84")]
				Pull,
				[Token(Token = "0x4000A85")]
				Reach,
				[Token(Token = "0x4000A86")]
				RotateBoneWeight,
				[Token(Token = "0x4000A87")]
				Push,
				[Token(Token = "0x4000A88")]
				PushParent,
				[Token(Token = "0x4000A89")]
				PoserWeight
			}

			[Token(Token = "0x4000930")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9DBDF4", Offset = "0x9DBDF4")]
			public Type type;

			[Token(Token = "0x4000931")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9DBE2C", Offset = "0x9DBE2C")]
			public AnimationCurve curve;

			[Token(Token = "0x6000A8F")]
			[Address(RVA = "0xED6198", Offset = "0xED6198", VA = "0xED6198")]
			public float GetValue(float timer)
			{
				return default(float);
			}

			[Token(Token = "0x6000A90")]
			[Address(RVA = "0xED7074", Offset = "0xED7074", VA = "0xED7074")]
			public WeightCurve()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200015E")]
		public class Multiplier
		{
			[Token(Token = "0x4000932")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9DBE64", Offset = "0x9DBE64")]
			public WeightCurve.Type curve;

			[Token(Token = "0x4000933")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9DBE9C", Offset = "0x9DBE9C")]
			public float multiplier;

			[Token(Token = "0x4000934")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9DBED4", Offset = "0x9DBED4")]
			public WeightCurve.Type result;

			[Token(Token = "0x6000A91")]
			[Address(RVA = "0xED6A3C", Offset = "0xED6A3C", VA = "0xED6A3C")]
			public float GetValue(WeightCurve weightCurve, float timer)
			{
				return default(float);
			}

			[Token(Token = "0x6000A92")]
			[Address(RVA = "0xED7064", Offset = "0xED7064", VA = "0xED7064")]
			public Multiplier()
			{
			}
		}

		[Token(Token = "0x40002BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9D7E08", Offset = "0x9D7E08")]
		public Transform otherLookAtTarget;

		[Token(Token = "0x40002BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9D7E40", Offset = "0x9D7E40")]
		public Transform otherTargetsRoot;

		[Token(Token = "0x40002BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9D7E78", Offset = "0x9D7E78")]
		public Transform positionOffsetSpace;

		[Token(Token = "0x40002BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public WeightCurve[] weightCurves;

		[Token(Token = "0x40002BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Multiplier[] multipliers;

		[Token(Token = "0x40002BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public InteractionEvent[] events;

		[Token(Token = "0x40002C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9D7EB0", Offset = "0x9D7EB0")]
		private float <length>k__BackingField;

		[Token(Token = "0x40002C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9D7EC0", Offset = "0x9D7EC0")]
		private InteractionSystem <lastUsedInteractionSystem>k__BackingField;

		[Token(Token = "0x40002C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private InteractionTarget[] targets;

		[Token(Token = "0x17000098")]
		public float length
		{
			[Token(Token = "0x600043C")]
			[Address(RVA = "0xED2238", Offset = "0xED2238", VA = "0xED2238")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DE674", Offset = "0x9DE674")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600043D")]
			[Address(RVA = "0xED5A18", Offset = "0xED5A18", VA = "0xED5A18")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DE684", Offset = "0x9DE684")]
			private set
			{
			}
		}

		[Token(Token = "0x17000099")]
		public InteractionSystem lastUsedInteractionSystem
		{
			[Token(Token = "0x600043E")]
			[Address(RVA = "0xED5A20", Offset = "0xED5A20", VA = "0xED5A20")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DE694", Offset = "0x9DE694")]
			get
			{
				return null;
			}
			[Token(Token = "0x600043F")]
			[Address(RVA = "0xED5A28", Offset = "0xED5A28", VA = "0xED5A28")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DE6A4", Offset = "0x9DE6A4")]
			private set
			{
			}
		}

		[Token(Token = "0x1700009A")]
		public Transform lookAtTarget
		{
			[Token(Token = "0x6000441")]
			[Address(RVA = "0xED5D40", Offset = "0xED5D40", VA = "0xED5D40")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700009B")]
		public Transform targetsRoot
		{
			[Token(Token = "0x6000449")]
			[Address(RVA = "0xED4860", Offset = "0xED4860", VA = "0xED4860")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000436")]
		[Address(RVA = "0xED5850", Offset = "0xED5850", VA = "0xED5850")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9DE524", Offset = "0x9DE524")]
		private void OpenTutorial1()
		{
		}

		[Token(Token = "0x6000437")]
		[Address(RVA = "0xED589C", Offset = "0xED589C", VA = "0xED589C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9DE55C", Offset = "0x9DE55C")]
		private void OpenTutorial2()
		{
		}

		[Token(Token = "0x6000438")]
		[Address(RVA = "0xED58E8", Offset = "0xED58E8", VA = "0xED58E8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9DE594", Offset = "0x9DE594")]
		private void OpenTutorial3()
		{
		}

		[Token(Token = "0x6000439")]
		[Address(RVA = "0xED5934", Offset = "0xED5934", VA = "0xED5934")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9DE5CC", Offset = "0x9DE5CC")]
		private void OpenTutorial4()
		{
		}

		[Token(Token = "0x600043A")]
		[Address(RVA = "0xED5980", Offset = "0xED5980", VA = "0xED5980")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9DE604", Offset = "0x9DE604")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600043B")]
		[Address(RVA = "0xED59CC", Offset = "0xED59CC", VA = "0xED59CC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9DE63C", Offset = "0x9DE63C")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000440")]
		[Address(RVA = "0xED5A30", Offset = "0xED5A30", VA = "0xED5A30")]
		public void Initiate()
		{
		}

		[Token(Token = "0x6000442")]
		[Address(RVA = "0xED5DD0", Offset = "0xED5DD0", VA = "0xED5DD0")]
		public InteractionTarget GetTarget(FullBodyBipedEffector effectorType, InteractionSystem interactionSystem)
		{
			return null;
		}

		[Token(Token = "0x6000443")]
		[Address(RVA = "0xED2138", Offset = "0xED2138", VA = "0xED2138")]
		public bool CurveUsed(WeightCurve.Type type)
		{
			return default(bool);
		}

		[Token(Token = "0x6000444")]
		[Address(RVA = "0xED5F9C", Offset = "0xED5F9C", VA = "0xED5F9C")]
		public InteractionTarget[] GetTargets()
		{
			return null;
		}

		[Token(Token = "0x6000445")]
		[Address(RVA = "0xED1F58", Offset = "0xED1F58", VA = "0xED1F58")]
		public Transform GetTarget(FullBodyBipedEffector effectorType, string tag)
		{
			return null;
		}

		[Token(Token = "0x6000446")]
		[Address(RVA = "0xED2130", Offset = "0xED2130", VA = "0xED2130")]
		public void OnStartInteraction(InteractionSystem interactionSystem)
		{
		}

		[Token(Token = "0x6000447")]
		[Address(RVA = "0xED313C", Offset = "0xED313C", VA = "0xED313C")]
		public void Apply(IKSolverFullBodyBiped solver, FullBodyBipedEffector effector, InteractionTarget target, float timer, float weight)
		{
		}

		[Token(Token = "0x6000448")]
		[Address(RVA = "0xED3F28", Offset = "0xED3F28", VA = "0xED3F28")]
		public float GetValue(WeightCurve.Type weightCurveType, InteractionTarget target, float timer)
		{
			return default(float);
		}

		[Token(Token = "0x600044A")]
		[Address(RVA = "0xED6A88", Offset = "0xED6A88", VA = "0xED6A88")]
		private void Awake()
		{
		}

		[Token(Token = "0x600044B")]
		[Address(RVA = "0xED61D8", Offset = "0xED61D8", VA = "0xED61D8")]
		private void Apply(IKSolverFullBodyBiped solver, FullBodyBipedEffector effector, WeightCurve.Type type, float value, float weight)
		{
		}

		[Token(Token = "0x600044C")]
		[Address(RVA = "0xED5FA4", Offset = "0xED5FA4", VA = "0xED5FA4")]
		private Transform GetTarget(FullBodyBipedEffector effectorType)
		{
			return null;
		}

		[Token(Token = "0x600044D")]
		[Address(RVA = "0xED698C", Offset = "0xED698C", VA = "0xED698C")]
		private int GetWeightCurveIndex(WeightCurve.Type weightCurveType)
		{
			return default(int);
		}

		[Token(Token = "0x600044E")]
		[Address(RVA = "0xED6A8C", Offset = "0xED6A8C", VA = "0xED6A8C")]
		private int GetMultiplierIndex(WeightCurve.Type weightCurveType)
		{
			return default(int);
		}

		[Token(Token = "0x600044F")]
		[Address(RVA = "0xED6B3C", Offset = "0xED6B3C", VA = "0xED6B3C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9DE6B4", Offset = "0x9DE6B4")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x6000450")]
		[Address(RVA = "0xED6B88", Offset = "0xED6B88", VA = "0xED6B88")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9DE6EC", Offset = "0x9DE6EC")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000451")]
		[Address(RVA = "0xED6BD4", Offset = "0xED6BD4", VA = "0xED6BD4")]
		public InteractionObject()
		{
		}
	}
	[Token(Token = "0x2000061")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x9D5444", Offset = "0x9D5444")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x9D5444", Offset = "0x9D5444")]
	public class InteractionSystem : MonoBehaviour
	{
		[Token(Token = "0x200015F")]
		public delegate void InteractionDelegate(FullBodyBipedEffector effectorType, InteractionObject interactionObject);

		[Token(Token = "0x2000160")]
		public delegate void InteractionEventDelegate(FullBodyBipedEffector effectorType, InteractionObject interactionObject, InteractionObject.InteractionEvent interactionEvent);

		[Token(Token = "0x40002C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9D7ED0", Offset = "0x9D7ED0")]
		public string targetTag;

		[Token(Token = "0x40002C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9D7F08", Offset = "0x9D7F08")]
		public float fadeInTime;

		[Token(Token = "0x40002C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9D7F40", Offset = "0x9D7F40")]
		public float speed;

		[Token(Token = "0x40002C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9D7F78", Offset = "0x9D7F78")]
		public float resetToDefaultsSpeed;

		[Token(Token = "0x40002C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9D7FB0", Offset = "0x9D7FB0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9D7FB0", Offset = "0x9D7FB0")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x9D7FB0", Offset = "0x9D7FB0")]
		public Collider characterCollider;

		[Token(Token = "0x40002C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9D8034", Offset = "0x9D8034")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x9D8034", Offset = "0x9D8034")]
		public Transform FPSCamera;

		[Token(Token = "0x40002C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9D8094", Offset = "0x9D8094")]
		public LayerMask camRaycastLayers;

		[Token(Token = "0x40002CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9D80CC", Offset = "0x9D80CC")]
		public float camRaycastDistance;

		[Token(Token = "0x40002CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9D8104", Offset = "0x9D8104")]
		private List<InteractionTrigger> <triggersInRange>k__BackingField;

		[Token(Token = "0x40002CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private List<InteractionTrigger> inContact;

		[Token(Token = "0x40002CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private List<int> bestRangeIndexes;

		[Token(Token = "0x40002CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public InteractionDelegate OnInteractionStart;

		[Token(Token = "0x40002CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public InteractionDelegate OnInteractionPause;

		[Token(Token = "0x40002D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public InteractionDelegate OnInteractionPickUp;

		[Token(Token = "0x40002D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public InteractionDelegate OnInteractionResume;

		[Token(Token = "0x40002D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public InteractionDelegate OnInteractionStop;

		[Token(Token = "0x40002D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public InteractionEventDelegate OnInteractionEvent;

		[Token(Token = "0x40002D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public RaycastHit raycastHit;

		[Token(Token = "0x40002D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x9D8114", Offset = "0x9D8114")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9D8114", Offset = "0x9D8114")]
		[SerializeField]
		private FullBodyBipedIK fullBody;

		[Token(Token = "0x40002D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9D8174", Offset = "0x9D8174")]
		public InteractionLookAt lookAt;

		[Token(Token = "0x40002D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private InteractionEffector[] interactionEffectors;

		[Token(Token = "0x40002D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private bool initiated;

		[Token(Token = "0x40002D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private Collider lastCollider;

		[Token(Token = "0x40002DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private Collider c;

		[Token(Token = "0x1700009C")]
		public bool inInteraction
		{
			[Token(Token = "0x6000458")]
			[Address(RVA = "0xED7244", Offset = "0xED7244", VA = "0xED7244")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700009D")]
		public FullBodyBipedIK ik
		{
			[Token(Token = "0x6000472")]
			[Address(RVA = "0xED0DE8", Offset = "0xED0DE8", VA = "0xED0DE8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000473")]
			[Address(RVA = "0xED9BB4", Offset = "0xED9BB4", VA = "0xED9BB4")]
			set
			{
			}
		}

		[Token(Token = "0x1700009E")]
		public List<InteractionTrigger> triggersInRange
		{
			[Token(Token = "0x6000474")]
			[Address(RVA = "0xED8728", Offset = "0xED8728", VA = "0xED8728")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DE874", Offset = "0x9DE874")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000475")]
			[Address(RVA = "0xED9BBC", Offset = "0xED9BBC", VA = "0xED9BBC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DE884", Offset = "0x9DE884")]
			private set
			{
			}
		}

		[Token(Token = "0x6000452")]
		[Address(RVA = "0xED707C", Offset = "0xED707C", VA = "0xED707C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9DE724", Offset = "0x9DE724")]
		private void OpenTutorial1()
		{
		}

		[Token(Token = "0x6000453")]
		[Address(RVA = "0xED70C8", Offset = "0xED70C8", VA = "0xED70C8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9DE75C", Offset = "0x9DE75C")]
		private void OpenTutorial2()
		{
		}

		[Token(Token = "0x6000454")]
		[Address(RVA = "0xED7114", Offset = "0xED7114", VA = "0xED7114")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9DE794", Offset = "0x9DE794")]
		private void OpenTutorial3()
		{
		}

		[Token(Token = "0x6000455")]
		[Address(RVA = "0xED7160", Offset = "0xED7160", VA = "0xED7160")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9DE7CC", Offset = "0x9DE7CC")]
		private void OpenTutorial4()
		{
		}

		[Token(Token = "0x6000456")]
		[Address(RVA = "0xED71AC", Offset = "0xED71AC", VA = "0xED71AC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9DE804", Offset = "0x9DE804")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000457")]
		[Address(RVA = "0xED71F8", Offset = "0xED71F8", VA = "0xED71F8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9DE83C", Offset = "0x9DE83C")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000459")]
		[Address(RVA = "0xED7420", Offset = "0xED7420", VA = "0xED7420")]
		public bool IsInInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x600045A")]
		[Address(RVA = "0xED7578", Offset = "0xED7578", VA = "0xED7578")]
		public bool IsPaused(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x600045B")]
		[Address(RVA = "0xED76D0", Offset = "0xED76D0", VA = "0xED76D0")]
		public bool IsPaused()
		{
			return default(bool);
		}

		[Token(Token = "0x600045C")]
		[Address(RVA = "0xED77CC", Offset = "0xED77CC", VA = "0xED77CC")]
		public bool IsInSync()
		{
			return default(bool);
		}

		[Token(Token = "0x600045D")]
		[Address(RVA = "0xED794C", Offset = "0xED794C", VA = "0xED794C")]
		public bool StartInteraction(FullBodyBipedEffector effectorType, InteractionObject interactionObject, bool interrupt)
		{
			return default(bool);
		}

		[Token(Token = "0x600045E")]
		[Address(RVA = "0xED7AF0", Offset = "0xED7AF0", VA = "0xED7AF0")]
		public bool PauseInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x600045F")]
		[Address(RVA = "0xED7C00", Offset = "0xED7C00", VA = "0xED7C00")]
		public bool ResumeInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x6000460")]
		[Address(RVA = "0xED7D10", Offset = "0xED7D10", VA = "0xED7D10")]
		public bool StopInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x6000461")]
		[Address(RVA = "0xED7E20", Offset = "0xED7E20", VA = "0xED7E20")]
		public void PauseAll()
		{
		}

		[Token(Token = "0x6000462")]
		[Address(RVA = "0xED7EC4", Offset = "0xED7EC4", VA = "0xED7EC4")]
		public void ResumeAll()
		{
		}

		[Token(Token = "0x6000463")]
		[Address(RVA = "0xED7F68", Offset = "0xED7F68", VA = "0xED7F68")]
		public void StopAll()
		{
		}

		[Token(Token = "0x6000464")]
		[Address(RVA = "0xED8000", Offset = "0xED8000", VA = "0xED8000")]
		public InteractionObject GetInteractionObject(FullBodyBipedEffector effectorType)
		{
			return null;
		}

		[Token(Token = "0x6000465")]
		[Address(RVA = "0xED8100", Offset = "0xED8100", VA = "0xED8100")]
		public float GetProgress(FullBodyBipedEffector effectorType)
		{
			return default(float);
		}

		[Token(Token = "0x6000466")]
		[Address(RVA = "0xED8228", Offset = "0xED8228", VA = "0xED8228")]
		public float GetMinActiveProgress()
		{
			return default(float);
		}

		[Token(Token = "0x6000467")]
		[Address(RVA = "0xED8358", Offset = "0xED8358", VA = "0xED8358")]
		public bool TriggerInteraction(int index, bool interrupt)
		{
			return default(bool);
		}

		[Token(Token = "0x6000468")]
		[Address(RVA = "0xED8730", Offset = "0xED8730", VA = "0xED8730")]
		public bool TriggerInteraction(int index, bool interrupt, out InteractionObject interactionObject)
		{
			return default(bool);
		}

		[Token(Token = "0x6000469")]
		[Address(RVA = "0xED89E0", Offset = "0xED89E0", VA = "0xED89E0")]
		public bool TriggerInteraction(int index, bool interrupt, out InteractionTarget interactionTarget)
		{
			return default(bool);
		}

		[Token(Token = "0x600046A")]
		[Address(RVA = "0xED8DA0", Offset = "0xED8DA0", VA = "0xED8DA0")]
		public InteractionTrigger.Range GetClosestInteractionRange()
		{
			return null;
		}

		[Token(Token = "0x600046B")]
		[Address(RVA = "0xED9144", Offset = "0xED9144", VA = "0xED9144")]
		public InteractionObject GetClosestInteractionObjectInRange()
		{
			return null;
		}

		[Token(Token = "0x600046C")]
		[Address(RVA = "0xED91A0", Offset = "0xED91A0", VA = "0xED91A0")]
		public InteractionTarget GetClosestInteractionTargetInRange()
		{
			return null;
		}

		[Token(Token = "0x600046D")]
		[Address(RVA = "0xED9298", Offset = "0xED9298", VA = "0xED9298")]
		public InteractionObject[] GetClosestInteractionObjectsInRange()
		{
			return null;
		}

		[Token(Token = "0x600046E")]
		[Address(RVA = "0xED9410", Offset = "0xED9410", VA = "0xED9410")]
		public InteractionTarget[] GetClosestInteractionTargetsInRange()
		{
			return null;
		}

		[Token(Token = "0x600046F")]
		[Address(RVA = "0xED95C8", Offset = "0xED95C8", VA = "0xED95C8")]
		public bool TriggerEffectorsReady(int index)
		{
			return default(bool);
		}

		[Token(Token = "0x6000470")]
		[Address(RVA = "0xED9A60", Offset = "0xED9A60", VA = "0xED9A60")]
		public InteractionTrigger.Range GetTriggerRange(int index)
		{
			return null;
		}

		[Token(Token = "0x6000471")]
		[Address(RVA = "0xED8ED8", Offset = "0xED8ED8", VA = "0xED8ED8")]
		public int GetClosestTriggerIndex()
		{
			return default(int);
		}

		[Token(Token = "0x6000476")]
		[Address(RVA = "0xED9BC4", Offset = "0xED9BC4", VA = "0xED9BC4", Slot = "4")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x6000477")]
		[Address(RVA = "0xEDA308", Offset = "0xEDA308", VA = "0xEDA308")]
		private void InteractionPause(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x6000478")]
		[Address(RVA = "0xEDA338", Offset = "0xEDA338", VA = "0xEDA338")]
		private void InteractionResume(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x6000479")]
		[Address(RVA = "0xEDA364", Offset = "0xEDA364", VA = "0xEDA364")]
		private void InteractionStop(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x600047A")]
		[Address(RVA = "0xEDA390", Offset = "0xEDA390", VA = "0xEDA390")]
		private void LookAtInteraction(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x600047B")]
		[Address(RVA = "0xEDA414", Offset = "0xEDA414", VA = "0xEDA414")]
		public void OnTriggerEnter(Collider c)
		{
		}

		[Token(Token = "0x600047C")]
		[Address(RVA = "0xEDA51C", Offset = "0xEDA51C", VA = "0xEDA51C")]
		public void OnTriggerExit(Collider c)
		{
		}

		[Token(Token = "0x600047D")]
		[Address(RVA = "0xEDA5F8", Offset = "0xEDA5F8", VA = "0xEDA5F8")]
		private bool ContactIsInRange(int index, out int bestRangeIndex)
		{
			return default(bool);
		}

		[Token(Token = "0x600047E")]
		[Address(RVA = "0xEDA9C4", Offset = "0xEDA9C4", VA = "0xEDA9C4")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x600047F")]
		[Address(RVA = "0xEDAAB0", Offset = "0xEDAAB0", VA = "0xEDAAB0")]
		private void Update()
		{
		}

		[Token(Token = "0x6000480")]
		[Address(RVA = "0xEDAD78", Offset = "0xEDAD78", VA = "0xEDAD78")]
		private void Raycasting()
		{
		}

		[Token(Token = "0x6000481")]
		[Address(RVA = "0xEDA048", Offset = "0xEDA048", VA = "0xEDA048")]
		private void UpdateTriggerEventBroadcasting()
		{
		}

		[Token(Token = "0x6000482")]
		[Address(RVA = "0xEDAECC", Offset = "0xEDAECC", VA = "0xEDAECC")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000483")]
		[Address(RVA = "0xEDB060", Offset = "0xEDB060", VA = "0xEDB060")]
		private void OnPreFBBIK()
		{
		}

		[Token(Token = "0x6000484")]
		[Address(RVA = "0xEDB108", Offset = "0xEDB108", VA = "0xEDB108")]
		private void OnPostFBBIK()
		{
		}

		[Token(Token = "0x6000485")]
		[Address(RVA = "0xEDB230", Offset = "0xEDB230", VA = "0xEDB230")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000486")]
		[Address(RVA = "0xED7340", Offset = "0xED7340", VA = "0xED7340")]
		private bool IsValid(bool log)
		{
			return default(bool);
		}

		[Token(Token = "0x6000487")]
		[Address(RVA = "0xED85FC", Offset = "0xED85FC", VA = "0xED85FC")]
		private bool TriggerIndexIsValid(int index)
		{
			return default(bool);
		}

		[Token(Token = "0x6000488")]
		[Address(RVA = "0xEDB568", Offset = "0xEDB568", VA = "0xEDB568")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9DE894", Offset = "0x9DE894")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x6000489")]
		[Address(RVA = "0xEDB5B4", Offset = "0xEDB5B4", VA = "0xEDB5B4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9DE8CC", Offset = "0x9DE8CC")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x600048A")]
		[Address(RVA = "0xEDB600", Offset = "0xEDB600", VA = "0xEDB600")]
		public InteractionSystem()
		{
		}
	}
	[Token(Token = "0x2000062")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x9D54A4", Offset = "0x9D54A4")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x9D54A4", Offset = "0x9D54A4")]
	public class InteractionTarget : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000161")]
		public class Multiplier
		{
			[Token(Token = "0x4000935")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9DBF0C", Offset = "0x9DBF0C")]
			public InteractionObject.WeightCurve.Type curve;

			[Token(Token = "0x4000936")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9DBF44", Offset = "0x9DBF44")]
			public float multiplier;

			[Token(Token = "0x6000A9B")]
			[Address(RVA = "0xEDC03C", Offset = "0xEDC03C", VA = "0xEDC03C")]
			public Multiplier()
			{
			}
		}

		[Token(Token = "0x40002DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9D81AC", Offset = "0x9D81AC")]
		public FullBodyBipedEffector effectorType;

		[Token(Token = "0x40002DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9D81E4", Offset = "0x9D81E4")]
		public Multiplier[] multipliers;

		[Token(Token = "0x40002DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9D821C", Offset = "0x9D821C")]
		public float interactionSpeedMlp;

		[Token(Token = "0x40002DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9D8254", Offset = "0x9D8254")]
		public Transform pivot;

		[Token(Token = "0x40002DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9D828C", Offset = "0x9D828C")]
		public Vector3 twistAxis;

		[Token(Token = "0x40002E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9D82C4", Offset = "0x9D82C4")]
		public float twistWeight;

		[Token(Token = "0x40002E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9D82FC", Offset = "0x9D82FC")]
		public float swingWeight;

		[Token(Token = "0x40002E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9D8334", Offset = "0x9D8334")]
		public bool rotateOnce;

		[Token(Token = "0x40002E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Quaternion defaultLocalRotation;

		[Token(Token = "0x40002E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Transform lastPivot;

		[Token(Token = "0x600048B")]
		[Address(RVA = "0xEDBBC4", Offset = "0xEDBBC4", VA = "0xEDBBC4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9DE904", Offset = "0x9DE904")]
		private void OpenTutorial1()
		{
		}

		[Token(Token = "0x600048C")]
		[Address(RVA = "0xEDBC10", Offset = "0xEDBC10", VA = "0xEDBC10")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9DE93C", Offset = "0x9DE93C")]
		private void OpenTutorial2()
		{
		}

		[Token(Token = "0x600048D")]
		[Address(RVA = "0xEDBC5C", Offset = "0xEDBC5C", VA = "0xEDBC5C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9DE974", Offset = "0x9DE974")]
		private void OpenTutorial3()
		{
		}

		[Token(Token = "0x600048E")]
		[Address(RVA = "0xEDBCA8", Offset = "0xEDBCA8", VA = "0xEDBCA8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9DE9AC", Offset = "0x9DE9AC")]
		private void OpenTutorial4()
		{
		}

		[Token(Token = "0x600048F")]
		[Address(RVA = "0xEDBCF4", Offset = "0xEDBCF4", VA = "0xEDBCF4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9DE9E4", Offset = "0x9DE9E4")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000490")]
		[Address(RVA = "0xEDBD40", Offset = "0xEDBD40", VA = "0xEDBD40")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9DEA1C", Offset = "0x9DEA1C")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000491")]
		[Address(RVA = "0xED6098", Offset = "0xED6098", VA = "0xED6098")]
		public float GetValue(InteractionObject.WeightCurve.Type curveType)
		{
			return default(float);
		}

		[Token(Token = "0x6000492")]
		[Address(RVA = "0xED48F0", Offset = "0xED48F0", VA = "0xED48F0")]
		public void ResetRotation()
		{
		}

		[Token(Token = "0x6000493")]
		[Address(RVA = "0xED2240", Offset = "0xED2240", VA = "0xED2240")]
		public void RotateTo(Vector3 position)
		{
		}

		[Token(Token = "0x6000494")]
		[Address(RVA = "0xEDBF18", Offset = "0xEDBF18", VA = "0xEDBF18")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9DEA54", Offset = "0x9DEA54")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x6000495")]
		[Address(RVA = "0xEDBF64", Offset = "0xEDBF64", VA = "0xEDBF64")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9DEA8C", Offset = "0x9DEA8C")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000496")]
		[Address(RVA = "0xEDBFB0", Offset = "0xEDBFB0", VA = "0xEDBFB0")]
		public InteractionTarget()
		{
		}
	}
	[Token(Token = "0x2000063")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x9D5504", Offset = "0x9D5504")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x9D5504", Offset = "0x9D5504")]
	public class InteractionTrigger : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000162")]
		public class CharacterPosition
		{
			[Token(Token = "0x4000937")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9DBF7C", Offset = "0x9DBF7C")]
			public bool use;

			[Token(Token = "0x4000938")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9DBFB4", Offset = "0x9DBFB4")]
			public Vector2 offset;

			[Token(Token = "0x4000939")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9DBFEC", Offset = "0x9DBFEC")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9DBFEC", Offset = "0x9DBFEC")]
			public float angleOffset;

			[Token(Token = "0x400093A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9DC048", Offset = "0x9DC048")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9DC048", Offset = "0x9DC048")]
			public float maxAngle;

			[Token(Token = "0x400093B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9DC0A0", Offset = "0x9DC0A0")]
			public float radius;

			[Token(Token = "0x400093C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9DC0D8", Offset = "0x9DC0D8")]
			public bool orbit;

			[Token(Token = "0x400093D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9DC110", Offset = "0x9DC110")]
			public bool fixYAxis;

			[Token(Token = "0x170001C6")]
			public Vector3 offset3D
			{
				[Token(Token = "0x6000A9C")]
				[Address(RVA = "0xEDC810", Offset = "0xEDC810", VA = "0xEDC810")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x170001C7")]
			public Vector3 direction3D
			{
				[Token(Token = "0x6000A9D")]
				[Address(RVA = "0xEDC84C", Offset = "0xEDC84C", VA = "0xEDC84C")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x6000A9E")]
			[Address(RVA = "0xEDC944", Offset = "0xEDC944", VA = "0xEDC944")]
			public bool IsInRange(Transform character, Transform trigger, out float error)
			{
				return default(bool);
			}

			[Token(Token = "0x6000A9F")]
			[Address(RVA = "0xEDD018", Offset = "0xEDD018", VA = "0xEDD018")]
			public CharacterPosition()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000163")]
		public class CameraPosition
		{
			[Token(Token = "0x400093E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9DC148", Offset = "0x9DC148")]
			public Collider lookAtTarget;

			[Token(Token = "0x400093F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9DC180", Offset = "0x9DC180")]
			public Vector3 direction;

			[Token(Token = "0x4000940")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9DC1B8", Offset = "0x9DC1B8")]
			public float maxDistance;

			[Token(Token = "0x4000941")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9DC1F0", Offset = "0x9DC1F0")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9DC1F0", Offset = "0x9DC1F0")]
			public float maxAngle;

			[Token(Token = "0x4000942")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9DC248", Offset = "0x9DC248")]
			public bool fixYAxis;

			[Token(Token = "0x6000AA0")]
			[Address(RVA = "0xEDC2CC", Offset = "0xEDC2CC", VA = "0xEDC2CC")]
			public Quaternion GetRotation()
			{
				return default(Quaternion);
			}

			[Token(Token = "0x6000AA1")]
			[Address(RVA = "0xEDC4A0", Offset = "0xEDC4A0", VA = "0xEDC4A0")]
			public bool IsInRange(Transform raycastFrom, RaycastHit hit, Transform trigger, out float error)
			{
				return default(bool);
			}

			[Token(Token = "0x6000AA2")]
			[Address(RVA = "0xEDC784", Offset = "0xEDC784", VA = "0xEDC784")]
			public CameraPosition()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000164")]
		public class Range
		{
			[Serializable]
			[Token(Token = "0x20001B4")]
			public class Interaction
			{
				[Token(Token = "0x4000A8A")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9DD040", Offset = "0x9DD040")]
				public InteractionObject interactionObject;

				[Token(Token = "0x4000A8B")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9DD078", Offset = "0x9DD078")]
				public FullBodyBipedEffector[] effectors;

				[Token(Token = "0x6000BD5")]
				[Address(RVA = "0xEDD03C", Offset = "0xEDD03C", VA = "0xEDD03C")]
				public Interaction()
				{
				}
			}

			[Token(Token = "0x4000943")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[HideInInspector]
			[SerializeField]
			public string name;

			[Token(Token = "0x4000944")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[HideInInspector]
			[SerializeField]
			public bool show;

			[Token(Token = "0x4000945")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9DC2F0", Offset = "0x9DC2F0")]
			public CharacterPosition characterPosition;

			[Token(Token = "0x4000946")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9DC328", Offset = "0x9DC328")]
			public CameraPosition cameraPosition;

			[Token(Token = "0x4000947")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9DC360", Offset = "0x9DC360")]
			public Interaction[] interactions;

			[Token(Token = "0x6000AA3")]
			[Address(RVA = "0xEDC12C", Offset = "0xEDC12C", VA = "0xEDC12C")]
			public bool IsInRange(Transform character, Transform raycastFrom, RaycastHit raycastHit, Transform trigger, out float maxError)
			{
				return default(bool);
			}

			[Token(Token = "0x6000AA4")]
			[Address(RVA = "0xEDD02C", Offset = "0xEDD02C", VA = "0xEDD02C")]
			public Range()
			{
			}
		}

		[Token(Token = "0x40002E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9D836C", Offset = "0x9D836C")]
		public Range[] ranges;

		[Token(Token = "0x6000497")]
		[Address(RVA = "0xEDC044", Offset = "0xEDC044", VA = "0xEDC044")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9DEAC4", Offset = "0x9DEAC4")]
		private void OpenTutorial4()
		{
		}

		[Token(Token = "0x6000498")]
		[Address(RVA = "0xEDC090", Offset = "0xEDC090", VA = "0xEDC090")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9DEAFC", Offset = "0x9DEAFC")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000499")]
		[Address(RVA = "0xEDC0DC", Offset = "0xEDC0DC", VA = "0xEDC0DC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9DEB34", Offset = "0x9DEB34")]
		private void ASThread()
		{
		}

		[Token(Token = "0x600049A")]
		[Address(RVA = "0xEDC128", Offset = "0xEDC128", VA = "0xEDC128")]
		private void Start()
		{
		}

		[Token(Token = "0x600049B")]
		[Address(RVA = "0xEDA7DC", Offset = "0xEDA7DC", VA = "0xEDA7DC")]
		public int GetBestRangeIndex(Transform character, Transform raycastFrom, RaycastHit raycastHit)
		{
			return default(int);
		}

		[Token(Token = "0x600049C")]
		[Address(RVA = "0xEDC26C", Offset = "0xEDC26C", VA = "0xEDC26C")]
		public InteractionTrigger()
		{
		}
	}
	[Token(Token = "0x2000064")]
	public class GenericPoser : Poser
	{
		[Serializable]
		[Token(Token = "0x2000165")]
		public class Map
		{
			[Token(Token = "0x4000948")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform bone;

			[Token(Token = "0x4000949")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Transform target;

			[Token(Token = "0x400094A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private Vector3 defaultLocalPosition;

			[Token(Token = "0x400094B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			private Quaternion defaultLocalRotation;

			[Token(Token = "0x6000AA5")]
			[Address(RVA = "0x16FE0EC", Offset = "0x16FE0EC", VA = "0x16FE0EC")]
			public Map(Transform bone, Transform target)
			{
			}

			[Token(Token = "0x6000AA6")]
			[Address(RVA = "0x16FE634", Offset = "0x16FE634", VA = "0x16FE634")]
			public void StoreDefaultState()
			{
			}

			[Token(Token = "0x6000AA7")]
			[Address(RVA = "0x16FE5A8", Offset = "0x16FE5A8", VA = "0x16FE5A8")]
			public void FixTransform()
			{
			}

			[Token(Token = "0x6000AA8")]
			[Address(RVA = "0x16FE2FC", Offset = "0x16FE2FC", VA = "0x16FE2FC")]
			public void Update(float localRotationWeight, float localPositionWeight)
			{
			}
		}

		[Token(Token = "0x40002E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Map[] maps;

		[Token(Token = "0x600049D")]
		[Address(RVA = "0x16FDD5C", Offset = "0x16FDD5C", VA = "0x16FDD5C", Slot = "7")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9DEB6C", Offset = "0x9DEB6C")]
		public override void AutoMapping()
		{
		}

		[Token(Token = "0x600049E")]
		[Address(RVA = "0x16FE1C0", Offset = "0x16FE1C0", VA = "0x16FE1C0", Slot = "8")]
		protected override void InitiatePoser()
		{
		}

		[Token(Token = "0x600049F")]
		[Address(RVA = "0x16FE1C4", Offset = "0x16FE1C4", VA = "0x16FE1C4", Slot = "9")]
		protected override void UpdatePoser()
		{
		}

		[Token(Token = "0x60004A0")]
		[Address(RVA = "0x16FE510", Offset = "0x16FE510", VA = "0x16FE510", Slot = "10")]
		protected override void FixPoserTransforms()
		{
		}

		[Token(Token = "0x60004A1")]
		[Address(RVA = "0x16FE128", Offset = "0x16FE128", VA = "0x16FE128")]
		private void StoreDefaultState()
		{
		}

		[Token(Token = "0x60004A2")]
		[Address(RVA = "0x16FE024", Offset = "0x16FE024", VA = "0x16FE024")]
		private Transform GetTargetNamed(string tName, Transform[] array)
		{
			return null;
		}

		[Token(Token = "0x60004A3")]
		[Address(RVA = "0x16FE698", Offset = "0x16FE698", VA = "0x16FE698")]
		public GenericPoser()
		{
		}
	}
	[Token(Token = "0x2000065")]
	public class HandPoser : Poser
	{
		[Token(Token = "0x40002E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Transform _poseRoot;

		[Token(Token = "0x40002E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Transform[] children;

		[Token(Token = "0x40002E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Transform[] poseChildren;

		[Token(Token = "0x40002EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Vector3[] defaultLocalPositions;

		[Token(Token = "0x40002EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Quaternion[] defaultLocalRotations;

		[Token(Token = "0x40002EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private bool _shouldLerp;

		[Token(Token = "0x40002ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private float _toValue;

		[Token(Token = "0x40002EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private float _duration;

		[Token(Token = "0x60004A4")]
		[Address(RVA = "0x1708948", Offset = "0x1708948", VA = "0x1708948", Slot = "7")]
		public override void AutoMapping()
		{
		}

		[Token(Token = "0x60004A5")]
		[Address(RVA = "0x1708A08", Offset = "0x1708A08", VA = "0x1708A08", Slot = "8")]
		protected override void InitiatePoser()
		{
		}

		[Token(Token = "0x60004A6")]
		[Address(RVA = "0x1708C68", Offset = "0x1708C68", VA = "0x1708C68", Slot = "10")]
		protected override void FixPoserTransforms()
		{
		}

		[Token(Token = "0x60004A7")]
		[Address(RVA = "0x1708DF8", Offset = "0x1708DF8", VA = "0x1708DF8", Slot = "9")]
		protected override void UpdatePoser()
		{
		}

		[Token(Token = "0x60004A8")]
		[Address(RVA = "0x1708A64", Offset = "0x1708A64", VA = "0x1708A64")]
		private void StoreDefaultState()
		{
		}

		[Token(Token = "0x60004A9")]
		[Address(RVA = "0x170931C", Offset = "0x170931C", VA = "0x170931C")]
		private void Update()
		{
		}

		[Token(Token = "0x60004AA")]
		[Address(RVA = "0x1709408", Offset = "0x1709408", VA = "0x1709408")]
		public void LerpWeightToZero(float duration)
		{
		}

		[Token(Token = "0x60004AB")]
		[Address(RVA = "0x170941C", Offset = "0x170941C", VA = "0x170941C")]
		public void LerpWeightToOne(float duration)
		{
		}

		[Token(Token = "0x60004AC")]
		[Address(RVA = "0x1709434", Offset = "0x1709434", VA = "0x1709434")]
		public HandPoser()
		{
		}
	}
	[Token(Token = "0x2000066")]
	public abstract class Poser : SolverManager
	{
		[Token(Token = "0x40002EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Transform poseRoot;

		[Token(Token = "0x40002F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9D83A4", Offset = "0x9D83A4")]
		public float weight;

		[Token(Token = "0x40002F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9D83BC", Offset = "0x9D83BC")]
		public float localRotationWeight;

		[Token(Token = "0x40002F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9D83D4", Offset = "0x9D83D4")]
		public float localPositionWeight;

		[Token(Token = "0x40002F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private bool initiated;

		[Token(Token = "0x60004AD")]
		public abstract void AutoMapping();

		[Token(Token = "0x60004AE")]
		protected abstract void InitiatePoser();

		[Token(Token = "0x60004AF")]
		protected abstract void UpdatePoser();

		[Token(Token = "0x60004B0")]
		protected abstract void FixPoserTransforms();

		[Token(Token = "0x60004B1")]
		[Address(RVA = "0xEDE770", Offset = "0xEDE770", VA = "0xEDE770", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x60004B2")]
		[Address(RVA = "0xEDE7C4", Offset = "0xEDE7C4", VA = "0xEDE7C4", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x60004B3")]
		[Address(RVA = "0xEDE800", Offset = "0xEDE800", VA = "0xEDE800", Slot = "6")]
		protected override void FixTransforms()
		{
		}

		[Token(Token = "0x60004B4")]
		[Address(RVA = "0xEDE818", Offset = "0xEDE818", VA = "0xEDE818")]
		protected Poser()
		{
		}
	}
	[Token(Token = "0x2000067")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x9D5564", Offset = "0x9D5564")]
	public class RagdollUtility : MonoBehaviour
	{
		[Token(Token = "0x2000166")]
		public class Rigidbone
		{
			[Token(Token = "0x400094C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody r;

			[Token(Token = "0x400094D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Transform t;

			[Token(Token = "0x400094E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Collider collider;

			[Token(Token = "0x400094F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Joint joint;

			[Token(Token = "0x4000950")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Rigidbody c;

			[Token(Token = "0x4000951")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public bool updateAnchor;

			[Token(Token = "0x4000952")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public Vector3 deltaPosition;

			[Token(Token = "0x4000953")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public Quaternion deltaRotation;

			[Token(Token = "0x4000954")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public float deltaTime;

			[Token(Token = "0x4000955")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			public Vector3 lastPosition;

			[Token(Token = "0x4000956")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			public Quaternion lastRotation;

			[Token(Token = "0x6000AA9")]
			[Address(RVA = "0xEDEECC", Offset = "0xEDEECC", VA = "0xEDEECC")]
			public Rigidbone(Rigidbody r)
			{
			}

			[Token(Token = "0x6000AAA")]
			[Address(RVA = "0xEDFEE0", Offset = "0xEDFEE0", VA = "0xEDFEE0")]
			public void RecordVelocity()
			{
			}

			[Token(Token = "0x6000AAB")]
			[Address(RVA = "0xEDFC28", Offset = "0xEDFC28", VA = "0xEDFC28")]
			public void WakeUp(float velocityWeight, float angularVelocityWeight)
			{
			}
		}

		[Token(Token = "0x2000167")]
		public class Child
		{
			[Token(Token = "0x4000957")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform t;

			[Token(Token = "0x4000958")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Vector3 localPosition;

			[Token(Token = "0x4000959")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			public Quaternion localRotation;

			[Token(Token = "0x6000AAC")]
			[Address(RVA = "0xEDF064", Offset = "0xEDF064", VA = "0xEDF064")]
			public Child(Transform transform)
			{
			}

			[Token(Token = "0x6000AAD")]
			[Address(RVA = "0xEE00B8", Offset = "0xEE00B8", VA = "0xEE00B8")]
			public void FixTransform(float weight)
			{
			}

			[Token(Token = "0x6000AAE")]
			[Address(RVA = "0xEE0054", Offset = "0xEE0054", VA = "0xEE0054")]
			public void StoreLocalState()
			{
			}
		}

		[Token(Token = "0x2000168")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9D5FCC", Offset = "0x9D5FCC")]
		private sealed class <DisableRagdollSmooth>d__21 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400095A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400095B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400095C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public RagdollUtility <>4__this;

			[Token(Token = "0x170001C8")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000AB2")]
				[Address(RVA = "0xEE0814", Offset = "0xEE0814", VA = "0xEE0814", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170001C9")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000AB4")]
				[Address(RVA = "0xEE0884", Offset = "0xEE0884", VA = "0xEE0884", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000AAF")]
			[Address(RVA = "0xEDF0D4", Offset = "0xEDF0D4", VA = "0xEDF0D4")]
			[DebuggerHidden]
			public <DisableRagdollSmooth>d__21(int <>1__state)
			{
			}

			[Token(Token = "0x6000AB0")]
			[Address(RVA = "0xEE04EC", Offset = "0xEE04EC", VA = "0xEE04EC", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000AB1")]
			[Address(RVA = "0xEE04F0", Offset = "0xEE04F0", VA = "0xEE04F0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000AB3")]
			[Address(RVA = "0xEE081C", Offset = "0xEE081C", VA = "0xEE081C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40002F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9D83EC", Offset = "0x9D83EC")]
		public IK ik;

		[Token(Token = "0x40002F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9D8424", Offset = "0x9D8424")]
		public float ragdollToAnimationTime;

		[Token(Token = "0x40002F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9D845C", Offset = "0x9D845C")]
		public bool applyIkOnRagdoll;

		[Token(Token = "0x40002F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9D8494", Offset = "0x9D8494")]
		public float applyVelocity;

		[Token(Token = "0x40002F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9D84CC", Offset = "0x9D84CC")]
		public float applyAngularVelocity;

		[Token(Token = "0x40002F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Animator animator;

		[Token(Token = "0x40002FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Rigidbone[] rigidbones;

		[Token(Token = "0x40002FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Child[] children;

		[Token(Token = "0x40002FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private bool enableRagdollFlag;

		[Token(Token = "0x40002FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private AnimatorUpdateMode animatorUpdateMode;

		[Token(Token = "0x40002FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private IK[] allIKComponents;

		[Token(Token = "0x40002FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private bool[] fixTransforms;

		[Token(Token = "0x4000300")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private float ragdollWeight;

		[Token(Token = "0x4000301")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private float ragdollWeightV;

		[Token(Token = "0x4000302")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private bool fixedFrame;

		[Token(Token = "0x4000303")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private bool[] disabledIKComponents;

		[Token(Token = "0x1700009F")]
		private bool isRagdoll
		{
			[Token(Token = "0x60004C0")]
			[Address(RVA = "0xEDE878", Offset = "0xEDE878", VA = "0xEDE878")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000A0")]
		private bool ikUsed
		{
			[Token(Token = "0x60004C2")]
			[Address(RVA = "0xEDF63C", Offset = "0xEDF63C", VA = "0xEDF63C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60004B5")]
		[Address(RVA = "0xEDE840", Offset = "0xEDE840", VA = "0xEDE840")]
		public void EnableRagdoll()
		{
		}

		[Token(Token = "0x60004B6")]
		[Address(RVA = "0xEDE918", Offset = "0xEDE918", VA = "0xEDE918")]
		public void DisableRagdoll()
		{
		}

		[Token(Token = "0x60004B7")]
		[Address(RVA = "0xEDEA64", Offset = "0xEDEA64", VA = "0xEDEA64")]
		public void Start()
		{
		}

		[Token(Token = "0x60004B8")]
		[Address(RVA = "0xEDE9F0", Offset = "0xEDE9F0", VA = "0xEDE9F0")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9DEBA4", Offset = "0x9DEBA4")]
		private IEnumerator DisableRagdollSmooth()
		{
			return null;
		}

		[Token(Token = "0x60004B9")]
		[Address(RVA = "0xEDF100", Offset = "0xEDF100", VA = "0xEDF100")]
		private void Update()
		{
		}

		[Token(Token = "0x60004BA")]
		[Address(RVA = "0xEDF49C", Offset = "0xEDF49C", VA = "0xEDF49C")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60004BB")]
		[Address(RVA = "0xEDF56C", Offset = "0xEDF56C", VA = "0xEDF56C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60004BC")]
		[Address(RVA = "0xEDF800", Offset = "0xEDF800", VA = "0xEDF800")]
		private void AfterLastIK()
		{
		}

		[Token(Token = "0x60004BD")]
		[Address(RVA = "0xEDF600", Offset = "0xEDF600", VA = "0xEDF600")]
		private void AfterAnimation()
		{
		}

		[Token(Token = "0x60004BE")]
		[Address(RVA = "0xEDF7BC", Offset = "0xEDF7BC", VA = "0xEDF7BC")]
		private void OnFinalPose()
		{
		}

		[Token(Token = "0x60004BF")]
		[Address(RVA = "0xEDF8B4", Offset = "0xEDF8B4", VA = "0xEDF8B4")]
		private void RagdollEnabler()
		{
		}

		[Token(Token = "0x60004C1")]
		[Address(RVA = "0xEDF834", Offset = "0xEDF834", VA = "0xEDF834")]
		private void RecordVelocities()
		{
		}

		[Token(Token = "0x60004C3")]
		[Address(RVA = "0xEDE970", Offset = "0xEDE970", VA = "0xEDE970")]
		private void StoreLocalState()
		{
		}

		[Token(Token = "0x60004C4")]
		[Address(RVA = "0xEDF4DC", Offset = "0xEDF4DC", VA = "0xEDF4DC")]
		private void FixTransforms(float weight)
		{
		}

		[Token(Token = "0x60004C5")]
		[Address(RVA = "0xEE02F0", Offset = "0xEE02F0", VA = "0xEE02F0")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60004C6")]
		[Address(RVA = "0xEE0420", Offset = "0xEE0420", VA = "0xEE0420")]
		public RagdollUtility()
		{
		}
	}
	[Token(Token = "0x2000068")]
	public abstract class RotationLimit : MonoBehaviour
	{
		[Token(Token = "0x4000304")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Vector3 axis;

		[Token(Token = "0x4000305")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[HideInInspector]
		public Quaternion defaultLocalRotation;

		[Token(Token = "0x4000306")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private bool initiated;

		[Token(Token = "0x4000307")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x35")]
		private bool applicationQuit;

		[Token(Token = "0x170000A1")]
		public Vector3 secondaryAxis
		{
			[Token(Token = "0x60004CB")]
			[Address(RVA = "0xEE2150", Offset = "0xEE2150", VA = "0xEE2150")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x170000A2")]
		public Vector3 crossAxis
		{
			[Token(Token = "0x60004CC")]
			[Address(RVA = "0xEE218C", Offset = "0xEE218C", VA = "0xEE218C")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x60004C7")]
		[Address(RVA = "0xEE1D9C", Offset = "0xEE1D9C", VA = "0xEE1D9C")]
		public void SetDefaultLocalRotation()
		{
		}

		[Token(Token = "0x60004C8")]
		[Address(RVA = "0xEE1DE0", Offset = "0xEE1DE0", VA = "0xEE1DE0")]
		public Quaternion GetLimitedLocalRotation(Quaternion localRotation, out bool changed)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60004C9")]
		[Address(RVA = "0xEE2068", Offset = "0xEE2068", VA = "0xEE2068")]
		public bool Apply()
		{
			return default(bool);
		}

		[Token(Token = "0x60004CA")]
		[Address(RVA = "0xEE2118", Offset = "0xEE2118", VA = "0xEE2118")]
		public void Disable()
		{
		}

		[Token(Token = "0x60004CD")]
		protected abstract Quaternion LimitRotation(Quaternion rotation);

		[Token(Token = "0x60004CE")]
		[Address(RVA = "0xEE1F80", Offset = "0xEE1F80", VA = "0xEE1F80")]
		private void Awake()
		{
		}

		[Token(Token = "0x60004CF")]
		[Address(RVA = "0xEE225C", Offset = "0xEE225C", VA = "0xEE225C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60004D0")]
		[Address(RVA = "0xEE2260", Offset = "0xEE2260", VA = "0xEE2260")]
		public void LogWarning(string message)
		{
		}

		[Token(Token = "0x60004D1")]
		[Address(RVA = "0xEE2290", Offset = "0xEE2290", VA = "0xEE2290")]
		protected static Quaternion Limit1DOF(Quaternion rotation, Vector3 axis)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60004D2")]
		[Address(RVA = "0xEE2374", Offset = "0xEE2374", VA = "0xEE2374")]
		protected static Quaternion LimitTwist(Quaternion rotation, Vector3 axis, Vector3 orthoAxis, float twistLimit)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60004D3")]
		[Address(RVA = "0xEE25F4", Offset = "0xEE25F4", VA = "0xEE25F4")]
		protected static float GetOrthogonalAngle(Vector3 v1, Vector3 v2, Vector3 normal)
		{
			return default(float);
		}

		[Token(Token = "0x60004D4")]
		[Address(RVA = "0xEE26B0", Offset = "0xEE26B0", VA = "0xEE26B0")]
		protected RotationLimit()
		{
		}
	}
	[Token(Token = "0x2000069")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x9D55C8", Offset = "0x9D55C8")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x9D55C8", Offset = "0x9D55C8")]
	public class RotationLimitAngle : RotationLimit
	{
		[Token(Token = "0x4000308")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9D8514", Offset = "0x9D8514")]
		public float limit;

		[Token(Token = "0x4000309")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9D8530", Offset = "0x9D8530")]
		public float twistLimit;

		[Token(Token = "0x60004D5")]
		[Address(RVA = "0xEE2728", Offset = "0xEE2728", VA = "0xEE2728")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9DEC08", Offset = "0x9DEC08")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x60004D6")]
		[Address(RVA = "0xEE2774", Offset = "0xEE2774", VA = "0xEE2774")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9DEC40", Offset = "0x9DEC40")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x60004D7")]
		[Address(RVA = "0xEE27C0", Offset = "0xEE27C0", VA = "0xEE27C0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9DEC78", Offset = "0x9DEC78")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60004D8")]
		[Address(RVA = "0xEE280C", Offset = "0xEE280C", VA = "0xEE280C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9DECB0", Offset = "0x9DECB0")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60004D9")]
		[Address(RVA = "0xEE2858", Offset = "0xEE2858", VA = "0xEE2858", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60004DA")]
		[Address(RVA = "0xEE2910", Offset = "0xEE2910", VA = "0xEE2910")]
		private Quaternion LimitSwing(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60004DB")]
		[Address(RVA = "0xEE2B58", Offset = "0xEE2B58", VA = "0xEE2B58")]
		public RotationLimitAngle()
		{
		}
	}
	[Token(Token = "0x200006A")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x9D5628", Offset = "0x9D5628")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x9D5628", Offset = "0x9D5628")]
	public class RotationLimitHinge : RotationLimit
	{
		[Token(Token = "0x400030A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x36")]
		public bool useLimits;

		[Token(Token = "0x400030B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float min;

		[Token(Token = "0x400030C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float max;

		[Token(Token = "0x400030D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[HideInInspector]
		public float zeroAxisDisplayOffset;

		[Token(Token = "0x400030E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private Quaternion lastRotation;

		[Token(Token = "0x400030F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private float lastAngle;

		[Token(Token = "0x60004DC")]
		[Address(RVA = "0xEE2B68", Offset = "0xEE2B68", VA = "0xEE2B68")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9DECE8", Offset = "0x9DECE8")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x60004DD")]
		[Address(RVA = "0xEE2BB4", Offset = "0xEE2BB4", VA = "0xEE2BB4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9DED20", Offset = "0x9DED20")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x60004DE")]
		[Address(RVA = "0xEE2C00", Offset = "0xEE2C00", VA = "0xEE2C00")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9DED58", Offset = "0x9DED58")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60004DF")]
		[Address(RVA = "0xEE2C4C", Offset = "0xEE2C4C", VA = "0xEE2C4C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9DED90", Offset = "0x9DED90")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60004E0")]
		[Address(RVA = "0xEE2C98", Offset = "0xEE2C98", VA = "0xEE2C98", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60004E1")]
		[Address(RVA = "0xEE2CC0", Offset = "0xEE2CC0", VA = "0xEE2CC0")]
		private Quaternion LimitHinge(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60004E2")]
		[Address(RVA = "0xEE2FC0", Offset = "0xEE2FC0", VA = "0xEE2FC0")]
		public RotationLimitHinge()
		{
		}
	}
	[Token(Token = "0x200006B")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x9D5688", Offset = "0x9D5688")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x9D5688", Offset = "0x9D5688")]
	public class RotationLimitPolygonal : RotationLimit
	{
		[Serializable]
		[Token(Token = "0x2000169")]
		public class ReachCone
		{
			[Token(Token = "0x400095D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Vector3[] tetrahedron;

			[Token(Token = "0x400095E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float volume;

			[Token(Token = "0x400095F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public Vector3 S;

			[Token(Token = "0x4000960")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Vector3 B;

			[Token(Token = "0x170001CA")]
			public Vector3 o
			{
				[Token(Token = "0x6000AB5")]
				[Address(RVA = "0xEE54A8", Offset = "0xEE54A8", VA = "0xEE54A8")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x170001CB")]
			public Vector3 a
			{
				[Token(Token = "0x6000AB6")]
				[Address(RVA = "0xEE54F0", Offset = "0xEE54F0", VA = "0xEE54F0")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x170001CC")]
			public Vector3 b
			{
				[Token(Token = "0x6000AB7")]
				[Address(RVA = "0xEE553C", Offset = "0xEE553C", VA = "0xEE553C")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x170001CD")]
			public Vector3 c
			{
				[Token(Token = "0x6000AB8")]
				[Address(RVA = "0xEE5588", Offset = "0xEE5588", VA = "0xEE5588")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x170001CE")]
			public bool isValid
			{
				[Token(Token = "0x6000ABA")]
				[Address(RVA = "0xEE43E4", Offset = "0xEE43E4", VA = "0xEE43E4")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x6000AB9")]
			[Address(RVA = "0xEE4B8C", Offset = "0xEE4B8C", VA = "0xEE4B8C")]
			public ReachCone(Vector3 _o, Vector3 _a, Vector3 _b, Vector3 _c)
			{
			}

			[Token(Token = "0x6000ABB")]
			[Address(RVA = "0xEE4D3C", Offset = "0xEE4D3C", VA = "0xEE4D3C")]
			public void Calculate()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200016A")]
		public class LimitPoint
		{
			[Token(Token = "0x4000961")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Vector3 point;

			[Token(Token = "0x4000962")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public float tangentWeight;

			[Token(Token = "0x6000ABC")]
			[Address(RVA = "0xEE43F4", Offset = "0xEE43F4", VA = "0xEE43F4")]
			public LimitPoint()
			{
			}
		}

		[Token(Token = "0x4000310")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9D855C", Offset = "0x9D855C")]
		public float twistLimit;

		[Token(Token = "0x4000311")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9D8578", Offset = "0x9D8578")]
		public int smoothIterations;

		[Token(Token = "0x4000312")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		[HideInInspector]
		public LimitPoint[] points;

		[Token(Token = "0x4000313")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		[HideInInspector]
		public Vector3[] P;

		[Token(Token = "0x4000314")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		[HideInInspector]
		public ReachCone[] reachCones;

		[Token(Token = "0x60004E3")]
		[Address(RVA = "0xEE3048", Offset = "0xEE3048", VA = "0xEE3048")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9DEDC8", Offset = "0x9DEDC8")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x60004E4")]
		[Address(RVA = "0xEE3094", Offset = "0xEE3094", VA = "0xEE3094")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9DEE00", Offset = "0x9DEE00")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x60004E5")]
		[Address(RVA = "0xEE30E0", Offset = "0xEE30E0", VA = "0xEE30E0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9DEE38", Offset = "0x9DEE38")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60004E6")]
		[Address(RVA = "0xEE312C", Offset = "0xEE312C", VA = "0xEE312C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9DEE70", Offset = "0x9DEE70")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60004E7")]
		[Address(RVA = "0xEE3178", Offset = "0xEE3178", VA = "0xEE3178")]
		public void SetLimitPoints(LimitPoint[] points)
		{
		}

		[Token(Token = "0x60004E8")]
		[Address(RVA = "0xEE37B0", Offset = "0xEE37B0", VA = "0xEE37B0", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60004E9")]
		[Address(RVA = "0xEE38AC", Offset = "0xEE38AC", VA = "0xEE38AC")]
		private void Start()
		{
		}

		[Token(Token = "0x60004EA")]
		[Address(RVA = "0xEE3F70", Offset = "0xEE3F70", VA = "0xEE3F70")]
		public void ResetToDefault()
		{
		}

		[Token(Token = "0x60004EB")]
		[Address(RVA = "0xEE3218", Offset = "0xEE3218", VA = "0xEE3218")]
		public void BuildReachCones()
		{
		}

		[Token(Token = "0x60004EC")]
		[Address(RVA = "0xEE4478", Offset = "0xEE4478", VA = "0xEE4478")]
		private Vector3[] SmoothPoints()
		{
			return null;
		}

		[Token(Token = "0x60004ED")]
		[Address(RVA = "0xEE4EFC", Offset = "0xEE4EFC", VA = "0xEE4EFC")]
		private float GetScalar(int k)
		{
			return default(float);
		}

		[Token(Token = "0x60004EE")]
		[Address(RVA = "0xEE4F40", Offset = "0xEE4F40", VA = "0xEE4F40")]
		private Vector3 PointToTangentPlane(Vector3 p, float r)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60004EF")]
		[Address(RVA = "0xEE5088", Offset = "0xEE5088", VA = "0xEE5088")]
		private Vector3 TangentPointToSphere(Vector3 q, float r)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60004F0")]
		[Address(RVA = "0xEE3C08", Offset = "0xEE3C08", VA = "0xEE3C08")]
		private Quaternion LimitSwing(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60004F1")]
		[Address(RVA = "0xEE5218", Offset = "0xEE5218", VA = "0xEE5218")]
		private int GetReachCone(Vector3 L)
		{
			return default(int);
		}

		[Token(Token = "0x60004F2")]
		[Address(RVA = "0xEE5444", Offset = "0xEE5444", VA = "0xEE5444")]
		public RotationLimitPolygonal()
		{
		}
	}
	[Token(Token = "0x200006C")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x9D56E8", Offset = "0x9D56E8")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x9D56E8", Offset = "0x9D56E8")]
	public class RotationLimitSpline : RotationLimit
	{
		[Token(Token = "0x4000315")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9D8638", Offset = "0x9D8638")]
		public float twistLimit;

		[Token(Token = "0x4000316")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		[HideInInspector]
		public AnimationCurve spline;

		[Token(Token = "0x60004F3")]
		[Address(RVA = "0xEE55D4", Offset = "0xEE55D4", VA = "0xEE55D4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9DEEA8", Offset = "0x9DEEA8")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x60004F4")]
		[Address(RVA = "0xEE5620", Offset = "0xEE5620", VA = "0xEE5620")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9DEEE0", Offset = "0x9DEEE0")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x60004F5")]
		[Address(RVA = "0xEE566C", Offset = "0xEE566C", VA = "0xEE566C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9DEF18", Offset = "0x9DEF18")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60004F6")]
		[Address(RVA = "0xEE56B8", Offset = "0xEE56B8", VA = "0xEE56B8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9DEF50", Offset = "0x9DEF50")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60004F7")]
		[Address(RVA = "0xEE5704", Offset = "0xEE5704", VA = "0xEE5704")]
		public void SetSpline(Keyframe[] keyframes)
		{
		}

		[Token(Token = "0x60004F8")]
		[Address(RVA = "0xEE573C", Offset = "0xEE573C", VA = "0xEE573C", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60004F9")]
		[Address(RVA = "0xEE57F4", Offset = "0xEE57F4", VA = "0xEE57F4")]
		public Quaternion LimitSwing(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60004FA")]
		[Address(RVA = "0xEE5B2C", Offset = "0xEE5B2C", VA = "0xEE5B2C")]
		public RotationLimitSpline()
		{
		}
	}
	[Token(Token = "0x200006D")]
	public class AimPoser : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x200016B")]
		public class Pose
		{
			[Token(Token = "0x4000963")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public bool visualize;

			[Token(Token = "0x4000964")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public string name;

			[Token(Token = "0x4000965")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Vector3 direction;

			[Token(Token = "0x4000966")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public float yaw;

			[Token(Token = "0x4000967")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public float pitch;

			[Token(Token = "0x4000968")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private float angleBuffer;

			[Token(Token = "0x6000ABD")]
			[Address(RVA = "0xF79068", Offset = "0xF79068", VA = "0xF79068")]
			public bool IsInDirection(Vector3 d)
			{
				return default(bool);
			}

			[Token(Token = "0x6000ABE")]
			[Address(RVA = "0xF793FC", Offset = "0xF793FC", VA = "0xF793FC")]
			public void SetAngleBuffer(float value)
			{
			}

			[Token(Token = "0x6000ABF")]
			[Address(RVA = "0xF7946C", Offset = "0xF7946C", VA = "0xF7946C")]
			public Pose()
			{
			}
		}

		[Token(Token = "0x4000317")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float angleBuffer;

		[Token(Token = "0x4000318")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Pose[] poses;

		[Token(Token = "0x60004FB")]
		[Address(RVA = "0xF78F08", Offset = "0xF78F08", VA = "0xF78F08")]
		public Pose GetPose(Vector3 localDirection)
		{
			return null;
		}

		[Token(Token = "0x60004FC")]
		[Address(RVA = "0xF79304", Offset = "0xF79304", VA = "0xF79304")]
		public void SetPoseActive(Pose pose)
		{
		}

		[Token(Token = "0x60004FD")]
		[Address(RVA = "0xF79404", Offset = "0xF79404", VA = "0xF79404")]
		public AimPoser()
		{
		}
	}
	[Token(Token = "0x200006E")]
	public class Amplifier : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x200016C")]
		public class Body
		{
			[Serializable]
			[Token(Token = "0x20001B5")]
			public class EffectorLink
			{
				[Token(Token = "0x4000A8C")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9DD0B0", Offset = "0x9DD0B0")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x4000A8D")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9DD0E8", Offset = "0x9DD0E8")]
				public float weight;

				[Token(Token = "0x6000BD6")]
				[Address(RVA = "0xF79B68", Offset = "0xF79B68", VA = "0xF79B68")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x4000969")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9DC398", Offset = "0x9DC398")]
			public Transform transform;

			[Token(Token = "0x400096A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9DC3D0", Offset = "0x9DC3D0")]
			public Transform relativeTo;

			[Token(Token = "0x400096B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9DC408", Offset = "0x9DC408")]
			public EffectorLink[] effectorLinks;

			[Token(Token = "0x400096C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9DC440", Offset = "0x9DC440")]
			public float verticalWeight;

			[Token(Token = "0x400096D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9DC478", Offset = "0x9DC478")]
			public float horizontalWeight;

			[Token(Token = "0x400096E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9DC4B0", Offset = "0x9DC4B0")]
			public float speed;

			[Token(Token = "0x400096F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private Vector3 lastRelativePos;

			[Token(Token = "0x4000970")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private Vector3 smoothDelta;

			[Token(Token = "0x4000971")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			private bool firstUpdate;

			[Token(Token = "0x6000AC0")]
			[Address(RVA = "0xF795E8", Offset = "0xF795E8", VA = "0xF795E8")]
			public void Update(IKSolverFullBodyBiped solver, float w, float deltaTime)
			{
			}

			[Token(Token = "0x6000AC1")]
			[Address(RVA = "0xF79B40", Offset = "0xF79B40", VA = "0xF79B40")]
			private static Vector3 Multiply(Vector3 v1, Vector3 v2)
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000AC2")]
			[Address(RVA = "0xF79B50", Offset = "0xF79B50", VA = "0xF79B50")]
			public Body()
			{
			}
		}

		[Token(Token = "0x4000319")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9D868C", Offset = "0x9D868C")]
		public Body[] bodies;

		[Token(Token = "0x60004FE")]
		[Address(RVA = "0xF79488", Offset = "0xF79488", VA = "0xF79488", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x60004FF")]
		[Address(RVA = "0xF79B38", Offset = "0xF79B38", VA = "0xF79B38")]
		public Amplifier()
		{
		}
	}
	[Token(Token = "0x200006F")]
	public class BodyTilt : OffsetModifier
	{
		[Token(Token = "0x400031A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9D86C4", Offset = "0x9D86C4")]
		public float tiltSpeed;

		[Token(Token = "0x400031B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9D86FC", Offset = "0x9D86FC")]
		public float tiltSensitivity;

		[Token(Token = "0x400031C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9D8734", Offset = "0x9D8734")]
		public OffsetPose poseLeft;

		[Token(Token = "0x400031D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9D876C", Offset = "0x9D876C")]
		public OffsetPose poseRight;

		[Token(Token = "0x400031E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float tiltAngle;

		[Token(Token = "0x400031F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Vector3 lastForward;

		[Token(Token = "0x6000500")]
		[Address(RVA = "0xF7B658", Offset = "0xF7B658", VA = "0xF7B658", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x6000501")]
		[Address(RVA = "0xF7B6A8", Offset = "0xF7B6A8", VA = "0xF7B6A8", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x6000502")]
		[Address(RVA = "0xF7B914", Offset = "0xF7B914", VA = "0xF7B914")]
		public BodyTilt()
		{
		}
	}
	[Token(Token = "0x2000070")]
	public class HitReaction : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x200016D")]
		public abstract class HitPoint
		{
			[Token(Token = "0x4000972")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9DC4E8", Offset = "0x9DC4E8")]
			public string name;

			[Token(Token = "0x4000973")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9DC520", Offset = "0x9DC520")]
			public Collider collider;

			[Token(Token = "0x4000974")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9DC558", Offset = "0x9DC558")]
			[SerializeField]
			private float crossFadeTime;

			[Token(Token = "0x4000975")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DC5A4", Offset = "0x9DC5A4")]
			private float <crossFader>k__BackingField;

			[Token(Token = "0x4000976")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DC5B4", Offset = "0x9DC5B4")]
			private float <timer>k__BackingField;

			[Token(Token = "0x4000977")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DC5C4", Offset = "0x9DC5C4")]
			private Vector3 <force>k__BackingField;

			[Token(Token = "0x4000978")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DC5D4", Offset = "0x9DC5D4")]
			private Vector3 <point>k__BackingField;

			[Token(Token = "0x4000979")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			private float length;

			[Token(Token = "0x400097A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private float crossFadeSpeed;

			[Token(Token = "0x400097B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			private float lastTime;

			[Token(Token = "0x170001CF")]
			protected float crossFader
			{
				[Token(Token = "0x6000AC3")]
				[Address(RVA = "0x1709A60", Offset = "0x1709A60", VA = "0x1709A60")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E07C4", Offset = "0x9E07C4")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000AC4")]
				[Address(RVA = "0x1709A68", Offset = "0x1709A68", VA = "0x1709A68")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E07D4", Offset = "0x9E07D4")]
				private set
				{
				}
			}

			[Token(Token = "0x170001D0")]
			protected float timer
			{
				[Token(Token = "0x6000AC5")]
				[Address(RVA = "0x1709A70", Offset = "0x1709A70", VA = "0x1709A70")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E07E4", Offset = "0x9E07E4")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000AC6")]
				[Address(RVA = "0x1709A78", Offset = "0x1709A78", VA = "0x1709A78")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E07F4", Offset = "0x9E07F4")]
				private set
				{
				}
			}

			[Token(Token = "0x170001D1")]
			protected Vector3 force
			{
				[Token(Token = "0x6000AC7")]
				[Address(RVA = "0x1709A80", Offset = "0x1709A80", VA = "0x1709A80")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E0804", Offset = "0x9E0804")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000AC8")]
				[Address(RVA = "0x1709A8C", Offset = "0x1709A8C", VA = "0x1709A8C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E0814", Offset = "0x9E0814")]
				private set
				{
				}
			}

			[Token(Token = "0x170001D2")]
			protected Vector3 point
			{
				[Token(Token = "0x6000AC9")]
				[Address(RVA = "0x1709A98", Offset = "0x1709A98", VA = "0x1709A98")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E0824", Offset = "0x9E0824")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000ACA")]
				[Address(RVA = "0x1709AA4", Offset = "0x1709AA4", VA = "0x1709AA4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E0834", Offset = "0x9E0834")]
				private set
				{
				}
			}

			[Token(Token = "0x6000ACB")]
			[Address(RVA = "0x170992C", Offset = "0x170992C", VA = "0x170992C")]
			public void Hit(Vector3 force, Vector3 point)
			{
			}

			[Token(Token = "0x6000ACC")]
			[Address(RVA = "0x1709578", Offset = "0x1709578", VA = "0x1709578")]
			public void Apply(IKSolverFullBodyBiped solver, float weight)
			{
			}

			[Token(Token = "0x6000ACD")]
			protected abstract float GetLength();

			[Token(Token = "0x6000ACE")]
			protected abstract void CrossFadeStart();

			[Token(Token = "0x6000ACF")]
			protected abstract void OnApply(IKSolverFullBodyBiped solver, float weight);

			[Token(Token = "0x6000AD0")]
			[Address(RVA = "0x1709AB0", Offset = "0x1709AB0", VA = "0x1709AB0")]
			protected HitPoint()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200016E")]
		public class HitPointEffector : HitPoint
		{
			[Serializable]
			[Token(Token = "0x20001B6")]
			public class EffectorLink
			{
				[Token(Token = "0x4000A8E")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9DD120", Offset = "0x9DD120")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x4000A8F")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9DD158", Offset = "0x9DD158")]
				public float weight;

				[Token(Token = "0x4000A90")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				private Vector3 lastValue;

				[Token(Token = "0x4000A91")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
				private Vector3 current;

				[Token(Token = "0x6000BD7")]
				[Address(RVA = "0x170A604", Offset = "0x170A604", VA = "0x170A604")]
				public void Apply(IKSolverFullBodyBiped solver, Vector3 offset, float crossFader)
				{
				}

				[Token(Token = "0x6000BD8")]
				[Address(RVA = "0x170A3A0", Offset = "0x170A3A0", VA = "0x170A3A0")]
				public void CrossFadeStart()
				{
				}

				[Token(Token = "0x6000BD9")]
				[Address(RVA = "0x170A764", Offset = "0x170A764", VA = "0x170A764")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x400097C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9DC5E4", Offset = "0x9DC5E4")]
			public AnimationCurve offsetInForceDirection;

			[Token(Token = "0x400097D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9DC61C", Offset = "0x9DC61C")]
			public AnimationCurve offsetInUpDirection;

			[Token(Token = "0x400097E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9DC654", Offset = "0x9DC654")]
			public EffectorLink[] effectorLinks;

			[Token(Token = "0x6000AD1")]
			[Address(RVA = "0x170A118", Offset = "0x170A118", VA = "0x170A118", Slot = "4")]
			protected override float GetLength()
			{
				return default(float);
			}

			[Token(Token = "0x6000AD2")]
			[Address(RVA = "0x170A318", Offset = "0x170A318", VA = "0x170A318", Slot = "5")]
			protected override void CrossFadeStart()
			{
			}

			[Token(Token = "0x6000AD3")]
			[Address(RVA = "0x170A3B4", Offset = "0x170A3B4", VA = "0x170A3B4", Slot = "6")]
			protected override void OnApply(IKSolverFullBodyBiped solver, float weight)
			{
			}

			[Token(Token = "0x6000AD4")]
			[Address(RVA = "0x170A750", Offset = "0x170A750", VA = "0x170A750")]
			public HitPointEffector()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200016F")]
		public class HitPointBone : HitPoint
		{
			[Serializable]
			[Token(Token = "0x20001B7")]
			public class BoneLink
			{
				[Token(Token = "0x4000A92")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9DD190", Offset = "0x9DD190")]
				public Transform bone;

				[Token(Token = "0x4000A93")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9DD1C8", Offset = "0x9DD1C8")]
				[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9DD1C8", Offset = "0x9DD1C8")]
				public float weight;

				[Token(Token = "0x4000A94")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
				private Quaternion lastValue;

				[Token(Token = "0x4000A95")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
				private Quaternion current;

				[Token(Token = "0x6000BDA")]
				[Address(RVA = "0x1709EF0", Offset = "0x1709EF0", VA = "0x1709EF0")]
				public void Apply(IKSolverFullBodyBiped solver, Quaternion offset, float crossFader)
				{
				}

				[Token(Token = "0x6000BDB")]
				[Address(RVA = "0x1709C30", Offset = "0x1709C30", VA = "0x1709C30")]
				public void CrossFadeStart()
				{
				}

				[Token(Token = "0x6000BDC")]
				[Address(RVA = "0x170A090", Offset = "0x170A090", VA = "0x170A090")]
				public BoneLink()
				{
				}
			}

			[Token(Token = "0x400097F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9DC68C", Offset = "0x9DC68C")]
			public AnimationCurve aroundCenterOfMass;

			[Token(Token = "0x4000980")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9DC6C4", Offset = "0x9DC6C4")]
			public BoneLink[] boneLinks;

			[Token(Token = "0x4000981")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private Rigidbody rigidbody;

			[Token(Token = "0x6000AD5")]
			[Address(RVA = "0x1709AC4", Offset = "0x1709AC4", VA = "0x1709AC4", Slot = "4")]
			protected override float GetLength()
			{
				return default(float);
			}

			[Token(Token = "0x6000AD6")]
			[Address(RVA = "0x1709BA0", Offset = "0x1709BA0", VA = "0x1709BA0", Slot = "5")]
			protected override void CrossFadeStart()
			{
			}

			[Token(Token = "0x6000AD7")]
			[Address(RVA = "0x1709C4C", Offset = "0x1709C4C", VA = "0x1709C4C", Slot = "6")]
			protected override void OnApply(IKSolverFullBodyBiped solver, float weight)
			{
			}

			[Token(Token = "0x6000AD8")]
			[Address(RVA = "0x170A07C", Offset = "0x170A07C", VA = "0x170A07C")]
			public HitPointBone()
			{
			}
		}

		[Token(Token = "0x4000320")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9D87A4", Offset = "0x9D87A4")]
		public HitPointEffector[] effectorHitPoints;

		[Token(Token = "0x4000321")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9D87DC", Offset = "0x9D87DC")]
		public HitPointBone[] boneHitPoints;

		[Token(Token = "0x6000503")]
		[Address(RVA = "0x1709444", Offset = "0x1709444", VA = "0x1709444", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x6000504")]
		[Address(RVA = "0x17096C4", Offset = "0x17096C4", VA = "0x17096C4")]
		public void Hit(Collider collider, Vector3 force, Vector3 point)
		{
		}

		[Token(Token = "0x6000505")]
		[Address(RVA = "0x1709A58", Offset = "0x1709A58", VA = "0x1709A58")]
		public HitReaction()
		{
		}
	}
	[Token(Token = "0x2000071")]
	public class HitReactionVRIK : OffsetModifierVRIK
	{
		[Serializable]
		[Token(Token = "0x2000170")]
		public abstract class Offset
		{
			[Token(Token = "0x4000982")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9DC6FC", Offset = "0x9DC6FC")]
			public string name;

			[Token(Token = "0x4000983")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9DC734", Offset = "0x9DC734")]
			public Collider collider;

			[Token(Token = "0x4000984")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9DC76C", Offset = "0x9DC76C")]
			[SerializeField]
			private float crossFadeTime;

			[Token(Token = "0x4000985")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DC7B8", Offset = "0x9DC7B8")]
			private float <crossFader>k__BackingField;

			[Token(Token = "0x4000986")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DC7C8", Offset = "0x9DC7C8")]
			private float <timer>k__BackingField;

			[Token(Token = "0x4000987")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DC7D8", Offset = "0x9DC7D8")]
			private Vector3 <force>k__BackingField;

			[Token(Token = "0x4000988")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DC7E8", Offset = "0x9DC7E8")]
			private Vector3 <point>k__BackingField;

			[Token(Token = "0x4000989")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			private float length;

			[Token(Token = "0x400098A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private float crossFadeSpeed;

			[Token(Token = "0x400098B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			private float lastTime;

			[Token(Token = "0x170001D3")]
			protected float crossFader
			{
				[Token(Token = "0x6000AD9")]
				[Address(RVA = "0x170AD9C", Offset = "0x170AD9C", VA = "0x170AD9C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E0844", Offset = "0x9E0844")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000ADA")]
				[Address(RVA = "0x170ADA4", Offset = "0x170ADA4", VA = "0x170ADA4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E0854", Offset = "0x9E0854")]
				private set
				{
				}
			}

			[Token(Token = "0x170001D4")]
			protected float timer
			{
				[Token(Token = "0x6000ADB")]
				[Address(RVA = "0x170ADAC", Offset = "0x170ADAC", VA = "0x170ADAC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E0864", Offset = "0x9E0864")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000ADC")]
				[Address(RVA = "0x170ADB4", Offset = "0x170ADB4", VA = "0x170ADB4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E0874", Offset = "0x9E0874")]
				private set
				{
				}
			}

			[Token(Token = "0x170001D5")]
			protected Vector3 force
			{
				[Token(Token = "0x6000ADD")]
				[Address(RVA = "0x170ADBC", Offset = "0x170ADBC", VA = "0x170ADBC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E0884", Offset = "0x9E0884")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000ADE")]
				[Address(RVA = "0x170ADC8", Offset = "0x170ADC8", VA = "0x170ADC8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E0894", Offset = "0x9E0894")]
				private set
				{
				}
			}

			[Token(Token = "0x170001D6")]
			protected Vector3 point
			{
				[Token(Token = "0x6000ADF")]
				[Address(RVA = "0x170ADD4", Offset = "0x170ADD4", VA = "0x170ADD4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E08A4", Offset = "0x9E08A4")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000AE0")]
				[Address(RVA = "0x170ADE0", Offset = "0x170ADE0", VA = "0x170ADE0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E08B4", Offset = "0x9E08B4")]
				private set
				{
				}
			}

			[Token(Token = "0x6000AE1")]
			[Address(RVA = "0x170AC54", Offset = "0x170AC54", VA = "0x170AC54")]
			public void Hit(Vector3 force, AnimationCurve[] curves, Vector3 point)
			{
			}

			[Token(Token = "0x6000AE2")]
			[Address(RVA = "0x170A890", Offset = "0x170A890", VA = "0x170A890")]
			public void Apply(VRIK ik, AnimationCurve[] curves, float weight)
			{
			}

			[Token(Token = "0x6000AE3")]
			protected abstract float GetLength(AnimationCurve[] curves);

			[Token(Token = "0x6000AE4")]
			protected abstract void CrossFadeStart();

			[Token(Token = "0x6000AE5")]
			protected abstract void OnApply(VRIK ik, AnimationCurve[] curves, float weight);

			[Token(Token = "0x6000AE6")]
			[Address(RVA = "0x170ADEC", Offset = "0x170ADEC", VA = "0x170ADEC")]
			protected Offset()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000171")]
		public class PositionOffset : Offset
		{
			[Serializable]
			[Token(Token = "0x20001B8")]
			public class PositionOffsetLink
			{
				[Token(Token = "0x4000A96")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9DD21C", Offset = "0x9DD21C")]
				public IKSolverVR.PositionOffset positionOffset;

				[Token(Token = "0x4000A97")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9DD254", Offset = "0x9DD254")]
				public float weight;

				[Token(Token = "0x4000A98")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				private Vector3 lastValue;

				[Token(Token = "0x4000A99")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
				private Vector3 current;

				[Token(Token = "0x6000BDD")]
				[Address(RVA = "0x170B42C", Offset = "0x170B42C", VA = "0x170B42C")]
				public void Apply(VRIK ik, Vector3 offset, float crossFader)
				{
				}

				[Token(Token = "0x6000BDE")]
				[Address(RVA = "0x170B170", Offset = "0x170B170", VA = "0x170B170")]
				public void CrossFadeStart()
				{
				}

				[Token(Token = "0x6000BDF")]
				[Address(RVA = "0x170B57C", Offset = "0x170B57C", VA = "0x170B57C")]
				public PositionOffsetLink()
				{
				}
			}

			[Token(Token = "0x400098C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9DC7F8", Offset = "0x9DC7F8")]
			public int forceDirCurveIndex;

			[Token(Token = "0x400098D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9DC830", Offset = "0x9DC830")]
			public int upDirCurveIndex;

			[Token(Token = "0x400098E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9DC868", Offset = "0x9DC868")]
			public PositionOffsetLink[] offsetLinks;

			[Token(Token = "0x6000AE7")]
			[Address(RVA = "0x170AE00", Offset = "0x170AE00", VA = "0x170AE00", Slot = "4")]
			protected override float GetLength(AnimationCurve[] curves)
			{
				return default(float);
			}

			[Token(Token = "0x6000AE8")]
			[Address(RVA = "0x170B0E8", Offset = "0x170B0E8", VA = "0x170B0E8", Slot = "5")]
			protected override void CrossFadeStart()
			{
			}

			[Token(Token = "0x6000AE9")]
			[Address(RVA = "0x170B184", Offset = "0x170B184", VA = "0x170B184", Slot = "6")]
			protected override void OnApply(VRIK ik, AnimationCurve[] curves, float weight)
			{
			}

			[Token(Token = "0x6000AEA")]
			[Address(RVA = "0x170B560", Offset = "0x170B560", VA = "0x170B560")]
			public PositionOffset()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000172")]
		public class RotationOffset : Offset
		{
			[Serializable]
			[Token(Token = "0x20001B9")]
			public class RotationOffsetLink
			{
				[Token(Token = "0x4000A9A")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9DD28C", Offset = "0x9DD28C")]
				public IKSolverVR.RotationOffset rotationOffset;

				[Token(Token = "0x4000A9B")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9DD2C4", Offset = "0x9DD2C4")]
				[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9DD2C4", Offset = "0x9DD2C4")]
				public float weight;

				[Token(Token = "0x4000A9C")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				private Quaternion lastValue;

				[Token(Token = "0x4000A9D")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
				private Quaternion current;

				[Token(Token = "0x6000BE0")]
				[Address(RVA = "0x170BAF8", Offset = "0x170BAF8", VA = "0x170BAF8")]
				public void Apply(VRIK ik, Quaternion offset, float crossFader)
				{
				}

				[Token(Token = "0x6000BE1")]
				[Address(RVA = "0x170B778", Offset = "0x170B778", VA = "0x170B778")]
				public void CrossFadeStart()
				{
				}

				[Token(Token = "0x6000BE2")]
				[Address(RVA = "0x170BC70", Offset = "0x170BC70", VA = "0x170BC70")]
				public RotationOffsetLink()
				{
				}
			}

			[Token(Token = "0x400098F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9DC8A0", Offset = "0x9DC8A0")]
			public int curveIndex;

			[Token(Token = "0x4000990")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9DC8D8", Offset = "0x9DC8D8")]
			public RotationOffsetLink[] offsetLinks;

			[Token(Token = "0x4000991")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private Rigidbody rigidbody;

			[Token(Token = "0x6000AEB")]
			[Address(RVA = "0x170B584", Offset = "0x170B584", VA = "0x170B584", Slot = "4")]
			protected override float GetLength(AnimationCurve[] curves)
			{
				return default(float);
			}

			[Token(Token = "0x6000AEC")]
			[Address(RVA = "0x170B6E8", Offset = "0x170B6E8", VA = "0x170B6E8", Slot = "5")]
			protected override void CrossFadeStart()
			{
			}

			[Token(Token = "0x6000AED")]
			[Address(RVA = "0x170B794", Offset = "0x170B794", VA = "0x170B794", Slot = "6")]
			protected override void OnApply(VRIK ik, AnimationCurve[] curves, float weight)
			{
			}

			[Token(Token = "0x6000AEE")]
			[Address(RVA = "0x170BC5C", Offset = "0x170BC5C", VA = "0x170BC5C")]
			public RotationOffset()
			{
			}
		}

		[Token(Token = "0x4000322")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public AnimationCurve[] offsetCurves;

		[Token(Token = "0x4000323")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9D8814", Offset = "0x9D8814")]
		public PositionOffset[] positionOffsets;

		[Token(Token = "0x4000324")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9D884C", Offset = "0x9D884C")]
		public RotationOffset[] rotationOffsets;

		[Token(Token = "0x6000506")]
		[Address(RVA = "0x170A76C", Offset = "0x170A76C", VA = "0x170A76C", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x6000507")]
		[Address(RVA = "0x170A9E4", Offset = "0x170A9E4", VA = "0x170A9E4")]
		public void Hit(Collider collider, Vector3 force, Vector3 point)
		{
		}

		[Token(Token = "0x6000508")]
		[Address(RVA = "0x170AD94", Offset = "0x170AD94", VA = "0x170AD94")]
		public HitReactionVRIK()
		{
		}
	}
	[Token(Token = "0x2000072")]
	public class Inertia : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x2000173")]
		public class Body
		{
			[Serializable]
			[Token(Token = "0x20001BA")]
			public class EffectorLink
			{
				[Token(Token = "0x4000A9E")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9DD318", Offset = "0x9DD318")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x4000A9F")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9DD350", Offset = "0x9DD350")]
				public float weight;

				[Token(Token = "0x6000BE3")]
				[Address(RVA = "0xED0BE4", Offset = "0xED0BE4", VA = "0xED0BE4")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x4000992")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9DC910", Offset = "0x9DC910")]
			public Transform transform;

			[Token(Token = "0x4000993")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9DC948", Offset = "0x9DC948")]
			public EffectorLink[] effectorLinks;

			[Token(Token = "0x4000994")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9DC980", Offset = "0x9DC980")]
			public float speed;

			[Token(Token = "0x4000995")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9DC9B8", Offset = "0x9DC9B8")]
			public float acceleration;

			[Token(Token = "0x4000996")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9DC9F0", Offset = "0x9DC9F0")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9DC9F0", Offset = "0x9DC9F0")]
			public float matchVelocity;

			[Token(Token = "0x4000997")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9DCA44", Offset = "0x9DCA44")]
			public float gravity;

			[Token(Token = "0x4000998")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private Vector3 delta;

			[Token(Token = "0x4000999")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private Vector3 lazyPoint;

			[Token(Token = "0x400099A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private Vector3 direction;

			[Token(Token = "0x400099B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			private Vector3 lastPosition;

			[Token(Token = "0x400099C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private bool firstUpdate;

			[Token(Token = "0x6000AEF")]
			[Address(RVA = "0xED0508", Offset = "0xED0508", VA = "0xED0508")]
			public void Reset()
			{
			}

			[Token(Token = "0x6000AF0")]
			[Address(RVA = "0xED06F4", Offset = "0xED06F4", VA = "0xED06F4")]
			public void Update(IKSolverFullBodyBiped solver, float weight, float deltaTime)
			{
			}

			[Token(Token = "0x6000AF1")]
			[Address(RVA = "0xED0BC8", Offset = "0xED0BC8", VA = "0xED0BC8")]
			public Body()
			{
			}
		}

		[Token(Token = "0x4000325")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9D8884", Offset = "0x9D8884")]
		public Body[] bodies;

		[Token(Token = "0x4000326")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9D88BC", Offset = "0x9D88BC")]
		public OffsetLimits[] limits;

		[Token(Token = "0x6000509")]
		[Address(RVA = "0xED0478", Offset = "0xED0478", VA = "0xED0478")]
		public void ResetBodies()
		{
		}

		[Token(Token = "0x600050A")]
		[Address(RVA = "0xED05F8", Offset = "0xED05F8", VA = "0xED05F8", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x600050B")]
		[Address(RVA = "0xED0BA8", Offset = "0xED0BA8", VA = "0xED0BA8")]
		public Inertia()
		{
		}
	}
	[Token(Token = "0x2000073")]
	public abstract class OffsetModifier : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000174")]
		public class OffsetLimits
		{
			[Token(Token = "0x400099D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9DCA7C", Offset = "0x9DCA7C")]
			public FullBodyBipedEffector effector;

			[Token(Token = "0x400099E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9DCAB4", Offset = "0x9DCAB4")]
			public float spring;

			[Token(Token = "0x400099F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9DCAEC", Offset = "0x9DCAEC")]
			public bool x;

			[Token(Token = "0x40009A0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9DCB24", Offset = "0x9DCB24")]
			public bool y;

			[Token(Token = "0x40009A1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9DCB5C", Offset = "0x9DCB5C")]
			public bool z;

			[Token(Token = "0x40009A2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9DCB94", Offset = "0x9DCB94")]
			public float minX;

			[Token(Token = "0x40009A3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9DCBCC", Offset = "0x9DCBCC")]
			public float maxX;

			[Token(Token = "0x40009A4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9DCC04", Offset = "0x9DCC04")]
			public float minY;

			[Token(Token = "0x40009A5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9DCC3C", Offset = "0x9DCC3C")]
			public float maxY;

			[Token(Token = "0x40009A6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9DCC74", Offset = "0x9DCC74")]
			public float minZ;

			[Token(Token = "0x40009A7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9DCCAC", Offset = "0x9DCCAC")]
			public float maxZ;

			[Token(Token = "0x6000AF2")]
			[Address(RVA = "0xEDD55C", Offset = "0xEDD55C", VA = "0xEDD55C")]
			public void Apply(IKEffector e, Quaternion rootRotation)
			{
			}

			[Token(Token = "0x6000AF3")]
			[Address(RVA = "0xEDDAE8", Offset = "0xEDDAE8", VA = "0xEDDAE8")]
			private float SpringAxis(float value, float min, float max)
			{
				return default(float);
			}

			[Token(Token = "0x6000AF4")]
			[Address(RVA = "0xEDDB18", Offset = "0xEDDB18", VA = "0xEDDB18")]
			private float Spring(float value, float limit, bool negative)
			{
				return default(float);
			}

			[Token(Token = "0x6000AF5")]
			[Address(RVA = "0xEDDBF0", Offset = "0xEDDBF0", VA = "0xEDDBF0")]
			public OffsetLimits()
			{
			}
		}

		[Token(Token = "0x2000175")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9D5FDC", Offset = "0x9D5FDC")]
		private sealed class <Initiate>d__8 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40009A8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40009A9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40009AA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public OffsetModifier <>4__this;

			[Token(Token = "0x170001D7")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000AF9")]
				[Address(RVA = "0xEDDA70", Offset = "0xEDDA70", VA = "0xEDDA70", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170001D8")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000AFB")]
				[Address(RVA = "0xEDDAE0", Offset = "0xEDDAE0", VA = "0xEDDAE0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000AF6")]
			[Address(RVA = "0xEDD424", Offset = "0xEDD424", VA = "0xEDD424")]
			[DebuggerHidden]
			public <Initiate>d__8(int <>1__state)
			{
			}

			[Token(Token = "0x6000AF7")]
			[Address(RVA = "0xEDD904", Offset = "0xEDD904", VA = "0xEDD904", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000AF8")]
			[Address(RVA = "0xEDD908", Offset = "0xEDD908", VA = "0xEDD908", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000AFA")]
			[Address(RVA = "0xEDDA78", Offset = "0xEDDA78", VA = "0xEDDA78", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000327")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9D88F4", Offset = "0x9D88F4")]
		public float weight;

		[Token(Token = "0x4000328")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9D892C", Offset = "0x9D892C")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x4000329")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		protected float lastTime;

		[Token(Token = "0x170000A3")]
		protected float deltaTime
		{
			[Token(Token = "0x600050C")]
			[Address(RVA = "0xED06C8", Offset = "0xED06C8", VA = "0xED06C8")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x600050D")]
		protected abstract void OnModifyOffset();

		[Token(Token = "0x600050E")]
		[Address(RVA = "0xEDD384", Offset = "0xEDD384", VA = "0xEDD384", Slot = "5")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x600050F")]
		[Address(RVA = "0xEDD3B0", Offset = "0xEDD3B0", VA = "0xEDD3B0")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9DEF88", Offset = "0x9DEF88")]
		private IEnumerator Initiate()
		{
			return null;
		}

		[Token(Token = "0x6000510")]
		[Address(RVA = "0xEDD450", Offset = "0xEDD450", VA = "0xEDD450")]
		private void ModifyOffset()
		{
		}

		[Token(Token = "0x6000511")]
		[Address(RVA = "0xED0ABC", Offset = "0xED0ABC", VA = "0xED0ABC")]
		protected void ApplyLimits(OffsetLimits[] limits)
		{
		}

		[Token(Token = "0x6000512")]
		[Address(RVA = "0xEDD7E0", Offset = "0xEDD7E0", VA = "0xEDD7E0", Slot = "6")]
		protected virtual void OnDestroy()
		{
		}

		[Token(Token = "0x6000513")]
		[Address(RVA = "0xED0BB8", Offset = "0xED0BB8", VA = "0xED0BB8")]
		protected OffsetModifier()
		{
		}
	}
	[Token(Token = "0x2000074")]
	public abstract class OffsetModifierVRIK : MonoBehaviour
	{
		[Token(Token = "0x2000176")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9D5FEC", Offset = "0x9D5FEC")]
		private sealed class <Initiate>d__7 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40009AB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40009AC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40009AD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public OffsetModifierVRIK <>4__this;

			[Token(Token = "0x170001D9")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000AFF")]
				[Address(RVA = "0xEDE09C", Offset = "0xEDE09C", VA = "0xEDE09C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170001DA")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000B01")]
				[Address(RVA = "0xEDE10C", Offset = "0xEDE10C", VA = "0xEDE10C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000AFC")]
			[Address(RVA = "0xEDDCC4", Offset = "0xEDDCC4", VA = "0xEDDCC4")]
			[DebuggerHidden]
			public <Initiate>d__7(int <>1__state)
			{
			}

			[Token(Token = "0x6000AFD")]
			[Address(RVA = "0xEDDF30", Offset = "0xEDDF30", VA = "0xEDDF30", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000AFE")]
			[Address(RVA = "0xEDDF34", Offset = "0xEDDF34", VA = "0xEDDF34", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000B00")]
			[Address(RVA = "0xEDE0A4", Offset = "0xEDE0A4", VA = "0xEDE0A4", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400032A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9D8964", Offset = "0x9D8964")]
		public float weight;

		[Token(Token = "0x400032B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9D899C", Offset = "0x9D899C")]
		public VRIK ik;

		[Token(Token = "0x400032C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float lastTime;

		[Token(Token = "0x170000A4")]
		protected float deltaTime
		{
			[Token(Token = "0x6000514")]
			[Address(RVA = "0xEDDBF8", Offset = "0xEDDBF8", VA = "0xEDDBF8")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x6000515")]
		protected abstract void OnModifyOffset();

		[Token(Token = "0x6000516")]
		[Address(RVA = "0xEDDC24", Offset = "0xEDDC24", VA = "0xEDDC24", Slot = "5")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x6000517")]
		[Address(RVA = "0xEDDC50", Offset = "0xEDDC50", VA = "0xEDDC50")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9DEFEC", Offset = "0x9DEFEC")]
		private IEnumerator Initiate()
		{
			return null;
		}

		[Token(Token = "0x6000518")]
		[Address(RVA = "0xEDDCF0", Offset = "0xEDDCF0", VA = "0xEDDCF0")]
		private void ModifyOffset()
		{
		}

		[Token(Token = "0x6000519")]
		[Address(RVA = "0xEDDDFC", Offset = "0xEDDDFC", VA = "0xEDDDFC", Slot = "6")]
		protected virtual void OnDestroy()
		{
		}

		[Token(Token = "0x600051A")]
		[Address(RVA = "0xEDDF20", Offset = "0xEDDF20", VA = "0xEDDF20")]
		protected OffsetModifierVRIK()
		{
		}
	}
	[Token(Token = "0x2000075")]
	public class OffsetPose : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000177")]
		public class EffectorLink
		{
			[Token(Token = "0x40009AE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public FullBodyBipedEffector effector;

			[Token(Token = "0x40009AF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public Vector3 offset;

			[Token(Token = "0x40009B0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Vector3 pin;

			[Token(Token = "0x40009B1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public Vector3 pinWeight;

			[Token(Token = "0x6000B02")]
			[Address(RVA = "0xEDE22C", Offset = "0xEDE22C", VA = "0xEDE22C")]
			public void Apply(IKSolverFullBodyBiped solver, float weight, Quaternion rotation)
			{
			}

			[Token(Token = "0x6000B03")]
			[Address(RVA = "0xEDE768", Offset = "0xEDE768", VA = "0xEDE768")]
			public EffectorLink()
			{
			}
		}

		[Token(Token = "0x400032D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public EffectorLink[] effectorLinks;

		[Token(Token = "0x600051B")]
		[Address(RVA = "0xEDE114", Offset = "0xEDE114", VA = "0xEDE114")]
		public void Apply(IKSolverFullBodyBiped solver, float weight)
		{
		}

		[Token(Token = "0x600051C")]
		[Address(RVA = "0xEDE620", Offset = "0xEDE620", VA = "0xEDE620")]
		public void Apply(IKSolverFullBodyBiped solver, float weight, Quaternion rotation)
		{
		}

		[Token(Token = "0x600051D")]
		[Address(RVA = "0xEDE708", Offset = "0xEDE708", VA = "0xEDE708")]
		public OffsetPose()
		{
		}
	}
	[Token(Token = "0x2000076")]
	public class Recoil : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x2000178")]
		public class RecoilOffset
		{
			[Serializable]
			[Token(Token = "0x20001BB")]
			public class EffectorLink
			{
				[Token(Token = "0x4000AA0")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9DD388", Offset = "0x9DD388")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x4000AA1")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9DD3C0", Offset = "0x9DD3C0")]
				public float weight;

				[Token(Token = "0x6000BE4")]
				[Address(RVA = "0xEE1D94", Offset = "0xEE1D94", VA = "0xEE1D94")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x40009B2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9DCCE4", Offset = "0x9DCCE4")]
			public Vector3 offset;

			[Token(Token = "0x40009B3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9DCD1C", Offset = "0x9DCD1C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9DCD1C", Offset = "0x9DCD1C")]
			public float additivity;

			[Token(Token = "0x40009B4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9DCD70", Offset = "0x9DCD70")]
			public float maxAdditiveOffsetMag;

			[Token(Token = "0x40009B5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9DCDA8", Offset = "0x9DCDA8")]
			public EffectorLink[] effectorLinks;

			[Token(Token = "0x40009B6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private Vector3 additiveOffset;

			[Token(Token = "0x40009B7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private Vector3 lastOffset;

			[Token(Token = "0x6000B04")]
			[Address(RVA = "0xEE0C14", Offset = "0xEE0C14", VA = "0xEE0C14")]
			public void Start()
			{
			}

			[Token(Token = "0x6000B05")]
			[Address(RVA = "0xEE1658", Offset = "0xEE1658", VA = "0xEE1658")]
			public void Apply(IKSolverFullBodyBiped solver, Quaternion rotation, float masterWeight, float length, float timeLeft)
			{
			}

			[Token(Token = "0x6000B06")]
			[Address(RVA = "0xEE1D7C", Offset = "0xEE1D7C", VA = "0xEE1D7C")]
			public RecoilOffset()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000179")]
		public enum Handedness
		{
			[Token(Token = "0x40009B9")]
			Right,
			[Token(Token = "0x40009BA")]
			Left
		}

		[Token(Token = "0x400032E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9D89D4", Offset = "0x9D89D4")]
		public AimIK aimIK;

		[Token(Token = "0x400032F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9D8A0C", Offset = "0x9D8A0C")]
		public Handedness handedness;

		[Token(Token = "0x4000330")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9D8A44", Offset = "0x9D8A44")]
		public bool twoHanded;

		[Token(Token = "0x4000331")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9D8A7C", Offset = "0x9D8A7C")]
		public AnimationCurve recoilWeight;

		[Token(Token = "0x4000332")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9D8AB4", Offset = "0x9D8AB4")]
		public float magnitudeRandom;

		[Token(Token = "0x4000333")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9D8AEC", Offset = "0x9D8AEC")]
		public Vector3 rotationRandom;

		[Token(Token = "0x4000334")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9D8B24", Offset = "0x9D8B24")]
		public Vector3 handRotationOffset;

		[Token(Token = "0x4000335")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9D8B5C", Offset = "0x9D8B5C")]
		public float blendTime;

		[Token(Token = "0x4000336")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x9D8B94", Offset = "0x9D8B94")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9D8B94", Offset = "0x9D8B94")]
		public RecoilOffset[] offsets;

		[Token(Token = "0x4000337")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[HideInInspector]
		public Quaternion rotationOffset;

		[Token(Token = "0x4000338")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private float magnitudeMlp;

		[Token(Token = "0x4000339")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private float endTime;

		[Token(Token = "0x400033A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Quaternion handRotation;

		[Token(Token = "0x400033B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Quaternion secondaryHandRelativeRotation;

		[Token(Token = "0x400033C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Quaternion randomRotation;

		[Token(Token = "0x400033D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private float length;

		[Token(Token = "0x400033E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		private bool initiated;

		[Token(Token = "0x400033F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private float blendWeight;

		[Token(Token = "0x4000340")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private float w;

		[Token(Token = "0x4000341")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private Quaternion primaryHandRotation;

		[Token(Token = "0x4000342")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private bool handRotationsSet;

		[Token(Token = "0x170000A5")]
		private IKEffector primaryHandEffector
		{
			[Token(Token = "0x6000522")]
			[Address(RVA = "0xEE1940", Offset = "0xEE1940", VA = "0xEE1940")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000A6")]
		private IKEffector secondaryHandEffector
		{
			[Token(Token = "0x6000523")]
			[Address(RVA = "0xEE19A0", Offset = "0xEE19A0", VA = "0xEE19A0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000A7")]
		private Transform primaryHand
		{
			[Token(Token = "0x6000524")]
			[Address(RVA = "0xEE18E8", Offset = "0xEE18E8", VA = "0xEE18E8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000A8")]
		private Transform secondaryHand
		{
			[Token(Token = "0x6000525")]
			[Address(RVA = "0xEE1914", Offset = "0xEE1914", VA = "0xEE1914")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600051E")]
		[Address(RVA = "0xEE09E0", Offset = "0xEE09E0", VA = "0xEE09E0")]
		public void SetHandRotations(Quaternion leftHandRotation, Quaternion rightHandRotation)
		{
		}

		[Token(Token = "0x600051F")]
		[Address(RVA = "0xEE0A0C", Offset = "0xEE0A0C", VA = "0xEE0A0C")]
		public void Fire(float magnitude)
		{
		}

		[Token(Token = "0x6000520")]
		[Address(RVA = "0xEE0CC4", Offset = "0xEE0CC4", VA = "0xEE0CC4", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x6000521")]
		[Address(RVA = "0xEE1A00", Offset = "0xEE1A00", VA = "0xEE1A00")]
		private void AfterFBBIK()
		{
		}

		[Token(Token = "0x6000526")]
		[Address(RVA = "0xEE1B9C", Offset = "0xEE1B9C", VA = "0xEE1B9C", Slot = "6")]
		protected override void OnDestroy()
		{
		}

		[Token(Token = "0x6000527")]
		[Address(RVA = "0xEE1CC8", Offset = "0xEE1CC8", VA = "0xEE1CC8")]
		public Recoil()
		{
		}
	}
	[Token(Token = "0x2000077")]
	public class ShoulderRotator : MonoBehaviour
	{
		[Token(Token = "0x4000343")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9D8BF4", Offset = "0x9D8BF4")]
		public float weight;

		[Token(Token = "0x4000344")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9D8C2C", Offset = "0x9D8C2C")]
		public float offset;

		[Token(Token = "0x4000345")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private FullBodyBipedIK ik;

		[Token(Token = "0x4000346")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool skip;

		[Token(Token = "0x6000528")]
		[Address(RVA = "0xEE5B38", Offset = "0xEE5B38", VA = "0xEE5B38")]
		private void Start()
		{
		}

		[Token(Token = "0x6000529")]
		[Address(RVA = "0xEE5C38", Offset = "0xEE5C38", VA = "0xEE5C38")]
		private void RotateShoulders()
		{
		}

		[Token(Token = "0x600052A")]
		[Address(RVA = "0xEE5D50", Offset = "0xEE5D50", VA = "0xEE5D50")]
		private void RotateShoulder(FullBodyBipedChain chain, float weight, float offset)
		{
		}

		[Token(Token = "0x600052B")]
		[Address(RVA = "0xEE62E8", Offset = "0xEE62E8", VA = "0xEE62E8")]
		private IKMapping.BoneMap GetParentBoneMap(FullBodyBipedChain chain)
		{
			return null;
		}

		[Token(Token = "0x600052C")]
		[Address(RVA = "0xEE634C", Offset = "0xEE634C", VA = "0xEE634C")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600052D")]
		[Address(RVA = "0xEE6470", Offset = "0xEE6470", VA = "0xEE6470")]
		public ShoulderRotator()
		{
		}
	}
}
namespace RootMotion.Demos
{
	[Token(Token = "0x2000078")]
	public class BipedIKvsAnimatorIK : MonoBehaviour
	{
		[Token(Token = "0x4000347")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Animator animator;

		[Token(Token = "0x4000348")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public BipedIK bipedIK;

		[Token(Token = "0x4000349")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform lookAtTargetBiped;

		[Token(Token = "0x400034A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Transform lookAtTargetAnimator;

		[Token(Token = "0x400034B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float lookAtWeight;

		[Token(Token = "0x400034C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float lookAtBodyWeight;

		[Token(Token = "0x400034D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float lookAtHeadWeight;

		[Token(Token = "0x400034E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float lookAtEyesWeight;

		[Token(Token = "0x400034F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float lookAtClampWeight;

		[Token(Token = "0x4000350")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public float lookAtClampWeightHead;

		[Token(Token = "0x4000351")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public float lookAtClampWeightEyes;

		[Token(Token = "0x4000352")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform footTargetBiped;

		[Token(Token = "0x4000353")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Transform footTargetAnimator;

		[Token(Token = "0x4000354")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public float footPositionWeight;

		[Token(Token = "0x4000355")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public float footRotationWeight;

		[Token(Token = "0x4000356")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Transform handTargetBiped;

		[Token(Token = "0x4000357")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Transform handTargetAnimator;

		[Token(Token = "0x4000358")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public float handPositionWeight;

		[Token(Token = "0x4000359")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		public float handRotationWeight;

		[Token(Token = "0x600052E")]
		[Address(RVA = "0x1270470", Offset = "0x1270470", VA = "0x1270470")]
		private void OnAnimatorIK(int layer)
		{
		}

		[Token(Token = "0x600052F")]
		[Address(RVA = "0x1270D2C", Offset = "0x1270D2C", VA = "0x1270D2C")]
		public BipedIKvsAnimatorIK()
		{
		}
	}
	[Token(Token = "0x2000079")]
	public class MechSpider : MonoBehaviour
	{
		[Token(Token = "0x400035A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public LayerMask raycastLayers;

		[Token(Token = "0x400035B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float scale;

		[Token(Token = "0x400035C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform body;

		[Token(Token = "0x400035D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public MechSpiderLeg[] legs;

		[Token(Token = "0x400035E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float legRotationWeight;

		[Token(Token = "0x400035F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float rootPositionSpeed;

		[Token(Token = "0x4000360")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float rootRotationSpeed;

		[Token(Token = "0x4000361")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float breatheSpeed;

		[Token(Token = "0x4000362")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float breatheMagnitude;

		[Token(Token = "0x4000363")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float height;

		[Token(Token = "0x4000364")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float minHeight;

		[Token(Token = "0x4000365")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public float raycastHeight;

		[Token(Token = "0x4000366")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public float raycastDistance;

		[Token(Token = "0x4000367")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private Vector3 lastPosition;

		[Token(Token = "0x4000368")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Vector3 defaultBodyLocalPosition;

		[Token(Token = "0x4000369")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private float sine;

		[Token(Token = "0x400036A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private RaycastHit rootHit;

		[Token(Token = "0x6000530")]
		[Address(RVA = "0xF69B94", Offset = "0xF69B94", VA = "0xF69B94")]
		private void Update()
		{
		}

		[Token(Token = "0x6000531")]
		[Address(RVA = "0xF6A76C", Offset = "0xF6A76C", VA = "0xF6A76C")]
		private Vector3 GetLegCentroid()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000532")]
		[Address(RVA = "0xF6A3F0", Offset = "0xF6A3F0", VA = "0xF6A3F0")]
		private Vector3 GetLegsPlaneNormal()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000533")]
		[Address(RVA = "0xF6A968", Offset = "0xF6A968", VA = "0xF6A968")]
		public MechSpider()
		{
		}
	}
	[Token(Token = "0x200007A")]
	public class MechSpiderController : MonoBehaviour
	{
		[Token(Token = "0x400036B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public MechSpider mechSpider;

		[Token(Token = "0x400036C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform cameraTransform;

		[Token(Token = "0x400036D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float speed;

		[Token(Token = "0x400036E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float turnSpeed;

		[Token(Token = "0x170000A9")]
		public Vector3 inputVector
		{
			[Token(Token = "0x6000534")]
			[Address(RVA = "0xF6A994", Offset = "0xF6A994", VA = "0xF6A994")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x6000535")]
		[Address(RVA = "0xF6AA34", Offset = "0xF6AA34", VA = "0xF6AA34")]
		private void Update()
		{
		}

		[Token(Token = "0x6000536")]
		[Address(RVA = "0xF6AD68", Offset = "0xF6AD68", VA = "0xF6AD68")]
		public MechSpiderController()
		{
		}
	}
	[Token(Token = "0x200007B")]
	public class MechSpiderLeg : MonoBehaviour
	{
		[Token(Token = "0x200017A")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9D5FFC", Offset = "0x9D5FFC")]
		private sealed class <Step>d__24 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40009BB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40009BC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40009BD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public MechSpiderLeg <>4__this;

			[Token(Token = "0x40009BE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Vector3 stepStartPosition;

			[Token(Token = "0x40009BF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			public Vector3 targetPosition;

			[Token(Token = "0x170001DB")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000B0A")]
				[Address(RVA = "0xF6BC7C", Offset = "0xF6BC7C", VA = "0xF6BC7C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170001DC")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000B0C")]
				[Address(RVA = "0xF6BCEC", Offset = "0xF6BCEC", VA = "0xF6BCEC", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000B07")]
			[Address(RVA = "0xF6B840", Offset = "0xF6B840", VA = "0xF6B840")]
			[DebuggerHidden]
			public <Step>d__24(int <>1__state)
			{
			}

			[Token(Token = "0x6000B08")]
			[Address(RVA = "0xF6B89C", Offset = "0xF6B89C", VA = "0xF6B89C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000B09")]
			[Address(RVA = "0xF6B8A0", Offset = "0xF6B8A0", VA = "0xF6B8A0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000B0B")]
			[Address(RVA = "0xF6BC84", Offset = "0xF6BC84", VA = "0xF6BC84", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400036F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public MechSpider mechSpider;

		[Token(Token = "0x4000370")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public MechSpiderLeg unSync;

		[Token(Token = "0x4000371")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Vector3 offset;

		[Token(Token = "0x4000372")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float minDelay;

		[Token(Token = "0x4000373")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float maxOffset;

		[Token(Token = "0x4000374")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float stepSpeed;

		[Token(Token = "0x4000375")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float footHeight;

		[Token(Token = "0x4000376")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float velocityPrediction;

		[Token(Token = "0x4000377")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float raycastFocus;

		[Token(Token = "0x4000378")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public AnimationCurve yOffset;

		[Token(Token = "0x4000379")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public ParticleSystem sand;

		[Token(Token = "0x400037A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private IK ik;

		[Token(Token = "0x400037B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private float stepProgress;

		[Token(Token = "0x400037C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private float lastStepTime;

		[Token(Token = "0x400037D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Vector3 defaultPosition;

		[Token(Token = "0x400037E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private RaycastHit hit;

		[Token(Token = "0x170000AA")]
		public bool isStepping
		{
			[Token(Token = "0x6000537")]
			[Address(RVA = "0xF6AD7C", Offset = "0xF6AD7C", VA = "0xF6AD7C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000AB")]
		public Vector3 position
		{
			[Token(Token = "0x6000538")]
			[Address(RVA = "0xF6A918", Offset = "0xF6A918", VA = "0xF6A918")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000539")]
			[Address(RVA = "0xF6AD90", Offset = "0xF6AD90", VA = "0xF6AD90")]
			set
			{
			}
		}

		[Token(Token = "0x600053A")]
		[Address(RVA = "0xF6AE04", Offset = "0xF6AE04", VA = "0xF6AE04")]
		private void Start()
		{
		}

		[Token(Token = "0x600053B")]
		[Address(RVA = "0xF6B040", Offset = "0xF6B040", VA = "0xF6B040")]
		private Vector3 GetStepTarget(out bool stepFound, float focus, float distance)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600053C")]
		[Address(RVA = "0xF6B504", Offset = "0xF6B504", VA = "0xF6B504")]
		private void Update()
		{
		}

		[Token(Token = "0x600053D")]
		[Address(RVA = "0xF6B76C", Offset = "0xF6B76C", VA = "0xF6B76C")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9DF050", Offset = "0x9DF050")]
		private IEnumerator Step(Vector3 stepStartPosition, Vector3 targetPosition)
		{
			return null;
		}

		[Token(Token = "0x600053E")]
		[Address(RVA = "0xF6B86C", Offset = "0xF6B86C", VA = "0xF6B86C")]
		public MechSpiderLeg()
		{
		}
	}
	[Token(Token = "0x200007C")]
	public class MechSpiderParticles : MonoBehaviour
	{
		[Token(Token = "0x400037F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public MechSpiderController mechSpiderController;

		[Token(Token = "0x4000380")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private ParticleSystem particles;

		[Token(Token = "0x600053F")]
		[Address(RVA = "0xF6BCF4", Offset = "0xF6BCF4", VA = "0xF6BCF4")]
		private void Start()
		{
		}

		[Token(Token = "0x6000540")]
		[Address(RVA = "0xF6BDA4", Offset = "0xF6BDA4", VA = "0xF6BDA4")]
		private void Update()
		{
		}

		[Token(Token = "0x6000541")]
		[Address(RVA = "0xF6BF80", Offset = "0xF6BF80", VA = "0xF6BF80")]
		public MechSpiderParticles()
		{
		}
	}
	[Token(Token = "0x200007D")]
	public class AnimationWarping : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x200017B")]
		public struct Warp
		{
			[Token(Token = "0x40009C0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9DCDE0", Offset = "0x9DCDE0")]
			public int animationLayer;

			[Token(Token = "0x40009C1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9DCE18", Offset = "0x9DCE18")]
			public string animationState;

			[Token(Token = "0x40009C2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9DCE50", Offset = "0x9DCE50")]
			public AnimationCurve weightCurve;

			[Token(Token = "0x40009C3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9DCE88", Offset = "0x9DCE88")]
			public Transform warpFrom;

			[Token(Token = "0x40009C4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9DCEC0", Offset = "0x9DCEC0")]
			public Transform warpTo;

			[Token(Token = "0x40009C5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9DCEF8", Offset = "0x9DCEF8")]
			public FullBodyBipedEffector effector;
		}

		[Serializable]
		[Token(Token = "0x200017C")]
		public enum EffectorMode
		{
			[Token(Token = "0x40009C7")]
			PositionOffset,
			[Token(Token = "0x40009C8")]
			Position
		}

		[Token(Token = "0x4000381")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9D8C64", Offset = "0x9D8C64")]
		public Animator animator;

		[Token(Token = "0x4000382")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9D8C9C", Offset = "0x9D8C9C")]
		public EffectorMode effectorMode;

		[Token(Token = "0x4000383")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x9D8CD4", Offset = "0x9D8CD4")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9D8CD4", Offset = "0x9D8CD4")]
		public Warp[] warps;

		[Token(Token = "0x4000384")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private EffectorMode lastMode;

		[Token(Token = "0x6000542")]
		[Address(RVA = "0x126E278", Offset = "0x126E278", VA = "0x126E278", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x6000543")]
		[Address(RVA = "0x126E2A4", Offset = "0x126E2A4", VA = "0x126E2A4")]
		public float GetWarpWeight(int warpIndex)
		{
			return default(float);
		}

		[Token(Token = "0x6000544")]
		[Address(RVA = "0x126E510", Offset = "0x126E510", VA = "0x126E510", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x6000545")]
		[Address(RVA = "0x126EA34", Offset = "0x126EA34", VA = "0x126EA34")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000546")]
		[Address(RVA = "0x126EAFC", Offset = "0x126EAFC", VA = "0x126EAFC")]
		public AnimationWarping()
		{
		}
	}
	[Token(Token = "0x200007E")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x9D5748", Offset = "0x9D5748")]
	public class AnimatorController3rdPerson : MonoBehaviour
	{
		[Token(Token = "0x4000385")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float rotateSpeed;

		[Token(Token = "0x4000386")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float blendSpeed;

		[Token(Token = "0x4000387")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float maxAngle;

		[Token(Token = "0x4000388")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float moveSpeed;

		[Token(Token = "0x4000389")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float rootMotionWeight;

		[Token(Token = "0x400038A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		protected Animator animator;

		[Token(Token = "0x400038B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		protected Vector3 moveBlend;

		[Token(Token = "0x400038C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		protected Vector3 moveInput;

		[Token(Token = "0x400038D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		protected Vector3 velocity;

		[Token(Token = "0x6000547")]
		[Address(RVA = "0x126EB04", Offset = "0x126EB04", VA = "0x126EB04", Slot = "4")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x6000548")]
		[Address(RVA = "0x126EB5C", Offset = "0x126EB5C", VA = "0x126EB5C")]
		private void OnAnimatorMove()
		{
		}

		[Token(Token = "0x6000549")]
		[Address(RVA = "0x126EDD8", Offset = "0x126EDD8", VA = "0x126EDD8", Slot = "5")]
		public virtual void Move(Vector3 moveInput, bool isMoving, Vector3 faceDirection, Vector3 aimTarget)
		{
		}

		[Token(Token = "0x600054A")]
		[Address(RVA = "0x126F09C", Offset = "0x126F09C", VA = "0x126F09C")]
		public AnimatorController3rdPerson()
		{
		}
	}
	[Token(Token = "0x200007F")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x9D57AC", Offset = "0x9D57AC")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x9D57AC", Offset = "0x9D57AC")]
	public class AnimatorController3rdPersonIK : AnimatorController3rdPerson
	{
		[Token(Token = "0x400038E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9D8D24", Offset = "0x9D8D24")]
		public float headLookWeight;

		[Token(Token = "0x400038F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Vector3 gunHoldOffset;

		[Token(Token = "0x4000390")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public Vector3 leftHandOffset;

		[Token(Token = "0x4000391")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Recoil recoil;

		[Token(Token = "0x4000392")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private AimIK aim;

		[Token(Token = "0x4000393")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private FullBodyBipedIK ik;

		[Token(Token = "0x4000394")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Vector3 headLookAxis;

		[Token(Token = "0x4000395")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private Vector3 leftHandPosRelToRightHand;

		[Token(Token = "0x4000396")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Quaternion leftHandRotRelToRightHand;

		[Token(Token = "0x4000397")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private Vector3 aimTarget;

		[Token(Token = "0x4000398")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private Quaternion rightHandRotation;

		[Token(Token = "0x600054B")]
		[Address(RVA = "0x126F0B0", Offset = "0x126F0B0", VA = "0x126F0B0", Slot = "4")]
		protected override void Start()
		{
		}

		[Token(Token = "0x600054C")]
		[Address(RVA = "0x126F2D8", Offset = "0x126F2D8", VA = "0x126F2D8", Slot = "5")]
		public override void Move(Vector3 moveInput, bool isMoving, Vector3 faceDirection, Vector3 aimTarget)
		{
		}

		[Token(Token = "0x600054D")]
		[Address(RVA = "0x126F34C", Offset = "0x126F34C", VA = "0x126F34C")]
		private void Read()
		{
		}

		[Token(Token = "0x600054E")]
		[Address(RVA = "0x126F53C", Offset = "0x126F53C", VA = "0x126F53C")]
		private void AimIK()
		{
		}

		[Token(Token = "0x600054F")]
		[Address(RVA = "0x126F5C0", Offset = "0x126F5C0", VA = "0x126F5C0")]
		private void FBBIK()
		{
		}

		[Token(Token = "0x6000550")]
		[Address(RVA = "0x126FD7C", Offset = "0x126FD7C", VA = "0x126FD7C")]
		private void OnPreRead()
		{
		}

		[Token(Token = "0x6000551")]
		[Address(RVA = "0x126FAC0", Offset = "0x126FAC0", VA = "0x126FAC0")]
		private void HeadLookAt(Vector3 lookAtTarget)
		{
		}

		[Token(Token = "0x6000552")]
		[Address(RVA = "0x127015C", Offset = "0x127015C", VA = "0x127015C")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000553")]
		[Address(RVA = "0x1270280", Offset = "0x1270280", VA = "0x1270280")]
		public AnimatorController3rdPersonIK()
		{
		}
	}
	[Token(Token = "0x2000080")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x9D5838", Offset = "0x9D5838")]
	public class CharacterAnimationThirdPersonIK : CharacterAnimationThirdPerson
	{
		[Token(Token = "0x4000399")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private FullBodyBipedIK ik;

		[Token(Token = "0x6000554")]
		[Address(RVA = "0x1271F2C", Offset = "0x1271F2C", VA = "0x1271F2C", Slot = "6")]
		protected override void Start()
		{
		}

		[Token(Token = "0x6000555")]
		[Address(RVA = "0x1271F8C", Offset = "0x1271F8C", VA = "0x1271F8C", Slot = "7")]
		protected override void LateUpdate()
		{
		}

		[Token(Token = "0x6000556")]
		[Address(RVA = "0x12722CC", Offset = "0x12722CC", VA = "0x12722CC")]
		private void RotateEffector(IKEffector effector, Quaternion rotation, float mlp)
		{
		}

		[Token(Token = "0x6000557")]
		[Address(RVA = "0x1272494", Offset = "0x1272494", VA = "0x1272494")]
		public CharacterAnimationThirdPersonIK()
		{
		}
	}
	[Token(Token = "0x2000081")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x9D589C", Offset = "0x9D589C")]
	public class CharacterController3rdPerson : MonoBehaviour
	{
		[Token(Token = "0x400039A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private CameraController cam;

		[Token(Token = "0x400039B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private AnimatorController3rdPerson animatorController;

		[Token(Token = "0x170000AC")]
		private static Vector3 inputVector
		{
			[Token(Token = "0x600055A")]
			[Address(RVA = "0x12734A4", Offset = "0x12734A4", VA = "0x12734A4")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x170000AD")]
		private static Vector3 inputVectorRaw
		{
			[Token(Token = "0x600055B")]
			[Address(RVA = "0x1273544", Offset = "0x1273544", VA = "0x1273544")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x6000558")]
		[Address(RVA = "0x12731A0", Offset = "0x12731A0", VA = "0x12731A0")]
		private void Start()
		{
		}

		[Token(Token = "0x6000559")]
		[Address(RVA = "0x1273214", Offset = "0x1273214", VA = "0x1273214")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600055C")]
		[Address(RVA = "0x12735E4", Offset = "0x12735E4", VA = "0x12735E4")]
		public CharacterController3rdPerson()
		{
		}
	}
	[Token(Token = "0x2000082")]
	public class EffectorOffset : OffsetModifier
	{
		[Token(Token = "0x400039C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9D8D4C", Offset = "0x9D8D4C")]
		public float handsMaintainRelativePositionWeight;

		[Token(Token = "0x400039D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Vector3 bodyOffset;

		[Token(Token = "0x400039E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public Vector3 leftShoulderOffset;

		[Token(Token = "0x400039F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Vector3 rightShoulderOffset;

		[Token(Token = "0x40003A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public Vector3 leftThighOffset;

		[Token(Token = "0x40003A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Vector3 rightThighOffset;

		[Token(Token = "0x40003A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public Vector3 leftHandOffset;

		[Token(Token = "0x40003A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Vector3 rightHandOffset;

		[Token(Token = "0x40003A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		public Vector3 leftFootOffset;

		[Token(Token = "0x40003A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public Vector3 rightFootOffset;

		[Token(Token = "0x600055D")]
		[Address(RVA = "0x1275F58", Offset = "0x1275F58", VA = "0x1275F58", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x600055E")]
		[Address(RVA = "0x12766B8", Offset = "0x12766B8", VA = "0x12766B8")]
		public EffectorOffset()
		{
		}
	}
	[Token(Token = "0x2000083")]
	public class ExplosionDemo : MonoBehaviour
	{
		[Token(Token = "0x40003A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public SimpleLocomotion character;

		[Token(Token = "0x40003A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float forceMlp;

		[Token(Token = "0x40003A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float upForce;

		[Token(Token = "0x40003A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float weightFalloffSpeed;

		[Token(Token = "0x40003AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public AnimationCurve weightFalloff;

		[Token(Token = "0x40003AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public AnimationCurve explosionForceByDistance;

		[Token(Token = "0x40003AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public AnimationCurve scale;

		[Token(Token = "0x40003AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float weight;

		[Token(Token = "0x40003AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Vector3 defaultScale;

		[Token(Token = "0x40003AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Rigidbody r;

		[Token(Token = "0x40003B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private FullBodyBipedIK ik;

		[Token(Token = "0x600055F")]
		[Address(RVA = "0x12766C0", Offset = "0x12766C0", VA = "0x12766C0")]
		private void Start()
		{
		}

		[Token(Token = "0x6000560")]
		[Address(RVA = "0x127677C", Offset = "0x127677C", VA = "0x127677C")]
		private void Update()
		{
		}

		[Token(Token = "0x6000561")]
		[Address(RVA = "0x1276DE8", Offset = "0x1276DE8", VA = "0x1276DE8")]
		private void SetEffectorWeights(float w)
		{
		}

		[Token(Token = "0x6000562")]
		[Address(RVA = "0x1276F00", Offset = "0x1276F00", VA = "0x1276F00")]
		public ExplosionDemo()
		{
		}
	}
	[Token(Token = "0x2000084")]
	public class FBBIKSettings : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x200017D")]
		public class Limb
		{
			[Token(Token = "0x40009C9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public FBIKChain.Smoothing reachSmoothing;

			[Token(Token = "0x40009CA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public float maintainRelativePositionWeight;

			[Token(Token = "0x40009CB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float mappingWeight;

			[Token(Token = "0x6000B0D")]
			[Address(RVA = "0x1277178", Offset = "0x1277178", VA = "0x1277178")]
			public void Apply(FullBodyBipedChain chain, IKSolverFullBodyBiped solver)
			{
			}

			[Token(Token = "0x6000B0E")]
			[Address(RVA = "0x12772EC", Offset = "0x12772EC", VA = "0x12772EC")]
			public Limb()
			{
			}
		}

		[Token(Token = "0x40003B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x40003B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool disableAfterStart;

		[Token(Token = "0x40003B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Limb leftArm;

		[Token(Token = "0x40003B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Limb rightArm;

		[Token(Token = "0x40003B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Limb leftLeg;

		[Token(Token = "0x40003B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Limb rightLeg;

		[Token(Token = "0x40003B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float rootPin;

		[Token(Token = "0x40003B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public bool bodyEffectChildNodes;

		[Token(Token = "0x6000563")]
		[Address(RVA = "0x1276F88", Offset = "0x1276F88", VA = "0x1276F88")]
		public void UpdateSettings()
		{
		}

		[Token(Token = "0x6000564")]
		[Address(RVA = "0x127723C", Offset = "0x127723C", VA = "0x127723C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000565")]
		[Address(RVA = "0x12772D8", Offset = "0x12772D8", VA = "0x12772D8")]
		private void Update()
		{
		}

		[Token(Token = "0x6000566")]
		[Address(RVA = "0x12772DC", Offset = "0x12772DC", VA = "0x12772DC")]
		public FBBIKSettings()
		{
		}
	}
	[Token(Token = "0x2000085")]
	public class FBIKBendGoal : MonoBehaviour
	{
		[Token(Token = "0x40003B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x40003BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public FullBodyBipedChain chain;

		[Token(Token = "0x40003BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float weight;

		[Token(Token = "0x6000567")]
		[Address(RVA = "0x12772FC", Offset = "0x12772FC", VA = "0x12772FC")]
		private void Start()
		{
		}

		[Token(Token = "0x6000568")]
		[Address(RVA = "0x1277368", Offset = "0x1277368", VA = "0x1277368")]
		private void Update()
		{
		}

		[Token(Token = "0x6000569")]
		[Address(RVA = "0x1277488", Offset = "0x1277488", VA = "0x1277488")]
		public FBIKBendGoal()
		{
		}
	}
	[Token(Token = "0x2000086")]
	public class FBIKBoxing : MonoBehaviour
	{
		[Token(Token = "0x40003BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9D8D64", Offset = "0x9D8D64")]
		public Transform target;

		[Token(Token = "0x40003BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9D8D9C", Offset = "0x9D8D9C")]
		public Transform pin;

		[Token(Token = "0x40003BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9D8DD4", Offset = "0x9D8DD4")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x40003BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9D8E0C", Offset = "0x9D8E0C")]
		public AimIK aim;

		[Token(Token = "0x40003C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9D8E44", Offset = "0x9D8E44")]
		public float weight;

		[Token(Token = "0x40003C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9D8E7C", Offset = "0x9D8E7C")]
		public FullBodyBipedEffector effector;

		[Token(Token = "0x40003C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9D8EB4", Offset = "0x9D8EB4")]
		public AnimationCurve aimWeight;

		[Token(Token = "0x40003C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Animator animator;

		[Token(Token = "0x600056A")]
		[Address(RVA = "0x1277490", Offset = "0x1277490", VA = "0x1277490")]
		private void Start()
		{
		}

		[Token(Token = "0x600056B")]
		[Address(RVA = "0x12774E8", Offset = "0x12774E8", VA = "0x12774E8")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600056C")]
		[Address(RVA = "0x1277774", Offset = "0x1277774", VA = "0x1277774")]
		public FBIKBoxing()
		{
		}
	}
	[Token(Token = "0x2000087")]
	public class FBIKHandsOnProp : MonoBehaviour
	{
		[Token(Token = "0x40003C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x40003C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool leftHanded;

		[Token(Token = "0x600056D")]
		[Address(RVA = "0x127777C", Offset = "0x127777C", VA = "0x127777C")]
		private void Awake()
		{
		}

		[Token(Token = "0x600056E")]
		[Address(RVA = "0x1277868", Offset = "0x1277868", VA = "0x1277868")]
		private void OnPreRead()
		{
		}

		[Token(Token = "0x600056F")]
		[Address(RVA = "0x127793C", Offset = "0x127793C", VA = "0x127793C")]
		private void HandsOnProp(IKEffector mainHand, IKEffector otherHand)
		{
		}

		[Token(Token = "0x6000570")]
		[Address(RVA = "0x1277E48", Offset = "0x1277E48", VA = "0x1277E48")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000571")]
		[Address(RVA = "0x1277F6C", Offset = "0x1277F6C", VA = "0x1277F6C")]
		public FBIKHandsOnProp()
		{
		}
	}
	[Token(Token = "0x2000088")]
	public class FPSAiming : MonoBehaviour
	{
		[Token(Token = "0x40003C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9D8EEC", Offset = "0x9D8EEC")]
		public float aimWeight;

		[Token(Token = "0x40003C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9D8F04", Offset = "0x9D8F04")]
		public float sightWeight;

		[Token(Token = "0x40003C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9D8F1C", Offset = "0x9D8F1C")]
		public float maxAngle;

		[Token(Token = "0x40003C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[SerializeField]
		private bool animatePhysics;

		[Token(Token = "0x40003CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Transform gun;

		[Token(Token = "0x40003CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Transform gunTarget;

		[Token(Token = "0x40003CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private FullBodyBipedIK ik;

		[Token(Token = "0x40003CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private AimIK gunAim;

		[Token(Token = "0x40003CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private CameraControllerFPS cam;

		[Token(Token = "0x40003CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Recoil recoil;

		[Token(Token = "0x40003D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9D8FA8", Offset = "0x9D8FA8")]
		private float cameraRecoilWeight;

		[Token(Token = "0x40003D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private Vector3 gunTargetDefaultLocalPosition;

		[Token(Token = "0x40003D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Quaternion gunTargetDefaultLocalRotation;

		[Token(Token = "0x40003D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Vector3 camDefaultLocalPosition;

		[Token(Token = "0x40003D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private Vector3 camRelativeToGunTarget;

		[Token(Token = "0x40003D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private bool updateFrame;

		[Token(Token = "0x6000572")]
		[Address(RVA = "0x1277F74", Offset = "0x1277F74", VA = "0x1277F74")]
		private void Start()
		{
		}

		[Token(Token = "0x6000573")]
		[Address(RVA = "0x1278134", Offset = "0x1278134", VA = "0x1278134")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000574")]
		[Address(RVA = "0x1278140", Offset = "0x1278140", VA = "0x1278140")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000575")]
		[Address(RVA = "0x12785BC", Offset = "0x12785BC", VA = "0x12785BC")]
		private void Aiming()
		{
		}

		[Token(Token = "0x6000576")]
		[Address(RVA = "0x127882C", Offset = "0x127882C", VA = "0x127882C")]
		private void LookDownTheSight()
		{
		}

		[Token(Token = "0x6000577")]
		[Address(RVA = "0x127828C", Offset = "0x127828C", VA = "0x127828C")]
		private void RotateCharacter()
		{
		}

		[Token(Token = "0x6000578")]
		[Address(RVA = "0x1279640", Offset = "0x1279640", VA = "0x1279640")]
		public FPSAiming()
		{
		}
	}
	[Token(Token = "0x2000089")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x9D5900", Offset = "0x9D5900")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x9D5900", Offset = "0x9D5900")]
	public class FPSCharacter : MonoBehaviour
	{
		[Token(Token = "0x40003D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9D8FE8", Offset = "0x9D8FE8")]
		public float walkSpeed;

		[Token(Token = "0x40003D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private float sVel;

		[Token(Token = "0x40003D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Animator animator;

		[Token(Token = "0x40003D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private FPSAiming FPSAiming;

		[Token(Token = "0x6000579")]
		[Address(RVA = "0xF66ADC", Offset = "0xF66ADC", VA = "0xF66ADC")]
		private void Start()
		{
		}

		[Token(Token = "0x600057A")]
		[Address(RVA = "0xF66B4C", Offset = "0xF66B4C", VA = "0xF66B4C")]
		private void Update()
		{
		}

		[Token(Token = "0x600057B")]
		[Address(RVA = "0xF66CB4", Offset = "0xF66CB4", VA = "0xF66CB4")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x600057C")]
		[Address(RVA = "0xF66D64", Offset = "0xF66D64", VA = "0xF66D64")]
		public FPSCharacter()
		{
		}
	}
	[Token(Token = "0x200008A")]
	public class HitReactionTrigger : MonoBehaviour
	{
		[Token(Token = "0x40003DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private HitReaction hitReaction;

		[Token(Token = "0x40003DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float hitForce;

		[Token(Token = "0x40003DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private string colliderName;

		[Token(Token = "0x600057D")]
		[Address(RVA = "0xF678B0", Offset = "0xF678B0", VA = "0xF678B0")]
		private void Update()
		{
		}

		[Token(Token = "0x600057E")]
		[Address(RVA = "0xF67ABC", Offset = "0xF67ABC", VA = "0xF67ABC")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x600057F")]
		[Address(RVA = "0xF67B8C", Offset = "0xF67B8C", VA = "0xF67B8C")]
		public HitReactionTrigger()
		{
		}
	}
	[Token(Token = "0x200008B")]
	public class HoldingHands : MonoBehaviour
	{
		[Token(Token = "0x40003DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public FullBodyBipedIK rightHandChar;

		[Token(Token = "0x40003DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public FullBodyBipedIK leftHandChar;

		[Token(Token = "0x40003DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform rightHandTarget;

		[Token(Token = "0x40003E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Transform leftHandTarget;

		[Token(Token = "0x40003E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float crossFade;

		[Token(Token = "0x40003E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float speed;

		[Token(Token = "0x40003E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Quaternion rightHandRotation;

		[Token(Token = "0x40003E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Quaternion leftHandRotation;

		[Token(Token = "0x6000580")]
		[Address(RVA = "0xF67B9C", Offset = "0xF67B9C", VA = "0xF67B9C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000581")]
		[Address(RVA = "0xF67DAC", Offset = "0xF67DAC", VA = "0xF67DAC")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000582")]
		[Address(RVA = "0xF68328", Offset = "0xF68328", VA = "0xF68328")]
		public HoldingHands()
		{
		}
	}
	[Token(Token = "0x200008C")]
	public class InteractionC2CDemo : MonoBehaviour
	{
		[Token(Token = "0x40003E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public InteractionSystem character1;

		[Token(Token = "0x40003E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public InteractionSystem character2;

		[Token(Token = "0x40003E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public InteractionObject handShake;

		[Token(Token = "0x6000583")]
		[Address(RVA = "0xF68338", Offset = "0xF68338", VA = "0xF68338")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000584")]
		[Address(RVA = "0xF68414", Offset = "0xF68414", VA = "0xF68414")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000585")]
		[Address(RVA = "0xF685E8", Offset = "0xF685E8", VA = "0xF685E8")]
		public InteractionC2CDemo()
		{
		}
	}
	[Token(Token = "0x200008D")]
	public class InteractionDemo : MonoBehaviour
	{
		[Token(Token = "0x40003E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public InteractionSystem interactionSystem;

		[Token(Token = "0x40003E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool interrupt;

		[Token(Token = "0x40003EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public InteractionObject ball;

		[Token(Token = "0x40003EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public InteractionObject benchMain;

		[Token(Token = "0x40003EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public InteractionObject benchHands;

		[Token(Token = "0x40003ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public InteractionObject button;

		[Token(Token = "0x40003EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public InteractionObject cigarette;

		[Token(Token = "0x40003EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public InteractionObject door;

		[Token(Token = "0x40003F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private bool isSitting;

		[Token(Token = "0x6000586")]
		[Address(RVA = "0xF685F0", Offset = "0xF685F0", VA = "0xF685F0")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000587")]
		[Address(RVA = "0xF68A40", Offset = "0xF68A40", VA = "0xF68A40")]
		public InteractionDemo()
		{
		}
	}
	[Token(Token = "0x200008E")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x9D598C", Offset = "0x9D598C")]
	public class InteractionSystemTestGUI : MonoBehaviour
	{
		[Token(Token = "0x40003F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9D9020", Offset = "0x9D9020")]
		[SerializeField]
		private InteractionObject interactionObject;

		[Token(Token = "0x40003F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9D906C", Offset = "0x9D906C")]
		[SerializeField]
		private FullBodyBipedEffector[] effectors;

		[Token(Token = "0x40003F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private InteractionSystem interactionSystem;

		[Token(Token = "0x6000588")]
		[Address(RVA = "0xF68A48", Offset = "0xF68A48", VA = "0xF68A48")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000589")]
		[Address(RVA = "0xF68AA0", Offset = "0xF68AA0", VA = "0xF68AA0")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x600058A")]
		[Address(RVA = "0xF68D48", Offset = "0xF68D48", VA = "0xF68D48")]
		public InteractionSystemTestGUI()
		{
		}
	}
	[Token(Token = "0x200008F")]
	public class KissingRig : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x200017E")]
		public class Partner
		{
			[Token(Token = "0x40009CC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public FullBodyBipedIK ik;

			[Token(Token = "0x40009CD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Transform mouth;

			[Token(Token = "0x40009CE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Transform mouthTarget;

			[Token(Token = "0x40009CF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Transform touchTargetLeftHand;

			[Token(Token = "0x40009D0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Transform touchTargetRightHand;

			[Token(Token = "0x40009D1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public float bodyWeightHorizontal;

			[Token(Token = "0x40009D2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public float bodyWeightVertical;

			[Token(Token = "0x40009D3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public float neckRotationWeight;

			[Token(Token = "0x40009D4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			public float headTiltAngle;

			[Token(Token = "0x40009D5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public Vector3 headTiltAxis;

			[Token(Token = "0x40009D6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			private Quaternion neckRotation;

			[Token(Token = "0x170001DD")]
			private Transform neck
			{
				[Token(Token = "0x6000B11")]
				[Address(RVA = "0xF69AA4", Offset = "0xF69AA4", VA = "0xF69AA4")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000B0F")]
			[Address(RVA = "0xF68D98", Offset = "0xF68D98", VA = "0xF68D98")]
			public void Initiate()
			{
			}

			[Token(Token = "0x6000B10")]
			[Address(RVA = "0xF68E58", Offset = "0xF68E58", VA = "0xF68E58")]
			public void Update(float weight)
			{
			}

			[Token(Token = "0x6000B12")]
			[Address(RVA = "0xF69850", Offset = "0xF69850", VA = "0xF69850")]
			private void InverseTransformEffector(FullBodyBipedEffector effector, Transform target, Vector3 targetPosition, float weight)
			{
			}

			[Token(Token = "0x6000B13")]
			[Address(RVA = "0xF69B80", Offset = "0xF69B80", VA = "0xF69B80")]
			public Partner()
			{
			}
		}

		[Token(Token = "0x40003F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Partner partner1;

		[Token(Token = "0x40003F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Partner partner2;

		[Token(Token = "0x40003F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float weight;

		[Token(Token = "0x40003F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public int iterations;

		[Token(Token = "0x600058B")]
		[Address(RVA = "0xF68D50", Offset = "0xF68D50", VA = "0xF68D50")]
		private void Start()
		{
		}

		[Token(Token = "0x600058C")]
		[Address(RVA = "0xF68DCC", Offset = "0xF68DCC", VA = "0xF68DCC")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600058D")]
		[Address(RVA = "0xF69840", Offset = "0xF69840", VA = "0xF69840")]
		public KissingRig()
		{
		}
	}
	[Token(Token = "0x2000090")]
	public class MotionAbsorb : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x200017F")]
		public class Absorber
		{
			[Token(Token = "0x40009D7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9DCF30", Offset = "0x9DCF30")]
			public FullBodyBipedEffector effector;

			[Token(Token = "0x40009D8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9DCF68", Offset = "0x9DCF68")]
			public float weight;

			[Token(Token = "0x6000B14")]
			[Address(RVA = "0xF6C8AC", Offset = "0xF6C8AC", VA = "0xF6C8AC")]
			public void SetToBone(IKSolverFullBodyBiped solver)
			{
			}

			[Token(Token = "0x6000B15")]
			[Address(RVA = "0xF6CA30", Offset = "0xF6CA30", VA = "0xF6CA30")]
			public void SetEffectorWeights(IKSolverFullBodyBiped solver, float w)
			{
			}

			[Token(Token = "0x6000B16")]
			[Address(RVA = "0xF6CB4C", Offset = "0xF6CB4C", VA = "0xF6CB4C")]
			public Absorber()
			{
			}
		}

		[Token(Token = "0x2000180")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9D600C", Offset = "0x9D600C")]
		private sealed class <AbsorbMotion>d__8 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40009D9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40009DA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40009DB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public MotionAbsorb <>4__this;

			[Token(Token = "0x170001DE")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000B1A")]
				[Address(RVA = "0xF6CAD4", Offset = "0xF6CAD4", VA = "0xF6CAD4", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170001DF")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000B1C")]
				[Address(RVA = "0xF6CB44", Offset = "0xF6CB44", VA = "0xF6CB44", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000B17")]
			[Address(RVA = "0xF6C658", Offset = "0xF6C658", VA = "0xF6C658")]
			[DebuggerHidden]
			public <AbsorbMotion>d__8(int <>1__state)
			{
			}

			[Token(Token = "0x6000B18")]
			[Address(RVA = "0xF6C698", Offset = "0xF6C698", VA = "0xF6C698", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000B19")]
			[Address(RVA = "0xF6C69C", Offset = "0xF6C69C", VA = "0xF6C69C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000B1B")]
			[Address(RVA = "0xF6CADC", Offset = "0xF6CADC", VA = "0xF6CADC", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40003F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9D90B8", Offset = "0x9D90B8")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x40003F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9D90F0", Offset = "0x9D90F0")]
		public Absorber[] absorbers;

		[Token(Token = "0x40003FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9D9128", Offset = "0x9D9128")]
		public float weight;

		[Token(Token = "0x40003FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9D9160", Offset = "0x9D9160")]
		public AnimationCurve falloff;

		[Token(Token = "0x40003FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9D9198", Offset = "0x9D9198")]
		public float falloffSpeed;

		[Token(Token = "0x40003FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private float timer;

		[Token(Token = "0x600058E")]
		[Address(RVA = "0xF6C59C", Offset = "0xF6C59C", VA = "0xF6C59C")]
		private void OnCollisionEnter()
		{
		}

		[Token(Token = "0x600058F")]
		[Address(RVA = "0xF6C5E4", Offset = "0xF6C5E4", VA = "0xF6C5E4")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9DF0B4", Offset = "0x9DF0B4")]
		private IEnumerator AbsorbMotion()
		{
			return null;
		}

		[Token(Token = "0x6000590")]
		[Address(RVA = "0xF6C684", Offset = "0xF6C684", VA = "0xF6C684")]
		public MotionAbsorb()
		{
		}
	}
	[Token(Token = "0x2000091")]
	public class MotionAbsorbCharacter : MonoBehaviour
	{
		[Token(Token = "0x40003FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Animator animator;

		[Token(Token = "0x40003FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public MotionAbsorb motionAbsorb;

		[Token(Token = "0x4000400")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform cube;

		[Token(Token = "0x4000401")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float cubeRandomPosition;

		[Token(Token = "0x4000402")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public AnimationCurve motionAbsorbWeight;

		[Token(Token = "0x4000403")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Vector3 cubeDefaultPosition;

		[Token(Token = "0x4000404")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private AnimatorStateInfo info;

		[Token(Token = "0x4000405")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Rigidbody cubeRigidbody;

		[Token(Token = "0x6000591")]
		[Address(RVA = "0xF6CB5C", Offset = "0xF6CB5C", VA = "0xF6CB5C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000592")]
		[Address(RVA = "0xF6CBE8", Offset = "0xF6CBE8", VA = "0xF6CBE8")]
		private void Update()
		{
		}

		[Token(Token = "0x6000593")]
		[Address(RVA = "0xF6CCBC", Offset = "0xF6CCBC", VA = "0xF6CCBC")]
		private void SwingStart()
		{
		}

		[Token(Token = "0x6000594")]
		[Address(RVA = "0xF6CEA0", Offset = "0xF6CEA0", VA = "0xF6CEA0")]
		public MotionAbsorbCharacter()
		{
		}
	}
	[Token(Token = "0x2000092")]
	public class OffsetEffector : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x2000181")]
		public class EffectorLink
		{
			[Token(Token = "0x40009DC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public FullBodyBipedEffector effectorType;

			[Token(Token = "0x40009DD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public float weightMultiplier;

			[Token(Token = "0x40009DE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[HideInInspector]
			public Vector3 localPosition;

			[Token(Token = "0x6000B1D")]
			[Address(RVA = "0xF6D2FC", Offset = "0xF6D2FC", VA = "0xF6D2FC")]
			public EffectorLink()
			{
			}
		}

		[Token(Token = "0x4000406")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public EffectorLink[] effectorLinks;

		[Token(Token = "0x6000595")]
		[Address(RVA = "0xF6CEB4", Offset = "0xF6CEB4", VA = "0xF6CEB4", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x6000596")]
		[Address(RVA = "0xF6D040", Offset = "0xF6D040", VA = "0xF6D040", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x6000597")]
		[Address(RVA = "0xF6D2F4", Offset = "0xF6D2F4", VA = "0xF6D2F4")]
		public OffsetEffector()
		{
		}
	}
	[Token(Token = "0x2000093")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x9D59F0", Offset = "0x9D59F0")]
	public class PendulumExample : MonoBehaviour
	{
		[Token(Token = "0x4000407")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9D91D0", Offset = "0x9D91D0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9D91D0", Offset = "0x9D91D0")]
		public float weight;

		[Token(Token = "0x4000408")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9D9224", Offset = "0x9D9224")]
		public float hangingDistanceMlp;

		[Token(Token = "0x4000409")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9D925C", Offset = "0x9D925C")]
		[HideInInspector]
		public Vector3 rootTargetPosition;

		[Token(Token = "0x400040A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9D92A8", Offset = "0x9D92A8")]
		[HideInInspector]
		public Quaternion rootTargetRotation;

		[Token(Token = "0x400040B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Transform target;

		[Token(Token = "0x400040C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Transform leftHandTarget;

		[Token(Token = "0x400040D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Transform rightHandTarget;

		[Token(Token = "0x400040E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Transform leftFootTarget;

		[Token(Token = "0x400040F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Transform rightFootTarget;

		[Token(Token = "0x4000410")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Transform pelvisTarget;

		[Token(Token = "0x4000411")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Transform bodyTarget;

		[Token(Token = "0x4000412")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Transform headTarget;

		[Token(Token = "0x4000413")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[SerializeField]
		private Vector3 pelvisDownAxis;

		[Token(Token = "0x4000414")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private FullBodyBipedIK ik;

		[Token(Token = "0x4000415")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Quaternion rootRelativeToPelvis;

		[Token(Token = "0x4000416")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Vector3 pelvisToRoot;

		[Token(Token = "0x4000417")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		private float lastWeight;

		[Token(Token = "0x6000598")]
		[Address(RVA = "0xF6D30C", Offset = "0xF6D30C", VA = "0xF6D30C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000599")]
		[Address(RVA = "0xF6D734", Offset = "0xF6D734", VA = "0xF6D734")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600059A")]
		[Address(RVA = "0xF6E130", Offset = "0xF6E130", VA = "0xF6E130")]
		public PendulumExample()
		{
		}
	}
	[Token(Token = "0x2000094")]
	public abstract class PickUp2Handed : MonoBehaviour
	{
		[Token(Token = "0x4000418")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private int GUIspace;

		[Token(Token = "0x4000419")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public InteractionSystem interactionSystem;

		[Token(Token = "0x400041A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public InteractionObject obj;

		[Token(Token = "0x400041B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Transform pivot;

		[Token(Token = "0x400041C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Transform holdPoint;

		[Token(Token = "0x400041D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float pickUpTime;

		[Token(Token = "0x400041E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private float holdWeight;

		[Token(Token = "0x400041F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float holdWeightVel;

		[Token(Token = "0x4000420")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Vector3 pickUpPosition;

		[Token(Token = "0x4000421")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Quaternion pickUpRotation;

		[Token(Token = "0x170000AE")]
		private bool holding
		{
			[Token(Token = "0x60005A2")]
			[Address(RVA = "0xF6E790", Offset = "0xF6E790", VA = "0xF6E790")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600059B")]
		[Address(RVA = "0xF6E608", Offset = "0xF6E608", VA = "0xF6E608")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x600059C")]
		protected abstract void RotatePivot();

		[Token(Token = "0x600059D")]
		[Address(RVA = "0xF6E7C4", Offset = "0xF6E7C4", VA = "0xF6E7C4")]
		private void Start()
		{
		}

		[Token(Token = "0x600059E")]
		[Address(RVA = "0xF6E9A8", Offset = "0xF6E9A8", VA = "0xF6E9A8")]
		private void OnPause(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x600059F")]
		[Address(RVA = "0xF6EB84", Offset = "0xF6EB84", VA = "0xF6EB84")]
		private void OnStart(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x60005A0")]
		[Address(RVA = "0xF6ECB8", Offset = "0xF6ECB8", VA = "0xF6ECB8")]
		private void OnDrop(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x60005A1")]
		[Address(RVA = "0xF6EE1C", Offset = "0xF6EE1C", VA = "0xF6EE1C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60005A3")]
		[Address(RVA = "0xF6F0A8", Offset = "0xF6F0A8", VA = "0xF6F0A8")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60005A4")]
		[Address(RVA = "0xF6F2C4", Offset = "0xF6F2C4", VA = "0xF6F2C4")]
		protected PickUp2Handed()
		{
		}
	}
	[Token(Token = "0x2000095")]
	public class PickUpBox : PickUp2Handed
	{
		[Token(Token = "0x60005A5")]
		[Address(RVA = "0xF6F2D8", Offset = "0xF6F2D8", VA = "0xF6F2D8", Slot = "4")]
		protected override void RotatePivot()
		{
		}

		[Token(Token = "0x60005A6")]
		[Address(RVA = "0xF6F574", Offset = "0xF6F574", VA = "0xF6F574")]
		public PickUpBox()
		{
		}
	}
	[Token(Token = "0x2000096")]
	public class PickUpSphere : PickUp2Handed
	{
		[Token(Token = "0x60005A7")]
		[Address(RVA = "0xF6F588", Offset = "0xF6F588", VA = "0xF6F588", Slot = "4")]
		protected override void RotatePivot()
		{
		}

		[Token(Token = "0x60005A8")]
		[Address(RVA = "0xF6F7E0", Offset = "0xF6F7E0", VA = "0xF6F7E0")]
		public PickUpSphere()
		{
		}
	}
	[Token(Token = "0x2000097")]
	public class RagdollUtilityDemo : MonoBehaviour
	{
		[Token(Token = "0x4000422")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public RagdollUtility ragdollUtility;

		[Token(Token = "0x4000423")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform root;

		[Token(Token = "0x4000424")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Rigidbody pelvis;

		[Token(Token = "0x60005A9")]
		[Address(RVA = "0xF70104", Offset = "0xF70104", VA = "0xF70104")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x60005AA")]
		[Address(RVA = "0xF70168", Offset = "0xF70168", VA = "0xF70168")]
		private void Update()
		{
		}

		[Token(Token = "0x60005AB")]
		[Address(RVA = "0xF703A0", Offset = "0xF703A0", VA = "0xF703A0")]
		public RagdollUtilityDemo()
		{
		}
	}
	[Token(Token = "0x2000098")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x9D5A54", Offset = "0x9D5A54")]
	public class RecoilTest : MonoBehaviour
	{
		[Token(Token = "0x4000425")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float magnitude;

		[Token(Token = "0x4000426")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Recoil recoil;

		[Token(Token = "0x60005AC")]
		[Address(RVA = "0xF703A8", Offset = "0xF703A8", VA = "0xF703A8")]
		private void Start()
		{
		}

		[Token(Token = "0x60005AD")]
		[Address(RVA = "0xF70400", Offset = "0xF70400", VA = "0xF70400")]
		private void Update()
		{
		}

		[Token(Token = "0x60005AE")]
		[Address(RVA = "0xF70474", Offset = "0xF70474", VA = "0xF70474")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x60005AF")]
		[Address(RVA = "0xF704D8", Offset = "0xF704D8", VA = "0xF704D8")]
		public RecoilTest()
		{
		}
	}
	[Token(Token = "0x2000099")]
	public class ResetInteractionObject : MonoBehaviour
	{
		[Token(Token = "0x2000182")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9D601C", Offset = "0x9D601C")]
		private sealed class <ResetObject>d__7 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40009DF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40009E0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40009E1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float resetTime;

			[Token(Token = "0x40009E2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public ResetInteractionObject <>4__this;

			[Token(Token = "0x170001E0")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000B21")]
				[Address(RVA = "0xF70948", Offset = "0xF70948", VA = "0xF70948", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170001E1")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000B23")]
				[Address(RVA = "0xF709B8", Offset = "0xF709B8", VA = "0xF709B8", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000B1E")]
			[Address(RVA = "0xF706A0", Offset = "0xF706A0", VA = "0xF706A0")]
			[DebuggerHidden]
			public <ResetObject>d__7(int <>1__state)
			{
			}

			[Token(Token = "0x6000B1F")]
			[Address(RVA = "0xF706DC", Offset = "0xF706DC", VA = "0xF706DC", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000B20")]
			[Address(RVA = "0xF706E0", Offset = "0xF706E0", VA = "0xF706E0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000B22")]
			[Address(RVA = "0xF70950", Offset = "0xF70950", VA = "0xF70950", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000427")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float resetDelay;

		[Token(Token = "0x4000428")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private Vector3 defaultPosition;

		[Token(Token = "0x4000429")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Quaternion defaultRotation;

		[Token(Token = "0x400042A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Transform defaultParent;

		[Token(Token = "0x400042B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Rigidbody r;

		[Token(Token = "0x60005B0")]
		[Address(RVA = "0xF704E8", Offset = "0xF704E8", VA = "0xF704E8")]
		private void Start()
		{
		}

		[Token(Token = "0x60005B1")]
		[Address(RVA = "0xF705C0", Offset = "0xF705C0", VA = "0xF705C0")]
		private void OnPickUp(Transform t)
		{
		}

		[Token(Token = "0x60005B2")]
		[Address(RVA = "0xF70608", Offset = "0xF70608", VA = "0xF70608")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9DF118", Offset = "0x9DF118")]
		private IEnumerator ResetObject(float resetTime)
		{
			return null;
		}

		[Token(Token = "0x60005B3")]
		[Address(RVA = "0xF706CC", Offset = "0xF706CC", VA = "0xF706CC")]
		public ResetInteractionObject()
		{
		}
	}
	[Token(Token = "0x200009A")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x9D5AB8", Offset = "0x9D5AB8")]
	public class SoccerDemo : MonoBehaviour
	{
		[Token(Token = "0x2000183")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9D602C", Offset = "0x9D602C")]
		private sealed class <ResetDelayed>d__4 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40009E3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40009E4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40009E5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public SoccerDemo <>4__this;

			[Token(Token = "0x170001E2")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000B27")]
				[Address(RVA = "0xF71858", Offset = "0xF71858", VA = "0xF71858", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170001E3")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000B29")]
				[Address(RVA = "0xF718C8", Offset = "0xF718C8", VA = "0xF718C8", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000B24")]
			[Address(RVA = "0xF7167C", Offset = "0xF7167C", VA = "0xF7167C")]
			[DebuggerHidden]
			public <ResetDelayed>d__4(int <>1__state)
			{
			}

			[Token(Token = "0x6000B25")]
			[Address(RVA = "0xF716B0", Offset = "0xF716B0", VA = "0xF716B0", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000B26")]
			[Address(RVA = "0xF716B4", Offset = "0xF716B4", VA = "0xF716B4", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000B28")]
			[Address(RVA = "0xF71860", Offset = "0xF71860", VA = "0xF71860", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400042C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Animator animator;

		[Token(Token = "0x400042D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Vector3 defaultPosition;

		[Token(Token = "0x400042E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private Quaternion defaultRotation;

		[Token(Token = "0x60005B4")]
		[Address(RVA = "0xF71544", Offset = "0xF71544", VA = "0xF71544")]
		private void Start()
		{
		}

		[Token(Token = "0x60005B5")]
		[Address(RVA = "0xF71608", Offset = "0xF71608", VA = "0xF71608")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9DF17C", Offset = "0x9DF17C")]
		private IEnumerator ResetDelayed()
		{
			return null;
		}

		[Token(Token = "0x60005B6")]
		[Address(RVA = "0xF716A8", Offset = "0xF716A8", VA = "0xF716A8")]
		public SoccerDemo()
		{
		}
	}
	[Token(Token = "0x200009B")]
	public class TouchWalls : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000184")]
		public class EffectorLink
		{
			[Token(Token = "0x40009E6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public bool enabled;

			[Token(Token = "0x40009E7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public FullBodyBipedEffector effectorType;

			[Token(Token = "0x40009E8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public InteractionObject interactionObject;

			[Token(Token = "0x40009E9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Transform spherecastFrom;

			[Token(Token = "0x40009EA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public float spherecastRadius;

			[Token(Token = "0x40009EB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public float minDistance;

			[Token(Token = "0x40009EC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public LayerMask touchLayers;

			[Token(Token = "0x40009ED")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			public float lerpSpeed;

			[Token(Token = "0x40009EE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public float minSwitchTime;

			[Token(Token = "0x40009EF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public float releaseDistance;

			[Token(Token = "0x40009F0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public bool sliding;

			[Token(Token = "0x40009F1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			private Vector3 raycastDirectionLocal;

			[Token(Token = "0x40009F2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			private float raycastDistance;

			[Token(Token = "0x40009F3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			private bool inTouch;

			[Token(Token = "0x40009F4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private RaycastHit hit;

			[Token(Token = "0x40009F5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
			private Vector3 targetPosition;

			[Token(Token = "0x40009F6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			private Quaternion targetRotation;

			[Token(Token = "0x40009F7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			private bool initiated;

			[Token(Token = "0x40009F8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
			private float nextSwitchTime;

			[Token(Token = "0x40009F9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
			private float speedF;

			[Token(Token = "0x6000B2A")]
			[Address(RVA = "0xF71964", Offset = "0xF71964", VA = "0xF71964")]
			public void Initiate(InteractionSystem interactionSystem)
			{
			}

			[Token(Token = "0x6000B2B")]
			[Address(RVA = "0xF7296C", Offset = "0xF7296C", VA = "0xF7296C")]
			private bool FindWalls(Vector3 direction)
			{
				return default(bool);
			}

			[Token(Token = "0x6000B2C")]
			[Address(RVA = "0xF71DF0", Offset = "0xF71DF0", VA = "0xF71DF0")]
			public void Update(InteractionSystem interactionSystem)
			{
			}

			[Token(Token = "0x6000B2D")]
			[Address(RVA = "0xF72A5C", Offset = "0xF72A5C", VA = "0xF72A5C")]
			private void StopTouch(InteractionSystem interactionSystem)
			{
			}

			[Token(Token = "0x6000B2E")]
			[Address(RVA = "0xF72C44", Offset = "0xF72C44", VA = "0xF72C44")]
			private void OnInteractionStart(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
			{
			}

			[Token(Token = "0x6000B2F")]
			[Address(RVA = "0xF72CE0", Offset = "0xF72CE0", VA = "0xF72CE0")]
			private void OnInteractionResume(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
			{
			}

			[Token(Token = "0x6000B30")]
			[Address(RVA = "0xF72D78", Offset = "0xF72D78", VA = "0xF72D78")]
			private void OnInteractionStop(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
			{
			}

			[Token(Token = "0x6000B31")]
			[Address(RVA = "0xF72780", Offset = "0xF72780", VA = "0xF72780")]
			public void Destroy(InteractionSystem interactionSystem)
			{
			}

			[Token(Token = "0x6000B32")]
			[Address(RVA = "0xF72E10", Offset = "0xF72E10", VA = "0xF72E10")]
			public EffectorLink()
			{
			}
		}

		[Token(Token = "0x400042F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public InteractionSystem interactionSystem;

		[Token(Token = "0x4000430")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public EffectorLink[] effectorLinks;

		[Token(Token = "0x60005B7")]
		[Address(RVA = "0xF718D0", Offset = "0xF718D0", VA = "0xF718D0")]
		private void Start()
		{
		}

		[Token(Token = "0x60005B8")]
		[Address(RVA = "0xF71D50", Offset = "0xF71D50", VA = "0xF71D50")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60005B9")]
		[Address(RVA = "0xF72684", Offset = "0xF72684", VA = "0xF72684")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60005BA")]
		[Address(RVA = "0xF72964", Offset = "0xF72964", VA = "0xF72964")]
		public TouchWalls()
		{
		}
	}
	[Token(Token = "0x200009C")]
	public class TransferMotion : MonoBehaviour
	{
		[Token(Token = "0x4000431")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9D9394", Offset = "0x9D9394")]
		public Transform to;

		[Token(Token = "0x4000432")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9D93CC", Offset = "0x9D93CC")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9D93CC", Offset = "0x9D93CC")]
		public float transferMotion;

		[Token(Token = "0x4000433")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private Vector3 lastPosition;

		[Token(Token = "0x60005BB")]
		[Address(RVA = "0xF72E50", Offset = "0xF72E50", VA = "0xF72E50")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60005BC")]
		[Address(RVA = "0xF72E94", Offset = "0xF72E94", VA = "0xF72E94")]
		private void Update()
		{
		}

		[Token(Token = "0x60005BD")]
		[Address(RVA = "0xF7302C", Offset = "0xF7302C", VA = "0xF7302C")]
		public TransferMotion()
		{
		}
	}
	[Token(Token = "0x200009D")]
	public class TwoHandedProp : MonoBehaviour
	{
		[Token(Token = "0x4000434")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9D9420", Offset = "0x9D9420")]
		public Transform leftHandTarget;

		[Token(Token = "0x4000435")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private FullBodyBipedIK ik;

		[Token(Token = "0x4000436")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Vector3 targetPosRelativeToRight;

		[Token(Token = "0x4000437")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private Quaternion targetRotRelativeToRight;

		[Token(Token = "0x60005BE")]
		[Address(RVA = "0xF73258", Offset = "0xF73258", VA = "0xF73258")]
		private void Start()
		{
		}

		[Token(Token = "0x60005BF")]
		[Address(RVA = "0xF7348C", Offset = "0xF7348C", VA = "0xF7348C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60005C0")]
		[Address(RVA = "0xF7385C", Offset = "0xF7385C", VA = "0xF7385C")]
		private void AfterFBBIK()
		{
		}

		[Token(Token = "0x60005C1")]
		[Address(RVA = "0xF739D4", Offset = "0xF739D4", VA = "0xF739D4")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60005C2")]
		[Address(RVA = "0xF73AF8", Offset = "0xF73AF8", VA = "0xF73AF8")]
		public TwoHandedProp()
		{
		}
	}
	[Token(Token = "0x200009E")]
	public class UserControlInteractions : UserControlThirdPerson
	{
		[Token(Token = "0x4000438")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private CharacterThirdPerson character;

		[Token(Token = "0x4000439")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private InteractionSystem interactionSystem;

		[Token(Token = "0x400043A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private bool disableInputInInteraction;

		[Token(Token = "0x400043B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public float enableInputAtProgress;

		[Token(Token = "0x60005C3")]
		[Address(RVA = "0xF73D58", Offset = "0xF73D58", VA = "0xF73D58", Slot = "4")]
		protected override void Update()
		{
		}

		[Token(Token = "0x60005C4")]
		[Address(RVA = "0xF7421C", Offset = "0xF7421C", VA = "0xF7421C")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x60005C5")]
		[Address(RVA = "0xF743E0", Offset = "0xF743E0", VA = "0xF743E0")]
		public UserControlInteractions()
		{
		}
	}
	[Token(Token = "0x200009F")]
	public class GrounderDemo : MonoBehaviour
	{
		[Token(Token = "0x400043C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject[] characters;

		[Token(Token = "0x60005C6")]
		[Address(RVA = "0xF676D8", Offset = "0xF676D8", VA = "0xF676D8")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x60005C7")]
		[Address(RVA = "0xF677F8", Offset = "0xF677F8", VA = "0xF677F8")]
		public void Activate(int index)
		{
		}

		[Token(Token = "0x60005C8")]
		[Address(RVA = "0xF678A8", Offset = "0xF678A8", VA = "0xF678A8")]
		public GrounderDemo()
		{
		}
	}
	[Token(Token = "0x20000A0")]
	public class PlatformRotator : MonoBehaviour
	{
		[Token(Token = "0x2000185")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9D603C", Offset = "0x9D603C")]
		private sealed class <SwitchRotation>d__14 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40009FA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40009FB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40009FC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public PlatformRotator <>4__this;

			[Token(Token = "0x170001E4")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000B36")]
				[Address(RVA = "0xF7008C", Offset = "0xF7008C", VA = "0xF7008C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170001E5")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000B38")]
				[Address(RVA = "0xF700FC", Offset = "0xF700FC", VA = "0xF700FC", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000B33")]
			[Address(RVA = "0xF6FC28", Offset = "0xF6FC28", VA = "0xF6FC28")]
			[DebuggerHidden]
			public <SwitchRotation>d__14(int <>1__state)
			{
			}

			[Token(Token = "0x6000B34")]
			[Address(RVA = "0xF6FE94", Offset = "0xF6FE94", VA = "0xF6FE94", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000B35")]
			[Address(RVA = "0xF6FE98", Offset = "0xF6FE98", VA = "0xF6FE98", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000B37")]
			[Address(RVA = "0xF70094", Offset = "0xF70094", VA = "0xF70094", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400043D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float maxAngle;

		[Token(Token = "0x400043E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float switchRotationTime;

		[Token(Token = "0x400043F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float random;

		[Token(Token = "0x4000440")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float rotationSpeed;

		[Token(Token = "0x4000441")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Vector3 movePosition;

		[Token(Token = "0x4000442")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float moveSpeed;

		[Token(Token = "0x4000443")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public int characterLayer;

		[Token(Token = "0x4000444")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private Quaternion defaultRotation;

		[Token(Token = "0x4000445")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Quaternion targetRotation;

		[Token(Token = "0x4000446")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private Vector3 targetPosition;

		[Token(Token = "0x4000447")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Vector3 velocity;

		[Token(Token = "0x4000448")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Rigidbody r;

		[Token(Token = "0x60005C9")]
		[Address(RVA = "0xF6F7F4", Offset = "0xF6F7F4", VA = "0xF6F7F4")]
		private void Start()
		{
		}

		[Token(Token = "0x60005CA")]
		[Address(RVA = "0xF6F998", Offset = "0xF6F998", VA = "0xF6F998")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60005CB")]
		[Address(RVA = "0xF6F924", Offset = "0xF6F924", VA = "0xF6F924")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9DF1E0", Offset = "0x9DF1E0")]
		private IEnumerator SwitchRotation()
		{
			return null;
		}

		[Token(Token = "0x60005CC")]
		[Address(RVA = "0xF6FC54", Offset = "0xF6FC54", VA = "0xF6FC54")]
		private void OnCollisionEnter(Collision collision)
		{
		}

		[Token(Token = "0x60005CD")]
		[Address(RVA = "0xF6FD68", Offset = "0xF6FD68", VA = "0xF6FD68")]
		private void OnCollisionExit(Collision collision)
		{
		}

		[Token(Token = "0x60005CE")]
		[Address(RVA = "0xF6FE78", Offset = "0xF6FE78", VA = "0xF6FE78")]
		public PlatformRotator()
		{
		}
	}
	[Token(Token = "0x20000A1")]
	public class BendGoal : MonoBehaviour
	{
		[Token(Token = "0x4000449")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public LimbIK limbIK;

		[Token(Token = "0x400044A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9D9488", Offset = "0x9D9488")]
		public float weight;

		[Token(Token = "0x60005CF")]
		[Address(RVA = "0x12702E0", Offset = "0x12702E0", VA = "0x12702E0")]
		private void Start()
		{
		}

		[Token(Token = "0x60005D0")]
		[Address(RVA = "0x127034C", Offset = "0x127034C", VA = "0x127034C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60005D1")]
		[Address(RVA = "0x1270460", Offset = "0x1270460", VA = "0x1270460")]
		public BendGoal()
		{
		}
	}
	[Token(Token = "0x20000A2")]
	public class Turret : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000186")]
		public class Part
		{
			[Token(Token = "0x40009FD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform transform;

			[Token(Token = "0x40009FE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private RotationLimit rotationLimit;

			[Token(Token = "0x6000B39")]
			[Address(RVA = "0xF730D4", Offset = "0xF730D4", VA = "0xF730D4")]
			public void AimAt(Transform target)
			{
			}

			[Token(Token = "0x6000B3A")]
			[Address(RVA = "0xF73250", Offset = "0xF73250", VA = "0xF73250")]
			public Part()
			{
			}
		}

		[Token(Token = "0x400044B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform target;

		[Token(Token = "0x400044C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Part[] parts;

		[Token(Token = "0x60005D2")]
		[Address(RVA = "0xF73040", Offset = "0xF73040", VA = "0xF73040")]
		private void Update()
		{
		}

		[Token(Token = "0x60005D3")]
		[Address(RVA = "0xF73248", Offset = "0xF73248", VA = "0xF73248")]
		public Turret()
		{
		}
	}
	[Token(Token = "0x20000A3")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x9D5B1C", Offset = "0x9D5B1C")]
	public class FixFeet : MonoBehaviour
	{
		[Token(Token = "0x400044D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9D94A0", Offset = "0x9D94A0")]
		public float weight;

		[Token(Token = "0x400044E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private FullBodyBipedIK ik;

		[Token(Token = "0x400044F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Vector3 relativePosL;

		[Token(Token = "0x4000450")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private Vector3 relativePosR;

		[Token(Token = "0x4000451")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Quaternion relativeRotL;

		[Token(Token = "0x4000452")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Quaternion relativeRotR;

		[Token(Token = "0x60005D4")]
		[Address(RVA = "0xF66D74", Offset = "0xF66D74", VA = "0xF66D74")]
		private void Start()
		{
		}

		[Token(Token = "0x60005D5")]
		[Address(RVA = "0xF66DD0", Offset = "0xF66DD0", VA = "0xF66DD0")]
		public void Sample()
		{
		}

		[Token(Token = "0x60005D6")]
		[Address(RVA = "0xF67120", Offset = "0xF67120", VA = "0xF67120")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60005D7")]
		[Address(RVA = "0xF676C8", Offset = "0xF676C8", VA = "0xF676C8")]
		public FixFeet()
		{
		}
	}
	[Token(Token = "0x20000A4")]
	public class Mirror : MonoBehaviour
	{
		[Token(Token = "0x4000453")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform target;

		[Token(Token = "0x4000454")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Transform[] children;

		[Token(Token = "0x4000455")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Transform[] targetChildren;

		[Token(Token = "0x4000456")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private FullBodyBipedIK ik;

		[Token(Token = "0x60005D8")]
		[Address(RVA = "0xF6BF88", Offset = "0xF6BF88", VA = "0xF6BF88")]
		private void Start()
		{
		}

		[Token(Token = "0x60005D9")]
		[Address(RVA = "0xF6C154", Offset = "0xF6C154", VA = "0xF6C154")]
		private void OnPostFBBIK()
		{
		}

		[Token(Token = "0x60005DA")]
		[Address(RVA = "0xF6C408", Offset = "0xF6C408", VA = "0xF6C408")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60005DB")]
		[Address(RVA = "0xF6C52C", Offset = "0xF6C52C", VA = "0xF6C52C")]
		public Mirror()
		{
		}
	}
	[Token(Token = "0x20000A5")]
	public class Phone : MonoBehaviour
	{
		[Token(Token = "0x2000187")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9D604C", Offset = "0x9D604C")]
		private sealed class <EnableDisplay>d__5 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40009FF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000A00")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000A01")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Phone <>4__this;

			[Token(Token = "0x170001E6")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000B3E")]
				[Address(RVA = "0xF6E590", Offset = "0xF6E590", VA = "0xF6E590", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170001E7")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000B40")]
				[Address(RVA = "0xF6E600", Offset = "0xF6E600", VA = "0xF6E600", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000B3B")]
			[Address(RVA = "0xF6E364", Offset = "0xF6E364", VA = "0xF6E364")]
			[DebuggerHidden]
			public <EnableDisplay>d__5(int <>1__state)
			{
			}

			[Token(Token = "0x6000B3C")]
			[Address(RVA = "0xF6E4C8", Offset = "0xF6E4C8", VA = "0xF6E4C8", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000B3D")]
			[Address(RVA = "0xF6E4CC", Offset = "0xF6E4CC", VA = "0xF6E4CC", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000B3F")]
			[Address(RVA = "0xF6E598", Offset = "0xF6E598", VA = "0xF6E598", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000457")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9D94B8", Offset = "0x9D94B8")]
		public Collider pickUpCollider;

		[Token(Token = "0x4000458")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9D94F0", Offset = "0x9D94F0")]
		public InteractionObject pickUpObject;

		[Token(Token = "0x4000459")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9D9528", Offset = "0x9D9528")]
		public GameObject display;

		[Token(Token = "0x400045A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Transform parent;

		[Token(Token = "0x60005DC")]
		[Address(RVA = "0xF6E1B8", Offset = "0xF6E1B8", VA = "0xF6E1B8")]
		private void OnPickUp()
		{
		}

		[Token(Token = "0x60005DD")]
		[Address(RVA = "0xF6E2F0", Offset = "0xF6E2F0", VA = "0xF6E2F0")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9DF244", Offset = "0x9DF244")]
		private IEnumerator EnableDisplay()
		{
			return null;
		}

		[Token(Token = "0x60005DE")]
		[Address(RVA = "0xF6E390", Offset = "0xF6E390", VA = "0xF6E390")]
		private void OnButton1()
		{
		}

		[Token(Token = "0x60005DF")]
		[Address(RVA = "0xF6E394", Offset = "0xF6E394", VA = "0xF6E394")]
		private void OnButton2()
		{
		}

		[Token(Token = "0x60005E0")]
		[Address(RVA = "0xF6E420", Offset = "0xF6E420", VA = "0xF6E420")]
		private void DropPhone()
		{
		}

		[Token(Token = "0x60005E1")]
		[Address(RVA = "0xF6E4C0", Offset = "0xF6E4C0", VA = "0xF6E4C0")]
		public Phone()
		{
		}
	}
	[Token(Token = "0x20000A6")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x9D5B80", Offset = "0x9D5B80")]
	public class VRAimingController : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000188")]
		public struct Targets
		{
			[Token(Token = "0x4000A02")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Transform leftHand;

			[Token(Token = "0x4000A03")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public Transform rightHand;

			[Token(Token = "0x4000A04")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform bendGoalLeftArm;

			[Token(Token = "0x4000A05")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Transform bendGoalRightArm;

			[Token(Token = "0x4000A06")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public BoneRotationOffset[] boneRotationOffsets;
		}

		[Serializable]
		[Token(Token = "0x2000189")]
		public enum Handedness
		{
			[Token(Token = "0x4000A08")]
			Right,
			[Token(Token = "0x4000A09")]
			Left
		}

		[Serializable]
		[Token(Token = "0x200018A")]
		public class BoneRotationOffset
		{
			[Token(Token = "0x4000A0A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform transform;

			[Token(Token = "0x4000A0B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Vector3 value;

			[Token(Token = "0x6000B41")]
			[Address(RVA = "0xF76B18", Offset = "0xF76B18", VA = "0xF76B18")]
			public BoneRotationOffset()
			{
			}
		}

		[Token(Token = "0x400045B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9D9560", Offset = "0x9D9560")]
		public VRAnimatorController animatorController;

		[Token(Token = "0x400045C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9D9598", Offset = "0x9D9598")]
		public WeaponBase currentWeapon;

		[Token(Token = "0x400045D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9D95D0", Offset = "0x9D95D0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9D95D0", Offset = "0x9D95D0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9D95D0", Offset = "0x9D95D0")]
		public float weight;

		[Token(Token = "0x400045E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9D9648", Offset = "0x9D9648")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9D9648", Offset = "0x9D9648")]
		public float spineTwistWeight;

		[Token(Token = "0x400045F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9D969C", Offset = "0x9D969C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9D969C", Offset = "0x9D969C")]
		public Handedness handedness;

		[Token(Token = "0x4000460")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9D96FC", Offset = "0x9D96FC")]
		public float sideOffset;

		[Token(Token = "0x4000461")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9D9734", Offset = "0x9D9734")]
		public Targets leftHandedTargets;

		[Token(Token = "0x4000462")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9D976C", Offset = "0x9D976C")]
		public Targets rightHandedTargets;

		[Token(Token = "0x4000463")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9D97A4", Offset = "0x9D97A4")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9D97A4", Offset = "0x9D97A4")]
		public Transform weaponsPivot;

		[Token(Token = "0x4000464")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9D9804", Offset = "0x9D9804")]
		public Transform weaponsAnchor;

		[Token(Token = "0x4000465")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9D983C", Offset = "0x9D983C")]
		public Transform pivotMotionTarget;

		[Token(Token = "0x4000466")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9D9874", Offset = "0x9D9874")]
		public float lerpSpeed;

		[Token(Token = "0x4000467")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9D98AC", Offset = "0x9D98AC")]
		public float pivotMotionSmoothSpeed;

		[Token(Token = "0x4000468")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9D98E4", Offset = "0x9D98E4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9D98E4", Offset = "0x9D98E4")]
		public float pivotMotionWeight;

		[Token(Token = "0x4000469")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9D9938", Offset = "0x9D9938")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9D9938", Offset = "0x9D9938")]
		public float aimVerticalLimit;

		[Token(Token = "0x400046A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9D9990", Offset = "0x9D9990")]
		public float aimZ;

		[Token(Token = "0x400046B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private FullBodyBipedIK ik;

		[Token(Token = "0x400046C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private float lastWeight;

		[Token(Token = "0x400046D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private Poser poserLeftHand;

		[Token(Token = "0x400046E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private Poser poserRightHand;

		[Token(Token = "0x400046F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private Vector3 pivotRelativePosition;

		[Token(Token = "0x4000470")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		private Vector3 weaponsPivotLocalPosition;

		[Token(Token = "0x4000471")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private Vector3 defaultWeaponsAnchorLocalPosition;

		[Token(Token = "0x4000472")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xFC")]
		private Vector3 aimVel;

		[Token(Token = "0x4000473")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private Vector3 aimRandom;

		[Token(Token = "0x4000474")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x114")]
		private float x;

		[Token(Token = "0x4000475")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private float y;

		[Token(Token = "0x4000476")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11C")]
		private float aimWeight;

		[Token(Token = "0x4000477")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private Vector3 cameraPosition;

		[Token(Token = "0x4000478")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x12C")]
		private Vector3 lastCharacterPosition;

		[Token(Token = "0x170000AF")]
		private Transform cam
		{
			[Token(Token = "0x60005E2")]
			[Address(RVA = "0xF74444", Offset = "0xF74444", VA = "0xF74444")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000B0")]
		private Transform characterController
		{
			[Token(Token = "0x60005E3")]
			[Address(RVA = "0xF74470", Offset = "0xF74470", VA = "0xF74470")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000B1")]
		private Targets targets
		{
			[Token(Token = "0x60005E7")]
			[Address(RVA = "0xF75BA0", Offset = "0xF75BA0", VA = "0xF75BA0")]
			get
			{
				return default(Targets);
			}
		}

		[Token(Token = "0x60005E4")]
		[Address(RVA = "0xF7449C", Offset = "0xF7449C", VA = "0xF7449C")]
		private void Start()
		{
		}

		[Token(Token = "0x60005E5")]
		[Address(RVA = "0xF74A68", Offset = "0xF74A68", VA = "0xF74A68")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60005E6")]
		[Address(RVA = "0xF75BE0", Offset = "0xF75BE0", VA = "0xF75BE0")]
		private void RotateWeapon(float horAdd, float vertAdd)
		{
		}

		[Token(Token = "0x60005E8")]
		[Address(RVA = "0xF747EC", Offset = "0xF747EC", VA = "0xF747EC")]
		private Vector3 TargetsCameraPosition()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60005E9")]
		[Address(RVA = "0xF74734", Offset = "0xF74734", VA = "0xF74734")]
		private void SetHandedness(Handedness h)
		{
		}

		[Token(Token = "0x60005EA")]
		[Address(RVA = "0xF76370", Offset = "0xF76370", VA = "0xF76370")]
		private void TwistSpine()
		{
		}

		[Token(Token = "0x60005EB")]
		[Address(RVA = "0xF76634", Offset = "0xF76634", VA = "0xF76634")]
		private void AfterFBBIK()
		{
		}

		[Token(Token = "0x60005EC")]
		[Address(RVA = "0xF76910", Offset = "0xF76910", VA = "0xF76910")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60005ED")]
		[Address(RVA = "0xF76A34", Offset = "0xF76A34", VA = "0xF76A34")]
		private float ClampAngle(float angle, float min, float max)
		{
			return default(float);
		}

		[Token(Token = "0x60005EE")]
		[Address(RVA = "0xF76AE4", Offset = "0xF76AE4", VA = "0xF76AE4")]
		public VRAimingController()
		{
		}
	}
	[Token(Token = "0x20000A7")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x9D5BE4", Offset = "0x9D5BE4")]
	public class VRAnimatorController : MonoBehaviour
	{
		[Token(Token = "0x4000479")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9D99C8", Offset = "0x9D99C8")]
		public VRSetup oculusSetup;

		[Token(Token = "0x400047A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform characterController;

		[Token(Token = "0x400047B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform cam;

		[Token(Token = "0x400047C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9D9A00", Offset = "0x9D9A00")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9D9A00", Offset = "0x9D9A00")]
		public Vector3 cameraOffset;

		[Token(Token = "0x400047D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9D9A60", Offset = "0x9D9A60")]
		public float smoothAccelerationTime;

		[Token(Token = "0x400047E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9D9A98", Offset = "0x9D9A98")]
		public float linearAcceleration;

		[Token(Token = "0x400047F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9D9AD0", Offset = "0x9D9AD0")]
		public float maxViewAngle;

		[Token(Token = "0x4000480")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9D9B08", Offset = "0x9D9B08")]
		public float locomotionSpeed;

		[Token(Token = "0x4000481")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9D9B40", Offset = "0x9D9B40")]
		private Vector3 <velocity>k__BackingField;

		[Token(Token = "0x4000482")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Animator animator;

		[Token(Token = "0x4000483")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Vector3 velocityC;

		[Token(Token = "0x4000484")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private bool rootCorrection;

		[Token(Token = "0x4000485")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Vector3 playerVelocity;

		[Token(Token = "0x4000486")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private Vector3 playerLastPosition;

		[Token(Token = "0x4000487")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private FixFeet fixFeet;

		[Token(Token = "0x4000488")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Transform cameraPivot;

		[Token(Token = "0x170000B2")]
		public Vector3 velocity
		{
			[Token(Token = "0x60005EF")]
			[Address(RVA = "0xF75B94", Offset = "0xF75B94", VA = "0xF75B94")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DF2A8", Offset = "0x9DF2A8")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60005F0")]
			[Address(RVA = "0xF76B20", Offset = "0xF76B20", VA = "0xF76B20")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DF2B8", Offset = "0x9DF2B8")]
			private set
			{
			}
		}

		[Token(Token = "0x60005F1")]
		[Address(RVA = "0xF76B2C", Offset = "0xF76B2C", VA = "0xF76B2C")]
		private void Start()
		{
		}

		[Token(Token = "0x60005F2")]
		[Address(RVA = "0xF76E3C", Offset = "0xF76E3C", VA = "0xF76E3C")]
		private void Update()
		{
		}

		[Token(Token = "0x60005F3")]
		[Address(RVA = "0xF77288", Offset = "0xF77288", VA = "0xF77288")]
		private Vector3 GetVelocityTarget()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60005F4")]
		[Address(RVA = "0xF75F88", Offset = "0xF75F88", VA = "0xF75F88")]
		public void RotateCharacter(Vector3 forward, float maxAngle, [Optional] Transform fix)
		{
		}

		[Token(Token = "0x60005F5")]
		[Address(RVA = "0xF77444", Offset = "0xF77444", VA = "0xF77444")]
		public VRAnimatorController()
		{
		}
	}
	[Token(Token = "0x20000A8")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x9D5C48", Offset = "0x9D5C48")]
	public class VRCharacterController : MonoBehaviour
	{
		[Token(Token = "0x4000489")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float moveSpeed;

		[Token(Token = "0x400048A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float rotationSpeed;

		[Token(Token = "0x400048B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9D9B50", Offset = "0x9D9B50")]
		public float rotationRatchet;

		[Token(Token = "0x400048C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public KeyCode ratchetRight;

		[Token(Token = "0x400048D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public KeyCode ratchetLeft;

		[Token(Token = "0x400048E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Transform forwardDirection;

		[Token(Token = "0x400048F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private CharacterController characterController;

		[Token(Token = "0x60005F6")]
		[Address(RVA = "0xF77458", Offset = "0xF77458", VA = "0xF77458")]
		private void Awake()
		{
		}

		[Token(Token = "0x60005F7")]
		[Address(RVA = "0xF774F8", Offset = "0xF774F8", VA = "0xF774F8")]
		private void Update()
		{
		}

		[Token(Token = "0x60005F8")]
		[Address(RVA = "0xF778E8", Offset = "0xF778E8", VA = "0xF778E8")]
		public VRCharacterController()
		{
		}
	}
	[Token(Token = "0x20000A9")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x9D5CAC", Offset = "0x9D5CAC")]
	public class VRInteractionController : MonoBehaviour
	{
		[Token(Token = "0x4000490")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9D9B6C", Offset = "0x9D9B6C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9D9B6C", Offset = "0x9D9B6C")]
		public float triggerTime;

		[Token(Token = "0x4000491")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9D9BC0", Offset = "0x9D9BC0")]
		private InteractionSystem <interactionSystem>k__BackingField;

		[Token(Token = "0x4000492")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9D9BD0", Offset = "0x9D9BD0")]
		private InteractionTrigger <currentTrigger>k__BackingField;

		[Token(Token = "0x4000493")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float timer;

		[Token(Token = "0x170000B3")]
		public InteractionSystem interactionSystem
		{
			[Token(Token = "0x60005F9")]
			[Address(RVA = "0xF77908", Offset = "0xF77908", VA = "0xF77908")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DF2C8", Offset = "0x9DF2C8")]
			get
			{
				return null;
			}
			[Token(Token = "0x60005FA")]
			[Address(RVA = "0xF77910", Offset = "0xF77910", VA = "0xF77910")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DF2D8", Offset = "0x9DF2D8")]
			private set
			{
			}
		}

		[Token(Token = "0x170000B4")]
		public float triggerProgress
		{
			[Token(Token = "0x60005FB")]
			[Address(RVA = "0xF77918", Offset = "0xF77918", VA = "0xF77918")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x170000B5")]
		public InteractionTrigger currentTrigger
		{
			[Token(Token = "0x60005FC")]
			[Address(RVA = "0xF77934", Offset = "0xF77934", VA = "0xF77934")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DF2E8", Offset = "0x9DF2E8")]
			get
			{
				return null;
			}
			[Token(Token = "0x60005FD")]
			[Address(RVA = "0xF7793C", Offset = "0xF7793C", VA = "0xF7793C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DF2F8", Offset = "0x9DF2F8")]
			private set
			{
			}
		}

		[Token(Token = "0x60005FE")]
		[Address(RVA = "0xF77944", Offset = "0xF77944", VA = "0xF77944")]
		private void Start()
		{
		}

		[Token(Token = "0x60005FF")]
		[Address(RVA = "0xF7799C", Offset = "0xF7799C", VA = "0xF7799C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000600")]
		[Address(RVA = "0xF77AB8", Offset = "0xF77AB8", VA = "0xF77AB8")]
		private bool CanTrigger(int index)
		{
			return default(bool);
		}

		[Token(Token = "0x6000601")]
		[Address(RVA = "0xF77B08", Offset = "0xF77B08", VA = "0xF77B08")]
		public VRInteractionController()
		{
		}
	}
	[Token(Token = "0x20000AA")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x9D5D10", Offset = "0x9D5D10")]
	public class VRInteractionUI : MonoBehaviour
	{
		[Token(Token = "0x4000494")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9D9BE0", Offset = "0x9D9BE0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9D9BE0", Offset = "0x9D9BE0")]
		public Slider slider;

		[Token(Token = "0x4000495")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9D9C40", Offset = "0x9D9C40")]
		public AnimationCurve alphaToProgress;

		[Token(Token = "0x4000496")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9D9C78", Offset = "0x9D9C78")]
		public Transform cursor;

		[Token(Token = "0x4000497")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private VRInteractionController interactionController;

		[Token(Token = "0x4000498")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Image[] sliderImages;

		[Token(Token = "0x4000499")]
		private const string showCursorTag = "ShowCursor";

		[Token(Token = "0x6000602")]
		[Address(RVA = "0xF77B18", Offset = "0xF77B18", VA = "0xF77B18")]
		private void Start()
		{
		}

		[Token(Token = "0x6000603")]
		[Address(RVA = "0xF77B98", Offset = "0xF77B98", VA = "0xF77B98")]
		private void Update()
		{
		}

		[Token(Token = "0x6000604")]
		[Address(RVA = "0xF77BBC", Offset = "0xF77BBC", VA = "0xF77BBC")]
		private void UpdateInteractionSlider()
		{
		}

		[Token(Token = "0x6000605")]
		[Address(RVA = "0xF77F0C", Offset = "0xF77F0C", VA = "0xF77F0C")]
		private void UpdateCursor()
		{
		}

		[Token(Token = "0x6000606")]
		[Address(RVA = "0xF78134", Offset = "0xF78134", VA = "0xF78134")]
		private void SetSliderAlpha(float a)
		{
		}

		[Token(Token = "0x6000607")]
		[Address(RVA = "0xF78404", Offset = "0xF78404", VA = "0xF78404")]
		public VRInteractionUI()
		{
		}
	}
	[Token(Token = "0x20000AB")]
	public class VRSetup : MonoBehaviour
	{
		[Token(Token = "0x400049A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Text text;

		[Token(Token = "0x400049B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public GameObject model;

		[Token(Token = "0x400049C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public GameObject[] enableOnR;

		[Token(Token = "0x400049D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public VRCharacterController characterController;

		[Token(Token = "0x400049E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public bool disableMovement;

		[Token(Token = "0x400049F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x39")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9D9CB0", Offset = "0x9D9CB0")]
		private bool <isFinished>k__BackingField;

		[Token(Token = "0x40004A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private float moveSpeed;

		[Token(Token = "0x170000B6")]
		public bool isFinished
		{
			[Token(Token = "0x6000608")]
			[Address(RVA = "0xF77280", Offset = "0xF77280", VA = "0xF77280")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DF308", Offset = "0x9DF308")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000609")]
			[Address(RVA = "0xF7840C", Offset = "0xF7840C", VA = "0xF7840C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DF318", Offset = "0x9DF318")]
			private set
			{
			}
		}

		[Token(Token = "0x600060A")]
		[Address(RVA = "0xF78418", Offset = "0xF78418", VA = "0xF78418")]
		private void Awake()
		{
		}

		[Token(Token = "0x600060B")]
		[Address(RVA = "0xF78548", Offset = "0xF78548", VA = "0xF78548")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600060C")]
		[Address(RVA = "0xF7887C", Offset = "0xF7887C", VA = "0xF7887C")]
		public VRSetup()
		{
		}
	}
	[Token(Token = "0x20000AC")]
	public abstract class WeaponBase : MonoBehaviour
	{
		[Token(Token = "0x40004A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9D9CC0", Offset = "0x9D9CC0")]
		public Vector3 recoilDirection;

		[Token(Token = "0x40004A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float recoilAngleVertical;

		[Token(Token = "0x40004A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float recoilAngleHorizontal;

		[Token(Token = "0x40004A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float recoilRandom;

		[Token(Token = "0x600060D")]
		public abstract void Fire();

		[Token(Token = "0x600060E")]
		[Address(RVA = "0xF78884", Offset = "0xF78884", VA = "0xF78884")]
		protected WeaponBase()
		{
		}
	}
	[Token(Token = "0x20000AD")]
	public class WeaponRifle : WeaponBase
	{
		[Token(Token = "0x40004A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9D9CF8", Offset = "0x9D9CF8")]
		public Transform shootFrom;

		[Token(Token = "0x40004A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float range;

		[Token(Token = "0x40004A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public LayerMask hitLayers;

		[Token(Token = "0x40004A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9D9D30", Offset = "0x9D9D30")]
		public ParticleSystem muzzleFlash;

		[Token(Token = "0x40004A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public ParticleSystem muzzleSmoke;

		[Token(Token = "0x40004AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Transform bulletHole;

		[Token(Token = "0x40004AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public ParticleSystem bulletHit;

		[Token(Token = "0x40004AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public float smokeFadeOutSpeed;

		[Token(Token = "0x40004AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private float smokeEmission;

		[Token(Token = "0x600060F")]
		[Address(RVA = "0xF78918", Offset = "0xF78918", VA = "0xF78918", Slot = "4")]
		public override void Fire()
		{
		}

		[Token(Token = "0x6000610")]
		[Address(RVA = "0xF78BF8", Offset = "0xF78BF8", VA = "0xF78BF8")]
		private void Update()
		{
		}

		[Token(Token = "0x6000611")]
		[Address(RVA = "0xF78D08", Offset = "0xF78D08", VA = "0xF78D08")]
		public WeaponRifle()
		{
		}
	}
	[Token(Token = "0x20000AE")]
	public abstract class CharacterAnimationBase : MonoBehaviour
	{
		[Token(Token = "0x40004AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool smoothFollow;

		[Token(Token = "0x40004AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float smoothFollowSpeed;

		[Token(Token = "0x40004B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Vector3 lastPosition;

		[Token(Token = "0x40004B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private Vector3 localPosition;

		[Token(Token = "0x40004B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Quaternion localRotation;

		[Token(Token = "0x40004B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Quaternion lastRotation;

		[Token(Token = "0x170000B7")]
		public virtual bool animationGrounded
		{
			[Token(Token = "0x6000613")]
			[Address(RVA = "0x1270D80", Offset = "0x1270D80", VA = "0x1270D80", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000612")]
		[Address(RVA = "0x1270D4C", Offset = "0x1270D4C", VA = "0x1270D4C", Slot = "4")]
		public virtual Vector3 GetPivotPoint()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000614")]
		[Address(RVA = "0x1270D88", Offset = "0x1270D88", VA = "0x1270D88")]
		public float GetAngleFromForward(Vector3 worldDirection)
		{
			return default(float);
		}

		[Token(Token = "0x6000615")]
		[Address(RVA = "0x1270E54", Offset = "0x1270E54", VA = "0x1270E54", Slot = "6")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x6000616")]
		[Address(RVA = "0x127113C", Offset = "0x127113C", VA = "0x127113C", Slot = "7")]
		protected virtual void LateUpdate()
		{
		}

		[Token(Token = "0x6000617")]
		[Address(RVA = "0x127144C", Offset = "0x127144C", VA = "0x127144C")]
		protected CharacterAnimationBase()
		{
		}
	}
	[Token(Token = "0x20000AF")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x9D5D74", Offset = "0x9D5D74")]
	public class CharacterAnimationSimple : CharacterAnimationBase
	{
		[Token(Token = "0x40004B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private CharacterThirdPerson characterController;

		[Token(Token = "0x40004B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		private float pivotOffset;

		[Token(Token = "0x40004B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private AnimationCurve moveSpeed;

		[Token(Token = "0x40004B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Animator animator;

		[Token(Token = "0x6000618")]
		[Address(RVA = "0x1271464", Offset = "0x1271464", VA = "0x1271464", Slot = "6")]
		protected override void Start()
		{
		}

		[Token(Token = "0x6000619")]
		[Address(RVA = "0x12714C4", Offset = "0x12714C4", VA = "0x12714C4", Slot = "4")]
		public override Vector3 GetPivotPoint()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600061A")]
		[Address(RVA = "0x1271610", Offset = "0x1271610", VA = "0x1271610")]
		private void Update()
		{
		}

		[Token(Token = "0x600061B")]
		[Address(RVA = "0x12717E4", Offset = "0x12717E4", VA = "0x12717E4")]
		public CharacterAnimationSimple()
		{
		}
	}
	[Token(Token = "0x20000B0")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x9D5DD8", Offset = "0x9D5DD8")]
	public class CharacterAnimationThirdPerson : CharacterAnimationBase
	{
		[Token(Token = "0x40004B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public CharacterThirdPerson characterController;

		[Token(Token = "0x40004B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		private float turnSensitivity;

		[Token(Token = "0x40004BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		[SerializeField]
		private float turnSpeed;

		[Token(Token = "0x40004BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private float runCycleLegOffset;

		[Token(Token = "0x40004BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9D9DC8", Offset = "0x9D9DC8")]
		[SerializeField]
		private float animSpeedMultiplier;

		[Token(Token = "0x40004BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		protected Animator animator;

		[Token(Token = "0x40004BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Vector3 lastForward;

		[Token(Token = "0x40004BF")]
		private const string groundedDirectional = "Grounded Directional";

		[Token(Token = "0x40004C0")]
		private const string groundedStrafe = "Grounded Strafe";

		[Token(Token = "0x170000B8")]
		public override bool animationGrounded
		{
			[Token(Token = "0x600061E")]
			[Address(RVA = "0x12718B8", Offset = "0x12718B8", VA = "0x12718B8", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600061C")]
		[Address(RVA = "0x12717FC", Offset = "0x12717FC", VA = "0x12717FC", Slot = "6")]
		protected override void Start()
		{
		}

		[Token(Token = "0x600061D")]
		[Address(RVA = "0x1271888", Offset = "0x1271888", VA = "0x1271888", Slot = "4")]
		public override Vector3 GetPivotPoint()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600061F")]
		[Address(RVA = "0x12719BC", Offset = "0x12719BC", VA = "0x12719BC", Slot = "8")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x6000620")]
		[Address(RVA = "0x1271E38", Offset = "0x1271E38", VA = "0x1271E38")]
		private void OnAnimatorMove()
		{
		}

		[Token(Token = "0x6000621")]
		[Address(RVA = "0x1271F08", Offset = "0x1271F08", VA = "0x1271F08")]
		public CharacterAnimationThirdPerson()
		{
		}
	}
	[Token(Token = "0x20000B1")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x9D5E3C", Offset = "0x9D5E3C")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x9D5E3C", Offset = "0x9D5E3C")]
	public abstract class CharacterBase : MonoBehaviour
	{
		[Token(Token = "0x40004C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9D9E0C", Offset = "0x9D9E0C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9D9E0C", Offset = "0x9D9E0C")]
		public Transform gravityTarget;

		[Token(Token = "0x40004C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9D9E6C", Offset = "0x9D9E6C")]
		[SerializeField]
		protected float gravityMultiplier;

		[Token(Token = "0x40004C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[SerializeField]
		protected float airborneThreshold;

		[Token(Token = "0x40004C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float slopeStartAngle;

		[Token(Token = "0x40004C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private float slopeEndAngle;

		[Token(Token = "0x40004C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float spherecastRadius;

		[Token(Token = "0x40004C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[SerializeField]
		private LayerMask groundLayers;

		[Token(Token = "0x40004C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private PhysicMaterial zeroFrictionMaterial;

		[Token(Token = "0x40004C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private PhysicMaterial highFrictionMaterial;

		[Token(Token = "0x40004CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		protected Rigidbody r;

		[Token(Token = "0x40004CB")]
		protected const float half = 0.5f;

		[Token(Token = "0x40004CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		protected float originalHeight;

		[Token(Token = "0x40004CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		protected Vector3 originalCenter;

		[Token(Token = "0x40004CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		protected CapsuleCollider capsule;

		[Token(Token = "0x6000622")]
		public abstract void Move(Vector3 deltaPosition, Quaternion deltaRotation);

		[Token(Token = "0x6000623")]
		[Address(RVA = "0x12724B8", Offset = "0x12724B8", VA = "0x12724B8")]
		protected Vector3 GetGravity()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000624")]
		[Address(RVA = "0x1272650", Offset = "0x1272650", VA = "0x1272650", Slot = "5")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x6000625")]
		[Address(RVA = "0x127283C", Offset = "0x127283C", VA = "0x127283C", Slot = "6")]
		protected virtual RaycastHit GetSpherecastHit()
		{
			return default(RaycastHit);
		}

		[Token(Token = "0x6000626")]
		[Address(RVA = "0x1272AF8", Offset = "0x1272AF8", VA = "0x1272AF8")]
		public float GetAngleFromForward(Vector3 worldDirection)
		{
			return default(float);
		}

		[Token(Token = "0x6000627")]
		[Address(RVA = "0x1272BC4", Offset = "0x1272BC4", VA = "0x1272BC4")]
		protected void RigidbodyRotateAround(Vector3 point, Vector3 axis, float angle)
		{
		}

		[Token(Token = "0x6000628")]
		[Address(RVA = "0x1272E0C", Offset = "0x1272E0C", VA = "0x1272E0C")]
		protected void ScaleCapsule(float mlp)
		{
		}

		[Token(Token = "0x6000629")]
		[Address(RVA = "0x127300C", Offset = "0x127300C", VA = "0x127300C")]
		protected void HighFriction()
		{
		}

		[Token(Token = "0x600062A")]
		[Address(RVA = "0x1273044", Offset = "0x1273044", VA = "0x1273044")]
		protected void ZeroFriction()
		{
		}

		[Token(Token = "0x600062B")]
		[Address(RVA = "0x127307C", Offset = "0x127307C", VA = "0x127307C")]
		protected float GetSlopeDamper(Vector3 velocity, Vector3 groundNormal)
		{
			return default(float);
		}

		[Token(Token = "0x600062C")]
		[Address(RVA = "0x1273180", Offset = "0x1273180", VA = "0x1273180")]
		protected CharacterBase()
		{
		}
	}
	[Token(Token = "0x20000B2")]
	public class CharacterThirdPerson : CharacterBase
	{
		[Serializable]
		[Token(Token = "0x200018B")]
		public enum MoveMode
		{
			[Token(Token = "0x4000A0D")]
			Directional,
			[Token(Token = "0x4000A0E")]
			Strafe
		}

		[Token(Token = "0x200018C")]
		public struct AnimState
		{
			[Token(Token = "0x4000A0F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Vector3 moveDirection;

			[Token(Token = "0x4000A10")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public bool jump;

			[Token(Token = "0x4000A11")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD")]
			public bool crouch;

			[Token(Token = "0x4000A12")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE")]
			public bool onGround;

			[Token(Token = "0x4000A13")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF")]
			public bool isStrafing;

			[Token(Token = "0x4000A14")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float yVelocity;
		}

		[Token(Token = "0x40004CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9D9F08", Offset = "0x9D9F08")]
		public CharacterAnimationBase characterAnimation;

		[Token(Token = "0x40004D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public UserControlThirdPerson userControl;

		[Token(Token = "0x40004D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public CameraController cam;

		[Token(Token = "0x40004D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9D9F40", Offset = "0x9D9F40")]
		public MoveMode moveMode;

		[Token(Token = "0x40004D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		public bool smoothPhysics;

		[Token(Token = "0x40004D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public float smoothAccelerationTime;

		[Token(Token = "0x40004D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		public float linearAccelerationSpeed;

		[Token(Token = "0x40004D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public float platformFriction;

		[Token(Token = "0x40004D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		public float groundStickyEffect;

		[Token(Token = "0x40004D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public float maxVerticalVelocityOnGround;

		[Token(Token = "0x40004D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		public float velocityToGroundTangentWeight;

		[Token(Token = "0x40004DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9D9F78", Offset = "0x9D9F78")]
		public bool lookInCameraDirection;

		[Token(Token = "0x40004DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		public float turnSpeed;

		[Token(Token = "0x40004DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public float stationaryTurnSpeedMlp;

		[Token(Token = "0x40004DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9D9FB0", Offset = "0x9D9FB0")]
		public float airSpeed;

		[Token(Token = "0x40004DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public float airControl;

		[Token(Token = "0x40004DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		public float jumpPower;

		[Token(Token = "0x40004E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public float jumpRepeatDelayTime;

		[Token(Token = "0x40004E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9D9FE8", Offset = "0x9D9FE8")]
		[SerializeField]
		private LayerMask wallRunLayers;

		[Token(Token = "0x40004E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public float wallRunMaxLength;

		[Token(Token = "0x40004E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		public float wallRunMinMoveMag;

		[Token(Token = "0x40004E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public float wallRunMinVelocityY;

		[Token(Token = "0x40004E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		public float wallRunRotationSpeed;

		[Token(Token = "0x40004E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public float wallRunMaxRotationAngle;

		[Token(Token = "0x40004E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		public float wallRunWeightSpeed;

		[Token(Token = "0x40004E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9DA034", Offset = "0x9DA034")]
		public float crouchCapsuleScaleMlp;

		[Token(Token = "0x40004E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DA06C", Offset = "0x9DA06C")]
		private bool <onGround>k__BackingField;

		[Token(Token = "0x40004EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		public AnimState animState;

		[Token(Token = "0x40004EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
		protected Vector3 moveDirection;

		[Token(Token = "0x40004EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private Animator animator;

		[Token(Token = "0x40004ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private Vector3 normal;

		[Token(Token = "0x40004EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x114")]
		private Vector3 platformVelocity;

		[Token(Token = "0x40004EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private Vector3 platformAngularVelocity;

		[Token(Token = "0x40004F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x12C")]
		private RaycastHit hit;

		[Token(Token = "0x40004F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		private float jumpLeg;

		[Token(Token = "0x40004F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x15C")]
		private float jumpEndTime;

		[Token(Token = "0x40004F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		private float forwardMlp;

		[Token(Token = "0x40004F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x164")]
		private float groundDistance;

		[Token(Token = "0x40004F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		private float lastAirTime;

		[Token(Token = "0x40004F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x16C")]
		private float stickyForce;

		[Token(Token = "0x40004F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		private Vector3 wallNormal;

		[Token(Token = "0x40004F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x17C")]
		private Vector3 moveDirectionVelocity;

		[Token(Token = "0x40004F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
		private float wallRunWeight;

		[Token(Token = "0x40004FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18C")]
		private float lastWallRunWeight;

		[Token(Token = "0x40004FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
		private Vector3 fixedDeltaPosition;

		[Token(Token = "0x40004FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19C")]
		private Quaternion fixedDeltaRotation;

		[Token(Token = "0x40004FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1AC")]
		private bool fixedFrame;

		[Token(Token = "0x40004FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
		private float wallRunEndTime;

		[Token(Token = "0x40004FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B4")]
		private Vector3 gravity;

		[Token(Token = "0x4000500")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
		private Vector3 verticalVelocity;

		[Token(Token = "0x4000501")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1CC")]
		private float velocityY;

		[Token(Token = "0x170000B9")]
		public bool onGround
		{
			[Token(Token = "0x600062D")]
			[Address(RVA = "0x12735EC", Offset = "0x12735EC", VA = "0x12735EC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DF328", Offset = "0x9DF328")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600062E")]
			[Address(RVA = "0x12735F4", Offset = "0x12735F4", VA = "0x12735F4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DF338", Offset = "0x9DF338")]
			private set
			{
			}
		}

		[Token(Token = "0x600062F")]
		[Address(RVA = "0x1273600", Offset = "0x1273600", VA = "0x1273600", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x6000630")]
		[Address(RVA = "0x1273798", Offset = "0x1273798", VA = "0x1273798")]
		private void OnAnimatorMove()
		{
		}

		[Token(Token = "0x6000631")]
		[Address(RVA = "0x127383C", Offset = "0x127383C", VA = "0x127383C", Slot = "4")]
		public override void Move(Vector3 deltaPosition, Quaternion deltaRotation)
		{
		}

		[Token(Token = "0x6000632")]
		[Address(RVA = "0x1273978", Offset = "0x1273978", VA = "0x1273978")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000633")]
		[Address(RVA = "0x1274940", Offset = "0x1274940", VA = "0x1274940", Slot = "7")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x6000634")]
		[Address(RVA = "0x1274CF4", Offset = "0x1274CF4", VA = "0x1274CF4", Slot = "8")]
		protected virtual void LateUpdate()
		{
		}

		[Token(Token = "0x6000635")]
		[Address(RVA = "0x1273E5C", Offset = "0x1273E5C", VA = "0x1273E5C")]
		private void MoveFixed(Vector3 deltaPosition)
		{
		}

		[Token(Token = "0x6000636")]
		[Address(RVA = "0x1274E14", Offset = "0x1274E14", VA = "0x1274E14")]
		private void WallRun()
		{
		}

		[Token(Token = "0x6000637")]
		[Address(RVA = "0x12754C0", Offset = "0x12754C0", VA = "0x12754C0")]
		private bool CanWallRun()
		{
			return default(bool);
		}

		[Token(Token = "0x6000638")]
		[Address(RVA = "0x1274A20", Offset = "0x1274A20", VA = "0x1274A20")]
		private Vector3 GetMoveDirection()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000639")]
		[Address(RVA = "0x1275564", Offset = "0x1275564", VA = "0x1275564", Slot = "9")]
		protected virtual void Rotate()
		{
		}

		[Token(Token = "0x600063A")]
		[Address(RVA = "0x1275A48", Offset = "0x1275A48", VA = "0x1275A48")]
		private Vector3 GetForwardDirection()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600063B")]
		[Address(RVA = "0x1275C44", Offset = "0x1275C44", VA = "0x1275C44", Slot = "10")]
		protected virtual bool Jump()
		{
			return default(bool);
		}

		[Token(Token = "0x600063C")]
		[Address(RVA = "0x12744B8", Offset = "0x12744B8", VA = "0x12744B8")]
		private void GroundCheck()
		{
		}

		[Token(Token = "0x600063D")]
		[Address(RVA = "0x1275E70", Offset = "0x1275E70", VA = "0x1275E70")]
		public CharacterThirdPerson()
		{
		}
	}
	[Token(Token = "0x20000B3")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x9D5EC8", Offset = "0x9D5EC8")]
	public class SimpleLocomotion : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x200018D")]
		public enum RotationMode
		{
			[Token(Token = "0x4000A16")]
			Smooth,
			[Token(Token = "0x4000A17")]
			Linear
		}

		[Token(Token = "0x4000502")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9DA07C", Offset = "0x9DA07C")]
		[SerializeField]
		private CameraController cameraController;

		[Token(Token = "0x4000503")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9DA0C8", Offset = "0x9DA0C8")]
		[SerializeField]
		private float accelerationTime;

		[Token(Token = "0x4000504")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9DA114", Offset = "0x9DA114")]
		[SerializeField]
		private float turnTime;

		[Token(Token = "0x4000505")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9DA160", Offset = "0x9DA160")]
		[SerializeField]
		private bool walkByDefault;

		[Token(Token = "0x4000506")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9DA1AC", Offset = "0x9DA1AC")]
		[SerializeField]
		private RotationMode rotationMode;

		[Token(Token = "0x4000507")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9DA1F8", Offset = "0x9DA1F8")]
		[SerializeField]
		private float moveSpeed;

		[Token(Token = "0x4000508")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DA244", Offset = "0x9DA244")]
		private bool <isGrounded>k__BackingField;

		[Token(Token = "0x4000509")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Animator animator;

		[Token(Token = "0x400050A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private float speed;

		[Token(Token = "0x400050B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private float angleVel;

		[Token(Token = "0x400050C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float speedVel;

		[Token(Token = "0x400050D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Vector3 linearTargetDirection;

		[Token(Token = "0x400050E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private CharacterController characterController;

		[Token(Token = "0x170000BA")]
		public bool isGrounded
		{
			[Token(Token = "0x600063E")]
			[Address(RVA = "0xF709C0", Offset = "0xF709C0", VA = "0xF709C0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DF348", Offset = "0x9DF348")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600063F")]
			[Address(RVA = "0xF709C8", Offset = "0xF709C8", VA = "0xF709C8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DF358", Offset = "0x9DF358")]
			private set
			{
			}
		}

		[Token(Token = "0x6000640")]
		[Address(RVA = "0xF709D4", Offset = "0xF709D4", VA = "0xF709D4")]
		private void Start()
		{
		}

		[Token(Token = "0x6000641")]
		[Address(RVA = "0xF70A60", Offset = "0xF70A60", VA = "0xF70A60")]
		private void Update()
		{
		}

		[Token(Token = "0x6000642")]
		[Address(RVA = "0xF71218", Offset = "0xF71218", VA = "0xF71218")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000643")]
		[Address(RVA = "0xF70ABC", Offset = "0xF70ABC", VA = "0xF70ABC")]
		private void Rotate()
		{
		}

		[Token(Token = "0x6000644")]
		[Address(RVA = "0xF70F18", Offset = "0xF70F18", VA = "0xF70F18")]
		private void Move()
		{
		}

		[Token(Token = "0x6000645")]
		[Address(RVA = "0xF71268", Offset = "0xF71268", VA = "0xF71268")]
		private Vector3 GetInputVector()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000646")]
		[Address(RVA = "0xF71360", Offset = "0xF71360", VA = "0xF71360")]
		private Vector3 GetInputVectorRaw()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000647")]
		[Address(RVA = "0xF71400", Offset = "0xF71400", VA = "0xF71400")]
		public SimpleLocomotion()
		{
		}
	}
	[Token(Token = "0x20000B4")]
	public class UserControlAI : UserControlThirdPerson
	{
		[Token(Token = "0x400050F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Transform moveTarget;

		[Token(Token = "0x4000510")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public float stoppingDistance;

		[Token(Token = "0x4000511")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public float stoppingThreshold;

		[Token(Token = "0x6000648")]
		[Address(RVA = "0xF73B00", Offset = "0xF73B00", VA = "0xF73B00", Slot = "4")]
		protected override void Update()
		{
		}

		[Token(Token = "0x6000649")]
		[Address(RVA = "0xF73D2C", Offset = "0xF73D2C", VA = "0xF73D2C")]
		public UserControlAI()
		{
		}
	}
	[Token(Token = "0x20000B5")]
	public class UserControlThirdPerson : MonoBehaviour
	{
		[Token(Token = "0x200018E")]
		public struct State
		{
			[Token(Token = "0x4000A18")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Vector3 move;

			[Token(Token = "0x4000A19")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public Vector3 lookPos;

			[Token(Token = "0x4000A1A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public bool crouch;

			[Token(Token = "0x4000A1B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
			public bool jump;

			[Token(Token = "0x4000A1C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public int actionIndex;
		}

		[Token(Token = "0x4000512")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool walkByDefault;

		[Token(Token = "0x4000513")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		public bool canCrouch;

		[Token(Token = "0x4000514")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
		public bool canJump;

		[Token(Token = "0x4000515")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public State state;

		[Token(Token = "0x4000516")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		protected Transform cam;

		[Token(Token = "0x600064A")]
		[Address(RVA = "0xF74404", Offset = "0xF74404", VA = "0xF74404")]
		private void Start()
		{
		}

		[Token(Token = "0x600064B")]
		[Address(RVA = "0xF73E8C", Offset = "0xF73E8C", VA = "0xF73E8C", Slot = "4")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x600064C")]
		[Address(RVA = "0xF73D48", Offset = "0xF73D48", VA = "0xF73D48")]
		public UserControlThirdPerson()
		{
		}
	}
	[Token(Token = "0x20000B6")]
	public class ApplicationQuit : MonoBehaviour
	{
		[Token(Token = "0x600064D")]
		[Address(RVA = "0x127029C", Offset = "0x127029C", VA = "0x127029C")]
		private void Update()
		{
		}

		[Token(Token = "0x600064E")]
		[Address(RVA = "0x12702D8", Offset = "0x12702D8", VA = "0x12702D8")]
		public ApplicationQuit()
		{
		}
	}
	[Token(Token = "0x20000B7")]
	public class SlowMo : MonoBehaviour
	{
		[Token(Token = "0x4000517")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private KeyCode[] keyCodes;

		[Token(Token = "0x4000518")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private bool mouse0;

		[Token(Token = "0x4000519")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
		[SerializeField]
		private bool mouse1;

		[Token(Token = "0x400051A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[SerializeField]
		private float slowMoTimeScale;

		[Token(Token = "0x600064F")]
		[Address(RVA = "0xF7142C", Offset = "0xF7142C", VA = "0xF7142C")]
		private void Update()
		{
		}

		[Token(Token = "0x6000650")]
		[Address(RVA = "0xF71460", Offset = "0xF71460", VA = "0xF71460")]
		private bool IsSlowMotion()
		{
			return default(bool);
		}

		[Token(Token = "0x6000651")]
		[Address(RVA = "0xF71530", Offset = "0xF71530", VA = "0xF71530")]
		public SlowMo()
		{
		}
	}
}
namespace POpusCodec
{
	[Token(Token = "0x20000B8")]
	public class OpusDecoder : IDisposable
	{
		[Token(Token = "0x400051B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private IntPtr _handle;

		[Token(Token = "0x400051C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private string _version;

		[Token(Token = "0x400051D")]
		private const int MaxFrameSize = 5760;

		[Token(Token = "0x400051E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private bool _previousPacketInvalid;

		[Token(Token = "0x400051F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private int _channelCount;

		[Token(Token = "0x4000520")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly float[] EmptyBufferFloat;

		[Token(Token = "0x4000521")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static readonly short[] EmptyBufferShort;

		[Token(Token = "0x4000522")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Bandwidth? _previousPacketBandwidth;

		[Token(Token = "0x4000523")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float[] bufferFloat;

		[Token(Token = "0x4000524")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private short[] bufferShort;

		[Token(Token = "0x170000BB")]
		public string Version
		{
			[Token(Token = "0x6000652")]
			[Address(RVA = "0x12623D0", Offset = "0x12623D0", VA = "0x12623D0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000BC")]
		public Bandwidth? PreviousPacketBandwidth
		{
			[Token(Token = "0x6000653")]
			[Address(RVA = "0x12623D8", Offset = "0x12623D8", VA = "0x12623D8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000654")]
		[Address(RVA = "0x12623E0", Offset = "0x12623E0", VA = "0x12623E0")]
		public OpusDecoder(SamplingRate outputSamplingRateHz, Channels numChannels)
		{
		}

		[Token(Token = "0x6000655")]
		[Address(RVA = "0x1262874", Offset = "0x1262874", VA = "0x1262874")]
		public float[] DecodePacketFloat(byte[] packetData)
		{
			return null;
		}

		[Token(Token = "0x6000656")]
		[Address(RVA = "0x1262B84", Offset = "0x1262B84", VA = "0x1262B84")]
		public short[] DecodePacketShort(byte[] packetData)
		{
			return null;
		}

		[Token(Token = "0x6000657")]
		[Address(RVA = "0x1262DF4", Offset = "0x1262DF4", VA = "0x1262DF4", Slot = "4")]
		public void Dispose()
		{
		}
	}
	[Token(Token = "0x20000B9")]
	public class OpusEncoder : IDisposable
	{
		[Token(Token = "0x4000525")]
		public const int BitrateMax = -1;

		[Token(Token = "0x4000526")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private IntPtr _handle;

		[Token(Token = "0x4000527")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private string _version;

		[Token(Token = "0x4000528")]
		private const int RecommendedMaxPacketSize = 4000;

		[Token(Token = "0x4000529")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private int _frameSizePerChannel;

		[Token(Token = "0x400052A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private SamplingRate _inputSamplingRate;

		[Token(Token = "0x400052B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Channels _inputChannels;

		[Token(Token = "0x400052C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private readonly byte[] writePacket;

		[Token(Token = "0x400052D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly ArraySegment<byte> EmptyBuffer;

		[Token(Token = "0x400052E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Delay _encoderDelay;

		[Token(Token = "0x170000BD")]
		public SamplingRate InputSamplingRate
		{
			[Token(Token = "0x6000659")]
			[Address(RVA = "0x1262F40", Offset = "0x1262F40", VA = "0x1262F40")]
			get
			{
				return default(SamplingRate);
			}
		}

		[Token(Token = "0x170000BE")]
		public Channels InputChannels
		{
			[Token(Token = "0x600065A")]
			[Address(RVA = "0x1262F48", Offset = "0x1262F48", VA = "0x1262F48")]
			get
			{
				return default(Channels);
			}
		}

		[Token(Token = "0x170000BF")]
		public string Version
		{
			[Token(Token = "0x600065B")]
			[Address(RVA = "0x1262F50", Offset = "0x1262F50", VA = "0x1262F50")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000C0")]
		public Delay EncoderDelay
		{
			[Token(Token = "0x600065D")]
			[Address(RVA = "0x126305C", Offset = "0x126305C", VA = "0x126305C")]
			get
			{
				return default(Delay);
			}
			[Token(Token = "0x600065C")]
			[Address(RVA = "0x1262F58", Offset = "0x1262F58", VA = "0x1262F58")]
			set
			{
			}
		}

		[Token(Token = "0x170000C1")]
		public int FrameSizePerChannel
		{
			[Token(Token = "0x600065E")]
			[Address(RVA = "0x1263064", Offset = "0x1263064", VA = "0x1263064")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170000C2")]
		public int Bitrate
		{
			[Token(Token = "0x600065F")]
			[Address(RVA = "0x126306C", Offset = "0x126306C", VA = "0x126306C")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000660")]
			[Address(RVA = "0x126313C", Offset = "0x126313C", VA = "0x126313C")]
			set
			{
			}
		}

		[Token(Token = "0x170000C3")]
		public Bandwidth MaxBandwidth
		{
			[Token(Token = "0x6000661")]
			[Address(RVA = "0x1263208", Offset = "0x1263208", VA = "0x1263208")]
			get
			{
				return default(Bandwidth);
			}
			[Token(Token = "0x6000662")]
			[Address(RVA = "0x1263214", Offset = "0x1263214", VA = "0x1263214")]
			set
			{
			}
		}

		[Token(Token = "0x170000C4")]
		public Complexity Complexity
		{
			[Token(Token = "0x6000663")]
			[Address(RVA = "0x1263228", Offset = "0x1263228", VA = "0x1263228")]
			get
			{
				return default(Complexity);
			}
			[Token(Token = "0x6000664")]
			[Address(RVA = "0x1263234", Offset = "0x1263234", VA = "0x1263234")]
			set
			{
			}
		}

		[Token(Token = "0x170000C5")]
		public int ExpectedPacketLossPercentage
		{
			[Token(Token = "0x6000665")]
			[Address(RVA = "0x1263248", Offset = "0x1263248", VA = "0x1263248")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000666")]
			[Address(RVA = "0x1263254", Offset = "0x1263254", VA = "0x1263254")]
			set
			{
			}
		}

		[Token(Token = "0x170000C6")]
		public SignalHint SignalHint
		{
			[Token(Token = "0x6000667")]
			[Address(RVA = "0x1263268", Offset = "0x1263268", VA = "0x1263268")]
			get
			{
				return default(SignalHint);
			}
			[Token(Token = "0x6000668")]
			[Address(RVA = "0x1263274", Offset = "0x1263274", VA = "0x1263274")]
			set
			{
			}
		}

		[Token(Token = "0x170000C7")]
		public ForceChannels ForceChannels
		{
			[Token(Token = "0x6000669")]
			[Address(RVA = "0x1263288", Offset = "0x1263288", VA = "0x1263288")]
			get
			{
				return default(ForceChannels);
			}
			[Token(Token = "0x600066A")]
			[Address(RVA = "0x1263294", Offset = "0x1263294", VA = "0x1263294")]
			set
			{
			}
		}

		[Token(Token = "0x170000C8")]
		public bool UseInbandFEC
		{
			[Token(Token = "0x600066B")]
			[Address(RVA = "0x12632A8", Offset = "0x12632A8", VA = "0x12632A8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600066C")]
			[Address(RVA = "0x12632CC", Offset = "0x12632CC", VA = "0x12632CC")]
			set
			{
			}
		}

		[Token(Token = "0x170000C9")]
		public bool UseUnconstrainedVBR
		{
			[Token(Token = "0x600066D")]
			[Address(RVA = "0x12632DC", Offset = "0x12632DC", VA = "0x12632DC")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600066E")]
			[Address(RVA = "0x1263300", Offset = "0x1263300", VA = "0x1263300")]
			set
			{
			}
		}

		[Token(Token = "0x170000CA")]
		public bool DtxEnabled
		{
			[Token(Token = "0x600066F")]
			[Address(RVA = "0x1263314", Offset = "0x1263314", VA = "0x1263314")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000670")]
			[Address(RVA = "0x1263338", Offset = "0x1263338", VA = "0x1263338")]
			set
			{
			}
		}

		[Token(Token = "0x6000671")]
		[Address(RVA = "0x1263348", Offset = "0x1263348", VA = "0x1263348")]
		public OpusEncoder(SamplingRate inputSamplingRateHz, Channels numChannels, int bitrate, OpusApplicationType applicationType, Delay encoderDelay)
		{
		}

		[Token(Token = "0x6000672")]
		[Address(RVA = "0x1263848", Offset = "0x1263848", VA = "0x1263848")]
		public ArraySegment<byte> Encode(float[] pcmSamples)
		{
			return default(ArraySegment<byte>);
		}

		[Token(Token = "0x6000673")]
		[Address(RVA = "0x1263A08", Offset = "0x1263A08", VA = "0x1263A08")]
		public ArraySegment<byte> Encode(short[] pcmSamples)
		{
			return default(ArraySegment<byte>);
		}

		[Token(Token = "0x6000674")]
		[Address(RVA = "0x1263BC8", Offset = "0x1263BC8", VA = "0x1263BC8", Slot = "4")]
		public void Dispose()
		{
		}
	}
	[Token(Token = "0x20000BA")]
	public class OpusException : Exception
	{
		[Token(Token = "0x400052F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private OpusStatusCode _statusCode;

		[Token(Token = "0x170000CB")]
		public OpusStatusCode StatusCode
		{
			[Token(Token = "0x6000676")]
			[Address(RVA = "0x1263D1C", Offset = "0x1263D1C", VA = "0x1263D1C")]
			get
			{
				return default(OpusStatusCode);
			}
		}

		[Token(Token = "0x6000677")]
		[Address(RVA = "0x12627F0", Offset = "0x12627F0", VA = "0x12627F0")]
		public OpusException(OpusStatusCode statusCode, string message)
		{
		}
	}
	[Token(Token = "0x20000BB")]
	internal class Wrapper
	{
		[Token(Token = "0x4000530")]
		private const string lib_name = "opus_egpv";

		[PreserveSig]
		[Token(Token = "0x6000678")]
		[Address(RVA = "0x1263D24", Offset = "0x1263D24", VA = "0x1263D24")]
		private static extern int opus_encoder_get_size(Channels channels);

		[PreserveSig]
		[Token(Token = "0x6000679")]
		[Address(RVA = "0x1263DC0", Offset = "0x1263DC0", VA = "0x1263DC0")]
		private static extern OpusStatusCode opus_encoder_init(IntPtr st, SamplingRate Fs, Channels channels, OpusApplicationType application);

		[PreserveSig]
		[Token(Token = "0x600067A")]
		[Address(RVA = "0x1262764", Offset = "0x1262764", VA = "0x1262764")]
		public static extern IntPtr opus_get_version_string();

		[PreserveSig]
		[Token(Token = "0x600067B")]
		[Address(RVA = "0x1263E84", Offset = "0x1263E84", VA = "0x1263E84")]
		private static extern int opus_encode(IntPtr st, short[] pcm, int frame_size, byte[] data, int max_data_bytes);

		[PreserveSig]
		[Token(Token = "0x600067C")]
		[Address(RVA = "0x1263F60", Offset = "0x1263F60", VA = "0x1263F60")]
		private static extern int opus_encode_float(IntPtr st, float[] pcm, int frame_size, byte[] data, int max_data_bytes);

		[PreserveSig]
		[Token(Token = "0x600067D")]
		[Address(RVA = "0x126403C", Offset = "0x126403C", VA = "0x126403C")]
		private static extern int opus_encoder_ctl_set(IntPtr st, OpusCtlSetRequest request, int value);

		[PreserveSig]
		[Token(Token = "0x600067E")]
		[Address(RVA = "0x12640F0", Offset = "0x12640F0", VA = "0x12640F0")]
		private static extern int opus_encoder_ctl_get(IntPtr st, OpusCtlGetRequest request, ref int value);

		[PreserveSig]
		[Token(Token = "0x600067F")]
		[Address(RVA = "0x12641A0", Offset = "0x12641A0", VA = "0x12641A0")]
		private static extern int opus_decoder_ctl_set(IntPtr st, OpusCtlSetRequest request, int value);

		[PreserveSig]
		[Token(Token = "0x6000680")]
		[Address(RVA = "0x1264254", Offset = "0x1264254", VA = "0x1264254")]
		private static extern int opus_decoder_ctl_get(IntPtr st, OpusCtlGetRequest request, ref int value);

		[PreserveSig]
		[Token(Token = "0x6000681")]
		[Address(RVA = "0x1264304", Offset = "0x1264304", VA = "0x1264304")]
		private static extern int opus_decoder_get_size(Channels channels);

		[PreserveSig]
		[Token(Token = "0x6000682")]
		[Address(RVA = "0x12643A0", Offset = "0x12643A0", VA = "0x12643A0")]
		private static extern OpusStatusCode opus_decoder_init(IntPtr st, SamplingRate Fs, Channels channels);

		[PreserveSig]
		[Token(Token = "0x6000683")]
		[Address(RVA = "0x1264454", Offset = "0x1264454", VA = "0x1264454")]
		private static extern int opus_decode(IntPtr st, byte[] data, int len, short[] pcm, int frame_size, int decode_fec);

		[PreserveSig]
		[Token(Token = "0x6000684")]
		[Address(RVA = "0x1264540", Offset = "0x1264540", VA = "0x1264540")]
		private static extern int opus_decode_float(IntPtr st, byte[] data, int len, float[] pcm, int frame_size, int decode_fec);

		[PreserveSig]
		[Token(Token = "0x6000685")]
		[Address(RVA = "0x1262AE0", Offset = "0x1262AE0", VA = "0x1262AE0")]
		public static extern int opus_packet_get_bandwidth(byte[] data);

		[PreserveSig]
		[Token(Token = "0x6000686")]
		[Address(RVA = "0x126462C", Offset = "0x126462C", VA = "0x126462C")]
		public static extern int opus_packet_get_nb_channels(byte[] data);

		[PreserveSig]
		[Token(Token = "0x6000687")]
		[Address(RVA = "0x12646D0", Offset = "0x12646D0", VA = "0x12646D0")]
		private static extern IntPtr opus_strerror(OpusStatusCode error);

		[Token(Token = "0x6000688")]
		[Address(RVA = "0x12636FC", Offset = "0x12636FC", VA = "0x12636FC")]
		public static IntPtr opus_encoder_create(SamplingRate Fs, Channels channels, OpusApplicationType application)
		{
			return default(IntPtr);
		}

		[Token(Token = "0x6000689")]
		[Address(RVA = "0x1263AD8", Offset = "0x1263AD8", VA = "0x1263AD8")]
		public static int opus_encode(IntPtr st, short[] pcm, int frame_size, byte[] data)
		{
			return default(int);
		}

		[Token(Token = "0x600068A")]
		[Address(RVA = "0x1263918", Offset = "0x1263918", VA = "0x1263918")]
		public static int opus_encode(IntPtr st, float[] pcm, int frame_size, byte[] data)
		{
			return default(int);
		}

		[Token(Token = "0x600068B")]
		[Address(RVA = "0x1263C28", Offset = "0x1263C28", VA = "0x1263C28")]
		public static void opus_encoder_destroy(IntPtr st)
		{
		}

		[Token(Token = "0x600068C")]
		[Address(RVA = "0x1263078", Offset = "0x1263078", VA = "0x1263078")]
		public static int get_opus_encoder_ctl(IntPtr st, OpusCtlGetRequest request)
		{
			return default(int);
		}

		[Token(Token = "0x600068D")]
		[Address(RVA = "0x1263150", Offset = "0x1263150", VA = "0x1263150")]
		public static void set_opus_encoder_ctl(IntPtr st, OpusCtlSetRequest request, int value)
		{
		}

		[Token(Token = "0x600068E")]
		[Address(RVA = "0x1264838", Offset = "0x1264838", VA = "0x1264838")]
		public static int get_opus_decoder_ctl(IntPtr st, OpusCtlGetRequest request)
		{
			return default(int);
		}

		[Token(Token = "0x600068F")]
		[Address(RVA = "0x12648FC", Offset = "0x12648FC", VA = "0x12648FC")]
		public static void set_opus_decoder_ctl(IntPtr st, OpusCtlSetRequest request, int value)
		{
		}

		[Token(Token = "0x6000690")]
		[Address(RVA = "0x1262620", Offset = "0x1262620", VA = "0x1262620")]
		public static IntPtr opus_decoder_create(SamplingRate Fs, Channels channels)
		{
			return default(IntPtr);
		}

		[Token(Token = "0x6000691")]
		[Address(RVA = "0x1262E54", Offset = "0x1262E54", VA = "0x1262E54")]
		public static void opus_decoder_destroy(IntPtr st)
		{
		}

		[Token(Token = "0x6000692")]
		[Address(RVA = "0x1262CC4", Offset = "0x1262CC4", VA = "0x1262CC4")]
		public static int opus_decode(IntPtr st, byte[] data, short[] pcm, int decode_fec, int channels)
		{
			return default(int);
		}

		[Token(Token = "0x6000693")]
		[Address(RVA = "0x12629B0", Offset = "0x12629B0", VA = "0x12629B0")]
		public static int opus_decode(IntPtr st, byte[] data, float[] pcm, int decode_fec, int channels)
		{
			return default(int);
		}

		[Token(Token = "0x6000694")]
		[Address(RVA = "0x126476C", Offset = "0x126476C", VA = "0x126476C")]
		private static void HandleStatusCode(OpusStatusCode statusCode)
		{
		}

		[Token(Token = "0x6000695")]
		[Address(RVA = "0x12649B4", Offset = "0x12649B4", VA = "0x12649B4")]
		public Wrapper()
		{
		}
	}
}
namespace POpusCodec.Enums
{
	[Token(Token = "0x20000BC")]
	public enum Bandwidth
	{
		[Token(Token = "0x4000532")]
		Narrowband = 1101,
		[Token(Token = "0x4000533")]
		Mediumband,
		[Token(Token = "0x4000534")]
		Wideband,
		[Token(Token = "0x4000535")]
		SuperWideband,
		[Token(Token = "0x4000536")]
		Fullband
	}
	[Token(Token = "0x20000BD")]
	public enum Channels
	{
		[Token(Token = "0x4000538")]
		Mono = 1,
		[Token(Token = "0x4000539")]
		Stereo
	}
	[Token(Token = "0x20000BE")]
	public enum Complexity
	{
		[Token(Token = "0x400053B")]
		Complexity0,
		[Token(Token = "0x400053C")]
		Complexity1,
		[Token(Token = "0x400053D")]
		Complexity2,
		[Token(Token = "0x400053E")]
		Complexity3,
		[Token(Token = "0x400053F")]
		Complexity4,
		[Token(Token = "0x4000540")]
		Complexity5,
		[Token(Token = "0x4000541")]
		Complexity6,
		[Token(Token = "0x4000542")]
		Complexity7,
		[Token(Token = "0x4000543")]
		Complexity8,
		[Token(Token = "0x4000544")]
		Complexity9,
		[Token(Token = "0x4000545")]
		Complexity10
	}
	[Token(Token = "0x20000BF")]
	public enum Delay
	{
		[Token(Token = "0x4000547")]
		Delay2dot5ms = 5,
		[Token(Token = "0x4000548")]
		Delay5ms = 10,
		[Token(Token = "0x4000549")]
		Delay10ms = 20,
		[Token(Token = "0x400054A")]
		Delay20ms = 40,
		[Token(Token = "0x400054B")]
		Delay40ms = 80,
		[Token(Token = "0x400054C")]
		Delay60ms = 120
	}
	[Token(Token = "0x20000C0")]
	public enum ForceChannels
	{
		[Token(Token = "0x400054E")]
		NoForce = -1000,
		[Token(Token = "0x400054F")]
		Mono = 1,
		[Token(Token = "0x4000550")]
		Stereo = 2
	}
	[Token(Token = "0x20000C1")]
	public enum OpusApplicationType
	{
		[Token(Token = "0x4000552")]
		Voip = 2048,
		[Token(Token = "0x4000553")]
		Audio = 2049,
		[Token(Token = "0x4000554")]
		RestrictedLowDelay = 2051
	}
	[Token(Token = "0x20000C2")]
	internal enum OpusCtlGetRequest
	{
		[Token(Token = "0x4000556")]
		Application = 4001,
		[Token(Token = "0x4000557")]
		Bitrate = 4003,
		[Token(Token = "0x4000558")]
		MaxBandwidth = 4005,
		[Token(Token = "0x4000559")]
		VBR = 4007,
		[Token(Token = "0x400055A")]
		Bandwidth = 4009,
		[Token(Token = "0x400055B")]
		Complexity = 4011,
		[Token(Token = "0x400055C")]
		InbandFec = 4013,
		[Token(Token = "0x400055D")]
		PacketLossPercentage = 4015,
		[Token(Token = "0x400055E")]
		Dtx = 4017,
		[Token(Token = "0x400055F")]
		VBRConstraint = 4021,
		[Token(Token = "0x4000560")]
		ForceChannels = 4023,
		[Token(Token = "0x4000561")]
		Signal = 4025,
		[Token(Token = "0x4000562")]
		LookAhead = 4027,
		[Token(Token = "0x4000563")]
		SampleRate = 4029,
		[Token(Token = "0x4000564")]
		FinalRange = 4031,
		[Token(Token = "0x4000565")]
		Pitch = 4033,
		[Token(Token = "0x4000566")]
		Gain = 4035,
		[Token(Token = "0x4000567")]
		LsbDepth = 4037,
		[Token(Token = "0x4000568")]
		LastPacketDurationRequest = 4039
	}
	[Token(Token = "0x20000C3")]
	internal enum OpusCtlSetRequest
	{
		[Token(Token = "0x400056A")]
		Application = 4000,
		[Token(Token = "0x400056B")]
		Bitrate = 4002,
		[Token(Token = "0x400056C")]
		MaxBandwidth = 4004,
		[Token(Token = "0x400056D")]
		VBR = 4006,
		[Token(Token = "0x400056E")]
		Bandwidth = 4008,
		[Token(Token = "0x400056F")]
		Complexity = 4010,
		[Token(Token = "0x4000570")]
		InbandFec = 4012,
		[Token(Token = "0x4000571")]
		PacketLossPercentage = 4014,
		[Token(Token = "0x4000572")]
		Dtx = 4016,
		[Token(Token = "0x4000573")]
		VBRConstraint = 4020,
		[Token(Token = "0x4000574")]
		ForceChannels = 4022,
		[Token(Token = "0x4000575")]
		Signal = 4024,
		[Token(Token = "0x4000576")]
		Gain = 4034,
		[Token(Token = "0x4000577")]
		LsbDepth = 4036
	}
	[Token(Token = "0x20000C4")]
	public enum OpusStatusCode
	{
		[Token(Token = "0x4000579")]
		OK = 0,
		[Token(Token = "0x400057A")]
		BadArguments = -1,
		[Token(Token = "0x400057B")]
		BufferTooSmall = -2,
		[Token(Token = "0x400057C")]
		InternalError = -3,
		[Token(Token = "0x400057D")]
		InvalidPacket = -4,
		[Token(Token = "0x400057E")]
		Unimplemented = -5,
		[Token(Token = "0x400057F")]
		InvalidState = -6,
		[Token(Token = "0x4000580")]
		AllocFail = -7
	}
	[Token(Token = "0x20000C5")]
	public enum SamplingRate
	{
		[Token(Token = "0x4000582")]
		Sampling08000 = 8000,
		[Token(Token = "0x4000583")]
		Sampling12000 = 12000,
		[Token(Token = "0x4000584")]
		Sampling16000 = 16000,
		[Token(Token = "0x4000585")]
		Sampling24000 = 24000,
		[Token(Token = "0x4000586")]
		Sampling48000 = 48000
	}
	[Token(Token = "0x20000C6")]
	public enum SignalHint
	{
		[Token(Token = "0x4000588")]
		Auto = -1000,
		[Token(Token = "0x4000589")]
		Voice = 3001,
		[Token(Token = "0x400058A")]
		Music = 3002
	}
}
namespace ExitGames.Client.Photon.Voice
{
	[Token(Token = "0x20000C7")]
	public static class AudioUtil
	{
		[Token(Token = "0x200018F")]
		public class Resampler<T> : LocalVoiceFramed<T>.IProcessor, IDisposable
		{
			[Token(Token = "0x4000A1D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			protected T[] frameResampled;

			[Token(Token = "0x4000A1E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private int channels;

			[Token(Token = "0x6000B42")]
			public Resampler(int dstSize, int channels)
			{
			}

			[Token(Token = "0x6000B43")]
			public T[] Process(T[] buf)
			{
				return null;
			}

			[Token(Token = "0x6000B44")]
			public void Dispose()
			{
			}
		}

		[Token(Token = "0x2000190")]
		public interface ILevelMeter
		{
			[Token(Token = "0x170001E8")]
			float CurrentAvgAmp
			{
				[Token(Token = "0x6000B45")]
				get;
			}

			[Token(Token = "0x170001E9")]
			float CurrentPeakAmp
			{
				[Token(Token = "0x6000B46")]
				get;
			}

			[Token(Token = "0x170001EA")]
			float AccumAvgPeakAmp
			{
				[Token(Token = "0x6000B47")]
				get;
			}

			[Token(Token = "0x6000B48")]
			void ResetAccumAvgPeakAmp();
		}

		[Token(Token = "0x2000191")]
		public class LevelMetterDummy : ILevelMeter
		{
			[Token(Token = "0x170001EB")]
			public float CurrentAvgAmp
			{
				[Token(Token = "0x6000B49")]
				[Address(RVA = "0x1339028", Offset = "0x1339028", VA = "0x1339028", Slot = "4")]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x170001EC")]
			public float CurrentPeakAmp
			{
				[Token(Token = "0x6000B4A")]
				[Address(RVA = "0x1339030", Offset = "0x1339030", VA = "0x1339030", Slot = "5")]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x170001ED")]
			public float AccumAvgPeakAmp
			{
				[Token(Token = "0x6000B4B")]
				[Address(RVA = "0x1339038", Offset = "0x1339038", VA = "0x1339038", Slot = "6")]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x6000B4C")]
			[Address(RVA = "0x1339040", Offset = "0x1339040", VA = "0x1339040", Slot = "7")]
			public void ResetAccumAvgPeakAmp()
			{
			}

			[Token(Token = "0x6000B4D")]
			[Address(RVA = "0x1339044", Offset = "0x1339044", VA = "0x1339044")]
			public LevelMetterDummy()
			{
			}
		}

		[Token(Token = "0x2000192")]
		public abstract class LevelMeter<T> : LocalVoiceFramed<T>.IProcessor, IDisposable, ILevelMeter
		{
			[Token(Token = "0x4000A1F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			protected float ampSum;

			[Token(Token = "0x4000A20")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			protected float ampPeak;

			[Token(Token = "0x4000A21")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			protected int bufferSize;

			[Token(Token = "0x4000A22")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			protected float[] buffer;

			[Token(Token = "0x4000A23")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			protected int prevValuesPtr;

			[Token(Token = "0x4000A24")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			protected float accumAvgPeakAmpSum;

			[Token(Token = "0x4000A25")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			protected int accumAvgPeakAmpCount;

			[Token(Token = "0x4000A26")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DCFB0", Offset = "0x9DCFB0")]
			private float <CurrentPeakAmp>k__BackingField;

			[Token(Token = "0x170001EE")]
			public float CurrentAvgAmp
			{
				[Token(Token = "0x6000B4F")]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x170001EF")]
			public float CurrentPeakAmp
			{
				[Token(Token = "0x6000B50")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E0B44", Offset = "0x9E0B44")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000B51")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E0B54", Offset = "0x9E0B54")]
				protected set
				{
				}
			}

			[Token(Token = "0x170001F0")]
			public float AccumAvgPeakAmp
			{
				[Token(Token = "0x6000B52")]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x6000B4E")]
			internal LevelMeter(int samplingRate, int numChannels)
			{
			}

			[Token(Token = "0x6000B53")]
			public void ResetAccumAvgPeakAmp()
			{
			}

			[Token(Token = "0x6000B54")]
			public abstract T[] Process(T[] buf);

			[Token(Token = "0x6000B55")]
			public void Dispose()
			{
			}
		}

		[Token(Token = "0x2000193")]
		public class LevelMeterFloat : LevelMeter<float>
		{
			[Token(Token = "0x6000B56")]
			[Address(RVA = "0x1338BEC", Offset = "0x1338BEC", VA = "0x1338BEC")]
			public LevelMeterFloat(int samplingRate, int numChannels)
			{
			}

			[Token(Token = "0x6000B57")]
			[Address(RVA = "0x1338C54", Offset = "0x1338C54", VA = "0x1338C54", Slot = "10")]
			public override float[] Process(float[] buf)
			{
				return null;
			}
		}

		[Token(Token = "0x2000194")]
		public class LevelMeterShort : LevelMeter<short>
		{
			[Token(Token = "0x6000B58")]
			[Address(RVA = "0x1338E08", Offset = "0x1338E08", VA = "0x1338E08")]
			public LevelMeterShort(int samplingRate, int numChannels)
			{
			}

			[Token(Token = "0x6000B59")]
			[Address(RVA = "0x1338E70", Offset = "0x1338E70", VA = "0x1338E70", Slot = "10")]
			public override short[] Process(short[] buf)
			{
				return null;
			}
		}

		[Token(Token = "0x2000195")]
		public interface IVoiceDetector
		{
			[Token(Token = "0x170001F1")]
			bool On
			{
				[Token(Token = "0x6000B5A")]
				get;
				[Token(Token = "0x6000B5B")]
				set;
			}

			[Token(Token = "0x170001F2")]
			float Threshold
			{
				[Token(Token = "0x6000B5C")]
				get;
				[Token(Token = "0x6000B5D")]
				set;
			}

			[Token(Token = "0x170001F3")]
			bool Detected
			{
				[Token(Token = "0x6000B5E")]
				get;
			}

			[Token(Token = "0x170001F4")]
			DateTime DetectedTime
			{
				[Token(Token = "0x6000B5F")]
				get;
			}

			[Token(Token = "0x170001F5")]
			int ActivityDelayMs
			{
				[Token(Token = "0x6000B62")]
				get;
				[Token(Token = "0x6000B63")]
				set;
			}

			[Token(Token = "0x14000005")]
			event Action OnDetected;
		}

		[Token(Token = "0x2000196")]
		public class VoiceDetectorCalibration<T> : LocalVoiceFramed<T>.IProcessor, IDisposable
		{
			[Token(Token = "0x4000A27")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private IVoiceDetector voiceDetector;

			[Token(Token = "0x4000A28")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private ILevelMeter levelMeter;

			[Token(Token = "0x4000A29")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private int valuesPerSec;

			[Token(Token = "0x4000A2A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			protected int voiceDetectorCalibrateCount;

			[Token(Token = "0x170001F6")]
			public bool VoiceDetectorCalibrating
			{
				[Token(Token = "0x6000B64")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x6000B65")]
			public VoiceDetectorCalibration(IVoiceDetector voiceDetector, ILevelMeter levelMeter, int samplingRate, int channels)
			{
			}

			[Token(Token = "0x6000B66")]
			public void VoiceDetectorCalibrate(int durationMs)
			{
			}

			[Token(Token = "0x6000B67")]
			public T[] Process(T[] buf)
			{
				return null;
			}

			[Token(Token = "0x6000B68")]
			public void Dispose()
			{
			}
		}

		[Token(Token = "0x2000197")]
		public class VoiceDetectorDummy : IVoiceDetector
		{
			[Token(Token = "0x4000A2B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DCFC0", Offset = "0x9DCFC0")]
			private DateTime <DetectedTime>k__BackingField;

			[Token(Token = "0x170001F7")]
			public bool On
			{
				[Token(Token = "0x6000B69")]
				[Address(RVA = "0x133904C", Offset = "0x133904C", VA = "0x133904C", Slot = "4")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6000B6A")]
				[Address(RVA = "0x1339054", Offset = "0x1339054", VA = "0x1339054", Slot = "5")]
				set
				{
				}
			}

			[Token(Token = "0x170001F8")]
			public float Threshold
			{
				[Token(Token = "0x6000B6B")]
				[Address(RVA = "0x1339058", Offset = "0x1339058", VA = "0x1339058", Slot = "6")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000B6C")]
				[Address(RVA = "0x1339060", Offset = "0x1339060", VA = "0x1339060", Slot = "7")]
				set
				{
				}
			}

			[Token(Token = "0x170001F9")]
			public bool Detected
			{
				[Token(Token = "0x6000B6D")]
				[Address(RVA = "0x1339064", Offset = "0x1339064", VA = "0x1339064", Slot = "8")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x170001FA")]
			public int ActivityDelayMs
			{
				[Token(Token = "0x6000B6E")]
				[Address(RVA = "0x133906C", Offset = "0x133906C", VA = "0x133906C", Slot = "12")]
				get
				{
					return default(int);
				}
				[Token(Token = "0x6000B6F")]
				[Address(RVA = "0x1339074", Offset = "0x1339074", VA = "0x1339074", Slot = "13")]
				set
				{
				}
			}

			[Token(Token = "0x170001FB")]
			public DateTime DetectedTime
			{
				[Token(Token = "0x6000B70")]
				[Address(RVA = "0x1339078", Offset = "0x1339078", VA = "0x1339078", Slot = "9")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E0B84", Offset = "0x9E0B84")]
				get
				{
					return default(DateTime);
				}
				[Token(Token = "0x6000B71")]
				[Address(RVA = "0x1339080", Offset = "0x1339080", VA = "0x1339080")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E0B94", Offset = "0x9E0B94")]
				private set
				{
				}
			}

			[Token(Token = "0x14000006")]
			public event Action OnDetected
			{
				[Token(Token = "0x6000B72")]
				[Address(RVA = "0x1339088", Offset = "0x1339088", VA = "0x1339088", Slot = "10")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E0BA4", Offset = "0x9E0BA4")]
				add
				{
				}
				[Token(Token = "0x6000B73")]
				[Address(RVA = "0x1339130", Offset = "0x1339130", VA = "0x1339130", Slot = "11")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E0BB4", Offset = "0x9E0BB4")]
				remove
				{
				}
			}

			[Token(Token = "0x6000B74")]
			[Address(RVA = "0x13391D8", Offset = "0x13391D8", VA = "0x13391D8")]
			public VoiceDetectorDummy()
			{
			}
		}

		[Token(Token = "0x2000198")]
		public abstract class VoiceDetector<T> : LocalVoiceFramed<T>.IProcessor, IDisposable, IVoiceDetector
		{
			[Token(Token = "0x4000A2D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DCFE0", Offset = "0x9DCFE0")]
			private bool <On>k__BackingField;

			[Token(Token = "0x4000A2E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DCFF0", Offset = "0x9DCFF0")]
			private float <Threshold>k__BackingField;

			[Token(Token = "0x4000A2F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private bool detected;

			[Token(Token = "0x4000A30")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DD000", Offset = "0x9DD000")]
			private DateTime <DetectedTime>k__BackingField;

			[Token(Token = "0x4000A32")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			protected int activityDelay;

			[Token(Token = "0x4000A33")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			protected int autoSilenceCounter;

			[Token(Token = "0x4000A34")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			protected int valuesCountPerSec;

			[Token(Token = "0x4000A35")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			protected int activityDelayValuesCount;

			[Token(Token = "0x170001FC")]
			public bool On
			{
				[Token(Token = "0x6000B75")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E0BC4", Offset = "0x9E0BC4")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6000B76")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E0BD4", Offset = "0x9E0BD4")]
				set
				{
				}
			}

			[Token(Token = "0x170001FD")]
			public float Threshold
			{
				[Token(Token = "0x6000B77")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E0BE4", Offset = "0x9E0BE4")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000B78")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E0BF4", Offset = "0x9E0BF4")]
				set
				{
				}
			}

			[Token(Token = "0x170001FE")]
			public bool Detected
			{
				[Token(Token = "0x6000B79")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6000B7A")]
				protected set
				{
				}
			}

			[Token(Token = "0x170001FF")]
			public DateTime DetectedTime
			{
				[Token(Token = "0x6000B7B")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E0C04", Offset = "0x9E0C04")]
				get
				{
					return default(DateTime);
				}
				[Token(Token = "0x6000B7C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E0C14", Offset = "0x9E0C14")]
				private set
				{
				}
			}

			[Token(Token = "0x17000200")]
			public int ActivityDelayMs
			{
				[Token(Token = "0x6000B7D")]
				get
				{
					return default(int);
				}
				[Token(Token = "0x6000B7E")]
				set
				{
				}
			}

			[Token(Token = "0x14000007")]
			public event Action OnDetected
			{
				[Token(Token = "0x6000B7F")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E0C24", Offset = "0x9E0C24")]
				add
				{
				}
				[Token(Token = "0x6000B80")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E0C34", Offset = "0x9E0C34")]
				remove
				{
				}
			}

			[Token(Token = "0x6000B81")]
			internal VoiceDetector(int samplingRate, int numChannels)
			{
			}

			[Token(Token = "0x6000B82")]
			public abstract T[] Process(T[] buf);

			[Token(Token = "0x6000B83")]
			public void Dispose()
			{
			}
		}

		[Token(Token = "0x2000199")]
		public class VoiceDetectorFloat : VoiceDetector<float>
		{
			[Token(Token = "0x6000B84")]
			[Address(RVA = "0x13391E0", Offset = "0x13391E0", VA = "0x13391E0")]
			public VoiceDetectorFloat(int samplingRate, int numChannels)
			{
			}

			[Token(Token = "0x6000B85")]
			[Address(RVA = "0x1339264", Offset = "0x1339264", VA = "0x1339264", Slot = "16")]
			public override float[] Process(float[] buffer)
			{
				return null;
			}
		}

		[Token(Token = "0x200019A")]
		public class VoiceDetectorShort : VoiceDetector<short>
		{
			[Token(Token = "0x6000B86")]
			[Address(RVA = "0x13393AC", Offset = "0x13393AC", VA = "0x13393AC")]
			internal VoiceDetectorShort(int samplingRate, int numChannels)
			{
			}

			[Token(Token = "0x6000B87")]
			[Address(RVA = "0x1339430", Offset = "0x1339430", VA = "0x1339430", Slot = "16")]
			public override short[] Process(short[] buffer)
			{
				return null;
			}
		}

		[Token(Token = "0x200019B")]
		public class VoiceLevelDetectCalibrate<T> : LocalVoiceFramed<T>.IProcessor, IDisposable
		{
			[Token(Token = "0x4000A36")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DD020", Offset = "0x9DD020")]
			private ILevelMeter <Level>k__BackingField;

			[Token(Token = "0x4000A37")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DD030", Offset = "0x9DD030")]
			private IVoiceDetector <Detector>k__BackingField;

			[Token(Token = "0x4000A38")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private VoiceDetectorCalibration<T> c;

			[Token(Token = "0x17000201")]
			public ILevelMeter Level
			{
				[Token(Token = "0x6000B88")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E0C44", Offset = "0x9E0C44")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000B89")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E0C54", Offset = "0x9E0C54")]
				private set
				{
				}
			}

			[Token(Token = "0x17000202")]
			public IVoiceDetector Detector
			{
				[Token(Token = "0x6000B8A")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E0C64", Offset = "0x9E0C64")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000B8B")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E0C74", Offset = "0x9E0C74")]
				private set
				{
				}
			}

			[Token(Token = "0x6000B8C")]
			public VoiceLevelDetectCalibrate(int samplingRate, int channels)
			{
			}

			[Token(Token = "0x6000B8D")]
			public void Calibrate(int durationMs)
			{
			}

			[Token(Token = "0x6000B8E")]
			public T[] Process(T[] buf)
			{
				return null;
			}

			[Token(Token = "0x6000B8F")]
			public void Dispose()
			{
			}
		}

		[Token(Token = "0x6000696")]
		public static void Resample<T>(T[] src, T[] dst, int dstCount, int channels)
		{
		}

		[Token(Token = "0x6000697")]
		[Address(RVA = "0x133842C", Offset = "0x133842C", VA = "0x133842C")]
		public static void ResampleAndConvert(short[] src, float[] dst, int dstCount, int channels)
		{
		}

		[Token(Token = "0x6000698")]
		[Address(RVA = "0x1338744", Offset = "0x1338744", VA = "0x1338744")]
		public static void ResampleAndConvert(float[] src, short[] dst, int dstCount, int channels)
		{
		}

		[Token(Token = "0x6000699")]
		[Address(RVA = "0x1338A50", Offset = "0x1338A50", VA = "0x1338A50")]
		public static void Convert(float[] src, short[] dst, int dstCount)
		{
		}

		[Token(Token = "0x600069A")]
		[Address(RVA = "0x1338B1C", Offset = "0x1338B1C", VA = "0x1338B1C")]
		public static void Convert(short[] src, float[] dst, int dstCount)
		{
		}

		[Token(Token = "0x600069B")]
		public static void ForceToStereo<T>(T[] src, T[] dst, int srcChannels)
		{
		}

		[Token(Token = "0x600069C")]
		internal static string tostr<T>(T[] x, int lim = 10)
		{
			return null;
		}
	}
	[Token(Token = "0x20000C8")]
	public interface IAudioOut
	{
		[Token(Token = "0x170000CC")]
		bool IsPlaying
		{
			[Token(Token = "0x600069D")]
			get;
		}

		[Token(Token = "0x170000CD")]
		int CurrentBufferLag
		{
			[Token(Token = "0x60006A2")]
			get;
		}

		[Token(Token = "0x600069E")]
		void Start(int frequency, int channels, int frameSamplesPerChannel, int playDelayMs);

		[Token(Token = "0x600069F")]
		void Stop();

		[Token(Token = "0x60006A0")]
		void OnAudioFrame(float[] frame);

		[Token(Token = "0x60006A1")]
		void Service();
	}
	[Token(Token = "0x20000C9")]
	public abstract class ObjectPool<TType, TInfo> : IDisposable
	{
		[Token(Token = "0x400058B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		protected int capacity;

		[Token(Token = "0x400058C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		protected TInfo info;

		[Token(Token = "0x400058D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private TType[] freeObj;

		[Token(Token = "0x400058E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		protected int pos;

		[Token(Token = "0x400058F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		protected string name;

		[Token(Token = "0x4000590")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private bool inited;

		[Token(Token = "0x170000CE")]
		internal string LogPrefix
		{
			[Token(Token = "0x60006A6")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000CF")]
		public TInfo Info
		{
			[Token(Token = "0x60006AA")]
			get
			{
				return (TInfo)null;
			}
		}

		[Token(Token = "0x60006A3")]
		protected abstract TType createObject(TInfo info);

		[Token(Token = "0x60006A4")]
		protected abstract void destroyObject(TType obj);

		[Token(Token = "0x60006A5")]
		protected abstract bool infosMatch(TInfo i0, TInfo i1);

		[Token(Token = "0x60006A7")]
		public ObjectPool(int capacity, string name)
		{
		}

		[Token(Token = "0x60006A8")]
		public ObjectPool(int capacity, string name, TInfo info)
		{
		}

		[Token(Token = "0x60006A9")]
		public void Init(TInfo info)
		{
		}

		[Token(Token = "0x60006AB")]
		public TType AcquireOrCreate()
		{
			return (TType)null;
		}

		[Token(Token = "0x60006AC")]
		public TType AcquireOrCreate(TInfo info)
		{
			return (TType)null;
		}

		[Token(Token = "0x60006AD")]
		public virtual bool Release(TType obj, TInfo objInfo)
		{
			return default(bool);
		}

		[Token(Token = "0x60006AE")]
		public virtual bool Release(TType obj)
		{
			return default(bool);
		}

		[Token(Token = "0x60006AF")]
		public void Dispose()
		{
		}
	}
	[Token(Token = "0x20000CA")]
	public class PrimitiveArrayPool<T> : ObjectPool<T[], int>
	{
		[Token(Token = "0x60006B0")]
		public PrimitiveArrayPool(int capacity, string name)
		{
		}

		[Token(Token = "0x60006B1")]
		public PrimitiveArrayPool(int capacity, string name, int info)
		{
		}

		[Token(Token = "0x60006B2")]
		protected override T[] createObject(int info)
		{
			return null;
		}

		[Token(Token = "0x60006B3")]
		protected override void destroyObject(T[] obj)
		{
		}

		[Token(Token = "0x60006B4")]
		protected override bool infosMatch(int i0, int i1)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x20000CB")]
	public class ImageBufferNativePool<T> : ObjectPool<T, ImageBufferInfo> where T : ImageBufferNative
	{
		[Token(Token = "0x200019C")]
		public delegate T Factory(ImageBufferNativePool<T> pool, ImageBufferInfo info);

		[Token(Token = "0x4000591")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Factory factory;

		[Token(Token = "0x60006B5")]
		public ImageBufferNativePool(int capacity, Factory factory, string name)
		{
		}

		[Token(Token = "0x60006B6")]
		public ImageBufferNativePool(int capacity, Factory factory, string name, ImageBufferInfo info)
		{
		}

		[Token(Token = "0x60006B7")]
		protected override T createObject(ImageBufferInfo info)
		{
			return null;
		}

		[Token(Token = "0x60006B8")]
		protected override void destroyObject(T obj)
		{
		}

		[Token(Token = "0x60006B9")]
		protected override bool infosMatch(ImageBufferInfo i0, ImageBufferInfo i1)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x20000CC")]
	public class OpusCodec
	{
		[Token(Token = "0x200019D")]
		public enum FrameDuration
		{
			[Token(Token = "0x4000A3A")]
			Frame2dot5ms = 2500,
			[Token(Token = "0x4000A3B")]
			Frame5ms = 5000,
			[Token(Token = "0x4000A3C")]
			Frame10ms = 10000,
			[Token(Token = "0x4000A3D")]
			Frame20ms = 20000,
			[Token(Token = "0x4000A3E")]
			Frame40ms = 40000,
			[Token(Token = "0x4000A3F")]
			Frame60ms = 60000
		}

		[Token(Token = "0x200019E")]
		public static class EncoderFactory
		{
			[Token(Token = "0x6000B94")]
			[Address(RVA = "0x133CAE0", Offset = "0x133CAE0", VA = "0x133CAE0")]
			public static IEncoder Create(VoiceInfo i, LocalVoice localVoice)
			{
				return null;
			}
		}

		[Token(Token = "0x200019F")]
		public abstract class Encoder<T> : IEncoderDataFlowDirect<T>, IEncoderDataFlow<T>, IEncoder, IDisposable
		{
			[Token(Token = "0x4000A40")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			protected OpusEncoder encoder;

			[Token(Token = "0x4000A41")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			protected bool disposed;

			[Token(Token = "0x6000B95")]
			protected Encoder(VoiceInfo i)
			{
			}

			[Token(Token = "0x6000B96")]
			public void Dispose()
			{
			}

			[Token(Token = "0x6000B97")]
			public abstract ArraySegment<byte> EncodeAndGetOutput(T[] buf);
		}

		[Token(Token = "0x20001A0")]
		public class EncoderFloat : Encoder<float>
		{
			[Token(Token = "0x4000A42")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static readonly ArraySegment<byte> EmptyBuffer;

			[Token(Token = "0x6000B98")]
			[Address(RVA = "0x133CCD0", Offset = "0x133CCD0", VA = "0x133CCD0")]
			internal EncoderFloat(VoiceInfo i)
			{
			}

			[Token(Token = "0x6000B99")]
			[Address(RVA = "0x133CDF8", Offset = "0x133CDF8", VA = "0x133CDF8", Slot = "6")]
			public override ArraySegment<byte> EncodeAndGetOutput(float[] buf)
			{
				return default(ArraySegment<byte>);
			}
		}

		[Token(Token = "0x20001A1")]
		public class EncoderShort : Encoder<short>
		{
			[Token(Token = "0x4000A43")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static readonly ArraySegment<byte> EmptyBuffer;

			[Token(Token = "0x6000B9B")]
			[Address(RVA = "0x133CD64", Offset = "0x133CD64", VA = "0x133CD64")]
			internal EncoderShort(VoiceInfo i)
			{
			}

			[Token(Token = "0x6000B9C")]
			[Address(RVA = "0x133CFC4", Offset = "0x133CFC4", VA = "0x133CFC4", Slot = "6")]
			public override ArraySegment<byte> EncodeAndGetOutput(short[] buf)
			{
				return default(ArraySegment<byte>);
			}
		}

		[Token(Token = "0x20001A2")]
		public class Decoder : IDecoderDirect, IDecoder, IDisposable
		{
			[Token(Token = "0x4000A44")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private OpusDecoder decoder;

			[Token(Token = "0x6000B9E")]
			[Address(RVA = "0x133C938", Offset = "0x133C938", VA = "0x133C938", Slot = "7")]
			public void Open(VoiceInfo i)
			{
			}

			[Token(Token = "0x6000B9F")]
			[Address(RVA = "0x133C9D0", Offset = "0x133C9D0", VA = "0x133C9D0", Slot = "4")]
			public byte[] DecodeToByte(byte[] buf)
			{
				return null;
			}

			[Token(Token = "0x6000BA0")]
			[Address(RVA = "0x133CA38", Offset = "0x133CA38", VA = "0x133CA38", Slot = "5")]
			public float[] DecodeToFloat(byte[] buf)
			{
				return null;
			}

			[Token(Token = "0x6000BA1")]
			[Address(RVA = "0x133CA70", Offset = "0x133CA70", VA = "0x133CA70", Slot = "6")]
			public short[] DecodeToShort(byte[] buf)
			{
				return null;
			}

			[Token(Token = "0x6000BA2")]
			[Address(RVA = "0x133CAA8", Offset = "0x133CAA8", VA = "0x133CAA8", Slot = "8")]
			public void Dispose()
			{
			}

			[Token(Token = "0x6000BA3")]
			[Address(RVA = "0x133CAD8", Offset = "0x133CAD8", VA = "0x133CAD8")]
			public Decoder()
			{
			}
		}

		[Token(Token = "0x20001A3")]
		public class Util
		{
			[Token(Token = "0x6000BA4")]
			[Address(RVA = "0x133D190", Offset = "0x133D190", VA = "0x133D190")]
			internal static int bestEncoderSampleRate(int f)
			{
				return default(int);
			}

			[Token(Token = "0x6000BA5")]
			[Address(RVA = "0x133D4F4", Offset = "0x133D4F4", VA = "0x133D4F4")]
			public Util()
			{
			}
		}

		[Token(Token = "0x60006BA")]
		[Address(RVA = "0x133C930", Offset = "0x133C930", VA = "0x133C930")]
		public OpusCodec()
		{
		}
	}
	[Token(Token = "0x20000CD")]
	public class SpeexProcessor : SpeexLib, LocalVoiceFramed<short>.IProcessor, IDisposable
	{
		[Token(Token = "0x20001A4")]
		public struct AECLatencyResultType
		{
			[Token(Token = "0x4000A45")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int LatencyMs;

			[Token(Token = "0x4000A46")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public int LatencyDelayedMs;

			[Token(Token = "0x4000A47")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public bool PlayDetected;

			[Token(Token = "0x4000A48")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x9")]
			public bool PlayDelayedDetected;

			[Token(Token = "0x4000A49")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA")]
			public bool RecDetected;
		}

		[Serializable]
		[Token(Token = "0x20001A5")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9D605C", Offset = "0x9D605C")]
		private sealed class <>c
		{
			[Token(Token = "0x4000A4A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x4000A4B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Func<long> <>9__58_0;

			[Token(Token = "0x6000BA7")]
			[Address(RVA = "0x1342B44", Offset = "0x1342B44", VA = "0x1342B44")]
			public <>c()
			{
			}

			[Token(Token = "0x6000BA8")]
			[Address(RVA = "0x1342B4C", Offset = "0x1342B4C", VA = "0x1342B4C")]
			internal long <.ctor>b__58_0()
			{
				return default(long);
			}
		}

		[Token(Token = "0x4000592")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private bool _AEC;

		[Token(Token = "0x4000593")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DA294", Offset = "0x9DA294")]
		private int <AECFilterLengthMs>k__BackingField;

		[Token(Token = "0x4000594")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private int _AECPlaybackDelayMs;

		[Token(Token = "0x4000595")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private bool _AECLatencyDetect;

		[Token(Token = "0x4000596")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private int frameSamples;

		[Token(Token = "0x4000597")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private int samplingRate;

		[Token(Token = "0x4000598")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private int channels;

		[Token(Token = "0x4000599")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private int playDelayFrames;

		[Token(Token = "0x400059A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private int playDelayMaxFrames;

		[Token(Token = "0x400059B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private IntPtr stEcho;

		[Token(Token = "0x400059C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private IntPtr st;

		[Token(Token = "0x400059D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private bool disposed;

		[Token(Token = "0x400059E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private short[] resultBuf;

		[Token(Token = "0x400059F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private PrimitiveArrayPool<short> playbackBufPool;

		[Token(Token = "0x40005A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Queue<short[]> playBufQueue;

		[Token(Token = "0x40005A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Framer<float> playFramer;

		[Token(Token = "0x40005A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private int playSamplingRate;

		[Token(Token = "0x40005A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private int playChannels;

		[Token(Token = "0x40005A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private ILogger logger;

		[Token(Token = "0x40005A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Func<long> clockMs;

		[Token(Token = "0x40005A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private AudioUtil.VoiceLevelDetectCalibrate<float> detectPlay;

		[Token(Token = "0x40005A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private AudioUtil.VoiceLevelDetectCalibrate<short> detectPlayCorr;

		[Token(Token = "0x40005A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private AudioUtil.VoiceLevelDetectCalibrate<short> detectRec;

		[Token(Token = "0x40005A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private long detectTimePlay;

		[Token(Token = "0x40005AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private long detectTimePlayDelayed;

		[Token(Token = "0x40005AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private long detectTimeRec;

		[Token(Token = "0x40005AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private int frameCntRec;

		[Token(Token = "0x40005AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		private int frameCntPlay;

		[Token(Token = "0x170000D0")]
		public bool AEC
		{
			[Token(Token = "0x60006BB")]
			[Address(RVA = "0x13404E0", Offset = "0x13404E0", VA = "0x13404E0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60006BC")]
			[Address(RVA = "0x13404E8", Offset = "0x13404E8", VA = "0x13404E8")]
			set
			{
			}
		}

		[Token(Token = "0x170000D1")]
		public int AECFilterLengthMs
		{
			[Token(Token = "0x60006BD")]
			[Address(RVA = "0x1340580", Offset = "0x1340580", VA = "0x1340580")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DF368", Offset = "0x9DF368")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60006BE")]
			[Address(RVA = "0x1340588", Offset = "0x1340588", VA = "0x1340588")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DF378", Offset = "0x9DF378")]
			set
			{
			}
		}

		[Token(Token = "0x170000D2")]
		public int AECPlaybackDelayMs
		{
			[Token(Token = "0x60006BF")]
			[Address(RVA = "0x1340590", Offset = "0x1340590", VA = "0x1340590")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60006C0")]
			[Address(RVA = "0x1340598", Offset = "0x1340598", VA = "0x1340598")]
			set
			{
			}
		}

		[Token(Token = "0x170000D3")]
		public int AECurrentPlayDelayFrames
		{
			[Token(Token = "0x60006C1")]
			[Address(RVA = "0x1340670", Offset = "0x1340670", VA = "0x1340670")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170000D4")]
		public bool AECLatencyDetect
		{
			[Token(Token = "0x60006C2")]
			[Address(RVA = "0x13406D0", Offset = "0x13406D0", VA = "0x13406D0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60006C3")]
			[Address(RVA = "0x13406D8", Offset = "0x13406D8", VA = "0x13406D8")]
			set
			{
			}
		}

		[Token(Token = "0x170000D5")]
		public AECLatencyResultType AECLatencyResult
		{
			[Token(Token = "0x60006C4")]
			[Address(RVA = "0x1340A30", Offset = "0x1340A30", VA = "0x1340A30")]
			get
			{
				return default(AECLatencyResultType);
			}
		}

		[Token(Token = "0x170000D6")]
		public bool Denoise
		{
			[Token(Token = "0x60006C7")]
			[Address(RVA = "0x1340E68", Offset = "0x1340E68", VA = "0x1340E68")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60006C8")]
			[Address(RVA = "0x1340ED4", Offset = "0x1340ED4", VA = "0x1340ED4")]
			set
			{
			}
		}

		[Token(Token = "0x170000D7")]
		public bool AGC
		{
			[Token(Token = "0x60006C9")]
			[Address(RVA = "0x1340F30", Offset = "0x1340F30", VA = "0x1340F30")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60006CA")]
			[Address(RVA = "0x1340F68", Offset = "0x1340F68", VA = "0x1340F68")]
			set
			{
			}
		}

		[Token(Token = "0x170000D8")]
		public float AGCLevel
		{
			[Token(Token = "0x60006CB")]
			[Address(RVA = "0x1340F98", Offset = "0x1340F98", VA = "0x1340F98")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60006CC")]
			[Address(RVA = "0x1340FF4", Offset = "0x1340FF4", VA = "0x1340FF4")]
			set
			{
			}
		}

		[Token(Token = "0x60006C5")]
		[Address(RVA = "0x1340CB0", Offset = "0x1340CB0", VA = "0x1340CB0")]
		public void ResetAEC()
		{
		}

		[Token(Token = "0x60006C6")]
		[Address(RVA = "0x1340DB4", Offset = "0x1340DB4", VA = "0x1340DB4")]
		public void AECLatecnyDetectCaliberate()
		{
		}

		[Token(Token = "0x60006CD")]
		[Address(RVA = "0x1340F04", Offset = "0x1340F04", VA = "0x1340F04")]
		private void set(int param, bool val)
		{
		}

		[Token(Token = "0x60006CE")]
		[Address(RVA = "0x1341020", Offset = "0x1341020", VA = "0x1341020")]
		private void set(int param, float val)
		{
		}

		[Token(Token = "0x60006CF")]
		[Address(RVA = "0x1340EA0", Offset = "0x1340EA0", VA = "0x1340EA0")]
		private bool getBool(int param)
		{
			return default(bool);
		}

		[Token(Token = "0x60006D0")]
		[Address(RVA = "0x1340FC8", Offset = "0x1340FC8", VA = "0x1340FC8")]
		private float getFloat(int param)
		{
			return default(float);
		}

		[Token(Token = "0x60006D1")]
		[Address(RVA = "0x1341048", Offset = "0x1341048", VA = "0x1341048")]
		public SpeexProcessor(ILogger logger, Func<long> clockMs, int frameSize, int samplingRate, int channels, int playSamplingRate, int playChannels, int playBufSize)
		{
		}

		[Token(Token = "0x60006D2")]
		[Address(RVA = "0x1340704", Offset = "0x1340704", VA = "0x1340704")]
		private void InitLatencyDetect()
		{
		}

		[Token(Token = "0x60006D3")]
		[Address(RVA = "0x1341344", Offset = "0x1341344", VA = "0x1341344")]
		public void InitAEC()
		{
		}

		[Token(Token = "0x60006D4")]
		[Address(RVA = "0x13405B0", Offset = "0x13405B0", VA = "0x13405B0")]
		private void InitPlayDelay(int ms)
		{
		}

		[Token(Token = "0x60006D5")]
		[Address(RVA = "0x1341BDC", Offset = "0x1341BDC", VA = "0x1341BDC", Slot = "4")]
		public short[] Process(short[] buf)
		{
			return null;
		}

		[Token(Token = "0x60006D6")]
		[Address(RVA = "0x1341F44", Offset = "0x1341F44", VA = "0x1341F44")]
		public void OnAudioOutFrame(float[] data, int outChannels)
		{
		}

		[Token(Token = "0x60006D7")]
		[Address(RVA = "0x13428B0", Offset = "0x13428B0", VA = "0x13428B0")]
		public void PrintInfo()
		{
		}

		[Token(Token = "0x60006D8")]
		[Address(RVA = "0x1340D44", Offset = "0x1340D44", VA = "0x1340D44")]
		private void DestroyEchoState()
		{
		}

		[Token(Token = "0x60006D9")]
		[Address(RVA = "0x13428B4", Offset = "0x13428B4", VA = "0x13428B4", Slot = "5")]
		public void Dispose()
		{
		}

		[Token(Token = "0x60006DA")]
		[Address(RVA = "0x13429A8", Offset = "0x13429A8", VA = "0x13429A8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DF388", Offset = "0x9DF388")]
		private void <InitLatencyDetect>b__59_0()
		{
		}

		[Token(Token = "0x60006DB")]
		[Address(RVA = "0x1342A10", Offset = "0x1342A10", VA = "0x1342A10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DF398", Offset = "0x9DF398")]
		private void <InitLatencyDetect>b__59_1()
		{
		}

		[Token(Token = "0x60006DC")]
		[Address(RVA = "0x1342A78", Offset = "0x1342A78", VA = "0x1342A78")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DF3A8", Offset = "0x9DF3A8")]
		private void <InitLatencyDetect>b__59_2()
		{
		}
	}
	[Token(Token = "0x20000CE")]
	public class SpeexLib
	{
		[Token(Token = "0x40005AE")]
		private const string lib_name = "libspeexdsp";

		[Token(Token = "0x40005AF")]
		public const int SPEEX_PREPROCESS_SET_DENOISE = 0;

		[Token(Token = "0x40005B0")]
		public const int SPEEX_PREPROCESS_GET_DENOISE = 1;

		[Token(Token = "0x40005B1")]
		public const int SPEEX_PREPROCESS_SET_AGC = 2;

		[Token(Token = "0x40005B2")]
		public const int SPEEX_PREPROCESS_GET_AGC = 3;

		[Token(Token = "0x40005B3")]
		public const int SPEEX_PREPROCESS_SET_VAD = 4;

		[Token(Token = "0x40005B4")]
		public const int SPEEX_PREPROCESS_GET_VAD = 5;

		[Token(Token = "0x40005B5")]
		public const int SPEEX_PREPROCESS_SET_AGC_LEVEL = 6;

		[Token(Token = "0x40005B6")]
		public const int SPEEX_PREPROCESS_GET_AGC_LEVEL = 7;

		[Token(Token = "0x40005B7")]
		public const int SPEEX_PREPROCESS_SET_DEREVERB = 8;

		[Token(Token = "0x40005B8")]
		public const int SPEEX_PREPROCESS_GET_DEREVERB = 9;

		[Token(Token = "0x40005B9")]
		public const int SPEEX_PREPROCESS_SET_DEREVERB_LEVEL = 10;

		[Token(Token = "0x40005BA")]
		public const int SPEEX_PREPROCESS_GET_DEREVERB_LEVEL = 11;

		[Token(Token = "0x40005BB")]
		public const int SPEEX_PREPROCESS_SET_DEREVERB_DECAY = 12;

		[Token(Token = "0x40005BC")]
		public const int SPEEX_PREPROCESS_GET_DEREVERB_DECAY = 13;

		[Token(Token = "0x40005BD")]
		public const int SPEEX_PREPROCESS_SET_PROB_START = 14;

		[Token(Token = "0x40005BE")]
		public const int SPEEX_PREPROCESS_GET_PROB_START = 15;

		[Token(Token = "0x40005BF")]
		public const int SPEEX_PREPROCESS_SET_PROB_CONTINUE = 16;

		[Token(Token = "0x40005C0")]
		public const int SPEEX_PREPROCESS_GET_PROB_CONTINUE = 17;

		[Token(Token = "0x40005C1")]
		public const int SPEEX_PREPROCESS_SET_NOISE_SUPPRESS = 18;

		[Token(Token = "0x40005C2")]
		public const int SPEEX_PREPROCESS_GET_NOISE_SUPPRESS = 19;

		[Token(Token = "0x40005C3")]
		public const int SPEEX_PREPROCESS_SET_ECHO_SUPPRESS = 20;

		[Token(Token = "0x40005C4")]
		public const int SPEEX_PREPROCESS_GET_ECHO_SUPPRESS = 21;

		[Token(Token = "0x40005C5")]
		public const int SPEEX_PREPROCESS_SET_ECHO_SUPPRESS_ACTIVE = 22;

		[Token(Token = "0x40005C6")]
		public const int SPEEX_PREPROCESS_GET_ECHO_SUPPRESS_ACTIVE = 23;

		[Token(Token = "0x40005C7")]
		public const int SPEEX_PREPROCESS_SET_ECHO_STATE = 24;

		[Token(Token = "0x40005C8")]
		public const int SPEEX_PREPROCESS_GET_ECHO_STATE = 25;

		[Token(Token = "0x40005C9")]
		public const int SPEEX_PREPROCESS_SET_AGC_INCREMENT = 26;

		[Token(Token = "0x40005CA")]
		public const int SPEEX_PREPROCESS_GET_AGC_INCREMENT = 27;

		[Token(Token = "0x40005CB")]
		public const int SPEEX_PREPROCESS_SET_AGC_DECREMENT = 28;

		[Token(Token = "0x40005CC")]
		public const int SPEEX_PREPROCESS_GET_AGC_DECREMENT = 29;

		[Token(Token = "0x40005CD")]
		public const int SPEEX_PREPROCESS_SET_AGC_MAX_GAIN = 30;

		[Token(Token = "0x40005CE")]
		public const int SPEEX_PREPROCESS_GET_AGC_MAX_GAIN = 31;

		[Token(Token = "0x40005CF")]
		public const int SPEEX_PREPROCESS_GET_AGC_LOUDNESS = 33;

		[Token(Token = "0x40005D0")]
		public const int SPEEX_PREPROCESS_GET_AGC_GAIN = 35;

		[Token(Token = "0x40005D1")]
		public const int SPEEX_PREPROCESS_GET_PSD_SIZE = 37;

		[Token(Token = "0x40005D2")]
		public const int SPEEX_PREPROCESS_GET_PSD = 39;

		[Token(Token = "0x40005D3")]
		public const int SPEEX_PREPROCESS_GET_NOISE_PSD_SIZE = 41;

		[Token(Token = "0x40005D4")]
		public const int SPEEX_PREPROCESS_GET_NOISE_PSD = 43;

		[Token(Token = "0x40005D5")]
		public const int SPEEX_PREPROCESS_GET_PROB = 45;

		[Token(Token = "0x40005D6")]
		public const int SPEEX_PREPROCESS_SET_AGC_TARGET = 46;

		[Token(Token = "0x40005D7")]
		public const int SPEEX_PREPROCESS_GET_AGC_TARGET = 47;

		[Token(Token = "0x40005D8")]
		public const int SPEEX_ECHO_GET_FRAME_SIZE = 3;

		[Token(Token = "0x40005D9")]
		public const int SPEEX_ECHO_SET_SAMPLING_RATE = 24;

		[Token(Token = "0x40005DA")]
		public const int SPEEX_ECHO_GET_SAMPLING_RATE = 25;

		[Token(Token = "0x40005DB")]
		public const int SPEEX_ECHO_GET_IMPULSE_RESPONSE_SIZE = 27;

		[Token(Token = "0x40005DC")]
		public const int SPEEX_ECHO_GET_IMPULSE_RESPONSE = 29;

		[PreserveSig]
		[Token(Token = "0x60006DD")]
		[Address(RVA = "0x133F79C", Offset = "0x133F79C", VA = "0x133F79C")]
		public static extern IntPtr speex_preprocess_state_init(int frame_size, int sampling_rate);

		[PreserveSig]
		[Token(Token = "0x60006DE")]
		[Address(RVA = "0x133F848", Offset = "0x133F848", VA = "0x133F848")]
		public static extern void speex_preprocess_state_destroy(IntPtr st);

		[PreserveSig]
		[Token(Token = "0x60006DF")]
		[Address(RVA = "0x133F8E4", Offset = "0x133F8E4", VA = "0x133F8E4")]
		public static extern int speex_preprocess_run(IntPtr st, short[] x);

		[PreserveSig]
		[Token(Token = "0x60006E0")]
		[Address(RVA = "0x133F998", Offset = "0x133F998", VA = "0x133F998")]
		public static extern int speex_preprocess_ctl(IntPtr st, int request, IntPtr ptr);

		[Token(Token = "0x60006E1")]
		[Address(RVA = "0x133FA48", Offset = "0x133FA48", VA = "0x133FA48")]
		public static int speex_preprocess_ctl(IntPtr st, int request, ref int value)
		{
			return default(int);
		}

		[Token(Token = "0x60006E2")]
		[Address(RVA = "0x133FB88", Offset = "0x133FB88", VA = "0x133FB88")]
		public static int speex_preprocess_ctl(IntPtr st, int request, ref float value)
		{
			return default(int);
		}

		[PreserveSig]
		[Token(Token = "0x60006E3")]
		[Address(RVA = "0x133FCA8", Offset = "0x133FCA8", VA = "0x133FCA8")]
		public static extern IntPtr speex_echo_state_init(int frame_size, int filter_length);

		[PreserveSig]
		[Token(Token = "0x60006E4")]
		[Address(RVA = "0x133FD54", Offset = "0x133FD54", VA = "0x133FD54")]
		public static extern IntPtr speex_echo_state_init_mc(int frame_size, int filter_length, int nb_mic, int nb_speakers);

		[PreserveSig]
		[Token(Token = "0x60006E5")]
		[Address(RVA = "0x133FE18", Offset = "0x133FE18", VA = "0x133FE18")]
		public static extern void speex_echo_state_destroy(IntPtr st);

		[PreserveSig]
		[Token(Token = "0x60006E6")]
		[Address(RVA = "0x133FEB4", Offset = "0x133FEB4", VA = "0x133FEB4")]
		public static extern void speex_echo_cancellation(IntPtr st, short[] rec, short[] play, short[] outBuf);

		[PreserveSig]
		[Token(Token = "0x60006E7")]
		[Address(RVA = "0x133FF90", Offset = "0x133FF90", VA = "0x133FF90")]
		public static extern void speex_echo_capture(IntPtr st, short[] rec, short[] outBuf);

		[PreserveSig]
		[Token(Token = "0x60006E8")]
		[Address(RVA = "0x1340054", Offset = "0x1340054", VA = "0x1340054")]
		public static extern void speex_echo_playback(IntPtr st, short[] play);

		[PreserveSig]
		[Token(Token = "0x60006E9")]
		[Address(RVA = "0x1340108", Offset = "0x1340108", VA = "0x1340108")]
		public static extern void speex_echo_state_reset(IntPtr st);

		[PreserveSig]
		[Token(Token = "0x60006EA")]
		[Address(RVA = "0x13401A4", Offset = "0x13401A4", VA = "0x13401A4")]
		public static extern int speex_echo_ctl(IntPtr st, int request, IntPtr ptr);

		[Token(Token = "0x60006EB")]
		[Address(RVA = "0x1340258", Offset = "0x1340258", VA = "0x1340258")]
		public static int speex_echo_ctl(IntPtr st, int request, ref int value)
		{
			return default(int);
		}

		[Token(Token = "0x60006EC")]
		[Address(RVA = "0x1340398", Offset = "0x1340398", VA = "0x1340398")]
		public static int speex_echo_ctl(IntPtr st, int request, ref float value)
		{
			return default(int);
		}

		[Token(Token = "0x60006ED")]
		[Address(RVA = "0x13404D8", Offset = "0x13404D8", VA = "0x13404D8")]
		public SpeexLib()
		{
		}
	}
	[Token(Token = "0x20000CF")]
	public interface IDataReader<T> : IDisposable
	{
		[Token(Token = "0x60006EE")]
		bool Read(T[] buffer);
	}
	[Token(Token = "0x20000D0")]
	public interface IServiceable
	{
		[Token(Token = "0x60006EF")]
		void Service(LocalVoice localVoice);
	}
	[Token(Token = "0x20000D1")]
	public class LocalVoice : IDisposable
	{
		[Token(Token = "0x40005DD")]
		public const int DATA_POOL_CAPACITY = 50;

		[Token(Token = "0x40005DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DA2A4", Offset = "0x9DA2A4")]
		private byte <Group>k__BackingField;

		[Token(Token = "0x40005DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DA2B4", Offset = "0x9DA2B4")]
		private bool <Transmit>k__BackingField;

		[Token(Token = "0x40005E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x12")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DA2C4", Offset = "0x9DA2C4")]
		private bool <IsTransmitting>k__BackingField;

		[Token(Token = "0x40005E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DA2D4", Offset = "0x9DA2D4")]
		private int <FramesSent>k__BackingField;

		[Token(Token = "0x40005E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DA2E4", Offset = "0x9DA2E4")]
		private int <FramesSentBytes>k__BackingField;

		[Token(Token = "0x40005E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DA2F4", Offset = "0x9DA2F4")]
		private bool <Reliable>k__BackingField;

		[Token(Token = "0x40005E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DA304", Offset = "0x9DA304")]
		private bool <Encrypt>k__BackingField;

		[Token(Token = "0x40005E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DA314", Offset = "0x9DA314")]
		private object <LocalUserObject>k__BackingField;

		[Token(Token = "0x40005E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DA324", Offset = "0x9DA324")]
		private IServiceable <LocalUserServiceable>k__BackingField;

		[Token(Token = "0x40005E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private bool debugEchoMode;

		[Token(Token = "0x40005E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		internal VoiceInfo info;

		[Token(Token = "0x40005E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		protected IEncoder encoder;

		[Token(Token = "0x40005EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		internal byte id;

		[Token(Token = "0x40005EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		internal int channelId;

		[Token(Token = "0x40005EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		internal byte evNumber;

		[Token(Token = "0x40005ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		protected VoiceClient voiceClient;

		[Token(Token = "0x40005EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		protected bool disposed;

		[Token(Token = "0x40005EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		protected object disposeLock;

		[Token(Token = "0x40005F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private int noTransmitCnt;

		[Token(Token = "0x40005F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		internal Dictionary<byte, int> eventTimestamps;

		[Token(Token = "0x170000D9")]
		public byte Group
		{
			[Token(Token = "0x60006F0")]
			[Address(RVA = "0x133AE78", Offset = "0x133AE78", VA = "0x133AE78")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DF3B8", Offset = "0x9DF3B8")]
			get
			{
				return default(byte);
			}
			[Token(Token = "0x60006F1")]
			[Address(RVA = "0x133B4BC", Offset = "0x133B4BC", VA = "0x133B4BC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DF3C8", Offset = "0x9DF3C8")]
			set
			{
			}
		}

		[Token(Token = "0x170000DA")]
		public VoiceInfo Info
		{
			[Token(Token = "0x60006F2")]
			[Address(RVA = "0x133B4C4", Offset = "0x133B4C4", VA = "0x133B4C4")]
			get
			{
				return default(VoiceInfo);
			}
		}

		[Token(Token = "0x170000DB")]
		public bool Transmit
		{
			[Token(Token = "0x60006F3")]
			[Address(RVA = "0x133B4E0", Offset = "0x133B4E0", VA = "0x133B4E0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DF3D8", Offset = "0x9DF3D8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60006F4")]
			[Address(RVA = "0x133B4E8", Offset = "0x133B4E8", VA = "0x133B4E8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DF3E8", Offset = "0x9DF3E8")]
			set
			{
			}
		}

		[Token(Token = "0x170000DC")]
		public bool IsTransmitting
		{
			[Token(Token = "0x60006F5")]
			[Address(RVA = "0x133B4F4", Offset = "0x133B4F4", VA = "0x133B4F4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DF3F8", Offset = "0x9DF3F8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60006F6")]
			[Address(RVA = "0x133B4FC", Offset = "0x133B4FC", VA = "0x133B4FC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DF408", Offset = "0x9DF408")]
			protected set
			{
			}
		}

		[Token(Token = "0x170000DD")]
		public int FramesSent
		{
			[Token(Token = "0x60006F7")]
			[Address(RVA = "0x133B508", Offset = "0x133B508", VA = "0x133B508")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DF418", Offset = "0x9DF418")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60006F8")]
			[Address(RVA = "0x133B510", Offset = "0x133B510", VA = "0x133B510")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DF428", Offset = "0x9DF428")]
			private set
			{
			}
		}

		[Token(Token = "0x170000DE")]
		public int FramesSentBytes
		{
			[Token(Token = "0x60006F9")]
			[Address(RVA = "0x133B518", Offset = "0x133B518", VA = "0x133B518")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DF438", Offset = "0x9DF438")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60006FA")]
			[Address(RVA = "0x133B520", Offset = "0x133B520", VA = "0x133B520")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DF448", Offset = "0x9DF448")]
			private set
			{
			}
		}

		[Token(Token = "0x170000DF")]
		public bool Reliable
		{
			[Token(Token = "0x60006FB")]
			[Address(RVA = "0x133AE68", Offset = "0x133AE68", VA = "0x133AE68")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DF458", Offset = "0x9DF458")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60006FC")]
			[Address(RVA = "0x133B528", Offset = "0x133B528", VA = "0x133B528")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DF468", Offset = "0x9DF468")]
			set
			{
			}
		}

		[Token(Token = "0x170000E0")]
		public bool Encrypt
		{
			[Token(Token = "0x60006FD")]
			[Address(RVA = "0x133AE70", Offset = "0x133AE70", VA = "0x133AE70")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DF478", Offset = "0x9DF478")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60006FE")]
			[Address(RVA = "0x133B534", Offset = "0x133B534", VA = "0x133B534")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DF488", Offset = "0x9DF488")]
			set
			{
			}
		}

		[Token(Token = "0x170000E1")]
		public object LocalUserObject
		{
			[Token(Token = "0x60006FF")]
			[Address(RVA = "0x133B540", Offset = "0x133B540", VA = "0x133B540")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DF498", Offset = "0x9DF498")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000700")]
			[Address(RVA = "0x133B548", Offset = "0x133B548", VA = "0x133B548")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DF4A8", Offset = "0x9DF4A8")]
			set
			{
			}
		}

		[Token(Token = "0x170000E2")]
		public IServiceable LocalUserServiceable
		{
			[Token(Token = "0x6000701")]
			[Address(RVA = "0x133B550", Offset = "0x133B550", VA = "0x133B550")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DF4B8", Offset = "0x9DF4B8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000702")]
			[Address(RVA = "0x133B558", Offset = "0x133B558", VA = "0x133B558")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DF4C8", Offset = "0x9DF4C8")]
			set
			{
			}
		}

		[Token(Token = "0x170000E3")]
		public bool DebugEchoMode
		{
			[Token(Token = "0x6000703")]
			[Address(RVA = "0x133A1C8", Offset = "0x133A1C8", VA = "0x133A1C8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000704")]
			[Address(RVA = "0x133B560", Offset = "0x133B560", VA = "0x133B560")]
			set
			{
			}
		}

		[Token(Token = "0x170000E4")]
		internal string Name
		{
			[Token(Token = "0x6000707")]
			[Address(RVA = "0x133B7E0", Offset = "0x133B7E0", VA = "0x133B7E0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000E5")]
		internal string LogPrefix
		{
			[Token(Token = "0x6000708")]
			[Address(RVA = "0x133B9D0", Offset = "0x133B9D0", VA = "0x133B9D0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000705")]
		[Address(RVA = "0x133B664", Offset = "0x133B664", VA = "0x133B664")]
		internal LocalVoice()
		{
		}

		[Token(Token = "0x6000706")]
		[Address(RVA = "0x133B6F4", Offset = "0x133B6F4", VA = "0x133B6F4")]
		internal LocalVoice(VoiceClient voiceClient, IEncoder encoder, byte id, VoiceInfo voiceInfo, int channelId)
		{
		}

		[Token(Token = "0x6000709")]
		[Address(RVA = "0x133BA30", Offset = "0x133BA30", VA = "0x133BA30")]
		protected void resetNoTransmitCnt()
		{
		}

		[Token(Token = "0x600070A")]
		[Address(RVA = "0x133BA3C", Offset = "0x133BA3C", VA = "0x133BA3C", Slot = "5")]
		internal virtual void service()
		{
		}

		[Token(Token = "0x600070B")]
		[Address(RVA = "0x133BEE0", Offset = "0x133BEE0", VA = "0x133BEE0")]
		internal void sendFrame(ArraySegment<byte> compressed)
		{
		}

		[Token(Token = "0x600070C")]
		[Address(RVA = "0x133C070", Offset = "0x133C070", VA = "0x133C070")]
		public void RemoveSelf()
		{
		}

		[Token(Token = "0x600070D")]
		[Address(RVA = "0x133C0A8", Offset = "0x133C0A8", VA = "0x133C0A8", Slot = "6")]
		public virtual void Dispose()
		{
		}
	}
	[Token(Token = "0x20000D2")]
	public struct RemoteVoiceOptions
	{
		[Token(Token = "0x40005F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DA334", Offset = "0x9DA334")]
		private Action<byte[]> <OnDecodedFrameByteAction>k__BackingField;

		[Token(Token = "0x40005F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DA344", Offset = "0x9DA344")]
		private Action<float[]> <OnDecodedFrameFloatAction>k__BackingField;

		[Token(Token = "0x40005F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DA354", Offset = "0x9DA354")]
		private Action<short[]> <OnDecodedFrameShortAction>k__BackingField;

		[Token(Token = "0x40005F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DA364", Offset = "0x9DA364")]
		private Action <OnRemoteVoiceRemoveAction>k__BackingField;

		[Token(Token = "0x40005F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DA374", Offset = "0x9DA374")]
		private object <LocalUserObject>k__BackingField;

		[Token(Token = "0x40005F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DA384", Offset = "0x9DA384")]
		private IDecoder <Decoder>k__BackingField;

		[Token(Token = "0x170000E6")]
		public Action<byte[]> OnDecodedFrameByteAction
		{
			[Token(Token = "0x600070E")]
			[Address(RVA = "0xA98204", Offset = "0xA98204", VA = "0xA98204")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DF4D8", Offset = "0x9DF4D8")]
			get
			{
				return null;
			}
			[Token(Token = "0x600070F")]
			[Address(RVA = "0xA9820C", Offset = "0xA9820C", VA = "0xA9820C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DF4E8", Offset = "0x9DF4E8")]
			set
			{
			}
		}

		[Token(Token = "0x170000E7")]
		public Action<float[]> OnDecodedFrameFloatAction
		{
			[Token(Token = "0x6000710")]
			[Address(RVA = "0xA98214", Offset = "0xA98214", VA = "0xA98214")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DF4F8", Offset = "0x9DF4F8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000711")]
			[Address(RVA = "0xA9821C", Offset = "0xA9821C", VA = "0xA9821C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DF508", Offset = "0x9DF508")]
			set
			{
			}
		}

		[Token(Token = "0x170000E8")]
		public Action<short[]> OnDecodedFrameShortAction
		{
			[Token(Token = "0x6000712")]
			[Address(RVA = "0xA98224", Offset = "0xA98224", VA = "0xA98224")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DF518", Offset = "0x9DF518")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000713")]
			[Address(RVA = "0xA9822C", Offset = "0xA9822C", VA = "0xA9822C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DF528", Offset = "0x9DF528")]
			set
			{
			}
		}

		[Token(Token = "0x170000E9")]
		public Action OnRemoteVoiceRemoveAction
		{
			[Token(Token = "0x6000714")]
			[Address(RVA = "0xA98234", Offset = "0xA98234", VA = "0xA98234")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DF538", Offset = "0x9DF538")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000715")]
			[Address(RVA = "0xA9823C", Offset = "0xA9823C", VA = "0xA9823C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DF548", Offset = "0x9DF548")]
			set
			{
			}
		}

		[Token(Token = "0x170000EA")]
		public object LocalUserObject
		{
			[Token(Token = "0x6000716")]
			[Address(RVA = "0xA98244", Offset = "0xA98244", VA = "0xA98244")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DF558", Offset = "0x9DF558")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000717")]
			[Address(RVA = "0xA9824C", Offset = "0xA9824C", VA = "0xA9824C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DF568", Offset = "0x9DF568")]
			set
			{
			}
		}

		[Token(Token = "0x170000EB")]
		public IDecoder Decoder
		{
			[Token(Token = "0x6000718")]
			[Address(RVA = "0xA98254", Offset = "0xA98254", VA = "0xA98254")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DF578", Offset = "0x9DF578")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000719")]
			[Address(RVA = "0xA9825C", Offset = "0xA9825C", VA = "0xA9825C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DF588", Offset = "0x9DF588")]
			set
			{
			}
		}
	}
	[Token(Token = "0x20000D3")]
	internal class RemoteVoice : IDisposable
	{
		[Token(Token = "0x40005F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DA394", Offset = "0x9DA394")]
		private VoiceInfo <Info>k__BackingField;

		[Token(Token = "0x40005F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		internal RemoteVoiceOptions options;

		[Token(Token = "0x40005FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private int channelId;

		[Token(Token = "0x40005FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private int playerId;

		[Token(Token = "0x40005FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private byte voiceId;

		[Token(Token = "0x40005FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x71")]
		private bool disposed;

		[Token(Token = "0x40005FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private object disposeLock;

		[Token(Token = "0x40005FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		internal byte lastEvNumber;

		[Token(Token = "0x4000600")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private VoiceClient voiceClient;

		[Token(Token = "0x4000601")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Queue<byte[]> frameQueue;

		[Token(Token = "0x4000602")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private AutoResetEvent frameQueueReady;

		[Token(Token = "0x170000EC")]
		internal VoiceInfo Info
		{
			[Token(Token = "0x600071A")]
			[Address(RVA = "0x133D4FC", Offset = "0x133D4FC", VA = "0x133D4FC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DF598", Offset = "0x9DF598")]
			get
			{
				return default(VoiceInfo);
			}
			[Token(Token = "0x600071B")]
			[Address(RVA = "0x133D518", Offset = "0x133D518", VA = "0x133D518")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DF5A8", Offset = "0x9DF5A8")]
			private set
			{
			}
		}

		[Token(Token = "0x170000ED")]
		protected string Name
		{
			[Token(Token = "0x600071D")]
			[Address(RVA = "0x133D85C", Offset = "0x133D85C", VA = "0x133D85C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000EE")]
		protected string LogPrefix
		{
			[Token(Token = "0x600071E")]
			[Address(RVA = "0x133D7FC", Offset = "0x133D7FC", VA = "0x133D7FC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600071C")]
		[Address(RVA = "0x133D52C", Offset = "0x133D52C", VA = "0x133D52C")]
		internal RemoteVoice(VoiceClient client, RemoteVoiceOptions options, int channelId, int playerId, byte voiceId, VoiceInfo info, byte lastEventNumber)
		{
		}

		[Token(Token = "0x600071F")]
		[Address(RVA = "0x133DB10", Offset = "0x133DB10", VA = "0x133DB10")]
		private static byte byteDiff(byte latest, byte last)
		{
			return default(byte);
		}

		[Token(Token = "0x6000720")]
		[Address(RVA = "0x133DB20", Offset = "0x133DB20", VA = "0x133DB20")]
		internal void receiveBytes(byte[] receivedBytes, byte evNumber)
		{
		}

		[Token(Token = "0x6000721")]
		[Address(RVA = "0x133E1F0", Offset = "0x133E1F0", VA = "0x133E1F0")]
		private void receiveFrame(byte[] frame)
		{
		}

		[Token(Token = "0x6000722")]
		[Address(RVA = "0x133E020", Offset = "0x133E020", VA = "0x133E020")]
		private void receiveNullFrames(int count)
		{
		}

		[Token(Token = "0x6000723")]
		[Address(RVA = "0x133E3A0", Offset = "0x133E3A0", VA = "0x133E3A0")]
		private void decodeThread(IDecoder decoder)
		{
		}

		[Token(Token = "0x6000724")]
		[Address(RVA = "0x133EB78", Offset = "0x133EB78", VA = "0x133EB78")]
		private void decodeFrame(IDecoder decoder, byte[] frame)
		{
		}

		[Token(Token = "0x6000725")]
		[Address(RVA = "0x133ED7C", Offset = "0x133ED7C", VA = "0x133ED7C")]
		internal byte[] decodeFrameToByte(byte[] buffer)
		{
			return null;
		}

		[Token(Token = "0x6000726")]
		[Address(RVA = "0x133F024", Offset = "0x133F024", VA = "0x133F024")]
		internal short[] decodeFrameToShort(byte[] buffer)
		{
			return null;
		}

		[Token(Token = "0x6000727")]
		[Address(RVA = "0x133F2D4", Offset = "0x133F2D4", VA = "0x133F2D4")]
		internal float[] decodeFrameToFloat(byte[] buffer)
		{
			return null;
		}

		[Token(Token = "0x6000728")]
		[Address(RVA = "0x133F57C", Offset = "0x133F57C", VA = "0x133F57C")]
		internal void removeAndDispose()
		{
		}

		[Token(Token = "0x6000729")]
		[Address(RVA = "0x133F5B4", Offset = "0x133F5B4", VA = "0x133F5B4", Slot = "4")]
		public void Dispose()
		{
		}

		[Token(Token = "0x600072A")]
		[Address(RVA = "0x133F688", Offset = "0x133F688", VA = "0x133F688")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DF5B8", Offset = "0x9DF5B8")]
		private void <.ctor>b__10_0()
		{
		}
	}
	[Token(Token = "0x20000D4")]
	public interface IAudioSource : IDisposable
	{
		[Token(Token = "0x170000EF")]
		int SamplingRate
		{
			[Token(Token = "0x600072B")]
			get;
		}

		[Token(Token = "0x170000F0")]
		int Channels
		{
			[Token(Token = "0x600072C")]
			get;
		}
	}
	[Token(Token = "0x20000D5")]
	public interface IAudioReader<T> : IDataReader<T>, IDisposable, IAudioSource
	{
	}
	[Token(Token = "0x20000D6")]
	public interface IAudioPusher<T> : IAudioSource, IDisposable
	{
		[Token(Token = "0x600072D")]
		void SetCallback(Action<T[]> callback, LocalVoice localVoice);
	}
	[Token(Token = "0x20000D7")]
	public interface ILocalVoiceAudio
	{
		[Token(Token = "0x170000F1")]
		AudioUtil.IVoiceDetector VoiceDetector
		{
			[Token(Token = "0x600072E")]
			get;
		}

		[Token(Token = "0x170000F2")]
		AudioUtil.ILevelMeter LevelMeter
		{
			[Token(Token = "0x600072F")]
			get;
		}

		[Token(Token = "0x170000F3")]
		bool VoiceDetectorCalibrating
		{
			[Token(Token = "0x6000730")]
			get;
		}

		[Token(Token = "0x6000731")]
		void VoiceDetectorCalibrate(int durationMs);
	}
	[Token(Token = "0x20000D8")]
	public static class LocalVoiceAudio
	{
		[Token(Token = "0x4000603")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static LocalVoiceAudioDummy Dummy;

		[Token(Token = "0x6000732")]
		public static LocalVoiceAudio<T> Create<T>(VoiceClient voiceClient, byte voiceId, IEncoder encoder, VoiceInfo voiceInfo, int channelId)
		{
			return null;
		}
	}
	[Token(Token = "0x20000D9")]
	public abstract class LocalVoiceAudio<T> : LocalVoiceFramed<T>, ILocalVoiceAudio
	{
		[Token(Token = "0x4000604")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		protected AudioUtil.VoiceDetector<T> voiceDetector;

		[Token(Token = "0x4000605")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		protected AudioUtil.VoiceDetectorCalibration<T> voiceDetectorCalibration;

		[Token(Token = "0x4000606")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		protected AudioUtil.LevelMeter<T> levelMeter;

		[Token(Token = "0x4000607")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		protected int channels;

		[Token(Token = "0x4000608")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		protected int sourceSamplingRateHz;

		[Token(Token = "0x4000609")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		protected bool resampleSource;

		[Token(Token = "0x170000F4")]
		public virtual AudioUtil.IVoiceDetector VoiceDetector
		{
			[Token(Token = "0x6000734")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000F5")]
		public virtual AudioUtil.ILevelMeter LevelMeter
		{
			[Token(Token = "0x6000735")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000F6")]
		public bool VoiceDetectorCalibrating
		{
			[Token(Token = "0x6000737")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000736")]
		public void VoiceDetectorCalibrate(int durationMs)
		{
		}

		[Token(Token = "0x6000738")]
		internal LocalVoiceAudio(VoiceClient voiceClient, IEncoderDataFlow<T> encoder, byte id, VoiceInfo voiceInfo, int channelId)
		{
		}

		[Token(Token = "0x6000739")]
		protected void initBuiltinProcessors()
		{
		}
	}
	[Token(Token = "0x20000DA")]
	public class LocalVoiceAudioDummy : LocalVoice, ILocalVoiceAudio
	{
		[Token(Token = "0x400060A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private AudioUtil.VoiceDetectorDummy voiceDetector;

		[Token(Token = "0x400060B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private AudioUtil.LevelMetterDummy levelMeter;

		[Token(Token = "0x170000F7")]
		public AudioUtil.IVoiceDetector VoiceDetector
		{
			[Token(Token = "0x600073A")]
			[Address(RVA = "0x133C260", Offset = "0x133C260", VA = "0x133C260", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000F8")]
		public AudioUtil.ILevelMeter LevelMeter
		{
			[Token(Token = "0x600073B")]
			[Address(RVA = "0x133C268", Offset = "0x133C268", VA = "0x133C268", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000F9")]
		public bool VoiceDetectorCalibrating
		{
			[Token(Token = "0x600073C")]
			[Address(RVA = "0x133C270", Offset = "0x133C270", VA = "0x133C270", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600073D")]
		[Address(RVA = "0x133C278", Offset = "0x133C278", VA = "0x133C278", Slot = "10")]
		public void VoiceDetectorCalibrate(int durationMs)
		{
		}

		[Token(Token = "0x600073E")]
		[Address(RVA = "0x133C1D8", Offset = "0x133C1D8", VA = "0x133C1D8")]
		public LocalVoiceAudioDummy()
		{
		}
	}
	[Token(Token = "0x20000DB")]
	public class LocalVoiceAudioFloat : LocalVoiceAudio<float>
	{
		[Token(Token = "0x600073F")]
		[Address(RVA = "0x133C27C", Offset = "0x133C27C", VA = "0x133C27C")]
		internal LocalVoiceAudioFloat(VoiceClient voiceClient, IEncoderDataFlow<float> encoder, byte id, VoiceInfo voiceInfo, int channelId)
		{
		}
	}
	[Token(Token = "0x20000DC")]
	public class LocalVoiceAudioShort : LocalVoiceAudio<short>
	{
		[Token(Token = "0x6000740")]
		[Address(RVA = "0x133C3E8", Offset = "0x133C3E8", VA = "0x133C3E8")]
		internal LocalVoiceAudioShort(VoiceClient voiceClient, IEncoderDataFlow<short> encoder, byte id, VoiceInfo voiceInfo, int channelId)
		{
		}
	}
	[Token(Token = "0x20000DD")]
	internal enum EventSubcode : byte
	{
		[Token(Token = "0x400060D")]
		VoiceInfo = 1,
		[Token(Token = "0x400060E")]
		VoiceRemove,
		[Token(Token = "0x400060F")]
		Frame
	}
	[Token(Token = "0x20000DE")]
	internal enum EventParam : byte
	{
		[Token(Token = "0x4000611")]
		VoiceId = 1,
		[Token(Token = "0x4000612")]
		SamplingRate = 2,
		[Token(Token = "0x4000613")]
		Channels = 3,
		[Token(Token = "0x4000614")]
		FrameDurationUs = 4,
		[Token(Token = "0x4000615")]
		Bitrate = 5,
		[Token(Token = "0x4000616")]
		UserData = 10,
		[Token(Token = "0x4000617")]
		EventNumber = 11,
		[Token(Token = "0x4000618")]
		Codec = 12
	}
	[Token(Token = "0x20000DF")]
	public interface ILogger
	{
		[Token(Token = "0x6000741")]
		void LogError(string fmt, params object[] args);

		[Token(Token = "0x6000742")]
		void LogWarning(string fmt, params object[] args);

		[Token(Token = "0x6000743")]
		void LogInfo(string fmt, params object[] args);

		[Token(Token = "0x6000744")]
		void LogDebug(string fmt, params object[] args);
	}
	[Token(Token = "0x20000E0")]
	internal interface IVoiceFrontend : ILogger
	{
		[Token(Token = "0x6000745")]
		int AssignChannel(VoiceInfo v);

		[Token(Token = "0x6000746")]
		bool IsChannelJoined(int channelId);

		[Token(Token = "0x6000747")]
		void SendVoicesInfo(IEnumerable<LocalVoice> voices, int channelId, int targetPlayerId);

		[Token(Token = "0x6000748")]
		void SendVoiceRemove(LocalVoice voice, int channelId, int targetPlayerId);

		[Token(Token = "0x6000749")]
		void SendFrame(ArraySegment<byte> data, byte evNumber, byte voiceId, int channelId, LocalVoice localVoice);

		[Token(Token = "0x600074A")]
		string ChannelIdStr(int channelId);

		[Token(Token = "0x600074B")]
		string PlayerIdStr(int playerId);

		[Token(Token = "0x600074C")]
		void SetDebugEchoMode(LocalVoice v);
	}
	[Token(Token = "0x20000E1")]
	public class VoiceClient : IDisposable
	{
		[Token(Token = "0x20001A6")]
		public delegate void RemoteVoiceInfoDelegate(int channelId, int playerId, byte voiceId, VoiceInfo voiceInfo, ref RemoteVoiceOptions options);

		[Token(Token = "0x20001A7")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9D606C", Offset = "0x9D606C")]
		private sealed class <get_RemoteVoiceInfos>d__39 : IEnumerable<RemoteVoiceInfo>, IEnumerable, IEnumerator<RemoteVoiceInfo>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000A4C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000A4D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private RemoteVoiceInfo <>2__current;

			[Token(Token = "0x4000A4E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private int <>l__initialThreadId;

			[Token(Token = "0x4000A4F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public VoiceClient <>4__this;

			[Token(Token = "0x4000A50")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private Dictionary<int, Dictionary<int, Dictionary<byte, RemoteVoice>>>.Enumerator <>7__wrap1;

			[Token(Token = "0x4000A51")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private KeyValuePair<int, Dictionary<int, Dictionary<byte, RemoteVoice>>> <channelVoices>5__3;

			[Token(Token = "0x4000A52")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			private Dictionary<int, Dictionary<byte, RemoteVoice>>.Enumerator <>7__wrap3;

			[Token(Token = "0x4000A53")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			private KeyValuePair<int, Dictionary<byte, RemoteVoice>> <playerVoices>5__5;

			[Token(Token = "0x4000A54")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			private Dictionary<byte, RemoteVoice>.Enumerator <>7__wrap5;

			[Token(Token = "0x17000203")]
			private RemoteVoiceInfo System.Collections.Generic.IEnumerator<ExitGames.Client.Photon.Voice.RemoteVoiceInfo>.Current
			{
				[Token(Token = "0x6000BB3")]
				[Address(RVA = "0x1261574", Offset = "0x1261574", VA = "0x1261574", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000204")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000BB5")]
				[Address(RVA = "0x12615E4", Offset = "0x12615E4", VA = "0x12615E4", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000BAD")]
			[Address(RVA = "0x125A6D4", Offset = "0x125A6D4", VA = "0x125A6D4")]
			[DebuggerHidden]
			public <get_RemoteVoiceInfos>d__39(int <>1__state)
			{
			}

			[Token(Token = "0x6000BAE")]
			[Address(RVA = "0x1260F98", Offset = "0x1260F98", VA = "0x1260F98", Slot = "7")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000BAF")]
			[Address(RVA = "0x1261134", Offset = "0x1261134", VA = "0x1261134", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000BB0")]
			[Address(RVA = "0x12610DC", Offset = "0x12610DC", VA = "0x12610DC")]
			private void <>m__Finally1()
			{
			}

			[Token(Token = "0x6000BB1")]
			[Address(RVA = "0x1261084", Offset = "0x1261084", VA = "0x1261084")]
			private void <>m__Finally2()
			{
			}

			[Token(Token = "0x6000BB2")]
			[Address(RVA = "0x126102C", Offset = "0x126102C", VA = "0x126102C")]
			private void <>m__Finally3()
			{
			}

			[Token(Token = "0x6000BB4")]
			[Address(RVA = "0x126157C", Offset = "0x126157C", VA = "0x126157C", Slot = "10")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}

			[Token(Token = "0x6000BB6")]
			[Address(RVA = "0x12615EC", Offset = "0x12615EC", VA = "0x12615EC", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<RemoteVoiceInfo> System.Collections.Generic.IEnumerable<ExitGames.Client.Photon.Voice.RemoteVoiceInfo>.GetEnumerator()
			{
				return null;
			}

			[Token(Token = "0x6000BB7")]
			[Address(RVA = "0x126169C", Offset = "0x126169C", VA = "0x126169C", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator System.Collections.IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Token(Token = "0x20001A8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9D607C", Offset = "0x9D607C")]
		private sealed class <get_RemoteVoiceLocalUserObjects>d__41 : IEnumerable<object>, IEnumerable, IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000A55")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000A56")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000A57")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private int <>l__initialThreadId;

			[Token(Token = "0x4000A58")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public VoiceClient <>4__this;

			[Token(Token = "0x4000A59")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private Dictionary<int, Dictionary<int, Dictionary<byte, RemoteVoice>>>.Enumerator <>7__wrap1;

			[Token(Token = "0x4000A5A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private Dictionary<int, Dictionary<byte, RemoteVoice>>.Enumerator <>7__wrap2;

			[Token(Token = "0x4000A5B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			private Dictionary<byte, RemoteVoice>.Enumerator <>7__wrap3;

			[Token(Token = "0x17000205")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000BBE")]
				[Address(RVA = "0x1261B80", Offset = "0x1261B80", VA = "0x1261B80", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000206")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000BC0")]
				[Address(RVA = "0x1261BF0", Offset = "0x1261BF0", VA = "0x1261BF0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000BB8")]
			[Address(RVA = "0x125A790", Offset = "0x125A790", VA = "0x125A790")]
			[DebuggerHidden]
			public <get_RemoteVoiceLocalUserObjects>d__41(int <>1__state)
			{
			}

			[Token(Token = "0x6000BB9")]
			[Address(RVA = "0x12616A0", Offset = "0x12616A0", VA = "0x12616A0", Slot = "7")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000BBA")]
			[Address(RVA = "0x126183C", Offset = "0x126183C", VA = "0x126183C", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000BBB")]
			[Address(RVA = "0x12617E4", Offset = "0x12617E4", VA = "0x12617E4")]
			private void <>m__Finally1()
			{
			}

			[Token(Token = "0x6000BBC")]
			[Address(RVA = "0x126178C", Offset = "0x126178C", VA = "0x126178C")]
			private void <>m__Finally2()
			{
			}

			[Token(Token = "0x6000BBD")]
			[Address(RVA = "0x1261734", Offset = "0x1261734", VA = "0x1261734")]
			private void <>m__Finally3()
			{
			}

			[Token(Token = "0x6000BBF")]
			[Address(RVA = "0x1261B88", Offset = "0x1261B88", VA = "0x1261B88", Slot = "10")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}

			[Token(Token = "0x6000BC1")]
			[Address(RVA = "0x1261BF8", Offset = "0x1261BF8", VA = "0x1261BF8", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<object> System.Collections.Generic.IEnumerable<System.Object>.GetEnumerator()
			{
				return null;
			}

			[Token(Token = "0x6000BC2")]
			[Address(RVA = "0x1261CA8", Offset = "0x1261CA8", VA = "0x1261CA8", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator System.Collections.IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Token(Token = "0x20001A9")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9D608C", Offset = "0x9D608C")]
		private sealed class <>c__DisplayClass46_0
		{
			[Token(Token = "0x4000A5C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public VoiceClient <>4__this;

			[Token(Token = "0x4000A5D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public IEncoder encoder;

			[Token(Token = "0x4000A5E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public VoiceInfo voiceInfo;

			[Token(Token = "0x6000BC3")]
			[Address(RVA = "0x125B99C", Offset = "0x125B99C", VA = "0x125B99C")]
			public <>c__DisplayClass46_0()
			{
			}

			[Token(Token = "0x6000BC4")]
			[Address(RVA = "0x1260EE8", Offset = "0x1260EE8", VA = "0x1260EE8")]
			internal LocalVoice <CreateLocalVoice>b__0(byte vId, int chId)
			{
				return null;
			}
		}

		[Token(Token = "0x20001AA")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9D609C", Offset = "0x9D609C")]
		private sealed class <>c__DisplayClass47_0<T>
		{
			[Token(Token = "0x4000A5F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public VoiceClient <>4__this;

			[Token(Token = "0x4000A60")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public IEncoderDataFlow<T> encoder;

			[Token(Token = "0x4000A61")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public VoiceInfo voiceInfo;

			[Token(Token = "0x4000A62")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int frameSize;

			[Token(Token = "0x6000BC5")]
			public <>c__DisplayClass47_0()
			{
			}

			[Token(Token = "0x6000BC6")]
			internal LocalVoice <CreateLocalVoiceFramed>b__0(byte vId, int chId)
			{
				return null;
			}
		}

		[Token(Token = "0x20001AB")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9D60AC", Offset = "0x9D60AC")]
		private sealed class <>c__DisplayClass48_0<T>
		{
			[Token(Token = "0x4000A63")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public VoiceClient <>4__this;

			[Token(Token = "0x4000A64")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public IEncoderDataFlow<T> encoder;

			[Token(Token = "0x4000A65")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public VoiceInfo voiceInfo;

			[Token(Token = "0x6000BC7")]
			public <>c__DisplayClass48_0()
			{
			}

			[Token(Token = "0x6000BC8")]
			internal LocalVoice <CreateLocalVoiceAudio>b__0(byte vId, int chId)
			{
				return null;
			}
		}

		[Token(Token = "0x4000619")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		internal IVoiceFrontend frontend;

		[Token(Token = "0x400061A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DA3A4", Offset = "0x9DA3A4")]
		private int <FramesLost>k__BackingField;

		[Token(Token = "0x400061B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DA3B4", Offset = "0x9DA3B4")]
		private int <FramesReceived>k__BackingField;

		[Token(Token = "0x400061C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DA3C4", Offset = "0x9DA3C4")]
		private int <RoundTripTime>k__BackingField;

		[Token(Token = "0x400061D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DA3D4", Offset = "0x9DA3D4")]
		private int <RoundTripTimeVariance>k__BackingField;

		[Token(Token = "0x400061E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DA3E4", Offset = "0x9DA3E4")]
		private bool <SuppressInfoDuplicateWarning>k__BackingField;

		[Token(Token = "0x400061F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DA3F4", Offset = "0x9DA3F4")]
		private RemoteVoiceInfoDelegate <OnRemoteVoiceInfoAction>k__BackingField;

		[Token(Token = "0x4000620")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DA404", Offset = "0x9DA404")]
		private int <DebugLostPercent>k__BackingField;

		[Token(Token = "0x4000621")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private int prevRtt;

		[Token(Token = "0x4000622")]
		public const int ChannelAuto = -1;

		[Token(Token = "0x4000623")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private byte globalGroup;

		[Token(Token = "0x4000624")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x41")]
		private byte voiceIdCnt;

		[Token(Token = "0x4000625")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Dictionary<byte, LocalVoice> localVoices;

		[Token(Token = "0x4000626")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Dictionary<int, List<LocalVoice>> localVoicesPerChannel;

		[Token(Token = "0x4000627")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Dictionary<int, Dictionary<int, Dictionary<byte, RemoteVoice>>> remoteVoices;

		[Token(Token = "0x4000628")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private System.Random rnd;

		[Token(Token = "0x170000FA")]
		public int FramesLost
		{
			[Token(Token = "0x600074D")]
			[Address(RVA = "0x125A138", Offset = "0x125A138", VA = "0x125A138")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DF5C8", Offset = "0x9DF5C8")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600074E")]
			[Address(RVA = "0x125A140", Offset = "0x125A140", VA = "0x125A140")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DF5D8", Offset = "0x9DF5D8")]
			internal set
			{
			}
		}

		[Token(Token = "0x170000FB")]
		public int FramesReceived
		{
			[Token(Token = "0x600074F")]
			[Address(RVA = "0x125A148", Offset = "0x125A148", VA = "0x125A148")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DF5E8", Offset = "0x9DF5E8")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000750")]
			[Address(RVA = "0x125A150", Offset = "0x125A150", VA = "0x125A150")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DF5F8", Offset = "0x9DF5F8")]
			private set
			{
			}
		}

		[Token(Token = "0x170000FC")]
		public int FramesSent
		{
			[Token(Token = "0x6000751")]
			[Address(RVA = "0x125A158", Offset = "0x125A158", VA = "0x125A158")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170000FD")]
		public int FramesSentBytes
		{
			[Token(Token = "0x6000752")]
			[Address(RVA = "0x125A2BC", Offset = "0x125A2BC", VA = "0x125A2BC")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170000FE")]
		public int RoundTripTime
		{
			[Token(Token = "0x6000753")]
			[Address(RVA = "0x125A420", Offset = "0x125A420", VA = "0x125A420")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DF608", Offset = "0x9DF608")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000754")]
			[Address(RVA = "0x125A428", Offset = "0x125A428", VA = "0x125A428")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DF618", Offset = "0x9DF618")]
			private set
			{
			}
		}

		[Token(Token = "0x170000FF")]
		public int RoundTripTimeVariance
		{
			[Token(Token = "0x6000755")]
			[Address(RVA = "0x125A430", Offset = "0x125A430", VA = "0x125A430")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DF628", Offset = "0x9DF628")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000756")]
			[Address(RVA = "0x125A438", Offset = "0x125A438", VA = "0x125A438")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DF638", Offset = "0x9DF638")]
			private set
			{
			}
		}

		[Token(Token = "0x17000100")]
		public bool SuppressInfoDuplicateWarning
		{
			[Token(Token = "0x6000757")]
			[Address(RVA = "0x125A440", Offset = "0x125A440", VA = "0x125A440")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DF648", Offset = "0x9DF648")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000758")]
			[Address(RVA = "0x125A448", Offset = "0x125A448", VA = "0x125A448")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DF658", Offset = "0x9DF658")]
			set
			{
			}
		}

		[Token(Token = "0x17000101")]
		public RemoteVoiceInfoDelegate OnRemoteVoiceInfoAction
		{
			[Token(Token = "0x6000759")]
			[Address(RVA = "0x125A454", Offset = "0x125A454", VA = "0x125A454")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DF668", Offset = "0x9DF668")]
			get
			{
				return null;
			}
			[Token(Token = "0x600075A")]
			[Address(RVA = "0x125A45C", Offset = "0x125A45C", VA = "0x125A45C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DF678", Offset = "0x9DF678")]
			set
			{
			}
		}

		[Token(Token = "0x17000102")]
		public int DebugLostPercent
		{
			[Token(Token = "0x600075B")]
			[Address(RVA = "0x125A464", Offset = "0x125A464", VA = "0x125A464")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DF688", Offset = "0x9DF688")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600075C")]
			[Address(RVA = "0x125A46C", Offset = "0x125A46C", VA = "0x125A46C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DF698", Offset = "0x9DF698")]
			set
			{
			}
		}

		[Token(Token = "0x17000103")]
		public IEnumerable<LocalVoice> LocalVoices
		{
			[Token(Token = "0x600075D")]
			[Address(RVA = "0x125A474", Offset = "0x125A474", VA = "0x125A474")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000104")]
		public IEnumerable<RemoteVoiceInfo> RemoteVoiceInfos
		{
			[Token(Token = "0x600075F")]
			[Address(RVA = "0x125A650", Offset = "0x125A650", VA = "0x125A650")]
			[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9DF6A8", Offset = "0x9DF6A8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000105")]
		public IEnumerable<object> RemoteVoiceLocalUserObjects
		{
			[Token(Token = "0x6000760")]
			[Address(RVA = "0x125A70C", Offset = "0x125A70C", VA = "0x125A70C")]
			[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9DF70C", Offset = "0x9DF70C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000106")]
		internal byte GlobalGroup
		{
			[Token(Token = "0x600076D")]
			[Address(RVA = "0x125B9A4", Offset = "0x125B9A4", VA = "0x125B9A4")]
			get
			{
				return default(byte);
			}
			[Token(Token = "0x600076E")]
			[Address(RVA = "0x125E564", Offset = "0x125E564", VA = "0x125E564")]
			set
			{
			}
		}

		[Token(Token = "0x600075E")]
		[Address(RVA = "0x125A544", Offset = "0x125A544", VA = "0x125A544")]
		public IEnumerable<LocalVoice> LocalVoicesInChannel(int channelId)
		{
			return null;
		}

		[Token(Token = "0x6000761")]
		[Address(RVA = "0x125A7C8", Offset = "0x125A7C8", VA = "0x125A7C8")]
		internal VoiceClient(IVoiceFrontend frontend)
		{
		}

		[Token(Token = "0x6000762")]
		[Address(RVA = "0x125A8BC", Offset = "0x125A8BC", VA = "0x125A8BC")]
		public void Service()
		{
		}

		[Token(Token = "0x6000763")]
		[Address(RVA = "0x125AA10", Offset = "0x125AA10", VA = "0x125AA10")]
		private LocalVoice createLocalVoice(VoiceInfo voiceInfo, int channelId, Func<byte, int, LocalVoice> voiceFactory)
		{
			return null;
		}

		[Token(Token = "0x6000764")]
		[Address(RVA = "0x125B818", Offset = "0x125B818", VA = "0x125B818")]
		public LocalVoice CreateLocalVoice(VoiceInfo voiceInfo, int channelId = -1, [Optional] IEncoder encoder)
		{
			return null;
		}

		[Token(Token = "0x6000765")]
		public LocalVoiceFramed<T> CreateLocalVoiceFramed<T>(VoiceInfo voiceInfo, int frameSize, int channelId = -1, [Optional] IEncoderDataFlow<T> encoder)
		{
			return null;
		}

		[Token(Token = "0x6000766")]
		public LocalVoiceAudio<T> CreateLocalVoiceAudio<T>(VoiceInfo voiceInfo, int channelId = -1, [Optional] IEncoderDataFlow<T> encoder)
		{
			return null;
		}

		[Token(Token = "0x6000767")]
		[Address(RVA = "0x125AC70", Offset = "0x125AC70", VA = "0x125AC70")]
		private byte getNewVoiceId()
		{
			return default(byte);
		}

		[Token(Token = "0x6000768")]
		[Address(RVA = "0x125AE7C", Offset = "0x125AE7C", VA = "0x125AE7C")]
		private void addVoice(byte newId, int channelId, LocalVoice v)
		{
		}

		[Token(Token = "0x6000769")]
		[Address(RVA = "0x125B9AC", Offset = "0x125B9AC", VA = "0x125B9AC")]
		public void RemoveLocalVoice(LocalVoice voice)
		{
		}

		[Token(Token = "0x600076A")]
		[Address(RVA = "0x125BC84", Offset = "0x125BC84", VA = "0x125BC84")]
		internal void sendVoicesInfo(int targetPlayerId)
		{
		}

		[Token(Token = "0x600076B")]
		[Address(RVA = "0x125BDC0", Offset = "0x125BDC0", VA = "0x125BDC0")]
		internal void sendChannelVoicesInfo(int channelId, int targetPlayerId)
		{
		}

		[Token(Token = "0x600076C")]
		[Address(RVA = "0x125BF54", Offset = "0x125BF54", VA = "0x125BF54")]
		internal void onVoiceEvent(object content0, int channelId, int playerId, int localPlayerId)
		{
		}

		[Token(Token = "0x600076F")]
		[Address(RVA = "0x125E6CC", Offset = "0x125E6CC", VA = "0x125E6CC")]
		internal object[] buildVoicesInfo(IEnumerable<LocalVoice> voicesToSend, bool logInfo)
		{
			return null;
		}

		[Token(Token = "0x6000770")]
		[Address(RVA = "0x125F0AC", Offset = "0x125F0AC", VA = "0x125F0AC")]
		internal object[] buildVoiceRemoveMessage(LocalVoice v)
		{
			return null;
		}

		[Token(Token = "0x6000771")]
		[Address(RVA = "0x125F34C", Offset = "0x125F34C", VA = "0x125F34C")]
		internal void clearRemoteVoices()
		{
		}

		[Token(Token = "0x6000772")]
		[Address(RVA = "0x125F7CC", Offset = "0x125F7CC", VA = "0x125F7CC")]
		internal void clearRemoteVoicesInChannel(int channelId)
		{
		}

		[Token(Token = "0x6000773")]
		[Address(RVA = "0x125C400", Offset = "0x125C400", VA = "0x125C400")]
		private void onVoiceInfo(int channelId, int playerId, object payload)
		{
		}

		[Token(Token = "0x6000774")]
		[Address(RVA = "0x125D000", Offset = "0x125D000", VA = "0x125D000")]
		private void onVoiceRemove(int channelId, int playerId, object payload)
		{
		}

		[Token(Token = "0x6000775")]
		[Address(RVA = "0x125DB98", Offset = "0x125DB98", VA = "0x125DB98")]
		private void onFrame(int channelId, int playerId, byte voiceId, byte evNumber, byte[] receivedBytes)
		{
		}

		[Token(Token = "0x6000776")]
		[Address(RVA = "0x12606EC", Offset = "0x12606EC", VA = "0x12606EC")]
		internal bool removePlayerVoices(int playerId)
		{
			return default(bool);
		}

		[Token(Token = "0x6000777")]
		[Address(RVA = "0x126082C", Offset = "0x126082C", VA = "0x126082C")]
		internal bool removePlayerVoices(int channelId, int playerId)
		{
			return default(bool);
		}

		[Token(Token = "0x6000778")]
		[Address(RVA = "0x125FBA0", Offset = "0x125FBA0", VA = "0x125FBA0")]
		internal string channelStr(int channelId)
		{
			return null;
		}

		[Token(Token = "0x6000779")]
		[Address(RVA = "0x126004C", Offset = "0x126004C", VA = "0x126004C")]
		internal string playerStr(int playerId)
		{
			return null;
		}

		[Token(Token = "0x600077A")]
		[Address(RVA = "0x1260A24", Offset = "0x1260A24", VA = "0x1260A24", Slot = "4")]
		public void Dispose()
		{
		}
	}
	[Token(Token = "0x20000E2")]
	public interface IEncoder : IDisposable
	{
	}
	[Token(Token = "0x20000E3")]
	public interface IEncoderDataFlow<T> : IEncoder, IDisposable
	{
	}
	[Token(Token = "0x20000E4")]
	public interface IEncoderDataFlowDirect<T> : IEncoderDataFlow<T>, IEncoder, IDisposable
	{
		[Token(Token = "0x600077B")]
		ArraySegment<byte> EncodeAndGetOutput(T[] buf);
	}
	[Token(Token = "0x20000E5")]
	public interface IEncoderNativeImageDirect : IEncoder, IDisposable
	{
		[Token(Token = "0x600077C")]
		IEnumerable<ArraySegment<byte>> EncodeAndGetOutput(IntPtr[] buf, int width, int height, int[] stride, ImageFormat imageFormat, Rotation rotation, Flip flip);
	}
	[Token(Token = "0x20000E6")]
	public interface IEncoderQueued : IEncoder, IDisposable
	{
		[Token(Token = "0x600077D")]
		IEnumerable<ArraySegment<byte>> GetOutput();
	}
	[Token(Token = "0x20000E7")]
	public interface IDecoder : IDisposable
	{
		[Token(Token = "0x600077E")]
		void Open(VoiceInfo info);
	}
	[Token(Token = "0x20000E8")]
	public interface IDecoderDirect : IDecoder, IDisposable
	{
		[Token(Token = "0x600077F")]
		byte[] DecodeToByte(byte[] buf);

		[Token(Token = "0x6000780")]
		float[] DecodeToFloat(byte[] buf);

		[Token(Token = "0x6000781")]
		short[] DecodeToShort(byte[] buf);
	}
	[Token(Token = "0x20000E9")]
	public interface IDecoderQueued : IDecoder, IDisposable
	{
		[Token(Token = "0x6000782")]
		void Decode(byte[] buf);
	}
	[Token(Token = "0x20000EA")]
	public delegate void OnImageOutputNative(IntPtr buf, int width, int height, int stride);
	[Token(Token = "0x20000EB")]
	public interface IDecoderQueuedOutputImageNative : IDecoderQueued, IDecoder, IDisposable
	{
		[Token(Token = "0x17000107")]
		ImageFormat OutputImageFormat
		{
			[Token(Token = "0x6000787")]
			get;
			[Token(Token = "0x6000788")]
			set;
		}

		[Token(Token = "0x17000108")]
		Flip OutputImageFlip
		{
			[Token(Token = "0x6000789")]
			get;
			[Token(Token = "0x600078A")]
			set;
		}

		[Token(Token = "0x17000109")]
		Func<int, int, IntPtr> OutputImageBufferGetter
		{
			[Token(Token = "0x600078B")]
			get;
			[Token(Token = "0x600078C")]
			set;
		}

		[Token(Token = "0x1700010A")]
		OnImageOutputNative OnOutputImage
		{
			[Token(Token = "0x600078D")]
			get;
			[Token(Token = "0x600078E")]
			set;
		}
	}
	[Token(Token = "0x20000EC")]
	internal class UnsupportedSampleTypeException : Exception
	{
		[Token(Token = "0x600078F")]
		[Address(RVA = "0x125A0A0", Offset = "0x125A0A0", VA = "0x125A0A0")]
		public UnsupportedSampleTypeException(Type t)
		{
		}
	}
	[Token(Token = "0x20000ED")]
	internal class UnsupportedCodecException : Exception
	{
		[Token(Token = "0x6000790")]
		[Address(RVA = "0x1259E78", Offset = "0x1259E78", VA = "0x1259E78")]
		public UnsupportedCodecException(Codec codec, LocalVoice voice)
		{
		}
	}
	[Token(Token = "0x20000EE")]
	public enum Codec
	{
		[Token(Token = "0x400062A")]
		AudioOpus = 11
	}
	[Token(Token = "0x20000EF")]
	public enum ImageFormat
	{
		[Token(Token = "0x400062C")]
		I420,
		[Token(Token = "0x400062D")]
		YV12,
		[Token(Token = "0x400062E")]
		Android420,
		[Token(Token = "0x400062F")]
		RGBA,
		[Token(Token = "0x4000630")]
		ABGR,
		[Token(Token = "0x4000631")]
		BGRA,
		[Token(Token = "0x4000632")]
		ARGB
	}
	[Token(Token = "0x20000F0")]
	public enum Rotation
	{
		[Token(Token = "0x4000634")]
		Rotate0 = 0,
		[Token(Token = "0x4000635")]
		Rotate90 = 90,
		[Token(Token = "0x4000636")]
		Rotate180 = 180,
		[Token(Token = "0x4000637")]
		Rotate270 = 270
	}
	[Token(Token = "0x20000F1")]
	public enum Flip
	{
		[Token(Token = "0x4000639")]
		None,
		[Token(Token = "0x400063A")]
		Vertical,
		[Token(Token = "0x400063B")]
		Horizontal
	}
	[Token(Token = "0x20000F2")]
	public class ImageBufferInfo
	{
		[Token(Token = "0x400063C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DA414", Offset = "0x9DA414")]
		private int <Width>k__BackingField;

		[Token(Token = "0x400063D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DA424", Offset = "0x9DA424")]
		private int <Height>k__BackingField;

		[Token(Token = "0x400063E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DA434", Offset = "0x9DA434")]
		private int[] <Stride>k__BackingField;

		[Token(Token = "0x400063F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DA444", Offset = "0x9DA444")]
		private ImageFormat <Format>k__BackingField;

		[Token(Token = "0x4000640")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DA454", Offset = "0x9DA454")]
		private Rotation <Rotation>k__BackingField;

		[Token(Token = "0x4000641")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DA464", Offset = "0x9DA464")]
		private Flip <Flip>k__BackingField;

		[Token(Token = "0x1700010B")]
		public int Width
		{
			[Token(Token = "0x6000791")]
			[Address(RVA = "0x1339910", Offset = "0x1339910", VA = "0x1339910")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DF770", Offset = "0x9DF770")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000792")]
			[Address(RVA = "0x1339918", Offset = "0x1339918", VA = "0x1339918")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DF780", Offset = "0x9DF780")]
			private set
			{
			}
		}

		[Token(Token = "0x1700010C")]
		public int Height
		{
			[Token(Token = "0x6000793")]
			[Address(RVA = "0x1339920", Offset = "0x1339920", VA = "0x1339920")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DF790", Offset = "0x9DF790")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000794")]
			[Address(RVA = "0x1339928", Offset = "0x1339928", VA = "0x1339928")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DF7A0", Offset = "0x9DF7A0")]
			private set
			{
			}
		}

		[Token(Token = "0x1700010D")]
		public int[] Stride
		{
			[Token(Token = "0x6000795")]
			[Address(RVA = "0x1339930", Offset = "0x1339930", VA = "0x1339930")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DF7B0", Offset = "0x9DF7B0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000796")]
			[Address(RVA = "0x1339938", Offset = "0x1339938", VA = "0x1339938")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DF7C0", Offset = "0x9DF7C0")]
			private set
			{
			}
		}

		[Token(Token = "0x1700010E")]
		public ImageFormat Format
		{
			[Token(Token = "0x6000797")]
			[Address(RVA = "0x1339940", Offset = "0x1339940", VA = "0x1339940")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DF7D0", Offset = "0x9DF7D0")]
			get
			{
				return default(ImageFormat);
			}
			[Token(Token = "0x6000798")]
			[Address(RVA = "0x1339948", Offset = "0x1339948", VA = "0x1339948")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DF7E0", Offset = "0x9DF7E0")]
			private set
			{
			}
		}

		[Token(Token = "0x1700010F")]
		public Rotation Rotation
		{
			[Token(Token = "0x6000799")]
			[Address(RVA = "0x1339950", Offset = "0x1339950", VA = "0x1339950")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DF7F0", Offset = "0x9DF7F0")]
			get
			{
				return default(Rotation);
			}
			[Token(Token = "0x600079A")]
			[Address(RVA = "0x1339958", Offset = "0x1339958", VA = "0x1339958")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DF800", Offset = "0x9DF800")]
			set
			{
			}
		}

		[Token(Token = "0x17000110")]
		public Flip Flip
		{
			[Token(Token = "0x600079B")]
			[Address(RVA = "0x1339960", Offset = "0x1339960", VA = "0x1339960")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DF810", Offset = "0x9DF810")]
			get
			{
				return default(Flip);
			}
			[Token(Token = "0x600079C")]
			[Address(RVA = "0x1339968", Offset = "0x1339968", VA = "0x1339968")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DF820", Offset = "0x9DF820")]
			set
			{
			}
		}

		[Token(Token = "0x600079D")]
		[Address(RVA = "0x1339970", Offset = "0x1339970", VA = "0x1339970")]
		public ImageBufferInfo(int width, int height, int[] stride, ImageFormat format)
		{
		}
	}
	[Token(Token = "0x20000F3")]
	public class ImageBufferNative
	{
		[Token(Token = "0x4000642")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DA474", Offset = "0x9DA474")]
		private ImageBufferInfo <Info>k__BackingField;

		[Token(Token = "0x4000643")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DA484", Offset = "0x9DA484")]
		private IntPtr[] <Planes>k__BackingField;

		[Token(Token = "0x17000111")]
		public ImageBufferInfo Info
		{
			[Token(Token = "0x600079F")]
			[Address(RVA = "0x13399F4", Offset = "0x13399F4", VA = "0x13399F4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DF830", Offset = "0x9DF830")]
			get
			{
				return null;
			}
			[Token(Token = "0x60007A0")]
			[Address(RVA = "0x13399EC", Offset = "0x13399EC", VA = "0x13399EC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DF840", Offset = "0x9DF840")]
			protected set
			{
			}
		}

		[Token(Token = "0x17000112")]
		public IntPtr[] Planes
		{
			[Token(Token = "0x60007A1")]
			[Address(RVA = "0x13399FC", Offset = "0x13399FC", VA = "0x13399FC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DF850", Offset = "0x9DF850")]
			get
			{
				return null;
			}
			[Token(Token = "0x60007A2")]
			[Address(RVA = "0x1339A04", Offset = "0x1339A04", VA = "0x1339A04")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DF860", Offset = "0x9DF860")]
			protected set
			{
			}
		}

		[Token(Token = "0x600079E")]
		[Address(RVA = "0x13399C0", Offset = "0x13399C0", VA = "0x13399C0")]
		public ImageBufferNative(ImageBufferInfo info)
		{
		}

		[Token(Token = "0x60007A3")]
		[Address(RVA = "0x1339A0C", Offset = "0x1339A0C", VA = "0x1339A0C", Slot = "4")]
		public virtual void Release()
		{
		}

		[Token(Token = "0x60007A4")]
		[Address(RVA = "0x1339A10", Offset = "0x1339A10", VA = "0x1339A10", Slot = "5")]
		public virtual void Dispose()
		{
		}
	}
	[Token(Token = "0x20000F4")]
	public class ImageBufferNativeAlloc : ImageBufferNative, IDisposable
	{
		[Token(Token = "0x4000644")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private ImageBufferNativePool<ImageBufferNativeAlloc> pool;

		[Token(Token = "0x60007A5")]
		[Address(RVA = "0x1339A14", Offset = "0x1339A14", VA = "0x1339A14")]
		public ImageBufferNativeAlloc(ImageBufferNativePool<ImageBufferNativeAlloc> pool, ImageBufferInfo info)
		{
		}

		[Token(Token = "0x60007A6")]
		[Address(RVA = "0x1339B84", Offset = "0x1339B84", VA = "0x1339B84", Slot = "4")]
		public override void Release()
		{
		}

		[Token(Token = "0x60007A7")]
		[Address(RVA = "0x1339BA4", Offset = "0x1339BA4", VA = "0x1339BA4", Slot = "5")]
		public override void Dispose()
		{
		}
	}
	[Token(Token = "0x20000F5")]
	public class ImageBufferNativeGCHandleSinglePlane : ImageBufferNative, IDisposable
	{
		[Token(Token = "0x4000645")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private ImageBufferNativePool<ImageBufferNativeGCHandleSinglePlane> pool;

		[Token(Token = "0x4000646")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private GCHandle planeHandle;

		[Token(Token = "0x60007A8")]
		[Address(RVA = "0x1339C90", Offset = "0x1339C90", VA = "0x1339C90")]
		public ImageBufferNativeGCHandleSinglePlane(ImageBufferNativePool<ImageBufferNativeGCHandleSinglePlane> pool, ImageBufferInfo info)
		{
		}

		[Token(Token = "0x60007A9")]
		[Address(RVA = "0x1339DD4", Offset = "0x1339DD4", VA = "0x1339DD4")]
		public void PinPlane(byte[] plane)
		{
		}

		[Token(Token = "0x60007AA")]
		[Address(RVA = "0x1339E44", Offset = "0x1339E44", VA = "0x1339E44", Slot = "4")]
		public override void Release()
		{
		}

		[Token(Token = "0x60007AB")]
		[Address(RVA = "0x1339E8C", Offset = "0x1339E8C", VA = "0x1339E8C", Slot = "5")]
		public override void Dispose()
		{
		}
	}
	[Token(Token = "0x20000F6")]
	internal static class VoiceCodec
	{
		[Token(Token = "0x60007AC")]
		[Address(RVA = "0x1261DF0", Offset = "0x1261DF0", VA = "0x1261DF0")]
		internal static IEncoder CreateDefaultEncoder(VoiceInfo info, LocalVoice localVoice)
		{
			return null;
		}

		[Token(Token = "0x60007AD")]
		[Address(RVA = "0x12602B0", Offset = "0x12602B0", VA = "0x12602B0")]
		internal static IDecoder CreateDefaultDecoder(int channelId, int playerId, byte voiceId, VoiceInfo info)
		{
			return null;
		}
	}
	[Token(Token = "0x20000F7")]
	public class Framer<T>
	{
		[Token(Token = "0x20001AC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9D60BC", Offset = "0x9D60BC")]
		private sealed class <Frame>d__5 : IEnumerable<T[]>, IEnumerable, IEnumerator<T[]>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000A66")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private int <>1__state;

			[Token(Token = "0x4000A67")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private T[] <>2__current;

			[Token(Token = "0x4000A68")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private int <>l__initialThreadId;

			[Token(Token = "0x4000A69")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Framer<T> <>4__this;

			[Token(Token = "0x4000A6A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private T[] buf;

			[Token(Token = "0x4000A6B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public T[] <>3__buf;

			[Token(Token = "0x4000A6C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private int <s>5__2;

			[Token(Token = "0x4000A6D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private int <bufPos>5__3;

			[Token(Token = "0x17000207")]
			private T[] System.Collections.Generic.IEnumerator<T[]>.Current
			{
				[Token(Token = "0x6000BCC")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000208")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000BCE")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000BC9")]
			[DebuggerHidden]
			public <Frame>d__5(int <>1__state)
			{
			}

			[Token(Token = "0x6000BCA")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000BCB")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000BCD")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}

			[Token(Token = "0x6000BCF")]
			[DebuggerHidden]
			private IEnumerator<T[]> System.Collections.Generic.IEnumerable<T[]>.GetEnumerator()
			{
				return null;
			}

			[Token(Token = "0x6000BD0")]
			[DebuggerHidden]
			private IEnumerator System.Collections.IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Token(Token = "0x4000647")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private T[] frame;

		[Token(Token = "0x4000648")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int sizeofT;

		[Token(Token = "0x4000649")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int framePos;

		[Token(Token = "0x60007AE")]
		public Framer(int frameSize)
		{
		}

		[Token(Token = "0x60007AF")]
		public int Count(int bufLen)
		{
			return default(int);
		}

		[Token(Token = "0x60007B0")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9DF870", Offset = "0x9DF870")]
		public IEnumerable<T[]> Frame(T[] buf)
		{
			return null;
		}
	}
	[Token(Token = "0x20000F8")]
	public class LocalVoiceFramed : LocalVoice
	{
		[Token(Token = "0x400064A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DA494", Offset = "0x9DA494")]
		private int <FrameSize>k__BackingField;

		[Token(Token = "0x17000113")]
		public int FrameSize
		{
			[Token(Token = "0x60007B1")]
			[Address(RVA = "0x1329624", Offset = "0x1329624", VA = "0x1329624")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DF8D4", Offset = "0x9DF8D4")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60007B2")]
			[Address(RVA = "0x133C554", Offset = "0x133C554", VA = "0x133C554")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DF8E4", Offset = "0x9DF8E4")]
			private set
			{
			}
		}

		[Token(Token = "0x60007B3")]
		[Address(RVA = "0x133C55C", Offset = "0x133C55C", VA = "0x133C55C")]
		internal LocalVoiceFramed(VoiceClient voiceClient, IEncoder encoder, byte id, VoiceInfo voiceInfo, int channelId, int frameSize)
		{
		}
	}
	[Token(Token = "0x20000F9")]
	public class LocalVoiceFramed<T> : LocalVoiceFramed
	{
		[Token(Token = "0x20001AD")]
		public interface IProcessor : IDisposable
		{
			[Token(Token = "0x6000BD1")]
			T[] Process(T[] buf);
		}

		[Token(Token = "0x400064B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Framer<T> framer;

		[Token(Token = "0x400064C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int preProcessorsCnt;

		[Token(Token = "0x400064D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private List<IProcessor> processors;

		[Token(Token = "0x400064E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private bool dataEncodeThreadStarted;

		[Token(Token = "0x400064F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Queue<T[]> pushDataQueue;

		[Token(Token = "0x4000650")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private AutoResetEvent pushDataQueueReady;

		[Token(Token = "0x4000651")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private PrimitiveArrayPool<T> pushDataBufferPool;

		[Token(Token = "0x4000652")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int framesSkipped;

		[Token(Token = "0x4000653")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private bool exitThread;

		[Token(Token = "0x17000114")]
		public PrimitiveArrayPool<T> PushDataBufferPool
		{
			[Token(Token = "0x60007B9")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000115")]
		public bool PushDataAsyncReady
		{
			[Token(Token = "0x60007BA")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60007B4")]
		internal T[] processFrame(T[] buf)
		{
			return null;
		}

		[Token(Token = "0x60007B5")]
		public void AddPostProcessor(params IProcessor[] processors)
		{
		}

		[Token(Token = "0x60007B6")]
		public void AddPreProcessor(params IProcessor[] processors)
		{
		}

		[Token(Token = "0x60007B7")]
		public void ClearProcessors()
		{
		}

		[Token(Token = "0x60007B8")]
		internal LocalVoiceFramed(VoiceClient voiceClient, IEncoder encoder, byte id, VoiceInfo voiceInfo, int channelId, int frameSize)
		{
		}

		[Token(Token = "0x60007BB")]
		public void PushDataAsync(T[] buf)
		{
		}

		[Token(Token = "0x60007BC")]
		private void PushDataAsyncThread()
		{
		}

		[Token(Token = "0x60007BD")]
		public void PushData(T[] buf)
		{
		}

		[Token(Token = "0x60007BE")]
		public override void Dispose()
		{
		}
	}
	[Token(Token = "0x20000FA")]
	public struct VoiceInfo
	{
		[Token(Token = "0x4000654")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DA4A4", Offset = "0x9DA4A4")]
		private Codec <Codec>k__BackingField;

		[Token(Token = "0x4000655")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DA4B4", Offset = "0x9DA4B4")]
		private int <SamplingRate>k__BackingField;

		[Token(Token = "0x4000656")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DA4C4", Offset = "0x9DA4C4")]
		private int <SourceSamplingRate>k__BackingField;

		[Token(Token = "0x4000657")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DA4D4", Offset = "0x9DA4D4")]
		private int <Channels>k__BackingField;

		[Token(Token = "0x4000658")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DA4E4", Offset = "0x9DA4E4")]
		private int <FrameDurationUs>k__BackingField;

		[Token(Token = "0x4000659")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DA4F4", Offset = "0x9DA4F4")]
		private int <Bitrate>k__BackingField;

		[Token(Token = "0x400065A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DA504", Offset = "0x9DA504")]
		private object <UserData>k__BackingField;

		[Token(Token = "0x400065B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DA514", Offset = "0x9DA514")]
		private int <Width>k__BackingField;

		[Token(Token = "0x400065C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DA524", Offset = "0x9DA524")]
		private int <Height>k__BackingField;

		[Token(Token = "0x17000116")]
		public Codec Codec
		{
			[Token(Token = "0x60007C2")]
			[Address(RVA = "0xA97A94", Offset = "0xA97A94", VA = "0xA97A94")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DF8F4", Offset = "0x9DF8F4")]
			get
			{
				return default(Codec);
			}
			[Token(Token = "0x60007C3")]
			[Address(RVA = "0xA97A9C", Offset = "0xA97A9C", VA = "0xA97A9C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DF904", Offset = "0x9DF904")]
			set
			{
			}
		}

		[Token(Token = "0x17000117")]
		public int SamplingRate
		{
			[Token(Token = "0x60007C4")]
			[Address(RVA = "0xA97AA4", Offset = "0xA97AA4", VA = "0xA97AA4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DF914", Offset = "0x9DF914")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60007C5")]
			[Address(RVA = "0xA97AAC", Offset = "0xA97AAC", VA = "0xA97AAC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DF924", Offset = "0x9DF924")]
			set
			{
			}
		}

		[Token(Token = "0x17000118")]
		public int SourceSamplingRate
		{
			[Token(Token = "0x60007C6")]
			[Address(RVA = "0xA97AB4", Offset = "0xA97AB4", VA = "0xA97AB4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DF934", Offset = "0x9DF934")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60007C7")]
			[Address(RVA = "0xA97ABC", Offset = "0xA97ABC", VA = "0xA97ABC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DF944", Offset = "0x9DF944")]
			set
			{
			}
		}

		[Token(Token = "0x17000119")]
		public int Channels
		{
			[Token(Token = "0x60007C8")]
			[Address(RVA = "0xA97AC4", Offset = "0xA97AC4", VA = "0xA97AC4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DF954", Offset = "0x9DF954")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60007C9")]
			[Address(RVA = "0xA97ACC", Offset = "0xA97ACC", VA = "0xA97ACC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DF964", Offset = "0x9DF964")]
			set
			{
			}
		}

		[Token(Token = "0x1700011A")]
		public int FrameDurationUs
		{
			[Token(Token = "0x60007CA")]
			[Address(RVA = "0xA97AD4", Offset = "0xA97AD4", VA = "0xA97AD4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DF974", Offset = "0x9DF974")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60007CB")]
			[Address(RVA = "0xA97ADC", Offset = "0xA97ADC", VA = "0xA97ADC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DF984", Offset = "0x9DF984")]
			set
			{
			}
		}

		[Token(Token = "0x1700011B")]
		public int Bitrate
		{
			[Token(Token = "0x60007CC")]
			[Address(RVA = "0xA97AE4", Offset = "0xA97AE4", VA = "0xA97AE4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DF994", Offset = "0x9DF994")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60007CD")]
			[Address(RVA = "0xA97AEC", Offset = "0xA97AEC", VA = "0xA97AEC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DF9A4", Offset = "0x9DF9A4")]
			set
			{
			}
		}

		[Token(Token = "0x1700011C")]
		public object UserData
		{
			[Token(Token = "0x60007CE")]
			[Address(RVA = "0xA97AF4", Offset = "0xA97AF4", VA = "0xA97AF4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DF9B4", Offset = "0x9DF9B4")]
			get
			{
				return null;
			}
			[Token(Token = "0x60007CF")]
			[Address(RVA = "0xA97AFC", Offset = "0xA97AFC", VA = "0xA97AFC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DF9C4", Offset = "0x9DF9C4")]
			set
			{
			}
		}

		[Token(Token = "0x1700011D")]
		public int FrameDurationSamples
		{
			[Token(Token = "0x60007D0")]
			[Address(RVA = "0xA97B04", Offset = "0xA97B04", VA = "0xA97B04")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700011E")]
		public int FrameSize
		{
			[Token(Token = "0x60007D1")]
			[Address(RVA = "0xA97B34", Offset = "0xA97B34", VA = "0xA97B34")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700011F")]
		public int Width
		{
			[Token(Token = "0x60007D2")]
			[Address(RVA = "0xA97B6C", Offset = "0xA97B6C", VA = "0xA97B6C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DF9D4", Offset = "0x9DF9D4")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60007D3")]
			[Address(RVA = "0xA97B74", Offset = "0xA97B74", VA = "0xA97B74")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DF9E4", Offset = "0x9DF9E4")]
			set
			{
			}
		}

		[Token(Token = "0x17000120")]
		public int Height
		{
			[Token(Token = "0x60007D4")]
			[Address(RVA = "0xA97B7C", Offset = "0xA97B7C", VA = "0xA97B7C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DF9F4", Offset = "0x9DF9F4")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60007D5")]
			[Address(RVA = "0xA97B84", Offset = "0xA97B84", VA = "0xA97B84")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DFA04", Offset = "0x9DFA04")]
			set
			{
			}
		}

		[Token(Token = "0x60007BF")]
		[Address(RVA = "0x1261EF8", Offset = "0x1261EF8", VA = "0x1261EF8")]
		public static VoiceInfo CreateAudioOpus(SamplingRate samplingRate, int sourceSamplingRate, int channels, OpusCodec.FrameDuration frameDurationUs, int bitrate, [Optional] object userdata)
		{
			return default(VoiceInfo);
		}

		[Token(Token = "0x60007C0")]
		[Address(RVA = "0xA97A8C", Offset = "0xA97A8C", VA = "0xA97A8C", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x60007C1")]
		[Address(RVA = "0x125FE04", Offset = "0x125FE04", VA = "0x125FE04")]
		internal static VoiceInfo CreateFromEventPayload(Dictionary<byte, object> h)
		{
			return default(VoiceInfo);
		}
	}
	[Token(Token = "0x20000FB")]
	public class RemoteVoiceInfo
	{
		[Token(Token = "0x400065D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DA534", Offset = "0x9DA534")]
		private VoiceInfo <Info>k__BackingField;

		[Token(Token = "0x400065E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DA544", Offset = "0x9DA544")]
		private int <ChannelId>k__BackingField;

		[Token(Token = "0x400065F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DA554", Offset = "0x9DA554")]
		private int <PlayerId>k__BackingField;

		[Token(Token = "0x4000660")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DA564", Offset = "0x9DA564")]
		private byte <VoiceId>k__BackingField;

		[Token(Token = "0x4000661")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DA574", Offset = "0x9DA574")]
		private object <LocalUserObject>k__BackingField;

		[Token(Token = "0x17000121")]
		public VoiceInfo Info
		{
			[Token(Token = "0x60007D7")]
			[Address(RVA = "0x133F728", Offset = "0x133F728", VA = "0x133F728")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DFA14", Offset = "0x9DFA14")]
			get
			{
				return default(VoiceInfo);
			}
			[Token(Token = "0x60007D8")]
			[Address(RVA = "0x133F70C", Offset = "0x133F70C", VA = "0x133F70C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DFA24", Offset = "0x9DFA24")]
			private set
			{
			}
		}

		[Token(Token = "0x17000122")]
		public int ChannelId
		{
			[Token(Token = "0x60007D9")]
			[Address(RVA = "0x133F744", Offset = "0x133F744", VA = "0x133F744")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DFA34", Offset = "0x9DFA34")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60007DA")]
			[Address(RVA = "0x133F6F4", Offset = "0x133F6F4", VA = "0x133F6F4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DFA44", Offset = "0x9DFA44")]
			private set
			{
			}
		}

		[Token(Token = "0x17000123")]
		public int PlayerId
		{
			[Token(Token = "0x60007DB")]
			[Address(RVA = "0x133F74C", Offset = "0x133F74C", VA = "0x133F74C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DFA54", Offset = "0x9DFA54")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60007DC")]
			[Address(RVA = "0x133F6FC", Offset = "0x133F6FC", VA = "0x133F6FC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DFA64", Offset = "0x9DFA64")]
			private set
			{
			}
		}

		[Token(Token = "0x17000124")]
		public byte VoiceId
		{
			[Token(Token = "0x60007DD")]
			[Address(RVA = "0x133F754", Offset = "0x133F754", VA = "0x133F754")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DFA74", Offset = "0x9DFA74")]
			get
			{
				return default(byte);
			}
			[Token(Token = "0x60007DE")]
			[Address(RVA = "0x133F704", Offset = "0x133F704", VA = "0x133F704")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DFA84", Offset = "0x9DFA84")]
			private set
			{
			}
		}

		[Token(Token = "0x17000125")]
		public object LocalUserObject
		{
			[Token(Token = "0x60007DF")]
			[Address(RVA = "0x133F75C", Offset = "0x133F75C", VA = "0x133F75C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DFA94", Offset = "0x9DFA94")]
			get
			{
				return null;
			}
			[Token(Token = "0x60007E0")]
			[Address(RVA = "0x133F720", Offset = "0x133F720", VA = "0x133F720")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DFAA4", Offset = "0x9DFAA4")]
			private set
			{
			}
		}

		[Token(Token = "0x60007D6")]
		[Address(RVA = "0x133F690", Offset = "0x133F690", VA = "0x133F690")]
		internal RemoteVoiceInfo(int channelId, int playerId, byte voiceId, VoiceInfo info, object localUserObject)
		{
		}
	}
	[Token(Token = "0x20000FC")]
	public abstract class BufferReaderPushAdapterBase<T> : IServiceable
	{
		[Token(Token = "0x4000662")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		protected IDataReader<T> reader;

		[Token(Token = "0x60007E1")]
		public abstract void Service(LocalVoice localVoice);

		[Token(Token = "0x60007E2")]
		public BufferReaderPushAdapterBase(IDataReader<T> reader)
		{
		}

		[Token(Token = "0x60007E3")]
		public void Dispose()
		{
		}
	}
	[Token(Token = "0x20000FD")]
	public class BufferReaderPushAdapter<T> : BufferReaderPushAdapterBase<T>
	{
		[Token(Token = "0x4000663")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		protected T[] buffer;

		[Token(Token = "0x60007E4")]
		public BufferReaderPushAdapter(LocalVoice localVoice, IDataReader<T> reader)
		{
		}

		[Token(Token = "0x60007E5")]
		public override void Service(LocalVoice localVoice)
		{
		}
	}
	[Token(Token = "0x20000FE")]
	public class BufferReaderPushAdapterAsyncPool<T> : BufferReaderPushAdapterBase<T>
	{
		[Token(Token = "0x60007E6")]
		public BufferReaderPushAdapterAsyncPool(LocalVoice localVoice, IDataReader<T> reader)
		{
		}

		[Token(Token = "0x60007E7")]
		public override void Service(LocalVoice localVoice)
		{
		}
	}
	[Token(Token = "0x20000FF")]
	public class BufferReaderPushAdapterAsyncPoolCopy<T> : BufferReaderPushAdapterBase<T>
	{
		[Token(Token = "0x4000664")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		protected T[] buffer;

		[Token(Token = "0x60007E8")]
		public BufferReaderPushAdapterAsyncPoolCopy(LocalVoice localVoice, IDataReader<T> reader)
		{
		}

		[Token(Token = "0x60007E9")]
		public override void Service(LocalVoice localVoice)
		{
		}
	}
	[Token(Token = "0x2000100")]
	public class BufferReaderPushAdapterAsyncPoolFloatToShort : BufferReaderPushAdapterBase<float>
	{
		[Token(Token = "0x4000665")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private float[] buffer;

		[Token(Token = "0x60007EA")]
		[Address(RVA = "0x1339574", Offset = "0x1339574", VA = "0x1339574")]
		public BufferReaderPushAdapterAsyncPoolFloatToShort(LocalVoice localVoice, IDataReader<float> reader)
		{
		}

		[Token(Token = "0x60007EB")]
		[Address(RVA = "0x1339670", Offset = "0x1339670", VA = "0x1339670", Slot = "5")]
		public override void Service(LocalVoice localVoice)
		{
		}
	}
	[Token(Token = "0x2000101")]
	internal class VoiceEventCode
	{
		[Token(Token = "0x4000666")]
		public const byte Code0 = 201;

		[Token(Token = "0x60007EC")]
		[Address(RVA = "0x1261EB8", Offset = "0x1261EB8", VA = "0x1261EB8")]
		public static byte GetCode(int channelID)
		{
			return default(byte);
		}

		[Token(Token = "0x60007ED")]
		[Address(RVA = "0x1261EC0", Offset = "0x1261EC0", VA = "0x1261EC0")]
		public static bool TryGetChannelID(byte evCode, int maxChannels, out byte channelID)
		{
			return default(bool);
		}

		[Token(Token = "0x60007EE")]
		[Address(RVA = "0x1261EF0", Offset = "0x1261EF0", VA = "0x1261EF0")]
		public VoiceEventCode()
		{
		}
	}
	[Token(Token = "0x2000102")]
	public class LoadBalancingFrontend : LoadBalancingClient, IVoiceFrontend, ILogger, IDisposable
	{
		[Serializable]
		[Token(Token = "0x20001AE")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9D60CC", Offset = "0x9D60CC")]
		private sealed class <>c
		{
			[Token(Token = "0x4000A6E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x4000A6F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Func<LocalVoice, bool> <>9__26_0;

			[Token(Token = "0x6000BD3")]
			[Address(RVA = "0x133B488", Offset = "0x133B488", VA = "0x133B488")]
			public <>c()
			{
			}

			[Token(Token = "0x6000BD4")]
			[Address(RVA = "0x133B490", Offset = "0x133B490", VA = "0x133B490")]
			internal bool <SendDebugEchoVoicesInfo>b__26_0(LocalVoice x)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x4000667")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		protected VoiceClient voiceClient;

		[Token(Token = "0x4000668")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DA584", Offset = "0x9DA584")]
		private Action<EventData> <OnEventAction>k__BackingField;

		[Token(Token = "0x4000669")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DA594", Offset = "0x9DA594")]
		private Action<ClientState> <OnStateChangeAction>k__BackingField;

		[Token(Token = "0x400066A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		private object sendLock;

		[Token(Token = "0x17000126")]
		public VoiceClient VoiceClient
		{
			[Token(Token = "0x60007EF")]
			[Address(RVA = "0x1339E90", Offset = "0x1339E90", VA = "0x1339E90")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000127")]
		public new Action<EventData> OnEventAction
		{
			[Token(Token = "0x60007F7")]
			[Address(RVA = "0x133A564", Offset = "0x133A564", VA = "0x133A564")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DFAB4", Offset = "0x9DFAB4")]
			get
			{
				return null;
			}
			[Token(Token = "0x60007F8")]
			[Address(RVA = "0x133A56C", Offset = "0x133A56C", VA = "0x133A56C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DFAC4", Offset = "0x9DFAC4")]
			set
			{
			}
		}

		[Token(Token = "0x17000128")]
		public new Action<ClientState> OnStateChangeAction
		{
			[Token(Token = "0x60007F9")]
			[Address(RVA = "0x133A574", Offset = "0x133A574", VA = "0x133A574")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DFAD4", Offset = "0x9DFAD4")]
			get
			{
				return null;
			}
			[Token(Token = "0x60007FA")]
			[Address(RVA = "0x133A57C", Offset = "0x133A57C", VA = "0x133A57C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DFAE4", Offset = "0x9DFAE4")]
			set
			{
			}
		}

		[Token(Token = "0x17000129")]
		public byte GlobalAudioGroup
		{
			[Token(Token = "0x60007FE")]
			[Address(RVA = "0x133A810", Offset = "0x133A810", VA = "0x133A810")]
			get
			{
				return default(byte);
			}
			[Token(Token = "0x60007FF")]
			[Address(RVA = "0x133A840", Offset = "0x133A840", VA = "0x133A840")]
			set
			{
			}
		}

		[Token(Token = "0x60007F0")]
		[Address(RVA = "0x1339E98", Offset = "0x1339E98", VA = "0x1339E98", Slot = "27")]
		public void LogError(string fmt, params object[] args)
		{
		}

		[Token(Token = "0x60007F1")]
		[Address(RVA = "0x1339EDC", Offset = "0x1339EDC", VA = "0x1339EDC", Slot = "28")]
		public void LogWarning(string fmt, params object[] args)
		{
		}

		[Token(Token = "0x60007F2")]
		[Address(RVA = "0x1339F20", Offset = "0x1339F20", VA = "0x1339F20", Slot = "29")]
		public void LogInfo(string fmt, params object[] args)
		{
		}

		[Token(Token = "0x60007F3")]
		[Address(RVA = "0x1339F64", Offset = "0x1339F64", VA = "0x1339F64", Slot = "30")]
		public void LogDebug(string fmt, params object[] args)
		{
		}

		[Token(Token = "0x60007F4")]
		[Address(RVA = "0x1339FA8", Offset = "0x1339FA8", VA = "0x1339FA8", Slot = "19")]
		public int AssignChannel(VoiceInfo v)
		{
			return default(int);
		}

		[Token(Token = "0x60007F5")]
		[Address(RVA = "0x133A09C", Offset = "0x133A09C", VA = "0x133A09C", Slot = "20")]
		public bool IsChannelJoined(int channelId)
		{
			return default(bool);
		}

		[Token(Token = "0x60007F6")]
		[Address(RVA = "0x133A0AC", Offset = "0x133A0AC", VA = "0x133A0AC", Slot = "26")]
		public void SetDebugEchoMode(LocalVoice v)
		{
		}

		[Token(Token = "0x60007FB")]
		[Address(RVA = "0x133A584", Offset = "0x133A584", VA = "0x133A584")]
		public LoadBalancingFrontend(ConnectionProtocol connectionProtocol = ConnectionProtocol.Udp)
		{
		}

		[Token(Token = "0x60007FC")]
		[Address(RVA = "0x133A778", Offset = "0x133A778", VA = "0x133A778")]
		public new void Service()
		{
		}

		[Token(Token = "0x60007FD")]
		[Address(RVA = "0x133A7C0", Offset = "0x133A7C0", VA = "0x133A7C0", Slot = "32")]
		public virtual bool ChangeAudioGroups(byte[] groupsToRemove, byte[] groupsToAdd)
		{
			return default(bool);
		}

		[Token(Token = "0x6000800")]
		[Address(RVA = "0x133A1D0", Offset = "0x133A1D0", VA = "0x133A1D0", Slot = "21")]
		public void SendVoicesInfo(IEnumerable<LocalVoice> voices, int channelId, int targetPlayerId)
		{
		}

		[Token(Token = "0x6000801")]
		[Address(RVA = "0x133A9B4", Offset = "0x133A9B4", VA = "0x133A9B4")]
		public void SendDebugEchoVoicesInfo(int channelId)
		{
		}

		[Token(Token = "0x6000802")]
		[Address(RVA = "0x133A3A4", Offset = "0x133A3A4", VA = "0x133A3A4", Slot = "22")]
		public void SendVoiceRemove(LocalVoice voice, int channelId, int targetPlayerId)
		{
		}

		[Token(Token = "0x6000803")]
		[Address(RVA = "0x133AB28", Offset = "0x133AB28", VA = "0x133AB28", Slot = "23")]
		public void SendFrame(ArraySegment<byte> data, byte evNumber, byte voiceId, int channelId, LocalVoice localVoice)
		{
		}

		[Token(Token = "0x6000804")]
		[Address(RVA = "0x133AE80", Offset = "0x133AE80", VA = "0x133AE80", Slot = "24")]
		public string ChannelIdStr(int channelId)
		{
			return null;
		}

		[Token(Token = "0x6000805")]
		[Address(RVA = "0x133AE88", Offset = "0x133AE88", VA = "0x133AE88", Slot = "25")]
		public string PlayerIdStr(int playerId)
		{
			return null;
		}

		[Token(Token = "0x6000806")]
		[Address(RVA = "0x133AE90", Offset = "0x133AE90", VA = "0x133AE90")]
		private void onEventActionVoiceClient(EventData ev)
		{
		}

		[Token(Token = "0x6000807")]
		[Address(RVA = "0x133B244", Offset = "0x133B244", VA = "0x133B244")]
		private void onStateChangeVoiceClient(ClientState state)
		{
		}

		[Token(Token = "0x6000808")]
		[Address(RVA = "0x133B130", Offset = "0x133B130", VA = "0x133B130")]
		private void onPlayerLeave(int playerId)
		{
		}

		[Token(Token = "0x6000809")]
		[Address(RVA = "0x133B3F4", Offset = "0x133B3F4", VA = "0x133B3F4", Slot = "31")]
		public void Dispose()
		{
		}
	}
	[Token(Token = "0x2000103")]
	public class AudioInEnumerator : IDisposable
	{
		[Token(Token = "0x400066B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public readonly bool IsSupported;

		[Token(Token = "0x1700012A")]
		public int Count
		{
			[Token(Token = "0x600080C")]
			[Address(RVA = "0x1338404", Offset = "0x1338404", VA = "0x1338404")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x600080A")]
		[Address(RVA = "0x13383F8", Offset = "0x13383F8", VA = "0x13383F8")]
		public AudioInEnumerator()
		{
		}

		[Token(Token = "0x600080B")]
		[Address(RVA = "0x1338400", Offset = "0x1338400", VA = "0x1338400")]
		public void Refresh()
		{
		}

		[Token(Token = "0x600080D")]
		[Address(RVA = "0x133840C", Offset = "0x133840C", VA = "0x133840C")]
		public string NameAtIndex(int i)
		{
			return null;
		}

		[Token(Token = "0x600080E")]
		[Address(RVA = "0x1338414", Offset = "0x1338414", VA = "0x1338414")]
		public int IDAtIndex(int i)
		{
			return default(int);
		}

		[Token(Token = "0x600080F")]
		[Address(RVA = "0x133841C", Offset = "0x133841C", VA = "0x133841C")]
		public bool IDIsValid(int id)
		{
			return default(bool);
		}

		[Token(Token = "0x6000810")]
		[Address(RVA = "0x1338428", Offset = "0x1338428", VA = "0x1338428", Slot = "4")]
		public void Dispose()
		{
		}
	}
}
namespace ExitGames.Client.Photon.LoadBalancing
{
	[Token(Token = "0x2000104")]
	public static class Extensions
	{
		[Token(Token = "0x6000811")]
		[Address(RVA = "0x132B158", Offset = "0x132B158", VA = "0x132B158")]
		public static void Merge(this IDictionary target, IDictionary addHash)
		{
		}

		[Token(Token = "0x6000812")]
		[Address(RVA = "0x132B570", Offset = "0x132B570", VA = "0x132B570")]
		public static void MergeStringKeys(this IDictionary target, IDictionary addHash)
		{
		}

		[Token(Token = "0x6000813")]
		[Address(RVA = "0x132B9A4", Offset = "0x132B9A4", VA = "0x132B9A4")]
		public static string ToStringFull(this IDictionary origin)
		{
			return null;
		}

		[Token(Token = "0x6000814")]
		[Address(RVA = "0x132BA10", Offset = "0x132BA10", VA = "0x132BA10")]
		public static string ToStringFull(this object[] data)
		{
			return null;
		}

		[Token(Token = "0x6000815")]
		[Address(RVA = "0x132BB78", Offset = "0x132BB78", VA = "0x132BB78")]
		public static Hashtable StripToStringKeys(this IDictionary original)
		{
			return null;
		}

		[Token(Token = "0x6000816")]
		[Address(RVA = "0x132BF38", Offset = "0x132BF38", VA = "0x132BF38")]
		public static void StripKeysWithNullValues(this IDictionary original)
		{
		}

		[Token(Token = "0x6000817")]
		[Address(RVA = "0x132C238", Offset = "0x132C238", VA = "0x132C238")]
		public static bool Contains(this int[] target, int nr)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x2000105")]
	public class FriendInfo
	{
		[Token(Token = "0x400066C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DA5A4", Offset = "0x9DA5A4")]
		private string <UserId>k__BackingField;

		[Token(Token = "0x400066D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DA5B4", Offset = "0x9DA5B4")]
		private bool <IsOnline>k__BackingField;

		[Token(Token = "0x400066E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DA5C4", Offset = "0x9DA5C4")]
		private string <Room>k__BackingField;

		[Token(Token = "0x1700012B")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x9E0F64", Offset = "0x9E0F64")]
		public string Name
		{
			[Token(Token = "0x6000818")]
			[Address(RVA = "0x132C2BC", Offset = "0x132C2BC", VA = "0x132C2BC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700012C")]
		public string UserId
		{
			[Token(Token = "0x6000819")]
			[Address(RVA = "0x132C2C4", Offset = "0x132C2C4", VA = "0x132C2C4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DFB64", Offset = "0x9DFB64")]
			get
			{
				return null;
			}
			[Token(Token = "0x600081A")]
			[Address(RVA = "0x132C2CC", Offset = "0x132C2CC", VA = "0x132C2CC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DFB74", Offset = "0x9DFB74")]
			protected internal set
			{
			}
		}

		[Token(Token = "0x1700012D")]
		public bool IsOnline
		{
			[Token(Token = "0x600081B")]
			[Address(RVA = "0x132C2D4", Offset = "0x132C2D4", VA = "0x132C2D4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DFB84", Offset = "0x9DFB84")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600081C")]
			[Address(RVA = "0x132C2DC", Offset = "0x132C2DC", VA = "0x132C2DC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DFB94", Offset = "0x9DFB94")]
			protected internal set
			{
			}
		}

		[Token(Token = "0x1700012E")]
		public string Room
		{
			[Token(Token = "0x600081D")]
			[Address(RVA = "0x132C2E8", Offset = "0x132C2E8", VA = "0x132C2E8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DFBA4", Offset = "0x9DFBA4")]
			get
			{
				return null;
			}
			[Token(Token = "0x600081E")]
			[Address(RVA = "0x132C2F0", Offset = "0x132C2F0", VA = "0x132C2F0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DFBB4", Offset = "0x9DFBB4")]
			protected internal set
			{
			}
		}

		[Token(Token = "0x1700012F")]
		public bool IsInRoom
		{
			[Token(Token = "0x600081F")]
			[Address(RVA = "0x132C2F8", Offset = "0x132C2F8", VA = "0x132C2F8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000820")]
		[Address(RVA = "0x132C324", Offset = "0x132C324", VA = "0x132C324", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000821")]
		[Address(RVA = "0x132C3C4", Offset = "0x132C3C4", VA = "0x132C3C4")]
		public FriendInfo()
		{
		}
	}
	[Token(Token = "0x2000106")]
	public enum ClientState
	{
		[Token(Token = "0x4000670")]
		PeerCreated = 0,
		[Token(Token = "0x4000671")]
		Authenticating = 1,
		[Token(Token = "0x4000672")]
		Authenticated = 2,
		[Token(Token = "0x4000673")]
		JoinedLobby = 3,
		[Token(Token = "0x4000674")]
		DisconnectingFromMasterserver = 4,
		[Token(Token = "0x4000675")]
		ConnectingToGameserver = 5,
		[Token(Token = "0x4000676")]
		ConnectedToGameserver = 6,
		[Token(Token = "0x4000677")]
		Joining = 7,
		[Token(Token = "0x4000678")]
		Joined = 8,
		[Token(Token = "0x4000679")]
		Leaving = 9,
		[Token(Token = "0x400067A")]
		DisconnectingFromGameserver = 10,
		[Token(Token = "0x400067B")]
		ConnectingToMasterserver = 11,
		[Token(Token = "0x400067C")]
		Disconnecting = 12,
		[Token(Token = "0x400067D")]
		Disconnected = 13,
		[Token(Token = "0x400067E")]
		ConnectedToMasterserver = 14,
		[Token(Token = "0x400067F")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x9DA5D4", Offset = "0x9DA5D4")]
		ConnectedToMaster = 14,
		[Token(Token = "0x4000680")]
		ConnectingToNameServer = 15,
		[Token(Token = "0x4000681")]
		ConnectedToNameServer = 16,
		[Token(Token = "0x4000682")]
		DisconnectingFromNameServer = 17
	}
	[Token(Token = "0x2000107")]
	internal enum JoinType
	{
		[Token(Token = "0x4000684")]
		CreateRoom,
		[Token(Token = "0x4000685")]
		JoinRoom,
		[Token(Token = "0x4000686")]
		JoinRandomRoom,
		[Token(Token = "0x4000687")]
		JoinOrCreateRoom
	}
	[Token(Token = "0x2000108")]
	public enum DisconnectCause
	{
		[Token(Token = "0x4000689")]
		None,
		[Token(Token = "0x400068A")]
		DisconnectByServerUserLimit,
		[Token(Token = "0x400068B")]
		ExceptionOnConnect,
		[Token(Token = "0x400068C")]
		DisconnectByServer,
		[Token(Token = "0x400068D")]
		TimeoutDisconnect,
		[Token(Token = "0x400068E")]
		Exception,
		[Token(Token = "0x400068F")]
		InvalidAuthentication,
		[Token(Token = "0x4000690")]
		MaxCcuReached,
		[Token(Token = "0x4000691")]
		InvalidRegion,
		[Token(Token = "0x4000692")]
		OperationNotAllowedInCurrentState,
		[Token(Token = "0x4000693")]
		CustomAuthenticationFailed,
		[Token(Token = "0x4000694")]
		DisconnectByServerLogic,
		[Token(Token = "0x4000695")]
		AuthenticationTicketExpired
	}
	[Token(Token = "0x2000109")]
	public enum ServerConnection
	{
		[Token(Token = "0x4000697")]
		MasterServer,
		[Token(Token = "0x4000698")]
		GameServer,
		[Token(Token = "0x4000699")]
		NameServer
	}
	[Token(Token = "0x200010A")]
	public enum EncryptionMode
	{
		[Token(Token = "0x400069B")]
		PayloadEncryption = 0,
		[Token(Token = "0x400069C")]
		DatagramEncryption = 10,
		[Token(Token = "0x400069D")]
		DatagramEncryptionRandomSequence = 11
	}
	[Token(Token = "0x200010B")]
	public static class EncryptionDataParameters
	{
		[Token(Token = "0x400069E")]
		public const byte Mode = 0;

		[Token(Token = "0x400069F")]
		public const byte Secret1 = 1;

		[Token(Token = "0x40006A0")]
		public const byte Secret2 = 2;
	}
	[Token(Token = "0x200010C")]
	public class LoadBalancingClient : IPhotonPeerListener
	{
		[Token(Token = "0x40006A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public LoadBalancingPeer loadBalancingPeer;

		[Token(Token = "0x40006A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DA60C", Offset = "0x9DA60C")]
		private string <AppVersion>k__BackingField;

		[Token(Token = "0x40006A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DA61C", Offset = "0x9DA61C")]
		private string <AppId>k__BackingField;

		[Token(Token = "0x40006A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DA62C", Offset = "0x9DA62C")]
		private AuthenticationValues <AuthValues>k__BackingField;

		[Token(Token = "0x40006A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public AuthModeOption AuthMode;

		[Token(Token = "0x40006A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public EncryptionMode EncryptionMode;

		[Token(Token = "0x40006A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private ConnectionProtocol ExpectedProtocol;

		[Token(Token = "0x40006A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x39")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DA63C", Offset = "0x9DA63C")]
		private bool <IsUsingNameServer>k__BackingField;

		[Token(Token = "0x40006A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public string NameServerHost;

		[Token(Token = "0x40006AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public string NameServerHttp;

		[Token(Token = "0x40006AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly Dictionary<ConnectionProtocol, int> ProtocolToNameServerPort;

		[Token(Token = "0x40006AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DA64C", Offset = "0x9DA64C")]
		private string <MasterServerAddress>k__BackingField;

		[Token(Token = "0x40006AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DA65C", Offset = "0x9DA65C")]
		private string <GameServerAddress>k__BackingField;

		[Token(Token = "0x40006AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DA66C", Offset = "0x9DA66C")]
		private ServerConnection <Server>k__BackingField;

		[Token(Token = "0x40006AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private ClientState state;

		[Token(Token = "0x40006B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DA6AC", Offset = "0x9DA6AC")]
		private DisconnectCause <DisconnectedCause>k__BackingField;

		[Token(Token = "0x40006B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private bool inLobby;

		[Token(Token = "0x40006B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DA6BC", Offset = "0x9DA6BC")]
		private TypedLobby <CurrentLobby>k__BackingField;

		[Token(Token = "0x40006B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private bool autoJoinLobby;

		[Token(Token = "0x40006B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x91")]
		public bool EnableLobbyStatistics;

		[Token(Token = "0x40006B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private List<TypedLobbyInfo> lobbyStatistics;

		[Token(Token = "0x40006B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DA6CC", Offset = "0x9DA6CC")]
		private Player <LocalPlayer>k__BackingField;

		[Token(Token = "0x40006BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public Dictionary<string, RoomInfo> RoomInfoList;

		[Token(Token = "0x40006BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public Room CurrentRoom;

		[Token(Token = "0x40006BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DA6DC", Offset = "0x9DA6DC")]
		private int <PlayersOnMasterCount>k__BackingField;

		[Token(Token = "0x40006BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DA6EC", Offset = "0x9DA6EC")]
		private int <PlayersInRoomsCount>k__BackingField;

		[Token(Token = "0x40006BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DA6FC", Offset = "0x9DA6FC")]
		private int <RoomsCount>k__BackingField;

		[Token(Token = "0x40006BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private JoinType lastJoinType;

		[Token(Token = "0x40006C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		protected internal EnterRoomParams enterRoomParamsCache;

		[Token(Token = "0x40006C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private bool didAuthenticate;

		[Token(Token = "0x40006C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DA70C", Offset = "0x9DA70C")]
		private List<FriendInfo> <FriendList>k__BackingField;

		[Token(Token = "0x40006C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private string[] friendListRequested;

		[Token(Token = "0x40006C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private int friendListTimestamp;

		[Token(Token = "0x40006C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
		private bool isFetchingFriendList;

		[Token(Token = "0x40006C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DA71C", Offset = "0x9DA71C")]
		private string[] <AvailableRegions>k__BackingField;

		[Token(Token = "0x40006C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DA72C", Offset = "0x9DA72C")]
		private string[] <AvailableRegionsServers>k__BackingField;

		[Token(Token = "0x40006C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DA73C", Offset = "0x9DA73C")]
		private string <CloudRegion>k__BackingField;

		[Token(Token = "0x40006C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private byte[] encryptionSecret;

		[Token(Token = "0x17000130")]
		public string AppVersion
		{
			[Token(Token = "0x6000822")]
			[Address(RVA = "0x132C3D4", Offset = "0x132C3D4", VA = "0x132C3D4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DFBC4", Offset = "0x9DFBC4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000823")]
			[Address(RVA = "0x132C3DC", Offset = "0x132C3DC", VA = "0x132C3DC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DFBD4", Offset = "0x9DFBD4")]
			set
			{
			}
		}

		[Token(Token = "0x17000131")]
		public string AppId
		{
			[Token(Token = "0x6000824")]
			[Address(RVA = "0x132C3E4", Offset = "0x132C3E4", VA = "0x132C3E4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DFBE4", Offset = "0x9DFBE4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000825")]
			[Address(RVA = "0x132C3EC", Offset = "0x132C3EC", VA = "0x132C3EC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DFBF4", Offset = "0x9DFBF4")]
			set
			{
			}
		}

		[Token(Token = "0x17000132")]
		public AuthenticationValues AuthValues
		{
			[Token(Token = "0x6000826")]
			[Address(RVA = "0x132C3F4", Offset = "0x132C3F4", VA = "0x132C3F4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DFC04", Offset = "0x9DFC04")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000827")]
			[Address(RVA = "0x132C3FC", Offset = "0x132C3FC", VA = "0x132C3FC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DFC14", Offset = "0x9DFC14")]
			set
			{
			}
		}

		[Token(Token = "0x17000133")]
		public ConnectionProtocol TransportProtocol
		{
			[Token(Token = "0x6000828")]
			[Address(RVA = "0x132C404", Offset = "0x132C404", VA = "0x132C404")]
			get
			{
				return default(ConnectionProtocol);
			}
			[Token(Token = "0x6000829")]
			[Address(RVA = "0x132C434", Offset = "0x132C434", VA = "0x132C434")]
			set
			{
			}
		}

		[Token(Token = "0x17000134")]
		public Dictionary<ConnectionProtocol, Type> SocketImplementationConfig
		{
			[Token(Token = "0x600082A")]
			[Address(RVA = "0x132C560", Offset = "0x132C560", VA = "0x132C560")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000135")]
		private string TokenForInit
		{
			[Token(Token = "0x600082B")]
			[Address(RVA = "0x132C58C", Offset = "0x132C58C", VA = "0x132C58C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000136")]
		public bool IsUsingNameServer
		{
			[Token(Token = "0x600082C")]
			[Address(RVA = "0x132C5AC", Offset = "0x132C5AC", VA = "0x132C5AC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DFC24", Offset = "0x9DFC24")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600082D")]
			[Address(RVA = "0x132C5B4", Offset = "0x132C5B4", VA = "0x132C5B4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DFC34", Offset = "0x9DFC34")]
			protected internal set
			{
			}
		}

		[Token(Token = "0x17000137")]
		public string NameServerAddress
		{
			[Token(Token = "0x600082E")]
			[Address(RVA = "0x132C5C0", Offset = "0x132C5C0", VA = "0x132C5C0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000138")]
		public string CurrentServerAddress
		{
			[Token(Token = "0x600082F")]
			[Address(RVA = "0x132C78C", Offset = "0x132C78C", VA = "0x132C78C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000139")]
		public string MasterServerAddress
		{
			[Token(Token = "0x6000830")]
			[Address(RVA = "0x132C7BC", Offset = "0x132C7BC", VA = "0x132C7BC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DFC44", Offset = "0x9DFC44")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000831")]
			[Address(RVA = "0x132C7C4", Offset = "0x132C7C4", VA = "0x132C7C4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DFC54", Offset = "0x9DFC54")]
			protected internal set
			{
			}
		}

		[Token(Token = "0x1700013A")]
		public string GameServerAddress
		{
			[Token(Token = "0x6000832")]
			[Address(RVA = "0x132C7CC", Offset = "0x132C7CC", VA = "0x132C7CC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DFC64", Offset = "0x9DFC64")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000833")]
			[Address(RVA = "0x132C7D4", Offset = "0x132C7D4", VA = "0x132C7D4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DFC74", Offset = "0x9DFC74")]
			protected internal set
			{
			}
		}

		[Token(Token = "0x1700013B")]
		public ServerConnection Server
		{
			[Token(Token = "0x6000834")]
			[Address(RVA = "0x132C7DC", Offset = "0x132C7DC", VA = "0x132C7DC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DFC84", Offset = "0x9DFC84")]
			get
			{
				return default(ServerConnection);
			}
			[Token(Token = "0x6000835")]
			[Address(RVA = "0x132C7E4", Offset = "0x132C7E4", VA = "0x132C7E4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DFC94", Offset = "0x9DFC94")]
			private set
			{
			}
		}

		[Token(Token = "0x1700013C")]
		public ClientState State
		{
			[Token(Token = "0x6000836")]
			[Address(RVA = "0x132C7EC", Offset = "0x132C7EC", VA = "0x132C7EC")]
			get
			{
				return default(ClientState);
			}
			[Token(Token = "0x6000837")]
			[Address(RVA = "0x132C7F4", Offset = "0x132C7F4", VA = "0x132C7F4")]
			protected internal set
			{
			}
		}

		[Token(Token = "0x1700013D")]
		public bool IsConnected
		{
			[Token(Token = "0x6000838")]
			[Address(RVA = "0x132C86C", Offset = "0x132C86C", VA = "0x132C86C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700013E")]
		public bool IsConnectedAndReady
		{
			[Token(Token = "0x6000839")]
			[Address(RVA = "0x132C898", Offset = "0x132C898", VA = "0x132C898")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700013F")]
		public DisconnectCause DisconnectedCause
		{
			[Token(Token = "0x6000840")]
			[Address(RVA = "0x132CCC0", Offset = "0x132CCC0", VA = "0x132CCC0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DFD04", Offset = "0x9DFD04")]
			get
			{
				return default(DisconnectCause);
			}
			[Token(Token = "0x6000841")]
			[Address(RVA = "0x132CCC8", Offset = "0x132CCC8", VA = "0x132CCC8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DFD14", Offset = "0x9DFD14")]
			protected set
			{
			}
		}

		[Token(Token = "0x17000140")]
		public TypedLobby CurrentLobby
		{
			[Token(Token = "0x6000842")]
			[Address(RVA = "0x132CCD0", Offset = "0x132CCD0", VA = "0x132CCD0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DFD24", Offset = "0x9DFD24")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000843")]
			[Address(RVA = "0x132CCD8", Offset = "0x132CCD8", VA = "0x132CCD8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DFD34", Offset = "0x9DFD34")]
			protected internal set
			{
			}
		}

		[Token(Token = "0x17000141")]
		public bool AutoJoinLobby
		{
			[Token(Token = "0x6000844")]
			[Address(RVA = "0x132CCE0", Offset = "0x132CCE0", VA = "0x132CCE0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000845")]
			[Address(RVA = "0x132CCE8", Offset = "0x132CCE8", VA = "0x132CCE8")]
			set
			{
			}
		}

		[Token(Token = "0x17000142")]
		public List<TypedLobbyInfo> LobbyStatistics
		{
			[Token(Token = "0x6000846")]
			[Address(RVA = "0x132CCF4", Offset = "0x132CCF4", VA = "0x132CCF4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000847")]
			[Address(RVA = "0x132CCFC", Offset = "0x132CCFC", VA = "0x132CCFC")]
			private set
			{
			}
		}

		[Token(Token = "0x17000143")]
		public Player LocalPlayer
		{
			[Token(Token = "0x6000848")]
			[Address(RVA = "0x132CD04", Offset = "0x132CD04", VA = "0x132CD04")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DFD44", Offset = "0x9DFD44")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000849")]
			[Address(RVA = "0x132CD0C", Offset = "0x132CD0C", VA = "0x132CD0C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DFD54", Offset = "0x9DFD54")]
			internal set
			{
			}
		}

		[Token(Token = "0x17000144")]
		public string NickName
		{
			[Token(Token = "0x600084A")]
			[Address(RVA = "0x132CD14", Offset = "0x132CD14", VA = "0x132CD14")]
			get
			{
				return null;
			}
			[Token(Token = "0x600084B")]
			[Address(RVA = "0x132CD48", Offset = "0x132CD48", VA = "0x132CD48")]
			set
			{
			}
		}

		[Token(Token = "0x17000145")]
		public string UserId
		{
			[Token(Token = "0x600084C")]
			[Address(RVA = "0x132CDE4", Offset = "0x132CDE4", VA = "0x132CDE4")]
			get
			{
				return null;
			}
			[Token(Token = "0x600084D")]
			[Address(RVA = "0x132CDFC", Offset = "0x132CDFC", VA = "0x132CDFC")]
			set
			{
			}
		}

		[Token(Token = "0x17000146")]
		public int PlayersOnMasterCount
		{
			[Token(Token = "0x600084E")]
			[Address(RVA = "0x132CE88", Offset = "0x132CE88", VA = "0x132CE88")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DFD64", Offset = "0x9DFD64")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600084F")]
			[Address(RVA = "0x132CE90", Offset = "0x132CE90", VA = "0x132CE90")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DFD74", Offset = "0x9DFD74")]
			internal set
			{
			}
		}

		[Token(Token = "0x17000147")]
		public int PlayersInRoomsCount
		{
			[Token(Token = "0x6000850")]
			[Address(RVA = "0x132CE98", Offset = "0x132CE98", VA = "0x132CE98")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DFD84", Offset = "0x9DFD84")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000851")]
			[Address(RVA = "0x132CEA0", Offset = "0x132CEA0", VA = "0x132CEA0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DFD94", Offset = "0x9DFD94")]
			internal set
			{
			}
		}

		[Token(Token = "0x17000148")]
		public int RoomsCount
		{
			[Token(Token = "0x6000852")]
			[Address(RVA = "0x132CEA8", Offset = "0x132CEA8", VA = "0x132CEA8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DFDA4", Offset = "0x9DFDA4")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000853")]
			[Address(RVA = "0x132CEB0", Offset = "0x132CEB0", VA = "0x132CEB0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DFDB4", Offset = "0x9DFDB4")]
			internal set
			{
			}
		}

		[Token(Token = "0x17000149")]
		public List<FriendInfo> FriendList
		{
			[Token(Token = "0x6000854")]
			[Address(RVA = "0x132CEB8", Offset = "0x132CEB8", VA = "0x132CEB8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DFDC4", Offset = "0x9DFDC4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000855")]
			[Address(RVA = "0x132CEC0", Offset = "0x132CEC0", VA = "0x132CEC0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DFDD4", Offset = "0x9DFDD4")]
			private set
			{
			}
		}

		[Token(Token = "0x1700014A")]
		public int FriendListAge
		{
			[Token(Token = "0x6000856")]
			[Address(RVA = "0x132CEC8", Offset = "0x132CEC8", VA = "0x132CEC8")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700014B")]
		protected bool IsAuthorizeSecretAvailable
		{
			[Token(Token = "0x6000857")]
			[Address(RVA = "0x132CF0C", Offset = "0x132CF0C", VA = "0x132CF0C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700014C")]
		public string[] AvailableRegions
		{
			[Token(Token = "0x6000858")]
			[Address(RVA = "0x132CF38", Offset = "0x132CF38", VA = "0x132CF38")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DFDE4", Offset = "0x9DFDE4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000859")]
			[Address(RVA = "0x132CF40", Offset = "0x132CF40", VA = "0x132CF40")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DFDF4", Offset = "0x9DFDF4")]
			private set
			{
			}
		}

		[Token(Token = "0x1700014D")]
		public string[] AvailableRegionsServers
		{
			[Token(Token = "0x600085A")]
			[Address(RVA = "0x132CF48", Offset = "0x132CF48", VA = "0x132CF48")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DFE04", Offset = "0x9DFE04")]
			get
			{
				return null;
			}
			[Token(Token = "0x600085B")]
			[Address(RVA = "0x132CF50", Offset = "0x132CF50", VA = "0x132CF50")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DFE14", Offset = "0x9DFE14")]
			private set
			{
			}
		}

		[Token(Token = "0x1700014E")]
		public string CloudRegion
		{
			[Token(Token = "0x600085C")]
			[Address(RVA = "0x132CF58", Offset = "0x132CF58", VA = "0x132CF58")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DFE24", Offset = "0x9DFE24")]
			get
			{
				return null;
			}
			[Token(Token = "0x600085D")]
			[Address(RVA = "0x132CF60", Offset = "0x132CF60", VA = "0x132CF60")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DFE34", Offset = "0x9DFE34")]
			private set
			{
			}
		}

		[Token(Token = "0x14000002")]
		public event Action<ClientState> OnStateChangeAction
		{
			[Token(Token = "0x600083A")]
			[Address(RVA = "0x132C8D0", Offset = "0x132C8D0", VA = "0x132C8D0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DFCA4", Offset = "0x9DFCA4")]
			add
			{
			}
			[Token(Token = "0x600083B")]
			[Address(RVA = "0x132C978", Offset = "0x132C978", VA = "0x132C978")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DFCB4", Offset = "0x9DFCB4")]
			remove
			{
			}
		}

		[Token(Token = "0x14000003")]
		public event Action<EventData> OnEventAction
		{
			[Token(Token = "0x600083C")]
			[Address(RVA = "0x132CA20", Offset = "0x132CA20", VA = "0x132CA20")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DFCC4", Offset = "0x9DFCC4")]
			add
			{
			}
			[Token(Token = "0x600083D")]
			[Address(RVA = "0x132CAC8", Offset = "0x132CAC8", VA = "0x132CAC8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DFCD4", Offset = "0x9DFCD4")]
			remove
			{
			}
		}

		[Token(Token = "0x14000004")]
		public event Action<OperationResponse> OnOpResponseAction
		{
			[Token(Token = "0x600083E")]
			[Address(RVA = "0x132CB70", Offset = "0x132CB70", VA = "0x132CB70")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DFCE4", Offset = "0x9DFCE4")]
			add
			{
			}
			[Token(Token = "0x600083F")]
			[Address(RVA = "0x132CC18", Offset = "0x132CC18", VA = "0x132CC18")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DFCF4", Offset = "0x9DFCF4")]
			remove
			{
			}
		}

		[Token(Token = "0x600085E")]
		[Address(RVA = "0x132CF68", Offset = "0x132CF68", VA = "0x132CF68")]
		public LoadBalancingClient(ConnectionProtocol protocol = ConnectionProtocol.Udp)
		{
		}

		[Token(Token = "0x600085F")]
		[Address(RVA = "0x132D120", Offset = "0x132D120", VA = "0x132D120")]
		public LoadBalancingClient(string masterAddress, string appId, string gameVersion, ConnectionProtocol protocol = ConnectionProtocol.Udp)
		{
		}

		[Token(Token = "0x6000860")]
		[Address(RVA = "0x132C5C4", Offset = "0x132C5C4", VA = "0x132C5C4")]
		private string GetNameServerAddress()
		{
			return null;
		}

		[Token(Token = "0x6000861")]
		[Address(RVA = "0x132D160", Offset = "0x132D160", VA = "0x132D160")]
		public bool Connect(string masterServerAddress, string appId, string appVersion, string nickName, AuthenticationValues authValues)
		{
			return default(bool);
		}

		[Token(Token = "0x6000862")]
		[Address(RVA = "0x132D20C", Offset = "0x132D20C", VA = "0x132D20C", Slot = "8")]
		public virtual bool Connect()
		{
			return default(bool);
		}

		[Token(Token = "0x6000863")]
		[Address(RVA = "0x132D2AC", Offset = "0x132D2AC", VA = "0x132D2AC")]
		public bool ConnectToNameServer()
		{
			return default(bool);
		}

		[Token(Token = "0x6000864")]
		[Address(RVA = "0x132D3C8", Offset = "0x132D3C8", VA = "0x132D3C8")]
		public bool ConnectToRegionMaster(string region)
		{
			return default(bool);
		}

		[Token(Token = "0x6000865")]
		[Address(RVA = "0x132D5F4", Offset = "0x132D5F4", VA = "0x132D5F4")]
		public void Disconnect()
		{
		}

		[Token(Token = "0x6000866")]
		[Address(RVA = "0x132D50C", Offset = "0x132D50C", VA = "0x132D50C")]
		private bool CallAuthenticate()
		{
			return default(bool);
		}

		[Token(Token = "0x6000867")]
		[Address(RVA = "0x132D650", Offset = "0x132D650", VA = "0x132D650")]
		public void Service()
		{
		}

		[Token(Token = "0x6000868")]
		[Address(RVA = "0x132D668", Offset = "0x132D668", VA = "0x132D668")]
		private void DisconnectToReconnect()
		{
		}

		[Token(Token = "0x6000869")]
		[Address(RVA = "0x132D6D4", Offset = "0x132D6D4", VA = "0x132D6D4")]
		private bool ConnectToGameServer()
		{
			return default(bool);
		}

		[Token(Token = "0x600086A")]
		[Address(RVA = "0x132D770", Offset = "0x132D770", VA = "0x132D770")]
		public bool OpGetRegions()
		{
			return default(bool);
		}

		[Token(Token = "0x600086B")]
		[Address(RVA = "0x132D7E0", Offset = "0x132D7E0", VA = "0x132D7E0")]
		public bool OpFindFriends(string[] friendsToFind)
		{
			return default(bool);
		}

		[Token(Token = "0x600086C")]
		[Address(RVA = "0x132DB04", Offset = "0x132DB04", VA = "0x132DB04")]
		public bool OpJoinLobby(TypedLobby lobby)
		{
			return default(bool);
		}

		[Token(Token = "0x600086D")]
		[Address(RVA = "0x132DBBC", Offset = "0x132DBBC", VA = "0x132DBBC")]
		public bool OpLeaveLobby()
		{
			return default(bool);
		}

		[Token(Token = "0x600086E")]
		[Address(RVA = "0x132DBF4", Offset = "0x132DBF4", VA = "0x132DBF4")]
		public bool OpJoinRandomRoom(Hashtable expectedCustomRoomProperties, byte expectedMaxPlayers, [Optional] string[] expectedUsers)
		{
			return default(bool);
		}

		[Token(Token = "0x600086F")]
		[Address(RVA = "0x132DE48", Offset = "0x132DE48", VA = "0x132DE48")]
		public bool OpJoinRandomRoom(Hashtable expectedCustomRoomProperties, byte expectedMaxPlayers, MatchmakingMode matchmakingMode)
		{
			return default(bool);
		}

		[Token(Token = "0x6000870")]
		[Address(RVA = "0x132DC94", Offset = "0x132DC94", VA = "0x132DC94")]
		public bool OpJoinRandomRoom(Hashtable expectedCustomRoomProperties, byte expectedMaxPlayers, MatchmakingMode matchmakingMode, TypedLobby lobby, string sqlLobbyFilter, [Optional] string[] expectedUsers)
		{
			return default(bool);
		}

		[Token(Token = "0x6000871")]
		[Address(RVA = "0x132DEF0", Offset = "0x132DEF0", VA = "0x132DEF0")]
		public bool OpJoinRoom(string roomName, [Optional] string[] expectedUsers)
		{
			return default(bool);
		}

		[Token(Token = "0x6000872")]
		[Address(RVA = "0x132DFEC", Offset = "0x132DFEC", VA = "0x132DFEC")]
		public bool OpReJoinRoom(string roomName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000873")]
		[Address(RVA = "0x132E0E8", Offset = "0x132E0E8", VA = "0x132E0E8")]
		public bool OpJoinOrCreateRoom(string roomName, RoomOptions roomOptions, TypedLobby lobby, [Optional] string[] expectedUsers)
		{
			return default(bool);
		}

		[Token(Token = "0x6000874")]
		[Address(RVA = "0x132E230", Offset = "0x132E230", VA = "0x132E230")]
		public bool OpCreateRoom(string roomName, RoomOptions roomOptions, TypedLobby lobby, [Optional] string[] expectedUsers)
		{
			return default(bool);
		}

		[Token(Token = "0x6000875")]
		[Address(RVA = "0x132E364", Offset = "0x132E364", VA = "0x132E364")]
		public bool OpLeaveRoom()
		{
			return default(bool);
		}

		[Token(Token = "0x6000876")]
		[Address(RVA = "0x132E370", Offset = "0x132E370", VA = "0x132E370")]
		public bool OpLeaveRoom(bool becomeInactive, bool sendAuthCookie = false)
		{
			return default(bool);
		}

		[Token(Token = "0x6000877")]
		[Address(RVA = "0x132E404", Offset = "0x132E404", VA = "0x132E404")]
		public bool OpGetGameList(TypedLobby typedLobby, string sqlLobbyFilter)
		{
			return default(bool);
		}

		[Token(Token = "0x6000878")]
		[Address(RVA = "0x132E454", Offset = "0x132E454", VA = "0x132E454")]
		public bool OpSetCustomPropertiesOfActor(int actorNr, Hashtable propertiesToSet, [Optional] Hashtable expectedProperties, [Optional] WebFlags webFlags)
		{
			return default(bool);
		}

		[Token(Token = "0x6000879")]
		[Address(RVA = "0x132E830", Offset = "0x132E830", VA = "0x132E830")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x9DFE44", Offset = "0x9DFE44")]
		public bool OpSetCustomPropertiesOfActor(int actorNr, Hashtable propertiesToSet, Hashtable expectedProperties, bool webForward)
		{
			return default(bool);
		}

		[Token(Token = "0x600087A")]
		[Address(RVA = "0x132E6C8", Offset = "0x132E6C8", VA = "0x132E6C8")]
		protected internal bool OpSetPropertiesOfActor(int actorNr, Hashtable actorProperties, [Optional] Hashtable expectedProperties, [Optional] WebFlags webFlags)
		{
			return default(bool);
		}

		[Token(Token = "0x600087B")]
		[Address(RVA = "0x132EC64", Offset = "0x132EC64", VA = "0x132EC64")]
		public bool OpSetCustomPropertiesOfRoom(Hashtable propertiesToSet, [Optional] Hashtable expectedProperties, [Optional] WebFlags webFlags)
		{
			return default(bool);
		}

		[Token(Token = "0x600087C")]
		[Address(RVA = "0x132EE38", Offset = "0x132EE38", VA = "0x132EE38")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x9DFE7C", Offset = "0x9DFE7C")]
		public bool OpSetCustomPropertiesOfRoom(Hashtable propertiesToSet, Hashtable expectedProperties, bool webForward)
		{
			return default(bool);
		}

		[Token(Token = "0x600087D")]
		[Address(RVA = "0x132ECF8", Offset = "0x132ECF8", VA = "0x132ECF8")]
		protected internal bool OpSetPropertiesOfRoom(Hashtable gameProperties, [Optional] Hashtable expectedProperties, [Optional] WebFlags webFlags)
		{
			return default(bool);
		}

		[Token(Token = "0x600087E")]
		[Address(RVA = "0x132F13C", Offset = "0x132F13C", VA = "0x132F13C", Slot = "9")]
		public virtual bool OpRaiseEvent(byte eventCode, object customEventContent, RaiseEventOptions raiseEventOptions, SendOptions sendOptions)
		{
			return default(bool);
		}

		[Token(Token = "0x600087F")]
		[Address(RVA = "0x132F158", Offset = "0x132F158", VA = "0x132F158", Slot = "10")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x9DFEB4", Offset = "0x9DFEB4")]
		public virtual bool OpRaiseEvent(byte eventCode, object customEventContent, bool sendReliable, RaiseEventOptions raiseEventOptions)
		{
			return default(bool);
		}

		[Token(Token = "0x6000880")]
		[Address(RVA = "0x132F1F0", Offset = "0x132F1F0", VA = "0x132F1F0", Slot = "11")]
		public virtual bool OpChangeGroups(byte[] groupsToRemove, byte[] groupsToAdd)
		{
			return default(bool);
		}

		[Token(Token = "0x6000881")]
		[Address(RVA = "0x132F20C", Offset = "0x132F20C", VA = "0x132F20C")]
		private void ReadoutProperties(Hashtable gameProperties, Hashtable actorProperties, int targetActorNr)
		{
		}

		[Token(Token = "0x6000882")]
		[Address(RVA = "0x132F5BC", Offset = "0x132F5BC", VA = "0x132F5BC")]
		private Hashtable ReadoutPropertiesForActorNr(Hashtable actorProperties, int actorNr)
		{
			return null;
		}

		[Token(Token = "0x6000883")]
		[Address(RVA = "0x132F6D0", Offset = "0x132F6D0", VA = "0x132F6D0")]
		protected internal void ChangeLocalID(int newID)
		{
		}

		[Token(Token = "0x6000884")]
		[Address(RVA = "0x132F864", Offset = "0x132F864", VA = "0x132F864")]
		private void CleanCachedValues()
		{
		}

		[Token(Token = "0x6000885")]
		[Address(RVA = "0x132F914", Offset = "0x132F914", VA = "0x132F914")]
		private void GameEnteredOnGameServer(OperationResponse operationResponse)
		{
		}

		[Token(Token = "0x6000886")]
		[Address(RVA = "0x132FBA8", Offset = "0x132FBA8", VA = "0x132FBA8")]
		private void UpdatedActorList(int[] actorsInGame)
		{
		}

		[Token(Token = "0x6000887")]
		[Address(RVA = "0x132FCC4", Offset = "0x132FCC4", VA = "0x132FCC4", Slot = "12")]
		protected internal virtual Player CreatePlayer(string actorName, int actorNumber, bool isLocal, Hashtable actorProperties)
		{
			return null;
		}

		[Token(Token = "0x6000888")]
		[Address(RVA = "0x132FE08", Offset = "0x132FE08", VA = "0x132FE08", Slot = "13")]
		protected internal virtual Room CreateRoom(string roomName, RoomOptions opt)
		{
			return null;
		}

		[Token(Token = "0x6000889")]
		[Address(RVA = "0x132FF50", Offset = "0x132FF50", VA = "0x132FF50", Slot = "14")]
		public virtual void DebugReturn(DebugLevel level, string message)
		{
		}

		[Token(Token = "0x600088A")]
		[Address(RVA = "0x1330068", Offset = "0x1330068", VA = "0x1330068", Slot = "15")]
		public virtual void OnOperationResponse(OperationResponse operationResponse)
		{
		}

		[Token(Token = "0x600088B")]
		[Address(RVA = "0x1331294", Offset = "0x1331294", VA = "0x1331294", Slot = "16")]
		public virtual void OnStatusChanged(StatusCode statusCode)
		{
		}

		[Token(Token = "0x600088C")]
		[Address(RVA = "0x1331904", Offset = "0x1331904", VA = "0x1331904", Slot = "17")]
		public virtual void OnEvent(EventData photonEvent)
		{
		}

		[Token(Token = "0x600088D")]
		[Address(RVA = "0x13324C8", Offset = "0x13324C8", VA = "0x13324C8", Slot = "18")]
		public virtual void OnMessage(object message)
		{
		}

		[Token(Token = "0x600088E")]
		[Address(RVA = "0x1330ED0", Offset = "0x1330ED0", VA = "0x1330ED0")]
		private void SetupEncryption(Dictionary<byte, object> encryptionData)
		{
		}

		[Token(Token = "0x600088F")]
		[Address(RVA = "0x1332544", Offset = "0x1332544", VA = "0x1332544")]
		public bool OpWebRpc(string uriPath, object parameters, bool sendAuthCookie = false)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x200010D")]
	public class LoadBalancingPeer : PhotonPeer
	{
		[Token(Token = "0x20001AF")]
		private enum RoomOptionBit
		{
			[Token(Token = "0x4000A71")]
			CheckUserOnJoin = 1,
			[Token(Token = "0x4000A72")]
			DeleteCacheOnLeave = 2,
			[Token(Token = "0x4000A73")]
			SuppressRoomEvents = 4,
			[Token(Token = "0x4000A74")]
			PublishUserId = 8,
			[Token(Token = "0x4000A75")]
			DeleteNullProps = 0x10,
			[Token(Token = "0x4000A76")]
			BroadcastPropsChangeToAll = 0x20
		}

		[Token(Token = "0x40006CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		protected internal static Type PingImplementation;

		[Token(Token = "0x40006CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private readonly Dictionary<byte, object> opParameters;

		[Token(Token = "0x6000891")]
		[Address(RVA = "0x133280C", Offset = "0x133280C", VA = "0x133280C")]
		public LoadBalancingPeer(ConnectionProtocol protocolType)
		{
		}

		[Token(Token = "0x6000892")]
		[Address(RVA = "0x132D098", Offset = "0x132D098", VA = "0x132D098")]
		public LoadBalancingPeer(IPhotonPeerListener listener, ConnectionProtocol protocolType)
		{
		}

		[Token(Token = "0x6000893")]
		[Address(RVA = "0x13328B4", Offset = "0x13328B4", VA = "0x13328B4")]
		[AttributeAttribute(Name = "ConditionalAttribute", RVA = "0x9DFEEC", Offset = "0x9DFEEC")]
		private void ConfigUnitySockets()
		{
		}

		[Token(Token = "0x6000894")]
		[Address(RVA = "0x1332B34", Offset = "0x1332B34", VA = "0x1332B34", Slot = "19")]
		public virtual bool OpGetRegions(string appId)
		{
			return default(bool);
		}

		[Token(Token = "0x6000895")]
		[Address(RVA = "0x1332C10", Offset = "0x1332C10", VA = "0x1332C10", Slot = "20")]
		public virtual bool OpJoinLobby([Optional] TypedLobby lobby)
		{
			return default(bool);
		}

		[Token(Token = "0x6000896")]
		[Address(RVA = "0x1332E1C", Offset = "0x1332E1C", VA = "0x1332E1C", Slot = "21")]
		public virtual bool OpLeaveLobby()
		{
			return default(bool);
		}

		[Token(Token = "0x6000897")]
		[Address(RVA = "0x1332F40", Offset = "0x1332F40", VA = "0x1332F40")]
		private void RoomOptionsToOpParameters(Dictionary<byte, object> op, RoomOptions roomOptions)
		{
		}

		[Token(Token = "0x6000898")]
		[Address(RVA = "0x13334C0", Offset = "0x13334C0", VA = "0x13334C0", Slot = "22")]
		public virtual bool OpCreateRoom(EnterRoomParams opParams)
		{
			return default(bool);
		}

		[Token(Token = "0x6000899")]
		[Address(RVA = "0x13337E0", Offset = "0x13337E0", VA = "0x13337E0", Slot = "23")]
		public virtual bool OpJoinRoom(EnterRoomParams opParams)
		{
			return default(bool);
		}

		[Token(Token = "0x600089A")]
		[Address(RVA = "0x1333B78", Offset = "0x1333B78", VA = "0x1333B78", Slot = "24")]
		public virtual bool OpJoinRandomRoom(OpJoinRandomRoomParams opJoinRandomRoomParams)
		{
			return default(bool);
		}

		[Token(Token = "0x600089B")]
		[Address(RVA = "0x1333F38", Offset = "0x1333F38", VA = "0x1333F38", Slot = "25")]
		public virtual bool OpLeaveRoom(bool becomeInactive, bool sendAuthCookie = false)
		{
			return default(bool);
		}

		[Token(Token = "0x600089C")]
		[Address(RVA = "0x1334088", Offset = "0x1334088", VA = "0x1334088", Slot = "26")]
		public virtual bool OpGetGameList(TypedLobby lobby, string queryData)
		{
			return default(bool);
		}

		[Token(Token = "0x600089D")]
		[Address(RVA = "0x13343B4", Offset = "0x13343B4", VA = "0x13343B4", Slot = "27")]
		public virtual bool OpFindFriends(string[] friendsToFind)
		{
			return default(bool);
		}

		[Token(Token = "0x600089E")]
		[Address(RVA = "0x1334494", Offset = "0x1334494", VA = "0x1334494")]
		public bool OpSetCustomPropertiesOfActor(int actorNr, Hashtable actorProperties)
		{
			return default(bool);
		}

		[Token(Token = "0x600089F")]
		[Address(RVA = "0x132E910", Offset = "0x132E910", VA = "0x132E910")]
		protected internal bool OpSetPropertiesOfActor(int actorNr, Hashtable actorProperties, [Optional] Hashtable expectedProperties, [Optional] WebFlags webflags)
		{
			return default(bool);
		}

		[Token(Token = "0x60008A0")]
		[Address(RVA = "0x13344DC", Offset = "0x13344DC", VA = "0x13344DC")]
		protected void OpSetPropertyOfRoom(byte propCode, object value)
		{
		}

		[Token(Token = "0x60008A1")]
		[Address(RVA = "0x13345A0", Offset = "0x13345A0", VA = "0x13345A0")]
		public bool OpSetCustomPropertiesOfRoom(Hashtable gameProperties)
		{
			return default(bool);
		}

		[Token(Token = "0x60008A2")]
		[Address(RVA = "0x132EEE4", Offset = "0x132EEE4", VA = "0x132EEE4")]
		protected internal bool OpSetPropertiesOfRoom(Hashtable gameProperties, [Optional] Hashtable expectedProperties, [Optional] WebFlags webflags)
		{
			return default(bool);
		}

		[Token(Token = "0x60008A3")]
		[Address(RVA = "0x13345D4", Offset = "0x13345D4", VA = "0x13345D4", Slot = "28")]
		public virtual bool OpAuthenticate(string appId, string appVersion, AuthenticationValues authValues, string regionCode, bool getLobbyStatistics)
		{
			return default(bool);
		}

		[Token(Token = "0x60008A4")]
		[Address(RVA = "0x1334998", Offset = "0x1334998", VA = "0x1334998", Slot = "29")]
		public virtual bool OpAuthenticateOnce(string appId, string appVersion, AuthenticationValues authValues, string regionCode, EncryptionMode encryptionMode, ConnectionProtocol expectedProtocol)
		{
			return default(bool);
		}

		[Token(Token = "0x60008A5")]
		[Address(RVA = "0x1334D84", Offset = "0x1334D84", VA = "0x1334D84", Slot = "30")]
		public virtual bool OpChangeGroups(byte[] groupsToRemove, byte[] groupsToAdd)
		{
			return default(bool);
		}

		[Token(Token = "0x60008A6")]
		[Address(RVA = "0x1334F34", Offset = "0x1334F34", VA = "0x1334F34", Slot = "31")]
		public virtual bool OpRaiseEvent(byte eventCode, object customEventContent, RaiseEventOptions raiseEventOptions, SendOptions sendOptions)
		{
			return default(bool);
		}

		[Token(Token = "0x60008A7")]
		[Address(RVA = "0x13351D4", Offset = "0x13351D4", VA = "0x13351D4", Slot = "32")]
		public virtual bool OpSettings(bool receiveLobbyStats)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x200010E")]
	public class OpJoinRandomRoomParams
	{
		[Token(Token = "0x40006CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Hashtable ExpectedCustomRoomProperties;

		[Token(Token = "0x40006CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public byte ExpectedMaxPlayers;

		[Token(Token = "0x40006CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		public MatchmakingMode MatchingType;

		[Token(Token = "0x40006CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public TypedLobby TypedLobby;

		[Token(Token = "0x40006D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string SqlLobbyFilter;

		[Token(Token = "0x40006D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string[] ExpectedUsers;

		[Token(Token = "0x60008A9")]
		[Address(RVA = "0x132DEE8", Offset = "0x132DEE8", VA = "0x132DEE8")]
		public OpJoinRandomRoomParams()
		{
		}
	}
	[Token(Token = "0x200010F")]
	public class EnterRoomParams
	{
		[Token(Token = "0x40006D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string RoomName;

		[Token(Token = "0x40006D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public RoomOptions RoomOptions;

		[Token(Token = "0x40006D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public TypedLobby Lobby;

		[Token(Token = "0x40006D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Hashtable PlayerProperties;

		[Token(Token = "0x40006D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool OnGameServer;

		[Token(Token = "0x40006D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
		public bool CreateIfNotExists;

		[Token(Token = "0x40006D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x32")]
		public bool RejoinOnly;

		[Token(Token = "0x40006D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public string[] ExpectedUsers;

		[Token(Token = "0x60008AA")]
		[Address(RVA = "0x132B138", Offset = "0x132B138", VA = "0x132B138")]
		public EnterRoomParams()
		{
		}
	}
	[Token(Token = "0x2000110")]
	public class ErrorCode
	{
		[Token(Token = "0x40006DA")]
		public const int Ok = 0;

		[Token(Token = "0x40006DB")]
		public const int OperationNotAllowedInCurrentState = -3;

		[Token(Token = "0x40006DC")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x9DA74C", Offset = "0x9DA74C")]
		public const int InvalidOperationCode = -2;

		[Token(Token = "0x40006DD")]
		public const int InvalidOperation = -2;

		[Token(Token = "0x40006DE")]
		public const int InternalServerError = -1;

		[Token(Token = "0x40006DF")]
		public const int InvalidAuthentication = 32767;

		[Token(Token = "0x40006E0")]
		public const int GameIdAlreadyExists = 32766;

		[Token(Token = "0x40006E1")]
		public const int GameFull = 32765;

		[Token(Token = "0x40006E2")]
		public const int GameClosed = 32764;

		[Token(Token = "0x40006E3")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x9DA784", Offset = "0x9DA784")]
		public const int AlreadyMatched = 32763;

		[Token(Token = "0x40006E4")]
		public const int ServerFull = 32762;

		[Token(Token = "0x40006E5")]
		public const int UserBlocked = 32761;

		[Token(Token = "0x40006E6")]
		public const int NoRandomMatchFound = 32760;

		[Token(Token = "0x40006E7")]
		public const int GameDoesNotExist = 32758;

		[Token(Token = "0x40006E8")]
		public const int MaxCcuReached = 32757;

		[Token(Token = "0x40006E9")]
		public const int InvalidRegion = 32756;

		[Token(Token = "0x40006EA")]
		public const int CustomAuthenticationFailed = 32755;

		[Token(Token = "0x40006EB")]
		public const int AuthenticationTicketExpired = 32753;

		[Token(Token = "0x40006EC")]
		public const int PluginReportedError = 32752;

		[Token(Token = "0x40006ED")]
		public const int PluginMismatch = 32751;

		[Token(Token = "0x40006EE")]
		public const int JoinFailedPeerAlreadyJoined = 32750;

		[Token(Token = "0x40006EF")]
		public const int JoinFailedFoundInactiveJoiner = 32749;

		[Token(Token = "0x40006F0")]
		public const int JoinFailedWithRejoinerNotFound = 32748;

		[Token(Token = "0x40006F1")]
		public const int JoinFailedFoundExcludedUserId = 32747;

		[Token(Token = "0x40006F2")]
		public const int JoinFailedFoundActiveJoiner = 32746;

		[Token(Token = "0x40006F3")]
		public const int HttpLimitReached = 32745;

		[Token(Token = "0x40006F4")]
		public const int ExternalHttpCallFailed = 32744;

		[Token(Token = "0x40006F5")]
		public const int SlotError = 32742;

		[Token(Token = "0x40006F6")]
		public const int InvalidEncryptionParameters = 32741;

		[Token(Token = "0x60008AB")]
		[Address(RVA = "0x132B148", Offset = "0x132B148", VA = "0x132B148")]
		public ErrorCode()
		{
		}
	}
	[Token(Token = "0x2000111")]
	public class ActorProperties
	{
		[Token(Token = "0x40006F7")]
		public const byte PlayerName = byte.MaxValue;

		[Token(Token = "0x40006F8")]
		public const byte IsInactive = 254;

		[Token(Token = "0x40006F9")]
		public const byte UserId = 253;

		[Token(Token = "0x60008AC")]
		[Address(RVA = "0x132AD98", Offset = "0x132AD98", VA = "0x132AD98")]
		public ActorProperties()
		{
		}
	}
	[Token(Token = "0x2000112")]
	public class GamePropertyKey
	{
		[Token(Token = "0x40006FA")]
		public const byte MaxPlayers = byte.MaxValue;

		[Token(Token = "0x40006FB")]
		public const byte IsVisible = 254;

		[Token(Token = "0x40006FC")]
		public const byte IsOpen = 253;

		[Token(Token = "0x40006FD")]
		public const byte PlayerCount = 252;

		[Token(Token = "0x40006FE")]
		public const byte Removed = 251;

		[Token(Token = "0x40006FF")]
		public const byte PropsListedInLobby = 250;

		[Token(Token = "0x4000700")]
		public const byte CleanupCacheOnLeave = 249;

		[Token(Token = "0x4000701")]
		public const byte MasterClientId = 248;

		[Token(Token = "0x4000702")]
		public const byte ExpectedUsers = 247;

		[Token(Token = "0x60008AD")]
		[Address(RVA = "0x132C3CC", Offset = "0x132C3CC", VA = "0x132C3CC")]
		public GamePropertyKey()
		{
		}
	}
	[Token(Token = "0x2000113")]
	public class EventCode
	{
		[Token(Token = "0x4000703")]
		public const byte GameList = 230;

		[Token(Token = "0x4000704")]
		public const byte GameListUpdate = 229;

		[Token(Token = "0x4000705")]
		public const byte QueueState = 228;

		[Token(Token = "0x4000706")]
		public const byte Match = 227;

		[Token(Token = "0x4000707")]
		public const byte AppStats = 226;

		[Token(Token = "0x4000708")]
		public const byte LobbyStats = 224;

		[Token(Token = "0x4000709")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x9DA7BC", Offset = "0x9DA7BC")]
		public const byte AzureNodeInfo = 210;

		[Token(Token = "0x400070A")]
		public const byte Join = byte.MaxValue;

		[Token(Token = "0x400070B")]
		public const byte Leave = 254;

		[Token(Token = "0x400070C")]
		public const byte PropertiesChanged = 253;

		[Token(Token = "0x400070D")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x9DA7F4", Offset = "0x9DA7F4")]
		public const byte SetProperties = 253;

		[Token(Token = "0x400070E")]
		public const byte ErrorInfo = 251;

		[Token(Token = "0x400070F")]
		public const byte CacheSliceChanged = 250;

		[Token(Token = "0x4000710")]
		public const byte AuthEvent = 223;

		[Token(Token = "0x60008AE")]
		[Address(RVA = "0x132B150", Offset = "0x132B150", VA = "0x132B150")]
		public EventCode()
		{
		}
	}
	[Token(Token = "0x2000114")]
	public class ParameterCode
	{
		[Token(Token = "0x4000711")]
		public const byte SuppressRoomEvents = 237;

		[Token(Token = "0x4000712")]
		public const byte EmptyRoomTTL = 236;

		[Token(Token = "0x4000713")]
		public const byte PlayerTTL = 235;

		[Token(Token = "0x4000714")]
		public const byte EventForward = 234;

		[Token(Token = "0x4000715")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x9DA82C", Offset = "0x9DA82C")]
		public const byte IsComingBack = 233;

		[Token(Token = "0x4000716")]
		public const byte IsInactive = 233;

		[Token(Token = "0x4000717")]
		public const byte CheckUserOnJoin = 232;

		[Token(Token = "0x4000718")]
		public const byte ExpectedValues = 231;

		[Token(Token = "0x4000719")]
		public const byte Address = 230;

		[Token(Token = "0x400071A")]
		public const byte PeerCount = 229;

		[Token(Token = "0x400071B")]
		public const byte GameCount = 228;

		[Token(Token = "0x400071C")]
		public const byte MasterPeerCount = 227;

		[Token(Token = "0x400071D")]
		public const byte UserId = 225;

		[Token(Token = "0x400071E")]
		public const byte ApplicationId = 224;

		[Token(Token = "0x400071F")]
		public const byte Position = 223;

		[Token(Token = "0x4000720")]
		public const byte MatchMakingType = 223;

		[Token(Token = "0x4000721")]
		public const byte GameList = 222;

		[Token(Token = "0x4000722")]
		public const byte Secret = 221;

		[Token(Token = "0x4000723")]
		public const byte AppVersion = 220;

		[Token(Token = "0x4000724")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x9DA864", Offset = "0x9DA864")]
		public const byte AzureNodeInfo = 210;

		[Token(Token = "0x4000725")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x9DA89C", Offset = "0x9DA89C")]
		public const byte AzureLocalNodeId = 209;

		[Token(Token = "0x4000726")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x9DA8D4", Offset = "0x9DA8D4")]
		public const byte AzureMasterNodeId = 208;

		[Token(Token = "0x4000727")]
		public const byte RoomName = byte.MaxValue;

		[Token(Token = "0x4000728")]
		public const byte Broadcast = 250;

		[Token(Token = "0x4000729")]
		public const byte ActorList = 252;

		[Token(Token = "0x400072A")]
		public const byte ActorNr = 254;

		[Token(Token = "0x400072B")]
		public const byte PlayerProperties = 249;

		[Token(Token = "0x400072C")]
		public const byte CustomEventContent = 245;

		[Token(Token = "0x400072D")]
		public const byte Data = 245;

		[Token(Token = "0x400072E")]
		public const byte Code = 244;

		[Token(Token = "0x400072F")]
		public const byte GameProperties = 248;

		[Token(Token = "0x4000730")]
		public const byte Properties = 251;

		[Token(Token = "0x4000731")]
		public const byte TargetActorNr = 253;

		[Token(Token = "0x4000732")]
		public const byte ReceiverGroup = 246;

		[Token(Token = "0x4000733")]
		public const byte Cache = 247;

		[Token(Token = "0x4000734")]
		public const byte CleanupCacheOnLeave = 241;

		[Token(Token = "0x4000735")]
		public const byte Group = 240;

		[Token(Token = "0x4000736")]
		public const byte Remove = 239;

		[Token(Token = "0x4000737")]
		public const byte PublishUserId = 239;

		[Token(Token = "0x4000738")]
		public const byte Add = 238;

		[Token(Token = "0x4000739")]
		public const byte Info = 218;

		[Token(Token = "0x400073A")]
		public const byte ClientAuthenticationType = 217;

		[Token(Token = "0x400073B")]
		public const byte ClientAuthenticationParams = 216;

		[Token(Token = "0x400073C")]
		public const byte JoinMode = 215;

		[Token(Token = "0x400073D")]
		public const byte ClientAuthenticationData = 214;

		[Token(Token = "0x400073E")]
		public const byte MasterClientId = 203;

		[Token(Token = "0x400073F")]
		public const byte FindFriendsRequestList = 1;

		[Token(Token = "0x4000740")]
		public const byte FindFriendsResponseOnlineList = 1;

		[Token(Token = "0x4000741")]
		public const byte FindFriendsResponseRoomIdList = 2;

		[Token(Token = "0x4000742")]
		public const byte LobbyName = 213;

		[Token(Token = "0x4000743")]
		public const byte LobbyType = 212;

		[Token(Token = "0x4000744")]
		public const byte LobbyStats = 211;

		[Token(Token = "0x4000745")]
		public const byte Region = 210;

		[Token(Token = "0x4000746")]
		public const byte UriPath = 209;

		[Token(Token = "0x4000747")]
		public const byte WebRpcParameters = 208;

		[Token(Token = "0x4000748")]
		public const byte WebRpcReturnCode = 207;

		[Token(Token = "0x4000749")]
		public const byte WebRpcReturnMessage = 206;

		[Token(Token = "0x400074A")]
		public const byte CacheSliceIndex = 205;

		[Token(Token = "0x400074B")]
		public const byte Plugins = 204;

		[Token(Token = "0x400074C")]
		public const byte NickName = 202;

		[Token(Token = "0x400074D")]
		public const byte PluginName = 201;

		[Token(Token = "0x400074E")]
		public const byte PluginVersion = 200;

		[Token(Token = "0x400074F")]
		public const byte ExpectedProtocol = 195;

		[Token(Token = "0x4000750")]
		public const byte CustomInitData = 194;

		[Token(Token = "0x4000751")]
		public const byte EncryptionMode = 193;

		[Token(Token = "0x4000752")]
		public const byte EncryptionData = 192;

		[Token(Token = "0x4000753")]
		public const byte RoomOptionFlags = 191;

		[Token(Token = "0x60008AF")]
		[Address(RVA = "0x13353B8", Offset = "0x13353B8", VA = "0x13353B8")]
		public ParameterCode()
		{
		}
	}
	[Token(Token = "0x2000115")]
	public class OperationCode
	{
		[Token(Token = "0x4000754")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x9DA90C", Offset = "0x9DA90C")]
		public const byte ExchangeKeysForEncryption = 250;

		[Token(Token = "0x4000755")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x9DA944", Offset = "0x9DA944")]
		public const byte Join = byte.MaxValue;

		[Token(Token = "0x4000756")]
		public const byte AuthenticateOnce = 231;

		[Token(Token = "0x4000757")]
		public const byte Authenticate = 230;

		[Token(Token = "0x4000758")]
		public const byte JoinLobby = 229;

		[Token(Token = "0x4000759")]
		public const byte LeaveLobby = 228;

		[Token(Token = "0x400075A")]
		public const byte CreateGame = 227;

		[Token(Token = "0x400075B")]
		public const byte JoinGame = 226;

		[Token(Token = "0x400075C")]
		public const byte JoinRandomGame = 225;

		[Token(Token = "0x400075D")]
		public const byte Leave = 254;

		[Token(Token = "0x400075E")]
		public const byte RaiseEvent = 253;

		[Token(Token = "0x400075F")]
		public const byte SetProperties = 252;

		[Token(Token = "0x4000760")]
		public const byte GetProperties = 251;

		[Token(Token = "0x4000761")]
		public const byte ChangeGroups = 248;

		[Token(Token = "0x4000762")]
		public const byte FindFriends = 222;

		[Token(Token = "0x4000763")]
		public const byte GetLobbyStats = 221;

		[Token(Token = "0x4000764")]
		public const byte GetRegions = 220;

		[Token(Token = "0x4000765")]
		public const byte WebRpc = 219;

		[Token(Token = "0x4000766")]
		public const byte ServerSettings = 218;

		[Token(Token = "0x4000767")]
		public const byte GetGameList = 217;

		[Token(Token = "0x60008B0")]
		[Address(RVA = "0x13353B0", Offset = "0x13353B0", VA = "0x13353B0")]
		public OperationCode()
		{
		}
	}
	[Token(Token = "0x2000116")]
	public enum JoinMode : byte
	{
		[Token(Token = "0x4000769")]
		Default,
		[Token(Token = "0x400076A")]
		CreateIfNotExists,
		[Token(Token = "0x400076B")]
		JoinOrRejoin,
		[Token(Token = "0x400076C")]
		RejoinOnly
	}
	[Token(Token = "0x2000117")]
	public enum MatchmakingMode : byte
	{
		[Token(Token = "0x400076E")]
		FillRoom,
		[Token(Token = "0x400076F")]
		SerialMatching,
		[Token(Token = "0x4000770")]
		RandomMatching
	}
	[Token(Token = "0x2000118")]
	public enum ReceiverGroup : byte
	{
		[Token(Token = "0x4000772")]
		Others,
		[Token(Token = "0x4000773")]
		All,
		[Token(Token = "0x4000774")]
		MasterClient
	}
	[Token(Token = "0x2000119")]
	public enum EventCaching : byte
	{
		[Token(Token = "0x4000776")]
		DoNotCache = 0,
		[Token(Token = "0x4000777")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x9DA954", Offset = "0x9DA954")]
		MergeCache = 1,
		[Token(Token = "0x4000778")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x9DA964", Offset = "0x9DA964")]
		ReplaceCache = 2,
		[Token(Token = "0x4000779")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x9DA974", Offset = "0x9DA974")]
		RemoveCache = 3,
		[Token(Token = "0x400077A")]
		AddToRoomCache = 4,
		[Token(Token = "0x400077B")]
		AddToRoomCacheGlobal = 5,
		[Token(Token = "0x400077C")]
		RemoveFromRoomCache = 6,
		[Token(Token = "0x400077D")]
		RemoveFromRoomCacheForActorsLeft = 7,
		[Token(Token = "0x400077E")]
		SliceIncreaseIndex = 10,
		[Token(Token = "0x400077F")]
		SliceSetIndex = 11,
		[Token(Token = "0x4000780")]
		SlicePurgeIndex = 12,
		[Token(Token = "0x4000781")]
		SlicePurgeUpToIndex = 13
	}
	[Token(Token = "0x200011A")]
	[Flags]
	public enum PropertyTypeFlag : byte
	{
		[Token(Token = "0x4000783")]
		None = 0,
		[Token(Token = "0x4000784")]
		Game = 1,
		[Token(Token = "0x4000785")]
		Actor = 2,
		[Token(Token = "0x4000786")]
		GameAndActor = 3
	}
	[Token(Token = "0x200011B")]
	public class RoomOptions
	{
		[Token(Token = "0x4000787")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private bool isVisible;

		[Token(Token = "0x4000788")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11")]
		private bool isOpen;

		[Token(Token = "0x4000789")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x12")]
		public byte MaxPlayers;

		[Token(Token = "0x400078A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public int PlayerTtl;

		[Token(Token = "0x400078B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int EmptyRoomTtl;

		[Token(Token = "0x400078C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private bool cleanupCacheOnLeave;

		[Token(Token = "0x400078D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Hashtable CustomRoomProperties;

		[Token(Token = "0x400078E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string[] CustomRoomPropertiesForLobby;

		[Token(Token = "0x400078F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string[] Plugins;

		[Token(Token = "0x4000790")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DA984", Offset = "0x9DA984")]
		private bool <SuppressRoomEvents>k__BackingField;

		[Token(Token = "0x4000791")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x39")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DA994", Offset = "0x9DA994")]
		private bool <PublishUserId>k__BackingField;

		[Token(Token = "0x4000792")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3A")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DA9A4", Offset = "0x9DA9A4")]
		private bool <DeleteNullProperties>k__BackingField;

		[Token(Token = "0x1700014F")]
		public bool IsVisible
		{
			[Token(Token = "0x60008B1")]
			[Address(RVA = "0x1333498", Offset = "0x1333498", VA = "0x1333498")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60008B2")]
			[Address(RVA = "0x1337AFC", Offset = "0x1337AFC", VA = "0x1337AFC")]
			set
			{
			}
		}

		[Token(Token = "0x17000150")]
		public bool IsOpen
		{
			[Token(Token = "0x60008B3")]
			[Address(RVA = "0x1333490", Offset = "0x1333490", VA = "0x1333490")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60008B4")]
			[Address(RVA = "0x1337B08", Offset = "0x1337B08", VA = "0x1337B08")]
			set
			{
			}
		}

		[Token(Token = "0x17000151")]
		public bool CleanupCacheOnLeave
		{
			[Token(Token = "0x60008B5")]
			[Address(RVA = "0x13334A0", Offset = "0x13334A0", VA = "0x13334A0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60008B6")]
			[Address(RVA = "0x1337B14", Offset = "0x1337B14", VA = "0x1337B14")]
			set
			{
			}
		}

		[Token(Token = "0x17000152")]
		public bool SuppressRoomEvents
		{
			[Token(Token = "0x60008B7")]
			[Address(RVA = "0x13334A8", Offset = "0x13334A8", VA = "0x13334A8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DFF24", Offset = "0x9DFF24")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60008B8")]
			[Address(RVA = "0x1337B20", Offset = "0x1337B20", VA = "0x1337B20")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DFF34", Offset = "0x9DFF34")]
			set
			{
			}
		}

		[Token(Token = "0x17000153")]
		public bool PublishUserId
		{
			[Token(Token = "0x60008B9")]
			[Address(RVA = "0x13334B0", Offset = "0x13334B0", VA = "0x13334B0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DFF44", Offset = "0x9DFF44")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60008BA")]
			[Address(RVA = "0x1337B2C", Offset = "0x1337B2C", VA = "0x1337B2C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DFF54", Offset = "0x9DFF54")]
			set
			{
			}
		}

		[Token(Token = "0x17000154")]
		public bool DeleteNullProperties
		{
			[Token(Token = "0x60008BB")]
			[Address(RVA = "0x13334B8", Offset = "0x13334B8", VA = "0x13334B8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DFF64", Offset = "0x9DFF64")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60008BC")]
			[Address(RVA = "0x1337B38", Offset = "0x1337B38", VA = "0x1337B38")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DFF74", Offset = "0x9DFF74")]
			set
			{
			}
		}

		[Token(Token = "0x60008BD")]
		[Address(RVA = "0x1333420", Offset = "0x1333420", VA = "0x1333420")]
		public RoomOptions()
		{
		}
	}
	[Token(Token = "0x200011C")]
	public class RaiseEventOptions
	{
		[Token(Token = "0x4000793")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly RaiseEventOptions Default;

		[Token(Token = "0x4000794")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public EventCaching CachingOption;

		[Token(Token = "0x4000795")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11")]
		public byte InterestGroup;

		[Token(Token = "0x4000796")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int[] TargetActors;

		[Token(Token = "0x4000797")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ReceiverGroup Receivers;

		[Token(Token = "0x4000798")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x9DA9B4", Offset = "0x9DA9B4")]
		public byte SequenceChannel;

		[Token(Token = "0x4000799")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public WebFlags Flags;

		[Token(Token = "0x60008BE")]
		[Address(RVA = "0x1335D0C", Offset = "0x1335D0C", VA = "0x1335D0C")]
		public RaiseEventOptions()
		{
		}
	}
	[Token(Token = "0x200011D")]
	public enum LobbyType : byte
	{
		[Token(Token = "0x400079B")]
		Default = 0,
		[Token(Token = "0x400079C")]
		SqlLobby = 2,
		[Token(Token = "0x400079D")]
		AsyncRandomLobby = 3
	}
	[Token(Token = "0x200011E")]
	public class TypedLobby
	{
		[Token(Token = "0x400079E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string Name;

		[Token(Token = "0x400079F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public LobbyType Type;

		[Token(Token = "0x40007A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly TypedLobby Default;

		[Token(Token = "0x17000155")]
		public bool IsDefault
		{
			[Token(Token = "0x60008C0")]
			[Address(RVA = "0x1332E00", Offset = "0x1332E00", VA = "0x1332E00")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60008C1")]
		[Address(RVA = "0x1337B44", Offset = "0x1337B44", VA = "0x1337B44")]
		public TypedLobby()
		{
		}

		[Token(Token = "0x60008C2")]
		[Address(RVA = "0x1337BAC", Offset = "0x1337BAC", VA = "0x1337BAC")]
		public TypedLobby(string name, LobbyType type)
		{
		}

		[Token(Token = "0x60008C3")]
		[Address(RVA = "0x1337BE8", Offset = "0x1337BE8", VA = "0x1337BE8", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Token(Token = "0x200011F")]
	public class TypedLobbyInfo : TypedLobby
	{
		[Token(Token = "0x40007A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public int PlayerCount;

		[Token(Token = "0x40007A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public int RoomCount;

		[Token(Token = "0x60008C5")]
		[Address(RVA = "0x1337CD0", Offset = "0x1337CD0", VA = "0x1337CD0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x60008C6")]
		[Address(RVA = "0x1332464", Offset = "0x1332464", VA = "0x1332464")]
		public TypedLobbyInfo()
		{
		}
	}
	[Token(Token = "0x2000120")]
	public enum AuthModeOption
	{
		[Token(Token = "0x40007A4")]
		Auth,
		[Token(Token = "0x40007A5")]
		AuthOnce,
		[Token(Token = "0x40007A6")]
		AuthOnceWss
	}
	[Token(Token = "0x2000121")]
	public enum CustomAuthenticationType : byte
	{
		[Token(Token = "0x40007A8")]
		Custom = 0,
		[Token(Token = "0x40007A9")]
		Steam = 1,
		[Token(Token = "0x40007AA")]
		Facebook = 2,
		[Token(Token = "0x40007AB")]
		Oculus = 3,
		[Token(Token = "0x40007AC")]
		PlayStation = 4,
		[Token(Token = "0x40007AD")]
		Xbox = 5,
		[Token(Token = "0x40007AE")]
		None = byte.MaxValue
	}
	[Token(Token = "0x2000122")]
	public class AuthenticationValues
	{
		[Token(Token = "0x40007AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private CustomAuthenticationType authType;

		[Token(Token = "0x40007B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DA9EC", Offset = "0x9DA9EC")]
		private string <AuthGetParameters>k__BackingField;

		[Token(Token = "0x40007B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DA9FC", Offset = "0x9DA9FC")]
		private object <AuthPostData>k__BackingField;

		[Token(Token = "0x40007B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DAA0C", Offset = "0x9DAA0C")]
		private string <Token>k__BackingField;

		[Token(Token = "0x40007B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DAA1C", Offset = "0x9DAA1C")]
		private string <UserId>k__BackingField;

		[Token(Token = "0x17000156")]
		public CustomAuthenticationType AuthType
		{
			[Token(Token = "0x60008C7")]
			[Address(RVA = "0x132ADA0", Offset = "0x132ADA0", VA = "0x132ADA0")]
			get
			{
				return default(CustomAuthenticationType);
			}
			[Token(Token = "0x60008C8")]
			[Address(RVA = "0x132ADA8", Offset = "0x132ADA8", VA = "0x132ADA8")]
			set
			{
			}
		}

		[Token(Token = "0x17000157")]
		public string AuthGetParameters
		{
			[Token(Token = "0x60008C9")]
			[Address(RVA = "0x132ADB0", Offset = "0x132ADB0", VA = "0x132ADB0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DFF84", Offset = "0x9DFF84")]
			get
			{
				return null;
			}
			[Token(Token = "0x60008CA")]
			[Address(RVA = "0x132ADB8", Offset = "0x132ADB8", VA = "0x132ADB8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DFF94", Offset = "0x9DFF94")]
			set
			{
			}
		}

		[Token(Token = "0x17000158")]
		public object AuthPostData
		{
			[Token(Token = "0x60008CB")]
			[Address(RVA = "0x132ADC0", Offset = "0x132ADC0", VA = "0x132ADC0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DFFA4", Offset = "0x9DFFA4")]
			get
			{
				return null;
			}
			[Token(Token = "0x60008CC")]
			[Address(RVA = "0x132ADC8", Offset = "0x132ADC8", VA = "0x132ADC8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DFFB4", Offset = "0x9DFFB4")]
			private set
			{
			}
		}

		[Token(Token = "0x17000159")]
		public string Token
		{
			[Token(Token = "0x60008CD")]
			[Address(RVA = "0x132ADD0", Offset = "0x132ADD0", VA = "0x132ADD0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DFFC4", Offset = "0x9DFFC4")]
			get
			{
				return null;
			}
			[Token(Token = "0x60008CE")]
			[Address(RVA = "0x132ADD8", Offset = "0x132ADD8", VA = "0x132ADD8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DFFD4", Offset = "0x9DFFD4")]
			set
			{
			}
		}

		[Token(Token = "0x1700015A")]
		public string UserId
		{
			[Token(Token = "0x60008CF")]
			[Address(RVA = "0x132ADE0", Offset = "0x132ADE0", VA = "0x132ADE0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DFFE4", Offset = "0x9DFFE4")]
			get
			{
				return null;
			}
			[Token(Token = "0x60008D0")]
			[Address(RVA = "0x132ADE8", Offset = "0x132ADE8", VA = "0x132ADE8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DFFF4", Offset = "0x9DFFF4")]
			set
			{
			}
		}

		[Token(Token = "0x60008D1")]
		[Address(RVA = "0x132ADF0", Offset = "0x132ADF0", VA = "0x132ADF0")]
		public AuthenticationValues()
		{
		}

		[Token(Token = "0x60008D2")]
		[Address(RVA = "0x132AE00", Offset = "0x132AE00", VA = "0x132AE00")]
		public AuthenticationValues(string userId)
		{
		}

		[Token(Token = "0x60008D3")]
		[Address(RVA = "0x132AE34", Offset = "0x132AE34", VA = "0x132AE34", Slot = "4")]
		public virtual void SetAuthPostData(string stringData)
		{
		}

		[Token(Token = "0x60008D4")]
		[Address(RVA = "0x132AE78", Offset = "0x132AE78", VA = "0x132AE78", Slot = "5")]
		public virtual void SetAuthPostData(byte[] byteData)
		{
		}

		[Token(Token = "0x60008D5")]
		[Address(RVA = "0x132AE80", Offset = "0x132AE80", VA = "0x132AE80", Slot = "6")]
		public virtual void AddAuthParameter(string key, string value)
		{
		}

		[Token(Token = "0x60008D6")]
		[Address(RVA = "0x132B0A4", Offset = "0x132B0A4", VA = "0x132B0A4", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Token(Token = "0x2000123")]
	public class Player
	{
		[Token(Token = "0x40007B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DAA2C", Offset = "0x9DAA2C")]
		private Room <RoomReference>k__BackingField;

		[Token(Token = "0x40007B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private int actorID;

		[Token(Token = "0x40007B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public readonly bool IsLocal;

		[Token(Token = "0x40007B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private string nickName;

		[Token(Token = "0x40007B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DAA3C", Offset = "0x9DAA3C")]
		private string <UserId>k__BackingField;

		[Token(Token = "0x40007B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DAA4C", Offset = "0x9DAA4C")]
		private bool <IsInactive>k__BackingField;

		[Token(Token = "0x40007BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DAA5C", Offset = "0x9DAA5C")]
		private Hashtable <CustomProperties>k__BackingField;

		[Token(Token = "0x40007BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public object TagObject;

		[Token(Token = "0x1700015B")]
		protected internal Room RoomReference
		{
			[Token(Token = "0x60008D7")]
			[Address(RVA = "0x13353C0", Offset = "0x13353C0", VA = "0x13353C0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E0004", Offset = "0x9E0004")]
			get
			{
				return null;
			}
			[Token(Token = "0x60008D8")]
			[Address(RVA = "0x132F85C", Offset = "0x132F85C", VA = "0x132F85C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E0014", Offset = "0x9E0014")]
			set
			{
			}
		}

		[Token(Token = "0x1700015C")]
		public int ID
		{
			[Token(Token = "0x60008D9")]
			[Address(RVA = "0x132E5BC", Offset = "0x132E5BC", VA = "0x132E5BC")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700015D")]
		public string NickName
		{
			[Token(Token = "0x60008DA")]
			[Address(RVA = "0x132CD40", Offset = "0x132CD40", VA = "0x132CD40")]
			get
			{
				return null;
			}
			[Token(Token = "0x60008DB")]
			[Address(RVA = "0x132CD58", Offset = "0x132CD58", VA = "0x132CD58")]
			set
			{
			}
		}

		[Token(Token = "0x1700015E")]
		public string UserId
		{
			[Token(Token = "0x60008DC")]
			[Address(RVA = "0x13354DC", Offset = "0x13354DC", VA = "0x13354DC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E0024", Offset = "0x9E0024")]
			get
			{
				return null;
			}
			[Token(Token = "0x60008DD")]
			[Address(RVA = "0x13354E4", Offset = "0x13354E4", VA = "0x13354E4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E0034", Offset = "0x9E0034")]
			internal set
			{
			}
		}

		[Token(Token = "0x1700015F")]
		public bool IsMasterClient
		{
			[Token(Token = "0x60008DE")]
			[Address(RVA = "0x13354EC", Offset = "0x13354EC", VA = "0x13354EC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000160")]
		public bool IsInactive
		{
			[Token(Token = "0x60008DF")]
			[Address(RVA = "0x1335518", Offset = "0x1335518", VA = "0x1335518")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E0044", Offset = "0x9E0044")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60008E0")]
			[Address(RVA = "0x1332458", Offset = "0x1332458", VA = "0x1332458")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E0054", Offset = "0x9E0054")]
			set
			{
			}
		}

		[Token(Token = "0x17000161")]
		public Hashtable CustomProperties
		{
			[Token(Token = "0x60008E1")]
			[Address(RVA = "0x1335520", Offset = "0x1335520", VA = "0x1335520")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E0064", Offset = "0x9E0064")]
			get
			{
				return null;
			}
			[Token(Token = "0x60008E2")]
			[Address(RVA = "0x1335528", Offset = "0x1335528", VA = "0x1335528")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E0074", Offset = "0x9E0074")]
			private set
			{
			}
		}

		[Token(Token = "0x17000162")]
		public Hashtable AllProperties
		{
			[Token(Token = "0x60008E3")]
			[Address(RVA = "0x1331138", Offset = "0x1331138", VA = "0x1331138")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60008E4")]
		[Address(RVA = "0x1335530", Offset = "0x1335530", VA = "0x1335530")]
		protected internal Player(string nickName, int actorID, bool isLocal)
		{
		}

		[Token(Token = "0x60008E5")]
		[Address(RVA = "0x132FD4C", Offset = "0x132FD4C", VA = "0x132FD4C")]
		protected internal Player(string nickName, int actorID, bool isLocal, Hashtable playerProperties)
		{
		}

		[Token(Token = "0x60008E6")]
		[Address(RVA = "0x133553C", Offset = "0x133553C", VA = "0x133553C")]
		public Player Get(int id)
		{
			return null;
		}

		[Token(Token = "0x60008E7")]
		[Address(RVA = "0x1335554", Offset = "0x1335554", VA = "0x1335554")]
		public Player GetNext()
		{
			return null;
		}

		[Token(Token = "0x60008E8")]
		[Address(RVA = "0x1335728", Offset = "0x1335728", VA = "0x1335728")]
		public Player GetNextFor(Player currentPlayer)
		{
			return null;
		}

		[Token(Token = "0x60008E9")]
		[Address(RVA = "0x133555C", Offset = "0x133555C", VA = "0x133555C")]
		public Player GetNextFor(int currentPlayerId)
		{
			return null;
		}

		[Token(Token = "0x60008EA")]
		[Address(RVA = "0x133573C", Offset = "0x133573C", VA = "0x133573C", Slot = "4")]
		public virtual void InternalCacheProperties(Hashtable properties)
		{
		}

		[Token(Token = "0x60008EB")]
		[Address(RVA = "0x13359A4", Offset = "0x13359A4", VA = "0x13359A4", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x60008EC")]
		[Address(RVA = "0x1335A30", Offset = "0x1335A30", VA = "0x1335A30")]
		public string ToStringFull()
		{
			return null;
		}

		[Token(Token = "0x60008ED")]
		[Address(RVA = "0x1335C34", Offset = "0x1335C34", VA = "0x1335C34", Slot = "0")]
		public override bool Equals(object p)
		{
			return default(bool);
		}

		[Token(Token = "0x60008EE")]
		[Address(RVA = "0x1335CFC", Offset = "0x1335CFC", VA = "0x1335CFC", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x60008EF")]
		[Address(RVA = "0x132F84C", Offset = "0x132F84C", VA = "0x132F84C")]
		protected internal void ChangeLocalID(int newID)
		{
		}

		[Token(Token = "0x60008F0")]
		[Address(RVA = "0x132E5C4", Offset = "0x132E5C4", VA = "0x132E5C4")]
		public void SetCustomProperties(Hashtable propertiesToSet, [Optional] Hashtable expectedValues, [Optional] WebFlags webFlags)
		{
		}

		[Token(Token = "0x60008F1")]
		[Address(RVA = "0x13353D0", Offset = "0x13353D0", VA = "0x13353D0")]
		private void SetPlayerNameProperty()
		{
		}
	}
	[Token(Token = "0x2000124")]
	public class Room : RoomInfo
	{
		[Token(Token = "0x40007BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		protected internal int PlayerTTL;

		[Token(Token = "0x40007BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		protected internal int RoomTTL;

		[Token(Token = "0x40007BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DAA6C", Offset = "0x9DAA6C")]
		private LoadBalancingClient <LoadBalancingClient>k__BackingField;

		[Token(Token = "0x40007BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Dictionary<int, Player> players;

		[Token(Token = "0x17000163")]
		protected internal LoadBalancingClient LoadBalancingClient
		{
			[Token(Token = "0x60008F2")]
			[Address(RVA = "0x1335D04", Offset = "0x1335D04", VA = "0x1335D04")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E0084", Offset = "0x9E0084")]
			get
			{
				return null;
			}
			[Token(Token = "0x60008F3")]
			[Address(RVA = "0x132FB94", Offset = "0x132FB94", VA = "0x132FB94")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E0094", Offset = "0x9E0094")]
			set
			{
			}
		}

		[Token(Token = "0x17000164")]
		public new string Name
		{
			[Token(Token = "0x60008F4")]
			[Address(RVA = "0x1335DE4", Offset = "0x1335DE4", VA = "0x1335DE4")]
			get
			{
				return null;
			}
			[Token(Token = "0x60008F5")]
			[Address(RVA = "0x1335DEC", Offset = "0x1335DEC", VA = "0x1335DEC")]
			internal set
			{
			}
		}

		[Token(Token = "0x17000165")]
		public new bool IsOpen
		{
			[Token(Token = "0x60008F6")]
			[Address(RVA = "0x1335DF4", Offset = "0x1335DF4", VA = "0x1335DF4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60008F7")]
			[Address(RVA = "0x1335DFC", Offset = "0x1335DFC", VA = "0x1335DFC")]
			set
			{
			}
		}

		[Token(Token = "0x17000166")]
		public new bool IsVisible
		{
			[Token(Token = "0x60008F8")]
			[Address(RVA = "0x1335F54", Offset = "0x1335F54", VA = "0x1335F54")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60008F9")]
			[Address(RVA = "0x1335F5C", Offset = "0x1335F5C", VA = "0x1335F5C")]
			set
			{
			}
		}

		[Token(Token = "0x17000167")]
		public new byte MaxPlayers
		{
			[Token(Token = "0x60008FA")]
			[Address(RVA = "0x13360B4", Offset = "0x13360B4", VA = "0x13360B4")]
			get
			{
				return default(byte);
			}
			[Token(Token = "0x60008FB")]
			[Address(RVA = "0x13360BC", Offset = "0x13360BC", VA = "0x13360BC")]
			set
			{
			}
		}

		[Token(Token = "0x17000168")]
		public new byte PlayerCount
		{
			[Token(Token = "0x60008FC")]
			[Address(RVA = "0x1336200", Offset = "0x1336200", VA = "0x1336200")]
			get
			{
				return default(byte);
			}
		}

		[Token(Token = "0x17000169")]
		public Dictionary<int, Player> Players
		{
			[Token(Token = "0x60008FD")]
			[Address(RVA = "0x132F844", Offset = "0x132F844", VA = "0x132F844")]
			get
			{
				return null;
			}
			[Token(Token = "0x60008FE")]
			[Address(RVA = "0x1336258", Offset = "0x1336258", VA = "0x1336258")]
			private set
			{
			}
		}

		[Token(Token = "0x1700016A")]
		public string[] ExpectedUsers
		{
			[Token(Token = "0x60008FF")]
			[Address(RVA = "0x1336260", Offset = "0x1336260", VA = "0x1336260")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700016B")]
		public int MasterClientId
		{
			[Token(Token = "0x6000900")]
			[Address(RVA = "0x1335510", Offset = "0x1335510", VA = "0x1335510")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700016C")]
		public string[] PropertiesListedInLobby
		{
			[Token(Token = "0x6000901")]
			[Address(RVA = "0x1336268", Offset = "0x1336268", VA = "0x1336268")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000902")]
			[Address(RVA = "0x1336270", Offset = "0x1336270", VA = "0x1336270")]
			private set
			{
			}
		}

		[Token(Token = "0x1700016D")]
		public bool AutoCleanUp
		{
			[Token(Token = "0x6000903")]
			[Address(RVA = "0x1336278", Offset = "0x1336278", VA = "0x1336278")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000904")]
		[Address(RVA = "0x132FE78", Offset = "0x132FE78", VA = "0x132FE78")]
		protected internal Room(string roomName, RoomOptions options)
		{
		}

		[Token(Token = "0x6000905")]
		[Address(RVA = "0x1336280", Offset = "0x1336280", VA = "0x1336280", Slot = "5")]
		public virtual void SetCustomProperties(Hashtable propertiesToSet, [Optional] Hashtable expectedProperties, [Optional] WebFlags webFlags)
		{
		}

		[Token(Token = "0x6000906")]
		[Address(RVA = "0x133636C", Offset = "0x133636C", VA = "0x133636C")]
		public void SetPropertiesListedInLobby(string[] propertiesListedInLobby)
		{
		}

		[Token(Token = "0x6000907")]
		[Address(RVA = "0x1336448", Offset = "0x1336448", VA = "0x1336448", Slot = "6")]
		protected internal virtual void RemovePlayer(Player player)
		{
		}

		[Token(Token = "0x6000908")]
		[Address(RVA = "0x13364D0", Offset = "0x13364D0", VA = "0x13364D0", Slot = "7")]
		protected internal virtual void RemovePlayer(int id)
		{
		}

		[Token(Token = "0x6000909")]
		[Address(RVA = "0x1336508", Offset = "0x1336508", VA = "0x1336508")]
		public bool SetMasterClient(Player masterClientPlayer)
		{
			return default(bool);
		}

		[Token(Token = "0x600090A")]
		[Address(RVA = "0x13366CC", Offset = "0x13366CC", VA = "0x13366CC", Slot = "8")]
		public virtual bool AddPlayer(Player player)
		{
			return default(bool);
		}

		[Token(Token = "0x600090B")]
		[Address(RVA = "0x1336774", Offset = "0x1336774", VA = "0x1336774", Slot = "9")]
		public virtual Player StorePlayer(Player player)
		{
			return null;
		}

		[Token(Token = "0x600090C")]
		[Address(RVA = "0x133681C", Offset = "0x133681C", VA = "0x133681C", Slot = "10")]
		public virtual Player GetPlayer(int id)
		{
			return null;
		}

		[Token(Token = "0x600090D")]
		[Address(RVA = "0x133689C", Offset = "0x133689C", VA = "0x133689C")]
		public void ClearExpectedUsers()
		{
		}

		[Token(Token = "0x600090E")]
		[Address(RVA = "0x13369DC", Offset = "0x13369DC", VA = "0x13369DC", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x600090F")]
		[Address(RVA = "0x1336C60", Offset = "0x1336C60", VA = "0x1336C60")]
		public new string ToStringFull()
		{
			return null;
		}
	}
	[Token(Token = "0x2000125")]
	public class RoomInfo
	{
		[Token(Token = "0x40007C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		protected internal bool removedFromList;

		[Token(Token = "0x40007C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Hashtable customProperties;

		[Token(Token = "0x40007C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		protected byte maxPlayers;

		[Token(Token = "0x40007C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		protected string[] expectedUsers;

		[Token(Token = "0x40007C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		protected bool isOpen;

		[Token(Token = "0x40007C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
		protected bool isVisible;

		[Token(Token = "0x40007C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x32")]
		protected bool autoCleanUp;

		[Token(Token = "0x40007C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		protected string name;

		[Token(Token = "0x40007C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		protected internal int masterClientId;

		[Token(Token = "0x40007C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		protected string[] propertiesListedInLobby;

		[Token(Token = "0x40007CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DAA7C", Offset = "0x9DAA7C")]
		private int <PlayerCount>k__BackingField;

		[Token(Token = "0x40007CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DAA8C", Offset = "0x9DAA8C")]
		private bool <IsLocalClientInside>k__BackingField;

		[Token(Token = "0x1700016E")]
		public Hashtable CustomProperties
		{
			[Token(Token = "0x6000910")]
			[Address(RVA = "0x1336364", Offset = "0x1336364", VA = "0x1336364")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700016F")]
		public string Name
		{
			[Token(Token = "0x6000911")]
			[Address(RVA = "0x1336F38", Offset = "0x1336F38", VA = "0x1336F38")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000170")]
		public int PlayerCount
		{
			[Token(Token = "0x6000912")]
			[Address(RVA = "0x1336F40", Offset = "0x1336F40", VA = "0x1336F40")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E00A4", Offset = "0x9E00A4")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000913")]
			[Address(RVA = "0x1336F48", Offset = "0x1336F48", VA = "0x1336F48")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E00B4", Offset = "0x9E00B4")]
			private set
			{
			}
		}

		[Token(Token = "0x17000171")]
		public bool IsLocalClientInside
		{
			[Token(Token = "0x6000914")]
			[Address(RVA = "0x13353C8", Offset = "0x13353C8", VA = "0x13353C8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E00C4", Offset = "0x9E00C4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000915")]
			[Address(RVA = "0x132FB9C", Offset = "0x132FB9C", VA = "0x132FB9C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E00D4", Offset = "0x9E00D4")]
			set
			{
			}
		}

		[Token(Token = "0x17000172")]
		public byte MaxPlayers
		{
			[Token(Token = "0x6000916")]
			[Address(RVA = "0x1336F50", Offset = "0x1336F50", VA = "0x1336F50")]
			get
			{
				return default(byte);
			}
		}

		[Token(Token = "0x17000173")]
		public bool IsOpen
		{
			[Token(Token = "0x6000917")]
			[Address(RVA = "0x1336F58", Offset = "0x1336F58", VA = "0x1336F58")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000174")]
		public bool IsVisible
		{
			[Token(Token = "0x6000918")]
			[Address(RVA = "0x1336F60", Offset = "0x1336F60", VA = "0x1336F60")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000919")]
		[Address(RVA = "0x13311F0", Offset = "0x13311F0", VA = "0x13311F0")]
		protected internal RoomInfo(string roomName, Hashtable roomProperties)
		{
		}

		[Token(Token = "0x600091A")]
		[Address(RVA = "0x1336F68", Offset = "0x1336F68", VA = "0x1336F68", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Token(Token = "0x600091B")]
		[Address(RVA = "0x1337030", Offset = "0x1337030", VA = "0x1337030", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x600091C")]
		[Address(RVA = "0x1337064", Offset = "0x1337064", VA = "0x1337064", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x600091D")]
		[Address(RVA = "0x13372E8", Offset = "0x13372E8", VA = "0x13372E8")]
		public string ToStringFull()
		{
			return null;
		}

		[Token(Token = "0x600091E")]
		[Address(RVA = "0x13375C0", Offset = "0x13375C0", VA = "0x13375C0", Slot = "4")]
		protected internal virtual void InternalCacheProperties(Hashtable propertiesToCache)
		{
		}
	}
	[Token(Token = "0x2000126")]
	public class WebRpcResponse
	{
		[Token(Token = "0x40007CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DAA9C", Offset = "0x9DAA9C")]
		private string <Name>k__BackingField;

		[Token(Token = "0x40007CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DAAAC", Offset = "0x9DAAAC")]
		private int <ReturnCode>k__BackingField;

		[Token(Token = "0x40007CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DAABC", Offset = "0x9DAABC")]
		private string <DebugMessage>k__BackingField;

		[Token(Token = "0x40007CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DAACC", Offset = "0x9DAACC")]
		private Dictionary<string, object> <Parameters>k__BackingField;

		[Token(Token = "0x17000175")]
		public string Name
		{
			[Token(Token = "0x600091F")]
			[Address(RVA = "0x1337FE0", Offset = "0x1337FE0", VA = "0x1337FE0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E00E4", Offset = "0x9E00E4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000920")]
			[Address(RVA = "0x1337FE8", Offset = "0x1337FE8", VA = "0x1337FE8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E00F4", Offset = "0x9E00F4")]
			private set
			{
			}
		}

		[Token(Token = "0x17000176")]
		public int ReturnCode
		{
			[Token(Token = "0x6000921")]
			[Address(RVA = "0x1337FF0", Offset = "0x1337FF0", VA = "0x1337FF0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E0104", Offset = "0x9E0104")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000922")]
			[Address(RVA = "0x1337FF8", Offset = "0x1337FF8", VA = "0x1337FF8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E0114", Offset = "0x9E0114")]
			private set
			{
			}
		}

		[Token(Token = "0x17000177")]
		public string DebugMessage
		{
			[Token(Token = "0x6000923")]
			[Address(RVA = "0x1338000", Offset = "0x1338000", VA = "0x1338000")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E0124", Offset = "0x9E0124")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000924")]
			[Address(RVA = "0x1338008", Offset = "0x1338008", VA = "0x1338008")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E0134", Offset = "0x9E0134")]
			private set
			{
			}
		}

		[Token(Token = "0x17000178")]
		public Dictionary<string, object> Parameters
		{
			[Token(Token = "0x6000925")]
			[Address(RVA = "0x1338010", Offset = "0x1338010", VA = "0x1338010")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E0144", Offset = "0x9E0144")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000926")]
			[Address(RVA = "0x1338018", Offset = "0x1338018", VA = "0x1338018")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9E0154", Offset = "0x9E0154")]
			private set
			{
			}
		}

		[Token(Token = "0x6000927")]
		[Address(RVA = "0x1338020", Offset = "0x1338020", VA = "0x1338020")]
		public WebRpcResponse(OperationResponse response)
		{
		}

		[Token(Token = "0x6000928")]
		[Address(RVA = "0x13381F8", Offset = "0x13381F8", VA = "0x13381F8")]
		public string ToStringFull()
		{
			return null;
		}
	}
	[Token(Token = "0x2000127")]
	public class WebFlags
	{
		[Token(Token = "0x40007D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly WebFlags Default;

		[Token(Token = "0x40007D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public byte WebhookFlags;

		[Token(Token = "0x40007D2")]
		public const byte HttpForwardConst = 1;

		[Token(Token = "0x40007D3")]
		public const byte SendAuthCookieConst = 2;

		[Token(Token = "0x40007D4")]
		public const byte SendSyncConst = 4;

		[Token(Token = "0x40007D5")]
		public const byte SendStateConst = 8;

		[Token(Token = "0x17000179")]
		public bool HttpForward
		{
			[Token(Token = "0x6000929")]
			[Address(RVA = "0x13344D0", Offset = "0x13344D0", VA = "0x13344D0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600092A")]
			[Address(RVA = "0x1337ED8", Offset = "0x1337ED8", VA = "0x1337ED8")]
			set
			{
			}
		}

		[Token(Token = "0x1700017A")]
		public bool SendAuthCookie
		{
			[Token(Token = "0x600092B")]
			[Address(RVA = "0x1337EF4", Offset = "0x1337EF4", VA = "0x1337EF4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600092C")]
			[Address(RVA = "0x1337F00", Offset = "0x1337F00", VA = "0x1337F00")]
			set
			{
			}
		}

		[Token(Token = "0x1700017B")]
		public bool SendSync
		{
			[Token(Token = "0x600092D")]
			[Address(RVA = "0x1337F20", Offset = "0x1337F20", VA = "0x1337F20")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600092E")]
			[Address(RVA = "0x1337F2C", Offset = "0x1337F2C", VA = "0x1337F2C")]
			set
			{
			}
		}

		[Token(Token = "0x1700017C")]
		public bool SendState
		{
			[Token(Token = "0x600092F")]
			[Address(RVA = "0x1337F4C", Offset = "0x1337F4C", VA = "0x1337F4C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000930")]
			[Address(RVA = "0x1337F58", Offset = "0x1337F58", VA = "0x1337F58")]
			set
			{
			}
		}

		[Token(Token = "0x6000931")]
		[Address(RVA = "0x132E8E4", Offset = "0x132E8E4", VA = "0x132E8E4")]
		public WebFlags(byte webhookFlags)
		{
		}
	}
}
