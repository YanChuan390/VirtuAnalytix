using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Sockets;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading;
using DarkTonic.MasterAudio;
using ExitGames.Client.Photon.LoadBalancing;
using ExitGames.Client.Photon.Voice;
using Il2CppDummyDll;
using POpusCodec;
using POpusCodec.Enums;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.EventSystems;
using UnityEngine.UI;

[assembly: AssemblyVersion("0.0.0.0")]
[Token(Token = "0x2000002")]
public static class AudioLoaderOptimizer
{
	[Token(Token = "0x4000001")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static readonly Dictionary<string, List<GameObject>> PlayingGameObjectsByClipName;

	[Token(Token = "0x6000001")]
	[Address(RVA = "0xA01564", Offset = "0xA01564", VA = "0xA01564")]
	public static void AddNonPreloadedPlayingClip(AudioClip clip, GameObject maHolderGameObject)
	{
	}

	[Token(Token = "0x6000002")]
	[Address(RVA = "0xA01758", Offset = "0xA01758", VA = "0xA01758")]
	public static void RemoveNonPreloadedPlayingClip(AudioClip clip, GameObject maHolderGameObject)
	{
	}

	[Token(Token = "0x6000003")]
	[Address(RVA = "0xA018E4", Offset = "0xA018E4", VA = "0xA018E4")]
	public static bool IsAnyOfNonPreloadedClipPlaying(AudioClip clip)
	{
		return default(bool);
	}
}
[Token(Token = "0x2000003")]
[AttributeAttribute(Name = "AudioScriptOrder", RVA = "0x981338", Offset = "0x981338")]
public class ListenerFollower : MonoBehaviour
{
	[Token(Token = "0x4000002")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private Transform _transToFollow;

	[Token(Token = "0x4000003")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private GameObject _goToFollow;

	[Token(Token = "0x4000004")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private Transform _trans;

	[Token(Token = "0x4000005")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private GameObject _go;

	[Token(Token = "0x4000006")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private SphereCollider _collider;

	[Token(Token = "0x17000001")]
	public SphereCollider Trigger
	{
		[Token(Token = "0x6000009")]
		[Address(RVA = "0x1721DC8", Offset = "0x1721DC8", VA = "0x1721DC8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000002")]
	public GameObject GameObj
	{
		[Token(Token = "0x600000A")]
		[Address(RVA = "0x1722184", Offset = "0x1722184", VA = "0x1722184")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000003")]
	public Transform Trans
	{
		[Token(Token = "0x600000B")]
		[Address(RVA = "0x17220F4", Offset = "0x17220F4", VA = "0x17220F4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000005")]
	[Address(RVA = "0x1721D4C", Offset = "0x1721D4C", VA = "0x1721D4C")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000006")]
	[Address(RVA = "0x1721E78", Offset = "0x1721E78", VA = "0x1721E78")]
	public void StartFollowing(Transform transToFollow, string soundType, float trigRadius)
	{
	}

	[Token(Token = "0x6000007")]
	[Address(RVA = "0x1721ED0", Offset = "0x1721ED0", VA = "0x1721ED0")]
	public void ManualUpdate()
	{
	}

	[Token(Token = "0x6000008")]
	[Address(RVA = "0x1721F98", Offset = "0x1721F98", VA = "0x1721F98")]
	private void BatchOcclusionRaycasts()
	{
	}

	[Token(Token = "0x600000C")]
	[Address(RVA = "0x1722214", Offset = "0x1722214", VA = "0x1722214")]
	public ListenerFollower()
	{
	}
}
[Token(Token = "0x2000004")]
public static class ResonanceAudioHelper
{
	[Token(Token = "0x17000004")]
	public static bool ResonanceAudioOptionExists
	{
		[Token(Token = "0x600000D")]
		[Address(RVA = "0x17248F0", Offset = "0x17248F0", VA = "0x17248F0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x600000E")]
	[Address(RVA = "0x17248F8", Offset = "0x17248F8", VA = "0x17248F8")]
	public static bool AddResonanceAudioSourceToAllVariations()
	{
		return default(bool);
	}

	[Token(Token = "0x600000F")]
	[Address(RVA = "0x1724900", Offset = "0x1724900", VA = "0x1724900")]
	public static bool RemoveResonanceAudioSourceFromAllVariations()
	{
		return default(bool);
	}

	[Token(Token = "0x6000010")]
	[Address(RVA = "0x1724908", Offset = "0x1724908", VA = "0x1724908")]
	public static void CopyResonanceAudioSource(DynamicGroupVariation sourceVariation, DynamicGroupVariation destVariation)
	{
	}

	[Token(Token = "0x6000011")]
	[Address(RVA = "0x172490C", Offset = "0x172490C", VA = "0x172490C")]
	public static void CopyResonanceAudioSource(DynamicGroupVariation sourceVariation, SoundGroupVariation destVariation)
	{
	}

	[Token(Token = "0x6000012")]
	[Address(RVA = "0x1724910", Offset = "0x1724910", VA = "0x1724910")]
	public static void CopyResonanceAudioSource(SoundGroupVariation sourceVariation, DynamicGroupVariation destVariation)
	{
	}
}
[Token(Token = "0x2000005")]
public class TransformFollower : MonoBehaviour
{
	[Token(Token = "0x4000007")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9818E4", Offset = "0x9818E4")]
	public Transform RuntimeFollowingTransform;

	[Token(Token = "0x4000008")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private GameObject _goToFollow;

	[Token(Token = "0x4000009")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private Transform _trans;

	[Token(Token = "0x400000A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private GameObject _go;

	[Token(Token = "0x400000B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private SphereCollider _collider;

	[Token(Token = "0x400000C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private string _soundType;

	[Token(Token = "0x400000D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private string _variationName;

	[Token(Token = "0x400000E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private bool _willFollowSource;

	[Token(Token = "0x400000F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x51")]
	private bool _isInsideTrigger;

	[Token(Token = "0x4000010")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x52")]
	private bool _hasPlayedSound;

	[Token(Token = "0x4000011")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x53")]
	private bool _groupLoadFailed;

	[Token(Token = "0x4000012")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private MasterAudioGroup _groupToPlay;

	[Token(Token = "0x4000013")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private bool _positionAtClosestColliderPoint;

	[Token(Token = "0x4000014")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	private MasterAudio.AmbientSoundExitMode _exitMode;

	[Token(Token = "0x4000015")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private float _exitFadeTime;

	[Token(Token = "0x4000016")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private readonly List<Collider> _actorColliders;

	[Token(Token = "0x4000017")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private readonly List<Collider2D> _actorColliders2D;

	[Token(Token = "0x4000018")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private Vector3 _lastListenerPos;

	[Token(Token = "0x4000019")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private readonly Dictionary<Collider, Vector3> _lastPositionByCollider;

	[Token(Token = "0x400001A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private readonly Dictionary<Collider2D, Vector3> _lastPositionByCollider2D;

	[Token(Token = "0x400001B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private PlaySoundResult playingVariation;

	[Token(Token = "0x17000005")]
	public SphereCollider Trigger
	{
		[Token(Token = "0x600001D")]
		[Address(RVA = "0x1724A34", Offset = "0x1724A34", VA = "0x1724A34")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000006")]
	public GameObject GameObj
	{
		[Token(Token = "0x600001E")]
		[Address(RVA = "0x172513C", Offset = "0x172513C", VA = "0x172513C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000007")]
	public Transform Trans
	{
		[Token(Token = "0x600001F")]
		[Address(RVA = "0x1725AE0", Offset = "0x1725AE0", VA = "0x1725AE0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000013")]
	[Address(RVA = "0x1724914", Offset = "0x1724914", VA = "0x1724914")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000014")]
	[Address(RVA = "0x1724AE4", Offset = "0x1724AE4", VA = "0x1724AE4")]
	private void Start()
	{
	}

	[Token(Token = "0x6000015")]
	[Address(RVA = "0x1724B5C", Offset = "0x1724B5C", VA = "0x1724B5C")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6000016")]
	[Address(RVA = "0x1724BC4", Offset = "0x1724BC4", VA = "0x1724BC4")]
	public void StartFollowing(Transform transToFollow, string soundType, string variationName, float trigRadius, bool willFollowSource, bool positionAtClosestColliderPoint, bool useTopCollider, bool useChildColliders, MasterAudio.AmbientSoundExitMode exitMode, float exitFadeTime)
	{
	}

	[Token(Token = "0x6000017")]
	[Address(RVA = "0x17250C0", Offset = "0x17250C0", VA = "0x17250C0")]
	private void StopFollowing()
	{
	}

	[Token(Token = "0x6000018")]
	[Address(RVA = "0x17251CC", Offset = "0x17251CC", VA = "0x17251CC")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x6000019")]
	[Address(RVA = "0x17254CC", Offset = "0x17254CC", VA = "0x17254CC")]
	private void PlaySound()
	{
	}

	[Token(Token = "0x600001A")]
	[Address(RVA = "0x1725814", Offset = "0x1725814", VA = "0x1725814")]
	public void ManualUpdate()
	{
	}

	[Token(Token = "0x600001B")]
	[Address(RVA = "0x1725B70", Offset = "0x1725B70", VA = "0x1725B70")]
	public bool RecalcClosestColliderPosition()
	{
		return default(bool);
	}

	[Token(Token = "0x600001C")]
	[Address(RVA = "0x17262F8", Offset = "0x17262F8", VA = "0x17262F8")]
	private void OnTriggerExit(Collider other)
	{
	}

	[Token(Token = "0x6000020")]
	[Address(RVA = "0x1726470", Offset = "0x1726470", VA = "0x1726470")]
	public TransformFollower()
	{
	}
}
[Token(Token = "0x2000006")]
public class AndroidAudioInAEC : IAudioPusher<short>, IAudioSource, IDisposable
{
	[Token(Token = "0x20000C6")]
	private class DataCallback : AndroidJavaProxy
	{
		[Token(Token = "0x40006A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Action<short[]> callback;

		[Token(Token = "0x40006A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private IntPtr javaBuf;

		[Token(Token = "0x40006A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private int cntFrame;

		[Token(Token = "0x40006A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private int cntShort;

		[Token(Token = "0x6000670")]
		[Address(RVA = "0xA0128C", Offset = "0xA0128C", VA = "0xA0128C")]
		public DataCallback(Action<short[]> callback, IntPtr javaBuf)
		{
		}

		[Token(Token = "0x6000671")]
		[Address(RVA = "0xA01328", Offset = "0xA01328", VA = "0xA01328")]
		public void OnData()
		{
		}

		[Token(Token = "0x6000672")]
		[Address(RVA = "0xA013B0", Offset = "0xA013B0", VA = "0xA013B0")]
		public void OnStop()
		{
		}
	}

	[Token(Token = "0x400001C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private AndroidJavaObject audioIn;

	[Token(Token = "0x400001D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private IntPtr javaBuf;

	[Token(Token = "0x400001E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private DataCallback callback;

	[Token(Token = "0x17000008")]
	public int Channels
	{
		[Token(Token = "0x6000023")]
		[Address(RVA = "0xA01320", Offset = "0xA01320", VA = "0xA01320", Slot = "6")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000009")]
	public int SamplingRate
	{
		[Token(Token = "0x6000024")]
		[Address(RVA = "0xA01318", Offset = "0xA01318", VA = "0xA01318", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x6000021")]
	[Address(RVA = "0xA00920", Offset = "0xA00920", VA = "0xA00920")]
	public AndroidAudioInAEC()
	{
	}

	[Token(Token = "0x6000022")]
	[Address(RVA = "0xA00928", Offset = "0xA00928", VA = "0xA00928", Slot = "4")]
	public void SetCallback(Action<short[]> callback, LocalVoice localVoice)
	{
	}

	[Token(Token = "0x6000025")]
	[Address(RVA = "0xA01190", Offset = "0xA01190", VA = "0xA01190", Slot = "7")]
	public void Dispose()
	{
	}
}
[Token(Token = "0x2000007")]
public class AudioClipWrapper : IAudioReader<float>, IDataReader<float>, IDisposable, IAudioSource
{
	[Token(Token = "0x400001F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private AudioClip audioClip;

	[Token(Token = "0x4000020")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private int readPos;

	[Token(Token = "0x4000021")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	private float startTime;

	[Token(Token = "0x4000022")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x98191C", Offset = "0x98191C")]
	private bool <Loop>k__BackingField;

	[Token(Token = "0x4000023")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
	private bool playing;

	[Token(Token = "0x1700000A")]
	public bool Loop
	{
		[Token(Token = "0x6000026")]
		[Address(RVA = "0xA013BC", Offset = "0xA013BC", VA = "0xA013BC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x982D48", Offset = "0x982D48")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000027")]
		[Address(RVA = "0xA013C4", Offset = "0xA013C4", VA = "0xA013C4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x982D58", Offset = "0x982D58")]
		set
		{
		}
	}

	[Token(Token = "0x1700000B")]
	public int SamplingRate
	{
		[Token(Token = "0x600002A")]
		[Address(RVA = "0xA01528", Offset = "0xA01528", VA = "0xA01528", Slot = "6")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x1700000C")]
	public int Channels
	{
		[Token(Token = "0x600002B")]
		[Address(RVA = "0xA01544", Offset = "0xA01544", VA = "0xA01544", Slot = "7")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x6000028")]
	[Address(RVA = "0xA013D0", Offset = "0xA013D0", VA = "0xA013D0")]
	public AudioClipWrapper(AudioClip audioClip)
	{
	}

	[Token(Token = "0x6000029")]
	[Address(RVA = "0xA01410", Offset = "0xA01410", VA = "0xA01410", Slot = "4")]
	public bool Read(float[] buffer)
	{
		return default(bool);
	}

	[Token(Token = "0x600002C")]
	[Address(RVA = "0xA01560", Offset = "0xA01560", VA = "0xA01560", Slot = "5")]
	public void Dispose()
	{
	}
}
[Token(Token = "0x2000008")]
public class AudioOutCapture : MonoBehaviour
{
	[Token(Token = "0x14000001")]
	public event Action<float[], int> OnAudioFrame
	{
		[Token(Token = "0x600002D")]
		[Address(RVA = "0xA01AA0", Offset = "0xA01AA0", VA = "0xA01AA0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x982D68", Offset = "0x982D68")]
		add
		{
		}
		[Token(Token = "0x600002E")]
		[Address(RVA = "0xA01B44", Offset = "0xA01B44", VA = "0xA01B44")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x982D78", Offset = "0x982D78")]
		remove
		{
		}
	}

	[Token(Token = "0x600002F")]
	[Address(RVA = "0xA01BE8", Offset = "0xA01BE8", VA = "0xA01BE8")]
	private void OnAudioFilterRead(float[] frame, int channels)
	{
	}

	[Token(Token = "0x6000030")]
	[Address(RVA = "0xA01C64", Offset = "0xA01C64", VA = "0xA01C64")]
	public AudioOutCapture()
	{
	}
}
[Token(Token = "0x2000009")]
public class AudioStreamPlayer : IAudioOut
{
	[Token(Token = "0x4000025")]
	private const int maxPlayLagMs = 100;

	[Token(Token = "0x4000026")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private int maxPlayLagSamples;

	[Token(Token = "0x4000027")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	private int playDelaySamples;

	[Token(Token = "0x4000028")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private int bufferSamples;

	[Token(Token = "0x4000029")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	private int channels;

	[Token(Token = "0x400002A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private int frameSize;

	[Token(Token = "0x400002B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	private int frameSamples;

	[Token(Token = "0x400002C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private int streamSamplePos;

	[Token(Token = "0x400002D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x98193C", Offset = "0x98193C")]
	private int <CurrentBufferLag>k__BackingField;

	[Token(Token = "0x400002E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private int streamSamplePosAvg;

	[Token(Token = "0x400002F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private AudioSource source;

	[Token(Token = "0x4000030")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private string logPrefix;

	[Token(Token = "0x4000031")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private bool debugInfo;

	[Token(Token = "0x4000032")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	private int sourceTimeSamplesPrev;

	[Token(Token = "0x4000033")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private int playLoopCount;

	[Token(Token = "0x4000034")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private Queue<float[]> frameQueue;

	[Token(Token = "0x4000035")]
	public const int FRAME_POOL_CAPACITY = 50;

	[Token(Token = "0x4000036")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private PrimitiveArrayPool<float> framePool;

	[Token(Token = "0x1700000D")]
	public int CurrentBufferLag
	{
		[Token(Token = "0x6000031")]
		[Address(RVA = "0xA01C6C", Offset = "0xA01C6C", VA = "0xA01C6C", Slot = "9")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x982D88", Offset = "0x982D88")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6000032")]
		[Address(RVA = "0xA01C74", Offset = "0xA01C74", VA = "0xA01C74")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x982D98", Offset = "0x982D98")]
		private set
		{
		}
	}

	[Token(Token = "0x1700000E")]
	public AudioSource AudioSource
	{
		[Token(Token = "0x6000033")]
		[Address(RVA = "0xA01C7C", Offset = "0xA01C7C", VA = "0xA01C7C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700000F")]
	private int playSamplePos
	{
		[Token(Token = "0x6000035")]
		[Address(RVA = "0xA01D58", Offset = "0xA01D58", VA = "0xA01D58")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6000036")]
		[Address(RVA = "0xA01E0C", Offset = "0xA01E0C", VA = "0xA01E0C")]
		set
		{
		}
	}

	[Token(Token = "0x17000010")]
	public bool IsPlaying
	{
		[Token(Token = "0x6000037")]
		[Address(RVA = "0xA01EF0", Offset = "0xA01EF0", VA = "0xA01EF0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6000034")]
	[Address(RVA = "0xA01C84", Offset = "0xA01C84", VA = "0xA01C84")]
	public AudioStreamPlayer(AudioSource audioSource, string logPrefix, bool debugInfo)
	{
	}

	[Token(Token = "0x6000038")]
	[Address(RVA = "0xA01F0C", Offset = "0xA01F0C", VA = "0xA01F0C", Slot = "5")]
	public void Start(int frequency, int channels, int frameSamples, int playDelayMs)
	{
	}

	[Token(Token = "0x6000039")]
	[Address(RVA = "0xA02078", Offset = "0xA02078", VA = "0xA02078", Slot = "8")]
	public void Service()
	{
	}

	[Token(Token = "0x600003A")]
	[Address(RVA = "0xA026DC", Offset = "0xA026DC", VA = "0xA026DC", Slot = "7")]
	public void OnAudioFrame(float[] frame)
	{
	}

	[Token(Token = "0x600003B")]
	[Address(RVA = "0xA02928", Offset = "0xA02928", VA = "0xA02928", Slot = "6")]
	public void Stop()
	{
	}
}
[Token(Token = "0x200000A")]
public class IOSAudioForceToSpeaker : MonoBehaviour
{
	[Token(Token = "0x600003C")]
	[Address(RVA = "0x1721D40", Offset = "0x1721D40", VA = "0x1721D40")]
	private void PhotonVoiceCreated()
	{
	}

	[Token(Token = "0x600003D")]
	[Address(RVA = "0x1721D44", Offset = "0x1721D44", VA = "0x1721D44")]
	public IOSAudioForceToSpeaker()
	{
	}
}
[Token(Token = "0x200000B")]
public class MicWrapper : IAudioReader<float>, IDataReader<float>, IDisposable, IAudioSource
{
	[Token(Token = "0x4000037")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private AudioClip mic;

	[Token(Token = "0x4000038")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private string device;

	[Token(Token = "0x4000039")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private int micPrevPos;

	[Token(Token = "0x400003A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	private int micLoopCnt;

	[Token(Token = "0x400003B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private int readAbsPos;

	[Token(Token = "0x17000011")]
	public int SamplingRate
	{
		[Token(Token = "0x600003F")]
		[Address(RVA = "0x1722428", Offset = "0x1722428", VA = "0x1722428", Slot = "6")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000012")]
	public int Channels
	{
		[Token(Token = "0x6000040")]
		[Address(RVA = "0x1722444", Offset = "0x1722444", VA = "0x1722444", Slot = "7")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x600003E")]
	[Address(RVA = "0x172221C", Offset = "0x172221C", VA = "0x172221C")]
	public MicWrapper(string device, int suggestedFrequency)
	{
	}

	[Token(Token = "0x6000041")]
	[Address(RVA = "0x1722460", Offset = "0x1722460", VA = "0x1722460", Slot = "5")]
	public void Dispose()
	{
	}

	[Token(Token = "0x6000042")]
	[Address(RVA = "0x172246C", Offset = "0x172246C", VA = "0x172246C", Slot = "4")]
	public bool Read(float[] buffer)
	{
		return default(bool);
	}
}
namespace RelationsInspector.Backend.AutoBackend
{
	[Token(Token = "0x200000C")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x98134C", Offset = "0x98134C")]
	public class AutoBackendAttribute : Attribute
	{
		[Token(Token = "0x6000043")]
		[Address(RVA = "0x17248D8", Offset = "0x17248D8", VA = "0x17248D8")]
		public AutoBackendAttribute()
		{
		}
	}
	[Token(Token = "0x200000D")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x981360", Offset = "0x981360")]
	public class RelatedAttribute : Attribute
	{
		[Token(Token = "0x6000044")]
		[Address(RVA = "0x17248E0", Offset = "0x17248E0", VA = "0x17248E0")]
		public RelatedAttribute()
		{
		}
	}
	[Token(Token = "0x200000E")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x981374", Offset = "0x981374")]
	public class RelatingAttribute : Attribute
	{
		[Token(Token = "0x6000045")]
		[Address(RVA = "0x17248E8", Offset = "0x17248E8", VA = "0x17248E8")]
		public RelatingAttribute()
		{
		}
	}
}
namespace POpusCodec
{
	[Token(Token = "0x200000F")]
	public class OpusDecoder : IDisposable
	{
		[Token(Token = "0x400003C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private IntPtr _handle;

		[Token(Token = "0x400003D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private string _version;

		[Token(Token = "0x400003E")]
		private const int MaxFrameSize = 5760;

		[Token(Token = "0x400003F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private bool _previousPacketInvalid;

		[Token(Token = "0x4000040")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private int _channelCount;

		[Token(Token = "0x4000041")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly float[] EmptyBufferFloat;

		[Token(Token = "0x4000042")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static readonly short[] EmptyBufferShort;

		[Token(Token = "0x4000043")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Bandwidth? _previousPacketBandwidth;

		[Token(Token = "0x4000044")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float[] bufferFloat;

		[Token(Token = "0x4000045")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private short[] bufferShort;

		[Token(Token = "0x17000013")]
		public string Version
		{
			[Token(Token = "0x6000046")]
			[Address(RVA = "0x1722550", Offset = "0x1722550", VA = "0x1722550")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000014")]
		public Bandwidth? PreviousPacketBandwidth
		{
			[Token(Token = "0x6000047")]
			[Address(RVA = "0x1722558", Offset = "0x1722558", VA = "0x1722558")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000048")]
		[Address(RVA = "0x1722560", Offset = "0x1722560", VA = "0x1722560")]
		public OpusDecoder(SamplingRate outputSamplingRateHz, Channels numChannels)
		{
		}

		[Token(Token = "0x6000049")]
		[Address(RVA = "0x17229CC", Offset = "0x17229CC", VA = "0x17229CC")]
		public float[] DecodePacketFloat(byte[] packetData)
		{
			return null;
		}

		[Token(Token = "0x600004A")]
		[Address(RVA = "0x1722CA8", Offset = "0x1722CA8", VA = "0x1722CA8")]
		public short[] DecodePacketShort(byte[] packetData)
		{
			return null;
		}

		[Token(Token = "0x600004B")]
		[Address(RVA = "0x1722F00", Offset = "0x1722F00", VA = "0x1722F00", Slot = "4")]
		public void Dispose()
		{
		}
	}
	[Token(Token = "0x2000010")]
	public class OpusEncoder : IDisposable
	{
		[Token(Token = "0x4000046")]
		public const int BitrateMax = -1;

		[Token(Token = "0x4000047")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private IntPtr _handle;

		[Token(Token = "0x4000048")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private string _version;

		[Token(Token = "0x4000049")]
		private const int RecommendedMaxPacketSize = 4000;

		[Token(Token = "0x400004A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private int _frameSizePerChannel;

		[Token(Token = "0x400004B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private SamplingRate _inputSamplingRate;

		[Token(Token = "0x400004C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Channels _inputChannels;

		[Token(Token = "0x400004D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private readonly byte[] writePacket;

		[Token(Token = "0x400004E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly ArraySegment<byte> EmptyBuffer;

		[Token(Token = "0x400004F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Delay _encoderDelay;

		[Token(Token = "0x17000015")]
		public SamplingRate InputSamplingRate
		{
			[Token(Token = "0x600004D")]
			[Address(RVA = "0x172304C", Offset = "0x172304C", VA = "0x172304C")]
			get
			{
				return default(SamplingRate);
			}
		}

		[Token(Token = "0x17000016")]
		public Channels InputChannels
		{
			[Token(Token = "0x600004E")]
			[Address(RVA = "0x1723054", Offset = "0x1723054", VA = "0x1723054")]
			get
			{
				return default(Channels);
			}
		}

		[Token(Token = "0x17000017")]
		public string Version
		{
			[Token(Token = "0x600004F")]
			[Address(RVA = "0x172305C", Offset = "0x172305C", VA = "0x172305C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000018")]
		public Delay EncoderDelay
		{
			[Token(Token = "0x6000051")]
			[Address(RVA = "0x1723168", Offset = "0x1723168", VA = "0x1723168")]
			get
			{
				return default(Delay);
			}
			[Token(Token = "0x6000050")]
			[Address(RVA = "0x1723064", Offset = "0x1723064", VA = "0x1723064")]
			set
			{
			}
		}

		[Token(Token = "0x17000019")]
		public int FrameSizePerChannel
		{
			[Token(Token = "0x6000052")]
			[Address(RVA = "0x1723170", Offset = "0x1723170", VA = "0x1723170")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700001A")]
		public int Bitrate
		{
			[Token(Token = "0x6000053")]
			[Address(RVA = "0x1723178", Offset = "0x1723178", VA = "0x1723178")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000054")]
			[Address(RVA = "0x1723240", Offset = "0x1723240", VA = "0x1723240")]
			set
			{
			}
		}

		[Token(Token = "0x1700001B")]
		public Bandwidth MaxBandwidth
		{
			[Token(Token = "0x6000055")]
			[Address(RVA = "0x1723300", Offset = "0x1723300", VA = "0x1723300")]
			get
			{
				return default(Bandwidth);
			}
			[Token(Token = "0x6000056")]
			[Address(RVA = "0x172330C", Offset = "0x172330C", VA = "0x172330C")]
			set
			{
			}
		}

		[Token(Token = "0x1700001C")]
		public Complexity Complexity
		{
			[Token(Token = "0x6000057")]
			[Address(RVA = "0x172331C", Offset = "0x172331C", VA = "0x172331C")]
			get
			{
				return default(Complexity);
			}
			[Token(Token = "0x6000058")]
			[Address(RVA = "0x1723328", Offset = "0x1723328", VA = "0x1723328")]
			set
			{
			}
		}

		[Token(Token = "0x1700001D")]
		public int ExpectedPacketLossPercentage
		{
			[Token(Token = "0x6000059")]
			[Address(RVA = "0x1723338", Offset = "0x1723338", VA = "0x1723338")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600005A")]
			[Address(RVA = "0x1723344", Offset = "0x1723344", VA = "0x1723344")]
			set
			{
			}
		}

		[Token(Token = "0x1700001E")]
		public SignalHint SignalHint
		{
			[Token(Token = "0x600005B")]
			[Address(RVA = "0x1723354", Offset = "0x1723354", VA = "0x1723354")]
			get
			{
				return default(SignalHint);
			}
			[Token(Token = "0x600005C")]
			[Address(RVA = "0x1723360", Offset = "0x1723360", VA = "0x1723360")]
			set
			{
			}
		}

		[Token(Token = "0x1700001F")]
		public ForceChannels ForceChannels
		{
			[Token(Token = "0x600005D")]
			[Address(RVA = "0x1723370", Offset = "0x1723370", VA = "0x1723370")]
			get
			{
				return default(ForceChannels);
			}
			[Token(Token = "0x600005E")]
			[Address(RVA = "0x172337C", Offset = "0x172337C", VA = "0x172337C")]
			set
			{
			}
		}

		[Token(Token = "0x17000020")]
		public bool UseInbandFEC
		{
			[Token(Token = "0x600005F")]
			[Address(RVA = "0x172338C", Offset = "0x172338C", VA = "0x172338C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000060")]
			[Address(RVA = "0x17233B0", Offset = "0x17233B0", VA = "0x17233B0")]
			set
			{
			}
		}

		[Token(Token = "0x17000021")]
		public bool UseUnconstrainedVBR
		{
			[Token(Token = "0x6000061")]
			[Address(RVA = "0x17233C0", Offset = "0x17233C0", VA = "0x17233C0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000062")]
			[Address(RVA = "0x17233E4", Offset = "0x17233E4", VA = "0x17233E4")]
			set
			{
			}
		}

		[Token(Token = "0x17000022")]
		public bool DtxEnabled
		{
			[Token(Token = "0x6000063")]
			[Address(RVA = "0x17233F8", Offset = "0x17233F8", VA = "0x17233F8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000064")]
			[Address(RVA = "0x172341C", Offset = "0x172341C", VA = "0x172341C")]
			set
			{
			}
		}

		[Token(Token = "0x6000065")]
		[Address(RVA = "0x172342C", Offset = "0x172342C", VA = "0x172342C")]
		public OpusEncoder(SamplingRate inputSamplingRateHz, Channels numChannels, int bitrate, OpusApplicationType applicationType, Delay encoderDelay)
		{
		}

		[Token(Token = "0x6000066")]
		[Address(RVA = "0x1723924", Offset = "0x1723924", VA = "0x1723924")]
		public ArraySegment<byte> Encode(float[] pcmSamples)
		{
			return default(ArraySegment<byte>);
		}

		[Token(Token = "0x6000067")]
		[Address(RVA = "0x1723AD4", Offset = "0x1723AD4", VA = "0x1723AD4")]
		public ArraySegment<byte> Encode(short[] pcmSamples)
		{
			return default(ArraySegment<byte>);
		}

		[Token(Token = "0x6000068")]
		[Address(RVA = "0x1723C84", Offset = "0x1723C84", VA = "0x1723C84", Slot = "4")]
		public void Dispose()
		{
		}
	}
	[Token(Token = "0x2000011")]
	public class OpusException : Exception
	{
		[Token(Token = "0x4000050")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private OpusStatusCode _statusCode;

		[Token(Token = "0x17000023")]
		public OpusStatusCode StatusCode
		{
			[Token(Token = "0x600006A")]
			[Address(RVA = "0x1723DD8", Offset = "0x1723DD8", VA = "0x1723DD8")]
			get
			{
				return default(OpusStatusCode);
			}
		}

		[Token(Token = "0x600006B")]
		[Address(RVA = "0x1722948", Offset = "0x1722948", VA = "0x1722948")]
		public OpusException(OpusStatusCode statusCode, string message)
		{
		}
	}
	[Token(Token = "0x2000012")]
	internal class Wrapper
	{
		[Token(Token = "0x4000051")]
		private const string lib_name = "opus_egpv";

		[PreserveSig]
		[Token(Token = "0x600006C")]
		[Address(RVA = "0x1723DE0", Offset = "0x1723DE0", VA = "0x1723DE0")]
		private static extern int opus_encoder_get_size(Channels channels);

		[PreserveSig]
		[Token(Token = "0x600006D")]
		[Address(RVA = "0x1723E60", Offset = "0x1723E60", VA = "0x1723E60")]
		private static extern OpusStatusCode opus_encoder_init(IntPtr st, SamplingRate Fs, Channels channels, OpusApplicationType application);

		[PreserveSig]
		[Token(Token = "0x600006E")]
		[Address(RVA = "0x17228D8", Offset = "0x17228D8", VA = "0x17228D8")]
		public static extern IntPtr opus_get_version_string();

		[PreserveSig]
		[Token(Token = "0x600006F")]
		[Address(RVA = "0x1723F08", Offset = "0x1723F08", VA = "0x1723F08")]
		private static extern int opus_encode(IntPtr st, short[] pcm, int frame_size, byte[] data, int max_data_bytes);

		[PreserveSig]
		[Token(Token = "0x6000070")]
		[Address(RVA = "0x1723FC8", Offset = "0x1723FC8", VA = "0x1723FC8")]
		private static extern int opus_encode_float(IntPtr st, float[] pcm, int frame_size, byte[] data, int max_data_bytes);

		[PreserveSig]
		[Token(Token = "0x6000071")]
		[Address(RVA = "0x1724088", Offset = "0x1724088", VA = "0x1724088")]
		private static extern int opus_encoder_ctl_set(IntPtr st, OpusCtlSetRequest request, int value);

		[PreserveSig]
		[Token(Token = "0x6000072")]
		[Address(RVA = "0x1724120", Offset = "0x1724120", VA = "0x1724120")]
		private static extern int opus_encoder_ctl_get(IntPtr st, OpusCtlGetRequest request, ref int value);

		[PreserveSig]
		[Token(Token = "0x6000073")]
		[Address(RVA = "0x17241B4", Offset = "0x17241B4", VA = "0x17241B4")]
		private static extern int opus_decoder_ctl_set(IntPtr st, OpusCtlSetRequest request, int value);

		[PreserveSig]
		[Token(Token = "0x6000074")]
		[Address(RVA = "0x172424C", Offset = "0x172424C", VA = "0x172424C")]
		private static extern int opus_decoder_ctl_get(IntPtr st, OpusCtlGetRequest request, ref int value);

		[PreserveSig]
		[Token(Token = "0x6000075")]
		[Address(RVA = "0x17242E0", Offset = "0x17242E0", VA = "0x17242E0")]
		private static extern int opus_decoder_get_size(Channels channels);

		[PreserveSig]
		[Token(Token = "0x6000076")]
		[Address(RVA = "0x1724360", Offset = "0x1724360", VA = "0x1724360")]
		private static extern OpusStatusCode opus_decoder_init(IntPtr st, SamplingRate Fs, Channels channels);

		[PreserveSig]
		[Token(Token = "0x6000077")]
		[Address(RVA = "0x17243F8", Offset = "0x17243F8", VA = "0x17243F8")]
		private static extern int opus_decode(IntPtr st, byte[] data, int len, short[] pcm, int frame_size, int decode_fec);

		[PreserveSig]
		[Token(Token = "0x6000078")]
		[Address(RVA = "0x17244C8", Offset = "0x17244C8", VA = "0x17244C8")]
		private static extern int opus_decode_float(IntPtr st, byte[] data, int len, float[] pcm, int frame_size, int decode_fec);

		[PreserveSig]
		[Token(Token = "0x6000079")]
		[Address(RVA = "0x1722C20", Offset = "0x1722C20", VA = "0x1722C20")]
		public static extern int opus_packet_get_bandwidth(byte[] data);

		[PreserveSig]
		[Token(Token = "0x600007A")]
		[Address(RVA = "0x1724598", Offset = "0x1724598", VA = "0x1724598")]
		public static extern int opus_packet_get_nb_channels(byte[] data);

		[PreserveSig]
		[Token(Token = "0x600007B")]
		[Address(RVA = "0x1724620", Offset = "0x1724620", VA = "0x1724620")]
		private static extern IntPtr opus_strerror(OpusStatusCode error);

		[Token(Token = "0x600007C")]
		[Address(RVA = "0x17237E0", Offset = "0x17237E0", VA = "0x17237E0")]
		public static IntPtr opus_encoder_create(SamplingRate Fs, Channels channels, OpusApplicationType application)
		{
			return default(IntPtr);
		}

		[Token(Token = "0x600007D")]
		[Address(RVA = "0x1723BA0", Offset = "0x1723BA0", VA = "0x1723BA0")]
		public static int opus_encode(IntPtr st, short[] pcm, int frame_size, byte[] data)
		{
			return default(int);
		}

		[Token(Token = "0x600007E")]
		[Address(RVA = "0x17239F0", Offset = "0x17239F0", VA = "0x17239F0")]
		public static int opus_encode(IntPtr st, float[] pcm, int frame_size, byte[] data)
		{
			return default(int);
		}

		[Token(Token = "0x600007F")]
		[Address(RVA = "0x1723CE4", Offset = "0x1723CE4", VA = "0x1723CE4")]
		public static void opus_encoder_destroy(IntPtr st)
		{
		}

		[Token(Token = "0x6000080")]
		[Address(RVA = "0x1723184", Offset = "0x1723184", VA = "0x1723184")]
		public static int get_opus_encoder_ctl(IntPtr st, OpusCtlGetRequest request)
		{
			return default(int);
		}

		[Token(Token = "0x6000081")]
		[Address(RVA = "0x1723250", Offset = "0x1723250", VA = "0x1723250")]
		public static void set_opus_encoder_ctl(IntPtr st, OpusCtlSetRequest request, int value)
		{
		}

		[Token(Token = "0x6000082")]
		[Address(RVA = "0x1724764", Offset = "0x1724764", VA = "0x1724764")]
		public static int get_opus_decoder_ctl(IntPtr st, OpusCtlGetRequest request)
		{
			return default(int);
		}

		[Token(Token = "0x6000083")]
		[Address(RVA = "0x1724820", Offset = "0x1724820", VA = "0x1724820")]
		public static void set_opus_decoder_ctl(IntPtr st, OpusCtlSetRequest request, int value)
		{
		}

		[Token(Token = "0x6000084")]
		[Address(RVA = "0x172279C", Offset = "0x172279C", VA = "0x172279C")]
		public static IntPtr opus_decoder_create(SamplingRate Fs, Channels channels)
		{
			return default(IntPtr);
		}

		[Token(Token = "0x6000085")]
		[Address(RVA = "0x1722F60", Offset = "0x1722F60", VA = "0x1722F60")]
		public static void opus_decoder_destroy(IntPtr st)
		{
		}

		[Token(Token = "0x6000086")]
		[Address(RVA = "0x1722DE4", Offset = "0x1722DE4", VA = "0x1722DE4")]
		public static int opus_decode(IntPtr st, byte[] data, short[] pcm, int decode_fec, int channels)
		{
			return default(int);
		}

		[Token(Token = "0x6000087")]
		[Address(RVA = "0x1722B04", Offset = "0x1722B04", VA = "0x1722B04")]
		public static int opus_decode(IntPtr st, byte[] data, float[] pcm, int decode_fec, int channels)
		{
			return default(int);
		}

		[Token(Token = "0x6000088")]
		[Address(RVA = "0x17246A0", Offset = "0x17246A0", VA = "0x17246A0")]
		private static void HandleStatusCode(OpusStatusCode statusCode)
		{
		}

		[Token(Token = "0x6000089")]
		[Address(RVA = "0x17248D0", Offset = "0x17248D0", VA = "0x17248D0")]
		public Wrapper()
		{
		}
	}
}
namespace POpusCodec.Enums
{
	[Token(Token = "0x2000013")]
	public enum Bandwidth
	{
		[Token(Token = "0x4000053")]
		Narrowband = 1101,
		[Token(Token = "0x4000054")]
		Mediumband,
		[Token(Token = "0x4000055")]
		Wideband,
		[Token(Token = "0x4000056")]
		SuperWideband,
		[Token(Token = "0x4000057")]
		Fullband
	}
	[Token(Token = "0x2000014")]
	public enum Channels
	{
		[Token(Token = "0x4000059")]
		Mono = 1,
		[Token(Token = "0x400005A")]
		Stereo
	}
	[Token(Token = "0x2000015")]
	public enum Complexity
	{
		[Token(Token = "0x400005C")]
		Complexity0,
		[Token(Token = "0x400005D")]
		Complexity1,
		[Token(Token = "0x400005E")]
		Complexity2,
		[Token(Token = "0x400005F")]
		Complexity3,
		[Token(Token = "0x4000060")]
		Complexity4,
		[Token(Token = "0x4000061")]
		Complexity5,
		[Token(Token = "0x4000062")]
		Complexity6,
		[Token(Token = "0x4000063")]
		Complexity7,
		[Token(Token = "0x4000064")]
		Complexity8,
		[Token(Token = "0x4000065")]
		Complexity9,
		[Token(Token = "0x4000066")]
		Complexity10
	}
	[Token(Token = "0x2000016")]
	public enum Delay
	{
		[Token(Token = "0x4000068")]
		Delay2dot5ms = 5,
		[Token(Token = "0x4000069")]
		Delay5ms = 10,
		[Token(Token = "0x400006A")]
		Delay10ms = 20,
		[Token(Token = "0x400006B")]
		Delay20ms = 40,
		[Token(Token = "0x400006C")]
		Delay40ms = 80,
		[Token(Token = "0x400006D")]
		Delay60ms = 120
	}
	[Token(Token = "0x2000017")]
	public enum ForceChannels
	{
		[Token(Token = "0x400006F")]
		NoForce = -1000,
		[Token(Token = "0x4000070")]
		Mono = 1,
		[Token(Token = "0x4000071")]
		Stereo = 2
	}
	[Token(Token = "0x2000018")]
	public enum OpusApplicationType
	{
		[Token(Token = "0x4000073")]
		Voip = 2048,
		[Token(Token = "0x4000074")]
		Audio = 2049,
		[Token(Token = "0x4000075")]
		RestrictedLowDelay = 2051
	}
	[Token(Token = "0x2000019")]
	internal enum OpusCtlGetRequest
	{
		[Token(Token = "0x4000077")]
		Application = 4001,
		[Token(Token = "0x4000078")]
		Bitrate = 4003,
		[Token(Token = "0x4000079")]
		MaxBandwidth = 4005,
		[Token(Token = "0x400007A")]
		VBR = 4007,
		[Token(Token = "0x400007B")]
		Bandwidth = 4009,
		[Token(Token = "0x400007C")]
		Complexity = 4011,
		[Token(Token = "0x400007D")]
		InbandFec = 4013,
		[Token(Token = "0x400007E")]
		PacketLossPercentage = 4015,
		[Token(Token = "0x400007F")]
		Dtx = 4017,
		[Token(Token = "0x4000080")]
		VBRConstraint = 4021,
		[Token(Token = "0x4000081")]
		ForceChannels = 4023,
		[Token(Token = "0x4000082")]
		Signal = 4025,
		[Token(Token = "0x4000083")]
		LookAhead = 4027,
		[Token(Token = "0x4000084")]
		SampleRate = 4029,
		[Token(Token = "0x4000085")]
		FinalRange = 4031,
		[Token(Token = "0x4000086")]
		Pitch = 4033,
		[Token(Token = "0x4000087")]
		Gain = 4035,
		[Token(Token = "0x4000088")]
		LsbDepth = 4037,
		[Token(Token = "0x4000089")]
		LastPacketDurationRequest = 4039
	}
	[Token(Token = "0x200001A")]
	internal enum OpusCtlSetRequest
	{
		[Token(Token = "0x400008B")]
		Application = 4000,
		[Token(Token = "0x400008C")]
		Bitrate = 4002,
		[Token(Token = "0x400008D")]
		MaxBandwidth = 4004,
		[Token(Token = "0x400008E")]
		VBR = 4006,
		[Token(Token = "0x400008F")]
		Bandwidth = 4008,
		[Token(Token = "0x4000090")]
		Complexity = 4010,
		[Token(Token = "0x4000091")]
		InbandFec = 4012,
		[Token(Token = "0x4000092")]
		PacketLossPercentage = 4014,
		[Token(Token = "0x4000093")]
		Dtx = 4016,
		[Token(Token = "0x4000094")]
		VBRConstraint = 4020,
		[Token(Token = "0x4000095")]
		ForceChannels = 4022,
		[Token(Token = "0x4000096")]
		Signal = 4024,
		[Token(Token = "0x4000097")]
		Gain = 4034,
		[Token(Token = "0x4000098")]
		LsbDepth = 4036
	}
	[Token(Token = "0x200001B")]
	public enum OpusStatusCode
	{
		[Token(Token = "0x400009A")]
		OK = 0,
		[Token(Token = "0x400009B")]
		BadArguments = -1,
		[Token(Token = "0x400009C")]
		BufferTooSmall = -2,
		[Token(Token = "0x400009D")]
		InternalError = -3,
		[Token(Token = "0x400009E")]
		InvalidPacket = -4,
		[Token(Token = "0x400009F")]
		Unimplemented = -5,
		[Token(Token = "0x40000A0")]
		InvalidState = -6,
		[Token(Token = "0x40000A1")]
		AllocFail = -7
	}
	[Token(Token = "0x200001C")]
	public enum SamplingRate
	{
		[Token(Token = "0x40000A3")]
		Sampling08000 = 8000,
		[Token(Token = "0x40000A4")]
		Sampling12000 = 12000,
		[Token(Token = "0x40000A5")]
		Sampling16000 = 16000,
		[Token(Token = "0x40000A6")]
		Sampling24000 = 24000,
		[Token(Token = "0x40000A7")]
		Sampling48000 = 48000
	}
	[Token(Token = "0x200001D")]
	public enum SignalHint
	{
		[Token(Token = "0x40000A9")]
		Auto = -1000,
		[Token(Token = "0x40000AA")]
		Voice = 3001,
		[Token(Token = "0x40000AB")]
		Music = 3002
	}
}
namespace ExitGames.Client.Photon.Voice
{
	[Token(Token = "0x200001E")]
	public static class AudioUtil
	{
		[Token(Token = "0x20000C7")]
		public class Resampler<T> : LocalVoiceFramed<T>.IProcessor, IDisposable
		{
			[Token(Token = "0x40006A8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			protected T[] frameResampled;

			[Token(Token = "0x40006A9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private int channels;

			[Token(Token = "0x6000673")]
			public Resampler(int dstSize, int channels)
			{
			}

			[Token(Token = "0x6000674")]
			public T[] Process(T[] buf)
			{
				return null;
			}

			[Token(Token = "0x6000675")]
			public void Dispose()
			{
			}
		}

		[Token(Token = "0x20000C8")]
		public interface ILevelMeter
		{
			[Token(Token = "0x17000173")]
			float CurrentAvgAmp
			{
				[Token(Token = "0x6000676")]
				get;
			}

			[Token(Token = "0x17000174")]
			float CurrentPeakAmp
			{
				[Token(Token = "0x6000677")]
				get;
			}

			[Token(Token = "0x17000175")]
			float AccumAvgPeakAmp
			{
				[Token(Token = "0x6000678")]
				get;
			}

			[Token(Token = "0x6000679")]
			void ResetAccumAvgPeakAmp();
		}

		[Token(Token = "0x20000C9")]
		public class LevelMetterDummy : ILevelMeter
		{
			[Token(Token = "0x17000176")]
			public float CurrentAvgAmp
			{
				[Token(Token = "0x600067A")]
				[Address(RVA = "0xE69FA8", Offset = "0xE69FA8", VA = "0xE69FA8", Slot = "4")]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x17000177")]
			public float CurrentPeakAmp
			{
				[Token(Token = "0x600067B")]
				[Address(RVA = "0xE69FB0", Offset = "0xE69FB0", VA = "0xE69FB0", Slot = "5")]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x17000178")]
			public float AccumAvgPeakAmp
			{
				[Token(Token = "0x600067C")]
				[Address(RVA = "0xE69FB8", Offset = "0xE69FB8", VA = "0xE69FB8", Slot = "6")]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x600067D")]
			[Address(RVA = "0xE69FC0", Offset = "0xE69FC0", VA = "0xE69FC0", Slot = "7")]
			public void ResetAccumAvgPeakAmp()
			{
			}

			[Token(Token = "0x600067E")]
			[Address(RVA = "0xE69FC4", Offset = "0xE69FC4", VA = "0xE69FC4")]
			public LevelMetterDummy()
			{
			}
		}

		[Token(Token = "0x20000CA")]
		public abstract class LevelMeter<T> : LocalVoiceFramed<T>.IProcessor, IDisposable, ILevelMeter
		{
			[Token(Token = "0x40006AA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			protected float ampSum;

			[Token(Token = "0x40006AB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			protected float ampPeak;

			[Token(Token = "0x40006AC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			protected int bufferSize;

			[Token(Token = "0x40006AD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			protected float[] buffer;

			[Token(Token = "0x40006AE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			protected int prevValuesPtr;

			[Token(Token = "0x40006AF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			protected float accumAvgPeakAmpSum;

			[Token(Token = "0x40006B0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			protected int accumAvgPeakAmpCount;

			[Token(Token = "0x40006B1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x982CB8", Offset = "0x982CB8")]
			private float <CurrentPeakAmp>k__BackingField;

			[Token(Token = "0x17000179")]
			public float CurrentAvgAmp
			{
				[Token(Token = "0x6000680")]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x1700017A")]
			public float CurrentPeakAmp
			{
				[Token(Token = "0x6000681")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x984218", Offset = "0x984218")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000682")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x984228", Offset = "0x984228")]
				protected set
				{
				}
			}

			[Token(Token = "0x1700017B")]
			public float AccumAvgPeakAmp
			{
				[Token(Token = "0x6000683")]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x600067F")]
			internal LevelMeter(int samplingRate, int numChannels)
			{
			}

			[Token(Token = "0x6000684")]
			public void ResetAccumAvgPeakAmp()
			{
			}

			[Token(Token = "0x6000685")]
			public abstract T[] Process(T[] buf);

			[Token(Token = "0x6000686")]
			public void Dispose()
			{
			}
		}

		[Token(Token = "0x20000CB")]
		public class LevelMeterFloat : LevelMeter<float>
		{
			[Token(Token = "0x6000687")]
			[Address(RVA = "0xE69C6C", Offset = "0xE69C6C", VA = "0xE69C6C")]
			public LevelMeterFloat(int samplingRate, int numChannels)
			{
			}

			[Token(Token = "0x6000688")]
			[Address(RVA = "0xE69CD4", Offset = "0xE69CD4", VA = "0xE69CD4", Slot = "10")]
			public override float[] Process(float[] buf)
			{
				return null;
			}
		}

		[Token(Token = "0x20000CC")]
		public class LevelMeterShort : LevelMeter<short>
		{
			[Token(Token = "0x6000689")]
			[Address(RVA = "0xE69E08", Offset = "0xE69E08", VA = "0xE69E08")]
			public LevelMeterShort(int samplingRate, int numChannels)
			{
			}

			[Token(Token = "0x600068A")]
			[Address(RVA = "0xE69E70", Offset = "0xE69E70", VA = "0xE69E70", Slot = "10")]
			public override short[] Process(short[] buf)
			{
				return null;
			}
		}

		[Token(Token = "0x20000CD")]
		public interface IVoiceDetector
		{
			[Token(Token = "0x1700017C")]
			bool On
			{
				[Token(Token = "0x600068B")]
				get;
				[Token(Token = "0x600068C")]
				set;
			}

			[Token(Token = "0x1700017D")]
			float Threshold
			{
				[Token(Token = "0x600068D")]
				get;
				[Token(Token = "0x600068E")]
				set;
			}

			[Token(Token = "0x1700017E")]
			bool Detected
			{
				[Token(Token = "0x600068F")]
				get;
			}

			[Token(Token = "0x1700017F")]
			DateTime DetectedTime
			{
				[Token(Token = "0x6000690")]
				get;
			}

			[Token(Token = "0x17000180")]
			int ActivityDelayMs
			{
				[Token(Token = "0x6000693")]
				get;
				[Token(Token = "0x6000694")]
				set;
			}

			[Token(Token = "0x1400000B")]
			event Action OnDetected;
		}

		[Token(Token = "0x20000CE")]
		public class VoiceDetectorCalibration<T> : LocalVoiceFramed<T>.IProcessor, IDisposable
		{
			[Token(Token = "0x40006B2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private IVoiceDetector voiceDetector;

			[Token(Token = "0x40006B3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private ILevelMeter levelMeter;

			[Token(Token = "0x40006B4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private int valuesPerSec;

			[Token(Token = "0x40006B5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			protected int voiceDetectorCalibrateCount;

			[Token(Token = "0x17000181")]
			public bool VoiceDetectorCalibrating
			{
				[Token(Token = "0x6000695")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x6000696")]
			public VoiceDetectorCalibration(IVoiceDetector voiceDetector, ILevelMeter levelMeter, int samplingRate, int channels)
			{
			}

			[Token(Token = "0x6000697")]
			public void VoiceDetectorCalibrate(int durationMs)
			{
			}

			[Token(Token = "0x6000698")]
			public T[] Process(T[] buf)
			{
				return null;
			}

			[Token(Token = "0x6000699")]
			public void Dispose()
			{
			}
		}

		[Token(Token = "0x20000CF")]
		public class VoiceDetectorDummy : IVoiceDetector
		{
			[Token(Token = "0x40006B6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x982CC8", Offset = "0x982CC8")]
			private DateTime <DetectedTime>k__BackingField;

			[Token(Token = "0x17000182")]
			public bool On
			{
				[Token(Token = "0x600069A")]
				[Address(RVA = "0xE69FCC", Offset = "0xE69FCC", VA = "0xE69FCC", Slot = "4")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x600069B")]
				[Address(RVA = "0xE69FD4", Offset = "0xE69FD4", VA = "0xE69FD4", Slot = "5")]
				set
				{
				}
			}

			[Token(Token = "0x17000183")]
			public float Threshold
			{
				[Token(Token = "0x600069C")]
				[Address(RVA = "0xE69FD8", Offset = "0xE69FD8", VA = "0xE69FD8", Slot = "6")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x600069D")]
				[Address(RVA = "0xE69FE0", Offset = "0xE69FE0", VA = "0xE69FE0", Slot = "7")]
				set
				{
				}
			}

			[Token(Token = "0x17000184")]
			public bool Detected
			{
				[Token(Token = "0x600069E")]
				[Address(RVA = "0xE69FE4", Offset = "0xE69FE4", VA = "0xE69FE4", Slot = "8")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x17000185")]
			public int ActivityDelayMs
			{
				[Token(Token = "0x600069F")]
				[Address(RVA = "0xE69FEC", Offset = "0xE69FEC", VA = "0xE69FEC", Slot = "12")]
				get
				{
					return default(int);
				}
				[Token(Token = "0x60006A0")]
				[Address(RVA = "0xE69FF4", Offset = "0xE69FF4", VA = "0xE69FF4", Slot = "13")]
				set
				{
				}
			}

			[Token(Token = "0x17000186")]
			public DateTime DetectedTime
			{
				[Token(Token = "0x60006A1")]
				[Address(RVA = "0xE69FF8", Offset = "0xE69FF8", VA = "0xE69FF8", Slot = "9")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x984258", Offset = "0x984258")]
				get
				{
					return default(DateTime);
				}
				[Token(Token = "0x60006A2")]
				[Address(RVA = "0xE6A000", Offset = "0xE6A000", VA = "0xE6A000")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x984268", Offset = "0x984268")]
				private set
				{
				}
			}

			[Token(Token = "0x1400000C")]
			public event Action OnDetected
			{
				[Token(Token = "0x60006A3")]
				[Address(RVA = "0xE6A008", Offset = "0xE6A008", VA = "0xE6A008", Slot = "10")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x984278", Offset = "0x984278")]
				add
				{
				}
				[Token(Token = "0x60006A4")]
				[Address(RVA = "0xE6A0AC", Offset = "0xE6A0AC", VA = "0xE6A0AC", Slot = "11")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x984288", Offset = "0x984288")]
				remove
				{
				}
			}

			[Token(Token = "0x60006A5")]
			[Address(RVA = "0xE6A150", Offset = "0xE6A150", VA = "0xE6A150")]
			public VoiceDetectorDummy()
			{
			}
		}

		[Token(Token = "0x20000D0")]
		public abstract class VoiceDetector<T> : LocalVoiceFramed<T>.IProcessor, IDisposable, IVoiceDetector
		{
			[Token(Token = "0x40006B8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x982CE8", Offset = "0x982CE8")]
			private bool <On>k__BackingField;

			[Token(Token = "0x40006B9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x982CF8", Offset = "0x982CF8")]
			private float <Threshold>k__BackingField;

			[Token(Token = "0x40006BA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private bool detected;

			[Token(Token = "0x40006BB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x982D08", Offset = "0x982D08")]
			private DateTime <DetectedTime>k__BackingField;

			[Token(Token = "0x40006BD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			protected int activityDelay;

			[Token(Token = "0x40006BE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			protected int autoSilenceCounter;

			[Token(Token = "0x40006BF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			protected int valuesCountPerSec;

			[Token(Token = "0x40006C0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			protected int activityDelayValuesCount;

			[Token(Token = "0x17000187")]
			public bool On
			{
				[Token(Token = "0x60006A6")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x984298", Offset = "0x984298")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x60006A7")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9842A8", Offset = "0x9842A8")]
				set
				{
				}
			}

			[Token(Token = "0x17000188")]
			public float Threshold
			{
				[Token(Token = "0x60006A8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9842B8", Offset = "0x9842B8")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x60006A9")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9842C8", Offset = "0x9842C8")]
				set
				{
				}
			}

			[Token(Token = "0x17000189")]
			public bool Detected
			{
				[Token(Token = "0x60006AA")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x60006AB")]
				protected set
				{
				}
			}

			[Token(Token = "0x1700018A")]
			public DateTime DetectedTime
			{
				[Token(Token = "0x60006AC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9842D8", Offset = "0x9842D8")]
				get
				{
					return default(DateTime);
				}
				[Token(Token = "0x60006AD")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9842E8", Offset = "0x9842E8")]
				private set
				{
				}
			}

			[Token(Token = "0x1700018B")]
			public int ActivityDelayMs
			{
				[Token(Token = "0x60006AE")]
				get
				{
					return default(int);
				}
				[Token(Token = "0x60006AF")]
				set
				{
				}
			}

			[Token(Token = "0x1400000D")]
			public event Action OnDetected
			{
				[Token(Token = "0x60006B0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9842F8", Offset = "0x9842F8")]
				add
				{
				}
				[Token(Token = "0x60006B1")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x984308", Offset = "0x984308")]
				remove
				{
				}
			}

			[Token(Token = "0x60006B2")]
			internal VoiceDetector(int samplingRate, int numChannels)
			{
			}

			[Token(Token = "0x60006B3")]
			public abstract T[] Process(T[] buf);

			[Token(Token = "0x60006B4")]
			public void Dispose()
			{
			}
		}

		[Token(Token = "0x20000D1")]
		public class VoiceDetectorFloat : VoiceDetector<float>
		{
			[Token(Token = "0x60006B5")]
			[Address(RVA = "0xE6A158", Offset = "0xE6A158", VA = "0xE6A158")]
			public VoiceDetectorFloat(int samplingRate, int numChannels)
			{
			}

			[Token(Token = "0x60006B6")]
			[Address(RVA = "0xE6A1D0", Offset = "0xE6A1D0", VA = "0xE6A1D0", Slot = "16")]
			public override float[] Process(float[] buffer)
			{
				return null;
			}
		}

		[Token(Token = "0x20000D2")]
		public class VoiceDetectorShort : VoiceDetector<short>
		{
			[Token(Token = "0x60006B7")]
			[Address(RVA = "0xE6A2E8", Offset = "0xE6A2E8", VA = "0xE6A2E8")]
			internal VoiceDetectorShort(int samplingRate, int numChannels)
			{
			}

			[Token(Token = "0x60006B8")]
			[Address(RVA = "0xE6A360", Offset = "0xE6A360", VA = "0xE6A360", Slot = "16")]
			public override short[] Process(short[] buffer)
			{
				return null;
			}
		}

		[Token(Token = "0x20000D3")]
		public class VoiceLevelDetectCalibrate<T> : LocalVoiceFramed<T>.IProcessor, IDisposable
		{
			[Token(Token = "0x40006C1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x982D28", Offset = "0x982D28")]
			private ILevelMeter <Level>k__BackingField;

			[Token(Token = "0x40006C2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x982D38", Offset = "0x982D38")]
			private IVoiceDetector <Detector>k__BackingField;

			[Token(Token = "0x40006C3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private VoiceDetectorCalibration<T> c;

			[Token(Token = "0x1700018C")]
			public ILevelMeter Level
			{
				[Token(Token = "0x60006B9")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x984318", Offset = "0x984318")]
				get
				{
					return null;
				}
				[Token(Token = "0x60006BA")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x984328", Offset = "0x984328")]
				private set
				{
				}
			}

			[Token(Token = "0x1700018D")]
			public IVoiceDetector Detector
			{
				[Token(Token = "0x60006BB")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x984338", Offset = "0x984338")]
				get
				{
					return null;
				}
				[Token(Token = "0x60006BC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x984348", Offset = "0x984348")]
				private set
				{
				}
			}

			[Token(Token = "0x60006BD")]
			public VoiceLevelDetectCalibrate(int samplingRate, int channels)
			{
			}

			[Token(Token = "0x60006BE")]
			public void Calibrate(int durationMs)
			{
			}

			[Token(Token = "0x60006BF")]
			public T[] Process(T[] buf)
			{
				return null;
			}

			[Token(Token = "0x60006C0")]
			public void Dispose()
			{
			}
		}

		[Token(Token = "0x600008A")]
		public static void Resample<T>(T[] src, T[] dst, int dstCount, int channels)
		{
		}

		[Token(Token = "0x600008B")]
		[Address(RVA = "0xE6971C", Offset = "0xE6971C", VA = "0xE6971C")]
		public static void ResampleAndConvert(short[] src, float[] dst, int dstCount, int channels)
		{
		}

		[Token(Token = "0x600008C")]
		[Address(RVA = "0xE69910", Offset = "0xE69910", VA = "0xE69910")]
		public static void ResampleAndConvert(float[] src, short[] dst, int dstCount, int channels)
		{
		}

		[Token(Token = "0x600008D")]
		[Address(RVA = "0xE69B5C", Offset = "0xE69B5C", VA = "0xE69B5C")]
		public static void Convert(float[] src, short[] dst, int dstCount)
		{
		}

		[Token(Token = "0x600008E")]
		[Address(RVA = "0xE69BF0", Offset = "0xE69BF0", VA = "0xE69BF0")]
		public static void Convert(short[] src, float[] dst, int dstCount)
		{
		}

		[Token(Token = "0x600008F")]
		public static void ForceToStereo<T>(T[] src, T[] dst, int srcChannels)
		{
		}

		[Token(Token = "0x6000090")]
		internal static string tostr<T>(T[] x, int lim = 10)
		{
			return null;
		}
	}
	[Token(Token = "0x200001F")]
	public interface IAudioOut
	{
		[Token(Token = "0x17000024")]
		bool IsPlaying
		{
			[Token(Token = "0x6000091")]
			get;
		}

		[Token(Token = "0x17000025")]
		int CurrentBufferLag
		{
			[Token(Token = "0x6000096")]
			get;
		}

		[Token(Token = "0x6000092")]
		void Start(int frequency, int channels, int frameSamplesPerChannel, int playDelayMs);

		[Token(Token = "0x6000093")]
		void Stop();

		[Token(Token = "0x6000094")]
		void OnAudioFrame(float[] frame);

		[Token(Token = "0x6000095")]
		void Service();
	}
	[Token(Token = "0x2000020")]
	public abstract class ObjectPool<TType, TInfo> : IDisposable
	{
		[Token(Token = "0x40000AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		protected int capacity;

		[Token(Token = "0x40000AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		protected TInfo info;

		[Token(Token = "0x40000AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private TType[] freeObj;

		[Token(Token = "0x40000AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		protected int pos;

		[Token(Token = "0x40000B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		protected string name;

		[Token(Token = "0x40000B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private bool inited;

		[Token(Token = "0x17000026")]
		internal string LogPrefix
		{
			[Token(Token = "0x600009A")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000027")]
		public TInfo Info
		{
			[Token(Token = "0x600009E")]
			get
			{
				return (TInfo)null;
			}
		}

		[Token(Token = "0x6000097")]
		protected abstract TType createObject(TInfo info);

		[Token(Token = "0x6000098")]
		protected abstract void destroyObject(TType obj);

		[Token(Token = "0x6000099")]
		protected abstract bool infosMatch(TInfo i0, TInfo i1);

		[Token(Token = "0x600009B")]
		public ObjectPool(int capacity, string name)
		{
		}

		[Token(Token = "0x600009C")]
		public ObjectPool(int capacity, string name, TInfo info)
		{
		}

		[Token(Token = "0x600009D")]
		public void Init(TInfo info)
		{
		}

		[Token(Token = "0x600009F")]
		public TType AcquireOrCreate()
		{
			return (TType)null;
		}

		[Token(Token = "0x60000A0")]
		public TType AcquireOrCreate(TInfo info)
		{
			return (TType)null;
		}

		[Token(Token = "0x60000A1")]
		public virtual bool Release(TType obj, TInfo objInfo)
		{
			return default(bool);
		}

		[Token(Token = "0x60000A2")]
		public virtual bool Release(TType obj)
		{
			return default(bool);
		}

		[Token(Token = "0x60000A3")]
		public void Dispose()
		{
		}
	}
	[Token(Token = "0x2000021")]
	public class PrimitiveArrayPool<T> : ObjectPool<T[], int>
	{
		[Token(Token = "0x60000A4")]
		public PrimitiveArrayPool(int capacity, string name)
		{
		}

		[Token(Token = "0x60000A5")]
		public PrimitiveArrayPool(int capacity, string name, int info)
		{
		}

		[Token(Token = "0x60000A6")]
		protected override T[] createObject(int info)
		{
			return null;
		}

		[Token(Token = "0x60000A7")]
		protected override void destroyObject(T[] obj)
		{
		}

		[Token(Token = "0x60000A8")]
		protected override bool infosMatch(int i0, int i1)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x2000022")]
	public class ImageBufferNativePool<T> : ObjectPool<T, ImageBufferInfo> where T : ImageBufferNative
	{
		[Token(Token = "0x20000D4")]
		public delegate T Factory(ImageBufferNativePool<T> pool, ImageBufferInfo info);

		[Token(Token = "0x40000B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Factory factory;

		[Token(Token = "0x60000A9")]
		public ImageBufferNativePool(int capacity, Factory factory, string name)
		{
		}

		[Token(Token = "0x60000AA")]
		public ImageBufferNativePool(int capacity, Factory factory, string name, ImageBufferInfo info)
		{
		}

		[Token(Token = "0x60000AB")]
		protected override T createObject(ImageBufferInfo info)
		{
			return null;
		}

		[Token(Token = "0x60000AC")]
		protected override void destroyObject(T obj)
		{
		}

		[Token(Token = "0x60000AD")]
		protected override bool infosMatch(ImageBufferInfo i0, ImageBufferInfo i1)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x2000023")]
	public class OpusCodec
	{
		[Token(Token = "0x20000D5")]
		public enum FrameDuration
		{
			[Token(Token = "0x40006C5")]
			Frame2dot5ms = 2500,
			[Token(Token = "0x40006C6")]
			Frame5ms = 5000,
			[Token(Token = "0x40006C7")]
			Frame10ms = 10000,
			[Token(Token = "0x40006C8")]
			Frame20ms = 20000,
			[Token(Token = "0x40006C9")]
			Frame40ms = 40000,
			[Token(Token = "0x40006CA")]
			Frame60ms = 60000
		}

		[Token(Token = "0x20000D6")]
		public static class EncoderFactory
		{
			[Token(Token = "0x60006C5")]
			[Address(RVA = "0xE6F638", Offset = "0xE6F638", VA = "0xE6F638")]
			public static IEncoder Create(VoiceInfo i, LocalVoice localVoice)
			{
				return null;
			}
		}

		[Token(Token = "0x20000D7")]
		public abstract class Encoder<T> : IEncoderDataFlowDirect<T>, IEncoderDataFlow<T>, IEncoder, IDisposable
		{
			[Token(Token = "0x40006CB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			protected OpusEncoder encoder;

			[Token(Token = "0x40006CC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			protected bool disposed;

			[Token(Token = "0x60006C6")]
			protected Encoder(VoiceInfo i)
			{
			}

			[Token(Token = "0x60006C7")]
			public void Dispose()
			{
			}

			[Token(Token = "0x60006C8")]
			public abstract ArraySegment<byte> EncodeAndGetOutput(T[] buf);
		}

		[Token(Token = "0x20000D8")]
		public class EncoderFloat : Encoder<float>
		{
			[Token(Token = "0x40006CD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static readonly ArraySegment<byte> EmptyBuffer;

			[Token(Token = "0x60006C9")]
			[Address(RVA = "0xE6F7EC", Offset = "0xE6F7EC", VA = "0xE6F7EC")]
			internal EncoderFloat(VoiceInfo i)
			{
			}

			[Token(Token = "0x60006CA")]
			[Address(RVA = "0xE6FAB4", Offset = "0xE6FAB4", VA = "0xE6FAB4", Slot = "6")]
			public override ArraySegment<byte> EncodeAndGetOutput(float[] buf)
			{
				return default(ArraySegment<byte>);
			}
		}

		[Token(Token = "0x20000D9")]
		public class EncoderShort : Encoder<short>
		{
			[Token(Token = "0x40006CE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static readonly ArraySegment<byte> EmptyBuffer;

			[Token(Token = "0x60006CC")]
			[Address(RVA = "0xE6F874", Offset = "0xE6F874", VA = "0xE6F874")]
			internal EncoderShort(VoiceInfo i)
			{
			}

			[Token(Token = "0x60006CD")]
			[Address(RVA = "0xE6FC64", Offset = "0xE6FC64", VA = "0xE6FC64", Slot = "6")]
			public override ArraySegment<byte> EncodeAndGetOutput(short[] buf)
			{
				return default(ArraySegment<byte>);
			}
		}

		[Token(Token = "0x20000DA")]
		public class Decoder : IDecoderDirect, IDecoder, IDisposable
		{
			[Token(Token = "0x40006CF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private OpusDecoder decoder;

			[Token(Token = "0x60006CF")]
			[Address(RVA = "0xE6F500", Offset = "0xE6F500", VA = "0xE6F500", Slot = "7")]
			public void Open(VoiceInfo i)
			{
			}

			[Token(Token = "0x60006D0")]
			[Address(RVA = "0xE6F57C", Offset = "0xE6F57C", VA = "0xE6F57C", Slot = "4")]
			public byte[] DecodeToByte(byte[] buf)
			{
				return null;
			}

			[Token(Token = "0x60006D1")]
			[Address(RVA = "0xE6F5DC", Offset = "0xE6F5DC", VA = "0xE6F5DC", Slot = "5")]
			public float[] DecodeToFloat(byte[] buf)
			{
				return null;
			}

			[Token(Token = "0x60006D2")]
			[Address(RVA = "0xE6F5F8", Offset = "0xE6F5F8", VA = "0xE6F5F8", Slot = "6")]
			public short[] DecodeToShort(byte[] buf)
			{
				return null;
			}

			[Token(Token = "0x60006D3")]
			[Address(RVA = "0xE6F614", Offset = "0xE6F614", VA = "0xE6F614", Slot = "8")]
			public void Dispose()
			{
			}

			[Token(Token = "0x60006D4")]
			[Address(RVA = "0xE6F630", Offset = "0xE6F630", VA = "0xE6F630")]
			public Decoder()
			{
			}
		}

		[Token(Token = "0x20000DB")]
		public class Util
		{
			[Token(Token = "0x60006D5")]
			[Address(RVA = "0xE6FE14", Offset = "0xE6FE14", VA = "0xE6FE14")]
			internal static int bestEncoderSampleRate(int f)
			{
				return default(int);
			}

			[Token(Token = "0x60006D6")]
			[Address(RVA = "0xE70144", Offset = "0xE70144", VA = "0xE70144")]
			public Util()
			{
			}
		}

		[Token(Token = "0x60000AE")]
		[Address(RVA = "0xE6F4F8", Offset = "0xE6F4F8", VA = "0xE6F4F8")]
		public OpusCodec()
		{
		}
	}
	[Token(Token = "0x2000024")]
	public interface IDataReader<T> : IDisposable
	{
		[Token(Token = "0x60000AF")]
		bool Read(T[] buffer);
	}
	[Token(Token = "0x2000025")]
	public interface IServiceable
	{
		[Token(Token = "0x60000B0")]
		void Service(LocalVoice localVoice);
	}
	[Token(Token = "0x2000026")]
	public class LocalVoice : IDisposable
	{
		[Token(Token = "0x40000B3")]
		public const int DATA_POOL_CAPACITY = 50;

		[Token(Token = "0x40000B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x98194C", Offset = "0x98194C")]
		private byte <Group>k__BackingField;

		[Token(Token = "0x40000B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x98195C", Offset = "0x98195C")]
		private bool <Transmit>k__BackingField;

		[Token(Token = "0x40000B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x12")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x98196C", Offset = "0x98196C")]
		private bool <IsTransmitting>k__BackingField;

		[Token(Token = "0x40000B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x98197C", Offset = "0x98197C")]
		private int <FramesSent>k__BackingField;

		[Token(Token = "0x40000B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x98198C", Offset = "0x98198C")]
		private int <FramesSentBytes>k__BackingField;

		[Token(Token = "0x40000B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x98199C", Offset = "0x98199C")]
		private bool <Reliable>k__BackingField;

		[Token(Token = "0x40000BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9819AC", Offset = "0x9819AC")]
		private bool <Encrypt>k__BackingField;

		[Token(Token = "0x40000BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9819BC", Offset = "0x9819BC")]
		private object <LocalUserObject>k__BackingField;

		[Token(Token = "0x40000BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9819CC", Offset = "0x9819CC")]
		private IServiceable <LocalUserServiceable>k__BackingField;

		[Token(Token = "0x40000BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private bool debugEchoMode;

		[Token(Token = "0x40000BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		internal VoiceInfo info;

		[Token(Token = "0x40000BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		protected IEncoder encoder;

		[Token(Token = "0x40000C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		internal byte id;

		[Token(Token = "0x40000C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		internal int channelId;

		[Token(Token = "0x40000C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		internal byte evNumber;

		[Token(Token = "0x40000C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		protected VoiceClient voiceClient;

		[Token(Token = "0x40000C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		protected bool disposed;

		[Token(Token = "0x40000C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		protected object disposeLock;

		[Token(Token = "0x40000C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private int noTransmitCnt;

		[Token(Token = "0x40000C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		internal Dictionary<byte, int> eventTimestamps;

		[Token(Token = "0x17000028")]
		public byte Group
		{
			[Token(Token = "0x60000B1")]
			[Address(RVA = "0xE6DD38", Offset = "0xE6DD38", VA = "0xE6DD38")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x982DA8", Offset = "0x982DA8")]
			get
			{
				return default(byte);
			}
			[Token(Token = "0x60000B2")]
			[Address(RVA = "0xE6DD40", Offset = "0xE6DD40", VA = "0xE6DD40")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x982DB8", Offset = "0x982DB8")]
			set
			{
			}
		}

		[Token(Token = "0x17000029")]
		public VoiceInfo Info
		{
			[Token(Token = "0x60000B3")]
			[Address(RVA = "0xE6DD48", Offset = "0xE6DD48", VA = "0xE6DD48")]
			get
			{
				return default(VoiceInfo);
			}
		}

		[Token(Token = "0x1700002A")]
		public bool Transmit
		{
			[Token(Token = "0x60000B4")]
			[Address(RVA = "0xE6DD60", Offset = "0xE6DD60", VA = "0xE6DD60")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x982DC8", Offset = "0x982DC8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60000B5")]
			[Address(RVA = "0xE6DD68", Offset = "0xE6DD68", VA = "0xE6DD68")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x982DD8", Offset = "0x982DD8")]
			set
			{
			}
		}

		[Token(Token = "0x1700002B")]
		public bool IsTransmitting
		{
			[Token(Token = "0x60000B6")]
			[Address(RVA = "0xE6DD74", Offset = "0xE6DD74", VA = "0xE6DD74")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x982DE8", Offset = "0x982DE8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60000B7")]
			[Address(RVA = "0xE6DD7C", Offset = "0xE6DD7C", VA = "0xE6DD7C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x982DF8", Offset = "0x982DF8")]
			protected set
			{
			}
		}

		[Token(Token = "0x1700002C")]
		public int FramesSent
		{
			[Token(Token = "0x60000B8")]
			[Address(RVA = "0xE6DD88", Offset = "0xE6DD88", VA = "0xE6DD88")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x982E08", Offset = "0x982E08")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60000B9")]
			[Address(RVA = "0xE6DD90", Offset = "0xE6DD90", VA = "0xE6DD90")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x982E18", Offset = "0x982E18")]
			private set
			{
			}
		}

		[Token(Token = "0x1700002D")]
		public int FramesSentBytes
		{
			[Token(Token = "0x60000BA")]
			[Address(RVA = "0xE6DD98", Offset = "0xE6DD98", VA = "0xE6DD98")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x982E28", Offset = "0x982E28")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60000BB")]
			[Address(RVA = "0xE6DDA0", Offset = "0xE6DDA0", VA = "0xE6DDA0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x982E38", Offset = "0x982E38")]
			private set
			{
			}
		}

		[Token(Token = "0x1700002E")]
		public bool Reliable
		{
			[Token(Token = "0x60000BC")]
			[Address(RVA = "0xE6DDA8", Offset = "0xE6DDA8", VA = "0xE6DDA8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x982E48", Offset = "0x982E48")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60000BD")]
			[Address(RVA = "0xE6DDB0", Offset = "0xE6DDB0", VA = "0xE6DDB0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x982E58", Offset = "0x982E58")]
			set
			{
			}
		}

		[Token(Token = "0x1700002F")]
		public bool Encrypt
		{
			[Token(Token = "0x60000BE")]
			[Address(RVA = "0xE6DDBC", Offset = "0xE6DDBC", VA = "0xE6DDBC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x982E68", Offset = "0x982E68")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60000BF")]
			[Address(RVA = "0xE6DDC4", Offset = "0xE6DDC4", VA = "0xE6DDC4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x982E78", Offset = "0x982E78")]
			set
			{
			}
		}

		[Token(Token = "0x17000030")]
		public object LocalUserObject
		{
			[Token(Token = "0x60000C0")]
			[Address(RVA = "0xE6DDD0", Offset = "0xE6DDD0", VA = "0xE6DDD0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x982E88", Offset = "0x982E88")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000C1")]
			[Address(RVA = "0xE6DDD8", Offset = "0xE6DDD8", VA = "0xE6DDD8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x982E98", Offset = "0x982E98")]
			set
			{
			}
		}

		[Token(Token = "0x17000031")]
		public IServiceable LocalUserServiceable
		{
			[Token(Token = "0x60000C2")]
			[Address(RVA = "0xE6DDE0", Offset = "0xE6DDE0", VA = "0xE6DDE0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x982EA8", Offset = "0x982EA8")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000C3")]
			[Address(RVA = "0xE6DDE8", Offset = "0xE6DDE8", VA = "0xE6DDE8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x982EB8", Offset = "0x982EB8")]
			set
			{
			}
		}

		[Token(Token = "0x17000032")]
		public bool DebugEchoMode
		{
			[Token(Token = "0x60000C4")]
			[Address(RVA = "0xE6DDF0", Offset = "0xE6DDF0", VA = "0xE6DDF0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60000C5")]
			[Address(RVA = "0xE6DDF8", Offset = "0xE6DDF8", VA = "0xE6DDF8")]
			set
			{
			}
		}

		[Token(Token = "0x17000033")]
		internal string Name
		{
			[Token(Token = "0x60000C8")]
			[Address(RVA = "0xE6E068", Offset = "0xE6E068", VA = "0xE6E068")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000034")]
		internal string LogPrefix
		{
			[Token(Token = "0x60000C9")]
			[Address(RVA = "0xE6E3CC", Offset = "0xE6E3CC", VA = "0xE6E3CC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60000C6")]
		[Address(RVA = "0xE6DEEC", Offset = "0xE6DEEC", VA = "0xE6DEEC")]
		internal LocalVoice()
		{
		}

		[Token(Token = "0x60000C7")]
		[Address(RVA = "0xE6DF7C", Offset = "0xE6DF7C", VA = "0xE6DF7C")]
		internal LocalVoice(VoiceClient voiceClient, IEncoder encoder, byte id, VoiceInfo voiceInfo, int channelId)
		{
		}

		[Token(Token = "0x60000CA")]
		[Address(RVA = "0xE6E42C", Offset = "0xE6E42C", VA = "0xE6E42C")]
		protected void resetNoTransmitCnt()
		{
		}

		[Token(Token = "0x60000CB")]
		[Address(RVA = "0xE6E438", Offset = "0xE6E438", VA = "0xE6E438", Slot = "5")]
		internal virtual void service()
		{
		}

		[Token(Token = "0x60000CC")]
		[Address(RVA = "0xE6E890", Offset = "0xE6E890", VA = "0xE6E890")]
		internal void sendFrame(ArraySegment<byte> compressed)
		{
		}

		[Token(Token = "0x60000CD")]
		[Address(RVA = "0xE6E9EC", Offset = "0xE6E9EC", VA = "0xE6E9EC")]
		public void RemoveSelf()
		{
		}

		[Token(Token = "0x60000CE")]
		[Address(RVA = "0xE6ECE4", Offset = "0xE6ECE4", VA = "0xE6ECE4", Slot = "6")]
		public virtual void Dispose()
		{
		}
	}
	[Token(Token = "0x2000027")]
	public struct RemoteVoiceOptions
	{
		[Token(Token = "0x40000C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9819DC", Offset = "0x9819DC")]
		private Action<byte[]> <OnDecodedFrameByteAction>k__BackingField;

		[Token(Token = "0x40000C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9819EC", Offset = "0x9819EC")]
		private Action<float[]> <OnDecodedFrameFloatAction>k__BackingField;

		[Token(Token = "0x40000CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9819FC", Offset = "0x9819FC")]
		private Action<short[]> <OnDecodedFrameShortAction>k__BackingField;

		[Token(Token = "0x40000CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x981A0C", Offset = "0x981A0C")]
		private Action <OnRemoteVoiceRemoveAction>k__BackingField;

		[Token(Token = "0x40000CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x981A1C", Offset = "0x981A1C")]
		private object <LocalUserObject>k__BackingField;

		[Token(Token = "0x40000CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x981A2C", Offset = "0x981A2C")]
		private IDecoder <Decoder>k__BackingField;

		[Token(Token = "0x17000035")]
		public Action<byte[]> OnDecodedFrameByteAction
		{
			[Token(Token = "0x60000CF")]
			[Address(RVA = "0xE72364", Offset = "0xE72364", VA = "0xE72364")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x982EC8", Offset = "0x982EC8")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000D0")]
			[Address(RVA = "0xE7236C", Offset = "0xE7236C", VA = "0xE7236C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x982ED8", Offset = "0x982ED8")]
			set
			{
			}
		}

		[Token(Token = "0x17000036")]
		public Action<float[]> OnDecodedFrameFloatAction
		{
			[Token(Token = "0x60000D1")]
			[Address(RVA = "0xE72374", Offset = "0xE72374", VA = "0xE72374")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x982EE8", Offset = "0x982EE8")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000D2")]
			[Address(RVA = "0xE7237C", Offset = "0xE7237C", VA = "0xE7237C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x982EF8", Offset = "0x982EF8")]
			set
			{
			}
		}

		[Token(Token = "0x17000037")]
		public Action<short[]> OnDecodedFrameShortAction
		{
			[Token(Token = "0x60000D3")]
			[Address(RVA = "0xE72384", Offset = "0xE72384", VA = "0xE72384")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x982F08", Offset = "0x982F08")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000D4")]
			[Address(RVA = "0xE7238C", Offset = "0xE7238C", VA = "0xE7238C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x982F18", Offset = "0x982F18")]
			set
			{
			}
		}

		[Token(Token = "0x17000038")]
		public Action OnRemoteVoiceRemoveAction
		{
			[Token(Token = "0x60000D5")]
			[Address(RVA = "0xE72394", Offset = "0xE72394", VA = "0xE72394")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x982F28", Offset = "0x982F28")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000D6")]
			[Address(RVA = "0xE7239C", Offset = "0xE7239C", VA = "0xE7239C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x982F38", Offset = "0x982F38")]
			set
			{
			}
		}

		[Token(Token = "0x17000039")]
		public object LocalUserObject
		{
			[Token(Token = "0x60000D7")]
			[Address(RVA = "0xE723A4", Offset = "0xE723A4", VA = "0xE723A4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x982F48", Offset = "0x982F48")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000D8")]
			[Address(RVA = "0xE723AC", Offset = "0xE723AC", VA = "0xE723AC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x982F58", Offset = "0x982F58")]
			set
			{
			}
		}

		[Token(Token = "0x1700003A")]
		public IDecoder Decoder
		{
			[Token(Token = "0x60000D9")]
			[Address(RVA = "0xE723B4", Offset = "0xE723B4", VA = "0xE723B4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x982F68", Offset = "0x982F68")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000DA")]
			[Address(RVA = "0xE723BC", Offset = "0xE723BC", VA = "0xE723BC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x982F78", Offset = "0x982F78")]
			set
			{
			}
		}
	}
	[Token(Token = "0x2000028")]
	internal class RemoteVoice : IDisposable
	{
		[Token(Token = "0x40000CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x981A3C", Offset = "0x981A3C")]
		private VoiceInfo <Info>k__BackingField;

		[Token(Token = "0x40000CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		internal RemoteVoiceOptions options;

		[Token(Token = "0x40000D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private int channelId;

		[Token(Token = "0x40000D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private int playerId;

		[Token(Token = "0x40000D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private byte voiceId;

		[Token(Token = "0x40000D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x71")]
		private bool disposed;

		[Token(Token = "0x40000D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private object disposeLock;

		[Token(Token = "0x40000D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		internal byte lastEvNumber;

		[Token(Token = "0x40000D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private VoiceClient voiceClient;

		[Token(Token = "0x40000D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Queue<byte[]> frameQueue;

		[Token(Token = "0x40000D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private AutoResetEvent frameQueueReady;

		[Token(Token = "0x1700003B")]
		internal VoiceInfo Info
		{
			[Token(Token = "0x60000DB")]
			[Address(RVA = "0xE7014C", Offset = "0xE7014C", VA = "0xE7014C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x982F88", Offset = "0x982F88")]
			get
			{
				return default(VoiceInfo);
			}
			[Token(Token = "0x60000DC")]
			[Address(RVA = "0xE70160", Offset = "0xE70160", VA = "0xE70160")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x982F98", Offset = "0x982F98")]
			private set
			{
			}
		}

		[Token(Token = "0x1700003C")]
		protected string Name
		{
			[Token(Token = "0x60000DE")]
			[Address(RVA = "0xE704DC", Offset = "0xE704DC", VA = "0xE704DC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700003D")]
		protected string LogPrefix
		{
			[Token(Token = "0x60000DF")]
			[Address(RVA = "0xE7047C", Offset = "0xE7047C", VA = "0xE7047C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60000DD")]
		[Address(RVA = "0xE70174", Offset = "0xE70174", VA = "0xE70174")]
		internal RemoteVoice(VoiceClient client, RemoteVoiceOptions options, int channelId, int playerId, byte voiceId, VoiceInfo info, byte lastEventNumber)
		{
		}

		[Token(Token = "0x60000E0")]
		[Address(RVA = "0xE706CC", Offset = "0xE706CC", VA = "0xE706CC")]
		private static byte byteDiff(byte latest, byte last)
		{
			return default(byte);
		}

		[Token(Token = "0x60000E1")]
		[Address(RVA = "0xE706D8", Offset = "0xE706D8", VA = "0xE706D8")]
		internal void receiveBytes(byte[] receivedBytes, byte evNumber)
		{
		}

		[Token(Token = "0x60000E2")]
		[Address(RVA = "0xE70CC8", Offset = "0xE70CC8", VA = "0xE70CC8")]
		private void receiveFrame(byte[] frame)
		{
		}

		[Token(Token = "0x60000E3")]
		[Address(RVA = "0xE70AF0", Offset = "0xE70AF0", VA = "0xE70AF0")]
		private void receiveNullFrames(int count)
		{
		}

		[Token(Token = "0x60000E4")]
		[Address(RVA = "0xE70E80", Offset = "0xE70E80", VA = "0xE70E80")]
		private void decodeThread(IDecoder decoder)
		{
		}

		[Token(Token = "0x60000E5")]
		[Address(RVA = "0xE71710", Offset = "0xE71710", VA = "0xE71710")]
		private void decodeFrame(IDecoder decoder, byte[] frame)
		{
		}

		[Token(Token = "0x60000E6")]
		[Address(RVA = "0xE718E4", Offset = "0xE718E4", VA = "0xE718E4")]
		internal byte[] decodeFrameToByte(byte[] buffer)
		{
			return null;
		}

		[Token(Token = "0x60000E7")]
		[Address(RVA = "0xE71BC8", Offset = "0xE71BC8", VA = "0xE71BC8")]
		internal short[] decodeFrameToShort(byte[] buffer)
		{
			return null;
		}

		[Token(Token = "0x60000E8")]
		[Address(RVA = "0xE71EB4", Offset = "0xE71EB4", VA = "0xE71EB4")]
		internal float[] decodeFrameToFloat(byte[] buffer)
		{
			return null;
		}

		[Token(Token = "0x60000E9")]
		[Address(RVA = "0xE721A0", Offset = "0xE721A0", VA = "0xE721A0")]
		internal void removeAndDispose()
		{
		}

		[Token(Token = "0x60000EA")]
		[Address(RVA = "0xE721D0", Offset = "0xE721D0", VA = "0xE721D0", Slot = "4")]
		public void Dispose()
		{
		}

		[Token(Token = "0x60000EB")]
		[Address(RVA = "0xE72290", Offset = "0xE72290", VA = "0xE72290")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x982FA8", Offset = "0x982FA8")]
		private void <.ctor>b__10_0()
		{
		}
	}
	[Token(Token = "0x2000029")]
	public interface IAudioSource : IDisposable
	{
		[Token(Token = "0x1700003E")]
		int SamplingRate
		{
			[Token(Token = "0x60000EC")]
			get;
		}

		[Token(Token = "0x1700003F")]
		int Channels
		{
			[Token(Token = "0x60000ED")]
			get;
		}
	}
	[Token(Token = "0x200002A")]
	public interface IAudioReader<T> : IDataReader<T>, IDisposable, IAudioSource
	{
	}
	[Token(Token = "0x200002B")]
	public interface IAudioPusher<T> : IAudioSource, IDisposable
	{
		[Token(Token = "0x60000EE")]
		void SetCallback(Action<T[]> callback, LocalVoice localVoice);
	}
	[Token(Token = "0x200002C")]
	public interface ILocalVoiceAudio
	{
		[Token(Token = "0x17000040")]
		AudioUtil.IVoiceDetector VoiceDetector
		{
			[Token(Token = "0x60000EF")]
			get;
		}

		[Token(Token = "0x17000041")]
		AudioUtil.ILevelMeter LevelMeter
		{
			[Token(Token = "0x60000F0")]
			get;
		}

		[Token(Token = "0x17000042")]
		bool VoiceDetectorCalibrating
		{
			[Token(Token = "0x60000F1")]
			get;
		}

		[Token(Token = "0x60000F2")]
		void VoiceDetectorCalibrate(int durationMs);
	}
	[Token(Token = "0x200002D")]
	public static class LocalVoiceAudio
	{
		[Token(Token = "0x40000D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static LocalVoiceAudioDummy Dummy;

		[Token(Token = "0x60000F3")]
		public static LocalVoiceAudio<T> Create<T>(VoiceClient voiceClient, byte voiceId, IEncoder encoder, VoiceInfo voiceInfo, int channelId)
		{
			return null;
		}
	}
	[Token(Token = "0x200002E")]
	public abstract class LocalVoiceAudio<T> : LocalVoiceFramed<T>, ILocalVoiceAudio
	{
		[Token(Token = "0x40000DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		protected AudioUtil.VoiceDetector<T> voiceDetector;

		[Token(Token = "0x40000DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		protected AudioUtil.VoiceDetectorCalibration<T> voiceDetectorCalibration;

		[Token(Token = "0x40000DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		protected AudioUtil.LevelMeter<T> levelMeter;

		[Token(Token = "0x40000DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		protected int channels;

		[Token(Token = "0x40000DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		protected int sourceSamplingRateHz;

		[Token(Token = "0x40000DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		protected bool resampleSource;

		[Token(Token = "0x17000043")]
		public virtual AudioUtil.IVoiceDetector VoiceDetector
		{
			[Token(Token = "0x60000F5")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000044")]
		public virtual AudioUtil.ILevelMeter LevelMeter
		{
			[Token(Token = "0x60000F6")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000045")]
		public bool VoiceDetectorCalibrating
		{
			[Token(Token = "0x60000F8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60000F7")]
		public void VoiceDetectorCalibrate(int durationMs)
		{
		}

		[Token(Token = "0x60000F9")]
		internal LocalVoiceAudio(VoiceClient voiceClient, IEncoderDataFlow<T> encoder, byte id, VoiceInfo voiceInfo, int channelId)
		{
		}

		[Token(Token = "0x60000FA")]
		protected void initBuiltinProcessors()
		{
		}
	}
	[Token(Token = "0x200002F")]
	public class LocalVoiceAudioDummy : LocalVoice, ILocalVoiceAudio
	{
		[Token(Token = "0x40000E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private AudioUtil.VoiceDetectorDummy voiceDetector;

		[Token(Token = "0x40000E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private AudioUtil.LevelMetterDummy levelMeter;

		[Token(Token = "0x17000046")]
		public AudioUtil.IVoiceDetector VoiceDetector
		{
			[Token(Token = "0x60000FB")]
			[Address(RVA = "0xE6EE9C", Offset = "0xE6EE9C", VA = "0xE6EE9C", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000047")]
		public AudioUtil.ILevelMeter LevelMeter
		{
			[Token(Token = "0x60000FC")]
			[Address(RVA = "0xE6EEA4", Offset = "0xE6EEA4", VA = "0xE6EEA4", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000048")]
		public bool VoiceDetectorCalibrating
		{
			[Token(Token = "0x60000FD")]
			[Address(RVA = "0xE6EEAC", Offset = "0xE6EEAC", VA = "0xE6EEAC", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60000FE")]
		[Address(RVA = "0xE6EEB4", Offset = "0xE6EEB4", VA = "0xE6EEB4", Slot = "10")]
		public void VoiceDetectorCalibrate(int durationMs)
		{
		}

		[Token(Token = "0x60000FF")]
		[Address(RVA = "0xE6EE14", Offset = "0xE6EE14", VA = "0xE6EE14")]
		public LocalVoiceAudioDummy()
		{
		}
	}
	[Token(Token = "0x2000030")]
	public class LocalVoiceAudioFloat : LocalVoiceAudio<float>
	{
		[Token(Token = "0x6000100")]
		[Address(RVA = "0xE6EEB8", Offset = "0xE6EEB8", VA = "0xE6EEB8")]
		internal LocalVoiceAudioFloat(VoiceClient voiceClient, IEncoderDataFlow<float> encoder, byte id, VoiceInfo voiceInfo, int channelId)
		{
		}
	}
	[Token(Token = "0x2000031")]
	public class LocalVoiceAudioShort : LocalVoiceAudio<short>
	{
		[Token(Token = "0x6000101")]
		[Address(RVA = "0xE6EFDC", Offset = "0xE6EFDC", VA = "0xE6EFDC")]
		internal LocalVoiceAudioShort(VoiceClient voiceClient, IEncoderDataFlow<short> encoder, byte id, VoiceInfo voiceInfo, int channelId)
		{
		}
	}
	[Token(Token = "0x2000032")]
	internal enum EventSubcode : byte
	{
		[Token(Token = "0x40000E3")]
		VoiceInfo = 1,
		[Token(Token = "0x40000E4")]
		VoiceRemove,
		[Token(Token = "0x40000E5")]
		Frame
	}
	[Token(Token = "0x2000033")]
	internal enum EventParam : byte
	{
		[Token(Token = "0x40000E7")]
		VoiceId = 1,
		[Token(Token = "0x40000E8")]
		SamplingRate = 2,
		[Token(Token = "0x40000E9")]
		Channels = 3,
		[Token(Token = "0x40000EA")]
		FrameDurationUs = 4,
		[Token(Token = "0x40000EB")]
		Bitrate = 5,
		[Token(Token = "0x40000EC")]
		UserData = 10,
		[Token(Token = "0x40000ED")]
		EventNumber = 11,
		[Token(Token = "0x40000EE")]
		Codec = 12
	}
	[Token(Token = "0x2000034")]
	public interface ILogger
	{
		[Token(Token = "0x6000102")]
		void LogError(string fmt, params object[] args);

		[Token(Token = "0x6000103")]
		void LogWarning(string fmt, params object[] args);

		[Token(Token = "0x6000104")]
		void LogInfo(string fmt, params object[] args);

		[Token(Token = "0x6000105")]
		void LogDebug(string fmt, params object[] args);
	}
	[Token(Token = "0x2000035")]
	internal interface IVoiceFrontend : ILogger
	{
		[Token(Token = "0x6000106")]
		int AssignChannel(VoiceInfo v);

		[Token(Token = "0x6000107")]
		bool IsChannelJoined(int channelId);

		[Token(Token = "0x6000108")]
		void SendVoicesInfo(IEnumerable<LocalVoice> voices, int channelId, int targetPlayerId);

		[Token(Token = "0x6000109")]
		void SendVoiceRemove(LocalVoice voice, int channelId, int targetPlayerId);

		[Token(Token = "0x600010A")]
		void SendFrame(ArraySegment<byte> data, byte evNumber, byte voiceId, int channelId, LocalVoice localVoice);

		[Token(Token = "0x600010B")]
		string ChannelIdStr(int channelId);

		[Token(Token = "0x600010C")]
		string PlayerIdStr(int playerId);

		[Token(Token = "0x600010D")]
		void SetDebugEchoMode(LocalVoice v);
	}
	[Token(Token = "0x2000036")]
	public class VoiceClient : IDisposable
	{
		[Token(Token = "0x20000DC")]
		public delegate void RemoteVoiceInfoDelegate(int channelId, int playerId, byte voiceId, VoiceInfo voiceInfo, ref RemoteVoiceOptions options);

		[Token(Token = "0x20000DD")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x981634", Offset = "0x981634")]
		private sealed class <get_RemoteVoiceInfos>d__39 : IEnumerable<RemoteVoiceInfo>, IEnumerable, IEnumerator<RemoteVoiceInfo>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40006D0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40006D1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private RemoteVoiceInfo <>2__current;

			[Token(Token = "0x40006D2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private int <>l__initialThreadId;

			[Token(Token = "0x40006D3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public VoiceClient <>4__this;

			[Token(Token = "0x40006D4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private Dictionary<int, Dictionary<int, Dictionary<byte, RemoteVoice>>>.Enumerator <>7__wrap1;

			[Token(Token = "0x40006D5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private KeyValuePair<int, Dictionary<int, Dictionary<byte, RemoteVoice>>> <channelVoices>5__3;

			[Token(Token = "0x40006D6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			private Dictionary<int, Dictionary<byte, RemoteVoice>>.Enumerator <>7__wrap3;

			[Token(Token = "0x40006D7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			private KeyValuePair<int, Dictionary<byte, RemoteVoice>> <playerVoices>5__5;

			[Token(Token = "0x40006D8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			private Dictionary<byte, RemoteVoice>.Enumerator <>7__wrap5;

			[Token(Token = "0x1700018E")]
			private RemoteVoiceInfo System.Collections.Generic.IEnumerator<ExitGames.Client.Photon.Voice.RemoteVoiceInfo>.Current
			{
				[Token(Token = "0x60006E1")]
				[Address(RVA = "0x17208B4", Offset = "0x17208B4", VA = "0x17208B4", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700018F")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60006E3")]
				[Address(RVA = "0x172091C", Offset = "0x172091C", VA = "0x172091C", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60006DB")]
			[Address(RVA = "0x17203DC", Offset = "0x17203DC", VA = "0x17203DC")]
			[DebuggerHidden]
			public <get_RemoteVoiceInfos>d__39(int <>1__state)
			{
			}

			[Token(Token = "0x60006DC")]
			[Address(RVA = "0x1720414", Offset = "0x1720414", VA = "0x1720414", Slot = "7")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60006DD")]
			[Address(RVA = "0x17205E4", Offset = "0x17205E4", VA = "0x17205E4", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60006DE")]
			[Address(RVA = "0x172058C", Offset = "0x172058C", VA = "0x172058C")]
			private void <>m__Finally1()
			{
			}

			[Token(Token = "0x60006DF")]
			[Address(RVA = "0x1720534", Offset = "0x1720534", VA = "0x1720534")]
			private void <>m__Finally2()
			{
			}

			[Token(Token = "0x60006E0")]
			[Address(RVA = "0x17204DC", Offset = "0x17204DC", VA = "0x17204DC")]
			private void <>m__Finally3()
			{
			}

			[Token(Token = "0x60006E2")]
			[Address(RVA = "0x17208BC", Offset = "0x17208BC", VA = "0x17208BC", Slot = "10")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}

			[Token(Token = "0x60006E4")]
			[Address(RVA = "0x1720924", Offset = "0x1720924", VA = "0x1720924", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<RemoteVoiceInfo> System.Collections.Generic.IEnumerable<ExitGames.Client.Photon.Voice.RemoteVoiceInfo>.GetEnumerator()
			{
				return null;
			}

			[Token(Token = "0x60006E5")]
			[Address(RVA = "0x17209D0", Offset = "0x17209D0", VA = "0x17209D0", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator System.Collections.IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Token(Token = "0x20000DE")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x981644", Offset = "0x981644")]
		private sealed class <get_RemoteVoiceLocalUserObjects>d__41 : IEnumerable<object>, IEnumerable, IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40006D9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40006DA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40006DB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private int <>l__initialThreadId;

			[Token(Token = "0x40006DC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public VoiceClient <>4__this;

			[Token(Token = "0x40006DD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private Dictionary<int, Dictionary<int, Dictionary<byte, RemoteVoice>>>.Enumerator <>7__wrap1;

			[Token(Token = "0x40006DE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private Dictionary<int, Dictionary<byte, RemoteVoice>>.Enumerator <>7__wrap2;

			[Token(Token = "0x40006DF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			private Dictionary<byte, RemoteVoice>.Enumerator <>7__wrap3;

			[Token(Token = "0x17000190")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60006EC")]
				[Address(RVA = "0x1720E38", Offset = "0x1720E38", VA = "0x1720E38", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000191")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60006EE")]
				[Address(RVA = "0x1720EA0", Offset = "0x1720EA0", VA = "0x1720EA0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60006E6")]
			[Address(RVA = "0x17209D4", Offset = "0x17209D4", VA = "0x17209D4")]
			[DebuggerHidden]
			public <get_RemoteVoiceLocalUserObjects>d__41(int <>1__state)
			{
			}

			[Token(Token = "0x60006E7")]
			[Address(RVA = "0x1720A0C", Offset = "0x1720A0C", VA = "0x1720A0C", Slot = "7")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60006E8")]
			[Address(RVA = "0x1720BDC", Offset = "0x1720BDC", VA = "0x1720BDC", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60006E9")]
			[Address(RVA = "0x1720B84", Offset = "0x1720B84", VA = "0x1720B84")]
			private void <>m__Finally1()
			{
			}

			[Token(Token = "0x60006EA")]
			[Address(RVA = "0x1720B2C", Offset = "0x1720B2C", VA = "0x1720B2C")]
			private void <>m__Finally2()
			{
			}

			[Token(Token = "0x60006EB")]
			[Address(RVA = "0x1720AD4", Offset = "0x1720AD4", VA = "0x1720AD4")]
			private void <>m__Finally3()
			{
			}

			[Token(Token = "0x60006ED")]
			[Address(RVA = "0x1720E40", Offset = "0x1720E40", VA = "0x1720E40", Slot = "10")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}

			[Token(Token = "0x60006EF")]
			[Address(RVA = "0x1720EA8", Offset = "0x1720EA8", VA = "0x1720EA8", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<object> System.Collections.Generic.IEnumerable<System.Object>.GetEnumerator()
			{
				return null;
			}

			[Token(Token = "0x60006F0")]
			[Address(RVA = "0x1720F54", Offset = "0x1720F54", VA = "0x1720F54", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator System.Collections.IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Token(Token = "0x20000DF")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x981654", Offset = "0x981654")]
		private sealed class <>c__DisplayClass46_0
		{
			[Token(Token = "0x40006E0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public VoiceClient <>4__this;

			[Token(Token = "0x40006E1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public IEncoder encoder;

			[Token(Token = "0x40006E2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public VoiceInfo voiceInfo;

			[Token(Token = "0x60006F1")]
			[Address(RVA = "0x172032C", Offset = "0x172032C", VA = "0x172032C")]
			public <>c__DisplayClass46_0()
			{
			}

			[Token(Token = "0x60006F2")]
			[Address(RVA = "0x1720334", Offset = "0x1720334", VA = "0x1720334")]
			internal LocalVoice <CreateLocalVoice>b__0(byte vId, int chId)
			{
				return null;
			}
		}

		[Token(Token = "0x20000E0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x981664", Offset = "0x981664")]
		private sealed class <>c__DisplayClass47_0<T>
		{
			[Token(Token = "0x40006E3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public VoiceClient <>4__this;

			[Token(Token = "0x40006E4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public IEncoderDataFlow<T> encoder;

			[Token(Token = "0x40006E5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public VoiceInfo voiceInfo;

			[Token(Token = "0x40006E6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int frameSize;

			[Token(Token = "0x60006F3")]
			public <>c__DisplayClass47_0()
			{
			}

			[Token(Token = "0x60006F4")]
			internal LocalVoice <CreateLocalVoiceFramed>b__0(byte vId, int chId)
			{
				return null;
			}
		}

		[Token(Token = "0x20000E1")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x981674", Offset = "0x981674")]
		private sealed class <>c__DisplayClass48_0<T>
		{
			[Token(Token = "0x40006E7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public VoiceClient <>4__this;

			[Token(Token = "0x40006E8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public IEncoderDataFlow<T> encoder;

			[Token(Token = "0x40006E9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public VoiceInfo voiceInfo;

			[Token(Token = "0x60006F5")]
			public <>c__DisplayClass48_0()
			{
			}

			[Token(Token = "0x60006F6")]
			internal LocalVoice <CreateLocalVoiceAudio>b__0(byte vId, int chId)
			{
				return null;
			}
		}

		[Token(Token = "0x40000EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		internal IVoiceFrontend frontend;

		[Token(Token = "0x40000F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x981A4C", Offset = "0x981A4C")]
		private int <FramesLost>k__BackingField;

		[Token(Token = "0x40000F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x981A5C", Offset = "0x981A5C")]
		private int <FramesReceived>k__BackingField;

		[Token(Token = "0x40000F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x981A6C", Offset = "0x981A6C")]
		private int <RoundTripTime>k__BackingField;

		[Token(Token = "0x40000F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x981A7C", Offset = "0x981A7C")]
		private int <RoundTripTimeVariance>k__BackingField;

		[Token(Token = "0x40000F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x981A8C", Offset = "0x981A8C")]
		private bool <SuppressInfoDuplicateWarning>k__BackingField;

		[Token(Token = "0x40000F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x981A9C", Offset = "0x981A9C")]
		private RemoteVoiceInfoDelegate <OnRemoteVoiceInfoAction>k__BackingField;

		[Token(Token = "0x40000F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x981AAC", Offset = "0x981AAC")]
		private int <DebugLostPercent>k__BackingField;

		[Token(Token = "0x40000F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private int prevRtt;

		[Token(Token = "0x40000F8")]
		public const int ChannelAuto = -1;

		[Token(Token = "0x40000F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private byte globalGroup;

		[Token(Token = "0x40000FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x41")]
		private byte voiceIdCnt;

		[Token(Token = "0x40000FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Dictionary<byte, LocalVoice> localVoices;

		[Token(Token = "0x40000FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Dictionary<int, List<LocalVoice>> localVoicesPerChannel;

		[Token(Token = "0x40000FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Dictionary<int, Dictionary<int, Dictionary<byte, RemoteVoice>>> remoteVoices;

		[Token(Token = "0x40000FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private System.Random rnd;

		[Token(Token = "0x17000049")]
		public int FramesLost
		{
			[Token(Token = "0x600010E")]
			[Address(RVA = "0xE7245C", Offset = "0xE7245C", VA = "0xE7245C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x982FB8", Offset = "0x982FB8")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600010F")]
			[Address(RVA = "0xE72464", Offset = "0xE72464", VA = "0xE72464")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x982FC8", Offset = "0x982FC8")]
			internal set
			{
			}
		}

		[Token(Token = "0x1700004A")]
		public int FramesReceived
		{
			[Token(Token = "0x6000110")]
			[Address(RVA = "0xE7246C", Offset = "0xE7246C", VA = "0xE7246C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x982FD8", Offset = "0x982FD8")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000111")]
			[Address(RVA = "0xE72474", Offset = "0xE72474", VA = "0xE72474")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x982FE8", Offset = "0x982FE8")]
			private set
			{
			}
		}

		[Token(Token = "0x1700004B")]
		public int FramesSent
		{
			[Token(Token = "0x6000112")]
			[Address(RVA = "0xE7247C", Offset = "0xE7247C", VA = "0xE7247C")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700004C")]
		public int FramesSentBytes
		{
			[Token(Token = "0x6000113")]
			[Address(RVA = "0xE72580", Offset = "0xE72580", VA = "0xE72580")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700004D")]
		public int RoundTripTime
		{
			[Token(Token = "0x6000114")]
			[Address(RVA = "0xE72684", Offset = "0xE72684", VA = "0xE72684")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x982FF8", Offset = "0x982FF8")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000115")]
			[Address(RVA = "0xE7268C", Offset = "0xE7268C", VA = "0xE7268C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x983008", Offset = "0x983008")]
			private set
			{
			}
		}

		[Token(Token = "0x1700004E")]
		public int RoundTripTimeVariance
		{
			[Token(Token = "0x6000116")]
			[Address(RVA = "0xE72694", Offset = "0xE72694", VA = "0xE72694")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x983018", Offset = "0x983018")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000117")]
			[Address(RVA = "0xE7269C", Offset = "0xE7269C", VA = "0xE7269C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x983028", Offset = "0x983028")]
			private set
			{
			}
		}

		[Token(Token = "0x1700004F")]
		public bool SuppressInfoDuplicateWarning
		{
			[Token(Token = "0x6000118")]
			[Address(RVA = "0xE726A4", Offset = "0xE726A4", VA = "0xE726A4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x983038", Offset = "0x983038")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000119")]
			[Address(RVA = "0xE726AC", Offset = "0xE726AC", VA = "0xE726AC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x983048", Offset = "0x983048")]
			set
			{
			}
		}

		[Token(Token = "0x17000050")]
		public RemoteVoiceInfoDelegate OnRemoteVoiceInfoAction
		{
			[Token(Token = "0x600011A")]
			[Address(RVA = "0xE726B8", Offset = "0xE726B8", VA = "0xE726B8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x983058", Offset = "0x983058")]
			get
			{
				return null;
			}
			[Token(Token = "0x600011B")]
			[Address(RVA = "0xE726C0", Offset = "0xE726C0", VA = "0xE726C0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x983068", Offset = "0x983068")]
			set
			{
			}
		}

		[Token(Token = "0x17000051")]
		public int DebugLostPercent
		{
			[Token(Token = "0x600011C")]
			[Address(RVA = "0xE726C8", Offset = "0xE726C8", VA = "0xE726C8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x983078", Offset = "0x983078")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600011D")]
			[Address(RVA = "0xE726D0", Offset = "0xE726D0", VA = "0xE726D0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x983088", Offset = "0x983088")]
			set
			{
			}
		}

		[Token(Token = "0x17000052")]
		public IEnumerable<LocalVoice> LocalVoices
		{
			[Token(Token = "0x600011E")]
			[Address(RVA = "0xE6C3C4", Offset = "0xE6C3C4", VA = "0xE6C3C4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000053")]
		public IEnumerable<RemoteVoiceInfo> RemoteVoiceInfos
		{
			[Token(Token = "0x6000120")]
			[Address(RVA = "0xE727B4", Offset = "0xE727B4", VA = "0xE727B4")]
			[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x983098", Offset = "0x983098")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000054")]
		public IEnumerable<object> RemoteVoiceLocalUserObjects
		{
			[Token(Token = "0x6000121")]
			[Address(RVA = "0xE72824", Offset = "0xE72824", VA = "0xE72824")]
			[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9830FC", Offset = "0x9830FC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000055")]
		internal byte GlobalGroup
		{
			[Token(Token = "0x600012E")]
			[Address(RVA = "0xE74F90", Offset = "0xE74F90", VA = "0xE74F90")]
			get
			{
				return default(byte);
			}
			[Token(Token = "0x600012F")]
			[Address(RVA = "0xE6B820", Offset = "0xE6B820", VA = "0xE6B820")]
			set
			{
			}
		}

		[Token(Token = "0x600011F")]
		[Address(RVA = "0xE726D8", Offset = "0xE726D8", VA = "0xE726D8")]
		public IEnumerable<LocalVoice> LocalVoicesInChannel(int channelId)
		{
			return null;
		}

		[Token(Token = "0x6000122")]
		[Address(RVA = "0xE6B490", Offset = "0xE6B490", VA = "0xE6B490")]
		internal VoiceClient(IVoiceFrontend frontend)
		{
		}

		[Token(Token = "0x6000123")]
		[Address(RVA = "0xE6B5C0", Offset = "0xE6B5C0", VA = "0xE6B5C0")]
		public void Service()
		{
		}

		[Token(Token = "0x6000124")]
		[Address(RVA = "0xE72894", Offset = "0xE72894", VA = "0xE72894")]
		private LocalVoice createLocalVoice(VoiceInfo voiceInfo, int channelId, Func<byte, int, LocalVoice> voiceFactory)
		{
			return null;
		}

		[Token(Token = "0x6000125")]
		[Address(RVA = "0xE72F3C", Offset = "0xE72F3C", VA = "0xE72F3C")]
		public LocalVoice CreateLocalVoice(VoiceInfo voiceInfo, int channelId = -1, [Optional] IEncoder encoder)
		{
			return null;
		}

		[Token(Token = "0x6000126")]
		public LocalVoiceFramed<T> CreateLocalVoiceFramed<T>(VoiceInfo voiceInfo, int frameSize, int channelId = -1, [Optional] IEncoderDataFlow<T> encoder)
		{
			return null;
		}

		[Token(Token = "0x6000127")]
		public LocalVoiceAudio<T> CreateLocalVoiceAudio<T>(VoiceInfo voiceInfo, int channelId = -1, [Optional] IEncoderDataFlow<T> encoder)
		{
			return null;
		}

		[Token(Token = "0x6000128")]
		[Address(RVA = "0xE72B4C", Offset = "0xE72B4C", VA = "0xE72B4C")]
		private byte getNewVoiceId()
		{
			return default(byte);
		}

		[Token(Token = "0x6000129")]
		[Address(RVA = "0xE72CF0", Offset = "0xE72CF0", VA = "0xE72CF0")]
		private void addVoice(byte newId, int channelId, LocalVoice v)
		{
		}

		[Token(Token = "0x600012A")]
		[Address(RVA = "0xE6EA08", Offset = "0xE6EA08", VA = "0xE6EA08")]
		public void RemoveLocalVoice(LocalVoice voice)
		{
		}

		[Token(Token = "0x600012B")]
		[Address(RVA = "0xE6CFDC", Offset = "0xE6CFDC", VA = "0xE6CFDC")]
		internal void sendVoicesInfo(int targetPlayerId)
		{
		}

		[Token(Token = "0x600012C")]
		[Address(RVA = "0xE73028", Offset = "0xE73028", VA = "0xE73028")]
		internal void sendChannelVoicesInfo(int channelId, int targetPlayerId)
		{
		}

		[Token(Token = "0x600012D")]
		[Address(RVA = "0xE6CBA8", Offset = "0xE6CBA8", VA = "0xE6CBA8")]
		internal void onVoiceEvent(object content0, int channelId, int playerId, int localPlayerId)
		{
		}

		[Token(Token = "0x6000130")]
		[Address(RVA = "0xE6B92C", Offset = "0xE6B92C", VA = "0xE6B92C")]
		internal object[] buildVoicesInfo(IEnumerable<LocalVoice> voicesToSend, bool logInfo)
		{
			return null;
		}

		[Token(Token = "0x6000131")]
		[Address(RVA = "0xE6C478", Offset = "0xE6C478", VA = "0xE6C478")]
		internal object[] buildVoiceRemoveMessage(LocalVoice v)
		{
			return null;
		}

		[Token(Token = "0x6000132")]
		[Address(RVA = "0xE6D0EC", Offset = "0xE6D0EC", VA = "0xE6D0EC")]
		internal void clearRemoteVoices()
		{
		}

		[Token(Token = "0x6000133")]
		[Address(RVA = "0xE74F98", Offset = "0xE74F98", VA = "0xE74F98")]
		internal void clearRemoteVoicesInChannel(int channelId)
		{
		}

		[Token(Token = "0x6000134")]
		[Address(RVA = "0xE731A4", Offset = "0xE731A4", VA = "0xE731A4")]
		private void onVoiceInfo(int channelId, int playerId, object payload)
		{
		}

		[Token(Token = "0x6000135")]
		[Address(RVA = "0xE73BD4", Offset = "0xE73BD4", VA = "0xE73BD4")]
		private void onVoiceRemove(int channelId, int playerId, object payload)
		{
		}

		[Token(Token = "0x6000136")]
		[Address(RVA = "0xE74668", Offset = "0xE74668", VA = "0xE74668")]
		private void onFrame(int channelId, int playerId, byte voiceId, byte evNumber, byte[] receivedBytes)
		{
		}

		[Token(Token = "0x6000137")]
		[Address(RVA = "0xE6D758", Offset = "0xE6D758", VA = "0xE6D758")]
		internal bool removePlayerVoices(int playerId)
		{
			return default(bool);
		}

		[Token(Token = "0x6000138")]
		[Address(RVA = "0xE75540", Offset = "0xE75540", VA = "0xE75540")]
		internal bool removePlayerVoices(int channelId, int playerId)
		{
			return default(bool);
		}

		[Token(Token = "0x6000139")]
		[Address(RVA = "0xE6E1DC", Offset = "0xE6E1DC", VA = "0xE6E1DC")]
		internal string channelStr(int channelId)
		{
			return null;
		}

		[Token(Token = "0x600013A")]
		[Address(RVA = "0xE75350", Offset = "0xE75350", VA = "0xE75350")]
		internal string playerStr(int playerId)
		{
			return null;
		}

		[Token(Token = "0x600013B")]
		[Address(RVA = "0xE6D884", Offset = "0xE6D884", VA = "0xE6D884", Slot = "4")]
		public void Dispose()
		{
		}
	}
	[Token(Token = "0x2000037")]
	public interface IEncoder : IDisposable
	{
	}
	[Token(Token = "0x2000038")]
	public interface IEncoderDataFlow<T> : IEncoder, IDisposable
	{
	}
	[Token(Token = "0x2000039")]
	public interface IEncoderDataFlowDirect<T> : IEncoderDataFlow<T>, IEncoder, IDisposable
	{
		[Token(Token = "0x600013C")]
		ArraySegment<byte> EncodeAndGetOutput(T[] buf);
	}
	[Token(Token = "0x200003A")]
	public interface IEncoderNativeImageDirect : IEncoder, IDisposable
	{
		[Token(Token = "0x600013D")]
		IEnumerable<ArraySegment<byte>> EncodeAndGetOutput(IntPtr[] buf, int width, int height, int[] stride, ImageFormat imageFormat, Rotation rotation, Flip flip);
	}
	[Token(Token = "0x200003B")]
	public interface IEncoderQueued : IEncoder, IDisposable
	{
		[Token(Token = "0x600013E")]
		IEnumerable<ArraySegment<byte>> GetOutput();
	}
	[Token(Token = "0x200003C")]
	public interface IDecoder : IDisposable
	{
		[Token(Token = "0x600013F")]
		void Open(VoiceInfo info);
	}
	[Token(Token = "0x200003D")]
	public interface IDecoderDirect : IDecoder, IDisposable
	{
		[Token(Token = "0x6000140")]
		byte[] DecodeToByte(byte[] buf);

		[Token(Token = "0x6000141")]
		float[] DecodeToFloat(byte[] buf);

		[Token(Token = "0x6000142")]
		short[] DecodeToShort(byte[] buf);
	}
	[Token(Token = "0x200003E")]
	public interface IDecoderQueued : IDecoder, IDisposable
	{
		[Token(Token = "0x6000143")]
		void Decode(byte[] buf);
	}
	[Token(Token = "0x200003F")]
	public delegate void OnImageOutputNative(IntPtr buf, int width, int height, int stride);
	[Token(Token = "0x2000040")]
	public interface IDecoderQueuedOutputImageNative : IDecoderQueued, IDecoder, IDisposable
	{
		[Token(Token = "0x17000056")]
		ImageFormat OutputImageFormat
		{
			[Token(Token = "0x6000148")]
			get;
			[Token(Token = "0x6000149")]
			set;
		}

		[Token(Token = "0x17000057")]
		Flip OutputImageFlip
		{
			[Token(Token = "0x600014A")]
			get;
			[Token(Token = "0x600014B")]
			set;
		}

		[Token(Token = "0x17000058")]
		Func<int, int, IntPtr> OutputImageBufferGetter
		{
			[Token(Token = "0x600014C")]
			get;
			[Token(Token = "0x600014D")]
			set;
		}

		[Token(Token = "0x17000059")]
		OnImageOutputNative OnOutputImage
		{
			[Token(Token = "0x600014E")]
			get;
			[Token(Token = "0x600014F")]
			set;
		}
	}
	[Token(Token = "0x2000041")]
	internal class UnsupportedSampleTypeException : Exception
	{
		[Token(Token = "0x6000150")]
		[Address(RVA = "0xE723C4", Offset = "0xE723C4", VA = "0xE723C4")]
		public UnsupportedSampleTypeException(Type t)
		{
		}
	}
	[Token(Token = "0x2000042")]
	internal class UnsupportedCodecException : Exception
	{
		[Token(Token = "0x6000151")]
		[Address(RVA = "0xE6F8FC", Offset = "0xE6F8FC", VA = "0xE6F8FC")]
		public UnsupportedCodecException(Codec codec, LocalVoice voice)
		{
		}
	}
	[Token(Token = "0x2000043")]
	public enum Codec
	{
		[Token(Token = "0x4000100")]
		AudioOpus = 11
	}
	[Token(Token = "0x2000044")]
	public enum ImageFormat
	{
		[Token(Token = "0x4000102")]
		I420,
		[Token(Token = "0x4000103")]
		YV12,
		[Token(Token = "0x4000104")]
		Android420,
		[Token(Token = "0x4000105")]
		RGBA,
		[Token(Token = "0x4000106")]
		ABGR,
		[Token(Token = "0x4000107")]
		BGRA,
		[Token(Token = "0x4000108")]
		ARGB
	}
	[Token(Token = "0x2000045")]
	public enum Rotation
	{
		[Token(Token = "0x400010A")]
		Rotate0 = 0,
		[Token(Token = "0x400010B")]
		Rotate90 = 90,
		[Token(Token = "0x400010C")]
		Rotate180 = 180,
		[Token(Token = "0x400010D")]
		Rotate270 = 270
	}
	[Token(Token = "0x2000046")]
	public enum Flip
	{
		[Token(Token = "0x400010F")]
		None,
		[Token(Token = "0x4000110")]
		Vertical,
		[Token(Token = "0x4000111")]
		Horizontal
	}
	[Token(Token = "0x2000047")]
	public class ImageBufferInfo
	{
		[Token(Token = "0x4000112")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x981ABC", Offset = "0x981ABC")]
		private int <Width>k__BackingField;

		[Token(Token = "0x4000113")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x981ACC", Offset = "0x981ACC")]
		private int <Height>k__BackingField;

		[Token(Token = "0x4000114")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x981ADC", Offset = "0x981ADC")]
		private int[] <Stride>k__BackingField;

		[Token(Token = "0x4000115")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x981AEC", Offset = "0x981AEC")]
		private ImageFormat <Format>k__BackingField;

		[Token(Token = "0x4000116")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x981AFC", Offset = "0x981AFC")]
		private Rotation <Rotation>k__BackingField;

		[Token(Token = "0x4000117")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x981B0C", Offset = "0x981B0C")]
		private Flip <Flip>k__BackingField;

		[Token(Token = "0x1700005A")]
		public int Width
		{
			[Token(Token = "0x6000152")]
			[Address(RVA = "0xE6A758", Offset = "0xE6A758", VA = "0xE6A758")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x983160", Offset = "0x983160")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000153")]
			[Address(RVA = "0xE6A760", Offset = "0xE6A760", VA = "0xE6A760")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x983170", Offset = "0x983170")]
			private set
			{
			}
		}

		[Token(Token = "0x1700005B")]
		public int Height
		{
			[Token(Token = "0x6000154")]
			[Address(RVA = "0xE6A768", Offset = "0xE6A768", VA = "0xE6A768")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x983180", Offset = "0x983180")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000155")]
			[Address(RVA = "0xE6A770", Offset = "0xE6A770", VA = "0xE6A770")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x983190", Offset = "0x983190")]
			private set
			{
			}
		}

		[Token(Token = "0x1700005C")]
		public int[] Stride
		{
			[Token(Token = "0x6000156")]
			[Address(RVA = "0xE6A778", Offset = "0xE6A778", VA = "0xE6A778")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9831A0", Offset = "0x9831A0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000157")]
			[Address(RVA = "0xE6A780", Offset = "0xE6A780", VA = "0xE6A780")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9831B0", Offset = "0x9831B0")]
			private set
			{
			}
		}

		[Token(Token = "0x1700005D")]
		public ImageFormat Format
		{
			[Token(Token = "0x6000158")]
			[Address(RVA = "0xE6A788", Offset = "0xE6A788", VA = "0xE6A788")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9831C0", Offset = "0x9831C0")]
			get
			{
				return default(ImageFormat);
			}
			[Token(Token = "0x6000159")]
			[Address(RVA = "0xE6A790", Offset = "0xE6A790", VA = "0xE6A790")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9831D0", Offset = "0x9831D0")]
			private set
			{
			}
		}

		[Token(Token = "0x1700005E")]
		public Rotation Rotation
		{
			[Token(Token = "0x600015A")]
			[Address(RVA = "0xE6A798", Offset = "0xE6A798", VA = "0xE6A798")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9831E0", Offset = "0x9831E0")]
			get
			{
				return default(Rotation);
			}
			[Token(Token = "0x600015B")]
			[Address(RVA = "0xE6A7A0", Offset = "0xE6A7A0", VA = "0xE6A7A0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9831F0", Offset = "0x9831F0")]
			set
			{
			}
		}

		[Token(Token = "0x1700005F")]
		public Flip Flip
		{
			[Token(Token = "0x600015C")]
			[Address(RVA = "0xE6A7A8", Offset = "0xE6A7A8", VA = "0xE6A7A8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x983200", Offset = "0x983200")]
			get
			{
				return default(Flip);
			}
			[Token(Token = "0x600015D")]
			[Address(RVA = "0xE6A7B0", Offset = "0xE6A7B0", VA = "0xE6A7B0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x983210", Offset = "0x983210")]
			set
			{
			}
		}

		[Token(Token = "0x600015E")]
		[Address(RVA = "0xE6A7B8", Offset = "0xE6A7B8", VA = "0xE6A7B8")]
		public ImageBufferInfo(int width, int height, int[] stride, ImageFormat format)
		{
		}
	}
	[Token(Token = "0x2000048")]
	public class ImageBufferNative
	{
		[Token(Token = "0x4000118")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x981B1C", Offset = "0x981B1C")]
		private ImageBufferInfo <Info>k__BackingField;

		[Token(Token = "0x4000119")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x981B2C", Offset = "0x981B2C")]
		private IntPtr[] <Planes>k__BackingField;

		[Token(Token = "0x17000060")]
		public ImageBufferInfo Info
		{
			[Token(Token = "0x6000160")]
			[Address(RVA = "0xE6A834", Offset = "0xE6A834", VA = "0xE6A834")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x983220", Offset = "0x983220")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000161")]
			[Address(RVA = "0xE6A83C", Offset = "0xE6A83C", VA = "0xE6A83C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x983230", Offset = "0x983230")]
			protected set
			{
			}
		}

		[Token(Token = "0x17000061")]
		public IntPtr[] Planes
		{
			[Token(Token = "0x6000162")]
			[Address(RVA = "0xE6A844", Offset = "0xE6A844", VA = "0xE6A844")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x983240", Offset = "0x983240")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000163")]
			[Address(RVA = "0xE6A84C", Offset = "0xE6A84C", VA = "0xE6A84C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x983250", Offset = "0x983250")]
			protected set
			{
			}
		}

		[Token(Token = "0x600015F")]
		[Address(RVA = "0xE6A808", Offset = "0xE6A808", VA = "0xE6A808")]
		public ImageBufferNative(ImageBufferInfo info)
		{
		}

		[Token(Token = "0x6000164")]
		[Address(RVA = "0xE6A854", Offset = "0xE6A854", VA = "0xE6A854", Slot = "4")]
		public virtual void Release()
		{
		}

		[Token(Token = "0x6000165")]
		[Address(RVA = "0xE6A858", Offset = "0xE6A858", VA = "0xE6A858", Slot = "5")]
		public virtual void Dispose()
		{
		}
	}
	[Token(Token = "0x2000049")]
	public class ImageBufferNativeAlloc : ImageBufferNative, IDisposable
	{
		[Token(Token = "0x400011A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private ImageBufferNativePool<ImageBufferNativeAlloc> pool;

		[Token(Token = "0x6000166")]
		[Address(RVA = "0xE6A85C", Offset = "0xE6A85C", VA = "0xE6A85C")]
		public ImageBufferNativeAlloc(ImageBufferNativePool<ImageBufferNativeAlloc> pool, ImageBufferInfo info)
		{
		}

		[Token(Token = "0x6000167")]
		[Address(RVA = "0xE6A984", Offset = "0xE6A984", VA = "0xE6A984", Slot = "4")]
		public override void Release()
		{
		}

		[Token(Token = "0x6000168")]
		[Address(RVA = "0xE6A9A0", Offset = "0xE6A9A0", VA = "0xE6A9A0", Slot = "5")]
		public override void Dispose()
		{
		}
	}
	[Token(Token = "0x200004A")]
	public class ImageBufferNativeGCHandleSinglePlane : ImageBufferNative, IDisposable
	{
		[Token(Token = "0x400011B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private ImageBufferNativePool<ImageBufferNativeGCHandleSinglePlane> pool;

		[Token(Token = "0x400011C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private GCHandle planeHandle;

		[Token(Token = "0x6000169")]
		[Address(RVA = "0xE6AA6C", Offset = "0xE6AA6C", VA = "0xE6AA6C")]
		public ImageBufferNativeGCHandleSinglePlane(ImageBufferNativePool<ImageBufferNativeGCHandleSinglePlane> pool, ImageBufferInfo info)
		{
		}

		[Token(Token = "0x600016A")]
		[Address(RVA = "0xE6AB94", Offset = "0xE6AB94", VA = "0xE6AB94")]
		public void PinPlane(byte[] plane)
		{
		}

		[Token(Token = "0x600016B")]
		[Address(RVA = "0xE6ABF8", Offset = "0xE6ABF8", VA = "0xE6ABF8", Slot = "4")]
		public override void Release()
		{
		}

		[Token(Token = "0x600016C")]
		[Address(RVA = "0xE6AC40", Offset = "0xE6AC40", VA = "0xE6AC40", Slot = "5")]
		public override void Dispose()
		{
		}
	}
	[Token(Token = "0x200004B")]
	internal static class VoiceCodec
	{
		[Token(Token = "0x600016D")]
		[Address(RVA = "0x1721444", Offset = "0x1721444", VA = "0x1721444")]
		internal static IEncoder CreateDefaultEncoder(VoiceInfo info, LocalVoice localVoice)
		{
			return null;
		}

		[Token(Token = "0x600016E")]
		[Address(RVA = "0x1721500", Offset = "0x1721500", VA = "0x1721500")]
		internal static IDecoder CreateDefaultDecoder(int channelId, int playerId, byte voiceId, VoiceInfo info)
		{
			return null;
		}
	}
	[Token(Token = "0x200004C")]
	public class Framer<T>
	{
		[Token(Token = "0x20000E2")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x981684", Offset = "0x981684")]
		private sealed class <Frame>d__5 : IEnumerable<T[]>, IEnumerable, IEnumerator<T[]>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40006EA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private int <>1__state;

			[Token(Token = "0x40006EB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private T[] <>2__current;

			[Token(Token = "0x40006EC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private int <>l__initialThreadId;

			[Token(Token = "0x40006ED")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Framer<T> <>4__this;

			[Token(Token = "0x40006EE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private T[] buf;

			[Token(Token = "0x40006EF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public T[] <>3__buf;

			[Token(Token = "0x40006F0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private int <s>5__2;

			[Token(Token = "0x40006F1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private int <bufPos>5__3;

			[Token(Token = "0x17000192")]
			private T[] System.Collections.Generic.IEnumerator<T[]>.Current
			{
				[Token(Token = "0x60006FA")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000193")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60006FC")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60006F7")]
			[DebuggerHidden]
			public <Frame>d__5(int <>1__state)
			{
			}

			[Token(Token = "0x60006F8")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60006F9")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60006FB")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}

			[Token(Token = "0x60006FD")]
			[DebuggerHidden]
			private IEnumerator<T[]> System.Collections.Generic.IEnumerable<T[]>.GetEnumerator()
			{
				return null;
			}

			[Token(Token = "0x60006FE")]
			[DebuggerHidden]
			private IEnumerator System.Collections.IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Token(Token = "0x400011D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private T[] frame;

		[Token(Token = "0x400011E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int sizeofT;

		[Token(Token = "0x400011F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int framePos;

		[Token(Token = "0x600016F")]
		public Framer(int frameSize)
		{
		}

		[Token(Token = "0x6000170")]
		public int Count(int bufLen)
		{
			return default(int);
		}

		[Token(Token = "0x6000171")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x983260", Offset = "0x983260")]
		public IEnumerable<T[]> Frame(T[] buf)
		{
			return null;
		}
	}
	[Token(Token = "0x200004D")]
	public class LocalVoiceFramed : LocalVoice
	{
		[Token(Token = "0x4000120")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x981B3C", Offset = "0x981B3C")]
		private int <FrameSize>k__BackingField;

		[Token(Token = "0x17000062")]
		public int FrameSize
		{
			[Token(Token = "0x6000172")]
			[Address(RVA = "0xE6F100", Offset = "0xE6F100", VA = "0xE6F100")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9832C4", Offset = "0x9832C4")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000173")]
			[Address(RVA = "0xE6F108", Offset = "0xE6F108", VA = "0xE6F108")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9832D4", Offset = "0x9832D4")]
			private set
			{
			}
		}

		[Token(Token = "0x6000174")]
		[Address(RVA = "0xE6F110", Offset = "0xE6F110", VA = "0xE6F110")]
		internal LocalVoiceFramed(VoiceClient voiceClient, IEncoder encoder, byte id, VoiceInfo voiceInfo, int channelId, int frameSize)
		{
		}
	}
	[Token(Token = "0x200004E")]
	public class LocalVoiceFramed<T> : LocalVoiceFramed
	{
		[Token(Token = "0x20000E3")]
		public interface IProcessor : IDisposable
		{
			[Token(Token = "0x60006FF")]
			T[] Process(T[] buf);
		}

		[Token(Token = "0x4000121")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Framer<T> framer;

		[Token(Token = "0x4000122")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int preProcessorsCnt;

		[Token(Token = "0x4000123")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private List<IProcessor> processors;

		[Token(Token = "0x4000124")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private bool dataEncodeThreadStarted;

		[Token(Token = "0x4000125")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Queue<T[]> pushDataQueue;

		[Token(Token = "0x4000126")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private AutoResetEvent pushDataQueueReady;

		[Token(Token = "0x4000127")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private PrimitiveArrayPool<T> pushDataBufferPool;

		[Token(Token = "0x4000128")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int framesSkipped;

		[Token(Token = "0x4000129")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private bool exitThread;

		[Token(Token = "0x17000063")]
		public PrimitiveArrayPool<T> PushDataBufferPool
		{
			[Token(Token = "0x600017A")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000064")]
		public bool PushDataAsyncReady
		{
			[Token(Token = "0x600017B")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000175")]
		internal T[] processFrame(T[] buf)
		{
			return null;
		}

		[Token(Token = "0x6000176")]
		public void AddPostProcessor(params IProcessor[] processors)
		{
		}

		[Token(Token = "0x6000177")]
		public void AddPreProcessor(params IProcessor[] processors)
		{
		}

		[Token(Token = "0x6000178")]
		public void ClearProcessors()
		{
		}

		[Token(Token = "0x6000179")]
		internal LocalVoiceFramed(VoiceClient voiceClient, IEncoder encoder, byte id, VoiceInfo voiceInfo, int channelId, int frameSize)
		{
		}

		[Token(Token = "0x600017C")]
		public void PushDataAsync(T[] buf)
		{
		}

		[Token(Token = "0x600017D")]
		private void PushDataAsyncThread()
		{
		}

		[Token(Token = "0x600017E")]
		public void PushData(T[] buf)
		{
		}

		[Token(Token = "0x600017F")]
		public override void Dispose()
		{
		}
	}
	[Token(Token = "0x200004F")]
	public struct VoiceInfo
	{
		[Token(Token = "0x400012A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x981B4C", Offset = "0x981B4C")]
		private Codec <Codec>k__BackingField;

		[Token(Token = "0x400012B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x981B5C", Offset = "0x981B5C")]
		private int <SamplingRate>k__BackingField;

		[Token(Token = "0x400012C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x981B6C", Offset = "0x981B6C")]
		private int <SourceSamplingRate>k__BackingField;

		[Token(Token = "0x400012D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x981B7C", Offset = "0x981B7C")]
		private int <Channels>k__BackingField;

		[Token(Token = "0x400012E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x981B8C", Offset = "0x981B8C")]
		private int <FrameDurationUs>k__BackingField;

		[Token(Token = "0x400012F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x981B9C", Offset = "0x981B9C")]
		private int <Bitrate>k__BackingField;

		[Token(Token = "0x4000130")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x981BAC", Offset = "0x981BAC")]
		private object <UserData>k__BackingField;

		[Token(Token = "0x4000131")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x981BBC", Offset = "0x981BBC")]
		private int <Width>k__BackingField;

		[Token(Token = "0x4000132")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x981BCC", Offset = "0x981BCC")]
		private int <Height>k__BackingField;

		[Token(Token = "0x17000065")]
		public Codec Codec
		{
			[Token(Token = "0x6000183")]
			[Address(RVA = "0x1721C80", Offset = "0x1721C80", VA = "0x1721C80")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9832E4", Offset = "0x9832E4")]
			get
			{
				return default(Codec);
			}
			[Token(Token = "0x6000184")]
			[Address(RVA = "0x1721C88", Offset = "0x1721C88", VA = "0x1721C88")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9832F4", Offset = "0x9832F4")]
			set
			{
			}
		}

		[Token(Token = "0x17000066")]
		public int SamplingRate
		{
			[Token(Token = "0x6000185")]
			[Address(RVA = "0x1721C90", Offset = "0x1721C90", VA = "0x1721C90")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x983304", Offset = "0x983304")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000186")]
			[Address(RVA = "0x1721C98", Offset = "0x1721C98", VA = "0x1721C98")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x983314", Offset = "0x983314")]
			set
			{
			}
		}

		[Token(Token = "0x17000067")]
		public int SourceSamplingRate
		{
			[Token(Token = "0x6000187")]
			[Address(RVA = "0x1721CA0", Offset = "0x1721CA0", VA = "0x1721CA0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x983324", Offset = "0x983324")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000188")]
			[Address(RVA = "0x1721CA8", Offset = "0x1721CA8", VA = "0x1721CA8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x983334", Offset = "0x983334")]
			set
			{
			}
		}

		[Token(Token = "0x17000068")]
		public int Channels
		{
			[Token(Token = "0x6000189")]
			[Address(RVA = "0x1721CB0", Offset = "0x1721CB0", VA = "0x1721CB0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x983344", Offset = "0x983344")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600018A")]
			[Address(RVA = "0x1721CB8", Offset = "0x1721CB8", VA = "0x1721CB8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x983354", Offset = "0x983354")]
			set
			{
			}
		}

		[Token(Token = "0x17000069")]
		public int FrameDurationUs
		{
			[Token(Token = "0x600018B")]
			[Address(RVA = "0x1721CC0", Offset = "0x1721CC0", VA = "0x1721CC0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x983364", Offset = "0x983364")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600018C")]
			[Address(RVA = "0x1721CC8", Offset = "0x1721CC8", VA = "0x1721CC8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x983374", Offset = "0x983374")]
			set
			{
			}
		}

		[Token(Token = "0x1700006A")]
		public int Bitrate
		{
			[Token(Token = "0x600018D")]
			[Address(RVA = "0x1721CD0", Offset = "0x1721CD0", VA = "0x1721CD0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x983384", Offset = "0x983384")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600018E")]
			[Address(RVA = "0x1721CD8", Offset = "0x1721CD8", VA = "0x1721CD8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x983394", Offset = "0x983394")]
			set
			{
			}
		}

		[Token(Token = "0x1700006B")]
		public object UserData
		{
			[Token(Token = "0x600018F")]
			[Address(RVA = "0x1721CE0", Offset = "0x1721CE0", VA = "0x1721CE0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9833A4", Offset = "0x9833A4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000190")]
			[Address(RVA = "0x1721CE8", Offset = "0x1721CE8", VA = "0x1721CE8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9833B4", Offset = "0x9833B4")]
			set
			{
			}
		}

		[Token(Token = "0x1700006C")]
		public int FrameDurationSamples
		{
			[Token(Token = "0x6000191")]
			[Address(RVA = "0x1721CF0", Offset = "0x1721CF0", VA = "0x1721CF0")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700006D")]
		public int FrameSize
		{
			[Token(Token = "0x6000192")]
			[Address(RVA = "0x1721AA0", Offset = "0x1721AA0", VA = "0x1721AA0")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700006E")]
		public int Width
		{
			[Token(Token = "0x6000193")]
			[Address(RVA = "0x1721D20", Offset = "0x1721D20", VA = "0x1721D20")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9833C4", Offset = "0x9833C4")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000194")]
			[Address(RVA = "0x1721D28", Offset = "0x1721D28", VA = "0x1721D28")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9833D4", Offset = "0x9833D4")]
			set
			{
			}
		}

		[Token(Token = "0x1700006F")]
		public int Height
		{
			[Token(Token = "0x6000195")]
			[Address(RVA = "0x1721D30", Offset = "0x1721D30", VA = "0x1721D30")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9833E4", Offset = "0x9833E4")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000196")]
			[Address(RVA = "0x1721D38", Offset = "0x1721D38", VA = "0x1721D38")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9833F4", Offset = "0x9833F4")]
			set
			{
			}
		}

		[Token(Token = "0x6000180")]
		[Address(RVA = "0x17215B8", Offset = "0x17215B8", VA = "0x17215B8")]
		public static VoiceInfo CreateAudioOpus(SamplingRate samplingRate, int sourceSamplingRate, int channels, OpusCodec.FrameDuration frameDurationUs, int bitrate, [Optional] object userdata)
		{
			return default(VoiceInfo);
		}

		[Token(Token = "0x6000181")]
		[Address(RVA = "0x17215D0", Offset = "0x17215D0", VA = "0x17215D0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000182")]
		[Address(RVA = "0x1721AD8", Offset = "0x1721AD8", VA = "0x1721AD8")]
		internal static VoiceInfo CreateFromEventPayload(Dictionary<byte, object> h)
		{
			return default(VoiceInfo);
		}
	}
	[Token(Token = "0x2000050")]
	public class RemoteVoiceInfo
	{
		[Token(Token = "0x4000133")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x981BDC", Offset = "0x981BDC")]
		private VoiceInfo <Info>k__BackingField;

		[Token(Token = "0x4000134")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x981BEC", Offset = "0x981BEC")]
		private int <ChannelId>k__BackingField;

		[Token(Token = "0x4000135")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x981BFC", Offset = "0x981BFC")]
		private int <PlayerId>k__BackingField;

		[Token(Token = "0x4000136")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x981C0C", Offset = "0x981C0C")]
		private byte <VoiceId>k__BackingField;

		[Token(Token = "0x4000137")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x981C1C", Offset = "0x981C1C")]
		private object <LocalUserObject>k__BackingField;

		[Token(Token = "0x17000070")]
		public VoiceInfo Info
		{
			[Token(Token = "0x6000198")]
			[Address(RVA = "0xE722FC", Offset = "0xE722FC", VA = "0xE722FC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x983404", Offset = "0x983404")]
			get
			{
				return default(VoiceInfo);
			}
			[Token(Token = "0x6000199")]
			[Address(RVA = "0xE72310", Offset = "0xE72310", VA = "0xE72310")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x983414", Offset = "0x983414")]
			private set
			{
			}
		}

		[Token(Token = "0x17000071")]
		public int ChannelId
		{
			[Token(Token = "0x600019A")]
			[Address(RVA = "0xE72324", Offset = "0xE72324", VA = "0xE72324")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x983424", Offset = "0x983424")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600019B")]
			[Address(RVA = "0xE7232C", Offset = "0xE7232C", VA = "0xE7232C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x983434", Offset = "0x983434")]
			private set
			{
			}
		}

		[Token(Token = "0x17000072")]
		public int PlayerId
		{
			[Token(Token = "0x600019C")]
			[Address(RVA = "0xE72334", Offset = "0xE72334", VA = "0xE72334")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x983444", Offset = "0x983444")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600019D")]
			[Address(RVA = "0xE7233C", Offset = "0xE7233C", VA = "0xE7233C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x983454", Offset = "0x983454")]
			private set
			{
			}
		}

		[Token(Token = "0x17000073")]
		public byte VoiceId
		{
			[Token(Token = "0x600019E")]
			[Address(RVA = "0xE72344", Offset = "0xE72344", VA = "0xE72344")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x983464", Offset = "0x983464")]
			get
			{
				return default(byte);
			}
			[Token(Token = "0x600019F")]
			[Address(RVA = "0xE7234C", Offset = "0xE7234C", VA = "0xE7234C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x983474", Offset = "0x983474")]
			private set
			{
			}
		}

		[Token(Token = "0x17000074")]
		public object LocalUserObject
		{
			[Token(Token = "0x60001A0")]
			[Address(RVA = "0xE72354", Offset = "0xE72354", VA = "0xE72354")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x983484", Offset = "0x983484")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001A1")]
			[Address(RVA = "0xE7235C", Offset = "0xE7235C", VA = "0xE7235C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x983494", Offset = "0x983494")]
			private set
			{
			}
		}

		[Token(Token = "0x6000197")]
		[Address(RVA = "0xE72298", Offset = "0xE72298", VA = "0xE72298")]
		internal RemoteVoiceInfo(int channelId, int playerId, byte voiceId, VoiceInfo info, object localUserObject)
		{
		}
	}
	[Token(Token = "0x2000051")]
	public abstract class BufferReaderPushAdapterBase<T> : IServiceable
	{
		[Token(Token = "0x4000138")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		protected IDataReader<T> reader;

		[Token(Token = "0x60001A2")]
		public abstract void Service(LocalVoice localVoice);

		[Token(Token = "0x60001A3")]
		public BufferReaderPushAdapterBase(IDataReader<T> reader)
		{
		}

		[Token(Token = "0x60001A4")]
		public void Dispose()
		{
		}
	}
	[Token(Token = "0x2000052")]
	public class BufferReaderPushAdapter<T> : BufferReaderPushAdapterBase<T>
	{
		[Token(Token = "0x4000139")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		protected T[] buffer;

		[Token(Token = "0x60001A5")]
		public BufferReaderPushAdapter(LocalVoice localVoice, IDataReader<T> reader)
		{
		}

		[Token(Token = "0x60001A6")]
		public override void Service(LocalVoice localVoice)
		{
		}
	}
	[Token(Token = "0x2000053")]
	public class BufferReaderPushAdapterAsyncPool<T> : BufferReaderPushAdapterBase<T>
	{
		[Token(Token = "0x60001A7")]
		public BufferReaderPushAdapterAsyncPool(LocalVoice localVoice, IDataReader<T> reader)
		{
		}

		[Token(Token = "0x60001A8")]
		public override void Service(LocalVoice localVoice)
		{
		}
	}
	[Token(Token = "0x2000054")]
	public class BufferReaderPushAdapterAsyncPoolCopy<T> : BufferReaderPushAdapterBase<T>
	{
		[Token(Token = "0x400013A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		protected T[] buffer;

		[Token(Token = "0x60001A9")]
		public BufferReaderPushAdapterAsyncPoolCopy(LocalVoice localVoice, IDataReader<T> reader)
		{
		}

		[Token(Token = "0x60001AA")]
		public override void Service(LocalVoice localVoice)
		{
		}
	}
	[Token(Token = "0x2000055")]
	public class BufferReaderPushAdapterAsyncPoolFloatToShort : BufferReaderPushAdapterBase<float>
	{
		[Token(Token = "0x400013B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private float[] buffer;

		[Token(Token = "0x60001AB")]
		[Address(RVA = "0xE6A47C", Offset = "0xE6A47C", VA = "0xE6A47C")]
		public BufferReaderPushAdapterAsyncPoolFloatToShort(LocalVoice localVoice, IDataReader<float> reader)
		{
		}

		[Token(Token = "0x60001AC")]
		[Address(RVA = "0xE6A540", Offset = "0xE6A540", VA = "0xE6A540", Slot = "5")]
		public override void Service(LocalVoice localVoice)
		{
		}
	}
	[Token(Token = "0x2000056")]
	internal class VoiceEventCode
	{
		[Token(Token = "0x400013C")]
		public const byte Code0 = 201;

		[Token(Token = "0x60001AD")]
		[Address(RVA = "0x1721574", Offset = "0x1721574", VA = "0x1721574")]
		public static byte GetCode(int channelID)
		{
			return default(byte);
		}

		[Token(Token = "0x60001AE")]
		[Address(RVA = "0x172157C", Offset = "0x172157C", VA = "0x172157C")]
		public static bool TryGetChannelID(byte evCode, int maxChannels, out byte channelID)
		{
			return default(bool);
		}

		[Token(Token = "0x60001AF")]
		[Address(RVA = "0x17215B0", Offset = "0x17215B0", VA = "0x17215B0")]
		public VoiceEventCode()
		{
		}
	}
	[Token(Token = "0x2000057")]
	public class LoadBalancingFrontend : LoadBalancingClient, IVoiceFrontend, ILogger, IDisposable
	{
		[Serializable]
		[Token(Token = "0x20000E4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x981694", Offset = "0x981694")]
		private sealed class <>c
		{
			[Token(Token = "0x40006F2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x40006F3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Func<LocalVoice, bool> <>9__26_0;

			[Token(Token = "0x6000701")]
			[Address(RVA = "0xE6DD18", Offset = "0xE6DD18", VA = "0xE6DD18")]
			public <>c()
			{
			}

			[Token(Token = "0x6000702")]
			[Address(RVA = "0xE6DD20", Offset = "0xE6DD20", VA = "0xE6DD20")]
			internal bool <SendDebugEchoVoicesInfo>b__26_0(LocalVoice x)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x400013D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		protected VoiceClient voiceClient;

		[Token(Token = "0x400013E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x981C2C", Offset = "0x981C2C")]
		private Action<EventData> <OnEventAction>k__BackingField;

		[Token(Token = "0x400013F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x981C3C", Offset = "0x981C3C")]
		private Action<ClientState> <OnStateChangeAction>k__BackingField;

		[Token(Token = "0x4000140")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		private object sendLock;

		[Token(Token = "0x17000075")]
		public VoiceClient VoiceClient
		{
			[Token(Token = "0x60001B0")]
			[Address(RVA = "0xE6AC44", Offset = "0xE6AC44", VA = "0xE6AC44")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000076")]
		public new Action<EventData> OnEventAction
		{
			[Token(Token = "0x60001B8")]
			[Address(RVA = "0xE6B2A0", Offset = "0xE6B2A0", VA = "0xE6B2A0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9834A4", Offset = "0x9834A4")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001B9")]
			[Address(RVA = "0xE6B2A8", Offset = "0xE6B2A8", VA = "0xE6B2A8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9834B4", Offset = "0x9834B4")]
			set
			{
			}
		}

		[Token(Token = "0x17000077")]
		public new Action<ClientState> OnStateChangeAction
		{
			[Token(Token = "0x60001BA")]
			[Address(RVA = "0xE6B2B0", Offset = "0xE6B2B0", VA = "0xE6B2B0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9834C4", Offset = "0x9834C4")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001BB")]
			[Address(RVA = "0xE6B2B8", Offset = "0xE6B2B8", VA = "0xE6B2B8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9834D4", Offset = "0x9834D4")]
			set
			{
			}
		}

		[Token(Token = "0x17000078")]
		public byte GlobalAudioGroup
		{
			[Token(Token = "0x60001BF")]
			[Address(RVA = "0xE6B6E8", Offset = "0xE6B6E8", VA = "0xE6B6E8")]
			get
			{
				return default(byte);
			}
			[Token(Token = "0x60001C0")]
			[Address(RVA = "0xE6B704", Offset = "0xE6B704", VA = "0xE6B704")]
			set
			{
			}
		}

		[Token(Token = "0x60001B1")]
		[Address(RVA = "0xE6AC4C", Offset = "0xE6AC4C", VA = "0xE6AC4C", Slot = "27")]
		public void LogError(string fmt, params object[] args)
		{
		}

		[Token(Token = "0x60001B2")]
		[Address(RVA = "0xE6AC90", Offset = "0xE6AC90", VA = "0xE6AC90", Slot = "28")]
		public void LogWarning(string fmt, params object[] args)
		{
		}

		[Token(Token = "0x60001B3")]
		[Address(RVA = "0xE6ACD4", Offset = "0xE6ACD4", VA = "0xE6ACD4", Slot = "29")]
		public void LogInfo(string fmt, params object[] args)
		{
		}

		[Token(Token = "0x60001B4")]
		[Address(RVA = "0xE6AD18", Offset = "0xE6AD18", VA = "0xE6AD18", Slot = "30")]
		public void LogDebug(string fmt, params object[] args)
		{
		}

		[Token(Token = "0x60001B5")]
		[Address(RVA = "0xE6AD5C", Offset = "0xE6AD5C", VA = "0xE6AD5C", Slot = "19")]
		public int AssignChannel(VoiceInfo v)
		{
			return default(int);
		}

		[Token(Token = "0x60001B6")]
		[Address(RVA = "0xE6AE44", Offset = "0xE6AE44", VA = "0xE6AE44", Slot = "20")]
		public bool IsChannelJoined(int channelId)
		{
			return default(bool);
		}

		[Token(Token = "0x60001B7")]
		[Address(RVA = "0xE6AE54", Offset = "0xE6AE54", VA = "0xE6AE54", Slot = "26")]
		public void SetDebugEchoMode(LocalVoice v)
		{
		}

		[Token(Token = "0x60001BC")]
		[Address(RVA = "0xE6B2C0", Offset = "0xE6B2C0", VA = "0xE6B2C0")]
		public LoadBalancingFrontend(ConnectionProtocol connectionProtocol = ConnectionProtocol.Udp)
		{
		}

		[Token(Token = "0x60001BD")]
		[Address(RVA = "0xE6B584", Offset = "0xE6B584", VA = "0xE6B584")]
		public new void Service()
		{
		}

		[Token(Token = "0x60001BE")]
		[Address(RVA = "0xE6B6C4", Offset = "0xE6B6C4", VA = "0xE6B6C4", Slot = "32")]
		public virtual bool ChangeAudioGroups(byte[] groupsToRemove, byte[] groupsToAdd)
		{
			return default(bool);
		}

		[Token(Token = "0x60001C1")]
		[Address(RVA = "0xE6AF4C", Offset = "0xE6AF4C", VA = "0xE6AF4C", Slot = "21")]
		public void SendVoicesInfo(IEnumerable<LocalVoice> voices, int channelId, int targetPlayerId)
		{
		}

		[Token(Token = "0x60001C2")]
		[Address(RVA = "0xE6C264", Offset = "0xE6C264", VA = "0xE6C264")]
		public void SendDebugEchoVoicesInfo(int channelId)
		{
		}

		[Token(Token = "0x60001C3")]
		[Address(RVA = "0xE6B0EC", Offset = "0xE6B0EC", VA = "0xE6B0EC", Slot = "22")]
		public void SendVoiceRemove(LocalVoice voice, int channelId, int targetPlayerId)
		{
		}

		[Token(Token = "0x60001C4")]
		[Address(RVA = "0xE6C70C", Offset = "0xE6C70C", VA = "0xE6C70C", Slot = "23")]
		public void SendFrame(ArraySegment<byte> data, byte evNumber, byte voiceId, int channelId, LocalVoice localVoice)
		{
		}

		[Token(Token = "0x60001C5")]
		[Address(RVA = "0xE6C994", Offset = "0xE6C994", VA = "0xE6C994", Slot = "24")]
		public string ChannelIdStr(int channelId)
		{
			return null;
		}

		[Token(Token = "0x60001C6")]
		[Address(RVA = "0xE6C99C", Offset = "0xE6C99C", VA = "0xE6C99C", Slot = "25")]
		public string PlayerIdStr(int playerId)
		{
			return null;
		}

		[Token(Token = "0x60001C7")]
		[Address(RVA = "0xE6C9A4", Offset = "0xE6C9A4", VA = "0xE6C9A4")]
		private void onEventActionVoiceClient(EventData ev)
		{
		}

		[Token(Token = "0x60001C8")]
		[Address(RVA = "0xE6D620", Offset = "0xE6D620", VA = "0xE6D620")]
		private void onStateChangeVoiceClient(ClientState state)
		{
		}

		[Token(Token = "0x60001C9")]
		[Address(RVA = "0xE6D564", Offset = "0xE6D564", VA = "0xE6D564")]
		private void onPlayerLeave(int playerId)
		{
		}

		[Token(Token = "0x60001CA")]
		[Address(RVA = "0xE6D86C", Offset = "0xE6D86C", VA = "0xE6D86C", Slot = "31")]
		public void Dispose()
		{
		}
	}
	[Token(Token = "0x2000058")]
	public class AudioInEnumerator : IDisposable
	{
		[Token(Token = "0x4000141")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public readonly bool IsSupported;

		[Token(Token = "0x17000079")]
		public int Count
		{
			[Token(Token = "0x60001CD")]
			[Address(RVA = "0xE696F4", Offset = "0xE696F4", VA = "0xE696F4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x60001CB")]
		[Address(RVA = "0xE696E8", Offset = "0xE696E8", VA = "0xE696E8")]
		public AudioInEnumerator()
		{
		}

		[Token(Token = "0x60001CC")]
		[Address(RVA = "0xE696F0", Offset = "0xE696F0", VA = "0xE696F0")]
		public void Refresh()
		{
		}

		[Token(Token = "0x60001CE")]
		[Address(RVA = "0xE696FC", Offset = "0xE696FC", VA = "0xE696FC")]
		public string NameAtIndex(int i)
		{
			return null;
		}

		[Token(Token = "0x60001CF")]
		[Address(RVA = "0xE69704", Offset = "0xE69704", VA = "0xE69704")]
		public int IDAtIndex(int i)
		{
			return default(int);
		}

		[Token(Token = "0x60001D0")]
		[Address(RVA = "0xE6970C", Offset = "0xE6970C", VA = "0xE6970C")]
		public bool IDIsValid(int id)
		{
			return default(bool);
		}

		[Token(Token = "0x60001D1")]
		[Address(RVA = "0xE69718", Offset = "0xE69718", VA = "0xE69718", Slot = "4")]
		public void Dispose()
		{
		}
	}
}
namespace ExitGames.Client.Photon.LoadBalancing
{
	[Token(Token = "0x2000059")]
	public static class Extensions
	{
		[Token(Token = "0x60001D2")]
		[Address(RVA = "0xE5D798", Offset = "0xE5D798", VA = "0xE5D798")]
		public static void Merge(this IDictionary target, IDictionary addHash)
		{
		}

		[Token(Token = "0x60001D3")]
		[Address(RVA = "0xE5DB64", Offset = "0xE5DB64", VA = "0xE5DB64")]
		public static void MergeStringKeys(this IDictionary target, IDictionary addHash)
		{
		}

		[Token(Token = "0x60001D4")]
		[Address(RVA = "0xE5DF4C", Offset = "0xE5DF4C", VA = "0xE5DF4C")]
		public static string ToStringFull(this IDictionary origin)
		{
			return null;
		}

		[Token(Token = "0x60001D5")]
		[Address(RVA = "0xE5DFB8", Offset = "0xE5DFB8", VA = "0xE5DFB8")]
		public static string ToStringFull(this object[] data)
		{
			return null;
		}

		[Token(Token = "0x60001D6")]
		[Address(RVA = "0xE5E10C", Offset = "0xE5E10C", VA = "0xE5E10C")]
		public static Hashtable StripToStringKeys(this IDictionary original)
		{
			return null;
		}

		[Token(Token = "0x60001D7")]
		[Address(RVA = "0xE5E4A4", Offset = "0xE5E4A4", VA = "0xE5E4A4")]
		public static void StripKeysWithNullValues(this IDictionary original)
		{
		}

		[Token(Token = "0x60001D8")]
		[Address(RVA = "0xE5E774", Offset = "0xE5E774", VA = "0xE5E774")]
		public static bool Contains(this int[] target, int nr)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x200005A")]
	public class FriendInfo
	{
		[Token(Token = "0x4000142")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x981C4C", Offset = "0x981C4C")]
		private string <UserId>k__BackingField;

		[Token(Token = "0x4000143")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x981C5C", Offset = "0x981C5C")]
		private bool <IsOnline>k__BackingField;

		[Token(Token = "0x4000144")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x981C6C", Offset = "0x981C6C")]
		private string <Room>k__BackingField;

		[Token(Token = "0x1700007A")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x984818", Offset = "0x984818")]
		public string Name
		{
			[Token(Token = "0x60001D9")]
			[Address(RVA = "0xE5E7D0", Offset = "0xE5E7D0", VA = "0xE5E7D0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700007B")]
		public string UserId
		{
			[Token(Token = "0x60001DA")]
			[Address(RVA = "0xE5E7D8", Offset = "0xE5E7D8", VA = "0xE5E7D8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x983554", Offset = "0x983554")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001DB")]
			[Address(RVA = "0xE5E7E0", Offset = "0xE5E7E0", VA = "0xE5E7E0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x983564", Offset = "0x983564")]
			protected internal set
			{
			}
		}

		[Token(Token = "0x1700007C")]
		public bool IsOnline
		{
			[Token(Token = "0x60001DC")]
			[Address(RVA = "0xE5E7E8", Offset = "0xE5E7E8", VA = "0xE5E7E8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x983574", Offset = "0x983574")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60001DD")]
			[Address(RVA = "0xE5E7F0", Offset = "0xE5E7F0", VA = "0xE5E7F0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x983584", Offset = "0x983584")]
			protected internal set
			{
			}
		}

		[Token(Token = "0x1700007D")]
		public string Room
		{
			[Token(Token = "0x60001DE")]
			[Address(RVA = "0xE5E7FC", Offset = "0xE5E7FC", VA = "0xE5E7FC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x983594", Offset = "0x983594")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001DF")]
			[Address(RVA = "0xE5E804", Offset = "0xE5E804", VA = "0xE5E804")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9835A4", Offset = "0x9835A4")]
			protected internal set
			{
			}
		}

		[Token(Token = "0x1700007E")]
		public bool IsInRoom
		{
			[Token(Token = "0x60001E0")]
			[Address(RVA = "0xE5E80C", Offset = "0xE5E80C", VA = "0xE5E80C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60001E1")]
		[Address(RVA = "0xE5E838", Offset = "0xE5E838", VA = "0xE5E838", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x60001E2")]
		[Address(RVA = "0xE5E8D8", Offset = "0xE5E8D8", VA = "0xE5E8D8")]
		public FriendInfo()
		{
		}
	}
	[Token(Token = "0x200005B")]
	public enum ClientState
	{
		[Token(Token = "0x4000146")]
		PeerCreated = 0,
		[Token(Token = "0x4000147")]
		Authenticating = 1,
		[Token(Token = "0x4000148")]
		Authenticated = 2,
		[Token(Token = "0x4000149")]
		JoinedLobby = 3,
		[Token(Token = "0x400014A")]
		DisconnectingFromMasterserver = 4,
		[Token(Token = "0x400014B")]
		ConnectingToGameserver = 5,
		[Token(Token = "0x400014C")]
		ConnectedToGameserver = 6,
		[Token(Token = "0x400014D")]
		Joining = 7,
		[Token(Token = "0x400014E")]
		Joined = 8,
		[Token(Token = "0x400014F")]
		Leaving = 9,
		[Token(Token = "0x4000150")]
		DisconnectingFromGameserver = 10,
		[Token(Token = "0x4000151")]
		ConnectingToMasterserver = 11,
		[Token(Token = "0x4000152")]
		Disconnecting = 12,
		[Token(Token = "0x4000153")]
		Disconnected = 13,
		[Token(Token = "0x4000154")]
		ConnectedToMasterserver = 14,
		[Token(Token = "0x4000155")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x981C7C", Offset = "0x981C7C")]
		ConnectedToMaster = 14,
		[Token(Token = "0x4000156")]
		ConnectingToNameServer = 15,
		[Token(Token = "0x4000157")]
		ConnectedToNameServer = 16,
		[Token(Token = "0x4000158")]
		DisconnectingFromNameServer = 17
	}
	[Token(Token = "0x200005C")]
	internal enum JoinType
	{
		[Token(Token = "0x400015A")]
		CreateRoom,
		[Token(Token = "0x400015B")]
		JoinRoom,
		[Token(Token = "0x400015C")]
		JoinRandomRoom,
		[Token(Token = "0x400015D")]
		JoinOrCreateRoom
	}
	[Token(Token = "0x200005D")]
	public enum DisconnectCause
	{
		[Token(Token = "0x400015F")]
		None,
		[Token(Token = "0x4000160")]
		DisconnectByServerUserLimit,
		[Token(Token = "0x4000161")]
		ExceptionOnConnect,
		[Token(Token = "0x4000162")]
		DisconnectByServer,
		[Token(Token = "0x4000163")]
		TimeoutDisconnect,
		[Token(Token = "0x4000164")]
		Exception,
		[Token(Token = "0x4000165")]
		InvalidAuthentication,
		[Token(Token = "0x4000166")]
		MaxCcuReached,
		[Token(Token = "0x4000167")]
		InvalidRegion,
		[Token(Token = "0x4000168")]
		OperationNotAllowedInCurrentState,
		[Token(Token = "0x4000169")]
		CustomAuthenticationFailed,
		[Token(Token = "0x400016A")]
		DisconnectByServerLogic,
		[Token(Token = "0x400016B")]
		AuthenticationTicketExpired
	}
	[Token(Token = "0x200005E")]
	public enum ServerConnection
	{
		[Token(Token = "0x400016D")]
		MasterServer,
		[Token(Token = "0x400016E")]
		GameServer,
		[Token(Token = "0x400016F")]
		NameServer
	}
	[Token(Token = "0x200005F")]
	public enum EncryptionMode
	{
		[Token(Token = "0x4000171")]
		PayloadEncryption = 0,
		[Token(Token = "0x4000172")]
		DatagramEncryption = 10,
		[Token(Token = "0x4000173")]
		DatagramEncryptionRandomSequence = 11
	}
	[Token(Token = "0x2000060")]
	public static class EncryptionDataParameters
	{
		[Token(Token = "0x4000174")]
		public const byte Mode = 0;

		[Token(Token = "0x4000175")]
		public const byte Secret1 = 1;

		[Token(Token = "0x4000176")]
		public const byte Secret2 = 2;
	}
	[Token(Token = "0x2000061")]
	public class LoadBalancingClient : IPhotonPeerListener
	{
		[Token(Token = "0x4000177")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public LoadBalancingPeer loadBalancingPeer;

		[Token(Token = "0x4000178")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x981CB4", Offset = "0x981CB4")]
		private string <AppVersion>k__BackingField;

		[Token(Token = "0x4000179")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x981CC4", Offset = "0x981CC4")]
		private string <AppId>k__BackingField;

		[Token(Token = "0x400017A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x981CD4", Offset = "0x981CD4")]
		private AuthenticationValues <AuthValues>k__BackingField;

		[Token(Token = "0x400017B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public AuthModeOption AuthMode;

		[Token(Token = "0x400017C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public EncryptionMode EncryptionMode;

		[Token(Token = "0x400017D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private ConnectionProtocol ExpectedProtocol;

		[Token(Token = "0x400017E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x39")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x981CE4", Offset = "0x981CE4")]
		private bool <IsUsingNameServer>k__BackingField;

		[Token(Token = "0x400017F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public string NameServerHost;

		[Token(Token = "0x4000180")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public string NameServerHttp;

		[Token(Token = "0x4000181")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly Dictionary<ConnectionProtocol, int> ProtocolToNameServerPort;

		[Token(Token = "0x4000182")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x981CF4", Offset = "0x981CF4")]
		private string <MasterServerAddress>k__BackingField;

		[Token(Token = "0x4000183")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x981D04", Offset = "0x981D04")]
		private string <GameServerAddress>k__BackingField;

		[Token(Token = "0x4000184")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x981D14", Offset = "0x981D14")]
		private ServerConnection <Server>k__BackingField;

		[Token(Token = "0x4000185")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private ClientState state;

		[Token(Token = "0x4000189")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x981D54", Offset = "0x981D54")]
		private DisconnectCause <DisconnectedCause>k__BackingField;

		[Token(Token = "0x400018A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private bool inLobby;

		[Token(Token = "0x400018B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x981D64", Offset = "0x981D64")]
		private TypedLobby <CurrentLobby>k__BackingField;

		[Token(Token = "0x400018C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private bool autoJoinLobby;

		[Token(Token = "0x400018D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x91")]
		public bool EnableLobbyStatistics;

		[Token(Token = "0x400018E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private List<TypedLobbyInfo> lobbyStatistics;

		[Token(Token = "0x400018F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x981D74", Offset = "0x981D74")]
		private Player <LocalPlayer>k__BackingField;

		[Token(Token = "0x4000190")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public Dictionary<string, RoomInfo> RoomInfoList;

		[Token(Token = "0x4000191")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public Room CurrentRoom;

		[Token(Token = "0x4000192")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x981D84", Offset = "0x981D84")]
		private int <PlayersOnMasterCount>k__BackingField;

		[Token(Token = "0x4000193")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x981D94", Offset = "0x981D94")]
		private int <PlayersInRoomsCount>k__BackingField;

		[Token(Token = "0x4000194")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x981DA4", Offset = "0x981DA4")]
		private int <RoomsCount>k__BackingField;

		[Token(Token = "0x4000195")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private JoinType lastJoinType;

		[Token(Token = "0x4000196")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		protected internal EnterRoomParams enterRoomParamsCache;

		[Token(Token = "0x4000197")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private bool didAuthenticate;

		[Token(Token = "0x4000198")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x981DB4", Offset = "0x981DB4")]
		private List<FriendInfo> <FriendList>k__BackingField;

		[Token(Token = "0x4000199")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private string[] friendListRequested;

		[Token(Token = "0x400019A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private int friendListTimestamp;

		[Token(Token = "0x400019B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
		private bool isFetchingFriendList;

		[Token(Token = "0x400019C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x981DC4", Offset = "0x981DC4")]
		private string[] <AvailableRegions>k__BackingField;

		[Token(Token = "0x400019D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x981DD4", Offset = "0x981DD4")]
		private string[] <AvailableRegionsServers>k__BackingField;

		[Token(Token = "0x400019E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x981DE4", Offset = "0x981DE4")]
		private string <CloudRegion>k__BackingField;

		[Token(Token = "0x400019F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private byte[] encryptionSecret;

		[Token(Token = "0x1700007F")]
		public string AppVersion
		{
			[Token(Token = "0x60001E3")]
			[Address(RVA = "0xE5E8E8", Offset = "0xE5E8E8", VA = "0xE5E8E8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9835B4", Offset = "0x9835B4")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001E4")]
			[Address(RVA = "0xE5E8F0", Offset = "0xE5E8F0", VA = "0xE5E8F0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9835C4", Offset = "0x9835C4")]
			set
			{
			}
		}

		[Token(Token = "0x17000080")]
		public string AppId
		{
			[Token(Token = "0x60001E5")]
			[Address(RVA = "0xE5E8F8", Offset = "0xE5E8F8", VA = "0xE5E8F8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9835D4", Offset = "0x9835D4")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001E6")]
			[Address(RVA = "0xE5E900", Offset = "0xE5E900", VA = "0xE5E900")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9835E4", Offset = "0x9835E4")]
			set
			{
			}
		}

		[Token(Token = "0x17000081")]
		public AuthenticationValues AuthValues
		{
			[Token(Token = "0x60001E7")]
			[Address(RVA = "0xE5E908", Offset = "0xE5E908", VA = "0xE5E908")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9835F4", Offset = "0x9835F4")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001E8")]
			[Address(RVA = "0xE5E910", Offset = "0xE5E910", VA = "0xE5E910")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x983604", Offset = "0x983604")]
			set
			{
			}
		}

		[Token(Token = "0x17000082")]
		public ConnectionProtocol TransportProtocol
		{
			[Token(Token = "0x60001E9")]
			[Address(RVA = "0xE5E918", Offset = "0xE5E918", VA = "0xE5E918")]
			get
			{
				return default(ConnectionProtocol);
			}
			[Token(Token = "0x60001EA")]
			[Address(RVA = "0xE5E934", Offset = "0xE5E934", VA = "0xE5E934")]
			set
			{
			}
		}

		[Token(Token = "0x17000083")]
		public Dictionary<ConnectionProtocol, Type> SocketImplementationConfig
		{
			[Token(Token = "0x60001EB")]
			[Address(RVA = "0xE5EA48", Offset = "0xE5EA48", VA = "0xE5EA48")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000084")]
		private string TokenForInit
		{
			[Token(Token = "0x60001EC")]
			[Address(RVA = "0xE5EA64", Offset = "0xE5EA64", VA = "0xE5EA64")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000085")]
		public bool IsUsingNameServer
		{
			[Token(Token = "0x60001ED")]
			[Address(RVA = "0xE5EA84", Offset = "0xE5EA84", VA = "0xE5EA84")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x983614", Offset = "0x983614")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60001EE")]
			[Address(RVA = "0xE5EA8C", Offset = "0xE5EA8C", VA = "0xE5EA8C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x983624", Offset = "0x983624")]
			protected internal set
			{
			}
		}

		[Token(Token = "0x17000086")]
		public string NameServerAddress
		{
			[Token(Token = "0x60001EF")]
			[Address(RVA = "0xE5EA98", Offset = "0xE5EA98", VA = "0xE5EA98")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000087")]
		public string CurrentServerAddress
		{
			[Token(Token = "0x60001F0")]
			[Address(RVA = "0xE5EC28", Offset = "0xE5EC28", VA = "0xE5EC28")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000088")]
		public string MasterServerAddress
		{
			[Token(Token = "0x60001F1")]
			[Address(RVA = "0xE5EC44", Offset = "0xE5EC44", VA = "0xE5EC44")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x983634", Offset = "0x983634")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001F2")]
			[Address(RVA = "0xE5EC4C", Offset = "0xE5EC4C", VA = "0xE5EC4C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x983644", Offset = "0x983644")]
			protected internal set
			{
			}
		}

		[Token(Token = "0x17000089")]
		public string GameServerAddress
		{
			[Token(Token = "0x60001F3")]
			[Address(RVA = "0xE5EC54", Offset = "0xE5EC54", VA = "0xE5EC54")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x983654", Offset = "0x983654")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001F4")]
			[Address(RVA = "0xE5EC5C", Offset = "0xE5EC5C", VA = "0xE5EC5C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x983664", Offset = "0x983664")]
			protected internal set
			{
			}
		}

		[Token(Token = "0x1700008A")]
		public ServerConnection Server
		{
			[Token(Token = "0x60001F5")]
			[Address(RVA = "0xE5EC64", Offset = "0xE5EC64", VA = "0xE5EC64")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x983674", Offset = "0x983674")]
			get
			{
				return default(ServerConnection);
			}
			[Token(Token = "0x60001F6")]
			[Address(RVA = "0xE5EC6C", Offset = "0xE5EC6C", VA = "0xE5EC6C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x983684", Offset = "0x983684")]
			private set
			{
			}
		}

		[Token(Token = "0x1700008B")]
		public ClientState State
		{
			[Token(Token = "0x60001F7")]
			[Address(RVA = "0xE5EC74", Offset = "0xE5EC74", VA = "0xE5EC74")]
			get
			{
				return default(ClientState);
			}
			[Token(Token = "0x60001F8")]
			[Address(RVA = "0xE5EC7C", Offset = "0xE5EC7C", VA = "0xE5EC7C")]
			protected internal set
			{
			}
		}

		[Token(Token = "0x1700008C")]
		public bool IsConnected
		{
			[Token(Token = "0x60001F9")]
			[Address(RVA = "0xE5ECF4", Offset = "0xE5ECF4", VA = "0xE5ECF4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700008D")]
		public bool IsConnectedAndReady
		{
			[Token(Token = "0x60001FA")]
			[Address(RVA = "0xE5ED20", Offset = "0xE5ED20", VA = "0xE5ED20")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700008E")]
		public DisconnectCause DisconnectedCause
		{
			[Token(Token = "0x6000201")]
			[Address(RVA = "0xE5F12C", Offset = "0xE5F12C", VA = "0xE5F12C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9836F4", Offset = "0x9836F4")]
			get
			{
				return default(DisconnectCause);
			}
			[Token(Token = "0x6000202")]
			[Address(RVA = "0xE5F134", Offset = "0xE5F134", VA = "0xE5F134")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x983704", Offset = "0x983704")]
			protected set
			{
			}
		}

		[Token(Token = "0x1700008F")]
		public TypedLobby CurrentLobby
		{
			[Token(Token = "0x6000203")]
			[Address(RVA = "0xE5F13C", Offset = "0xE5F13C", VA = "0xE5F13C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x983714", Offset = "0x983714")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000204")]
			[Address(RVA = "0xE5F144", Offset = "0xE5F144", VA = "0xE5F144")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x983724", Offset = "0x983724")]
			protected internal set
			{
			}
		}

		[Token(Token = "0x17000090")]
		public bool AutoJoinLobby
		{
			[Token(Token = "0x6000205")]
			[Address(RVA = "0xE5F14C", Offset = "0xE5F14C", VA = "0xE5F14C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000206")]
			[Address(RVA = "0xE5F154", Offset = "0xE5F154", VA = "0xE5F154")]
			set
			{
			}
		}

		[Token(Token = "0x17000091")]
		public List<TypedLobbyInfo> LobbyStatistics
		{
			[Token(Token = "0x6000207")]
			[Address(RVA = "0xE5F160", Offset = "0xE5F160", VA = "0xE5F160")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000208")]
			[Address(RVA = "0xE5F168", Offset = "0xE5F168", VA = "0xE5F168")]
			private set
			{
			}
		}

		[Token(Token = "0x17000092")]
		public Player LocalPlayer
		{
			[Token(Token = "0x6000209")]
			[Address(RVA = "0xE5F170", Offset = "0xE5F170", VA = "0xE5F170")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x983734", Offset = "0x983734")]
			get
			{
				return null;
			}
			[Token(Token = "0x600020A")]
			[Address(RVA = "0xE5F178", Offset = "0xE5F178", VA = "0xE5F178")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x983744", Offset = "0x983744")]
			internal set
			{
			}
		}

		[Token(Token = "0x17000093")]
		public string NickName
		{
			[Token(Token = "0x600020B")]
			[Address(RVA = "0xE5F180", Offset = "0xE5F180", VA = "0xE5F180")]
			get
			{
				return null;
			}
			[Token(Token = "0x600020C")]
			[Address(RVA = "0xE5F19C", Offset = "0xE5F19C", VA = "0xE5F19C")]
			set
			{
			}
		}

		[Token(Token = "0x17000094")]
		public string UserId
		{
			[Token(Token = "0x600020D")]
			[Address(RVA = "0xE5F224", Offset = "0xE5F224", VA = "0xE5F224")]
			get
			{
				return null;
			}
			[Token(Token = "0x600020E")]
			[Address(RVA = "0xE5F23C", Offset = "0xE5F23C", VA = "0xE5F23C")]
			set
			{
			}
		}

		[Token(Token = "0x17000095")]
		public int PlayersOnMasterCount
		{
			[Token(Token = "0x600020F")]
			[Address(RVA = "0xE5F2BC", Offset = "0xE5F2BC", VA = "0xE5F2BC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x983754", Offset = "0x983754")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000210")]
			[Address(RVA = "0xE5F2C4", Offset = "0xE5F2C4", VA = "0xE5F2C4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x983764", Offset = "0x983764")]
			internal set
			{
			}
		}

		[Token(Token = "0x17000096")]
		public int PlayersInRoomsCount
		{
			[Token(Token = "0x6000211")]
			[Address(RVA = "0xE5F2CC", Offset = "0xE5F2CC", VA = "0xE5F2CC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x983774", Offset = "0x983774")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000212")]
			[Address(RVA = "0xE5F2D4", Offset = "0xE5F2D4", VA = "0xE5F2D4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x983784", Offset = "0x983784")]
			internal set
			{
			}
		}

		[Token(Token = "0x17000097")]
		public int RoomsCount
		{
			[Token(Token = "0x6000213")]
			[Address(RVA = "0xE5F2DC", Offset = "0xE5F2DC", VA = "0xE5F2DC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x983794", Offset = "0x983794")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000214")]
			[Address(RVA = "0xE5F2E4", Offset = "0xE5F2E4", VA = "0xE5F2E4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9837A4", Offset = "0x9837A4")]
			internal set
			{
			}
		}

		[Token(Token = "0x17000098")]
		public List<FriendInfo> FriendList
		{
			[Token(Token = "0x6000215")]
			[Address(RVA = "0xE5F2EC", Offset = "0xE5F2EC", VA = "0xE5F2EC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9837B4", Offset = "0x9837B4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000216")]
			[Address(RVA = "0xE5F2F4", Offset = "0xE5F2F4", VA = "0xE5F2F4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9837C4", Offset = "0x9837C4")]
			private set
			{
			}
		}

		[Token(Token = "0x17000099")]
		public int FriendListAge
		{
			[Token(Token = "0x6000217")]
			[Address(RVA = "0xE5F2FC", Offset = "0xE5F2FC", VA = "0xE5F2FC")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700009A")]
		protected bool IsAuthorizeSecretAvailable
		{
			[Token(Token = "0x6000218")]
			[Address(RVA = "0xE5F340", Offset = "0xE5F340", VA = "0xE5F340")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700009B")]
		public string[] AvailableRegions
		{
			[Token(Token = "0x6000219")]
			[Address(RVA = "0xE5F36C", Offset = "0xE5F36C", VA = "0xE5F36C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9837D4", Offset = "0x9837D4")]
			get
			{
				return null;
			}
			[Token(Token = "0x600021A")]
			[Address(RVA = "0xE5F374", Offset = "0xE5F374", VA = "0xE5F374")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9837E4", Offset = "0x9837E4")]
			private set
			{
			}
		}

		[Token(Token = "0x1700009C")]
		public string[] AvailableRegionsServers
		{
			[Token(Token = "0x600021B")]
			[Address(RVA = "0xE5F37C", Offset = "0xE5F37C", VA = "0xE5F37C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9837F4", Offset = "0x9837F4")]
			get
			{
				return null;
			}
			[Token(Token = "0x600021C")]
			[Address(RVA = "0xE5F384", Offset = "0xE5F384", VA = "0xE5F384")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x983804", Offset = "0x983804")]
			private set
			{
			}
		}

		[Token(Token = "0x1700009D")]
		public string CloudRegion
		{
			[Token(Token = "0x600021D")]
			[Address(RVA = "0xE5F38C", Offset = "0xE5F38C", VA = "0xE5F38C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x983814", Offset = "0x983814")]
			get
			{
				return null;
			}
			[Token(Token = "0x600021E")]
			[Address(RVA = "0xE5F394", Offset = "0xE5F394", VA = "0xE5F394")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x983824", Offset = "0x983824")]
			private set
			{
			}
		}

		[Token(Token = "0x14000002")]
		public event Action<ClientState> OnStateChangeAction
		{
			[Token(Token = "0x60001FB")]
			[Address(RVA = "0xE5ED54", Offset = "0xE5ED54", VA = "0xE5ED54")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x983694", Offset = "0x983694")]
			add
			{
			}
			[Token(Token = "0x60001FC")]
			[Address(RVA = "0xE5EDF8", Offset = "0xE5EDF8", VA = "0xE5EDF8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9836A4", Offset = "0x9836A4")]
			remove
			{
			}
		}

		[Token(Token = "0x14000003")]
		public event Action<EventData> OnEventAction
		{
			[Token(Token = "0x60001FD")]
			[Address(RVA = "0xE5EE9C", Offset = "0xE5EE9C", VA = "0xE5EE9C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9836B4", Offset = "0x9836B4")]
			add
			{
			}
			[Token(Token = "0x60001FE")]
			[Address(RVA = "0xE5EF40", Offset = "0xE5EF40", VA = "0xE5EF40")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9836C4", Offset = "0x9836C4")]
			remove
			{
			}
		}

		[Token(Token = "0x14000004")]
		public event Action<OperationResponse> OnOpResponseAction
		{
			[Token(Token = "0x60001FF")]
			[Address(RVA = "0xE5EFE4", Offset = "0xE5EFE4", VA = "0xE5EFE4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9836D4", Offset = "0x9836D4")]
			add
			{
			}
			[Token(Token = "0x6000200")]
			[Address(RVA = "0xE5F088", Offset = "0xE5F088", VA = "0xE5F088")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9836E4", Offset = "0x9836E4")]
			remove
			{
			}
		}

		[Token(Token = "0x600021F")]
		[Address(RVA = "0xE5F39C", Offset = "0xE5F39C", VA = "0xE5F39C")]
		public LoadBalancingClient(ConnectionProtocol protocol = ConnectionProtocol.Udp)
		{
		}

		[Token(Token = "0x6000220")]
		[Address(RVA = "0xE5F54C", Offset = "0xE5F54C", VA = "0xE5F54C")]
		public LoadBalancingClient(string masterAddress, string appId, string gameVersion, ConnectionProtocol protocol = ConnectionProtocol.Udp)
		{
		}

		[Token(Token = "0x6000221")]
		[Address(RVA = "0xE5EA9C", Offset = "0xE5EA9C", VA = "0xE5EA9C")]
		private string GetNameServerAddress()
		{
			return null;
		}

		[Token(Token = "0x6000222")]
		[Address(RVA = "0xE5F58C", Offset = "0xE5F58C", VA = "0xE5F58C")]
		public bool Connect(string masterServerAddress, string appId, string appVersion, string nickName, AuthenticationValues authValues)
		{
			return default(bool);
		}

		[Token(Token = "0x6000223")]
		[Address(RVA = "0xE5F638", Offset = "0xE5F638", VA = "0xE5F638", Slot = "8")]
		public virtual bool Connect()
		{
			return default(bool);
		}

		[Token(Token = "0x6000224")]
		[Address(RVA = "0xE5F6B4", Offset = "0xE5F6B4", VA = "0xE5F6B4")]
		public bool ConnectToNameServer()
		{
			return default(bool);
		}

		[Token(Token = "0x6000225")]
		[Address(RVA = "0xE5F794", Offset = "0xE5F794", VA = "0xE5F794")]
		public bool ConnectToRegionMaster(string region)
		{
			return default(bool);
		}

		[Token(Token = "0x6000226")]
		[Address(RVA = "0xE5F918", Offset = "0xE5F918", VA = "0xE5F918")]
		public void Disconnect()
		{
		}

		[Token(Token = "0x6000227")]
		[Address(RVA = "0xE5F89C", Offset = "0xE5F89C", VA = "0xE5F89C")]
		private bool CallAuthenticate()
		{
			return default(bool);
		}

		[Token(Token = "0x6000228")]
		[Address(RVA = "0xE5F968", Offset = "0xE5F968", VA = "0xE5F968")]
		public void Service()
		{
		}

		[Token(Token = "0x6000229")]
		[Address(RVA = "0xE5F980", Offset = "0xE5F980", VA = "0xE5F980")]
		private void DisconnectToReconnect()
		{
		}

		[Token(Token = "0x600022A")]
		[Address(RVA = "0xE5F9E4", Offset = "0xE5F9E4", VA = "0xE5F9E4")]
		private bool ConnectToGameServer()
		{
			return default(bool);
		}

		[Token(Token = "0x600022B")]
		[Address(RVA = "0xE5FA5C", Offset = "0xE5FA5C", VA = "0xE5FA5C")]
		public bool OpGetRegions()
		{
			return default(bool);
		}

		[Token(Token = "0x600022C")]
		[Address(RVA = "0xE5FAB8", Offset = "0xE5FAB8", VA = "0xE5FAB8")]
		public bool OpFindFriends(string[] friendsToFind)
		{
			return default(bool);
		}

		[Token(Token = "0x600022D")]
		[Address(RVA = "0xE5FD90", Offset = "0xE5FD90", VA = "0xE5FD90")]
		public bool OpJoinLobby(TypedLobby lobby)
		{
			return default(bool);
		}

		[Token(Token = "0x600022E")]
		[Address(RVA = "0xE5FE40", Offset = "0xE5FE40", VA = "0xE5FE40")]
		public bool OpLeaveLobby()
		{
			return default(bool);
		}

		[Token(Token = "0x600022F")]
		[Address(RVA = "0xE5FE64", Offset = "0xE5FE64", VA = "0xE5FE64")]
		public bool OpJoinRandomRoom(Hashtable expectedCustomRoomProperties, byte expectedMaxPlayers, [Optional] string[] expectedUsers)
		{
			return default(bool);
		}

		[Token(Token = "0x6000230")]
		[Address(RVA = "0xE60048", Offset = "0xE60048", VA = "0xE60048")]
		public bool OpJoinRandomRoom(Hashtable expectedCustomRoomProperties, byte expectedMaxPlayers, MatchmakingMode matchmakingMode)
		{
			return default(bool);
		}

		[Token(Token = "0x6000231")]
		[Address(RVA = "0xE5FF04", Offset = "0xE5FF04", VA = "0xE5FF04")]
		public bool OpJoinRandomRoom(Hashtable expectedCustomRoomProperties, byte expectedMaxPlayers, MatchmakingMode matchmakingMode, TypedLobby lobby, string sqlLobbyFilter, [Optional] string[] expectedUsers)
		{
			return default(bool);
		}

		[Token(Token = "0x6000232")]
		[Address(RVA = "0xE600F0", Offset = "0xE600F0", VA = "0xE600F0")]
		public bool OpJoinRoom(string roomName, [Optional] string[] expectedUsers)
		{
			return default(bool);
		}

		[Token(Token = "0x6000233")]
		[Address(RVA = "0xE601B8", Offset = "0xE601B8", VA = "0xE601B8")]
		public bool OpReJoinRoom(string roomName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000234")]
		[Address(RVA = "0xE6027C", Offset = "0xE6027C", VA = "0xE6027C")]
		public bool OpJoinOrCreateRoom(string roomName, RoomOptions roomOptions, TypedLobby lobby, [Optional] string[] expectedUsers)
		{
			return default(bool);
		}

		[Token(Token = "0x6000235")]
		[Address(RVA = "0xE60364", Offset = "0xE60364", VA = "0xE60364")]
		public bool OpCreateRoom(string roomName, RoomOptions roomOptions, TypedLobby lobby, [Optional] string[] expectedUsers)
		{
			return default(bool);
		}

		[Token(Token = "0x6000236")]
		[Address(RVA = "0xE60444", Offset = "0xE60444", VA = "0xE60444")]
		public bool OpLeaveRoom()
		{
			return default(bool);
		}

		[Token(Token = "0x6000237")]
		[Address(RVA = "0xE60450", Offset = "0xE60450", VA = "0xE60450")]
		public bool OpLeaveRoom(bool becomeInactive, bool sendAuthCookie = false)
		{
			return default(bool);
		}

		[Token(Token = "0x6000238")]
		[Address(RVA = "0xE604DC", Offset = "0xE604DC", VA = "0xE604DC")]
		public bool OpGetGameList(TypedLobby typedLobby, string sqlLobbyFilter)
		{
			return default(bool);
		}

		[Token(Token = "0x6000239")]
		[Address(RVA = "0xE60500", Offset = "0xE60500", VA = "0xE60500")]
		public bool OpSetCustomPropertiesOfActor(int actorNr, Hashtable propertiesToSet, [Optional] Hashtable expectedProperties, [Optional] WebFlags webFlags)
		{
			return default(bool);
		}

		[Token(Token = "0x600023A")]
		[Address(RVA = "0xE608A8", Offset = "0xE608A8", VA = "0xE608A8")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x983834", Offset = "0x983834")]
		public bool OpSetCustomPropertiesOfActor(int actorNr, Hashtable propertiesToSet, Hashtable expectedProperties, bool webForward)
		{
			return default(bool);
		}

		[Token(Token = "0x600023B")]
		[Address(RVA = "0xE60754", Offset = "0xE60754", VA = "0xE60754")]
		protected internal bool OpSetPropertiesOfActor(int actorNr, Hashtable actorProperties, [Optional] Hashtable expectedProperties, [Optional] WebFlags webFlags)
		{
			return default(bool);
		}

		[Token(Token = "0x600023C")]
		[Address(RVA = "0xE60C78", Offset = "0xE60C78", VA = "0xE60C78")]
		public bool OpSetCustomPropertiesOfRoom(Hashtable propertiesToSet, [Optional] Hashtable expectedProperties, [Optional] WebFlags webFlags)
		{
			return default(bool);
		}

		[Token(Token = "0x600023D")]
		[Address(RVA = "0xE60E38", Offset = "0xE60E38", VA = "0xE60E38")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x98386C", Offset = "0x98386C")]
		public bool OpSetCustomPropertiesOfRoom(Hashtable propertiesToSet, Hashtable expectedProperties, bool webForward)
		{
			return default(bool);
		}

		[Token(Token = "0x600023E")]
		[Address(RVA = "0xE60D0C", Offset = "0xE60D0C", VA = "0xE60D0C")]
		protected internal bool OpSetPropertiesOfRoom(Hashtable gameProperties, [Optional] Hashtable expectedProperties, [Optional] WebFlags webFlags)
		{
			return default(bool);
		}

		[Token(Token = "0x600023F")]
		[Address(RVA = "0xE610F8", Offset = "0xE610F8", VA = "0xE610F8", Slot = "9")]
		public virtual bool OpRaiseEvent(byte eventCode, object customEventContent, RaiseEventOptions raiseEventOptions, SendOptions sendOptions)
		{
			return default(bool);
		}

		[Token(Token = "0x6000240")]
		[Address(RVA = "0xE61114", Offset = "0xE61114", VA = "0xE61114", Slot = "10")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x9838A4", Offset = "0x9838A4")]
		public virtual bool OpRaiseEvent(byte eventCode, object customEventContent, bool sendReliable, RaiseEventOptions raiseEventOptions)
		{
			return default(bool);
		}

		[Token(Token = "0x6000241")]
		[Address(RVA = "0xE611A8", Offset = "0xE611A8", VA = "0xE611A8", Slot = "11")]
		public virtual bool OpChangeGroups(byte[] groupsToRemove, byte[] groupsToAdd)
		{
			return default(bool);
		}

		[Token(Token = "0x6000242")]
		[Address(RVA = "0xE611C4", Offset = "0xE611C4", VA = "0xE611C4")]
		private void ReadoutProperties(Hashtable gameProperties, Hashtable actorProperties, int targetActorNr)
		{
		}

		[Token(Token = "0x6000243")]
		[Address(RVA = "0xE61528", Offset = "0xE61528", VA = "0xE61528")]
		private Hashtable ReadoutPropertiesForActorNr(Hashtable actorProperties, int actorNr)
		{
			return null;
		}

		[Token(Token = "0x6000244")]
		[Address(RVA = "0xE61618", Offset = "0xE61618", VA = "0xE61618")]
		protected internal void ChangeLocalID(int newID)
		{
		}

		[Token(Token = "0x6000245")]
		[Address(RVA = "0xE6176C", Offset = "0xE6176C", VA = "0xE6176C")]
		private void CleanCachedValues()
		{
		}

		[Token(Token = "0x6000246")]
		[Address(RVA = "0xE61814", Offset = "0xE61814", VA = "0xE61814")]
		private void GameEnteredOnGameServer(OperationResponse operationResponse)
		{
		}

		[Token(Token = "0x6000247")]
		[Address(RVA = "0xE61A20", Offset = "0xE61A20", VA = "0xE61A20")]
		private void UpdatedActorList(int[] actorsInGame)
		{
		}

		[Token(Token = "0x6000248")]
		[Address(RVA = "0xE61B2C", Offset = "0xE61B2C", VA = "0xE61B2C", Slot = "12")]
		protected internal virtual Player CreatePlayer(string actorName, int actorNumber, bool isLocal, Hashtable actorProperties)
		{
			return null;
		}

		[Token(Token = "0x6000249")]
		[Address(RVA = "0xE61C70", Offset = "0xE61C70", VA = "0xE61C70", Slot = "13")]
		protected internal virtual Room CreateRoom(string roomName, RoomOptions opt)
		{
			return null;
		}

		[Token(Token = "0x600024A")]
		[Address(RVA = "0xE61DB8", Offset = "0xE61DB8", VA = "0xE61DB8", Slot = "14")]
		public virtual void DebugReturn(DebugLevel level, string message)
		{
		}

		[Token(Token = "0x600024B")]
		[Address(RVA = "0xE61EF4", Offset = "0xE61EF4", VA = "0xE61EF4", Slot = "15")]
		public virtual void OnOperationResponse(OperationResponse operationResponse)
		{
		}

		[Token(Token = "0x600024C")]
		[Address(RVA = "0xE62E38", Offset = "0xE62E38", VA = "0xE62E38", Slot = "16")]
		public virtual void OnStatusChanged(StatusCode statusCode)
		{
		}

		[Token(Token = "0x600024D")]
		[Address(RVA = "0xE633C8", Offset = "0xE633C8", VA = "0xE633C8", Slot = "17")]
		public virtual void OnEvent(EventData photonEvent)
		{
		}

		[Token(Token = "0x600024E")]
		[Address(RVA = "0xE63DD0", Offset = "0xE63DD0", VA = "0xE63DD0", Slot = "18")]
		public virtual void OnMessage(object message)
		{
		}

		[Token(Token = "0x600024F")]
		[Address(RVA = "0xE62AFC", Offset = "0xE62AFC", VA = "0xE62AFC")]
		private void SetupEncryption(Dictionary<byte, object> encryptionData)
		{
		}

		[Token(Token = "0x6000250")]
		[Address(RVA = "0xE63E4C", Offset = "0xE63E4C", VA = "0xE63E4C")]
		public bool OpWebRpc(string uriPath, object parameters, bool sendAuthCookie = false)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x2000062")]
	public class LoadBalancingPeer : PhotonPeer
	{
		[Token(Token = "0x20000E5")]
		private enum RoomOptionBit
		{
			[Token(Token = "0x40006F5")]
			CheckUserOnJoin = 1,
			[Token(Token = "0x40006F6")]
			DeleteCacheOnLeave = 2,
			[Token(Token = "0x40006F7")]
			SuppressRoomEvents = 4,
			[Token(Token = "0x40006F8")]
			PublishUserId = 8,
			[Token(Token = "0x40006F9")]
			DeleteNullProps = 0x10,
			[Token(Token = "0x40006FA")]
			BroadcastPropsChangeToAll = 0x20
		}

		[Token(Token = "0x40001A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		protected internal static Type PingImplementation;

		[Token(Token = "0x40001A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private readonly Dictionary<byte, object> opParameters;

		[Token(Token = "0x6000252")]
		[Address(RVA = "0xE64058", Offset = "0xE64058", VA = "0xE64058")]
		public LoadBalancingPeer(ConnectionProtocol protocolType)
		{
		}

		[Token(Token = "0x6000253")]
		[Address(RVA = "0xE5F4CC", Offset = "0xE5F4CC", VA = "0xE5F4CC")]
		public LoadBalancingPeer(IPhotonPeerListener listener, ConnectionProtocol protocolType)
		{
		}

		[Token(Token = "0x6000254")]
		[Address(RVA = "0xE64100", Offset = "0xE64100", VA = "0xE64100")]
		[AttributeAttribute(Name = "ConditionalAttribute", RVA = "0x9838DC", Offset = "0x9838DC")]
		private void ConfigUnitySockets()
		{
		}

		[Token(Token = "0x6000255")]
		[Address(RVA = "0xE6438C", Offset = "0xE6438C", VA = "0xE6438C", Slot = "16")]
		public virtual bool OpGetRegions(string appId)
		{
			return default(bool);
		}

		[Token(Token = "0x6000256")]
		[Address(RVA = "0xE64464", Offset = "0xE64464", VA = "0xE64464", Slot = "17")]
		public virtual bool OpJoinLobby([Optional] TypedLobby lobby)
		{
			return default(bool);
		}

		[Token(Token = "0x6000257")]
		[Address(RVA = "0xE64640", Offset = "0xE64640", VA = "0xE64640", Slot = "18")]
		public virtual bool OpLeaveLobby()
		{
			return default(bool);
		}

		[Token(Token = "0x6000258")]
		[Address(RVA = "0xE64758", Offset = "0xE64758", VA = "0xE64758")]
		private void RoomOptionsToOpParameters(Dictionary<byte, object> op, RoomOptions roomOptions)
		{
		}

		[Token(Token = "0x6000259")]
		[Address(RVA = "0xE64BB4", Offset = "0xE64BB4", VA = "0xE64BB4", Slot = "19")]
		public virtual bool OpCreateRoom(EnterRoomParams opParams)
		{
			return default(bool);
		}

		[Token(Token = "0x600025A")]
		[Address(RVA = "0xE64E58", Offset = "0xE64E58", VA = "0xE64E58", Slot = "20")]
		public virtual bool OpJoinRoom(EnterRoomParams opParams)
		{
			return default(bool);
		}

		[Token(Token = "0x600025B")]
		[Address(RVA = "0xE65168", Offset = "0xE65168", VA = "0xE65168", Slot = "21")]
		public virtual bool OpJoinRandomRoom(OpJoinRandomRoomParams opJoinRandomRoomParams)
		{
			return default(bool);
		}

		[Token(Token = "0x600025C")]
		[Address(RVA = "0xE6548C", Offset = "0xE6548C", VA = "0xE6548C", Slot = "22")]
		public virtual bool OpLeaveRoom(bool becomeInactive, bool sendAuthCookie = false)
		{
			return default(bool);
		}

		[Token(Token = "0x600025D")]
		[Address(RVA = "0xE655C8", Offset = "0xE655C8", VA = "0xE655C8", Slot = "23")]
		public virtual bool OpGetGameList(TypedLobby lobby, string queryData)
		{
			return default(bool);
		}

		[Token(Token = "0x600025E")]
		[Address(RVA = "0xE6588C", Offset = "0xE6588C", VA = "0xE6588C", Slot = "24")]
		public virtual bool OpFindFriends(string[] friendsToFind)
		{
			return default(bool);
		}

		[Token(Token = "0x600025F")]
		[Address(RVA = "0xE65968", Offset = "0xE65968", VA = "0xE65968")]
		public bool OpSetCustomPropertiesOfActor(int actorNr, Hashtable actorProperties)
		{
			return default(bool);
		}

		[Token(Token = "0x6000260")]
		[Address(RVA = "0xE60984", Offset = "0xE60984", VA = "0xE60984")]
		protected internal bool OpSetPropertiesOfActor(int actorNr, Hashtable actorProperties, [Optional] Hashtable expectedProperties, [Optional] WebFlags webflags)
		{
			return default(bool);
		}

		[Token(Token = "0x6000261")]
		[Address(RVA = "0xE659B0", Offset = "0xE659B0", VA = "0xE659B0")]
		protected void OpSetPropertyOfRoom(byte propCode, object value)
		{
		}

		[Token(Token = "0x6000262")]
		[Address(RVA = "0xE65A6C", Offset = "0xE65A6C", VA = "0xE65A6C")]
		public bool OpSetCustomPropertiesOfRoom(Hashtable gameProperties)
		{
			return default(bool);
		}

		[Token(Token = "0x6000263")]
		[Address(RVA = "0xE60EE0", Offset = "0xE60EE0", VA = "0xE60EE0")]
		protected internal bool OpSetPropertiesOfRoom(Hashtable gameProperties, [Optional] Hashtable expectedProperties, [Optional] WebFlags webflags)
		{
			return default(bool);
		}

		[Token(Token = "0x6000264")]
		[Address(RVA = "0xE65AA0", Offset = "0xE65AA0", VA = "0xE65AA0", Slot = "25")]
		public virtual bool OpAuthenticate(string appId, string appVersion, AuthenticationValues authValues, string regionCode, bool getLobbyStatistics)
		{
			return default(bool);
		}

		[Token(Token = "0x6000265")]
		[Address(RVA = "0xE65DB0", Offset = "0xE65DB0", VA = "0xE65DB0", Slot = "26")]
		public virtual bool OpAuthenticateOnce(string appId, string appVersion, AuthenticationValues authValues, string regionCode, EncryptionMode encryptionMode, ConnectionProtocol expectedProtocol)
		{
			return default(bool);
		}

		[Token(Token = "0x6000266")]
		[Address(RVA = "0xE660D4", Offset = "0xE660D4", VA = "0xE660D4", Slot = "27")]
		public virtual bool OpChangeGroups(byte[] groupsToRemove, byte[] groupsToAdd)
		{
			return default(bool);
		}

		[Token(Token = "0x6000267")]
		[Address(RVA = "0xE66268", Offset = "0xE66268", VA = "0xE66268", Slot = "28")]
		public virtual bool OpRaiseEvent(byte eventCode, object customEventContent, RaiseEventOptions raiseEventOptions, SendOptions sendOptions)
		{
			return default(bool);
		}

		[Token(Token = "0x6000268")]
		[Address(RVA = "0xE6648C", Offset = "0xE6648C", VA = "0xE6648C", Slot = "29")]
		public virtual bool OpSettings(bool receiveLobbyStats)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x2000063")]
	public class OpJoinRandomRoomParams
	{
		[Token(Token = "0x40001A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Hashtable ExpectedCustomRoomProperties;

		[Token(Token = "0x40001A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public byte ExpectedMaxPlayers;

		[Token(Token = "0x40001A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		public MatchmakingMode MatchingType;

		[Token(Token = "0x40001A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public TypedLobby TypedLobby;

		[Token(Token = "0x40001A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string SqlLobbyFilter;

		[Token(Token = "0x40001A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string[] ExpectedUsers;

		[Token(Token = "0x600026A")]
		[Address(RVA = "0xE600E8", Offset = "0xE600E8", VA = "0xE600E8")]
		public OpJoinRandomRoomParams()
		{
		}
	}
	[Token(Token = "0x2000064")]
	public class EnterRoomParams
	{
		[Token(Token = "0x40001A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string RoomName;

		[Token(Token = "0x40001A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public RoomOptions RoomOptions;

		[Token(Token = "0x40001AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public TypedLobby Lobby;

		[Token(Token = "0x40001AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Hashtable PlayerProperties;

		[Token(Token = "0x40001AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool OnGameServer;

		[Token(Token = "0x40001AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
		public bool CreateIfNotExists;

		[Token(Token = "0x40001AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x32")]
		public bool RejoinOnly;

		[Token(Token = "0x40001AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public string[] ExpectedUsers;

		[Token(Token = "0x600026B")]
		[Address(RVA = "0xE5D778", Offset = "0xE5D778", VA = "0xE5D778")]
		public EnterRoomParams()
		{
		}
	}
	[Token(Token = "0x2000065")]
	public class ErrorCode
	{
		[Token(Token = "0x40001B0")]
		public const int Ok = 0;

		[Token(Token = "0x40001B1")]
		public const int OperationNotAllowedInCurrentState = -3;

		[Token(Token = "0x40001B2")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x981DF4", Offset = "0x981DF4")]
		public const int InvalidOperationCode = -2;

		[Token(Token = "0x40001B3")]
		public const int InvalidOperation = -2;

		[Token(Token = "0x40001B4")]
		public const int InternalServerError = -1;

		[Token(Token = "0x40001B5")]
		public const int InvalidAuthentication = 32767;

		[Token(Token = "0x40001B6")]
		public const int GameIdAlreadyExists = 32766;

		[Token(Token = "0x40001B7")]
		public const int GameFull = 32765;

		[Token(Token = "0x40001B8")]
		public const int GameClosed = 32764;

		[Token(Token = "0x40001B9")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x981E2C", Offset = "0x981E2C")]
		public const int AlreadyMatched = 32763;

		[Token(Token = "0x40001BA")]
		public const int ServerFull = 32762;

		[Token(Token = "0x40001BB")]
		public const int UserBlocked = 32761;

		[Token(Token = "0x40001BC")]
		public const int NoRandomMatchFound = 32760;

		[Token(Token = "0x40001BD")]
		public const int GameDoesNotExist = 32758;

		[Token(Token = "0x40001BE")]
		public const int MaxCcuReached = 32757;

		[Token(Token = "0x40001BF")]
		public const int InvalidRegion = 32756;

		[Token(Token = "0x40001C0")]
		public const int CustomAuthenticationFailed = 32755;

		[Token(Token = "0x40001C1")]
		public const int AuthenticationTicketExpired = 32753;

		[Token(Token = "0x40001C2")]
		public const int PluginReportedError = 32752;

		[Token(Token = "0x40001C3")]
		public const int PluginMismatch = 32751;

		[Token(Token = "0x40001C4")]
		public const int JoinFailedPeerAlreadyJoined = 32750;

		[Token(Token = "0x40001C5")]
		public const int JoinFailedFoundInactiveJoiner = 32749;

		[Token(Token = "0x40001C6")]
		public const int JoinFailedWithRejoinerNotFound = 32748;

		[Token(Token = "0x40001C7")]
		public const int JoinFailedFoundExcludedUserId = 32747;

		[Token(Token = "0x40001C8")]
		public const int JoinFailedFoundActiveJoiner = 32746;

		[Token(Token = "0x40001C9")]
		public const int HttpLimitReached = 32745;

		[Token(Token = "0x40001CA")]
		public const int ExternalHttpCallFailed = 32744;

		[Token(Token = "0x40001CB")]
		public const int SlotError = 32742;

		[Token(Token = "0x40001CC")]
		public const int InvalidEncryptionParameters = 32741;

		[Token(Token = "0x600026C")]
		[Address(RVA = "0xE5D788", Offset = "0xE5D788", VA = "0xE5D788")]
		public ErrorCode()
		{
		}
	}
	[Token(Token = "0x2000066")]
	public class ActorProperties
	{
		[Token(Token = "0x40001CD")]
		public const byte PlayerName = byte.MaxValue;

		[Token(Token = "0x40001CE")]
		public const byte IsInactive = 254;

		[Token(Token = "0x40001CF")]
		public const byte UserId = 253;

		[Token(Token = "0x600026D")]
		[Address(RVA = "0xFFC83C", Offset = "0xFFC83C", VA = "0xFFC83C")]
		public ActorProperties()
		{
		}
	}
	[Token(Token = "0x2000067")]
	public class GamePropertyKey
	{
		[Token(Token = "0x40001D0")]
		public const byte MaxPlayers = byte.MaxValue;

		[Token(Token = "0x40001D1")]
		public const byte IsVisible = 254;

		[Token(Token = "0x40001D2")]
		public const byte IsOpen = 253;

		[Token(Token = "0x40001D3")]
		public const byte PlayerCount = 252;

		[Token(Token = "0x40001D4")]
		public const byte Removed = 251;

		[Token(Token = "0x40001D5")]
		public const byte PropsListedInLobby = 250;

		[Token(Token = "0x40001D6")]
		public const byte CleanupCacheOnLeave = 249;

		[Token(Token = "0x40001D7")]
		public const byte MasterClientId = 248;

		[Token(Token = "0x40001D8")]
		public const byte ExpectedUsers = 247;

		[Token(Token = "0x600026E")]
		[Address(RVA = "0xE5E8E0", Offset = "0xE5E8E0", VA = "0xE5E8E0")]
		public GamePropertyKey()
		{
		}
	}
	[Token(Token = "0x2000068")]
	public class EventCode
	{
		[Token(Token = "0x40001D9")]
		public const byte GameList = 230;

		[Token(Token = "0x40001DA")]
		public const byte GameListUpdate = 229;

		[Token(Token = "0x40001DB")]
		public const byte QueueState = 228;

		[Token(Token = "0x40001DC")]
		public const byte Match = 227;

		[Token(Token = "0x40001DD")]
		public const byte AppStats = 226;

		[Token(Token = "0x40001DE")]
		public const byte LobbyStats = 224;

		[Token(Token = "0x40001DF")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x981E64", Offset = "0x981E64")]
		public const byte AzureNodeInfo = 210;

		[Token(Token = "0x40001E0")]
		public const byte Join = byte.MaxValue;

		[Token(Token = "0x40001E1")]
		public const byte Leave = 254;

		[Token(Token = "0x40001E2")]
		public const byte PropertiesChanged = 253;

		[Token(Token = "0x40001E3")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x981E9C", Offset = "0x981E9C")]
		public const byte SetProperties = 253;

		[Token(Token = "0x40001E4")]
		public const byte ErrorInfo = 251;

		[Token(Token = "0x40001E5")]
		public const byte CacheSliceChanged = 250;

		[Token(Token = "0x40001E6")]
		public const byte AuthEvent = 223;

		[Token(Token = "0x600026F")]
		[Address(RVA = "0xE5D790", Offset = "0xE5D790", VA = "0xE5D790")]
		public EventCode()
		{
		}
	}
	[Token(Token = "0x2000069")]
	public class ParameterCode
	{
		[Token(Token = "0x40001E7")]
		public const byte SuppressRoomEvents = 237;

		[Token(Token = "0x40001E8")]
		public const byte EmptyRoomTTL = 236;

		[Token(Token = "0x40001E9")]
		public const byte PlayerTTL = 235;

		[Token(Token = "0x40001EA")]
		public const byte EventForward = 234;

		[Token(Token = "0x40001EB")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x981ED4", Offset = "0x981ED4")]
		public const byte IsComingBack = 233;

		[Token(Token = "0x40001EC")]
		public const byte IsInactive = 233;

		[Token(Token = "0x40001ED")]
		public const byte CheckUserOnJoin = 232;

		[Token(Token = "0x40001EE")]
		public const byte ExpectedValues = 231;

		[Token(Token = "0x40001EF")]
		public const byte Address = 230;

		[Token(Token = "0x40001F0")]
		public const byte PeerCount = 229;

		[Token(Token = "0x40001F1")]
		public const byte GameCount = 228;

		[Token(Token = "0x40001F2")]
		public const byte MasterPeerCount = 227;

		[Token(Token = "0x40001F3")]
		public const byte UserId = 225;

		[Token(Token = "0x40001F4")]
		public const byte ApplicationId = 224;

		[Token(Token = "0x40001F5")]
		public const byte Position = 223;

		[Token(Token = "0x40001F6")]
		public const byte MatchMakingType = 223;

		[Token(Token = "0x40001F7")]
		public const byte GameList = 222;

		[Token(Token = "0x40001F8")]
		public const byte Secret = 221;

		[Token(Token = "0x40001F9")]
		public const byte AppVersion = 220;

		[Token(Token = "0x40001FA")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x981F0C", Offset = "0x981F0C")]
		public const byte AzureNodeInfo = 210;

		[Token(Token = "0x40001FB")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x981F44", Offset = "0x981F44")]
		public const byte AzureLocalNodeId = 209;

		[Token(Token = "0x40001FC")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x981F7C", Offset = "0x981F7C")]
		public const byte AzureMasterNodeId = 208;

		[Token(Token = "0x40001FD")]
		public const byte RoomName = byte.MaxValue;

		[Token(Token = "0x40001FE")]
		public const byte Broadcast = 250;

		[Token(Token = "0x40001FF")]
		public const byte ActorList = 252;

		[Token(Token = "0x4000200")]
		public const byte ActorNr = 254;

		[Token(Token = "0x4000201")]
		public const byte PlayerProperties = 249;

		[Token(Token = "0x4000202")]
		public const byte CustomEventContent = 245;

		[Token(Token = "0x4000203")]
		public const byte Data = 245;

		[Token(Token = "0x4000204")]
		public const byte Code = 244;

		[Token(Token = "0x4000205")]
		public const byte GameProperties = 248;

		[Token(Token = "0x4000206")]
		public const byte Properties = 251;

		[Token(Token = "0x4000207")]
		public const byte TargetActorNr = 253;

		[Token(Token = "0x4000208")]
		public const byte ReceiverGroup = 246;

		[Token(Token = "0x4000209")]
		public const byte Cache = 247;

		[Token(Token = "0x400020A")]
		public const byte CleanupCacheOnLeave = 241;

		[Token(Token = "0x400020B")]
		public const byte Group = 240;

		[Token(Token = "0x400020C")]
		public const byte Remove = 239;

		[Token(Token = "0x400020D")]
		public const byte PublishUserId = 239;

		[Token(Token = "0x400020E")]
		public const byte Add = 238;

		[Token(Token = "0x400020F")]
		public const byte Info = 218;

		[Token(Token = "0x4000210")]
		public const byte ClientAuthenticationType = 217;

		[Token(Token = "0x4000211")]
		public const byte ClientAuthenticationParams = 216;

		[Token(Token = "0x4000212")]
		public const byte JoinMode = 215;

		[Token(Token = "0x4000213")]
		public const byte ClientAuthenticationData = 214;

		[Token(Token = "0x4000214")]
		public const byte MasterClientId = 203;

		[Token(Token = "0x4000215")]
		public const byte FindFriendsRequestList = 1;

		[Token(Token = "0x4000216")]
		public const byte FindFriendsResponseOnlineList = 1;

		[Token(Token = "0x4000217")]
		public const byte FindFriendsResponseRoomIdList = 2;

		[Token(Token = "0x4000218")]
		public const byte LobbyName = 213;

		[Token(Token = "0x4000219")]
		public const byte LobbyType = 212;

		[Token(Token = "0x400021A")]
		public const byte LobbyStats = 211;

		[Token(Token = "0x400021B")]
		public const byte Region = 210;

		[Token(Token = "0x400021C")]
		public const byte UriPath = 209;

		[Token(Token = "0x400021D")]
		public const byte WebRpcParameters = 208;

		[Token(Token = "0x400021E")]
		public const byte WebRpcReturnCode = 207;

		[Token(Token = "0x400021F")]
		public const byte WebRpcReturnMessage = 206;

		[Token(Token = "0x4000220")]
		public const byte CacheSliceIndex = 205;

		[Token(Token = "0x4000221")]
		public const byte Plugins = 204;

		[Token(Token = "0x4000222")]
		public const byte NickName = 202;

		[Token(Token = "0x4000223")]
		public const byte PluginName = 201;

		[Token(Token = "0x4000224")]
		public const byte PluginVersion = 200;

		[Token(Token = "0x4000225")]
		public const byte ExpectedProtocol = 195;

		[Token(Token = "0x4000226")]
		public const byte CustomInitData = 194;

		[Token(Token = "0x4000227")]
		public const byte EncryptionMode = 193;

		[Token(Token = "0x4000228")]
		public const byte EncryptionData = 192;

		[Token(Token = "0x4000229")]
		public const byte RoomOptionFlags = 191;

		[Token(Token = "0x6000270")]
		[Address(RVA = "0xE66640", Offset = "0xE66640", VA = "0xE66640")]
		public ParameterCode()
		{
		}
	}
	[Token(Token = "0x200006A")]
	public class OperationCode
	{
		[Token(Token = "0x400022A")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x981FB4", Offset = "0x981FB4")]
		public const byte ExchangeKeysForEncryption = 250;

		[Token(Token = "0x400022B")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x981FEC", Offset = "0x981FEC")]
		public const byte Join = byte.MaxValue;

		[Token(Token = "0x400022C")]
		public const byte AuthenticateOnce = 231;

		[Token(Token = "0x400022D")]
		public const byte Authenticate = 230;

		[Token(Token = "0x400022E")]
		public const byte JoinLobby = 229;

		[Token(Token = "0x400022F")]
		public const byte LeaveLobby = 228;

		[Token(Token = "0x4000230")]
		public const byte CreateGame = 227;

		[Token(Token = "0x4000231")]
		public const byte JoinGame = 226;

		[Token(Token = "0x4000232")]
		public const byte JoinRandomGame = 225;

		[Token(Token = "0x4000233")]
		public const byte Leave = 254;

		[Token(Token = "0x4000234")]
		public const byte RaiseEvent = 253;

		[Token(Token = "0x4000235")]
		public const byte SetProperties = 252;

		[Token(Token = "0x4000236")]
		public const byte GetProperties = 251;

		[Token(Token = "0x4000237")]
		public const byte ChangeGroups = 248;

		[Token(Token = "0x4000238")]
		public const byte FindFriends = 222;

		[Token(Token = "0x4000239")]
		public const byte GetLobbyStats = 221;

		[Token(Token = "0x400023A")]
		public const byte GetRegions = 220;

		[Token(Token = "0x400023B")]
		public const byte WebRpc = 219;

		[Token(Token = "0x400023C")]
		public const byte ServerSettings = 218;

		[Token(Token = "0x400023D")]
		public const byte GetGameList = 217;

		[Token(Token = "0x6000271")]
		[Address(RVA = "0xE66638", Offset = "0xE66638", VA = "0xE66638")]
		public OperationCode()
		{
		}
	}
	[Token(Token = "0x200006B")]
	public enum JoinMode : byte
	{
		[Token(Token = "0x400023F")]
		Default,
		[Token(Token = "0x4000240")]
		CreateIfNotExists,
		[Token(Token = "0x4000241")]
		JoinOrRejoin,
		[Token(Token = "0x4000242")]
		RejoinOnly
	}
	[Token(Token = "0x200006C")]
	public enum MatchmakingMode : byte
	{
		[Token(Token = "0x4000244")]
		FillRoom,
		[Token(Token = "0x4000245")]
		SerialMatching,
		[Token(Token = "0x4000246")]
		RandomMatching
	}
	[Token(Token = "0x200006D")]
	public enum ReceiverGroup : byte
	{
		[Token(Token = "0x4000248")]
		Others,
		[Token(Token = "0x4000249")]
		All,
		[Token(Token = "0x400024A")]
		MasterClient
	}
	[Token(Token = "0x200006E")]
	public enum EventCaching : byte
	{
		[Token(Token = "0x400024C")]
		DoNotCache = 0,
		[Token(Token = "0x400024D")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x981FFC", Offset = "0x981FFC")]
		MergeCache = 1,
		[Token(Token = "0x400024E")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x98200C", Offset = "0x98200C")]
		ReplaceCache = 2,
		[Token(Token = "0x400024F")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x98201C", Offset = "0x98201C")]
		RemoveCache = 3,
		[Token(Token = "0x4000250")]
		AddToRoomCache = 4,
		[Token(Token = "0x4000251")]
		AddToRoomCacheGlobal = 5,
		[Token(Token = "0x4000252")]
		RemoveFromRoomCache = 6,
		[Token(Token = "0x4000253")]
		RemoveFromRoomCacheForActorsLeft = 7,
		[Token(Token = "0x4000254")]
		SliceIncreaseIndex = 10,
		[Token(Token = "0x4000255")]
		SliceSetIndex = 11,
		[Token(Token = "0x4000256")]
		SlicePurgeIndex = 12,
		[Token(Token = "0x4000257")]
		SlicePurgeUpToIndex = 13
	}
	[Token(Token = "0x200006F")]
	[Flags]
	public enum PropertyTypeFlag : byte
	{
		[Token(Token = "0x4000259")]
		None = 0,
		[Token(Token = "0x400025A")]
		Game = 1,
		[Token(Token = "0x400025B")]
		Actor = 2,
		[Token(Token = "0x400025C")]
		GameAndActor = 3
	}
	[Token(Token = "0x2000070")]
	public class RoomOptions
	{
		[Token(Token = "0x400025D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private bool isVisible;

		[Token(Token = "0x400025E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11")]
		private bool isOpen;

		[Token(Token = "0x400025F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x12")]
		public byte MaxPlayers;

		[Token(Token = "0x4000260")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public int PlayerTtl;

		[Token(Token = "0x4000261")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int EmptyRoomTtl;

		[Token(Token = "0x4000262")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private bool cleanupCacheOnLeave;

		[Token(Token = "0x4000263")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Hashtable CustomRoomProperties;

		[Token(Token = "0x4000264")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string[] CustomRoomPropertiesForLobby;

		[Token(Token = "0x4000265")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string[] Plugins;

		[Token(Token = "0x4000266")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x98202C", Offset = "0x98202C")]
		private bool <SuppressRoomEvents>k__BackingField;

		[Token(Token = "0x4000267")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x39")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x98203C", Offset = "0x98203C")]
		private bool <PublishUserId>k__BackingField;

		[Token(Token = "0x4000268")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3A")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x98204C", Offset = "0x98204C")]
		private bool <DeleteNullProperties>k__BackingField;

		[Token(Token = "0x1700009E")]
		public bool IsVisible
		{
			[Token(Token = "0x6000272")]
			[Address(RVA = "0xE68EE4", Offset = "0xE68EE4", VA = "0xE68EE4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000273")]
			[Address(RVA = "0xE68EEC", Offset = "0xE68EEC", VA = "0xE68EEC")]
			set
			{
			}
		}

		[Token(Token = "0x1700009F")]
		public bool IsOpen
		{
			[Token(Token = "0x6000274")]
			[Address(RVA = "0xE68EF8", Offset = "0xE68EF8", VA = "0xE68EF8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000275")]
			[Address(RVA = "0xE68F00", Offset = "0xE68F00", VA = "0xE68F00")]
			set
			{
			}
		}

		[Token(Token = "0x170000A0")]
		public bool CleanupCacheOnLeave
		{
			[Token(Token = "0x6000276")]
			[Address(RVA = "0xE68F0C", Offset = "0xE68F0C", VA = "0xE68F0C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000277")]
			[Address(RVA = "0xE68F14", Offset = "0xE68F14", VA = "0xE68F14")]
			set
			{
			}
		}

		[Token(Token = "0x170000A1")]
		public bool SuppressRoomEvents
		{
			[Token(Token = "0x6000278")]
			[Address(RVA = "0xE68F20", Offset = "0xE68F20", VA = "0xE68F20")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x983914", Offset = "0x983914")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000279")]
			[Address(RVA = "0xE68F28", Offset = "0xE68F28", VA = "0xE68F28")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x983924", Offset = "0x983924")]
			set
			{
			}
		}

		[Token(Token = "0x170000A2")]
		public bool PublishUserId
		{
			[Token(Token = "0x600027A")]
			[Address(RVA = "0xE68F34", Offset = "0xE68F34", VA = "0xE68F34")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x983934", Offset = "0x983934")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600027B")]
			[Address(RVA = "0xE68F3C", Offset = "0xE68F3C", VA = "0xE68F3C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x983944", Offset = "0x983944")]
			set
			{
			}
		}

		[Token(Token = "0x170000A3")]
		public bool DeleteNullProperties
		{
			[Token(Token = "0x600027C")]
			[Address(RVA = "0xE68F48", Offset = "0xE68F48", VA = "0xE68F48")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x983954", Offset = "0x983954")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600027D")]
			[Address(RVA = "0xE68F50", Offset = "0xE68F50", VA = "0xE68F50")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x983964", Offset = "0x983964")]
			set
			{
			}
		}

		[Token(Token = "0x600027E")]
		[Address(RVA = "0xE64B44", Offset = "0xE64B44", VA = "0xE64B44")]
		public RoomOptions()
		{
		}
	}
	[Token(Token = "0x2000071")]
	public class RaiseEventOptions
	{
		[Token(Token = "0x4000269")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly RaiseEventOptions Default;

		[Token(Token = "0x400026A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public EventCaching CachingOption;

		[Token(Token = "0x400026B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11")]
		public byte InterestGroup;

		[Token(Token = "0x400026C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int[] TargetActors;

		[Token(Token = "0x400026D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ReceiverGroup Receivers;

		[Token(Token = "0x400026E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x98205C", Offset = "0x98205C")]
		public byte SequenceChannel;

		[Token(Token = "0x400026F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public WebFlags Flags;

		[Token(Token = "0x600027F")]
		[Address(RVA = "0xE67508", Offset = "0xE67508", VA = "0xE67508")]
		public RaiseEventOptions()
		{
		}
	}
	[Token(Token = "0x2000072")]
	public enum LobbyType : byte
	{
		[Token(Token = "0x4000271")]
		Default = 0,
		[Token(Token = "0x4000272")]
		SqlLobby = 2,
		[Token(Token = "0x4000273")]
		AsyncRandomLobby = 3
	}
	[Token(Token = "0x2000073")]
	public class TypedLobby
	{
		[Token(Token = "0x4000274")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string Name;

		[Token(Token = "0x4000275")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public LobbyType Type;

		[Token(Token = "0x4000276")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly TypedLobby Default;

		[Token(Token = "0x170000A4")]
		public bool IsDefault
		{
			[Token(Token = "0x6000281")]
			[Address(RVA = "0xE64624", Offset = "0xE64624", VA = "0xE64624")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000282")]
		[Address(RVA = "0xE68F5C", Offset = "0xE68F5C", VA = "0xE68F5C")]
		public TypedLobby()
		{
		}

		[Token(Token = "0x6000283")]
		[Address(RVA = "0xE68FC4", Offset = "0xE68FC4", VA = "0xE68FC4")]
		public TypedLobby(string name, LobbyType type)
		{
		}

		[Token(Token = "0x6000284")]
		[Address(RVA = "0xE69000", Offset = "0xE69000", VA = "0xE69000", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Token(Token = "0x2000074")]
	public class TypedLobbyInfo : TypedLobby
	{
		[Token(Token = "0x4000277")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public int PlayerCount;

		[Token(Token = "0x4000278")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public int RoomCount;

		[Token(Token = "0x6000286")]
		[Address(RVA = "0xE690E8", Offset = "0xE690E8", VA = "0xE690E8", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000287")]
		[Address(RVA = "0xE63D6C", Offset = "0xE63D6C", VA = "0xE63D6C")]
		public TypedLobbyInfo()
		{
		}
	}
	[Token(Token = "0x2000075")]
	public enum AuthModeOption
	{
		[Token(Token = "0x400027A")]
		Auth,
		[Token(Token = "0x400027B")]
		AuthOnce,
		[Token(Token = "0x400027C")]
		AuthOnceWss
	}
	[Token(Token = "0x2000076")]
	public enum CustomAuthenticationType : byte
	{
		[Token(Token = "0x400027E")]
		Custom = 0,
		[Token(Token = "0x400027F")]
		Steam = 1,
		[Token(Token = "0x4000280")]
		Facebook = 2,
		[Token(Token = "0x4000281")]
		Oculus = 3,
		[Token(Token = "0x4000282")]
		PlayStation = 4,
		[Token(Token = "0x4000283")]
		Xbox = 5,
		[Token(Token = "0x4000284")]
		None = byte.MaxValue
	}
	[Token(Token = "0x2000077")]
	public class AuthenticationValues
	{
		[Token(Token = "0x4000285")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private CustomAuthenticationType authType;

		[Token(Token = "0x4000286")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x982094", Offset = "0x982094")]
		private string <AuthGetParameters>k__BackingField;

		[Token(Token = "0x4000287")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9820A4", Offset = "0x9820A4")]
		private object <AuthPostData>k__BackingField;

		[Token(Token = "0x4000288")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9820B4", Offset = "0x9820B4")]
		private string <Token>k__BackingField;

		[Token(Token = "0x4000289")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9820C4", Offset = "0x9820C4")]
		private string <UserId>k__BackingField;

		[Token(Token = "0x170000A5")]
		public CustomAuthenticationType AuthType
		{
			[Token(Token = "0x6000288")]
			[Address(RVA = "0xFFC844", Offset = "0xFFC844", VA = "0xFFC844")]
			get
			{
				return default(CustomAuthenticationType);
			}
			[Token(Token = "0x6000289")]
			[Address(RVA = "0xFFC84C", Offset = "0xFFC84C", VA = "0xFFC84C")]
			set
			{
			}
		}

		[Token(Token = "0x170000A6")]
		public string AuthGetParameters
		{
			[Token(Token = "0x600028A")]
			[Address(RVA = "0xFFC854", Offset = "0xFFC854", VA = "0xFFC854")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x983974", Offset = "0x983974")]
			get
			{
				return null;
			}
			[Token(Token = "0x600028B")]
			[Address(RVA = "0xFFC85C", Offset = "0xFFC85C", VA = "0xFFC85C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x983984", Offset = "0x983984")]
			set
			{
			}
		}

		[Token(Token = "0x170000A7")]
		public object AuthPostData
		{
			[Token(Token = "0x600028C")]
			[Address(RVA = "0xFFC864", Offset = "0xFFC864", VA = "0xFFC864")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x983994", Offset = "0x983994")]
			get
			{
				return null;
			}
			[Token(Token = "0x600028D")]
			[Address(RVA = "0xFFC86C", Offset = "0xFFC86C", VA = "0xFFC86C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9839A4", Offset = "0x9839A4")]
			private set
			{
			}
		}

		[Token(Token = "0x170000A8")]
		public string Token
		{
			[Token(Token = "0x600028E")]
			[Address(RVA = "0xFFC874", Offset = "0xFFC874", VA = "0xFFC874")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9839B4", Offset = "0x9839B4")]
			get
			{
				return null;
			}
			[Token(Token = "0x600028F")]
			[Address(RVA = "0xFFC87C", Offset = "0xFFC87C", VA = "0xFFC87C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9839C4", Offset = "0x9839C4")]
			set
			{
			}
		}

		[Token(Token = "0x170000A9")]
		public string UserId
		{
			[Token(Token = "0x6000290")]
			[Address(RVA = "0xFFC884", Offset = "0xFFC884", VA = "0xFFC884")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9839D4", Offset = "0x9839D4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000291")]
			[Address(RVA = "0xFFC88C", Offset = "0xFFC88C", VA = "0xFFC88C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9839E4", Offset = "0x9839E4")]
			set
			{
			}
		}

		[Token(Token = "0x6000292")]
		[Address(RVA = "0xFFC894", Offset = "0xFFC894", VA = "0xFFC894")]
		public AuthenticationValues()
		{
		}

		[Token(Token = "0x6000293")]
		[Address(RVA = "0xFFC8A4", Offset = "0xFFC8A4", VA = "0xFFC8A4")]
		public AuthenticationValues(string userId)
		{
		}

		[Token(Token = "0x6000294")]
		[Address(RVA = "0xFFC8D8", Offset = "0xFFC8D8", VA = "0xFFC8D8", Slot = "4")]
		public virtual void SetAuthPostData(string stringData)
		{
		}

		[Token(Token = "0x6000295")]
		[Address(RVA = "0xFFC918", Offset = "0xFFC918", VA = "0xFFC918", Slot = "5")]
		public virtual void SetAuthPostData(byte[] byteData)
		{
		}

		[Token(Token = "0x6000296")]
		[Address(RVA = "0xFFC920", Offset = "0xFFC920", VA = "0xFFC920", Slot = "6")]
		public virtual void AddAuthParameter(string key, string value)
		{
		}

		[Token(Token = "0x6000297")]
		[Address(RVA = "0xFFCAD4", Offset = "0xFFCAD4", VA = "0xFFCAD4", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Token(Token = "0x2000078")]
	public abstract class PhotonPing : IDisposable
	{
		[Token(Token = "0x400028A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string DebugString;

		[Token(Token = "0x400028B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool Successful;

		[Token(Token = "0x400028C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		protected internal bool GotResult;

		[Token(Token = "0x400028D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		protected internal int PingLength;

		[Token(Token = "0x400028E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		protected internal byte[] PingBytes;

		[Token(Token = "0x400028F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		protected internal byte PingId;

		[Token(Token = "0x6000298")]
		[Address(RVA = "0xE66648", Offset = "0xE66648", VA = "0xE66648", Slot = "5")]
		public virtual bool StartPing(string ip)
		{
			return default(bool);
		}

		[Token(Token = "0x6000299")]
		[Address(RVA = "0xE666A8", Offset = "0xE666A8", VA = "0xE666A8", Slot = "6")]
		public virtual bool Done()
		{
			return default(bool);
		}

		[Token(Token = "0x600029A")]
		[Address(RVA = "0xE66708", Offset = "0xE66708", VA = "0xE66708", Slot = "7")]
		public virtual void Dispose()
		{
		}

		[Token(Token = "0x600029B")]
		[Address(RVA = "0xE66768", Offset = "0xE66768", VA = "0xE66768")]
		protected internal void Init()
		{
		}

		[Token(Token = "0x600029C")]
		[Address(RVA = "0xE667B4", Offset = "0xE667B4", VA = "0xE667B4")]
		protected PhotonPing()
		{
		}
	}
	[Token(Token = "0x2000079")]
	public class PingMono : PhotonPing
	{
		[Token(Token = "0x4000290")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Socket sock;

		[Token(Token = "0x600029D")]
		[Address(RVA = "0xE66844", Offset = "0xE66844", VA = "0xE66844", Slot = "5")]
		public override bool StartPing(string ip)
		{
			return default(bool);
		}

		[Token(Token = "0x600029E")]
		[Address(RVA = "0xE66AB8", Offset = "0xE66AB8", VA = "0xE66AB8", Slot = "6")]
		public override bool Done()
		{
			return default(bool);
		}

		[Token(Token = "0x600029F")]
		[Address(RVA = "0xE66BF0", Offset = "0xE66BF0", VA = "0xE66BF0", Slot = "7")]
		public override void Dispose()
		{
		}

		[Token(Token = "0x60002A0")]
		[Address(RVA = "0xE66CB8", Offset = "0xE66CB8", VA = "0xE66CB8")]
		public PingMono()
		{
		}
	}
	[Token(Token = "0x200007A")]
	public class Player
	{
		[Token(Token = "0x4000291")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9820D4", Offset = "0x9820D4")]
		private Room <RoomReference>k__BackingField;

		[Token(Token = "0x4000292")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private int actorID;

		[Token(Token = "0x4000293")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public readonly bool IsLocal;

		[Token(Token = "0x4000294")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private string nickName;

		[Token(Token = "0x4000295")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9820E4", Offset = "0x9820E4")]
		private string <UserId>k__BackingField;

		[Token(Token = "0x4000296")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9820F4", Offset = "0x9820F4")]
		private bool <IsInactive>k__BackingField;

		[Token(Token = "0x4000297")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x982104", Offset = "0x982104")]
		private Hashtable <CustomProperties>k__BackingField;

		[Token(Token = "0x4000298")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public object TagObject;

		[Token(Token = "0x170000AA")]
		protected internal Room RoomReference
		{
			[Token(Token = "0x60002A1")]
			[Address(RVA = "0xE66CBC", Offset = "0xE66CBC", VA = "0xE66CBC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9839F4", Offset = "0x9839F4")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002A2")]
			[Address(RVA = "0xE66CC4", Offset = "0xE66CC4", VA = "0xE66CC4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x983A04", Offset = "0x983A04")]
			set
			{
			}
		}

		[Token(Token = "0x170000AB")]
		public int ID
		{
			[Token(Token = "0x60002A3")]
			[Address(RVA = "0xE66CCC", Offset = "0xE66CCC", VA = "0xE66CCC")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170000AC")]
		public string NickName
		{
			[Token(Token = "0x60002A4")]
			[Address(RVA = "0xE66CD4", Offset = "0xE66CD4", VA = "0xE66CD4")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002A5")]
			[Address(RVA = "0xE5F1AC", Offset = "0xE5F1AC", VA = "0xE5F1AC")]
			set
			{
			}
		}

		[Token(Token = "0x170000AD")]
		public string UserId
		{
			[Token(Token = "0x60002A6")]
			[Address(RVA = "0xE66DB4", Offset = "0xE66DB4", VA = "0xE66DB4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x983A14", Offset = "0x983A14")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002A7")]
			[Address(RVA = "0xE66DBC", Offset = "0xE66DBC", VA = "0xE66DBC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x983A24", Offset = "0x983A24")]
			internal set
			{
			}
		}

		[Token(Token = "0x170000AE")]
		public bool IsMasterClient
		{
			[Token(Token = "0x60002A8")]
			[Address(RVA = "0xE66DC4", Offset = "0xE66DC4", VA = "0xE66DC4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000AF")]
		public bool IsInactive
		{
			[Token(Token = "0x60002A9")]
			[Address(RVA = "0xE66DE8", Offset = "0xE66DE8", VA = "0xE66DE8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x983A34", Offset = "0x983A34")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60002AA")]
			[Address(RVA = "0xE66DF0", Offset = "0xE66DF0", VA = "0xE66DF0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x983A44", Offset = "0x983A44")]
			set
			{
			}
		}

		[Token(Token = "0x170000B0")]
		public Hashtable CustomProperties
		{
			[Token(Token = "0x60002AB")]
			[Address(RVA = "0xE66DFC", Offset = "0xE66DFC", VA = "0xE66DFC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x983A54", Offset = "0x983A54")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002AC")]
			[Address(RVA = "0xE66E04", Offset = "0xE66E04", VA = "0xE66E04")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x983A64", Offset = "0x983A64")]
			private set
			{
			}
		}

		[Token(Token = "0x170000B1")]
		public Hashtable AllProperties
		{
			[Token(Token = "0x60002AD")]
			[Address(RVA = "0xE62CE8", Offset = "0xE62CE8", VA = "0xE62CE8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60002AE")]
		[Address(RVA = "0xE66E0C", Offset = "0xE66E0C", VA = "0xE66E0C")]
		protected internal Player(string nickName, int actorID, bool isLocal)
		{
		}

		[Token(Token = "0x60002AF")]
		[Address(RVA = "0xE61BB4", Offset = "0xE61BB4", VA = "0xE61BB4")]
		protected internal Player(string nickName, int actorID, bool isLocal, Hashtable playerProperties)
		{
		}

		[Token(Token = "0x60002B0")]
		[Address(RVA = "0xE66E18", Offset = "0xE66E18", VA = "0xE66E18")]
		public Player Get(int id)
		{
			return null;
		}

		[Token(Token = "0x60002B1")]
		[Address(RVA = "0xE66E30", Offset = "0xE66E30", VA = "0xE66E30")]
		public Player GetNext()
		{
			return null;
		}

		[Token(Token = "0x60002B2")]
		[Address(RVA = "0xE66FCC", Offset = "0xE66FCC", VA = "0xE66FCC")]
		public Player GetNextFor(Player currentPlayer)
		{
			return null;
		}

		[Token(Token = "0x60002B3")]
		[Address(RVA = "0xE66E38", Offset = "0xE66E38", VA = "0xE66E38")]
		public Player GetNextFor(int currentPlayerId)
		{
			return null;
		}

		[Token(Token = "0x60002B4")]
		[Address(RVA = "0xE66FE0", Offset = "0xE66FE0", VA = "0xE66FE0", Slot = "4")]
		public virtual void InternalCacheProperties(Hashtable properties)
		{
		}

		[Token(Token = "0x60002B5")]
		[Address(RVA = "0xE67220", Offset = "0xE67220", VA = "0xE67220", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x60002B6")]
		[Address(RVA = "0xE672AC", Offset = "0xE672AC", VA = "0xE672AC")]
		public string ToStringFull()
		{
			return null;
		}

		[Token(Token = "0x60002B7")]
		[Address(RVA = "0xE6743C", Offset = "0xE6743C", VA = "0xE6743C", Slot = "0")]
		public override bool Equals(object p)
		{
			return default(bool);
		}

		[Token(Token = "0x60002B8")]
		[Address(RVA = "0xE67500", Offset = "0xE67500", VA = "0xE67500", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x60002B9")]
		[Address(RVA = "0xE6175C", Offset = "0xE6175C", VA = "0xE6175C")]
		protected internal void ChangeLocalID(int newID)
		{
		}

		[Token(Token = "0x60002BA")]
		[Address(RVA = "0xE60664", Offset = "0xE60664", VA = "0xE60664")]
		public void SetCustomProperties(Hashtable propertiesToSet, [Optional] Hashtable expectedValues, [Optional] WebFlags webFlags)
		{
		}

		[Token(Token = "0x60002BB")]
		[Address(RVA = "0xE66CDC", Offset = "0xE66CDC", VA = "0xE66CDC")]
		private void SetPlayerNameProperty()
		{
		}
	}
	[Token(Token = "0x200007B")]
	public class Room : RoomInfo
	{
		[Token(Token = "0x4000299")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		protected internal int PlayerTTL;

		[Token(Token = "0x400029A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		protected internal int RoomTTL;

		[Token(Token = "0x400029B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x982114", Offset = "0x982114")]
		private LoadBalancingClient <LoadBalancingClient>k__BackingField;

		[Token(Token = "0x400029C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Dictionary<int, Player> players;

		[Token(Token = "0x170000B2")]
		protected internal LoadBalancingClient LoadBalancingClient
		{
			[Token(Token = "0x60002BC")]
			[Address(RVA = "0xE675E0", Offset = "0xE675E0", VA = "0xE675E0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x983A74", Offset = "0x983A74")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002BD")]
			[Address(RVA = "0xE675E8", Offset = "0xE675E8", VA = "0xE675E8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x983A84", Offset = "0x983A84")]
			set
			{
			}
		}

		[Token(Token = "0x170000B3")]
		public new string Name
		{
			[Token(Token = "0x60002BE")]
			[Address(RVA = "0xE675F0", Offset = "0xE675F0", VA = "0xE675F0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002BF")]
			[Address(RVA = "0xE675F8", Offset = "0xE675F8", VA = "0xE675F8")]
			internal set
			{
			}
		}

		[Token(Token = "0x170000B4")]
		public new bool IsOpen
		{
			[Token(Token = "0x60002C0")]
			[Address(RVA = "0xE67600", Offset = "0xE67600", VA = "0xE67600")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60002C1")]
			[Address(RVA = "0xE67608", Offset = "0xE67608", VA = "0xE67608")]
			set
			{
			}
		}

		[Token(Token = "0x170000B5")]
		public new bool IsVisible
		{
			[Token(Token = "0x60002C2")]
			[Address(RVA = "0xE6773C", Offset = "0xE6773C", VA = "0xE6773C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60002C3")]
			[Address(RVA = "0xE67744", Offset = "0xE67744", VA = "0xE67744")]
			set
			{
			}
		}

		[Token(Token = "0x170000B6")]
		public new byte MaxPlayers
		{
			[Token(Token = "0x60002C4")]
			[Address(RVA = "0xE67878", Offset = "0xE67878", VA = "0xE67878")]
			get
			{
				return default(byte);
			}
			[Token(Token = "0x60002C5")]
			[Address(RVA = "0xE67880", Offset = "0xE67880", VA = "0xE67880")]
			set
			{
			}
		}

		[Token(Token = "0x170000B7")]
		public new byte PlayerCount
		{
			[Token(Token = "0x60002C6")]
			[Address(RVA = "0xE679A8", Offset = "0xE679A8", VA = "0xE679A8")]
			get
			{
				return default(byte);
			}
		}

		[Token(Token = "0x170000B8")]
		public Dictionary<int, Player> Players
		{
			[Token(Token = "0x60002C7")]
			[Address(RVA = "0xE67A00", Offset = "0xE67A00", VA = "0xE67A00")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002C8")]
			[Address(RVA = "0xE67A08", Offset = "0xE67A08", VA = "0xE67A08")]
			private set
			{
			}
		}

		[Token(Token = "0x170000B9")]
		public string[] ExpectedUsers
		{
			[Token(Token = "0x60002C9")]
			[Address(RVA = "0xE67A10", Offset = "0xE67A10", VA = "0xE67A10")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000BA")]
		public int MasterClientId
		{
			[Token(Token = "0x60002CA")]
			[Address(RVA = "0xE67A18", Offset = "0xE67A18", VA = "0xE67A18")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170000BB")]
		public string[] PropertiesListedInLobby
		{
			[Token(Token = "0x60002CB")]
			[Address(RVA = "0xE67A20", Offset = "0xE67A20", VA = "0xE67A20")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002CC")]
			[Address(RVA = "0xE67A28", Offset = "0xE67A28", VA = "0xE67A28")]
			private set
			{
			}
		}

		[Token(Token = "0x170000BC")]
		public bool AutoCleanUp
		{
			[Token(Token = "0x60002CD")]
			[Address(RVA = "0xE67A30", Offset = "0xE67A30", VA = "0xE67A30")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60002CE")]
		[Address(RVA = "0xE61CE0", Offset = "0xE61CE0", VA = "0xE61CE0")]
		protected internal Room(string roomName, RoomOptions options)
		{
		}

		[Token(Token = "0x60002CF")]
		[Address(RVA = "0xE67A38", Offset = "0xE67A38", VA = "0xE67A38", Slot = "5")]
		public virtual void SetCustomProperties(Hashtable propertiesToSet, [Optional] Hashtable expectedProperties, [Optional] WebFlags webFlags)
		{
		}

		[Token(Token = "0x60002D0")]
		[Address(RVA = "0xE67B0C", Offset = "0xE67B0C", VA = "0xE67B0C")]
		public void SetPropertiesListedInLobby(string[] propertiesListedInLobby)
		{
		}

		[Token(Token = "0x60002D1")]
		[Address(RVA = "0xE67BCC", Offset = "0xE67BCC", VA = "0xE67BCC", Slot = "6")]
		protected internal virtual void RemovePlayer(Player player)
		{
		}

		[Token(Token = "0x60002D2")]
		[Address(RVA = "0xE67C40", Offset = "0xE67C40", VA = "0xE67C40", Slot = "7")]
		protected internal virtual void RemovePlayer(int id)
		{
		}

		[Token(Token = "0x60002D3")]
		[Address(RVA = "0xE67C78", Offset = "0xE67C78", VA = "0xE67C78")]
		public bool SetMasterClient(Player masterClientPlayer)
		{
			return default(bool);
		}

		[Token(Token = "0x60002D4")]
		[Address(RVA = "0xE67E08", Offset = "0xE67E08", VA = "0xE67E08", Slot = "8")]
		public virtual bool AddPlayer(Player player)
		{
			return default(bool);
		}

		[Token(Token = "0x60002D5")]
		[Address(RVA = "0xE67E9C", Offset = "0xE67E9C", VA = "0xE67E9C", Slot = "9")]
		public virtual Player StorePlayer(Player player)
		{
			return null;
		}

		[Token(Token = "0x60002D6")]
		[Address(RVA = "0xE67F30", Offset = "0xE67F30", VA = "0xE67F30", Slot = "10")]
		public virtual Player GetPlayer(int id)
		{
			return null;
		}

		[Token(Token = "0x60002D7")]
		[Address(RVA = "0xE67FA8", Offset = "0xE67FA8", VA = "0xE67FA8")]
		public void ClearExpectedUsers()
		{
		}

		[Token(Token = "0x60002D8")]
		[Address(RVA = "0xE680C4", Offset = "0xE680C4", VA = "0xE680C4", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x60002D9")]
		[Address(RVA = "0xE682B8", Offset = "0xE682B8", VA = "0xE682B8")]
		public new string ToStringFull()
		{
			return null;
		}
	}
	[Token(Token = "0x200007C")]
	public class RoomInfo
	{
		[Token(Token = "0x400029D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		protected internal bool removedFromList;

		[Token(Token = "0x400029E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Hashtable customProperties;

		[Token(Token = "0x400029F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		protected byte maxPlayers;

		[Token(Token = "0x40002A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		protected string[] expectedUsers;

		[Token(Token = "0x40002A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		protected bool isOpen;

		[Token(Token = "0x40002A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
		protected bool isVisible;

		[Token(Token = "0x40002A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x32")]
		protected bool autoCleanUp;

		[Token(Token = "0x40002A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		protected string name;

		[Token(Token = "0x40002A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		protected internal int masterClientId;

		[Token(Token = "0x40002A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		protected string[] propertiesListedInLobby;

		[Token(Token = "0x40002A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x982124", Offset = "0x982124")]
		private int <PlayerCount>k__BackingField;

		[Token(Token = "0x40002A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x982134", Offset = "0x982134")]
		private bool <IsLocalClientInside>k__BackingField;

		[Token(Token = "0x170000BD")]
		public Hashtable CustomProperties
		{
			[Token(Token = "0x60002DA")]
			[Address(RVA = "0xE684E0", Offset = "0xE684E0", VA = "0xE684E0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000BE")]
		public string Name
		{
			[Token(Token = "0x60002DB")]
			[Address(RVA = "0xE684E8", Offset = "0xE684E8", VA = "0xE684E8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000BF")]
		public int PlayerCount
		{
			[Token(Token = "0x60002DC")]
			[Address(RVA = "0xE684F0", Offset = "0xE684F0", VA = "0xE684F0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x983A94", Offset = "0x983A94")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60002DD")]
			[Address(RVA = "0xE684F8", Offset = "0xE684F8", VA = "0xE684F8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x983AA4", Offset = "0x983AA4")]
			private set
			{
			}
		}

		[Token(Token = "0x170000C0")]
		public bool IsLocalClientInside
		{
			[Token(Token = "0x60002DE")]
			[Address(RVA = "0xE68500", Offset = "0xE68500", VA = "0xE68500")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x983AB4", Offset = "0x983AB4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60002DF")]
			[Address(RVA = "0xE68508", Offset = "0xE68508", VA = "0xE68508")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x983AC4", Offset = "0x983AC4")]
			set
			{
			}
		}

		[Token(Token = "0x170000C1")]
		public byte MaxPlayers
		{
			[Token(Token = "0x60002E0")]
			[Address(RVA = "0xE68514", Offset = "0xE68514", VA = "0xE68514")]
			get
			{
				return default(byte);
			}
		}

		[Token(Token = "0x170000C2")]
		public bool IsOpen
		{
			[Token(Token = "0x60002E1")]
			[Address(RVA = "0xE6851C", Offset = "0xE6851C", VA = "0xE6851C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000C3")]
		public bool IsVisible
		{
			[Token(Token = "0x60002E2")]
			[Address(RVA = "0xE68524", Offset = "0xE68524", VA = "0xE68524")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60002E3")]
		[Address(RVA = "0xE62D94", Offset = "0xE62D94", VA = "0xE62D94")]
		protected internal RoomInfo(string roomName, Hashtable roomProperties)
		{
		}

		[Token(Token = "0x60002E4")]
		[Address(RVA = "0xE6852C", Offset = "0xE6852C", VA = "0xE6852C", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Token(Token = "0x60002E5")]
		[Address(RVA = "0xE685E0", Offset = "0xE685E0", VA = "0xE685E0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x60002E6")]
		[Address(RVA = "0xE68600", Offset = "0xE68600", VA = "0xE68600", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x60002E7")]
		[Address(RVA = "0xE687F4", Offset = "0xE687F4", VA = "0xE687F4")]
		public string ToStringFull()
		{
			return null;
		}

		[Token(Token = "0x60002E8")]
		[Address(RVA = "0xE68A1C", Offset = "0xE68A1C", VA = "0xE68A1C", Slot = "4")]
		protected internal virtual void InternalCacheProperties(Hashtable propertiesToCache)
		{
		}
	}
	[Token(Token = "0x200007D")]
	public class WebRpcResponse
	{
		[Token(Token = "0x40002A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x982144", Offset = "0x982144")]
		private string <Name>k__BackingField;

		[Token(Token = "0x40002AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x982154", Offset = "0x982154")]
		private int <ReturnCode>k__BackingField;

		[Token(Token = "0x40002AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x982164", Offset = "0x982164")]
		private string <DebugMessage>k__BackingField;

		[Token(Token = "0x40002AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x982174", Offset = "0x982174")]
		private Dictionary<string, object> <Parameters>k__BackingField;

		[Token(Token = "0x170000C4")]
		public string Name
		{
			[Token(Token = "0x60002E9")]
			[Address(RVA = "0xE6937C", Offset = "0xE6937C", VA = "0xE6937C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x983AD4", Offset = "0x983AD4")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002EA")]
			[Address(RVA = "0xE69384", Offset = "0xE69384", VA = "0xE69384")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x983AE4", Offset = "0x983AE4")]
			private set
			{
			}
		}

		[Token(Token = "0x170000C5")]
		public int ReturnCode
		{
			[Token(Token = "0x60002EB")]
			[Address(RVA = "0xE6938C", Offset = "0xE6938C", VA = "0xE6938C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x983AF4", Offset = "0x983AF4")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60002EC")]
			[Address(RVA = "0xE69394", Offset = "0xE69394", VA = "0xE69394")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x983B04", Offset = "0x983B04")]
			private set
			{
			}
		}

		[Token(Token = "0x170000C6")]
		public string DebugMessage
		{
			[Token(Token = "0x60002ED")]
			[Address(RVA = "0xE6939C", Offset = "0xE6939C", VA = "0xE6939C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x983B14", Offset = "0x983B14")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002EE")]
			[Address(RVA = "0xE693A4", Offset = "0xE693A4", VA = "0xE693A4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x983B24", Offset = "0x983B24")]
			private set
			{
			}
		}

		[Token(Token = "0x170000C7")]
		public Dictionary<string, object> Parameters
		{
			[Token(Token = "0x60002EF")]
			[Address(RVA = "0xE693AC", Offset = "0xE693AC", VA = "0xE693AC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x983B34", Offset = "0x983B34")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002F0")]
			[Address(RVA = "0xE693B4", Offset = "0xE693B4", VA = "0xE693B4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x983B44", Offset = "0x983B44")]
			private set
			{
			}
		}

		[Token(Token = "0x60002F1")]
		[Address(RVA = "0xE693BC", Offset = "0xE693BC", VA = "0xE693BC")]
		public WebRpcResponse(OperationResponse response)
		{
		}

		[Token(Token = "0x60002F2")]
		[Address(RVA = "0xE69558", Offset = "0xE69558", VA = "0xE69558")]
		public string ToStringFull()
		{
			return null;
		}
	}
	[Token(Token = "0x200007E")]
	public class WebFlags
	{
		[Token(Token = "0x40002AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly WebFlags Default;

		[Token(Token = "0x40002AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public byte WebhookFlags;

		[Token(Token = "0x40002AF")]
		public const byte HttpForwardConst = 1;

		[Token(Token = "0x40002B0")]
		public const byte SendAuthCookieConst = 2;

		[Token(Token = "0x40002B1")]
		public const byte SendSyncConst = 4;

		[Token(Token = "0x40002B2")]
		public const byte SendStateConst = 8;

		[Token(Token = "0x170000C8")]
		public bool HttpForward
		{
			[Token(Token = "0x60002F3")]
			[Address(RVA = "0xE659A4", Offset = "0xE659A4", VA = "0xE659A4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60002F4")]
			[Address(RVA = "0xE69280", Offset = "0xE69280", VA = "0xE69280")]
			set
			{
			}
		}

		[Token(Token = "0x170000C9")]
		public bool SendAuthCookie
		{
			[Token(Token = "0x60002F5")]
			[Address(RVA = "0xE6929C", Offset = "0xE6929C", VA = "0xE6929C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60002F6")]
			[Address(RVA = "0xE692A8", Offset = "0xE692A8", VA = "0xE692A8")]
			set
			{
			}
		}

		[Token(Token = "0x170000CA")]
		public bool SendSync
		{
			[Token(Token = "0x60002F7")]
			[Address(RVA = "0xE692C4", Offset = "0xE692C4", VA = "0xE692C4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60002F8")]
			[Address(RVA = "0xE692D0", Offset = "0xE692D0", VA = "0xE692D0")]
			set
			{
			}
		}

		[Token(Token = "0x170000CB")]
		public bool SendState
		{
			[Token(Token = "0x60002F9")]
			[Address(RVA = "0xE692EC", Offset = "0xE692EC", VA = "0xE692EC")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60002FA")]
			[Address(RVA = "0xE692F8", Offset = "0xE692F8", VA = "0xE692F8")]
			set
			{
			}
		}

		[Token(Token = "0x60002FB")]
		[Address(RVA = "0xE60958", Offset = "0xE60958", VA = "0xE60958")]
		public WebFlags(byte webhookFlags)
		{
		}
	}
}
namespace DarkTonic.MasterAudio
{
	[Token(Token = "0x200007F")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x9813A8", Offset = "0x9813A8")]
	[AttributeAttribute(Name = "AudioScriptOrder", RVA = "0x9813A8", Offset = "0x9813A8")]
	public class AmbientSound : MonoBehaviour
	{
		[Token(Token = "0x40002B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SoundGroup]
		public string AmbientSoundGroup;

		[Token(Token = "0x40002B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public EventSounds.VariationType variationType;

		[Token(Token = "0x40002B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string variationName;

		[Token(Token = "0x40002B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public MasterAudio.AmbientSoundExitMode exitMode;

		[Token(Token = "0x40002B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float exitFadeTime;

		[Token(Token = "0x40002B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x982194", Offset = "0x982194")]
		public bool FollowCaller;

		[Token(Token = "0x40002B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x39")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9821CC", Offset = "0x9821CC")]
		public bool UseClosestColliderPosition;

		[Token(Token = "0x40002BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3A")]
		public bool UseTopCollider;

		[Token(Token = "0x40002BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3B")]
		public bool IncludeChildColliders;

		[Token(Token = "0x40002BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x982204", Offset = "0x982204")]
		public Transform RuntimeFollower;

		[Token(Token = "0x40002BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Transform _trans;

		[Token(Token = "0x40002BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public float colliderMaxDistance;

		[Token(Token = "0x40002BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public long lastTimeMaxDistanceCalced;

		[Token(Token = "0x170000CC")]
		public bool IsValidSoundGroup
		{
			[Token(Token = "0x6000305")]
			[Address(RVA = "0xA02E60", Offset = "0xA02E60", VA = "0xA02E60")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000CD")]
		public Transform Trans
		{
			[Token(Token = "0x6000306")]
			[Address(RVA = "0xA03084", Offset = "0xA03084", VA = "0xA03084")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60002FD")]
		[Address(RVA = "0xA02968", Offset = "0xA02968", VA = "0xA02968")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60002FE")]
		[Address(RVA = "0xA02CB0", Offset = "0xA02CB0", VA = "0xA02CB0")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60002FF")]
		[Address(RVA = "0xA0346C", Offset = "0xA0346C", VA = "0xA0346C")]
		public void CalculateRadius()
		{
		}

		[Token(Token = "0x6000300")]
		[Address(RVA = "0xA03558", Offset = "0xA03558", VA = "0xA03558")]
		public AudioSource GetNamedOrFirstAudioSource()
		{
			return null;
		}

		[Token(Token = "0x6000301")]
		[Address(RVA = "0xA0390C", Offset = "0xA0390C", VA = "0xA0390C")]
		public List<AudioSource> GetAllVariationAudioSources()
		{
			return null;
		}

		[Token(Token = "0x6000302")]
		[Address(RVA = "0xA03AFC", Offset = "0xA03AFC", VA = "0xA03AFC")]
		private void OnDrawGizmos()
		{
		}

		[Token(Token = "0x6000303")]
		[Address(RVA = "0xA03D58", Offset = "0xA03D58", VA = "0xA03D58")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x6000304")]
		[Address(RVA = "0xA0296C", Offset = "0xA0296C", VA = "0xA0296C")]
		private void StartTrackers()
		{
		}

		[Token(Token = "0x6000307")]
		[Address(RVA = "0xA04698", Offset = "0xA04698", VA = "0xA04698")]
		public AmbientSound()
		{
		}
	}
	[Token(Token = "0x2000080")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x9813F8", Offset = "0x9813F8")]
	public class ButtonClicker : MonoBehaviour
	{
		[Token(Token = "0x40002C0")]
		public const float SmallSizeMultiplier = 0.9f;

		[Token(Token = "0x40002C1")]
		public const float LargeSizeMultiplier = 1.1f;

		[Token(Token = "0x40002C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool resizeOnClick;

		[Token(Token = "0x40002C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		public bool resizeClickAllSiblings;

		[Token(Token = "0x40002C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
		public bool resizeOnHover;

		[Token(Token = "0x40002C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B")]
		public bool resizeHoverAllSiblings;

		[Token(Token = "0x40002C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string mouseDownSound;

		[Token(Token = "0x40002C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string mouseUpSound;

		[Token(Token = "0x40002C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string mouseClickSound;

		[Token(Token = "0x40002C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public string mouseOverSound;

		[Token(Token = "0x40002CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public string mouseOutSound;

		[Token(Token = "0x40002CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Vector3 _originalSize;

		[Token(Token = "0x40002CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private Vector3 _smallerSize;

		[Token(Token = "0x40002CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Vector3 _largerSize;

		[Token(Token = "0x40002CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Transform _trans;

		[Token(Token = "0x40002CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private readonly Dictionary<Transform, Vector3> _siblingClickScaleByTransform;

		[Token(Token = "0x40002D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private readonly Dictionary<Transform, Vector3> _siblingHoverScaleByTransform;

		[Token(Token = "0x6000308")]
		[Address(RVA = "0xA0C384", Offset = "0xA0C384", VA = "0xA0C384")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000309")]
		[Address(RVA = "0xA0C638", Offset = "0xA0C638", VA = "0xA0C638")]
		private void OnPress(bool isDown)
		{
		}

		[Token(Token = "0x600030A")]
		[Address(RVA = "0xA0CA5C", Offset = "0xA0CA5C", VA = "0xA0CA5C")]
		private void OnClick()
		{
		}

		[Token(Token = "0x600030B")]
		[Address(RVA = "0xA0CAF8", Offset = "0xA0CAF8", VA = "0xA0CAF8")]
		private void OnHover(bool isOver)
		{
		}

		[Token(Token = "0x600030C")]
		[Address(RVA = "0xA0CD44", Offset = "0xA0CD44", VA = "0xA0CD44")]
		public ButtonClicker()
		{
		}
	}
	[Token(Token = "0x2000081")]
	[AttributeAttribute(Name = "AudioScriptOrder", RVA = "0x981430", Offset = "0x981430")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x981430", Offset = "0x981430")]
	public class EventSounds : MonoBehaviour, ICustomEventReceiver
	{
		[Token(Token = "0x20000E6")]
		public enum UnityUIVersion
		{
			[Token(Token = "0x40006FC")]
			Legacy,
			[Token(Token = "0x40006FD")]
			uGUI
		}

		[Token(Token = "0x20000E7")]
		public enum EventType
		{
			[Token(Token = "0x40006FF")]
			OnStart,
			[Token(Token = "0x4000700")]
			OnVisible,
			[Token(Token = "0x4000701")]
			OnInvisible,
			[Token(Token = "0x4000702")]
			OnCollision,
			[Token(Token = "0x4000703")]
			OnTriggerEnter,
			[Token(Token = "0x4000704")]
			OnTriggerExit,
			[Token(Token = "0x4000705")]
			OnMouseEnter,
			[Token(Token = "0x4000706")]
			OnMouseClick,
			[Token(Token = "0x4000707")]
			OnSpawned,
			[Token(Token = "0x4000708")]
			OnDespawned,
			[Token(Token = "0x4000709")]
			OnEnable,
			[Token(Token = "0x400070A")]
			OnDisable,
			[Token(Token = "0x400070B")]
			OnCollision2D,
			[Token(Token = "0x400070C")]
			OnTriggerEnter2D,
			[Token(Token = "0x400070D")]
			OnTriggerExit2D,
			[Token(Token = "0x400070E")]
			OnParticleCollision,
			[Token(Token = "0x400070F")]
			UserDefinedEvent,
			[Token(Token = "0x4000710")]
			OnCollisionExit,
			[Token(Token = "0x4000711")]
			OnCollisionExit2D,
			[Token(Token = "0x4000712")]
			OnMouseUp,
			[Token(Token = "0x4000713")]
			OnMouseExit,
			[Token(Token = "0x4000714")]
			OnMouseDrag,
			[Token(Token = "0x4000715")]
			NGUIOnClick,
			[Token(Token = "0x4000716")]
			NGUIMouseDown,
			[Token(Token = "0x4000717")]
			NGUIMouseUp,
			[Token(Token = "0x4000718")]
			NGUIMouseEnter,
			[Token(Token = "0x4000719")]
			NGUIMouseExit,
			[Token(Token = "0x400071A")]
			MechanimStateChanged,
			[Token(Token = "0x400071B")]
			UnitySliderChanged,
			[Token(Token = "0x400071C")]
			UnityButtonClicked,
			[Token(Token = "0x400071D")]
			UnityPointerDown,
			[Token(Token = "0x400071E")]
			UnityPointerUp,
			[Token(Token = "0x400071F")]
			UnityPointerEnter,
			[Token(Token = "0x4000720")]
			UnityPointerExit,
			[Token(Token = "0x4000721")]
			UnityDrag,
			[Token(Token = "0x4000722")]
			UnityDrop,
			[Token(Token = "0x4000723")]
			UnityScroll,
			[Token(Token = "0x4000724")]
			UnityUpdateSelected,
			[Token(Token = "0x4000725")]
			UnitySelect,
			[Token(Token = "0x4000726")]
			UnityDeselect,
			[Token(Token = "0x4000727")]
			UnityMove,
			[Token(Token = "0x4000728")]
			UnityInitializePotentialDrag,
			[Token(Token = "0x4000729")]
			UnityBeginDrag,
			[Token(Token = "0x400072A")]
			UnityEndDrag,
			[Token(Token = "0x400072B")]
			UnitySubmit,
			[Token(Token = "0x400072C")]
			UnityCancel,
			[Token(Token = "0x400072D")]
			UnityToggle,
			[Token(Token = "0x400072E")]
			OnTriggerStay,
			[Token(Token = "0x400072F")]
			OnTriggerStay2D
		}

		[Token(Token = "0x20000E8")]
		public enum GlidePitchType
		{
			[Token(Token = "0x4000731")]
			None,
			[Token(Token = "0x4000732")]
			RaisePitch,
			[Token(Token = "0x4000733")]
			LowerPitch
		}

		[Token(Token = "0x20000E9")]
		public enum VariationType
		{
			[Token(Token = "0x4000735")]
			PlaySpecific,
			[Token(Token = "0x4000736")]
			PlayRandom
		}

		[Token(Token = "0x20000EA")]
		public enum PreviousSoundStopMode
		{
			[Token(Token = "0x4000738")]
			None,
			[Token(Token = "0x4000739")]
			Stop,
			[Token(Token = "0x400073A")]
			FadeOut
		}

		[Token(Token = "0x20000EB")]
		public enum RetriggerLimMode
		{
			[Token(Token = "0x400073C")]
			None,
			[Token(Token = "0x400073D")]
			FrameBased,
			[Token(Token = "0x400073E")]
			TimeBased
		}

		[Token(Token = "0x20000EC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9816A4", Offset = "0x9816A4")]
		private sealed class <CoUpdate>d__123 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400073F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000740")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000741")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public EventSounds <>4__this;

			[Token(Token = "0x17000194")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000706")]
				[Address(RVA = "0xA1F474", Offset = "0xA1F474", VA = "0xA1F474", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000195")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000708")]
				[Address(RVA = "0xA1F4DC", Offset = "0xA1F4DC", VA = "0xA1F4DC", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000703")]
			[Address(RVA = "0xA1214C", Offset = "0xA1214C", VA = "0xA1214C")]
			[DebuggerHidden]
			public <CoUpdate>d__123(int <>1__state)
			{
			}

			[Token(Token = "0x6000704")]
			[Address(RVA = "0xA1F2F4", Offset = "0xA1F2F4", VA = "0xA1F2F4", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000705")]
			[Address(RVA = "0xA1F2F8", Offset = "0xA1F2F8", VA = "0xA1F2F8", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000707")]
			[Address(RVA = "0xA1F47C", Offset = "0xA1F47C", VA = "0xA1F47C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x20000ED")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9816B4", Offset = "0x9816B4")]
		private sealed class <>c__DisplayClass175_0
		{
			[Token(Token = "0x4000742")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string stateName;

			[Token(Token = "0x6000709")]
			[Address(RVA = "0xA1460C", Offset = "0xA1460C", VA = "0xA1460C")]
			public <>c__DisplayClass175_0()
			{
			}

			[Token(Token = "0x600070A")]
			[Address(RVA = "0xA1F2D0", Offset = "0xA1F2D0", VA = "0xA1F2D0")]
			internal bool <GetMechanimAudioEventGroup>b__0(AudioEventGroup grp)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x40002D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public MasterAudio.SoundSpawnLocationMode soundSpawnMode;

		[Token(Token = "0x40002D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public bool disableSounds;

		[Token(Token = "0x40002D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D")]
		public bool showPoolManager;

		[Token(Token = "0x40002D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E")]
		public bool showNGUI;

		[Token(Token = "0x40002D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public AudioEvent eventToGizmo;

		[Token(Token = "0x40002D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public UnityUIVersion unityUIMode;

		[Token(Token = "0x40002D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public bool logMissingEvents;

		[Token(Token = "0x40002D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static List<string> LayerTagFilterEvents;

		[Token(Token = "0x40002D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static List<MasterAudio.PlaylistCommand> PlaylistCommandsWithAll;

		[Token(Token = "0x40002DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public AudioEventGroup startSound;

		[Token(Token = "0x40002DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public AudioEventGroup visibleSound;

		[Token(Token = "0x40002DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public AudioEventGroup invisibleSound;

		[Token(Token = "0x40002DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public AudioEventGroup collisionSound;

		[Token(Token = "0x40002DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public AudioEventGroup collisionExitSound;

		[Token(Token = "0x40002DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public AudioEventGroup triggerSound;

		[Token(Token = "0x40002E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public AudioEventGroup triggerExitSound;

		[Token(Token = "0x40002E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public AudioEventGroup triggerStaySound;

		[Token(Token = "0x40002E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public AudioEventGroup mouseEnterSound;

		[Token(Token = "0x40002E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public AudioEventGroup mouseExitSound;

		[Token(Token = "0x40002E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public AudioEventGroup mouseClickSound;

		[Token(Token = "0x40002E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public AudioEventGroup mouseUpSound;

		[Token(Token = "0x40002E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public AudioEventGroup mouseDragSound;

		[Token(Token = "0x40002E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public AudioEventGroup spawnedSound;

		[Token(Token = "0x40002E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public AudioEventGroup despawnedSound;

		[Token(Token = "0x40002E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public AudioEventGroup enableSound;

		[Token(Token = "0x40002EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public AudioEventGroup disableSound;

		[Token(Token = "0x40002EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public AudioEventGroup collision2dSound;

		[Token(Token = "0x40002EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public AudioEventGroup collisionExit2dSound;

		[Token(Token = "0x40002ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public AudioEventGroup triggerEnter2dSound;

		[Token(Token = "0x40002EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public AudioEventGroup triggerStay2dSound;

		[Token(Token = "0x40002EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		public AudioEventGroup triggerExit2dSound;

		[Token(Token = "0x40002F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		public AudioEventGroup particleCollisionSound;

		[Token(Token = "0x40002F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		public AudioEventGroup nguiOnClickSound;

		[Token(Token = "0x40002F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		public AudioEventGroup nguiMouseDownSound;

		[Token(Token = "0x40002F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		public AudioEventGroup nguiMouseUpSound;

		[Token(Token = "0x40002F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		public AudioEventGroup nguiMouseEnterSound;

		[Token(Token = "0x40002F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		public AudioEventGroup nguiMouseExitSound;

		[Token(Token = "0x40002F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		public AudioEventGroup unitySliderChangedSound;

		[Token(Token = "0x40002F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		public AudioEventGroup unityButtonClickedSound;

		[Token(Token = "0x40002F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		public AudioEventGroup unityPointerDownSound;

		[Token(Token = "0x40002F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		public AudioEventGroup unityDragSound;

		[Token(Token = "0x40002FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		public AudioEventGroup unityPointerUpSound;

		[Token(Token = "0x40002FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		public AudioEventGroup unityPointerEnterSound;

		[Token(Token = "0x40002FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		public AudioEventGroup unityPointerExitSound;

		[Token(Token = "0x40002FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		public AudioEventGroup unityDropSound;

		[Token(Token = "0x40002FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		public AudioEventGroup unityScrollSound;

		[Token(Token = "0x40002FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		public AudioEventGroup unityUpdateSelectedSound;

		[Token(Token = "0x4000300")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		public AudioEventGroup unitySelectSound;

		[Token(Token = "0x4000301")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		public AudioEventGroup unityDeselectSound;

		[Token(Token = "0x4000302")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		public AudioEventGroup unityMoveSound;

		[Token(Token = "0x4000303")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
		public AudioEventGroup unityInitializePotentialDragSound;

		[Token(Token = "0x4000304")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
		public AudioEventGroup unityBeginDragSound;

		[Token(Token = "0x4000305")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
		public AudioEventGroup unityEndDragSound;

		[Token(Token = "0x4000306")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
		public AudioEventGroup unitySubmitSound;

		[Token(Token = "0x4000307")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
		public AudioEventGroup unityCancelSound;

		[Token(Token = "0x4000308")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
		public AudioEventGroup unityToggleSound;

		[Token(Token = "0x4000309")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
		public List<AudioEventGroup> userDefinedSounds;

		[Token(Token = "0x400030A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
		public List<AudioEventGroup> mechanimStateChangedSounds;

		[Token(Token = "0x400030B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
		public bool useStartSound;

		[Token(Token = "0x400030C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B9")]
		public bool useVisibleSound;

		[Token(Token = "0x400030D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1BA")]
		public bool useInvisibleSound;

		[Token(Token = "0x400030E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1BB")]
		public bool useCollisionSound;

		[Token(Token = "0x400030F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1BC")]
		public bool useCollisionExitSound;

		[Token(Token = "0x4000310")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1BD")]
		public bool useTriggerEnterSound;

		[Token(Token = "0x4000311")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1BE")]
		public bool useTriggerExitSound;

		[Token(Token = "0x4000312")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1BF")]
		public bool useTriggerStaySound;

		[Token(Token = "0x4000313")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
		public bool useMouseEnterSound;

		[Token(Token = "0x4000314")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C1")]
		public bool useMouseExitSound;

		[Token(Token = "0x4000315")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C2")]
		public bool useMouseClickSound;

		[Token(Token = "0x4000316")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C3")]
		public bool useMouseUpSound;

		[Token(Token = "0x4000317")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C4")]
		public bool useMouseDragSound;

		[Token(Token = "0x4000318")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C5")]
		public bool useSpawnedSound;

		[Token(Token = "0x4000319")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C6")]
		public bool useDespawnedSound;

		[Token(Token = "0x400031A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C7")]
		public bool useEnableSound;

		[Token(Token = "0x400031B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C8")]
		public bool useDisableSound;

		[Token(Token = "0x400031C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C9")]
		public bool useCollision2dSound;

		[Token(Token = "0x400031D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1CA")]
		public bool useCollisionExit2dSound;

		[Token(Token = "0x400031E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1CB")]
		public bool useTriggerEnter2dSound;

		[Token(Token = "0x400031F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1CC")]
		public bool useTriggerStay2dSound;

		[Token(Token = "0x4000320")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1CD")]
		public bool useTriggerExit2dSound;

		[Token(Token = "0x4000321")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1CE")]
		public bool useParticleCollisionSound;

		[Token(Token = "0x4000322")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1CF")]
		public bool useNguiOnClickSound;

		[Token(Token = "0x4000323")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D0")]
		public bool useNguiMouseDownSound;

		[Token(Token = "0x4000324")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D1")]
		public bool useNguiMouseUpSound;

		[Token(Token = "0x4000325")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D2")]
		public bool useNguiMouseEnterSound;

		[Token(Token = "0x4000326")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D3")]
		public bool useNguiMouseExitSound;

		[Token(Token = "0x4000327")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D4")]
		public bool useUnitySliderChangedSound;

		[Token(Token = "0x4000328")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D5")]
		public bool useUnityButtonClickedSound;

		[Token(Token = "0x4000329")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D6")]
		public bool useUnityPointerDownSound;

		[Token(Token = "0x400032A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D7")]
		public bool useUnityDragSound;

		[Token(Token = "0x400032B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D8")]
		public bool useUnityPointerUpSound;

		[Token(Token = "0x400032C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D9")]
		public bool useUnityPointerEnterSound;

		[Token(Token = "0x400032D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1DA")]
		public bool useUnityPointerExitSound;

		[Token(Token = "0x400032E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1DB")]
		public bool useUnityDropSound;

		[Token(Token = "0x400032F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1DC")]
		public bool useUnityScrollSound;

		[Token(Token = "0x4000330")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1DD")]
		public bool useUnityUpdateSelectedSound;

		[Token(Token = "0x4000331")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1DE")]
		public bool useUnitySelectSound;

		[Token(Token = "0x4000332")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1DF")]
		public bool useUnityDeselectSound;

		[Token(Token = "0x4000333")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E0")]
		public bool useUnityMoveSound;

		[Token(Token = "0x4000334")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E1")]
		public bool useUnityInitializePotentialDragSound;

		[Token(Token = "0x4000335")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E2")]
		public bool useUnityBeginDragSound;

		[Token(Token = "0x4000336")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E3")]
		public bool useUnityEndDragSound;

		[Token(Token = "0x4000337")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E4")]
		public bool useUnitySubmitSound;

		[Token(Token = "0x4000338")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E5")]
		public bool useUnityCancelSound;

		[Token(Token = "0x4000339")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E6")]
		public bool useUnityToggleSound;

		[Token(Token = "0x400033A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E8")]
		private Slider _slider;

		[Token(Token = "0x400033B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F0")]
		private Toggle _toggle;

		[Token(Token = "0x400033C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F8")]
		private Button _button;

		[Token(Token = "0x400033D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x200")]
		private bool _isVisible;

		[Token(Token = "0x400033E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x201")]
		private bool _needsCoroutine;

		[Token(Token = "0x400033F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x204")]
		private float? _triggerEnterTime;

		[Token(Token = "0x4000340")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20C")]
		private float? _triggerEnter2dTime;

		[Token(Token = "0x4000341")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x218")]
		private Transform _trans;

		[Token(Token = "0x4000342")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x220")]
		private readonly List<AudioEventGroup> _validMechanimStateChangedSounds;

		[Token(Token = "0x4000343")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x228")]
		private Animator _anim;

		[Token(Token = "0x170000CE")]
		private bool IsSetToUGUI
		{
			[Token(Token = "0x6000337")]
			[Address(RVA = "0xA11DDC", Offset = "0xA11DDC", VA = "0xA11DDC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000CF")]
		private bool IsSetToLegacyUI
		{
			[Token(Token = "0x6000338")]
			[Address(RVA = "0xA13FC8", Offset = "0xA13FC8", VA = "0xA13FC8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600030D")]
		[Address(RVA = "0xA11D10", Offset = "0xA11D10", VA = "0xA11D10")]
		private void Awake()
		{
		}

		[Token(Token = "0x600030E")]
		[Address(RVA = "0xA11FA8", Offset = "0xA11FA8", VA = "0xA11FA8", Slot = "10")]
		protected virtual void SpawnedOrAwake()
		{
		}

		[Token(Token = "0x600030F")]
		[Address(RVA = "0xA120DC", Offset = "0xA120DC", VA = "0xA120DC")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x983B54", Offset = "0x983B54")]
		private IEnumerator CoUpdate()
		{
			return null;
		}

		[Token(Token = "0x6000310")]
		[Address(RVA = "0xA12178", Offset = "0xA12178", VA = "0xA12178")]
		private void Start()
		{
		}

		[Token(Token = "0x6000311")]
		[Address(RVA = "0xA127EC", Offset = "0xA127EC", VA = "0xA127EC")]
		private void OnBecameVisible()
		{
		}

		[Token(Token = "0x6000312")]
		[Address(RVA = "0xA12814", Offset = "0xA12814", VA = "0xA12814")]
		private void OnBecameInvisible()
		{
		}

		[Token(Token = "0x6000313")]
		[Address(RVA = "0xA12830", Offset = "0xA12830", VA = "0xA12830")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000314")]
		[Address(RVA = "0xA12A78", Offset = "0xA12A78", VA = "0xA12A78")]
		private void RestorePersistentSliders()
		{
		}

		[Token(Token = "0x6000315")]
		[Address(RVA = "0xA12DC4", Offset = "0xA12DC4", VA = "0xA12DC4")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000316")]
		[Address(RVA = "0xA13188", Offset = "0xA13188", VA = "0xA13188")]
		private void OnTriggerEnter2D(Collider2D other)
		{
		}

		[Token(Token = "0x6000317")]
		[Address(RVA = "0xA132BC", Offset = "0xA132BC", VA = "0xA132BC")]
		private void OnTriggerStay2D(Collider2D other)
		{
		}

		[Token(Token = "0x6000318")]
		[Address(RVA = "0xA133A4", Offset = "0xA133A4", VA = "0xA133A4")]
		private void OnTriggerExit2D(Collider2D other)
		{
		}

		[Token(Token = "0x6000319")]
		[Address(RVA = "0xA134C0", Offset = "0xA134C0", VA = "0xA134C0")]
		private void OnCollisionEnter2D(Collision2D collision)
		{
		}

		[Token(Token = "0x600031A")]
		[Address(RVA = "0xA135D4", Offset = "0xA135D4", VA = "0xA135D4")]
		private void OnCollisionExit2D(Collision2D collision)
		{
		}

		[Token(Token = "0x600031B")]
		[Address(RVA = "0xA136E8", Offset = "0xA136E8", VA = "0xA136E8")]
		private void OnCollisionEnter(Collision collision)
		{
		}

		[Token(Token = "0x600031C")]
		[Address(RVA = "0xA137FC", Offset = "0xA137FC", VA = "0xA137FC")]
		private void OnCollisionExit(Collision collision)
		{
		}

		[Token(Token = "0x600031D")]
		[Address(RVA = "0xA13910", Offset = "0xA13910", VA = "0xA13910")]
		private void OnTriggerEnter(Collider other)
		{
		}

		[Token(Token = "0x600031E")]
		[Address(RVA = "0xA13A44", Offset = "0xA13A44", VA = "0xA13A44")]
		private void OnTriggerStay(Collider other)
		{
		}

		[Token(Token = "0x600031F")]
		[Address(RVA = "0xA13B2C", Offset = "0xA13B2C", VA = "0xA13B2C")]
		private void OnTriggerExit(Collider other)
		{
		}

		[Token(Token = "0x6000320")]
		[Address(RVA = "0xA13C48", Offset = "0xA13C48", VA = "0xA13C48")]
		private void OnParticleCollision(GameObject other)
		{
		}

		[Token(Token = "0x6000321")]
		[Address(RVA = "0xA13D5C", Offset = "0xA13D5C", VA = "0xA13D5C")]
		public void OnPointerEnter(PointerEventData data)
		{
		}

		[Token(Token = "0x6000322")]
		[Address(RVA = "0xA13D7C", Offset = "0xA13D7C", VA = "0xA13D7C")]
		public void OnPointerExit(PointerEventData data)
		{
		}

		[Token(Token = "0x6000323")]
		[Address(RVA = "0xA13D9C", Offset = "0xA13D9C", VA = "0xA13D9C")]
		public void OnPointerDown(PointerEventData data)
		{
		}

		[Token(Token = "0x6000324")]
		[Address(RVA = "0xA13DBC", Offset = "0xA13DBC", VA = "0xA13DBC")]
		public void OnPointerUp(PointerEventData data)
		{
		}

		[Token(Token = "0x6000325")]
		[Address(RVA = "0xA13DDC", Offset = "0xA13DDC", VA = "0xA13DDC")]
		private void OnDrag(Vector2 delta)
		{
		}

		[Token(Token = "0x6000326")]
		[Address(RVA = "0xA13DE0", Offset = "0xA13DE0", VA = "0xA13DE0")]
		public void OnDrag(PointerEventData data)
		{
		}

		[Token(Token = "0x6000327")]
		[Address(RVA = "0xA13E00", Offset = "0xA13E00", VA = "0xA13E00")]
		private void OnDrop(GameObject go)
		{
		}

		[Token(Token = "0x6000328")]
		[Address(RVA = "0xA13E04", Offset = "0xA13E04", VA = "0xA13E04")]
		public void OnDrop(PointerEventData data)
		{
		}

		[Token(Token = "0x6000329")]
		[Address(RVA = "0xA13E24", Offset = "0xA13E24", VA = "0xA13E24")]
		public void OnScroll(PointerEventData data)
		{
		}

		[Token(Token = "0x600032A")]
		[Address(RVA = "0xA13E44", Offset = "0xA13E44", VA = "0xA13E44")]
		public void OnUpdateSelected(BaseEventData data)
		{
		}

		[Token(Token = "0x600032B")]
		[Address(RVA = "0xA13E64", Offset = "0xA13E64", VA = "0xA13E64")]
		private void OnSelect(bool isSelected)
		{
		}

		[Token(Token = "0x600032C")]
		[Address(RVA = "0xA13E68", Offset = "0xA13E68", VA = "0xA13E68")]
		public void OnSelect(BaseEventData data)
		{
		}

		[Token(Token = "0x600032D")]
		[Address(RVA = "0xA13E88", Offset = "0xA13E88", VA = "0xA13E88")]
		public void OnDeselect(BaseEventData data)
		{
		}

		[Token(Token = "0x600032E")]
		[Address(RVA = "0xA13EA8", Offset = "0xA13EA8", VA = "0xA13EA8")]
		public void OnMove(AxisEventData data)
		{
		}

		[Token(Token = "0x600032F")]
		[Address(RVA = "0xA13EC8", Offset = "0xA13EC8", VA = "0xA13EC8")]
		public void OnInitializePotentialDrag(PointerEventData data)
		{
		}

		[Token(Token = "0x6000330")]
		[Address(RVA = "0xA13EE8", Offset = "0xA13EE8", VA = "0xA13EE8")]
		public void OnBeginDrag(PointerEventData data)
		{
		}

		[Token(Token = "0x6000331")]
		[Address(RVA = "0xA13F08", Offset = "0xA13F08", VA = "0xA13F08")]
		public void OnEndDrag(PointerEventData data)
		{
		}

		[Token(Token = "0x6000332")]
		[Address(RVA = "0xA13F28", Offset = "0xA13F28", VA = "0xA13F28")]
		public void OnSubmit(BaseEventData data)
		{
		}

		[Token(Token = "0x6000333")]
		[Address(RVA = "0xA13F48", Offset = "0xA13F48", VA = "0xA13F48")]
		public void OnCancel(BaseEventData data)
		{
		}

		[Token(Token = "0x6000334")]
		[Address(RVA = "0xA13F68", Offset = "0xA13F68", VA = "0xA13F68")]
		private void SliderChanged(float newValue)
		{
		}

		[Token(Token = "0x6000335")]
		[Address(RVA = "0xA13F98", Offset = "0xA13F98", VA = "0xA13F98")]
		private void ToggleChanged(bool newValue)
		{
		}

		[Token(Token = "0x6000336")]
		[Address(RVA = "0xA13FB0", Offset = "0xA13FB0", VA = "0xA13FB0")]
		private void ButtonClicked()
		{
		}

		[Token(Token = "0x6000339")]
		[Address(RVA = "0xA13FD8", Offset = "0xA13FD8", VA = "0xA13FD8")]
		private void OnPress(bool isDown)
		{
		}

		[Token(Token = "0x600033A")]
		[Address(RVA = "0xA14010", Offset = "0xA14010", VA = "0xA14010")]
		private void OnClick()
		{
		}

		[Token(Token = "0x600033B")]
		[Address(RVA = "0xA14030", Offset = "0xA14030", VA = "0xA14030")]
		private void OnHover(bool isOver)
		{
		}

		[Token(Token = "0x600033C")]
		[Address(RVA = "0xA14068", Offset = "0xA14068", VA = "0xA14068")]
		private void OnSpawned()
		{
		}

		[Token(Token = "0x600033D")]
		[Address(RVA = "0xA140B8", Offset = "0xA140B8", VA = "0xA140B8")]
		private void OnDespawned()
		{
		}

		[Token(Token = "0x600033E")]
		[Address(RVA = "0xA140D8", Offset = "0xA140D8", VA = "0xA140D8")]
		public void CalculateRadius(AudioEvent anEvent)
		{
		}

		[Token(Token = "0x600033F")]
		[Address(RVA = "0xA14184", Offset = "0xA14184", VA = "0xA14184")]
		public AudioSource GetNamedOrFirstAudioSource(AudioEvent anEvent)
		{
			return null;
		}

		[Token(Token = "0x6000340")]
		[Address(RVA = "0xA14354", Offset = "0xA14354", VA = "0xA14354")]
		public List<AudioSource> GetAllVariationAudioSources(AudioEvent anEvent)
		{
			return null;
		}

		[Token(Token = "0x6000341")]
		[Address(RVA = "0xA14548", Offset = "0xA14548", VA = "0xA14548")]
		public AudioEventGroup GetMechanimAudioEventGroup(string stateName)
		{
			return null;
		}

		[Token(Token = "0x6000342")]
		[Address(RVA = "0xA125C0", Offset = "0xA125C0", VA = "0xA125C0")]
		public bool PlaySounds(AudioEventGroup eventGrp, EventType eType)
		{
			return default(bool);
		}

		[Token(Token = "0x6000343")]
		[Address(RVA = "0xA168E0", Offset = "0xA168E0", VA = "0xA168E0")]
		private void OnDrawGizmos()
		{
		}

		[Token(Token = "0x6000344")]
		[Address(RVA = "0xA16AC0", Offset = "0xA16AC0", VA = "0xA16AC0")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x6000345")]
		[Address(RVA = "0xA14614", Offset = "0xA14614", VA = "0xA14614")]
		private static bool CheckForRetriggerLimit(AudioEventGroup grp)
		{
			return default(bool);
		}

		[Token(Token = "0x6000346")]
		[Address(RVA = "0xA14780", Offset = "0xA14780", VA = "0xA14780")]
		private void PerformSingleAction(AudioEventGroup grp, AudioEvent aEvent, EventType eType)
		{
		}

		[Token(Token = "0x6000347")]
		[Address(RVA = "0xA1DFA8", Offset = "0xA1DFA8", VA = "0xA1DFA8")]
		private void LogIfCustomEventMissing(AudioEventGroup eventGroup)
		{
		}

		[Token(Token = "0x6000348")]
		[Address(RVA = "0xA121B8", Offset = "0xA121B8", VA = "0xA121B8", Slot = "4")]
		public void CheckForIllegalCustomEvents()
		{
		}

		[Token(Token = "0x6000349")]
		[Address(RVA = "0xA1E380", Offset = "0xA1E380", VA = "0xA1E380", Slot = "5")]
		public void ReceiveEvent(string customEventName, Vector3 originPoint)
		{
		}

		[Token(Token = "0x600034A")]
		[Address(RVA = "0xA1E454", Offset = "0xA1E454", VA = "0xA1E454", Slot = "6")]
		public bool SubscribesToEvent(string customEventName)
		{
			return default(bool);
		}

		[Token(Token = "0x600034B")]
		[Address(RVA = "0xA12D34", Offset = "0xA12D34", VA = "0xA12D34", Slot = "7")]
		public void RegisterReceiver()
		{
		}

		[Token(Token = "0x600034C")]
		[Address(RVA = "0xA13100", Offset = "0xA13100", VA = "0xA13100", Slot = "8")]
		public void UnregisterReceiver()
		{
		}

		[Token(Token = "0x600034D")]
		[Address(RVA = "0xA1ED78", Offset = "0xA1ED78", VA = "0xA1ED78", Slot = "9")]
		public IList<AudioEventGroup> GetAllEvents()
		{
			return null;
		}

		[Token(Token = "0x600034E")]
		[Address(RVA = "0xA11DEC", Offset = "0xA11DEC", VA = "0xA11DEC")]
		private void AddUGUIComponents()
		{
		}

		[Token(Token = "0x600034F")]
		private void AddUGUIHandler<T>(bool useSound) where T : EventSoundsUGUIHandler
		{
		}

		[Token(Token = "0x6000350")]
		[Address(RVA = "0xA1EDD0", Offset = "0xA1EDD0", VA = "0xA1EDD0")]
		public EventSounds()
		{
		}
	}
	[Token(Token = "0x2000082")]
	public class EventSoundsUGUIHandler : MonoBehaviour
	{
		[Token(Token = "0x4000344")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x98223C", Offset = "0x98223C")]
		private EventSounds <eventSounds>k__BackingField;

		[Token(Token = "0x170000D0")]
		public EventSounds eventSounds
		{
			[Token(Token = "0x6000352")]
			[Address(RVA = "0xA1FF3C", Offset = "0xA1FF3C", VA = "0xA1FF3C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x983BB8", Offset = "0x983BB8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000353")]
			[Address(RVA = "0xA1FF44", Offset = "0xA1FF44", VA = "0xA1FF44")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x983BC8", Offset = "0x983BC8")]
			set
			{
			}
		}

		[Token(Token = "0x6000354")]
		[Address(RVA = "0xA1F594", Offset = "0xA1F594", VA = "0xA1F594")]
		public EventSoundsUGUIHandler()
		{
		}
	}
	[Token(Token = "0x2000083")]
	public class EventSoundsPointerEnterHandler : EventSoundsUGUIHandler, IPointerEnterHandler, IEventSystemHandler
	{
		[Token(Token = "0x6000355")]
		[Address(RVA = "0xA1FB1C", Offset = "0xA1FB1C", VA = "0xA1FB1C", Slot = "4")]
		public void OnPointerEnter(PointerEventData data)
		{
		}

		[Token(Token = "0x6000356")]
		[Address(RVA = "0xA1FBC4", Offset = "0xA1FBC4", VA = "0xA1FBC4")]
		public EventSoundsPointerEnterHandler()
		{
		}
	}
	[Token(Token = "0x2000084")]
	public class EventSoundsPointerExitHandler : EventSoundsUGUIHandler, IPointerExitHandler, IEventSystemHandler
	{
		[Token(Token = "0x6000357")]
		[Address(RVA = "0xA1FBCC", Offset = "0xA1FBCC", VA = "0xA1FBCC", Slot = "4")]
		public void OnPointerExit(PointerEventData data)
		{
		}

		[Token(Token = "0x6000358")]
		[Address(RVA = "0xA1FC74", Offset = "0xA1FC74", VA = "0xA1FC74")]
		public EventSoundsPointerExitHandler()
		{
		}
	}
	[Token(Token = "0x2000085")]
	public class EventSoundsPointerDownHandler : EventSoundsUGUIHandler, IPointerDownHandler, IEventSystemHandler
	{
		[Token(Token = "0x6000359")]
		[Address(RVA = "0xA1FA6C", Offset = "0xA1FA6C", VA = "0xA1FA6C", Slot = "4")]
		public void OnPointerDown(PointerEventData data)
		{
		}

		[Token(Token = "0x600035A")]
		[Address(RVA = "0xA1FB14", Offset = "0xA1FB14", VA = "0xA1FB14")]
		public EventSoundsPointerDownHandler()
		{
		}
	}
	[Token(Token = "0x2000086")]
	public class EventSoundsPointerUpHandler : EventSoundsUGUIHandler, IPointerUpHandler, IEventSystemHandler
	{
		[Token(Token = "0x600035B")]
		[Address(RVA = "0xA1FC7C", Offset = "0xA1FC7C", VA = "0xA1FC7C", Slot = "4")]
		public void OnPointerUp(PointerEventData data)
		{
		}

		[Token(Token = "0x600035C")]
		[Address(RVA = "0xA1FD24", Offset = "0xA1FD24", VA = "0xA1FD24")]
		public EventSoundsPointerUpHandler()
		{
		}
	}
	[Token(Token = "0x2000087")]
	public class EventSoundsDragHandler : EventSoundsUGUIHandler, IDragHandler, IEventSystemHandler
	{
		[Token(Token = "0x600035D")]
		[Address(RVA = "0xA1F6FC", Offset = "0xA1F6FC", VA = "0xA1F6FC", Slot = "4")]
		public void OnDrag(PointerEventData data)
		{
		}

		[Token(Token = "0x600035E")]
		[Address(RVA = "0xA1F7A4", Offset = "0xA1F7A4", VA = "0xA1F7A4")]
		public EventSoundsDragHandler()
		{
		}
	}
	[Token(Token = "0x2000088")]
	public class EventSoundsDropHandler : EventSoundsUGUIHandler, IDropHandler, IEventSystemHandler
	{
		[Token(Token = "0x600035F")]
		[Address(RVA = "0xA1F7AC", Offset = "0xA1F7AC", VA = "0xA1F7AC", Slot = "4")]
		public void OnDrop(PointerEventData data)
		{
		}

		[Token(Token = "0x6000360")]
		[Address(RVA = "0xA1F854", Offset = "0xA1F854", VA = "0xA1F854")]
		public EventSoundsDropHandler()
		{
		}
	}
	[Token(Token = "0x2000089")]
	public class EventSoundsScrollHandler : EventSoundsUGUIHandler, IScrollHandler, IEventSystemHandler
	{
		[Token(Token = "0x6000361")]
		[Address(RVA = "0xA1FD2C", Offset = "0xA1FD2C", VA = "0xA1FD2C", Slot = "4")]
		public void OnScroll(PointerEventData data)
		{
		}

		[Token(Token = "0x6000362")]
		[Address(RVA = "0xA1FDD4", Offset = "0xA1FDD4", VA = "0xA1FDD4")]
		public EventSoundsScrollHandler()
		{
		}
	}
	[Token(Token = "0x200008A")]
	public class EventSoundsUpdateSelectedHandler : EventSoundsUGUIHandler, IUpdateSelectedHandler, IEventSystemHandler
	{
		[Token(Token = "0x6000363")]
		[Address(RVA = "0xA1FF4C", Offset = "0xA1FF4C", VA = "0xA1FF4C", Slot = "4")]
		public void OnUpdateSelected(BaseEventData data)
		{
		}

		[Token(Token = "0x6000364")]
		[Address(RVA = "0xA1FFF4", Offset = "0xA1FFF4", VA = "0xA1FFF4")]
		public EventSoundsUpdateSelectedHandler()
		{
		}
	}
	[Token(Token = "0x200008B")]
	public class EventSoundsSelectHandler : EventSoundsUGUIHandler, ISelectHandler, IEventSystemHandler
	{
		[Token(Token = "0x6000365")]
		[Address(RVA = "0xA1FDDC", Offset = "0xA1FDDC", VA = "0xA1FDDC", Slot = "4")]
		public void OnSelect(BaseEventData data)
		{
		}

		[Token(Token = "0x6000366")]
		[Address(RVA = "0xA1FE84", Offset = "0xA1FE84", VA = "0xA1FE84")]
		public EventSoundsSelectHandler()
		{
		}
	}
	[Token(Token = "0x200008C")]
	public class EventSoundsDeselectHandler : EventSoundsUGUIHandler, IDeselectHandler, IEventSystemHandler
	{
		[Token(Token = "0x6000367")]
		[Address(RVA = "0xA1F64C", Offset = "0xA1F64C", VA = "0xA1F64C", Slot = "4")]
		public void OnDeselect(BaseEventData data)
		{
		}

		[Token(Token = "0x6000368")]
		[Address(RVA = "0xA1F6F4", Offset = "0xA1F6F4", VA = "0xA1F6F4")]
		public EventSoundsDeselectHandler()
		{
		}
	}
	[Token(Token = "0x200008D")]
	public class EventSoundsMoveHandler : EventSoundsUGUIHandler, IMoveHandler, IEventSystemHandler
	{
		[Token(Token = "0x6000369")]
		[Address(RVA = "0xA1F9BC", Offset = "0xA1F9BC", VA = "0xA1F9BC", Slot = "4")]
		public void OnMove(AxisEventData data)
		{
		}

		[Token(Token = "0x600036A")]
		[Address(RVA = "0xA1FA64", Offset = "0xA1FA64", VA = "0xA1FA64")]
		public EventSoundsMoveHandler()
		{
		}
	}
	[Token(Token = "0x200008E")]
	public class EventSoundsInitializePotentialDragHandler : EventSoundsUGUIHandler, IInitializePotentialDragHandler, IEventSystemHandler
	{
		[Token(Token = "0x600036B")]
		[Address(RVA = "0xA1F90C", Offset = "0xA1F90C", VA = "0xA1F90C", Slot = "4")]
		public void OnInitializePotentialDrag(PointerEventData data)
		{
		}

		[Token(Token = "0x600036C")]
		[Address(RVA = "0xA1F9B4", Offset = "0xA1F9B4", VA = "0xA1F9B4")]
		public EventSoundsInitializePotentialDragHandler()
		{
		}
	}
	[Token(Token = "0x200008F")]
	public class EventSoundsBeginDragHandler : EventSoundsUGUIHandler, IBeginDragHandler, IEventSystemHandler
	{
		[Token(Token = "0x600036D")]
		[Address(RVA = "0xA1F4E4", Offset = "0xA1F4E4", VA = "0xA1F4E4", Slot = "4")]
		public void OnBeginDrag(PointerEventData data)
		{
		}

		[Token(Token = "0x600036E")]
		[Address(RVA = "0xA1F58C", Offset = "0xA1F58C", VA = "0xA1F58C")]
		public EventSoundsBeginDragHandler()
		{
		}
	}
	[Token(Token = "0x2000090")]
	public class EventSoundsEndDragHandler : EventSoundsUGUIHandler, IEndDragHandler, IEventSystemHandler
	{
		[Token(Token = "0x600036F")]
		[Address(RVA = "0xA1F85C", Offset = "0xA1F85C", VA = "0xA1F85C", Slot = "4")]
		public void OnEndDrag(PointerEventData data)
		{
		}

		[Token(Token = "0x6000370")]
		[Address(RVA = "0xA1F904", Offset = "0xA1F904", VA = "0xA1F904")]
		public EventSoundsEndDragHandler()
		{
		}
	}
	[Token(Token = "0x2000091")]
	public class EventSoundsSubmitHandler : EventSoundsUGUIHandler, ISubmitHandler, IEventSystemHandler
	{
		[Token(Token = "0x6000371")]
		[Address(RVA = "0xA1FE8C", Offset = "0xA1FE8C", VA = "0xA1FE8C", Slot = "4")]
		public void OnSubmit(BaseEventData data)
		{
		}

		[Token(Token = "0x6000372")]
		[Address(RVA = "0xA1FF34", Offset = "0xA1FF34", VA = "0xA1FF34")]
		public EventSoundsSubmitHandler()
		{
		}
	}
	[Token(Token = "0x2000092")]
	public class EventSoundsCancelHandler : EventSoundsUGUIHandler, ICancelHandler, IEventSystemHandler
	{
		[Token(Token = "0x6000373")]
		[Address(RVA = "0xA1F59C", Offset = "0xA1F59C", VA = "0xA1F59C", Slot = "4")]
		public void OnCancel(BaseEventData data)
		{
		}

		[Token(Token = "0x6000374")]
		[Address(RVA = "0xA1F644", Offset = "0xA1F644", VA = "0xA1F644")]
		public EventSoundsCancelHandler()
		{
		}
	}
	[Token(Token = "0x2000093")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x981480", Offset = "0x981480")]
	public class FootstepSounds : MonoBehaviour
	{
		[Token(Token = "0x20000EE")]
		public enum FootstepTriggerMode
		{
			[Token(Token = "0x4000744")]
			None,
			[Token(Token = "0x4000745")]
			OnCollision,
			[Token(Token = "0x4000746")]
			OnTriggerEnter,
			[Token(Token = "0x4000747")]
			OnCollision2D,
			[Token(Token = "0x4000748")]
			OnTriggerEnter2D
		}

		[Token(Token = "0x4000345")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public MasterAudio.SoundSpawnLocationMode soundSpawnMode;

		[Token(Token = "0x4000346")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public FootstepTriggerMode footstepEvent;

		[Token(Token = "0x4000347")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public List<FootstepGroup> footstepGroups;

		[Token(Token = "0x4000348")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public EventSounds.RetriggerLimMode retriggerLimitMode;

		[Token(Token = "0x4000349")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public int limitPerXFrm;

		[Token(Token = "0x400034A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float limitPerXSec;

		[Token(Token = "0x400034B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public int triggeredLastFrame;

		[Token(Token = "0x400034C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float triggeredLastTime;

		[Token(Token = "0x400034D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Transform _trans;

		[Token(Token = "0x170000D1")]
		private Transform Trans
		{
			[Token(Token = "0x600037B")]
			[Address(RVA = "0xA224FC", Offset = "0xA224FC", VA = "0xA224FC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000375")]
		[Address(RVA = "0xA22038", Offset = "0xA22038", VA = "0xA22038")]
		private void OnTriggerEnter(Collider other)
		{
		}

		[Token(Token = "0x6000376")]
		[Address(RVA = "0xA2237C", Offset = "0xA2237C", VA = "0xA2237C")]
		private void OnCollisionEnter(Collision collision)
		{
		}

		[Token(Token = "0x6000377")]
		[Address(RVA = "0xA223CC", Offset = "0xA223CC", VA = "0xA223CC")]
		private void OnCollisionEnter2D(Collision2D collision)
		{
		}

		[Token(Token = "0x6000378")]
		[Address(RVA = "0xA2241C", Offset = "0xA2241C", VA = "0xA2241C")]
		private void OnTriggerEnter2D(Collider2D other)
		{
		}

		[Token(Token = "0x6000379")]
		[Address(RVA = "0xA2246C", Offset = "0xA2246C", VA = "0xA2246C")]
		private bool CheckForRetriggerLimit()
		{
			return default(bool);
		}

		[Token(Token = "0x600037A")]
		[Address(RVA = "0xA22088", Offset = "0xA22088", VA = "0xA22088")]
		private void PlaySoundsIfMatch(GameObject go)
		{
		}

		[Token(Token = "0x600037C")]
		[Address(RVA = "0xA2258C", Offset = "0xA2258C", VA = "0xA2258C")]
		public FootstepSounds()
		{
		}
	}
	[Token(Token = "0x2000094")]
	public class MechanimStateCustomEvents : StateMachineBehaviour
	{
		[Token(Token = "0x400034E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x98224C", Offset = "0x98224C")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x98224C", Offset = "0x98224C")]
		public bool RetriggerWhenStateLoops;

		[Token(Token = "0x400034F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9822AC", Offset = "0x9822AC")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9822AC", Offset = "0x9822AC")]
		public bool fireEnterEvent;

		[Token(Token = "0x4000350")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[MasterCustomEvent]
		public string enterCustomEvent;

		[Token(Token = "0x4000351")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x98231C", Offset = "0x98231C")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x98231C", Offset = "0x98231C")]
		public bool fireExitEvent;

		[Token(Token = "0x4000352")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[MasterCustomEvent]
		public string exitCustomEvent;

		[Token(Token = "0x4000353")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x98238C", Offset = "0x98238C")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x98238C", Offset = "0x98238C")]
		public bool fireAnimTimeEvent;

		[Token(Token = "0x4000354")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9823EC", Offset = "0x9823EC")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9823EC", Offset = "0x9823EC")]
		public float whenToFireEvent;

		[Token(Token = "0x4000355")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[MasterCustomEvent]
		public string timedCustomEvent;

		[Token(Token = "0x4000356")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x982450", Offset = "0x982450")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x982450", Offset = "0x982450")]
		public bool fireMultiAnimTimeEvent;

		[Token(Token = "0x4000357")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9824B0", Offset = "0x9824B0")]
		public int numOfMultiEventsToFire;

		[Token(Token = "0x4000358")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9824C8", Offset = "0x9824C8")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9824C8", Offset = "0x9824C8")]
		public float whenToFireMultiEvent1;

		[Token(Token = "0x4000359")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x98251C", Offset = "0x98251C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x98251C", Offset = "0x98251C")]
		public float whenToFireMultiEvent2;

		[Token(Token = "0x400035A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x982570", Offset = "0x982570")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x982570", Offset = "0x982570")]
		public float whenToFireMultiEvent3;

		[Token(Token = "0x400035B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9825C4", Offset = "0x9825C4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9825C4", Offset = "0x9825C4")]
		public float whenToFireMultiEvent4;

		[Token(Token = "0x400035C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[MasterCustomEvent]
		public string MultiTimedEvent;

		[Token(Token = "0x400035D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private bool _playMultiEvent1;

		[Token(Token = "0x400035E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x69")]
		private bool _playMultiEvent2;

		[Token(Token = "0x400035F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6A")]
		private bool _playMultiEvent3;

		[Token(Token = "0x4000360")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6B")]
		private bool _playMultiEvent4;

		[Token(Token = "0x4000361")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private bool _fireTimedEvent;

		[Token(Token = "0x4000362")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Transform _actorTrans;

		[Token(Token = "0x4000363")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private int _lastRepetition;

		[Token(Token = "0x600037D")]
		[Address(RVA = "0xFEA6DC", Offset = "0xFEA6DC", VA = "0xFEA6DC", Slot = "4")]
		public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
		{
		}

		[Token(Token = "0x600037E")]
		[Address(RVA = "0xFEA85C", Offset = "0xFEA85C", VA = "0xFEA85C", Slot = "5")]
		public override void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
		{
		}

		[Token(Token = "0x600037F")]
		[Address(RVA = "0xFEAB88", Offset = "0xFEAB88", VA = "0xFEAB88", Slot = "6")]
		public override void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
		{
		}

		[Token(Token = "0x6000380")]
		[Address(RVA = "0xFEA7B8", Offset = "0xFEA7B8", VA = "0xFEA7B8")]
		private Transform ActorTrans(Animator anim)
		{
			return null;
		}

		[Token(Token = "0x6000381")]
		[Address(RVA = "0xFEAC60", Offset = "0xFEAC60", VA = "0xFEAC60")]
		public MechanimStateCustomEvents()
		{
		}
	}
	[Token(Token = "0x2000095")]
	public class MechanimStateSounds : StateMachineBehaviour
	{
		[Token(Token = "0x4000364")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x982628", Offset = "0x982628")]
		public bool SoundFollowsObject;

		[Token(Token = "0x4000365")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x982660", Offset = "0x982660")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x982660", Offset = "0x982660")]
		public bool RetriggerWhenStateLoops;

		[Token(Token = "0x4000366")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9826C0", Offset = "0x9826C0")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9826C0", Offset = "0x9826C0")]
		public bool playEnterSound;

		[Token(Token = "0x4000367")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B")]
		public bool stopEnterSoundOnExit;

		[Token(Token = "0x4000368")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SoundGroup]
		public string enterSoundGroup;

		[Token(Token = "0x4000369")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x982730", Offset = "0x982730")]
		public string enterVariationName;

		[Token(Token = "0x400036A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private bool wasEnterSoundPlayed;

		[Token(Token = "0x400036B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x982768", Offset = "0x982768")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x982768", Offset = "0x982768")]
		public bool playExitSound;

		[Token(Token = "0x400036C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SoundGroup]
		public string exitSoundGroup;

		[Token(Token = "0x400036D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9827D8", Offset = "0x9827D8")]
		public string exitVariationName;

		[Token(Token = "0x400036E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x982810", Offset = "0x982810")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x982810", Offset = "0x982810")]
		public bool playAnimTimeSound;

		[Token(Token = "0x400036F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x49")]
		public bool stopAnimTimeSoundOnExit;

		[Token(Token = "0x4000370")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4A")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x982870", Offset = "0x982870")]
		public bool useStopTime;

		[Token(Token = "0x4000371")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9828A8", Offset = "0x9828A8")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9828A8", Offset = "0x9828A8")]
		public float whenToStartSound;

		[Token(Token = "0x4000372")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9828FC", Offset = "0x9828FC")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9828FC", Offset = "0x9828FC")]
		public float whenToStopSound;

		[Token(Token = "0x4000373")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SoundGroup]
		public string TimedSoundGroup;

		[Token(Token = "0x4000374")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x982960", Offset = "0x982960")]
		public string timedVariationName;

		[Token(Token = "0x4000375")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private bool playSoundStart;

		[Token(Token = "0x4000376")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x69")]
		private bool playSoundStop;

		[Token(Token = "0x4000377")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6A")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x982998", Offset = "0x982998")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x982998", Offset = "0x982998")]
		public bool playMultiAnimTimeSounds;

		[Token(Token = "0x4000378")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6B")]
		public bool StopMultiAnimTimeSoundsOnExit;

		[Token(Token = "0x4000379")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9829F8", Offset = "0x9829F8")]
		public int numOfMultiSoundsToPlay;

		[Token(Token = "0x400037A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x982A10", Offset = "0x982A10")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x982A10", Offset = "0x982A10")]
		public float whenToStartMultiSound1;

		[Token(Token = "0x400037B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x982A64", Offset = "0x982A64")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x982A64", Offset = "0x982A64")]
		public float whenToStartMultiSound2;

		[Token(Token = "0x400037C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x982AB8", Offset = "0x982AB8")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x982AB8", Offset = "0x982AB8")]
		public float whenToStartMultiSound3;

		[Token(Token = "0x400037D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x982B0C", Offset = "0x982B0C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x982B0C", Offset = "0x982B0C")]
		public float whenToStartMultiSound4;

		[Token(Token = "0x400037E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[SoundGroup]
		public string MultiSoundsTimedGroup;

		[Token(Token = "0x400037F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x982B70", Offset = "0x982B70")]
		public string multiTimedVariationName;

		[Token(Token = "0x4000380")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private bool playMultiSound1;

		[Token(Token = "0x4000381")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x91")]
		private bool playMultiSound2;

		[Token(Token = "0x4000382")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x92")]
		private bool playMultiSound3;

		[Token(Token = "0x4000383")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x93")]
		private bool playMultiSound4;

		[Token(Token = "0x4000384")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Transform _actorTrans;

		[Token(Token = "0x4000385")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private int _lastRepetition;

		[Token(Token = "0x6000382")]
		[Address(RVA = "0xFEACDC", Offset = "0xFEACDC", VA = "0xFEACDC", Slot = "4")]
		public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
		{
		}

		[Token(Token = "0x6000383")]
		[Address(RVA = "0xFEAF58", Offset = "0xFEAF58", VA = "0xFEAF58", Slot = "5")]
		public override void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
		{
		}

		[Token(Token = "0x6000384")]
		[Address(RVA = "0xFEB6FC", Offset = "0xFEB6FC", VA = "0xFEB6FC", Slot = "6")]
		public override void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
		{
		}

		[Token(Token = "0x6000385")]
		[Address(RVA = "0xFEAE5C", Offset = "0xFEAE5C", VA = "0xFEAE5C")]
		private Transform ActorTrans(Animator anim)
		{
			return null;
		}

		[Token(Token = "0x6000386")]
		[Address(RVA = "0xFEAF00", Offset = "0xFEAF00", VA = "0xFEAF00")]
		private static string GetVariationName(string varName)
		{
			return null;
		}

		[Token(Token = "0x6000387")]
		[Address(RVA = "0xFEB948", Offset = "0xFEB948", VA = "0xFEB948")]
		public MechanimStateSounds()
		{
		}
	}
	[Token(Token = "0x2000096")]
	[SerializeField]
	public class PlaySoundResult
	{
		[Token(Token = "0x4000386")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x982BA8", Offset = "0x982BA8")]
		private bool <SoundPlayed>k__BackingField;

		[Token(Token = "0x4000387")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x982BB8", Offset = "0x982BB8")]
		private bool <SoundScheduled>k__BackingField;

		[Token(Token = "0x4000388")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x982BC8", Offset = "0x982BC8")]
		private SoundGroupVariation <ActingVariation>k__BackingField;

		[Token(Token = "0x170000D2")]
		public bool SoundPlayed
		{
			[Token(Token = "0x6000389")]
			[Address(RVA = "0xFED288", Offset = "0xFED288", VA = "0xFED288")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x983BD8", Offset = "0x983BD8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600038A")]
			[Address(RVA = "0xFED290", Offset = "0xFED290", VA = "0xFED290")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x983BE8", Offset = "0x983BE8")]
			set
			{
			}
		}

		[Token(Token = "0x170000D3")]
		public bool SoundScheduled
		{
			[Token(Token = "0x600038B")]
			[Address(RVA = "0xFED29C", Offset = "0xFED29C", VA = "0xFED29C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x983BF8", Offset = "0x983BF8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600038C")]
			[Address(RVA = "0xFED2A4", Offset = "0xFED2A4", VA = "0xFED2A4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x983C08", Offset = "0x983C08")]
			set
			{
			}
		}

		[Token(Token = "0x170000D4")]
		public SoundGroupVariation ActingVariation
		{
			[Token(Token = "0x600038D")]
			[Address(RVA = "0xFED2B0", Offset = "0xFED2B0", VA = "0xFED2B0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x983C18", Offset = "0x983C18")]
			get
			{
				return null;
			}
			[Token(Token = "0x600038E")]
			[Address(RVA = "0xFED2B8", Offset = "0xFED2B8", VA = "0xFED2B8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x983C28", Offset = "0x983C28")]
			set
			{
			}
		}

		[Token(Token = "0x6000388")]
		[Address(RVA = "0xFED25C", Offset = "0xFED25C", VA = "0xFED25C")]
		public PlaySoundResult()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000097")]
	public class AudioEvent
	{
		[Token(Token = "0x20000EF")]
		public enum TargetVolumeMode
		{
			[Token(Token = "0x400074A")]
			UseSliderValue,
			[Token(Token = "0x400074B")]
			UseSpecificValue
		}

		[Serializable]
		[Token(Token = "0x20000F0")]
		public class MA_SnapshotInfo
		{
			[Token(Token = "0x400074C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public AudioMixerSnapshot snapshot;

			[Token(Token = "0x400074D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float weight;

			[Token(Token = "0x600070B")]
			[Address(RVA = "0xA05BBC", Offset = "0xA05BBC", VA = "0xA05BBC")]
			public MA_SnapshotInfo(AudioMixerSnapshot snap, float wt)
			{
			}
		}

		[Token(Token = "0x4000389")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string actionName;

		[Token(Token = "0x400038A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool isExpanded;

		[Token(Token = "0x400038B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string soundType;

		[Token(Token = "0x400038C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool allPlaylistControllersForGroupCmd;

		[Token(Token = "0x400038D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
		public bool allSoundTypesForGroupCmd;

		[Token(Token = "0x400038E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2A")]
		public bool allSoundTypesForBusCmd;

		[Token(Token = "0x400038F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float volume;

		[Token(Token = "0x4000390")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool useFixedPitch;

		[Token(Token = "0x4000391")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float pitch;

		[Token(Token = "0x4000392")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public EventSounds.GlidePitchType glidePitchType;

		[Token(Token = "0x4000393")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float targetGlidePitch;

		[Token(Token = "0x4000394")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float pitchGlideTime;

		[Token(Token = "0x4000395")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float delaySound;

		[Token(Token = "0x4000396")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public MasterAudio.EventSoundFunctionType currentSoundFunctionType;

		[Token(Token = "0x4000397")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public MasterAudio.PlaylistCommand currentPlaylistCommand;

		[Token(Token = "0x4000398")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public MasterAudio.SoundGroupCommand currentSoundGroupCommand;

		[Token(Token = "0x4000399")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public MasterAudio.BusCommand currentBusCommand;

		[Token(Token = "0x400039A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public MasterAudio.CustomEventCommand currentCustomEventCommand;

		[Token(Token = "0x400039B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public MasterAudio.GlobalCommand currentGlobalCommand;

		[Token(Token = "0x400039C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public MasterAudio.UnityMixerCommand currentMixerCommand;

		[Token(Token = "0x400039D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public AudioMixerSnapshot snapshotToTransitionTo;

		[Token(Token = "0x400039E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public float snapshotTransitionTime;

		[Token(Token = "0x400039F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public List<MA_SnapshotInfo> snapshotsToBlend;

		[Token(Token = "0x40003A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public MasterAudio.PersistentSettingsCommand currentPersistentSettingsCommand;

		[Token(Token = "0x40003A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public string busName;

		[Token(Token = "0x40003A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public string playlistName;

		[Token(Token = "0x40003A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public string playlistControllerName;

		[Token(Token = "0x40003A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public bool startPlaylist;

		[Token(Token = "0x40003A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		public float fadeVolume;

		[Token(Token = "0x40003A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public float fadeTime;

		[Token(Token = "0x40003A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		public bool stopAfterFade;

		[Token(Token = "0x40003A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAD")]
		public bool restoreVolumeAfterFade;

		[Token(Token = "0x40003A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public TargetVolumeMode targetVolMode;

		[Token(Token = "0x40003AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public string clipName;

		[Token(Token = "0x40003AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public EventSounds.VariationType variationType;

		[Token(Token = "0x40003AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public string variationName;

		[Token(Token = "0x40003AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public float colliderMaxDistance;

		[Token(Token = "0x40003AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		public bool showSphereGizmo;

		[Token(Token = "0x40003AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		public string theCustomEventName;

		[Token(Token = "0x170000D5")]
		public bool IsFadeCommand
		{
			[Token(Token = "0x600038F")]
			[Address(RVA = "0xA059F4", Offset = "0xA059F4", VA = "0xA059F4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000390")]
		[Address(RVA = "0xA05A5C", Offset = "0xA05A5C", VA = "0xA05A5C")]
		public AudioEvent()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000098")]
	public class AudioEventGroup
	{
		[Token(Token = "0x40003B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public bool isExpanded;

		[Token(Token = "0x40003B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11")]
		public bool allPlayersShouldHear;

		[Token(Token = "0x40003B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x12")]
		public bool useLayerFilter;

		[Token(Token = "0x40003B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x13")]
		public bool useTagFilter;

		[Token(Token = "0x40003B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public List<int> matchingLayers;

		[Token(Token = "0x40003B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public List<string> matchingTags;

		[Token(Token = "0x40003B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool customSoundActive;

		[Token(Token = "0x40003B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
		public bool isCustomEvent;

		[Token(Token = "0x40003B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string customEventName;

		[Token(Token = "0x40003B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public bool mechanimEventActive;

		[Token(Token = "0x40003BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x39")]
		public bool isMechanimStateCheckEvent;

		[Token(Token = "0x40003BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public string mechanimStateName;

		[Token(Token = "0x40003BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public bool mechEventPlayedForState;

		[Token(Token = "0x40003BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public List<AudioEvent> SoundEvents;

		[Token(Token = "0x40003BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public EventSounds.PreviousSoundStopMode mouseDragStopMode;

		[Token(Token = "0x40003BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public float mouseDragFadeOutTime;

		[Token(Token = "0x40003C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public EventSounds.RetriggerLimMode retriggerLimitMode;

		[Token(Token = "0x40003C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public int limitPerXFrm;

		[Token(Token = "0x40003C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public float limitPerXSec;

		[Token(Token = "0x40003C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public int triggeredLastFrame;

		[Token(Token = "0x40003C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public float triggeredLastTime;

		[Token(Token = "0x40003C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		public float triggerStayForTime;

		[Token(Token = "0x40003C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public bool doesTriggerStayRepeat;

		[Token(Token = "0x40003C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		public float sliderValue;

		[Token(Token = "0x6000391")]
		[Address(RVA = "0xA05BF8", Offset = "0xA05BF8", VA = "0xA05BF8")]
		public AudioEventGroup()
		{
		}
	}
	[Token(Token = "0x2000099")]
	public class AudioScriptOrder : Attribute
	{
		[Token(Token = "0x40003C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int Order;

		[Token(Token = "0x6000392")]
		[Address(RVA = "0xA097CC", Offset = "0xA097CC", VA = "0xA097CC")]
		public AudioScriptOrder(int order)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200009A")]
	public class BusFadeInfo
	{
		[Token(Token = "0x40003C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string NameOfBus;

		[Token(Token = "0x40003CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GroupBus ActingBus;

		[Token(Token = "0x40003CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float StartVolume;

		[Token(Token = "0x40003CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float TargetVolume;

		[Token(Token = "0x40003CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float StartTime;

		[Token(Token = "0x40003CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float CompletionTime;

		[Token(Token = "0x40003CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool IsActive;

		[Token(Token = "0x40003D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
		public bool WillStopGroupAfterFade;

		[Token(Token = "0x40003D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x32")]
		public bool WillResetVolumeAfterFade;

		[Token(Token = "0x40003D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Action completionAction;

		[Token(Token = "0x6000393")]
		[Address(RVA = "0xA0C364", Offset = "0xA0C364", VA = "0xA0C364")]
		public BusFadeInfo()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200009B")]
	public class BusPitchGlideInfo
	{
		[Token(Token = "0x40003D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string NameOfBus;

		[Token(Token = "0x40003D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float CompletionTime;

		[Token(Token = "0x40003D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public bool IsActive;

		[Token(Token = "0x40003D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public List<SoundGroupVariation> GlidingVariations;

		[Token(Token = "0x40003D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Action completionAction;

		[Token(Token = "0x6000394")]
		[Address(RVA = "0xA0C374", Offset = "0xA0C374", VA = "0xA0C374")]
		public BusPitchGlideInfo()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200009C")]
	public class CustomEvent
	{
		[Token(Token = "0x40003D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string EventName;

		[Token(Token = "0x40003D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string ProspectiveName;

		[Token(Token = "0x40003DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool IsEditing;

		[Token(Token = "0x40003DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
		public bool eventExpanded;

		[Token(Token = "0x40003DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public MasterAudio.CustomEventReceiveMode eventReceiveMode;

		[Token(Token = "0x40003DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float distanceThreshold;

		[Token(Token = "0x40003DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public MasterAudio.EventReceiveFilter eventRcvFilterMode;

		[Token(Token = "0x40003DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public int filterModeQty;

		[Token(Token = "0x40003E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public bool isTemporary;

		[Token(Token = "0x40003E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public int frameLastFired;

		[Token(Token = "0x40003E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public string categoryName;

		[Token(Token = "0x6000395")]
		[Address(RVA = "0xA0D004", Offset = "0xA0D004", VA = "0xA0D004")]
		public CustomEvent(string eventName)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200009D")]
	public class CustomEventCategory
	{
		[Token(Token = "0x40003E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string CatName;

		[Token(Token = "0x40003E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool IsExpanded;

		[Token(Token = "0x40003E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		public bool IsEditing;

		[Token(Token = "0x40003E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
		public bool IsTemporary;

		[Token(Token = "0x40003E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string ProspectiveName;

		[Token(Token = "0x6000396")]
		[Address(RVA = "0xA0D08C", Offset = "0xA0D08C", VA = "0xA0D08C")]
		public CustomEventCategory()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200009E")]
	public class CustomEventToFireInfo
	{
		[Token(Token = "0x40003E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string eventName;

		[Token(Token = "0x40003E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform eventOrigin;

		[Token(Token = "0x6000397")]
		[Address(RVA = "0xA0D0F0", Offset = "0xA0D0F0", VA = "0xA0D0F0")]
		public CustomEventToFireInfo()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200009F")]
	public class DuckGroupInfo
	{
		[Token(Token = "0x40003EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string soundType;

		[Token(Token = "0x40003EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float riseVolStart;

		[Token(Token = "0x40003EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float unduckTime;

		[Token(Token = "0x40003ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float duckedVolumeCut;

		[Token(Token = "0x40003EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public bool isTemporary;

		[Token(Token = "0x6000398")]
		[Address(RVA = "0xA0D598", Offset = "0xA0D598", VA = "0xA0D598")]
		public DuckGroupInfo()
		{
		}
	}
	[Token(Token = "0x20000A0")]
	public class DynamicGroupVariation : MonoBehaviour
	{
		[Token(Token = "0x40003EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x982BD8", Offset = "0x982BD8")]
		public int probabilityToPlay;

		[Token(Token = "0x40003F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public bool useLocalization;

		[Token(Token = "0x40003F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D")]
		public bool useRandomPitch;

		[Token(Token = "0x40003F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public SoundGroupVariation.RandomPitchMode randomPitchMode;

		[Token(Token = "0x40003F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float randomPitchMin;

		[Token(Token = "0x40003F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float randomPitchMax;

		[Token(Token = "0x40003F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public bool useRandomVolume;

		[Token(Token = "0x40003F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public SoundGroupVariation.RandomVolumeMode randomVolumeMode;

		[Token(Token = "0x40003F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float randomVolumeMin;

		[Token(Token = "0x40003F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float randomVolumeMax;

		[Token(Token = "0x40003F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public int weight;

		[Token(Token = "0x40003FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public MasterAudio.AudioLocation audLocation;

		[Token(Token = "0x40003FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public string resourceFileName;

		[Token(Token = "0x40003FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public string internetFileUrl;

		[Token(Token = "0x40003FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public bool isExpanded;

		[Token(Token = "0x40003FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x59")]
		public bool isChecked;

		[Token(Token = "0x40003FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5A")]
		public bool useFades;

		[Token(Token = "0x4000400")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public float fadeInTime;

		[Token(Token = "0x4000401")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public float fadeOutTime;

		[Token(Token = "0x4000402")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public bool useCustomLooping;

		[Token(Token = "0x4000403")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public int minCustomLoops;

		[Token(Token = "0x4000404")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public int maxCustomLoops;

		[Token(Token = "0x4000405")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public bool useIntroSilence;

		[Token(Token = "0x4000406")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		public float introSilenceMin;

		[Token(Token = "0x4000407")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public float introSilenceMax;

		[Token(Token = "0x4000408")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		public bool useRandomStartTime;

		[Token(Token = "0x4000409")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public float randomStartMinPercent;

		[Token(Token = "0x400040A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		public float randomStartMaxPercent;

		[Token(Token = "0x400040B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public float randomEndPercent;

		[Token(Token = "0x400040C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private AudioDistortionFilter _distFilter;

		[Token(Token = "0x400040D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private AudioEchoFilter _echoFilter;

		[Token(Token = "0x400040E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private AudioHighPassFilter _hpFilter;

		[Token(Token = "0x400040F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private AudioLowPassFilter _lpFilter;

		[Token(Token = "0x4000410")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private AudioReverbFilter _reverbFilter;

		[Token(Token = "0x4000411")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private AudioChorusFilter _chorusFilter;

		[Token(Token = "0x4000412")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private DynamicSoundGroup _parentGroupScript;

		[Token(Token = "0x4000413")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private Transform _trans;

		[Token(Token = "0x4000414")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private AudioSource _aud;

		[Token(Token = "0x170000D6")]
		public AudioDistortionFilter DistortionFilter
		{
			[Token(Token = "0x6000399")]
			[Address(RVA = "0xA0D604", Offset = "0xA0D604", VA = "0xA0D604")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000D7")]
		public AudioReverbFilter ReverbFilter
		{
			[Token(Token = "0x600039A")]
			[Address(RVA = "0xA0D69C", Offset = "0xA0D69C", VA = "0xA0D69C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000D8")]
		public AudioChorusFilter ChorusFilter
		{
			[Token(Token = "0x600039B")]
			[Address(RVA = "0xA0D734", Offset = "0xA0D734", VA = "0xA0D734")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000D9")]
		public AudioEchoFilter EchoFilter
		{
			[Token(Token = "0x600039C")]
			[Address(RVA = "0xA0D7CC", Offset = "0xA0D7CC", VA = "0xA0D7CC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000DA")]
		public AudioLowPassFilter LowPassFilter
		{
			[Token(Token = "0x600039D")]
			[Address(RVA = "0xA0D864", Offset = "0xA0D864", VA = "0xA0D864")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000DB")]
		public AudioHighPassFilter HighPassFilter
		{
			[Token(Token = "0x600039E")]
			[Address(RVA = "0xA0D8FC", Offset = "0xA0D8FC", VA = "0xA0D8FC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000DC")]
		public DynamicSoundGroup ParentGroup
		{
			[Token(Token = "0x600039F")]
			[Address(RVA = "0xA0D994", Offset = "0xA0D994", VA = "0xA0D994")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000DD")]
		public Transform Trans
		{
			[Token(Token = "0x60003A0")]
			[Address(RVA = "0xA0DAE8", Offset = "0xA0DAE8", VA = "0xA0DAE8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000DE")]
		public bool HasActiveFXFilter
		{
			[Token(Token = "0x60003A1")]
			[Address(RVA = "0xA0DB78", Offset = "0xA0DB78", VA = "0xA0DB78")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000DF")]
		public AudioSource VarAudio
		{
			[Token(Token = "0x60003A2")]
			[Address(RVA = "0xA0DDD0", Offset = "0xA0DDD0", VA = "0xA0DDD0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60003A3")]
		[Address(RVA = "0xA0DE68", Offset = "0xA0DE68", VA = "0xA0DE68")]
		public DynamicGroupVariation()
		{
		}
	}
	[Token(Token = "0x20000A1")]
	public class DynamicSoundGroup : MonoBehaviour
	{
		[Token(Token = "0x4000415")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject variationTemplate;

		[Token(Token = "0x4000416")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool alwaysHighestPriority;

		[Token(Token = "0x4000417")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float groupMasterVolume;

		[Token(Token = "0x4000418")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public int retriggerPercentage;

		[Token(Token = "0x4000419")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public MasterAudioGroup.VariationSequence curVariationSequence;

		[Token(Token = "0x400041A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool useNoRepeatRefill;

		[Token(Token = "0x400041B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
		public bool useInactivePeriodPoolRefill;

		[Token(Token = "0x400041C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float inactivePeriodSeconds;

		[Token(Token = "0x400041D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public MasterAudioGroup.VariationMode curVariationMode;

		[Token(Token = "0x400041E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public MasterAudio.AudioLocation bulkVariationMode;

		[Token(Token = "0x400041F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float chainLoopDelayMin;

		[Token(Token = "0x4000420")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float chainLoopDelayMax;

		[Token(Token = "0x4000421")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public MasterAudioGroup.ChainedLoopLoopMode chainLoopMode;

		[Token(Token = "0x4000422")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public int chainLoopNumLoops;

		[Token(Token = "0x4000423")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public bool useDialogFadeOut;

		[Token(Token = "0x4000424")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public float dialogFadeOutTime;

		[Token(Token = "0x4000425")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public bool resourceClipsAllLoadAsync;

		[Token(Token = "0x4000426")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x59")]
		public bool logSound;

		[Token(Token = "0x4000427")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5A")]
		public bool soundPlayedEventActive;

		[Token(Token = "0x4000428")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public string soundPlayedCustomEvent;

		[Token(Token = "0x4000429")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public int busIndex;

		[Token(Token = "0x400042A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public MasterAudio.ItemSpatialBlendType spatialBlendType;

		[Token(Token = "0x400042B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public float spatialBlend;

		[Token(Token = "0x400042C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public string busName;

		[Token(Token = "0x400042D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public bool isExistingBus;

		[Token(Token = "0x400042E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x81")]
		public bool isCopiedFromDGSC;

		[Token(Token = "0x400042F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		public MasterAudioGroup.LimitMode limitMode;

		[Token(Token = "0x4000430")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public int limitPerXFrames;

		[Token(Token = "0x4000431")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		public float minimumTimeBetween;

		[Token(Token = "0x4000432")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public bool limitPolyphony;

		[Token(Token = "0x4000433")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		public int voiceLimitCount;

		[Token(Token = "0x4000434")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public MasterAudioGroup.TargetDespawnedBehavior targetDespawnedBehavior;

		[Token(Token = "0x4000435")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		public float despawnFadeTime;

		[Token(Token = "0x4000436")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public bool isUsingOcclusion;

		[Token(Token = "0x4000437")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA1")]
		public bool willOcclusionOverrideRaycastOffset;

		[Token(Token = "0x4000438")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		public float occlusionRayCastOffset;

		[Token(Token = "0x4000439")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public bool willOcclusionOverrideFrequencies;

		[Token(Token = "0x400043A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		public float occlusionMaxCutoffFreq;

		[Token(Token = "0x400043B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public float occlusionMinCutoffFreq;

		[Token(Token = "0x400043C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		public bool copySettingsExpanded;

		[Token(Token = "0x400043D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB5")]
		public bool expandLinkedGroups;

		[Token(Token = "0x400043E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public List<string> childSoundGroups;

		[Token(Token = "0x400043F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public List<string> endLinkedGroups;

		[Token(Token = "0x4000440")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public MasterAudio.LinkedGroupSelectionType linkedStartGroupSelectionType;

		[Token(Token = "0x4000441")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		public MasterAudio.LinkedGroupSelectionType linkedStopGroupSelectionType;

		[Token(Token = "0x4000442")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public List<DynamicGroupVariation> groupVariations;

		[Token(Token = "0x60003A4")]
		[Address(RVA = "0xA0DEA0", Offset = "0xA0DEA0", VA = "0xA0DEA0")]
		public DynamicSoundGroup()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000A2")]
	public class FootstepGroup
	{
		[Token(Token = "0x4000443")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public bool isExpanded;

		[Token(Token = "0x4000444")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11")]
		public bool useLayerFilter;

		[Token(Token = "0x4000445")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x12")]
		public bool useTagFilter;

		[Token(Token = "0x4000446")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public List<int> matchingLayers;

		[Token(Token = "0x4000447")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public List<string> matchingTags;

		[Token(Token = "0x4000448")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string soundType;

		[Token(Token = "0x4000449")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public EventSounds.VariationType variationType;

		[Token(Token = "0x400044A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public string variationName;

		[Token(Token = "0x400044B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float volume;

		[Token(Token = "0x400044C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public bool useFixedPitch;

		[Token(Token = "0x400044D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float pitch;

		[Token(Token = "0x400044E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public float delaySound;

		[Token(Token = "0x60003A5")]
		[Address(RVA = "0xA21F18", Offset = "0xA21F18", VA = "0xA21F18")]
		public FootstepGroup()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000A3")]
	public class GroupBus
	{
		[Token(Token = "0x400044F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string busName;

		[Token(Token = "0x4000450")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float volume;

		[Token(Token = "0x4000451")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public bool isSoloed;

		[Token(Token = "0x4000452")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D")]
		public bool isMuted;

		[Token(Token = "0x4000453")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public int voiceLimit;

		[Token(Token = "0x4000454")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public bool stopOldest;

		[Token(Token = "0x4000455")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x25")]
		public bool isExisting;

		[Token(Token = "0x4000456")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x26")]
		public bool isTemporary;

		[Token(Token = "0x4000457")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x27")]
		public bool isUsingOcclusion;

		[Token(Token = "0x4000458")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public AudioMixerGroup mixerChannel;

		[Token(Token = "0x4000459")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool forceTo2D;

		[Token(Token = "0x400045A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private readonly List<int> _activeAudioSourcesIds;

		[Token(Token = "0x400045B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private float _originalVolume;

		[Token(Token = "0x170000E0")]
		public int ActiveVoices
		{
			[Token(Token = "0x60003A8")]
			[Address(RVA = "0xA22714", Offset = "0xA22714", VA = "0xA22714")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170000E1")]
		public bool BusVoiceLimitReached
		{
			[Token(Token = "0x60003A9")]
			[Address(RVA = "0xA22764", Offset = "0xA22764", VA = "0xA22764")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000E2")]
		public float OriginalVolume
		{
			[Token(Token = "0x60003AA")]
			[Address(RVA = "0xA227D0", Offset = "0xA227D0", VA = "0xA227D0")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60003AB")]
			[Address(RVA = "0xA227D8", Offset = "0xA227D8", VA = "0xA227D8")]
			set
			{
			}
		}

		[Token(Token = "0x60003A6")]
		[Address(RVA = "0xA22614", Offset = "0xA22614", VA = "0xA22614")]
		public void AddActiveAudioSourceId(int id)
		{
		}

		[Token(Token = "0x60003A7")]
		[Address(RVA = "0xA226AC", Offset = "0xA226AC", VA = "0xA226AC")]
		public void RemoveActiveAudioSourceId(int id)
		{
		}

		[Token(Token = "0x60003AC")]
		[Address(RVA = "0xA227E0", Offset = "0xA227E0", VA = "0xA227E0")]
		public GroupBus()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000A4")]
	public class GroupFadeInfo
	{
		[Token(Token = "0x400045C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public MasterAudioGroup ActingGroup;

		[Token(Token = "0x400045D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string NameOfGroup;

		[Token(Token = "0x400045E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float StartVolume;

		[Token(Token = "0x400045F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float TargetVolume;

		[Token(Token = "0x4000460")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float StartTime;

		[Token(Token = "0x4000461")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float CompletionTime;

		[Token(Token = "0x4000462")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool IsActive;

		[Token(Token = "0x4000463")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
		public bool WillStopGroupAfterFade;

		[Token(Token = "0x4000464")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x32")]
		public bool WillResetVolumeAfterFade;

		[Token(Token = "0x4000465")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Action completionAction;

		[Token(Token = "0x60003AD")]
		[Address(RVA = "0xA22870", Offset = "0xA22870", VA = "0xA22870")]
		public GroupFadeInfo()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000A5")]
	public class GroupPitchGlideInfo
	{
		[Token(Token = "0x4000466")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public MasterAudioGroup ActingGroup;

		[Token(Token = "0x4000467")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string NameOfGroup;

		[Token(Token = "0x4000468")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float CompletionTime;

		[Token(Token = "0x4000469")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public bool IsActive;

		[Token(Token = "0x400046A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public List<SoundGroupVariation> GlidingVariations;

		[Token(Token = "0x400046B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Action completionAction;

		[Token(Token = "0x60003AE")]
		[Address(RVA = "0xA22880", Offset = "0xA22880", VA = "0xA22880")]
		public GroupPitchGlideInfo()
		{
		}
	}
	[Token(Token = "0x20000A6")]
	public interface ICustomEventReceiver
	{
		[Token(Token = "0x60003AF")]
		void CheckForIllegalCustomEvents();

		[Token(Token = "0x60003B0")]
		void ReceiveEvent(string customEventName, Vector3 originPoint);

		[Token(Token = "0x60003B1")]
		bool SubscribesToEvent(string customEventName);

		[Token(Token = "0x60003B2")]
		void RegisterReceiver();

		[Token(Token = "0x60003B3")]
		void UnregisterReceiver();

		[Token(Token = "0x60003B4")]
		IList<AudioEventGroup> GetAllEvents();
	}
	[Token(Token = "0x20000A7")]
	public class MasterAudioGroup : MonoBehaviour
	{
		[Token(Token = "0x20000F1")]
		public enum TargetDespawnedBehavior
		{
			[Token(Token = "0x400074F")]
			None,
			[Token(Token = "0x4000750")]
			Stop,
			[Token(Token = "0x4000751")]
			FadeOut
		}

		[Token(Token = "0x20000F2")]
		public enum VariationSequence
		{
			[Token(Token = "0x4000753")]
			Randomized,
			[Token(Token = "0x4000754")]
			TopToBottom
		}

		[Token(Token = "0x20000F3")]
		public enum VariationMode
		{
			[Token(Token = "0x4000756")]
			Normal,
			[Token(Token = "0x4000757")]
			LoopedChain,
			[Token(Token = "0x4000758")]
			Dialog
		}

		[Token(Token = "0x20000F4")]
		public enum ChainedLoopLoopMode
		{
			[Token(Token = "0x400075A")]
			Endless,
			[Token(Token = "0x400075B")]
			NumberOfLoops
		}

		[Token(Token = "0x20000F5")]
		public enum LimitMode
		{
			[Token(Token = "0x400075D")]
			None,
			[Token(Token = "0x400075E")]
			FrameBased,
			[Token(Token = "0x400075F")]
			TimeBased
		}

		[Token(Token = "0x400046C")]
		public const float UseCurveSpatialBlend = -99f;

		[Token(Token = "0x400046D")]
		public const string NoBus = "[NO BUS]";

		[Token(Token = "0x400046E")]
		public const int MinNoRepeatVariations = 3;

		[Token(Token = "0x400046F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int busIndex;

		[Token(Token = "0x4000470")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public MasterAudio.ItemSpatialBlendType spatialBlendType;

		[Token(Token = "0x4000471")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float spatialBlend;

		[Token(Token = "0x4000472")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public bool isSelected;

		[Token(Token = "0x4000473")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x25")]
		public bool isExpanded;

		[Token(Token = "0x4000474")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float groupMasterVolume;

		[Token(Token = "0x4000475")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public int retriggerPercentage;

		[Token(Token = "0x4000476")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public VariationMode curVariationMode;

		[Token(Token = "0x4000477")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public bool alwaysHighestPriority;

		[Token(Token = "0x4000478")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float chainLoopDelayMin;

		[Token(Token = "0x4000479")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float chainLoopDelayMax;

		[Token(Token = "0x400047A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public ChainedLoopLoopMode chainLoopMode;

		[Token(Token = "0x400047B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public int chainLoopNumLoops;

		[Token(Token = "0x400047C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public bool useDialogFadeOut;

		[Token(Token = "0x400047D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public float dialogFadeOutTime;

		[Token(Token = "0x400047E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public VariationSequence curVariationSequence;

		[Token(Token = "0x400047F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public bool useNoRepeatRefill;

		[Token(Token = "0x4000480")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x55")]
		public bool useInactivePeriodPoolRefill;

		[Token(Token = "0x4000481")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public float inactivePeriodSeconds;

		[Token(Token = "0x4000482")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public List<SoundGroupVariation> groupVariations;

		[Token(Token = "0x4000483")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public MasterAudio.AudioLocation bulkVariationMode;

		[Token(Token = "0x4000484")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public bool resourceClipsAllLoadAsync;

		[Token(Token = "0x4000485")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6D")]
		public bool logSound;

		[Token(Token = "0x4000486")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6E")]
		public bool copySettingsExpanded;

		[Token(Token = "0x4000487")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6F")]
		public bool expandLinkedGroups;

		[Token(Token = "0x4000488")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public List<string> childSoundGroups;

		[Token(Token = "0x4000489")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public List<string> endLinkedGroups;

		[Token(Token = "0x400048A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public MasterAudio.LinkedGroupSelectionType linkedStartGroupSelectionType;

		[Token(Token = "0x400048B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		public MasterAudio.LinkedGroupSelectionType linkedStopGroupSelectionType;

		[Token(Token = "0x400048C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public LimitMode limitMode;

		[Token(Token = "0x400048D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		public int limitPerXFrames;

		[Token(Token = "0x400048E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public float minimumTimeBetween;

		[Token(Token = "0x400048F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		public bool useClipAgePriority;

		[Token(Token = "0x4000490")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x95")]
		public bool limitPolyphony;

		[Token(Token = "0x4000491")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public int voiceLimitCount;

		[Token(Token = "0x4000492")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		public TargetDespawnedBehavior targetDespawnedBehavior;

		[Token(Token = "0x4000493")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public float despawnFadeTime;

		[Token(Token = "0x4000494")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		public bool isUsingOcclusion;

		[Token(Token = "0x4000495")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA5")]
		public bool willOcclusionOverrideRaycastOffset;

		[Token(Token = "0x4000496")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public float occlusionRayCastOffset;

		[Token(Token = "0x4000497")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		public bool willOcclusionOverrideFrequencies;

		[Token(Token = "0x4000498")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public float occlusionMaxCutoffFreq;

		[Token(Token = "0x4000499")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		public float occlusionMinCutoffFreq;

		[Token(Token = "0x400049A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public bool isSoloed;

		[Token(Token = "0x400049B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB9")]
		public bool isMuted;

		[Token(Token = "0x400049C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBA")]
		public bool soundPlayedEventActive;

		[Token(Token = "0x400049D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public string soundPlayedCustomEvent;

		[Token(Token = "0x400049E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public bool willCleanUpDelegatesAfterStop;

		[Token(Token = "0x40004A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		public int frames;

		[Token(Token = "0x40004A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private List<int> _activeAudioSourcesIds;

		[Token(Token = "0x40004A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private string _objectName;

		[Token(Token = "0x40004A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private Transform _trans;

		[Token(Token = "0x40004A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private float _originalVolume;

		[Token(Token = "0x40004A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xFC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x982C00", Offset = "0x982C00")]
		private int <ChainLoopCount>k__BackingField;

		[Token(Token = "0x170000E3")]
		public MasterAudio.InternetFileLoadStatus GroupLoadStatus
		{
			[Token(Token = "0x60003B7")]
			[Address(RVA = "0xFE9AD0", Offset = "0xFE9AD0", VA = "0xFE9AD0")]
			get
			{
				return default(MasterAudio.InternetFileLoadStatus);
			}
		}

		[Token(Token = "0x170000E4")]
		public float SpatialBlendForGroup
		{
			[Token(Token = "0x60003BC")]
			[Address(RVA = "0xFEA2CC", Offset = "0xFEA2CC", VA = "0xFEA2CC")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x170000E5")]
		public int ActiveVoices
		{
			[Token(Token = "0x60003BD")]
			[Address(RVA = "0xFEA3BC", Offset = "0xFEA3BC", VA = "0xFEA3BC")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170000E6")]
		public int TotalVoices
		{
			[Token(Token = "0x60003BE")]
			[Address(RVA = "0xFEA410", Offset = "0xFEA410", VA = "0xFEA410")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170000E7")]
		public bool WillCleanUpDelegatesAfterStop
		{
			[Token(Token = "0x60003BF")]
			[Address(RVA = "0xFEA434", Offset = "0xFEA434", VA = "0xFEA434")]
			set
			{
			}
		}

		[Token(Token = "0x170000E8")]
		public GroupBus BusForGroup
		{
			[Token(Token = "0x60003C0")]
			[Address(RVA = "0xFEA160", Offset = "0xFEA160", VA = "0xFEA160")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000E9")]
		public float OriginalVolume
		{
			[Token(Token = "0x60003C1")]
			[Address(RVA = "0xFEA440", Offset = "0xFEA440", VA = "0xFEA440")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60003C2")]
			[Address(RVA = "0xFEA448", Offset = "0xFEA448", VA = "0xFEA448")]
			set
			{
			}
		}

		[Token(Token = "0x170000EA")]
		public bool LoggingEnabledForGroup
		{
			[Token(Token = "0x60003C3")]
			[Address(RVA = "0xFEA450", Offset = "0xFEA450", VA = "0xFEA450")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000EB")]
		public int ChainLoopCount
		{
			[Token(Token = "0x60003C7")]
			[Address(RVA = "0xFEA4F0", Offset = "0xFEA4F0", VA = "0xFEA4F0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x983C58", Offset = "0x983C58")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60003C8")]
			[Address(RVA = "0xFEA4F8", Offset = "0xFEA4F8", VA = "0xFEA4F8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x983C68", Offset = "0x983C68")]
			set
			{
			}
		}

		[Token(Token = "0x170000EC")]
		public string GameObjectName
		{
			[Token(Token = "0x60003C9")]
			[Address(RVA = "0xFE9F38", Offset = "0xFE9F38", VA = "0xFE9F38")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000ED")]
		public bool UsesNoRepeat
		{
			[Token(Token = "0x60003CA")]
			[Address(RVA = "0xFEA500", Offset = "0xFEA500", VA = "0xFEA500")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000EE")]
		private Transform Trans
		{
			[Token(Token = "0x60003CB")]
			[Address(RVA = "0xFE9BA8", Offset = "0xFE9BA8", VA = "0xFE9BA8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000EF")]
		private List<int> ActiveAudioSourceIds
		{
			[Token(Token = "0x60003CC")]
			[Address(RVA = "0xFE9E98", Offset = "0xFE9E98", VA = "0xFE9E98")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x14000005")]
		public event Action LastVariationFinishedPlay
		{
			[Token(Token = "0x60003B5")]
			[Address(RVA = "0xFE9988", Offset = "0xFE9988", VA = "0xFE9988")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x983C38", Offset = "0x983C38")]
			add
			{
			}
			[Token(Token = "0x60003B6")]
			[Address(RVA = "0xFE9A2C", Offset = "0xFE9A2C", VA = "0xFE9A2C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x983C48", Offset = "0x983C48")]
			remove
			{
			}
		}

		[Token(Token = "0x60003B8")]
		[Address(RVA = "0xFE9C38", Offset = "0xFE9C38", VA = "0xFE9C38")]
		private void Start()
		{
		}

		[Token(Token = "0x60003B9")]
		[Address(RVA = "0xFE9F7C", Offset = "0xFE9F7C", VA = "0xFE9F7C")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60003BA")]
		[Address(RVA = "0xFEA0A8", Offset = "0xFEA0A8", VA = "0xFEA0A8")]
		public void AddActiveAudioSourceId(int varInstanceId)
		{
		}

		[Token(Token = "0x60003BB")]
		[Address(RVA = "0xFEA238", Offset = "0xFEA238", VA = "0xFEA238")]
		public void RemoveActiveAudioSourceId(int varInstanceId)
		{
		}

		[Token(Token = "0x60003C4")]
		[Address(RVA = "0xFEA4CC", Offset = "0xFEA4CC", VA = "0xFEA4CC")]
		public void FireLastVariationFinishedPlay()
		{
		}

		[Token(Token = "0x60003C5")]
		[Address(RVA = "0xFEA4E0", Offset = "0xFEA4E0", VA = "0xFEA4E0")]
		public void SubscribeToLastVariationFinishedPlay(Action finishedCallback)
		{
		}

		[Token(Token = "0x60003C6")]
		[Address(RVA = "0xFEA4E8", Offset = "0xFEA4E8", VA = "0xFEA4E8")]
		public void UnsubscribeFromLastVariationFinishedPlay()
		{
		}

		[Token(Token = "0x60003CD")]
		[Address(RVA = "0xFEA574", Offset = "0xFEA574", VA = "0xFEA574")]
		public MasterAudioGroup()
		{
		}
	}
	[Token(Token = "0x20000A8")]
	public class MasterCustomEventAttribute : PropertyAttribute
	{
		[Token(Token = "0x60003CE")]
		[Address(RVA = "0xFEA6D4", Offset = "0xFEA6D4", VA = "0xFEA6D4")]
		public MasterCustomEventAttribute()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000A9")]
	public class MusicSetting
	{
		[Token(Token = "0x20000F6")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9816C4", Offset = "0x9816C4")]
		private sealed class <>c__DisplayClass32_0
		{
			[Token(Token = "0x4000760")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public SongMetadataStringValue valToClone;

			[Token(Token = "0x600070C")]
			[Address(RVA = "0xFEC158", Offset = "0xFEC158", VA = "0xFEC158")]
			public <>c__DisplayClass32_0()
			{
			}

			[Token(Token = "0x600070D")]
			[Address(RVA = "0xFEC248", Offset = "0xFEC248", VA = "0xFEC248")]
			internal bool <Clone>b__0(SongMetadataProperty p)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x20000F7")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9816D4", Offset = "0x9816D4")]
		private sealed class <>c__DisplayClass32_1
		{
			[Token(Token = "0x4000761")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public SongMetadataFloatValue valToClone;

			[Token(Token = "0x600070E")]
			[Address(RVA = "0xFEC194", Offset = "0xFEC194", VA = "0xFEC194")]
			public <>c__DisplayClass32_1()
			{
			}

			[Token(Token = "0x600070F")]
			[Address(RVA = "0xFEC274", Offset = "0xFEC274", VA = "0xFEC274")]
			internal bool <Clone>b__1(SongMetadataProperty p)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x20000F8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9816E4", Offset = "0x9816E4")]
		private sealed class <>c__DisplayClass32_2
		{
			[Token(Token = "0x4000762")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public SongMetadataBoolValue valToClone;

			[Token(Token = "0x6000710")]
			[Address(RVA = "0xFEC1D0", Offset = "0xFEC1D0", VA = "0xFEC1D0")]
			public <>c__DisplayClass32_2()
			{
			}

			[Token(Token = "0x6000711")]
			[Address(RVA = "0xFEC2A0", Offset = "0xFEC2A0", VA = "0xFEC2A0")]
			internal bool <Clone>b__2(SongMetadataProperty p)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x20000F9")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9816F4", Offset = "0x9816F4")]
		private sealed class <>c__DisplayClass32_3
		{
			[Token(Token = "0x4000763")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public SongMetadataIntValue valToClone;

			[Token(Token = "0x6000712")]
			[Address(RVA = "0xFEC20C", Offset = "0xFEC20C", VA = "0xFEC20C")]
			public <>c__DisplayClass32_3()
			{
			}

			[Token(Token = "0x6000713")]
			[Address(RVA = "0xFEC2CC", Offset = "0xFEC2CC", VA = "0xFEC2CC")]
			internal bool <Clone>b__3(SongMetadataProperty p)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x40004A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string alias;

		[Token(Token = "0x40004A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public MasterAudio.AudioLocation audLocation;

		[Token(Token = "0x40004A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public AudioClip clip;

		[Token(Token = "0x40004A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string songName;

		[Token(Token = "0x40004AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string resourceFileName;

		[Token(Token = "0x40004AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float volume;

		[Token(Token = "0x40004AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float pitch;

		[Token(Token = "0x40004AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public bool isExpanded;

		[Token(Token = "0x40004AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x41")]
		public bool isLoop;

		[Token(Token = "0x40004AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x42")]
		public bool isChecked;

		[Token(Token = "0x40004B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public List<SongMetadataStringValue> metadataStringValues;

		[Token(Token = "0x40004B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public List<SongMetadataBoolValue> metadataBoolValues;

		[Token(Token = "0x40004B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public List<SongMetadataIntValue> metadataIntValues;

		[Token(Token = "0x40004B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public List<SongMetadataFloatValue> metadataFloatValues;

		[Token(Token = "0x40004B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public bool metadataExpanded;

		[Token(Token = "0x40004B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public MasterAudio.CustomSongStartTimeMode songStartTimeMode;

		[Token(Token = "0x40004B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public float customStartTime;

		[Token(Token = "0x40004B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		public float customStartTimeMax;

		[Token(Token = "0x40004B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public int lastKnownTimePoint;

		[Token(Token = "0x40004B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		public bool wasLastKnownTimePointSet;

		[Token(Token = "0x40004BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public int songIndex;

		[Token(Token = "0x40004BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		public bool songStartedEventExpanded;

		[Token(Token = "0x40004BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public string songStartedCustomEvent;

		[Token(Token = "0x40004BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public bool songChangedEventExpanded;

		[Token(Token = "0x40004BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public string songChangedCustomEvent;

		[Token(Token = "0x170000F0")]
		public bool HasMetadataProperties
		{
			[Token(Token = "0x60003D0")]
			[Address(RVA = "0xFEBB20", Offset = "0xFEBB20", VA = "0xFEBB20")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000F1")]
		public int MetadataPropertyCount
		{
			[Token(Token = "0x60003D1")]
			[Address(RVA = "0xFEBB3C", Offset = "0xFEBB3C", VA = "0xFEBB3C")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170000F2")]
		public float SongStartTime
		{
			[Token(Token = "0x60003D2")]
			[Address(RVA = "0xFEBBBC", Offset = "0xFEBBBC", VA = "0xFEBBBC")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x60003CF")]
		[Address(RVA = "0xFEB9C4", Offset = "0xFEB9C4", VA = "0xFEB9C4")]
		public MusicSetting()
		{
		}

		[Token(Token = "0x60003D3")]
		[Address(RVA = "0xFEBBE8", Offset = "0xFEBBE8", VA = "0xFEBBE8")]
		public static MusicSetting Clone(MusicSetting mus, MasterAudio.Playlist aList)
		{
			return null;
		}
	}
	[Serializable]
	[Token(Token = "0x20000AA")]
	public class OcclusionFreqChangeInfo
	{
		[Token(Token = "0x40004BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public SoundGroupVariation ActingVariation;

		[Token(Token = "0x40004C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float StartFrequency;

		[Token(Token = "0x40004C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float TargetFrequency;

		[Token(Token = "0x40004C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float StartTime;

		[Token(Token = "0x40004C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float CompletionTime;

		[Token(Token = "0x40004C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool IsActive;

		[Token(Token = "0x60003D4")]
		[Address(RVA = "0xFEC2F8", Offset = "0xFEC2F8", VA = "0xFEC2F8")]
		public OcclusionFreqChangeInfo()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000AB")]
	public class SongMetadataBoolValue
	{
		[Token(Token = "0x40004C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string PropertyName;

		[Token(Token = "0x40004C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool Value;

		[Token(Token = "0x60003D5")]
		[Address(RVA = "0xFEC1D8", Offset = "0xFEC1D8", VA = "0xFEC1D8")]
		public SongMetadataBoolValue(SongMetadataProperty prop)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000AC")]
	public class SongMetadataFloatValue
	{
		[Token(Token = "0x40004C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string PropertyName;

		[Token(Token = "0x40004C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float Value;

		[Token(Token = "0x60003D6")]
		[Address(RVA = "0xFEC19C", Offset = "0xFEC19C", VA = "0xFEC19C")]
		public SongMetadataFloatValue(SongMetadataProperty prop)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000AD")]
	public class SongMetadataIntValue
	{
		[Token(Token = "0x40004C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string PropertyName;

		[Token(Token = "0x40004CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int Value;

		[Token(Token = "0x60003D7")]
		[Address(RVA = "0xFEC214", Offset = "0xFEC214", VA = "0xFEC214")]
		public SongMetadataIntValue(SongMetadataProperty prop)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000AE")]
	public class SongMetadataProperty
	{
		[Token(Token = "0x20000FA")]
		public enum MetadataPropertyType
		{
			[Token(Token = "0x4000765")]
			Boolean,
			[Token(Token = "0x4000766")]
			String,
			[Token(Token = "0x4000767")]
			Integer,
			[Token(Token = "0x4000768")]
			Float
		}

		[Token(Token = "0x40004CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public MetadataPropertyType PropertyType;

		[Token(Token = "0x40004CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string PropertyName;

		[Token(Token = "0x40004CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string ProspectiveName;

		[Token(Token = "0x40004CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool IsEditing;

		[Token(Token = "0x40004CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
		public bool PropertyExpanded;

		[Token(Token = "0x40004D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2A")]
		public bool AllSongsMustContain;

		[Token(Token = "0x40004D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2B")]
		public bool CanSongHaveMultiple;

		[Token(Token = "0x60003D8")]
		[Address(RVA = "0xFF4C64", Offset = "0xFF4C64", VA = "0xFF4C64")]
		public SongMetadataProperty(string propertyName, MetadataPropertyType propertyType, bool allSongsMustContain, bool canSongHaveMultiple)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000AF")]
	public class SongMetadataStringValue
	{
		[Token(Token = "0x40004D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string PropertyName;

		[Token(Token = "0x40004D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string Value;

		[Token(Token = "0x60003D9")]
		[Address(RVA = "0xFEC160", Offset = "0xFEC160", VA = "0xFEC160")]
		public SongMetadataStringValue(SongMetadataProperty prop)
		{
		}
	}
	[Token(Token = "0x20000B0")]
	public class SoundGroupAttribute : PropertyAttribute
	{
		[Token(Token = "0x60003DA")]
		[Address(RVA = "0xFF4CC8", Offset = "0xFF4CC8", VA = "0xFF4CC8")]
		public SoundGroupAttribute()
		{
		}
	}
	[Token(Token = "0x20000B1")]
	[AttributeAttribute(Name = "AudioScriptOrder", RVA = "0x9814C8", Offset = "0x9814C8")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x9814C8", Offset = "0x9814C8")]
	public class SoundGroupVariation : MonoBehaviour
	{
		[Token(Token = "0x20000FB")]
		public delegate void SoundFinishedEventHandler();

		[Token(Token = "0x20000FC")]
		public delegate void SoundLoopedEventHandler(int loopNumberStarted);

		[Token(Token = "0x20000FD")]
		public class PlaySoundParams
		{
			[Token(Token = "0x4000769")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string SoundType;

			[Token(Token = "0x400076A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float VolumePercentage;

			[Token(Token = "0x400076B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public float? Pitch;

			[Token(Token = "0x400076C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public double? TimeToSchedulePlay;

			[Token(Token = "0x400076D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Transform SourceTrans;

			[Token(Token = "0x400076E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public bool AttachToSource;

			[Token(Token = "0x400076F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			public float DelaySoundTime;

			[Token(Token = "0x4000770")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public bool IsChainLoop;

			[Token(Token = "0x4000771")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x49")]
			public bool IsSingleSubscribedPlay;

			[Token(Token = "0x4000772")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			public float GroupCalcVolume;

			[Token(Token = "0x4000773")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public bool IsPlaying;

			[Token(Token = "0x600071C")]
			[Address(RVA = "0xFF9CCC", Offset = "0xFF9CCC", VA = "0xFF9CCC")]
			public PlaySoundParams(string soundType, float volPercent, float groupCalcVolume, float? pitch, Transform sourceTrans, bool attach, float delaySoundTime, double? timeToSchedulePlay, bool isChainLoop, bool isSingleSubscribedPlay)
			{
			}
		}

		[Token(Token = "0x20000FE")]
		public enum PitchMode
		{
			[Token(Token = "0x4000775")]
			None,
			[Token(Token = "0x4000776")]
			Gliding
		}

		[Token(Token = "0x20000FF")]
		public enum FadeMode
		{
			[Token(Token = "0x4000778")]
			None,
			[Token(Token = "0x4000779")]
			FadeInOut,
			[Token(Token = "0x400077A")]
			FadeOutEarly,
			[Token(Token = "0x400077B")]
			GradualFade
		}

		[Token(Token = "0x2000100")]
		public enum RandomPitchMode
		{
			[Token(Token = "0x400077D")]
			AddToClipPitch,
			[Token(Token = "0x400077E")]
			IgnoreClipPitch
		}

		[Token(Token = "0x2000101")]
		public enum RandomVolumeMode
		{
			[Token(Token = "0x4000780")]
			AddToClipVolume,
			[Token(Token = "0x4000781")]
			IgnoreClipVolume
		}

		[Token(Token = "0x2000102")]
		public enum DetectEndMode
		{
			[Token(Token = "0x4000783")]
			None,
			[Token(Token = "0x4000784")]
			DetectEnd
		}

		[Token(Token = "0x40004D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int weight;

		[Token(Token = "0x40004D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x982C10", Offset = "0x982C10")]
		public int probabilityToPlay;

		[Token(Token = "0x40004D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool useLocalization;

		[Token(Token = "0x40004D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
		public bool useRandomPitch;

		[Token(Token = "0x40004D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public RandomPitchMode randomPitchMode;

		[Token(Token = "0x40004D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float randomPitchMin;

		[Token(Token = "0x40004DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float randomPitchMax;

		[Token(Token = "0x40004DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool useRandomVolume;

		[Token(Token = "0x40004DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public RandomVolumeMode randomVolumeMode;

		[Token(Token = "0x40004DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float randomVolumeMin;

		[Token(Token = "0x40004DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float randomVolumeMax;

		[Token(Token = "0x40004DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public MasterAudio.AudioLocation audLocation;

		[Token(Token = "0x40004E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public string resourceFileName;

		[Token(Token = "0x40004E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public string internetFileUrl;

		[Token(Token = "0x40004E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public MasterAudio.InternetFileLoadStatus internetFileLoadStatus;

		[Token(Token = "0x40004E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public float original_pitch;

		[Token(Token = "0x40004E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public float original_volume;

		[Token(Token = "0x40004E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public bool isExpanded;

		[Token(Token = "0x40004E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x65")]
		public bool isChecked;

		[Token(Token = "0x40004E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x66")]
		public bool useFades;

		[Token(Token = "0x40004E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public float fadeInTime;

		[Token(Token = "0x40004E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public float fadeOutTime;

		[Token(Token = "0x40004EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public bool useCustomLooping;

		[Token(Token = "0x40004EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		public int minCustomLoops;

		[Token(Token = "0x40004EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public int maxCustomLoops;

		[Token(Token = "0x40004ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		public bool useRandomStartTime;

		[Token(Token = "0x40004EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public float randomStartMinPercent;

		[Token(Token = "0x40004EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		public float randomStartMaxPercent;

		[Token(Token = "0x40004F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public float randomEndPercent;

		[Token(Token = "0x40004F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		public bool useIntroSilence;

		[Token(Token = "0x40004F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public float introSilenceMin;

		[Token(Token = "0x40004F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		public float introSilenceMax;

		[Token(Token = "0x40004F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public float fadeMaxVolume;

		[Token(Token = "0x40004F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		public FadeMode curFadeMode;

		[Token(Token = "0x40004F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public PitchMode curPitchMode;

		[Token(Token = "0x40004F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		public DetectEndMode curDetectEndMode;

		[Token(Token = "0x40004F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public int frames;

		[Token(Token = "0x40004F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private AudioSource _audioSource;

		[Token(Token = "0x40004FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private readonly PlaySoundParams _playSndParam;

		[Token(Token = "0x40004FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private AudioDistortionFilter _distFilter;

		[Token(Token = "0x40004FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private AudioEchoFilter _echoFilter;

		[Token(Token = "0x40004FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private AudioHighPassFilter _hpFilter;

		[Token(Token = "0x40004FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private AudioLowPassFilter _lpFilter;

		[Token(Token = "0x40004FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private AudioReverbFilter _reverbFilter;

		[Token(Token = "0x4000500")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private AudioChorusFilter _chorusFilter;

		[Token(Token = "0x4000501")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private float _maxVol;

		[Token(Token = "0x4000502")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
		private int _instanceId;

		[Token(Token = "0x4000503")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private bool? _audioLoops;

		[Token(Token = "0x4000504")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xFC")]
		private int _maxLoops;

		[Token(Token = "0x4000505")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private SoundGroupVariationUpdater _varUpdater;

		[Token(Token = "0x4000506")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private int _previousSoundFinishedFrame;

		[Token(Token = "0x4000507")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private string _soundGroupName;

		[Token(Token = "0x400050A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		private Transform _trans;

		[Token(Token = "0x400050B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private GameObject _go;

		[Token(Token = "0x400050C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		private Transform _objectToFollow;

		[Token(Token = "0x400050D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		private Transform _objectToTriggerFrom;

		[Token(Token = "0x400050E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		private MasterAudioGroup _parentGroupScript;

		[Token(Token = "0x400050F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		private bool _attachToSource;

		[Token(Token = "0x4000510")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		private string _resFileName;

		[Token(Token = "0x4000511")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		private bool _hasStartedEndLinkedGroups;

		[Token(Token = "0x4000512")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x164")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x982C48", Offset = "0x982C48")]
		private float <LastTimePlayed>k__BackingField;

		[Token(Token = "0x170000F3")]
		public AudioDistortionFilter DistortionFilter
		{
			[Token(Token = "0x6000400")]
			[Address(RVA = "0xFF9100", Offset = "0xFF9100", VA = "0xFF9100")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000F4")]
		public AudioReverbFilter ReverbFilter
		{
			[Token(Token = "0x6000401")]
			[Address(RVA = "0xFF9198", Offset = "0xFF9198", VA = "0xFF9198")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000F5")]
		public AudioChorusFilter ChorusFilter
		{
			[Token(Token = "0x6000402")]
			[Address(RVA = "0xFF9230", Offset = "0xFF9230", VA = "0xFF9230")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000F6")]
		public AudioEchoFilter EchoFilter
		{
			[Token(Token = "0x6000403")]
			[Address(RVA = "0xFF92C8", Offset = "0xFF92C8", VA = "0xFF92C8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000F7")]
		public AudioLowPassFilter LowPassFilter
		{
			[Token(Token = "0x6000404")]
			[Address(RVA = "0xFF9360", Offset = "0xFF9360", VA = "0xFF9360")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000405")]
			[Address(RVA = "0xFF9368", Offset = "0xFF9368", VA = "0xFF9368")]
			set
			{
			}
		}

		[Token(Token = "0x170000F8")]
		public AudioHighPassFilter HighPassFilter
		{
			[Token(Token = "0x6000406")]
			[Address(RVA = "0xFF9370", Offset = "0xFF9370", VA = "0xFF9370")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000F9")]
		public Transform ObjectToFollow
		{
			[Token(Token = "0x6000407")]
			[Address(RVA = "0xFF9408", Offset = "0xFF9408", VA = "0xFF9408")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000408")]
			[Address(RVA = "0xFF9410", Offset = "0xFF9410", VA = "0xFF9410")]
			set
			{
			}
		}

		[Token(Token = "0x170000FA")]
		public Transform ObjectToTriggerFrom
		{
			[Token(Token = "0x6000409")]
			[Address(RVA = "0xFF953C", Offset = "0xFF953C", VA = "0xFF953C")]
			get
			{
				return null;
			}
			[Token(Token = "0x600040A")]
			[Address(RVA = "0xFF9544", Offset = "0xFF9544", VA = "0xFF9544")]
			set
			{
			}
		}

		[Token(Token = "0x170000FB")]
		public bool HasActiveFXFilter
		{
			[Token(Token = "0x600040C")]
			[Address(RVA = "0xFF954C", Offset = "0xFF954C", VA = "0xFF954C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000FC")]
		public MasterAudioGroup ParentGroup
		{
			[Token(Token = "0x600040D")]
			[Address(RVA = "0xFF5554", Offset = "0xFF5554", VA = "0xFF5554")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000FD")]
		public float OriginalPitch
		{
			[Token(Token = "0x600040E")]
			[Address(RVA = "0xFF6B54", Offset = "0xFF6B54", VA = "0xFF6B54")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x170000FE")]
		public float OriginalVolume
		{
			[Token(Token = "0x600040F")]
			[Address(RVA = "0xFF9794", Offset = "0xFF9794", VA = "0xFF9794")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x170000FF")]
		public string SoundGroupName
		{
			[Token(Token = "0x6000410")]
			[Address(RVA = "0xFF97D4", Offset = "0xFF97D4", VA = "0xFF97D4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000100")]
		public bool IsAvailableToPlay
		{
			[Token(Token = "0x6000411")]
			[Address(RVA = "0xFF9810", Offset = "0xFF9810", VA = "0xFF9810")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000101")]
		public float LastTimePlayed
		{
			[Token(Token = "0x6000412")]
			[Address(RVA = "0xFF98AC", Offset = "0xFF98AC", VA = "0xFF98AC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x983CB8", Offset = "0x983CB8")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000413")]
			[Address(RVA = "0xFF98B4", Offset = "0xFF98B4", VA = "0xFF98B4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x983CC8", Offset = "0x983CC8")]
			set
			{
			}
		}

		[Token(Token = "0x17000102")]
		public bool IsPlaying
		{
			[Token(Token = "0x6000414")]
			[Address(RVA = "0xFF8C48", Offset = "0xFF8C48", VA = "0xFF8C48")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000103")]
		public int InstanceId
		{
			[Token(Token = "0x6000415")]
			[Address(RVA = "0xFF72E8", Offset = "0xFF72E8", VA = "0xFF72E8")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000104")]
		public Transform Trans
		{
			[Token(Token = "0x6000416")]
			[Address(RVA = "0xFF840C", Offset = "0xFF840C", VA = "0xFF840C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000105")]
		public GameObject GameObj
		{
			[Token(Token = "0x6000417")]
			[Address(RVA = "0xFF54C4", Offset = "0xFF54C4", VA = "0xFF54C4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000106")]
		public AudioSource VarAudio
		{
			[Token(Token = "0x6000418")]
			[Address(RVA = "0xFF542C", Offset = "0xFF542C", VA = "0xFF542C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000107")]
		public bool AudioLoops
		{
			[Token(Token = "0x6000419")]
			[Address(RVA = "0xFF7240", Offset = "0xFF7240", VA = "0xFF7240")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000108")]
		public string ResFileName
		{
			[Token(Token = "0x600041A")]
			[Address(RVA = "0xFF6E90", Offset = "0xFF6E90", VA = "0xFF6E90")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000109")]
		public SoundGroupVariationUpdater VariationUpdater
		{
			[Token(Token = "0x600041B")]
			[Address(RVA = "0xFF5E08", Offset = "0xFF5E08", VA = "0xFF5E08")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700010A")]
		public PlaySoundParams PlaySoundParm
		{
			[Token(Token = "0x600041C")]
			[Address(RVA = "0xFF98BC", Offset = "0xFF98BC", VA = "0xFF98BC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700010B")]
		public float SetGroupVolume
		{
			[Token(Token = "0x600041D")]
			[Address(RVA = "0xFF98C4", Offset = "0xFF98C4", VA = "0xFF98C4")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600041E")]
			[Address(RVA = "0xFF98E0", Offset = "0xFF98E0", VA = "0xFF98E0")]
			set
			{
			}
		}

		[Token(Token = "0x1700010C")]
		public int MaxLoops
		{
			[Token(Token = "0x600041F")]
			[Address(RVA = "0xFF98FC", Offset = "0xFF98FC", VA = "0xFF98FC")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700010D")]
		private bool Is2D
		{
			[Token(Token = "0x6000420")]
			[Address(RVA = "0xFF9904", Offset = "0xFF9904", VA = "0xFF9904")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700010E")]
		private bool ShouldLoadAsync
		{
			[Token(Token = "0x6000421")]
			[Address(RVA = "0xFF6ABC", Offset = "0xFF6ABC", VA = "0xFF6ABC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700010F")]
		public bool UsesOcclusion
		{
			[Token(Token = "0x6000422")]
			[Address(RVA = "0xFF5F98", Offset = "0xFF5F98", VA = "0xFF5F98")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x14000006")]
		public event SoundFinishedEventHandler SoundFinished
		{
			[Token(Token = "0x60003DB")]
			[Address(RVA = "0xFE902C", Offset = "0xFE902C", VA = "0xFE902C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x983C78", Offset = "0x983C78")]
			add
			{
			}
			[Token(Token = "0x60003DC")]
			[Address(RVA = "0xFF4F58", Offset = "0xFF4F58", VA = "0xFF4F58")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x983C88", Offset = "0x983C88")]
			remove
			{
			}
		}

		[Token(Token = "0x14000007")]
		public event SoundLoopedEventHandler SoundLooped
		{
			[Token(Token = "0x60003DD")]
			[Address(RVA = "0xFF5000", Offset = "0xFF5000", VA = "0xFF5000")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x983C98", Offset = "0x983C98")]
			add
			{
			}
			[Token(Token = "0x60003DE")]
			[Address(RVA = "0xFF50A8", Offset = "0xFF50A8", VA = "0xFF50A8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x983CA8", Offset = "0x983CA8")]
			remove
			{
			}
		}

		[Token(Token = "0x60003DF")]
		[Address(RVA = "0xFF5150", Offset = "0xFF5150", VA = "0xFF5150")]
		private void Awake()
		{
		}

		[Token(Token = "0x60003E0")]
		[Address(RVA = "0xFF56F8", Offset = "0xFF56F8", VA = "0xFF56F8")]
		private void Start()
		{
		}

		[Token(Token = "0x60003E1")]
		[Address(RVA = "0xFF5978", Offset = "0xFF5978", VA = "0xFF5978")]
		public void SetMixerGroup()
		{
		}

		[Token(Token = "0x60003E2")]
		[Address(RVA = "0xFF59CC", Offset = "0xFF59CC", VA = "0xFF59CC")]
		public void SetSpatialBlend()
		{
		}

		[Token(Token = "0x60003E3")]
		[Address(RVA = "0xFF5898", Offset = "0xFF5898", VA = "0xFF5898")]
		public void LoadInternetFile()
		{
		}

		[Token(Token = "0x60003E4")]
		[Address(RVA = "0xFF5B7C", Offset = "0xFF5B7C", VA = "0xFF5B7C")]
		private void SetOcclusion()
		{
		}

		[Token(Token = "0x60003E5")]
		[Address(RVA = "0xFF5ACC", Offset = "0xFF5ACC", VA = "0xFF5ACC")]
		private void SetPriority()
		{
		}

		[Token(Token = "0x60003E6")]
		[Address(RVA = "0xFF60D0", Offset = "0xFF60D0", VA = "0xFF60D0")]
		public void DisableUpdater()
		{
		}

		[Token(Token = "0x60003E7")]
		[Address(RVA = "0xFF6178", Offset = "0xFF6178", VA = "0xFF6178")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60003E8")]
		[Address(RVA = "0xFF624C", Offset = "0xFF624C", VA = "0xFF624C")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60003E9")]
		[Address(RVA = "0xFF617C", Offset = "0xFF617C", VA = "0xFF617C")]
		private void StopSoundEarly()
		{
		}

		[Token(Token = "0x60003EA")]
		[Address(RVA = "0xFF654C", Offset = "0xFF654C", VA = "0xFF654C")]
		public void Play(float? pitch, float maxVolume, string gameObjectName, float volPercent, float targetVol, float? targetPitch, Transform sourceTrans, bool attach, float delayTime, double? timeToSchedulePlay, bool isChaining, bool isSingleSubscribedPlay)
		{
		}

		[Token(Token = "0x60003EB")]
		[Address(RVA = "0xFF69E0", Offset = "0xFF69E0", VA = "0xFF69E0")]
		public void SetPlaySoundParams(string gameObjectName, float volPercent, float targetVol, float? targetPitch, Transform sourceTrans, bool attach, float delayTime, double? timeToSchedulePlay, bool isChaining, bool isSingleSubscribedPlay)
		{
		}

		[Token(Token = "0x60003EC")]
		[Address(RVA = "0xFF6F30", Offset = "0xFF6F30", VA = "0xFF6F30")]
		private void InternetFileFailedToLoad()
		{
		}

		[Token(Token = "0x60003ED")]
		[Address(RVA = "0xFF69AC", Offset = "0xFF69AC", VA = "0xFF69AC")]
		private void MaybeCleanupFinishedDelegate()
		{
		}

		[Token(Token = "0x60003EE")]
		[Address(RVA = "0xFF6F44", Offset = "0xFF6F44", VA = "0xFF6F44")]
		private void InternetFileLoaded()
		{
		}

		[Token(Token = "0x60003EF")]
		[Address(RVA = "0xFF6FFC", Offset = "0xFF6FFC", VA = "0xFF6FFC")]
		private void ResourceFailedToLoad()
		{
		}

		[Token(Token = "0x60003F0")]
		[Address(RVA = "0xFF6B94", Offset = "0xFF6B94", VA = "0xFF6B94")]
		private void FinishSetupToPlay()
		{
		}

		[Token(Token = "0x60003F1")]
		[Address(RVA = "0xFF73E8", Offset = "0xFF73E8", VA = "0xFF73E8")]
		public void JumpToTime(float timeToJumpTo)
		{
		}

		[Token(Token = "0x60003F2")]
		[Address(RVA = "0xFF7434", Offset = "0xFF7434", VA = "0xFF7434")]
		public void GlideByPitch(float pitchAddition, float glideTime, [Optional] Action completionCallback)
		{
		}

		[Token(Token = "0x60003F3")]
		[Address(RVA = "0xFF771C", Offset = "0xFF771C", VA = "0xFF771C")]
		public void AdjustVolume(float volumePercentage)
		{
		}

		[Token(Token = "0x60003F4")]
		[Address(RVA = "0xFF7888", Offset = "0xFF7888", VA = "0xFF7888")]
		public void Pause()
		{
		}

		[Token(Token = "0x60003F5")]
		[Address(RVA = "0xFF79D0", Offset = "0xFF79D0", VA = "0xFF79D0")]
		public void DoNextChain(float volumePercentage, float? pitch, Transform transActor, bool attach)
		{
		}

		[Token(Token = "0x60003F6")]
		[Address(RVA = "0xFF7DCC", Offset = "0xFF7DCC", VA = "0xFF7DCC")]
		public void PlayEndLinkedGroups([Optional] double? timeToPlayClip)
		{
		}

		[Token(Token = "0x60003F7")]
		[Address(RVA = "0xFF7008", Offset = "0xFF7008", VA = "0xFF7008")]
		private void EnableUpdater(bool waitForSoundFinish = true)
		{
		}

		[Token(Token = "0x60003F8")]
		[Address(RVA = "0xFF8360", Offset = "0xFF8360", VA = "0xFF8360")]
		private void MaybeUnloadClip()
		{
		}

		[Token(Token = "0x60003F9")]
		[Address(RVA = "0xFF804C", Offset = "0xFF804C", VA = "0xFF804C")]
		private void PlayEndLinkedGroup(string sType, [Optional] double? timeToPlayClip)
		{
		}

		[Token(Token = "0x60003FA")]
		[Address(RVA = "0xFF6250", Offset = "0xFF6250", VA = "0xFF6250")]
		public void Stop(bool stopEndDetection = false, bool skipLinked = false)
		{
		}

		[Token(Token = "0x60003FB")]
		[Address(RVA = "0xFF872C", Offset = "0xFF872C", VA = "0xFF872C")]
		public void FadeToVolume(float newVolume, float fadeTime)
		{
		}

		[Token(Token = "0x60003FC")]
		[Address(RVA = "0xFF8B14", Offset = "0xFF8B14", VA = "0xFF8B14")]
		public void FadeOutNow()
		{
		}

		[Token(Token = "0x60003FD")]
		[Address(RVA = "0xFF8E00", Offset = "0xFF8E00", VA = "0xFF8E00")]
		public void FadeOutNow(float fadeTime)
		{
		}

		[Token(Token = "0x60003FE")]
		[Address(RVA = "0xFF8F3C", Offset = "0xFF8F3C", VA = "0xFF8F3C")]
		public bool WasTriggeredFromTransform(Transform trans)
		{
			return default(bool);
		}

		[Token(Token = "0x60003FF")]
		[Address(RVA = "0xFF8FFC", Offset = "0xFF8FFC", VA = "0xFF8FFC")]
		public bool WasTriggeredFromAnyOfTransformMap(HashSet<Transform> transMap)
		{
			return default(bool);
		}

		[Token(Token = "0x600040B")]
		[Address(RVA = "0xFF9418", Offset = "0xFF9418", VA = "0xFF9418")]
		public void UpdateTransformTracker(Transform sourceTrans)
		{
		}

		[Token(Token = "0x6000423")]
		[Address(RVA = "0xFF9930", Offset = "0xFF9930", VA = "0xFF9930")]
		public void SoundLoopStarted(int numberOfLoops)
		{
		}

		[Token(Token = "0x6000424")]
		[Address(RVA = "0xFF6F3C", Offset = "0xFF6F3C", VA = "0xFF6F3C")]
		public void ClearSubscribers()
		{
		}

		[Token(Token = "0x6000425")]
		[Address(RVA = "0xFF9BA0", Offset = "0xFF9BA0", VA = "0xFF9BA0")]
		public SoundGroupVariation()
		{
		}
	}
	[Token(Token = "0x20000B2")]
	[AttributeAttribute(Name = "AudioScriptOrder", RVA = "0x981540", Offset = "0x981540")]
	public class SoundGroupVariationUpdater : MonoBehaviour
	{
		[Token(Token = "0x2000103")]
		private enum WaitForSoundFinishMode
		{
			[Token(Token = "0x4000786")]
			None,
			[Token(Token = "0x4000787")]
			Play,
			[Token(Token = "0x4000788")]
			WaitForEnd,
			[Token(Token = "0x4000789")]
			StopOrRepeat
		}

		[Token(Token = "0x4000513")]
		private const float TimeEarlyToScheduleNextClip = 0.1f;

		[Token(Token = "0x4000514")]
		private const float FakeNegativeFloatValue = -10f;

		[Token(Token = "0x4000515")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Transform _objectToFollow;

		[Token(Token = "0x4000516")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private GameObject _objectToFollowGo;

		[Token(Token = "0x4000517")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool _isFollowing;

		[Token(Token = "0x4000518")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private SoundGroupVariation _variation;

		[Token(Token = "0x4000519")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private float _priorityLastUpdated;

		[Token(Token = "0x400051A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private bool _useClipAgePriority;

		[Token(Token = "0x400051B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private WaitForSoundFinishMode _waitMode;

		[Token(Token = "0x400051C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private AudioSource _varAudio;

		[Token(Token = "0x400051D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private MasterAudioGroup _parentGrp;

		[Token(Token = "0x400051E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Transform _trans;

		[Token(Token = "0x400051F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private int _frameNum;

		[Token(Token = "0x4000520")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private bool _inited;

		[Token(Token = "0x4000521")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private float _fadeOutStartTime;

		[Token(Token = "0x4000522")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private bool _fadeInOutWillFadeOut;

		[Token(Token = "0x4000523")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6D")]
		private bool _hasFadeInOutSetMaxVolume;

		[Token(Token = "0x4000524")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private float _fadeInOutInFactor;

		[Token(Token = "0x4000525")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private float _fadeInOutOutFactor;

		[Token(Token = "0x4000526")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private int _fadeOutEarlyTotalFrames;

		[Token(Token = "0x4000527")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private float _fadeOutEarlyFrameVolChange;

		[Token(Token = "0x4000528")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private int _fadeOutEarlyFrameNumber;

		[Token(Token = "0x4000529")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private float _fadeOutEarlyOrigVol;

		[Token(Token = "0x400052A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private float _fadeToTargetFrameVolChange;

		[Token(Token = "0x400052B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private int _fadeToTargetFrameNumber;

		[Token(Token = "0x400052C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private float _fadeToTargetOrigVol;

		[Token(Token = "0x400052D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private int _fadeToTargetTotalFrames;

		[Token(Token = "0x400052E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private float _fadeToTargetVolume;

		[Token(Token = "0x400052F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private bool _fadeOutStarted;

		[Token(Token = "0x4000530")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private float _lastFrameClipTime;

		[Token(Token = "0x4000531")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		private bool _isPlayingBackward;

		[Token(Token = "0x4000532")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private int _pitchGlideToTargetTotalFrames;

		[Token(Token = "0x4000533")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		private float _pitchGlideToTargetFramePitchChange;

		[Token(Token = "0x4000534")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private int _pitchGlideToTargetFrameNumber;

		[Token(Token = "0x4000535")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		private float _glideToTargetPitch;

		[Token(Token = "0x4000536")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private float _glideToTargetOrigPitch;

		[Token(Token = "0x4000537")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private Action _glideToPitchCompletionCallback;

		[Token(Token = "0x4000538")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private bool _hasStartedNextInChain;

		[Token(Token = "0x4000539")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC9")]
		private bool _isWaitingForQueuedOcclusionRay;

		[Token(Token = "0x400053A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		private int _framesPlayed;

		[Token(Token = "0x400053B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private float? _clipStartPosition;

		[Token(Token = "0x400053C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private float? _clipEndPosition;

		[Token(Token = "0x400053D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private double? _clipSchedEndTime;

		[Token(Token = "0x400053E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private bool _hasScheduledNextClip;

		[Token(Token = "0x400053F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF1")]
		private bool _hasScheduledEndLinkedGroups;

		[Token(Token = "0x4000540")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
		private int _lastFrameClipPosition;

		[Token(Token = "0x4000541")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private int _timesLooped;

		[Token(Token = "0x4000542")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xFC")]
		private bool _isPaused;

		[Token(Token = "0x4000543")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private double _pauseTime;

		[Token(Token = "0x4000544")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static int _maCachedFromFrame;

		[Token(Token = "0x4000545")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static MasterAudio _maThisFrame;

		[Token(Token = "0x4000546")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static Transform _listenerThisFrame;

		[Token(Token = "0x17000110")]
		public float ClipStartPosition
		{
			[Token(Token = "0x6000443")]
			[Address(RVA = "0xFFB660", Offset = "0xFFB660", VA = "0xFFB660")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000111")]
		public float ClipEndPosition
		{
			[Token(Token = "0x6000444")]
			[Address(RVA = "0xFF9F94", Offset = "0xFF9F94", VA = "0xFF9F94")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000112")]
		public int FramesPlayed
		{
			[Token(Token = "0x6000445")]
			[Address(RVA = "0xFFC3C4", Offset = "0xFFC3C4", VA = "0xFFC3C4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000113")]
		public MasterAudio MAThisFrame
		{
			[Token(Token = "0x6000446")]
			[Address(RVA = "0xFFC3CC", Offset = "0xFFC3CC", VA = "0xFFC3CC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000114")]
		public float MaxOcclusionFreq
		{
			[Token(Token = "0x6000447")]
			[Address(RVA = "0xFFC434", Offset = "0xFFC434", VA = "0xFFC434")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000115")]
		public float MinOcclusionFreq
		{
			[Token(Token = "0x6000448")]
			[Address(RVA = "0xFFC4EC", Offset = "0xFFC4EC", VA = "0xFFC4EC")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000116")]
		private Transform Trans
		{
			[Token(Token = "0x6000449")]
			[Address(RVA = "0xFFA5D0", Offset = "0xFFA5D0", VA = "0xFFA5D0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000117")]
		private AudioSource VarAudio
		{
			[Token(Token = "0x600044A")]
			[Address(RVA = "0xFF9EFC", Offset = "0xFF9EFC", VA = "0xFF9EFC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000118")]
		private MasterAudioGroup ParentGroup
		{
			[Token(Token = "0x600044B")]
			[Address(RVA = "0xFFA668", Offset = "0xFFA668", VA = "0xFFA668")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000119")]
		private SoundGroupVariation GrpVariation
		{
			[Token(Token = "0x600044C")]
			[Address(RVA = "0xFF9E64", Offset = "0xFF9E64", VA = "0xFF9E64")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700011A")]
		private float RayCastOriginOffset
		{
			[Token(Token = "0x600044D")]
			[Address(RVA = "0xFFB5A8", Offset = "0xFFB5A8", VA = "0xFFB5A8")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700011B")]
		private bool IsOcclusionMeasuringPaused
		{
			[Token(Token = "0x600044E")]
			[Address(RVA = "0xFFA8FC", Offset = "0xFFA8FC", VA = "0xFFA8FC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700011C")]
		private bool HasEndLinkedGroups
		{
			[Token(Token = "0x600044F")]
			[Address(RVA = "0xFFC358", Offset = "0xFFC358", VA = "0xFFC358")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000426")]
		[Address(RVA = "0xFF765C", Offset = "0xFF765C", VA = "0xFF765C")]
		public void GlidePitch(float targetPitch, float glideTime, [Optional] Action completionCallback)
		{
		}

		[Token(Token = "0x6000427")]
		[Address(RVA = "0xFF8988", Offset = "0xFF8988", VA = "0xFF8988")]
		public void FadeOverTimeToVolume(float targetVolume, float fadeTime)
		{
		}

		[Token(Token = "0x6000428")]
		[Address(RVA = "0xFF8C64", Offset = "0xFF8C64", VA = "0xFF8C64")]
		public void FadeOutEarly(float fadeTime)
		{
		}

		[Token(Token = "0x6000429")]
		[Address(RVA = "0xFF82A4", Offset = "0xFF82A4", VA = "0xFF82A4")]
		public void Initialize()
		{
		}

		[Token(Token = "0x600042A")]
		[Address(RVA = "0xFF7114", Offset = "0xFF7114", VA = "0xFF7114")]
		public void FadeInOut()
		{
		}

		[Token(Token = "0x600042B")]
		[Address(RVA = "0xFF731C", Offset = "0xFF731C", VA = "0xFF731C")]
		public void FollowObject(bool follow, Transform objToFollow, bool clipAgePriority)
		{
		}

		[Token(Token = "0x600042C")]
		[Address(RVA = "0xFF82DC", Offset = "0xFF82DC", VA = "0xFF82DC")]
		public void WaitForSoundFinish()
		{
		}

		[Token(Token = "0x600042D")]
		[Address(RVA = "0xFF84DC", Offset = "0xFF84DC", VA = "0xFF84DC")]
		public void StopPitchGliding()
		{
		}

		[Token(Token = "0x600042E")]
		[Address(RVA = "0xFF84AC", Offset = "0xFF84AC", VA = "0xFF84AC")]
		public void StopFading()
		{
		}

		[Token(Token = "0x600042F")]
		[Address(RVA = "0xFF7D98", Offset = "0xFF7D98", VA = "0xFF7D98")]
		public void StopWaitingForFinish()
		{
		}

		[Token(Token = "0x6000430")]
		[Address(RVA = "0xFF849C", Offset = "0xFF849C", VA = "0xFF849C")]
		public void StopFollowing()
		{
		}

		[Token(Token = "0x6000431")]
		[Address(RVA = "0xFFA554", Offset = "0xFFA554", VA = "0xFFA554")]
		private void DisableIfFinished()
		{
		}

		[Token(Token = "0x6000432")]
		[Address(RVA = "0xFFA0C4", Offset = "0xFFA0C4", VA = "0xFFA0C4")]
		private void UpdateAudioLocationAndPriority(bool rePrioritize)
		{
		}

		[Token(Token = "0x6000433")]
		[Address(RVA = "0xFFA700", Offset = "0xFFA700", VA = "0xFFA700")]
		private void ResetToNonOcclusionSetting()
		{
		}

		[Token(Token = "0x6000434")]
		[Address(RVA = "0xFFA7AC", Offset = "0xFFA7AC", VA = "0xFFA7AC")]
		private void UpdateOcclusion()
		{
		}

		[Token(Token = "0x6000435")]
		[Address(RVA = "0xFFA98C", Offset = "0xFFA98C", VA = "0xFFA98C")]
		private void DoneWithOcclusion()
		{
		}

		[Token(Token = "0x6000436")]
		[Address(RVA = "0xFFAA08", Offset = "0xFFAA08", VA = "0xFFAA08")]
		public bool RayCastForOcclusion()
		{
			return default(bool);
		}

		[Token(Token = "0x6000437")]
		[Address(RVA = "0xFFA240", Offset = "0xFFA240", VA = "0xFFA240")]
		private void PlaySoundAndWait()
		{
		}

		[Token(Token = "0x6000438")]
		[Address(RVA = "0xFFB79C", Offset = "0xFFB79C", VA = "0xFFB79C")]
		private void DuckIfNotSilent()
		{
		}

		[Token(Token = "0x6000439")]
		[Address(RVA = "0xFFB90C", Offset = "0xFFB90C", VA = "0xFFB90C")]
		private void StopOrChain()
		{
		}

		[Token(Token = "0x600043A")]
		[Address(RVA = "0xFF79A0", Offset = "0xFF79A0", VA = "0xFF79A0")]
		public void Pause()
		{
		}

		[Token(Token = "0x600043B")]
		[Address(RVA = "0xFFB9A8", Offset = "0xFFB9A8", VA = "0xFFB9A8")]
		public void Unpause()
		{
		}

		[Token(Token = "0x600043C")]
		[Address(RVA = "0xFF7A80", Offset = "0xFF7A80", VA = "0xFF7A80")]
		public void MaybeChain()
		{
		}

		[Token(Token = "0x600043D")]
		[Address(RVA = "0xFFBA84", Offset = "0xFFBA84", VA = "0xFFBA84")]
		private void UpdatePitch()
		{
		}

		[Token(Token = "0x600043E")]
		[Address(RVA = "0xFFBB48", Offset = "0xFFBB48", VA = "0xFFBB48")]
		private void PerformFading()
		{
		}

		[Token(Token = "0x600043F")]
		[Address(RVA = "0xFFBE08", Offset = "0xFFBE08", VA = "0xFFBE08")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000440")]
		[Address(RVA = "0xFFBE94", Offset = "0xFFBE94", VA = "0xFFBE94")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000441")]
		[Address(RVA = "0xFF5EA0", Offset = "0xFF5EA0", VA = "0xFF5EA0")]
		public void UpdateCachedObjects()
		{
		}

		[Token(Token = "0x6000442")]
		[Address(RVA = "0xFFBF84", Offset = "0xFFBF84", VA = "0xFFBF84")]
		public void ManualUpdate()
		{
		}

		[Token(Token = "0x6000450")]
		[Address(RVA = "0xFFC5A4", Offset = "0xFFC5A4", VA = "0xFFC5A4")]
		public SoundGroupVariationUpdater()
		{
		}
	}
	[Token(Token = "0x20000B3")]
	public static class AudioPrioritizer
	{
		[Token(Token = "0x4000547")]
		private const int MaxPriority = 0;

		[Token(Token = "0x4000548")]
		private const int HighestPriority = 16;

		[Token(Token = "0x4000549")]
		private const int LowestPriority = 128;

		[Token(Token = "0x6000452")]
		[Address(RVA = "0xA05D48", Offset = "0xA05D48", VA = "0xA05D48")]
		public static void Set2DSoundPriority(AudioSource audio)
		{
		}

		[Token(Token = "0x6000453")]
		[Address(RVA = "0xA05D64", Offset = "0xA05D64", VA = "0xA05D64")]
		public static void SetSoundGroupInitialPriority(AudioSource audio)
		{
		}

		[Token(Token = "0x6000454")]
		[Address(RVA = "0xA05D80", Offset = "0xA05D80", VA = "0xA05D80")]
		public static void SetPreviewPriority(AudioSource audio)
		{
		}

		[Token(Token = "0x6000455")]
		[Address(RVA = "0xA05D9C", Offset = "0xA05D9C", VA = "0xA05D9C")]
		public static void Set3DPriority(SoundGroupVariation variation, bool useClipAgePriority)
		{
		}
	}
	[Token(Token = "0x20000B4")]
	public static class AudioResourceOptimizer
	{
		[Token(Token = "0x2000104")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x981704", Offset = "0x981704")]
		private sealed class <PopulateResourceSongToPlaylistControllerAsync>d__13 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400078A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400078B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400078C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public string songResourceName;

			[Token(Token = "0x400078D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public string playlistName;

			[Token(Token = "0x400078E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public PlaylistController controller;

			[Token(Token = "0x400078F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public PlaylistController.AudioPlayType playType;

			[Token(Token = "0x4000790")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private ResourceRequest <asyncRes>5__2;

			[Token(Token = "0x17000196")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000720")]
				[Address(RVA = "0xA087D0", Offset = "0xA087D0", VA = "0xA087D0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000197")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000722")]
				[Address(RVA = "0xA08838", Offset = "0xA08838", VA = "0xA08838", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600071D")]
			[Address(RVA = "0xA07244", Offset = "0xA07244", VA = "0xA07244")]
			[DebuggerHidden]
			public <PopulateResourceSongToPlaylistControllerAsync>d__13(int <>1__state)
			{
			}

			[Token(Token = "0x600071E")]
			[Address(RVA = "0xA08330", Offset = "0xA08330", VA = "0xA08330", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600071F")]
			[Address(RVA = "0xA08334", Offset = "0xA08334", VA = "0xA08334", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000721")]
			[Address(RVA = "0xA087D8", Offset = "0xA087D8", VA = "0xA087D8", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x2000105")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x981714", Offset = "0x981714")]
		private sealed class <PopulateSourceWithInternetFile>d__14 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000791")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000792")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000793")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public string fileUrl;

			[Token(Token = "0x4000794")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Action successAction;

			[Token(Token = "0x4000795")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public SoundGroupVariation variation;

			[Token(Token = "0x4000796")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Action failureAction;

			[Token(Token = "0x4000797")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private WWW <fileRequest>5__2;

			[Token(Token = "0x17000198")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000727")]
				[Address(RVA = "0xA091A4", Offset = "0xA091A4", VA = "0xA091A4", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000199")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000729")]
				[Address(RVA = "0xA0920C", Offset = "0xA0920C", VA = "0xA0920C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000723")]
			[Address(RVA = "0xA07300", Offset = "0xA07300", VA = "0xA07300")]
			[DebuggerHidden]
			public <PopulateSourceWithInternetFile>d__14(int <>1__state)
			{
			}

			[Token(Token = "0x6000724")]
			[Address(RVA = "0xA08840", Offset = "0xA08840", VA = "0xA08840", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000725")]
			[Address(RVA = "0xA0891C", Offset = "0xA0891C", VA = "0xA0891C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000726")]
			[Address(RVA = "0xA0885C", Offset = "0xA0885C", VA = "0xA0885C")]
			private void <>m__Finally1()
			{
			}

			[Token(Token = "0x6000728")]
			[Address(RVA = "0xA091AC", Offset = "0xA091AC", VA = "0xA091AC", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x2000106")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x981724", Offset = "0x981724")]
		private sealed class <PopulateSourcesWithResourceClipAsync>d__16 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000798")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000799")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400079A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public string clipName;

			[Token(Token = "0x400079B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Action successAction;

			[Token(Token = "0x400079C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Action failureAction;

			[Token(Token = "0x400079D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public SoundGroupVariation variation;

			[Token(Token = "0x400079E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private ResourceRequest <asyncRes>5__2;

			[Token(Token = "0x1700019A")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600072D")]
				[Address(RVA = "0xA0975C", Offset = "0xA0975C", VA = "0xA0975C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700019B")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600072F")]
				[Address(RVA = "0xA097C4", Offset = "0xA097C4", VA = "0xA097C4", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600072A")]
			[Address(RVA = "0xA07684", Offset = "0xA07684", VA = "0xA07684")]
			[DebuggerHidden]
			public <PopulateSourcesWithResourceClipAsync>d__16(int <>1__state)
			{
			}

			[Token(Token = "0x600072B")]
			[Address(RVA = "0xA09214", Offset = "0xA09214", VA = "0xA09214", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600072C")]
			[Address(RVA = "0xA09218", Offset = "0xA09218", VA = "0xA09218", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600072E")]
			[Address(RVA = "0xA09764", Offset = "0xA09764", VA = "0xA09764", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400054A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly Dictionary<string, List<AudioSource>> AudioResourceTargetsByName;

		[Token(Token = "0x400054B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static readonly Dictionary<string, AudioClip> AudioClipsByName;

		[Token(Token = "0x400054C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static readonly Dictionary<string, List<AudioClip>> PlaylistClipsByPlaylistName;

		[Token(Token = "0x400054D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static readonly List<string> InternetFilesStartedLoading;

		[Token(Token = "0x400054E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static string _supportedLanguageFolder;

		[Token(Token = "0x6000456")]
		[Address(RVA = "0xA06230", Offset = "0xA06230", VA = "0xA06230")]
		public static void ClearAudioClips()
		{
		}

		[Token(Token = "0x6000457")]
		[Address(RVA = "0xA062CC", Offset = "0xA062CC", VA = "0xA062CC")]
		public static string GetLocalizedDynamicSoundGroupFileName(SystemLanguage localLanguage, bool useLocalization, string resourceFileName)
		{
			return null;
		}

		[Token(Token = "0x6000458")]
		[Address(RVA = "0xA0641C", Offset = "0xA0641C", VA = "0xA0641C")]
		public static string GetLocalizedFileName(bool useLocalization, string resourceFileName)
		{
			return null;
		}

		[Token(Token = "0x6000459")]
		[Address(RVA = "0xA06770", Offset = "0xA06770", VA = "0xA06770")]
		public static void AddTargetForClip(string clipName, AudioSource source)
		{
		}

		[Token(Token = "0x600045A")]
		[Address(RVA = "0xA064B8", Offset = "0xA064B8", VA = "0xA064B8")]
		private static string SupportedLanguageFolder()
		{
			return null;
		}

		[Token(Token = "0x600045B")]
		[Address(RVA = "0xA06BA4", Offset = "0xA06BA4", VA = "0xA06BA4")]
		public static void ClearSupportLanguageFolder()
		{
		}

		[Token(Token = "0x600045C")]
		[Address(RVA = "0xA06C20", Offset = "0xA06C20", VA = "0xA06C20")]
		public static AudioClip PopulateResourceSongToPlaylistController(string controllerName, string songResourceName, string playlistName)
		{
			return null;
		}

		[Token(Token = "0x600045D")]
		[Address(RVA = "0xA07050", Offset = "0xA07050", VA = "0xA07050")]
		private static void FinishRecordingPlaylistClip(string controllerName, AudioClip resAudioClip)
		{
		}

		[Token(Token = "0x600045E")]
		[Address(RVA = "0xA071B0", Offset = "0xA071B0", VA = "0xA071B0")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x983CD8", Offset = "0x983CD8")]
		public static IEnumerator PopulateResourceSongToPlaylistControllerAsync(string songResourceName, string playlistName, PlaylistController controller, PlaylistController.AudioPlayType playType)
		{
			return null;
		}

		[Token(Token = "0x600045F")]
		[Address(RVA = "0xA07270", Offset = "0xA07270", VA = "0xA07270")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x983D3C", Offset = "0x983D3C")]
		public static IEnumerator PopulateSourceWithInternetFile(string fileUrl, SoundGroupVariation variation, Action successAction, Action failureAction)
		{
			return null;
		}

		[Token(Token = "0x6000460")]
		[Address(RVA = "0xA0732C", Offset = "0xA0732C", VA = "0xA0732C")]
		public static void RemoveLoadedInternetClip(string fileUrl)
		{
		}

		[Token(Token = "0x6000461")]
		[Address(RVA = "0xA075F4", Offset = "0xA075F4", VA = "0xA075F4")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x983DA0", Offset = "0x983DA0")]
		public static IEnumerator PopulateSourcesWithResourceClipAsync(string clipName, SoundGroupVariation variation, Action successAction, Action failureAction)
		{
			return null;
		}

		[Token(Token = "0x6000462")]
		[Address(RVA = "0xA076B0", Offset = "0xA076B0", VA = "0xA076B0")]
		public static void UnloadPlaylistSongIfUnused(string controllerName, AudioClip clipToRemove)
		{
		}

		[Token(Token = "0x6000463")]
		[Address(RVA = "0xA0781C", Offset = "0xA0781C", VA = "0xA0781C")]
		public static bool PopulateSourcesWithResourceClip(string clipName, SoundGroupVariation variation)
		{
			return default(bool);
		}

		[Token(Token = "0x6000464")]
		[Address(RVA = "0xA07CD4", Offset = "0xA07CD4", VA = "0xA07CD4")]
		public static void DeleteAudioSourceFromList(string clipName, AudioSource source)
		{
		}

		[Token(Token = "0x6000465")]
		[Address(RVA = "0xA07E74", Offset = "0xA07E74", VA = "0xA07E74")]
		public static void UnloadClipIfUnused(string clipName)
		{
		}
	}
	[Token(Token = "0x20000B5")]
	[AttributeAttribute(Name = "AudioScriptOrder", RVA = "0x981554", Offset = "0x981554")]
	public class MasterAudio : MonoBehaviour
	{
		[Token(Token = "0x2000107")]
		public enum AmbientSoundExitMode
		{
			[Token(Token = "0x40007A0")]
			StopSound,
			[Token(Token = "0x40007A1")]
			FadeSound
		}

		[Token(Token = "0x2000108")]
		public enum VariationFollowerType
		{
			[Token(Token = "0x40007A3")]
			LateUpdate,
			[Token(Token = "0x40007A4")]
			FixedUpdate
		}

		[Token(Token = "0x2000109")]
		public enum LinkedGroupSelectionType
		{
			[Token(Token = "0x40007A6")]
			All,
			[Token(Token = "0x40007A7")]
			OneAtRandom
		}

		[Token(Token = "0x200010A")]
		public enum OcclusionSelectionType
		{
			[Token(Token = "0x40007A9")]
			AllGroups,
			[Token(Token = "0x40007AA")]
			TurnOnPerBusOrGroup
		}

		[Token(Token = "0x200010B")]
		public enum RaycastMode
		{
			[Token(Token = "0x40007AC")]
			Physics3D,
			[Token(Token = "0x40007AD")]
			Physics2D
		}

		[Token(Token = "0x200010C")]
		public enum AllMusicSpatialBlendType
		{
			[Token(Token = "0x40007AF")]
			ForceAllTo2D,
			[Token(Token = "0x40007B0")]
			ForceAllTo3D,
			[Token(Token = "0x40007B1")]
			ForceAllToCustom,
			[Token(Token = "0x40007B2")]
			AllowDifferentPerController
		}

		[Token(Token = "0x200010D")]
		public enum AllMixerSpatialBlendType
		{
			[Token(Token = "0x40007B4")]
			ForceAllTo2D,
			[Token(Token = "0x40007B5")]
			ForceAllTo3D,
			[Token(Token = "0x40007B6")]
			ForceAllToCustom,
			[Token(Token = "0x40007B7")]
			AllowDifferentPerGroup
		}

		[Token(Token = "0x200010E")]
		public enum ItemSpatialBlendType
		{
			[Token(Token = "0x40007B9")]
			ForceTo2D,
			[Token(Token = "0x40007BA")]
			ForceTo3D,
			[Token(Token = "0x40007BB")]
			ForceToCustom,
			[Token(Token = "0x40007BC")]
			UseCurveFromAudioSource
		}

		[Token(Token = "0x200010F")]
		public enum InternetFileLoadStatus
		{
			[Token(Token = "0x40007BE")]
			Loading,
			[Token(Token = "0x40007BF")]
			Loaded,
			[Token(Token = "0x40007C0")]
			Failed
		}

		[Token(Token = "0x2000110")]
		public enum MixerWidthMode
		{
			[Token(Token = "0x40007C2")]
			Narrow,
			[Token(Token = "0x40007C3")]
			Normal,
			[Token(Token = "0x40007C4")]
			Wide
		}

		[Token(Token = "0x2000111")]
		public enum CustomEventReceiveMode
		{
			[Token(Token = "0x40007C6")]
			Always,
			[Token(Token = "0x40007C7")]
			WhenDistanceLessThan,
			[Token(Token = "0x40007C8")]
			WhenDistanceMoreThan,
			[Token(Token = "0x40007C9")]
			Never,
			[Token(Token = "0x40007CA")]
			OnSameGameObject,
			[Token(Token = "0x40007CB")]
			OnChildGameObject,
			[Token(Token = "0x40007CC")]
			OnParentGameObject,
			[Token(Token = "0x40007CD")]
			OnSameOrChildGameObject,
			[Token(Token = "0x40007CE")]
			OnSameOrParentGameObject
		}

		[Token(Token = "0x2000112")]
		public enum EventReceiveFilter
		{
			[Token(Token = "0x40007D0")]
			All,
			[Token(Token = "0x40007D1")]
			Closest,
			[Token(Token = "0x40007D2")]
			Random
		}

		[Token(Token = "0x2000113")]
		public enum AudioLocation
		{
			[Token(Token = "0x40007D4")]
			Clip,
			[Token(Token = "0x40007D5")]
			ResourceFile,
			[Token(Token = "0x40007D6")]
			FileOnInternet
		}

		[Token(Token = "0x2000114")]
		public enum CustomSongStartTimeMode
		{
			[Token(Token = "0x40007D8")]
			Beginning,
			[Token(Token = "0x40007D9")]
			SpecificTime,
			[Token(Token = "0x40007DA")]
			RandomTime
		}

		[Token(Token = "0x2000115")]
		public enum BusCommand
		{
			[Token(Token = "0x40007DC")]
			None,
			[Token(Token = "0x40007DD")]
			FadeToVolume,
			[Token(Token = "0x40007DE")]
			Mute,
			[Token(Token = "0x40007DF")]
			Pause,
			[Token(Token = "0x40007E0")]
			Solo,
			[Token(Token = "0x40007E1")]
			Unmute,
			[Token(Token = "0x40007E2")]
			Unpause,
			[Token(Token = "0x40007E3")]
			Unsolo,
			[Token(Token = "0x40007E4")]
			Stop,
			[Token(Token = "0x40007E5")]
			ChangePitch,
			[Token(Token = "0x40007E6")]
			ToggleMute,
			[Token(Token = "0x40007E7")]
			StopBusOfTransform,
			[Token(Token = "0x40007E8")]
			PauseBusOfTransform,
			[Token(Token = "0x40007E9")]
			UnpauseBusOfTransform,
			[Token(Token = "0x40007EA")]
			GlideByPitch
		}

		[Token(Token = "0x2000116")]
		public enum DragGroupMode
		{
			[Token(Token = "0x40007EC")]
			OneGroupPerClip,
			[Token(Token = "0x40007ED")]
			OneGroupWithVariations
		}

		[Token(Token = "0x2000117")]
		public enum EventSoundFunctionType
		{
			[Token(Token = "0x40007EF")]
			PlaySound,
			[Token(Token = "0x40007F0")]
			GroupControl,
			[Token(Token = "0x40007F1")]
			BusControl,
			[Token(Token = "0x40007F2")]
			PlaylistControl,
			[Token(Token = "0x40007F3")]
			CustomEventControl,
			[Token(Token = "0x40007F4")]
			GlobalControl,
			[Token(Token = "0x40007F5")]
			UnityMixerControl,
			[Token(Token = "0x40007F6")]
			PersistentSettingsControl
		}

		[Token(Token = "0x2000118")]
		public enum LanguageMode
		{
			[Token(Token = "0x40007F8")]
			UseDeviceSetting,
			[Token(Token = "0x40007F9")]
			SpecificLanguage,
			[Token(Token = "0x40007FA")]
			DynamicallySet
		}

		[Token(Token = "0x2000119")]
		public enum UnityMixerCommand
		{
			[Token(Token = "0x40007FC")]
			None,
			[Token(Token = "0x40007FD")]
			TransitionToSnapshot,
			[Token(Token = "0x40007FE")]
			TransitionToSnapshotBlend
		}

		[Token(Token = "0x200011A")]
		public enum PlaylistCommand
		{
			[Token(Token = "0x4000800")]
			None,
			[Token(Token = "0x4000801")]
			ChangePlaylist,
			[Token(Token = "0x4000802")]
			FadeToVolume,
			[Token(Token = "0x4000803")]
			PlaySong,
			[Token(Token = "0x4000804")]
			PlayRandomSong,
			[Token(Token = "0x4000805")]
			PlayNextSong,
			[Token(Token = "0x4000806")]
			Pause,
			[Token(Token = "0x4000807")]
			Resume,
			[Token(Token = "0x4000808")]
			Stop,
			[Token(Token = "0x4000809")]
			Mute,
			[Token(Token = "0x400080A")]
			Unmute,
			[Token(Token = "0x400080B")]
			ToggleMute,
			[Token(Token = "0x400080C")]
			Restart,
			[Token(Token = "0x400080D")]
			Start,
			[Token(Token = "0x400080E")]
			StopLoopingCurrentSong,
			[Token(Token = "0x400080F")]
			StopPlaylistAfterCurrentSong,
			[Token(Token = "0x4000810")]
			AddSongToQueue
		}

		[Token(Token = "0x200011B")]
		public enum CustomEventCommand
		{
			[Token(Token = "0x4000812")]
			None,
			[Token(Token = "0x4000813")]
			FireEvent
		}

		[Token(Token = "0x200011C")]
		public enum GlobalCommand
		{
			[Token(Token = "0x4000815")]
			None,
			[Token(Token = "0x4000816")]
			PauseMixer,
			[Token(Token = "0x4000817")]
			UnpauseMixer,
			[Token(Token = "0x4000818")]
			StopMixer,
			[Token(Token = "0x4000819")]
			StopEverything,
			[Token(Token = "0x400081A")]
			PauseEverything,
			[Token(Token = "0x400081B")]
			UnpauseEverything,
			[Token(Token = "0x400081C")]
			MuteEverything,
			[Token(Token = "0x400081D")]
			UnmuteEverything,
			[Token(Token = "0x400081E")]
			SetMasterMixerVolume,
			[Token(Token = "0x400081F")]
			SetMasterPlaylistVolume
		}

		[Token(Token = "0x200011D")]
		public enum SoundGroupCommand
		{
			[Token(Token = "0x4000821")]
			None,
			[Token(Token = "0x4000822")]
			FadeToVolume,
			[Token(Token = "0x4000823")]
			FadeOutAllOfSound,
			[Token(Token = "0x4000824")]
			Mute,
			[Token(Token = "0x4000825")]
			Pause,
			[Token(Token = "0x4000826")]
			Solo,
			[Token(Token = "0x4000827")]
			StopAllOfSound,
			[Token(Token = "0x4000828")]
			Unmute,
			[Token(Token = "0x4000829")]
			Unpause,
			[Token(Token = "0x400082A")]
			Unsolo,
			[Token(Token = "0x400082B")]
			StopAllSoundsOfTransform,
			[Token(Token = "0x400082C")]
			PauseAllSoundsOfTransform,
			[Token(Token = "0x400082D")]
			UnpauseAllSoundsOfTransform,
			[Token(Token = "0x400082E")]
			StopSoundGroupOfTransform,
			[Token(Token = "0x400082F")]
			PauseSoundGroupOfTransform,
			[Token(Token = "0x4000830")]
			UnpauseSoundGroupOfTransform,
			[Token(Token = "0x4000831")]
			FadeOutSoundGroupOfTransform,
			[Token(Token = "0x4000832")]
			RefillSoundGroupPool,
			[Token(Token = "0x4000833")]
			RouteToBus,
			[Token(Token = "0x4000834")]
			GlideByPitch,
			[Token(Token = "0x4000835")]
			ToggleSoundGroup,
			[Token(Token = "0x4000836")]
			ToggleSoundGroupOfTransform,
			[Token(Token = "0x4000837")]
			FadeOutAllSoundsOfTransform
		}

		[Token(Token = "0x200011E")]
		public enum PersistentSettingsCommand
		{
			[Token(Token = "0x4000839")]
			None,
			[Token(Token = "0x400083A")]
			SetBusVolume,
			[Token(Token = "0x400083B")]
			SetGroupVolume,
			[Token(Token = "0x400083C")]
			SetMixerVolume,
			[Token(Token = "0x400083D")]
			SetMusicVolume,
			[Token(Token = "0x400083E")]
			MixerMuteToggle,
			[Token(Token = "0x400083F")]
			MusicMuteToggle
		}

		[Token(Token = "0x200011F")]
		public enum SongFadeInPosition
		{
			[Token(Token = "0x4000841")]
			NewClipFromBeginning = 1,
			[Token(Token = "0x4000842")]
			NewClipFromLastKnownPosition = 3,
			[Token(Token = "0x4000843")]
			SynchronizeClips = 5
		}

		[Token(Token = "0x2000120")]
		public enum SoundSpawnLocationMode
		{
			[Token(Token = "0x4000845")]
			MasterAudioLocation,
			[Token(Token = "0x4000846")]
			CallerLocation,
			[Token(Token = "0x4000847")]
			AttachToCaller
		}

		[Token(Token = "0x2000121")]
		public enum VariationCommand
		{
			[Token(Token = "0x4000849")]
			None,
			[Token(Token = "0x400084A")]
			Stop,
			[Token(Token = "0x400084B")]
			Pause,
			[Token(Token = "0x400084C")]
			Unpause
		}

		[Token(Token = "0x2000122")]
		public struct CustomEventCandidate
		{
			[Token(Token = "0x400084D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public float DistanceAway;

			[Token(Token = "0x400084E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public ICustomEventReceiver Receiver;

			[Token(Token = "0x400084F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform Trans;

			[Token(Token = "0x4000850")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public int RandomId;

			[Token(Token = "0x6000730")]
			[Address(RVA = "0xFE985C", Offset = "0xFE985C", VA = "0xFE985C")]
			public CustomEventCandidate(float distance, ICustomEventReceiver rec, Transform trans, int randomId)
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000123")]
		public class AudioGroupInfo
		{
			[Token(Token = "0x4000851")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public List<AudioInfo> Sources;

			[Token(Token = "0x4000852")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public int LastFramePlayed;

			[Token(Token = "0x4000853")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public float LastTimePlayed;

			[Token(Token = "0x4000854")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public MasterAudioGroup Group;

			[Token(Token = "0x4000855")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public bool PlayedForWarming;

			[Token(Token = "0x6000731")]
			[Address(RVA = "0xFE97B8", Offset = "0xFE97B8", VA = "0xFE97B8")]
			public AudioGroupInfo(List<AudioInfo> sources, MasterAudioGroup groupScript)
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000124")]
		public class AudioInfo
		{
			[Token(Token = "0x4000856")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public AudioSource Source;

			[Token(Token = "0x4000857")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float OriginalVolume;

			[Token(Token = "0x4000858")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public float LastPercentageVolume;

			[Token(Token = "0x4000859")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float LastRandomVolume;

			[Token(Token = "0x400085A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public SoundGroupVariation Variation;

			[Token(Token = "0x6000732")]
			[Address(RVA = "0xFE9804", Offset = "0xFE9804", VA = "0xFE9804")]
			public AudioInfo(SoundGroupVariation variation, AudioSource source, float origVol)
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000125")]
		public class Playlist
		{
			[Token(Token = "0x200014F")]
			public enum CrossfadeTimeMode
			{
				[Token(Token = "0x40008D3")]
				UseMasterSetting,
				[Token(Token = "0x40008D4")]
				Override
			}

			[Token(Token = "0x400085B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public bool isExpanded;

			[Token(Token = "0x400085C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public string playlistName;

			[Token(Token = "0x400085D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public SongFadeInPosition songTransitionType;

			[Token(Token = "0x400085E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public List<MusicSetting> MusicSettings;

			[Token(Token = "0x400085F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public AudioLocation bulkLocationMode;

			[Token(Token = "0x4000860")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			public CrossfadeTimeMode crossfadeMode;

			[Token(Token = "0x4000861")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public float crossFadeTime;

			[Token(Token = "0x4000862")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public bool fadeInFirstSong;

			[Token(Token = "0x4000863")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3D")]
			public bool fadeOutLastSong;

			[Token(Token = "0x4000864")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3E")]
			public bool bulkEditMode;

			[Token(Token = "0x4000865")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3F")]
			public bool resourceClipsAllLoadAsync;

			[Token(Token = "0x4000866")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public bool isTemporary;

			[Token(Token = "0x4000867")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x41")]
			public bool showMetadata;

			[Token(Token = "0x4000868")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public List<SongMetadataProperty> songMetadataProps;

			[Token(Token = "0x4000869")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public string newMetadataPropName;

			[Token(Token = "0x400086A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public SongMetadataProperty.MetadataPropertyType newMetadataPropType;

			[Token(Token = "0x400086B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			public bool newMetadataPropRequired;

			[Token(Token = "0x400086C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5D")]
			public bool newMetadataPropCanHaveMult;

			[Token(Token = "0x6000733")]
			[Address(RVA = "0xFE986C", Offset = "0xFE986C", VA = "0xFE986C")]
			public Playlist()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000126")]
		public class SoundGroupRefillInfo
		{
			[Token(Token = "0x400086D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float LastTimePlayed;

			[Token(Token = "0x400086E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public float InactivePeriodSeconds;

			[Token(Token = "0x6000734")]
			[Address(RVA = "0xFE9950", Offset = "0xFE9950", VA = "0xFE9950")]
			public SoundGroupRefillInfo(float lastTimePlayed, float inactivePeriodSeconds)
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000127")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x981734", Offset = "0x981734")]
		private sealed class <>c
		{
			[Token(Token = "0x400086F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x4000870")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Predicate<OcclusionFreqChangeInfo> <>9__211_0;

			[Token(Token = "0x4000871")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public static Predicate<BusFadeInfo> <>9__212_0;

			[Token(Token = "0x4000872")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public static Predicate<GroupFadeInfo> <>9__213_0;

			[Token(Token = "0x4000873")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public static Predicate<GroupPitchGlideInfo> <>9__214_0;

			[Token(Token = "0x4000874")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public static Predicate<BusPitchGlideInfo> <>9__215_0;

			[Token(Token = "0x4000875")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public static Comparison<CustomEventCandidate> <>9__409_0;

			[Token(Token = "0x4000876")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public static Comparison<CustomEventCandidate> <>9__409_1;

			[Token(Token = "0x6000736")]
			[Address(RVA = "0xFE8884", Offset = "0xFE8884", VA = "0xFE8884")]
			public <>c()
			{
			}

			[Token(Token = "0x6000737")]
			[Address(RVA = "0xFE888C", Offset = "0xFE888C", VA = "0xFE888C")]
			internal bool <PerformOcclusionFrequencyChanges>b__211_0(OcclusionFreqChangeInfo obj)
			{
				return default(bool);
			}

			[Token(Token = "0x6000738")]
			[Address(RVA = "0xFE88AC", Offset = "0xFE88AC", VA = "0xFE88AC")]
			internal bool <PerformBusFades>b__212_0(BusFadeInfo obj)
			{
				return default(bool);
			}

			[Token(Token = "0x6000739")]
			[Address(RVA = "0xFE88CC", Offset = "0xFE88CC", VA = "0xFE88CC")]
			internal bool <PerformGroupFades>b__213_0(GroupFadeInfo obj)
			{
				return default(bool);
			}

			[Token(Token = "0x600073A")]
			[Address(RVA = "0xFE88EC", Offset = "0xFE88EC", VA = "0xFE88EC")]
			internal bool <PerformGroupPitchGlides>b__214_0(GroupPitchGlideInfo obj)
			{
				return default(bool);
			}

			[Token(Token = "0x600073B")]
			[Address(RVA = "0xFE890C", Offset = "0xFE890C", VA = "0xFE890C")]
			internal bool <PerformBusPitchGlides>b__215_0(BusPitchGlideInfo obj)
			{
				return default(bool);
			}

			[Token(Token = "0x600073C")]
			[Address(RVA = "0xFE892C", Offset = "0xFE892C", VA = "0xFE892C")]
			internal int <FireCustomEvent>b__409_0(CustomEventCandidate x, CustomEventCandidate y)
			{
				return default(int);
			}

			[Token(Token = "0x600073D")]
			[Address(RVA = "0xFE893C", Offset = "0xFE893C", VA = "0xFE893C")]
			internal int <FireCustomEvent>b__409_1(CustomEventCandidate x, CustomEventCandidate y)
			{
				return default(int);
			}
		}

		[Token(Token = "0x2000128")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x981744", Offset = "0x981744")]
		private sealed class <>c__DisplayClass225_0
		{
			[Token(Token = "0x4000877")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public bool done;

			[Token(Token = "0x600073E")]
			[Address(RVA = "0xFE8950", Offset = "0xFE8950", VA = "0xFE8950")]
			public <>c__DisplayClass225_0()
			{
			}

			[Token(Token = "0x600073F")]
			[Address(RVA = "0xFE8958", Offset = "0xFE8958", VA = "0xFE8958")]
			internal void <PlaySoundAndWaitUntilFinished>b__0()
			{
			}
		}

		[Token(Token = "0x2000129")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x981754", Offset = "0x981754")]
		private sealed class <PlaySoundAndWaitUntilFinished>d__225 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000878")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000879")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400087A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public string sType;

			[Token(Token = "0x400087B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public float volumePercentage;

			[Token(Token = "0x400087C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public float? pitch;

			[Token(Token = "0x400087D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			public float delaySoundTime;

			[Token(Token = "0x400087E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public string variationName;

			[Token(Token = "0x400087F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private <>c__DisplayClass225_0 <>8__1;

			[Token(Token = "0x4000880")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public Action completedAction;

			[Token(Token = "0x1700019C")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000743")]
				[Address(RVA = "0xFE9748", Offset = "0xFE9748", VA = "0xFE9748", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700019D")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000745")]
				[Address(RVA = "0xFE97B0", Offset = "0xFE97B0", VA = "0xFE97B0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000740")]
			[Address(RVA = "0xFE948C", Offset = "0xFE948C", VA = "0xFE948C")]
			[DebuggerHidden]
			public <PlaySoundAndWaitUntilFinished>d__225(int <>1__state)
			{
			}

			[Token(Token = "0x6000741")]
			[Address(RVA = "0xFE94B8", Offset = "0xFE94B8", VA = "0xFE94B8", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000742")]
			[Address(RVA = "0xFE94BC", Offset = "0xFE94BC", VA = "0xFE94BC", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000744")]
			[Address(RVA = "0xFE9750", Offset = "0xFE9750", VA = "0xFE9750", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x200012A")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x981764", Offset = "0x981764")]
		private sealed class <>c__DisplayClass226_0
		{
			[Token(Token = "0x4000881")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public bool done;

			[Token(Token = "0x6000746")]
			[Address(RVA = "0xFE8964", Offset = "0xFE8964", VA = "0xFE8964")]
			public <>c__DisplayClass226_0()
			{
			}

			[Token(Token = "0x6000747")]
			[Address(RVA = "0xFE896C", Offset = "0xFE896C", VA = "0xFE896C")]
			internal void <PlaySound3DAtTransformAndWaitUntilFinished>b__0()
			{
			}
		}

		[Token(Token = "0x200012B")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x981774", Offset = "0x981774")]
		private sealed class <PlaySound3DAtTransformAndWaitUntilFinished>d__226 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000882")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000883")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000884")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public string sType;

			[Token(Token = "0x4000885")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Transform sourceTrans;

			[Token(Token = "0x4000886")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public float volumePercentage;

			[Token(Token = "0x4000887")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			public float? pitch;

			[Token(Token = "0x4000888")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public float delaySoundTime;

			[Token(Token = "0x4000889")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public string variationName;

			[Token(Token = "0x400088A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public double? timeToSchedulePlay;

			[Token(Token = "0x400088B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private <>c__DisplayClass226_0 <>8__1;

			[Token(Token = "0x400088C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			public Action completedAction;

			[Token(Token = "0x1700019E")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600074B")]
				[Address(RVA = "0xFE90D4", Offset = "0xFE90D4", VA = "0xFE90D4", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700019F")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600074D")]
				[Address(RVA = "0xFE913C", Offset = "0xFE913C", VA = "0xFE913C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000748")]
			[Address(RVA = "0xFE8D44", Offset = "0xFE8D44", VA = "0xFE8D44")]
			[DebuggerHidden]
			public <PlaySound3DAtTransformAndWaitUntilFinished>d__226(int <>1__state)
			{
			}

			[Token(Token = "0x6000749")]
			[Address(RVA = "0xFE8D70", Offset = "0xFE8D70", VA = "0xFE8D70", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600074A")]
			[Address(RVA = "0xFE8D74", Offset = "0xFE8D74", VA = "0xFE8D74", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600074C")]
			[Address(RVA = "0xFE90DC", Offset = "0xFE90DC", VA = "0xFE90DC", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x200012C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x981784", Offset = "0x981784")]
		private sealed class <>c__DisplayClass227_0
		{
			[Token(Token = "0x400088D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public bool done;

			[Token(Token = "0x600074E")]
			[Address(RVA = "0xFE8978", Offset = "0xFE8978", VA = "0xFE8978")]
			public <>c__DisplayClass227_0()
			{
			}

			[Token(Token = "0x600074F")]
			[Address(RVA = "0xFE8980", Offset = "0xFE8980", VA = "0xFE8980")]
			internal void <PlaySound3DFollowTransformAndWaitUntilFinished>b__0()
			{
			}
		}

		[Token(Token = "0x200012D")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x981794", Offset = "0x981794")]
		private sealed class <PlaySound3DFollowTransformAndWaitUntilFinished>d__227 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400088E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400088F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000890")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public string sType;

			[Token(Token = "0x4000891")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Transform sourceTrans;

			[Token(Token = "0x4000892")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public float volumePercentage;

			[Token(Token = "0x4000893")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			public float? pitch;

			[Token(Token = "0x4000894")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public float delaySoundTime;

			[Token(Token = "0x4000895")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public string variationName;

			[Token(Token = "0x4000896")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public double? timeToSchedulePlay;

			[Token(Token = "0x4000897")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private <>c__DisplayClass227_0 <>8__1;

			[Token(Token = "0x4000898")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			public Action completedAction;

			[Token(Token = "0x170001A0")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000753")]
				[Address(RVA = "0xFE941C", Offset = "0xFE941C", VA = "0xFE941C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170001A1")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000755")]
				[Address(RVA = "0xFE9484", Offset = "0xFE9484", VA = "0xFE9484", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000750")]
			[Address(RVA = "0xFE9144", Offset = "0xFE9144", VA = "0xFE9144")]
			[DebuggerHidden]
			public <PlaySound3DFollowTransformAndWaitUntilFinished>d__227(int <>1__state)
			{
			}

			[Token(Token = "0x6000751")]
			[Address(RVA = "0xFE9170", Offset = "0xFE9170", VA = "0xFE9170", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000752")]
			[Address(RVA = "0xFE9174", Offset = "0xFE9174", VA = "0xFE9174", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000754")]
			[Address(RVA = "0xFE9424", Offset = "0xFE9424", VA = "0xFE9424", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x200012E")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9817A4", Offset = "0x9817A4")]
		private sealed class <>c__DisplayClass260_0
		{
			[Token(Token = "0x4000899")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string busName;

			[Token(Token = "0x6000756")]
			[Address(RVA = "0xFE898C", Offset = "0xFE898C", VA = "0xFE898C")]
			public <>c__DisplayClass260_0()
			{
			}

			[Token(Token = "0x6000757")]
			[Address(RVA = "0xFE8994", Offset = "0xFE8994", VA = "0xFE8994")]
			internal bool <RouteGroupToBus>b__1(GroupBus x)
			{
				return default(bool);
			}

			[Token(Token = "0x6000758")]
			[Address(RVA = "0xFE89B8", Offset = "0xFE89B8", VA = "0xFE89B8")]
			internal bool <RouteGroupToBus>b__0(GroupBus x)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x200012F")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9817B4", Offset = "0x9817B4")]
		private sealed class <>c__DisplayClass268_0
		{
			[Token(Token = "0x400089A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string sType;

			[Token(Token = "0x6000759")]
			[Address(RVA = "0xFE89DC", Offset = "0xFE89DC", VA = "0xFE89DC")]
			public <>c__DisplayClass268_0()
			{
			}

			[Token(Token = "0x600075A")]
			[Address(RVA = "0xFE89E4", Offset = "0xFE89E4", VA = "0xFE89E4")]
			internal bool <FadeSoundGroupToVolume>b__0(GroupFadeInfo obj)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x2000130")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9817C4", Offset = "0x9817C4")]
		private sealed class <>c__DisplayClass269_0
		{
			[Token(Token = "0x400089B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string sType;

			[Token(Token = "0x600075B")]
			[Address(RVA = "0xFE8A08", Offset = "0xFE8A08", VA = "0xFE8A08")]
			public <>c__DisplayClass269_0()
			{
			}

			[Token(Token = "0x600075C")]
			[Address(RVA = "0xFE8A10", Offset = "0xFE8A10", VA = "0xFE8A10")]
			internal bool <GlideSoundGroupByPitch>b__0(GroupPitchGlideInfo obj)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x2000131")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9817D4", Offset = "0x9817D4")]
		private sealed class <>c__DisplayClass321_0
		{
			[Token(Token = "0x400089C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string busName;

			[Token(Token = "0x600075D")]
			[Address(RVA = "0xFE8A34", Offset = "0xFE8A34", VA = "0xFE8A34")]
			public <>c__DisplayClass321_0()
			{
			}

			[Token(Token = "0x600075E")]
			[Address(RVA = "0xFE8A3C", Offset = "0xFE8A3C", VA = "0xFE8A3C")]
			internal bool <CreateBus>b__0(GroupBus obj)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x2000132")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9817E4", Offset = "0x9817E4")]
		private sealed class <>c__DisplayClass325_0
		{
			[Token(Token = "0x400089D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string busName;

			[Token(Token = "0x600075F")]
			[Address(RVA = "0xFE8A60", Offset = "0xFE8A60", VA = "0xFE8A60")]
			public <>c__DisplayClass325_0()
			{
			}

			[Token(Token = "0x6000760")]
			[Address(RVA = "0xFE8A68", Offset = "0xFE8A68", VA = "0xFE8A68")]
			internal bool <FadeBusToVolume>b__0(BusFadeInfo obj)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x2000133")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9817F4", Offset = "0x9817F4")]
		private sealed class <>c__DisplayClass326_0
		{
			[Token(Token = "0x400089E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string busName;

			[Token(Token = "0x6000761")]
			[Address(RVA = "0xFE8A8C", Offset = "0xFE8A8C", VA = "0xFE8A8C")]
			public <>c__DisplayClass326_0()
			{
			}

			[Token(Token = "0x6000762")]
			[Address(RVA = "0xFE8A94", Offset = "0xFE8A94", VA = "0xFE8A94")]
			internal bool <GlideBusByPitch>b__0(BusPitchGlideInfo obj)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x2000134")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x981804", Offset = "0x981804")]
		private sealed class <>c__DisplayClass405_0
		{
			[Token(Token = "0x400089F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string categoryName;

			[Token(Token = "0x6000763")]
			[Address(RVA = "0xFE8AB8", Offset = "0xFE8AB8", VA = "0xFE8AB8")]
			public <>c__DisplayClass405_0()
			{
			}

			[Token(Token = "0x6000764")]
			[Address(RVA = "0xFE8AC0", Offset = "0xFE8AC0", VA = "0xFE8AC0")]
			internal bool <CreateCustomEventCategoryIfNotThere>b__0(CustomEventCategory cat)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x2000135")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x981814", Offset = "0x981814")]
		private sealed class <>c__DisplayClass406_0
		{
			[Token(Token = "0x40008A0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string customEventName;

			[Token(Token = "0x6000765")]
			[Address(RVA = "0xFE8AE4", Offset = "0xFE8AE4", VA = "0xFE8AE4")]
			public <>c__DisplayClass406_0()
			{
			}

			[Token(Token = "0x6000766")]
			[Address(RVA = "0xFE8AEC", Offset = "0xFE8AEC", VA = "0xFE8AEC")]
			internal bool <CreateCustomEvent>b__0(CustomEvent obj)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x2000136")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x981824", Offset = "0x981824")]
		private sealed class <>c__DisplayClass407_0
		{
			[Token(Token = "0x40008A1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string customEventName;

			[Token(Token = "0x6000767")]
			[Address(RVA = "0xFE8B10", Offset = "0xFE8B10", VA = "0xFE8B10")]
			public <>c__DisplayClass407_0()
			{
			}

			[Token(Token = "0x6000768")]
			[Address(RVA = "0xFE8B18", Offset = "0xFE8B18", VA = "0xFE8B18")]
			internal bool <DeleteCustomEvent>b__0(CustomEvent obj)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x2000137")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x981834", Offset = "0x981834")]
		private sealed class <>c__DisplayClass408_0
		{
			[Token(Token = "0x40008A2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string customEventName;

			[Token(Token = "0x6000769")]
			[Address(RVA = "0xFE8B3C", Offset = "0xFE8B3C", VA = "0xFE8B3C")]
			public <>c__DisplayClass408_0()
			{
			}

			[Token(Token = "0x600076A")]
			[Address(RVA = "0xFE8B44", Offset = "0xFE8B44", VA = "0xFE8B44")]
			internal bool <GetCustomEventByName>b__0(CustomEvent obj)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x2000138")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x981844", Offset = "0x981844")]
		private sealed class <>c__DisplayClass410_0
		{
			[Token(Token = "0x40008A3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string customEventName;

			[Token(Token = "0x600076B")]
			[Address(RVA = "0xFE8B68", Offset = "0xFE8B68", VA = "0xFE8B68")]
			public <>c__DisplayClass410_0()
			{
			}

			[Token(Token = "0x600076C")]
			[Address(RVA = "0xFE8B70", Offset = "0xFE8B70", VA = "0xFE8B70")]
			internal bool <CustomEventExists>b__0(CustomEvent obj)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x2000139")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x981854", Offset = "0x981854")]
		private sealed class <>c__DisplayClass411_0
		{
			[Token(Token = "0x40008A4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string eventName;

			[Token(Token = "0x600076D")]
			[Address(RVA = "0xFE8B94", Offset = "0xFE8B94", VA = "0xFE8B94")]
			public <>c__DisplayClass411_0()
			{
			}

			[Token(Token = "0x600076E")]
			[Address(RVA = "0xFE8B9C", Offset = "0xFE8B9C", VA = "0xFE8B9C")]
			internal bool <GetChildReceivers>b__0(ICustomEventReceiver rec)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x200013A")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x981864", Offset = "0x981864")]
		private sealed class <>c__DisplayClass412_0
		{
			[Token(Token = "0x40008A5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string eventName;

			[Token(Token = "0x600076F")]
			[Address(RVA = "0xFE8C6C", Offset = "0xFE8C6C", VA = "0xFE8C6C")]
			public <>c__DisplayClass412_0()
			{
			}

			[Token(Token = "0x6000770")]
			[Address(RVA = "0xFE8C74", Offset = "0xFE8C74", VA = "0xFE8C74")]
			internal bool <GetParentReceivers>b__0(ICustomEventReceiver rec)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x400054F")]
		public const string MasterAudioDefaultFolder = "Assets/Plugins/DarkTonic/MasterAudio";

		[Token(Token = "0x4000550")]
		public const string PreviewText = "Random delay, custom fading & start/end position settings are ignored by preview in edit mode.";

		[Token(Token = "0x4000551")]
		public const string LoopDisabledLoopedChain = "Loop Clip is always OFF for Looped Chain Groups";

		[Token(Token = "0x4000552")]
		public const string LoopDisabledCustomStartEnd = "Loop Clip is always OFF when using Custom Start/End Position";

		[Token(Token = "0x4000553")]
		public const string DragAudioTip = "Drag Audio clips or a folder containing some here";

		[Token(Token = "0x4000554")]
		public const string NoCategory = "[Uncategorized]";

		[Token(Token = "0x4000555")]
		public const float SemiTonePitchFactor = 1.05946f;

		[Token(Token = "0x4000556")]
		public const float SpatialBlend_2DValue = 0f;

		[Token(Token = "0x4000557")]
		public const float SpatialBlend_3DValue = 1f;

		[Token(Token = "0x4000558")]
		public const float MaxCrossFadeTimeSeconds = 120f;

		[Token(Token = "0x4000559")]
		public const float DefaultDuckVolCut = -6f;

		[Token(Token = "0x400055A")]
		public const string StoredLanguageNameKey = "~MA_Language_Key~";

		[Token(Token = "0x400055B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly YieldInstruction EndOfFrameDelay;

		[Token(Token = "0x400055C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static readonly List<string> ExemptChildNames;

		[Token(Token = "0x400055D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static Action NumberOfAudioSourcesChanged;

		[Token(Token = "0x400055E")]
		public const int HardCodedBusOptions = 2;

		[Token(Token = "0x400055F")]
		public const string AllBusesName = "[All]";

		[Token(Token = "0x4000560")]
		public const string NoGroupName = "[None]";

		[Token(Token = "0x4000561")]
		public const string DynamicGroupName = "[Type In]";

		[Token(Token = "0x4000562")]
		public const string NoPlaylistName = "[No Playlist]";

		[Token(Token = "0x4000563")]
		public const string NoVoiceLimitName = "[NO LMT]";

		[Token(Token = "0x4000564")]
		public const string OnlyPlaylistControllerName = "~only~";

		[Token(Token = "0x4000565")]
		public const float InnerLoopCheckInterval = 0.1f;

		[Token(Token = "0x4000566")]
		private const int MaxComponents = 20;

		[Token(Token = "0x4000567")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AudioLocation bulkLocationMode;

		[Token(Token = "0x4000568")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string groupTemplateName;

		[Token(Token = "0x4000569")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string audioSourceTemplateName;

		[Token(Token = "0x400056A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool showGroupCreation;

		[Token(Token = "0x400056B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
		public bool useGroupTemplates;

		[Token(Token = "0x400056C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public DragGroupMode curDragGroupMode;

		[Token(Token = "0x400056D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public List<GameObject> groupTemplates;

		[Token(Token = "0x400056E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public List<GameObject> audioSourceTemplates;

		[Token(Token = "0x400056F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public bool mixerMuted;

		[Token(Token = "0x4000570")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x49")]
		public bool playlistsMuted;

		[Token(Token = "0x4000571")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public LanguageMode langMode;

		[Token(Token = "0x4000572")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public SystemLanguage testLanguage;

		[Token(Token = "0x4000573")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public SystemLanguage defaultLanguage;

		[Token(Token = "0x4000574")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public List<SystemLanguage> supportedLanguages;

		[Token(Token = "0x4000575")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public string busFilter;

		[Token(Token = "0x4000576")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public bool useTextGroupFilter;

		[Token(Token = "0x4000577")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public string textGroupFilter;

		[Token(Token = "0x4000578")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public bool resourceClipsPauseDoNotUnload;

		[Token(Token = "0x4000579")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x79")]
		public bool resourceClipsAllLoadAsync;

		[Token(Token = "0x400057A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public Transform playlistControllerPrefab;

		[Token(Token = "0x400057B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public bool persistBetweenScenes;

		[Token(Token = "0x400057C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x89")]
		public bool shouldLogDestroys;

		[Token(Token = "0x400057D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8A")]
		public bool areGroupsExpanded;

		[Token(Token = "0x400057E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public Transform soundGroupTemplate;

		[Token(Token = "0x400057F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public Transform soundGroupVariationTemplate;

		[Token(Token = "0x4000580")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public List<GroupBus> groupBuses;

		[Token(Token = "0x4000581")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public bool groupByBus;

		[Token(Token = "0x4000582")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA9")]
		public bool showRangeSoundGizmos;

		[Token(Token = "0x4000583")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAA")]
		public bool showSelectedRangeSoundGizmos;

		[Token(Token = "0x4000584")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		public Color rangeGizmoColor;

		[Token(Token = "0x4000585")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		public Color selectedRangeGizmoColor;

		[Token(Token = "0x4000586")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		public bool showAdvancedSettings;

		[Token(Token = "0x4000587")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCD")]
		public bool showLocalization;

		[Token(Token = "0x4000588")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCE")]
		public bool playListExpanded;

		[Token(Token = "0x4000589")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCF")]
		public bool playlistsExpanded;

		[Token(Token = "0x400058A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public AllMusicSpatialBlendType musicSpatialBlendType;

		[Token(Token = "0x400058B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		public float musicSpatialBlend;

		[Token(Token = "0x400058C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		public AllMixerSpatialBlendType mixerSpatialBlendType;

		[Token(Token = "0x400058D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		public float mixerSpatialBlend;

		[Token(Token = "0x400058E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		public ItemSpatialBlendType newGroupSpatialType;

		[Token(Token = "0x400058F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		public float newGroupSpatialBlend;

		[Token(Token = "0x4000590")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		public List<Playlist> musicPlaylists;

		[Token(Token = "0x4000591")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		public float _masterAudioVolume;

		[Token(Token = "0x4000592")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
		public bool vrSettingsExpanded;

		[Token(Token = "0x4000593")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF5")]
		public bool useSpatializer;

		[Token(Token = "0x4000594")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF6")]
		public bool useSpatializerPostFX;

		[Token(Token = "0x4000595")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF7")]
		public bool ignoreTimeScale;

		[Token(Token = "0x4000596")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		public bool useGaplessPlaylists;

		[Token(Token = "0x4000597")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF9")]
		public bool saveRuntimeChanges;

		[Token(Token = "0x4000598")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xFA")]
		public bool prioritizeOnDistance;

		[Token(Token = "0x4000599")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xFC")]
		public int rePrioritizeEverySecIndex;

		[Token(Token = "0x400059A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		public bool useOcclusion;

		[Token(Token = "0x400059B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
		public float occlusionMaxCutoffFreq;

		[Token(Token = "0x400059C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		public float occlusionMinCutoffFreq;

		[Token(Token = "0x400059D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10C")]
		public float occlusionFreqChangeSeconds;

		[Token(Token = "0x400059E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		public OcclusionSelectionType occlusionSelectType;

		[Token(Token = "0x400059F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x114")]
		public int occlusionMaxRayCastsPerFrame;

		[Token(Token = "0x40005A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		public float occlusionRayCastOffset;

		[Token(Token = "0x40005A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11C")]
		public bool occlusionUseLayerMask;

		[Token(Token = "0x40005A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		public LayerMask occlusionLayerMask;

		[Token(Token = "0x40005A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x124")]
		public bool occlusionShowRaycasts;

		[Token(Token = "0x40005A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x125")]
		public bool occlusionShowCategories;

		[Token(Token = "0x40005A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		public RaycastMode occlusionRaycastMode;

		[Token(Token = "0x40005A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x12C")]
		public bool occlusionIncludeStartRaycast2DCollider;

		[Token(Token = "0x40005A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x12D")]
		public bool occlusionRaycastsHitTriggers;

		[Token(Token = "0x40005A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x12E")]
		public bool ambientAdvancedExpanded;

		[Token(Token = "0x40005A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		public int ambientMaxRecalcsPerFrame;

		[Token(Token = "0x40005AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x134")]
		public bool visualAdvancedExpanded;

		[Token(Token = "0x40005AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x135")]
		public bool logAdvancedExpanded;

		[Token(Token = "0x40005AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x136")]
		public bool listenerAdvancedExpanded;

		[Token(Token = "0x40005AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x137")]
		public bool listenerFollowerHasRigidBody;

		[Token(Token = "0x40005AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		public VariationFollowerType variationFollowerType;

		[Token(Token = "0x40005AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x13C")]
		public bool showFadingSettings;

		[Token(Token = "0x40005B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x13D")]
		public bool stopZeroVolumeGroups;

		[Token(Token = "0x40005B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x13E")]
		public bool stopZeroVolumeBuses;

		[Token(Token = "0x40005B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x13F")]
		public bool stopZeroVolumePlaylists;

		[Token(Token = "0x40005B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		public float stopOldestBusFadeTime;

		[Token(Token = "0x40005B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x144")]
		public bool resourceAdvancedExpanded;

		[Token(Token = "0x40005B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x145")]
		public bool useClipAgePriority;

		[Token(Token = "0x40005B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x146")]
		public bool logOutOfVoices;

		[Token(Token = "0x40005B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x147")]
		public bool LogSounds;

		[Token(Token = "0x40005B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		public bool logCustomEvents;

		[Token(Token = "0x40005B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x149")]
		public bool disableLogging;

		[Token(Token = "0x40005BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14A")]
		public bool showMusicDucking;

		[Token(Token = "0x40005BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14B")]
		public bool enableMusicDucking;

		[Token(Token = "0x40005BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		public List<DuckGroupInfo> musicDuckingSounds;

		[Token(Token = "0x40005BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		public float defaultRiseVolStart;

		[Token(Token = "0x40005BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x15C")]
		public float defaultUnduckTime;

		[Token(Token = "0x40005BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		public float defaultDuckedVolumeCut;

		[Token(Token = "0x40005C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x164")]
		public float crossFadeTime;

		[Token(Token = "0x40005C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		public float _masterPlaylistVolume;

		[Token(Token = "0x40005C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x16C")]
		public bool showGroupSelect;

		[Token(Token = "0x40005C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x16D")]
		public bool hideGroupsWithNoActiveVars;

		[Token(Token = "0x40005C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		public string newEventName;

		[Token(Token = "0x40005C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
		public bool showCustomEvents;

		[Token(Token = "0x40005C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
		public string newCustomEventCategoryName;

		[Token(Token = "0x40005C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
		public string addToCustomEventCategoryName;

		[Token(Token = "0x40005C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
		public List<CustomEvent> customEvents;

		[Token(Token = "0x40005C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
		public List<CustomEventCategory> customEventCategories;

		[Token(Token = "0x40005CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
		public Dictionary<string, DuckGroupInfo> duckingBySoundType;

		[Token(Token = "0x40005CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
		public int frames;

		[Token(Token = "0x40005CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1AC")]
		public bool showUnityMixerGroupAssignment;

		[Token(Token = "0x40005CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public static readonly PlaySoundResult AndForgetSuccessResult;

		[Token(Token = "0x40005CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
		private readonly Dictionary<string, AudioGroupInfo> AudioSourcesBySoundType;

		[Token(Token = "0x40005CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
		private Dictionary<string, List<int>> _randomizer;

		[Token(Token = "0x40005D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
		private Dictionary<string, List<int>> _randomizerOrigin;

		[Token(Token = "0x40005D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C8")]
		private Dictionary<string, List<int>> _randomizerLeftovers;

		[Token(Token = "0x40005D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D0")]
		private Dictionary<string, List<int>> _clipsPlayedBySoundTypeOldestFirst;

		[Token(Token = "0x40005D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D8")]
		private readonly List<SoundGroupVariationUpdater> ActiveVariationUpdaters;

		[Token(Token = "0x40005D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E0")]
		private readonly List<SoundGroupVariationUpdater> ActiveUpdatersToRemove;

		[Token(Token = "0x40005D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E8")]
		private readonly List<CustomEventCandidate> ValidReceivers;

		[Token(Token = "0x40005D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F0")]
		private readonly List<MasterAudioGroup> SoloedGroups;

		[Token(Token = "0x40005D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F8")]
		private readonly Queue<CustomEventToFireInfo> CustomEventsToFire;

		[Token(Token = "0x40005D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x200")]
		private readonly Queue<TransformFollower> TransFollowerColliderPositionRecalcs;

		[Token(Token = "0x40005D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x208")]
		private readonly List<TransformFollower> ProcessedColliderPositionRecalcs;

		[Token(Token = "0x40005DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x210")]
		private readonly List<BusFadeInfo> BusFades;

		[Token(Token = "0x40005DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x218")]
		private readonly List<GroupFadeInfo> GroupFades;

		[Token(Token = "0x40005DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x220")]
		private readonly List<GroupPitchGlideInfo> GroupPitchGlides;

		[Token(Token = "0x40005DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x228")]
		private readonly List<BusPitchGlideInfo> BusPitchGlides;

		[Token(Token = "0x40005DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x230")]
		private readonly List<OcclusionFreqChangeInfo> VariationOcclusionFreqChanges;

		[Token(Token = "0x40005DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x238")]
		private readonly List<AudioSource> AllAudioSources;

		[Token(Token = "0x40005E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x240")]
		private readonly Dictionary<string, Dictionary<ICustomEventReceiver, Transform>> ReceiversByEventName;

		[Token(Token = "0x40005E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x248")]
		private readonly Dictionary<string, PlaylistController> PlaylistControllersByName;

		[Token(Token = "0x40005E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x250")]
		private readonly Dictionary<string, SoundGroupRefillInfo> LastTimeSoundGroupPlayed;

		[Token(Token = "0x40005E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x258")]
		private readonly List<GameObject> OcclusionSourcesInRange;

		[Token(Token = "0x40005E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x260")]
		private readonly List<GameObject> OcclusionSourcesOutOfRange;

		[Token(Token = "0x40005E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x268")]
		private readonly List<GameObject> OcclusionSourcesBlocked;

		[Token(Token = "0x40005E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x270")]
		private readonly Queue<SoundGroupVariationUpdater> QueuedOcclusionRays;

		[Token(Token = "0x40005E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x278")]
		private readonly List<SoundGroupVariation> VariationsStartedDuringMultiStop;

		[Token(Token = "0x40005E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x280")]
		private bool _isStoppingMultiple;

		[Token(Token = "0x40005E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x284")]
		private float _repriTime;

		[Token(Token = "0x40005EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x288")]
		private List<string> _groupsToRemove;

		[Token(Token = "0x40005EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x290")]
		private bool _mustRescanGroups;

		[Token(Token = "0x40005EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x298")]
		private Transform _trans;

		[Token(Token = "0x40005ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2A0")]
		private bool _soundsLoaded;

		[Token(Token = "0x40005EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2A1")]
		private bool _warming;

		[Token(Token = "0x40005EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static MasterAudio _instance;

		[Token(Token = "0x40005F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static string _prospectiveMAFolder;

		[Token(Token = "0x40005F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static Transform _listenerTrans;

		[Token(Token = "0x40005F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public static readonly List<SoundGroupCommand> GroupCommandsWithNoGroupSelector;

		[Token(Token = "0x40005F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public static readonly List<SoundGroupCommand> GroupCommandsWithNoAllGroupSelector;

		[Token(Token = "0x40005F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x982C58", Offset = "0x982C58")]
		private static bool <AppIsShuttingDown>k__BackingField;

		[Token(Token = "0x1700011D")]
		public static float PlaylistMasterVolume
		{
			[Token(Token = "0x600052F")]
			[Address(RVA = "0xA2FFE0", Offset = "0xA2FFE0", VA = "0xA2FFE0")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000530")]
			[Address(RVA = "0xA1D780", Offset = "0xA1D780", VA = "0xA1D780")]
			set
			{
			}
		}

		[Token(Token = "0x1700011E")]
		public static bool LogSoundsEnabled
		{
			[Token(Token = "0x6000541")]
			[Address(RVA = "0xA30D14", Offset = "0xA30D14", VA = "0xA30D14")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000542")]
			[Address(RVA = "0xA30D80", Offset = "0xA30D80", VA = "0xA30D80")]
			set
			{
			}
		}

		[Token(Token = "0x1700011F")]
		public static bool LogOutOfVoices
		{
			[Token(Token = "0x6000543")]
			[Address(RVA = "0xA280FC", Offset = "0xA280FC", VA = "0xA280FC")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000544")]
			[Address(RVA = "0xA30DF4", Offset = "0xA30DF4", VA = "0xA30DF4")]
			set
			{
			}
		}

		[Token(Token = "0x17000120")]
		public static List<AudioSource> MasterAudioSources
		{
			[Token(Token = "0x6000555")]
			[Address(RVA = "0xA31E78", Offset = "0xA31E78", VA = "0xA31E78")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000121")]
		public static Transform ListenerTrans
		{
			[Token(Token = "0x6000557")]
			[Address(RVA = "0xA04C08", Offset = "0xA04C08", VA = "0xA04C08")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000122")]
		public static PlaylistController OnlyPlaylistController
		{
			[Token(Token = "0x6000558")]
			[Address(RVA = "0xA31FBC", Offset = "0xA31FBC", VA = "0xA31FBC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000123")]
		public static bool IsWarming
		{
			[Token(Token = "0x6000559")]
			[Address(RVA = "0xA146AC", Offset = "0xA146AC", VA = "0xA146AC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000124")]
		public static bool MixerMuted
		{
			[Token(Token = "0x600055A")]
			[Address(RVA = "0xA32054", Offset = "0xA32054", VA = "0xA32054")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600055B")]
			[Address(RVA = "0xA2DFEC", Offset = "0xA2DFEC", VA = "0xA2DFEC")]
			set
			{
			}
		}

		[Token(Token = "0x17000125")]
		public static bool PlaylistsMuted
		{
			[Token(Token = "0x600055C")]
			[Address(RVA = "0xA320C0", Offset = "0xA320C0", VA = "0xA320C0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600055D")]
			[Address(RVA = "0xA2F07C", Offset = "0xA2F07C", VA = "0xA2F07C")]
			set
			{
			}
		}

		[Token(Token = "0x17000126")]
		public bool EnableMusicDucking
		{
			[Token(Token = "0x600055E")]
			[Address(RVA = "0xA3212C", Offset = "0xA3212C", VA = "0xA3212C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600055F")]
			[Address(RVA = "0xA32134", Offset = "0xA32134", VA = "0xA32134")]
			set
			{
			}
		}

		[Token(Token = "0x17000127")]
		public float MasterCrossFadeTime
		{
			[Token(Token = "0x6000560")]
			[Address(RVA = "0xA32140", Offset = "0xA32140", VA = "0xA32140")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000128")]
		public static List<Playlist> MusicPlaylists
		{
			[Token(Token = "0x6000561")]
			[Address(RVA = "0xA2ECF4", Offset = "0xA2ECF4", VA = "0xA2ECF4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000129")]
		public static List<GroupBus> GroupBuses
		{
			[Token(Token = "0x6000562")]
			[Address(RVA = "0xA2BB60", Offset = "0xA2BB60", VA = "0xA2BB60")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700012A")]
		public static List<string> RuntimeSoundGroupNames
		{
			[Token(Token = "0x6000563")]
			[Address(RVA = "0xA18DF0", Offset = "0xA18DF0", VA = "0xA18DF0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700012B")]
		public static List<string> RuntimeBusNames
		{
			[Token(Token = "0x6000564")]
			[Address(RVA = "0xA1B08C", Offset = "0xA1B08C", VA = "0xA1B08C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700012C")]
		public static MasterAudio SafeInstance
		{
			[Token(Token = "0x6000565")]
			[Address(RVA = "0xA02EE8", Offset = "0xA02EE8", VA = "0xA02EE8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700012D")]
		public static MasterAudio Instance
		{
			[Token(Token = "0x6000566")]
			[Address(RVA = "0xA03724", Offset = "0xA03724", VA = "0xA03724")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000567")]
			[Address(RVA = "0xA32148", Offset = "0xA32148", VA = "0xA32148")]
			set
			{
			}
		}

		[Token(Token = "0x1700012E")]
		public static bool SoundsReady
		{
			[Token(Token = "0x6000568")]
			[Address(RVA = "0xA0E62C", Offset = "0xA0E62C", VA = "0xA0E62C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700012F")]
		public static bool AppIsShuttingDown
		{
			[Token(Token = "0x6000569")]
			[Address(RVA = "0xA321B0", Offset = "0xA321B0", VA = "0xA321B0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x983F30", Offset = "0x983F30")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600056A")]
			[Address(RVA = "0xA32218", Offset = "0xA32218", VA = "0xA32218")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x983F40", Offset = "0x983F40")]
			set
			{
			}
		}

		[Token(Token = "0x17000130")]
		public List<string> GroupNames
		{
			[Token(Token = "0x600056B")]
			[Address(RVA = "0xA32288", Offset = "0xA32288", VA = "0xA32288")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000131")]
		public static List<string> SoundGroupHardCodedNames
		{
			[Token(Token = "0x600056C")]
			[Address(RVA = "0xA045F4", Offset = "0xA045F4", VA = "0xA045F4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000132")]
		public List<string> BusNames
		{
			[Token(Token = "0x600056D")]
			[Address(RVA = "0xA325C4", Offset = "0xA325C4", VA = "0xA325C4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000133")]
		public List<string> PlaylistNames
		{
			[Token(Token = "0x600056E")]
			[Address(RVA = "0xA326D0", Offset = "0xA326D0", VA = "0xA326D0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000134")]
		public List<string> PlaylistNamesOnly
		{
			[Token(Token = "0x600056F")]
			[Address(RVA = "0xA327DC", Offset = "0xA327DC", VA = "0xA327DC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000135")]
		public Transform Trans
		{
			[Token(Token = "0x6000570")]
			[Address(RVA = "0xA054E4", Offset = "0xA054E4", VA = "0xA054E4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000136")]
		public bool ShouldShowUnityAudioMixerGroupAssignments
		{
			[Token(Token = "0x6000571")]
			[Address(RVA = "0xA328C8", Offset = "0xA328C8", VA = "0xA328C8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000137")]
		public List<string> CustomEventNames
		{
			[Token(Token = "0x6000572")]
			[Address(RVA = "0xA328D0", Offset = "0xA328D0", VA = "0xA328D0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000138")]
		public List<string> CustomEventNamesOnly
		{
			[Token(Token = "0x6000573")]
			[Address(RVA = "0xA32A54", Offset = "0xA32A54", VA = "0xA32A54")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000139")]
		public static List<string> CustomEventHardCodedNames
		{
			[Token(Token = "0x6000574")]
			[Address(RVA = "0xA329B0", Offset = "0xA329B0", VA = "0xA329B0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700013A")]
		public static float MasterVolumeLevel
		{
			[Token(Token = "0x6000575")]
			[Address(RVA = "0xA32B64", Offset = "0xA32B64", VA = "0xA32B64")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000576")]
			[Address(RVA = "0xA1D638", Offset = "0xA1D638", VA = "0xA1D638")]
			set
			{
			}
		}

		[Token(Token = "0x1700013B")]
		private static bool SceneHasMasterAudio
		{
			[Token(Token = "0x6000577")]
			[Address(RVA = "0xA26398", Offset = "0xA26398", VA = "0xA26398")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700013C")]
		public static bool IgnoreTimeScale
		{
			[Token(Token = "0x6000578")]
			[Address(RVA = "0xA0D4BC", Offset = "0xA0D4BC", VA = "0xA0D4BC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700013D")]
		public static SystemLanguage DynamicLanguage
		{
			[Token(Token = "0x6000579")]
			[Address(RVA = "0xA06A20", Offset = "0xA06A20", VA = "0xA06A20")]
			get
			{
				return default(SystemLanguage);
			}
			[Token(Token = "0x600057A")]
			[Address(RVA = "0xA32BD0", Offset = "0xA32BD0", VA = "0xA32BD0")]
			set
			{
			}
		}

		[Token(Token = "0x1700013E")]
		public static float ReprioritizeTime
		{
			[Token(Token = "0x600057B")]
			[Address(RVA = "0xA32C94", Offset = "0xA32C94", VA = "0xA32C94")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700013F")]
		public static bool ShouldRescanGroups
		{
			[Token(Token = "0x600057F")]
			[Address(RVA = "0xA32DE8", Offset = "0xA32DE8", VA = "0xA32DE8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000140")]
		public static string ProspectiveMAPath
		{
			[Token(Token = "0x6000580")]
			[Address(RVA = "0xA32EBC", Offset = "0xA32EBC", VA = "0xA32EBC")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000581")]
			[Address(RVA = "0xA32F24", Offset = "0xA32F24", VA = "0xA32F24")]
			set
			{
			}
		}

		[Token(Token = "0x6000467")]
		[Address(RVA = "0xA22890", Offset = "0xA22890", VA = "0xA22890")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000468")]
		[Address(RVA = "0xA24268", Offset = "0xA24268", VA = "0xA24268")]
		private void Start()
		{
		}

		[Token(Token = "0x6000469")]
		[Address(RVA = "0xA243C0", Offset = "0xA243C0", VA = "0xA243C0")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600046A")]
		[Address(RVA = "0xA24664", Offset = "0xA24664", VA = "0xA24664")]
		private void Update()
		{
		}

		[Token(Token = "0x600046B")]
		[Address(RVA = "0xA25700", Offset = "0xA25700", VA = "0xA25700")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600046C")]
		[Address(RVA = "0xA2579C", Offset = "0xA2579C", VA = "0xA2579C")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x600046D")]
		[Address(RVA = "0xA25710", Offset = "0xA25710", VA = "0xA25710")]
		private void ManualUpdate()
		{
		}

		[Token(Token = "0x600046E")]
		[Address(RVA = "0xA25C0C", Offset = "0xA25C0C", VA = "0xA25C0C")]
		public static void RegisterUpdaterForUpdates(SoundGroupVariationUpdater updater)
		{
		}

		[Token(Token = "0x600046F")]
		[Address(RVA = "0xA25CDC", Offset = "0xA25CDC", VA = "0xA25CDC")]
		public static void UnregisterUpdaterForUpdates(SoundGroupVariationUpdater updater)
		{
		}

		[Token(Token = "0x6000470")]
		[Address(RVA = "0xA25A84", Offset = "0xA25A84", VA = "0xA25A84")]
		private void UpdateActiveVariations()
		{
		}

		[Token(Token = "0x6000471")]
		[Address(RVA = "0xA25D60", Offset = "0xA25D60", VA = "0xA25D60")]
		private static void UpdateRefillTime(string sType, float inactivePeriodSeconds)
		{
		}

		[Token(Token = "0x6000472")]
		[Address(RVA = "0xA257B0", Offset = "0xA257B0", VA = "0xA257B0")]
		private static void RecalcClosestColliderPositions()
		{
		}

		[Token(Token = "0x6000473")]
		[Address(RVA = "0xA25634", Offset = "0xA25634", VA = "0xA25634")]
		private static void FireCustomEventsWaiting()
		{
		}

		[Token(Token = "0x6000474")]
		[Address(RVA = "0xA2539C", Offset = "0xA2539C", VA = "0xA2539C")]
		private static void RefillInactiveGroupPools()
		{
		}

		[Token(Token = "0x6000475")]
		[Address(RVA = "0xA246F8", Offset = "0xA246F8", VA = "0xA246F8")]
		private static void PerformOcclusionFrequencyChanges()
		{
		}

		[Token(Token = "0x6000476")]
		[Address(RVA = "0xA249EC", Offset = "0xA249EC", VA = "0xA249EC")]
		private void PerformBusFades()
		{
		}

		[Token(Token = "0x6000477")]
		[Address(RVA = "0xA24E98", Offset = "0xA24E98", VA = "0xA24E98")]
		private void PerformGroupFades()
		{
		}

		[Token(Token = "0x6000478")]
		[Address(RVA = "0xA251EC", Offset = "0xA251EC", VA = "0xA251EC")]
		private void PerformGroupPitchGlides()
		{
		}

		[Token(Token = "0x6000479")]
		[Address(RVA = "0xA24CEC", Offset = "0xA24CEC", VA = "0xA24CEC")]
		private void PerformBusPitchGlides()
		{
		}

		[Token(Token = "0x600047A")]
		[Address(RVA = "0xA262F0", Offset = "0xA262F0", VA = "0xA262F0")]
		private void OnApplicationQuit()
		{
		}

		[Token(Token = "0x600047B")]
		[Address(RVA = "0xA0C884", Offset = "0xA0C884", VA = "0xA0C884")]
		public static bool PlaySoundAndForget(string sType, float volumePercentage = 1f, [Optional] float? pitch, float delaySoundTime = 0f, [Optional] string variationName, [Optional] double? timeToSchedulePlay)
		{
			return default(bool);
		}

		[Token(Token = "0x600047C")]
		[Address(RVA = "0xA16CA0", Offset = "0xA16CA0", VA = "0xA16CA0")]
		public static PlaySoundResult PlaySound(string sType, float volumePercentage = 1f, [Optional] float? pitch, float delaySoundTime = 0f, [Optional] string variationName, [Optional] double? timeToSchedulePlay, bool isChaining = false, bool isSingleSubscribedPlay = false)
		{
			return null;
		}

		[Token(Token = "0x600047D")]
		[Address(RVA = "0xA279F4", Offset = "0xA279F4", VA = "0xA279F4")]
		public static bool PlaySound3DAtVector3AndForget(string sType, Vector3 sourcePosition, float volumePercentage = 1f, [Optional] float? pitch, float delaySoundTime = 0f, [Optional] string variationName, [Optional] double? timeToSchedulePlay)
		{
			return default(bool);
		}

		[Token(Token = "0x600047E")]
		[Address(RVA = "0xA27BA4", Offset = "0xA27BA4", VA = "0xA27BA4")]
		public static PlaySoundResult PlaySound3DAtVector3(string sType, Vector3 sourcePosition, float volumePercentage = 1f, [Optional] float? pitch, float delaySoundTime = 0f, [Optional] string variationName, [Optional] double? timeToSchedulePlay)
		{
			return null;
		}

		[Token(Token = "0x600047F")]
		[Address(RVA = "0xA09C34", Offset = "0xA09C34", VA = "0xA09C34")]
		public static bool PlaySound3DAtTransformAndForget(string sType, Transform sourceTrans, float volumePercentage = 1f, [Optional] float? pitch, float delaySoundTime = 0f, [Optional] string variationName, [Optional] double? timeToSchedulePlay)
		{
			return default(bool);
		}

		[Token(Token = "0x6000480")]
		[Address(RVA = "0xA09ED8", Offset = "0xA09ED8", VA = "0xA09ED8")]
		public static PlaySoundResult PlaySound3DAtTransform(string sType, Transform sourceTrans, float volumePercentage = 1f, [Optional] float? pitch, float delaySoundTime = 0f, [Optional] string variationName, [Optional] double? timeToSchedulePlay, bool isChaining = false, bool isSingleSubscribedPlay = false)
		{
			return null;
		}

		[Token(Token = "0x6000481")]
		[Address(RVA = "0xA0A164", Offset = "0xA0A164", VA = "0xA0A164")]
		public static bool PlaySound3DFollowTransformAndForget(string sType, Transform sourceTrans, float volumePercentage = 1f, [Optional] float? pitch, float delaySoundTime = 0f, [Optional] string variationName, [Optional] double? timeToSchedulePlay)
		{
			return default(bool);
		}

		[Token(Token = "0x6000482")]
		[Address(RVA = "0xA0A408", Offset = "0xA0A408", VA = "0xA0A408")]
		public static PlaySoundResult PlaySound3DFollowTransform(string sType, Transform sourceTrans, float volumePercentage = 1f, [Optional] float? pitch, float delaySoundTime = 0f, [Optional] string variationName, [Optional] double? timeToSchedulePlay, bool isChaining = false, bool isSingleSubscribedPlay = false)
		{
			return null;
		}

		[Token(Token = "0x6000483")]
		[Address(RVA = "0xA27D38", Offset = "0xA27D38", VA = "0xA27D38")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x983E04", Offset = "0x983E04")]
		public static IEnumerator PlaySoundAndWaitUntilFinished(string sType, float volumePercentage = 1f, [Optional] float? pitch, float delaySoundTime = 0f, [Optional] string variationName, [Optional] Action completedAction)
		{
			return null;
		}

		[Token(Token = "0x6000484")]
		[Address(RVA = "0xA0A6AC", Offset = "0xA0A6AC", VA = "0xA0A6AC")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x983E68", Offset = "0x983E68")]
		public static IEnumerator PlaySound3DAtTransformAndWaitUntilFinished(string sType, Transform sourceTrans, float volumePercentage = 1f, [Optional] float? pitch, float delaySoundTime = 0f, [Optional] string variationName, [Optional] double? timeToSchedulePlay, [Optional] Action completedAction)
		{
			return null;
		}

		[Token(Token = "0x6000485")]
		[Address(RVA = "0xA0A838", Offset = "0xA0A838", VA = "0xA0A838")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x983ECC", Offset = "0x983ECC")]
		public static IEnumerator PlaySound3DFollowTransformAndWaitUntilFinished(string sType, Transform sourceTrans, float volumePercentage = 1f, [Optional] float? pitch, float delaySoundTime = 0f, [Optional] string variationName, [Optional] double? timeToSchedulePlay, [Optional] Action completedAction)
		{
			return null;
		}

		[Token(Token = "0x6000486")]
		[Address(RVA = "0xA279D0", Offset = "0xA279D0", VA = "0xA279D0")]
		public static bool PSRAsSuccessBool(PlaySoundResult psr)
		{
			return default(bool);
		}

		[Token(Token = "0x6000487")]
		[Address(RVA = "0xA2642C", Offset = "0xA2642C", VA = "0xA2642C")]
		private static PlaySoundResult PlaySoundAtVolume(string sType, float volumePercentage, Vector3 sourcePosition, double? timeToSchedulePlay, [Optional] float? pitch, [Optional] Transform sourceTrans, [Optional] string variationName, bool attachToSource = false, float delaySoundTime = 0f, bool useVector3 = false, bool makePlaySoundResult = false, bool isChaining = false, bool isSingleSubscribedPlay = false, bool triggeredAsChildGroup = false)
		{
			return null;
		}

		[Token(Token = "0x6000488")]
		[Address(RVA = "0xA28604", Offset = "0xA28604", VA = "0xA28604")]
		private static void MaybeChainNextVar(bool isChaining, SoundGroupVariation variation, float volumePercentage, float? pitch, Transform sourceTrans, bool attachToSource)
		{
		}

		[Token(Token = "0x6000489")]
		[Address(RVA = "0xA280C0", Offset = "0xA280C0", VA = "0xA280C0")]
		private static void SetLastPlayed(AudioGroupInfo grp)
		{
		}

		[Token(Token = "0x600048A")]
		[Address(RVA = "0xA283FC", Offset = "0xA283FC", VA = "0xA283FC")]
		private static void RemoveClipAndRefillIfEmpty(AudioGroupInfo grp, bool isNonSpecific, int? randomIndex, List<int> choices, string sType, int pickedChoice, bool loggingEnabledForGrp, bool isSingleVarLoop)
		{
		}

		[Token(Token = "0x600048B")]
		[Address(RVA = "0xA28638", Offset = "0xA28638", VA = "0xA28638")]
		private static PlaySoundResult PlaySoundIfAvailable(AudioInfo info, Vector3 sourcePosition, float volumePercentage, ref bool forgetSoundPlayed, [Optional] float? pitch, [Optional] AudioGroupInfo audioGroup, [Optional] Transform sourceTrans, bool attachToSource = false, float delaySoundTime = 0f, bool useVector3 = false, bool makePlaySoundResult = false, [Optional] double? timeToSchedulePlay, bool isChaining = false, bool isSingleSubscribedPlay = false)
		{
			return null;
		}

		[Token(Token = "0x600048C")]
		[Address(RVA = "0xA28CE8", Offset = "0xA28CE8", VA = "0xA28CE8")]
		public static void DuckSoundGroup(string soundGroupName, AudioSource aSource)
		{
		}

		[Token(Token = "0x600048D")]
		[Address(RVA = "0xA28E98", Offset = "0xA28E98", VA = "0xA28E98")]
		private static void StopPauseOrUnpauseSoundsOfTransform(Transform trans, List<AudioInfo> varList, VariationCommand varCmd)
		{
		}

		[Token(Token = "0x600048E")]
		[Address(RVA = "0xA0AF68", Offset = "0xA0AF68", VA = "0xA0AF68")]
		public static void StopAllSoundsOfTransform(Transform sourceTrans)
		{
		}

		[Token(Token = "0x600048F")]
		[Address(RVA = "0xA03114", Offset = "0xA03114", VA = "0xA03114")]
		public static void StopSoundGroupOfTransform(Transform sourceTrans, string sType)
		{
		}

		[Token(Token = "0x6000490")]
		[Address(RVA = "0xA0A964", Offset = "0xA0A964", VA = "0xA0A964")]
		public static void PauseAllSoundsOfTransform(Transform sourceTrans)
		{
		}

		[Token(Token = "0x6000491")]
		[Address(RVA = "0xA0AD8C", Offset = "0xA0AD8C", VA = "0xA0AD8C")]
		public static void PauseSoundGroupOfTransform(Transform sourceTrans, string sType)
		{
		}

		[Token(Token = "0x6000492")]
		[Address(RVA = "0xA0B49C", Offset = "0xA0B49C", VA = "0xA0B49C")]
		public static void UnpauseAllSoundsOfTransform(Transform sourceTrans)
		{
		}

		[Token(Token = "0x6000493")]
		[Address(RVA = "0xA0B8C4", Offset = "0xA0B8C4", VA = "0xA0B8C4")]
		public static void UnpauseSoundGroupOfTransform(Transform sourceTrans, string sType)
		{
		}

		[Token(Token = "0x6000494")]
		[Address(RVA = "0xA1A470", Offset = "0xA1A470", VA = "0xA1A470")]
		public static void FadeOutAllSoundsOfTransform(Transform sourceTrans, float fadeTime)
		{
		}

		[Token(Token = "0x6000495")]
		[Address(RVA = "0xA0328C", Offset = "0xA0328C", VA = "0xA0328C")]
		public static void FadeOutSoundGroupOfTransform(Transform sourceTrans, string sType, float fadeTime)
		{
		}

		[Token(Token = "0x6000496")]
		[Address(RVA = "0xA19D50", Offset = "0xA19D50", VA = "0xA19D50")]
		public static void StopAllOfSound(string sType)
		{
		}

		[Token(Token = "0x6000497")]
		[Address(RVA = "0xA19010", Offset = "0xA19010", VA = "0xA19010")]
		public static void FadeOutAllOfSound(string sType, float fadeTime)
		{
		}

		[Token(Token = "0x6000498")]
		[Address(RVA = "0xA2914C", Offset = "0xA2914C", VA = "0xA2914C")]
		public static List<SoundGroupVariation> GetAllPlayingVariations()
		{
			return null;
		}

		[Token(Token = "0x6000499")]
		[Address(RVA = "0xA098E0", Offset = "0xA098E0", VA = "0xA098E0")]
		public static List<SoundGroupVariation> GetAllPlayingVariationsOfTransform(Transform sourceTrans)
		{
			return null;
		}

		[Token(Token = "0x600049A")]
		[Address(RVA = "0xA293C4", Offset = "0xA293C4", VA = "0xA293C4")]
		public static List<SoundGroupVariation> GetAllPlayingVariationsOfTransformList(List<Transform> sourceTransList)
		{
			return null;
		}

		[Token(Token = "0x600049B")]
		[Address(RVA = "0xA296E8", Offset = "0xA296E8", VA = "0xA296E8")]
		public static List<SoundGroupVariation> GetAllPlayingVariationsInBus(string busName)
		{
			return null;
		}

		[Token(Token = "0x600049C")]
		[Address(RVA = "0xA298B8", Offset = "0xA298B8", VA = "0xA298B8")]
		public static void DeleteGroupVariation(string sType, string variationName)
		{
		}

		[Token(Token = "0x600049D")]
		[Address(RVA = "0xA2A588", Offset = "0xA2A588", VA = "0xA2A588")]
		public static void CreateGroupVariationFromClip(string sType, AudioClip clip, string variationName, float volume = 1f, float pitch = 1f)
		{
		}

		[Token(Token = "0x600049E")]
		[Address(RVA = "0xA2AB84", Offset = "0xA2AB84", VA = "0xA2AB84")]
		public static void ChangeVariationPitch(string sType, bool changeAllVariations, string variationName, float pitch)
		{
		}

		[Token(Token = "0x600049F")]
		[Address(RVA = "0xA2AEC8", Offset = "0xA2AEC8", VA = "0xA2AEC8")]
		public static void ChangeVariationVolume(string sType, bool changeAllVariations, string variationName, float volume)
		{
		}

		[Token(Token = "0x60004A0")]
		[Address(RVA = "0xA2B1A4", Offset = "0xA2B1A4", VA = "0xA2B1A4")]
		public static void ChangeVariationClipFromResources(string sType, bool changeAllVariations, string variationName, string resourceFileName)
		{
		}

		[Token(Token = "0x60004A1")]
		[Address(RVA = "0xA2B354", Offset = "0xA2B354", VA = "0xA2B354")]
		public static void ChangeVariationClip(string sType, bool changeAllVariations, string variationName, AudioClip clip)
		{
		}

		[Token(Token = "0x60004A2")]
		[Address(RVA = "0xA2B5CC", Offset = "0xA2B5CC", VA = "0xA2B5CC")]
		public static void GradualOcclusionFreqChange(SoundGroupVariation variation, float fadeTime, float newCutoffFreq)
		{
		}

		[Token(Token = "0x60004A3")]
		[Address(RVA = "0xA2B884", Offset = "0xA2B884", VA = "0xA2B884")]
		public static AudioSource GetNextVariationForSoundGroup(string sType)
		{
			return null;
		}

		[Token(Token = "0x60004A4")]
		[Address(RVA = "0xA18ED8", Offset = "0xA18ED8", VA = "0xA18ED8")]
		public static bool IsSoundGroupPlaying(string sType)
		{
			return default(bool);
		}

		[Token(Token = "0x60004A5")]
		[Address(RVA = "0xA0BAB0", Offset = "0xA0BAB0", VA = "0xA0BAB0")]
		public static bool IsTransformPlayingSoundGroup(string sType, Transform sourceTrans)
		{
			return default(bool);
		}

		[Token(Token = "0x60004A6")]
		[Address(RVA = "0xA1A608", Offset = "0xA1A608", VA = "0xA1A608")]
		public static void RouteGroupToBus(string sType, string busName)
		{
		}

		[Token(Token = "0x60004A7")]
		[Address(RVA = "0xA2BE10", Offset = "0xA2BE10", VA = "0xA2BE10")]
		public static float GetVariationLength(string sType, string variationName)
		{
			return default(float);
		}

		[Token(Token = "0x60004A8")]
		[Address(RVA = "0xA1922C", Offset = "0xA1922C", VA = "0xA1922C")]
		public static void RefillSoundGroupPool(string sType)
		{
		}

		[Token(Token = "0x60004A9")]
		[Address(RVA = "0xA2C564", Offset = "0xA2C564", VA = "0xA2C564")]
		public static bool SoundGroupExists(string sType)
		{
			return default(bool);
		}

		[Token(Token = "0x60004AA")]
		[Address(RVA = "0xA19AC8", Offset = "0xA19AC8", VA = "0xA19AC8")]
		public static void PauseSoundGroup(string sType)
		{
		}

		[Token(Token = "0x60004AB")]
		[Address(RVA = "0xA2C604", Offset = "0xA2C604", VA = "0xA2C604")]
		public static void SetGroupSpatialBlend(string sType)
		{
		}

		[Token(Token = "0x60004AC")]
		[Address(RVA = "0xA2C750", Offset = "0xA2C750", VA = "0xA2C750")]
		public static void RouteGroupToUnityMixerGroup(string sType, AudioMixerGroup mixerGroup)
		{
		}

		[Token(Token = "0x60004AD")]
		[Address(RVA = "0xA1A15C", Offset = "0xA1A15C", VA = "0xA1A15C")]
		public static void UnpauseSoundGroup(string sType)
		{
		}

		[Token(Token = "0x60004AE")]
		[Address(RVA = "0xA19634", Offset = "0xA19634", VA = "0xA19634")]
		public static void FadeSoundGroupToVolume(string sType, float newVolume, float fadeTime, [Optional] Action completionCallback, bool willStopAfterFade = false, bool willResetVolumeAfterFade = false)
		{
		}

		[Token(Token = "0x60004AF")]
		[Address(RVA = "0xA1ABE4", Offset = "0xA1ABE4", VA = "0xA1ABE4")]
		public static void GlideSoundGroupByPitch(string sType, float pitchAddition, float glideTime, [Optional] Action completionCallback)
		{
		}

		[Token(Token = "0x60004B0")]
		[Address(RVA = "0xA0F31C", Offset = "0xA0F31C", VA = "0xA0F31C")]
		public static void DeleteSoundGroup(string sType)
		{
		}

		[Token(Token = "0x60004B1")]
		[Address(RVA = "0xA10068", Offset = "0xA10068", VA = "0xA10068")]
		public static Transform CreateSoundGroup(DynamicSoundGroup aGroup, string creatorObjectName, bool errorOnExisting = true)
		{
			return null;
		}

		[Token(Token = "0x60004B2")]
		[Address(RVA = "0xA2CAEC", Offset = "0xA2CAEC", VA = "0xA2CAEC")]
		public static float GetGroupVolume(string sType)
		{
			return default(float);
		}

		[Token(Token = "0x60004B3")]
		[Address(RVA = "0xA25ED4", Offset = "0xA25ED4", VA = "0xA25ED4")]
		public static void SetGroupVolume(string sType, float volumeLevel)
		{
		}

		[Token(Token = "0x60004B4")]
		[Address(RVA = "0xA19990", Offset = "0xA19990", VA = "0xA19990")]
		public static void MuteGroup(string sType, bool shouldCheckMuteStatus = true)
		{
		}

		[Token(Token = "0x60004B5")]
		[Address(RVA = "0xA1A054", Offset = "0xA1A054", VA = "0xA1A054")]
		public static void UnmuteGroup(string sType, bool shouldCheckMuteStatus = true)
		{
		}

		[Token(Token = "0x60004B6")]
		[Address(RVA = "0xA24008", Offset = "0xA24008", VA = "0xA24008")]
		private static void AddRuntimeGroupInfo(string groupName, AudioGroupInfo groupInfo)
		{
		}

		[Token(Token = "0x60004B7")]
		[Address(RVA = "0xA2CE04", Offset = "0xA2CE04", VA = "0xA2CE04")]
		private static void FireAudioSourcesNumberChangedEvent()
		{
		}

		[Token(Token = "0x60004B8")]
		[Address(RVA = "0xA2CCA8", Offset = "0xA2CCA8", VA = "0xA2CCA8")]
		public static void TrackRuntimeAudioSources(List<AudioSource> sources)
		{
		}

		[Token(Token = "0x60004B9")]
		[Address(RVA = "0xA24450", Offset = "0xA24450", VA = "0xA24450")]
		public static void StopTrackingRuntimeAudioSources(List<AudioSource> sources)
		{
		}

		[Token(Token = "0x60004BA")]
		[Address(RVA = "0xA2C8BC", Offset = "0xA2C8BC", VA = "0xA2C8BC")]
		private static void RemoveRuntimeGroupInfo(string groupName)
		{
		}

		[Token(Token = "0x60004BB")]
		[Address(RVA = "0xA2CEAC", Offset = "0xA2CEAC", VA = "0xA2CEAC")]
		private static void RescanChildren(MasterAudioGroup group)
		{
		}

		[Token(Token = "0x60004BC")]
		[Address(RVA = "0xA2CBA4", Offset = "0xA2CBA4", VA = "0xA2CBA4")]
		private static void SetGroupMuteStatus(MasterAudioGroup aGroup, string sType, bool isMute)
		{
		}

		[Token(Token = "0x60004BD")]
		[Address(RVA = "0xA19C14", Offset = "0xA19C14", VA = "0xA19C14")]
		public static void SoloGroup(string sType, bool shouldCheckMuteStatus = true)
		{
		}

		[Token(Token = "0x60004BE")]
		[Address(RVA = "0xA0FA50", Offset = "0xA0FA50", VA = "0xA0FA50")]
		public static void SilenceOrUnsilenceGroupsFromSoloChange()
		{
		}

		[Token(Token = "0x60004BF")]
		[Address(RVA = "0xA2D1B8", Offset = "0xA2D1B8", VA = "0xA2D1B8")]
		private static void UnsilenceNonSoloedGroups()
		{
		}

		[Token(Token = "0x60004C0")]
		[Address(RVA = "0xA2D330", Offset = "0xA2D330", VA = "0xA2D330")]
		private static void UnsilenceGroup(string sType)
		{
		}

		[Token(Token = "0x60004C1")]
		[Address(RVA = "0xA2D038", Offset = "0xA2D038", VA = "0xA2D038")]
		private static void SilenceNonSoloedGroups()
		{
		}

		[Token(Token = "0x60004C2")]
		[Address(RVA = "0xA2D460", Offset = "0xA2D460", VA = "0xA2D460")]
		private static void SilenceGroup(string sType)
		{
		}

		[Token(Token = "0x60004C3")]
		[Address(RVA = "0xA1A348", Offset = "0xA1A348", VA = "0xA1A348")]
		public static void UnsoloGroup(string sType, bool shouldCheckMuteStatus = true)
		{
		}

		[Token(Token = "0x60004C4")]
		[Address(RVA = "0xA0527C", Offset = "0xA0527C", VA = "0xA0527C")]
		public static MasterAudioGroup GrabGroup(string sType, bool logIfMissing = true)
		{
			return null;
		}

		[Token(Token = "0x60004C5")]
		[Address(RVA = "0xA2D590", Offset = "0xA2D590", VA = "0xA2D590")]
		public static int VoicesForGroup(string sType)
		{
			return default(int);
		}

		[Token(Token = "0x60004C6")]
		[Address(RVA = "0xA2D670", Offset = "0xA2D670", VA = "0xA2D670")]
		public static Transform FindGroupTransform(string sType)
		{
			return null;
		}

		[Token(Token = "0x60004C7")]
		[Address(RVA = "0xA2D870", Offset = "0xA2D870", VA = "0xA2D870")]
		public static List<AudioInfo> GetAllVariationsOfGroup(string sType, bool logIfMissing = true)
		{
			return null;
		}

		[Token(Token = "0x60004C8")]
		[Address(RVA = "0xA2D9B0", Offset = "0xA2D9B0", VA = "0xA2D9B0")]
		public static AudioGroupInfo GetGroupInfo(string sType)
		{
			return null;
		}

		[Token(Token = "0x60004C9")]
		[Address(RVA = "0xA2DA80", Offset = "0xA2DA80", VA = "0xA2DA80")]
		public static void SubscribeToLastVariationPlayed(string sType, Action finishedCallback)
		{
		}

		[Token(Token = "0x60004CA")]
		[Address(RVA = "0xA2DBCC", Offset = "0xA2DBCC", VA = "0xA2DBCC")]
		public static void UnsubscribeFromLastVariationPlayed(string sType)
		{
		}

		[Token(Token = "0x60004CB")]
		[Address(RVA = "0xA2DCB0", Offset = "0xA2DCB0", VA = "0xA2DCB0")]
		public void SetSpatialBlendForMixer()
		{
		}

		[Token(Token = "0x60004CC")]
		[Address(RVA = "0xA1D850", Offset = "0xA1D850", VA = "0xA1D850")]
		public static void PauseMixer()
		{
		}

		[Token(Token = "0x60004CD")]
		[Address(RVA = "0xA1DA04", Offset = "0xA1DA04", VA = "0xA1DA04")]
		public static void UnpauseMixer()
		{
		}

		[Token(Token = "0x60004CE")]
		[Address(RVA = "0xA1DBB8", Offset = "0xA1DBB8", VA = "0xA1DBB8")]
		public static void StopMixer()
		{
		}

		[Token(Token = "0x60004CF")]
		[Address(RVA = "0xA2DDD8", Offset = "0xA2DDD8", VA = "0xA2DDD8")]
		public static void UnsubscribeFromAllVariations()
		{
		}

		[Token(Token = "0x60004D0")]
		[Address(RVA = "0xA1DF48", Offset = "0xA1DF48", VA = "0xA1DF48")]
		public static void StopEverything()
		{
		}

		[Token(Token = "0x60004D1")]
		[Address(RVA = "0xA1DE88", Offset = "0xA1DE88", VA = "0xA1DE88")]
		public static void PauseEverything()
		{
		}

		[Token(Token = "0x60004D2")]
		[Address(RVA = "0xA1DEE8", Offset = "0xA1DEE8", VA = "0xA1DEE8")]
		public static void UnpauseEverything()
		{
		}

		[Token(Token = "0x60004D3")]
		[Address(RVA = "0xA1DDC0", Offset = "0xA1DDC0", VA = "0xA1DDC0")]
		public static void MuteEverything()
		{
		}

		[Token(Token = "0x60004D4")]
		[Address(RVA = "0xA1DE24", Offset = "0xA1DE24", VA = "0xA1DE24")]
		public static void UnmuteEverything()
		{
		}

		[Token(Token = "0x60004D5")]
		[Address(RVA = "0xA2E330", Offset = "0xA2E330", VA = "0xA2E330")]
		public static List<string> ListOfAudioClipsInGroupsEditTime()
		{
			return null;
		}

		[Token(Token = "0x60004D6")]
		[Address(RVA = "0xA26180", Offset = "0xA26180", VA = "0xA26180")]
		private static int GetBusIndex(string busName, bool alertMissing)
		{
			return default(int);
		}

		[Token(Token = "0x60004D7")]
		[Address(RVA = "0xA2BBCC", Offset = "0xA2BBCC", VA = "0xA2BBCC")]
		private static GroupBus GetBusByIndex(int busIndex)
		{
			return null;
		}

		[Token(Token = "0x60004D8")]
		[Address(RVA = "0xA1C6D4", Offset = "0xA1C6D4", VA = "0xA1C6D4")]
		public static void ChangeBusPitch(string busName, float pitch)
		{
		}

		[Token(Token = "0x60004D9")]
		[Address(RVA = "0xA1BF6C", Offset = "0xA1BF6C", VA = "0xA1BF6C")]
		public static void MuteBus(string busName)
		{
		}

		[Token(Token = "0x60004DA")]
		[Address(RVA = "0xA1C12C", Offset = "0xA1C12C", VA = "0xA1C12C")]
		public static void UnmuteBus(string busName, bool shouldCheckMuteStatus = true)
		{
		}

		[Token(Token = "0x60004DB")]
		[Address(RVA = "0xA1C2A8", Offset = "0xA1C2A8", VA = "0xA1C2A8")]
		public static void ToggleMuteBus(string busName)
		{
		}

		[Token(Token = "0x60004DC")]
		[Address(RVA = "0xA1BB44", Offset = "0xA1BB44", VA = "0xA1BB44")]
		public static void PauseBus(string busName)
		{
		}

		[Token(Token = "0x60004DD")]
		[Address(RVA = "0xA1C398", Offset = "0xA1C398", VA = "0xA1C398")]
		public static void SoloBus(string busName)
		{
		}

		[Token(Token = "0x60004DE")]
		[Address(RVA = "0xA1C558", Offset = "0xA1C558", VA = "0xA1C558")]
		public static void UnsoloBus(string busName, bool shouldCheckMuteStatus = true)
		{
		}

		[Token(Token = "0x60004DF")]
		[Address(RVA = "0xA2E5B0", Offset = "0xA2E5B0", VA = "0xA2E5B0")]
		public static void RouteBusToUnityMixerGroup(string busName, AudioMixerGroup mixerGroup)
		{
		}

		[Token(Token = "0x60004E0")]
		[Address(RVA = "0xA28168", Offset = "0xA28168", VA = "0xA28168")]
		private static void StopOldestSoundOnBus(GroupBus bus)
		{
		}

		[Token(Token = "0x60004E1")]
		[Address(RVA = "0xA1BCA0", Offset = "0xA1BCA0", VA = "0xA1BCA0")]
		public static void StopBus(string busName)
		{
		}

		[Token(Token = "0x60004E2")]
		[Address(RVA = "0xA1BE30", Offset = "0xA1BE30", VA = "0xA1BE30")]
		public static void UnpauseBus(string busName)
		{
		}

		[Token(Token = "0x60004E3")]
		[Address(RVA = "0xA0FE2C", Offset = "0xA0FE2C", VA = "0xA0FE2C")]
		public static bool CreateBus(string busName, bool errorOnExisting = true, bool isTemporary = false)
		{
			return default(bool);
		}

		[Token(Token = "0x60004E4")]
		[Address(RVA = "0xA0F18C", Offset = "0xA0F18C", VA = "0xA0F18C")]
		public static void DeleteBusByName(string busName)
		{
		}

		[Token(Token = "0x60004E5")]
		[Address(RVA = "0xA2E708", Offset = "0xA2E708", VA = "0xA2E708")]
		public static void DeleteBusByIndex(int busIndex)
		{
		}

		[Token(Token = "0x60004E6")]
		[Address(RVA = "0xA28C30", Offset = "0xA28C30", VA = "0xA28C30")]
		public static float GetBusVolume(MasterAudioGroup maGroup)
		{
			return default(float);
		}

		[Token(Token = "0x60004E7")]
		[Address(RVA = "0xA1B1C8", Offset = "0xA1B1C8", VA = "0xA1B1C8")]
		public static void FadeBusToVolume(string busName, float newVolume, float fadeTime, [Optional] Action completionCallback, bool willStopAfterFade = false, bool willResetVolumeAfterFade = false)
		{
		}

		[Token(Token = "0x60004E8")]
		[Address(RVA = "0xA1B55C", Offset = "0xA1B55C", VA = "0xA1B55C")]
		public static void GlideBusByPitch(string busName, float pitchAddition, float glideTime, [Optional] Action completionCallback)
		{
		}

		[Token(Token = "0x60004E9")]
		[Address(RVA = "0xA2415C", Offset = "0xA2415C", VA = "0xA2415C")]
		public static void SetBusVolumeByName(string busName, float newVolume)
		{
		}

		[Token(Token = "0x60004EA")]
		[Address(RVA = "0xA2E9C4", Offset = "0xA2E9C4", VA = "0xA2E9C4")]
		private static void RecalculateGroupVolumes(AudioGroupInfo aGroup, GroupBus bus)
		{
		}

		[Token(Token = "0x60004EB")]
		[Address(RVA = "0xA2BC6C", Offset = "0xA2BC6C", VA = "0xA2BC6C")]
		private static void SetBusVolume(GroupBus bus, float newVolume)
		{
		}

		[Token(Token = "0x60004EC")]
		[Address(RVA = "0xA0FD3C", Offset = "0xA0FD3C", VA = "0xA0FD3C")]
		public static GroupBus GrabBusByName(string busName)
		{
			return null;
		}

		[Token(Token = "0x60004ED")]
		[Address(RVA = "0xA0ABAC", Offset = "0xA0ABAC", VA = "0xA0ABAC")]
		public static void PauseBusOfTransform(Transform sourceTrans, string busName)
		{
		}

		[Token(Token = "0x60004EE")]
		[Address(RVA = "0xA0B6E4", Offset = "0xA0B6E4", VA = "0xA0B6E4")]
		public static void UnpauseBusOfTransform(Transform sourceTrans, string busName)
		{
		}

		[Token(Token = "0x60004EF")]
		[Address(RVA = "0xA0B204", Offset = "0xA0B204", VA = "0xA0B204")]
		public static void StopBusOfTransform(Transform sourceTrans, string busName)
		{
		}

		[Token(Token = "0x60004F0")]
		[Address(RVA = "0xA110B8", Offset = "0xA110B8", VA = "0xA110B8")]
		public static void AddSoundGroupToDuckList(string sType, float riseVolumeStart, float duckedVolCut, float unduckTime, bool isTemporary = false)
		{
		}

		[Token(Token = "0x60004F1")]
		[Address(RVA = "0xA0F22C", Offset = "0xA0F22C", VA = "0xA0F22C")]
		public static void RemoveSoundGroupFromDuckList(string sType)
		{
		}

		[Token(Token = "0x60004F2")]
		[Address(RVA = "0xA2EB7C", Offset = "0xA2EB7C", VA = "0xA2EB7C")]
		public static Playlist GrabPlaylist(string playlistName, bool logErrorIfNotFound = true)
		{
			return null;
		}

		[Token(Token = "0x60004F3")]
		[Address(RVA = "0xA2ED60", Offset = "0xA2ED60", VA = "0xA2ED60")]
		public static void ChangePlaylistPitch(string playlistName, float pitch, [Optional] string songName)
		{
		}

		[Token(Token = "0x60004F4")]
		[Address(RVA = "0xA2EE7C", Offset = "0xA2EE7C", VA = "0xA2EE7C")]
		public static void MutePlaylist()
		{
		}

		[Token(Token = "0x60004F5")]
		[Address(RVA = "0xA17AD8", Offset = "0xA17AD8", VA = "0xA17AD8")]
		public static void MutePlaylist(string playlistControllerName)
		{
		}

		[Token(Token = "0x60004F6")]
		[Address(RVA = "0xA17A68", Offset = "0xA17A68", VA = "0xA17A68")]
		public static void MuteAllPlaylists()
		{
		}

		[Token(Token = "0x60004F7")]
		[Address(RVA = "0xA2EFA8", Offset = "0xA2EFA8", VA = "0xA2EFA8")]
		private static void MutePlaylists(List<PlaylistController> playlists)
		{
		}

		[Token(Token = "0x60004F8")]
		[Address(RVA = "0xA2F15C", Offset = "0xA2F15C", VA = "0xA2F15C")]
		public static void UnmutePlaylist()
		{
		}

		[Token(Token = "0x60004F9")]
		[Address(RVA = "0xA17CEC", Offset = "0xA17CEC", VA = "0xA17CEC")]
		public static void UnmutePlaylist(string playlistControllerName)
		{
		}

		[Token(Token = "0x60004FA")]
		[Address(RVA = "0xA17C7C", Offset = "0xA17C7C", VA = "0xA17C7C")]
		public static void UnmuteAllPlaylists()
		{
		}

		[Token(Token = "0x60004FB")]
		[Address(RVA = "0xA2F1C4", Offset = "0xA2F1C4", VA = "0xA2F1C4")]
		private static void UnmutePlaylists(List<PlaylistController> playlists)
		{
		}

		[Token(Token = "0x60004FC")]
		[Address(RVA = "0xA2F298", Offset = "0xA2F298", VA = "0xA2F298")]
		public static void ToggleMutePlaylist()
		{
		}

		[Token(Token = "0x60004FD")]
		[Address(RVA = "0xA17F00", Offset = "0xA17F00", VA = "0xA17F00")]
		public static void ToggleMutePlaylist(string playlistControllerName)
		{
		}

		[Token(Token = "0x60004FE")]
		[Address(RVA = "0xA17E90", Offset = "0xA17E90", VA = "0xA17E90")]
		public static void ToggleMuteAllPlaylists()
		{
		}

		[Token(Token = "0x60004FF")]
		[Address(RVA = "0xA2F300", Offset = "0xA2F300", VA = "0xA2F300")]
		private static void ToggleMutePlaylists(List<PlaylistController> playlists)
		{
		}

		[Token(Token = "0x6000500")]
		[Address(RVA = "0xA2F390", Offset = "0xA2F390", VA = "0xA2F390")]
		public static void PausePlaylist()
		{
		}

		[Token(Token = "0x6000501")]
		[Address(RVA = "0xA18824", Offset = "0xA18824", VA = "0xA18824")]
		public static void PausePlaylist(string playlistControllerName)
		{
		}

		[Token(Token = "0x6000502")]
		[Address(RVA = "0xA187B4", Offset = "0xA187B4", VA = "0xA187B4")]
		public static void PauseAllPlaylists()
		{
		}

		[Token(Token = "0x6000503")]
		[Address(RVA = "0xA2F3F8", Offset = "0xA2F3F8", VA = "0xA2F3F8")]
		private static void PausePlaylists(List<PlaylistController> playlists)
		{
		}

		[Token(Token = "0x6000504")]
		[Address(RVA = "0xA2F488", Offset = "0xA2F488", VA = "0xA2F488")]
		public static void UnpausePlaylist()
		{
		}

		[Token(Token = "0x6000505")]
		[Address(RVA = "0xA18C4C", Offset = "0xA18C4C", VA = "0xA18C4C")]
		public static void UnpausePlaylist(string playlistControllerName)
		{
		}

		[Token(Token = "0x6000506")]
		[Address(RVA = "0xA18BDC", Offset = "0xA18BDC", VA = "0xA18BDC")]
		public static void UnpauseAllPlaylists()
		{
		}

		[Token(Token = "0x6000507")]
		[Address(RVA = "0xA2F4F0", Offset = "0xA2F4F0", VA = "0xA2F4F0")]
		private static void UnpausePlaylists(List<PlaylistController> controllers)
		{
		}

		[Token(Token = "0x6000508")]
		[Address(RVA = "0xA2F580", Offset = "0xA2F580", VA = "0xA2F580")]
		public static void StopPlaylist()
		{
		}

		[Token(Token = "0x6000509")]
		[Address(RVA = "0xA18A38", Offset = "0xA18A38", VA = "0xA18A38")]
		public static void StopPlaylist(string playlistControllerName)
		{
		}

		[Token(Token = "0x600050A")]
		[Address(RVA = "0xA189C8", Offset = "0xA189C8", VA = "0xA189C8")]
		public static void StopAllPlaylists()
		{
		}

		[Token(Token = "0x600050B")]
		[Address(RVA = "0xA2F5E8", Offset = "0xA2F5E8", VA = "0xA2F5E8")]
		private static void StopPlaylists(List<PlaylistController> playlists)
		{
		}

		[Token(Token = "0x600050C")]
		[Address(RVA = "0xA2F67C", Offset = "0xA2F67C", VA = "0xA2F67C")]
		public static void TriggerNextPlaylistClip()
		{
		}

		[Token(Token = "0x600050D")]
		[Address(RVA = "0xA18610", Offset = "0xA18610", VA = "0xA18610")]
		public static void TriggerNextPlaylistClip(string playlistControllerName)
		{
		}

		[Token(Token = "0x600050E")]
		[Address(RVA = "0xA185A0", Offset = "0xA185A0", VA = "0xA185A0")]
		public static void TriggerNextClipAllPlaylists()
		{
		}

		[Token(Token = "0x600050F")]
		[Address(RVA = "0xA2F6E4", Offset = "0xA2F6E4", VA = "0xA2F6E4")]
		private static void NextPlaylistClips(List<PlaylistController> playlists)
		{
		}

		[Token(Token = "0x6000510")]
		[Address(RVA = "0xA2F774", Offset = "0xA2F774", VA = "0xA2F774")]
		public static void TriggerRandomPlaylistClip()
		{
		}

		[Token(Token = "0x6000511")]
		[Address(RVA = "0xA183FC", Offset = "0xA183FC", VA = "0xA183FC")]
		public static void TriggerRandomPlaylistClip(string playlistControllerName)
		{
		}

		[Token(Token = "0x6000512")]
		[Address(RVA = "0xA1838C", Offset = "0xA1838C", VA = "0xA1838C")]
		public static void TriggerRandomClipAllPlaylists()
		{
		}

		[Token(Token = "0x6000513")]
		[Address(RVA = "0xA2F7DC", Offset = "0xA2F7DC", VA = "0xA2F7DC")]
		private static void RandomPlaylistClips(List<PlaylistController> playlists)
		{
		}

		[Token(Token = "0x6000514")]
		[Address(RVA = "0xA2F86C", Offset = "0xA2F86C", VA = "0xA2F86C")]
		public static void RestartPlaylist()
		{
		}

		[Token(Token = "0x6000515")]
		[Address(RVA = "0xA16EE4", Offset = "0xA16EE4", VA = "0xA16EE4")]
		public static void RestartPlaylist(string playlistControllerName)
		{
		}

		[Token(Token = "0x6000516")]
		[Address(RVA = "0xA16E74", Offset = "0xA16E74", VA = "0xA16E74")]
		public static void RestartAllPlaylists()
		{
		}

		[Token(Token = "0x6000517")]
		[Address(RVA = "0xA2F8D4", Offset = "0xA2F8D4", VA = "0xA2F8D4")]
		private static void RestartPlaylists(List<PlaylistController> playlists)
		{
		}

		[Token(Token = "0x6000518")]
		[Address(RVA = "0xA2F964", Offset = "0xA2F964", VA = "0xA2F964")]
		public static void StartPlaylist(string playlistName)
		{
		}

		[Token(Token = "0x6000519")]
		[Address(RVA = "0xA17098", Offset = "0xA17098", VA = "0xA17098")]
		public static void StartPlaylist(string playlistControllerName, string playlistName)
		{
		}

		[Token(Token = "0x600051A")]
		[Address(RVA = "0xA173D8", Offset = "0xA173D8", VA = "0xA173D8")]
		public static void StopLoopingAllCurrentSongs()
		{
		}

		[Token(Token = "0x600051B")]
		[Address(RVA = "0xA2FA64", Offset = "0xA2FA64", VA = "0xA2FA64")]
		public static void StopLoopingCurrentSong()
		{
		}

		[Token(Token = "0x600051C")]
		[Address(RVA = "0xA17448", Offset = "0xA17448", VA = "0xA17448")]
		public static void StopLoopingCurrentSong(string playlistControllerName)
		{
		}

		[Token(Token = "0x600051D")]
		[Address(RVA = "0xA2F9D4", Offset = "0xA2F9D4", VA = "0xA2F9D4")]
		private static void StopLoopingCurrentSongs(List<PlaylistController> playlistControllers)
		{
		}

		[Token(Token = "0x600051E")]
		[Address(RVA = "0xA175FC", Offset = "0xA175FC", VA = "0xA175FC")]
		public static void StopAllPlaylistsAfterCurrentSongs()
		{
		}

		[Token(Token = "0x600051F")]
		[Address(RVA = "0xA2FB5C", Offset = "0xA2FB5C", VA = "0xA2FB5C")]
		public static void StopPlaylistAfterCurrentSong()
		{
		}

		[Token(Token = "0x6000520")]
		[Address(RVA = "0xA1766C", Offset = "0xA1766C", VA = "0xA1766C")]
		public static void StopPlaylistAfterCurrentSong(string playlistControllerName)
		{
		}

		[Token(Token = "0x6000521")]
		[Address(RVA = "0xA2FACC", Offset = "0xA2FACC", VA = "0xA2FACC")]
		private static void StopPlaylistAfterCurrentSongs(List<PlaylistController> playlistControllers)
		{
		}

		[Token(Token = "0x6000522")]
		[Address(RVA = "0xA2FBC4", Offset = "0xA2FBC4", VA = "0xA2FBC4")]
		public static void QueuePlaylistClip(string clipName)
		{
		}

		[Token(Token = "0x6000523")]
		[Address(RVA = "0xA18218", Offset = "0xA18218", VA = "0xA18218")]
		public static void QueuePlaylistClip(string playlistControllerName, string clipName)
		{
		}

		[Token(Token = "0x6000524")]
		[Address(RVA = "0xA2FC34", Offset = "0xA2FC34", VA = "0xA2FC34")]
		public static bool TriggerPlaylistClip(string clipName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000525")]
		[Address(RVA = "0xA180A4", Offset = "0xA180A4", VA = "0xA180A4")]
		public static bool TriggerPlaylistClip(string playlistControllerName, string clipName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000526")]
		[Address(RVA = "0xA2FCA4", Offset = "0xA2FCA4", VA = "0xA2FCA4")]
		public static void ChangePlaylistByName(string playlistName, bool playFirstClip = true)
		{
		}

		[Token(Token = "0x6000527")]
		[Address(RVA = "0xA17260", Offset = "0xA17260", VA = "0xA17260")]
		public static void ChangePlaylistByName(string playlistControllerName, string playlistName, bool playFirstClip = true)
		{
		}

		[Token(Token = "0x6000528")]
		[Address(RVA = "0xA2FD24", Offset = "0xA2FD24", VA = "0xA2FD24")]
		public static void FadePlaylistToVolume(float targetVolume, float fadeTime)
		{
		}

		[Token(Token = "0x6000529")]
		[Address(RVA = "0xA178A8", Offset = "0xA178A8", VA = "0xA178A8")]
		public static void FadePlaylistToVolume(string playlistControllerName, float targetVolume, float fadeTime)
		{
		}

		[Token(Token = "0x600052A")]
		[Address(RVA = "0xA17820", Offset = "0xA17820", VA = "0xA17820")]
		public static void FadeAllPlaylistsToVolume(float targetVolume, float fadeTime)
		{
		}

		[Token(Token = "0x600052B")]
		[Address(RVA = "0xA2FDA4", Offset = "0xA2FDA4", VA = "0xA2FDA4")]
		private static void FadePlaylists(List<PlaylistController> playlists, float targetVolume, float fadeTime)
		{
		}

		[Token(Token = "0x600052C")]
		[Address(RVA = "0xA116D0", Offset = "0xA116D0", VA = "0xA116D0")]
		public static void CreatePlaylist(Playlist playlist, bool errorOnDuplicate)
		{
		}

		[Token(Token = "0x600052D")]
		[Address(RVA = "0xA0F89C", Offset = "0xA0F89C", VA = "0xA0F89C")]
		public static void DeletePlaylist(string playlistName)
		{
		}

		[Token(Token = "0x600052E")]
		[Address(RVA = "0xA2FEE4", Offset = "0xA2FEE4", VA = "0xA2FEE4")]
		public static void AddSongToPlaylist(string playlistName, AudioClip song, bool loopSong = false, float songPitch = 1f, float songVolume = 1f)
		{
		}

		[Token(Token = "0x6000531")]
		[Address(RVA = "0xA3004C", Offset = "0xA3004C", VA = "0xA3004C")]
		public static void ReDownloadAllInternetFiles()
		{
		}

		[Token(Token = "0x6000532")]
		[Address(RVA = "0xA11870", Offset = "0xA11870", VA = "0xA11870")]
		public static void FireCustomEventNextFrame(string customEventName, Transform eventOrigin)
		{
		}

		[Token(Token = "0x6000533")]
		[Address(RVA = "0xA1E524", Offset = "0xA1E524", VA = "0xA1E524")]
		public static void AddCustomEventReceiver(ICustomEventReceiver receiver, Transform receiverTrans)
		{
		}

		[Token(Token = "0x6000534")]
		[Address(RVA = "0xA1E948", Offset = "0xA1E948", VA = "0xA1E948")]
		public static void RemoveCustomEventReceiver(ICustomEventReceiver receiver)
		{
		}

		[Token(Token = "0x6000535")]
		[Address(RVA = "0xA30460", Offset = "0xA30460", VA = "0xA30460")]
		public static List<Transform> ReceiversForEvent(string customEventName)
		{
			return null;
		}

		[Token(Token = "0x6000536")]
		[Address(RVA = "0xA111F0", Offset = "0xA111F0", VA = "0xA111F0")]
		public static CustomEventCategory CreateCustomEventCategoryIfNotThere(string categoryName, bool isTemporary)
		{
			return null;
		}

		[Token(Token = "0x6000537")]
		[Address(RVA = "0xA113D4", Offset = "0xA113D4", VA = "0xA113D4")]
		public static void CreateCustomEvent(string customEventName, CustomEventReceiveMode eventReceiveMode, float distanceThreshold, EventReceiveFilter receiveFilter, int filterModeQty, string categoryName = "", bool isTemporary = false, bool errorOnDuplicate = true)
		{
		}

		[Token(Token = "0x6000538")]
		[Address(RVA = "0xA0F6E4", Offset = "0xA0F6E4", VA = "0xA0F6E4")]
		public static void DeleteCustomEvent(string customEventName)
		{
		}

		[Token(Token = "0x6000539")]
		[Address(RVA = "0xA306EC", Offset = "0xA306EC", VA = "0xA306EC")]
		public static CustomEvent GetCustomEventByName(string customEventName)
		{
			return null;
		}

		[Token(Token = "0x600053A")]
		[Address(RVA = "0xA1C850", Offset = "0xA1C850", VA = "0xA1C850")]
		public static void FireCustomEvent(string customEventName, Transform originObject, bool logDupe = true)
		{
		}

		[Token(Token = "0x600053B")]
		[Address(RVA = "0xA1E21C", Offset = "0xA1E21C", VA = "0xA1E21C")]
		public static bool CustomEventExists(string customEventName)
		{
			return default(bool);
		}

		[Token(Token = "0x600053C")]
		[Address(RVA = "0xA307F8", Offset = "0xA307F8", VA = "0xA307F8")]
		private static List<ICustomEventReceiver> GetChildReceivers(Transform origin, string eventName, bool includeSelf)
		{
			return null;
		}

		[Token(Token = "0x600053D")]
		[Address(RVA = "0xA3093C", Offset = "0xA3093C", VA = "0xA3093C")]
		private static List<ICustomEventReceiver> GetParentReceivers(Transform origin, string eventName, bool includeSelf)
		{
			return null;
		}

		[Token(Token = "0x600053E")]
		[Address(RVA = "0xA30A80", Offset = "0xA30A80", VA = "0xA30A80")]
		private static List<ICustomEventReceiver> FilterOutSelf(List<ICustomEventReceiver> sourceList, Transform origin)
		{
			return null;
		}

		[Token(Token = "0x600053F")]
		[Address(RVA = "0xA27DE8", Offset = "0xA27DE8", VA = "0xA27DE8")]
		private static bool LoggingEnabledForGroup(MasterAudioGroup grp)
		{
			return default(bool);
		}

		[Token(Token = "0x6000540")]
		[Address(RVA = "0xA27EF8", Offset = "0xA27EF8", VA = "0xA27EF8")]
		private static void LogMessage(string message)
		{
		}

		[Token(Token = "0x6000545")]
		[Address(RVA = "0xA04178", Offset = "0xA04178", VA = "0xA04178")]
		public static void LogWarning(string msg)
		{
		}

		[Token(Token = "0x6000546")]
		[Address(RVA = "0xA07C2C", Offset = "0xA07C2C", VA = "0xA07C2C")]
		public static void LogError(string msg)
		{
		}

		[Token(Token = "0x6000547")]
		[Address(RVA = "0xA30E68", Offset = "0xA30E68", VA = "0xA30E68")]
		public static void LogNoPlaylist(string playlistControllerName, string methodName)
		{
		}

		[Token(Token = "0x6000548")]
		[Address(RVA = "0xA2EEE4", Offset = "0xA2EEE4", VA = "0xA2EEE4")]
		private static bool IsOkToCallOnlyPlaylistMethod(List<PlaylistController> pcs, string methodName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000549")]
		[Address(RVA = "0xA3100C", Offset = "0xA3100C", VA = "0xA3100C")]
		public static void QueueTransformFollowerForColliderPositionRecalc(TransformFollower follower)
		{
		}

		[Token(Token = "0x600054A")]
		[Address(RVA = "0xA31218", Offset = "0xA31218", VA = "0xA31218")]
		public static void AddToQueuedOcclusionRays(SoundGroupVariationUpdater updater)
		{
		}

		[Token(Token = "0x600054B")]
		[Address(RVA = "0xA31424", Offset = "0xA31424", VA = "0xA31424")]
		public static void AddToOcclusionInRangeSources(GameObject src)
		{
		}

		[Token(Token = "0x600054C")]
		[Address(RVA = "0xA31600", Offset = "0xA31600", VA = "0xA31600")]
		public static void AddToOcclusionOutOfRangeSources(GameObject src)
		{
		}

		[Token(Token = "0x600054D")]
		[Address(RVA = "0xA31964", Offset = "0xA31964", VA = "0xA31964")]
		public static void AddToBlockedOcclusionSources(GameObject src)
		{
		}

		[Token(Token = "0x600054E")]
		[Address(RVA = "0xA31ACC", Offset = "0xA31ACC", VA = "0xA31ACC")]
		public static bool HasQueuedOcclusionRays()
		{
			return default(bool);
		}

		[Token(Token = "0x600054F")]
		[Address(RVA = "0xA31B48", Offset = "0xA31B48", VA = "0xA31B48")]
		public static SoundGroupVariationUpdater OldestQueuedOcclusionRay()
		{
			return null;
		}

		[Token(Token = "0x6000550")]
		[Address(RVA = "0xA2B75C", Offset = "0xA2B75C", VA = "0xA2B75C")]
		public static bool IsOcclusionFreqencyTransitioning(SoundGroupVariation variation)
		{
			return default(bool);
		}

		[Token(Token = "0x6000551")]
		[Address(RVA = "0xA2A41C", Offset = "0xA2A41C", VA = "0xA2A41C")]
		public static void RemoveFromOcclusionFrequencyTransitioning(SoundGroupVariation variation)
		{
		}

		[Token(Token = "0x6000552")]
		[Address(RVA = "0xA317FC", Offset = "0xA317FC", VA = "0xA317FC")]
		public static void RemoveFromBlockedOcclusionSources(GameObject src)
		{
		}

		[Token(Token = "0x6000553")]
		[Address(RVA = "0xA31C28", Offset = "0xA31C28", VA = "0xA31C28")]
		public static void StopTrackingOcclusionForSource(GameObject src)
		{
		}

		[Token(Token = "0x6000554")]
		[Address(RVA = "0xA29090", Offset = "0xA29090", VA = "0xA29090")]
		private static bool IsLinkedGroupPlay(SoundGroupVariation variation)
		{
			return default(bool);
		}

		[Token(Token = "0x6000556")]
		[Address(RVA = "0xA31EE4", Offset = "0xA31EE4", VA = "0xA31EE4")]
		public static int RemainingClipsInGroup(string sType)
		{
			return default(int);
		}

		[Token(Token = "0x600057C")]
		[Address(RVA = "0xA32D74", Offset = "0xA32D74", VA = "0xA32D74")]
		public static bool HasAsyncResourceLoaderFeature()
		{
			return default(bool);
		}

		[Token(Token = "0x600057D")]
		[Address(RVA = "0xA2CA7C", Offset = "0xA2CA7C", VA = "0xA2CA7C")]
		public static void RescanGroupsNow()
		{
		}

		[Token(Token = "0x600057E")]
		[Address(RVA = "0xA32D7C", Offset = "0xA32D7C", VA = "0xA32D7C")]
		public static void DoneRescanningGroups()
		{
		}

		[Token(Token = "0x6000582")]
		[Address(RVA = "0xA32F90", Offset = "0xA32F90", VA = "0xA32F90")]
		public static GameObject CreateMasterAudio()
		{
			return null;
		}

		[Token(Token = "0x6000583")]
		[Address(RVA = "0xA330FC", Offset = "0xA330FC", VA = "0xA330FC")]
		public static GameObject CreatePlaylistController()
		{
			return null;
		}

		[Token(Token = "0x6000584")]
		[Address(RVA = "0xA33268", Offset = "0xA33268", VA = "0xA33268")]
		public static GameObject CreateDynamicSoundGroupCreator()
		{
			return null;
		}

		[Token(Token = "0x6000585")]
		[Address(RVA = "0xA333D4", Offset = "0xA333D4", VA = "0xA333D4")]
		public static GameObject CreateSoundGroupOrganizer()
		{
			return null;
		}

		[Token(Token = "0x6000586")]
		[Address(RVA = "0xA33540", Offset = "0xA33540", VA = "0xA33540")]
		public MasterAudio()
		{
		}
	}
	[Token(Token = "0x20000B6")]
	public static class PersistentAudioSettings
	{
		[Token(Token = "0x40005F5")]
		public const string SfxVolKey = "MA_sfxVolume";

		[Token(Token = "0x40005F6")]
		public const string MusicVolKey = "MA_musicVolume";

		[Token(Token = "0x40005F7")]
		public const string SfxMuteKey = "MA_sfxMute";

		[Token(Token = "0x40005F8")]
		public const string MusicMuteKey = "MA_musicMute";

		[Token(Token = "0x40005F9")]
		public const string BusVolKey = "MA_BusVolume_";

		[Token(Token = "0x40005FA")]
		public const string GroupVolKey = "MA_GroupVolume_";

		[Token(Token = "0x40005FB")]
		public const string BusKeysKey = "MA_BusKeys";

		[Token(Token = "0x40005FC")]
		public const string GroupKeysKey = "MA_GroupsKeys";

		[Token(Token = "0x40005FD")]
		public const string Separator = ";";

		[Token(Token = "0x17000141")]
		public static string BusesUpdatedKeys
		{
			[Token(Token = "0x6000589")]
			[Address(RVA = "0xFEC4E0", Offset = "0xFEC4E0", VA = "0xFEC4E0")]
			get
			{
				return null;
			}
			[Token(Token = "0x600058A")]
			[Address(RVA = "0xFEC554", Offset = "0xFEC554", VA = "0xFEC554")]
			set
			{
			}
		}

		[Token(Token = "0x17000142")]
		public static string GroupsUpdatedKeys
		{
			[Token(Token = "0x600058E")]
			[Address(RVA = "0xFEC690", Offset = "0xFEC690", VA = "0xFEC690")]
			get
			{
				return null;
			}
			[Token(Token = "0x600058F")]
			[Address(RVA = "0xFEC704", Offset = "0xFEC704", VA = "0xFEC704")]
			set
			{
			}
		}

		[Token(Token = "0x17000143")]
		public static bool? MixerMuted
		{
			[Token(Token = "0x6000592")]
			[Address(RVA = "0xFEC9A4", Offset = "0xFEC9A4", VA = "0xFEC9A4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000593")]
			[Address(RVA = "0xFECA34", Offset = "0xFECA34", VA = "0xFECA34")]
			set
			{
			}
		}

		[Token(Token = "0x17000144")]
		public static float? MixerVolume
		{
			[Token(Token = "0x6000594")]
			[Address(RVA = "0xFECB68", Offset = "0xFECB68", VA = "0xFECB68")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000595")]
			[Address(RVA = "0xFECBF0", Offset = "0xFECBF0", VA = "0xFECBF0")]
			set
			{
			}
		}

		[Token(Token = "0x17000145")]
		public static bool? MusicMuted
		{
			[Token(Token = "0x6000596")]
			[Address(RVA = "0xFECD18", Offset = "0xFECD18", VA = "0xFECD18")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000597")]
			[Address(RVA = "0xFECDA8", Offset = "0xFECDA8", VA = "0xFECDA8")]
			set
			{
			}
		}

		[Token(Token = "0x17000146")]
		public static float? MusicVolume
		{
			[Token(Token = "0x6000598")]
			[Address(RVA = "0xFECEDC", Offset = "0xFECEDC", VA = "0xFECEDC")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000599")]
			[Address(RVA = "0xFECF64", Offset = "0xFECF64", VA = "0xFECF64")]
			set
			{
			}
		}

		[Token(Token = "0x6000588")]
		[Address(RVA = "0xFEC308", Offset = "0xFEC308", VA = "0xFEC308")]
		public static void SetBusVolume(string busName, float vol)
		{
		}

		[Token(Token = "0x600058B")]
		[Address(RVA = "0xFEC48C", Offset = "0xFEC48C", VA = "0xFEC48C")]
		public static string MakeBusKey(string busName)
		{
			return null;
		}

		[Token(Token = "0x600058C")]
		[Address(RVA = "0xFEC5A8", Offset = "0xFEC5A8", VA = "0xFEC5A8")]
		public static float? GetBusVolume(string busName)
		{
			return null;
		}

		[Token(Token = "0x600058D")]
		[Address(RVA = "0xFEC63C", Offset = "0xFEC63C", VA = "0xFEC63C")]
		public static string GetGroupKey(string groupName)
		{
			return null;
		}

		[Token(Token = "0x6000590")]
		[Address(RVA = "0xFEC758", Offset = "0xFEC758", VA = "0xFEC758")]
		public static void SetGroupVolume(string grpName, float vol)
		{
		}

		[Token(Token = "0x6000591")]
		[Address(RVA = "0xFEC910", Offset = "0xFEC910", VA = "0xFEC910")]
		public static float? GetGroupVolume(string grpName)
		{
			return null;
		}

		[Token(Token = "0x600059A")]
		[Address(RVA = "0xFED08C", Offset = "0xFED08C", VA = "0xFED08C")]
		public static void RestoreMasterSettings()
		{
		}
	}
	[Token(Token = "0x20000B7")]
	public class SoundGroupOrganizer : MonoBehaviour
	{
		[Token(Token = "0x200013B")]
		public class CustomEventSelection
		{
			[Token(Token = "0x40008A6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public CustomEvent Event;

			[Token(Token = "0x40008A7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public bool IsSelected;

			[Token(Token = "0x6000771")]
			[Address(RVA = "0xFF4ED8", Offset = "0xFF4ED8", VA = "0xFF4ED8")]
			public CustomEventSelection(CustomEvent cEvent, bool isSelected)
			{
			}
		}

		[Token(Token = "0x200013C")]
		public class SoundGroupSelection
		{
			[Token(Token = "0x40008A8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public GameObject Go;

			[Token(Token = "0x40008A9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public bool IsSelected;

			[Token(Token = "0x6000772")]
			[Address(RVA = "0xFF4F18", Offset = "0xFF4F18", VA = "0xFF4F18")]
			public SoundGroupSelection(GameObject go, bool isSelected)
			{
			}
		}

		[Token(Token = "0x200013D")]
		public enum MAItemType
		{
			[Token(Token = "0x40008AB")]
			SoundGroups,
			[Token(Token = "0x40008AC")]
			CustomEvents
		}

		[Token(Token = "0x200013E")]
		public enum TransferMode
		{
			[Token(Token = "0x40008AE")]
			None,
			[Token(Token = "0x40008AF")]
			Import,
			[Token(Token = "0x40008B0")]
			Export
		}

		[Token(Token = "0x40005FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject dynGroupTemplate;

		[Token(Token = "0x40005FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public GameObject dynVariationTemplate;

		[Token(Token = "0x4000600")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public GameObject maGroupTemplate;

		[Token(Token = "0x4000601")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public GameObject maVariationTemplate;

		[Token(Token = "0x4000602")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public MasterAudio.DragGroupMode curDragGroupMode;

		[Token(Token = "0x4000603")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public MasterAudio.AudioLocation bulkVariationMode;

		[Token(Token = "0x4000604")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public SystemLanguage previewLanguage;

		[Token(Token = "0x4000605")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public bool useTextGroupFilter;

		[Token(Token = "0x4000606")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public string textGroupFilter;

		[Token(Token = "0x4000607")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public TransferMode transMode;

		[Token(Token = "0x4000608")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public GameObject sourceObject;

		[Token(Token = "0x4000609")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public List<SoundGroupSelection> selectedSourceSoundGroups;

		[Token(Token = "0x400060A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public GameObject destObject;

		[Token(Token = "0x400060B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public List<SoundGroupSelection> selectedDestSoundGroups;

		[Token(Token = "0x400060C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public MAItemType itemType;

		[Token(Token = "0x400060D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public List<CustomEventSelection> selectedSourceCustomEvents;

		[Token(Token = "0x400060E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public List<CustomEventSelection> selectedDestCustomEvents;

		[Token(Token = "0x400060F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public List<CustomEvent> customEvents;

		[Token(Token = "0x4000610")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public List<CustomEventCategory> customEventCategories;

		[Token(Token = "0x4000611")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public string newEventName;

		[Token(Token = "0x4000612")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public string newCustomEventCategoryName;

		[Token(Token = "0x4000613")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public string addToCustomEventCategoryName;

		[Token(Token = "0x600059B")]
		[Address(RVA = "0xFF4CD0", Offset = "0xFF4CD0", VA = "0xFF4CD0")]
		private void Awake()
		{
		}

		[Token(Token = "0x600059C")]
		[Address(RVA = "0xFF4D3C", Offset = "0xFF4D3C", VA = "0xFF4D3C")]
		public SoundGroupOrganizer()
		{
		}
	}
	[Token(Token = "0x20000B8")]
	public static class AmbientUtil
	{
		[Token(Token = "0x4000614")]
		public const string FollowerHolderName = "_Followers";

		[Token(Token = "0x4000615")]
		public const string ListenerFollowerName = "~ListenerFollower~";

		[Token(Token = "0x4000616")]
		public const float ListenerFollowerTrigRadius = 0.01f;

		[Token(Token = "0x4000617")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static Transform _followerHolder;

		[Token(Token = "0x4000618")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static ListenerFollower _listenerFollower;

		[Token(Token = "0x4000619")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static Rigidbody _listenerFollowerRB;

		[Token(Token = "0x400061A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static List<TransformFollower> _transformFollowers;

		[Token(Token = "0x17000147")]
		public static ListenerFollower ListenerFollower
		{
			[Token(Token = "0x60005A1")]
			[Address(RVA = "0xA04E00", Offset = "0xA04E00", VA = "0xA04E00")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000148")]
		public static Transform FollowerHolder
		{
			[Token(Token = "0x60005A2")]
			[Address(RVA = "0xA047C8", Offset = "0xA047C8", VA = "0xA047C8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000149")]
		public static bool HasListenerFollower
		{
			[Token(Token = "0x60005A5")]
			[Address(RVA = "0xA05754", Offset = "0xA05754", VA = "0xA05754")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700014A")]
		public static bool HasListenerFolowerRigidBody
		{
			[Token(Token = "0x60005A6")]
			[Address(RVA = "0xA040E0", Offset = "0xA040E0", VA = "0xA040E0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600059D")]
		[Address(RVA = "0xA0471C", Offset = "0xA0471C", VA = "0xA0471C")]
		public static void InitFollowerHolder()
		{
		}

		[Token(Token = "0x600059E")]
		[Address(RVA = "0xA03FB4", Offset = "0xA03FB4", VA = "0xA03FB4")]
		public static bool InitListenerFollower()
		{
			return default(bool);
		}

		[Token(Token = "0x600059F")]
		[Address(RVA = "0xA051F8", Offset = "0xA051F8", VA = "0xA051F8")]
		public static void RemoveTransformFollower(TransformFollower follower)
		{
		}

		[Token(Token = "0x60005A0")]
		[Address(RVA = "0xA04220", Offset = "0xA04220", VA = "0xA04220")]
		public static Transform InitAudioSourceFollower(Transform transToFollow, string followerName, string soundGroupName, string variationName, bool willFollowSource, bool willPositionOnClosestColliderPoint, bool useTopCollider, bool useChildColliders, MasterAudio.AmbientSoundExitMode exitMode, float exitFadeTime)
		{
			return null;
		}

		[Token(Token = "0x60005A3")]
		[Address(RVA = "0xA0557C", Offset = "0xA0557C", VA = "0xA0557C")]
		public static void ManualUpdate()
		{
		}

		[Token(Token = "0x60005A4")]
		[Address(RVA = "0xA05678", Offset = "0xA05678", VA = "0xA05678")]
		private static void UpdateListenerFollower()
		{
		}
	}
	[Token(Token = "0x20000B9")]
	public static class ArrayListUtil
	{
		[Token(Token = "0x60005A8")]
		[Address(RVA = "0xA05860", Offset = "0xA05860", VA = "0xA05860")]
		public static void SortIntArray(ref List<int> list)
		{
		}

		[Token(Token = "0x60005A9")]
		[Address(RVA = "0xA05970", Offset = "0xA05970", VA = "0xA05970")]
		public static bool IsExcludedChildName(string name)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x20000BA")]
	public static class AudioTransformExtensions
	{
		[Token(Token = "0x60005AA")]
		[Address(RVA = "0xA097F8", Offset = "0xA097F8", VA = "0xA097F8")]
		public static void FadeOutSoundGroupOfTransform(this Transform sourceTrans, string sType, float fadeTime)
		{
		}

		[Token(Token = "0x60005AB")]
		[Address(RVA = "0xA0987C", Offset = "0xA0987C", VA = "0xA0987C")]
		public static List<SoundGroupVariation> GetAllPlayingVariationsOfTransform(this Transform sourceTrans)
		{
			return null;
		}

		[Token(Token = "0x60005AC")]
		[Address(RVA = "0xA09B88", Offset = "0xA09B88", VA = "0xA09B88")]
		public static bool PlaySound3DAtTransformAndForget(this Transform sourceTrans, string sType, float volumePercentage = 1f, [Optional] float? pitch, float delaySoundTime = 0f, [Optional] string variationName)
		{
			return default(bool);
		}

		[Token(Token = "0x60005AD")]
		[Address(RVA = "0xA09E18", Offset = "0xA09E18", VA = "0xA09E18")]
		public static PlaySoundResult PlaySound3DAtTransform(this Transform sourceTrans, string sType, float volumePercentage = 1f, [Optional] float? pitch, float delaySoundTime = 0f, [Optional] string variationName)
		{
			return null;
		}

		[Token(Token = "0x60005AE")]
		[Address(RVA = "0xA0A0B8", Offset = "0xA0A0B8", VA = "0xA0A0B8")]
		public static bool PlaySound3DFollowTransformAndForget(this Transform sourceTrans, string sType, float volumePercentage = 1f, [Optional] float? pitch, float delaySoundTime = 0f, [Optional] string variationName)
		{
			return default(bool);
		}

		[Token(Token = "0x60005AF")]
		[Address(RVA = "0xA0A348", Offset = "0xA0A348", VA = "0xA0A348")]
		public static PlaySoundResult PlaySound3DFollowTransform(this Transform sourceTrans, string sType, float volumePercentage = 1f, [Optional] float? pitch, float delaySoundTime = 0f, [Optional] string variationName)
		{
			return null;
		}

		[Token(Token = "0x60005B0")]
		[Address(RVA = "0xA0A5E8", Offset = "0xA0A5E8", VA = "0xA0A5E8")]
		public static IEnumerator PlaySound3DAtTransformAndWaitUntilFinished(this Transform sourceTrans, string sType, float volumePercentage = 1f, [Optional] float? pitch, float delaySoundTime = 0f, [Optional] string variationName, [Optional] double? timeToSchedulePlay, [Optional] Action completedAction)
		{
			return null;
		}

		[Token(Token = "0x60005B1")]
		[Address(RVA = "0xA0A774", Offset = "0xA0A774", VA = "0xA0A774")]
		public static IEnumerator PlaySound3DFollowTransformAndWaitUntilFinished(this Transform sourceTrans, string sType, float volumePercentage = 1f, [Optional] float? pitch, float delaySoundTime = 0f, [Optional] string variationName, [Optional] double? timeToSchedulePlay, [Optional] Action completedAction)
		{
			return null;
		}

		[Token(Token = "0x60005B2")]
		[Address(RVA = "0xA0A900", Offset = "0xA0A900", VA = "0xA0A900")]
		public static void PauseAllSoundsOfTransform(Transform sourceTrans)
		{
		}

		[Token(Token = "0x60005B3")]
		[Address(RVA = "0xA0AB38", Offset = "0xA0AB38", VA = "0xA0AB38")]
		public static void PauseBusOfTransform(this Transform sourceTrans, string busName)
		{
		}

		[Token(Token = "0x60005B4")]
		[Address(RVA = "0xA0AD18", Offset = "0xA0AD18", VA = "0xA0AD18")]
		public static void PauseSoundGroupOfTransform(this Transform sourceTrans, string sType)
		{
		}

		[Token(Token = "0x60005B5")]
		[Address(RVA = "0xA0AF04", Offset = "0xA0AF04", VA = "0xA0AF04")]
		public static void StopAllSoundsOfTransform(this Transform sourceTrans)
		{
		}

		[Token(Token = "0x60005B6")]
		[Address(RVA = "0xA0B190", Offset = "0xA0B190", VA = "0xA0B190")]
		public static void StopBusOfTransform(this Transform sourceTrans, string busName)
		{
		}

		[Token(Token = "0x60005B7")]
		[Address(RVA = "0xA0B3C4", Offset = "0xA0B3C4", VA = "0xA0B3C4")]
		public static void StopSoundGroupOfTransform(this Transform sourceTrans, string sType)
		{
		}

		[Token(Token = "0x60005B8")]
		[Address(RVA = "0xA0B438", Offset = "0xA0B438", VA = "0xA0B438")]
		public static void UnpauseAllSoundsOfTransform(this Transform sourceTrans)
		{
		}

		[Token(Token = "0x60005B9")]
		[Address(RVA = "0xA0B670", Offset = "0xA0B670", VA = "0xA0B670")]
		public static void UnpauseBusOfTransform(this Transform sourceTrans, string busName)
		{
		}

		[Token(Token = "0x60005BA")]
		[Address(RVA = "0xA0B850", Offset = "0xA0B850", VA = "0xA0B850")]
		public static void UnpauseSoundGroupOfTransform(this Transform sourceTrans, string sType)
		{
		}

		[Token(Token = "0x60005BB")]
		[Address(RVA = "0xA0BA3C", Offset = "0xA0BA3C", VA = "0xA0BA3C")]
		public static bool IsTransformPlayingSoundGroup(this Transform sourceTrans, string sType)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x20000BB")]
	public class AudioTransformTracker : MonoBehaviour
	{
		[Token(Token = "0x400061B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int _frames;

		[Token(Token = "0x400061C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Transform _trans;

		[Token(Token = "0x1700014B")]
		public Transform Trans
		{
			[Token(Token = "0x60005BC")]
			[Address(RVA = "0xA0BC70", Offset = "0xA0BC70", VA = "0xA0BC70")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60005BD")]
		[Address(RVA = "0xA0BD00", Offset = "0xA0BD00", VA = "0xA0BD00")]
		private void Update()
		{
		}

		[Token(Token = "0x60005BE")]
		[Address(RVA = "0xA0BD10", Offset = "0xA0BD10", VA = "0xA0BD10")]
		public AudioTransformTracker()
		{
		}
	}
	[Token(Token = "0x20000BC")]
	public static class AudioUtil
	{
		[Token(Token = "0x400061D")]
		public const float DefaultMinOcclusionCutoffFrequency = 22000f;

		[Token(Token = "0x400061E")]
		public const float DefaultMaxOcclusionCutoffFrequency = 0f;

		[Token(Token = "0x400061F")]
		private const float SemitonePitchChangeAmt = 1.0594635f;

		[Token(Token = "0x1700014C")]
		public static float FixedDeltaTime
		{
			[Token(Token = "0x60005C2")]
			[Address(RVA = "0xA0BD90", Offset = "0xA0BD90", VA = "0xA0BD90")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700014D")]
		public static float FrameTime
		{
			[Token(Token = "0x60005C3")]
			[Address(RVA = "0xA0BD98", Offset = "0xA0BD98", VA = "0xA0BD98")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700014E")]
		public static float Time
		{
			[Token(Token = "0x60005C4")]
			[Address(RVA = "0xA0BDA0", Offset = "0xA0BDA0", VA = "0xA0BDA0")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700014F")]
		public static int FrameCount
		{
			[Token(Token = "0x60005C5")]
			[Address(RVA = "0xA0BDA8", Offset = "0xA0BDA8", VA = "0xA0BDA8")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x60005BF")]
		[Address(RVA = "0xA0BD18", Offset = "0xA0BD18", VA = "0xA0BD18")]
		private static float CutoffRange(SoundGroupVariationUpdater updater)
		{
			return default(float);
		}

		[Token(Token = "0x60005C0")]
		[Address(RVA = "0xA0BD60", Offset = "0xA0BD60", VA = "0xA0BD60")]
		private static float MaxCutoffFreq(SoundGroupVariationUpdater updater)
		{
			return default(float);
		}

		[Token(Token = "0x60005C1")]
		[Address(RVA = "0xA0BD78", Offset = "0xA0BD78", VA = "0xA0BD78")]
		public static float MinCutoffFreq(SoundGroupVariationUpdater updater)
		{
			return default(float);
		}

		[Token(Token = "0x60005C6")]
		[Address(RVA = "0xA0BDB0", Offset = "0xA0BDB0", VA = "0xA0BDB0")]
		public static float GetOcclusionCutoffFrequencyByDistanceRatio(float distRatio, SoundGroupVariationUpdater updater)
		{
			return default(float);
		}

		[Token(Token = "0x60005C7")]
		[Address(RVA = "0xA0BDFC", Offset = "0xA0BDFC", VA = "0xA0BDFC")]
		public static float GetSemitonesFromPitch(float pitch)
		{
			return default(float);
		}

		[Token(Token = "0x60005C8")]
		[Address(RVA = "0xA0BEC0", Offset = "0xA0BEC0", VA = "0xA0BEC0")]
		public static float GetPitchFromSemitones(float semitones)
		{
			return default(float);
		}

		[Token(Token = "0x60005C9")]
		[Address(RVA = "0xA0BF74", Offset = "0xA0BF74", VA = "0xA0BF74")]
		public static float GetDbFromFloatVolume(float vol)
		{
			return default(float);
		}

		[Token(Token = "0x60005CA")]
		[Address(RVA = "0xA0BFEC", Offset = "0xA0BFEC", VA = "0xA0BFEC")]
		public static float GetFloatVolumeFromDb(float db)
		{
			return default(float);
		}

		[Token(Token = "0x60005CB")]
		[Address(RVA = "0xA06144", Offset = "0xA06144", VA = "0xA06144")]
		public static float GetAudioPlayedPercentage(AudioSource source)
		{
			return default(float);
		}

		[Token(Token = "0x60005CC")]
		[Address(RVA = "0xA0C060", Offset = "0xA0C060", VA = "0xA0C060")]
		public static bool IsAudioPaused(AudioSource source)
		{
			return default(bool);
		}

		[Token(Token = "0x60005CD")]
		[Address(RVA = "0xA0C0A8", Offset = "0xA0C0A8", VA = "0xA0C0A8")]
		public static void ClipPlayed(AudioClip clip, GameObject actor)
		{
		}

		[Token(Token = "0x60005CE")]
		[Address(RVA = "0xA0C138", Offset = "0xA0C138", VA = "0xA0C138")]
		public static void UnloadNonPreloadedAudioData(AudioClip clip, GameObject actor)
		{
		}

		[Token(Token = "0x60005CF")]
		[Address(RVA = "0xA06FBC", Offset = "0xA06FBC", VA = "0xA06FBC")]
		public static bool AudioClipWillPreload(AudioClip clip)
		{
			return default(bool);
		}

		[Token(Token = "0x60005D0")]
		[Address(RVA = "0xA0C21C", Offset = "0xA0C21C", VA = "0xA0C21C")]
		public static bool IsClipReadyToPlay(this AudioClip clip)
		{
			return default(bool);
		}

		[Token(Token = "0x60005D1")]
		[Address(RVA = "0xA0C2B4", Offset = "0xA0C2B4", VA = "0xA0C2B4")]
		private static float GetPositiveUsablePitch(AudioSource source)
		{
			return default(float);
		}

		[Token(Token = "0x60005D2")]
		[Address(RVA = "0xA0C2E0", Offset = "0xA0C2E0", VA = "0xA0C2E0")]
		private static float GetPositiveUsablePitch(float pitch)
		{
			return default(float);
		}

		[Token(Token = "0x60005D3")]
		[Address(RVA = "0xA0C2F0", Offset = "0xA0C2F0", VA = "0xA0C2F0")]
		public static float AdjustAudioClipDurationForPitch(float duration, AudioSource sourceWithPitch)
		{
			return default(float);
		}

		[Token(Token = "0x60005D4")]
		[Address(RVA = "0xA0C32C", Offset = "0xA0C32C", VA = "0xA0C32C")]
		public static float AdjustAudioClipDurationForPitch(float duration, float pitch)
		{
			return default(float);
		}

		[Token(Token = "0x60005D5")]
		[Address(RVA = "0xA0C340", Offset = "0xA0C340", VA = "0xA0C340")]
		public static float AdjustEndLeadTimeForPitch(float duration, AudioSource sourceWithPitch)
		{
			return default(float);
		}
	}
	[Token(Token = "0x20000BD")]
	public static class CoroutineHelper
	{
		[Token(Token = "0x200013F")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x981874", Offset = "0x981874")]
		private sealed class <WaitForActualSeconds>d__0 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40008B1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40008B2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40008B3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float time;

			[Token(Token = "0x40008B4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			private float <start>5__2;

			[Token(Token = "0x170001A2")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000776")]
				[Address(RVA = "0xA0CF94", Offset = "0xA0CF94", VA = "0xA0CF94", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170001A3")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000778")]
				[Address(RVA = "0xA0CFFC", Offset = "0xA0CFFC", VA = "0xA0CFFC", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000773")]
			[Address(RVA = "0xA0CE9C", Offset = "0xA0CE9C", VA = "0xA0CE9C")]
			[DebuggerHidden]
			public <WaitForActualSeconds>d__0(int <>1__state)
			{
			}

			[Token(Token = "0x6000774")]
			[Address(RVA = "0xA0CEC8", Offset = "0xA0CEC8", VA = "0xA0CEC8", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000775")]
			[Address(RVA = "0xA0CECC", Offset = "0xA0CECC", VA = "0xA0CECC", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000777")]
			[Address(RVA = "0xA0CF9C", Offset = "0xA0CF9C", VA = "0xA0CF9C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x60005D6")]
		[Address(RVA = "0xA0CE24", Offset = "0xA0CE24", VA = "0xA0CE24")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x984070", Offset = "0x984070")]
		public static IEnumerator WaitForActualSeconds(float time)
		{
			return null;
		}
	}
	[Token(Token = "0x20000BE")]
	public static class DTMonoHelper
	{
		[Token(Token = "0x60005D7")]
		[Address(RVA = "0xA054CC", Offset = "0xA054CC", VA = "0xA054CC")]
		public static Transform GetChildTransform(this Transform transParent, string childName)
		{
			return null;
		}

		[Token(Token = "0x60005D8")]
		[Address(RVA = "0xA0D0F8", Offset = "0xA0D0F8", VA = "0xA0D0F8")]
		public static bool IsActive(GameObject go)
		{
			return default(bool);
		}

		[Token(Token = "0x60005D9")]
		[Address(RVA = "0xA0D110", Offset = "0xA0D110", VA = "0xA0D110")]
		public static void SetActive(GameObject go, bool isActive)
		{
		}

		[Token(Token = "0x60005DA")]
		[Address(RVA = "0xA04A84", Offset = "0xA04A84", VA = "0xA04A84")]
		public static void DestroyAllChildren(this Transform tran)
		{
		}
	}
	[Token(Token = "0x20000BF")]
	public class DelayBetweenSongs : MonoBehaviour
	{
		[Token(Token = "0x2000140")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x981884", Offset = "0x981884")]
		private sealed class <PlaySongWithDelay>d__7 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40008B5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40008B6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40008B7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public DelayBetweenSongs <>4__this;

			[Token(Token = "0x170001A4")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600077C")]
				[Address(RVA = "0xA0D528", Offset = "0xA0D528", VA = "0xA0D528", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170001A5")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600077E")]
				[Address(RVA = "0xA0D590", Offset = "0xA0D590", VA = "0xA0D590", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000779")]
			[Address(RVA = "0xA0D300", Offset = "0xA0D300", VA = "0xA0D300")]
			[DebuggerHidden]
			public <PlaySongWithDelay>d__7(int <>1__state)
			{
			}

			[Token(Token = "0x600077A")]
			[Address(RVA = "0xA0D390", Offset = "0xA0D390", VA = "0xA0D390", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600077B")]
			[Address(RVA = "0xA0D394", Offset = "0xA0D394", VA = "0xA0D394", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600077D")]
			[Address(RVA = "0xA0D530", Offset = "0xA0D530", VA = "0xA0D530", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000620")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float minTimeToWait;

		[Token(Token = "0x4000621")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float maxTimeToWait;

		[Token(Token = "0x4000622")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string playlistControllerName;

		[Token(Token = "0x4000623")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private PlaylistController _controller;

		[Token(Token = "0x60005DB")]
		[Address(RVA = "0xA0D12C", Offset = "0xA0D12C", VA = "0xA0D12C")]
		private void Start()
		{
		}

		[Token(Token = "0x60005DC")]
		[Address(RVA = "0xA0D1CC", Offset = "0xA0D1CC", VA = "0xA0D1CC")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60005DD")]
		[Address(RVA = "0xA0D258", Offset = "0xA0D258", VA = "0xA0D258")]
		private void SongEnded(string songName)
		{
		}

		[Token(Token = "0x60005DE")]
		[Address(RVA = "0xA0D290", Offset = "0xA0D290", VA = "0xA0D290")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9840F4", Offset = "0x9840F4")]
		private IEnumerator PlaySongWithDelay()
		{
			return null;
		}

		[Token(Token = "0x60005DF")]
		[Address(RVA = "0xA0D32C", Offset = "0xA0D32C", VA = "0xA0D32C")]
		public DelayBetweenSongs()
		{
		}
	}
	[Token(Token = "0x20000C0")]
	[AttributeAttribute(Name = "AudioScriptOrder", RVA = "0x981598", Offset = "0x981598")]
	public class DynamicSoundGroupCreator : MonoBehaviour
	{
		[Token(Token = "0x2000141")]
		public enum CreateItemsWhen
		{
			[Token(Token = "0x40008B9")]
			FirstEnableOnly,
			[Token(Token = "0x40008BA")]
			EveryEnable
		}

		[Token(Token = "0x2000142")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x981894", Offset = "0x981894")]
		private sealed class <>c__DisplayClass39_0
		{
			[Token(Token = "0x40008BB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public CustomEventCategory aCat;

			[Token(Token = "0x600077F")]
			[Address(RVA = "0xA0F894", Offset = "0xA0F894", VA = "0xA0F894")]
			public <>c__DisplayClass39_0()
			{
			}

			[Token(Token = "0x6000780")]
			[Address(RVA = "0xA11CBC", Offset = "0xA11CBC", VA = "0xA11CBC")]
			internal bool <RemoveItems>b__0(CustomEventCategory cat)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x4000624")]
		public const int ExtraHardCodedBusOptions = 1;

		[Token(Token = "0x4000625")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public SystemLanguage previewLanguage;

		[Token(Token = "0x4000626")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public MasterAudio.DragGroupMode curDragGroupMode;

		[Token(Token = "0x4000627")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public GameObject groupTemplate;

		[Token(Token = "0x4000628")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public GameObject variationTemplate;

		[Token(Token = "0x4000629")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool errorOnDuplicates;

		[Token(Token = "0x400062A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
		public bool createOnAwake;

		[Token(Token = "0x400062B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x32")]
		public bool soundGroupsAreExpanded;

		[Token(Token = "0x400062C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x33")]
		public bool removeGroupsOnSceneChange;

		[Token(Token = "0x400062D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public CreateItemsWhen reUseMode;

		[Token(Token = "0x400062E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public bool showCustomEvents;

		[Token(Token = "0x400062F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public MasterAudio.AudioLocation bulkVariationMode;

		[Token(Token = "0x4000630")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public List<CustomEvent> customEventsToCreate;

		[Token(Token = "0x4000631")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public List<CustomEventCategory> customEventCategories;

		[Token(Token = "0x4000632")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public string newEventName;

		[Token(Token = "0x4000633")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public string newCustomEventCategoryName;

		[Token(Token = "0x4000634")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public string addToCustomEventCategoryName;

		[Token(Token = "0x4000635")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public bool showMusicDucking;

		[Token(Token = "0x4000636")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public List<DuckGroupInfo> musicDuckingSounds;

		[Token(Token = "0x4000637")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public List<GroupBus> groupBuses;

		[Token(Token = "0x4000638")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public bool playListExpanded;

		[Token(Token = "0x4000639")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x81")]
		public bool playlistEditorExp;

		[Token(Token = "0x400063A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public List<MasterAudio.Playlist> musicPlaylists;

		[Token(Token = "0x400063B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public List<GameObject> audioSourceTemplates;

		[Token(Token = "0x400063C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public string audioSourceTemplateName;

		[Token(Token = "0x400063D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public bool groupByBus;

		[Token(Token = "0x400063E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA1")]
		public bool itemsCreatedEventExpanded;

		[Token(Token = "0x400063F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public string itemsCreatedCustomEvent;

		[Token(Token = "0x4000640")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public bool showUnityMixerGroupAssignment;

		[Token(Token = "0x4000641")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB1")]
		private bool _hasCreated;

		[Token(Token = "0x4000642")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private readonly List<Transform> _groupsToRemove;

		[Token(Token = "0x4000643")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private Transform _trans;

		[Token(Token = "0x4000644")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private readonly List<DynamicSoundGroup> _groupsToCreate;

		[Token(Token = "0x17000150")]
		public static int HardCodedBusOptions
		{
			[Token(Token = "0x60005E9")]
			[Address(RVA = "0xA10060", Offset = "0xA10060", VA = "0xA10060")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000151")]
		public List<DynamicSoundGroup> GroupsToCreate
		{
			[Token(Token = "0x60005EA")]
			[Address(RVA = "0xA11A70", Offset = "0xA11A70", VA = "0xA11A70")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000152")]
		public bool ShouldShowUnityAudioMixerGroupAssignments
		{
			[Token(Token = "0x60005EB")]
			[Address(RVA = "0xA11A78", Offset = "0xA11A78", VA = "0xA11A78")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60005E0")]
		[Address(RVA = "0xA0DFEC", Offset = "0xA0DFEC", VA = "0xA0DFEC")]
		private void Awake()
		{
		}

		[Token(Token = "0x60005E1")]
		[Address(RVA = "0xA0E0BC", Offset = "0xA0E0BC", VA = "0xA0E0BC")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60005E2")]
		[Address(RVA = "0xA0E1AC", Offset = "0xA0E1AC", VA = "0xA0E1AC")]
		private void Start()
		{
		}

		[Token(Token = "0x60005E3")]
		[Address(RVA = "0xA0E1B0", Offset = "0xA0E1B0", VA = "0xA0E1B0")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60005E4")]
		[Address(RVA = "0xA0E0C0", Offset = "0xA0E0C0", VA = "0xA0E0C0")]
		private void CreateItemsIfReady()
		{
		}

		[Token(Token = "0x60005E5")]
		[Address(RVA = "0xA0E2D4", Offset = "0xA0E2D4", VA = "0xA0E2D4")]
		public void RemoveItems()
		{
		}

		[Token(Token = "0x60005E6")]
		[Address(RVA = "0xA0E700", Offset = "0xA0E700", VA = "0xA0E700")]
		public void CreateItems()
		{
		}

		[Token(Token = "0x60005E7")]
		[Address(RVA = "0xA11800", Offset = "0xA11800", VA = "0xA11800")]
		private void FireEvents()
		{
		}

		[Token(Token = "0x60005E8")]
		[Address(RVA = "0xA0FB00", Offset = "0xA0FB00", VA = "0xA0FB00")]
		public void PopulateGroupData()
		{
		}

		[Token(Token = "0x60005EC")]
		[Address(RVA = "0xA11A80", Offset = "0xA11A80", VA = "0xA11A80")]
		public DynamicSoundGroupCreator()
		{
		}
	}
	[Token(Token = "0x20000C1")]
	public static class FilePlayerPrefs
	{
		[Token(Token = "0x4000645")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly Hashtable PlayerPrefsHashtable;

		[Token(Token = "0x4000646")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static bool _hashTableChanged;

		[Token(Token = "0x4000647")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static string _serializedOutput;

		[Token(Token = "0x4000648")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static readonly string SerializedInput;

		[Token(Token = "0x4000649")]
		private const string ParametersSeperator = ";";

		[Token(Token = "0x400064A")]
		private const string KeyValueSeperator = ":";

		[Token(Token = "0x400064B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static readonly string FileName;

		[Token(Token = "0x60005ED")]
		[Address(RVA = "0xA1FFFC", Offset = "0xA1FFFC", VA = "0xA1FFFC")]
		static FilePlayerPrefs()
		{
		}

		[Token(Token = "0x60005EE")]
		[Address(RVA = "0xA203E8", Offset = "0xA203E8", VA = "0xA203E8")]
		public static bool HasKey(string key)
		{
			return default(bool);
		}

		[Token(Token = "0x60005EF")]
		[Address(RVA = "0xA2046C", Offset = "0xA2046C", VA = "0xA2046C")]
		public static void SetString(string key, string value)
		{
		}

		[Token(Token = "0x60005F0")]
		[Address(RVA = "0xA205A4", Offset = "0xA205A4", VA = "0xA205A4")]
		public static void SetInt(string key, int value)
		{
		}

		[Token(Token = "0x60005F1")]
		[Address(RVA = "0xA2071C", Offset = "0xA2071C", VA = "0xA2071C")]
		public static void SetFloat(string key, float value)
		{
		}

		[Token(Token = "0x60005F2")]
		[Address(RVA = "0xA2089C", Offset = "0xA2089C", VA = "0xA2089C")]
		public static void SetBool(string key, bool value)
		{
		}

		[Token(Token = "0x60005F3")]
		[Address(RVA = "0xA20A18", Offset = "0xA20A18", VA = "0xA20A18")]
		public static string GetString(string key)
		{
			return null;
		}

		[Token(Token = "0x60005F4")]
		[Address(RVA = "0xA20AFC", Offset = "0xA20AFC", VA = "0xA20AFC")]
		public static string GetString(string key, string defaultValue)
		{
			return null;
		}

		[Token(Token = "0x60005F5")]
		[Address(RVA = "0xA20C40", Offset = "0xA20C40", VA = "0xA20C40")]
		public static int GetInt(string key)
		{
			return default(int);
		}

		[Token(Token = "0x60005F6")]
		[Address(RVA = "0xA20DE0", Offset = "0xA20DE0", VA = "0xA20DE0")]
		public static int GetInt(string key, int defaultValue)
		{
			return default(int);
		}

		[Token(Token = "0x60005F7")]
		[Address(RVA = "0xA20F60", Offset = "0xA20F60", VA = "0xA20F60")]
		public static float GetFloat(string key)
		{
			return default(float);
		}

		[Token(Token = "0x60005F8")]
		[Address(RVA = "0xA21100", Offset = "0xA21100", VA = "0xA21100")]
		public static float GetFloat(string key, float defaultValue)
		{
			return default(float);
		}

		[Token(Token = "0x60005F9")]
		[Address(RVA = "0xA21288", Offset = "0xA21288", VA = "0xA21288")]
		public static bool GetBool(string key)
		{
			return default(bool);
		}

		[Token(Token = "0x60005FA")]
		[Address(RVA = "0xA21390", Offset = "0xA21390", VA = "0xA21390")]
		public static bool GetBool(string key, bool defaultValue)
		{
			return default(bool);
		}

		[Token(Token = "0x60005FB")]
		[Address(RVA = "0xA2151C", Offset = "0xA2151C", VA = "0xA2151C")]
		public static void DeleteKey(string key)
		{
		}

		[Token(Token = "0x60005FC")]
		[Address(RVA = "0xA215A0", Offset = "0xA215A0", VA = "0xA215A0")]
		public static void DeleteAll()
		{
		}

		[Token(Token = "0x60005FD")]
		[Address(RVA = "0xA2161C", Offset = "0xA2161C", VA = "0xA2161C")]
		public static void Flush()
		{
		}

		[Token(Token = "0x60005FE")]
		[Address(RVA = "0xA21798", Offset = "0xA21798", VA = "0xA21798")]
		private static void Serialize()
		{
		}

		[Token(Token = "0x60005FF")]
		[Address(RVA = "0xA20140", Offset = "0xA20140", VA = "0xA20140")]
		private static void Deserialize()
		{
		}

		[Token(Token = "0x6000600")]
		[Address(RVA = "0xA21C10", Offset = "0xA21C10", VA = "0xA21C10")]
		private static string EscapeNonSeperators(string inputToEscape)
		{
			return null;
		}

		[Token(Token = "0x6000601")]
		[Address(RVA = "0xA21C9C", Offset = "0xA21C9C", VA = "0xA21C9C")]
		private static string DeEscapeNonSeperators(string inputToDeEscape)
		{
			return null;
		}

		[Token(Token = "0x6000602")]
		[Address(RVA = "0xA21D28", Offset = "0xA21D28", VA = "0xA21D28")]
		public static object GetTypeValue(string typeName, string value)
		{
			return null;
		}
	}
	[Token(Token = "0x20000C2")]
	[AttributeAttribute(Name = "AudioScriptOrder", RVA = "0x9815AC", Offset = "0x9815AC")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x9815AC", Offset = "0x9815AC")]
	public class PlaylistController : MonoBehaviour
	{
		[Token(Token = "0x2000143")]
		public enum AudioPlayType
		{
			[Token(Token = "0x40008BD")]
			PlayNow,
			[Token(Token = "0x40008BE")]
			Schedule,
			[Token(Token = "0x40008BF")]
			AlreadyScheduled
		}

		[Token(Token = "0x2000144")]
		public enum PlaylistStates
		{
			[Token(Token = "0x40008C1")]
			NotInScene,
			[Token(Token = "0x40008C2")]
			Stopped,
			[Token(Token = "0x40008C3")]
			Playing,
			[Token(Token = "0x40008C4")]
			Paused,
			[Token(Token = "0x40008C5")]
			Crossfading
		}

		[Token(Token = "0x2000145")]
		public enum FadeMode
		{
			[Token(Token = "0x40008C7")]
			None,
			[Token(Token = "0x40008C8")]
			GradualFade
		}

		[Token(Token = "0x2000146")]
		public enum AudioDuckingMode
		{
			[Token(Token = "0x40008CA")]
			NotDucking,
			[Token(Token = "0x40008CB")]
			SetToDuck,
			[Token(Token = "0x40008CC")]
			Ducked
		}

		[Token(Token = "0x2000147")]
		public delegate void SongChangedEventHandler(string newSongName, MusicSetting song);

		[Token(Token = "0x2000148")]
		public delegate void SongEndedEventHandler(string songName);

		[Token(Token = "0x2000149")]
		public delegate void SongLoopedEventHandler(string songName);

		[Token(Token = "0x200014A")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9818A4", Offset = "0x9818A4")]
		private sealed class <>c__DisplayClass107_0
		{
			[Token(Token = "0x40008CD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string playlistControllerName;

			[Token(Token = "0x600078D")]
			[Address(RVA = "0xFEFEF4", Offset = "0xFEFEF4", VA = "0xFEFEF4")]
			public <>c__DisplayClass107_0()
			{
			}

			[Token(Token = "0x600078E")]
			[Address(RVA = "0xFF48DC", Offset = "0xFF48DC", VA = "0xFF48DC")]
			internal bool <InstanceByName>b__0(PlaylistController obj)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x200014B")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9818B4", Offset = "0x9818B4")]
		private sealed class <>c__DisplayClass126_0
		{
			[Token(Token = "0x40008CE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string clipName;

			[Token(Token = "0x600078F")]
			[Address(RVA = "0xFF2284", Offset = "0xFF2284", VA = "0xFF2284")]
			public <>c__DisplayClass126_0()
			{
			}

			[Token(Token = "0x6000790")]
			[Address(RVA = "0xFF4988", Offset = "0xFF4988", VA = "0xFF4988")]
			internal bool <QueuePlaylistClip>b__0(MusicSetting obj)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x200014C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9818C4", Offset = "0x9818C4")]
		private sealed class <>c__DisplayClass127_0
		{
			[Token(Token = "0x40008CF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string clipName;

			[Token(Token = "0x6000791")]
			[Address(RVA = "0xFF25D8", Offset = "0xFF25D8", VA = "0xFF25D8")]
			public <>c__DisplayClass127_0()
			{
			}

			[Token(Token = "0x6000792")]
			[Address(RVA = "0xFF4A50", Offset = "0xFF4A50", VA = "0xFF4A50")]
			internal bool <TriggerPlaylistClip>b__0(MusicSetting obj)
			{
				return default(bool);
			}

			[Token(Token = "0x6000793")]
			[Address(RVA = "0xFF4A74", Offset = "0xFF4A74", VA = "0xFF4A74")]
			internal bool <TriggerPlaylistClip>b__1(MusicSetting obj)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x200014D")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9818D4", Offset = "0x9818D4")]
		private sealed class <>c__DisplayClass137_0
		{
			[Token(Token = "0x40008D0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public PlaylistController <>4__this;

			[Token(Token = "0x40008D1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float volumeBeforeFade;

			[Token(Token = "0x6000794")]
			[Address(RVA = "0xFF2C2C", Offset = "0xFF2C2C", VA = "0xFF2C2C")]
			public <>c__DisplayClass137_0()
			{
			}

			[Token(Token = "0x6000795")]
			[Address(RVA = "0xFF4B58", Offset = "0xFF4B58", VA = "0xFF4B58")]
			internal void <FadeOutPlaylist>b__0()
			{
			}
		}

		[Token(Token = "0x400064C")]
		public const float ScheduledSongMinBadOffset = 0.5f;

		[Token(Token = "0x400064D")]
		public const int FramesEarlyToTrigger = 2;

		[Token(Token = "0x400064E")]
		public const int FramesEarlyToBeSyncable = 10;

		[Token(Token = "0x400064F")]
		private const string NotReadyMessage = "Playlist Controller is not initialized yet. It must call its own Awake & Start method before any other methods are called. If you have a script with an Awake or Start event that needs to call it, make sure PlaylistController.cs is set to execute first (Script Execution Order window in Unity). Awake event is still not guaranteed to work, so use Start where possible.";

		[Token(Token = "0x4000650")]
		private const float MinSongLength = 0.5f;

		[Token(Token = "0x4000651")]
		private const float SlowestFrameTimeForCalc = 0.3f;

		[Token(Token = "0x4000652")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool startPlaylistOnAwake;

		[Token(Token = "0x4000653")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		public bool isShuffle;

		[Token(Token = "0x4000654")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
		public bool isAutoAdvance;

		[Token(Token = "0x4000655")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B")]
		public bool loopPlaylist;

		[Token(Token = "0x4000656")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float _playlistVolume;

		[Token(Token = "0x4000657")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool isMuted;

		[Token(Token = "0x4000658")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string startPlaylistName;

		[Token(Token = "0x4000659")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public int syncGroupNum;

		[Token(Token = "0x400065A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public AudioMixerGroup mixerChannel;

		[Token(Token = "0x400065B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public MasterAudio.ItemSpatialBlendType spatialBlendType;

		[Token(Token = "0x400065C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float spatialBlend;

		[Token(Token = "0x400065D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public bool initializedEventExpanded;

		[Token(Token = "0x400065E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public string initializedCustomEvent;

		[Token(Token = "0x400065F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public bool crossfadeStartedExpanded;

		[Token(Token = "0x4000660")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public string crossfadeStartedCustomEvent;

		[Token(Token = "0x4000661")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public bool songChangedEventExpanded;

		[Token(Token = "0x4000662")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public string songChangedCustomEvent;

		[Token(Token = "0x4000663")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public bool songEndedEventExpanded;

		[Token(Token = "0x4000664")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public string songEndedCustomEvent;

		[Token(Token = "0x4000665")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public bool songLoopedEventExpanded;

		[Token(Token = "0x4000666")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public string songLoopedCustomEvent;

		[Token(Token = "0x4000667")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public bool playlistStartedEventExpanded;

		[Token(Token = "0x4000668")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public string playlistStartedCustomEvent;

		[Token(Token = "0x4000669")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public bool playlistEndedEventExpanded;

		[Token(Token = "0x400066A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public string playlistEndedCustomEvent;

		[Token(Token = "0x400066B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private AudioSource _activeAudio;

		[Token(Token = "0x400066C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private AudioSource _transitioningAudio;

		[Token(Token = "0x400066D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private float _activeAudioEndVolume;

		[Token(Token = "0x400066E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		private float _transitioningAudioStartVolume;

		[Token(Token = "0x400066F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private float _crossFadeStartTime;

		[Token(Token = "0x4000670")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private readonly List<int> _clipsRemaining;

		[Token(Token = "0x4000671")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private int _currentSequentialClipIndex;

		[Token(Token = "0x4000672")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		private AudioDuckingMode _duckingMode;

		[Token(Token = "0x4000673")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private float _timeToStartUnducking;

		[Token(Token = "0x4000674")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
		private float _timeToFinishUnducking;

		[Token(Token = "0x4000675")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private float _originalMusicVolume;

		[Token(Token = "0x4000676")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
		private float _initialDuckVolume;

		[Token(Token = "0x4000677")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private float _duckRange;

		[Token(Token = "0x4000678")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private MusicSetting _currentSong;

		[Token(Token = "0x4000679")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private GameObject _go;

		[Token(Token = "0x400067A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private string _name;

		[Token(Token = "0x400067B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private FadeMode _curFadeMode;

		[Token(Token = "0x400067C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11C")]
		private float _slowFadeStartTime;

		[Token(Token = "0x400067D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private float _slowFadeCompletionTime;

		[Token(Token = "0x400067E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x124")]
		private float _slowFadeStartVolume;

		[Token(Token = "0x400067F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		private float _slowFadeTargetVolume;

		[Token(Token = "0x4000680")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private MasterAudio.Playlist _currentPlaylist;

		[Token(Token = "0x4000681")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		private float _lastTimeMissingPlaylistLogged;

		[Token(Token = "0x4000682")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		private Action _fadeCompleteCallback;

		[Token(Token = "0x4000683")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		private readonly List<MusicSetting> _queuedSongs;

		[Token(Token = "0x4000684")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		private bool _lostFocus;

		[Token(Token = "0x4000685")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x151")]
		private bool _autoStartedPlaylist;

		[Token(Token = "0x4000686")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		private AudioSource _audioClip;

		[Token(Token = "0x4000687")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		private AudioSource _transClip;

		[Token(Token = "0x4000688")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		private MusicSetting _newSongSetting;

		[Token(Token = "0x4000689")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		private bool _nextSongRequested;

		[Token(Token = "0x400068A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x171")]
		private bool _nextSongScheduled;

		[Token(Token = "0x400068B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x174")]
		private int _lastRandomClipIndex;

		[Token(Token = "0x400068C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
		private float _lastTimeSongRequested;

		[Token(Token = "0x400068D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x17C")]
		private float _currentDuckVolCut;

		[Token(Token = "0x400068E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
		private int? _lastSongPosition;

		[Token(Token = "0x400068F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
		private double? _currentSchedSongDspStartTime;

		[Token(Token = "0x4000690")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
		private double? _currentSchedSongDspEndTime;

		[Token(Token = "0x4000691")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
		private int _lastFrameSongPosition;

		[Token(Token = "0x4000692")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
		private readonly Dictionary<AudioSource, double> _scheduledSongOffsetByAudioSource;

		[Token(Token = "0x4000693")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
		public int _frames;

		[Token(Token = "0x4000694")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static List<PlaylistController> _instances;

		[Token(Token = "0x4000695")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1BC")]
		private int _songsPlayedFromPlaylist;

		[Token(Token = "0x4000696")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
		private AudioSource _audio1;

		[Token(Token = "0x4000697")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C8")]
		private AudioSource _audio2;

		[Token(Token = "0x4000698")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D0")]
		private Transform _trans;

		[Token(Token = "0x4000699")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D8")]
		private bool _willPersist;

		[Token(Token = "0x400069A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E0")]
		private double? _songPauseTime;

		[Token(Token = "0x400069B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F0")]
		private int framesOfSongPlayed;

		[Token(Token = "0x400069F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x210")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x982C98", Offset = "0x982C98")]
		private bool <ControllerIsReady>k__BackingField;

		[Token(Token = "0x40006A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x211")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x982CA8", Offset = "0x982CA8")]
		private bool <IsCrossFading>k__BackingField;

		[Token(Token = "0x17000153")]
		private bool SongIsNonAdvancible
		{
			[Token(Token = "0x6000644")]
			[Address(RVA = "0xFF42E8", Offset = "0xFF42E8", VA = "0xFF42E8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000154")]
		private bool ShouldLoadAsync
		{
			[Token(Token = "0x6000646")]
			[Address(RVA = "0xFF2CC4", Offset = "0xFF2CC4", VA = "0xFF2CC4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000155")]
		public bool ControllerIsReady
		{
			[Token(Token = "0x6000647")]
			[Address(RVA = "0xFF4340", Offset = "0xFF4340", VA = "0xFF4340")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9841B8", Offset = "0x9841B8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000648")]
			[Address(RVA = "0xFF4348", Offset = "0xFF4348", VA = "0xFF4348")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9841C8", Offset = "0x9841C8")]
			private set
			{
			}
		}

		[Token(Token = "0x17000156")]
		public PlaylistStates PlaylistState
		{
			[Token(Token = "0x6000649")]
			[Address(RVA = "0xFEF708", Offset = "0xFEF708", VA = "0xFEF708")]
			get
			{
				return default(PlaylistStates);
			}
		}

		[Token(Token = "0x17000157")]
		public AudioSource ActiveAudioSource
		{
			[Token(Token = "0x600064A")]
			[Address(RVA = "0xFEE9E8", Offset = "0xFEE9E8", VA = "0xFEE9E8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000158")]
		public static List<PlaylistController> Instances
		{
			[Token(Token = "0x600064B")]
			[Address(RVA = "0xFEFEFC", Offset = "0xFEFEFC", VA = "0xFEFEFC")]
			get
			{
				return null;
			}
			[Token(Token = "0x600064C")]
			[Address(RVA = "0xFF4354", Offset = "0xFF4354", VA = "0xFF4354")]
			set
			{
			}
		}

		[Token(Token = "0x17000159")]
		public GameObject PlaylistControllerGameObject
		{
			[Token(Token = "0x600064D")]
			[Address(RVA = "0xFF43A8", Offset = "0xFF43A8", VA = "0xFF43A8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700015A")]
		public AudioSource CurrentPlaylistSource
		{
			[Token(Token = "0x600064E")]
			[Address(RVA = "0xFF43B0", Offset = "0xFF43B0", VA = "0xFF43B0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700015B")]
		public AudioClip CurrentPlaylistClip
		{
			[Token(Token = "0x600064F")]
			[Address(RVA = "0xFF43B8", Offset = "0xFF43B8", VA = "0xFF43B8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700015C")]
		public AudioClip FadingPlaylistClip
		{
			[Token(Token = "0x6000650")]
			[Address(RVA = "0xFF4450", Offset = "0xFF4450", VA = "0xFF4450")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700015D")]
		public AudioSource FadingSource
		{
			[Token(Token = "0x6000651")]
			[Address(RVA = "0xFF44F0", Offset = "0xFF44F0", VA = "0xFF44F0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700015E")]
		public bool IsCrossFading
		{
			[Token(Token = "0x6000652")]
			[Address(RVA = "0xFF4508", Offset = "0xFF4508", VA = "0xFF4508")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9841D8", Offset = "0x9841D8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000653")]
			[Address(RVA = "0xFF4510", Offset = "0xFF4510", VA = "0xFF4510")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9841E8", Offset = "0x9841E8")]
			private set
			{
			}
		}

		[Token(Token = "0x1700015F")]
		public bool IsFading
		{
			[Token(Token = "0x6000654")]
			[Address(RVA = "0xFF451C", Offset = "0xFF451C", VA = "0xFF451C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000160")]
		public float PlaylistVolume
		{
			[Token(Token = "0x6000655")]
			[Address(RVA = "0xFF2780", Offset = "0xFF2780", VA = "0xFF2780")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000656")]
			[Address(RVA = "0xFF453C", Offset = "0xFF453C", VA = "0xFF453C")]
			set
			{
			}
		}

		[Token(Token = "0x17000161")]
		public MasterAudio.Playlist CurrentPlaylist
		{
			[Token(Token = "0x6000658")]
			[Address(RVA = "0xFF2D5C", Offset = "0xFF2D5C", VA = "0xFF2D5C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000162")]
		public bool HasPlaylist
		{
			[Token(Token = "0x6000659")]
			[Address(RVA = "0xFF01C8", Offset = "0xFF01C8", VA = "0xFF01C8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000163")]
		public string PlaylistName
		{
			[Token(Token = "0x600065A")]
			[Address(RVA = "0xFF4588", Offset = "0xFF4588", VA = "0xFF4588")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000164")]
		private bool IsMuted
		{
			[Token(Token = "0x600065B")]
			[Address(RVA = "0xFF4600", Offset = "0xFF4600", VA = "0xFF4600")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000165")]
		private bool PlaylistIsMuted
		{
			[Token(Token = "0x600065C")]
			[Address(RVA = "0xFF0328", Offset = "0xFF0328", VA = "0xFF0328")]
			set
			{
			}
		}

		[Token(Token = "0x17000166")]
		private float CrossFadeTime
		{
			[Token(Token = "0x600065D")]
			[Address(RVA = "0xFEF52C", Offset = "0xFEF52C", VA = "0xFEF52C")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000167")]
		private bool IsAutoAdvance
		{
			[Token(Token = "0x600065E")]
			[Address(RVA = "0xFEF5BC", Offset = "0xFEF5BC", VA = "0xFEF5BC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000168")]
		public GameObject GameObj
		{
			[Token(Token = "0x600065F")]
			[Address(RVA = "0xFF0AF0", Offset = "0xFF0AF0", VA = "0xFF0AF0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000169")]
		public string ControllerName
		{
			[Token(Token = "0x6000660")]
			[Address(RVA = "0xFEDBB8", Offset = "0xFEDBB8", VA = "0xFEDBB8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700016A")]
		public bool CanSchedule
		{
			[Token(Token = "0x6000661")]
			[Address(RVA = "0xFEF3B0", Offset = "0xFEF3B0", VA = "0xFEF3B0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700016B")]
		private bool IsFrameFastEnough
		{
			[Token(Token = "0x6000662")]
			[Address(RVA = "0xFEE1A8", Offset = "0xFEE1A8", VA = "0xFEE1A8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700016C")]
		private bool ShouldNotSwitchEarly
		{
			[Token(Token = "0x6000663")]
			[Address(RVA = "0xFEF6CC", Offset = "0xFEF6CC", VA = "0xFEF6CC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700016D")]
		private Transform Trans
		{
			[Token(Token = "0x6000664")]
			[Address(RVA = "0xFEE0B0", Offset = "0xFEE0B0", VA = "0xFEE0B0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700016E")]
		public int ClipsRemainingInCurrentPlaylist
		{
			[Token(Token = "0x6000665")]
			[Address(RVA = "0xFF4608", Offset = "0xFF4608", VA = "0xFF4608")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x14000008")]
		public event SongChangedEventHandler SongChanged
		{
			[Token(Token = "0x6000603")]
			[Address(RVA = "0xFED2C0", Offset = "0xFED2C0", VA = "0xFED2C0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x984158", Offset = "0x984158")]
			add
			{
			}
			[Token(Token = "0x6000604")]
			[Address(RVA = "0xFED368", Offset = "0xFED368", VA = "0xFED368")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x984168", Offset = "0x984168")]
			remove
			{
			}
		}

		[Token(Token = "0x14000009")]
		public event SongEndedEventHandler SongEnded
		{
			[Token(Token = "0x6000605")]
			[Address(RVA = "0xFED410", Offset = "0xFED410", VA = "0xFED410")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x984178", Offset = "0x984178")]
			add
			{
			}
			[Token(Token = "0x6000606")]
			[Address(RVA = "0xFED4B8", Offset = "0xFED4B8", VA = "0xFED4B8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x984188", Offset = "0x984188")]
			remove
			{
			}
		}

		[Token(Token = "0x1400000A")]
		public event SongLoopedEventHandler SongLooped
		{
			[Token(Token = "0x6000607")]
			[Address(RVA = "0xFED560", Offset = "0xFED560", VA = "0xFED560")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x984198", Offset = "0x984198")]
			add
			{
			}
			[Token(Token = "0x6000608")]
			[Address(RVA = "0xFED608", Offset = "0xFED608", VA = "0xFED608")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9841A8", Offset = "0x9841A8")]
			remove
			{
			}
		}

		[Token(Token = "0x6000609")]
		[Address(RVA = "0xFED6B0", Offset = "0xFED6B0", VA = "0xFED6B0")]
		private void Awake()
		{
		}

		[Token(Token = "0x600060A")]
		[Address(RVA = "0xFEDBF8", Offset = "0xFEDBF8", VA = "0xFEDBF8")]
		public void SetSpatialBlend()
		{
		}

		[Token(Token = "0x600060B")]
		[Address(RVA = "0xFEDE10", Offset = "0xFEDE10", VA = "0xFEDE10")]
		private void SetAudiosIfEmpty()
		{
		}

		[Token(Token = "0x600060C")]
		[Address(RVA = "0xFEDD5C", Offset = "0xFEDD5C", VA = "0xFEDD5C")]
		private void SetAudioSpatialBlend(float blend)
		{
		}

		[Token(Token = "0x600060D")]
		[Address(RVA = "0xFEDE9C", Offset = "0xFEDE9C", VA = "0xFEDE9C")]
		private void Start()
		{
		}

		[Token(Token = "0x600060E")]
		[Address(RVA = "0xFEE140", Offset = "0xFEE140", VA = "0xFEE140")]
		private void AutoStartPlaylist()
		{
		}

		[Token(Token = "0x600060F")]
		[Address(RVA = "0xFEE27C", Offset = "0xFEE27C", VA = "0xFEE27C")]
		private void CoUpdate()
		{
		}

		[Token(Token = "0x6000610")]
		[Address(RVA = "0xFEE6D0", Offset = "0xFEE6D0", VA = "0xFEE6D0")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000611")]
		[Address(RVA = "0xFEE7A8", Offset = "0xFEE7A8", VA = "0xFEE7A8")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000612")]
		[Address(RVA = "0xFEEAC0", Offset = "0xFEEAC0", VA = "0xFEEAC0")]
		private void OnApplicationPause(bool pauseStatus)
		{
		}

		[Token(Token = "0x6000613")]
		[Address(RVA = "0xFEEACC", Offset = "0xFEEACC", VA = "0xFEEACC")]
		private void Update()
		{
		}

		[Token(Token = "0x6000614")]
		[Address(RVA = "0xFEFD7C", Offset = "0xFEFD7C", VA = "0xFEFD7C")]
		public static PlaylistController InstanceByName(string playlistControllerName, bool errorIfNotFound = true)
		{
			return null;
		}

		[Token(Token = "0x6000615")]
		[Address(RVA = "0xFF00A8", Offset = "0xFF00A8", VA = "0xFF00A8")]
		public bool IsSongPlaying(string songName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000616")]
		[Address(RVA = "0xFF01D8", Offset = "0xFF01D8", VA = "0xFF01D8")]
		public void ClearQueue()
		{
		}

		[Token(Token = "0x6000617")]
		[Address(RVA = "0xFF0274", Offset = "0xFF0274", VA = "0xFF0274")]
		public void ToggleMutePlaylist()
		{
		}

		[Token(Token = "0x6000618")]
		[Address(RVA = "0xFEE1A0", Offset = "0xFEE1A0", VA = "0xFEE1A0")]
		public void MutePlaylist()
		{
		}

		[Token(Token = "0x6000619")]
		[Address(RVA = "0xFF0320", Offset = "0xFF0320", VA = "0xFF0320")]
		public void UnmutePlaylist()
		{
		}

		[Token(Token = "0x600061A")]
		[Address(RVA = "0xFF0490", Offset = "0xFF0490", VA = "0xFF0490")]
		public void PausePlaylist()
		{
		}

		[Token(Token = "0x600061B")]
		[Address(RVA = "0xFF0670", Offset = "0xFF0670", VA = "0xFF0670")]
		public bool UnpausePlaylist()
		{
			return default(bool);
		}

		[Token(Token = "0x600061C")]
		[Address(RVA = "0xFEE5EC", Offset = "0xFEE5EC", VA = "0xFEE5EC")]
		public void StopPlaylist(bool onlyFadingClip = false)
		{
		}

		[Token(Token = "0x600061D")]
		[Address(RVA = "0xFF0CC0", Offset = "0xFF0CC0", VA = "0xFF0CC0")]
		public void FadeToVolume(float targetVolume, float fadeTime, [Optional] Action callback)
		{
		}

		[Token(Token = "0x600061E")]
		[Address(RVA = "0xFF0DE4", Offset = "0xFF0DE4", VA = "0xFF0DE4")]
		public void PlayRandomSong()
		{
		}

		[Token(Token = "0x600061F")]
		[Address(RVA = "0xFF0E70", Offset = "0xFF0E70", VA = "0xFF0E70")]
		public void PlayARandomSong(AudioPlayType playType)
		{
		}

		[Token(Token = "0x6000620")]
		[Address(RVA = "0xFF1034", Offset = "0xFF1034", VA = "0xFF1034")]
		private void RemoveRandomClip(int randIndex)
		{
		}

		[Token(Token = "0x6000621")]
		[Address(RVA = "0xFF1830", Offset = "0xFF1830", VA = "0xFF1830")]
		private void PlayFirstQueuedSong(AudioPlayType playType)
		{
		}

		[Token(Token = "0x6000622")]
		[Address(RVA = "0xFF1934", Offset = "0xFF1934", VA = "0xFF1934")]
		public void PlayNextSong()
		{
		}

		[Token(Token = "0x6000623")]
		[Address(RVA = "0xFF19C0", Offset = "0xFF19C0", VA = "0xFF19C0")]
		public void PlayTheNextSong(AudioPlayType playType)
		{
		}

		[Token(Token = "0x6000624")]
		[Address(RVA = "0xFF1B40", Offset = "0xFF1B40", VA = "0xFF1B40")]
		private void AdvanceSongCounter()
		{
		}

		[Token(Token = "0x6000625")]
		[Address(RVA = "0xFF1BB8", Offset = "0xFF1BB8", VA = "0xFF1BB8")]
		public void StopPlaylistAfterCurrentSong()
		{
		}

		[Token(Token = "0x6000626")]
		[Address(RVA = "0xFF1D70", Offset = "0xFF1D70", VA = "0xFF1D70")]
		public void StopLoopingCurrentSong()
		{
		}

		[Token(Token = "0x6000627")]
		[Address(RVA = "0xFF1EEC", Offset = "0xFF1EEC", VA = "0xFF1EEC")]
		public void QueuePlaylistClip(string clipName, bool scheduleNow = true)
		{
		}

		[Token(Token = "0x6000628")]
		[Address(RVA = "0xFF228C", Offset = "0xFF228C", VA = "0xFF228C")]
		public bool TriggerPlaylistClip(string clipName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000629")]
		[Address(RVA = "0xFF25E0", Offset = "0xFF25E0", VA = "0xFF25E0")]
		public void DuckMusicForTime(float duckLength, float unduckTime, float pitch, float duckedTimePercentage, float duckedVolCut)
		{
		}

		[Token(Token = "0x600062A")]
		[Address(RVA = "0xFF2750", Offset = "0xFF2750", VA = "0xFF2750")]
		private void InitControllerIfNot()
		{
		}

		[Token(Token = "0x600062B")]
		[Address(RVA = "0xFEE4B8", Offset = "0xFEE4B8", VA = "0xFEE4B8")]
		public void UpdateMasterVolume()
		{
		}

		[Token(Token = "0x600062C")]
		[Address(RVA = "0xFF27F0", Offset = "0xFF27F0", VA = "0xFF27F0")]
		public void StartPlaylist(string playlistName)
		{
		}

		[Token(Token = "0x600062D")]
		[Address(RVA = "0xFF294C", Offset = "0xFF294C", VA = "0xFF294C")]
		public void ChangePlaylist(string playlistName, bool playFirstClip = true)
		{
		}

		[Token(Token = "0x600062E")]
		[Address(RVA = "0xFF0A30", Offset = "0xFF0A30", VA = "0xFF0A30")]
		private void FinishPlaylistInit(bool playFirstClip = true)
		{
		}

		[Token(Token = "0x600062F")]
		[Address(RVA = "0xFF28C0", Offset = "0xFF28C0", VA = "0xFF28C0")]
		public void RestartPlaylist()
		{
		}

		[Token(Token = "0x6000630")]
		[Address(RVA = "0xFF2A78", Offset = "0xFF2A78", VA = "0xFF2A78")]
		private void CheckIfPlaylistStarted()
		{
		}

		[Token(Token = "0x6000631")]
		[Address(RVA = "0xFF2B5C", Offset = "0xFF2B5C", VA = "0xFF2B5C")]
		private PlaylistController FindOtherControllerInSameSyncGroup()
		{
			return null;
		}

		[Token(Token = "0x6000632")]
		[Address(RVA = "0xFEF814", Offset = "0xFEF814", VA = "0xFEF814")]
		private void FadeOutPlaylist()
		{
		}

		[Token(Token = "0x6000633")]
		[Address(RVA = "0xFEE07C", Offset = "0xFEE07C", VA = "0xFEE07C")]
		private void InitializePlaylist()
		{
		}

		[Token(Token = "0x6000634")]
		[Address(RVA = "0xFEE1D0", Offset = "0xFEE1D0", VA = "0xFEE1D0")]
		private void PlayNextOrRandom(AudioPlayType playType)
		{
		}

		[Token(Token = "0x6000635")]
		[Address(RVA = "0xFEF5F4", Offset = "0xFEF5F4", VA = "0xFEF5F4")]
		private void FirePlaylistEndedEventIfAny()
		{
		}

		[Token(Token = "0x6000636")]
		[Address(RVA = "0xFF16B0", Offset = "0xFF16B0", VA = "0xFF16B0")]
		private void FillClips()
		{
		}

		[Token(Token = "0x6000637")]
		[Address(RVA = "0xFF10CC", Offset = "0xFF10CC", VA = "0xFF10CC")]
		private void PlaySong(MusicSetting setting, AudioPlayType playType)
		{
		}

		[Token(Token = "0x6000638")]
		[Address(RVA = "0xFF37BC", Offset = "0xFF37BC", VA = "0xFF37BC")]
		public double? ScheduledGaplessNextSongStartTime()
		{
			return null;
		}

		[Token(Token = "0x6000639")]
		[Address(RVA = "0xFF2E04", Offset = "0xFF2E04", VA = "0xFF2E04")]
		public void FinishLoadingNewSong(AudioClip clipToPlay, AudioPlayType playType)
		{
		}

		[Token(Token = "0x600063A")]
		[Address(RVA = "0xFF3980", Offset = "0xFF3980", VA = "0xFF3980")]
		private void RemoveScheduledClip()
		{
		}

		[Token(Token = "0x600063B")]
		[Address(RVA = "0xFF1EE4", Offset = "0xFF1EE4", VA = "0xFF1EE4")]
		private void ScheduleNextSong()
		{
		}

		[Token(Token = "0x600063C")]
		[Address(RVA = "0xFEF8FC", Offset = "0xFEF8FC", VA = "0xFEF8FC")]
		private void FadeInScheduledSong()
		{
		}

		[Token(Token = "0x600063D")]
		[Address(RVA = "0xFF3A20", Offset = "0xFF3A20", VA = "0xFF3A20")]
		private double CalculateNextTrackStartTimeOffset()
		{
			return default(double);
		}

		[Token(Token = "0x600063E")]
		[Address(RVA = "0xFF3ED8", Offset = "0xFF3ED8", VA = "0xFF3ED8")]
		private double GetClipDuration(AudioSource src)
		{
			return default(double);
		}

		[Token(Token = "0x600063F")]
		[Address(RVA = "0xFF0B80", Offset = "0xFF0B80", VA = "0xFF0B80")]
		private void ScheduleClipPlay(double scheduledPlayTimeOffset, AudioSource source, bool calledAfterPause)
		{
		}

		[Token(Token = "0x6000640")]
		[Address(RVA = "0xFF3868", Offset = "0xFF3868", VA = "0xFF3868")]
		private void CrossFadeNow(AudioSource audioClip)
		{
		}

		[Token(Token = "0x6000641")]
		[Address(RVA = "0xFEF0E4", Offset = "0xFEF0E4", VA = "0xFEF0E4")]
		private void CeaseAudioSource(AudioSource source)
		{
		}

		[Token(Token = "0x6000642")]
		[Address(RVA = "0xFEF448", Offset = "0xFEF448", VA = "0xFEF448")]
		private void SetDuckProperties()
		{
		}

		[Token(Token = "0x6000643")]
		[Address(RVA = "0xFEFC98", Offset = "0xFEFC98", VA = "0xFEFC98")]
		private void AudioDucking()
		{
		}

		[Token(Token = "0x6000645")]
		[Address(RVA = "0xFF2C34", Offset = "0xFF2C34", VA = "0xFF2C34")]
		private bool SongShouldLoop(MusicSetting setting)
		{
			return default(bool);
		}

		[Token(Token = "0x6000657")]
		[Address(RVA = "0xFF4544", Offset = "0xFF4544", VA = "0xFF4544")]
		public void RouteToMixerChannel(AudioMixerGroup group)
		{
		}

		[Token(Token = "0x6000666")]
		[Address(RVA = "0xFF4658", Offset = "0xFF4658", VA = "0xFF4658")]
		public PlaylistController()
		{
		}

		[Token(Token = "0x6000667")]
		[Address(RVA = "0xFF47D4", Offset = "0xFF47D4", VA = "0xFF47D4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9841F8", Offset = "0x9841F8")]
		private bool <FindOtherControllerInSameSyncGroup>b__136_0(PlaylistController obj)
		{
			return default(bool);
		}

		[Token(Token = "0x6000668")]
		[Address(RVA = "0xFF48CC", Offset = "0xFF48CC", VA = "0xFF48CC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x984208", Offset = "0x984208")]
		private bool <FinishLoadingNewSong>b__144_0(MusicSetting obj)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x20000C3")]
	public static class SpatializerHelper
	{
		[Token(Token = "0x40006A1")]
		private const string OculusSpatializer = "OculusSpatializer";

		[Token(Token = "0x40006A2")]
		private const string ResonanceAudioSpatializer = "Resonance Audio";

		[Token(Token = "0x1700016F")]
		public static bool IsSupportedSpatializer
		{
			[Token(Token = "0x6000669")]
			[Address(RVA = "0xFFC624", Offset = "0xFFC624", VA = "0xFFC624")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000170")]
		public static bool IsResonanceAudioSpatializer
		{
			[Token(Token = "0x600066A")]
			[Address(RVA = "0xFFC6B0", Offset = "0xFFC6B0", VA = "0xFFC6B0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000171")]
		public static string SelectedSpatializer
		{
			[Token(Token = "0x600066B")]
			[Address(RVA = "0xFFC6A8", Offset = "0xFFC6A8", VA = "0xFFC6A8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000172")]
		public static bool SpatializerOptionExists
		{
			[Token(Token = "0x600066C")]
			[Address(RVA = "0xFFC704", Offset = "0xFFC704", VA = "0xFFC704")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600066D")]
		[Address(RVA = "0xFF5CC4", Offset = "0xFF5CC4", VA = "0xFF5CC4")]
		public static void TurnOnSpatializerIfEnabled(AudioSource source)
		{
		}
	}
	[Token(Token = "0x20000C4")]
	public static class UtilStrings
	{
		[Token(Token = "0x600066E")]
		[Address(RVA = "0xFFC70C", Offset = "0xFFC70C", VA = "0xFFC70C")]
		public static string TrimSpace(string untrimmed)
		{
			return null;
		}

		[Token(Token = "0x600066F")]
		[Address(RVA = "0xFFC78C", Offset = "0xFFC78C", VA = "0xFFC78C")]
		public static string ReplaceUnsafeChars(string source)
		{
			return null;
		}
	}
}
