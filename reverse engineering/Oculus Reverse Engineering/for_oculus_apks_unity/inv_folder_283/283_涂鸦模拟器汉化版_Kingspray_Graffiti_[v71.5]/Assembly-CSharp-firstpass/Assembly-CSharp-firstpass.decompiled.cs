using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
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
using UnityEngine.Rendering;
using UnityEngine.Timeline;

[assembly: AssemblyVersion("0.0.0.0")]
[Token(Token = "0x2000002")]
public static class FmodResonanceAudio
{
	[Token(Token = "0x2000130")]
	private struct RoomProperties
	{
		[Token(Token = "0x4000689")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float positionX;

		[Token(Token = "0x400068A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public float positionY;

		[Token(Token = "0x400068B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public float positionZ;

		[Token(Token = "0x400068C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public float rotationX;

		[Token(Token = "0x400068D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float rotationY;

		[Token(Token = "0x400068E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public float rotationZ;

		[Token(Token = "0x400068F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float rotationW;

		[Token(Token = "0x4000690")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float dimensionsX;

		[Token(Token = "0x4000691")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float dimensionsY;

		[Token(Token = "0x4000692")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float dimensionsZ;

		[Token(Token = "0x4000693")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public FmodResonanceAudioRoom.SurfaceMaterial materialLeft;

		[Token(Token = "0x4000694")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public FmodResonanceAudioRoom.SurfaceMaterial materialRight;

		[Token(Token = "0x4000695")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public FmodResonanceAudioRoom.SurfaceMaterial materialBottom;

		[Token(Token = "0x4000696")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public FmodResonanceAudioRoom.SurfaceMaterial materialTop;

		[Token(Token = "0x4000697")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public FmodResonanceAudioRoom.SurfaceMaterial materialFront;

		[Token(Token = "0x4000698")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public FmodResonanceAudioRoom.SurfaceMaterial materialBack;

		[Token(Token = "0x4000699")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float reflectionScalar;

		[Token(Token = "0x400069A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float reverbGain;

		[Token(Token = "0x400069B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float reverbTime;

		[Token(Token = "0x400069C")]
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
		[Address(RVA = "0x1037C18", Offset = "0x1037C18", VA = "0x1037C18")]
		get
		{
			return default(DSP);
		}
	}

	[Token(Token = "0x6000001")]
	[Address(RVA = "0x10376D0", Offset = "0x10376D0", VA = "0x10376D0")]
	public static void UpdateAudioRoom(FmodResonanceAudioRoom room, bool roomEnabled)
	{
	}

	[Token(Token = "0x6000002")]
	[Address(RVA = "0x1037DAC", Offset = "0x1037DAC", VA = "0x1037DAC")]
	public static bool IsListenerInsideRoom(FmodResonanceAudioRoom room)
	{
		return default(bool);
	}

	[Token(Token = "0x6000004")]
	[Address(RVA = "0x10384B8", Offset = "0x10384B8", VA = "0x10384B8")]
	private static float ConvertAmplitudeFromDb(float db)
	{
		return default(float);
	}

	[Token(Token = "0x6000005")]
	[Address(RVA = "0x1038530", Offset = "0x1038530", VA = "0x1038530")]
	private static void ConvertAudioTransformFromUnity(ref Vector3 position, ref Quaternion rotation)
	{
	}

	[Token(Token = "0x6000006")]
	[Address(RVA = "0x1037CDC", Offset = "0x1037CDC", VA = "0x1037CDC")]
	private static byte[] GetBytes(IntPtr ptr, int length)
	{
		return null;
	}

	[Token(Token = "0x6000007")]
	[Address(RVA = "0x10379CC", Offset = "0x10379CC", VA = "0x10379CC")]
	private static RoomProperties GetRoomProperties(FmodResonanceAudioRoom room)
	{
		return default(RoomProperties);
	}

	[Token(Token = "0x6000008")]
	[Address(RVA = "0x1038070", Offset = "0x1038070", VA = "0x1038070")]
	private static DSP Initialize()
	{
		return default(DSP);
	}
}
[Token(Token = "0x2000003")]
[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x8F1B98", Offset = "0x8F1B98")]
public class FmodResonanceAudioRoom : MonoBehaviour
{
	[Token(Token = "0x2000131")]
	public enum SurfaceMaterial
	{
		[Token(Token = "0x400069E")]
		Transparent,
		[Token(Token = "0x400069F")]
		AcousticCeilingTiles,
		[Token(Token = "0x40006A0")]
		BrickBare,
		[Token(Token = "0x40006A1")]
		BrickPainted,
		[Token(Token = "0x40006A2")]
		ConcreteBlockCoarse,
		[Token(Token = "0x40006A3")]
		ConcreteBlockPainted,
		[Token(Token = "0x40006A4")]
		CurtainHeavy,
		[Token(Token = "0x40006A5")]
		FiberglassInsulation,
		[Token(Token = "0x40006A6")]
		GlassThin,
		[Token(Token = "0x40006A7")]
		GlassThick,
		[Token(Token = "0x40006A8")]
		Grass,
		[Token(Token = "0x40006A9")]
		LinoleumOnConcrete,
		[Token(Token = "0x40006AA")]
		Marble,
		[Token(Token = "0x40006AB")]
		Metal,
		[Token(Token = "0x40006AC")]
		ParquetOnConcrete,
		[Token(Token = "0x40006AD")]
		PlasterRough,
		[Token(Token = "0x40006AE")]
		PlasterSmooth,
		[Token(Token = "0x40006AF")]
		PlywoodPanel,
		[Token(Token = "0x40006B0")]
		PolishedConcreteOrTile,
		[Token(Token = "0x40006B1")]
		Sheetrock,
		[Token(Token = "0x40006B2")]
		WaterOrIceSurface,
		[Token(Token = "0x40006B3")]
		WoodCeiling,
		[Token(Token = "0x40006B4")]
		WoodPanel
	}

	[Token(Token = "0x400000F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public SurfaceMaterial leftWall;

	[Token(Token = "0x4000010")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public SurfaceMaterial rightWall;

	[Token(Token = "0x4000011")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public SurfaceMaterial floor;

	[Token(Token = "0x4000012")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public SurfaceMaterial ceiling;

	[Token(Token = "0x4000013")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public SurfaceMaterial backWall;

	[Token(Token = "0x4000014")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public SurfaceMaterial frontWall;

	[Token(Token = "0x4000015")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public float reflectivity;

	[Token(Token = "0x4000016")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public float reverbGainDb;

	[Token(Token = "0x4000017")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public float reverbBrightness;

	[Token(Token = "0x4000018")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public float reverbTime;

	[Token(Token = "0x4000019")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Vector3 size;

	[Token(Token = "0x600000A")]
	[Address(RVA = "0x1038A50", Offset = "0x1038A50", VA = "0x1038A50")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x600000B")]
	[Address(RVA = "0x1038AC0", Offset = "0x1038AC0", VA = "0x1038AC0")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x600000C")]
	[Address(RVA = "0x1038B28", Offset = "0x1038B28", VA = "0x1038B28")]
	private void Update()
	{
	}

	[Token(Token = "0x600000D")]
	[Address(RVA = "0x1038B98", Offset = "0x1038B98", VA = "0x1038B98")]
	private void OnDrawGizmosSelected()
	{
	}

	[Token(Token = "0x600000E")]
	[Address(RVA = "0x1038C6C", Offset = "0x1038C6C", VA = "0x1038C6C")]
	public FmodResonanceAudioRoom()
	{
	}
}
[Serializable]
[Token(Token = "0x2000004")]
public class FMODEventPlayable : PlayableAsset, ITimelineClipAsset
{
	[Token(Token = "0x400001A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public FMODEventPlayableBehavior template;

	[Token(Token = "0x400001B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F2458", Offset = "0x8F2458")]
	private GameObject <TrackTargetObject>k__BackingField;

	[Token(Token = "0x400001C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float eventLength;

	[Token(Token = "0x400001D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private FMODEventPlayableBehavior behavior;

	[Token(Token = "0x400001E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[EventRef]
	[SerializeField]
	public string eventName;

	[Token(Token = "0x400001F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[SerializeField]
	public STOP_MODE stopType;

	[Token(Token = "0x4000020")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[SerializeField]
	public ParamRef[] parameters;

	[NonSerialized]
	[Token(Token = "0x4000021")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public bool cachedParameters;

	[Token(Token = "0x4000022")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F24C0", Offset = "0x8F24C0")]
	private TimelineClip <OwningClip>k__BackingField;

	[Token(Token = "0x17000002")]
	public GameObject TrackTargetObject
	{
		[Token(Token = "0x600000F")]
		[Address(RVA = "0x102D144", Offset = "0x102D144", VA = "0x102D144")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F2F40", Offset = "0x8F2F40")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000010")]
		[Address(RVA = "0x102D14C", Offset = "0x102D14C", VA = "0x102D14C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F2F50", Offset = "0x8F2F50")]
		set
		{
		}
	}

	[Token(Token = "0x17000003")]
	public override double duration
	{
		[Token(Token = "0x6000011")]
		[Address(RVA = "0x102D154", Offset = "0x102D154", VA = "0x102D154", Slot = "7")]
		get
		{
			return default(double);
		}
	}

	[Token(Token = "0x17000004")]
	public ClipCaps clipCaps
	{
		[Token(Token = "0x6000012")]
		[Address(RVA = "0x102D170", Offset = "0x102D170", VA = "0x102D170", Slot = "9")]
		get
		{
			return default(ClipCaps);
		}
	}

	[Token(Token = "0x17000005")]
	public TimelineClip OwningClip
	{
		[Token(Token = "0x6000013")]
		[Address(RVA = "0x102D178", Offset = "0x102D178", VA = "0x102D178")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F2F60", Offset = "0x8F2F60")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000014")]
		[Address(RVA = "0x102D180", Offset = "0x102D180", VA = "0x102D180")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F2F70", Offset = "0x8F2F70")]
		set
		{
		}
	}

	[Token(Token = "0x6000015")]
	[Address(RVA = "0x102D188", Offset = "0x102D188", VA = "0x102D188", Slot = "6")]
	public override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
	{
		return default(Playable);
	}

	[Token(Token = "0x6000016")]
	[Address(RVA = "0x102D47C", Offset = "0x102D47C", VA = "0x102D47C")]
	public FMODEventPlayable()
	{
	}
}
[Token(Token = "0x2000005")]
public enum STOP_MODE
{
	[Token(Token = "0x4000024")]
	AllowFadeout,
	[Token(Token = "0x4000025")]
	Immediate,
	[Token(Token = "0x4000026")]
	None
}
[Token(Token = "0x2000006")]
public class FMODEventPlayableBehavior : PlayableBehaviour
{
	[Token(Token = "0x4000027")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public string eventName;

	[Token(Token = "0x4000028")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public STOP_MODE stopType;

	[Token(Token = "0x4000029")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public ParamRef[] parameters;

	[Token(Token = "0x400002A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public GameObject TrackTargetObject;

	[Token(Token = "0x400002B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public TimelineClip OwningClip;

	[Token(Token = "0x400002C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private bool isPlayheadInside;

	[Token(Token = "0x400002D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private EventInstance eventInstance;

	[Token(Token = "0x6000017")]
	[Address(RVA = "0x102D558", Offset = "0x102D558", VA = "0x102D558")]
	protected void PlayEvent()
	{
	}

	[Token(Token = "0x6000018")]
	[Address(RVA = "0x102DC60", Offset = "0x102DC60", VA = "0x102DC60")]
	public void OnEnter()
	{
	}

	[Token(Token = "0x6000019")]
	[Address(RVA = "0x102DC94", Offset = "0x102DC94", VA = "0x102DC94")]
	public void OnExit()
	{
	}

	[Token(Token = "0x600001A")]
	[Address(RVA = "0x102D09C", Offset = "0x102D09C", VA = "0x102D09C")]
	public void UpdateBehaviour(float time)
	{
	}

	[Token(Token = "0x600001B")]
	[Address(RVA = "0x102DCFC", Offset = "0x102DCFC", VA = "0x102DCFC", Slot = "14")]
	public override void OnGraphStop(Playable playable)
	{
	}

	[Token(Token = "0x600001C")]
	[Address(RVA = "0x102D4F8", Offset = "0x102D4F8", VA = "0x102D4F8")]
	public FMODEventPlayableBehavior()
	{
	}
}
[Token(Token = "0x2000007")]
[AttributeAttribute(Name = "TrackColorAttribute", RVA = "0x8F1BD0", Offset = "0x8F1BD0")]
[AttributeAttribute(Name = "TrackClipTypeAttribute", RVA = "0x8F1BD0", Offset = "0x8F1BD0")]
[AttributeAttribute(Name = "TrackBindingTypeAttribute", RVA = "0x8F1BD0", Offset = "0x8F1BD0")]
public class FMODEventTrack : TrackAsset
{
	[Token(Token = "0x600001D")]
	[Address(RVA = "0x102DDB0", Offset = "0x102DDB0", VA = "0x102DDB0", Slot = "14")]
	public override Playable CreateTrackMixer(PlayableGraph graph, GameObject go, int inputCount)
	{
		return default(Playable);
	}

	[Token(Token = "0x600001E")]
	[Address(RVA = "0x102E1C0", Offset = "0x102E1C0", VA = "0x102E1C0")]
	public FMODEventTrack()
	{
	}
}
[Token(Token = "0x2000008")]
public class FMODEventMixerBehaviour : PlayableBehaviour
{
	[Token(Token = "0x600001F")]
	[Address(RVA = "0x102CF20", Offset = "0x102CF20", VA = "0x102CF20", Slot = "20")]
	public override void ProcessFrame(Playable playable, FrameData info, object playerData)
	{
	}

	[Token(Token = "0x6000020")]
	[Address(RVA = "0x102D13C", Offset = "0x102D13C", VA = "0x102D13C")]
	public FMODEventMixerBehaviour()
	{
	}
}
[Token(Token = "0x2000009")]
public class lzip
{
	[Token(Token = "0x2000132")]
	public class inMemory
	{
		[Token(Token = "0x40006B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public IntPtr pointer;

		[Token(Token = "0x40006B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public IntPtr zf;

		[Token(Token = "0x40006B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public IntPtr memStruct;

		[Token(Token = "0x40006B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public IntPtr fileStruct;

		[Token(Token = "0x40006B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public int[] info;

		[Token(Token = "0x40006BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public int lastResult;

		[Token(Token = "0x40006BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public bool isClosed;

		[Token(Token = "0x6000834")]
		[Address(RVA = "0x1D268B0", Offset = "0x1D268B0", VA = "0x1D268B0")]
		public int size()
		{
			return default(int);
		}

		[Token(Token = "0x6000835")]
		[Address(RVA = "0x1D268F4", Offset = "0x1D268F4", VA = "0x1D268F4")]
		public byte[] getZipBuffer()
		{
			return null;
		}

		[Token(Token = "0x6000836")]
		[Address(RVA = "0x1D24194", Offset = "0x1D24194", VA = "0x1D24194")]
		public inMemory()
		{
		}
	}

	[Token(Token = "0x2000133")]
	public struct zipInfo
	{
		[Token(Token = "0x40006BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public short VersionMadeBy;

		[Token(Token = "0x40006BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2")]
		public short MinimumVersionToExtract;

		[Token(Token = "0x40006BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public short BitFlag;

		[Token(Token = "0x40006BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6")]
		public short CompressionMethod;

		[Token(Token = "0x40006C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public short FileLastModificationTime;

		[Token(Token = "0x40006C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA")]
		public short FileLastModificationDate;

		[Token(Token = "0x40006C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public int CRC;

		[Token(Token = "0x40006C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int CompressedSize;

		[Token(Token = "0x40006C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public int UncompressedSize;

		[Token(Token = "0x40006C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public short DiskNumberWhereFileStarts;

		[Token(Token = "0x40006C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
		public short InternalFileAttributes;

		[Token(Token = "0x40006C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public int ExternalFileAttributes;

		[Token(Token = "0x40006C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public int RelativeOffsetOfLocalFileHeader;

		[Token(Token = "0x40006C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public int AbsoluteOffsetOfLocalFileHeaderStore;

		[Token(Token = "0x40006CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string filename;

		[Token(Token = "0x40006CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string extraField;

		[Token(Token = "0x40006CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public string fileComment;
	}

	[Token(Token = "0x400002E")]
	private const string libname = "zipw";

	[Token(Token = "0x400002F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static List<string> ninfo;

	[Token(Token = "0x4000030")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public static List<ulong> uinfo;

	[Token(Token = "0x4000031")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public static List<ulong> cinfo;

	[Token(Token = "0x4000032")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public static List<ulong> localOffset;

	[Token(Token = "0x4000033")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public static int zipFiles;

	[Token(Token = "0x4000034")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public static int zipFolders;

	[Token(Token = "0x4000035")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public static List<zipInfo> zinfo;

	[PreserveSig]
	[Token(Token = "0x6000021")]
	[Address(RVA = "0x1D1AD8C", Offset = "0x1D1AD8C", VA = "0x1D1AD8C")]
	internal static extern int zsetPermissions(string filePath, string _user, string _group, string _other);

	[PreserveSig]
	[Token(Token = "0x6000022")]
	[Address(RVA = "0x1D1AEAC", Offset = "0x1D1AEAC", VA = "0x1D1AEAC")]
	internal static extern bool zipValidateFile(string zipArchive, IntPtr FileBuffer, int fileBufferLength);

	[PreserveSig]
	[Token(Token = "0x6000023")]
	[Address(RVA = "0x1D1AF80", Offset = "0x1D1AF80", VA = "0x1D1AF80")]
	internal static extern int zipGetTotalFiles(string zipArchive, IntPtr FileBuffer, int fileBufferLength);

	[PreserveSig]
	[Token(Token = "0x6000024")]
	[Address(RVA = "0x1D1B050", Offset = "0x1D1B050", VA = "0x1D1B050")]
	internal static extern int zipGetTotalEntries(string zipArchive, IntPtr FileBuffer, int fileBufferLength);

	[PreserveSig]
	[Token(Token = "0x6000025")]
	[Address(RVA = "0x1D1B120", Offset = "0x1D1B120", VA = "0x1D1B120")]
	internal static extern int zipGetInfoA(string zipArchive, IntPtr total, IntPtr FileBuffer, int fileBufferLength);

	[PreserveSig]
	[Token(Token = "0x6000026")]
	[Address(RVA = "0x1D1B200", Offset = "0x1D1B200", VA = "0x1D1B200")]
	internal static extern IntPtr zipGetInfo(string zipArchive, int size, IntPtr unc, IntPtr comp, IntPtr offs, IntPtr FileBuffer, int fileBufferLength);

	[PreserveSig]
	[Token(Token = "0x6000027")]
	[Address(RVA = "0x1D1B300", Offset = "0x1D1B300", VA = "0x1D1B300")]
	internal static extern void releaseBuffer(IntPtr buffer);

	[PreserveSig]
	[Token(Token = "0x6000028")]
	[Address(RVA = "0x1D1B3A0", Offset = "0x1D1B3A0", VA = "0x1D1B3A0")]
	internal static extern ulong zipGetEntrySize(string zipArchive, string entry, IntPtr FileBuffer, int fileBufferLength);

	[PreserveSig]
	[Token(Token = "0x6000029")]
	[Address(RVA = "0x1D1B498", Offset = "0x1D1B498", VA = "0x1D1B498")]
	internal static extern bool zipEntryExists(string zipArchive, string entry, IntPtr FileBuffer, int fileBufferLength);

	[PreserveSig]
	[Token(Token = "0x600002A")]
	[Address(RVA = "0x1D1B594", Offset = "0x1D1B594", VA = "0x1D1B594")]
	internal static extern int zipCD(int levelOfCompression, string zipArchive, string inFilePath, string fileName, string comment, string password, bool useBz2, int diskSize, IntPtr bprog);

	[PreserveSig]
	[Token(Token = "0x600002B")]
	[Address(RVA = "0x1D1B700", Offset = "0x1D1B700", VA = "0x1D1B700")]
	internal static extern int zipCDList(int levelOfCompression, string zipArchive, IntPtr filename, int arrayLength, IntPtr prog, IntPtr filenameForced, string password, bool useBz2, int diskSize, IntPtr bprog);

	[PreserveSig]
	[Token(Token = "0x600002C")]
	[Address(RVA = "0x1D1B838", Offset = "0x1D1B838", VA = "0x1D1B838")]
	internal static extern bool zipBuf2File(int levelOfCompression, string zipArchive, string arc_filename, IntPtr buffer, int bufferSize, string comment, string password, bool useBz2);

	[PreserveSig]
	[Token(Token = "0x600002D")]
	[Address(RVA = "0x1D1B98C", Offset = "0x1D1B98C", VA = "0x1D1B98C")]
	internal static extern int zipDeleteFile(string zipArchive, string arc_filename, string tempArchive);

	[PreserveSig]
	[Token(Token = "0x600002E")]
	[Address(RVA = "0x1D1BA88", Offset = "0x1D1BA88", VA = "0x1D1BA88")]
	internal static extern int zipEntry2Buffer(string zipArchive, string entry, IntPtr buffer, int bufferSize, IntPtr FileBuffer, int fileBufferLength, string password);

	[PreserveSig]
	[Token(Token = "0x600002F")]
	[Address(RVA = "0x1D1BBB4", Offset = "0x1D1BBB4", VA = "0x1D1BBB4")]
	internal static extern IntPtr zipCompressBuffer(IntPtr source, int sourceLen, int levelOfCompression, ref int v);

	[PreserveSig]
	[Token(Token = "0x6000030")]
	[Address(RVA = "0x1D1BC7C", Offset = "0x1D1BC7C", VA = "0x1D1BC7C")]
	internal static extern IntPtr zipDecompressBuffer(IntPtr source, int sourceLen, ref int v);

	[PreserveSig]
	[Token(Token = "0x6000031")]
	[Address(RVA = "0x1D1BD34", Offset = "0x1D1BD34", VA = "0x1D1BD34")]
	internal static extern int zipEX(string zipArchive, string outPath, IntPtr progress, IntPtr FileBuffer, int fileBufferLength, IntPtr proc, string password);

	[PreserveSig]
	[Token(Token = "0x6000032")]
	[Address(RVA = "0x1D1BE60", Offset = "0x1D1BE60", VA = "0x1D1BE60")]
	internal static extern int zipEntry(string zipArchive, string arc_filename, string outpath, IntPtr FileBuffer, int fileBufferLength, IntPtr proc, string password);

	[PreserveSig]
	[Token(Token = "0x6000033")]
	[Address(RVA = "0x1D1BFA0", Offset = "0x1D1BFA0", VA = "0x1D1BFA0")]
	internal static extern uint getEntryDateTime(string zipArchive, string arc_filename, IntPtr FileBuffer, int fileBufferLength);

	[PreserveSig]
	[Token(Token = "0x6000034")]
	[Address(RVA = "0x1D1C098", Offset = "0x1D1C098", VA = "0x1D1C098")]
	internal static extern int freeMemStruct(IntPtr buffer);

	[PreserveSig]
	[Token(Token = "0x6000035")]
	[Address(RVA = "0x1D1C138", Offset = "0x1D1C138", VA = "0x1D1C138")]
	internal static extern IntPtr zipCDMem(IntPtr info, IntPtr pnt, int levelOfCompression, IntPtr source, int sourceLen, string fileName, string comment, string password, bool useBz2);

	[PreserveSig]
	[Token(Token = "0x6000036")]
	[Address(RVA = "0x1D1C280", Offset = "0x1D1C280", VA = "0x1D1C280")]
	internal static extern IntPtr initMemStruct();

	[PreserveSig]
	[Token(Token = "0x6000037")]
	[Address(RVA = "0x1D1C310", Offset = "0x1D1C310", VA = "0x1D1C310")]
	internal static extern IntPtr initFileStruct();

	[PreserveSig]
	[Token(Token = "0x6000038")]
	[Address(RVA = "0x1D1C3A0", Offset = "0x1D1C3A0", VA = "0x1D1C3A0")]
	internal static extern int freeMemZ(IntPtr pointer);

	[PreserveSig]
	[Token(Token = "0x6000039")]
	[Address(RVA = "0x1D1C43C", Offset = "0x1D1C43C", VA = "0x1D1C43C")]
	internal static extern int freeFileZ(IntPtr pointer);

	[PreserveSig]
	[Token(Token = "0x600003A")]
	[Address(RVA = "0x1D1C4DC", Offset = "0x1D1C4DC", VA = "0x1D1C4DC")]
	internal static extern IntPtr zipCDMemStart(IntPtr info, IntPtr pnt, IntPtr fileStruct, IntPtr memStruct);

	[PreserveSig]
	[Token(Token = "0x600003B")]
	[Address(RVA = "0x1D1C5A4", Offset = "0x1D1C5A4", VA = "0x1D1C5A4")]
	internal static extern int zipCDMemAdd(IntPtr zf, int levelOfCompression, IntPtr source, int sourceLen, string fileName, string comment, string password, bool useBz2);

	[PreserveSig]
	[Token(Token = "0x600003C")]
	[Address(RVA = "0x1D1C6E0", Offset = "0x1D1C6E0", VA = "0x1D1C6E0")]
	internal static extern IntPtr zipCDMemClose(IntPtr zf, IntPtr memStruct, IntPtr info, int err);

	[PreserveSig]
	[Token(Token = "0x600003D")]
	[Address(RVA = "0x1D1C7A8", Offset = "0x1D1C7A8", VA = "0x1D1C7A8")]
	internal static extern int zipGzip(IntPtr source, int sourceLen, IntPtr outBuffer, int levelOfCompression, bool addHeader, bool addFooter);

	[PreserveSig]
	[Token(Token = "0x600003E")]
	[Address(RVA = "0x1D1C888", Offset = "0x1D1C888", VA = "0x1D1C888")]
	internal static extern int zipUnGzip(IntPtr source, int sourceLen, IntPtr outBuffer, int outLen, bool hasHeader, bool hasFooter);

	[PreserveSig]
	[Token(Token = "0x600003F")]
	[Address(RVA = "0x1D1C968", Offset = "0x1D1C968", VA = "0x1D1C968")]
	internal static extern int zipUnGzip2(IntPtr source, int sourceLen, IntPtr outBuffer, int outLen);

	[PreserveSig]
	[Token(Token = "0x6000040")]
	[Address(RVA = "0x1D1CA30", Offset = "0x1D1CA30", VA = "0x1D1CA30")]
	public static extern void setCancel();

	[Token(Token = "0x6000041")]
	[Address(RVA = "0x1D1CAC0", Offset = "0x1D1CAC0", VA = "0x1D1CAC0")]
	public static int setFilePermissions(string filePath, string _user, string _group, string _other)
	{
		return default(int);
	}

	[Token(Token = "0x6000042")]
	[Address(RVA = "0x1D1CB4C", Offset = "0x1D1CB4C", VA = "0x1D1CB4C")]
	public static int getTotalFiles(string zipArchive, [Optional] byte[] FileBuffer)
	{
		return default(int);
	}

	[Token(Token = "0x6000043")]
	[Address(RVA = "0x1D1CC44", Offset = "0x1D1CC44", VA = "0x1D1CC44")]
	public static int getTotalEntries(string zipArchive, [Optional] byte[] FileBuffer)
	{
		return default(int);
	}

	[Token(Token = "0x6000044")]
	[Address(RVA = "0x1D1CD3C", Offset = "0x1D1CD3C", VA = "0x1D1CD3C")]
	public static int getEntryIndex(string entry)
	{
		return default(int);
	}

	[Token(Token = "0x6000045")]
	[Address(RVA = "0x1D1CEB8", Offset = "0x1D1CEB8", VA = "0x1D1CEB8")]
	public static ulong getFileInfo(string zipArchive, [Optional] byte[] FileBuffer)
	{
		return default(ulong);
	}

	[Token(Token = "0x6000046")]
	[Address(RVA = "0x1D1D6B0", Offset = "0x1D1D6B0", VA = "0x1D1D6B0")]
	public static ulong getEntrySize(string zipArchive, string entry, [Optional] byte[] FileBuffer)
	{
		return default(ulong);
	}

	[Token(Token = "0x6000047")]
	[Address(RVA = "0x1D1D7BC", Offset = "0x1D1D7BC", VA = "0x1D1D7BC")]
	public static bool entryExists(string zipArchive, string entry, [Optional] byte[] FileBuffer)
	{
		return default(bool);
	}

	[Token(Token = "0x6000048")]
	[Address(RVA = "0x1D1D8C8", Offset = "0x1D1D8C8", VA = "0x1D1D8C8")]
	public static bool buffer2File(int levelOfCompression, string zipArchive, string arc_filename, byte[] buffer, bool append = false, [Optional] string comment, [Optional] string password, bool useBz2 = false)
	{
		return default(bool);
	}

	[Token(Token = "0x6000049")]
	[Address(RVA = "0x1D1DA40", Offset = "0x1D1DA40", VA = "0x1D1DA40")]
	public static int delete_entry(string zipArchive, string arc_filename)
	{
		return default(int);
	}

	[Token(Token = "0x600004A")]
	[Address(RVA = "0x1D1DB28", Offset = "0x1D1DB28", VA = "0x1D1DB28")]
	public static int replace_entry(string zipArchive, string arc_filename, string newFilePath, int level = 9, [Optional] string comment, [Optional] string password, bool useBz2 = false)
	{
		return default(int);
	}

	[Token(Token = "0x600004B")]
	[Address(RVA = "0x1D1DC5C", Offset = "0x1D1DC5C", VA = "0x1D1DC5C")]
	public static int replace_entry(string zipArchive, string arc_filename, byte[] newFileBuffer, int level = 9, [Optional] string password, bool useBz2 = false)
	{
		return default(int);
	}

	[Token(Token = "0x600004C")]
	[Address(RVA = "0x1D1DD50", Offset = "0x1D1DD50", VA = "0x1D1DD50")]
	public static int extract_entry(string zipArchive, string arc_filename, string outpath, [Optional] byte[] FileBuffer, [Optional] ulong[] proc, [Optional] string password)
	{
		return default(int);
	}

	[Token(Token = "0x600004D")]
	[Address(RVA = "0x1D1DF8C", Offset = "0x1D1DF8C", VA = "0x1D1DF8C")]
	public static int decompress_File(string zipArchive, string outPath, int[] progress, [Optional] byte[] FileBuffer, [Optional] ulong[] proc, [Optional] string password)
	{
		return default(int);
	}

	[Token(Token = "0x600004E")]
	[Address(RVA = "0x1D1E244", Offset = "0x1D1E244", VA = "0x1D1E244")]
	public static int compress_File(int levelOfCompression, string zipArchive, string inFilePath, bool append = false, string fileName = "", [Optional] string comment, [Optional] string password, bool useBz2 = false, int diskSize = 0, [Optional] ulong[] byteProgress)
	{
		return default(int);
	}

	[Token(Token = "0x600004F")]
	[Address(RVA = "0x1D1E47C", Offset = "0x1D1E47C", VA = "0x1D1E47C")]
	public static int compress_File_List(int levelOfCompression, string zipArchive, string[] inFilePath, [Optional] int[] progress, bool append = false, [Optional] string[] fileName, [Optional] string password, bool useBz2 = false, int diskSize = 0, [Optional] ulong[] byteProgress)
	{
		return default(int);
	}

	[Token(Token = "0x6000050")]
	[Address(RVA = "0x1D1ECD8", Offset = "0x1D1ECD8", VA = "0x1D1ECD8")]
	public static int compressDir(string sourceDir, int levelOfCompression, string zipArchive, bool includeRoot = false, [Optional] int[] progress, [Optional] string password, bool useBz2 = false, int diskSize = 0, bool append = false, [Optional] ulong[] byteProgress)
	{
		return default(int);
	}

	[Token(Token = "0x6000051")]
	[Address(RVA = "0x1D1F578", Offset = "0x1D1F578", VA = "0x1D1F578")]
	public static int getAllFiles(string Dir)
	{
		return default(int);
	}

	[Token(Token = "0x6000052")]
	[Address(RVA = "0x1D1F5E4", Offset = "0x1D1F5E4", VA = "0x1D1F5E4")]
	public static DateTime entryDateTime(string zipArchive, string entry, [Optional] byte[] FileBuffer)
	{
		return default(DateTime);
	}

	[Token(Token = "0x6000053")]
	[Address(RVA = "0x1D1F7BC", Offset = "0x1D1F7BC", VA = "0x1D1F7BC")]
	public static void free_inmemory(inMemory t)
	{
	}

	[Token(Token = "0x6000054")]
	[Address(RVA = "0x1D1F9A4", Offset = "0x1D1F9A4", VA = "0x1D1F9A4")]
	public static bool inMemoryZipStart(inMemory t)
	{
		return default(bool);
	}

	[Token(Token = "0x6000055")]
	[Address(RVA = "0x1D1FCE0", Offset = "0x1D1FCE0", VA = "0x1D1FCE0")]
	public static int inMemoryZipAdd(inMemory t, int levelOfCompression, byte[] buffer, string fileName, [Optional] string comment, [Optional] string password, bool useBz2 = false)
	{
		return default(int);
	}

	[Token(Token = "0x6000056")]
	[Address(RVA = "0x1D1FB7C", Offset = "0x1D1FB7C", VA = "0x1D1FB7C")]
	public static IntPtr inMemoryZipClose(inMemory t)
	{
		return default(IntPtr);
	}

	[Token(Token = "0x6000057")]
	[Address(RVA = "0x1D1FECC", Offset = "0x1D1FECC", VA = "0x1D1FECC")]
	public static IntPtr compress_Buf2Mem(inMemory t, int levelOfCompression, byte[] buffer, string fileName, [Optional] string comment, [Optional] string password, bool useBz2 = false)
	{
		return default(IntPtr);
	}

	[Token(Token = "0x6000058")]
	[Address(RVA = "0x1D200F8", Offset = "0x1D200F8", VA = "0x1D200F8")]
	public static int decompress_Mem2File(inMemory t, string outPath, int[] progress, [Optional] int[] proc, [Optional] string password)
	{
		return default(int);
	}

	[Token(Token = "0x6000059")]
	[Address(RVA = "0x1D20354", Offset = "0x1D20354", VA = "0x1D20354")]
	public static int entry2BufferMem(inMemory t, string entry, ref byte[] buffer, [Optional] string password)
	{
		return default(int);
	}

	[Token(Token = "0x600005A")]
	[Address(RVA = "0x1D20548", Offset = "0x1D20548", VA = "0x1D20548")]
	public static byte[] entry2BufferMem(inMemory t, string entry, [Optional] string password)
	{
		return null;
	}

	[Token(Token = "0x600005B")]
	[Address(RVA = "0x1D20718", Offset = "0x1D20718", VA = "0x1D20718")]
	public static int entry2FixedBufferMem(inMemory t, string entry, ref byte[] fixedBuffer, [Optional] string password)
	{
		return default(int);
	}

	[Token(Token = "0x600005C")]
	[Address(RVA = "0x1D208FC", Offset = "0x1D208FC", VA = "0x1D208FC")]
	public static ulong getFileInfoMem(inMemory t)
	{
		return default(ulong);
	}

	[Token(Token = "0x600005D")]
	[Address(RVA = "0x1D2102C", Offset = "0x1D2102C", VA = "0x1D2102C")]
	public static int entry2Buffer(string zipArchive, string entry, ref byte[] buffer, [Optional] byte[] FileBuffer, [Optional] string password)
	{
		return default(int);
	}

	[Token(Token = "0x600005E")]
	[Address(RVA = "0x1D212A0", Offset = "0x1D212A0", VA = "0x1D212A0")]
	public static int entry2FixedBuffer(string zipArchive, string entry, ref byte[] fixedBuffer, [Optional] byte[] FileBuffer, [Optional] string password)
	{
		return default(int);
	}

	[Token(Token = "0x600005F")]
	[Address(RVA = "0x1D2152C", Offset = "0x1D2152C", VA = "0x1D2152C")]
	public static byte[] entry2Buffer(string zipArchive, string entry, [Optional] byte[] FileBuffer, [Optional] string password)
	{
		return null;
	}

	[Token(Token = "0x6000060")]
	[Address(RVA = "0x1D217A4", Offset = "0x1D217A4", VA = "0x1D217A4")]
	public static bool validateFile(string zipArchive, [Optional] byte[] FileBuffer)
	{
		return default(bool);
	}

	[Token(Token = "0x6000061")]
	[Address(RVA = "0x1D2189C", Offset = "0x1D2189C", VA = "0x1D2189C")]
	public static bool getZipInfo(string fileName)
	{
		return default(bool);
	}

	[Token(Token = "0x6000062")]
	[Address(RVA = "0x1D22700", Offset = "0x1D22700", VA = "0x1D22700")]
	public static bool getZipInfoMerged(string fileName, ref int pos, ref int size, bool getCentralDirectory = false)
	{
		return default(bool);
	}

	[Token(Token = "0x6000063")]
	[Address(RVA = "0x1D22B18", Offset = "0x1D22B18", VA = "0x1D22B18")]
	public static bool getZipInfoMerged(byte[] buffer, ref int pos, ref int size, bool getCentralDirectory = false)
	{
		return default(bool);
	}

	[Token(Token = "0x6000064")]
	[Address(RVA = "0x1D22F18", Offset = "0x1D22F18", VA = "0x1D22F18")]
	public static bool getZipInfoMerged(byte[] buffer)
	{
		return default(bool);
	}

	[Token(Token = "0x6000065")]
	[Address(RVA = "0x1D21CA8", Offset = "0x1D21CA8", VA = "0x1D21CA8")]
	private static bool findPK(BinaryReader reader)
	{
		return default(bool);
	}

	[Token(Token = "0x6000066")]
	[Address(RVA = "0x1D21E80", Offset = "0x1D21E80", VA = "0x1D21E80")]
	private static int findEnd(BinaryReader reader, ref int pos, ref int size)
	{
		return default(int);
	}

	[Token(Token = "0x6000067")]
	[Address(RVA = "0x1D221F0", Offset = "0x1D221F0", VA = "0x1D221F0")]
	private static void getCentralDir(BinaryReader reader, int count)
	{
	}

	[Token(Token = "0x6000068")]
	[Address(RVA = "0x1D2330C", Offset = "0x1D2330C", VA = "0x1D2330C")]
	public static byte[] getMergedZip(string filePath, ref int position, ref int siz)
	{
		return null;
	}

	[Token(Token = "0x6000069")]
	[Address(RVA = "0x1D2362C", Offset = "0x1D2362C", VA = "0x1D2362C")]
	public static byte[] getMergedZip(string filePath)
	{
		return null;
	}

	[Token(Token = "0x600006A")]
	[Address(RVA = "0x1D2393C", Offset = "0x1D2393C", VA = "0x1D2393C")]
	public static byte[] getMergedZip(byte[] buffer, ref int position, ref int siz)
	{
		return null;
	}

	[Token(Token = "0x600006B")]
	[Address(RVA = "0x1D23C5C", Offset = "0x1D23C5C", VA = "0x1D23C5C")]
	public static byte[] getMergedZip(byte[] buffer)
	{
		return null;
	}

	[Token(Token = "0x600006C")]
	[Address(RVA = "0x1D23F6C", Offset = "0x1D23F6C", VA = "0x1D23F6C")]
	public static int decompressZipMerged(string file, string outPath, int[] progress, [Optional] int[] proc, [Optional] string password)
	{
		return default(int);
	}

	[Token(Token = "0x600006D")]
	[Address(RVA = "0x1D24204", Offset = "0x1D24204", VA = "0x1D24204")]
	public static int decompressZipMerged(byte[] buffer, string outPath, int[] progress, [Optional] int[] proc, [Optional] string password)
	{
		return default(int);
	}

	[Token(Token = "0x600006E")]
	[Address(RVA = "0x1D2442C", Offset = "0x1D2442C", VA = "0x1D2442C")]
	private static void writeFile(byte[] tb, string entry, string outPath, string overrideEntryName, ref int res)
	{
	}

	[Token(Token = "0x600006F")]
	[Address(RVA = "0x1D245D4", Offset = "0x1D245D4", VA = "0x1D245D4")]
	public static int entry2FileMerged(string file, string entry, string outPath, [Optional] string overrideEntryName, [Optional] string password)
	{
		return default(int);
	}

	[Token(Token = "0x6000070")]
	[Address(RVA = "0x1D247FC", Offset = "0x1D247FC", VA = "0x1D247FC")]
	public static int entry2FileMerged(byte[] buffer, string entry, string outPath, [Optional] string overrideEntryName, [Optional] string password)
	{
		return default(int);
	}

	[Token(Token = "0x6000071")]
	[Address(RVA = "0x1D24A24", Offset = "0x1D24A24", VA = "0x1D24A24")]
	public static byte[] entry2BufferMerged(string file, string entry, [Optional] string password)
	{
		return null;
	}

	[Token(Token = "0x6000072")]
	[Address(RVA = "0x1D24BE8", Offset = "0x1D24BE8", VA = "0x1D24BE8")]
	public static int entry2BufferMerged(string file, string entry, ref byte[] refBuffer, [Optional] string password)
	{
		return default(int);
	}

	[Token(Token = "0x6000073")]
	[Address(RVA = "0x1D24DB4", Offset = "0x1D24DB4", VA = "0x1D24DB4")]
	public static int entry2FixedBufferMerged(string file, string entry, ref byte[] fixedBuffer, [Optional] string password)
	{
		return default(int);
	}

	[Token(Token = "0x6000074")]
	[Address(RVA = "0x1D24F80", Offset = "0x1D24F80", VA = "0x1D24F80")]
	public static byte[] entry2BufferMerged(byte[] buffer, string entry, [Optional] string password)
	{
		return null;
	}

	[Token(Token = "0x6000075")]
	[Address(RVA = "0x1D25140", Offset = "0x1D25140", VA = "0x1D25140")]
	public static int entry2BufferMerged(byte[] buffer, string entry, ref byte[] refBuffer, [Optional] string password)
	{
		return default(int);
	}

	[Token(Token = "0x6000076")]
	[Address(RVA = "0x1D2530C", Offset = "0x1D2530C", VA = "0x1D2530C")]
	public static int entry2FixedBufferMerged(byte[] buffer, string entry, ref byte[] fixedBuffer, [Optional] string password)
	{
		return default(int);
	}

	[Token(Token = "0x6000077")]
	[Address(RVA = "0x1D254D8", Offset = "0x1D254D8", VA = "0x1D254D8")]
	public static bool compressBuffer(byte[] source, ref byte[] outBuffer, int levelOfCompression)
	{
		return default(bool);
	}

	[Token(Token = "0x6000078")]
	[Address(RVA = "0x1D25680", Offset = "0x1D25680", VA = "0x1D25680")]
	public static int compressBufferFixed(byte[] source, ref byte[] outBuffer, int levelOfCompression, bool safe = true)
	{
		return default(int);
	}

	[Token(Token = "0x6000079")]
	[Address(RVA = "0x1D2585C", Offset = "0x1D2585C", VA = "0x1D2585C")]
	public static byte[] compressBuffer(byte[] source, int levelOfCompression)
	{
		return null;
	}

	[Token(Token = "0x600007A")]
	[Address(RVA = "0x1D25A00", Offset = "0x1D25A00", VA = "0x1D25A00")]
	public static bool decompressBuffer(byte[] source, ref byte[] outBuffer)
	{
		return default(bool);
	}

	[Token(Token = "0x600007B")]
	[Address(RVA = "0x1D25B90", Offset = "0x1D25B90", VA = "0x1D25B90")]
	public static int decompressBufferFixed(byte[] source, ref byte[] outBuffer, bool safe = true)
	{
		return default(int);
	}

	[Token(Token = "0x600007C")]
	[Address(RVA = "0x1D25D54", Offset = "0x1D25D54", VA = "0x1D25D54")]
	public static byte[] decompressBuffer(byte[] source)
	{
		return null;
	}

	[Token(Token = "0x600007D")]
	[Address(RVA = "0x1D25EE0", Offset = "0x1D25EE0", VA = "0x1D25EE0")]
	public static int gzip(byte[] source, byte[] outBuffer, int level, bool addHeader = true, bool addFooter = true, bool overrideDateTimeWithLength = false)
	{
		return default(int);
	}

	[Token(Token = "0x600007E")]
	[Address(RVA = "0x1D260E4", Offset = "0x1D260E4", VA = "0x1D260E4")]
	public static int gzipUncompressedSize(byte[] source)
	{
		return default(int);
	}

	[Token(Token = "0x600007F")]
	[Address(RVA = "0x1D261E0", Offset = "0x1D261E0", VA = "0x1D261E0")]
	public static int gzipCompressedSize(byte[] source, int offset = 0)
	{
		return default(int);
	}

	[Token(Token = "0x6000080")]
	[Address(RVA = "0x1D26368", Offset = "0x1D26368", VA = "0x1D26368")]
	public static int findGzStart(byte[] buffer)
	{
		return default(int);
	}

	[Token(Token = "0x6000081")]
	[Address(RVA = "0x1D26454", Offset = "0x1D26454", VA = "0x1D26454")]
	public static int unGzip(byte[] source, byte[] outBuffer, bool hasHeader = true, bool hasFooter = true)
	{
		return default(int);
	}

	[Token(Token = "0x6000082")]
	[Address(RVA = "0x1D26574", Offset = "0x1D26574", VA = "0x1D26574")]
	public static int unGzip2(byte[] source, byte[] outBuffer)
	{
		return default(int);
	}

	[Token(Token = "0x6000083")]
	[Address(RVA = "0x1D2667C", Offset = "0x1D2667C", VA = "0x1D2667C")]
	public static int unGzip2Merged(byte[] source, int offset, int bufferLength, byte[] outBuffer)
	{
		return default(int);
	}

	[Token(Token = "0x6000084")]
	[Address(RVA = "0x1D267BC", Offset = "0x1D267BC", VA = "0x1D267BC")]
	public lzip()
	{
	}
}
[Token(Token = "0x200000A")]
public static class MaterialModifier
{
	[Token(Token = "0x2000134")]
	public interface Interface
	{
		[Token(Token = "0x6000837")]
		void SetMaterialProp(int nameID, float value);

		[Token(Token = "0x6000838")]
		void SetMaterialProp(int nameID, Vector4 value);

		[Token(Token = "0x6000839")]
		void SetMaterialProp(int nameID, Color value);

		[Token(Token = "0x600083A")]
		void SetMaterialProp(int nameID, Matrix4x4 value);

		[Token(Token = "0x600083B")]
		void SetMaterialProp(int nameID, Texture value);
	}

	[Token(Token = "0x2000135")]
	public delegate void Callback(Interface owner);
}
[Token(Token = "0x200000B")]
public static class SRPHelper
{
	[Token(Token = "0x6000086")]
	[Address(RVA = "0x1039478", Offset = "0x1039478", VA = "0x1039478")]
	public static bool IsUsingCustomRenderPipeline()
	{
		return default(bool);
	}

	[Token(Token = "0x6000087")]
	[Address(RVA = "0x1039508", Offset = "0x1039508", VA = "0x1039508")]
	public static void RegisterOnBeginCameraRendering(Action<Camera> cb)
	{
	}

	[Token(Token = "0x6000088")]
	[Address(RVA = "0x103954C", Offset = "0x103954C", VA = "0x103954C")]
	public static void UnregisterOnBeginCameraRendering(Action<Camera> cb)
	{
	}
}
namespace VLB
{
	[Token(Token = "0x200000C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x8F1C84", Offset = "0x8F1C84")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x8F1C84", Offset = "0x8F1C84")]
	public class BeamGeometry : MonoBehaviour, MaterialModifier.Interface
	{
		[Token(Token = "0x2000136")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F23D8", Offset = "0x8F23D8")]
		private sealed class <CoUpdateFadeOut>d__30 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40006CD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40006CE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40006CF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public BeamGeometry <>4__this;

			[Token(Token = "0x17000058")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000843")]
				[Address(RVA = "0x103DC0C", Offset = "0x103DC0C", VA = "0x103DC0C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000059")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000845")]
				[Address(RVA = "0x103DC7C", Offset = "0x103DC7C", VA = "0x103DC7C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000840")]
			[Address(RVA = "0x1039978", Offset = "0x1039978", VA = "0x1039978")]
			[DebuggerHidden]
			public <CoUpdateFadeOut>d__30(int <>1__state)
			{
			}

			[Token(Token = "0x6000841")]
			[Address(RVA = "0x103DB6C", Offset = "0x103DB6C", VA = "0x103DB6C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000842")]
			[Address(RVA = "0x103DB70", Offset = "0x103DB70", VA = "0x103DB70", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000844")]
			[Address(RVA = "0x103DC14", Offset = "0x103DC14", VA = "0x103DC14", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000036")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private VolumetricLightBeam m_Master;

		[Token(Token = "0x4000037")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Matrix4x4 m_ColorGradientMatrix;

		[Token(Token = "0x4000038")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private MeshType m_CurrentMeshType;

		[Token(Token = "0x4000039")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Material m_CustomMaterial;

		[Token(Token = "0x400003A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private MaterialModifier.Callback m_MaterialModifierCallback;

		[Token(Token = "0x400003B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Coroutine m_CoFadeOut;

		[Token(Token = "0x400003C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F24D0", Offset = "0x8F24D0")]
		private MeshRenderer <meshRenderer>k__BackingField;

		[Token(Token = "0x400003D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F24E0", Offset = "0x8F24E0")]
		private MeshFilter <meshFilter>k__BackingField;

		[Token(Token = "0x400003E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F24F0", Offset = "0x8F24F0")]
		private Mesh <coneMesh>k__BackingField;

		[Token(Token = "0x400003F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Camera m_CurrentCameraRenderingSRP;

		[Token(Token = "0x17000006")]
		public MeshRenderer meshRenderer
		{
			[Token(Token = "0x6000089")]
			[Address(RVA = "0x1039584", Offset = "0x1039584", VA = "0x1039584")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F2F80", Offset = "0x8F2F80")]
			get
			{
				return null;
			}
			[Token(Token = "0x600008A")]
			[Address(RVA = "0x103958C", Offset = "0x103958C", VA = "0x103958C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F2F90", Offset = "0x8F2F90")]
			private set
			{
			}
		}

		[Token(Token = "0x17000007")]
		public MeshFilter meshFilter
		{
			[Token(Token = "0x600008B")]
			[Address(RVA = "0x1039594", Offset = "0x1039594", VA = "0x1039594")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F2FA0", Offset = "0x8F2FA0")]
			get
			{
				return null;
			}
			[Token(Token = "0x600008C")]
			[Address(RVA = "0x103959C", Offset = "0x103959C", VA = "0x103959C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F2FB0", Offset = "0x8F2FB0")]
			private set
			{
			}
		}

		[Token(Token = "0x17000008")]
		public Mesh coneMesh
		{
			[Token(Token = "0x600008D")]
			[Address(RVA = "0x10395A4", Offset = "0x10395A4", VA = "0x10395A4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F2FC0", Offset = "0x8F2FC0")]
			get
			{
				return null;
			}
			[Token(Token = "0x600008E")]
			[Address(RVA = "0x10395AC", Offset = "0x10395AC", VA = "0x10395AC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F2FD0", Offset = "0x8F2FD0")]
			private set
			{
			}
		}

		[Token(Token = "0x17000009")]
		public bool visible
		{
			[Token(Token = "0x600008F")]
			[Address(RVA = "0x10395B4", Offset = "0x10395B4", VA = "0x10395B4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000090")]
			[Address(RVA = "0x10395E4", Offset = "0x10395E4", VA = "0x10395E4")]
			set
			{
			}
		}

		[Token(Token = "0x1700000A")]
		public int sortingLayerID
		{
			[Token(Token = "0x6000091")]
			[Address(RVA = "0x103961C", Offset = "0x103961C", VA = "0x103961C")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000092")]
			[Address(RVA = "0x103964C", Offset = "0x103964C", VA = "0x103964C")]
			set
			{
			}
		}

		[Token(Token = "0x1700000B")]
		public int sortingOrder
		{
			[Token(Token = "0x6000093")]
			[Address(RVA = "0x1039684", Offset = "0x1039684", VA = "0x1039684")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000094")]
			[Address(RVA = "0x10396B4", Offset = "0x10396B4", VA = "0x10396B4")]
			set
			{
			}
		}

		[Token(Token = "0x1700000C")]
		public bool _INTERNAL_IsFadeOutCoroutineRunning
		{
			[Token(Token = "0x6000095")]
			[Address(RVA = "0x10396EC", Offset = "0x10396EC", VA = "0x10396EC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700000D")]
		public static bool isCustomRenderPipelineSupported
		{
			[Token(Token = "0x600009E")]
			[Address(RVA = "0x103A180", Offset = "0x103A180", VA = "0x103A180")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700000E")]
		private bool shouldUseGPUInstancedMaterial
		{
			[Token(Token = "0x600009F")]
			[Address(RVA = "0x103A188", Offset = "0x103A188", VA = "0x103A188")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700000F")]
		private bool isNoiseEnabled
		{
			[Token(Token = "0x60000A4")]
			[Address(RVA = "0x103C73C", Offset = "0x103C73C", VA = "0x103C73C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000010")]
		private bool isDepthBlendEnabled
		{
			[Token(Token = "0x60000A5")]
			[Address(RVA = "0x103C7EC", Offset = "0x103C7EC", VA = "0x103C7EC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000096")]
		[Address(RVA = "0x10396FC", Offset = "0x10396FC", VA = "0x10396FC")]
		private float ComputeFadeOutFactor(Transform camTransform)
		{
			return default(float);
		}

		[Token(Token = "0x6000097")]
		[Address(RVA = "0x1039904", Offset = "0x1039904", VA = "0x1039904")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x8F2FE0", Offset = "0x8F2FE0")]
		private IEnumerator CoUpdateFadeOut()
		{
			return null;
		}

		[Token(Token = "0x6000098")]
		[Address(RVA = "0x10399A4", Offset = "0x10399A4", VA = "0x10399A4")]
		private void ComputeFadeOutFactor()
		{
		}

		[Token(Token = "0x6000099")]
		[Address(RVA = "0x1039B50", Offset = "0x1039B50", VA = "0x1039B50")]
		private void SetFadeOutFactorProp(float value)
		{
		}

		[Token(Token = "0x600009A")]
		[Address(RVA = "0x1039EC4", Offset = "0x1039EC4", VA = "0x1039EC4")]
		public void RestartFadeOutCoroutine()
		{
		}

		[Token(Token = "0x600009B")]
		[Address(RVA = "0x1039F8C", Offset = "0x1039F8C", VA = "0x1039F8C")]
		private void Start()
		{
		}

		[Token(Token = "0x600009C")]
		[Address(RVA = "0x103A04C", Offset = "0x103A04C", VA = "0x103A04C")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600009D")]
		[Address(RVA = "0x103A0F4", Offset = "0x103A0F4", VA = "0x103A0F4")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60000A0")]
		[Address(RVA = "0x103A238", Offset = "0x103A238", VA = "0x103A238")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60000A1")]
		[Address(RVA = "0x103A2B8", Offset = "0x103A2B8", VA = "0x103A2B8")]
		public void Initialize(VolumetricLightBeam master)
		{
		}

		[Token(Token = "0x60000A2")]
		[Address(RVA = "0x103AAEC", Offset = "0x103AAEC", VA = "0x103AAEC")]
		public void RegenerateMesh()
		{
		}

		[Token(Token = "0x60000A3")]
		[Address(RVA = "0x103C610", Offset = "0x103C610", VA = "0x103C610")]
		private void ComputeLocalMatrix()
		{
		}

		[Token(Token = "0x60000A6")]
		[Address(RVA = "0x103A8AC", Offset = "0x103A8AC", VA = "0x103A8AC")]
		private bool ApplyMaterial()
		{
			return default(bool);
		}

		[Token(Token = "0x60000A7")]
		[Address(RVA = "0x1039CF0", Offset = "0x1039CF0", VA = "0x1039CF0", Slot = "4")]
		public void SetMaterialProp(int nameID, float value)
		{
		}

		[Token(Token = "0x60000A8")]
		[Address(RVA = "0x103CEA8", Offset = "0x103CEA8", VA = "0x103CEA8", Slot = "5")]
		public void SetMaterialProp(int nameID, Vector4 value)
		{
		}

		[Token(Token = "0x60000A9")]
		[Address(RVA = "0x103CFE0", Offset = "0x103CFE0", VA = "0x103CFE0", Slot = "6")]
		public void SetMaterialProp(int nameID, Color value)
		{
		}

		[Token(Token = "0x60000AA")]
		[Address(RVA = "0x103D118", Offset = "0x103D118", VA = "0x103D118", Slot = "7")]
		public void SetMaterialProp(int nameID, Matrix4x4 value)
		{
		}

		[Token(Token = "0x60000AB")]
		[Address(RVA = "0x103D278", Offset = "0x103D278", VA = "0x103D278", Slot = "8")]
		public void SetMaterialProp(int nameID, Texture value)
		{
		}

		[Token(Token = "0x60000AC")]
		[Address(RVA = "0x1039C24", Offset = "0x1039C24", VA = "0x1039C24")]
		private void MaterialChangeStart()
		{
		}

		[Token(Token = "0x60000AD")]
		[Address(RVA = "0x1039DF8", Offset = "0x1039DF8", VA = "0x1039DF8")]
		private void MaterialChangeStop()
		{
		}

		[Token(Token = "0x60000AE")]
		[Address(RVA = "0x103D35C", Offset = "0x103D35C", VA = "0x103D35C")]
		public void SetDynamicOcclusionCallback(string shaderKeyword, MaterialModifier.Callback cb)
		{
		}

		[Token(Token = "0x60000AF")]
		[Address(RVA = "0x103BE88", Offset = "0x103BE88", VA = "0x103BE88")]
		public void UpdateMaterialAndBounds()
		{
		}

		[Token(Token = "0x60000B0")]
		[Address(RVA = "0x103D450", Offset = "0x103D450", VA = "0x103D450")]
		private void UpdateMatricesPropertiesForGPUInstancingSRP()
		{
		}

		[Token(Token = "0x60000B1")]
		[Address(RVA = "0x103D5B4", Offset = "0x103D5B4", VA = "0x103D5B4")]
		private void OnBeginCameraRenderingSRP(Camera cam)
		{
		}

		[Token(Token = "0x60000B2")]
		[Address(RVA = "0x103D5BC", Offset = "0x103D5BC", VA = "0x103D5BC")]
		private void OnWillRenderObject()
		{
		}

		[Token(Token = "0x60000B3")]
		[Address(RVA = "0x103D5F8", Offset = "0x103D5F8", VA = "0x103D5F8")]
		private void OnWillCameraRenderThisBeam(Camera cam)
		{
		}

		[Token(Token = "0x60000B4")]
		[Address(RVA = "0x103D6F4", Offset = "0x103D6F4", VA = "0x103D6F4")]
		private void UpdateCameraRelatedProperties(Camera cam)
		{
		}

		[Token(Token = "0x60000B5")]
		[Address(RVA = "0x103DB64", Offset = "0x103DB64", VA = "0x103DB64")]
		public BeamGeometry()
		{
		}
	}
	[Token(Token = "0x200000D")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x8F1CF4", Offset = "0x8F1CF4")]
	public class Config : ScriptableObject
	{
		[Token(Token = "0x4000040")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool geometryOverrideLayer;

		[Token(Token = "0x4000041")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public int geometryLayerID;

		[Token(Token = "0x4000042")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string geometryTag;

		[Token(Token = "0x4000043")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public int geometryRenderQueue;

		[Token(Token = "0x4000044")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public RenderPipeline renderPipeline;

		[Token(Token = "0x4000045")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x8F2500", Offset = "0x8F2500")]
		public bool forceSinglePass;

		[Token(Token = "0x4000046")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public RenderingMode renderingMode;

		[Token(Token = "0x4000047")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		[HighlightNull]
		private Shader beamShader1Pass;

		[Token(Token = "0x4000048")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x8F2570", Offset = "0x8F2570")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x8F2570", Offset = "0x8F2570")]
		[SerializeField]
		[HighlightNull]
		private Shader beamShader2Pass;

		[Token(Token = "0x4000049")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		[HighlightNull]
		private Shader beamShaderSRP;

		[Token(Token = "0x400004A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public int sharedMeshSides;

		[Token(Token = "0x400004B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public int sharedMeshSegments;

		[Token(Token = "0x400004C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8F2628", Offset = "0x8F2628")]
		public float globalNoiseScale;

		[Token(Token = "0x400004D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public Vector3 globalNoiseVelocity;

		[Token(Token = "0x400004E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public string fadeOutCameraTag;

		[Token(Token = "0x400004F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[HighlightNull]
		public TextAsset noise3DData;

		[Token(Token = "0x4000050")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public int noise3DSize;

		[Token(Token = "0x4000051")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[HighlightNull]
		public ParticleSystem dustParticlesPrefab;

		[Token(Token = "0x4000052")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[SerializeField]
		private int pluginVersion;

		[Token(Token = "0x4000053")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Transform m_CachedFadeOutCamera;

		[Token(Token = "0x4000054")]
		private const string kAssetName = "Config";

		[Token(Token = "0x4000055")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static Config m_Instance;

		[Token(Token = "0x17000011")]
		public RenderingMode actualRenderingMode
		{
			[Token(Token = "0x60000B6")]
			[Address(RVA = "0x103A230", Offset = "0x103A230", VA = "0x103A230")]
			get
			{
				return default(RenderingMode);
			}
		}

		[Token(Token = "0x17000012")]
		public bool useSinglePassShader
		{
			[Token(Token = "0x60000B7")]
			[Address(RVA = "0x103AEAC", Offset = "0x103AEAC", VA = "0x103AEAC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000013")]
		public Shader beamShader
		{
			[Token(Token = "0x60000B8")]
			[Address(RVA = "0x103DC84", Offset = "0x103DC84", VA = "0x103DC84")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000014")]
		public Vector4 globalNoiseParam
		{
			[Token(Token = "0x60000B9")]
			[Address(RVA = "0x103DD1C", Offset = "0x103DD1C", VA = "0x103DD1C")]
			get
			{
				return default(Vector4);
			}
		}

		[Token(Token = "0x17000015")]
		public Transform fadeOutCameraTransform
		{
			[Token(Token = "0x60000BA")]
			[Address(RVA = "0x1039ACC", Offset = "0x1039ACC", VA = "0x1039ACC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000016")]
		public static Config Instance
		{
			[Token(Token = "0x60000C4")]
			[Address(RVA = "0x1039A6C", Offset = "0x1039A6C", VA = "0x1039A6C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60000BB")]
		[Address(RVA = "0x103DD54", Offset = "0x103DD54", VA = "0x103DD54")]
		public void ForceUpdateFadeOutCamera()
		{
		}

		[Token(Token = "0x60000BC")]
		[Address(RVA = "0x103DDF4", Offset = "0x103DDF4", VA = "0x103DDF4")]
		[AttributeAttribute(Name = "RuntimeInitializeOnLoadMethodAttribute", RVA = "0x8F4044", Offset = "0x8F4044")]
		private static void OnStartup()
		{
		}

		[Token(Token = "0x60000BD")]
		[Address(RVA = "0x103DD10", Offset = "0x103DD10", VA = "0x103DD10")]
		private static bool ShouldEnableSrpApi(RenderPipeline pipeline)
		{
			return default(bool);
		}

		[Token(Token = "0x60000BE")]
		[Address(RVA = "0x103DE78", Offset = "0x103DE78", VA = "0x103DE78")]
		public static void OnRenderPipelineChanged(RenderPipeline pipeline)
		{
		}

		[Token(Token = "0x60000BF")]
		[Address(RVA = "0x103DF10", Offset = "0x103DF10", VA = "0x103DF10")]
		public void Reset()
		{
		}

		[Token(Token = "0x60000C0")]
		[Address(RVA = "0x103DFD0", Offset = "0x103DFD0", VA = "0x103DFD0")]
		public void ResetInternalData()
		{
		}

		[Token(Token = "0x60000C1")]
		[Address(RVA = "0x103E134", Offset = "0x103E134", VA = "0x103E134")]
		public ParticleSystem NewVolumetricDustParticles()
		{
			return null;
		}

		[Token(Token = "0x60000C2")]
		[Address(RVA = "0x103E32C", Offset = "0x103E32C", VA = "0x103E32C")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60000C3")]
		[Address(RVA = "0x103E35C", Offset = "0x103E35C", VA = "0x103E35C")]
		private void HandleBackwardCompatibility(int serializedVersion, int newVersion)
		{
		}

		[Token(Token = "0x60000C5")]
		[Address(RVA = "0x103E42C", Offset = "0x103E42C", VA = "0x103E42C")]
		private static Config GetInstance(bool assertIfNotFound)
		{
			return null;
		}

		[Token(Token = "0x60000C6")]
		[Address(RVA = "0x103E5A4", Offset = "0x103E5A4", VA = "0x103E5A4")]
		public Config()
		{
		}
	}
	[Token(Token = "0x200000E")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x8F1D2C", Offset = "0x8F1D2C")]
	public class ConfigOverride : Config
	{
		[Token(Token = "0x4000056")]
		public const string kAssetName = "VLBConfigOverride";

		[Token(Token = "0x60000C8")]
		[Address(RVA = "0x103E680", Offset = "0x103E680", VA = "0x103E680")]
		public ConfigOverride()
		{
		}
	}
	[Token(Token = "0x200000F")]
	public static class Consts
	{
		[Token(Token = "0x4000057")]
		private const string HelpUrlBase = "http://saladgamer.com/vlb-doc/";

		[Token(Token = "0x4000058")]
		public const string HelpUrlBeam = "http://saladgamer.com/vlb-doc/comp-lightbeam/";

		[Token(Token = "0x4000059")]
		public const string HelpUrlDustParticles = "http://saladgamer.com/vlb-doc/comp-dustparticles/";

		[Token(Token = "0x400005A")]
		public const string HelpUrlDynamicOcclusionRaycasting = "http://saladgamer.com/vlb-doc/comp-dynocclusion-raycasting/";

		[Token(Token = "0x400005B")]
		public const string HelpUrlDynamicOcclusionDepthBuffer = "http://saladgamer.com/vlb-doc/comp-dynocclusion-depthbuffer/";

		[Token(Token = "0x400005C")]
		public const string HelpUrlTriggerZone = "http://saladgamer.com/vlb-doc/comp-triggerzone/";

		[Token(Token = "0x400005D")]
		public const string HelpUrlConfig = "http://saladgamer.com/vlb-doc/config/";

		[Token(Token = "0x400005E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly bool ProceduralObjectsVisibleInEditor;

		[Token(Token = "0x400005F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public static readonly Color FlatColor;

		[Token(Token = "0x4000060")]
		public const ColorMode ColorModeDefault = ColorMode.Flat;

		[Token(Token = "0x4000061")]
		public const float IntensityDefault = 1f;

		[Token(Token = "0x4000062")]
		public const float IntensityMin = 0f;

		[Token(Token = "0x4000063")]
		public const float IntensityMax = 8f;

		[Token(Token = "0x4000064")]
		public const float SpotAngleDefault = 35f;

		[Token(Token = "0x4000065")]
		public const float SpotAngleMin = 0.1f;

		[Token(Token = "0x4000066")]
		public const float SpotAngleMax = 179.9f;

		[Token(Token = "0x4000067")]
		public const float ConeRadiusStart = 0.1f;

		[Token(Token = "0x4000068")]
		public const MeshType GeomMeshType = MeshType.Shared;

		[Token(Token = "0x4000069")]
		public const int GeomSidesDefault = 18;

		[Token(Token = "0x400006A")]
		public const int GeomSidesMin = 3;

		[Token(Token = "0x400006B")]
		public const int GeomSidesMax = 256;

		[Token(Token = "0x400006C")]
		public const int GeomSegmentsDefault = 5;

		[Token(Token = "0x400006D")]
		public const int GeomSegmentsMin = 0;

		[Token(Token = "0x400006E")]
		public const int GeomSegmentsMax = 64;

		[Token(Token = "0x400006F")]
		public const bool GeomCap = false;

		[Token(Token = "0x4000070")]
		public const AttenuationEquation AttenuationEquationDefault = AttenuationEquation.Quadratic;

		[Token(Token = "0x4000071")]
		public const float AttenuationCustomBlending = 0.5f;

		[Token(Token = "0x4000072")]
		public const float FallOffStart = 0f;

		[Token(Token = "0x4000073")]
		public const float FallOffEnd = 3f;

		[Token(Token = "0x4000074")]
		public const float FallOffDistancesMinThreshold = 0.01f;

		[Token(Token = "0x4000075")]
		public const float DepthBlendDistance = 2f;

		[Token(Token = "0x4000076")]
		public const float CameraClippingDistance = 0.5f;

		[Token(Token = "0x4000077")]
		public const float FresnelPowMaxValue = 10f;

		[Token(Token = "0x4000078")]
		public const float FresnelPow = 8f;

		[Token(Token = "0x4000079")]
		public const float GlareFrontal = 0.5f;

		[Token(Token = "0x400007A")]
		public const float GlareBehind = 0.5f;

		[Token(Token = "0x400007B")]
		public const NoiseMode NoiseModeDefault = NoiseMode.Disabled;

		[Token(Token = "0x400007C")]
		public const float NoiseIntensityMin = 0f;

		[Token(Token = "0x400007D")]
		public const float NoiseIntensityMax = 1f;

		[Token(Token = "0x400007E")]
		public const float NoiseIntensityDefault = 0.5f;

		[Token(Token = "0x400007F")]
		public const float NoiseScaleMin = 0.01f;

		[Token(Token = "0x4000080")]
		public const float NoiseScaleMax = 2f;

		[Token(Token = "0x4000081")]
		public const float NoiseScaleDefault = 0.5f;

		[Token(Token = "0x4000082")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public static readonly Vector3 NoiseVelocityDefault;

		[Token(Token = "0x4000083")]
		public const BlendingMode BlendingModeDefault = BlendingMode.Additive;

		[Token(Token = "0x4000084")]
		public const float FadeOutBeginDefault = -150f;

		[Token(Token = "0x4000085")]
		public const float FadeOutEndDefault = -200f;

		[Token(Token = "0x4000086")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public static readonly LayerMask DynOcclusionLayerMaskDefault;

		[Token(Token = "0x4000087")]
		public const float DynOcclusionFadeDistanceToSurfaceDefault = 0.25f;

		[Token(Token = "0x4000088")]
		public const DynamicOcclusionUpdateRate DynamicOcclusionUpdateRateDefault = DynamicOcclusionUpdateRate.EveryXFrames;

		[Token(Token = "0x4000089")]
		public const int DynOcclusionWaitFramesCountDefault = 3;

		[Token(Token = "0x400008A")]
		public const OccluderDimensions DynOcclusionRaycastingDimensionsDefault = OccluderDimensions.Occluders3D;

		[Token(Token = "0x400008B")]
		public const bool DynOcclusionRaycastingConsiderTriggersDefault = false;

		[Token(Token = "0x400008C")]
		public const float DynOcclusionRaycastingMinOccluderAreaDefault = 0f;

		[Token(Token = "0x400008D")]
		public const float DynOcclusionRaycastingMinSurfaceRatioDefault = 0.5f;

		[Token(Token = "0x400008E")]
		public const float DynOcclusionRaycastingMinSurfaceRatioMin = 50f;

		[Token(Token = "0x400008F")]
		public const float DynOcclusionRaycastingMinSurfaceRatioMax = 100f;

		[Token(Token = "0x4000090")]
		public const float DynOcclusionRaycastingMaxSurfaceDotDefault = 0.25f;

		[Token(Token = "0x4000091")]
		public const float DynOcclusionRaycastingMaxSurfaceAngleMin = 45f;

		[Token(Token = "0x4000092")]
		public const float DynOcclusionRaycastingMaxSurfaceAngleMax = 90f;

		[Token(Token = "0x4000093")]
		public const PlaneAlignment DynOcclusionRaycastingPlaneAlignmentDefault = PlaneAlignment.Surface;

		[Token(Token = "0x4000094")]
		public const float DynOcclusionRaycastingPlaneOffsetDefault = 0.1f;

		[Token(Token = "0x4000095")]
		public const int DynOcclusionDepthBufferDepthMapResolutionDefault = 32;

		[Token(Token = "0x4000096")]
		public const bool DynOcclusionDepthBufferOcclusionCullingDefault = true;

		[Token(Token = "0x4000097")]
		public const bool ConfigGeometryOverrideLayerDefault = true;

		[Token(Token = "0x4000098")]
		public const int ConfigGeometryLayerIDDefault = 1;

		[Token(Token = "0x4000099")]
		public const string ConfigGeometryTagDefault = "Untagged";

		[Token(Token = "0x400009A")]
		public const string ConfigFadeOutCameraTagDefault = "MainCamera";

		[Token(Token = "0x400009B")]
		public const RenderQueue ConfigGeometryRenderQueueDefault = RenderQueue.Transparent;

		[Token(Token = "0x400009C")]
		public const RenderPipeline ConfigGeometryRenderPipelineDefault = RenderPipeline.BuiltIn;

		[Token(Token = "0x400009D")]
		public const RenderingMode ConfigGeometryRenderingModeDefault = RenderingMode.MultiPass;

		[Token(Token = "0x400009E")]
		public const int ConfigNoise3DSizeDefault = 64;

		[Token(Token = "0x400009F")]
		public const int ConfigSharedMeshSides = 24;

		[Token(Token = "0x40000A0")]
		public const int ConfigSharedMeshSegments = 5;

		[Token(Token = "0x17000017")]
		public static HideFlags ProceduralObjectsHideFlags
		{
			[Token(Token = "0x60000C9")]
			[Address(RVA = "0x103A688", Offset = "0x103A688", VA = "0x103A688")]
			get
			{
				return default(HideFlags);
			}
		}
	}
	[Token(Token = "0x2000010")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x8F1D64", Offset = "0x8F1D64")]
	[DisallowMultipleComponent]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x8F1D64", Offset = "0x8F1D64")]
	public abstract class DynamicOcclusionAbstractBase : MonoBehaviour
	{
		[Token(Token = "0x2000137")]
		protected enum ProcessOcclusionSource
		{
			[Token(Token = "0x40006D1")]
			RenderLoop,
			[Token(Token = "0x40006D2")]
			OnEnable,
			[Token(Token = "0x40006D3")]
			EditorUpdate,
			[Token(Token = "0x40006D4")]
			User
		}

		[Token(Token = "0x40000A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public DynamicOcclusionUpdateRate updateRate;

		[Token(Token = "0x40000A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x8F2674", Offset = "0x8F2674")]
		public int waitXFrames;

		[Token(Token = "0x40000A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static bool _INTERNAL_ApplyRandomFrameOffset;

		[Token(Token = "0x40000A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private TransformUtils.Packed m_TransformPacked;

		[Token(Token = "0x40000A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private int m_LastFrameRendered;

		[Token(Token = "0x40000A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		protected VolumetricLightBeam m_Master;

		[Token(Token = "0x17000018")]
		public int _INTERNAL_LastFrameRendered
		{
			[Token(Token = "0x60000CD")]
			[Address(RVA = "0x103E9A0", Offset = "0x103E9A0", VA = "0x103E9A0")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x60000CB")]
		[Address(RVA = "0x103E7B4", Offset = "0x103E7B4", VA = "0x103E7B4")]
		public void ProcessOcclusionManually()
		{
		}

		[Token(Token = "0x60000CC")]
		[Address(RVA = "0x103E7BC", Offset = "0x103E7BC", VA = "0x103E7BC")]
		protected void ProcessOcclusion(ProcessOcclusionSource source)
		{
		}

		[Token(Token = "0x60000CE")]
		protected abstract string GetShaderKeyword();

		[Token(Token = "0x60000CF")]
		protected abstract MaterialManager.DynamicOcclusion GetDynamicOcclusionMode();

		[Token(Token = "0x60000D0")]
		protected abstract bool OnProcessOcclusion(ProcessOcclusionSource source);

		[Token(Token = "0x60000D1")]
		protected abstract void OnModifyMaterialCallback(MaterialModifier.Interface owner);

		[Token(Token = "0x60000D2")]
		protected abstract void OnEnablePostValidate();

		[Token(Token = "0x60000D3")]
		[Address(RVA = "0x103E9A8", Offset = "0x103E9A8", VA = "0x103E9A8", Slot = "9")]
		protected virtual void OnValidateProperties()
		{
		}

		[Token(Token = "0x60000D4")]
		[Address(RVA = "0x103EA24", Offset = "0x103EA24", VA = "0x103EA24", Slot = "10")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x60000D5")]
		[Address(RVA = "0x103EAAC", Offset = "0x103EAAC", VA = "0x103EAAC", Slot = "11")]
		protected virtual void OnDestroy()
		{
		}

		[Token(Token = "0x60000D6")]
		[Address(RVA = "0x103EB34", Offset = "0x103EB34", VA = "0x103EB34", Slot = "12")]
		protected virtual void OnEnable()
		{
		}

		[Token(Token = "0x60000D7")]
		[Address(RVA = "0x103EC8C", Offset = "0x103EC8C", VA = "0x103EC8C", Slot = "13")]
		protected virtual void OnDisable()
		{
		}

		[Token(Token = "0x60000D8")]
		[Address(RVA = "0x103ED24", Offset = "0x103ED24", VA = "0x103ED24")]
		private void OnWillCameraRender(Camera cam)
		{
		}

		[Token(Token = "0x60000D9")]
		[Address(RVA = "0x103EAEC", Offset = "0x103EAEC", VA = "0x103EAEC")]
		private void DisableOcclusion()
		{
		}

		[Token(Token = "0x60000DA")]
		[Address(RVA = "0x103EEC8", Offset = "0x103EEC8", VA = "0x103EEC8")]
		protected DynamicOcclusionAbstractBase()
		{
		}

		[Token(Token = "0x60000DC")]
		[Address(RVA = "0x103EF38", Offset = "0x103EF38", VA = "0x103EF38")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F4054", Offset = "0x8F4054")]
		private void <OnEnable>b__19_0()
		{
		}
	}
	[Token(Token = "0x2000011")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x8F1DFC", Offset = "0x8F1DFC")]
	public class DynamicOcclusionDepthBuffer : DynamicOcclusionAbstractBase
	{
		[Token(Token = "0x40000A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public LayerMask layerMask;

		[Token(Token = "0x40000A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public bool useOcclusionCulling;

		[Token(Token = "0x40000A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public int depthMapResolution;

		[Token(Token = "0x40000AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float fadeDistanceToSurface;

		[Token(Token = "0x40000AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Camera m_DepthCamera;

		[Token(Token = "0x40000AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private bool m_NeedToUpdateOcclusionNextFrame;

		[Token(Token = "0x60000DD")]
		[Address(RVA = "0x103EF40", Offset = "0x103EF40", VA = "0x103EF40", Slot = "4")]
		protected override string GetShaderKeyword()
		{
			return null;
		}

		[Token(Token = "0x60000DE")]
		[Address(RVA = "0x103EF88", Offset = "0x103EF88", VA = "0x103EF88", Slot = "5")]
		protected override MaterialManager.DynamicOcclusion GetDynamicOcclusionMode()
		{
			return default(MaterialManager.DynamicOcclusion);
		}

		[Token(Token = "0x60000DF")]
		[Address(RVA = "0x103EF90", Offset = "0x103EF90", VA = "0x103EF90")]
		private void ProcessOcclusionInternal()
		{
		}

		[Token(Token = "0x60000E0")]
		[Address(RVA = "0x103F200", Offset = "0x103F200", VA = "0x103F200", Slot = "6")]
		protected override bool OnProcessOcclusion(ProcessOcclusionSource source)
		{
			return default(bool);
		}

		[Token(Token = "0x60000E1")]
		[Address(RVA = "0x103F240", Offset = "0x103F240", VA = "0x103F240")]
		private void Update()
		{
		}

		[Token(Token = "0x60000E2")]
		[Address(RVA = "0x103EFC8", Offset = "0x103EFC8", VA = "0x103EFC8")]
		private void UpdateDepthCameraPropertiesAccordingToBeam()
		{
		}

		[Token(Token = "0x60000E3")]
		[Address(RVA = "0x103F2FC", Offset = "0x103F2FC", VA = "0x103F2FC")]
		public bool HasLayerMaskIssues()
		{
			return default(bool);
		}

		[Token(Token = "0x60000E4")]
		[Address(RVA = "0x103F3D0", Offset = "0x103F3D0", VA = "0x103F3D0", Slot = "9")]
		protected override void OnValidateProperties()
		{
		}

		[Token(Token = "0x60000E5")]
		[Address(RVA = "0x103F470", Offset = "0x103F470", VA = "0x103F470")]
		private void InstantiateOrActivateDepthCamera()
		{
		}

		[Token(Token = "0x60000E6")]
		[Address(RVA = "0x103F7CC", Offset = "0x103F7CC", VA = "0x103F7CC", Slot = "8")]
		protected override void OnEnablePostValidate()
		{
		}

		[Token(Token = "0x60000E7")]
		[Address(RVA = "0x103F7D0", Offset = "0x103F7D0", VA = "0x103F7D0", Slot = "13")]
		protected override void OnDisable()
		{
		}

		[Token(Token = "0x60000E8")]
		[Address(RVA = "0x103F88C", Offset = "0x103F88C", VA = "0x103F88C", Slot = "10")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x60000E9")]
		[Address(RVA = "0x103F890", Offset = "0x103F890", VA = "0x103F890", Slot = "11")]
		protected override void OnDestroy()
		{
		}

		[Token(Token = "0x60000EA")]
		[Address(RVA = "0x103F8B4", Offset = "0x103F8B4", VA = "0x103F8B4")]
		private void DestroyDepthCamera()
		{
		}

		[Token(Token = "0x60000EB")]
		[Address(RVA = "0x103FA64", Offset = "0x103FA64", VA = "0x103FA64", Slot = "7")]
		protected override void OnModifyMaterialCallback(MaterialModifier.Interface owner)
		{
		}

		[Token(Token = "0x60000EC")]
		[Address(RVA = "0x103FC0C", Offset = "0x103FC0C", VA = "0x103FC0C")]
		public DynamicOcclusionDepthBuffer()
		{
		}
	}
	[Token(Token = "0x2000012")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x8F1E48", Offset = "0x8F1E48")]
	public class DynamicOcclusionRaycasting : DynamicOcclusionAbstractBase
	{
		[Token(Token = "0x2000138")]
		public class HitResult
		{
			[Token(Token = "0x40006D5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Vector3 point;

			[Token(Token = "0x40006D6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public Vector3 normal;

			[Token(Token = "0x40006D7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public float distance;

			[Token(Token = "0x40006D8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private Collider2D collider2D;

			[Token(Token = "0x40006D9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private Collider collider3D;

			[Token(Token = "0x1700005A")]
			public bool hasCollider
			{
				[Token(Token = "0x6000849")]
				[Address(RVA = "0x1040E00", Offset = "0x1040E00", VA = "0x1040E00")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x1700005B")]
			public string name
			{
				[Token(Token = "0x600084A")]
				[Address(RVA = "0x10417E0", Offset = "0x10417E0", VA = "0x10417E0")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700005C")]
			public Bounds bounds
			{
				[Token(Token = "0x600084B")]
				[Address(RVA = "0x10418C8", Offset = "0x10418C8", VA = "0x10418C8")]
				get
				{
					return default(Bounds);
				}
			}

			[Token(Token = "0x6000846")]
			[Address(RVA = "0x10408B4", Offset = "0x10408B4", VA = "0x10408B4")]
			public HitResult(RaycastHit hit3D)
			{
			}

			[Token(Token = "0x6000847")]
			[Address(RVA = "0x10409B8", Offset = "0x10409B8", VA = "0x10409B8")]
			public HitResult(RaycastHit2D hit2D)
			{
			}

			[Token(Token = "0x6000848")]
			[Address(RVA = "0x1040924", Offset = "0x1040924", VA = "0x1040924")]
			public HitResult()
			{
			}
		}

		[Token(Token = "0x2000139")]
		private enum Direction
		{
			[Token(Token = "0x40006DB")]
			Up,
			[Token(Token = "0x40006DC")]
			Right,
			[Token(Token = "0x40006DD")]
			Down,
			[Token(Token = "0x40006DE")]
			Left
		}

		[Token(Token = "0x40000AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public OccluderDimensions dimensions;

		[Token(Token = "0x40000AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public LayerMask layerMask;

		[Token(Token = "0x40000AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public bool considerTriggers;

		[Token(Token = "0x40000B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float minOccluderArea;

		[Token(Token = "0x40000B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float minSurfaceRatio;

		[Token(Token = "0x40000B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public float maxSurfaceDot;

		[Token(Token = "0x40000B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public PlaneAlignment planeAlignment;

		[Token(Token = "0x40000B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public float planeOffset;

		[Token(Token = "0x40000B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x8F26AC", Offset = "0x8F26AC")]
		public float fadeDistanceToSurface;

		[Token(Token = "0x40000B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F26E4", Offset = "0x8F26E4")]
		private HitResult <currentHit>k__BackingField;

		[Token(Token = "0x40000B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private float m_RangeMultiplier;

		[Token(Token = "0x40000B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F26F4", Offset = "0x8F26F4")]
		private Plane <planeEquationWS>k__BackingField;

		[Token(Token = "0x40000B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private uint m_PrevNonSubHitDirectionId;

		[Token(Token = "0x17000019")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x8F44F8", Offset = "0x8F44F8")]
		public float fadeDistanceToPlane
		{
			[Token(Token = "0x60000ED")]
			[Address(RVA = "0x103FCCC", Offset = "0x103FCCC", VA = "0x103FCCC")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60000EE")]
			[Address(RVA = "0x103FCD4", Offset = "0x103FCD4", VA = "0x103FCD4")]
			set
			{
			}
		}

		[Token(Token = "0x1700001A")]
		public HitResult currentHit
		{
			[Token(Token = "0x60000F0")]
			[Address(RVA = "0x103FE2C", Offset = "0x103FE2C", VA = "0x103FE2C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F4064", Offset = "0x8F4064")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000F1")]
			[Address(RVA = "0x103FE34", Offset = "0x103FE34", VA = "0x103FE34")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F4074", Offset = "0x8F4074")]
			private set
			{
			}
		}

		[Token(Token = "0x1700001B")]
		private Plane planeEquationWS
		{
			[Token(Token = "0x60000F4")]
			[Address(RVA = "0x103FE20", Offset = "0x103FE20", VA = "0x103FE20")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F4084", Offset = "0x8F4084")]
			get
			{
				return default(Plane);
			}
			[Token(Token = "0x60000F5")]
			[Address(RVA = "0x103FE8C", Offset = "0x103FE8C", VA = "0x103FE8C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F4094", Offset = "0x8F4094")]
			set
			{
			}
		}

		[Token(Token = "0x1700001C")]
		private QueryTriggerInteraction queryTriggerInteraction
		{
			[Token(Token = "0x60000FB")]
			[Address(RVA = "0x1040268", Offset = "0x1040268", VA = "0x1040268")]
			get
			{
				return default(QueryTriggerInteraction);
			}
		}

		[Token(Token = "0x1700001D")]
		private float raycastMaxDistance
		{
			[Token(Token = "0x60000FC")]
			[Address(RVA = "0x104027C", Offset = "0x104027C", VA = "0x104027C")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x60000EF")]
		[Address(RVA = "0x103FCDC", Offset = "0x103FCDC", VA = "0x103FCDC")]
		public bool IsColliderHiddenByDynamicOccluder(Collider collider)
		{
			return default(bool);
		}

		[Token(Token = "0x60000F2")]
		[Address(RVA = "0x103FE3C", Offset = "0x103FE3C", VA = "0x103FE3C", Slot = "4")]
		protected override string GetShaderKeyword()
		{
			return null;
		}

		[Token(Token = "0x60000F3")]
		[Address(RVA = "0x103FE84", Offset = "0x103FE84", VA = "0x103FE84", Slot = "5")]
		protected override MaterialManager.DynamicOcclusion GetDynamicOcclusionMode()
		{
			return default(MaterialManager.DynamicOcclusion);
		}

		[Token(Token = "0x60000F6")]
		[Address(RVA = "0x103FE98", Offset = "0x103FE98", VA = "0x103FE98", Slot = "9")]
		protected override void OnValidateProperties()
		{
		}

		[Token(Token = "0x60000F7")]
		[Address(RVA = "0x103FF38", Offset = "0x103FF38", VA = "0x103FF38", Slot = "8")]
		protected override void OnEnablePostValidate()
		{
		}

		[Token(Token = "0x60000F8")]
		[Address(RVA = "0x103FF40", Offset = "0x103FF40", VA = "0x103FF40", Slot = "13")]
		protected override void OnDisable()
		{
		}

		[Token(Token = "0x60000F9")]
		[Address(RVA = "0x1040088", Offset = "0x1040088", VA = "0x1040088")]
		private void Start()
		{
		}

		[Token(Token = "0x60000FA")]
		[Address(RVA = "0x104016C", Offset = "0x104016C", VA = "0x104016C")]
		private Vector3 GetRandomVectorAround(Vector3 direction, float angleDiff)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000FD")]
		[Address(RVA = "0x10402E4", Offset = "0x10402E4", VA = "0x10402E4")]
		private HitResult GetBestHit(Vector3 rayPos, Vector3 rayDir)
		{
			return null;
		}

		[Token(Token = "0x60000FE")]
		[Address(RVA = "0x10402F8", Offset = "0x10402F8", VA = "0x10402F8")]
		private HitResult GetBestHit3D(Vector3 rayPos, Vector3 rayDir)
		{
			return null;
		}

		[Token(Token = "0x60000FF")]
		[Address(RVA = "0x10405A0", Offset = "0x10405A0", VA = "0x10405A0")]
		private HitResult GetBestHit2D(Vector3 rayPos, Vector3 rayDir)
		{
			return null;
		}

		[Token(Token = "0x6000100")]
		[Address(RVA = "0x1040AA0", Offset = "0x1040AA0", VA = "0x1040AA0")]
		private Vector3 GetDirection(uint dirInt)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000101")]
		[Address(RVA = "0x1040CD8", Offset = "0x1040CD8", VA = "0x1040CD8")]
		private bool IsHitValid(HitResult hit)
		{
			return default(bool);
		}

		[Token(Token = "0x6000102")]
		[Address(RVA = "0x1040EB4", Offset = "0x1040EB4", VA = "0x1040EB4", Slot = "6")]
		protected override bool OnProcessOcclusion(ProcessOcclusionSource source)
		{
			return default(bool);
		}

		[Token(Token = "0x6000103")]
		[Address(RVA = "0x103FF68", Offset = "0x103FF68", VA = "0x103FF68")]
		private void SetHit(HitResult hit)
		{
		}

		[Token(Token = "0x6000104")]
		[Address(RVA = "0x10414F0", Offset = "0x10414F0", VA = "0x10414F0", Slot = "7")]
		protected override void OnModifyMaterialCallback(MaterialModifier.Interface owner)
		{
		}

		[Token(Token = "0x6000105")]
		[Address(RVA = "0x1041350", Offset = "0x1041350", VA = "0x1041350")]
		private void SetClippingPlane(Plane planeWS)
		{
		}

		[Token(Token = "0x6000106")]
		[Address(RVA = "0x1041300", Offset = "0x1041300", VA = "0x1041300")]
		private void SetClippingPlaneOff()
		{
		}

		[Token(Token = "0x6000107")]
		[Address(RVA = "0x1041704", Offset = "0x1041704", VA = "0x1041704")]
		private void SetPlaneWS(Plane planeWS)
		{
		}

		[Token(Token = "0x6000108")]
		[Address(RVA = "0x1041710", Offset = "0x1041710", VA = "0x1041710")]
		public DynamicOcclusionRaycasting()
		{
		}
	}
	[Token(Token = "0x2000013")]
	public enum ColorMode
	{
		[Token(Token = "0x40000BB")]
		Flat,
		[Token(Token = "0x40000BC")]
		Gradient
	}
	[Token(Token = "0x2000014")]
	public enum AttenuationEquation
	{
		[Token(Token = "0x40000BE")]
		Linear,
		[Token(Token = "0x40000BF")]
		Quadratic,
		[Token(Token = "0x40000C0")]
		Blend
	}
	[Token(Token = "0x2000015")]
	public enum BlendingMode
	{
		[Token(Token = "0x40000C2")]
		Additive,
		[Token(Token = "0x40000C3")]
		SoftAdditive,
		[Token(Token = "0x40000C4")]
		TraditionalTransparency
	}
	[Token(Token = "0x2000016")]
	public enum NoiseMode
	{
		[Token(Token = "0x40000C6")]
		Disabled,
		[Token(Token = "0x40000C7")]
		WorldSpace,
		[Token(Token = "0x40000C8")]
		LocalSpace
	}
	[Token(Token = "0x2000017")]
	public enum MeshType
	{
		[Token(Token = "0x40000CA")]
		Shared,
		[Token(Token = "0x40000CB")]
		Custom
	}
	[Token(Token = "0x2000018")]
	public enum RenderPipeline
	{
		[Token(Token = "0x40000CD")]
		BuiltIn,
		[Token(Token = "0x40000CE")]
		SRP_4_0_0_or_higher
	}
	[Token(Token = "0x2000019")]
	public enum RenderingMode
	{
		[Token(Token = "0x40000D0")]
		MultiPass,
		[Token(Token = "0x40000D1")]
		SinglePass,
		[Token(Token = "0x40000D2")]
		GPUInstancing
	}
	[Token(Token = "0x200001A")]
	public enum RenderQueue
	{
		[Token(Token = "0x40000D4")]
		Custom = 0,
		[Token(Token = "0x40000D5")]
		Background = 1000,
		[Token(Token = "0x40000D6")]
		Geometry = 2000,
		[Token(Token = "0x40000D7")]
		AlphaTest = 2450,
		[Token(Token = "0x40000D8")]
		GeometryLast = 2500,
		[Token(Token = "0x40000D9")]
		Transparent = 3000,
		[Token(Token = "0x40000DA")]
		Overlay = 4000
	}
	[Token(Token = "0x200001B")]
	public enum OccluderDimensions
	{
		[Token(Token = "0x40000DC")]
		Occluders3D,
		[Token(Token = "0x40000DD")]
		Occluders2D
	}
	[Token(Token = "0x200001C")]
	public enum PlaneAlignment
	{
		[Token(Token = "0x40000DF")]
		Surface,
		[Token(Token = "0x40000E0")]
		Beam
	}
	[Token(Token = "0x200001D")]
	[Flags]
	public enum DynamicOcclusionUpdateRate
	{
		[Token(Token = "0x40000E2")]
		Never = 1,
		[Token(Token = "0x40000E3")]
		OnEnable = 2,
		[Token(Token = "0x40000E4")]
		OnBeamMove = 4,
		[Token(Token = "0x40000E5")]
		EveryXFrames = 8,
		[Token(Token = "0x40000E6")]
		OnBeamMoveAndEveryXFrames = 0xC
	}
	[Token(Token = "0x200001E")]
	public static class GlobalMesh
	{
		[Token(Token = "0x40000E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static Mesh ms_Mesh;

		[Token(Token = "0x40000E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static bool ms_DoubleSided;

		[Token(Token = "0x6000109")]
		[Address(RVA = "0x103BC5C", Offset = "0x103BC5C", VA = "0x103BC5C")]
		public static Mesh Get()
		{
			return null;
		}

		[Token(Token = "0x600010A")]
		[Address(RVA = "0x10419D4", Offset = "0x10419D4", VA = "0x10419D4")]
		public static void Destroy()
		{
		}
	}
	[Token(Token = "0x200001F")]
	public static class GpuInstancing
	{
		[Token(Token = "0x40000E9")]
		public const bool isSupported = true;

		[Token(Token = "0x1700001E")]
		public static bool forceEnableDepthBlend
		{
			[Token(Token = "0x600010C")]
			[Address(RVA = "0x103C834", Offset = "0x103C834", VA = "0x103C834")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600010D")]
		[Address(RVA = "0x1041AD8", Offset = "0x1041AD8", VA = "0x1041AD8")]
		public static void SetMaterialProperties(Material material, bool enableInstancing)
		{
		}

		[Token(Token = "0x600010E")]
		[Address(RVA = "0x1041B7C", Offset = "0x1041B7C", VA = "0x1041B7C")]
		public static bool CanBeBatched(VolumetricLightBeam beamA, VolumetricLightBeam beamB, ref string reasons)
		{
			return default(bool);
		}

		[Token(Token = "0x600010F")]
		[Address(RVA = "0x1041DD4", Offset = "0x1041DD4", VA = "0x1041DD4")]
		public static bool CanBeBatched(VolumetricLightBeam beam, ref string reasons)
		{
			return default(bool);
		}

		[Token(Token = "0x6000110")]
		[Address(RVA = "0x1041EFC", Offset = "0x1041EFC", VA = "0x1041EFC")]
		private static void AppendErrorMessage(ref string message, string toAppend)
		{
		}
	}
	[Token(Token = "0x2000020")]
	public sealed class HighlightNullAttribute : PropertyAttribute
	{
		[Token(Token = "0x6000111")]
		[Address(RVA = "0x1041FA8", Offset = "0x1041FA8", VA = "0x1041FA8")]
		public HighlightNullAttribute()
		{
		}
	}
	[Token(Token = "0x2000021")]
	public class MaterialKeywordSRP
	{
		[Token(Token = "0x40000EA")]
		public const string kKeyword = "VLB_SRP_API";

		[Token(Token = "0x6000112")]
		[Address(RVA = "0x1041FB0", Offset = "0x1041FB0", VA = "0x1041FB0")]
		public MaterialKeywordSRP()
		{
		}
	}
	[Token(Token = "0x2000022")]
	public static class MaterialManager
	{
		[Token(Token = "0x200013A")]
		public enum BlendingMode
		{
			[Token(Token = "0x40006E0")]
			Additive,
			[Token(Token = "0x40006E1")]
			SoftAdditive,
			[Token(Token = "0x40006E2")]
			TraditionalTransparency,
			[Token(Token = "0x40006E3")]
			Count
		}

		[Token(Token = "0x200013B")]
		public enum Noise3D
		{
			[Token(Token = "0x40006E5")]
			Off,
			[Token(Token = "0x40006E6")]
			On,
			[Token(Token = "0x40006E7")]
			Count
		}

		[Token(Token = "0x200013C")]
		public enum DepthBlend
		{
			[Token(Token = "0x40006E9")]
			Off,
			[Token(Token = "0x40006EA")]
			On,
			[Token(Token = "0x40006EB")]
			Count
		}

		[Token(Token = "0x200013D")]
		public enum ColorGradient
		{
			[Token(Token = "0x40006ED")]
			Off,
			[Token(Token = "0x40006EE")]
			MatrixLow,
			[Token(Token = "0x40006EF")]
			MatrixHigh,
			[Token(Token = "0x40006F0")]
			Count
		}

		[Token(Token = "0x200013E")]
		public enum DynamicOcclusion
		{
			[Token(Token = "0x40006F2")]
			Off,
			[Token(Token = "0x40006F3")]
			ClippingPlane,
			[Token(Token = "0x40006F4")]
			DepthTexture,
			[Token(Token = "0x40006F5")]
			Count
		}

		[Token(Token = "0x200013F")]
		public class StaticProperties
		{
			[Token(Token = "0x40006F6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public BlendingMode blendingMode;

			[Token(Token = "0x40006F7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public Noise3D noise3D;

			[Token(Token = "0x40006F8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public DepthBlend depthBlend;

			[Token(Token = "0x40006F9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public ColorGradient colorGradient;

			[Token(Token = "0x40006FA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public DynamicOcclusion dynamicOcclusion;

			[Token(Token = "0x1700005D")]
			public int materialID
			{
				[Token(Token = "0x600084C")]
				[Address(RVA = "0x1042040", Offset = "0x1042040", VA = "0x1042040")]
				get
				{
					return default(int);
				}
			}

			[Token(Token = "0x600084D")]
			[Address(RVA = "0x103C8B4", Offset = "0x103C8B4", VA = "0x103C8B4")]
			public void ApplyToMaterial(Material mat)
			{
			}

			[Token(Token = "0x600084E")]
			[Address(RVA = "0x103C8AC", Offset = "0x103C8AC", VA = "0x103C8AC")]
			public StaticProperties()
			{
			}
		}

		[Token(Token = "0x2000140")]
		private class MaterialsGroup
		{
			[Token(Token = "0x40006FB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Material[] materials;

			[Token(Token = "0x600084F")]
			[Address(RVA = "0x1041FB8", Offset = "0x1041FB8", VA = "0x1041FB8")]
			public MaterialsGroup()
			{
			}
		}

		[Token(Token = "0x40000EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static MaterialPropertyBlock materialPropertyBlock;

		[Token(Token = "0x40000EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static readonly BlendMode[] BlendingMode_SrcFactor;

		[Token(Token = "0x40000ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static readonly BlendMode[] BlendingMode_DstFactor;

		[Token(Token = "0x40000EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static readonly bool[] BlendingMode_AlphaAsBlack;

		[Token(Token = "0x40000EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static int kStaticPropertiesCount;

		[Token(Token = "0x40000F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static Hashtable ms_MaterialsGroup;

		[Token(Token = "0x6000113")]
		[Address(RVA = "0x103A6FC", Offset = "0x103A6FC", VA = "0x103A6FC")]
		public static Material NewMaterial(bool gpuInstanced)
		{
			return null;
		}

		[Token(Token = "0x6000114")]
		[Address(RVA = "0x103CB7C", Offset = "0x103CB7C", VA = "0x103CB7C")]
		public static Material GetInstancedMaterial(uint groupID, StaticProperties staticProps)
		{
			return null;
		}
	}
	[Token(Token = "0x2000023")]
	public static class MeshGenerator
	{
		[Token(Token = "0x40000F1")]
		private const float kMinTruncatedRadius = 0.001f;

		[Token(Token = "0x6000116")]
		[Address(RVA = "0x10421E8", Offset = "0x10421E8", VA = "0x10421E8")]
		private static float GetAngleOffset(int numSides)
		{
			return default(float);
		}

		[Token(Token = "0x6000117")]
		[Address(RVA = "0x1042200", Offset = "0x1042200", VA = "0x1042200")]
		public static Mesh GenerateConeZ_RadiusAndAngle(float lengthZ, float radiusStart, float coneAngle, int numSides, int numSegments, bool cap, bool doubleSided)
		{
			return null;
		}

		[Token(Token = "0x6000118")]
		[Address(RVA = "0x10422CC", Offset = "0x10422CC", VA = "0x10422CC")]
		public static Mesh GenerateConeZ_Angle(float lengthZ, float coneAngle, int numSides, int numSegments, bool cap, bool doubleSided)
		{
			return null;
		}

		[Token(Token = "0x6000119")]
		[Address(RVA = "0x103AEBC", Offset = "0x103AEBC", VA = "0x103AEBC")]
		public static Mesh GenerateConeZ_Radius(float lengthZ, float radiusStart, float radiusEnd, int numSides, int numSegments, bool cap, bool doubleSided)
		{
			return null;
		}

		[Token(Token = "0x600011A")]
		[Address(RVA = "0x10422E0", Offset = "0x10422E0", VA = "0x10422E0")]
		public static int GetVertexCount(int numSides, int numSegments, bool geomCap, bool doubleSided)
		{
			return default(int);
		}

		[Token(Token = "0x600011B")]
		[Address(RVA = "0x10422FC", Offset = "0x10422FC", VA = "0x10422FC")]
		public static int GetIndicesCount(int numSides, int numSegments, bool geomCap, bool doubleSided)
		{
			return default(int);
		}

		[Token(Token = "0x600011C")]
		[Address(RVA = "0x1042324", Offset = "0x1042324", VA = "0x1042324")]
		public static int GetSharedMeshVertexCount()
		{
			return default(int);
		}

		[Token(Token = "0x600011D")]
		[Address(RVA = "0x10423DC", Offset = "0x10423DC", VA = "0x10423DC")]
		public static int GetSharedMeshIndicesCount()
		{
			return default(int);
		}
	}
	[Token(Token = "0x2000024")]
	public static class Noise3D
	{
		[Token(Token = "0x40000F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static bool ms_IsSupportedChecked;

		[Token(Token = "0x40000F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1")]
		private static bool ms_IsSupported;

		[Token(Token = "0x40000F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static Texture3D ms_NoiseTexture;

		[Token(Token = "0x40000F5")]
		private const HideFlags kHideFlags = HideFlags.HideAndDontSave;

		[Token(Token = "0x40000F6")]
		private const int kMinShaderLevel = 35;

		[Token(Token = "0x1700001F")]
		public static bool isSupported
		{
			[Token(Token = "0x600011E")]
			[Address(RVA = "0x1D12F34", Offset = "0x1D12F34", VA = "0x1D12F34")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000020")]
		public static bool isProperlyLoaded
		{
			[Token(Token = "0x600011F")]
			[Address(RVA = "0x1D13124", Offset = "0x1D13124", VA = "0x1D13124")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000021")]
		public static string isNotSupportedString
		{
			[Token(Token = "0x6000120")]
			[Address(RVA = "0x1D13084", Offset = "0x1D13084", VA = "0x1D13084")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000121")]
		[Address(RVA = "0x1D131BC", Offset = "0x1D131BC", VA = "0x1D131BC")]
		[AttributeAttribute(Name = "RuntimeInitializeOnLoadMethodAttribute", RVA = "0x8F40A4", Offset = "0x8F40A4")]
		private static void OnStartUp()
		{
		}

		[Token(Token = "0x6000122")]
		[Address(RVA = "0x1D13218", Offset = "0x1D13218", VA = "0x1D13218")]
		public static void LoadIfNeeded()
		{
		}

		[Token(Token = "0x6000123")]
		[Address(RVA = "0x1D13468", Offset = "0x1D13468", VA = "0x1D13468")]
		private static Texture3D LoadTexture3D(TextAsset textData, int size)
		{
			return null;
		}
	}
	[Token(Token = "0x2000025")]
	public static class ShaderProperties
	{
		[Token(Token = "0x40000F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly int FadeOutFactor;

		[Token(Token = "0x40000F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public static readonly int ClippingPlaneWS;

		[Token(Token = "0x40000F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static readonly int ClippingPlaneProps;

		[Token(Token = "0x40000FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public static readonly int ConeSlopeCosSin;

		[Token(Token = "0x40000FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static readonly int ConeRadius;

		[Token(Token = "0x40000FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public static readonly int ConeApexOffsetZ;

		[Token(Token = "0x40000FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public static readonly int ColorFlat;

		[Token(Token = "0x40000FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public static readonly int AlphaInside;

		[Token(Token = "0x40000FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public static readonly int AlphaOutside;

		[Token(Token = "0x4000100")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public static readonly int AttenuationLerpLinearQuad;

		[Token(Token = "0x4000101")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public static readonly int DistanceFadeStart;

		[Token(Token = "0x4000102")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public static readonly int DistanceFadeEnd;

		[Token(Token = "0x4000103")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public static readonly int DistanceCamClipping;

		[Token(Token = "0x4000104")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public static readonly int FresnelPow;

		[Token(Token = "0x4000105")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public static readonly int GlareBehind;

		[Token(Token = "0x4000106")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public static readonly int GlareFrontal;

		[Token(Token = "0x4000107")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public static readonly int DrawCap;

		[Token(Token = "0x4000108")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public static readonly int DepthBlendDistance;

		[Token(Token = "0x4000109")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public static readonly int NoiseLocal;

		[Token(Token = "0x400010A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public static readonly int NoiseParam;

		[Token(Token = "0x400010B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public static readonly int CameraParams;

		[Token(Token = "0x400010C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public static readonly int CameraBufferSizeSRP;

		[Token(Token = "0x400010D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public static readonly int ColorGradientMatrix;

		[Token(Token = "0x400010E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public static readonly int LocalToWorldMatrix;

		[Token(Token = "0x400010F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public static readonly int WorldToLocalMatrix;

		[Token(Token = "0x4000110")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public static readonly int BlendSrcFactor;

		[Token(Token = "0x4000111")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public static readonly int BlendDstFactor;

		[Token(Token = "0x4000112")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public static readonly int DynamicOcclusionDepthTexture;

		[Token(Token = "0x4000113")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public static readonly int DynamicOcclusionDepthProps;
	}
	[Token(Token = "0x2000026")]
	public static class TransformUtils
	{
		[Token(Token = "0x2000141")]
		public class Packed
		{
			[Token(Token = "0x40006FC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Vector3 position;

			[Token(Token = "0x40006FD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public Quaternion rotation;

			[Token(Token = "0x40006FE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public Vector3 lossyScale;

			[Token(Token = "0x6000850")]
			[Address(RVA = "0x1D13C90", Offset = "0x1D13C90", VA = "0x1D13C90")]
			public Packed()
			{
			}
		}

		[Token(Token = "0x6000126")]
		[Address(RVA = "0x1D13BA8", Offset = "0x1D13BA8", VA = "0x1D13BA8")]
		public static Packed GetWorldPacked(this Transform self)
		{
			return null;
		}

		[Token(Token = "0x6000127")]
		[Address(RVA = "0x1D13C98", Offset = "0x1D13C98", VA = "0x1D13C98")]
		public static bool IsSame(this Transform self, Packed packed)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x2000027")]
	[DisallowMultipleComponent]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x8F1EB4", Offset = "0x8F1EB4")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x8F1EB4", Offset = "0x8F1EB4")]
	public class TriggerZone : MonoBehaviour
	{
		[Token(Token = "0x4000114")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool setIsTrigger;

		[Token(Token = "0x4000115")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float rangeMultiplier;

		[Token(Token = "0x4000116")]
		private const int kMeshColliderNumSides = 8;

		[Token(Token = "0x4000117")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Mesh m_Mesh;

		[Token(Token = "0x6000128")]
		[Address(RVA = "0x1D13E78", Offset = "0x1D13E78", VA = "0x1D13E78")]
		private void Update()
		{
		}

		[Token(Token = "0x6000129")]
		[Address(RVA = "0x1D141B0", Offset = "0x1D141B0", VA = "0x1D141B0")]
		public TriggerZone()
		{
		}
	}
	[Token(Token = "0x2000028")]
	public static class Utils
	{
		[Token(Token = "0x2000142")]
		public enum FloatPackingPrecision
		{
			[Token(Token = "0x4000700")]
			High = 64,
			[Token(Token = "0x4000701")]
			Low = 8,
			[Token(Token = "0x4000702")]
			Undef = 0
		}

		[Token(Token = "0x4000118")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static FloatPackingPrecision ms_FloatPackingPrecision;

		[Token(Token = "0x4000119")]
		private const int kFloatPackingHighMinShaderLevel = 35;

		[Token(Token = "0x600012A")]
		[Address(RVA = "0x1D141C8", Offset = "0x1D141C8", VA = "0x1D141C8")]
		public static float ComputeConeRadiusEnd(float fallOffEnd, float spotAngle)
		{
			return default(float);
		}

		[Token(Token = "0x600012B")]
		public static void Swap<T>(ref T a, ref T b)
		{
		}

		[Token(Token = "0x600012C")]
		[Address(RVA = "0x1D14250", Offset = "0x1D14250", VA = "0x1D14250")]
		public static string GetPath(Transform current)
		{
			return null;
		}

		[Token(Token = "0x600012D")]
		public static T NewWithComponent<T>(string name) where T : Component
		{
			return null;
		}

		[Token(Token = "0x600012E")]
		public static T GetOrAddComponent<T>(this GameObject self) where T : Component
		{
			return null;
		}

		[Token(Token = "0x600012F")]
		public static T GetOrAddComponent<T>(this MonoBehaviour self) where T : Component
		{
			return null;
		}

		[Token(Token = "0x6000130")]
		[Address(RVA = "0x1D14398", Offset = "0x1D14398", VA = "0x1D14398")]
		public static bool HasFlag(this Enum mask, Enum flags)
		{
			return default(bool);
		}

		[Token(Token = "0x6000131")]
		[Address(RVA = "0x1D14428", Offset = "0x1D14428", VA = "0x1D14428")]
		public static Vector2 xy(this Vector3 aVector)
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000132")]
		[Address(RVA = "0x1D14454", Offset = "0x1D14454", VA = "0x1D14454")]
		public static Vector2 xz(this Vector3 aVector)
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000133")]
		[Address(RVA = "0x1D14484", Offset = "0x1D14484", VA = "0x1D14484")]
		public static Vector2 yz(this Vector3 aVector)
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000134")]
		[Address(RVA = "0x1D144B8", Offset = "0x1D144B8", VA = "0x1D144B8")]
		public static Vector2 yx(this Vector3 aVector)
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000135")]
		[Address(RVA = "0x1D144F0", Offset = "0x1D144F0", VA = "0x1D144F0")]
		public static Vector2 zx(this Vector3 aVector)
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000136")]
		[Address(RVA = "0x1D14524", Offset = "0x1D14524", VA = "0x1D14524")]
		public static Vector2 zy(this Vector3 aVector)
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000137")]
		[Address(RVA = "0x1D14554", Offset = "0x1D14554", VA = "0x1D14554")]
		public static float GetVolumeCubic(this Bounds self)
		{
			return default(float);
		}

		[Token(Token = "0x6000138")]
		[Address(RVA = "0x1D145A8", Offset = "0x1D145A8", VA = "0x1D145A8")]
		public static float GetMaxArea2D(this Bounds self)
		{
			return default(float);
		}

		[Token(Token = "0x6000139")]
		[Address(RVA = "0x1D14694", Offset = "0x1D14694", VA = "0x1D14694")]
		public static Color Opaque(this Color self)
		{
			return default(Color);
		}

		[Token(Token = "0x600013A")]
		[Address(RVA = "0x1D146C8", Offset = "0x1D146C8", VA = "0x1D146C8")]
		public static void GizmosDrawPlane(Vector3 normal, Vector3 position, Color color, float size = 1f)
		{
		}

		[Token(Token = "0x600013B")]
		[Address(RVA = "0x1D14AD0", Offset = "0x1D14AD0", VA = "0x1D14AD0")]
		public static Plane TranslateCustom(this Plane plane, Vector3 translation)
		{
			return default(Plane);
		}

		[Token(Token = "0x600013C")]
		[Address(RVA = "0x1D14BF0", Offset = "0x1D14BF0", VA = "0x1D14BF0")]
		public static bool IsValid(this Plane plane)
		{
			return default(bool);
		}

		[Token(Token = "0x600013D")]
		[Address(RVA = "0x1D14C3C", Offset = "0x1D14C3C", VA = "0x1D14C3C")]
		public static void SetKeywordEnabled(this Material mat, string name, bool enabled)
		{
		}

		[Token(Token = "0x600013E")]
		[Address(RVA = "0x1D14CA0", Offset = "0x1D14CA0", VA = "0x1D14CA0")]
		public static void SetShaderKeywordEnabled(string name, bool enabled)
		{
		}

		[Token(Token = "0x600013F")]
		[Address(RVA = "0x1D14CB4", Offset = "0x1D14CB4", VA = "0x1D14CB4")]
		public static Matrix4x4 SampleInMatrix(this Gradient self, int floatPackingPrecision)
		{
			return default(Matrix4x4);
		}

		[Token(Token = "0x6000140")]
		[Address(RVA = "0x1D14F00", Offset = "0x1D14F00", VA = "0x1D14F00")]
		public static Color[] SampleInArray(this Gradient self, int samplesCount)
		{
			return null;
		}

		[Token(Token = "0x6000141")]
		[Address(RVA = "0x1D15040", Offset = "0x1D15040", VA = "0x1D15040")]
		private static Vector4 Vector4_Floor(Vector4 vec)
		{
			return default(Vector4);
		}

		[Token(Token = "0x6000142")]
		[Address(RVA = "0x1D14E04", Offset = "0x1D14E04", VA = "0x1D14E04")]
		public static float PackToFloat(this Color color, int floatPackingPrecision)
		{
			return default(float);
		}

		[Token(Token = "0x6000143")]
		[Address(RVA = "0x1D150EC", Offset = "0x1D150EC", VA = "0x1D150EC")]
		public static FloatPackingPrecision GetFloatPackingPrecision()
		{
			return default(FloatPackingPrecision);
		}

		[Token(Token = "0x6000144")]
		[Address(RVA = "0x1D151BC", Offset = "0x1D151BC", VA = "0x1D151BC")]
		public static void MarkCurrentSceneDirty()
		{
		}

		[Token(Token = "0x6000145")]
		[Address(RVA = "0x1D151C0", Offset = "0x1D151C0", VA = "0x1D151C0")]
		public static void MarkObjectDirty(UnityEngine.Object obj)
		{
		}
	}
	[Token(Token = "0x2000029")]
	public static class Version
	{
		[Token(Token = "0x400011A")]
		public const int Current = 1800;
	}
	[Token(Token = "0x200002A")]
	[ExecuteInEditMode]
	[DisallowMultipleComponent]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x8F1F5C", Offset = "0x8F1F5C")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x8F1F5C", Offset = "0x8F1F5C")]
	public class VolumetricDustParticles : MonoBehaviour
	{
		[Token(Token = "0x2000143")]
		public enum Direction
		{
			[Token(Token = "0x4000704")]
			Beam,
			[Token(Token = "0x4000705")]
			Random
		}

		[Token(Token = "0x400011B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8F2704", Offset = "0x8F2704")]
		public float alpha;

		[Token(Token = "0x400011C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8F271C", Offset = "0x8F271C")]
		public float size;

		[Token(Token = "0x400011D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Direction direction;

		[Token(Token = "0x400011E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float speed;

		[Token(Token = "0x400011F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float density;

		[Token(Token = "0x4000120")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8F273C", Offset = "0x8F273C")]
		public float spawnMinDistance;

		[Token(Token = "0x4000121")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8F2754", Offset = "0x8F2754")]
		public float spawnMaxDistance;

		[Token(Token = "0x4000122")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public bool cullingEnabled;

		[Token(Token = "0x4000123")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float cullingMaxDistance;

		[Token(Token = "0x4000124")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F276C", Offset = "0x8F276C")]
		private bool <isCulled>k__BackingField;

		[Token(Token = "0x4000125")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static bool isFeatureSupported;

		[Token(Token = "0x4000126")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private ParticleSystem m_Particles;

		[Token(Token = "0x4000127")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private ParticleSystemRenderer m_Renderer;

		[Token(Token = "0x4000128")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1")]
		private static bool ms_NoMainCameraLogged;

		[Token(Token = "0x4000129")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static Camera ms_MainCamera;

		[Token(Token = "0x400012A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private VolumetricLightBeam m_Master;

		[Token(Token = "0x17000022")]
		public bool isCulled
		{
			[Token(Token = "0x6000147")]
			[Address(RVA = "0x1D151C8", Offset = "0x1D151C8", VA = "0x1D151C8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F41F4", Offset = "0x8F41F4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000148")]
			[Address(RVA = "0x1D151D0", Offset = "0x1D151D0", VA = "0x1D151D0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F4204", Offset = "0x8F4204")]
			private set
			{
			}
		}

		[Token(Token = "0x17000023")]
		public bool particlesAreInstantiated
		{
			[Token(Token = "0x6000149")]
			[Address(RVA = "0x1D151DC", Offset = "0x1D151DC", VA = "0x1D151DC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000024")]
		public int particlesCurrentCount
		{
			[Token(Token = "0x600014A")]
			[Address(RVA = "0x1D15248", Offset = "0x1D15248", VA = "0x1D15248")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000025")]
		public int particlesMaxCount
		{
			[Token(Token = "0x600014B")]
			[Address(RVA = "0x1D152E4", Offset = "0x1D152E4", VA = "0x1D152E4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000026")]
		public Camera mainCamera
		{
			[Token(Token = "0x600014C")]
			[Address(RVA = "0x1D15398", Offset = "0x1D15398", VA = "0x1D15398")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600014D")]
		[Address(RVA = "0x1D15580", Offset = "0x1D15580", VA = "0x1D15580")]
		private void Start()
		{
		}

		[Token(Token = "0x600014E")]
		[Address(RVA = "0x1D155E8", Offset = "0x1D155E8", VA = "0x1D155E8")]
		private void InstantiateParticleSystem()
		{
		}

		[Token(Token = "0x600014F")]
		[Address(RVA = "0x1D158C0", Offset = "0x1D158C0", VA = "0x1D158C0")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000150")]
		[Address(RVA = "0x1D157E4", Offset = "0x1D157E4", VA = "0x1D157E4")]
		private void SetActiveAndPlay()
		{
		}

		[Token(Token = "0x6000151")]
		[Address(RVA = "0x1D16060", Offset = "0x1D16060", VA = "0x1D16060")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000152")]
		[Address(RVA = "0x1D16114", Offset = "0x1D16114", VA = "0x1D16114")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000153")]
		[Address(RVA = "0x1D161DC", Offset = "0x1D161DC", VA = "0x1D161DC")]
		private void Update()
		{
		}

		[Token(Token = "0x6000154")]
		[Address(RVA = "0x1D158C4", Offset = "0x1D158C4", VA = "0x1D158C4")]
		private void SetParticleProperties()
		{
		}

		[Token(Token = "0x6000155")]
		[Address(RVA = "0x1D16210", Offset = "0x1D16210", VA = "0x1D16210")]
		private void UpdateCulling()
		{
		}

		[Token(Token = "0x6000156")]
		[Address(RVA = "0x1D16774", Offset = "0x1D16774", VA = "0x1D16774")]
		public VolumetricDustParticles()
		{
		}
	}
	[Token(Token = "0x200002B")]
	[ExecuteInEditMode]
	[DisallowMultipleComponent]
	[SelectionBase]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x8F2004", Offset = "0x8F2004")]
	public class VolumetricLightBeam : MonoBehaviour
	{
		[Token(Token = "0x2000144")]
		public delegate void OnWillCameraRenderCB(Camera cam);

		[Token(Token = "0x2000145")]
		public delegate void OnBeamGeometryInitialized();

		[Token(Token = "0x2000146")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F23E8", Offset = "0x8F23E8")]
		private sealed class <CoPlaytimeUpdate>d__149 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000706")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000707")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000708")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public VolumetricLightBeam <>4__this;

			[Token(Token = "0x1700005E")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600085C")]
				[Address(RVA = "0x1D19104", Offset = "0x1D19104", VA = "0x1D19104", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700005F")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600085E")]
				[Address(RVA = "0x1D19174", Offset = "0x1D19174", VA = "0x1D19174", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000859")]
			[Address(RVA = "0x1D18B34", Offset = "0x1D18B34", VA = "0x1D18B34")]
			[DebuggerHidden]
			public <CoPlaytimeUpdate>d__149(int <>1__state)
			{
			}

			[Token(Token = "0x600085A")]
			[Address(RVA = "0x1D19078", Offset = "0x1D19078", VA = "0x1D19078", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600085B")]
			[Address(RVA = "0x1D1907C", Offset = "0x1D1907C", VA = "0x1D1907C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600085D")]
			[Address(RVA = "0x1D1910C", Offset = "0x1D1910C", VA = "0x1D1910C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400012B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool colorFromLight;

		[Token(Token = "0x400012C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public ColorMode colorMode;

		[Token(Token = "0x400012D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "ColorUsageAttribute", RVA = "0x8F277C", Offset = "0x8F277C")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x8F277C", Offset = "0x8F277C")]
		public Color color;

		[Token(Token = "0x400012E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Gradient colorGradient;

		[Token(Token = "0x400012F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public bool intensityFromLight;

		[Token(Token = "0x4000130")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x39")]
		public bool intensityModeAdvanced;

		[Token(Token = "0x4000131")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x8F27D0", Offset = "0x8F27D0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8F27D0", Offset = "0x8F27D0")]
		public float intensityInside;

		[Token(Token = "0x4000132")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x8F2824", Offset = "0x8F2824")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x8F2824", Offset = "0x8F2824")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8F2824", Offset = "0x8F2824")]
		public float intensityOutside;

		[Token(Token = "0x4000133")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public BlendingMode blendingMode;

		[Token(Token = "0x4000134")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x8F289C", Offset = "0x8F289C")]
		public bool spotAngleFromLight;

		[Token(Token = "0x4000135")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8F28D4", Offset = "0x8F28D4")]
		public float spotAngle;

		[Token(Token = "0x4000136")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x8F28F4", Offset = "0x8F28F4")]
		public float coneRadiusStart;

		[Token(Token = "0x4000137")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public MeshType geomMeshType;

		[Token(Token = "0x4000138")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x8F292C", Offset = "0x8F292C")]
		public int geomCustomSides;

		[Token(Token = "0x4000139")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public int geomCustomSegments;

		[Token(Token = "0x400013A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public bool geomCap;

		[Token(Token = "0x400013B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x61")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x8F2964", Offset = "0x8F2964")]
		public bool fallOffEndFromLight;

		[Token(Token = "0x400013C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public AttenuationEquation attenuationEquation;

		[Token(Token = "0x400013D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8F299C", Offset = "0x8F299C")]
		public float attenuationCustomBlending;

		[Token(Token = "0x400013E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x8F29B4", Offset = "0x8F29B4")]
		public float fallOffStart;

		[Token(Token = "0x400013F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x8F29EC", Offset = "0x8F29EC")]
		public float fallOffEnd;

		[Token(Token = "0x4000140")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		public float depthBlendDistance;

		[Token(Token = "0x4000141")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public float cameraClippingDistance;

		[Token(Token = "0x4000142")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8F2A24", Offset = "0x8F2A24")]
		public float glareFrontal;

		[Token(Token = "0x4000143")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8F2A3C", Offset = "0x8F2A3C")]
		public float glareBehind;

		[Token(Token = "0x4000144")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x8F2A54", Offset = "0x8F2A54")]
		public float fresnelPow;

		[Token(Token = "0x4000145")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public NoiseMode noiseMode;

		[Token(Token = "0x4000146")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x8F2A8C", Offset = "0x8F2A8C")]
		[SerializeField]
		private bool _DEPRECATED_NoiseEnabled;

		[Token(Token = "0x4000147")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8F2AD8", Offset = "0x8F2AD8")]
		public float noiseIntensity;

		[Token(Token = "0x4000148")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		public bool noiseScaleUseGlobal;

		[Token(Token = "0x4000149")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8F2AF0", Offset = "0x8F2AF0")]
		public float noiseScaleLocal;

		[Token(Token = "0x400014A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		public bool noiseVelocityUseGlobal;

		[Token(Token = "0x400014B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public Vector3 noiseVelocityLocal;

		[Token(Token = "0x400014C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F2B0C", Offset = "0x8F2B0C")]
		private MaterialManager.DynamicOcclusion <_INTERNAL_DynamicOcclusionMode>k__BackingField;

		[Token(Token = "0x400014D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private bool m_IsDynamicOcclusionEnabled;

		[Token(Token = "0x400014F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private OnBeamGeometryInitialized m_OnBeamGeometryInitialized;

		[Token(Token = "0x4000150")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[SerializeField]
		private int pluginVersion;

		[Token(Token = "0x4000151")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x8F2B3C", Offset = "0x8F2B3C")]
		[SerializeField]
		private bool _TrackChangesDuringPlaytime;

		[Token(Token = "0x4000152")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		[SerializeField]
		private int _SortingLayerID;

		[Token(Token = "0x4000153")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		[SerializeField]
		private int _SortingOrder;

		[Token(Token = "0x4000154")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x8F2BA8", Offset = "0x8F2BA8")]
		[SerializeField]
		private float _FadeOutBegin;

		[Token(Token = "0x4000155")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x8F2BF4", Offset = "0x8F2BF4")]
		[SerializeField]
		private float _FadeOutEnd;

		[Token(Token = "0x4000156")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F2C40", Offset = "0x8F2C40")]
		private uint <_INTERNAL_InstancedMaterialGroupID>k__BackingField;

		[Token(Token = "0x4000157")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private BeamGeometry m_BeamGeom;

		[Token(Token = "0x4000158")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private Coroutine m_CoPlaytimeUpdate;

		[Token(Token = "0x4000159")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private Light _CachedLight;

		[Token(Token = "0x17000027")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x8F4530", Offset = "0x8F4530")]
		public float alphaInside
		{
			[Token(Token = "0x6000158")]
			[Address(RVA = "0x1D16828", Offset = "0x1D16828", VA = "0x1D16828")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000159")]
			[Address(RVA = "0x1D16830", Offset = "0x1D16830", VA = "0x1D16830")]
			set
			{
			}
		}

		[Token(Token = "0x17000028")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x8F4568", Offset = "0x8F4568")]
		public float alphaOutside
		{
			[Token(Token = "0x600015A")]
			[Address(RVA = "0x1D16838", Offset = "0x1D16838", VA = "0x1D16838")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600015B")]
			[Address(RVA = "0x1D16840", Offset = "0x1D16840", VA = "0x1D16840")]
			set
			{
			}
		}

		[Token(Token = "0x17000029")]
		public float intensityGlobal
		{
			[Token(Token = "0x600015C")]
			[Address(RVA = "0x1D16848", Offset = "0x1D16848", VA = "0x1D16848")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600015D")]
			[Address(RVA = "0x1D16850", Offset = "0x1D16850", VA = "0x1D16850")]
			set
			{
			}
		}

		[Token(Token = "0x1700002A")]
		public float coneAngle
		{
			[Token(Token = "0x600015E")]
			[Address(RVA = "0x1D164E4", Offset = "0x1D164E4", VA = "0x1D164E4")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700002B")]
		public float coneRadiusEnd
		{
			[Token(Token = "0x600015F")]
			[Address(RVA = "0x1D14138", Offset = "0x1D14138", VA = "0x1D14138")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700002C")]
		public float coneVolume
		{
			[Token(Token = "0x6000160")]
			[Address(RVA = "0x1D16858", Offset = "0x1D16858", VA = "0x1D16858")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700002D")]
		public float coneApexOffsetZ
		{
			[Token(Token = "0x6000161")]
			[Address(RVA = "0x1D168AC", Offset = "0x1D168AC", VA = "0x1D168AC")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700002E")]
		public int geomSides
		{
			[Token(Token = "0x6000162")]
			[Address(RVA = "0x1D16904", Offset = "0x1D16904", VA = "0x1D16904")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000163")]
			[Address(RVA = "0x1D16994", Offset = "0x1D16994", VA = "0x1D16994")]
			set
			{
			}
		}

		[Token(Token = "0x1700002F")]
		public int geomSegments
		{
			[Token(Token = "0x6000164")]
			[Address(RVA = "0x1D16A14", Offset = "0x1D16A14", VA = "0x1D16A14")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000165")]
			[Address(RVA = "0x1D16AA4", Offset = "0x1D16AA4", VA = "0x1D16AA4")]
			set
			{
			}
		}

		[Token(Token = "0x17000030")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x8F45A0", Offset = "0x8F45A0")]
		public bool fadeEndFromLight
		{
			[Token(Token = "0x6000166")]
			[Address(RVA = "0x1D16B24", Offset = "0x1D16B24", VA = "0x1D16B24")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000167")]
			[Address(RVA = "0x1D16B2C", Offset = "0x1D16B2C", VA = "0x1D16B2C")]
			set
			{
			}
		}

		[Token(Token = "0x17000031")]
		public float attenuationLerpLinearQuad
		{
			[Token(Token = "0x6000168")]
			[Address(RVA = "0x1D16B38", Offset = "0x1D16B38", VA = "0x1D16B38")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000032")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x8F45D8", Offset = "0x8F45D8")]
		public float fadeStart
		{
			[Token(Token = "0x6000169")]
			[Address(RVA = "0x1D16B60", Offset = "0x1D16B60", VA = "0x1D16B60")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600016A")]
			[Address(RVA = "0x1D16B68", Offset = "0x1D16B68", VA = "0x1D16B68")]
			set
			{
			}
		}

		[Token(Token = "0x17000033")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x8F4610", Offset = "0x8F4610")]
		public float fadeEnd
		{
			[Token(Token = "0x600016B")]
			[Address(RVA = "0x1D16B70", Offset = "0x1D16B70", VA = "0x1D16B70")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600016C")]
			[Address(RVA = "0x1D16B78", Offset = "0x1D16B78", VA = "0x1D16B78")]
			set
			{
			}
		}

		[Token(Token = "0x17000034")]
		public bool isNoiseEnabled
		{
			[Token(Token = "0x600016D")]
			[Address(RVA = "0x1D16B80", Offset = "0x1D16B80", VA = "0x1D16B80")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000035")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x8F4648", Offset = "0x8F4648")]
		public bool noiseEnabled
		{
			[Token(Token = "0x600016E")]
			[Address(RVA = "0x1D16B90", Offset = "0x1D16B90", VA = "0x1D16B90")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600016F")]
			[Address(RVA = "0x1D16BA0", Offset = "0x1D16BA0", VA = "0x1D16BA0")]
			set
			{
			}
		}

		[Token(Token = "0x17000036")]
		public float fadeOutBegin
		{
			[Token(Token = "0x6000170")]
			[Address(RVA = "0x1D16BCC", Offset = "0x1D16BCC", VA = "0x1D16BCC")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000171")]
			[Address(RVA = "0x1D16BD4", Offset = "0x1D16BD4", VA = "0x1D16BD4")]
			set
			{
			}
		}

		[Token(Token = "0x17000037")]
		public float fadeOutEnd
		{
			[Token(Token = "0x6000172")]
			[Address(RVA = "0x1D16628", Offset = "0x1D16628", VA = "0x1D16628")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000173")]
			[Address(RVA = "0x1D16C30", Offset = "0x1D16C30", VA = "0x1D16C30")]
			set
			{
			}
		}

		[Token(Token = "0x17000038")]
		public bool isFadeOutEnabled
		{
			[Token(Token = "0x6000174")]
			[Address(RVA = "0x1D16594", Offset = "0x1D16594", VA = "0x1D16594")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000039")]
		public int sortingLayerID
		{
			[Token(Token = "0x6000175")]
			[Address(RVA = "0x1D16584", Offset = "0x1D16584", VA = "0x1D16584")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000176")]
			[Address(RVA = "0x1D16C38", Offset = "0x1D16C38", VA = "0x1D16C38")]
			set
			{
			}
		}

		[Token(Token = "0x1700003A")]
		public string sortingLayerName
		{
			[Token(Token = "0x6000177")]
			[Address(RVA = "0x1D16CE8", Offset = "0x1D16CE8", VA = "0x1D16CE8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000178")]
			[Address(RVA = "0x1D16CF4", Offset = "0x1D16CF4", VA = "0x1D16CF4")]
			set
			{
			}
		}

		[Token(Token = "0x1700003B")]
		public int sortingOrder
		{
			[Token(Token = "0x6000179")]
			[Address(RVA = "0x1D1658C", Offset = "0x1D1658C", VA = "0x1D1658C")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600017A")]
			[Address(RVA = "0x1D16D24", Offset = "0x1D16D24", VA = "0x1D16D24")]
			set
			{
			}
		}

		[Token(Token = "0x1700003C")]
		public bool trackChangesDuringPlaytime
		{
			[Token(Token = "0x600017B")]
			[Address(RVA = "0x1D16DD4", Offset = "0x1D16DD4", VA = "0x1D16DD4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600017C")]
			[Address(RVA = "0x1D16DDC", Offset = "0x1D16DDC", VA = "0x1D16DDC")]
			set
			{
			}
		}

		[Token(Token = "0x1700003D")]
		public bool isCurrentlyTrackingChanges
		{
			[Token(Token = "0x600017D")]
			[Address(RVA = "0x1D16E3C", Offset = "0x1D16E3C", VA = "0x1D16E3C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700003E")]
		public bool hasGeometry
		{
			[Token(Token = "0x600017E")]
			[Address(RVA = "0x1D165B8", Offset = "0x1D165B8", VA = "0x1D165B8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700003F")]
		public Bounds bounds
		{
			[Token(Token = "0x600017F")]
			[Address(RVA = "0x1D16630", Offset = "0x1D16630", VA = "0x1D16630")]
			get
			{
				return default(Bounds);
			}
		}

		[Token(Token = "0x17000040")]
		public int blendingModeAsInt
		{
			[Token(Token = "0x6000180")]
			[Address(RVA = "0x1D16E4C", Offset = "0x1D16E4C", VA = "0x1D16E4C")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000041")]
		public MaterialManager.DynamicOcclusion _INTERNAL_DynamicOcclusionMode
		{
			[Token(Token = "0x6000181")]
			[Address(RVA = "0x1D16F4C", Offset = "0x1D16F4C", VA = "0x1D16F4C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F4214", Offset = "0x8F4214")]
			get
			{
				return default(MaterialManager.DynamicOcclusion);
			}
			[Token(Token = "0x6000182")]
			[Address(RVA = "0x1D16F54", Offset = "0x1D16F54", VA = "0x1D16F54")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F4224", Offset = "0x8F4224")]
			set
			{
			}
		}

		[Token(Token = "0x17000042")]
		public MaterialManager.DynamicOcclusion _INTERNAL_EnabledDynamicOcclusionMode
		{
			[Token(Token = "0x6000183")]
			[Address(RVA = "0x1D16F5C", Offset = "0x1D16F5C", VA = "0x1D16F5C")]
			get
			{
				return default(MaterialManager.DynamicOcclusion);
			}
		}

		[Token(Token = "0x17000043")]
		public uint _INTERNAL_InstancedMaterialGroupID
		{
			[Token(Token = "0x600018C")]
			[Address(RVA = "0x1D17F34", Offset = "0x1D17F34", VA = "0x1D17F34")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F4254", Offset = "0x8F4254")]
			get
			{
				return default(uint);
			}
			[Token(Token = "0x600018D")]
			[Address(RVA = "0x1D17F3C", Offset = "0x1D17F3C", VA = "0x1D17F3C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F4264", Offset = "0x8F4264")]
			protected set
			{
			}
		}

		[Token(Token = "0x17000044")]
		public string meshStats
		{
			[Token(Token = "0x600018E")]
			[Address(RVA = "0x1D17F44", Offset = "0x1D17F44", VA = "0x1D17F44")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000045")]
		public int meshVerticesCount
		{
			[Token(Token = "0x600018F")]
			[Address(RVA = "0x1D180F4", Offset = "0x1D180F4", VA = "0x1D180F4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000046")]
		public int meshTrianglesCount
		{
			[Token(Token = "0x6000190")]
			[Address(RVA = "0x1D18200", Offset = "0x1D18200", VA = "0x1D18200")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000047")]
		private Light lightSpotAttached
		{
			[Token(Token = "0x6000191")]
			[Address(RVA = "0x1D1832C", Offset = "0x1D1832C", VA = "0x1D1832C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x14000001")]
		public event OnWillCameraRenderCB onWillCameraRenderThisBeam
		{
			[Token(Token = "0x6000185")]
			[Address(RVA = "0x1D17034", Offset = "0x1D17034", VA = "0x1D17034")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F4234", Offset = "0x8F4234")]
			add
			{
			}
			[Token(Token = "0x6000186")]
			[Address(RVA = "0x1D17120", Offset = "0x1D17120", VA = "0x1D17120")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F4244", Offset = "0x8F4244")]
			remove
			{
			}
		}

		[Token(Token = "0x6000184")]
		[Address(RVA = "0x1D16F74", Offset = "0x1D16F74", VA = "0x1D16F74")]
		public void _INTERNAL_SetDynamicOcclusionCallback(string shaderKeyword, MaterialModifier.Callback cb)
		{
		}

		[Token(Token = "0x6000187")]
		[Address(RVA = "0x1D1720C", Offset = "0x1D1720C", VA = "0x1D1720C")]
		public void _INTERNAL_OnWillCameraRenderThisBeam(Camera cam)
		{
		}

		[Token(Token = "0x6000188")]
		[Address(RVA = "0x1D17950", Offset = "0x1D17950", VA = "0x1D17950")]
		public void RegisterOnBeamGeometryInitializedCallback(OnBeamGeometryInitialized cb)
		{
		}

		[Token(Token = "0x6000189")]
		[Address(RVA = "0x1D17A58", Offset = "0x1D17A58", VA = "0x1D17A58")]
		private void CallOnBeamGeometryInitializedCallback()
		{
		}

		[Token(Token = "0x600018A")]
		[Address(RVA = "0x1D16BDC", Offset = "0x1D16BDC", VA = "0x1D16BDC")]
		private void SetFadeOutValue(ref float propToChange, float value)
		{
		}

		[Token(Token = "0x600018B")]
		[Address(RVA = "0x1D17E84", Offset = "0x1D17E84", VA = "0x1D17E84")]
		private void OnFadeOutStateChanged()
		{
		}

		[Token(Token = "0x6000192")]
		[Address(RVA = "0x1D1842C", Offset = "0x1D1842C", VA = "0x1D1842C")]
		public float GetInsideBeamFactor(Vector3 posWS)
		{
			return default(float);
		}

		[Token(Token = "0x6000193")]
		[Address(RVA = "0x1D18494", Offset = "0x1D18494", VA = "0x1D18494")]
		public float GetInsideBeamFactorFromObjectSpacePos(Vector3 posOS)
		{
			return default(float);
		}

		[Token(Token = "0x6000194")]
		[Address(RVA = "0x1D18630", Offset = "0x1D18630", VA = "0x1D18630")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x8F4274", Offset = "0x8F4274")]
		public void Generate()
		{
		}

		[Token(Token = "0x6000195")]
		[Address(RVA = "0x1D1863C", Offset = "0x1D1863C", VA = "0x1D1863C", Slot = "4")]
		public virtual void GenerateGeometry()
		{
		}

		[Token(Token = "0x6000196")]
		[Address(RVA = "0x1D188E4", Offset = "0x1D188E4", VA = "0x1D188E4", Slot = "5")]
		public virtual void UpdateAfterManualPropertyChange()
		{
		}

		[Token(Token = "0x6000197")]
		[Address(RVA = "0x1D18984", Offset = "0x1D18984", VA = "0x1D18984")]
		private void Start()
		{
		}

		[Token(Token = "0x6000198")]
		[Address(RVA = "0x1D18990", Offset = "0x1D18990", VA = "0x1D18990")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000199")]
		[Address(RVA = "0x1D18A28", Offset = "0x1D18A28", VA = "0x1D18A28")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600019A")]
		[Address(RVA = "0x1D16DE8", Offset = "0x1D16DE8", VA = "0x1D16DE8")]
		private void StartPlaytimeUpdateIfNeeded()
		{
		}

		[Token(Token = "0x600019B")]
		[Address(RVA = "0x1D18AC0", Offset = "0x1D18AC0", VA = "0x1D18AC0")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x8F42AC", Offset = "0x8F42AC")]
		private IEnumerator CoPlaytimeUpdate()
		{
			return null;
		}

		[Token(Token = "0x600019C")]
		[Address(RVA = "0x1D18B60", Offset = "0x1D18B60", VA = "0x1D18B60")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600019D")]
		[Address(RVA = "0x1D18B64", Offset = "0x1D18B64", VA = "0x1D18B64")]
		private void DestroyBeam()
		{
		}

		[Token(Token = "0x600019E")]
		[Address(RVA = "0x1D18C2C", Offset = "0x1D18C2C", VA = "0x1D18C2C")]
		private void AssignPropertiesFromSpotLight(Light lightSpot)
		{
		}

		[Token(Token = "0x600019F")]
		[Address(RVA = "0x1D18D60", Offset = "0x1D18D60", VA = "0x1D18D60")]
		private void ClampProperties()
		{
		}

		[Token(Token = "0x60001A0")]
		[Address(RVA = "0x1D188B4", Offset = "0x1D188B4", VA = "0x1D188B4")]
		private void ValidateProperties()
		{
		}

		[Token(Token = "0x60001A1")]
		[Address(RVA = "0x1D18788", Offset = "0x1D18788", VA = "0x1D18788")]
		private void HandleBackwardCompatibility(int serializedVersion, int newVersion)
		{
		}

		[Token(Token = "0x60001A2")]
		[Address(RVA = "0x1D18F4C", Offset = "0x1D18F4C", VA = "0x1D18F4C")]
		public VolumetricLightBeam()
		{
		}
	}
}
namespace VLB_Samples
{
	[Token(Token = "0x200002C")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x8F2070", Offset = "0x8F2070")]
	public class CameraToggleBeamVisibility : MonoBehaviour
	{
		[Token(Token = "0x400015A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private KeyCode m_KeyCode;

		[Token(Token = "0x60001A3")]
		[Address(RVA = "0x1D1920C", Offset = "0x1D1920C", VA = "0x1D1920C")]
		private void Update()
		{
		}

		[Token(Token = "0x60001A4")]
		[Address(RVA = "0x1D1934C", Offset = "0x1D1934C", VA = "0x1D1934C")]
		public CameraToggleBeamVisibility()
		{
		}
	}
	[Token(Token = "0x200002D")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x8F20D4", Offset = "0x8F20D4")]
	public class CheckIfInsideBeam : MonoBehaviour
	{
		[Token(Token = "0x400015B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private bool isInsideBeam;

		[Token(Token = "0x400015C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Material m_Material;

		[Token(Token = "0x400015D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Collider m_Collider;

		[Token(Token = "0x60001A5")]
		[Address(RVA = "0x1D1935C", Offset = "0x1D1935C", VA = "0x1D1935C")]
		private void Start()
		{
		}

		[Token(Token = "0x60001A6")]
		[Address(RVA = "0x1D1941C", Offset = "0x1D1941C", VA = "0x1D1941C")]
		private void Update()
		{
		}

		[Token(Token = "0x60001A7")]
		[Address(RVA = "0x1D19514", Offset = "0x1D19514", VA = "0x1D19514")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60001A8")]
		[Address(RVA = "0x1D1951C", Offset = "0x1D1951C", VA = "0x1D1951C")]
		private void OnTriggerStay(Collider trigger)
		{
		}

		[Token(Token = "0x60001A9")]
		[Address(RVA = "0x1D195F4", Offset = "0x1D195F4", VA = "0x1D195F4")]
		public CheckIfInsideBeam()
		{
		}
	}
	[Token(Token = "0x200002E")]
	public class FeaturesNotSupportedMessage : MonoBehaviour
	{
		[Token(Token = "0x60001AA")]
		[Address(RVA = "0x1D195FC", Offset = "0x1D195FC", VA = "0x1D195FC")]
		private void Start()
		{
		}

		[Token(Token = "0x60001AB")]
		[Address(RVA = "0x1D196B8", Offset = "0x1D196B8", VA = "0x1D196B8")]
		public FeaturesNotSupportedMessage()
		{
		}
	}
	[Token(Token = "0x200002F")]
	public class FreeCameraController : MonoBehaviour
	{
		[Token(Token = "0x400015E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float cameraSensitivity;

		[Token(Token = "0x400015F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float speedNormal;

		[Token(Token = "0x4000160")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float speedFactorSlow;

		[Token(Token = "0x4000161")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float speedFactorFast;

		[Token(Token = "0x4000162")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float speedClimb;

		[Token(Token = "0x4000163")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private float rotationH;

		[Token(Token = "0x4000164")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float rotationV;

		[Token(Token = "0x4000165")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private bool m_UseMouseView;

		[Token(Token = "0x17000048")]
		private bool useMouseView
		{
			[Token(Token = "0x60001AC")]
			[Address(RVA = "0x1D196C0", Offset = "0x1D196C0", VA = "0x1D196C0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60001AD")]
			[Address(RVA = "0x1D196C8", Offset = "0x1D196C8", VA = "0x1D196C8")]
			set
			{
			}
		}

		[Token(Token = "0x60001AE")]
		[Address(RVA = "0x1D19704", Offset = "0x1D19704", VA = "0x1D19704")]
		private void Start()
		{
		}

		[Token(Token = "0x60001AF")]
		[Address(RVA = "0x1D197A4", Offset = "0x1D197A4", VA = "0x1D197A4")]
		private void Update()
		{
		}

		[Token(Token = "0x60001B0")]
		[Address(RVA = "0x1D19F70", Offset = "0x1D19F70", VA = "0x1D19F70")]
		public FreeCameraController()
		{
		}
	}
	[Token(Token = "0x2000030")]
	public class LightGenerator : MonoBehaviour
	{
		[Token(Token = "0x4000166")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8F2C60", Offset = "0x8F2C60")]
		[SerializeField]
		private int CountX;

		[Token(Token = "0x4000167")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8F2CA4", Offset = "0x8F2CA4")]
		[SerializeField]
		private int CountY;

		[Token(Token = "0x4000168")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float OffsetUnits;

		[Token(Token = "0x4000169")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[SerializeField]
		private float PositionY;

		[Token(Token = "0x400016A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private bool NoiseEnabled;

		[Token(Token = "0x400016B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
		[SerializeField]
		private bool AddLight;

		[Token(Token = "0x60001B1")]
		[Address(RVA = "0x1D19F94", Offset = "0x1D19F94", VA = "0x1D19F94")]
		public void Generate()
		{
		}

		[Token(Token = "0x60001B2")]
		[Address(RVA = "0x1D1AB4C", Offset = "0x1D1AB4C", VA = "0x1D1AB4C")]
		public LightGenerator()
		{
		}
	}
	[Token(Token = "0x2000031")]
	public class Rotater : MonoBehaviour
	{
		[Token(Token = "0x400016C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x8F2D28", Offset = "0x8F2D28")]
		public Vector3 EulerSpeed;

		[Token(Token = "0x60001B3")]
		[Address(RVA = "0x1D1AB6C", Offset = "0x1D1AB6C", VA = "0x1D1AB6C")]
		private void Update()
		{
		}

		[Token(Token = "0x60001B4")]
		[Address(RVA = "0x1D1AD14", Offset = "0x1D1AD14", VA = "0x1D1AD14")]
		public Rotater()
		{
		}
	}
}
namespace FMOD
{
	[Token(Token = "0x2000032")]
	public class VERSION
	{
		[Token(Token = "0x400016D")]
		public const int number = 131075;

		[Token(Token = "0x400016E")]
		public const string dll = "fmod";

		[Token(Token = "0x60001B5")]
		[Address(RVA = "0x102CF18", Offset = "0x102CF18", VA = "0x102CF18")]
		public VERSION()
		{
		}
	}
	[Token(Token = "0x2000033")]
	public class CONSTANTS
	{
		[Token(Token = "0x400016F")]
		public const int MAX_CHANNEL_WIDTH = 32;

		[Token(Token = "0x4000170")]
		public const int MAX_LISTENERS = 8;

		[Token(Token = "0x4000171")]
		public const int REVERB_MAXINSTANCES = 4;

		[Token(Token = "0x4000172")]
		public const int MAX_SYSTEMS = 8;

		[Token(Token = "0x60001B6")]
		[Address(RVA = "0x1A5D56C", Offset = "0x1A5D56C", VA = "0x1A5D56C")]
		public CONSTANTS()
		{
		}
	}
	[Token(Token = "0x2000034")]
	public enum RESULT
	{
		[Token(Token = "0x4000174")]
		OK,
		[Token(Token = "0x4000175")]
		ERR_BADCOMMAND,
		[Token(Token = "0x4000176")]
		ERR_CHANNEL_ALLOC,
		[Token(Token = "0x4000177")]
		ERR_CHANNEL_STOLEN,
		[Token(Token = "0x4000178")]
		ERR_DMA,
		[Token(Token = "0x4000179")]
		ERR_DSP_CONNECTION,
		[Token(Token = "0x400017A")]
		ERR_DSP_DONTPROCESS,
		[Token(Token = "0x400017B")]
		ERR_DSP_FORMAT,
		[Token(Token = "0x400017C")]
		ERR_DSP_INUSE,
		[Token(Token = "0x400017D")]
		ERR_DSP_NOTFOUND,
		[Token(Token = "0x400017E")]
		ERR_DSP_RESERVED,
		[Token(Token = "0x400017F")]
		ERR_DSP_SILENCE,
		[Token(Token = "0x4000180")]
		ERR_DSP_TYPE,
		[Token(Token = "0x4000181")]
		ERR_FILE_BAD,
		[Token(Token = "0x4000182")]
		ERR_FILE_COULDNOTSEEK,
		[Token(Token = "0x4000183")]
		ERR_FILE_DISKEJECTED,
		[Token(Token = "0x4000184")]
		ERR_FILE_EOF,
		[Token(Token = "0x4000185")]
		ERR_FILE_ENDOFDATA,
		[Token(Token = "0x4000186")]
		ERR_FILE_NOTFOUND,
		[Token(Token = "0x4000187")]
		ERR_FORMAT,
		[Token(Token = "0x4000188")]
		ERR_HEADER_MISMATCH,
		[Token(Token = "0x4000189")]
		ERR_HTTP,
		[Token(Token = "0x400018A")]
		ERR_HTTP_ACCESS,
		[Token(Token = "0x400018B")]
		ERR_HTTP_PROXY_AUTH,
		[Token(Token = "0x400018C")]
		ERR_HTTP_SERVER_ERROR,
		[Token(Token = "0x400018D")]
		ERR_HTTP_TIMEOUT,
		[Token(Token = "0x400018E")]
		ERR_INITIALIZATION,
		[Token(Token = "0x400018F")]
		ERR_INITIALIZED,
		[Token(Token = "0x4000190")]
		ERR_INTERNAL,
		[Token(Token = "0x4000191")]
		ERR_INVALID_FLOAT,
		[Token(Token = "0x4000192")]
		ERR_INVALID_HANDLE,
		[Token(Token = "0x4000193")]
		ERR_INVALID_PARAM,
		[Token(Token = "0x4000194")]
		ERR_INVALID_POSITION,
		[Token(Token = "0x4000195")]
		ERR_INVALID_SPEAKER,
		[Token(Token = "0x4000196")]
		ERR_INVALID_SYNCPOINT,
		[Token(Token = "0x4000197")]
		ERR_INVALID_THREAD,
		[Token(Token = "0x4000198")]
		ERR_INVALID_VECTOR,
		[Token(Token = "0x4000199")]
		ERR_MAXAUDIBLE,
		[Token(Token = "0x400019A")]
		ERR_MEMORY,
		[Token(Token = "0x400019B")]
		ERR_MEMORY_CANTPOINT,
		[Token(Token = "0x400019C")]
		ERR_NEEDS3D,
		[Token(Token = "0x400019D")]
		ERR_NEEDSHARDWARE,
		[Token(Token = "0x400019E")]
		ERR_NET_CONNECT,
		[Token(Token = "0x400019F")]
		ERR_NET_SOCKET_ERROR,
		[Token(Token = "0x40001A0")]
		ERR_NET_URL,
		[Token(Token = "0x40001A1")]
		ERR_NET_WOULD_BLOCK,
		[Token(Token = "0x40001A2")]
		ERR_NOTREADY,
		[Token(Token = "0x40001A3")]
		ERR_OUTPUT_ALLOCATED,
		[Token(Token = "0x40001A4")]
		ERR_OUTPUT_CREATEBUFFER,
		[Token(Token = "0x40001A5")]
		ERR_OUTPUT_DRIVERCALL,
		[Token(Token = "0x40001A6")]
		ERR_OUTPUT_FORMAT,
		[Token(Token = "0x40001A7")]
		ERR_OUTPUT_INIT,
		[Token(Token = "0x40001A8")]
		ERR_OUTPUT_NODRIVERS,
		[Token(Token = "0x40001A9")]
		ERR_PLUGIN,
		[Token(Token = "0x40001AA")]
		ERR_PLUGIN_MISSING,
		[Token(Token = "0x40001AB")]
		ERR_PLUGIN_RESOURCE,
		[Token(Token = "0x40001AC")]
		ERR_PLUGIN_VERSION,
		[Token(Token = "0x40001AD")]
		ERR_RECORD,
		[Token(Token = "0x40001AE")]
		ERR_REVERB_CHANNELGROUP,
		[Token(Token = "0x40001AF")]
		ERR_REVERB_INSTANCE,
		[Token(Token = "0x40001B0")]
		ERR_SUBSOUNDS,
		[Token(Token = "0x40001B1")]
		ERR_SUBSOUND_ALLOCATED,
		[Token(Token = "0x40001B2")]
		ERR_SUBSOUND_CANTMOVE,
		[Token(Token = "0x40001B3")]
		ERR_TAGNOTFOUND,
		[Token(Token = "0x40001B4")]
		ERR_TOOMANYCHANNELS,
		[Token(Token = "0x40001B5")]
		ERR_TRUNCATED,
		[Token(Token = "0x40001B6")]
		ERR_UNIMPLEMENTED,
		[Token(Token = "0x40001B7")]
		ERR_UNINITIALIZED,
		[Token(Token = "0x40001B8")]
		ERR_UNSUPPORTED,
		[Token(Token = "0x40001B9")]
		ERR_VERSION,
		[Token(Token = "0x40001BA")]
		ERR_EVENT_ALREADY_LOADED,
		[Token(Token = "0x40001BB")]
		ERR_EVENT_LIVEUPDATE_BUSY,
		[Token(Token = "0x40001BC")]
		ERR_EVENT_LIVEUPDATE_MISMATCH,
		[Token(Token = "0x40001BD")]
		ERR_EVENT_LIVEUPDATE_TIMEOUT,
		[Token(Token = "0x40001BE")]
		ERR_EVENT_NOTFOUND,
		[Token(Token = "0x40001BF")]
		ERR_STUDIO_UNINITIALIZED,
		[Token(Token = "0x40001C0")]
		ERR_STUDIO_NOT_LOADED,
		[Token(Token = "0x40001C1")]
		ERR_INVALID_STRING,
		[Token(Token = "0x40001C2")]
		ERR_ALREADY_LOCKED,
		[Token(Token = "0x40001C3")]
		ERR_NOT_LOCKED,
		[Token(Token = "0x40001C4")]
		ERR_RECORD_DISCONNECTED,
		[Token(Token = "0x40001C5")]
		ERR_TOOMANYSAMPLES
	}
	[Token(Token = "0x2000035")]
	public enum CHANNELCONTROL_TYPE
	{
		[Token(Token = "0x40001C7")]
		CHANNEL,
		[Token(Token = "0x40001C8")]
		CHANNELGROUP,
		[Token(Token = "0x40001C9")]
		MAX
	}
	[Token(Token = "0x2000036")]
	public struct VECTOR
	{
		[Token(Token = "0x40001CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float x;

		[Token(Token = "0x40001CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public float y;

		[Token(Token = "0x40001CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public float z;
	}
	[Token(Token = "0x2000037")]
	public struct ATTRIBUTES_3D
	{
		[Token(Token = "0x40001CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public VECTOR position;

		[Token(Token = "0x40001CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public VECTOR velocity;

		[Token(Token = "0x40001CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public VECTOR forward;

		[Token(Token = "0x40001D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public VECTOR up;
	}
	[Token(Token = "0x2000038")]
	public struct ASYNCREADINFO
	{
		[Token(Token = "0x40001D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public IntPtr handle;

		[Token(Token = "0x40001D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public uint offset;

		[Token(Token = "0x40001D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public uint sizebytes;

		[Token(Token = "0x40001D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int priority;

		[Token(Token = "0x40001D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public IntPtr userdata;

		[Token(Token = "0x40001D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public IntPtr buffer;

		[Token(Token = "0x40001D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public uint bytesread;

		[Token(Token = "0x40001D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public FILE_ASYNCDONE_FUNC done;
	}
	[Token(Token = "0x2000039")]
	public enum OUTPUTTYPE
	{
		[Token(Token = "0x40001DA")]
		AUTODETECT,
		[Token(Token = "0x40001DB")]
		UNKNOWN,
		[Token(Token = "0x40001DC")]
		NOSOUND,
		[Token(Token = "0x40001DD")]
		WAVWRITER,
		[Token(Token = "0x40001DE")]
		NOSOUND_NRT,
		[Token(Token = "0x40001DF")]
		WAVWRITER_NRT,
		[Token(Token = "0x40001E0")]
		WASAPI,
		[Token(Token = "0x40001E1")]
		ASIO,
		[Token(Token = "0x40001E2")]
		PULSEAUDIO,
		[Token(Token = "0x40001E3")]
		ALSA,
		[Token(Token = "0x40001E4")]
		COREAUDIO,
		[Token(Token = "0x40001E5")]
		AUDIOTRACK,
		[Token(Token = "0x40001E6")]
		OPENSL,
		[Token(Token = "0x40001E7")]
		AUDIOOUT,
		[Token(Token = "0x40001E8")]
		AUDIO3D,
		[Token(Token = "0x40001E9")]
		WEBAUDIO,
		[Token(Token = "0x40001EA")]
		NNAUDIO,
		[Token(Token = "0x40001EB")]
		WINSONIC,
		[Token(Token = "0x40001EC")]
		AAUDIO,
		[Token(Token = "0x40001ED")]
		MAX
	}
	[Token(Token = "0x200003A")]
	public enum DEBUG_MODE
	{
		[Token(Token = "0x40001EF")]
		TTY,
		[Token(Token = "0x40001F0")]
		FILE,
		[Token(Token = "0x40001F1")]
		CALLBACK
	}
	[Token(Token = "0x200003B")]
	[Flags]
	public enum DEBUG_FLAGS : uint
	{
		[Token(Token = "0x40001F3")]
		NONE = 0u,
		[Token(Token = "0x40001F4")]
		ERROR = 1u,
		[Token(Token = "0x40001F5")]
		WARNING = 2u,
		[Token(Token = "0x40001F6")]
		LOG = 4u,
		[Token(Token = "0x40001F7")]
		TYPE_MEMORY = 0x100u,
		[Token(Token = "0x40001F8")]
		TYPE_FILE = 0x200u,
		[Token(Token = "0x40001F9")]
		TYPE_CODEC = 0x400u,
		[Token(Token = "0x40001FA")]
		TYPE_TRACE = 0x800u,
		[Token(Token = "0x40001FB")]
		DISPLAY_TIMESTAMPS = 0x10000u,
		[Token(Token = "0x40001FC")]
		DISPLAY_LINENUMBERS = 0x20000u,
		[Token(Token = "0x40001FD")]
		DISPLAY_THREAD = 0x40000u
	}
	[Token(Token = "0x200003C")]
	[Flags]
	public enum MEMORY_TYPE : uint
	{
		[Token(Token = "0x40001FF")]
		NORMAL = 0u,
		[Token(Token = "0x4000200")]
		STREAM_FILE = 1u,
		[Token(Token = "0x4000201")]
		STREAM_DECODE = 2u,
		[Token(Token = "0x4000202")]
		SAMPLEDATA = 4u,
		[Token(Token = "0x4000203")]
		DSP_BUFFER = 8u,
		[Token(Token = "0x4000204")]
		PLUGIN = 0x10u,
		[Token(Token = "0x4000205")]
		PERSISTENT = 0x200000u,
		[Token(Token = "0x4000206")]
		ALL = uint.MaxValue
	}
	[Token(Token = "0x200003D")]
	public enum SPEAKERMODE
	{
		[Token(Token = "0x4000208")]
		DEFAULT,
		[Token(Token = "0x4000209")]
		RAW,
		[Token(Token = "0x400020A")]
		MONO,
		[Token(Token = "0x400020B")]
		STEREO,
		[Token(Token = "0x400020C")]
		QUAD,
		[Token(Token = "0x400020D")]
		SURROUND,
		[Token(Token = "0x400020E")]
		_5POINT1,
		[Token(Token = "0x400020F")]
		_7POINT1,
		[Token(Token = "0x4000210")]
		_7POINT1POINT4,
		[Token(Token = "0x4000211")]
		MAX
	}
	[Token(Token = "0x200003E")]
	public enum SPEAKER
	{
		[Token(Token = "0x4000213")]
		NONE = -1,
		[Token(Token = "0x4000214")]
		FRONT_LEFT,
		[Token(Token = "0x4000215")]
		FRONT_RIGHT,
		[Token(Token = "0x4000216")]
		FRONT_CENTER,
		[Token(Token = "0x4000217")]
		LOW_FREQUENCY,
		[Token(Token = "0x4000218")]
		SURROUND_LEFT,
		[Token(Token = "0x4000219")]
		SURROUND_RIGHT,
		[Token(Token = "0x400021A")]
		BACK_LEFT,
		[Token(Token = "0x400021B")]
		BACK_RIGHT,
		[Token(Token = "0x400021C")]
		TOP_FRONT_LEFT,
		[Token(Token = "0x400021D")]
		TOP_FRONT_RIGHT,
		[Token(Token = "0x400021E")]
		TOP_BACK_LEFT,
		[Token(Token = "0x400021F")]
		TOP_BACK_RIGHT,
		[Token(Token = "0x4000220")]
		MAX
	}
	[Token(Token = "0x200003F")]
	[Flags]
	public enum CHANNELMASK : uint
	{
		[Token(Token = "0x4000222")]
		FRONT_LEFT = 1u,
		[Token(Token = "0x4000223")]
		FRONT_RIGHT = 2u,
		[Token(Token = "0x4000224")]
		FRONT_CENTER = 4u,
		[Token(Token = "0x4000225")]
		LOW_FREQUENCY = 8u,
		[Token(Token = "0x4000226")]
		SURROUND_LEFT = 0x10u,
		[Token(Token = "0x4000227")]
		SURROUND_RIGHT = 0x20u,
		[Token(Token = "0x4000228")]
		BACK_LEFT = 0x40u,
		[Token(Token = "0x4000229")]
		BACK_RIGHT = 0x80u,
		[Token(Token = "0x400022A")]
		BACK_CENTER = 0x100u,
		[Token(Token = "0x400022B")]
		MONO = 1u,
		[Token(Token = "0x400022C")]
		STEREO = 3u,
		[Token(Token = "0x400022D")]
		LRC = 7u,
		[Token(Token = "0x400022E")]
		QUAD = 0x33u,
		[Token(Token = "0x400022F")]
		SURROUND = 0x37u,
		[Token(Token = "0x4000230")]
		_5POINT1 = 0x3Fu,
		[Token(Token = "0x4000231")]
		_5POINT1_REARS = 0xCFu,
		[Token(Token = "0x4000232")]
		_7POINT0 = 0xF7u,
		[Token(Token = "0x4000233")]
		_7POINT1 = 0xFFu
	}
	[Token(Token = "0x2000040")]
	public enum CHANNELORDER
	{
		[Token(Token = "0x4000235")]
		DEFAULT,
		[Token(Token = "0x4000236")]
		WAVEFORMAT,
		[Token(Token = "0x4000237")]
		PROTOOLS,
		[Token(Token = "0x4000238")]
		ALLMONO,
		[Token(Token = "0x4000239")]
		ALLSTEREO,
		[Token(Token = "0x400023A")]
		ALSA,
		[Token(Token = "0x400023B")]
		MAX
	}
	[Token(Token = "0x2000041")]
	public enum PLUGINTYPE
	{
		[Token(Token = "0x400023D")]
		OUTPUT,
		[Token(Token = "0x400023E")]
		CODEC,
		[Token(Token = "0x400023F")]
		DSP,
		[Token(Token = "0x4000240")]
		MAX
	}
	[Token(Token = "0x2000042")]
	public struct PLUGINLIST
	{
		[Token(Token = "0x4000241")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private PLUGINTYPE type;

		[Token(Token = "0x4000242")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private IntPtr description;
	}
	[Token(Token = "0x2000043")]
	[Flags]
	public enum INITFLAGS : uint
	{
		[Token(Token = "0x4000244")]
		NORMAL = 0u,
		[Token(Token = "0x4000245")]
		STREAM_FROM_UPDATE = 1u,
		[Token(Token = "0x4000246")]
		MIX_FROM_UPDATE = 2u,
		[Token(Token = "0x4000247")]
		_3D_RIGHTHANDED = 4u,
		[Token(Token = "0x4000248")]
		CHANNEL_LOWPASS = 0x100u,
		[Token(Token = "0x4000249")]
		CHANNEL_DISTANCEFILTER = 0x200u,
		[Token(Token = "0x400024A")]
		PROFILE_ENABLE = 0x10000u,
		[Token(Token = "0x400024B")]
		VOL0_BECOMES_VIRTUAL = 0x20000u,
		[Token(Token = "0x400024C")]
		GEOMETRY_USECLOSEST = 0x40000u,
		[Token(Token = "0x400024D")]
		PREFER_DOLBY_DOWNMIX = 0x80000u,
		[Token(Token = "0x400024E")]
		THREAD_UNSAFE = 0x100000u,
		[Token(Token = "0x400024F")]
		PROFILE_METER_ALL = 0x200000u
	}
	[Token(Token = "0x2000044")]
	public enum SOUND_TYPE
	{
		[Token(Token = "0x4000251")]
		UNKNOWN,
		[Token(Token = "0x4000252")]
		AIFF,
		[Token(Token = "0x4000253")]
		ASF,
		[Token(Token = "0x4000254")]
		DLS,
		[Token(Token = "0x4000255")]
		FLAC,
		[Token(Token = "0x4000256")]
		FSB,
		[Token(Token = "0x4000257")]
		IT,
		[Token(Token = "0x4000258")]
		MIDI,
		[Token(Token = "0x4000259")]
		MOD,
		[Token(Token = "0x400025A")]
		MPEG,
		[Token(Token = "0x400025B")]
		OGGVORBIS,
		[Token(Token = "0x400025C")]
		PLAYLIST,
		[Token(Token = "0x400025D")]
		RAW,
		[Token(Token = "0x400025E")]
		S3M,
		[Token(Token = "0x400025F")]
		USER,
		[Token(Token = "0x4000260")]
		WAV,
		[Token(Token = "0x4000261")]
		XM,
		[Token(Token = "0x4000262")]
		XMA,
		[Token(Token = "0x4000263")]
		AUDIOQUEUE,
		[Token(Token = "0x4000264")]
		AT9,
		[Token(Token = "0x4000265")]
		VORBIS,
		[Token(Token = "0x4000266")]
		MEDIA_FOUNDATION,
		[Token(Token = "0x4000267")]
		MEDIACODEC,
		[Token(Token = "0x4000268")]
		FADPCM,
		[Token(Token = "0x4000269")]
		MAX
	}
	[Token(Token = "0x2000045")]
	public enum SOUND_FORMAT
	{
		[Token(Token = "0x400026B")]
		NONE,
		[Token(Token = "0x400026C")]
		PCM8,
		[Token(Token = "0x400026D")]
		PCM16,
		[Token(Token = "0x400026E")]
		PCM24,
		[Token(Token = "0x400026F")]
		PCM32,
		[Token(Token = "0x4000270")]
		PCMFLOAT,
		[Token(Token = "0x4000271")]
		BITSTREAM,
		[Token(Token = "0x4000272")]
		MAX
	}
	[Token(Token = "0x2000046")]
	[Flags]
	public enum MODE : uint
	{
		[Token(Token = "0x4000274")]
		DEFAULT = 0u,
		[Token(Token = "0x4000275")]
		LOOP_OFF = 1u,
		[Token(Token = "0x4000276")]
		LOOP_NORMAL = 2u,
		[Token(Token = "0x4000277")]
		LOOP_BIDI = 4u,
		[Token(Token = "0x4000278")]
		_2D = 8u,
		[Token(Token = "0x4000279")]
		_3D = 0x10u,
		[Token(Token = "0x400027A")]
		CREATESTREAM = 0x80u,
		[Token(Token = "0x400027B")]
		CREATESAMPLE = 0x100u,
		[Token(Token = "0x400027C")]
		CREATECOMPRESSEDSAMPLE = 0x200u,
		[Token(Token = "0x400027D")]
		OPENUSER = 0x400u,
		[Token(Token = "0x400027E")]
		OPENMEMORY = 0x800u,
		[Token(Token = "0x400027F")]
		OPENMEMORY_POINT = 0x10000000u,
		[Token(Token = "0x4000280")]
		OPENRAW = 0x1000u,
		[Token(Token = "0x4000281")]
		OPENONLY = 0x2000u,
		[Token(Token = "0x4000282")]
		ACCURATETIME = 0x4000u,
		[Token(Token = "0x4000283")]
		MPEGSEARCH = 0x8000u,
		[Token(Token = "0x4000284")]
		NONBLOCKING = 0x10000u,
		[Token(Token = "0x4000285")]
		UNIQUE = 0x20000u,
		[Token(Token = "0x4000286")]
		_3D_HEADRELATIVE = 0x40000u,
		[Token(Token = "0x4000287")]
		_3D_WORLDRELATIVE = 0x80000u,
		[Token(Token = "0x4000288")]
		_3D_INVERSEROLLOFF = 0x100000u,
		[Token(Token = "0x4000289")]
		_3D_LINEARROLLOFF = 0x200000u,
		[Token(Token = "0x400028A")]
		_3D_LINEARSQUAREROLLOFF = 0x400000u,
		[Token(Token = "0x400028B")]
		_3D_INVERSETAPEREDROLLOFF = 0x800000u,
		[Token(Token = "0x400028C")]
		_3D_CUSTOMROLLOFF = 0x4000000u,
		[Token(Token = "0x400028D")]
		_3D_IGNOREGEOMETRY = 0x40000000u,
		[Token(Token = "0x400028E")]
		IGNORETAGS = 0x2000000u,
		[Token(Token = "0x400028F")]
		LOWMEM = 0x8000000u,
		[Token(Token = "0x4000290")]
		VIRTUAL_PLAYFROMSTART = 0x80000000u
	}
	[Token(Token = "0x2000047")]
	public enum OPENSTATE
	{
		[Token(Token = "0x4000292")]
		READY,
		[Token(Token = "0x4000293")]
		LOADING,
		[Token(Token = "0x4000294")]
		ERROR,
		[Token(Token = "0x4000295")]
		CONNECTING,
		[Token(Token = "0x4000296")]
		BUFFERING,
		[Token(Token = "0x4000297")]
		SEEKING,
		[Token(Token = "0x4000298")]
		PLAYING,
		[Token(Token = "0x4000299")]
		SETPOSITION,
		[Token(Token = "0x400029A")]
		MAX
	}
	[Token(Token = "0x2000048")]
	public enum SOUNDGROUP_BEHAVIOR
	{
		[Token(Token = "0x400029C")]
		BEHAVIOR_FAIL,
		[Token(Token = "0x400029D")]
		BEHAVIOR_MUTE,
		[Token(Token = "0x400029E")]
		BEHAVIOR_STEALLOWEST,
		[Token(Token = "0x400029F")]
		MAX
	}
	[Token(Token = "0x2000049")]
	public enum CHANNELCONTROL_CALLBACK_TYPE
	{
		[Token(Token = "0x40002A1")]
		END,
		[Token(Token = "0x40002A2")]
		VIRTUALVOICE,
		[Token(Token = "0x40002A3")]
		SYNCPOINT,
		[Token(Token = "0x40002A4")]
		OCCLUSION,
		[Token(Token = "0x40002A5")]
		MAX
	}
	[Token(Token = "0x200004A")]
	public struct CHANNELCONTROL_DSP_INDEX
	{
		[Token(Token = "0x40002A6")]
		public const int HEAD = -1;

		[Token(Token = "0x40002A7")]
		public const int FADER = -2;

		[Token(Token = "0x40002A8")]
		public const int TAIL = -3;
	}
	[Token(Token = "0x200004B")]
	public enum ERRORCALLBACK_INSTANCETYPE
	{
		[Token(Token = "0x40002AA")]
		NONE,
		[Token(Token = "0x40002AB")]
		SYSTEM,
		[Token(Token = "0x40002AC")]
		CHANNEL,
		[Token(Token = "0x40002AD")]
		CHANNELGROUP,
		[Token(Token = "0x40002AE")]
		CHANNELCONTROL,
		[Token(Token = "0x40002AF")]
		SOUND,
		[Token(Token = "0x40002B0")]
		SOUNDGROUP,
		[Token(Token = "0x40002B1")]
		DSP,
		[Token(Token = "0x40002B2")]
		DSPCONNECTION,
		[Token(Token = "0x40002B3")]
		GEOMETRY,
		[Token(Token = "0x40002B4")]
		REVERB3D,
		[Token(Token = "0x40002B5")]
		STUDIO_SYSTEM,
		[Token(Token = "0x40002B6")]
		STUDIO_EVENTDESCRIPTION,
		[Token(Token = "0x40002B7")]
		STUDIO_EVENTINSTANCE,
		[Token(Token = "0x40002B8")]
		STUDIO_PARAMETERINSTANCE,
		[Token(Token = "0x40002B9")]
		STUDIO_BUS,
		[Token(Token = "0x40002BA")]
		STUDIO_VCA,
		[Token(Token = "0x40002BB")]
		STUDIO_BANK,
		[Token(Token = "0x40002BC")]
		STUDIO_COMMANDREPLAY
	}
	[Token(Token = "0x200004C")]
	public struct ERRORCALLBACK_INFO
	{
		[Token(Token = "0x40002BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public RESULT result;

		[Token(Token = "0x40002BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public ERRORCALLBACK_INSTANCETYPE instancetype;

		[Token(Token = "0x40002BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public IntPtr instance;

		[Token(Token = "0x40002C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public StringWrapper functionname;

		[Token(Token = "0x40002C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public StringWrapper functionparams;
	}
	[Token(Token = "0x200004D")]
	[Flags]
	public enum SYSTEM_CALLBACK_TYPE : uint
	{
		[Token(Token = "0x40002C3")]
		DEVICELISTCHANGED = 1u,
		[Token(Token = "0x40002C4")]
		DEVICELOST = 2u,
		[Token(Token = "0x40002C5")]
		MEMORYALLOCATIONFAILED = 4u,
		[Token(Token = "0x40002C6")]
		THREADCREATED = 8u,
		[Token(Token = "0x40002C7")]
		BADDSPCONNECTION = 0x10u,
		[Token(Token = "0x40002C8")]
		PREMIX = 0x20u,
		[Token(Token = "0x40002C9")]
		POSTMIX = 0x40u,
		[Token(Token = "0x40002CA")]
		ERROR = 0x80u,
		[Token(Token = "0x40002CB")]
		MIDMIX = 0x100u,
		[Token(Token = "0x40002CC")]
		THREADDESTROYED = 0x200u,
		[Token(Token = "0x40002CD")]
		PREUPDATE = 0x400u,
		[Token(Token = "0x40002CE")]
		POSTUPDATE = 0x800u,
		[Token(Token = "0x40002CF")]
		RECORDLISTCHANGED = 0x1000u,
		[Token(Token = "0x40002D0")]
		ALL = uint.MaxValue
	}
	[Token(Token = "0x200004E")]
	public delegate RESULT DEBUG_CALLBACK(DEBUG_FLAGS flags, StringWrapper file, int line, StringWrapper func, StringWrapper message);
	[Token(Token = "0x200004F")]
	public delegate RESULT SYSTEM_CALLBACK(IntPtr system, SYSTEM_CALLBACK_TYPE type, IntPtr commanddata1, IntPtr commanddata2, IntPtr userdata);
	[Token(Token = "0x2000050")]
	public delegate RESULT CHANNELCONTROL_CALLBACK(IntPtr channelcontrol, CHANNELCONTROL_TYPE controltype, CHANNELCONTROL_CALLBACK_TYPE callbacktype, IntPtr commanddata1, IntPtr commanddata2);
	[Token(Token = "0x2000051")]
	public delegate RESULT SOUND_NONBLOCK_CALLBACK(IntPtr sound, RESULT result);
	[Token(Token = "0x2000052")]
	public delegate RESULT SOUND_PCMREAD_CALLBACK(IntPtr sound, IntPtr data, uint datalen);
	[Token(Token = "0x2000053")]
	public delegate RESULT SOUND_PCMSETPOS_CALLBACK(IntPtr sound, int subsound, uint position, TIMEUNIT postype);
	[Token(Token = "0x2000054")]
	public delegate RESULT FILE_OPEN_CALLBACK(StringWrapper name, ref uint filesize, ref IntPtr handle, IntPtr userdata);
	[Token(Token = "0x2000055")]
	public delegate RESULT FILE_CLOSE_CALLBACK(IntPtr handle, IntPtr userdata);
	[Token(Token = "0x2000056")]
	public delegate RESULT FILE_READ_CALLBACK(IntPtr handle, IntPtr buffer, uint sizebytes, ref uint bytesread, IntPtr userdata);
	[Token(Token = "0x2000057")]
	public delegate RESULT FILE_SEEK_CALLBACK(IntPtr handle, uint pos, IntPtr userdata);
	[Token(Token = "0x2000058")]
	public delegate RESULT FILE_ASYNCREAD_CALLBACK(IntPtr info, IntPtr userdata);
	[Token(Token = "0x2000059")]
	public delegate RESULT FILE_ASYNCCANCEL_CALLBACK(IntPtr info, IntPtr userdata);
	[Token(Token = "0x200005A")]
	public delegate RESULT FILE_ASYNCDONE_FUNC(IntPtr info, RESULT result);
	[Token(Token = "0x200005B")]
	public delegate IntPtr MEMORY_ALLOC_CALLBACK(uint size, MEMORY_TYPE type, StringWrapper sourcestr);
	[Token(Token = "0x200005C")]
	public delegate IntPtr MEMORY_REALLOC_CALLBACK(IntPtr ptr, uint size, MEMORY_TYPE type, StringWrapper sourcestr);
	[Token(Token = "0x200005D")]
	public delegate void MEMORY_FREE_CALLBACK(IntPtr ptr, MEMORY_TYPE type, StringWrapper sourcestr);
	[Token(Token = "0x200005E")]
	public delegate float CB_3D_ROLLOFF_CALLBACK(IntPtr channelcontrol, float distance);
	[Token(Token = "0x200005F")]
	public enum DSP_RESAMPLER
	{
		[Token(Token = "0x40002D2")]
		DEFAULT,
		[Token(Token = "0x40002D3")]
		NOINTERP,
		[Token(Token = "0x40002D4")]
		LINEAR,
		[Token(Token = "0x40002D5")]
		CUBIC,
		[Token(Token = "0x40002D6")]
		SPLINE,
		[Token(Token = "0x40002D7")]
		MAX
	}
	[Token(Token = "0x2000060")]
	public enum DSPCONNECTION_TYPE
	{
		[Token(Token = "0x40002D9")]
		STANDARD,
		[Token(Token = "0x40002DA")]
		SIDECHAIN,
		[Token(Token = "0x40002DB")]
		SEND,
		[Token(Token = "0x40002DC")]
		SEND_SIDECHAIN,
		[Token(Token = "0x40002DD")]
		MAX
	}
	[Token(Token = "0x2000061")]
	public enum TAGTYPE
	{
		[Token(Token = "0x40002DF")]
		UNKNOWN,
		[Token(Token = "0x40002E0")]
		ID3V1,
		[Token(Token = "0x40002E1")]
		ID3V2,
		[Token(Token = "0x40002E2")]
		VORBISCOMMENT,
		[Token(Token = "0x40002E3")]
		SHOUTCAST,
		[Token(Token = "0x40002E4")]
		ICECAST,
		[Token(Token = "0x40002E5")]
		ASF,
		[Token(Token = "0x40002E6")]
		MIDI,
		[Token(Token = "0x40002E7")]
		PLAYLIST,
		[Token(Token = "0x40002E8")]
		FMOD,
		[Token(Token = "0x40002E9")]
		USER,
		[Token(Token = "0x40002EA")]
		MAX
	}
	[Token(Token = "0x2000062")]
	public enum TAGDATATYPE
	{
		[Token(Token = "0x40002EC")]
		BINARY,
		[Token(Token = "0x40002ED")]
		INT,
		[Token(Token = "0x40002EE")]
		FLOAT,
		[Token(Token = "0x40002EF")]
		STRING,
		[Token(Token = "0x40002F0")]
		STRING_UTF16,
		[Token(Token = "0x40002F1")]
		STRING_UTF16BE,
		[Token(Token = "0x40002F2")]
		STRING_UTF8,
		[Token(Token = "0x40002F3")]
		MAX
	}
	[Token(Token = "0x2000063")]
	public struct TAG
	{
		[Token(Token = "0x40002F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public TAGTYPE type;

		[Token(Token = "0x40002F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public TAGDATATYPE datatype;

		[Token(Token = "0x40002F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public StringWrapper name;

		[Token(Token = "0x40002F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public IntPtr data;

		[Token(Token = "0x40002F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public uint datalen;

		[Token(Token = "0x40002F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public bool updated;
	}
	[Token(Token = "0x2000064")]
	[Flags]
	public enum TIMEUNIT : uint
	{
		[Token(Token = "0x40002FB")]
		MS = 1u,
		[Token(Token = "0x40002FC")]
		PCM = 2u,
		[Token(Token = "0x40002FD")]
		PCMBYTES = 4u,
		[Token(Token = "0x40002FE")]
		RAWBYTES = 8u,
		[Token(Token = "0x40002FF")]
		PCMFRACTION = 0x10u,
		[Token(Token = "0x4000300")]
		MODORDER = 0x100u,
		[Token(Token = "0x4000301")]
		MODROW = 0x200u,
		[Token(Token = "0x4000302")]
		MODPATTERN = 0x400u
	}
	[Token(Token = "0x2000065")]
	public struct PORT_INDEX
	{
		[Token(Token = "0x4000303")]
		public const ulong NONE = ulong.MaxValue;
	}
	[Token(Token = "0x2000066")]
	public struct CREATESOUNDEXINFO
	{
		[Token(Token = "0x4000304")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int cbsize;

		[Token(Token = "0x4000305")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public uint length;

		[Token(Token = "0x4000306")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public uint fileoffset;

		[Token(Token = "0x4000307")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public int numchannels;

		[Token(Token = "0x4000308")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int defaultfrequency;

		[Token(Token = "0x4000309")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public SOUND_FORMAT format;

		[Token(Token = "0x400030A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public uint decodebuffersize;

		[Token(Token = "0x400030B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public int initialsubsound;

		[Token(Token = "0x400030C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public int numsubsounds;

		[Token(Token = "0x400030D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public IntPtr inclusionlist;

		[Token(Token = "0x400030E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public int inclusionlistnum;

		[Token(Token = "0x400030F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public SOUND_PCMREAD_CALLBACK pcmreadcallback;

		[Token(Token = "0x4000310")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public SOUND_PCMSETPOS_CALLBACK pcmsetposcallback;

		[Token(Token = "0x4000311")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public SOUND_NONBLOCK_CALLBACK nonblockcallback;

		[Token(Token = "0x4000312")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public IntPtr dlsname;

		[Token(Token = "0x4000313")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public IntPtr encryptionkey;

		[Token(Token = "0x4000314")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public int maxpolyphony;

		[Token(Token = "0x4000315")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public IntPtr userdata;

		[Token(Token = "0x4000316")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public SOUND_TYPE suggestedsoundtype;

		[Token(Token = "0x4000317")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public FILE_OPEN_CALLBACK fileuseropen;

		[Token(Token = "0x4000318")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public FILE_CLOSE_CALLBACK fileuserclose;

		[Token(Token = "0x4000319")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public FILE_READ_CALLBACK fileuserread;

		[Token(Token = "0x400031A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public FILE_SEEK_CALLBACK fileuserseek;

		[Token(Token = "0x400031B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public FILE_ASYNCREAD_CALLBACK fileuserasyncread;

		[Token(Token = "0x400031C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public FILE_ASYNCCANCEL_CALLBACK fileuserasynccancel;

		[Token(Token = "0x400031D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public IntPtr fileuserdata;

		[Token(Token = "0x400031E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public int filebuffersize;

		[Token(Token = "0x400031F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		public CHANNELORDER channelorder;

		[Token(Token = "0x4000320")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public IntPtr initialsoundgroup;

		[Token(Token = "0x4000321")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public uint initialseekposition;

		[Token(Token = "0x4000322")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		public TIMEUNIT initialseekpostype;

		[Token(Token = "0x4000323")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public int ignoresetfilesystem;

		[Token(Token = "0x4000324")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		public uint audioqueuepolicy;

		[Token(Token = "0x4000325")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public uint minmidigranularity;

		[Token(Token = "0x4000326")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		public int nonblockthreadid;

		[Token(Token = "0x4000327")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		public IntPtr fsbguid;
	}
	[Token(Token = "0x2000067")]
	public struct REVERB_PROPERTIES
	{
		[Token(Token = "0x4000328")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float DecayTime;

		[Token(Token = "0x4000329")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public float EarlyDelay;

		[Token(Token = "0x400032A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public float LateDelay;

		[Token(Token = "0x400032B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public float HFReference;

		[Token(Token = "0x400032C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float HFDecayRatio;

		[Token(Token = "0x400032D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public float Diffusion;

		[Token(Token = "0x400032E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float Density;

		[Token(Token = "0x400032F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float LowShelfFrequency;

		[Token(Token = "0x4000330")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float LowShelfGain;

		[Token(Token = "0x4000331")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float HighCut;

		[Token(Token = "0x4000332")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float EarlyLateMix;

		[Token(Token = "0x4000333")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float WetLevel;

		[Token(Token = "0x60001FB")]
		[Address(RVA = "0x9C7938", Offset = "0x9C7938", VA = "0x9C7938")]
		public REVERB_PROPERTIES(float decayTime, float earlyDelay, float lateDelay, float hfReference, float hfDecayRatio, float diffusion, float density, float lowShelfFrequency, float lowShelfGain, float highCut, float earlyLateMix, float wetLevel)
		{
		}
	}
	[Token(Token = "0x2000068")]
	public class PRESET
	{
		[Token(Token = "0x60001FC")]
		[Address(RVA = "0x1A48C28", Offset = "0x1A48C28", VA = "0x1A48C28")]
		public static REVERB_PROPERTIES OFF()
		{
			return default(REVERB_PROPERTIES);
		}

		[Token(Token = "0x60001FD")]
		[Address(RVA = "0x1A48C78", Offset = "0x1A48C78", VA = "0x1A48C78")]
		public static REVERB_PROPERTIES GENERIC()
		{
			return default(REVERB_PROPERTIES);
		}

		[Token(Token = "0x60001FE")]
		[Address(RVA = "0x1A48C9C", Offset = "0x1A48C9C", VA = "0x1A48C9C")]
		public static REVERB_PROPERTIES PADDEDCELL()
		{
			return default(REVERB_PROPERTIES);
		}

		[Token(Token = "0x60001FF")]
		[Address(RVA = "0x1A48CC0", Offset = "0x1A48CC0", VA = "0x1A48CC0")]
		public static REVERB_PROPERTIES ROOM()
		{
			return default(REVERB_PROPERTIES);
		}

		[Token(Token = "0x6000200")]
		[Address(RVA = "0x1A48CE4", Offset = "0x1A48CE4", VA = "0x1A48CE4")]
		public static REVERB_PROPERTIES BATHROOM()
		{
			return default(REVERB_PROPERTIES);
		}

		[Token(Token = "0x6000201")]
		[Address(RVA = "0x1A48D08", Offset = "0x1A48D08", VA = "0x1A48D08")]
		public static REVERB_PROPERTIES LIVINGROOM()
		{
			return default(REVERB_PROPERTIES);
		}

		[Token(Token = "0x6000202")]
		[Address(RVA = "0x1A48D2C", Offset = "0x1A48D2C", VA = "0x1A48D2C")]
		public static REVERB_PROPERTIES STONEROOM()
		{
			return default(REVERB_PROPERTIES);
		}

		[Token(Token = "0x6000203")]
		[Address(RVA = "0x1A48D50", Offset = "0x1A48D50", VA = "0x1A48D50")]
		public static REVERB_PROPERTIES AUDITORIUM()
		{
			return default(REVERB_PROPERTIES);
		}

		[Token(Token = "0x6000204")]
		[Address(RVA = "0x1A48D74", Offset = "0x1A48D74", VA = "0x1A48D74")]
		public static REVERB_PROPERTIES CONCERTHALL()
		{
			return default(REVERB_PROPERTIES);
		}

		[Token(Token = "0x6000205")]
		[Address(RVA = "0x1A48D98", Offset = "0x1A48D98", VA = "0x1A48D98")]
		public static REVERB_PROPERTIES CAVE()
		{
			return default(REVERB_PROPERTIES);
		}

		[Token(Token = "0x6000206")]
		[Address(RVA = "0x1A48DBC", Offset = "0x1A48DBC", VA = "0x1A48DBC")]
		public static REVERB_PROPERTIES ARENA()
		{
			return default(REVERB_PROPERTIES);
		}

		[Token(Token = "0x6000207")]
		[Address(RVA = "0x1A48DE0", Offset = "0x1A48DE0", VA = "0x1A48DE0")]
		public static REVERB_PROPERTIES HANGAR()
		{
			return default(REVERB_PROPERTIES);
		}

		[Token(Token = "0x6000208")]
		[Address(RVA = "0x1A48E04", Offset = "0x1A48E04", VA = "0x1A48E04")]
		public static REVERB_PROPERTIES CARPETTEDHALLWAY()
		{
			return default(REVERB_PROPERTIES);
		}

		[Token(Token = "0x6000209")]
		[Address(RVA = "0x1A48E28", Offset = "0x1A48E28", VA = "0x1A48E28")]
		public static REVERB_PROPERTIES HALLWAY()
		{
			return default(REVERB_PROPERTIES);
		}

		[Token(Token = "0x600020A")]
		[Address(RVA = "0x1A48E4C", Offset = "0x1A48E4C", VA = "0x1A48E4C")]
		public static REVERB_PROPERTIES STONECORRIDOR()
		{
			return default(REVERB_PROPERTIES);
		}

		[Token(Token = "0x600020B")]
		[Address(RVA = "0x1A48E70", Offset = "0x1A48E70", VA = "0x1A48E70")]
		public static REVERB_PROPERTIES ALLEY()
		{
			return default(REVERB_PROPERTIES);
		}

		[Token(Token = "0x600020C")]
		[Address(RVA = "0x1A48E94", Offset = "0x1A48E94", VA = "0x1A48E94")]
		public static REVERB_PROPERTIES FOREST()
		{
			return default(REVERB_PROPERTIES);
		}

		[Token(Token = "0x600020D")]
		[Address(RVA = "0x1A48EB8", Offset = "0x1A48EB8", VA = "0x1A48EB8")]
		public static REVERB_PROPERTIES CITY()
		{
			return default(REVERB_PROPERTIES);
		}

		[Token(Token = "0x600020E")]
		[Address(RVA = "0x1A48EDC", Offset = "0x1A48EDC", VA = "0x1A48EDC")]
		public static REVERB_PROPERTIES MOUNTAINS()
		{
			return default(REVERB_PROPERTIES);
		}

		[Token(Token = "0x600020F")]
		[Address(RVA = "0x1A48F00", Offset = "0x1A48F00", VA = "0x1A48F00")]
		public static REVERB_PROPERTIES QUARRY()
		{
			return default(REVERB_PROPERTIES);
		}

		[Token(Token = "0x6000210")]
		[Address(RVA = "0x1A48F24", Offset = "0x1A48F24", VA = "0x1A48F24")]
		public static REVERB_PROPERTIES PLAIN()
		{
			return default(REVERB_PROPERTIES);
		}

		[Token(Token = "0x6000211")]
		[Address(RVA = "0x1A48F48", Offset = "0x1A48F48", VA = "0x1A48F48")]
		public static REVERB_PROPERTIES PARKINGLOT()
		{
			return default(REVERB_PROPERTIES);
		}

		[Token(Token = "0x6000212")]
		[Address(RVA = "0x1A48F6C", Offset = "0x1A48F6C", VA = "0x1A48F6C")]
		public static REVERB_PROPERTIES SEWERPIPE()
		{
			return default(REVERB_PROPERTIES);
		}

		[Token(Token = "0x6000213")]
		[Address(RVA = "0x1A48F90", Offset = "0x1A48F90", VA = "0x1A48F90")]
		public static REVERB_PROPERTIES UNDERWATER()
		{
			return default(REVERB_PROPERTIES);
		}

		[Token(Token = "0x6000214")]
		[Address(RVA = "0x1A48FB4", Offset = "0x1A48FB4", VA = "0x1A48FB4")]
		public PRESET()
		{
		}
	}
	[Token(Token = "0x2000069")]
	public struct ADVANCEDSETTINGS
	{
		[Token(Token = "0x4000334")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int cbSize;

		[Token(Token = "0x4000335")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public int maxMPEGCodecs;

		[Token(Token = "0x4000336")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public int maxADPCMCodecs;

		[Token(Token = "0x4000337")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public int maxXMACodecs;

		[Token(Token = "0x4000338")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int maxVorbisCodecs;

		[Token(Token = "0x4000339")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public int maxAT9Codecs;

		[Token(Token = "0x400033A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int maxFADPCMCodecs;

		[Token(Token = "0x400033B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public int maxPCMCodecs;

		[Token(Token = "0x400033C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public int ASIONumChannels;

		[Token(Token = "0x400033D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public IntPtr ASIOChannelList;

		[Token(Token = "0x400033E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public IntPtr ASIOSpeakerList;

		[Token(Token = "0x400033F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float vol0virtualvol;

		[Token(Token = "0x4000340")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public uint defaultDecodeBufferSize;

		[Token(Token = "0x4000341")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public ushort profilePort;

		[Token(Token = "0x4000342")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public uint geometryMaxFadeTime;

		[Token(Token = "0x4000343")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float distanceFilterCenterFreq;

		[Token(Token = "0x4000344")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public int reverb3Dinstance;

		[Token(Token = "0x4000345")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public int DSPBufferPoolSize;

		[Token(Token = "0x4000346")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public uint stackSizeStream;

		[Token(Token = "0x4000347")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public uint stackSizeNonBlocking;

		[Token(Token = "0x4000348")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public uint stackSizeMixer;

		[Token(Token = "0x4000349")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public DSP_RESAMPLER resamplerMethod;

		[Token(Token = "0x400034A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public uint commandQueueSize;

		[Token(Token = "0x400034B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public uint randomSeed;
	}
	[Token(Token = "0x200006A")]
	[Flags]
	public enum DRIVER_STATE : uint
	{
		[Token(Token = "0x400034D")]
		CONNECTED = 1u,
		[Token(Token = "0x400034E")]
		DEFAULT = 2u
	}
	[Token(Token = "0x200006B")]
	public struct Factory
	{
		[Token(Token = "0x6000215")]
		[Address(RVA = "0x1A468D0", Offset = "0x1A468D0", VA = "0x1A468D0")]
		public static RESULT System_Create(out System system)
		{
			return default(RESULT);
		}

		[PreserveSig]
		[Token(Token = "0x6000216")]
		[Address(RVA = "0x1A468D4", Offset = "0x1A468D4", VA = "0x1A468D4")]
		private static extern RESULT FMOD5_System_Create(out IntPtr system);
	}
	[Token(Token = "0x200006C")]
	public struct Memory
	{
		[Token(Token = "0x6000217")]
		[Address(RVA = "0x1A48A6C", Offset = "0x1A48A6C", VA = "0x1A48A6C")]
		public static RESULT Initialize(IntPtr poolmem, int poollen, MEMORY_ALLOC_CALLBACK useralloc, MEMORY_REALLOC_CALLBACK userrealloc, MEMORY_FREE_CALLBACK userfree, MEMORY_TYPE memtypeflags = MEMORY_TYPE.ALL)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000218")]
		[Address(RVA = "0x1A48B6C", Offset = "0x1A48B6C", VA = "0x1A48B6C")]
		public static RESULT GetStats(out int currentalloced, out int maxalloced, bool blocking = true)
		{
			return default(RESULT);
		}

		[PreserveSig]
		[Token(Token = "0x6000219")]
		[Address(RVA = "0x1A48A70", Offset = "0x1A48A70", VA = "0x1A48A70")]
		private static extern RESULT FMOD5_Memory_Initialize(IntPtr poolmem, int poollen, MEMORY_ALLOC_CALLBACK useralloc, MEMORY_REALLOC_CALLBACK userrealloc, MEMORY_FREE_CALLBACK userfree, MEMORY_TYPE memtypeflags);

		[PreserveSig]
		[Token(Token = "0x600021A")]
		[Address(RVA = "0x1A48B74", Offset = "0x1A48B74", VA = "0x1A48B74")]
		private static extern RESULT FMOD5_Memory_GetStats(out int currentalloced, out int maxalloced, bool blocking);
	}
	[Token(Token = "0x200006D")]
	public struct Debug
	{
		[Token(Token = "0x600021B")]
		[Address(RVA = "0x1A439E4", Offset = "0x1A439E4", VA = "0x1A439E4")]
		public static RESULT Initialize(DEBUG_FLAGS flags, DEBUG_MODE mode = DEBUG_MODE.TTY, [Optional] DEBUG_CALLBACK callback, [Optional] string filename)
		{
			return default(RESULT);
		}

		[PreserveSig]
		[Token(Token = "0x600021C")]
		[Address(RVA = "0x1A43FA8", Offset = "0x1A43FA8", VA = "0x1A43FA8")]
		private static extern RESULT FMOD5_Debug_Initialize(DEBUG_FLAGS flags, DEBUG_MODE mode, DEBUG_CALLBACK callback, byte[] filename);
	}
	[Token(Token = "0x200006E")]
	public struct System
	{
		[Token(Token = "0x400034F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public IntPtr handle;

		[Token(Token = "0x600021D")]
		[Address(RVA = "0x9AF14C", Offset = "0x9AF14C", VA = "0x9AF14C")]
		public RESULT release()
		{
			return default(RESULT);
		}

		[Token(Token = "0x600021E")]
		[Address(RVA = "0x9AF154", Offset = "0x9AF154", VA = "0x9AF154")]
		public RESULT setOutput(OUTPUTTYPE output)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600021F")]
		[Address(RVA = "0x9AF15C", Offset = "0x9AF15C", VA = "0x9AF15C")]
		public RESULT getOutput(out OUTPUTTYPE output)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000220")]
		[Address(RVA = "0x9AF164", Offset = "0x9AF164", VA = "0x9AF164")]
		public RESULT getNumDrivers(out int numdrivers)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000221")]
		[Address(RVA = "0x9AF16C", Offset = "0x9AF16C", VA = "0x9AF16C")]
		public RESULT getDriverInfo(int id, out string name, int namelen, out Guid guid, out int systemrate, out SPEAKERMODE speakermode, out int speakermodechannels)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000222")]
		[Address(RVA = "0x9AF174", Offset = "0x9AF174", VA = "0x9AF174")]
		public RESULT getDriverInfo(int id, out Guid guid, out int systemrate, out SPEAKERMODE speakermode, out int speakermodechannels)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000223")]
		[Address(RVA = "0x9AF17C", Offset = "0x9AF17C", VA = "0x9AF17C")]
		public RESULT setDriver(int driver)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000224")]
		[Address(RVA = "0x9AF184", Offset = "0x9AF184", VA = "0x9AF184")]
		public RESULT getDriver(out int driver)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000225")]
		[Address(RVA = "0x9AF18C", Offset = "0x9AF18C", VA = "0x9AF18C")]
		public RESULT setSoftwareChannels(int numsoftwarechannels)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000226")]
		[Address(RVA = "0x9AF194", Offset = "0x9AF194", VA = "0x9AF194")]
		public RESULT getSoftwareChannels(out int numsoftwarechannels)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000227")]
		[Address(RVA = "0x9AF19C", Offset = "0x9AF19C", VA = "0x9AF19C")]
		public RESULT setSoftwareFormat(int samplerate, SPEAKERMODE speakermode, int numrawspeakers)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000228")]
		[Address(RVA = "0x9AF1A4", Offset = "0x9AF1A4", VA = "0x9AF1A4")]
		public RESULT getSoftwareFormat(out int samplerate, out SPEAKERMODE speakermode, out int numrawspeakers)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000229")]
		[Address(RVA = "0x9AF1AC", Offset = "0x9AF1AC", VA = "0x9AF1AC")]
		public RESULT setDSPBufferSize(uint bufferlength, int numbuffers)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600022A")]
		[Address(RVA = "0x9AF1B4", Offset = "0x9AF1B4", VA = "0x9AF1B4")]
		public RESULT getDSPBufferSize(out uint bufferlength, out int numbuffers)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600022B")]
		[Address(RVA = "0x9AF1BC", Offset = "0x9AF1BC", VA = "0x9AF1BC")]
		public RESULT setFileSystem(FILE_OPEN_CALLBACK useropen, FILE_CLOSE_CALLBACK userclose, FILE_READ_CALLBACK userread, FILE_SEEK_CALLBACK userseek, FILE_ASYNCREAD_CALLBACK userasyncread, FILE_ASYNCCANCEL_CALLBACK userasynccancel, int blockalign)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600022C")]
		[Address(RVA = "0x9AF1C4", Offset = "0x9AF1C4", VA = "0x9AF1C4")]
		public RESULT attachFileSystem(FILE_OPEN_CALLBACK useropen, FILE_CLOSE_CALLBACK userclose, FILE_READ_CALLBACK userread, FILE_SEEK_CALLBACK userseek)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600022D")]
		[Address(RVA = "0x9AF1CC", Offset = "0x9AF1CC", VA = "0x9AF1CC")]
		public RESULT setAdvancedSettings(ref ADVANCEDSETTINGS settings)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600022E")]
		[Address(RVA = "0x9AF1D4", Offset = "0x9AF1D4", VA = "0x9AF1D4")]
		public RESULT getAdvancedSettings(ref ADVANCEDSETTINGS settings)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600022F")]
		[Address(RVA = "0x9AF1DC", Offset = "0x9AF1DC", VA = "0x9AF1DC")]
		public RESULT setCallback(SYSTEM_CALLBACK callback, SYSTEM_CALLBACK_TYPE callbackmask = SYSTEM_CALLBACK_TYPE.ALL)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000230")]
		[Address(RVA = "0x9AF1E4", Offset = "0x9AF1E4", VA = "0x9AF1E4")]
		public RESULT setPluginPath(string path)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000231")]
		[Address(RVA = "0x9AF1EC", Offset = "0x9AF1EC", VA = "0x9AF1EC")]
		public RESULT loadPlugin(string filename, out uint handle, uint priority = 0u)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000232")]
		[Address(RVA = "0x9AF1F4", Offset = "0x9AF1F4", VA = "0x9AF1F4")]
		public RESULT unloadPlugin(uint handle)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000233")]
		[Address(RVA = "0x9AF1FC", Offset = "0x9AF1FC", VA = "0x9AF1FC")]
		public RESULT getNumNestedPlugins(uint handle, out int count)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000234")]
		[Address(RVA = "0x9AF204", Offset = "0x9AF204", VA = "0x9AF204")]
		public RESULT getNestedPlugin(uint handle, int index, out uint nestedhandle)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000235")]
		[Address(RVA = "0x9AF20C", Offset = "0x9AF20C", VA = "0x9AF20C")]
		public RESULT getNumPlugins(PLUGINTYPE plugintype, out int numplugins)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000236")]
		[Address(RVA = "0x9AF214", Offset = "0x9AF214", VA = "0x9AF214")]
		public RESULT getPluginHandle(PLUGINTYPE plugintype, int index, out uint handle)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000237")]
		[Address(RVA = "0x9AF21C", Offset = "0x9AF21C", VA = "0x9AF21C")]
		public RESULT getPluginInfo(uint handle, out PLUGINTYPE plugintype, out string name, int namelen, out uint version)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000238")]
		[Address(RVA = "0x9AF224", Offset = "0x9AF224", VA = "0x9AF224")]
		public RESULT getPluginInfo(uint handle, out PLUGINTYPE plugintype, out uint version)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000239")]
		[Address(RVA = "0x9AF22C", Offset = "0x9AF22C", VA = "0x9AF22C")]
		public RESULT setOutputByPlugin(uint handle)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600023A")]
		[Address(RVA = "0x9AF234", Offset = "0x9AF234", VA = "0x9AF234")]
		public RESULT getOutputByPlugin(out uint handle)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600023B")]
		[Address(RVA = "0x9AF23C", Offset = "0x9AF23C", VA = "0x9AF23C")]
		public RESULT createDSPByPlugin(uint handle, out DSP dsp)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600023C")]
		[Address(RVA = "0x9AF244", Offset = "0x9AF244", VA = "0x9AF244")]
		public RESULT getDSPInfoByPlugin(uint handle, out IntPtr description)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600023D")]
		[Address(RVA = "0x9AF24C", Offset = "0x9AF24C", VA = "0x9AF24C")]
		public RESULT registerDSP(ref DSP_DESCRIPTION description, out uint handle)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600023E")]
		[Address(RVA = "0x9AF254", Offset = "0x9AF254", VA = "0x9AF254")]
		public RESULT init(int maxchannels, INITFLAGS flags, IntPtr extradriverdata)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600023F")]
		[Address(RVA = "0x9AF25C", Offset = "0x9AF25C", VA = "0x9AF25C")]
		public RESULT close()
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000240")]
		[Address(RVA = "0x9AF264", Offset = "0x9AF264", VA = "0x9AF264")]
		public RESULT update()
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000241")]
		[Address(RVA = "0x9AF26C", Offset = "0x9AF26C", VA = "0x9AF26C")]
		public RESULT setSpeakerPosition(SPEAKER speaker, float x, float y, bool active)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000242")]
		[Address(RVA = "0x9AF278", Offset = "0x9AF278", VA = "0x9AF278")]
		public RESULT getSpeakerPosition(SPEAKER speaker, out float x, out float y, out bool active)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000243")]
		[Address(RVA = "0x9AF280", Offset = "0x9AF280", VA = "0x9AF280")]
		public RESULT setStreamBufferSize(uint filebuffersize, TIMEUNIT filebuffersizetype)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000244")]
		[Address(RVA = "0x9AF288", Offset = "0x9AF288", VA = "0x9AF288")]
		public RESULT getStreamBufferSize(out uint filebuffersize, out TIMEUNIT filebuffersizetype)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000245")]
		[Address(RVA = "0x9AF290", Offset = "0x9AF290", VA = "0x9AF290")]
		public RESULT set3DSettings(float dopplerscale, float distancefactor, float rolloffscale)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000246")]
		[Address(RVA = "0x9AF298", Offset = "0x9AF298", VA = "0x9AF298")]
		public RESULT get3DSettings(out float dopplerscale, out float distancefactor, out float rolloffscale)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000247")]
		[Address(RVA = "0x9AF2A0", Offset = "0x9AF2A0", VA = "0x9AF2A0")]
		public RESULT set3DNumListeners(int numlisteners)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000248")]
		[Address(RVA = "0x9AF2A8", Offset = "0x9AF2A8", VA = "0x9AF2A8")]
		public RESULT get3DNumListeners(out int numlisteners)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000249")]
		[Address(RVA = "0x9AF2B0", Offset = "0x9AF2B0", VA = "0x9AF2B0")]
		public RESULT set3DListenerAttributes(int listener, ref VECTOR pos, ref VECTOR vel, ref VECTOR forward, ref VECTOR up)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600024A")]
		[Address(RVA = "0x9AF2B8", Offset = "0x9AF2B8", VA = "0x9AF2B8")]
		public RESULT get3DListenerAttributes(int listener, out VECTOR pos, out VECTOR vel, out VECTOR forward, out VECTOR up)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600024B")]
		[Address(RVA = "0x9AF2C0", Offset = "0x9AF2C0", VA = "0x9AF2C0")]
		public RESULT set3DRolloffCallback(CB_3D_ROLLOFF_CALLBACK callback)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600024C")]
		[Address(RVA = "0x9AF2C8", Offset = "0x9AF2C8", VA = "0x9AF2C8")]
		public RESULT mixerSuspend()
		{
			return default(RESULT);
		}

		[Token(Token = "0x600024D")]
		[Address(RVA = "0x9AF2D0", Offset = "0x9AF2D0", VA = "0x9AF2D0")]
		public RESULT mixerResume()
		{
			return default(RESULT);
		}

		[Token(Token = "0x600024E")]
		[Address(RVA = "0x9AF2D8", Offset = "0x9AF2D8", VA = "0x9AF2D8")]
		public RESULT getDefaultMixMatrix(SPEAKERMODE sourcespeakermode, SPEAKERMODE targetspeakermode, float[] matrix, int matrixhop)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600024F")]
		[Address(RVA = "0x9AF2E0", Offset = "0x9AF2E0", VA = "0x9AF2E0")]
		public RESULT getSpeakerModeChannels(SPEAKERMODE mode, out int channels)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000250")]
		[Address(RVA = "0x9AF2E8", Offset = "0x9AF2E8", VA = "0x9AF2E8")]
		public RESULT getVersion(out uint version)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000251")]
		[Address(RVA = "0x9AF2F0", Offset = "0x9AF2F0", VA = "0x9AF2F0")]
		public RESULT getOutputHandle(out IntPtr handle)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000252")]
		[Address(RVA = "0x9AF2F8", Offset = "0x9AF2F8", VA = "0x9AF2F8")]
		public RESULT getChannelsPlaying(out int channels)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000253")]
		[Address(RVA = "0x9AF300", Offset = "0x9AF300", VA = "0x9AF300")]
		public RESULT getChannelsPlaying(out int channels, out int realchannels)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000254")]
		[Address(RVA = "0x9AF308", Offset = "0x9AF308", VA = "0x9AF308")]
		public RESULT getCPUUsage(out float dsp, out float stream, out float geometry, out float update, out float total)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000255")]
		[Address(RVA = "0x9AF310", Offset = "0x9AF310", VA = "0x9AF310")]
		public RESULT getFileUsage(out long sampleBytesRead, out long streamBytesRead, out long otherBytesRead)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000256")]
		[Address(RVA = "0x9AF318", Offset = "0x9AF318", VA = "0x9AF318")]
		public RESULT createSound(string name, MODE mode, ref CREATESOUNDEXINFO exinfo, out Sound sound)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000257")]
		[Address(RVA = "0x9AF320", Offset = "0x9AF320", VA = "0x9AF320")]
		public RESULT createSound(byte[] data, MODE mode, ref CREATESOUNDEXINFO exinfo, out Sound sound)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000258")]
		[Address(RVA = "0x9AF328", Offset = "0x9AF328", VA = "0x9AF328")]
		public RESULT createSound(IntPtr name_or_data, MODE mode, ref CREATESOUNDEXINFO exinfo, out Sound sound)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000259")]
		[Address(RVA = "0x9AF330", Offset = "0x9AF330", VA = "0x9AF330")]
		public RESULT createSound(string name, MODE mode, out Sound sound)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600025A")]
		[Address(RVA = "0x9AF338", Offset = "0x9AF338", VA = "0x9AF338")]
		public RESULT createStream(string name, MODE mode, ref CREATESOUNDEXINFO exinfo, out Sound sound)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600025B")]
		[Address(RVA = "0x9AF340", Offset = "0x9AF340", VA = "0x9AF340")]
		public RESULT createStream(byte[] data, MODE mode, ref CREATESOUNDEXINFO exinfo, out Sound sound)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600025C")]
		[Address(RVA = "0x9AF348", Offset = "0x9AF348", VA = "0x9AF348")]
		public RESULT createStream(IntPtr name_or_data, MODE mode, ref CREATESOUNDEXINFO exinfo, out Sound sound)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600025D")]
		[Address(RVA = "0x9AF350", Offset = "0x9AF350", VA = "0x9AF350")]
		public RESULT createStream(string name, MODE mode, out Sound sound)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600025E")]
		[Address(RVA = "0x9AF358", Offset = "0x9AF358", VA = "0x9AF358")]
		public RESULT createDSP(ref DSP_DESCRIPTION description, out DSP dsp)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600025F")]
		[Address(RVA = "0x9AF360", Offset = "0x9AF360", VA = "0x9AF360")]
		public RESULT createDSPByType(DSP_TYPE type, out DSP dsp)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000260")]
		[Address(RVA = "0x9AF368", Offset = "0x9AF368", VA = "0x9AF368")]
		public RESULT createChannelGroup(string name, out ChannelGroup channelgroup)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000261")]
		[Address(RVA = "0x9AF370", Offset = "0x9AF370", VA = "0x9AF370")]
		public RESULT createSoundGroup(string name, out SoundGroup soundgroup)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000262")]
		[Address(RVA = "0x9AF378", Offset = "0x9AF378", VA = "0x9AF378")]
		public RESULT createReverb3D(out Reverb3D reverb)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000263")]
		[Address(RVA = "0x9AF380", Offset = "0x9AF380", VA = "0x9AF380")]
		public RESULT playSound(Sound sound, ChannelGroup channelgroup, bool paused, out Channel channel)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000264")]
		[Address(RVA = "0x9AF38C", Offset = "0x9AF38C", VA = "0x9AF38C")]
		public RESULT playDSP(DSP dsp, ChannelGroup channelgroup, bool paused, out Channel channel)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000265")]
		[Address(RVA = "0x9AF398", Offset = "0x9AF398", VA = "0x9AF398")]
		public RESULT getChannel(int channelid, out Channel channel)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000266")]
		[Address(RVA = "0x9AF3A0", Offset = "0x9AF3A0", VA = "0x9AF3A0")]
		public RESULT getMasterChannelGroup(out ChannelGroup channelgroup)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000267")]
		[Address(RVA = "0x9AF3A8", Offset = "0x9AF3A8", VA = "0x9AF3A8")]
		public RESULT getMasterSoundGroup(out SoundGroup soundgroup)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000268")]
		[Address(RVA = "0x9AF3B0", Offset = "0x9AF3B0", VA = "0x9AF3B0")]
		public RESULT attachChannelGroupToPort(uint portType, ulong portIndex, ChannelGroup channelgroup, bool passThru = false)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000269")]
		[Address(RVA = "0x9AF3BC", Offset = "0x9AF3BC", VA = "0x9AF3BC")]
		public RESULT detachChannelGroupFromPort(ChannelGroup channelgroup)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600026A")]
		[Address(RVA = "0x9AF3C4", Offset = "0x9AF3C4", VA = "0x9AF3C4")]
		public RESULT setReverbProperties(int instance, ref REVERB_PROPERTIES prop)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600026B")]
		[Address(RVA = "0x9AF3CC", Offset = "0x9AF3CC", VA = "0x9AF3CC")]
		public RESULT getReverbProperties(int instance, out REVERB_PROPERTIES prop)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600026C")]
		[Address(RVA = "0x9AF3D4", Offset = "0x9AF3D4", VA = "0x9AF3D4")]
		public RESULT lockDSP()
		{
			return default(RESULT);
		}

		[Token(Token = "0x600026D")]
		[Address(RVA = "0x9AF3DC", Offset = "0x9AF3DC", VA = "0x9AF3DC")]
		public RESULT unlockDSP()
		{
			return default(RESULT);
		}

		[Token(Token = "0x600026E")]
		[Address(RVA = "0x9AF3E4", Offset = "0x9AF3E4", VA = "0x9AF3E4")]
		public RESULT getRecordNumDrivers(out int numdrivers, out int numconnected)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600026F")]
		[Address(RVA = "0x9AF3EC", Offset = "0x9AF3EC", VA = "0x9AF3EC")]
		public RESULT getRecordDriverInfo(int id, out string name, int namelen, out Guid guid, out int systemrate, out SPEAKERMODE speakermode, out int speakermodechannels, out DRIVER_STATE state)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000270")]
		[Address(RVA = "0x9AF3FC", Offset = "0x9AF3FC", VA = "0x9AF3FC")]
		public RESULT getRecordDriverInfo(int id, out Guid guid, out int systemrate, out SPEAKERMODE speakermode, out int speakermodechannels, out DRIVER_STATE state)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000271")]
		[Address(RVA = "0x9AF404", Offset = "0x9AF404", VA = "0x9AF404")]
		public RESULT getRecordPosition(int id, out uint position)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000272")]
		[Address(RVA = "0x9AF40C", Offset = "0x9AF40C", VA = "0x9AF40C")]
		public RESULT recordStart(int id, Sound sound, bool loop)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000273")]
		[Address(RVA = "0x9AF418", Offset = "0x9AF418", VA = "0x9AF418")]
		public RESULT recordStop(int id)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000274")]
		[Address(RVA = "0x9AF420", Offset = "0x9AF420", VA = "0x9AF420")]
		public RESULT isRecording(int id, out bool recording)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000275")]
		[Address(RVA = "0x9AF428", Offset = "0x9AF428", VA = "0x9AF428")]
		public RESULT createGeometry(int maxpolygons, int maxvertices, out Geometry geometry)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000276")]
		[Address(RVA = "0x9AF430", Offset = "0x9AF430", VA = "0x9AF430")]
		public RESULT setGeometrySettings(float maxworldsize)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000277")]
		[Address(RVA = "0x9AF438", Offset = "0x9AF438", VA = "0x9AF438")]
		public RESULT getGeometrySettings(out float maxworldsize)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000278")]
		[Address(RVA = "0x9AF440", Offset = "0x9AF440", VA = "0x9AF440")]
		public RESULT loadGeometry(IntPtr data, int datasize, out Geometry geometry)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000279")]
		[Address(RVA = "0x9AF448", Offset = "0x9AF448", VA = "0x9AF448")]
		public RESULT getGeometryOcclusion(ref VECTOR listener, ref VECTOR source, out float direct, out float reverb)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600027A")]
		[Address(RVA = "0x9AF450", Offset = "0x9AF450", VA = "0x9AF450")]
		public RESULT setNetworkProxy(string proxy)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600027B")]
		[Address(RVA = "0x9AF458", Offset = "0x9AF458", VA = "0x9AF458")]
		public RESULT getNetworkProxy(out string proxy, int proxylen)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600027C")]
		[Address(RVA = "0x9AF460", Offset = "0x9AF460", VA = "0x9AF460")]
		public RESULT setNetworkTimeout(int timeout)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600027D")]
		[Address(RVA = "0x9AF468", Offset = "0x9AF468", VA = "0x9AF468")]
		public RESULT getNetworkTimeout(out int timeout)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600027E")]
		[Address(RVA = "0x9AF470", Offset = "0x9AF470", VA = "0x9AF470")]
		public RESULT setUserData(IntPtr userdata)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600027F")]
		[Address(RVA = "0x9AF478", Offset = "0x9AF478", VA = "0x9AF478")]
		public RESULT getUserData(out IntPtr userdata)
		{
			return default(RESULT);
		}

		[PreserveSig]
		[Token(Token = "0x6000280")]
		[Address(RVA = "0x1026F34", Offset = "0x1026F34", VA = "0x1026F34")]
		private static extern RESULT FMOD5_System_Release(IntPtr system);

		[PreserveSig]
		[Token(Token = "0x6000281")]
		[Address(RVA = "0x1026FD8", Offset = "0x1026FD8", VA = "0x1026FD8")]
		private static extern RESULT FMOD5_System_SetOutput(IntPtr system, OUTPUTTYPE output);

		[PreserveSig]
		[Token(Token = "0x6000282")]
		[Address(RVA = "0x102708C", Offset = "0x102708C", VA = "0x102708C")]
		private static extern RESULT FMOD5_System_GetOutput(IntPtr system, out OUTPUTTYPE output);

		[PreserveSig]
		[Token(Token = "0x6000283")]
		[Address(RVA = "0x1027140", Offset = "0x1027140", VA = "0x1027140")]
		private static extern RESULT FMOD5_System_GetNumDrivers(IntPtr system, out int numdrivers);

		[PreserveSig]
		[Token(Token = "0x6000284")]
		[Address(RVA = "0x10273F4", Offset = "0x10273F4", VA = "0x10273F4")]
		private static extern RESULT FMOD5_System_GetDriverInfo(IntPtr system, int id, IntPtr name, int namelen, out Guid guid, out int systemrate, out SPEAKERMODE speakermode, out int speakermodechannels);

		[PreserveSig]
		[Token(Token = "0x6000285")]
		[Address(RVA = "0x1027588", Offset = "0x1027588", VA = "0x1027588")]
		private static extern RESULT FMOD5_System_SetDriver(IntPtr system, int driver);

		[PreserveSig]
		[Token(Token = "0x6000286")]
		[Address(RVA = "0x102763C", Offset = "0x102763C", VA = "0x102763C")]
		private static extern RESULT FMOD5_System_GetDriver(IntPtr system, out int driver);

		[PreserveSig]
		[Token(Token = "0x6000287")]
		[Address(RVA = "0x10276F0", Offset = "0x10276F0", VA = "0x10276F0")]
		private static extern RESULT FMOD5_System_SetSoftwareChannels(IntPtr system, int numsoftwarechannels);

		[PreserveSig]
		[Token(Token = "0x6000288")]
		[Address(RVA = "0x10277A4", Offset = "0x10277A4", VA = "0x10277A4")]
		private static extern RESULT FMOD5_System_GetSoftwareChannels(IntPtr system, out int numsoftwarechannels);

		[PreserveSig]
		[Token(Token = "0x6000289")]
		[Address(RVA = "0x1027858", Offset = "0x1027858", VA = "0x1027858")]
		private static extern RESULT FMOD5_System_SetSoftwareFormat(IntPtr system, int samplerate, SPEAKERMODE speakermode, int numrawspeakers);

		[PreserveSig]
		[Token(Token = "0x600028A")]
		[Address(RVA = "0x1027924", Offset = "0x1027924", VA = "0x1027924")]
		private static extern RESULT FMOD5_System_GetSoftwareFormat(IntPtr system, out int samplerate, out SPEAKERMODE speakermode, out int numrawspeakers);

		[PreserveSig]
		[Token(Token = "0x600028B")]
		[Address(RVA = "0x10279F0", Offset = "0x10279F0", VA = "0x10279F0")]
		private static extern RESULT FMOD5_System_SetDSPBufferSize(IntPtr system, uint bufferlength, int numbuffers);

		[PreserveSig]
		[Token(Token = "0x600028C")]
		[Address(RVA = "0x1027AAC", Offset = "0x1027AAC", VA = "0x1027AAC")]
		private static extern RESULT FMOD5_System_GetDSPBufferSize(IntPtr system, out uint bufferlength, out int numbuffers);

		[PreserveSig]
		[Token(Token = "0x600028D")]
		[Address(RVA = "0x1027B68", Offset = "0x1027B68", VA = "0x1027B68")]
		private static extern RESULT FMOD5_System_SetFileSystem(IntPtr system, FILE_OPEN_CALLBACK useropen, FILE_CLOSE_CALLBACK userclose, FILE_READ_CALLBACK userread, FILE_SEEK_CALLBACK userseek, FILE_ASYNCREAD_CALLBACK userasyncread, FILE_ASYNCCANCEL_CALLBACK userasynccancel, int blockalign);

		[PreserveSig]
		[Token(Token = "0x600028E")]
		[Address(RVA = "0x1027CA8", Offset = "0x1027CA8", VA = "0x1027CA8")]
		private static extern RESULT FMOD5_System_AttachFileSystem(IntPtr system, FILE_OPEN_CALLBACK useropen, FILE_CLOSE_CALLBACK userclose, FILE_READ_CALLBACK userread, FILE_SEEK_CALLBACK userseek);

		[PreserveSig]
		[Token(Token = "0x600028F")]
		[Address(RVA = "0x1027E5C", Offset = "0x1027E5C", VA = "0x1027E5C")]
		private static extern RESULT FMOD5_System_SetAdvancedSettings(IntPtr system, ref ADVANCEDSETTINGS settings);

		[PreserveSig]
		[Token(Token = "0x6000290")]
		[Address(RVA = "0x1027FC4", Offset = "0x1027FC4", VA = "0x1027FC4")]
		private static extern RESULT FMOD5_System_GetAdvancedSettings(IntPtr system, ref ADVANCEDSETTINGS settings);

		[PreserveSig]
		[Token(Token = "0x6000291")]
		[Address(RVA = "0x1028078", Offset = "0x1028078", VA = "0x1028078")]
		private static extern RESULT FMOD5_System_SetCallback(IntPtr system, SYSTEM_CALLBACK callback, SYSTEM_CALLBACK_TYPE callbackmask);

		[PreserveSig]
		[Token(Token = "0x6000292")]
		[Address(RVA = "0x1028298", Offset = "0x1028298", VA = "0x1028298")]
		private static extern RESULT FMOD5_System_SetPluginPath(IntPtr system, byte[] path);

		[PreserveSig]
		[Token(Token = "0x6000293")]
		[Address(RVA = "0x10284C8", Offset = "0x10284C8", VA = "0x10284C8")]
		private static extern RESULT FMOD5_System_LoadPlugin(IntPtr system, byte[] filename, out uint handle, uint priority);

		[PreserveSig]
		[Token(Token = "0x6000294")]
		[Address(RVA = "0x102859C", Offset = "0x102859C", VA = "0x102859C")]
		private static extern RESULT FMOD5_System_UnloadPlugin(IntPtr system, uint handle);

		[PreserveSig]
		[Token(Token = "0x6000295")]
		[Address(RVA = "0x1028650", Offset = "0x1028650", VA = "0x1028650")]
		private static extern RESULT FMOD5_System_GetNumNestedPlugins(IntPtr system, uint handle, out int count);

		[PreserveSig]
		[Token(Token = "0x6000296")]
		[Address(RVA = "0x102870C", Offset = "0x102870C", VA = "0x102870C")]
		private static extern RESULT FMOD5_System_GetNestedPlugin(IntPtr system, uint handle, int index, out uint nestedhandle);

		[PreserveSig]
		[Token(Token = "0x6000297")]
		[Address(RVA = "0x10287D8", Offset = "0x10287D8", VA = "0x10287D8")]
		private static extern RESULT FMOD5_System_GetNumPlugins(IntPtr system, PLUGINTYPE plugintype, out int numplugins);

		[PreserveSig]
		[Token(Token = "0x6000298")]
		[Address(RVA = "0x1028894", Offset = "0x1028894", VA = "0x1028894")]
		private static extern RESULT FMOD5_System_GetPluginHandle(IntPtr system, PLUGINTYPE plugintype, int index, out uint handle);

		[PreserveSig]
		[Token(Token = "0x6000299")]
		[Address(RVA = "0x1028B40", Offset = "0x1028B40", VA = "0x1028B40")]
		private static extern RESULT FMOD5_System_GetPluginInfo(IntPtr system, uint handle, out PLUGINTYPE plugintype, IntPtr name, int namelen, out uint version);

		[PreserveSig]
		[Token(Token = "0x600029A")]
		[Address(RVA = "0x1028C98", Offset = "0x1028C98", VA = "0x1028C98")]
		private static extern RESULT FMOD5_System_SetOutputByPlugin(IntPtr system, uint handle);

		[PreserveSig]
		[Token(Token = "0x600029B")]
		[Address(RVA = "0x1028D4C", Offset = "0x1028D4C", VA = "0x1028D4C")]
		private static extern RESULT FMOD5_System_GetOutputByPlugin(IntPtr system, out uint handle);

		[PreserveSig]
		[Token(Token = "0x600029C")]
		[Address(RVA = "0x1028E00", Offset = "0x1028E00", VA = "0x1028E00")]
		private static extern RESULT FMOD5_System_CreateDSPByPlugin(IntPtr system, uint handle, out IntPtr dsp);

		[PreserveSig]
		[Token(Token = "0x600029D")]
		[Address(RVA = "0x1028EBC", Offset = "0x1028EBC", VA = "0x1028EBC")]
		private static extern RESULT FMOD5_System_GetDSPInfoByPlugin(IntPtr system, uint handle, out IntPtr description);

		[PreserveSig]
		[Token(Token = "0x600029E")]
		[Address(RVA = "0x1028F78", Offset = "0x1028F78", VA = "0x1028F78")]
		private static extern RESULT FMOD5_System_RegisterDSP(IntPtr system, ref DSP_DESCRIPTION description, out uint handle);

		[PreserveSig]
		[Token(Token = "0x600029F")]
		[Address(RVA = "0x1029090", Offset = "0x1029090", VA = "0x1029090")]
		private static extern RESULT FMOD5_System_Init(IntPtr system, int maxchannels, INITFLAGS flags, IntPtr extradriverdata);

		[PreserveSig]
		[Token(Token = "0x60002A0")]
		[Address(RVA = "0x102915C", Offset = "0x102915C", VA = "0x102915C")]
		private static extern RESULT FMOD5_System_Close(IntPtr system);

		[PreserveSig]
		[Token(Token = "0x60002A1")]
		[Address(RVA = "0x1029200", Offset = "0x1029200", VA = "0x1029200")]
		private static extern RESULT FMOD5_System_Update(IntPtr system);

		[PreserveSig]
		[Token(Token = "0x60002A2")]
		[Address(RVA = "0x10292A8", Offset = "0x10292A8", VA = "0x10292A8")]
		private static extern RESULT FMOD5_System_SetSpeakerPosition(IntPtr system, SPEAKER speaker, float x, float y, bool active);

		[PreserveSig]
		[Token(Token = "0x60002A3")]
		[Address(RVA = "0x102937C", Offset = "0x102937C", VA = "0x102937C")]
		private static extern RESULT FMOD5_System_GetSpeakerPosition(IntPtr system, SPEAKER speaker, out float x, out float y, out bool active);

		[PreserveSig]
		[Token(Token = "0x60002A4")]
		[Address(RVA = "0x1029464", Offset = "0x1029464", VA = "0x1029464")]
		private static extern RESULT FMOD5_System_SetStreamBufferSize(IntPtr system, uint filebuffersize, TIMEUNIT filebuffersizetype);

		[PreserveSig]
		[Token(Token = "0x60002A5")]
		[Address(RVA = "0x1029520", Offset = "0x1029520", VA = "0x1029520")]
		private static extern RESULT FMOD5_System_GetStreamBufferSize(IntPtr system, out uint filebuffersize, out TIMEUNIT filebuffersizetype);

		[PreserveSig]
		[Token(Token = "0x60002A6")]
		[Address(RVA = "0x10295DC", Offset = "0x10295DC", VA = "0x10295DC")]
		private static extern RESULT FMOD5_System_Set3DSettings(IntPtr system, float dopplerscale, float distancefactor, float rolloffscale);

		[PreserveSig]
		[Token(Token = "0x60002A7")]
		[Address(RVA = "0x10296A8", Offset = "0x10296A8", VA = "0x10296A8")]
		private static extern RESULT FMOD5_System_Get3DSettings(IntPtr system, out float dopplerscale, out float distancefactor, out float rolloffscale);

		[PreserveSig]
		[Token(Token = "0x60002A8")]
		[Address(RVA = "0x1029774", Offset = "0x1029774", VA = "0x1029774")]
		private static extern RESULT FMOD5_System_Set3DNumListeners(IntPtr system, int numlisteners);

		[PreserveSig]
		[Token(Token = "0x60002A9")]
		[Address(RVA = "0x1029828", Offset = "0x1029828", VA = "0x1029828")]
		private static extern RESULT FMOD5_System_Get3DNumListeners(IntPtr system, out int numlisteners);

		[PreserveSig]
		[Token(Token = "0x60002AA")]
		[Address(RVA = "0x10298DC", Offset = "0x10298DC", VA = "0x10298DC")]
		private static extern RESULT FMOD5_System_Set3DListenerAttributes(IntPtr system, int listener, ref VECTOR pos, ref VECTOR vel, ref VECTOR forward, ref VECTOR up);

		[PreserveSig]
		[Token(Token = "0x60002AB")]
		[Address(RVA = "0x10299C0", Offset = "0x10299C0", VA = "0x10299C0")]
		private static extern RESULT FMOD5_System_Get3DListenerAttributes(IntPtr system, int listener, out VECTOR pos, out VECTOR vel, out VECTOR forward, out VECTOR up);

		[PreserveSig]
		[Token(Token = "0x60002AC")]
		[Address(RVA = "0x1029AA4", Offset = "0x1029AA4", VA = "0x1029AA4")]
		private static extern RESULT FMOD5_System_Set3DRolloffCallback(IntPtr system, CB_3D_ROLLOFF_CALLBACK callback);

		[PreserveSig]
		[Token(Token = "0x60002AD")]
		[Address(RVA = "0x1029B60", Offset = "0x1029B60", VA = "0x1029B60")]
		private static extern RESULT FMOD5_System_MixerSuspend(IntPtr system);

		[PreserveSig]
		[Token(Token = "0x60002AE")]
		[Address(RVA = "0x1029C04", Offset = "0x1029C04", VA = "0x1029C04")]
		private static extern RESULT FMOD5_System_MixerResume(IntPtr system);

		[PreserveSig]
		[Token(Token = "0x60002AF")]
		[Address(RVA = "0x1029CA8", Offset = "0x1029CA8", VA = "0x1029CA8")]
		private static extern RESULT FMOD5_System_GetDefaultMixMatrix(IntPtr system, SPEAKERMODE sourcespeakermode, SPEAKERMODE targetspeakermode, float[] matrix, int matrixhop);

		[PreserveSig]
		[Token(Token = "0x60002B0")]
		[Address(RVA = "0x1029D84", Offset = "0x1029D84", VA = "0x1029D84")]
		private static extern RESULT FMOD5_System_GetSpeakerModeChannels(IntPtr system, SPEAKERMODE mode, out int channels);

		[PreserveSig]
		[Token(Token = "0x60002B1")]
		[Address(RVA = "0x1029E40", Offset = "0x1029E40", VA = "0x1029E40")]
		private static extern RESULT FMOD5_System_GetVersion(IntPtr system, out uint version);

		[PreserveSig]
		[Token(Token = "0x60002B2")]
		[Address(RVA = "0x1029EF4", Offset = "0x1029EF4", VA = "0x1029EF4")]
		private static extern RESULT FMOD5_System_GetOutputHandle(IntPtr system, out IntPtr handle);

		[PreserveSig]
		[Token(Token = "0x60002B3")]
		[Address(RVA = "0x1029FF8", Offset = "0x1029FF8", VA = "0x1029FF8")]
		private static extern RESULT FMOD5_System_GetChannelsPlaying(IntPtr system, out int channels, IntPtr zero);

		[PreserveSig]
		[Token(Token = "0x60002B4")]
		[Address(RVA = "0x102A0B4", Offset = "0x102A0B4", VA = "0x102A0B4")]
		private static extern RESULT FMOD5_System_GetChannelsPlaying(IntPtr system, out int channels, out int realchannels);

		[PreserveSig]
		[Token(Token = "0x60002B5")]
		[Address(RVA = "0x102A170", Offset = "0x102A170", VA = "0x102A170")]
		private static extern RESULT FMOD5_System_GetCPUUsage(IntPtr system, out float dsp, out float stream, out float geometry, out float update, out float total);

		[PreserveSig]
		[Token(Token = "0x60002B6")]
		[Address(RVA = "0x102A254", Offset = "0x102A254", VA = "0x102A254")]
		private static extern RESULT FMOD5_System_GetFileUsage(IntPtr system, out long sampleBytesRead, out long streamBytesRead, out long otherBytesRead);

		[PreserveSig]
		[Token(Token = "0x60002B7")]
		[Address(RVA = "0x102A49C", Offset = "0x102A49C", VA = "0x102A49C")]
		private static extern RESULT FMOD5_System_CreateSound(IntPtr system, byte[] name_or_data, MODE mode, ref CREATESOUNDEXINFO exinfo, out IntPtr sound);

		[PreserveSig]
		[Token(Token = "0x60002B8")]
		[Address(RVA = "0x102A5E4", Offset = "0x102A5E4", VA = "0x102A5E4")]
		private static extern RESULT FMOD5_System_CreateSound(IntPtr system, IntPtr name_or_data, MODE mode, ref CREATESOUNDEXINFO exinfo, out IntPtr sound);

		[PreserveSig]
		[Token(Token = "0x60002B9")]
		[Address(RVA = "0x102A97C", Offset = "0x102A97C", VA = "0x102A97C")]
		private static extern RESULT FMOD5_System_CreateStream(IntPtr system, byte[] name_or_data, MODE mode, ref CREATESOUNDEXINFO exinfo, out IntPtr sound);

		[PreserveSig]
		[Token(Token = "0x60002BA")]
		[Address(RVA = "0x102AAC4", Offset = "0x102AAC4", VA = "0x102AAC4")]
		private static extern RESULT FMOD5_System_CreateStream(IntPtr system, IntPtr name_or_data, MODE mode, ref CREATESOUNDEXINFO exinfo, out IntPtr sound);

		[PreserveSig]
		[Token(Token = "0x60002BB")]
		[Address(RVA = "0x102ACE0", Offset = "0x102ACE0", VA = "0x102ACE0")]
		private static extern RESULT FMOD5_System_CreateDSP(IntPtr system, ref DSP_DESCRIPTION description, out IntPtr dsp);

		[PreserveSig]
		[Token(Token = "0x60002BC")]
		[Address(RVA = "0x102ADFC", Offset = "0x102ADFC", VA = "0x102ADFC")]
		private static extern RESULT FMOD5_System_CreateDSPByType(IntPtr system, DSP_TYPE type, out IntPtr dsp);

		[PreserveSig]
		[Token(Token = "0x60002BD")]
		[Address(RVA = "0x102B01C", Offset = "0x102B01C", VA = "0x102B01C")]
		private static extern RESULT FMOD5_System_CreateChannelGroup(IntPtr system, byte[] name, out IntPtr channelgroup);

		[PreserveSig]
		[Token(Token = "0x60002BE")]
		[Address(RVA = "0x102B244", Offset = "0x102B244", VA = "0x102B244")]
		private static extern RESULT FMOD5_System_CreateSoundGroup(IntPtr system, byte[] name, out IntPtr soundgroup);

		[PreserveSig]
		[Token(Token = "0x60002BF")]
		[Address(RVA = "0x102B308", Offset = "0x102B308", VA = "0x102B308")]
		private static extern RESULT FMOD5_System_CreateReverb3D(IntPtr system, out IntPtr reverb);

		[PreserveSig]
		[Token(Token = "0x60002C0")]
		[Address(RVA = "0x102B3C0", Offset = "0x102B3C0", VA = "0x102B3C0")]
		private static extern RESULT FMOD5_System_PlaySound(IntPtr system, IntPtr sound, IntPtr channelgroup, bool paused, out IntPtr channel);

		[PreserveSig]
		[Token(Token = "0x60002C1")]
		[Address(RVA = "0x102B498", Offset = "0x102B498", VA = "0x102B498")]
		private static extern RESULT FMOD5_System_PlayDSP(IntPtr system, IntPtr dsp, IntPtr channelgroup, bool paused, out IntPtr channel);

		[PreserveSig]
		[Token(Token = "0x60002C2")]
		[Address(RVA = "0x102B56C", Offset = "0x102B56C", VA = "0x102B56C")]
		private static extern RESULT FMOD5_System_GetChannel(IntPtr system, int channelid, out IntPtr channel);

		[PreserveSig]
		[Token(Token = "0x60002C3")]
		[Address(RVA = "0x102B628", Offset = "0x102B628", VA = "0x102B628")]
		private static extern RESULT FMOD5_System_GetMasterChannelGroup(IntPtr system, out IntPtr channelgroup);

		[PreserveSig]
		[Token(Token = "0x60002C4")]
		[Address(RVA = "0x102B6DC", Offset = "0x102B6DC", VA = "0x102B6DC")]
		private static extern RESULT FMOD5_System_GetMasterSoundGroup(IntPtr system, out IntPtr soundgroup);

		[PreserveSig]
		[Token(Token = "0x60002C5")]
		[Address(RVA = "0x102B794", Offset = "0x102B794", VA = "0x102B794")]
		private static extern RESULT FMOD5_System_AttachChannelGroupToPort(IntPtr system, uint portType, ulong portIndex, IntPtr channelgroup, bool passThru);

		[PreserveSig]
		[Token(Token = "0x60002C6")]
		[Address(RVA = "0x102B868", Offset = "0x102B868", VA = "0x102B868")]
		private static extern RESULT FMOD5_System_DetachChannelGroupFromPort(IntPtr system, IntPtr channelgroup);

		[PreserveSig]
		[Token(Token = "0x60002C7")]
		[Address(RVA = "0x102B91C", Offset = "0x102B91C", VA = "0x102B91C")]
		private static extern RESULT FMOD5_System_SetReverbProperties(IntPtr system, int instance, ref REVERB_PROPERTIES prop);

		[PreserveSig]
		[Token(Token = "0x60002C8")]
		[Address(RVA = "0x102B9D8", Offset = "0x102B9D8", VA = "0x102B9D8")]
		private static extern RESULT FMOD5_System_GetReverbProperties(IntPtr system, int instance, out REVERB_PROPERTIES prop);

		[PreserveSig]
		[Token(Token = "0x60002C9")]
		[Address(RVA = "0x102BA94", Offset = "0x102BA94", VA = "0x102BA94")]
		private static extern RESULT FMOD5_System_LockDSP(IntPtr system);

		[PreserveSig]
		[Token(Token = "0x60002CA")]
		[Address(RVA = "0x102BB38", Offset = "0x102BB38", VA = "0x102BB38")]
		private static extern RESULT FMOD5_System_UnlockDSP(IntPtr system);

		[PreserveSig]
		[Token(Token = "0x60002CB")]
		[Address(RVA = "0x102BBDC", Offset = "0x102BBDC", VA = "0x102BBDC")]
		private static extern RESULT FMOD5_System_GetRecordNumDrivers(IntPtr system, out int numdrivers, out int numconnected);

		[PreserveSig]
		[Token(Token = "0x60002CC")]
		[Address(RVA = "0x102BEA0", Offset = "0x102BEA0", VA = "0x102BEA0")]
		private static extern RESULT FMOD5_System_GetRecordDriverInfo(IntPtr system, int id, IntPtr name, int namelen, out Guid guid, out int systemrate, out SPEAKERMODE speakermode, out int speakermodechannels, out DRIVER_STATE state);

		[PreserveSig]
		[Token(Token = "0x60002CD")]
		[Address(RVA = "0x102C044", Offset = "0x102C044", VA = "0x102C044")]
		private static extern RESULT FMOD5_System_GetRecordPosition(IntPtr system, int id, out uint position);

		[PreserveSig]
		[Token(Token = "0x60002CE")]
		[Address(RVA = "0x102C104", Offset = "0x102C104", VA = "0x102C104")]
		private static extern RESULT FMOD5_System_RecordStart(IntPtr system, int id, IntPtr sound, bool loop);

		[PreserveSig]
		[Token(Token = "0x60002CF")]
		[Address(RVA = "0x102C1CC", Offset = "0x102C1CC", VA = "0x102C1CC")]
		private static extern RESULT FMOD5_System_RecordStop(IntPtr system, int id);

		[PreserveSig]
		[Token(Token = "0x60002D0")]
		[Address(RVA = "0x102C280", Offset = "0x102C280", VA = "0x102C280")]
		private static extern RESULT FMOD5_System_IsRecording(IntPtr system, int id, out bool recording);

		[PreserveSig]
		[Token(Token = "0x60002D1")]
		[Address(RVA = "0x102C350", Offset = "0x102C350", VA = "0x102C350")]
		private static extern RESULT FMOD5_System_CreateGeometry(IntPtr system, int maxpolygons, int maxvertices, out IntPtr geometry);

		[PreserveSig]
		[Token(Token = "0x60002D2")]
		[Address(RVA = "0x102C41C", Offset = "0x102C41C", VA = "0x102C41C")]
		private static extern RESULT FMOD5_System_SetGeometrySettings(IntPtr system, float maxworldsize);

		[PreserveSig]
		[Token(Token = "0x60002D3")]
		[Address(RVA = "0x102C4D0", Offset = "0x102C4D0", VA = "0x102C4D0")]
		private static extern RESULT FMOD5_System_GetGeometrySettings(IntPtr system, out float maxworldsize);

		[PreserveSig]
		[Token(Token = "0x60002D4")]
		[Address(RVA = "0x102C584", Offset = "0x102C584", VA = "0x102C584")]
		private static extern RESULT FMOD5_System_LoadGeometry(IntPtr system, IntPtr data, int datasize, out IntPtr geometry);

		[PreserveSig]
		[Token(Token = "0x60002D5")]
		[Address(RVA = "0x102C650", Offset = "0x102C650", VA = "0x102C650")]
		private static extern RESULT FMOD5_System_GetGeometryOcclusion(IntPtr system, ref VECTOR listener, ref VECTOR source, out float direct, out float reverb);

		[PreserveSig]
		[Token(Token = "0x60002D6")]
		[Address(RVA = "0x102C880", Offset = "0x102C880", VA = "0x102C880")]
		private static extern RESULT FMOD5_System_SetNetworkProxy(IntPtr system, byte[] proxy);

		[PreserveSig]
		[Token(Token = "0x60002D7")]
		[Address(RVA = "0x102CB04", Offset = "0x102CB04", VA = "0x102CB04")]
		private static extern RESULT FMOD5_System_GetNetworkProxy(IntPtr system, IntPtr proxy, int proxylen);

		[PreserveSig]
		[Token(Token = "0x60002D8")]
		[Address(RVA = "0x102CBC0", Offset = "0x102CBC0", VA = "0x102CBC0")]
		private static extern RESULT FMOD5_System_SetNetworkTimeout(IntPtr system, int timeout);

		[PreserveSig]
		[Token(Token = "0x60002D9")]
		[Address(RVA = "0x102CC74", Offset = "0x102CC74", VA = "0x102CC74")]
		private static extern RESULT FMOD5_System_GetNetworkTimeout(IntPtr system, out int timeout);

		[PreserveSig]
		[Token(Token = "0x60002DA")]
		[Address(RVA = "0x102CD28", Offset = "0x102CD28", VA = "0x102CD28")]
		private static extern RESULT FMOD5_System_SetUserData(IntPtr system, IntPtr userdata);

		[PreserveSig]
		[Token(Token = "0x60002DB")]
		[Address(RVA = "0x102CDDC", Offset = "0x102CDDC", VA = "0x102CDDC")]
		private static extern RESULT FMOD5_System_GetUserData(IntPtr system, out IntPtr userdata);

		[Token(Token = "0x60002DC")]
		[Address(RVA = "0x9AF480", Offset = "0x9AF480", VA = "0x9AF480")]
		public bool hasHandle()
		{
			return default(bool);
		}

		[Token(Token = "0x60002DD")]
		[Address(RVA = "0x9AF488", Offset = "0x9AF488", VA = "0x9AF488")]
		public void clearHandle()
		{
		}
	}
	[Token(Token = "0x200006F")]
	public struct Sound
	{
		[Token(Token = "0x4000350")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public IntPtr handle;

		[Token(Token = "0x60002DE")]
		[Address(RVA = "0x9C7A64", Offset = "0x9C7A64", VA = "0x9C7A64")]
		public RESULT release()
		{
			return default(RESULT);
		}

		[Token(Token = "0x60002DF")]
		[Address(RVA = "0x9C7A6C", Offset = "0x9C7A6C", VA = "0x9C7A6C")]
		public RESULT getSystemObject(out System system)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60002E0")]
		[Address(RVA = "0x9C7A74", Offset = "0x9C7A74", VA = "0x9C7A74")]
		public RESULT @lock(uint offset, uint length, out IntPtr ptr1, out IntPtr ptr2, out uint len1, out uint len2)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60002E1")]
		[Address(RVA = "0x9C7A7C", Offset = "0x9C7A7C", VA = "0x9C7A7C")]
		public RESULT unlock(IntPtr ptr1, IntPtr ptr2, uint len1, uint len2)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60002E2")]
		[Address(RVA = "0x9C7A84", Offset = "0x9C7A84", VA = "0x9C7A84")]
		public RESULT setDefaults(float frequency, int priority)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60002E3")]
		[Address(RVA = "0x9C7A8C", Offset = "0x9C7A8C", VA = "0x9C7A8C")]
		public RESULT getDefaults(out float frequency, out int priority)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60002E4")]
		[Address(RVA = "0x9C7A94", Offset = "0x9C7A94", VA = "0x9C7A94")]
		public RESULT set3DMinMaxDistance(float min, float max)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60002E5")]
		[Address(RVA = "0x9C7A9C", Offset = "0x9C7A9C", VA = "0x9C7A9C")]
		public RESULT get3DMinMaxDistance(out float min, out float max)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60002E6")]
		[Address(RVA = "0x9C7AA4", Offset = "0x9C7AA4", VA = "0x9C7AA4")]
		public RESULT set3DConeSettings(float insideconeangle, float outsideconeangle, float outsidevolume)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60002E7")]
		[Address(RVA = "0x9C7AAC", Offset = "0x9C7AAC", VA = "0x9C7AAC")]
		public RESULT get3DConeSettings(out float insideconeangle, out float outsideconeangle, out float outsidevolume)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60002E8")]
		[Address(RVA = "0x9C7AB4", Offset = "0x9C7AB4", VA = "0x9C7AB4")]
		public RESULT set3DCustomRolloff(ref VECTOR points, int numpoints)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60002E9")]
		[Address(RVA = "0x9C7ABC", Offset = "0x9C7ABC", VA = "0x9C7ABC")]
		public RESULT get3DCustomRolloff(out IntPtr points, out int numpoints)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60002EA")]
		[Address(RVA = "0x9C7AC4", Offset = "0x9C7AC4", VA = "0x9C7AC4")]
		public RESULT getSubSound(int index, out Sound subsound)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60002EB")]
		[Address(RVA = "0x9C7ACC", Offset = "0x9C7ACC", VA = "0x9C7ACC")]
		public RESULT getSubSoundParent(out Sound parentsound)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60002EC")]
		[Address(RVA = "0x9C7AD4", Offset = "0x9C7AD4", VA = "0x9C7AD4")]
		public RESULT getName(out string name, int namelen)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60002ED")]
		[Address(RVA = "0x9C7ADC", Offset = "0x9C7ADC", VA = "0x9C7ADC")]
		public RESULT getLength(out uint length, TIMEUNIT lengthtype)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60002EE")]
		[Address(RVA = "0x9C7AE4", Offset = "0x9C7AE4", VA = "0x9C7AE4")]
		public RESULT getFormat(out SOUND_TYPE type, out SOUND_FORMAT format, out int channels, out int bits)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60002EF")]
		[Address(RVA = "0x9C7AEC", Offset = "0x9C7AEC", VA = "0x9C7AEC")]
		public RESULT getNumSubSounds(out int numsubsounds)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60002F0")]
		[Address(RVA = "0x9C7AF4", Offset = "0x9C7AF4", VA = "0x9C7AF4")]
		public RESULT getNumTags(out int numtags, out int numtagsupdated)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60002F1")]
		[Address(RVA = "0x9C7AFC", Offset = "0x9C7AFC", VA = "0x9C7AFC")]
		public RESULT getTag(string name, int index, out TAG tag)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60002F2")]
		[Address(RVA = "0x9C7B04", Offset = "0x9C7B04", VA = "0x9C7B04")]
		public RESULT getOpenState(out OPENSTATE openstate, out uint percentbuffered, out bool starving, out bool diskbusy)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60002F3")]
		[Address(RVA = "0x9C7B0C", Offset = "0x9C7B0C", VA = "0x9C7B0C")]
		public RESULT readData(IntPtr buffer, uint length, out uint read)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60002F4")]
		[Address(RVA = "0x9C7B14", Offset = "0x9C7B14", VA = "0x9C7B14")]
		public RESULT seekData(uint pcm)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60002F5")]
		[Address(RVA = "0x9C7B1C", Offset = "0x9C7B1C", VA = "0x9C7B1C")]
		public RESULT setSoundGroup(SoundGroup soundgroup)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60002F6")]
		[Address(RVA = "0x9C7B24", Offset = "0x9C7B24", VA = "0x9C7B24")]
		public RESULT getSoundGroup(out SoundGroup soundgroup)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60002F7")]
		[Address(RVA = "0x9C7B2C", Offset = "0x9C7B2C", VA = "0x9C7B2C")]
		public RESULT getNumSyncPoints(out int numsyncpoints)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60002F8")]
		[Address(RVA = "0x9C7B34", Offset = "0x9C7B34", VA = "0x9C7B34")]
		public RESULT getSyncPoint(int index, out IntPtr point)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60002F9")]
		[Address(RVA = "0x9C7B3C", Offset = "0x9C7B3C", VA = "0x9C7B3C")]
		public RESULT getSyncPointInfo(IntPtr point, out string name, int namelen, out uint offset, TIMEUNIT offsettype)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60002FA")]
		[Address(RVA = "0x9C7B44", Offset = "0x9C7B44", VA = "0x9C7B44")]
		public RESULT getSyncPointInfo(IntPtr point, out uint offset, TIMEUNIT offsettype)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60002FB")]
		[Address(RVA = "0x9C7B4C", Offset = "0x9C7B4C", VA = "0x9C7B4C")]
		public RESULT addSyncPoint(uint offset, TIMEUNIT offsettype, string name, out IntPtr point)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60002FC")]
		[Address(RVA = "0x9C7B54", Offset = "0x9C7B54", VA = "0x9C7B54")]
		public RESULT deleteSyncPoint(IntPtr point)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60002FD")]
		[Address(RVA = "0x9C7B5C", Offset = "0x9C7B5C", VA = "0x9C7B5C")]
		public RESULT setMode(MODE mode)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60002FE")]
		[Address(RVA = "0x9C7B64", Offset = "0x9C7B64", VA = "0x9C7B64")]
		public RESULT getMode(out MODE mode)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60002FF")]
		[Address(RVA = "0x9C7B6C", Offset = "0x9C7B6C", VA = "0x9C7B6C")]
		public RESULT setLoopCount(int loopcount)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000300")]
		[Address(RVA = "0x9C7B74", Offset = "0x9C7B74", VA = "0x9C7B74")]
		public RESULT getLoopCount(out int loopcount)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000301")]
		[Address(RVA = "0x9C7B7C", Offset = "0x9C7B7C", VA = "0x9C7B7C")]
		public RESULT setLoopPoints(uint loopstart, TIMEUNIT loopstarttype, uint loopend, TIMEUNIT loopendtype)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000302")]
		[Address(RVA = "0x9C7B84", Offset = "0x9C7B84", VA = "0x9C7B84")]
		public RESULT getLoopPoints(out uint loopstart, TIMEUNIT loopstarttype, out uint loopend, TIMEUNIT loopendtype)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000303")]
		[Address(RVA = "0x9C7B8C", Offset = "0x9C7B8C", VA = "0x9C7B8C")]
		public RESULT getMusicNumChannels(out int numchannels)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000304")]
		[Address(RVA = "0x9C7B94", Offset = "0x9C7B94", VA = "0x9C7B94")]
		public RESULT setMusicChannelVolume(int channel, float volume)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000305")]
		[Address(RVA = "0x9C7B9C", Offset = "0x9C7B9C", VA = "0x9C7B9C")]
		public RESULT getMusicChannelVolume(int channel, out float volume)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000306")]
		[Address(RVA = "0x9C7BA4", Offset = "0x9C7BA4", VA = "0x9C7BA4")]
		public RESULT setMusicSpeed(float speed)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000307")]
		[Address(RVA = "0x9C7BAC", Offset = "0x9C7BAC", VA = "0x9C7BAC")]
		public RESULT getMusicSpeed(out float speed)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000308")]
		[Address(RVA = "0x9C7BB4", Offset = "0x9C7BB4", VA = "0x9C7BB4")]
		public RESULT setUserData(IntPtr userdata)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000309")]
		[Address(RVA = "0x9C7BBC", Offset = "0x9C7BBC", VA = "0x9C7BBC")]
		public RESULT getUserData(out IntPtr userdata)
		{
			return default(RESULT);
		}

		[PreserveSig]
		[Token(Token = "0x600030A")]
		[Address(RVA = "0x1A4AE58", Offset = "0x1A4AE58", VA = "0x1A4AE58")]
		private static extern RESULT FMOD5_Sound_Release(IntPtr sound);

		[PreserveSig]
		[Token(Token = "0x600030B")]
		[Address(RVA = "0x1A4AEFC", Offset = "0x1A4AEFC", VA = "0x1A4AEFC")]
		private static extern RESULT FMOD5_Sound_GetSystemObject(IntPtr sound, out IntPtr system);

		[PreserveSig]
		[Token(Token = "0x600030C")]
		[Address(RVA = "0x1A4AFB0", Offset = "0x1A4AFB0", VA = "0x1A4AFB0")]
		private static extern RESULT FMOD5_Sound_Lock(IntPtr sound, uint offset, uint length, out IntPtr ptr1, out IntPtr ptr2, out uint len1, out uint len2);

		[PreserveSig]
		[Token(Token = "0x600030D")]
		[Address(RVA = "0x1A4B09C", Offset = "0x1A4B09C", VA = "0x1A4B09C")]
		private static extern RESULT FMOD5_Sound_Unlock(IntPtr sound, IntPtr ptr1, IntPtr ptr2, uint len1, uint len2);

		[PreserveSig]
		[Token(Token = "0x600030E")]
		[Address(RVA = "0x1A4B170", Offset = "0x1A4B170", VA = "0x1A4B170")]
		private static extern RESULT FMOD5_Sound_SetDefaults(IntPtr sound, float frequency, int priority);

		[PreserveSig]
		[Token(Token = "0x600030F")]
		[Address(RVA = "0x1A4B234", Offset = "0x1A4B234", VA = "0x1A4B234")]
		private static extern RESULT FMOD5_Sound_GetDefaults(IntPtr sound, out float frequency, out int priority);

		[PreserveSig]
		[Token(Token = "0x6000310")]
		[Address(RVA = "0x1A4B2F0", Offset = "0x1A4B2F0", VA = "0x1A4B2F0")]
		private static extern RESULT FMOD5_Sound_Set3DMinMaxDistance(IntPtr sound, float min, float max);

		[PreserveSig]
		[Token(Token = "0x6000311")]
		[Address(RVA = "0x1A4B3AC", Offset = "0x1A4B3AC", VA = "0x1A4B3AC")]
		private static extern RESULT FMOD5_Sound_Get3DMinMaxDistance(IntPtr sound, out float min, out float max);

		[PreserveSig]
		[Token(Token = "0x6000312")]
		[Address(RVA = "0x1A4B468", Offset = "0x1A4B468", VA = "0x1A4B468")]
		private static extern RESULT FMOD5_Sound_Set3DConeSettings(IntPtr sound, float insideconeangle, float outsideconeangle, float outsidevolume);

		[PreserveSig]
		[Token(Token = "0x6000313")]
		[Address(RVA = "0x1A4B534", Offset = "0x1A4B534", VA = "0x1A4B534")]
		private static extern RESULT FMOD5_Sound_Get3DConeSettings(IntPtr sound, out float insideconeangle, out float outsideconeangle, out float outsidevolume);

		[PreserveSig]
		[Token(Token = "0x6000314")]
		[Address(RVA = "0x1A4B600", Offset = "0x1A4B600", VA = "0x1A4B600")]
		private static extern RESULT FMOD5_Sound_Set3DCustomRolloff(IntPtr sound, ref VECTOR points, int numpoints);

		[PreserveSig]
		[Token(Token = "0x6000315")]
		[Address(RVA = "0x1A4B6BC", Offset = "0x1A4B6BC", VA = "0x1A4B6BC")]
		private static extern RESULT FMOD5_Sound_Get3DCustomRolloff(IntPtr sound, out IntPtr points, out int numpoints);

		[PreserveSig]
		[Token(Token = "0x6000316")]
		[Address(RVA = "0x1A4B778", Offset = "0x1A4B778", VA = "0x1A4B778")]
		private static extern RESULT FMOD5_Sound_GetSubSound(IntPtr sound, int index, out IntPtr subsound);

		[PreserveSig]
		[Token(Token = "0x6000317")]
		[Address(RVA = "0x1A4B834", Offset = "0x1A4B834", VA = "0x1A4B834")]
		private static extern RESULT FMOD5_Sound_GetSubSoundParent(IntPtr sound, out IntPtr parentsound);

		[PreserveSig]
		[Token(Token = "0x6000318")]
		[Address(RVA = "0x1A4BAA8", Offset = "0x1A4BAA8", VA = "0x1A4BAA8")]
		private static extern RESULT FMOD5_Sound_GetName(IntPtr sound, IntPtr name, int namelen);

		[PreserveSig]
		[Token(Token = "0x6000319")]
		[Address(RVA = "0x1A4BDC8", Offset = "0x1A4BDC8", VA = "0x1A4BDC8")]
		private static extern RESULT FMOD5_Sound_GetLength(IntPtr sound, out uint length, TIMEUNIT lengthtype);

		[PreserveSig]
		[Token(Token = "0x600031A")]
		[Address(RVA = "0x1A4BE84", Offset = "0x1A4BE84", VA = "0x1A4BE84")]
		private static extern RESULT FMOD5_Sound_GetFormat(IntPtr sound, out SOUND_TYPE type, out SOUND_FORMAT format, out int channels, out int bits);

		[PreserveSig]
		[Token(Token = "0x600031B")]
		[Address(RVA = "0x1A4BF58", Offset = "0x1A4BF58", VA = "0x1A4BF58")]
		private static extern RESULT FMOD5_Sound_GetNumSubSounds(IntPtr sound, out int numsubsounds);

		[PreserveSig]
		[Token(Token = "0x600031C")]
		[Address(RVA = "0x1A4C00C", Offset = "0x1A4C00C", VA = "0x1A4C00C")]
		private static extern RESULT FMOD5_Sound_GetNumTags(IntPtr sound, out int numtags, out int numtagsupdated);

		[PreserveSig]
		[Token(Token = "0x600031D")]
		[Address(RVA = "0x1A4C234", Offset = "0x1A4C234", VA = "0x1A4C234")]
		private static extern RESULT FMOD5_Sound_GetTag(IntPtr sound, byte[] name, int index, out TAG tag);

		[PreserveSig]
		[Token(Token = "0x600031E")]
		[Address(RVA = "0x1A4C344", Offset = "0x1A4C344", VA = "0x1A4C344")]
		private static extern RESULT FMOD5_Sound_GetOpenState(IntPtr sound, out OPENSTATE openstate, out uint percentbuffered, out bool starving, out bool diskbusy);

		[PreserveSig]
		[Token(Token = "0x600031F")]
		[Address(RVA = "0x1A4C43C", Offset = "0x1A4C43C", VA = "0x1A4C43C")]
		private static extern RESULT FMOD5_Sound_ReadData(IntPtr sound, IntPtr buffer, uint length, out uint read);

		[PreserveSig]
		[Token(Token = "0x6000320")]
		[Address(RVA = "0x1A4C508", Offset = "0x1A4C508", VA = "0x1A4C508")]
		private static extern RESULT FMOD5_Sound_SeekData(IntPtr sound, uint pcm);

		[PreserveSig]
		[Token(Token = "0x6000321")]
		[Address(RVA = "0x1A4C5BC", Offset = "0x1A4C5BC", VA = "0x1A4C5BC")]
		private static extern RESULT FMOD5_Sound_SetSoundGroup(IntPtr sound, IntPtr soundgroup);

		[PreserveSig]
		[Token(Token = "0x6000322")]
		[Address(RVA = "0x1A4C670", Offset = "0x1A4C670", VA = "0x1A4C670")]
		private static extern RESULT FMOD5_Sound_GetSoundGroup(IntPtr sound, out IntPtr soundgroup);

		[PreserveSig]
		[Token(Token = "0x6000323")]
		[Address(RVA = "0x1A4C724", Offset = "0x1A4C724", VA = "0x1A4C724")]
		private static extern RESULT FMOD5_Sound_GetNumSyncPoints(IntPtr sound, out int numsyncpoints);

		[PreserveSig]
		[Token(Token = "0x6000324")]
		[Address(RVA = "0x1A4C7D8", Offset = "0x1A4C7D8", VA = "0x1A4C7D8")]
		private static extern RESULT FMOD5_Sound_GetSyncPoint(IntPtr sound, int index, out IntPtr point);

		[PreserveSig]
		[Token(Token = "0x6000325")]
		[Address(RVA = "0x1A4CA6C", Offset = "0x1A4CA6C", VA = "0x1A4CA6C")]
		private static extern RESULT FMOD5_Sound_GetSyncPointInfo(IntPtr sound, IntPtr point, IntPtr name, int namelen, out uint offset, TIMEUNIT offsettype);

		[PreserveSig]
		[Token(Token = "0x6000326")]
		[Address(RVA = "0x1A4CD38", Offset = "0x1A4CD38", VA = "0x1A4CD38")]
		private static extern RESULT FMOD5_Sound_AddSyncPoint(IntPtr sound, uint offset, TIMEUNIT offsettype, byte[] name, out IntPtr point);

		[PreserveSig]
		[Token(Token = "0x6000327")]
		[Address(RVA = "0x1A4CE14", Offset = "0x1A4CE14", VA = "0x1A4CE14")]
		private static extern RESULT FMOD5_Sound_DeleteSyncPoint(IntPtr sound, IntPtr point);

		[PreserveSig]
		[Token(Token = "0x6000328")]
		[Address(RVA = "0x1A4CEC8", Offset = "0x1A4CEC8", VA = "0x1A4CEC8")]
		private static extern RESULT FMOD5_Sound_SetMode(IntPtr sound, MODE mode);

		[PreserveSig]
		[Token(Token = "0x6000329")]
		[Address(RVA = "0x1A4CF7C", Offset = "0x1A4CF7C", VA = "0x1A4CF7C")]
		private static extern RESULT FMOD5_Sound_GetMode(IntPtr sound, out MODE mode);

		[PreserveSig]
		[Token(Token = "0x600032A")]
		[Address(RVA = "0x1A4D030", Offset = "0x1A4D030", VA = "0x1A4D030")]
		private static extern RESULT FMOD5_Sound_SetLoopCount(IntPtr sound, int loopcount);

		[PreserveSig]
		[Token(Token = "0x600032B")]
		[Address(RVA = "0x1A4D0E4", Offset = "0x1A4D0E4", VA = "0x1A4D0E4")]
		private static extern RESULT FMOD5_Sound_GetLoopCount(IntPtr sound, out int loopcount);

		[PreserveSig]
		[Token(Token = "0x600032C")]
		[Address(RVA = "0x1A4D198", Offset = "0x1A4D198", VA = "0x1A4D198")]
		private static extern RESULT FMOD5_Sound_SetLoopPoints(IntPtr sound, uint loopstart, TIMEUNIT loopstarttype, uint loopend, TIMEUNIT loopendtype);

		[PreserveSig]
		[Token(Token = "0x600032D")]
		[Address(RVA = "0x1A4D26C", Offset = "0x1A4D26C", VA = "0x1A4D26C")]
		private static extern RESULT FMOD5_Sound_GetLoopPoints(IntPtr sound, out uint loopstart, TIMEUNIT loopstarttype, out uint loopend, TIMEUNIT loopendtype);

		[PreserveSig]
		[Token(Token = "0x600032E")]
		[Address(RVA = "0x1A4D340", Offset = "0x1A4D340", VA = "0x1A4D340")]
		private static extern RESULT FMOD5_Sound_GetMusicNumChannels(IntPtr sound, out int numchannels);

		[PreserveSig]
		[Token(Token = "0x600032F")]
		[Address(RVA = "0x1A4D3F4", Offset = "0x1A4D3F4", VA = "0x1A4D3F4")]
		private static extern RESULT FMOD5_Sound_SetMusicChannelVolume(IntPtr sound, int channel, float volume);

		[PreserveSig]
		[Token(Token = "0x6000330")]
		[Address(RVA = "0x1A4D4B8", Offset = "0x1A4D4B8", VA = "0x1A4D4B8")]
		private static extern RESULT FMOD5_Sound_GetMusicChannelVolume(IntPtr sound, int channel, out float volume);

		[PreserveSig]
		[Token(Token = "0x6000331")]
		[Address(RVA = "0x1A4D574", Offset = "0x1A4D574", VA = "0x1A4D574")]
		private static extern RESULT FMOD5_Sound_SetMusicSpeed(IntPtr sound, float speed);

		[PreserveSig]
		[Token(Token = "0x6000332")]
		[Address(RVA = "0x1A4D628", Offset = "0x1A4D628", VA = "0x1A4D628")]
		private static extern RESULT FMOD5_Sound_GetMusicSpeed(IntPtr sound, out float speed);

		[PreserveSig]
		[Token(Token = "0x6000333")]
		[Address(RVA = "0x1A4D6DC", Offset = "0x1A4D6DC", VA = "0x1A4D6DC")]
		private static extern RESULT FMOD5_Sound_SetUserData(IntPtr sound, IntPtr userdata);

		[PreserveSig]
		[Token(Token = "0x6000334")]
		[Address(RVA = "0x1A4D790", Offset = "0x1A4D790", VA = "0x1A4D790")]
		private static extern RESULT FMOD5_Sound_GetUserData(IntPtr sound, out IntPtr userdata);

		[Token(Token = "0x6000335")]
		[Address(RVA = "0x9C7BC4", Offset = "0x9C7BC4", VA = "0x9C7BC4")]
		public bool hasHandle()
		{
			return default(bool);
		}

		[Token(Token = "0x6000336")]
		[Address(RVA = "0x9C7BCC", Offset = "0x9C7BCC", VA = "0x9C7BCC")]
		public void clearHandle()
		{
		}
	}
	[Token(Token = "0x2000070")]
	internal interface IChannelControl
	{
		[Token(Token = "0x6000337")]
		RESULT getSystemObject(out System system);

		[Token(Token = "0x6000338")]
		RESULT stop();

		[Token(Token = "0x6000339")]
		RESULT setPaused(bool paused);

		[Token(Token = "0x600033A")]
		RESULT getPaused(out bool paused);

		[Token(Token = "0x600033B")]
		RESULT setVolume(float volume);

		[Token(Token = "0x600033C")]
		RESULT getVolume(out float volume);

		[Token(Token = "0x600033D")]
		RESULT setVolumeRamp(bool ramp);

		[Token(Token = "0x600033E")]
		RESULT getVolumeRamp(out bool ramp);

		[Token(Token = "0x600033F")]
		RESULT getAudibility(out float audibility);

		[Token(Token = "0x6000340")]
		RESULT setPitch(float pitch);

		[Token(Token = "0x6000341")]
		RESULT getPitch(out float pitch);

		[Token(Token = "0x6000342")]
		RESULT setMute(bool mute);

		[Token(Token = "0x6000343")]
		RESULT getMute(out bool mute);

		[Token(Token = "0x6000344")]
		RESULT setReverbProperties(int instance, float wet);

		[Token(Token = "0x6000345")]
		RESULT getReverbProperties(int instance, out float wet);

		[Token(Token = "0x6000346")]
		RESULT setLowPassGain(float gain);

		[Token(Token = "0x6000347")]
		RESULT getLowPassGain(out float gain);

		[Token(Token = "0x6000348")]
		RESULT setMode(MODE mode);

		[Token(Token = "0x6000349")]
		RESULT getMode(out MODE mode);

		[Token(Token = "0x600034A")]
		RESULT setCallback(CHANNELCONTROL_CALLBACK callback);

		[Token(Token = "0x600034B")]
		RESULT isPlaying(out bool isplaying);

		[Token(Token = "0x600034C")]
		RESULT setPan(float pan);

		[Token(Token = "0x600034D")]
		RESULT setMixLevelsOutput(float frontleft, float frontright, float center, float lfe, float surroundleft, float surroundright, float backleft, float backright);

		[Token(Token = "0x600034E")]
		RESULT setMixLevelsInput(float[] levels, int numlevels);

		[Token(Token = "0x600034F")]
		RESULT setMixMatrix(float[] matrix, int outchannels, int inchannels, int inchannel_hop);

		[Token(Token = "0x6000350")]
		RESULT getMixMatrix(float[] matrix, out int outchannels, out int inchannels, int inchannel_hop);

		[Token(Token = "0x6000351")]
		RESULT getDSPClock(out ulong dspclock, out ulong parentclock);

		[Token(Token = "0x6000352")]
		RESULT setDelay(ulong dspclock_start, ulong dspclock_end, bool stopchannels);

		[Token(Token = "0x6000353")]
		RESULT getDelay(out ulong dspclock_start, out ulong dspclock_end);

		[Token(Token = "0x6000354")]
		RESULT getDelay(out ulong dspclock_start, out ulong dspclock_end, out bool stopchannels);

		[Token(Token = "0x6000355")]
		RESULT addFadePoint(ulong dspclock, float volume);

		[Token(Token = "0x6000356")]
		RESULT setFadePointRamp(ulong dspclock, float volume);

		[Token(Token = "0x6000357")]
		RESULT removeFadePoints(ulong dspclock_start, ulong dspclock_end);

		[Token(Token = "0x6000358")]
		RESULT getFadePoints(ref uint numpoints, ulong[] point_dspclock, float[] point_volume);

		[Token(Token = "0x6000359")]
		RESULT getDSP(int index, out DSP dsp);

		[Token(Token = "0x600035A")]
		RESULT addDSP(int index, DSP dsp);

		[Token(Token = "0x600035B")]
		RESULT removeDSP(DSP dsp);

		[Token(Token = "0x600035C")]
		RESULT getNumDSPs(out int numdsps);

		[Token(Token = "0x600035D")]
		RESULT setDSPIndex(DSP dsp, int index);

		[Token(Token = "0x600035E")]
		RESULT getDSPIndex(DSP dsp, out int index);

		[Token(Token = "0x600035F")]
		RESULT set3DAttributes(ref VECTOR pos, ref VECTOR vel);

		[Token(Token = "0x6000360")]
		RESULT get3DAttributes(out VECTOR pos, out VECTOR vel);

		[Token(Token = "0x6000361")]
		RESULT set3DMinMaxDistance(float mindistance, float maxdistance);

		[Token(Token = "0x6000362")]
		RESULT get3DMinMaxDistance(out float mindistance, out float maxdistance);

		[Token(Token = "0x6000363")]
		RESULT set3DConeSettings(float insideconeangle, float outsideconeangle, float outsidevolume);

		[Token(Token = "0x6000364")]
		RESULT get3DConeSettings(out float insideconeangle, out float outsideconeangle, out float outsidevolume);

		[Token(Token = "0x6000365")]
		RESULT set3DConeOrientation(ref VECTOR orientation);

		[Token(Token = "0x6000366")]
		RESULT get3DConeOrientation(out VECTOR orientation);

		[Token(Token = "0x6000367")]
		RESULT set3DCustomRolloff(ref VECTOR points, int numpoints);

		[Token(Token = "0x6000368")]
		RESULT get3DCustomRolloff(out IntPtr points, out int numpoints);

		[Token(Token = "0x6000369")]
		RESULT set3DOcclusion(float directocclusion, float reverbocclusion);

		[Token(Token = "0x600036A")]
		RESULT get3DOcclusion(out float directocclusion, out float reverbocclusion);

		[Token(Token = "0x600036B")]
		RESULT set3DSpread(float angle);

		[Token(Token = "0x600036C")]
		RESULT get3DSpread(out float angle);

		[Token(Token = "0x600036D")]
		RESULT set3DLevel(float level);

		[Token(Token = "0x600036E")]
		RESULT get3DLevel(out float level);

		[Token(Token = "0x600036F")]
		RESULT set3DDopplerLevel(float level);

		[Token(Token = "0x6000370")]
		RESULT get3DDopplerLevel(out float level);

		[Token(Token = "0x6000371")]
		RESULT set3DDistanceFilter(bool custom, float customLevel, float centerFreq);

		[Token(Token = "0x6000372")]
		RESULT get3DDistanceFilter(out bool custom, out float customLevel, out float centerFreq);

		[Token(Token = "0x6000373")]
		RESULT setUserData(IntPtr userdata);

		[Token(Token = "0x6000374")]
		RESULT getUserData(out IntPtr userdata);
	}
	[Token(Token = "0x2000071")]
	public struct Channel : IChannelControl
	{
		[Token(Token = "0x4000351")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public IntPtr handle;

		[Token(Token = "0x6000375")]
		[Address(RVA = "0x9C8F7C", Offset = "0x9C8F7C", VA = "0x9C8F7C")]
		public RESULT setFrequency(float frequency)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000376")]
		[Address(RVA = "0x9C8F84", Offset = "0x9C8F84", VA = "0x9C8F84")]
		public RESULT getFrequency(out float frequency)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000377")]
		[Address(RVA = "0x9C8F8C", Offset = "0x9C8F8C", VA = "0x9C8F8C")]
		public RESULT setPriority(int priority)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000378")]
		[Address(RVA = "0x9C8F94", Offset = "0x9C8F94", VA = "0x9C8F94")]
		public RESULT getPriority(out int priority)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000379")]
		[Address(RVA = "0x9C8F9C", Offset = "0x9C8F9C", VA = "0x9C8F9C")]
		public RESULT setPosition(uint position, TIMEUNIT postype)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600037A")]
		[Address(RVA = "0x9C8FA4", Offset = "0x9C8FA4", VA = "0x9C8FA4")]
		public RESULT getPosition(out uint position, TIMEUNIT postype)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600037B")]
		[Address(RVA = "0x9C8FAC", Offset = "0x9C8FAC", VA = "0x9C8FAC")]
		public RESULT setChannelGroup(ChannelGroup channelgroup)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600037C")]
		[Address(RVA = "0x9C8FB4", Offset = "0x9C8FB4", VA = "0x9C8FB4")]
		public RESULT getChannelGroup(out ChannelGroup channelgroup)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600037D")]
		[Address(RVA = "0x9C8FBC", Offset = "0x9C8FBC", VA = "0x9C8FBC")]
		public RESULT setLoopCount(int loopcount)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600037E")]
		[Address(RVA = "0x9C8FC4", Offset = "0x9C8FC4", VA = "0x9C8FC4")]
		public RESULT getLoopCount(out int loopcount)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600037F")]
		[Address(RVA = "0x9C8FCC", Offset = "0x9C8FCC", VA = "0x9C8FCC")]
		public RESULT setLoopPoints(uint loopstart, TIMEUNIT loopstarttype, uint loopend, TIMEUNIT loopendtype)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000380")]
		[Address(RVA = "0x9C8FD4", Offset = "0x9C8FD4", VA = "0x9C8FD4")]
		public RESULT getLoopPoints(out uint loopstart, TIMEUNIT loopstarttype, out uint loopend, TIMEUNIT loopendtype)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000381")]
		[Address(RVA = "0x9C8FDC", Offset = "0x9C8FDC", VA = "0x9C8FDC")]
		public RESULT isVirtual(out bool isvirtual)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000382")]
		[Address(RVA = "0x9C8FE4", Offset = "0x9C8FE4", VA = "0x9C8FE4")]
		public RESULT getCurrentSound(out Sound sound)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000383")]
		[Address(RVA = "0x9C8FEC", Offset = "0x9C8FEC", VA = "0x9C8FEC")]
		public RESULT getIndex(out int index)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000384")]
		[Address(RVA = "0x9C8FF4", Offset = "0x9C8FF4", VA = "0x9C8FF4", Slot = "4")]
		public RESULT getSystemObject(out System system)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000385")]
		[Address(RVA = "0x9C8FFC", Offset = "0x9C8FFC", VA = "0x9C8FFC", Slot = "5")]
		public RESULT stop()
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000386")]
		[Address(RVA = "0x9C9004", Offset = "0x9C9004", VA = "0x9C9004", Slot = "6")]
		public RESULT setPaused(bool paused)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000387")]
		[Address(RVA = "0x9C9010", Offset = "0x9C9010", VA = "0x9C9010", Slot = "7")]
		public RESULT getPaused(out bool paused)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000388")]
		[Address(RVA = "0x9C9018", Offset = "0x9C9018", VA = "0x9C9018", Slot = "8")]
		public RESULT setVolume(float volume)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000389")]
		[Address(RVA = "0x9C9020", Offset = "0x9C9020", VA = "0x9C9020", Slot = "9")]
		public RESULT getVolume(out float volume)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600038A")]
		[Address(RVA = "0x9C9028", Offset = "0x9C9028", VA = "0x9C9028", Slot = "10")]
		public RESULT setVolumeRamp(bool ramp)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600038B")]
		[Address(RVA = "0x9C9034", Offset = "0x9C9034", VA = "0x9C9034", Slot = "11")]
		public RESULT getVolumeRamp(out bool ramp)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600038C")]
		[Address(RVA = "0x9C903C", Offset = "0x9C903C", VA = "0x9C903C", Slot = "12")]
		public RESULT getAudibility(out float audibility)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600038D")]
		[Address(RVA = "0x9C9044", Offset = "0x9C9044", VA = "0x9C9044", Slot = "13")]
		public RESULT setPitch(float pitch)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600038E")]
		[Address(RVA = "0x9C904C", Offset = "0x9C904C", VA = "0x9C904C", Slot = "14")]
		public RESULT getPitch(out float pitch)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600038F")]
		[Address(RVA = "0x9C9054", Offset = "0x9C9054", VA = "0x9C9054", Slot = "15")]
		public RESULT setMute(bool mute)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000390")]
		[Address(RVA = "0x9C9060", Offset = "0x9C9060", VA = "0x9C9060", Slot = "16")]
		public RESULT getMute(out bool mute)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000391")]
		[Address(RVA = "0x9C9068", Offset = "0x9C9068", VA = "0x9C9068", Slot = "17")]
		public RESULT setReverbProperties(int instance, float wet)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000392")]
		[Address(RVA = "0x9C9070", Offset = "0x9C9070", VA = "0x9C9070", Slot = "18")]
		public RESULT getReverbProperties(int instance, out float wet)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000393")]
		[Address(RVA = "0x9C9078", Offset = "0x9C9078", VA = "0x9C9078", Slot = "19")]
		public RESULT setLowPassGain(float gain)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000394")]
		[Address(RVA = "0x9C9080", Offset = "0x9C9080", VA = "0x9C9080", Slot = "20")]
		public RESULT getLowPassGain(out float gain)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000395")]
		[Address(RVA = "0x9C9088", Offset = "0x9C9088", VA = "0x9C9088", Slot = "21")]
		public RESULT setMode(MODE mode)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000396")]
		[Address(RVA = "0x9C9090", Offset = "0x9C9090", VA = "0x9C9090", Slot = "22")]
		public RESULT getMode(out MODE mode)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000397")]
		[Address(RVA = "0x9C9098", Offset = "0x9C9098", VA = "0x9C9098", Slot = "23")]
		public RESULT setCallback(CHANNELCONTROL_CALLBACK callback)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000398")]
		[Address(RVA = "0x9C90A0", Offset = "0x9C90A0", VA = "0x9C90A0", Slot = "24")]
		public RESULT isPlaying(out bool isplaying)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000399")]
		[Address(RVA = "0x9C90A8", Offset = "0x9C90A8", VA = "0x9C90A8", Slot = "25")]
		public RESULT setPan(float pan)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600039A")]
		[Address(RVA = "0x9C90B0", Offset = "0x9C90B0", VA = "0x9C90B0", Slot = "26")]
		public RESULT setMixLevelsOutput(float frontleft, float frontright, float center, float lfe, float surroundleft, float surroundright, float backleft, float backright)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600039B")]
		[Address(RVA = "0x9C90B8", Offset = "0x9C90B8", VA = "0x9C90B8", Slot = "27")]
		public RESULT setMixLevelsInput(float[] levels, int numlevels)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600039C")]
		[Address(RVA = "0x9C90C0", Offset = "0x9C90C0", VA = "0x9C90C0", Slot = "28")]
		public RESULT setMixMatrix(float[] matrix, int outchannels, int inchannels, int inchannel_hop = 0)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600039D")]
		[Address(RVA = "0x9C90C8", Offset = "0x9C90C8", VA = "0x9C90C8", Slot = "29")]
		public RESULT getMixMatrix(float[] matrix, out int outchannels, out int inchannels, int inchannel_hop = 0)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600039E")]
		[Address(RVA = "0x9C90D0", Offset = "0x9C90D0", VA = "0x9C90D0", Slot = "30")]
		public RESULT getDSPClock(out ulong dspclock, out ulong parentclock)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600039F")]
		[Address(RVA = "0x9C90D8", Offset = "0x9C90D8", VA = "0x9C90D8", Slot = "31")]
		public RESULT setDelay(ulong dspclock_start, ulong dspclock_end, bool stopchannels = true)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60003A0")]
		[Address(RVA = "0x9C90E4", Offset = "0x9C90E4", VA = "0x9C90E4", Slot = "32")]
		public RESULT getDelay(out ulong dspclock_start, out ulong dspclock_end)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60003A1")]
		[Address(RVA = "0x9C90EC", Offset = "0x9C90EC", VA = "0x9C90EC", Slot = "33")]
		public RESULT getDelay(out ulong dspclock_start, out ulong dspclock_end, out bool stopchannels)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60003A2")]
		[Address(RVA = "0x9C90F4", Offset = "0x9C90F4", VA = "0x9C90F4", Slot = "34")]
		public RESULT addFadePoint(ulong dspclock, float volume)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60003A3")]
		[Address(RVA = "0x9C90FC", Offset = "0x9C90FC", VA = "0x9C90FC", Slot = "35")]
		public RESULT setFadePointRamp(ulong dspclock, float volume)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60003A4")]
		[Address(RVA = "0x9C9104", Offset = "0x9C9104", VA = "0x9C9104", Slot = "36")]
		public RESULT removeFadePoints(ulong dspclock_start, ulong dspclock_end)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60003A5")]
		[Address(RVA = "0x9C910C", Offset = "0x9C910C", VA = "0x9C910C", Slot = "37")]
		public RESULT getFadePoints(ref uint numpoints, ulong[] point_dspclock, float[] point_volume)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60003A6")]
		[Address(RVA = "0x9C9114", Offset = "0x9C9114", VA = "0x9C9114", Slot = "38")]
		public RESULT getDSP(int index, out DSP dsp)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60003A7")]
		[Address(RVA = "0x9C911C", Offset = "0x9C911C", VA = "0x9C911C", Slot = "39")]
		public RESULT addDSP(int index, DSP dsp)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60003A8")]
		[Address(RVA = "0x9C9124", Offset = "0x9C9124", VA = "0x9C9124", Slot = "40")]
		public RESULT removeDSP(DSP dsp)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60003A9")]
		[Address(RVA = "0x9C912C", Offset = "0x9C912C", VA = "0x9C912C", Slot = "41")]
		public RESULT getNumDSPs(out int numdsps)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60003AA")]
		[Address(RVA = "0x9C9134", Offset = "0x9C9134", VA = "0x9C9134", Slot = "42")]
		public RESULT setDSPIndex(DSP dsp, int index)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60003AB")]
		[Address(RVA = "0x9C913C", Offset = "0x9C913C", VA = "0x9C913C", Slot = "43")]
		public RESULT getDSPIndex(DSP dsp, out int index)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60003AC")]
		[Address(RVA = "0x9C9144", Offset = "0x9C9144", VA = "0x9C9144", Slot = "44")]
		public RESULT set3DAttributes(ref VECTOR pos, ref VECTOR vel)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60003AD")]
		[Address(RVA = "0x9C914C", Offset = "0x9C914C", VA = "0x9C914C", Slot = "45")]
		public RESULT get3DAttributes(out VECTOR pos, out VECTOR vel)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60003AE")]
		[Address(RVA = "0x9C9154", Offset = "0x9C9154", VA = "0x9C9154", Slot = "46")]
		public RESULT set3DMinMaxDistance(float mindistance, float maxdistance)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60003AF")]
		[Address(RVA = "0x9C915C", Offset = "0x9C915C", VA = "0x9C915C", Slot = "47")]
		public RESULT get3DMinMaxDistance(out float mindistance, out float maxdistance)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60003B0")]
		[Address(RVA = "0x9C9164", Offset = "0x9C9164", VA = "0x9C9164", Slot = "48")]
		public RESULT set3DConeSettings(float insideconeangle, float outsideconeangle, float outsidevolume)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60003B1")]
		[Address(RVA = "0x9C916C", Offset = "0x9C916C", VA = "0x9C916C", Slot = "49")]
		public RESULT get3DConeSettings(out float insideconeangle, out float outsideconeangle, out float outsidevolume)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60003B2")]
		[Address(RVA = "0x9C9174", Offset = "0x9C9174", VA = "0x9C9174", Slot = "50")]
		public RESULT set3DConeOrientation(ref VECTOR orientation)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60003B3")]
		[Address(RVA = "0x9C917C", Offset = "0x9C917C", VA = "0x9C917C", Slot = "51")]
		public RESULT get3DConeOrientation(out VECTOR orientation)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60003B4")]
		[Address(RVA = "0x9C9184", Offset = "0x9C9184", VA = "0x9C9184", Slot = "52")]
		public RESULT set3DCustomRolloff(ref VECTOR points, int numpoints)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60003B5")]
		[Address(RVA = "0x9C918C", Offset = "0x9C918C", VA = "0x9C918C", Slot = "53")]
		public RESULT get3DCustomRolloff(out IntPtr points, out int numpoints)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60003B6")]
		[Address(RVA = "0x9C9194", Offset = "0x9C9194", VA = "0x9C9194", Slot = "54")]
		public RESULT set3DOcclusion(float directocclusion, float reverbocclusion)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60003B7")]
		[Address(RVA = "0x9C919C", Offset = "0x9C919C", VA = "0x9C919C", Slot = "55")]
		public RESULT get3DOcclusion(out float directocclusion, out float reverbocclusion)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60003B8")]
		[Address(RVA = "0x9C91A4", Offset = "0x9C91A4", VA = "0x9C91A4", Slot = "56")]
		public RESULT set3DSpread(float angle)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60003B9")]
		[Address(RVA = "0x9C91AC", Offset = "0x9C91AC", VA = "0x9C91AC", Slot = "57")]
		public RESULT get3DSpread(out float angle)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60003BA")]
		[Address(RVA = "0x9C91B4", Offset = "0x9C91B4", VA = "0x9C91B4", Slot = "58")]
		public RESULT set3DLevel(float level)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60003BB")]
		[Address(RVA = "0x9C91BC", Offset = "0x9C91BC", VA = "0x9C91BC", Slot = "59")]
		public RESULT get3DLevel(out float level)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60003BC")]
		[Address(RVA = "0x9C91C4", Offset = "0x9C91C4", VA = "0x9C91C4", Slot = "60")]
		public RESULT set3DDopplerLevel(float level)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60003BD")]
		[Address(RVA = "0x9C91CC", Offset = "0x9C91CC", VA = "0x9C91CC", Slot = "61")]
		public RESULT get3DDopplerLevel(out float level)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60003BE")]
		[Address(RVA = "0x9C91D4", Offset = "0x9C91D4", VA = "0x9C91D4", Slot = "62")]
		public RESULT set3DDistanceFilter(bool custom, float customLevel, float centerFreq)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60003BF")]
		[Address(RVA = "0x9C91E0", Offset = "0x9C91E0", VA = "0x9C91E0", Slot = "63")]
		public RESULT get3DDistanceFilter(out bool custom, out float customLevel, out float centerFreq)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60003C0")]
		[Address(RVA = "0x9C91E8", Offset = "0x9C91E8", VA = "0x9C91E8", Slot = "64")]
		public RESULT setUserData(IntPtr userdata)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60003C1")]
		[Address(RVA = "0x9C91F0", Offset = "0x9C91F0", VA = "0x9C91F0", Slot = "65")]
		public RESULT getUserData(out IntPtr userdata)
		{
			return default(RESULT);
		}

		[PreserveSig]
		[Token(Token = "0x60003C2")]
		[Address(RVA = "0x1A5D57C", Offset = "0x1A5D57C", VA = "0x1A5D57C")]
		private static extern RESULT FMOD5_Channel_SetFrequency(IntPtr channel, float frequency);

		[PreserveSig]
		[Token(Token = "0x60003C3")]
		[Address(RVA = "0x1A5D630", Offset = "0x1A5D630", VA = "0x1A5D630")]
		private static extern RESULT FMOD5_Channel_GetFrequency(IntPtr channel, out float frequency);

		[PreserveSig]
		[Token(Token = "0x60003C4")]
		[Address(RVA = "0x1A5D6E4", Offset = "0x1A5D6E4", VA = "0x1A5D6E4")]
		private static extern RESULT FMOD5_Channel_SetPriority(IntPtr channel, int priority);

		[PreserveSig]
		[Token(Token = "0x60003C5")]
		[Address(RVA = "0x1A5D798", Offset = "0x1A5D798", VA = "0x1A5D798")]
		private static extern RESULT FMOD5_Channel_GetPriority(IntPtr channel, out int priority);

		[PreserveSig]
		[Token(Token = "0x60003C6")]
		[Address(RVA = "0x1A5D84C", Offset = "0x1A5D84C", VA = "0x1A5D84C")]
		private static extern RESULT FMOD5_Channel_SetPosition(IntPtr channel, uint position, TIMEUNIT postype);

		[PreserveSig]
		[Token(Token = "0x60003C7")]
		[Address(RVA = "0x1A5D908", Offset = "0x1A5D908", VA = "0x1A5D908")]
		private static extern RESULT FMOD5_Channel_GetPosition(IntPtr channel, out uint position, TIMEUNIT postype);

		[PreserveSig]
		[Token(Token = "0x60003C8")]
		[Address(RVA = "0x1A5D9C4", Offset = "0x1A5D9C4", VA = "0x1A5D9C4")]
		private static extern RESULT FMOD5_Channel_SetChannelGroup(IntPtr channel, IntPtr channelgroup);

		[PreserveSig]
		[Token(Token = "0x60003C9")]
		[Address(RVA = "0x1A5DA78", Offset = "0x1A5DA78", VA = "0x1A5DA78")]
		private static extern RESULT FMOD5_Channel_GetChannelGroup(IntPtr channel, out IntPtr channelgroup);

		[PreserveSig]
		[Token(Token = "0x60003CA")]
		[Address(RVA = "0x1A5DB2C", Offset = "0x1A5DB2C", VA = "0x1A5DB2C")]
		private static extern RESULT FMOD5_Channel_SetLoopCount(IntPtr channel, int loopcount);

		[PreserveSig]
		[Token(Token = "0x60003CB")]
		[Address(RVA = "0x1A5DBE0", Offset = "0x1A5DBE0", VA = "0x1A5DBE0")]
		private static extern RESULT FMOD5_Channel_GetLoopCount(IntPtr channel, out int loopcount);

		[PreserveSig]
		[Token(Token = "0x60003CC")]
		[Address(RVA = "0x1A5DC94", Offset = "0x1A5DC94", VA = "0x1A5DC94")]
		private static extern RESULT FMOD5_Channel_SetLoopPoints(IntPtr channel, uint loopstart, TIMEUNIT loopstarttype, uint loopend, TIMEUNIT loopendtype);

		[PreserveSig]
		[Token(Token = "0x60003CD")]
		[Address(RVA = "0x1A5DD68", Offset = "0x1A5DD68", VA = "0x1A5DD68")]
		private static extern RESULT FMOD5_Channel_GetLoopPoints(IntPtr channel, out uint loopstart, TIMEUNIT loopstarttype, out uint loopend, TIMEUNIT loopendtype);

		[PreserveSig]
		[Token(Token = "0x60003CE")]
		[Address(RVA = "0x1A5DE3C", Offset = "0x1A5DE3C", VA = "0x1A5DE3C")]
		private static extern RESULT FMOD5_Channel_IsVirtual(IntPtr channel, out bool isvirtual);

		[PreserveSig]
		[Token(Token = "0x60003CF")]
		[Address(RVA = "0x1A5DF04", Offset = "0x1A5DF04", VA = "0x1A5DF04")]
		private static extern RESULT FMOD5_Channel_GetCurrentSound(IntPtr channel, out IntPtr sound);

		[PreserveSig]
		[Token(Token = "0x60003D0")]
		[Address(RVA = "0x1A5DFB8", Offset = "0x1A5DFB8", VA = "0x1A5DFB8")]
		private static extern RESULT FMOD5_Channel_GetIndex(IntPtr channel, out int index);

		[PreserveSig]
		[Token(Token = "0x60003D1")]
		[Address(RVA = "0x1A5E06C", Offset = "0x1A5E06C", VA = "0x1A5E06C")]
		private static extern RESULT FMOD5_Channel_GetSystemObject(IntPtr channel, out IntPtr system);

		[PreserveSig]
		[Token(Token = "0x60003D2")]
		[Address(RVA = "0x1A5E120", Offset = "0x1A5E120", VA = "0x1A5E120")]
		private static extern RESULT FMOD5_Channel_Stop(IntPtr channel);

		[PreserveSig]
		[Token(Token = "0x60003D3")]
		[Address(RVA = "0x1A5E1C8", Offset = "0x1A5E1C8", VA = "0x1A5E1C8")]
		private static extern RESULT FMOD5_Channel_SetPaused(IntPtr channel, bool paused);

		[PreserveSig]
		[Token(Token = "0x60003D4")]
		[Address(RVA = "0x1A5E27C", Offset = "0x1A5E27C", VA = "0x1A5E27C")]
		private static extern RESULT FMOD5_Channel_GetPaused(IntPtr channel, out bool paused);

		[PreserveSig]
		[Token(Token = "0x60003D5")]
		[Address(RVA = "0x1A5E344", Offset = "0x1A5E344", VA = "0x1A5E344")]
		private static extern RESULT FMOD5_Channel_SetVolume(IntPtr channel, float volume);

		[PreserveSig]
		[Token(Token = "0x60003D6")]
		[Address(RVA = "0x1A5E3F8", Offset = "0x1A5E3F8", VA = "0x1A5E3F8")]
		private static extern RESULT FMOD5_Channel_GetVolume(IntPtr channel, out float volume);

		[PreserveSig]
		[Token(Token = "0x60003D7")]
		[Address(RVA = "0x1A5E4B0", Offset = "0x1A5E4B0", VA = "0x1A5E4B0")]
		private static extern RESULT FMOD5_Channel_SetVolumeRamp(IntPtr channel, bool ramp);

		[PreserveSig]
		[Token(Token = "0x60003D8")]
		[Address(RVA = "0x1A5E564", Offset = "0x1A5E564", VA = "0x1A5E564")]
		private static extern RESULT FMOD5_Channel_GetVolumeRamp(IntPtr channel, out bool ramp);

		[PreserveSig]
		[Token(Token = "0x60003D9")]
		[Address(RVA = "0x1A5E62C", Offset = "0x1A5E62C", VA = "0x1A5E62C")]
		private static extern RESULT FMOD5_Channel_GetAudibility(IntPtr channel, out float audibility);

		[PreserveSig]
		[Token(Token = "0x60003DA")]
		[Address(RVA = "0x1A5E6E0", Offset = "0x1A5E6E0", VA = "0x1A5E6E0")]
		private static extern RESULT FMOD5_Channel_SetPitch(IntPtr channel, float pitch);

		[PreserveSig]
		[Token(Token = "0x60003DB")]
		[Address(RVA = "0x1A5E794", Offset = "0x1A5E794", VA = "0x1A5E794")]
		private static extern RESULT FMOD5_Channel_GetPitch(IntPtr channel, out float pitch);

		[PreserveSig]
		[Token(Token = "0x60003DC")]
		[Address(RVA = "0x1A5E84C", Offset = "0x1A5E84C", VA = "0x1A5E84C")]
		private static extern RESULT FMOD5_Channel_SetMute(IntPtr channel, bool mute);

		[PreserveSig]
		[Token(Token = "0x60003DD")]
		[Address(RVA = "0x1A5E900", Offset = "0x1A5E900", VA = "0x1A5E900")]
		private static extern RESULT FMOD5_Channel_GetMute(IntPtr channel, out bool mute);

		[PreserveSig]
		[Token(Token = "0x60003DE")]
		[Address(RVA = "0x1A5E9C8", Offset = "0x1A5E9C8", VA = "0x1A5E9C8")]
		private static extern RESULT FMOD5_Channel_SetReverbProperties(IntPtr channel, int instance, float wet);

		[PreserveSig]
		[Token(Token = "0x60003DF")]
		[Address(RVA = "0x1A5EA8C", Offset = "0x1A5EA8C", VA = "0x1A5EA8C")]
		private static extern RESULT FMOD5_Channel_GetReverbProperties(IntPtr channel, int instance, out float wet);

		[PreserveSig]
		[Token(Token = "0x60003E0")]
		[Address(RVA = "0x1A5EB48", Offset = "0x1A5EB48", VA = "0x1A5EB48")]
		private static extern RESULT FMOD5_Channel_SetLowPassGain(IntPtr channel, float gain);

		[PreserveSig]
		[Token(Token = "0x60003E1")]
		[Address(RVA = "0x1A5EBFC", Offset = "0x1A5EBFC", VA = "0x1A5EBFC")]
		private static extern RESULT FMOD5_Channel_GetLowPassGain(IntPtr channel, out float gain);

		[PreserveSig]
		[Token(Token = "0x60003E2")]
		[Address(RVA = "0x1A5ECB0", Offset = "0x1A5ECB0", VA = "0x1A5ECB0")]
		private static extern RESULT FMOD5_Channel_SetMode(IntPtr channel, MODE mode);

		[PreserveSig]
		[Token(Token = "0x60003E3")]
		[Address(RVA = "0x1A5ED64", Offset = "0x1A5ED64", VA = "0x1A5ED64")]
		private static extern RESULT FMOD5_Channel_GetMode(IntPtr channel, out MODE mode);

		[PreserveSig]
		[Token(Token = "0x60003E4")]
		[Address(RVA = "0x1A5EE18", Offset = "0x1A5EE18", VA = "0x1A5EE18")]
		private static extern RESULT FMOD5_Channel_SetCallback(IntPtr channel, CHANNELCONTROL_CALLBACK callback);

		[PreserveSig]
		[Token(Token = "0x60003E5")]
		[Address(RVA = "0x1A5EED4", Offset = "0x1A5EED4", VA = "0x1A5EED4")]
		private static extern RESULT FMOD5_Channel_IsPlaying(IntPtr channel, out bool isplaying);

		[PreserveSig]
		[Token(Token = "0x60003E6")]
		[Address(RVA = "0x1A5EF9C", Offset = "0x1A5EF9C", VA = "0x1A5EF9C")]
		private static extern RESULT FMOD5_Channel_SetPan(IntPtr channel, float pan);

		[PreserveSig]
		[Token(Token = "0x60003E7")]
		[Address(RVA = "0x1A5F050", Offset = "0x1A5F050", VA = "0x1A5F050")]
		private static extern RESULT FMOD5_Channel_SetMixLevelsOutput(IntPtr channel, float frontleft, float frontright, float center, float lfe, float surroundleft, float surroundright, float backleft, float backright);

		[PreserveSig]
		[Token(Token = "0x60003E8")]
		[Address(RVA = "0x1A5F154", Offset = "0x1A5F154", VA = "0x1A5F154")]
		private static extern RESULT FMOD5_Channel_SetMixLevelsInput(IntPtr channel, float[] levels, int numlevels);

		[PreserveSig]
		[Token(Token = "0x60003E9")]
		[Address(RVA = "0x1A5F218", Offset = "0x1A5F218", VA = "0x1A5F218")]
		private static extern RESULT FMOD5_Channel_SetMixMatrix(IntPtr channel, float[] matrix, int outchannels, int inchannels, int inchannel_hop);

		[PreserveSig]
		[Token(Token = "0x60003EA")]
		[Address(RVA = "0x1A5F2F4", Offset = "0x1A5F2F4", VA = "0x1A5F2F4")]
		private static extern RESULT FMOD5_Channel_GetMixMatrix(IntPtr channel, float[] matrix, out int outchannels, out int inchannels, int inchannel_hop);

		[PreserveSig]
		[Token(Token = "0x60003EB")]
		[Address(RVA = "0x1A5F3D0", Offset = "0x1A5F3D0", VA = "0x1A5F3D0")]
		private static extern RESULT FMOD5_Channel_GetDSPClock(IntPtr channel, out ulong dspclock, out ulong parentclock);

		[PreserveSig]
		[Token(Token = "0x60003EC")]
		[Address(RVA = "0x1A5F490", Offset = "0x1A5F490", VA = "0x1A5F490")]
		private static extern RESULT FMOD5_Channel_SetDelay(IntPtr channel, ulong dspclock_start, ulong dspclock_end, bool stopchannels);

		[PreserveSig]
		[Token(Token = "0x60003ED")]
		[Address(RVA = "0x1A5F5B4", Offset = "0x1A5F5B4", VA = "0x1A5F5B4")]
		private static extern RESULT FMOD5_Channel_GetDelay(IntPtr channel, out ulong dspclock_start, out ulong dspclock_end, IntPtr zero);

		[PreserveSig]
		[Token(Token = "0x60003EE")]
		[Address(RVA = "0x1A5F680", Offset = "0x1A5F680", VA = "0x1A5F680")]
		private static extern RESULT FMOD5_Channel_GetDelay(IntPtr channel, out ulong dspclock_start, out ulong dspclock_end, out bool stopchannels);

		[PreserveSig]
		[Token(Token = "0x60003EF")]
		[Address(RVA = "0x1A5F760", Offset = "0x1A5F760", VA = "0x1A5F760")]
		private static extern RESULT FMOD5_Channel_AddFadePoint(IntPtr channel, ulong dspclock, float volume);

		[PreserveSig]
		[Token(Token = "0x60003F0")]
		[Address(RVA = "0x1A5F824", Offset = "0x1A5F824", VA = "0x1A5F824")]
		private static extern RESULT FMOD5_Channel_SetFadePointRamp(IntPtr channel, ulong dspclock, float volume);

		[PreserveSig]
		[Token(Token = "0x60003F1")]
		[Address(RVA = "0x1A5F8E8", Offset = "0x1A5F8E8", VA = "0x1A5F8E8")]
		private static extern RESULT FMOD5_Channel_RemoveFadePoints(IntPtr channel, ulong dspclock_start, ulong dspclock_end);

		[PreserveSig]
		[Token(Token = "0x60003F2")]
		[Address(RVA = "0x1A5F9A4", Offset = "0x1A5F9A4", VA = "0x1A5F9A4")]
		private static extern RESULT FMOD5_Channel_GetFadePoints(IntPtr channel, ref uint numpoints, ulong[] point_dspclock, float[] point_volume);

		[PreserveSig]
		[Token(Token = "0x60003F3")]
		[Address(RVA = "0x1A5FA80", Offset = "0x1A5FA80", VA = "0x1A5FA80")]
		private static extern RESULT FMOD5_Channel_GetDSP(IntPtr channel, int index, out IntPtr dsp);

		[PreserveSig]
		[Token(Token = "0x60003F4")]
		[Address(RVA = "0x1A5FB38", Offset = "0x1A5FB38", VA = "0x1A5FB38")]
		private static extern RESULT FMOD5_Channel_AddDSP(IntPtr channel, int index, IntPtr dsp);

		[PreserveSig]
		[Token(Token = "0x60003F5")]
		[Address(RVA = "0x1A5FBF0", Offset = "0x1A5FBF0", VA = "0x1A5FBF0")]
		private static extern RESULT FMOD5_Channel_RemoveDSP(IntPtr channel, IntPtr dsp);

		[PreserveSig]
		[Token(Token = "0x60003F6")]
		[Address(RVA = "0x1A5FCA4", Offset = "0x1A5FCA4", VA = "0x1A5FCA4")]
		private static extern RESULT FMOD5_Channel_GetNumDSPs(IntPtr channel, out int numdsps);

		[PreserveSig]
		[Token(Token = "0x60003F7")]
		[Address(RVA = "0x1A5FD58", Offset = "0x1A5FD58", VA = "0x1A5FD58")]
		private static extern RESULT FMOD5_Channel_SetDSPIndex(IntPtr channel, IntPtr dsp, int index);

		[PreserveSig]
		[Token(Token = "0x60003F8")]
		[Address(RVA = "0x1A5FE14", Offset = "0x1A5FE14", VA = "0x1A5FE14")]
		private static extern RESULT FMOD5_Channel_GetDSPIndex(IntPtr channel, IntPtr dsp, out int index);

		[PreserveSig]
		[Token(Token = "0x60003F9")]
		[Address(RVA = "0x1A5FED0", Offset = "0x1A5FED0", VA = "0x1A5FED0")]
		private static extern RESULT FMOD5_Channel_Set3DAttributes(IntPtr channel, ref VECTOR pos, ref VECTOR vel);

		[PreserveSig]
		[Token(Token = "0x60003FA")]
		[Address(RVA = "0x1A5FF8C", Offset = "0x1A5FF8C", VA = "0x1A5FF8C")]
		private static extern RESULT FMOD5_Channel_Get3DAttributes(IntPtr channel, out VECTOR pos, out VECTOR vel);

		[PreserveSig]
		[Token(Token = "0x60003FB")]
		[Address(RVA = "0x1A60048", Offset = "0x1A60048", VA = "0x1A60048")]
		private static extern RESULT FMOD5_Channel_Set3DMinMaxDistance(IntPtr channel, float mindistance, float maxdistance);

		[PreserveSig]
		[Token(Token = "0x60003FC")]
		[Address(RVA = "0x1A60104", Offset = "0x1A60104", VA = "0x1A60104")]
		private static extern RESULT FMOD5_Channel_Get3DMinMaxDistance(IntPtr channel, out float mindistance, out float maxdistance);

		[PreserveSig]
		[Token(Token = "0x60003FD")]
		[Address(RVA = "0x1A601C0", Offset = "0x1A601C0", VA = "0x1A601C0")]
		private static extern RESULT FMOD5_Channel_Set3DConeSettings(IntPtr channel, float insideconeangle, float outsideconeangle, float outsidevolume);

		[PreserveSig]
		[Token(Token = "0x60003FE")]
		[Address(RVA = "0x1A6028C", Offset = "0x1A6028C", VA = "0x1A6028C")]
		private static extern RESULT FMOD5_Channel_Get3DConeSettings(IntPtr channel, out float insideconeangle, out float outsideconeangle, out float outsidevolume);

		[PreserveSig]
		[Token(Token = "0x60003FF")]
		[Address(RVA = "0x1A60358", Offset = "0x1A60358", VA = "0x1A60358")]
		private static extern RESULT FMOD5_Channel_Set3DConeOrientation(IntPtr channel, ref VECTOR orientation);

		[PreserveSig]
		[Token(Token = "0x6000400")]
		[Address(RVA = "0x1A6040C", Offset = "0x1A6040C", VA = "0x1A6040C")]
		private static extern RESULT FMOD5_Channel_Get3DConeOrientation(IntPtr channel, out VECTOR orientation);

		[PreserveSig]
		[Token(Token = "0x6000401")]
		[Address(RVA = "0x1A604C0", Offset = "0x1A604C0", VA = "0x1A604C0")]
		private static extern RESULT FMOD5_Channel_Set3DCustomRolloff(IntPtr channel, ref VECTOR points, int numpoints);

		[PreserveSig]
		[Token(Token = "0x6000402")]
		[Address(RVA = "0x1A6057C", Offset = "0x1A6057C", VA = "0x1A6057C")]
		private static extern RESULT FMOD5_Channel_Get3DCustomRolloff(IntPtr channel, out IntPtr points, out int numpoints);

		[PreserveSig]
		[Token(Token = "0x6000403")]
		[Address(RVA = "0x1A60638", Offset = "0x1A60638", VA = "0x1A60638")]
		private static extern RESULT FMOD5_Channel_Set3DOcclusion(IntPtr channel, float directocclusion, float reverbocclusion);

		[PreserveSig]
		[Token(Token = "0x6000404")]
		[Address(RVA = "0x1A606F4", Offset = "0x1A606F4", VA = "0x1A606F4")]
		private static extern RESULT FMOD5_Channel_Get3DOcclusion(IntPtr channel, out float directocclusion, out float reverbocclusion);

		[PreserveSig]
		[Token(Token = "0x6000405")]
		[Address(RVA = "0x1A607B0", Offset = "0x1A607B0", VA = "0x1A607B0")]
		private static extern RESULT FMOD5_Channel_Set3DSpread(IntPtr channel, float angle);

		[PreserveSig]
		[Token(Token = "0x6000406")]
		[Address(RVA = "0x1A60864", Offset = "0x1A60864", VA = "0x1A60864")]
		private static extern RESULT FMOD5_Channel_Get3DSpread(IntPtr channel, out float angle);

		[PreserveSig]
		[Token(Token = "0x6000407")]
		[Address(RVA = "0x1A60918", Offset = "0x1A60918", VA = "0x1A60918")]
		private static extern RESULT FMOD5_Channel_Set3DLevel(IntPtr channel, float level);

		[PreserveSig]
		[Token(Token = "0x6000408")]
		[Address(RVA = "0x1A609CC", Offset = "0x1A609CC", VA = "0x1A609CC")]
		private static extern RESULT FMOD5_Channel_Get3DLevel(IntPtr channel, out float level);

		[PreserveSig]
		[Token(Token = "0x6000409")]
		[Address(RVA = "0x1A60A80", Offset = "0x1A60A80", VA = "0x1A60A80")]
		private static extern RESULT FMOD5_Channel_Set3DDopplerLevel(IntPtr channel, float level);

		[PreserveSig]
		[Token(Token = "0x600040A")]
		[Address(RVA = "0x1A60B34", Offset = "0x1A60B34", VA = "0x1A60B34")]
		private static extern RESULT FMOD5_Channel_Get3DDopplerLevel(IntPtr channel, out float level);

		[PreserveSig]
		[Token(Token = "0x600040B")]
		[Address(RVA = "0x1A60BEC", Offset = "0x1A60BEC", VA = "0x1A60BEC")]
		private static extern RESULT FMOD5_Channel_Set3DDistanceFilter(IntPtr channel, bool custom, float customLevel, float centerFreq);

		[PreserveSig]
		[Token(Token = "0x600040C")]
		[Address(RVA = "0x1A60CB8", Offset = "0x1A60CB8", VA = "0x1A60CB8")]
		private static extern RESULT FMOD5_Channel_Get3DDistanceFilter(IntPtr channel, out bool custom, out float customLevel, out float centerFreq);

		[PreserveSig]
		[Token(Token = "0x600040D")]
		[Address(RVA = "0x1A60D98", Offset = "0x1A60D98", VA = "0x1A60D98")]
		private static extern RESULT FMOD5_Channel_SetUserData(IntPtr channel, IntPtr userdata);

		[PreserveSig]
		[Token(Token = "0x600040E")]
		[Address(RVA = "0x1A60E4C", Offset = "0x1A60E4C", VA = "0x1A60E4C")]
		private static extern RESULT FMOD5_Channel_GetUserData(IntPtr channel, out IntPtr userdata);

		[Token(Token = "0x600040F")]
		[Address(RVA = "0x9C91F8", Offset = "0x9C91F8", VA = "0x9C91F8")]
		public bool hasHandle()
		{
			return default(bool);
		}

		[Token(Token = "0x6000410")]
		[Address(RVA = "0x9C9200", Offset = "0x9C9200", VA = "0x9C9200")]
		public void clearHandle()
		{
		}
	}
	[Token(Token = "0x2000072")]
	public struct ChannelGroup : IChannelControl
	{
		[Token(Token = "0x4000352")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public IntPtr handle;

		[Token(Token = "0x6000411")]
		[Address(RVA = "0x9C9244", Offset = "0x9C9244", VA = "0x9C9244")]
		public RESULT release()
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000412")]
		[Address(RVA = "0x9C924C", Offset = "0x9C924C", VA = "0x9C924C")]
		public RESULT addGroup(ChannelGroup group, bool propagatedspclock = true)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000413")]
		[Address(RVA = "0x9C9258", Offset = "0x9C9258", VA = "0x9C9258")]
		public RESULT addGroup(ChannelGroup group, bool propagatedspclock, out DSPConnection connection)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000414")]
		[Address(RVA = "0x9C9264", Offset = "0x9C9264", VA = "0x9C9264")]
		public RESULT getNumGroups(out int numgroups)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000415")]
		[Address(RVA = "0x9C926C", Offset = "0x9C926C", VA = "0x9C926C")]
		public RESULT getGroup(int index, out ChannelGroup group)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000416")]
		[Address(RVA = "0x9C9274", Offset = "0x9C9274", VA = "0x9C9274")]
		public RESULT getParentGroup(out ChannelGroup group)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000417")]
		[Address(RVA = "0x9C927C", Offset = "0x9C927C", VA = "0x9C927C")]
		public RESULT getName(out string name, int namelen)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000418")]
		[Address(RVA = "0x9C9284", Offset = "0x9C9284", VA = "0x9C9284")]
		public RESULT getNumChannels(out int numchannels)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000419")]
		[Address(RVA = "0x9C928C", Offset = "0x9C928C", VA = "0x9C928C")]
		public RESULT getChannel(int index, out Channel channel)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600041A")]
		[Address(RVA = "0x9C9294", Offset = "0x9C9294", VA = "0x9C9294", Slot = "4")]
		public RESULT getSystemObject(out System system)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600041B")]
		[Address(RVA = "0x9C929C", Offset = "0x9C929C", VA = "0x9C929C", Slot = "5")]
		public RESULT stop()
		{
			return default(RESULT);
		}

		[Token(Token = "0x600041C")]
		[Address(RVA = "0x9C92A4", Offset = "0x9C92A4", VA = "0x9C92A4", Slot = "6")]
		public RESULT setPaused(bool paused)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600041D")]
		[Address(RVA = "0x9C92B0", Offset = "0x9C92B0", VA = "0x9C92B0", Slot = "7")]
		public RESULT getPaused(out bool paused)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600041E")]
		[Address(RVA = "0x9C92B8", Offset = "0x9C92B8", VA = "0x9C92B8", Slot = "8")]
		public RESULT setVolume(float volume)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600041F")]
		[Address(RVA = "0x9C92C0", Offset = "0x9C92C0", VA = "0x9C92C0", Slot = "9")]
		public RESULT getVolume(out float volume)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000420")]
		[Address(RVA = "0x9C92C8", Offset = "0x9C92C8", VA = "0x9C92C8", Slot = "10")]
		public RESULT setVolumeRamp(bool ramp)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000421")]
		[Address(RVA = "0x9C92D4", Offset = "0x9C92D4", VA = "0x9C92D4", Slot = "11")]
		public RESULT getVolumeRamp(out bool ramp)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000422")]
		[Address(RVA = "0x9C92DC", Offset = "0x9C92DC", VA = "0x9C92DC", Slot = "12")]
		public RESULT getAudibility(out float audibility)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000423")]
		[Address(RVA = "0x9C92E4", Offset = "0x9C92E4", VA = "0x9C92E4", Slot = "13")]
		public RESULT setPitch(float pitch)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000424")]
		[Address(RVA = "0x9C92EC", Offset = "0x9C92EC", VA = "0x9C92EC", Slot = "14")]
		public RESULT getPitch(out float pitch)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000425")]
		[Address(RVA = "0x9C92F4", Offset = "0x9C92F4", VA = "0x9C92F4", Slot = "15")]
		public RESULT setMute(bool mute)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000426")]
		[Address(RVA = "0x9C9300", Offset = "0x9C9300", VA = "0x9C9300", Slot = "16")]
		public RESULT getMute(out bool mute)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000427")]
		[Address(RVA = "0x9C9308", Offset = "0x9C9308", VA = "0x9C9308", Slot = "17")]
		public RESULT setReverbProperties(int instance, float wet)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000428")]
		[Address(RVA = "0x9C9310", Offset = "0x9C9310", VA = "0x9C9310", Slot = "18")]
		public RESULT getReverbProperties(int instance, out float wet)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000429")]
		[Address(RVA = "0x9C9318", Offset = "0x9C9318", VA = "0x9C9318", Slot = "19")]
		public RESULT setLowPassGain(float gain)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600042A")]
		[Address(RVA = "0x9C9320", Offset = "0x9C9320", VA = "0x9C9320", Slot = "20")]
		public RESULT getLowPassGain(out float gain)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600042B")]
		[Address(RVA = "0x9C9328", Offset = "0x9C9328", VA = "0x9C9328", Slot = "21")]
		public RESULT setMode(MODE mode)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600042C")]
		[Address(RVA = "0x9C9330", Offset = "0x9C9330", VA = "0x9C9330", Slot = "22")]
		public RESULT getMode(out MODE mode)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600042D")]
		[Address(RVA = "0x9C9338", Offset = "0x9C9338", VA = "0x9C9338", Slot = "23")]
		public RESULT setCallback(CHANNELCONTROL_CALLBACK callback)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600042E")]
		[Address(RVA = "0x9C9340", Offset = "0x9C9340", VA = "0x9C9340", Slot = "24")]
		public RESULT isPlaying(out bool isplaying)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600042F")]
		[Address(RVA = "0x9C9348", Offset = "0x9C9348", VA = "0x9C9348", Slot = "25")]
		public RESULT setPan(float pan)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000430")]
		[Address(RVA = "0x9C9350", Offset = "0x9C9350", VA = "0x9C9350", Slot = "26")]
		public RESULT setMixLevelsOutput(float frontleft, float frontright, float center, float lfe, float surroundleft, float surroundright, float backleft, float backright)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000431")]
		[Address(RVA = "0x9C9358", Offset = "0x9C9358", VA = "0x9C9358", Slot = "27")]
		public RESULT setMixLevelsInput(float[] levels, int numlevels)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000432")]
		[Address(RVA = "0x9C9360", Offset = "0x9C9360", VA = "0x9C9360", Slot = "28")]
		public RESULT setMixMatrix(float[] matrix, int outchannels, int inchannels, int inchannel_hop)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000433")]
		[Address(RVA = "0x9C9368", Offset = "0x9C9368", VA = "0x9C9368", Slot = "29")]
		public RESULT getMixMatrix(float[] matrix, out int outchannels, out int inchannels, int inchannel_hop)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000434")]
		[Address(RVA = "0x9C9370", Offset = "0x9C9370", VA = "0x9C9370", Slot = "30")]
		public RESULT getDSPClock(out ulong dspclock, out ulong parentclock)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000435")]
		[Address(RVA = "0x9C9378", Offset = "0x9C9378", VA = "0x9C9378", Slot = "31")]
		public RESULT setDelay(ulong dspclock_start, ulong dspclock_end, bool stopchannels)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000436")]
		[Address(RVA = "0x9C9384", Offset = "0x9C9384", VA = "0x9C9384", Slot = "32")]
		public RESULT getDelay(out ulong dspclock_start, out ulong dspclock_end)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000437")]
		[Address(RVA = "0x9C938C", Offset = "0x9C938C", VA = "0x9C938C", Slot = "33")]
		public RESULT getDelay(out ulong dspclock_start, out ulong dspclock_end, out bool stopchannels)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000438")]
		[Address(RVA = "0x9C9394", Offset = "0x9C9394", VA = "0x9C9394", Slot = "34")]
		public RESULT addFadePoint(ulong dspclock, float volume)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000439")]
		[Address(RVA = "0x9C939C", Offset = "0x9C939C", VA = "0x9C939C", Slot = "35")]
		public RESULT setFadePointRamp(ulong dspclock, float volume)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600043A")]
		[Address(RVA = "0x9C93A4", Offset = "0x9C93A4", VA = "0x9C93A4", Slot = "36")]
		public RESULT removeFadePoints(ulong dspclock_start, ulong dspclock_end)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600043B")]
		[Address(RVA = "0x9C93AC", Offset = "0x9C93AC", VA = "0x9C93AC", Slot = "37")]
		public RESULT getFadePoints(ref uint numpoints, ulong[] point_dspclock, float[] point_volume)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600043C")]
		[Address(RVA = "0x9C93B4", Offset = "0x9C93B4", VA = "0x9C93B4", Slot = "38")]
		public RESULT getDSP(int index, out DSP dsp)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600043D")]
		[Address(RVA = "0x9C93BC", Offset = "0x9C93BC", VA = "0x9C93BC", Slot = "39")]
		public RESULT addDSP(int index, DSP dsp)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600043E")]
		[Address(RVA = "0x9C93C4", Offset = "0x9C93C4", VA = "0x9C93C4", Slot = "40")]
		public RESULT removeDSP(DSP dsp)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600043F")]
		[Address(RVA = "0x9C93CC", Offset = "0x9C93CC", VA = "0x9C93CC", Slot = "41")]
		public RESULT getNumDSPs(out int numdsps)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000440")]
		[Address(RVA = "0x9C93D4", Offset = "0x9C93D4", VA = "0x9C93D4", Slot = "42")]
		public RESULT setDSPIndex(DSP dsp, int index)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000441")]
		[Address(RVA = "0x9C93DC", Offset = "0x9C93DC", VA = "0x9C93DC", Slot = "43")]
		public RESULT getDSPIndex(DSP dsp, out int index)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000442")]
		[Address(RVA = "0x9C93E4", Offset = "0x9C93E4", VA = "0x9C93E4", Slot = "44")]
		public RESULT set3DAttributes(ref VECTOR pos, ref VECTOR vel)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000443")]
		[Address(RVA = "0x9C93EC", Offset = "0x9C93EC", VA = "0x9C93EC", Slot = "45")]
		public RESULT get3DAttributes(out VECTOR pos, out VECTOR vel)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000444")]
		[Address(RVA = "0x9C93F4", Offset = "0x9C93F4", VA = "0x9C93F4", Slot = "46")]
		public RESULT set3DMinMaxDistance(float mindistance, float maxdistance)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000445")]
		[Address(RVA = "0x9C93FC", Offset = "0x9C93FC", VA = "0x9C93FC", Slot = "47")]
		public RESULT get3DMinMaxDistance(out float mindistance, out float maxdistance)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000446")]
		[Address(RVA = "0x9C9404", Offset = "0x9C9404", VA = "0x9C9404", Slot = "48")]
		public RESULT set3DConeSettings(float insideconeangle, float outsideconeangle, float outsidevolume)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000447")]
		[Address(RVA = "0x9C940C", Offset = "0x9C940C", VA = "0x9C940C", Slot = "49")]
		public RESULT get3DConeSettings(out float insideconeangle, out float outsideconeangle, out float outsidevolume)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000448")]
		[Address(RVA = "0x9C9414", Offset = "0x9C9414", VA = "0x9C9414", Slot = "50")]
		public RESULT set3DConeOrientation(ref VECTOR orientation)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000449")]
		[Address(RVA = "0x9C941C", Offset = "0x9C941C", VA = "0x9C941C", Slot = "51")]
		public RESULT get3DConeOrientation(out VECTOR orientation)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600044A")]
		[Address(RVA = "0x9C9424", Offset = "0x9C9424", VA = "0x9C9424", Slot = "52")]
		public RESULT set3DCustomRolloff(ref VECTOR points, int numpoints)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600044B")]
		[Address(RVA = "0x9C942C", Offset = "0x9C942C", VA = "0x9C942C", Slot = "53")]
		public RESULT get3DCustomRolloff(out IntPtr points, out int numpoints)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600044C")]
		[Address(RVA = "0x9C9434", Offset = "0x9C9434", VA = "0x9C9434", Slot = "54")]
		public RESULT set3DOcclusion(float directocclusion, float reverbocclusion)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600044D")]
		[Address(RVA = "0x9C943C", Offset = "0x9C943C", VA = "0x9C943C", Slot = "55")]
		public RESULT get3DOcclusion(out float directocclusion, out float reverbocclusion)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600044E")]
		[Address(RVA = "0x9C9444", Offset = "0x9C9444", VA = "0x9C9444", Slot = "56")]
		public RESULT set3DSpread(float angle)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600044F")]
		[Address(RVA = "0x9C944C", Offset = "0x9C944C", VA = "0x9C944C", Slot = "57")]
		public RESULT get3DSpread(out float angle)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000450")]
		[Address(RVA = "0x9C9454", Offset = "0x9C9454", VA = "0x9C9454", Slot = "58")]
		public RESULT set3DLevel(float level)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000451")]
		[Address(RVA = "0x9C945C", Offset = "0x9C945C", VA = "0x9C945C", Slot = "59")]
		public RESULT get3DLevel(out float level)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000452")]
		[Address(RVA = "0x9C9464", Offset = "0x9C9464", VA = "0x9C9464", Slot = "60")]
		public RESULT set3DDopplerLevel(float level)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000453")]
		[Address(RVA = "0x9C946C", Offset = "0x9C946C", VA = "0x9C946C", Slot = "61")]
		public RESULT get3DDopplerLevel(out float level)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000454")]
		[Address(RVA = "0x9C9474", Offset = "0x9C9474", VA = "0x9C9474", Slot = "62")]
		public RESULT set3DDistanceFilter(bool custom, float customLevel, float centerFreq)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000455")]
		[Address(RVA = "0x9C9480", Offset = "0x9C9480", VA = "0x9C9480", Slot = "63")]
		public RESULT get3DDistanceFilter(out bool custom, out float customLevel, out float centerFreq)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000456")]
		[Address(RVA = "0x9C9488", Offset = "0x9C9488", VA = "0x9C9488", Slot = "64")]
		public RESULT setUserData(IntPtr userdata)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000457")]
		[Address(RVA = "0x9C9490", Offset = "0x9C9490", VA = "0x9C9490", Slot = "65")]
		public RESULT getUserData(out IntPtr userdata)
		{
			return default(RESULT);
		}

		[PreserveSig]
		[Token(Token = "0x6000458")]
		[Address(RVA = "0x1A60F90", Offset = "0x1A60F90", VA = "0x1A60F90")]
		private static extern RESULT FMOD5_ChannelGroup_Release(IntPtr channelgroup);

		[PreserveSig]
		[Token(Token = "0x6000459")]
		[Address(RVA = "0x1A6108C", Offset = "0x1A6108C", VA = "0x1A6108C")]
		private static extern RESULT FMOD5_ChannelGroup_AddGroup(IntPtr channelgroup, IntPtr group, bool propagatedspclock, IntPtr zero);

		[PreserveSig]
		[Token(Token = "0x600045A")]
		[Address(RVA = "0x1A6115C", Offset = "0x1A6115C", VA = "0x1A6115C")]
		private static extern RESULT FMOD5_ChannelGroup_AddGroup(IntPtr channelgroup, IntPtr group, bool propagatedspclock, out IntPtr connection);

		[PreserveSig]
		[Token(Token = "0x600045B")]
		[Address(RVA = "0x1A61228", Offset = "0x1A61228", VA = "0x1A61228")]
		private static extern RESULT FMOD5_ChannelGroup_GetNumGroups(IntPtr channelgroup, out int numgroups);

		[PreserveSig]
		[Token(Token = "0x600045C")]
		[Address(RVA = "0x1A612DC", Offset = "0x1A612DC", VA = "0x1A612DC")]
		private static extern RESULT FMOD5_ChannelGroup_GetGroup(IntPtr channelgroup, int index, out IntPtr group);

		[PreserveSig]
		[Token(Token = "0x600045D")]
		[Address(RVA = "0x1A61398", Offset = "0x1A61398", VA = "0x1A61398")]
		private static extern RESULT FMOD5_ChannelGroup_GetParentGroup(IntPtr channelgroup, out IntPtr group);

		[PreserveSig]
		[Token(Token = "0x600045E")]
		[Address(RVA = "0x1A61614", Offset = "0x1A61614", VA = "0x1A61614")]
		private static extern RESULT FMOD5_ChannelGroup_GetName(IntPtr channelgroup, IntPtr name, int namelen);

		[PreserveSig]
		[Token(Token = "0x600045F")]
		[Address(RVA = "0x1A616D0", Offset = "0x1A616D0", VA = "0x1A616D0")]
		private static extern RESULT FMOD5_ChannelGroup_GetNumChannels(IntPtr channelgroup, out int numchannels);

		[PreserveSig]
		[Token(Token = "0x6000460")]
		[Address(RVA = "0x1A61784", Offset = "0x1A61784", VA = "0x1A61784")]
		private static extern RESULT FMOD5_ChannelGroup_GetChannel(IntPtr channelgroup, int index, out IntPtr channel);

		[PreserveSig]
		[Token(Token = "0x6000461")]
		[Address(RVA = "0x1A61840", Offset = "0x1A61840", VA = "0x1A61840")]
		private static extern RESULT FMOD5_ChannelGroup_GetSystemObject(IntPtr channelgroup, out IntPtr system);

		[PreserveSig]
		[Token(Token = "0x6000462")]
		[Address(RVA = "0x1A618F4", Offset = "0x1A618F4", VA = "0x1A618F4")]
		private static extern RESULT FMOD5_ChannelGroup_Stop(IntPtr channelgroup);

		[PreserveSig]
		[Token(Token = "0x6000463")]
		[Address(RVA = "0x1A6199C", Offset = "0x1A6199C", VA = "0x1A6199C")]
		private static extern RESULT FMOD5_ChannelGroup_SetPaused(IntPtr channelgroup, bool paused);

		[PreserveSig]
		[Token(Token = "0x6000464")]
		[Address(RVA = "0x1A61A50", Offset = "0x1A61A50", VA = "0x1A61A50")]
		private static extern RESULT FMOD5_ChannelGroup_GetPaused(IntPtr channelgroup, out bool paused);

		[PreserveSig]
		[Token(Token = "0x6000465")]
		[Address(RVA = "0x1A61B18", Offset = "0x1A61B18", VA = "0x1A61B18")]
		private static extern RESULT FMOD5_ChannelGroup_SetVolume(IntPtr channelgroup, float volume);

		[PreserveSig]
		[Token(Token = "0x6000466")]
		[Address(RVA = "0x1A61BCC", Offset = "0x1A61BCC", VA = "0x1A61BCC")]
		private static extern RESULT FMOD5_ChannelGroup_GetVolume(IntPtr channelgroup, out float volume);

		[PreserveSig]
		[Token(Token = "0x6000467")]
		[Address(RVA = "0x1A61C84", Offset = "0x1A61C84", VA = "0x1A61C84")]
		private static extern RESULT FMOD5_ChannelGroup_SetVolumeRamp(IntPtr channelgroup, bool ramp);

		[PreserveSig]
		[Token(Token = "0x6000468")]
		[Address(RVA = "0x1A61D38", Offset = "0x1A61D38", VA = "0x1A61D38")]
		private static extern RESULT FMOD5_ChannelGroup_GetVolumeRamp(IntPtr channelgroup, out bool ramp);

		[PreserveSig]
		[Token(Token = "0x6000469")]
		[Address(RVA = "0x1A61E00", Offset = "0x1A61E00", VA = "0x1A61E00")]
		private static extern RESULT FMOD5_ChannelGroup_GetAudibility(IntPtr channelgroup, out float audibility);

		[PreserveSig]
		[Token(Token = "0x600046A")]
		[Address(RVA = "0x1A61EB4", Offset = "0x1A61EB4", VA = "0x1A61EB4")]
		private static extern RESULT FMOD5_ChannelGroup_SetPitch(IntPtr channelgroup, float pitch);

		[PreserveSig]
		[Token(Token = "0x600046B")]
		[Address(RVA = "0x1A61F68", Offset = "0x1A61F68", VA = "0x1A61F68")]
		private static extern RESULT FMOD5_ChannelGroup_GetPitch(IntPtr channelgroup, out float pitch);

		[PreserveSig]
		[Token(Token = "0x600046C")]
		[Address(RVA = "0x1A62020", Offset = "0x1A62020", VA = "0x1A62020")]
		private static extern RESULT FMOD5_ChannelGroup_SetMute(IntPtr channelgroup, bool mute);

		[PreserveSig]
		[Token(Token = "0x600046D")]
		[Address(RVA = "0x1A620D4", Offset = "0x1A620D4", VA = "0x1A620D4")]
		private static extern RESULT FMOD5_ChannelGroup_GetMute(IntPtr channelgroup, out bool mute);

		[PreserveSig]
		[Token(Token = "0x600046E")]
		[Address(RVA = "0x1A6219C", Offset = "0x1A6219C", VA = "0x1A6219C")]
		private static extern RESULT FMOD5_ChannelGroup_SetReverbProperties(IntPtr channelgroup, int instance, float wet);

		[PreserveSig]
		[Token(Token = "0x600046F")]
		[Address(RVA = "0x1A62260", Offset = "0x1A62260", VA = "0x1A62260")]
		private static extern RESULT FMOD5_ChannelGroup_GetReverbProperties(IntPtr channelgroup, int instance, out float wet);

		[PreserveSig]
		[Token(Token = "0x6000470")]
		[Address(RVA = "0x1A6231C", Offset = "0x1A6231C", VA = "0x1A6231C")]
		private static extern RESULT FMOD5_ChannelGroup_SetLowPassGain(IntPtr channelgroup, float gain);

		[PreserveSig]
		[Token(Token = "0x6000471")]
		[Address(RVA = "0x1A623D0", Offset = "0x1A623D0", VA = "0x1A623D0")]
		private static extern RESULT FMOD5_ChannelGroup_GetLowPassGain(IntPtr channelgroup, out float gain);

		[PreserveSig]
		[Token(Token = "0x6000472")]
		[Address(RVA = "0x1A62484", Offset = "0x1A62484", VA = "0x1A62484")]
		private static extern RESULT FMOD5_ChannelGroup_SetMode(IntPtr channelgroup, MODE mode);

		[PreserveSig]
		[Token(Token = "0x6000473")]
		[Address(RVA = "0x1A62538", Offset = "0x1A62538", VA = "0x1A62538")]
		private static extern RESULT FMOD5_ChannelGroup_GetMode(IntPtr channelgroup, out MODE mode);

		[PreserveSig]
		[Token(Token = "0x6000474")]
		[Address(RVA = "0x1A625EC", Offset = "0x1A625EC", VA = "0x1A625EC")]
		private static extern RESULT FMOD5_ChannelGroup_SetCallback(IntPtr channelgroup, CHANNELCONTROL_CALLBACK callback);

		[PreserveSig]
		[Token(Token = "0x6000475")]
		[Address(RVA = "0x1A626A8", Offset = "0x1A626A8", VA = "0x1A626A8")]
		private static extern RESULT FMOD5_ChannelGroup_IsPlaying(IntPtr channelgroup, out bool isplaying);

		[PreserveSig]
		[Token(Token = "0x6000476")]
		[Address(RVA = "0x1A62770", Offset = "0x1A62770", VA = "0x1A62770")]
		private static extern RESULT FMOD5_ChannelGroup_SetPan(IntPtr channelgroup, float pan);

		[PreserveSig]
		[Token(Token = "0x6000477")]
		[Address(RVA = "0x1A62824", Offset = "0x1A62824", VA = "0x1A62824")]
		private static extern RESULT FMOD5_ChannelGroup_SetMixLevelsOutput(IntPtr channelgroup, float frontleft, float frontright, float center, float lfe, float surroundleft, float surroundright, float backleft, float backright);

		[PreserveSig]
		[Token(Token = "0x6000478")]
		[Address(RVA = "0x1A62928", Offset = "0x1A62928", VA = "0x1A62928")]
		private static extern RESULT FMOD5_ChannelGroup_SetMixLevelsInput(IntPtr channelgroup, float[] levels, int numlevels);

		[PreserveSig]
		[Token(Token = "0x6000479")]
		[Address(RVA = "0x1A629EC", Offset = "0x1A629EC", VA = "0x1A629EC")]
		private static extern RESULT FMOD5_ChannelGroup_SetMixMatrix(IntPtr channelgroup, float[] matrix, int outchannels, int inchannels, int inchannel_hop);

		[PreserveSig]
		[Token(Token = "0x600047A")]
		[Address(RVA = "0x1A62AC8", Offset = "0x1A62AC8", VA = "0x1A62AC8")]
		private static extern RESULT FMOD5_ChannelGroup_GetMixMatrix(IntPtr channelgroup, float[] matrix, out int outchannels, out int inchannels, int inchannel_hop);

		[PreserveSig]
		[Token(Token = "0x600047B")]
		[Address(RVA = "0x1A62BA4", Offset = "0x1A62BA4", VA = "0x1A62BA4")]
		private static extern RESULT FMOD5_ChannelGroup_GetDSPClock(IntPtr channelgroup, out ulong dspclock, out ulong parentclock);

		[PreserveSig]
		[Token(Token = "0x600047C")]
		[Address(RVA = "0x1A62C64", Offset = "0x1A62C64", VA = "0x1A62C64")]
		private static extern RESULT FMOD5_ChannelGroup_SetDelay(IntPtr channelgroup, ulong dspclock_start, ulong dspclock_end, bool stopchannels);

		[PreserveSig]
		[Token(Token = "0x600047D")]
		[Address(RVA = "0x1A62D88", Offset = "0x1A62D88", VA = "0x1A62D88")]
		private static extern RESULT FMOD5_ChannelGroup_GetDelay(IntPtr channelgroup, out ulong dspclock_start, out ulong dspclock_end, IntPtr zero);

		[PreserveSig]
		[Token(Token = "0x600047E")]
		[Address(RVA = "0x1A62E54", Offset = "0x1A62E54", VA = "0x1A62E54")]
		private static extern RESULT FMOD5_ChannelGroup_GetDelay(IntPtr channelgroup, out ulong dspclock_start, out ulong dspclock_end, out bool stopchannels);

		[PreserveSig]
		[Token(Token = "0x600047F")]
		[Address(RVA = "0x1A62F34", Offset = "0x1A62F34", VA = "0x1A62F34")]
		private static extern RESULT FMOD5_ChannelGroup_AddFadePoint(IntPtr channelgroup, ulong dspclock, float volume);

		[PreserveSig]
		[Token(Token = "0x6000480")]
		[Address(RVA = "0x1A62FF8", Offset = "0x1A62FF8", VA = "0x1A62FF8")]
		private static extern RESULT FMOD5_ChannelGroup_SetFadePointRamp(IntPtr channelgroup, ulong dspclock, float volume);

		[PreserveSig]
		[Token(Token = "0x6000481")]
		[Address(RVA = "0x1A630BC", Offset = "0x1A630BC", VA = "0x1A630BC")]
		private static extern RESULT FMOD5_ChannelGroup_RemoveFadePoints(IntPtr channelgroup, ulong dspclock_start, ulong dspclock_end);

		[PreserveSig]
		[Token(Token = "0x6000482")]
		[Address(RVA = "0x1A63178", Offset = "0x1A63178", VA = "0x1A63178")]
		private static extern RESULT FMOD5_ChannelGroup_GetFadePoints(IntPtr channelgroup, ref uint numpoints, ulong[] point_dspclock, float[] point_volume);

		[PreserveSig]
		[Token(Token = "0x6000483")]
		[Address(RVA = "0x1A63250", Offset = "0x1A63250", VA = "0x1A63250")]
		private static extern RESULT FMOD5_ChannelGroup_GetDSP(IntPtr channelgroup, int index, out IntPtr dsp);

		[PreserveSig]
		[Token(Token = "0x6000484")]
		[Address(RVA = "0x1A6330C", Offset = "0x1A6330C", VA = "0x1A6330C")]
		private static extern RESULT FMOD5_ChannelGroup_AddDSP(IntPtr channelgroup, int index, IntPtr dsp);

		[PreserveSig]
		[Token(Token = "0x6000485")]
		[Address(RVA = "0x1A633C8", Offset = "0x1A633C8", VA = "0x1A633C8")]
		private static extern RESULT FMOD5_ChannelGroup_RemoveDSP(IntPtr channelgroup, IntPtr dsp);

		[PreserveSig]
		[Token(Token = "0x6000486")]
		[Address(RVA = "0x1A6347C", Offset = "0x1A6347C", VA = "0x1A6347C")]
		private static extern RESULT FMOD5_ChannelGroup_GetNumDSPs(IntPtr channelgroup, out int numdsps);

		[PreserveSig]
		[Token(Token = "0x6000487")]
		[Address(RVA = "0x1A63530", Offset = "0x1A63530", VA = "0x1A63530")]
		private static extern RESULT FMOD5_ChannelGroup_SetDSPIndex(IntPtr channelgroup, IntPtr dsp, int index);

		[PreserveSig]
		[Token(Token = "0x6000488")]
		[Address(RVA = "0x1A635EC", Offset = "0x1A635EC", VA = "0x1A635EC")]
		private static extern RESULT FMOD5_ChannelGroup_GetDSPIndex(IntPtr channelgroup, IntPtr dsp, out int index);

		[PreserveSig]
		[Token(Token = "0x6000489")]
		[Address(RVA = "0x1A636A8", Offset = "0x1A636A8", VA = "0x1A636A8")]
		private static extern RESULT FMOD5_ChannelGroup_Set3DAttributes(IntPtr channelgroup, ref VECTOR pos, ref VECTOR vel);

		[PreserveSig]
		[Token(Token = "0x600048A")]
		[Address(RVA = "0x1A63764", Offset = "0x1A63764", VA = "0x1A63764")]
		private static extern RESULT FMOD5_ChannelGroup_Get3DAttributes(IntPtr channelgroup, out VECTOR pos, out VECTOR vel);

		[PreserveSig]
		[Token(Token = "0x600048B")]
		[Address(RVA = "0x1A63820", Offset = "0x1A63820", VA = "0x1A63820")]
		private static extern RESULT FMOD5_ChannelGroup_Set3DMinMaxDistance(IntPtr channelgroup, float mindistance, float maxdistance);

		[PreserveSig]
		[Token(Token = "0x600048C")]
		[Address(RVA = "0x1A638DC", Offset = "0x1A638DC", VA = "0x1A638DC")]
		private static extern RESULT FMOD5_ChannelGroup_Get3DMinMaxDistance(IntPtr channelgroup, out float mindistance, out float maxdistance);

		[PreserveSig]
		[Token(Token = "0x600048D")]
		[Address(RVA = "0x1A63998", Offset = "0x1A63998", VA = "0x1A63998")]
		private static extern RESULT FMOD5_ChannelGroup_Set3DConeSettings(IntPtr channelgroup, float insideconeangle, float outsideconeangle, float outsidevolume);

		[PreserveSig]
		[Token(Token = "0x600048E")]
		[Address(RVA = "0x1A63A64", Offset = "0x1A63A64", VA = "0x1A63A64")]
		private static extern RESULT FMOD5_ChannelGroup_Get3DConeSettings(IntPtr channelgroup, out float insideconeangle, out float outsideconeangle, out float outsidevolume);

		[PreserveSig]
		[Token(Token = "0x600048F")]
		[Address(RVA = "0x1A63B30", Offset = "0x1A63B30", VA = "0x1A63B30")]
		private static extern RESULT FMOD5_ChannelGroup_Set3DConeOrientation(IntPtr channelgroup, ref VECTOR orientation);

		[PreserveSig]
		[Token(Token = "0x6000490")]
		[Address(RVA = "0x1A63BE4", Offset = "0x1A63BE4", VA = "0x1A63BE4")]
		private static extern RESULT FMOD5_ChannelGroup_Get3DConeOrientation(IntPtr channelgroup, out VECTOR orientation);

		[PreserveSig]
		[Token(Token = "0x6000491")]
		[Address(RVA = "0x1A63C98", Offset = "0x1A63C98", VA = "0x1A63C98")]
		private static extern RESULT FMOD5_ChannelGroup_Set3DCustomRolloff(IntPtr channelgroup, ref VECTOR points, int numpoints);

		[PreserveSig]
		[Token(Token = "0x6000492")]
		[Address(RVA = "0x1A63D54", Offset = "0x1A63D54", VA = "0x1A63D54")]
		private static extern RESULT FMOD5_ChannelGroup_Get3DCustomRolloff(IntPtr channelgroup, out IntPtr points, out int numpoints);

		[PreserveSig]
		[Token(Token = "0x6000493")]
		[Address(RVA = "0x1A63E10", Offset = "0x1A63E10", VA = "0x1A63E10")]
		private static extern RESULT FMOD5_ChannelGroup_Set3DOcclusion(IntPtr channelgroup, float directocclusion, float reverbocclusion);

		[PreserveSig]
		[Token(Token = "0x6000494")]
		[Address(RVA = "0x1A63ECC", Offset = "0x1A63ECC", VA = "0x1A63ECC")]
		private static extern RESULT FMOD5_ChannelGroup_Get3DOcclusion(IntPtr channelgroup, out float directocclusion, out float reverbocclusion);

		[PreserveSig]
		[Token(Token = "0x6000495")]
		[Address(RVA = "0x1A63F88", Offset = "0x1A63F88", VA = "0x1A63F88")]
		private static extern RESULT FMOD5_ChannelGroup_Set3DSpread(IntPtr channelgroup, float angle);

		[PreserveSig]
		[Token(Token = "0x6000496")]
		[Address(RVA = "0x1A6403C", Offset = "0x1A6403C", VA = "0x1A6403C")]
		private static extern RESULT FMOD5_ChannelGroup_Get3DSpread(IntPtr channelgroup, out float angle);

		[PreserveSig]
		[Token(Token = "0x6000497")]
		[Address(RVA = "0x1A640F0", Offset = "0x1A640F0", VA = "0x1A640F0")]
		private static extern RESULT FMOD5_ChannelGroup_Set3DLevel(IntPtr channelgroup, float level);

		[PreserveSig]
		[Token(Token = "0x6000498")]
		[Address(RVA = "0x1A641A4", Offset = "0x1A641A4", VA = "0x1A641A4")]
		private static extern RESULT FMOD5_ChannelGroup_Get3DLevel(IntPtr channelgroup, out float level);

		[PreserveSig]
		[Token(Token = "0x6000499")]
		[Address(RVA = "0x1A64258", Offset = "0x1A64258", VA = "0x1A64258")]
		private static extern RESULT FMOD5_ChannelGroup_Set3DDopplerLevel(IntPtr channelgroup, float level);

		[PreserveSig]
		[Token(Token = "0x600049A")]
		[Address(RVA = "0x1A6430C", Offset = "0x1A6430C", VA = "0x1A6430C")]
		private static extern RESULT FMOD5_ChannelGroup_Get3DDopplerLevel(IntPtr channelgroup, out float level);

		[PreserveSig]
		[Token(Token = "0x600049B")]
		[Address(RVA = "0x1A643C4", Offset = "0x1A643C4", VA = "0x1A643C4")]
		private static extern RESULT FMOD5_ChannelGroup_Set3DDistanceFilter(IntPtr channelgroup, bool custom, float customLevel, float centerFreq);

		[PreserveSig]
		[Token(Token = "0x600049C")]
		[Address(RVA = "0x1A64490", Offset = "0x1A64490", VA = "0x1A64490")]
		private static extern RESULT FMOD5_ChannelGroup_Get3DDistanceFilter(IntPtr channelgroup, out bool custom, out float customLevel, out float centerFreq);

		[PreserveSig]
		[Token(Token = "0x600049D")]
		[Address(RVA = "0x1A64570", Offset = "0x1A64570", VA = "0x1A64570")]
		private static extern RESULT FMOD5_ChannelGroup_SetUserData(IntPtr channelgroup, IntPtr userdata);

		[PreserveSig]
		[Token(Token = "0x600049E")]
		[Address(RVA = "0x1A64624", Offset = "0x1A64624", VA = "0x1A64624")]
		private static extern RESULT FMOD5_ChannelGroup_GetUserData(IntPtr channelgroup, out IntPtr userdata);

		[Token(Token = "0x600049F")]
		[Address(RVA = "0x9C9498", Offset = "0x9C9498", VA = "0x9C9498")]
		public bool hasHandle()
		{
			return default(bool);
		}

		[Token(Token = "0x60004A0")]
		[Address(RVA = "0x9C94A0", Offset = "0x9C94A0", VA = "0x9C94A0")]
		public void clearHandle()
		{
		}
	}
	[Token(Token = "0x2000073")]
	public struct SoundGroup
	{
		[Token(Token = "0x4000353")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public IntPtr handle;

		[Token(Token = "0x60004A1")]
		[Address(RVA = "0x9C7C10", Offset = "0x9C7C10", VA = "0x9C7C10")]
		public RESULT release()
		{
			return default(RESULT);
		}

		[Token(Token = "0x60004A2")]
		[Address(RVA = "0x9C7C18", Offset = "0x9C7C18", VA = "0x9C7C18")]
		public RESULT getSystemObject(out System system)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60004A3")]
		[Address(RVA = "0x9C7C20", Offset = "0x9C7C20", VA = "0x9C7C20")]
		public RESULT setMaxAudible(int maxaudible)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60004A4")]
		[Address(RVA = "0x9C7C28", Offset = "0x9C7C28", VA = "0x9C7C28")]
		public RESULT getMaxAudible(out int maxaudible)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60004A5")]
		[Address(RVA = "0x9C7C30", Offset = "0x9C7C30", VA = "0x9C7C30")]
		public RESULT setMaxAudibleBehavior(SOUNDGROUP_BEHAVIOR behavior)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60004A6")]
		[Address(RVA = "0x9C7C38", Offset = "0x9C7C38", VA = "0x9C7C38")]
		public RESULT getMaxAudibleBehavior(out SOUNDGROUP_BEHAVIOR behavior)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60004A7")]
		[Address(RVA = "0x9C7C40", Offset = "0x9C7C40", VA = "0x9C7C40")]
		public RESULT setMuteFadeSpeed(float speed)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60004A8")]
		[Address(RVA = "0x9C7C48", Offset = "0x9C7C48", VA = "0x9C7C48")]
		public RESULT getMuteFadeSpeed(out float speed)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60004A9")]
		[Address(RVA = "0x9C7C50", Offset = "0x9C7C50", VA = "0x9C7C50")]
		public RESULT setVolume(float volume)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60004AA")]
		[Address(RVA = "0x9C7C58", Offset = "0x9C7C58", VA = "0x9C7C58")]
		public RESULT getVolume(out float volume)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60004AB")]
		[Address(RVA = "0x9C7C60", Offset = "0x9C7C60", VA = "0x9C7C60")]
		public RESULT stop()
		{
			return default(RESULT);
		}

		[Token(Token = "0x60004AC")]
		[Address(RVA = "0x9C7C68", Offset = "0x9C7C68", VA = "0x9C7C68")]
		public RESULT getName(out string name, int namelen)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60004AD")]
		[Address(RVA = "0x9C7C70", Offset = "0x9C7C70", VA = "0x9C7C70")]
		public RESULT getNumSounds(out int numsounds)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60004AE")]
		[Address(RVA = "0x9C7C78", Offset = "0x9C7C78", VA = "0x9C7C78")]
		public RESULT getSound(int index, out Sound sound)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60004AF")]
		[Address(RVA = "0x9C7C80", Offset = "0x9C7C80", VA = "0x9C7C80")]
		public RESULT getNumPlaying(out int numplaying)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60004B0")]
		[Address(RVA = "0x9C7C88", Offset = "0x9C7C88", VA = "0x9C7C88")]
		public RESULT setUserData(IntPtr userdata)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60004B1")]
		[Address(RVA = "0x9C7C90", Offset = "0x9C7C90", VA = "0x9C7C90")]
		public RESULT getUserData(out IntPtr userdata)
		{
			return default(RESULT);
		}

		[PreserveSig]
		[Token(Token = "0x60004B2")]
		[Address(RVA = "0x1A4D8D4", Offset = "0x1A4D8D4", VA = "0x1A4D8D4")]
		private static extern RESULT FMOD5_SoundGroup_Release(IntPtr soundgroup);

		[PreserveSig]
		[Token(Token = "0x60004B3")]
		[Address(RVA = "0x1A4D978", Offset = "0x1A4D978", VA = "0x1A4D978")]
		private static extern RESULT FMOD5_SoundGroup_GetSystemObject(IntPtr soundgroup, out IntPtr system);

		[PreserveSig]
		[Token(Token = "0x60004B4")]
		[Address(RVA = "0x1A4DA2C", Offset = "0x1A4DA2C", VA = "0x1A4DA2C")]
		private static extern RESULT FMOD5_SoundGroup_SetMaxAudible(IntPtr soundgroup, int maxaudible);

		[PreserveSig]
		[Token(Token = "0x60004B5")]
		[Address(RVA = "0x1A4DAE0", Offset = "0x1A4DAE0", VA = "0x1A4DAE0")]
		private static extern RESULT FMOD5_SoundGroup_GetMaxAudible(IntPtr soundgroup, out int maxaudible);

		[PreserveSig]
		[Token(Token = "0x60004B6")]
		[Address(RVA = "0x1A4DB94", Offset = "0x1A4DB94", VA = "0x1A4DB94")]
		private static extern RESULT FMOD5_SoundGroup_SetMaxAudibleBehavior(IntPtr soundgroup, SOUNDGROUP_BEHAVIOR behavior);

		[PreserveSig]
		[Token(Token = "0x60004B7")]
		[Address(RVA = "0x1A4DC48", Offset = "0x1A4DC48", VA = "0x1A4DC48")]
		private static extern RESULT FMOD5_SoundGroup_GetMaxAudibleBehavior(IntPtr soundgroup, out SOUNDGROUP_BEHAVIOR behavior);

		[PreserveSig]
		[Token(Token = "0x60004B8")]
		[Address(RVA = "0x1A4DCFC", Offset = "0x1A4DCFC", VA = "0x1A4DCFC")]
		private static extern RESULT FMOD5_SoundGroup_SetMuteFadeSpeed(IntPtr soundgroup, float speed);

		[PreserveSig]
		[Token(Token = "0x60004B9")]
		[Address(RVA = "0x1A4DDB0", Offset = "0x1A4DDB0", VA = "0x1A4DDB0")]
		private static extern RESULT FMOD5_SoundGroup_GetMuteFadeSpeed(IntPtr soundgroup, out float speed);

		[PreserveSig]
		[Token(Token = "0x60004BA")]
		[Address(RVA = "0x1A4DE64", Offset = "0x1A4DE64", VA = "0x1A4DE64")]
		private static extern RESULT FMOD5_SoundGroup_SetVolume(IntPtr soundgroup, float volume);

		[PreserveSig]
		[Token(Token = "0x60004BB")]
		[Address(RVA = "0x1A4DF18", Offset = "0x1A4DF18", VA = "0x1A4DF18")]
		private static extern RESULT FMOD5_SoundGroup_GetVolume(IntPtr soundgroup, out float volume);

		[PreserveSig]
		[Token(Token = "0x60004BC")]
		[Address(RVA = "0x1A4DFCC", Offset = "0x1A4DFCC", VA = "0x1A4DFCC")]
		private static extern RESULT FMOD5_SoundGroup_Stop(IntPtr soundgroup);

		[PreserveSig]
		[Token(Token = "0x60004BD")]
		[Address(RVA = "0x1A4E230", Offset = "0x1A4E230", VA = "0x1A4E230")]
		private static extern RESULT FMOD5_SoundGroup_GetName(IntPtr soundgroup, IntPtr name, int namelen);

		[PreserveSig]
		[Token(Token = "0x60004BE")]
		[Address(RVA = "0x1A4E2EC", Offset = "0x1A4E2EC", VA = "0x1A4E2EC")]
		private static extern RESULT FMOD5_SoundGroup_GetNumSounds(IntPtr soundgroup, out int numsounds);

		[PreserveSig]
		[Token(Token = "0x60004BF")]
		[Address(RVA = "0x1A4E3A0", Offset = "0x1A4E3A0", VA = "0x1A4E3A0")]
		private static extern RESULT FMOD5_SoundGroup_GetSound(IntPtr soundgroup, int index, out IntPtr sound);

		[PreserveSig]
		[Token(Token = "0x60004C0")]
		[Address(RVA = "0x1A4E45C", Offset = "0x1A4E45C", VA = "0x1A4E45C")]
		private static extern RESULT FMOD5_SoundGroup_GetNumPlaying(IntPtr soundgroup, out int numplaying);

		[PreserveSig]
		[Token(Token = "0x60004C1")]
		[Address(RVA = "0x1A4E510", Offset = "0x1A4E510", VA = "0x1A4E510")]
		private static extern RESULT FMOD5_SoundGroup_SetUserData(IntPtr soundgroup, IntPtr userdata);

		[PreserveSig]
		[Token(Token = "0x60004C2")]
		[Address(RVA = "0x1A4E5C4", Offset = "0x1A4E5C4", VA = "0x1A4E5C4")]
		private static extern RESULT FMOD5_SoundGroup_GetUserData(IntPtr soundgroup, out IntPtr userdata);

		[Token(Token = "0x60004C3")]
		[Address(RVA = "0x9C7C98", Offset = "0x9C7C98", VA = "0x9C7C98")]
		public bool hasHandle()
		{
			return default(bool);
		}

		[Token(Token = "0x60004C4")]
		[Address(RVA = "0x9C7CA0", Offset = "0x9C7CA0", VA = "0x9C7CA0")]
		public void clearHandle()
		{
		}
	}
	[Token(Token = "0x2000074")]
	public struct DSP
	{
		[Token(Token = "0x4000354")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public IntPtr handle;

		[Token(Token = "0x60004C5")]
		[Address(RVA = "0x9C9504", Offset = "0x9C9504", VA = "0x9C9504")]
		public RESULT release()
		{
			return default(RESULT);
		}

		[Token(Token = "0x60004C6")]
		[Address(RVA = "0x9C950C", Offset = "0x9C950C", VA = "0x9C950C")]
		public RESULT getSystemObject(out System system)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60004C7")]
		[Address(RVA = "0x9C9514", Offset = "0x9C9514", VA = "0x9C9514")]
		public RESULT addInput(DSP input)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60004C8")]
		[Address(RVA = "0x9C951C", Offset = "0x9C951C", VA = "0x9C951C")]
		public RESULT addInput(DSP input, out DSPConnection connection, DSPCONNECTION_TYPE type = DSPCONNECTION_TYPE.STANDARD)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60004C9")]
		[Address(RVA = "0x9C9524", Offset = "0x9C9524", VA = "0x9C9524")]
		public RESULT disconnectFrom(DSP target, DSPConnection connection)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60004CA")]
		[Address(RVA = "0x9C952C", Offset = "0x9C952C", VA = "0x9C952C")]
		public RESULT disconnectAll(bool inputs, bool outputs)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60004CB")]
		[Address(RVA = "0x9C953C", Offset = "0x9C953C", VA = "0x9C953C")]
		public RESULT getNumInputs(out int numinputs)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60004CC")]
		[Address(RVA = "0x9C9544", Offset = "0x9C9544", VA = "0x9C9544")]
		public RESULT getNumOutputs(out int numoutputs)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60004CD")]
		[Address(RVA = "0x9C954C", Offset = "0x9C954C", VA = "0x9C954C")]
		public RESULT getInput(int index, out DSP input, out DSPConnection inputconnection)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60004CE")]
		[Address(RVA = "0x9C9554", Offset = "0x9C9554", VA = "0x9C9554")]
		public RESULT getOutput(int index, out DSP output, out DSPConnection outputconnection)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60004CF")]
		[Address(RVA = "0x9C955C", Offset = "0x9C955C", VA = "0x9C955C")]
		public RESULT setActive(bool active)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60004D0")]
		[Address(RVA = "0x9C9568", Offset = "0x9C9568", VA = "0x9C9568")]
		public RESULT getActive(out bool active)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60004D1")]
		[Address(RVA = "0x9C9570", Offset = "0x9C9570", VA = "0x9C9570")]
		public RESULT setBypass(bool bypass)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60004D2")]
		[Address(RVA = "0x9C957C", Offset = "0x9C957C", VA = "0x9C957C")]
		public RESULT getBypass(out bool bypass)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60004D3")]
		[Address(RVA = "0x9C9584", Offset = "0x9C9584", VA = "0x9C9584")]
		public RESULT setWetDryMix(float prewet, float postwet, float dry)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60004D4")]
		[Address(RVA = "0x9C958C", Offset = "0x9C958C", VA = "0x9C958C")]
		public RESULT getWetDryMix(out float prewet, out float postwet, out float dry)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60004D5")]
		[Address(RVA = "0x9C9594", Offset = "0x9C9594", VA = "0x9C9594")]
		public RESULT setChannelFormat(CHANNELMASK channelmask, int numchannels, SPEAKERMODE source_speakermode)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60004D6")]
		[Address(RVA = "0x9C959C", Offset = "0x9C959C", VA = "0x9C959C")]
		public RESULT getChannelFormat(out CHANNELMASK channelmask, out int numchannels, out SPEAKERMODE source_speakermode)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60004D7")]
		[Address(RVA = "0x9C95A4", Offset = "0x9C95A4", VA = "0x9C95A4")]
		public RESULT getOutputChannelFormat(CHANNELMASK inmask, int inchannels, SPEAKERMODE inspeakermode, out CHANNELMASK outmask, out int outchannels, out SPEAKERMODE outspeakermode)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60004D8")]
		[Address(RVA = "0x9C95AC", Offset = "0x9C95AC", VA = "0x9C95AC")]
		public RESULT reset()
		{
			return default(RESULT);
		}

		[Token(Token = "0x60004D9")]
		[Address(RVA = "0x9C95B4", Offset = "0x9C95B4", VA = "0x9C95B4")]
		public RESULT setParameterFloat(int index, float value)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60004DA")]
		[Address(RVA = "0x9C95BC", Offset = "0x9C95BC", VA = "0x9C95BC")]
		public RESULT setParameterInt(int index, int value)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60004DB")]
		[Address(RVA = "0x9C95C4", Offset = "0x9C95C4", VA = "0x9C95C4")]
		public RESULT setParameterBool(int index, bool value)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60004DC")]
		[Address(RVA = "0x9C95D0", Offset = "0x9C95D0", VA = "0x9C95D0")]
		public RESULT setParameterData(int index, byte[] data)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60004DD")]
		[Address(RVA = "0x9C95D8", Offset = "0x9C95D8", VA = "0x9C95D8")]
		public RESULT getParameterFloat(int index, out float value)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60004DE")]
		[Address(RVA = "0x9C95E0", Offset = "0x9C95E0", VA = "0x9C95E0")]
		public RESULT getParameterInt(int index, out int value)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60004DF")]
		[Address(RVA = "0x9C95E8", Offset = "0x9C95E8", VA = "0x9C95E8")]
		public RESULT getParameterBool(int index, out bool value)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60004E0")]
		[Address(RVA = "0x9C95F0", Offset = "0x9C95F0", VA = "0x9C95F0")]
		public RESULT getParameterData(int index, out IntPtr data, out uint length)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60004E1")]
		[Address(RVA = "0x9C95F8", Offset = "0x9C95F8", VA = "0x9C95F8")]
		public RESULT getNumParameters(out int numparams)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60004E2")]
		[Address(RVA = "0x9C9600", Offset = "0x9C9600", VA = "0x9C9600")]
		public RESULT getParameterInfo(int index, out DSP_PARAMETER_DESC desc)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60004E3")]
		[Address(RVA = "0x9C9608", Offset = "0x9C9608", VA = "0x9C9608")]
		public RESULT getDataParameterIndex(int datatype, out int index)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60004E4")]
		[Address(RVA = "0x9C9610", Offset = "0x9C9610", VA = "0x9C9610")]
		public RESULT showConfigDialog(IntPtr hwnd, bool show)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60004E5")]
		[Address(RVA = "0x9C961C", Offset = "0x9C961C", VA = "0x9C961C")]
		public RESULT getInfo(out string name, out uint version, out int channels, out int configwidth, out int configheight)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60004E6")]
		[Address(RVA = "0x9C9624", Offset = "0x9C9624", VA = "0x9C9624")]
		public RESULT getInfo(out uint version, out int channels, out int configwidth, out int configheight)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60004E7")]
		[Address(RVA = "0x9C962C", Offset = "0x9C962C", VA = "0x9C962C")]
		public RESULT getType(out DSP_TYPE type)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60004E8")]
		[Address(RVA = "0x9C9634", Offset = "0x9C9634", VA = "0x9C9634")]
		public RESULT getIdle(out bool idle)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60004E9")]
		[Address(RVA = "0x9C963C", Offset = "0x9C963C", VA = "0x9C963C")]
		public RESULT setUserData(IntPtr userdata)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60004EA")]
		[Address(RVA = "0x9C9644", Offset = "0x9C9644", VA = "0x9C9644")]
		public RESULT getUserData(out IntPtr userdata)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60004EB")]
		[Address(RVA = "0x9C964C", Offset = "0x9C964C", VA = "0x9C964C")]
		public RESULT setMeteringEnabled(bool inputEnabled, bool outputEnabled)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60004EC")]
		[Address(RVA = "0x9C965C", Offset = "0x9C965C", VA = "0x9C965C")]
		public RESULT getMeteringEnabled(out bool inputEnabled, out bool outputEnabled)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60004ED")]
		[Address(RVA = "0x9C9664", Offset = "0x9C9664", VA = "0x9C9664")]
		public RESULT getMeteringInfo(IntPtr zero, out DSP_METERING_INFO outputInfo)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60004EE")]
		[Address(RVA = "0x9C966C", Offset = "0x9C966C", VA = "0x9C966C")]
		public RESULT getMeteringInfo(out DSP_METERING_INFO inputInfo, IntPtr zero)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60004EF")]
		[Address(RVA = "0x9C9674", Offset = "0x9C9674", VA = "0x9C9674")]
		public RESULT getMeteringInfo(out DSP_METERING_INFO inputInfo, out DSP_METERING_INFO outputInfo)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60004F0")]
		[Address(RVA = "0x9C967C", Offset = "0x9C967C", VA = "0x9C967C")]
		public RESULT getCPUUsage(out uint exclusive, out uint inclusive)
		{
			return default(RESULT);
		}

		[PreserveSig]
		[Token(Token = "0x60004F1")]
		[Address(RVA = "0x1A64D88", Offset = "0x1A64D88", VA = "0x1A64D88")]
		private static extern RESULT FMOD5_DSP_Release(IntPtr dsp);

		[PreserveSig]
		[Token(Token = "0x60004F2")]
		[Address(RVA = "0x1A64E2C", Offset = "0x1A64E2C", VA = "0x1A64E2C")]
		private static extern RESULT FMOD5_DSP_GetSystemObject(IntPtr dsp, out IntPtr system);

		[PreserveSig]
		[Token(Token = "0x60004F3")]
		[Address(RVA = "0x1A64F34", Offset = "0x1A64F34", VA = "0x1A64F34")]
		private static extern RESULT FMOD5_DSP_AddInput(IntPtr dsp, IntPtr input, IntPtr zero, DSPCONNECTION_TYPE type);

		[PreserveSig]
		[Token(Token = "0x60004F4")]
		[Address(RVA = "0x1A65000", Offset = "0x1A65000", VA = "0x1A65000")]
		private static extern RESULT FMOD5_DSP_AddInput(IntPtr dsp, IntPtr input, out IntPtr connection, DSPCONNECTION_TYPE type);

		[PreserveSig]
		[Token(Token = "0x60004F5")]
		[Address(RVA = "0x1A650CC", Offset = "0x1A650CC", VA = "0x1A650CC")]
		private static extern RESULT FMOD5_DSP_DisconnectFrom(IntPtr dsp, IntPtr target, IntPtr connection);

		[PreserveSig]
		[Token(Token = "0x60004F6")]
		[Address(RVA = "0x1A6518C", Offset = "0x1A6518C", VA = "0x1A6518C")]
		private static extern RESULT FMOD5_DSP_DisconnectAll(IntPtr dsp, bool inputs, bool outputs);

		[PreserveSig]
		[Token(Token = "0x60004F7")]
		[Address(RVA = "0x1A65248", Offset = "0x1A65248", VA = "0x1A65248")]
		private static extern RESULT FMOD5_DSP_GetNumInputs(IntPtr dsp, out int numinputs);

		[PreserveSig]
		[Token(Token = "0x60004F8")]
		[Address(RVA = "0x1A652FC", Offset = "0x1A652FC", VA = "0x1A652FC")]
		private static extern RESULT FMOD5_DSP_GetNumOutputs(IntPtr dsp, out int numoutputs);

		[PreserveSig]
		[Token(Token = "0x60004F9")]
		[Address(RVA = "0x1A653B0", Offset = "0x1A653B0", VA = "0x1A653B0")]
		private static extern RESULT FMOD5_DSP_GetInput(IntPtr dsp, int index, out IntPtr input, out IntPtr inputconnection);

		[PreserveSig]
		[Token(Token = "0x60004FA")]
		[Address(RVA = "0x1A6547C", Offset = "0x1A6547C", VA = "0x1A6547C")]
		private static extern RESULT FMOD5_DSP_GetOutput(IntPtr dsp, int index, out IntPtr output, out IntPtr outputconnection);

		[PreserveSig]
		[Token(Token = "0x60004FB")]
		[Address(RVA = "0x1A6554C", Offset = "0x1A6554C", VA = "0x1A6554C")]
		private static extern RESULT FMOD5_DSP_SetActive(IntPtr dsp, bool active);

		[PreserveSig]
		[Token(Token = "0x60004FC")]
		[Address(RVA = "0x1A65600", Offset = "0x1A65600", VA = "0x1A65600")]
		private static extern RESULT FMOD5_DSP_GetActive(IntPtr dsp, out bool active);

		[PreserveSig]
		[Token(Token = "0x60004FD")]
		[Address(RVA = "0x1A656CC", Offset = "0x1A656CC", VA = "0x1A656CC")]
		private static extern RESULT FMOD5_DSP_SetBypass(IntPtr dsp, bool bypass);

		[PreserveSig]
		[Token(Token = "0x60004FE")]
		[Address(RVA = "0x1A65780", Offset = "0x1A65780", VA = "0x1A65780")]
		private static extern RESULT FMOD5_DSP_GetBypass(IntPtr dsp, out bool bypass);

		[PreserveSig]
		[Token(Token = "0x60004FF")]
		[Address(RVA = "0x1A65848", Offset = "0x1A65848", VA = "0x1A65848")]
		private static extern RESULT FMOD5_DSP_SetWetDryMix(IntPtr dsp, float prewet, float postwet, float dry);

		[PreserveSig]
		[Token(Token = "0x6000500")]
		[Address(RVA = "0x1A65914", Offset = "0x1A65914", VA = "0x1A65914")]
		private static extern RESULT FMOD5_DSP_GetWetDryMix(IntPtr dsp, out float prewet, out float postwet, out float dry);

		[PreserveSig]
		[Token(Token = "0x6000501")]
		[Address(RVA = "0x1A659E0", Offset = "0x1A659E0", VA = "0x1A659E0")]
		private static extern RESULT FMOD5_DSP_SetChannelFormat(IntPtr dsp, CHANNELMASK channelmask, int numchannels, SPEAKERMODE source_speakermode);

		[PreserveSig]
		[Token(Token = "0x6000502")]
		[Address(RVA = "0x1A65AAC", Offset = "0x1A65AAC", VA = "0x1A65AAC")]
		private static extern RESULT FMOD5_DSP_GetChannelFormat(IntPtr dsp, out CHANNELMASK channelmask, out int numchannels, out SPEAKERMODE source_speakermode);

		[PreserveSig]
		[Token(Token = "0x6000503")]
		[Address(RVA = "0x1A65B78", Offset = "0x1A65B78", VA = "0x1A65B78")]
		private static extern RESULT FMOD5_DSP_GetOutputChannelFormat(IntPtr dsp, CHANNELMASK inmask, int inchannels, SPEAKERMODE inspeakermode, out CHANNELMASK outmask, out int outchannels, out SPEAKERMODE outspeakermode);

		[PreserveSig]
		[Token(Token = "0x6000504")]
		[Address(RVA = "0x1A65C64", Offset = "0x1A65C64", VA = "0x1A65C64")]
		private static extern RESULT FMOD5_DSP_Reset(IntPtr dsp);

		[PreserveSig]
		[Token(Token = "0x6000505")]
		[Address(RVA = "0x1A65D08", Offset = "0x1A65D08", VA = "0x1A65D08")]
		private static extern RESULT FMOD5_DSP_SetParameterFloat(IntPtr dsp, int index, float value);

		[PreserveSig]
		[Token(Token = "0x6000506")]
		[Address(RVA = "0x1A65DCC", Offset = "0x1A65DCC", VA = "0x1A65DCC")]
		private static extern RESULT FMOD5_DSP_SetParameterInt(IntPtr dsp, int index, int value);

		[PreserveSig]
		[Token(Token = "0x6000507")]
		[Address(RVA = "0x1A65E8C", Offset = "0x1A65E8C", VA = "0x1A65E8C")]
		private static extern RESULT FMOD5_DSP_SetParameterBool(IntPtr dsp, int index, bool value);

		[PreserveSig]
		[Token(Token = "0x6000508")]
		[Address(RVA = "0x1A65FEC", Offset = "0x1A65FEC", VA = "0x1A65FEC")]
		private static extern RESULT FMOD5_DSP_SetParameterData(IntPtr dsp, int index, IntPtr data, uint length);

		[PreserveSig]
		[Token(Token = "0x6000509")]
		[Address(RVA = "0x1A66114", Offset = "0x1A66114", VA = "0x1A66114")]
		private static extern RESULT FMOD5_DSP_GetParameterFloat(IntPtr dsp, int index, out float value, IntPtr valuestr, int valuestrlen);

		[PreserveSig]
		[Token(Token = "0x600050A")]
		[Address(RVA = "0x1A66244", Offset = "0x1A66244", VA = "0x1A66244")]
		private static extern RESULT FMOD5_DSP_GetParameterInt(IntPtr dsp, int index, out int value, IntPtr valuestr, int valuestrlen);

		[PreserveSig]
		[Token(Token = "0x600050B")]
		[Address(RVA = "0x1A66374", Offset = "0x1A66374", VA = "0x1A66374")]
		private static extern RESULT FMOD5_DSP_GetParameterBool(IntPtr dsp, int index, out bool value, IntPtr valuestr, int valuestrlen);

		[PreserveSig]
		[Token(Token = "0x600050C")]
		[Address(RVA = "0x1A664C8", Offset = "0x1A664C8", VA = "0x1A664C8")]
		private static extern RESULT FMOD5_DSP_GetParameterData(IntPtr dsp, int index, out IntPtr data, out uint length, IntPtr valuestr, int valuestrlen);

		[PreserveSig]
		[Token(Token = "0x600050D")]
		[Address(RVA = "0x1A665AC", Offset = "0x1A665AC", VA = "0x1A665AC")]
		private static extern RESULT FMOD5_DSP_GetNumParameters(IntPtr dsp, out int numparams);

		[PreserveSig]
		[Token(Token = "0x600050E")]
		[Address(RVA = "0x1A66660", Offset = "0x1A66660", VA = "0x1A66660")]
		private static extern RESULT FMOD5_DSP_GetParameterInfo(IntPtr dsp, int index, out DSP_PARAMETER_DESC desc);

		[PreserveSig]
		[Token(Token = "0x600050F")]
		[Address(RVA = "0x1A66770", Offset = "0x1A66770", VA = "0x1A66770")]
		private static extern RESULT FMOD5_DSP_GetDataParameterIndex(IntPtr dsp, int datatype, out int index);

		[PreserveSig]
		[Token(Token = "0x6000510")]
		[Address(RVA = "0x1A66830", Offset = "0x1A66830", VA = "0x1A66830")]
		private static extern RESULT FMOD5_DSP_ShowConfigDialog(IntPtr dsp, IntPtr hwnd, bool show);

		[PreserveSig]
		[Token(Token = "0x6000511")]
		[Address(RVA = "0x1A66ACC", Offset = "0x1A66ACC", VA = "0x1A66ACC")]
		private static extern RESULT FMOD5_DSP_GetInfo(IntPtr dsp, IntPtr name, out uint version, out int channels, out int configwidth, out int configheight);

		[PreserveSig]
		[Token(Token = "0x6000512")]
		[Address(RVA = "0x1A66C28", Offset = "0x1A66C28", VA = "0x1A66C28")]
		private static extern RESULT FMOD5_DSP_GetType(IntPtr dsp, out DSP_TYPE type);

		[PreserveSig]
		[Token(Token = "0x6000513")]
		[Address(RVA = "0x1A66CDC", Offset = "0x1A66CDC", VA = "0x1A66CDC")]
		private static extern RESULT FMOD5_DSP_GetIdle(IntPtr dsp, out bool idle);

		[PreserveSig]
		[Token(Token = "0x6000514")]
		[Address(RVA = "0x1A66DA4", Offset = "0x1A66DA4", VA = "0x1A66DA4")]
		private static extern RESULT FMOD5_DSP_SetUserData(IntPtr dsp, IntPtr userdata);

		[PreserveSig]
		[Token(Token = "0x6000515")]
		[Address(RVA = "0x1A66E58", Offset = "0x1A66E58", VA = "0x1A66E58")]
		private static extern RESULT FMOD5_DSP_GetUserData(IntPtr dsp, out IntPtr userdata);

		[PreserveSig]
		[Token(Token = "0x6000516")]
		[Address(RVA = "0x1A66F14", Offset = "0x1A66F14", VA = "0x1A66F14")]
		public static extern RESULT FMOD5_DSP_SetMeteringEnabled(IntPtr dsp, bool inputEnabled, bool outputEnabled);

		[PreserveSig]
		[Token(Token = "0x6000517")]
		[Address(RVA = "0x1A66FD0", Offset = "0x1A66FD0", VA = "0x1A66FD0")]
		public static extern RESULT FMOD5_DSP_GetMeteringEnabled(IntPtr dsp, out bool inputEnabled, out bool outputEnabled);

		[PreserveSig]
		[Token(Token = "0x6000518")]
		[Address(RVA = "0x1A670B0", Offset = "0x1A670B0", VA = "0x1A670B0")]
		public static extern RESULT FMOD5_DSP_GetMeteringInfo(IntPtr dsp, IntPtr zero, out DSP_METERING_INFO outputInfo);

		[PreserveSig]
		[Token(Token = "0x6000519")]
		[Address(RVA = "0x1A671B4", Offset = "0x1A671B4", VA = "0x1A671B4")]
		public static extern RESULT FMOD5_DSP_GetMeteringInfo(IntPtr dsp, out DSP_METERING_INFO inputInfo, IntPtr zero);

		[PreserveSig]
		[Token(Token = "0x600051A")]
		[Address(RVA = "0x1A672B8", Offset = "0x1A672B8", VA = "0x1A672B8")]
		public static extern RESULT FMOD5_DSP_GetMeteringInfo(IntPtr dsp, out DSP_METERING_INFO inputInfo, out DSP_METERING_INFO outputInfo);

		[PreserveSig]
		[Token(Token = "0x600051B")]
		[Address(RVA = "0x1A673EC", Offset = "0x1A673EC", VA = "0x1A673EC")]
		public static extern RESULT FMOD5_DSP_GetCPUUsage(IntPtr dsp, out uint exclusive, out uint inclusive);

		[Token(Token = "0x600051C")]
		[Address(RVA = "0x9C98A0", Offset = "0x9C98A0", VA = "0x9C98A0")]
		public bool hasHandle()
		{
			return default(bool);
		}

		[Token(Token = "0x600051D")]
		[Address(RVA = "0x9C98A8", Offset = "0x9C98A8", VA = "0x9C98A8")]
		public void clearHandle()
		{
		}
	}
	[Token(Token = "0x2000075")]
	public struct DSPConnection
	{
		[Token(Token = "0x4000355")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public IntPtr handle;

		[Token(Token = "0x600051E")]
		[Address(RVA = "0x9C98EC", Offset = "0x9C98EC", VA = "0x9C98EC")]
		public RESULT getInput(out DSP input)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600051F")]
		[Address(RVA = "0x9C98F4", Offset = "0x9C98F4", VA = "0x9C98F4")]
		public RESULT getOutput(out DSP output)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000520")]
		[Address(RVA = "0x9C98FC", Offset = "0x9C98FC", VA = "0x9C98FC")]
		public RESULT setMix(float volume)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000521")]
		[Address(RVA = "0x9C9904", Offset = "0x9C9904", VA = "0x9C9904")]
		public RESULT getMix(out float volume)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000522")]
		[Address(RVA = "0x9C990C", Offset = "0x9C990C", VA = "0x9C990C")]
		public RESULT setMixMatrix(float[] matrix, int outchannels, int inchannels, int inchannel_hop = 0)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000523")]
		[Address(RVA = "0x9C9914", Offset = "0x9C9914", VA = "0x9C9914")]
		public RESULT getMixMatrix(float[] matrix, out int outchannels, out int inchannels, int inchannel_hop = 0)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000524")]
		[Address(RVA = "0x9C991C", Offset = "0x9C991C", VA = "0x9C991C")]
		public RESULT getType(out DSPCONNECTION_TYPE type)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000525")]
		[Address(RVA = "0x9C9924", Offset = "0x9C9924", VA = "0x9C9924")]
		public RESULT setUserData(IntPtr userdata)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000526")]
		[Address(RVA = "0x9C992C", Offset = "0x9C992C", VA = "0x9C992C")]
		public RESULT getUserData(out IntPtr userdata)
		{
			return default(RESULT);
		}

		[PreserveSig]
		[Token(Token = "0x6000527")]
		[Address(RVA = "0x1A67538", Offset = "0x1A67538", VA = "0x1A67538")]
		private static extern RESULT FMOD5_DSPConnection_GetInput(IntPtr dspconnection, out IntPtr input);

		[PreserveSig]
		[Token(Token = "0x6000528")]
		[Address(RVA = "0x1A675EC", Offset = "0x1A675EC", VA = "0x1A675EC")]
		private static extern RESULT FMOD5_DSPConnection_GetOutput(IntPtr dspconnection, out IntPtr output);

		[PreserveSig]
		[Token(Token = "0x6000529")]
		[Address(RVA = "0x1A676A0", Offset = "0x1A676A0", VA = "0x1A676A0")]
		private static extern RESULT FMOD5_DSPConnection_SetMix(IntPtr dspconnection, float volume);

		[PreserveSig]
		[Token(Token = "0x600052A")]
		[Address(RVA = "0x1A67754", Offset = "0x1A67754", VA = "0x1A67754")]
		private static extern RESULT FMOD5_DSPConnection_GetMix(IntPtr dspconnection, out float volume);

		[PreserveSig]
		[Token(Token = "0x600052B")]
		[Address(RVA = "0x1A67808", Offset = "0x1A67808", VA = "0x1A67808")]
		private static extern RESULT FMOD5_DSPConnection_SetMixMatrix(IntPtr dspconnection, float[] matrix, int outchannels, int inchannels, int inchannel_hop);

		[PreserveSig]
		[Token(Token = "0x600052C")]
		[Address(RVA = "0x1A678E4", Offset = "0x1A678E4", VA = "0x1A678E4")]
		private static extern RESULT FMOD5_DSPConnection_GetMixMatrix(IntPtr dspconnection, float[] matrix, out int outchannels, out int inchannels, int inchannel_hop);

		[PreserveSig]
		[Token(Token = "0x600052D")]
		[Address(RVA = "0x1A679C0", Offset = "0x1A679C0", VA = "0x1A679C0")]
		private static extern RESULT FMOD5_DSPConnection_GetType(IntPtr dspconnection, out DSPCONNECTION_TYPE type);

		[PreserveSig]
		[Token(Token = "0x600052E")]
		[Address(RVA = "0x1A67A74", Offset = "0x1A67A74", VA = "0x1A67A74")]
		private static extern RESULT FMOD5_DSPConnection_SetUserData(IntPtr dspconnection, IntPtr userdata);

		[PreserveSig]
		[Token(Token = "0x600052F")]
		[Address(RVA = "0x1A67B28", Offset = "0x1A67B28", VA = "0x1A67B28")]
		private static extern RESULT FMOD5_DSPConnection_GetUserData(IntPtr dspconnection, out IntPtr userdata);

		[Token(Token = "0x6000530")]
		[Address(RVA = "0x9C9934", Offset = "0x9C9934", VA = "0x9C9934")]
		public bool hasHandle()
		{
			return default(bool);
		}

		[Token(Token = "0x6000531")]
		[Address(RVA = "0x9C993C", Offset = "0x9C993C", VA = "0x9C993C")]
		public void clearHandle()
		{
		}
	}
	[Token(Token = "0x2000076")]
	public struct Geometry
	{
		[Token(Token = "0x4000356")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public IntPtr handle;

		[Token(Token = "0x6000532")]
		[Address(RVA = "0x9C77F4", Offset = "0x9C77F4", VA = "0x9C77F4")]
		public RESULT release()
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000533")]
		[Address(RVA = "0x9C77FC", Offset = "0x9C77FC", VA = "0x9C77FC")]
		public RESULT addPolygon(float directocclusion, float reverbocclusion, bool doublesided, int numvertices, VECTOR[] vertices, out int polygonindex)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000534")]
		[Address(RVA = "0x9C7808", Offset = "0x9C7808", VA = "0x9C7808")]
		public RESULT getNumPolygons(out int numpolygons)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000535")]
		[Address(RVA = "0x9C7810", Offset = "0x9C7810", VA = "0x9C7810")]
		public RESULT getMaxPolygons(out int maxpolygons, out int maxvertices)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000536")]
		[Address(RVA = "0x9C7818", Offset = "0x9C7818", VA = "0x9C7818")]
		public RESULT getPolygonNumVertices(int index, out int numvertices)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000537")]
		[Address(RVA = "0x9C7820", Offset = "0x9C7820", VA = "0x9C7820")]
		public RESULT setPolygonVertex(int index, int vertexindex, ref VECTOR vertex)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000538")]
		[Address(RVA = "0x9C7828", Offset = "0x9C7828", VA = "0x9C7828")]
		public RESULT getPolygonVertex(int index, int vertexindex, out VECTOR vertex)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000539")]
		[Address(RVA = "0x9C7830", Offset = "0x9C7830", VA = "0x9C7830")]
		public RESULT setPolygonAttributes(int index, float directocclusion, float reverbocclusion, bool doublesided)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600053A")]
		[Address(RVA = "0x9C783C", Offset = "0x9C783C", VA = "0x9C783C")]
		public RESULT getPolygonAttributes(int index, out float directocclusion, out float reverbocclusion, out bool doublesided)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600053B")]
		[Address(RVA = "0x9C7844", Offset = "0x9C7844", VA = "0x9C7844")]
		public RESULT setActive(bool active)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600053C")]
		[Address(RVA = "0x9C7850", Offset = "0x9C7850", VA = "0x9C7850")]
		public RESULT getActive(out bool active)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600053D")]
		[Address(RVA = "0x9C7858", Offset = "0x9C7858", VA = "0x9C7858")]
		public RESULT setRotation(ref VECTOR forward, ref VECTOR up)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600053E")]
		[Address(RVA = "0x9C7860", Offset = "0x9C7860", VA = "0x9C7860")]
		public RESULT getRotation(out VECTOR forward, out VECTOR up)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600053F")]
		[Address(RVA = "0x9C7868", Offset = "0x9C7868", VA = "0x9C7868")]
		public RESULT setPosition(ref VECTOR position)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000540")]
		[Address(RVA = "0x9C7870", Offset = "0x9C7870", VA = "0x9C7870")]
		public RESULT getPosition(out VECTOR position)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000541")]
		[Address(RVA = "0x9C7878", Offset = "0x9C7878", VA = "0x9C7878")]
		public RESULT setScale(ref VECTOR scale)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000542")]
		[Address(RVA = "0x9C7880", Offset = "0x9C7880", VA = "0x9C7880")]
		public RESULT getScale(out VECTOR scale)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000543")]
		[Address(RVA = "0x9C7888", Offset = "0x9C7888", VA = "0x9C7888")]
		public RESULT save(IntPtr data, out int datasize)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000544")]
		[Address(RVA = "0x9C7890", Offset = "0x9C7890", VA = "0x9C7890")]
		public RESULT setUserData(IntPtr userdata)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000545")]
		[Address(RVA = "0x9C7898", Offset = "0x9C7898", VA = "0x9C7898")]
		public RESULT getUserData(out IntPtr userdata)
		{
			return default(RESULT);
		}

		[PreserveSig]
		[Token(Token = "0x6000546")]
		[Address(RVA = "0x1A46978", Offset = "0x1A46978", VA = "0x1A46978")]
		private static extern RESULT FMOD5_Geometry_Release(IntPtr geometry);

		[PreserveSig]
		[Token(Token = "0x6000547")]
		[Address(RVA = "0x1A46A20", Offset = "0x1A46A20", VA = "0x1A46A20")]
		private static extern RESULT FMOD5_Geometry_AddPolygon(IntPtr geometry, float directocclusion, float reverbocclusion, bool doublesided, int numvertices, VECTOR[] vertices, out int polygonindex);

		[PreserveSig]
		[Token(Token = "0x6000548")]
		[Address(RVA = "0x1A46B14", Offset = "0x1A46B14", VA = "0x1A46B14")]
		private static extern RESULT FMOD5_Geometry_GetNumPolygons(IntPtr geometry, out int numpolygons);

		[PreserveSig]
		[Token(Token = "0x6000549")]
		[Address(RVA = "0x1A46BC8", Offset = "0x1A46BC8", VA = "0x1A46BC8")]
		private static extern RESULT FMOD5_Geometry_GetMaxPolygons(IntPtr geometry, out int maxpolygons, out int maxvertices);

		[PreserveSig]
		[Token(Token = "0x600054A")]
		[Address(RVA = "0x1A46C84", Offset = "0x1A46C84", VA = "0x1A46C84")]
		private static extern RESULT FMOD5_Geometry_GetPolygonNumVertices(IntPtr geometry, int index, out int numvertices);

		[PreserveSig]
		[Token(Token = "0x600054B")]
		[Address(RVA = "0x1A46D40", Offset = "0x1A46D40", VA = "0x1A46D40")]
		private static extern RESULT FMOD5_Geometry_SetPolygonVertex(IntPtr geometry, int index, int vertexindex, ref VECTOR vertex);

		[PreserveSig]
		[Token(Token = "0x600054C")]
		[Address(RVA = "0x1A46E0C", Offset = "0x1A46E0C", VA = "0x1A46E0C")]
		private static extern RESULT FMOD5_Geometry_GetPolygonVertex(IntPtr geometry, int index, int vertexindex, out VECTOR vertex);

		[PreserveSig]
		[Token(Token = "0x600054D")]
		[Address(RVA = "0x1A46EDC", Offset = "0x1A46EDC", VA = "0x1A46EDC")]
		private static extern RESULT FMOD5_Geometry_SetPolygonAttributes(IntPtr geometry, int index, float directocclusion, float reverbocclusion, bool doublesided);

		[PreserveSig]
		[Token(Token = "0x600054E")]
		[Address(RVA = "0x1A46FB0", Offset = "0x1A46FB0", VA = "0x1A46FB0")]
		private static extern RESULT FMOD5_Geometry_GetPolygonAttributes(IntPtr geometry, int index, out float directocclusion, out float reverbocclusion, out bool doublesided);

		[PreserveSig]
		[Token(Token = "0x600054F")]
		[Address(RVA = "0x1A4709C", Offset = "0x1A4709C", VA = "0x1A4709C")]
		private static extern RESULT FMOD5_Geometry_SetActive(IntPtr geometry, bool active);

		[PreserveSig]
		[Token(Token = "0x6000550")]
		[Address(RVA = "0x1A47150", Offset = "0x1A47150", VA = "0x1A47150")]
		private static extern RESULT FMOD5_Geometry_GetActive(IntPtr geometry, out bool active);

		[PreserveSig]
		[Token(Token = "0x6000551")]
		[Address(RVA = "0x1A47218", Offset = "0x1A47218", VA = "0x1A47218")]
		private static extern RESULT FMOD5_Geometry_SetRotation(IntPtr geometry, ref VECTOR forward, ref VECTOR up);

		[PreserveSig]
		[Token(Token = "0x6000552")]
		[Address(RVA = "0x1A472D4", Offset = "0x1A472D4", VA = "0x1A472D4")]
		private static extern RESULT FMOD5_Geometry_GetRotation(IntPtr geometry, out VECTOR forward, out VECTOR up);

		[PreserveSig]
		[Token(Token = "0x6000553")]
		[Address(RVA = "0x1A47390", Offset = "0x1A47390", VA = "0x1A47390")]
		private static extern RESULT FMOD5_Geometry_SetPosition(IntPtr geometry, ref VECTOR position);

		[PreserveSig]
		[Token(Token = "0x6000554")]
		[Address(RVA = "0x1A47444", Offset = "0x1A47444", VA = "0x1A47444")]
		private static extern RESULT FMOD5_Geometry_GetPosition(IntPtr geometry, out VECTOR position);

		[PreserveSig]
		[Token(Token = "0x6000555")]
		[Address(RVA = "0x1A474F8", Offset = "0x1A474F8", VA = "0x1A474F8")]
		private static extern RESULT FMOD5_Geometry_SetScale(IntPtr geometry, ref VECTOR scale);

		[PreserveSig]
		[Token(Token = "0x6000556")]
		[Address(RVA = "0x1A475AC", Offset = "0x1A475AC", VA = "0x1A475AC")]
		private static extern RESULT FMOD5_Geometry_GetScale(IntPtr geometry, out VECTOR scale);

		[PreserveSig]
		[Token(Token = "0x6000557")]
		[Address(RVA = "0x1A47660", Offset = "0x1A47660", VA = "0x1A47660")]
		private static extern RESULT FMOD5_Geometry_Save(IntPtr geometry, IntPtr data, out int datasize);

		[PreserveSig]
		[Token(Token = "0x6000558")]
		[Address(RVA = "0x1A4771C", Offset = "0x1A4771C", VA = "0x1A4771C")]
		private static extern RESULT FMOD5_Geometry_SetUserData(IntPtr geometry, IntPtr userdata);

		[PreserveSig]
		[Token(Token = "0x6000559")]
		[Address(RVA = "0x1A477D0", Offset = "0x1A477D0", VA = "0x1A477D0")]
		private static extern RESULT FMOD5_Geometry_GetUserData(IntPtr geometry, out IntPtr userdata);

		[Token(Token = "0x600055A")]
		[Address(RVA = "0x9C78A0", Offset = "0x9C78A0", VA = "0x9C78A0")]
		public bool hasHandle()
		{
			return default(bool);
		}

		[Token(Token = "0x600055B")]
		[Address(RVA = "0x9C78A8", Offset = "0x9C78A8", VA = "0x9C78A8")]
		public void clearHandle()
		{
		}
	}
	[Token(Token = "0x2000077")]
	public struct Reverb3D
	{
		[Token(Token = "0x4000357")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public IntPtr handle;

		[Token(Token = "0x600055C")]
		[Address(RVA = "0x9C7964", Offset = "0x9C7964", VA = "0x9C7964")]
		public RESULT release()
		{
			return default(RESULT);
		}

		[Token(Token = "0x600055D")]
		[Address(RVA = "0x9C796C", Offset = "0x9C796C", VA = "0x9C796C")]
		public RESULT set3DAttributes(ref VECTOR position, float mindistance, float maxdistance)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600055E")]
		[Address(RVA = "0x9C7974", Offset = "0x9C7974", VA = "0x9C7974")]
		public RESULT get3DAttributes(ref VECTOR position, ref float mindistance, ref float maxdistance)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600055F")]
		[Address(RVA = "0x9C797C", Offset = "0x9C797C", VA = "0x9C797C")]
		public RESULT setProperties(ref REVERB_PROPERTIES properties)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000560")]
		[Address(RVA = "0x9C7984", Offset = "0x9C7984", VA = "0x9C7984")]
		public RESULT getProperties(ref REVERB_PROPERTIES properties)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000561")]
		[Address(RVA = "0x9C798C", Offset = "0x9C798C", VA = "0x9C798C")]
		public RESULT setActive(bool active)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000562")]
		[Address(RVA = "0x9C7998", Offset = "0x9C7998", VA = "0x9C7998")]
		public RESULT getActive(out bool active)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000563")]
		[Address(RVA = "0x9C79A0", Offset = "0x9C79A0", VA = "0x9C79A0")]
		public RESULT setUserData(IntPtr userdata)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000564")]
		[Address(RVA = "0x9C79A8", Offset = "0x9C79A8", VA = "0x9C79A8")]
		public RESULT getUserData(out IntPtr userdata)
		{
			return default(RESULT);
		}

		[PreserveSig]
		[Token(Token = "0x6000565")]
		[Address(RVA = "0x1A48FC4", Offset = "0x1A48FC4", VA = "0x1A48FC4")]
		private static extern RESULT FMOD5_Reverb3D_Release(IntPtr reverb3d);

		[PreserveSig]
		[Token(Token = "0x6000566")]
		[Address(RVA = "0x1A49068", Offset = "0x1A49068", VA = "0x1A49068")]
		private static extern RESULT FMOD5_Reverb3D_Set3DAttributes(IntPtr reverb3d, ref VECTOR position, float mindistance, float maxdistance);

		[PreserveSig]
		[Token(Token = "0x6000567")]
		[Address(RVA = "0x1A49134", Offset = "0x1A49134", VA = "0x1A49134")]
		private static extern RESULT FMOD5_Reverb3D_Get3DAttributes(IntPtr reverb3d, ref VECTOR position, ref float mindistance, ref float maxdistance);

		[PreserveSig]
		[Token(Token = "0x6000568")]
		[Address(RVA = "0x1A49200", Offset = "0x1A49200", VA = "0x1A49200")]
		private static extern RESULT FMOD5_Reverb3D_SetProperties(IntPtr reverb3d, ref REVERB_PROPERTIES properties);

		[PreserveSig]
		[Token(Token = "0x6000569")]
		[Address(RVA = "0x1A492B4", Offset = "0x1A492B4", VA = "0x1A492B4")]
		private static extern RESULT FMOD5_Reverb3D_GetProperties(IntPtr reverb3d, ref REVERB_PROPERTIES properties);

		[PreserveSig]
		[Token(Token = "0x600056A")]
		[Address(RVA = "0x1A4936C", Offset = "0x1A4936C", VA = "0x1A4936C")]
		private static extern RESULT FMOD5_Reverb3D_SetActive(IntPtr reverb3d, bool active);

		[PreserveSig]
		[Token(Token = "0x600056B")]
		[Address(RVA = "0x1A49420", Offset = "0x1A49420", VA = "0x1A49420")]
		private static extern RESULT FMOD5_Reverb3D_GetActive(IntPtr reverb3d, out bool active);

		[PreserveSig]
		[Token(Token = "0x600056C")]
		[Address(RVA = "0x1A494E8", Offset = "0x1A494E8", VA = "0x1A494E8")]
		private static extern RESULT FMOD5_Reverb3D_SetUserData(IntPtr reverb3d, IntPtr userdata);

		[PreserveSig]
		[Token(Token = "0x600056D")]
		[Address(RVA = "0x1A4959C", Offset = "0x1A4959C", VA = "0x1A4959C")]
		private static extern RESULT FMOD5_Reverb3D_GetUserData(IntPtr reverb3d, out IntPtr userdata);

		[Token(Token = "0x600056E")]
		[Address(RVA = "0x9C79B0", Offset = "0x9C79B0", VA = "0x9C79B0")]
		public bool hasHandle()
		{
			return default(bool);
		}

		[Token(Token = "0x600056F")]
		[Address(RVA = "0x9C79B8", Offset = "0x9C79B8", VA = "0x9C79B8")]
		public void clearHandle()
		{
		}
	}
	[Token(Token = "0x2000078")]
	public struct StringWrapper
	{
		[Token(Token = "0x4000358")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private IntPtr nativeUtf8Ptr;

		[Token(Token = "0x6000570")]
		[Address(RVA = "0x1A4E9D8", Offset = "0x1A4E9D8", VA = "0x1A4E9D8")]
		public static implicit operator string(StringWrapper fstring)
		{
			return null;
		}
	}
	[Token(Token = "0x2000079")]
	internal static class StringHelper
	{
		[Token(Token = "0x2000147")]
		public class ThreadSafeEncoding : IDisposable
		{
			[Token(Token = "0x4000709")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private UTF8Encoding encoding;

			[Token(Token = "0x400070A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private byte[] encodedBuffer;

			[Token(Token = "0x400070B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private char[] decodedBuffer;

			[Token(Token = "0x400070C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private bool inUse;

			[Token(Token = "0x400070D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			private GCHandle gcHandle;

			[Token(Token = "0x600085F")]
			[Address(RVA = "0x1A4E700", Offset = "0x1A4E700", VA = "0x1A4E700")]
			public bool InUse()
			{
				return default(bool);
			}

			[Token(Token = "0x6000860")]
			[Address(RVA = "0x1A4E7A0", Offset = "0x1A4E7A0", VA = "0x1A4E7A0")]
			public void SetInUse()
			{
			}

			[Token(Token = "0x6000861")]
			[Address(RVA = "0x1A4E824", Offset = "0x1A4E824", VA = "0x1A4E824")]
			private int roundUpPowerTwo(int number)
			{
				return default(int);
			}

			[Token(Token = "0x6000862")]
			[Address(RVA = "0x1A43DF0", Offset = "0x1A43DF0", VA = "0x1A43DF0")]
			public byte[] byteFromStringUTF8(string s)
			{
				return null;
			}

			[Token(Token = "0x6000863")]
			[Address(RVA = "0x1A4E83C", Offset = "0x1A4E83C", VA = "0x1A4E83C")]
			public IntPtr intptrFromStringUTF8(string s)
			{
				return default(IntPtr);
			}

			[Token(Token = "0x6000864")]
			[Address(RVA = "0x1A4BB5C", Offset = "0x1A4BB5C", VA = "0x1A4BB5C")]
			public string stringFromNative(IntPtr nativePtr)
			{
				return null;
			}

			[Token(Token = "0x6000865")]
			[Address(RVA = "0x1A4E8C8", Offset = "0x1A4E8C8", VA = "0x1A4E8C8", Slot = "4")]
			public void Dispose()
			{
			}

			[Token(Token = "0x6000866")]
			[Address(RVA = "0x1A4E708", Offset = "0x1A4E708", VA = "0x1A4E708")]
			public ThreadSafeEncoding()
			{
			}
		}

		[Token(Token = "0x4000359")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static List<ThreadSafeEncoding> encoders;

		[Token(Token = "0x6000571")]
		[Address(RVA = "0x1A43B54", Offset = "0x1A43B54", VA = "0x1A43B54")]
		public static ThreadSafeEncoding GetFreeHelper()
		{
			return null;
		}
	}
	[Token(Token = "0x200007A")]
	internal static class Android
	{
		[Token(Token = "0x2000148")]
		public struct THREADAFFINITY
		{
			[Token(Token = "0x400070E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public THREAD mixer;

			[Token(Token = "0x400070F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public THREAD stream;

			[Token(Token = "0x4000710")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public THREAD nonblocking;

			[Token(Token = "0x4000711")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public THREAD file;

			[Token(Token = "0x4000712")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public THREAD geometry;

			[Token(Token = "0x4000713")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public THREAD profiler;

			[Token(Token = "0x4000714")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public THREAD studioUpdate;

			[Token(Token = "0x4000715")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public THREAD studioLoadBank;

			[Token(Token = "0x4000716")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public THREAD studioLoadSample;
		}

		[Token(Token = "0x2000149")]
		[Flags]
		public enum THREAD : uint
		{
			[Token(Token = "0x4000718")]
			DEFAULT = 0u,
			[Token(Token = "0x4000719")]
			CORE0 = 1u,
			[Token(Token = "0x400071A")]
			CORE1 = 2u,
			[Token(Token = "0x400071B")]
			CORE2 = 4u,
			[Token(Token = "0x400071C")]
			CORE3 = 8u,
			[Token(Token = "0x400071D")]
			CORE4 = 0x10u,
			[Token(Token = "0x400071E")]
			CORE5 = 0x20u,
			[Token(Token = "0x400071F")]
			CORE6 = 0x40u,
			[Token(Token = "0x4000720")]
			CORE7 = 0x80u
		}

		[Token(Token = "0x6000573")]
		[Address(RVA = "0x1A5C928", Offset = "0x1A5C928", VA = "0x1A5C928")]
		public static RESULT setThreadAffinity(ref THREADAFFINITY affinity)
		{
			return default(RESULT);
		}

		[PreserveSig]
		[Token(Token = "0x6000574")]
		[Address(RVA = "0x1A5C92C", Offset = "0x1A5C92C", VA = "0x1A5C92C")]
		private static extern RESULT FMOD_Android_SetThreadAffinity(ref THREADAFFINITY affinity);
	}
	[Token(Token = "0x200007B")]
	public struct DSP_BUFFER_ARRAY
	{
		[Token(Token = "0x400035A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int numbuffers;

		[Token(Token = "0x400035B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public int[] buffernumchannels;

		[Token(Token = "0x400035C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public CHANNELMASK[] bufferchannelmask;

		[Token(Token = "0x400035D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public IntPtr[] buffers;

		[Token(Token = "0x400035E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public SPEAKERMODE speakermode;
	}
	[Token(Token = "0x200007C")]
	public enum DSP_PROCESS_OPERATION
	{
		[Token(Token = "0x4000360")]
		PROCESS_PERFORM,
		[Token(Token = "0x4000361")]
		PROCESS_QUERY
	}
	[Token(Token = "0x200007D")]
	public struct COMPLEX
	{
		[Token(Token = "0x4000362")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float real;

		[Token(Token = "0x4000363")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public float imag;
	}
	[Token(Token = "0x200007E")]
	public enum DSP_PAN_SURROUND_FLAGS
	{
		[Token(Token = "0x4000365")]
		DEFAULT,
		[Token(Token = "0x4000366")]
		ROTATION_NOT_BIASED
	}
	[Token(Token = "0x200007F")]
	public delegate RESULT DSP_CREATECALLBACK(ref DSP_STATE dsp_state);
	[Token(Token = "0x2000080")]
	public delegate RESULT DSP_RELEASECALLBACK(ref DSP_STATE dsp_state);
	[Token(Token = "0x2000081")]
	public delegate RESULT DSP_RESETCALLBACK(ref DSP_STATE dsp_state);
	[Token(Token = "0x2000082")]
	public delegate RESULT DSP_SETPOSITIONCALLBACK(ref DSP_STATE dsp_state, uint pos);
	[Token(Token = "0x2000083")]
	public delegate RESULT DSP_READCALLBACK(ref DSP_STATE dsp_state, IntPtr inbuffer, IntPtr outbuffer, uint length, int inchannels, ref int outchannels);
	[Token(Token = "0x2000084")]
	public delegate RESULT DSP_SHOULDIPROCESS_CALLBACK(ref DSP_STATE dsp_state, bool inputsidle, uint length, CHANNELMASK inmask, int inchannels, SPEAKERMODE speakermode);
	[Token(Token = "0x2000085")]
	public delegate RESULT DSP_PROCESS_CALLBACK(ref DSP_STATE dsp_state, uint length, ref DSP_BUFFER_ARRAY inbufferarray, ref DSP_BUFFER_ARRAY outbufferarray, bool inputsidle, DSP_PROCESS_OPERATION op);
	[Token(Token = "0x2000086")]
	public delegate RESULT DSP_SETPARAM_FLOAT_CALLBACK(ref DSP_STATE dsp_state, int index, float value);
	[Token(Token = "0x2000087")]
	public delegate RESULT DSP_SETPARAM_INT_CALLBACK(ref DSP_STATE dsp_state, int index, int value);
	[Token(Token = "0x2000088")]
	public delegate RESULT DSP_SETPARAM_BOOL_CALLBACK(ref DSP_STATE dsp_state, int index, bool value);
	[Token(Token = "0x2000089")]
	public delegate RESULT DSP_SETPARAM_DATA_CALLBACK(ref DSP_STATE dsp_state, int index, IntPtr data, uint length);
	[Token(Token = "0x200008A")]
	public delegate RESULT DSP_GETPARAM_FLOAT_CALLBACK(ref DSP_STATE dsp_state, int index, ref float value, IntPtr valuestr);
	[Token(Token = "0x200008B")]
	public delegate RESULT DSP_GETPARAM_INT_CALLBACK(ref DSP_STATE dsp_state, int index, ref int value, IntPtr valuestr);
	[Token(Token = "0x200008C")]
	public delegate RESULT DSP_GETPARAM_BOOL_CALLBACK(ref DSP_STATE dsp_state, int index, ref bool value, IntPtr valuestr);
	[Token(Token = "0x200008D")]
	public delegate RESULT DSP_GETPARAM_DATA_CALLBACK(ref DSP_STATE dsp_state, int index, ref IntPtr data, ref uint length, IntPtr valuestr);
	[Token(Token = "0x200008E")]
	public delegate RESULT DSP_SYSTEM_REGISTER_CALLBACK(ref DSP_STATE dsp_state);
	[Token(Token = "0x200008F")]
	public delegate RESULT DSP_SYSTEM_DEREGISTER_CALLBACK(ref DSP_STATE dsp_state);
	[Token(Token = "0x2000090")]
	public delegate RESULT DSP_SYSTEM_MIX_CALLBACK(ref DSP_STATE dsp_state, int stage);
	[Token(Token = "0x2000091")]
	public delegate IntPtr DSP_ALLOC_FUNC(uint size, MEMORY_TYPE type, StringWrapper sourcestr);
	[Token(Token = "0x2000092")]
	public delegate IntPtr DSP_REALLOC_FUNC(IntPtr ptr, uint size, MEMORY_TYPE type, StringWrapper sourcestr);
	[Token(Token = "0x2000093")]
	public delegate void DSP_FREE_FUNC(IntPtr ptr, MEMORY_TYPE type, StringWrapper sourcestr);
	[Token(Token = "0x2000094")]
	public delegate void DSP_LOG_FUNC(DEBUG_FLAGS level, StringWrapper file, int line, StringWrapper function, StringWrapper format);
	[Token(Token = "0x2000095")]
	public delegate RESULT DSP_GETSAMPLERATE_FUNC(ref DSP_STATE dsp_state, ref int rate);
	[Token(Token = "0x2000096")]
	public delegate RESULT DSP_GETBLOCKSIZE_FUNC(ref DSP_STATE dsp_state, ref uint blocksize);
	[Token(Token = "0x2000097")]
	public delegate RESULT DSP_GETSPEAKERMODE_FUNC(ref DSP_STATE dsp_state, ref int speakermode_mixer, ref int speakermode_output);
	[Token(Token = "0x2000098")]
	public delegate RESULT DSP_GETCLOCK_FUNC(ref DSP_STATE dsp_state, out ulong clock, out uint offset, out uint length);
	[Token(Token = "0x2000099")]
	public delegate RESULT DSP_GETLISTENERATTRIBUTES_FUNC(ref DSP_STATE dsp_state, ref int numlisteners, IntPtr attributes);
	[Token(Token = "0x200009A")]
	public delegate RESULT DSP_GETUSERDATA_FUNC(ref DSP_STATE dsp_state, out IntPtr userdata);
	[Token(Token = "0x200009B")]
	public delegate RESULT DSP_DFT_FFTREAL_FUNC(ref DSP_STATE dsp_state, int size, IntPtr signal, IntPtr dft, IntPtr window, int signalhop);
	[Token(Token = "0x200009C")]
	public delegate RESULT DSP_DFT_IFFTREAL_FUNC(ref DSP_STATE dsp_state, int size, IntPtr dft, IntPtr signal, IntPtr window, int signalhop);
	[Token(Token = "0x200009D")]
	public delegate RESULT DSP_PAN_SUMMONOMATRIX_FUNC(ref DSP_STATE dsp_state, int sourceSpeakerMode, float lowFrequencyGain, float overallGain, IntPtr matrix);
	[Token(Token = "0x200009E")]
	public delegate RESULT DSP_PAN_SUMSTEREOMATRIX_FUNC(ref DSP_STATE dsp_state, int sourceSpeakerMode, float pan, float lowFrequencyGain, float overallGain, int matrixHop, IntPtr matrix);
	[Token(Token = "0x200009F")]
	public delegate RESULT DSP_PAN_SUMSURROUNDMATRIX_FUNC(ref DSP_STATE dsp_state, int sourceSpeakerMode, int targetSpeakerMode, float direction, float extent, float rotation, float lowFrequencyGain, float overallGain, int matrixHop, IntPtr matrix, DSP_PAN_SURROUND_FLAGS flags);
	[Token(Token = "0x20000A0")]
	public delegate RESULT DSP_PAN_SUMMONOTOSURROUNDMATRIX_FUNC(ref DSP_STATE dsp_state, int targetSpeakerMode, float direction, float extent, float lowFrequencyGain, float overallGain, int matrixHop, IntPtr matrix);
	[Token(Token = "0x20000A1")]
	public delegate RESULT DSP_PAN_SUMSTEREOTOSURROUNDMATRIX_FUNC(ref DSP_STATE dsp_state, int targetSpeakerMode, float direction, float extent, float rotation, float lowFrequencyGain, float overallGain, int matrixHop, IntPtr matrix);
	[Token(Token = "0x20000A2")]
	public delegate RESULT DSP_PAN_GETROLLOFFGAIN_FUNC(ref DSP_STATE dsp_state, DSP_PAN_3D_ROLLOFF_TYPE rolloff, float distance, float mindistance, float maxdistance, out float gain);
	[Token(Token = "0x20000A3")]
	public enum DSP_TYPE
	{
		[Token(Token = "0x4000368")]
		UNKNOWN,
		[Token(Token = "0x4000369")]
		MIXER,
		[Token(Token = "0x400036A")]
		OSCILLATOR,
		[Token(Token = "0x400036B")]
		LOWPASS,
		[Token(Token = "0x400036C")]
		ITLOWPASS,
		[Token(Token = "0x400036D")]
		HIGHPASS,
		[Token(Token = "0x400036E")]
		ECHO,
		[Token(Token = "0x400036F")]
		FADER,
		[Token(Token = "0x4000370")]
		FLANGE,
		[Token(Token = "0x4000371")]
		DISTORTION,
		[Token(Token = "0x4000372")]
		NORMALIZE,
		[Token(Token = "0x4000373")]
		LIMITER,
		[Token(Token = "0x4000374")]
		PARAMEQ,
		[Token(Token = "0x4000375")]
		PITCHSHIFT,
		[Token(Token = "0x4000376")]
		CHORUS,
		[Token(Token = "0x4000377")]
		VSTPLUGIN,
		[Token(Token = "0x4000378")]
		WINAMPPLUGIN,
		[Token(Token = "0x4000379")]
		ITECHO,
		[Token(Token = "0x400037A")]
		COMPRESSOR,
		[Token(Token = "0x400037B")]
		SFXREVERB,
		[Token(Token = "0x400037C")]
		LOWPASS_SIMPLE,
		[Token(Token = "0x400037D")]
		DELAY,
		[Token(Token = "0x400037E")]
		TREMOLO,
		[Token(Token = "0x400037F")]
		LADSPAPLUGIN,
		[Token(Token = "0x4000380")]
		SEND,
		[Token(Token = "0x4000381")]
		RETURN,
		[Token(Token = "0x4000382")]
		HIGHPASS_SIMPLE,
		[Token(Token = "0x4000383")]
		PAN,
		[Token(Token = "0x4000384")]
		THREE_EQ,
		[Token(Token = "0x4000385")]
		FFT,
		[Token(Token = "0x4000386")]
		LOUDNESS_METER,
		[Token(Token = "0x4000387")]
		ENVELOPEFOLLOWER,
		[Token(Token = "0x4000388")]
		CONVOLUTIONREVERB,
		[Token(Token = "0x4000389")]
		CHANNELMIX,
		[Token(Token = "0x400038A")]
		TRANSCEIVER,
		[Token(Token = "0x400038B")]
		OBJECTPAN,
		[Token(Token = "0x400038C")]
		MULTIBAND_EQ,
		[Token(Token = "0x400038D")]
		MAX
	}
	[Token(Token = "0x20000A4")]
	public enum DSP_PARAMETER_TYPE
	{
		[Token(Token = "0x400038F")]
		FLOAT,
		[Token(Token = "0x4000390")]
		INT,
		[Token(Token = "0x4000391")]
		BOOL,
		[Token(Token = "0x4000392")]
		DATA,
		[Token(Token = "0x4000393")]
		MAX
	}
	[Token(Token = "0x20000A5")]
	public enum DSP_PARAMETER_FLOAT_MAPPING_TYPE
	{
		[Token(Token = "0x4000395")]
		DSP_PARAMETER_FLOAT_MAPPING_TYPE_LINEAR,
		[Token(Token = "0x4000396")]
		DSP_PARAMETER_FLOAT_MAPPING_TYPE_AUTO,
		[Token(Token = "0x4000397")]
		DSP_PARAMETER_FLOAT_MAPPING_TYPE_PIECEWISE_LINEAR
	}
	[Token(Token = "0x20000A6")]
	public struct DSP_PARAMETER_FLOAT_MAPPING_PIECEWISE_LINEAR
	{
		[Token(Token = "0x4000398")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int numpoints;

		[Token(Token = "0x4000399")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public IntPtr pointparamvalues;

		[Token(Token = "0x400039A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public IntPtr pointpositions;
	}
	[Token(Token = "0x20000A7")]
	public struct DSP_PARAMETER_FLOAT_MAPPING
	{
		[Token(Token = "0x400039B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public DSP_PARAMETER_FLOAT_MAPPING_TYPE type;

		[Token(Token = "0x400039C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public DSP_PARAMETER_FLOAT_MAPPING_PIECEWISE_LINEAR piecewiselinearmapping;
	}
	[Token(Token = "0x20000A8")]
	public struct DSP_PARAMETER_DESC_FLOAT
	{
		[Token(Token = "0x400039D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float min;

		[Token(Token = "0x400039E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public float max;

		[Token(Token = "0x400039F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public float defaultval;

		[Token(Token = "0x40003A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public DSP_PARAMETER_FLOAT_MAPPING mapping;
	}
	[Token(Token = "0x20000A9")]
	public struct DSP_PARAMETER_DESC_INT
	{
		[Token(Token = "0x40003A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int min;

		[Token(Token = "0x40003A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public int max;

		[Token(Token = "0x40003A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public int defaultval;

		[Token(Token = "0x40003A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public bool goestoinf;

		[Token(Token = "0x40003A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public IntPtr valuenames;
	}
	[Token(Token = "0x20000AA")]
	public struct DSP_PARAMETER_DESC_BOOL
	{
		[Token(Token = "0x40003A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public bool defaultval;

		[Token(Token = "0x40003A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public IntPtr valuenames;
	}
	[Token(Token = "0x20000AB")]
	public struct DSP_PARAMETER_DESC_DATA
	{
		[Token(Token = "0x40003A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int datatype;
	}
	[StructLayout(2)]
	[Token(Token = "0x20000AC")]
	public struct DSP_PARAMETER_DESC_UNION
	{
		[Token(Token = "0x40003A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public DSP_PARAMETER_DESC_FLOAT floatdesc;

		[Token(Token = "0x40003AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public DSP_PARAMETER_DESC_INT intdesc;

		[Token(Token = "0x40003AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public DSP_PARAMETER_DESC_BOOL booldesc;

		[Token(Token = "0x40003AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public DSP_PARAMETER_DESC_DATA datadesc;
	}
	[Token(Token = "0x20000AD")]
	public struct DSP_PARAMETER_DESC
	{
		[Token(Token = "0x40003AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public DSP_PARAMETER_TYPE type;

		[Token(Token = "0x40003AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public char[] name;

		[Token(Token = "0x40003AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public char[] label;

		[Token(Token = "0x40003B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string description;

		[Token(Token = "0x40003B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public DSP_PARAMETER_DESC_UNION desc;
	}
	[Token(Token = "0x20000AE")]
	public enum DSP_PARAMETER_DATA_TYPE
	{
		[Token(Token = "0x40003B3")]
		DSP_PARAMETER_DATA_TYPE_USER = 0,
		[Token(Token = "0x40003B4")]
		DSP_PARAMETER_DATA_TYPE_OVERALLGAIN = -1,
		[Token(Token = "0x40003B5")]
		DSP_PARAMETER_DATA_TYPE_3DATTRIBUTES = -2,
		[Token(Token = "0x40003B6")]
		DSP_PARAMETER_DATA_TYPE_SIDECHAIN = -3,
		[Token(Token = "0x40003B7")]
		DSP_PARAMETER_DATA_TYPE_FFT = -4,
		[Token(Token = "0x40003B8")]
		DSP_PARAMETER_DATA_TYPE_3DATTRIBUTES_MULTI = -5
	}
	[Token(Token = "0x20000AF")]
	public struct DSP_PARAMETER_OVERALLGAIN
	{
		[Token(Token = "0x40003B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float linear_gain;

		[Token(Token = "0x40003BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public float linear_gain_additive;
	}
	[Token(Token = "0x20000B0")]
	public struct DSP_PARAMETER_3DATTRIBUTES
	{
		[Token(Token = "0x40003BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public ATTRIBUTES_3D relative;

		[Token(Token = "0x40003BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public ATTRIBUTES_3D absolute;
	}
	[Token(Token = "0x20000B1")]
	public struct DSP_PARAMETER_3DATTRIBUTES_MULTI
	{
		[Token(Token = "0x40003BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int numlisteners;

		[Token(Token = "0x40003BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public ATTRIBUTES_3D[] relative;

		[Token(Token = "0x40003BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float[] weight;

		[Token(Token = "0x40003C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public ATTRIBUTES_3D absolute;
	}
	[Token(Token = "0x20000B2")]
	public struct DSP_PARAMETER_SIDECHAIN
	{
		[Token(Token = "0x40003C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int sidechainenable;
	}
	[Token(Token = "0x20000B3")]
	public struct DSP_PARAMETER_FFT
	{
		[Token(Token = "0x40003C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int length;

		[Token(Token = "0x40003C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public int numchannels;

		[Token(Token = "0x40003C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private IntPtr[] spectrum_internal;

		[Token(Token = "0x17000049")]
		public float[][] spectrum
		{
			[Token(Token = "0x6000605")]
			[Address(RVA = "0x9CA660", Offset = "0x9CA660", VA = "0x9CA660")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000606")]
		[Address(RVA = "0x9CA668", Offset = "0x9CA668", VA = "0x9CA668")]
		public void getSpectrum(ref float[][] buffer)
		{
		}

		[Token(Token = "0x6000607")]
		[Address(RVA = "0x9CA670", Offset = "0x9CA670", VA = "0x9CA670")]
		public void getSpectrum(int channel, ref float[] buffer)
		{
		}
	}
	[Token(Token = "0x20000B4")]
	public struct DSP_DESCRIPTION
	{
		[Token(Token = "0x40003C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public uint pluginsdkversion;

		[Token(Token = "0x40003C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public char[] name;

		[Token(Token = "0x40003C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public uint version;

		[Token(Token = "0x40003C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public int numinputbuffers;

		[Token(Token = "0x40003C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int numoutputbuffers;

		[Token(Token = "0x40003CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public DSP_CREATECALLBACK create;

		[Token(Token = "0x40003CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public DSP_RELEASECALLBACK release;

		[Token(Token = "0x40003CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public DSP_RESETCALLBACK reset;

		[Token(Token = "0x40003CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public DSP_READCALLBACK read;

		[Token(Token = "0x40003CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public DSP_PROCESS_CALLBACK process;

		[Token(Token = "0x40003CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public DSP_SETPOSITIONCALLBACK setposition;

		[Token(Token = "0x40003D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public int numparameters;

		[Token(Token = "0x40003D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public IntPtr paramdesc;

		[Token(Token = "0x40003D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public DSP_SETPARAM_FLOAT_CALLBACK setparameterfloat;

		[Token(Token = "0x40003D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public DSP_SETPARAM_INT_CALLBACK setparameterint;

		[Token(Token = "0x40003D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public DSP_SETPARAM_BOOL_CALLBACK setparameterbool;

		[Token(Token = "0x40003D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public DSP_SETPARAM_DATA_CALLBACK setparameterdata;

		[Token(Token = "0x40003D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public DSP_GETPARAM_FLOAT_CALLBACK getparameterfloat;

		[Token(Token = "0x40003D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public DSP_GETPARAM_INT_CALLBACK getparameterint;

		[Token(Token = "0x40003D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public DSP_GETPARAM_BOOL_CALLBACK getparameterbool;

		[Token(Token = "0x40003D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public DSP_GETPARAM_DATA_CALLBACK getparameterdata;

		[Token(Token = "0x40003DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public DSP_SHOULDIPROCESS_CALLBACK shouldiprocess;

		[Token(Token = "0x40003DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public IntPtr userdata;

		[Token(Token = "0x40003DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public DSP_SYSTEM_REGISTER_CALLBACK sys_register;

		[Token(Token = "0x40003DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public DSP_SYSTEM_DEREGISTER_CALLBACK sys_deregister;

		[Token(Token = "0x40003DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public DSP_SYSTEM_MIX_CALLBACK sys_mix;
	}
	[Token(Token = "0x20000B5")]
	public struct DSP_STATE_DFT_FUNCTIONS
	{
		[Token(Token = "0x40003DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public DSP_DFT_FFTREAL_FUNC fftreal;

		[Token(Token = "0x40003E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public DSP_DFT_IFFTREAL_FUNC inversefftreal;
	}
	[Token(Token = "0x20000B6")]
	public struct DSP_STATE_PAN_FUNCTIONS
	{
		[Token(Token = "0x40003E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public DSP_PAN_SUMMONOMATRIX_FUNC summonomatrix;

		[Token(Token = "0x40003E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public DSP_PAN_SUMSTEREOMATRIX_FUNC sumstereomatrix;

		[Token(Token = "0x40003E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public DSP_PAN_SUMSURROUNDMATRIX_FUNC sumsurroundmatrix;

		[Token(Token = "0x40003E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public DSP_PAN_SUMMONOTOSURROUNDMATRIX_FUNC summonotosurroundmatrix;

		[Token(Token = "0x40003E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public DSP_PAN_SUMSTEREOTOSURROUNDMATRIX_FUNC sumstereotosurroundmatrix;

		[Token(Token = "0x40003E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public DSP_PAN_GETROLLOFFGAIN_FUNC getrolloffgain;
	}
	[Token(Token = "0x20000B7")]
	public struct DSP_STATE_FUNCTIONS
	{
		[Token(Token = "0x40003E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private DSP_ALLOC_FUNC alloc;

		[Token(Token = "0x40003E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private DSP_REALLOC_FUNC realloc;

		[Token(Token = "0x40003E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private DSP_FREE_FUNC free;

		[Token(Token = "0x40003EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private DSP_GETSAMPLERATE_FUNC getsamplerate;

		[Token(Token = "0x40003EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private DSP_GETBLOCKSIZE_FUNC getblocksize;

		[Token(Token = "0x40003EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private IntPtr dft;

		[Token(Token = "0x40003ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private IntPtr pan;

		[Token(Token = "0x40003EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private DSP_GETSPEAKERMODE_FUNC getspeakermode;

		[Token(Token = "0x40003EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private DSP_GETCLOCK_FUNC getclock;

		[Token(Token = "0x40003F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private DSP_GETLISTENERATTRIBUTES_FUNC getlistenerattributes;

		[Token(Token = "0x40003F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private DSP_LOG_FUNC log;

		[Token(Token = "0x40003F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private DSP_GETUSERDATA_FUNC getuserdata;
	}
	[Token(Token = "0x20000B8")]
	public struct DSP_STATE
	{
		[Token(Token = "0x40003F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public IntPtr instance;

		[Token(Token = "0x40003F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public IntPtr plugindata;

		[Token(Token = "0x40003F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public uint channelmask;

		[Token(Token = "0x40003F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public int source_speakermode;

		[Token(Token = "0x40003F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public IntPtr sidechaindata;

		[Token(Token = "0x40003F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public int sidechainchannels;

		[Token(Token = "0x40003F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public IntPtr functions;

		[Token(Token = "0x40003FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public int systemobject;
	}
	[Token(Token = "0x20000B9")]
	public struct DSP_METERING_INFO
	{
		[Token(Token = "0x40003FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int numsamples;

		[Token(Token = "0x40003FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public float[] peaklevel;

		[Token(Token = "0x40003FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float[] rmslevel;

		[Token(Token = "0x40003FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public short numchannels;
	}
	[Token(Token = "0x20000BA")]
	public enum DSP_OSCILLATOR
	{
		[Token(Token = "0x4000400")]
		TYPE,
		[Token(Token = "0x4000401")]
		RATE
	}
	[Token(Token = "0x20000BB")]
	public enum DSP_LOWPASS
	{
		[Token(Token = "0x4000403")]
		CUTOFF,
		[Token(Token = "0x4000404")]
		RESONANCE
	}
	[Token(Token = "0x20000BC")]
	public enum DSP_ITLOWPASS
	{
		[Token(Token = "0x4000406")]
		CUTOFF,
		[Token(Token = "0x4000407")]
		RESONANCE
	}
	[Token(Token = "0x20000BD")]
	public enum DSP_HIGHPASS
	{
		[Token(Token = "0x4000409")]
		CUTOFF,
		[Token(Token = "0x400040A")]
		RESONANCE
	}
	[Token(Token = "0x20000BE")]
	public enum DSP_ECHO
	{
		[Token(Token = "0x400040C")]
		DELAY,
		[Token(Token = "0x400040D")]
		FEEDBACK,
		[Token(Token = "0x400040E")]
		DRYLEVEL,
		[Token(Token = "0x400040F")]
		WETLEVEL
	}
	[Token(Token = "0x20000BF")]
	public enum DSP_FADER
	{
		[Token(Token = "0x4000411")]
		GAIN,
		[Token(Token = "0x4000412")]
		OVERALL_GAIN
	}
	[Token(Token = "0x20000C0")]
	public enum DSP_DELAY
	{
		[Token(Token = "0x4000414")]
		CH0,
		[Token(Token = "0x4000415")]
		CH1,
		[Token(Token = "0x4000416")]
		CH2,
		[Token(Token = "0x4000417")]
		CH3,
		[Token(Token = "0x4000418")]
		CH4,
		[Token(Token = "0x4000419")]
		CH5,
		[Token(Token = "0x400041A")]
		CH6,
		[Token(Token = "0x400041B")]
		CH7,
		[Token(Token = "0x400041C")]
		CH8,
		[Token(Token = "0x400041D")]
		CH9,
		[Token(Token = "0x400041E")]
		CH10,
		[Token(Token = "0x400041F")]
		CH11,
		[Token(Token = "0x4000420")]
		CH12,
		[Token(Token = "0x4000421")]
		CH13,
		[Token(Token = "0x4000422")]
		CH14,
		[Token(Token = "0x4000423")]
		CH15,
		[Token(Token = "0x4000424")]
		MAXDELAY
	}
	[Token(Token = "0x20000C1")]
	public enum DSP_FLANGE
	{
		[Token(Token = "0x4000426")]
		MIX,
		[Token(Token = "0x4000427")]
		DEPTH,
		[Token(Token = "0x4000428")]
		RATE
	}
	[Token(Token = "0x20000C2")]
	public enum DSP_TREMOLO
	{
		[Token(Token = "0x400042A")]
		FREQUENCY,
		[Token(Token = "0x400042B")]
		DEPTH,
		[Token(Token = "0x400042C")]
		SHAPE,
		[Token(Token = "0x400042D")]
		SKEW,
		[Token(Token = "0x400042E")]
		DUTY,
		[Token(Token = "0x400042F")]
		SQUARE,
		[Token(Token = "0x4000430")]
		PHASE,
		[Token(Token = "0x4000431")]
		SPREAD
	}
	[Token(Token = "0x20000C3")]
	public enum DSP_DISTORTION
	{
		[Token(Token = "0x4000433")]
		LEVEL
	}
	[Token(Token = "0x20000C4")]
	public enum DSP_NORMALIZE
	{
		[Token(Token = "0x4000435")]
		FADETIME,
		[Token(Token = "0x4000436")]
		THRESHHOLD,
		[Token(Token = "0x4000437")]
		MAXAMP
	}
	[Token(Token = "0x20000C5")]
	public enum DSP_LIMITER
	{
		[Token(Token = "0x4000439")]
		RELEASETIME,
		[Token(Token = "0x400043A")]
		CEILING,
		[Token(Token = "0x400043B")]
		MAXIMIZERGAIN,
		[Token(Token = "0x400043C")]
		MODE
	}
	[Token(Token = "0x20000C6")]
	public enum DSP_PARAMEQ
	{
		[Token(Token = "0x400043E")]
		CENTER,
		[Token(Token = "0x400043F")]
		BANDWIDTH,
		[Token(Token = "0x4000440")]
		GAIN
	}
	[Token(Token = "0x20000C7")]
	public enum DSP_MULTIBAND_EQ
	{
		[Token(Token = "0x4000442")]
		A_FILTER,
		[Token(Token = "0x4000443")]
		A_FREQUENCY,
		[Token(Token = "0x4000444")]
		A_Q,
		[Token(Token = "0x4000445")]
		A_GAIN,
		[Token(Token = "0x4000446")]
		B_FILTER,
		[Token(Token = "0x4000447")]
		B_FREQUENCY,
		[Token(Token = "0x4000448")]
		B_Q,
		[Token(Token = "0x4000449")]
		B_GAIN,
		[Token(Token = "0x400044A")]
		C_FILTER,
		[Token(Token = "0x400044B")]
		C_FREQUENCY,
		[Token(Token = "0x400044C")]
		C_Q,
		[Token(Token = "0x400044D")]
		C_GAIN,
		[Token(Token = "0x400044E")]
		D_FILTER,
		[Token(Token = "0x400044F")]
		D_FREQUENCY,
		[Token(Token = "0x4000450")]
		D_Q,
		[Token(Token = "0x4000451")]
		D_GAIN,
		[Token(Token = "0x4000452")]
		E_FILTER,
		[Token(Token = "0x4000453")]
		E_FREQUENCY,
		[Token(Token = "0x4000454")]
		E_Q,
		[Token(Token = "0x4000455")]
		E_GAIN
	}
	[Token(Token = "0x20000C8")]
	public enum DSP_MULTIBAND_EQ_FILTER_TYPE
	{
		[Token(Token = "0x4000457")]
		DISABLED,
		[Token(Token = "0x4000458")]
		LOWPASS_12DB,
		[Token(Token = "0x4000459")]
		LOWPASS_24DB,
		[Token(Token = "0x400045A")]
		LOWPASS_48DB,
		[Token(Token = "0x400045B")]
		HIGHPASS_12DB,
		[Token(Token = "0x400045C")]
		HIGHPASS_24DB,
		[Token(Token = "0x400045D")]
		HIGHPASS_48DB,
		[Token(Token = "0x400045E")]
		LOWSHELF,
		[Token(Token = "0x400045F")]
		HIGHSHELF,
		[Token(Token = "0x4000460")]
		PEAKING,
		[Token(Token = "0x4000461")]
		BANDPASS,
		[Token(Token = "0x4000462")]
		NOTCH,
		[Token(Token = "0x4000463")]
		ALLPASS
	}
	[Token(Token = "0x20000C9")]
	public enum DSP_PITCHSHIFT
	{
		[Token(Token = "0x4000465")]
		PITCH,
		[Token(Token = "0x4000466")]
		FFTSIZE,
		[Token(Token = "0x4000467")]
		OVERLAP,
		[Token(Token = "0x4000468")]
		MAXCHANNELS
	}
	[Token(Token = "0x20000CA")]
	public enum DSP_CHORUS
	{
		[Token(Token = "0x400046A")]
		MIX,
		[Token(Token = "0x400046B")]
		RATE,
		[Token(Token = "0x400046C")]
		DEPTH
	}
	[Token(Token = "0x20000CB")]
	public enum DSP_ITECHO
	{
		[Token(Token = "0x400046E")]
		WETDRYMIX,
		[Token(Token = "0x400046F")]
		FEEDBACK,
		[Token(Token = "0x4000470")]
		LEFTDELAY,
		[Token(Token = "0x4000471")]
		RIGHTDELAY,
		[Token(Token = "0x4000472")]
		PANDELAY
	}
	[Token(Token = "0x20000CC")]
	public enum DSP_COMPRESSOR
	{
		[Token(Token = "0x4000474")]
		THRESHOLD,
		[Token(Token = "0x4000475")]
		RATIO,
		[Token(Token = "0x4000476")]
		ATTACK,
		[Token(Token = "0x4000477")]
		RELEASE,
		[Token(Token = "0x4000478")]
		GAINMAKEUP,
		[Token(Token = "0x4000479")]
		USESIDECHAIN,
		[Token(Token = "0x400047A")]
		LINKED
	}
	[Token(Token = "0x20000CD")]
	public enum DSP_SFXREVERB
	{
		[Token(Token = "0x400047C")]
		DECAYTIME,
		[Token(Token = "0x400047D")]
		EARLYDELAY,
		[Token(Token = "0x400047E")]
		LATEDELAY,
		[Token(Token = "0x400047F")]
		HFREFERENCE,
		[Token(Token = "0x4000480")]
		HFDECAYRATIO,
		[Token(Token = "0x4000481")]
		DIFFUSION,
		[Token(Token = "0x4000482")]
		DENSITY,
		[Token(Token = "0x4000483")]
		LOWSHELFFREQUENCY,
		[Token(Token = "0x4000484")]
		LOWSHELFGAIN,
		[Token(Token = "0x4000485")]
		HIGHCUT,
		[Token(Token = "0x4000486")]
		EARLYLATEMIX,
		[Token(Token = "0x4000487")]
		WETLEVEL,
		[Token(Token = "0x4000488")]
		DRYLEVEL
	}
	[Token(Token = "0x20000CE")]
	public enum DSP_LOWPASS_SIMPLE
	{
		[Token(Token = "0x400048A")]
		CUTOFF
	}
	[Token(Token = "0x20000CF")]
	public enum DSP_SEND
	{
		[Token(Token = "0x400048C")]
		RETURNID,
		[Token(Token = "0x400048D")]
		LEVEL
	}
	[Token(Token = "0x20000D0")]
	public enum DSP_RETURN
	{
		[Token(Token = "0x400048F")]
		ID,
		[Token(Token = "0x4000490")]
		INPUT_SPEAKER_MODE
	}
	[Token(Token = "0x20000D1")]
	public enum DSP_HIGHPASS_SIMPLE
	{
		[Token(Token = "0x4000492")]
		CUTOFF
	}
	[Token(Token = "0x20000D2")]
	public enum DSP_PAN_2D_STEREO_MODE_TYPE
	{
		[Token(Token = "0x4000494")]
		DISTRIBUTED,
		[Token(Token = "0x4000495")]
		DISCRETE
	}
	[Token(Token = "0x20000D3")]
	public enum DSP_PAN_MODE_TYPE
	{
		[Token(Token = "0x4000497")]
		MONO,
		[Token(Token = "0x4000498")]
		STEREO,
		[Token(Token = "0x4000499")]
		SURROUND
	}
	[Token(Token = "0x20000D4")]
	public enum DSP_PAN_3D_ROLLOFF_TYPE
	{
		[Token(Token = "0x400049B")]
		LINEARSQUARED,
		[Token(Token = "0x400049C")]
		LINEAR,
		[Token(Token = "0x400049D")]
		INVERSE,
		[Token(Token = "0x400049E")]
		INVERSETAPERED,
		[Token(Token = "0x400049F")]
		CUSTOM
	}
	[Token(Token = "0x20000D5")]
	public enum DSP_PAN_3D_EXTENT_MODE_TYPE
	{
		[Token(Token = "0x40004A1")]
		AUTO,
		[Token(Token = "0x40004A2")]
		USER,
		[Token(Token = "0x40004A3")]
		OFF
	}
	[Token(Token = "0x20000D6")]
	public enum DSP_PAN
	{
		[Token(Token = "0x40004A5")]
		MODE,
		[Token(Token = "0x40004A6")]
		_2D_STEREO_POSITION,
		[Token(Token = "0x40004A7")]
		_2D_DIRECTION,
		[Token(Token = "0x40004A8")]
		_2D_EXTENT,
		[Token(Token = "0x40004A9")]
		_2D_ROTATION,
		[Token(Token = "0x40004AA")]
		_2D_LFE_LEVEL,
		[Token(Token = "0x40004AB")]
		_2D_STEREO_MODE,
		[Token(Token = "0x40004AC")]
		_2D_STEREO_SEPARATION,
		[Token(Token = "0x40004AD")]
		_2D_STEREO_AXIS,
		[Token(Token = "0x40004AE")]
		ENABLED_SPEAKERS,
		[Token(Token = "0x40004AF")]
		_3D_POSITION,
		[Token(Token = "0x40004B0")]
		_3D_ROLLOFF,
		[Token(Token = "0x40004B1")]
		_3D_MIN_DISTANCE,
		[Token(Token = "0x40004B2")]
		_3D_MAX_DISTANCE,
		[Token(Token = "0x40004B3")]
		_3D_EXTENT_MODE,
		[Token(Token = "0x40004B4")]
		_3D_SOUND_SIZE,
		[Token(Token = "0x40004B5")]
		_3D_MIN_EXTENT,
		[Token(Token = "0x40004B6")]
		_3D_PAN_BLEND,
		[Token(Token = "0x40004B7")]
		LFE_UPMIX_ENABLED,
		[Token(Token = "0x40004B8")]
		OVERALL_GAIN,
		[Token(Token = "0x40004B9")]
		SURROUND_SPEAKER_MODE,
		[Token(Token = "0x40004BA")]
		_2D_HEIGHT_BLEND
	}
	[Token(Token = "0x20000D7")]
	public enum DSP_THREE_EQ_CROSSOVERSLOPE_TYPE
	{
		[Token(Token = "0x40004BC")]
		_12DB,
		[Token(Token = "0x40004BD")]
		_24DB,
		[Token(Token = "0x40004BE")]
		_48DB
	}
	[Token(Token = "0x20000D8")]
	public enum DSP_THREE_EQ
	{
		[Token(Token = "0x40004C0")]
		LOWGAIN,
		[Token(Token = "0x40004C1")]
		MIDGAIN,
		[Token(Token = "0x40004C2")]
		HIGHGAIN,
		[Token(Token = "0x40004C3")]
		LOWCROSSOVER,
		[Token(Token = "0x40004C4")]
		HIGHCROSSOVER,
		[Token(Token = "0x40004C5")]
		CROSSOVERSLOPE
	}
	[Token(Token = "0x20000D9")]
	public enum DSP_FFT_WINDOW
	{
		[Token(Token = "0x40004C7")]
		RECT,
		[Token(Token = "0x40004C8")]
		TRIANGLE,
		[Token(Token = "0x40004C9")]
		HAMMING,
		[Token(Token = "0x40004CA")]
		HANNING,
		[Token(Token = "0x40004CB")]
		BLACKMAN,
		[Token(Token = "0x40004CC")]
		BLACKMANHARRIS
	}
	[Token(Token = "0x20000DA")]
	public enum DSP_FFT
	{
		[Token(Token = "0x40004CE")]
		WINDOWSIZE,
		[Token(Token = "0x40004CF")]
		WINDOWTYPE,
		[Token(Token = "0x40004D0")]
		SPECTRUMDATA,
		[Token(Token = "0x40004D1")]
		DOMINANT_FREQ
	}
	[Token(Token = "0x20000DB")]
	public enum DSP_ENVELOPEFOLLOWER
	{
		[Token(Token = "0x40004D3")]
		ATTACK,
		[Token(Token = "0x40004D4")]
		RELEASE,
		[Token(Token = "0x40004D5")]
		ENVELOPE,
		[Token(Token = "0x40004D6")]
		USESIDECHAIN
	}
	[Token(Token = "0x20000DC")]
	public enum DSP_CONVOLUTION_REVERB
	{
		[Token(Token = "0x40004D8")]
		IR,
		[Token(Token = "0x40004D9")]
		WET,
		[Token(Token = "0x40004DA")]
		DRY,
		[Token(Token = "0x40004DB")]
		LINKED
	}
	[Token(Token = "0x20000DD")]
	public enum DSP_CHANNELMIX_OUTPUT
	{
		[Token(Token = "0x40004DD")]
		DEFAULT,
		[Token(Token = "0x40004DE")]
		ALLMONO,
		[Token(Token = "0x40004DF")]
		ALLSTEREO,
		[Token(Token = "0x40004E0")]
		ALLQUAD,
		[Token(Token = "0x40004E1")]
		ALL5POINT1,
		[Token(Token = "0x40004E2")]
		ALL7POINT1,
		[Token(Token = "0x40004E3")]
		ALLLFE,
		[Token(Token = "0x40004E4")]
		ALL7POINT1POINT4
	}
	[Token(Token = "0x20000DE")]
	public enum DSP_CHANNELMIX
	{
		[Token(Token = "0x40004E6")]
		OUTPUTGROUPING,
		[Token(Token = "0x40004E7")]
		GAIN_CH0,
		[Token(Token = "0x40004E8")]
		GAIN_CH1,
		[Token(Token = "0x40004E9")]
		GAIN_CH2,
		[Token(Token = "0x40004EA")]
		GAIN_CH3,
		[Token(Token = "0x40004EB")]
		GAIN_CH4,
		[Token(Token = "0x40004EC")]
		GAIN_CH5,
		[Token(Token = "0x40004ED")]
		GAIN_CH6,
		[Token(Token = "0x40004EE")]
		GAIN_CH7,
		[Token(Token = "0x40004EF")]
		GAIN_CH8,
		[Token(Token = "0x40004F0")]
		GAIN_CH9,
		[Token(Token = "0x40004F1")]
		GAIN_CH10,
		[Token(Token = "0x40004F2")]
		GAIN_CH11,
		[Token(Token = "0x40004F3")]
		GAIN_CH12,
		[Token(Token = "0x40004F4")]
		GAIN_CH13,
		[Token(Token = "0x40004F5")]
		GAIN_CH14,
		[Token(Token = "0x40004F6")]
		GAIN_CH15,
		[Token(Token = "0x40004F7")]
		GAIN_CH16,
		[Token(Token = "0x40004F8")]
		GAIN_CH17,
		[Token(Token = "0x40004F9")]
		GAIN_CH18,
		[Token(Token = "0x40004FA")]
		GAIN_CH19,
		[Token(Token = "0x40004FB")]
		GAIN_CH20,
		[Token(Token = "0x40004FC")]
		GAIN_CH21,
		[Token(Token = "0x40004FD")]
		GAIN_CH22,
		[Token(Token = "0x40004FE")]
		GAIN_CH23,
		[Token(Token = "0x40004FF")]
		GAIN_CH24,
		[Token(Token = "0x4000500")]
		GAIN_CH25,
		[Token(Token = "0x4000501")]
		GAIN_CH26,
		[Token(Token = "0x4000502")]
		GAIN_CH27,
		[Token(Token = "0x4000503")]
		GAIN_CH28,
		[Token(Token = "0x4000504")]
		GAIN_CH29,
		[Token(Token = "0x4000505")]
		GAIN_CH30,
		[Token(Token = "0x4000506")]
		GAIN_CH31,
		[Token(Token = "0x4000507")]
		OUTPUT_CH0,
		[Token(Token = "0x4000508")]
		OUTPUT_CH1,
		[Token(Token = "0x4000509")]
		OUTPUT_CH2,
		[Token(Token = "0x400050A")]
		OUTPUT_CH3,
		[Token(Token = "0x400050B")]
		OUTPUT_CH4,
		[Token(Token = "0x400050C")]
		OUTPUT_CH5,
		[Token(Token = "0x400050D")]
		OUTPUT_CH6,
		[Token(Token = "0x400050E")]
		OUTPUT_CH7,
		[Token(Token = "0x400050F")]
		OUTPUT_CH8,
		[Token(Token = "0x4000510")]
		OUTPUT_CH9,
		[Token(Token = "0x4000511")]
		OUTPUT_CH10,
		[Token(Token = "0x4000512")]
		OUTPUT_CH11,
		[Token(Token = "0x4000513")]
		OUTPUT_CH12,
		[Token(Token = "0x4000514")]
		OUTPUT_CH13,
		[Token(Token = "0x4000515")]
		OUTPUT_CH14,
		[Token(Token = "0x4000516")]
		OUTPUT_CH15,
		[Token(Token = "0x4000517")]
		OUTPUT_CH16,
		[Token(Token = "0x4000518")]
		OUTPUT_CH17,
		[Token(Token = "0x4000519")]
		OUTPUT_CH18,
		[Token(Token = "0x400051A")]
		OUTPUT_CH19,
		[Token(Token = "0x400051B")]
		OUTPUT_CH20,
		[Token(Token = "0x400051C")]
		OUTPUT_CH21,
		[Token(Token = "0x400051D")]
		OUTPUT_CH22,
		[Token(Token = "0x400051E")]
		OUTPUT_CH23,
		[Token(Token = "0x400051F")]
		OUTPUT_CH24,
		[Token(Token = "0x4000520")]
		OUTPUT_CH25,
		[Token(Token = "0x4000521")]
		OUTPUT_CH26,
		[Token(Token = "0x4000522")]
		OUTPUT_CH27,
		[Token(Token = "0x4000523")]
		OUTPUT_CH28,
		[Token(Token = "0x4000524")]
		OUTPUT_CH29,
		[Token(Token = "0x4000525")]
		OUTPUT_CH30,
		[Token(Token = "0x4000526")]
		OUTPUT_CH31
	}
	[Token(Token = "0x20000DF")]
	public enum DSP_TRANSCEIVER_SPEAKERMODE
	{
		[Token(Token = "0x4000528")]
		AUTO = -1,
		[Token(Token = "0x4000529")]
		MONO,
		[Token(Token = "0x400052A")]
		STEREO,
		[Token(Token = "0x400052B")]
		SURROUND
	}
	[Token(Token = "0x20000E0")]
	public enum DSP_TRANSCEIVER
	{
		[Token(Token = "0x400052D")]
		TRANSMIT,
		[Token(Token = "0x400052E")]
		GAIN,
		[Token(Token = "0x400052F")]
		CHANNEL,
		[Token(Token = "0x4000530")]
		TRANSMITSPEAKERMODE
	}
	[Token(Token = "0x20000E1")]
	public enum DSP_OBJECTPAN
	{
		[Token(Token = "0x4000532")]
		_3D_POSITION,
		[Token(Token = "0x4000533")]
		_3D_ROLLOFF,
		[Token(Token = "0x4000534")]
		_3D_MIN_DISTANCE,
		[Token(Token = "0x4000535")]
		_3D_MAX_DISTANCE,
		[Token(Token = "0x4000536")]
		_3D_EXTENT_MODE,
		[Token(Token = "0x4000537")]
		_3D_SOUND_SIZE,
		[Token(Token = "0x4000538")]
		_3D_MIN_EXTENT,
		[Token(Token = "0x4000539")]
		OVERALL_GAIN,
		[Token(Token = "0x400053A")]
		OUTPUTGAIN
	}
	[Token(Token = "0x20000E2")]
	public class Error
	{
		[Token(Token = "0x6000608")]
		[Address(RVA = "0x1A4407C", Offset = "0x1A4407C", VA = "0x1A4407C")]
		public static string String(RESULT errcode)
		{
			return null;
		}

		[Token(Token = "0x6000609")]
		[Address(RVA = "0x1A440E0", Offset = "0x1A440E0", VA = "0x1A440E0")]
		public Error()
		{
		}
	}
}
namespace FMOD.Studio
{
	[Token(Token = "0x20000E3")]
	public class STUDIO_VERSION
	{
		[Token(Token = "0x400053B")]
		public const string dll = "fmodstudio";

		[Token(Token = "0x600060A")]
		[Address(RVA = "0x1A57688", Offset = "0x1A57688", VA = "0x1A57688")]
		public STUDIO_VERSION()
		{
		}
	}
	[Token(Token = "0x20000E4")]
	public enum STOP_MODE
	{
		[Token(Token = "0x400053D")]
		ALLOWFADEOUT,
		[Token(Token = "0x400053E")]
		IMMEDIATE
	}
	[Token(Token = "0x20000E5")]
	public enum LOADING_STATE
	{
		[Token(Token = "0x4000540")]
		UNLOADING,
		[Token(Token = "0x4000541")]
		UNLOADED,
		[Token(Token = "0x4000542")]
		LOADING,
		[Token(Token = "0x4000543")]
		LOADED,
		[Token(Token = "0x4000544")]
		ERROR
	}
	[Token(Token = "0x20000E6")]
	public struct PROGRAMMER_SOUND_PROPERTIES
	{
		[Token(Token = "0x4000545")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public StringWrapper name;

		[Token(Token = "0x4000546")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public IntPtr sound;

		[Token(Token = "0x4000547")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int subsoundIndex;
	}
	[Token(Token = "0x20000E7")]
	public struct TIMELINE_MARKER_PROPERTIES
	{
		[Token(Token = "0x4000548")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public StringWrapper name;

		[Token(Token = "0x4000549")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public int position;
	}
	[Token(Token = "0x20000E8")]
	public struct TIMELINE_BEAT_PROPERTIES
	{
		[Token(Token = "0x400054A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int bar;

		[Token(Token = "0x400054B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public int beat;

		[Token(Token = "0x400054C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public int position;

		[Token(Token = "0x400054D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public float tempo;

		[Token(Token = "0x400054E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int timesignatureupper;

		[Token(Token = "0x400054F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public int timesignaturelower;
	}
	[Token(Token = "0x20000E9")]
	public struct ADVANCEDSETTINGS
	{
		[Token(Token = "0x4000550")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int cbsize;

		[Token(Token = "0x4000551")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public int commandqueuesize;

		[Token(Token = "0x4000552")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public int handleinitialsize;

		[Token(Token = "0x4000553")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public int studioupdateperiod;

		[Token(Token = "0x4000554")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int idlesampledatapoolsize;

		[Token(Token = "0x4000555")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public int streamingscheduledelay;

		[Token(Token = "0x4000556")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public IntPtr encryptionkey;
	}
	[Token(Token = "0x20000EA")]
	public struct CPU_USAGE
	{
		[Token(Token = "0x4000557")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float dspusage;

		[Token(Token = "0x4000558")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public float streamusage;

		[Token(Token = "0x4000559")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public float geometryusage;

		[Token(Token = "0x400055A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public float updateusage;

		[Token(Token = "0x400055B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float studiousage;
	}
	[Token(Token = "0x20000EB")]
	public struct BUFFER_INFO
	{
		[Token(Token = "0x400055C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int currentusage;

		[Token(Token = "0x400055D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public int peakusage;

		[Token(Token = "0x400055E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public int capacity;

		[Token(Token = "0x400055F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public int stallcount;

		[Token(Token = "0x4000560")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float stalltime;
	}
	[Token(Token = "0x20000EC")]
	public struct BUFFER_USAGE
	{
		[Token(Token = "0x4000561")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public BUFFER_INFO studiocommandqueue;

		[Token(Token = "0x4000562")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public BUFFER_INFO studiohandle;
	}
	[Token(Token = "0x20000ED")]
	public struct BANK_INFO
	{
		[Token(Token = "0x4000563")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int size;

		[Token(Token = "0x4000564")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public IntPtr userdata;

		[Token(Token = "0x4000565")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int userdatalength;

		[Token(Token = "0x4000566")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public FILE_OPEN_CALLBACK opencallback;

		[Token(Token = "0x4000567")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public FILE_CLOSE_CALLBACK closecallback;

		[Token(Token = "0x4000568")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public FILE_READ_CALLBACK readcallback;

		[Token(Token = "0x4000569")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public FILE_SEEK_CALLBACK seekcallback;
	}
	[Token(Token = "0x20000EE")]
	[Flags]
	public enum SYSTEM_CALLBACK_TYPE : uint
	{
		[Token(Token = "0x400056B")]
		PREUPDATE = 1u,
		[Token(Token = "0x400056C")]
		POSTUPDATE = 2u,
		[Token(Token = "0x400056D")]
		BANK_UNLOAD = 4u,
		[Token(Token = "0x400056E")]
		ALL = uint.MaxValue
	}
	[Token(Token = "0x20000EF")]
	public delegate RESULT SYSTEM_CALLBACK(IntPtr system, SYSTEM_CALLBACK_TYPE type, IntPtr commanddata, IntPtr userdata);
	[Token(Token = "0x20000F0")]
	public enum PARAMETER_TYPE
	{
		[Token(Token = "0x4000570")]
		GAME_CONTROLLED,
		[Token(Token = "0x4000571")]
		AUTOMATIC_DISTANCE,
		[Token(Token = "0x4000572")]
		AUTOMATIC_EVENT_CONE_ANGLE,
		[Token(Token = "0x4000573")]
		AUTOMATIC_EVENT_ORIENTATION,
		[Token(Token = "0x4000574")]
		AUTOMATIC_DIRECTION,
		[Token(Token = "0x4000575")]
		AUTOMATIC_ELEVATION,
		[Token(Token = "0x4000576")]
		AUTOMATIC_LISTENER_ORIENTATION,
		[Token(Token = "0x4000577")]
		AUTOMATIC_SPEED,
		[Token(Token = "0x4000578")]
		MAX
	}
	[Token(Token = "0x20000F1")]
	[Flags]
	public enum PARAMETER_FLAGS : uint
	{
		[Token(Token = "0x400057A")]
		READONLY = 1u,
		[Token(Token = "0x400057B")]
		AUTOMATIC = 2u,
		[Token(Token = "0x400057C")]
		GLOBAL = 4u
	}
	[Token(Token = "0x20000F2")]
	public struct PARAMETER_ID
	{
		[Token(Token = "0x400057D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public uint data1;

		[Token(Token = "0x400057E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public uint data2;
	}
	[Token(Token = "0x20000F3")]
	public struct PARAMETER_DESCRIPTION
	{
		[Token(Token = "0x400057F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public StringWrapper name;

		[Token(Token = "0x4000580")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public PARAMETER_ID id;

		[Token(Token = "0x4000581")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float minimum;

		[Token(Token = "0x4000582")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public float maximum;

		[Token(Token = "0x4000583")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float defaultvalue;

		[Token(Token = "0x4000584")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public PARAMETER_TYPE type;

		[Token(Token = "0x4000585")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public PARAMETER_FLAGS flags;
	}
	[Token(Token = "0x20000F4")]
	internal enum LOAD_MEMORY_MODE
	{
		[Token(Token = "0x4000587")]
		LOAD_MEMORY,
		[Token(Token = "0x4000588")]
		LOAD_MEMORY_POINT
	}
	[Token(Token = "0x20000F5")]
	internal enum LOAD_MEMORY_ALIGNMENT
	{
		[Token(Token = "0x400058A")]
		VALUE = 0x20
	}
	[Token(Token = "0x20000F6")]
	public struct SOUND_INFO
	{
		[Token(Token = "0x400058B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public IntPtr name_or_data;

		[Token(Token = "0x400058C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public MODE mode;

		[Token(Token = "0x400058D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public CREATESOUNDEXINFO exinfo;

		[Token(Token = "0x400058E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		public int subsoundindex;

		[Token(Token = "0x1700004A")]
		public string name
		{
			[Token(Token = "0x600060F")]
			[Address(RVA = "0x9C85C0", Offset = "0x9C85C0", VA = "0x9C85C0")]
			get
			{
				return null;
			}
		}
	}
	[Token(Token = "0x20000F7")]
	public enum USER_PROPERTY_TYPE
	{
		[Token(Token = "0x4000590")]
		INTEGER,
		[Token(Token = "0x4000591")]
		BOOLEAN,
		[Token(Token = "0x4000592")]
		FLOAT,
		[Token(Token = "0x4000593")]
		STRING
	}
	[Token(Token = "0x20000F8")]
	public struct USER_PROPERTY
	{
		[Token(Token = "0x4000594")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public StringWrapper name;

		[Token(Token = "0x4000595")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public USER_PROPERTY_TYPE type;

		[Token(Token = "0x4000596")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private Union_IntBoolFloatString value;

		[Token(Token = "0x6000610")]
		[Address(RVA = "0x9C89EC", Offset = "0x9C89EC", VA = "0x9C89EC")]
		public int intValue()
		{
			return default(int);
		}

		[Token(Token = "0x6000611")]
		[Address(RVA = "0x9C8A04", Offset = "0x9C8A04", VA = "0x9C8A04")]
		public bool boolValue()
		{
			return default(bool);
		}

		[Token(Token = "0x6000612")]
		[Address(RVA = "0x9C8A28", Offset = "0x9C8A28", VA = "0x9C8A28")]
		public float floatValue()
		{
			return default(float);
		}

		[Token(Token = "0x6000613")]
		[Address(RVA = "0x9C8A44", Offset = "0x9C8A44", VA = "0x9C8A44")]
		public string stringValue()
		{
			return null;
		}
	}
	[StructLayout(2)]
	[Token(Token = "0x20000F9")]
	internal struct Union_IntBoolFloatString
	{
		[Token(Token = "0x4000597")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int intvalue;

		[Token(Token = "0x4000598")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public bool boolvalue;

		[Token(Token = "0x4000599")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float floatvalue;

		[Token(Token = "0x400059A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public StringWrapper stringvalue;
	}
	[Token(Token = "0x20000FA")]
	[Flags]
	public enum INITFLAGS : uint
	{
		[Token(Token = "0x400059C")]
		NORMAL = 0u,
		[Token(Token = "0x400059D")]
		LIVEUPDATE = 1u,
		[Token(Token = "0x400059E")]
		ALLOW_MISSING_PLUGINS = 2u,
		[Token(Token = "0x400059F")]
		SYNCHRONOUS_UPDATE = 4u,
		[Token(Token = "0x40005A0")]
		DEFERRED_CALLBACKS = 8u,
		[Token(Token = "0x40005A1")]
		LOAD_FROM_UPDATE = 0x10u
	}
	[Token(Token = "0x20000FB")]
	[Flags]
	public enum LOAD_BANK_FLAGS : uint
	{
		[Token(Token = "0x40005A3")]
		NORMAL = 0u,
		[Token(Token = "0x40005A4")]
		NONBLOCKING = 1u,
		[Token(Token = "0x40005A5")]
		DECOMPRESS_SAMPLES = 2u,
		[Token(Token = "0x40005A6")]
		UNENCRYPTED = 4u
	}
	[Token(Token = "0x20000FC")]
	[Flags]
	public enum COMMANDCAPTURE_FLAGS : uint
	{
		[Token(Token = "0x40005A8")]
		NORMAL = 0u,
		[Token(Token = "0x40005A9")]
		FILEFLUSH = 1u,
		[Token(Token = "0x40005AA")]
		SKIP_INITIAL_STATE = 2u
	}
	[Token(Token = "0x20000FD")]
	[Flags]
	public enum COMMANDREPLAY_FLAGS : uint
	{
		[Token(Token = "0x40005AC")]
		NORMAL = 0u,
		[Token(Token = "0x40005AD")]
		SKIP_CLEANUP = 1u,
		[Token(Token = "0x40005AE")]
		FAST_FORWARD = 2u,
		[Token(Token = "0x40005AF")]
		SKIP_BANK_LOAD = 4u
	}
	[Token(Token = "0x20000FE")]
	public enum PLAYBACK_STATE
	{
		[Token(Token = "0x40005B1")]
		PLAYING,
		[Token(Token = "0x40005B2")]
		SUSTAINING,
		[Token(Token = "0x40005B3")]
		STOPPED,
		[Token(Token = "0x40005B4")]
		STARTING,
		[Token(Token = "0x40005B5")]
		STOPPING
	}
	[Token(Token = "0x20000FF")]
	public enum EVENT_PROPERTY
	{
		[Token(Token = "0x40005B7")]
		CHANNELPRIORITY,
		[Token(Token = "0x40005B8")]
		SCHEDULE_DELAY,
		[Token(Token = "0x40005B9")]
		SCHEDULE_LOOKAHEAD,
		[Token(Token = "0x40005BA")]
		MINIMUM_DISTANCE,
		[Token(Token = "0x40005BB")]
		MAXIMUM_DISTANCE,
		[Token(Token = "0x40005BC")]
		MAX
	}
	[Token(Token = "0x2000100")]
	public struct PLUGIN_INSTANCE_PROPERTIES
	{
		[Token(Token = "0x40005BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public IntPtr name;

		[Token(Token = "0x40005BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public IntPtr dsp;
	}
	[Token(Token = "0x2000101")]
	[Flags]
	public enum EVENT_CALLBACK_TYPE : uint
	{
		[Token(Token = "0x40005C0")]
		CREATED = 1u,
		[Token(Token = "0x40005C1")]
		DESTROYED = 2u,
		[Token(Token = "0x40005C2")]
		STARTING = 4u,
		[Token(Token = "0x40005C3")]
		STARTED = 8u,
		[Token(Token = "0x40005C4")]
		RESTARTED = 0x10u,
		[Token(Token = "0x40005C5")]
		STOPPED = 0x20u,
		[Token(Token = "0x40005C6")]
		START_FAILED = 0x40u,
		[Token(Token = "0x40005C7")]
		CREATE_PROGRAMMER_SOUND = 0x80u,
		[Token(Token = "0x40005C8")]
		DESTROY_PROGRAMMER_SOUND = 0x100u,
		[Token(Token = "0x40005C9")]
		PLUGIN_CREATED = 0x200u,
		[Token(Token = "0x40005CA")]
		PLUGIN_DESTROYED = 0x400u,
		[Token(Token = "0x40005CB")]
		TIMELINE_MARKER = 0x800u,
		[Token(Token = "0x40005CC")]
		TIMELINE_BEAT = 0x1000u,
		[Token(Token = "0x40005CD")]
		SOUND_PLAYED = 0x2000u,
		[Token(Token = "0x40005CE")]
		SOUND_STOPPED = 0x4000u,
		[Token(Token = "0x40005CF")]
		REAL_TO_VIRTUAL = 0x8000u,
		[Token(Token = "0x40005D0")]
		VIRTUAL_TO_REAL = 0x10000u,
		[Token(Token = "0x40005D1")]
		ALL = uint.MaxValue
	}
	[Token(Token = "0x2000102")]
	public delegate RESULT EVENT_CALLBACK(EVENT_CALLBACK_TYPE type, EventInstance _event, IntPtr parameters);
	[Token(Token = "0x2000103")]
	public delegate RESULT COMMANDREPLAY_FRAME_CALLBACK(CommandReplay replay, int commandindex, float currenttime, IntPtr userdata);
	[Token(Token = "0x2000104")]
	public delegate RESULT COMMANDREPLAY_LOAD_BANK_CALLBACK(CommandReplay replay, int commandindex, Guid bankguid, StringWrapper bankfilename, LOAD_BANK_FLAGS flags, out Bank bank, IntPtr userdata);
	[Token(Token = "0x2000105")]
	public delegate RESULT COMMANDREPLAY_CREATE_INSTANCE_CALLBACK(CommandReplay replay, int commandindex, EventDescription eventdescription, out EventInstance instance, IntPtr userdata);
	[Token(Token = "0x2000106")]
	public enum INSTANCETYPE
	{
		[Token(Token = "0x40005D3")]
		NONE,
		[Token(Token = "0x40005D4")]
		SYSTEM,
		[Token(Token = "0x40005D5")]
		EVENTDESCRIPTION,
		[Token(Token = "0x40005D6")]
		EVENTINSTANCE,
		[Token(Token = "0x40005D7")]
		PARAMETERINSTANCE,
		[Token(Token = "0x40005D8")]
		BUS,
		[Token(Token = "0x40005D9")]
		VCA,
		[Token(Token = "0x40005DA")]
		BANK,
		[Token(Token = "0x40005DB")]
		COMMANDREPLAY
	}
	[Token(Token = "0x2000107")]
	public struct COMMAND_INFO
	{
		[Token(Token = "0x40005DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public StringWrapper commandname;

		[Token(Token = "0x40005DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public int parentcommandindex;

		[Token(Token = "0x40005DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public int framenumber;

		[Token(Token = "0x40005DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float frametime;

		[Token(Token = "0x40005E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public INSTANCETYPE instancetype;

		[Token(Token = "0x40005E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public INSTANCETYPE outputtype;

		[Token(Token = "0x40005E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public uint instancehandle;

		[Token(Token = "0x40005E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public uint outputhandle;
	}
	[Token(Token = "0x2000108")]
	public struct Util
	{
		[Token(Token = "0x6000624")]
		[Address(RVA = "0x1A5C05C", Offset = "0x1A5C05C", VA = "0x1A5C05C")]
		public static RESULT parseID(string idString, out Guid id)
		{
			return default(RESULT);
		}

		[PreserveSig]
		[Token(Token = "0x6000625")]
		[Address(RVA = "0x1A5C1B0", Offset = "0x1A5C1B0", VA = "0x1A5C1B0")]
		private static extern RESULT FMOD_Studio_ParseID(byte[] idString, out Guid id);
	}
	[Token(Token = "0x2000109")]
	public struct System
	{
		[Token(Token = "0x40005E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public IntPtr handle;

		[Token(Token = "0x6000626")]
		[Address(RVA = "0x1A57C8C", Offset = "0x1A57C8C", VA = "0x1A57C8C")]
		public static RESULT create(out System system)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000627")]
		[Address(RVA = "0x9C85E4", Offset = "0x9C85E4", VA = "0x9C85E4")]
		public RESULT setAdvancedSettings(ADVANCEDSETTINGS settings)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000628")]
		[Address(RVA = "0x9C8618", Offset = "0x9C8618", VA = "0x9C8618")]
		public RESULT setAdvancedSettings(ADVANCEDSETTINGS settings, string encryptionKey)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000629")]
		[Address(RVA = "0x9C864C", Offset = "0x9C864C", VA = "0x9C864C")]
		public RESULT getAdvancedSettings(out ADVANCEDSETTINGS settings)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600062A")]
		[Address(RVA = "0x9C8654", Offset = "0x9C8654", VA = "0x9C8654")]
		public RESULT initialize(int maxchannels, INITFLAGS studioflags, FMOD.INITFLAGS flags, IntPtr extradriverdata)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600062B")]
		[Address(RVA = "0x9C865C", Offset = "0x9C865C", VA = "0x9C865C")]
		public RESULT release()
		{
			return default(RESULT);
		}

		[Token(Token = "0x600062C")]
		[Address(RVA = "0x9C8664", Offset = "0x9C8664", VA = "0x9C8664")]
		public RESULT update()
		{
			return default(RESULT);
		}

		[Token(Token = "0x600062D")]
		[Address(RVA = "0x9C866C", Offset = "0x9C866C", VA = "0x9C866C")]
		public RESULT getCoreSystem(out FMOD.System coresystem)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600062E")]
		[Address(RVA = "0x9C8674", Offset = "0x9C8674", VA = "0x9C8674")]
		public RESULT getEvent(string path, out EventDescription _event)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600062F")]
		[Address(RVA = "0x9C867C", Offset = "0x9C867C", VA = "0x9C867C")]
		public RESULT getBus(string path, out Bus bus)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000630")]
		[Address(RVA = "0x9C8684", Offset = "0x9C8684", VA = "0x9C8684")]
		public RESULT getVCA(string path, out VCA vca)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000631")]
		[Address(RVA = "0x9C868C", Offset = "0x9C868C", VA = "0x9C868C")]
		public RESULT getBank(string path, out Bank bank)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000632")]
		[Address(RVA = "0x9C8694", Offset = "0x9C8694", VA = "0x9C8694")]
		public RESULT getEventByID(Guid id, out EventDescription _event)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000633")]
		[Address(RVA = "0x9C86C0", Offset = "0x9C86C0", VA = "0x9C86C0")]
		public RESULT getBusByID(Guid id, out Bus bus)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000634")]
		[Address(RVA = "0x9C86EC", Offset = "0x9C86EC", VA = "0x9C86EC")]
		public RESULT getVCAByID(Guid id, out VCA vca)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000635")]
		[Address(RVA = "0x9C8718", Offset = "0x9C8718", VA = "0x9C8718")]
		public RESULT getBankByID(Guid id, out Bank bank)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000636")]
		[Address(RVA = "0x9C8744", Offset = "0x9C8744", VA = "0x9C8744")]
		public RESULT getSoundInfo(string key, out SOUND_INFO info)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000637")]
		[Address(RVA = "0x9C874C", Offset = "0x9C874C", VA = "0x9C874C")]
		public RESULT getParameterDescriptionByName(string name, out PARAMETER_DESCRIPTION parameter)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000638")]
		[Address(RVA = "0x9C8754", Offset = "0x9C8754", VA = "0x9C8754")]
		public RESULT getParameterDescriptionByID(PARAMETER_ID id, out PARAMETER_DESCRIPTION parameter)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000639")]
		[Address(RVA = "0x9C875C", Offset = "0x9C875C", VA = "0x9C875C")]
		public RESULT getParameterByID(PARAMETER_ID id, out float value)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600063A")]
		[Address(RVA = "0x9C8784", Offset = "0x9C8784", VA = "0x9C8784")]
		public RESULT getParameterByID(PARAMETER_ID id, out float value, out float finalvalue)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600063B")]
		[Address(RVA = "0x9C878C", Offset = "0x9C878C", VA = "0x9C878C")]
		public RESULT setParameterByID(PARAMETER_ID id, float value, bool ignoreseekspeed = false)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600063C")]
		[Address(RVA = "0x9C8798", Offset = "0x9C8798", VA = "0x9C8798")]
		public RESULT setParametersByIDs(PARAMETER_ID[] ids, float[] values, int count, bool ignoreseekspeed = false)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600063D")]
		[Address(RVA = "0x9C87A4", Offset = "0x9C87A4", VA = "0x9C87A4")]
		public RESULT getParameterByName(string name, out float value)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600063E")]
		[Address(RVA = "0x9C87CC", Offset = "0x9C87CC", VA = "0x9C87CC")]
		public RESULT getParameterByName(string name, out float value, out float finalvalue)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600063F")]
		[Address(RVA = "0x9C87D4", Offset = "0x9C87D4", VA = "0x9C87D4")]
		public RESULT setParameterByName(string name, float value, bool ignoreseekspeed = false)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000640")]
		[Address(RVA = "0x9C87E0", Offset = "0x9C87E0", VA = "0x9C87E0")]
		public RESULT lookupID(string path, out Guid id)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000641")]
		[Address(RVA = "0x9C87E8", Offset = "0x9C87E8", VA = "0x9C87E8")]
		public RESULT lookupPath(Guid id, out string path)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000642")]
		[Address(RVA = "0x9C87F0", Offset = "0x9C87F0", VA = "0x9C87F0")]
		public RESULT getNumListeners(out int numlisteners)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000643")]
		[Address(RVA = "0x9C87F8", Offset = "0x9C87F8", VA = "0x9C87F8")]
		public RESULT setNumListeners(int numlisteners)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000644")]
		[Address(RVA = "0x9C8800", Offset = "0x9C8800", VA = "0x9C8800")]
		public RESULT getListenerAttributes(int listener, out ATTRIBUTES_3D attributes)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000645")]
		[Address(RVA = "0x9C8808", Offset = "0x9C8808", VA = "0x9C8808")]
		public RESULT setListenerAttributes(int listener, ATTRIBUTES_3D attributes)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000646")]
		[Address(RVA = "0x9C8844", Offset = "0x9C8844", VA = "0x9C8844")]
		public RESULT getListenerWeight(int listener, out float weight)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000647")]
		[Address(RVA = "0x9C884C", Offset = "0x9C884C", VA = "0x9C884C")]
		public RESULT setListenerWeight(int listener, float weight)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000648")]
		[Address(RVA = "0x9C8854", Offset = "0x9C8854", VA = "0x9C8854")]
		public RESULT loadBankFile(string filename, LOAD_BANK_FLAGS flags, out Bank bank)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000649")]
		[Address(RVA = "0x9C885C", Offset = "0x9C885C", VA = "0x9C885C")]
		public RESULT loadBankMemory(byte[] buffer, LOAD_BANK_FLAGS flags, out Bank bank)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600064A")]
		[Address(RVA = "0x9C8864", Offset = "0x9C8864", VA = "0x9C8864")]
		public RESULT loadBankCustom(BANK_INFO info, LOAD_BANK_FLAGS flags, out Bank bank)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600064B")]
		[Address(RVA = "0x9C88A8", Offset = "0x9C88A8", VA = "0x9C88A8")]
		public RESULT unloadAll()
		{
			return default(RESULT);
		}

		[Token(Token = "0x600064C")]
		[Address(RVA = "0x9C88B0", Offset = "0x9C88B0", VA = "0x9C88B0")]
		public RESULT flushCommands()
		{
			return default(RESULT);
		}

		[Token(Token = "0x600064D")]
		[Address(RVA = "0x9C88B8", Offset = "0x9C88B8", VA = "0x9C88B8")]
		public RESULT flushSampleLoading()
		{
			return default(RESULT);
		}

		[Token(Token = "0x600064E")]
		[Address(RVA = "0x9C88C0", Offset = "0x9C88C0", VA = "0x9C88C0")]
		public RESULT startCommandCapture(string filename, COMMANDCAPTURE_FLAGS flags)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600064F")]
		[Address(RVA = "0x9C88C8", Offset = "0x9C88C8", VA = "0x9C88C8")]
		public RESULT stopCommandCapture()
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000650")]
		[Address(RVA = "0x9C88D0", Offset = "0x9C88D0", VA = "0x9C88D0")]
		public RESULT loadCommandReplay(string filename, COMMANDREPLAY_FLAGS flags, out CommandReplay replay)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000651")]
		[Address(RVA = "0x9C88D8", Offset = "0x9C88D8", VA = "0x9C88D8")]
		public RESULT getBankCount(out int count)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000652")]
		[Address(RVA = "0x9C88E0", Offset = "0x9C88E0", VA = "0x9C88E0")]
		public RESULT getBankList(out Bank[] array)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000653")]
		[Address(RVA = "0x9C88E8", Offset = "0x9C88E8", VA = "0x9C88E8")]
		public RESULT getParameterDescriptionCount(out int count)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000654")]
		[Address(RVA = "0x9C88F0", Offset = "0x9C88F0", VA = "0x9C88F0")]
		public RESULT getParameterDescriptionList(out PARAMETER_DESCRIPTION[] array)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000655")]
		[Address(RVA = "0x9C88F8", Offset = "0x9C88F8", VA = "0x9C88F8")]
		public RESULT getCPUUsage(out CPU_USAGE usage)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000656")]
		[Address(RVA = "0x9C8900", Offset = "0x9C8900", VA = "0x9C8900")]
		public RESULT getBufferUsage(out BUFFER_USAGE usage)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000657")]
		[Address(RVA = "0x9C8908", Offset = "0x9C8908", VA = "0x9C8908")]
		public RESULT resetBufferUsage()
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000658")]
		[Address(RVA = "0x9C8910", Offset = "0x9C8910", VA = "0x9C8910")]
		public RESULT setCallback(SYSTEM_CALLBACK callback, SYSTEM_CALLBACK_TYPE callbackmask = SYSTEM_CALLBACK_TYPE.ALL)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000659")]
		[Address(RVA = "0x9C8918", Offset = "0x9C8918", VA = "0x9C8918")]
		public RESULT getUserData(out IntPtr userdata)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600065A")]
		[Address(RVA = "0x9C8920", Offset = "0x9C8920", VA = "0x9C8920")]
		public RESULT setUserData(IntPtr userdata)
		{
			return default(RESULT);
		}

		[PreserveSig]
		[Token(Token = "0x600065B")]
		[Address(RVA = "0x1A57C98", Offset = "0x1A57C98", VA = "0x1A57C98")]
		private static extern RESULT FMOD_Studio_System_Create(out IntPtr system, uint headerversion);

		[PreserveSig]
		[Token(Token = "0x600065C")]
		[Address(RVA = "0x1A5BE30", Offset = "0x1A5BE30", VA = "0x1A5BE30")]
		private static extern bool FMOD_Studio_System_IsValid(IntPtr system);

		[PreserveSig]
		[Token(Token = "0x600065D")]
		[Address(RVA = "0x1A57E08", Offset = "0x1A57E08", VA = "0x1A57E08")]
		private static extern RESULT FMOD_Studio_System_SetAdvancedSettings(IntPtr system, ref ADVANCEDSETTINGS settings);

		[PreserveSig]
		[Token(Token = "0x600065E")]
		[Address(RVA = "0x1A58100", Offset = "0x1A58100", VA = "0x1A58100")]
		private static extern RESULT FMOD_Studio_System_GetAdvancedSettings(IntPtr system, out ADVANCEDSETTINGS settings);

		[PreserveSig]
		[Token(Token = "0x600065F")]
		[Address(RVA = "0x1A581B4", Offset = "0x1A581B4", VA = "0x1A581B4")]
		private static extern RESULT FMOD_Studio_System_Initialize(IntPtr system, int maxchannels, INITFLAGS studioflags, FMOD.INITFLAGS flags, IntPtr extradriverdata);

		[PreserveSig]
		[Token(Token = "0x6000660")]
		[Address(RVA = "0x1A58288", Offset = "0x1A58288", VA = "0x1A58288")]
		private static extern RESULT FMOD_Studio_System_Release(IntPtr system);

		[PreserveSig]
		[Token(Token = "0x6000661")]
		[Address(RVA = "0x1A5832C", Offset = "0x1A5832C", VA = "0x1A5832C")]
		private static extern RESULT FMOD_Studio_System_Update(IntPtr system);

		[PreserveSig]
		[Token(Token = "0x6000662")]
		[Address(RVA = "0x1A583D0", Offset = "0x1A583D0", VA = "0x1A583D0")]
		private static extern RESULT FMOD_Studio_System_GetCoreSystem(IntPtr system, out IntPtr coresystem);

		[PreserveSig]
		[Token(Token = "0x6000663")]
		[Address(RVA = "0x1A585E0", Offset = "0x1A585E0", VA = "0x1A585E0")]
		private static extern RESULT FMOD_Studio_System_GetEvent(IntPtr system, byte[] path, out IntPtr _event);

		[PreserveSig]
		[Token(Token = "0x6000664")]
		[Address(RVA = "0x1A58800", Offset = "0x1A58800", VA = "0x1A58800")]
		private static extern RESULT FMOD_Studio_System_GetBus(IntPtr system, byte[] path, out IntPtr bus);

		[PreserveSig]
		[Token(Token = "0x6000665")]
		[Address(RVA = "0x1A58A20", Offset = "0x1A58A20", VA = "0x1A58A20")]
		private static extern RESULT FMOD_Studio_System_GetVCA(IntPtr system, byte[] path, out IntPtr vca);

		[PreserveSig]
		[Token(Token = "0x6000666")]
		[Address(RVA = "0x1A58C40", Offset = "0x1A58C40", VA = "0x1A58C40")]
		private static extern RESULT FMOD_Studio_System_GetBank(IntPtr system, byte[] path, out IntPtr bank);

		[PreserveSig]
		[Token(Token = "0x6000667")]
		[Address(RVA = "0x1A58D28", Offset = "0x1A58D28", VA = "0x1A58D28")]
		private static extern RESULT FMOD_Studio_System_GetEventByID(IntPtr system, ref Guid id, out IntPtr _event);

		[PreserveSig]
		[Token(Token = "0x6000668")]
		[Address(RVA = "0x1A58E08", Offset = "0x1A58E08", VA = "0x1A58E08")]
		private static extern RESULT FMOD_Studio_System_GetBusByID(IntPtr system, ref Guid id, out IntPtr bus);

		[PreserveSig]
		[Token(Token = "0x6000669")]
		[Address(RVA = "0x1A58EE8", Offset = "0x1A58EE8", VA = "0x1A58EE8")]
		private static extern RESULT FMOD_Studio_System_GetVCAByID(IntPtr system, ref Guid id, out IntPtr vca);

		[PreserveSig]
		[Token(Token = "0x600066A")]
		[Address(RVA = "0x1A58FC8", Offset = "0x1A58FC8", VA = "0x1A58FC8")]
		private static extern RESULT FMOD_Studio_System_GetBankByID(IntPtr system, ref Guid id, out IntPtr bank);

		[PreserveSig]
		[Token(Token = "0x600066B")]
		[Address(RVA = "0x1A591E0", Offset = "0x1A591E0", VA = "0x1A591E0")]
		private static extern RESULT FMOD_Studio_System_GetSoundInfo(IntPtr system, byte[] key, out SOUND_INFO info);

		[PreserveSig]
		[Token(Token = "0x600066C")]
		[Address(RVA = "0x1A594A4", Offset = "0x1A594A4", VA = "0x1A594A4")]
		private static extern RESULT FMOD_Studio_System_GetParameterDescriptionByName(IntPtr system, byte[] name, out PARAMETER_DESCRIPTION parameter);

		[PreserveSig]
		[Token(Token = "0x600066D")]
		[Address(RVA = "0x1A59568", Offset = "0x1A59568", VA = "0x1A59568")]
		private static extern RESULT FMOD_Studio_System_GetParameterDescriptionByID(IntPtr system, PARAMETER_ID id, out PARAMETER_DESCRIPTION parameter);

		[PreserveSig]
		[Token(Token = "0x600066E")]
		[Address(RVA = "0x1A5964C", Offset = "0x1A5964C", VA = "0x1A5964C")]
		private static extern RESULT FMOD_Studio_System_GetParameterByID(IntPtr system, PARAMETER_ID id, out float value, out float finalvalue);

		[PreserveSig]
		[Token(Token = "0x600066F")]
		[Address(RVA = "0x1A5971C", Offset = "0x1A5971C", VA = "0x1A5971C")]
		private static extern RESULT FMOD_Studio_System_SetParameterByID(IntPtr system, PARAMETER_ID id, float value, bool ignoreseekspeed);

		[PreserveSig]
		[Token(Token = "0x6000670")]
		[Address(RVA = "0x1A597EC", Offset = "0x1A597EC", VA = "0x1A597EC")]
		private static extern RESULT FMOD_Studio_System_SetParametersByIDs(IntPtr system, PARAMETER_ID[] ids, float[] values, int count, bool ignoreseekspeed);

		[PreserveSig]
		[Token(Token = "0x6000671")]
		[Address(RVA = "0x1A59A60", Offset = "0x1A59A60", VA = "0x1A59A60")]
		private static extern RESULT FMOD_Studio_System_GetParameterByName(IntPtr system, byte[] name, out float value, out float finalvalue);

		[PreserveSig]
		[Token(Token = "0x6000672")]
		[Address(RVA = "0x1A59CA0", Offset = "0x1A59CA0", VA = "0x1A59CA0")]
		private static extern RESULT FMOD_Studio_System_SetParameterByName(IntPtr system, byte[] name, float value, bool ignoreseekspeed);

		[PreserveSig]
		[Token(Token = "0x6000673")]
		[Address(RVA = "0x1A59ED0", Offset = "0x1A59ED0", VA = "0x1A59ED0")]
		private static extern RESULT FMOD_Studio_System_LookupID(IntPtr system, byte[] path, out Guid id);

		[PreserveSig]
		[Token(Token = "0x6000674")]
		[Address(RVA = "0x1A5A1E0", Offset = "0x1A5A1E0", VA = "0x1A5A1E0")]
		private static extern RESULT FMOD_Studio_System_LookupPath(IntPtr system, ref Guid id, IntPtr path, int size, out int retrieved);

		[PreserveSig]
		[Token(Token = "0x6000675")]
		[Address(RVA = "0x1A5A2B4", Offset = "0x1A5A2B4", VA = "0x1A5A2B4")]
		private static extern RESULT FMOD_Studio_System_GetNumListeners(IntPtr system, out int numlisteners);

		[PreserveSig]
		[Token(Token = "0x6000676")]
		[Address(RVA = "0x1A5A368", Offset = "0x1A5A368", VA = "0x1A5A368")]
		private static extern RESULT FMOD_Studio_System_SetNumListeners(IntPtr system, int numlisteners);

		[PreserveSig]
		[Token(Token = "0x6000677")]
		[Address(RVA = "0x1A5A41C", Offset = "0x1A5A41C", VA = "0x1A5A41C")]
		private static extern RESULT FMOD_Studio_System_GetListenerAttributes(IntPtr system, int listener, out ATTRIBUTES_3D attributes);

		[PreserveSig]
		[Token(Token = "0x6000678")]
		[Address(RVA = "0x1A5A4D8", Offset = "0x1A5A4D8", VA = "0x1A5A4D8")]
		private static extern RESULT FMOD_Studio_System_SetListenerAttributes(IntPtr system, int listener, ref ATTRIBUTES_3D attributes);

		[PreserveSig]
		[Token(Token = "0x6000679")]
		[Address(RVA = "0x1A5A594", Offset = "0x1A5A594", VA = "0x1A5A594")]
		private static extern RESULT FMOD_Studio_System_GetListenerWeight(IntPtr system, int listener, out float weight);

		[PreserveSig]
		[Token(Token = "0x600067A")]
		[Address(RVA = "0x1A5A650", Offset = "0x1A5A650", VA = "0x1A5A650")]
		private static extern RESULT FMOD_Studio_System_SetListenerWeight(IntPtr system, int listener, float weight);

		[PreserveSig]
		[Token(Token = "0x600067B")]
		[Address(RVA = "0x1A5A880", Offset = "0x1A5A880", VA = "0x1A5A880")]
		private static extern RESULT FMOD_Studio_System_LoadBankFile(IntPtr system, byte[] filename, LOAD_BANK_FLAGS flags, out IntPtr bank);

		[PreserveSig]
		[Token(Token = "0x600067C")]
		[Address(RVA = "0x1A5A9E8", Offset = "0x1A5A9E8", VA = "0x1A5A9E8")]
		private static extern RESULT FMOD_Studio_System_LoadBankMemory(IntPtr system, IntPtr buffer, int length, LOAD_MEMORY_MODE mode, LOAD_BANK_FLAGS flags, out IntPtr bank);

		[PreserveSig]
		[Token(Token = "0x600067D")]
		[Address(RVA = "0x1A5ABAC", Offset = "0x1A5ABAC", VA = "0x1A5ABAC")]
		private static extern RESULT FMOD_Studio_System_LoadBankCustom(IntPtr system, ref BANK_INFO info, LOAD_BANK_FLAGS flags, out IntPtr bank);

		[PreserveSig]
		[Token(Token = "0x600067E")]
		[Address(RVA = "0x1A5ACDC", Offset = "0x1A5ACDC", VA = "0x1A5ACDC")]
		private static extern RESULT FMOD_Studio_System_UnloadAll(IntPtr system);

		[PreserveSig]
		[Token(Token = "0x600067F")]
		[Address(RVA = "0x1A5AD80", Offset = "0x1A5AD80", VA = "0x1A5AD80")]
		private static extern RESULT FMOD_Studio_System_FlushCommands(IntPtr system);

		[PreserveSig]
		[Token(Token = "0x6000680")]
		[Address(RVA = "0x1A5AE24", Offset = "0x1A5AE24", VA = "0x1A5AE24")]
		private static extern RESULT FMOD_Studio_System_FlushSampleLoading(IntPtr system);

		[PreserveSig]
		[Token(Token = "0x6000681")]
		[Address(RVA = "0x1A5B024", Offset = "0x1A5B024", VA = "0x1A5B024")]
		private static extern RESULT FMOD_Studio_System_StartCommandCapture(IntPtr system, byte[] filename, COMMANDCAPTURE_FLAGS flags);

		[PreserveSig]
		[Token(Token = "0x6000682")]
		[Address(RVA = "0x1A5B0E8", Offset = "0x1A5B0E8", VA = "0x1A5B0E8")]
		private static extern RESULT FMOD_Studio_System_StopCommandCapture(IntPtr system);

		[PreserveSig]
		[Token(Token = "0x6000683")]
		[Address(RVA = "0x1A5B2F8", Offset = "0x1A5B2F8", VA = "0x1A5B2F8")]
		private static extern RESULT FMOD_Studio_System_LoadCommandReplay(IntPtr system, byte[] filename, COMMANDREPLAY_FLAGS flags, out IntPtr replay);

		[PreserveSig]
		[Token(Token = "0x6000684")]
		[Address(RVA = "0x1A5B3CC", Offset = "0x1A5B3CC", VA = "0x1A5B3CC")]
		private static extern RESULT FMOD_Studio_System_GetBankCount(IntPtr system, out int count);

		[PreserveSig]
		[Token(Token = "0x6000685")]
		[Address(RVA = "0x1A5B618", Offset = "0x1A5B618", VA = "0x1A5B618")]
		private static extern RESULT FMOD_Studio_System_GetBankList(IntPtr system, IntPtr[] array, int capacity, out int count);

		[PreserveSig]
		[Token(Token = "0x6000686")]
		[Address(RVA = "0x1A5B6EC", Offset = "0x1A5B6EC", VA = "0x1A5B6EC")]
		private static extern RESULT FMOD_Studio_System_GetParameterDescriptionCount(IntPtr system, out int count);

		[PreserveSig]
		[Token(Token = "0x6000687")]
		[Address(RVA = "0x1A5B890", Offset = "0x1A5B890", VA = "0x1A5B890")]
		private static extern RESULT FMOD_Studio_System_GetParameterDescriptionList(IntPtr system, [Out] PARAMETER_DESCRIPTION[] array, int capacity, out int count);

		[PreserveSig]
		[Token(Token = "0x6000688")]
		[Address(RVA = "0x1A5BA00", Offset = "0x1A5BA00", VA = "0x1A5BA00")]
		private static extern RESULT FMOD_Studio_System_GetCPUUsage(IntPtr system, out CPU_USAGE usage);

		[PreserveSig]
		[Token(Token = "0x6000689")]
		[Address(RVA = "0x1A5BAB4", Offset = "0x1A5BAB4", VA = "0x1A5BAB4")]
		private static extern RESULT FMOD_Studio_System_GetBufferUsage(IntPtr system, out BUFFER_USAGE usage);

		[PreserveSig]
		[Token(Token = "0x600068A")]
		[Address(RVA = "0x1A5BB68", Offset = "0x1A5BB68", VA = "0x1A5BB68")]
		private static extern RESULT FMOD_Studio_System_ResetBufferUsage(IntPtr system);

		[PreserveSig]
		[Token(Token = "0x600068B")]
		[Address(RVA = "0x1A5BC0C", Offset = "0x1A5BC0C", VA = "0x1A5BC0C")]
		private static extern RESULT FMOD_Studio_System_SetCallback(IntPtr system, SYSTEM_CALLBACK callback, SYSTEM_CALLBACK_TYPE callbackmask);

		[PreserveSig]
		[Token(Token = "0x600068C")]
		[Address(RVA = "0x1A5BCD0", Offset = "0x1A5BCD0", VA = "0x1A5BCD0")]
		private static extern RESULT FMOD_Studio_System_GetUserData(IntPtr system, out IntPtr userdata);

		[PreserveSig]
		[Token(Token = "0x600068D")]
		[Address(RVA = "0x1A5BD84", Offset = "0x1A5BD84", VA = "0x1A5BD84")]
		private static extern RESULT FMOD_Studio_System_SetUserData(IntPtr system, IntPtr userdata);

		[Token(Token = "0x600068E")]
		[Address(RVA = "0x9C8928", Offset = "0x9C8928", VA = "0x9C8928")]
		public bool hasHandle()
		{
			return default(bool);
		}

		[Token(Token = "0x600068F")]
		[Address(RVA = "0x9C8930", Offset = "0x9C8930", VA = "0x9C8930")]
		public void clearHandle()
		{
		}

		[Token(Token = "0x6000690")]
		[Address(RVA = "0x9C8974", Offset = "0x9C8974", VA = "0x9C8974")]
		public bool isValid()
		{
			return default(bool);
		}
	}
	[Token(Token = "0x200010A")]
	public struct EventDescription
	{
		[Token(Token = "0x40005E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public IntPtr handle;

		[Token(Token = "0x6000691")]
		[Address(RVA = "0x9C8154", Offset = "0x9C8154", VA = "0x9C8154")]
		public RESULT getID(out Guid id)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000692")]
		[Address(RVA = "0x9C815C", Offset = "0x9C815C", VA = "0x9C815C")]
		public RESULT getPath(out string path)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000693")]
		[Address(RVA = "0x9C8164", Offset = "0x9C8164", VA = "0x9C8164")]
		public RESULT getParameterDescriptionCount(out int count)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000694")]
		[Address(RVA = "0x9C816C", Offset = "0x9C816C", VA = "0x9C816C")]
		public RESULT getParameterDescriptionByIndex(int index, out PARAMETER_DESCRIPTION parameter)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000695")]
		[Address(RVA = "0x9C8174", Offset = "0x9C8174", VA = "0x9C8174")]
		public RESULT getParameterDescriptionByName(string name, out PARAMETER_DESCRIPTION parameter)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000696")]
		[Address(RVA = "0x9C817C", Offset = "0x9C817C", VA = "0x9C817C")]
		public RESULT getParameterDescriptionByID(PARAMETER_ID id, out PARAMETER_DESCRIPTION parameter)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000697")]
		[Address(RVA = "0x9C8184", Offset = "0x9C8184", VA = "0x9C8184")]
		public RESULT getUserPropertyCount(out int count)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000698")]
		[Address(RVA = "0x9C818C", Offset = "0x9C818C", VA = "0x9C818C")]
		public RESULT getUserPropertyByIndex(int index, out USER_PROPERTY property)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000699")]
		[Address(RVA = "0x9C8194", Offset = "0x9C8194", VA = "0x9C8194")]
		public RESULT getUserProperty(string name, out USER_PROPERTY property)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600069A")]
		[Address(RVA = "0x9C819C", Offset = "0x9C819C", VA = "0x9C819C")]
		public RESULT getLength(out int length)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600069B")]
		[Address(RVA = "0x9C81A4", Offset = "0x9C81A4", VA = "0x9C81A4")]
		public RESULT getMinimumDistance(out float distance)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600069C")]
		[Address(RVA = "0x9C81AC", Offset = "0x9C81AC", VA = "0x9C81AC")]
		public RESULT getMaximumDistance(out float distance)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600069D")]
		[Address(RVA = "0x9C81B4", Offset = "0x9C81B4", VA = "0x9C81B4")]
		public RESULT getSoundSize(out float size)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600069E")]
		[Address(RVA = "0x9C81BC", Offset = "0x9C81BC", VA = "0x9C81BC")]
		public RESULT isSnapshot(out bool snapshot)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600069F")]
		[Address(RVA = "0x9C81C4", Offset = "0x9C81C4", VA = "0x9C81C4")]
		public RESULT isOneshot(out bool oneshot)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60006A0")]
		[Address(RVA = "0x9C81CC", Offset = "0x9C81CC", VA = "0x9C81CC")]
		public RESULT isStream(out bool isStream)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60006A1")]
		[Address(RVA = "0x9C81D4", Offset = "0x9C81D4", VA = "0x9C81D4")]
		public RESULT is3D(out bool is3D)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60006A2")]
		[Address(RVA = "0x9C81DC", Offset = "0x9C81DC", VA = "0x9C81DC")]
		public RESULT hasCue(out bool cue)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60006A3")]
		[Address(RVA = "0x9C81E4", Offset = "0x9C81E4", VA = "0x9C81E4")]
		public RESULT createInstance(out EventInstance instance)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60006A4")]
		[Address(RVA = "0x9C81EC", Offset = "0x9C81EC", VA = "0x9C81EC")]
		public RESULT getInstanceCount(out int count)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60006A5")]
		[Address(RVA = "0x9C81F4", Offset = "0x9C81F4", VA = "0x9C81F4")]
		public RESULT getInstanceList(out EventInstance[] array)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60006A6")]
		[Address(RVA = "0x9C81FC", Offset = "0x9C81FC", VA = "0x9C81FC")]
		public RESULT loadSampleData()
		{
			return default(RESULT);
		}

		[Token(Token = "0x60006A7")]
		[Address(RVA = "0x9C8204", Offset = "0x9C8204", VA = "0x9C8204")]
		public RESULT unloadSampleData()
		{
			return default(RESULT);
		}

		[Token(Token = "0x60006A8")]
		[Address(RVA = "0x9C820C", Offset = "0x9C820C", VA = "0x9C820C")]
		public RESULT getSampleLoadingState(out LOADING_STATE state)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60006A9")]
		[Address(RVA = "0x9C8214", Offset = "0x9C8214", VA = "0x9C8214")]
		public RESULT releaseAllInstances()
		{
			return default(RESULT);
		}

		[Token(Token = "0x60006AA")]
		[Address(RVA = "0x9C821C", Offset = "0x9C821C", VA = "0x9C821C")]
		public RESULT setCallback(EVENT_CALLBACK callback, EVENT_CALLBACK_TYPE callbackmask = EVENT_CALLBACK_TYPE.ALL)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60006AB")]
		[Address(RVA = "0x9C8224", Offset = "0x9C8224", VA = "0x9C8224")]
		public RESULT getUserData(out IntPtr userdata)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60006AC")]
		[Address(RVA = "0x9C822C", Offset = "0x9C822C", VA = "0x9C822C")]
		public RESULT setUserData(IntPtr userdata)
		{
			return default(RESULT);
		}

		[PreserveSig]
		[Token(Token = "0x60006AD")]
		[Address(RVA = "0x1A55744", Offset = "0x1A55744", VA = "0x1A55744")]
		private static extern bool FMOD_Studio_EventDescription_IsValid(IntPtr eventdescription);

		[PreserveSig]
		[Token(Token = "0x60006AE")]
		[Address(RVA = "0x1A53C18", Offset = "0x1A53C18", VA = "0x1A53C18")]
		private static extern RESULT FMOD_Studio_EventDescription_GetID(IntPtr eventdescription, out Guid id);

		[PreserveSig]
		[Token(Token = "0x60006AF")]
		[Address(RVA = "0x1A53F0C", Offset = "0x1A53F0C", VA = "0x1A53F0C")]
		private static extern RESULT FMOD_Studio_EventDescription_GetPath(IntPtr eventdescription, IntPtr path, int size, out int retrieved);

		[PreserveSig]
		[Token(Token = "0x60006B0")]
		[Address(RVA = "0x1A53FD8", Offset = "0x1A53FD8", VA = "0x1A53FD8")]
		private static extern RESULT FMOD_Studio_EventDescription_GetParameterDescriptionCount(IntPtr eventdescription, out int count);

		[PreserveSig]
		[Token(Token = "0x60006B1")]
		[Address(RVA = "0x1A5408C", Offset = "0x1A5408C", VA = "0x1A5408C")]
		private static extern RESULT FMOD_Studio_EventDescription_GetParameterDescriptionByIndex(IntPtr eventdescription, int index, out PARAMETER_DESCRIPTION parameter);

		[PreserveSig]
		[Token(Token = "0x60006B2")]
		[Address(RVA = "0x1A542A4", Offset = "0x1A542A4", VA = "0x1A542A4")]
		private static extern RESULT FMOD_Studio_EventDescription_GetParameterDescriptionByName(IntPtr eventdescription, byte[] name, out PARAMETER_DESCRIPTION parameter);

		[PreserveSig]
		[Token(Token = "0x60006B3")]
		[Address(RVA = "0x1A54368", Offset = "0x1A54368", VA = "0x1A54368")]
		private static extern RESULT FMOD_Studio_EventDescription_GetParameterDescriptionByID(IntPtr eventdescription, PARAMETER_ID id, out PARAMETER_DESCRIPTION parameter);

		[PreserveSig]
		[Token(Token = "0x60006B4")]
		[Address(RVA = "0x1A54424", Offset = "0x1A54424", VA = "0x1A54424")]
		private static extern RESULT FMOD_Studio_EventDescription_GetUserPropertyCount(IntPtr eventdescription, out int count);

		[PreserveSig]
		[Token(Token = "0x60006B5")]
		[Address(RVA = "0x1A544D8", Offset = "0x1A544D8", VA = "0x1A544D8")]
		private static extern RESULT FMOD_Studio_EventDescription_GetUserPropertyByIndex(IntPtr eventdescription, int index, out USER_PROPERTY property);

		[PreserveSig]
		[Token(Token = "0x60006B6")]
		[Address(RVA = "0x1A54710", Offset = "0x1A54710", VA = "0x1A54710")]
		private static extern RESULT FMOD_Studio_EventDescription_GetUserProperty(IntPtr eventdescription, byte[] name, out USER_PROPERTY property);

		[PreserveSig]
		[Token(Token = "0x60006B7")]
		[Address(RVA = "0x1A547F4", Offset = "0x1A547F4", VA = "0x1A547F4")]
		private static extern RESULT FMOD_Studio_EventDescription_GetLength(IntPtr eventdescription, out int length);

		[PreserveSig]
		[Token(Token = "0x60006B8")]
		[Address(RVA = "0x1A548A8", Offset = "0x1A548A8", VA = "0x1A548A8")]
		private static extern RESULT FMOD_Studio_EventDescription_GetMinimumDistance(IntPtr eventdescription, out float distance);

		[PreserveSig]
		[Token(Token = "0x60006B9")]
		[Address(RVA = "0x1A5495C", Offset = "0x1A5495C", VA = "0x1A5495C")]
		private static extern RESULT FMOD_Studio_EventDescription_GetMaximumDistance(IntPtr eventdescription, out float distance);

		[PreserveSig]
		[Token(Token = "0x60006BA")]
		[Address(RVA = "0x1A54A10", Offset = "0x1A54A10", VA = "0x1A54A10")]
		private static extern RESULT FMOD_Studio_EventDescription_GetSoundSize(IntPtr eventdescription, out float size);

		[PreserveSig]
		[Token(Token = "0x60006BB")]
		[Address(RVA = "0x1A54AC4", Offset = "0x1A54AC4", VA = "0x1A54AC4")]
		private static extern RESULT FMOD_Studio_EventDescription_IsSnapshot(IntPtr eventdescription, out bool snapshot);

		[PreserveSig]
		[Token(Token = "0x60006BC")]
		[Address(RVA = "0x1A54B8C", Offset = "0x1A54B8C", VA = "0x1A54B8C")]
		private static extern RESULT FMOD_Studio_EventDescription_IsOneshot(IntPtr eventdescription, out bool oneshot);

		[PreserveSig]
		[Token(Token = "0x60006BD")]
		[Address(RVA = "0x1A54C54", Offset = "0x1A54C54", VA = "0x1A54C54")]
		private static extern RESULT FMOD_Studio_EventDescription_IsStream(IntPtr eventdescription, out bool isStream);

		[PreserveSig]
		[Token(Token = "0x60006BE")]
		[Address(RVA = "0x1A54D1C", Offset = "0x1A54D1C", VA = "0x1A54D1C")]
		private static extern RESULT FMOD_Studio_EventDescription_Is3D(IntPtr eventdescription, out bool is3D);

		[PreserveSig]
		[Token(Token = "0x60006BF")]
		[Address(RVA = "0x1A54DE4", Offset = "0x1A54DE4", VA = "0x1A54DE4")]
		private static extern RESULT FMOD_Studio_EventDescription_HasCue(IntPtr eventdescription, out bool cue);

		[PreserveSig]
		[Token(Token = "0x60006C0")]
		[Address(RVA = "0x1A54EAC", Offset = "0x1A54EAC", VA = "0x1A54EAC")]
		private static extern RESULT FMOD_Studio_EventDescription_CreateInstance(IntPtr eventdescription, out IntPtr instance);

		[PreserveSig]
		[Token(Token = "0x60006C1")]
		[Address(RVA = "0x1A54F60", Offset = "0x1A54F60", VA = "0x1A54F60")]
		private static extern RESULT FMOD_Studio_EventDescription_GetInstanceCount(IntPtr eventdescription, out int count);

		[PreserveSig]
		[Token(Token = "0x60006C2")]
		[Address(RVA = "0x1A551AC", Offset = "0x1A551AC", VA = "0x1A551AC")]
		private static extern RESULT FMOD_Studio_EventDescription_GetInstanceList(IntPtr eventdescription, IntPtr[] array, int capacity, out int count);

		[PreserveSig]
		[Token(Token = "0x60006C3")]
		[Address(RVA = "0x1A55280", Offset = "0x1A55280", VA = "0x1A55280")]
		private static extern RESULT FMOD_Studio_EventDescription_LoadSampleData(IntPtr eventdescription);

		[PreserveSig]
		[Token(Token = "0x60006C4")]
		[Address(RVA = "0x1A55324", Offset = "0x1A55324", VA = "0x1A55324")]
		private static extern RESULT FMOD_Studio_EventDescription_UnloadSampleData(IntPtr eventdescription);

		[PreserveSig]
		[Token(Token = "0x60006C5")]
		[Address(RVA = "0x1A553C8", Offset = "0x1A553C8", VA = "0x1A553C8")]
		private static extern RESULT FMOD_Studio_EventDescription_GetSampleLoadingState(IntPtr eventdescription, out LOADING_STATE state);

		[PreserveSig]
		[Token(Token = "0x60006C6")]
		[Address(RVA = "0x1A5547C", Offset = "0x1A5547C", VA = "0x1A5547C")]
		private static extern RESULT FMOD_Studio_EventDescription_ReleaseAllInstances(IntPtr eventdescription);

		[PreserveSig]
		[Token(Token = "0x60006C7")]
		[Address(RVA = "0x1A55520", Offset = "0x1A55520", VA = "0x1A55520")]
		private static extern RESULT FMOD_Studio_EventDescription_SetCallback(IntPtr eventdescription, EVENT_CALLBACK callback, EVENT_CALLBACK_TYPE callbackmask);

		[PreserveSig]
		[Token(Token = "0x60006C8")]
		[Address(RVA = "0x1A555E4", Offset = "0x1A555E4", VA = "0x1A555E4")]
		private static extern RESULT FMOD_Studio_EventDescription_GetUserData(IntPtr eventdescription, out IntPtr userdata);

		[PreserveSig]
		[Token(Token = "0x60006C9")]
		[Address(RVA = "0x1A55698", Offset = "0x1A55698", VA = "0x1A55698")]
		private static extern RESULT FMOD_Studio_EventDescription_SetUserData(IntPtr eventdescription, IntPtr userdata);

		[Token(Token = "0x60006CA")]
		[Address(RVA = "0x9C8254", Offset = "0x9C8254", VA = "0x9C8254")]
		public bool hasHandle()
		{
			return default(bool);
		}

		[Token(Token = "0x60006CB")]
		[Address(RVA = "0x9C825C", Offset = "0x9C825C", VA = "0x9C825C")]
		public void clearHandle()
		{
		}

		[Token(Token = "0x60006CC")]
		[Address(RVA = "0x9C82A0", Offset = "0x9C82A0", VA = "0x9C82A0")]
		public bool isValid()
		{
			return default(bool);
		}
	}
	[Token(Token = "0x200010B")]
	public struct EventInstance
	{
		[Token(Token = "0x40005E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public IntPtr handle;

		[Token(Token = "0x60006CD")]
		[Address(RVA = "0x9C82A8", Offset = "0x9C82A8", VA = "0x9C82A8")]
		public RESULT getDescription(out EventDescription description)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60006CE")]
		[Address(RVA = "0x9C82B0", Offset = "0x9C82B0", VA = "0x9C82B0")]
		public RESULT getVolume(out float volume)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60006CF")]
		[Address(RVA = "0x9C82D8", Offset = "0x9C82D8", VA = "0x9C82D8")]
		public RESULT getVolume(out float volume, out float finalvolume)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60006D0")]
		[Address(RVA = "0x9C82E0", Offset = "0x9C82E0", VA = "0x9C82E0")]
		public RESULT setVolume(float volume)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60006D1")]
		[Address(RVA = "0x9C82E8", Offset = "0x9C82E8", VA = "0x9C82E8")]
		public RESULT getPitch(out float pitch)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60006D2")]
		[Address(RVA = "0x9C8310", Offset = "0x9C8310", VA = "0x9C8310")]
		public RESULT getPitch(out float pitch, out float finalpitch)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60006D3")]
		[Address(RVA = "0x9C8318", Offset = "0x9C8318", VA = "0x9C8318")]
		public RESULT setPitch(float pitch)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60006D4")]
		[Address(RVA = "0x9C8320", Offset = "0x9C8320", VA = "0x9C8320")]
		public RESULT get3DAttributes(out ATTRIBUTES_3D attributes)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60006D5")]
		[Address(RVA = "0x9C8328", Offset = "0x9C8328", VA = "0x9C8328")]
		public RESULT set3DAttributes(ATTRIBUTES_3D attributes)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60006D6")]
		[Address(RVA = "0x9C8364", Offset = "0x9C8364", VA = "0x9C8364")]
		public RESULT getListenerMask(out uint mask)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60006D7")]
		[Address(RVA = "0x9C836C", Offset = "0x9C836C", VA = "0x9C836C")]
		public RESULT setListenerMask(uint mask)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60006D8")]
		[Address(RVA = "0x9C8374", Offset = "0x9C8374", VA = "0x9C8374")]
		public RESULT getProperty(EVENT_PROPERTY index, out float value)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60006D9")]
		[Address(RVA = "0x9C837C", Offset = "0x9C837C", VA = "0x9C837C")]
		public RESULT setProperty(EVENT_PROPERTY index, float value)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60006DA")]
		[Address(RVA = "0x9C8384", Offset = "0x9C8384", VA = "0x9C8384")]
		public RESULT getReverbLevel(int index, out float level)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60006DB")]
		[Address(RVA = "0x9C838C", Offset = "0x9C838C", VA = "0x9C838C")]
		public RESULT setReverbLevel(int index, float level)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60006DC")]
		[Address(RVA = "0x9C8394", Offset = "0x9C8394", VA = "0x9C8394")]
		public RESULT getPaused(out bool paused)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60006DD")]
		[Address(RVA = "0x9C839C", Offset = "0x9C839C", VA = "0x9C839C")]
		public RESULT setPaused(bool paused)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60006DE")]
		[Address(RVA = "0x9C83A8", Offset = "0x9C83A8", VA = "0x9C83A8")]
		public RESULT start()
		{
			return default(RESULT);
		}

		[Token(Token = "0x60006DF")]
		[Address(RVA = "0x9C83B0", Offset = "0x9C83B0", VA = "0x9C83B0")]
		public RESULT stop(STOP_MODE mode)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60006E0")]
		[Address(RVA = "0x9C83B8", Offset = "0x9C83B8", VA = "0x9C83B8")]
		public RESULT getTimelinePosition(out int position)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60006E1")]
		[Address(RVA = "0x9C83C0", Offset = "0x9C83C0", VA = "0x9C83C0")]
		public RESULT setTimelinePosition(int position)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60006E2")]
		[Address(RVA = "0x9C83C8", Offset = "0x9C83C8", VA = "0x9C83C8")]
		public RESULT getPlaybackState(out PLAYBACK_STATE state)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60006E3")]
		[Address(RVA = "0x9C83D0", Offset = "0x9C83D0", VA = "0x9C83D0")]
		public RESULT getChannelGroup(out ChannelGroup group)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60006E4")]
		[Address(RVA = "0x9C83D8", Offset = "0x9C83D8", VA = "0x9C83D8")]
		public RESULT release()
		{
			return default(RESULT);
		}

		[Token(Token = "0x60006E5")]
		[Address(RVA = "0x9C83E0", Offset = "0x9C83E0", VA = "0x9C83E0")]
		public RESULT isVirtual(out bool virtualstate)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60006E6")]
		[Address(RVA = "0x9C83E8", Offset = "0x9C83E8", VA = "0x9C83E8")]
		public RESULT getParameterByID(PARAMETER_ID id, out float value)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60006E7")]
		[Address(RVA = "0x9C8410", Offset = "0x9C8410", VA = "0x9C8410")]
		public RESULT getParameterByID(PARAMETER_ID id, out float value, out float finalvalue)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60006E8")]
		[Address(RVA = "0x9C8418", Offset = "0x9C8418", VA = "0x9C8418")]
		public RESULT setParameterByID(PARAMETER_ID id, float value, bool ignoreseekspeed = false)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60006E9")]
		[Address(RVA = "0x9C8424", Offset = "0x9C8424", VA = "0x9C8424")]
		public RESULT setParametersByIDs(PARAMETER_ID[] ids, float[] values, int count, bool ignoreseekspeed = false)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60006EA")]
		[Address(RVA = "0x9C8430", Offset = "0x9C8430", VA = "0x9C8430")]
		public RESULT getParameterByName(string name, out float value)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60006EB")]
		[Address(RVA = "0x9C8458", Offset = "0x9C8458", VA = "0x9C8458")]
		public RESULT getParameterByName(string name, out float value, out float finalvalue)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60006EC")]
		[Address(RVA = "0x9C8460", Offset = "0x9C8460", VA = "0x9C8460")]
		public RESULT setParameterByName(string name, float value, bool ignoreseekspeed = false)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60006ED")]
		[Address(RVA = "0x9C846C", Offset = "0x9C846C", VA = "0x9C846C")]
		public RESULT triggerCue()
		{
			return default(RESULT);
		}

		[Token(Token = "0x60006EE")]
		[Address(RVA = "0x9C8474", Offset = "0x9C8474", VA = "0x9C8474")]
		public RESULT setCallback(EVENT_CALLBACK callback, EVENT_CALLBACK_TYPE callbackmask = EVENT_CALLBACK_TYPE.ALL)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60006EF")]
		[Address(RVA = "0x9C847C", Offset = "0x9C847C", VA = "0x9C847C")]
		public RESULT getUserData(out IntPtr userdata)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60006F0")]
		[Address(RVA = "0x9C8484", Offset = "0x9C8484", VA = "0x9C8484")]
		public RESULT setUserData(IntPtr userdata)
		{
			return default(RESULT);
		}

		[PreserveSig]
		[Token(Token = "0x60006F1")]
		[Address(RVA = "0x1A57398", Offset = "0x1A57398", VA = "0x1A57398")]
		private static extern bool FMOD_Studio_EventInstance_IsValid(IntPtr _event);

		[PreserveSig]
		[Token(Token = "0x60006F2")]
		[Address(RVA = "0x1A558B8", Offset = "0x1A558B8", VA = "0x1A558B8")]
		private static extern RESULT FMOD_Studio_EventInstance_GetDescription(IntPtr _event, out IntPtr description);

		[PreserveSig]
		[Token(Token = "0x60006F3")]
		[Address(RVA = "0x1A55994", Offset = "0x1A55994", VA = "0x1A55994")]
		private static extern RESULT FMOD_Studio_EventInstance_GetVolume(IntPtr _event, out float volume, out float finalvolume);

		[PreserveSig]
		[Token(Token = "0x60006F4")]
		[Address(RVA = "0x1A55A50", Offset = "0x1A55A50", VA = "0x1A55A50")]
		private static extern RESULT FMOD_Studio_EventInstance_SetVolume(IntPtr _event, float volume);

		[PreserveSig]
		[Token(Token = "0x60006F5")]
		[Address(RVA = "0x1A55B2C", Offset = "0x1A55B2C", VA = "0x1A55B2C")]
		private static extern RESULT FMOD_Studio_EventInstance_GetPitch(IntPtr _event, out float pitch, out float finalpitch);

		[PreserveSig]
		[Token(Token = "0x60006F6")]
		[Address(RVA = "0x1A55BE8", Offset = "0x1A55BE8", VA = "0x1A55BE8")]
		private static extern RESULT FMOD_Studio_EventInstance_SetPitch(IntPtr _event, float pitch);

		[PreserveSig]
		[Token(Token = "0x60006F7")]
		[Address(RVA = "0x1A55C9C", Offset = "0x1A55C9C", VA = "0x1A55C9C")]
		private static extern RESULT FMOD_Studio_EventInstance_Get3DAttributes(IntPtr _event, out ATTRIBUTES_3D attributes);

		[PreserveSig]
		[Token(Token = "0x60006F8")]
		[Address(RVA = "0x1A55D50", Offset = "0x1A55D50", VA = "0x1A55D50")]
		private static extern RESULT FMOD_Studio_EventInstance_Set3DAttributes(IntPtr _event, ref ATTRIBUTES_3D attributes);

		[PreserveSig]
		[Token(Token = "0x60006F9")]
		[Address(RVA = "0x1A55E04", Offset = "0x1A55E04", VA = "0x1A55E04")]
		private static extern RESULT FMOD_Studio_EventInstance_GetListenerMask(IntPtr _event, out uint mask);

		[PreserveSig]
		[Token(Token = "0x60006FA")]
		[Address(RVA = "0x1A55EB8", Offset = "0x1A55EB8", VA = "0x1A55EB8")]
		private static extern RESULT FMOD_Studio_EventInstance_SetListenerMask(IntPtr _event, uint mask);

		[PreserveSig]
		[Token(Token = "0x60006FB")]
		[Address(RVA = "0x1A55F6C", Offset = "0x1A55F6C", VA = "0x1A55F6C")]
		private static extern RESULT FMOD_Studio_EventInstance_GetProperty(IntPtr _event, EVENT_PROPERTY index, out float value);

		[PreserveSig]
		[Token(Token = "0x60006FC")]
		[Address(RVA = "0x1A56028", Offset = "0x1A56028", VA = "0x1A56028")]
		private static extern RESULT FMOD_Studio_EventInstance_SetProperty(IntPtr _event, EVENT_PROPERTY index, float value);

		[PreserveSig]
		[Token(Token = "0x60006FD")]
		[Address(RVA = "0x1A560EC", Offset = "0x1A560EC", VA = "0x1A560EC")]
		private static extern RESULT FMOD_Studio_EventInstance_GetReverbLevel(IntPtr _event, int index, out float level);

		[PreserveSig]
		[Token(Token = "0x60006FE")]
		[Address(RVA = "0x1A561A8", Offset = "0x1A561A8", VA = "0x1A561A8")]
		private static extern RESULT FMOD_Studio_EventInstance_SetReverbLevel(IntPtr _event, int index, float level);

		[PreserveSig]
		[Token(Token = "0x60006FF")]
		[Address(RVA = "0x1A5626C", Offset = "0x1A5626C", VA = "0x1A5626C")]
		private static extern RESULT FMOD_Studio_EventInstance_GetPaused(IntPtr _event, out bool paused);

		[PreserveSig]
		[Token(Token = "0x6000700")]
		[Address(RVA = "0x1A56338", Offset = "0x1A56338", VA = "0x1A56338")]
		private static extern RESULT FMOD_Studio_EventInstance_SetPaused(IntPtr _event, bool paused);

		[PreserveSig]
		[Token(Token = "0x6000701")]
		[Address(RVA = "0x1A563EC", Offset = "0x1A563EC", VA = "0x1A563EC")]
		private static extern RESULT FMOD_Studio_EventInstance_Start(IntPtr _event);

		[PreserveSig]
		[Token(Token = "0x6000702")]
		[Address(RVA = "0x1A56490", Offset = "0x1A56490", VA = "0x1A56490")]
		private static extern RESULT FMOD_Studio_EventInstance_Stop(IntPtr _event, STOP_MODE mode);

		[PreserveSig]
		[Token(Token = "0x6000703")]
		[Address(RVA = "0x1A56544", Offset = "0x1A56544", VA = "0x1A56544")]
		private static extern RESULT FMOD_Studio_EventInstance_GetTimelinePosition(IntPtr _event, out int position);

		[PreserveSig]
		[Token(Token = "0x6000704")]
		[Address(RVA = "0x1A565F8", Offset = "0x1A565F8", VA = "0x1A565F8")]
		private static extern RESULT FMOD_Studio_EventInstance_SetTimelinePosition(IntPtr _event, int position);

		[PreserveSig]
		[Token(Token = "0x6000705")]
		[Address(RVA = "0x1A566AC", Offset = "0x1A566AC", VA = "0x1A566AC")]
		private static extern RESULT FMOD_Studio_EventInstance_GetPlaybackState(IntPtr _event, out PLAYBACK_STATE state);

		[PreserveSig]
		[Token(Token = "0x6000706")]
		[Address(RVA = "0x1A56760", Offset = "0x1A56760", VA = "0x1A56760")]
		private static extern RESULT FMOD_Studio_EventInstance_GetChannelGroup(IntPtr _event, out IntPtr group);

		[PreserveSig]
		[Token(Token = "0x6000707")]
		[Address(RVA = "0x1A56814", Offset = "0x1A56814", VA = "0x1A56814")]
		private static extern RESULT FMOD_Studio_EventInstance_Release(IntPtr _event);

		[PreserveSig]
		[Token(Token = "0x6000708")]
		[Address(RVA = "0x1A568B8", Offset = "0x1A568B8", VA = "0x1A568B8")]
		private static extern RESULT FMOD_Studio_EventInstance_IsVirtual(IntPtr _event, out bool virtualstate);

		[PreserveSig]
		[Token(Token = "0x6000709")]
		[Address(RVA = "0x1A56DBC", Offset = "0x1A56DBC", VA = "0x1A56DBC")]
		private static extern RESULT FMOD_Studio_EventInstance_GetParameterByName(IntPtr _event, byte[] name, out float value, out float finalvalue);

		[PreserveSig]
		[Token(Token = "0x600070A")]
		[Address(RVA = "0x1A56FFC", Offset = "0x1A56FFC", VA = "0x1A56FFC")]
		private static extern RESULT FMOD_Studio_EventInstance_SetParameterByName(IntPtr _event, byte[] name, float value, bool ignoreseekspeed);

		[PreserveSig]
		[Token(Token = "0x600070B")]
		[Address(RVA = "0x1A569A8", Offset = "0x1A569A8", VA = "0x1A569A8")]
		private static extern RESULT FMOD_Studio_EventInstance_GetParameterByID(IntPtr _event, PARAMETER_ID id, out float value, out float finalvalue);

		[PreserveSig]
		[Token(Token = "0x600070C")]
		[Address(RVA = "0x1A56A78", Offset = "0x1A56A78", VA = "0x1A56A78")]
		private static extern RESULT FMOD_Studio_EventInstance_SetParameterByID(IntPtr _event, PARAMETER_ID id, float value, bool ignoreseekspeed);

		[PreserveSig]
		[Token(Token = "0x600070D")]
		[Address(RVA = "0x1A56B48", Offset = "0x1A56B48", VA = "0x1A56B48")]
		private static extern RESULT FMOD_Studio_EventInstance_SetParametersByIDs(IntPtr _event, PARAMETER_ID[] ids, float[] values, int count, bool ignoreseekspeed);

		[PreserveSig]
		[Token(Token = "0x600070E")]
		[Address(RVA = "0x1A570D0", Offset = "0x1A570D0", VA = "0x1A570D0")]
		private static extern RESULT FMOD_Studio_EventInstance_TriggerCue(IntPtr _event);

		[PreserveSig]
		[Token(Token = "0x600070F")]
		[Address(RVA = "0x1A57174", Offset = "0x1A57174", VA = "0x1A57174")]
		private static extern RESULT FMOD_Studio_EventInstance_SetCallback(IntPtr _event, EVENT_CALLBACK callback, EVENT_CALLBACK_TYPE callbackmask);

		[PreserveSig]
		[Token(Token = "0x6000710")]
		[Address(RVA = "0x1A57238", Offset = "0x1A57238", VA = "0x1A57238")]
		private static extern RESULT FMOD_Studio_EventInstance_GetUserData(IntPtr _event, out IntPtr userdata);

		[PreserveSig]
		[Token(Token = "0x6000711")]
		[Address(RVA = "0x1A572EC", Offset = "0x1A572EC", VA = "0x1A572EC")]
		private static extern RESULT FMOD_Studio_EventInstance_SetUserData(IntPtr _event, IntPtr userdata);

		[Token(Token = "0x6000712")]
		[Address(RVA = "0x9C848C", Offset = "0x9C848C", VA = "0x9C848C")]
		public bool hasHandle()
		{
			return default(bool);
		}

		[Token(Token = "0x6000713")]
		[Address(RVA = "0x9C8494", Offset = "0x9C8494", VA = "0x9C8494")]
		public void clearHandle()
		{
		}

		[Token(Token = "0x6000714")]
		[Address(RVA = "0x9C84D8", Offset = "0x9C84D8", VA = "0x9C84D8")]
		public bool isValid()
		{
			return default(bool);
		}
	}
	[Token(Token = "0x200010C")]
	public struct Bus
	{
		[Token(Token = "0x40005E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public IntPtr handle;

		[Token(Token = "0x6000715")]
		[Address(RVA = "0x9C7EF0", Offset = "0x9C7EF0", VA = "0x9C7EF0")]
		public RESULT getID(out Guid id)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000716")]
		[Address(RVA = "0x9C7EF8", Offset = "0x9C7EF8", VA = "0x9C7EF8")]
		public RESULT getPath(out string path)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000717")]
		[Address(RVA = "0x9C7F00", Offset = "0x9C7F00", VA = "0x9C7F00")]
		public RESULT getVolume(out float volume)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000718")]
		[Address(RVA = "0x9C7F28", Offset = "0x9C7F28", VA = "0x9C7F28")]
		public RESULT getVolume(out float volume, out float finalvolume)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000719")]
		[Address(RVA = "0x9C7F30", Offset = "0x9C7F30", VA = "0x9C7F30")]
		public RESULT setVolume(float volume)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600071A")]
		[Address(RVA = "0x9C7F38", Offset = "0x9C7F38", VA = "0x9C7F38")]
		public RESULT getPaused(out bool paused)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600071B")]
		[Address(RVA = "0x9C7F40", Offset = "0x9C7F40", VA = "0x9C7F40")]
		public RESULT setPaused(bool paused)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600071C")]
		[Address(RVA = "0x9C7F4C", Offset = "0x9C7F4C", VA = "0x9C7F4C")]
		public RESULT getMute(out bool mute)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600071D")]
		[Address(RVA = "0x9C7F54", Offset = "0x9C7F54", VA = "0x9C7F54")]
		public RESULT setMute(bool mute)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600071E")]
		[Address(RVA = "0x9C7F60", Offset = "0x9C7F60", VA = "0x9C7F60")]
		public RESULT stopAllEvents(STOP_MODE mode)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600071F")]
		[Address(RVA = "0x9C7F68", Offset = "0x9C7F68", VA = "0x9C7F68")]
		public RESULT lockChannelGroup()
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000720")]
		[Address(RVA = "0x9C7F70", Offset = "0x9C7F70", VA = "0x9C7F70")]
		public RESULT unlockChannelGroup()
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000721")]
		[Address(RVA = "0x9C7F78", Offset = "0x9C7F78", VA = "0x9C7F78")]
		public RESULT getChannelGroup(out ChannelGroup group)
		{
			return default(RESULT);
		}

		[PreserveSig]
		[Token(Token = "0x6000722")]
		[Address(RVA = "0x1A50D94", Offset = "0x1A50D94", VA = "0x1A50D94")]
		private static extern bool FMOD_Studio_Bus_IsValid(IntPtr bus);

		[PreserveSig]
		[Token(Token = "0x6000723")]
		[Address(RVA = "0x1A50294", Offset = "0x1A50294", VA = "0x1A50294")]
		private static extern RESULT FMOD_Studio_Bus_GetID(IntPtr bus, out Guid id);

		[PreserveSig]
		[Token(Token = "0x6000724")]
		[Address(RVA = "0x1A50588", Offset = "0x1A50588", VA = "0x1A50588")]
		private static extern RESULT FMOD_Studio_Bus_GetPath(IntPtr bus, IntPtr path, int size, out int retrieved);

		[PreserveSig]
		[Token(Token = "0x6000725")]
		[Address(RVA = "0x1A5067C", Offset = "0x1A5067C", VA = "0x1A5067C")]
		private static extern RESULT FMOD_Studio_Bus_GetVolume(IntPtr bus, out float volume, out float finalvolume);

		[PreserveSig]
		[Token(Token = "0x6000726")]
		[Address(RVA = "0x1A50738", Offset = "0x1A50738", VA = "0x1A50738")]
		private static extern RESULT FMOD_Studio_Bus_SetVolume(IntPtr bus, float volume);

		[PreserveSig]
		[Token(Token = "0x6000727")]
		[Address(RVA = "0x1A507EC", Offset = "0x1A507EC", VA = "0x1A507EC")]
		private static extern RESULT FMOD_Studio_Bus_GetPaused(IntPtr bus, out bool paused);

		[PreserveSig]
		[Token(Token = "0x6000728")]
		[Address(RVA = "0x1A508B8", Offset = "0x1A508B8", VA = "0x1A508B8")]
		private static extern RESULT FMOD_Studio_Bus_SetPaused(IntPtr bus, bool paused);

		[PreserveSig]
		[Token(Token = "0x6000729")]
		[Address(RVA = "0x1A5096C", Offset = "0x1A5096C", VA = "0x1A5096C")]
		private static extern RESULT FMOD_Studio_Bus_GetMute(IntPtr bus, out bool mute);

		[PreserveSig]
		[Token(Token = "0x600072A")]
		[Address(RVA = "0x1A50A38", Offset = "0x1A50A38", VA = "0x1A50A38")]
		private static extern RESULT FMOD_Studio_Bus_SetMute(IntPtr bus, bool mute);

		[PreserveSig]
		[Token(Token = "0x600072B")]
		[Address(RVA = "0x1A50AEC", Offset = "0x1A50AEC", VA = "0x1A50AEC")]
		private static extern RESULT FMOD_Studio_Bus_StopAllEvents(IntPtr bus, STOP_MODE mode);

		[PreserveSig]
		[Token(Token = "0x600072C")]
		[Address(RVA = "0x1A50BA0", Offset = "0x1A50BA0", VA = "0x1A50BA0")]
		private static extern RESULT FMOD_Studio_Bus_LockChannelGroup(IntPtr bus);

		[PreserveSig]
		[Token(Token = "0x600072D")]
		[Address(RVA = "0x1A50C44", Offset = "0x1A50C44", VA = "0x1A50C44")]
		private static extern RESULT FMOD_Studio_Bus_UnlockChannelGroup(IntPtr bus);

		[PreserveSig]
		[Token(Token = "0x600072E")]
		[Address(RVA = "0x1A50CE8", Offset = "0x1A50CE8", VA = "0x1A50CE8")]
		private static extern RESULT FMOD_Studio_Bus_GetChannelGroup(IntPtr bus, out IntPtr group);

		[Token(Token = "0x600072F")]
		[Address(RVA = "0x9C7F80", Offset = "0x9C7F80", VA = "0x9C7F80")]
		public bool hasHandle()
		{
			return default(bool);
		}

		[Token(Token = "0x6000730")]
		[Address(RVA = "0x9C7F88", Offset = "0x9C7F88", VA = "0x9C7F88")]
		public void clearHandle()
		{
		}

		[Token(Token = "0x6000731")]
		[Address(RVA = "0x9C7FCC", Offset = "0x9C7FCC", VA = "0x9C7FCC")]
		public bool isValid()
		{
			return default(bool);
		}
	}
	[Token(Token = "0x200010D")]
	public struct VCA
	{
		[Token(Token = "0x40005E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public IntPtr handle;

		[Token(Token = "0x6000732")]
		[Address(RVA = "0x9C8A4C", Offset = "0x9C8A4C", VA = "0x9C8A4C")]
		public RESULT getID(out Guid id)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000733")]
		[Address(RVA = "0x9C8A54", Offset = "0x9C8A54", VA = "0x9C8A54")]
		public RESULT getPath(out string path)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000734")]
		[Address(RVA = "0x9C8A5C", Offset = "0x9C8A5C", VA = "0x9C8A5C")]
		public RESULT getVolume(out float volume)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000735")]
		[Address(RVA = "0x9C8A84", Offset = "0x9C8A84", VA = "0x9C8A84")]
		public RESULT getVolume(out float volume, out float finalvolume)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000736")]
		[Address(RVA = "0x9C8A8C", Offset = "0x9C8A8C", VA = "0x9C8A8C")]
		public RESULT setVolume(float volume)
		{
			return default(RESULT);
		}

		[PreserveSig]
		[Token(Token = "0x6000737")]
		[Address(RVA = "0x1A5C7BC", Offset = "0x1A5C7BC", VA = "0x1A5C7BC")]
		private static extern bool FMOD_Studio_VCA_IsValid(IntPtr vca);

		[PreserveSig]
		[Token(Token = "0x6000738")]
		[Address(RVA = "0x1A5C26C", Offset = "0x1A5C26C", VA = "0x1A5C26C")]
		private static extern RESULT FMOD_Studio_VCA_GetID(IntPtr vca, out Guid id);

		[PreserveSig]
		[Token(Token = "0x6000739")]
		[Address(RVA = "0x1A5C560", Offset = "0x1A5C560", VA = "0x1A5C560")]
		private static extern RESULT FMOD_Studio_VCA_GetPath(IntPtr vca, IntPtr path, int size, out int retrieved);

		[PreserveSig]
		[Token(Token = "0x600073A")]
		[Address(RVA = "0x1A5C654", Offset = "0x1A5C654", VA = "0x1A5C654")]
		private static extern RESULT FMOD_Studio_VCA_GetVolume(IntPtr vca, out float volume, out float finalvolume);

		[PreserveSig]
		[Token(Token = "0x600073B")]
		[Address(RVA = "0x1A5C710", Offset = "0x1A5C710", VA = "0x1A5C710")]
		private static extern RESULT FMOD_Studio_VCA_SetVolume(IntPtr vca, float volume);

		[Token(Token = "0x600073C")]
		[Address(RVA = "0x9C8A94", Offset = "0x9C8A94", VA = "0x9C8A94")]
		public bool hasHandle()
		{
			return default(bool);
		}

		[Token(Token = "0x600073D")]
		[Address(RVA = "0x9C8A9C", Offset = "0x9C8A9C", VA = "0x9C8A9C")]
		public void clearHandle()
		{
		}

		[Token(Token = "0x600073E")]
		[Address(RVA = "0x9C8AE0", Offset = "0x9C8AE0", VA = "0x9C8AE0")]
		public bool isValid()
		{
			return default(bool);
		}
	}
	[Token(Token = "0x200010E")]
	public struct Bank
	{
		[Token(Token = "0x40005E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public IntPtr handle;

		[Token(Token = "0x600073F")]
		[Address(RVA = "0x9C7E14", Offset = "0x9C7E14", VA = "0x9C7E14")]
		public RESULT getID(out Guid id)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000740")]
		[Address(RVA = "0x9C7E1C", Offset = "0x9C7E1C", VA = "0x9C7E1C")]
		public RESULT getPath(out string path)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000741")]
		[Address(RVA = "0x9C7E24", Offset = "0x9C7E24", VA = "0x9C7E24")]
		public RESULT unload()
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000742")]
		[Address(RVA = "0x9C7E2C", Offset = "0x9C7E2C", VA = "0x9C7E2C")]
		public RESULT loadSampleData()
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000743")]
		[Address(RVA = "0x9C7E34", Offset = "0x9C7E34", VA = "0x9C7E34")]
		public RESULT unloadSampleData()
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000744")]
		[Address(RVA = "0x9C7E3C", Offset = "0x9C7E3C", VA = "0x9C7E3C")]
		public RESULT getLoadingState(out LOADING_STATE state)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000745")]
		[Address(RVA = "0x9C7E44", Offset = "0x9C7E44", VA = "0x9C7E44")]
		public RESULT getSampleLoadingState(out LOADING_STATE state)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000746")]
		[Address(RVA = "0x9C7E4C", Offset = "0x9C7E4C", VA = "0x9C7E4C")]
		public RESULT getStringCount(out int count)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000747")]
		[Address(RVA = "0x9C7E54", Offset = "0x9C7E54", VA = "0x9C7E54")]
		public RESULT getStringInfo(int index, out Guid id, out string path)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000748")]
		[Address(RVA = "0x9C7E5C", Offset = "0x9C7E5C", VA = "0x9C7E5C")]
		public RESULT getEventCount(out int count)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000749")]
		[Address(RVA = "0x9C7E64", Offset = "0x9C7E64", VA = "0x9C7E64")]
		public RESULT getEventList(out EventDescription[] array)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600074A")]
		[Address(RVA = "0x9C7E6C", Offset = "0x9C7E6C", VA = "0x9C7E6C")]
		public RESULT getBusCount(out int count)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600074B")]
		[Address(RVA = "0x9C7E74", Offset = "0x9C7E74", VA = "0x9C7E74")]
		public RESULT getBusList(out Bus[] array)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600074C")]
		[Address(RVA = "0x9C7E7C", Offset = "0x9C7E7C", VA = "0x9C7E7C")]
		public RESULT getVCACount(out int count)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600074D")]
		[Address(RVA = "0x9C7E84", Offset = "0x9C7E84", VA = "0x9C7E84")]
		public RESULT getVCAList(out VCA[] array)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600074E")]
		[Address(RVA = "0x9C7E8C", Offset = "0x9C7E8C", VA = "0x9C7E8C")]
		public RESULT getUserData(out IntPtr userdata)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600074F")]
		[Address(RVA = "0x9C7E94", Offset = "0x9C7E94", VA = "0x9C7E94")]
		public RESULT setUserData(IntPtr userdata)
		{
			return default(RESULT);
		}

		[PreserveSig]
		[Token(Token = "0x6000750")]
		[Address(RVA = "0x1A50120", Offset = "0x1A50120", VA = "0x1A50120")]
		private static extern bool FMOD_Studio_Bank_IsValid(IntPtr bank);

		[PreserveSig]
		[Token(Token = "0x6000751")]
		[Address(RVA = "0x1A4EB24", Offset = "0x1A4EB24", VA = "0x1A4EB24")]
		private static extern RESULT FMOD_Studio_Bank_GetID(IntPtr bank, out Guid id);

		[PreserveSig]
		[Token(Token = "0x6000752")]
		[Address(RVA = "0x1A4EE18", Offset = "0x1A4EE18", VA = "0x1A4EE18")]
		private static extern RESULT FMOD_Studio_Bank_GetPath(IntPtr bank, IntPtr path, int size, out int retrieved);

		[PreserveSig]
		[Token(Token = "0x6000753")]
		[Address(RVA = "0x1A4EEE4", Offset = "0x1A4EEE4", VA = "0x1A4EEE4")]
		private static extern RESULT FMOD_Studio_Bank_Unload(IntPtr bank);

		[PreserveSig]
		[Token(Token = "0x6000754")]
		[Address(RVA = "0x1A4EF88", Offset = "0x1A4EF88", VA = "0x1A4EF88")]
		private static extern RESULT FMOD_Studio_Bank_LoadSampleData(IntPtr bank);

		[PreserveSig]
		[Token(Token = "0x6000755")]
		[Address(RVA = "0x1A4F02C", Offset = "0x1A4F02C", VA = "0x1A4F02C")]
		private static extern RESULT FMOD_Studio_Bank_UnloadSampleData(IntPtr bank);

		[PreserveSig]
		[Token(Token = "0x6000756")]
		[Address(RVA = "0x1A4F0D0", Offset = "0x1A4F0D0", VA = "0x1A4F0D0")]
		private static extern RESULT FMOD_Studio_Bank_GetLoadingState(IntPtr bank, out LOADING_STATE state);

		[PreserveSig]
		[Token(Token = "0x6000757")]
		[Address(RVA = "0x1A4F184", Offset = "0x1A4F184", VA = "0x1A4F184")]
		private static extern RESULT FMOD_Studio_Bank_GetSampleLoadingState(IntPtr bank, out LOADING_STATE state);

		[PreserveSig]
		[Token(Token = "0x6000758")]
		[Address(RVA = "0x1A4F238", Offset = "0x1A4F238", VA = "0x1A4F238")]
		private static extern RESULT FMOD_Studio_Bank_GetStringCount(IntPtr bank, out int count);

		[PreserveSig]
		[Token(Token = "0x6000759")]
		[Address(RVA = "0x1A4F57C", Offset = "0x1A4F57C", VA = "0x1A4F57C")]
		private static extern RESULT FMOD_Studio_Bank_GetStringInfo(IntPtr bank, int index, out Guid id, IntPtr path, int size, out int retrieved);

		[PreserveSig]
		[Token(Token = "0x600075A")]
		[Address(RVA = "0x1A4F660", Offset = "0x1A4F660", VA = "0x1A4F660")]
		private static extern RESULT FMOD_Studio_Bank_GetEventCount(IntPtr bank, out int count);

		[PreserveSig]
		[Token(Token = "0x600075B")]
		[Address(RVA = "0x1A4F8AC", Offset = "0x1A4F8AC", VA = "0x1A4F8AC")]
		private static extern RESULT FMOD_Studio_Bank_GetEventList(IntPtr bank, IntPtr[] array, int capacity, out int count);

		[PreserveSig]
		[Token(Token = "0x600075C")]
		[Address(RVA = "0x1A4F980", Offset = "0x1A4F980", VA = "0x1A4F980")]
		private static extern RESULT FMOD_Studio_Bank_GetBusCount(IntPtr bank, out int count);

		[PreserveSig]
		[Token(Token = "0x600075D")]
		[Address(RVA = "0x1A4FBCC", Offset = "0x1A4FBCC", VA = "0x1A4FBCC")]
		private static extern RESULT FMOD_Studio_Bank_GetBusList(IntPtr bank, IntPtr[] array, int capacity, out int count);

		[PreserveSig]
		[Token(Token = "0x600075E")]
		[Address(RVA = "0x1A4FCA0", Offset = "0x1A4FCA0", VA = "0x1A4FCA0")]
		private static extern RESULT FMOD_Studio_Bank_GetVCACount(IntPtr bank, out int count);

		[PreserveSig]
		[Token(Token = "0x600075F")]
		[Address(RVA = "0x1A4FEEC", Offset = "0x1A4FEEC", VA = "0x1A4FEEC")]
		private static extern RESULT FMOD_Studio_Bank_GetVCAList(IntPtr bank, IntPtr[] array, int capacity, out int count);

		[PreserveSig]
		[Token(Token = "0x6000760")]
		[Address(RVA = "0x1A4FFC0", Offset = "0x1A4FFC0", VA = "0x1A4FFC0")]
		private static extern RESULT FMOD_Studio_Bank_GetUserData(IntPtr bank, out IntPtr userdata);

		[PreserveSig]
		[Token(Token = "0x6000761")]
		[Address(RVA = "0x1A50074", Offset = "0x1A50074", VA = "0x1A50074")]
		private static extern RESULT FMOD_Studio_Bank_SetUserData(IntPtr bank, IntPtr userdata);

		[Token(Token = "0x6000762")]
		[Address(RVA = "0x9C7E9C", Offset = "0x9C7E9C", VA = "0x9C7E9C")]
		public bool hasHandle()
		{
			return default(bool);
		}

		[Token(Token = "0x6000763")]
		[Address(RVA = "0x9C7EA4", Offset = "0x9C7EA4", VA = "0x9C7EA4")]
		public void clearHandle()
		{
		}

		[Token(Token = "0x6000764")]
		[Address(RVA = "0x9C7EE8", Offset = "0x9C7EE8", VA = "0x9C7EE8")]
		public bool isValid()
		{
			return default(bool);
		}
	}
	[Token(Token = "0x200010F")]
	public struct CommandReplay
	{
		[Token(Token = "0x40005EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public IntPtr handle;

		[Token(Token = "0x6000765")]
		[Address(RVA = "0x9C803C", Offset = "0x9C803C", VA = "0x9C803C")]
		public RESULT getSystem(out System system)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000766")]
		[Address(RVA = "0x9C8044", Offset = "0x9C8044", VA = "0x9C8044")]
		public RESULT getLength(out float length)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000767")]
		[Address(RVA = "0x9C804C", Offset = "0x9C804C", VA = "0x9C804C")]
		public RESULT getCommandCount(out int count)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000768")]
		[Address(RVA = "0x9C8054", Offset = "0x9C8054", VA = "0x9C8054")]
		public RESULT getCommandInfo(int commandIndex, out COMMAND_INFO info)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000769")]
		[Address(RVA = "0x9C805C", Offset = "0x9C805C", VA = "0x9C805C")]
		public RESULT getCommandString(int commandIndex, out string buffer)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600076A")]
		[Address(RVA = "0x9C8064", Offset = "0x9C8064", VA = "0x9C8064")]
		public RESULT getCommandAtTime(float time, out int commandIndex)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600076B")]
		[Address(RVA = "0x9C806C", Offset = "0x9C806C", VA = "0x9C806C")]
		public RESULT setBankPath(string bankPath)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600076C")]
		[Address(RVA = "0x9C8074", Offset = "0x9C8074", VA = "0x9C8074")]
		public RESULT start()
		{
			return default(RESULT);
		}

		[Token(Token = "0x600076D")]
		[Address(RVA = "0x9C807C", Offset = "0x9C807C", VA = "0x9C807C")]
		public RESULT stop()
		{
			return default(RESULT);
		}

		[Token(Token = "0x600076E")]
		[Address(RVA = "0x9C8084", Offset = "0x9C8084", VA = "0x9C8084")]
		public RESULT seekToTime(float time)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600076F")]
		[Address(RVA = "0x9C808C", Offset = "0x9C808C", VA = "0x9C808C")]
		public RESULT seekToCommand(int commandIndex)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000770")]
		[Address(RVA = "0x9C8094", Offset = "0x9C8094", VA = "0x9C8094")]
		public RESULT getPaused(out bool paused)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000771")]
		[Address(RVA = "0x9C809C", Offset = "0x9C809C", VA = "0x9C809C")]
		public RESULT setPaused(bool paused)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000772")]
		[Address(RVA = "0x9C80A8", Offset = "0x9C80A8", VA = "0x9C80A8")]
		public RESULT getPlaybackState(out PLAYBACK_STATE state)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000773")]
		[Address(RVA = "0x9C80B0", Offset = "0x9C80B0", VA = "0x9C80B0")]
		public RESULT getCurrentCommand(out int commandIndex, out float currentTime)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000774")]
		[Address(RVA = "0x9C80B8", Offset = "0x9C80B8", VA = "0x9C80B8")]
		public RESULT release()
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000775")]
		[Address(RVA = "0x9C80C0", Offset = "0x9C80C0", VA = "0x9C80C0")]
		public RESULT setFrameCallback(COMMANDREPLAY_FRAME_CALLBACK callback)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000776")]
		[Address(RVA = "0x9C80C8", Offset = "0x9C80C8", VA = "0x9C80C8")]
		public RESULT setLoadBankCallback(COMMANDREPLAY_LOAD_BANK_CALLBACK callback)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000777")]
		[Address(RVA = "0x9C80D0", Offset = "0x9C80D0", VA = "0x9C80D0")]
		public RESULT setCreateInstanceCallback(COMMANDREPLAY_CREATE_INSTANCE_CALLBACK callback)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000778")]
		[Address(RVA = "0x9C80D8", Offset = "0x9C80D8", VA = "0x9C80D8")]
		public RESULT getUserData(out IntPtr userdata)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000779")]
		[Address(RVA = "0x9C80E0", Offset = "0x9C80E0", VA = "0x9C80E0")]
		public RESULT setUserData(IntPtr userdata)
		{
			return default(RESULT);
		}

		[PreserveSig]
		[Token(Token = "0x600077A")]
		[Address(RVA = "0x1A534D4", Offset = "0x1A534D4", VA = "0x1A534D4")]
		private static extern bool FMOD_Studio_CommandReplay_IsValid(IntPtr replay);

		[PreserveSig]
		[Token(Token = "0x600077B")]
		[Address(RVA = "0x1A52238", Offset = "0x1A52238", VA = "0x1A52238")]
		private static extern RESULT FMOD_Studio_CommandReplay_GetSystem(IntPtr replay, out IntPtr system);

		[PreserveSig]
		[Token(Token = "0x600077C")]
		[Address(RVA = "0x1A522EC", Offset = "0x1A522EC", VA = "0x1A522EC")]
		private static extern RESULT FMOD_Studio_CommandReplay_GetLength(IntPtr replay, out float length);

		[PreserveSig]
		[Token(Token = "0x600077D")]
		[Address(RVA = "0x1A523A0", Offset = "0x1A523A0", VA = "0x1A523A0")]
		private static extern RESULT FMOD_Studio_CommandReplay_GetCommandCount(IntPtr replay, out int count);

		[PreserveSig]
		[Token(Token = "0x600077E")]
		[Address(RVA = "0x1A52454", Offset = "0x1A52454", VA = "0x1A52454")]
		private static extern RESULT FMOD_Studio_CommandReplay_GetCommandInfo(IntPtr replay, int commandindex, out COMMAND_INFO info);

		[PreserveSig]
		[Token(Token = "0x600077F")]
		[Address(RVA = "0x1A5275C", Offset = "0x1A5275C", VA = "0x1A5275C")]
		private static extern RESULT FMOD_Studio_CommandReplay_GetCommandString(IntPtr replay, int commandIndex, IntPtr buffer, int length);

		[PreserveSig]
		[Token(Token = "0x6000780")]
		[Address(RVA = "0x1A52828", Offset = "0x1A52828", VA = "0x1A52828")]
		private static extern RESULT FMOD_Studio_CommandReplay_GetCommandAtTime(IntPtr replay, float time, out int commandIndex);

		[PreserveSig]
		[Token(Token = "0x6000781")]
		[Address(RVA = "0x1A52A40", Offset = "0x1A52A40", VA = "0x1A52A40")]
		private static extern RESULT FMOD_Studio_CommandReplay_SetBankPath(IntPtr replay, byte[] bankPath);

		[PreserveSig]
		[Token(Token = "0x6000782")]
		[Address(RVA = "0x1A52AFC", Offset = "0x1A52AFC", VA = "0x1A52AFC")]
		private static extern RESULT FMOD_Studio_CommandReplay_Start(IntPtr replay);

		[PreserveSig]
		[Token(Token = "0x6000783")]
		[Address(RVA = "0x1A52BA0", Offset = "0x1A52BA0", VA = "0x1A52BA0")]
		private static extern RESULT FMOD_Studio_CommandReplay_Stop(IntPtr replay);

		[PreserveSig]
		[Token(Token = "0x6000784")]
		[Address(RVA = "0x1A52C44", Offset = "0x1A52C44", VA = "0x1A52C44")]
		private static extern RESULT FMOD_Studio_CommandReplay_SeekToTime(IntPtr replay, float time);

		[PreserveSig]
		[Token(Token = "0x6000785")]
		[Address(RVA = "0x1A52CF8", Offset = "0x1A52CF8", VA = "0x1A52CF8")]
		private static extern RESULT FMOD_Studio_CommandReplay_SeekToCommand(IntPtr replay, int commandIndex);

		[PreserveSig]
		[Token(Token = "0x6000786")]
		[Address(RVA = "0x1A52DAC", Offset = "0x1A52DAC", VA = "0x1A52DAC")]
		private static extern RESULT FMOD_Studio_CommandReplay_GetPaused(IntPtr replay, out bool paused);

		[PreserveSig]
		[Token(Token = "0x6000787")]
		[Address(RVA = "0x1A52E78", Offset = "0x1A52E78", VA = "0x1A52E78")]
		private static extern RESULT FMOD_Studio_CommandReplay_SetPaused(IntPtr replay, bool paused);

		[PreserveSig]
		[Token(Token = "0x6000788")]
		[Address(RVA = "0x1A52F2C", Offset = "0x1A52F2C", VA = "0x1A52F2C")]
		private static extern RESULT FMOD_Studio_CommandReplay_GetPlaybackState(IntPtr replay, out PLAYBACK_STATE state);

		[PreserveSig]
		[Token(Token = "0x6000789")]
		[Address(RVA = "0x1A52FE0", Offset = "0x1A52FE0", VA = "0x1A52FE0")]
		private static extern RESULT FMOD_Studio_CommandReplay_GetCurrentCommand(IntPtr replay, out int commandIndex, out float currentTime);

		[PreserveSig]
		[Token(Token = "0x600078A")]
		[Address(RVA = "0x1A5309C", Offset = "0x1A5309C", VA = "0x1A5309C")]
		private static extern RESULT FMOD_Studio_CommandReplay_Release(IntPtr replay);

		[PreserveSig]
		[Token(Token = "0x600078B")]
		[Address(RVA = "0x1A53140", Offset = "0x1A53140", VA = "0x1A53140")]
		private static extern RESULT FMOD_Studio_CommandReplay_SetFrameCallback(IntPtr replay, COMMANDREPLAY_FRAME_CALLBACK callback);

		[PreserveSig]
		[Token(Token = "0x600078C")]
		[Address(RVA = "0x1A531FC", Offset = "0x1A531FC", VA = "0x1A531FC")]
		private static extern RESULT FMOD_Studio_CommandReplay_SetLoadBankCallback(IntPtr replay, COMMANDREPLAY_LOAD_BANK_CALLBACK callback);

		[PreserveSig]
		[Token(Token = "0x600078D")]
		[Address(RVA = "0x1A532B8", Offset = "0x1A532B8", VA = "0x1A532B8")]
		private static extern RESULT FMOD_Studio_CommandReplay_SetCreateInstanceCallback(IntPtr replay, COMMANDREPLAY_CREATE_INSTANCE_CALLBACK callback);

		[PreserveSig]
		[Token(Token = "0x600078E")]
		[Address(RVA = "0x1A53374", Offset = "0x1A53374", VA = "0x1A53374")]
		private static extern RESULT FMOD_Studio_CommandReplay_GetUserData(IntPtr replay, out IntPtr userdata);

		[PreserveSig]
		[Token(Token = "0x600078F")]
		[Address(RVA = "0x1A53428", Offset = "0x1A53428", VA = "0x1A53428")]
		private static extern RESULT FMOD_Studio_CommandReplay_SetUserData(IntPtr replay, IntPtr userdata);

		[Token(Token = "0x6000790")]
		[Address(RVA = "0x9C80E8", Offset = "0x9C80E8", VA = "0x9C80E8")]
		public bool hasHandle()
		{
			return default(bool);
		}

		[Token(Token = "0x6000791")]
		[Address(RVA = "0x9C80F0", Offset = "0x9C80F0", VA = "0x9C80F0")]
		public void clearHandle()
		{
		}

		[Token(Token = "0x6000792")]
		[Address(RVA = "0x9C8134", Offset = "0x9C8134", VA = "0x9C8134")]
		public bool isValid()
		{
			return default(bool);
		}
	}
}
namespace FMODUnity
{
	[Token(Token = "0x2000110")]
	public class BankRefAttribute : PropertyAttribute
	{
		[Token(Token = "0x6000793")]
		[Address(RVA = "0x102E3F0", Offset = "0x102E3F0", VA = "0x102E3F0")]
		public BankRefAttribute()
		{
		}
	}
	[Token(Token = "0x2000111")]
	public abstract class EventHandler : MonoBehaviour
	{
		[Token(Token = "0x40005EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string CollisionTag;

		[Token(Token = "0x6000794")]
		[Address(RVA = "0x102E4AC", Offset = "0x102E4AC", VA = "0x102E4AC")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000795")]
		[Address(RVA = "0x102E4BC", Offset = "0x102E4BC", VA = "0x102E4BC")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000796")]
		[Address(RVA = "0x102E4CC", Offset = "0x102E4CC", VA = "0x102E4CC")]
		private void OnTriggerEnter(Collider other)
		{
		}

		[Token(Token = "0x6000797")]
		[Address(RVA = "0x102E548", Offset = "0x102E548", VA = "0x102E548")]
		private void OnTriggerExit(Collider other)
		{
		}

		[Token(Token = "0x6000798")]
		[Address(RVA = "0x102E5C4", Offset = "0x102E5C4", VA = "0x102E5C4")]
		private void OnTriggerEnter2D(Collider2D other)
		{
		}

		[Token(Token = "0x6000799")]
		[Address(RVA = "0x102E640", Offset = "0x102E640", VA = "0x102E640")]
		private void OnTriggerExit2D(Collider2D other)
		{
		}

		[Token(Token = "0x600079A")]
		[Address(RVA = "0x102E6BC", Offset = "0x102E6BC", VA = "0x102E6BC")]
		private void OnCollisionEnter()
		{
		}

		[Token(Token = "0x600079B")]
		[Address(RVA = "0x102E6CC", Offset = "0x102E6CC", VA = "0x102E6CC")]
		private void OnCollisionExit()
		{
		}

		[Token(Token = "0x600079C")]
		[Address(RVA = "0x102E6DC", Offset = "0x102E6DC", VA = "0x102E6DC")]
		private void OnCollisionEnter2D()
		{
		}

		[Token(Token = "0x600079D")]
		[Address(RVA = "0x102E6EC", Offset = "0x102E6EC", VA = "0x102E6EC")]
		private void OnCollisionExit2D()
		{
		}

		[Token(Token = "0x600079E")]
		[Address(RVA = "0x102E6FC", Offset = "0x102E6FC", VA = "0x102E6FC")]
		private void OnMouseEnter()
		{
		}

		[Token(Token = "0x600079F")]
		[Address(RVA = "0x102E70C", Offset = "0x102E70C", VA = "0x102E70C")]
		private void OnMouseExit()
		{
		}

		[Token(Token = "0x60007A0")]
		[Address(RVA = "0x102E71C", Offset = "0x102E71C", VA = "0x102E71C")]
		private void OnMouseDown()
		{
		}

		[Token(Token = "0x60007A1")]
		[Address(RVA = "0x102E72C", Offset = "0x102E72C", VA = "0x102E72C")]
		private void OnMouseUp()
		{
		}

		[Token(Token = "0x60007A2")]
		protected abstract void HandleGameEvent(EmitterGameEvent gameEvent);

		[Token(Token = "0x60007A3")]
		[Address(RVA = "0x102E73C", Offset = "0x102E73C", VA = "0x102E73C")]
		protected EventHandler()
		{
		}
	}
	[Token(Token = "0x2000112")]
	public class EventRefAttribute : PropertyAttribute
	{
		[Token(Token = "0x60007A4")]
		[Address(RVA = "0x102E918", Offset = "0x102E918", VA = "0x102E918")]
		public EventRefAttribute()
		{
		}
	}
	[Token(Token = "0x2000113")]
	public class FMODRuntimeManagerOnGUIHelper : MonoBehaviour
	{
		[Token(Token = "0x40005EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public RuntimeManager TargetRuntimeManager;

		[Token(Token = "0x60007A5")]
		[Address(RVA = "0x102E920", Offset = "0x102E920", VA = "0x102E920")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x60007A6")]
		[Address(RVA = "0x102EAC0", Offset = "0x102EAC0", VA = "0x102EAC0")]
		public FMODRuntimeManagerOnGUIHelper()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000114")]
	public class ParamRef
	{
		[Token(Token = "0x40005ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string Name;

		[Token(Token = "0x40005EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float Value;

		[Token(Token = "0x40005EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public PARAMETER_ID ID;

		[Token(Token = "0x60007A7")]
		[Address(RVA = "0x102EAC8", Offset = "0x102EAC8", VA = "0x102EAC8")]
		public ParamRef()
		{
		}
	}
	[Token(Token = "0x2000115")]
	public class ParamRefAttribute : PropertyAttribute
	{
		[Token(Token = "0x60007A8")]
		[Address(RVA = "0x102EAD0", Offset = "0x102EAD0", VA = "0x102EAD0")]
		public ParamRefAttribute()
		{
		}
	}
	[Token(Token = "0x2000116")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x8F2268", Offset = "0x8F2268")]
	public class RuntimeManager : MonoBehaviour
	{
		[Token(Token = "0x200014A")]
		private struct LoadedBank
		{
			[Token(Token = "0x4000721")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Bank Bank;

			[Token(Token = "0x4000722")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public int RefCount;
		}

		[Token(Token = "0x200014B")]
		private class GuidComparer : IEqualityComparer<Guid>
		{
			[Token(Token = "0x6000867")]
			[Address(RVA = "0x103556C", Offset = "0x103556C", VA = "0x103556C", Slot = "4")]
			private bool System.Collections.Generic.IEqualityComparer<System.Guid>.Equals(Guid x, Guid y)
			{
				return default(bool);
			}

			[Token(Token = "0x6000868")]
			[Address(RVA = "0x10355A0", Offset = "0x10355A0", VA = "0x10355A0", Slot = "5")]
			private int System.Collections.Generic.IEqualityComparer<System.Guid>.GetHashCode(Guid obj)
			{
				return default(int);
			}

			[Token(Token = "0x6000869")]
			[Address(RVA = "0x1035120", Offset = "0x1035120", VA = "0x1035120")]
			public GuidComparer()
			{
			}
		}

		[Token(Token = "0x200014C")]
		private class AttachedInstance
		{
			[Token(Token = "0x4000723")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public EventInstance instance;

			[Token(Token = "0x4000724")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Transform transform;

			[Token(Token = "0x4000725")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Rigidbody rigidBody;

			[Token(Token = "0x4000726")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Rigidbody2D rigidBody2D;

			[Token(Token = "0x600086A")]
			[Address(RVA = "0x1031FF8", Offset = "0x1031FF8", VA = "0x1031FF8")]
			public AttachedInstance()
			{
			}
		}

		[Token(Token = "0x200014D")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F2408", Offset = "0x8F2408")]
		private sealed class <loadFromWeb>d__42 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000727")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000728")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000729")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public string bankPath;

			[Token(Token = "0x400072A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public RuntimeManager <>4__this;

			[Token(Token = "0x400072B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public string bankName;

			[Token(Token = "0x400072C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public bool loadSamples;

			[Token(Token = "0x400072D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private UnityWebRequest <www>5__2;

			[Token(Token = "0x17000060")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600086E")]
				[Address(RVA = "0x10354F4", Offset = "0x10354F4", VA = "0x10354F4", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000061")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000870")]
				[Address(RVA = "0x1035564", Offset = "0x1035564", VA = "0x1035564", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600086B")]
			[Address(RVA = "0x1032CA4", Offset = "0x1032CA4", VA = "0x1032CA4")]
			[DebuggerHidden]
			public <loadFromWeb>d__42(int <>1__state)
			{
			}

			[Token(Token = "0x600086C")]
			[Address(RVA = "0x10351B0", Offset = "0x10351B0", VA = "0x10351B0", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600086D")]
			[Address(RVA = "0x10351B4", Offset = "0x10351B4", VA = "0x10351B4", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600086F")]
			[Address(RVA = "0x10354FC", Offset = "0x10354FC", VA = "0x10354FC", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40005F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static SystemNotInitializedException initException;

		[Token(Token = "0x40005F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static RuntimeManager instance;

		[Token(Token = "0x40005F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private FMODPlatform fmodPlatform;

		[Token(Token = "0x40005F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private FMOD.Studio.System studioSystem;

		[Token(Token = "0x40005F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private FMOD.System coreSystem;

		[Token(Token = "0x40005F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private DSP mixerHead;

		[Token(Token = "0x40005F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private long[] cachedPointers;

		[Token(Token = "0x40005F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Dictionary<string, LoadedBank> loadedBanks;

		[Token(Token = "0x40005F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Dictionary<string, uint> loadedPlugins;

		[Token(Token = "0x40005F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Dictionary<Guid, EventDescription> cachedDescriptions;

		[Token(Token = "0x40005FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private List<AttachedInstance> attachedInstances;

		[Token(Token = "0x40005FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private bool listenerWarningIssued;

		[Token(Token = "0x40005FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x61")]
		protected bool isOverlayEnabled;

		[Token(Token = "0x40005FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private FMODRuntimeManagerOnGUIHelper overlayDrawer;

		[Token(Token = "0x40005FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Rect windowRect;

		[Token(Token = "0x40005FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private string lastDebugText;

		[Token(Token = "0x4000600")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private float lastDebugUpdate;

		[Token(Token = "0x4000601")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static List<StudioListener> Listeners;

		[Token(Token = "0x4000602")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static int numListeners;

		[Token(Token = "0x1700004B")]
		private static RuntimeManager Instance
		{
			[Token(Token = "0x60007AA")]
			[Address(RVA = "0x102ED94", Offset = "0x102ED94", VA = "0x102ED94")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700004C")]
		public static FMOD.Studio.System StudioSystem
		{
			[Token(Token = "0x60007AB")]
			[Address(RVA = "0x102D40C", Offset = "0x102D40C", VA = "0x102D40C")]
			get
			{
				return default(FMOD.Studio.System);
			}
		}

		[Token(Token = "0x1700004D")]
		public static FMOD.System CoreSystem
		{
			[Token(Token = "0x60007AC")]
			[Address(RVA = "0x102FFC0", Offset = "0x102FFC0", VA = "0x102FFC0")]
			get
			{
				return default(FMOD.System);
			}
		}

		[Token(Token = "0x1700004E")]
		public static bool IsInitialized
		{
			[Token(Token = "0x60007D6")]
			[Address(RVA = "0x1034DA8", Offset = "0x1034DA8", VA = "0x1034DA8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700004F")]
		public static bool HasBanksLoaded
		{
			[Token(Token = "0x60007D7")]
			[Address(RVA = "0x1034C4C", Offset = "0x1034C4C", VA = "0x1034C4C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60007A9")]
		[Address(RVA = "0x102EBD0", Offset = "0x102EBD0", VA = "0x102EBD0")]
		[AttributeAttribute(Name = "MonoPInvokeCallbackAttribute", RVA = "0x8F4310", Offset = "0x8F4310")]
		private static RESULT DEBUG_CALLBACK(DEBUG_FLAGS flags, StringWrapper file, int line, StringWrapper func, StringWrapper message)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60007AD")]
		[Address(RVA = "0x1030030", Offset = "0x1030030", VA = "0x1030030")]
		private void CheckInitResult(RESULT result, string cause)
		{
		}

		[Token(Token = "0x60007AE")]
		[Address(RVA = "0x102F824", Offset = "0x102F824", VA = "0x102F824")]
		private RESULT Initialize()
		{
			return default(RESULT);
		}

		[Token(Token = "0x60007AF")]
		[Address(RVA = "0x1031024", Offset = "0x1031024", VA = "0x1031024")]
		public static int AddListener(StudioListener listener)
		{
			return default(int);
		}

		[Token(Token = "0x60007B0")]
		[Address(RVA = "0x10314A0", Offset = "0x10314A0", VA = "0x10314A0")]
		public static bool RemoveListener(StudioListener listener)
		{
			return default(bool);
		}

		[Token(Token = "0x60007B1")]
		[Address(RVA = "0x103183C", Offset = "0x103183C", VA = "0x103183C")]
		private void Update()
		{
		}

		[Token(Token = "0x60007B2")]
		[Address(RVA = "0x102D920", Offset = "0x102D920", VA = "0x102D920")]
		public static void AttachInstanceToGameObject(EventInstance instance, Transform transform, Rigidbody rigidBody)
		{
		}

		[Token(Token = "0x60007B3")]
		[Address(RVA = "0x102DA4C", Offset = "0x102DA4C", VA = "0x102DA4C")]
		public static void AttachInstanceToGameObject(EventInstance instance, Transform transform, Rigidbody2D rigidBody2D)
		{
		}

		[Token(Token = "0x60007B4")]
		[Address(RVA = "0x1032000", Offset = "0x1032000", VA = "0x1032000")]
		public static void DetachInstanceFromGameObject(EventInstance instance)
		{
		}

		[Token(Token = "0x60007B5")]
		[Address(RVA = "0x102E9B4", Offset = "0x102E9B4", VA = "0x102E9B4")]
		public void ExecuteOnGUI()
		{
		}

		[Token(Token = "0x60007B6")]
		[Address(RVA = "0x103213C", Offset = "0x103213C", VA = "0x103213C")]
		private void Start()
		{
		}

		[Token(Token = "0x60007B7")]
		[Address(RVA = "0x1032260", Offset = "0x1032260", VA = "0x1032260")]
		private void DrawDebugOverlay(int windowID)
		{
		}

		[Token(Token = "0x60007B8")]
		[Address(RVA = "0x1032770", Offset = "0x1032770", VA = "0x1032770")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60007B9")]
		[Address(RVA = "0x1032810", Offset = "0x1032810", VA = "0x1032810")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60007BA")]
		[Address(RVA = "0x10328B4", Offset = "0x10328B4", VA = "0x10328B4")]
		private void OnApplicationPause(bool pauseStatus)
		{
		}

		[Token(Token = "0x60007BB")]
		[Address(RVA = "0x1032A24", Offset = "0x1032A24", VA = "0x1032A24")]
		private void loadedBankRegister(LoadedBank loadedBank, string bankPath, string bankName, bool loadSamples, RESULT loadResult)
		{
		}

		[Token(Token = "0x60007BC")]
		[Address(RVA = "0x1032BD4", Offset = "0x1032BD4", VA = "0x1032BD4")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x8F4374", Offset = "0x8F4374")]
		private IEnumerator loadFromWeb(string bankPath, string bankName, bool loadSamples)
		{
			return null;
		}

		[Token(Token = "0x60007BD")]
		[Address(RVA = "0x1032CD0", Offset = "0x1032CD0", VA = "0x1032CD0")]
		public static void LoadBank(string bankName, bool loadSamples = false)
		{
		}

		[Token(Token = "0x60007BE")]
		[Address(RVA = "0x1033278", Offset = "0x1033278", VA = "0x1033278")]
		public static void LoadBank(TextAsset asset, bool loadSamples = false)
		{
		}

		[Token(Token = "0x60007BF")]
		[Address(RVA = "0x1030B14", Offset = "0x1030B14", VA = "0x1030B14")]
		private void LoadBanks(Settings fmodSettings)
		{
		}

		[Token(Token = "0x60007C0")]
		[Address(RVA = "0x10335BC", Offset = "0x10335BC", VA = "0x10335BC")]
		public static void UnloadBank(string bankName)
		{
		}

		[Token(Token = "0x60007C1")]
		[Address(RVA = "0x103373C", Offset = "0x103373C", VA = "0x103373C")]
		public static bool AnyBankLoading()
		{
			return default(bool);
		}

		[Token(Token = "0x60007C2")]
		[Address(RVA = "0x1033548", Offset = "0x1033548", VA = "0x1033548")]
		public static void WaitForAllLoads()
		{
		}

		[Token(Token = "0x60007C3")]
		[Address(RVA = "0x10338C8", Offset = "0x10338C8", VA = "0x10338C8")]
		public static Guid PathToGUID(string path)
		{
			return default(Guid);
		}

		[Token(Token = "0x60007C4")]
		[Address(RVA = "0x102D80C", Offset = "0x102D80C", VA = "0x102D80C")]
		public static EventInstance CreateInstance(string path)
		{
			return default(EventInstance);
		}

		[Token(Token = "0x60007C5")]
		[Address(RVA = "0x1033A08", Offset = "0x1033A08", VA = "0x1033A08")]
		public static EventInstance CreateInstance(Guid guid)
		{
			return default(EventInstance);
		}

		[Token(Token = "0x60007C6")]
		[Address(RVA = "0x1033D10", Offset = "0x1033D10", VA = "0x1033D10")]
		public static void PlayOneShot(string path, [Optional] Vector3 position)
		{
		}

		[Token(Token = "0x60007C7")]
		[Address(RVA = "0x1033E70", Offset = "0x1033E70", VA = "0x1033E70")]
		public static void PlayOneShot(Guid guid, [Optional] Vector3 position)
		{
		}

		[Token(Token = "0x60007C8")]
		[Address(RVA = "0x1033F50", Offset = "0x1033F50", VA = "0x1033F50")]
		public static void PlayOneShotAttached(string path, GameObject gameObject)
		{
		}

		[Token(Token = "0x60007C9")]
		[Address(RVA = "0x1034094", Offset = "0x1034094", VA = "0x1034094")]
		public static void PlayOneShotAttached(Guid guid, GameObject gameObject)
		{
		}

		[Token(Token = "0x60007CA")]
		[Address(RVA = "0x1034198", Offset = "0x1034198", VA = "0x1034198")]
		public static EventDescription GetEventDescription(string path)
		{
			return default(EventDescription);
		}

		[Token(Token = "0x60007CB")]
		[Address(RVA = "0x1033AA4", Offset = "0x1033AA4", VA = "0x1033AA4")]
		public static EventDescription GetEventDescription(Guid guid)
		{
			return default(EventDescription);
		}

		[Token(Token = "0x60007CC")]
		[Address(RVA = "0x10342AC", Offset = "0x10342AC", VA = "0x10342AC")]
		public static void SetListenerLocation(GameObject gameObject, [Optional] Rigidbody rigidBody)
		{
		}

		[Token(Token = "0x60007CD")]
		[Address(RVA = "0x1034494", Offset = "0x1034494", VA = "0x1034494")]
		public static void SetListenerLocation(GameObject gameObject, Rigidbody2D rigidBody2D)
		{
		}

		[Token(Token = "0x60007CE")]
		[Address(RVA = "0x10346A4", Offset = "0x10346A4", VA = "0x10346A4")]
		public static void SetListenerLocation(Transform transform)
		{
		}

		[Token(Token = "0x60007CF")]
		[Address(RVA = "0x1034808", Offset = "0x1034808", VA = "0x1034808")]
		public static void SetListenerLocation(int listenerIndex, GameObject gameObject, [Optional] Rigidbody rigidBody)
		{
		}

		[Token(Token = "0x60007D0")]
		[Address(RVA = "0x10348B8", Offset = "0x10348B8", VA = "0x10348B8")]
		public static void SetListenerLocation(int listenerIndex, GameObject gameObject, Rigidbody2D rigidBody2D)
		{
		}

		[Token(Token = "0x60007D1")]
		[Address(RVA = "0x1034968", Offset = "0x1034968", VA = "0x1034968")]
		public static void SetListenerLocation(int listenerIndex, Transform transform)
		{
		}

		[Token(Token = "0x60007D2")]
		[Address(RVA = "0x1034A10", Offset = "0x1034A10", VA = "0x1034A10")]
		public static Bus GetBus(string path)
		{
			return default(Bus);
		}

		[Token(Token = "0x60007D3")]
		[Address(RVA = "0x1034AD8", Offset = "0x1034AD8", VA = "0x1034AD8")]
		public static VCA GetVCA(string path)
		{
			return default(VCA);
		}

		[Token(Token = "0x60007D4")]
		[Address(RVA = "0x1032960", Offset = "0x1032960", VA = "0x1032960")]
		public static void PauseAllEvents(bool paused)
		{
		}

		[Token(Token = "0x60007D5")]
		[Address(RVA = "0x1034CE4", Offset = "0x1034CE4", VA = "0x1034CE4")]
		public static void MuteAllEvents(bool muted)
		{
		}

		[Token(Token = "0x60007D8")]
		[Address(RVA = "0x1034E90", Offset = "0x1034E90", VA = "0x1034E90")]
		public static bool HasBankLoaded(string loadedBank)
		{
			return default(bool);
		}

		[Token(Token = "0x60007D9")]
		[Address(RVA = "0x1030930", Offset = "0x1030930", VA = "0x1030930")]
		private void LoadPlugins(Settings fmodSettings)
		{
		}

		[Token(Token = "0x60007DA")]
		[Address(RVA = "0x1030820", Offset = "0x1030820", VA = "0x1030820")]
		private void SetThreadAffinity()
		{
		}

		[Token(Token = "0x60007DB")]
		[Address(RVA = "0x1034FA8", Offset = "0x1034FA8", VA = "0x1034FA8")]
		public RuntimeManager()
		{
		}
	}
	[Token(Token = "0x2000117")]
	public class EventNotFoundException : Exception
	{
		[Token(Token = "0x4000603")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public Guid Guid;

		[Token(Token = "0x4000604")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public string Path;

		[Token(Token = "0x60007DD")]
		[Address(RVA = "0x102E794", Offset = "0x102E794", VA = "0x102E794")]
		public EventNotFoundException(string path)
		{
		}

		[Token(Token = "0x60007DE")]
		[Address(RVA = "0x102E840", Offset = "0x102E840", VA = "0x102E840")]
		public EventNotFoundException(Guid guid)
		{
		}
	}
	[Token(Token = "0x2000118")]
	public class BusNotFoundException : Exception
	{
		[Token(Token = "0x4000605")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public string Path;

		[Token(Token = "0x60007DF")]
		[Address(RVA = "0x102E3F8", Offset = "0x102E3F8", VA = "0x102E3F8")]
		public BusNotFoundException(string path)
		{
		}
	}
	[Token(Token = "0x2000119")]
	public class VCANotFoundException : Exception
	{
		[Token(Token = "0x4000606")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public string Path;

		[Token(Token = "0x60007E0")]
		[Address(RVA = "0x1034BA0", Offset = "0x1034BA0", VA = "0x1034BA0")]
		public VCANotFoundException(string path)
		{
		}
	}
	[Token(Token = "0x200011A")]
	public class BankLoadException : Exception
	{
		[Token(Token = "0x4000607")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public string Path;

		[Token(Token = "0x4000608")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public RESULT Result;

		[Token(Token = "0x60007E1")]
		[Address(RVA = "0x102E228", Offset = "0x102E228", VA = "0x102E228")]
		public BankLoadException(string path, RESULT result)
		{
		}

		[Token(Token = "0x60007E2")]
		[Address(RVA = "0x102E340", Offset = "0x102E340", VA = "0x102E340")]
		public BankLoadException(string path, string error)
		{
		}
	}
	[Token(Token = "0x200011B")]
	public class SystemNotInitializedException : Exception
	{
		[Token(Token = "0x4000609")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public RESULT Result;

		[Token(Token = "0x400060A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public string Location;

		[Token(Token = "0x60007E3")]
		[Address(RVA = "0x102FEA8", Offset = "0x102FEA8", VA = "0x102FEA8")]
		public SystemNotInitializedException(RESULT result, string location)
		{
		}

		[Token(Token = "0x60007E4")]
		[Address(RVA = "0x102FE24", Offset = "0x102FE24", VA = "0x102FE24")]
		public SystemNotInitializedException(Exception inner)
		{
		}
	}
	[Token(Token = "0x200011C")]
	public enum EmitterGameEvent
	{
		[Token(Token = "0x400060C")]
		None,
		[Token(Token = "0x400060D")]
		ObjectStart,
		[Token(Token = "0x400060E")]
		ObjectDestroy,
		[Token(Token = "0x400060F")]
		TriggerEnter,
		[Token(Token = "0x4000610")]
		TriggerExit,
		[Token(Token = "0x4000611")]
		TriggerEnter2D,
		[Token(Token = "0x4000612")]
		TriggerExit2D,
		[Token(Token = "0x4000613")]
		CollisionEnter,
		[Token(Token = "0x4000614")]
		CollisionExit,
		[Token(Token = "0x4000615")]
		CollisionEnter2D,
		[Token(Token = "0x4000616")]
		CollisionExit2D,
		[Token(Token = "0x4000617")]
		ObjectEnable,
		[Token(Token = "0x4000618")]
		ObjectDisable,
		[Token(Token = "0x4000619")]
		MouseEnter,
		[Token(Token = "0x400061A")]
		MouseExit,
		[Token(Token = "0x400061B")]
		MouseDown,
		[Token(Token = "0x400061C")]
		MouseUp
	}
	[Token(Token = "0x200011D")]
	public enum LoaderGameEvent
	{
		[Token(Token = "0x400061E")]
		None,
		[Token(Token = "0x400061F")]
		ObjectStart,
		[Token(Token = "0x4000620")]
		ObjectDestroy,
		[Token(Token = "0x4000621")]
		TriggerEnter,
		[Token(Token = "0x4000622")]
		TriggerExit,
		[Token(Token = "0x4000623")]
		TriggerEnter2D,
		[Token(Token = "0x4000624")]
		TriggerExit2D
	}
	[Token(Token = "0x200011E")]
	public static class RuntimeUtils
	{
		[Token(Token = "0x4000625")]
		private const string BankExtension = ".bank";

		[Token(Token = "0x60007E5")]
		[Address(RVA = "0x10355C8", Offset = "0x10355C8", VA = "0x10355C8")]
		public static string GetCommonPlatformPath(string path)
		{
			return null;
		}

		[Token(Token = "0x60007E6")]
		[Address(RVA = "0x103561C", Offset = "0x103561C", VA = "0x103561C")]
		public static VECTOR ToFMODVector(this Vector3 vec)
		{
			return default(VECTOR);
		}

		[Token(Token = "0x60007E7")]
		[Address(RVA = "0x102DB8C", Offset = "0x102DB8C", VA = "0x102DB8C")]
		public static ATTRIBUTES_3D To3DAttributes(this Vector3 pos)
		{
			return default(ATTRIBUTES_3D);
		}

		[Token(Token = "0x60007E8")]
		[Address(RVA = "0x1034740", Offset = "0x1034740", VA = "0x1034740")]
		public static ATTRIBUTES_3D To3DAttributes(this Transform transform)
		{
			return default(ATTRIBUTES_3D);
		}

		[Token(Token = "0x60007E9")]
		[Address(RVA = "0x1031D80", Offset = "0x1031D80", VA = "0x1031D80")]
		public static ATTRIBUTES_3D To3DAttributes(Transform transform, [Optional] Rigidbody rigidbody)
		{
			return default(ATTRIBUTES_3D);
		}

		[Token(Token = "0x60007EA")]
		[Address(RVA = "0x1034358", Offset = "0x1034358", VA = "0x1034358")]
		public static ATTRIBUTES_3D To3DAttributes(GameObject go, [Optional] Rigidbody rigidbody)
		{
			return default(ATTRIBUTES_3D);
		}

		[Token(Token = "0x60007EB")]
		[Address(RVA = "0x1031EA8", Offset = "0x1031EA8", VA = "0x1031EA8")]
		public static ATTRIBUTES_3D To3DAttributes(Transform transform, Rigidbody2D rigidbody)
		{
			return default(ATTRIBUTES_3D);
		}

		[Token(Token = "0x60007EC")]
		[Address(RVA = "0x1034540", Offset = "0x1034540", VA = "0x1034540")]
		public static ATTRIBUTES_3D To3DAttributes(GameObject go, Rigidbody2D rigidbody)
		{
			return default(ATTRIBUTES_3D);
		}

		[Token(Token = "0x60007ED")]
		[Address(RVA = "0x1030304", Offset = "0x1030304", VA = "0x1030304")]
		internal static FMODPlatform GetCurrentPlatform()
		{
			return default(FMODPlatform);
		}

		[Token(Token = "0x60007EE")]
		[Address(RVA = "0x1033144", Offset = "0x1033144", VA = "0x1033144")]
		internal static string GetBankPath(string bankName)
		{
			return null;
		}

		[Token(Token = "0x60007EF")]
		[Address(RVA = "0x1034F2C", Offset = "0x1034F2C", VA = "0x1034F2C")]
		internal static string GetPluginPath(string pluginName)
		{
			return null;
		}

		[Token(Token = "0x60007F0")]
		[Address(RVA = "0x102F658", Offset = "0x102F658", VA = "0x102F658")]
		public static void EnforceLibraryOrder()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200011F")]
	public enum FMODPlatform
	{
		[Token(Token = "0x4000627")]
		None,
		[Token(Token = "0x4000628")]
		PlayInEditor,
		[Token(Token = "0x4000629")]
		Default,
		[Token(Token = "0x400062A")]
		Desktop,
		[Token(Token = "0x400062B")]
		Mobile,
		[Token(Token = "0x400062C")]
		MobileHigh,
		[Token(Token = "0x400062D")]
		MobileLow,
		[Token(Token = "0x400062E")]
		Console,
		[Token(Token = "0x400062F")]
		Windows,
		[Token(Token = "0x4000630")]
		Mac,
		[Token(Token = "0x4000631")]
		Linux,
		[Token(Token = "0x4000632")]
		iOS,
		[Token(Token = "0x4000633")]
		Android,
		[Token(Token = "0x4000634")]
		Deprecated_1,
		[Token(Token = "0x4000635")]
		XboxOne,
		[Token(Token = "0x4000636")]
		PS4,
		[Token(Token = "0x4000637")]
		Deprecated_2,
		[Token(Token = "0x4000638")]
		Deprecated_3,
		[Token(Token = "0x4000639")]
		AppleTV,
		[Token(Token = "0x400063A")]
		UWP,
		[Token(Token = "0x400063B")]
		Switch,
		[Token(Token = "0x400063C")]
		WebGL,
		[Token(Token = "0x400063D")]
		Count
	}
	[Serializable]
	[Token(Token = "0x2000120")]
	public enum ImportType
	{
		[Token(Token = "0x400063F")]
		StreamingAssets,
		[Token(Token = "0x4000640")]
		AssetBundle
	}
	[Serializable]
	[Token(Token = "0x2000121")]
	public enum BankLoadType
	{
		[Token(Token = "0x4000642")]
		All,
		[Token(Token = "0x4000643")]
		Specified,
		[Token(Token = "0x4000644")]
		None
	}
	[Token(Token = "0x2000122")]
	public class PlatformSettingBase
	{
		[Token(Token = "0x4000645")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public FMODPlatform Platform;

		[Token(Token = "0x60007F1")]
		[Address(RVA = "0x102EB78", Offset = "0x102EB78", VA = "0x102EB78")]
		public PlatformSettingBase()
		{
		}
	}
	[Token(Token = "0x2000123")]
	public class PlatformSetting<T> : PlatformSettingBase
	{
		[Token(Token = "0x4000646")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public T Value;

		[Token(Token = "0x60007F2")]
		public PlatformSetting()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000124")]
	public class PlatformIntSetting : PlatformSetting<int>
	{
		[Token(Token = "0x60007F3")]
		[Address(RVA = "0x102EB28", Offset = "0x102EB28", VA = "0x102EB28")]
		public PlatformIntSetting()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000125")]
	public class PlatformStringSetting : PlatformSetting<string>
	{
		[Token(Token = "0x60007F4")]
		[Address(RVA = "0x102EB80", Offset = "0x102EB80", VA = "0x102EB80")]
		public PlatformStringSetting()
		{
		}
	}
	[Token(Token = "0x2000126")]
	public enum TriStateBool
	{
		[Token(Token = "0x4000648")]
		Disabled,
		[Token(Token = "0x4000649")]
		Enabled,
		[Token(Token = "0x400064A")]
		Development
	}
	[Serializable]
	[Token(Token = "0x2000127")]
	public class PlatformBoolSetting : PlatformSetting<TriStateBool>
	{
		[Token(Token = "0x60007F5")]
		[Address(RVA = "0x102EAD8", Offset = "0x102EAD8", VA = "0x102EAD8")]
		public PlatformBoolSetting()
		{
		}
	}
	[Token(Token = "0x2000128")]
	public class Settings : ScriptableObject
	{
		[Token(Token = "0x200014E")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F2418", Offset = "0x8F2418")]
		private sealed class <>c__DisplayClass40_0<T> where T : PlatformSettingBase
		{
			[Token(Token = "0x400072E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public FMODPlatform platform;

			[Token(Token = "0x6000871")]
			public <>c__DisplayClass40_0()
			{
			}

			[Token(Token = "0x6000872")]
			internal bool <HasSetting>b__0(T x)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x200014F")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F2428", Offset = "0x8F2428")]
		private sealed class <>c__DisplayClass41_0<T, U> where T : PlatformSetting<U>
		{
			[Token(Token = "0x400072F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public FMODPlatform platform;

			[Token(Token = "0x6000873")]
			public <>c__DisplayClass41_0()
			{
			}

			[Token(Token = "0x6000874")]
			internal bool <GetSetting>b__0(T x)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x2000150")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F2438", Offset = "0x8F2438")]
		private sealed class <>c__DisplayClass42_0<T, U> where T : PlatformSetting<U>, new()
		{
			[Token(Token = "0x4000730")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public FMODPlatform platform;

			[Token(Token = "0x6000875")]
			public <>c__DisplayClass42_0()
			{
			}

			[Token(Token = "0x6000876")]
			internal bool <SetSetting>b__0(T x)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x2000151")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F2448", Offset = "0x8F2448")]
		private sealed class <>c__DisplayClass43_0<T> where T : PlatformSettingBase
		{
			[Token(Token = "0x4000731")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public FMODPlatform platform;

			[Token(Token = "0x6000877")]
			public <>c__DisplayClass43_0()
			{
			}

			[Token(Token = "0x6000878")]
			internal bool <RemoveSetting>b__0(T x)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x400064B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private bool SwitchSettingsMigration;

		[Token(Token = "0x400064C")]
		private const string SettingsAssetName = "FMODStudioSettings";

		[Token(Token = "0x400064D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static Settings instance;

		[Token(Token = "0x400064E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		[SerializeField]
		public bool HasSourceProject;

		[Token(Token = "0x400064F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
		[SerializeField]
		public bool HasPlatforms;

		[Token(Token = "0x4000650")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private string sourceProjectPath;

		[Token(Token = "0x4000651")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private string SourceBankPathUnformatted;

		[Token(Token = "0x4000652")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		public bool AutomaticEventLoading;

		[Token(Token = "0x4000653")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[SerializeField]
		public BankLoadType BankLoadType;

		[Token(Token = "0x4000654")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		public bool AutomaticSampleLoading;

		[Token(Token = "0x4000655")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		public string EncryptionKey;

		[Token(Token = "0x4000656")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		public ImportType ImportType;

		[Token(Token = "0x4000657")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		public string TargetAssetPath;

		[Token(Token = "0x4000658")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		public DEBUG_FLAGS LoggingLevel;

		[Token(Token = "0x4000659")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		public List<PlatformIntSetting> SpeakerModeSettings;

		[Token(Token = "0x400065A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		public List<PlatformIntSetting> SampleRateSettings;

		[Token(Token = "0x400065B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		public List<PlatformBoolSetting> LiveUpdateSettings;

		[Token(Token = "0x400065C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[SerializeField]
		public List<PlatformBoolSetting> OverlaySettings;

		[Token(Token = "0x400065D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[SerializeField]
		public List<PlatformBoolSetting> LoggingSettings;

		[Token(Token = "0x400065E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[SerializeField]
		public List<PlatformStringSetting> BankDirectorySettings;

		[Token(Token = "0x400065F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[SerializeField]
		public List<PlatformIntSetting> VirtualChannelSettings;

		[Token(Token = "0x4000660")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		[SerializeField]
		public List<PlatformIntSetting> RealChannelSettings;

		[Token(Token = "0x4000661")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		[SerializeField]
		public List<string> Plugins;

		[Token(Token = "0x4000662")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[SerializeField]
		public List<string> MasterBanks;

		[Token(Token = "0x4000663")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[SerializeField]
		public List<string> Banks;

		[Token(Token = "0x4000664")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		[SerializeField]
		public List<string> BanksToLoad;

		[Token(Token = "0x4000665")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[SerializeField]
		public ushort LiveUpdatePort;

		[Token(Token = "0x17000050")]
		public static Settings Instance
		{
			[Token(Token = "0x60007F6")]
			[Address(RVA = "0x10300EC", Offset = "0x10300EC", VA = "0x10300EC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000051")]
		public string SourceProjectPathRelative
		{
			[Token(Token = "0x60007F7")]
			[Address(RVA = "0x1035620", Offset = "0x1035620", VA = "0x1035620")]
			get
			{
				return null;
			}
			[Token(Token = "0x60007F8")]
			[Address(RVA = "0x1035628", Offset = "0x1035628", VA = "0x1035628")]
			set
			{
			}
		}

		[Token(Token = "0x17000052")]
		public string SourceProjectPathFull
		{
			[Token(Token = "0x60007F9")]
			[Address(RVA = "0x1035650", Offset = "0x1035650", VA = "0x1035650")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000053")]
		public string SourceBankPathRelative
		{
			[Token(Token = "0x60007FA")]
			[Address(RVA = "0x10356E4", Offset = "0x10356E4", VA = "0x10356E4")]
			get
			{
				return null;
			}
			[Token(Token = "0x60007FB")]
			[Address(RVA = "0x10356EC", Offset = "0x10356EC", VA = "0x10356EC")]
			set
			{
			}
		}

		[Token(Token = "0x17000054")]
		public string SourceBankPathFull
		{
			[Token(Token = "0x60007FC")]
			[Address(RVA = "0x1035714", Offset = "0x1035714", VA = "0x1035714")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60007FD")]
		[Address(RVA = "0x10357A8", Offset = "0x10357A8", VA = "0x10357A8")]
		public static FMODPlatform GetParent(FMODPlatform platform)
		{
			return default(FMODPlatform);
		}

		[Token(Token = "0x60007FE")]
		public static bool HasSetting<T>(List<T> list, FMODPlatform platform) where T : PlatformSettingBase
		{
			return default(bool);
		}

		[Token(Token = "0x60007FF")]
		public static U GetSetting<T, U>(List<T> list, FMODPlatform platform, U def) where T : PlatformSetting<U>
		{
			return (U)null;
		}

		[Token(Token = "0x6000800")]
		public static void SetSetting<T, U>(List<T> list, FMODPlatform platform, U value) where T : PlatformSetting<U>, new()
		{
		}

		[Token(Token = "0x6000801")]
		public static void RemoveSetting<T>(List<T> list, FMODPlatform platform) where T : PlatformSettingBase
		{
		}

		[Token(Token = "0x6000802")]
		[Address(RVA = "0x103089C", Offset = "0x103089C", VA = "0x103089C")]
		public bool IsLiveUpdateEnabled(FMODPlatform platform)
		{
			return default(bool);
		}

		[Token(Token = "0x6000803")]
		[Address(RVA = "0x10321CC", Offset = "0x10321CC", VA = "0x10321CC")]
		public bool IsOverlayEnabled(FMODPlatform platform)
		{
			return default(bool);
		}

		[Token(Token = "0x6000804")]
		[Address(RVA = "0x1030688", Offset = "0x1030688", VA = "0x1030688")]
		public int GetRealChannels(FMODPlatform platform)
		{
			return default(int);
		}

		[Token(Token = "0x6000805")]
		[Address(RVA = "0x1030710", Offset = "0x1030710", VA = "0x1030710")]
		public int GetVirtualChannels(FMODPlatform platform)
		{
			return default(int);
		}

		[Token(Token = "0x6000806")]
		[Address(RVA = "0x1030798", Offset = "0x1030798", VA = "0x1030798")]
		public int GetSpeakerMode(FMODPlatform platform)
		{
			return default(int);
		}

		[Token(Token = "0x6000807")]
		[Address(RVA = "0x1030600", Offset = "0x1030600", VA = "0x1030600")]
		public int GetSampleRate(FMODPlatform platform)
		{
			return default(int);
		}

		[Token(Token = "0x6000808")]
		[Address(RVA = "0x10357FC", Offset = "0x10357FC", VA = "0x10357FC")]
		public string GetBankPlatform(FMODPlatform platform)
		{
			return null;
		}

		[Token(Token = "0x6000809")]
		[Address(RVA = "0x10358A8", Offset = "0x10358A8", VA = "0x10358A8")]
		private Settings()
		{
		}

		[Token(Token = "0x600080A")]
		[Address(RVA = "0x1035BBC", Offset = "0x1035BBC", VA = "0x1035BBC")]
		private void OnEnable()
		{
		}
	}
	[Token(Token = "0x2000129")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x8F22B0", Offset = "0x8F22B0")]
	public class StudioBankLoader : MonoBehaviour
	{
		[Token(Token = "0x4000666")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public LoaderGameEvent LoadEvent;

		[Token(Token = "0x4000667")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public LoaderGameEvent UnloadEvent;

		[Token(Token = "0x4000668")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[BankRef]
		public List<string> Banks;

		[Token(Token = "0x4000669")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string CollisionTag;

		[Token(Token = "0x400066A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool PreloadSamples;

		[Token(Token = "0x400066B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
		private bool isQuitting;

		[Token(Token = "0x600080C")]
		[Address(RVA = "0x1035DA8", Offset = "0x1035DA8", VA = "0x1035DA8")]
		private void HandleGameEvent(LoaderGameEvent gameEvent)
		{
		}

		[Token(Token = "0x600080D")]
		[Address(RVA = "0x103616C", Offset = "0x103616C", VA = "0x103616C")]
		private void Start()
		{
		}

		[Token(Token = "0x600080E")]
		[Address(RVA = "0x1036194", Offset = "0x1036194", VA = "0x1036194")]
		private void OnApplicationQuit()
		{
		}

		[Token(Token = "0x600080F")]
		[Address(RVA = "0x10361A0", Offset = "0x10361A0", VA = "0x10361A0")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000810")]
		[Address(RVA = "0x10361B4", Offset = "0x10361B4", VA = "0x10361B4")]
		private void OnTriggerEnter(Collider other)
		{
		}

		[Token(Token = "0x6000811")]
		[Address(RVA = "0x1036228", Offset = "0x1036228", VA = "0x1036228")]
		private void OnTriggerExit(Collider other)
		{
		}

		[Token(Token = "0x6000812")]
		[Address(RVA = "0x103629C", Offset = "0x103629C", VA = "0x103629C")]
		private void OnTriggerEnter2D(Collider2D other)
		{
		}

		[Token(Token = "0x6000813")]
		[Address(RVA = "0x1036310", Offset = "0x1036310", VA = "0x1036310")]
		private void OnTriggerExit2D(Collider2D other)
		{
		}

		[Token(Token = "0x6000814")]
		[Address(RVA = "0x1035DF8", Offset = "0x1035DF8", VA = "0x1035DF8")]
		public void Load()
		{
		}

		[Token(Token = "0x6000815")]
		[Address(RVA = "0x1036034", Offset = "0x1036034", VA = "0x1036034")]
		public void Unload()
		{
		}

		[Token(Token = "0x6000816")]
		[Address(RVA = "0x1036384", Offset = "0x1036384", VA = "0x1036384")]
		public StudioBankLoader()
		{
		}
	}
	[Token(Token = "0x200012A")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x8F22E8", Offset = "0x8F22E8")]
	public class StudioEventEmitter : EventHandler
	{
		[Token(Token = "0x400066C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[EventRef]
		public string Event;

		[Token(Token = "0x400066D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public EmitterGameEvent PlayEvent;

		[Token(Token = "0x400066E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public EmitterGameEvent StopEvent;

		[Token(Token = "0x400066F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool AllowFadeout;

		[Token(Token = "0x4000670")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
		public bool TriggerOnce;

		[Token(Token = "0x4000671")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x32")]
		public bool Preload;

		[Token(Token = "0x4000672")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public ParamRef[] Params;

		[Token(Token = "0x4000673")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public bool OverrideAttenuation;

		[Token(Token = "0x4000674")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float OverrideMinDistance;

		[Token(Token = "0x4000675")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float OverrideMaxDistance;

		[Token(Token = "0x4000676")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		protected EventDescription eventDescription;

		[Token(Token = "0x4000677")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		protected EventInstance instance;

		[Token(Token = "0x4000678")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private bool hasTriggered;

		[Token(Token = "0x4000679")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x61")]
		private bool isQuitting;

		[Token(Token = "0x400067A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x62")]
		private bool isOneshot;

		[Token(Token = "0x400067B")]
		private const string SnapshotString = "snapshot";

		[Token(Token = "0x17000055")]
		public EventDescription EventDescription
		{
			[Token(Token = "0x6000817")]
			[Address(RVA = "0x103638C", Offset = "0x103638C", VA = "0x103638C")]
			get
			{
				return default(EventDescription);
			}
		}

		[Token(Token = "0x17000056")]
		public EventInstance EventInstance
		{
			[Token(Token = "0x6000818")]
			[Address(RVA = "0x1036394", Offset = "0x1036394", VA = "0x1036394")]
			get
			{
				return default(EventInstance);
			}
		}

		[Token(Token = "0x6000819")]
		[Address(RVA = "0x103639C", Offset = "0x103639C", VA = "0x103639C")]
		private void Start()
		{
		}

		[Token(Token = "0x600081A")]
		[Address(RVA = "0x10365F8", Offset = "0x10365F8", VA = "0x10365F8")]
		private void OnApplicationQuit()
		{
		}

		[Token(Token = "0x600081B")]
		[Address(RVA = "0x1036604", Offset = "0x1036604", VA = "0x1036604")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600081C")]
		[Address(RVA = "0x10366F8", Offset = "0x10366F8", VA = "0x10366F8", Slot = "4")]
		protected override void HandleGameEvent(EmitterGameEvent gameEvent)
		{
		}

		[Token(Token = "0x600081D")]
		[Address(RVA = "0x1036484", Offset = "0x1036484", VA = "0x1036484")]
		private void Lookup()
		{
		}

		[Token(Token = "0x600081E")]
		[Address(RVA = "0x1036748", Offset = "0x1036748", VA = "0x1036748")]
		public void Play()
		{
		}

		[Token(Token = "0x600081F")]
		[Address(RVA = "0x1036AB4", Offset = "0x1036AB4", VA = "0x1036AB4")]
		public void Stop()
		{
		}

		[Token(Token = "0x6000820")]
		[Address(RVA = "0x1036B1C", Offset = "0x1036B1C", VA = "0x1036B1C")]
		public void SetParameter(string name, float value, bool ignoreseekspeed = false)
		{
		}

		[Token(Token = "0x6000821")]
		[Address(RVA = "0x1036B8C", Offset = "0x1036B8C", VA = "0x1036B8C")]
		public void SetParameter(PARAMETER_ID id, float value, bool ignoreseekspeed = false)
		{
		}

		[Token(Token = "0x6000822")]
		[Address(RVA = "0x1036BFC", Offset = "0x1036BFC", VA = "0x1036BFC")]
		public bool IsPlaying()
		{
			return default(bool);
		}

		[Token(Token = "0x6000823")]
		[Address(RVA = "0x1036C68", Offset = "0x1036C68", VA = "0x1036C68")]
		public StudioEventEmitter()
		{
		}
	}
	[Token(Token = "0x200012B")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x8F2320", Offset = "0x8F2320")]
	public class StudioGlobalParameterTrigger : EventHandler
	{
		[Token(Token = "0x400067C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[ParamRef]
		public string parameter;

		[Token(Token = "0x400067D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public EmitterGameEvent TriggerEvent;

		[Token(Token = "0x400067E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float value;

		[Token(Token = "0x400067F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private PARAMETER_DESCRIPTION parameterDescription;

		[Token(Token = "0x17000057")]
		public PARAMETER_DESCRIPTION ParameterDesctription
		{
			[Token(Token = "0x6000824")]
			[Address(RVA = "0x1036CE8", Offset = "0x1036CE8", VA = "0x1036CE8")]
			get
			{
				return default(PARAMETER_DESCRIPTION);
			}
		}

		[Token(Token = "0x6000825")]
		[Address(RVA = "0x1036D04", Offset = "0x1036D04", VA = "0x1036D04")]
		private RESULT Lookup()
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000826")]
		[Address(RVA = "0x1036D8C", Offset = "0x1036D8C", VA = "0x1036D8C")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000827")]
		[Address(RVA = "0x1036DD0", Offset = "0x1036DD0", VA = "0x1036DD0", Slot = "4")]
		protected override void HandleGameEvent(EmitterGameEvent gameEvent)
		{
		}

		[Token(Token = "0x6000828")]
		[Address(RVA = "0x1036DE4", Offset = "0x1036DE4", VA = "0x1036DE4")]
		public void TriggerParameters()
		{
		}

		[Token(Token = "0x6000829")]
		[Address(RVA = "0x1036EF8", Offset = "0x1036EF8", VA = "0x1036EF8")]
		public StudioGlobalParameterTrigger()
		{
		}
	}
	[Token(Token = "0x200012C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x8F2358", Offset = "0x8F2358")]
	public class StudioListener : MonoBehaviour
	{
		[Token(Token = "0x4000680")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Rigidbody rigidBody;

		[Token(Token = "0x4000681")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Rigidbody2D rigidBody2D;

		[Token(Token = "0x4000682")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public int ListenerNumber;

		[Token(Token = "0x600082A")]
		[Address(RVA = "0x1036EFC", Offset = "0x1036EFC", VA = "0x1036EFC")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600082B")]
		[Address(RVA = "0x1036FCC", Offset = "0x1036FCC", VA = "0x1036FCC")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600082C")]
		[Address(RVA = "0x1037030", Offset = "0x1037030", VA = "0x1037030")]
		private void Update()
		{
		}

		[Token(Token = "0x600082D")]
		[Address(RVA = "0x1037044", Offset = "0x1037044", VA = "0x1037044")]
		private void SetListenerLocation()
		{
		}

		[Token(Token = "0x600082E")]
		[Address(RVA = "0x1037140", Offset = "0x1037140", VA = "0x1037140")]
		public StudioListener()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200012D")]
	public class EmitterRef
	{
		[Token(Token = "0x4000683")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public StudioEventEmitter Target;

		[Token(Token = "0x4000684")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public ParamRef[] Params;

		[Token(Token = "0x600082F")]
		[Address(RVA = "0x102E4A4", Offset = "0x102E4A4", VA = "0x102E4A4")]
		public EmitterRef()
		{
		}
	}
	[Token(Token = "0x200012E")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x8F2390", Offset = "0x8F2390")]
	public class StudioParameterTrigger : EventHandler
	{
		[Token(Token = "0x4000685")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public EmitterRef[] Emitters;

		[Token(Token = "0x4000686")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public EmitterGameEvent TriggerEvent;

		[Token(Token = "0x6000830")]
		[Address(RVA = "0x1037150", Offset = "0x1037150", VA = "0x1037150")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000831")]
		[Address(RVA = "0x10373E8", Offset = "0x10373E8", VA = "0x10373E8", Slot = "4")]
		protected override void HandleGameEvent(EmitterGameEvent gameEvent)
		{
		}

		[Token(Token = "0x6000832")]
		[Address(RVA = "0x10373FC", Offset = "0x10373FC", VA = "0x10373FC")]
		public void TriggerParameters()
		{
		}

		[Token(Token = "0x6000833")]
		[Address(RVA = "0x10376CC", Offset = "0x10376CC", VA = "0x10376CC")]
		public StudioParameterTrigger()
		{
		}
	}
}
