using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using FMOD;
using FMOD.Studio;
using FMODUnity;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.Playables;
using UnityEngine.Timeline;

[assembly: AssemblyVersion("0.0.0.0")]
[Token(Token = "0x2000002")]
public static class FmodResonanceAudio
{
	[Token(Token = "0x2000003")]
	private struct RoomProperties
	{
		[Token(Token = "0x400000F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float positionX;

		[Token(Token = "0x4000010")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public float positionY;

		[Token(Token = "0x4000011")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public float positionZ;

		[Token(Token = "0x4000012")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public float rotationX;

		[Token(Token = "0x4000013")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float rotationY;

		[Token(Token = "0x4000014")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public float rotationZ;

		[Token(Token = "0x4000015")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float rotationW;

		[Token(Token = "0x4000016")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float dimensionsX;

		[Token(Token = "0x4000017")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float dimensionsY;

		[Token(Token = "0x4000018")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float dimensionsZ;

		[Token(Token = "0x4000019")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public FmodResonanceAudioRoom.SurfaceMaterial materialLeft;

		[Token(Token = "0x400001A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public FmodResonanceAudioRoom.SurfaceMaterial materialRight;

		[Token(Token = "0x400001B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public FmodResonanceAudioRoom.SurfaceMaterial materialBottom;

		[Token(Token = "0x400001C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public FmodResonanceAudioRoom.SurfaceMaterial materialTop;

		[Token(Token = "0x400001D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public FmodResonanceAudioRoom.SurfaceMaterial materialFront;

		[Token(Token = "0x400001E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public FmodResonanceAudioRoom.SurfaceMaterial materialBack;

		[Token(Token = "0x400001F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float reflectionScalar;

		[Token(Token = "0x4000020")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float reverbGain;

		[Token(Token = "0x4000021")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float reverbTime;

		[Token(Token = "0x4000022")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public float reverbBrightness;
	}

	[Token(Token = "0x4000001")]
	public const float maxGainDb = 24f;

	[Token(Token = "0x4000002")]
	public const float minGainDb = -24f;

	[Token(Token = "0x4000003")]
	public const float maxReverbBrightness = 1f;

	[Token(Token = "0x4000004")]
	public const float minReverbBrightness = -1f;

	[Token(Token = "0x4000005")]
	public const float maxReverbTime = 3f;

	[Token(Token = "0x4000006")]
	public const float maxReflectivity = 2f;

	[Token(Token = "0x4000007")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static readonly Matrix4x4 flipZ;

	[Token(Token = "0x4000008")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private static readonly string listenerPluginName;

	[Token(Token = "0x4000009")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private static readonly int roomPropertiesSize;

	[Token(Token = "0x400000A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	private static readonly int roomPropertiesIndex;

	[Token(Token = "0x400000B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private static Bounds bounds;

	[Token(Token = "0x400000C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private static List<FmodResonanceAudioRoom> enabledRooms;

	[Token(Token = "0x400000D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private static VECTOR listenerPositionFmod;

	[Token(Token = "0x400000E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private static DSP listenerPlugin;

	[Token(Token = "0x17000001")]
	private static DSP ListenerPlugin
	{
		[Token(Token = "0x6000003")]
		[Address(RVA = "0xC3447C", Offset = "0xC3447C", VA = "0xC3447C")]
		get
		{
			return default(DSP);
		}
	}

	[Token(Token = "0x6000001")]
	[Address(RVA = "0xC34020", Offset = "0xC34020", VA = "0xC34020")]
	public static void UpdateAudioRoom(FmodResonanceAudioRoom room, bool roomEnabled)
	{
	}

	[Token(Token = "0x6000002")]
	[Address(RVA = "0xC3461C", Offset = "0xC3461C", VA = "0xC3461C")]
	public static bool IsListenerInsideRoom(FmodResonanceAudioRoom room)
	{
		return default(bool);
	}

	[Token(Token = "0x6000004")]
	[Address(RVA = "0xC34C18", Offset = "0xC34C18", VA = "0xC34C18")]
	private static float ConvertAmplitudeFromDb(float db)
	{
		return default(float);
	}

	[Token(Token = "0x6000005")]
	[Address(RVA = "0xC34C2C", Offset = "0xC34C2C", VA = "0xC34C2C")]
	private static void ConvertAudioTransformFromUnity(ref Vector3 position, ref Quaternion rotation)
	{
	}

	[Token(Token = "0x6000006")]
	[Address(RVA = "0xC34538", Offset = "0xC34538", VA = "0xC34538")]
	private static byte[] GetBytes(IntPtr ptr, int length)
	{
		return null;
	}

	[Token(Token = "0x6000007")]
	[Address(RVA = "0xC34300", Offset = "0xC34300", VA = "0xC34300")]
	private static RoomProperties GetRoomProperties(FmodResonanceAudioRoom room)
	{
		return default(RoomProperties);
	}

	[Token(Token = "0x6000008")]
	[Address(RVA = "0xC34870", Offset = "0xC34870", VA = "0xC34870")]
	private static DSP Initialize()
	{
		return default(DSP);
	}
}
[Token(Token = "0x2000004")]
[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x918A44", Offset = "0x918A44")]
public class FmodResonanceAudioRoom : MonoBehaviour
{
	[Token(Token = "0x2000005")]
	public enum SurfaceMaterial
	{
		[Token(Token = "0x400002F")]
		Transparent,
		[Token(Token = "0x4000030")]
		AcousticCeilingTiles,
		[Token(Token = "0x4000031")]
		BrickBare,
		[Token(Token = "0x4000032")]
		BrickPainted,
		[Token(Token = "0x4000033")]
		ConcreteBlockCoarse,
		[Token(Token = "0x4000034")]
		ConcreteBlockPainted,
		[Token(Token = "0x4000035")]
		CurtainHeavy,
		[Token(Token = "0x4000036")]
		FiberglassInsulation,
		[Token(Token = "0x4000037")]
		GlassThin,
		[Token(Token = "0x4000038")]
		GlassThick,
		[Token(Token = "0x4000039")]
		Grass,
		[Token(Token = "0x400003A")]
		LinoleumOnConcrete,
		[Token(Token = "0x400003B")]
		Marble,
		[Token(Token = "0x400003C")]
		Metal,
		[Token(Token = "0x400003D")]
		ParquetOnConcrete,
		[Token(Token = "0x400003E")]
		PlasterRough,
		[Token(Token = "0x400003F")]
		PlasterSmooth,
		[Token(Token = "0x4000040")]
		PlywoodPanel,
		[Token(Token = "0x4000041")]
		PolishedConcreteOrTile,
		[Token(Token = "0x4000042")]
		Sheetrock,
		[Token(Token = "0x4000043")]
		WaterOrIceSurface,
		[Token(Token = "0x4000044")]
		WoodCeiling,
		[Token(Token = "0x4000045")]
		WoodPanel
	}

	[Token(Token = "0x4000023")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public SurfaceMaterial leftWall;

	[Token(Token = "0x4000024")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public SurfaceMaterial rightWall;

	[Token(Token = "0x4000025")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public SurfaceMaterial floor;

	[Token(Token = "0x4000026")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public SurfaceMaterial ceiling;

	[Token(Token = "0x4000027")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public SurfaceMaterial backWall;

	[Token(Token = "0x4000028")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public SurfaceMaterial frontWall;

	[Token(Token = "0x4000029")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public float reflectivity;

	[Token(Token = "0x400002A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public float reverbGainDb;

	[Token(Token = "0x400002B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public float reverbBrightness;

	[Token(Token = "0x400002C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public float reverbTime;

	[Token(Token = "0x400002D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Vector3 size;

	[Token(Token = "0x600000A")]
	[Address(RVA = "0xC35074", Offset = "0xC35074", VA = "0xC35074")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x600000B")]
	[Address(RVA = "0xC350E0", Offset = "0xC350E0", VA = "0xC350E0")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x600000C")]
	[Address(RVA = "0xC35144", Offset = "0xC35144", VA = "0xC35144")]
	private void Update()
	{
	}

	[Token(Token = "0x600000D")]
	[Address(RVA = "0xC351B0", Offset = "0xC351B0", VA = "0xC351B0")]
	private void OnDrawGizmosSelected()
	{
	}

	[Token(Token = "0x600000E")]
	[Address(RVA = "0xC35238", Offset = "0xC35238", VA = "0xC35238")]
	public FmodResonanceAudioRoom()
	{
	}
}
[Serializable]
[Token(Token = "0x2000006")]
public class FMODEventPlayable : PlayableAsset, ITimelineClipAsset
{
	[Token(Token = "0x4000046")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public FMODEventPlayableBehavior template;

	[Token(Token = "0x4000047")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x918E08", Offset = "0x918E08")]
	private GameObject <TrackTargetObject>k__BackingField;

	[Token(Token = "0x4000048")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float eventLength;

	[Token(Token = "0x4000049")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private FMODEventPlayableBehavior behavior;

	[Token(Token = "0x400004A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[SerializeField]
	[EventRef]
	public string eventName;

	[Token(Token = "0x400004B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[SerializeField]
	public STOP_MODE stopType;

	[Token(Token = "0x400004C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[SerializeField]
	public ParamRef[] parameters;

	[NonSerialized]
	[Token(Token = "0x400004D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public bool cachedParameters;

	[Token(Token = "0x400004E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x918E70", Offset = "0x918E70")]
	private TimelineClip <OwningClip>k__BackingField;

	[Token(Token = "0x17000002")]
	public GameObject TrackTargetObject
	{
		[Token(Token = "0x600000F")]
		[Address(RVA = "0xC32C50", Offset = "0xC32C50", VA = "0xC32C50")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x919060", Offset = "0x919060")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000010")]
		[Address(RVA = "0xC32C58", Offset = "0xC32C58", VA = "0xC32C58")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x919070", Offset = "0x919070")]
		set
		{
		}
	}

	[Token(Token = "0x17000003")]
	public override double duration
	{
		[Token(Token = "0x6000011")]
		[Address(RVA = "0xC32C60", Offset = "0xC32C60", VA = "0xC32C60", Slot = "7")]
		get
		{
			return default(double);
		}
	}

	[Token(Token = "0x17000004")]
	public ClipCaps clipCaps
	{
		[Token(Token = "0x6000012")]
		[Address(RVA = "0xC32C7C", Offset = "0xC32C7C", VA = "0xC32C7C", Slot = "9")]
		get
		{
			return default(ClipCaps);
		}
	}

	[Token(Token = "0x17000005")]
	public TimelineClip OwningClip
	{
		[Token(Token = "0x6000013")]
		[Address(RVA = "0xC32C84", Offset = "0xC32C84", VA = "0xC32C84")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x919080", Offset = "0x919080")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000014")]
		[Address(RVA = "0xC32C8C", Offset = "0xC32C8C", VA = "0xC32C8C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x919090", Offset = "0x919090")]
		set
		{
		}
	}

	[Token(Token = "0x6000015")]
	[Address(RVA = "0xC32C94", Offset = "0xC32C94", VA = "0xC32C94", Slot = "6")]
	public override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
	{
		return default(Playable);
	}

	[Token(Token = "0x6000016")]
	[Address(RVA = "0xC32F3C", Offset = "0xC32F3C", VA = "0xC32F3C")]
	public FMODEventPlayable()
	{
	}
}
[Token(Token = "0x2000007")]
public enum STOP_MODE
{
	[Token(Token = "0x4000050")]
	AllowFadeout,
	[Token(Token = "0x4000051")]
	Immediate,
	[Token(Token = "0x4000052")]
	None
}
[Token(Token = "0x2000008")]
public class FMODEventPlayableBehavior : PlayableBehaviour
{
	[Token(Token = "0x4000053")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public string eventName;

	[Token(Token = "0x4000054")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public STOP_MODE stopType;

	[Token(Token = "0x4000055")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public ParamRef[] parameters;

	[Token(Token = "0x4000056")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public GameObject TrackTargetObject;

	[Token(Token = "0x4000057")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public TimelineClip OwningClip;

	[Token(Token = "0x4000058")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private bool isPlayheadInside;

	[Token(Token = "0x4000059")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private EventInstance eventInstance;

	[Token(Token = "0x6000017")]
	[Address(RVA = "0xC3301C", Offset = "0xC3301C", VA = "0xC3301C")]
	protected void PlayEvent()
	{
	}

	[Token(Token = "0x6000018")]
	[Address(RVA = "0xC337C8", Offset = "0xC337C8", VA = "0xC337C8")]
	public void OnEnter()
	{
	}

	[Token(Token = "0x6000019")]
	[Address(RVA = "0xC337FC", Offset = "0xC337FC", VA = "0xC337FC")]
	public void OnExit()
	{
	}

	[Token(Token = "0x600001A")]
	[Address(RVA = "0xC32BCC", Offset = "0xC32BCC", VA = "0xC32BCC")]
	public void UpdateBehaviour(float time)
	{
	}

	[Token(Token = "0x600001B")]
	[Address(RVA = "0xC33858", Offset = "0xC33858", VA = "0xC33858", Slot = "14")]
	public override void OnGraphStop(Playable playable)
	{
	}

	[Token(Token = "0x600001C")]
	[Address(RVA = "0xC32FC0", Offset = "0xC32FC0", VA = "0xC32FC0")]
	public FMODEventPlayableBehavior()
	{
	}
}
[Token(Token = "0x2000009")]
[AttributeAttribute(Name = "TrackColorAttribute", RVA = "0x918A7C", Offset = "0x918A7C")]
[AttributeAttribute(Name = "TrackClipTypeAttribute", RVA = "0x918A7C", Offset = "0x918A7C")]
[AttributeAttribute(Name = "TrackBindingTypeAttribute", RVA = "0x918A7C", Offset = "0x918A7C")]
public class FMODEventTrack : TrackAsset
{
	[Token(Token = "0x600001D")]
	[Address(RVA = "0xC338FC", Offset = "0xC338FC", VA = "0xC338FC", Slot = "23")]
	public override Playable CreateTrackMixer(PlayableGraph graph, GameObject go, int inputCount)
	{
		return default(Playable);
	}

	[Token(Token = "0x600001E")]
	[Address(RVA = "0xC33D7C", Offset = "0xC33D7C", VA = "0xC33D7C")]
	public FMODEventTrack()
	{
	}
}
[Token(Token = "0x200000A")]
public class FMODEventMixerBehaviour : PlayableBehaviour
{
	[Token(Token = "0x600001F")]
	[Address(RVA = "0xC32A14", Offset = "0xC32A14", VA = "0xC32A14", Slot = "20")]
	public override void ProcessFrame(Playable playable, FrameData info, object playerData)
	{
	}

	[Token(Token = "0x6000020")]
	[Address(RVA = "0xC32C48", Offset = "0xC32C48", VA = "0xC32C48")]
	public FMODEventMixerBehaviour()
	{
	}
}
namespace FMOD
{
	[Token(Token = "0x200000B")]
	public class VERSION
	{
		[Token(Token = "0x400005A")]
		public const int number = 131088;

		[Token(Token = "0x400005B")]
		public const string dll = "fmod";

		[Token(Token = "0x6000021")]
		[Address(RVA = "0x1E4A638", Offset = "0x1E4A638", VA = "0x1E4A638")]
		public VERSION()
		{
		}
	}
	[Token(Token = "0x200000C")]
	public class CONSTANTS
	{
		[Token(Token = "0x400005C")]
		public const int MAX_CHANNEL_WIDTH = 32;

		[Token(Token = "0x400005D")]
		public const int MAX_LISTENERS = 8;

		[Token(Token = "0x400005E")]
		public const int REVERB_MAXINSTANCES = 4;

		[Token(Token = "0x400005F")]
		public const int MAX_SYSTEMS = 8;

		[Token(Token = "0x6000022")]
		[Address(RVA = "0xC1A580", Offset = "0xC1A580", VA = "0xC1A580")]
		public CONSTANTS()
		{
		}
	}
	[Token(Token = "0x200000D")]
	public enum RESULT
	{
		[Token(Token = "0x4000061")]
		OK,
		[Token(Token = "0x4000062")]
		ERR_BADCOMMAND,
		[Token(Token = "0x4000063")]
		ERR_CHANNEL_ALLOC,
		[Token(Token = "0x4000064")]
		ERR_CHANNEL_STOLEN,
		[Token(Token = "0x4000065")]
		ERR_DMA,
		[Token(Token = "0x4000066")]
		ERR_DSP_CONNECTION,
		[Token(Token = "0x4000067")]
		ERR_DSP_DONTPROCESS,
		[Token(Token = "0x4000068")]
		ERR_DSP_FORMAT,
		[Token(Token = "0x4000069")]
		ERR_DSP_INUSE,
		[Token(Token = "0x400006A")]
		ERR_DSP_NOTFOUND,
		[Token(Token = "0x400006B")]
		ERR_DSP_RESERVED,
		[Token(Token = "0x400006C")]
		ERR_DSP_SILENCE,
		[Token(Token = "0x400006D")]
		ERR_DSP_TYPE,
		[Token(Token = "0x400006E")]
		ERR_FILE_BAD,
		[Token(Token = "0x400006F")]
		ERR_FILE_COULDNOTSEEK,
		[Token(Token = "0x4000070")]
		ERR_FILE_DISKEJECTED,
		[Token(Token = "0x4000071")]
		ERR_FILE_EOF,
		[Token(Token = "0x4000072")]
		ERR_FILE_ENDOFDATA,
		[Token(Token = "0x4000073")]
		ERR_FILE_NOTFOUND,
		[Token(Token = "0x4000074")]
		ERR_FORMAT,
		[Token(Token = "0x4000075")]
		ERR_HEADER_MISMATCH,
		[Token(Token = "0x4000076")]
		ERR_HTTP,
		[Token(Token = "0x4000077")]
		ERR_HTTP_ACCESS,
		[Token(Token = "0x4000078")]
		ERR_HTTP_PROXY_AUTH,
		[Token(Token = "0x4000079")]
		ERR_HTTP_SERVER_ERROR,
		[Token(Token = "0x400007A")]
		ERR_HTTP_TIMEOUT,
		[Token(Token = "0x400007B")]
		ERR_INITIALIZATION,
		[Token(Token = "0x400007C")]
		ERR_INITIALIZED,
		[Token(Token = "0x400007D")]
		ERR_INTERNAL,
		[Token(Token = "0x400007E")]
		ERR_INVALID_FLOAT,
		[Token(Token = "0x400007F")]
		ERR_INVALID_HANDLE,
		[Token(Token = "0x4000080")]
		ERR_INVALID_PARAM,
		[Token(Token = "0x4000081")]
		ERR_INVALID_POSITION,
		[Token(Token = "0x4000082")]
		ERR_INVALID_SPEAKER,
		[Token(Token = "0x4000083")]
		ERR_INVALID_SYNCPOINT,
		[Token(Token = "0x4000084")]
		ERR_INVALID_THREAD,
		[Token(Token = "0x4000085")]
		ERR_INVALID_VECTOR,
		[Token(Token = "0x4000086")]
		ERR_MAXAUDIBLE,
		[Token(Token = "0x4000087")]
		ERR_MEMORY,
		[Token(Token = "0x4000088")]
		ERR_MEMORY_CANTPOINT,
		[Token(Token = "0x4000089")]
		ERR_NEEDS3D,
		[Token(Token = "0x400008A")]
		ERR_NEEDSHARDWARE,
		[Token(Token = "0x400008B")]
		ERR_NET_CONNECT,
		[Token(Token = "0x400008C")]
		ERR_NET_SOCKET_ERROR,
		[Token(Token = "0x400008D")]
		ERR_NET_URL,
		[Token(Token = "0x400008E")]
		ERR_NET_WOULD_BLOCK,
		[Token(Token = "0x400008F")]
		ERR_NOTREADY,
		[Token(Token = "0x4000090")]
		ERR_OUTPUT_ALLOCATED,
		[Token(Token = "0x4000091")]
		ERR_OUTPUT_CREATEBUFFER,
		[Token(Token = "0x4000092")]
		ERR_OUTPUT_DRIVERCALL,
		[Token(Token = "0x4000093")]
		ERR_OUTPUT_FORMAT,
		[Token(Token = "0x4000094")]
		ERR_OUTPUT_INIT,
		[Token(Token = "0x4000095")]
		ERR_OUTPUT_NODRIVERS,
		[Token(Token = "0x4000096")]
		ERR_PLUGIN,
		[Token(Token = "0x4000097")]
		ERR_PLUGIN_MISSING,
		[Token(Token = "0x4000098")]
		ERR_PLUGIN_RESOURCE,
		[Token(Token = "0x4000099")]
		ERR_PLUGIN_VERSION,
		[Token(Token = "0x400009A")]
		ERR_RECORD,
		[Token(Token = "0x400009B")]
		ERR_REVERB_CHANNELGROUP,
		[Token(Token = "0x400009C")]
		ERR_REVERB_INSTANCE,
		[Token(Token = "0x400009D")]
		ERR_SUBSOUNDS,
		[Token(Token = "0x400009E")]
		ERR_SUBSOUND_ALLOCATED,
		[Token(Token = "0x400009F")]
		ERR_SUBSOUND_CANTMOVE,
		[Token(Token = "0x40000A0")]
		ERR_TAGNOTFOUND,
		[Token(Token = "0x40000A1")]
		ERR_TOOMANYCHANNELS,
		[Token(Token = "0x40000A2")]
		ERR_TRUNCATED,
		[Token(Token = "0x40000A3")]
		ERR_UNIMPLEMENTED,
		[Token(Token = "0x40000A4")]
		ERR_UNINITIALIZED,
		[Token(Token = "0x40000A5")]
		ERR_UNSUPPORTED,
		[Token(Token = "0x40000A6")]
		ERR_VERSION,
		[Token(Token = "0x40000A7")]
		ERR_EVENT_ALREADY_LOADED,
		[Token(Token = "0x40000A8")]
		ERR_EVENT_LIVEUPDATE_BUSY,
		[Token(Token = "0x40000A9")]
		ERR_EVENT_LIVEUPDATE_MISMATCH,
		[Token(Token = "0x40000AA")]
		ERR_EVENT_LIVEUPDATE_TIMEOUT,
		[Token(Token = "0x40000AB")]
		ERR_EVENT_NOTFOUND,
		[Token(Token = "0x40000AC")]
		ERR_STUDIO_UNINITIALIZED,
		[Token(Token = "0x40000AD")]
		ERR_STUDIO_NOT_LOADED,
		[Token(Token = "0x40000AE")]
		ERR_INVALID_STRING,
		[Token(Token = "0x40000AF")]
		ERR_ALREADY_LOCKED,
		[Token(Token = "0x40000B0")]
		ERR_NOT_LOCKED,
		[Token(Token = "0x40000B1")]
		ERR_RECORD_DISCONNECTED,
		[Token(Token = "0x40000B2")]
		ERR_TOOMANYSAMPLES
	}
	[Token(Token = "0x200000E")]
	public enum CHANNELCONTROL_TYPE
	{
		[Token(Token = "0x40000B4")]
		CHANNEL,
		[Token(Token = "0x40000B5")]
		CHANNELGROUP,
		[Token(Token = "0x40000B6")]
		MAX
	}
	[Token(Token = "0x200000F")]
	public struct VECTOR
	{
		[Token(Token = "0x40000B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float x;

		[Token(Token = "0x40000B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public float y;

		[Token(Token = "0x40000B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public float z;
	}
	[Token(Token = "0x2000010")]
	public struct ATTRIBUTES_3D
	{
		[Token(Token = "0x40000BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public VECTOR position;

		[Token(Token = "0x40000BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public VECTOR velocity;

		[Token(Token = "0x40000BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public VECTOR forward;

		[Token(Token = "0x40000BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public VECTOR up;
	}
	[Token(Token = "0x2000011")]
	public struct ASYNCREADINFO
	{
		[Token(Token = "0x40000BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public IntPtr handle;

		[Token(Token = "0x40000BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public uint offset;

		[Token(Token = "0x40000C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public uint sizebytes;

		[Token(Token = "0x40000C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int priority;

		[Token(Token = "0x40000C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public IntPtr userdata;

		[Token(Token = "0x40000C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public IntPtr buffer;

		[Token(Token = "0x40000C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public uint bytesread;

		[Token(Token = "0x40000C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public FILE_ASYNCDONE_FUNC done;
	}
	[Token(Token = "0x2000012")]
	public enum OUTPUTTYPE
	{
		[Token(Token = "0x40000C7")]
		AUTODETECT,
		[Token(Token = "0x40000C8")]
		UNKNOWN,
		[Token(Token = "0x40000C9")]
		NOSOUND,
		[Token(Token = "0x40000CA")]
		WAVWRITER,
		[Token(Token = "0x40000CB")]
		NOSOUND_NRT,
		[Token(Token = "0x40000CC")]
		WAVWRITER_NRT,
		[Token(Token = "0x40000CD")]
		WASAPI,
		[Token(Token = "0x40000CE")]
		ASIO,
		[Token(Token = "0x40000CF")]
		PULSEAUDIO,
		[Token(Token = "0x40000D0")]
		ALSA,
		[Token(Token = "0x40000D1")]
		COREAUDIO,
		[Token(Token = "0x40000D2")]
		AUDIOTRACK,
		[Token(Token = "0x40000D3")]
		OPENSL,
		[Token(Token = "0x40000D4")]
		AUDIOOUT,
		[Token(Token = "0x40000D5")]
		AUDIO3D,
		[Token(Token = "0x40000D6")]
		WEBAUDIO,
		[Token(Token = "0x40000D7")]
		NNAUDIO,
		[Token(Token = "0x40000D8")]
		WINSONIC,
		[Token(Token = "0x40000D9")]
		AAUDIO,
		[Token(Token = "0x40000DA")]
		MAX
	}
	[Token(Token = "0x2000013")]
	public enum DEBUG_MODE
	{
		[Token(Token = "0x40000DC")]
		TTY,
		[Token(Token = "0x40000DD")]
		FILE,
		[Token(Token = "0x40000DE")]
		CALLBACK
	}
	[Token(Token = "0x2000014")]
	[Flags]
	public enum DEBUG_FLAGS : uint
	{
		[Token(Token = "0x40000E0")]
		NONE = 0u,
		[Token(Token = "0x40000E1")]
		ERROR = 1u,
		[Token(Token = "0x40000E2")]
		WARNING = 2u,
		[Token(Token = "0x40000E3")]
		LOG = 4u,
		[Token(Token = "0x40000E4")]
		TYPE_MEMORY = 0x100u,
		[Token(Token = "0x40000E5")]
		TYPE_FILE = 0x200u,
		[Token(Token = "0x40000E6")]
		TYPE_CODEC = 0x400u,
		[Token(Token = "0x40000E7")]
		TYPE_TRACE = 0x800u,
		[Token(Token = "0x40000E8")]
		DISPLAY_TIMESTAMPS = 0x10000u,
		[Token(Token = "0x40000E9")]
		DISPLAY_LINENUMBERS = 0x20000u,
		[Token(Token = "0x40000EA")]
		DISPLAY_THREAD = 0x40000u
	}
	[Token(Token = "0x2000015")]
	[Flags]
	public enum MEMORY_TYPE : uint
	{
		[Token(Token = "0x40000EC")]
		NORMAL = 0u,
		[Token(Token = "0x40000ED")]
		STREAM_FILE = 1u,
		[Token(Token = "0x40000EE")]
		STREAM_DECODE = 2u,
		[Token(Token = "0x40000EF")]
		SAMPLEDATA = 4u,
		[Token(Token = "0x40000F0")]
		DSP_BUFFER = 8u,
		[Token(Token = "0x40000F1")]
		PLUGIN = 0x10u,
		[Token(Token = "0x40000F2")]
		PERSISTENT = 0x200000u,
		[Token(Token = "0x40000F3")]
		ALL = uint.MaxValue
	}
	[Token(Token = "0x2000016")]
	public enum SPEAKERMODE
	{
		[Token(Token = "0x40000F5")]
		DEFAULT,
		[Token(Token = "0x40000F6")]
		RAW,
		[Token(Token = "0x40000F7")]
		MONO,
		[Token(Token = "0x40000F8")]
		STEREO,
		[Token(Token = "0x40000F9")]
		QUAD,
		[Token(Token = "0x40000FA")]
		SURROUND,
		[Token(Token = "0x40000FB")]
		_5POINT1,
		[Token(Token = "0x40000FC")]
		_7POINT1,
		[Token(Token = "0x40000FD")]
		_7POINT1POINT4,
		[Token(Token = "0x40000FE")]
		MAX
	}
	[Token(Token = "0x2000017")]
	public enum SPEAKER
	{
		[Token(Token = "0x4000100")]
		NONE = -1,
		[Token(Token = "0x4000101")]
		FRONT_LEFT,
		[Token(Token = "0x4000102")]
		FRONT_RIGHT,
		[Token(Token = "0x4000103")]
		FRONT_CENTER,
		[Token(Token = "0x4000104")]
		LOW_FREQUENCY,
		[Token(Token = "0x4000105")]
		SURROUND_LEFT,
		[Token(Token = "0x4000106")]
		SURROUND_RIGHT,
		[Token(Token = "0x4000107")]
		BACK_LEFT,
		[Token(Token = "0x4000108")]
		BACK_RIGHT,
		[Token(Token = "0x4000109")]
		TOP_FRONT_LEFT,
		[Token(Token = "0x400010A")]
		TOP_FRONT_RIGHT,
		[Token(Token = "0x400010B")]
		TOP_BACK_LEFT,
		[Token(Token = "0x400010C")]
		TOP_BACK_RIGHT,
		[Token(Token = "0x400010D")]
		MAX
	}
	[Token(Token = "0x2000018")]
	[Flags]
	public enum CHANNELMASK : uint
	{
		[Token(Token = "0x400010F")]
		FRONT_LEFT = 1u,
		[Token(Token = "0x4000110")]
		FRONT_RIGHT = 2u,
		[Token(Token = "0x4000111")]
		FRONT_CENTER = 4u,
		[Token(Token = "0x4000112")]
		LOW_FREQUENCY = 8u,
		[Token(Token = "0x4000113")]
		SURROUND_LEFT = 0x10u,
		[Token(Token = "0x4000114")]
		SURROUND_RIGHT = 0x20u,
		[Token(Token = "0x4000115")]
		BACK_LEFT = 0x40u,
		[Token(Token = "0x4000116")]
		BACK_RIGHT = 0x80u,
		[Token(Token = "0x4000117")]
		BACK_CENTER = 0x100u,
		[Token(Token = "0x4000118")]
		MONO = 1u,
		[Token(Token = "0x4000119")]
		STEREO = 3u,
		[Token(Token = "0x400011A")]
		LRC = 7u,
		[Token(Token = "0x400011B")]
		QUAD = 0x33u,
		[Token(Token = "0x400011C")]
		SURROUND = 0x37u,
		[Token(Token = "0x400011D")]
		_5POINT1 = 0x3Fu,
		[Token(Token = "0x400011E")]
		_5POINT1_REARS = 0xCFu,
		[Token(Token = "0x400011F")]
		_7POINT0 = 0xF7u,
		[Token(Token = "0x4000120")]
		_7POINT1 = 0xFFu
	}
	[Token(Token = "0x2000019")]
	public enum CHANNELORDER
	{
		[Token(Token = "0x4000122")]
		DEFAULT,
		[Token(Token = "0x4000123")]
		WAVEFORMAT,
		[Token(Token = "0x4000124")]
		PROTOOLS,
		[Token(Token = "0x4000125")]
		ALLMONO,
		[Token(Token = "0x4000126")]
		ALLSTEREO,
		[Token(Token = "0x4000127")]
		ALSA,
		[Token(Token = "0x4000128")]
		MAX
	}
	[Token(Token = "0x200001A")]
	public enum PLUGINTYPE
	{
		[Token(Token = "0x400012A")]
		OUTPUT,
		[Token(Token = "0x400012B")]
		CODEC,
		[Token(Token = "0x400012C")]
		DSP,
		[Token(Token = "0x400012D")]
		MAX
	}
	[Token(Token = "0x200001B")]
	public struct PLUGINLIST
	{
		[Token(Token = "0x400012E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private PLUGINTYPE type;

		[Token(Token = "0x400012F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private IntPtr description;
	}
	[Token(Token = "0x200001C")]
	[Flags]
	public enum INITFLAGS : uint
	{
		[Token(Token = "0x4000131")]
		NORMAL = 0u,
		[Token(Token = "0x4000132")]
		STREAM_FROM_UPDATE = 1u,
		[Token(Token = "0x4000133")]
		MIX_FROM_UPDATE = 2u,
		[Token(Token = "0x4000134")]
		_3D_RIGHTHANDED = 4u,
		[Token(Token = "0x4000135")]
		CHANNEL_LOWPASS = 0x100u,
		[Token(Token = "0x4000136")]
		CHANNEL_DISTANCEFILTER = 0x200u,
		[Token(Token = "0x4000137")]
		PROFILE_ENABLE = 0x10000u,
		[Token(Token = "0x4000138")]
		VOL0_BECOMES_VIRTUAL = 0x20000u,
		[Token(Token = "0x4000139")]
		GEOMETRY_USECLOSEST = 0x40000u,
		[Token(Token = "0x400013A")]
		PREFER_DOLBY_DOWNMIX = 0x80000u,
		[Token(Token = "0x400013B")]
		THREAD_UNSAFE = 0x100000u,
		[Token(Token = "0x400013C")]
		PROFILE_METER_ALL = 0x200000u,
		[Token(Token = "0x400013D")]
		MEMORY_TRACKING = 0x400000u
	}
	[Token(Token = "0x200001D")]
	public enum SOUND_TYPE
	{
		[Token(Token = "0x400013F")]
		UNKNOWN,
		[Token(Token = "0x4000140")]
		AIFF,
		[Token(Token = "0x4000141")]
		ASF,
		[Token(Token = "0x4000142")]
		DLS,
		[Token(Token = "0x4000143")]
		FLAC,
		[Token(Token = "0x4000144")]
		FSB,
		[Token(Token = "0x4000145")]
		IT,
		[Token(Token = "0x4000146")]
		MIDI,
		[Token(Token = "0x4000147")]
		MOD,
		[Token(Token = "0x4000148")]
		MPEG,
		[Token(Token = "0x4000149")]
		OGGVORBIS,
		[Token(Token = "0x400014A")]
		PLAYLIST,
		[Token(Token = "0x400014B")]
		RAW,
		[Token(Token = "0x400014C")]
		S3M,
		[Token(Token = "0x400014D")]
		USER,
		[Token(Token = "0x400014E")]
		WAV,
		[Token(Token = "0x400014F")]
		XM,
		[Token(Token = "0x4000150")]
		XMA,
		[Token(Token = "0x4000151")]
		AUDIOQUEUE,
		[Token(Token = "0x4000152")]
		AT9,
		[Token(Token = "0x4000153")]
		VORBIS,
		[Token(Token = "0x4000154")]
		MEDIA_FOUNDATION,
		[Token(Token = "0x4000155")]
		MEDIACODEC,
		[Token(Token = "0x4000156")]
		FADPCM,
		[Token(Token = "0x4000157")]
		OPUS,
		[Token(Token = "0x4000158")]
		MAX
	}
	[Token(Token = "0x200001E")]
	public enum SOUND_FORMAT
	{
		[Token(Token = "0x400015A")]
		NONE,
		[Token(Token = "0x400015B")]
		PCM8,
		[Token(Token = "0x400015C")]
		PCM16,
		[Token(Token = "0x400015D")]
		PCM24,
		[Token(Token = "0x400015E")]
		PCM32,
		[Token(Token = "0x400015F")]
		PCMFLOAT,
		[Token(Token = "0x4000160")]
		BITSTREAM,
		[Token(Token = "0x4000161")]
		MAX
	}
	[Token(Token = "0x200001F")]
	[Flags]
	public enum MODE : uint
	{
		[Token(Token = "0x4000163")]
		DEFAULT = 0u,
		[Token(Token = "0x4000164")]
		LOOP_OFF = 1u,
		[Token(Token = "0x4000165")]
		LOOP_NORMAL = 2u,
		[Token(Token = "0x4000166")]
		LOOP_BIDI = 4u,
		[Token(Token = "0x4000167")]
		_2D = 8u,
		[Token(Token = "0x4000168")]
		_3D = 0x10u,
		[Token(Token = "0x4000169")]
		CREATESTREAM = 0x80u,
		[Token(Token = "0x400016A")]
		CREATESAMPLE = 0x100u,
		[Token(Token = "0x400016B")]
		CREATECOMPRESSEDSAMPLE = 0x200u,
		[Token(Token = "0x400016C")]
		OPENUSER = 0x400u,
		[Token(Token = "0x400016D")]
		OPENMEMORY = 0x800u,
		[Token(Token = "0x400016E")]
		OPENMEMORY_POINT = 0x10000000u,
		[Token(Token = "0x400016F")]
		OPENRAW = 0x1000u,
		[Token(Token = "0x4000170")]
		OPENONLY = 0x2000u,
		[Token(Token = "0x4000171")]
		ACCURATETIME = 0x4000u,
		[Token(Token = "0x4000172")]
		MPEGSEARCH = 0x8000u,
		[Token(Token = "0x4000173")]
		NONBLOCKING = 0x10000u,
		[Token(Token = "0x4000174")]
		UNIQUE = 0x20000u,
		[Token(Token = "0x4000175")]
		_3D_HEADRELATIVE = 0x40000u,
		[Token(Token = "0x4000176")]
		_3D_WORLDRELATIVE = 0x80000u,
		[Token(Token = "0x4000177")]
		_3D_INVERSEROLLOFF = 0x100000u,
		[Token(Token = "0x4000178")]
		_3D_LINEARROLLOFF = 0x200000u,
		[Token(Token = "0x4000179")]
		_3D_LINEARSQUAREROLLOFF = 0x400000u,
		[Token(Token = "0x400017A")]
		_3D_INVERSETAPEREDROLLOFF = 0x800000u,
		[Token(Token = "0x400017B")]
		_3D_CUSTOMROLLOFF = 0x4000000u,
		[Token(Token = "0x400017C")]
		_3D_IGNOREGEOMETRY = 0x40000000u,
		[Token(Token = "0x400017D")]
		IGNORETAGS = 0x2000000u,
		[Token(Token = "0x400017E")]
		LOWMEM = 0x8000000u,
		[Token(Token = "0x400017F")]
		VIRTUAL_PLAYFROMSTART = 0x80000000u
	}
	[Token(Token = "0x2000020")]
	public enum OPENSTATE
	{
		[Token(Token = "0x4000181")]
		READY,
		[Token(Token = "0x4000182")]
		LOADING,
		[Token(Token = "0x4000183")]
		ERROR,
		[Token(Token = "0x4000184")]
		CONNECTING,
		[Token(Token = "0x4000185")]
		BUFFERING,
		[Token(Token = "0x4000186")]
		SEEKING,
		[Token(Token = "0x4000187")]
		PLAYING,
		[Token(Token = "0x4000188")]
		SETPOSITION,
		[Token(Token = "0x4000189")]
		MAX
	}
	[Token(Token = "0x2000021")]
	public enum SOUNDGROUP_BEHAVIOR
	{
		[Token(Token = "0x400018B")]
		BEHAVIOR_FAIL,
		[Token(Token = "0x400018C")]
		BEHAVIOR_MUTE,
		[Token(Token = "0x400018D")]
		BEHAVIOR_STEALLOWEST,
		[Token(Token = "0x400018E")]
		MAX
	}
	[Token(Token = "0x2000022")]
	public enum CHANNELCONTROL_CALLBACK_TYPE
	{
		[Token(Token = "0x4000190")]
		END,
		[Token(Token = "0x4000191")]
		VIRTUALVOICE,
		[Token(Token = "0x4000192")]
		SYNCPOINT,
		[Token(Token = "0x4000193")]
		OCCLUSION,
		[Token(Token = "0x4000194")]
		MAX
	}
	[Token(Token = "0x2000023")]
	public struct CHANNELCONTROL_DSP_INDEX
	{
		[Token(Token = "0x4000195")]
		public const int HEAD = -1;

		[Token(Token = "0x4000196")]
		public const int FADER = -2;

		[Token(Token = "0x4000197")]
		public const int TAIL = -3;
	}
	[Token(Token = "0x2000024")]
	public enum ERRORCALLBACK_INSTANCETYPE
	{
		[Token(Token = "0x4000199")]
		NONE,
		[Token(Token = "0x400019A")]
		SYSTEM,
		[Token(Token = "0x400019B")]
		CHANNEL,
		[Token(Token = "0x400019C")]
		CHANNELGROUP,
		[Token(Token = "0x400019D")]
		CHANNELCONTROL,
		[Token(Token = "0x400019E")]
		SOUND,
		[Token(Token = "0x400019F")]
		SOUNDGROUP,
		[Token(Token = "0x40001A0")]
		DSP,
		[Token(Token = "0x40001A1")]
		DSPCONNECTION,
		[Token(Token = "0x40001A2")]
		GEOMETRY,
		[Token(Token = "0x40001A3")]
		REVERB3D,
		[Token(Token = "0x40001A4")]
		STUDIO_SYSTEM,
		[Token(Token = "0x40001A5")]
		STUDIO_EVENTDESCRIPTION,
		[Token(Token = "0x40001A6")]
		STUDIO_EVENTINSTANCE,
		[Token(Token = "0x40001A7")]
		STUDIO_PARAMETERINSTANCE,
		[Token(Token = "0x40001A8")]
		STUDIO_BUS,
		[Token(Token = "0x40001A9")]
		STUDIO_VCA,
		[Token(Token = "0x40001AA")]
		STUDIO_BANK,
		[Token(Token = "0x40001AB")]
		STUDIO_COMMANDREPLAY
	}
	[Token(Token = "0x2000025")]
	public struct ERRORCALLBACK_INFO
	{
		[Token(Token = "0x40001AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public RESULT result;

		[Token(Token = "0x40001AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public ERRORCALLBACK_INSTANCETYPE instancetype;

		[Token(Token = "0x40001AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public IntPtr instance;

		[Token(Token = "0x40001AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public StringWrapper functionname;

		[Token(Token = "0x40001B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public StringWrapper functionparams;
	}
	[Token(Token = "0x2000026")]
	[Flags]
	public enum SYSTEM_CALLBACK_TYPE : uint
	{
		[Token(Token = "0x40001B2")]
		DEVICELISTCHANGED = 1u,
		[Token(Token = "0x40001B3")]
		DEVICELOST = 2u,
		[Token(Token = "0x40001B4")]
		MEMORYALLOCATIONFAILED = 4u,
		[Token(Token = "0x40001B5")]
		THREADCREATED = 8u,
		[Token(Token = "0x40001B6")]
		BADDSPCONNECTION = 0x10u,
		[Token(Token = "0x40001B7")]
		PREMIX = 0x20u,
		[Token(Token = "0x40001B8")]
		POSTMIX = 0x40u,
		[Token(Token = "0x40001B9")]
		ERROR = 0x80u,
		[Token(Token = "0x40001BA")]
		MIDMIX = 0x100u,
		[Token(Token = "0x40001BB")]
		THREADDESTROYED = 0x200u,
		[Token(Token = "0x40001BC")]
		PREUPDATE = 0x400u,
		[Token(Token = "0x40001BD")]
		POSTUPDATE = 0x800u,
		[Token(Token = "0x40001BE")]
		RECORDLISTCHANGED = 0x1000u,
		[Token(Token = "0x40001BF")]
		ALL = uint.MaxValue
	}
	[Token(Token = "0x2000027")]
	public delegate RESULT DEBUG_CALLBACK(DEBUG_FLAGS flags, StringWrapper file, int line, StringWrapper func, StringWrapper message);
	[Token(Token = "0x2000028")]
	public delegate RESULT SYSTEM_CALLBACK(IntPtr system, SYSTEM_CALLBACK_TYPE type, IntPtr commanddata1, IntPtr commanddata2, IntPtr userdata);
	[Token(Token = "0x2000029")]
	public delegate RESULT CHANNELCONTROL_CALLBACK(IntPtr channelcontrol, CHANNELCONTROL_TYPE controltype, CHANNELCONTROL_CALLBACK_TYPE callbacktype, IntPtr commanddata1, IntPtr commanddata2);
	[Token(Token = "0x200002A")]
	public delegate RESULT SOUND_NONBLOCK_CALLBACK(IntPtr sound, RESULT result);
	[Token(Token = "0x200002B")]
	public delegate RESULT SOUND_PCMREAD_CALLBACK(IntPtr sound, IntPtr data, uint datalen);
	[Token(Token = "0x200002C")]
	public delegate RESULT SOUND_PCMSETPOS_CALLBACK(IntPtr sound, int subsound, uint position, TIMEUNIT postype);
	[Token(Token = "0x200002D")]
	public delegate RESULT FILE_OPEN_CALLBACK(StringWrapper name, ref uint filesize, ref IntPtr handle, IntPtr userdata);
	[Token(Token = "0x200002E")]
	public delegate RESULT FILE_CLOSE_CALLBACK(IntPtr handle, IntPtr userdata);
	[Token(Token = "0x200002F")]
	public delegate RESULT FILE_READ_CALLBACK(IntPtr handle, IntPtr buffer, uint sizebytes, ref uint bytesread, IntPtr userdata);
	[Token(Token = "0x2000030")]
	public delegate RESULT FILE_SEEK_CALLBACK(IntPtr handle, uint pos, IntPtr userdata);
	[Token(Token = "0x2000031")]
	public delegate RESULT FILE_ASYNCREAD_CALLBACK(IntPtr info, IntPtr userdata);
	[Token(Token = "0x2000032")]
	public delegate RESULT FILE_ASYNCCANCEL_CALLBACK(IntPtr info, IntPtr userdata);
	[Token(Token = "0x2000033")]
	public delegate RESULT FILE_ASYNCDONE_FUNC(IntPtr info, RESULT result);
	[Token(Token = "0x2000034")]
	public delegate IntPtr MEMORY_ALLOC_CALLBACK(uint size, MEMORY_TYPE type, StringWrapper sourcestr);
	[Token(Token = "0x2000035")]
	public delegate IntPtr MEMORY_REALLOC_CALLBACK(IntPtr ptr, uint size, MEMORY_TYPE type, StringWrapper sourcestr);
	[Token(Token = "0x2000036")]
	public delegate void MEMORY_FREE_CALLBACK(IntPtr ptr, MEMORY_TYPE type, StringWrapper sourcestr);
	[Token(Token = "0x2000037")]
	public delegate float CB_3D_ROLLOFF_CALLBACK(IntPtr channelcontrol, float distance);
	[Token(Token = "0x2000038")]
	public enum DSP_RESAMPLER
	{
		[Token(Token = "0x40001C1")]
		DEFAULT,
		[Token(Token = "0x40001C2")]
		NOINTERP,
		[Token(Token = "0x40001C3")]
		LINEAR,
		[Token(Token = "0x40001C4")]
		CUBIC,
		[Token(Token = "0x40001C5")]
		SPLINE,
		[Token(Token = "0x40001C6")]
		MAX
	}
	[Token(Token = "0x2000039")]
	public enum DSPCONNECTION_TYPE
	{
		[Token(Token = "0x40001C8")]
		STANDARD,
		[Token(Token = "0x40001C9")]
		SIDECHAIN,
		[Token(Token = "0x40001CA")]
		SEND,
		[Token(Token = "0x40001CB")]
		SEND_SIDECHAIN,
		[Token(Token = "0x40001CC")]
		MAX
	}
	[Token(Token = "0x200003A")]
	public enum TAGTYPE
	{
		[Token(Token = "0x40001CE")]
		UNKNOWN,
		[Token(Token = "0x40001CF")]
		ID3V1,
		[Token(Token = "0x40001D0")]
		ID3V2,
		[Token(Token = "0x40001D1")]
		VORBISCOMMENT,
		[Token(Token = "0x40001D2")]
		SHOUTCAST,
		[Token(Token = "0x40001D3")]
		ICECAST,
		[Token(Token = "0x40001D4")]
		ASF,
		[Token(Token = "0x40001D5")]
		MIDI,
		[Token(Token = "0x40001D6")]
		PLAYLIST,
		[Token(Token = "0x40001D7")]
		FMOD,
		[Token(Token = "0x40001D8")]
		USER,
		[Token(Token = "0x40001D9")]
		MAX
	}
	[Token(Token = "0x200003B")]
	public enum TAGDATATYPE
	{
		[Token(Token = "0x40001DB")]
		BINARY,
		[Token(Token = "0x40001DC")]
		INT,
		[Token(Token = "0x40001DD")]
		FLOAT,
		[Token(Token = "0x40001DE")]
		STRING,
		[Token(Token = "0x40001DF")]
		STRING_UTF16,
		[Token(Token = "0x40001E0")]
		STRING_UTF16BE,
		[Token(Token = "0x40001E1")]
		STRING_UTF8,
		[Token(Token = "0x40001E2")]
		MAX
	}
	[Token(Token = "0x200003C")]
	public struct TAG
	{
		[Token(Token = "0x40001E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public TAGTYPE type;

		[Token(Token = "0x40001E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public TAGDATATYPE datatype;

		[Token(Token = "0x40001E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public StringWrapper name;

		[Token(Token = "0x40001E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public IntPtr data;

		[Token(Token = "0x40001E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public uint datalen;

		[Token(Token = "0x40001E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public bool updated;
	}
	[Token(Token = "0x200003D")]
	[Flags]
	public enum TIMEUNIT : uint
	{
		[Token(Token = "0x40001EA")]
		MS = 1u,
		[Token(Token = "0x40001EB")]
		PCM = 2u,
		[Token(Token = "0x40001EC")]
		PCMBYTES = 4u,
		[Token(Token = "0x40001ED")]
		RAWBYTES = 8u,
		[Token(Token = "0x40001EE")]
		PCMFRACTION = 0x10u,
		[Token(Token = "0x40001EF")]
		MODORDER = 0x100u,
		[Token(Token = "0x40001F0")]
		MODROW = 0x200u,
		[Token(Token = "0x40001F1")]
		MODPATTERN = 0x400u
	}
	[Token(Token = "0x200003E")]
	public struct PORT_INDEX
	{
		[Token(Token = "0x40001F2")]
		public const ulong NONE = ulong.MaxValue;
	}
	[Token(Token = "0x200003F")]
	public struct CREATESOUNDEXINFO
	{
		[Token(Token = "0x40001F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int cbsize;

		[Token(Token = "0x40001F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public uint length;

		[Token(Token = "0x40001F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public uint fileoffset;

		[Token(Token = "0x40001F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public int numchannels;

		[Token(Token = "0x40001F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int defaultfrequency;

		[Token(Token = "0x40001F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public SOUND_FORMAT format;

		[Token(Token = "0x40001F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public uint decodebuffersize;

		[Token(Token = "0x40001FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public int initialsubsound;

		[Token(Token = "0x40001FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public int numsubsounds;

		[Token(Token = "0x40001FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public IntPtr inclusionlist;

		[Token(Token = "0x40001FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public int inclusionlistnum;

		[Token(Token = "0x40001FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public SOUND_PCMREAD_CALLBACK pcmreadcallback;

		[Token(Token = "0x40001FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public SOUND_PCMSETPOS_CALLBACK pcmsetposcallback;

		[Token(Token = "0x4000200")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public SOUND_NONBLOCK_CALLBACK nonblockcallback;

		[Token(Token = "0x4000201")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public IntPtr dlsname;

		[Token(Token = "0x4000202")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public IntPtr encryptionkey;

		[Token(Token = "0x4000203")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public int maxpolyphony;

		[Token(Token = "0x4000204")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public IntPtr userdata;

		[Token(Token = "0x4000205")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public SOUND_TYPE suggestedsoundtype;

		[Token(Token = "0x4000206")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public FILE_OPEN_CALLBACK fileuseropen;

		[Token(Token = "0x4000207")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public FILE_CLOSE_CALLBACK fileuserclose;

		[Token(Token = "0x4000208")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public FILE_READ_CALLBACK fileuserread;

		[Token(Token = "0x4000209")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public FILE_SEEK_CALLBACK fileuserseek;

		[Token(Token = "0x400020A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public FILE_ASYNCREAD_CALLBACK fileuserasyncread;

		[Token(Token = "0x400020B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public FILE_ASYNCCANCEL_CALLBACK fileuserasynccancel;

		[Token(Token = "0x400020C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public IntPtr fileuserdata;

		[Token(Token = "0x400020D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public int filebuffersize;

		[Token(Token = "0x400020E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		public CHANNELORDER channelorder;

		[Token(Token = "0x400020F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public IntPtr initialsoundgroup;

		[Token(Token = "0x4000210")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public uint initialseekposition;

		[Token(Token = "0x4000211")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		public TIMEUNIT initialseekpostype;

		[Token(Token = "0x4000212")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public int ignoresetfilesystem;

		[Token(Token = "0x4000213")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		public uint audioqueuepolicy;

		[Token(Token = "0x4000214")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public uint minmidigranularity;

		[Token(Token = "0x4000215")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		public int nonblockthreadid;

		[Token(Token = "0x4000216")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		public IntPtr fsbguid;
	}
	[Token(Token = "0x2000040")]
	public struct REVERB_PROPERTIES
	{
		[Token(Token = "0x4000217")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float DecayTime;

		[Token(Token = "0x4000218")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public float EarlyDelay;

		[Token(Token = "0x4000219")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public float LateDelay;

		[Token(Token = "0x400021A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public float HFReference;

		[Token(Token = "0x400021B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float HFDecayRatio;

		[Token(Token = "0x400021C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public float Diffusion;

		[Token(Token = "0x400021D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float Density;

		[Token(Token = "0x400021E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float LowShelfFrequency;

		[Token(Token = "0x400021F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float LowShelfGain;

		[Token(Token = "0x4000220")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float HighCut;

		[Token(Token = "0x4000221")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float EarlyLateMix;

		[Token(Token = "0x4000222")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float WetLevel;

		[Token(Token = "0x6000067")]
		[Address(RVA = "0xC36C28", Offset = "0xC36C28", VA = "0xC36C28")]
		public REVERB_PROPERTIES(float decayTime, float earlyDelay, float lateDelay, float hfReference, float hfDecayRatio, float diffusion, float density, float lowShelfFrequency, float lowShelfGain, float highCut, float earlyLateMix, float wetLevel)
		{
		}
	}
	[Token(Token = "0x2000041")]
	public class PRESET
	{
		[Token(Token = "0x6000068")]
		[Address(RVA = "0xC36C04", Offset = "0xC36C04", VA = "0xC36C04")]
		public static REVERB_PROPERTIES OFF()
		{
			return default(REVERB_PROPERTIES);
		}

		[Token(Token = "0x6000069")]
		[Address(RVA = "0xC36C54", Offset = "0xC36C54", VA = "0xC36C54")]
		public static REVERB_PROPERTIES GENERIC()
		{
			return default(REVERB_PROPERTIES);
		}

		[Token(Token = "0x600006A")]
		[Address(RVA = "0xC36C78", Offset = "0xC36C78", VA = "0xC36C78")]
		public static REVERB_PROPERTIES PADDEDCELL()
		{
			return default(REVERB_PROPERTIES);
		}

		[Token(Token = "0x600006B")]
		[Address(RVA = "0xC36C9C", Offset = "0xC36C9C", VA = "0xC36C9C")]
		public static REVERB_PROPERTIES ROOM()
		{
			return default(REVERB_PROPERTIES);
		}

		[Token(Token = "0x600006C")]
		[Address(RVA = "0xC36CC0", Offset = "0xC36CC0", VA = "0xC36CC0")]
		public static REVERB_PROPERTIES BATHROOM()
		{
			return default(REVERB_PROPERTIES);
		}

		[Token(Token = "0x600006D")]
		[Address(RVA = "0xC36CE4", Offset = "0xC36CE4", VA = "0xC36CE4")]
		public static REVERB_PROPERTIES LIVINGROOM()
		{
			return default(REVERB_PROPERTIES);
		}

		[Token(Token = "0x600006E")]
		[Address(RVA = "0xC36D08", Offset = "0xC36D08", VA = "0xC36D08")]
		public static REVERB_PROPERTIES STONEROOM()
		{
			return default(REVERB_PROPERTIES);
		}

		[Token(Token = "0x600006F")]
		[Address(RVA = "0xC36D2C", Offset = "0xC36D2C", VA = "0xC36D2C")]
		public static REVERB_PROPERTIES AUDITORIUM()
		{
			return default(REVERB_PROPERTIES);
		}

		[Token(Token = "0x6000070")]
		[Address(RVA = "0xC36D50", Offset = "0xC36D50", VA = "0xC36D50")]
		public static REVERB_PROPERTIES CONCERTHALL()
		{
			return default(REVERB_PROPERTIES);
		}

		[Token(Token = "0x6000071")]
		[Address(RVA = "0xC36D74", Offset = "0xC36D74", VA = "0xC36D74")]
		public static REVERB_PROPERTIES CAVE()
		{
			return default(REVERB_PROPERTIES);
		}

		[Token(Token = "0x6000072")]
		[Address(RVA = "0xC36D98", Offset = "0xC36D98", VA = "0xC36D98")]
		public static REVERB_PROPERTIES ARENA()
		{
			return default(REVERB_PROPERTIES);
		}

		[Token(Token = "0x6000073")]
		[Address(RVA = "0xC36DBC", Offset = "0xC36DBC", VA = "0xC36DBC")]
		public static REVERB_PROPERTIES HANGAR()
		{
			return default(REVERB_PROPERTIES);
		}

		[Token(Token = "0x6000074")]
		[Address(RVA = "0xC36DE0", Offset = "0xC36DE0", VA = "0xC36DE0")]
		public static REVERB_PROPERTIES CARPETTEDHALLWAY()
		{
			return default(REVERB_PROPERTIES);
		}

		[Token(Token = "0x6000075")]
		[Address(RVA = "0xC36E04", Offset = "0xC36E04", VA = "0xC36E04")]
		public static REVERB_PROPERTIES HALLWAY()
		{
			return default(REVERB_PROPERTIES);
		}

		[Token(Token = "0x6000076")]
		[Address(RVA = "0xC36E28", Offset = "0xC36E28", VA = "0xC36E28")]
		public static REVERB_PROPERTIES STONECORRIDOR()
		{
			return default(REVERB_PROPERTIES);
		}

		[Token(Token = "0x6000077")]
		[Address(RVA = "0xC36E4C", Offset = "0xC36E4C", VA = "0xC36E4C")]
		public static REVERB_PROPERTIES ALLEY()
		{
			return default(REVERB_PROPERTIES);
		}

		[Token(Token = "0x6000078")]
		[Address(RVA = "0xC36E70", Offset = "0xC36E70", VA = "0xC36E70")]
		public static REVERB_PROPERTIES FOREST()
		{
			return default(REVERB_PROPERTIES);
		}

		[Token(Token = "0x6000079")]
		[Address(RVA = "0xC36E94", Offset = "0xC36E94", VA = "0xC36E94")]
		public static REVERB_PROPERTIES CITY()
		{
			return default(REVERB_PROPERTIES);
		}

		[Token(Token = "0x600007A")]
		[Address(RVA = "0xC36EB8", Offset = "0xC36EB8", VA = "0xC36EB8")]
		public static REVERB_PROPERTIES MOUNTAINS()
		{
			return default(REVERB_PROPERTIES);
		}

		[Token(Token = "0x600007B")]
		[Address(RVA = "0xC36EDC", Offset = "0xC36EDC", VA = "0xC36EDC")]
		public static REVERB_PROPERTIES QUARRY()
		{
			return default(REVERB_PROPERTIES);
		}

		[Token(Token = "0x600007C")]
		[Address(RVA = "0xC36F00", Offset = "0xC36F00", VA = "0xC36F00")]
		public static REVERB_PROPERTIES PLAIN()
		{
			return default(REVERB_PROPERTIES);
		}

		[Token(Token = "0x600007D")]
		[Address(RVA = "0xC36F24", Offset = "0xC36F24", VA = "0xC36F24")]
		public static REVERB_PROPERTIES PARKINGLOT()
		{
			return default(REVERB_PROPERTIES);
		}

		[Token(Token = "0x600007E")]
		[Address(RVA = "0xC36F48", Offset = "0xC36F48", VA = "0xC36F48")]
		public static REVERB_PROPERTIES SEWERPIPE()
		{
			return default(REVERB_PROPERTIES);
		}

		[Token(Token = "0x600007F")]
		[Address(RVA = "0xC36F6C", Offset = "0xC36F6C", VA = "0xC36F6C")]
		public static REVERB_PROPERTIES UNDERWATER()
		{
			return default(REVERB_PROPERTIES);
		}

		[Token(Token = "0x6000080")]
		[Address(RVA = "0xC36F90", Offset = "0xC36F90", VA = "0xC36F90")]
		public PRESET()
		{
		}
	}
	[Token(Token = "0x2000042")]
	public struct ADVANCEDSETTINGS
	{
		[Token(Token = "0x4000223")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int cbSize;

		[Token(Token = "0x4000224")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public int maxMPEGCodecs;

		[Token(Token = "0x4000225")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public int maxADPCMCodecs;

		[Token(Token = "0x4000226")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public int maxXMACodecs;

		[Token(Token = "0x4000227")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int maxVorbisCodecs;

		[Token(Token = "0x4000228")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public int maxAT9Codecs;

		[Token(Token = "0x4000229")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int maxFADPCMCodecs;

		[Token(Token = "0x400022A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public int maxPCMCodecs;

		[Token(Token = "0x400022B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public int ASIONumChannels;

		[Token(Token = "0x400022C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public IntPtr ASIOChannelList;

		[Token(Token = "0x400022D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public IntPtr ASIOSpeakerList;

		[Token(Token = "0x400022E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float vol0virtualvol;

		[Token(Token = "0x400022F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public uint defaultDecodeBufferSize;

		[Token(Token = "0x4000230")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public ushort profilePort;

		[Token(Token = "0x4000231")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public uint geometryMaxFadeTime;

		[Token(Token = "0x4000232")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float distanceFilterCenterFreq;

		[Token(Token = "0x4000233")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public int reverb3Dinstance;

		[Token(Token = "0x4000234")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public int DSPBufferPoolSize;

		[Token(Token = "0x4000235")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public uint stackSizeStream;

		[Token(Token = "0x4000236")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public uint stackSizeNonBlocking;

		[Token(Token = "0x4000237")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public uint stackSizeMixer;

		[Token(Token = "0x4000238")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public DSP_RESAMPLER resamplerMethod;

		[Token(Token = "0x4000239")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public uint commandQueueSize;

		[Token(Token = "0x400023A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public uint randomSeed;
	}
	[Token(Token = "0x2000043")]
	[Flags]
	public enum DRIVER_STATE : uint
	{
		[Token(Token = "0x400023C")]
		CONNECTED = 1u,
		[Token(Token = "0x400023D")]
		DEFAULT = 2u
	}
	[Token(Token = "0x2000044")]
	public struct Factory
	{
		[Token(Token = "0x6000081")]
		[Address(RVA = "0xC33F9C", Offset = "0xC33F9C", VA = "0xC33F9C")]
		public static RESULT System_Create(out System system)
		{
			return default(RESULT);
		}

		[PreserveSig]
		[Token(Token = "0x6000082")]
		[Address(RVA = "0xC33FA0", Offset = "0xC33FA0", VA = "0xC33FA0")]
		private static extern RESULT FMOD5_System_Create(out IntPtr system);
	}
	[Token(Token = "0x2000045")]
	public struct Memory
	{
		[Token(Token = "0x6000083")]
		[Address(RVA = "0xC36A80", Offset = "0xC36A80", VA = "0xC36A80")]
		public static RESULT Initialize(IntPtr poolmem, int poollen, MEMORY_ALLOC_CALLBACK useralloc, MEMORY_REALLOC_CALLBACK userrealloc, MEMORY_FREE_CALLBACK userfree, MEMORY_TYPE memtypeflags = MEMORY_TYPE.ALL)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000084")]
		[Address(RVA = "0xC36B64", Offset = "0xC36B64", VA = "0xC36B64")]
		public static RESULT GetStats(out int currentalloced, out int maxalloced, bool blocking = true)
		{
			return default(RESULT);
		}

		[PreserveSig]
		[Token(Token = "0x6000085")]
		[Address(RVA = "0xC36A84", Offset = "0xC36A84", VA = "0xC36A84")]
		private static extern RESULT FMOD5_Memory_Initialize(IntPtr poolmem, int poollen, MEMORY_ALLOC_CALLBACK useralloc, MEMORY_REALLOC_CALLBACK userrealloc, MEMORY_FREE_CALLBACK userfree, MEMORY_TYPE memtypeflags);

		[PreserveSig]
		[Token(Token = "0x6000086")]
		[Address(RVA = "0xC36B6C", Offset = "0xC36B6C", VA = "0xC36B6C")]
		private static extern RESULT FMOD5_Memory_GetStats(out int currentalloced, out int maxalloced, bool blocking);
	}
	[Token(Token = "0x2000046")]
	public struct Debug
	{
		[Token(Token = "0x6000087")]
		[Address(RVA = "0xC2D3A0", Offset = "0xC2D3A0", VA = "0xC2D3A0")]
		public static RESULT Initialize(DEBUG_FLAGS flags, DEBUG_MODE mode = DEBUG_MODE.TTY, [Optional] DEBUG_CALLBACK callback, [Optional] string filename)
		{
			return default(RESULT);
		}

		[PreserveSig]
		[Token(Token = "0x6000088")]
		[Address(RVA = "0xC2D540", Offset = "0xC2D540", VA = "0xC2D540")]
		private static extern RESULT FMOD5_Debug_Initialize(DEBUG_FLAGS flags, DEBUG_MODE mode, DEBUG_CALLBACK callback, byte[] filename);
	}
	[Token(Token = "0x2000047")]
	public struct System
	{
		[Token(Token = "0x400023E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public IntPtr handle;

		[Token(Token = "0x6000089")]
		[Address(RVA = "0x1E403F8", Offset = "0x1E403F8", VA = "0x1E403F8")]
		public RESULT release()
		{
			return default(RESULT);
		}

		[Token(Token = "0x600008A")]
		[Address(RVA = "0x1E40480", Offset = "0x1E40480", VA = "0x1E40480")]
		public RESULT setOutput(OUTPUTTYPE output)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600008B")]
		[Address(RVA = "0x1E40518", Offset = "0x1E40518", VA = "0x1E40518")]
		public RESULT getOutput(out OUTPUTTYPE output)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600008C")]
		[Address(RVA = "0x1E405B0", Offset = "0x1E405B0", VA = "0x1E405B0")]
		public RESULT getNumDrivers(out int numdrivers)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600008D")]
		[Address(RVA = "0x1E40648", Offset = "0x1E40648", VA = "0x1E40648")]
		public RESULT getDriverInfo(int id, out string name, int namelen, out Guid guid, out int systemrate, out SPEAKERMODE speakermode, out int speakermodechannels)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600008E")]
		[Address(RVA = "0x1E40954", Offset = "0x1E40954", VA = "0x1E40954")]
		public RESULT getDriverInfo(int id, out Guid guid, out int systemrate, out SPEAKERMODE speakermode, out int speakermodechannels)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600008F")]
		[Address(RVA = "0x1E409E8", Offset = "0x1E409E8", VA = "0x1E409E8")]
		public RESULT setDriver(int driver)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000090")]
		[Address(RVA = "0x1E40A80", Offset = "0x1E40A80", VA = "0x1E40A80")]
		public RESULT getDriver(out int driver)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000091")]
		[Address(RVA = "0x1E40B18", Offset = "0x1E40B18", VA = "0x1E40B18")]
		public RESULT setSoftwareChannels(int numsoftwarechannels)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000092")]
		[Address(RVA = "0x1E40BB0", Offset = "0x1E40BB0", VA = "0x1E40BB0")]
		public RESULT getSoftwareChannels(out int numsoftwarechannels)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000093")]
		[Address(RVA = "0x1E40C48", Offset = "0x1E40C48", VA = "0x1E40C48")]
		public RESULT setSoftwareFormat(int samplerate, SPEAKERMODE speakermode, int numrawspeakers)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000094")]
		[Address(RVA = "0x1E40CF8", Offset = "0x1E40CF8", VA = "0x1E40CF8")]
		public RESULT getSoftwareFormat(out int samplerate, out SPEAKERMODE speakermode, out int numrawspeakers)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000095")]
		[Address(RVA = "0x1E40DA8", Offset = "0x1E40DA8", VA = "0x1E40DA8")]
		public RESULT setDSPBufferSize(uint bufferlength, int numbuffers)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000096")]
		[Address(RVA = "0x1E40E48", Offset = "0x1E40E48", VA = "0x1E40E48")]
		public RESULT getDSPBufferSize(out uint bufferlength, out int numbuffers)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000097")]
		[Address(RVA = "0x1E40EE8", Offset = "0x1E40EE8", VA = "0x1E40EE8")]
		public RESULT setFileSystem(FILE_OPEN_CALLBACK useropen, FILE_CLOSE_CALLBACK userclose, FILE_READ_CALLBACK userread, FILE_SEEK_CALLBACK userseek, FILE_ASYNCREAD_CALLBACK userasyncread, FILE_ASYNCCANCEL_CALLBACK userasynccancel, int blockalign)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000098")]
		[Address(RVA = "0x1E4100C", Offset = "0x1E4100C", VA = "0x1E4100C")]
		public RESULT attachFileSystem(FILE_OPEN_CALLBACK useropen, FILE_CLOSE_CALLBACK userclose, FILE_READ_CALLBACK userread, FILE_SEEK_CALLBACK userseek)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000099")]
		[Address(RVA = "0x1E410F0", Offset = "0x1E410F0", VA = "0x1E410F0")]
		public RESULT setAdvancedSettings(ref ADVANCEDSETTINGS settings)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600009A")]
		[Address(RVA = "0x1E41244", Offset = "0x1E41244", VA = "0x1E41244")]
		public RESULT getAdvancedSettings(ref ADVANCEDSETTINGS settings)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600009B")]
		[Address(RVA = "0x1E41398", Offset = "0x1E41398", VA = "0x1E41398")]
		public RESULT setCallback(SYSTEM_CALLBACK callback, SYSTEM_CALLBACK_TYPE callbackmask = SYSTEM_CALLBACK_TYPE.ALL)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600009C")]
		[Address(RVA = "0x1E41440", Offset = "0x1E41440", VA = "0x1E41440")]
		public RESULT setPluginPath(string path)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600009D")]
		[Address(RVA = "0x1E41664", Offset = "0x1E41664", VA = "0x1E41664")]
		public RESULT loadPlugin(string filename, out uint handle, uint priority = 0u)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600009E")]
		[Address(RVA = "0x1E418B0", Offset = "0x1E418B0", VA = "0x1E418B0")]
		public RESULT unloadPlugin(uint handle)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600009F")]
		[Address(RVA = "0x1E41948", Offset = "0x1E41948", VA = "0x1E41948")]
		public RESULT getNumNestedPlugins(uint handle, out int count)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60000A0")]
		[Address(RVA = "0x1E419E8", Offset = "0x1E419E8", VA = "0x1E419E8")]
		public RESULT getNestedPlugin(uint handle, int index, out uint nestedhandle)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60000A1")]
		[Address(RVA = "0x1E41A98", Offset = "0x1E41A98", VA = "0x1E41A98")]
		public RESULT getNumPlugins(PLUGINTYPE plugintype, out int numplugins)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60000A2")]
		[Address(RVA = "0x1E41B38", Offset = "0x1E41B38", VA = "0x1E41B38")]
		public RESULT getPluginHandle(PLUGINTYPE plugintype, int index, out uint handle)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60000A3")]
		[Address(RVA = "0x1E41BE8", Offset = "0x1E41BE8", VA = "0x1E41BE8")]
		public RESULT getPluginInfo(uint handle, out PLUGINTYPE plugintype, out string name, int namelen, out uint version)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60000A4")]
		[Address(RVA = "0x1E41EBC", Offset = "0x1E41EBC", VA = "0x1E41EBC")]
		public RESULT getPluginInfo(uint handle, out PLUGINTYPE plugintype, out uint version)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60000A5")]
		[Address(RVA = "0x1E41F2C", Offset = "0x1E41F2C", VA = "0x1E41F2C")]
		public RESULT setOutputByPlugin(uint handle)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60000A6")]
		[Address(RVA = "0x1E41FC4", Offset = "0x1E41FC4", VA = "0x1E41FC4")]
		public RESULT getOutputByPlugin(out uint handle)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60000A7")]
		[Address(RVA = "0x1E4205C", Offset = "0x1E4205C", VA = "0x1E4205C")]
		public RESULT createDSPByPlugin(uint handle, out DSP dsp)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60000A8")]
		[Address(RVA = "0x1E420FC", Offset = "0x1E420FC", VA = "0x1E420FC")]
		public RESULT getDSPInfoByPlugin(uint handle, out IntPtr description)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60000A9")]
		[Address(RVA = "0x1E4219C", Offset = "0x1E4219C", VA = "0x1E4219C")]
		public RESULT registerDSP(ref DSP_DESCRIPTION description, out uint handle)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60000AA")]
		[Address(RVA = "0x1E42298", Offset = "0x1E42298", VA = "0x1E42298")]
		public RESULT init(int maxchannels, INITFLAGS flags, IntPtr extradriverdata)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60000AB")]
		[Address(RVA = "0x1E42348", Offset = "0x1E42348", VA = "0x1E42348")]
		public RESULT close()
		{
			return default(RESULT);
		}

		[Token(Token = "0x60000AC")]
		[Address(RVA = "0x1E423D0", Offset = "0x1E423D0", VA = "0x1E423D0")]
		public RESULT update()
		{
			return default(RESULT);
		}

		[Token(Token = "0x60000AD")]
		[Address(RVA = "0x1E42458", Offset = "0x1E42458", VA = "0x1E42458")]
		public RESULT setSpeakerPosition(SPEAKER speaker, float x, float y, bool active)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60000AE")]
		[Address(RVA = "0x1E42514", Offset = "0x1E42514", VA = "0x1E42514")]
		public RESULT getSpeakerPosition(SPEAKER speaker, out float x, out float y, out bool active)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60000AF")]
		[Address(RVA = "0x1E425E0", Offset = "0x1E425E0", VA = "0x1E425E0")]
		public RESULT setStreamBufferSize(uint filebuffersize, TIMEUNIT filebuffersizetype)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60000B0")]
		[Address(RVA = "0x1E42680", Offset = "0x1E42680", VA = "0x1E42680")]
		public RESULT getStreamBufferSize(out uint filebuffersize, out TIMEUNIT filebuffersizetype)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60000B1")]
		[Address(RVA = "0x1E42720", Offset = "0x1E42720", VA = "0x1E42720")]
		public RESULT set3DSettings(float dopplerscale, float distancefactor, float rolloffscale)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60000B2")]
		[Address(RVA = "0x1E427D0", Offset = "0x1E427D0", VA = "0x1E427D0")]
		public RESULT get3DSettings(out float dopplerscale, out float distancefactor, out float rolloffscale)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60000B3")]
		[Address(RVA = "0x1E42880", Offset = "0x1E42880", VA = "0x1E42880")]
		public RESULT set3DNumListeners(int numlisteners)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60000B4")]
		[Address(RVA = "0x1E42918", Offset = "0x1E42918", VA = "0x1E42918")]
		public RESULT get3DNumListeners(out int numlisteners)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60000B5")]
		[Address(RVA = "0x1E429B0", Offset = "0x1E429B0", VA = "0x1E429B0")]
		public RESULT set3DListenerAttributes(int listener, ref VECTOR pos, ref VECTOR vel, ref VECTOR forward, ref VECTOR up)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60000B6")]
		[Address(RVA = "0x1E42A78", Offset = "0x1E42A78", VA = "0x1E42A78")]
		public RESULT get3DListenerAttributes(int listener, out VECTOR pos, out VECTOR vel, out VECTOR forward, out VECTOR up)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60000B7")]
		[Address(RVA = "0x1E42B40", Offset = "0x1E42B40", VA = "0x1E42B40")]
		public RESULT set3DRolloffCallback(CB_3D_ROLLOFF_CALLBACK callback)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60000B8")]
		[Address(RVA = "0x1E42BE0", Offset = "0x1E42BE0", VA = "0x1E42BE0")]
		public RESULT mixerSuspend()
		{
			return default(RESULT);
		}

		[Token(Token = "0x60000B9")]
		[Address(RVA = "0x1E42C68", Offset = "0x1E42C68", VA = "0x1E42C68")]
		public RESULT mixerResume()
		{
			return default(RESULT);
		}

		[Token(Token = "0x60000BA")]
		[Address(RVA = "0x1E42CF0", Offset = "0x1E42CF0", VA = "0x1E42CF0")]
		public RESULT getDefaultMixMatrix(SPEAKERMODE sourcespeakermode, SPEAKERMODE targetspeakermode, float[] matrix, int matrixhop)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60000BB")]
		[Address(RVA = "0x1E42DB0", Offset = "0x1E42DB0", VA = "0x1E42DB0")]
		public RESULT getSpeakerModeChannels(SPEAKERMODE mode, out int channels)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60000BC")]
		[Address(RVA = "0x1E42E50", Offset = "0x1E42E50", VA = "0x1E42E50")]
		public RESULT getVersion(out uint version)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60000BD")]
		[Address(RVA = "0x1E42EE8", Offset = "0x1E42EE8", VA = "0x1E42EE8")]
		public RESULT getOutputHandle(out IntPtr handle)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60000BE")]
		[Address(RVA = "0x1E42F80", Offset = "0x1E42F80", VA = "0x1E42F80")]
		public RESULT getChannelsPlaying(out int channels)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60000BF")]
		[Address(RVA = "0x1E4306C", Offset = "0x1E4306C", VA = "0x1E4306C")]
		public RESULT getChannelsPlaying(out int channels, out int realchannels)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60000C0")]
		[Address(RVA = "0x1E4310C", Offset = "0x1E4310C", VA = "0x1E4310C")]
		public RESULT getCPUUsage(out float dsp, out float stream, out float geometry, out float update, out float total)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60000C1")]
		[Address(RVA = "0x1E431D4", Offset = "0x1E431D4", VA = "0x1E431D4")]
		public RESULT getFileUsage(out long sampleBytesRead, out long streamBytesRead, out long otherBytesRead)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60000C2")]
		[Address(RVA = "0x1E43284", Offset = "0x1E43284", VA = "0x1E43284")]
		public RESULT createSound(string name, MODE mode, ref CREATESOUNDEXINFO exinfo, out Sound sound)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60000C3")]
		[Address(RVA = "0x1E4354C", Offset = "0x1E4354C", VA = "0x1E4354C")]
		public RESULT createSound(byte[] data, MODE mode, ref CREATESOUNDEXINFO exinfo, out Sound sound)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60000C4")]
		[Address(RVA = "0x1E43554", Offset = "0x1E43554", VA = "0x1E43554")]
		public RESULT createSound(IntPtr name_or_data, MODE mode, ref CREATESOUNDEXINFO exinfo, out Sound sound)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60000C5")]
		[Address(RVA = "0x1E4366C", Offset = "0x1E4366C", VA = "0x1E4366C")]
		public RESULT createSound(string name, MODE mode, out Sound sound)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60000C6")]
		[Address(RVA = "0x1E4375C", Offset = "0x1E4375C", VA = "0x1E4375C")]
		public RESULT createStream(string name, MODE mode, ref CREATESOUNDEXINFO exinfo, out Sound sound)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60000C7")]
		[Address(RVA = "0x1E43A24", Offset = "0x1E43A24", VA = "0x1E43A24")]
		public RESULT createStream(byte[] data, MODE mode, ref CREATESOUNDEXINFO exinfo, out Sound sound)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60000C8")]
		[Address(RVA = "0x1E43A2C", Offset = "0x1E43A2C", VA = "0x1E43A2C")]
		public RESULT createStream(IntPtr name_or_data, MODE mode, ref CREATESOUNDEXINFO exinfo, out Sound sound)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60000C9")]
		[Address(RVA = "0x1E43B44", Offset = "0x1E43B44", VA = "0x1E43B44")]
		public RESULT createStream(string name, MODE mode, out Sound sound)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60000CA")]
		[Address(RVA = "0x1E43C34", Offset = "0x1E43C34", VA = "0x1E43C34")]
		public RESULT createDSP(ref DSP_DESCRIPTION description, out DSP dsp)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60000CB")]
		[Address(RVA = "0x1E43D34", Offset = "0x1E43D34", VA = "0x1E43D34")]
		public RESULT createDSPByType(DSP_TYPE type, out DSP dsp)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60000CC")]
		[Address(RVA = "0x1E43DD4", Offset = "0x1E43DD4", VA = "0x1E43DD4")]
		public RESULT createChannelGroup(string name, out ChannelGroup channelgroup)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60000CD")]
		[Address(RVA = "0x1E44008", Offset = "0x1E44008", VA = "0x1E44008")]
		public RESULT createSoundGroup(string name, out SoundGroup soundgroup)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60000CE")]
		[Address(RVA = "0x1E4423C", Offset = "0x1E4423C", VA = "0x1E4423C")]
		public RESULT createReverb3D(out Reverb3D reverb)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60000CF")]
		[Address(RVA = "0x1E442D4", Offset = "0x1E442D4", VA = "0x1E442D4")]
		public RESULT playSound(Sound sound, ChannelGroup channelgroup, bool paused, out Channel channel)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60000D0")]
		[Address(RVA = "0x1E44390", Offset = "0x1E44390", VA = "0x1E44390")]
		public RESULT playDSP(DSP dsp, ChannelGroup channelgroup, bool paused, out Channel channel)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60000D1")]
		[Address(RVA = "0x1E4444C", Offset = "0x1E4444C", VA = "0x1E4444C")]
		public RESULT getChannel(int channelid, out Channel channel)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60000D2")]
		[Address(RVA = "0x1E444EC", Offset = "0x1E444EC", VA = "0x1E444EC")]
		public RESULT getMasterChannelGroup(out ChannelGroup channelgroup)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60000D3")]
		[Address(RVA = "0x1E44584", Offset = "0x1E44584", VA = "0x1E44584")]
		public RESULT getMasterSoundGroup(out SoundGroup soundgroup)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60000D4")]
		[Address(RVA = "0x1E4461C", Offset = "0x1E4461C", VA = "0x1E4461C")]
		public RESULT attachChannelGroupToPort(uint portType, ulong portIndex, ChannelGroup channelgroup, bool passThru = false)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60000D5")]
		[Address(RVA = "0x1E446D8", Offset = "0x1E446D8", VA = "0x1E446D8")]
		public RESULT detachChannelGroupFromPort(ChannelGroup channelgroup)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60000D6")]
		[Address(RVA = "0x1E44770", Offset = "0x1E44770", VA = "0x1E44770")]
		public RESULT setReverbProperties(int instance, ref REVERB_PROPERTIES prop)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60000D7")]
		[Address(RVA = "0x1E44810", Offset = "0x1E44810", VA = "0x1E44810")]
		public RESULT getReverbProperties(int instance, out REVERB_PROPERTIES prop)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60000D8")]
		[Address(RVA = "0x1E448B0", Offset = "0x1E448B0", VA = "0x1E448B0")]
		public RESULT lockDSP()
		{
			return default(RESULT);
		}

		[Token(Token = "0x60000D9")]
		[Address(RVA = "0x1E44938", Offset = "0x1E44938", VA = "0x1E44938")]
		public RESULT unlockDSP()
		{
			return default(RESULT);
		}

		[Token(Token = "0x60000DA")]
		[Address(RVA = "0x1E449C0", Offset = "0x1E449C0", VA = "0x1E449C0")]
		public RESULT getRecordNumDrivers(out int numdrivers, out int numconnected)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60000DB")]
		[Address(RVA = "0x1E44A60", Offset = "0x1E44A60", VA = "0x1E44A60")]
		public RESULT getRecordDriverInfo(int id, out string name, int namelen, out Guid guid, out int systemrate, out SPEAKERMODE speakermode, out int speakermodechannels, out DRIVER_STATE state)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60000DC")]
		[Address(RVA = "0x1E44D7C", Offset = "0x1E44D7C", VA = "0x1E44D7C")]
		public RESULT getRecordDriverInfo(int id, out Guid guid, out int systemrate, out SPEAKERMODE speakermode, out int speakermodechannels, out DRIVER_STATE state)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60000DD")]
		[Address(RVA = "0x1E44E18", Offset = "0x1E44E18", VA = "0x1E44E18")]
		public RESULT getRecordPosition(int id, out uint position)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60000DE")]
		[Address(RVA = "0x1E44EB8", Offset = "0x1E44EB8", VA = "0x1E44EB8")]
		public RESULT recordStart(int id, Sound sound, bool loop)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60000DF")]
		[Address(RVA = "0x1E44F68", Offset = "0x1E44F68", VA = "0x1E44F68")]
		public RESULT recordStop(int id)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60000E0")]
		[Address(RVA = "0x1E45000", Offset = "0x1E45000", VA = "0x1E45000")]
		public RESULT isRecording(int id, out bool recording)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60000E1")]
		[Address(RVA = "0x1E450B4", Offset = "0x1E450B4", VA = "0x1E450B4")]
		public RESULT createGeometry(int maxpolygons, int maxvertices, out Geometry geometry)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60000E2")]
		[Address(RVA = "0x1E45164", Offset = "0x1E45164", VA = "0x1E45164")]
		public RESULT setGeometrySettings(float maxworldsize)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60000E3")]
		[Address(RVA = "0x1E451FC", Offset = "0x1E451FC", VA = "0x1E451FC")]
		public RESULT getGeometrySettings(out float maxworldsize)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60000E4")]
		[Address(RVA = "0x1E45294", Offset = "0x1E45294", VA = "0x1E45294")]
		public RESULT loadGeometry(IntPtr data, int datasize, out Geometry geometry)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60000E5")]
		[Address(RVA = "0x1E45344", Offset = "0x1E45344", VA = "0x1E45344")]
		public RESULT getGeometryOcclusion(ref VECTOR listener, ref VECTOR source, out float direct, out float reverb)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60000E6")]
		[Address(RVA = "0x1E453FC", Offset = "0x1E453FC", VA = "0x1E453FC")]
		public RESULT setNetworkProxy(string proxy)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60000E7")]
		[Address(RVA = "0x1E45620", Offset = "0x1E45620", VA = "0x1E45620")]
		public RESULT getNetworkProxy(out string proxy, int proxylen)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60000E8")]
		[Address(RVA = "0x1E458B4", Offset = "0x1E458B4", VA = "0x1E458B4")]
		public RESULT setNetworkTimeout(int timeout)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60000E9")]
		[Address(RVA = "0x1E4594C", Offset = "0x1E4594C", VA = "0x1E4594C")]
		public RESULT getNetworkTimeout(out int timeout)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60000EA")]
		[Address(RVA = "0x1E459E4", Offset = "0x1E459E4", VA = "0x1E459E4")]
		public RESULT setUserData(IntPtr userdata)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60000EB")]
		[Address(RVA = "0x1E45A7C", Offset = "0x1E45A7C", VA = "0x1E45A7C")]
		public RESULT getUserData(out IntPtr userdata)
		{
			return default(RESULT);
		}

		[PreserveSig]
		[Token(Token = "0x60000EC")]
		[Address(RVA = "0x1E40400", Offset = "0x1E40400", VA = "0x1E40400")]
		private static extern RESULT FMOD5_System_Release(IntPtr system);

		[PreserveSig]
		[Token(Token = "0x60000ED")]
		[Address(RVA = "0x1E40488", Offset = "0x1E40488", VA = "0x1E40488")]
		private static extern RESULT FMOD5_System_SetOutput(IntPtr system, OUTPUTTYPE output);

		[PreserveSig]
		[Token(Token = "0x60000EE")]
		[Address(RVA = "0x1E40520", Offset = "0x1E40520", VA = "0x1E40520")]
		private static extern RESULT FMOD5_System_GetOutput(IntPtr system, out OUTPUTTYPE output);

		[PreserveSig]
		[Token(Token = "0x60000EF")]
		[Address(RVA = "0x1E405B8", Offset = "0x1E405B8", VA = "0x1E405B8")]
		private static extern RESULT FMOD5_System_GetNumDrivers(IntPtr system, out int numdrivers);

		[PreserveSig]
		[Token(Token = "0x60000F0")]
		[Address(RVA = "0x1E4087C", Offset = "0x1E4087C", VA = "0x1E4087C")]
		private static extern RESULT FMOD5_System_GetDriverInfo(IntPtr system, int id, IntPtr name, int namelen, out Guid guid, out int systemrate, out SPEAKERMODE speakermode, out int speakermodechannels);

		[PreserveSig]
		[Token(Token = "0x60000F1")]
		[Address(RVA = "0x1E409F0", Offset = "0x1E409F0", VA = "0x1E409F0")]
		private static extern RESULT FMOD5_System_SetDriver(IntPtr system, int driver);

		[PreserveSig]
		[Token(Token = "0x60000F2")]
		[Address(RVA = "0x1E40A88", Offset = "0x1E40A88", VA = "0x1E40A88")]
		private static extern RESULT FMOD5_System_GetDriver(IntPtr system, out int driver);

		[PreserveSig]
		[Token(Token = "0x60000F3")]
		[Address(RVA = "0x1E40B20", Offset = "0x1E40B20", VA = "0x1E40B20")]
		private static extern RESULT FMOD5_System_SetSoftwareChannels(IntPtr system, int numsoftwarechannels);

		[PreserveSig]
		[Token(Token = "0x60000F4")]
		[Address(RVA = "0x1E40BB8", Offset = "0x1E40BB8", VA = "0x1E40BB8")]
		private static extern RESULT FMOD5_System_GetSoftwareChannels(IntPtr system, out int numsoftwarechannels);

		[PreserveSig]
		[Token(Token = "0x60000F5")]
		[Address(RVA = "0x1E40C50", Offset = "0x1E40C50", VA = "0x1E40C50")]
		private static extern RESULT FMOD5_System_SetSoftwareFormat(IntPtr system, int samplerate, SPEAKERMODE speakermode, int numrawspeakers);

		[PreserveSig]
		[Token(Token = "0x60000F6")]
		[Address(RVA = "0x1E40D00", Offset = "0x1E40D00", VA = "0x1E40D00")]
		private static extern RESULT FMOD5_System_GetSoftwareFormat(IntPtr system, out int samplerate, out SPEAKERMODE speakermode, out int numrawspeakers);

		[PreserveSig]
		[Token(Token = "0x60000F7")]
		[Address(RVA = "0x1E40DB0", Offset = "0x1E40DB0", VA = "0x1E40DB0")]
		private static extern RESULT FMOD5_System_SetDSPBufferSize(IntPtr system, uint bufferlength, int numbuffers);

		[PreserveSig]
		[Token(Token = "0x60000F8")]
		[Address(RVA = "0x1E40E50", Offset = "0x1E40E50", VA = "0x1E40E50")]
		private static extern RESULT FMOD5_System_GetDSPBufferSize(IntPtr system, out uint bufferlength, out int numbuffers);

		[PreserveSig]
		[Token(Token = "0x60000F9")]
		[Address(RVA = "0x1E40EF0", Offset = "0x1E40EF0", VA = "0x1E40EF0")]
		private static extern RESULT FMOD5_System_SetFileSystem(IntPtr system, FILE_OPEN_CALLBACK useropen, FILE_CLOSE_CALLBACK userclose, FILE_READ_CALLBACK userread, FILE_SEEK_CALLBACK userseek, FILE_ASYNCREAD_CALLBACK userasyncread, FILE_ASYNCCANCEL_CALLBACK userasynccancel, int blockalign);

		[PreserveSig]
		[Token(Token = "0x60000FA")]
		[Address(RVA = "0x1E41014", Offset = "0x1E41014", VA = "0x1E41014")]
		private static extern RESULT FMOD5_System_AttachFileSystem(IntPtr system, FILE_OPEN_CALLBACK useropen, FILE_CLOSE_CALLBACK userclose, FILE_READ_CALLBACK userread, FILE_SEEK_CALLBACK userseek);

		[PreserveSig]
		[Token(Token = "0x60000FB")]
		[Address(RVA = "0x1E411B4", Offset = "0x1E411B4", VA = "0x1E411B4")]
		private static extern RESULT FMOD5_System_SetAdvancedSettings(IntPtr system, ref ADVANCEDSETTINGS settings);

		[PreserveSig]
		[Token(Token = "0x60000FC")]
		[Address(RVA = "0x1E41308", Offset = "0x1E41308", VA = "0x1E41308")]
		private static extern RESULT FMOD5_System_GetAdvancedSettings(IntPtr system, ref ADVANCEDSETTINGS settings);

		[PreserveSig]
		[Token(Token = "0x60000FD")]
		[Address(RVA = "0x1E413A0", Offset = "0x1E413A0", VA = "0x1E413A0")]
		private static extern RESULT FMOD5_System_SetCallback(IntPtr system, SYSTEM_CALLBACK callback, SYSTEM_CALLBACK_TYPE callbackmask);

		[PreserveSig]
		[Token(Token = "0x60000FE")]
		[Address(RVA = "0x1E415CC", Offset = "0x1E415CC", VA = "0x1E415CC")]
		private static extern RESULT FMOD5_System_SetPluginPath(IntPtr system, byte[] path);

		[PreserveSig]
		[Token(Token = "0x60000FF")]
		[Address(RVA = "0x1E41800", Offset = "0x1E41800", VA = "0x1E41800")]
		private static extern RESULT FMOD5_System_LoadPlugin(IntPtr system, byte[] filename, out uint handle, uint priority);

		[PreserveSig]
		[Token(Token = "0x6000100")]
		[Address(RVA = "0x1E418B8", Offset = "0x1E418B8", VA = "0x1E418B8")]
		private static extern RESULT FMOD5_System_UnloadPlugin(IntPtr system, uint handle);

		[PreserveSig]
		[Token(Token = "0x6000101")]
		[Address(RVA = "0x1E41950", Offset = "0x1E41950", VA = "0x1E41950")]
		private static extern RESULT FMOD5_System_GetNumNestedPlugins(IntPtr system, uint handle, out int count);

		[PreserveSig]
		[Token(Token = "0x6000102")]
		[Address(RVA = "0x1E419F0", Offset = "0x1E419F0", VA = "0x1E419F0")]
		private static extern RESULT FMOD5_System_GetNestedPlugin(IntPtr system, uint handle, int index, out uint nestedhandle);

		[PreserveSig]
		[Token(Token = "0x6000103")]
		[Address(RVA = "0x1E41AA0", Offset = "0x1E41AA0", VA = "0x1E41AA0")]
		private static extern RESULT FMOD5_System_GetNumPlugins(IntPtr system, PLUGINTYPE plugintype, out int numplugins);

		[PreserveSig]
		[Token(Token = "0x6000104")]
		[Address(RVA = "0x1E41B40", Offset = "0x1E41B40", VA = "0x1E41B40")]
		private static extern RESULT FMOD5_System_GetPluginHandle(IntPtr system, PLUGINTYPE plugintype, int index, out uint handle);

		[PreserveSig]
		[Token(Token = "0x6000105")]
		[Address(RVA = "0x1E41DFC", Offset = "0x1E41DFC", VA = "0x1E41DFC")]
		private static extern RESULT FMOD5_System_GetPluginInfo(IntPtr system, uint handle, out PLUGINTYPE plugintype, IntPtr name, int namelen, out uint version);

		[PreserveSig]
		[Token(Token = "0x6000106")]
		[Address(RVA = "0x1E41F34", Offset = "0x1E41F34", VA = "0x1E41F34")]
		private static extern RESULT FMOD5_System_SetOutputByPlugin(IntPtr system, uint handle);

		[PreserveSig]
		[Token(Token = "0x6000107")]
		[Address(RVA = "0x1E41FCC", Offset = "0x1E41FCC", VA = "0x1E41FCC")]
		private static extern RESULT FMOD5_System_GetOutputByPlugin(IntPtr system, out uint handle);

		[PreserveSig]
		[Token(Token = "0x6000108")]
		[Address(RVA = "0x1E42064", Offset = "0x1E42064", VA = "0x1E42064")]
		private static extern RESULT FMOD5_System_CreateDSPByPlugin(IntPtr system, uint handle, out IntPtr dsp);

		[PreserveSig]
		[Token(Token = "0x6000109")]
		[Address(RVA = "0x1E42104", Offset = "0x1E42104", VA = "0x1E42104")]
		private static extern RESULT FMOD5_System_GetDSPInfoByPlugin(IntPtr system, uint handle, out IntPtr description);

		[PreserveSig]
		[Token(Token = "0x600010A")]
		[Address(RVA = "0x1E421A4", Offset = "0x1E421A4", VA = "0x1E421A4")]
		private static extern RESULT FMOD5_System_RegisterDSP(IntPtr system, ref DSP_DESCRIPTION description, out uint handle);

		[PreserveSig]
		[Token(Token = "0x600010B")]
		[Address(RVA = "0x1E422A0", Offset = "0x1E422A0", VA = "0x1E422A0")]
		private static extern RESULT FMOD5_System_Init(IntPtr system, int maxchannels, INITFLAGS flags, IntPtr extradriverdata);

		[PreserveSig]
		[Token(Token = "0x600010C")]
		[Address(RVA = "0x1E42350", Offset = "0x1E42350", VA = "0x1E42350")]
		private static extern RESULT FMOD5_System_Close(IntPtr system);

		[PreserveSig]
		[Token(Token = "0x600010D")]
		[Address(RVA = "0x1E423D8", Offset = "0x1E423D8", VA = "0x1E423D8")]
		private static extern RESULT FMOD5_System_Update(IntPtr system);

		[PreserveSig]
		[Token(Token = "0x600010E")]
		[Address(RVA = "0x1E42464", Offset = "0x1E42464", VA = "0x1E42464")]
		private static extern RESULT FMOD5_System_SetSpeakerPosition(IntPtr system, SPEAKER speaker, float x, float y, bool active);

		[PreserveSig]
		[Token(Token = "0x600010F")]
		[Address(RVA = "0x1E4251C", Offset = "0x1E4251C", VA = "0x1E4251C")]
		private static extern RESULT FMOD5_System_GetSpeakerPosition(IntPtr system, SPEAKER speaker, out float x, out float y, out bool active);

		[PreserveSig]
		[Token(Token = "0x6000110")]
		[Address(RVA = "0x1E425E8", Offset = "0x1E425E8", VA = "0x1E425E8")]
		private static extern RESULT FMOD5_System_SetStreamBufferSize(IntPtr system, uint filebuffersize, TIMEUNIT filebuffersizetype);

		[PreserveSig]
		[Token(Token = "0x6000111")]
		[Address(RVA = "0x1E42688", Offset = "0x1E42688", VA = "0x1E42688")]
		private static extern RESULT FMOD5_System_GetStreamBufferSize(IntPtr system, out uint filebuffersize, out TIMEUNIT filebuffersizetype);

		[PreserveSig]
		[Token(Token = "0x6000112")]
		[Address(RVA = "0x1E42728", Offset = "0x1E42728", VA = "0x1E42728")]
		private static extern RESULT FMOD5_System_Set3DSettings(IntPtr system, float dopplerscale, float distancefactor, float rolloffscale);

		[PreserveSig]
		[Token(Token = "0x6000113")]
		[Address(RVA = "0x1E427D8", Offset = "0x1E427D8", VA = "0x1E427D8")]
		private static extern RESULT FMOD5_System_Get3DSettings(IntPtr system, out float dopplerscale, out float distancefactor, out float rolloffscale);

		[PreserveSig]
		[Token(Token = "0x6000114")]
		[Address(RVA = "0x1E42888", Offset = "0x1E42888", VA = "0x1E42888")]
		private static extern RESULT FMOD5_System_Set3DNumListeners(IntPtr system, int numlisteners);

		[PreserveSig]
		[Token(Token = "0x6000115")]
		[Address(RVA = "0x1E42920", Offset = "0x1E42920", VA = "0x1E42920")]
		private static extern RESULT FMOD5_System_Get3DNumListeners(IntPtr system, out int numlisteners);

		[PreserveSig]
		[Token(Token = "0x6000116")]
		[Address(RVA = "0x1E429B8", Offset = "0x1E429B8", VA = "0x1E429B8")]
		private static extern RESULT FMOD5_System_Set3DListenerAttributes(IntPtr system, int listener, ref VECTOR pos, ref VECTOR vel, ref VECTOR forward, ref VECTOR up);

		[PreserveSig]
		[Token(Token = "0x6000117")]
		[Address(RVA = "0x1E42A80", Offset = "0x1E42A80", VA = "0x1E42A80")]
		private static extern RESULT FMOD5_System_Get3DListenerAttributes(IntPtr system, int listener, out VECTOR pos, out VECTOR vel, out VECTOR forward, out VECTOR up);

		[PreserveSig]
		[Token(Token = "0x6000118")]
		[Address(RVA = "0x1E42B48", Offset = "0x1E42B48", VA = "0x1E42B48")]
		private static extern RESULT FMOD5_System_Set3DRolloffCallback(IntPtr system, CB_3D_ROLLOFF_CALLBACK callback);

		[PreserveSig]
		[Token(Token = "0x6000119")]
		[Address(RVA = "0x1E42BE8", Offset = "0x1E42BE8", VA = "0x1E42BE8")]
		private static extern RESULT FMOD5_System_MixerSuspend(IntPtr system);

		[PreserveSig]
		[Token(Token = "0x600011A")]
		[Address(RVA = "0x1E42C70", Offset = "0x1E42C70", VA = "0x1E42C70")]
		private static extern RESULT FMOD5_System_MixerResume(IntPtr system);

		[PreserveSig]
		[Token(Token = "0x600011B")]
		[Address(RVA = "0x1E42CF8", Offset = "0x1E42CF8", VA = "0x1E42CF8")]
		private static extern RESULT FMOD5_System_GetDefaultMixMatrix(IntPtr system, SPEAKERMODE sourcespeakermode, SPEAKERMODE targetspeakermode, float[] matrix, int matrixhop);

		[PreserveSig]
		[Token(Token = "0x600011C")]
		[Address(RVA = "0x1E42DB8", Offset = "0x1E42DB8", VA = "0x1E42DB8")]
		private static extern RESULT FMOD5_System_GetSpeakerModeChannels(IntPtr system, SPEAKERMODE mode, out int channels);

		[PreserveSig]
		[Token(Token = "0x600011D")]
		[Address(RVA = "0x1E42E58", Offset = "0x1E42E58", VA = "0x1E42E58")]
		private static extern RESULT FMOD5_System_GetVersion(IntPtr system, out uint version);

		[PreserveSig]
		[Token(Token = "0x600011E")]
		[Address(RVA = "0x1E42EF0", Offset = "0x1E42EF0", VA = "0x1E42EF0")]
		private static extern RESULT FMOD5_System_GetOutputHandle(IntPtr system, out IntPtr handle);

		[PreserveSig]
		[Token(Token = "0x600011F")]
		[Address(RVA = "0x1E42FD4", Offset = "0x1E42FD4", VA = "0x1E42FD4")]
		private static extern RESULT FMOD5_System_GetChannelsPlaying(IntPtr system, out int channels, IntPtr zero);

		[PreserveSig]
		[Token(Token = "0x6000120")]
		[Address(RVA = "0x1E43074", Offset = "0x1E43074", VA = "0x1E43074")]
		private static extern RESULT FMOD5_System_GetChannelsPlaying(IntPtr system, out int channels, out int realchannels);

		[PreserveSig]
		[Token(Token = "0x6000121")]
		[Address(RVA = "0x1E43114", Offset = "0x1E43114", VA = "0x1E43114")]
		private static extern RESULT FMOD5_System_GetCPUUsage(IntPtr system, out float dsp, out float stream, out float geometry, out float update, out float total);

		[PreserveSig]
		[Token(Token = "0x6000122")]
		[Address(RVA = "0x1E431DC", Offset = "0x1E431DC", VA = "0x1E431DC")]
		private static extern RESULT FMOD5_System_GetFileUsage(IntPtr system, out long sampleBytesRead, out long streamBytesRead, out long otherBytesRead);

		[PreserveSig]
		[Token(Token = "0x6000123")]
		[Address(RVA = "0x1E43430", Offset = "0x1E43430", VA = "0x1E43430")]
		private static extern RESULT FMOD5_System_CreateSound(IntPtr system, byte[] name_or_data, MODE mode, ref CREATESOUNDEXINFO exinfo, out IntPtr sound);

		[PreserveSig]
		[Token(Token = "0x6000124")]
		[Address(RVA = "0x1E4355C", Offset = "0x1E4355C", VA = "0x1E4355C")]
		private static extern RESULT FMOD5_System_CreateSound(IntPtr system, IntPtr name_or_data, MODE mode, ref CREATESOUNDEXINFO exinfo, out IntPtr sound);

		[PreserveSig]
		[Token(Token = "0x6000125")]
		[Address(RVA = "0x1E43908", Offset = "0x1E43908", VA = "0x1E43908")]
		private static extern RESULT FMOD5_System_CreateStream(IntPtr system, byte[] name_or_data, MODE mode, ref CREATESOUNDEXINFO exinfo, out IntPtr sound);

		[PreserveSig]
		[Token(Token = "0x6000126")]
		[Address(RVA = "0x1E43A34", Offset = "0x1E43A34", VA = "0x1E43A34")]
		private static extern RESULT FMOD5_System_CreateStream(IntPtr system, IntPtr name_or_data, MODE mode, ref CREATESOUNDEXINFO exinfo, out IntPtr sound);

		[PreserveSig]
		[Token(Token = "0x6000127")]
		[Address(RVA = "0x1E43C3C", Offset = "0x1E43C3C", VA = "0x1E43C3C")]
		private static extern RESULT FMOD5_System_CreateDSP(IntPtr system, ref DSP_DESCRIPTION description, out IntPtr dsp);

		[PreserveSig]
		[Token(Token = "0x6000128")]
		[Address(RVA = "0x1E43D3C", Offset = "0x1E43D3C", VA = "0x1E43D3C")]
		private static extern RESULT FMOD5_System_CreateDSPByType(IntPtr system, DSP_TYPE type, out IntPtr dsp);

		[PreserveSig]
		[Token(Token = "0x6000129")]
		[Address(RVA = "0x1E43F68", Offset = "0x1E43F68", VA = "0x1E43F68")]
		private static extern RESULT FMOD5_System_CreateChannelGroup(IntPtr system, byte[] name, out IntPtr channelgroup);

		[PreserveSig]
		[Token(Token = "0x600012A")]
		[Address(RVA = "0x1E4419C", Offset = "0x1E4419C", VA = "0x1E4419C")]
		private static extern RESULT FMOD5_System_CreateSoundGroup(IntPtr system, byte[] name, out IntPtr soundgroup);

		[PreserveSig]
		[Token(Token = "0x600012B")]
		[Address(RVA = "0x1E44244", Offset = "0x1E44244", VA = "0x1E44244")]
		private static extern RESULT FMOD5_System_CreateReverb3D(IntPtr system, out IntPtr reverb);

		[PreserveSig]
		[Token(Token = "0x600012C")]
		[Address(RVA = "0x1E442E0", Offset = "0x1E442E0", VA = "0x1E442E0")]
		private static extern RESULT FMOD5_System_PlaySound(IntPtr system, IntPtr sound, IntPtr channelgroup, bool paused, out IntPtr channel);

		[PreserveSig]
		[Token(Token = "0x600012D")]
		[Address(RVA = "0x1E4439C", Offset = "0x1E4439C", VA = "0x1E4439C")]
		private static extern RESULT FMOD5_System_PlayDSP(IntPtr system, IntPtr dsp, IntPtr channelgroup, bool paused, out IntPtr channel);

		[PreserveSig]
		[Token(Token = "0x600012E")]
		[Address(RVA = "0x1E44454", Offset = "0x1E44454", VA = "0x1E44454")]
		private static extern RESULT FMOD5_System_GetChannel(IntPtr system, int channelid, out IntPtr channel);

		[PreserveSig]
		[Token(Token = "0x600012F")]
		[Address(RVA = "0x1E444F4", Offset = "0x1E444F4", VA = "0x1E444F4")]
		private static extern RESULT FMOD5_System_GetMasterChannelGroup(IntPtr system, out IntPtr channelgroup);

		[PreserveSig]
		[Token(Token = "0x6000130")]
		[Address(RVA = "0x1E4458C", Offset = "0x1E4458C", VA = "0x1E4458C")]
		private static extern RESULT FMOD5_System_GetMasterSoundGroup(IntPtr system, out IntPtr soundgroup);

		[PreserveSig]
		[Token(Token = "0x6000131")]
		[Address(RVA = "0x1E44628", Offset = "0x1E44628", VA = "0x1E44628")]
		private static extern RESULT FMOD5_System_AttachChannelGroupToPort(IntPtr system, uint portType, ulong portIndex, IntPtr channelgroup, bool passThru);

		[PreserveSig]
		[Token(Token = "0x6000132")]
		[Address(RVA = "0x1E446E0", Offset = "0x1E446E0", VA = "0x1E446E0")]
		private static extern RESULT FMOD5_System_DetachChannelGroupFromPort(IntPtr system, IntPtr channelgroup);

		[PreserveSig]
		[Token(Token = "0x6000133")]
		[Address(RVA = "0x1E44778", Offset = "0x1E44778", VA = "0x1E44778")]
		private static extern RESULT FMOD5_System_SetReverbProperties(IntPtr system, int instance, ref REVERB_PROPERTIES prop);

		[PreserveSig]
		[Token(Token = "0x6000134")]
		[Address(RVA = "0x1E44818", Offset = "0x1E44818", VA = "0x1E44818")]
		private static extern RESULT FMOD5_System_GetReverbProperties(IntPtr system, int instance, out REVERB_PROPERTIES prop);

		[PreserveSig]
		[Token(Token = "0x6000135")]
		[Address(RVA = "0x1E448B8", Offset = "0x1E448B8", VA = "0x1E448B8")]
		private static extern RESULT FMOD5_System_LockDSP(IntPtr system);

		[PreserveSig]
		[Token(Token = "0x6000136")]
		[Address(RVA = "0x1E44940", Offset = "0x1E44940", VA = "0x1E44940")]
		private static extern RESULT FMOD5_System_UnlockDSP(IntPtr system);

		[PreserveSig]
		[Token(Token = "0x6000137")]
		[Address(RVA = "0x1E449C8", Offset = "0x1E449C8", VA = "0x1E449C8")]
		private static extern RESULT FMOD5_System_GetRecordNumDrivers(IntPtr system, out int numdrivers, out int numconnected);

		[PreserveSig]
		[Token(Token = "0x6000138")]
		[Address(RVA = "0x1E44C9C", Offset = "0x1E44C9C", VA = "0x1E44C9C")]
		private static extern RESULT FMOD5_System_GetRecordDriverInfo(IntPtr system, int id, IntPtr name, int namelen, out Guid guid, out int systemrate, out SPEAKERMODE speakermode, out int speakermodechannels, out DRIVER_STATE state);

		[PreserveSig]
		[Token(Token = "0x6000139")]
		[Address(RVA = "0x1E44E20", Offset = "0x1E44E20", VA = "0x1E44E20")]
		private static extern RESULT FMOD5_System_GetRecordPosition(IntPtr system, int id, out uint position);

		[PreserveSig]
		[Token(Token = "0x600013A")]
		[Address(RVA = "0x1E44EC4", Offset = "0x1E44EC4", VA = "0x1E44EC4")]
		private static extern RESULT FMOD5_System_RecordStart(IntPtr system, int id, IntPtr sound, bool loop);

		[PreserveSig]
		[Token(Token = "0x600013B")]
		[Address(RVA = "0x1E44F70", Offset = "0x1E44F70", VA = "0x1E44F70")]
		private static extern RESULT FMOD5_System_RecordStop(IntPtr system, int id);

		[PreserveSig]
		[Token(Token = "0x600013C")]
		[Address(RVA = "0x1E45008", Offset = "0x1E45008", VA = "0x1E45008")]
		private static extern RESULT FMOD5_System_IsRecording(IntPtr system, int id, out bool recording);

		[PreserveSig]
		[Token(Token = "0x600013D")]
		[Address(RVA = "0x1E450BC", Offset = "0x1E450BC", VA = "0x1E450BC")]
		private static extern RESULT FMOD5_System_CreateGeometry(IntPtr system, int maxpolygons, int maxvertices, out IntPtr geometry);

		[PreserveSig]
		[Token(Token = "0x600013E")]
		[Address(RVA = "0x1E4516C", Offset = "0x1E4516C", VA = "0x1E4516C")]
		private static extern RESULT FMOD5_System_SetGeometrySettings(IntPtr system, float maxworldsize);

		[PreserveSig]
		[Token(Token = "0x600013F")]
		[Address(RVA = "0x1E45204", Offset = "0x1E45204", VA = "0x1E45204")]
		private static extern RESULT FMOD5_System_GetGeometrySettings(IntPtr system, out float maxworldsize);

		[PreserveSig]
		[Token(Token = "0x6000140")]
		[Address(RVA = "0x1E4529C", Offset = "0x1E4529C", VA = "0x1E4529C")]
		private static extern RESULT FMOD5_System_LoadGeometry(IntPtr system, IntPtr data, int datasize, out IntPtr geometry);

		[PreserveSig]
		[Token(Token = "0x6000141")]
		[Address(RVA = "0x1E4534C", Offset = "0x1E4534C", VA = "0x1E4534C")]
		private static extern RESULT FMOD5_System_GetGeometryOcclusion(IntPtr system, ref VECTOR listener, ref VECTOR source, out float direct, out float reverb);

		[PreserveSig]
		[Token(Token = "0x6000142")]
		[Address(RVA = "0x1E45588", Offset = "0x1E45588", VA = "0x1E45588")]
		private static extern RESULT FMOD5_System_SetNetworkProxy(IntPtr system, byte[] proxy);

		[PreserveSig]
		[Token(Token = "0x6000143")]
		[Address(RVA = "0x1E4581C", Offset = "0x1E4581C", VA = "0x1E4581C")]
		private static extern RESULT FMOD5_System_GetNetworkProxy(IntPtr system, IntPtr proxy, int proxylen);

		[PreserveSig]
		[Token(Token = "0x6000144")]
		[Address(RVA = "0x1E458BC", Offset = "0x1E458BC", VA = "0x1E458BC")]
		private static extern RESULT FMOD5_System_SetNetworkTimeout(IntPtr system, int timeout);

		[PreserveSig]
		[Token(Token = "0x6000145")]
		[Address(RVA = "0x1E45954", Offset = "0x1E45954", VA = "0x1E45954")]
		private static extern RESULT FMOD5_System_GetNetworkTimeout(IntPtr system, out int timeout);

		[PreserveSig]
		[Token(Token = "0x6000146")]
		[Address(RVA = "0x1E459EC", Offset = "0x1E459EC", VA = "0x1E459EC")]
		private static extern RESULT FMOD5_System_SetUserData(IntPtr system, IntPtr userdata);

		[PreserveSig]
		[Token(Token = "0x6000147")]
		[Address(RVA = "0x1E45A84", Offset = "0x1E45A84", VA = "0x1E45A84")]
		private static extern RESULT FMOD5_System_GetUserData(IntPtr system, out IntPtr userdata);

		[Token(Token = "0x6000148")]
		[Address(RVA = "0x1E45B14", Offset = "0x1E45B14", VA = "0x1E45B14")]
		public bool hasHandle()
		{
			return default(bool);
		}

		[Token(Token = "0x6000149")]
		[Address(RVA = "0x1E45B5C", Offset = "0x1E45B5C", VA = "0x1E45B5C")]
		public void clearHandle()
		{
		}
	}
	[Token(Token = "0x2000048")]
	public struct Sound
	{
		[Token(Token = "0x400023F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public IntPtr handle;

		[Token(Token = "0x600014A")]
		[Address(RVA = "0x1E3B14C", Offset = "0x1E3B14C", VA = "0x1E3B14C")]
		public RESULT release()
		{
			return default(RESULT);
		}

		[Token(Token = "0x600014B")]
		[Address(RVA = "0x1E3B1D4", Offset = "0x1E3B1D4", VA = "0x1E3B1D4")]
		public RESULT getSystemObject(out System system)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600014C")]
		[Address(RVA = "0x1E3B26C", Offset = "0x1E3B26C", VA = "0x1E3B26C")]
		public RESULT @lock(uint offset, uint length, out IntPtr ptr1, out IntPtr ptr2, out uint len1, out uint len2)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600014D")]
		[Address(RVA = "0x1E3B33C", Offset = "0x1E3B33C", VA = "0x1E3B33C")]
		public RESULT unlock(IntPtr ptr1, IntPtr ptr2, uint len1, uint len2)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600014E")]
		[Address(RVA = "0x1E3B3F4", Offset = "0x1E3B3F4", VA = "0x1E3B3F4")]
		public RESULT setDefaults(float frequency, int priority)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600014F")]
		[Address(RVA = "0x1E3B49C", Offset = "0x1E3B49C", VA = "0x1E3B49C")]
		public RESULT getDefaults(out float frequency, out int priority)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000150")]
		[Address(RVA = "0x1E3B53C", Offset = "0x1E3B53C", VA = "0x1E3B53C")]
		public RESULT set3DMinMaxDistance(float min, float max)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000151")]
		[Address(RVA = "0x1E3B5DC", Offset = "0x1E3B5DC", VA = "0x1E3B5DC")]
		public RESULT get3DMinMaxDistance(out float min, out float max)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000152")]
		[Address(RVA = "0x1E3B67C", Offset = "0x1E3B67C", VA = "0x1E3B67C")]
		public RESULT set3DConeSettings(float insideconeangle, float outsideconeangle, float outsidevolume)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000153")]
		[Address(RVA = "0x1E3B72C", Offset = "0x1E3B72C", VA = "0x1E3B72C")]
		public RESULT get3DConeSettings(out float insideconeangle, out float outsideconeangle, out float outsidevolume)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000154")]
		[Address(RVA = "0x1E3B7DC", Offset = "0x1E3B7DC", VA = "0x1E3B7DC")]
		public RESULT set3DCustomRolloff(ref VECTOR points, int numpoints)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000155")]
		[Address(RVA = "0x1E3B87C", Offset = "0x1E3B87C", VA = "0x1E3B87C")]
		public RESULT get3DCustomRolloff(out IntPtr points, out int numpoints)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000156")]
		[Address(RVA = "0x1E3B91C", Offset = "0x1E3B91C", VA = "0x1E3B91C")]
		public RESULT getSubSound(int index, out Sound subsound)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000157")]
		[Address(RVA = "0x1E3B9BC", Offset = "0x1E3B9BC", VA = "0x1E3B9BC")]
		public RESULT getSubSoundParent(out Sound parentsound)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000158")]
		[Address(RVA = "0x1E3BA54", Offset = "0x1E3BA54", VA = "0x1E3BA54")]
		public RESULT getName(out string name, int namelen)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000159")]
		[Address(RVA = "0x1E3C1F0", Offset = "0x1E3C1F0", VA = "0x1E3C1F0")]
		public RESULT getLength(out uint length, TIMEUNIT lengthtype)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600015A")]
		[Address(RVA = "0x1E3C290", Offset = "0x1E3C290", VA = "0x1E3C290")]
		public RESULT getFormat(out SOUND_TYPE type, out SOUND_FORMAT format, out int channels, out int bits)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600015B")]
		[Address(RVA = "0x1E3C348", Offset = "0x1E3C348", VA = "0x1E3C348")]
		public RESULT getNumSubSounds(out int numsubsounds)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600015C")]
		[Address(RVA = "0x1E3C3E0", Offset = "0x1E3C3E0", VA = "0x1E3C3E0")]
		public RESULT getNumTags(out int numtags, out int numtagsupdated)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600015D")]
		[Address(RVA = "0x1E3C480", Offset = "0x1E3C480", VA = "0x1E3C480")]
		public RESULT getTag(string name, int index, out TAG tag)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600015E")]
		[Address(RVA = "0x1E3C83C", Offset = "0x1E3C83C", VA = "0x1E3C83C")]
		public RESULT getOpenState(out OPENSTATE openstate, out uint percentbuffered, out bool starving, out bool diskbusy)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600015F")]
		[Address(RVA = "0x1E3C918", Offset = "0x1E3C918", VA = "0x1E3C918")]
		public RESULT readData(IntPtr buffer, uint length, out uint read)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000160")]
		[Address(RVA = "0x1E3C9C8", Offset = "0x1E3C9C8", VA = "0x1E3C9C8")]
		public RESULT seekData(uint pcm)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000161")]
		[Address(RVA = "0x1E3CA60", Offset = "0x1E3CA60", VA = "0x1E3CA60")]
		public RESULT setSoundGroup(SoundGroup soundgroup)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000162")]
		[Address(RVA = "0x1E3CAF8", Offset = "0x1E3CAF8", VA = "0x1E3CAF8")]
		public RESULT getSoundGroup(out SoundGroup soundgroup)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000163")]
		[Address(RVA = "0x1E3CB90", Offset = "0x1E3CB90", VA = "0x1E3CB90")]
		public RESULT getNumSyncPoints(out int numsyncpoints)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000164")]
		[Address(RVA = "0x1E3CC28", Offset = "0x1E3CC28", VA = "0x1E3CC28")]
		public RESULT getSyncPoint(int index, out IntPtr point)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000165")]
		[Address(RVA = "0x1E3CCC8", Offset = "0x1E3CCC8", VA = "0x1E3CCC8")]
		public RESULT getSyncPointInfo(IntPtr point, out string name, int namelen, out uint offset, TIMEUNIT offsettype)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000166")]
		[Address(RVA = "0x1E3CF9C", Offset = "0x1E3CF9C", VA = "0x1E3CF9C")]
		public RESULT getSyncPointInfo(IntPtr point, out uint offset, TIMEUNIT offsettype)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000167")]
		[Address(RVA = "0x1E3D00C", Offset = "0x1E3D00C", VA = "0x1E3D00C")]
		public RESULT addSyncPoint(uint offset, TIMEUNIT offsettype, string name, out IntPtr point)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000168")]
		[Address(RVA = "0x1E3D270", Offset = "0x1E3D270", VA = "0x1E3D270")]
		public RESULT deleteSyncPoint(IntPtr point)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000169")]
		[Address(RVA = "0x1E3D308", Offset = "0x1E3D308", VA = "0x1E3D308")]
		public RESULT setMode(MODE mode)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600016A")]
		[Address(RVA = "0x1E3D3A0", Offset = "0x1E3D3A0", VA = "0x1E3D3A0")]
		public RESULT getMode(out MODE mode)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600016B")]
		[Address(RVA = "0x1E3D438", Offset = "0x1E3D438", VA = "0x1E3D438")]
		public RESULT setLoopCount(int loopcount)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600016C")]
		[Address(RVA = "0x1E3D4D0", Offset = "0x1E3D4D0", VA = "0x1E3D4D0")]
		public RESULT getLoopCount(out int loopcount)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600016D")]
		[Address(RVA = "0x1E3D568", Offset = "0x1E3D568", VA = "0x1E3D568")]
		public RESULT setLoopPoints(uint loopstart, TIMEUNIT loopstarttype, uint loopend, TIMEUNIT loopendtype)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600016E")]
		[Address(RVA = "0x1E3D620", Offset = "0x1E3D620", VA = "0x1E3D620")]
		public RESULT getLoopPoints(out uint loopstart, TIMEUNIT loopstarttype, out uint loopend, TIMEUNIT loopendtype)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600016F")]
		[Address(RVA = "0x1E3D6D8", Offset = "0x1E3D6D8", VA = "0x1E3D6D8")]
		public RESULT getMusicNumChannels(out int numchannels)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000170")]
		[Address(RVA = "0x1E3D770", Offset = "0x1E3D770", VA = "0x1E3D770")]
		public RESULT setMusicChannelVolume(int channel, float volume)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000171")]
		[Address(RVA = "0x1E3D818", Offset = "0x1E3D818", VA = "0x1E3D818")]
		public RESULT getMusicChannelVolume(int channel, out float volume)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000172")]
		[Address(RVA = "0x1E3D8B8", Offset = "0x1E3D8B8", VA = "0x1E3D8B8")]
		public RESULT setMusicSpeed(float speed)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000173")]
		[Address(RVA = "0x1E3D950", Offset = "0x1E3D950", VA = "0x1E3D950")]
		public RESULT getMusicSpeed(out float speed)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000174")]
		[Address(RVA = "0x1E3D9E8", Offset = "0x1E3D9E8", VA = "0x1E3D9E8")]
		public RESULT setUserData(IntPtr userdata)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000175")]
		[Address(RVA = "0x1E3DA80", Offset = "0x1E3DA80", VA = "0x1E3DA80")]
		public RESULT getUserData(out IntPtr userdata)
		{
			return default(RESULT);
		}

		[PreserveSig]
		[Token(Token = "0x6000176")]
		[Address(RVA = "0x1E3B154", Offset = "0x1E3B154", VA = "0x1E3B154")]
		private static extern RESULT FMOD5_Sound_Release(IntPtr sound);

		[PreserveSig]
		[Token(Token = "0x6000177")]
		[Address(RVA = "0x1E3B1DC", Offset = "0x1E3B1DC", VA = "0x1E3B1DC")]
		private static extern RESULT FMOD5_Sound_GetSystemObject(IntPtr sound, out IntPtr system);

		[PreserveSig]
		[Token(Token = "0x6000178")]
		[Address(RVA = "0x1E3B274", Offset = "0x1E3B274", VA = "0x1E3B274")]
		private static extern RESULT FMOD5_Sound_Lock(IntPtr sound, uint offset, uint length, out IntPtr ptr1, out IntPtr ptr2, out uint len1, out uint len2);

		[PreserveSig]
		[Token(Token = "0x6000179")]
		[Address(RVA = "0x1E3B344", Offset = "0x1E3B344", VA = "0x1E3B344")]
		private static extern RESULT FMOD5_Sound_Unlock(IntPtr sound, IntPtr ptr1, IntPtr ptr2, uint len1, uint len2);

		[PreserveSig]
		[Token(Token = "0x600017A")]
		[Address(RVA = "0x1E3B3FC", Offset = "0x1E3B3FC", VA = "0x1E3B3FC")]
		private static extern RESULT FMOD5_Sound_SetDefaults(IntPtr sound, float frequency, int priority);

		[PreserveSig]
		[Token(Token = "0x600017B")]
		[Address(RVA = "0x1E3B4A4", Offset = "0x1E3B4A4", VA = "0x1E3B4A4")]
		private static extern RESULT FMOD5_Sound_GetDefaults(IntPtr sound, out float frequency, out int priority);

		[PreserveSig]
		[Token(Token = "0x600017C")]
		[Address(RVA = "0x1E3B544", Offset = "0x1E3B544", VA = "0x1E3B544")]
		private static extern RESULT FMOD5_Sound_Set3DMinMaxDistance(IntPtr sound, float min, float max);

		[PreserveSig]
		[Token(Token = "0x600017D")]
		[Address(RVA = "0x1E3B5E4", Offset = "0x1E3B5E4", VA = "0x1E3B5E4")]
		private static extern RESULT FMOD5_Sound_Get3DMinMaxDistance(IntPtr sound, out float min, out float max);

		[PreserveSig]
		[Token(Token = "0x600017E")]
		[Address(RVA = "0x1E3B684", Offset = "0x1E3B684", VA = "0x1E3B684")]
		private static extern RESULT FMOD5_Sound_Set3DConeSettings(IntPtr sound, float insideconeangle, float outsideconeangle, float outsidevolume);

		[PreserveSig]
		[Token(Token = "0x600017F")]
		[Address(RVA = "0x1E3B734", Offset = "0x1E3B734", VA = "0x1E3B734")]
		private static extern RESULT FMOD5_Sound_Get3DConeSettings(IntPtr sound, out float insideconeangle, out float outsideconeangle, out float outsidevolume);

		[PreserveSig]
		[Token(Token = "0x6000180")]
		[Address(RVA = "0x1E3B7E4", Offset = "0x1E3B7E4", VA = "0x1E3B7E4")]
		private static extern RESULT FMOD5_Sound_Set3DCustomRolloff(IntPtr sound, ref VECTOR points, int numpoints);

		[PreserveSig]
		[Token(Token = "0x6000181")]
		[Address(RVA = "0x1E3B884", Offset = "0x1E3B884", VA = "0x1E3B884")]
		private static extern RESULT FMOD5_Sound_Get3DCustomRolloff(IntPtr sound, out IntPtr points, out int numpoints);

		[PreserveSig]
		[Token(Token = "0x6000182")]
		[Address(RVA = "0x1E3B924", Offset = "0x1E3B924", VA = "0x1E3B924")]
		private static extern RESULT FMOD5_Sound_GetSubSound(IntPtr sound, int index, out IntPtr subsound);

		[PreserveSig]
		[Token(Token = "0x6000183")]
		[Address(RVA = "0x1E3B9C4", Offset = "0x1E3B9C4", VA = "0x1E3B9C4")]
		private static extern RESULT FMOD5_Sound_GetSubSoundParent(IntPtr sound, out IntPtr parentsound);

		[PreserveSig]
		[Token(Token = "0x6000184")]
		[Address(RVA = "0x1E3BC50", Offset = "0x1E3BC50", VA = "0x1E3BC50")]
		private static extern RESULT FMOD5_Sound_GetName(IntPtr sound, IntPtr name, int namelen);

		[PreserveSig]
		[Token(Token = "0x6000185")]
		[Address(RVA = "0x1E3C1F8", Offset = "0x1E3C1F8", VA = "0x1E3C1F8")]
		private static extern RESULT FMOD5_Sound_GetLength(IntPtr sound, out uint length, TIMEUNIT lengthtype);

		[PreserveSig]
		[Token(Token = "0x6000186")]
		[Address(RVA = "0x1E3C298", Offset = "0x1E3C298", VA = "0x1E3C298")]
		private static extern RESULT FMOD5_Sound_GetFormat(IntPtr sound, out SOUND_TYPE type, out SOUND_FORMAT format, out int channels, out int bits);

		[PreserveSig]
		[Token(Token = "0x6000187")]
		[Address(RVA = "0x1E3C350", Offset = "0x1E3C350", VA = "0x1E3C350")]
		private static extern RESULT FMOD5_Sound_GetNumSubSounds(IntPtr sound, out int numsubsounds);

		[PreserveSig]
		[Token(Token = "0x6000188")]
		[Address(RVA = "0x1E3C3E8", Offset = "0x1E3C3E8", VA = "0x1E3C3E8")]
		private static extern RESULT FMOD5_Sound_GetNumTags(IntPtr sound, out int numtags, out int numtagsupdated);

		[PreserveSig]
		[Token(Token = "0x6000189")]
		[Address(RVA = "0x1E3C758", Offset = "0x1E3C758", VA = "0x1E3C758")]
		private static extern RESULT FMOD5_Sound_GetTag(IntPtr sound, byte[] name, int index, out TAG tag);

		[PreserveSig]
		[Token(Token = "0x600018A")]
		[Address(RVA = "0x1E3C844", Offset = "0x1E3C844", VA = "0x1E3C844")]
		private static extern RESULT FMOD5_Sound_GetOpenState(IntPtr sound, out OPENSTATE openstate, out uint percentbuffered, out bool starving, out bool diskbusy);

		[PreserveSig]
		[Token(Token = "0x600018B")]
		[Address(RVA = "0x1E3C920", Offset = "0x1E3C920", VA = "0x1E3C920")]
		private static extern RESULT FMOD5_Sound_ReadData(IntPtr sound, IntPtr buffer, uint length, out uint read);

		[PreserveSig]
		[Token(Token = "0x600018C")]
		[Address(RVA = "0x1E3C9D0", Offset = "0x1E3C9D0", VA = "0x1E3C9D0")]
		private static extern RESULT FMOD5_Sound_SeekData(IntPtr sound, uint pcm);

		[PreserveSig]
		[Token(Token = "0x600018D")]
		[Address(RVA = "0x1E3CA68", Offset = "0x1E3CA68", VA = "0x1E3CA68")]
		private static extern RESULT FMOD5_Sound_SetSoundGroup(IntPtr sound, IntPtr soundgroup);

		[PreserveSig]
		[Token(Token = "0x600018E")]
		[Address(RVA = "0x1E3CB00", Offset = "0x1E3CB00", VA = "0x1E3CB00")]
		private static extern RESULT FMOD5_Sound_GetSoundGroup(IntPtr sound, out IntPtr soundgroup);

		[PreserveSig]
		[Token(Token = "0x600018F")]
		[Address(RVA = "0x1E3CB98", Offset = "0x1E3CB98", VA = "0x1E3CB98")]
		private static extern RESULT FMOD5_Sound_GetNumSyncPoints(IntPtr sound, out int numsyncpoints);

		[PreserveSig]
		[Token(Token = "0x6000190")]
		[Address(RVA = "0x1E3CC30", Offset = "0x1E3CC30", VA = "0x1E3CC30")]
		private static extern RESULT FMOD5_Sound_GetSyncPoint(IntPtr sound, int index, out IntPtr point);

		[PreserveSig]
		[Token(Token = "0x6000191")]
		[Address(RVA = "0x1E3CEDC", Offset = "0x1E3CEDC", VA = "0x1E3CEDC")]
		private static extern RESULT FMOD5_Sound_GetSyncPointInfo(IntPtr sound, IntPtr point, IntPtr name, int namelen, out uint offset, TIMEUNIT offsettype);

		[PreserveSig]
		[Token(Token = "0x6000192")]
		[Address(RVA = "0x1E3D1B8", Offset = "0x1E3D1B8", VA = "0x1E3D1B8")]
		private static extern RESULT FMOD5_Sound_AddSyncPoint(IntPtr sound, uint offset, TIMEUNIT offsettype, byte[] name, out IntPtr point);

		[PreserveSig]
		[Token(Token = "0x6000193")]
		[Address(RVA = "0x1E3D278", Offset = "0x1E3D278", VA = "0x1E3D278")]
		private static extern RESULT FMOD5_Sound_DeleteSyncPoint(IntPtr sound, IntPtr point);

		[PreserveSig]
		[Token(Token = "0x6000194")]
		[Address(RVA = "0x1E3D310", Offset = "0x1E3D310", VA = "0x1E3D310")]
		private static extern RESULT FMOD5_Sound_SetMode(IntPtr sound, MODE mode);

		[PreserveSig]
		[Token(Token = "0x6000195")]
		[Address(RVA = "0x1E3D3A8", Offset = "0x1E3D3A8", VA = "0x1E3D3A8")]
		private static extern RESULT FMOD5_Sound_GetMode(IntPtr sound, out MODE mode);

		[PreserveSig]
		[Token(Token = "0x6000196")]
		[Address(RVA = "0x1E3D440", Offset = "0x1E3D440", VA = "0x1E3D440")]
		private static extern RESULT FMOD5_Sound_SetLoopCount(IntPtr sound, int loopcount);

		[PreserveSig]
		[Token(Token = "0x6000197")]
		[Address(RVA = "0x1E3D4D8", Offset = "0x1E3D4D8", VA = "0x1E3D4D8")]
		private static extern RESULT FMOD5_Sound_GetLoopCount(IntPtr sound, out int loopcount);

		[PreserveSig]
		[Token(Token = "0x6000198")]
		[Address(RVA = "0x1E3D570", Offset = "0x1E3D570", VA = "0x1E3D570")]
		private static extern RESULT FMOD5_Sound_SetLoopPoints(IntPtr sound, uint loopstart, TIMEUNIT loopstarttype, uint loopend, TIMEUNIT loopendtype);

		[PreserveSig]
		[Token(Token = "0x6000199")]
		[Address(RVA = "0x1E3D628", Offset = "0x1E3D628", VA = "0x1E3D628")]
		private static extern RESULT FMOD5_Sound_GetLoopPoints(IntPtr sound, out uint loopstart, TIMEUNIT loopstarttype, out uint loopend, TIMEUNIT loopendtype);

		[PreserveSig]
		[Token(Token = "0x600019A")]
		[Address(RVA = "0x1E3D6E0", Offset = "0x1E3D6E0", VA = "0x1E3D6E0")]
		private static extern RESULT FMOD5_Sound_GetMusicNumChannels(IntPtr sound, out int numchannels);

		[PreserveSig]
		[Token(Token = "0x600019B")]
		[Address(RVA = "0x1E3D778", Offset = "0x1E3D778", VA = "0x1E3D778")]
		private static extern RESULT FMOD5_Sound_SetMusicChannelVolume(IntPtr sound, int channel, float volume);

		[PreserveSig]
		[Token(Token = "0x600019C")]
		[Address(RVA = "0x1E3D820", Offset = "0x1E3D820", VA = "0x1E3D820")]
		private static extern RESULT FMOD5_Sound_GetMusicChannelVolume(IntPtr sound, int channel, out float volume);

		[PreserveSig]
		[Token(Token = "0x600019D")]
		[Address(RVA = "0x1E3D8C0", Offset = "0x1E3D8C0", VA = "0x1E3D8C0")]
		private static extern RESULT FMOD5_Sound_SetMusicSpeed(IntPtr sound, float speed);

		[PreserveSig]
		[Token(Token = "0x600019E")]
		[Address(RVA = "0x1E3D958", Offset = "0x1E3D958", VA = "0x1E3D958")]
		private static extern RESULT FMOD5_Sound_GetMusicSpeed(IntPtr sound, out float speed);

		[PreserveSig]
		[Token(Token = "0x600019F")]
		[Address(RVA = "0x1E3D9F0", Offset = "0x1E3D9F0", VA = "0x1E3D9F0")]
		private static extern RESULT FMOD5_Sound_SetUserData(IntPtr sound, IntPtr userdata);

		[PreserveSig]
		[Token(Token = "0x60001A0")]
		[Address(RVA = "0x1E3DA88", Offset = "0x1E3DA88", VA = "0x1E3DA88")]
		private static extern RESULT FMOD5_Sound_GetUserData(IntPtr sound, out IntPtr userdata);

		[Token(Token = "0x60001A1")]
		[Address(RVA = "0x1E3DB18", Offset = "0x1E3DB18", VA = "0x1E3DB18")]
		public bool hasHandle()
		{
			return default(bool);
		}

		[Token(Token = "0x60001A2")]
		[Address(RVA = "0x1E3DB60", Offset = "0x1E3DB60", VA = "0x1E3DB60")]
		public void clearHandle()
		{
		}
	}
	[Token(Token = "0x2000049")]
	internal interface IChannelControl
	{
		[Token(Token = "0x60001A3")]
		RESULT getSystemObject(out System system);

		[Token(Token = "0x60001A4")]
		RESULT stop();

		[Token(Token = "0x60001A5")]
		RESULT setPaused(bool paused);

		[Token(Token = "0x60001A6")]
		RESULT getPaused(out bool paused);

		[Token(Token = "0x60001A7")]
		RESULT setVolume(float volume);

		[Token(Token = "0x60001A8")]
		RESULT getVolume(out float volume);

		[Token(Token = "0x60001A9")]
		RESULT setVolumeRamp(bool ramp);

		[Token(Token = "0x60001AA")]
		RESULT getVolumeRamp(out bool ramp);

		[Token(Token = "0x60001AB")]
		RESULT getAudibility(out float audibility);

		[Token(Token = "0x60001AC")]
		RESULT setPitch(float pitch);

		[Token(Token = "0x60001AD")]
		RESULT getPitch(out float pitch);

		[Token(Token = "0x60001AE")]
		RESULT setMute(bool mute);

		[Token(Token = "0x60001AF")]
		RESULT getMute(out bool mute);

		[Token(Token = "0x60001B0")]
		RESULT setReverbProperties(int instance, float wet);

		[Token(Token = "0x60001B1")]
		RESULT getReverbProperties(int instance, out float wet);

		[Token(Token = "0x60001B2")]
		RESULT setLowPassGain(float gain);

		[Token(Token = "0x60001B3")]
		RESULT getLowPassGain(out float gain);

		[Token(Token = "0x60001B4")]
		RESULT setMode(MODE mode);

		[Token(Token = "0x60001B5")]
		RESULT getMode(out MODE mode);

		[Token(Token = "0x60001B6")]
		RESULT setCallback(CHANNELCONTROL_CALLBACK callback);

		[Token(Token = "0x60001B7")]
		RESULT isPlaying(out bool isplaying);

		[Token(Token = "0x60001B8")]
		RESULT setPan(float pan);

		[Token(Token = "0x60001B9")]
		RESULT setMixLevelsOutput(float frontleft, float frontright, float center, float lfe, float surroundleft, float surroundright, float backleft, float backright);

		[Token(Token = "0x60001BA")]
		RESULT setMixLevelsInput(float[] levels, int numlevels);

		[Token(Token = "0x60001BB")]
		RESULT setMixMatrix(float[] matrix, int outchannels, int inchannels, int inchannel_hop);

		[Token(Token = "0x60001BC")]
		RESULT getMixMatrix(float[] matrix, out int outchannels, out int inchannels, int inchannel_hop);

		[Token(Token = "0x60001BD")]
		RESULT getDSPClock(out ulong dspclock, out ulong parentclock);

		[Token(Token = "0x60001BE")]
		RESULT setDelay(ulong dspclock_start, ulong dspclock_end, bool stopchannels);

		[Token(Token = "0x60001BF")]
		RESULT getDelay(out ulong dspclock_start, out ulong dspclock_end);

		[Token(Token = "0x60001C0")]
		RESULT getDelay(out ulong dspclock_start, out ulong dspclock_end, out bool stopchannels);

		[Token(Token = "0x60001C1")]
		RESULT addFadePoint(ulong dspclock, float volume);

		[Token(Token = "0x60001C2")]
		RESULT setFadePointRamp(ulong dspclock, float volume);

		[Token(Token = "0x60001C3")]
		RESULT removeFadePoints(ulong dspclock_start, ulong dspclock_end);

		[Token(Token = "0x60001C4")]
		RESULT getFadePoints(ref uint numpoints, ulong[] point_dspclock, float[] point_volume);

		[Token(Token = "0x60001C5")]
		RESULT getDSP(int index, out DSP dsp);

		[Token(Token = "0x60001C6")]
		RESULT addDSP(int index, DSP dsp);

		[Token(Token = "0x60001C7")]
		RESULT removeDSP(DSP dsp);

		[Token(Token = "0x60001C8")]
		RESULT getNumDSPs(out int numdsps);

		[Token(Token = "0x60001C9")]
		RESULT setDSPIndex(DSP dsp, int index);

		[Token(Token = "0x60001CA")]
		RESULT getDSPIndex(DSP dsp, out int index);

		[Token(Token = "0x60001CB")]
		RESULT set3DAttributes(ref VECTOR pos, ref VECTOR vel);

		[Token(Token = "0x60001CC")]
		RESULT get3DAttributes(out VECTOR pos, out VECTOR vel);

		[Token(Token = "0x60001CD")]
		RESULT set3DMinMaxDistance(float mindistance, float maxdistance);

		[Token(Token = "0x60001CE")]
		RESULT get3DMinMaxDistance(out float mindistance, out float maxdistance);

		[Token(Token = "0x60001CF")]
		RESULT set3DConeSettings(float insideconeangle, float outsideconeangle, float outsidevolume);

		[Token(Token = "0x60001D0")]
		RESULT get3DConeSettings(out float insideconeangle, out float outsideconeangle, out float outsidevolume);

		[Token(Token = "0x60001D1")]
		RESULT set3DConeOrientation(ref VECTOR orientation);

		[Token(Token = "0x60001D2")]
		RESULT get3DConeOrientation(out VECTOR orientation);

		[Token(Token = "0x60001D3")]
		RESULT set3DCustomRolloff(ref VECTOR points, int numpoints);

		[Token(Token = "0x60001D4")]
		RESULT get3DCustomRolloff(out IntPtr points, out int numpoints);

		[Token(Token = "0x60001D5")]
		RESULT set3DOcclusion(float directocclusion, float reverbocclusion);

		[Token(Token = "0x60001D6")]
		RESULT get3DOcclusion(out float directocclusion, out float reverbocclusion);

		[Token(Token = "0x60001D7")]
		RESULT set3DSpread(float angle);

		[Token(Token = "0x60001D8")]
		RESULT get3DSpread(out float angle);

		[Token(Token = "0x60001D9")]
		RESULT set3DLevel(float level);

		[Token(Token = "0x60001DA")]
		RESULT get3DLevel(out float level);

		[Token(Token = "0x60001DB")]
		RESULT set3DDopplerLevel(float level);

		[Token(Token = "0x60001DC")]
		RESULT get3DDopplerLevel(out float level);

		[Token(Token = "0x60001DD")]
		RESULT set3DDistanceFilter(bool custom, float customLevel, float centerFreq);

		[Token(Token = "0x60001DE")]
		RESULT get3DDistanceFilter(out bool custom, out float customLevel, out float centerFreq);

		[Token(Token = "0x60001DF")]
		RESULT setUserData(IntPtr userdata);

		[Token(Token = "0x60001E0")]
		RESULT getUserData(out IntPtr userdata);
	}
	[Token(Token = "0x200004A")]
	public struct Channel : IChannelControl
	{
		[Token(Token = "0x4000240")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public IntPtr handle;

		[Token(Token = "0x60001E1")]
		[Address(RVA = "0xC1A588", Offset = "0xC1A588", VA = "0xC1A588")]
		public RESULT setFrequency(float frequency)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60001E2")]
		[Address(RVA = "0xC1A620", Offset = "0xC1A620", VA = "0xC1A620")]
		public RESULT getFrequency(out float frequency)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60001E3")]
		[Address(RVA = "0xC1A6B8", Offset = "0xC1A6B8", VA = "0xC1A6B8")]
		public RESULT setPriority(int priority)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60001E4")]
		[Address(RVA = "0xC1A750", Offset = "0xC1A750", VA = "0xC1A750")]
		public RESULT getPriority(out int priority)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60001E5")]
		[Address(RVA = "0xC1A7E8", Offset = "0xC1A7E8", VA = "0xC1A7E8")]
		public RESULT setPosition(uint position, TIMEUNIT postype)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60001E6")]
		[Address(RVA = "0xC1A888", Offset = "0xC1A888", VA = "0xC1A888")]
		public RESULT getPosition(out uint position, TIMEUNIT postype)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60001E7")]
		[Address(RVA = "0xC1A928", Offset = "0xC1A928", VA = "0xC1A928")]
		public RESULT setChannelGroup(ChannelGroup channelgroup)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60001E8")]
		[Address(RVA = "0xC1A9C0", Offset = "0xC1A9C0", VA = "0xC1A9C0")]
		public RESULT getChannelGroup(out ChannelGroup channelgroup)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60001E9")]
		[Address(RVA = "0xC1AA58", Offset = "0xC1AA58", VA = "0xC1AA58")]
		public RESULT setLoopCount(int loopcount)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60001EA")]
		[Address(RVA = "0xC1AAF0", Offset = "0xC1AAF0", VA = "0xC1AAF0")]
		public RESULT getLoopCount(out int loopcount)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60001EB")]
		[Address(RVA = "0xC1AB88", Offset = "0xC1AB88", VA = "0xC1AB88")]
		public RESULT setLoopPoints(uint loopstart, TIMEUNIT loopstarttype, uint loopend, TIMEUNIT loopendtype)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60001EC")]
		[Address(RVA = "0xC1AC40", Offset = "0xC1AC40", VA = "0xC1AC40")]
		public RESULT getLoopPoints(out uint loopstart, TIMEUNIT loopstarttype, out uint loopend, TIMEUNIT loopendtype)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60001ED")]
		[Address(RVA = "0xC1ACF8", Offset = "0xC1ACF8", VA = "0xC1ACF8")]
		public RESULT isVirtual(out bool isvirtual)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60001EE")]
		[Address(RVA = "0xC1ADA4", Offset = "0xC1ADA4", VA = "0xC1ADA4")]
		public RESULT getCurrentSound(out Sound sound)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60001EF")]
		[Address(RVA = "0xC1AE3C", Offset = "0xC1AE3C", VA = "0xC1AE3C")]
		public RESULT getIndex(out int index)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60001F0")]
		[Address(RVA = "0xC1AED4", Offset = "0xC1AED4", VA = "0xC1AED4", Slot = "4")]
		public RESULT getSystemObject(out System system)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60001F1")]
		[Address(RVA = "0xC1AF6C", Offset = "0xC1AF6C", VA = "0xC1AF6C", Slot = "5")]
		public RESULT stop()
		{
			return default(RESULT);
		}

		[Token(Token = "0x60001F2")]
		[Address(RVA = "0xC1AFF4", Offset = "0xC1AFF4", VA = "0xC1AFF4", Slot = "6")]
		public RESULT setPaused(bool paused)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60001F3")]
		[Address(RVA = "0xC1B090", Offset = "0xC1B090", VA = "0xC1B090", Slot = "7")]
		public RESULT getPaused(out bool paused)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60001F4")]
		[Address(RVA = "0xC1B13C", Offset = "0xC1B13C", VA = "0xC1B13C", Slot = "8")]
		public RESULT setVolume(float volume)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60001F5")]
		[Address(RVA = "0xC1B1D4", Offset = "0xC1B1D4", VA = "0xC1B1D4", Slot = "9")]
		public RESULT getVolume(out float volume)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60001F6")]
		[Address(RVA = "0xC1B26C", Offset = "0xC1B26C", VA = "0xC1B26C", Slot = "10")]
		public RESULT setVolumeRamp(bool ramp)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60001F7")]
		[Address(RVA = "0xC1B308", Offset = "0xC1B308", VA = "0xC1B308", Slot = "11")]
		public RESULT getVolumeRamp(out bool ramp)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60001F8")]
		[Address(RVA = "0xC1B3B4", Offset = "0xC1B3B4", VA = "0xC1B3B4", Slot = "12")]
		public RESULT getAudibility(out float audibility)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60001F9")]
		[Address(RVA = "0xC1B44C", Offset = "0xC1B44C", VA = "0xC1B44C", Slot = "13")]
		public RESULT setPitch(float pitch)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60001FA")]
		[Address(RVA = "0xC1B4E4", Offset = "0xC1B4E4", VA = "0xC1B4E4", Slot = "14")]
		public RESULT getPitch(out float pitch)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60001FB")]
		[Address(RVA = "0xC1B57C", Offset = "0xC1B57C", VA = "0xC1B57C", Slot = "15")]
		public RESULT setMute(bool mute)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60001FC")]
		[Address(RVA = "0xC1B618", Offset = "0xC1B618", VA = "0xC1B618", Slot = "16")]
		public RESULT getMute(out bool mute)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60001FD")]
		[Address(RVA = "0xC1B6C4", Offset = "0xC1B6C4", VA = "0xC1B6C4", Slot = "17")]
		public RESULT setReverbProperties(int instance, float wet)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60001FE")]
		[Address(RVA = "0xC1B76C", Offset = "0xC1B76C", VA = "0xC1B76C", Slot = "18")]
		public RESULT getReverbProperties(int instance, out float wet)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60001FF")]
		[Address(RVA = "0xC1B80C", Offset = "0xC1B80C", VA = "0xC1B80C", Slot = "19")]
		public RESULT setLowPassGain(float gain)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000200")]
		[Address(RVA = "0xC1B8A4", Offset = "0xC1B8A4", VA = "0xC1B8A4", Slot = "20")]
		public RESULT getLowPassGain(out float gain)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000201")]
		[Address(RVA = "0xC1B93C", Offset = "0xC1B93C", VA = "0xC1B93C", Slot = "21")]
		public RESULT setMode(MODE mode)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000202")]
		[Address(RVA = "0xC1B9D4", Offset = "0xC1B9D4", VA = "0xC1B9D4", Slot = "22")]
		public RESULT getMode(out MODE mode)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000203")]
		[Address(RVA = "0xC1BA6C", Offset = "0xC1BA6C", VA = "0xC1BA6C", Slot = "23")]
		public RESULT setCallback(CHANNELCONTROL_CALLBACK callback)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000204")]
		[Address(RVA = "0xC1BB0C", Offset = "0xC1BB0C", VA = "0xC1BB0C", Slot = "24")]
		public RESULT isPlaying(out bool isplaying)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000205")]
		[Address(RVA = "0xC1BBB8", Offset = "0xC1BBB8", VA = "0xC1BBB8", Slot = "25")]
		public RESULT setPan(float pan)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000206")]
		[Address(RVA = "0xC1BC50", Offset = "0xC1BC50", VA = "0xC1BC50", Slot = "26")]
		public RESULT setMixLevelsOutput(float frontleft, float frontright, float center, float lfe, float surroundleft, float surroundright, float backleft, float backright)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000207")]
		[Address(RVA = "0xC1BD38", Offset = "0xC1BD38", VA = "0xC1BD38", Slot = "27")]
		public RESULT setMixLevelsInput(float[] levels, int numlevels)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000208")]
		[Address(RVA = "0xC1BDE0", Offset = "0xC1BDE0", VA = "0xC1BDE0", Slot = "28")]
		public RESULT setMixMatrix(float[] matrix, int outchannels, int inchannels, int inchannel_hop = 0)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000209")]
		[Address(RVA = "0xC1BEA0", Offset = "0xC1BEA0", VA = "0xC1BEA0", Slot = "29")]
		public RESULT getMixMatrix(float[] matrix, out int outchannels, out int inchannels, int inchannel_hop = 0)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600020A")]
		[Address(RVA = "0xC1BF60", Offset = "0xC1BF60", VA = "0xC1BF60", Slot = "30")]
		public RESULT getDSPClock(out ulong dspclock, out ulong parentclock)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600020B")]
		[Address(RVA = "0xC1C000", Offset = "0xC1C000", VA = "0xC1C000", Slot = "31")]
		public RESULT setDelay(ulong dspclock_start, ulong dspclock_end, bool stopchannels = true)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600020C")]
		[Address(RVA = "0xC1C0B4", Offset = "0xC1C0B4", VA = "0xC1C0B4", Slot = "32")]
		public RESULT getDelay(out ulong dspclock_start, out ulong dspclock_end)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600020D")]
		[Address(RVA = "0xC1C1B8", Offset = "0xC1C1B8", VA = "0xC1C1B8", Slot = "33")]
		public RESULT getDelay(out ulong dspclock_start, out ulong dspclock_end, out bool stopchannels)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600020E")]
		[Address(RVA = "0xC1C27C", Offset = "0xC1C27C", VA = "0xC1C27C", Slot = "34")]
		public RESULT addFadePoint(ulong dspclock, float volume)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600020F")]
		[Address(RVA = "0xC1C324", Offset = "0xC1C324", VA = "0xC1C324", Slot = "35")]
		public RESULT setFadePointRamp(ulong dspclock, float volume)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000210")]
		[Address(RVA = "0xC1C3CC", Offset = "0xC1C3CC", VA = "0xC1C3CC", Slot = "36")]
		public RESULT removeFadePoints(ulong dspclock_start, ulong dspclock_end)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000211")]
		[Address(RVA = "0xC1C46C", Offset = "0xC1C46C", VA = "0xC1C46C", Slot = "37")]
		public RESULT getFadePoints(ref uint numpoints, ulong[] point_dspclock, float[] point_volume)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000212")]
		[Address(RVA = "0xC1C52C", Offset = "0xC1C52C", VA = "0xC1C52C", Slot = "38")]
		public RESULT getDSP(int index, out DSP dsp)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000213")]
		[Address(RVA = "0xC1C5C8", Offset = "0xC1C5C8", VA = "0xC1C5C8", Slot = "39")]
		public RESULT addDSP(int index, DSP dsp)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000214")]
		[Address(RVA = "0xC1C664", Offset = "0xC1C664", VA = "0xC1C664", Slot = "40")]
		public RESULT removeDSP(DSP dsp)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000215")]
		[Address(RVA = "0xC1C6FC", Offset = "0xC1C6FC", VA = "0xC1C6FC", Slot = "41")]
		public RESULT getNumDSPs(out int numdsps)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000216")]
		[Address(RVA = "0xC1C794", Offset = "0xC1C794", VA = "0xC1C794", Slot = "42")]
		public RESULT setDSPIndex(DSP dsp, int index)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000217")]
		[Address(RVA = "0xC1C834", Offset = "0xC1C834", VA = "0xC1C834", Slot = "43")]
		public RESULT getDSPIndex(DSP dsp, out int index)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000218")]
		[Address(RVA = "0xC1C8D4", Offset = "0xC1C8D4", VA = "0xC1C8D4", Slot = "44")]
		public RESULT set3DAttributes(ref VECTOR pos, ref VECTOR vel)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000219")]
		[Address(RVA = "0xC1C974", Offset = "0xC1C974", VA = "0xC1C974", Slot = "45")]
		public RESULT get3DAttributes(out VECTOR pos, out VECTOR vel)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600021A")]
		[Address(RVA = "0xC1CA14", Offset = "0xC1CA14", VA = "0xC1CA14", Slot = "46")]
		public RESULT set3DMinMaxDistance(float mindistance, float maxdistance)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600021B")]
		[Address(RVA = "0xC1CAB4", Offset = "0xC1CAB4", VA = "0xC1CAB4", Slot = "47")]
		public RESULT get3DMinMaxDistance(out float mindistance, out float maxdistance)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600021C")]
		[Address(RVA = "0xC1CB54", Offset = "0xC1CB54", VA = "0xC1CB54", Slot = "48")]
		public RESULT set3DConeSettings(float insideconeangle, float outsideconeangle, float outsidevolume)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600021D")]
		[Address(RVA = "0xC1CC04", Offset = "0xC1CC04", VA = "0xC1CC04", Slot = "49")]
		public RESULT get3DConeSettings(out float insideconeangle, out float outsideconeangle, out float outsidevolume)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600021E")]
		[Address(RVA = "0xC1CCB4", Offset = "0xC1CCB4", VA = "0xC1CCB4", Slot = "50")]
		public RESULT set3DConeOrientation(ref VECTOR orientation)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600021F")]
		[Address(RVA = "0xC1CD4C", Offset = "0xC1CD4C", VA = "0xC1CD4C", Slot = "51")]
		public RESULT get3DConeOrientation(out VECTOR orientation)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000220")]
		[Address(RVA = "0xC1CDE4", Offset = "0xC1CDE4", VA = "0xC1CDE4", Slot = "52")]
		public RESULT set3DCustomRolloff(ref VECTOR points, int numpoints)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000221")]
		[Address(RVA = "0xC1CE84", Offset = "0xC1CE84", VA = "0xC1CE84", Slot = "53")]
		public RESULT get3DCustomRolloff(out IntPtr points, out int numpoints)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000222")]
		[Address(RVA = "0xC1CF24", Offset = "0xC1CF24", VA = "0xC1CF24", Slot = "54")]
		public RESULT set3DOcclusion(float directocclusion, float reverbocclusion)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000223")]
		[Address(RVA = "0xC1CFC4", Offset = "0xC1CFC4", VA = "0xC1CFC4", Slot = "55")]
		public RESULT get3DOcclusion(out float directocclusion, out float reverbocclusion)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000224")]
		[Address(RVA = "0xC1D064", Offset = "0xC1D064", VA = "0xC1D064", Slot = "56")]
		public RESULT set3DSpread(float angle)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000225")]
		[Address(RVA = "0xC1D0FC", Offset = "0xC1D0FC", VA = "0xC1D0FC", Slot = "57")]
		public RESULT get3DSpread(out float angle)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000226")]
		[Address(RVA = "0xC1D194", Offset = "0xC1D194", VA = "0xC1D194", Slot = "58")]
		public RESULT set3DLevel(float level)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000227")]
		[Address(RVA = "0xC1D22C", Offset = "0xC1D22C", VA = "0xC1D22C", Slot = "59")]
		public RESULT get3DLevel(out float level)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000228")]
		[Address(RVA = "0xC1D2C4", Offset = "0xC1D2C4", VA = "0xC1D2C4", Slot = "60")]
		public RESULT set3DDopplerLevel(float level)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000229")]
		[Address(RVA = "0xC1D35C", Offset = "0xC1D35C", VA = "0xC1D35C", Slot = "61")]
		public RESULT get3DDopplerLevel(out float level)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600022A")]
		[Address(RVA = "0xC1D3F4", Offset = "0xC1D3F4", VA = "0xC1D3F4", Slot = "62")]
		public RESULT set3DDistanceFilter(bool custom, float customLevel, float centerFreq)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600022B")]
		[Address(RVA = "0xC1D4A8", Offset = "0xC1D4A8", VA = "0xC1D4A8", Slot = "63")]
		public RESULT get3DDistanceFilter(out bool custom, out float customLevel, out float centerFreq)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600022C")]
		[Address(RVA = "0xC1D56C", Offset = "0xC1D56C", VA = "0xC1D56C", Slot = "64")]
		public RESULT setUserData(IntPtr userdata)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600022D")]
		[Address(RVA = "0xC1D604", Offset = "0xC1D604", VA = "0xC1D604", Slot = "65")]
		public RESULT getUserData(out IntPtr userdata)
		{
			return default(RESULT);
		}

		[PreserveSig]
		[Token(Token = "0x600022E")]
		[Address(RVA = "0xC1A590", Offset = "0xC1A590", VA = "0xC1A590")]
		private static extern RESULT FMOD5_Channel_SetFrequency(IntPtr channel, float frequency);

		[PreserveSig]
		[Token(Token = "0x600022F")]
		[Address(RVA = "0xC1A628", Offset = "0xC1A628", VA = "0xC1A628")]
		private static extern RESULT FMOD5_Channel_GetFrequency(IntPtr channel, out float frequency);

		[PreserveSig]
		[Token(Token = "0x6000230")]
		[Address(RVA = "0xC1A6C0", Offset = "0xC1A6C0", VA = "0xC1A6C0")]
		private static extern RESULT FMOD5_Channel_SetPriority(IntPtr channel, int priority);

		[PreserveSig]
		[Token(Token = "0x6000231")]
		[Address(RVA = "0xC1A758", Offset = "0xC1A758", VA = "0xC1A758")]
		private static extern RESULT FMOD5_Channel_GetPriority(IntPtr channel, out int priority);

		[PreserveSig]
		[Token(Token = "0x6000232")]
		[Address(RVA = "0xC1A7F0", Offset = "0xC1A7F0", VA = "0xC1A7F0")]
		private static extern RESULT FMOD5_Channel_SetPosition(IntPtr channel, uint position, TIMEUNIT postype);

		[PreserveSig]
		[Token(Token = "0x6000233")]
		[Address(RVA = "0xC1A890", Offset = "0xC1A890", VA = "0xC1A890")]
		private static extern RESULT FMOD5_Channel_GetPosition(IntPtr channel, out uint position, TIMEUNIT postype);

		[PreserveSig]
		[Token(Token = "0x6000234")]
		[Address(RVA = "0xC1A930", Offset = "0xC1A930", VA = "0xC1A930")]
		private static extern RESULT FMOD5_Channel_SetChannelGroup(IntPtr channel, IntPtr channelgroup);

		[PreserveSig]
		[Token(Token = "0x6000235")]
		[Address(RVA = "0xC1A9C8", Offset = "0xC1A9C8", VA = "0xC1A9C8")]
		private static extern RESULT FMOD5_Channel_GetChannelGroup(IntPtr channel, out IntPtr channelgroup);

		[PreserveSig]
		[Token(Token = "0x6000236")]
		[Address(RVA = "0xC1AA60", Offset = "0xC1AA60", VA = "0xC1AA60")]
		private static extern RESULT FMOD5_Channel_SetLoopCount(IntPtr channel, int loopcount);

		[PreserveSig]
		[Token(Token = "0x6000237")]
		[Address(RVA = "0xC1AAF8", Offset = "0xC1AAF8", VA = "0xC1AAF8")]
		private static extern RESULT FMOD5_Channel_GetLoopCount(IntPtr channel, out int loopcount);

		[PreserveSig]
		[Token(Token = "0x6000238")]
		[Address(RVA = "0xC1AB90", Offset = "0xC1AB90", VA = "0xC1AB90")]
		private static extern RESULT FMOD5_Channel_SetLoopPoints(IntPtr channel, uint loopstart, TIMEUNIT loopstarttype, uint loopend, TIMEUNIT loopendtype);

		[PreserveSig]
		[Token(Token = "0x6000239")]
		[Address(RVA = "0xC1AC48", Offset = "0xC1AC48", VA = "0xC1AC48")]
		private static extern RESULT FMOD5_Channel_GetLoopPoints(IntPtr channel, out uint loopstart, TIMEUNIT loopstarttype, out uint loopend, TIMEUNIT loopendtype);

		[PreserveSig]
		[Token(Token = "0x600023A")]
		[Address(RVA = "0xC1AD00", Offset = "0xC1AD00", VA = "0xC1AD00")]
		private static extern RESULT FMOD5_Channel_IsVirtual(IntPtr channel, out bool isvirtual);

		[PreserveSig]
		[Token(Token = "0x600023B")]
		[Address(RVA = "0xC1ADAC", Offset = "0xC1ADAC", VA = "0xC1ADAC")]
		private static extern RESULT FMOD5_Channel_GetCurrentSound(IntPtr channel, out IntPtr sound);

		[PreserveSig]
		[Token(Token = "0x600023C")]
		[Address(RVA = "0xC1AE44", Offset = "0xC1AE44", VA = "0xC1AE44")]
		private static extern RESULT FMOD5_Channel_GetIndex(IntPtr channel, out int index);

		[PreserveSig]
		[Token(Token = "0x600023D")]
		[Address(RVA = "0xC1AEDC", Offset = "0xC1AEDC", VA = "0xC1AEDC")]
		private static extern RESULT FMOD5_Channel_GetSystemObject(IntPtr channel, out IntPtr system);

		[PreserveSig]
		[Token(Token = "0x600023E")]
		[Address(RVA = "0xC1AF74", Offset = "0xC1AF74", VA = "0xC1AF74")]
		private static extern RESULT FMOD5_Channel_Stop(IntPtr channel);

		[PreserveSig]
		[Token(Token = "0x600023F")]
		[Address(RVA = "0xC1B000", Offset = "0xC1B000", VA = "0xC1B000")]
		private static extern RESULT FMOD5_Channel_SetPaused(IntPtr channel, bool paused);

		[PreserveSig]
		[Token(Token = "0x6000240")]
		[Address(RVA = "0xC1B098", Offset = "0xC1B098", VA = "0xC1B098")]
		private static extern RESULT FMOD5_Channel_GetPaused(IntPtr channel, out bool paused);

		[PreserveSig]
		[Token(Token = "0x6000241")]
		[Address(RVA = "0xC1B144", Offset = "0xC1B144", VA = "0xC1B144")]
		private static extern RESULT FMOD5_Channel_SetVolume(IntPtr channel, float volume);

		[PreserveSig]
		[Token(Token = "0x6000242")]
		[Address(RVA = "0xC1B1DC", Offset = "0xC1B1DC", VA = "0xC1B1DC")]
		private static extern RESULT FMOD5_Channel_GetVolume(IntPtr channel, out float volume);

		[PreserveSig]
		[Token(Token = "0x6000243")]
		[Address(RVA = "0xC1B278", Offset = "0xC1B278", VA = "0xC1B278")]
		private static extern RESULT FMOD5_Channel_SetVolumeRamp(IntPtr channel, bool ramp);

		[PreserveSig]
		[Token(Token = "0x6000244")]
		[Address(RVA = "0xC1B310", Offset = "0xC1B310", VA = "0xC1B310")]
		private static extern RESULT FMOD5_Channel_GetVolumeRamp(IntPtr channel, out bool ramp);

		[PreserveSig]
		[Token(Token = "0x6000245")]
		[Address(RVA = "0xC1B3BC", Offset = "0xC1B3BC", VA = "0xC1B3BC")]
		private static extern RESULT FMOD5_Channel_GetAudibility(IntPtr channel, out float audibility);

		[PreserveSig]
		[Token(Token = "0x6000246")]
		[Address(RVA = "0xC1B454", Offset = "0xC1B454", VA = "0xC1B454")]
		private static extern RESULT FMOD5_Channel_SetPitch(IntPtr channel, float pitch);

		[PreserveSig]
		[Token(Token = "0x6000247")]
		[Address(RVA = "0xC1B4EC", Offset = "0xC1B4EC", VA = "0xC1B4EC")]
		private static extern RESULT FMOD5_Channel_GetPitch(IntPtr channel, out float pitch);

		[PreserveSig]
		[Token(Token = "0x6000248")]
		[Address(RVA = "0xC1B588", Offset = "0xC1B588", VA = "0xC1B588")]
		private static extern RESULT FMOD5_Channel_SetMute(IntPtr channel, bool mute);

		[PreserveSig]
		[Token(Token = "0x6000249")]
		[Address(RVA = "0xC1B620", Offset = "0xC1B620", VA = "0xC1B620")]
		private static extern RESULT FMOD5_Channel_GetMute(IntPtr channel, out bool mute);

		[PreserveSig]
		[Token(Token = "0x600024A")]
		[Address(RVA = "0xC1B6CC", Offset = "0xC1B6CC", VA = "0xC1B6CC")]
		private static extern RESULT FMOD5_Channel_SetReverbProperties(IntPtr channel, int instance, float wet);

		[PreserveSig]
		[Token(Token = "0x600024B")]
		[Address(RVA = "0xC1B774", Offset = "0xC1B774", VA = "0xC1B774")]
		private static extern RESULT FMOD5_Channel_GetReverbProperties(IntPtr channel, int instance, out float wet);

		[PreserveSig]
		[Token(Token = "0x600024C")]
		[Address(RVA = "0xC1B814", Offset = "0xC1B814", VA = "0xC1B814")]
		private static extern RESULT FMOD5_Channel_SetLowPassGain(IntPtr channel, float gain);

		[PreserveSig]
		[Token(Token = "0x600024D")]
		[Address(RVA = "0xC1B8AC", Offset = "0xC1B8AC", VA = "0xC1B8AC")]
		private static extern RESULT FMOD5_Channel_GetLowPassGain(IntPtr channel, out float gain);

		[PreserveSig]
		[Token(Token = "0x600024E")]
		[Address(RVA = "0xC1B944", Offset = "0xC1B944", VA = "0xC1B944")]
		private static extern RESULT FMOD5_Channel_SetMode(IntPtr channel, MODE mode);

		[PreserveSig]
		[Token(Token = "0x600024F")]
		[Address(RVA = "0xC1B9DC", Offset = "0xC1B9DC", VA = "0xC1B9DC")]
		private static extern RESULT FMOD5_Channel_GetMode(IntPtr channel, out MODE mode);

		[PreserveSig]
		[Token(Token = "0x6000250")]
		[Address(RVA = "0xC1BA74", Offset = "0xC1BA74", VA = "0xC1BA74")]
		private static extern RESULT FMOD5_Channel_SetCallback(IntPtr channel, CHANNELCONTROL_CALLBACK callback);

		[PreserveSig]
		[Token(Token = "0x6000251")]
		[Address(RVA = "0xC1BB14", Offset = "0xC1BB14", VA = "0xC1BB14")]
		private static extern RESULT FMOD5_Channel_IsPlaying(IntPtr channel, out bool isplaying);

		[PreserveSig]
		[Token(Token = "0x6000252")]
		[Address(RVA = "0xC1BBC0", Offset = "0xC1BBC0", VA = "0xC1BBC0")]
		private static extern RESULT FMOD5_Channel_SetPan(IntPtr channel, float pan);

		[PreserveSig]
		[Token(Token = "0x6000253")]
		[Address(RVA = "0xC1BC58", Offset = "0xC1BC58", VA = "0xC1BC58")]
		private static extern RESULT FMOD5_Channel_SetMixLevelsOutput(IntPtr channel, float frontleft, float frontright, float center, float lfe, float surroundleft, float surroundright, float backleft, float backright);

		[PreserveSig]
		[Token(Token = "0x6000254")]
		[Address(RVA = "0xC1BD40", Offset = "0xC1BD40", VA = "0xC1BD40")]
		private static extern RESULT FMOD5_Channel_SetMixLevelsInput(IntPtr channel, float[] levels, int numlevels);

		[PreserveSig]
		[Token(Token = "0x6000255")]
		[Address(RVA = "0xC1BDE8", Offset = "0xC1BDE8", VA = "0xC1BDE8")]
		private static extern RESULT FMOD5_Channel_SetMixMatrix(IntPtr channel, float[] matrix, int outchannels, int inchannels, int inchannel_hop);

		[PreserveSig]
		[Token(Token = "0x6000256")]
		[Address(RVA = "0xC1BEA8", Offset = "0xC1BEA8", VA = "0xC1BEA8")]
		private static extern RESULT FMOD5_Channel_GetMixMatrix(IntPtr channel, float[] matrix, out int outchannels, out int inchannels, int inchannel_hop);

		[PreserveSig]
		[Token(Token = "0x6000257")]
		[Address(RVA = "0xC1BF68", Offset = "0xC1BF68", VA = "0xC1BF68")]
		private static extern RESULT FMOD5_Channel_GetDSPClock(IntPtr channel, out ulong dspclock, out ulong parentclock);

		[PreserveSig]
		[Token(Token = "0x6000258")]
		[Address(RVA = "0xC1C00C", Offset = "0xC1C00C", VA = "0xC1C00C")]
		private static extern RESULT FMOD5_Channel_SetDelay(IntPtr channel, ulong dspclock_start, ulong dspclock_end, bool stopchannels);

		[PreserveSig]
		[Token(Token = "0x6000259")]
		[Address(RVA = "0xC1C110", Offset = "0xC1C110", VA = "0xC1C110")]
		private static extern RESULT FMOD5_Channel_GetDelay(IntPtr channel, out ulong dspclock_start, out ulong dspclock_end, IntPtr zero);

		[PreserveSig]
		[Token(Token = "0x600025A")]
		[Address(RVA = "0xC1C1C0", Offset = "0xC1C1C0", VA = "0xC1C1C0")]
		private static extern RESULT FMOD5_Channel_GetDelay(IntPtr channel, out ulong dspclock_start, out ulong dspclock_end, out bool stopchannels);

		[PreserveSig]
		[Token(Token = "0x600025B")]
		[Address(RVA = "0xC1C284", Offset = "0xC1C284", VA = "0xC1C284")]
		private static extern RESULT FMOD5_Channel_AddFadePoint(IntPtr channel, ulong dspclock, float volume);

		[PreserveSig]
		[Token(Token = "0x600025C")]
		[Address(RVA = "0xC1C32C", Offset = "0xC1C32C", VA = "0xC1C32C")]
		private static extern RESULT FMOD5_Channel_SetFadePointRamp(IntPtr channel, ulong dspclock, float volume);

		[PreserveSig]
		[Token(Token = "0x600025D")]
		[Address(RVA = "0xC1C3D4", Offset = "0xC1C3D4", VA = "0xC1C3D4")]
		private static extern RESULT FMOD5_Channel_RemoveFadePoints(IntPtr channel, ulong dspclock_start, ulong dspclock_end);

		[PreserveSig]
		[Token(Token = "0x600025E")]
		[Address(RVA = "0xC1C474", Offset = "0xC1C474", VA = "0xC1C474")]
		private static extern RESULT FMOD5_Channel_GetFadePoints(IntPtr channel, ref uint numpoints, ulong[] point_dspclock, float[] point_volume);

		[PreserveSig]
		[Token(Token = "0x600025F")]
		[Address(RVA = "0xC1C534", Offset = "0xC1C534", VA = "0xC1C534")]
		private static extern RESULT FMOD5_Channel_GetDSP(IntPtr channel, int index, out IntPtr dsp);

		[PreserveSig]
		[Token(Token = "0x6000260")]
		[Address(RVA = "0xC1C5D0", Offset = "0xC1C5D0", VA = "0xC1C5D0")]
		private static extern RESULT FMOD5_Channel_AddDSP(IntPtr channel, int index, IntPtr dsp);

		[PreserveSig]
		[Token(Token = "0x6000261")]
		[Address(RVA = "0xC1C66C", Offset = "0xC1C66C", VA = "0xC1C66C")]
		private static extern RESULT FMOD5_Channel_RemoveDSP(IntPtr channel, IntPtr dsp);

		[PreserveSig]
		[Token(Token = "0x6000262")]
		[Address(RVA = "0xC1C704", Offset = "0xC1C704", VA = "0xC1C704")]
		private static extern RESULT FMOD5_Channel_GetNumDSPs(IntPtr channel, out int numdsps);

		[PreserveSig]
		[Token(Token = "0x6000263")]
		[Address(RVA = "0xC1C79C", Offset = "0xC1C79C", VA = "0xC1C79C")]
		private static extern RESULT FMOD5_Channel_SetDSPIndex(IntPtr channel, IntPtr dsp, int index);

		[PreserveSig]
		[Token(Token = "0x6000264")]
		[Address(RVA = "0xC1C83C", Offset = "0xC1C83C", VA = "0xC1C83C")]
		private static extern RESULT FMOD5_Channel_GetDSPIndex(IntPtr channel, IntPtr dsp, out int index);

		[PreserveSig]
		[Token(Token = "0x6000265")]
		[Address(RVA = "0xC1C8DC", Offset = "0xC1C8DC", VA = "0xC1C8DC")]
		private static extern RESULT FMOD5_Channel_Set3DAttributes(IntPtr channel, ref VECTOR pos, ref VECTOR vel);

		[PreserveSig]
		[Token(Token = "0x6000266")]
		[Address(RVA = "0xC1C97C", Offset = "0xC1C97C", VA = "0xC1C97C")]
		private static extern RESULT FMOD5_Channel_Get3DAttributes(IntPtr channel, out VECTOR pos, out VECTOR vel);

		[PreserveSig]
		[Token(Token = "0x6000267")]
		[Address(RVA = "0xC1CA1C", Offset = "0xC1CA1C", VA = "0xC1CA1C")]
		private static extern RESULT FMOD5_Channel_Set3DMinMaxDistance(IntPtr channel, float mindistance, float maxdistance);

		[PreserveSig]
		[Token(Token = "0x6000268")]
		[Address(RVA = "0xC1CABC", Offset = "0xC1CABC", VA = "0xC1CABC")]
		private static extern RESULT FMOD5_Channel_Get3DMinMaxDistance(IntPtr channel, out float mindistance, out float maxdistance);

		[PreserveSig]
		[Token(Token = "0x6000269")]
		[Address(RVA = "0xC1CB5C", Offset = "0xC1CB5C", VA = "0xC1CB5C")]
		private static extern RESULT FMOD5_Channel_Set3DConeSettings(IntPtr channel, float insideconeangle, float outsideconeangle, float outsidevolume);

		[PreserveSig]
		[Token(Token = "0x600026A")]
		[Address(RVA = "0xC1CC0C", Offset = "0xC1CC0C", VA = "0xC1CC0C")]
		private static extern RESULT FMOD5_Channel_Get3DConeSettings(IntPtr channel, out float insideconeangle, out float outsideconeangle, out float outsidevolume);

		[PreserveSig]
		[Token(Token = "0x600026B")]
		[Address(RVA = "0xC1CCBC", Offset = "0xC1CCBC", VA = "0xC1CCBC")]
		private static extern RESULT FMOD5_Channel_Set3DConeOrientation(IntPtr channel, ref VECTOR orientation);

		[PreserveSig]
		[Token(Token = "0x600026C")]
		[Address(RVA = "0xC1CD54", Offset = "0xC1CD54", VA = "0xC1CD54")]
		private static extern RESULT FMOD5_Channel_Get3DConeOrientation(IntPtr channel, out VECTOR orientation);

		[PreserveSig]
		[Token(Token = "0x600026D")]
		[Address(RVA = "0xC1CDEC", Offset = "0xC1CDEC", VA = "0xC1CDEC")]
		private static extern RESULT FMOD5_Channel_Set3DCustomRolloff(IntPtr channel, ref VECTOR points, int numpoints);

		[PreserveSig]
		[Token(Token = "0x600026E")]
		[Address(RVA = "0xC1CE8C", Offset = "0xC1CE8C", VA = "0xC1CE8C")]
		private static extern RESULT FMOD5_Channel_Get3DCustomRolloff(IntPtr channel, out IntPtr points, out int numpoints);

		[PreserveSig]
		[Token(Token = "0x600026F")]
		[Address(RVA = "0xC1CF2C", Offset = "0xC1CF2C", VA = "0xC1CF2C")]
		private static extern RESULT FMOD5_Channel_Set3DOcclusion(IntPtr channel, float directocclusion, float reverbocclusion);

		[PreserveSig]
		[Token(Token = "0x6000270")]
		[Address(RVA = "0xC1CFCC", Offset = "0xC1CFCC", VA = "0xC1CFCC")]
		private static extern RESULT FMOD5_Channel_Get3DOcclusion(IntPtr channel, out float directocclusion, out float reverbocclusion);

		[PreserveSig]
		[Token(Token = "0x6000271")]
		[Address(RVA = "0xC1D06C", Offset = "0xC1D06C", VA = "0xC1D06C")]
		private static extern RESULT FMOD5_Channel_Set3DSpread(IntPtr channel, float angle);

		[PreserveSig]
		[Token(Token = "0x6000272")]
		[Address(RVA = "0xC1D104", Offset = "0xC1D104", VA = "0xC1D104")]
		private static extern RESULT FMOD5_Channel_Get3DSpread(IntPtr channel, out float angle);

		[PreserveSig]
		[Token(Token = "0x6000273")]
		[Address(RVA = "0xC1D19C", Offset = "0xC1D19C", VA = "0xC1D19C")]
		private static extern RESULT FMOD5_Channel_Set3DLevel(IntPtr channel, float level);

		[PreserveSig]
		[Token(Token = "0x6000274")]
		[Address(RVA = "0xC1D234", Offset = "0xC1D234", VA = "0xC1D234")]
		private static extern RESULT FMOD5_Channel_Get3DLevel(IntPtr channel, out float level);

		[PreserveSig]
		[Token(Token = "0x6000275")]
		[Address(RVA = "0xC1D2CC", Offset = "0xC1D2CC", VA = "0xC1D2CC")]
		private static extern RESULT FMOD5_Channel_Set3DDopplerLevel(IntPtr channel, float level);

		[PreserveSig]
		[Token(Token = "0x6000276")]
		[Address(RVA = "0xC1D364", Offset = "0xC1D364", VA = "0xC1D364")]
		private static extern RESULT FMOD5_Channel_Get3DDopplerLevel(IntPtr channel, out float level);

		[PreserveSig]
		[Token(Token = "0x6000277")]
		[Address(RVA = "0xC1D400", Offset = "0xC1D400", VA = "0xC1D400")]
		private static extern RESULT FMOD5_Channel_Set3DDistanceFilter(IntPtr channel, bool custom, float customLevel, float centerFreq);

		[PreserveSig]
		[Token(Token = "0x6000278")]
		[Address(RVA = "0xC1D4B0", Offset = "0xC1D4B0", VA = "0xC1D4B0")]
		private static extern RESULT FMOD5_Channel_Get3DDistanceFilter(IntPtr channel, out bool custom, out float customLevel, out float centerFreq);

		[PreserveSig]
		[Token(Token = "0x6000279")]
		[Address(RVA = "0xC1D574", Offset = "0xC1D574", VA = "0xC1D574")]
		private static extern RESULT FMOD5_Channel_SetUserData(IntPtr channel, IntPtr userdata);

		[PreserveSig]
		[Token(Token = "0x600027A")]
		[Address(RVA = "0xC1D60C", Offset = "0xC1D60C", VA = "0xC1D60C")]
		private static extern RESULT FMOD5_Channel_GetUserData(IntPtr channel, out IntPtr userdata);

		[Token(Token = "0x600027B")]
		[Address(RVA = "0xC1D69C", Offset = "0xC1D69C", VA = "0xC1D69C")]
		public bool hasHandle()
		{
			return default(bool);
		}

		[Token(Token = "0x600027C")]
		[Address(RVA = "0xC1D6E4", Offset = "0xC1D6E4", VA = "0xC1D6E4")]
		public void clearHandle()
		{
		}
	}
	[Token(Token = "0x200004B")]
	public struct ChannelGroup : IChannelControl
	{
		[Token(Token = "0x4000241")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public IntPtr handle;

		[Token(Token = "0x600027D")]
		[Address(RVA = "0xC1D724", Offset = "0xC1D724", VA = "0xC1D724")]
		public RESULT release()
		{
			return default(RESULT);
		}

		[Token(Token = "0x600027E")]
		[Address(RVA = "0xC1D7AC", Offset = "0xC1D7AC", VA = "0xC1D7AC")]
		public RESULT addGroup(ChannelGroup group, bool propagatedspclock = true)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600027F")]
		[Address(RVA = "0xC1D8B0", Offset = "0xC1D8B0", VA = "0xC1D8B0")]
		public RESULT addGroup(ChannelGroup group, bool propagatedspclock, out DSPConnection connection)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000280")]
		[Address(RVA = "0xC1D964", Offset = "0xC1D964", VA = "0xC1D964")]
		public RESULT getNumGroups(out int numgroups)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000281")]
		[Address(RVA = "0xC1D9FC", Offset = "0xC1D9FC", VA = "0xC1D9FC")]
		public RESULT getGroup(int index, out ChannelGroup group)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000282")]
		[Address(RVA = "0xC1DA9C", Offset = "0xC1DA9C", VA = "0xC1DA9C")]
		public RESULT getParentGroup(out ChannelGroup group)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000283")]
		[Address(RVA = "0xC1DB34", Offset = "0xC1DB34", VA = "0xC1DB34")]
		public RESULT getName(out string name, int namelen)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000284")]
		[Address(RVA = "0xC1DDD0", Offset = "0xC1DDD0", VA = "0xC1DDD0")]
		public RESULT getNumChannels(out int numchannels)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000285")]
		[Address(RVA = "0xC1DE68", Offset = "0xC1DE68", VA = "0xC1DE68")]
		public RESULT getChannel(int index, out Channel channel)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000286")]
		[Address(RVA = "0xC1DF08", Offset = "0xC1DF08", VA = "0xC1DF08", Slot = "4")]
		public RESULT getSystemObject(out System system)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000287")]
		[Address(RVA = "0xC1DFA0", Offset = "0xC1DFA0", VA = "0xC1DFA0", Slot = "5")]
		public RESULT stop()
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000288")]
		[Address(RVA = "0xC1E028", Offset = "0xC1E028", VA = "0xC1E028", Slot = "6")]
		public RESULT setPaused(bool paused)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000289")]
		[Address(RVA = "0xC1E0C4", Offset = "0xC1E0C4", VA = "0xC1E0C4", Slot = "7")]
		public RESULT getPaused(out bool paused)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600028A")]
		[Address(RVA = "0xC1E170", Offset = "0xC1E170", VA = "0xC1E170", Slot = "8")]
		public RESULT setVolume(float volume)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600028B")]
		[Address(RVA = "0xC1E208", Offset = "0xC1E208", VA = "0xC1E208", Slot = "9")]
		public RESULT getVolume(out float volume)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600028C")]
		[Address(RVA = "0xC1E2A0", Offset = "0xC1E2A0", VA = "0xC1E2A0", Slot = "10")]
		public RESULT setVolumeRamp(bool ramp)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600028D")]
		[Address(RVA = "0xC1E33C", Offset = "0xC1E33C", VA = "0xC1E33C", Slot = "11")]
		public RESULT getVolumeRamp(out bool ramp)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600028E")]
		[Address(RVA = "0xC1E3E8", Offset = "0xC1E3E8", VA = "0xC1E3E8", Slot = "12")]
		public RESULT getAudibility(out float audibility)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600028F")]
		[Address(RVA = "0xC1E480", Offset = "0xC1E480", VA = "0xC1E480", Slot = "13")]
		public RESULT setPitch(float pitch)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000290")]
		[Address(RVA = "0xC1E518", Offset = "0xC1E518", VA = "0xC1E518", Slot = "14")]
		public RESULT getPitch(out float pitch)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000291")]
		[Address(RVA = "0xC1E5B0", Offset = "0xC1E5B0", VA = "0xC1E5B0", Slot = "15")]
		public RESULT setMute(bool mute)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000292")]
		[Address(RVA = "0xC1E64C", Offset = "0xC1E64C", VA = "0xC1E64C", Slot = "16")]
		public RESULT getMute(out bool mute)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000293")]
		[Address(RVA = "0xC1E6F8", Offset = "0xC1E6F8", VA = "0xC1E6F8", Slot = "17")]
		public RESULT setReverbProperties(int instance, float wet)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000294")]
		[Address(RVA = "0xC1E7A0", Offset = "0xC1E7A0", VA = "0xC1E7A0", Slot = "18")]
		public RESULT getReverbProperties(int instance, out float wet)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000295")]
		[Address(RVA = "0xC1E840", Offset = "0xC1E840", VA = "0xC1E840", Slot = "19")]
		public RESULT setLowPassGain(float gain)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000296")]
		[Address(RVA = "0xC1E8D8", Offset = "0xC1E8D8", VA = "0xC1E8D8", Slot = "20")]
		public RESULT getLowPassGain(out float gain)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000297")]
		[Address(RVA = "0xC1E970", Offset = "0xC1E970", VA = "0xC1E970", Slot = "21")]
		public RESULT setMode(MODE mode)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000298")]
		[Address(RVA = "0xC1EA08", Offset = "0xC1EA08", VA = "0xC1EA08", Slot = "22")]
		public RESULT getMode(out MODE mode)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000299")]
		[Address(RVA = "0xC1EAA0", Offset = "0xC1EAA0", VA = "0xC1EAA0", Slot = "23")]
		public RESULT setCallback(CHANNELCONTROL_CALLBACK callback)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600029A")]
		[Address(RVA = "0xC1EB40", Offset = "0xC1EB40", VA = "0xC1EB40", Slot = "24")]
		public RESULT isPlaying(out bool isplaying)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600029B")]
		[Address(RVA = "0xC1EBEC", Offset = "0xC1EBEC", VA = "0xC1EBEC", Slot = "25")]
		public RESULT setPan(float pan)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600029C")]
		[Address(RVA = "0xC1EC84", Offset = "0xC1EC84", VA = "0xC1EC84", Slot = "26")]
		public RESULT setMixLevelsOutput(float frontleft, float frontright, float center, float lfe, float surroundleft, float surroundright, float backleft, float backright)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600029D")]
		[Address(RVA = "0xC1ED6C", Offset = "0xC1ED6C", VA = "0xC1ED6C", Slot = "27")]
		public RESULT setMixLevelsInput(float[] levels, int numlevels)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600029E")]
		[Address(RVA = "0xC1EE14", Offset = "0xC1EE14", VA = "0xC1EE14", Slot = "28")]
		public RESULT setMixMatrix(float[] matrix, int outchannels, int inchannels, int inchannel_hop)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600029F")]
		[Address(RVA = "0xC1EED4", Offset = "0xC1EED4", VA = "0xC1EED4", Slot = "29")]
		public RESULT getMixMatrix(float[] matrix, out int outchannels, out int inchannels, int inchannel_hop)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60002A0")]
		[Address(RVA = "0xC1EF94", Offset = "0xC1EF94", VA = "0xC1EF94", Slot = "30")]
		public RESULT getDSPClock(out ulong dspclock, out ulong parentclock)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60002A1")]
		[Address(RVA = "0xC1F034", Offset = "0xC1F034", VA = "0xC1F034", Slot = "31")]
		public RESULT setDelay(ulong dspclock_start, ulong dspclock_end, bool stopchannels)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60002A2")]
		[Address(RVA = "0xC1F0E8", Offset = "0xC1F0E8", VA = "0xC1F0E8", Slot = "32")]
		public RESULT getDelay(out ulong dspclock_start, out ulong dspclock_end)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60002A3")]
		[Address(RVA = "0xC1F1EC", Offset = "0xC1F1EC", VA = "0xC1F1EC", Slot = "33")]
		public RESULT getDelay(out ulong dspclock_start, out ulong dspclock_end, out bool stopchannels)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60002A4")]
		[Address(RVA = "0xC1F2B0", Offset = "0xC1F2B0", VA = "0xC1F2B0", Slot = "34")]
		public RESULT addFadePoint(ulong dspclock, float volume)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60002A5")]
		[Address(RVA = "0xC1F358", Offset = "0xC1F358", VA = "0xC1F358", Slot = "35")]
		public RESULT setFadePointRamp(ulong dspclock, float volume)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60002A6")]
		[Address(RVA = "0xC1F400", Offset = "0xC1F400", VA = "0xC1F400", Slot = "36")]
		public RESULT removeFadePoints(ulong dspclock_start, ulong dspclock_end)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60002A7")]
		[Address(RVA = "0xC1F4A0", Offset = "0xC1F4A0", VA = "0xC1F4A0", Slot = "37")]
		public RESULT getFadePoints(ref uint numpoints, ulong[] point_dspclock, float[] point_volume)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60002A8")]
		[Address(RVA = "0xC1F55C", Offset = "0xC1F55C", VA = "0xC1F55C", Slot = "38")]
		public RESULT getDSP(int index, out DSP dsp)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60002A9")]
		[Address(RVA = "0xC1F5FC", Offset = "0xC1F5FC", VA = "0xC1F5FC", Slot = "39")]
		public RESULT addDSP(int index, DSP dsp)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60002AA")]
		[Address(RVA = "0xC1F69C", Offset = "0xC1F69C", VA = "0xC1F69C", Slot = "40")]
		public RESULT removeDSP(DSP dsp)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60002AB")]
		[Address(RVA = "0xC1F734", Offset = "0xC1F734", VA = "0xC1F734", Slot = "41")]
		public RESULT getNumDSPs(out int numdsps)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60002AC")]
		[Address(RVA = "0xC1F7CC", Offset = "0xC1F7CC", VA = "0xC1F7CC", Slot = "42")]
		public RESULT setDSPIndex(DSP dsp, int index)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60002AD")]
		[Address(RVA = "0xC1F86C", Offset = "0xC1F86C", VA = "0xC1F86C", Slot = "43")]
		public RESULT getDSPIndex(DSP dsp, out int index)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60002AE")]
		[Address(RVA = "0xC1F90C", Offset = "0xC1F90C", VA = "0xC1F90C", Slot = "44")]
		public RESULT set3DAttributes(ref VECTOR pos, ref VECTOR vel)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60002AF")]
		[Address(RVA = "0xC1F9AC", Offset = "0xC1F9AC", VA = "0xC1F9AC", Slot = "45")]
		public RESULT get3DAttributes(out VECTOR pos, out VECTOR vel)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60002B0")]
		[Address(RVA = "0xC1FA4C", Offset = "0xC1FA4C", VA = "0xC1FA4C", Slot = "46")]
		public RESULT set3DMinMaxDistance(float mindistance, float maxdistance)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60002B1")]
		[Address(RVA = "0xC1FAEC", Offset = "0xC1FAEC", VA = "0xC1FAEC", Slot = "47")]
		public RESULT get3DMinMaxDistance(out float mindistance, out float maxdistance)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60002B2")]
		[Address(RVA = "0xC1FB8C", Offset = "0xC1FB8C", VA = "0xC1FB8C", Slot = "48")]
		public RESULT set3DConeSettings(float insideconeangle, float outsideconeangle, float outsidevolume)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60002B3")]
		[Address(RVA = "0xC1FC3C", Offset = "0xC1FC3C", VA = "0xC1FC3C", Slot = "49")]
		public RESULT get3DConeSettings(out float insideconeangle, out float outsideconeangle, out float outsidevolume)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60002B4")]
		[Address(RVA = "0xC1FCEC", Offset = "0xC1FCEC", VA = "0xC1FCEC", Slot = "50")]
		public RESULT set3DConeOrientation(ref VECTOR orientation)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60002B5")]
		[Address(RVA = "0xC1FD84", Offset = "0xC1FD84", VA = "0xC1FD84", Slot = "51")]
		public RESULT get3DConeOrientation(out VECTOR orientation)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60002B6")]
		[Address(RVA = "0xC1FE1C", Offset = "0xC1FE1C", VA = "0xC1FE1C", Slot = "52")]
		public RESULT set3DCustomRolloff(ref VECTOR points, int numpoints)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60002B7")]
		[Address(RVA = "0xC1FEBC", Offset = "0xC1FEBC", VA = "0xC1FEBC", Slot = "53")]
		public RESULT get3DCustomRolloff(out IntPtr points, out int numpoints)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60002B8")]
		[Address(RVA = "0xC1FF5C", Offset = "0xC1FF5C", VA = "0xC1FF5C", Slot = "54")]
		public RESULT set3DOcclusion(float directocclusion, float reverbocclusion)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60002B9")]
		[Address(RVA = "0xC1FFFC", Offset = "0xC1FFFC", VA = "0xC1FFFC", Slot = "55")]
		public RESULT get3DOcclusion(out float directocclusion, out float reverbocclusion)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60002BA")]
		[Address(RVA = "0xC2009C", Offset = "0xC2009C", VA = "0xC2009C", Slot = "56")]
		public RESULT set3DSpread(float angle)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60002BB")]
		[Address(RVA = "0xC20134", Offset = "0xC20134", VA = "0xC20134", Slot = "57")]
		public RESULT get3DSpread(out float angle)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60002BC")]
		[Address(RVA = "0xC201CC", Offset = "0xC201CC", VA = "0xC201CC", Slot = "58")]
		public RESULT set3DLevel(float level)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60002BD")]
		[Address(RVA = "0xC20264", Offset = "0xC20264", VA = "0xC20264", Slot = "59")]
		public RESULT get3DLevel(out float level)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60002BE")]
		[Address(RVA = "0xC202FC", Offset = "0xC202FC", VA = "0xC202FC", Slot = "60")]
		public RESULT set3DDopplerLevel(float level)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60002BF")]
		[Address(RVA = "0xC20394", Offset = "0xC20394", VA = "0xC20394", Slot = "61")]
		public RESULT get3DDopplerLevel(out float level)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60002C0")]
		[Address(RVA = "0xC2042C", Offset = "0xC2042C", VA = "0xC2042C", Slot = "62")]
		public RESULT set3DDistanceFilter(bool custom, float customLevel, float centerFreq)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60002C1")]
		[Address(RVA = "0xC204E0", Offset = "0xC204E0", VA = "0xC204E0", Slot = "63")]
		public RESULT get3DDistanceFilter(out bool custom, out float customLevel, out float centerFreq)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60002C2")]
		[Address(RVA = "0xC205A4", Offset = "0xC205A4", VA = "0xC205A4", Slot = "64")]
		public RESULT setUserData(IntPtr userdata)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60002C3")]
		[Address(RVA = "0xC2063C", Offset = "0xC2063C", VA = "0xC2063C", Slot = "65")]
		public RESULT getUserData(out IntPtr userdata)
		{
			return default(RESULT);
		}

		[PreserveSig]
		[Token(Token = "0x60002C4")]
		[Address(RVA = "0xC1D72C", Offset = "0xC1D72C", VA = "0xC1D72C")]
		private static extern RESULT FMOD5_ChannelGroup_Release(IntPtr channelgroup);

		[PreserveSig]
		[Token(Token = "0x60002C5")]
		[Address(RVA = "0xC1D808", Offset = "0xC1D808", VA = "0xC1D808")]
		private static extern RESULT FMOD5_ChannelGroup_AddGroup(IntPtr channelgroup, IntPtr group, bool propagatedspclock, IntPtr zero);

		[PreserveSig]
		[Token(Token = "0x60002C6")]
		[Address(RVA = "0xC1D8BC", Offset = "0xC1D8BC", VA = "0xC1D8BC")]
		private static extern RESULT FMOD5_ChannelGroup_AddGroup(IntPtr channelgroup, IntPtr group, bool propagatedspclock, out IntPtr connection);

		[PreserveSig]
		[Token(Token = "0x60002C7")]
		[Address(RVA = "0xC1D96C", Offset = "0xC1D96C", VA = "0xC1D96C")]
		private static extern RESULT FMOD5_ChannelGroup_GetNumGroups(IntPtr channelgroup, out int numgroups);

		[PreserveSig]
		[Token(Token = "0x60002C8")]
		[Address(RVA = "0xC1DA04", Offset = "0xC1DA04", VA = "0xC1DA04")]
		private static extern RESULT FMOD5_ChannelGroup_GetGroup(IntPtr channelgroup, int index, out IntPtr group);

		[PreserveSig]
		[Token(Token = "0x60002C9")]
		[Address(RVA = "0xC1DAA4", Offset = "0xC1DAA4", VA = "0xC1DAA4")]
		private static extern RESULT FMOD5_ChannelGroup_GetParentGroup(IntPtr channelgroup, out IntPtr group);

		[PreserveSig]
		[Token(Token = "0x60002CA")]
		[Address(RVA = "0xC1DD38", Offset = "0xC1DD38", VA = "0xC1DD38")]
		private static extern RESULT FMOD5_ChannelGroup_GetName(IntPtr channelgroup, IntPtr name, int namelen);

		[PreserveSig]
		[Token(Token = "0x60002CB")]
		[Address(RVA = "0xC1DDD8", Offset = "0xC1DDD8", VA = "0xC1DDD8")]
		private static extern RESULT FMOD5_ChannelGroup_GetNumChannels(IntPtr channelgroup, out int numchannels);

		[PreserveSig]
		[Token(Token = "0x60002CC")]
		[Address(RVA = "0xC1DE70", Offset = "0xC1DE70", VA = "0xC1DE70")]
		private static extern RESULT FMOD5_ChannelGroup_GetChannel(IntPtr channelgroup, int index, out IntPtr channel);

		[PreserveSig]
		[Token(Token = "0x60002CD")]
		[Address(RVA = "0xC1DF10", Offset = "0xC1DF10", VA = "0xC1DF10")]
		private static extern RESULT FMOD5_ChannelGroup_GetSystemObject(IntPtr channelgroup, out IntPtr system);

		[PreserveSig]
		[Token(Token = "0x60002CE")]
		[Address(RVA = "0xC1DFA8", Offset = "0xC1DFA8", VA = "0xC1DFA8")]
		private static extern RESULT FMOD5_ChannelGroup_Stop(IntPtr channelgroup);

		[PreserveSig]
		[Token(Token = "0x60002CF")]
		[Address(RVA = "0xC1E034", Offset = "0xC1E034", VA = "0xC1E034")]
		private static extern RESULT FMOD5_ChannelGroup_SetPaused(IntPtr channelgroup, bool paused);

		[PreserveSig]
		[Token(Token = "0x60002D0")]
		[Address(RVA = "0xC1E0CC", Offset = "0xC1E0CC", VA = "0xC1E0CC")]
		private static extern RESULT FMOD5_ChannelGroup_GetPaused(IntPtr channelgroup, out bool paused);

		[PreserveSig]
		[Token(Token = "0x60002D1")]
		[Address(RVA = "0xC1E178", Offset = "0xC1E178", VA = "0xC1E178")]
		private static extern RESULT FMOD5_ChannelGroup_SetVolume(IntPtr channelgroup, float volume);

		[PreserveSig]
		[Token(Token = "0x60002D2")]
		[Address(RVA = "0xC1E210", Offset = "0xC1E210", VA = "0xC1E210")]
		private static extern RESULT FMOD5_ChannelGroup_GetVolume(IntPtr channelgroup, out float volume);

		[PreserveSig]
		[Token(Token = "0x60002D3")]
		[Address(RVA = "0xC1E2AC", Offset = "0xC1E2AC", VA = "0xC1E2AC")]
		private static extern RESULT FMOD5_ChannelGroup_SetVolumeRamp(IntPtr channelgroup, bool ramp);

		[PreserveSig]
		[Token(Token = "0x60002D4")]
		[Address(RVA = "0xC1E344", Offset = "0xC1E344", VA = "0xC1E344")]
		private static extern RESULT FMOD5_ChannelGroup_GetVolumeRamp(IntPtr channelgroup, out bool ramp);

		[PreserveSig]
		[Token(Token = "0x60002D5")]
		[Address(RVA = "0xC1E3F0", Offset = "0xC1E3F0", VA = "0xC1E3F0")]
		private static extern RESULT FMOD5_ChannelGroup_GetAudibility(IntPtr channelgroup, out float audibility);

		[PreserveSig]
		[Token(Token = "0x60002D6")]
		[Address(RVA = "0xC1E488", Offset = "0xC1E488", VA = "0xC1E488")]
		private static extern RESULT FMOD5_ChannelGroup_SetPitch(IntPtr channelgroup, float pitch);

		[PreserveSig]
		[Token(Token = "0x60002D7")]
		[Address(RVA = "0xC1E520", Offset = "0xC1E520", VA = "0xC1E520")]
		private static extern RESULT FMOD5_ChannelGroup_GetPitch(IntPtr channelgroup, out float pitch);

		[PreserveSig]
		[Token(Token = "0x60002D8")]
		[Address(RVA = "0xC1E5BC", Offset = "0xC1E5BC", VA = "0xC1E5BC")]
		private static extern RESULT FMOD5_ChannelGroup_SetMute(IntPtr channelgroup, bool mute);

		[PreserveSig]
		[Token(Token = "0x60002D9")]
		[Address(RVA = "0xC1E654", Offset = "0xC1E654", VA = "0xC1E654")]
		private static extern RESULT FMOD5_ChannelGroup_GetMute(IntPtr channelgroup, out bool mute);

		[PreserveSig]
		[Token(Token = "0x60002DA")]
		[Address(RVA = "0xC1E700", Offset = "0xC1E700", VA = "0xC1E700")]
		private static extern RESULT FMOD5_ChannelGroup_SetReverbProperties(IntPtr channelgroup, int instance, float wet);

		[PreserveSig]
		[Token(Token = "0x60002DB")]
		[Address(RVA = "0xC1E7A8", Offset = "0xC1E7A8", VA = "0xC1E7A8")]
		private static extern RESULT FMOD5_ChannelGroup_GetReverbProperties(IntPtr channelgroup, int instance, out float wet);

		[PreserveSig]
		[Token(Token = "0x60002DC")]
		[Address(RVA = "0xC1E848", Offset = "0xC1E848", VA = "0xC1E848")]
		private static extern RESULT FMOD5_ChannelGroup_SetLowPassGain(IntPtr channelgroup, float gain);

		[PreserveSig]
		[Token(Token = "0x60002DD")]
		[Address(RVA = "0xC1E8E0", Offset = "0xC1E8E0", VA = "0xC1E8E0")]
		private static extern RESULT FMOD5_ChannelGroup_GetLowPassGain(IntPtr channelgroup, out float gain);

		[PreserveSig]
		[Token(Token = "0x60002DE")]
		[Address(RVA = "0xC1E978", Offset = "0xC1E978", VA = "0xC1E978")]
		private static extern RESULT FMOD5_ChannelGroup_SetMode(IntPtr channelgroup, MODE mode);

		[PreserveSig]
		[Token(Token = "0x60002DF")]
		[Address(RVA = "0xC1EA10", Offset = "0xC1EA10", VA = "0xC1EA10")]
		private static extern RESULT FMOD5_ChannelGroup_GetMode(IntPtr channelgroup, out MODE mode);

		[PreserveSig]
		[Token(Token = "0x60002E0")]
		[Address(RVA = "0xC1EAA8", Offset = "0xC1EAA8", VA = "0xC1EAA8")]
		private static extern RESULT FMOD5_ChannelGroup_SetCallback(IntPtr channelgroup, CHANNELCONTROL_CALLBACK callback);

		[PreserveSig]
		[Token(Token = "0x60002E1")]
		[Address(RVA = "0xC1EB48", Offset = "0xC1EB48", VA = "0xC1EB48")]
		private static extern RESULT FMOD5_ChannelGroup_IsPlaying(IntPtr channelgroup, out bool isplaying);

		[PreserveSig]
		[Token(Token = "0x60002E2")]
		[Address(RVA = "0xC1EBF4", Offset = "0xC1EBF4", VA = "0xC1EBF4")]
		private static extern RESULT FMOD5_ChannelGroup_SetPan(IntPtr channelgroup, float pan);

		[PreserveSig]
		[Token(Token = "0x60002E3")]
		[Address(RVA = "0xC1EC8C", Offset = "0xC1EC8C", VA = "0xC1EC8C")]
		private static extern RESULT FMOD5_ChannelGroup_SetMixLevelsOutput(IntPtr channelgroup, float frontleft, float frontright, float center, float lfe, float surroundleft, float surroundright, float backleft, float backright);

		[PreserveSig]
		[Token(Token = "0x60002E4")]
		[Address(RVA = "0xC1ED74", Offset = "0xC1ED74", VA = "0xC1ED74")]
		private static extern RESULT FMOD5_ChannelGroup_SetMixLevelsInput(IntPtr channelgroup, float[] levels, int numlevels);

		[PreserveSig]
		[Token(Token = "0x60002E5")]
		[Address(RVA = "0xC1EE1C", Offset = "0xC1EE1C", VA = "0xC1EE1C")]
		private static extern RESULT FMOD5_ChannelGroup_SetMixMatrix(IntPtr channelgroup, float[] matrix, int outchannels, int inchannels, int inchannel_hop);

		[PreserveSig]
		[Token(Token = "0x60002E6")]
		[Address(RVA = "0xC1EEDC", Offset = "0xC1EEDC", VA = "0xC1EEDC")]
		private static extern RESULT FMOD5_ChannelGroup_GetMixMatrix(IntPtr channelgroup, float[] matrix, out int outchannels, out int inchannels, int inchannel_hop);

		[PreserveSig]
		[Token(Token = "0x60002E7")]
		[Address(RVA = "0xC1EF9C", Offset = "0xC1EF9C", VA = "0xC1EF9C")]
		private static extern RESULT FMOD5_ChannelGroup_GetDSPClock(IntPtr channelgroup, out ulong dspclock, out ulong parentclock);

		[PreserveSig]
		[Token(Token = "0x60002E8")]
		[Address(RVA = "0xC1F040", Offset = "0xC1F040", VA = "0xC1F040")]
		private static extern RESULT FMOD5_ChannelGroup_SetDelay(IntPtr channelgroup, ulong dspclock_start, ulong dspclock_end, bool stopchannels);

		[PreserveSig]
		[Token(Token = "0x60002E9")]
		[Address(RVA = "0xC1F144", Offset = "0xC1F144", VA = "0xC1F144")]
		private static extern RESULT FMOD5_ChannelGroup_GetDelay(IntPtr channelgroup, out ulong dspclock_start, out ulong dspclock_end, IntPtr zero);

		[PreserveSig]
		[Token(Token = "0x60002EA")]
		[Address(RVA = "0xC1F1F4", Offset = "0xC1F1F4", VA = "0xC1F1F4")]
		private static extern RESULT FMOD5_ChannelGroup_GetDelay(IntPtr channelgroup, out ulong dspclock_start, out ulong dspclock_end, out bool stopchannels);

		[PreserveSig]
		[Token(Token = "0x60002EB")]
		[Address(RVA = "0xC1F2B8", Offset = "0xC1F2B8", VA = "0xC1F2B8")]
		private static extern RESULT FMOD5_ChannelGroup_AddFadePoint(IntPtr channelgroup, ulong dspclock, float volume);

		[PreserveSig]
		[Token(Token = "0x60002EC")]
		[Address(RVA = "0xC1F360", Offset = "0xC1F360", VA = "0xC1F360")]
		private static extern RESULT FMOD5_ChannelGroup_SetFadePointRamp(IntPtr channelgroup, ulong dspclock, float volume);

		[PreserveSig]
		[Token(Token = "0x60002ED")]
		[Address(RVA = "0xC1F408", Offset = "0xC1F408", VA = "0xC1F408")]
		private static extern RESULT FMOD5_ChannelGroup_RemoveFadePoints(IntPtr channelgroup, ulong dspclock_start, ulong dspclock_end);

		[PreserveSig]
		[Token(Token = "0x60002EE")]
		[Address(RVA = "0xC1F4A8", Offset = "0xC1F4A8", VA = "0xC1F4A8")]
		private static extern RESULT FMOD5_ChannelGroup_GetFadePoints(IntPtr channelgroup, ref uint numpoints, ulong[] point_dspclock, float[] point_volume);

		[PreserveSig]
		[Token(Token = "0x60002EF")]
		[Address(RVA = "0xC1F564", Offset = "0xC1F564", VA = "0xC1F564")]
		private static extern RESULT FMOD5_ChannelGroup_GetDSP(IntPtr channelgroup, int index, out IntPtr dsp);

		[PreserveSig]
		[Token(Token = "0x60002F0")]
		[Address(RVA = "0xC1F604", Offset = "0xC1F604", VA = "0xC1F604")]
		private static extern RESULT FMOD5_ChannelGroup_AddDSP(IntPtr channelgroup, int index, IntPtr dsp);

		[PreserveSig]
		[Token(Token = "0x60002F1")]
		[Address(RVA = "0xC1F6A4", Offset = "0xC1F6A4", VA = "0xC1F6A4")]
		private static extern RESULT FMOD5_ChannelGroup_RemoveDSP(IntPtr channelgroup, IntPtr dsp);

		[PreserveSig]
		[Token(Token = "0x60002F2")]
		[Address(RVA = "0xC1F73C", Offset = "0xC1F73C", VA = "0xC1F73C")]
		private static extern RESULT FMOD5_ChannelGroup_GetNumDSPs(IntPtr channelgroup, out int numdsps);

		[PreserveSig]
		[Token(Token = "0x60002F3")]
		[Address(RVA = "0xC1F7D4", Offset = "0xC1F7D4", VA = "0xC1F7D4")]
		private static extern RESULT FMOD5_ChannelGroup_SetDSPIndex(IntPtr channelgroup, IntPtr dsp, int index);

		[PreserveSig]
		[Token(Token = "0x60002F4")]
		[Address(RVA = "0xC1F874", Offset = "0xC1F874", VA = "0xC1F874")]
		private static extern RESULT FMOD5_ChannelGroup_GetDSPIndex(IntPtr channelgroup, IntPtr dsp, out int index);

		[PreserveSig]
		[Token(Token = "0x60002F5")]
		[Address(RVA = "0xC1F914", Offset = "0xC1F914", VA = "0xC1F914")]
		private static extern RESULT FMOD5_ChannelGroup_Set3DAttributes(IntPtr channelgroup, ref VECTOR pos, ref VECTOR vel);

		[PreserveSig]
		[Token(Token = "0x60002F6")]
		[Address(RVA = "0xC1F9B4", Offset = "0xC1F9B4", VA = "0xC1F9B4")]
		private static extern RESULT FMOD5_ChannelGroup_Get3DAttributes(IntPtr channelgroup, out VECTOR pos, out VECTOR vel);

		[PreserveSig]
		[Token(Token = "0x60002F7")]
		[Address(RVA = "0xC1FA54", Offset = "0xC1FA54", VA = "0xC1FA54")]
		private static extern RESULT FMOD5_ChannelGroup_Set3DMinMaxDistance(IntPtr channelgroup, float mindistance, float maxdistance);

		[PreserveSig]
		[Token(Token = "0x60002F8")]
		[Address(RVA = "0xC1FAF4", Offset = "0xC1FAF4", VA = "0xC1FAF4")]
		private static extern RESULT FMOD5_ChannelGroup_Get3DMinMaxDistance(IntPtr channelgroup, out float mindistance, out float maxdistance);

		[PreserveSig]
		[Token(Token = "0x60002F9")]
		[Address(RVA = "0xC1FB94", Offset = "0xC1FB94", VA = "0xC1FB94")]
		private static extern RESULT FMOD5_ChannelGroup_Set3DConeSettings(IntPtr channelgroup, float insideconeangle, float outsideconeangle, float outsidevolume);

		[PreserveSig]
		[Token(Token = "0x60002FA")]
		[Address(RVA = "0xC1FC44", Offset = "0xC1FC44", VA = "0xC1FC44")]
		private static extern RESULT FMOD5_ChannelGroup_Get3DConeSettings(IntPtr channelgroup, out float insideconeangle, out float outsideconeangle, out float outsidevolume);

		[PreserveSig]
		[Token(Token = "0x60002FB")]
		[Address(RVA = "0xC1FCF4", Offset = "0xC1FCF4", VA = "0xC1FCF4")]
		private static extern RESULT FMOD5_ChannelGroup_Set3DConeOrientation(IntPtr channelgroup, ref VECTOR orientation);

		[PreserveSig]
		[Token(Token = "0x60002FC")]
		[Address(RVA = "0xC1FD8C", Offset = "0xC1FD8C", VA = "0xC1FD8C")]
		private static extern RESULT FMOD5_ChannelGroup_Get3DConeOrientation(IntPtr channelgroup, out VECTOR orientation);

		[PreserveSig]
		[Token(Token = "0x60002FD")]
		[Address(RVA = "0xC1FE24", Offset = "0xC1FE24", VA = "0xC1FE24")]
		private static extern RESULT FMOD5_ChannelGroup_Set3DCustomRolloff(IntPtr channelgroup, ref VECTOR points, int numpoints);

		[PreserveSig]
		[Token(Token = "0x60002FE")]
		[Address(RVA = "0xC1FEC4", Offset = "0xC1FEC4", VA = "0xC1FEC4")]
		private static extern RESULT FMOD5_ChannelGroup_Get3DCustomRolloff(IntPtr channelgroup, out IntPtr points, out int numpoints);

		[PreserveSig]
		[Token(Token = "0x60002FF")]
		[Address(RVA = "0xC1FF64", Offset = "0xC1FF64", VA = "0xC1FF64")]
		private static extern RESULT FMOD5_ChannelGroup_Set3DOcclusion(IntPtr channelgroup, float directocclusion, float reverbocclusion);

		[PreserveSig]
		[Token(Token = "0x6000300")]
		[Address(RVA = "0xC20004", Offset = "0xC20004", VA = "0xC20004")]
		private static extern RESULT FMOD5_ChannelGroup_Get3DOcclusion(IntPtr channelgroup, out float directocclusion, out float reverbocclusion);

		[PreserveSig]
		[Token(Token = "0x6000301")]
		[Address(RVA = "0xC200A4", Offset = "0xC200A4", VA = "0xC200A4")]
		private static extern RESULT FMOD5_ChannelGroup_Set3DSpread(IntPtr channelgroup, float angle);

		[PreserveSig]
		[Token(Token = "0x6000302")]
		[Address(RVA = "0xC2013C", Offset = "0xC2013C", VA = "0xC2013C")]
		private static extern RESULT FMOD5_ChannelGroup_Get3DSpread(IntPtr channelgroup, out float angle);

		[PreserveSig]
		[Token(Token = "0x6000303")]
		[Address(RVA = "0xC201D4", Offset = "0xC201D4", VA = "0xC201D4")]
		private static extern RESULT FMOD5_ChannelGroup_Set3DLevel(IntPtr channelgroup, float level);

		[PreserveSig]
		[Token(Token = "0x6000304")]
		[Address(RVA = "0xC2026C", Offset = "0xC2026C", VA = "0xC2026C")]
		private static extern RESULT FMOD5_ChannelGroup_Get3DLevel(IntPtr channelgroup, out float level);

		[PreserveSig]
		[Token(Token = "0x6000305")]
		[Address(RVA = "0xC20304", Offset = "0xC20304", VA = "0xC20304")]
		private static extern RESULT FMOD5_ChannelGroup_Set3DDopplerLevel(IntPtr channelgroup, float level);

		[PreserveSig]
		[Token(Token = "0x6000306")]
		[Address(RVA = "0xC2039C", Offset = "0xC2039C", VA = "0xC2039C")]
		private static extern RESULT FMOD5_ChannelGroup_Get3DDopplerLevel(IntPtr channelgroup, out float level);

		[PreserveSig]
		[Token(Token = "0x6000307")]
		[Address(RVA = "0xC20438", Offset = "0xC20438", VA = "0xC20438")]
		private static extern RESULT FMOD5_ChannelGroup_Set3DDistanceFilter(IntPtr channelgroup, bool custom, float customLevel, float centerFreq);

		[PreserveSig]
		[Token(Token = "0x6000308")]
		[Address(RVA = "0xC204E8", Offset = "0xC204E8", VA = "0xC204E8")]
		private static extern RESULT FMOD5_ChannelGroup_Get3DDistanceFilter(IntPtr channelgroup, out bool custom, out float customLevel, out float centerFreq);

		[PreserveSig]
		[Token(Token = "0x6000309")]
		[Address(RVA = "0xC205AC", Offset = "0xC205AC", VA = "0xC205AC")]
		private static extern RESULT FMOD5_ChannelGroup_SetUserData(IntPtr channelgroup, IntPtr userdata);

		[PreserveSig]
		[Token(Token = "0x600030A")]
		[Address(RVA = "0xC20644", Offset = "0xC20644", VA = "0xC20644")]
		private static extern RESULT FMOD5_ChannelGroup_GetUserData(IntPtr channelgroup, out IntPtr userdata);

		[Token(Token = "0x600030B")]
		[Address(RVA = "0xC206D4", Offset = "0xC206D4", VA = "0xC206D4")]
		public bool hasHandle()
		{
			return default(bool);
		}

		[Token(Token = "0x600030C")]
		[Address(RVA = "0xC2071C", Offset = "0xC2071C", VA = "0xC2071C")]
		public void clearHandle()
		{
		}
	}
	[Token(Token = "0x200004C")]
	public struct SoundGroup
	{
		[Token(Token = "0x4000242")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public IntPtr handle;

		[Token(Token = "0x600030D")]
		[Address(RVA = "0x1E3DBA0", Offset = "0x1E3DBA0", VA = "0x1E3DBA0")]
		public RESULT release()
		{
			return default(RESULT);
		}

		[Token(Token = "0x600030E")]
		[Address(RVA = "0x1E3DC28", Offset = "0x1E3DC28", VA = "0x1E3DC28")]
		public RESULT getSystemObject(out System system)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600030F")]
		[Address(RVA = "0x1E3DCC0", Offset = "0x1E3DCC0", VA = "0x1E3DCC0")]
		public RESULT setMaxAudible(int maxaudible)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000310")]
		[Address(RVA = "0x1E3DD58", Offset = "0x1E3DD58", VA = "0x1E3DD58")]
		public RESULT getMaxAudible(out int maxaudible)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000311")]
		[Address(RVA = "0x1E3DDF0", Offset = "0x1E3DDF0", VA = "0x1E3DDF0")]
		public RESULT setMaxAudibleBehavior(SOUNDGROUP_BEHAVIOR behavior)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000312")]
		[Address(RVA = "0x1E3DE88", Offset = "0x1E3DE88", VA = "0x1E3DE88")]
		public RESULT getMaxAudibleBehavior(out SOUNDGROUP_BEHAVIOR behavior)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000313")]
		[Address(RVA = "0x1E3DF20", Offset = "0x1E3DF20", VA = "0x1E3DF20")]
		public RESULT setMuteFadeSpeed(float speed)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000314")]
		[Address(RVA = "0x1E3DFB8", Offset = "0x1E3DFB8", VA = "0x1E3DFB8")]
		public RESULT getMuteFadeSpeed(out float speed)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000315")]
		[Address(RVA = "0x1E3E050", Offset = "0x1E3E050", VA = "0x1E3E050")]
		public RESULT setVolume(float volume)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000316")]
		[Address(RVA = "0x1E3E0E8", Offset = "0x1E3E0E8", VA = "0x1E3E0E8")]
		public RESULT getVolume(out float volume)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000317")]
		[Address(RVA = "0x1E3E180", Offset = "0x1E3E180", VA = "0x1E3E180")]
		public RESULT stop()
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000318")]
		[Address(RVA = "0x1E3E208", Offset = "0x1E3E208", VA = "0x1E3E208")]
		public RESULT getName(out string name, int namelen)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000319")]
		[Address(RVA = "0x1E3E49C", Offset = "0x1E3E49C", VA = "0x1E3E49C")]
		public RESULT getNumSounds(out int numsounds)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600031A")]
		[Address(RVA = "0x1E3E534", Offset = "0x1E3E534", VA = "0x1E3E534")]
		public RESULT getSound(int index, out Sound sound)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600031B")]
		[Address(RVA = "0x1E3E5D4", Offset = "0x1E3E5D4", VA = "0x1E3E5D4")]
		public RESULT getNumPlaying(out int numplaying)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600031C")]
		[Address(RVA = "0x1E3E66C", Offset = "0x1E3E66C", VA = "0x1E3E66C")]
		public RESULT setUserData(IntPtr userdata)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600031D")]
		[Address(RVA = "0x1E3E704", Offset = "0x1E3E704", VA = "0x1E3E704")]
		public RESULT getUserData(out IntPtr userdata)
		{
			return default(RESULT);
		}

		[PreserveSig]
		[Token(Token = "0x600031E")]
		[Address(RVA = "0x1E3DBA8", Offset = "0x1E3DBA8", VA = "0x1E3DBA8")]
		private static extern RESULT FMOD5_SoundGroup_Release(IntPtr soundgroup);

		[PreserveSig]
		[Token(Token = "0x600031F")]
		[Address(RVA = "0x1E3DC30", Offset = "0x1E3DC30", VA = "0x1E3DC30")]
		private static extern RESULT FMOD5_SoundGroup_GetSystemObject(IntPtr soundgroup, out IntPtr system);

		[PreserveSig]
		[Token(Token = "0x6000320")]
		[Address(RVA = "0x1E3DCC8", Offset = "0x1E3DCC8", VA = "0x1E3DCC8")]
		private static extern RESULT FMOD5_SoundGroup_SetMaxAudible(IntPtr soundgroup, int maxaudible);

		[PreserveSig]
		[Token(Token = "0x6000321")]
		[Address(RVA = "0x1E3DD60", Offset = "0x1E3DD60", VA = "0x1E3DD60")]
		private static extern RESULT FMOD5_SoundGroup_GetMaxAudible(IntPtr soundgroup, out int maxaudible);

		[PreserveSig]
		[Token(Token = "0x6000322")]
		[Address(RVA = "0x1E3DDF8", Offset = "0x1E3DDF8", VA = "0x1E3DDF8")]
		private static extern RESULT FMOD5_SoundGroup_SetMaxAudibleBehavior(IntPtr soundgroup, SOUNDGROUP_BEHAVIOR behavior);

		[PreserveSig]
		[Token(Token = "0x6000323")]
		[Address(RVA = "0x1E3DE90", Offset = "0x1E3DE90", VA = "0x1E3DE90")]
		private static extern RESULT FMOD5_SoundGroup_GetMaxAudibleBehavior(IntPtr soundgroup, out SOUNDGROUP_BEHAVIOR behavior);

		[PreserveSig]
		[Token(Token = "0x6000324")]
		[Address(RVA = "0x1E3DF28", Offset = "0x1E3DF28", VA = "0x1E3DF28")]
		private static extern RESULT FMOD5_SoundGroup_SetMuteFadeSpeed(IntPtr soundgroup, float speed);

		[PreserveSig]
		[Token(Token = "0x6000325")]
		[Address(RVA = "0x1E3DFC0", Offset = "0x1E3DFC0", VA = "0x1E3DFC0")]
		private static extern RESULT FMOD5_SoundGroup_GetMuteFadeSpeed(IntPtr soundgroup, out float speed);

		[PreserveSig]
		[Token(Token = "0x6000326")]
		[Address(RVA = "0x1E3E058", Offset = "0x1E3E058", VA = "0x1E3E058")]
		private static extern RESULT FMOD5_SoundGroup_SetVolume(IntPtr soundgroup, float volume);

		[PreserveSig]
		[Token(Token = "0x6000327")]
		[Address(RVA = "0x1E3E0F0", Offset = "0x1E3E0F0", VA = "0x1E3E0F0")]
		private static extern RESULT FMOD5_SoundGroup_GetVolume(IntPtr soundgroup, out float volume);

		[PreserveSig]
		[Token(Token = "0x6000328")]
		[Address(RVA = "0x1E3E188", Offset = "0x1E3E188", VA = "0x1E3E188")]
		private static extern RESULT FMOD5_SoundGroup_Stop(IntPtr soundgroup);

		[PreserveSig]
		[Token(Token = "0x6000329")]
		[Address(RVA = "0x1E3E404", Offset = "0x1E3E404", VA = "0x1E3E404")]
		private static extern RESULT FMOD5_SoundGroup_GetName(IntPtr soundgroup, IntPtr name, int namelen);

		[PreserveSig]
		[Token(Token = "0x600032A")]
		[Address(RVA = "0x1E3E4A4", Offset = "0x1E3E4A4", VA = "0x1E3E4A4")]
		private static extern RESULT FMOD5_SoundGroup_GetNumSounds(IntPtr soundgroup, out int numsounds);

		[PreserveSig]
		[Token(Token = "0x600032B")]
		[Address(RVA = "0x1E3E53C", Offset = "0x1E3E53C", VA = "0x1E3E53C")]
		private static extern RESULT FMOD5_SoundGroup_GetSound(IntPtr soundgroup, int index, out IntPtr sound);

		[PreserveSig]
		[Token(Token = "0x600032C")]
		[Address(RVA = "0x1E3E5DC", Offset = "0x1E3E5DC", VA = "0x1E3E5DC")]
		private static extern RESULT FMOD5_SoundGroup_GetNumPlaying(IntPtr soundgroup, out int numplaying);

		[PreserveSig]
		[Token(Token = "0x600032D")]
		[Address(RVA = "0x1E3E674", Offset = "0x1E3E674", VA = "0x1E3E674")]
		private static extern RESULT FMOD5_SoundGroup_SetUserData(IntPtr soundgroup, IntPtr userdata);

		[PreserveSig]
		[Token(Token = "0x600032E")]
		[Address(RVA = "0x1E3E70C", Offset = "0x1E3E70C", VA = "0x1E3E70C")]
		private static extern RESULT FMOD5_SoundGroup_GetUserData(IntPtr soundgroup, out IntPtr userdata);

		[Token(Token = "0x600032F")]
		[Address(RVA = "0x1E3E79C", Offset = "0x1E3E79C", VA = "0x1E3E79C")]
		public bool hasHandle()
		{
			return default(bool);
		}

		[Token(Token = "0x6000330")]
		[Address(RVA = "0x1E3E7E4", Offset = "0x1E3E7E4", VA = "0x1E3E7E4")]
		public void clearHandle()
		{
		}
	}
	[Token(Token = "0x200004D")]
	public struct DSP
	{
		[Token(Token = "0x4000243")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public IntPtr handle;

		[Token(Token = "0x6000331")]
		[Address(RVA = "0xC21D88", Offset = "0xC21D88", VA = "0xC21D88")]
		public RESULT release()
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000332")]
		[Address(RVA = "0xC21E10", Offset = "0xC21E10", VA = "0xC21E10")]
		public RESULT getSystemObject(out System system)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000333")]
		[Address(RVA = "0xC21EA8", Offset = "0xC21EA8", VA = "0xC21EA8")]
		public RESULT addInput(DSP input)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000334")]
		[Address(RVA = "0xC21FA8", Offset = "0xC21FA8", VA = "0xC21FA8")]
		public RESULT addInput(DSP input, out DSPConnection connection, DSPCONNECTION_TYPE type = DSPCONNECTION_TYPE.STANDARD)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000335")]
		[Address(RVA = "0xC22058", Offset = "0xC22058", VA = "0xC22058")]
		public RESULT disconnectFrom(DSP target, DSPConnection connection)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000336")]
		[Address(RVA = "0xC220F4", Offset = "0xC220F4", VA = "0xC220F4")]
		public RESULT disconnectAll(bool inputs, bool outputs)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000337")]
		[Address(RVA = "0xC2219C", Offset = "0xC2219C", VA = "0xC2219C")]
		public RESULT getNumInputs(out int numinputs)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000338")]
		[Address(RVA = "0xC22234", Offset = "0xC22234", VA = "0xC22234")]
		public RESULT getNumOutputs(out int numoutputs)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000339")]
		[Address(RVA = "0xC222CC", Offset = "0xC222CC", VA = "0xC222CC")]
		public RESULT getInput(int index, out DSP input, out DSPConnection inputconnection)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600033A")]
		[Address(RVA = "0xC2237C", Offset = "0xC2237C", VA = "0xC2237C")]
		public RESULT getOutput(int index, out DSP output, out DSPConnection outputconnection)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600033B")]
		[Address(RVA = "0xC2242C", Offset = "0xC2242C", VA = "0xC2242C")]
		public RESULT setActive(bool active)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600033C")]
		[Address(RVA = "0xC224C8", Offset = "0xC224C8", VA = "0xC224C8")]
		public RESULT getActive(out bool active)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600033D")]
		[Address(RVA = "0xC22574", Offset = "0xC22574", VA = "0xC22574")]
		public RESULT setBypass(bool bypass)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600033E")]
		[Address(RVA = "0xC22610", Offset = "0xC22610", VA = "0xC22610")]
		public RESULT getBypass(out bool bypass)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600033F")]
		[Address(RVA = "0xC226BC", Offset = "0xC226BC", VA = "0xC226BC")]
		public RESULT setWetDryMix(float prewet, float postwet, float dry)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000340")]
		[Address(RVA = "0xC2276C", Offset = "0xC2276C", VA = "0xC2276C")]
		public RESULT getWetDryMix(out float prewet, out float postwet, out float dry)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000341")]
		[Address(RVA = "0xC2281C", Offset = "0xC2281C", VA = "0xC2281C")]
		public RESULT setChannelFormat(CHANNELMASK channelmask, int numchannels, SPEAKERMODE source_speakermode)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000342")]
		[Address(RVA = "0xC228CC", Offset = "0xC228CC", VA = "0xC228CC")]
		public RESULT getChannelFormat(out CHANNELMASK channelmask, out int numchannels, out SPEAKERMODE source_speakermode)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000343")]
		[Address(RVA = "0xC2297C", Offset = "0xC2297C", VA = "0xC2297C")]
		public RESULT getOutputChannelFormat(CHANNELMASK inmask, int inchannels, SPEAKERMODE inspeakermode, out CHANNELMASK outmask, out int outchannels, out SPEAKERMODE outspeakermode)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000344")]
		[Address(RVA = "0xC22A4C", Offset = "0xC22A4C", VA = "0xC22A4C")]
		public RESULT reset()
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000345")]
		[Address(RVA = "0xC22AD4", Offset = "0xC22AD4", VA = "0xC22AD4")]
		public RESULT setParameterFloat(int index, float value)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000346")]
		[Address(RVA = "0xC22B7C", Offset = "0xC22B7C", VA = "0xC22B7C")]
		public RESULT setParameterInt(int index, int value)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000347")]
		[Address(RVA = "0xC22C1C", Offset = "0xC22C1C", VA = "0xC22C1C")]
		public RESULT setParameterBool(int index, bool value)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000348")]
		[Address(RVA = "0xC22CC0", Offset = "0xC22CC0", VA = "0xC22CC0")]
		public RESULT setParameterData(int index, byte[] data)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000349")]
		[Address(RVA = "0xC22E14", Offset = "0xC22E14", VA = "0xC22E14")]
		public RESULT getParameterFloat(int index, out float value)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600034A")]
		[Address(RVA = "0xC22F24", Offset = "0xC22F24", VA = "0xC22F24")]
		public RESULT getParameterInt(int index, out int value)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600034B")]
		[Address(RVA = "0xC23034", Offset = "0xC23034", VA = "0xC23034")]
		public RESULT getParameterBool(int index, out bool value)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600034C")]
		[Address(RVA = "0xC23158", Offset = "0xC23158", VA = "0xC23158")]
		public RESULT getParameterData(int index, out IntPtr data, out uint length)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600034D")]
		[Address(RVA = "0xC23288", Offset = "0xC23288", VA = "0xC23288")]
		public RESULT getNumParameters(out int numparams)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600034E")]
		[Address(RVA = "0xC23320", Offset = "0xC23320", VA = "0xC23320")]
		public RESULT getParameterInfo(int index, out DSP_PARAMETER_DESC desc)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600034F")]
		[Address(RVA = "0xC23494", Offset = "0xC23494", VA = "0xC23494")]
		public RESULT getDataParameterIndex(int datatype, out int index)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000350")]
		[Address(RVA = "0xC23534", Offset = "0xC23534", VA = "0xC23534")]
		public RESULT showConfigDialog(IntPtr hwnd, bool show)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000351")]
		[Address(RVA = "0xC235D8", Offset = "0xC235D8", VA = "0xC235D8")]
		public RESULT getInfo(out string name, out uint version, out int channels, out int configwidth, out int configheight)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000352")]
		[Address(RVA = "0xC238B4", Offset = "0xC238B4", VA = "0xC238B4")]
		public RESULT getInfo(out uint version, out int channels, out int configwidth, out int configheight)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000353")]
		[Address(RVA = "0xC23928", Offset = "0xC23928", VA = "0xC23928")]
		public RESULT getType(out DSP_TYPE type)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000354")]
		[Address(RVA = "0xC239C0", Offset = "0xC239C0", VA = "0xC239C0")]
		public RESULT getIdle(out bool idle)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000355")]
		[Address(RVA = "0xC23A6C", Offset = "0xC23A6C", VA = "0xC23A6C")]
		public RESULT setUserData(IntPtr userdata)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000356")]
		[Address(RVA = "0xC23B04", Offset = "0xC23B04", VA = "0xC23B04")]
		public RESULT getUserData(out IntPtr userdata)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000357")]
		[Address(RVA = "0xC23B9C", Offset = "0xC23B9C", VA = "0xC23B9C")]
		public RESULT setMeteringEnabled(bool inputEnabled, bool outputEnabled)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000358")]
		[Address(RVA = "0xC23C44", Offset = "0xC23C44", VA = "0xC23C44")]
		public RESULT getMeteringEnabled(out bool inputEnabled, out bool outputEnabled)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000359")]
		[Address(RVA = "0xC23D08", Offset = "0xC23D08", VA = "0xC23D08")]
		public RESULT getMeteringInfo(IntPtr zero, out DSP_METERING_INFO outputInfo)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600035A")]
		[Address(RVA = "0xC23DEC", Offset = "0xC23DEC", VA = "0xC23DEC")]
		public RESULT getMeteringInfo(out DSP_METERING_INFO inputInfo, IntPtr zero)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600035B")]
		[Address(RVA = "0xC23ED0", Offset = "0xC23ED0", VA = "0xC23ED0")]
		public RESULT getMeteringInfo(out DSP_METERING_INFO inputInfo, out DSP_METERING_INFO outputInfo)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600035C")]
		[Address(RVA = "0xC23FD4", Offset = "0xC23FD4", VA = "0xC23FD4")]
		public RESULT getCPUUsage(out uint exclusive, out uint inclusive)
		{
			return default(RESULT);
		}

		[PreserveSig]
		[Token(Token = "0x600035D")]
		[Address(RVA = "0xC21D90", Offset = "0xC21D90", VA = "0xC21D90")]
		private static extern RESULT FMOD5_DSP_Release(IntPtr dsp);

		[PreserveSig]
		[Token(Token = "0x600035E")]
		[Address(RVA = "0xC21E18", Offset = "0xC21E18", VA = "0xC21E18")]
		private static extern RESULT FMOD5_DSP_GetSystemObject(IntPtr dsp, out IntPtr system);

		[PreserveSig]
		[Token(Token = "0x600035F")]
		[Address(RVA = "0xC21F00", Offset = "0xC21F00", VA = "0xC21F00")]
		private static extern RESULT FMOD5_DSP_AddInput(IntPtr dsp, IntPtr input, IntPtr zero, DSPCONNECTION_TYPE type);

		[PreserveSig]
		[Token(Token = "0x6000360")]
		[Address(RVA = "0xC21FB0", Offset = "0xC21FB0", VA = "0xC21FB0")]
		private static extern RESULT FMOD5_DSP_AddInput(IntPtr dsp, IntPtr input, out IntPtr connection, DSPCONNECTION_TYPE type);

		[PreserveSig]
		[Token(Token = "0x6000361")]
		[Address(RVA = "0xC22060", Offset = "0xC22060", VA = "0xC22060")]
		private static extern RESULT FMOD5_DSP_DisconnectFrom(IntPtr dsp, IntPtr target, IntPtr connection);

		[PreserveSig]
		[Token(Token = "0x6000362")]
		[Address(RVA = "0xC22104", Offset = "0xC22104", VA = "0xC22104")]
		private static extern RESULT FMOD5_DSP_DisconnectAll(IntPtr dsp, bool inputs, bool outputs);

		[PreserveSig]
		[Token(Token = "0x6000363")]
		[Address(RVA = "0xC221A4", Offset = "0xC221A4", VA = "0xC221A4")]
		private static extern RESULT FMOD5_DSP_GetNumInputs(IntPtr dsp, out int numinputs);

		[PreserveSig]
		[Token(Token = "0x6000364")]
		[Address(RVA = "0xC2223C", Offset = "0xC2223C", VA = "0xC2223C")]
		private static extern RESULT FMOD5_DSP_GetNumOutputs(IntPtr dsp, out int numoutputs);

		[PreserveSig]
		[Token(Token = "0x6000365")]
		[Address(RVA = "0xC222D4", Offset = "0xC222D4", VA = "0xC222D4")]
		private static extern RESULT FMOD5_DSP_GetInput(IntPtr dsp, int index, out IntPtr input, out IntPtr inputconnection);

		[PreserveSig]
		[Token(Token = "0x6000366")]
		[Address(RVA = "0xC22384", Offset = "0xC22384", VA = "0xC22384")]
		private static extern RESULT FMOD5_DSP_GetOutput(IntPtr dsp, int index, out IntPtr output, out IntPtr outputconnection);

		[PreserveSig]
		[Token(Token = "0x6000367")]
		[Address(RVA = "0xC22438", Offset = "0xC22438", VA = "0xC22438")]
		private static extern RESULT FMOD5_DSP_SetActive(IntPtr dsp, bool active);

		[PreserveSig]
		[Token(Token = "0x6000368")]
		[Address(RVA = "0xC224D0", Offset = "0xC224D0", VA = "0xC224D0")]
		private static extern RESULT FMOD5_DSP_GetActive(IntPtr dsp, out bool active);

		[PreserveSig]
		[Token(Token = "0x6000369")]
		[Address(RVA = "0xC22580", Offset = "0xC22580", VA = "0xC22580")]
		private static extern RESULT FMOD5_DSP_SetBypass(IntPtr dsp, bool bypass);

		[PreserveSig]
		[Token(Token = "0x600036A")]
		[Address(RVA = "0xC22618", Offset = "0xC22618", VA = "0xC22618")]
		private static extern RESULT FMOD5_DSP_GetBypass(IntPtr dsp, out bool bypass);

		[PreserveSig]
		[Token(Token = "0x600036B")]
		[Address(RVA = "0xC226C4", Offset = "0xC226C4", VA = "0xC226C4")]
		private static extern RESULT FMOD5_DSP_SetWetDryMix(IntPtr dsp, float prewet, float postwet, float dry);

		[PreserveSig]
		[Token(Token = "0x600036C")]
		[Address(RVA = "0xC22774", Offset = "0xC22774", VA = "0xC22774")]
		private static extern RESULT FMOD5_DSP_GetWetDryMix(IntPtr dsp, out float prewet, out float postwet, out float dry);

		[PreserveSig]
		[Token(Token = "0x600036D")]
		[Address(RVA = "0xC22824", Offset = "0xC22824", VA = "0xC22824")]
		private static extern RESULT FMOD5_DSP_SetChannelFormat(IntPtr dsp, CHANNELMASK channelmask, int numchannels, SPEAKERMODE source_speakermode);

		[PreserveSig]
		[Token(Token = "0x600036E")]
		[Address(RVA = "0xC228D4", Offset = "0xC228D4", VA = "0xC228D4")]
		private static extern RESULT FMOD5_DSP_GetChannelFormat(IntPtr dsp, out CHANNELMASK channelmask, out int numchannels, out SPEAKERMODE source_speakermode);

		[PreserveSig]
		[Token(Token = "0x600036F")]
		[Address(RVA = "0xC22984", Offset = "0xC22984", VA = "0xC22984")]
		private static extern RESULT FMOD5_DSP_GetOutputChannelFormat(IntPtr dsp, CHANNELMASK inmask, int inchannels, SPEAKERMODE inspeakermode, out CHANNELMASK outmask, out int outchannels, out SPEAKERMODE outspeakermode);

		[PreserveSig]
		[Token(Token = "0x6000370")]
		[Address(RVA = "0xC22A54", Offset = "0xC22A54", VA = "0xC22A54")]
		private static extern RESULT FMOD5_DSP_Reset(IntPtr dsp);

		[PreserveSig]
		[Token(Token = "0x6000371")]
		[Address(RVA = "0xC22ADC", Offset = "0xC22ADC", VA = "0xC22ADC")]
		private static extern RESULT FMOD5_DSP_SetParameterFloat(IntPtr dsp, int index, float value);

		[PreserveSig]
		[Token(Token = "0x6000372")]
		[Address(RVA = "0xC22B84", Offset = "0xC22B84", VA = "0xC22B84")]
		private static extern RESULT FMOD5_DSP_SetParameterInt(IntPtr dsp, int index, int value);

		[PreserveSig]
		[Token(Token = "0x6000373")]
		[Address(RVA = "0xC22C28", Offset = "0xC22C28", VA = "0xC22C28")]
		private static extern RESULT FMOD5_DSP_SetParameterBool(IntPtr dsp, int index, bool value);

		[PreserveSig]
		[Token(Token = "0x6000374")]
		[Address(RVA = "0xC22D6C", Offset = "0xC22D6C", VA = "0xC22D6C")]
		private static extern RESULT FMOD5_DSP_SetParameterData(IntPtr dsp, int index, IntPtr data, uint length);

		[PreserveSig]
		[Token(Token = "0x6000375")]
		[Address(RVA = "0xC22E74", Offset = "0xC22E74", VA = "0xC22E74")]
		private static extern RESULT FMOD5_DSP_GetParameterFloat(IntPtr dsp, int index, out float value, IntPtr valuestr, int valuestrlen);

		[PreserveSig]
		[Token(Token = "0x6000376")]
		[Address(RVA = "0xC22F84", Offset = "0xC22F84", VA = "0xC22F84")]
		private static extern RESULT FMOD5_DSP_GetParameterInt(IntPtr dsp, int index, out int value, IntPtr valuestr, int valuestrlen);

		[PreserveSig]
		[Token(Token = "0x6000377")]
		[Address(RVA = "0xC23094", Offset = "0xC23094", VA = "0xC23094")]
		private static extern RESULT FMOD5_DSP_GetParameterBool(IntPtr dsp, int index, out bool value, IntPtr valuestr, int valuestrlen);

		[PreserveSig]
		[Token(Token = "0x6000378")]
		[Address(RVA = "0xC231C8", Offset = "0xC231C8", VA = "0xC231C8")]
		private static extern RESULT FMOD5_DSP_GetParameterData(IntPtr dsp, int index, out IntPtr data, out uint length, IntPtr valuestr, int valuestrlen);

		[PreserveSig]
		[Token(Token = "0x6000379")]
		[Address(RVA = "0xC23290", Offset = "0xC23290", VA = "0xC23290")]
		private static extern RESULT FMOD5_DSP_GetNumParameters(IntPtr dsp, out int numparams);

		[PreserveSig]
		[Token(Token = "0x600037A")]
		[Address(RVA = "0xC233FC", Offset = "0xC233FC", VA = "0xC233FC")]
		private static extern RESULT FMOD5_DSP_GetParameterInfo(IntPtr dsp, int index, out IntPtr desc);

		[PreserveSig]
		[Token(Token = "0x600037B")]
		[Address(RVA = "0xC2349C", Offset = "0xC2349C", VA = "0xC2349C")]
		private static extern RESULT FMOD5_DSP_GetDataParameterIndex(IntPtr dsp, int datatype, out int index);

		[PreserveSig]
		[Token(Token = "0x600037C")]
		[Address(RVA = "0xC23540", Offset = "0xC23540", VA = "0xC23540")]
		private static extern RESULT FMOD5_DSP_ShowConfigDialog(IntPtr dsp, IntPtr hwnd, bool show);

		[PreserveSig]
		[Token(Token = "0x600037D")]
		[Address(RVA = "0xC237F4", Offset = "0xC237F4", VA = "0xC237F4")]
		private static extern RESULT FMOD5_DSP_GetInfo(IntPtr dsp, IntPtr name, out uint version, out int channels, out int configwidth, out int configheight);

		[PreserveSig]
		[Token(Token = "0x600037E")]
		[Address(RVA = "0xC23930", Offset = "0xC23930", VA = "0xC23930")]
		private static extern RESULT FMOD5_DSP_GetType(IntPtr dsp, out DSP_TYPE type);

		[PreserveSig]
		[Token(Token = "0x600037F")]
		[Address(RVA = "0xC239C8", Offset = "0xC239C8", VA = "0xC239C8")]
		private static extern RESULT FMOD5_DSP_GetIdle(IntPtr dsp, out bool idle);

		[PreserveSig]
		[Token(Token = "0x6000380")]
		[Address(RVA = "0xC23A74", Offset = "0xC23A74", VA = "0xC23A74")]
		private static extern RESULT FMOD5_DSP_SetUserData(IntPtr dsp, IntPtr userdata);

		[PreserveSig]
		[Token(Token = "0x6000381")]
		[Address(RVA = "0xC23B0C", Offset = "0xC23B0C", VA = "0xC23B0C")]
		private static extern RESULT FMOD5_DSP_GetUserData(IntPtr dsp, out IntPtr userdata);

		[PreserveSig]
		[Token(Token = "0x6000382")]
		[Address(RVA = "0xC23BAC", Offset = "0xC23BAC", VA = "0xC23BAC")]
		public static extern RESULT FMOD5_DSP_SetMeteringEnabled(IntPtr dsp, bool inputEnabled, bool outputEnabled);

		[PreserveSig]
		[Token(Token = "0x6000383")]
		[Address(RVA = "0xC23C4C", Offset = "0xC23C4C", VA = "0xC23C4C")]
		public static extern RESULT FMOD5_DSP_GetMeteringEnabled(IntPtr dsp, out bool inputEnabled, out bool outputEnabled);

		[PreserveSig]
		[Token(Token = "0x6000384")]
		[Address(RVA = "0xC23D10", Offset = "0xC23D10", VA = "0xC23D10")]
		public static extern RESULT FMOD5_DSP_GetMeteringInfo(IntPtr dsp, IntPtr zero, out DSP_METERING_INFO outputInfo);

		[PreserveSig]
		[Token(Token = "0x6000385")]
		[Address(RVA = "0xC23DF4", Offset = "0xC23DF4", VA = "0xC23DF4")]
		public static extern RESULT FMOD5_DSP_GetMeteringInfo(IntPtr dsp, out DSP_METERING_INFO inputInfo, IntPtr zero);

		[PreserveSig]
		[Token(Token = "0x6000386")]
		[Address(RVA = "0xC23ED8", Offset = "0xC23ED8", VA = "0xC23ED8")]
		public static extern RESULT FMOD5_DSP_GetMeteringInfo(IntPtr dsp, out DSP_METERING_INFO inputInfo, out DSP_METERING_INFO outputInfo);

		[PreserveSig]
		[Token(Token = "0x6000387")]
		[Address(RVA = "0xC23FDC", Offset = "0xC23FDC", VA = "0xC23FDC")]
		public static extern RESULT FMOD5_DSP_GetCPUUsage(IntPtr dsp, out uint exclusive, out uint inclusive);

		[Token(Token = "0x6000388")]
		[Address(RVA = "0xC24074", Offset = "0xC24074", VA = "0xC24074")]
		public bool hasHandle()
		{
			return default(bool);
		}

		[Token(Token = "0x6000389")]
		[Address(RVA = "0xC240BC", Offset = "0xC240BC", VA = "0xC240BC")]
		public void clearHandle()
		{
		}
	}
	[Token(Token = "0x200004E")]
	public struct DSPConnection
	{
		[Token(Token = "0x4000244")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public IntPtr handle;

		[Token(Token = "0x600038A")]
		[Address(RVA = "0xC240FC", Offset = "0xC240FC", VA = "0xC240FC")]
		public RESULT getInput(out DSP input)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600038B")]
		[Address(RVA = "0xC24194", Offset = "0xC24194", VA = "0xC24194")]
		public RESULT getOutput(out DSP output)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600038C")]
		[Address(RVA = "0xC2422C", Offset = "0xC2422C", VA = "0xC2422C")]
		public RESULT setMix(float volume)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600038D")]
		[Address(RVA = "0xC242C4", Offset = "0xC242C4", VA = "0xC242C4")]
		public RESULT getMix(out float volume)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600038E")]
		[Address(RVA = "0xC2435C", Offset = "0xC2435C", VA = "0xC2435C")]
		public RESULT setMixMatrix(float[] matrix, int outchannels, int inchannels, int inchannel_hop = 0)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600038F")]
		[Address(RVA = "0xC2441C", Offset = "0xC2441C", VA = "0xC2441C")]
		public RESULT getMixMatrix(float[] matrix, out int outchannels, out int inchannels, int inchannel_hop = 0)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000390")]
		[Address(RVA = "0xC244DC", Offset = "0xC244DC", VA = "0xC244DC")]
		public RESULT getType(out DSPCONNECTION_TYPE type)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000391")]
		[Address(RVA = "0xC24574", Offset = "0xC24574", VA = "0xC24574")]
		public RESULT setUserData(IntPtr userdata)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000392")]
		[Address(RVA = "0xC2460C", Offset = "0xC2460C", VA = "0xC2460C")]
		public RESULT getUserData(out IntPtr userdata)
		{
			return default(RESULT);
		}

		[PreserveSig]
		[Token(Token = "0x6000393")]
		[Address(RVA = "0xC24104", Offset = "0xC24104", VA = "0xC24104")]
		private static extern RESULT FMOD5_DSPConnection_GetInput(IntPtr dspconnection, out IntPtr input);

		[PreserveSig]
		[Token(Token = "0x6000394")]
		[Address(RVA = "0xC2419C", Offset = "0xC2419C", VA = "0xC2419C")]
		private static extern RESULT FMOD5_DSPConnection_GetOutput(IntPtr dspconnection, out IntPtr output);

		[PreserveSig]
		[Token(Token = "0x6000395")]
		[Address(RVA = "0xC24234", Offset = "0xC24234", VA = "0xC24234")]
		private static extern RESULT FMOD5_DSPConnection_SetMix(IntPtr dspconnection, float volume);

		[PreserveSig]
		[Token(Token = "0x6000396")]
		[Address(RVA = "0xC242CC", Offset = "0xC242CC", VA = "0xC242CC")]
		private static extern RESULT FMOD5_DSPConnection_GetMix(IntPtr dspconnection, out float volume);

		[PreserveSig]
		[Token(Token = "0x6000397")]
		[Address(RVA = "0xC24364", Offset = "0xC24364", VA = "0xC24364")]
		private static extern RESULT FMOD5_DSPConnection_SetMixMatrix(IntPtr dspconnection, float[] matrix, int outchannels, int inchannels, int inchannel_hop);

		[PreserveSig]
		[Token(Token = "0x6000398")]
		[Address(RVA = "0xC24424", Offset = "0xC24424", VA = "0xC24424")]
		private static extern RESULT FMOD5_DSPConnection_GetMixMatrix(IntPtr dspconnection, float[] matrix, out int outchannels, out int inchannels, int inchannel_hop);

		[PreserveSig]
		[Token(Token = "0x6000399")]
		[Address(RVA = "0xC244E4", Offset = "0xC244E4", VA = "0xC244E4")]
		private static extern RESULT FMOD5_DSPConnection_GetType(IntPtr dspconnection, out DSPCONNECTION_TYPE type);

		[PreserveSig]
		[Token(Token = "0x600039A")]
		[Address(RVA = "0xC2457C", Offset = "0xC2457C", VA = "0xC2457C")]
		private static extern RESULT FMOD5_DSPConnection_SetUserData(IntPtr dspconnection, IntPtr userdata);

		[PreserveSig]
		[Token(Token = "0x600039B")]
		[Address(RVA = "0xC24614", Offset = "0xC24614", VA = "0xC24614")]
		private static extern RESULT FMOD5_DSPConnection_GetUserData(IntPtr dspconnection, out IntPtr userdata);

		[Token(Token = "0x600039C")]
		[Address(RVA = "0xC246A4", Offset = "0xC246A4", VA = "0xC246A4")]
		public bool hasHandle()
		{
			return default(bool);
		}

		[Token(Token = "0x600039D")]
		[Address(RVA = "0xC246EC", Offset = "0xC246EC", VA = "0xC246EC")]
		public void clearHandle()
		{
		}
	}
	[Token(Token = "0x200004F")]
	public struct Geometry
	{
		[Token(Token = "0x4000245")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public IntPtr handle;

		[Token(Token = "0x600039E")]
		[Address(RVA = "0xC3528C", Offset = "0xC3528C", VA = "0xC3528C")]
		public RESULT release()
		{
			return default(RESULT);
		}

		[Token(Token = "0x600039F")]
		[Address(RVA = "0xC35314", Offset = "0xC35314", VA = "0xC35314")]
		public RESULT addPolygon(float directocclusion, float reverbocclusion, bool doublesided, int numvertices, VECTOR[] vertices, out int polygonindex)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60003A0")]
		[Address(RVA = "0xC353F0", Offset = "0xC353F0", VA = "0xC353F0")]
		public RESULT getNumPolygons(out int numpolygons)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60003A1")]
		[Address(RVA = "0xC35488", Offset = "0xC35488", VA = "0xC35488")]
		public RESULT getMaxPolygons(out int maxpolygons, out int maxvertices)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60003A2")]
		[Address(RVA = "0xC35528", Offset = "0xC35528", VA = "0xC35528")]
		public RESULT getPolygonNumVertices(int index, out int numvertices)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60003A3")]
		[Address(RVA = "0xC355C8", Offset = "0xC355C8", VA = "0xC355C8")]
		public RESULT setPolygonVertex(int index, int vertexindex, ref VECTOR vertex)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60003A4")]
		[Address(RVA = "0xC35678", Offset = "0xC35678", VA = "0xC35678")]
		public RESULT getPolygonVertex(int index, int vertexindex, out VECTOR vertex)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60003A5")]
		[Address(RVA = "0xC35728", Offset = "0xC35728", VA = "0xC35728")]
		public RESULT setPolygonAttributes(int index, float directocclusion, float reverbocclusion, bool doublesided)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60003A6")]
		[Address(RVA = "0xC357E4", Offset = "0xC357E4", VA = "0xC357E4")]
		public RESULT getPolygonAttributes(int index, out float directocclusion, out float reverbocclusion, out bool doublesided)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60003A7")]
		[Address(RVA = "0xC358B0", Offset = "0xC358B0", VA = "0xC358B0")]
		public RESULT setActive(bool active)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60003A8")]
		[Address(RVA = "0xC3594C", Offset = "0xC3594C", VA = "0xC3594C")]
		public RESULT getActive(out bool active)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60003A9")]
		[Address(RVA = "0xC359F8", Offset = "0xC359F8", VA = "0xC359F8")]
		public RESULT setRotation(ref VECTOR forward, ref VECTOR up)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60003AA")]
		[Address(RVA = "0xC35A98", Offset = "0xC35A98", VA = "0xC35A98")]
		public RESULT getRotation(out VECTOR forward, out VECTOR up)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60003AB")]
		[Address(RVA = "0xC35B38", Offset = "0xC35B38", VA = "0xC35B38")]
		public RESULT setPosition(ref VECTOR position)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60003AC")]
		[Address(RVA = "0xC35BD0", Offset = "0xC35BD0", VA = "0xC35BD0")]
		public RESULT getPosition(out VECTOR position)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60003AD")]
		[Address(RVA = "0xC35C68", Offset = "0xC35C68", VA = "0xC35C68")]
		public RESULT setScale(ref VECTOR scale)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60003AE")]
		[Address(RVA = "0xC35D00", Offset = "0xC35D00", VA = "0xC35D00")]
		public RESULT getScale(out VECTOR scale)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60003AF")]
		[Address(RVA = "0xC35D98", Offset = "0xC35D98", VA = "0xC35D98")]
		public RESULT save(IntPtr data, out int datasize)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60003B0")]
		[Address(RVA = "0xC35E38", Offset = "0xC35E38", VA = "0xC35E38")]
		public RESULT setUserData(IntPtr userdata)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60003B1")]
		[Address(RVA = "0xC35ED0", Offset = "0xC35ED0", VA = "0xC35ED0")]
		public RESULT getUserData(out IntPtr userdata)
		{
			return default(RESULT);
		}

		[PreserveSig]
		[Token(Token = "0x60003B2")]
		[Address(RVA = "0xC35294", Offset = "0xC35294", VA = "0xC35294")]
		private static extern RESULT FMOD5_Geometry_Release(IntPtr geometry);

		[PreserveSig]
		[Token(Token = "0x60003B3")]
		[Address(RVA = "0xC35320", Offset = "0xC35320", VA = "0xC35320")]
		private static extern RESULT FMOD5_Geometry_AddPolygon(IntPtr geometry, float directocclusion, float reverbocclusion, bool doublesided, int numvertices, VECTOR[] vertices, out int polygonindex);

		[PreserveSig]
		[Token(Token = "0x60003B4")]
		[Address(RVA = "0xC353F8", Offset = "0xC353F8", VA = "0xC353F8")]
		private static extern RESULT FMOD5_Geometry_GetNumPolygons(IntPtr geometry, out int numpolygons);

		[PreserveSig]
		[Token(Token = "0x60003B5")]
		[Address(RVA = "0xC35490", Offset = "0xC35490", VA = "0xC35490")]
		private static extern RESULT FMOD5_Geometry_GetMaxPolygons(IntPtr geometry, out int maxpolygons, out int maxvertices);

		[PreserveSig]
		[Token(Token = "0x60003B6")]
		[Address(RVA = "0xC35530", Offset = "0xC35530", VA = "0xC35530")]
		private static extern RESULT FMOD5_Geometry_GetPolygonNumVertices(IntPtr geometry, int index, out int numvertices);

		[PreserveSig]
		[Token(Token = "0x60003B7")]
		[Address(RVA = "0xC355D0", Offset = "0xC355D0", VA = "0xC355D0")]
		private static extern RESULT FMOD5_Geometry_SetPolygonVertex(IntPtr geometry, int index, int vertexindex, ref VECTOR vertex);

		[PreserveSig]
		[Token(Token = "0x60003B8")]
		[Address(RVA = "0xC35680", Offset = "0xC35680", VA = "0xC35680")]
		private static extern RESULT FMOD5_Geometry_GetPolygonVertex(IntPtr geometry, int index, int vertexindex, out VECTOR vertex);

		[PreserveSig]
		[Token(Token = "0x60003B9")]
		[Address(RVA = "0xC35734", Offset = "0xC35734", VA = "0xC35734")]
		private static extern RESULT FMOD5_Geometry_SetPolygonAttributes(IntPtr geometry, int index, float directocclusion, float reverbocclusion, bool doublesided);

		[PreserveSig]
		[Token(Token = "0x60003BA")]
		[Address(RVA = "0xC357EC", Offset = "0xC357EC", VA = "0xC357EC")]
		private static extern RESULT FMOD5_Geometry_GetPolygonAttributes(IntPtr geometry, int index, out float directocclusion, out float reverbocclusion, out bool doublesided);

		[PreserveSig]
		[Token(Token = "0x60003BB")]
		[Address(RVA = "0xC358BC", Offset = "0xC358BC", VA = "0xC358BC")]
		private static extern RESULT FMOD5_Geometry_SetActive(IntPtr geometry, bool active);

		[PreserveSig]
		[Token(Token = "0x60003BC")]
		[Address(RVA = "0xC35954", Offset = "0xC35954", VA = "0xC35954")]
		private static extern RESULT FMOD5_Geometry_GetActive(IntPtr geometry, out bool active);

		[PreserveSig]
		[Token(Token = "0x60003BD")]
		[Address(RVA = "0xC35A00", Offset = "0xC35A00", VA = "0xC35A00")]
		private static extern RESULT FMOD5_Geometry_SetRotation(IntPtr geometry, ref VECTOR forward, ref VECTOR up);

		[PreserveSig]
		[Token(Token = "0x60003BE")]
		[Address(RVA = "0xC35AA0", Offset = "0xC35AA0", VA = "0xC35AA0")]
		private static extern RESULT FMOD5_Geometry_GetRotation(IntPtr geometry, out VECTOR forward, out VECTOR up);

		[PreserveSig]
		[Token(Token = "0x60003BF")]
		[Address(RVA = "0xC35B40", Offset = "0xC35B40", VA = "0xC35B40")]
		private static extern RESULT FMOD5_Geometry_SetPosition(IntPtr geometry, ref VECTOR position);

		[PreserveSig]
		[Token(Token = "0x60003C0")]
		[Address(RVA = "0xC35BD8", Offset = "0xC35BD8", VA = "0xC35BD8")]
		private static extern RESULT FMOD5_Geometry_GetPosition(IntPtr geometry, out VECTOR position);

		[PreserveSig]
		[Token(Token = "0x60003C1")]
		[Address(RVA = "0xC35C70", Offset = "0xC35C70", VA = "0xC35C70")]
		private static extern RESULT FMOD5_Geometry_SetScale(IntPtr geometry, ref VECTOR scale);

		[PreserveSig]
		[Token(Token = "0x60003C2")]
		[Address(RVA = "0xC35D08", Offset = "0xC35D08", VA = "0xC35D08")]
		private static extern RESULT FMOD5_Geometry_GetScale(IntPtr geometry, out VECTOR scale);

		[PreserveSig]
		[Token(Token = "0x60003C3")]
		[Address(RVA = "0xC35DA0", Offset = "0xC35DA0", VA = "0xC35DA0")]
		private static extern RESULT FMOD5_Geometry_Save(IntPtr geometry, IntPtr data, out int datasize);

		[PreserveSig]
		[Token(Token = "0x60003C4")]
		[Address(RVA = "0xC35E40", Offset = "0xC35E40", VA = "0xC35E40")]
		private static extern RESULT FMOD5_Geometry_SetUserData(IntPtr geometry, IntPtr userdata);

		[PreserveSig]
		[Token(Token = "0x60003C5")]
		[Address(RVA = "0xC35ED8", Offset = "0xC35ED8", VA = "0xC35ED8")]
		private static extern RESULT FMOD5_Geometry_GetUserData(IntPtr geometry, out IntPtr userdata);

		[Token(Token = "0x60003C6")]
		[Address(RVA = "0xC35F68", Offset = "0xC35F68", VA = "0xC35F68")]
		public bool hasHandle()
		{
			return default(bool);
		}

		[Token(Token = "0x60003C7")]
		[Address(RVA = "0xC35FB0", Offset = "0xC35FB0", VA = "0xC35FB0")]
		public void clearHandle()
		{
		}
	}
	[Token(Token = "0x2000050")]
	public struct Reverb3D
	{
		[Token(Token = "0x4000246")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public IntPtr handle;

		[Token(Token = "0x60003C8")]
		[Address(RVA = "0xC37094", Offset = "0xC37094", VA = "0xC37094")]
		public RESULT release()
		{
			return default(RESULT);
		}

		[Token(Token = "0x60003C9")]
		[Address(RVA = "0xC3711C", Offset = "0xC3711C", VA = "0xC3711C")]
		public RESULT set3DAttributes(ref VECTOR position, float mindistance, float maxdistance)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60003CA")]
		[Address(RVA = "0xC371CC", Offset = "0xC371CC", VA = "0xC371CC")]
		public RESULT get3DAttributes(ref VECTOR position, ref float mindistance, ref float maxdistance)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60003CB")]
		[Address(RVA = "0xC3727C", Offset = "0xC3727C", VA = "0xC3727C")]
		public RESULT setProperties(ref REVERB_PROPERTIES properties)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60003CC")]
		[Address(RVA = "0xC37314", Offset = "0xC37314", VA = "0xC37314")]
		public RESULT getProperties(ref REVERB_PROPERTIES properties)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60003CD")]
		[Address(RVA = "0xC373AC", Offset = "0xC373AC", VA = "0xC373AC")]
		public RESULT setActive(bool active)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60003CE")]
		[Address(RVA = "0xC37448", Offset = "0xC37448", VA = "0xC37448")]
		public RESULT getActive(out bool active)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60003CF")]
		[Address(RVA = "0xC374F4", Offset = "0xC374F4", VA = "0xC374F4")]
		public RESULT setUserData(IntPtr userdata)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60003D0")]
		[Address(RVA = "0xC3758C", Offset = "0xC3758C", VA = "0xC3758C")]
		public RESULT getUserData(out IntPtr userdata)
		{
			return default(RESULT);
		}

		[PreserveSig]
		[Token(Token = "0x60003D1")]
		[Address(RVA = "0xC3709C", Offset = "0xC3709C", VA = "0xC3709C")]
		private static extern RESULT FMOD5_Reverb3D_Release(IntPtr reverb3d);

		[PreserveSig]
		[Token(Token = "0x60003D2")]
		[Address(RVA = "0xC37124", Offset = "0xC37124", VA = "0xC37124")]
		private static extern RESULT FMOD5_Reverb3D_Set3DAttributes(IntPtr reverb3d, ref VECTOR position, float mindistance, float maxdistance);

		[PreserveSig]
		[Token(Token = "0x60003D3")]
		[Address(RVA = "0xC371D4", Offset = "0xC371D4", VA = "0xC371D4")]
		private static extern RESULT FMOD5_Reverb3D_Get3DAttributes(IntPtr reverb3d, ref VECTOR position, ref float mindistance, ref float maxdistance);

		[PreserveSig]
		[Token(Token = "0x60003D4")]
		[Address(RVA = "0xC37284", Offset = "0xC37284", VA = "0xC37284")]
		private static extern RESULT FMOD5_Reverb3D_SetProperties(IntPtr reverb3d, ref REVERB_PROPERTIES properties);

		[PreserveSig]
		[Token(Token = "0x60003D5")]
		[Address(RVA = "0xC3731C", Offset = "0xC3731C", VA = "0xC3731C")]
		private static extern RESULT FMOD5_Reverb3D_GetProperties(IntPtr reverb3d, ref REVERB_PROPERTIES properties);

		[PreserveSig]
		[Token(Token = "0x60003D6")]
		[Address(RVA = "0xC373B8", Offset = "0xC373B8", VA = "0xC373B8")]
		private static extern RESULT FMOD5_Reverb3D_SetActive(IntPtr reverb3d, bool active);

		[PreserveSig]
		[Token(Token = "0x60003D7")]
		[Address(RVA = "0xC37450", Offset = "0xC37450", VA = "0xC37450")]
		private static extern RESULT FMOD5_Reverb3D_GetActive(IntPtr reverb3d, out bool active);

		[PreserveSig]
		[Token(Token = "0x60003D8")]
		[Address(RVA = "0xC374FC", Offset = "0xC374FC", VA = "0xC374FC")]
		private static extern RESULT FMOD5_Reverb3D_SetUserData(IntPtr reverb3d, IntPtr userdata);

		[PreserveSig]
		[Token(Token = "0x60003D9")]
		[Address(RVA = "0xC37594", Offset = "0xC37594", VA = "0xC37594")]
		private static extern RESULT FMOD5_Reverb3D_GetUserData(IntPtr reverb3d, out IntPtr userdata);

		[Token(Token = "0x60003DA")]
		[Address(RVA = "0xC37624", Offset = "0xC37624", VA = "0xC37624")]
		public bool hasHandle()
		{
			return default(bool);
		}

		[Token(Token = "0x60003DB")]
		[Address(RVA = "0xC3766C", Offset = "0xC3766C", VA = "0xC3766C")]
		public void clearHandle()
		{
		}
	}
	[Token(Token = "0x2000051")]
	public struct StringWrapper
	{
		[Token(Token = "0x4000247")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private IntPtr nativeUtf8Ptr;

		[Token(Token = "0x60003DC")]
		[Address(RVA = "0x1E3E968", Offset = "0x1E3E968", VA = "0x1E3E968")]
		public static implicit operator string(StringWrapper fstring)
		{
			return null;
		}
	}
	[Token(Token = "0x2000052")]
	internal static class StringHelper
	{
		[Token(Token = "0x2000053")]
		public class ThreadSafeEncoding : IDisposable
		{
			[Token(Token = "0x4000249")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private UTF8Encoding encoding;

			[Token(Token = "0x400024A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private byte[] encodedBuffer;

			[Token(Token = "0x400024B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private char[] decodedBuffer;

			[Token(Token = "0x400024C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private bool inUse;

			[Token(Token = "0x400024D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			private GCHandle gcHandle;

			[Token(Token = "0x60003DF")]
			[Address(RVA = "0x1E4AA58", Offset = "0x1E4AA58", VA = "0x1E4AA58")]
			public bool InUse()
			{
				return default(bool);
			}

			[Token(Token = "0x60003E0")]
			[Address(RVA = "0x1E3E8D0", Offset = "0x1E3E8D0", VA = "0x1E3E8D0")]
			public void SetInUse()
			{
			}

			[Token(Token = "0x60003E1")]
			[Address(RVA = "0x1E4AA60", Offset = "0x1E4AA60", VA = "0x1E4AA60")]
			private int roundUpPowerTwo(int number)
			{
				return default(int);
			}

			[Token(Token = "0x60003E2")]
			[Address(RVA = "0x1E3C61C", Offset = "0x1E3C61C", VA = "0x1E3C61C")]
			public byte[] byteFromStringUTF8(string s)
			{
				return null;
			}

			[Token(Token = "0x60003E3")]
			[Address(RVA = "0x1E45F48", Offset = "0x1E45F48", VA = "0x1E45F48")]
			public IntPtr intptrFromStringUTF8(string s)
			{
				return default(IntPtr);
			}

			[Token(Token = "0x60003E4")]
			[Address(RVA = "0x1E3BFB4", Offset = "0x1E3BFB4", VA = "0x1E3BFB4")]
			public string stringFromNative(IntPtr nativePtr)
			{
				return null;
			}

			[Token(Token = "0x60003E5")]
			[Address(RVA = "0x1E4AA78", Offset = "0x1E4AA78", VA = "0x1E4AA78", Slot = "4")]
			public void Dispose()
			{
			}

			[Token(Token = "0x60003E6")]
			[Address(RVA = "0x1E3E824", Offset = "0x1E3E824", VA = "0x1E3E824")]
			public ThreadSafeEncoding()
			{
			}
		}

		[Token(Token = "0x4000248")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static List<ThreadSafeEncoding> encoders;

		[Token(Token = "0x60003DD")]
		[Address(RVA = "0x1E3BCE8", Offset = "0x1E3BCE8", VA = "0x1E3BCE8")]
		public static ThreadSafeEncoding GetFreeHelper()
		{
			return null;
		}
	}
	[Token(Token = "0x2000054")]
	internal static class Android
	{
		[Token(Token = "0x2000055")]
		public struct THREADAFFINITY
		{
			[Token(Token = "0x400024E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public THREAD mixer;

			[Token(Token = "0x400024F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public THREAD stream;

			[Token(Token = "0x4000250")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public THREAD nonblocking;

			[Token(Token = "0x4000251")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public THREAD file;

			[Token(Token = "0x4000252")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public THREAD geometry;

			[Token(Token = "0x4000253")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public THREAD profiler;

			[Token(Token = "0x4000254")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public THREAD studioUpdate;

			[Token(Token = "0x4000255")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public THREAD studioLoadBank;

			[Token(Token = "0x4000256")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public THREAD studioLoadSample;
		}

		[Token(Token = "0x2000056")]
		[Flags]
		public enum THREAD : uint
		{
			[Token(Token = "0x4000258")]
			DEFAULT = 0u,
			[Token(Token = "0x4000259")]
			CORE0 = 1u,
			[Token(Token = "0x400025A")]
			CORE1 = 2u,
			[Token(Token = "0x400025B")]
			CORE2 = 4u,
			[Token(Token = "0x400025C")]
			CORE3 = 8u,
			[Token(Token = "0x400025D")]
			CORE4 = 0x10u,
			[Token(Token = "0x400025E")]
			CORE5 = 0x20u,
			[Token(Token = "0x400025F")]
			CORE6 = 0x40u,
			[Token(Token = "0x4000260")]
			CORE7 = 0x80u
		}

		[Token(Token = "0x60003E7")]
		[Address(RVA = "0xC168AC", Offset = "0xC168AC", VA = "0xC168AC")]
		public static RESULT setThreadAffinity(ref THREADAFFINITY affinity)
		{
			return default(RESULT);
		}

		[PreserveSig]
		[Token(Token = "0x60003E8")]
		[Address(RVA = "0xC168B0", Offset = "0xC168B0", VA = "0xC168B0")]
		private static extern RESULT FMOD_Android_SetThreadAffinity(ref THREADAFFINITY affinity);
	}
	[Token(Token = "0x2000057")]
	public struct DSP_BUFFER_ARRAY
	{
		[Token(Token = "0x4000261")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int numbuffers;

		[Token(Token = "0x4000262")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public int[] buffernumchannels;

		[Token(Token = "0x4000263")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public CHANNELMASK[] bufferchannelmask;

		[Token(Token = "0x4000264")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public IntPtr[] buffers;

		[Token(Token = "0x4000265")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public SPEAKERMODE speakermode;
	}
	[Token(Token = "0x2000058")]
	public enum DSP_PROCESS_OPERATION
	{
		[Token(Token = "0x4000267")]
		PROCESS_PERFORM,
		[Token(Token = "0x4000268")]
		PROCESS_QUERY
	}
	[Token(Token = "0x2000059")]
	public struct COMPLEX
	{
		[Token(Token = "0x4000269")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float real;

		[Token(Token = "0x400026A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public float imag;
	}
	[Token(Token = "0x200005A")]
	public enum DSP_PAN_SURROUND_FLAGS
	{
		[Token(Token = "0x400026C")]
		DEFAULT,
		[Token(Token = "0x400026D")]
		ROTATION_NOT_BIASED
	}
	[Token(Token = "0x200005B")]
	public delegate RESULT DSP_CREATECALLBACK(ref DSP_STATE dsp_state);
	[Token(Token = "0x200005C")]
	public delegate RESULT DSP_RELEASECALLBACK(ref DSP_STATE dsp_state);
	[Token(Token = "0x200005D")]
	public delegate RESULT DSP_RESETCALLBACK(ref DSP_STATE dsp_state);
	[Token(Token = "0x200005E")]
	public delegate RESULT DSP_SETPOSITIONCALLBACK(ref DSP_STATE dsp_state, uint pos);
	[Token(Token = "0x200005F")]
	public delegate RESULT DSP_READCALLBACK(ref DSP_STATE dsp_state, IntPtr inbuffer, IntPtr outbuffer, uint length, int inchannels, ref int outchannels);
	[Token(Token = "0x2000060")]
	public delegate RESULT DSP_SHOULDIPROCESS_CALLBACK(ref DSP_STATE dsp_state, bool inputsidle, uint length, CHANNELMASK inmask, int inchannels, SPEAKERMODE speakermode);
	[Token(Token = "0x2000061")]
	public delegate RESULT DSP_PROCESS_CALLBACK(ref DSP_STATE dsp_state, uint length, ref DSP_BUFFER_ARRAY inbufferarray, ref DSP_BUFFER_ARRAY outbufferarray, bool inputsidle, DSP_PROCESS_OPERATION op);
	[Token(Token = "0x2000062")]
	public delegate RESULT DSP_SETPARAM_FLOAT_CALLBACK(ref DSP_STATE dsp_state, int index, float value);
	[Token(Token = "0x2000063")]
	public delegate RESULT DSP_SETPARAM_INT_CALLBACK(ref DSP_STATE dsp_state, int index, int value);
	[Token(Token = "0x2000064")]
	public delegate RESULT DSP_SETPARAM_BOOL_CALLBACK(ref DSP_STATE dsp_state, int index, bool value);
	[Token(Token = "0x2000065")]
	public delegate RESULT DSP_SETPARAM_DATA_CALLBACK(ref DSP_STATE dsp_state, int index, IntPtr data, uint length);
	[Token(Token = "0x2000066")]
	public delegate RESULT DSP_GETPARAM_FLOAT_CALLBACK(ref DSP_STATE dsp_state, int index, ref float value, IntPtr valuestr);
	[Token(Token = "0x2000067")]
	public delegate RESULT DSP_GETPARAM_INT_CALLBACK(ref DSP_STATE dsp_state, int index, ref int value, IntPtr valuestr);
	[Token(Token = "0x2000068")]
	public delegate RESULT DSP_GETPARAM_BOOL_CALLBACK(ref DSP_STATE dsp_state, int index, ref bool value, IntPtr valuestr);
	[Token(Token = "0x2000069")]
	public delegate RESULT DSP_GETPARAM_DATA_CALLBACK(ref DSP_STATE dsp_state, int index, ref IntPtr data, ref uint length, IntPtr valuestr);
	[Token(Token = "0x200006A")]
	public delegate RESULT DSP_SYSTEM_REGISTER_CALLBACK(ref DSP_STATE dsp_state);
	[Token(Token = "0x200006B")]
	public delegate RESULT DSP_SYSTEM_DEREGISTER_CALLBACK(ref DSP_STATE dsp_state);
	[Token(Token = "0x200006C")]
	public delegate RESULT DSP_SYSTEM_MIX_CALLBACK(ref DSP_STATE dsp_state, int stage);
	[Token(Token = "0x200006D")]
	public delegate IntPtr DSP_ALLOC_FUNC(uint size, MEMORY_TYPE type, StringWrapper sourcestr);
	[Token(Token = "0x200006E")]
	public delegate IntPtr DSP_REALLOC_FUNC(IntPtr ptr, uint size, MEMORY_TYPE type, StringWrapper sourcestr);
	[Token(Token = "0x200006F")]
	public delegate void DSP_FREE_FUNC(IntPtr ptr, MEMORY_TYPE type, StringWrapper sourcestr);
	[Token(Token = "0x2000070")]
	public delegate void DSP_LOG_FUNC(DEBUG_FLAGS level, StringWrapper file, int line, StringWrapper function, StringWrapper format);
	[Token(Token = "0x2000071")]
	public delegate RESULT DSP_GETSAMPLERATE_FUNC(ref DSP_STATE dsp_state, ref int rate);
	[Token(Token = "0x2000072")]
	public delegate RESULT DSP_GETBLOCKSIZE_FUNC(ref DSP_STATE dsp_state, ref uint blocksize);
	[Token(Token = "0x2000073")]
	public delegate RESULT DSP_GETSPEAKERMODE_FUNC(ref DSP_STATE dsp_state, ref int speakermode_mixer, ref int speakermode_output);
	[Token(Token = "0x2000074")]
	public delegate RESULT DSP_GETCLOCK_FUNC(ref DSP_STATE dsp_state, out ulong clock, out uint offset, out uint length);
	[Token(Token = "0x2000075")]
	public delegate RESULT DSP_GETLISTENERATTRIBUTES_FUNC(ref DSP_STATE dsp_state, ref int numlisteners, IntPtr attributes);
	[Token(Token = "0x2000076")]
	public delegate RESULT DSP_GETUSERDATA_FUNC(ref DSP_STATE dsp_state, out IntPtr userdata);
	[Token(Token = "0x2000077")]
	public delegate RESULT DSP_DFT_FFTREAL_FUNC(ref DSP_STATE dsp_state, int size, IntPtr signal, IntPtr dft, IntPtr window, int signalhop);
	[Token(Token = "0x2000078")]
	public delegate RESULT DSP_DFT_IFFTREAL_FUNC(ref DSP_STATE dsp_state, int size, IntPtr dft, IntPtr signal, IntPtr window, int signalhop);
	[Token(Token = "0x2000079")]
	public delegate RESULT DSP_PAN_SUMMONOMATRIX_FUNC(ref DSP_STATE dsp_state, int sourceSpeakerMode, float lowFrequencyGain, float overallGain, IntPtr matrix);
	[Token(Token = "0x200007A")]
	public delegate RESULT DSP_PAN_SUMSTEREOMATRIX_FUNC(ref DSP_STATE dsp_state, int sourceSpeakerMode, float pan, float lowFrequencyGain, float overallGain, int matrixHop, IntPtr matrix);
	[Token(Token = "0x200007B")]
	public delegate RESULT DSP_PAN_SUMSURROUNDMATRIX_FUNC(ref DSP_STATE dsp_state, int sourceSpeakerMode, int targetSpeakerMode, float direction, float extent, float rotation, float lowFrequencyGain, float overallGain, int matrixHop, IntPtr matrix, DSP_PAN_SURROUND_FLAGS flags);
	[Token(Token = "0x200007C")]
	public delegate RESULT DSP_PAN_SUMMONOTOSURROUNDMATRIX_FUNC(ref DSP_STATE dsp_state, int targetSpeakerMode, float direction, float extent, float lowFrequencyGain, float overallGain, int matrixHop, IntPtr matrix);
	[Token(Token = "0x200007D")]
	public delegate RESULT DSP_PAN_SUMSTEREOTOSURROUNDMATRIX_FUNC(ref DSP_STATE dsp_state, int targetSpeakerMode, float direction, float extent, float rotation, float lowFrequencyGain, float overallGain, int matrixHop, IntPtr matrix);
	[Token(Token = "0x200007E")]
	public delegate RESULT DSP_PAN_GETROLLOFFGAIN_FUNC(ref DSP_STATE dsp_state, DSP_PAN_3D_ROLLOFF_TYPE rolloff, float distance, float mindistance, float maxdistance, out float gain);
	[Token(Token = "0x200007F")]
	public enum DSP_TYPE
	{
		[Token(Token = "0x400026F")]
		UNKNOWN,
		[Token(Token = "0x4000270")]
		MIXER,
		[Token(Token = "0x4000271")]
		OSCILLATOR,
		[Token(Token = "0x4000272")]
		LOWPASS,
		[Token(Token = "0x4000273")]
		ITLOWPASS,
		[Token(Token = "0x4000274")]
		HIGHPASS,
		[Token(Token = "0x4000275")]
		ECHO,
		[Token(Token = "0x4000276")]
		FADER,
		[Token(Token = "0x4000277")]
		FLANGE,
		[Token(Token = "0x4000278")]
		DISTORTION,
		[Token(Token = "0x4000279")]
		NORMALIZE,
		[Token(Token = "0x400027A")]
		LIMITER,
		[Token(Token = "0x400027B")]
		PARAMEQ,
		[Token(Token = "0x400027C")]
		PITCHSHIFT,
		[Token(Token = "0x400027D")]
		CHORUS,
		[Token(Token = "0x400027E")]
		VSTPLUGIN,
		[Token(Token = "0x400027F")]
		WINAMPPLUGIN,
		[Token(Token = "0x4000280")]
		ITECHO,
		[Token(Token = "0x4000281")]
		COMPRESSOR,
		[Token(Token = "0x4000282")]
		SFXREVERB,
		[Token(Token = "0x4000283")]
		LOWPASS_SIMPLE,
		[Token(Token = "0x4000284")]
		DELAY,
		[Token(Token = "0x4000285")]
		TREMOLO,
		[Token(Token = "0x4000286")]
		LADSPAPLUGIN,
		[Token(Token = "0x4000287")]
		SEND,
		[Token(Token = "0x4000288")]
		RETURN,
		[Token(Token = "0x4000289")]
		HIGHPASS_SIMPLE,
		[Token(Token = "0x400028A")]
		PAN,
		[Token(Token = "0x400028B")]
		THREE_EQ,
		[Token(Token = "0x400028C")]
		FFT,
		[Token(Token = "0x400028D")]
		LOUDNESS_METER,
		[Token(Token = "0x400028E")]
		ENVELOPEFOLLOWER,
		[Token(Token = "0x400028F")]
		CONVOLUTIONREVERB,
		[Token(Token = "0x4000290")]
		CHANNELMIX,
		[Token(Token = "0x4000291")]
		TRANSCEIVER,
		[Token(Token = "0x4000292")]
		OBJECTPAN,
		[Token(Token = "0x4000293")]
		MULTIBAND_EQ,
		[Token(Token = "0x4000294")]
		MAX
	}
	[Token(Token = "0x2000080")]
	public enum DSP_PARAMETER_TYPE
	{
		[Token(Token = "0x4000296")]
		FLOAT,
		[Token(Token = "0x4000297")]
		INT,
		[Token(Token = "0x4000298")]
		BOOL,
		[Token(Token = "0x4000299")]
		DATA,
		[Token(Token = "0x400029A")]
		MAX
	}
	[Token(Token = "0x2000081")]
	public enum DSP_PARAMETER_FLOAT_MAPPING_TYPE
	{
		[Token(Token = "0x400029C")]
		DSP_PARAMETER_FLOAT_MAPPING_TYPE_LINEAR,
		[Token(Token = "0x400029D")]
		DSP_PARAMETER_FLOAT_MAPPING_TYPE_AUTO,
		[Token(Token = "0x400029E")]
		DSP_PARAMETER_FLOAT_MAPPING_TYPE_PIECEWISE_LINEAR
	}
	[Token(Token = "0x2000082")]
	public struct DSP_PARAMETER_FLOAT_MAPPING_PIECEWISE_LINEAR
	{
		[Token(Token = "0x400029F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int numpoints;

		[Token(Token = "0x40002A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public IntPtr pointparamvalues;

		[Token(Token = "0x40002A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public IntPtr pointpositions;
	}
	[Token(Token = "0x2000083")]
	public struct DSP_PARAMETER_FLOAT_MAPPING
	{
		[Token(Token = "0x40002A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public DSP_PARAMETER_FLOAT_MAPPING_TYPE type;

		[Token(Token = "0x40002A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public DSP_PARAMETER_FLOAT_MAPPING_PIECEWISE_LINEAR piecewiselinearmapping;
	}
	[Token(Token = "0x2000084")]
	public struct DSP_PARAMETER_DESC_FLOAT
	{
		[Token(Token = "0x40002A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float min;

		[Token(Token = "0x40002A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public float max;

		[Token(Token = "0x40002A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public float defaultval;

		[Token(Token = "0x40002A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public DSP_PARAMETER_FLOAT_MAPPING mapping;
	}
	[Token(Token = "0x2000085")]
	public struct DSP_PARAMETER_DESC_INT
	{
		[Token(Token = "0x40002A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int min;

		[Token(Token = "0x40002A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public int max;

		[Token(Token = "0x40002AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public int defaultval;

		[Token(Token = "0x40002AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public bool goestoinf;

		[Token(Token = "0x40002AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public IntPtr valuenames;
	}
	[Token(Token = "0x2000086")]
	public struct DSP_PARAMETER_DESC_BOOL
	{
		[Token(Token = "0x40002AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public bool defaultval;

		[Token(Token = "0x40002AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public IntPtr valuenames;
	}
	[Token(Token = "0x2000087")]
	public struct DSP_PARAMETER_DESC_DATA
	{
		[Token(Token = "0x40002AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int datatype;
	}
	[StructLayout(2)]
	[Token(Token = "0x2000088")]
	public struct DSP_PARAMETER_DESC_UNION
	{
		[Token(Token = "0x40002B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public DSP_PARAMETER_DESC_FLOAT floatdesc;

		[Token(Token = "0x40002B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public DSP_PARAMETER_DESC_INT intdesc;

		[Token(Token = "0x40002B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public DSP_PARAMETER_DESC_BOOL booldesc;

		[Token(Token = "0x40002B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public DSP_PARAMETER_DESC_DATA datadesc;
	}
	[Token(Token = "0x2000089")]
	public struct DSP_PARAMETER_DESC
	{
		[Token(Token = "0x40002B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public DSP_PARAMETER_TYPE type;

		[Token(Token = "0x40002B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public byte[] name;

		[Token(Token = "0x40002B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public byte[] label;

		[Token(Token = "0x40002B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string description;

		[Token(Token = "0x40002B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public DSP_PARAMETER_DESC_UNION desc;
	}
	[Token(Token = "0x200008A")]
	public enum DSP_PARAMETER_DATA_TYPE
	{
		[Token(Token = "0x40002BA")]
		DSP_PARAMETER_DATA_TYPE_USER = 0,
		[Token(Token = "0x40002BB")]
		DSP_PARAMETER_DATA_TYPE_OVERALLGAIN = -1,
		[Token(Token = "0x40002BC")]
		DSP_PARAMETER_DATA_TYPE_3DATTRIBUTES = -2,
		[Token(Token = "0x40002BD")]
		DSP_PARAMETER_DATA_TYPE_SIDECHAIN = -3,
		[Token(Token = "0x40002BE")]
		DSP_PARAMETER_DATA_TYPE_FFT = -4,
		[Token(Token = "0x40002BF")]
		DSP_PARAMETER_DATA_TYPE_3DATTRIBUTES_MULTI = -5
	}
	[Token(Token = "0x200008B")]
	public struct DSP_PARAMETER_OVERALLGAIN
	{
		[Token(Token = "0x40002C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float linear_gain;

		[Token(Token = "0x40002C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public float linear_gain_additive;
	}
	[Token(Token = "0x200008C")]
	public struct DSP_PARAMETER_3DATTRIBUTES
	{
		[Token(Token = "0x40002C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public ATTRIBUTES_3D relative;

		[Token(Token = "0x40002C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public ATTRIBUTES_3D absolute;
	}
	[Token(Token = "0x200008D")]
	public struct DSP_PARAMETER_3DATTRIBUTES_MULTI
	{
		[Token(Token = "0x40002C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int numlisteners;

		[Token(Token = "0x40002C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public ATTRIBUTES_3D[] relative;

		[Token(Token = "0x40002C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float[] weight;

		[Token(Token = "0x40002C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public ATTRIBUTES_3D absolute;
	}
	[Token(Token = "0x200008E")]
	public struct DSP_PARAMETER_SIDECHAIN
	{
		[Token(Token = "0x40002C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int sidechainenable;
	}
	[Token(Token = "0x200008F")]
	public struct DSP_PARAMETER_FFT
	{
		[Token(Token = "0x40002C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int length;

		[Token(Token = "0x40002CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public int numchannels;

		[Token(Token = "0x40002CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private IntPtr[] spectrum_internal;

		[Token(Token = "0x17000006")]
		public float[][] spectrum
		{
			[Token(Token = "0x6000479")]
			[Address(RVA = "0xC29DC0", Offset = "0xC29DC0", VA = "0xC29DC0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600047A")]
		[Address(RVA = "0xC29F24", Offset = "0xC29F24", VA = "0xC29F24")]
		public void getSpectrum(ref float[][] buffer)
		{
		}

		[Token(Token = "0x600047B")]
		[Address(RVA = "0xC2A008", Offset = "0xC2A008", VA = "0xC2A008")]
		public void getSpectrum(int channel, ref float[] buffer)
		{
		}
	}
	[Token(Token = "0x2000090")]
	public struct DSP_DESCRIPTION
	{
		[Token(Token = "0x40002CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public uint pluginsdkversion;

		[Token(Token = "0x40002CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public char[] name;

		[Token(Token = "0x40002CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public uint version;

		[Token(Token = "0x40002CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public int numinputbuffers;

		[Token(Token = "0x40002D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int numoutputbuffers;

		[Token(Token = "0x40002D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public DSP_CREATECALLBACK create;

		[Token(Token = "0x40002D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public DSP_RELEASECALLBACK release;

		[Token(Token = "0x40002D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public DSP_RESETCALLBACK reset;

		[Token(Token = "0x40002D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public DSP_READCALLBACK read;

		[Token(Token = "0x40002D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public DSP_PROCESS_CALLBACK process;

		[Token(Token = "0x40002D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public DSP_SETPOSITIONCALLBACK setposition;

		[Token(Token = "0x40002D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public int numparameters;

		[Token(Token = "0x40002D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public IntPtr paramdesc;

		[Token(Token = "0x40002D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public DSP_SETPARAM_FLOAT_CALLBACK setparameterfloat;

		[Token(Token = "0x40002DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public DSP_SETPARAM_INT_CALLBACK setparameterint;

		[Token(Token = "0x40002DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public DSP_SETPARAM_BOOL_CALLBACK setparameterbool;

		[Token(Token = "0x40002DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public DSP_SETPARAM_DATA_CALLBACK setparameterdata;

		[Token(Token = "0x40002DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public DSP_GETPARAM_FLOAT_CALLBACK getparameterfloat;

		[Token(Token = "0x40002DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public DSP_GETPARAM_INT_CALLBACK getparameterint;

		[Token(Token = "0x40002DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public DSP_GETPARAM_BOOL_CALLBACK getparameterbool;

		[Token(Token = "0x40002E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public DSP_GETPARAM_DATA_CALLBACK getparameterdata;

		[Token(Token = "0x40002E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public DSP_SHOULDIPROCESS_CALLBACK shouldiprocess;

		[Token(Token = "0x40002E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public IntPtr userdata;

		[Token(Token = "0x40002E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public DSP_SYSTEM_REGISTER_CALLBACK sys_register;

		[Token(Token = "0x40002E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public DSP_SYSTEM_DEREGISTER_CALLBACK sys_deregister;

		[Token(Token = "0x40002E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public DSP_SYSTEM_MIX_CALLBACK sys_mix;
	}
	[Token(Token = "0x2000091")]
	public struct DSP_STATE_DFT_FUNCTIONS
	{
		[Token(Token = "0x40002E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public DSP_DFT_FFTREAL_FUNC fftreal;

		[Token(Token = "0x40002E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public DSP_DFT_IFFTREAL_FUNC inversefftreal;
	}
	[Token(Token = "0x2000092")]
	public struct DSP_STATE_PAN_FUNCTIONS
	{
		[Token(Token = "0x40002E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public DSP_PAN_SUMMONOMATRIX_FUNC summonomatrix;

		[Token(Token = "0x40002E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public DSP_PAN_SUMSTEREOMATRIX_FUNC sumstereomatrix;

		[Token(Token = "0x40002EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public DSP_PAN_SUMSURROUNDMATRIX_FUNC sumsurroundmatrix;

		[Token(Token = "0x40002EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public DSP_PAN_SUMMONOTOSURROUNDMATRIX_FUNC summonotosurroundmatrix;

		[Token(Token = "0x40002EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public DSP_PAN_SUMSTEREOTOSURROUNDMATRIX_FUNC sumstereotosurroundmatrix;

		[Token(Token = "0x40002ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public DSP_PAN_GETROLLOFFGAIN_FUNC getrolloffgain;
	}
	[Token(Token = "0x2000093")]
	public struct DSP_STATE_FUNCTIONS
	{
		[Token(Token = "0x40002EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public DSP_ALLOC_FUNC alloc;

		[Token(Token = "0x40002EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public DSP_REALLOC_FUNC realloc;

		[Token(Token = "0x40002F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public DSP_FREE_FUNC free;

		[Token(Token = "0x40002F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public DSP_GETSAMPLERATE_FUNC getsamplerate;

		[Token(Token = "0x40002F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public DSP_GETBLOCKSIZE_FUNC getblocksize;

		[Token(Token = "0x40002F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public IntPtr dft;

		[Token(Token = "0x40002F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public IntPtr pan;

		[Token(Token = "0x40002F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public DSP_GETSPEAKERMODE_FUNC getspeakermode;

		[Token(Token = "0x40002F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public DSP_GETCLOCK_FUNC getclock;

		[Token(Token = "0x40002F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public DSP_GETLISTENERATTRIBUTES_FUNC getlistenerattributes;

		[Token(Token = "0x40002F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public DSP_LOG_FUNC log;

		[Token(Token = "0x40002F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public DSP_GETUSERDATA_FUNC getuserdata;
	}
	[Token(Token = "0x2000094")]
	public struct DSP_STATE
	{
		[Token(Token = "0x40002FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public IntPtr instance;

		[Token(Token = "0x40002FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public IntPtr plugindata;

		[Token(Token = "0x40002FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public uint channelmask;

		[Token(Token = "0x40002FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public int source_speakermode;

		[Token(Token = "0x40002FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public IntPtr sidechaindata;

		[Token(Token = "0x40002FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public int sidechainchannels;

		[Token(Token = "0x4000300")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public IntPtr functions;

		[Token(Token = "0x4000301")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public int systemobject;
	}
	[Token(Token = "0x2000095")]
	public struct DSP_METERING_INFO
	{
		[Token(Token = "0x4000302")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int numsamples;

		[Token(Token = "0x4000303")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public float[] peaklevel;

		[Token(Token = "0x4000304")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float[] rmslevel;

		[Token(Token = "0x4000305")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public short numchannels;
	}
	[Token(Token = "0x2000096")]
	public enum DSP_OSCILLATOR
	{
		[Token(Token = "0x4000307")]
		TYPE,
		[Token(Token = "0x4000308")]
		RATE
	}
	[Token(Token = "0x2000097")]
	public enum DSP_LOWPASS
	{
		[Token(Token = "0x400030A")]
		CUTOFF,
		[Token(Token = "0x400030B")]
		RESONANCE
	}
	[Token(Token = "0x2000098")]
	public enum DSP_ITLOWPASS
	{
		[Token(Token = "0x400030D")]
		CUTOFF,
		[Token(Token = "0x400030E")]
		RESONANCE
	}
	[Token(Token = "0x2000099")]
	public enum DSP_HIGHPASS
	{
		[Token(Token = "0x4000310")]
		CUTOFF,
		[Token(Token = "0x4000311")]
		RESONANCE
	}
	[Token(Token = "0x200009A")]
	public enum DSP_ECHO
	{
		[Token(Token = "0x4000313")]
		DELAY,
		[Token(Token = "0x4000314")]
		FEEDBACK,
		[Token(Token = "0x4000315")]
		DRYLEVEL,
		[Token(Token = "0x4000316")]
		WETLEVEL
	}
	[Token(Token = "0x200009B")]
	public enum DSP_FADER
	{
		[Token(Token = "0x4000318")]
		GAIN,
		[Token(Token = "0x4000319")]
		OVERALL_GAIN
	}
	[Token(Token = "0x200009C")]
	public enum DSP_DELAY
	{
		[Token(Token = "0x400031B")]
		CH0,
		[Token(Token = "0x400031C")]
		CH1,
		[Token(Token = "0x400031D")]
		CH2,
		[Token(Token = "0x400031E")]
		CH3,
		[Token(Token = "0x400031F")]
		CH4,
		[Token(Token = "0x4000320")]
		CH5,
		[Token(Token = "0x4000321")]
		CH6,
		[Token(Token = "0x4000322")]
		CH7,
		[Token(Token = "0x4000323")]
		CH8,
		[Token(Token = "0x4000324")]
		CH9,
		[Token(Token = "0x4000325")]
		CH10,
		[Token(Token = "0x4000326")]
		CH11,
		[Token(Token = "0x4000327")]
		CH12,
		[Token(Token = "0x4000328")]
		CH13,
		[Token(Token = "0x4000329")]
		CH14,
		[Token(Token = "0x400032A")]
		CH15,
		[Token(Token = "0x400032B")]
		MAXDELAY
	}
	[Token(Token = "0x200009D")]
	public enum DSP_FLANGE
	{
		[Token(Token = "0x400032D")]
		MIX,
		[Token(Token = "0x400032E")]
		DEPTH,
		[Token(Token = "0x400032F")]
		RATE
	}
	[Token(Token = "0x200009E")]
	public enum DSP_TREMOLO
	{
		[Token(Token = "0x4000331")]
		FREQUENCY,
		[Token(Token = "0x4000332")]
		DEPTH,
		[Token(Token = "0x4000333")]
		SHAPE,
		[Token(Token = "0x4000334")]
		SKEW,
		[Token(Token = "0x4000335")]
		DUTY,
		[Token(Token = "0x4000336")]
		SQUARE,
		[Token(Token = "0x4000337")]
		PHASE,
		[Token(Token = "0x4000338")]
		SPREAD
	}
	[Token(Token = "0x200009F")]
	public enum DSP_DISTORTION
	{
		[Token(Token = "0x400033A")]
		LEVEL
	}
	[Token(Token = "0x20000A0")]
	public enum DSP_NORMALIZE
	{
		[Token(Token = "0x400033C")]
		FADETIME,
		[Token(Token = "0x400033D")]
		THRESHHOLD,
		[Token(Token = "0x400033E")]
		MAXAMP
	}
	[Token(Token = "0x20000A1")]
	public enum DSP_LIMITER
	{
		[Token(Token = "0x4000340")]
		RELEASETIME,
		[Token(Token = "0x4000341")]
		CEILING,
		[Token(Token = "0x4000342")]
		MAXIMIZERGAIN,
		[Token(Token = "0x4000343")]
		MODE
	}
	[Token(Token = "0x20000A2")]
	public enum DSP_PARAMEQ
	{
		[Token(Token = "0x4000345")]
		CENTER,
		[Token(Token = "0x4000346")]
		BANDWIDTH,
		[Token(Token = "0x4000347")]
		GAIN
	}
	[Token(Token = "0x20000A3")]
	public enum DSP_MULTIBAND_EQ
	{
		[Token(Token = "0x4000349")]
		A_FILTER,
		[Token(Token = "0x400034A")]
		A_FREQUENCY,
		[Token(Token = "0x400034B")]
		A_Q,
		[Token(Token = "0x400034C")]
		A_GAIN,
		[Token(Token = "0x400034D")]
		B_FILTER,
		[Token(Token = "0x400034E")]
		B_FREQUENCY,
		[Token(Token = "0x400034F")]
		B_Q,
		[Token(Token = "0x4000350")]
		B_GAIN,
		[Token(Token = "0x4000351")]
		C_FILTER,
		[Token(Token = "0x4000352")]
		C_FREQUENCY,
		[Token(Token = "0x4000353")]
		C_Q,
		[Token(Token = "0x4000354")]
		C_GAIN,
		[Token(Token = "0x4000355")]
		D_FILTER,
		[Token(Token = "0x4000356")]
		D_FREQUENCY,
		[Token(Token = "0x4000357")]
		D_Q,
		[Token(Token = "0x4000358")]
		D_GAIN,
		[Token(Token = "0x4000359")]
		E_FILTER,
		[Token(Token = "0x400035A")]
		E_FREQUENCY,
		[Token(Token = "0x400035B")]
		E_Q,
		[Token(Token = "0x400035C")]
		E_GAIN
	}
	[Token(Token = "0x20000A4")]
	public enum DSP_MULTIBAND_EQ_FILTER_TYPE
	{
		[Token(Token = "0x400035E")]
		DISABLED,
		[Token(Token = "0x400035F")]
		LOWPASS_12DB,
		[Token(Token = "0x4000360")]
		LOWPASS_24DB,
		[Token(Token = "0x4000361")]
		LOWPASS_48DB,
		[Token(Token = "0x4000362")]
		HIGHPASS_12DB,
		[Token(Token = "0x4000363")]
		HIGHPASS_24DB,
		[Token(Token = "0x4000364")]
		HIGHPASS_48DB,
		[Token(Token = "0x4000365")]
		LOWSHELF,
		[Token(Token = "0x4000366")]
		HIGHSHELF,
		[Token(Token = "0x4000367")]
		PEAKING,
		[Token(Token = "0x4000368")]
		BANDPASS,
		[Token(Token = "0x4000369")]
		NOTCH,
		[Token(Token = "0x400036A")]
		ALLPASS
	}
	[Token(Token = "0x20000A5")]
	public enum DSP_PITCHSHIFT
	{
		[Token(Token = "0x400036C")]
		PITCH,
		[Token(Token = "0x400036D")]
		FFTSIZE,
		[Token(Token = "0x400036E")]
		OVERLAP,
		[Token(Token = "0x400036F")]
		MAXCHANNELS
	}
	[Token(Token = "0x20000A6")]
	public enum DSP_CHORUS
	{
		[Token(Token = "0x4000371")]
		MIX,
		[Token(Token = "0x4000372")]
		RATE,
		[Token(Token = "0x4000373")]
		DEPTH
	}
	[Token(Token = "0x20000A7")]
	public enum DSP_ITECHO
	{
		[Token(Token = "0x4000375")]
		WETDRYMIX,
		[Token(Token = "0x4000376")]
		FEEDBACK,
		[Token(Token = "0x4000377")]
		LEFTDELAY,
		[Token(Token = "0x4000378")]
		RIGHTDELAY,
		[Token(Token = "0x4000379")]
		PANDELAY
	}
	[Token(Token = "0x20000A8")]
	public enum DSP_COMPRESSOR
	{
		[Token(Token = "0x400037B")]
		THRESHOLD,
		[Token(Token = "0x400037C")]
		RATIO,
		[Token(Token = "0x400037D")]
		ATTACK,
		[Token(Token = "0x400037E")]
		RELEASE,
		[Token(Token = "0x400037F")]
		GAINMAKEUP,
		[Token(Token = "0x4000380")]
		USESIDECHAIN,
		[Token(Token = "0x4000381")]
		LINKED
	}
	[Token(Token = "0x20000A9")]
	public enum DSP_SFXREVERB
	{
		[Token(Token = "0x4000383")]
		DECAYTIME,
		[Token(Token = "0x4000384")]
		EARLYDELAY,
		[Token(Token = "0x4000385")]
		LATEDELAY,
		[Token(Token = "0x4000386")]
		HFREFERENCE,
		[Token(Token = "0x4000387")]
		HFDECAYRATIO,
		[Token(Token = "0x4000388")]
		DIFFUSION,
		[Token(Token = "0x4000389")]
		DENSITY,
		[Token(Token = "0x400038A")]
		LOWSHELFFREQUENCY,
		[Token(Token = "0x400038B")]
		LOWSHELFGAIN,
		[Token(Token = "0x400038C")]
		HIGHCUT,
		[Token(Token = "0x400038D")]
		EARLYLATEMIX,
		[Token(Token = "0x400038E")]
		WETLEVEL,
		[Token(Token = "0x400038F")]
		DRYLEVEL
	}
	[Token(Token = "0x20000AA")]
	public enum DSP_LOWPASS_SIMPLE
	{
		[Token(Token = "0x4000391")]
		CUTOFF
	}
	[Token(Token = "0x20000AB")]
	public enum DSP_SEND
	{
		[Token(Token = "0x4000393")]
		RETURNID,
		[Token(Token = "0x4000394")]
		LEVEL
	}
	[Token(Token = "0x20000AC")]
	public enum DSP_RETURN
	{
		[Token(Token = "0x4000396")]
		ID,
		[Token(Token = "0x4000397")]
		INPUT_SPEAKER_MODE
	}
	[Token(Token = "0x20000AD")]
	public enum DSP_HIGHPASS_SIMPLE
	{
		[Token(Token = "0x4000399")]
		CUTOFF
	}
	[Token(Token = "0x20000AE")]
	public enum DSP_PAN_2D_STEREO_MODE_TYPE
	{
		[Token(Token = "0x400039B")]
		DISTRIBUTED,
		[Token(Token = "0x400039C")]
		DISCRETE
	}
	[Token(Token = "0x20000AF")]
	public enum DSP_PAN_MODE_TYPE
	{
		[Token(Token = "0x400039E")]
		MONO,
		[Token(Token = "0x400039F")]
		STEREO,
		[Token(Token = "0x40003A0")]
		SURROUND
	}
	[Token(Token = "0x20000B0")]
	public enum DSP_PAN_3D_ROLLOFF_TYPE
	{
		[Token(Token = "0x40003A2")]
		LINEARSQUARED,
		[Token(Token = "0x40003A3")]
		LINEAR,
		[Token(Token = "0x40003A4")]
		INVERSE,
		[Token(Token = "0x40003A5")]
		INVERSETAPERED,
		[Token(Token = "0x40003A6")]
		CUSTOM
	}
	[Token(Token = "0x20000B1")]
	public enum DSP_PAN_3D_EXTENT_MODE_TYPE
	{
		[Token(Token = "0x40003A8")]
		AUTO,
		[Token(Token = "0x40003A9")]
		USER,
		[Token(Token = "0x40003AA")]
		OFF
	}
	[Token(Token = "0x20000B2")]
	public enum DSP_PAN
	{
		[Token(Token = "0x40003AC")]
		MODE,
		[Token(Token = "0x40003AD")]
		_2D_STEREO_POSITION,
		[Token(Token = "0x40003AE")]
		_2D_DIRECTION,
		[Token(Token = "0x40003AF")]
		_2D_EXTENT,
		[Token(Token = "0x40003B0")]
		_2D_ROTATION,
		[Token(Token = "0x40003B1")]
		_2D_LFE_LEVEL,
		[Token(Token = "0x40003B2")]
		_2D_STEREO_MODE,
		[Token(Token = "0x40003B3")]
		_2D_STEREO_SEPARATION,
		[Token(Token = "0x40003B4")]
		_2D_STEREO_AXIS,
		[Token(Token = "0x40003B5")]
		ENABLED_SPEAKERS,
		[Token(Token = "0x40003B6")]
		_3D_POSITION,
		[Token(Token = "0x40003B7")]
		_3D_ROLLOFF,
		[Token(Token = "0x40003B8")]
		_3D_MIN_DISTANCE,
		[Token(Token = "0x40003B9")]
		_3D_MAX_DISTANCE,
		[Token(Token = "0x40003BA")]
		_3D_EXTENT_MODE,
		[Token(Token = "0x40003BB")]
		_3D_SOUND_SIZE,
		[Token(Token = "0x40003BC")]
		_3D_MIN_EXTENT,
		[Token(Token = "0x40003BD")]
		_3D_PAN_BLEND,
		[Token(Token = "0x40003BE")]
		LFE_UPMIX_ENABLED,
		[Token(Token = "0x40003BF")]
		OVERALL_GAIN,
		[Token(Token = "0x40003C0")]
		SURROUND_SPEAKER_MODE,
		[Token(Token = "0x40003C1")]
		_2D_HEIGHT_BLEND
	}
	[Token(Token = "0x20000B3")]
	public enum DSP_THREE_EQ_CROSSOVERSLOPE_TYPE
	{
		[Token(Token = "0x40003C3")]
		_12DB,
		[Token(Token = "0x40003C4")]
		_24DB,
		[Token(Token = "0x40003C5")]
		_48DB
	}
	[Token(Token = "0x20000B4")]
	public enum DSP_THREE_EQ
	{
		[Token(Token = "0x40003C7")]
		LOWGAIN,
		[Token(Token = "0x40003C8")]
		MIDGAIN,
		[Token(Token = "0x40003C9")]
		HIGHGAIN,
		[Token(Token = "0x40003CA")]
		LOWCROSSOVER,
		[Token(Token = "0x40003CB")]
		HIGHCROSSOVER,
		[Token(Token = "0x40003CC")]
		CROSSOVERSLOPE
	}
	[Token(Token = "0x20000B5")]
	public enum DSP_FFT_WINDOW
	{
		[Token(Token = "0x40003CE")]
		RECT,
		[Token(Token = "0x40003CF")]
		TRIANGLE,
		[Token(Token = "0x40003D0")]
		HAMMING,
		[Token(Token = "0x40003D1")]
		HANNING,
		[Token(Token = "0x40003D2")]
		BLACKMAN,
		[Token(Token = "0x40003D3")]
		BLACKMANHARRIS
	}
	[Token(Token = "0x20000B6")]
	public enum DSP_FFT
	{
		[Token(Token = "0x40003D5")]
		WINDOWSIZE,
		[Token(Token = "0x40003D6")]
		WINDOWTYPE,
		[Token(Token = "0x40003D7")]
		SPECTRUMDATA,
		[Token(Token = "0x40003D8")]
		DOMINANT_FREQ
	}
	[Token(Token = "0x20000B7")]
	public enum DSP_ENVELOPEFOLLOWER
	{
		[Token(Token = "0x40003DA")]
		ATTACK,
		[Token(Token = "0x40003DB")]
		RELEASE,
		[Token(Token = "0x40003DC")]
		ENVELOPE,
		[Token(Token = "0x40003DD")]
		USESIDECHAIN
	}
	[Token(Token = "0x20000B8")]
	public enum DSP_CONVOLUTION_REVERB
	{
		[Token(Token = "0x40003DF")]
		IR,
		[Token(Token = "0x40003E0")]
		WET,
		[Token(Token = "0x40003E1")]
		DRY,
		[Token(Token = "0x40003E2")]
		LINKED
	}
	[Token(Token = "0x20000B9")]
	public enum DSP_CHANNELMIX_OUTPUT
	{
		[Token(Token = "0x40003E4")]
		DEFAULT,
		[Token(Token = "0x40003E5")]
		ALLMONO,
		[Token(Token = "0x40003E6")]
		ALLSTEREO,
		[Token(Token = "0x40003E7")]
		ALLQUAD,
		[Token(Token = "0x40003E8")]
		ALL5POINT1,
		[Token(Token = "0x40003E9")]
		ALL7POINT1,
		[Token(Token = "0x40003EA")]
		ALLLFE,
		[Token(Token = "0x40003EB")]
		ALL7POINT1POINT4
	}
	[Token(Token = "0x20000BA")]
	public enum DSP_CHANNELMIX
	{
		[Token(Token = "0x40003ED")]
		OUTPUTGROUPING,
		[Token(Token = "0x40003EE")]
		GAIN_CH0,
		[Token(Token = "0x40003EF")]
		GAIN_CH1,
		[Token(Token = "0x40003F0")]
		GAIN_CH2,
		[Token(Token = "0x40003F1")]
		GAIN_CH3,
		[Token(Token = "0x40003F2")]
		GAIN_CH4,
		[Token(Token = "0x40003F3")]
		GAIN_CH5,
		[Token(Token = "0x40003F4")]
		GAIN_CH6,
		[Token(Token = "0x40003F5")]
		GAIN_CH7,
		[Token(Token = "0x40003F6")]
		GAIN_CH8,
		[Token(Token = "0x40003F7")]
		GAIN_CH9,
		[Token(Token = "0x40003F8")]
		GAIN_CH10,
		[Token(Token = "0x40003F9")]
		GAIN_CH11,
		[Token(Token = "0x40003FA")]
		GAIN_CH12,
		[Token(Token = "0x40003FB")]
		GAIN_CH13,
		[Token(Token = "0x40003FC")]
		GAIN_CH14,
		[Token(Token = "0x40003FD")]
		GAIN_CH15,
		[Token(Token = "0x40003FE")]
		GAIN_CH16,
		[Token(Token = "0x40003FF")]
		GAIN_CH17,
		[Token(Token = "0x4000400")]
		GAIN_CH18,
		[Token(Token = "0x4000401")]
		GAIN_CH19,
		[Token(Token = "0x4000402")]
		GAIN_CH20,
		[Token(Token = "0x4000403")]
		GAIN_CH21,
		[Token(Token = "0x4000404")]
		GAIN_CH22,
		[Token(Token = "0x4000405")]
		GAIN_CH23,
		[Token(Token = "0x4000406")]
		GAIN_CH24,
		[Token(Token = "0x4000407")]
		GAIN_CH25,
		[Token(Token = "0x4000408")]
		GAIN_CH26,
		[Token(Token = "0x4000409")]
		GAIN_CH27,
		[Token(Token = "0x400040A")]
		GAIN_CH28,
		[Token(Token = "0x400040B")]
		GAIN_CH29,
		[Token(Token = "0x400040C")]
		GAIN_CH30,
		[Token(Token = "0x400040D")]
		GAIN_CH31,
		[Token(Token = "0x400040E")]
		OUTPUT_CH0,
		[Token(Token = "0x400040F")]
		OUTPUT_CH1,
		[Token(Token = "0x4000410")]
		OUTPUT_CH2,
		[Token(Token = "0x4000411")]
		OUTPUT_CH3,
		[Token(Token = "0x4000412")]
		OUTPUT_CH4,
		[Token(Token = "0x4000413")]
		OUTPUT_CH5,
		[Token(Token = "0x4000414")]
		OUTPUT_CH6,
		[Token(Token = "0x4000415")]
		OUTPUT_CH7,
		[Token(Token = "0x4000416")]
		OUTPUT_CH8,
		[Token(Token = "0x4000417")]
		OUTPUT_CH9,
		[Token(Token = "0x4000418")]
		OUTPUT_CH10,
		[Token(Token = "0x4000419")]
		OUTPUT_CH11,
		[Token(Token = "0x400041A")]
		OUTPUT_CH12,
		[Token(Token = "0x400041B")]
		OUTPUT_CH13,
		[Token(Token = "0x400041C")]
		OUTPUT_CH14,
		[Token(Token = "0x400041D")]
		OUTPUT_CH15,
		[Token(Token = "0x400041E")]
		OUTPUT_CH16,
		[Token(Token = "0x400041F")]
		OUTPUT_CH17,
		[Token(Token = "0x4000420")]
		OUTPUT_CH18,
		[Token(Token = "0x4000421")]
		OUTPUT_CH19,
		[Token(Token = "0x4000422")]
		OUTPUT_CH20,
		[Token(Token = "0x4000423")]
		OUTPUT_CH21,
		[Token(Token = "0x4000424")]
		OUTPUT_CH22,
		[Token(Token = "0x4000425")]
		OUTPUT_CH23,
		[Token(Token = "0x4000426")]
		OUTPUT_CH24,
		[Token(Token = "0x4000427")]
		OUTPUT_CH25,
		[Token(Token = "0x4000428")]
		OUTPUT_CH26,
		[Token(Token = "0x4000429")]
		OUTPUT_CH27,
		[Token(Token = "0x400042A")]
		OUTPUT_CH28,
		[Token(Token = "0x400042B")]
		OUTPUT_CH29,
		[Token(Token = "0x400042C")]
		OUTPUT_CH30,
		[Token(Token = "0x400042D")]
		OUTPUT_CH31
	}
	[Token(Token = "0x20000BB")]
	public enum DSP_TRANSCEIVER_SPEAKERMODE
	{
		[Token(Token = "0x400042F")]
		AUTO = -1,
		[Token(Token = "0x4000430")]
		MONO,
		[Token(Token = "0x4000431")]
		STEREO,
		[Token(Token = "0x4000432")]
		SURROUND
	}
	[Token(Token = "0x20000BC")]
	public enum DSP_TRANSCEIVER
	{
		[Token(Token = "0x4000434")]
		TRANSMIT,
		[Token(Token = "0x4000435")]
		GAIN,
		[Token(Token = "0x4000436")]
		CHANNEL,
		[Token(Token = "0x4000437")]
		TRANSMITSPEAKERMODE
	}
	[Token(Token = "0x20000BD")]
	public enum DSP_OBJECTPAN
	{
		[Token(Token = "0x4000439")]
		_3D_POSITION,
		[Token(Token = "0x400043A")]
		_3D_ROLLOFF,
		[Token(Token = "0x400043B")]
		_3D_MIN_DISTANCE,
		[Token(Token = "0x400043C")]
		_3D_MAX_DISTANCE,
		[Token(Token = "0x400043D")]
		_3D_EXTENT_MODE,
		[Token(Token = "0x400043E")]
		_3D_SOUND_SIZE,
		[Token(Token = "0x400043F")]
		_3D_MIN_EXTENT,
		[Token(Token = "0x4000440")]
		OVERALL_GAIN,
		[Token(Token = "0x4000441")]
		OUTPUTGAIN
	}
	[Token(Token = "0x20000BE")]
	public class Error
	{
		[Token(Token = "0x600047C")]
		[Address(RVA = "0xC17F6C", Offset = "0xC17F6C", VA = "0xC17F6C")]
		public static string String(RESULT errcode)
		{
			return null;
		}

		[Token(Token = "0x600047D")]
		[Address(RVA = "0xC2D9B0", Offset = "0xC2D9B0", VA = "0xC2D9B0")]
		public Error()
		{
		}
	}
}
namespace FMOD.Studio
{
	[Token(Token = "0x20000BF")]
	public class STUDIO_VERSION
	{
		[Token(Token = "0x4000442")]
		public const string dll = "fmodstudio";

		[Token(Token = "0x600047E")]
		[Address(RVA = "0xC3E474", Offset = "0xC3E474", VA = "0xC3E474")]
		public STUDIO_VERSION()
		{
		}
	}
	[Token(Token = "0x20000C0")]
	public enum STOP_MODE
	{
		[Token(Token = "0x4000444")]
		ALLOWFADEOUT,
		[Token(Token = "0x4000445")]
		IMMEDIATE
	}
	[Token(Token = "0x20000C1")]
	public enum LOADING_STATE
	{
		[Token(Token = "0x4000447")]
		UNLOADING,
		[Token(Token = "0x4000448")]
		UNLOADED,
		[Token(Token = "0x4000449")]
		LOADING,
		[Token(Token = "0x400044A")]
		LOADED,
		[Token(Token = "0x400044B")]
		ERROR
	}
	[Token(Token = "0x20000C2")]
	public struct PROGRAMMER_SOUND_PROPERTIES
	{
		[Token(Token = "0x400044C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public StringWrapper name;

		[Token(Token = "0x400044D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public IntPtr sound;

		[Token(Token = "0x400044E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int subsoundIndex;
	}
	[Token(Token = "0x20000C3")]
	public struct TIMELINE_MARKER_PROPERTIES
	{
		[Token(Token = "0x400044F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public StringWrapper name;

		[Token(Token = "0x4000450")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public int position;
	}
	[Token(Token = "0x20000C4")]
	public struct TIMELINE_BEAT_PROPERTIES
	{
		[Token(Token = "0x4000451")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int bar;

		[Token(Token = "0x4000452")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public int beat;

		[Token(Token = "0x4000453")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public int position;

		[Token(Token = "0x4000454")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public float tempo;

		[Token(Token = "0x4000455")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int timesignatureupper;

		[Token(Token = "0x4000456")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public int timesignaturelower;
	}
	[Token(Token = "0x20000C5")]
	public struct ADVANCEDSETTINGS
	{
		[Token(Token = "0x4000457")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int cbsize;

		[Token(Token = "0x4000458")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public int commandqueuesize;

		[Token(Token = "0x4000459")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public int handleinitialsize;

		[Token(Token = "0x400045A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public int studioupdateperiod;

		[Token(Token = "0x400045B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int idlesampledatapoolsize;

		[Token(Token = "0x400045C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public int streamingscheduledelay;

		[Token(Token = "0x400045D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public IntPtr encryptionkey;
	}
	[Token(Token = "0x20000C6")]
	public struct CPU_USAGE
	{
		[Token(Token = "0x400045E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float dspusage;

		[Token(Token = "0x400045F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public float streamusage;

		[Token(Token = "0x4000460")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public float geometryusage;

		[Token(Token = "0x4000461")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public float updateusage;

		[Token(Token = "0x4000462")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float studiousage;
	}
	[Token(Token = "0x20000C7")]
	public struct BUFFER_INFO
	{
		[Token(Token = "0x4000463")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int currentusage;

		[Token(Token = "0x4000464")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public int peakusage;

		[Token(Token = "0x4000465")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public int capacity;

		[Token(Token = "0x4000466")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public int stallcount;

		[Token(Token = "0x4000467")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float stalltime;
	}
	[Token(Token = "0x20000C8")]
	public struct BUFFER_USAGE
	{
		[Token(Token = "0x4000468")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public BUFFER_INFO studiocommandqueue;

		[Token(Token = "0x4000469")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public BUFFER_INFO studiohandle;
	}
	[Token(Token = "0x20000C9")]
	public struct BANK_INFO
	{
		[Token(Token = "0x400046A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int size;

		[Token(Token = "0x400046B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public IntPtr userdata;

		[Token(Token = "0x400046C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int userdatalength;

		[Token(Token = "0x400046D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public FILE_OPEN_CALLBACK opencallback;

		[Token(Token = "0x400046E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public FILE_CLOSE_CALLBACK closecallback;

		[Token(Token = "0x400046F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public FILE_READ_CALLBACK readcallback;

		[Token(Token = "0x4000470")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public FILE_SEEK_CALLBACK seekcallback;
	}
	[Token(Token = "0x20000CA")]
	[Flags]
	public enum SYSTEM_CALLBACK_TYPE : uint
	{
		[Token(Token = "0x4000472")]
		PREUPDATE = 1u,
		[Token(Token = "0x4000473")]
		POSTUPDATE = 2u,
		[Token(Token = "0x4000474")]
		BANK_UNLOAD = 4u,
		[Token(Token = "0x4000475")]
		ALL = uint.MaxValue
	}
	[Token(Token = "0x20000CB")]
	public delegate RESULT SYSTEM_CALLBACK(IntPtr system, SYSTEM_CALLBACK_TYPE type, IntPtr commanddata, IntPtr userdata);
	[Token(Token = "0x20000CC")]
	public enum PARAMETER_TYPE
	{
		[Token(Token = "0x4000477")]
		GAME_CONTROLLED,
		[Token(Token = "0x4000478")]
		AUTOMATIC_DISTANCE,
		[Token(Token = "0x4000479")]
		AUTOMATIC_EVENT_CONE_ANGLE,
		[Token(Token = "0x400047A")]
		AUTOMATIC_EVENT_ORIENTATION,
		[Token(Token = "0x400047B")]
		AUTOMATIC_DIRECTION,
		[Token(Token = "0x400047C")]
		AUTOMATIC_ELEVATION,
		[Token(Token = "0x400047D")]
		AUTOMATIC_LISTENER_ORIENTATION,
		[Token(Token = "0x400047E")]
		AUTOMATIC_SPEED,
		[Token(Token = "0x400047F")]
		MAX
	}
	[Token(Token = "0x20000CD")]
	[Flags]
	public enum PARAMETER_FLAGS : uint
	{
		[Token(Token = "0x4000481")]
		READONLY = 1u,
		[Token(Token = "0x4000482")]
		AUTOMATIC = 2u,
		[Token(Token = "0x4000483")]
		GLOBAL = 4u
	}
	[Token(Token = "0x20000CE")]
	public struct PARAMETER_ID
	{
		[Token(Token = "0x4000484")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public uint data1;

		[Token(Token = "0x4000485")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public uint data2;
	}
	[Token(Token = "0x20000CF")]
	public struct PARAMETER_DESCRIPTION
	{
		[Token(Token = "0x4000486")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public StringWrapper name;

		[Token(Token = "0x4000487")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public PARAMETER_ID id;

		[Token(Token = "0x4000488")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float minimum;

		[Token(Token = "0x4000489")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public float maximum;

		[Token(Token = "0x400048A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float defaultvalue;

		[Token(Token = "0x400048B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public PARAMETER_TYPE type;

		[Token(Token = "0x400048C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public PARAMETER_FLAGS flags;
	}
	[Token(Token = "0x20000D0")]
	internal enum LOAD_MEMORY_MODE
	{
		[Token(Token = "0x400048E")]
		LOAD_MEMORY,
		[Token(Token = "0x400048F")]
		LOAD_MEMORY_POINT
	}
	[Token(Token = "0x20000D1")]
	internal enum LOAD_MEMORY_ALIGNMENT
	{
		[Token(Token = "0x4000491")]
		VALUE = 0x20
	}
	[Token(Token = "0x20000D2")]
	public struct SOUND_INFO
	{
		[Token(Token = "0x4000492")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public IntPtr name_or_data;

		[Token(Token = "0x4000493")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public MODE mode;

		[Token(Token = "0x4000494")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public CREATESOUNDEXINFO exinfo;

		[Token(Token = "0x4000495")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		public int subsoundindex;

		[Token(Token = "0x17000007")]
		public string name
		{
			[Token(Token = "0x6000483")]
			[Address(RVA = "0xC3D85C", Offset = "0xC3D85C", VA = "0xC3D85C")]
			get
			{
				return null;
			}
		}
	}
	[Token(Token = "0x20000D3")]
	public enum USER_PROPERTY_TYPE
	{
		[Token(Token = "0x4000497")]
		INTEGER,
		[Token(Token = "0x4000498")]
		BOOLEAN,
		[Token(Token = "0x4000499")]
		FLOAT,
		[Token(Token = "0x400049A")]
		STRING
	}
	[Token(Token = "0x20000D4")]
	public struct USER_PROPERTY
	{
		[Token(Token = "0x400049B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public StringWrapper name;

		[Token(Token = "0x400049C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public USER_PROPERTY_TYPE type;

		[Token(Token = "0x400049D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private Union_IntBoolFloatString value;

		[Token(Token = "0x6000484")]
		[Address(RVA = "0x1E49C38", Offset = "0x1E49C38", VA = "0x1E49C38")]
		public int intValue()
		{
			return default(int);
		}

		[Token(Token = "0x6000485")]
		[Address(RVA = "0x1E49C50", Offset = "0x1E49C50", VA = "0x1E49C50")]
		public bool boolValue()
		{
			return default(bool);
		}

		[Token(Token = "0x6000486")]
		[Address(RVA = "0x1E49C74", Offset = "0x1E49C74", VA = "0x1E49C74")]
		public float floatValue()
		{
			return default(float);
		}

		[Token(Token = "0x6000487")]
		[Address(RVA = "0x1E49C90", Offset = "0x1E49C90", VA = "0x1E49C90")]
		public string stringValue()
		{
			return null;
		}
	}
	[StructLayout(2)]
	[Token(Token = "0x20000D5")]
	internal struct Union_IntBoolFloatString
	{
		[Token(Token = "0x400049E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int intvalue;

		[Token(Token = "0x400049F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public bool boolvalue;

		[Token(Token = "0x40004A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float floatvalue;

		[Token(Token = "0x40004A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public StringWrapper stringvalue;
	}
	[Token(Token = "0x20000D6")]
	[Flags]
	public enum INITFLAGS : uint
	{
		[Token(Token = "0x40004A3")]
		NORMAL = 0u,
		[Token(Token = "0x40004A4")]
		LIVEUPDATE = 1u,
		[Token(Token = "0x40004A5")]
		ALLOW_MISSING_PLUGINS = 2u,
		[Token(Token = "0x40004A6")]
		SYNCHRONOUS_UPDATE = 4u,
		[Token(Token = "0x40004A7")]
		DEFERRED_CALLBACKS = 8u,
		[Token(Token = "0x40004A8")]
		LOAD_FROM_UPDATE = 0x10u,
		[Token(Token = "0x40004A9")]
		MEMORY_TRACKING = 0x20u
	}
	[Token(Token = "0x20000D7")]
	[Flags]
	public enum LOAD_BANK_FLAGS : uint
	{
		[Token(Token = "0x40004AB")]
		NORMAL = 0u,
		[Token(Token = "0x40004AC")]
		NONBLOCKING = 1u,
		[Token(Token = "0x40004AD")]
		DECOMPRESS_SAMPLES = 2u,
		[Token(Token = "0x40004AE")]
		UNENCRYPTED = 4u
	}
	[Token(Token = "0x20000D8")]
	[Flags]
	public enum COMMANDCAPTURE_FLAGS : uint
	{
		[Token(Token = "0x40004B0")]
		NORMAL = 0u,
		[Token(Token = "0x40004B1")]
		FILEFLUSH = 1u,
		[Token(Token = "0x40004B2")]
		SKIP_INITIAL_STATE = 2u
	}
	[Token(Token = "0x20000D9")]
	[Flags]
	public enum COMMANDREPLAY_FLAGS : uint
	{
		[Token(Token = "0x40004B4")]
		NORMAL = 0u,
		[Token(Token = "0x40004B5")]
		SKIP_CLEANUP = 1u,
		[Token(Token = "0x40004B6")]
		FAST_FORWARD = 2u,
		[Token(Token = "0x40004B7")]
		SKIP_BANK_LOAD = 4u
	}
	[Token(Token = "0x20000DA")]
	public enum PLAYBACK_STATE
	{
		[Token(Token = "0x40004B9")]
		PLAYING,
		[Token(Token = "0x40004BA")]
		SUSTAINING,
		[Token(Token = "0x40004BB")]
		STOPPED,
		[Token(Token = "0x40004BC")]
		STARTING,
		[Token(Token = "0x40004BD")]
		STOPPING
	}
	[Token(Token = "0x20000DB")]
	public enum EVENT_PROPERTY
	{
		[Token(Token = "0x40004BF")]
		CHANNELPRIORITY,
		[Token(Token = "0x40004C0")]
		SCHEDULE_DELAY,
		[Token(Token = "0x40004C1")]
		SCHEDULE_LOOKAHEAD,
		[Token(Token = "0x40004C2")]
		MINIMUM_DISTANCE,
		[Token(Token = "0x40004C3")]
		MAXIMUM_DISTANCE,
		[Token(Token = "0x40004C4")]
		COOLDOWN,
		[Token(Token = "0x40004C5")]
		MAX
	}
	[Token(Token = "0x20000DC")]
	public struct PLUGIN_INSTANCE_PROPERTIES
	{
		[Token(Token = "0x40004C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public IntPtr name;

		[Token(Token = "0x40004C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public IntPtr dsp;
	}
	[Token(Token = "0x20000DD")]
	[Flags]
	public enum EVENT_CALLBACK_TYPE : uint
	{
		[Token(Token = "0x40004C9")]
		CREATED = 1u,
		[Token(Token = "0x40004CA")]
		DESTROYED = 2u,
		[Token(Token = "0x40004CB")]
		STARTING = 4u,
		[Token(Token = "0x40004CC")]
		STARTED = 8u,
		[Token(Token = "0x40004CD")]
		RESTARTED = 0x10u,
		[Token(Token = "0x40004CE")]
		STOPPED = 0x20u,
		[Token(Token = "0x40004CF")]
		START_FAILED = 0x40u,
		[Token(Token = "0x40004D0")]
		CREATE_PROGRAMMER_SOUND = 0x80u,
		[Token(Token = "0x40004D1")]
		DESTROY_PROGRAMMER_SOUND = 0x100u,
		[Token(Token = "0x40004D2")]
		PLUGIN_CREATED = 0x200u,
		[Token(Token = "0x40004D3")]
		PLUGIN_DESTROYED = 0x400u,
		[Token(Token = "0x40004D4")]
		TIMELINE_MARKER = 0x800u,
		[Token(Token = "0x40004D5")]
		TIMELINE_BEAT = 0x1000u,
		[Token(Token = "0x40004D6")]
		SOUND_PLAYED = 0x2000u,
		[Token(Token = "0x40004D7")]
		SOUND_STOPPED = 0x4000u,
		[Token(Token = "0x40004D8")]
		REAL_TO_VIRTUAL = 0x8000u,
		[Token(Token = "0x40004D9")]
		VIRTUAL_TO_REAL = 0x10000u,
		[Token(Token = "0x40004DA")]
		ALL = uint.MaxValue
	}
	[Token(Token = "0x20000DE")]
	public delegate RESULT EVENT_CALLBACK(EVENT_CALLBACK_TYPE type, EventInstance _event, IntPtr parameters);
	[Token(Token = "0x20000DF")]
	public delegate RESULT COMMANDREPLAY_FRAME_CALLBACK(CommandReplay replay, int commandindex, float currenttime, IntPtr userdata);
	[Token(Token = "0x20000E0")]
	public delegate RESULT COMMANDREPLAY_LOAD_BANK_CALLBACK(CommandReplay replay, int commandindex, Guid bankguid, StringWrapper bankfilename, LOAD_BANK_FLAGS flags, out Bank bank, IntPtr userdata);
	[Token(Token = "0x20000E1")]
	public delegate RESULT COMMANDREPLAY_CREATE_INSTANCE_CALLBACK(CommandReplay replay, int commandindex, EventDescription eventdescription, out EventInstance instance, IntPtr userdata);
	[Token(Token = "0x20000E2")]
	public enum INSTANCETYPE
	{
		[Token(Token = "0x40004DC")]
		NONE,
		[Token(Token = "0x40004DD")]
		SYSTEM,
		[Token(Token = "0x40004DE")]
		EVENTDESCRIPTION,
		[Token(Token = "0x40004DF")]
		EVENTINSTANCE,
		[Token(Token = "0x40004E0")]
		PARAMETERINSTANCE,
		[Token(Token = "0x40004E1")]
		BUS,
		[Token(Token = "0x40004E2")]
		VCA,
		[Token(Token = "0x40004E3")]
		BANK,
		[Token(Token = "0x40004E4")]
		COMMANDREPLAY
	}
	[Token(Token = "0x20000E3")]
	public struct COMMAND_INFO
	{
		[Token(Token = "0x40004E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public StringWrapper commandname;

		[Token(Token = "0x40004E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public int parentcommandindex;

		[Token(Token = "0x40004E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public int framenumber;

		[Token(Token = "0x40004E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float frametime;

		[Token(Token = "0x40004E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public INSTANCETYPE instancetype;

		[Token(Token = "0x40004EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public INSTANCETYPE outputtype;

		[Token(Token = "0x40004EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public uint instancehandle;

		[Token(Token = "0x40004EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public uint outputhandle;
	}
	[Token(Token = "0x20000E4")]
	public struct MEMORY_USAGE
	{
		[Token(Token = "0x40004ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int exclusive;

		[Token(Token = "0x40004EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public int inclusive;

		[Token(Token = "0x40004EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public int sampledata;
	}
	[Token(Token = "0x20000E5")]
	public struct Util
	{
		[Token(Token = "0x6000498")]
		[Address(RVA = "0x1E49CF4", Offset = "0x1E49CF4", VA = "0x1E49CF4")]
		public static RESULT parseID(string idString, out Guid id)
		{
			return default(RESULT);
		}

		[PreserveSig]
		[Token(Token = "0x6000499")]
		[Address(RVA = "0x1E49E78", Offset = "0x1E49E78", VA = "0x1E49E78")]
		private static extern RESULT FMOD_Studio_ParseID(byte[] idString, out Guid id);
	}
	[Token(Token = "0x20000E6")]
	public struct System
	{
		[Token(Token = "0x40004F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public IntPtr handle;

		[Token(Token = "0x600049A")]
		[Address(RVA = "0x1E45B9C", Offset = "0x1E45B9C", VA = "0x1E45B9C")]
		public static RESULT create(out System system)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600049B")]
		[Address(RVA = "0x1E45C38", Offset = "0x1E45C38", VA = "0x1E45C38")]
		public RESULT setAdvancedSettings(ADVANCEDSETTINGS settings)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600049C")]
		[Address(RVA = "0x1E45DA0", Offset = "0x1E45DA0", VA = "0x1E45DA0")]
		public RESULT setAdvancedSettings(ADVANCEDSETTINGS settings, string encryptionKey)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600049D")]
		[Address(RVA = "0x1E45FD0", Offset = "0x1E45FD0", VA = "0x1E45FD0")]
		public RESULT getAdvancedSettings(out ADVANCEDSETTINGS settings)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600049E")]
		[Address(RVA = "0x1E46138", Offset = "0x1E46138", VA = "0x1E46138")]
		public RESULT initialize(int maxchannels, INITFLAGS studioflags, FMOD.INITFLAGS flags, IntPtr extradriverdata)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600049F")]
		[Address(RVA = "0x1E461F0", Offset = "0x1E461F0", VA = "0x1E461F0")]
		public RESULT release()
		{
			return default(RESULT);
		}

		[Token(Token = "0x60004A0")]
		[Address(RVA = "0x1E3F300", Offset = "0x1E3F300", VA = "0x1E3F300")]
		public RESULT update()
		{
			return default(RESULT);
		}

		[Token(Token = "0x60004A1")]
		[Address(RVA = "0x1E462F8", Offset = "0x1E462F8", VA = "0x1E462F8")]
		public RESULT getCoreSystem(out FMOD.System coresystem)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60004A2")]
		[Address(RVA = "0x1E46390", Offset = "0x1E46390", VA = "0x1E46390")]
		public RESULT getEvent(string path, out EventDescription _event)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60004A3")]
		[Address(RVA = "0x1E465C4", Offset = "0x1E465C4", VA = "0x1E465C4")]
		public RESULT getBus(string path, out Bus bus)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60004A4")]
		[Address(RVA = "0x1E467F8", Offset = "0x1E467F8", VA = "0x1E467F8")]
		public RESULT getVCA(string path, out VCA vca)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60004A5")]
		[Address(RVA = "0x1E46A2C", Offset = "0x1E46A2C", VA = "0x1E46A2C")]
		public RESULT getBank(string path, out Bank bank)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60004A6")]
		[Address(RVA = "0x1E46C60", Offset = "0x1E46C60", VA = "0x1E46C60")]
		public RESULT getEventByID(Guid id, out EventDescription _event)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60004A7")]
		[Address(RVA = "0x1E46D24", Offset = "0x1E46D24", VA = "0x1E46D24")]
		public RESULT getBusByID(Guid id, out Bus bus)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60004A8")]
		[Address(RVA = "0x1E46DE8", Offset = "0x1E46DE8", VA = "0x1E46DE8")]
		public RESULT getVCAByID(Guid id, out VCA vca)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60004A9")]
		[Address(RVA = "0x1E46EAC", Offset = "0x1E46EAC", VA = "0x1E46EAC")]
		public RESULT getBankByID(Guid id, out Bank bank)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60004AA")]
		[Address(RVA = "0x1E46F70", Offset = "0x1E46F70", VA = "0x1E46F70")]
		public RESULT getSoundInfo(string key, out SOUND_INFO info)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60004AB")]
		[Address(RVA = "0x1E3FABC", Offset = "0x1E3FABC", VA = "0x1E3FABC")]
		public RESULT getParameterDescriptionByName(string name, out PARAMETER_DESCRIPTION parameter)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60004AC")]
		[Address(RVA = "0x1E4729C", Offset = "0x1E4729C", VA = "0x1E4729C")]
		public RESULT getParameterDescriptionByID(PARAMETER_ID id, out PARAMETER_DESCRIPTION parameter)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60004AD")]
		[Address(RVA = "0x1E4733C", Offset = "0x1E4733C", VA = "0x1E4733C")]
		public RESULT getParameterByID(PARAMETER_ID id, out float value)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60004AE")]
		[Address(RVA = "0x1E47364", Offset = "0x1E47364", VA = "0x1E47364")]
		public RESULT getParameterByID(PARAMETER_ID id, out float value, out float finalvalue)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60004AF")]
		[Address(RVA = "0x1E3FDCC", Offset = "0x1E3FDCC", VA = "0x1E3FDCC")]
		public RESULT setParameterByID(PARAMETER_ID id, float value, bool ignoreseekspeed = false)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60004B0")]
		[Address(RVA = "0x1E474BC", Offset = "0x1E474BC", VA = "0x1E474BC")]
		public RESULT setParametersByIDs(PARAMETER_ID[] ids, float[] values, int count, bool ignoreseekspeed = false)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60004B1")]
		[Address(RVA = "0x1E47588", Offset = "0x1E47588", VA = "0x1E47588")]
		public RESULT getParameterByName(string name, out float value)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60004B2")]
		[Address(RVA = "0x1E475AC", Offset = "0x1E475AC", VA = "0x1E475AC")]
		public RESULT getParameterByName(string name, out float value, out float finalvalue)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60004B3")]
		[Address(RVA = "0x1E477F8", Offset = "0x1E477F8", VA = "0x1E477F8")]
		public RESULT setParameterByName(string name, float value, bool ignoreseekspeed = false)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60004B4")]
		[Address(RVA = "0x1E47A44", Offset = "0x1E47A44", VA = "0x1E47A44")]
		public RESULT lookupID(string path, out Guid id)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60004B5")]
		[Address(RVA = "0x1E47C78", Offset = "0x1E47C78", VA = "0x1E47C78")]
		public RESULT lookupPath(Guid id, out string path)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60004B6")]
		[Address(RVA = "0x1E47FB4", Offset = "0x1E47FB4", VA = "0x1E47FB4")]
		public RESULT getNumListeners(out int numlisteners)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60004B7")]
		[Address(RVA = "0x1E4804C", Offset = "0x1E4804C", VA = "0x1E4804C")]
		public RESULT setNumListeners(int numlisteners)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60004B8")]
		[Address(RVA = "0x1E480E4", Offset = "0x1E480E4", VA = "0x1E480E4")]
		public RESULT getListenerAttributes(int listener, out ATTRIBUTES_3D attributes)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60004B9")]
		[Address(RVA = "0x1E48184", Offset = "0x1E48184", VA = "0x1E48184")]
		public RESULT setListenerAttributes(int listener, ATTRIBUTES_3D attributes)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60004BA")]
		[Address(RVA = "0x1E48224", Offset = "0x1E48224", VA = "0x1E48224")]
		public RESULT getListenerWeight(int listener, out float weight)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60004BB")]
		[Address(RVA = "0x1E482C4", Offset = "0x1E482C4", VA = "0x1E482C4")]
		public RESULT setListenerWeight(int listener, float weight)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60004BC")]
		[Address(RVA = "0x1E4836C", Offset = "0x1E4836C", VA = "0x1E4836C")]
		public RESULT loadBankFile(string filename, LOAD_BANK_FLAGS flags, out Bank bank)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60004BD")]
		[Address(RVA = "0x1E485B8", Offset = "0x1E485B8", VA = "0x1E485B8")]
		public RESULT loadBankMemory(byte[] buffer, LOAD_BANK_FLAGS flags, out Bank bank)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60004BE")]
		[Address(RVA = "0x1E48708", Offset = "0x1E48708", VA = "0x1E48708")]
		public RESULT loadBankCustom(BANK_INFO info, LOAD_BANK_FLAGS flags, out Bank bank)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60004BF")]
		[Address(RVA = "0x1E488FC", Offset = "0x1E488FC", VA = "0x1E488FC")]
		public RESULT unloadAll()
		{
			return default(RESULT);
		}

		[Token(Token = "0x60004C0")]
		[Address(RVA = "0x1E48984", Offset = "0x1E48984", VA = "0x1E48984")]
		public RESULT flushCommands()
		{
			return default(RESULT);
		}

		[Token(Token = "0x60004C1")]
		[Address(RVA = "0x1E48A0C", Offset = "0x1E48A0C", VA = "0x1E48A0C")]
		public RESULT flushSampleLoading()
		{
			return default(RESULT);
		}

		[Token(Token = "0x60004C2")]
		[Address(RVA = "0x1E48A94", Offset = "0x1E48A94", VA = "0x1E48A94")]
		public RESULT startCommandCapture(string filename, COMMANDCAPTURE_FLAGS flags)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60004C3")]
		[Address(RVA = "0x1E48CC8", Offset = "0x1E48CC8", VA = "0x1E48CC8")]
		public RESULT stopCommandCapture()
		{
			return default(RESULT);
		}

		[Token(Token = "0x60004C4")]
		[Address(RVA = "0x1E48D50", Offset = "0x1E48D50", VA = "0x1E48D50")]
		public RESULT loadCommandReplay(string filename, COMMANDREPLAY_FLAGS flags, out CommandReplay replay)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60004C5")]
		[Address(RVA = "0x1E48F9C", Offset = "0x1E48F9C", VA = "0x1E48F9C")]
		public RESULT getBankCount(out int count)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60004C6")]
		[Address(RVA = "0x1E49034", Offset = "0x1E49034", VA = "0x1E49034")]
		public RESULT getBankList(out Bank[] array)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60004C7")]
		[Address(RVA = "0x1E4923C", Offset = "0x1E4923C", VA = "0x1E4923C")]
		public RESULT getParameterDescriptionCount(out int count)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60004C8")]
		[Address(RVA = "0x1E492D4", Offset = "0x1E492D4", VA = "0x1E492D4")]
		public RESULT getParameterDescriptionList(out PARAMETER_DESCRIPTION[] array)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60004C9")]
		[Address(RVA = "0x1E49520", Offset = "0x1E49520", VA = "0x1E49520")]
		public RESULT getCPUUsage(out CPU_USAGE usage)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60004CA")]
		[Address(RVA = "0x1E495B8", Offset = "0x1E495B8", VA = "0x1E495B8")]
		public RESULT getBufferUsage(out BUFFER_USAGE usage)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60004CB")]
		[Address(RVA = "0x1E49650", Offset = "0x1E49650", VA = "0x1E49650")]
		public RESULT resetBufferUsage()
		{
			return default(RESULT);
		}

		[Token(Token = "0x60004CC")]
		[Address(RVA = "0x1E496D8", Offset = "0x1E496D8", VA = "0x1E496D8")]
		public RESULT setCallback(SYSTEM_CALLBACK callback, SYSTEM_CALLBACK_TYPE callbackmask = SYSTEM_CALLBACK_TYPE.ALL)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60004CD")]
		[Address(RVA = "0x1E49780", Offset = "0x1E49780", VA = "0x1E49780")]
		public RESULT getUserData(out IntPtr userdata)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60004CE")]
		[Address(RVA = "0x1E49818", Offset = "0x1E49818", VA = "0x1E49818")]
		public RESULT setUserData(IntPtr userdata)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60004CF")]
		[Address(RVA = "0x1E498B0", Offset = "0x1E498B0", VA = "0x1E498B0")]
		public RESULT getMemoryUsage(out MEMORY_USAGE memoryusage)
		{
			return default(RESULT);
		}

		[PreserveSig]
		[Token(Token = "0x60004D0")]
		[Address(RVA = "0x1E45BA8", Offset = "0x1E45BA8", VA = "0x1E45BA8")]
		private static extern RESULT FMOD_Studio_System_Create(out IntPtr system, uint headerversion);

		[PreserveSig]
		[Token(Token = "0x60004D1")]
		[Address(RVA = "0x1E49948", Offset = "0x1E49948", VA = "0x1E49948")]
		private static extern bool FMOD_Studio_System_IsValid(IntPtr system);

		[PreserveSig]
		[Token(Token = "0x60004D2")]
		[Address(RVA = "0x1E45D10", Offset = "0x1E45D10", VA = "0x1E45D10")]
		private static extern RESULT FMOD_Studio_System_SetAdvancedSettings(IntPtr system, ref ADVANCEDSETTINGS settings);

		[PreserveSig]
		[Token(Token = "0x60004D3")]
		[Address(RVA = "0x1E460A8", Offset = "0x1E460A8", VA = "0x1E460A8")]
		private static extern RESULT FMOD_Studio_System_GetAdvancedSettings(IntPtr system, out ADVANCEDSETTINGS settings);

		[PreserveSig]
		[Token(Token = "0x60004D4")]
		[Address(RVA = "0x1E46140", Offset = "0x1E46140", VA = "0x1E46140")]
		private static extern RESULT FMOD_Studio_System_Initialize(IntPtr system, int maxchannels, INITFLAGS studioflags, FMOD.INITFLAGS flags, IntPtr extradriverdata);

		[PreserveSig]
		[Token(Token = "0x60004D5")]
		[Address(RVA = "0x1E461F8", Offset = "0x1E461F8", VA = "0x1E461F8")]
		private static extern RESULT FMOD_Studio_System_Release(IntPtr system);

		[PreserveSig]
		[Token(Token = "0x60004D6")]
		[Address(RVA = "0x1E46278", Offset = "0x1E46278", VA = "0x1E46278")]
		private static extern RESULT FMOD_Studio_System_Update(IntPtr system);

		[PreserveSig]
		[Token(Token = "0x60004D7")]
		[Address(RVA = "0x1E46300", Offset = "0x1E46300", VA = "0x1E46300")]
		private static extern RESULT FMOD_Studio_System_GetCoreSystem(IntPtr system, out IntPtr coresystem);

		[PreserveSig]
		[Token(Token = "0x60004D8")]
		[Address(RVA = "0x1E46524", Offset = "0x1E46524", VA = "0x1E46524")]
		private static extern RESULT FMOD_Studio_System_GetEvent(IntPtr system, byte[] path, out IntPtr _event);

		[PreserveSig]
		[Token(Token = "0x60004D9")]
		[Address(RVA = "0x1E46758", Offset = "0x1E46758", VA = "0x1E46758")]
		private static extern RESULT FMOD_Studio_System_GetBus(IntPtr system, byte[] path, out IntPtr bus);

		[PreserveSig]
		[Token(Token = "0x60004DA")]
		[Address(RVA = "0x1E4698C", Offset = "0x1E4698C", VA = "0x1E4698C")]
		private static extern RESULT FMOD_Studio_System_GetVCA(IntPtr system, byte[] path, out IntPtr vca);

		[PreserveSig]
		[Token(Token = "0x60004DB")]
		[Address(RVA = "0x1E46BC0", Offset = "0x1E46BC0", VA = "0x1E46BC0")]
		private static extern RESULT FMOD_Studio_System_GetBank(IntPtr system, byte[] path, out IntPtr bank);

		[PreserveSig]
		[Token(Token = "0x60004DC")]
		[Address(RVA = "0x1E46C8C", Offset = "0x1E46C8C", VA = "0x1E46C8C")]
		private static extern RESULT FMOD_Studio_System_GetEventByID(IntPtr system, ref Guid id, out IntPtr _event);

		[PreserveSig]
		[Token(Token = "0x60004DD")]
		[Address(RVA = "0x1E46D50", Offset = "0x1E46D50", VA = "0x1E46D50")]
		private static extern RESULT FMOD_Studio_System_GetBusByID(IntPtr system, ref Guid id, out IntPtr bus);

		[PreserveSig]
		[Token(Token = "0x60004DE")]
		[Address(RVA = "0x1E46E14", Offset = "0x1E46E14", VA = "0x1E46E14")]
		private static extern RESULT FMOD_Studio_System_GetVCAByID(IntPtr system, ref Guid id, out IntPtr vca);

		[PreserveSig]
		[Token(Token = "0x60004DF")]
		[Address(RVA = "0x1E46ED8", Offset = "0x1E46ED8", VA = "0x1E46ED8")]
		private static extern RESULT FMOD_Studio_System_GetBankByID(IntPtr system, ref Guid id, out IntPtr bank);

		[PreserveSig]
		[Token(Token = "0x60004E0")]
		[Address(RVA = "0x1E47104", Offset = "0x1E47104", VA = "0x1E47104")]
		private static extern RESULT FMOD_Studio_System_GetSoundInfo(IntPtr system, byte[] key, out SOUND_INFO info);

		[PreserveSig]
		[Token(Token = "0x60004E1")]
		[Address(RVA = "0x1E471FC", Offset = "0x1E471FC", VA = "0x1E471FC")]
		private static extern RESULT FMOD_Studio_System_GetParameterDescriptionByName(IntPtr system, byte[] name, out PARAMETER_DESCRIPTION parameter);

		[PreserveSig]
		[Token(Token = "0x60004E2")]
		[Address(RVA = "0x1E472A4", Offset = "0x1E472A4", VA = "0x1E472A4")]
		private static extern RESULT FMOD_Studio_System_GetParameterDescriptionByID(IntPtr system, PARAMETER_ID id, out PARAMETER_DESCRIPTION parameter);

		[PreserveSig]
		[Token(Token = "0x60004E3")]
		[Address(RVA = "0x1E4736C", Offset = "0x1E4736C", VA = "0x1E4736C")]
		private static extern RESULT FMOD_Studio_System_GetParameterByID(IntPtr system, PARAMETER_ID id, out float value, out float finalvalue);

		[PreserveSig]
		[Token(Token = "0x60004E4")]
		[Address(RVA = "0x1E47414", Offset = "0x1E47414", VA = "0x1E47414")]
		private static extern RESULT FMOD_Studio_System_SetParameterByID(IntPtr system, PARAMETER_ID id, float value, bool ignoreseekspeed);

		[PreserveSig]
		[Token(Token = "0x60004E5")]
		[Address(RVA = "0x1E474C8", Offset = "0x1E474C8", VA = "0x1E474C8")]
		private static extern RESULT FMOD_Studio_System_SetParametersByIDs(IntPtr system, PARAMETER_ID[] ids, float[] values, int count, bool ignoreseekspeed);

		[PreserveSig]
		[Token(Token = "0x60004E6")]
		[Address(RVA = "0x1E47748", Offset = "0x1E47748", VA = "0x1E47748")]
		private static extern RESULT FMOD_Studio_System_GetParameterByName(IntPtr system, byte[] name, out float value, out float finalvalue);

		[PreserveSig]
		[Token(Token = "0x60004E7")]
		[Address(RVA = "0x1E47994", Offset = "0x1E47994", VA = "0x1E47994")]
		private static extern RESULT FMOD_Studio_System_SetParameterByName(IntPtr system, byte[] name, float value, bool ignoreseekspeed);

		[PreserveSig]
		[Token(Token = "0x60004E8")]
		[Address(RVA = "0x1E47BD8", Offset = "0x1E47BD8", VA = "0x1E47BD8")]
		private static extern RESULT FMOD_Studio_System_LookupID(IntPtr system, byte[] path, out Guid id);

		[PreserveSig]
		[Token(Token = "0x60004E9")]
		[Address(RVA = "0x1E47F04", Offset = "0x1E47F04", VA = "0x1E47F04")]
		private static extern RESULT FMOD_Studio_System_LookupPath(IntPtr system, ref Guid id, IntPtr path, int size, out int retrieved);

		[PreserveSig]
		[Token(Token = "0x60004EA")]
		[Address(RVA = "0x1E47FBC", Offset = "0x1E47FBC", VA = "0x1E47FBC")]
		private static extern RESULT FMOD_Studio_System_GetNumListeners(IntPtr system, out int numlisteners);

		[PreserveSig]
		[Token(Token = "0x60004EB")]
		[Address(RVA = "0x1E48054", Offset = "0x1E48054", VA = "0x1E48054")]
		private static extern RESULT FMOD_Studio_System_SetNumListeners(IntPtr system, int numlisteners);

		[PreserveSig]
		[Token(Token = "0x60004EC")]
		[Address(RVA = "0x1E480EC", Offset = "0x1E480EC", VA = "0x1E480EC")]
		private static extern RESULT FMOD_Studio_System_GetListenerAttributes(IntPtr system, int listener, out ATTRIBUTES_3D attributes);

		[PreserveSig]
		[Token(Token = "0x60004ED")]
		[Address(RVA = "0x1E4818C", Offset = "0x1E4818C", VA = "0x1E4818C")]
		private static extern RESULT FMOD_Studio_System_SetListenerAttributes(IntPtr system, int listener, ref ATTRIBUTES_3D attributes);

		[PreserveSig]
		[Token(Token = "0x60004EE")]
		[Address(RVA = "0x1E4822C", Offset = "0x1E4822C", VA = "0x1E4822C")]
		private static extern RESULT FMOD_Studio_System_GetListenerWeight(IntPtr system, int listener, out float weight);

		[PreserveSig]
		[Token(Token = "0x60004EF")]
		[Address(RVA = "0x1E482CC", Offset = "0x1E482CC", VA = "0x1E482CC")]
		private static extern RESULT FMOD_Studio_System_SetListenerWeight(IntPtr system, int listener, float weight);

		[PreserveSig]
		[Token(Token = "0x60004F0")]
		[Address(RVA = "0x1E48508", Offset = "0x1E48508", VA = "0x1E48508")]
		private static extern RESULT FMOD_Studio_System_LoadBankFile(IntPtr system, byte[] filename, LOAD_BANK_FLAGS flags, out IntPtr bank);

		[PreserveSig]
		[Token(Token = "0x60004F1")]
		[Address(RVA = "0x1E48648", Offset = "0x1E48648", VA = "0x1E48648")]
		private static extern RESULT FMOD_Studio_System_LoadBankMemory(IntPtr system, IntPtr buffer, int length, LOAD_MEMORY_MODE mode, LOAD_BANK_FLAGS flags, out IntPtr bank);

		[PreserveSig]
		[Token(Token = "0x60004F2")]
		[Address(RVA = "0x1E487F0", Offset = "0x1E487F0", VA = "0x1E487F0")]
		private static extern RESULT FMOD_Studio_System_LoadBankCustom(IntPtr system, ref BANK_INFO info, LOAD_BANK_FLAGS flags, out IntPtr bank);

		[PreserveSig]
		[Token(Token = "0x60004F3")]
		[Address(RVA = "0x1E48904", Offset = "0x1E48904", VA = "0x1E48904")]
		private static extern RESULT FMOD_Studio_System_UnloadAll(IntPtr system);

		[PreserveSig]
		[Token(Token = "0x60004F4")]
		[Address(RVA = "0x1E4898C", Offset = "0x1E4898C", VA = "0x1E4898C")]
		private static extern RESULT FMOD_Studio_System_FlushCommands(IntPtr system);

		[PreserveSig]
		[Token(Token = "0x60004F5")]
		[Address(RVA = "0x1E48A14", Offset = "0x1E48A14", VA = "0x1E48A14")]
		private static extern RESULT FMOD_Studio_System_FlushSampleLoading(IntPtr system);

		[PreserveSig]
		[Token(Token = "0x60004F6")]
		[Address(RVA = "0x1E48C28", Offset = "0x1E48C28", VA = "0x1E48C28")]
		private static extern RESULT FMOD_Studio_System_StartCommandCapture(IntPtr system, byte[] filename, COMMANDCAPTURE_FLAGS flags);

		[PreserveSig]
		[Token(Token = "0x60004F7")]
		[Address(RVA = "0x1E48CD0", Offset = "0x1E48CD0", VA = "0x1E48CD0")]
		private static extern RESULT FMOD_Studio_System_StopCommandCapture(IntPtr system);

		[PreserveSig]
		[Token(Token = "0x60004F8")]
		[Address(RVA = "0x1E48EEC", Offset = "0x1E48EEC", VA = "0x1E48EEC")]
		private static extern RESULT FMOD_Studio_System_LoadCommandReplay(IntPtr system, byte[] filename, COMMANDREPLAY_FLAGS flags, out IntPtr replay);

		[PreserveSig]
		[Token(Token = "0x60004F9")]
		[Address(RVA = "0x1E48FA4", Offset = "0x1E48FA4", VA = "0x1E48FA4")]
		private static extern RESULT FMOD_Studio_System_GetBankCount(IntPtr system, out int count);

		[PreserveSig]
		[Token(Token = "0x60004FA")]
		[Address(RVA = "0x1E4918C", Offset = "0x1E4918C", VA = "0x1E4918C")]
		private static extern RESULT FMOD_Studio_System_GetBankList(IntPtr system, IntPtr[] array, int capacity, out int count);

		[PreserveSig]
		[Token(Token = "0x60004FB")]
		[Address(RVA = "0x1E49244", Offset = "0x1E49244", VA = "0x1E49244")]
		private static extern RESULT FMOD_Studio_System_GetParameterDescriptionCount(IntPtr system, out int count);

		[PreserveSig]
		[Token(Token = "0x60004FC")]
		[Address(RVA = "0x1E493D0", Offset = "0x1E493D0", VA = "0x1E493D0")]
		private static extern RESULT FMOD_Studio_System_GetParameterDescriptionList(IntPtr system, [Out] PARAMETER_DESCRIPTION[] array, int capacity, out int count);

		[PreserveSig]
		[Token(Token = "0x60004FD")]
		[Address(RVA = "0x1E49528", Offset = "0x1E49528", VA = "0x1E49528")]
		private static extern RESULT FMOD_Studio_System_GetCPUUsage(IntPtr system, out CPU_USAGE usage);

		[PreserveSig]
		[Token(Token = "0x60004FE")]
		[Address(RVA = "0x1E495C0", Offset = "0x1E495C0", VA = "0x1E495C0")]
		private static extern RESULT FMOD_Studio_System_GetBufferUsage(IntPtr system, out BUFFER_USAGE usage);

		[PreserveSig]
		[Token(Token = "0x60004FF")]
		[Address(RVA = "0x1E49658", Offset = "0x1E49658", VA = "0x1E49658")]
		private static extern RESULT FMOD_Studio_System_ResetBufferUsage(IntPtr system);

		[PreserveSig]
		[Token(Token = "0x6000500")]
		[Address(RVA = "0x1E496E0", Offset = "0x1E496E0", VA = "0x1E496E0")]
		private static extern RESULT FMOD_Studio_System_SetCallback(IntPtr system, SYSTEM_CALLBACK callback, SYSTEM_CALLBACK_TYPE callbackmask);

		[PreserveSig]
		[Token(Token = "0x6000501")]
		[Address(RVA = "0x1E49788", Offset = "0x1E49788", VA = "0x1E49788")]
		private static extern RESULT FMOD_Studio_System_GetUserData(IntPtr system, out IntPtr userdata);

		[PreserveSig]
		[Token(Token = "0x6000502")]
		[Address(RVA = "0x1E49820", Offset = "0x1E49820", VA = "0x1E49820")]
		private static extern RESULT FMOD_Studio_System_SetUserData(IntPtr system, IntPtr userdata);

		[PreserveSig]
		[Token(Token = "0x6000503")]
		[Address(RVA = "0x1E498B8", Offset = "0x1E498B8", VA = "0x1E498B8")]
		private static extern RESULT FMOD_Studio_System_GetMemoryUsage(IntPtr system, out MEMORY_USAGE memoryusage);

		[Token(Token = "0x6000504")]
		[Address(RVA = "0x1E499D0", Offset = "0x1E499D0", VA = "0x1E499D0")]
		public bool hasHandle()
		{
			return default(bool);
		}

		[Token(Token = "0x6000505")]
		[Address(RVA = "0x1E49A18", Offset = "0x1E49A18", VA = "0x1E49A18")]
		public void clearHandle()
		{
		}

		[Token(Token = "0x6000506")]
		[Address(RVA = "0x1E49A58", Offset = "0x1E49A58", VA = "0x1E49A58")]
		public bool isValid()
		{
			return default(bool);
		}
	}
	[Token(Token = "0x20000E7")]
	public struct EventDescription
	{
		[Token(Token = "0x40004F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public IntPtr handle;

		[Token(Token = "0x6000507")]
		[Address(RVA = "0xC2D9B8", Offset = "0xC2D9B8", VA = "0xC2D9B8")]
		public RESULT getID(out Guid id)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000508")]
		[Address(RVA = "0xC2DA50", Offset = "0xC2DA50", VA = "0xC2DA50")]
		public RESULT getPath(out string path)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000509")]
		[Address(RVA = "0xC2DD80", Offset = "0xC2DD80", VA = "0xC2DD80")]
		public RESULT getParameterDescriptionCount(out int count)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600050A")]
		[Address(RVA = "0xC2DE18", Offset = "0xC2DE18", VA = "0xC2DE18")]
		public RESULT getParameterDescriptionByIndex(int index, out PARAMETER_DESCRIPTION parameter)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600050B")]
		[Address(RVA = "0xC2DEB8", Offset = "0xC2DEB8", VA = "0xC2DEB8")]
		public RESULT getParameterDescriptionByName(string name, out PARAMETER_DESCRIPTION parameter)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600050C")]
		[Address(RVA = "0xC2E0F4", Offset = "0xC2E0F4", VA = "0xC2E0F4")]
		public RESULT getParameterDescriptionByID(PARAMETER_ID id, out PARAMETER_DESCRIPTION parameter)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600050D")]
		[Address(RVA = "0xC2E194", Offset = "0xC2E194", VA = "0xC2E194")]
		public RESULT getUserPropertyCount(out int count)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600050E")]
		[Address(RVA = "0xC2E22C", Offset = "0xC2E22C", VA = "0xC2E22C")]
		public RESULT getUserPropertyByIndex(int index, out USER_PROPERTY property)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600050F")]
		[Address(RVA = "0xC2E318", Offset = "0xC2E318", VA = "0xC2E318")]
		public RESULT getUserProperty(string name, out USER_PROPERTY property)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000510")]
		[Address(RVA = "0xC2E5A0", Offset = "0xC2E5A0", VA = "0xC2E5A0")]
		public RESULT getLength(out int length)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000511")]
		[Address(RVA = "0xC2E638", Offset = "0xC2E638", VA = "0xC2E638")]
		public RESULT getMinimumDistance(out float distance)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000512")]
		[Address(RVA = "0xC2E6D0", Offset = "0xC2E6D0", VA = "0xC2E6D0")]
		public RESULT getMaximumDistance(out float distance)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000513")]
		[Address(RVA = "0xC2E768", Offset = "0xC2E768", VA = "0xC2E768")]
		public RESULT getSoundSize(out float size)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000514")]
		[Address(RVA = "0xC2E800", Offset = "0xC2E800", VA = "0xC2E800")]
		public RESULT isSnapshot(out bool snapshot)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000515")]
		[Address(RVA = "0xC2E8AC", Offset = "0xC2E8AC", VA = "0xC2E8AC")]
		public RESULT isOneshot(out bool oneshot)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000516")]
		[Address(RVA = "0xC2E958", Offset = "0xC2E958", VA = "0xC2E958")]
		public RESULT isStream(out bool isStream)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000517")]
		[Address(RVA = "0xC2EA04", Offset = "0xC2EA04", VA = "0xC2EA04")]
		public RESULT is3D(out bool is3D)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000518")]
		[Address(RVA = "0xC2EAB0", Offset = "0xC2EAB0", VA = "0xC2EAB0")]
		public RESULT hasCue(out bool cue)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000519")]
		[Address(RVA = "0xC2EB5C", Offset = "0xC2EB5C", VA = "0xC2EB5C")]
		public RESULT createInstance(out EventInstance instance)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600051A")]
		[Address(RVA = "0xC2EBF4", Offset = "0xC2EBF4", VA = "0xC2EBF4")]
		public RESULT getInstanceCount(out int count)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600051B")]
		[Address(RVA = "0xC2EC8C", Offset = "0xC2EC8C", VA = "0xC2EC8C")]
		public RESULT getInstanceList(out EventInstance[] array)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600051C")]
		[Address(RVA = "0xC2EE94", Offset = "0xC2EE94", VA = "0xC2EE94")]
		public RESULT loadSampleData()
		{
			return default(RESULT);
		}

		[Token(Token = "0x600051D")]
		[Address(RVA = "0xC2EF1C", Offset = "0xC2EF1C", VA = "0xC2EF1C")]
		public RESULT unloadSampleData()
		{
			return default(RESULT);
		}

		[Token(Token = "0x600051E")]
		[Address(RVA = "0xC2EFA4", Offset = "0xC2EFA4", VA = "0xC2EFA4")]
		public RESULT getSampleLoadingState(out LOADING_STATE state)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600051F")]
		[Address(RVA = "0xC2F03C", Offset = "0xC2F03C", VA = "0xC2F03C")]
		public RESULT releaseAllInstances()
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000520")]
		[Address(RVA = "0xC2F0C4", Offset = "0xC2F0C4", VA = "0xC2F0C4")]
		public RESULT setCallback(EVENT_CALLBACK callback, EVENT_CALLBACK_TYPE callbackmask = EVENT_CALLBACK_TYPE.ALL)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000521")]
		[Address(RVA = "0xC2F16C", Offset = "0xC2F16C", VA = "0xC2F16C")]
		public RESULT getUserData(out IntPtr userdata)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000522")]
		[Address(RVA = "0xC2F204", Offset = "0xC2F204", VA = "0xC2F204")]
		public RESULT setUserData(IntPtr userdata)
		{
			return default(RESULT);
		}

		[PreserveSig]
		[Token(Token = "0x6000523")]
		[Address(RVA = "0xC2F29C", Offset = "0xC2F29C", VA = "0xC2F29C")]
		private static extern bool FMOD_Studio_EventDescription_IsValid(IntPtr eventdescription);

		[PreserveSig]
		[Token(Token = "0x6000524")]
		[Address(RVA = "0xC2D9C0", Offset = "0xC2D9C0", VA = "0xC2D9C0")]
		private static extern RESULT FMOD_Studio_EventDescription_GetID(IntPtr eventdescription, out Guid id);

		[PreserveSig]
		[Token(Token = "0x6000525")]
		[Address(RVA = "0xC2DCD8", Offset = "0xC2DCD8", VA = "0xC2DCD8")]
		private static extern RESULT FMOD_Studio_EventDescription_GetPath(IntPtr eventdescription, IntPtr path, int size, out int retrieved);

		[PreserveSig]
		[Token(Token = "0x6000526")]
		[Address(RVA = "0xC2DD88", Offset = "0xC2DD88", VA = "0xC2DD88")]
		private static extern RESULT FMOD_Studio_EventDescription_GetParameterDescriptionCount(IntPtr eventdescription, out int count);

		[PreserveSig]
		[Token(Token = "0x6000527")]
		[Address(RVA = "0xC2DE20", Offset = "0xC2DE20", VA = "0xC2DE20")]
		private static extern RESULT FMOD_Studio_EventDescription_GetParameterDescriptionByIndex(IntPtr eventdescription, int index, out PARAMETER_DESCRIPTION parameter);

		[PreserveSig]
		[Token(Token = "0x6000528")]
		[Address(RVA = "0xC2E054", Offset = "0xC2E054", VA = "0xC2E054")]
		private static extern RESULT FMOD_Studio_EventDescription_GetParameterDescriptionByName(IntPtr eventdescription, byte[] name, out PARAMETER_DESCRIPTION parameter);

		[PreserveSig]
		[Token(Token = "0x6000529")]
		[Address(RVA = "0xC2E0FC", Offset = "0xC2E0FC", VA = "0xC2E0FC")]
		private static extern RESULT FMOD_Studio_EventDescription_GetParameterDescriptionByID(IntPtr eventdescription, PARAMETER_ID id, out PARAMETER_DESCRIPTION parameter);

		[PreserveSig]
		[Token(Token = "0x600052A")]
		[Address(RVA = "0xC2E19C", Offset = "0xC2E19C", VA = "0xC2E19C")]
		private static extern RESULT FMOD_Studio_EventDescription_GetUserPropertyCount(IntPtr eventdescription, out int count);

		[PreserveSig]
		[Token(Token = "0x600052B")]
		[Address(RVA = "0xC2E234", Offset = "0xC2E234", VA = "0xC2E234")]
		private static extern RESULT FMOD_Studio_EventDescription_GetUserPropertyByIndex(IntPtr eventdescription, int index, out USER_PROPERTY property);

		[PreserveSig]
		[Token(Token = "0x600052C")]
		[Address(RVA = "0xC2E4B4", Offset = "0xC2E4B4", VA = "0xC2E4B4")]
		private static extern RESULT FMOD_Studio_EventDescription_GetUserProperty(IntPtr eventdescription, byte[] name, out USER_PROPERTY property);

		[PreserveSig]
		[Token(Token = "0x600052D")]
		[Address(RVA = "0xC2E5A8", Offset = "0xC2E5A8", VA = "0xC2E5A8")]
		private static extern RESULT FMOD_Studio_EventDescription_GetLength(IntPtr eventdescription, out int length);

		[PreserveSig]
		[Token(Token = "0x600052E")]
		[Address(RVA = "0xC2E640", Offset = "0xC2E640", VA = "0xC2E640")]
		private static extern RESULT FMOD_Studio_EventDescription_GetMinimumDistance(IntPtr eventdescription, out float distance);

		[PreserveSig]
		[Token(Token = "0x600052F")]
		[Address(RVA = "0xC2E6D8", Offset = "0xC2E6D8", VA = "0xC2E6D8")]
		private static extern RESULT FMOD_Studio_EventDescription_GetMaximumDistance(IntPtr eventdescription, out float distance);

		[PreserveSig]
		[Token(Token = "0x6000530")]
		[Address(RVA = "0xC2E770", Offset = "0xC2E770", VA = "0xC2E770")]
		private static extern RESULT FMOD_Studio_EventDescription_GetSoundSize(IntPtr eventdescription, out float size);

		[PreserveSig]
		[Token(Token = "0x6000531")]
		[Address(RVA = "0xC2E808", Offset = "0xC2E808", VA = "0xC2E808")]
		private static extern RESULT FMOD_Studio_EventDescription_IsSnapshot(IntPtr eventdescription, out bool snapshot);

		[PreserveSig]
		[Token(Token = "0x6000532")]
		[Address(RVA = "0xC2E8B4", Offset = "0xC2E8B4", VA = "0xC2E8B4")]
		private static extern RESULT FMOD_Studio_EventDescription_IsOneshot(IntPtr eventdescription, out bool oneshot);

		[PreserveSig]
		[Token(Token = "0x6000533")]
		[Address(RVA = "0xC2E960", Offset = "0xC2E960", VA = "0xC2E960")]
		private static extern RESULT FMOD_Studio_EventDescription_IsStream(IntPtr eventdescription, out bool isStream);

		[PreserveSig]
		[Token(Token = "0x6000534")]
		[Address(RVA = "0xC2EA0C", Offset = "0xC2EA0C", VA = "0xC2EA0C")]
		private static extern RESULT FMOD_Studio_EventDescription_Is3D(IntPtr eventdescription, out bool is3D);

		[PreserveSig]
		[Token(Token = "0x6000535")]
		[Address(RVA = "0xC2EAB8", Offset = "0xC2EAB8", VA = "0xC2EAB8")]
		private static extern RESULT FMOD_Studio_EventDescription_HasCue(IntPtr eventdescription, out bool cue);

		[PreserveSig]
		[Token(Token = "0x6000536")]
		[Address(RVA = "0xC2EB64", Offset = "0xC2EB64", VA = "0xC2EB64")]
		private static extern RESULT FMOD_Studio_EventDescription_CreateInstance(IntPtr eventdescription, out IntPtr instance);

		[PreserveSig]
		[Token(Token = "0x6000537")]
		[Address(RVA = "0xC2EBFC", Offset = "0xC2EBFC", VA = "0xC2EBFC")]
		private static extern RESULT FMOD_Studio_EventDescription_GetInstanceCount(IntPtr eventdescription, out int count);

		[PreserveSig]
		[Token(Token = "0x6000538")]
		[Address(RVA = "0xC2EDE4", Offset = "0xC2EDE4", VA = "0xC2EDE4")]
		private static extern RESULT FMOD_Studio_EventDescription_GetInstanceList(IntPtr eventdescription, IntPtr[] array, int capacity, out int count);

		[PreserveSig]
		[Token(Token = "0x6000539")]
		[Address(RVA = "0xC2EE9C", Offset = "0xC2EE9C", VA = "0xC2EE9C")]
		private static extern RESULT FMOD_Studio_EventDescription_LoadSampleData(IntPtr eventdescription);

		[PreserveSig]
		[Token(Token = "0x600053A")]
		[Address(RVA = "0xC2EF24", Offset = "0xC2EF24", VA = "0xC2EF24")]
		private static extern RESULT FMOD_Studio_EventDescription_UnloadSampleData(IntPtr eventdescription);

		[PreserveSig]
		[Token(Token = "0x600053B")]
		[Address(RVA = "0xC2EFAC", Offset = "0xC2EFAC", VA = "0xC2EFAC")]
		private static extern RESULT FMOD_Studio_EventDescription_GetSampleLoadingState(IntPtr eventdescription, out LOADING_STATE state);

		[PreserveSig]
		[Token(Token = "0x600053C")]
		[Address(RVA = "0xC2F044", Offset = "0xC2F044", VA = "0xC2F044")]
		private static extern RESULT FMOD_Studio_EventDescription_ReleaseAllInstances(IntPtr eventdescription);

		[PreserveSig]
		[Token(Token = "0x600053D")]
		[Address(RVA = "0xC2F0CC", Offset = "0xC2F0CC", VA = "0xC2F0CC")]
		private static extern RESULT FMOD_Studio_EventDescription_SetCallback(IntPtr eventdescription, EVENT_CALLBACK callback, EVENT_CALLBACK_TYPE callbackmask);

		[PreserveSig]
		[Token(Token = "0x600053E")]
		[Address(RVA = "0xC2F174", Offset = "0xC2F174", VA = "0xC2F174")]
		private static extern RESULT FMOD_Studio_EventDescription_GetUserData(IntPtr eventdescription, out IntPtr userdata);

		[PreserveSig]
		[Token(Token = "0x600053F")]
		[Address(RVA = "0xC2F20C", Offset = "0xC2F20C", VA = "0xC2F20C")]
		private static extern RESULT FMOD_Studio_EventDescription_SetUserData(IntPtr eventdescription, IntPtr userdata);

		[Token(Token = "0x6000540")]
		[Address(RVA = "0xC2F324", Offset = "0xC2F324", VA = "0xC2F324")]
		public bool hasHandle()
		{
			return default(bool);
		}

		[Token(Token = "0x6000541")]
		[Address(RVA = "0xC2F36C", Offset = "0xC2F36C", VA = "0xC2F36C")]
		public void clearHandle()
		{
		}

		[Token(Token = "0x6000542")]
		[Address(RVA = "0xC2F3AC", Offset = "0xC2F3AC", VA = "0xC2F3AC")]
		public bool isValid()
		{
			return default(bool);
		}
	}
	[Token(Token = "0x20000E8")]
	public struct EventInstance
	{
		[Token(Token = "0x40004F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public IntPtr handle;

		[Token(Token = "0x6000543")]
		[Address(RVA = "0xC2F678", Offset = "0xC2F678", VA = "0xC2F678")]
		public RESULT getDescription(out EventDescription description)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000544")]
		[Address(RVA = "0xC2F710", Offset = "0xC2F710", VA = "0xC2F710")]
		public RESULT getVolume(out float volume)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000545")]
		[Address(RVA = "0xC2F738", Offset = "0xC2F738", VA = "0xC2F738")]
		public RESULT getVolume(out float volume, out float finalvolume)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000546")]
		[Address(RVA = "0xC2F7D8", Offset = "0xC2F7D8", VA = "0xC2F7D8")]
		public RESULT setVolume(float volume)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000547")]
		[Address(RVA = "0xC2F870", Offset = "0xC2F870", VA = "0xC2F870")]
		public RESULT getPitch(out float pitch)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000548")]
		[Address(RVA = "0xC2F898", Offset = "0xC2F898", VA = "0xC2F898")]
		public RESULT getPitch(out float pitch, out float finalpitch)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000549")]
		[Address(RVA = "0xC2F938", Offset = "0xC2F938", VA = "0xC2F938")]
		public RESULT setPitch(float pitch)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600054A")]
		[Address(RVA = "0xC2F9D0", Offset = "0xC2F9D0", VA = "0xC2F9D0")]
		public RESULT get3DAttributes(out ATTRIBUTES_3D attributes)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600054B")]
		[Address(RVA = "0xC2FA68", Offset = "0xC2FA68", VA = "0xC2FA68")]
		public RESULT set3DAttributes(ATTRIBUTES_3D attributes)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600054C")]
		[Address(RVA = "0xC2FB00", Offset = "0xC2FB00", VA = "0xC2FB00")]
		public RESULT getListenerMask(out uint mask)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600054D")]
		[Address(RVA = "0xC2FB98", Offset = "0xC2FB98", VA = "0xC2FB98")]
		public RESULT setListenerMask(uint mask)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600054E")]
		[Address(RVA = "0xC2FC30", Offset = "0xC2FC30", VA = "0xC2FC30")]
		public RESULT getProperty(EVENT_PROPERTY index, out float value)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600054F")]
		[Address(RVA = "0xC2FCD0", Offset = "0xC2FCD0", VA = "0xC2FCD0")]
		public RESULT setProperty(EVENT_PROPERTY index, float value)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000550")]
		[Address(RVA = "0xC2FD78", Offset = "0xC2FD78", VA = "0xC2FD78")]
		public RESULT getReverbLevel(int index, out float level)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000551")]
		[Address(RVA = "0xC2FE18", Offset = "0xC2FE18", VA = "0xC2FE18")]
		public RESULT setReverbLevel(int index, float level)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000552")]
		[Address(RVA = "0xC2FEC0", Offset = "0xC2FEC0", VA = "0xC2FEC0")]
		public RESULT getPaused(out bool paused)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000553")]
		[Address(RVA = "0xC2FF6C", Offset = "0xC2FF6C", VA = "0xC2FF6C")]
		public RESULT setPaused(bool paused)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000554")]
		[Address(RVA = "0xC30008", Offset = "0xC30008", VA = "0xC30008")]
		public RESULT start()
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000555")]
		[Address(RVA = "0xC30090", Offset = "0xC30090", VA = "0xC30090")]
		public RESULT stop(STOP_MODE mode)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000556")]
		[Address(RVA = "0xC30128", Offset = "0xC30128", VA = "0xC30128")]
		public RESULT getTimelinePosition(out int position)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000557")]
		[Address(RVA = "0xC301C0", Offset = "0xC301C0", VA = "0xC301C0")]
		public RESULT setTimelinePosition(int position)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000558")]
		[Address(RVA = "0xC30258", Offset = "0xC30258", VA = "0xC30258")]
		public RESULT getPlaybackState(out PLAYBACK_STATE state)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000559")]
		[Address(RVA = "0xC302F0", Offset = "0xC302F0", VA = "0xC302F0")]
		public RESULT getChannelGroup(out ChannelGroup group)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600055A")]
		[Address(RVA = "0xC30388", Offset = "0xC30388", VA = "0xC30388")]
		public RESULT release()
		{
			return default(RESULT);
		}

		[Token(Token = "0x600055B")]
		[Address(RVA = "0xC30410", Offset = "0xC30410", VA = "0xC30410")]
		public RESULT isVirtual(out bool virtualstate)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600055C")]
		[Address(RVA = "0xC304BC", Offset = "0xC304BC", VA = "0xC304BC")]
		public RESULT getParameterByID(PARAMETER_ID id, out float value)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600055D")]
		[Address(RVA = "0xC304E4", Offset = "0xC304E4", VA = "0xC304E4")]
		public RESULT getParameterByID(PARAMETER_ID id, out float value, out float finalvalue)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600055E")]
		[Address(RVA = "0xC30594", Offset = "0xC30594", VA = "0xC30594")]
		public RESULT setParameterByID(PARAMETER_ID id, float value, bool ignoreseekspeed = false)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600055F")]
		[Address(RVA = "0xC30648", Offset = "0xC30648", VA = "0xC30648")]
		public RESULT setParametersByIDs(PARAMETER_ID[] ids, float[] values, int count, bool ignoreseekspeed = false)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000560")]
		[Address(RVA = "0xC30714", Offset = "0xC30714", VA = "0xC30714")]
		public RESULT getParameterByName(string name, out float value)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000561")]
		[Address(RVA = "0xC30738", Offset = "0xC30738", VA = "0xC30738")]
		public RESULT getParameterByName(string name, out float value, out float finalvalue)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000562")]
		[Address(RVA = "0xC3098C", Offset = "0xC3098C", VA = "0xC3098C")]
		public RESULT setParameterByName(string name, float value, bool ignoreseekspeed = false)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000563")]
		[Address(RVA = "0xC30BE0", Offset = "0xC30BE0", VA = "0xC30BE0")]
		public RESULT triggerCue()
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000564")]
		[Address(RVA = "0xC30C68", Offset = "0xC30C68", VA = "0xC30C68")]
		public RESULT setCallback(EVENT_CALLBACK callback, EVENT_CALLBACK_TYPE callbackmask = EVENT_CALLBACK_TYPE.ALL)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000565")]
		[Address(RVA = "0xC30D10", Offset = "0xC30D10", VA = "0xC30D10")]
		public RESULT getUserData(out IntPtr userdata)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000566")]
		[Address(RVA = "0xC30DA8", Offset = "0xC30DA8", VA = "0xC30DA8")]
		public RESULT setUserData(IntPtr userdata)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000567")]
		[Address(RVA = "0xC30E40", Offset = "0xC30E40", VA = "0xC30E40")]
		public RESULT getCPUUsage(out uint exclusive, out uint inclusive)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000568")]
		[Address(RVA = "0xC30EE0", Offset = "0xC30EE0", VA = "0xC30EE0")]
		public RESULT getMemoryUsage(out MEMORY_USAGE memoryusage)
		{
			return default(RESULT);
		}

		[PreserveSig]
		[Token(Token = "0x6000569")]
		[Address(RVA = "0xC30F78", Offset = "0xC30F78", VA = "0xC30F78")]
		private static extern bool FMOD_Studio_EventInstance_IsValid(IntPtr _event);

		[PreserveSig]
		[Token(Token = "0x600056A")]
		[Address(RVA = "0xC2F680", Offset = "0xC2F680", VA = "0xC2F680")]
		private static extern RESULT FMOD_Studio_EventInstance_GetDescription(IntPtr _event, out IntPtr description);

		[PreserveSig]
		[Token(Token = "0x600056B")]
		[Address(RVA = "0xC2F740", Offset = "0xC2F740", VA = "0xC2F740")]
		private static extern RESULT FMOD_Studio_EventInstance_GetVolume(IntPtr _event, out float volume, out float finalvolume);

		[PreserveSig]
		[Token(Token = "0x600056C")]
		[Address(RVA = "0xC2F7E0", Offset = "0xC2F7E0", VA = "0xC2F7E0")]
		private static extern RESULT FMOD_Studio_EventInstance_SetVolume(IntPtr _event, float volume);

		[PreserveSig]
		[Token(Token = "0x600056D")]
		[Address(RVA = "0xC2F8A0", Offset = "0xC2F8A0", VA = "0xC2F8A0")]
		private static extern RESULT FMOD_Studio_EventInstance_GetPitch(IntPtr _event, out float pitch, out float finalpitch);

		[PreserveSig]
		[Token(Token = "0x600056E")]
		[Address(RVA = "0xC2F940", Offset = "0xC2F940", VA = "0xC2F940")]
		private static extern RESULT FMOD_Studio_EventInstance_SetPitch(IntPtr _event, float pitch);

		[PreserveSig]
		[Token(Token = "0x600056F")]
		[Address(RVA = "0xC2F9D8", Offset = "0xC2F9D8", VA = "0xC2F9D8")]
		private static extern RESULT FMOD_Studio_EventInstance_Get3DAttributes(IntPtr _event, out ATTRIBUTES_3D attributes);

		[PreserveSig]
		[Token(Token = "0x6000570")]
		[Address(RVA = "0xC2FA70", Offset = "0xC2FA70", VA = "0xC2FA70")]
		private static extern RESULT FMOD_Studio_EventInstance_Set3DAttributes(IntPtr _event, ref ATTRIBUTES_3D attributes);

		[PreserveSig]
		[Token(Token = "0x6000571")]
		[Address(RVA = "0xC2FB08", Offset = "0xC2FB08", VA = "0xC2FB08")]
		private static extern RESULT FMOD_Studio_EventInstance_GetListenerMask(IntPtr _event, out uint mask);

		[PreserveSig]
		[Token(Token = "0x6000572")]
		[Address(RVA = "0xC2FBA0", Offset = "0xC2FBA0", VA = "0xC2FBA0")]
		private static extern RESULT FMOD_Studio_EventInstance_SetListenerMask(IntPtr _event, uint mask);

		[PreserveSig]
		[Token(Token = "0x6000573")]
		[Address(RVA = "0xC2FC38", Offset = "0xC2FC38", VA = "0xC2FC38")]
		private static extern RESULT FMOD_Studio_EventInstance_GetProperty(IntPtr _event, EVENT_PROPERTY index, out float value);

		[PreserveSig]
		[Token(Token = "0x6000574")]
		[Address(RVA = "0xC2FCD8", Offset = "0xC2FCD8", VA = "0xC2FCD8")]
		private static extern RESULT FMOD_Studio_EventInstance_SetProperty(IntPtr _event, EVENT_PROPERTY index, float value);

		[PreserveSig]
		[Token(Token = "0x6000575")]
		[Address(RVA = "0xC2FD80", Offset = "0xC2FD80", VA = "0xC2FD80")]
		private static extern RESULT FMOD_Studio_EventInstance_GetReverbLevel(IntPtr _event, int index, out float level);

		[PreserveSig]
		[Token(Token = "0x6000576")]
		[Address(RVA = "0xC2FE20", Offset = "0xC2FE20", VA = "0xC2FE20")]
		private static extern RESULT FMOD_Studio_EventInstance_SetReverbLevel(IntPtr _event, int index, float level);

		[PreserveSig]
		[Token(Token = "0x6000577")]
		[Address(RVA = "0xC2FEC8", Offset = "0xC2FEC8", VA = "0xC2FEC8")]
		private static extern RESULT FMOD_Studio_EventInstance_GetPaused(IntPtr _event, out bool paused);

		[PreserveSig]
		[Token(Token = "0x6000578")]
		[Address(RVA = "0xC2FF78", Offset = "0xC2FF78", VA = "0xC2FF78")]
		private static extern RESULT FMOD_Studio_EventInstance_SetPaused(IntPtr _event, bool paused);

		[PreserveSig]
		[Token(Token = "0x6000579")]
		[Address(RVA = "0xC30010", Offset = "0xC30010", VA = "0xC30010")]
		private static extern RESULT FMOD_Studio_EventInstance_Start(IntPtr _event);

		[PreserveSig]
		[Token(Token = "0x600057A")]
		[Address(RVA = "0xC30098", Offset = "0xC30098", VA = "0xC30098")]
		private static extern RESULT FMOD_Studio_EventInstance_Stop(IntPtr _event, STOP_MODE mode);

		[PreserveSig]
		[Token(Token = "0x600057B")]
		[Address(RVA = "0xC30130", Offset = "0xC30130", VA = "0xC30130")]
		private static extern RESULT FMOD_Studio_EventInstance_GetTimelinePosition(IntPtr _event, out int position);

		[PreserveSig]
		[Token(Token = "0x600057C")]
		[Address(RVA = "0xC301C8", Offset = "0xC301C8", VA = "0xC301C8")]
		private static extern RESULT FMOD_Studio_EventInstance_SetTimelinePosition(IntPtr _event, int position);

		[PreserveSig]
		[Token(Token = "0x600057D")]
		[Address(RVA = "0xC30260", Offset = "0xC30260", VA = "0xC30260")]
		private static extern RESULT FMOD_Studio_EventInstance_GetPlaybackState(IntPtr _event, out PLAYBACK_STATE state);

		[PreserveSig]
		[Token(Token = "0x600057E")]
		[Address(RVA = "0xC302F8", Offset = "0xC302F8", VA = "0xC302F8")]
		private static extern RESULT FMOD_Studio_EventInstance_GetChannelGroup(IntPtr _event, out IntPtr group);

		[PreserveSig]
		[Token(Token = "0x600057F")]
		[Address(RVA = "0xC30390", Offset = "0xC30390", VA = "0xC30390")]
		private static extern RESULT FMOD_Studio_EventInstance_Release(IntPtr _event);

		[PreserveSig]
		[Token(Token = "0x6000580")]
		[Address(RVA = "0xC30418", Offset = "0xC30418", VA = "0xC30418")]
		private static extern RESULT FMOD_Studio_EventInstance_IsVirtual(IntPtr _event, out bool virtualstate);

		[PreserveSig]
		[Token(Token = "0x6000581")]
		[Address(RVA = "0xC308DC", Offset = "0xC308DC", VA = "0xC308DC")]
		private static extern RESULT FMOD_Studio_EventInstance_GetParameterByName(IntPtr _event, byte[] name, out float value, out float finalvalue);

		[PreserveSig]
		[Token(Token = "0x6000582")]
		[Address(RVA = "0xC30B30", Offset = "0xC30B30", VA = "0xC30B30")]
		private static extern RESULT FMOD_Studio_EventInstance_SetParameterByName(IntPtr _event, byte[] name, float value, bool ignoreseekspeed);

		[PreserveSig]
		[Token(Token = "0x6000583")]
		[Address(RVA = "0xC304EC", Offset = "0xC304EC", VA = "0xC304EC")]
		private static extern RESULT FMOD_Studio_EventInstance_GetParameterByID(IntPtr _event, PARAMETER_ID id, out float value, out float finalvalue);

		[PreserveSig]
		[Token(Token = "0x6000584")]
		[Address(RVA = "0xC305A0", Offset = "0xC305A0", VA = "0xC305A0")]
		private static extern RESULT FMOD_Studio_EventInstance_SetParameterByID(IntPtr _event, PARAMETER_ID id, float value, bool ignoreseekspeed);

		[PreserveSig]
		[Token(Token = "0x6000585")]
		[Address(RVA = "0xC30654", Offset = "0xC30654", VA = "0xC30654")]
		private static extern RESULT FMOD_Studio_EventInstance_SetParametersByIDs(IntPtr _event, PARAMETER_ID[] ids, float[] values, int count, bool ignoreseekspeed);

		[PreserveSig]
		[Token(Token = "0x6000586")]
		[Address(RVA = "0xC30BE8", Offset = "0xC30BE8", VA = "0xC30BE8")]
		private static extern RESULT FMOD_Studio_EventInstance_TriggerCue(IntPtr _event);

		[PreserveSig]
		[Token(Token = "0x6000587")]
		[Address(RVA = "0xC30C70", Offset = "0xC30C70", VA = "0xC30C70")]
		private static extern RESULT FMOD_Studio_EventInstance_SetCallback(IntPtr _event, EVENT_CALLBACK callback, EVENT_CALLBACK_TYPE callbackmask);

		[PreserveSig]
		[Token(Token = "0x6000588")]
		[Address(RVA = "0xC30D18", Offset = "0xC30D18", VA = "0xC30D18")]
		private static extern RESULT FMOD_Studio_EventInstance_GetUserData(IntPtr _event, out IntPtr userdata);

		[PreserveSig]
		[Token(Token = "0x6000589")]
		[Address(RVA = "0xC30DB0", Offset = "0xC30DB0", VA = "0xC30DB0")]
		private static extern RESULT FMOD_Studio_EventInstance_SetUserData(IntPtr _event, IntPtr userdata);

		[PreserveSig]
		[Token(Token = "0x600058A")]
		[Address(RVA = "0xC30E48", Offset = "0xC30E48", VA = "0xC30E48")]
		private static extern RESULT FMOD_Studio_EventInstance_GetCPUUsage(IntPtr _event, out uint exclusive, out uint inclusive);

		[PreserveSig]
		[Token(Token = "0x600058B")]
		[Address(RVA = "0xC30EE8", Offset = "0xC30EE8", VA = "0xC30EE8")]
		private static extern RESULT FMOD_Studio_EventInstance_GetMemoryUsage(IntPtr _event, out MEMORY_USAGE memoryusage);

		[Token(Token = "0x600058C")]
		[Address(RVA = "0xC31000", Offset = "0xC31000", VA = "0xC31000")]
		public bool hasHandle()
		{
			return default(bool);
		}

		[Token(Token = "0x600058D")]
		[Address(RVA = "0xC31048", Offset = "0xC31048", VA = "0xC31048")]
		public void clearHandle()
		{
		}

		[Token(Token = "0x600058E")]
		[Address(RVA = "0xC31088", Offset = "0xC31088", VA = "0xC31088")]
		public bool isValid()
		{
			return default(bool);
		}
	}
	[Token(Token = "0x20000E9")]
	public struct Bus
	{
		[Token(Token = "0x40004F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public IntPtr handle;

		[Token(Token = "0x600058F")]
		[Address(RVA = "0xC18464", Offset = "0xC18464", VA = "0xC18464")]
		public RESULT getID(out Guid id)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000590")]
		[Address(RVA = "0xC184FC", Offset = "0xC184FC", VA = "0xC184FC")]
		public RESULT getPath(out string path)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000591")]
		[Address(RVA = "0xC1882C", Offset = "0xC1882C", VA = "0xC1882C")]
		public RESULT getVolume(out float volume)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000592")]
		[Address(RVA = "0xC18854", Offset = "0xC18854", VA = "0xC18854")]
		public RESULT getVolume(out float volume, out float finalvolume)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000593")]
		[Address(RVA = "0xC188F4", Offset = "0xC188F4", VA = "0xC188F4")]
		public RESULT setVolume(float volume)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000594")]
		[Address(RVA = "0xC1898C", Offset = "0xC1898C", VA = "0xC1898C")]
		public RESULT getPaused(out bool paused)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000595")]
		[Address(RVA = "0xC18A38", Offset = "0xC18A38", VA = "0xC18A38")]
		public RESULT setPaused(bool paused)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000596")]
		[Address(RVA = "0xC18AD4", Offset = "0xC18AD4", VA = "0xC18AD4")]
		public RESULT getMute(out bool mute)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000597")]
		[Address(RVA = "0xC18B80", Offset = "0xC18B80", VA = "0xC18B80")]
		public RESULT setMute(bool mute)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000598")]
		[Address(RVA = "0xC18C1C", Offset = "0xC18C1C", VA = "0xC18C1C")]
		public RESULT stopAllEvents(STOP_MODE mode)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000599")]
		[Address(RVA = "0xC18CB4", Offset = "0xC18CB4", VA = "0xC18CB4")]
		public RESULT lockChannelGroup()
		{
			return default(RESULT);
		}

		[Token(Token = "0x600059A")]
		[Address(RVA = "0xC18D3C", Offset = "0xC18D3C", VA = "0xC18D3C")]
		public RESULT unlockChannelGroup()
		{
			return default(RESULT);
		}

		[Token(Token = "0x600059B")]
		[Address(RVA = "0xC18DC4", Offset = "0xC18DC4", VA = "0xC18DC4")]
		public RESULT getChannelGroup(out ChannelGroup group)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600059C")]
		[Address(RVA = "0xC18E5C", Offset = "0xC18E5C", VA = "0xC18E5C")]
		public RESULT getCPUUsage(out uint exclusive, out uint inclusive)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600059D")]
		[Address(RVA = "0xC18EFC", Offset = "0xC18EFC", VA = "0xC18EFC")]
		public RESULT getMemoryUsage(out MEMORY_USAGE memoryusage)
		{
			return default(RESULT);
		}

		[PreserveSig]
		[Token(Token = "0x600059E")]
		[Address(RVA = "0xC18F94", Offset = "0xC18F94", VA = "0xC18F94")]
		private static extern bool FMOD_Studio_Bus_IsValid(IntPtr bus);

		[PreserveSig]
		[Token(Token = "0x600059F")]
		[Address(RVA = "0xC1846C", Offset = "0xC1846C", VA = "0xC1846C")]
		private static extern RESULT FMOD_Studio_Bus_GetID(IntPtr bus, out Guid id);

		[PreserveSig]
		[Token(Token = "0x60005A0")]
		[Address(RVA = "0xC18784", Offset = "0xC18784", VA = "0xC18784")]
		private static extern RESULT FMOD_Studio_Bus_GetPath(IntPtr bus, IntPtr path, int size, out int retrieved);

		[PreserveSig]
		[Token(Token = "0x60005A1")]
		[Address(RVA = "0xC1885C", Offset = "0xC1885C", VA = "0xC1885C")]
		private static extern RESULT FMOD_Studio_Bus_GetVolume(IntPtr bus, out float volume, out float finalvolume);

		[PreserveSig]
		[Token(Token = "0x60005A2")]
		[Address(RVA = "0xC188FC", Offset = "0xC188FC", VA = "0xC188FC")]
		private static extern RESULT FMOD_Studio_Bus_SetVolume(IntPtr bus, float volume);

		[PreserveSig]
		[Token(Token = "0x60005A3")]
		[Address(RVA = "0xC18994", Offset = "0xC18994", VA = "0xC18994")]
		private static extern RESULT FMOD_Studio_Bus_GetPaused(IntPtr bus, out bool paused);

		[PreserveSig]
		[Token(Token = "0x60005A4")]
		[Address(RVA = "0xC18A44", Offset = "0xC18A44", VA = "0xC18A44")]
		private static extern RESULT FMOD_Studio_Bus_SetPaused(IntPtr bus, bool paused);

		[PreserveSig]
		[Token(Token = "0x60005A5")]
		[Address(RVA = "0xC18ADC", Offset = "0xC18ADC", VA = "0xC18ADC")]
		private static extern RESULT FMOD_Studio_Bus_GetMute(IntPtr bus, out bool mute);

		[PreserveSig]
		[Token(Token = "0x60005A6")]
		[Address(RVA = "0xC18B8C", Offset = "0xC18B8C", VA = "0xC18B8C")]
		private static extern RESULT FMOD_Studio_Bus_SetMute(IntPtr bus, bool mute);

		[PreserveSig]
		[Token(Token = "0x60005A7")]
		[Address(RVA = "0xC18C24", Offset = "0xC18C24", VA = "0xC18C24")]
		private static extern RESULT FMOD_Studio_Bus_StopAllEvents(IntPtr bus, STOP_MODE mode);

		[PreserveSig]
		[Token(Token = "0x60005A8")]
		[Address(RVA = "0xC18CBC", Offset = "0xC18CBC", VA = "0xC18CBC")]
		private static extern RESULT FMOD_Studio_Bus_LockChannelGroup(IntPtr bus);

		[PreserveSig]
		[Token(Token = "0x60005A9")]
		[Address(RVA = "0xC18D44", Offset = "0xC18D44", VA = "0xC18D44")]
		private static extern RESULT FMOD_Studio_Bus_UnlockChannelGroup(IntPtr bus);

		[PreserveSig]
		[Token(Token = "0x60005AA")]
		[Address(RVA = "0xC18DCC", Offset = "0xC18DCC", VA = "0xC18DCC")]
		private static extern RESULT FMOD_Studio_Bus_GetChannelGroup(IntPtr bus, out IntPtr group);

		[PreserveSig]
		[Token(Token = "0x60005AB")]
		[Address(RVA = "0xC18E64", Offset = "0xC18E64", VA = "0xC18E64")]
		private static extern RESULT FMOD_Studio_Bus_GetCPUUsage(IntPtr bus, out uint exclusive, out uint inclusive);

		[PreserveSig]
		[Token(Token = "0x60005AC")]
		[Address(RVA = "0xC18F04", Offset = "0xC18F04", VA = "0xC18F04")]
		private static extern RESULT FMOD_Studio_Bus_GetMemoryUsage(IntPtr bus, out MEMORY_USAGE memoryusage);

		[Token(Token = "0x60005AD")]
		[Address(RVA = "0xC1901C", Offset = "0xC1901C", VA = "0xC1901C")]
		public bool hasHandle()
		{
			return default(bool);
		}

		[Token(Token = "0x60005AE")]
		[Address(RVA = "0xC19064", Offset = "0xC19064", VA = "0xC19064")]
		public void clearHandle()
		{
		}

		[Token(Token = "0x60005AF")]
		[Address(RVA = "0xC190A4", Offset = "0xC190A4", VA = "0xC190A4")]
		public bool isValid()
		{
			return default(bool);
		}
	}
	[Token(Token = "0x20000EA")]
	public struct VCA
	{
		[Token(Token = "0x40004F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public IntPtr handle;

		[Token(Token = "0x60005B0")]
		[Address(RVA = "0x1E49F10", Offset = "0x1E49F10", VA = "0x1E49F10")]
		public RESULT getID(out Guid id)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60005B1")]
		[Address(RVA = "0x1E49FA8", Offset = "0x1E49FA8", VA = "0x1E49FA8")]
		public RESULT getPath(out string path)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60005B2")]
		[Address(RVA = "0x1E4A2D0", Offset = "0x1E4A2D0", VA = "0x1E4A2D0")]
		public RESULT getVolume(out float volume)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60005B3")]
		[Address(RVA = "0x1E4A2F8", Offset = "0x1E4A2F8", VA = "0x1E4A2F8")]
		public RESULT getVolume(out float volume, out float finalvolume)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60005B4")]
		[Address(RVA = "0x1E4A398", Offset = "0x1E4A398", VA = "0x1E4A398")]
		public RESULT setVolume(float volume)
		{
			return default(RESULT);
		}

		[PreserveSig]
		[Token(Token = "0x60005B5")]
		[Address(RVA = "0x1E4A430", Offset = "0x1E4A430", VA = "0x1E4A430")]
		private static extern bool FMOD_Studio_VCA_IsValid(IntPtr vca);

		[PreserveSig]
		[Token(Token = "0x60005B6")]
		[Address(RVA = "0x1E49F18", Offset = "0x1E49F18", VA = "0x1E49F18")]
		private static extern RESULT FMOD_Studio_VCA_GetID(IntPtr vca, out Guid id);

		[PreserveSig]
		[Token(Token = "0x60005B7")]
		[Address(RVA = "0x1E4A228", Offset = "0x1E4A228", VA = "0x1E4A228")]
		private static extern RESULT FMOD_Studio_VCA_GetPath(IntPtr vca, IntPtr path, int size, out int retrieved);

		[PreserveSig]
		[Token(Token = "0x60005B8")]
		[Address(RVA = "0x1E4A300", Offset = "0x1E4A300", VA = "0x1E4A300")]
		private static extern RESULT FMOD_Studio_VCA_GetVolume(IntPtr vca, out float volume, out float finalvolume);

		[PreserveSig]
		[Token(Token = "0x60005B9")]
		[Address(RVA = "0x1E4A3A0", Offset = "0x1E4A3A0", VA = "0x1E4A3A0")]
		private static extern RESULT FMOD_Studio_VCA_SetVolume(IntPtr vca, float volume);

		[Token(Token = "0x60005BA")]
		[Address(RVA = "0x1E4A4B8", Offset = "0x1E4A4B8", VA = "0x1E4A4B8")]
		public bool hasHandle()
		{
			return default(bool);
		}

		[Token(Token = "0x60005BB")]
		[Address(RVA = "0x1E4A500", Offset = "0x1E4A500", VA = "0x1E4A500")]
		public void clearHandle()
		{
		}

		[Token(Token = "0x60005BC")]
		[Address(RVA = "0x1E4A540", Offset = "0x1E4A540", VA = "0x1E4A540")]
		public bool isValid()
		{
			return default(bool);
		}
	}
	[Token(Token = "0x20000EB")]
	public struct Bank
	{
		[Token(Token = "0x40004F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public IntPtr handle;

		[Token(Token = "0x60005BD")]
		[Address(RVA = "0xC16930", Offset = "0xC16930", VA = "0xC16930")]
		public RESULT getID(out Guid id)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60005BE")]
		[Address(RVA = "0xC169C8", Offset = "0xC169C8", VA = "0xC169C8")]
		public RESULT getPath(out string path)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60005BF")]
		[Address(RVA = "0xC16CF8", Offset = "0xC16CF8", VA = "0xC16CF8")]
		public RESULT unload()
		{
			return default(RESULT);
		}

		[Token(Token = "0x60005C0")]
		[Address(RVA = "0xC16D80", Offset = "0xC16D80", VA = "0xC16D80")]
		public RESULT loadSampleData()
		{
			return default(RESULT);
		}

		[Token(Token = "0x60005C1")]
		[Address(RVA = "0xC16E08", Offset = "0xC16E08", VA = "0xC16E08")]
		public RESULT unloadSampleData()
		{
			return default(RESULT);
		}

		[Token(Token = "0x60005C2")]
		[Address(RVA = "0xC16E90", Offset = "0xC16E90", VA = "0xC16E90")]
		public RESULT getLoadingState(out LOADING_STATE state)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60005C3")]
		[Address(RVA = "0xC16F28", Offset = "0xC16F28", VA = "0xC16F28")]
		public RESULT getSampleLoadingState(out LOADING_STATE state)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60005C4")]
		[Address(RVA = "0xC16FC0", Offset = "0xC16FC0", VA = "0xC16FC0")]
		public RESULT getStringCount(out int count)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60005C5")]
		[Address(RVA = "0xC17058", Offset = "0xC17058", VA = "0xC17058")]
		public RESULT getStringInfo(int index, out Guid id, out string path)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60005C6")]
		[Address(RVA = "0xC173FC", Offset = "0xC173FC", VA = "0xC173FC")]
		public RESULT getEventCount(out int count)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60005C7")]
		[Address(RVA = "0xC17494", Offset = "0xC17494", VA = "0xC17494")]
		public RESULT getEventList(out EventDescription[] array)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60005C8")]
		[Address(RVA = "0xC1769C", Offset = "0xC1769C", VA = "0xC1769C")]
		public RESULT getBusCount(out int count)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60005C9")]
		[Address(RVA = "0xC17734", Offset = "0xC17734", VA = "0xC17734")]
		public RESULT getBusList(out Bus[] array)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60005CA")]
		[Address(RVA = "0xC1793C", Offset = "0xC1793C", VA = "0xC1793C")]
		public RESULT getVCACount(out int count)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60005CB")]
		[Address(RVA = "0xC179D4", Offset = "0xC179D4", VA = "0xC179D4")]
		public RESULT getVCAList(out VCA[] array)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60005CC")]
		[Address(RVA = "0xC17BDC", Offset = "0xC17BDC", VA = "0xC17BDC")]
		public RESULT getUserData(out IntPtr userdata)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60005CD")]
		[Address(RVA = "0xC17C74", Offset = "0xC17C74", VA = "0xC17C74")]
		public RESULT setUserData(IntPtr userdata)
		{
			return default(RESULT);
		}

		[PreserveSig]
		[Token(Token = "0x60005CE")]
		[Address(RVA = "0xC17D0C", Offset = "0xC17D0C", VA = "0xC17D0C")]
		private static extern bool FMOD_Studio_Bank_IsValid(IntPtr bank);

		[PreserveSig]
		[Token(Token = "0x60005CF")]
		[Address(RVA = "0xC16938", Offset = "0xC16938", VA = "0xC16938")]
		private static extern RESULT FMOD_Studio_Bank_GetID(IntPtr bank, out Guid id);

		[PreserveSig]
		[Token(Token = "0x60005D0")]
		[Address(RVA = "0xC16C50", Offset = "0xC16C50", VA = "0xC16C50")]
		private static extern RESULT FMOD_Studio_Bank_GetPath(IntPtr bank, IntPtr path, int size, out int retrieved);

		[PreserveSig]
		[Token(Token = "0x60005D1")]
		[Address(RVA = "0xC16D00", Offset = "0xC16D00", VA = "0xC16D00")]
		private static extern RESULT FMOD_Studio_Bank_Unload(IntPtr bank);

		[PreserveSig]
		[Token(Token = "0x60005D2")]
		[Address(RVA = "0xC16D88", Offset = "0xC16D88", VA = "0xC16D88")]
		private static extern RESULT FMOD_Studio_Bank_LoadSampleData(IntPtr bank);

		[PreserveSig]
		[Token(Token = "0x60005D3")]
		[Address(RVA = "0xC16E10", Offset = "0xC16E10", VA = "0xC16E10")]
		private static extern RESULT FMOD_Studio_Bank_UnloadSampleData(IntPtr bank);

		[PreserveSig]
		[Token(Token = "0x60005D4")]
		[Address(RVA = "0xC16E98", Offset = "0xC16E98", VA = "0xC16E98")]
		private static extern RESULT FMOD_Studio_Bank_GetLoadingState(IntPtr bank, out LOADING_STATE state);

		[PreserveSig]
		[Token(Token = "0x60005D5")]
		[Address(RVA = "0xC16F30", Offset = "0xC16F30", VA = "0xC16F30")]
		private static extern RESULT FMOD_Studio_Bank_GetSampleLoadingState(IntPtr bank, out LOADING_STATE state);

		[PreserveSig]
		[Token(Token = "0x60005D6")]
		[Address(RVA = "0xC16FC8", Offset = "0xC16FC8", VA = "0xC16FC8")]
		private static extern RESULT FMOD_Studio_Bank_GetStringCount(IntPtr bank, out int count);

		[PreserveSig]
		[Token(Token = "0x60005D7")]
		[Address(RVA = "0xC1733C", Offset = "0xC1733C", VA = "0xC1733C")]
		private static extern RESULT FMOD_Studio_Bank_GetStringInfo(IntPtr bank, int index, out Guid id, IntPtr path, int size, out int retrieved);

		[PreserveSig]
		[Token(Token = "0x60005D8")]
		[Address(RVA = "0xC17404", Offset = "0xC17404", VA = "0xC17404")]
		private static extern RESULT FMOD_Studio_Bank_GetEventCount(IntPtr bank, out int count);

		[PreserveSig]
		[Token(Token = "0x60005D9")]
		[Address(RVA = "0xC175EC", Offset = "0xC175EC", VA = "0xC175EC")]
		private static extern RESULT FMOD_Studio_Bank_GetEventList(IntPtr bank, IntPtr[] array, int capacity, out int count);

		[PreserveSig]
		[Token(Token = "0x60005DA")]
		[Address(RVA = "0xC176A4", Offset = "0xC176A4", VA = "0xC176A4")]
		private static extern RESULT FMOD_Studio_Bank_GetBusCount(IntPtr bank, out int count);

		[PreserveSig]
		[Token(Token = "0x60005DB")]
		[Address(RVA = "0xC1788C", Offset = "0xC1788C", VA = "0xC1788C")]
		private static extern RESULT FMOD_Studio_Bank_GetBusList(IntPtr bank, IntPtr[] array, int capacity, out int count);

		[PreserveSig]
		[Token(Token = "0x60005DC")]
		[Address(RVA = "0xC17944", Offset = "0xC17944", VA = "0xC17944")]
		private static extern RESULT FMOD_Studio_Bank_GetVCACount(IntPtr bank, out int count);

		[PreserveSig]
		[Token(Token = "0x60005DD")]
		[Address(RVA = "0xC17B2C", Offset = "0xC17B2C", VA = "0xC17B2C")]
		private static extern RESULT FMOD_Studio_Bank_GetVCAList(IntPtr bank, IntPtr[] array, int capacity, out int count);

		[PreserveSig]
		[Token(Token = "0x60005DE")]
		[Address(RVA = "0xC17BE4", Offset = "0xC17BE4", VA = "0xC17BE4")]
		private static extern RESULT FMOD_Studio_Bank_GetUserData(IntPtr bank, out IntPtr userdata);

		[PreserveSig]
		[Token(Token = "0x60005DF")]
		[Address(RVA = "0xC17C7C", Offset = "0xC17C7C", VA = "0xC17C7C")]
		private static extern RESULT FMOD_Studio_Bank_SetUserData(IntPtr bank, IntPtr userdata);

		[Token(Token = "0x60005E0")]
		[Address(RVA = "0xC17D94", Offset = "0xC17D94", VA = "0xC17D94")]
		public bool hasHandle()
		{
			return default(bool);
		}

		[Token(Token = "0x60005E1")]
		[Address(RVA = "0xC17DDC", Offset = "0xC17DDC", VA = "0xC17DDC")]
		public void clearHandle()
		{
		}

		[Token(Token = "0x60005E2")]
		[Address(RVA = "0xC17E1C", Offset = "0xC17E1C", VA = "0xC17E1C")]
		public bool isValid()
		{
			return default(bool);
		}
	}
	[Token(Token = "0x20000EC")]
	public struct CommandReplay
	{
		[Token(Token = "0x40004F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public IntPtr handle;

		[Token(Token = "0x60005E3")]
		[Address(RVA = "0xC2075C", Offset = "0xC2075C", VA = "0xC2075C")]
		public RESULT getSystem(out System system)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60005E4")]
		[Address(RVA = "0xC207F4", Offset = "0xC207F4", VA = "0xC207F4")]
		public RESULT getLength(out float length)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60005E5")]
		[Address(RVA = "0xC2088C", Offset = "0xC2088C", VA = "0xC2088C")]
		public RESULT getCommandCount(out int count)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60005E6")]
		[Address(RVA = "0xC20924", Offset = "0xC20924", VA = "0xC20924")]
		public RESULT getCommandInfo(int commandIndex, out COMMAND_INFO info)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60005E7")]
		[Address(RVA = "0xC209C4", Offset = "0xC209C4", VA = "0xC209C4")]
		public RESULT getCommandString(int commandIndex, out string buffer)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60005E8")]
		[Address(RVA = "0xC20D04", Offset = "0xC20D04", VA = "0xC20D04")]
		public RESULT getCommandAtTime(float time, out int commandIndex)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60005E9")]
		[Address(RVA = "0xC20DAC", Offset = "0xC20DAC", VA = "0xC20DAC")]
		public RESULT setBankPath(string bankPath)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60005EA")]
		[Address(RVA = "0xC20FD8", Offset = "0xC20FD8", VA = "0xC20FD8")]
		public RESULT start()
		{
			return default(RESULT);
		}

		[Token(Token = "0x60005EB")]
		[Address(RVA = "0xC21060", Offset = "0xC21060", VA = "0xC21060")]
		public RESULT stop()
		{
			return default(RESULT);
		}

		[Token(Token = "0x60005EC")]
		[Address(RVA = "0xC210E8", Offset = "0xC210E8", VA = "0xC210E8")]
		public RESULT seekToTime(float time)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60005ED")]
		[Address(RVA = "0xC21180", Offset = "0xC21180", VA = "0xC21180")]
		public RESULT seekToCommand(int commandIndex)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60005EE")]
		[Address(RVA = "0xC21218", Offset = "0xC21218", VA = "0xC21218")]
		public RESULT getPaused(out bool paused)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60005EF")]
		[Address(RVA = "0xC212C4", Offset = "0xC212C4", VA = "0xC212C4")]
		public RESULT setPaused(bool paused)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60005F0")]
		[Address(RVA = "0xC21360", Offset = "0xC21360", VA = "0xC21360")]
		public RESULT getPlaybackState(out PLAYBACK_STATE state)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60005F1")]
		[Address(RVA = "0xC213F8", Offset = "0xC213F8", VA = "0xC213F8")]
		public RESULT getCurrentCommand(out int commandIndex, out float currentTime)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60005F2")]
		[Address(RVA = "0xC21498", Offset = "0xC21498", VA = "0xC21498")]
		public RESULT release()
		{
			return default(RESULT);
		}

		[Token(Token = "0x60005F3")]
		[Address(RVA = "0xC21520", Offset = "0xC21520", VA = "0xC21520")]
		public RESULT setFrameCallback(COMMANDREPLAY_FRAME_CALLBACK callback)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60005F4")]
		[Address(RVA = "0xC215C0", Offset = "0xC215C0", VA = "0xC215C0")]
		public RESULT setLoadBankCallback(COMMANDREPLAY_LOAD_BANK_CALLBACK callback)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60005F5")]
		[Address(RVA = "0xC21660", Offset = "0xC21660", VA = "0xC21660")]
		public RESULT setCreateInstanceCallback(COMMANDREPLAY_CREATE_INSTANCE_CALLBACK callback)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60005F6")]
		[Address(RVA = "0xC21700", Offset = "0xC21700", VA = "0xC21700")]
		public RESULT getUserData(out IntPtr userdata)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60005F7")]
		[Address(RVA = "0xC21798", Offset = "0xC21798", VA = "0xC21798")]
		public RESULT setUserData(IntPtr userdata)
		{
			return default(RESULT);
		}

		[PreserveSig]
		[Token(Token = "0x60005F8")]
		[Address(RVA = "0xC21830", Offset = "0xC21830", VA = "0xC21830")]
		private static extern bool FMOD_Studio_CommandReplay_IsValid(IntPtr replay);

		[PreserveSig]
		[Token(Token = "0x60005F9")]
		[Address(RVA = "0xC20764", Offset = "0xC20764", VA = "0xC20764")]
		private static extern RESULT FMOD_Studio_CommandReplay_GetSystem(IntPtr replay, out IntPtr system);

		[PreserveSig]
		[Token(Token = "0x60005FA")]
		[Address(RVA = "0xC207FC", Offset = "0xC207FC", VA = "0xC207FC")]
		private static extern RESULT FMOD_Studio_CommandReplay_GetLength(IntPtr replay, out float length);

		[PreserveSig]
		[Token(Token = "0x60005FB")]
		[Address(RVA = "0xC20894", Offset = "0xC20894", VA = "0xC20894")]
		private static extern RESULT FMOD_Studio_CommandReplay_GetCommandCount(IntPtr replay, out int count);

		[PreserveSig]
		[Token(Token = "0x60005FC")]
		[Address(RVA = "0xC2092C", Offset = "0xC2092C", VA = "0xC2092C")]
		private static extern RESULT FMOD_Studio_CommandReplay_GetCommandInfo(IntPtr replay, int commandindex, out COMMAND_INFO info);

		[PreserveSig]
		[Token(Token = "0x60005FD")]
		[Address(RVA = "0xC20C5C", Offset = "0xC20C5C", VA = "0xC20C5C")]
		private static extern RESULT FMOD_Studio_CommandReplay_GetCommandString(IntPtr replay, int commandIndex, IntPtr buffer, int length);

		[PreserveSig]
		[Token(Token = "0x60005FE")]
		[Address(RVA = "0xC20D0C", Offset = "0xC20D0C", VA = "0xC20D0C")]
		private static extern RESULT FMOD_Studio_CommandReplay_GetCommandAtTime(IntPtr replay, float time, out int commandIndex);

		[PreserveSig]
		[Token(Token = "0x60005FF")]
		[Address(RVA = "0xC20F40", Offset = "0xC20F40", VA = "0xC20F40")]
		private static extern RESULT FMOD_Studio_CommandReplay_SetBankPath(IntPtr replay, byte[] bankPath);

		[PreserveSig]
		[Token(Token = "0x6000600")]
		[Address(RVA = "0xC20FE0", Offset = "0xC20FE0", VA = "0xC20FE0")]
		private static extern RESULT FMOD_Studio_CommandReplay_Start(IntPtr replay);

		[PreserveSig]
		[Token(Token = "0x6000601")]
		[Address(RVA = "0xC21068", Offset = "0xC21068", VA = "0xC21068")]
		private static extern RESULT FMOD_Studio_CommandReplay_Stop(IntPtr replay);

		[PreserveSig]
		[Token(Token = "0x6000602")]
		[Address(RVA = "0xC210F0", Offset = "0xC210F0", VA = "0xC210F0")]
		private static extern RESULT FMOD_Studio_CommandReplay_SeekToTime(IntPtr replay, float time);

		[PreserveSig]
		[Token(Token = "0x6000603")]
		[Address(RVA = "0xC21188", Offset = "0xC21188", VA = "0xC21188")]
		private static extern RESULT FMOD_Studio_CommandReplay_SeekToCommand(IntPtr replay, int commandIndex);

		[PreserveSig]
		[Token(Token = "0x6000604")]
		[Address(RVA = "0xC21220", Offset = "0xC21220", VA = "0xC21220")]
		private static extern RESULT FMOD_Studio_CommandReplay_GetPaused(IntPtr replay, out bool paused);

		[PreserveSig]
		[Token(Token = "0x6000605")]
		[Address(RVA = "0xC212D0", Offset = "0xC212D0", VA = "0xC212D0")]
		private static extern RESULT FMOD_Studio_CommandReplay_SetPaused(IntPtr replay, bool paused);

		[PreserveSig]
		[Token(Token = "0x6000606")]
		[Address(RVA = "0xC21368", Offset = "0xC21368", VA = "0xC21368")]
		private static extern RESULT FMOD_Studio_CommandReplay_GetPlaybackState(IntPtr replay, out PLAYBACK_STATE state);

		[PreserveSig]
		[Token(Token = "0x6000607")]
		[Address(RVA = "0xC21400", Offset = "0xC21400", VA = "0xC21400")]
		private static extern RESULT FMOD_Studio_CommandReplay_GetCurrentCommand(IntPtr replay, out int commandIndex, out float currentTime);

		[PreserveSig]
		[Token(Token = "0x6000608")]
		[Address(RVA = "0xC214A0", Offset = "0xC214A0", VA = "0xC214A0")]
		private static extern RESULT FMOD_Studio_CommandReplay_Release(IntPtr replay);

		[PreserveSig]
		[Token(Token = "0x6000609")]
		[Address(RVA = "0xC21528", Offset = "0xC21528", VA = "0xC21528")]
		private static extern RESULT FMOD_Studio_CommandReplay_SetFrameCallback(IntPtr replay, COMMANDREPLAY_FRAME_CALLBACK callback);

		[PreserveSig]
		[Token(Token = "0x600060A")]
		[Address(RVA = "0xC215C8", Offset = "0xC215C8", VA = "0xC215C8")]
		private static extern RESULT FMOD_Studio_CommandReplay_SetLoadBankCallback(IntPtr replay, COMMANDREPLAY_LOAD_BANK_CALLBACK callback);

		[PreserveSig]
		[Token(Token = "0x600060B")]
		[Address(RVA = "0xC21668", Offset = "0xC21668", VA = "0xC21668")]
		private static extern RESULT FMOD_Studio_CommandReplay_SetCreateInstanceCallback(IntPtr replay, COMMANDREPLAY_CREATE_INSTANCE_CALLBACK callback);

		[PreserveSig]
		[Token(Token = "0x600060C")]
		[Address(RVA = "0xC21708", Offset = "0xC21708", VA = "0xC21708")]
		private static extern RESULT FMOD_Studio_CommandReplay_GetUserData(IntPtr replay, out IntPtr userdata);

		[PreserveSig]
		[Token(Token = "0x600060D")]
		[Address(RVA = "0xC217A0", Offset = "0xC217A0", VA = "0xC217A0")]
		private static extern RESULT FMOD_Studio_CommandReplay_SetUserData(IntPtr replay, IntPtr userdata);

		[Token(Token = "0x600060E")]
		[Address(RVA = "0xC218B8", Offset = "0xC218B8", VA = "0xC218B8")]
		public bool hasHandle()
		{
			return default(bool);
		}

		[Token(Token = "0x600060F")]
		[Address(RVA = "0xC21900", Offset = "0xC21900", VA = "0xC21900")]
		public void clearHandle()
		{
		}

		[Token(Token = "0x6000610")]
		[Address(RVA = "0xC21940", Offset = "0xC21940", VA = "0xC21940")]
		public bool isValid()
		{
			return default(bool);
		}
	}
}
namespace FMODUnity
{
	[Token(Token = "0x20000ED")]
	public class BankRefAttribute : PropertyAttribute
	{
		[Token(Token = "0x6000611")]
		[Address(RVA = "0xC1845C", Offset = "0xC1845C", VA = "0xC1845C")]
		public BankRefAttribute()
		{
		}
	}
	[Token(Token = "0x20000EE")]
	public abstract class EventHandler : MonoBehaviour
	{
		[Token(Token = "0x40004F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string CollisionTag;

		[Token(Token = "0x6000612")]
		[Address(RVA = "0xC2F3E4", Offset = "0xC2F3E4", VA = "0xC2F3E4")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000613")]
		[Address(RVA = "0xC2F3F4", Offset = "0xC2F3F4", VA = "0xC2F3F4")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000614")]
		[Address(RVA = "0xC2F404", Offset = "0xC2F404", VA = "0xC2F404")]
		private void OnTriggerEnter(Collider other)
		{
		}

		[Token(Token = "0x6000615")]
		[Address(RVA = "0xC2F46C", Offset = "0xC2F46C", VA = "0xC2F46C")]
		private void OnTriggerExit(Collider other)
		{
		}

		[Token(Token = "0x6000616")]
		[Address(RVA = "0xC2F4D4", Offset = "0xC2F4D4", VA = "0xC2F4D4")]
		private void OnTriggerEnter2D(Collider2D other)
		{
		}

		[Token(Token = "0x6000617")]
		[Address(RVA = "0xC2F53C", Offset = "0xC2F53C", VA = "0xC2F53C")]
		private void OnTriggerExit2D(Collider2D other)
		{
		}

		[Token(Token = "0x6000618")]
		[Address(RVA = "0xC2F5A4", Offset = "0xC2F5A4", VA = "0xC2F5A4")]
		private void OnCollisionEnter()
		{
		}

		[Token(Token = "0x6000619")]
		[Address(RVA = "0xC2F5B4", Offset = "0xC2F5B4", VA = "0xC2F5B4")]
		private void OnCollisionExit()
		{
		}

		[Token(Token = "0x600061A")]
		[Address(RVA = "0xC2F5C4", Offset = "0xC2F5C4", VA = "0xC2F5C4")]
		private void OnCollisionEnter2D()
		{
		}

		[Token(Token = "0x600061B")]
		[Address(RVA = "0xC2F5D4", Offset = "0xC2F5D4", VA = "0xC2F5D4")]
		private void OnCollisionExit2D()
		{
		}

		[Token(Token = "0x600061C")]
		[Address(RVA = "0xC2F5E4", Offset = "0xC2F5E4", VA = "0xC2F5E4")]
		private void OnMouseEnter()
		{
		}

		[Token(Token = "0x600061D")]
		[Address(RVA = "0xC2F5F4", Offset = "0xC2F5F4", VA = "0xC2F5F4")]
		private void OnMouseExit()
		{
		}

		[Token(Token = "0x600061E")]
		[Address(RVA = "0xC2F604", Offset = "0xC2F604", VA = "0xC2F604")]
		private void OnMouseDown()
		{
		}

		[Token(Token = "0x600061F")]
		[Address(RVA = "0xC2F614", Offset = "0xC2F614", VA = "0xC2F614")]
		private void OnMouseUp()
		{
		}

		[Token(Token = "0x6000620")]
		protected abstract void HandleGameEvent(EmitterGameEvent gameEvent);

		[Token(Token = "0x6000621")]
		[Address(RVA = "0xC2F624", Offset = "0xC2F624", VA = "0xC2F624")]
		protected EventHandler()
		{
		}
	}
	[Token(Token = "0x20000EF")]
	public class EventRefAttribute : PropertyAttribute
	{
		[Token(Token = "0x6000622")]
		[Address(RVA = "0xC31254", Offset = "0xC31254", VA = "0xC31254")]
		public EventRefAttribute()
		{
		}
	}
	[Token(Token = "0x20000F0")]
	public class FMODRuntimeManagerOnGUIHelper : MonoBehaviour
	{
		[Token(Token = "0x40004F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public RuntimeManager TargetRuntimeManager;

		[Token(Token = "0x6000623")]
		[Address(RVA = "0xC33DE0", Offset = "0xC33DE0", VA = "0xC33DE0")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000624")]
		[Address(RVA = "0xC33F94", Offset = "0xC33F94", VA = "0xC33F94")]
		public FMODRuntimeManagerOnGUIHelper()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000F1")]
	public class ParamRef
	{
		[Token(Token = "0x40004F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string Name;

		[Token(Token = "0x40004FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float Value;

		[Token(Token = "0x40004FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public PARAMETER_ID ID;

		[Token(Token = "0x6000625")]
		[Address(RVA = "0xC36F98", Offset = "0xC36F98", VA = "0xC36F98")]
		public ParamRef()
		{
		}
	}
	[Token(Token = "0x20000F2")]
	public class ParamRefAttribute : PropertyAttribute
	{
		[Token(Token = "0x6000626")]
		[Address(RVA = "0xC36FA0", Offset = "0xC36FA0", VA = "0xC36FA0")]
		public ParamRefAttribute()
		{
		}
	}
	[Token(Token = "0x20000F3")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x918C38", Offset = "0x918C38")]
	public class RuntimeManager : MonoBehaviour
	{
		[Token(Token = "0x20000F4")]
		private struct LoadedBank
		{
			[Token(Token = "0x400050F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Bank Bank;

			[Token(Token = "0x4000510")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public int RefCount;
		}

		[Token(Token = "0x20000F5")]
		private class GuidComparer : IEqualityComparer<Guid>
		{
			[Token(Token = "0x600065B")]
			[Address(RVA = "0x1E4A9F4", Offset = "0x1E4A9F4", VA = "0x1E4A9F4", Slot = "4")]
			private bool System.Collections.Generic.IEqualityComparer<System.Guid>.Equals(Guid x, Guid y)
			{
				return default(bool);
			}

			[Token(Token = "0x600065C")]
			[Address(RVA = "0x1E4AA28", Offset = "0x1E4AA28", VA = "0x1E4AA28", Slot = "5")]
			private int System.Collections.Generic.IEqualityComparer<System.Guid>.GetHashCode(Guid obj)
			{
				return default(int);
			}

			[Token(Token = "0x600065D")]
			[Address(RVA = "0x1E4AA50", Offset = "0x1E4AA50", VA = "0x1E4AA50")]
			public GuidComparer()
			{
			}
		}

		[Token(Token = "0x20000F6")]
		private class AttachedInstance
		{
			[Token(Token = "0x4000511")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public EventInstance instance;

			[Token(Token = "0x4000512")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Transform transform;

			[Token(Token = "0x4000513")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Rigidbody rigidBody;

			[Token(Token = "0x4000514")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Rigidbody2D rigidBody2D;

			[Token(Token = "0x600065E")]
			[Address(RVA = "0x1E4A9EC", Offset = "0x1E4A9EC", VA = "0x1E4A9EC")]
			public AttachedInstance()
			{
			}
		}

		[Token(Token = "0x20000F7")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x918C70", Offset = "0x918C70")]
		private sealed class <>c__DisplayClass27_0
		{
			[Token(Token = "0x4000515")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public EventInstance instance;

			[Token(Token = "0x600065F")]
			[Address(RVA = "0x1E4A640", Offset = "0x1E4A640", VA = "0x1E4A640")]
			public <>c__DisplayClass27_0()
			{
			}

			[Token(Token = "0x6000660")]
			[Address(RVA = "0x1E4A648", Offset = "0x1E4A648", VA = "0x1E4A648")]
			internal bool <AttachInstanceToGameObject>b__0(AttachedInstance x)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x20000F8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x918C80", Offset = "0x918C80")]
		private sealed class <>c__DisplayClass28_0
		{
			[Token(Token = "0x4000516")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public EventInstance instance;

			[Token(Token = "0x6000661")]
			[Address(RVA = "0x1E4A66C", Offset = "0x1E4A66C", VA = "0x1E4A66C")]
			public <>c__DisplayClass28_0()
			{
			}

			[Token(Token = "0x6000662")]
			[Address(RVA = "0x1E4A674", Offset = "0x1E4A674", VA = "0x1E4A674")]
			internal bool <AttachInstanceToGameObject>b__0(AttachedInstance x)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x20000F9")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x918C90", Offset = "0x918C90")]
		private sealed class <loadFromWeb>d__42 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000517")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000518")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000519")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public string bankPath;

			[Token(Token = "0x400051A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public RuntimeManager <>4__this;

			[Token(Token = "0x400051B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public string bankName;

			[Token(Token = "0x400051C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public bool loadSamples;

			[Token(Token = "0x400051D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private UnityWebRequest <www>5__2;

			[Token(Token = "0x1700000D")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000666")]
				[Address(RVA = "0x1E4A99C", Offset = "0x1E4A99C", VA = "0x1E4A99C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700000E")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000668")]
				[Address(RVA = "0x1E4A9E4", Offset = "0x1E4A9E4", VA = "0x1E4A9E4", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000663")]
			[Address(RVA = "0x1E4A698", Offset = "0x1E4A698", VA = "0x1E4A698")]
			[DebuggerHidden]
			public <loadFromWeb>d__42(int <>1__state)
			{
			}

			[Token(Token = "0x6000664")]
			[Address(RVA = "0x1E4A6C4", Offset = "0x1E4A6C4", VA = "0x1E4A6C4", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000665")]
			[Address(RVA = "0x1E4A6C8", Offset = "0x1E4A6C8", VA = "0x1E4A6C8", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000667")]
			[Address(RVA = "0x1E4A9A4", Offset = "0x1E4A9A4", VA = "0x1E4A9A4", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40004FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static SystemNotInitializedException initException;

		[Token(Token = "0x40004FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static RuntimeManager instance;

		[Token(Token = "0x40004FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private FMODPlatform fmodPlatform;

		[Token(Token = "0x40004FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private FMOD.Studio.System studioSystem;

		[Token(Token = "0x4000500")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private FMOD.System coreSystem;

		[Token(Token = "0x4000501")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private DSP mixerHead;

		[Token(Token = "0x4000502")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private long[] cachedPointers;

		[Token(Token = "0x4000503")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Dictionary<string, LoadedBank> loadedBanks;

		[Token(Token = "0x4000504")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Dictionary<string, uint> loadedPlugins;

		[Token(Token = "0x4000505")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Dictionary<Guid, EventDescription> cachedDescriptions;

		[Token(Token = "0x4000506")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private List<AttachedInstance> attachedInstances;

		[Token(Token = "0x4000507")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private bool listenerWarningIssued;

		[Token(Token = "0x4000508")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x61")]
		protected bool isOverlayEnabled;

		[Token(Token = "0x4000509")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private FMODRuntimeManagerOnGUIHelper overlayDrawer;

		[Token(Token = "0x400050A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Rect windowRect;

		[Token(Token = "0x400050B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private string lastDebugText;

		[Token(Token = "0x400050C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private float lastDebugUpdate;

		[Token(Token = "0x400050D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static List<StudioListener> Listeners;

		[Token(Token = "0x400050E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static int numListeners;

		[Token(Token = "0x17000008")]
		private static RuntimeManager Instance
		{
			[Token(Token = "0x6000628")]
			[Address(RVA = "0xC37878", Offset = "0xC37878", VA = "0xC37878")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000009")]
		public static FMOD.Studio.System StudioSystem
		{
			[Token(Token = "0x6000629")]
			[Address(RVA = "0xC32ED4", Offset = "0xC32ED4", VA = "0xC32ED4")]
			get
			{
				return default(FMOD.Studio.System);
			}
		}

		[Token(Token = "0x1700000A")]
		public static FMOD.System CoreSystem
		{
			[Token(Token = "0x600062A")]
			[Address(RVA = "0xC34808", Offset = "0xC34808", VA = "0xC34808")]
			get
			{
				return default(FMOD.System);
			}
		}

		[Token(Token = "0x1700000B")]
		public static bool IsInitialized
		{
			[Token(Token = "0x6000654")]
			[Address(RVA = "0xC3D38C", Offset = "0xC3D38C", VA = "0xC3D38C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700000C")]
		public static bool HasBanksLoaded
		{
			[Token(Token = "0x6000655")]
			[Address(RVA = "0xC3D234", Offset = "0xC3D234", VA = "0xC3D234")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000627")]
		[Address(RVA = "0xC376AC", Offset = "0xC376AC", VA = "0xC376AC")]
		[AttributeAttribute(Name = "MonoPInvokeCallbackAttribute", RVA = "0x9190A0", Offset = "0x9190A0")]
		private static RESULT DEBUG_CALLBACK(DEBUG_FLAGS flags, StringWrapper file, int line, StringWrapper func, StringWrapper message)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600062B")]
		[Address(RVA = "0xC38B08", Offset = "0xC38B08", VA = "0xC38B08")]
		private void CheckInitResult(RESULT result, string cause)
		{
		}

		[Token(Token = "0x600062C")]
		[Address(RVA = "0xC38500", Offset = "0xC38500", VA = "0xC38500")]
		private RESULT Initialize()
		{
			return default(RESULT);
		}

		[Token(Token = "0x600062D")]
		[Address(RVA = "0xC39B58", Offset = "0xC39B58", VA = "0xC39B58")]
		public static int AddListener(StudioListener listener)
		{
			return default(int);
		}

		[Token(Token = "0x600062E")]
		[Address(RVA = "0xC39FA0", Offset = "0xC39FA0", VA = "0xC39FA0")]
		public static bool RemoveListener(StudioListener listener)
		{
			return default(bool);
		}

		[Token(Token = "0x600062F")]
		[Address(RVA = "0xC3A2C8", Offset = "0xC3A2C8", VA = "0xC3A2C8")]
		private void Update()
		{
		}

		[Token(Token = "0x6000630")]
		[Address(RVA = "0xC33388", Offset = "0xC33388", VA = "0xC33388")]
		public static void AttachInstanceToGameObject(EventInstance instance, Transform transform, Rigidbody rigidBody)
		{
		}

		[Token(Token = "0x6000631")]
		[Address(RVA = "0xC3356C", Offset = "0xC3356C", VA = "0xC3356C")]
		public static void AttachInstanceToGameObject(EventInstance instance, Transform transform, Rigidbody2D rigidBody2D)
		{
		}

		[Token(Token = "0x6000632")]
		[Address(RVA = "0xC3A9F4", Offset = "0xC3A9F4", VA = "0xC3A9F4")]
		public static void DetachInstanceFromGameObject(EventInstance instance)
		{
		}

		[Token(Token = "0x6000633")]
		[Address(RVA = "0xC33E68", Offset = "0xC33E68", VA = "0xC33E68")]
		public void ExecuteOnGUI()
		{
		}

		[Token(Token = "0x6000634")]
		[Address(RVA = "0xC3AB10", Offset = "0xC3AB10", VA = "0xC3AB10")]
		private void Start()
		{
		}

		[Token(Token = "0x6000635")]
		[Address(RVA = "0xC3AC24", Offset = "0xC3AC24", VA = "0xC3AC24")]
		private void DrawDebugOverlay(int windowID)
		{
		}

		[Token(Token = "0x6000636")]
		[Address(RVA = "0xC3B0A0", Offset = "0xC3B0A0", VA = "0xC3B0A0")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000637")]
		[Address(RVA = "0xC3B110", Offset = "0xC3B110", VA = "0xC3B110")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000638")]
		[Address(RVA = "0xC3B1B0", Offset = "0xC3B1B0", VA = "0xC3B1B0")]
		private void OnApplicationPause(bool pauseStatus)
		{
		}

		[Token(Token = "0x6000639")]
		[Address(RVA = "0xC3B324", Offset = "0xC3B324", VA = "0xC3B324")]
		private void loadedBankRegister(LoadedBank loadedBank, string bankPath, string bankName, bool loadSamples, RESULT loadResult)
		{
		}

		[Token(Token = "0x600063A")]
		[Address(RVA = "0xC3B478", Offset = "0xC3B478", VA = "0xC3B478")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x919100", Offset = "0x919100")]
		private IEnumerator loadFromWeb(string bankPath, string bankName, bool loadSamples)
		{
			return null;
		}

		[Token(Token = "0x600063B")]
		[Address(RVA = "0xC3B50C", Offset = "0xC3B50C", VA = "0xC3B50C")]
		public static void LoadBank(string bankName, bool loadSamples = false)
		{
		}

		[Token(Token = "0x600063C")]
		[Address(RVA = "0xC3BAC8", Offset = "0xC3BAC8", VA = "0xC3BAC8")]
		public static void LoadBank(TextAsset asset, bool loadSamples = false)
		{
		}

		[Token(Token = "0x600063D")]
		[Address(RVA = "0xC39630", Offset = "0xC39630", VA = "0xC39630")]
		private void LoadBanks(Settings fmodSettings)
		{
		}

		[Token(Token = "0x600063E")]
		[Address(RVA = "0xC3BD90", Offset = "0xC3BD90", VA = "0xC3BD90")]
		public static void UnloadBank(string bankName)
		{
		}

		[Token(Token = "0x600063F")]
		[Address(RVA = "0xC3BEE4", Offset = "0xC3BEE4", VA = "0xC3BEE4")]
		public static bool AnyBankLoading()
		{
			return default(bool);
		}

		[Token(Token = "0x6000640")]
		[Address(RVA = "0xC3BD24", Offset = "0xC3BD24", VA = "0xC3BD24")]
		public static void WaitForAllLoads()
		{
		}

		[Token(Token = "0x6000641")]
		[Address(RVA = "0xC3C05C", Offset = "0xC3C05C", VA = "0xC3C05C")]
		public static Guid PathToGUID(string path)
		{
			return default(Guid);
		}

		[Token(Token = "0x6000642")]
		[Address(RVA = "0xC33278", Offset = "0xC33278", VA = "0xC33278")]
		public static EventInstance CreateInstance(string path)
		{
			return default(EventInstance);
		}

		[Token(Token = "0x6000643")]
		[Address(RVA = "0xC3C1A0", Offset = "0xC3C1A0", VA = "0xC3C1A0")]
		public static EventInstance CreateInstance(Guid guid)
		{
			return default(EventInstance);
		}

		[Token(Token = "0x6000644")]
		[Address(RVA = "0xC3C444", Offset = "0xC3C444", VA = "0xC3C444")]
		public static void PlayOneShot(string path, [Optional] Vector3 position, float volume = 0.8f)
		{
		}

		[Token(Token = "0x6000645")]
		[Address(RVA = "0xC3C5C0", Offset = "0xC3C5C0", VA = "0xC3C5C0")]
		public static void PlayOneShot(Guid guid, [Optional] Vector3 position, float volume = 0.8f)
		{
		}

		[Token(Token = "0x6000646")]
		[Address(RVA = "0xC3C69C", Offset = "0xC3C69C", VA = "0xC3C69C")]
		public static void PlayOneShotAttached(string path, GameObject gameObject)
		{
		}

		[Token(Token = "0x6000647")]
		[Address(RVA = "0xC3C7F4", Offset = "0xC3C7F4", VA = "0xC3C7F4")]
		public static void PlayOneShotAttached(Guid guid, GameObject gameObject)
		{
		}

		[Token(Token = "0x6000648")]
		[Address(RVA = "0xC3C8C4", Offset = "0xC3C8C4", VA = "0xC3C8C4")]
		public static EventDescription GetEventDescription(string path)
		{
			return default(EventDescription);
		}

		[Token(Token = "0x6000649")]
		[Address(RVA = "0xC3C224", Offset = "0xC3C224", VA = "0xC3C224")]
		public static EventDescription GetEventDescription(Guid guid)
		{
			return default(EventDescription);
		}

		[Token(Token = "0x600064A")]
		[Address(RVA = "0xC3C9D4", Offset = "0xC3C9D4", VA = "0xC3C9D4")]
		public static void SetListenerLocation(GameObject gameObject, [Optional] Rigidbody rigidBody)
		{
		}

		[Token(Token = "0x600064B")]
		[Address(RVA = "0xC3CBA4", Offset = "0xC3CBA4", VA = "0xC3CBA4")]
		public static void SetListenerLocation(GameObject gameObject, Rigidbody2D rigidBody2D)
		{
		}

		[Token(Token = "0x600064C")]
		[Address(RVA = "0xC3CD80", Offset = "0xC3CD80", VA = "0xC3CD80")]
		public static void SetListenerLocation(Transform transform)
		{
		}

		[Token(Token = "0x600064D")]
		[Address(RVA = "0xC3CEC0", Offset = "0xC3CEC0", VA = "0xC3CEC0")]
		public static void SetListenerLocation(int listenerIndex, GameObject gameObject, [Optional] Rigidbody rigidBody)
		{
		}

		[Token(Token = "0x600064E")]
		[Address(RVA = "0xC3CF68", Offset = "0xC3CF68", VA = "0xC3CF68")]
		public static void SetListenerLocation(int listenerIndex, GameObject gameObject, Rigidbody2D rigidBody2D)
		{
		}

		[Token(Token = "0x600064F")]
		[Address(RVA = "0xC3D010", Offset = "0xC3D010", VA = "0xC3D010")]
		public static void SetListenerLocation(int listenerIndex, Transform transform)
		{
		}

		[Token(Token = "0x6000650")]
		[Address(RVA = "0xC3D0B0", Offset = "0xC3D0B0", VA = "0xC3D0B0")]
		public static Bus GetBus(string path)
		{
			return default(Bus);
		}

		[Token(Token = "0x6000651")]
		[Address(RVA = "0xC3D170", Offset = "0xC3D170", VA = "0xC3D170")]
		public static VCA GetVCA(string path)
		{
			return default(VCA);
		}

		[Token(Token = "0x6000652")]
		[Address(RVA = "0xC3B25C", Offset = "0xC3B25C", VA = "0xC3B25C")]
		public static void PauseAllEvents(bool paused)
		{
		}

		[Token(Token = "0x6000653")]
		[Address(RVA = "0xC3D2C4", Offset = "0xC3D2C4", VA = "0xC3D2C4")]
		public static void MuteAllEvents(bool muted)
		{
		}

		[Token(Token = "0x6000656")]
		[Address(RVA = "0xC3D478", Offset = "0xC3D478", VA = "0xC3D478")]
		public static bool HasBankLoaded(string loadedBank)
		{
			return default(bool);
		}

		[Token(Token = "0x6000657")]
		[Address(RVA = "0xC39450", Offset = "0xC39450", VA = "0xC39450")]
		private void LoadPlugins(Settings fmodSettings)
		{
		}

		[Token(Token = "0x6000658")]
		[Address(RVA = "0xC39340", Offset = "0xC39340", VA = "0xC39340")]
		private void SetThreadAffinity()
		{
		}

		[Token(Token = "0x6000659")]
		[Address(RVA = "0xC3D59C", Offset = "0xC3D59C", VA = "0xC3D59C")]
		public RuntimeManager()
		{
		}
	}
	[Token(Token = "0x20000FA")]
	public class EventNotFoundException : Exception
	{
		[Token(Token = "0x400051E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public Guid Guid;

		[Token(Token = "0x400051F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public string Path;

		[Token(Token = "0x6000669")]
		[Address(RVA = "0xC310C0", Offset = "0xC310C0", VA = "0xC310C0")]
		public EventNotFoundException(string path)
		{
		}

		[Token(Token = "0x600066A")]
		[Address(RVA = "0xC31180", Offset = "0xC31180", VA = "0xC31180")]
		public EventNotFoundException(Guid guid)
		{
		}
	}
	[Token(Token = "0x20000FB")]
	public class BusNotFoundException : Exception
	{
		[Token(Token = "0x4000520")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public string Path;

		[Token(Token = "0x600066B")]
		[Address(RVA = "0xC190DC", Offset = "0xC190DC", VA = "0xC190DC")]
		public BusNotFoundException(string path)
		{
		}
	}
	[Token(Token = "0x20000FC")]
	public class VCANotFoundException : Exception
	{
		[Token(Token = "0x4000521")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public string Path;

		[Token(Token = "0x600066C")]
		[Address(RVA = "0x1E4A578", Offset = "0x1E4A578", VA = "0x1E4A578")]
		public VCANotFoundException(string path)
		{
		}
	}
	[Token(Token = "0x20000FD")]
	public class BankLoadException : Exception
	{
		[Token(Token = "0x4000522")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public string Path;

		[Token(Token = "0x4000523")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public RESULT Result;

		[Token(Token = "0x600066D")]
		[Address(RVA = "0xC17E54", Offset = "0xC17E54", VA = "0xC17E54")]
		public BankLoadException(string path, RESULT result)
		{
		}

		[Token(Token = "0x600066E")]
		[Address(RVA = "0xC183A4", Offset = "0xC183A4", VA = "0xC183A4")]
		public BankLoadException(string path, string error)
		{
		}
	}
	[Token(Token = "0x20000FE")]
	public class SystemNotInitializedException : Exception
	{
		[Token(Token = "0x4000524")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public RESULT Result;

		[Token(Token = "0x4000525")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public string Location;

		[Token(Token = "0x600066F")]
		[Address(RVA = "0x1E49A90", Offset = "0x1E49A90", VA = "0x1E49A90")]
		public SystemNotInitializedException(RESULT result, string location)
		{
		}

		[Token(Token = "0x6000670")]
		[Address(RVA = "0x1E49BAC", Offset = "0x1E49BAC", VA = "0x1E49BAC")]
		public SystemNotInitializedException(Exception inner)
		{
		}
	}
	[Token(Token = "0x20000FF")]
	public enum EmitterGameEvent
	{
		[Token(Token = "0x4000527")]
		None,
		[Token(Token = "0x4000528")]
		ObjectStart,
		[Token(Token = "0x4000529")]
		ObjectDestroy,
		[Token(Token = "0x400052A")]
		TriggerEnter,
		[Token(Token = "0x400052B")]
		TriggerExit,
		[Token(Token = "0x400052C")]
		TriggerEnter2D,
		[Token(Token = "0x400052D")]
		TriggerExit2D,
		[Token(Token = "0x400052E")]
		CollisionEnter,
		[Token(Token = "0x400052F")]
		CollisionExit,
		[Token(Token = "0x4000530")]
		CollisionEnter2D,
		[Token(Token = "0x4000531")]
		CollisionExit2D,
		[Token(Token = "0x4000532")]
		ObjectEnable,
		[Token(Token = "0x4000533")]
		ObjectDisable,
		[Token(Token = "0x4000534")]
		MouseEnter,
		[Token(Token = "0x4000535")]
		MouseExit,
		[Token(Token = "0x4000536")]
		MouseDown,
		[Token(Token = "0x4000537")]
		MouseUp
	}
	[Token(Token = "0x2000100")]
	public enum LoaderGameEvent
	{
		[Token(Token = "0x4000539")]
		None,
		[Token(Token = "0x400053A")]
		ObjectStart,
		[Token(Token = "0x400053B")]
		ObjectDestroy,
		[Token(Token = "0x400053C")]
		TriggerEnter,
		[Token(Token = "0x400053D")]
		TriggerExit,
		[Token(Token = "0x400053E")]
		TriggerEnter2D,
		[Token(Token = "0x400053F")]
		TriggerExit2D
	}
	[Token(Token = "0x2000101")]
	public static class RuntimeUtils
	{
		[Token(Token = "0x4000540")]
		private const string BankExtension = ".bank";

		[Token(Token = "0x6000671")]
		[Address(RVA = "0xC3D808", Offset = "0xC3D808", VA = "0xC3D808")]
		public static string GetCommonPlatformPath(string path)
		{
			return null;
		}

		[Token(Token = "0x6000672")]
		[Address(RVA = "0xC3D858", Offset = "0xC3D858", VA = "0xC3D858")]
		public static VECTOR ToFMODVector(this Vector3 vec)
		{
			return default(VECTOR);
		}

		[Token(Token = "0x6000673")]
		[Address(RVA = "0xC33750", Offset = "0xC33750", VA = "0xC33750")]
		public static ATTRIBUTES_3D To3DAttributes(this Vector3 pos)
		{
			return default(ATTRIBUTES_3D);
		}

		[Token(Token = "0x6000674")]
		[Address(RVA = "0xC3CE14", Offset = "0xC3CE14", VA = "0xC3CE14")]
		public static ATTRIBUTES_3D To3DAttributes(this Transform transform)
		{
			return default(ATTRIBUTES_3D);
		}

		[Token(Token = "0x6000675")]
		[Address(RVA = "0xC3A7A8", Offset = "0xC3A7A8", VA = "0xC3A7A8")]
		public static ATTRIBUTES_3D To3DAttributes(Transform transform, [Optional] Rigidbody rigidbody)
		{
			return default(ATTRIBUTES_3D);
		}

		[Token(Token = "0x6000676")]
		[Address(RVA = "0xC3CA78", Offset = "0xC3CA78", VA = "0xC3CA78")]
		public static ATTRIBUTES_3D To3DAttributes(GameObject go, [Optional] Rigidbody rigidbody)
		{
			return default(ATTRIBUTES_3D);
		}

		[Token(Token = "0x6000677")]
		[Address(RVA = "0xC3A8C8", Offset = "0xC3A8C8", VA = "0xC3A8C8")]
		public static ATTRIBUTES_3D To3DAttributes(Transform transform, Rigidbody2D rigidbody)
		{
			return default(ATTRIBUTES_3D);
		}

		[Token(Token = "0x6000678")]
		[Address(RVA = "0xC3CC48", Offset = "0xC3CC48", VA = "0xC3CC48")]
		public static ATTRIBUTES_3D To3DAttributes(GameObject go, Rigidbody2D rigidbody)
		{
			return default(ATTRIBUTES_3D);
		}

		[Token(Token = "0x6000679")]
		[Address(RVA = "0xC38DE4", Offset = "0xC38DE4", VA = "0xC38DE4")]
		internal static FMODPlatform GetCurrentPlatform()
		{
			return default(FMODPlatform);
		}

		[Token(Token = "0x600067A")]
		[Address(RVA = "0xC3B950", Offset = "0xC3B950", VA = "0xC3B950")]
		internal static string GetBankPath(string bankName)
		{
			return null;
		}

		[Token(Token = "0x600067B")]
		[Address(RVA = "0xC3D50C", Offset = "0xC3D50C", VA = "0xC3D50C")]
		internal static string GetPluginPath(string pluginName)
		{
			return null;
		}

		[Token(Token = "0x600067C")]
		[Address(RVA = "0xC38334", Offset = "0xC38334", VA = "0xC38334")]
		public static void EnforceLibraryOrder()
		{
		}

		[Token(Token = "0x600067D")]
		[Address(RVA = "0xC381E4", Offset = "0xC381E4", VA = "0xC381E4")]
		public static bool VerifyPlatformLibsExist()
		{
			return default(bool);
		}
	}
	[Serializable]
	[Token(Token = "0x2000102")]
	public enum FMODPlatform
	{
		[Token(Token = "0x4000542")]
		None,
		[Token(Token = "0x4000543")]
		PlayInEditor,
		[Token(Token = "0x4000544")]
		Default,
		[Token(Token = "0x4000545")]
		Desktop,
		[Token(Token = "0x4000546")]
		Mobile,
		[Token(Token = "0x4000547")]
		MobileHigh,
		[Token(Token = "0x4000548")]
		MobileLow,
		[Token(Token = "0x4000549")]
		Console,
		[Token(Token = "0x400054A")]
		Windows,
		[Token(Token = "0x400054B")]
		Mac,
		[Token(Token = "0x400054C")]
		Linux,
		[Token(Token = "0x400054D")]
		iOS,
		[Token(Token = "0x400054E")]
		Android,
		[Token(Token = "0x400054F")]
		Deprecated_1,
		[Token(Token = "0x4000550")]
		XboxOne,
		[Token(Token = "0x4000551")]
		PS4,
		[Token(Token = "0x4000552")]
		Deprecated_2,
		[Token(Token = "0x4000553")]
		Deprecated_3,
		[Token(Token = "0x4000554")]
		AppleTV,
		[Token(Token = "0x4000555")]
		UWP,
		[Token(Token = "0x4000556")]
		Switch,
		[Token(Token = "0x4000557")]
		WebGL,
		[Token(Token = "0x4000558")]
		Stadia,
		[Token(Token = "0x4000559")]
		Reserved_1,
		[Token(Token = "0x400055A")]
		Reserved_2,
		[Token(Token = "0x400055B")]
		Count
	}
	[Serializable]
	[Token(Token = "0x2000103")]
	public enum ImportType
	{
		[Token(Token = "0x400055D")]
		StreamingAssets,
		[Token(Token = "0x400055E")]
		AssetBundle
	}
	[Serializable]
	[Token(Token = "0x2000104")]
	public enum BankLoadType
	{
		[Token(Token = "0x4000560")]
		All,
		[Token(Token = "0x4000561")]
		Specified,
		[Token(Token = "0x4000562")]
		None
	}
	[Token(Token = "0x2000105")]
	public class PlatformSettingBase
	{
		[Token(Token = "0x4000563")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public FMODPlatform Platform;

		[Token(Token = "0x600067E")]
		[Address(RVA = "0xC37040", Offset = "0xC37040", VA = "0xC37040")]
		public PlatformSettingBase()
		{
		}
	}
	[Token(Token = "0x2000106")]
	public class PlatformSetting<T> : PlatformSettingBase
	{
		[Token(Token = "0x4000564")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public T Value;

		[Token(Token = "0x600067F")]
		public PlatformSetting()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000107")]
	public class PlatformIntSetting : PlatformSetting<int>
	{
		[Token(Token = "0x6000680")]
		[Address(RVA = "0xC36FF4", Offset = "0xC36FF4", VA = "0xC36FF4")]
		public PlatformIntSetting()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000108")]
	public class PlatformStringSetting : PlatformSetting<string>
	{
		[Token(Token = "0x6000681")]
		[Address(RVA = "0xC37048", Offset = "0xC37048", VA = "0xC37048")]
		public PlatformStringSetting()
		{
		}
	}
	[Token(Token = "0x2000109")]
	public enum TriStateBool
	{
		[Token(Token = "0x4000566")]
		Disabled,
		[Token(Token = "0x4000567")]
		Enabled,
		[Token(Token = "0x4000568")]
		Development
	}
	[Serializable]
	[Token(Token = "0x200010A")]
	public class PlatformBoolSetting : PlatformSetting<TriStateBool>
	{
		[Token(Token = "0x6000682")]
		[Address(RVA = "0xC36FA8", Offset = "0xC36FA8", VA = "0xC36FA8")]
		public PlatformBoolSetting()
		{
		}
	}
	[Token(Token = "0x200010B")]
	public class Settings : ScriptableObject
	{
		[Token(Token = "0x200010C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x918CB0", Offset = "0x918CB0")]
		private sealed class <>c__DisplayClass36_0<T> where T : PlatformSettingBase
		{
			[Token(Token = "0x4000584")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public FMODPlatform platform;

			[Token(Token = "0x6000696")]
			public <>c__DisplayClass36_0()
			{
			}

			[Token(Token = "0x6000697")]
			internal bool <HasSetting>b__0(T x)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x200010D")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x918CC0", Offset = "0x918CC0")]
		private sealed class <>c__DisplayClass37_0<T, U> where T : PlatformSetting<U>
		{
			[Token(Token = "0x4000585")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public FMODPlatform platform;

			[Token(Token = "0x6000698")]
			public <>c__DisplayClass37_0()
			{
			}

			[Token(Token = "0x6000699")]
			internal bool <GetSetting>b__0(T x)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x200010E")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x918CD0", Offset = "0x918CD0")]
		private sealed class <>c__DisplayClass38_0<T, U> where T : PlatformSetting<U>, new()
		{
			[Token(Token = "0x4000586")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public FMODPlatform platform;

			[Token(Token = "0x600069A")]
			public <>c__DisplayClass38_0()
			{
			}

			[Token(Token = "0x600069B")]
			internal bool <SetSetting>b__0(T x)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x200010F")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x918CE0", Offset = "0x918CE0")]
		private sealed class <>c__DisplayClass39_0<T> where T : PlatformSettingBase
		{
			[Token(Token = "0x4000587")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public FMODPlatform platform;

			[Token(Token = "0x600069C")]
			public <>c__DisplayClass39_0()
			{
			}

			[Token(Token = "0x600069D")]
			internal bool <RemoveSetting>b__0(T x)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x4000569")]
		private const string SettingsAssetName = "FMODStudioSettings";

		[Token(Token = "0x400056A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static Settings instance;

		[Token(Token = "0x400056B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		public bool HasSourceProject;

		[Token(Token = "0x400056C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		[SerializeField]
		public bool HasPlatforms;

		[Token(Token = "0x400056D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private string sourceProjectPath;

		[Token(Token = "0x400056E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private string sourceBankPath;

		[Token(Token = "0x400056F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		public string SourceBankPathUnformatted;

		[Token(Token = "0x4000570")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		public bool AutomaticEventLoading;

		[Token(Token = "0x4000571")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[SerializeField]
		public BankLoadType BankLoadType;

		[Token(Token = "0x4000572")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		public bool AutomaticSampleLoading;

		[Token(Token = "0x4000573")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		public string EncryptionKey;

		[Token(Token = "0x4000574")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		public ImportType ImportType;

		[Token(Token = "0x4000575")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		public string TargetAssetPath;

		[Token(Token = "0x4000576")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		public DEBUG_FLAGS LoggingLevel;

		[Token(Token = "0x4000577")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		public List<PlatformIntSetting> SpeakerModeSettings;

		[Token(Token = "0x4000578")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		public List<PlatformIntSetting> SampleRateSettings;

		[Token(Token = "0x4000579")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[SerializeField]
		public List<PlatformBoolSetting> LiveUpdateSettings;

		[Token(Token = "0x400057A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[SerializeField]
		public List<PlatformBoolSetting> OverlaySettings;

		[Token(Token = "0x400057B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[SerializeField]
		public List<PlatformBoolSetting> LoggingSettings;

		[Token(Token = "0x400057C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[SerializeField]
		public List<PlatformStringSetting> BankDirectorySettings;

		[Token(Token = "0x400057D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		[SerializeField]
		public List<PlatformIntSetting> VirtualChannelSettings;

		[Token(Token = "0x400057E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		[SerializeField]
		public List<PlatformIntSetting> RealChannelSettings;

		[Token(Token = "0x400057F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[SerializeField]
		public List<string> Plugins;

		[Token(Token = "0x4000580")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[SerializeField]
		public List<string> MasterBanks;

		[Token(Token = "0x4000581")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		[SerializeField]
		public List<string> Banks;

		[Token(Token = "0x4000582")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[SerializeField]
		public List<string> BanksToLoad;

		[Token(Token = "0x4000583")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[SerializeField]
		public ushort LiveUpdatePort;

		[Token(Token = "0x1700000F")]
		public static Settings Instance
		{
			[Token(Token = "0x6000683")]
			[Address(RVA = "0xC38B90", Offset = "0xC38B90", VA = "0xC38B90")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000010")]
		public string SourceProjectPath
		{
			[Token(Token = "0x6000684")]
			[Address(RVA = "0xC3EBD0", Offset = "0xC3EBD0", VA = "0xC3EBD0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000685")]
			[Address(RVA = "0xC3EBD8", Offset = "0xC3EBD8", VA = "0xC3EBD8")]
			set
			{
			}
		}

		[Token(Token = "0x17000011")]
		public string SourceBankPath
		{
			[Token(Token = "0x6000686")]
			[Address(RVA = "0xC3EBE0", Offset = "0xC3EBE0", VA = "0xC3EBE0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000687")]
			[Address(RVA = "0xC3EBE8", Offset = "0xC3EBE8", VA = "0xC3EBE8")]
			set
			{
			}
		}

		[Token(Token = "0x6000688")]
		[Address(RVA = "0xC3EBF0", Offset = "0xC3EBF0", VA = "0xC3EBF0")]
		public static FMODPlatform GetParent(FMODPlatform platform)
		{
			return default(FMODPlatform);
		}

		[Token(Token = "0x6000689")]
		public static bool HasSetting<T>(List<T> list, FMODPlatform platform) where T : PlatformSettingBase
		{
			return default(bool);
		}

		[Token(Token = "0x600068A")]
		public static U GetSetting<T, U>(List<T> list, FMODPlatform platform, U def) where T : PlatformSetting<U>
		{
			return (U)null;
		}

		[Token(Token = "0x600068B")]
		public static void SetSetting<T, U>(List<T> list, FMODPlatform platform, U value) where T : PlatformSetting<U>, new()
		{
		}

		[Token(Token = "0x600068C")]
		public static void RemoveSetting<T>(List<T> list, FMODPlatform platform) where T : PlatformSettingBase
		{
		}

		[Token(Token = "0x600068D")]
		[Address(RVA = "0xC393B4", Offset = "0xC393B4", VA = "0xC393B4")]
		public bool IsLiveUpdateEnabled(FMODPlatform platform)
		{
			return default(bool);
		}

		[Token(Token = "0x600068E")]
		[Address(RVA = "0xC3AB88", Offset = "0xC3AB88", VA = "0xC3AB88")]
		public bool IsOverlayEnabled(FMODPlatform platform)
		{
			return default(bool);
		}

		[Token(Token = "0x600068F")]
		[Address(RVA = "0xC39190", Offset = "0xC39190", VA = "0xC39190")]
		public int GetRealChannels(FMODPlatform platform)
		{
			return default(int);
		}

		[Token(Token = "0x6000690")]
		[Address(RVA = "0xC39220", Offset = "0xC39220", VA = "0xC39220")]
		public int GetVirtualChannels(FMODPlatform platform)
		{
			return default(int);
		}

		[Token(Token = "0x6000691")]
		[Address(RVA = "0xC392B0", Offset = "0xC392B0", VA = "0xC392B0")]
		public int GetSpeakerMode(FMODPlatform platform)
		{
			return default(int);
		}

		[Token(Token = "0x6000692")]
		[Address(RVA = "0xC39100", Offset = "0xC39100", VA = "0xC39100")]
		public int GetSampleRate(FMODPlatform platform)
		{
			return default(int);
		}

		[Token(Token = "0x6000693")]
		[Address(RVA = "0xC3EC14", Offset = "0xC3EC14", VA = "0xC3EC14")]
		public string GetBankPlatform(FMODPlatform platform)
		{
			return null;
		}

		[Token(Token = "0x6000694")]
		[Address(RVA = "0xC3ECE0", Offset = "0xC3ECE0", VA = "0xC3ECE0")]
		private Settings()
		{
		}
	}
	[Token(Token = "0x2000110")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x918CF0", Offset = "0x918CF0")]
	public class StudioBankLoader : MonoBehaviour
	{
		[Token(Token = "0x4000588")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public LoaderGameEvent LoadEvent;

		[Token(Token = "0x4000589")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public LoaderGameEvent UnloadEvent;

		[Token(Token = "0x400058A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[BankRef]
		public List<string> Banks;

		[Token(Token = "0x400058B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string CollisionTag;

		[Token(Token = "0x400058C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool PreloadSamples;

		[Token(Token = "0x400058D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
		private bool isQuitting;

		[Token(Token = "0x600069E")]
		[Address(RVA = "0x1E3EADC", Offset = "0x1E3EADC", VA = "0x1E3EADC")]
		private void HandleGameEvent(LoaderGameEvent gameEvent)
		{
		}

		[Token(Token = "0x600069F")]
		[Address(RVA = "0x1E3EF1C", Offset = "0x1E3EF1C", VA = "0x1E3EF1C")]
		private void Start()
		{
		}

		[Token(Token = "0x60006A0")]
		[Address(RVA = "0x1E3EF48", Offset = "0x1E3EF48", VA = "0x1E3EF48")]
		private void OnApplicationQuit()
		{
		}

		[Token(Token = "0x60006A1")]
		[Address(RVA = "0x1E3EF54", Offset = "0x1E3EF54", VA = "0x1E3EF54")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60006A2")]
		[Address(RVA = "0x1E3EF68", Offset = "0x1E3EF68", VA = "0x1E3EF68")]
		private void OnTriggerEnter(Collider other)
		{
		}

		[Token(Token = "0x60006A3")]
		[Address(RVA = "0x1E3EFC8", Offset = "0x1E3EFC8", VA = "0x1E3EFC8")]
		private void OnTriggerExit(Collider other)
		{
		}

		[Token(Token = "0x60006A4")]
		[Address(RVA = "0x1E3F028", Offset = "0x1E3F028", VA = "0x1E3F028")]
		private void OnTriggerEnter2D(Collider2D other)
		{
		}

		[Token(Token = "0x60006A5")]
		[Address(RVA = "0x1E3F088", Offset = "0x1E3F088", VA = "0x1E3F088")]
		private void OnTriggerExit2D(Collider2D other)
		{
		}

		[Token(Token = "0x60006A6")]
		[Address(RVA = "0x1E3EB2C", Offset = "0x1E3EB2C", VA = "0x1E3EB2C")]
		public void Load()
		{
		}

		[Token(Token = "0x60006A7")]
		[Address(RVA = "0x1E3EDD8", Offset = "0x1E3EDD8", VA = "0x1E3EDD8")]
		public void Unload()
		{
		}

		[Token(Token = "0x60006A8")]
		[Address(RVA = "0x1E3F0E8", Offset = "0x1E3F0E8", VA = "0x1E3F0E8")]
		public StudioBankLoader()
		{
		}
	}
	[Token(Token = "0x2000111")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x918D28", Offset = "0x918D28")]
	public class StudioEventEmitter : EventHandler
	{
		[Token(Token = "0x400058E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[EventRef]
		public string Event;

		[Token(Token = "0x400058F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public EmitterGameEvent PlayEvent;

		[Token(Token = "0x4000590")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public EmitterGameEvent StopEvent;

		[Token(Token = "0x4000591")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool AllowFadeout;

		[Token(Token = "0x4000592")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
		public bool TriggerOnce;

		[Token(Token = "0x4000593")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x32")]
		public bool Preload;

		[Token(Token = "0x4000594")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public ParamRef[] Params;

		[Token(Token = "0x4000595")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public bool OverrideAttenuation;

		[Token(Token = "0x4000596")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float OverrideMinDistance;

		[Token(Token = "0x4000597")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float OverrideMaxDistance;

		[Token(Token = "0x4000598")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		protected EventDescription eventDescription;

		[Token(Token = "0x4000599")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		protected EventInstance instance;

		[Token(Token = "0x400059A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private bool hasTriggered;

		[Token(Token = "0x400059B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x61")]
		private bool isQuitting;

		[Token(Token = "0x400059C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x62")]
		private bool isOneshot;

		[Token(Token = "0x400059D")]
		private const string SnapshotString = "snapshot";

		[Token(Token = "0x17000012")]
		public EventDescription EventDescription
		{
			[Token(Token = "0x60006A9")]
			[Address(RVA = "0x1E3F0F0", Offset = "0x1E3F0F0", VA = "0x1E3F0F0")]
			get
			{
				return default(EventDescription);
			}
		}

		[Token(Token = "0x17000013")]
		public EventInstance EventInstance
		{
			[Token(Token = "0x60006AA")]
			[Address(RVA = "0x1E3F0F8", Offset = "0x1E3F0F8", VA = "0x1E3F0F8")]
			get
			{
				return default(EventInstance);
			}
		}

		[Token(Token = "0x60006AB")]
		[Address(RVA = "0x1E3F100", Offset = "0x1E3F100", VA = "0x1E3F100")]
		private void Start()
		{
		}

		[Token(Token = "0x60006AC")]
		[Address(RVA = "0x1E3F308", Offset = "0x1E3F308", VA = "0x1E3F308")]
		private void OnApplicationQuit()
		{
		}

		[Token(Token = "0x60006AD")]
		[Address(RVA = "0x1E3F314", Offset = "0x1E3F314", VA = "0x1E3F314")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60006AE")]
		[Address(RVA = "0x1E3F408", Offset = "0x1E3F408", VA = "0x1E3F408", Slot = "4")]
		protected override void HandleGameEvent(EmitterGameEvent gameEvent)
		{
		}

		[Token(Token = "0x60006AF")]
		[Address(RVA = "0x1E3F1DC", Offset = "0x1E3F1DC", VA = "0x1E3F1DC")]
		private void Lookup()
		{
		}

		[Token(Token = "0x60006B0")]
		[Address(RVA = "0x1E3F458", Offset = "0x1E3F458", VA = "0x1E3F458")]
		public void Play()
		{
		}

		[Token(Token = "0x60006B1")]
		[Address(RVA = "0x1E3F804", Offset = "0x1E3F804", VA = "0x1E3F804")]
		public void Stop()
		{
		}

		[Token(Token = "0x60006B2")]
		[Address(RVA = "0x1E3F868", Offset = "0x1E3F868", VA = "0x1E3F868")]
		public void SetParameter(string name, float value, bool ignoreseekspeed = false)
		{
		}

		[Token(Token = "0x60006B3")]
		[Address(RVA = "0x1E3F8D8", Offset = "0x1E3F8D8", VA = "0x1E3F8D8")]
		public void SetParameter(PARAMETER_ID id, float value, bool ignoreseekspeed = false)
		{
		}

		[Token(Token = "0x60006B4")]
		[Address(RVA = "0x1E3F948", Offset = "0x1E3F948", VA = "0x1E3F948")]
		public bool IsPlaying()
		{
			return default(bool);
		}

		[Token(Token = "0x60006B5")]
		[Address(RVA = "0x1E3F99C", Offset = "0x1E3F99C", VA = "0x1E3F99C")]
		public StudioEventEmitter()
		{
		}
	}
	[Token(Token = "0x2000112")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x918D60", Offset = "0x918D60")]
	public class StudioGlobalParameterTrigger : EventHandler
	{
		[Token(Token = "0x400059E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[ParamRef]
		public string parameter;

		[Token(Token = "0x400059F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public EmitterGameEvent TriggerEvent;

		[Token(Token = "0x40005A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float value;

		[Token(Token = "0x40005A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private PARAMETER_DESCRIPTION parameterDescription;

		[Token(Token = "0x17000014")]
		public PARAMETER_DESCRIPTION ParameterDesctription
		{
			[Token(Token = "0x60006B6")]
			[Address(RVA = "0x1E3FA24", Offset = "0x1E3FA24", VA = "0x1E3FA24")]
			get
			{
				return default(PARAMETER_DESCRIPTION);
			}
		}

		[Token(Token = "0x60006B7")]
		[Address(RVA = "0x1E3FA38", Offset = "0x1E3FA38", VA = "0x1E3FA38")]
		private RESULT Lookup()
		{
			return default(RESULT);
		}

		[Token(Token = "0x60006B8")]
		[Address(RVA = "0x1E3FC50", Offset = "0x1E3FC50", VA = "0x1E3FC50")]
		private void Awake()
		{
		}

		[Token(Token = "0x60006B9")]
		[Address(RVA = "0x1E3FC90", Offset = "0x1E3FC90", VA = "0x1E3FC90", Slot = "4")]
		protected override void HandleGameEvent(EmitterGameEvent gameEvent)
		{
		}

		[Token(Token = "0x60006BA")]
		[Address(RVA = "0x1E3FCA4", Offset = "0x1E3FCA4", VA = "0x1E3FCA4")]
		public void TriggerParameters()
		{
		}

		[Token(Token = "0x60006BB")]
		[Address(RVA = "0x1E3FDD8", Offset = "0x1E3FDD8", VA = "0x1E3FDD8")]
		public StudioGlobalParameterTrigger()
		{
		}
	}
	[Token(Token = "0x2000113")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x918D98", Offset = "0x918D98")]
	public class StudioListener : MonoBehaviour
	{
		[Token(Token = "0x40005A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Rigidbody rigidBody;

		[Token(Token = "0x40005A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Rigidbody2D rigidBody2D;

		[Token(Token = "0x40005A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public int ListenerNumber;

		[Token(Token = "0x60006BC")]
		[Address(RVA = "0x1E3FDE0", Offset = "0x1E3FDE0", VA = "0x1E3FDE0")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60006BD")]
		[Address(RVA = "0x1E3FEB8", Offset = "0x1E3FEB8", VA = "0x1E3FEB8")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60006BE")]
		[Address(RVA = "0x1E3FF1C", Offset = "0x1E3FF1C", VA = "0x1E3FF1C")]
		private void Update()
		{
		}

		[Token(Token = "0x60006BF")]
		[Address(RVA = "0x1E3FF30", Offset = "0x1E3FF30", VA = "0x1E3FF30")]
		private void SetListenerLocation()
		{
		}

		[Token(Token = "0x60006C0")]
		[Address(RVA = "0x1E4003C", Offset = "0x1E4003C", VA = "0x1E4003C")]
		public StudioListener()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000114")]
	public class EmitterRef
	{
		[Token(Token = "0x40005A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public StudioEventEmitter Target;

		[Token(Token = "0x40005A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public ParamRef[] Params;

		[Token(Token = "0x60006C1")]
		[Address(RVA = "0xC2D9A8", Offset = "0xC2D9A8", VA = "0xC2D9A8")]
		public EmitterRef()
		{
		}
	}
	[Token(Token = "0x2000115")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x918DD0", Offset = "0x918DD0")]
	public class StudioParameterTrigger : EventHandler
	{
		[Token(Token = "0x40005A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public EmitterRef[] Emitters;

		[Token(Token = "0x40005A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public EmitterGameEvent TriggerEvent;

		[Token(Token = "0x60006C2")]
		[Address(RVA = "0x1E4004C", Offset = "0x1E4004C", VA = "0x1E4004C")]
		private void Awake()
		{
		}

		[Token(Token = "0x60006C3")]
		[Address(RVA = "0x1E40248", Offset = "0x1E40248", VA = "0x1E40248", Slot = "4")]
		protected override void HandleGameEvent(EmitterGameEvent gameEvent)
		{
		}

		[Token(Token = "0x60006C4")]
		[Address(RVA = "0x1E4025C", Offset = "0x1E4025C", VA = "0x1E4025C")]
		public void TriggerParameters()
		{
		}

		[Token(Token = "0x60006C5")]
		[Address(RVA = "0x1E403F0", Offset = "0x1E403F0", VA = "0x1E403F0")]
		public StudioParameterTrigger()
		{
		}
	}
}
