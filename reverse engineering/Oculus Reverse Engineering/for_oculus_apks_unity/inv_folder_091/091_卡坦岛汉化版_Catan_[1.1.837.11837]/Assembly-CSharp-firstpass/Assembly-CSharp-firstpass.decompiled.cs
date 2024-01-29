using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Sockets;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading;
using ExitGames.Client.Photon.LoadBalancing;
using ExitGames.Client.Photon.Voice;
using Il2CppDummyDll;
using POpusCodec;
using POpusCodec.Enums;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Token(Token = "0x2000002")]
public class AndroidAudioInAEC : IAudioPusher<short>, IAudioSource, IDisposable
{
	[Token(Token = "0x200007D")]
	private class DataCallback : AndroidJavaProxy
	{
		[Token(Token = "0x40002F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Action<short[]> callback;

		[Token(Token = "0x40002F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private IntPtr javaBuf;

		[Token(Token = "0x40002FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private int cntFrame;

		[Token(Token = "0x40002FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private int cntShort;

		[Token(Token = "0x6000322")]
		[Address(RVA = "0x1266D24", Offset = "0x1266D24", VA = "0x1266D24")]
		public DataCallback(Action<short[]> callback, IntPtr javaBuf)
		{
		}

		[Token(Token = "0x6000323")]
		[Address(RVA = "0x1266DC0", Offset = "0x1266DC0", VA = "0x1266DC0")]
		public void OnData()
		{
		}

		[Token(Token = "0x6000324")]
		[Address(RVA = "0x1266E5C", Offset = "0x1266E5C", VA = "0x1266E5C")]
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
		[Address(RVA = "0x1266DB8", Offset = "0x1266DB8", VA = "0x1266DB8", Slot = "6")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000002")]
	public int SamplingRate
	{
		[Token(Token = "0x6000004")]
		[Address(RVA = "0x1266DB0", Offset = "0x1266DB0", VA = "0x1266DB0", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x6000001")]
	[Address(RVA = "0x12661F0", Offset = "0x12661F0", VA = "0x12661F0")]
	public AndroidAudioInAEC()
	{
	}

	[Token(Token = "0x6000002")]
	[Address(RVA = "0x12661F8", Offset = "0x12661F8", VA = "0x12661F8", Slot = "4")]
	public void SetCallback(Action<short[]> callback, LocalVoice localVoice)
	{
	}

	[Token(Token = "0x6000005")]
	[Address(RVA = "0x1266C98", Offset = "0x1266C98", VA = "0x1266C98", Slot = "7")]
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
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87D038", Offset = "0x87D038")]
	private bool <Loop>k__BackingField;

	[Token(Token = "0x4000008")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
	private bool playing;

	[Token(Token = "0x17000003")]
	public bool Loop
	{
		[Token(Token = "0x6000006")]
		[Address(RVA = "0x1266E68", Offset = "0x1266E68", VA = "0x1266E68")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87DA3C", Offset = "0x87DA3C")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000007")]
		[Address(RVA = "0x1266E70", Offset = "0x1266E70", VA = "0x1266E70")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87DA4C", Offset = "0x87DA4C")]
		set
		{
		}
	}

	[Token(Token = "0x17000004")]
	public int SamplingRate
	{
		[Token(Token = "0x600000A")]
		[Address(RVA = "0x1266FFC", Offset = "0x1266FFC", VA = "0x1266FFC", Slot = "6")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000005")]
	public int Channels
	{
		[Token(Token = "0x600000B")]
		[Address(RVA = "0x126702C", Offset = "0x126702C", VA = "0x126702C", Slot = "7")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x6000008")]
	[Address(RVA = "0x1266E7C", Offset = "0x1266E7C", VA = "0x1266E7C")]
	public AudioClipWrapper(AudioClip audioClip)
	{
	}

	[Token(Token = "0x6000009")]
	[Address(RVA = "0x1266EBC", Offset = "0x1266EBC", VA = "0x1266EBC", Slot = "4")]
	public bool Read(float[] buffer)
	{
		return default(bool);
	}

	[Token(Token = "0x600000C")]
	[Address(RVA = "0x126705C", Offset = "0x126705C", VA = "0x126705C", Slot = "5")]
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
		[Address(RVA = "0x1267060", Offset = "0x1267060", VA = "0x1267060")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87DA5C", Offset = "0x87DA5C")]
		add
		{
		}
		[Token(Token = "0x600000E")]
		[Address(RVA = "0x126714C", Offset = "0x126714C", VA = "0x126714C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87DA6C", Offset = "0x87DA6C")]
		remove
		{
		}
	}

	[Token(Token = "0x600000F")]
	[Address(RVA = "0x1267238", Offset = "0x1267238", VA = "0x1267238")]
	private void OnAudioFilterRead(float[] frame, int channels)
	{
	}

	[Token(Token = "0x6000010")]
	[Address(RVA = "0x12672B4", Offset = "0x12672B4", VA = "0x12672B4")]
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
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87D058", Offset = "0x87D058")]
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
		[Address(RVA = "0x12672BC", Offset = "0x12672BC", VA = "0x12672BC", Slot = "9")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87DA7C", Offset = "0x87DA7C")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6000012")]
		[Address(RVA = "0x12672C4", Offset = "0x12672C4", VA = "0x12672C4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87DA8C", Offset = "0x87DA8C")]
		private set
		{
		}
	}

	[Token(Token = "0x17000007")]
	public AudioSource AudioSource
	{
		[Token(Token = "0x6000013")]
		[Address(RVA = "0x12672CC", Offset = "0x12672CC", VA = "0x12672CC")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000008")]
	private int playSamplePos
	{
		[Token(Token = "0x6000015")]
		[Address(RVA = "0x12673A8", Offset = "0x12673A8", VA = "0x12673A8")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6000016")]
		[Address(RVA = "0x1267478", Offset = "0x1267478", VA = "0x1267478")]
		set
		{
		}
	}

	[Token(Token = "0x17000009")]
	public bool IsPlaying
	{
		[Token(Token = "0x6000017")]
		[Address(RVA = "0x1267580", Offset = "0x1267580", VA = "0x1267580", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6000014")]
	[Address(RVA = "0x12672D4", Offset = "0x12672D4", VA = "0x12672D4")]
	public AudioStreamPlayer(AudioSource audioSource, string logPrefix, bool debugInfo)
	{
	}

	[Token(Token = "0x6000018")]
	[Address(RVA = "0x12675B0", Offset = "0x12675B0", VA = "0x12675B0", Slot = "5")]
	public void Start(int frequency, int channels, int frameSamples, int playDelayMs)
	{
	}

	[Token(Token = "0x6000019")]
	[Address(RVA = "0x1267758", Offset = "0x1267758", VA = "0x1267758", Slot = "8")]
	public void Service()
	{
	}

	[Token(Token = "0x600001A")]
	[Address(RVA = "0x1267FA8", Offset = "0x1267FA8", VA = "0x1267FA8", Slot = "7")]
	public void OnAudioFrame(float[] frame)
	{
	}

	[Token(Token = "0x600001B")]
	[Address(RVA = "0x1268270", Offset = "0x1268270", VA = "0x1268270", Slot = "6")]
	public void Stop()
	{
	}
}
[Token(Token = "0x2000006")]
public class IOSAudioForceToSpeaker : MonoBehaviour
{
	[Token(Token = "0x600001C")]
	[Address(RVA = "0x1CEC5A0", Offset = "0x1CEC5A0", VA = "0x1CEC5A0")]
	private void PhotonVoiceCreated()
	{
	}

	[Token(Token = "0x600001D")]
	[Address(RVA = "0x1CEC5A4", Offset = "0x1CEC5A4", VA = "0x1CEC5A4")]
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
		[Address(RVA = "0x1CEC80C", Offset = "0x1CEC80C", VA = "0x1CEC80C", Slot = "6")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x1700000B")]
	public int Channels
	{
		[Token(Token = "0x6000020")]
		[Address(RVA = "0x1CEC83C", Offset = "0x1CEC83C", VA = "0x1CEC83C", Slot = "7")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x600001E")]
	[Address(RVA = "0x1CEC5AC", Offset = "0x1CEC5AC", VA = "0x1CEC5AC")]
	public MicWrapper(string device, int suggestedFrequency)
	{
	}

	[Token(Token = "0x6000021")]
	[Address(RVA = "0x1CEC86C", Offset = "0x1CEC86C", VA = "0x1CEC86C", Slot = "5")]
	public void Dispose()
	{
	}

	[Token(Token = "0x6000022")]
	[Address(RVA = "0x1CEC878", Offset = "0x1CEC878", VA = "0x1CEC878", Slot = "4")]
	public bool Read(float[] buffer)
	{
		return default(bool);
	}
}
[Token(Token = "0x2000008")]
public class SpeexDSP : MonoBehaviour
{
	[Token(Token = "0x200007E")]
	private class Logger : ExitGames.Client.Photon.Voice.ILogger
	{
		[Token(Token = "0x6000325")]
		[Address(RVA = "0x1CEFEA0", Offset = "0x1CEFEA0", VA = "0x1CEFEA0", Slot = "4")]
		public void LogError(string fmt, params object[] args)
		{
		}

		[Token(Token = "0x6000326")]
		[Address(RVA = "0x1CEFF18", Offset = "0x1CEFF18", VA = "0x1CEFF18", Slot = "5")]
		public void LogWarning(string fmt, params object[] args)
		{
		}

		[Token(Token = "0x6000327")]
		[Address(RVA = "0x1CEFF90", Offset = "0x1CEFF90", VA = "0x1CEFF90", Slot = "6")]
		public void LogInfo(string fmt, params object[] args)
		{
		}

		[Token(Token = "0x6000328")]
		[Address(RVA = "0x1CF0008", Offset = "0x1CF0008", VA = "0x1CF0008", Slot = "7")]
		public void LogDebug(string fmt, params object[] args)
		{
		}

		[Token(Token = "0x6000329")]
		[Address(RVA = "0x1CEFD74", Offset = "0x1CEFD74", VA = "0x1CEFD74")]
		public Logger()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x200007F")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87CFA8", Offset = "0x87CFA8")]
	private sealed class <>c
	{
		[Token(Token = "0x40002FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly <>c <>9;

		[Token(Token = "0x40002FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static Func<long> <>9__29_0;

		[Token(Token = "0x600032B")]
		[Address(RVA = "0x1CEFE70", Offset = "0x1CEFE70", VA = "0x1CEFE70")]
		public <>c()
		{
		}

		[Token(Token = "0x600032C")]
		[Address(RVA = "0x1CEFE78", Offset = "0x1CEFE78", VA = "0x1CEFE78")]
		internal long <PhotonVoiceCreated>b__29_0()
		{
			return default(long);
		}
	}

	[Token(Token = "0x4000021")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x87D068", Offset = "0x87D068")]
	public bool Windows;

	[Token(Token = "0x4000022")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
	public bool Mac;

	[Token(Token = "0x4000023")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x87D0A0", Offset = "0x87D0A0")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x87D0A0", Offset = "0x87D0A0")]
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
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x87D100", Offset = "0x87D100")]
	public bool AGC;

	[Token(Token = "0x4000028")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x87D138", Offset = "0x87D138")]
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
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87D154", Offset = "0x87D154")]
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
		[Address(RVA = "0x1CEEF84", Offset = "0x1CEEF84", VA = "0x1CEEF84")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700000D")]
	public bool Active
	{
		[Token(Token = "0x6000024")]
		[Address(RVA = "0x1CEEF8C", Offset = "0x1CEEF8C", VA = "0x1CEEF8C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87DA9C", Offset = "0x87DA9C")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000025")]
		[Address(RVA = "0x1CEEF94", Offset = "0x1CEEF94", VA = "0x1CEEF94")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87DAAC", Offset = "0x87DAAC")]
		private set
		{
		}
	}

	[Token(Token = "0x6000026")]
	[Address(RVA = "0x1CEEFA0", Offset = "0x1CEEFA0", VA = "0x1CEEFA0")]
	public void ResetAEC()
	{
	}

	[Token(Token = "0x6000027")]
	[Address(RVA = "0x1CEEFB4", Offset = "0x1CEEFB4", VA = "0x1CEEFB4")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000028")]
	[Address(RVA = "0x1CEF004", Offset = "0x1CEF004", VA = "0x1CEF004")]
	private void Start()
	{
	}

	[Token(Token = "0x6000029")]
	[Address(RVA = "0x1CEF008", Offset = "0x1CEF008", VA = "0x1CEF008")]
	private void UpdateProcProps()
	{
	}

	[Token(Token = "0x600002A")]
	[Address(RVA = "0x1CEF250", Offset = "0x1CEF250", VA = "0x1CEF250")]
	private void setOutputListener(bool set)
	{
	}

	[Token(Token = "0x600002B")]
	[Address(RVA = "0x1CEF718", Offset = "0x1CEF718", VA = "0x1CEF718")]
	private void Update()
	{
	}

	[Token(Token = "0x600002C")]
	[Address(RVA = "0x1CEF484", Offset = "0x1CEF484", VA = "0x1CEF484")]
	private void InitAECLatencyDetect()
	{
	}

	[Token(Token = "0x600002D")]
	[Address(RVA = "0x1CEF854", Offset = "0x1CEF854", VA = "0x1CEF854")]
	private void PhotonVoiceCreated(LocalVoice localVoice)
	{
	}

	[Token(Token = "0x600002E")]
	[Address(RVA = "0x1CEFD7C", Offset = "0x1CEFD7C", VA = "0x1CEFD7C")]
	private void PhotonVoiceRemoved()
	{
	}

	[Token(Token = "0x600002F")]
	[Address(RVA = "0x1CEFDD0", Offset = "0x1CEFDD0", VA = "0x1CEFDD0")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6000030")]
	[Address(RVA = "0x1CEFD80", Offset = "0x1CEFD80", VA = "0x1CEFD80")]
	private void reset()
	{
	}

	[Token(Token = "0x6000031")]
	[Address(RVA = "0x1CEFDD4", Offset = "0x1CEFDD4", VA = "0x1CEFDD4")]
	public SpeexDSP()
	{
	}
}
namespace POpusCodec
{
	[Token(Token = "0x2000009")]
	public class OpusDecoder : IDisposable
	{
		[Token(Token = "0x4000031")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private IntPtr _handle;

		[Token(Token = "0x4000032")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private string _version;

		[Token(Token = "0x4000033")]
		private const int MaxFrameSize = 5760;

		[Token(Token = "0x4000034")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private bool _previousPacketInvalid;

		[Token(Token = "0x4000035")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private int _channelCount;

		[Token(Token = "0x4000036")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly float[] EmptyBufferFloat;

		[Token(Token = "0x4000037")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static readonly short[] EmptyBufferShort;

		[Token(Token = "0x4000038")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Bandwidth? _previousPacketBandwidth;

		[Token(Token = "0x4000039")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float[] bufferFloat;

		[Token(Token = "0x400003A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private short[] bufferShort;

		[Token(Token = "0x1700000E")]
		public string Version
		{
			[Token(Token = "0x6000032")]
			[Address(RVA = "0x1CEC998", Offset = "0x1CEC998", VA = "0x1CEC998")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700000F")]
		public Bandwidth? PreviousPacketBandwidth
		{
			[Token(Token = "0x6000033")]
			[Address(RVA = "0x1CEC9A0", Offset = "0x1CEC9A0", VA = "0x1CEC9A0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000034")]
		[Address(RVA = "0x1CEC9A8", Offset = "0x1CEC9A8", VA = "0x1CEC9A8")]
		public OpusDecoder(SamplingRate outputSamplingRateHz, Channels numChannels)
		{
		}

		[Token(Token = "0x6000035")]
		[Address(RVA = "0x1CECE3C", Offset = "0x1CECE3C", VA = "0x1CECE3C")]
		public float[] DecodePacketFloat(byte[] packetData)
		{
			return null;
		}

		[Token(Token = "0x6000036")]
		[Address(RVA = "0x1CED14C", Offset = "0x1CED14C", VA = "0x1CED14C")]
		public short[] DecodePacketShort(byte[] packetData)
		{
			return null;
		}

		[Token(Token = "0x6000037")]
		[Address(RVA = "0x1CED3BC", Offset = "0x1CED3BC", VA = "0x1CED3BC", Slot = "4")]
		public void Dispose()
		{
		}
	}
	[Token(Token = "0x200000A")]
	public class OpusEncoder : IDisposable
	{
		[Token(Token = "0x400003B")]
		public const int BitrateMax = -1;

		[Token(Token = "0x400003C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private IntPtr _handle;

		[Token(Token = "0x400003D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private string _version;

		[Token(Token = "0x400003E")]
		private const int RecommendedMaxPacketSize = 4000;

		[Token(Token = "0x400003F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private int _frameSizePerChannel;

		[Token(Token = "0x4000040")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private SamplingRate _inputSamplingRate;

		[Token(Token = "0x4000041")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Channels _inputChannels;

		[Token(Token = "0x4000042")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private readonly byte[] writePacket;

		[Token(Token = "0x4000043")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly ArraySegment<byte> EmptyBuffer;

		[Token(Token = "0x4000044")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Delay _encoderDelay;

		[Token(Token = "0x17000010")]
		public SamplingRate InputSamplingRate
		{
			[Token(Token = "0x6000039")]
			[Address(RVA = "0x1CED508", Offset = "0x1CED508", VA = "0x1CED508")]
			get
			{
				return default(SamplingRate);
			}
		}

		[Token(Token = "0x17000011")]
		public Channels InputChannels
		{
			[Token(Token = "0x600003A")]
			[Address(RVA = "0x1CED510", Offset = "0x1CED510", VA = "0x1CED510")]
			get
			{
				return default(Channels);
			}
		}

		[Token(Token = "0x17000012")]
		public string Version
		{
			[Token(Token = "0x600003B")]
			[Address(RVA = "0x1CED518", Offset = "0x1CED518", VA = "0x1CED518")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000013")]
		public Delay EncoderDelay
		{
			[Token(Token = "0x600003D")]
			[Address(RVA = "0x1CED624", Offset = "0x1CED624", VA = "0x1CED624")]
			get
			{
				return default(Delay);
			}
			[Token(Token = "0x600003C")]
			[Address(RVA = "0x1CED520", Offset = "0x1CED520", VA = "0x1CED520")]
			set
			{
			}
		}

		[Token(Token = "0x17000014")]
		public int FrameSizePerChannel
		{
			[Token(Token = "0x600003E")]
			[Address(RVA = "0x1CED62C", Offset = "0x1CED62C", VA = "0x1CED62C")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000015")]
		public int Bitrate
		{
			[Token(Token = "0x600003F")]
			[Address(RVA = "0x1CED634", Offset = "0x1CED634", VA = "0x1CED634")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000040")]
			[Address(RVA = "0x1CED704", Offset = "0x1CED704", VA = "0x1CED704")]
			set
			{
			}
		}

		[Token(Token = "0x17000016")]
		public Bandwidth MaxBandwidth
		{
			[Token(Token = "0x6000041")]
			[Address(RVA = "0x1CED7D0", Offset = "0x1CED7D0", VA = "0x1CED7D0")]
			get
			{
				return default(Bandwidth);
			}
			[Token(Token = "0x6000042")]
			[Address(RVA = "0x1CED7DC", Offset = "0x1CED7DC", VA = "0x1CED7DC")]
			set
			{
			}
		}

		[Token(Token = "0x17000017")]
		public Complexity Complexity
		{
			[Token(Token = "0x6000043")]
			[Address(RVA = "0x1CED7F0", Offset = "0x1CED7F0", VA = "0x1CED7F0")]
			get
			{
				return default(Complexity);
			}
			[Token(Token = "0x6000044")]
			[Address(RVA = "0x1CED7FC", Offset = "0x1CED7FC", VA = "0x1CED7FC")]
			set
			{
			}
		}

		[Token(Token = "0x17000018")]
		public int ExpectedPacketLossPercentage
		{
			[Token(Token = "0x6000045")]
			[Address(RVA = "0x1CED810", Offset = "0x1CED810", VA = "0x1CED810")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000046")]
			[Address(RVA = "0x1CED81C", Offset = "0x1CED81C", VA = "0x1CED81C")]
			set
			{
			}
		}

		[Token(Token = "0x17000019")]
		public SignalHint SignalHint
		{
			[Token(Token = "0x6000047")]
			[Address(RVA = "0x1CED830", Offset = "0x1CED830", VA = "0x1CED830")]
			get
			{
				return default(SignalHint);
			}
			[Token(Token = "0x6000048")]
			[Address(RVA = "0x1CED83C", Offset = "0x1CED83C", VA = "0x1CED83C")]
			set
			{
			}
		}

		[Token(Token = "0x1700001A")]
		public ForceChannels ForceChannels
		{
			[Token(Token = "0x6000049")]
			[Address(RVA = "0x1CED850", Offset = "0x1CED850", VA = "0x1CED850")]
			get
			{
				return default(ForceChannels);
			}
			[Token(Token = "0x600004A")]
			[Address(RVA = "0x1CED85C", Offset = "0x1CED85C", VA = "0x1CED85C")]
			set
			{
			}
		}

		[Token(Token = "0x1700001B")]
		public bool UseInbandFEC
		{
			[Token(Token = "0x600004B")]
			[Address(RVA = "0x1CED870", Offset = "0x1CED870", VA = "0x1CED870")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600004C")]
			[Address(RVA = "0x1CED894", Offset = "0x1CED894", VA = "0x1CED894")]
			set
			{
			}
		}

		[Token(Token = "0x1700001C")]
		public bool UseUnconstrainedVBR
		{
			[Token(Token = "0x600004D")]
			[Address(RVA = "0x1CED8A4", Offset = "0x1CED8A4", VA = "0x1CED8A4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600004E")]
			[Address(RVA = "0x1CED8C8", Offset = "0x1CED8C8", VA = "0x1CED8C8")]
			set
			{
			}
		}

		[Token(Token = "0x1700001D")]
		public bool DtxEnabled
		{
			[Token(Token = "0x600004F")]
			[Address(RVA = "0x1CED8DC", Offset = "0x1CED8DC", VA = "0x1CED8DC")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000050")]
			[Address(RVA = "0x1CED900", Offset = "0x1CED900", VA = "0x1CED900")]
			set
			{
			}
		}

		[Token(Token = "0x6000051")]
		[Address(RVA = "0x1CED910", Offset = "0x1CED910", VA = "0x1CED910")]
		public OpusEncoder(SamplingRate inputSamplingRateHz, Channels numChannels, int bitrate, OpusApplicationType applicationType, Delay encoderDelay)
		{
		}

		[Token(Token = "0x6000052")]
		[Address(RVA = "0x1CEDE10", Offset = "0x1CEDE10", VA = "0x1CEDE10")]
		public ArraySegment<byte> Encode(float[] pcmSamples)
		{
			return default(ArraySegment<byte>);
		}

		[Token(Token = "0x6000053")]
		[Address(RVA = "0x1CEDFD0", Offset = "0x1CEDFD0", VA = "0x1CEDFD0")]
		public ArraySegment<byte> Encode(short[] pcmSamples)
		{
			return default(ArraySegment<byte>);
		}

		[Token(Token = "0x6000054")]
		[Address(RVA = "0x1CEE190", Offset = "0x1CEE190", VA = "0x1CEE190", Slot = "4")]
		public void Dispose()
		{
		}
	}
	[Token(Token = "0x200000B")]
	public class OpusException : Exception
	{
		[Token(Token = "0x4000045")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private OpusStatusCode _statusCode;

		[Token(Token = "0x1700001E")]
		public OpusStatusCode StatusCode
		{
			[Token(Token = "0x6000056")]
			[Address(RVA = "0x1CEE2E4", Offset = "0x1CEE2E4", VA = "0x1CEE2E4")]
			get
			{
				return default(OpusStatusCode);
			}
		}

		[Token(Token = "0x6000057")]
		[Address(RVA = "0x1CECDB8", Offset = "0x1CECDB8", VA = "0x1CECDB8")]
		public OpusException(OpusStatusCode statusCode, string message)
		{
		}
	}
	[Token(Token = "0x200000C")]
	internal class Wrapper
	{
		[Token(Token = "0x4000046")]
		private const string lib_name = "opus_egpv";

		[PreserveSig]
		[Token(Token = "0x6000058")]
		[Address(RVA = "0x1CEE2EC", Offset = "0x1CEE2EC", VA = "0x1CEE2EC")]
		private static extern int opus_encoder_get_size(Channels channels);

		[PreserveSig]
		[Token(Token = "0x6000059")]
		[Address(RVA = "0x1CEE388", Offset = "0x1CEE388", VA = "0x1CEE388")]
		private static extern OpusStatusCode opus_encoder_init(IntPtr st, SamplingRate Fs, Channels channels, OpusApplicationType application);

		[PreserveSig]
		[Token(Token = "0x600005A")]
		[Address(RVA = "0x1CECD2C", Offset = "0x1CECD2C", VA = "0x1CECD2C")]
		public static extern IntPtr opus_get_version_string();

		[PreserveSig]
		[Token(Token = "0x600005B")]
		[Address(RVA = "0x1CEE44C", Offset = "0x1CEE44C", VA = "0x1CEE44C")]
		private static extern int opus_encode(IntPtr st, short[] pcm, int frame_size, byte[] data, int max_data_bytes);

		[PreserveSig]
		[Token(Token = "0x600005C")]
		[Address(RVA = "0x1CEE528", Offset = "0x1CEE528", VA = "0x1CEE528")]
		private static extern int opus_encode_float(IntPtr st, float[] pcm, int frame_size, byte[] data, int max_data_bytes);

		[PreserveSig]
		[Token(Token = "0x600005D")]
		[Address(RVA = "0x1CEE604", Offset = "0x1CEE604", VA = "0x1CEE604")]
		private static extern int opus_encoder_ctl_set(IntPtr st, OpusCtlSetRequest request, int value);

		[PreserveSig]
		[Token(Token = "0x600005E")]
		[Address(RVA = "0x1CEE6B8", Offset = "0x1CEE6B8", VA = "0x1CEE6B8")]
		private static extern int opus_encoder_ctl_get(IntPtr st, OpusCtlGetRequest request, ref int value);

		[PreserveSig]
		[Token(Token = "0x600005F")]
		[Address(RVA = "0x1CEE768", Offset = "0x1CEE768", VA = "0x1CEE768")]
		private static extern int opus_decoder_ctl_set(IntPtr st, OpusCtlSetRequest request, int value);

		[PreserveSig]
		[Token(Token = "0x6000060")]
		[Address(RVA = "0x1CEE81C", Offset = "0x1CEE81C", VA = "0x1CEE81C")]
		private static extern int opus_decoder_ctl_get(IntPtr st, OpusCtlGetRequest request, ref int value);

		[PreserveSig]
		[Token(Token = "0x6000061")]
		[Address(RVA = "0x1CEE8CC", Offset = "0x1CEE8CC", VA = "0x1CEE8CC")]
		private static extern int opus_decoder_get_size(Channels channels);

		[PreserveSig]
		[Token(Token = "0x6000062")]
		[Address(RVA = "0x1CEE968", Offset = "0x1CEE968", VA = "0x1CEE968")]
		private static extern OpusStatusCode opus_decoder_init(IntPtr st, SamplingRate Fs, Channels channels);

		[PreserveSig]
		[Token(Token = "0x6000063")]
		[Address(RVA = "0x1CEEA1C", Offset = "0x1CEEA1C", VA = "0x1CEEA1C")]
		private static extern int opus_decode(IntPtr st, byte[] data, int len, short[] pcm, int frame_size, int decode_fec);

		[PreserveSig]
		[Token(Token = "0x6000064")]
		[Address(RVA = "0x1CEEB08", Offset = "0x1CEEB08", VA = "0x1CEEB08")]
		private static extern int opus_decode_float(IntPtr st, byte[] data, int len, float[] pcm, int frame_size, int decode_fec);

		[PreserveSig]
		[Token(Token = "0x6000065")]
		[Address(RVA = "0x1CED0A8", Offset = "0x1CED0A8", VA = "0x1CED0A8")]
		public static extern int opus_packet_get_bandwidth(byte[] data);

		[PreserveSig]
		[Token(Token = "0x6000066")]
		[Address(RVA = "0x1CEEBF4", Offset = "0x1CEEBF4", VA = "0x1CEEBF4")]
		public static extern int opus_packet_get_nb_channels(byte[] data);

		[PreserveSig]
		[Token(Token = "0x6000067")]
		[Address(RVA = "0x1CEEC98", Offset = "0x1CEEC98", VA = "0x1CEEC98")]
		private static extern IntPtr opus_strerror(OpusStatusCode error);

		[Token(Token = "0x6000068")]
		[Address(RVA = "0x1CEDCC4", Offset = "0x1CEDCC4", VA = "0x1CEDCC4")]
		public static IntPtr opus_encoder_create(SamplingRate Fs, Channels channels, OpusApplicationType application)
		{
			return default(IntPtr);
		}

		[Token(Token = "0x6000069")]
		[Address(RVA = "0x1CEE0A0", Offset = "0x1CEE0A0", VA = "0x1CEE0A0")]
		public static int opus_encode(IntPtr st, short[] pcm, int frame_size, byte[] data)
		{
			return default(int);
		}

		[Token(Token = "0x600006A")]
		[Address(RVA = "0x1CEDEE0", Offset = "0x1CEDEE0", VA = "0x1CEDEE0")]
		public static int opus_encode(IntPtr st, float[] pcm, int frame_size, byte[] data)
		{
			return default(int);
		}

		[Token(Token = "0x600006B")]
		[Address(RVA = "0x1CEE1F0", Offset = "0x1CEE1F0", VA = "0x1CEE1F0")]
		public static void opus_encoder_destroy(IntPtr st)
		{
		}

		[Token(Token = "0x600006C")]
		[Address(RVA = "0x1CED640", Offset = "0x1CED640", VA = "0x1CED640")]
		public static int get_opus_encoder_ctl(IntPtr st, OpusCtlGetRequest request)
		{
			return default(int);
		}

		[Token(Token = "0x600006D")]
		[Address(RVA = "0x1CED718", Offset = "0x1CED718", VA = "0x1CED718")]
		public static void set_opus_encoder_ctl(IntPtr st, OpusCtlSetRequest request, int value)
		{
		}

		[Token(Token = "0x600006E")]
		[Address(RVA = "0x1CEEE00", Offset = "0x1CEEE00", VA = "0x1CEEE00")]
		public static int get_opus_decoder_ctl(IntPtr st, OpusCtlGetRequest request)
		{
			return default(int);
		}

		[Token(Token = "0x600006F")]
		[Address(RVA = "0x1CEEEC4", Offset = "0x1CEEEC4", VA = "0x1CEEEC4")]
		public static void set_opus_decoder_ctl(IntPtr st, OpusCtlSetRequest request, int value)
		{
		}

		[Token(Token = "0x6000070")]
		[Address(RVA = "0x1CECBE8", Offset = "0x1CECBE8", VA = "0x1CECBE8")]
		public static IntPtr opus_decoder_create(SamplingRate Fs, Channels channels)
		{
			return default(IntPtr);
		}

		[Token(Token = "0x6000071")]
		[Address(RVA = "0x1CED41C", Offset = "0x1CED41C", VA = "0x1CED41C")]
		public static void opus_decoder_destroy(IntPtr st)
		{
		}

		[Token(Token = "0x6000072")]
		[Address(RVA = "0x1CED28C", Offset = "0x1CED28C", VA = "0x1CED28C")]
		public static int opus_decode(IntPtr st, byte[] data, short[] pcm, int decode_fec, int channels)
		{
			return default(int);
		}

		[Token(Token = "0x6000073")]
		[Address(RVA = "0x1CECF78", Offset = "0x1CECF78", VA = "0x1CECF78")]
		public static int opus_decode(IntPtr st, byte[] data, float[] pcm, int decode_fec, int channels)
		{
			return default(int);
		}

		[Token(Token = "0x6000074")]
		[Address(RVA = "0x1CEED34", Offset = "0x1CEED34", VA = "0x1CEED34")]
		private static void HandleStatusCode(OpusStatusCode statusCode)
		{
		}

		[Token(Token = "0x6000075")]
		[Address(RVA = "0x1CEEF7C", Offset = "0x1CEEF7C", VA = "0x1CEEF7C")]
		public Wrapper()
		{
		}
	}
}
namespace POpusCodec.Enums
{
	[Token(Token = "0x200000D")]
	public enum Bandwidth
	{
		[Token(Token = "0x4000048")]
		Narrowband = 1101,
		[Token(Token = "0x4000049")]
		Mediumband,
		[Token(Token = "0x400004A")]
		Wideband,
		[Token(Token = "0x400004B")]
		SuperWideband,
		[Token(Token = "0x400004C")]
		Fullband
	}
	[Token(Token = "0x200000E")]
	public enum Channels
	{
		[Token(Token = "0x400004E")]
		Mono = 1,
		[Token(Token = "0x400004F")]
		Stereo
	}
	[Token(Token = "0x200000F")]
	public enum Complexity
	{
		[Token(Token = "0x4000051")]
		Complexity0,
		[Token(Token = "0x4000052")]
		Complexity1,
		[Token(Token = "0x4000053")]
		Complexity2,
		[Token(Token = "0x4000054")]
		Complexity3,
		[Token(Token = "0x4000055")]
		Complexity4,
		[Token(Token = "0x4000056")]
		Complexity5,
		[Token(Token = "0x4000057")]
		Complexity6,
		[Token(Token = "0x4000058")]
		Complexity7,
		[Token(Token = "0x4000059")]
		Complexity8,
		[Token(Token = "0x400005A")]
		Complexity9,
		[Token(Token = "0x400005B")]
		Complexity10
	}
	[Token(Token = "0x2000010")]
	public enum Delay
	{
		[Token(Token = "0x400005D")]
		Delay2dot5ms = 5,
		[Token(Token = "0x400005E")]
		Delay5ms = 10,
		[Token(Token = "0x400005F")]
		Delay10ms = 20,
		[Token(Token = "0x4000060")]
		Delay20ms = 40,
		[Token(Token = "0x4000061")]
		Delay40ms = 80,
		[Token(Token = "0x4000062")]
		Delay60ms = 120
	}
	[Token(Token = "0x2000011")]
	public enum ForceChannels
	{
		[Token(Token = "0x4000064")]
		NoForce = -1000,
		[Token(Token = "0x4000065")]
		Mono = 1,
		[Token(Token = "0x4000066")]
		Stereo = 2
	}
	[Token(Token = "0x2000012")]
	public enum OpusApplicationType
	{
		[Token(Token = "0x4000068")]
		Voip = 2048,
		[Token(Token = "0x4000069")]
		Audio = 2049,
		[Token(Token = "0x400006A")]
		RestrictedLowDelay = 2051
	}
	[Token(Token = "0x2000013")]
	internal enum OpusCtlGetRequest
	{
		[Token(Token = "0x400006C")]
		Application = 4001,
		[Token(Token = "0x400006D")]
		Bitrate = 4003,
		[Token(Token = "0x400006E")]
		MaxBandwidth = 4005,
		[Token(Token = "0x400006F")]
		VBR = 4007,
		[Token(Token = "0x4000070")]
		Bandwidth = 4009,
		[Token(Token = "0x4000071")]
		Complexity = 4011,
		[Token(Token = "0x4000072")]
		InbandFec = 4013,
		[Token(Token = "0x4000073")]
		PacketLossPercentage = 4015,
		[Token(Token = "0x4000074")]
		Dtx = 4017,
		[Token(Token = "0x4000075")]
		VBRConstraint = 4021,
		[Token(Token = "0x4000076")]
		ForceChannels = 4023,
		[Token(Token = "0x4000077")]
		Signal = 4025,
		[Token(Token = "0x4000078")]
		LookAhead = 4027,
		[Token(Token = "0x4000079")]
		SampleRate = 4029,
		[Token(Token = "0x400007A")]
		FinalRange = 4031,
		[Token(Token = "0x400007B")]
		Pitch = 4033,
		[Token(Token = "0x400007C")]
		Gain = 4035,
		[Token(Token = "0x400007D")]
		LsbDepth = 4037,
		[Token(Token = "0x400007E")]
		LastPacketDurationRequest = 4039
	}
	[Token(Token = "0x2000014")]
	internal enum OpusCtlSetRequest
	{
		[Token(Token = "0x4000080")]
		Application = 4000,
		[Token(Token = "0x4000081")]
		Bitrate = 4002,
		[Token(Token = "0x4000082")]
		MaxBandwidth = 4004,
		[Token(Token = "0x4000083")]
		VBR = 4006,
		[Token(Token = "0x4000084")]
		Bandwidth = 4008,
		[Token(Token = "0x4000085")]
		Complexity = 4010,
		[Token(Token = "0x4000086")]
		InbandFec = 4012,
		[Token(Token = "0x4000087")]
		PacketLossPercentage = 4014,
		[Token(Token = "0x4000088")]
		Dtx = 4016,
		[Token(Token = "0x4000089")]
		VBRConstraint = 4020,
		[Token(Token = "0x400008A")]
		ForceChannels = 4022,
		[Token(Token = "0x400008B")]
		Signal = 4024,
		[Token(Token = "0x400008C")]
		Gain = 4034,
		[Token(Token = "0x400008D")]
		LsbDepth = 4036
	}
	[Token(Token = "0x2000015")]
	public enum OpusStatusCode
	{
		[Token(Token = "0x400008F")]
		OK = 0,
		[Token(Token = "0x4000090")]
		BadArguments = -1,
		[Token(Token = "0x4000091")]
		BufferTooSmall = -2,
		[Token(Token = "0x4000092")]
		InternalError = -3,
		[Token(Token = "0x4000093")]
		InvalidPacket = -4,
		[Token(Token = "0x4000094")]
		Unimplemented = -5,
		[Token(Token = "0x4000095")]
		InvalidState = -6,
		[Token(Token = "0x4000096")]
		AllocFail = -7
	}
	[Token(Token = "0x2000016")]
	public enum SamplingRate
	{
		[Token(Token = "0x4000098")]
		Sampling08000 = 8000,
		[Token(Token = "0x4000099")]
		Sampling12000 = 12000,
		[Token(Token = "0x400009A")]
		Sampling16000 = 16000,
		[Token(Token = "0x400009B")]
		Sampling24000 = 24000,
		[Token(Token = "0x400009C")]
		Sampling48000 = 48000
	}
	[Token(Token = "0x2000017")]
	public enum SignalHint
	{
		[Token(Token = "0x400009E")]
		Auto = -1000,
		[Token(Token = "0x400009F")]
		Voice = 3001,
		[Token(Token = "0x40000A0")]
		Music = 3002
	}
}
namespace ExitGames.Client.Photon.Voice
{
	[Token(Token = "0x2000018")]
	public static class AudioUtil
	{
		[Token(Token = "0x2000080")]
		public class Resampler<T> : LocalVoiceFramed<T>.IProcessor, IDisposable
		{
			[Token(Token = "0x40002FE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			protected T[] frameResampled;

			[Token(Token = "0x40002FF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private int channels;

			[Token(Token = "0x600032D")]
			public Resampler(int dstSize, int channels)
			{
			}

			[Token(Token = "0x600032E")]
			public T[] Process(T[] buf)
			{
				return null;
			}

			[Token(Token = "0x600032F")]
			public void Dispose()
			{
			}
		}

		[Token(Token = "0x2000081")]
		public interface ILevelMeter
		{
			[Token(Token = "0x170000D1")]
			float CurrentAvgAmp
			{
				[Token(Token = "0x6000330")]
				get;
			}

			[Token(Token = "0x170000D2")]
			float CurrentPeakAmp
			{
				[Token(Token = "0x6000331")]
				get;
			}

			[Token(Token = "0x170000D3")]
			float AccumAvgPeakAmp
			{
				[Token(Token = "0x6000332")]
				get;
			}

			[Token(Token = "0x6000333")]
			void ResetAccumAvgPeakAmp();
		}

		[Token(Token = "0x2000082")]
		public class LevelMetterDummy : ILevelMeter
		{
			[Token(Token = "0x170000D4")]
			public float CurrentAvgAmp
			{
				[Token(Token = "0x6000334")]
				[Address(RVA = "0x12771DC", Offset = "0x12771DC", VA = "0x12771DC", Slot = "4")]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x170000D5")]
			public float CurrentPeakAmp
			{
				[Token(Token = "0x6000335")]
				[Address(RVA = "0x12771E4", Offset = "0x12771E4", VA = "0x12771E4", Slot = "5")]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x170000D6")]
			public float AccumAvgPeakAmp
			{
				[Token(Token = "0x6000336")]
				[Address(RVA = "0x12771EC", Offset = "0x12771EC", VA = "0x12771EC", Slot = "6")]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x6000337")]
			[Address(RVA = "0x12771F4", Offset = "0x12771F4", VA = "0x12771F4", Slot = "7")]
			public void ResetAccumAvgPeakAmp()
			{
			}

			[Token(Token = "0x6000338")]
			[Address(RVA = "0x12771F8", Offset = "0x12771F8", VA = "0x12771F8")]
			public LevelMetterDummy()
			{
			}
		}

		[Token(Token = "0x2000083")]
		public abstract class LevelMeter<T> : LocalVoiceFramed<T>.IProcessor, IDisposable, ILevelMeter
		{
			[Token(Token = "0x4000300")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			protected float ampSum;

			[Token(Token = "0x4000301")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			protected float ampPeak;

			[Token(Token = "0x4000302")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			protected int bufferSize;

			[Token(Token = "0x4000303")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			protected float[] buffer;

			[Token(Token = "0x4000304")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			protected int prevValuesPtr;

			[Token(Token = "0x4000305")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			protected float accumAvgPeakAmpSum;

			[Token(Token = "0x4000306")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			protected int accumAvgPeakAmpCount;

			[Token(Token = "0x4000307")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87D9AC", Offset = "0x87D9AC")]
			private float <CurrentPeakAmp>k__BackingField;

			[Token(Token = "0x170000D7")]
			public float CurrentAvgAmp
			{
				[Token(Token = "0x600033A")]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x170000D8")]
			public float CurrentPeakAmp
			{
				[Token(Token = "0x600033B")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87F8B8", Offset = "0x87F8B8")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x600033C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87F8C8", Offset = "0x87F8C8")]
				protected set
				{
				}
			}

			[Token(Token = "0x170000D9")]
			public float AccumAvgPeakAmp
			{
				[Token(Token = "0x600033D")]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x6000339")]
			internal LevelMeter(int samplingRate, int numChannels)
			{
			}

			[Token(Token = "0x600033E")]
			public void ResetAccumAvgPeakAmp()
			{
			}

			[Token(Token = "0x600033F")]
			public abstract T[] Process(T[] buf);

			[Token(Token = "0x6000340")]
			public void Dispose()
			{
			}
		}

		[Token(Token = "0x2000084")]
		public class LevelMeterFloat : LevelMeter<float>
		{
			[Token(Token = "0x6000341")]
			[Address(RVA = "0x1276DA0", Offset = "0x1276DA0", VA = "0x1276DA0")]
			public LevelMeterFloat(int samplingRate, int numChannels)
			{
			}

			[Token(Token = "0x6000342")]
			[Address(RVA = "0x1276E08", Offset = "0x1276E08", VA = "0x1276E08", Slot = "10")]
			public override float[] Process(float[] buf)
			{
				return null;
			}
		}

		[Token(Token = "0x2000085")]
		public class LevelMeterShort : LevelMeter<short>
		{
			[Token(Token = "0x6000343")]
			[Address(RVA = "0x1276FBC", Offset = "0x1276FBC", VA = "0x1276FBC")]
			public LevelMeterShort(int samplingRate, int numChannels)
			{
			}

			[Token(Token = "0x6000344")]
			[Address(RVA = "0x1277024", Offset = "0x1277024", VA = "0x1277024", Slot = "10")]
			public override short[] Process(short[] buf)
			{
				return null;
			}
		}

		[Token(Token = "0x2000086")]
		public interface IVoiceDetector
		{
			[Token(Token = "0x170000DA")]
			bool On
			{
				[Token(Token = "0x6000345")]
				get;
				[Token(Token = "0x6000346")]
				set;
			}

			[Token(Token = "0x170000DB")]
			float Threshold
			{
				[Token(Token = "0x6000347")]
				get;
				[Token(Token = "0x6000348")]
				set;
			}

			[Token(Token = "0x170000DC")]
			bool Detected
			{
				[Token(Token = "0x6000349")]
				get;
			}

			[Token(Token = "0x170000DD")]
			DateTime DetectedTime
			{
				[Token(Token = "0x600034A")]
				get;
			}

			[Token(Token = "0x170000DE")]
			int ActivityDelayMs
			{
				[Token(Token = "0x600034D")]
				get;
				[Token(Token = "0x600034E")]
				set;
			}

			[Token(Token = "0x14000005")]
			event Action OnDetected;
		}

		[Token(Token = "0x2000087")]
		public class VoiceDetectorCalibration<T> : LocalVoiceFramed<T>.IProcessor, IDisposable
		{
			[Token(Token = "0x4000308")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private IVoiceDetector voiceDetector;

			[Token(Token = "0x4000309")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private ILevelMeter levelMeter;

			[Token(Token = "0x400030A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private int valuesPerSec;

			[Token(Token = "0x400030B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			protected int voiceDetectorCalibrateCount;

			[Token(Token = "0x170000DF")]
			public bool VoiceDetectorCalibrating
			{
				[Token(Token = "0x600034F")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x6000350")]
			public VoiceDetectorCalibration(IVoiceDetector voiceDetector, ILevelMeter levelMeter, int samplingRate, int channels)
			{
			}

			[Token(Token = "0x6000351")]
			public void VoiceDetectorCalibrate(int durationMs)
			{
			}

			[Token(Token = "0x6000352")]
			public T[] Process(T[] buf)
			{
				return null;
			}

			[Token(Token = "0x6000353")]
			public void Dispose()
			{
			}
		}

		[Token(Token = "0x2000088")]
		public class VoiceDetectorDummy : IVoiceDetector
		{
			[Token(Token = "0x400030C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87D9BC", Offset = "0x87D9BC")]
			private DateTime <DetectedTime>k__BackingField;

			[Token(Token = "0x170000E0")]
			public bool On
			{
				[Token(Token = "0x6000354")]
				[Address(RVA = "0x1277200", Offset = "0x1277200", VA = "0x1277200", Slot = "4")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6000355")]
				[Address(RVA = "0x1277208", Offset = "0x1277208", VA = "0x1277208", Slot = "5")]
				set
				{
				}
			}

			[Token(Token = "0x170000E1")]
			public float Threshold
			{
				[Token(Token = "0x6000356")]
				[Address(RVA = "0x127720C", Offset = "0x127720C", VA = "0x127720C", Slot = "6")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000357")]
				[Address(RVA = "0x1277214", Offset = "0x1277214", VA = "0x1277214", Slot = "7")]
				set
				{
				}
			}

			[Token(Token = "0x170000E2")]
			public bool Detected
			{
				[Token(Token = "0x6000358")]
				[Address(RVA = "0x1277218", Offset = "0x1277218", VA = "0x1277218", Slot = "8")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x170000E3")]
			public int ActivityDelayMs
			{
				[Token(Token = "0x6000359")]
				[Address(RVA = "0x1277220", Offset = "0x1277220", VA = "0x1277220", Slot = "12")]
				get
				{
					return default(int);
				}
				[Token(Token = "0x600035A")]
				[Address(RVA = "0x1277228", Offset = "0x1277228", VA = "0x1277228", Slot = "13")]
				set
				{
				}
			}

			[Token(Token = "0x170000E4")]
			public DateTime DetectedTime
			{
				[Token(Token = "0x600035B")]
				[Address(RVA = "0x127722C", Offset = "0x127722C", VA = "0x127722C", Slot = "9")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87F8F8", Offset = "0x87F8F8")]
				get
				{
					return default(DateTime);
				}
				[Token(Token = "0x600035C")]
				[Address(RVA = "0x1277234", Offset = "0x1277234", VA = "0x1277234")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87F908", Offset = "0x87F908")]
				private set
				{
				}
			}

			[Token(Token = "0x14000006")]
			public event Action OnDetected
			{
				[Token(Token = "0x600035D")]
				[Address(RVA = "0x127723C", Offset = "0x127723C", VA = "0x127723C", Slot = "10")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87F918", Offset = "0x87F918")]
				add
				{
				}
				[Token(Token = "0x600035E")]
				[Address(RVA = "0x1277328", Offset = "0x1277328", VA = "0x1277328", Slot = "11")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87F928", Offset = "0x87F928")]
				remove
				{
				}
			}

			[Token(Token = "0x600035F")]
			[Address(RVA = "0x1277414", Offset = "0x1277414", VA = "0x1277414")]
			public VoiceDetectorDummy()
			{
			}
		}

		[Token(Token = "0x2000089")]
		public abstract class VoiceDetector<T> : LocalVoiceFramed<T>.IProcessor, IDisposable, IVoiceDetector
		{
			[Token(Token = "0x400030E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87D9DC", Offset = "0x87D9DC")]
			private bool <On>k__BackingField;

			[Token(Token = "0x400030F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87D9EC", Offset = "0x87D9EC")]
			private float <Threshold>k__BackingField;

			[Token(Token = "0x4000310")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private bool detected;

			[Token(Token = "0x4000311")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87D9FC", Offset = "0x87D9FC")]
			private DateTime <DetectedTime>k__BackingField;

			[Token(Token = "0x4000313")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			protected int activityDelay;

			[Token(Token = "0x4000314")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			protected int autoSilenceCounter;

			[Token(Token = "0x4000315")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			protected int valuesCountPerSec;

			[Token(Token = "0x4000316")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			protected int activityDelayValuesCount;

			[Token(Token = "0x170000E5")]
			public bool On
			{
				[Token(Token = "0x6000360")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87F938", Offset = "0x87F938")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6000361")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87F948", Offset = "0x87F948")]
				set
				{
				}
			}

			[Token(Token = "0x170000E6")]
			public float Threshold
			{
				[Token(Token = "0x6000362")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87F958", Offset = "0x87F958")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000363")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87F968", Offset = "0x87F968")]
				set
				{
				}
			}

			[Token(Token = "0x170000E7")]
			public bool Detected
			{
				[Token(Token = "0x6000364")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6000365")]
				protected set
				{
				}
			}

			[Token(Token = "0x170000E8")]
			public DateTime DetectedTime
			{
				[Token(Token = "0x6000366")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87F978", Offset = "0x87F978")]
				get
				{
					return default(DateTime);
				}
				[Token(Token = "0x6000367")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87F988", Offset = "0x87F988")]
				private set
				{
				}
			}

			[Token(Token = "0x170000E9")]
			public int ActivityDelayMs
			{
				[Token(Token = "0x6000368")]
				get
				{
					return default(int);
				}
				[Token(Token = "0x6000369")]
				set
				{
				}
			}

			[Token(Token = "0x14000007")]
			public event Action OnDetected
			{
				[Token(Token = "0x600036A")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87F998", Offset = "0x87F998")]
				add
				{
				}
				[Token(Token = "0x600036B")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87F9A8", Offset = "0x87F9A8")]
				remove
				{
				}
			}

			[Token(Token = "0x600036C")]
			internal VoiceDetector(int samplingRate, int numChannels)
			{
			}

			[Token(Token = "0x600036D")]
			public abstract T[] Process(T[] buf);

			[Token(Token = "0x600036E")]
			public void Dispose()
			{
			}
		}

		[Token(Token = "0x200008A")]
		public class VoiceDetectorFloat : VoiceDetector<float>
		{
			[Token(Token = "0x600036F")]
			[Address(RVA = "0x127741C", Offset = "0x127741C", VA = "0x127741C")]
			public VoiceDetectorFloat(int samplingRate, int numChannels)
			{
			}

			[Token(Token = "0x6000370")]
			[Address(RVA = "0x12774A0", Offset = "0x12774A0", VA = "0x12774A0", Slot = "16")]
			public override float[] Process(float[] buffer)
			{
				return null;
			}
		}

		[Token(Token = "0x200008B")]
		public class VoiceDetectorShort : VoiceDetector<short>
		{
			[Token(Token = "0x6000371")]
			[Address(RVA = "0x12775E8", Offset = "0x12775E8", VA = "0x12775E8")]
			internal VoiceDetectorShort(int samplingRate, int numChannels)
			{
			}

			[Token(Token = "0x6000372")]
			[Address(RVA = "0x127766C", Offset = "0x127766C", VA = "0x127766C", Slot = "16")]
			public override short[] Process(short[] buffer)
			{
				return null;
			}
		}

		[Token(Token = "0x200008C")]
		public class VoiceLevelDetectCalibrate<T> : LocalVoiceFramed<T>.IProcessor, IDisposable
		{
			[Token(Token = "0x4000317")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87DA1C", Offset = "0x87DA1C")]
			private ILevelMeter <Level>k__BackingField;

			[Token(Token = "0x4000318")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87DA2C", Offset = "0x87DA2C")]
			private IVoiceDetector <Detector>k__BackingField;

			[Token(Token = "0x4000319")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private VoiceDetectorCalibration<T> c;

			[Token(Token = "0x170000EA")]
			public ILevelMeter Level
			{
				[Token(Token = "0x6000373")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87F9B8", Offset = "0x87F9B8")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000374")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87F9C8", Offset = "0x87F9C8")]
				private set
				{
				}
			}

			[Token(Token = "0x170000EB")]
			public IVoiceDetector Detector
			{
				[Token(Token = "0x6000375")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87F9D8", Offset = "0x87F9D8")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000376")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87F9E8", Offset = "0x87F9E8")]
				private set
				{
				}
			}

			[Token(Token = "0x6000377")]
			public VoiceLevelDetectCalibrate(int samplingRate, int channels)
			{
			}

			[Token(Token = "0x6000378")]
			public void Calibrate(int durationMs)
			{
			}

			[Token(Token = "0x6000379")]
			public T[] Process(T[] buf)
			{
				return null;
			}

			[Token(Token = "0x600037A")]
			public void Dispose()
			{
			}
		}

		[Token(Token = "0x6000076")]
		public static void Resample<T>(T[] src, T[] dst, int dstCount, int channels)
		{
		}

		[Token(Token = "0x6000077")]
		[Address(RVA = "0x12765E0", Offset = "0x12765E0", VA = "0x12765E0")]
		public static void ResampleAndConvert(short[] src, float[] dst, int dstCount, int channels)
		{
		}

		[Token(Token = "0x6000078")]
		[Address(RVA = "0x12768F8", Offset = "0x12768F8", VA = "0x12768F8")]
		public static void ResampleAndConvert(float[] src, short[] dst, int dstCount, int channels)
		{
		}

		[Token(Token = "0x6000079")]
		[Address(RVA = "0x1276C04", Offset = "0x1276C04", VA = "0x1276C04")]
		public static void Convert(float[] src, short[] dst, int dstCount)
		{
		}

		[Token(Token = "0x600007A")]
		[Address(RVA = "0x1276CD0", Offset = "0x1276CD0", VA = "0x1276CD0")]
		public static void Convert(short[] src, float[] dst, int dstCount)
		{
		}

		[Token(Token = "0x600007B")]
		public static void ForceToStereo<T>(T[] src, T[] dst, int srcChannels)
		{
		}

		[Token(Token = "0x600007C")]
		internal static string tostr<T>(T[] x, int lim = 10)
		{
			return null;
		}
	}
	[Token(Token = "0x2000019")]
	public interface IAudioOut
	{
		[Token(Token = "0x1700001F")]
		bool IsPlaying
		{
			[Token(Token = "0x600007D")]
			get;
		}

		[Token(Token = "0x17000020")]
		int CurrentBufferLag
		{
			[Token(Token = "0x6000082")]
			get;
		}

		[Token(Token = "0x600007E")]
		void Start(int frequency, int channels, int frameSamplesPerChannel, int playDelayMs);

		[Token(Token = "0x600007F")]
		void Stop();

		[Token(Token = "0x6000080")]
		void OnAudioFrame(float[] frame);

		[Token(Token = "0x6000081")]
		void Service();
	}
	[Token(Token = "0x200001A")]
	public abstract class ObjectPool<TType, TInfo> : IDisposable
	{
		[Token(Token = "0x40000A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		protected int capacity;

		[Token(Token = "0x40000A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		protected TInfo info;

		[Token(Token = "0x40000A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private TType[] freeObj;

		[Token(Token = "0x40000A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		protected int pos;

		[Token(Token = "0x40000A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		protected string name;

		[Token(Token = "0x40000A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private bool inited;

		[Token(Token = "0x17000021")]
		internal string LogPrefix
		{
			[Token(Token = "0x6000086")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000022")]
		public TInfo Info
		{
			[Token(Token = "0x600008A")]
			get
			{
				return (TInfo)null;
			}
		}

		[Token(Token = "0x6000083")]
		protected abstract TType createObject(TInfo info);

		[Token(Token = "0x6000084")]
		protected abstract void destroyObject(TType obj);

		[Token(Token = "0x6000085")]
		protected abstract bool infosMatch(TInfo i0, TInfo i1);

		[Token(Token = "0x6000087")]
		public ObjectPool(int capacity, string name)
		{
		}

		[Token(Token = "0x6000088")]
		public ObjectPool(int capacity, string name, TInfo info)
		{
		}

		[Token(Token = "0x6000089")]
		public void Init(TInfo info)
		{
		}

		[Token(Token = "0x600008B")]
		public TType AcquireOrCreate()
		{
			return (TType)null;
		}

		[Token(Token = "0x600008C")]
		public TType AcquireOrCreate(TInfo info)
		{
			return (TType)null;
		}

		[Token(Token = "0x600008D")]
		public virtual bool Release(TType obj, TInfo objInfo)
		{
			return default(bool);
		}

		[Token(Token = "0x600008E")]
		public virtual bool Release(TType obj)
		{
			return default(bool);
		}

		[Token(Token = "0x600008F")]
		public void Dispose()
		{
		}
	}
	[Token(Token = "0x200001B")]
	public class PrimitiveArrayPool<T> : ObjectPool<T[], int>
	{
		[Token(Token = "0x6000090")]
		public PrimitiveArrayPool(int capacity, string name)
		{
		}

		[Token(Token = "0x6000091")]
		public PrimitiveArrayPool(int capacity, string name, int info)
		{
		}

		[Token(Token = "0x6000092")]
		protected override T[] createObject(int info)
		{
			return null;
		}

		[Token(Token = "0x6000093")]
		protected override void destroyObject(T[] obj)
		{
		}

		[Token(Token = "0x6000094")]
		protected override bool infosMatch(int i0, int i1)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x200001C")]
	public class ImageBufferNativePool<T> : ObjectPool<T, ImageBufferInfo> where T : ImageBufferNative
	{
		[Token(Token = "0x200008D")]
		public delegate T Factory(ImageBufferNativePool<T> pool, ImageBufferInfo info);

		[Token(Token = "0x40000A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Factory factory;

		[Token(Token = "0x6000095")]
		public ImageBufferNativePool(int capacity, Factory factory, string name)
		{
		}

		[Token(Token = "0x6000096")]
		public ImageBufferNativePool(int capacity, Factory factory, string name, ImageBufferInfo info)
		{
		}

		[Token(Token = "0x6000097")]
		protected override T createObject(ImageBufferInfo info)
		{
			return null;
		}

		[Token(Token = "0x6000098")]
		protected override void destroyObject(T obj)
		{
		}

		[Token(Token = "0x6000099")]
		protected override bool infosMatch(ImageBufferInfo i0, ImageBufferInfo i1)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x200001D")]
	public class OpusCodec
	{
		[Token(Token = "0x200008E")]
		public enum FrameDuration
		{
			[Token(Token = "0x400031B")]
			Frame2dot5ms = 2500,
			[Token(Token = "0x400031C")]
			Frame5ms = 5000,
			[Token(Token = "0x400031D")]
			Frame10ms = 10000,
			[Token(Token = "0x400031E")]
			Frame20ms = 20000,
			[Token(Token = "0x400031F")]
			Frame40ms = 40000,
			[Token(Token = "0x4000320")]
			Frame60ms = 60000
		}

		[Token(Token = "0x200008F")]
		public static class EncoderFactory
		{
			[Token(Token = "0x600037F")]
			[Address(RVA = "0x127C3E4", Offset = "0x127C3E4", VA = "0x127C3E4")]
			public static IEncoder Create(VoiceInfo i, LocalVoice localVoice)
			{
				return null;
			}
		}

		[Token(Token = "0x2000090")]
		public abstract class Encoder<T> : IEncoderDataFlowDirect<T>, IEncoderDataFlow<T>, IEncoder, IDisposable
		{
			[Token(Token = "0x4000321")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			protected OpusEncoder encoder;

			[Token(Token = "0x4000322")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			protected bool disposed;

			[Token(Token = "0x6000380")]
			protected Encoder(VoiceInfo i)
			{
			}

			[Token(Token = "0x6000381")]
			public void Dispose()
			{
			}

			[Token(Token = "0x6000382")]
			public abstract ArraySegment<byte> EncodeAndGetOutput(T[] buf);
		}

		[Token(Token = "0x2000091")]
		public class EncoderFloat : Encoder<float>
		{
			[Token(Token = "0x4000323")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static readonly ArraySegment<byte> EmptyBuffer;

			[Token(Token = "0x6000383")]
			[Address(RVA = "0x127C5D4", Offset = "0x127C5D4", VA = "0x127C5D4")]
			internal EncoderFloat(VoiceInfo i)
			{
			}

			[Token(Token = "0x6000384")]
			[Address(RVA = "0x127C6FC", Offset = "0x127C6FC", VA = "0x127C6FC", Slot = "6")]
			public override ArraySegment<byte> EncodeAndGetOutput(float[] buf)
			{
				return default(ArraySegment<byte>);
			}
		}

		[Token(Token = "0x2000092")]
		public class EncoderShort : Encoder<short>
		{
			[Token(Token = "0x4000324")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static readonly ArraySegment<byte> EmptyBuffer;

			[Token(Token = "0x6000386")]
			[Address(RVA = "0x127C668", Offset = "0x127C668", VA = "0x127C668")]
			internal EncoderShort(VoiceInfo i)
			{
			}

			[Token(Token = "0x6000387")]
			[Address(RVA = "0x127C8F4", Offset = "0x127C8F4", VA = "0x127C8F4", Slot = "6")]
			public override ArraySegment<byte> EncodeAndGetOutput(short[] buf)
			{
				return default(ArraySegment<byte>);
			}
		}

		[Token(Token = "0x2000093")]
		public class Decoder : IDecoderDirect, IDecoder, IDisposable
		{
			[Token(Token = "0x4000325")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private OpusDecoder decoder;

			[Token(Token = "0x6000389")]
			[Address(RVA = "0x127C23C", Offset = "0x127C23C", VA = "0x127C23C", Slot = "7")]
			public void Open(VoiceInfo i)
			{
			}

			[Token(Token = "0x600038A")]
			[Address(RVA = "0x127C2D4", Offset = "0x127C2D4", VA = "0x127C2D4", Slot = "4")]
			public byte[] DecodeToByte(byte[] buf)
			{
				return null;
			}

			[Token(Token = "0x600038B")]
			[Address(RVA = "0x127C33C", Offset = "0x127C33C", VA = "0x127C33C", Slot = "5")]
			public float[] DecodeToFloat(byte[] buf)
			{
				return null;
			}

			[Token(Token = "0x600038C")]
			[Address(RVA = "0x127C374", Offset = "0x127C374", VA = "0x127C374", Slot = "6")]
			public short[] DecodeToShort(byte[] buf)
			{
				return null;
			}

			[Token(Token = "0x600038D")]
			[Address(RVA = "0x127C3AC", Offset = "0x127C3AC", VA = "0x127C3AC", Slot = "8")]
			public void Dispose()
			{
			}

			[Token(Token = "0x600038E")]
			[Address(RVA = "0x127C3DC", Offset = "0x127C3DC", VA = "0x127C3DC")]
			public Decoder()
			{
			}
		}

		[Token(Token = "0x2000094")]
		public class Util
		{
			[Token(Token = "0x600038F")]
			[Address(RVA = "0x127CAEC", Offset = "0x127CAEC", VA = "0x127CAEC")]
			internal static int bestEncoderSampleRate(int f)
			{
				return default(int);
			}

			[Token(Token = "0x6000390")]
			[Address(RVA = "0x127CDF8", Offset = "0x127CDF8", VA = "0x127CDF8")]
			public Util()
			{
			}
		}

		[Token(Token = "0x600009A")]
		[Address(RVA = "0x127C234", Offset = "0x127C234", VA = "0x127C234")]
		public OpusCodec()
		{
		}
	}
	[Token(Token = "0x200001E")]
	public class SpeexProcessor : SpeexLib, LocalVoiceFramed<short>.IProcessor, IDisposable
	{
		[Token(Token = "0x2000095")]
		public struct AECLatencyResultType
		{
			[Token(Token = "0x4000326")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int LatencyMs;

			[Token(Token = "0x4000327")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public int LatencyDelayedMs;

			[Token(Token = "0x4000328")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public bool PlayDetected;

			[Token(Token = "0x4000329")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x9")]
			public bool PlayDelayedDetected;

			[Token(Token = "0x400032A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA")]
			public bool RecDetected;
		}

		[Serializable]
		[Token(Token = "0x2000096")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87CFB8", Offset = "0x87CFB8")]
		private sealed class <>c
		{
			[Token(Token = "0x400032B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x400032C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Func<long> <>9__58_0;

			[Token(Token = "0x6000392")]
			[Address(RVA = "0x1CE4034", Offset = "0x1CE4034", VA = "0x1CE4034")]
			public <>c()
			{
			}

			[Token(Token = "0x6000393")]
			[Address(RVA = "0x1CE403C", Offset = "0x1CE403C", VA = "0x1CE403C")]
			internal long <.ctor>b__58_0()
			{
				return default(long);
			}
		}

		[Token(Token = "0x40000A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private bool _AEC;

		[Token(Token = "0x40000A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87D164", Offset = "0x87D164")]
		private int <AECFilterLengthMs>k__BackingField;

		[Token(Token = "0x40000AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private int _AECPlaybackDelayMs;

		[Token(Token = "0x40000AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private bool _AECLatencyDetect;

		[Token(Token = "0x40000AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private int frameSamples;

		[Token(Token = "0x40000AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private int samplingRate;

		[Token(Token = "0x40000AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private int channels;

		[Token(Token = "0x40000AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private int playDelayFrames;

		[Token(Token = "0x40000B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private int playDelayMaxFrames;

		[Token(Token = "0x40000B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private IntPtr stEcho;

		[Token(Token = "0x40000B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private IntPtr st;

		[Token(Token = "0x40000B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private bool disposed;

		[Token(Token = "0x40000B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private short[] resultBuf;

		[Token(Token = "0x40000B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private PrimitiveArrayPool<short> playbackBufPool;

		[Token(Token = "0x40000B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Queue<short[]> playBufQueue;

		[Token(Token = "0x40000B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Framer<float> playFramer;

		[Token(Token = "0x40000B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private int playSamplingRate;

		[Token(Token = "0x40000B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private int playChannels;

		[Token(Token = "0x40000BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private ILogger logger;

		[Token(Token = "0x40000BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Func<long> clockMs;

		[Token(Token = "0x40000BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private AudioUtil.VoiceLevelDetectCalibrate<float> detectPlay;

		[Token(Token = "0x40000BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private AudioUtil.VoiceLevelDetectCalibrate<short> detectPlayCorr;

		[Token(Token = "0x40000BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private AudioUtil.VoiceLevelDetectCalibrate<short> detectRec;

		[Token(Token = "0x40000BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private long detectTimePlay;

		[Token(Token = "0x40000C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private long detectTimePlayDelayed;

		[Token(Token = "0x40000C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private long detectTimeRec;

		[Token(Token = "0x40000C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private int frameCntRec;

		[Token(Token = "0x40000C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		private int frameCntPlay;

		[Token(Token = "0x17000023")]
		public bool AEC
		{
			[Token(Token = "0x600009B")]
			[Address(RVA = "0x1280134", Offset = "0x1280134", VA = "0x1280134")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600009C")]
			[Address(RVA = "0x128013C", Offset = "0x128013C", VA = "0x128013C")]
			set
			{
			}
		}

		[Token(Token = "0x17000024")]
		public int AECFilterLengthMs
		{
			[Token(Token = "0x600009D")]
			[Address(RVA = "0x12801D4", Offset = "0x12801D4", VA = "0x12801D4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87DABC", Offset = "0x87DABC")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600009E")]
			[Address(RVA = "0x12801DC", Offset = "0x12801DC", VA = "0x12801DC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87DACC", Offset = "0x87DACC")]
			set
			{
			}
		}

		[Token(Token = "0x17000025")]
		public int AECPlaybackDelayMs
		{
			[Token(Token = "0x600009F")]
			[Address(RVA = "0x12801E4", Offset = "0x12801E4", VA = "0x12801E4")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60000A0")]
			[Address(RVA = "0x12801EC", Offset = "0x12801EC", VA = "0x12801EC")]
			set
			{
			}
		}

		[Token(Token = "0x17000026")]
		public int AECurrentPlayDelayFrames
		{
			[Token(Token = "0x60000A1")]
			[Address(RVA = "0x12802C4", Offset = "0x12802C4", VA = "0x12802C4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000027")]
		public bool AECLatencyDetect
		{
			[Token(Token = "0x60000A2")]
			[Address(RVA = "0x1280324", Offset = "0x1280324", VA = "0x1280324")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60000A3")]
			[Address(RVA = "0x128032C", Offset = "0x128032C", VA = "0x128032C")]
			set
			{
			}
		}

		[Token(Token = "0x17000028")]
		public AECLatencyResultType AECLatencyResult
		{
			[Token(Token = "0x60000A4")]
			[Address(RVA = "0x1280684", Offset = "0x1280684", VA = "0x1280684")]
			get
			{
				return default(AECLatencyResultType);
			}
		}

		[Token(Token = "0x17000029")]
		public bool Denoise
		{
			[Token(Token = "0x60000A7")]
			[Address(RVA = "0x1280ABC", Offset = "0x1280ABC", VA = "0x1280ABC")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60000A8")]
			[Address(RVA = "0x1280B28", Offset = "0x1280B28", VA = "0x1280B28")]
			set
			{
			}
		}

		[Token(Token = "0x1700002A")]
		public bool AGC
		{
			[Token(Token = "0x60000A9")]
			[Address(RVA = "0x1280B84", Offset = "0x1280B84", VA = "0x1280B84")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60000AA")]
			[Address(RVA = "0x1280BBC", Offset = "0x1280BBC", VA = "0x1280BBC")]
			set
			{
			}
		}

		[Token(Token = "0x1700002B")]
		public float AGCLevel
		{
			[Token(Token = "0x60000AB")]
			[Address(RVA = "0x1280BEC", Offset = "0x1280BEC", VA = "0x1280BEC")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60000AC")]
			[Address(RVA = "0x1280C48", Offset = "0x1280C48", VA = "0x1280C48")]
			set
			{
			}
		}

		[Token(Token = "0x60000A5")]
		[Address(RVA = "0x1280904", Offset = "0x1280904", VA = "0x1280904")]
		public void ResetAEC()
		{
		}

		[Token(Token = "0x60000A6")]
		[Address(RVA = "0x1280A08", Offset = "0x1280A08", VA = "0x1280A08")]
		public void AECLatecnyDetectCaliberate()
		{
		}

		[Token(Token = "0x60000AD")]
		[Address(RVA = "0x1280B58", Offset = "0x1280B58", VA = "0x1280B58")]
		private void set(int param, bool val)
		{
		}

		[Token(Token = "0x60000AE")]
		[Address(RVA = "0x1280C74", Offset = "0x1280C74", VA = "0x1280C74")]
		private void set(int param, float val)
		{
		}

		[Token(Token = "0x60000AF")]
		[Address(RVA = "0x1280AF4", Offset = "0x1280AF4", VA = "0x1280AF4")]
		private bool getBool(int param)
		{
			return default(bool);
		}

		[Token(Token = "0x60000B0")]
		[Address(RVA = "0x1280C1C", Offset = "0x1280C1C", VA = "0x1280C1C")]
		private float getFloat(int param)
		{
			return default(float);
		}

		[Token(Token = "0x60000B1")]
		[Address(RVA = "0x1280C9C", Offset = "0x1280C9C", VA = "0x1280C9C")]
		public SpeexProcessor(ILogger logger, Func<long> clockMs, int frameSize, int samplingRate, int channels, int playSamplingRate, int playChannels, int playBufSize)
		{
		}

		[Token(Token = "0x60000B2")]
		[Address(RVA = "0x1280358", Offset = "0x1280358", VA = "0x1280358")]
		private void InitLatencyDetect()
		{
		}

		[Token(Token = "0x60000B3")]
		[Address(RVA = "0x1280F98", Offset = "0x1280F98", VA = "0x1280F98")]
		public void InitAEC()
		{
		}

		[Token(Token = "0x60000B4")]
		[Address(RVA = "0x1280204", Offset = "0x1280204", VA = "0x1280204")]
		private void InitPlayDelay(int ms)
		{
		}

		[Token(Token = "0x60000B5")]
		[Address(RVA = "0x128185C", Offset = "0x128185C", VA = "0x128185C", Slot = "4")]
		public short[] Process(short[] buf)
		{
			return null;
		}

		[Token(Token = "0x60000B6")]
		[Address(RVA = "0x1281BF0", Offset = "0x1281BF0", VA = "0x1281BF0")]
		public void OnAudioOutFrame(float[] data, int outChannels)
		{
		}

		[Token(Token = "0x60000B7")]
		[Address(RVA = "0x1282580", Offset = "0x1282580", VA = "0x1282580")]
		public void PrintInfo()
		{
		}

		[Token(Token = "0x60000B8")]
		[Address(RVA = "0x1280998", Offset = "0x1280998", VA = "0x1280998")]
		private void DestroyEchoState()
		{
		}

		[Token(Token = "0x60000B9")]
		[Address(RVA = "0x1282584", Offset = "0x1282584", VA = "0x1282584", Slot = "5")]
		public void Dispose()
		{
		}

		[Token(Token = "0x60000BA")]
		[Address(RVA = "0x1282678", Offset = "0x1282678", VA = "0x1282678")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87DADC", Offset = "0x87DADC")]
		private void <InitLatencyDetect>b__59_0()
		{
		}

		[Token(Token = "0x60000BB")]
		[Address(RVA = "0x12826E0", Offset = "0x12826E0", VA = "0x12826E0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87DAEC", Offset = "0x87DAEC")]
		private void <InitLatencyDetect>b__59_1()
		{
		}

		[Token(Token = "0x60000BC")]
		[Address(RVA = "0x1282748", Offset = "0x1282748", VA = "0x1282748")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87DAFC", Offset = "0x87DAFC")]
		private void <InitLatencyDetect>b__59_2()
		{
		}
	}
	[Token(Token = "0x200001F")]
	public class SpeexLib
	{
		[Token(Token = "0x40000C4")]
		private const string lib_name = "libspeexdsp";

		[Token(Token = "0x40000C5")]
		public const int SPEEX_PREPROCESS_SET_DENOISE = 0;

		[Token(Token = "0x40000C6")]
		public const int SPEEX_PREPROCESS_GET_DENOISE = 1;

		[Token(Token = "0x40000C7")]
		public const int SPEEX_PREPROCESS_SET_AGC = 2;

		[Token(Token = "0x40000C8")]
		public const int SPEEX_PREPROCESS_GET_AGC = 3;

		[Token(Token = "0x40000C9")]
		public const int SPEEX_PREPROCESS_SET_VAD = 4;

		[Token(Token = "0x40000CA")]
		public const int SPEEX_PREPROCESS_GET_VAD = 5;

		[Token(Token = "0x40000CB")]
		public const int SPEEX_PREPROCESS_SET_AGC_LEVEL = 6;

		[Token(Token = "0x40000CC")]
		public const int SPEEX_PREPROCESS_GET_AGC_LEVEL = 7;

		[Token(Token = "0x40000CD")]
		public const int SPEEX_PREPROCESS_SET_DEREVERB = 8;

		[Token(Token = "0x40000CE")]
		public const int SPEEX_PREPROCESS_GET_DEREVERB = 9;

		[Token(Token = "0x40000CF")]
		public const int SPEEX_PREPROCESS_SET_DEREVERB_LEVEL = 10;

		[Token(Token = "0x40000D0")]
		public const int SPEEX_PREPROCESS_GET_DEREVERB_LEVEL = 11;

		[Token(Token = "0x40000D1")]
		public const int SPEEX_PREPROCESS_SET_DEREVERB_DECAY = 12;

		[Token(Token = "0x40000D2")]
		public const int SPEEX_PREPROCESS_GET_DEREVERB_DECAY = 13;

		[Token(Token = "0x40000D3")]
		public const int SPEEX_PREPROCESS_SET_PROB_START = 14;

		[Token(Token = "0x40000D4")]
		public const int SPEEX_PREPROCESS_GET_PROB_START = 15;

		[Token(Token = "0x40000D5")]
		public const int SPEEX_PREPROCESS_SET_PROB_CONTINUE = 16;

		[Token(Token = "0x40000D6")]
		public const int SPEEX_PREPROCESS_GET_PROB_CONTINUE = 17;

		[Token(Token = "0x40000D7")]
		public const int SPEEX_PREPROCESS_SET_NOISE_SUPPRESS = 18;

		[Token(Token = "0x40000D8")]
		public const int SPEEX_PREPROCESS_GET_NOISE_SUPPRESS = 19;

		[Token(Token = "0x40000D9")]
		public const int SPEEX_PREPROCESS_SET_ECHO_SUPPRESS = 20;

		[Token(Token = "0x40000DA")]
		public const int SPEEX_PREPROCESS_GET_ECHO_SUPPRESS = 21;

		[Token(Token = "0x40000DB")]
		public const int SPEEX_PREPROCESS_SET_ECHO_SUPPRESS_ACTIVE = 22;

		[Token(Token = "0x40000DC")]
		public const int SPEEX_PREPROCESS_GET_ECHO_SUPPRESS_ACTIVE = 23;

		[Token(Token = "0x40000DD")]
		public const int SPEEX_PREPROCESS_SET_ECHO_STATE = 24;

		[Token(Token = "0x40000DE")]
		public const int SPEEX_PREPROCESS_GET_ECHO_STATE = 25;

		[Token(Token = "0x40000DF")]
		public const int SPEEX_PREPROCESS_SET_AGC_INCREMENT = 26;

		[Token(Token = "0x40000E0")]
		public const int SPEEX_PREPROCESS_GET_AGC_INCREMENT = 27;

		[Token(Token = "0x40000E1")]
		public const int SPEEX_PREPROCESS_SET_AGC_DECREMENT = 28;

		[Token(Token = "0x40000E2")]
		public const int SPEEX_PREPROCESS_GET_AGC_DECREMENT = 29;

		[Token(Token = "0x40000E3")]
		public const int SPEEX_PREPROCESS_SET_AGC_MAX_GAIN = 30;

		[Token(Token = "0x40000E4")]
		public const int SPEEX_PREPROCESS_GET_AGC_MAX_GAIN = 31;

		[Token(Token = "0x40000E5")]
		public const int SPEEX_PREPROCESS_GET_AGC_LOUDNESS = 33;

		[Token(Token = "0x40000E6")]
		public const int SPEEX_PREPROCESS_GET_AGC_GAIN = 35;

		[Token(Token = "0x40000E7")]
		public const int SPEEX_PREPROCESS_GET_PSD_SIZE = 37;

		[Token(Token = "0x40000E8")]
		public const int SPEEX_PREPROCESS_GET_PSD = 39;

		[Token(Token = "0x40000E9")]
		public const int SPEEX_PREPROCESS_GET_NOISE_PSD_SIZE = 41;

		[Token(Token = "0x40000EA")]
		public const int SPEEX_PREPROCESS_GET_NOISE_PSD = 43;

		[Token(Token = "0x40000EB")]
		public const int SPEEX_PREPROCESS_GET_PROB = 45;

		[Token(Token = "0x40000EC")]
		public const int SPEEX_PREPROCESS_SET_AGC_TARGET = 46;

		[Token(Token = "0x40000ED")]
		public const int SPEEX_PREPROCESS_GET_AGC_TARGET = 47;

		[Token(Token = "0x40000EE")]
		public const int SPEEX_ECHO_GET_FRAME_SIZE = 3;

		[Token(Token = "0x40000EF")]
		public const int SPEEX_ECHO_SET_SAMPLING_RATE = 24;

		[Token(Token = "0x40000F0")]
		public const int SPEEX_ECHO_GET_SAMPLING_RATE = 25;

		[Token(Token = "0x40000F1")]
		public const int SPEEX_ECHO_GET_IMPULSE_RESPONSE_SIZE = 27;

		[Token(Token = "0x40000F2")]
		public const int SPEEX_ECHO_GET_IMPULSE_RESPONSE = 29;

		[PreserveSig]
		[Token(Token = "0x60000BD")]
		[Address(RVA = "0x127F3F0", Offset = "0x127F3F0", VA = "0x127F3F0")]
		public static extern IntPtr speex_preprocess_state_init(int frame_size, int sampling_rate);

		[PreserveSig]
		[Token(Token = "0x60000BE")]
		[Address(RVA = "0x127F49C", Offset = "0x127F49C", VA = "0x127F49C")]
		public static extern void speex_preprocess_state_destroy(IntPtr st);

		[PreserveSig]
		[Token(Token = "0x60000BF")]
		[Address(RVA = "0x127F538", Offset = "0x127F538", VA = "0x127F538")]
		public static extern int speex_preprocess_run(IntPtr st, short[] x);

		[PreserveSig]
		[Token(Token = "0x60000C0")]
		[Address(RVA = "0x127F5EC", Offset = "0x127F5EC", VA = "0x127F5EC")]
		public static extern int speex_preprocess_ctl(IntPtr st, int request, IntPtr ptr);

		[Token(Token = "0x60000C1")]
		[Address(RVA = "0x127F69C", Offset = "0x127F69C", VA = "0x127F69C")]
		public static int speex_preprocess_ctl(IntPtr st, int request, ref int value)
		{
			return default(int);
		}

		[Token(Token = "0x60000C2")]
		[Address(RVA = "0x127F7DC", Offset = "0x127F7DC", VA = "0x127F7DC")]
		public static int speex_preprocess_ctl(IntPtr st, int request, ref float value)
		{
			return default(int);
		}

		[PreserveSig]
		[Token(Token = "0x60000C3")]
		[Address(RVA = "0x127F8FC", Offset = "0x127F8FC", VA = "0x127F8FC")]
		public static extern IntPtr speex_echo_state_init(int frame_size, int filter_length);

		[PreserveSig]
		[Token(Token = "0x60000C4")]
		[Address(RVA = "0x127F9A8", Offset = "0x127F9A8", VA = "0x127F9A8")]
		public static extern IntPtr speex_echo_state_init_mc(int frame_size, int filter_length, int nb_mic, int nb_speakers);

		[PreserveSig]
		[Token(Token = "0x60000C5")]
		[Address(RVA = "0x127FA6C", Offset = "0x127FA6C", VA = "0x127FA6C")]
		public static extern void speex_echo_state_destroy(IntPtr st);

		[PreserveSig]
		[Token(Token = "0x60000C6")]
		[Address(RVA = "0x127FB08", Offset = "0x127FB08", VA = "0x127FB08")]
		public static extern void speex_echo_cancellation(IntPtr st, short[] rec, short[] play, short[] outBuf);

		[PreserveSig]
		[Token(Token = "0x60000C7")]
		[Address(RVA = "0x127FBE4", Offset = "0x127FBE4", VA = "0x127FBE4")]
		public static extern void speex_echo_capture(IntPtr st, short[] rec, short[] outBuf);

		[PreserveSig]
		[Token(Token = "0x60000C8")]
		[Address(RVA = "0x127FCA8", Offset = "0x127FCA8", VA = "0x127FCA8")]
		public static extern void speex_echo_playback(IntPtr st, short[] play);

		[PreserveSig]
		[Token(Token = "0x60000C9")]
		[Address(RVA = "0x127FD5C", Offset = "0x127FD5C", VA = "0x127FD5C")]
		public static extern void speex_echo_state_reset(IntPtr st);

		[PreserveSig]
		[Token(Token = "0x60000CA")]
		[Address(RVA = "0x127FDF8", Offset = "0x127FDF8", VA = "0x127FDF8")]
		public static extern int speex_echo_ctl(IntPtr st, int request, IntPtr ptr);

		[Token(Token = "0x60000CB")]
		[Address(RVA = "0x127FEAC", Offset = "0x127FEAC", VA = "0x127FEAC")]
		public static int speex_echo_ctl(IntPtr st, int request, ref int value)
		{
			return default(int);
		}

		[Token(Token = "0x60000CC")]
		[Address(RVA = "0x127FFEC", Offset = "0x127FFEC", VA = "0x127FFEC")]
		public static int speex_echo_ctl(IntPtr st, int request, ref float value)
		{
			return default(int);
		}

		[Token(Token = "0x60000CD")]
		[Address(RVA = "0x128012C", Offset = "0x128012C", VA = "0x128012C")]
		public SpeexLib()
		{
		}
	}
	[Token(Token = "0x2000020")]
	public interface IDataReader<T> : IDisposable
	{
		[Token(Token = "0x60000CE")]
		bool Read(T[] buffer);
	}
	[Token(Token = "0x2000021")]
	public interface IServiceable
	{
		[Token(Token = "0x60000CF")]
		void Service(LocalVoice localVoice);
	}
	[Token(Token = "0x2000022")]
	public class LocalVoice : IDisposable
	{
		[Token(Token = "0x40000F3")]
		public const int DATA_POOL_CAPACITY = 50;

		[Token(Token = "0x40000F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87D174", Offset = "0x87D174")]
		private byte <Group>k__BackingField;

		[Token(Token = "0x40000F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87D184", Offset = "0x87D184")]
		private bool <Transmit>k__BackingField;

		[Token(Token = "0x40000F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x12")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87D194", Offset = "0x87D194")]
		private bool <IsTransmitting>k__BackingField;

		[Token(Token = "0x40000F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87D1A4", Offset = "0x87D1A4")]
		private int <FramesSent>k__BackingField;

		[Token(Token = "0x40000F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87D1B4", Offset = "0x87D1B4")]
		private int <FramesSentBytes>k__BackingField;

		[Token(Token = "0x40000F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87D1C4", Offset = "0x87D1C4")]
		private bool <Reliable>k__BackingField;

		[Token(Token = "0x40000FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87D1D4", Offset = "0x87D1D4")]
		private bool <Encrypt>k__BackingField;

		[Token(Token = "0x40000FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87D1E4", Offset = "0x87D1E4")]
		private object <LocalUserObject>k__BackingField;

		[Token(Token = "0x40000FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87D1F4", Offset = "0x87D1F4")]
		private IServiceable <LocalUserServiceable>k__BackingField;

		[Token(Token = "0x40000FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private bool debugEchoMode;

		[Token(Token = "0x40000FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		internal VoiceInfo info;

		[Token(Token = "0x40000FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		protected IEncoder encoder;

		[Token(Token = "0x4000100")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		internal byte id;

		[Token(Token = "0x4000101")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		internal int channelId;

		[Token(Token = "0x4000102")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		internal byte evNumber;

		[Token(Token = "0x4000103")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		protected VoiceClient voiceClient;

		[Token(Token = "0x4000104")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		protected bool disposed;

		[Token(Token = "0x4000105")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		protected object disposeLock;

		[Token(Token = "0x4000106")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private int noTransmitCnt;

		[Token(Token = "0x4000107")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		internal Dictionary<byte, int> eventTimestamps;

		[Token(Token = "0x1700002C")]
		public byte Group
		{
			[Token(Token = "0x60000D0")]
			[Address(RVA = "0x12791A0", Offset = "0x12791A0", VA = "0x12791A0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87DB0C", Offset = "0x87DB0C")]
			get
			{
				return default(byte);
			}
			[Token(Token = "0x60000D1")]
			[Address(RVA = "0x1279760", Offset = "0x1279760", VA = "0x1279760")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87DB1C", Offset = "0x87DB1C")]
			set
			{
			}
		}

		[Token(Token = "0x1700002D")]
		public VoiceInfo Info
		{
			[Token(Token = "0x60000D2")]
			[Address(RVA = "0x1279768", Offset = "0x1279768", VA = "0x1279768")]
			get
			{
				return default(VoiceInfo);
			}
		}

		[Token(Token = "0x1700002E")]
		public bool Transmit
		{
			[Token(Token = "0x60000D3")]
			[Address(RVA = "0x1279784", Offset = "0x1279784", VA = "0x1279784")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87DB2C", Offset = "0x87DB2C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60000D4")]
			[Address(RVA = "0x127978C", Offset = "0x127978C", VA = "0x127978C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87DB3C", Offset = "0x87DB3C")]
			set
			{
			}
		}

		[Token(Token = "0x1700002F")]
		public bool IsTransmitting
		{
			[Token(Token = "0x60000D5")]
			[Address(RVA = "0x1279798", Offset = "0x1279798", VA = "0x1279798")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87DB4C", Offset = "0x87DB4C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60000D6")]
			[Address(RVA = "0x12797A0", Offset = "0x12797A0", VA = "0x12797A0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87DB5C", Offset = "0x87DB5C")]
			protected set
			{
			}
		}

		[Token(Token = "0x17000030")]
		public int FramesSent
		{
			[Token(Token = "0x60000D7")]
			[Address(RVA = "0x12797AC", Offset = "0x12797AC", VA = "0x12797AC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87DB6C", Offset = "0x87DB6C")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60000D8")]
			[Address(RVA = "0x12797B4", Offset = "0x12797B4", VA = "0x12797B4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87DB7C", Offset = "0x87DB7C")]
			private set
			{
			}
		}

		[Token(Token = "0x17000031")]
		public int FramesSentBytes
		{
			[Token(Token = "0x60000D9")]
			[Address(RVA = "0x12797BC", Offset = "0x12797BC", VA = "0x12797BC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87DB8C", Offset = "0x87DB8C")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60000DA")]
			[Address(RVA = "0x12797C4", Offset = "0x12797C4", VA = "0x12797C4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87DB9C", Offset = "0x87DB9C")]
			private set
			{
			}
		}

		[Token(Token = "0x17000032")]
		public bool Reliable
		{
			[Token(Token = "0x60000DB")]
			[Address(RVA = "0x1279190", Offset = "0x1279190", VA = "0x1279190")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87DBAC", Offset = "0x87DBAC")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60000DC")]
			[Address(RVA = "0x12797CC", Offset = "0x12797CC", VA = "0x12797CC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87DBBC", Offset = "0x87DBBC")]
			set
			{
			}
		}

		[Token(Token = "0x17000033")]
		public bool Encrypt
		{
			[Token(Token = "0x60000DD")]
			[Address(RVA = "0x1279198", Offset = "0x1279198", VA = "0x1279198")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87DBCC", Offset = "0x87DBCC")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60000DE")]
			[Address(RVA = "0x12797D8", Offset = "0x12797D8", VA = "0x12797D8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87DBDC", Offset = "0x87DBDC")]
			set
			{
			}
		}

		[Token(Token = "0x17000034")]
		public object LocalUserObject
		{
			[Token(Token = "0x60000DF")]
			[Address(RVA = "0x12797E4", Offset = "0x12797E4", VA = "0x12797E4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87DBEC", Offset = "0x87DBEC")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000E0")]
			[Address(RVA = "0x12797EC", Offset = "0x12797EC", VA = "0x12797EC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87DBFC", Offset = "0x87DBFC")]
			set
			{
			}
		}

		[Token(Token = "0x17000035")]
		public IServiceable LocalUserServiceable
		{
			[Token(Token = "0x60000E1")]
			[Address(RVA = "0x12797F4", Offset = "0x12797F4", VA = "0x12797F4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87DC0C", Offset = "0x87DC0C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000E2")]
			[Address(RVA = "0x12797FC", Offset = "0x12797FC", VA = "0x12797FC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87DC1C", Offset = "0x87DC1C")]
			set
			{
			}
		}

		[Token(Token = "0x17000036")]
		public bool DebugEchoMode
		{
			[Token(Token = "0x60000E3")]
			[Address(RVA = "0x12784C0", Offset = "0x12784C0", VA = "0x12784C0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60000E4")]
			[Address(RVA = "0x1279804", Offset = "0x1279804", VA = "0x1279804")]
			set
			{
			}
		}

		[Token(Token = "0x17000037")]
		internal string Name
		{
			[Token(Token = "0x60000E7")]
			[Address(RVA = "0x1279A74", Offset = "0x1279A74", VA = "0x1279A74")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000038")]
		internal string LogPrefix
		{
			[Token(Token = "0x60000E8")]
			[Address(RVA = "0x1279C64", Offset = "0x1279C64", VA = "0x1279C64")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60000E5")]
		[Address(RVA = "0x12798F8", Offset = "0x12798F8", VA = "0x12798F8")]
		internal LocalVoice()
		{
		}

		[Token(Token = "0x60000E6")]
		[Address(RVA = "0x1279988", Offset = "0x1279988", VA = "0x1279988")]
		internal LocalVoice(VoiceClient voiceClient, IEncoder encoder, byte id, VoiceInfo voiceInfo, int channelId)
		{
		}

		[Token(Token = "0x60000E9")]
		[Address(RVA = "0x1279CC4", Offset = "0x1279CC4", VA = "0x1279CC4")]
		protected void resetNoTransmitCnt()
		{
		}

		[Token(Token = "0x60000EA")]
		[Address(RVA = "0x1279CD0", Offset = "0x1279CD0", VA = "0x1279CD0", Slot = "5")]
		internal virtual void service()
		{
		}

		[Token(Token = "0x60000EB")]
		[Address(RVA = "0x127A1F4", Offset = "0x127A1F4", VA = "0x127A1F4")]
		internal void sendFrame(ArraySegment<byte> compressed)
		{
		}

		[Token(Token = "0x60000EC")]
		[Address(RVA = "0x127A384", Offset = "0x127A384", VA = "0x127A384")]
		public void RemoveSelf()
		{
		}

		[Token(Token = "0x60000ED")]
		[Address(RVA = "0x127A3BC", Offset = "0x127A3BC", VA = "0x127A3BC", Slot = "6")]
		public virtual void Dispose()
		{
		}
	}
	[Token(Token = "0x2000023")]
	public struct RemoteVoiceOptions
	{
		[Token(Token = "0x4000108")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87D204", Offset = "0x87D204")]
		private Action<byte[]> <OnDecodedFrameByteAction>k__BackingField;

		[Token(Token = "0x4000109")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87D214", Offset = "0x87D214")]
		private Action<float[]> <OnDecodedFrameFloatAction>k__BackingField;

		[Token(Token = "0x400010A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87D224", Offset = "0x87D224")]
		private Action<short[]> <OnDecodedFrameShortAction>k__BackingField;

		[Token(Token = "0x400010B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87D234", Offset = "0x87D234")]
		private Action <OnRemoteVoiceRemoveAction>k__BackingField;

		[Token(Token = "0x400010C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87D244", Offset = "0x87D244")]
		private object <LocalUserObject>k__BackingField;

		[Token(Token = "0x400010D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87D254", Offset = "0x87D254")]
		private IDecoder <Decoder>k__BackingField;

		[Token(Token = "0x17000039")]
		public Action<byte[]> OnDecodedFrameByteAction
		{
			[Token(Token = "0x60000EE")]
			[Address(RVA = "0x933CCC", Offset = "0x933CCC", VA = "0x933CCC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87DC2C", Offset = "0x87DC2C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000EF")]
			[Address(RVA = "0x933CD4", Offset = "0x933CD4", VA = "0x933CD4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87DC3C", Offset = "0x87DC3C")]
			set
			{
			}
		}

		[Token(Token = "0x1700003A")]
		public Action<float[]> OnDecodedFrameFloatAction
		{
			[Token(Token = "0x60000F0")]
			[Address(RVA = "0x933CDC", Offset = "0x933CDC", VA = "0x933CDC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87DC4C", Offset = "0x87DC4C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000F1")]
			[Address(RVA = "0x933CE4", Offset = "0x933CE4", VA = "0x933CE4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87DC5C", Offset = "0x87DC5C")]
			set
			{
			}
		}

		[Token(Token = "0x1700003B")]
		public Action<short[]> OnDecodedFrameShortAction
		{
			[Token(Token = "0x60000F2")]
			[Address(RVA = "0x933CEC", Offset = "0x933CEC", VA = "0x933CEC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87DC6C", Offset = "0x87DC6C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000F3")]
			[Address(RVA = "0x933CF4", Offset = "0x933CF4", VA = "0x933CF4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87DC7C", Offset = "0x87DC7C")]
			set
			{
			}
		}

		[Token(Token = "0x1700003C")]
		public Action OnRemoteVoiceRemoveAction
		{
			[Token(Token = "0x60000F4")]
			[Address(RVA = "0x933CFC", Offset = "0x933CFC", VA = "0x933CFC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87DC8C", Offset = "0x87DC8C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000F5")]
			[Address(RVA = "0x933D04", Offset = "0x933D04", VA = "0x933D04")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87DC9C", Offset = "0x87DC9C")]
			set
			{
			}
		}

		[Token(Token = "0x1700003D")]
		public object LocalUserObject
		{
			[Token(Token = "0x60000F6")]
			[Address(RVA = "0x933D0C", Offset = "0x933D0C", VA = "0x933D0C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87DCAC", Offset = "0x87DCAC")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000F7")]
			[Address(RVA = "0x933D14", Offset = "0x933D14", VA = "0x933D14")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87DCBC", Offset = "0x87DCBC")]
			set
			{
			}
		}

		[Token(Token = "0x1700003E")]
		public IDecoder Decoder
		{
			[Token(Token = "0x60000F8")]
			[Address(RVA = "0x933D1C", Offset = "0x933D1C", VA = "0x933D1C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87DCCC", Offset = "0x87DCCC")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000F9")]
			[Address(RVA = "0x933D24", Offset = "0x933D24", VA = "0x933D24")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87DCDC", Offset = "0x87DCDC")]
			set
			{
			}
		}
	}
	[Token(Token = "0x2000024")]
	internal class RemoteVoice : IDisposable
	{
		[Token(Token = "0x400010E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87D264", Offset = "0x87D264")]
		private VoiceInfo <Info>k__BackingField;

		[Token(Token = "0x400010F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		internal RemoteVoiceOptions options;

		[Token(Token = "0x4000110")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private int channelId;

		[Token(Token = "0x4000111")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private int playerId;

		[Token(Token = "0x4000112")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private byte voiceId;

		[Token(Token = "0x4000113")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x71")]
		private bool disposed;

		[Token(Token = "0x4000114")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private object disposeLock;

		[Token(Token = "0x4000115")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		internal byte lastEvNumber;

		[Token(Token = "0x4000116")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private VoiceClient voiceClient;

		[Token(Token = "0x4000117")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Queue<byte[]> frameQueue;

		[Token(Token = "0x4000118")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private AutoResetEvent frameQueueReady;

		[Token(Token = "0x1700003F")]
		internal VoiceInfo Info
		{
			[Token(Token = "0x60000FA")]
			[Address(RVA = "0x127CE00", Offset = "0x127CE00", VA = "0x127CE00")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87DCEC", Offset = "0x87DCEC")]
			get
			{
				return default(VoiceInfo);
			}
			[Token(Token = "0x60000FB")]
			[Address(RVA = "0x127CE1C", Offset = "0x127CE1C", VA = "0x127CE1C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87DCFC", Offset = "0x87DCFC")]
			private set
			{
			}
		}

		[Token(Token = "0x17000040")]
		protected string Name
		{
			[Token(Token = "0x60000FD")]
			[Address(RVA = "0x127D160", Offset = "0x127D160", VA = "0x127D160")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000041")]
		protected string LogPrefix
		{
			[Token(Token = "0x60000FE")]
			[Address(RVA = "0x127D100", Offset = "0x127D100", VA = "0x127D100")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60000FC")]
		[Address(RVA = "0x127CE30", Offset = "0x127CE30", VA = "0x127CE30")]
		internal RemoteVoice(VoiceClient client, RemoteVoiceOptions options, int channelId, int playerId, byte voiceId, VoiceInfo info, byte lastEventNumber)
		{
		}

		[Token(Token = "0x60000FF")]
		[Address(RVA = "0x127D414", Offset = "0x127D414", VA = "0x127D414")]
		private static byte byteDiff(byte latest, byte last)
		{
			return default(byte);
		}

		[Token(Token = "0x6000100")]
		[Address(RVA = "0x127D424", Offset = "0x127D424", VA = "0x127D424")]
		internal void receiveBytes(byte[] receivedBytes, byte evNumber)
		{
		}

		[Token(Token = "0x6000101")]
		[Address(RVA = "0x127DB64", Offset = "0x127DB64", VA = "0x127DB64")]
		private void receiveFrame(byte[] frame)
		{
		}

		[Token(Token = "0x6000102")]
		[Address(RVA = "0x127D924", Offset = "0x127D924", VA = "0x127D924")]
		private void receiveNullFrames(int count)
		{
		}

		[Token(Token = "0x6000103")]
		[Address(RVA = "0x127DD80", Offset = "0x127DD80", VA = "0x127DD80")]
		private void decodeThread(IDecoder decoder)
		{
		}

		[Token(Token = "0x6000104")]
		[Address(RVA = "0x127E5F4", Offset = "0x127E5F4", VA = "0x127E5F4")]
		private void decodeFrame(IDecoder decoder, byte[] frame)
		{
		}

		[Token(Token = "0x6000105")]
		[Address(RVA = "0x127E874", Offset = "0x127E874", VA = "0x127E874")]
		internal byte[] decodeFrameToByte(byte[] buffer)
		{
			return null;
		}

		[Token(Token = "0x6000106")]
		[Address(RVA = "0x127EB90", Offset = "0x127EB90", VA = "0x127EB90")]
		internal short[] decodeFrameToShort(byte[] buffer)
		{
			return null;
		}

		[Token(Token = "0x6000107")]
		[Address(RVA = "0x127EEB4", Offset = "0x127EEB4", VA = "0x127EEB4")]
		internal float[] decodeFrameToFloat(byte[] buffer)
		{
			return null;
		}

		[Token(Token = "0x6000108")]
		[Address(RVA = "0x127F1D0", Offset = "0x127F1D0", VA = "0x127F1D0")]
		internal void removeAndDispose()
		{
		}

		[Token(Token = "0x6000109")]
		[Address(RVA = "0x127F208", Offset = "0x127F208", VA = "0x127F208", Slot = "4")]
		public void Dispose()
		{
		}

		[Token(Token = "0x600010A")]
		[Address(RVA = "0x127F2DC", Offset = "0x127F2DC", VA = "0x127F2DC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87DD0C", Offset = "0x87DD0C")]
		private void <.ctor>b__10_0()
		{
		}
	}
	[Token(Token = "0x2000025")]
	public interface IAudioSource : IDisposable
	{
		[Token(Token = "0x17000042")]
		int SamplingRate
		{
			[Token(Token = "0x600010B")]
			get;
		}

		[Token(Token = "0x17000043")]
		int Channels
		{
			[Token(Token = "0x600010C")]
			get;
		}
	}
	[Token(Token = "0x2000026")]
	public interface IAudioReader<T> : IDataReader<T>, IDisposable, IAudioSource
	{
	}
	[Token(Token = "0x2000027")]
	public interface IAudioPusher<T> : IAudioSource, IDisposable
	{
		[Token(Token = "0x600010D")]
		void SetCallback(Action<T[]> callback, LocalVoice localVoice);
	}
	[Token(Token = "0x2000028")]
	public interface ILocalVoiceAudio
	{
		[Token(Token = "0x17000044")]
		AudioUtil.IVoiceDetector VoiceDetector
		{
			[Token(Token = "0x600010E")]
			get;
		}

		[Token(Token = "0x17000045")]
		AudioUtil.ILevelMeter LevelMeter
		{
			[Token(Token = "0x600010F")]
			get;
		}

		[Token(Token = "0x17000046")]
		bool VoiceDetectorCalibrating
		{
			[Token(Token = "0x6000110")]
			get;
		}

		[Token(Token = "0x6000111")]
		void VoiceDetectorCalibrate(int durationMs);
	}
	[Token(Token = "0x2000029")]
	public static class LocalVoiceAudio
	{
		[Token(Token = "0x4000119")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static LocalVoiceAudioDummy Dummy;

		[Token(Token = "0x6000112")]
		public static LocalVoiceAudio<T> Create<T>(VoiceClient voiceClient, byte voiceId, IEncoder encoder, VoiceInfo voiceInfo, int channelId)
		{
			return null;
		}
	}
	[Token(Token = "0x200002A")]
	public abstract class LocalVoiceAudio<T> : LocalVoiceFramed<T>, ILocalVoiceAudio
	{
		[Token(Token = "0x400011A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		protected AudioUtil.VoiceDetector<T> voiceDetector;

		[Token(Token = "0x400011B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		protected AudioUtil.VoiceDetectorCalibration<T> voiceDetectorCalibration;

		[Token(Token = "0x400011C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		protected AudioUtil.LevelMeter<T> levelMeter;

		[Token(Token = "0x400011D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		protected int channels;

		[Token(Token = "0x400011E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		protected int sourceSamplingRateHz;

		[Token(Token = "0x400011F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		protected bool resampleSource;

		[Token(Token = "0x17000047")]
		public virtual AudioUtil.IVoiceDetector VoiceDetector
		{
			[Token(Token = "0x6000114")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000048")]
		public virtual AudioUtil.ILevelMeter LevelMeter
		{
			[Token(Token = "0x6000115")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000049")]
		public bool VoiceDetectorCalibrating
		{
			[Token(Token = "0x6000117")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000116")]
		public void VoiceDetectorCalibrate(int durationMs)
		{
		}

		[Token(Token = "0x6000118")]
		internal LocalVoiceAudio(VoiceClient voiceClient, IEncoderDataFlow<T> encoder, byte id, VoiceInfo voiceInfo, int channelId)
		{
		}

		[Token(Token = "0x6000119")]
		protected void initBuiltinProcessors()
		{
		}
	}
	[Token(Token = "0x200002B")]
	public class LocalVoiceAudioDummy : LocalVoice, ILocalVoiceAudio
	{
		[Token(Token = "0x4000120")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private AudioUtil.VoiceDetectorDummy voiceDetector;

		[Token(Token = "0x4000121")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private AudioUtil.LevelMetterDummy levelMeter;

		[Token(Token = "0x1700004A")]
		public AudioUtil.IVoiceDetector VoiceDetector
		{
			[Token(Token = "0x600011A")]
			[Address(RVA = "0x127A574", Offset = "0x127A574", VA = "0x127A574", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700004B")]
		public AudioUtil.ILevelMeter LevelMeter
		{
			[Token(Token = "0x600011B")]
			[Address(RVA = "0x127A57C", Offset = "0x127A57C", VA = "0x127A57C", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700004C")]
		public bool VoiceDetectorCalibrating
		{
			[Token(Token = "0x600011C")]
			[Address(RVA = "0x127A584", Offset = "0x127A584", VA = "0x127A584", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600011D")]
		[Address(RVA = "0x127A58C", Offset = "0x127A58C", VA = "0x127A58C", Slot = "10")]
		public void VoiceDetectorCalibrate(int durationMs)
		{
		}

		[Token(Token = "0x600011E")]
		[Address(RVA = "0x127A4EC", Offset = "0x127A4EC", VA = "0x127A4EC")]
		public LocalVoiceAudioDummy()
		{
		}
	}
	[Token(Token = "0x200002C")]
	public class LocalVoiceAudioFloat : LocalVoiceAudio<float>
	{
		[Token(Token = "0x600011F")]
		[Address(RVA = "0x127A590", Offset = "0x127A590", VA = "0x127A590")]
		internal LocalVoiceAudioFloat(VoiceClient voiceClient, IEncoderDataFlow<float> encoder, byte id, VoiceInfo voiceInfo, int channelId)
		{
		}
	}
	[Token(Token = "0x200002D")]
	public class LocalVoiceAudioShort : LocalVoiceAudio<short>
	{
		[Token(Token = "0x6000120")]
		[Address(RVA = "0x127A6FC", Offset = "0x127A6FC", VA = "0x127A6FC")]
		internal LocalVoiceAudioShort(VoiceClient voiceClient, IEncoderDataFlow<short> encoder, byte id, VoiceInfo voiceInfo, int channelId)
		{
		}
	}
	[Token(Token = "0x200002E")]
	internal enum EventSubcode : byte
	{
		[Token(Token = "0x4000123")]
		VoiceInfo = 1,
		[Token(Token = "0x4000124")]
		VoiceRemove,
		[Token(Token = "0x4000125")]
		Frame
	}
	[Token(Token = "0x200002F")]
	internal enum EventParam : byte
	{
		[Token(Token = "0x4000127")]
		VoiceId = 1,
		[Token(Token = "0x4000128")]
		SamplingRate = 2,
		[Token(Token = "0x4000129")]
		Channels = 3,
		[Token(Token = "0x400012A")]
		FrameDurationUs = 4,
		[Token(Token = "0x400012B")]
		Bitrate = 5,
		[Token(Token = "0x400012C")]
		UserData = 10,
		[Token(Token = "0x400012D")]
		EventNumber = 11,
		[Token(Token = "0x400012E")]
		Codec = 12
	}
	[Token(Token = "0x2000030")]
	public interface ILogger
	{
		[Token(Token = "0x6000121")]
		void LogError(string fmt, params object[] args);

		[Token(Token = "0x6000122")]
		void LogWarning(string fmt, params object[] args);

		[Token(Token = "0x6000123")]
		void LogInfo(string fmt, params object[] args);

		[Token(Token = "0x6000124")]
		void LogDebug(string fmt, params object[] args);
	}
	[Token(Token = "0x2000031")]
	internal interface IVoiceFrontend : ILogger
	{
		[Token(Token = "0x6000125")]
		int AssignChannel(VoiceInfo v);

		[Token(Token = "0x6000126")]
		bool IsChannelJoined(int channelId);

		[Token(Token = "0x6000127")]
		void SendVoicesInfo(IEnumerable<LocalVoice> voices, int channelId, int targetPlayerId);

		[Token(Token = "0x6000128")]
		void SendVoiceRemove(LocalVoice voice, int channelId, int targetPlayerId);

		[Token(Token = "0x6000129")]
		void SendFrame(ArraySegment<byte> data, byte evNumber, byte voiceId, int channelId, LocalVoice localVoice);

		[Token(Token = "0x600012A")]
		string ChannelIdStr(int channelId);

		[Token(Token = "0x600012B")]
		string PlayerIdStr(int playerId);

		[Token(Token = "0x600012C")]
		void SetDebugEchoMode(LocalVoice v);
	}
	[Token(Token = "0x2000032")]
	public class VoiceClient : IDisposable
	{
		[Token(Token = "0x2000097")]
		public delegate void RemoteVoiceInfoDelegate(int channelId, int playerId, byte voiceId, VoiceInfo voiceInfo, ref RemoteVoiceOptions options);

		[Token(Token = "0x2000098")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87CFC8", Offset = "0x87CFC8")]
		private sealed class <get_RemoteVoiceInfos>d__39 : IEnumerable<RemoteVoiceInfo>, IEnumerable, IEnumerator<RemoteVoiceInfo>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400032D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400032E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private RemoteVoiceInfo <>2__current;

			[Token(Token = "0x400032F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private int <>l__initialThreadId;

			[Token(Token = "0x4000330")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public VoiceClient <>4__this;

			[Token(Token = "0x4000331")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private Dictionary<int, Dictionary<int, Dictionary<byte, RemoteVoice>>>.Enumerator <>7__wrap1;

			[Token(Token = "0x4000332")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private KeyValuePair<int, Dictionary<int, Dictionary<byte, RemoteVoice>>> <channelVoices>5__3;

			[Token(Token = "0x4000333")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			private Dictionary<int, Dictionary<byte, RemoteVoice>>.Enumerator <>7__wrap3;

			[Token(Token = "0x4000334")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			private KeyValuePair<int, Dictionary<byte, RemoteVoice>> <playerVoices>5__5;

			[Token(Token = "0x4000335")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			private Dictionary<byte, RemoteVoice>.Enumerator <>7__wrap5;

			[Token(Token = "0x170000EC")]
			private RemoteVoiceInfo System.Collections.Generic.IEnumerator<ExitGames.Client.Photon.Voice.RemoteVoiceInfo>.Current
			{
				[Token(Token = "0x600039E")]
				[Address(RVA = "0x1CEBB40", Offset = "0x1CEBB40", VA = "0x1CEBB40", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000ED")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60003A0")]
				[Address(RVA = "0x1CEBBB0", Offset = "0x1CEBBB0", VA = "0x1CEBBB0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000398")]
			[Address(RVA = "0x1CE491C", Offset = "0x1CE491C", VA = "0x1CE491C")]
			[DebuggerHidden]
			public <get_RemoteVoiceInfos>d__39(int <>1__state)
			{
			}

			[Token(Token = "0x6000399")]
			[Address(RVA = "0x1CEB568", Offset = "0x1CEB568", VA = "0x1CEB568", Slot = "7")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600039A")]
			[Address(RVA = "0x1CEB700", Offset = "0x1CEB700", VA = "0x1CEB700", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600039B")]
			[Address(RVA = "0x1CEB6A8", Offset = "0x1CEB6A8", VA = "0x1CEB6A8")]
			private void <>m__Finally1()
			{
			}

			[Token(Token = "0x600039C")]
			[Address(RVA = "0x1CEB650", Offset = "0x1CEB650", VA = "0x1CEB650")]
			private void <>m__Finally2()
			{
			}

			[Token(Token = "0x600039D")]
			[Address(RVA = "0x1CEB5F8", Offset = "0x1CEB5F8", VA = "0x1CEB5F8")]
			private void <>m__Finally3()
			{
			}

			[Token(Token = "0x600039F")]
			[Address(RVA = "0x1CEBB48", Offset = "0x1CEBB48", VA = "0x1CEBB48", Slot = "10")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}

			[Token(Token = "0x60003A1")]
			[Address(RVA = "0x1CEBBB8", Offset = "0x1CEBBB8", VA = "0x1CEBBB8", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<RemoteVoiceInfo> System.Collections.Generic.IEnumerable<ExitGames.Client.Photon.Voice.RemoteVoiceInfo>.GetEnumerator()
			{
				return null;
			}

			[Token(Token = "0x60003A2")]
			[Address(RVA = "0x1CEBC68", Offset = "0x1CEBC68", VA = "0x1CEBC68", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator System.Collections.IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Token(Token = "0x2000099")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87CFD8", Offset = "0x87CFD8")]
		private sealed class <get_RemoteVoiceLocalUserObjects>d__41 : IEnumerable<object>, IEnumerable, IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000336")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000337")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000338")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private int <>l__initialThreadId;

			[Token(Token = "0x4000339")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public VoiceClient <>4__this;

			[Token(Token = "0x400033A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private Dictionary<int, Dictionary<int, Dictionary<byte, RemoteVoice>>>.Enumerator <>7__wrap1;

			[Token(Token = "0x400033B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private Dictionary<int, Dictionary<byte, RemoteVoice>>.Enumerator <>7__wrap2;

			[Token(Token = "0x400033C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			private Dictionary<byte, RemoteVoice>.Enumerator <>7__wrap3;

			[Token(Token = "0x170000EE")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60003A9")]
				[Address(RVA = "0x1CEC148", Offset = "0x1CEC148", VA = "0x1CEC148", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000EF")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60003AB")]
				[Address(RVA = "0x1CEC1B8", Offset = "0x1CEC1B8", VA = "0x1CEC1B8", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60003A3")]
			[Address(RVA = "0x1CE49D8", Offset = "0x1CE49D8", VA = "0x1CE49D8")]
			[DebuggerHidden]
			public <get_RemoteVoiceLocalUserObjects>d__41(int <>1__state)
			{
			}

			[Token(Token = "0x60003A4")]
			[Address(RVA = "0x1CEBC6C", Offset = "0x1CEBC6C", VA = "0x1CEBC6C", Slot = "7")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60003A5")]
			[Address(RVA = "0x1CEBE04", Offset = "0x1CEBE04", VA = "0x1CEBE04", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60003A6")]
			[Address(RVA = "0x1CEBDAC", Offset = "0x1CEBDAC", VA = "0x1CEBDAC")]
			private void <>m__Finally1()
			{
			}

			[Token(Token = "0x60003A7")]
			[Address(RVA = "0x1CEBD54", Offset = "0x1CEBD54", VA = "0x1CEBD54")]
			private void <>m__Finally2()
			{
			}

			[Token(Token = "0x60003A8")]
			[Address(RVA = "0x1CEBCFC", Offset = "0x1CEBCFC", VA = "0x1CEBCFC")]
			private void <>m__Finally3()
			{
			}

			[Token(Token = "0x60003AA")]
			[Address(RVA = "0x1CEC150", Offset = "0x1CEC150", VA = "0x1CEC150", Slot = "10")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}

			[Token(Token = "0x60003AC")]
			[Address(RVA = "0x1CEC1C0", Offset = "0x1CEC1C0", VA = "0x1CEC1C0", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<object> System.Collections.Generic.IEnumerable<System.Object>.GetEnumerator()
			{
				return null;
			}

			[Token(Token = "0x60003AD")]
			[Address(RVA = "0x1CEC270", Offset = "0x1CEC270", VA = "0x1CEC270", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator System.Collections.IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Token(Token = "0x200009A")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87CFE8", Offset = "0x87CFE8")]
		private sealed class <>c__DisplayClass46_0
		{
			[Token(Token = "0x400033D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public VoiceClient <>4__this;

			[Token(Token = "0x400033E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public IEncoder encoder;

			[Token(Token = "0x400033F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public VoiceInfo voiceInfo;

			[Token(Token = "0x60003AE")]
			[Address(RVA = "0x1CE5BEC", Offset = "0x1CE5BEC", VA = "0x1CE5BEC")]
			public <>c__DisplayClass46_0()
			{
			}

			[Token(Token = "0x60003AF")]
			[Address(RVA = "0x1CEB4B8", Offset = "0x1CEB4B8", VA = "0x1CEB4B8")]
			internal LocalVoice <CreateLocalVoice>b__0(byte vId, int chId)
			{
				return null;
			}
		}

		[Token(Token = "0x200009B")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87CFF8", Offset = "0x87CFF8")]
		private sealed class <>c__DisplayClass47_0<T>
		{
			[Token(Token = "0x4000340")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public VoiceClient <>4__this;

			[Token(Token = "0x4000341")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public IEncoderDataFlow<T> encoder;

			[Token(Token = "0x4000342")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public VoiceInfo voiceInfo;

			[Token(Token = "0x4000343")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int frameSize;

			[Token(Token = "0x60003B0")]
			public <>c__DisplayClass47_0()
			{
			}

			[Token(Token = "0x60003B1")]
			internal LocalVoice <CreateLocalVoiceFramed>b__0(byte vId, int chId)
			{
				return null;
			}
		}

		[Token(Token = "0x200009C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87D008", Offset = "0x87D008")]
		private sealed class <>c__DisplayClass48_0<T>
		{
			[Token(Token = "0x4000344")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public VoiceClient <>4__this;

			[Token(Token = "0x4000345")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public IEncoderDataFlow<T> encoder;

			[Token(Token = "0x4000346")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public VoiceInfo voiceInfo;

			[Token(Token = "0x60003B2")]
			public <>c__DisplayClass48_0()
			{
			}

			[Token(Token = "0x60003B3")]
			internal LocalVoice <CreateLocalVoiceAudio>b__0(byte vId, int chId)
			{
				return null;
			}
		}

		[Token(Token = "0x400012F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		internal IVoiceFrontend frontend;

		[Token(Token = "0x4000130")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87D274", Offset = "0x87D274")]
		private int <FramesLost>k__BackingField;

		[Token(Token = "0x4000131")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87D284", Offset = "0x87D284")]
		private int <FramesReceived>k__BackingField;

		[Token(Token = "0x4000132")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87D294", Offset = "0x87D294")]
		private int <RoundTripTime>k__BackingField;

		[Token(Token = "0x4000133")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87D2A4", Offset = "0x87D2A4")]
		private int <RoundTripTimeVariance>k__BackingField;

		[Token(Token = "0x4000134")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87D2B4", Offset = "0x87D2B4")]
		private bool <SuppressInfoDuplicateWarning>k__BackingField;

		[Token(Token = "0x4000135")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87D2C4", Offset = "0x87D2C4")]
		private RemoteVoiceInfoDelegate <OnRemoteVoiceInfoAction>k__BackingField;

		[Token(Token = "0x4000136")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87D2D4", Offset = "0x87D2D4")]
		private int <DebugLostPercent>k__BackingField;

		[Token(Token = "0x4000137")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private int prevRtt;

		[Token(Token = "0x4000138")]
		public const int ChannelAuto = -1;

		[Token(Token = "0x4000139")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private byte globalGroup;

		[Token(Token = "0x400013A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x41")]
		private byte voiceIdCnt;

		[Token(Token = "0x400013B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Dictionary<byte, LocalVoice> localVoices;

		[Token(Token = "0x400013C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Dictionary<int, List<LocalVoice>> localVoicesPerChannel;

		[Token(Token = "0x400013D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Dictionary<int, Dictionary<int, Dictionary<byte, RemoteVoice>>> remoteVoices;

		[Token(Token = "0x400013E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private System.Random rnd;

		[Token(Token = "0x1700004D")]
		public int FramesLost
		{
			[Token(Token = "0x600012D")]
			[Address(RVA = "0x1CE4378", Offset = "0x1CE4378", VA = "0x1CE4378")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87DD1C", Offset = "0x87DD1C")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600012E")]
			[Address(RVA = "0x1CE4380", Offset = "0x1CE4380", VA = "0x1CE4380")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87DD2C", Offset = "0x87DD2C")]
			internal set
			{
			}
		}

		[Token(Token = "0x1700004E")]
		public int FramesReceived
		{
			[Token(Token = "0x600012F")]
			[Address(RVA = "0x1CE4388", Offset = "0x1CE4388", VA = "0x1CE4388")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87DD3C", Offset = "0x87DD3C")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000130")]
			[Address(RVA = "0x1CE4390", Offset = "0x1CE4390", VA = "0x1CE4390")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87DD4C", Offset = "0x87DD4C")]
			private set
			{
			}
		}

		[Token(Token = "0x1700004F")]
		public int FramesSent
		{
			[Token(Token = "0x6000131")]
			[Address(RVA = "0x1CE4398", Offset = "0x1CE4398", VA = "0x1CE4398")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000050")]
		public int FramesSentBytes
		{
			[Token(Token = "0x6000132")]
			[Address(RVA = "0x1CE4500", Offset = "0x1CE4500", VA = "0x1CE4500")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000051")]
		public int RoundTripTime
		{
			[Token(Token = "0x6000133")]
			[Address(RVA = "0x1CE4668", Offset = "0x1CE4668", VA = "0x1CE4668")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87DD5C", Offset = "0x87DD5C")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000134")]
			[Address(RVA = "0x1CE4670", Offset = "0x1CE4670", VA = "0x1CE4670")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87DD6C", Offset = "0x87DD6C")]
			private set
			{
			}
		}

		[Token(Token = "0x17000052")]
		public int RoundTripTimeVariance
		{
			[Token(Token = "0x6000135")]
			[Address(RVA = "0x1CE4678", Offset = "0x1CE4678", VA = "0x1CE4678")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87DD7C", Offset = "0x87DD7C")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000136")]
			[Address(RVA = "0x1CE4680", Offset = "0x1CE4680", VA = "0x1CE4680")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87DD8C", Offset = "0x87DD8C")]
			private set
			{
			}
		}

		[Token(Token = "0x17000053")]
		public bool SuppressInfoDuplicateWarning
		{
			[Token(Token = "0x6000137")]
			[Address(RVA = "0x1CE4688", Offset = "0x1CE4688", VA = "0x1CE4688")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87DD9C", Offset = "0x87DD9C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000138")]
			[Address(RVA = "0x1CE4690", Offset = "0x1CE4690", VA = "0x1CE4690")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87DDAC", Offset = "0x87DDAC")]
			set
			{
			}
		}

		[Token(Token = "0x17000054")]
		public RemoteVoiceInfoDelegate OnRemoteVoiceInfoAction
		{
			[Token(Token = "0x6000139")]
			[Address(RVA = "0x1CE469C", Offset = "0x1CE469C", VA = "0x1CE469C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87DDBC", Offset = "0x87DDBC")]
			get
			{
				return null;
			}
			[Token(Token = "0x600013A")]
			[Address(RVA = "0x1CE46A4", Offset = "0x1CE46A4", VA = "0x1CE46A4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87DDCC", Offset = "0x87DDCC")]
			set
			{
			}
		}

		[Token(Token = "0x17000055")]
		public int DebugLostPercent
		{
			[Token(Token = "0x600013B")]
			[Address(RVA = "0x1CE46AC", Offset = "0x1CE46AC", VA = "0x1CE46AC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87DDDC", Offset = "0x87DDDC")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600013C")]
			[Address(RVA = "0x1CE46B4", Offset = "0x1CE46B4", VA = "0x1CE46B4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87DDEC", Offset = "0x87DDEC")]
			set
			{
			}
		}

		[Token(Token = "0x17000056")]
		public IEnumerable<LocalVoice> LocalVoices
		{
			[Token(Token = "0x600013D")]
			[Address(RVA = "0x1CE46BC", Offset = "0x1CE46BC", VA = "0x1CE46BC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000057")]
		public IEnumerable<RemoteVoiceInfo> RemoteVoiceInfos
		{
			[Token(Token = "0x600013F")]
			[Address(RVA = "0x1CE4898", Offset = "0x1CE4898", VA = "0x1CE4898")]
			[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x87DDFC", Offset = "0x87DDFC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000058")]
		public IEnumerable<object> RemoteVoiceLocalUserObjects
		{
			[Token(Token = "0x6000140")]
			[Address(RVA = "0x1CE4954", Offset = "0x1CE4954", VA = "0x1CE4954")]
			[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x87DE60", Offset = "0x87DE60")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000059")]
		internal byte GlobalGroup
		{
			[Token(Token = "0x600014D")]
			[Address(RVA = "0x1CE5BF4", Offset = "0x1CE5BF4", VA = "0x1CE5BF4")]
			get
			{
				return default(byte);
			}
			[Token(Token = "0x600014E")]
			[Address(RVA = "0x1CE87C0", Offset = "0x1CE87C0", VA = "0x1CE87C0")]
			set
			{
			}
		}

		[Token(Token = "0x600013E")]
		[Address(RVA = "0x1CE478C", Offset = "0x1CE478C", VA = "0x1CE478C")]
		public IEnumerable<LocalVoice> LocalVoicesInChannel(int channelId)
		{
			return null;
		}

		[Token(Token = "0x6000141")]
		[Address(RVA = "0x1CE4A10", Offset = "0x1CE4A10", VA = "0x1CE4A10")]
		internal VoiceClient(IVoiceFrontend frontend)
		{
		}

		[Token(Token = "0x6000142")]
		[Address(RVA = "0x1CE4B04", Offset = "0x1CE4B04", VA = "0x1CE4B04")]
		public void Service()
		{
		}

		[Token(Token = "0x6000143")]
		[Address(RVA = "0x1CE4C5C", Offset = "0x1CE4C5C", VA = "0x1CE4C5C")]
		private LocalVoice createLocalVoice(VoiceInfo voiceInfo, int channelId, Func<byte, int, LocalVoice> voiceFactory)
		{
			return null;
		}

		[Token(Token = "0x6000144")]
		[Address(RVA = "0x1CE5A68", Offset = "0x1CE5A68", VA = "0x1CE5A68")]
		public LocalVoice CreateLocalVoice(VoiceInfo voiceInfo, int channelId = -1, [Optional] IEncoder encoder)
		{
			return null;
		}

		[Token(Token = "0x6000145")]
		public LocalVoiceFramed<T> CreateLocalVoiceFramed<T>(VoiceInfo voiceInfo, int frameSize, int channelId = -1, [Optional] IEncoderDataFlow<T> encoder)
		{
			return null;
		}

		[Token(Token = "0x6000146")]
		public LocalVoiceAudio<T> CreateLocalVoiceAudio<T>(VoiceInfo voiceInfo, int channelId = -1, [Optional] IEncoderDataFlow<T> encoder)
		{
			return null;
		}

		[Token(Token = "0x6000147")]
		[Address(RVA = "0x1CE4EBC", Offset = "0x1CE4EBC", VA = "0x1CE4EBC")]
		private byte getNewVoiceId()
		{
			return default(byte);
		}

		[Token(Token = "0x6000148")]
		[Address(RVA = "0x1CE50CC", Offset = "0x1CE50CC", VA = "0x1CE50CC")]
		private void addVoice(byte newId, int channelId, LocalVoice v)
		{
		}

		[Token(Token = "0x6000149")]
		[Address(RVA = "0x1CE5BFC", Offset = "0x1CE5BFC", VA = "0x1CE5BFC")]
		public void RemoveLocalVoice(LocalVoice voice)
		{
		}

		[Token(Token = "0x600014A")]
		[Address(RVA = "0x1CE5ED4", Offset = "0x1CE5ED4", VA = "0x1CE5ED4")]
		internal void sendVoicesInfo(int targetPlayerId)
		{
		}

		[Token(Token = "0x600014B")]
		[Address(RVA = "0x1CE6014", Offset = "0x1CE6014", VA = "0x1CE6014")]
		internal void sendChannelVoicesInfo(int channelId, int targetPlayerId)
		{
		}

		[Token(Token = "0x600014C")]
		[Address(RVA = "0x1CE61A8", Offset = "0x1CE61A8", VA = "0x1CE61A8")]
		internal void onVoiceEvent(object content0, int channelId, int playerId, int localPlayerId)
		{
		}

		[Token(Token = "0x600014F")]
		[Address(RVA = "0x1CE892C", Offset = "0x1CE892C", VA = "0x1CE892C")]
		internal object[] buildVoicesInfo(IEnumerable<LocalVoice> voicesToSend, bool logInfo)
		{
			return null;
		}

		[Token(Token = "0x6000150")]
		[Address(RVA = "0x1CE930C", Offset = "0x1CE930C", VA = "0x1CE930C")]
		internal object[] buildVoiceRemoveMessage(LocalVoice v)
		{
			return null;
		}

		[Token(Token = "0x6000151")]
		[Address(RVA = "0x1CE95AC", Offset = "0x1CE95AC", VA = "0x1CE95AC")]
		internal void clearRemoteVoices()
		{
		}

		[Token(Token = "0x6000152")]
		[Address(RVA = "0x1CE9A80", Offset = "0x1CE9A80", VA = "0x1CE9A80")]
		internal void clearRemoteVoicesInChannel(int channelId)
		{
		}

		[Token(Token = "0x6000153")]
		[Address(RVA = "0x1CE6620", Offset = "0x1CE6620", VA = "0x1CE6620")]
		private void onVoiceInfo(int channelId, int playerId, object payload)
		{
		}

		[Token(Token = "0x6000154")]
		[Address(RVA = "0x1CE7220", Offset = "0x1CE7220", VA = "0x1CE7220")]
		private void onVoiceRemove(int channelId, int playerId, object payload)
		{
		}

		[Token(Token = "0x6000155")]
		[Address(RVA = "0x1CE7DF4", Offset = "0x1CE7DF4", VA = "0x1CE7DF4")]
		private void onFrame(int channelId, int playerId, byte voiceId, byte evNumber, byte[] receivedBytes)
		{
		}

		[Token(Token = "0x6000156")]
		[Address(RVA = "0x1CEAC60", Offset = "0x1CEAC60", VA = "0x1CEAC60")]
		internal bool removePlayerVoices(int playerId)
		{
			return default(bool);
		}

		[Token(Token = "0x6000157")]
		[Address(RVA = "0x1CEADA4", Offset = "0x1CEADA4", VA = "0x1CEADA4")]
		internal bool removePlayerVoices(int channelId, int playerId)
		{
			return default(bool);
		}

		[Token(Token = "0x6000158")]
		[Address(RVA = "0x1CE9E94", Offset = "0x1CE9E94", VA = "0x1CE9E94")]
		internal string channelStr(int channelId)
		{
			return null;
		}

		[Token(Token = "0x6000159")]
		[Address(RVA = "0x1CEA278", Offset = "0x1CEA278", VA = "0x1CEA278")]
		internal string playerStr(int playerId)
		{
			return null;
		}

		[Token(Token = "0x600015A")]
		[Address(RVA = "0x1CEAF9C", Offset = "0x1CEAF9C", VA = "0x1CEAF9C", Slot = "4")]
		public void Dispose()
		{
		}
	}
	[Token(Token = "0x2000033")]
	public interface IEncoder : IDisposable
	{
	}
	[Token(Token = "0x2000034")]
	public interface IEncoderDataFlow<T> : IEncoder, IDisposable
	{
	}
	[Token(Token = "0x2000035")]
	public interface IEncoderDataFlowDirect<T> : IEncoderDataFlow<T>, IEncoder, IDisposable
	{
		[Token(Token = "0x600015B")]
		ArraySegment<byte> EncodeAndGetOutput(T[] buf);
	}
	[Token(Token = "0x2000036")]
	public interface IEncoderNativeImageDirect : IEncoder, IDisposable
	{
		[Token(Token = "0x600015C")]
		IEnumerable<ArraySegment<byte>> EncodeAndGetOutput(IntPtr[] buf, int width, int height, int[] stride, ImageFormat imageFormat, Rotation rotation, Flip flip);
	}
	[Token(Token = "0x2000037")]
	public interface IEncoderQueued : IEncoder, IDisposable
	{
		[Token(Token = "0x600015D")]
		IEnumerable<ArraySegment<byte>> GetOutput();
	}
	[Token(Token = "0x2000038")]
	public interface IDecoder : IDisposable
	{
		[Token(Token = "0x600015E")]
		void Open(VoiceInfo info);
	}
	[Token(Token = "0x2000039")]
	public interface IDecoderDirect : IDecoder, IDisposable
	{
		[Token(Token = "0x600015F")]
		byte[] DecodeToByte(byte[] buf);

		[Token(Token = "0x6000160")]
		float[] DecodeToFloat(byte[] buf);

		[Token(Token = "0x6000161")]
		short[] DecodeToShort(byte[] buf);
	}
	[Token(Token = "0x200003A")]
	public interface IDecoderQueued : IDecoder, IDisposable
	{
		[Token(Token = "0x6000162")]
		void Decode(byte[] buf);
	}
	[Token(Token = "0x200003B")]
	public delegate void OnImageOutputNative(IntPtr buf, int width, int height, int stride);
	[Token(Token = "0x200003C")]
	public interface IDecoderQueuedOutputImageNative : IDecoderQueued, IDecoder, IDisposable
	{
		[Token(Token = "0x1700005A")]
		ImageFormat OutputImageFormat
		{
			[Token(Token = "0x6000167")]
			get;
			[Token(Token = "0x6000168")]
			set;
		}

		[Token(Token = "0x1700005B")]
		Flip OutputImageFlip
		{
			[Token(Token = "0x6000169")]
			get;
			[Token(Token = "0x600016A")]
			set;
		}

		[Token(Token = "0x1700005C")]
		Func<int, int, IntPtr> OutputImageBufferGetter
		{
			[Token(Token = "0x600016B")]
			get;
			[Token(Token = "0x600016C")]
			set;
		}

		[Token(Token = "0x1700005D")]
		OnImageOutputNative OnOutputImage
		{
			[Token(Token = "0x600016D")]
			get;
			[Token(Token = "0x600016E")]
			set;
		}
	}
	[Token(Token = "0x200003D")]
	internal class UnsupportedSampleTypeException : Exception
	{
		[Token(Token = "0x600016F")]
		[Address(RVA = "0x1CE42E0", Offset = "0x1CE42E0", VA = "0x1CE42E0")]
		public UnsupportedSampleTypeException(Type t)
		{
		}
	}
	[Token(Token = "0x200003E")]
	internal class UnsupportedCodecException : Exception
	{
		[Token(Token = "0x6000170")]
		[Address(RVA = "0x1CE40B8", Offset = "0x1CE40B8", VA = "0x1CE40B8")]
		public UnsupportedCodecException(Codec codec, LocalVoice voice)
		{
		}
	}
	[Token(Token = "0x200003F")]
	public enum Codec
	{
		[Token(Token = "0x4000140")]
		AudioOpus = 11
	}
	[Token(Token = "0x2000040")]
	public enum ImageFormat
	{
		[Token(Token = "0x4000142")]
		I420,
		[Token(Token = "0x4000143")]
		YV12,
		[Token(Token = "0x4000144")]
		Android420,
		[Token(Token = "0x4000145")]
		RGBA,
		[Token(Token = "0x4000146")]
		ABGR,
		[Token(Token = "0x4000147")]
		BGRA,
		[Token(Token = "0x4000148")]
		ARGB
	}
	[Token(Token = "0x2000041")]
	public enum Rotation
	{
		[Token(Token = "0x400014A")]
		Rotate0 = 0,
		[Token(Token = "0x400014B")]
		Rotate90 = 90,
		[Token(Token = "0x400014C")]
		Rotate180 = 180,
		[Token(Token = "0x400014D")]
		Rotate270 = 270
	}
	[Token(Token = "0x2000042")]
	public enum Flip
	{
		[Token(Token = "0x400014F")]
		None,
		[Token(Token = "0x4000150")]
		Vertical,
		[Token(Token = "0x4000151")]
		Horizontal
	}
	[Token(Token = "0x2000043")]
	public class ImageBufferInfo
	{
		[Token(Token = "0x4000152")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87D2E4", Offset = "0x87D2E4")]
		private int <Width>k__BackingField;

		[Token(Token = "0x4000153")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87D2F4", Offset = "0x87D2F4")]
		private int <Height>k__BackingField;

		[Token(Token = "0x4000154")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87D304", Offset = "0x87D304")]
		private int[] <Stride>k__BackingField;

		[Token(Token = "0x4000155")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87D314", Offset = "0x87D314")]
		private ImageFormat <Format>k__BackingField;

		[Token(Token = "0x4000156")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87D324", Offset = "0x87D324")]
		private Rotation <Rotation>k__BackingField;

		[Token(Token = "0x4000157")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87D334", Offset = "0x87D334")]
		private Flip <Flip>k__BackingField;

		[Token(Token = "0x1700005E")]
		public int Width
		{
			[Token(Token = "0x6000171")]
			[Address(RVA = "0x1277C08", Offset = "0x1277C08", VA = "0x1277C08")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87DEC4", Offset = "0x87DEC4")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000172")]
			[Address(RVA = "0x1277C10", Offset = "0x1277C10", VA = "0x1277C10")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87DED4", Offset = "0x87DED4")]
			private set
			{
			}
		}

		[Token(Token = "0x1700005F")]
		public int Height
		{
			[Token(Token = "0x6000173")]
			[Address(RVA = "0x1277C18", Offset = "0x1277C18", VA = "0x1277C18")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87DEE4", Offset = "0x87DEE4")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000174")]
			[Address(RVA = "0x1277C20", Offset = "0x1277C20", VA = "0x1277C20")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87DEF4", Offset = "0x87DEF4")]
			private set
			{
			}
		}

		[Token(Token = "0x17000060")]
		public int[] Stride
		{
			[Token(Token = "0x6000175")]
			[Address(RVA = "0x1277C28", Offset = "0x1277C28", VA = "0x1277C28")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87DF04", Offset = "0x87DF04")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000176")]
			[Address(RVA = "0x1277C30", Offset = "0x1277C30", VA = "0x1277C30")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87DF14", Offset = "0x87DF14")]
			private set
			{
			}
		}

		[Token(Token = "0x17000061")]
		public ImageFormat Format
		{
			[Token(Token = "0x6000177")]
			[Address(RVA = "0x1277C38", Offset = "0x1277C38", VA = "0x1277C38")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87DF24", Offset = "0x87DF24")]
			get
			{
				return default(ImageFormat);
			}
			[Token(Token = "0x6000178")]
			[Address(RVA = "0x1277C40", Offset = "0x1277C40", VA = "0x1277C40")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87DF34", Offset = "0x87DF34")]
			private set
			{
			}
		}

		[Token(Token = "0x17000062")]
		public Rotation Rotation
		{
			[Token(Token = "0x6000179")]
			[Address(RVA = "0x1277C48", Offset = "0x1277C48", VA = "0x1277C48")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87DF44", Offset = "0x87DF44")]
			get
			{
				return default(Rotation);
			}
			[Token(Token = "0x600017A")]
			[Address(RVA = "0x1277C50", Offset = "0x1277C50", VA = "0x1277C50")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87DF54", Offset = "0x87DF54")]
			set
			{
			}
		}

		[Token(Token = "0x17000063")]
		public Flip Flip
		{
			[Token(Token = "0x600017B")]
			[Address(RVA = "0x1277C58", Offset = "0x1277C58", VA = "0x1277C58")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87DF64", Offset = "0x87DF64")]
			get
			{
				return default(Flip);
			}
			[Token(Token = "0x600017C")]
			[Address(RVA = "0x1277C60", Offset = "0x1277C60", VA = "0x1277C60")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87DF74", Offset = "0x87DF74")]
			set
			{
			}
		}

		[Token(Token = "0x600017D")]
		[Address(RVA = "0x1277C68", Offset = "0x1277C68", VA = "0x1277C68")]
		public ImageBufferInfo(int width, int height, int[] stride, ImageFormat format)
		{
		}
	}
	[Token(Token = "0x2000044")]
	public class ImageBufferNative
	{
		[Token(Token = "0x4000158")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87D344", Offset = "0x87D344")]
		private ImageBufferInfo <Info>k__BackingField;

		[Token(Token = "0x4000159")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87D354", Offset = "0x87D354")]
		private IntPtr[] <Planes>k__BackingField;

		[Token(Token = "0x17000064")]
		public ImageBufferInfo Info
		{
			[Token(Token = "0x600017F")]
			[Address(RVA = "0x1277CEC", Offset = "0x1277CEC", VA = "0x1277CEC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87DF84", Offset = "0x87DF84")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000180")]
			[Address(RVA = "0x1277CE4", Offset = "0x1277CE4", VA = "0x1277CE4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87DF94", Offset = "0x87DF94")]
			protected set
			{
			}
		}

		[Token(Token = "0x17000065")]
		public IntPtr[] Planes
		{
			[Token(Token = "0x6000181")]
			[Address(RVA = "0x1277CF4", Offset = "0x1277CF4", VA = "0x1277CF4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87DFA4", Offset = "0x87DFA4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000182")]
			[Address(RVA = "0x1277CFC", Offset = "0x1277CFC", VA = "0x1277CFC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87DFB4", Offset = "0x87DFB4")]
			protected set
			{
			}
		}

		[Token(Token = "0x600017E")]
		[Address(RVA = "0x1277CB8", Offset = "0x1277CB8", VA = "0x1277CB8")]
		public ImageBufferNative(ImageBufferInfo info)
		{
		}

		[Token(Token = "0x6000183")]
		[Address(RVA = "0x1277D04", Offset = "0x1277D04", VA = "0x1277D04", Slot = "4")]
		public virtual void Release()
		{
		}

		[Token(Token = "0x6000184")]
		[Address(RVA = "0x1277D08", Offset = "0x1277D08", VA = "0x1277D08", Slot = "5")]
		public virtual void Dispose()
		{
		}
	}
	[Token(Token = "0x2000045")]
	public class ImageBufferNativeAlloc : ImageBufferNative, IDisposable
	{
		[Token(Token = "0x400015A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private ImageBufferNativePool<ImageBufferNativeAlloc> pool;

		[Token(Token = "0x6000185")]
		[Address(RVA = "0x1277D0C", Offset = "0x1277D0C", VA = "0x1277D0C")]
		public ImageBufferNativeAlloc(ImageBufferNativePool<ImageBufferNativeAlloc> pool, ImageBufferInfo info)
		{
		}

		[Token(Token = "0x6000186")]
		[Address(RVA = "0x1277E7C", Offset = "0x1277E7C", VA = "0x1277E7C", Slot = "4")]
		public override void Release()
		{
		}

		[Token(Token = "0x6000187")]
		[Address(RVA = "0x1277E9C", Offset = "0x1277E9C", VA = "0x1277E9C", Slot = "5")]
		public override void Dispose()
		{
		}
	}
	[Token(Token = "0x2000046")]
	public class ImageBufferNativeGCHandleSinglePlane : ImageBufferNative, IDisposable
	{
		[Token(Token = "0x400015B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private ImageBufferNativePool<ImageBufferNativeGCHandleSinglePlane> pool;

		[Token(Token = "0x400015C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private GCHandle planeHandle;

		[Token(Token = "0x6000188")]
		[Address(RVA = "0x1277F88", Offset = "0x1277F88", VA = "0x1277F88")]
		public ImageBufferNativeGCHandleSinglePlane(ImageBufferNativePool<ImageBufferNativeGCHandleSinglePlane> pool, ImageBufferInfo info)
		{
		}

		[Token(Token = "0x6000189")]
		[Address(RVA = "0x12780CC", Offset = "0x12780CC", VA = "0x12780CC")]
		public void PinPlane(byte[] plane)
		{
		}

		[Token(Token = "0x600018A")]
		[Address(RVA = "0x127813C", Offset = "0x127813C", VA = "0x127813C", Slot = "4")]
		public override void Release()
		{
		}

		[Token(Token = "0x600018B")]
		[Address(RVA = "0x1278184", Offset = "0x1278184", VA = "0x1278184", Slot = "5")]
		public override void Dispose()
		{
		}
	}
	[Token(Token = "0x2000047")]
	internal static class VoiceCodec
	{
		[Token(Token = "0x600018C")]
		[Address(RVA = "0x1CEC3B8", Offset = "0x1CEC3B8", VA = "0x1CEC3B8")]
		internal static IEncoder CreateDefaultEncoder(VoiceInfo info, LocalVoice localVoice)
		{
			return null;
		}

		[Token(Token = "0x600018D")]
		[Address(RVA = "0x1CEA4DC", Offset = "0x1CEA4DC", VA = "0x1CEA4DC")]
		internal static IDecoder CreateDefaultDecoder(int channelId, int playerId, byte voiceId, VoiceInfo info)
		{
			return null;
		}
	}
	[Token(Token = "0x2000048")]
	public class Framer<T>
	{
		[Token(Token = "0x200009D")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87D018", Offset = "0x87D018")]
		private sealed class <Frame>d__5 : IEnumerable<T[]>, IEnumerable, IEnumerator<T[]>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000347")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private int <>1__state;

			[Token(Token = "0x4000348")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private T[] <>2__current;

			[Token(Token = "0x4000349")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private int <>l__initialThreadId;

			[Token(Token = "0x400034A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Framer<T> <>4__this;

			[Token(Token = "0x400034B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private T[] buf;

			[Token(Token = "0x400034C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public T[] <>3__buf;

			[Token(Token = "0x400034D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private int <s>5__2;

			[Token(Token = "0x400034E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private int <bufPos>5__3;

			[Token(Token = "0x170000F0")]
			private T[] System.Collections.Generic.IEnumerator<T[]>.Current
			{
				[Token(Token = "0x60003B7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000F1")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60003B9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60003B4")]
			[DebuggerHidden]
			public <Frame>d__5(int <>1__state)
			{
			}

			[Token(Token = "0x60003B5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60003B6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60003B8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}

			[Token(Token = "0x60003BA")]
			[DebuggerHidden]
			private IEnumerator<T[]> System.Collections.Generic.IEnumerable<T[]>.GetEnumerator()
			{
				return null;
			}

			[Token(Token = "0x60003BB")]
			[DebuggerHidden]
			private IEnumerator System.Collections.IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Token(Token = "0x400015D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private T[] frame;

		[Token(Token = "0x400015E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int sizeofT;

		[Token(Token = "0x400015F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int framePos;

		[Token(Token = "0x600018E")]
		public Framer(int frameSize)
		{
		}

		[Token(Token = "0x600018F")]
		public int Count(int bufLen)
		{
			return default(int);
		}

		[Token(Token = "0x6000190")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x87DFC4", Offset = "0x87DFC4")]
		public IEnumerable<T[]> Frame(T[] buf)
		{
			return null;
		}
	}
	[Token(Token = "0x2000049")]
	public class LocalVoiceFramed : LocalVoice
	{
		[Token(Token = "0x4000160")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87D364", Offset = "0x87D364")]
		private int <FrameSize>k__BackingField;

		[Token(Token = "0x17000066")]
		public int FrameSize
		{
			[Token(Token = "0x6000191")]
			[Address(RVA = "0x1266D1C", Offset = "0x1266D1C", VA = "0x1266D1C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87F028", Offset = "0x87F028")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000192")]
			[Address(RVA = "0x127A868", Offset = "0x127A868", VA = "0x127A868")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87F038", Offset = "0x87F038")]
			private set
			{
			}
		}

		[Token(Token = "0x6000193")]
		[Address(RVA = "0x127A870", Offset = "0x127A870", VA = "0x127A870")]
		internal LocalVoiceFramed(VoiceClient voiceClient, IEncoder encoder, byte id, VoiceInfo voiceInfo, int channelId, int frameSize)
		{
		}
	}
	[Token(Token = "0x200004A")]
	public class LocalVoiceFramed<T> : LocalVoiceFramed
	{
		[Token(Token = "0x200009E")]
		public interface IProcessor : IDisposable
		{
			[Token(Token = "0x60003BC")]
			T[] Process(T[] buf);
		}

		[Token(Token = "0x4000161")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Framer<T> framer;

		[Token(Token = "0x4000162")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int preProcessorsCnt;

		[Token(Token = "0x4000163")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private List<IProcessor> processors;

		[Token(Token = "0x4000164")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private bool dataEncodeThreadStarted;

		[Token(Token = "0x4000165")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Queue<T[]> pushDataQueue;

		[Token(Token = "0x4000166")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private AutoResetEvent pushDataQueueReady;

		[Token(Token = "0x4000167")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private PrimitiveArrayPool<T> pushDataBufferPool;

		[Token(Token = "0x4000168")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int framesSkipped;

		[Token(Token = "0x4000169")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private bool exitThread;

		[Token(Token = "0x17000067")]
		public PrimitiveArrayPool<T> PushDataBufferPool
		{
			[Token(Token = "0x6000199")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000068")]
		public bool PushDataAsyncReady
		{
			[Token(Token = "0x600019A")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000194")]
		internal T[] processFrame(T[] buf)
		{
			return null;
		}

		[Token(Token = "0x6000195")]
		public void AddPostProcessor(params IProcessor[] processors)
		{
		}

		[Token(Token = "0x6000196")]
		public void AddPreProcessor(params IProcessor[] processors)
		{
		}

		[Token(Token = "0x6000197")]
		public void ClearProcessors()
		{
		}

		[Token(Token = "0x6000198")]
		internal LocalVoiceFramed(VoiceClient voiceClient, IEncoder encoder, byte id, VoiceInfo voiceInfo, int channelId, int frameSize)
		{
		}

		[Token(Token = "0x600019B")]
		public void PushDataAsync(T[] buf)
		{
		}

		[Token(Token = "0x600019C")]
		private void PushDataAsyncThread()
		{
		}

		[Token(Token = "0x600019D")]
		public void PushData(T[] buf)
		{
		}

		[Token(Token = "0x600019E")]
		public override void Dispose()
		{
		}
	}
	[Token(Token = "0x200004B")]
	public struct VoiceInfo
	{
		[Token(Token = "0x400016A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87D374", Offset = "0x87D374")]
		private Codec <Codec>k__BackingField;

		[Token(Token = "0x400016B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87D384", Offset = "0x87D384")]
		private int <SamplingRate>k__BackingField;

		[Token(Token = "0x400016C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87D394", Offset = "0x87D394")]
		private int <SourceSamplingRate>k__BackingField;

		[Token(Token = "0x400016D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87D3A4", Offset = "0x87D3A4")]
		private int <Channels>k__BackingField;

		[Token(Token = "0x400016E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87D3B4", Offset = "0x87D3B4")]
		private int <FrameDurationUs>k__BackingField;

		[Token(Token = "0x400016F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87D3C4", Offset = "0x87D3C4")]
		private int <Bitrate>k__BackingField;

		[Token(Token = "0x4000170")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87D3D4", Offset = "0x87D3D4")]
		private object <UserData>k__BackingField;

		[Token(Token = "0x4000171")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87D3E4", Offset = "0x87D3E4")]
		private int <Width>k__BackingField;

		[Token(Token = "0x4000172")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87D3F4", Offset = "0x87D3F4")]
		private int <Height>k__BackingField;

		[Token(Token = "0x17000069")]
		public Codec Codec
		{
			[Token(Token = "0x60001A2")]
			[Address(RVA = "0x94FB94", Offset = "0x94FB94", VA = "0x94FB94")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87F048", Offset = "0x87F048")]
			get
			{
				return default(Codec);
			}
			[Token(Token = "0x60001A3")]
			[Address(RVA = "0x94FB9C", Offset = "0x94FB9C", VA = "0x94FB9C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87F058", Offset = "0x87F058")]
			set
			{
			}
		}

		[Token(Token = "0x1700006A")]
		public int SamplingRate
		{
			[Token(Token = "0x60001A4")]
			[Address(RVA = "0x94FBA4", Offset = "0x94FBA4", VA = "0x94FBA4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87F068", Offset = "0x87F068")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60001A5")]
			[Address(RVA = "0x94FBAC", Offset = "0x94FBAC", VA = "0x94FBAC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87F078", Offset = "0x87F078")]
			set
			{
			}
		}

		[Token(Token = "0x1700006B")]
		public int SourceSamplingRate
		{
			[Token(Token = "0x60001A6")]
			[Address(RVA = "0x94FBB4", Offset = "0x94FBB4", VA = "0x94FBB4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87F088", Offset = "0x87F088")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60001A7")]
			[Address(RVA = "0x94FBBC", Offset = "0x94FBBC", VA = "0x94FBBC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87F098", Offset = "0x87F098")]
			set
			{
			}
		}

		[Token(Token = "0x1700006C")]
		public int Channels
		{
			[Token(Token = "0x60001A8")]
			[Address(RVA = "0x94FBC4", Offset = "0x94FBC4", VA = "0x94FBC4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87F0A8", Offset = "0x87F0A8")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60001A9")]
			[Address(RVA = "0x94FBCC", Offset = "0x94FBCC", VA = "0x94FBCC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87F0B8", Offset = "0x87F0B8")]
			set
			{
			}
		}

		[Token(Token = "0x1700006D")]
		public int FrameDurationUs
		{
			[Token(Token = "0x60001AA")]
			[Address(RVA = "0x94FBD4", Offset = "0x94FBD4", VA = "0x94FBD4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87F0C8", Offset = "0x87F0C8")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60001AB")]
			[Address(RVA = "0x94FBDC", Offset = "0x94FBDC", VA = "0x94FBDC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87F0D8", Offset = "0x87F0D8")]
			set
			{
			}
		}

		[Token(Token = "0x1700006E")]
		public int Bitrate
		{
			[Token(Token = "0x60001AC")]
			[Address(RVA = "0x94FBE4", Offset = "0x94FBE4", VA = "0x94FBE4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87F0E8", Offset = "0x87F0E8")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60001AD")]
			[Address(RVA = "0x94FBEC", Offset = "0x94FBEC", VA = "0x94FBEC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87F0F8", Offset = "0x87F0F8")]
			set
			{
			}
		}

		[Token(Token = "0x1700006F")]
		public object UserData
		{
			[Token(Token = "0x60001AE")]
			[Address(RVA = "0x94FBF4", Offset = "0x94FBF4", VA = "0x94FBF4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87F108", Offset = "0x87F108")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001AF")]
			[Address(RVA = "0x94FBFC", Offset = "0x94FBFC", VA = "0x94FBFC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87F118", Offset = "0x87F118")]
			set
			{
			}
		}

		[Token(Token = "0x17000070")]
		public int FrameDurationSamples
		{
			[Token(Token = "0x60001B0")]
			[Address(RVA = "0x94FC04", Offset = "0x94FC04", VA = "0x94FC04")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000071")]
		public int FrameSize
		{
			[Token(Token = "0x60001B1")]
			[Address(RVA = "0x94FC34", Offset = "0x94FC34", VA = "0x94FC34")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000072")]
		public int Width
		{
			[Token(Token = "0x60001B2")]
			[Address(RVA = "0x94FC6C", Offset = "0x94FC6C", VA = "0x94FC6C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87F128", Offset = "0x87F128")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60001B3")]
			[Address(RVA = "0x94FC74", Offset = "0x94FC74", VA = "0x94FC74")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87F138", Offset = "0x87F138")]
			set
			{
			}
		}

		[Token(Token = "0x17000073")]
		public int Height
		{
			[Token(Token = "0x60001B4")]
			[Address(RVA = "0x94FC7C", Offset = "0x94FC7C", VA = "0x94FC7C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87F148", Offset = "0x87F148")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60001B5")]
			[Address(RVA = "0x94FC84", Offset = "0x94FC84", VA = "0x94FC84")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87F158", Offset = "0x87F158")]
			set
			{
			}
		}

		[Token(Token = "0x600019F")]
		[Address(RVA = "0x1CEC4C0", Offset = "0x1CEC4C0", VA = "0x1CEC4C0")]
		public static VoiceInfo CreateAudioOpus(SamplingRate samplingRate, int sourceSamplingRate, int channels, OpusCodec.FrameDuration frameDurationUs, int bitrate, [Optional] object userdata)
		{
			return default(VoiceInfo);
		}

		[Token(Token = "0x60001A0")]
		[Address(RVA = "0x94FB8C", Offset = "0x94FB8C", VA = "0x94FB8C", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x60001A1")]
		[Address(RVA = "0x1CEA0F8", Offset = "0x1CEA0F8", VA = "0x1CEA0F8")]
		internal static VoiceInfo CreateFromEventPayload(Dictionary<byte, object> h)
		{
			return default(VoiceInfo);
		}
	}
	[Token(Token = "0x200004C")]
	public class RemoteVoiceInfo
	{
		[Token(Token = "0x4000173")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87D404", Offset = "0x87D404")]
		private VoiceInfo <Info>k__BackingField;

		[Token(Token = "0x4000174")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87D414", Offset = "0x87D414")]
		private int <ChannelId>k__BackingField;

		[Token(Token = "0x4000175")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87D424", Offset = "0x87D424")]
		private int <PlayerId>k__BackingField;

		[Token(Token = "0x4000176")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87D434", Offset = "0x87D434")]
		private byte <VoiceId>k__BackingField;

		[Token(Token = "0x4000177")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87D444", Offset = "0x87D444")]
		private object <LocalUserObject>k__BackingField;

		[Token(Token = "0x17000074")]
		public VoiceInfo Info
		{
			[Token(Token = "0x60001B7")]
			[Address(RVA = "0x127F37C", Offset = "0x127F37C", VA = "0x127F37C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87F168", Offset = "0x87F168")]
			get
			{
				return default(VoiceInfo);
			}
			[Token(Token = "0x60001B8")]
			[Address(RVA = "0x127F360", Offset = "0x127F360", VA = "0x127F360")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87F178", Offset = "0x87F178")]
			private set
			{
			}
		}

		[Token(Token = "0x17000075")]
		public int ChannelId
		{
			[Token(Token = "0x60001B9")]
			[Address(RVA = "0x127F398", Offset = "0x127F398", VA = "0x127F398")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87F188", Offset = "0x87F188")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60001BA")]
			[Address(RVA = "0x127F348", Offset = "0x127F348", VA = "0x127F348")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87F198", Offset = "0x87F198")]
			private set
			{
			}
		}

		[Token(Token = "0x17000076")]
		public int PlayerId
		{
			[Token(Token = "0x60001BB")]
			[Address(RVA = "0x127F3A0", Offset = "0x127F3A0", VA = "0x127F3A0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87F1A8", Offset = "0x87F1A8")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60001BC")]
			[Address(RVA = "0x127F350", Offset = "0x127F350", VA = "0x127F350")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87F1B8", Offset = "0x87F1B8")]
			private set
			{
			}
		}

		[Token(Token = "0x17000077")]
		public byte VoiceId
		{
			[Token(Token = "0x60001BD")]
			[Address(RVA = "0x127F3A8", Offset = "0x127F3A8", VA = "0x127F3A8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87F1C8", Offset = "0x87F1C8")]
			get
			{
				return default(byte);
			}
			[Token(Token = "0x60001BE")]
			[Address(RVA = "0x127F358", Offset = "0x127F358", VA = "0x127F358")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87F1D8", Offset = "0x87F1D8")]
			private set
			{
			}
		}

		[Token(Token = "0x17000078")]
		public object LocalUserObject
		{
			[Token(Token = "0x60001BF")]
			[Address(RVA = "0x127F3B0", Offset = "0x127F3B0", VA = "0x127F3B0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87F1E8", Offset = "0x87F1E8")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001C0")]
			[Address(RVA = "0x127F374", Offset = "0x127F374", VA = "0x127F374")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87F1F8", Offset = "0x87F1F8")]
			private set
			{
			}
		}

		[Token(Token = "0x60001B6")]
		[Address(RVA = "0x127F2E4", Offset = "0x127F2E4", VA = "0x127F2E4")]
		internal RemoteVoiceInfo(int channelId, int playerId, byte voiceId, VoiceInfo info, object localUserObject)
		{
		}
	}
	[Token(Token = "0x200004D")]
	public abstract class BufferReaderPushAdapterBase<T> : IServiceable
	{
		[Token(Token = "0x4000178")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		protected IDataReader<T> reader;

		[Token(Token = "0x60001C1")]
		public abstract void Service(LocalVoice localVoice);

		[Token(Token = "0x60001C2")]
		public BufferReaderPushAdapterBase(IDataReader<T> reader)
		{
		}

		[Token(Token = "0x60001C3")]
		public void Dispose()
		{
		}
	}
	[Token(Token = "0x200004E")]
	public class BufferReaderPushAdapter<T> : BufferReaderPushAdapterBase<T>
	{
		[Token(Token = "0x4000179")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		protected T[] buffer;

		[Token(Token = "0x60001C4")]
		public BufferReaderPushAdapter(LocalVoice localVoice, IDataReader<T> reader)
		{
		}

		[Token(Token = "0x60001C5")]
		public override void Service(LocalVoice localVoice)
		{
		}
	}
	[Token(Token = "0x200004F")]
	public class BufferReaderPushAdapterAsyncPool<T> : BufferReaderPushAdapterBase<T>
	{
		[Token(Token = "0x60001C6")]
		public BufferReaderPushAdapterAsyncPool(LocalVoice localVoice, IDataReader<T> reader)
		{
		}

		[Token(Token = "0x60001C7")]
		public override void Service(LocalVoice localVoice)
		{
		}
	}
	[Token(Token = "0x2000050")]
	public class BufferReaderPushAdapterAsyncPoolCopy<T> : BufferReaderPushAdapterBase<T>
	{
		[Token(Token = "0x400017A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		protected T[] buffer;

		[Token(Token = "0x60001C8")]
		public BufferReaderPushAdapterAsyncPoolCopy(LocalVoice localVoice, IDataReader<T> reader)
		{
		}

		[Token(Token = "0x60001C9")]
		public override void Service(LocalVoice localVoice)
		{
		}
	}
	[Token(Token = "0x2000051")]
	public class BufferReaderPushAdapterAsyncPoolFloatToShort : BufferReaderPushAdapterBase<float>
	{
		[Token(Token = "0x400017B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private float[] buffer;

		[Token(Token = "0x60001CA")]
		[Address(RVA = "0x12777B0", Offset = "0x12777B0", VA = "0x12777B0")]
		public BufferReaderPushAdapterAsyncPoolFloatToShort(LocalVoice localVoice, IDataReader<float> reader)
		{
		}

		[Token(Token = "0x60001CB")]
		[Address(RVA = "0x1277928", Offset = "0x1277928", VA = "0x1277928", Slot = "5")]
		public override void Service(LocalVoice localVoice)
		{
		}
	}
	[Token(Token = "0x2000052")]
	public class LocalVoiceVideo : LocalVoice
	{
		[Token(Token = "0x400017C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private bool imageEncodeThreadStarted;

		[Token(Token = "0x400017D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Queue<ImageBufferNative> pushImageQueue;

		[Token(Token = "0x400017E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private AutoResetEvent pushImageQueueReady;

		[Token(Token = "0x400017F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private bool exitThread;

		[Token(Token = "0x17000079")]
		public int PushImageQueueCount
		{
			[Token(Token = "0x60001CD")]
			[Address(RVA = "0x127A9E4", Offset = "0x127A9E4", VA = "0x127A9E4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x60001CC")]
		[Address(RVA = "0x127A8BC", Offset = "0x127A8BC", VA = "0x127A8BC")]
		internal LocalVoiceVideo(VoiceClient voiceClient, IEncoder encoder, byte id, VoiceInfo voiceInfo, int channelId)
		{
		}

		[Token(Token = "0x60001CE")]
		[Address(RVA = "0x127AA44", Offset = "0x127AA44", VA = "0x127AA44")]
		public void PushImageAsync(ImageBufferNative buf)
		{
		}

		[Token(Token = "0x60001CF")]
		[Address(RVA = "0x127ACEC", Offset = "0x127ACEC", VA = "0x127ACEC")]
		private void PushImageAsyncThread()
		{
		}

		[Token(Token = "0x60001D0")]
		[Address(RVA = "0x127B4B8", Offset = "0x127B4B8", VA = "0x127B4B8")]
		public void PushImage(IntPtr[] buf, int width, int height, int[] stride, ImageFormat imageFormat, Rotation rotation = Rotation.Rotate0, Flip flip = Flip.None)
		{
		}

		[Token(Token = "0x60001D1")]
		[Address(RVA = "0x127BB88", Offset = "0x127BB88", VA = "0x127BB88", Slot = "6")]
		public override void Dispose()
		{
		}
	}
	[Token(Token = "0x2000053")]
	internal class VoiceEventCode
	{
		[Token(Token = "0x4000180")]
		public const byte Code0 = 201;

		[Token(Token = "0x60001D2")]
		[Address(RVA = "0x1CEC480", Offset = "0x1CEC480", VA = "0x1CEC480")]
		public static byte GetCode(int channelID)
		{
			return default(byte);
		}

		[Token(Token = "0x60001D3")]
		[Address(RVA = "0x1CEC488", Offset = "0x1CEC488", VA = "0x1CEC488")]
		public static bool TryGetChannelID(byte evCode, int maxChannels, out byte channelID)
		{
			return default(bool);
		}

		[Token(Token = "0x60001D4")]
		[Address(RVA = "0x1CEC4B8", Offset = "0x1CEC4B8", VA = "0x1CEC4B8")]
		public VoiceEventCode()
		{
		}
	}
	[Token(Token = "0x2000054")]
	public class LoadBalancingFrontend : LoadBalancingClient, IVoiceFrontend, ILogger, IDisposable
	{
		[Serializable]
		[Token(Token = "0x200009F")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87D028", Offset = "0x87D028")]
		private sealed class <>c
		{
			[Token(Token = "0x400034F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x4000350")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Func<LocalVoice, bool> <>9__26_0;

			[Token(Token = "0x60003BE")]
			[Address(RVA = "0x127972C", Offset = "0x127972C", VA = "0x127972C")]
			public <>c()
			{
			}

			[Token(Token = "0x60003BF")]
			[Address(RVA = "0x1279734", Offset = "0x1279734", VA = "0x1279734")]
			internal bool <SendDebugEchoVoicesInfo>b__26_0(LocalVoice x)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x4000181")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		protected VoiceClient voiceClient;

		[Token(Token = "0x4000182")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87D454", Offset = "0x87D454")]
		private Action<EventData> <OnEventAction>k__BackingField;

		[Token(Token = "0x4000183")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87D464", Offset = "0x87D464")]
		private Action<ClientState> <OnStateChangeAction>k__BackingField;

		[Token(Token = "0x4000184")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		private object sendLock;

		[Token(Token = "0x1700007A")]
		public VoiceClient VoiceClient
		{
			[Token(Token = "0x60001D5")]
			[Address(RVA = "0x1278188", Offset = "0x1278188", VA = "0x1278188")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700007B")]
		public new Action<EventData> OnEventAction
		{
			[Token(Token = "0x60001DD")]
			[Address(RVA = "0x127888C", Offset = "0x127888C", VA = "0x127888C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87F208", Offset = "0x87F208")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001DE")]
			[Address(RVA = "0x1278894", Offset = "0x1278894", VA = "0x1278894")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87F218", Offset = "0x87F218")]
			set
			{
			}
		}

		[Token(Token = "0x1700007C")]
		public new Action<ClientState> OnStateChangeAction
		{
			[Token(Token = "0x60001DF")]
			[Address(RVA = "0x127889C", Offset = "0x127889C", VA = "0x127889C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87F228", Offset = "0x87F228")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001E0")]
			[Address(RVA = "0x12788A4", Offset = "0x12788A4", VA = "0x12788A4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87F238", Offset = "0x87F238")]
			set
			{
			}
		}

		[Token(Token = "0x1700007D")]
		public byte GlobalAudioGroup
		{
			[Token(Token = "0x60001E4")]
			[Address(RVA = "0x1278B38", Offset = "0x1278B38", VA = "0x1278B38")]
			get
			{
				return default(byte);
			}
			[Token(Token = "0x60001E5")]
			[Address(RVA = "0x1278B68", Offset = "0x1278B68", VA = "0x1278B68")]
			set
			{
			}
		}

		[Token(Token = "0x60001D6")]
		[Address(RVA = "0x1278190", Offset = "0x1278190", VA = "0x1278190", Slot = "27")]
		public void LogError(string fmt, params object[] args)
		{
		}

		[Token(Token = "0x60001D7")]
		[Address(RVA = "0x12781D4", Offset = "0x12781D4", VA = "0x12781D4", Slot = "28")]
		public void LogWarning(string fmt, params object[] args)
		{
		}

		[Token(Token = "0x60001D8")]
		[Address(RVA = "0x1278218", Offset = "0x1278218", VA = "0x1278218", Slot = "29")]
		public void LogInfo(string fmt, params object[] args)
		{
		}

		[Token(Token = "0x60001D9")]
		[Address(RVA = "0x127825C", Offset = "0x127825C", VA = "0x127825C", Slot = "30")]
		public void LogDebug(string fmt, params object[] args)
		{
		}

		[Token(Token = "0x60001DA")]
		[Address(RVA = "0x12782A0", Offset = "0x12782A0", VA = "0x12782A0", Slot = "19")]
		public int AssignChannel(VoiceInfo v)
		{
			return default(int);
		}

		[Token(Token = "0x60001DB")]
		[Address(RVA = "0x1278394", Offset = "0x1278394", VA = "0x1278394", Slot = "20")]
		public bool IsChannelJoined(int channelId)
		{
			return default(bool);
		}

		[Token(Token = "0x60001DC")]
		[Address(RVA = "0x12783A4", Offset = "0x12783A4", VA = "0x12783A4", Slot = "26")]
		public void SetDebugEchoMode(LocalVoice v)
		{
		}

		[Token(Token = "0x60001E1")]
		[Address(RVA = "0x12788AC", Offset = "0x12788AC", VA = "0x12788AC")]
		public LoadBalancingFrontend(ConnectionProtocol connectionProtocol = ConnectionProtocol.Udp)
		{
		}

		[Token(Token = "0x60001E2")]
		[Address(RVA = "0x1278AA0", Offset = "0x1278AA0", VA = "0x1278AA0")]
		public new void Service()
		{
		}

		[Token(Token = "0x60001E3")]
		[Address(RVA = "0x1278AE8", Offset = "0x1278AE8", VA = "0x1278AE8", Slot = "32")]
		public virtual bool ChangeAudioGroups(byte[] groupsToRemove, byte[] groupsToAdd)
		{
			return default(bool);
		}

		[Token(Token = "0x60001E6")]
		[Address(RVA = "0x12784C8", Offset = "0x12784C8", VA = "0x12784C8", Slot = "21")]
		public void SendVoicesInfo(IEnumerable<LocalVoice> voices, int channelId, int targetPlayerId)
		{
		}

		[Token(Token = "0x60001E7")]
		[Address(RVA = "0x1278CDC", Offset = "0x1278CDC", VA = "0x1278CDC")]
		public void SendDebugEchoVoicesInfo(int channelId)
		{
		}

		[Token(Token = "0x60001E8")]
		[Address(RVA = "0x127869C", Offset = "0x127869C", VA = "0x127869C", Slot = "22")]
		public void SendVoiceRemove(LocalVoice voice, int channelId, int targetPlayerId)
		{
		}

		[Token(Token = "0x60001E9")]
		[Address(RVA = "0x1278E50", Offset = "0x1278E50", VA = "0x1278E50", Slot = "23")]
		public void SendFrame(ArraySegment<byte> data, byte evNumber, byte voiceId, int channelId, LocalVoice localVoice)
		{
		}

		[Token(Token = "0x60001EA")]
		[Address(RVA = "0x12791A8", Offset = "0x12791A8", VA = "0x12791A8", Slot = "24")]
		public string ChannelIdStr(int channelId)
		{
			return null;
		}

		[Token(Token = "0x60001EB")]
		[Address(RVA = "0x12791B0", Offset = "0x12791B0", VA = "0x12791B0", Slot = "25")]
		public string PlayerIdStr(int playerId)
		{
			return null;
		}

		[Token(Token = "0x60001EC")]
		[Address(RVA = "0x12791B8", Offset = "0x12791B8", VA = "0x12791B8")]
		private void onEventActionVoiceClient(EventData ev)
		{
		}

		[Token(Token = "0x60001ED")]
		[Address(RVA = "0x12794E8", Offset = "0x12794E8", VA = "0x12794E8")]
		private void onStateChangeVoiceClient(ClientState state)
		{
		}

		[Token(Token = "0x60001EE")]
		[Address(RVA = "0x12793D4", Offset = "0x12793D4", VA = "0x12793D4")]
		private void onPlayerLeave(int playerId)
		{
		}

		[Token(Token = "0x60001EF")]
		[Address(RVA = "0x1279698", Offset = "0x1279698", VA = "0x1279698", Slot = "31")]
		public void Dispose()
		{
		}
	}
	[Token(Token = "0x2000055")]
	public class AudioInEnumerator : IDisposable
	{
		[Token(Token = "0x4000185")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public readonly bool IsSupported;

		[Token(Token = "0x1700007E")]
		public int Count
		{
			[Token(Token = "0x60001F2")]
			[Address(RVA = "0x12765B8", Offset = "0x12765B8", VA = "0x12765B8")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x60001F0")]
		[Address(RVA = "0x12765AC", Offset = "0x12765AC", VA = "0x12765AC")]
		public AudioInEnumerator()
		{
		}

		[Token(Token = "0x60001F1")]
		[Address(RVA = "0x12765B4", Offset = "0x12765B4", VA = "0x12765B4")]
		public void Refresh()
		{
		}

		[Token(Token = "0x60001F3")]
		[Address(RVA = "0x12765C0", Offset = "0x12765C0", VA = "0x12765C0")]
		public string NameAtIndex(int i)
		{
			return null;
		}

		[Token(Token = "0x60001F4")]
		[Address(RVA = "0x12765C8", Offset = "0x12765C8", VA = "0x12765C8")]
		public int IDAtIndex(int i)
		{
			return default(int);
		}

		[Token(Token = "0x60001F5")]
		[Address(RVA = "0x12765D0", Offset = "0x12765D0", VA = "0x12765D0")]
		public bool IDIsValid(int id)
		{
			return default(bool);
		}

		[Token(Token = "0x60001F6")]
		[Address(RVA = "0x12765DC", Offset = "0x12765DC", VA = "0x12765DC", Slot = "4")]
		public void Dispose()
		{
		}
	}
}
namespace ExitGames.Client.Photon.LoadBalancing
{
	[Token(Token = "0x2000056")]
	public static class Extensions
	{
		[Token(Token = "0x60001F7")]
		[Address(RVA = "0x1268684", Offset = "0x1268684", VA = "0x1268684")]
		public static void Merge(this IDictionary target, IDictionary addHash)
		{
		}

		[Token(Token = "0x60001F8")]
		[Address(RVA = "0x1268A9C", Offset = "0x1268A9C", VA = "0x1268A9C")]
		public static void MergeStringKeys(this IDictionary target, IDictionary addHash)
		{
		}

		[Token(Token = "0x60001F9")]
		[Address(RVA = "0x1268ED0", Offset = "0x1268ED0", VA = "0x1268ED0")]
		public static string ToStringFull(this IDictionary origin)
		{
			return null;
		}

		[Token(Token = "0x60001FA")]
		[Address(RVA = "0x1268F3C", Offset = "0x1268F3C", VA = "0x1268F3C")]
		public static string ToStringFull(this object[] data)
		{
			return null;
		}

		[Token(Token = "0x60001FB")]
		[Address(RVA = "0x12690A4", Offset = "0x12690A4", VA = "0x12690A4")]
		public static Hashtable StripToStringKeys(this IDictionary original)
		{
			return null;
		}

		[Token(Token = "0x60001FC")]
		[Address(RVA = "0x1269464", Offset = "0x1269464", VA = "0x1269464")]
		public static void StripKeysWithNullValues(this IDictionary original)
		{
		}

		[Token(Token = "0x60001FD")]
		[Address(RVA = "0x1269764", Offset = "0x1269764", VA = "0x1269764")]
		public static bool Contains(this int[] target, int nr)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x2000057")]
	public class FriendInfo
	{
		[Token(Token = "0x4000186")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87D474", Offset = "0x87D474")]
		private string <UserId>k__BackingField;

		[Token(Token = "0x4000187")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87D484", Offset = "0x87D484")]
		private bool <IsOnline>k__BackingField;

		[Token(Token = "0x4000188")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87D494", Offset = "0x87D494")]
		private string <Room>k__BackingField;

		[Token(Token = "0x1700007F")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x87FC28", Offset = "0x87FC28")]
		public string Name
		{
			[Token(Token = "0x60001FE")]
			[Address(RVA = "0x12697E8", Offset = "0x12697E8", VA = "0x12697E8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000080")]
		public string UserId
		{
			[Token(Token = "0x60001FF")]
			[Address(RVA = "0x12697F0", Offset = "0x12697F0", VA = "0x12697F0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87F2B8", Offset = "0x87F2B8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000200")]
			[Address(RVA = "0x12697F8", Offset = "0x12697F8", VA = "0x12697F8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87F2C8", Offset = "0x87F2C8")]
			protected internal set
			{
			}
		}

		[Token(Token = "0x17000081")]
		public bool IsOnline
		{
			[Token(Token = "0x6000201")]
			[Address(RVA = "0x1269800", Offset = "0x1269800", VA = "0x1269800")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87F2D8", Offset = "0x87F2D8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000202")]
			[Address(RVA = "0x1269808", Offset = "0x1269808", VA = "0x1269808")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87F2E8", Offset = "0x87F2E8")]
			protected internal set
			{
			}
		}

		[Token(Token = "0x17000082")]
		public string Room
		{
			[Token(Token = "0x6000203")]
			[Address(RVA = "0x1269814", Offset = "0x1269814", VA = "0x1269814")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87F2F8", Offset = "0x87F2F8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000204")]
			[Address(RVA = "0x126981C", Offset = "0x126981C", VA = "0x126981C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87F308", Offset = "0x87F308")]
			protected internal set
			{
			}
		}

		[Token(Token = "0x17000083")]
		public bool IsInRoom
		{
			[Token(Token = "0x6000205")]
			[Address(RVA = "0x1269824", Offset = "0x1269824", VA = "0x1269824")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000206")]
		[Address(RVA = "0x1269850", Offset = "0x1269850", VA = "0x1269850", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000207")]
		[Address(RVA = "0x12698F0", Offset = "0x12698F0", VA = "0x12698F0")]
		public FriendInfo()
		{
		}
	}
	[Token(Token = "0x2000058")]
	public enum ClientState
	{
		[Token(Token = "0x400018A")]
		PeerCreated = 0,
		[Token(Token = "0x400018B")]
		Authenticating = 1,
		[Token(Token = "0x400018C")]
		Authenticated = 2,
		[Token(Token = "0x400018D")]
		JoinedLobby = 3,
		[Token(Token = "0x400018E")]
		DisconnectingFromMasterserver = 4,
		[Token(Token = "0x400018F")]
		ConnectingToGameserver = 5,
		[Token(Token = "0x4000190")]
		ConnectedToGameserver = 6,
		[Token(Token = "0x4000191")]
		Joining = 7,
		[Token(Token = "0x4000192")]
		Joined = 8,
		[Token(Token = "0x4000193")]
		Leaving = 9,
		[Token(Token = "0x4000194")]
		DisconnectingFromGameserver = 10,
		[Token(Token = "0x4000195")]
		ConnectingToMasterserver = 11,
		[Token(Token = "0x4000196")]
		Disconnecting = 12,
		[Token(Token = "0x4000197")]
		Disconnected = 13,
		[Token(Token = "0x4000198")]
		ConnectedToMasterserver = 14,
		[Token(Token = "0x4000199")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x87D4A4", Offset = "0x87D4A4")]
		ConnectedToMaster = 14,
		[Token(Token = "0x400019A")]
		ConnectingToNameServer = 15,
		[Token(Token = "0x400019B")]
		ConnectedToNameServer = 16,
		[Token(Token = "0x400019C")]
		DisconnectingFromNameServer = 17
	}
	[Token(Token = "0x2000059")]
	internal enum JoinType
	{
		[Token(Token = "0x400019E")]
		CreateRoom,
		[Token(Token = "0x400019F")]
		JoinRoom,
		[Token(Token = "0x40001A0")]
		JoinRandomRoom,
		[Token(Token = "0x40001A1")]
		JoinOrCreateRoom
	}
	[Token(Token = "0x200005A")]
	public enum DisconnectCause
	{
		[Token(Token = "0x40001A3")]
		None,
		[Token(Token = "0x40001A4")]
		DisconnectByServerUserLimit,
		[Token(Token = "0x40001A5")]
		ExceptionOnConnect,
		[Token(Token = "0x40001A6")]
		DisconnectByServer,
		[Token(Token = "0x40001A7")]
		TimeoutDisconnect,
		[Token(Token = "0x40001A8")]
		Exception,
		[Token(Token = "0x40001A9")]
		InvalidAuthentication,
		[Token(Token = "0x40001AA")]
		MaxCcuReached,
		[Token(Token = "0x40001AB")]
		InvalidRegion,
		[Token(Token = "0x40001AC")]
		OperationNotAllowedInCurrentState,
		[Token(Token = "0x40001AD")]
		CustomAuthenticationFailed,
		[Token(Token = "0x40001AE")]
		DisconnectByServerLogic,
		[Token(Token = "0x40001AF")]
		AuthenticationTicketExpired
	}
	[Token(Token = "0x200005B")]
	public enum ServerConnection
	{
		[Token(Token = "0x40001B1")]
		MasterServer,
		[Token(Token = "0x40001B2")]
		GameServer,
		[Token(Token = "0x40001B3")]
		NameServer
	}
	[Token(Token = "0x200005C")]
	public enum EncryptionMode
	{
		[Token(Token = "0x40001B5")]
		PayloadEncryption = 0,
		[Token(Token = "0x40001B6")]
		DatagramEncryption = 10,
		[Token(Token = "0x40001B7")]
		DatagramEncryptionRandomSequence = 11
	}
	[Token(Token = "0x200005D")]
	public static class EncryptionDataParameters
	{
		[Token(Token = "0x40001B8")]
		public const byte Mode = 0;

		[Token(Token = "0x40001B9")]
		public const byte Secret1 = 1;

		[Token(Token = "0x40001BA")]
		public const byte Secret2 = 2;
	}
	[Token(Token = "0x200005E")]
	public class LoadBalancingClient : IPhotonPeerListener
	{
		[Token(Token = "0x40001BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public LoadBalancingPeer loadBalancingPeer;

		[Token(Token = "0x40001BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87D4DC", Offset = "0x87D4DC")]
		private string <AppVersion>k__BackingField;

		[Token(Token = "0x40001BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87D4EC", Offset = "0x87D4EC")]
		private string <AppId>k__BackingField;

		[Token(Token = "0x40001BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87D4FC", Offset = "0x87D4FC")]
		private AuthenticationValues <AuthValues>k__BackingField;

		[Token(Token = "0x40001BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public AuthModeOption AuthMode;

		[Token(Token = "0x40001C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public EncryptionMode EncryptionMode;

		[Token(Token = "0x40001C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private ConnectionProtocol ExpectedProtocol;

		[Token(Token = "0x40001C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x39")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87D50C", Offset = "0x87D50C")]
		private bool <IsUsingNameServer>k__BackingField;

		[Token(Token = "0x40001C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public string NameServerHost;

		[Token(Token = "0x40001C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public string NameServerHttp;

		[Token(Token = "0x40001C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly Dictionary<ConnectionProtocol, int> ProtocolToNameServerPort;

		[Token(Token = "0x40001C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87D51C", Offset = "0x87D51C")]
		private string <MasterServerAddress>k__BackingField;

		[Token(Token = "0x40001C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87D52C", Offset = "0x87D52C")]
		private string <GameServerAddress>k__BackingField;

		[Token(Token = "0x40001C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87D53C", Offset = "0x87D53C")]
		private ServerConnection <Server>k__BackingField;

		[Token(Token = "0x40001C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private ClientState state;

		[Token(Token = "0x40001CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87D57C", Offset = "0x87D57C")]
		private DisconnectCause <DisconnectedCause>k__BackingField;

		[Token(Token = "0x40001CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private bool inLobby;

		[Token(Token = "0x40001CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87D58C", Offset = "0x87D58C")]
		private TypedLobby <CurrentLobby>k__BackingField;

		[Token(Token = "0x40001D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private bool autoJoinLobby;

		[Token(Token = "0x40001D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x91")]
		public bool EnableLobbyStatistics;

		[Token(Token = "0x40001D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private List<TypedLobbyInfo> lobbyStatistics;

		[Token(Token = "0x40001D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87D59C", Offset = "0x87D59C")]
		private Player <LocalPlayer>k__BackingField;

		[Token(Token = "0x40001D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public Dictionary<string, RoomInfo> RoomInfoList;

		[Token(Token = "0x40001D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public Room CurrentRoom;

		[Token(Token = "0x40001D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87D5AC", Offset = "0x87D5AC")]
		private int <PlayersOnMasterCount>k__BackingField;

		[Token(Token = "0x40001D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87D5BC", Offset = "0x87D5BC")]
		private int <PlayersInRoomsCount>k__BackingField;

		[Token(Token = "0x40001D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87D5CC", Offset = "0x87D5CC")]
		private int <RoomsCount>k__BackingField;

		[Token(Token = "0x40001D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private JoinType lastJoinType;

		[Token(Token = "0x40001DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		protected internal EnterRoomParams enterRoomParamsCache;

		[Token(Token = "0x40001DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private bool didAuthenticate;

		[Token(Token = "0x40001DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87D5DC", Offset = "0x87D5DC")]
		private List<FriendInfo> <FriendList>k__BackingField;

		[Token(Token = "0x40001DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private string[] friendListRequested;

		[Token(Token = "0x40001DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private int friendListTimestamp;

		[Token(Token = "0x40001DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
		private bool isFetchingFriendList;

		[Token(Token = "0x40001E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87D5EC", Offset = "0x87D5EC")]
		private string[] <AvailableRegions>k__BackingField;

		[Token(Token = "0x40001E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87D5FC", Offset = "0x87D5FC")]
		private string[] <AvailableRegionsServers>k__BackingField;

		[Token(Token = "0x40001E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87D60C", Offset = "0x87D60C")]
		private string <CloudRegion>k__BackingField;

		[Token(Token = "0x40001E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private byte[] encryptionSecret;

		[Token(Token = "0x17000084")]
		public string AppVersion
		{
			[Token(Token = "0x6000208")]
			[Address(RVA = "0x1269900", Offset = "0x1269900", VA = "0x1269900")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87F318", Offset = "0x87F318")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000209")]
			[Address(RVA = "0x1269908", Offset = "0x1269908", VA = "0x1269908")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87F328", Offset = "0x87F328")]
			set
			{
			}
		}

		[Token(Token = "0x17000085")]
		public string AppId
		{
			[Token(Token = "0x600020A")]
			[Address(RVA = "0x1269910", Offset = "0x1269910", VA = "0x1269910")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87F338", Offset = "0x87F338")]
			get
			{
				return null;
			}
			[Token(Token = "0x600020B")]
			[Address(RVA = "0x1269918", Offset = "0x1269918", VA = "0x1269918")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87F348", Offset = "0x87F348")]
			set
			{
			}
		}

		[Token(Token = "0x17000086")]
		public AuthenticationValues AuthValues
		{
			[Token(Token = "0x600020C")]
			[Address(RVA = "0x1269920", Offset = "0x1269920", VA = "0x1269920")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87F358", Offset = "0x87F358")]
			get
			{
				return null;
			}
			[Token(Token = "0x600020D")]
			[Address(RVA = "0x1269928", Offset = "0x1269928", VA = "0x1269928")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87F368", Offset = "0x87F368")]
			set
			{
			}
		}

		[Token(Token = "0x17000087")]
		public ConnectionProtocol TransportProtocol
		{
			[Token(Token = "0x600020E")]
			[Address(RVA = "0x1269930", Offset = "0x1269930", VA = "0x1269930")]
			get
			{
				return default(ConnectionProtocol);
			}
			[Token(Token = "0x600020F")]
			[Address(RVA = "0x1269960", Offset = "0x1269960", VA = "0x1269960")]
			set
			{
			}
		}

		[Token(Token = "0x17000088")]
		public Dictionary<ConnectionProtocol, Type> SocketImplementationConfig
		{
			[Token(Token = "0x6000210")]
			[Address(RVA = "0x1269A8C", Offset = "0x1269A8C", VA = "0x1269A8C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000089")]
		private string TokenForInit
		{
			[Token(Token = "0x6000211")]
			[Address(RVA = "0x1269AB8", Offset = "0x1269AB8", VA = "0x1269AB8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700008A")]
		public bool IsUsingNameServer
		{
			[Token(Token = "0x6000212")]
			[Address(RVA = "0x1269AD8", Offset = "0x1269AD8", VA = "0x1269AD8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87F378", Offset = "0x87F378")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000213")]
			[Address(RVA = "0x1269AE0", Offset = "0x1269AE0", VA = "0x1269AE0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87F388", Offset = "0x87F388")]
			protected internal set
			{
			}
		}

		[Token(Token = "0x1700008B")]
		public string NameServerAddress
		{
			[Token(Token = "0x6000214")]
			[Address(RVA = "0x1269AEC", Offset = "0x1269AEC", VA = "0x1269AEC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700008C")]
		public string CurrentServerAddress
		{
			[Token(Token = "0x6000215")]
			[Address(RVA = "0x1269CB8", Offset = "0x1269CB8", VA = "0x1269CB8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700008D")]
		public string MasterServerAddress
		{
			[Token(Token = "0x6000216")]
			[Address(RVA = "0x1269CE8", Offset = "0x1269CE8", VA = "0x1269CE8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87F398", Offset = "0x87F398")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000217")]
			[Address(RVA = "0x1269CF0", Offset = "0x1269CF0", VA = "0x1269CF0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87F3A8", Offset = "0x87F3A8")]
			protected internal set
			{
			}
		}

		[Token(Token = "0x1700008E")]
		public string GameServerAddress
		{
			[Token(Token = "0x6000218")]
			[Address(RVA = "0x1269CF8", Offset = "0x1269CF8", VA = "0x1269CF8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87F3B8", Offset = "0x87F3B8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000219")]
			[Address(RVA = "0x1269D00", Offset = "0x1269D00", VA = "0x1269D00")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87F3C8", Offset = "0x87F3C8")]
			protected internal set
			{
			}
		}

		[Token(Token = "0x1700008F")]
		public ServerConnection Server
		{
			[Token(Token = "0x600021A")]
			[Address(RVA = "0x1269D08", Offset = "0x1269D08", VA = "0x1269D08")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87F3D8", Offset = "0x87F3D8")]
			get
			{
				return default(ServerConnection);
			}
			[Token(Token = "0x600021B")]
			[Address(RVA = "0x1269D10", Offset = "0x1269D10", VA = "0x1269D10")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87F3E8", Offset = "0x87F3E8")]
			private set
			{
			}
		}

		[Token(Token = "0x17000090")]
		public ClientState State
		{
			[Token(Token = "0x600021C")]
			[Address(RVA = "0x1269D18", Offset = "0x1269D18", VA = "0x1269D18")]
			get
			{
				return default(ClientState);
			}
			[Token(Token = "0x600021D")]
			[Address(RVA = "0x1269D20", Offset = "0x1269D20", VA = "0x1269D20")]
			protected internal set
			{
			}
		}

		[Token(Token = "0x17000091")]
		public bool IsConnected
		{
			[Token(Token = "0x600021E")]
			[Address(RVA = "0x1269D98", Offset = "0x1269D98", VA = "0x1269D98")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000092")]
		public bool IsConnectedAndReady
		{
			[Token(Token = "0x600021F")]
			[Address(RVA = "0x1269DC4", Offset = "0x1269DC4", VA = "0x1269DC4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000093")]
		public DisconnectCause DisconnectedCause
		{
			[Token(Token = "0x6000226")]
			[Address(RVA = "0x126A384", Offset = "0x126A384", VA = "0x126A384")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87F458", Offset = "0x87F458")]
			get
			{
				return default(DisconnectCause);
			}
			[Token(Token = "0x6000227")]
			[Address(RVA = "0x126A38C", Offset = "0x126A38C", VA = "0x126A38C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87F468", Offset = "0x87F468")]
			protected set
			{
			}
		}

		[Token(Token = "0x17000094")]
		public TypedLobby CurrentLobby
		{
			[Token(Token = "0x6000228")]
			[Address(RVA = "0x126A394", Offset = "0x126A394", VA = "0x126A394")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87F478", Offset = "0x87F478")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000229")]
			[Address(RVA = "0x126A39C", Offset = "0x126A39C", VA = "0x126A39C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87F488", Offset = "0x87F488")]
			protected internal set
			{
			}
		}

		[Token(Token = "0x17000095")]
		public bool AutoJoinLobby
		{
			[Token(Token = "0x600022A")]
			[Address(RVA = "0x126A3A4", Offset = "0x126A3A4", VA = "0x126A3A4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600022B")]
			[Address(RVA = "0x126A3AC", Offset = "0x126A3AC", VA = "0x126A3AC")]
			set
			{
			}
		}

		[Token(Token = "0x17000096")]
		public List<TypedLobbyInfo> LobbyStatistics
		{
			[Token(Token = "0x600022C")]
			[Address(RVA = "0x126A3B8", Offset = "0x126A3B8", VA = "0x126A3B8")]
			get
			{
				return null;
			}
			[Token(Token = "0x600022D")]
			[Address(RVA = "0x126A3C0", Offset = "0x126A3C0", VA = "0x126A3C0")]
			private set
			{
			}
		}

		[Token(Token = "0x17000097")]
		public Player LocalPlayer
		{
			[Token(Token = "0x600022E")]
			[Address(RVA = "0x126A3C8", Offset = "0x126A3C8", VA = "0x126A3C8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87F498", Offset = "0x87F498")]
			get
			{
				return null;
			}
			[Token(Token = "0x600022F")]
			[Address(RVA = "0x126A3D0", Offset = "0x126A3D0", VA = "0x126A3D0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87F4A8", Offset = "0x87F4A8")]
			internal set
			{
			}
		}

		[Token(Token = "0x17000098")]
		public string NickName
		{
			[Token(Token = "0x6000230")]
			[Address(RVA = "0x126A3D8", Offset = "0x126A3D8", VA = "0x126A3D8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000231")]
			[Address(RVA = "0x126A40C", Offset = "0x126A40C", VA = "0x126A40C")]
			set
			{
			}
		}

		[Token(Token = "0x17000099")]
		public string UserId
		{
			[Token(Token = "0x6000232")]
			[Address(RVA = "0x126A4A8", Offset = "0x126A4A8", VA = "0x126A4A8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000233")]
			[Address(RVA = "0x126A4C0", Offset = "0x126A4C0", VA = "0x126A4C0")]
			set
			{
			}
		}

		[Token(Token = "0x1700009A")]
		public int PlayersOnMasterCount
		{
			[Token(Token = "0x6000234")]
			[Address(RVA = "0x126A54C", Offset = "0x126A54C", VA = "0x126A54C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87F4B8", Offset = "0x87F4B8")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000235")]
			[Address(RVA = "0x126A554", Offset = "0x126A554", VA = "0x126A554")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87F4C8", Offset = "0x87F4C8")]
			internal set
			{
			}
		}

		[Token(Token = "0x1700009B")]
		public int PlayersInRoomsCount
		{
			[Token(Token = "0x6000236")]
			[Address(RVA = "0x126A55C", Offset = "0x126A55C", VA = "0x126A55C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87F4D8", Offset = "0x87F4D8")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000237")]
			[Address(RVA = "0x126A564", Offset = "0x126A564", VA = "0x126A564")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87F4E8", Offset = "0x87F4E8")]
			internal set
			{
			}
		}

		[Token(Token = "0x1700009C")]
		public int RoomsCount
		{
			[Token(Token = "0x6000238")]
			[Address(RVA = "0x126A56C", Offset = "0x126A56C", VA = "0x126A56C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87F4F8", Offset = "0x87F4F8")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000239")]
			[Address(RVA = "0x126A574", Offset = "0x126A574", VA = "0x126A574")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87F508", Offset = "0x87F508")]
			internal set
			{
			}
		}

		[Token(Token = "0x1700009D")]
		public List<FriendInfo> FriendList
		{
			[Token(Token = "0x600023A")]
			[Address(RVA = "0x126A57C", Offset = "0x126A57C", VA = "0x126A57C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87F518", Offset = "0x87F518")]
			get
			{
				return null;
			}
			[Token(Token = "0x600023B")]
			[Address(RVA = "0x126A584", Offset = "0x126A584", VA = "0x126A584")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87F528", Offset = "0x87F528")]
			private set
			{
			}
		}

		[Token(Token = "0x1700009E")]
		public int FriendListAge
		{
			[Token(Token = "0x600023C")]
			[Address(RVA = "0x126A58C", Offset = "0x126A58C", VA = "0x126A58C")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700009F")]
		protected bool IsAuthorizeSecretAvailable
		{
			[Token(Token = "0x600023D")]
			[Address(RVA = "0x126A5D0", Offset = "0x126A5D0", VA = "0x126A5D0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000A0")]
		public string[] AvailableRegions
		{
			[Token(Token = "0x600023E")]
			[Address(RVA = "0x126A5FC", Offset = "0x126A5FC", VA = "0x126A5FC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87F538", Offset = "0x87F538")]
			get
			{
				return null;
			}
			[Token(Token = "0x600023F")]
			[Address(RVA = "0x126A604", Offset = "0x126A604", VA = "0x126A604")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87F548", Offset = "0x87F548")]
			private set
			{
			}
		}

		[Token(Token = "0x170000A1")]
		public string[] AvailableRegionsServers
		{
			[Token(Token = "0x6000240")]
			[Address(RVA = "0x126A60C", Offset = "0x126A60C", VA = "0x126A60C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87F558", Offset = "0x87F558")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000241")]
			[Address(RVA = "0x126A614", Offset = "0x126A614", VA = "0x126A614")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87F568", Offset = "0x87F568")]
			private set
			{
			}
		}

		[Token(Token = "0x170000A2")]
		public string CloudRegion
		{
			[Token(Token = "0x6000242")]
			[Address(RVA = "0x126A61C", Offset = "0x126A61C", VA = "0x126A61C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87F578", Offset = "0x87F578")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000243")]
			[Address(RVA = "0x126A624", Offset = "0x126A624", VA = "0x126A624")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87F588", Offset = "0x87F588")]
			private set
			{
			}
		}

		[Token(Token = "0x14000002")]
		public event Action<ClientState> OnStateChangeAction
		{
			[Token(Token = "0x6000220")]
			[Address(RVA = "0x1269DFC", Offset = "0x1269DFC", VA = "0x1269DFC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87F3F8", Offset = "0x87F3F8")]
			add
			{
			}
			[Token(Token = "0x6000221")]
			[Address(RVA = "0x1269EE8", Offset = "0x1269EE8", VA = "0x1269EE8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87F408", Offset = "0x87F408")]
			remove
			{
			}
		}

		[Token(Token = "0x14000003")]
		public event Action<EventData> OnEventAction
		{
			[Token(Token = "0x6000222")]
			[Address(RVA = "0x1269FD4", Offset = "0x1269FD4", VA = "0x1269FD4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87F418", Offset = "0x87F418")]
			add
			{
			}
			[Token(Token = "0x6000223")]
			[Address(RVA = "0x126A0C0", Offset = "0x126A0C0", VA = "0x126A0C0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87F428", Offset = "0x87F428")]
			remove
			{
			}
		}

		[Token(Token = "0x14000004")]
		public event Action<OperationResponse> OnOpResponseAction
		{
			[Token(Token = "0x6000224")]
			[Address(RVA = "0x126A1AC", Offset = "0x126A1AC", VA = "0x126A1AC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87F438", Offset = "0x87F438")]
			add
			{
			}
			[Token(Token = "0x6000225")]
			[Address(RVA = "0x126A298", Offset = "0x126A298", VA = "0x126A298")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87F448", Offset = "0x87F448")]
			remove
			{
			}
		}

		[Token(Token = "0x6000244")]
		[Address(RVA = "0x126A62C", Offset = "0x126A62C", VA = "0x126A62C")]
		public LoadBalancingClient(ConnectionProtocol protocol = ConnectionProtocol.Udp)
		{
		}

		[Token(Token = "0x6000245")]
		[Address(RVA = "0x126A7E4", Offset = "0x126A7E4", VA = "0x126A7E4")]
		public LoadBalancingClient(string masterAddress, string appId, string gameVersion, ConnectionProtocol protocol = ConnectionProtocol.Udp)
		{
		}

		[Token(Token = "0x6000246")]
		[Address(RVA = "0x1269AF0", Offset = "0x1269AF0", VA = "0x1269AF0")]
		private string GetNameServerAddress()
		{
			return null;
		}

		[Token(Token = "0x6000247")]
		[Address(RVA = "0x126A824", Offset = "0x126A824", VA = "0x126A824")]
		public bool Connect(string masterServerAddress, string appId, string appVersion, string nickName, AuthenticationValues authValues)
		{
			return default(bool);
		}

		[Token(Token = "0x6000248")]
		[Address(RVA = "0x126A8D0", Offset = "0x126A8D0", VA = "0x126A8D0", Slot = "8")]
		public virtual bool Connect()
		{
			return default(bool);
		}

		[Token(Token = "0x6000249")]
		[Address(RVA = "0x126A970", Offset = "0x126A970", VA = "0x126A970")]
		public bool ConnectToNameServer()
		{
			return default(bool);
		}

		[Token(Token = "0x600024A")]
		[Address(RVA = "0x126AA8C", Offset = "0x126AA8C", VA = "0x126AA8C")]
		public bool ConnectToRegionMaster(string region)
		{
			return default(bool);
		}

		[Token(Token = "0x600024B")]
		[Address(RVA = "0x126ACB8", Offset = "0x126ACB8", VA = "0x126ACB8")]
		public void Disconnect()
		{
		}

		[Token(Token = "0x600024C")]
		[Address(RVA = "0x126ABD0", Offset = "0x126ABD0", VA = "0x126ABD0")]
		private bool CallAuthenticate()
		{
			return default(bool);
		}

		[Token(Token = "0x600024D")]
		[Address(RVA = "0x126AD14", Offset = "0x126AD14", VA = "0x126AD14")]
		public void Service()
		{
		}

		[Token(Token = "0x600024E")]
		[Address(RVA = "0x126AD2C", Offset = "0x126AD2C", VA = "0x126AD2C")]
		private void DisconnectToReconnect()
		{
		}

		[Token(Token = "0x600024F")]
		[Address(RVA = "0x126AD98", Offset = "0x126AD98", VA = "0x126AD98")]
		private bool ConnectToGameServer()
		{
			return default(bool);
		}

		[Token(Token = "0x6000250")]
		[Address(RVA = "0x126AE34", Offset = "0x126AE34", VA = "0x126AE34")]
		public bool OpGetRegions()
		{
			return default(bool);
		}

		[Token(Token = "0x6000251")]
		[Address(RVA = "0x126AEA4", Offset = "0x126AEA4", VA = "0x126AEA4")]
		public bool OpFindFriends(string[] friendsToFind)
		{
			return default(bool);
		}

		[Token(Token = "0x6000252")]
		[Address(RVA = "0x126B1C8", Offset = "0x126B1C8", VA = "0x126B1C8")]
		public bool OpJoinLobby(TypedLobby lobby)
		{
			return default(bool);
		}

		[Token(Token = "0x6000253")]
		[Address(RVA = "0x126B280", Offset = "0x126B280", VA = "0x126B280")]
		public bool OpLeaveLobby()
		{
			return default(bool);
		}

		[Token(Token = "0x6000254")]
		[Address(RVA = "0x126B2B8", Offset = "0x126B2B8", VA = "0x126B2B8")]
		public bool OpJoinRandomRoom(Hashtable expectedCustomRoomProperties, byte expectedMaxPlayers, [Optional] string[] expectedUsers)
		{
			return default(bool);
		}

		[Token(Token = "0x6000255")]
		[Address(RVA = "0x126B50C", Offset = "0x126B50C", VA = "0x126B50C")]
		public bool OpJoinRandomRoom(Hashtable expectedCustomRoomProperties, byte expectedMaxPlayers, MatchmakingMode matchmakingMode)
		{
			return default(bool);
		}

		[Token(Token = "0x6000256")]
		[Address(RVA = "0x126B358", Offset = "0x126B358", VA = "0x126B358")]
		public bool OpJoinRandomRoom(Hashtable expectedCustomRoomProperties, byte expectedMaxPlayers, MatchmakingMode matchmakingMode, TypedLobby lobby, string sqlLobbyFilter, [Optional] string[] expectedUsers)
		{
			return default(bool);
		}

		[Token(Token = "0x6000257")]
		[Address(RVA = "0x126B5B4", Offset = "0x126B5B4", VA = "0x126B5B4")]
		public bool OpJoinRoom(string roomName, [Optional] string[] expectedUsers)
		{
			return default(bool);
		}

		[Token(Token = "0x6000258")]
		[Address(RVA = "0x126B6B0", Offset = "0x126B6B0", VA = "0x126B6B0")]
		public bool OpReJoinRoom(string roomName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000259")]
		[Address(RVA = "0x126B7AC", Offset = "0x126B7AC", VA = "0x126B7AC")]
		public bool OpJoinOrCreateRoom(string roomName, RoomOptions roomOptions, TypedLobby lobby, [Optional] string[] expectedUsers)
		{
			return default(bool);
		}

		[Token(Token = "0x600025A")]
		[Address(RVA = "0x126B8F4", Offset = "0x126B8F4", VA = "0x126B8F4")]
		public bool OpCreateRoom(string roomName, RoomOptions roomOptions, TypedLobby lobby, [Optional] string[] expectedUsers)
		{
			return default(bool);
		}

		[Token(Token = "0x600025B")]
		[Address(RVA = "0x126BA28", Offset = "0x126BA28", VA = "0x126BA28")]
		public bool OpLeaveRoom()
		{
			return default(bool);
		}

		[Token(Token = "0x600025C")]
		[Address(RVA = "0x126BA34", Offset = "0x126BA34", VA = "0x126BA34")]
		public bool OpLeaveRoom(bool becomeInactive, bool sendAuthCookie = false)
		{
			return default(bool);
		}

		[Token(Token = "0x600025D")]
		[Address(RVA = "0x126BAC8", Offset = "0x126BAC8", VA = "0x126BAC8")]
		public bool OpGetGameList(TypedLobby typedLobby, string sqlLobbyFilter)
		{
			return default(bool);
		}

		[Token(Token = "0x600025E")]
		[Address(RVA = "0x126BB18", Offset = "0x126BB18", VA = "0x126BB18")]
		public bool OpSetCustomPropertiesOfActor(int actorNr, Hashtable propertiesToSet, [Optional] Hashtable expectedProperties, [Optional] WebFlags webFlags)
		{
			return default(bool);
		}

		[Token(Token = "0x600025F")]
		[Address(RVA = "0x126BEF4", Offset = "0x126BEF4", VA = "0x126BEF4")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x87F598", Offset = "0x87F598")]
		public bool OpSetCustomPropertiesOfActor(int actorNr, Hashtable propertiesToSet, Hashtable expectedProperties, bool webForward)
		{
			return default(bool);
		}

		[Token(Token = "0x6000260")]
		[Address(RVA = "0x126BD8C", Offset = "0x126BD8C", VA = "0x126BD8C")]
		protected internal bool OpSetPropertiesOfActor(int actorNr, Hashtable actorProperties, [Optional] Hashtable expectedProperties, [Optional] WebFlags webFlags)
		{
			return default(bool);
		}

		[Token(Token = "0x6000261")]
		[Address(RVA = "0x126C328", Offset = "0x126C328", VA = "0x126C328")]
		public bool OpSetCustomPropertiesOfRoom(Hashtable propertiesToSet, [Optional] Hashtable expectedProperties, [Optional] WebFlags webFlags)
		{
			return default(bool);
		}

		[Token(Token = "0x6000262")]
		[Address(RVA = "0x126C4FC", Offset = "0x126C4FC", VA = "0x126C4FC")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x87F5D0", Offset = "0x87F5D0")]
		public bool OpSetCustomPropertiesOfRoom(Hashtable propertiesToSet, Hashtable expectedProperties, bool webForward)
		{
			return default(bool);
		}

		[Token(Token = "0x6000263")]
		[Address(RVA = "0x126C3BC", Offset = "0x126C3BC", VA = "0x126C3BC")]
		protected internal bool OpSetPropertiesOfRoom(Hashtable gameProperties, [Optional] Hashtable expectedProperties, [Optional] WebFlags webFlags)
		{
			return default(bool);
		}

		[Token(Token = "0x6000264")]
		[Address(RVA = "0x126C800", Offset = "0x126C800", VA = "0x126C800", Slot = "9")]
		public virtual bool OpRaiseEvent(byte eventCode, object customEventContent, RaiseEventOptions raiseEventOptions, SendOptions sendOptions)
		{
			return default(bool);
		}

		[Token(Token = "0x6000265")]
		[Address(RVA = "0x126C81C", Offset = "0x126C81C", VA = "0x126C81C", Slot = "10")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x87F608", Offset = "0x87F608")]
		public virtual bool OpRaiseEvent(byte eventCode, object customEventContent, bool sendReliable, RaiseEventOptions raiseEventOptions)
		{
			return default(bool);
		}

		[Token(Token = "0x6000266")]
		[Address(RVA = "0x126C8B4", Offset = "0x126C8B4", VA = "0x126C8B4", Slot = "11")]
		public virtual bool OpChangeGroups(byte[] groupsToRemove, byte[] groupsToAdd)
		{
			return default(bool);
		}

		[Token(Token = "0x6000267")]
		[Address(RVA = "0x126C8D0", Offset = "0x126C8D0", VA = "0x126C8D0")]
		private void ReadoutProperties(Hashtable gameProperties, Hashtable actorProperties, int targetActorNr)
		{
		}

		[Token(Token = "0x6000268")]
		[Address(RVA = "0x126CCCC", Offset = "0x126CCCC", VA = "0x126CCCC")]
		private Hashtable ReadoutPropertiesForActorNr(Hashtable actorProperties, int actorNr)
		{
			return null;
		}

		[Token(Token = "0x6000269")]
		[Address(RVA = "0x126CE1C", Offset = "0x126CE1C", VA = "0x126CE1C")]
		protected internal void ChangeLocalID(int newID)
		{
		}

		[Token(Token = "0x600026A")]
		[Address(RVA = "0x126CFB0", Offset = "0x126CFB0", VA = "0x126CFB0")]
		private void CleanCachedValues()
		{
		}

		[Token(Token = "0x600026B")]
		[Address(RVA = "0x126D060", Offset = "0x126D060", VA = "0x126D060")]
		private void GameEnteredOnGameServer(OperationResponse operationResponse)
		{
		}

		[Token(Token = "0x600026C")]
		[Address(RVA = "0x126D3AC", Offset = "0x126D3AC", VA = "0x126D3AC")]
		private void UpdatedActorList(int[] actorsInGame)
		{
		}

		[Token(Token = "0x600026D")]
		[Address(RVA = "0x126D4C8", Offset = "0x126D4C8", VA = "0x126D4C8", Slot = "12")]
		protected internal virtual Player CreatePlayer(string actorName, int actorNumber, bool isLocal, Hashtable actorProperties)
		{
			return null;
		}

		[Token(Token = "0x600026E")]
		[Address(RVA = "0x126D60C", Offset = "0x126D60C", VA = "0x126D60C", Slot = "13")]
		protected internal virtual Room CreateRoom(string roomName, RoomOptions opt)
		{
			return null;
		}

		[Token(Token = "0x600026F")]
		[Address(RVA = "0x126D754", Offset = "0x126D754", VA = "0x126D754", Slot = "14")]
		public virtual void DebugReturn(DebugLevel level, string message)
		{
		}

		[Token(Token = "0x6000270")]
		[Address(RVA = "0x126D8A8", Offset = "0x126D8A8", VA = "0x126D8A8", Slot = "15")]
		public virtual void OnOperationResponse(OperationResponse operationResponse)
		{
		}

		[Token(Token = "0x6000271")]
		[Address(RVA = "0x126ECF0", Offset = "0x126ECF0", VA = "0x126ECF0", Slot = "16")]
		public virtual void OnStatusChanged(StatusCode statusCode)
		{
		}

		[Token(Token = "0x6000272")]
		[Address(RVA = "0x126F360", Offset = "0x126F360", VA = "0x126F360", Slot = "17")]
		public virtual void OnEvent(EventData photonEvent)
		{
		}

		[Token(Token = "0x6000273")]
		[Address(RVA = "0x126FF84", Offset = "0x126FF84", VA = "0x126FF84", Slot = "18")]
		public virtual void OnMessage(object message)
		{
		}

		[Token(Token = "0x6000274")]
		[Address(RVA = "0x126E8B4", Offset = "0x126E8B4", VA = "0x126E8B4")]
		private void SetupEncryption(Dictionary<byte, object> encryptionData)
		{
		}

		[Token(Token = "0x6000275")]
		[Address(RVA = "0x1270000", Offset = "0x1270000", VA = "0x1270000")]
		public bool OpWebRpc(string uriPath, object parameters, bool sendAuthCookie = false)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x200005F")]
	public class LoadBalancingPeer : PhotonPeer
	{
		[Token(Token = "0x20000A0")]
		private enum RoomOptionBit
		{
			[Token(Token = "0x4000352")]
			CheckUserOnJoin = 1,
			[Token(Token = "0x4000353")]
			DeleteCacheOnLeave = 2,
			[Token(Token = "0x4000354")]
			SuppressRoomEvents = 4,
			[Token(Token = "0x4000355")]
			PublishUserId = 8,
			[Token(Token = "0x4000356")]
			DeleteNullProps = 0x10,
			[Token(Token = "0x4000357")]
			BroadcastPropsChangeToAll = 0x20
		}

		[Token(Token = "0x40001E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		protected internal static Type PingImplementation;

		[Token(Token = "0x40001E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private readonly Dictionary<byte, object> opParameters;

		[Token(Token = "0x6000277")]
		[Address(RVA = "0x12702C8", Offset = "0x12702C8", VA = "0x12702C8")]
		public LoadBalancingPeer(ConnectionProtocol protocolType)
		{
		}

		[Token(Token = "0x6000278")]
		[Address(RVA = "0x126A75C", Offset = "0x126A75C", VA = "0x126A75C")]
		public LoadBalancingPeer(IPhotonPeerListener listener, ConnectionProtocol protocolType)
		{
		}

		[Token(Token = "0x6000279")]
		[Address(RVA = "0x1270370", Offset = "0x1270370", VA = "0x1270370")]
		[AttributeAttribute(Name = "ConditionalAttribute", RVA = "0x87F640", Offset = "0x87F640")]
		private void ConfigUnitySockets()
		{
		}

		[Token(Token = "0x600027A")]
		[Address(RVA = "0x1270610", Offset = "0x1270610", VA = "0x1270610", Slot = "16")]
		public virtual bool OpGetRegions(string appId)
		{
			return default(bool);
		}

		[Token(Token = "0x600027B")]
		[Address(RVA = "0x12706EC", Offset = "0x12706EC", VA = "0x12706EC", Slot = "17")]
		public virtual bool OpJoinLobby([Optional] TypedLobby lobby)
		{
			return default(bool);
		}

		[Token(Token = "0x600027C")]
		[Address(RVA = "0x12708F8", Offset = "0x12708F8", VA = "0x12708F8", Slot = "18")]
		public virtual bool OpLeaveLobby()
		{
			return default(bool);
		}

		[Token(Token = "0x600027D")]
		[Address(RVA = "0x1270A1C", Offset = "0x1270A1C", VA = "0x1270A1C")]
		private void RoomOptionsToOpParameters(Dictionary<byte, object> op, RoomOptions roomOptions)
		{
		}

		[Token(Token = "0x600027E")]
		[Address(RVA = "0x1270F9C", Offset = "0x1270F9C", VA = "0x1270F9C", Slot = "19")]
		public virtual bool OpCreateRoom(EnterRoomParams opParams)
		{
			return default(bool);
		}

		[Token(Token = "0x600027F")]
		[Address(RVA = "0x12712BC", Offset = "0x12712BC", VA = "0x12712BC", Slot = "20")]
		public virtual bool OpJoinRoom(EnterRoomParams opParams)
		{
			return default(bool);
		}

		[Token(Token = "0x6000280")]
		[Address(RVA = "0x1271654", Offset = "0x1271654", VA = "0x1271654", Slot = "21")]
		public virtual bool OpJoinRandomRoom(OpJoinRandomRoomParams opJoinRandomRoomParams)
		{
			return default(bool);
		}

		[Token(Token = "0x6000281")]
		[Address(RVA = "0x1271A14", Offset = "0x1271A14", VA = "0x1271A14", Slot = "22")]
		public virtual bool OpLeaveRoom(bool becomeInactive, bool sendAuthCookie = false)
		{
			return default(bool);
		}

		[Token(Token = "0x6000282")]
		[Address(RVA = "0x1271B64", Offset = "0x1271B64", VA = "0x1271B64", Slot = "23")]
		public virtual bool OpGetGameList(TypedLobby lobby, string queryData)
		{
			return default(bool);
		}

		[Token(Token = "0x6000283")]
		[Address(RVA = "0x1271E90", Offset = "0x1271E90", VA = "0x1271E90", Slot = "24")]
		public virtual bool OpFindFriends(string[] friendsToFind)
		{
			return default(bool);
		}

		[Token(Token = "0x6000284")]
		[Address(RVA = "0x1271F70", Offset = "0x1271F70", VA = "0x1271F70")]
		public bool OpSetCustomPropertiesOfActor(int actorNr, Hashtable actorProperties)
		{
			return default(bool);
		}

		[Token(Token = "0x6000285")]
		[Address(RVA = "0x126BFD4", Offset = "0x126BFD4", VA = "0x126BFD4")]
		protected internal bool OpSetPropertiesOfActor(int actorNr, Hashtable actorProperties, [Optional] Hashtable expectedProperties, [Optional] WebFlags webflags)
		{
			return default(bool);
		}

		[Token(Token = "0x6000286")]
		[Address(RVA = "0x1271FB8", Offset = "0x1271FB8", VA = "0x1271FB8")]
		protected void OpSetPropertyOfRoom(byte propCode, object value)
		{
		}

		[Token(Token = "0x6000287")]
		[Address(RVA = "0x127207C", Offset = "0x127207C", VA = "0x127207C")]
		public bool OpSetCustomPropertiesOfRoom(Hashtable gameProperties)
		{
			return default(bool);
		}

		[Token(Token = "0x6000288")]
		[Address(RVA = "0x126C5A8", Offset = "0x126C5A8", VA = "0x126C5A8")]
		protected internal bool OpSetPropertiesOfRoom(Hashtable gameProperties, [Optional] Hashtable expectedProperties, [Optional] WebFlags webflags)
		{
			return default(bool);
		}

		[Token(Token = "0x6000289")]
		[Address(RVA = "0x12720B0", Offset = "0x12720B0", VA = "0x12720B0", Slot = "25")]
		public virtual bool OpAuthenticate(string appId, string appVersion, AuthenticationValues authValues, string regionCode, bool getLobbyStatistics)
		{
			return default(bool);
		}

		[Token(Token = "0x600028A")]
		[Address(RVA = "0x1272474", Offset = "0x1272474", VA = "0x1272474", Slot = "26")]
		public virtual bool OpAuthenticateOnce(string appId, string appVersion, AuthenticationValues authValues, string regionCode, EncryptionMode encryptionMode, ConnectionProtocol expectedProtocol)
		{
			return default(bool);
		}

		[Token(Token = "0x600028B")]
		[Address(RVA = "0x1272860", Offset = "0x1272860", VA = "0x1272860", Slot = "27")]
		public virtual bool OpChangeGroups(byte[] groupsToRemove, byte[] groupsToAdd)
		{
			return default(bool);
		}

		[Token(Token = "0x600028C")]
		[Address(RVA = "0x1272A10", Offset = "0x1272A10", VA = "0x1272A10", Slot = "28")]
		public virtual bool OpRaiseEvent(byte eventCode, object customEventContent, RaiseEventOptions raiseEventOptions, SendOptions sendOptions)
		{
			return default(bool);
		}

		[Token(Token = "0x600028D")]
		[Address(RVA = "0x1272CB0", Offset = "0x1272CB0", VA = "0x1272CB0", Slot = "29")]
		public virtual bool OpSettings(bool receiveLobbyStats)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x2000060")]
	public class OpJoinRandomRoomParams
	{
		[Token(Token = "0x40001E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Hashtable ExpectedCustomRoomProperties;

		[Token(Token = "0x40001E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public byte ExpectedMaxPlayers;

		[Token(Token = "0x40001E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		public MatchmakingMode MatchingType;

		[Token(Token = "0x40001E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public TypedLobby TypedLobby;

		[Token(Token = "0x40001EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string SqlLobbyFilter;

		[Token(Token = "0x40001EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string[] ExpectedUsers;

		[Token(Token = "0x600028F")]
		[Address(RVA = "0x126B5AC", Offset = "0x126B5AC", VA = "0x126B5AC")]
		public OpJoinRandomRoomParams()
		{
		}
	}
	[Token(Token = "0x2000061")]
	public class EnterRoomParams
	{
		[Token(Token = "0x40001EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string RoomName;

		[Token(Token = "0x40001ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public RoomOptions RoomOptions;

		[Token(Token = "0x40001EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public TypedLobby Lobby;

		[Token(Token = "0x40001EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Hashtable PlayerProperties;

		[Token(Token = "0x40001F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool OnGameServer;

		[Token(Token = "0x40001F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
		public bool CreateIfNotExists;

		[Token(Token = "0x40001F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x32")]
		public bool RejoinOnly;

		[Token(Token = "0x40001F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public string[] ExpectedUsers;

		[Token(Token = "0x6000290")]
		[Address(RVA = "0x1268664", Offset = "0x1268664", VA = "0x1268664")]
		public EnterRoomParams()
		{
		}
	}
	[Token(Token = "0x2000062")]
	public class ErrorCode
	{
		[Token(Token = "0x40001F4")]
		public const int Ok = 0;

		[Token(Token = "0x40001F5")]
		public const int OperationNotAllowedInCurrentState = -3;

		[Token(Token = "0x40001F6")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x87D61C", Offset = "0x87D61C")]
		public const int InvalidOperationCode = -2;

		[Token(Token = "0x40001F7")]
		public const int InvalidOperation = -2;

		[Token(Token = "0x40001F8")]
		public const int InternalServerError = -1;

		[Token(Token = "0x40001F9")]
		public const int InvalidAuthentication = 32767;

		[Token(Token = "0x40001FA")]
		public const int GameIdAlreadyExists = 32766;

		[Token(Token = "0x40001FB")]
		public const int GameFull = 32765;

		[Token(Token = "0x40001FC")]
		public const int GameClosed = 32764;

		[Token(Token = "0x40001FD")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x87D654", Offset = "0x87D654")]
		public const int AlreadyMatched = 32763;

		[Token(Token = "0x40001FE")]
		public const int ServerFull = 32762;

		[Token(Token = "0x40001FF")]
		public const int UserBlocked = 32761;

		[Token(Token = "0x4000200")]
		public const int NoRandomMatchFound = 32760;

		[Token(Token = "0x4000201")]
		public const int GameDoesNotExist = 32758;

		[Token(Token = "0x4000202")]
		public const int MaxCcuReached = 32757;

		[Token(Token = "0x4000203")]
		public const int InvalidRegion = 32756;

		[Token(Token = "0x4000204")]
		public const int CustomAuthenticationFailed = 32755;

		[Token(Token = "0x4000205")]
		public const int AuthenticationTicketExpired = 32753;

		[Token(Token = "0x4000206")]
		public const int PluginReportedError = 32752;

		[Token(Token = "0x4000207")]
		public const int PluginMismatch = 32751;

		[Token(Token = "0x4000208")]
		public const int JoinFailedPeerAlreadyJoined = 32750;

		[Token(Token = "0x4000209")]
		public const int JoinFailedFoundInactiveJoiner = 32749;

		[Token(Token = "0x400020A")]
		public const int JoinFailedWithRejoinerNotFound = 32748;

		[Token(Token = "0x400020B")]
		public const int JoinFailedFoundExcludedUserId = 32747;

		[Token(Token = "0x400020C")]
		public const int JoinFailedFoundActiveJoiner = 32746;

		[Token(Token = "0x400020D")]
		public const int HttpLimitReached = 32745;

		[Token(Token = "0x400020E")]
		public const int ExternalHttpCallFailed = 32744;

		[Token(Token = "0x400020F")]
		public const int SlotError = 32742;

		[Token(Token = "0x4000210")]
		public const int InvalidEncryptionParameters = 32741;

		[Token(Token = "0x6000291")]
		[Address(RVA = "0x1268674", Offset = "0x1268674", VA = "0x1268674")]
		public ErrorCode()
		{
		}
	}
	[Token(Token = "0x2000063")]
	public class ActorProperties
	{
		[Token(Token = "0x4000211")]
		public const byte PlayerName = byte.MaxValue;

		[Token(Token = "0x4000212")]
		public const byte IsInactive = 254;

		[Token(Token = "0x4000213")]
		public const byte UserId = 253;

		[Token(Token = "0x6000292")]
		[Address(RVA = "0x12682C4", Offset = "0x12682C4", VA = "0x12682C4")]
		public ActorProperties()
		{
		}
	}
	[Token(Token = "0x2000064")]
	public class GamePropertyKey
	{
		[Token(Token = "0x4000214")]
		public const byte MaxPlayers = byte.MaxValue;

		[Token(Token = "0x4000215")]
		public const byte IsVisible = 254;

		[Token(Token = "0x4000216")]
		public const byte IsOpen = 253;

		[Token(Token = "0x4000217")]
		public const byte PlayerCount = 252;

		[Token(Token = "0x4000218")]
		public const byte Removed = 251;

		[Token(Token = "0x4000219")]
		public const byte PropsListedInLobby = 250;

		[Token(Token = "0x400021A")]
		public const byte CleanupCacheOnLeave = 249;

		[Token(Token = "0x400021B")]
		public const byte MasterClientId = 248;

		[Token(Token = "0x400021C")]
		public const byte ExpectedUsers = 247;

		[Token(Token = "0x6000293")]
		[Address(RVA = "0x12698F8", Offset = "0x12698F8", VA = "0x12698F8")]
		public GamePropertyKey()
		{
		}
	}
	[Token(Token = "0x2000065")]
	public class EventCode
	{
		[Token(Token = "0x400021D")]
		public const byte GameList = 230;

		[Token(Token = "0x400021E")]
		public const byte GameListUpdate = 229;

		[Token(Token = "0x400021F")]
		public const byte QueueState = 228;

		[Token(Token = "0x4000220")]
		public const byte Match = 227;

		[Token(Token = "0x4000221")]
		public const byte AppStats = 226;

		[Token(Token = "0x4000222")]
		public const byte LobbyStats = 224;

		[Token(Token = "0x4000223")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x87D68C", Offset = "0x87D68C")]
		public const byte AzureNodeInfo = 210;

		[Token(Token = "0x4000224")]
		public const byte Join = byte.MaxValue;

		[Token(Token = "0x4000225")]
		public const byte Leave = 254;

		[Token(Token = "0x4000226")]
		public const byte PropertiesChanged = 253;

		[Token(Token = "0x4000227")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x87D6C4", Offset = "0x87D6C4")]
		public const byte SetProperties = 253;

		[Token(Token = "0x4000228")]
		public const byte ErrorInfo = 251;

		[Token(Token = "0x4000229")]
		public const byte CacheSliceChanged = 250;

		[Token(Token = "0x400022A")]
		public const byte AuthEvent = 223;

		[Token(Token = "0x6000294")]
		[Address(RVA = "0x126867C", Offset = "0x126867C", VA = "0x126867C")]
		public EventCode()
		{
		}
	}
	[Token(Token = "0x2000066")]
	public class ParameterCode
	{
		[Token(Token = "0x400022B")]
		public const byte SuppressRoomEvents = 237;

		[Token(Token = "0x400022C")]
		public const byte EmptyRoomTTL = 236;

		[Token(Token = "0x400022D")]
		public const byte PlayerTTL = 235;

		[Token(Token = "0x400022E")]
		public const byte EventForward = 234;

		[Token(Token = "0x400022F")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x87D6FC", Offset = "0x87D6FC")]
		public const byte IsComingBack = 233;

		[Token(Token = "0x4000230")]
		public const byte IsInactive = 233;

		[Token(Token = "0x4000231")]
		public const byte CheckUserOnJoin = 232;

		[Token(Token = "0x4000232")]
		public const byte ExpectedValues = 231;

		[Token(Token = "0x4000233")]
		public const byte Address = 230;

		[Token(Token = "0x4000234")]
		public const byte PeerCount = 229;

		[Token(Token = "0x4000235")]
		public const byte GameCount = 228;

		[Token(Token = "0x4000236")]
		public const byte MasterPeerCount = 227;

		[Token(Token = "0x4000237")]
		public const byte UserId = 225;

		[Token(Token = "0x4000238")]
		public const byte ApplicationId = 224;

		[Token(Token = "0x4000239")]
		public const byte Position = 223;

		[Token(Token = "0x400023A")]
		public const byte MatchMakingType = 223;

		[Token(Token = "0x400023B")]
		public const byte GameList = 222;

		[Token(Token = "0x400023C")]
		public const byte Secret = 221;

		[Token(Token = "0x400023D")]
		public const byte AppVersion = 220;

		[Token(Token = "0x400023E")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x87D734", Offset = "0x87D734")]
		public const byte AzureNodeInfo = 210;

		[Token(Token = "0x400023F")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x87D76C", Offset = "0x87D76C")]
		public const byte AzureLocalNodeId = 209;

		[Token(Token = "0x4000240")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x87D7A4", Offset = "0x87D7A4")]
		public const byte AzureMasterNodeId = 208;

		[Token(Token = "0x4000241")]
		public const byte RoomName = byte.MaxValue;

		[Token(Token = "0x4000242")]
		public const byte Broadcast = 250;

		[Token(Token = "0x4000243")]
		public const byte ActorList = 252;

		[Token(Token = "0x4000244")]
		public const byte ActorNr = 254;

		[Token(Token = "0x4000245")]
		public const byte PlayerProperties = 249;

		[Token(Token = "0x4000246")]
		public const byte CustomEventContent = 245;

		[Token(Token = "0x4000247")]
		public const byte Data = 245;

		[Token(Token = "0x4000248")]
		public const byte Code = 244;

		[Token(Token = "0x4000249")]
		public const byte GameProperties = 248;

		[Token(Token = "0x400024A")]
		public const byte Properties = 251;

		[Token(Token = "0x400024B")]
		public const byte TargetActorNr = 253;

		[Token(Token = "0x400024C")]
		public const byte ReceiverGroup = 246;

		[Token(Token = "0x400024D")]
		public const byte Cache = 247;

		[Token(Token = "0x400024E")]
		public const byte CleanupCacheOnLeave = 241;

		[Token(Token = "0x400024F")]
		public const byte Group = 240;

		[Token(Token = "0x4000250")]
		public const byte Remove = 239;

		[Token(Token = "0x4000251")]
		public const byte PublishUserId = 239;

		[Token(Token = "0x4000252")]
		public const byte Add = 238;

		[Token(Token = "0x4000253")]
		public const byte Info = 218;

		[Token(Token = "0x4000254")]
		public const byte ClientAuthenticationType = 217;

		[Token(Token = "0x4000255")]
		public const byte ClientAuthenticationParams = 216;

		[Token(Token = "0x4000256")]
		public const byte JoinMode = 215;

		[Token(Token = "0x4000257")]
		public const byte ClientAuthenticationData = 214;

		[Token(Token = "0x4000258")]
		public const byte MasterClientId = 203;

		[Token(Token = "0x4000259")]
		public const byte FindFriendsRequestList = 1;

		[Token(Token = "0x400025A")]
		public const byte FindFriendsResponseOnlineList = 1;

		[Token(Token = "0x400025B")]
		public const byte FindFriendsResponseRoomIdList = 2;

		[Token(Token = "0x400025C")]
		public const byte LobbyName = 213;

		[Token(Token = "0x400025D")]
		public const byte LobbyType = 212;

		[Token(Token = "0x400025E")]
		public const byte LobbyStats = 211;

		[Token(Token = "0x400025F")]
		public const byte Region = 210;

		[Token(Token = "0x4000260")]
		public const byte UriPath = 209;

		[Token(Token = "0x4000261")]
		public const byte WebRpcParameters = 208;

		[Token(Token = "0x4000262")]
		public const byte WebRpcReturnCode = 207;

		[Token(Token = "0x4000263")]
		public const byte WebRpcReturnMessage = 206;

		[Token(Token = "0x4000264")]
		public const byte CacheSliceIndex = 205;

		[Token(Token = "0x4000265")]
		public const byte Plugins = 204;

		[Token(Token = "0x4000266")]
		public const byte NickName = 202;

		[Token(Token = "0x4000267")]
		public const byte PluginName = 201;

		[Token(Token = "0x4000268")]
		public const byte PluginVersion = 200;

		[Token(Token = "0x4000269")]
		public const byte ExpectedProtocol = 195;

		[Token(Token = "0x400026A")]
		public const byte CustomInitData = 194;

		[Token(Token = "0x400026B")]
		public const byte EncryptionMode = 193;

		[Token(Token = "0x400026C")]
		public const byte EncryptionData = 192;

		[Token(Token = "0x400026D")]
		public const byte RoomOptionFlags = 191;

		[Token(Token = "0x6000295")]
		[Address(RVA = "0x1272E94", Offset = "0x1272E94", VA = "0x1272E94")]
		public ParameterCode()
		{
		}
	}
	[Token(Token = "0x2000067")]
	public class OperationCode
	{
		[Token(Token = "0x400026E")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x87D7DC", Offset = "0x87D7DC")]
		public const byte ExchangeKeysForEncryption = 250;

		[Token(Token = "0x400026F")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x87D814", Offset = "0x87D814")]
		public const byte Join = byte.MaxValue;

		[Token(Token = "0x4000270")]
		public const byte AuthenticateOnce = 231;

		[Token(Token = "0x4000271")]
		public const byte Authenticate = 230;

		[Token(Token = "0x4000272")]
		public const byte JoinLobby = 229;

		[Token(Token = "0x4000273")]
		public const byte LeaveLobby = 228;

		[Token(Token = "0x4000274")]
		public const byte CreateGame = 227;

		[Token(Token = "0x4000275")]
		public const byte JoinGame = 226;

		[Token(Token = "0x4000276")]
		public const byte JoinRandomGame = 225;

		[Token(Token = "0x4000277")]
		public const byte Leave = 254;

		[Token(Token = "0x4000278")]
		public const byte RaiseEvent = 253;

		[Token(Token = "0x4000279")]
		public const byte SetProperties = 252;

		[Token(Token = "0x400027A")]
		public const byte GetProperties = 251;

		[Token(Token = "0x400027B")]
		public const byte ChangeGroups = 248;

		[Token(Token = "0x400027C")]
		public const byte FindFriends = 222;

		[Token(Token = "0x400027D")]
		public const byte GetLobbyStats = 221;

		[Token(Token = "0x400027E")]
		public const byte GetRegions = 220;

		[Token(Token = "0x400027F")]
		public const byte WebRpc = 219;

		[Token(Token = "0x4000280")]
		public const byte ServerSettings = 218;

		[Token(Token = "0x4000281")]
		public const byte GetGameList = 217;

		[Token(Token = "0x6000296")]
		[Address(RVA = "0x1272E8C", Offset = "0x1272E8C", VA = "0x1272E8C")]
		public OperationCode()
		{
		}
	}
	[Token(Token = "0x2000068")]
	public enum JoinMode : byte
	{
		[Token(Token = "0x4000283")]
		Default,
		[Token(Token = "0x4000284")]
		CreateIfNotExists,
		[Token(Token = "0x4000285")]
		JoinOrRejoin,
		[Token(Token = "0x4000286")]
		RejoinOnly
	}
	[Token(Token = "0x2000069")]
	public enum MatchmakingMode : byte
	{
		[Token(Token = "0x4000288")]
		FillRoom,
		[Token(Token = "0x4000289")]
		SerialMatching,
		[Token(Token = "0x400028A")]
		RandomMatching
	}
	[Token(Token = "0x200006A")]
	public enum ReceiverGroup : byte
	{
		[Token(Token = "0x400028C")]
		Others,
		[Token(Token = "0x400028D")]
		All,
		[Token(Token = "0x400028E")]
		MasterClient
	}
	[Token(Token = "0x200006B")]
	public enum EventCaching : byte
	{
		[Token(Token = "0x4000290")]
		DoNotCache = 0,
		[Token(Token = "0x4000291")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x87D824", Offset = "0x87D824")]
		MergeCache = 1,
		[Token(Token = "0x4000292")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x87D834", Offset = "0x87D834")]
		ReplaceCache = 2,
		[Token(Token = "0x4000293")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x87D844", Offset = "0x87D844")]
		RemoveCache = 3,
		[Token(Token = "0x4000294")]
		AddToRoomCache = 4,
		[Token(Token = "0x4000295")]
		AddToRoomCacheGlobal = 5,
		[Token(Token = "0x4000296")]
		RemoveFromRoomCache = 6,
		[Token(Token = "0x4000297")]
		RemoveFromRoomCacheForActorsLeft = 7,
		[Token(Token = "0x4000298")]
		SliceIncreaseIndex = 10,
		[Token(Token = "0x4000299")]
		SliceSetIndex = 11,
		[Token(Token = "0x400029A")]
		SlicePurgeIndex = 12,
		[Token(Token = "0x400029B")]
		SlicePurgeUpToIndex = 13
	}
	[Token(Token = "0x200006C")]
	[Flags]
	public enum PropertyTypeFlag : byte
	{
		[Token(Token = "0x400029D")]
		None = 0,
		[Token(Token = "0x400029E")]
		Game = 1,
		[Token(Token = "0x400029F")]
		Actor = 2,
		[Token(Token = "0x40002A0")]
		GameAndActor = 3
	}
	[Token(Token = "0x200006D")]
	public class RoomOptions
	{
		[Token(Token = "0x40002A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private bool isVisible;

		[Token(Token = "0x40002A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11")]
		private bool isOpen;

		[Token(Token = "0x40002A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x12")]
		public byte MaxPlayers;

		[Token(Token = "0x40002A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public int PlayerTtl;

		[Token(Token = "0x40002A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int EmptyRoomTtl;

		[Token(Token = "0x40002A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private bool cleanupCacheOnLeave;

		[Token(Token = "0x40002A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Hashtable CustomRoomProperties;

		[Token(Token = "0x40002A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string[] CustomRoomPropertiesForLobby;

		[Token(Token = "0x40002A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string[] Plugins;

		[Token(Token = "0x40002AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87D854", Offset = "0x87D854")]
		private bool <SuppressRoomEvents>k__BackingField;

		[Token(Token = "0x40002AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x39")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87D864", Offset = "0x87D864")]
		private bool <PublishUserId>k__BackingField;

		[Token(Token = "0x40002AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3A")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87D874", Offset = "0x87D874")]
		private bool <DeleteNullProperties>k__BackingField;

		[Token(Token = "0x170000A3")]
		public bool IsVisible
		{
			[Token(Token = "0x6000297")]
			[Address(RVA = "0x1270F74", Offset = "0x1270F74", VA = "0x1270F74")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000298")]
			[Address(RVA = "0x1275CC8", Offset = "0x1275CC8", VA = "0x1275CC8")]
			set
			{
			}
		}

		[Token(Token = "0x170000A4")]
		public bool IsOpen
		{
			[Token(Token = "0x6000299")]
			[Address(RVA = "0x1270F6C", Offset = "0x1270F6C", VA = "0x1270F6C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600029A")]
			[Address(RVA = "0x1275CD4", Offset = "0x1275CD4", VA = "0x1275CD4")]
			set
			{
			}
		}

		[Token(Token = "0x170000A5")]
		public bool CleanupCacheOnLeave
		{
			[Token(Token = "0x600029B")]
			[Address(RVA = "0x1270F7C", Offset = "0x1270F7C", VA = "0x1270F7C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600029C")]
			[Address(RVA = "0x1275CE0", Offset = "0x1275CE0", VA = "0x1275CE0")]
			set
			{
			}
		}

		[Token(Token = "0x170000A6")]
		public bool SuppressRoomEvents
		{
			[Token(Token = "0x600029D")]
			[Address(RVA = "0x1270F84", Offset = "0x1270F84", VA = "0x1270F84")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87F678", Offset = "0x87F678")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600029E")]
			[Address(RVA = "0x1275CEC", Offset = "0x1275CEC", VA = "0x1275CEC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87F688", Offset = "0x87F688")]
			set
			{
			}
		}

		[Token(Token = "0x170000A7")]
		public bool PublishUserId
		{
			[Token(Token = "0x600029F")]
			[Address(RVA = "0x1270F8C", Offset = "0x1270F8C", VA = "0x1270F8C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87F698", Offset = "0x87F698")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60002A0")]
			[Address(RVA = "0x1275CF8", Offset = "0x1275CF8", VA = "0x1275CF8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87F6A8", Offset = "0x87F6A8")]
			set
			{
			}
		}

		[Token(Token = "0x170000A8")]
		public bool DeleteNullProperties
		{
			[Token(Token = "0x60002A1")]
			[Address(RVA = "0x1270F94", Offset = "0x1270F94", VA = "0x1270F94")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87F6B8", Offset = "0x87F6B8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60002A2")]
			[Address(RVA = "0x1275D04", Offset = "0x1275D04", VA = "0x1275D04")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87F6C8", Offset = "0x87F6C8")]
			set
			{
			}
		}

		[Token(Token = "0x60002A3")]
		[Address(RVA = "0x1270EFC", Offset = "0x1270EFC", VA = "0x1270EFC")]
		public RoomOptions()
		{
		}
	}
	[Token(Token = "0x200006E")]
	public class RaiseEventOptions
	{
		[Token(Token = "0x40002AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly RaiseEventOptions Default;

		[Token(Token = "0x40002AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public EventCaching CachingOption;

		[Token(Token = "0x40002AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11")]
		public byte InterestGroup;

		[Token(Token = "0x40002B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int[] TargetActors;

		[Token(Token = "0x40002B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ReceiverGroup Receivers;

		[Token(Token = "0x40002B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x87D884", Offset = "0x87D884")]
		public byte SequenceChannel;

		[Token(Token = "0x40002B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public WebFlags Flags;

		[Token(Token = "0x60002A4")]
		[Address(RVA = "0x1273FA0", Offset = "0x1273FA0", VA = "0x1273FA0")]
		public RaiseEventOptions()
		{
		}
	}
	[Token(Token = "0x200006F")]
	public enum LobbyType : byte
	{
		[Token(Token = "0x40002B5")]
		Default = 0,
		[Token(Token = "0x40002B6")]
		SqlLobby = 2,
		[Token(Token = "0x40002B7")]
		AsyncRandomLobby = 3
	}
	[Token(Token = "0x2000070")]
	public class TypedLobby
	{
		[Token(Token = "0x40002B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string Name;

		[Token(Token = "0x40002B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public LobbyType Type;

		[Token(Token = "0x40002BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly TypedLobby Default;

		[Token(Token = "0x170000A9")]
		public bool IsDefault
		{
			[Token(Token = "0x60002A6")]
			[Address(RVA = "0x12708DC", Offset = "0x12708DC", VA = "0x12708DC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60002A7")]
		[Address(RVA = "0x1275D10", Offset = "0x1275D10", VA = "0x1275D10")]
		public TypedLobby()
		{
		}

		[Token(Token = "0x60002A8")]
		[Address(RVA = "0x1275D78", Offset = "0x1275D78", VA = "0x1275D78")]
		public TypedLobby(string name, LobbyType type)
		{
		}

		[Token(Token = "0x60002A9")]
		[Address(RVA = "0x1275DB4", Offset = "0x1275DB4", VA = "0x1275DB4", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Token(Token = "0x2000071")]
	public class TypedLobbyInfo : TypedLobby
	{
		[Token(Token = "0x40002BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public int PlayerCount;

		[Token(Token = "0x40002BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public int RoomCount;

		[Token(Token = "0x60002AB")]
		[Address(RVA = "0x1275E9C", Offset = "0x1275E9C", VA = "0x1275E9C", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x60002AC")]
		[Address(RVA = "0x126FF20", Offset = "0x126FF20", VA = "0x126FF20")]
		public TypedLobbyInfo()
		{
		}
	}
	[Token(Token = "0x2000072")]
	public enum AuthModeOption
	{
		[Token(Token = "0x40002BE")]
		Auth,
		[Token(Token = "0x40002BF")]
		AuthOnce,
		[Token(Token = "0x40002C0")]
		AuthOnceWss
	}
	[Token(Token = "0x2000073")]
	public enum CustomAuthenticationType : byte
	{
		[Token(Token = "0x40002C2")]
		Custom = 0,
		[Token(Token = "0x40002C3")]
		Steam = 1,
		[Token(Token = "0x40002C4")]
		Facebook = 2,
		[Token(Token = "0x40002C5")]
		Oculus = 3,
		[Token(Token = "0x40002C6")]
		PlayStation = 4,
		[Token(Token = "0x40002C7")]
		Xbox = 5,
		[Token(Token = "0x40002C8")]
		None = byte.MaxValue
	}
	[Token(Token = "0x2000074")]
	public class AuthenticationValues
	{
		[Token(Token = "0x40002C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private CustomAuthenticationType authType;

		[Token(Token = "0x40002CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87D8BC", Offset = "0x87D8BC")]
		private string <AuthGetParameters>k__BackingField;

		[Token(Token = "0x40002CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87D8CC", Offset = "0x87D8CC")]
		private object <AuthPostData>k__BackingField;

		[Token(Token = "0x40002CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87D8DC", Offset = "0x87D8DC")]
		private string <Token>k__BackingField;

		[Token(Token = "0x40002CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87D8EC", Offset = "0x87D8EC")]
		private string <UserId>k__BackingField;

		[Token(Token = "0x170000AA")]
		public CustomAuthenticationType AuthType
		{
			[Token(Token = "0x60002AD")]
			[Address(RVA = "0x12682CC", Offset = "0x12682CC", VA = "0x12682CC")]
			get
			{
				return default(CustomAuthenticationType);
			}
			[Token(Token = "0x60002AE")]
			[Address(RVA = "0x12682D4", Offset = "0x12682D4", VA = "0x12682D4")]
			set
			{
			}
		}

		[Token(Token = "0x170000AB")]
		public string AuthGetParameters
		{
			[Token(Token = "0x60002AF")]
			[Address(RVA = "0x12682DC", Offset = "0x12682DC", VA = "0x12682DC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87F6D8", Offset = "0x87F6D8")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002B0")]
			[Address(RVA = "0x12682E4", Offset = "0x12682E4", VA = "0x12682E4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87F6E8", Offset = "0x87F6E8")]
			set
			{
			}
		}

		[Token(Token = "0x170000AC")]
		public object AuthPostData
		{
			[Token(Token = "0x60002B1")]
			[Address(RVA = "0x12682EC", Offset = "0x12682EC", VA = "0x12682EC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87F6F8", Offset = "0x87F6F8")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002B2")]
			[Address(RVA = "0x12682F4", Offset = "0x12682F4", VA = "0x12682F4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87F708", Offset = "0x87F708")]
			private set
			{
			}
		}

		[Token(Token = "0x170000AD")]
		public string Token
		{
			[Token(Token = "0x60002B3")]
			[Address(RVA = "0x12682FC", Offset = "0x12682FC", VA = "0x12682FC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87F718", Offset = "0x87F718")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002B4")]
			[Address(RVA = "0x1268304", Offset = "0x1268304", VA = "0x1268304")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87F728", Offset = "0x87F728")]
			set
			{
			}
		}

		[Token(Token = "0x170000AE")]
		public string UserId
		{
			[Token(Token = "0x60002B5")]
			[Address(RVA = "0x126830C", Offset = "0x126830C", VA = "0x126830C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87F738", Offset = "0x87F738")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002B6")]
			[Address(RVA = "0x1268314", Offset = "0x1268314", VA = "0x1268314")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87F748", Offset = "0x87F748")]
			set
			{
			}
		}

		[Token(Token = "0x60002B7")]
		[Address(RVA = "0x126831C", Offset = "0x126831C", VA = "0x126831C")]
		public AuthenticationValues()
		{
		}

		[Token(Token = "0x60002B8")]
		[Address(RVA = "0x126832C", Offset = "0x126832C", VA = "0x126832C")]
		public AuthenticationValues(string userId)
		{
		}

		[Token(Token = "0x60002B9")]
		[Address(RVA = "0x1268360", Offset = "0x1268360", VA = "0x1268360", Slot = "4")]
		public virtual void SetAuthPostData(string stringData)
		{
		}

		[Token(Token = "0x60002BA")]
		[Address(RVA = "0x12683A4", Offset = "0x12683A4", VA = "0x12683A4", Slot = "5")]
		public virtual void SetAuthPostData(byte[] byteData)
		{
		}

		[Token(Token = "0x60002BB")]
		[Address(RVA = "0x12683AC", Offset = "0x12683AC", VA = "0x12683AC", Slot = "6")]
		public virtual void AddAuthParameter(string key, string value)
		{
		}

		[Token(Token = "0x60002BC")]
		[Address(RVA = "0x12685D0", Offset = "0x12685D0", VA = "0x12685D0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Token(Token = "0x2000075")]
	public abstract class PhotonPing : IDisposable
	{
		[Token(Token = "0x40002CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string DebugString;

		[Token(Token = "0x40002CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool Successful;

		[Token(Token = "0x40002D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		protected internal bool GotResult;

		[Token(Token = "0x40002D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		protected internal int PingLength;

		[Token(Token = "0x40002D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		protected internal byte[] PingBytes;

		[Token(Token = "0x40002D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		protected internal byte PingId;

		[Token(Token = "0x60002BD")]
		[Address(RVA = "0x1272E9C", Offset = "0x1272E9C", VA = "0x1272E9C", Slot = "5")]
		public virtual bool StartPing(string ip)
		{
			return default(bool);
		}

		[Token(Token = "0x60002BE")]
		[Address(RVA = "0x1272F04", Offset = "0x1272F04", VA = "0x1272F04", Slot = "6")]
		public virtual bool Done()
		{
			return default(bool);
		}

		[Token(Token = "0x60002BF")]
		[Address(RVA = "0x1272F6C", Offset = "0x1272F6C", VA = "0x1272F6C", Slot = "7")]
		public virtual void Dispose()
		{
		}

		[Token(Token = "0x60002C0")]
		[Address(RVA = "0x1272FD4", Offset = "0x1272FD4", VA = "0x1272FD4")]
		protected internal void Init()
		{
		}

		[Token(Token = "0x60002C1")]
		[Address(RVA = "0x1273028", Offset = "0x1273028", VA = "0x1273028")]
		protected PhotonPing()
		{
		}
	}
	[Token(Token = "0x2000076")]
	public class PingMono : PhotonPing
	{
		[Token(Token = "0x40002D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Socket sock;

		[Token(Token = "0x60002C2")]
		[Address(RVA = "0x12730B8", Offset = "0x12730B8", VA = "0x12730B8", Slot = "5")]
		public override bool StartPing(string ip)
		{
			return default(bool);
		}

		[Token(Token = "0x60002C3")]
		[Address(RVA = "0x1273390", Offset = "0x1273390", VA = "0x1273390", Slot = "6")]
		public override bool Done()
		{
			return default(bool);
		}

		[Token(Token = "0x60002C4")]
		[Address(RVA = "0x127352C", Offset = "0x127352C", VA = "0x127352C", Slot = "7")]
		public override void Dispose()
		{
		}

		[Token(Token = "0x60002C5")]
		[Address(RVA = "0x12735FC", Offset = "0x12735FC", VA = "0x12735FC")]
		public PingMono()
		{
		}
	}
	[Token(Token = "0x2000077")]
	public class Player
	{
		[Token(Token = "0x40002D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87D8FC", Offset = "0x87D8FC")]
		private Room <RoomReference>k__BackingField;

		[Token(Token = "0x40002D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private int actorID;

		[Token(Token = "0x40002D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public readonly bool IsLocal;

		[Token(Token = "0x40002D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private string nickName;

		[Token(Token = "0x40002D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87D90C", Offset = "0x87D90C")]
		private string <UserId>k__BackingField;

		[Token(Token = "0x40002DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87D91C", Offset = "0x87D91C")]
		private bool <IsInactive>k__BackingField;

		[Token(Token = "0x40002DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87D92C", Offset = "0x87D92C")]
		private Hashtable <CustomProperties>k__BackingField;

		[Token(Token = "0x40002DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public object TagObject;

		[Token(Token = "0x170000AF")]
		protected internal Room RoomReference
		{
			[Token(Token = "0x60002C6")]
			[Address(RVA = "0x1273600", Offset = "0x1273600", VA = "0x1273600")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87F758", Offset = "0x87F758")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002C7")]
			[Address(RVA = "0x126CFA8", Offset = "0x126CFA8", VA = "0x126CFA8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87F768", Offset = "0x87F768")]
			set
			{
			}
		}

		[Token(Token = "0x170000B0")]
		public int ID
		{
			[Token(Token = "0x60002C8")]
			[Address(RVA = "0x126BC80", Offset = "0x126BC80", VA = "0x126BC80")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170000B1")]
		public string NickName
		{
			[Token(Token = "0x60002C9")]
			[Address(RVA = "0x126A404", Offset = "0x126A404", VA = "0x126A404")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002CA")]
			[Address(RVA = "0x126A41C", Offset = "0x126A41C", VA = "0x126A41C")]
			set
			{
			}
		}

		[Token(Token = "0x170000B2")]
		public string UserId
		{
			[Token(Token = "0x60002CB")]
			[Address(RVA = "0x127371C", Offset = "0x127371C", VA = "0x127371C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87F778", Offset = "0x87F778")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002CC")]
			[Address(RVA = "0x1273724", Offset = "0x1273724", VA = "0x1273724")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87F788", Offset = "0x87F788")]
			internal set
			{
			}
		}

		[Token(Token = "0x170000B3")]
		public bool IsMasterClient
		{
			[Token(Token = "0x60002CD")]
			[Address(RVA = "0x127372C", Offset = "0x127372C", VA = "0x127372C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000B4")]
		public bool IsInactive
		{
			[Token(Token = "0x60002CE")]
			[Address(RVA = "0x1273758", Offset = "0x1273758", VA = "0x1273758")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87F798", Offset = "0x87F798")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60002CF")]
			[Address(RVA = "0x126FF14", Offset = "0x126FF14", VA = "0x126FF14")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87F7A8", Offset = "0x87F7A8")]
			set
			{
			}
		}

		[Token(Token = "0x170000B5")]
		public Hashtable CustomProperties
		{
			[Token(Token = "0x60002D0")]
			[Address(RVA = "0x1273760", Offset = "0x1273760", VA = "0x1273760")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87F7B8", Offset = "0x87F7B8")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002D1")]
			[Address(RVA = "0x1273768", Offset = "0x1273768", VA = "0x1273768")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87F7C8", Offset = "0x87F7C8")]
			private set
			{
			}
		}

		[Token(Token = "0x170000B6")]
		public Hashtable AllProperties
		{
			[Token(Token = "0x60002D2")]
			[Address(RVA = "0x126EB94", Offset = "0x126EB94", VA = "0x126EB94")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60002D3")]
		[Address(RVA = "0x1273770", Offset = "0x1273770", VA = "0x1273770")]
		protected internal Player(string nickName, int actorID, bool isLocal)
		{
		}

		[Token(Token = "0x60002D4")]
		[Address(RVA = "0x126D550", Offset = "0x126D550", VA = "0x126D550")]
		protected internal Player(string nickName, int actorID, bool isLocal, Hashtable playerProperties)
		{
		}

		[Token(Token = "0x60002D5")]
		[Address(RVA = "0x127377C", Offset = "0x127377C", VA = "0x127377C")]
		public Player Get(int id)
		{
			return null;
		}

		[Token(Token = "0x60002D6")]
		[Address(RVA = "0x1273794", Offset = "0x1273794", VA = "0x1273794")]
		public Player GetNext()
		{
			return null;
		}

		[Token(Token = "0x60002D7")]
		[Address(RVA = "0x1273970", Offset = "0x1273970", VA = "0x1273970")]
		public Player GetNextFor(Player currentPlayer)
		{
			return null;
		}

		[Token(Token = "0x60002D8")]
		[Address(RVA = "0x127379C", Offset = "0x127379C", VA = "0x127379C")]
		public Player GetNextFor(int currentPlayerId)
		{
			return null;
		}

		[Token(Token = "0x60002D9")]
		[Address(RVA = "0x1273984", Offset = "0x1273984", VA = "0x1273984", Slot = "4")]
		public virtual void InternalCacheProperties(Hashtable properties)
		{
		}

		[Token(Token = "0x60002DA")]
		[Address(RVA = "0x1273C38", Offset = "0x1273C38", VA = "0x1273C38", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x60002DB")]
		[Address(RVA = "0x1273CC4", Offset = "0x1273CC4", VA = "0x1273CC4")]
		public string ToStringFull()
		{
			return null;
		}

		[Token(Token = "0x60002DC")]
		[Address(RVA = "0x1273EC8", Offset = "0x1273EC8", VA = "0x1273EC8", Slot = "0")]
		public override bool Equals(object p)
		{
			return default(bool);
		}

		[Token(Token = "0x60002DD")]
		[Address(RVA = "0x1273F90", Offset = "0x1273F90", VA = "0x1273F90", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x60002DE")]
		[Address(RVA = "0x126CF98", Offset = "0x126CF98", VA = "0x126CF98")]
		protected internal void ChangeLocalID(int newID)
		{
		}

		[Token(Token = "0x60002DF")]
		[Address(RVA = "0x126BC88", Offset = "0x126BC88", VA = "0x126BC88")]
		public void SetCustomProperties(Hashtable propertiesToSet, [Optional] Hashtable expectedValues, [Optional] WebFlags webFlags)
		{
		}

		[Token(Token = "0x60002E0")]
		[Address(RVA = "0x1273610", Offset = "0x1273610", VA = "0x1273610")]
		private void SetPlayerNameProperty()
		{
		}
	}
	[Token(Token = "0x2000078")]
	public class Room : RoomInfo
	{
		[Token(Token = "0x40002DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		protected internal int PlayerTTL;

		[Token(Token = "0x40002DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		protected internal int RoomTTL;

		[Token(Token = "0x40002DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87D93C", Offset = "0x87D93C")]
		private LoadBalancingClient <LoadBalancingClient>k__BackingField;

		[Token(Token = "0x40002E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Dictionary<int, Player> players;

		[Token(Token = "0x170000B7")]
		protected internal LoadBalancingClient LoadBalancingClient
		{
			[Token(Token = "0x60002E1")]
			[Address(RVA = "0x1273F98", Offset = "0x1273F98", VA = "0x1273F98")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87F7D8", Offset = "0x87F7D8")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002E2")]
			[Address(RVA = "0x126D398", Offset = "0x126D398", VA = "0x126D398")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87F7E8", Offset = "0x87F7E8")]
			set
			{
			}
		}

		[Token(Token = "0x170000B8")]
		public new string Name
		{
			[Token(Token = "0x60002E3")]
			[Address(RVA = "0x1274078", Offset = "0x1274078", VA = "0x1274078")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002E4")]
			[Address(RVA = "0x1274080", Offset = "0x1274080", VA = "0x1274080")]
			internal set
			{
			}
		}

		[Token(Token = "0x170000B9")]
		public new bool IsOpen
		{
			[Token(Token = "0x60002E5")]
			[Address(RVA = "0x1274088", Offset = "0x1274088", VA = "0x1274088")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60002E6")]
			[Address(RVA = "0x1274090", Offset = "0x1274090", VA = "0x1274090")]
			set
			{
			}
		}

		[Token(Token = "0x170000BA")]
		public new bool IsVisible
		{
			[Token(Token = "0x60002E7")]
			[Address(RVA = "0x12741E8", Offset = "0x12741E8", VA = "0x12741E8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60002E8")]
			[Address(RVA = "0x12741F0", Offset = "0x12741F0", VA = "0x12741F0")]
			set
			{
			}
		}

		[Token(Token = "0x170000BB")]
		public new byte MaxPlayers
		{
			[Token(Token = "0x60002E9")]
			[Address(RVA = "0x1274348", Offset = "0x1274348", VA = "0x1274348")]
			get
			{
				return default(byte);
			}
			[Token(Token = "0x60002EA")]
			[Address(RVA = "0x1274350", Offset = "0x1274350", VA = "0x1274350")]
			set
			{
			}
		}

		[Token(Token = "0x170000BC")]
		public new byte PlayerCount
		{
			[Token(Token = "0x60002EB")]
			[Address(RVA = "0x1274494", Offset = "0x1274494", VA = "0x1274494")]
			get
			{
				return default(byte);
			}
		}

		[Token(Token = "0x170000BD")]
		public Dictionary<int, Player> Players
		{
			[Token(Token = "0x60002EC")]
			[Address(RVA = "0x126CF90", Offset = "0x126CF90", VA = "0x126CF90")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002ED")]
			[Address(RVA = "0x12744EC", Offset = "0x12744EC", VA = "0x12744EC")]
			private set
			{
			}
		}

		[Token(Token = "0x170000BE")]
		public string[] ExpectedUsers
		{
			[Token(Token = "0x60002EE")]
			[Address(RVA = "0x12744F4", Offset = "0x12744F4", VA = "0x12744F4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000BF")]
		public int MasterClientId
		{
			[Token(Token = "0x60002EF")]
			[Address(RVA = "0x1273750", Offset = "0x1273750", VA = "0x1273750")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170000C0")]
		public string[] PropertiesListedInLobby
		{
			[Token(Token = "0x60002F0")]
			[Address(RVA = "0x12744FC", Offset = "0x12744FC", VA = "0x12744FC")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002F1")]
			[Address(RVA = "0x1274504", Offset = "0x1274504", VA = "0x1274504")]
			private set
			{
			}
		}

		[Token(Token = "0x170000C1")]
		public bool AutoCleanUp
		{
			[Token(Token = "0x60002F2")]
			[Address(RVA = "0x127450C", Offset = "0x127450C", VA = "0x127450C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60002F3")]
		[Address(RVA = "0x126D67C", Offset = "0x126D67C", VA = "0x126D67C")]
		protected internal Room(string roomName, RoomOptions options)
		{
		}

		[Token(Token = "0x60002F4")]
		[Address(RVA = "0x1274514", Offset = "0x1274514", VA = "0x1274514", Slot = "5")]
		public virtual void SetCustomProperties(Hashtable propertiesToSet, [Optional] Hashtable expectedProperties, [Optional] WebFlags webFlags)
		{
		}

		[Token(Token = "0x60002F5")]
		[Address(RVA = "0x1274600", Offset = "0x1274600", VA = "0x1274600")]
		public void SetPropertiesListedInLobby(string[] propertiesListedInLobby)
		{
		}

		[Token(Token = "0x60002F6")]
		[Address(RVA = "0x12746DC", Offset = "0x12746DC", VA = "0x12746DC", Slot = "6")]
		protected internal virtual void RemovePlayer(Player player)
		{
		}

		[Token(Token = "0x60002F7")]
		[Address(RVA = "0x1274764", Offset = "0x1274764", VA = "0x1274764", Slot = "7")]
		protected internal virtual void RemovePlayer(int id)
		{
		}

		[Token(Token = "0x60002F8")]
		[Address(RVA = "0x127479C", Offset = "0x127479C", VA = "0x127479C")]
		public bool SetMasterClient(Player masterClientPlayer)
		{
			return default(bool);
		}

		[Token(Token = "0x60002F9")]
		[Address(RVA = "0x1274960", Offset = "0x1274960", VA = "0x1274960", Slot = "8")]
		public virtual bool AddPlayer(Player player)
		{
			return default(bool);
		}

		[Token(Token = "0x60002FA")]
		[Address(RVA = "0x1274A08", Offset = "0x1274A08", VA = "0x1274A08", Slot = "9")]
		public virtual Player StorePlayer(Player player)
		{
			return null;
		}

		[Token(Token = "0x60002FB")]
		[Address(RVA = "0x1274AB0", Offset = "0x1274AB0", VA = "0x1274AB0", Slot = "10")]
		public virtual Player GetPlayer(int id)
		{
			return null;
		}

		[Token(Token = "0x60002FC")]
		[Address(RVA = "0x1274B30", Offset = "0x1274B30", VA = "0x1274B30")]
		public void ClearExpectedUsers()
		{
		}

		[Token(Token = "0x60002FD")]
		[Address(RVA = "0x1274C70", Offset = "0x1274C70", VA = "0x1274C70", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x60002FE")]
		[Address(RVA = "0x1274EF4", Offset = "0x1274EF4", VA = "0x1274EF4")]
		public new string ToStringFull()
		{
			return null;
		}
	}
	[Token(Token = "0x2000079")]
	public class RoomInfo
	{
		[Token(Token = "0x40002E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		protected internal bool removedFromList;

		[Token(Token = "0x40002E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Hashtable customProperties;

		[Token(Token = "0x40002E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		protected byte maxPlayers;

		[Token(Token = "0x40002E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		protected string[] expectedUsers;

		[Token(Token = "0x40002E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		protected bool isOpen;

		[Token(Token = "0x40002E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
		protected bool isVisible;

		[Token(Token = "0x40002E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x32")]
		protected bool autoCleanUp;

		[Token(Token = "0x40002E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		protected string name;

		[Token(Token = "0x40002E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		protected internal int masterClientId;

		[Token(Token = "0x40002EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		protected string[] propertiesListedInLobby;

		[Token(Token = "0x40002EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87D94C", Offset = "0x87D94C")]
		private int <PlayerCount>k__BackingField;

		[Token(Token = "0x40002EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87D95C", Offset = "0x87D95C")]
		private bool <IsLocalClientInside>k__BackingField;

		[Token(Token = "0x170000C2")]
		public Hashtable CustomProperties
		{
			[Token(Token = "0x60002FF")]
			[Address(RVA = "0x12745F8", Offset = "0x12745F8", VA = "0x12745F8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000C3")]
		public string Name
		{
			[Token(Token = "0x6000300")]
			[Address(RVA = "0x12751CC", Offset = "0x12751CC", VA = "0x12751CC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000C4")]
		public int PlayerCount
		{
			[Token(Token = "0x6000301")]
			[Address(RVA = "0x12751D4", Offset = "0x12751D4", VA = "0x12751D4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87F7F8", Offset = "0x87F7F8")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000302")]
			[Address(RVA = "0x12751DC", Offset = "0x12751DC", VA = "0x12751DC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87F808", Offset = "0x87F808")]
			private set
			{
			}
		}

		[Token(Token = "0x170000C5")]
		public bool IsLocalClientInside
		{
			[Token(Token = "0x6000303")]
			[Address(RVA = "0x1273608", Offset = "0x1273608", VA = "0x1273608")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87F818", Offset = "0x87F818")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000304")]
			[Address(RVA = "0x126D3A0", Offset = "0x126D3A0", VA = "0x126D3A0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87F828", Offset = "0x87F828")]
			set
			{
			}
		}

		[Token(Token = "0x170000C6")]
		public byte MaxPlayers
		{
			[Token(Token = "0x6000305")]
			[Address(RVA = "0x12751E4", Offset = "0x12751E4", VA = "0x12751E4")]
			get
			{
				return default(byte);
			}
		}

		[Token(Token = "0x170000C7")]
		public bool IsOpen
		{
			[Token(Token = "0x6000306")]
			[Address(RVA = "0x12751EC", Offset = "0x12751EC", VA = "0x12751EC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000C8")]
		public bool IsVisible
		{
			[Token(Token = "0x6000307")]
			[Address(RVA = "0x12751F4", Offset = "0x12751F4", VA = "0x12751F4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000308")]
		[Address(RVA = "0x126EC4C", Offset = "0x126EC4C", VA = "0x126EC4C")]
		protected internal RoomInfo(string roomName, Hashtable roomProperties)
		{
		}

		[Token(Token = "0x6000309")]
		[Address(RVA = "0x12751FC", Offset = "0x12751FC", VA = "0x12751FC", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Token(Token = "0x600030A")]
		[Address(RVA = "0x12752C4", Offset = "0x12752C4", VA = "0x12752C4", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x600030B")]
		[Address(RVA = "0x12752F8", Offset = "0x12752F8", VA = "0x12752F8", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x600030C")]
		[Address(RVA = "0x127557C", Offset = "0x127557C", VA = "0x127557C")]
		public string ToStringFull()
		{
			return null;
		}

		[Token(Token = "0x600030D")]
		[Address(RVA = "0x1275854", Offset = "0x1275854", VA = "0x1275854", Slot = "4")]
		protected internal virtual void InternalCacheProperties(Hashtable propertiesToCache)
		{
		}
	}
	[Token(Token = "0x200007A")]
	public class WebRpcResponse
	{
		[Token(Token = "0x40002ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87D96C", Offset = "0x87D96C")]
		private string <Name>k__BackingField;

		[Token(Token = "0x40002EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87D97C", Offset = "0x87D97C")]
		private int <ReturnCode>k__BackingField;

		[Token(Token = "0x40002EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87D98C", Offset = "0x87D98C")]
		private string <DebugMessage>k__BackingField;

		[Token(Token = "0x40002F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87D99C", Offset = "0x87D99C")]
		private Dictionary<string, object> <Parameters>k__BackingField;

		[Token(Token = "0x170000C9")]
		public string Name
		{
			[Token(Token = "0x600030E")]
			[Address(RVA = "0x12761AC", Offset = "0x12761AC", VA = "0x12761AC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87F838", Offset = "0x87F838")]
			get
			{
				return null;
			}
			[Token(Token = "0x600030F")]
			[Address(RVA = "0x12761B4", Offset = "0x12761B4", VA = "0x12761B4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87F848", Offset = "0x87F848")]
			private set
			{
			}
		}

		[Token(Token = "0x170000CA")]
		public int ReturnCode
		{
			[Token(Token = "0x6000310")]
			[Address(RVA = "0x12761BC", Offset = "0x12761BC", VA = "0x12761BC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87F858", Offset = "0x87F858")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000311")]
			[Address(RVA = "0x12761C4", Offset = "0x12761C4", VA = "0x12761C4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87F868", Offset = "0x87F868")]
			private set
			{
			}
		}

		[Token(Token = "0x170000CB")]
		public string DebugMessage
		{
			[Token(Token = "0x6000312")]
			[Address(RVA = "0x12761CC", Offset = "0x12761CC", VA = "0x12761CC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87F878", Offset = "0x87F878")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000313")]
			[Address(RVA = "0x12761D4", Offset = "0x12761D4", VA = "0x12761D4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87F888", Offset = "0x87F888")]
			private set
			{
			}
		}

		[Token(Token = "0x170000CC")]
		public Dictionary<string, object> Parameters
		{
			[Token(Token = "0x6000314")]
			[Address(RVA = "0x12761DC", Offset = "0x12761DC", VA = "0x12761DC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87F898", Offset = "0x87F898")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000315")]
			[Address(RVA = "0x12761E4", Offset = "0x12761E4", VA = "0x12761E4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87F8A8", Offset = "0x87F8A8")]
			private set
			{
			}
		}

		[Token(Token = "0x6000316")]
		[Address(RVA = "0x12761EC", Offset = "0x12761EC", VA = "0x12761EC")]
		public WebRpcResponse(OperationResponse response)
		{
		}

		[Token(Token = "0x6000317")]
		[Address(RVA = "0x12763AC", Offset = "0x12763AC", VA = "0x12763AC")]
		public string ToStringFull()
		{
			return null;
		}
	}
	[Token(Token = "0x200007B")]
	public class WebFlags
	{
		[Token(Token = "0x40002F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly WebFlags Default;

		[Token(Token = "0x40002F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public byte WebhookFlags;

		[Token(Token = "0x40002F3")]
		public const byte HttpForwardConst = 1;

		[Token(Token = "0x40002F4")]
		public const byte SendAuthCookieConst = 2;

		[Token(Token = "0x40002F5")]
		public const byte SendSyncConst = 4;

		[Token(Token = "0x40002F6")]
		public const byte SendStateConst = 8;

		[Token(Token = "0x170000CD")]
		public bool HttpForward
		{
			[Token(Token = "0x6000318")]
			[Address(RVA = "0x1271FAC", Offset = "0x1271FAC", VA = "0x1271FAC")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000319")]
			[Address(RVA = "0x12760A4", Offset = "0x12760A4", VA = "0x12760A4")]
			set
			{
			}
		}

		[Token(Token = "0x170000CE")]
		public bool SendAuthCookie
		{
			[Token(Token = "0x600031A")]
			[Address(RVA = "0x12760C0", Offset = "0x12760C0", VA = "0x12760C0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600031B")]
			[Address(RVA = "0x12760CC", Offset = "0x12760CC", VA = "0x12760CC")]
			set
			{
			}
		}

		[Token(Token = "0x170000CF")]
		public bool SendSync
		{
			[Token(Token = "0x600031C")]
			[Address(RVA = "0x12760EC", Offset = "0x12760EC", VA = "0x12760EC")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600031D")]
			[Address(RVA = "0x12760F8", Offset = "0x12760F8", VA = "0x12760F8")]
			set
			{
			}
		}

		[Token(Token = "0x170000D0")]
		public bool SendState
		{
			[Token(Token = "0x600031E")]
			[Address(RVA = "0x1276118", Offset = "0x1276118", VA = "0x1276118")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600031F")]
			[Address(RVA = "0x1276124", Offset = "0x1276124", VA = "0x1276124")]
			set
			{
			}
		}

		[Token(Token = "0x6000320")]
		[Address(RVA = "0x126BFA8", Offset = "0x126BFA8", VA = "0x126BFA8")]
		public WebFlags(byte webhookFlags)
		{
		}
	}
}
