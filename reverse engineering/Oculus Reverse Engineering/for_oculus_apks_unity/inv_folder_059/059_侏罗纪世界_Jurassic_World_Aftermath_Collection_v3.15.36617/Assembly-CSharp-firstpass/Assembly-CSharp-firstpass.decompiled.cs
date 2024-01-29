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
using Unity.Collections;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Animations;
using UnityEngine.Events;
using UnityEngine.Networking;
using UnityEngine.Playables;
using UnityEngine.Timeline;

[assembly: AssemblyVersion("0.0.0.0")]
[Token(Token = "0x2000002")]
public static class FmodResonanceAudio
{
	[Token(Token = "0x2000185")]
	private struct RoomProperties
	{
		[Token(Token = "0x400094E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float positionX;

		[Token(Token = "0x400094F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public float positionY;

		[Token(Token = "0x4000950")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public float positionZ;

		[Token(Token = "0x4000951")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public float rotationX;

		[Token(Token = "0x4000952")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float rotationY;

		[Token(Token = "0x4000953")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public float rotationZ;

		[Token(Token = "0x4000954")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float rotationW;

		[Token(Token = "0x4000955")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float dimensionsX;

		[Token(Token = "0x4000956")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float dimensionsY;

		[Token(Token = "0x4000957")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float dimensionsZ;

		[Token(Token = "0x4000958")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public FmodResonanceAudioRoom.SurfaceMaterial materialLeft;

		[Token(Token = "0x4000959")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public FmodResonanceAudioRoom.SurfaceMaterial materialRight;

		[Token(Token = "0x400095A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public FmodResonanceAudioRoom.SurfaceMaterial materialBottom;

		[Token(Token = "0x400095B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public FmodResonanceAudioRoom.SurfaceMaterial materialTop;

		[Token(Token = "0x400095C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public FmodResonanceAudioRoom.SurfaceMaterial materialFront;

		[Token(Token = "0x400095D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public FmodResonanceAudioRoom.SurfaceMaterial materialBack;

		[Token(Token = "0x400095E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float reflectionScalar;

		[Token(Token = "0x400095F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float reverbGain;

		[Token(Token = "0x4000960")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float reverbTime;

		[Token(Token = "0x4000961")]
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
		[Address(RVA = "0x23FDB8C", Offset = "0x23FDB8C", VA = "0x23FDB8C")]
		get
		{
			return default(DSP);
		}
	}

	[Token(Token = "0x6000001")]
	[Address(RVA = "0x23FD734", Offset = "0x23FD734", VA = "0x23FD734")]
	public static void UpdateAudioRoom(FmodResonanceAudioRoom room, bool roomEnabled)
	{
	}

	[Token(Token = "0x6000002")]
	[Address(RVA = "0x23FDD20", Offset = "0x23FDD20", VA = "0x23FDD20")]
	public static bool IsListenerInsideRoom(FmodResonanceAudioRoom room)
	{
		return default(bool);
	}

	[Token(Token = "0x6000004")]
	[Address(RVA = "0x23FE34C", Offset = "0x23FE34C", VA = "0x23FE34C")]
	private static float ConvertAmplitudeFromDb(float db)
	{
		return default(float);
	}

	[Token(Token = "0x6000005")]
	[Address(RVA = "0x23FE3C4", Offset = "0x23FE3C4", VA = "0x23FE3C4")]
	private static void ConvertAudioTransformFromUnity(ref Vector3 position, ref Quaternion rotation)
	{
	}

	[Token(Token = "0x6000006")]
	[Address(RVA = "0x23FDC50", Offset = "0x23FDC50", VA = "0x23FDC50")]
	private static byte[] GetBytes(IntPtr ptr, int length)
	{
		return null;
	}

	[Token(Token = "0x6000007")]
	[Address(RVA = "0x23FD9C0", Offset = "0x23FD9C0", VA = "0x23FD9C0")]
	private static RoomProperties GetRoomProperties(FmodResonanceAudioRoom room)
	{
		return default(RoomProperties);
	}

	[Token(Token = "0x6000008")]
	[Address(RVA = "0x23FDF88", Offset = "0x23FDF88", VA = "0x23FDF88")]
	private static DSP Initialize()
	{
		return default(DSP);
	}
}
[Token(Token = "0x2000003")]
[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x14CF070", Offset = "0x14CF070")]
public class FmodResonanceAudioRoom : MonoBehaviour
{
	[Token(Token = "0x2000186")]
	public enum SurfaceMaterial
	{
		[Token(Token = "0x4000963")]
		Transparent,
		[Token(Token = "0x4000964")]
		AcousticCeilingTiles,
		[Token(Token = "0x4000965")]
		BrickBare,
		[Token(Token = "0x4000966")]
		BrickPainted,
		[Token(Token = "0x4000967")]
		ConcreteBlockCoarse,
		[Token(Token = "0x4000968")]
		ConcreteBlockPainted,
		[Token(Token = "0x4000969")]
		CurtainHeavy,
		[Token(Token = "0x400096A")]
		FiberglassInsulation,
		[Token(Token = "0x400096B")]
		GlassThin,
		[Token(Token = "0x400096C")]
		GlassThick,
		[Token(Token = "0x400096D")]
		Grass,
		[Token(Token = "0x400096E")]
		LinoleumOnConcrete,
		[Token(Token = "0x400096F")]
		Marble,
		[Token(Token = "0x4000970")]
		Metal,
		[Token(Token = "0x4000971")]
		ParquetOnConcrete,
		[Token(Token = "0x4000972")]
		PlasterRough,
		[Token(Token = "0x4000973")]
		PlasterSmooth,
		[Token(Token = "0x4000974")]
		PlywoodPanel,
		[Token(Token = "0x4000975")]
		PolishedConcreteOrTile,
		[Token(Token = "0x4000976")]
		Sheetrock,
		[Token(Token = "0x4000977")]
		WaterOrIceSurface,
		[Token(Token = "0x4000978")]
		WoodCeiling,
		[Token(Token = "0x4000979")]
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
	[Address(RVA = "0x23FE8C4", Offset = "0x23FE8C4", VA = "0x23FE8C4")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x600000B")]
	[Address(RVA = "0x23FE934", Offset = "0x23FE934", VA = "0x23FE934")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x600000C")]
	[Address(RVA = "0x23FE99C", Offset = "0x23FE99C", VA = "0x23FE99C")]
	private void Update()
	{
	}

	[Token(Token = "0x600000D")]
	[Address(RVA = "0x23FEA0C", Offset = "0x23FEA0C", VA = "0x23FEA0C")]
	private void OnDrawGizmosSelected()
	{
	}

	[Token(Token = "0x600000E")]
	[Address(RVA = "0x23FEAD8", Offset = "0x23FEAD8", VA = "0x23FEAD8")]
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
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x14CFFA8", Offset = "0x14CFFA8")]
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
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	[SerializeField]
	public bool keepAlive;

	[Token(Token = "0x4000021")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[SerializeField]
	public ParamRef[] parameters;

	[NonSerialized]
	[Token(Token = "0x4000022")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public bool cachedParameters;

	[Token(Token = "0x4000023")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x14D0020", Offset = "0x14D0020")]
	private TimelineClip <OwningClip>k__BackingField;

	[Token(Token = "0x17000002")]
	public GameObject TrackTargetObject
	{
		[Token(Token = "0x600000F")]
		[Address(RVA = "0x23F40D4", Offset = "0x23F40D4", VA = "0x23F40D4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x14D777C", Offset = "0x14D777C")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000010")]
		[Address(RVA = "0x23F40DC", Offset = "0x23F40DC", VA = "0x23F40DC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x14D778C", Offset = "0x14D778C")]
		set
		{
		}
	}

	[Token(Token = "0x17000003")]
	public override double duration
	{
		[Token(Token = "0x6000011")]
		[Address(RVA = "0x23F40E4", Offset = "0x23F40E4", VA = "0x23F40E4", Slot = "7")]
		get
		{
			return default(double);
		}
	}

	[Token(Token = "0x17000004")]
	public ClipCaps clipCaps
	{
		[Token(Token = "0x6000012")]
		[Address(RVA = "0x23F4100", Offset = "0x23F4100", VA = "0x23F4100", Slot = "9")]
		get
		{
			return default(ClipCaps);
		}
	}

	[Token(Token = "0x17000005")]
	public TimelineClip OwningClip
	{
		[Token(Token = "0x6000013")]
		[Address(RVA = "0x23F4108", Offset = "0x23F4108", VA = "0x23F4108")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x14D779C", Offset = "0x14D779C")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000014")]
		[Address(RVA = "0x23F4110", Offset = "0x23F4110", VA = "0x23F4110")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x14D77AC", Offset = "0x14D77AC")]
		set
		{
		}
	}

	[Token(Token = "0x6000015")]
	[Address(RVA = "0x23F4118", Offset = "0x23F4118", VA = "0x23F4118", Slot = "6")]
	public override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
	{
		return default(Playable);
	}

	[Token(Token = "0x6000016")]
	[Address(RVA = "0x23F43AC", Offset = "0x23F43AC", VA = "0x23F43AC")]
	public FMODEventPlayable()
	{
	}
}
[Token(Token = "0x2000005")]
public enum STOP_MODE
{
	[Token(Token = "0x4000025")]
	AllowFadeout,
	[Token(Token = "0x4000026")]
	Immediate,
	[Token(Token = "0x4000027")]
	None
}
[Token(Token = "0x2000006")]
public class FMODEventPlayableBehavior : PlayableBehaviour
{
	[Token(Token = "0x4000028")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public bool keepAlive;

	[Token(Token = "0x4000029")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public string eventName;

	[Token(Token = "0x400002A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public STOP_MODE stopType;

	[Token(Token = "0x400002B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public ParamRef[] parameters;

	[Token(Token = "0x400002C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public GameObject TrackTargetObject;

	[Token(Token = "0x400002D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public TimelineClip OwningClip;

	[Token(Token = "0x400002E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private bool isPlayheadInside;

	[Token(Token = "0x400002F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private EventInstance eventInstance;

	[Token(Token = "0x6000017")]
	[Address(RVA = "0x23F4488", Offset = "0x23F4488", VA = "0x23F4488")]
	protected void PlayEvent()
	{
	}

	[Token(Token = "0x6000018")]
	[Address(RVA = "0x23F4C3C", Offset = "0x23F4C3C", VA = "0x23F4C3C")]
	public void OnEnter()
	{
	}

	[Token(Token = "0x6000019")]
	[Address(RVA = "0x23F4C70", Offset = "0x23F4C70", VA = "0x23F4C70")]
	public void OnExit()
	{
	}

	[Token(Token = "0x600001A")]
	[Address(RVA = "0x23F4044", Offset = "0x23F4044", VA = "0x23F4044")]
	public void UpdateBehaviour(float time)
	{
	}

	[Token(Token = "0x600001B")]
	[Address(RVA = "0x23F4CCC", Offset = "0x23F4CCC", VA = "0x23F4CCC", Slot = "14")]
	public override void OnGraphStop(Playable playable)
	{
	}

	[Token(Token = "0x600001C")]
	[Address(RVA = "0x23F4428", Offset = "0x23F4428", VA = "0x23F4428")]
	public FMODEventPlayableBehavior()
	{
	}
}
[Token(Token = "0x2000007")]
[AttributeAttribute(Name = "TrackColorAttribute", RVA = "0x14CF0A8", Offset = "0x14CF0A8")]
[AttributeAttribute(Name = "TrackClipTypeAttribute", RVA = "0x14CF0A8", Offset = "0x14CF0A8")]
[AttributeAttribute(Name = "TrackBindingTypeAttribute", RVA = "0x14CF0A8", Offset = "0x14CF0A8")]
public class FMODEventTrack : TrackAsset
{
	[Token(Token = "0x600001D")]
	[Address(RVA = "0x23F4D7C", Offset = "0x23F4D7C", VA = "0x23F4D7C", Slot = "24")]
	public override Playable CreateTrackMixer(PlayableGraph graph, GameObject go, int inputCount)
	{
		return default(Playable);
	}

	[Token(Token = "0x600001E")]
	[Address(RVA = "0x23F5150", Offset = "0x23F5150", VA = "0x23F5150")]
	public FMODEventTrack()
	{
	}
}
[Token(Token = "0x2000008")]
public class FMODEventMixerBehaviour : PlayableBehaviour
{
	[Token(Token = "0x600001F")]
	[Address(RVA = "0x23F3ED0", Offset = "0x23F3ED0", VA = "0x23F3ED0", Slot = "20")]
	public override void ProcessFrame(Playable playable, FrameData info, object playerData)
	{
	}

	[Token(Token = "0x6000020")]
	[Address(RVA = "0x23F40CC", Offset = "0x23F40CC", VA = "0x23F40CC")]
	public FMODEventMixerBehaviour()
	{
	}
}
namespace RootMotion
{
	[Token(Token = "0x2000009")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x14CF15C", Offset = "0x14CF15C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x14CF15C", Offset = "0x14CF15C")]
	public abstract class Baker : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000187")]
		public enum Mode
		{
			[Token(Token = "0x400097B")]
			AnimationClips,
			[Token(Token = "0x400097C")]
			AnimationStates,
			[Token(Token = "0x400097D")]
			PlayableDirector,
			[Token(Token = "0x400097E")]
			Realtime
		}

		[Token(Token = "0x4000030")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D0030", Offset = "0x14D0030")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x14D0030", Offset = "0x14D0030")]
		public int frameRate;

		[Token(Token = "0x4000031")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D0088", Offset = "0x14D0088")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x14D0088", Offset = "0x14D0088")]
		public float keyReductionError;

		[Token(Token = "0x4000032")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D00E0", Offset = "0x14D00E0")]
		public Mode mode;

		[Token(Token = "0x4000033")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D0118", Offset = "0x14D0118")]
		public AnimationClip[] animationClips;

		[Token(Token = "0x4000034")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D0150", Offset = "0x14D0150")]
		public string[] animationStates;

		[Token(Token = "0x4000035")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D0188", Offset = "0x14D0188")]
		public bool loop;

		[Token(Token = "0x4000036")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D01C0", Offset = "0x14D01C0")]
		public string saveToFolder;

		[Token(Token = "0x4000037")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D01F8", Offset = "0x14D01F8")]
		public string appendName;

		[Token(Token = "0x4000038")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D0230", Offset = "0x14D0230")]
		public string saveName;

		[Token(Token = "0x4000039")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x14D0268", Offset = "0x14D0268")]
		private bool <isBaking>k__BackingField;

		[Token(Token = "0x400003A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x14D0278", Offset = "0x14D0278")]
		private float <bakingProgress>k__BackingField;

		[Token(Token = "0x400003B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		[HideInInspector]
		public Animator animator;

		[Token(Token = "0x400003C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		[HideInInspector]
		public PlayableDirector director;

		[Token(Token = "0x400003D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x14D02F8", Offset = "0x14D02F8")]
		private float <clipLength>k__BackingField;

		[Token(Token = "0x17000006")]
		public bool isBaking
		{
			[Token(Token = "0x6000025")]
			[Address(RVA = "0x23FFCB8", Offset = "0x23FFCB8", VA = "0x23FFCB8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x14D789C", Offset = "0x14D789C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000026")]
			[Address(RVA = "0x23FFCC0", Offset = "0x23FFCC0", VA = "0x23FFCC0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x14D78AC", Offset = "0x14D78AC")]
			private set
			{
			}
		}

		[Token(Token = "0x17000007")]
		public float bakingProgress
		{
			[Token(Token = "0x6000027")]
			[Address(RVA = "0x23FFCCC", Offset = "0x23FFCCC", VA = "0x23FFCCC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x14D78BC", Offset = "0x14D78BC")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000028")]
			[Address(RVA = "0x23FFCD4", Offset = "0x23FFCD4", VA = "0x23FFCD4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x14D78CC", Offset = "0x14D78CC")]
			private set
			{
			}
		}

		[Token(Token = "0x17000008")]
		protected float clipLength
		{
			[Token(Token = "0x600002E")]
			[Address(RVA = "0x23FFCDC", Offset = "0x23FFCDC", VA = "0x23FFCDC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x14D78DC", Offset = "0x14D78DC")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600002F")]
			[Address(RVA = "0x23FFCE4", Offset = "0x23FFCE4", VA = "0x23FFCE4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x14D78EC", Offset = "0x14D78EC")]
			private set
			{
			}
		}

		[Token(Token = "0x6000021")]
		[Address(RVA = "0x23FFB88", Offset = "0x23FFB88", VA = "0x23FFB88")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x14D77BC", Offset = "0x14D77BC")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x6000022")]
		[Address(RVA = "0x23FFBD4", Offset = "0x23FFBD4", VA = "0x23FFBD4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x14D77F4", Offset = "0x14D77F4")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000023")]
		[Address(RVA = "0x23FFC20", Offset = "0x23FFC20", VA = "0x23FFC20")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x14D782C", Offset = "0x14D782C")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000024")]
		[Address(RVA = "0x23FFC6C", Offset = "0x23FFC6C", VA = "0x23FFC6C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x14D7864", Offset = "0x14D7864")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000029")]
		protected abstract Transform GetCharacterRoot();

		[Token(Token = "0x600002A")]
		protected abstract void OnStartBaking();

		[Token(Token = "0x600002B")]
		protected abstract void OnSetLoopFrame(float time);

		[Token(Token = "0x600002C")]
		protected abstract void OnSetCurves(ref AnimationClip clip);

		[Token(Token = "0x600002D")]
		protected abstract void OnSetKeyframes(float time, bool lastFrame);

		[Token(Token = "0x6000030")]
		[Address(RVA = "0x23FFCEC", Offset = "0x23FFCEC", VA = "0x23FFCEC")]
		public void BakeClip()
		{
		}

		[Token(Token = "0x6000031")]
		[Address(RVA = "0x23FFCF0", Offset = "0x23FFCF0", VA = "0x23FFCF0")]
		public void StartBaking()
		{
		}

		[Token(Token = "0x6000032")]
		[Address(RVA = "0x23FFCF4", Offset = "0x23FFCF4", VA = "0x23FFCF4")]
		public void StopBaking()
		{
		}

		[Token(Token = "0x6000033")]
		[Address(RVA = "0x23FFCF8", Offset = "0x23FFCF8", VA = "0x23FFCF8")]
		protected Baker()
		{
		}
	}
	[Token(Token = "0x200000A")]
	public class GenericBaker : Baker
	{
		[Token(Token = "0x400003E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D0308", Offset = "0x14D0308")]
		public bool markAsLegacy;

		[Token(Token = "0x400003F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D0340", Offset = "0x14D0340")]
		public Transform root;

		[Token(Token = "0x4000040")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D0378", Offset = "0x14D0378")]
		public Transform rootNode;

		[Token(Token = "0x4000041")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D03B0", Offset = "0x14D03B0")]
		public Transform[] ignoreList;

		[Token(Token = "0x4000042")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D03E8", Offset = "0x14D03E8")]
		public Transform[] bakePositionList;

		[Token(Token = "0x4000043")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private BakerTransform[] children;

		[Token(Token = "0x4000044")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private BakerTransform rootChild;

		[Token(Token = "0x4000045")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private int rootChildIndex;

		[Token(Token = "0x6000034")]
		[Address(RVA = "0x29979C8", Offset = "0x29979C8", VA = "0x29979C8")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000035")]
		[Address(RVA = "0x2997D94", Offset = "0x2997D94", VA = "0x2997D94", Slot = "4")]
		protected override Transform GetCharacterRoot()
		{
			return null;
		}

		[Token(Token = "0x6000036")]
		[Address(RVA = "0x2997D9C", Offset = "0x2997D9C", VA = "0x2997D9C", Slot = "5")]
		protected override void OnStartBaking()
		{
		}

		[Token(Token = "0x6000037")]
		[Address(RVA = "0x2997EAC", Offset = "0x2997EAC", VA = "0x2997EAC", Slot = "6")]
		protected override void OnSetLoopFrame(float time)
		{
		}

		[Token(Token = "0x6000038")]
		[Address(RVA = "0x2997F28", Offset = "0x2997F28", VA = "0x2997F28", Slot = "7")]
		protected override void OnSetCurves(ref AnimationClip clip)
		{
		}

		[Token(Token = "0x6000039")]
		[Address(RVA = "0x2997FA4", Offset = "0x2997FA4", VA = "0x2997FA4", Slot = "8")]
		protected override void OnSetKeyframes(float time, bool lastFrame)
		{
		}

		[Token(Token = "0x600003A")]
		[Address(RVA = "0x2997BE4", Offset = "0x2997BE4", VA = "0x2997BE4")]
		private bool IsIgnored(Transform t)
		{
			return default(bool);
		}

		[Token(Token = "0x600003B")]
		[Address(RVA = "0x2997CBC", Offset = "0x2997CBC", VA = "0x2997CBC")]
		private bool BakePosition(Transform t)
		{
			return default(bool);
		}

		[Token(Token = "0x600003C")]
		[Address(RVA = "0x2998020", Offset = "0x2998020", VA = "0x2998020")]
		public GenericBaker()
		{
		}
	}
	[Token(Token = "0x200000B")]
	public class TQ
	{
		[Token(Token = "0x4000046")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Vector3 t;

		[Token(Token = "0x4000047")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Quaternion q;

		[Token(Token = "0x600003D")]
		[Address(RVA = "0x299C520", Offset = "0x299C520", VA = "0x299C520")]
		public TQ(Vector3 translation, Quaternion rotation)
		{
		}
	}
	[Token(Token = "0x200000C")]
	public class AvatarUtility
	{
		[Token(Token = "0x600003E")]
		[Address(RVA = "0x23FEB70", Offset = "0x23FEB70", VA = "0x23FEB70")]
		public static Quaternion GetPostRotation(Avatar avatar, AvatarIKGoal avatarIKGoal)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600003F")]
		[Address(RVA = "0x23FED84", Offset = "0x23FED84", VA = "0x23FED84")]
		public static TQ GetIKGoalTQ(Avatar avatar, float humanScale, AvatarIKGoal avatarIKGoal, TQ bodyPositionRotation, TQ boneTQ)
		{
			return null;
		}

		[Token(Token = "0x6000040")]
		[Address(RVA = "0x23FED64", Offset = "0x23FED64", VA = "0x23FED64")]
		public static HumanBodyBones HumanIDFromAvatarIKGoal(AvatarIKGoal avatarIKGoal)
		{
			return default(HumanBodyBones);
		}

		[Token(Token = "0x6000041")]
		[Address(RVA = "0x23FF404", Offset = "0x23FF404", VA = "0x23FF404")]
		public AvatarUtility()
		{
		}
	}
	[Token(Token = "0x200000D")]
	public static class BakerUtilities
	{
		[Token(Token = "0x6000042")]
		[Address(RVA = "0x2400E3C", Offset = "0x2400E3C", VA = "0x2400E3C")]
		public static void ReduceKeyframes(AnimationCurve curve, float maxError)
		{
		}

		[Token(Token = "0x6000043")]
		[Address(RVA = "0x2402310", Offset = "0x2402310", VA = "0x2402310")]
		public static Keyframe[] GetReducedKeyframes(AnimationCurve curve, float maxError)
		{
			return null;
		}

		[Token(Token = "0x6000044")]
		[Address(RVA = "0x2400850", Offset = "0x2400850", VA = "0x2400850")]
		public static void SetLoopFrame(float time, AnimationCurve curve)
		{
		}

		[Token(Token = "0x6000045")]
		[Address(RVA = "0x2400E84", Offset = "0x2400E84", VA = "0x2400E84")]
		public static void SetTangentMode(AnimationCurve curve)
		{
		}

		[Token(Token = "0x6000046")]
		[Address(RVA = "0x2400388", Offset = "0x2400388", VA = "0x2400388")]
		public static Quaternion EnsureQuaternionContinuity(Quaternion lastQ, Quaternion q)
		{
			return default(Quaternion);
		}
	}
	[Serializable]
	[Token(Token = "0x200000E")]
	public class BakerHumanoidQT
	{
		[Token(Token = "0x4000048")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private Transform transform;

		[Token(Token = "0x4000049")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private string Qx;

		[Token(Token = "0x400004A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private string Qy;

		[Token(Token = "0x400004B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private string Qz;

		[Token(Token = "0x400004C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private string Qw;

		[Token(Token = "0x400004D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private string Tx;

		[Token(Token = "0x400004E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private string Ty;

		[Token(Token = "0x400004F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private string Tz;

		[Token(Token = "0x4000050")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public AnimationCurve rotX;

		[Token(Token = "0x4000051")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public AnimationCurve rotY;

		[Token(Token = "0x4000052")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public AnimationCurve rotZ;

		[Token(Token = "0x4000053")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public AnimationCurve rotW;

		[Token(Token = "0x4000054")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public AnimationCurve posX;

		[Token(Token = "0x4000055")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public AnimationCurve posY;

		[Token(Token = "0x4000056")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public AnimationCurve posZ;

		[Token(Token = "0x4000057")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private AvatarIKGoal goal;

		[Token(Token = "0x4000058")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private Quaternion lastQ;

		[Token(Token = "0x4000059")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private bool lastQSet;

		[Token(Token = "0x6000047")]
		[Address(RVA = "0x23FFDB8", Offset = "0x23FFDB8", VA = "0x23FFDB8")]
		public BakerHumanoidQT(string name)
		{
		}

		[Token(Token = "0x6000048")]
		[Address(RVA = "0x2400004", Offset = "0x2400004", VA = "0x2400004")]
		public BakerHumanoidQT(Transform transform, AvatarIKGoal goal, string name)
		{
		}

		[Token(Token = "0x6000049")]
		[Address(RVA = "0x23FFED8", Offset = "0x23FFED8", VA = "0x23FFED8")]
		public void Reset()
		{
		}

		[Token(Token = "0x600004A")]
		[Address(RVA = "0x240013C", Offset = "0x240013C", VA = "0x240013C")]
		public void SetIKKeyframes(float time, Avatar avatar, float humanScale, Vector3 bodyPosition, Quaternion bodyRotation)
		{
		}

		[Token(Token = "0x600004B")]
		[Address(RVA = "0x24005E4", Offset = "0x24005E4", VA = "0x24005E4")]
		public void SetKeyframes(float time, Vector3 pos, Quaternion rot)
		{
		}

		[Token(Token = "0x600004C")]
		[Address(RVA = "0x24006E0", Offset = "0x24006E0", VA = "0x24006E0")]
		public void MoveLastKeyframes(float time)
		{
		}

		[Token(Token = "0x600004D")]
		[Address(RVA = "0x24007DC", Offset = "0x24007DC", VA = "0x24007DC")]
		public void SetLoopFrame(float time)
		{
		}

		[Token(Token = "0x600004E")]
		[Address(RVA = "0x2400754", Offset = "0x2400754", VA = "0x2400754")]
		private void MoveLastKeyframe(float time, AnimationCurve curve)
		{
		}

		[Token(Token = "0x600004F")]
		[Address(RVA = "0x2400A9C", Offset = "0x2400A9C", VA = "0x2400A9C")]
		public void MultiplyLength(AnimationCurve curve, float mlp)
		{
		}

		[Token(Token = "0x6000050")]
		[Address(RVA = "0x2400B50", Offset = "0x2400B50", VA = "0x2400B50")]
		public void SetCurves(ref AnimationClip clip, float maxError, float lengthMlp)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200000F")]
	public class BakerMuscle
	{
		[Token(Token = "0x400005A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public AnimationCurve curve;

		[Token(Token = "0x400005B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private int muscleIndex;

		[Token(Token = "0x400005C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private string propertyName;

		[Token(Token = "0x6000051")]
		[Address(RVA = "0x2400E88", Offset = "0x2400E88", VA = "0x2400E88")]
		public BakerMuscle(int muscleIndex)
		{
		}

		[Token(Token = "0x6000052")]
		[Address(RVA = "0x2400EF8", Offset = "0x2400EF8", VA = "0x2400EF8")]
		private string MuscleNameToPropertyName(string n)
		{
			return null;
		}

		[Token(Token = "0x6000053")]
		[Address(RVA = "0x24015E0", Offset = "0x24015E0", VA = "0x24015E0")]
		public void MultiplyLength(AnimationCurve curve, float mlp)
		{
		}

		[Token(Token = "0x6000054")]
		[Address(RVA = "0x2401694", Offset = "0x2401694", VA = "0x2401694")]
		public void SetCurves(ref AnimationClip clip, float maxError, float lengthMlp)
		{
		}

		[Token(Token = "0x6000055")]
		[Address(RVA = "0x2401580", Offset = "0x2401580", VA = "0x2401580")]
		public void Reset()
		{
		}

		[Token(Token = "0x6000056")]
		[Address(RVA = "0x2401778", Offset = "0x2401778", VA = "0x2401778")]
		public void SetKeyframe(float time, float[] muscles)
		{
		}

		[Token(Token = "0x6000057")]
		[Address(RVA = "0x24017C0", Offset = "0x24017C0", VA = "0x24017C0")]
		public void SetLoopFrame(float time)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000010")]
	public class BakerTransform
	{
		[Token(Token = "0x400005D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform transform;

		[Token(Token = "0x400005E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AnimationCurve posX;

		[Token(Token = "0x400005F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public AnimationCurve posY;

		[Token(Token = "0x4000060")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public AnimationCurve posZ;

		[Token(Token = "0x4000061")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public AnimationCurve rotX;

		[Token(Token = "0x4000062")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public AnimationCurve rotY;

		[Token(Token = "0x4000063")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public AnimationCurve rotZ;

		[Token(Token = "0x4000064")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public AnimationCurve rotW;

		[Token(Token = "0x4000065")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private string relativePath;

		[Token(Token = "0x4000066")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private bool recordPosition;

		[Token(Token = "0x4000067")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private Vector3 relativePosition;

		[Token(Token = "0x4000068")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private bool isRootNode;

		[Token(Token = "0x4000069")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private Quaternion relativeRotation;

		[Token(Token = "0x6000058")]
		[Address(RVA = "0x24017C8", Offset = "0x24017C8", VA = "0x24017C8")]
		public BakerTransform(Transform transform, Transform root, bool recordPosition, bool isRootNode)
		{
		}

		[Token(Token = "0x6000059")]
		[Address(RVA = "0x240195C", Offset = "0x240195C", VA = "0x240195C")]
		public void SetRelativeSpace(Vector3 position, Quaternion rotation)
		{
		}

		[Token(Token = "0x600005A")]
		[Address(RVA = "0x2401970", Offset = "0x2401970", VA = "0x2401970")]
		public void SetCurves(ref AnimationClip clip)
		{
		}

		[Token(Token = "0x600005B")]
		[Address(RVA = "0x2401C00", Offset = "0x2401C00", VA = "0x2401C00")]
		private void AddRootMotionCurves(ref AnimationClip clip)
		{
		}

		[Token(Token = "0x600005C")]
		[Address(RVA = "0x2401864", Offset = "0x2401864", VA = "0x2401864")]
		public void Reset()
		{
		}

		[Token(Token = "0x600005D")]
		[Address(RVA = "0x2401E4C", Offset = "0x2401E4C", VA = "0x2401E4C")]
		public void ReduceKeyframes(float maxError)
		{
		}

		[Token(Token = "0x600005E")]
		[Address(RVA = "0x2401EC0", Offset = "0x2401EC0", VA = "0x2401EC0")]
		public void SetKeyframes(float time)
		{
		}

		[Token(Token = "0x600005F")]
		[Address(RVA = "0x240210C", Offset = "0x240210C", VA = "0x240210C")]
		public void AddLoopFrame(float time)
		{
		}
	}
	[Token(Token = "0x2000011")]
	public class HumanoidBaker : Baker
	{
		[Token(Token = "0x400006A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D0420", Offset = "0x14D0420")]
		public bool bakeHandIK;

		[Token(Token = "0x400006B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D0458", Offset = "0x14D0458")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x14D0458", Offset = "0x14D0458")]
		public float IKKeyReductionError;

		[Token(Token = "0x400006C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D04B0", Offset = "0x14D04B0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x14D04B0", Offset = "0x14D04B0")]
		public int muscleFrameRateDiv;

		[Token(Token = "0x400006D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private BakerMuscle[] bakerMuscles;

		[Token(Token = "0x400006E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private BakerHumanoidQT rootQT;

		[Token(Token = "0x400006F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private BakerHumanoidQT leftFootQT;

		[Token(Token = "0x4000070")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private BakerHumanoidQT rightFootQT;

		[Token(Token = "0x4000071")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private BakerHumanoidQT leftHandQT;

		[Token(Token = "0x4000072")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private BakerHumanoidQT rightHandQT;

		[Token(Token = "0x4000073")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private float[] muscles;

		[Token(Token = "0x4000074")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private HumanPose pose;

		[Token(Token = "0x4000075")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private HumanPoseHandler handler;

		[Token(Token = "0x4000076")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private Vector3 bodyPosition;

		[Token(Token = "0x4000077")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
		private Quaternion bodyRotation;

		[Token(Token = "0x4000078")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
		private int mN;

		[Token(Token = "0x4000079")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private Quaternion lastBodyRotation;

		[Token(Token = "0x6000060")]
		[Address(RVA = "0x2998F58", Offset = "0x2998F58", VA = "0x2998F58")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000061")]
		[Address(RVA = "0x2999384", Offset = "0x2999384", VA = "0x2999384", Slot = "4")]
		protected override Transform GetCharacterRoot()
		{
			return null;
		}

		[Token(Token = "0x6000062")]
		[Address(RVA = "0x29993A0", Offset = "0x29993A0", VA = "0x29993A0", Slot = "5")]
		protected override void OnStartBaking()
		{
		}

		[Token(Token = "0x6000063")]
		[Address(RVA = "0x29994C0", Offset = "0x29994C0", VA = "0x29994C0", Slot = "6")]
		protected override void OnSetLoopFrame(float time)
		{
		}

		[Token(Token = "0x6000064")]
		[Address(RVA = "0x299959C", Offset = "0x299959C", VA = "0x299959C", Slot = "7")]
		protected override void OnSetCurves(ref AnimationClip clip)
		{
		}

		[Token(Token = "0x6000065")]
		[Address(RVA = "0x299976C", Offset = "0x299976C", VA = "0x299976C", Slot = "8")]
		protected override void OnSetKeyframes(float time, bool lastFrame)
		{
		}

		[Token(Token = "0x6000066")]
		[Address(RVA = "0x2999A94", Offset = "0x2999A94", VA = "0x2999A94")]
		private void UpdateHumanPose()
		{
		}

		[Token(Token = "0x6000067")]
		[Address(RVA = "0x2999B70", Offset = "0x2999B70", VA = "0x2999B70")]
		public HumanoidBaker()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000012")]
	public enum Axis
	{
		[Token(Token = "0x400007B")]
		X,
		[Token(Token = "0x400007C")]
		Y,
		[Token(Token = "0x400007D")]
		Z
	}
	[Token(Token = "0x2000013")]
	public class AxisTools
	{
		[Token(Token = "0x6000068")]
		[Address(RVA = "0x23FF40C", Offset = "0x23FF40C", VA = "0x23FF40C")]
		public static Vector3 ToVector3(Axis axis)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000069")]
		[Address(RVA = "0x23FF4C4", Offset = "0x23FF4C4", VA = "0x23FF4C4")]
		public static Axis ToAxis(Vector3 v)
		{
			return default(Axis);
		}

		[Token(Token = "0x600006A")]
		[Address(RVA = "0x23FF570", Offset = "0x23FF570", VA = "0x23FF570")]
		public static Axis GetAxisToPoint(Transform t, Vector3 worldPosition)
		{
			return default(Axis);
		}

		[Token(Token = "0x600006B")]
		[Address(RVA = "0x23FF754", Offset = "0x23FF754", VA = "0x23FF754")]
		public static Axis GetAxisToDirection(Transform t, Vector3 direction)
		{
			return default(Axis);
		}

		[Token(Token = "0x600006C")]
		[Address(RVA = "0x23FF68C", Offset = "0x23FF68C", VA = "0x23FF68C")]
		public static Vector3 GetAxisVectorToPoint(Transform t, Vector3 worldPosition)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600006D")]
		[Address(RVA = "0x23FF870", Offset = "0x23FF870", VA = "0x23FF870")]
		public static Vector3 GetAxisVectorToDirection(Transform t, Vector3 direction)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600006E")]
		[Address(RVA = "0x23FF8B8", Offset = "0x23FF8B8", VA = "0x23FF8B8")]
		public static Vector3 GetAxisVectorToDirection(Quaternion r, Vector3 direction)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600006F")]
		[Address(RVA = "0x23FFB80", Offset = "0x23FFB80", VA = "0x23FFB80")]
		public AxisTools()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000014")]
	public class BipedLimbOrientations
	{
		[Serializable]
		[Token(Token = "0x2000188")]
		public class LimbOrientation
		{
			[Token(Token = "0x400097F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Vector3 upperBoneForwardAxis;

			[Token(Token = "0x4000980")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public Vector3 lowerBoneForwardAxis;

			[Token(Token = "0x4000981")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Vector3 lastBoneLeftAxis;

			[Token(Token = "0x6000BAB")]
			[Address(RVA = "0x24029B8", Offset = "0x24029B8", VA = "0x24029B8")]
			public LimbOrientation(Vector3 upperBoneForwardAxis, Vector3 lowerBoneForwardAxis, Vector3 lastBoneLeftAxis)
			{
			}
		}

		[Token(Token = "0x400007E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public LimbOrientation leftArm;

		[Token(Token = "0x400007F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public LimbOrientation rightArm;

		[Token(Token = "0x4000080")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public LimbOrientation leftLeg;

		[Token(Token = "0x4000081")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public LimbOrientation rightLeg;

		[Token(Token = "0x17000009")]
		public static BipedLimbOrientations UMA
		{
			[Token(Token = "0x6000071")]
			[Address(RVA = "0x2402744", Offset = "0x2402744", VA = "0x2402744")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700000A")]
		public static BipedLimbOrientations MaxBiped
		{
			[Token(Token = "0x6000072")]
			[Address(RVA = "0x2402A30", Offset = "0x2402A30", VA = "0x2402A30")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000070")]
		[Address(RVA = "0x24026F8", Offset = "0x24026F8", VA = "0x24026F8")]
		public BipedLimbOrientations(LimbOrientation leftArm, LimbOrientation rightArm, LimbOrientation leftLeg, LimbOrientation rightLeg)
		{
		}
	}
	[Token(Token = "0x2000015")]
	public static class BipedNaming
	{
		[Serializable]
		[Token(Token = "0x2000189")]
		public enum BoneType
		{
			[Token(Token = "0x4000983")]
			Unassigned,
			[Token(Token = "0x4000984")]
			Spine,
			[Token(Token = "0x4000985")]
			Head,
			[Token(Token = "0x4000986")]
			Arm,
			[Token(Token = "0x4000987")]
			Leg,
			[Token(Token = "0x4000988")]
			Tail,
			[Token(Token = "0x4000989")]
			Eye
		}

		[Serializable]
		[Token(Token = "0x200018A")]
		public enum BoneSide
		{
			[Token(Token = "0x400098B")]
			Center,
			[Token(Token = "0x400098C")]
			Left,
			[Token(Token = "0x400098D")]
			Right
		}

		[Token(Token = "0x4000082")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static string[] typeLeft;

		[Token(Token = "0x4000083")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static string[] typeRight;

		[Token(Token = "0x4000084")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static string[] typeSpine;

		[Token(Token = "0x4000085")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public static string[] typeHead;

		[Token(Token = "0x4000086")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public static string[] typeArm;

		[Token(Token = "0x4000087")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public static string[] typeLeg;

		[Token(Token = "0x4000088")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public static string[] typeTail;

		[Token(Token = "0x4000089")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public static string[] typeEye;

		[Token(Token = "0x400008A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public static string[] typeExclude;

		[Token(Token = "0x400008B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public static string[] typeExcludeSpine;

		[Token(Token = "0x400008C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public static string[] typeExcludeHead;

		[Token(Token = "0x400008D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public static string[] typeExcludeArm;

		[Token(Token = "0x400008E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public static string[] typeExcludeLeg;

		[Token(Token = "0x400008F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public static string[] typeExcludeTail;

		[Token(Token = "0x4000090")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public static string[] typeExcludeEye;

		[Token(Token = "0x4000091")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public static string[] pelvis;

		[Token(Token = "0x4000092")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public static string[] hand;

		[Token(Token = "0x4000093")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public static string[] foot;

		[Token(Token = "0x6000073")]
		[Address(RVA = "0x2402CA4", Offset = "0x2402CA4", VA = "0x2402CA4")]
		public static Transform[] GetBonesOfType(BoneType boneType, Transform[] bones)
		{
			return null;
		}

		[Token(Token = "0x6000074")]
		[Address(RVA = "0x2402FA4", Offset = "0x2402FA4", VA = "0x2402FA4")]
		public static Transform[] GetBonesOfSide(BoneSide boneSide, Transform[] bones)
		{
			return null;
		}

		[Token(Token = "0x6000075")]
		[Address(RVA = "0x24031F4", Offset = "0x24031F4", VA = "0x24031F4")]
		public static Transform[] GetBonesOfTypeAndSide(BoneType boneType, BoneSide boneSide, Transform[] bones)
		{
			return null;
		}

		[Token(Token = "0x6000076")]
		[Address(RVA = "0x2403278", Offset = "0x2403278", VA = "0x2403278")]
		public static Transform GetFirstBoneOfTypeAndSide(BoneType boneType, BoneSide boneSide, Transform[] bones)
		{
			return null;
		}

		[Token(Token = "0x6000077")]
		[Address(RVA = "0x2403324", Offset = "0x2403324", VA = "0x2403324")]
		public static Transform GetNamingMatch(Transform[] transforms, params string[][] namings)
		{
			return null;
		}

		[Token(Token = "0x6000078")]
		[Address(RVA = "0x2402E54", Offset = "0x2402E54", VA = "0x2402E54")]
		public static BoneType GetBoneType(string boneName)
		{
			return default(BoneType);
		}

		[Token(Token = "0x6000079")]
		[Address(RVA = "0x2403154", Offset = "0x2403154", VA = "0x2403154")]
		public static BoneSide GetBoneSide(string boneName)
		{
			return default(BoneSide);
		}

		[Token(Token = "0x600007A")]
		[Address(RVA = "0x2403B64", Offset = "0x2403B64", VA = "0x2403B64")]
		public static Transform GetBone(Transform[] transforms, BoneType boneType, BoneSide boneSide = BoneSide.Center, params string[][] namings)
		{
			return null;
		}

		[Token(Token = "0x600007B")]
		[Address(RVA = "0x240397C", Offset = "0x240397C", VA = "0x240397C")]
		private static bool isLeft(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x600007C")]
		[Address(RVA = "0x2403A70", Offset = "0x2403A70", VA = "0x2403A70")]
		private static bool isRight(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x600007D")]
		[Address(RVA = "0x2403544", Offset = "0x2403544", VA = "0x2403544")]
		private static bool isSpine(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x600007E")]
		[Address(RVA = "0x24035F8", Offset = "0x24035F8", VA = "0x24035F8")]
		private static bool isHead(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x600007F")]
		[Address(RVA = "0x24036AC", Offset = "0x24036AC", VA = "0x24036AC")]
		private static bool isArm(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000080")]
		[Address(RVA = "0x2403760", Offset = "0x2403760", VA = "0x2403760")]
		private static bool isLeg(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000081")]
		[Address(RVA = "0x2403814", Offset = "0x2403814", VA = "0x2403814")]
		private static bool isTail(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000082")]
		[Address(RVA = "0x24038C8", Offset = "0x24038C8", VA = "0x24038C8")]
		private static bool isEye(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000083")]
		[Address(RVA = "0x2403D78", Offset = "0x2403D78", VA = "0x2403D78")]
		private static bool isTypeExclude(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000084")]
		[Address(RVA = "0x2403458", Offset = "0x2403458", VA = "0x2403458")]
		private static bool matchesNaming(string boneName, string[] namingConvention)
		{
			return default(bool);
		}

		[Token(Token = "0x6000085")]
		[Address(RVA = "0x2403CE8", Offset = "0x2403CE8", VA = "0x2403CE8")]
		private static bool excludesNaming(string boneName, string[] namingConvention)
		{
			return default(bool);
		}

		[Token(Token = "0x6000086")]
		[Address(RVA = "0x2403DE8", Offset = "0x2403DE8", VA = "0x2403DE8")]
		private static bool matchesLastLetter(string boneName, string[] namingConvention)
		{
			return default(bool);
		}

		[Token(Token = "0x6000087")]
		[Address(RVA = "0x2403EC0", Offset = "0x2403EC0", VA = "0x2403EC0")]
		private static bool LastLetterIs(string boneName, string letter)
		{
			return default(bool);
		}

		[Token(Token = "0x6000088")]
		[Address(RVA = "0x2403C6C", Offset = "0x2403C6C", VA = "0x2403C6C")]
		private static string firstLetter(string boneName)
		{
			return null;
		}

		[Token(Token = "0x6000089")]
		[Address(RVA = "0x2403BF4", Offset = "0x2403BF4", VA = "0x2403BF4")]
		private static string lastLetter(string boneName)
		{
			return null;
		}
	}
	[Serializable]
	[Token(Token = "0x2000016")]
	public class BipedReferences
	{
		[Token(Token = "0x200018B")]
		public struct AutoDetectParams
		{
			[Token(Token = "0x400098E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public bool legsParentInSpine;

			[Token(Token = "0x400098F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1")]
			public bool includeEyes;

			[Token(Token = "0x1700007A")]
			public static AutoDetectParams Default
			{
				[Token(Token = "0x6000BAD")]
				[Address(RVA = "0x2B12450", Offset = "0x2B12450", VA = "0x2B12450")]
				get
				{
					return default(AutoDetectParams);
				}
			}

			[Token(Token = "0x6000BAC")]
			[Address(RVA = "0x2B1243C", Offset = "0x2B1243C", VA = "0x2B1243C")]
			public AutoDetectParams(bool legsParentInSpine, bool includeEyes)
			{
			}
		}

		[Token(Token = "0x4000094")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform root;

		[Token(Token = "0x4000095")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform pelvis;

		[Token(Token = "0x4000096")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform leftThigh;

		[Token(Token = "0x4000097")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform leftCalf;

		[Token(Token = "0x4000098")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Transform leftFoot;

		[Token(Token = "0x4000099")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Transform rightThigh;

		[Token(Token = "0x400009A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Transform rightCalf;

		[Token(Token = "0x400009B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Transform rightFoot;

		[Token(Token = "0x400009C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Transform leftUpperArm;

		[Token(Token = "0x400009D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform leftForearm;

		[Token(Token = "0x400009E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Transform leftHand;

		[Token(Token = "0x400009F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Transform rightUpperArm;

		[Token(Token = "0x40000A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Transform rightForearm;

		[Token(Token = "0x40000A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Transform rightHand;

		[Token(Token = "0x40000A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public Transform head;

		[Token(Token = "0x40000A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public Transform[] spine;

		[Token(Token = "0x40000A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public Transform[] eyes;

		[Token(Token = "0x1700000B")]
		public virtual bool isFilled
		{
			[Token(Token = "0x600008B")]
			[Address(RVA = "0x2B0F024", Offset = "0x2B0F024", VA = "0x2B0F024", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700000C")]
		public bool isEmpty
		{
			[Token(Token = "0x600008C")]
			[Address(RVA = "0x2B0F410", Offset = "0x2B0F410", VA = "0x2B0F410")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600008D")]
		[Address(RVA = "0x2B0F420", Offset = "0x2B0F420", VA = "0x2B0F420", Slot = "5")]
		public virtual bool IsEmpty(bool includeRoot)
		{
			return default(bool);
		}

		[Token(Token = "0x600008E")]
		[Address(RVA = "0x2B0F84C", Offset = "0x2B0F84C", VA = "0x2B0F84C", Slot = "6")]
		public virtual bool Contains(Transform t, bool ignoreRoot = false)
		{
			return default(bool);
		}

		[Token(Token = "0x600008F")]
		[Address(RVA = "0x2B0FC84", Offset = "0x2B0FC84", VA = "0x2B0FC84")]
		public static bool AutoDetectReferences(ref BipedReferences references, Transform root, AutoDetectParams autoDetectParams)
		{
			return default(bool);
		}

		[Token(Token = "0x6000090")]
		[Address(RVA = "0x2B10294", Offset = "0x2B10294", VA = "0x2B10294")]
		public static void DetectReferencesByNaming(ref BipedReferences references, Transform root, AutoDetectParams autoDetectParams)
		{
		}

		[Token(Token = "0x6000091")]
		[Address(RVA = "0x2B0FED0", Offset = "0x2B0FED0", VA = "0x2B0FED0")]
		public static void AssignHumanoidReferences(ref BipedReferences references, Animator animator, AutoDetectParams autoDetectParams)
		{
		}

		[Token(Token = "0x6000092")]
		[Address(RVA = "0x2B10A50", Offset = "0x2B10A50", VA = "0x2B10A50")]
		public static bool SetupError(BipedReferences references, ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000093")]
		[Address(RVA = "0x2B10B44", Offset = "0x2B10B44", VA = "0x2B10B44")]
		public static bool SetupWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000094")]
		[Address(RVA = "0x2B110A0", Offset = "0x2B110A0", VA = "0x2B110A0")]
		private static bool IsNeckBone(Transform bone, Transform leftUpperArm)
		{
			return default(bool);
		}

		[Token(Token = "0x6000095")]
		[Address(RVA = "0x2B10EA4", Offset = "0x2B10EA4", VA = "0x2B10EA4")]
		private static bool AddBoneToEyes(Transform bone, ref BipedReferences references, AutoDetectParams autoDetectParams)
		{
			return default(bool);
		}

		[Token(Token = "0x6000096")]
		[Address(RVA = "0x2B10D1C", Offset = "0x2B10D1C", VA = "0x2B10D1C")]
		private static bool AddBoneToSpine(Transform bone, ref BipedReferences references, AutoDetectParams autoDetectParams)
		{
			return default(bool);
		}

		[Token(Token = "0x6000097")]
		[Address(RVA = "0x2B10BE4", Offset = "0x2B10BE4", VA = "0x2B10BE4")]
		private static void DetectLimb(BipedNaming.BoneType boneType, BipedNaming.BoneSide boneSide, ref Transform firstBone, ref Transform secondBone, ref Transform lastBone, Transform[] transforms)
		{
		}

		[Token(Token = "0x6000098")]
		[Address(RVA = "0x2B10FA8", Offset = "0x2B10FA8", VA = "0x2B10FA8")]
		private static void AddBoneToHierarchy(ref Transform[] bones, Transform transform)
		{
		}

		[Token(Token = "0x6000099")]
		[Address(RVA = "0x2B1119C", Offset = "0x2B1119C", VA = "0x2B1119C")]
		private static bool LimbError(Transform bone1, Transform bone2, Transform bone3, ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x600009A")]
		[Address(RVA = "0x2B11C3C", Offset = "0x2B11C3C", VA = "0x2B11C3C")]
		private static bool LimbWarning(Transform bone1, Transform bone2, Transform bone3, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x600009B")]
		[Address(RVA = "0x2B11720", Offset = "0x2B11720", VA = "0x2B11720")]
		private static bool SpineError(BipedReferences references, ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x600009C")]
		[Address(RVA = "0x2B11F30", Offset = "0x2B11F30", VA = "0x2B11F30")]
		private static bool SpineWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x600009D")]
		[Address(RVA = "0x2B11A60", Offset = "0x2B11A60", VA = "0x2B11A60")]
		private static bool EyesError(BipedReferences references, ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x600009E")]
		[Address(RVA = "0x2B11F38", Offset = "0x2B11F38", VA = "0x2B11F38")]
		private static bool EyesWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x600009F")]
		[Address(RVA = "0x2B11F40", Offset = "0x2B11F40", VA = "0x2B11F40")]
		private static bool RootHeightWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x60000A0")]
		[Address(RVA = "0x2B12100", Offset = "0x2B12100", VA = "0x2B12100")]
		private static bool FacingAxisWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x60000A1")]
		[Address(RVA = "0x2B12318", Offset = "0x2B12318", VA = "0x2B12318")]
		private static float GetVerticalOffset(Vector3 p1, Vector3 p2, Quaternion rotation)
		{
			return default(float);
		}

		[Token(Token = "0x60000A2")]
		[Address(RVA = "0x2B0FE60", Offset = "0x2B0FE60", VA = "0x2B0FE60")]
		public BipedReferences()
		{
		}
	}
	[Token(Token = "0x2000017")]
	public class Comments : MonoBehaviour
	{
		[Token(Token = "0x40000A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Multiline]
		public string text;

		[Token(Token = "0x60000A3")]
		[Address(RVA = "0x2B12458", Offset = "0x2B12458", VA = "0x2B12458")]
		public Comments()
		{
		}
	}
	[Token(Token = "0x2000018")]
	public class DemoGUIMessage : MonoBehaviour
	{
		[Token(Token = "0x40000A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string text;

		[Token(Token = "0x40000A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Color color;

		[Token(Token = "0x60000A4")]
		[Address(RVA = "0x2B12460", Offset = "0x2B12460", VA = "0x2B12460")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x60000A5")]
		[Address(RVA = "0x2B125A0", Offset = "0x2B125A0", VA = "0x2B125A0")]
		public DemoGUIMessage()
		{
		}
	}
	[Token(Token = "0x2000019")]
	public class Hierarchy
	{
		[Token(Token = "0x60000A6")]
		[Address(RVA = "0x2998088", Offset = "0x2998088", VA = "0x2998088")]
		public static bool HierarchyIsValid(Transform[] bones)
		{
			return default(bool);
		}

		[Token(Token = "0x60000A7")]
		[Address(RVA = "0x2998288", Offset = "0x2998288", VA = "0x2998288")]
		public static UnityEngine.Object ContainsDuplicate(UnityEngine.Object[] objects)
		{
			return null;
		}

		[Token(Token = "0x60000A8")]
		[Address(RVA = "0x2998120", Offset = "0x2998120", VA = "0x2998120")]
		public static bool IsAncestor(Transform transform, Transform ancestor)
		{
			return default(bool);
		}

		[Token(Token = "0x60000A9")]
		[Address(RVA = "0x29983AC", Offset = "0x29983AC", VA = "0x29983AC")]
		public static bool ContainsChild(Transform transform, Transform child)
		{
			return default(bool);
		}

		[Token(Token = "0x60000AA")]
		[Address(RVA = "0x29984D0", Offset = "0x29984D0", VA = "0x29984D0")]
		public static void AddAncestors(Transform transform, Transform blocker, ref Transform[] array)
		{
		}

		[Token(Token = "0x60000AB")]
		[Address(RVA = "0x2998778", Offset = "0x2998778", VA = "0x2998778")]
		public static Transform GetAncestor(Transform transform, int minChildCount)
		{
			return null;
		}

		[Token(Token = "0x60000AC")]
		[Address(RVA = "0x2998894", Offset = "0x2998894", VA = "0x2998894")]
		public static Transform GetFirstCommonAncestor(Transform t1, Transform t2)
		{
			return null;
		}

		[Token(Token = "0x60000AD")]
		[Address(RVA = "0x2998A1C", Offset = "0x2998A1C", VA = "0x2998A1C")]
		public static Transform GetFirstCommonAncestor(Transform[] transforms)
		{
			return null;
		}

		[Token(Token = "0x60000AE")]
		[Address(RVA = "0x2998DB0", Offset = "0x2998DB0", VA = "0x2998DB0")]
		public static Transform GetFirstCommonAncestorRecursive(Transform transform, Transform[] transforms)
		{
			return null;
		}

		[Token(Token = "0x60000AF")]
		[Address(RVA = "0x2998B9C", Offset = "0x2998B9C", VA = "0x2998B9C")]
		public static bool IsCommonAncestor(Transform transform, Transform[] transforms)
		{
			return default(bool);
		}

		[Token(Token = "0x60000B0")]
		[Address(RVA = "0x2998F50", Offset = "0x2998F50", VA = "0x2998F50")]
		public Hierarchy()
		{
		}
	}
	[Token(Token = "0x200001A")]
	public class InspectorComment : PropertyAttribute
	{
		[Token(Token = "0x40000A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string name;

		[Token(Token = "0x40000A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string color;

		[Token(Token = "0x60000B1")]
		[Address(RVA = "0x2999C24", Offset = "0x2999C24", VA = "0x2999C24")]
		public InspectorComment(string name)
		{
		}

		[Token(Token = "0x60000B2")]
		[Address(RVA = "0x2999C94", Offset = "0x2999C94", VA = "0x2999C94")]
		public InspectorComment(string name, string color)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200001B")]
	public enum InterpolationMode
	{
		[Token(Token = "0x40000AB")]
		None,
		[Token(Token = "0x40000AC")]
		InOutCubic,
		[Token(Token = "0x40000AD")]
		InOutQuintic,
		[Token(Token = "0x40000AE")]
		InOutSine,
		[Token(Token = "0x40000AF")]
		InQuintic,
		[Token(Token = "0x40000B0")]
		InQuartic,
		[Token(Token = "0x40000B1")]
		InCubic,
		[Token(Token = "0x40000B2")]
		InQuadratic,
		[Token(Token = "0x40000B3")]
		InElastic,
		[Token(Token = "0x40000B4")]
		InElasticSmall,
		[Token(Token = "0x40000B5")]
		InElasticBig,
		[Token(Token = "0x40000B6")]
		InSine,
		[Token(Token = "0x40000B7")]
		InBack,
		[Token(Token = "0x40000B8")]
		OutQuintic,
		[Token(Token = "0x40000B9")]
		OutQuartic,
		[Token(Token = "0x40000BA")]
		OutCubic,
		[Token(Token = "0x40000BB")]
		OutInCubic,
		[Token(Token = "0x40000BC")]
		OutInQuartic,
		[Token(Token = "0x40000BD")]
		OutElastic,
		[Token(Token = "0x40000BE")]
		OutElasticSmall,
		[Token(Token = "0x40000BF")]
		OutElasticBig,
		[Token(Token = "0x40000C0")]
		OutSine,
		[Token(Token = "0x40000C1")]
		OutBack,
		[Token(Token = "0x40000C2")]
		OutBackCubic,
		[Token(Token = "0x40000C3")]
		OutBackQuartic,
		[Token(Token = "0x40000C4")]
		BackInCubic,
		[Token(Token = "0x40000C5")]
		BackInQuartic
	}
	[Token(Token = "0x200001C")]
	public class Interp
	{
		[Token(Token = "0x60000B3")]
		[Address(RVA = "0x2999D04", Offset = "0x2999D04", VA = "0x2999D04")]
		public static float Float(float t, InterpolationMode mode)
		{
			return default(float);
		}

		[Token(Token = "0x60000B4")]
		[Address(RVA = "0x299A76C", Offset = "0x299A76C", VA = "0x299A76C")]
		public static Vector3 V3(Vector3 v1, Vector3 v2, float t, InterpolationMode mode)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000B5")]
		[Address(RVA = "0x299A874", Offset = "0x299A874", VA = "0x299A874")]
		public static float LerpValue(float value, float target, float increaseSpeed, float decreaseSpeed)
		{
			return default(float);
		}

		[Token(Token = "0x60000B6")]
		[Address(RVA = "0x299A070", Offset = "0x299A070", VA = "0x299A070")]
		private static float None(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000B7")]
		[Address(RVA = "0x299A07C", Offset = "0x299A07C", VA = "0x299A07C")]
		private static float InOutCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000B8")]
		[Address(RVA = "0x299A0A0", Offset = "0x299A0A0", VA = "0x299A0A0")]
		private static float InOutQuintic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000B9")]
		[Address(RVA = "0x299A0DC", Offset = "0x299A0DC", VA = "0x299A0DC")]
		private static float InQuintic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000BA")]
		[Address(RVA = "0x299A0F4", Offset = "0x299A0F4", VA = "0x299A0F4")]
		private static float InQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000BB")]
		[Address(RVA = "0x299A108", Offset = "0x299A108", VA = "0x299A108")]
		private static float InCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000BC")]
		[Address(RVA = "0x299A11C", Offset = "0x299A11C", VA = "0x299A11C")]
		private static float InQuadratic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000BD")]
		[Address(RVA = "0x299A12C", Offset = "0x299A12C", VA = "0x299A12C")]
		private static float OutQuintic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000BE")]
		[Address(RVA = "0x299A174", Offset = "0x299A174", VA = "0x299A174")]
		private static float OutQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000BF")]
		[Address(RVA = "0x299A1AC", Offset = "0x299A1AC", VA = "0x299A1AC")]
		private static float OutCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000C0")]
		[Address(RVA = "0x299A1D4", Offset = "0x299A1D4", VA = "0x299A1D4")]
		private static float OutInCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000C1")]
		[Address(RVA = "0x299A970", Offset = "0x299A970", VA = "0x299A970")]
		private static float OutInQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000C2")]
		[Address(RVA = "0x299A208", Offset = "0x299A208", VA = "0x299A208")]
		private static float BackInCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000C3")]
		[Address(RVA = "0x299A230", Offset = "0x299A230", VA = "0x299A230")]
		private static float BackInQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000C4")]
		[Address(RVA = "0x299A260", Offset = "0x299A260", VA = "0x299A260")]
		private static float OutBackCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000C5")]
		[Address(RVA = "0x299A294", Offset = "0x299A294", VA = "0x299A294")]
		private static float OutBackQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000C6")]
		[Address(RVA = "0x299A2D8", Offset = "0x299A2D8", VA = "0x299A2D8")]
		private static float OutElasticSmall(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000C7")]
		[Address(RVA = "0x299A33C", Offset = "0x299A33C", VA = "0x299A33C")]
		private static float OutElasticBig(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000C8")]
		[Address(RVA = "0x299A3A0", Offset = "0x299A3A0", VA = "0x299A3A0")]
		private static float InElasticSmall(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000C9")]
		[Address(RVA = "0x299A3F4", Offset = "0x299A3F4", VA = "0x299A3F4")]
		private static float InElasticBig(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000CA")]
		[Address(RVA = "0x299A448", Offset = "0x299A448", VA = "0x299A448")]
		private static float InSine(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000CB")]
		[Address(RVA = "0x299A4E0", Offset = "0x299A4E0", VA = "0x299A4E0")]
		private static float OutSine(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000CC")]
		[Address(RVA = "0x299A574", Offset = "0x299A574", VA = "0x299A574")]
		private static float InOutSine(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000CD")]
		[Address(RVA = "0x299A9A4", Offset = "0x299A9A4", VA = "0x299A9A4")]
		private static float InElastic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000CE")]
		[Address(RVA = "0x299A618", Offset = "0x299A618", VA = "0x299A618")]
		private static float OutElastic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000CF")]
		[Address(RVA = "0x299A6FC", Offset = "0x299A6FC", VA = "0x299A6FC")]
		private static float InBack(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000D0")]
		[Address(RVA = "0x299A72C", Offset = "0x299A72C", VA = "0x299A72C")]
		private static float OutBack(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000D1")]
		[Address(RVA = "0x299AA8C", Offset = "0x299AA8C", VA = "0x299AA8C")]
		public Interp()
		{
		}
	}
	[Token(Token = "0x200001D")]
	public class LargeHeader : PropertyAttribute
	{
		[Token(Token = "0x40000C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string name;

		[Token(Token = "0x40000C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string color;

		[Token(Token = "0x60000D2")]
		[Address(RVA = "0x299AA94", Offset = "0x299AA94", VA = "0x299AA94")]
		public LargeHeader(string name)
		{
		}

		[Token(Token = "0x60000D3")]
		[Address(RVA = "0x299AB04", Offset = "0x299AB04", VA = "0x299AB04")]
		public LargeHeader(string name, string color)
		{
		}
	}
	[Token(Token = "0x200001E")]
	public static class LayerMaskExtensions
	{
		[Token(Token = "0x60000D4")]
		[Address(RVA = "0x299AB74", Offset = "0x299AB74", VA = "0x299AB74")]
		public static bool Contains(LayerMask mask, int layer)
		{
			return default(bool);
		}

		[Token(Token = "0x60000D5")]
		[Address(RVA = "0x299ABCC", Offset = "0x299ABCC", VA = "0x299ABCC")]
		public static LayerMask Create(params string[] layerNames)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60000D6")]
		[Address(RVA = "0x299AC98", Offset = "0x299AC98", VA = "0x299AC98")]
		public static LayerMask Create(params int[] layerNumbers)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60000D7")]
		[Address(RVA = "0x299ABE4", Offset = "0x299ABE4", VA = "0x299ABE4")]
		public static LayerMask NamesToMask(params string[] layerNames)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60000D8")]
		[Address(RVA = "0x299ACB0", Offset = "0x299ACB0", VA = "0x299ACB0")]
		public static LayerMask LayerNumbersToMask(params int[] layerNumbers)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60000D9")]
		[Address(RVA = "0x299AD54", Offset = "0x299AD54", VA = "0x299AD54")]
		public static LayerMask Inverse(this LayerMask original)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60000DA")]
		[Address(RVA = "0x299AD80", Offset = "0x299AD80", VA = "0x299AD80")]
		public static LayerMask AddToMask(this LayerMask original, params string[] layerNames)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60000DB")]
		[Address(RVA = "0x299ADD0", Offset = "0x299ADD0", VA = "0x299ADD0")]
		public static LayerMask RemoveFromMask(this LayerMask original, params string[] layerNames)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60000DC")]
		[Address(RVA = "0x299AE3C", Offset = "0x299AE3C", VA = "0x299AE3C")]
		public static string[] MaskToNames(this LayerMask original)
		{
			return null;
		}

		[Token(Token = "0x60000DD")]
		[Address(RVA = "0x299AF30", Offset = "0x299AF30", VA = "0x299AF30")]
		public static int[] MaskToNumbers(this LayerMask original)
		{
			return null;
		}

		[Token(Token = "0x60000DE")]
		[Address(RVA = "0x299B008", Offset = "0x299B008", VA = "0x299B008")]
		public static string MaskToString(this LayerMask original)
		{
			return null;
		}

		[Token(Token = "0x60000DF")]
		[Address(RVA = "0x299B068", Offset = "0x299B068", VA = "0x299B068")]
		public static string MaskToString(this LayerMask original, string delimiter)
		{
			return null;
		}
	}
	[Token(Token = "0x200001F")]
	public static class QuaTools
	{
		[Token(Token = "0x60000E0")]
		[Address(RVA = "0x299B098", Offset = "0x299B098", VA = "0x299B098")]
		public static Quaternion Lerp(Quaternion fromRotation, Quaternion toRotation, float weight)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60000E1")]
		[Address(RVA = "0x299B1E4", Offset = "0x299B1E4", VA = "0x299B1E4")]
		public static Quaternion Slerp(Quaternion fromRotation, Quaternion toRotation, float weight)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60000E2")]
		[Address(RVA = "0x299B330", Offset = "0x299B330", VA = "0x299B330")]
		public static Quaternion LinearBlend(Quaternion q, float weight)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60000E3")]
		[Address(RVA = "0x299B444", Offset = "0x299B444", VA = "0x299B444")]
		public static Quaternion SphericalBlend(Quaternion q, float weight)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60000E4")]
		[Address(RVA = "0x299B558", Offset = "0x299B558", VA = "0x299B558")]
		public static Quaternion FromToAroundAxis(Vector3 fromDirection, Vector3 toDirection, Vector3 axis)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60000E5")]
		[Address(RVA = "0x299B6E4", Offset = "0x299B6E4", VA = "0x299B6E4")]
		public static Quaternion RotationToLocalSpace(Quaternion space, Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60000E6")]
		[Address(RVA = "0x298C194", Offset = "0x298C194", VA = "0x298C194")]
		public static Quaternion FromToRotation(Quaternion from, Quaternion to)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60000E7")]
		[Address(RVA = "0x299B7B4", Offset = "0x299B7B4", VA = "0x299B7B4")]
		public static Vector3 GetAxis(Vector3 v)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000E8")]
		[Address(RVA = "0x299BA38", Offset = "0x299BA38", VA = "0x299BA38")]
		public static Quaternion ClampRotation(Quaternion rotation, float clampWeight, int clampSmoothing)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60000E9")]
		[Address(RVA = "0x299BC4C", Offset = "0x299BC4C", VA = "0x299BC4C")]
		public static float ClampAngle(float angle, float clampWeight, int clampSmoothing)
		{
			return default(float);
		}

		[Token(Token = "0x60000EA")]
		[Address(RVA = "0x2995568", Offset = "0x2995568", VA = "0x2995568")]
		public static Quaternion MatchRotation(Quaternion targetRotation, Vector3 targetforwardAxis, Vector3 targetUpAxis, Vector3 forwardAxis, Vector3 upAxis)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60000EB")]
		[Address(RVA = "0x299BDCC", Offset = "0x299BDCC", VA = "0x299BDCC")]
		public static Vector3 ToBiPolar(Vector3 euler)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000EC")]
		[Address(RVA = "0x299BEDC", Offset = "0x299BEDC", VA = "0x299BEDC")]
		public static float ToBiPolar(float angle)
		{
			return default(float);
		}
	}
	[Token(Token = "0x2000020")]
	public abstract class Singleton<T> : MonoBehaviour where T : Singleton<T>
	{
		[Token(Token = "0x40000C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static T sInstance;

		[Token(Token = "0x1700000D")]
		public static T instance
		{
			[Token(Token = "0x60000ED")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60000EE")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x60000EF")]
		protected Singleton()
		{
		}
	}
	[Token(Token = "0x2000021")]
	public class SolverManager : MonoBehaviour
	{
		[Token(Token = "0x40000C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D0514", Offset = "0x14D0514")]
		public bool fixTransforms;

		[Token(Token = "0x40000CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Animator animator;

		[Token(Token = "0x40000CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Animation legacy;

		[Token(Token = "0x40000CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private bool updateFrame;

		[Token(Token = "0x40000CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
		private bool componentInitiated;

		[Token(Token = "0x40000CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x32")]
		private bool skipSolverUpdate;

		[Token(Token = "0x1700000E")]
		private bool animatePhysics
		{
			[Token(Token = "0x60000F7")]
			[Address(RVA = "0x299C070", Offset = "0x299C070", VA = "0x299C070")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700000F")]
		private bool isAnimated
		{
			[Token(Token = "0x60000FB")]
			[Address(RVA = "0x299C36C", Offset = "0x299C36C", VA = "0x299C36C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60000F1")]
		[Address(RVA = "0x299BF38", Offset = "0x299BF38", VA = "0x299BF38")]
		public void Disable()
		{
		}

		[Token(Token = "0x60000F2")]
		[Address(RVA = "0x299BFD0", Offset = "0x299BFD0", VA = "0x299BFD0", Slot = "4")]
		protected virtual void InitiateSolver()
		{
		}

		[Token(Token = "0x60000F3")]
		[Address(RVA = "0x299BFD4", Offset = "0x299BFD4", VA = "0x299BFD4", Slot = "5")]
		protected virtual void UpdateSolver()
		{
		}

		[Token(Token = "0x60000F4")]
		[Address(RVA = "0x299BFD8", Offset = "0x299BFD8", VA = "0x299BFD8", Slot = "6")]
		protected virtual void FixTransforms()
		{
		}

		[Token(Token = "0x60000F5")]
		[Address(RVA = "0x299BFDC", Offset = "0x299BFDC", VA = "0x299BFDC")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60000F6")]
		[Address(RVA = "0x299C06C", Offset = "0x299C06C", VA = "0x299C06C")]
		private void Start()
		{
		}

		[Token(Token = "0x60000F8")]
		[Address(RVA = "0x299C014", Offset = "0x299C014", VA = "0x299C014")]
		private void Initiate()
		{
		}

		[Token(Token = "0x60000F9")]
		[Address(RVA = "0x299C320", Offset = "0x299C320", VA = "0x299C320")]
		private void Update()
		{
		}

		[Token(Token = "0x60000FA")]
		[Address(RVA = "0x299C160", Offset = "0x299C160", VA = "0x299C160")]
		private void FindAnimatorRecursive(Transform t, bool findInChildren)
		{
		}

		[Token(Token = "0x60000FC")]
		[Address(RVA = "0x299C428", Offset = "0x299C428", VA = "0x299C428")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60000FD")]
		[Address(RVA = "0x299C484", Offset = "0x299C484", VA = "0x299C484")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60000FE")]
		[Address(RVA = "0x299C4E0", Offset = "0x299C4E0", VA = "0x299C4E0")]
		public void UpdateSolverExternal()
		{
		}

		[Token(Token = "0x60000FF")]
		[Address(RVA = "0x298A81C", Offset = "0x298A81C", VA = "0x298A81C")]
		public SolverManager()
		{
		}
	}
	[Token(Token = "0x2000022")]
	public class TriggerEventBroadcaster : MonoBehaviour
	{
		[Token(Token = "0x40000CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject target;

		[Token(Token = "0x6000100")]
		[Address(RVA = "0x299C590", Offset = "0x299C590", VA = "0x299C590")]
		private void OnTriggerEnter(Collider collider)
		{
		}

		[Token(Token = "0x6000101")]
		[Address(RVA = "0x299C648", Offset = "0x299C648", VA = "0x299C648")]
		private void OnTriggerStay(Collider collider)
		{
		}

		[Token(Token = "0x6000102")]
		[Address(RVA = "0x299C700", Offset = "0x299C700", VA = "0x299C700")]
		private void OnTriggerExit(Collider collider)
		{
		}

		[Token(Token = "0x6000103")]
		[Address(RVA = "0x299C7B8", Offset = "0x299C7B8", VA = "0x299C7B8")]
		public TriggerEventBroadcaster()
		{
		}
	}
	[Token(Token = "0x2000023")]
	public static class V3Tools
	{
		[Token(Token = "0x6000104")]
		[Address(RVA = "0x299C7C0", Offset = "0x299C7C0", VA = "0x299C7C0")]
		public static Vector3 Lerp(Vector3 fromVector, Vector3 toVector, float weight)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000105")]
		[Address(RVA = "0x299C8B8", Offset = "0x299C8B8", VA = "0x299C8B8")]
		public static Vector3 Slerp(Vector3 fromVector, Vector3 toVector, float weight)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000106")]
		[Address(RVA = "0x299C9B0", Offset = "0x299C9B0", VA = "0x299C9B0")]
		public static Vector3 ExtractVertical(Vector3 v, Vector3 verticalAxis, float weight)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000107")]
		[Address(RVA = "0x299CAA8", Offset = "0x299CAA8", VA = "0x299CAA8")]
		public static Vector3 ExtractHorizontal(Vector3 v, Vector3 normal, float weight)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000108")]
		[Address(RVA = "0x299CBA8", Offset = "0x299CBA8", VA = "0x299CBA8")]
		public static Vector3 ClampDirection(Vector3 direction, Vector3 normalDirection, float clampWeight, int clampSmoothing)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000109")]
		[Address(RVA = "0x299CDCC", Offset = "0x299CDCC", VA = "0x299CDCC")]
		public static Vector3 ClampDirection(Vector3 direction, Vector3 normalDirection, float clampWeight, int clampSmoothing, out bool changed)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600010A")]
		[Address(RVA = "0x299D008", Offset = "0x299D008", VA = "0x299D008")]
		public static Vector3 ClampDirection(Vector3 direction, Vector3 normalDirection, float clampWeight, int clampSmoothing, out float clampValue)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600010B")]
		[Address(RVA = "0x299D258", Offset = "0x299D258", VA = "0x299D258")]
		public static Vector3 LineToPlane(Vector3 origin, Vector3 direction, Vector3 planeNormal, Vector3 planePoint)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600010C")]
		[Address(RVA = "0x299D458", Offset = "0x299D458", VA = "0x299D458")]
		public static Vector3 PointToPlane(Vector3 point, Vector3 planePosition, Vector3 planeNormal)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600010D")]
		[Address(RVA = "0x299D634", Offset = "0x299D634", VA = "0x299D634")]
		public static Vector3 TransformPointUnscaled(Transform t, Vector3 point)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600010E")]
		[Address(RVA = "0x299D768", Offset = "0x299D768", VA = "0x299D768")]
		public static Vector3 InverseTransformPointUnscaled(Transform t, Vector3 point)
		{
			return default(Vector3);
		}
	}
	[Token(Token = "0x2000024")]
	public static class Warning
	{
		[Token(Token = "0x200018C")]
		public delegate void Logger(string message);

		[Token(Token = "0x40000D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static bool logged;

		[Token(Token = "0x600010F")]
		[Address(RVA = "0x299D8C0", Offset = "0x299D8C0", VA = "0x299D8C0")]
		public static void Log(string message, Logger logger, bool logInEditMode = false)
		{
		}

		[Token(Token = "0x6000110")]
		[Address(RVA = "0x2986B84", Offset = "0x2986B84", VA = "0x2986B84")]
		public static void Log(string message, Transform context, bool logInEditMode = false)
		{
		}
	}
}
namespace RootMotion.Demos
{
	[Serializable]
	[Token(Token = "0x2000025")]
	public class Navigator
	{
		[Token(Token = "0x200018D")]
		public enum State
		{
			[Token(Token = "0x4000991")]
			Idle,
			[Token(Token = "0x4000992")]
			Seeking,
			[Token(Token = "0x4000993")]
			OnPath
		}

		[Token(Token = "0x40000D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D054C", Offset = "0x14D054C")]
		public bool activeTargetSeeking;

		[Token(Token = "0x40000D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D0584", Offset = "0x14D0584")]
		public float cornerRadius;

		[Token(Token = "0x40000D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D05BC", Offset = "0x14D05BC")]
		public float recalculateOnPathDistance;

		[Token(Token = "0x40000D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D05F4", Offset = "0x14D05F4")]
		public float maxSampleDistance;

		[Token(Token = "0x40000D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D062C", Offset = "0x14D062C")]
		public float nextPathInterval;

		[Token(Token = "0x40000D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x14D0664", Offset = "0x14D0664")]
		private Vector3 <normalizedDeltaPosition>k__BackingField;

		[Token(Token = "0x40000D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x14D0674", Offset = "0x14D0674")]
		private State <state>k__BackingField;

		[Token(Token = "0x40000D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Transform transform;

		[Token(Token = "0x40000D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private int cornerIndex;

		[Token(Token = "0x40000DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Vector3[] corners;

		[Token(Token = "0x40000DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private NavMeshPath path;

		[Token(Token = "0x40000DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Vector3 lastTargetPosition;

		[Token(Token = "0x40000DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private bool initiated;

		[Token(Token = "0x40000DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private float nextPathTime;

		[Token(Token = "0x17000010")]
		public Vector3 normalizedDeltaPosition
		{
			[Token(Token = "0x6000111")]
			[Address(RVA = "0x2B125D4", Offset = "0x2B125D4", VA = "0x2B125D4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x14D796C", Offset = "0x14D796C")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000112")]
			[Address(RVA = "0x2B125E0", Offset = "0x2B125E0", VA = "0x2B125E0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x14D797C", Offset = "0x14D797C")]
			private set
			{
			}
		}

		[Token(Token = "0x17000011")]
		public State state
		{
			[Token(Token = "0x6000113")]
			[Address(RVA = "0x2B125EC", Offset = "0x2B125EC", VA = "0x2B125EC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x14D798C", Offset = "0x14D798C")]
			get
			{
				return default(State);
			}
			[Token(Token = "0x6000114")]
			[Address(RVA = "0x2B125F4", Offset = "0x2B125F4", VA = "0x2B125F4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x14D799C", Offset = "0x14D799C")]
			private set
			{
			}
		}

		[Token(Token = "0x6000115")]
		[Address(RVA = "0x2B125FC", Offset = "0x2B125FC", VA = "0x2B125FC")]
		public void Initiate(Transform transform)
		{
		}

		[Token(Token = "0x6000116")]
		[Address(RVA = "0x2B126D0", Offset = "0x2B126D0", VA = "0x2B126D0")]
		public void Update(Vector3 targetPosition)
		{
		}

		[Token(Token = "0x6000117")]
		[Address(RVA = "0x2B12C14", Offset = "0x2B12C14", VA = "0x2B12C14")]
		private void CalculatePath(Vector3 targetPosition)
		{
		}

		[Token(Token = "0x6000118")]
		[Address(RVA = "0x2B12C84", Offset = "0x2B12C84", VA = "0x2B12C84")]
		private bool Find(Vector3 targetPosition)
		{
			return default(bool);
		}

		[Token(Token = "0x6000119")]
		[Address(RVA = "0x2B12ADC", Offset = "0x2B12ADC", VA = "0x2B12ADC")]
		private void Stop()
		{
		}

		[Token(Token = "0x600011A")]
		[Address(RVA = "0x2B12B50", Offset = "0x2B12B50", VA = "0x2B12B50")]
		private float HorDistance(Vector3 p1, Vector3 p2)
		{
			return default(float);
		}

		[Token(Token = "0x600011B")]
		[Address(RVA = "0x2B12DCC", Offset = "0x2B12DCC", VA = "0x2B12DCC")]
		public void Visualize()
		{
		}

		[Token(Token = "0x600011C")]
		[Address(RVA = "0x2B12F7C", Offset = "0x2B12F7C", VA = "0x2B12F7C")]
		public Navigator()
		{
		}
	}
}
namespace RootMotion.FinalIK
{
	[Token(Token = "0x2000026")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x14CF1CC", Offset = "0x14CF1CC")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x14CF1CC", Offset = "0x14CF1CC")]
	public class BipedIK : SolverManager
	{
		[Token(Token = "0x40000DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public BipedReferences references;

		[Token(Token = "0x40000E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public BipedIKSolvers solvers;

		[Token(Token = "0x600011D")]
		[Address(RVA = "0x2B18B40", Offset = "0x2B18B40", VA = "0x2B18B40")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x14D79AC", Offset = "0x14D79AC")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x600011E")]
		[Address(RVA = "0x2B18B8C", Offset = "0x2B18B8C", VA = "0x2B18B8C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x14D79E4", Offset = "0x14D79E4")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x600011F")]
		[Address(RVA = "0x2B18BD8", Offset = "0x2B18BD8", VA = "0x2B18BD8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x14D7A1C", Offset = "0x14D7A1C")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000120")]
		[Address(RVA = "0x2B18C24", Offset = "0x2B18C24", VA = "0x2B18C24")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x14D7A54", Offset = "0x14D7A54")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000121")]
		[Address(RVA = "0x2B18C70", Offset = "0x2B18C70", VA = "0x2B18C70")]
		public float GetIKPositionWeight(AvatarIKGoal goal)
		{
			return default(float);
		}

		[Token(Token = "0x6000122")]
		[Address(RVA = "0x2B18D0C", Offset = "0x2B18D0C", VA = "0x2B18D0C")]
		public float GetIKRotationWeight(AvatarIKGoal goal)
		{
			return default(float);
		}

		[Token(Token = "0x6000123")]
		[Address(RVA = "0x2B18D2C", Offset = "0x2B18D2C", VA = "0x2B18D2C")]
		public void SetIKPositionWeight(AvatarIKGoal goal, float weight)
		{
		}

		[Token(Token = "0x6000124")]
		[Address(RVA = "0x2B18D5C", Offset = "0x2B18D5C", VA = "0x2B18D5C")]
		public void SetIKRotationWeight(AvatarIKGoal goal, float weight)
		{
		}

		[Token(Token = "0x6000125")]
		[Address(RVA = "0x2B18D8C", Offset = "0x2B18D8C", VA = "0x2B18D8C")]
		public void SetIKPosition(AvatarIKGoal goal, Vector3 IKPosition)
		{
		}

		[Token(Token = "0x6000126")]
		[Address(RVA = "0x2B18DCC", Offset = "0x2B18DCC", VA = "0x2B18DCC")]
		public void SetIKRotation(AvatarIKGoal goal, Quaternion IKRotation)
		{
		}

		[Token(Token = "0x6000127")]
		[Address(RVA = "0x2B18E10", Offset = "0x2B18E10", VA = "0x2B18E10")]
		public Vector3 GetIKPosition(AvatarIKGoal goal)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000128")]
		[Address(RVA = "0x2B18E34", Offset = "0x2B18E34", VA = "0x2B18E34")]
		public Quaternion GetIKRotation(AvatarIKGoal goal)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000129")]
		[Address(RVA = "0x2B18E58", Offset = "0x2B18E58", VA = "0x2B18E58")]
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight, float clampWeight, float clampWeightHead, float clampWeightEyes)
		{
		}

		[Token(Token = "0x600012A")]
		[Address(RVA = "0x2B18E80", Offset = "0x2B18E80", VA = "0x2B18E80")]
		public void SetLookAtPosition(Vector3 lookAtPosition)
		{
		}

		[Token(Token = "0x600012B")]
		[Address(RVA = "0x2B18EAC", Offset = "0x2B18EAC", VA = "0x2B18EAC")]
		public void SetSpinePosition(Vector3 spinePosition)
		{
		}

		[Token(Token = "0x600012C")]
		[Address(RVA = "0x2B18ED8", Offset = "0x2B18ED8", VA = "0x2B18ED8")]
		public void SetSpineWeight(float weight)
		{
		}

		[Token(Token = "0x600012D")]
		[Address(RVA = "0x2B18C90", Offset = "0x2B18C90", VA = "0x2B18C90")]
		public IKSolverLimb GetGoalIK(AvatarIKGoal goal)
		{
			return null;
		}

		[Token(Token = "0x600012E")]
		[Address(RVA = "0x2B18F00", Offset = "0x2B18F00", VA = "0x2B18F00")]
		public void InitiateBipedIK()
		{
		}

		[Token(Token = "0x600012F")]
		[Address(RVA = "0x2B18F0C", Offset = "0x2B18F0C", VA = "0x2B18F0C")]
		public void UpdateBipedIK()
		{
		}

		[Token(Token = "0x6000130")]
		[Address(RVA = "0x2B18F18", Offset = "0x2B18F18", VA = "0x2B18F18")]
		public void SetToDefaults()
		{
		}

		[Token(Token = "0x6000131")]
		[Address(RVA = "0x2B19200", Offset = "0x2B19200", VA = "0x2B19200", Slot = "6")]
		protected override void FixTransforms()
		{
		}

		[Token(Token = "0x6000132")]
		[Address(RVA = "0x2B192A8", Offset = "0x2B192A8", VA = "0x2B192A8", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x6000133")]
		[Address(RVA = "0x2B195EC", Offset = "0x2B195EC", VA = "0x2B195EC", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x6000134")]
		[Address(RVA = "0x2B19AD4", Offset = "0x2B19AD4", VA = "0x2B19AD4")]
		public void LogWarning(string message)
		{
		}

		[Token(Token = "0x6000135")]
		[Address(RVA = "0x2B19B08", Offset = "0x2B19B08", VA = "0x2B19B08")]
		public BipedIK()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000027")]
	public class BipedIKSolvers
	{
		[Token(Token = "0x40000E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public IKSolverLimb leftFoot;

		[Token(Token = "0x40000E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public IKSolverLimb rightFoot;

		[Token(Token = "0x40000E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public IKSolverLimb leftHand;

		[Token(Token = "0x40000E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public IKSolverLimb rightHand;

		[Token(Token = "0x40000E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public IKSolverFABRIK spine;

		[Token(Token = "0x40000E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverLookAt lookAt;

		[Token(Token = "0x40000E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public IKSolverAim aim;

		[Token(Token = "0x40000E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Constraints pelvis;

		[Token(Token = "0x40000E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private IKSolverLimb[] _limbs;

		[Token(Token = "0x40000EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private IKSolver[] _ikSolvers;

		[Token(Token = "0x17000012")]
		public IKSolverLimb[] limbs
		{
			[Token(Token = "0x6000136")]
			[Address(RVA = "0x2B190B8", Offset = "0x2B190B8", VA = "0x2B190B8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000013")]
		public IKSolver[] ikSolvers
		{
			[Token(Token = "0x6000137")]
			[Address(RVA = "0x2B19CD0", Offset = "0x2B19CD0", VA = "0x2B19CD0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000138")]
		[Address(RVA = "0x2B19474", Offset = "0x2B19474", VA = "0x2B19474")]
		public void AssignReferences(BipedReferences references)
		{
		}

		[Token(Token = "0x6000139")]
		[Address(RVA = "0x2B19B88", Offset = "0x2B19B88", VA = "0x2B19B88")]
		public BipedIKSolvers()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000028")]
	public abstract class Constraint
	{
		[Token(Token = "0x40000EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform transform;

		[Token(Token = "0x40000EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float weight;

		[Token(Token = "0x17000014")]
		public bool isValid
		{
			[Token(Token = "0x600013A")]
			[Address(RVA = "0x2B1CF14", Offset = "0x2B1CF14", VA = "0x2B1CF14")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600013B")]
		public abstract void UpdateConstraint();

		[Token(Token = "0x600013C")]
		[Address(RVA = "0x2B1CF84", Offset = "0x2B1CF84", VA = "0x2B1CF84")]
		protected Constraint()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000029")]
	public class ConstraintPosition : Constraint
	{
		[Token(Token = "0x40000ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Vector3 position;

		[Token(Token = "0x600013D")]
		[Address(RVA = "0x2B1CF8C", Offset = "0x2B1CF8C", VA = "0x2B1CF8C", Slot = "4")]
		public override void UpdateConstraint()
		{
		}

		[Token(Token = "0x600013E")]
		[Address(RVA = "0x2B1D098", Offset = "0x2B1D098", VA = "0x2B1D098")]
		public ConstraintPosition()
		{
		}

		[Token(Token = "0x600013F")]
		[Address(RVA = "0x2B1D0A0", Offset = "0x2B1D0A0", VA = "0x2B1D0A0")]
		public ConstraintPosition(Transform transform)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200002A")]
	public class ConstraintPositionOffset : Constraint
	{
		[Token(Token = "0x40000EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Vector3 offset;

		[Token(Token = "0x40000EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Vector3 defaultLocalPosition;

		[Token(Token = "0x40000F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private Vector3 lastLocalPosition;

		[Token(Token = "0x40000F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private bool initiated;

		[Token(Token = "0x17000015")]
		private bool positionChanged
		{
			[Token(Token = "0x6000143")]
			[Address(RVA = "0x2B1D268", Offset = "0x2B1D268", VA = "0x2B1D268")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000140")]
		[Address(RVA = "0x2B1D0CC", Offset = "0x2B1D0CC", VA = "0x2B1D0CC", Slot = "4")]
		public override void UpdateConstraint()
		{
		}

		[Token(Token = "0x6000141")]
		[Address(RVA = "0x2B1D324", Offset = "0x2B1D324", VA = "0x2B1D324")]
		public ConstraintPositionOffset()
		{
		}

		[Token(Token = "0x6000142")]
		[Address(RVA = "0x2B1D32C", Offset = "0x2B1D32C", VA = "0x2B1D32C")]
		public ConstraintPositionOffset(Transform transform)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200002B")]
	public class ConstraintRotation : Constraint
	{
		[Token(Token = "0x40000F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Quaternion rotation;

		[Token(Token = "0x6000144")]
		[Address(RVA = "0x2B1D358", Offset = "0x2B1D358", VA = "0x2B1D358", Slot = "4")]
		public override void UpdateConstraint()
		{
		}

		[Token(Token = "0x6000145")]
		[Address(RVA = "0x2B1D480", Offset = "0x2B1D480", VA = "0x2B1D480")]
		public ConstraintRotation()
		{
		}

		[Token(Token = "0x6000146")]
		[Address(RVA = "0x2B1D488", Offset = "0x2B1D488", VA = "0x2B1D488")]
		public ConstraintRotation(Transform transform)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200002C")]
	public class ConstraintRotationOffset : Constraint
	{
		[Token(Token = "0x40000F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Quaternion offset;

		[Token(Token = "0x40000F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private Quaternion defaultRotation;

		[Token(Token = "0x40000F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private Quaternion defaultLocalRotation;

		[Token(Token = "0x40000F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Quaternion lastLocalRotation;

		[Token(Token = "0x40000F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private Quaternion defaultTargetLocalRotation;

		[Token(Token = "0x40000F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private bool initiated;

		[Token(Token = "0x17000016")]
		private bool rotationChanged
		{
			[Token(Token = "0x600014A")]
			[Address(RVA = "0x2B1D654", Offset = "0x2B1D654", VA = "0x2B1D654")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000147")]
		[Address(RVA = "0x2B1D4B4", Offset = "0x2B1D4B4", VA = "0x2B1D4B4", Slot = "4")]
		public override void UpdateConstraint()
		{
		}

		[Token(Token = "0x6000148")]
		[Address(RVA = "0x2B1D724", Offset = "0x2B1D724", VA = "0x2B1D724")]
		public ConstraintRotationOffset()
		{
		}

		[Token(Token = "0x6000149")]
		[Address(RVA = "0x2B1D72C", Offset = "0x2B1D72C", VA = "0x2B1D72C")]
		public ConstraintRotationOffset(Transform transform)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200002D")]
	public class Constraints
	{
		[Token(Token = "0x40000F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform transform;

		[Token(Token = "0x40000FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform target;

		[Token(Token = "0x40000FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Vector3 positionOffset;

		[Token(Token = "0x40000FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public Vector3 position;

		[Token(Token = "0x40000FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x14D0684", Offset = "0x14D0684")]
		public float positionWeight;

		[Token(Token = "0x40000FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public Vector3 rotationOffset;

		[Token(Token = "0x40000FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Vector3 rotation;

		[Token(Token = "0x4000100")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x14D069C", Offset = "0x14D069C")]
		public float rotationWeight;

		[Token(Token = "0x600014B")]
		[Address(RVA = "0x2B1D758", Offset = "0x2B1D758", VA = "0x2B1D758")]
		public bool IsValid()
		{
			return default(bool);
		}

		[Token(Token = "0x600014C")]
		[Address(RVA = "0x2B19598", Offset = "0x2B19598", VA = "0x2B19598")]
		public void Initiate(Transform transform)
		{
		}

		[Token(Token = "0x600014D")]
		[Address(RVA = "0x2B19774", Offset = "0x2B19774", VA = "0x2B19774")]
		public void Update()
		{
		}

		[Token(Token = "0x600014E")]
		[Address(RVA = "0x2B19E9C", Offset = "0x2B19E9C", VA = "0x2B19E9C")]
		public Constraints()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200002E")]
	public class Finger
	{
		[Serializable]
		[Token(Token = "0x200018E")]
		public enum DOF
		{
			[Token(Token = "0x4000995")]
			One,
			[Token(Token = "0x4000996")]
			Three
		}

		[Token(Token = "0x4000101")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D06B4", Offset = "0x14D06B4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x14D06B4", Offset = "0x14D06B4")]
		public float weight;

		[Token(Token = "0x4000102")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D0708", Offset = "0x14D0708")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x14D0708", Offset = "0x14D0708")]
		public float rotationWeight;

		[Token(Token = "0x4000103")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D075C", Offset = "0x14D075C")]
		public DOF rotationDOF;

		[Token(Token = "0x4000104")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D0794", Offset = "0x14D0794")]
		public bool fixBone1Twist;

		[Token(Token = "0x4000105")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D07CC", Offset = "0x14D07CC")]
		public Transform bone1;

		[Token(Token = "0x4000106")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D0804", Offset = "0x14D0804")]
		public Transform bone2;

		[Token(Token = "0x4000107")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D083C", Offset = "0x14D083C")]
		public Transform bone3;

		[Token(Token = "0x4000108")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D0874", Offset = "0x14D0874")]
		public Transform tip;

		[Token(Token = "0x4000109")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D08AC", Offset = "0x14D08AC")]
		public Transform target;

		[Token(Token = "0x400010A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x14D08E4", Offset = "0x14D08E4")]
		private bool <initiated>k__BackingField;

		[Token(Token = "0x400010B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private IKSolverLimb solver;

		[Token(Token = "0x400010C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Quaternion bone3RelativeToTarget;

		[Token(Token = "0x400010D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Vector3 bone3DefaultLocalPosition;

		[Token(Token = "0x400010E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private Quaternion bone3DefaultLocalRotation;

		[Token(Token = "0x400010F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private Vector3 bone1Axis;

		[Token(Token = "0x4000110")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Vector3 tipAxis;

		[Token(Token = "0x4000111")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private Vector3 bone1TwistAxis;

		[Token(Token = "0x17000017")]
		public bool initiated
		{
			[Token(Token = "0x600014F")]
			[Address(RVA = "0x2B24A90", Offset = "0x2B24A90", VA = "0x2B24A90")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x14D7A8C", Offset = "0x14D7A8C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000150")]
			[Address(RVA = "0x2B24A98", Offset = "0x2B24A98", VA = "0x2B24A98")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x14D7A9C", Offset = "0x14D7A9C")]
			private set
			{
			}
		}

		[Token(Token = "0x17000018")]
		public Vector3 IKPosition
		{
			[Token(Token = "0x6000151")]
			[Address(RVA = "0x2B24AA4", Offset = "0x2B24AA4", VA = "0x2B24AA4")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000152")]
			[Address(RVA = "0x2B24AC4", Offset = "0x2B24AC4", VA = "0x2B24AC4")]
			set
			{
			}
		}

		[Token(Token = "0x17000019")]
		public Quaternion IKRotation
		{
			[Token(Token = "0x6000153")]
			[Address(RVA = "0x2B24AE4", Offset = "0x2B24AE4", VA = "0x2B24AE4")]
			get
			{
				return default(Quaternion);
			}
			[Token(Token = "0x6000154")]
			[Address(RVA = "0x2B24B04", Offset = "0x2B24B04", VA = "0x2B24B04")]
			set
			{
			}
		}

		[Token(Token = "0x6000155")]
		[Address(RVA = "0x2B24B24", Offset = "0x2B24B24", VA = "0x2B24B24")]
		public bool IsValid(ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000156")]
		[Address(RVA = "0x2B24C24", Offset = "0x2B24C24", VA = "0x2B24C24")]
		public void Initiate(Transform hand, int index)
		{
		}

		[Token(Token = "0x6000157")]
		[Address(RVA = "0x2B251B8", Offset = "0x2B251B8", VA = "0x2B251B8")]
		public void FixTransforms()
		{
		}

		[Token(Token = "0x6000158")]
		[Address(RVA = "0x2B25294", Offset = "0x2B25294", VA = "0x2B25294")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000159")]
		[Address(RVA = "0x2B2535C", Offset = "0x2B2535C", VA = "0x2B2535C")]
		public void Update(float masterWeight)
		{
		}

		[Token(Token = "0x600015A")]
		[Address(RVA = "0x2B25AA0", Offset = "0x2B25AA0", VA = "0x2B25AA0")]
		public Finger()
		{
		}
	}
	[Token(Token = "0x200002F")]
	public class FingerRig : SolverManager
	{
		[Token(Token = "0x4000112")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D08F4", Offset = "0x14D08F4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x14D08F4", Offset = "0x14D08F4")]
		public float weight;

		[Token(Token = "0x4000113")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Finger[] fingers;

		[Token(Token = "0x4000114")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x14D0948", Offset = "0x14D0948")]
		private bool <initiated>k__BackingField;

		[Token(Token = "0x1700001A")]
		public bool initiated
		{
			[Token(Token = "0x600015B")]
			[Address(RVA = "0x2D3FCD0", Offset = "0x2D3FCD0", VA = "0x2D3FCD0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x14D7AAC", Offset = "0x14D7AAC")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600015C")]
			[Address(RVA = "0x2D3FCD8", Offset = "0x2D3FCD8", VA = "0x2D3FCD8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x14D7ABC", Offset = "0x14D7ABC")]
			private set
			{
			}
		}

		[Token(Token = "0x600015D")]
		[Address(RVA = "0x2D3FCE4", Offset = "0x2D3FCE4", VA = "0x2D3FCE4")]
		public bool IsValid(ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x600015E")]
		[Address(RVA = "0x2D3FD70", Offset = "0x2D3FD70", VA = "0x2D3FD70")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x14D7ACC", Offset = "0x14D7ACC")]
		public void AutoDetect()
		{
		}

		[Token(Token = "0x600015F")]
		[Address(RVA = "0x2D4008C", Offset = "0x2D4008C", VA = "0x2D4008C")]
		public void AddFinger(Transform bone1, Transform bone2, Transform bone3, Transform tip, [Optional] Transform target)
		{
		}

		[Token(Token = "0x6000160")]
		[Address(RVA = "0x2D40200", Offset = "0x2D40200", VA = "0x2D40200")]
		public void RemoveFinger(int index)
		{
		}

		[Token(Token = "0x6000161")]
		[Address(RVA = "0x2D3FF84", Offset = "0x2D3FF84", VA = "0x2D3FF84")]
		private void AddChildrenRecursive(Transform parent, ref Transform[] array)
		{
		}

		[Token(Token = "0x6000162")]
		[Address(RVA = "0x2D40368", Offset = "0x2D40368", VA = "0x2D40368", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x6000163")]
		[Address(RVA = "0x2D40430", Offset = "0x2D40430", VA = "0x2D40430")]
		public void UpdateFingerSolvers()
		{
		}

		[Token(Token = "0x6000164")]
		[Address(RVA = "0x2D404AC", Offset = "0x2D404AC", VA = "0x2D404AC")]
		public void FixFingerTransforms()
		{
		}

		[Token(Token = "0x6000165")]
		[Address(RVA = "0x2D40524", Offset = "0x2D40524", VA = "0x2D40524")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000166")]
		[Address(RVA = "0x2D40590", Offset = "0x2D40590", VA = "0x2D40590", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x6000167")]
		[Address(RVA = "0x2D40594", Offset = "0x2D40594", VA = "0x2D40594", Slot = "6")]
		protected override void FixTransforms()
		{
		}

		[Token(Token = "0x6000168")]
		[Address(RVA = "0x2D405A8", Offset = "0x2D405A8", VA = "0x2D405A8")]
		public FingerRig()
		{
		}
	}
	[Token(Token = "0x2000030")]
	public abstract class Grounder : MonoBehaviour
	{
		[Token(Token = "0x200018F")]
		public delegate void GrounderDelegate();

		[Token(Token = "0x4000115")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D0958", Offset = "0x14D0958")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x14D0958", Offset = "0x14D0958")]
		public float weight;

		[Token(Token = "0x4000116")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D09AC", Offset = "0x14D09AC")]
		public Grounding solver;

		[Token(Token = "0x4000117")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public GrounderDelegate OnPreGrounder;

		[Token(Token = "0x4000118")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public GrounderDelegate OnPostGrounder;

		[Token(Token = "0x4000119")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x14D09E4", Offset = "0x14D09E4")]
		private bool <initiated>k__BackingField;

		[Token(Token = "0x1700001B")]
		public bool initiated
		{
			[Token(Token = "0x600016A")]
			[Address(RVA = "0x2D415E4", Offset = "0x2D415E4", VA = "0x2D415E4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x14D7B04", Offset = "0x14D7B04")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600016B")]
			[Address(RVA = "0x2D415EC", Offset = "0x2D415EC", VA = "0x2D415EC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x14D7B14", Offset = "0x14D7B14")]
			protected set
			{
			}
		}

		[Token(Token = "0x6000169")]
		public abstract void ResetPosition();

		[Token(Token = "0x600016C")]
		[Address(RVA = "0x2D415F8", Offset = "0x2D415F8", VA = "0x2D415F8")]
		protected Vector3 GetSpineOffsetTarget()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600016D")]
		[Address(RVA = "0x2D418CC", Offset = "0x2D418CC", VA = "0x2D418CC")]
		protected void LogWarning(string message)
		{
		}

		[Token(Token = "0x600016E")]
		[Address(RVA = "0x2D4173C", Offset = "0x2D4173C", VA = "0x2D4173C")]
		private Vector3 GetLegSpineBendVector(Grounding.Leg leg)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600016F")]
		[Address(RVA = "0x2D41900", Offset = "0x2D41900", VA = "0x2D41900")]
		private Vector3 GetLegSpineTangent(Grounding.Leg leg)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000170")]
		protected abstract void OpenUserManual();

		[Token(Token = "0x6000171")]
		protected abstract void OpenScriptReference();

		[Token(Token = "0x6000172")]
		[Address(RVA = "0x2D41B08", Offset = "0x2D41B08", VA = "0x2D41B08")]
		protected Grounder()
		{
		}
	}
	[Token(Token = "0x2000031")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x14CF22C", Offset = "0x14CF22C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x14CF22C", Offset = "0x14CF22C")]
	public class GrounderBipedIK : Grounder
	{
		[Token(Token = "0x400011A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D09F4", Offset = "0x14D09F4")]
		public BipedIK ik;

		[Token(Token = "0x400011B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D0A2C", Offset = "0x14D0A2C")]
		public float spineBend;

		[Token(Token = "0x400011C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D0A64", Offset = "0x14D0A64")]
		public float spineSpeed;

		[Token(Token = "0x400011D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Transform[] feet;

		[Token(Token = "0x400011E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Quaternion[] footRotations;

		[Token(Token = "0x400011F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Vector3 animatedPelvisLocalPosition;

		[Token(Token = "0x4000120")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private Vector3 solvedPelvisLocalPosition;

		[Token(Token = "0x4000121")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Vector3 spineOffset;

		[Token(Token = "0x4000122")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private float lastWeight;

		[Token(Token = "0x6000173")]
		[Address(RVA = "0x2D41E70", Offset = "0x2D41E70", VA = "0x2D41E70", Slot = "5")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x14D7B24", Offset = "0x14D7B24")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000174")]
		[Address(RVA = "0x2D41EBC", Offset = "0x2D41EBC", VA = "0x2D41EBC", Slot = "6")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x14D7B5C", Offset = "0x14D7B5C")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000175")]
		[Address(RVA = "0x2D41F08", Offset = "0x2D41F08", VA = "0x2D41F08", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x6000176")]
		[Address(RVA = "0x2D4200C", Offset = "0x2D4200C", VA = "0x2D4200C")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x6000177")]
		[Address(RVA = "0x2D420BC", Offset = "0x2D420BC", VA = "0x2D420BC")]
		private void Update()
		{
		}

		[Token(Token = "0x6000178")]
		[Address(RVA = "0x2D42170", Offset = "0x2D42170", VA = "0x2D42170")]
		private void Initiate()
		{
		}

		[Token(Token = "0x6000179")]
		[Address(RVA = "0x2D42684", Offset = "0x2D42684", VA = "0x2D42684")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600017A")]
		[Address(RVA = "0x2D426D8", Offset = "0x2D426D8", VA = "0x2D426D8")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x600017B")]
		[Address(RVA = "0x2D42E8C", Offset = "0x2D42E8C", VA = "0x2D42E8C")]
		private void SetLegIK(IKSolverLimb limb, int index)
		{
		}

		[Token(Token = "0x600017C")]
		[Address(RVA = "0x2D42FEC", Offset = "0x2D42FEC", VA = "0x2D42FEC")]
		private void OnPostSolverUpdate()
		{
		}

		[Token(Token = "0x600017D")]
		[Address(RVA = "0x2D4317C", Offset = "0x2D4317C", VA = "0x2D4317C")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600017E")]
		[Address(RVA = "0x2D432EC", Offset = "0x2D432EC", VA = "0x2D432EC")]
		public GrounderBipedIK()
		{
		}
	}
	[Token(Token = "0x2000032")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x14CF28C", Offset = "0x14CF28C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x14CF28C", Offset = "0x14CF28C")]
	public class GrounderFBBIK : Grounder
	{
		[Serializable]
		[Token(Token = "0x2000190")]
		public class SpineEffector
		{
			[Token(Token = "0x4000997")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D433C", Offset = "0x14D433C")]
			public FullBodyBipedEffector effectorType;

			[Token(Token = "0x4000998")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D4374", Offset = "0x14D4374")]
			public float horizontalWeight;

			[Token(Token = "0x4000999")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D43AC", Offset = "0x14D43AC")]
			public float verticalWeight;

			[Token(Token = "0x6000BB6")]
			[Address(RVA = "0x2D44154", Offset = "0x2D44154", VA = "0x2D44154")]
			public SpineEffector()
			{
			}

			[Token(Token = "0x6000BB7")]
			[Address(RVA = "0x2D44164", Offset = "0x2D44164", VA = "0x2D44164")]
			public SpineEffector(FullBodyBipedEffector effectorType, float horizontalWeight, float verticalWeight)
			{
			}
		}

		[Token(Token = "0x4000123")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D0A9C", Offset = "0x14D0A9C")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x4000124")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D0AD4", Offset = "0x14D0AD4")]
		public float spineBend;

		[Token(Token = "0x4000125")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D0B0C", Offset = "0x14D0B0C")]
		public float spineSpeed;

		[Token(Token = "0x4000126")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public SpineEffector[] spine;

		[Token(Token = "0x4000127")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Transform[] feet;

		[Token(Token = "0x4000128")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Vector3 spineOffset;

		[Token(Token = "0x4000129")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private bool firstSolve;

		[Token(Token = "0x600017F")]
		[Address(RVA = "0x2D4336C", Offset = "0x2D4336C", VA = "0x2D4336C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x14D7B94", Offset = "0x14D7B94")]
		private void OpenTutorial()
		{
		}

		[Token(Token = "0x6000180")]
		[Address(RVA = "0x2D433B8", Offset = "0x2D433B8", VA = "0x2D433B8", Slot = "5")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x14D7BCC", Offset = "0x14D7BCC")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000181")]
		[Address(RVA = "0x2D43404", Offset = "0x2D43404", VA = "0x2D43404", Slot = "6")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x14D7C04", Offset = "0x14D7C04")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000182")]
		[Address(RVA = "0x2D43450", Offset = "0x2D43450", VA = "0x2D43450", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x6000183")]
		[Address(RVA = "0x2D434D0", Offset = "0x2D434D0", VA = "0x2D434D0")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x6000184")]
		[Address(RVA = "0x2D43568", Offset = "0x2D43568", VA = "0x2D43568")]
		private void Update()
		{
		}

		[Token(Token = "0x6000185")]
		[Address(RVA = "0x2D43824", Offset = "0x2D43824", VA = "0x2D43824")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000186")]
		[Address(RVA = "0x2D43830", Offset = "0x2D43830", VA = "0x2D43830")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000187")]
		[Address(RVA = "0x2D43624", Offset = "0x2D43624", VA = "0x2D43624")]
		private void Initiate()
		{
		}

		[Token(Token = "0x6000188")]
		[Address(RVA = "0x2D4383C", Offset = "0x2D4383C", VA = "0x2D4383C")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x6000189")]
		[Address(RVA = "0x2D43CDC", Offset = "0x2D43CDC", VA = "0x2D43CDC")]
		private void SetLegIK(IKEffector effector, Grounding.Leg leg)
		{
		}

		[Token(Token = "0x600018A")]
		[Address(RVA = "0x2D43E9C", Offset = "0x2D43E9C", VA = "0x2D43E9C")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x600018B")]
		[Address(RVA = "0x2D43FD4", Offset = "0x2D43FD4", VA = "0x2D43FD4")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600018C")]
		[Address(RVA = "0x2D440D4", Offset = "0x2D440D4", VA = "0x2D440D4")]
		public GrounderFBBIK()
		{
		}
	}
	[Token(Token = "0x2000033")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x14CF2EC", Offset = "0x14CF2EC")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x14CF2EC", Offset = "0x14CF2EC")]
	public class GrounderIK : Grounder
	{
		[Token(Token = "0x400012A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public IK[] legs;

		[Token(Token = "0x400012B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D0B44", Offset = "0x14D0B44")]
		public Transform pelvis;

		[Token(Token = "0x400012C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D0B7C", Offset = "0x14D0B7C")]
		public Transform characterRoot;

		[Token(Token = "0x400012D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D0BB4", Offset = "0x14D0BB4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x14D0BB4", Offset = "0x14D0BB4")]
		public float rootRotationWeight;

		[Token(Token = "0x400012E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D0C08", Offset = "0x14D0C08")]
		public float rootRotationSpeed;

		[Token(Token = "0x400012F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D0C40", Offset = "0x14D0C40")]
		public float maxRootRotationAngle;

		[Token(Token = "0x4000130")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Transform[] feet;

		[Token(Token = "0x4000131")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Quaternion[] footRotations;

		[Token(Token = "0x4000132")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Vector3 animatedPelvisLocalPosition;

		[Token(Token = "0x4000133")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private Vector3 solvedPelvisLocalPosition;

		[Token(Token = "0x4000134")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private int solvedFeet;

		[Token(Token = "0x4000135")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private bool solved;

		[Token(Token = "0x4000136")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private float lastWeight;

		[Token(Token = "0x4000137")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private Rigidbody characterRootRigidbody;

		[Token(Token = "0x600018D")]
		[Address(RVA = "0x2D441AC", Offset = "0x2D441AC", VA = "0x2D441AC", Slot = "5")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x14D7C3C", Offset = "0x14D7C3C")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x600018E")]
		[Address(RVA = "0x2D441F8", Offset = "0x2D441F8", VA = "0x2D441F8", Slot = "6")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x14D7C74", Offset = "0x14D7C74")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x600018F")]
		[Address(RVA = "0x2D44244", Offset = "0x2D44244", VA = "0x2D44244", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x6000190")]
		[Address(RVA = "0x2D4425C", Offset = "0x2D4425C", VA = "0x2D4425C")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x6000191")]
		[Address(RVA = "0x2D4444C", Offset = "0x2D4444C", VA = "0x2D4444C")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000192")]
		[Address(RVA = "0x2D4454C", Offset = "0x2D4454C", VA = "0x2D4454C")]
		private void Update()
		{
		}

		[Token(Token = "0x6000193")]
		[Address(RVA = "0x2D44C94", Offset = "0x2D44C94", VA = "0x2D44C94")]
		private void Initiate()
		{
		}

		[Token(Token = "0x6000194")]
		[Address(RVA = "0x2D45078", Offset = "0x2D45078", VA = "0x2D45078")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x6000195")]
		[Address(RVA = "0x2D452E8", Offset = "0x2D452E8", VA = "0x2D452E8")]
		private void SetLegIK(int index)
		{
		}

		[Token(Token = "0x6000196")]
		[Address(RVA = "0x2D45608", Offset = "0x2D45608", VA = "0x2D45608")]
		private void OnPostSolverUpdate()
		{
		}

		[Token(Token = "0x6000197")]
		[Address(RVA = "0x2D457A4", Offset = "0x2D457A4", VA = "0x2D457A4")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000198")]
		[Address(RVA = "0x2D4596C", Offset = "0x2D4596C", VA = "0x2D4596C")]
		public GrounderIK()
		{
		}
	}
	[Token(Token = "0x2000034")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x14CF34C", Offset = "0x14CF34C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x14CF34C", Offset = "0x14CF34C")]
	public class GrounderQuadruped : Grounder
	{
		[Token(Token = "0x2000191")]
		public struct Foot
		{
			[Token(Token = "0x400099A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public IKSolver solver;

			[Token(Token = "0x400099B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public Transform transform;

			[Token(Token = "0x400099C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Quaternion rotation;

			[Token(Token = "0x400099D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Grounding.Leg leg;

			[Token(Token = "0x6000BB8")]
			[Address(RVA = "0x2D464E8", Offset = "0x2D464E8", VA = "0x2D464E8")]
			public Foot(IKSolver solver, Transform transform)
			{
			}
		}

		[Token(Token = "0x4000138")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D0C78", Offset = "0x14D0C78")]
		public Grounding forelegSolver;

		[Token(Token = "0x4000139")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D0CB0", Offset = "0x14D0CB0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x14D0CB0", Offset = "0x14D0CB0")]
		public float rootRotationWeight;

		[Token(Token = "0x400013A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D0D04", Offset = "0x14D0D04")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x14D0D04", Offset = "0x14D0D04")]
		public float minRootRotation;

		[Token(Token = "0x400013B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D0D5C", Offset = "0x14D0D5C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x14D0D5C", Offset = "0x14D0D5C")]
		public float maxRootRotation;

		[Token(Token = "0x400013C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D0DB4", Offset = "0x14D0DB4")]
		public float rootRotationSpeed;

		[Token(Token = "0x400013D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D0DEC", Offset = "0x14D0DEC")]
		public float maxLegOffset;

		[Token(Token = "0x400013E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D0E24", Offset = "0x14D0E24")]
		public float maxForeLegOffset;

		[Token(Token = "0x400013F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D0E5C", Offset = "0x14D0E5C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x14D0E5C", Offset = "0x14D0E5C")]
		public float maintainHeadRotationWeight;

		[Token(Token = "0x4000140")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D0EB0", Offset = "0x14D0EB0")]
		public Transform characterRoot;

		[Token(Token = "0x4000141")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D0EE8", Offset = "0x14D0EE8")]
		public Transform pelvis;

		[Token(Token = "0x4000142")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D0F20", Offset = "0x14D0F20")]
		public Transform lastSpineBone;

		[Token(Token = "0x4000143")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D0F58", Offset = "0x14D0F58")]
		public Transform head;

		[Token(Token = "0x4000144")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public IK[] legs;

		[Token(Token = "0x4000145")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public IK[] forelegs;

		[Token(Token = "0x4000146")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		[HideInInspector]
		public Vector3 gravity;

		[Token(Token = "0x4000147")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Foot[] feet;

		[Token(Token = "0x4000148")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Vector3 animatedPelvisLocalPosition;

		[Token(Token = "0x4000149")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		private Quaternion animatedPelvisLocalRotation;

		[Token(Token = "0x400014A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		private Quaternion animatedHeadLocalRotation;

		[Token(Token = "0x400014B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		private Vector3 solvedPelvisLocalPosition;

		[Token(Token = "0x400014C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private Quaternion solvedPelvisLocalRotation;

		[Token(Token = "0x400014D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private Quaternion solvedHeadLocalRotation;

		[Token(Token = "0x400014E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private int solvedFeet;

		[Token(Token = "0x400014F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10C")]
		private bool solved;

		[Token(Token = "0x4000150")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private float angle;

		[Token(Token = "0x4000151")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private Transform forefeetRoot;

		[Token(Token = "0x4000152")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private Quaternion headRotation;

		[Token(Token = "0x4000153")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private float lastWeight;

		[Token(Token = "0x4000154")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		private Rigidbody characterRootRigidbody;

		[Token(Token = "0x6000199")]
		[Address(RVA = "0x2D459EC", Offset = "0x2D459EC", VA = "0x2D459EC", Slot = "5")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x14D7CAC", Offset = "0x14D7CAC")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x600019A")]
		[Address(RVA = "0x2D45A38", Offset = "0x2D45A38", VA = "0x2D45A38", Slot = "6")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x14D7CE4", Offset = "0x14D7CE4")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x600019B")]
		[Address(RVA = "0x2D45A84", Offset = "0x2D45A84", VA = "0x2D45A84", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x600019C")]
		[Address(RVA = "0x2D45AB8", Offset = "0x2D45AB8", VA = "0x2D45AB8")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x600019D")]
		[Address(RVA = "0x2D45BE8", Offset = "0x2D45BE8", VA = "0x2D45BE8")]
		private bool IsReadyToInitiateLegs(IK[] ikComponents)
		{
			return default(bool);
		}

		[Token(Token = "0x600019E")]
		[Address(RVA = "0x2D45DA8", Offset = "0x2D45DA8", VA = "0x2D45DA8")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600019F")]
		[Address(RVA = "0x2D45E10", Offset = "0x2D45E10", VA = "0x2D45E10")]
		private void Update()
		{
		}

		[Token(Token = "0x60001A0")]
		[Address(RVA = "0x2D45EC8", Offset = "0x2D45EC8", VA = "0x2D45EC8")]
		private void Initiate()
		{
		}

		[Token(Token = "0x60001A1")]
		[Address(RVA = "0x2D461C8", Offset = "0x2D461C8", VA = "0x2D461C8")]
		private Transform[] InitiateFeet(IK[] ikComponents, ref Foot[] f, int indexOffset)
		{
			return null;
		}

		[Token(Token = "0x60001A2")]
		[Address(RVA = "0x2D46528", Offset = "0x2D46528", VA = "0x2D46528")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60001A3")]
		[Address(RVA = "0x2D46674", Offset = "0x2D46674", VA = "0x2D46674")]
		private void RootRotation()
		{
		}

		[Token(Token = "0x60001A4")]
		[Address(RVA = "0x2D46B18", Offset = "0x2D46B18", VA = "0x2D46B18")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x60001A5")]
		[Address(RVA = "0x2D47308", Offset = "0x2D47308", VA = "0x2D47308")]
		private void UpdateForefeetRoot()
		{
		}

		[Token(Token = "0x60001A6")]
		[Address(RVA = "0x2D475C8", Offset = "0x2D475C8", VA = "0x2D475C8")]
		private void SetFootIK(Foot foot, float maxOffset)
		{
		}

		[Token(Token = "0x60001A7")]
		[Address(RVA = "0x2D47728", Offset = "0x2D47728", VA = "0x2D47728")]
		private void OnPostSolverUpdate()
		{
		}

		[Token(Token = "0x60001A8")]
		[Address(RVA = "0x2D47A04", Offset = "0x2D47A04", VA = "0x2D47A04")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60001A9")]
		[Address(RVA = "0x2D47A3C", Offset = "0x2D47A3C", VA = "0x2D47A3C")]
		private void DestroyLegs(IK[] ikComponents)
		{
		}

		[Token(Token = "0x60001AA")]
		[Address(RVA = "0x2D47BFC", Offset = "0x2D47BFC", VA = "0x2D47BFC")]
		public GrounderQuadruped()
		{
		}
	}
	[Token(Token = "0x2000035")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x14CF3AC", Offset = "0x14CF3AC")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x14CF3AC", Offset = "0x14CF3AC")]
	public class GrounderVRIK : Grounder
	{
		[Token(Token = "0x4000155")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D0FA0", Offset = "0x14D0FA0")]
		public VRIK ik;

		[Token(Token = "0x4000156")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Transform[] feet;

		[Token(Token = "0x60001AB")]
		[Address(RVA = "0x2D47D14", Offset = "0x2D47D14", VA = "0x2D47D14")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x14D7D1C", Offset = "0x14D7D1C")]
		private void OpenTutorial()
		{
		}

		[Token(Token = "0x60001AC")]
		[Address(RVA = "0x2D47D60", Offset = "0x2D47D60", VA = "0x2D47D60", Slot = "5")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x14D7D54", Offset = "0x14D7D54")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60001AD")]
		[Address(RVA = "0x2D47DAC", Offset = "0x2D47DAC", VA = "0x2D47DAC", Slot = "6")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x14D7D8C", Offset = "0x14D7D8C")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60001AE")]
		[Address(RVA = "0x2D47DF8", Offset = "0x2D47DF8", VA = "0x2D47DF8", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x60001AF")]
		[Address(RVA = "0x2D47E10", Offset = "0x2D47E10", VA = "0x2D47E10")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x60001B0")]
		[Address(RVA = "0x2D47EA8", Offset = "0x2D47EA8", VA = "0x2D47EA8")]
		private void Update()
		{
		}

		[Token(Token = "0x60001B1")]
		[Address(RVA = "0x2D47F5C", Offset = "0x2D47F5C", VA = "0x2D47F5C")]
		private void Initiate()
		{
		}

		[Token(Token = "0x60001B2")]
		[Address(RVA = "0x2D4815C", Offset = "0x2D4815C", VA = "0x2D4815C")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x60001B3")]
		[Address(RVA = "0x2D483F0", Offset = "0x2D483F0", VA = "0x2D483F0")]
		private void SetLegIK(IKSolverVR.PositionOffset positionOffset, Transform bone, Grounding.Leg leg)
		{
		}

		[Token(Token = "0x60001B4")]
		[Address(RVA = "0x2D484F8", Offset = "0x2D484F8", VA = "0x2D484F8")]
		private void OnPostSolverUpdate()
		{
		}

		[Token(Token = "0x60001B5")]
		[Address(RVA = "0x2D486F8", Offset = "0x2D486F8", VA = "0x2D486F8")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x60001B6")]
		[Address(RVA = "0x2D48830", Offset = "0x2D48830", VA = "0x2D48830")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60001B7")]
		[Address(RVA = "0x2D48990", Offset = "0x2D48990", VA = "0x2D48990")]
		public GrounderVRIK()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000036")]
	public class Grounding
	{
		[Serializable]
		[Token(Token = "0x2000192")]
		public enum Quality
		{
			[Token(Token = "0x400099F")]
			Fastest,
			[Token(Token = "0x40009A0")]
			Simple,
			[Token(Token = "0x40009A1")]
			Best
		}

		[Token(Token = "0x2000193")]
		public class Leg
		{
			[Token(Token = "0x40009A2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x14D43E4", Offset = "0x14D43E4")]
			private bool <isGrounded>k__BackingField;

			[Token(Token = "0x40009A3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x14D43F4", Offset = "0x14D43F4")]
			private Vector3 <IKPosition>k__BackingField;

			[Token(Token = "0x40009A4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Quaternion rotationOffset;

			[Token(Token = "0x40009A5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x14D4404", Offset = "0x14D4404")]
			private bool <initiated>k__BackingField;

			[Token(Token = "0x40009A6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x14D4414", Offset = "0x14D4414")]
			private float <heightFromGround>k__BackingField;

			[Token(Token = "0x40009A7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x14D4424", Offset = "0x14D4424")]
			private Vector3 <velocity>k__BackingField;

			[Token(Token = "0x40009A8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x14D4434", Offset = "0x14D4434")]
			private Transform <transform>k__BackingField;

			[Token(Token = "0x40009A9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x14D4444", Offset = "0x14D4444")]
			private float <IKOffset>k__BackingField;

			[Token(Token = "0x40009AA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			public bool invertFootCenter;

			[Token(Token = "0x40009AB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x14D4454", Offset = "0x14D4454")]
			private RaycastHit <heelHit>k__BackingField;

			[Token(Token = "0x40009AC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x14D4464", Offset = "0x14D4464")]
			private RaycastHit <capsuleHit>k__BackingField;

			[Token(Token = "0x40009AD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
			private Grounding grounding;

			[Token(Token = "0x40009AE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
			private float lastTime;

			[Token(Token = "0x40009AF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
			private float deltaTime;

			[Token(Token = "0x40009B0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
			private Vector3 lastPosition;

			[Token(Token = "0x40009B1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
			private Quaternion toHitNormal;

			[Token(Token = "0x40009B2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
			private Quaternion r;

			[Token(Token = "0x40009B3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
			private Vector3 up;

			[Token(Token = "0x40009B4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
			private bool doOverrideFootPosition;

			[Token(Token = "0x40009B5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xFC")]
			private Vector3 overrideFootPosition;

			[Token(Token = "0x40009B6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
			private Vector3 transformPosition;

			[Token(Token = "0x1700007B")]
			public bool isGrounded
			{
				[Token(Token = "0x6000BB9")]
				[Address(RVA = "0x2D4A204", Offset = "0x2D4A204", VA = "0x2D4A204")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x14D97CC", Offset = "0x14D97CC")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6000BBA")]
				[Address(RVA = "0x2D4A20C", Offset = "0x2D4A20C", VA = "0x2D4A20C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x14D97DC", Offset = "0x14D97DC")]
				private set
				{
				}
			}

			[Token(Token = "0x1700007C")]
			public Vector3 IKPosition
			{
				[Token(Token = "0x6000BBB")]
				[Address(RVA = "0x2D4A218", Offset = "0x2D4A218", VA = "0x2D4A218")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x14D97EC", Offset = "0x14D97EC")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000BBC")]
				[Address(RVA = "0x2D4A224", Offset = "0x2D4A224", VA = "0x2D4A224")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x14D97FC", Offset = "0x14D97FC")]
				private set
				{
				}
			}

			[Token(Token = "0x1700007D")]
			public bool initiated
			{
				[Token(Token = "0x6000BBD")]
				[Address(RVA = "0x2D4A230", Offset = "0x2D4A230", VA = "0x2D4A230")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x14D980C", Offset = "0x14D980C")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6000BBE")]
				[Address(RVA = "0x2D4A238", Offset = "0x2D4A238", VA = "0x2D4A238")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x14D981C", Offset = "0x14D981C")]
				private set
				{
				}
			}

			[Token(Token = "0x1700007E")]
			public float heightFromGround
			{
				[Token(Token = "0x6000BBF")]
				[Address(RVA = "0x2D4A244", Offset = "0x2D4A244", VA = "0x2D4A244")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x14D982C", Offset = "0x14D982C")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000BC0")]
				[Address(RVA = "0x2D4A24C", Offset = "0x2D4A24C", VA = "0x2D4A24C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x14D983C", Offset = "0x14D983C")]
				private set
				{
				}
			}

			[Token(Token = "0x1700007F")]
			public Vector3 velocity
			{
				[Token(Token = "0x6000BC1")]
				[Address(RVA = "0x2D4A254", Offset = "0x2D4A254", VA = "0x2D4A254")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x14D984C", Offset = "0x14D984C")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000BC2")]
				[Address(RVA = "0x2D4A260", Offset = "0x2D4A260", VA = "0x2D4A260")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x14D985C", Offset = "0x14D985C")]
				private set
				{
				}
			}

			[Token(Token = "0x17000080")]
			public Transform transform
			{
				[Token(Token = "0x6000BC3")]
				[Address(RVA = "0x2D4A26C", Offset = "0x2D4A26C", VA = "0x2D4A26C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x14D986C", Offset = "0x14D986C")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000BC4")]
				[Address(RVA = "0x2D4A274", Offset = "0x2D4A274", VA = "0x2D4A274")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x14D987C", Offset = "0x14D987C")]
				private set
				{
				}
			}

			[Token(Token = "0x17000081")]
			public float IKOffset
			{
				[Token(Token = "0x6000BC5")]
				[Address(RVA = "0x2D4A27C", Offset = "0x2D4A27C", VA = "0x2D4A27C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x14D988C", Offset = "0x14D988C")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000BC6")]
				[Address(RVA = "0x2D4A284", Offset = "0x2D4A284", VA = "0x2D4A284")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x14D989C", Offset = "0x14D989C")]
				private set
				{
				}
			}

			[Token(Token = "0x17000082")]
			public RaycastHit heelHit
			{
				[Token(Token = "0x6000BC7")]
				[Address(RVA = "0x2D4A28C", Offset = "0x2D4A28C", VA = "0x2D4A28C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x14D98AC", Offset = "0x14D98AC")]
				get
				{
					return default(RaycastHit);
				}
				[Token(Token = "0x6000BC8")]
				[Address(RVA = "0x2D4A2A4", Offset = "0x2D4A2A4", VA = "0x2D4A2A4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x14D98BC", Offset = "0x14D98BC")]
				private set
				{
				}
			}

			[Token(Token = "0x17000083")]
			public RaycastHit capsuleHit
			{
				[Token(Token = "0x6000BC9")]
				[Address(RVA = "0x2D4A2C4", Offset = "0x2D4A2C4", VA = "0x2D4A2C4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x14D98CC", Offset = "0x14D98CC")]
				get
				{
					return default(RaycastHit);
				}
				[Token(Token = "0x6000BCA")]
				[Address(RVA = "0x2D4A2DC", Offset = "0x2D4A2DC", VA = "0x2D4A2DC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x14D98DC", Offset = "0x14D98DC")]
				private set
				{
				}
			}

			[Token(Token = "0x17000084")]
			public RaycastHit GetHitPoint
			{
				[Token(Token = "0x6000BCB")]
				[Address(RVA = "0x2D4A2FC", Offset = "0x2D4A2FC", VA = "0x2D4A2FC")]
				get
				{
					return default(RaycastHit);
				}
			}

			[Token(Token = "0x17000085")]
			public float stepHeightFromGround
			{
				[Token(Token = "0x6000BD1")]
				[Address(RVA = "0x2D4B0B8", Offset = "0x2D4B0B8", VA = "0x2D4B0B8")]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x17000086")]
			private float rootYOffset
			{
				[Token(Token = "0x6000BDA")]
				[Address(RVA = "0x2D4B390", Offset = "0x2D4B390", VA = "0x2D4B390")]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x6000BCC")]
			[Address(RVA = "0x2D4A344", Offset = "0x2D4A344", VA = "0x2D4A344")]
			public void SetFootPosition(Vector3 position)
			{
			}

			[Token(Token = "0x6000BCD")]
			[Address(RVA = "0x2D49028", Offset = "0x2D49028", VA = "0x2D49028")]
			public void Initiate(Grounding grounding, Transform transform)
			{
			}

			[Token(Token = "0x6000BCE")]
			[Address(RVA = "0x2D4A358", Offset = "0x2D4A358", VA = "0x2D4A358")]
			public void OnEnable()
			{
			}

			[Token(Token = "0x6000BCF")]
			[Address(RVA = "0x2D49D24", Offset = "0x2D49D24", VA = "0x2D49D24")]
			public void Reset()
			{
			}

			[Token(Token = "0x6000BD0")]
			[Address(RVA = "0x2D49134", Offset = "0x2D49134", VA = "0x2D49134")]
			public void Process()
			{
			}

			[Token(Token = "0x6000BD2")]
			[Address(RVA = "0x2D4AB30", Offset = "0x2D4AB30", VA = "0x2D4AB30")]
			private RaycastHit GetCapsuleHit(Vector3 offsetFromHeel)
			{
				return default(RaycastHit);
			}

			[Token(Token = "0x6000BD3")]
			[Address(RVA = "0x2D4A3A4", Offset = "0x2D4A3A4", VA = "0x2D4A3A4")]
			private RaycastHit GetRaycastHit(Vector3 offsetFromHeel)
			{
				return default(RaycastHit);
			}

			[Token(Token = "0x6000BD4")]
			[Address(RVA = "0x2D4B238", Offset = "0x2D4B238", VA = "0x2D4B238")]
			private Vector3 RotateNormal(Vector3 normal)
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000BD5")]
			[Address(RVA = "0x2D4A7DC", Offset = "0x2D4A7DC", VA = "0x2D4A7DC")]
			private void SetFootToPoint(Vector3 normal, Vector3 point)
			{
			}

			[Token(Token = "0x6000BD6")]
			[Address(RVA = "0x2D4A8E4", Offset = "0x2D4A8E4", VA = "0x2D4A8E4")]
			private void SetFootToPlane(Vector3 planeNormal, Vector3 planePoint, Vector3 heelHitPoint)
			{
			}

			[Token(Token = "0x6000BD7")]
			[Address(RVA = "0x2D4B334", Offset = "0x2D4B334", VA = "0x2D4B334")]
			private float GetHeightFromGround(Vector3 hitPoint)
			{
				return default(float);
			}

			[Token(Token = "0x6000BD8")]
			[Address(RVA = "0x2D4B144", Offset = "0x2D4B144", VA = "0x2D4B144")]
			private void RotateFoot()
			{
			}

			[Token(Token = "0x6000BD9")]
			[Address(RVA = "0x2D4B4B8", Offset = "0x2D4B4B8", VA = "0x2D4B4B8")]
			private Quaternion GetRotationOffsetTarget()
			{
				return default(Quaternion);
			}

			[Token(Token = "0x6000BDB")]
			[Address(RVA = "0x2D48F78", Offset = "0x2D48F78", VA = "0x2D48F78")]
			public Leg()
			{
			}
		}

		[Token(Token = "0x2000194")]
		public class Pelvis
		{
			[Token(Token = "0x40009B7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x14D4474", Offset = "0x14D4474")]
			private Vector3 <IKOffset>k__BackingField;

			[Token(Token = "0x40009B8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x14D4484", Offset = "0x14D4484")]
			private float <heightOffset>k__BackingField;

			[Token(Token = "0x40009B9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private Grounding grounding;

			[Token(Token = "0x40009BA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private Vector3 lastRootPosition;

			[Token(Token = "0x40009BB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private float damperF;

			[Token(Token = "0x40009BC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private bool initiated;

			[Token(Token = "0x40009BD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private float lastTime;

			[Token(Token = "0x17000087")]
			public Vector3 IKOffset
			{
				[Token(Token = "0x6000BDC")]
				[Address(RVA = "0x2D4B5A8", Offset = "0x2D4B5A8", VA = "0x2D4B5A8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x14D98EC", Offset = "0x14D98EC")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000BDD")]
				[Address(RVA = "0x2D4B5B4", Offset = "0x2D4B5B4", VA = "0x2D4B5B4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x14D98FC", Offset = "0x14D98FC")]
				private set
				{
				}
			}

			[Token(Token = "0x17000088")]
			public float heightOffset
			{
				[Token(Token = "0x6000BDE")]
				[Address(RVA = "0x2D4B5C0", Offset = "0x2D4B5C0", VA = "0x2D4B5C0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x14D990C", Offset = "0x14D990C")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000BDF")]
				[Address(RVA = "0x2D4B5C8", Offset = "0x2D4B5C8", VA = "0x2D4B5C8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x14D991C", Offset = "0x14D991C")]
				private set
				{
				}
			}

			[Token(Token = "0x6000BE0")]
			[Address(RVA = "0x2D4910C", Offset = "0x2D4910C", VA = "0x2D4910C")]
			public void Initiate(Grounding grounding)
			{
			}

			[Token(Token = "0x6000BE1")]
			[Address(RVA = "0x2D49C74", Offset = "0x2D49C74", VA = "0x2D49C74")]
			public void Reset()
			{
			}

			[Token(Token = "0x6000BE2")]
			[Address(RVA = "0x2D4B5D0", Offset = "0x2D4B5D0", VA = "0x2D4B5D0")]
			public void OnEnable()
			{
			}

			[Token(Token = "0x6000BE3")]
			[Address(RVA = "0x2D49A08", Offset = "0x2D49A08", VA = "0x2D49A08")]
			public void Process(float lowestOffset, float highestOffset, bool isGrounded)
			{
			}

			[Token(Token = "0x6000BE4")]
			[Address(RVA = "0x2D49020", Offset = "0x2D49020", VA = "0x2D49020")]
			public Pelvis()
			{
			}
		}

		[Token(Token = "0x4000157")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D0FD8", Offset = "0x14D0FD8")]
		public LayerMask layers;

		[Token(Token = "0x4000158")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D1010", Offset = "0x14D1010")]
		public float maxStep;

		[Token(Token = "0x4000159")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D1048", Offset = "0x14D1048")]
		public float heightOffset;

		[Token(Token = "0x400015A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D1080", Offset = "0x14D1080")]
		public float footSpeed;

		[Token(Token = "0x400015B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D10B8", Offset = "0x14D10B8")]
		public float footRadius;

		[Token(Token = "0x400015C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D10F0", Offset = "0x14D10F0")]
		[HideInInspector]
		public float footCenterOffset;

		[Token(Token = "0x400015D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D113C", Offset = "0x14D113C")]
		public float prediction;

		[Token(Token = "0x400015E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D1174", Offset = "0x14D1174")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x14D1174", Offset = "0x14D1174")]
		public float footRotationWeight;

		[Token(Token = "0x400015F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D11C8", Offset = "0x14D11C8")]
		public float footRotationSpeed;

		[Token(Token = "0x4000160")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D1200", Offset = "0x14D1200")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x14D1200", Offset = "0x14D1200")]
		public float maxFootRotationAngle;

		[Token(Token = "0x4000161")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D1258", Offset = "0x14D1258")]
		public bool rotateSolver;

		[Token(Token = "0x4000162")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D1290", Offset = "0x14D1290")]
		public float pelvisSpeed;

		[Token(Token = "0x4000163")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D12C8", Offset = "0x14D12C8")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x14D12C8", Offset = "0x14D12C8")]
		public float pelvisDamper;

		[Token(Token = "0x4000164")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D131C", Offset = "0x14D131C")]
		public float lowerPelvisWeight;

		[Token(Token = "0x4000165")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D1354", Offset = "0x14D1354")]
		public float liftPelvisWeight;

		[Token(Token = "0x4000166")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D138C", Offset = "0x14D138C")]
		public float rootSphereCastRadius;

		[Token(Token = "0x4000167")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D13C4", Offset = "0x14D13C4")]
		public bool overstepFallsDown;

		[Token(Token = "0x4000168")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D13FC", Offset = "0x14D13FC")]
		public Quality quality;

		[Token(Token = "0x4000169")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x14D1434", Offset = "0x14D1434")]
		private Leg[] <legs>k__BackingField;

		[Token(Token = "0x400016A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x14D1444", Offset = "0x14D1444")]
		private Pelvis <pelvis>k__BackingField;

		[Token(Token = "0x400016B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x14D1454", Offset = "0x14D1454")]
		private bool <isGrounded>k__BackingField;

		[Token(Token = "0x400016C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x14D1464", Offset = "0x14D1464")]
		private Transform <root>k__BackingField;

		[Token(Token = "0x400016D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x14D1474", Offset = "0x14D1474")]
		private RaycastHit <rootHit>k__BackingField;

		[Token(Token = "0x400016E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		private bool initiated;

		[Token(Token = "0x1700001C")]
		public Leg[] legs
		{
			[Token(Token = "0x60001B8")]
			[Address(RVA = "0x2D489EC", Offset = "0x2D489EC", VA = "0x2D489EC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x14D7DC4", Offset = "0x14D7DC4")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001B9")]
			[Address(RVA = "0x2D489F4", Offset = "0x2D489F4", VA = "0x2D489F4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x14D7DD4", Offset = "0x14D7DD4")]
			private set
			{
			}
		}

		[Token(Token = "0x1700001D")]
		public Pelvis pelvis
		{
			[Token(Token = "0x60001BA")]
			[Address(RVA = "0x2D489FC", Offset = "0x2D489FC", VA = "0x2D489FC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x14D7DE4", Offset = "0x14D7DE4")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001BB")]
			[Address(RVA = "0x2D48A04", Offset = "0x2D48A04", VA = "0x2D48A04")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x14D7DF4", Offset = "0x14D7DF4")]
			private set
			{
			}
		}

		[Token(Token = "0x1700001E")]
		public bool isGrounded
		{
			[Token(Token = "0x60001BC")]
			[Address(RVA = "0x2D48A0C", Offset = "0x2D48A0C", VA = "0x2D48A0C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x14D7E04", Offset = "0x14D7E04")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60001BD")]
			[Address(RVA = "0x2D48A14", Offset = "0x2D48A14", VA = "0x2D48A14")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x14D7E14", Offset = "0x14D7E14")]
			private set
			{
			}
		}

		[Token(Token = "0x1700001F")]
		public Transform root
		{
			[Token(Token = "0x60001BE")]
			[Address(RVA = "0x2D48A20", Offset = "0x2D48A20", VA = "0x2D48A20")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x14D7E24", Offset = "0x14D7E24")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001BF")]
			[Address(RVA = "0x2D48A28", Offset = "0x2D48A28", VA = "0x2D48A28")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x14D7E34", Offset = "0x14D7E34")]
			private set
			{
			}
		}

		[Token(Token = "0x17000020")]
		public RaycastHit rootHit
		{
			[Token(Token = "0x60001C0")]
			[Address(RVA = "0x2D48A30", Offset = "0x2D48A30", VA = "0x2D48A30")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x14D7E44", Offset = "0x14D7E44")]
			get
			{
				return default(RaycastHit);
			}
			[Token(Token = "0x60001C1")]
			[Address(RVA = "0x2D48A48", Offset = "0x2D48A48", VA = "0x2D48A48")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x14D7E54", Offset = "0x14D7E54")]
			private set
			{
			}
		}

		[Token(Token = "0x17000021")]
		public bool rootGrounded
		{
			[Token(Token = "0x60001C2")]
			[Address(RVA = "0x2D48A68", Offset = "0x2D48A68", VA = "0x2D48A68")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000022")]
		public Vector3 up
		{
			[Token(Token = "0x60001CA")]
			[Address(RVA = "0x2D42F60", Offset = "0x2D42F60", VA = "0x2D42F60")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000023")]
		private bool useRootRotation
		{
			[Token(Token = "0x60001CD")]
			[Address(RVA = "0x2D49DD8", Offset = "0x2D49DD8", VA = "0x2D49DD8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60001C3")]
		[Address(RVA = "0x2D48ABC", Offset = "0x2D48ABC", VA = "0x2D48ABC")]
		public RaycastHit GetRootHit(float maxDistanceMlp = 10f)
		{
			return default(RaycastHit);
		}

		[Token(Token = "0x60001C4")]
		[Address(RVA = "0x2D48E9C", Offset = "0x2D48E9C", VA = "0x2D48E9C")]
		public bool IsValid(ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x60001C5")]
		[Address(RVA = "0x2D42424", Offset = "0x2D42424", VA = "0x2D42424")]
		public void Initiate(Transform root, Transform[] feet)
		{
		}

		[Token(Token = "0x60001C6")]
		[Address(RVA = "0x2D42C24", Offset = "0x2D42C24", VA = "0x2D42C24")]
		public void Update()
		{
		}

		[Token(Token = "0x60001C7")]
		[Address(RVA = "0x2D44A7C", Offset = "0x2D44A7C", VA = "0x2D44A7C")]
		public Vector3 GetLegsPlaneNormal()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60001C8")]
		[Address(RVA = "0x2D41F88", Offset = "0x2D41F88", VA = "0x2D41F88")]
		public void Reset()
		{
		}

		[Token(Token = "0x60001C9")]
		[Address(RVA = "0x2D4911C", Offset = "0x2D4911C", VA = "0x2D4911C")]
		public void LogWarning(string message)
		{
		}

		[Token(Token = "0x60001CB")]
		[Address(RVA = "0x2D49EA8", Offset = "0x2D49EA8", VA = "0x2D49EA8")]
		public float GetVerticalOffset(Vector3 p1, Vector3 p2)
		{
			return default(float);
		}

		[Token(Token = "0x60001CC")]
		[Address(RVA = "0x2D4A010", Offset = "0x2D4A010", VA = "0x2D4A010")]
		public Vector3 Flatten(Vector3 v)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60001CE")]
		[Address(RVA = "0x2D4A114", Offset = "0x2D4A114", VA = "0x2D4A114")]
		public Vector3 GetFootCenterOffset()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60001CF")]
		[Address(RVA = "0x2D41BC8", Offset = "0x2D41BC8", VA = "0x2D41BC8")]
		public Grounding()
		{
		}
	}
	[Token(Token = "0x2000037")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x14CF40C", Offset = "0x14CF40C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x14CF40C", Offset = "0x14CF40C")]
	public class AimIK : IK
	{
		[Token(Token = "0x400016F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverAim solver;

		[Token(Token = "0x60001D0")]
		[Address(RVA = "0x2B14178", Offset = "0x2B14178", VA = "0x2B14178", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x14D7E64", Offset = "0x14D7E64")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60001D1")]
		[Address(RVA = "0x2B141C4", Offset = "0x2B141C4", VA = "0x2B141C4", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x14D7E9C", Offset = "0x14D7E9C")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60001D2")]
		[Address(RVA = "0x2B14210", Offset = "0x2B14210", VA = "0x2B14210")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x14D7ED4", Offset = "0x14D7ED4")]
		private void OpenSetupTutorial()
		{
		}

		[Token(Token = "0x60001D3")]
		[Address(RVA = "0x2B1425C", Offset = "0x2B1425C", VA = "0x2B1425C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x14D7F0C", Offset = "0x14D7F0C")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60001D4")]
		[Address(RVA = "0x2B142A8", Offset = "0x2B142A8", VA = "0x2B142A8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x14D7F44", Offset = "0x14D7F44")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60001D5")]
		[Address(RVA = "0x2B142F4", Offset = "0x2B142F4", VA = "0x2B142F4", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x60001D6")]
		[Address(RVA = "0x2B142FC", Offset = "0x2B142FC", VA = "0x2B142FC")]
		public AimIK()
		{
		}
	}
	[Token(Token = "0x2000038")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x14CF46C", Offset = "0x14CF46C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x14CF46C", Offset = "0x14CF46C")]
	public class ArmIK : IK
	{
		[Token(Token = "0x4000170")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverArm solver;

		[Token(Token = "0x60001D7")]
		[Address(RVA = "0x2B189A0", Offset = "0x2B189A0", VA = "0x2B189A0", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x14D7F7C", Offset = "0x14D7F7C")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60001D8")]
		[Address(RVA = "0x2B189EC", Offset = "0x2B189EC", VA = "0x2B189EC", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x14D7FB4", Offset = "0x14D7FB4")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60001D9")]
		[Address(RVA = "0x2B18A38", Offset = "0x2B18A38", VA = "0x2B18A38")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x14D7FEC", Offset = "0x14D7FEC")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60001DA")]
		[Address(RVA = "0x2B18A84", Offset = "0x2B18A84", VA = "0x2B18A84")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x14D8024", Offset = "0x14D8024")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60001DB")]
		[Address(RVA = "0x2B18AD0", Offset = "0x2B18AD0", VA = "0x2B18AD0", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x60001DC")]
		[Address(RVA = "0x2B18AD8", Offset = "0x2B18AD8", VA = "0x2B18AD8")]
		public ArmIK()
		{
		}
	}
	[Token(Token = "0x2000039")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x14CF4CC", Offset = "0x14CF4CC")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x14CF4CC", Offset = "0x14CF4CC")]
	public class CCDIK : IK
	{
		[Token(Token = "0x4000171")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverCCD solver;

		[Token(Token = "0x60001DD")]
		[Address(RVA = "0x2B1A130", Offset = "0x2B1A130", VA = "0x2B1A130", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x14D805C", Offset = "0x14D805C")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60001DE")]
		[Address(RVA = "0x2B1A17C", Offset = "0x2B1A17C", VA = "0x2B1A17C", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x14D8094", Offset = "0x14D8094")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60001DF")]
		[Address(RVA = "0x2B1A1C8", Offset = "0x2B1A1C8", VA = "0x2B1A1C8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x14D80CC", Offset = "0x14D80CC")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60001E0")]
		[Address(RVA = "0x2B1A214", Offset = "0x2B1A214", VA = "0x2B1A214")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x14D8104", Offset = "0x14D8104")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60001E1")]
		[Address(RVA = "0x2B1A260", Offset = "0x2B1A260", VA = "0x2B1A260", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x60001E2")]
		[Address(RVA = "0x2B1A268", Offset = "0x2B1A268", VA = "0x2B1A268")]
		public CCDIK()
		{
		}
	}
	[Token(Token = "0x200003A")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x14CF52C", Offset = "0x14CF52C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x14CF52C", Offset = "0x14CF52C")]
	public class FABRIK : IK
	{
		[Token(Token = "0x4000172")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverFABRIK solver;

		[Token(Token = "0x60001E3")]
		[Address(RVA = "0x2B1D934", Offset = "0x2B1D934", VA = "0x2B1D934", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x14D813C", Offset = "0x14D813C")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60001E4")]
		[Address(RVA = "0x2B1D980", Offset = "0x2B1D980", VA = "0x2B1D980", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x14D8174", Offset = "0x14D8174")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60001E5")]
		[Address(RVA = "0x2B1D9CC", Offset = "0x2B1D9CC", VA = "0x2B1D9CC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x14D81AC", Offset = "0x14D81AC")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60001E6")]
		[Address(RVA = "0x2B1DA18", Offset = "0x2B1DA18", VA = "0x2B1DA18")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x14D81E4", Offset = "0x14D81E4")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60001E7")]
		[Address(RVA = "0x2B1DA64", Offset = "0x2B1DA64", VA = "0x2B1DA64", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x60001E8")]
		[Address(RVA = "0x2B1DA6C", Offset = "0x2B1DA6C", VA = "0x2B1DA6C")]
		public FABRIK()
		{
		}
	}
	[Token(Token = "0x200003B")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x14CF58C", Offset = "0x14CF58C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x14CF58C", Offset = "0x14CF58C")]
	public class FABRIKRoot : IK
	{
		[Token(Token = "0x4000173")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverFABRIKRoot solver;

		[Token(Token = "0x60001E9")]
		[Address(RVA = "0x2B1E0EC", Offset = "0x2B1E0EC", VA = "0x2B1E0EC", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x14D821C", Offset = "0x14D821C")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60001EA")]
		[Address(RVA = "0x2B1E138", Offset = "0x2B1E138", VA = "0x2B1E138", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x14D8254", Offset = "0x14D8254")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60001EB")]
		[Address(RVA = "0x2B1E184", Offset = "0x2B1E184", VA = "0x2B1E184")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x14D828C", Offset = "0x14D828C")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60001EC")]
		[Address(RVA = "0x2B1E1D0", Offset = "0x2B1E1D0", VA = "0x2B1E1D0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x14D82C4", Offset = "0x14D82C4")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60001ED")]
		[Address(RVA = "0x2B1E21C", Offset = "0x2B1E21C", VA = "0x2B1E21C", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x60001EE")]
		[Address(RVA = "0x2B1E224", Offset = "0x2B1E224", VA = "0x2B1E224")]
		public FABRIKRoot()
		{
		}
	}
	[Token(Token = "0x200003C")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x14CF5EC", Offset = "0x14CF5EC")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x14CF5EC", Offset = "0x14CF5EC")]
	public class FullBodyBipedIK : IK
	{
		[Token(Token = "0x4000174")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public BipedReferences references;

		[Token(Token = "0x4000175")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public IKSolverFullBodyBiped solver;

		[Token(Token = "0x60001EF")]
		[Address(RVA = "0x2D40610", Offset = "0x2D40610", VA = "0x2D40610", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x14D82FC", Offset = "0x14D82FC")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60001F0")]
		[Address(RVA = "0x2D4065C", Offset = "0x2D4065C", VA = "0x2D4065C", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x14D8334", Offset = "0x14D8334")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60001F1")]
		[Address(RVA = "0x2D406A8", Offset = "0x2D406A8", VA = "0x2D406A8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x14D836C", Offset = "0x14D836C")]
		private void OpenSetupTutorial()
		{
		}

		[Token(Token = "0x60001F2")]
		[Address(RVA = "0x2D406F4", Offset = "0x2D406F4", VA = "0x2D406F4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x14D83A4", Offset = "0x14D83A4")]
		private void OpenInspectorTutorial()
		{
		}

		[Token(Token = "0x60001F3")]
		[Address(RVA = "0x2D40740", Offset = "0x2D40740", VA = "0x2D40740")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x14D83DC", Offset = "0x14D83DC")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60001F4")]
		[Address(RVA = "0x2D4078C", Offset = "0x2D4078C", VA = "0x2D4078C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x14D8414", Offset = "0x14D8414")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60001F5")]
		[Address(RVA = "0x2D407D8", Offset = "0x2D407D8", VA = "0x2D407D8")]
		public void SetReferences(BipedReferences references, Transform rootNode)
		{
		}

		[Token(Token = "0x60001F6")]
		[Address(RVA = "0x2D407FC", Offset = "0x2D407FC", VA = "0x2D407FC", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x60001F7")]
		[Address(RVA = "0x2D40804", Offset = "0x2D40804", VA = "0x2D40804")]
		public bool ReferencesError(ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x60001F8")]
		[Address(RVA = "0x2D409C0", Offset = "0x2D409C0", VA = "0x2D409C0")]
		public bool ReferencesWarning(ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x60001F9")]
		[Address(RVA = "0x2D40D14", Offset = "0x2D40D14", VA = "0x2D40D14")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x14D844C", Offset = "0x14D844C")]
		private void Reinitiate()
		{
		}

		[Token(Token = "0x60001FA")]
		[Address(RVA = "0x2D40D34", Offset = "0x2D40D34", VA = "0x2D40D34")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x14D8484", Offset = "0x14D8484")]
		private void AutoDetectReferences()
		{
		}

		[Token(Token = "0x60001FB")]
		[Address(RVA = "0x2D40E10", Offset = "0x2D40E10", VA = "0x2D40E10")]
		public FullBodyBipedIK()
		{
		}
	}
	[Token(Token = "0x200003D")]
	public abstract class IK : SolverManager
	{
		[Token(Token = "0x60001FC")]
		public abstract IKSolver GetIKSolver();

		[Token(Token = "0x60001FD")]
		[Address(RVA = "0x2D4E0B8", Offset = "0x2D4E0B8", VA = "0x2D4E0B8", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x60001FE")]
		[Address(RVA = "0x2D4E1AC", Offset = "0x2D4E1AC", VA = "0x2D4E1AC", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x60001FF")]
		[Address(RVA = "0x2D4E370", Offset = "0x2D4E370", VA = "0x2D4E370", Slot = "6")]
		protected override void FixTransforms()
		{
		}

		[Token(Token = "0x6000200")]
		protected abstract void OpenUserManual();

		[Token(Token = "0x6000201")]
		protected abstract void OpenScriptReference();

		[Token(Token = "0x6000202")]
		[Address(RVA = "0x2D40E98", Offset = "0x2D40E98", VA = "0x2D40E98")]
		protected IK()
		{
		}
	}
	[Token(Token = "0x200003E")]
	public class IKExecutionOrder : MonoBehaviour
	{
		[Token(Token = "0x4000176")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D1484", Offset = "0x14D1484")]
		public IK[] IKComponents;

		[Token(Token = "0x4000177")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D14BC", Offset = "0x14D14BC")]
		public Animator animator;

		[Token(Token = "0x4000178")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool fixedFrame;

		[Token(Token = "0x17000024")]
		private bool animatePhysics
		{
			[Token(Token = "0x6000203")]
			[Address(RVA = "0x2D51310", Offset = "0x2D51310", VA = "0x2D51310")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000204")]
		[Address(RVA = "0x2D513AC", Offset = "0x2D513AC", VA = "0x2D513AC")]
		private void Start()
		{
		}

		[Token(Token = "0x6000205")]
		[Address(RVA = "0x2D5141C", Offset = "0x2D5141C", VA = "0x2D5141C")]
		private void Update()
		{
		}

		[Token(Token = "0x6000206")]
		[Address(RVA = "0x2D514D8", Offset = "0x2D514D8", VA = "0x2D514D8")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000207")]
		[Address(RVA = "0x2D51514", Offset = "0x2D51514", VA = "0x2D51514")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000208")]
		[Address(RVA = "0x2D51450", Offset = "0x2D51450", VA = "0x2D51450")]
		private void FixTransforms()
		{
		}

		[Token(Token = "0x6000209")]
		[Address(RVA = "0x2D515A0", Offset = "0x2D515A0", VA = "0x2D515A0")]
		public IKExecutionOrder()
		{
		}
	}
	[Token(Token = "0x200003F")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x14CF64C", Offset = "0x14CF64C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x14CF64C", Offset = "0x14CF64C")]
	public class LegIK : IK
	{
		[Token(Token = "0x4000179")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverLeg solver;

		[Token(Token = "0x600020A")]
		[Address(RVA = "0x2987AB0", Offset = "0x2987AB0", VA = "0x2987AB0", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x14D84BC", Offset = "0x14D84BC")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x600020B")]
		[Address(RVA = "0x2987AFC", Offset = "0x2987AFC", VA = "0x2987AFC", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x14D84F4", Offset = "0x14D84F4")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x600020C")]
		[Address(RVA = "0x2987B48", Offset = "0x2987B48", VA = "0x2987B48")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x14D852C", Offset = "0x14D852C")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600020D")]
		[Address(RVA = "0x2987B94", Offset = "0x2987B94", VA = "0x2987B94")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x14D8564", Offset = "0x14D8564")]
		private void ASThread()
		{
		}

		[Token(Token = "0x600020E")]
		[Address(RVA = "0x2987BE0", Offset = "0x2987BE0", VA = "0x2987BE0", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x600020F")]
		[Address(RVA = "0x2987BE8", Offset = "0x2987BE8", VA = "0x2987BE8")]
		public LegIK()
		{
		}
	}
	[Token(Token = "0x2000040")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x14CF6AC", Offset = "0x14CF6AC")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x14CF6AC", Offset = "0x14CF6AC")]
	public class LimbIK : IK
	{
		[Token(Token = "0x400017A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverLimb solver;

		[Token(Token = "0x6000210")]
		[Address(RVA = "0x2987C50", Offset = "0x2987C50", VA = "0x2987C50", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x14D859C", Offset = "0x14D859C")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000211")]
		[Address(RVA = "0x2987C9C", Offset = "0x2987C9C", VA = "0x2987C9C", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x14D85D4", Offset = "0x14D85D4")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000212")]
		[Address(RVA = "0x2987CE8", Offset = "0x2987CE8", VA = "0x2987CE8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x14D860C", Offset = "0x14D860C")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000213")]
		[Address(RVA = "0x2987D34", Offset = "0x2987D34", VA = "0x2987D34")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x14D8644", Offset = "0x14D8644")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000214")]
		[Address(RVA = "0x2987D80", Offset = "0x2987D80", VA = "0x2987D80", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000215")]
		[Address(RVA = "0x2987D88", Offset = "0x2987D88", VA = "0x2987D88")]
		public LimbIK()
		{
		}
	}
	[Token(Token = "0x2000041")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x14CF70C", Offset = "0x14CF70C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x14CF70C", Offset = "0x14CF70C")]
	public class LookAtIK : IK
	{
		[Token(Token = "0x400017B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverLookAt solver;

		[Token(Token = "0x6000216")]
		[Address(RVA = "0x2988C44", Offset = "0x2988C44", VA = "0x2988C44", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x14D867C", Offset = "0x14D867C")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000217")]
		[Address(RVA = "0x2988C90", Offset = "0x2988C90", VA = "0x2988C90", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x14D86B4", Offset = "0x14D86B4")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000218")]
		[Address(RVA = "0x2988CDC", Offset = "0x2988CDC", VA = "0x2988CDC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x14D86EC", Offset = "0x14D86EC")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000219")]
		[Address(RVA = "0x2988D28", Offset = "0x2988D28", VA = "0x2988D28")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x14D8724", Offset = "0x14D8724")]
		private void ASThread()
		{
		}

		[Token(Token = "0x600021A")]
		[Address(RVA = "0x2988D74", Offset = "0x2988D74", VA = "0x2988D74", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x600021B")]
		[Address(RVA = "0x2988D7C", Offset = "0x2988D7C", VA = "0x2988D7C")]
		public LookAtIK()
		{
		}
	}
	[Token(Token = "0x2000042")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x14CF76C", Offset = "0x14CF76C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x14CF76C", Offset = "0x14CF76C")]
	public class TrigonometricIK : IK
	{
		[Token(Token = "0x400017C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverTrigonometric solver;

		[Token(Token = "0x600021C")]
		[Address(RVA = "0x2992018", Offset = "0x2992018", VA = "0x2992018", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x14D875C", Offset = "0x14D875C")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x600021D")]
		[Address(RVA = "0x2992064", Offset = "0x2992064", VA = "0x2992064", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x14D8794", Offset = "0x14D8794")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x600021E")]
		[Address(RVA = "0x29920B0", Offset = "0x29920B0", VA = "0x29920B0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x14D87CC", Offset = "0x14D87CC")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600021F")]
		[Address(RVA = "0x29920FC", Offset = "0x29920FC", VA = "0x29920FC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x14D8804", Offset = "0x14D8804")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000220")]
		[Address(RVA = "0x2992148", Offset = "0x2992148", VA = "0x2992148", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000221")]
		[Address(RVA = "0x2992150", Offset = "0x2992150", VA = "0x2992150")]
		public TrigonometricIK()
		{
		}
	}
	[Token(Token = "0x2000043")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x14CF7CC", Offset = "0x14CF7CC")]
	public class VRIK : IK
	{
		[Serializable]
		[Token(Token = "0x2000195")]
		public class References
		{
			[Token(Token = "0x40009BE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform root;

			[Token(Token = "0x40009BF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Transform pelvis;

			[Token(Token = "0x40009C0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Transform spine;

			[Token(Token = "0x40009C1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D4494", Offset = "0x14D4494")]
			public Transform chest;

			[Token(Token = "0x40009C2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D44CC", Offset = "0x14D44CC")]
			public Transform neck;

			[Token(Token = "0x40009C3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Transform head;

			[Token(Token = "0x40009C4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D4504", Offset = "0x14D4504")]
			public Transform leftShoulder;

			[Token(Token = "0x40009C5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public Transform leftUpperArm;

			[Token(Token = "0x40009C6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public Transform leftForearm;

			[Token(Token = "0x40009C7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public Transform leftHand;

			[Token(Token = "0x40009C8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D453C", Offset = "0x14D453C")]
			public Transform rightShoulder;

			[Token(Token = "0x40009C9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			public Transform rightUpperArm;

			[Token(Token = "0x40009CA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			public Transform rightForearm;

			[Token(Token = "0x40009CB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			public Transform rightHand;

			[Token(Token = "0x40009CC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D4574", Offset = "0x14D4574")]
			public Transform leftThigh;

			[Token(Token = "0x40009CD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D45AC", Offset = "0x14D45AC")]
			public Transform leftCalf;

			[Token(Token = "0x40009CE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D45E4", Offset = "0x14D45E4")]
			public Transform leftFoot;

			[Token(Token = "0x40009CF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D461C", Offset = "0x14D461C")]
			public Transform leftToes;

			[Token(Token = "0x40009D0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D4654", Offset = "0x14D4654")]
			public Transform rightThigh;

			[Token(Token = "0x40009D1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D468C", Offset = "0x14D468C")]
			public Transform rightCalf;

			[Token(Token = "0x40009D2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D46C4", Offset = "0x14D46C4")]
			public Transform rightFoot;

			[Token(Token = "0x40009D3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D46FC", Offset = "0x14D46FC")]
			public Transform rightToes;

			[Token(Token = "0x17000089")]
			public bool isFilled
			{
				[Token(Token = "0x6000BE6")]
				[Address(RVA = "0x2993650", Offset = "0x2993650", VA = "0x2993650")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x1700008A")]
			public bool isEmpty
			{
				[Token(Token = "0x6000BE7")]
				[Address(RVA = "0x29931D4", Offset = "0x29931D4", VA = "0x29931D4")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x6000BE5")]
			[Address(RVA = "0x2993CD4", Offset = "0x2993CD4", VA = "0x2993CD4")]
			public Transform[] GetTransforms()
			{
				return null;
			}

			[Token(Token = "0x6000BE8")]
			[Address(RVA = "0x2992DC0", Offset = "0x2992DC0", VA = "0x2992DC0")]
			public static bool AutoDetectReferences(Transform root, out References references)
			{
				return default(bool);
			}

			[Token(Token = "0x6000BE9")]
			[Address(RVA = "0x2993CCC", Offset = "0x2993CCC", VA = "0x2993CCC")]
			public References()
			{
			}
		}

		[Token(Token = "0x400017D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "ContextMenuItemAttribute", RVA = "0x14D14F4", Offset = "0x14D14F4")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D14F4", Offset = "0x14D14F4")]
		public References references;

		[Token(Token = "0x400017E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D1570", Offset = "0x14D1570")]
		public IKSolverVR solver;

		[Token(Token = "0x6000222")]
		[Address(RVA = "0x2992CB4", Offset = "0x2992CB4", VA = "0x2992CB4", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x14D883C", Offset = "0x14D883C")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000223")]
		[Address(RVA = "0x2992D00", Offset = "0x2992D00", VA = "0x2992D00", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x14D8874", Offset = "0x14D8874")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000224")]
		[Address(RVA = "0x2992D4C", Offset = "0x2992D4C", VA = "0x2992D4C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x14D88AC", Offset = "0x14D88AC")]
		private void OpenSetupTutorial()
		{
		}

		[Token(Token = "0x6000225")]
		[Address(RVA = "0x2992D98", Offset = "0x2992D98", VA = "0x2992D98")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x14D88E4", Offset = "0x14D88E4")]
		public void AutoDetectReferences()
		{
		}

		[Token(Token = "0x6000226")]
		[Address(RVA = "0x2993130", Offset = "0x2993130", VA = "0x2993130")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x14D891C", Offset = "0x14D891C")]
		public void GuessHandOrientations()
		{
		}

		[Token(Token = "0x6000227")]
		[Address(RVA = "0x2993158", Offset = "0x2993158", VA = "0x2993158", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000228")]
		[Address(RVA = "0x2993160", Offset = "0x2993160", VA = "0x2993160", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x6000229")]
		[Address(RVA = "0x2993ACC", Offset = "0x2993ACC", VA = "0x2993ACC", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x600022A")]
		[Address(RVA = "0x2993C44", Offset = "0x2993C44", VA = "0x2993C44")]
		public VRIK()
		{
		}
	}
	[Token(Token = "0x2000044")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x14CF804", Offset = "0x14CF804")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x14CF804", Offset = "0x14CF804")]
	public class AimIKJ : MonoBehaviour
	{
		[Token(Token = "0x400017F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D15A8", Offset = "0x14D15A8")]
		public Transform target;

		[Token(Token = "0x4000180")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D15E0", Offset = "0x14D15E0")]
		public Transform poleTarget;

		[Token(Token = "0x4000181")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D1618", Offset = "0x14D1618")]
		public Transform aimTransform;

		[Token(Token = "0x4000182")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x14D1650", Offset = "0x14D1650")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D1650", Offset = "0x14D1650")]
		public float axisX;

		[Token(Token = "0x4000183")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D16A0", Offset = "0x14D16A0")]
		public float axisY;

		[Token(Token = "0x4000184")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D16D8", Offset = "0x14D16D8")]
		public float axisZ;

		[Token(Token = "0x4000185")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x14D1710", Offset = "0x14D1710")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D1710", Offset = "0x14D1710")]
		public float poleAxisX;

		[Token(Token = "0x4000186")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D1760", Offset = "0x14D1760")]
		public float poleAxisY;

		[Token(Token = "0x4000187")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D1798", Offset = "0x14D1798")]
		public float poleAxisZ;

		[Token(Token = "0x4000188")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x14D17D0", Offset = "0x14D17D0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D17D0", Offset = "0x14D17D0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x14D17D0", Offset = "0x14D17D0")]
		public float weight;

		[Token(Token = "0x4000189")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D1838", Offset = "0x14D1838")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x14D1838", Offset = "0x14D1838")]
		public float poleWeight;

		[Token(Token = "0x400018A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D188C", Offset = "0x14D188C")]
		public float tolerance;

		[Token(Token = "0x400018B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D18C4", Offset = "0x14D18C4")]
		public int maxIterations;

		[Token(Token = "0x400018C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D18FC", Offset = "0x14D18FC")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x14D18FC", Offset = "0x14D18FC")]
		public float clampWeight;

		[Token(Token = "0x400018D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D1950", Offset = "0x14D1950")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x14D1950", Offset = "0x14D1950")]
		public int clampSmoothing;

		[Token(Token = "0x400018E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D19A4", Offset = "0x14D19A4")]
		public bool useRotationLimits;

		[Token(Token = "0x400018F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x61")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D19DC", Offset = "0x14D19DC")]
		public bool XY;

		[Token(Token = "0x4000190")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x14D1A14", Offset = "0x14D1A14")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D1A14", Offset = "0x14D1A14")]
		public Transform[] bones;

		[Token(Token = "0x4000191")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x14D1A64", Offset = "0x14D1A64")]
		private bool <initiated>k__BackingField;

		[Token(Token = "0x4000192")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Animator animator;

		[Token(Token = "0x4000193")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private PlayableGraph graph;

		[Token(Token = "0x4000194")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private AnimationScriptPlayable IKPlayable;

		[Token(Token = "0x4000195")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private AimIKJob job;

		[Token(Token = "0x17000025")]
		public bool initiated
		{
			[Token(Token = "0x600022B")]
			[Address(RVA = "0x2B14364", Offset = "0x2B14364", VA = "0x2B14364")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x14D8954", Offset = "0x14D8954")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600022C")]
			[Address(RVA = "0x2B1436C", Offset = "0x2B1436C", VA = "0x2B1436C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x14D8964", Offset = "0x14D8964")]
			private set
			{
			}
		}

		[Token(Token = "0x17000026")]
		public Vector3 axis
		{
			[Token(Token = "0x600022D")]
			[Address(RVA = "0x2B14378", Offset = "0x2B14378", VA = "0x2B14378")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x600022E")]
			[Address(RVA = "0x2B143B4", Offset = "0x2B143B4", VA = "0x2B143B4")]
			set
			{
			}
		}

		[Token(Token = "0x17000027")]
		public Vector3 poleAxis
		{
			[Token(Token = "0x600022F")]
			[Address(RVA = "0x2B143C0", Offset = "0x2B143C0", VA = "0x2B143C0")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000230")]
			[Address(RVA = "0x2B143FC", Offset = "0x2B143FC", VA = "0x2B143FC")]
			set
			{
			}
		}

		[Token(Token = "0x6000231")]
		[Address(RVA = "0x2B14408", Offset = "0x2B14408", VA = "0x2B14408")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000232")]
		[Address(RVA = "0x2B15210", Offset = "0x2B15210", VA = "0x2B15210")]
		private void Update()
		{
		}

		[Token(Token = "0x6000233")]
		[Address(RVA = "0x2B155F8", Offset = "0x2B155F8", VA = "0x2B155F8")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000234")]
		[Address(RVA = "0x2B156F8", Offset = "0x2B156F8", VA = "0x2B156F8")]
		public AimIKJ()
		{
		}
	}
	[Token(Token = "0x2000045")]
	public struct AimIKJob : IAnimationJob
	{
		[Token(Token = "0x4000196")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public TransformSceneHandle _target;

		[Token(Token = "0x4000197")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public TransformSceneHandle _poleTarget;

		[Token(Token = "0x4000198")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public TransformStreamHandle _transform;

		[Token(Token = "0x4000199")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public PropertySceneHandle _IKPositionWeight;

		[Token(Token = "0x400019A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public PropertySceneHandle _poleWeight;

		[Token(Token = "0x400019B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public PropertySceneHandle _axisX;

		[Token(Token = "0x400019C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public PropertySceneHandle _axisY;

		[Token(Token = "0x400019D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public PropertySceneHandle _axisZ;

		[Token(Token = "0x400019E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public PropertySceneHandle _poleAxisX;

		[Token(Token = "0x400019F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public PropertySceneHandle _poleAxisY;

		[Token(Token = "0x40001A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public PropertySceneHandle _poleAxisZ;

		[Token(Token = "0x40001A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public PropertySceneHandle _clampWeight;

		[Token(Token = "0x40001A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public PropertySceneHandle _clampSmoothing;

		[Token(Token = "0x40001A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public PropertySceneHandle _maxIterations;

		[Token(Token = "0x40001A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		public PropertySceneHandle _tolerance;

		[Token(Token = "0x40001A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		public PropertySceneHandle _XY;

		[Token(Token = "0x40001A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		public PropertySceneHandle _useRotationLimits;

		[Token(Token = "0x40001A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private NativeArray<TransformStreamHandle> bones;

		[Token(Token = "0x40001A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private NativeArray<PropertySceneHandle> boneWeights;

		[Token(Token = "0x40001A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Vector3 lastLocalDirection;

		[Token(Token = "0x40001AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		private float step;

		[Token(Token = "0x40001AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private NativeArray<Quaternion> limitDefaultLocalRotationArray;

		[Token(Token = "0x40001AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private NativeArray<Vector3> limitAxisArray;

		[Token(Token = "0x40001AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private NativeArray<int> hingeFlags;

		[Token(Token = "0x40001AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private NativeArray<PropertySceneHandle> hingeMinArray;

		[Token(Token = "0x40001AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private NativeArray<PropertySceneHandle> hingeMaxArray;

		[Token(Token = "0x40001B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private NativeArray<PropertySceneHandle> hingeUseLimitsArray;

		[Token(Token = "0x40001B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private NativeArray<Quaternion> hingeLastRotations;

		[Token(Token = "0x40001B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private NativeArray<float> hingeLastAngles;

		[Token(Token = "0x40001B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		private NativeArray<int> angleFlags;

		[Token(Token = "0x40001B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		private NativeArray<Vector3> angleSecondaryAxisArray;

		[Token(Token = "0x40001B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		private NativeArray<PropertySceneHandle> angleLimitArray;

		[Token(Token = "0x40001B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		private NativeArray<PropertySceneHandle> angleTwistLimitArray;

		[Token(Token = "0x6000235")]
		[Address(RVA = "0x2B14B48", Offset = "0x2B14B48", VA = "0x2B14B48")]
		public void Setup(Animator animator, Transform[] bones, Transform target, Transform poleTarget, Transform aimTransform)
		{
		}

		[Token(Token = "0x6000236")]
		[Address(RVA = "0x2B15788", Offset = "0x2B15788", VA = "0x2B15788")]
		private void SetUpRotationLimits(Animator animator, Transform[] bones)
		{
		}

		[Token(Token = "0x6000237")]
		[Address(RVA = "0x2B15DFC", Offset = "0x2B15DFC", VA = "0x2B15DFC")]
		private void DisposeRotationLimits()
		{
		}

		[Token(Token = "0x6000238")]
		[Address(RVA = "0x2B15F00", Offset = "0x2B15F00", VA = "0x2B15F00", Slot = "5")]
		public void ProcessRootMotion(AnimationStream stream)
		{
		}

		[Token(Token = "0x6000239")]
		[Address(RVA = "0x2B15F04", Offset = "0x2B15F04", VA = "0x2B15F04", Slot = "4")]
		public void ProcessAnimation(AnimationStream stream)
		{
		}

		[Token(Token = "0x600023A")]
		[Address(RVA = "0x2B15F3C", Offset = "0x2B15F3C", VA = "0x2B15F3C")]
		private void Update(AnimationStream s)
		{
		}

		[Token(Token = "0x600023B")]
		[Address(RVA = "0x2B17080", Offset = "0x2B17080", VA = "0x2B17080")]
		private void RotateToTarget(AnimationStream s, Vector3 targetPosition, Vector3 polePosition, int i, float weight, float poleWeight, bool XY, bool useRotationLimits, Vector3 axis, Vector3 poleAxis)
		{
		}

		[Token(Token = "0x600023C")]
		[Address(RVA = "0x2B16DBC", Offset = "0x2B16DBC", VA = "0x2B16DBC")]
		public float GetAngle(AnimationStream s, Vector3 axis, Vector3 IKPosition)
		{
			return default(float);
		}

		[Token(Token = "0x600023D")]
		[Address(RVA = "0x2B16A84", Offset = "0x2B16A84", VA = "0x2B16A84")]
		private Vector3 GetClampedIKPosition(AnimationStream s, float clampWeight, int clampSmoothing, Vector3 IKPosition, Vector3 transformPosition, Vector3 transformAxis)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600023E")]
		[Address(RVA = "0x2B16F60", Offset = "0x2B16F60", VA = "0x2B16F60")]
		private Vector3 GetLocalDirection(AnimationStream s, Vector3 transformAxis)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600023F")]
		[Address(RVA = "0x2B17EA8", Offset = "0x2B17EA8", VA = "0x2B17EA8")]
		private float GetPositionOffset(AnimationStream s, Vector3 localDirection)
		{
			return default(float);
		}

		[Token(Token = "0x6000240")]
		[Address(RVA = "0x2B1568C", Offset = "0x2B1568C", VA = "0x2B1568C")]
		public void Dispose()
		{
		}
	}
	[Token(Token = "0x2000046")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x14CF88C", Offset = "0x14CF88C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x14CF88C", Offset = "0x14CF88C")]
	public class CCDIKJ : MonoBehaviour
	{
		[Token(Token = "0x40001B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D1A74", Offset = "0x14D1A74")]
		public Transform target;

		[Token(Token = "0x40001B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D1AAC", Offset = "0x14D1AAC")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x14D1AAC", Offset = "0x14D1AAC")]
		public float weight;

		[Token(Token = "0x40001B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D1B00", Offset = "0x14D1B00")]
		public float tolerance;

		[Token(Token = "0x40001BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D1B38", Offset = "0x14D1B38")]
		public int maxIterations;

		[Token(Token = "0x40001BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D1B70", Offset = "0x14D1B70")]
		public bool useRotationLimits;

		[Token(Token = "0x40001BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2D")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D1BA8", Offset = "0x14D1BA8")]
		public bool XY;

		[Token(Token = "0x40001BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D1BE0", Offset = "0x14D1BE0")]
		public Transform[] bones;

		[Token(Token = "0x40001BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x14D1C18", Offset = "0x14D1C18")]
		private bool <initiated>k__BackingField;

		[Token(Token = "0x40001BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Animator animator;

		[Token(Token = "0x40001C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private PlayableGraph graph;

		[Token(Token = "0x40001C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private AnimationScriptPlayable IKPlayable;

		[Token(Token = "0x40001C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private CCDIKJob job;

		[Token(Token = "0x17000028")]
		public bool initiated
		{
			[Token(Token = "0x6000241")]
			[Address(RVA = "0x2B1A2D0", Offset = "0x2B1A2D0", VA = "0x2B1A2D0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x14D8974", Offset = "0x14D8974")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000242")]
			[Address(RVA = "0x2B1A2D8", Offset = "0x2B1A2D8", VA = "0x2B1A2D8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x14D8984", Offset = "0x14D8984")]
			private set
			{
			}
		}

		[Token(Token = "0x6000243")]
		[Address(RVA = "0x2B1A2E4", Offset = "0x2B1A2E4", VA = "0x2B1A2E4")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000244")]
		[Address(RVA = "0x2B1AAA8", Offset = "0x2B1AAA8", VA = "0x2B1AAA8")]
		private void Update()
		{
		}

		[Token(Token = "0x6000245")]
		[Address(RVA = "0x2B1AC40", Offset = "0x2B1AC40", VA = "0x2B1AC40")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000246")]
		[Address(RVA = "0x2B1AD54", Offset = "0x2B1AD54", VA = "0x2B1AD54")]
		public CCDIKJ()
		{
		}
	}
	[Token(Token = "0x2000047")]
	public struct CCDIKJob : IAnimationJob
	{
		[Token(Token = "0x40001C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public TransformSceneHandle _target;

		[Token(Token = "0x40001C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public PropertySceneHandle _IKPositionWeight;

		[Token(Token = "0x40001C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public PropertySceneHandle _maxIterations;

		[Token(Token = "0x40001C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public PropertySceneHandle _tolerance;

		[Token(Token = "0x40001C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public PropertySceneHandle _XY;

		[Token(Token = "0x40001C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public PropertySceneHandle _useRotationLimits;

		[Token(Token = "0x40001C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private NativeArray<TransformStreamHandle> bones;

		[Token(Token = "0x40001CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private NativeArray<PropertySceneHandle> boneWeights;

		[Token(Token = "0x40001CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private NativeArray<float> boneSqrMags;

		[Token(Token = "0x40001CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private float chainSqrMag;

		[Token(Token = "0x40001CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private Vector3 lastLocalDirection;

		[Token(Token = "0x40001CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private NativeArray<Quaternion> limitDefaultLocalRotationArray;

		[Token(Token = "0x40001CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private NativeArray<Vector3> limitAxisArray;

		[Token(Token = "0x40001D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private NativeArray<int> hingeFlags;

		[Token(Token = "0x40001D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private NativeArray<PropertySceneHandle> hingeMinArray;

		[Token(Token = "0x40001D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private NativeArray<PropertySceneHandle> hingeMaxArray;

		[Token(Token = "0x40001D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private NativeArray<PropertySceneHandle> hingeUseLimitsArray;

		[Token(Token = "0x40001D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private NativeArray<Quaternion> hingeLastRotations;

		[Token(Token = "0x40001D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private NativeArray<float> hingeLastAngles;

		[Token(Token = "0x40001D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private NativeArray<int> angleFlags;

		[Token(Token = "0x40001D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private NativeArray<Vector3> angleSecondaryAxisArray;

		[Token(Token = "0x40001D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private NativeArray<PropertySceneHandle> angleLimitArray;

		[Token(Token = "0x40001D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private NativeArray<PropertySceneHandle> angleTwistLimitArray;

		[Token(Token = "0x6000247")]
		[Address(RVA = "0x2B1A648", Offset = "0x2B1A648", VA = "0x2B1A648")]
		public void Setup(Animator animator, Transform[] bones, Transform target)
		{
		}

		[Token(Token = "0x6000248")]
		[Address(RVA = "0x2B1ADCC", Offset = "0x2B1ADCC", VA = "0x2B1ADCC")]
		private void SetUpRotationLimits(Animator animator, Transform[] bones)
		{
		}

		[Token(Token = "0x6000249")]
		[Address(RVA = "0x2B1B440", Offset = "0x2B1B440", VA = "0x2B1B440")]
		private void DisposeRotationLimits()
		{
		}

		[Token(Token = "0x600024A")]
		[Address(RVA = "0x2B1B544", Offset = "0x2B1B544", VA = "0x2B1B544", Slot = "5")]
		public void ProcessRootMotion(AnimationStream stream)
		{
		}

		[Token(Token = "0x600024B")]
		[Address(RVA = "0x2B1B548", Offset = "0x2B1B548", VA = "0x2B1B548", Slot = "4")]
		public void ProcessAnimation(AnimationStream stream)
		{
		}

		[Token(Token = "0x600024C")]
		[Address(RVA = "0x2B1B580", Offset = "0x2B1B580", VA = "0x2B1B580")]
		private void Update(AnimationStream s)
		{
		}

		[Token(Token = "0x600024D")]
		[Address(RVA = "0x2B1BAA8", Offset = "0x2B1BAA8", VA = "0x2B1BAA8")]
		private void Read(AnimationStream s)
		{
		}

		[Token(Token = "0x600024E")]
		[Address(RVA = "0x2B1C278", Offset = "0x2B1C278", VA = "0x2B1C278")]
		private void Solve(AnimationStream s, Vector3 targetPosition, bool XY, float weight, int it, bool useRotationLimits)
		{
		}

		[Token(Token = "0x600024F")]
		[Address(RVA = "0x2B1BFBC", Offset = "0x2B1BFBC", VA = "0x2B1BFBC")]
		private Vector3 GetLocalDirection(AnimationStream s)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000250")]
		[Address(RVA = "0x2B1C1C8", Offset = "0x2B1C1C8", VA = "0x2B1C1C8")]
		private float GetPositionOffset(AnimationStream s, Vector3 localDirection)
		{
			return default(float);
		}

		[Token(Token = "0x6000251")]
		[Address(RVA = "0x2B1BC74", Offset = "0x2B1BC74", VA = "0x2B1BC74")]
		private Vector3 GetSingularityOffset(AnimationStream s, Vector3 IKPosition, bool useRotationLimits)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000252")]
		[Address(RVA = "0x2B1CCA8", Offset = "0x2B1CCA8", VA = "0x2B1CCA8")]
		private bool SingularityDetected(AnimationStream s, Vector3 IKPosition)
		{
			return default(bool);
		}

		[Token(Token = "0x6000253")]
		[Address(RVA = "0x2B1ACD4", Offset = "0x2B1ACD4", VA = "0x2B1ACD4")]
		public void Dispose()
		{
		}
	}
	[Token(Token = "0x2000048")]
	public class IKJBoneParams : MonoBehaviour
	{
		[Token(Token = "0x40001DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x14D1C28", Offset = "0x14D1C28")]
		public float weight;

		[Token(Token = "0x6000254")]
		[Address(RVA = "0x2D515A8", Offset = "0x2D515A8", VA = "0x2D515A8")]
		public IKJBoneParams()
		{
		}
	}
	[Token(Token = "0x2000049")]
	public static class RotationLimitUtilities
	{
		[Token(Token = "0x6000255")]
		[Address(RVA = "0x2990FB0", Offset = "0x2990FB0", VA = "0x2990FB0")]
		public static Quaternion LimitHinge(Quaternion rotation, float min, float max, bool useLimits, Vector3 axis, ref Quaternion lastRotation, ref float lastAngle)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000256")]
		[Address(RVA = "0x29912D0", Offset = "0x29912D0", VA = "0x29912D0")]
		public static Quaternion Limit1DOF(Quaternion rotation, Vector3 axis)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000257")]
		[Address(RVA = "0x29913B4", Offset = "0x29913B4", VA = "0x29913B4")]
		public static Quaternion LimitAngle(Quaternion rotation, Vector3 axis, Vector3 secondaryAxis, float limit, float twistLimit)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000258")]
		[Address(RVA = "0x299141C", Offset = "0x299141C", VA = "0x299141C")]
		public static Quaternion LimitSwing(Quaternion rotation, Vector3 axis, float limit)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000259")]
		[Address(RVA = "0x2991650", Offset = "0x2991650", VA = "0x2991650")]
		public static Quaternion LimitTwist(Quaternion rotation, Vector3 axis, Vector3 orthoAxis, float twistLimit)
		{
			return default(Quaternion);
		}
	}
	[Serializable]
	[Token(Token = "0x200004A")]
	public class FABRIKChain
	{
		[Token(Token = "0x40001DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public FABRIK ik;

		[Token(Token = "0x40001DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x14D1C40", Offset = "0x14D1C40")]
		public float pull;

		[Token(Token = "0x40001DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x14D1C58", Offset = "0x14D1C58")]
		public float pin;

		[Token(Token = "0x40001DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public int[] children;

		[Token(Token = "0x600025A")]
		[Address(RVA = "0x2B1DAD4", Offset = "0x2B1DAD4", VA = "0x2B1DAD4")]
		public bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x600025B")]
		[Address(RVA = "0x2B1DB9C", Offset = "0x2B1DB9C", VA = "0x2B1DB9C")]
		public void Initiate()
		{
		}

		[Token(Token = "0x600025C")]
		[Address(RVA = "0x2B1DBBC", Offset = "0x2B1DBBC", VA = "0x2B1DBBC")]
		public void Stage1(FABRIKChain[] chain)
		{
		}

		[Token(Token = "0x600025D")]
		[Address(RVA = "0x2B1DF8C", Offset = "0x2B1DF8C", VA = "0x2B1DF8C")]
		public void Stage2(Vector3 rootPosition, FABRIKChain[] chain)
		{
		}

		[Token(Token = "0x600025E")]
		[Address(RVA = "0x2B1DC90", Offset = "0x2B1DC90", VA = "0x2B1DC90")]
		private Vector3 GetCentroid(FABRIKChain[] chain)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600025F")]
		[Address(RVA = "0x2B1E084", Offset = "0x2B1E084", VA = "0x2B1E084")]
		public FABRIKChain()
		{
		}
	}
	[Token(Token = "0x200004B")]
	public class FBBIKArmBending : MonoBehaviour
	{
		[Token(Token = "0x40001DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x40001E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Vector3 bendDirectionOffsetLeft;

		[Token(Token = "0x40001E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public Vector3 bendDirectionOffsetRight;

		[Token(Token = "0x40001E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Vector3 characterSpaceBendOffsetLeft;

		[Token(Token = "0x40001E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public Vector3 characterSpaceBendOffsetRight;

		[Token(Token = "0x40001E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Quaternion leftHandTargetRotation;

		[Token(Token = "0x40001E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Quaternion rightHandTargetRotation;

		[Token(Token = "0x40001E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private bool initiated;

		[Token(Token = "0x6000260")]
		[Address(RVA = "0x2B1E28C", Offset = "0x2B1E28C", VA = "0x2B1E28C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000261")]
		[Address(RVA = "0x2B1E7F4", Offset = "0x2B1E7F4", VA = "0x2B1E7F4")]
		private void OnPostFBBIK()
		{
		}

		[Token(Token = "0x6000262")]
		[Address(RVA = "0x2B1E9B4", Offset = "0x2B1E9B4", VA = "0x2B1E9B4")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000263")]
		[Address(RVA = "0x2B1EAAC", Offset = "0x2B1EAAC", VA = "0x2B1EAAC")]
		public FBBIKArmBending()
		{
		}
	}
	[Token(Token = "0x200004C")]
	public class FBBIKHeadEffector : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000196")]
		public class BendBone
		{
			[Token(Token = "0x40009D4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D4734", Offset = "0x14D4734")]
			public Transform transform;

			[Token(Token = "0x40009D5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D476C", Offset = "0x14D476C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x14D476C", Offset = "0x14D476C")]
			public float weight;

			[Token(Token = "0x40009D6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			private Quaternion defaultLocalRotation;

			[Token(Token = "0x6000BEA")]
			[Address(RVA = "0x2B21ADC", Offset = "0x2B21ADC", VA = "0x2B21ADC")]
			public BendBone()
			{
			}

			[Token(Token = "0x6000BEB")]
			[Address(RVA = "0x2B21B5C", Offset = "0x2B21B5C", VA = "0x2B21B5C")]
			public BendBone(Transform transform, float weight)
			{
			}

			[Token(Token = "0x6000BEC")]
			[Address(RVA = "0x2B1F26C", Offset = "0x2B1F26C", VA = "0x2B1F26C")]
			public void StoreDefaultLocalState()
			{
			}

			[Token(Token = "0x6000BED")]
			[Address(RVA = "0x2B1F670", Offset = "0x2B1F670", VA = "0x2B1F670")]
			public void FixTransforms()
			{
			}
		}

		[Token(Token = "0x40001E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D1C70", Offset = "0x14D1C70")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x40001E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x14D1CA8", Offset = "0x14D1CA8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D1CA8", Offset = "0x14D1CA8")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x14D1CA8", Offset = "0x14D1CA8")]
		public float positionWeight;

		[Token(Token = "0x40001E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D1D20", Offset = "0x14D1D20")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x14D1D20", Offset = "0x14D1D20")]
		public float bodyWeight;

		[Token(Token = "0x40001EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D1D74", Offset = "0x14D1D74")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x14D1D74", Offset = "0x14D1D74")]
		public float thighWeight;

		[Token(Token = "0x40001EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D1DC8", Offset = "0x14D1DC8")]
		public bool handsPullBody;

		[Token(Token = "0x40001EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x14D1E00", Offset = "0x14D1E00")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D1E00", Offset = "0x14D1E00")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x14D1E00", Offset = "0x14D1E00")]
		public float rotationWeight;

		[Token(Token = "0x40001ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D1E78", Offset = "0x14D1E78")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x14D1E78", Offset = "0x14D1E78")]
		public float bodyClampWeight;

		[Token(Token = "0x40001EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D1ECC", Offset = "0x14D1ECC")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x14D1ECC", Offset = "0x14D1ECC")]
		public float headClampWeight;

		[Token(Token = "0x40001EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D1F20", Offset = "0x14D1F20")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x14D1F20", Offset = "0x14D1F20")]
		public float bendWeight;

		[Token(Token = "0x40001F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D1F74", Offset = "0x14D1F74")]
		public BendBone[] bendBones;

		[Token(Token = "0x40001F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x14D1FAC", Offset = "0x14D1FAC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D1FAC", Offset = "0x14D1FAC")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x14D1FAC", Offset = "0x14D1FAC")]
		public float CCDWeight;

		[Token(Token = "0x40001F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D2024", Offset = "0x14D2024")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x14D2024", Offset = "0x14D2024")]
		public float roll;

		[Token(Token = "0x40001F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D2078", Offset = "0x14D2078")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x14D2078", Offset = "0x14D2078")]
		public float damper;

		[Token(Token = "0x40001F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D20D0", Offset = "0x14D20D0")]
		public Transform[] CCDBones;

		[Token(Token = "0x40001F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x14D2108", Offset = "0x14D2108")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D2108", Offset = "0x14D2108")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x14D2108", Offset = "0x14D2108")]
		public float postStretchWeight;

		[Token(Token = "0x40001F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D2180", Offset = "0x14D2180")]
		public float maxStretch;

		[Token(Token = "0x40001F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D21B8", Offset = "0x14D21B8")]
		public float stretchDamper;

		[Token(Token = "0x40001F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D21F0", Offset = "0x14D21F0")]
		public bool fixHead;

		[Token(Token = "0x40001F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D2228", Offset = "0x14D2228")]
		public Transform[] stretchBones;

		[Token(Token = "0x40001FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x14D2260", Offset = "0x14D2260")]
		public Vector3 chestDirection;

		[Token(Token = "0x40001FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x14D2298", Offset = "0x14D2298")]
		public float chestDirectionWeight;

		[Token(Token = "0x40001FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public Transform[] chestBones;

		[Token(Token = "0x40001FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public IKSolver.UpdateDelegate OnPostHeadEffectorFK;

		[Token(Token = "0x40001FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Vector3 offset;

		[Token(Token = "0x40001FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		private Vector3 headToBody;

		[Token(Token = "0x4000200")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Vector3 shoulderCenterToHead;

		[Token(Token = "0x4000201")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		private Vector3 headToLeftThigh;

		[Token(Token = "0x4000202")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private Vector3 headToRightThigh;

		[Token(Token = "0x4000203")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		private Vector3 leftShoulderPos;

		[Token(Token = "0x4000204")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private Vector3 rightShoulderPos;

		[Token(Token = "0x4000205")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
		private float shoulderDist;

		[Token(Token = "0x4000206")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private float leftShoulderDist;

		[Token(Token = "0x4000207")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
		private float rightShoulderDist;

		[Token(Token = "0x4000208")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private Quaternion chestRotation;

		[Token(Token = "0x4000209")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private Quaternion headRotationRelativeToRoot;

		[Token(Token = "0x400020A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private Quaternion[] ccdDefaultLocalRotations;

		[Token(Token = "0x400020B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private Vector3 headLocalPosition;

		[Token(Token = "0x400020C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x12C")]
		private Quaternion headLocalRotation;

		[Token(Token = "0x400020D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		private Vector3[] stretchLocalPositions;

		[Token(Token = "0x400020E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		private Quaternion[] stretchLocalRotations;

		[Token(Token = "0x400020F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		private Vector3[] chestLocalPositions;

		[Token(Token = "0x4000210")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		private Quaternion[] chestLocalRotations;

		[Token(Token = "0x4000211")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		private int bendBonesCount;

		[Token(Token = "0x4000212")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x164")]
		private int ccdBonesCount;

		[Token(Token = "0x4000213")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		private int stretchBonesCount;

		[Token(Token = "0x4000214")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x16C")]
		private int chestBonesCount;

		[Token(Token = "0x6000264")]
		[Address(RVA = "0x2B1EAB4", Offset = "0x2B1EAB4", VA = "0x2B1EAB4")]
		private void Start()
		{
		}

		[Token(Token = "0x6000265")]
		[Address(RVA = "0x2B1EDE4", Offset = "0x2B1EDE4", VA = "0x2B1EDE4")]
		private void OnStoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000266")]
		[Address(RVA = "0x2B1F2A4", Offset = "0x2B1F2A4", VA = "0x2B1F2A4")]
		private void OnFixTransforms()
		{
		}

		[Token(Token = "0x6000267")]
		[Address(RVA = "0x2B1F698", Offset = "0x2B1F698", VA = "0x2B1F698")]
		private void OnPreRead()
		{
		}

		[Token(Token = "0x6000268")]
		[Address(RVA = "0x2B20010", Offset = "0x2B20010", VA = "0x2B20010")]
		private void SpineBend()
		{
		}

		[Token(Token = "0x6000269")]
		[Address(RVA = "0x2B2035C", Offset = "0x2B2035C", VA = "0x2B2035C")]
		private void CCDPass()
		{
		}

		[Token(Token = "0x600026A")]
		[Address(RVA = "0x2B206F8", Offset = "0x2B206F8", VA = "0x2B206F8")]
		private void Iterate(int iteration)
		{
		}

		[Token(Token = "0x600026B")]
		[Address(RVA = "0x2B21164", Offset = "0x2B21164", VA = "0x2B21164")]
		private void OnPostUpdate()
		{
		}

		[Token(Token = "0x600026C")]
		[Address(RVA = "0x2B1FD3C", Offset = "0x2B1FD3C", VA = "0x2B1FD3C")]
		private void ChestDirection()
		{
		}

		[Token(Token = "0x600026D")]
		[Address(RVA = "0x2B21374", Offset = "0x2B21374", VA = "0x2B21374")]
		private void PostStretching()
		{
		}

		[Token(Token = "0x600026E")]
		[Address(RVA = "0x2B21020", Offset = "0x2B21020", VA = "0x2B21020")]
		private void LerpSolverPosition(IKEffector effector, Vector3 position, float weight, Vector3 offset)
		{
		}

		[Token(Token = "0x600026F")]
		[Address(RVA = "0x2B20E84", Offset = "0x2B20E84", VA = "0x2B20E84")]
		private void Solve(ref Vector3 pos1, ref Vector3 pos2, float nominalDistance)
		{
		}

		[Token(Token = "0x6000270")]
		[Address(RVA = "0x2B216E0", Offset = "0x2B216E0", VA = "0x2B216E0")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000271")]
		[Address(RVA = "0x2B21960", Offset = "0x2B21960", VA = "0x2B21960")]
		public FBBIKHeadEffector()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200004D")]
	public class FBIKChain
	{
		[Serializable]
		[Token(Token = "0x2000197")]
		public class ChildConstraint
		{
			[Token(Token = "0x40009D7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float pushElasticity;

			[Token(Token = "0x40009D8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public float pullElasticity;

			[Token(Token = "0x40009D9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[SerializeField]
			private Transform bone1;

			[Token(Token = "0x40009DA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[SerializeField]
			private Transform bone2;

			[Token(Token = "0x40009DB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x14D47E0", Offset = "0x14D47E0")]
			private float <nominalDistance>k__BackingField;

			[Token(Token = "0x40009DC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x14D47F0", Offset = "0x14D47F0")]
			private bool <isRigid>k__BackingField;

			[Token(Token = "0x40009DD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private float crossFade;

			[Token(Token = "0x40009DE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private float inverseCrossFade;

			[Token(Token = "0x40009DF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private int chain1Index;

			[Token(Token = "0x40009E0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private int chain2Index;

			[Token(Token = "0x1700008B")]
			public float nominalDistance
			{
				[Token(Token = "0x6000BEE")]
				[Address(RVA = "0x2B24A20", Offset = "0x2B24A20", VA = "0x2B24A20")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x14D992C", Offset = "0x14D992C")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000BEF")]
				[Address(RVA = "0x2B24A28", Offset = "0x2B24A28", VA = "0x2B24A28")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x14D993C", Offset = "0x14D993C")]
				private set
				{
				}
			}

			[Token(Token = "0x1700008C")]
			public bool isRigid
			{
				[Token(Token = "0x6000BF0")]
				[Address(RVA = "0x2B24A30", Offset = "0x2B24A30", VA = "0x2B24A30")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x14D994C", Offset = "0x14D994C")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6000BF1")]
				[Address(RVA = "0x2B24A38", Offset = "0x2B24A38", VA = "0x2B24A38")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x14D995C", Offset = "0x14D995C")]
				private set
				{
				}
			}

			[Token(Token = "0x6000BF2")]
			[Address(RVA = "0x2B24A44", Offset = "0x2B24A44", VA = "0x2B24A44")]
			public ChildConstraint(Transform bone1, Transform bone2, float pushElasticity = 0f, float pullElasticity = 0f)
			{
			}

			[Token(Token = "0x6000BF3")]
			[Address(RVA = "0x2B227A4", Offset = "0x2B227A4", VA = "0x2B227A4")]
			public void Initiate(IKSolverFullBody solver)
			{
			}

			[Token(Token = "0x6000BF4")]
			[Address(RVA = "0x2B22CE4", Offset = "0x2B22CE4", VA = "0x2B22CE4")]
			public void OnPreSolve(IKSolverFullBody solver)
			{
			}

			[Token(Token = "0x6000BF5")]
			[Address(RVA = "0x2B2471C", Offset = "0x2B2471C", VA = "0x2B2471C")]
			public void Solve(IKSolverFullBody solver)
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000198")]
		public enum Smoothing
		{
			[Token(Token = "0x40009E2")]
			None,
			[Token(Token = "0x40009E3")]
			Exponential,
			[Token(Token = "0x40009E4")]
			Cubic
		}

		[Token(Token = "0x4000215")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x14D22B0", Offset = "0x14D22B0")]
		public float pin;

		[Token(Token = "0x4000216")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x14D22C8", Offset = "0x14D22C8")]
		public float pull;

		[Token(Token = "0x4000217")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x14D22E0", Offset = "0x14D22E0")]
		public float push;

		[Token(Token = "0x4000218")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x14D22F8", Offset = "0x14D22F8")]
		public float pushParent;

		[Token(Token = "0x4000219")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x14D2310", Offset = "0x14D2310")]
		public float reach;

		[Token(Token = "0x400021A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public Smoothing reachSmoothing;

		[Token(Token = "0x400021B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Smoothing pushSmoothing;

		[Token(Token = "0x400021C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public IKSolver.Node[] nodes;

		[Token(Token = "0x400021D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public int[] children;

		[Token(Token = "0x400021E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public ChildConstraint[] childConstraints;

		[Token(Token = "0x400021F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public IKConstraintBend bendConstraint;

		[Token(Token = "0x4000220")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private float rootLength;

		[Token(Token = "0x4000221")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private bool initiated;

		[Token(Token = "0x4000222")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private float length;

		[Token(Token = "0x4000223")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private float distance;

		[Token(Token = "0x4000224")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private IKSolver.Point p;

		[Token(Token = "0x4000225")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private float reachForce;

		[Token(Token = "0x4000226")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private float pullParentSum;

		[Token(Token = "0x4000227")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private float[] crossFades;

		[Token(Token = "0x4000228")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private float sqrMag1;

		[Token(Token = "0x4000229")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private float sqrMag2;

		[Token(Token = "0x400022A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private float sqrMagDif;

		[Token(Token = "0x400022B")]
		private const float maxLimbLength = 0.99999f;

		[Token(Token = "0x6000272")]
		[Address(RVA = "0x2B21C00", Offset = "0x2B21C00", VA = "0x2B21C00")]
		public FBIKChain()
		{
		}

		[Token(Token = "0x6000273")]
		[Address(RVA = "0x2B21CCC", Offset = "0x2B21CCC", VA = "0x2B21CCC")]
		public FBIKChain(float pin, float pull, params Transform[] nodeTransforms)
		{
		}

		[Token(Token = "0x6000274")]
		[Address(RVA = "0x2B21DD8", Offset = "0x2B21DD8", VA = "0x2B21DD8")]
		public void SetNodes(params Transform[] boneTransforms)
		{
		}

		[Token(Token = "0x6000275")]
		[Address(RVA = "0x2B21EFC", Offset = "0x2B21EFC", VA = "0x2B21EFC")]
		public int GetNodeIndex(Transform boneTransform)
		{
			return default(int);
		}

		[Token(Token = "0x6000276")]
		[Address(RVA = "0x2B21FD8", Offset = "0x2B21FD8", VA = "0x2B21FD8")]
		public bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000277")]
		[Address(RVA = "0x2B220DC", Offset = "0x2B220DC", VA = "0x2B220DC")]
		public void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000278")]
		[Address(RVA = "0x2B227FC", Offset = "0x2B227FC", VA = "0x2B227FC")]
		public void ReadPose(IKSolverFullBody solver, bool fullBody)
		{
		}

		[Token(Token = "0x6000279")]
		[Address(RVA = "0x2B2226C", Offset = "0x2B2226C", VA = "0x2B2226C")]
		private void CalculateBoneLengths(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x600027A")]
		[Address(RVA = "0x2B22EE8", Offset = "0x2B22EE8", VA = "0x2B22EE8")]
		public void Reach(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x600027B")]
		[Address(RVA = "0x2B2328C", Offset = "0x2B2328C", VA = "0x2B2328C")]
		public Vector3 Push(IKSolverFullBody solver)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600027C")]
		[Address(RVA = "0x2B23670", Offset = "0x2B23670", VA = "0x2B23670")]
		public void SolveTrigonometric(IKSolverFullBody solver, bool calculateBendDirection = false)
		{
		}

		[Token(Token = "0x600027D")]
		[Address(RVA = "0x2B23BF4", Offset = "0x2B23BF4", VA = "0x2B23BF4")]
		public void Stage1(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x600027E")]
		[Address(RVA = "0x2B241C4", Offset = "0x2B241C4", VA = "0x2B241C4")]
		public void Stage2(IKSolverFullBody solver, Vector3 position)
		{
		}

		[Token(Token = "0x600027F")]
		[Address(RVA = "0x2B2445C", Offset = "0x2B2445C", VA = "0x2B2445C")]
		public void SolveConstraintSystems(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000280")]
		[Address(RVA = "0x2B240BC", Offset = "0x2B240BC", VA = "0x2B240BC")]
		private Vector3 SolveFABRIKJoint(Vector3 pos1, Vector3 pos2, float length)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000281")]
		[Address(RVA = "0x2B239DC", Offset = "0x2B239DC", VA = "0x2B239DC")]
		protected Vector3 GetDirToBendPoint(Vector3 direction, Vector3 bendDirection, float directionMagnitude)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000282")]
		[Address(RVA = "0x2B24044", Offset = "0x2B24044", VA = "0x2B24044")]
		private void SolveChildConstraints(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000283")]
		[Address(RVA = "0x2B24544", Offset = "0x2B24544", VA = "0x2B24544")]
		private void SolveLinearConstraint(IKSolver.Node node1, IKSolver.Node node2, float crossFade, float distance)
		{
		}

		[Token(Token = "0x6000284")]
		[Address(RVA = "0x2B23F64", Offset = "0x2B23F64", VA = "0x2B23F64")]
		public void ForwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x6000285")]
		[Address(RVA = "0x2B24344", Offset = "0x2B24344", VA = "0x2B24344")]
		private void BackwardReach(Vector3 position)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200004E")]
	public class IKConstraintBend
	{
		[Token(Token = "0x400022C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform bone1;

		[Token(Token = "0x400022D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform bone2;

		[Token(Token = "0x400022E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform bone3;

		[Token(Token = "0x400022F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform bendGoal;

		[Token(Token = "0x4000230")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Vector3 direction;

		[Token(Token = "0x4000231")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public Quaternion rotationOffset;

		[Token(Token = "0x4000232")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x14D2328", Offset = "0x14D2328")]
		public float weight;

		[Token(Token = "0x4000233")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Vector3 defaultLocalDirection;

		[Token(Token = "0x4000234")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public Vector3 defaultChildDirection;

		[NonSerialized]
		[Token(Token = "0x4000235")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public float clampF;

		[Token(Token = "0x4000236")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private int chainIndex1;

		[Token(Token = "0x4000237")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private int nodeIndex1;

		[Token(Token = "0x4000238")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private int chainIndex2;

		[Token(Token = "0x4000239")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private int nodeIndex2;

		[Token(Token = "0x400023A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private int chainIndex3;

		[Token(Token = "0x400023B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private int nodeIndex3;

		[Token(Token = "0x400023C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x14D2340", Offset = "0x14D2340")]
		private bool <initiated>k__BackingField;

		[Token(Token = "0x400023D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x85")]
		private bool limbOrientationsSet;

		[Token(Token = "0x17000029")]
		public bool initiated
		{
			[Token(Token = "0x6000287")]
			[Address(RVA = "0x2D4E598", Offset = "0x2D4E598", VA = "0x2D4E598")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x14D8994", Offset = "0x14D8994")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000288")]
			[Address(RVA = "0x2D4E5A0", Offset = "0x2D4E5A0", VA = "0x2D4E5A0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x14D89A4", Offset = "0x14D89A4")]
			private set
			{
			}
		}

		[Token(Token = "0x6000286")]
		[Address(RVA = "0x2D4E3D0", Offset = "0x2D4E3D0", VA = "0x2D4E3D0")]
		public bool IsValid(IKSolverFullBody solver, Warning.Logger logger)
		{
			return default(bool);
		}

		[Token(Token = "0x6000289")]
		[Address(RVA = "0x2D4E5AC", Offset = "0x2D4E5AC", VA = "0x2D4E5AC")]
		public IKConstraintBend()
		{
		}

		[Token(Token = "0x600028A")]
		[Address(RVA = "0x2D4E630", Offset = "0x2D4E630", VA = "0x2D4E630")]
		public IKConstraintBend(Transform bone1, Transform bone2, Transform bone3)
		{
		}

		[Token(Token = "0x600028B")]
		[Address(RVA = "0x2D4E6DC", Offset = "0x2D4E6DC", VA = "0x2D4E6DC")]
		public void SetBones(Transform bone1, Transform bone2, Transform bone3)
		{
		}

		[Token(Token = "0x600028C")]
		[Address(RVA = "0x2D4E6E8", Offset = "0x2D4E6E8", VA = "0x2D4E6E8")]
		public void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x600028D")]
		[Address(RVA = "0x2D4EBD8", Offset = "0x2D4EBD8", VA = "0x2D4EBD8")]
		public void SetLimbOrientation(Vector3 upper, Vector3 lower, Vector3 last)
		{
		}

		[Token(Token = "0x600028E")]
		[Address(RVA = "0x2D4EE10", Offset = "0x2D4EE10", VA = "0x2D4EE10")]
		public void LimitBend(float solverWeight, float positionWeight)
		{
		}

		[Token(Token = "0x600028F")]
		[Address(RVA = "0x2D4F2AC", Offset = "0x2D4F2AC", VA = "0x2D4F2AC")]
		public Vector3 GetDir(IKSolverFullBody solver)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000290")]
		[Address(RVA = "0x2D4E998", Offset = "0x2D4E998", VA = "0x2D4E998")]
		private Vector3 OrthoToLimb(IKSolverFullBody solver, Vector3 tangent)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000291")]
		[Address(RVA = "0x2D4EAB8", Offset = "0x2D4EAB8", VA = "0x2D4EAB8")]
		private Vector3 OrthoToBone1(IKSolverFullBody solver, Vector3 tangent)
		{
			return default(Vector3);
		}
	}
	[Serializable]
	[Token(Token = "0x200004F")]
	public class IKEffector
	{
		[Token(Token = "0x400023E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform bone;

		[Token(Token = "0x400023F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform target;

		[Token(Token = "0x4000240")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x14D2350", Offset = "0x14D2350")]
		public float positionWeight;

		[Token(Token = "0x4000241")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x14D2368", Offset = "0x14D2368")]
		public float rotationWeight;

		[Token(Token = "0x4000242")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Vector3 position;

		[Token(Token = "0x4000243")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public Quaternion rotation;

		[Token(Token = "0x4000244")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public Vector3 positionOffset;

		[Token(Token = "0x4000245")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x14D2380", Offset = "0x14D2380")]
		private bool <isEndEffector>k__BackingField;

		[Token(Token = "0x4000246")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x51")]
		public bool effectChildNodes;

		[Token(Token = "0x4000247")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x14D2390", Offset = "0x14D2390")]
		public float maintainRelativePositionWeight;

		[Token(Token = "0x4000248")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform[] childBones;

		[Token(Token = "0x4000249")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Transform planeBone1;

		[Token(Token = "0x400024A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Transform planeBone2;

		[Token(Token = "0x400024B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Transform planeBone3;

		[Token(Token = "0x400024C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Quaternion planeRotationOffset;

		[Token(Token = "0x400024D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private float posW;

		[Token(Token = "0x400024E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private float rotW;

		[Token(Token = "0x400024F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Vector3[] localPositions;

		[Token(Token = "0x4000250")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private bool usePlaneNodes;

		[Token(Token = "0x4000251")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private Quaternion animatedPlaneRotation;

		[Token(Token = "0x4000252")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		private Vector3 animatedPosition;

		[Token(Token = "0x4000253")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private bool firstUpdate;

		[Token(Token = "0x4000254")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		private int chainIndex;

		[Token(Token = "0x4000255")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private int nodeIndex;

		[Token(Token = "0x4000256")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private int plane1ChainIndex;

		[Token(Token = "0x4000257")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private int plane1NodeIndex;

		[Token(Token = "0x4000258")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		private int plane2ChainIndex;

		[Token(Token = "0x4000259")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private int plane2NodeIndex;

		[Token(Token = "0x400025A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		private int plane3ChainIndex;

		[Token(Token = "0x400025B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private int plane3NodeIndex;

		[Token(Token = "0x400025C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private int[] childChainIndexes;

		[Token(Token = "0x400025D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private int[] childNodeIndexes;

		[Token(Token = "0x1700002A")]
		public bool isEndEffector
		{
			[Token(Token = "0x6000293")]
			[Address(RVA = "0x2D4F918", Offset = "0x2D4F918", VA = "0x2D4F918")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x14D89B4", Offset = "0x14D89B4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000294")]
			[Address(RVA = "0x2D4F920", Offset = "0x2D4F920", VA = "0x2D4F920")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x14D89C4", Offset = "0x14D89C4")]
			private set
			{
			}
		}

		[Token(Token = "0x6000292")]
		[Address(RVA = "0x2D4F8B0", Offset = "0x2D4F8B0", VA = "0x2D4F8B0")]
		public IKSolver.Node GetNode(IKSolverFullBody solver)
		{
			return null;
		}

		[Token(Token = "0x6000295")]
		[Address(RVA = "0x2D4F92C", Offset = "0x2D4F92C", VA = "0x2D4F92C")]
		public void PinToBone(float positionWeight, float rotationWeight)
		{
		}

		[Token(Token = "0x6000296")]
		[Address(RVA = "0x2D4FA00", Offset = "0x2D4FA00", VA = "0x2D4FA00")]
		public IKEffector()
		{
		}

		[Token(Token = "0x6000297")]
		[Address(RVA = "0x2D4FB3C", Offset = "0x2D4FB3C", VA = "0x2D4FB3C")]
		public IKEffector(Transform bone, Transform[] childBones)
		{
		}

		[Token(Token = "0x6000298")]
		[Address(RVA = "0x2D4FC94", Offset = "0x2D4FC94", VA = "0x2D4FC94")]
		public bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000299")]
		[Address(RVA = "0x2D4FF84", Offset = "0x2D4FF84", VA = "0x2D4FF84")]
		public void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x600029A")]
		[Address(RVA = "0x2D50224", Offset = "0x2D50224", VA = "0x2D50224")]
		public void ResetOffset(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x600029B")]
		[Address(RVA = "0x2D50364", Offset = "0x2D50364", VA = "0x2D50364")]
		public void SetToTarget()
		{
		}

		[Token(Token = "0x600029C")]
		[Address(RVA = "0x2D50410", Offset = "0x2D50410", VA = "0x2D50410")]
		public void OnPreSolve(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x600029D")]
		[Address(RVA = "0x2D50A64", Offset = "0x2D50A64", VA = "0x2D50A64")]
		public void OnPostWrite()
		{
		}

		[Token(Token = "0x600029E")]
		[Address(RVA = "0x2D50AD4", Offset = "0x2D50AD4", VA = "0x2D50AD4")]
		private Quaternion GetPlaneRotation(IKSolverFullBody solver)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600029F")]
		[Address(RVA = "0x2D50CEC", Offset = "0x2D50CEC", VA = "0x2D50CEC")]
		public void Update(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60002A0")]
		[Address(RVA = "0x2D51034", Offset = "0x2D51034", VA = "0x2D51034")]
		private Vector3 GetPosition(IKSolverFullBody solver, out Quaternion planeRotationOffset)
		{
			return default(Vector3);
		}
	}
	[Serializable]
	[Token(Token = "0x2000050")]
	public class IKMapping
	{
		[Serializable]
		[Token(Token = "0x2000199")]
		public class BoneMap
		{
			[Token(Token = "0x40009E5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform transform;

			[Token(Token = "0x40009E6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public int chainIndex;

			[Token(Token = "0x40009E7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public int nodeIndex;

			[Token(Token = "0x40009E8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Vector3 defaultLocalPosition;

			[Token(Token = "0x40009E9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public Quaternion defaultLocalRotation;

			[Token(Token = "0x40009EA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public Vector3 localSwingAxis;

			[Token(Token = "0x40009EB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public Vector3 localTwistAxis;

			[Token(Token = "0x40009EC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			public Vector3 planePosition;

			[Token(Token = "0x40009ED")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			public Vector3 ikPosition;

			[Token(Token = "0x40009EE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
			public Quaternion defaultLocalTargetRotation;

			[Token(Token = "0x40009EF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
			private Quaternion maintainRotation;

			[Token(Token = "0x40009F0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
			public float length;

			[Token(Token = "0x40009F1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			public Quaternion animatedRotation;

			[Token(Token = "0x40009F2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			private Transform planeBone1;

			[Token(Token = "0x40009F3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
			private Transform planeBone2;

			[Token(Token = "0x40009F4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
			private Transform planeBone3;

			[Token(Token = "0x40009F5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
			private int plane1ChainIndex;

			[Token(Token = "0x40009F6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
			private int plane1NodeIndex;

			[Token(Token = "0x40009F7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
			private int plane2ChainIndex;

			[Token(Token = "0x40009F8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
			private int plane2NodeIndex;

			[Token(Token = "0x40009F9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
			private int plane3ChainIndex;

			[Token(Token = "0x40009FA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
			private int plane3NodeIndex;

			[Token(Token = "0x1700008D")]
			public Vector3 swingDirection
			{
				[Token(Token = "0x6000BF7")]
				[Address(RVA = "0x2D51824", Offset = "0x2D51824", VA = "0x2D51824")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x1700008E")]
			public bool isNodeBone
			{
				[Token(Token = "0x6000BFA")]
				[Address(RVA = "0x2D51990", Offset = "0x2D51990", VA = "0x2D51990")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x1700008F")]
			private Quaternion lastAnimatedTargetRotation
			{
				[Token(Token = "0x6000C0E")]
				[Address(RVA = "0x2D51F74", Offset = "0x2D51F74", VA = "0x2D51F74")]
				get
				{
					return default(Quaternion);
				}
			}

			[Token(Token = "0x6000BF6")]
			[Address(RVA = "0x2D517F8", Offset = "0x2D517F8", VA = "0x2D517F8")]
			public void Initiate(Transform transform, IKSolverFullBody solver)
			{
			}

			[Token(Token = "0x6000BF8")]
			[Address(RVA = "0x2D518F0", Offset = "0x2D518F0", VA = "0x2D518F0")]
			public void StoreDefaultLocalState()
			{
			}

			[Token(Token = "0x6000BF9")]
			[Address(RVA = "0x2D51940", Offset = "0x2D51940", VA = "0x2D51940")]
			public void FixTransform(bool position)
			{
			}

			[Token(Token = "0x6000BFB")]
			[Address(RVA = "0x2D519A0", Offset = "0x2D519A0", VA = "0x2D519A0")]
			public void SetLength(BoneMap nextBone)
			{
			}

			[Token(Token = "0x6000BFC")]
			[Address(RVA = "0x2D51A88", Offset = "0x2D51A88", VA = "0x2D51A88")]
			public void SetLocalSwingAxis(BoneMap swingTarget)
			{
			}

			[Token(Token = "0x6000BFD")]
			[Address(RVA = "0x2D51A90", Offset = "0x2D51A90", VA = "0x2D51A90")]
			public void SetLocalSwingAxis(BoneMap bone1, BoneMap bone2)
			{
			}

			[Token(Token = "0x6000BFE")]
			[Address(RVA = "0x2D51C20", Offset = "0x2D51C20", VA = "0x2D51C20")]
			public void SetLocalTwistAxis(Vector3 twistDirection, Vector3 normalDirection)
			{
			}

			[Token(Token = "0x6000BFF")]
			[Address(RVA = "0x2D51D2C", Offset = "0x2D51D2C", VA = "0x2D51D2C")]
			public void SetPlane(IKSolverFullBody solver, Transform planeBone1, Transform planeBone2, Transform planeBone3)
			{
			}

			[Token(Token = "0x6000C00")]
			[Address(RVA = "0x2D51DC4", Offset = "0x2D51DC4", VA = "0x2D51DC4")]
			public void UpdatePlane(bool rotation, bool position)
			{
			}

			[Token(Token = "0x6000C01")]
			[Address(RVA = "0x2D52198", Offset = "0x2D52198", VA = "0x2D52198")]
			public void SetIKPosition()
			{
			}

			[Token(Token = "0x6000C02")]
			[Address(RVA = "0x2D521D0", Offset = "0x2D521D0", VA = "0x2D521D0")]
			public void MaintainRotation()
			{
			}

			[Token(Token = "0x6000C03")]
			[Address(RVA = "0x2D52208", Offset = "0x2D52208", VA = "0x2D52208")]
			public void SetToIKPosition()
			{
			}

			[Token(Token = "0x6000C04")]
			[Address(RVA = "0x2D52230", Offset = "0x2D52230", VA = "0x2D52230")]
			public void FixToNode(IKSolverFullBody solver, float weight, [Optional] IKSolver.Node fixNode)
			{
			}

			[Token(Token = "0x6000C05")]
			[Address(RVA = "0x2D5235C", Offset = "0x2D5235C", VA = "0x2D5235C")]
			public Vector3 GetPlanePosition(IKSolverFullBody solver)
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000C06")]
			[Address(RVA = "0x2D526A4", Offset = "0x2D526A4", VA = "0x2D526A4")]
			public void PositionToPlane(IKSolverFullBody solver)
			{
			}

			[Token(Token = "0x6000C07")]
			[Address(RVA = "0x2D526D4", Offset = "0x2D526D4", VA = "0x2D526D4")]
			public void RotateToPlane(IKSolverFullBody solver, float weight)
			{
			}

			[Token(Token = "0x6000C08")]
			[Address(RVA = "0x2D5286C", Offset = "0x2D5286C", VA = "0x2D5286C")]
			public void Swing(Vector3 swingTarget, float weight)
			{
			}

			[Token(Token = "0x6000C09")]
			[Address(RVA = "0x2D528DC", Offset = "0x2D528DC", VA = "0x2D528DC")]
			public void Swing(Vector3 pos1, Vector3 pos2, float weight)
			{
			}

			[Token(Token = "0x6000C0A")]
			[Address(RVA = "0x2D52B20", Offset = "0x2D52B20", VA = "0x2D52B20")]
			public void Twist(Vector3 twistDirection, Vector3 normalDirection, float weight)
			{
			}

			[Token(Token = "0x6000C0B")]
			[Address(RVA = "0x2D52D48", Offset = "0x2D52D48", VA = "0x2D52D48")]
			public void RotateToMaintain(float weight)
			{
			}

			[Token(Token = "0x6000C0C")]
			[Address(RVA = "0x2D52E60", Offset = "0x2D52E60", VA = "0x2D52E60")]
			public void RotateToEffector(IKSolverFullBody solver, float weight)
			{
			}

			[Token(Token = "0x6000C0D")]
			[Address(RVA = "0x2D524A0", Offset = "0x2D524A0", VA = "0x2D524A0")]
			private Quaternion GetTargetRotation(IKSolverFullBody solver)
			{
				return default(Quaternion);
			}

			[Token(Token = "0x6000C0F")]
			[Address(RVA = "0x2D52FFC", Offset = "0x2D52FFC", VA = "0x2D52FFC")]
			public BoneMap()
			{
			}
		}

		[Token(Token = "0x60002A1")]
		[Address(RVA = "0x2D515B8", Offset = "0x2D515B8", VA = "0x2D515B8", Slot = "4")]
		public virtual bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60002A2")]
		[Address(RVA = "0x2D515C0", Offset = "0x2D515C0", VA = "0x2D515C0", Slot = "5")]
		public virtual void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60002A3")]
		[Address(RVA = "0x2D515C4", Offset = "0x2D515C4", VA = "0x2D515C4")]
		protected bool BoneIsValid(Transform bone, IKSolver solver, ref string message, [Optional] Warning.Logger logger)
		{
			return default(bool);
		}

		[Token(Token = "0x60002A4")]
		[Address(RVA = "0x2D516E8", Offset = "0x2D516E8", VA = "0x2D516E8")]
		protected Vector3 SolveFABRIKJoint(Vector3 pos1, Vector3 pos2, float length)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002A5")]
		[Address(RVA = "0x2D517F0", Offset = "0x2D517F0", VA = "0x2D517F0")]
		public IKMapping()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000051")]
	public class IKMappingBone : IKMapping
	{
		[Token(Token = "0x400025E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform bone;

		[Token(Token = "0x400025F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x14D23A8", Offset = "0x14D23A8")]
		public float maintainRotationWeight;

		[Token(Token = "0x4000260")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private BoneMap boneMap;

		[Token(Token = "0x60002A6")]
		[Address(RVA = "0x2D53018", Offset = "0x2D53018", VA = "0x2D53018", Slot = "4")]
		public override bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60002A7")]
		[Address(RVA = "0x2D530B8", Offset = "0x2D530B8", VA = "0x2D530B8")]
		public IKMappingBone()
		{
		}

		[Token(Token = "0x60002A8")]
		[Address(RVA = "0x2D5313C", Offset = "0x2D5313C", VA = "0x2D5313C")]
		public IKMappingBone(Transform bone)
		{
		}

		[Token(Token = "0x60002A9")]
		[Address(RVA = "0x2D531D4", Offset = "0x2D531D4", VA = "0x2D531D4")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60002AA")]
		[Address(RVA = "0x2D531EC", Offset = "0x2D531EC", VA = "0x2D531EC")]
		public void FixTransforms()
		{
		}

		[Token(Token = "0x60002AB")]
		[Address(RVA = "0x2D53208", Offset = "0x2D53208", VA = "0x2D53208", Slot = "5")]
		public override void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60002AC")]
		[Address(RVA = "0x2D532A4", Offset = "0x2D532A4", VA = "0x2D532A4")]
		public void ReadPose()
		{
		}

		[Token(Token = "0x60002AD")]
		[Address(RVA = "0x2D532BC", Offset = "0x2D532BC", VA = "0x2D532BC")]
		public void WritePose(float solverWeight)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000052")]
	public class IKMappingLimb : IKMapping
	{
		[Serializable]
		[Token(Token = "0x200019A")]
		public enum BoneMapType
		{
			[Token(Token = "0x40009FC")]
			Parent,
			[Token(Token = "0x40009FD")]
			Bone1,
			[Token(Token = "0x40009FE")]
			Bone2,
			[Token(Token = "0x40009FF")]
			Bone3
		}

		[Token(Token = "0x4000261")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform parentBone;

		[Token(Token = "0x4000262")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform bone1;

		[Token(Token = "0x4000263")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform bone2;

		[Token(Token = "0x4000264")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform bone3;

		[Token(Token = "0x4000265")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x14D23C0", Offset = "0x14D23C0")]
		public float maintainRotationWeight;

		[Token(Token = "0x4000266")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x14D23D8", Offset = "0x14D23D8")]
		public float weight;

		[NonSerialized]
		[Token(Token = "0x4000267")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public bool updatePlaneRotations;

		[Token(Token = "0x4000268")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private BoneMap boneMapParent;

		[Token(Token = "0x4000269")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private BoneMap boneMap1;

		[Token(Token = "0x400026A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private BoneMap boneMap2;

		[Token(Token = "0x400026B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private BoneMap boneMap3;

		[Token(Token = "0x60002AE")]
		[Address(RVA = "0x2D532E0", Offset = "0x2D532E0", VA = "0x2D532E0", Slot = "4")]
		public override bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60002AF")]
		[Address(RVA = "0x2D53364", Offset = "0x2D53364", VA = "0x2D53364")]
		public BoneMap GetBoneMap(BoneMapType boneMap)
		{
			return null;
		}

		[Token(Token = "0x60002B0")]
		[Address(RVA = "0x2D53438", Offset = "0x2D53438", VA = "0x2D53438")]
		public void SetLimbOrientation(Vector3 upper, Vector3 lower)
		{
		}

		[Token(Token = "0x60002B1")]
		[Address(RVA = "0x2D5378C", Offset = "0x2D5378C", VA = "0x2D5378C")]
		public IKMappingLimb()
		{
		}

		[Token(Token = "0x60002B2")]
		[Address(RVA = "0x2D53894", Offset = "0x2D53894", VA = "0x2D53894")]
		public IKMappingLimb(Transform bone1, Transform bone2, Transform bone3, [Optional] Transform parentBone)
		{
		}

		[Token(Token = "0x60002B3")]
		[Address(RVA = "0x2D539C8", Offset = "0x2D539C8", VA = "0x2D539C8")]
		public void SetBones(Transform bone1, Transform bone2, Transform bone3, [Optional] Transform parentBone)
		{
		}

		[Token(Token = "0x60002B4")]
		[Address(RVA = "0x2D539D4", Offset = "0x2D539D4", VA = "0x2D539D4")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60002B5")]
		[Address(RVA = "0x2D53A7C", Offset = "0x2D53A7C", VA = "0x2D53A7C")]
		public void FixTransforms()
		{
		}

		[Token(Token = "0x60002B6")]
		[Address(RVA = "0x2D53B34", Offset = "0x2D53B34", VA = "0x2D53B34", Slot = "5")]
		public override void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60002B7")]
		[Address(RVA = "0x2D53DA4", Offset = "0x2D53DA4", VA = "0x2D53DA4")]
		public void ReadPose()
		{
		}

		[Token(Token = "0x60002B8")]
		[Address(RVA = "0x2D53E5C", Offset = "0x2D53E5C", VA = "0x2D53E5C")]
		public void WritePose(IKSolverFullBody solver, bool fullBody)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000053")]
	public class IKMappingSpine : IKMapping
	{
		[Token(Token = "0x400026C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform[] spineBones;

		[Token(Token = "0x400026D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform leftUpperArmBone;

		[Token(Token = "0x400026E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform rightUpperArmBone;

		[Token(Token = "0x400026F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform leftThighBone;

		[Token(Token = "0x4000270")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Transform rightThighBone;

		[Token(Token = "0x4000271")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x14D23F0", Offset = "0x14D23F0")]
		public int iterations;

		[Token(Token = "0x4000272")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x14D2408", Offset = "0x14D2408")]
		public float twistWeight;

		[Token(Token = "0x4000273")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private int rootNodeIndex;

		[Token(Token = "0x4000274")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private BoneMap[] spine;

		[Token(Token = "0x4000275")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private BoneMap leftUpperArm;

		[Token(Token = "0x4000276")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private BoneMap rightUpperArm;

		[Token(Token = "0x4000277")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private BoneMap leftThigh;

		[Token(Token = "0x4000278")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private BoneMap rightThigh;

		[Token(Token = "0x4000279")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private bool useFABRIK;

		[Token(Token = "0x60002B9")]
		[Address(RVA = "0x2D53FC8", Offset = "0x2D53FC8", VA = "0x2D53FC8", Slot = "4")]
		public override bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60002BA")]
		[Address(RVA = "0x2D542B8", Offset = "0x2D542B8", VA = "0x2D542B8")]
		public IKMappingSpine()
		{
		}

		[Token(Token = "0x60002BB")]
		[Address(RVA = "0x2D543D4", Offset = "0x2D543D4", VA = "0x2D543D4")]
		public IKMappingSpine(Transform[] spineBones, Transform leftUpperArmBone, Transform rightUpperArmBone, Transform leftThighBone, Transform rightThighBone)
		{
		}

		[Token(Token = "0x60002BC")]
		[Address(RVA = "0x2D5452C", Offset = "0x2D5452C", VA = "0x2D5452C")]
		public void SetBones(Transform[] spineBones, Transform leftUpperArmBone, Transform rightUpperArmBone, Transform leftThighBone, Transform rightThighBone)
		{
		}

		[Token(Token = "0x60002BD")]
		[Address(RVA = "0x2D5453C", Offset = "0x2D5453C", VA = "0x2D5453C")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60002BE")]
		[Address(RVA = "0x2D545A4", Offset = "0x2D545A4", VA = "0x2D545A4")]
		public void FixTransforms()
		{
		}

		[Token(Token = "0x60002BF")]
		[Address(RVA = "0x2D54624", Offset = "0x2D54624", VA = "0x2D54624", Slot = "5")]
		public override void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60002C0")]
		[Address(RVA = "0x2D54C78", Offset = "0x2D54C78", VA = "0x2D54C78")]
		private bool UseFABRIK()
		{
			return default(bool);
		}

		[Token(Token = "0x60002C1")]
		[Address(RVA = "0x2D54CB0", Offset = "0x2D54CB0", VA = "0x2D54CB0")]
		public void ReadPose()
		{
		}

		[Token(Token = "0x60002C2")]
		[Address(RVA = "0x2D54F90", Offset = "0x2D54F90", VA = "0x2D54F90")]
		public void WritePose(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60002C3")]
		[Address(RVA = "0x2D55344", Offset = "0x2D55344", VA = "0x2D55344")]
		public void ForwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x60002C4")]
		[Address(RVA = "0x2D55430", Offset = "0x2D55430", VA = "0x2D55430")]
		private void BackwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x60002C5")]
		[Address(RVA = "0x2D554F8", Offset = "0x2D554F8", VA = "0x2D554F8")]
		private void MapToSolverPositions(IKSolverFullBody solver)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000054")]
	public abstract class IKSolver
	{
		[Serializable]
		[Token(Token = "0x200019B")]
		public class Point
		{
			[Token(Token = "0x4000A00")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform transform;

			[Token(Token = "0x4000A01")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x14D4800", Offset = "0x14D4800")]
			public float weight;

			[Token(Token = "0x4000A02")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public Vector3 solverPosition;

			[Token(Token = "0x4000A03")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Quaternion solverRotation;

			[Token(Token = "0x4000A04")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Vector3 defaultLocalPosition;

			[Token(Token = "0x4000A05")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			public Quaternion defaultLocalRotation;

			[Token(Token = "0x6000C10")]
			[Address(RVA = "0x2D56E14", Offset = "0x2D56E14", VA = "0x2D56E14")]
			public void StoreDefaultLocalState()
			{
			}

			[Token(Token = "0x6000C11")]
			[Address(RVA = "0x2D56E64", Offset = "0x2D56E64", VA = "0x2D56E64")]
			public void FixTransform()
			{
			}

			[Token(Token = "0x6000C12")]
			[Address(RVA = "0x2D56FEC", Offset = "0x2D56FEC", VA = "0x2D56FEC")]
			public void UpdateSolverPosition()
			{
			}

			[Token(Token = "0x6000C13")]
			[Address(RVA = "0x2D57024", Offset = "0x2D57024", VA = "0x2D57024")]
			public void UpdateSolverLocalPosition()
			{
			}

			[Token(Token = "0x6000C14")]
			[Address(RVA = "0x2D5705C", Offset = "0x2D5705C", VA = "0x2D5705C")]
			public void UpdateSolverState()
			{
			}

			[Token(Token = "0x6000C15")]
			[Address(RVA = "0x2D570AC", Offset = "0x2D570AC", VA = "0x2D570AC")]
			public void UpdateSolverLocalState()
			{
			}

			[Token(Token = "0x6000C16")]
			[Address(RVA = "0x2D568E8", Offset = "0x2D568E8", VA = "0x2D568E8")]
			public Point()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200019C")]
		public class Bone : Point
		{
			[Token(Token = "0x4000A06")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			public float length;

			[Token(Token = "0x4000A07")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public float sqrMag;

			[Token(Token = "0x4000A08")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			public Vector3 axis;

			[Token(Token = "0x4000A09")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			private RotationLimit _rotationLimit;

			[Token(Token = "0x4000A0A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			private bool isLimited;

			[Token(Token = "0x17000090")]
			public RotationLimit rotationLimit
			{
				[Token(Token = "0x6000C17")]
				[Address(RVA = "0x2D55EB8", Offset = "0x2D55EB8", VA = "0x2D55EB8")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000C18")]
				[Address(RVA = "0x2D55FAC", Offset = "0x2D55FAC", VA = "0x2D55FAC")]
				set
				{
				}
			}

			[Token(Token = "0x6000C19")]
			[Address(RVA = "0x2D56034", Offset = "0x2D56034", VA = "0x2D56034")]
			public void Swing(Vector3 swingTarget, float weight = 1f)
			{
			}

			[Token(Token = "0x6000C1A")]
			[Address(RVA = "0x2D562F4", Offset = "0x2D562F4", VA = "0x2D562F4")]
			public static void SolverSwing(Bone[] bones, int index, Vector3 swingTarget, float weight = 1f)
			{
			}

			[Token(Token = "0x6000C1B")]
			[Address(RVA = "0x2D565D4", Offset = "0x2D565D4", VA = "0x2D565D4")]
			public void Swing2D(Vector3 swingTarget, float weight = 1f)
			{
			}

			[Token(Token = "0x6000C1C")]
			[Address(RVA = "0x2D5683C", Offset = "0x2D5683C", VA = "0x2D5683C")]
			public void SetToSolverPosition()
			{
			}

			[Token(Token = "0x6000C1D")]
			[Address(RVA = "0x2D56864", Offset = "0x2D56864", VA = "0x2D56864")]
			public Bone()
			{
			}

			[Token(Token = "0x6000C1E")]
			[Address(RVA = "0x2D56968", Offset = "0x2D56968", VA = "0x2D56968")]
			public Bone(Transform transform)
			{
			}

			[Token(Token = "0x6000C1F")]
			[Address(RVA = "0x2D56A00", Offset = "0x2D56A00", VA = "0x2D56A00")]
			public Bone(Transform transform, float weight)
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200019D")]
		public class Node : Point
		{
			[Token(Token = "0x4000A0B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			public float length;

			[Token(Token = "0x4000A0C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public float effectorPositionWeight;

			[Token(Token = "0x4000A0D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			public float effectorRotationWeight;

			[Token(Token = "0x4000A0E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			public Vector3 offset;

			[Token(Token = "0x6000C20")]
			[Address(RVA = "0x2D56DB0", Offset = "0x2D56DB0", VA = "0x2D56DB0")]
			public Node()
			{
			}

			[Token(Token = "0x6000C21")]
			[Address(RVA = "0x2D56DB4", Offset = "0x2D56DB4", VA = "0x2D56DB4")]
			public Node(Transform transform)
			{
			}

			[Token(Token = "0x6000C22")]
			[Address(RVA = "0x2D56DDC", Offset = "0x2D56DDC", VA = "0x2D56DDC")]
			public Node(Transform transform, float weight)
			{
			}
		}

		[Token(Token = "0x200019E")]
		public delegate void UpdateDelegate();

		[Token(Token = "0x200019F")]
		public delegate void IterationDelegate(int i);

		[Token(Token = "0x400027A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[HideInInspector]
		public Vector3 IKPosition;

		[Token(Token = "0x400027B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D2430", Offset = "0x14D2430")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x14D2430", Offset = "0x14D2430")]
		public float IKPositionWeight;

		[Token(Token = "0x400027C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x14D2484", Offset = "0x14D2484")]
		private bool <initiated>k__BackingField;

		[Token(Token = "0x400027D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public UpdateDelegate OnPreInitiate;

		[Token(Token = "0x400027E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public UpdateDelegate OnPostInitiate;

		[Token(Token = "0x400027F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public UpdateDelegate OnPreUpdate;

		[Token(Token = "0x4000280")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public UpdateDelegate OnPostUpdate;

		[Token(Token = "0x4000281")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		protected bool firstInitiation;

		[Token(Token = "0x4000282")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		[HideInInspector]
		protected Transform root;

		[Token(Token = "0x1700002B")]
		public bool initiated
		{
			[Token(Token = "0x60002CF")]
			[Address(RVA = "0x2D55908", Offset = "0x2D55908", VA = "0x2D55908")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x14D89D4", Offset = "0x14D89D4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60002D0")]
			[Address(RVA = "0x2D55910", Offset = "0x2D55910", VA = "0x2D55910")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x14D89E4", Offset = "0x14D89E4")]
			private set
			{
			}
		}

		[Token(Token = "0x60002C6")]
		[Address(RVA = "0x2D557E0", Offset = "0x2D557E0", VA = "0x2D557E0")]
		public bool IsValid()
		{
			return default(bool);
		}

		[Token(Token = "0x60002C7")]
		public abstract bool IsValid(ref string message);

		[Token(Token = "0x60002C8")]
		[Address(RVA = "0x2D4E21C", Offset = "0x2D4E21C", VA = "0x2D4E21C")]
		public void Initiate(Transform root)
		{
		}

		[Token(Token = "0x60002C9")]
		[Address(RVA = "0x2D4E13C", Offset = "0x2D4E13C", VA = "0x2D4E13C")]
		public void Update()
		{
		}

		[Token(Token = "0x60002CA")]
		[Address(RVA = "0x2D5585C", Offset = "0x2D5585C", VA = "0x2D5585C", Slot = "5")]
		public virtual Vector3 GetIKPosition()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002CB")]
		[Address(RVA = "0x2D55868", Offset = "0x2D55868", VA = "0x2D55868")]
		public void SetIKPosition(Vector3 position)
		{
		}

		[Token(Token = "0x60002CC")]
		[Address(RVA = "0x2D55874", Offset = "0x2D55874", VA = "0x2D55874")]
		public float GetIKPositionWeight()
		{
			return default(float);
		}

		[Token(Token = "0x60002CD")]
		[Address(RVA = "0x2D5587C", Offset = "0x2D5587C", VA = "0x2D5587C")]
		public void SetIKPositionWeight(float weight)
		{
		}

		[Token(Token = "0x60002CE")]
		[Address(RVA = "0x2D55900", Offset = "0x2D55900", VA = "0x2D55900")]
		public Transform GetRoot()
		{
			return null;
		}

		[Token(Token = "0x60002D1")]
		public abstract Point[] GetPoints();

		[Token(Token = "0x60002D2")]
		public abstract Point GetPoint(Transform transform);

		[Token(Token = "0x60002D3")]
		public abstract void FixTransforms();

		[Token(Token = "0x60002D4")]
		public abstract void StoreDefaultLocalState();

		[Token(Token = "0x60002D5")]
		protected abstract void OnInitiate();

		[Token(Token = "0x60002D6")]
		protected abstract void OnUpdate();

		[Token(Token = "0x60002D7")]
		[Address(RVA = "0x2D5591C", Offset = "0x2D5591C", VA = "0x2D5591C")]
		protected void LogWarning(string message)
		{
		}

		[Token(Token = "0x60002D8")]
		[Address(RVA = "0x2D55934", Offset = "0x2D55934", VA = "0x2D55934")]
		public static Transform ContainsDuplicateBone(Bone[] bones)
		{
			return null;
		}

		[Token(Token = "0x60002D9")]
		[Address(RVA = "0x2D55A70", Offset = "0x2D55A70", VA = "0x2D55A70")]
		public static bool HierarchyIsValid(Bone[] bones)
		{
			return default(bool);
		}

		[Token(Token = "0x60002DA")]
		[Address(RVA = "0x2D55B1C", Offset = "0x2D55B1C", VA = "0x2D55B1C")]
		protected static float PreSolveBones(ref Bone[] bones)
		{
			return default(float);
		}

		[Token(Token = "0x60002DB")]
		[Address(RVA = "0x2D55EA0", Offset = "0x2D55EA0", VA = "0x2D55EA0")]
		protected IKSolver()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000055")]
	public class IKSolverAim : IKSolverHeuristic
	{
		[Token(Token = "0x4000283")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public Transform transform;

		[Token(Token = "0x4000284")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public Vector3 axis;

		[Token(Token = "0x4000285")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		public Vector3 poleAxis;

		[Token(Token = "0x4000286")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public Vector3 polePosition;

		[Token(Token = "0x4000287")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x14D24CC", Offset = "0x14D24CC")]
		public float poleWeight;

		[Token(Token = "0x4000288")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public Transform poleTarget;

		[Token(Token = "0x4000289")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x14D24E4", Offset = "0x14D24E4")]
		public float clampWeight;

		[Token(Token = "0x400028A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x14D24FC", Offset = "0x14D24FC")]
		public int clampSmoothing;

		[Token(Token = "0x400028B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public IterationDelegate OnPreIteration;

		[Token(Token = "0x400028C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private float step;

		[Token(Token = "0x400028D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		private Vector3 clampedIKPosition;

		[Token(Token = "0x400028E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private RotationLimit transformLimit;

		[Token(Token = "0x400028F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private Transform lastTransform;

		[Token(Token = "0x1700002C")]
		public Vector3 transformAxis
		{
			[Token(Token = "0x60002DD")]
			[Address(RVA = "0x2CB2380", Offset = "0x2CB2380", VA = "0x2CB2380")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x1700002D")]
		public Vector3 transformPoleAxis
		{
			[Token(Token = "0x60002DE")]
			[Address(RVA = "0x2CB244C", Offset = "0x2CB244C", VA = "0x2CB244C")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x1700002E")]
		protected override int minBones
		{
			[Token(Token = "0x60002E1")]
			[Address(RVA = "0x2CB31C4", Offset = "0x2CB31C4", VA = "0x2CB31C4", Slot = "12")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700002F")]
		protected override Vector3 localDirection
		{
			[Token(Token = "0x60002E5")]
			[Address(RVA = "0x2CB3770", Offset = "0x2CB3770", VA = "0x2CB3770", Slot = "15")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x60002DC")]
		[Address(RVA = "0x2CB2280", Offset = "0x2CB2280", VA = "0x2CB2280")]
		public float GetAngle()
		{
			return default(float);
		}

		[Token(Token = "0x60002DF")]
		[Address(RVA = "0x2CB2518", Offset = "0x2CB2518", VA = "0x2CB2518", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x60002E0")]
		[Address(RVA = "0x2CB27A0", Offset = "0x2CB27A0", VA = "0x2CB27A0", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x60002E2")]
		[Address(RVA = "0x2CB3110", Offset = "0x2CB3110", VA = "0x2CB3110")]
		private void Solve()
		{
		}

		[Token(Token = "0x60002E3")]
		[Address(RVA = "0x2CB2D38", Offset = "0x2CB2D38", VA = "0x2CB2D38")]
		private Vector3 GetClampedIKPosition()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002E4")]
		[Address(RVA = "0x2CB31CC", Offset = "0x2CB31CC", VA = "0x2CB31CC")]
		private void RotateToTarget(Vector3 targetPosition, Bone bone, float weight)
		{
		}

		[Token(Token = "0x60002E6")]
		[Address(RVA = "0x2CB37E4", Offset = "0x2CB37E4", VA = "0x2CB37E4")]
		public IKSolverAim()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000056")]
	public class IKSolverArm : IKSolver
	{
		[Token(Token = "0x4000290")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x14D2514", Offset = "0x14D2514")]
		public float IKRotationWeight;

		[Token(Token = "0x4000291")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public Quaternion IKRotation;

		[Token(Token = "0x4000292")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Point chest;

		[Token(Token = "0x4000293")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Point shoulder;

		[Token(Token = "0x4000294")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public Point upperArm;

		[Token(Token = "0x4000295")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public Point forearm;

		[Token(Token = "0x4000296")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public Point hand;

		[Token(Token = "0x4000297")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public bool isLeft;

		[Token(Token = "0x4000298")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public IKSolverVR.Arm arm;

		[Token(Token = "0x4000299")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Vector3[] positions;

		[Token(Token = "0x400029A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Quaternion[] rotations;

		[Token(Token = "0x60002E7")]
		[Address(RVA = "0x2CB38E8", Offset = "0x2CB38E8", VA = "0x2CB38E8", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60002E8")]
		[Address(RVA = "0x2CB3C5C", Offset = "0x2CB3C5C", VA = "0x2CB3C5C")]
		public bool SetChain(Transform chest, Transform shoulder, Transform upperArm, Transform forearm, Transform hand, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x60002E9")]
		[Address(RVA = "0x2CB3CCC", Offset = "0x2CB3CCC", VA = "0x2CB3CCC", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x60002EA")]
		[Address(RVA = "0x2CB3E28", Offset = "0x2CB3E28", VA = "0x2CB3E28", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x60002EB")]
		[Address(RVA = "0x2CB3FC0", Offset = "0x2CB3FC0", VA = "0x2CB3FC0", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60002EC")]
		[Address(RVA = "0x2CB401C", Offset = "0x2CB401C", VA = "0x2CB401C", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x60002ED")]
		[Address(RVA = "0x2CB408C", Offset = "0x2CB408C", VA = "0x2CB408C", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x60002EE")]
		[Address(RVA = "0x2CB43FC", Offset = "0x2CB43FC", VA = "0x2CB43FC", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x60002EF")]
		[Address(RVA = "0x2CB4428", Offset = "0x2CB4428", VA = "0x2CB4428")]
		private void Solve()
		{
		}

		[Token(Token = "0x60002F0")]
		[Address(RVA = "0x2CB40F0", Offset = "0x2CB40F0", VA = "0x2CB40F0")]
		private void Read()
		{
		}

		[Token(Token = "0x60002F1")]
		[Address(RVA = "0x2CB4494", Offset = "0x2CB4494", VA = "0x2CB4494")]
		private void Write()
		{
		}

		[Token(Token = "0x60002F2")]
		[Address(RVA = "0x2CB4620", Offset = "0x2CB4620", VA = "0x2CB4620")]
		public IKSolverArm()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000057")]
	public class IKSolverCCD : IKSolverHeuristic
	{
		[Token(Token = "0x400029B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public IterationDelegate OnPreIteration;

		[Token(Token = "0x60002F3")]
		[Address(RVA = "0x2CB4778", Offset = "0x2CB4778", VA = "0x2CB4778")]
		public void FadeOutBoneWeights()
		{
		}

		[Token(Token = "0x60002F4")]
		[Address(RVA = "0x2CB4828", Offset = "0x2CB4828", VA = "0x2CB4828", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x60002F5")]
		[Address(RVA = "0x2CB4E28", Offset = "0x2CB4E28", VA = "0x2CB4E28", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x60002F6")]
		[Address(RVA = "0x2CB5588", Offset = "0x2CB5588", VA = "0x2CB5588")]
		protected void Solve(Vector3 targetPosition)
		{
		}

		[Token(Token = "0x60002F7")]
		[Address(RVA = "0x2CB5CEC", Offset = "0x2CB5CEC", VA = "0x2CB5CEC")]
		public IKSolverCCD()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000058")]
	public class IKSolverFABRIK : IKSolverHeuristic
	{
		[Token(Token = "0x400029C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public IterationDelegate OnPreIteration;

		[Token(Token = "0x400029D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private bool[] limitedBones;

		[Token(Token = "0x400029E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Vector3[] solverLocalPositions;

		[Token(Token = "0x17000030")]
		protected override bool boneLengthCanBeZero
		{
			[Token(Token = "0x60002FD")]
			[Address(RVA = "0x2CB6F08", Offset = "0x2CB6F08", VA = "0x2CB6F08", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60002F8")]
		[Address(RVA = "0x2CB5CF0", Offset = "0x2CB5CF0", VA = "0x2CB5CF0")]
		public void SolveForward(Vector3 position)
		{
		}

		[Token(Token = "0x60002F9")]
		[Address(RVA = "0x2CB6434", Offset = "0x2CB6434", VA = "0x2CB6434")]
		public void SolveBackward(Vector3 position)
		{
		}

		[Token(Token = "0x60002FA")]
		[Address(RVA = "0x2CB6568", Offset = "0x2CB6568", VA = "0x2CB6568", Slot = "5")]
		public override Vector3 GetIKPosition()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002FB")]
		[Address(RVA = "0x2CB6600", Offset = "0x2CB6600", VA = "0x2CB6600", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x60002FC")]
		[Address(RVA = "0x2CB6BA4", Offset = "0x2CB6BA4", VA = "0x2CB6BA4", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x60002FE")]
		[Address(RVA = "0x2CB6F10", Offset = "0x2CB6F10", VA = "0x2CB6F10")]
		private Vector3 SolveJoint(Vector3 pos1, Vector3 pos2, float length)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002FF")]
		[Address(RVA = "0x2CB5DC0", Offset = "0x2CB5DC0", VA = "0x2CB5DC0")]
		private void OnPreSolve()
		{
		}

		[Token(Token = "0x6000300")]
		[Address(RVA = "0x2CB6514", Offset = "0x2CB6514", VA = "0x2CB6514")]
		private void OnPostSolve()
		{
		}

		[Token(Token = "0x6000301")]
		[Address(RVA = "0x2CB6EAC", Offset = "0x2CB6EAC", VA = "0x2CB6EAC")]
		private void Solve(Vector3 targetPosition)
		{
		}

		[Token(Token = "0x6000302")]
		[Address(RVA = "0x2CB625C", Offset = "0x2CB625C", VA = "0x2CB625C")]
		private void ForwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x6000303")]
		[Address(RVA = "0x2CB7758", Offset = "0x2CB7758", VA = "0x2CB7758")]
		private void SolverMove(int index, Vector3 offset)
		{
		}

		[Token(Token = "0x6000304")]
		[Address(RVA = "0x2CB7868", Offset = "0x2CB7868", VA = "0x2CB7868")]
		private void SolverRotate(int index, Quaternion rotation, bool recursive)
		{
		}

		[Token(Token = "0x6000305")]
		[Address(RVA = "0x2CB7994", Offset = "0x2CB7994", VA = "0x2CB7994")]
		private void SolverRotateChildren(int index, Quaternion rotation)
		{
		}

		[Token(Token = "0x6000306")]
		[Address(RVA = "0x2CB7AAC", Offset = "0x2CB7AAC", VA = "0x2CB7AAC")]
		private void SolverMoveChildrenAroundPoint(int index, Quaternion rotation)
		{
		}

		[Token(Token = "0x6000307")]
		[Address(RVA = "0x2CB690C", Offset = "0x2CB690C", VA = "0x2CB690C")]
		private Quaternion GetParentSolverRotation(int index)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000308")]
		[Address(RVA = "0x2CB6A58", Offset = "0x2CB6A58", VA = "0x2CB6A58")]
		private Vector3 GetParentSolverPosition(int index)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000309")]
		[Address(RVA = "0x2CB7C98", Offset = "0x2CB7C98", VA = "0x2CB7C98")]
		private Quaternion GetLimitedRotation(int index, Quaternion q, out bool changed)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600030A")]
		[Address(RVA = "0x2CB71CC", Offset = "0x2CB71CC", VA = "0x2CB71CC")]
		private void LimitForward(int rotateBone, int limitBone)
		{
		}

		[Token(Token = "0x600030B")]
		[Address(RVA = "0x2CB6504", Offset = "0x2CB6504", VA = "0x2CB6504")]
		private void BackwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x600030C")]
		[Address(RVA = "0x2CB8408", Offset = "0x2CB8408", VA = "0x2CB8408")]
		private void BackwardReachUnlimited(Vector3 position)
		{
		}

		[Token(Token = "0x600030D")]
		[Address(RVA = "0x2CB7E70", Offset = "0x2CB7E70", VA = "0x2CB7E70")]
		private void BackwardReachLimited(Vector3 position)
		{
		}

		[Token(Token = "0x600030E")]
		[Address(RVA = "0x2CB7028", Offset = "0x2CB7028", VA = "0x2CB7028")]
		private void MapToSolverPositions()
		{
		}

		[Token(Token = "0x600030F")]
		[Address(RVA = "0x2CB7108", Offset = "0x2CB7108", VA = "0x2CB7108")]
		private void MapToSolverPositionsLimited()
		{
		}

		[Token(Token = "0x6000310")]
		[Address(RVA = "0x2CB84D4", Offset = "0x2CB84D4", VA = "0x2CB84D4")]
		public IKSolverFABRIK()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000059")]
	public class IKSolverFABRIKRoot : IKSolver
	{
		[Token(Token = "0x400029F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public int iterations;

		[Token(Token = "0x40002A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x14D252C", Offset = "0x14D252C")]
		public float rootPin;

		[Token(Token = "0x40002A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public FABRIKChain[] chains;

		[Token(Token = "0x40002A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private bool zeroWeightApplied;

		[Token(Token = "0x40002A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private bool[] isRoot;

		[Token(Token = "0x40002A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Vector3 rootDefaultPosition;

		[Token(Token = "0x6000311")]
		[Address(RVA = "0x2CB8548", Offset = "0x2CB8548", VA = "0x2CB8548", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000312")]
		[Address(RVA = "0x2CB8E14", Offset = "0x2CB8E14", VA = "0x2CB8E14", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000313")]
		[Address(RVA = "0x2CB8EAC", Offset = "0x2CB8EAC", VA = "0x2CB8EAC", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x6000314")]
		[Address(RVA = "0x2CB8F4C", Offset = "0x2CB8F4C", VA = "0x2CB8F4C", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000315")]
		[Address(RVA = "0x2CB904C", Offset = "0x2CB904C", VA = "0x2CB904C")]
		private bool IsRoot(int index)
		{
			return default(bool);
		}

		[Token(Token = "0x6000316")]
		[Address(RVA = "0x2CB90E8", Offset = "0x2CB90E8", VA = "0x2CB90E8", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000317")]
		[Address(RVA = "0x2CB9650", Offset = "0x2CB9650", VA = "0x2CB9650", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x6000318")]
		[Address(RVA = "0x2CB9850", Offset = "0x2CB9850", VA = "0x2CB9850", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x6000319")]
		[Address(RVA = "0x2CB9700", Offset = "0x2CB9700", VA = "0x2CB9700")]
		private void AddPointsToArray(ref Point[] array, FABRIKChain chain)
		{
		}

		[Token(Token = "0x600031A")]
		[Address(RVA = "0x2CB931C", Offset = "0x2CB931C", VA = "0x2CB931C")]
		private Vector3 GetCentroid()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600031B")]
		[Address(RVA = "0x2CB98E8", Offset = "0x2CB98E8", VA = "0x2CB98E8")]
		public IKSolverFABRIKRoot()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200005A")]
	public class IKSolverFullBody : IKSolver
	{
		[Token(Token = "0x40002A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x14D2544", Offset = "0x14D2544")]
		public int iterations;

		[Token(Token = "0x40002A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public FBIKChain[] chain;

		[Token(Token = "0x40002A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public IKEffector[] effectors;

		[Token(Token = "0x40002A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public IKMappingSpine spineMapping;

		[Token(Token = "0x40002A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public IKMappingBone[] boneMappings;

		[Token(Token = "0x40002AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public IKMappingLimb[] limbMappings;

		[Token(Token = "0x40002AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public bool FABRIKPass;

		[Token(Token = "0x40002AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public UpdateDelegate OnPreRead;

		[Token(Token = "0x40002AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public UpdateDelegate OnPreSolve;

		[Token(Token = "0x40002AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public IterationDelegate OnPreIteration;

		[Token(Token = "0x40002AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public IterationDelegate OnPostIteration;

		[Token(Token = "0x40002B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public UpdateDelegate OnPreBend;

		[Token(Token = "0x40002B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public UpdateDelegate OnPostSolve;

		[Token(Token = "0x40002B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public UpdateDelegate OnStoreDefaultLocalState;

		[Token(Token = "0x40002B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public UpdateDelegate OnFixTransforms;

		[Token(Token = "0x600031C")]
		[Address(RVA = "0x2CB9950", Offset = "0x2CB9950", VA = "0x2CB9950")]
		public IKEffector GetEffector(Transform t)
		{
			return null;
		}

		[Token(Token = "0x600031D")]
		[Address(RVA = "0x2CB9A44", Offset = "0x2CB9A44", VA = "0x2CB9A44")]
		public FBIKChain GetChain(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x600031E")]
		[Address(RVA = "0x2CB9AA0", Offset = "0x2CB9AA0", VA = "0x2CB9AA0")]
		public int GetChainIndex(Transform transform)
		{
			return default(int);
		}

		[Token(Token = "0x600031F")]
		[Address(RVA = "0x2CB9BD4", Offset = "0x2CB9BD4", VA = "0x2CB9BD4")]
		public Node GetNode(int chainIndex, int nodeIndex)
		{
			return null;
		}

		[Token(Token = "0x6000320")]
		[Address(RVA = "0x2CB9C30", Offset = "0x2CB9C30", VA = "0x2CB9C30")]
		public void GetChainAndNodeIndexes(Transform transform, out int chainIndex, out int nodeIndex)
		{
		}

		[Token(Token = "0x6000321")]
		[Address(RVA = "0x2CB9CB0", Offset = "0x2CB9CB0", VA = "0x2CB9CB0", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x6000322")]
		[Address(RVA = "0x2CB9E58", Offset = "0x2CB9E58", VA = "0x2CB9E58", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x6000323")]
		[Address(RVA = "0x2CB9FCC", Offset = "0x2CB9FCC", VA = "0x2CB9FCC", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000324")]
		[Address(RVA = "0x2CBA1D0", Offset = "0x2CBA1D0", VA = "0x2CBA1D0", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000325")]
		[Address(RVA = "0x2CBA2A4", Offset = "0x2CBA2A4", VA = "0x2CBA2A4", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x6000326")]
		[Address(RVA = "0x2CBA38C", Offset = "0x2CBA38C", VA = "0x2CBA38C", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000327")]
		[Address(RVA = "0x2CBA500", Offset = "0x2CBA500", VA = "0x2CBA500", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000328")]
		[Address(RVA = "0x2CBA6BC", Offset = "0x2CBA6BC", VA = "0x2CBA6BC", Slot = "12")]
		protected virtual void ReadPose()
		{
		}

		[Token(Token = "0x6000329")]
		[Address(RVA = "0x2CBA908", Offset = "0x2CBA908", VA = "0x2CBA908", Slot = "13")]
		protected virtual void Solve()
		{
		}

		[Token(Token = "0x600032A")]
		[Address(RVA = "0x2CBABE0", Offset = "0x2CBABE0", VA = "0x2CBABE0", Slot = "14")]
		protected virtual void ApplyBendConstraints()
		{
		}

		[Token(Token = "0x600032B")]
		[Address(RVA = "0x2CBAC24", Offset = "0x2CBAC24", VA = "0x2CBAC24", Slot = "15")]
		protected virtual void WritePose()
		{
		}

		[Token(Token = "0x600032C")]
		[Address(RVA = "0x2CBAD14", Offset = "0x2CBAD14", VA = "0x2CBAD14")]
		public IKSolverFullBody()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200005B")]
	public enum FullBodyBipedEffector
	{
		[Token(Token = "0x40002B5")]
		Body,
		[Token(Token = "0x40002B6")]
		LeftShoulder,
		[Token(Token = "0x40002B7")]
		RightShoulder,
		[Token(Token = "0x40002B8")]
		LeftThigh,
		[Token(Token = "0x40002B9")]
		RightThigh,
		[Token(Token = "0x40002BA")]
		LeftHand,
		[Token(Token = "0x40002BB")]
		RightHand,
		[Token(Token = "0x40002BC")]
		LeftFoot,
		[Token(Token = "0x40002BD")]
		RightFoot
	}
	[Serializable]
	[Token(Token = "0x200005C")]
	public enum FullBodyBipedChain
	{
		[Token(Token = "0x40002BF")]
		LeftArm,
		[Token(Token = "0x40002C0")]
		RightArm,
		[Token(Token = "0x40002C1")]
		LeftLeg,
		[Token(Token = "0x40002C2")]
		RightLeg
	}
	[Serializable]
	[Token(Token = "0x200005D")]
	public class IKSolverFullBodyBiped : IKSolverFullBody
	{
		[Token(Token = "0x40002C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public Transform rootNode;

		[Token(Token = "0x40002C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x14D255C", Offset = "0x14D255C")]
		public float spineStiffness;

		[Token(Token = "0x40002C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x14D2574", Offset = "0x14D2574")]
		public float pullBodyVertical;

		[Token(Token = "0x40002C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x14D258C", Offset = "0x14D258C")]
		public float pullBodyHorizontal;

		[Token(Token = "0x40002C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x14D25A4", Offset = "0x14D25A4")]
		private Vector3 <pullBodyOffset>k__BackingField;

		[Token(Token = "0x40002C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private Vector3 offset;

		[Token(Token = "0x17000031")]
		public IKEffector bodyEffector
		{
			[Token(Token = "0x600032D")]
			[Address(RVA = "0x2CBADEC", Offset = "0x2CBADEC", VA = "0x2CBADEC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000032")]
		public IKEffector leftShoulderEffector
		{
			[Token(Token = "0x600032E")]
			[Address(RVA = "0x2CBAF34", Offset = "0x2CBAF34", VA = "0x2CBAF34")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000033")]
		public IKEffector rightShoulderEffector
		{
			[Token(Token = "0x600032F")]
			[Address(RVA = "0x2CBAF3C", Offset = "0x2CBAF3C", VA = "0x2CBAF3C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000034")]
		public IKEffector leftThighEffector
		{
			[Token(Token = "0x6000330")]
			[Address(RVA = "0x2CBAF44", Offset = "0x2CBAF44", VA = "0x2CBAF44")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000035")]
		public IKEffector rightThighEffector
		{
			[Token(Token = "0x6000331")]
			[Address(RVA = "0x2CBAF4C", Offset = "0x2CBAF4C", VA = "0x2CBAF4C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000036")]
		public IKEffector leftHandEffector
		{
			[Token(Token = "0x6000332")]
			[Address(RVA = "0x2CBAF54", Offset = "0x2CBAF54", VA = "0x2CBAF54")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000037")]
		public IKEffector rightHandEffector
		{
			[Token(Token = "0x6000333")]
			[Address(RVA = "0x2CBAF5C", Offset = "0x2CBAF5C", VA = "0x2CBAF5C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000038")]
		public IKEffector leftFootEffector
		{
			[Token(Token = "0x6000334")]
			[Address(RVA = "0x2CBAF64", Offset = "0x2CBAF64", VA = "0x2CBAF64")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000039")]
		public IKEffector rightFootEffector
		{
			[Token(Token = "0x6000335")]
			[Address(RVA = "0x2CBAF6C", Offset = "0x2CBAF6C", VA = "0x2CBAF6C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700003A")]
		public FBIKChain leftArmChain
		{
			[Token(Token = "0x6000336")]
			[Address(RVA = "0x2CBAF74", Offset = "0x2CBAF74", VA = "0x2CBAF74")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700003B")]
		public FBIKChain rightArmChain
		{
			[Token(Token = "0x6000337")]
			[Address(RVA = "0x2CBAFAC", Offset = "0x2CBAFAC", VA = "0x2CBAFAC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700003C")]
		public FBIKChain leftLegChain
		{
			[Token(Token = "0x6000338")]
			[Address(RVA = "0x2CBAFE4", Offset = "0x2CBAFE4", VA = "0x2CBAFE4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700003D")]
		public FBIKChain rightLegChain
		{
			[Token(Token = "0x6000339")]
			[Address(RVA = "0x2CBB01C", Offset = "0x2CBB01C", VA = "0x2CBB01C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700003E")]
		public IKMappingLimb leftArmMapping
		{
			[Token(Token = "0x600033A")]
			[Address(RVA = "0x2CBB054", Offset = "0x2CBB054", VA = "0x2CBB054")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700003F")]
		public IKMappingLimb rightArmMapping
		{
			[Token(Token = "0x600033B")]
			[Address(RVA = "0x2CBB088", Offset = "0x2CBB088", VA = "0x2CBB088")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000040")]
		public IKMappingLimb leftLegMapping
		{
			[Token(Token = "0x600033C")]
			[Address(RVA = "0x2CBB0C0", Offset = "0x2CBB0C0", VA = "0x2CBB0C0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000041")]
		public IKMappingLimb rightLegMapping
		{
			[Token(Token = "0x600033D")]
			[Address(RVA = "0x2CBB0F8", Offset = "0x2CBB0F8", VA = "0x2CBB0F8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000042")]
		public IKMappingBone headMapping
		{
			[Token(Token = "0x600033E")]
			[Address(RVA = "0x2CBB130", Offset = "0x2CBB130", VA = "0x2CBB130")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000043")]
		public Vector3 pullBodyOffset
		{
			[Token(Token = "0x600034E")]
			[Address(RVA = "0x2CBD0F4", Offset = "0x2CBD0F4", VA = "0x2CBD0F4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x14D89F4", Offset = "0x14D89F4")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x600034F")]
			[Address(RVA = "0x2CBD100", Offset = "0x2CBD100", VA = "0x2CBD100")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x14D8A04", Offset = "0x14D8A04")]
			private set
			{
			}
		}

		[Token(Token = "0x600033F")]
		[Address(RVA = "0x2CBB164", Offset = "0x2CBB164", VA = "0x2CBB164")]
		public void SetChainWeights(FullBodyBipedChain c, float pull, float reach = 0f)
		{
		}

		[Token(Token = "0x6000340")]
		[Address(RVA = "0x2CBB270", Offset = "0x2CBB270", VA = "0x2CBB270")]
		public void SetEffectorWeights(FullBodyBipedEffector effector, float positionWeight, float rotationWeight)
		{
		}

		[Token(Token = "0x6000341")]
		[Address(RVA = "0x2CBB1B8", Offset = "0x2CBB1B8", VA = "0x2CBB1B8")]
		public FBIKChain GetChain(FullBodyBipedChain c)
		{
			return null;
		}

		[Token(Token = "0x6000342")]
		[Address(RVA = "0x2CBB34C", Offset = "0x2CBB34C", VA = "0x2CBB34C")]
		public FBIKChain GetChain(FullBodyBipedEffector effector)
		{
			return null;
		}

		[Token(Token = "0x6000343")]
		[Address(RVA = "0x2CBADF4", Offset = "0x2CBADF4", VA = "0x2CBADF4")]
		public IKEffector GetEffector(FullBodyBipedEffector effector)
		{
			return null;
		}

		[Token(Token = "0x6000344")]
		[Address(RVA = "0x2CBB41C", Offset = "0x2CBB41C", VA = "0x2CBB41C")]
		public IKEffector GetEndEffector(FullBodyBipedChain c)
		{
			return null;
		}

		[Token(Token = "0x6000345")]
		[Address(RVA = "0x2CBB4D4", Offset = "0x2CBB4D4", VA = "0x2CBB4D4")]
		public IKMappingLimb GetLimbMapping(FullBodyBipedChain chain)
		{
			return null;
		}

		[Token(Token = "0x6000346")]
		[Address(RVA = "0x2CBB588", Offset = "0x2CBB588", VA = "0x2CBB588")]
		public IKMappingLimb GetLimbMapping(FullBodyBipedEffector effector)
		{
			return null;
		}

		[Token(Token = "0x6000347")]
		[Address(RVA = "0x2CBB63C", Offset = "0x2CBB63C", VA = "0x2CBB63C")]
		public IKMappingSpine GetSpineMapping()
		{
			return null;
		}

		[Token(Token = "0x6000348")]
		[Address(RVA = "0x2CBB644", Offset = "0x2CBB644", VA = "0x2CBB644")]
		public IKMappingBone GetHeadMapping()
		{
			return null;
		}

		[Token(Token = "0x6000349")]
		[Address(RVA = "0x2CBB678", Offset = "0x2CBB678", VA = "0x2CBB678")]
		public IKConstraintBend GetBendConstraint(FullBodyBipedChain limb)
		{
			return null;
		}

		[Token(Token = "0x600034A")]
		[Address(RVA = "0x2CBB740", Offset = "0x2CBB740", VA = "0x2CBB740", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x600034B")]
		[Address(RVA = "0x2CBB8D0", Offset = "0x2CBB8D0", VA = "0x2CBB8D0")]
		public void SetToReferences(BipedReferences references, [Optional] Transform rootNode)
		{
		}

		[Token(Token = "0x600034C")]
		[Address(RVA = "0x2CBCA0C", Offset = "0x2CBCA0C", VA = "0x2CBCA0C")]
		public static Transform DetectRootNodeBone(BipedReferences references)
		{
			return null;
		}

		[Token(Token = "0x600034D")]
		[Address(RVA = "0x2CBCEA0", Offset = "0x2CBCEA0", VA = "0x2CBCEA0")]
		public void SetLimbOrientations(BipedLimbOrientations o)
		{
		}

		[Token(Token = "0x6000350")]
		[Address(RVA = "0x2CBCF00", Offset = "0x2CBCF00", VA = "0x2CBCF00")]
		private void SetLimbOrientation(FullBodyBipedChain chain, BipedLimbOrientations.LimbOrientation limbOrientation)
		{
		}

		[Token(Token = "0x6000351")]
		[Address(RVA = "0x2CBCD20", Offset = "0x2CBCD20", VA = "0x2CBCD20")]
		private static Transform GetLeftClavicle(BipedReferences references)
		{
			return null;
		}

		[Token(Token = "0x6000352")]
		[Address(RVA = "0x2CBCDE0", Offset = "0x2CBCDE0", VA = "0x2CBCDE0")]
		private static Transform GetRightClavicle(BipedReferences references)
		{
			return null;
		}

		[Token(Token = "0x6000353")]
		[Address(RVA = "0x2CBD10C", Offset = "0x2CBD10C", VA = "0x2CBD10C")]
		private static bool Contains(Transform[] array, Transform transform)
		{
			return default(bool);
		}

		[Token(Token = "0x6000354")]
		[Address(RVA = "0x2CBD1E8", Offset = "0x2CBD1E8", VA = "0x2CBD1E8", Slot = "12")]
		protected override void ReadPose()
		{
		}

		[Token(Token = "0x6000355")]
		[Address(RVA = "0x2CBD330", Offset = "0x2CBD330", VA = "0x2CBD330")]
		private void PullBody()
		{
		}

		[Token(Token = "0x6000356")]
		[Address(RVA = "0x2CBD4C0", Offset = "0x2CBD4C0", VA = "0x2CBD4C0")]
		private Vector3 GetBodyOffset()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000357")]
		[Address(RVA = "0x2CBD6C0", Offset = "0x2CBD6C0", VA = "0x2CBD6C0")]
		private Vector3 GetHandBodyPull(IKEffector effector, FBIKChain arm, Vector3 offset)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000358")]
		[Address(RVA = "0x2CBD8C0", Offset = "0x2CBD8C0", VA = "0x2CBD8C0", Slot = "14")]
		protected override void ApplyBendConstraints()
		{
		}

		[Token(Token = "0x6000359")]
		[Address(RVA = "0x2CBDBF4", Offset = "0x2CBDBF4", VA = "0x2CBDBF4", Slot = "15")]
		protected override void WritePose()
		{
		}

		[Token(Token = "0x600035A")]
		[Address(RVA = "0x2CBDCF4", Offset = "0x2CBDCF4", VA = "0x2CBDCF4")]
		public IKSolverFullBodyBiped()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200005E")]
	public class IKSolverHeuristic : IKSolver
	{
		[Token(Token = "0x40002C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform target;

		[Token(Token = "0x40002CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public float tolerance;

		[Token(Token = "0x40002CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public int maxIterations;

		[Token(Token = "0x40002CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public bool useRotationLimits;

		[Token(Token = "0x40002CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x69")]
		public bool XY;

		[Token(Token = "0x40002CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Bone[] bones;

		[Token(Token = "0x40002CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		protected Vector3 lastLocalDirection;

		[Token(Token = "0x40002D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		protected float chainLength;

		[Token(Token = "0x17000044")]
		protected virtual int minBones
		{
			[Token(Token = "0x6000362")]
			[Address(RVA = "0x2CBE544", Offset = "0x2CBE544", VA = "0x2CBE544", Slot = "12")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000045")]
		protected virtual bool boneLengthCanBeZero
		{
			[Token(Token = "0x6000363")]
			[Address(RVA = "0x2CBE54C", Offset = "0x2CBE54C", VA = "0x2CBE54C", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000046")]
		protected virtual bool allowCommonParent
		{
			[Token(Token = "0x6000364")]
			[Address(RVA = "0x2CBE554", Offset = "0x2CBE554", VA = "0x2CBE554", Slot = "14")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000047")]
		protected virtual Vector3 localDirection
		{
			[Token(Token = "0x6000368")]
			[Address(RVA = "0x2CBE564", Offset = "0x2CBE564", VA = "0x2CBE564", Slot = "15")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000048")]
		protected float positionOffset
		{
			[Token(Token = "0x6000369")]
			[Address(RVA = "0x2CB54C4", Offset = "0x2CB54C4", VA = "0x2CB54C4")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x600035B")]
		[Address(RVA = "0x2CBDD00", Offset = "0x2CBDD00", VA = "0x2CBDD00")]
		public bool SetChain(Transform[] hierarchy, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x600035C")]
		[Address(RVA = "0x2CBDE94", Offset = "0x2CBDE94", VA = "0x2CBDE94")]
		public void AddBone(Transform bone)
		{
		}

		[Token(Token = "0x600035D")]
		[Address(RVA = "0x2CBDFD0", Offset = "0x2CBDFD0", VA = "0x2CBDFD0", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x600035E")]
		[Address(RVA = "0x2CBE03C", Offset = "0x2CBE03C", VA = "0x2CBE03C", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x600035F")]
		[Address(RVA = "0x2CBE0BC", Offset = "0x2CBE0BC", VA = "0x2CBE0BC", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000360")]
		[Address(RVA = "0x2CBE448", Offset = "0x2CBE448", VA = "0x2CBE448", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x6000361")]
		[Address(RVA = "0x2CBE450", Offset = "0x2CBE450", VA = "0x2CBE450", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x6000365")]
		[Address(RVA = "0x2CBE55C", Offset = "0x2CBE55C", VA = "0x2CBE55C", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000366")]
		[Address(RVA = "0x2CBE560", Offset = "0x2CBE560", VA = "0x2CBE560", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000367")]
		[Address(RVA = "0x2CB48A8", Offset = "0x2CB48A8", VA = "0x2CB48A8")]
		protected void InitiateBones()
		{
		}

		[Token(Token = "0x600036A")]
		[Address(RVA = "0x2CB5120", Offset = "0x2CB5120", VA = "0x2CB5120")]
		protected Vector3 GetSingularityOffset()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600036B")]
		[Address(RVA = "0x2CBE698", Offset = "0x2CBE698", VA = "0x2CBE698")]
		private bool SingularityDetected()
		{
			return default(bool);
		}

		[Token(Token = "0x600036C")]
		[Address(RVA = "0x2CB3878", Offset = "0x2CB3878", VA = "0x2CB3878")]
		public IKSolverHeuristic()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200005F")]
	public class IKSolverLeg : IKSolver
	{
		[Token(Token = "0x40002D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x14D25B4", Offset = "0x14D25B4")]
		public float IKRotationWeight;

		[Token(Token = "0x40002D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public Quaternion IKRotation;

		[Token(Token = "0x40002D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Point pelvis;

		[Token(Token = "0x40002D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Point thigh;

		[Token(Token = "0x40002D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public Point calf;

		[Token(Token = "0x40002D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public Point foot;

		[Token(Token = "0x40002D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public Point toe;

		[Token(Token = "0x40002D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public IKSolverVR.Leg leg;

		[Token(Token = "0x40002D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public Vector3 heelOffset;

		[Token(Token = "0x40002DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Vector3[] positions;

		[Token(Token = "0x40002DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private Quaternion[] rotations;

		[Token(Token = "0x600036D")]
		[Address(RVA = "0x2CBE94C", Offset = "0x2CBE94C", VA = "0x2CBE94C", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x600036E")]
		[Address(RVA = "0x2CBECC0", Offset = "0x2CBECC0", VA = "0x2CBECC0")]
		public bool SetChain(Transform pelvis, Transform thigh, Transform calf, Transform foot, Transform toe, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x600036F")]
		[Address(RVA = "0x2CBED30", Offset = "0x2CBED30", VA = "0x2CBED30", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x6000370")]
		[Address(RVA = "0x2CBEE8C", Offset = "0x2CBEE8C", VA = "0x2CBEE8C", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x6000371")]
		[Address(RVA = "0x2CBF024", Offset = "0x2CBF024", VA = "0x2CBF024", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000372")]
		[Address(RVA = "0x2CBF080", Offset = "0x2CBF080", VA = "0x2CBF080", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x6000373")]
		[Address(RVA = "0x2CBF0F0", Offset = "0x2CBF0F0", VA = "0x2CBF0F0", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000374")]
		[Address(RVA = "0x2CBF460", Offset = "0x2CBF460", VA = "0x2CBF460", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000375")]
		[Address(RVA = "0x2CBF48C", Offset = "0x2CBF48C", VA = "0x2CBF48C")]
		private void Solve()
		{
		}

		[Token(Token = "0x6000376")]
		[Address(RVA = "0x2CBF154", Offset = "0x2CBF154", VA = "0x2CBF154")]
		private void Read()
		{
		}

		[Token(Token = "0x6000377")]
		[Address(RVA = "0x2CBF594", Offset = "0x2CBF594", VA = "0x2CBF594")]
		private void Write()
		{
		}

		[Token(Token = "0x6000378")]
		[Address(RVA = "0x2CBF720", Offset = "0x2CBF720", VA = "0x2CBF720")]
		public IKSolverLeg()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000060")]
	public class IKSolverLimb : IKSolverTrigonometric
	{
		[Serializable]
		[Token(Token = "0x20001A0")]
		public enum BendModifier
		{
			[Token(Token = "0x4000A10")]
			Animation,
			[Token(Token = "0x4000A11")]
			Target,
			[Token(Token = "0x4000A12")]
			Parent,
			[Token(Token = "0x4000A13")]
			Arm,
			[Token(Token = "0x4000A14")]
			Goal
		}

		[Serializable]
		[Token(Token = "0x20001A1")]
		public struct AxisDirection
		{
			[Token(Token = "0x4000A15")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Vector3 direction;

			[Token(Token = "0x4000A16")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public Vector3 axis;

			[Token(Token = "0x4000A17")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float dot;

			[Token(Token = "0x6000C2B")]
			[Address(RVA = "0x2CC0F98", Offset = "0x2CC0F98", VA = "0x2CC0F98")]
			public AxisDirection(Vector3 direction, Vector3 axis)
			{
			}
		}

		[Token(Token = "0x40002DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public AvatarIKGoal goal;

		[Token(Token = "0x40002DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		public BendModifier bendModifier;

		[Token(Token = "0x40002DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x14D25CC", Offset = "0x14D25CC")]
		public float maintainRotationWeight;

		[Token(Token = "0x40002DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x14D25E4", Offset = "0x14D25E4")]
		public float bendModifierWeight;

		[Token(Token = "0x40002E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public Transform bendGoal;

		[Token(Token = "0x40002E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private bool maintainBendFor1Frame;

		[Token(Token = "0x40002E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC1")]
		private bool maintainRotationFor1Frame;

		[Token(Token = "0x40002E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private Quaternion defaultRootRotation;

		[Token(Token = "0x40002E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		private Quaternion parentDefaultRotation;

		[Token(Token = "0x40002E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		private Quaternion bone3RotationBeforeSolve;

		[Token(Token = "0x40002E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
		private Quaternion maintainRotation;

		[Token(Token = "0x40002E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
		private Quaternion bone3DefaultRotation;

		[Token(Token = "0x40002E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x114")]
		private Vector3 _bendNormal;

		[Token(Token = "0x40002E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private Vector3 animationNormal;

		[Token(Token = "0x40002EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private AxisDirection[] axisDirectionsLeft;

		[Token(Token = "0x40002EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		private AxisDirection[] axisDirectionsRight;

		[Token(Token = "0x17000049")]
		private AxisDirection[] axisDirections
		{
			[Token(Token = "0x6000380")]
			[Address(RVA = "0x2CC0F7C", Offset = "0x2CC0F7C", VA = "0x2CC0F7C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000379")]
		[Address(RVA = "0x2CBF878", Offset = "0x2CBF878", VA = "0x2CBF878")]
		public void MaintainRotation()
		{
		}

		[Token(Token = "0x600037A")]
		[Address(RVA = "0x2CBF8C8", Offset = "0x2CBF8C8", VA = "0x2CBF8C8")]
		public void MaintainBend()
		{
		}

		[Token(Token = "0x600037B")]
		[Address(RVA = "0x2CBF9DC", Offset = "0x2CBF9DC", VA = "0x2CBF9DC", Slot = "12")]
		protected override void OnInitiateVirtual()
		{
		}

		[Token(Token = "0x600037C")]
		[Address(RVA = "0x2CC004C", Offset = "0x2CC004C", VA = "0x2CC004C", Slot = "13")]
		protected override void OnUpdateVirtual()
		{
		}

		[Token(Token = "0x600037D")]
		[Address(RVA = "0x2CC0C28", Offset = "0x2CC0C28", VA = "0x2CC0C28", Slot = "14")]
		protected override void OnPostSolveVirtual()
		{
		}

		[Token(Token = "0x600037E")]
		[Address(RVA = "0x2CC0D70", Offset = "0x2CC0D70", VA = "0x2CC0D70")]
		public IKSolverLimb()
		{
		}

		[Token(Token = "0x600037F")]
		[Address(RVA = "0x2CC0EF4", Offset = "0x2CC0EF4", VA = "0x2CC0EF4")]
		public IKSolverLimb(AvatarIKGoal goal)
		{
		}

		[Token(Token = "0x6000381")]
		[Address(RVA = "0x2CBFD58", Offset = "0x2CBFD58", VA = "0x2CBFD58")]
		private void StoreAxisDirections(ref AxisDirection[] axisDirections)
		{
		}

		[Token(Token = "0x6000382")]
		[Address(RVA = "0x2CC0178", Offset = "0x2CC0178", VA = "0x2CC0178")]
		private Vector3 GetModifiedBendNormal()
		{
			return default(Vector3);
		}
	}
	[Serializable]
	[Token(Token = "0x2000061")]
	public class IKSolverLookAt : IKSolver
	{
		[Serializable]
		[Token(Token = "0x20001A2")]
		public class LookAtBone : Bone
		{
			[Token(Token = "0x4000A18")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
			public Vector3 baseForwardOffsetEuler;

			[Token(Token = "0x17000091")]
			public Vector3 forward
			{
				[Token(Token = "0x6000C30")]
				[Address(RVA = "0x2CC3038", Offset = "0x2CC3038", VA = "0x2CC3038")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x6000C2C")]
			[Address(RVA = "0x2CC3784", Offset = "0x2CC3784", VA = "0x2CC3784")]
			public LookAtBone()
			{
			}

			[Token(Token = "0x6000C2D")]
			[Address(RVA = "0x2CC21D4", Offset = "0x2CC21D4", VA = "0x2CC21D4")]
			public LookAtBone(Transform transform)
			{
			}

			[Token(Token = "0x6000C2E")]
			[Address(RVA = "0x2CC2510", Offset = "0x2CC2510", VA = "0x2CC2510")]
			public void Initiate(Transform root)
			{
			}

			[Token(Token = "0x6000C2F")]
			[Address(RVA = "0x2CC343C", Offset = "0x2CC343C", VA = "0x2CC343C")]
			public void LookAt(Vector3 direction, float weight)
			{
			}
		}

		[Token(Token = "0x40002EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform target;

		[Token(Token = "0x40002ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public LookAtBone[] spine;

		[Token(Token = "0x40002EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public LookAtBone head;

		[Token(Token = "0x40002EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public LookAtBone[] eyes;

		[Token(Token = "0x40002F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x14D25FC", Offset = "0x14D25FC")]
		public float bodyWeight;

		[Token(Token = "0x40002F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x14D2614", Offset = "0x14D2614")]
		public float headWeight;

		[Token(Token = "0x40002F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x14D262C", Offset = "0x14D262C")]
		public float eyesWeight;

		[Token(Token = "0x40002F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x14D2644", Offset = "0x14D2644")]
		public float clampWeight;

		[Token(Token = "0x40002F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x14D265C", Offset = "0x14D265C")]
		public float clampWeightHead;

		[Token(Token = "0x40002F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x14D2674", Offset = "0x14D2674")]
		public float clampWeightEyes;

		[Token(Token = "0x40002F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x14D268C", Offset = "0x14D268C")]
		public int clampSmoothing;

		[Token(Token = "0x40002F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public AnimationCurve spineWeightCurve;

		[Token(Token = "0x40002F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public Vector3 spineTargetOffset;

		[Token(Token = "0x40002F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		protected Vector3[] spineForwards;

		[Token(Token = "0x40002FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		protected Vector3[] headForwards;

		[Token(Token = "0x40002FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		protected Vector3[] eyeForward;

		[Token(Token = "0x1700004A")]
		protected bool spineIsValid
		{
			[Token(Token = "0x6000391")]
			[Address(RVA = "0x2CC1938", Offset = "0x2CC1938", VA = "0x2CC1938")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700004B")]
		protected bool spineIsEmpty
		{
			[Token(Token = "0x6000392")]
			[Address(RVA = "0x2CC1B10", Offset = "0x2CC1B10", VA = "0x2CC1B10")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700004C")]
		protected bool headIsValid
		{
			[Token(Token = "0x6000394")]
			[Address(RVA = "0x2CC1A1C", Offset = "0x2CC1A1C", VA = "0x2CC1A1C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700004D")]
		protected bool headIsEmpty
		{
			[Token(Token = "0x6000395")]
			[Address(RVA = "0x2CC1B34", Offset = "0x2CC1B34", VA = "0x2CC1B34")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700004E")]
		protected bool eyesIsValid
		{
			[Token(Token = "0x6000397")]
			[Address(RVA = "0x2CC1A2C", Offset = "0x2CC1A2C", VA = "0x2CC1A2C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700004F")]
		protected bool eyesIsEmpty
		{
			[Token(Token = "0x6000398")]
			[Address(RVA = "0x2CC1BB0", Offset = "0x2CC1BB0", VA = "0x2CC1BB0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000383")]
		[Address(RVA = "0x2CC0FF8", Offset = "0x2CC0FF8", VA = "0x2CC0FF8")]
		public void SetLookAtWeight(float weight)
		{
		}

		[Token(Token = "0x6000384")]
		[Address(RVA = "0x2CC107C", Offset = "0x2CC107C", VA = "0x2CC107C")]
		public void SetLookAtWeight(float weight, float bodyWeight)
		{
		}

		[Token(Token = "0x6000385")]
		[Address(RVA = "0x2CC1128", Offset = "0x2CC1128", VA = "0x2CC1128")]
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight)
		{
		}

		[Token(Token = "0x6000386")]
		[Address(RVA = "0x2CC11F0", Offset = "0x2CC11F0", VA = "0x2CC11F0")]
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight)
		{
		}

		[Token(Token = "0x6000387")]
		[Address(RVA = "0x2CC12DC", Offset = "0x2CC12DC", VA = "0x2CC12DC")]
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight, float clampWeight)
		{
		}

		[Token(Token = "0x6000388")]
		[Address(RVA = "0x2CC13E8", Offset = "0x2CC13E8", VA = "0x2CC13E8")]
		public void SetLookAtWeight(float weight, float bodyWeight = 0f, float headWeight = 1f, float eyesWeight = 0.5f, float clampWeight = 0.5f, float clampWeightHead = 0.5f, float clampWeightEyes = 0.3f)
		{
		}

		[Token(Token = "0x6000389")]
		[Address(RVA = "0x2CC1530", Offset = "0x2CC1530", VA = "0x2CC1530", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x600038A")]
		[Address(RVA = "0x2CC1660", Offset = "0x2CC1660", VA = "0x2CC1660", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x600038B")]
		[Address(RVA = "0x2CC17A4", Offset = "0x2CC17A4", VA = "0x2CC17A4", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x600038C")]
		[Address(RVA = "0x2CC1BD4", Offset = "0x2CC1BD4", VA = "0x2CC1BD4", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x600038D")]
		[Address(RVA = "0x2CC1E0C", Offset = "0x2CC1E0C", VA = "0x2CC1E0C", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x600038E")]
		[Address(RVA = "0x2CC1FAC", Offset = "0x2CC1FAC", VA = "0x2CC1FAC")]
		public bool SetChain(Transform[] spine, Transform head, Transform[] eyes, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x600038F")]
		[Address(RVA = "0x2CC2200", Offset = "0x2CC2200", VA = "0x2CC2200", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000390")]
		[Address(RVA = "0x2CC264C", Offset = "0x2CC264C", VA = "0x2CC264C", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000393")]
		[Address(RVA = "0x2CC2750", Offset = "0x2CC2750", VA = "0x2CC2750")]
		protected void SolveSpine()
		{
		}

		[Token(Token = "0x6000396")]
		[Address(RVA = "0x2CC297C", Offset = "0x2CC297C", VA = "0x2CC297C")]
		protected void SolveHead()
		{
		}

		[Token(Token = "0x6000399")]
		[Address(RVA = "0x2CC2BD8", Offset = "0x2CC2BD8", VA = "0x2CC2BD8")]
		protected void SolveEyes()
		{
		}

		[Token(Token = "0x600039A")]
		[Address(RVA = "0x2CC3104", Offset = "0x2CC3104", VA = "0x2CC3104")]
		protected Vector3[] GetForwards(ref Vector3[] forwards, Vector3 baseForward, Vector3 targetForward, int bones, float clamp)
		{
			return null;
		}

		[Token(Token = "0x600039B")]
		[Address(RVA = "0x2CC205C", Offset = "0x2CC205C", VA = "0x2CC205C")]
		protected void SetBones(Transform[] array, ref LookAtBone[] bones)
		{
		}

		[Token(Token = "0x600039C")]
		[Address(RVA = "0x2CC35A4", Offset = "0x2CC35A4", VA = "0x2CC35A4")]
		public IKSolverLookAt()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000062")]
	public class IKSolverTrigonometric : IKSolver
	{
		[Serializable]
		[Token(Token = "0x20001A3")]
		public class TrigonometricBone : Bone
		{
			[Token(Token = "0x4000A19")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
			private Quaternion targetToLocalSpace;

			[Token(Token = "0x4000A1A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
			private Vector3 defaultLocalBendNormal;

			[Token(Token = "0x6000C31")]
			[Address(RVA = "0x2CC4D5C", Offset = "0x2CC4D5C", VA = "0x2CC4D5C")]
			public void Initiate(Vector3 childPosition, Vector3 bendNormal)
			{
			}

			[Token(Token = "0x6000C32")]
			[Address(RVA = "0x2CC5914", Offset = "0x2CC5914", VA = "0x2CC5914")]
			public Quaternion GetRotation(Vector3 direction, Vector3 bendNormal)
			{
				return default(Quaternion);
			}

			[Token(Token = "0x6000C33")]
			[Address(RVA = "0x2CBF910", Offset = "0x2CBF910", VA = "0x2CBF910")]
			public Vector3 GetBendNormalFromCurrentRotation()
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000C34")]
			[Address(RVA = "0x2CC59DC", Offset = "0x2CC59DC", VA = "0x2CC59DC")]
			public TrigonometricBone()
			{
			}
		}

		[Token(Token = "0x40002FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform target;

		[Token(Token = "0x40002FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x14D26A4", Offset = "0x14D26A4")]
		public float IKRotationWeight;

		[Token(Token = "0x40002FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public Quaternion IKRotation;

		[Token(Token = "0x40002FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		public Vector3 bendNormal;

		[Token(Token = "0x4000300")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public TrigonometricBone bone1;

		[Token(Token = "0x4000301")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public TrigonometricBone bone2;

		[Token(Token = "0x4000302")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public TrigonometricBone bone3;

		[Token(Token = "0x4000303")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		protected Vector3 weightIKPosition;

		[Token(Token = "0x4000304")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		protected bool directHierarchy;

		[Token(Token = "0x600039D")]
		[Address(RVA = "0x2CC378C", Offset = "0x2CC378C", VA = "0x2CC378C")]
		public void SetBendGoalPosition(Vector3 goalPosition, float weight)
		{
		}

		[Token(Token = "0x600039E")]
		[Address(RVA = "0x2CC397C", Offset = "0x2CC397C", VA = "0x2CC397C")]
		public void SetBendPlaneToCurrent()
		{
		}

		[Token(Token = "0x600039F")]
		[Address(RVA = "0x2CC3B30", Offset = "0x2CC3B30", VA = "0x2CC3B30")]
		public void SetIKRotation(Quaternion rotation)
		{
		}

		[Token(Token = "0x60003A0")]
		[Address(RVA = "0x2CC3B3C", Offset = "0x2CC3B3C", VA = "0x2CC3B3C")]
		public void SetIKRotationWeight(float weight)
		{
		}

		[Token(Token = "0x60003A1")]
		[Address(RVA = "0x2CC3BC0", Offset = "0x2CC3BC0", VA = "0x2CC3BC0")]
		public Quaternion GetIKRotation()
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60003A2")]
		[Address(RVA = "0x2CC3BCC", Offset = "0x2CC3BCC", VA = "0x2CC3BCC")]
		public float GetIKRotationWeight()
		{
			return default(float);
		}

		[Token(Token = "0x60003A3")]
		[Address(RVA = "0x2CC3BD4", Offset = "0x2CC3BD4", VA = "0x2CC3BD4", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x60003A4")]
		[Address(RVA = "0x2CC3CD8", Offset = "0x2CC3CD8", VA = "0x2CC3CD8", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x60003A5")]
		[Address(RVA = "0x2CC3DF8", Offset = "0x2CC3DF8", VA = "0x2CC3DF8", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60003A6")]
		[Address(RVA = "0x2CC3E44", Offset = "0x2CC3E44", VA = "0x2CC3E44", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x60003A7")]
		[Address(RVA = "0x2CC3EA4", Offset = "0x2CC3EA4", VA = "0x2CC3EA4", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60003A8")]
		[Address(RVA = "0x2CC4280", Offset = "0x2CC4280", VA = "0x2CC4280")]
		public bool SetChain(Transform bone1, Transform bone2, Transform bone3, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x60003A9")]
		[Address(RVA = "0x2CC42D8", Offset = "0x2CC42D8", VA = "0x2CC42D8")]
		public static void Solve(Transform bone1, Transform bone2, Transform bone3, Vector3 targetPosition, Vector3 bendNormal, float weight)
		{
		}

		[Token(Token = "0x60003AA")]
		[Address(RVA = "0x2CC4880", Offset = "0x2CC4880", VA = "0x2CC4880")]
		private static Vector3 GetDirectionToBendPoint(Vector3 direction, float directionMag, Vector3 bendDirection, float sqrMag1, float sqrMag2)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003AB")]
		[Address(RVA = "0x2CC4A98", Offset = "0x2CC4A98", VA = "0x2CC4A98", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x60003AC")]
		[Address(RVA = "0x2CC4C54", Offset = "0x2CC4C54", VA = "0x2CC4C54")]
		private bool IsDirectHierarchy()
		{
			return default(bool);
		}

		[Token(Token = "0x60003AD")]
		[Address(RVA = "0x2CC4BD0", Offset = "0x2CC4BD0", VA = "0x2CC4BD0")]
		private void InitiateBones()
		{
		}

		[Token(Token = "0x60003AE")]
		[Address(RVA = "0x2CC4EFC", Offset = "0x2CC4EFC", VA = "0x2CC4EFC", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x60003AF")]
		[Address(RVA = "0x2CC59D0", Offset = "0x2CC59D0", VA = "0x2CC59D0", Slot = "12")]
		protected virtual void OnInitiateVirtual()
		{
		}

		[Token(Token = "0x60003B0")]
		[Address(RVA = "0x2CC59D4", Offset = "0x2CC59D4", VA = "0x2CC59D4", Slot = "13")]
		protected virtual void OnUpdateVirtual()
		{
		}

		[Token(Token = "0x60003B1")]
		[Address(RVA = "0x2CC59D8", Offset = "0x2CC59D8", VA = "0x2CC59D8", Slot = "14")]
		protected virtual void OnPostSolveVirtual()
		{
		}

		[Token(Token = "0x60003B2")]
		[Address(RVA = "0x2CC5608", Offset = "0x2CC5608", VA = "0x2CC5608")]
		protected Vector3 GetBendDirection(Vector3 IKPosition, Vector3 bendNormal)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003B3")]
		[Address(RVA = "0x2CC0DE4", Offset = "0x2CC0DE4", VA = "0x2CC0DE4")]
		public IKSolverTrigonometric()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000063")]
	public class IKSolverVR : IKSolver
	{
		[Serializable]
		[Token(Token = "0x20001A4")]
		public class Arm : BodyPart
		{
			[Serializable]
			[Token(Token = "0x20001DF")]
			public enum ShoulderRotationMode
			{
				[Token(Token = "0x4000BC1")]
				YawPitch,
				[Token(Token = "0x4000BC2")]
				FromTo
			}

			[Token(Token = "0x4000A1B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D4818", Offset = "0x14D4818")]
			public Transform target;

			[Token(Token = "0x4000A1C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D4850", Offset = "0x14D4850")]
			public Transform bendGoal;

			[Token(Token = "0x4000A1D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D4888", Offset = "0x14D4888")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x14D4888", Offset = "0x14D4888")]
			public float positionWeight;

			[Token(Token = "0x4000A1E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D48DC", Offset = "0x14D48DC")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x14D48DC", Offset = "0x14D48DC")]
			public float rotationWeight;

			[Token(Token = "0x4000A1F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D4930", Offset = "0x14D4930")]
			public ShoulderRotationMode shoulderRotationMode;

			[Token(Token = "0x4000A20")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D4968", Offset = "0x14D4968")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x14D4968", Offset = "0x14D4968")]
			public float shoulderRotationWeight;

			[Token(Token = "0x4000A21")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D49BC", Offset = "0x14D49BC")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x14D49BC", Offset = "0x14D49BC")]
			public float shoulderTwistWeight;

			[Token(Token = "0x4000A22")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D4A10", Offset = "0x14D4A10")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x14D4A10", Offset = "0x14D4A10")]
			public float bendGoalWeight;

			[Token(Token = "0x4000A23")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D4A64", Offset = "0x14D4A64")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x14D4A64", Offset = "0x14D4A64")]
			public float swivelOffset;

			[Token(Token = "0x4000A24")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D4AC0", Offset = "0x14D4AC0")]
			public Vector3 wristToPalmAxis;

			[Token(Token = "0x4000A25")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D4AF8", Offset = "0x14D4AF8")]
			public Vector3 palmToThumbAxis;

			[Token(Token = "0x4000A26")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D4B30", Offset = "0x14D4B30")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x14D4B30", Offset = "0x14D4B30")]
			public float armLengthMlp;

			[Token(Token = "0x4000A27")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D4B88", Offset = "0x14D4B88")]
			public AnimationCurve stretchCurve;

			[NonSerialized]
			[Token(Token = "0x4000A28")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			[HideInInspector]
			public Vector3 IKPosition;

			[NonSerialized]
			[Token(Token = "0x4000A29")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
			[HideInInspector]
			public Quaternion IKRotation;

			[NonSerialized]
			[Token(Token = "0x4000A2A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
			[HideInInspector]
			public Vector3 bendDirection;

			[NonSerialized]
			[Token(Token = "0x4000A2B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
			[HideInInspector]
			public Vector3 handPositionOffset;

			[Token(Token = "0x4000A2C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x14D4C00", Offset = "0x14D4C00")]
			private Vector3 <position>k__BackingField;

			[Token(Token = "0x4000A2D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x14D4C10", Offset = "0x14D4C10")]
			private Quaternion <rotation>k__BackingField;

			[Token(Token = "0x4000A2E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
			private bool hasShoulder;

			[Token(Token = "0x4000A2F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
			private Vector3 chestForwardAxis;

			[Token(Token = "0x4000A30")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
			private Vector3 chestUpAxis;

			[Token(Token = "0x4000A31")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
			private Quaternion chestRotation;

			[Token(Token = "0x4000A32")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x114")]
			private Vector3 chestForward;

			[Token(Token = "0x4000A33")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
			private Vector3 chestUp;

			[Token(Token = "0x4000A34")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x12C")]
			private Quaternion forearmRelToUpperArm;

			[Token(Token = "0x4000A35")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x13C")]
			private Vector3 upperArmBendAxis;

			[Token(Token = "0x4000A36")]
			private const float yawOffsetAngle = 45f;

			[Token(Token = "0x4000A37")]
			private const float pitchOffsetAngle = -30f;

			[Token(Token = "0x17000092")]
			public Vector3 position
			{
				[Token(Token = "0x6000C35")]
				[Address(RVA = "0x2FD644C", Offset = "0x2FD644C", VA = "0x2FD644C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x14D996C", Offset = "0x14D996C")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000C36")]
				[Address(RVA = "0x2FD6458", Offset = "0x2FD6458", VA = "0x2FD6458")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x14D997C", Offset = "0x14D997C")]
				private set
				{
				}
			}

			[Token(Token = "0x17000093")]
			public Quaternion rotation
			{
				[Token(Token = "0x6000C37")]
				[Address(RVA = "0x2FD6464", Offset = "0x2FD6464", VA = "0x2FD6464")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x14D998C", Offset = "0x14D998C")]
				get
				{
					return default(Quaternion);
				}
				[Token(Token = "0x6000C38")]
				[Address(RVA = "0x2FD6470", Offset = "0x2FD6470", VA = "0x2FD6470")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x14D999C", Offset = "0x14D999C")]
				private set
				{
				}
			}

			[Token(Token = "0x17000094")]
			private VirtualBone shoulder
			{
				[Token(Token = "0x6000C39")]
				[Address(RVA = "0x2FD647C", Offset = "0x2FD647C", VA = "0x2FD647C")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000095")]
			private VirtualBone upperArm
			{
				[Token(Token = "0x6000C3A")]
				[Address(RVA = "0x2FD64B0", Offset = "0x2FD64B0", VA = "0x2FD64B0")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000096")]
			private VirtualBone forearm
			{
				[Token(Token = "0x6000C3B")]
				[Address(RVA = "0x2FD64F0", Offset = "0x2FD64F0", VA = "0x2FD64F0")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000097")]
			private VirtualBone hand
			{
				[Token(Token = "0x6000C3C")]
				[Address(RVA = "0x2FD653C", Offset = "0x2FD653C", VA = "0x2FD653C")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000C3D")]
			[Address(RVA = "0x2FD6588", Offset = "0x2FD6588", VA = "0x2FD6588", Slot = "4")]
			protected override void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index)
			{
			}

			[Token(Token = "0x6000C3E")]
			[Address(RVA = "0x2FD6F38", Offset = "0x2FD6F38", VA = "0x2FD6F38", Slot = "5")]
			public override void PreSolve()
			{
			}

			[Token(Token = "0x6000C3F")]
			[Address(RVA = "0x2FD712C", Offset = "0x2FD712C", VA = "0x2FD712C", Slot = "7")]
			public override void ApplyOffsets()
			{
			}

			[Token(Token = "0x6000C40")]
			[Address(RVA = "0x2FD71D8", Offset = "0x2FD71D8", VA = "0x2FD71D8")]
			private void Stretching()
			{
			}

			[Token(Token = "0x6000C41")]
			[Address(RVA = "0x2FD75F0", Offset = "0x2FD75F0", VA = "0x2FD75F0")]
			public void Solve(bool isLeft)
			{
			}

			[Token(Token = "0x6000C42")]
			[Address(RVA = "0x2FD9B54", Offset = "0x2FD9B54", VA = "0x2FD9B54", Slot = "8")]
			public override void ResetOffsets()
			{
			}

			[Token(Token = "0x6000C43")]
			[Address(RVA = "0x2FD9BC4", Offset = "0x2FD9BC4", VA = "0x2FD9BC4", Slot = "6")]
			public override void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations)
			{
			}

			[Token(Token = "0x6000C44")]
			[Address(RVA = "0x2FD8B44", Offset = "0x2FD8B44", VA = "0x2FD8B44")]
			private float DamperValue(float value, float min, float max, float weight = 1f)
			{
				return default(float);
			}

			[Token(Token = "0x6000C45")]
			[Address(RVA = "0x2FD8E50", Offset = "0x2FD8E50", VA = "0x2FD8E50")]
			private Vector3 GetBendNormal(Vector3 dir)
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000C46")]
			[Address(RVA = "0x2FD9DE4", Offset = "0x2FD9DE4", VA = "0x2FD9DE4")]
			private void Visualize(VirtualBone bone1, VirtualBone bone2, VirtualBone bone3, Color color)
			{
			}

			[Token(Token = "0x6000C47")]
			[Address(RVA = "0x2FD9F0C", Offset = "0x2FD9F0C", VA = "0x2FD9F0C")]
			public Arm()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20001A5")]
		public abstract class BodyPart
		{
			[Token(Token = "0x4000A38")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x14D4C20", Offset = "0x14D4C20")]
			private float <sqrMag>k__BackingField;

			[Token(Token = "0x4000A39")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x14D4C30", Offset = "0x14D4C30")]
			private float <mag>k__BackingField;

			[Token(Token = "0x4000A3A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[HideInInspector]
			public VirtualBone[] bones;

			[Token(Token = "0x4000A3B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			protected bool initiated;

			[Token(Token = "0x4000A3C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			protected Vector3 rootPosition;

			[Token(Token = "0x4000A3D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			protected Quaternion rootRotation;

			[Token(Token = "0x4000A3E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			protected int index;

			[Token(Token = "0x4000A3F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			protected int LOD;

			[Token(Token = "0x17000098")]
			public float sqrMag
			{
				[Token(Token = "0x6000C4D")]
				[Address(RVA = "0x2FDA0CC", Offset = "0x2FDA0CC", VA = "0x2FDA0CC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x14D99AC", Offset = "0x14D99AC")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000C4E")]
				[Address(RVA = "0x2FDA0D4", Offset = "0x2FDA0D4", VA = "0x2FDA0D4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x14D99BC", Offset = "0x14D99BC")]
				private set
				{
				}
			}

			[Token(Token = "0x17000099")]
			public float mag
			{
				[Token(Token = "0x6000C4F")]
				[Address(RVA = "0x2FDA0DC", Offset = "0x2FDA0DC", VA = "0x2FDA0DC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x14D99CC", Offset = "0x14D99CC")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000C50")]
				[Address(RVA = "0x2FDA0E4", Offset = "0x2FDA0E4", VA = "0x2FDA0E4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x14D99DC", Offset = "0x14D99DC")]
				private set
				{
				}
			}

			[Token(Token = "0x6000C48")]
			protected abstract void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index);

			[Token(Token = "0x6000C49")]
			public abstract void PreSolve();

			[Token(Token = "0x6000C4A")]
			public abstract void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations);

			[Token(Token = "0x6000C4B")]
			public abstract void ApplyOffsets();

			[Token(Token = "0x6000C4C")]
			public abstract void ResetOffsets();

			[Token(Token = "0x6000C51")]
			[Address(RVA = "0x2FDA0EC", Offset = "0x2FDA0EC", VA = "0x2FDA0EC")]
			public void SetLOD(int LOD)
			{
			}

			[Token(Token = "0x6000C52")]
			[Address(RVA = "0x2FDA0F4", Offset = "0x2FDA0F4", VA = "0x2FDA0F4")]
			public void Read(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index)
			{
			}

			[Token(Token = "0x6000C53")]
			[Address(RVA = "0x2FDA4B0", Offset = "0x2FDA4B0", VA = "0x2FDA4B0")]
			public void MovePosition(Vector3 position)
			{
			}

			[Token(Token = "0x6000C54")]
			[Address(RVA = "0x2FDA61C", Offset = "0x2FDA61C", VA = "0x2FDA61C")]
			public void MoveRotation(Quaternion rotation)
			{
			}

			[Token(Token = "0x6000C55")]
			[Address(RVA = "0x2FDA8AC", Offset = "0x2FDA8AC", VA = "0x2FDA8AC")]
			public void Translate(Vector3 position, Quaternion rotation)
			{
			}

			[Token(Token = "0x6000C56")]
			[Address(RVA = "0x2FDA900", Offset = "0x2FDA900", VA = "0x2FDA900")]
			public void TranslateRoot(Vector3 newRootPos, Quaternion newRootRot)
			{
			}

			[Token(Token = "0x6000C57")]
			[Address(RVA = "0x2FD99B4", Offset = "0x2FD99B4", VA = "0x2FD99B4")]
			public void RotateTo(VirtualBone bone, Quaternion rotation, float weight = 1f)
			{
			}

			[Token(Token = "0x6000C58")]
			[Address(RVA = "0x2FDAAEC", Offset = "0x2FDAAEC", VA = "0x2FDAAEC")]
			public void Visualize(Color color)
			{
			}

			[Token(Token = "0x6000C59")]
			[Address(RVA = "0x2FDAC30", Offset = "0x2FDAC30", VA = "0x2FDAC30")]
			public void Visualize()
			{
			}

			[Token(Token = "0x6000C5A")]
			[Address(RVA = "0x2FDA034", Offset = "0x2FDA034", VA = "0x2FDA034")]
			protected BodyPart()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20001A6")]
		public class Footstep
		{
			[Token(Token = "0x4000A40")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float stepSpeed;

			[Token(Token = "0x4000A41")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public Vector3 characterSpaceOffset;

			[Token(Token = "0x4000A42")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Vector3 position;

			[Token(Token = "0x4000A43")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public Quaternion rotation;

			[Token(Token = "0x4000A44")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public Quaternion stepToRootRot;

			[Token(Token = "0x4000A45")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			public bool isSupportLeg;

			[Token(Token = "0x4000A46")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x14D4C50", Offset = "0x14D4C50")]
			private float <stepProgress>k__BackingField;

			[Token(Token = "0x4000A47")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			public Vector3 stepFrom;

			[Token(Token = "0x4000A48")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			public Vector3 stepTo;

			[Token(Token = "0x4000A49")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
			public Quaternion stepFromRot;

			[Token(Token = "0x4000A4A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
			public Quaternion stepToRot;

			[Token(Token = "0x4000A4B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
			private Quaternion footRelativeToRoot;

			[Token(Token = "0x4000A4C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
			private float supportLegW;

			[Token(Token = "0x4000A4D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			private float supportLegWV;

			[Token(Token = "0x1700009A")]
			public bool isStepping
			{
				[Token(Token = "0x6000C5B")]
				[Address(RVA = "0x2FDAC58", Offset = "0x2FDAC58", VA = "0x2FDAC58")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x1700009B")]
			public float stepProgress
			{
				[Token(Token = "0x6000C5C")]
				[Address(RVA = "0x2FDAC6C", Offset = "0x2FDAC6C", VA = "0x2FDAC6C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x14D99EC", Offset = "0x14D99EC")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000C5D")]
				[Address(RVA = "0x2FDAC74", Offset = "0x2FDAC74", VA = "0x2FDAC74")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x14D99FC", Offset = "0x14D99FC")]
				private set
				{
				}
			}

			[Token(Token = "0x6000C5E")]
			[Address(RVA = "0x2FDAC7C", Offset = "0x2FDAC7C", VA = "0x2FDAC7C")]
			public Footstep(Quaternion rootRotation, Vector3 footPosition, Quaternion footRotation, Vector3 characterSpaceOffset)
			{
			}

			[Token(Token = "0x6000C5F")]
			[Address(RVA = "0x2FDAE0C", Offset = "0x2FDAE0C", VA = "0x2FDAE0C")]
			public void Reset(Quaternion rootRotation, Vector3 footPosition, Quaternion footRotation)
			{
			}

			[Token(Token = "0x6000C60")]
			[Address(RVA = "0x2FDAE54", Offset = "0x2FDAE54", VA = "0x2FDAE54")]
			public void StepTo(Vector3 p, Quaternion rootRotation, float stepThreshold)
			{
			}

			[Token(Token = "0x6000C61")]
			[Address(RVA = "0x2FDB014", Offset = "0x2FDB014", VA = "0x2FDB014")]
			public void UpdateStepping(Vector3 p, Quaternion rootRotation, float speed)
			{
			}

			[Token(Token = "0x6000C62")]
			[Address(RVA = "0x2FDB1EC", Offset = "0x2FDB1EC", VA = "0x2FDB1EC")]
			public void UpdateStanding(Quaternion rootRotation, float minAngle, float speed)
			{
			}

			[Token(Token = "0x6000C63")]
			[Address(RVA = "0x2FDB3D8", Offset = "0x2FDB3D8", VA = "0x2FDB3D8")]
			public void Update(InterpolationMode interpolation, UnityEvent onStep)
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20001A7")]
		public class Leg : BodyPart
		{
			[Token(Token = "0x4000A4E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D4C60", Offset = "0x14D4C60")]
			public Transform target;

			[Token(Token = "0x4000A4F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D4C98", Offset = "0x14D4C98")]
			public Transform bendGoal;

			[Token(Token = "0x4000A50")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D4CD0", Offset = "0x14D4CD0")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x14D4CD0", Offset = "0x14D4CD0")]
			public float positionWeight;

			[Token(Token = "0x4000A51")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D4D24", Offset = "0x14D4D24")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x14D4D24", Offset = "0x14D4D24")]
			public float rotationWeight;

			[Token(Token = "0x4000A52")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D4D78", Offset = "0x14D4D78")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x14D4D78", Offset = "0x14D4D78")]
			public float bendGoalWeight;

			[Token(Token = "0x4000A53")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D4DCC", Offset = "0x14D4DCC")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x14D4DCC", Offset = "0x14D4DCC")]
			public float swivelOffset;

			[Token(Token = "0x4000A54")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D4E28", Offset = "0x14D4E28")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x14D4E28", Offset = "0x14D4E28")]
			public float bendToTargetWeight;

			[Token(Token = "0x4000A55")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D4E7C", Offset = "0x14D4E7C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x14D4E7C", Offset = "0x14D4E7C")]
			public float legLengthMlp;

			[Token(Token = "0x4000A56")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D4ED4", Offset = "0x14D4ED4")]
			public AnimationCurve stretchCurve;

			[NonSerialized]
			[Token(Token = "0x4000A57")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			[HideInInspector]
			public Vector3 IKPosition;

			[NonSerialized]
			[Token(Token = "0x4000A58")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
			[HideInInspector]
			public Quaternion IKRotation;

			[NonSerialized]
			[Token(Token = "0x4000A59")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
			[HideInInspector]
			public Vector3 footPositionOffset;

			[NonSerialized]
			[Token(Token = "0x4000A5A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			[HideInInspector]
			public Vector3 heelPositionOffset;

			[NonSerialized]
			[Token(Token = "0x4000A5B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
			[HideInInspector]
			public Quaternion footRotationOffset;

			[NonSerialized]
			[Token(Token = "0x4000A5C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
			[HideInInspector]
			public float currentMag;

			[Token(Token = "0x4000A5D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
			[HideInInspector]
			public bool useAnimatedBendNormal;

			[Token(Token = "0x4000A5E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x14D4F7C", Offset = "0x14D4F7C")]
			private Vector3 <position>k__BackingField;

			[Token(Token = "0x4000A5F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x14D4F8C", Offset = "0x14D4F8C")]
			private Quaternion <rotation>k__BackingField;

			[Token(Token = "0x4000A60")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x14D4F9C", Offset = "0x14D4F9C")]
			private bool <hasToes>k__BackingField;

			[Token(Token = "0x4000A61")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x14D4FAC", Offset = "0x14D4FAC")]
			private Vector3 <thighRelativeToPelvis>k__BackingField;

			[Token(Token = "0x4000A62")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
			private Vector3 footPosition;

			[Token(Token = "0x4000A63")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xFC")]
			private Quaternion footRotation;

			[Token(Token = "0x4000A64")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10C")]
			private Vector3 bendNormal;

			[Token(Token = "0x4000A65")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
			private Quaternion calfRelToThigh;

			[Token(Token = "0x4000A66")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
			private Quaternion thighRelToFoot;

			[Token(Token = "0x4000A67")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
			private Vector3 bendNormalRelToPelvis;

			[Token(Token = "0x4000A68")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x144")]
			private Vector3 bendNormalRelToTarget;

			[Token(Token = "0x1700009C")]
			public Vector3 position
			{
				[Token(Token = "0x6000C64")]
				[Address(RVA = "0x2FDB5F4", Offset = "0x2FDB5F4", VA = "0x2FDB5F4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x14D9A0C", Offset = "0x14D9A0C")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000C65")]
				[Address(RVA = "0x2FDB600", Offset = "0x2FDB600", VA = "0x2FDB600")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x14D9A1C", Offset = "0x14D9A1C")]
				private set
				{
				}
			}

			[Token(Token = "0x1700009D")]
			public Quaternion rotation
			{
				[Token(Token = "0x6000C66")]
				[Address(RVA = "0x2FDB60C", Offset = "0x2FDB60C", VA = "0x2FDB60C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x14D9A2C", Offset = "0x14D9A2C")]
				get
				{
					return default(Quaternion);
				}
				[Token(Token = "0x6000C67")]
				[Address(RVA = "0x2FDB618", Offset = "0x2FDB618", VA = "0x2FDB618")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x14D9A3C", Offset = "0x14D9A3C")]
				private set
				{
				}
			}

			[Token(Token = "0x1700009E")]
			public bool hasToes
			{
				[Token(Token = "0x6000C68")]
				[Address(RVA = "0x2FDB624", Offset = "0x2FDB624", VA = "0x2FDB624")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x14D9A4C", Offset = "0x14D9A4C")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6000C69")]
				[Address(RVA = "0x2FDB62C", Offset = "0x2FDB62C", VA = "0x2FDB62C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x14D9A5C", Offset = "0x14D9A5C")]
				private set
				{
				}
			}

			[Token(Token = "0x1700009F")]
			public VirtualBone thigh
			{
				[Token(Token = "0x6000C6A")]
				[Address(RVA = "0x2FDB638", Offset = "0x2FDB638", VA = "0x2FDB638")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000A0")]
			private VirtualBone calf
			{
				[Token(Token = "0x6000C6B")]
				[Address(RVA = "0x2FDB66C", Offset = "0x2FDB66C", VA = "0x2FDB66C")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000A1")]
			private VirtualBone foot
			{
				[Token(Token = "0x6000C6C")]
				[Address(RVA = "0x2FDB6A4", Offset = "0x2FDB6A4", VA = "0x2FDB6A4")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000A2")]
			private VirtualBone toes
			{
				[Token(Token = "0x6000C6D")]
				[Address(RVA = "0x2FDB6DC", Offset = "0x2FDB6DC", VA = "0x2FDB6DC")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000A3")]
			public VirtualBone lastBone
			{
				[Token(Token = "0x6000C6E")]
				[Address(RVA = "0x2FDB714", Offset = "0x2FDB714", VA = "0x2FDB714")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000A4")]
			public Vector3 thighRelativeToPelvis
			{
				[Token(Token = "0x6000C6F")]
				[Address(RVA = "0x2FDB754", Offset = "0x2FDB754", VA = "0x2FDB754")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x14D9A6C", Offset = "0x14D9A6C")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000C70")]
				[Address(RVA = "0x2FDB760", Offset = "0x2FDB760", VA = "0x2FDB760")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x14D9A7C", Offset = "0x14D9A7C")]
				private set
				{
				}
			}

			[Token(Token = "0x6000C71")]
			[Address(RVA = "0x2FDB76C", Offset = "0x2FDB76C", VA = "0x2FDB76C", Slot = "4")]
			protected override void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index)
			{
			}

			[Token(Token = "0x6000C72")]
			[Address(RVA = "0x2FDBD88", Offset = "0x2FDBD88", VA = "0x2FDBD88", Slot = "5")]
			public override void PreSolve()
			{
			}

			[Token(Token = "0x6000C73")]
			[Address(RVA = "0x2FDC670", Offset = "0x2FDC670", VA = "0x2FDC670", Slot = "7")]
			public override void ApplyOffsets()
			{
			}

			[Token(Token = "0x6000C74")]
			[Address(RVA = "0x2FDC56C", Offset = "0x2FDC56C", VA = "0x2FDC56C")]
			private void ApplyPositionOffset(Vector3 offset, float weight)
			{
			}

			[Token(Token = "0x6000C75")]
			[Address(RVA = "0x2FDC334", Offset = "0x2FDC334", VA = "0x2FDC334")]
			private void ApplyRotationOffset(Quaternion offset, float weight)
			{
			}

			[Token(Token = "0x6000C76")]
			[Address(RVA = "0x2FDCC28", Offset = "0x2FDCC28", VA = "0x2FDCC28")]
			public void Solve(bool stretch)
			{
			}

			[Token(Token = "0x6000C77")]
			[Address(RVA = "0x2FDD374", Offset = "0x2FDD374", VA = "0x2FDD374")]
			private void FixTwistRotations()
			{
			}

			[Token(Token = "0x6000C78")]
			[Address(RVA = "0x2FDCE48", Offset = "0x2FDCE48", VA = "0x2FDCE48")]
			private void Stretching()
			{
			}

			[Token(Token = "0x6000C79")]
			[Address(RVA = "0x2FDD7DC", Offset = "0x2FDD7DC", VA = "0x2FDD7DC", Slot = "6")]
			public override void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations)
			{
			}

			[Token(Token = "0x6000C7A")]
			[Address(RVA = "0x2FDD9F8", Offset = "0x2FDD9F8", VA = "0x2FDD9F8", Slot = "8")]
			public override void ResetOffsets()
			{
			}

			[Token(Token = "0x6000C7B")]
			[Address(RVA = "0x2FDDAA8", Offset = "0x2FDDAA8", VA = "0x2FDDAA8")]
			public Leg()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20001A8")]
		public class Locomotion
		{
			[Token(Token = "0x4000A69")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D4FBC", Offset = "0x14D4FBC")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x14D4FBC", Offset = "0x14D4FBC")]
			public float weight;

			[Token(Token = "0x4000A6A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D5010", Offset = "0x14D5010")]
			public float footDistance;

			[Token(Token = "0x4000A6B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D5048", Offset = "0x14D5048")]
			public float stepThreshold;

			[Token(Token = "0x4000A6C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D5080", Offset = "0x14D5080")]
			public float angleThreshold;

			[Token(Token = "0x4000A6D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D50B8", Offset = "0x14D50B8")]
			public float comAngleMlp;

			[Token(Token = "0x4000A6E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D50F0", Offset = "0x14D50F0")]
			public float maxVelocity;

			[Token(Token = "0x4000A6F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D5128", Offset = "0x14D5128")]
			public float velocityFactor;

			[Token(Token = "0x4000A70")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D5160", Offset = "0x14D5160")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x14D5160", Offset = "0x14D5160")]
			public float maxLegStretch;

			[Token(Token = "0x4000A71")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D51B8", Offset = "0x14D51B8")]
			public float rootSpeed;

			[Token(Token = "0x4000A72")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D51F0", Offset = "0x14D51F0")]
			public float stepSpeed;

			[Token(Token = "0x4000A73")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D5228", Offset = "0x14D5228")]
			public AnimationCurve stepHeight;

			[Token(Token = "0x4000A74")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D5260", Offset = "0x14D5260")]
			public AnimationCurve heelHeight;

			[Token(Token = "0x4000A75")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D5298", Offset = "0x14D5298")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x14D5298", Offset = "0x14D5298")]
			public float relaxLegTwistMinAngle;

			[Token(Token = "0x4000A76")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D52F0", Offset = "0x14D52F0")]
			public float relaxLegTwistSpeed;

			[Token(Token = "0x4000A77")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D5328", Offset = "0x14D5328")]
			public InterpolationMode stepInterpolation;

			[Token(Token = "0x4000A78")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D5360", Offset = "0x14D5360")]
			public Vector3 offset;

			[Token(Token = "0x4000A79")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[HideInInspector]
			public bool blockingEnabled;

			[Token(Token = "0x4000A7A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			[HideInInspector]
			public LayerMask blockingLayers;

			[Token(Token = "0x4000A7B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			[HideInInspector]
			public float raycastRadius;

			[Token(Token = "0x4000A7C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
			[HideInInspector]
			public float raycastHeight;

			[Token(Token = "0x4000A7D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D53D8", Offset = "0x14D53D8")]
			public UnityEvent onLeftFootstep;

			[Token(Token = "0x4000A7E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D5410", Offset = "0x14D5410")]
			public UnityEvent onRightFootstep;

			[Token(Token = "0x4000A7F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x14D5448", Offset = "0x14D5448")]
			private Vector3 <centerOfMass>k__BackingField;

			[Token(Token = "0x4000A80")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			private Footstep[] footsteps;

			[Token(Token = "0x4000A81")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			private Vector3 lastComPosition;

			[Token(Token = "0x4000A82")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
			private Vector3 comVelocity;

			[Token(Token = "0x4000A83")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
			private int leftFootIndex;

			[Token(Token = "0x4000A84")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
			private int rightFootIndex;

			[Token(Token = "0x170000A5")]
			public Vector3 centerOfMass
			{
				[Token(Token = "0x6000C7C")]
				[Address(RVA = "0x2FDDB9C", Offset = "0x2FDDB9C", VA = "0x2FDDB9C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x14D9A8C", Offset = "0x14D9A8C")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000C7D")]
				[Address(RVA = "0x2FDDBA8", Offset = "0x2FDDBA8", VA = "0x2FDDBA8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x14D9A9C", Offset = "0x14D9A9C")]
				private set
				{
				}
			}

			[Token(Token = "0x170000A6")]
			public Vector3 leftFootstepPosition
			{
				[Token(Token = "0x6000C83")]
				[Address(RVA = "0x2FE0084", Offset = "0x2FE0084", VA = "0x2FE0084")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x170000A7")]
			public Vector3 rightFootstepPosition
			{
				[Token(Token = "0x6000C84")]
				[Address(RVA = "0x2FE00C4", Offset = "0x2FE00C4", VA = "0x2FE00C4")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x170000A8")]
			public Quaternion leftFootstepRotation
			{
				[Token(Token = "0x6000C85")]
				[Address(RVA = "0x2FE0108", Offset = "0x2FE0108", VA = "0x2FE0108")]
				get
				{
					return default(Quaternion);
				}
			}

			[Token(Token = "0x170000A9")]
			public Quaternion rightFootstepRotation
			{
				[Token(Token = "0x6000C86")]
				[Address(RVA = "0x2FE0148", Offset = "0x2FE0148", VA = "0x2FE0148")]
				get
				{
					return default(Quaternion);
				}
			}

			[Token(Token = "0x6000C7E")]
			[Address(RVA = "0x2FDDBB4", Offset = "0x2FDDBB4", VA = "0x2FDDBB4")]
			public void Initiate(Vector3[] positions, Quaternion[] rotations, bool hasToes)
			{
			}

			[Token(Token = "0x6000C7F")]
			[Address(RVA = "0x2FDDEAC", Offset = "0x2FDDEAC", VA = "0x2FDDEAC")]
			public void Reset(Vector3[] positions, Quaternion[] rotations)
			{
			}

			[Token(Token = "0x6000C80")]
			[Address(RVA = "0x2FDE120", Offset = "0x2FDE120", VA = "0x2FDE120")]
			public void AddDeltaRotation(Quaternion delta, Vector3 pivot)
			{
			}

			[Token(Token = "0x6000C81")]
			[Address(RVA = "0x2FDE4F8", Offset = "0x2FDE4F8", VA = "0x2FDE4F8")]
			public void AddDeltaPosition(Vector3 delta)
			{
			}

			[Token(Token = "0x6000C82")]
			[Address(RVA = "0x2FDE6A8", Offset = "0x2FDE6A8", VA = "0x2FDE6A8")]
			public void Solve(VirtualBone rootBone, Spine spine, Leg leftLeg, Leg rightLeg, Arm leftArm, Arm rightArm, int supportLegIndex, out Vector3 leftFootPosition, out Vector3 rightFootPosition, out Quaternion leftFootRotation, out Quaternion rightFootRotation, out float leftFootOffset, out float rightFootOffset, out float leftHeelOffset, out float rightHeelOffset)
			{
			}

			[Token(Token = "0x6000C87")]
			[Address(RVA = "0x2FDFC90", Offset = "0x2FDFC90", VA = "0x2FDFC90")]
			private bool StepBlocked(Vector3 fromPosition, Vector3 toPosition, Vector3 rootPosition)
			{
				return default(bool);
			}

			[Token(Token = "0x6000C88")]
			[Address(RVA = "0x2FDFE34", Offset = "0x2FDFE34", VA = "0x2FDFE34")]
			private bool CanStep()
			{
				return default(bool);
			}

			[Token(Token = "0x6000C89")]
			[Address(RVA = "0x2FDFEB8", Offset = "0x2FDFEB8", VA = "0x2FDFEB8")]
			private static bool GetLineSphereCollision(Vector3 lineStart, Vector3 lineEnd, Vector3 sphereCenter, float sphereRadius)
			{
				return default(bool);
			}

			[Token(Token = "0x6000C8A")]
			[Address(RVA = "0x2FE018C", Offset = "0x2FE018C", VA = "0x2FE018C")]
			public Locomotion()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20001A9")]
		public class Spine : BodyPart
		{
			[Token(Token = "0x4000A85")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D5458", Offset = "0x14D5458")]
			public Transform headTarget;

			[Token(Token = "0x4000A86")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D5490", Offset = "0x14D5490")]
			public Transform pelvisTarget;

			[Token(Token = "0x4000A87")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D54C8", Offset = "0x14D54C8")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x14D54C8", Offset = "0x14D54C8")]
			public float positionWeight;

			[Token(Token = "0x4000A88")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D551C", Offset = "0x14D551C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x14D551C", Offset = "0x14D551C")]
			public float rotationWeight;

			[Token(Token = "0x4000A89")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D5570", Offset = "0x14D5570")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x14D5570", Offset = "0x14D5570")]
			public float pelvisPositionWeight;

			[Token(Token = "0x4000A8A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D55C4", Offset = "0x14D55C4")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x14D55C4", Offset = "0x14D55C4")]
			public float pelvisRotationWeight;

			[Token(Token = "0x4000A8B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D5618", Offset = "0x14D5618")]
			public Transform chestGoal;

			[Token(Token = "0x4000A8C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D5650", Offset = "0x14D5650")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x14D5650", Offset = "0x14D5650")]
			public float chestGoalWeight;

			[Token(Token = "0x4000A8D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D56A4", Offset = "0x14D56A4")]
			public float minHeadHeight;

			[Token(Token = "0x4000A8E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D56DC", Offset = "0x14D56DC")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x14D56DC", Offset = "0x14D56DC")]
			public float bodyPosStiffness;

			[Token(Token = "0x4000A8F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D5730", Offset = "0x14D5730")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x14D5730", Offset = "0x14D5730")]
			public float bodyRotStiffness;

			[Token(Token = "0x4000A90")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D5784", Offset = "0x14D5784")]
			[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x14D5784", Offset = "0x14D5784")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x14D5784", Offset = "0x14D5784")]
			public float neckStiffness;

			[Token(Token = "0x4000A91")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D57FC", Offset = "0x14D57FC")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x14D57FC", Offset = "0x14D57FC")]
			public float rotateChestByHands;

			[Token(Token = "0x4000A92")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D5850", Offset = "0x14D5850")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x14D5850", Offset = "0x14D5850")]
			public float chestClampWeight;

			[Token(Token = "0x4000A93")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D58A4", Offset = "0x14D58A4")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x14D58A4", Offset = "0x14D58A4")]
			public float headClampWeight;

			[Token(Token = "0x4000A94")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D58F8", Offset = "0x14D58F8")]
			public float moveBodyBackWhenCrouching;

			[Token(Token = "0x4000A95")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D5930", Offset = "0x14D5930")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x14D5930", Offset = "0x14D5930")]
			public float maintainPelvisPosition;

			[Token(Token = "0x4000A96")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D5984", Offset = "0x14D5984")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x14D5984", Offset = "0x14D5984")]
			public float maxRootAngle;

			[Token(Token = "0x4000A97")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D59DC", Offset = "0x14D59DC")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x14D59DC", Offset = "0x14D59DC")]
			public float rootHeadingOffset;

			[NonSerialized]
			[Token(Token = "0x4000A98")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			[HideInInspector]
			public Vector3 IKPositionHead;

			[NonSerialized]
			[Token(Token = "0x4000A99")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
			[HideInInspector]
			public Quaternion IKRotationHead;

			[NonSerialized]
			[Token(Token = "0x4000A9A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
			[HideInInspector]
			public Vector3 IKPositionPelvis;

			[NonSerialized]
			[Token(Token = "0x4000A9B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
			[HideInInspector]
			public Quaternion IKRotationPelvis;

			[NonSerialized]
			[Token(Token = "0x4000A9C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
			[HideInInspector]
			public Vector3 goalPositionChest;

			[NonSerialized]
			[Token(Token = "0x4000A9D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
			[HideInInspector]
			public Vector3 pelvisPositionOffset;

			[NonSerialized]
			[Token(Token = "0x4000A9E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
			[HideInInspector]
			public Vector3 chestPositionOffset;

			[NonSerialized]
			[Token(Token = "0x4000A9F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xFC")]
			[HideInInspector]
			public Vector3 headPositionOffset;

			[NonSerialized]
			[Token(Token = "0x4000AA0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
			[HideInInspector]
			public Quaternion pelvisRotationOffset;

			[NonSerialized]
			[Token(Token = "0x4000AA1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
			[HideInInspector]
			public Quaternion chestRotationOffset;

			[NonSerialized]
			[Token(Token = "0x4000AA2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
			[HideInInspector]
			public Quaternion headRotationOffset;

			[NonSerialized]
			[Token(Token = "0x4000AA3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
			[HideInInspector]
			public Vector3 faceDirection;

			[NonSerialized]
			[Token(Token = "0x4000AA4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x144")]
			[HideInInspector]
			public Vector3 locomotionHeadPositionOffset;

			[NonSerialized]
			[Token(Token = "0x4000AA5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
			[HideInInspector]
			public Vector3 headPosition;

			[Token(Token = "0x4000AA6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x15C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x14D5B18", Offset = "0x14D5B18")]
			private Quaternion <anchorRotation>k__BackingField;

			[Token(Token = "0x4000AA7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x16C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x14D5B28", Offset = "0x14D5B28")]
			private Quaternion <anchorRelativeToHead>k__BackingField;

			[Token(Token = "0x4000AA8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x17C")]
			private Quaternion headRotation;

			[Token(Token = "0x4000AA9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18C")]
			private Quaternion pelvisRotation;

			[Token(Token = "0x4000AAA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x19C")]
			private Quaternion anchorRelativeToPelvis;

			[Token(Token = "0x4000AAB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1AC")]
			private Quaternion pelvisRelativeRotation;

			[Token(Token = "0x4000AAC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1BC")]
			private Quaternion chestRelativeRotation;

			[Token(Token = "0x4000AAD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1CC")]
			private Vector3 headDeltaPosition;

			[Token(Token = "0x4000AAE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1D8")]
			private Quaternion pelvisDeltaRotation;

			[Token(Token = "0x4000AAF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1E8")]
			private Quaternion chestTargetRotation;

			[Token(Token = "0x4000AB0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1F8")]
			private int pelvisIndex;

			[Token(Token = "0x4000AB1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1FC")]
			private int spineIndex;

			[Token(Token = "0x4000AB2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x200")]
			private int chestIndex;

			[Token(Token = "0x4000AB3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x204")]
			private int neckIndex;

			[Token(Token = "0x4000AB4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x208")]
			private int headIndex;

			[Token(Token = "0x4000AB5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20C")]
			private float length;

			[Token(Token = "0x4000AB6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x210")]
			private bool hasChest;

			[Token(Token = "0x4000AB7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x211")]
			private bool hasNeck;

			[Token(Token = "0x4000AB8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x212")]
			private bool hasLegs;

			[Token(Token = "0x4000AB9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x214")]
			private float headHeight;

			[Token(Token = "0x4000ABA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x218")]
			private float sizeMlp;

			[Token(Token = "0x4000ABB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x21C")]
			private Vector3 chestForward;

			[Token(Token = "0x170000AA")]
			public VirtualBone pelvis
			{
				[Token(Token = "0x6000C8B")]
				[Address(RVA = "0x2FDFC10", Offset = "0x2FDFC10", VA = "0x2FDFC10")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000AB")]
			public VirtualBone firstSpineBone
			{
				[Token(Token = "0x6000C8C")]
				[Address(RVA = "0x2FE0270", Offset = "0x2FE0270", VA = "0x2FE0270")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000AC")]
			public VirtualBone chest
			{
				[Token(Token = "0x6000C8D")]
				[Address(RVA = "0x2FE02B0", Offset = "0x2FE02B0", VA = "0x2FE02B0")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000AD")]
			private VirtualBone neck
			{
				[Token(Token = "0x6000C8E")]
				[Address(RVA = "0x2FE0304", Offset = "0x2FE0304", VA = "0x2FE0304")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000AE")]
			public VirtualBone head
			{
				[Token(Token = "0x6000C8F")]
				[Address(RVA = "0x2FDFC50", Offset = "0x2FDFC50", VA = "0x2FDFC50")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000AF")]
			public Quaternion anchorRotation
			{
				[Token(Token = "0x6000C90")]
				[Address(RVA = "0x2FE0344", Offset = "0x2FE0344", VA = "0x2FE0344")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x14D9AAC", Offset = "0x14D9AAC")]
				get
				{
					return default(Quaternion);
				}
				[Token(Token = "0x6000C91")]
				[Address(RVA = "0x2FE0358", Offset = "0x2FE0358", VA = "0x2FE0358")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x14D9ABC", Offset = "0x14D9ABC")]
				private set
				{
				}
			}

			[Token(Token = "0x170000B0")]
			public Quaternion anchorRelativeToHead
			{
				[Token(Token = "0x6000C92")]
				[Address(RVA = "0x2FE036C", Offset = "0x2FE036C", VA = "0x2FE036C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x14D9ACC", Offset = "0x14D9ACC")]
				get
				{
					return default(Quaternion);
				}
				[Token(Token = "0x6000C93")]
				[Address(RVA = "0x2FE0380", Offset = "0x2FE0380", VA = "0x2FE0380")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x14D9ADC", Offset = "0x14D9ADC")]
				private set
				{
				}
			}

			[Token(Token = "0x6000C94")]
			[Address(RVA = "0x2FE0394", Offset = "0x2FE0394", VA = "0x2FE0394", Slot = "4")]
			protected override void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index)
			{
			}

			[Token(Token = "0x6000C95")]
			[Address(RVA = "0x2FE0E60", Offset = "0x2FE0E60", VA = "0x2FE0E60", Slot = "5")]
			public override void PreSolve()
			{
			}

			[Token(Token = "0x6000C96")]
			[Address(RVA = "0x2FE1070", Offset = "0x2FE1070", VA = "0x2FE1070", Slot = "7")]
			public override void ApplyOffsets()
			{
			}

			[Token(Token = "0x6000C97")]
			[Address(RVA = "0x2FE16E8", Offset = "0x2FE16E8", VA = "0x2FE16E8")]
			private void CalculateChestTargetRotation(VirtualBone rootBone, Arm[] arms)
			{
			}

			[Token(Token = "0x6000C98")]
			[Address(RVA = "0x2FE1CA8", Offset = "0x2FE1CA8", VA = "0x2FE1CA8")]
			public void Solve(VirtualBone rootBone, Leg[] legs, Arm[] arms)
			{
			}

			[Token(Token = "0x6000C99")]
			[Address(RVA = "0x2FE26E8", Offset = "0x2FE26E8", VA = "0x2FE26E8")]
			private void FABRIKPass(Vector3 animatedPelvisPos, Vector3 rootUp, float weight)
			{
			}

			[Token(Token = "0x6000C9A")]
			[Address(RVA = "0x2FE2F14", Offset = "0x2FE2F14", VA = "0x2FE2F14")]
			private void SolvePelvis()
			{
			}

			[Token(Token = "0x6000C9B")]
			[Address(RVA = "0x2FE36FC", Offset = "0x2FE36FC", VA = "0x2FE36FC", Slot = "6")]
			public override void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations)
			{
			}

			[Token(Token = "0x6000C9C")]
			[Address(RVA = "0x2FE38D8", Offset = "0x2FE38D8", VA = "0x2FE38D8", Slot = "8")]
			public override void ResetOffsets()
			{
			}

			[Token(Token = "0x6000C9D")]
			[Address(RVA = "0x2FE1918", Offset = "0x2FE1918", VA = "0x2FE1918")]
			private void AdjustChestByHands(ref Quaternion chestTargetRotation, Arm[] arms)
			{
			}

			[Token(Token = "0x6000C9E")]
			[Address(RVA = "0x2FE2B5C", Offset = "0x2FE2B5C", VA = "0x2FE2B5C")]
			public void InverseTranslateToHead(Leg[] legs, bool limited, bool useCurrentLegMag, Vector3 offset, float w)
			{
			}

			[Token(Token = "0x6000C9F")]
			[Address(RVA = "0x2FE22CC", Offset = "0x2FE22CC", VA = "0x2FE22CC")]
			private void TranslatePelvis(Leg[] legs, Vector3 deltaPosition, Quaternion deltaRotation)
			{
			}

			[Token(Token = "0x6000CA0")]
			[Address(RVA = "0x2FE39D4", Offset = "0x2FE39D4", VA = "0x2FE39D4")]
			private Vector3 LimitPelvisPosition(Leg[] legs, Vector3 pelvisPosition, bool useCurrentLegMag, int it = 2)
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000CA1")]
			[Address(RVA = "0x2FE2CC8", Offset = "0x2FE2CC8", VA = "0x2FE2CC8")]
			private void Bend(VirtualBone[] bones, int firstIndex, int lastIndex, Quaternion targetRotation, float clampWeight, bool uniformWeight, float w)
			{
			}

			[Token(Token = "0x6000CA2")]
			[Address(RVA = "0x2FE28A8", Offset = "0x2FE28A8", VA = "0x2FE28A8")]
			private void Bend(VirtualBone[] bones, int firstIndex, int lastIndex, Quaternion targetRotation, Quaternion rotationOffset, float clampWeight, bool uniformWeight, float w)
			{
			}

			[Token(Token = "0x6000CA3")]
			[Address(RVA = "0x2FE3CFC", Offset = "0x2FE3CFC", VA = "0x2FE3CFC")]
			public Spine()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20001AA")]
		public enum PositionOffset
		{
			[Token(Token = "0x4000ABD")]
			Pelvis,
			[Token(Token = "0x4000ABE")]
			Chest,
			[Token(Token = "0x4000ABF")]
			Head,
			[Token(Token = "0x4000AC0")]
			LeftHand,
			[Token(Token = "0x4000AC1")]
			RightHand,
			[Token(Token = "0x4000AC2")]
			LeftFoot,
			[Token(Token = "0x4000AC3")]
			RightFoot,
			[Token(Token = "0x4000AC4")]
			LeftHeel,
			[Token(Token = "0x4000AC5")]
			RightHeel
		}

		[Serializable]
		[Token(Token = "0x20001AB")]
		public enum RotationOffset
		{
			[Token(Token = "0x4000AC7")]
			Pelvis,
			[Token(Token = "0x4000AC8")]
			Chest,
			[Token(Token = "0x4000AC9")]
			Head
		}

		[Serializable]
		[Token(Token = "0x20001AC")]
		public class VirtualBone
		{
			[Token(Token = "0x4000ACA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Vector3 readPosition;

			[Token(Token = "0x4000ACB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public Quaternion readRotation;

			[Token(Token = "0x4000ACC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public Vector3 solverPosition;

			[Token(Token = "0x4000ACD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Quaternion solverRotation;

			[Token(Token = "0x4000ACE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public float length;

			[Token(Token = "0x4000ACF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			public float sqrMag;

			[Token(Token = "0x4000AD0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public Vector3 axis;

			[Token(Token = "0x6000CA4")]
			[Address(RVA = "0x2FD6E9C", Offset = "0x2FD6E9C", VA = "0x2FD6E9C")]
			public VirtualBone(Vector3 position, Quaternion rotation)
			{
			}

			[Token(Token = "0x6000CA5")]
			[Address(RVA = "0x2FD6F18", Offset = "0x2FD6F18", VA = "0x2FD6F18")]
			public void Read(Vector3 position, Quaternion rotation)
			{
			}

			[Token(Token = "0x6000CA6")]
			[Address(RVA = "0x2FE3EB0", Offset = "0x2FE3EB0", VA = "0x2FE3EB0")]
			public static void SwingRotation(VirtualBone[] bones, int index, Vector3 swingTarget, float weight = 1f)
			{
			}

			[Token(Token = "0x6000CA7")]
			[Address(RVA = "0x2FDA1C4", Offset = "0x2FDA1C4", VA = "0x2FDA1C4")]
			public static float PreSolve(ref VirtualBone[] bones)
			{
				return default(float);
			}

			[Token(Token = "0x6000CA8")]
			[Address(RVA = "0x2FDA6C4", Offset = "0x2FDA6C4", VA = "0x2FDA6C4")]
			public static void RotateAroundPoint(VirtualBone[] bones, int index, Vector3 point, Quaternion rotation)
			{
			}

			[Token(Token = "0x6000CA9")]
			[Address(RVA = "0x2FE4140", Offset = "0x2FE4140", VA = "0x2FE4140")]
			public static void RotateBy(VirtualBone[] bones, int index, Quaternion rotation)
			{
			}

			[Token(Token = "0x6000CAA")]
			[Address(RVA = "0x2FD8C1C", Offset = "0x2FD8C1C", VA = "0x2FD8C1C")]
			public static void RotateBy(VirtualBone[] bones, Quaternion rotation)
			{
			}

			[Token(Token = "0x6000CAB")]
			[Address(RVA = "0x2FE4378", Offset = "0x2FE4378", VA = "0x2FE4378")]
			public static void RotateTo(VirtualBone[] bones, int index, Quaternion rotation)
			{
			}

			[Token(Token = "0x6000CAC")]
			[Address(RVA = "0x2FD9408", Offset = "0x2FD9408", VA = "0x2FD9408")]
			public static void SolveTrigonometric(VirtualBone[] bones, int first, int second, int third, Vector3 targetPosition, Vector3 bendNormal, float weight)
			{
			}

			[Token(Token = "0x6000CAD")]
			[Address(RVA = "0x2FE4430", Offset = "0x2FE4430", VA = "0x2FE4430")]
			private static Vector3 GetDirectionToBendPoint(Vector3 direction, float directionMag, Vector3 bendDirection, float sqrMag1, float sqrMag2)
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000CAE")]
			[Address(RVA = "0x2FE329C", Offset = "0x2FE329C", VA = "0x2FE329C")]
			public static void SolveFABRIK(VirtualBone[] bones, Vector3 startPosition, Vector3 targetPosition, float weight, float minNormalizedTargetDistance, int iterations, float length, Vector3 startOffset)
			{
			}

			[Token(Token = "0x6000CAF")]
			[Address(RVA = "0x2FE4648", Offset = "0x2FE4648", VA = "0x2FE4648")]
			private static Vector3 SolveFABRIKJoint(Vector3 pos1, Vector3 pos2, float length)
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000CB0")]
			[Address(RVA = "0x2FE4750", Offset = "0x2FE4750", VA = "0x2FE4750")]
			public static void SolveCCD(VirtualBone[] bones, Vector3 targetPosition, float weight, int iterations)
			{
			}
		}

		[Token(Token = "0x4000305")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Transform[] solverTransforms;

		[Token(Token = "0x4000306")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private bool hasChest;

		[Token(Token = "0x4000307")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x61")]
		private bool hasNeck;

		[Token(Token = "0x4000308")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x62")]
		private bool hasShoulders;

		[Token(Token = "0x4000309")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x63")]
		private bool hasToes;

		[Token(Token = "0x400030A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private bool hasLegs;

		[Token(Token = "0x400030B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Vector3[] readPositions;

		[Token(Token = "0x400030C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Quaternion[] readRotations;

		[Token(Token = "0x400030D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Vector3[] solvedPositions;

		[Token(Token = "0x400030E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Quaternion[] solvedRotations;

		[Token(Token = "0x400030F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Quaternion[] defaultLocalRotations;

		[Token(Token = "0x4000310")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Vector3[] defaultLocalPositions;

		[Token(Token = "0x4000311")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Vector3 rootV;

		[Token(Token = "0x4000312")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		private Vector3 rootVelocity;

		[Token(Token = "0x4000313")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Vector3 bodyOffset;

		[Token(Token = "0x4000314")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		private int supportLegIndex;

		[Token(Token = "0x4000315")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private int lastLOD;

		[Token(Token = "0x4000316")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D26BC", Offset = "0x14D26BC")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x14D26BC", Offset = "0x14D26BC")]
		public int LOD;

		[Token(Token = "0x4000317")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D2710", Offset = "0x14D2710")]
		public bool plantFeet;

		[Token(Token = "0x4000318")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x14D2748", Offset = "0x14D2748")]
		private VirtualBone <rootBone>k__BackingField;

		[Token(Token = "0x4000319")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D2758", Offset = "0x14D2758")]
		public Spine spine;

		[Token(Token = "0x400031A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D2790", Offset = "0x14D2790")]
		public Arm leftArm;

		[Token(Token = "0x400031B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D27C8", Offset = "0x14D27C8")]
		public Arm rightArm;

		[Token(Token = "0x400031C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D2800", Offset = "0x14D2800")]
		public Leg leftLeg;

		[Token(Token = "0x400031D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D2838", Offset = "0x14D2838")]
		public Leg rightLeg;

		[Token(Token = "0x400031E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D2870", Offset = "0x14D2870")]
		public Locomotion locomotion;

		[Token(Token = "0x400031F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private Leg[] legs;

		[Token(Token = "0x4000320")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private Arm[] arms;

		[Token(Token = "0x4000321")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private Vector3 headPosition;

		[Token(Token = "0x4000322")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x124")]
		private Vector3 headDeltaPosition;

		[Token(Token = "0x4000323")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private Vector3 raycastOriginPelvis;

		[Token(Token = "0x4000324")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x13C")]
		private Vector3 lastOffset;

		[Token(Token = "0x4000325")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		private Vector3 debugPos1;

		[Token(Token = "0x4000326")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x154")]
		private Vector3 debugPos2;

		[Token(Token = "0x4000327")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		private Vector3 debugPos3;

		[Token(Token = "0x4000328")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x16C")]
		private Vector3 debugPos4;

		[Token(Token = "0x17000050")]
		[HideInInspector]
		public VirtualBone rootBone
		{
			[Token(Token = "0x60003CD")]
			[Address(RVA = "0x2CCA1EC", Offset = "0x2CCA1EC", VA = "0x2CCA1EC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x14D8A14", Offset = "0x14D8A14")]
			get
			{
				return null;
			}
			[Token(Token = "0x60003CE")]
			[Address(RVA = "0x2CCA1F4", Offset = "0x2CCA1F4", VA = "0x2CCA1F4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x14D8A24", Offset = "0x14D8A24")]
			private set
			{
			}
		}

		[Token(Token = "0x60003B4")]
		[Address(RVA = "0x2CC59E4", Offset = "0x2CC59E4", VA = "0x2CC59E4")]
		public void SetToReferences(VRIK.References references)
		{
		}

		[Token(Token = "0x60003B5")]
		[Address(RVA = "0x2CC5E20", Offset = "0x2CC5E20", VA = "0x2CC5E20")]
		public void GuessHandOrientations(VRIK.References references, bool onlyIfZero)
		{
		}

		[Token(Token = "0x60003B6")]
		[Address(RVA = "0x2CC5CC8", Offset = "0x2CC5CC8", VA = "0x2CC5CC8")]
		public void DefaultAnimationCurves()
		{
		}

		[Token(Token = "0x60003B7")]
		[Address(RVA = "0x2CC680C", Offset = "0x2CC680C", VA = "0x2CC680C")]
		public void AddPositionOffset(PositionOffset positionOffset, Vector3 value)
		{
		}

		[Token(Token = "0x60003B8")]
		[Address(RVA = "0x2CC6AE8", Offset = "0x2CC6AE8", VA = "0x2CC6AE8")]
		public void AddRotationOffset(RotationOffset rotationOffset, Vector3 value)
		{
		}

		[Token(Token = "0x60003B9")]
		[Address(RVA = "0x2CC6B8C", Offset = "0x2CC6B8C", VA = "0x2CC6B8C")]
		public void AddRotationOffset(RotationOffset rotationOffset, Quaternion value)
		{
		}

		[Token(Token = "0x60003BA")]
		[Address(RVA = "0x2CC6D20", Offset = "0x2CC6D20", VA = "0x2CC6D20")]
		public void AddPlatformMotion(Vector3 deltaPosition, Quaternion deltaRotation, Vector3 platformPivot)
		{
		}

		[Token(Token = "0x60003BB")]
		[Address(RVA = "0x2CC6EAC", Offset = "0x2CC6EAC", VA = "0x2CC6EAC")]
		public void Reset()
		{
		}

		[Token(Token = "0x60003BC")]
		[Address(RVA = "0x2CC76D0", Offset = "0x2CC76D0", VA = "0x2CC76D0", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60003BD")]
		[Address(RVA = "0x2CC7844", Offset = "0x2CC7844", VA = "0x2CC7844", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x60003BE")]
		[Address(RVA = "0x2CC7A4C", Offset = "0x2CC7A4C", VA = "0x2CC7A4C", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x60003BF")]
		[Address(RVA = "0x2CC7AC0", Offset = "0x2CC7AC0", VA = "0x2CC7AC0", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x60003C0")]
		[Address(RVA = "0x2CC7B34", Offset = "0x2CC7B34", VA = "0x2CC7B34", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60003C1")]
		[Address(RVA = "0x2CC7D48", Offset = "0x2CC7D48", VA = "0x2CC7D48")]
		private Vector3 GetNormal(Transform[] transforms)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003C2")]
		[Address(RVA = "0x2CC60C0", Offset = "0x2CC60C0", VA = "0x2CC60C0")]
		private Vector3 GuessWristToPalmAxis(Transform hand, Transform forearm)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003C3")]
		[Address(RVA = "0x2CC6298", Offset = "0x2CC6298", VA = "0x2CC6298")]
		private Vector3 GuessPalmToThumbAxis(Transform hand, Transform forearm)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003C4")]
		[Address(RVA = "0x2CC66E8", Offset = "0x2CC66E8", VA = "0x2CC66E8")]
		private static Keyframe[] GetSineKeyframes(float mag)
		{
			return null;
		}

		[Token(Token = "0x60003C5")]
		[Address(RVA = "0x2CC7024", Offset = "0x2CC7024", VA = "0x2CC7024")]
		private void UpdateSolverTransforms()
		{
		}

		[Token(Token = "0x60003C6")]
		[Address(RVA = "0x2CC8028", Offset = "0x2CC8028", VA = "0x2CC8028", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x60003C7")]
		[Address(RVA = "0x2CC8070", Offset = "0x2CC8070", VA = "0x2CC8070", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x60003C8")]
		[Address(RVA = "0x2CC9774", Offset = "0x2CC9774", VA = "0x2CC9774")]
		private void WriteTransforms()
		{
		}

		[Token(Token = "0x60003C9")]
		[Address(RVA = "0x2CC718C", Offset = "0x2CC718C", VA = "0x2CC718C")]
		private void Read(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs)
		{
		}

		[Token(Token = "0x60003CA")]
		[Address(RVA = "0x2CC8538", Offset = "0x2CC8538", VA = "0x2CC8538")]
		private void Solve()
		{
		}

		[Token(Token = "0x60003CB")]
		[Address(RVA = "0x2CC9B60", Offset = "0x2CC9B60", VA = "0x2CC9B60")]
		private Vector3 GetPosition(int index)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003CC")]
		[Address(RVA = "0x2CC9BA8", Offset = "0x2CC9BA8", VA = "0x2CC9BA8")]
		private Quaternion GetRotation(int index)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60003CF")]
		[Address(RVA = "0x2CC9624", Offset = "0x2CC9624", VA = "0x2CC9624")]
		private void Write()
		{
		}

		[Token(Token = "0x60003D0")]
		[Address(RVA = "0x2CC9BEC", Offset = "0x2CC9BEC", VA = "0x2CC9BEC")]
		private Vector3 GetPelvisOffset()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003D1")]
		[Address(RVA = "0x2CCA1FC", Offset = "0x2CCA1FC", VA = "0x2CCA1FC")]
		public IKSolverVR()
		{
		}
	}
	[Token(Token = "0x2000064")]
	public class TwistRelaxer : MonoBehaviour
	{
		[Token(Token = "0x4000329")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public IK ik;

		[Token(Token = "0x400032A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D28A8", Offset = "0x14D28A8")]
		public Transform parent;

		[Token(Token = "0x400032B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D28E0", Offset = "0x14D28E0")]
		public Transform child;

		[Token(Token = "0x400032C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D2918", Offset = "0x14D2918")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x14D2918", Offset = "0x14D2918")]
		public float weight;

		[Token(Token = "0x400032D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D296C", Offset = "0x14D296C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x14D296C", Offset = "0x14D296C")]
		public float parentChildCrossfade;

		[Token(Token = "0x400032E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D29C0", Offset = "0x14D29C0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x14D29C0", Offset = "0x14D29C0")]
		public float twistAngleOffset;

		[Token(Token = "0x400032F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private Vector3 twistAxis;

		[Token(Token = "0x4000330")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Vector3 axis;

		[Token(Token = "0x4000331")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private Vector3 axisRelativeToParentDefault;

		[Token(Token = "0x4000332")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Vector3 axisRelativeToChildDefault;

		[Token(Token = "0x60003D2")]
		[Address(RVA = "0x29921B8", Offset = "0x29921B8", VA = "0x29921B8")]
		public void Relax()
		{
		}

		[Token(Token = "0x60003D3")]
		[Address(RVA = "0x2992598", Offset = "0x2992598", VA = "0x2992598")]
		private void Start()
		{
		}

		[Token(Token = "0x60003D4")]
		[Address(RVA = "0x2992A0C", Offset = "0x2992A0C", VA = "0x2992A0C")]
		private void OnPostUpdate()
		{
		}

		[Token(Token = "0x60003D5")]
		[Address(RVA = "0x2992A94", Offset = "0x2992A94", VA = "0x2992A94")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60003D6")]
		[Address(RVA = "0x2992B1C", Offset = "0x2992B1C", VA = "0x2992B1C")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60003D7")]
		[Address(RVA = "0x2992C20", Offset = "0x2992C20", VA = "0x2992C20")]
		public TwistRelaxer()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000065")]
	public class InteractionEffector
	{
		[Token(Token = "0x4000333")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x14D2A1C", Offset = "0x14D2A1C")]
		private FullBodyBipedEffector <effectorType>k__BackingField;

		[Token(Token = "0x4000334")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x14D2A2C", Offset = "0x14D2A2C")]
		private bool <isPaused>k__BackingField;

		[Token(Token = "0x4000335")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x14D2A3C", Offset = "0x14D2A3C")]
		private InteractionObject <interactionObject>k__BackingField;

		[Token(Token = "0x4000336")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Poser poser;

		[Token(Token = "0x4000337")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private IKEffector effector;

		[Token(Token = "0x4000338")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float timer;

		[Token(Token = "0x4000339")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private float length;

		[Token(Token = "0x400033A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private float weight;

		[Token(Token = "0x400033B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private float fadeInSpeed;

		[Token(Token = "0x400033C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private float defaultPositionWeight;

		[Token(Token = "0x400033D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private float defaultRotationWeight;

		[Token(Token = "0x400033E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float defaultPull;

		[Token(Token = "0x400033F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private float defaultReach;

		[Token(Token = "0x4000340")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private float defaultPush;

		[Token(Token = "0x4000341")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private float defaultPushParent;

		[Token(Token = "0x4000342")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private float defaultBendGoalWeight;

		[Token(Token = "0x4000343")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private float resetTimer;

		[Token(Token = "0x4000344")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private bool positionWeightUsed;

		[Token(Token = "0x4000345")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x61")]
		private bool rotationWeightUsed;

		[Token(Token = "0x4000346")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x62")]
		private bool pullUsed;

		[Token(Token = "0x4000347")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x63")]
		private bool reachUsed;

		[Token(Token = "0x4000348")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private bool pushUsed;

		[Token(Token = "0x4000349")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x65")]
		private bool pushParentUsed;

		[Token(Token = "0x400034A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x66")]
		private bool bendGoalWeightUsed;

		[Token(Token = "0x400034B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x67")]
		private bool pickedUp;

		[Token(Token = "0x400034C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private bool defaults;

		[Token(Token = "0x400034D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x69")]
		private bool pickUpOnPostFBBIK;

		[Token(Token = "0x400034E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private Vector3 pickUpPosition;

		[Token(Token = "0x400034F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Vector3 pausePositionRelative;

		[Token(Token = "0x4000350")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private Quaternion pickUpRotation;

		[Token(Token = "0x4000351")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private Quaternion pauseRotationRelative;

		[Token(Token = "0x4000352")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private InteractionTarget interactionTarget;

		[Token(Token = "0x4000353")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Transform target;

		[Token(Token = "0x4000354")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private List<bool> triggered;

		[Token(Token = "0x4000355")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private InteractionSystem interactionSystem;

		[Token(Token = "0x4000356")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private bool started;

		[Token(Token = "0x17000051")]
		public FullBodyBipedEffector effectorType
		{
			[Token(Token = "0x60003D8")]
			[Address(RVA = "0x2FE4F78", Offset = "0x2FE4F78", VA = "0x2FE4F78")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x14D8A34", Offset = "0x14D8A34")]
			get
			{
				return default(FullBodyBipedEffector);
			}
			[Token(Token = "0x60003D9")]
			[Address(RVA = "0x2FE4F80", Offset = "0x2FE4F80", VA = "0x2FE4F80")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x14D8A44", Offset = "0x14D8A44")]
			private set
			{
			}
		}

		[Token(Token = "0x17000052")]
		public bool isPaused
		{
			[Token(Token = "0x60003DA")]
			[Address(RVA = "0x2FE4F88", Offset = "0x2FE4F88", VA = "0x2FE4F88")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x14D8A54", Offset = "0x14D8A54")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60003DB")]
			[Address(RVA = "0x2FE4F90", Offset = "0x2FE4F90", VA = "0x2FE4F90")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x14D8A64", Offset = "0x14D8A64")]
			private set
			{
			}
		}

		[Token(Token = "0x17000053")]
		public InteractionObject interactionObject
		{
			[Token(Token = "0x60003DC")]
			[Address(RVA = "0x2FE4F9C", Offset = "0x2FE4F9C", VA = "0x2FE4F9C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x14D8A74", Offset = "0x14D8A74")]
			get
			{
				return null;
			}
			[Token(Token = "0x60003DD")]
			[Address(RVA = "0x2FE4FA4", Offset = "0x2FE4FA4", VA = "0x2FE4FA4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x14D8A84", Offset = "0x14D8A84")]
			private set
			{
			}
		}

		[Token(Token = "0x17000054")]
		public bool inInteraction
		{
			[Token(Token = "0x60003DE")]
			[Address(RVA = "0x2FE4FAC", Offset = "0x2FE4FAC", VA = "0x2FE4FAC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000055")]
		public float progress
		{
			[Token(Token = "0x60003E7")]
			[Address(RVA = "0x2FE796C", Offset = "0x2FE796C", VA = "0x2FE796C")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x60003DF")]
		[Address(RVA = "0x2FE501C", Offset = "0x2FE501C", VA = "0x2FE501C")]
		public InteractionEffector(FullBodyBipedEffector effectorType)
		{
		}

		[Token(Token = "0x60003E0")]
		[Address(RVA = "0x2FE50A0", Offset = "0x2FE50A0", VA = "0x2FE50A0")]
		public void Initiate(InteractionSystem interactionSystem)
		{
		}

		[Token(Token = "0x60003E1")]
		[Address(RVA = "0x2FE5144", Offset = "0x2FE5144", VA = "0x2FE5144")]
		private void StoreDefaults()
		{
		}

		[Token(Token = "0x60003E2")]
		[Address(RVA = "0x2FE52BC", Offset = "0x2FE52BC", VA = "0x2FE52BC")]
		public bool ResetToDefaults(float speed)
		{
			return default(bool);
		}

		[Token(Token = "0x60003E3")]
		[Address(RVA = "0x2FE576C", Offset = "0x2FE576C", VA = "0x2FE576C")]
		public bool Pause()
		{
			return default(bool);
		}

		[Token(Token = "0x60003E4")]
		[Address(RVA = "0x2FE5B2C", Offset = "0x2FE5B2C", VA = "0x2FE5B2C")]
		public bool Resume()
		{
			return default(bool);
		}

		[Token(Token = "0x60003E5")]
		[Address(RVA = "0x2FE5B80", Offset = "0x2FE5B80", VA = "0x2FE5B80")]
		public bool Start(InteractionObject interactionObject, string tag, float fadeInTime, bool interrupt)
		{
			return default(bool);
		}

		[Token(Token = "0x60003E6")]
		[Address(RVA = "0x2FE66D4", Offset = "0x2FE66D4", VA = "0x2FE66D4")]
		public void Update(Transform root, float speed)
		{
		}

		[Token(Token = "0x60003E8")]
		[Address(RVA = "0x2FE71B4", Offset = "0x2FE71B4", VA = "0x2FE71B4")]
		private void TriggerUntriggeredEvents(bool checkTime, out bool pickUp, out bool pause)
		{
		}

		[Token(Token = "0x60003E9")]
		[Address(RVA = "0x2FE73DC", Offset = "0x2FE73DC", VA = "0x2FE73DC")]
		private void PickUp(Transform root)
		{
		}

		[Token(Token = "0x60003EA")]
		[Address(RVA = "0x2FE7818", Offset = "0x2FE7818", VA = "0x2FE7818")]
		public bool Stop()
		{
			return default(bool);
		}

		[Token(Token = "0x60003EB")]
		[Address(RVA = "0x2FE7E54", Offset = "0x2FE7E54", VA = "0x2FE7E54")]
		public void OnPostFBBIK()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000066")]
	public class InteractionLookAt
	{
		[Token(Token = "0x4000357")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D2A4C", Offset = "0x14D2A4C")]
		public LookAtIK ik;

		[Token(Token = "0x4000358")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D2A84", Offset = "0x14D2A84")]
		public float lerpSpeed;

		[Token(Token = "0x4000359")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D2ABC", Offset = "0x14D2ABC")]
		public float weightSpeed;

		[Token(Token = "0x400035A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[HideInInspector]
		public bool isPaused;

		[Token(Token = "0x400035B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Transform lookAtTarget;

		[Token(Token = "0x400035C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float stopLookTime;

		[Token(Token = "0x400035D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private float weight;

		[Token(Token = "0x400035E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private bool firstFBBIKSolve;

		[Token(Token = "0x60003EC")]
		[Address(RVA = "0x2FE80B8", Offset = "0x2FE80B8", VA = "0x2FE80B8")]
		public void Look(Transform target, float time)
		{
		}

		[Token(Token = "0x60003ED")]
		[Address(RVA = "0x2FE8230", Offset = "0x2FE8230", VA = "0x2FE8230")]
		public void OnFixTransforms()
		{
		}

		[Token(Token = "0x60003EE")]
		[Address(RVA = "0x2FE82D8", Offset = "0x2FE82D8", VA = "0x2FE82D8")]
		public void Update()
		{
		}

		[Token(Token = "0x60003EF")]
		[Address(RVA = "0x2FE851C", Offset = "0x2FE851C", VA = "0x2FE851C")]
		public void SolveSpine()
		{
		}

		[Token(Token = "0x60003F0")]
		[Address(RVA = "0x2FE8614", Offset = "0x2FE8614", VA = "0x2FE8614")]
		public void SolveHead()
		{
		}

		[Token(Token = "0x60003F1")]
		[Address(RVA = "0x2FE86E0", Offset = "0x2FE86E0", VA = "0x2FE86E0")]
		public InteractionLookAt()
		{
		}
	}
	[Token(Token = "0x2000067")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x14CF914", Offset = "0x14CF914")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x14CF914", Offset = "0x14CF914")]
	public class InteractionObject : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20001AD")]
		public class InteractionEvent
		{
			[Token(Token = "0x4000AD1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D5B38", Offset = "0x14D5B38")]
			public float time;

			[Token(Token = "0x4000AD2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D5B70", Offset = "0x14D5B70")]
			public bool pause;

			[Token(Token = "0x4000AD3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x15")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D5BA8", Offset = "0x14D5BA8")]
			public bool pickUp;

			[Token(Token = "0x4000AD4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D5BE0", Offset = "0x14D5BE0")]
			public AnimatorEvent[] animations;

			[Token(Token = "0x4000AD5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D5C18", Offset = "0x14D5C18")]
			public Message[] messages;

			[Token(Token = "0x4000AD6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D5C50", Offset = "0x14D5C50")]
			public UnityEvent unityEvent;

			[Token(Token = "0x6000CB1")]
			[Address(RVA = "0x2FE79A8", Offset = "0x2FE79A8", VA = "0x2FE79A8")]
			public void Activate(Transform t)
			{
			}

			[Token(Token = "0x6000CB2")]
			[Address(RVA = "0x2FE99FC", Offset = "0x2FE99FC", VA = "0x2FE99FC")]
			public InteractionEvent()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20001AE")]
		public class Message
		{
			[Token(Token = "0x4000AD7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D5C88", Offset = "0x14D5C88")]
			public string function;

			[Token(Token = "0x4000AD8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D5CC0", Offset = "0x14D5CC0")]
			public GameObject recipient;

			[Token(Token = "0x4000AD9")]
			private const string empty = "";

			[Token(Token = "0x6000CB3")]
			[Address(RVA = "0x2FE990C", Offset = "0x2FE990C", VA = "0x2FE990C")]
			public void Send(Transform t)
			{
			}

			[Token(Token = "0x6000CB4")]
			[Address(RVA = "0x2FE9A04", Offset = "0x2FE9A04", VA = "0x2FE9A04")]
			public Message()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20001AF")]
		public class AnimatorEvent
		{
			[Token(Token = "0x4000ADA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D5CF8", Offset = "0x14D5CF8")]
			public Animator animator;

			[Token(Token = "0x4000ADB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D5D30", Offset = "0x14D5D30")]
			public Animation animation;

			[Token(Token = "0x4000ADC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D5D68", Offset = "0x14D5D68")]
			public string animationState;

			[Token(Token = "0x4000ADD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D5DA0", Offset = "0x14D5DA0")]
			public float crossfadeTime;

			[Token(Token = "0x4000ADE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D5DD8", Offset = "0x14D5DD8")]
			public int layer;

			[Token(Token = "0x4000ADF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D5E10", Offset = "0x14D5E10")]
			public bool resetNormalizedTime;

			[Token(Token = "0x4000AE0")]
			private const string empty = "";

			[Token(Token = "0x6000CB5")]
			[Address(RVA = "0x2FE966C", Offset = "0x2FE966C", VA = "0x2FE966C")]
			public void Activate(bool pickUp)
			{
			}

			[Token(Token = "0x6000CB6")]
			[Address(RVA = "0x2FE9760", Offset = "0x2FE9760", VA = "0x2FE9760")]
			private void Activate(Animator animator)
			{
			}

			[Token(Token = "0x6000CB7")]
			[Address(RVA = "0x2FE9818", Offset = "0x2FE9818", VA = "0x2FE9818")]
			private void Activate(Animation animation)
			{
			}

			[Token(Token = "0x6000CB8")]
			[Address(RVA = "0x2FE98F8", Offset = "0x2FE98F8", VA = "0x2FE98F8")]
			public AnimatorEvent()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20001B0")]
		public class WeightCurve
		{
			[Serializable]
			[Token(Token = "0x20001E0")]
			public enum Type
			{
				[Token(Token = "0x4000BC4")]
				PositionWeight,
				[Token(Token = "0x4000BC5")]
				RotationWeight,
				[Token(Token = "0x4000BC6")]
				PositionOffsetX,
				[Token(Token = "0x4000BC7")]
				PositionOffsetY,
				[Token(Token = "0x4000BC8")]
				PositionOffsetZ,
				[Token(Token = "0x4000BC9")]
				Pull,
				[Token(Token = "0x4000BCA")]
				Reach,
				[Token(Token = "0x4000BCB")]
				RotateBoneWeight,
				[Token(Token = "0x4000BCC")]
				Push,
				[Token(Token = "0x4000BCD")]
				PushParent,
				[Token(Token = "0x4000BCE")]
				PoserWeight,
				[Token(Token = "0x4000BCF")]
				BendGoalWeight
			}

			[Token(Token = "0x4000AE1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D5E48", Offset = "0x14D5E48")]
			public Type type;

			[Token(Token = "0x4000AE2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D5E80", Offset = "0x14D5E80")]
			public AnimationCurve curve;

			[Token(Token = "0x6000CB9")]
			[Address(RVA = "0x2FE8E84", Offset = "0x2FE8E84", VA = "0x2FE8E84")]
			public float GetValue(float timer)
			{
				return default(float);
			}

			[Token(Token = "0x6000CBA")]
			[Address(RVA = "0x2FE9A1C", Offset = "0x2FE9A1C", VA = "0x2FE9A1C")]
			public WeightCurve()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20001B1")]
		public class Multiplier
		{
			[Token(Token = "0x4000AE3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D5EB8", Offset = "0x14D5EB8")]
			public WeightCurve.Type curve;

			[Token(Token = "0x4000AE4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D5EF0", Offset = "0x14D5EF0")]
			public float multiplier;

			[Token(Token = "0x4000AE5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D5F28", Offset = "0x14D5F28")]
			public WeightCurve.Type result;

			[Token(Token = "0x6000CBB")]
			[Address(RVA = "0x2FE9564", Offset = "0x2FE9564", VA = "0x2FE9564")]
			public float GetValue(WeightCurve weightCurve, float timer)
			{
				return default(float);
			}

			[Token(Token = "0x6000CBC")]
			[Address(RVA = "0x2FE9A0C", Offset = "0x2FE9A0C", VA = "0x2FE9A0C")]
			public Multiplier()
			{
			}
		}

		[Token(Token = "0x400035F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D2B04", Offset = "0x14D2B04")]
		public Transform otherLookAtTarget;

		[Token(Token = "0x4000360")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D2B3C", Offset = "0x14D2B3C")]
		public Transform otherTargetsRoot;

		[Token(Token = "0x4000361")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D2B74", Offset = "0x14D2B74")]
		public Transform positionOffsetSpace;

		[Token(Token = "0x4000362")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public WeightCurve[] weightCurves;

		[Token(Token = "0x4000363")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Multiplier[] multipliers;

		[Token(Token = "0x4000364")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public InteractionEvent[] events;

		[Token(Token = "0x4000365")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x14D2BAC", Offset = "0x14D2BAC")]
		private float <length>k__BackingField;

		[Token(Token = "0x4000366")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x14D2BBC", Offset = "0x14D2BBC")]
		private InteractionSystem <lastUsedInteractionSystem>k__BackingField;

		[Token(Token = "0x4000367")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private InteractionTarget[] targets;

		[Token(Token = "0x17000056")]
		public float length
		{
			[Token(Token = "0x60003FA")]
			[Address(RVA = "0x2FE8954", Offset = "0x2FE8954", VA = "0x2FE8954")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x14D8C54", Offset = "0x14D8C54")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60003FB")]
			[Address(RVA = "0x2FE895C", Offset = "0x2FE895C", VA = "0x2FE895C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x14D8C64", Offset = "0x14D8C64")]
			private set
			{
			}
		}

		[Token(Token = "0x17000057")]
		public InteractionSystem lastUsedInteractionSystem
		{
			[Token(Token = "0x60003FC")]
			[Address(RVA = "0x2FE8964", Offset = "0x2FE8964", VA = "0x2FE8964")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x14D8C74", Offset = "0x14D8C74")]
			get
			{
				return null;
			}
			[Token(Token = "0x60003FD")]
			[Address(RVA = "0x2FE896C", Offset = "0x2FE896C", VA = "0x2FE896C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x14D8C84", Offset = "0x14D8C84")]
			private set
			{
			}
		}

		[Token(Token = "0x17000058")]
		public Transform lookAtTarget
		{
			[Token(Token = "0x60003FF")]
			[Address(RVA = "0x2FE8B88", Offset = "0x2FE8B88", VA = "0x2FE8B88")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000059")]
		public Transform targetsRoot
		{
			[Token(Token = "0x6000407")]
			[Address(RVA = "0x2FE7D28", Offset = "0x2FE7D28", VA = "0x2FE7D28")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60003F2")]
		[Address(RVA = "0x2FE86F4", Offset = "0x2FE86F4", VA = "0x2FE86F4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x14D8A94", Offset = "0x14D8A94")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x60003F3")]
		[Address(RVA = "0x2FE8740", Offset = "0x2FE8740", VA = "0x2FE8740")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x14D8ACC", Offset = "0x14D8ACC")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x60003F4")]
		[Address(RVA = "0x2FE878C", Offset = "0x2FE878C", VA = "0x2FE878C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x14D8B04", Offset = "0x14D8B04")]
		private void OpenTutorial1()
		{
		}

		[Token(Token = "0x60003F5")]
		[Address(RVA = "0x2FE87D8", Offset = "0x2FE87D8", VA = "0x2FE87D8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x14D8B3C", Offset = "0x14D8B3C")]
		private void OpenTutorial2()
		{
		}

		[Token(Token = "0x60003F6")]
		[Address(RVA = "0x2FE8824", Offset = "0x2FE8824", VA = "0x2FE8824")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x14D8B74", Offset = "0x14D8B74")]
		private void OpenTutorial3()
		{
		}

		[Token(Token = "0x60003F7")]
		[Address(RVA = "0x2FE8870", Offset = "0x2FE8870", VA = "0x2FE8870")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x14D8BAC", Offset = "0x14D8BAC")]
		private void OpenTutorial4()
		{
		}

		[Token(Token = "0x60003F8")]
		[Address(RVA = "0x2FE88BC", Offset = "0x2FE88BC", VA = "0x2FE88BC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x14D8BE4", Offset = "0x14D8BE4")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60003F9")]
		[Address(RVA = "0x2FE8908", Offset = "0x2FE8908", VA = "0x2FE8908")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x14D8C1C", Offset = "0x14D8C1C")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60003FE")]
		[Address(RVA = "0x2FE8974", Offset = "0x2FE8974", VA = "0x2FE8974")]
		public void Initiate()
		{
		}

		[Token(Token = "0x6000400")]
		[Address(RVA = "0x2FE8C18", Offset = "0x2FE8C18", VA = "0x2FE8C18")]
		public InteractionTarget GetTarget(FullBodyBipedEffector effectorType, InteractionSystem interactionSystem)
		{
			return null;
		}

		[Token(Token = "0x6000401")]
		[Address(RVA = "0x2FE60FC", Offset = "0x2FE60FC", VA = "0x2FE60FC")]
		public bool CurveUsed(WeightCurve.Type type)
		{
			return default(bool);
		}

		[Token(Token = "0x6000402")]
		[Address(RVA = "0x2FE8D9C", Offset = "0x2FE8D9C", VA = "0x2FE8D9C")]
		public InteractionTarget[] GetTargets()
		{
			return null;
		}

		[Token(Token = "0x6000403")]
		[Address(RVA = "0x2FE5FB0", Offset = "0x2FE5FB0", VA = "0x2FE5FB0")]
		public Transform GetTarget(FullBodyBipedEffector effectorType, string tag)
		{
			return null;
		}

		[Token(Token = "0x6000404")]
		[Address(RVA = "0x2FE60F4", Offset = "0x2FE60F4", VA = "0x2FE60F4")]
		public void OnStartInteraction(InteractionSystem interactionSystem)
		{
		}

		[Token(Token = "0x6000405")]
		[Address(RVA = "0x2FE6D98", Offset = "0x2FE6D98", VA = "0x2FE6D98")]
		public void Apply(IKSolverFullBodyBiped solver, FullBodyBipedEffector effector, InteractionTarget target, float timer, float weight)
		{
		}

		[Token(Token = "0x6000406")]
		[Address(RVA = "0x2FE75F0", Offset = "0x2FE75F0", VA = "0x2FE75F0")]
		public float GetValue(WeightCurve.Type weightCurveType, InteractionTarget target, float timer)
		{
			return default(float);
		}

		[Token(Token = "0x6000408")]
		[Address(RVA = "0x2FE95A0", Offset = "0x2FE95A0", VA = "0x2FE95A0")]
		private void Start()
		{
		}

		[Token(Token = "0x6000409")]
		[Address(RVA = "0x2FE8EA0", Offset = "0x2FE8EA0", VA = "0x2FE8EA0")]
		private void Apply(IKSolverFullBodyBiped solver, FullBodyBipedEffector effector, WeightCurve.Type type, float value, float weight)
		{
		}

		[Token(Token = "0x600040A")]
		[Address(RVA = "0x2FE8DA4", Offset = "0x2FE8DA4", VA = "0x2FE8DA4")]
		private Transform GetTarget(FullBodyBipedEffector effectorType)
		{
			return null;
		}

		[Token(Token = "0x600040B")]
		[Address(RVA = "0x2FE94FC", Offset = "0x2FE94FC", VA = "0x2FE94FC")]
		private int GetWeightCurveIndex(WeightCurve.Type weightCurveType)
		{
			return default(int);
		}

		[Token(Token = "0x600040C")]
		[Address(RVA = "0x2FE95A4", Offset = "0x2FE95A4", VA = "0x2FE95A4")]
		private int GetMultiplierIndex(WeightCurve.Type weightCurveType)
		{
			return default(int);
		}

		[Token(Token = "0x600040D")]
		[Address(RVA = "0x2FE960C", Offset = "0x2FE960C", VA = "0x2FE960C")]
		public InteractionObject()
		{
		}
	}
	[Token(Token = "0x2000068")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x14CF974", Offset = "0x14CF974")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x14CF974", Offset = "0x14CF974")]
	public class InteractionSystem : MonoBehaviour
	{
		[Token(Token = "0x20001B2")]
		public delegate void InteractionDelegate(FullBodyBipedEffector effectorType, InteractionObject interactionObject);

		[Token(Token = "0x20001B3")]
		public delegate void InteractionEventDelegate(FullBodyBipedEffector effectorType, InteractionObject interactionObject, InteractionObject.InteractionEvent interactionEvent);

		[Token(Token = "0x4000368")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D2BCC", Offset = "0x14D2BCC")]
		public string targetTag;

		[Token(Token = "0x4000369")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D2C04", Offset = "0x14D2C04")]
		public float fadeInTime;

		[Token(Token = "0x400036A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D2C3C", Offset = "0x14D2C3C")]
		public float speed;

		[Token(Token = "0x400036B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D2C74", Offset = "0x14D2C74")]
		public float resetToDefaultsSpeed;

		[Token(Token = "0x400036C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x14D2CAC", Offset = "0x14D2CAC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D2CAC", Offset = "0x14D2CAC")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x14D2CAC", Offset = "0x14D2CAC")]
		public Collider characterCollider;

		[Token(Token = "0x400036D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D2D30", Offset = "0x14D2D30")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x14D2D30", Offset = "0x14D2D30")]
		public Transform FPSCamera;

		[Token(Token = "0x400036E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D2D90", Offset = "0x14D2D90")]
		public LayerMask camRaycastLayers;

		[Token(Token = "0x400036F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D2DC8", Offset = "0x14D2DC8")]
		public float camRaycastDistance;

		[Token(Token = "0x4000370")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x14D2E00", Offset = "0x14D2E00")]
		private List<InteractionTrigger> <triggersInRange>k__BackingField;

		[Token(Token = "0x4000371")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private List<InteractionTrigger> inContact;

		[Token(Token = "0x4000372")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private List<int> bestRangeIndexes;

		[Token(Token = "0x4000373")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public InteractionDelegate OnInteractionStart;

		[Token(Token = "0x4000374")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public InteractionDelegate OnInteractionPause;

		[Token(Token = "0x4000375")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public InteractionDelegate OnInteractionPickUp;

		[Token(Token = "0x4000376")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public InteractionDelegate OnInteractionResume;

		[Token(Token = "0x4000377")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public InteractionDelegate OnInteractionStop;

		[Token(Token = "0x4000378")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public InteractionEventDelegate OnInteractionEvent;

		[Token(Token = "0x4000379")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public RaycastHit raycastHit;

		[Token(Token = "0x400037A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x14D2E10", Offset = "0x14D2E10")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D2E10", Offset = "0x14D2E10")]
		[SerializeField]
		private FullBodyBipedIK fullBody;

		[Token(Token = "0x400037B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D2E70", Offset = "0x14D2E70")]
		public InteractionLookAt lookAt;

		[Token(Token = "0x400037C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private InteractionEffector[] interactionEffectors;

		[Token(Token = "0x400037D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private bool initiated;

		[Token(Token = "0x400037E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private Collider lastCollider;

		[Token(Token = "0x400037F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private Collider c;

		[Token(Token = "0x1700005A")]
		public bool inInteraction
		{
			[Token(Token = "0x6000416")]
			[Address(RVA = "0x2FE9C84", Offset = "0x2FE9C84", VA = "0x2FE9C84")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700005B")]
		public FullBodyBipedIK ik
		{
			[Token(Token = "0x6000430")]
			[Address(RVA = "0x2FEB89C", Offset = "0x2FEB89C", VA = "0x2FEB89C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000431")]
			[Address(RVA = "0x2FEB8A4", Offset = "0x2FEB8A4", VA = "0x2FEB8A4")]
			set
			{
			}
		}

		[Token(Token = "0x1700005C")]
		public List<InteractionTrigger> triggersInRange
		{
			[Token(Token = "0x6000432")]
			[Address(RVA = "0x2FEB8AC", Offset = "0x2FEB8AC", VA = "0x2FEB8AC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x14D8E54", Offset = "0x14D8E54")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000433")]
			[Address(RVA = "0x2FEB8B4", Offset = "0x2FEB8B4", VA = "0x2FEB8B4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x14D8E64", Offset = "0x14D8E64")]
			private set
			{
			}
		}

		[Token(Token = "0x600040E")]
		[Address(RVA = "0x2FE9A24", Offset = "0x2FE9A24", VA = "0x2FE9A24")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x14D8C94", Offset = "0x14D8C94")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x600040F")]
		[Address(RVA = "0x2FE9A70", Offset = "0x2FE9A70", VA = "0x2FE9A70")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x14D8CCC", Offset = "0x14D8CCC")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000410")]
		[Address(RVA = "0x2FE9ABC", Offset = "0x2FE9ABC", VA = "0x2FE9ABC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x14D8D04", Offset = "0x14D8D04")]
		private void OpenTutorial1()
		{
		}

		[Token(Token = "0x6000411")]
		[Address(RVA = "0x2FE9B08", Offset = "0x2FE9B08", VA = "0x2FE9B08")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x14D8D3C", Offset = "0x14D8D3C")]
		private void OpenTutorial2()
		{
		}

		[Token(Token = "0x6000412")]
		[Address(RVA = "0x2FE9B54", Offset = "0x2FE9B54", VA = "0x2FE9B54")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x14D8D74", Offset = "0x14D8D74")]
		private void OpenTutorial3()
		{
		}

		[Token(Token = "0x6000413")]
		[Address(RVA = "0x2FE9BA0", Offset = "0x2FE9BA0", VA = "0x2FE9BA0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x14D8DAC", Offset = "0x14D8DAC")]
		private void OpenTutorial4()
		{
		}

		[Token(Token = "0x6000414")]
		[Address(RVA = "0x2FE9BEC", Offset = "0x2FE9BEC", VA = "0x2FE9BEC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x14D8DE4", Offset = "0x14D8DE4")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000415")]
		[Address(RVA = "0x2FE9C38", Offset = "0x2FE9C38", VA = "0x2FE9C38")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x14D8E1C", Offset = "0x14D8E1C")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000417")]
		[Address(RVA = "0x2FE9E14", Offset = "0x2FE9E14", VA = "0x2FE9E14")]
		public bool IsInInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x6000418")]
		[Address(RVA = "0x2FE9EE0", Offset = "0x2FE9EE0", VA = "0x2FE9EE0")]
		public bool IsPaused(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x6000419")]
		[Address(RVA = "0x2FE9FAC", Offset = "0x2FE9FAC", VA = "0x2FE9FAC")]
		public bool IsPaused()
		{
			return default(bool);
		}

		[Token(Token = "0x600041A")]
		[Address(RVA = "0x2FEA058", Offset = "0x2FEA058", VA = "0x2FEA058")]
		public bool IsInSync()
		{
			return default(bool);
		}

		[Token(Token = "0x600041B")]
		[Address(RVA = "0x2FEA150", Offset = "0x2FEA150", VA = "0x2FEA150")]
		public bool StartInteraction(FullBodyBipedEffector effectorType, InteractionObject interactionObject, bool interrupt)
		{
			return default(bool);
		}

		[Token(Token = "0x600041C")]
		[Address(RVA = "0x2FEA26C", Offset = "0x2FEA26C", VA = "0x2FEA26C")]
		public bool PauseInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x600041D")]
		[Address(RVA = "0x2FEA2FC", Offset = "0x2FEA2FC", VA = "0x2FEA2FC")]
		public bool ResumeInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x600041E")]
		[Address(RVA = "0x2FEA38C", Offset = "0x2FEA38C", VA = "0x2FEA38C")]
		public bool StopInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x600041F")]
		[Address(RVA = "0x2FEA41C", Offset = "0x2FEA41C", VA = "0x2FEA41C")]
		public void PauseAll()
		{
		}

		[Token(Token = "0x6000420")]
		[Address(RVA = "0x2FEA490", Offset = "0x2FEA490", VA = "0x2FEA490")]
		public void ResumeAll()
		{
		}

		[Token(Token = "0x6000421")]
		[Address(RVA = "0x2FEA504", Offset = "0x2FEA504", VA = "0x2FEA504")]
		public void StopAll()
		{
		}

		[Token(Token = "0x6000422")]
		[Address(RVA = "0x2FEA56C", Offset = "0x2FEA56C", VA = "0x2FEA56C")]
		public InteractionObject GetInteractionObject(FullBodyBipedEffector effectorType)
		{
			return null;
		}

		[Token(Token = "0x6000423")]
		[Address(RVA = "0x2FEA5F8", Offset = "0x2FEA5F8", VA = "0x2FEA5F8")]
		public float GetProgress(FullBodyBipedEffector effectorType)
		{
			return default(float);
		}

		[Token(Token = "0x6000424")]
		[Address(RVA = "0x2FEA6AC", Offset = "0x2FEA6AC", VA = "0x2FEA6AC")]
		public float GetMinActiveProgress()
		{
			return default(float);
		}

		[Token(Token = "0x6000425")]
		[Address(RVA = "0x2FEA790", Offset = "0x2FEA790", VA = "0x2FEA790")]
		public bool TriggerInteraction(int index, bool interrupt)
		{
			return default(bool);
		}

		[Token(Token = "0x6000426")]
		[Address(RVA = "0x2FEAA34", Offset = "0x2FEAA34", VA = "0x2FEAA34")]
		public bool TriggerInteraction(int index, bool interrupt, out InteractionObject interactionObject)
		{
			return default(bool);
		}

		[Token(Token = "0x6000427")]
		[Address(RVA = "0x2FEAC0C", Offset = "0x2FEAC0C", VA = "0x2FEAC0C")]
		public bool TriggerInteraction(int index, bool interrupt, out InteractionTarget interactionTarget)
		{
			return default(bool);
		}

		[Token(Token = "0x6000428")]
		[Address(RVA = "0x2FEAE80", Offset = "0x2FEAE80", VA = "0x2FEAE80")]
		public InteractionTrigger.Range GetClosestInteractionRange()
		{
			return null;
		}

		[Token(Token = "0x6000429")]
		[Address(RVA = "0x2FEB174", Offset = "0x2FEB174", VA = "0x2FEB174")]
		public InteractionObject GetClosestInteractionObjectInRange()
		{
			return null;
		}

		[Token(Token = "0x600042A")]
		[Address(RVA = "0x2FEB1B8", Offset = "0x2FEB1B8", VA = "0x2FEB1B8")]
		public InteractionTarget GetClosestInteractionTargetInRange()
		{
			return null;
		}

		[Token(Token = "0x600042B")]
		[Address(RVA = "0x2FEB230", Offset = "0x2FEB230", VA = "0x2FEB230")]
		public InteractionObject[] GetClosestInteractionObjectsInRange()
		{
			return null;
		}

		[Token(Token = "0x600042C")]
		[Address(RVA = "0x2FEB350", Offset = "0x2FEB350", VA = "0x2FEB350")]
		public InteractionTarget[] GetClosestInteractionTargetsInRange()
		{
			return null;
		}

		[Token(Token = "0x600042D")]
		[Address(RVA = "0x2FEB4C8", Offset = "0x2FEB4C8", VA = "0x2FEB4C8")]
		public bool TriggerEffectorsReady(int index)
		{
			return default(bool);
		}

		[Token(Token = "0x600042E")]
		[Address(RVA = "0x2FEB770", Offset = "0x2FEB770", VA = "0x2FEB770")]
		public InteractionTrigger.Range GetTriggerRange(int index)
		{
			return null;
		}

		[Token(Token = "0x600042F")]
		[Address(RVA = "0x2FEAF80", Offset = "0x2FEAF80", VA = "0x2FEAF80")]
		public int GetClosestTriggerIndex()
		{
			return default(int);
		}

		[Token(Token = "0x6000434")]
		[Address(RVA = "0x2FEB8BC", Offset = "0x2FEB8BC", VA = "0x2FEB8BC")]
		public void Start()
		{
		}

		[Token(Token = "0x6000435")]
		[Address(RVA = "0x2FEBF70", Offset = "0x2FEBF70", VA = "0x2FEBF70")]
		private void InteractionPause(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x6000436")]
		[Address(RVA = "0x2FEBF90", Offset = "0x2FEBF90", VA = "0x2FEBF90")]
		private void InteractionResume(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x6000437")]
		[Address(RVA = "0x2FEBFAC", Offset = "0x2FEBFAC", VA = "0x2FEBFAC")]
		private void InteractionStop(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x6000438")]
		[Address(RVA = "0x2FEBFC8", Offset = "0x2FEBFC8", VA = "0x2FEBFC8")]
		private void LookAtInteraction(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x6000439")]
		[Address(RVA = "0x2FEC028", Offset = "0x2FEC028", VA = "0x2FEC028")]
		public void OnTriggerEnter(Collider c)
		{
		}

		[Token(Token = "0x600043A")]
		[Address(RVA = "0x2FEC144", Offset = "0x2FEC144", VA = "0x2FEC144")]
		public void OnTriggerExit(Collider c)
		{
		}

		[Token(Token = "0x600043B")]
		[Address(RVA = "0x2FEC240", Offset = "0x2FEC240", VA = "0x2FEC240")]
		private bool ContactIsInRange(int index, out int bestRangeIndex)
		{
			return default(bool);
		}

		[Token(Token = "0x600043C")]
		[Address(RVA = "0x2FEC3E8", Offset = "0x2FEC3E8", VA = "0x2FEC3E8")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x600043D")]
		[Address(RVA = "0x2FEC4D4", Offset = "0x2FEC4D4", VA = "0x2FEC4D4")]
		public void Update()
		{
		}

		[Token(Token = "0x600043E")]
		[Address(RVA = "0x2FEC720", Offset = "0x2FEC720", VA = "0x2FEC720")]
		private void Raycasting()
		{
		}

		[Token(Token = "0x600043F")]
		[Address(RVA = "0x2FEBCE8", Offset = "0x2FEBCE8", VA = "0x2FEBCE8")]
		private void UpdateTriggerEventBroadcasting()
		{
		}

		[Token(Token = "0x6000440")]
		[Address(RVA = "0x2FEC860", Offset = "0x2FEC860", VA = "0x2FEC860")]
		private void UpdateEffectors()
		{
		}

		[Token(Token = "0x6000441")]
		[Address(RVA = "0x2FEC98C", Offset = "0x2FEC98C", VA = "0x2FEC98C")]
		private void OnPreFBBIK()
		{
		}

		[Token(Token = "0x6000442")]
		[Address(RVA = "0x2FECA24", Offset = "0x2FECA24", VA = "0x2FECA24")]
		private void OnPostFBBIK()
		{
		}

		[Token(Token = "0x6000443")]
		[Address(RVA = "0x2FECAFC", Offset = "0x2FECAFC", VA = "0x2FECAFC")]
		private void OnFixTransforms()
		{
		}

		[Token(Token = "0x6000444")]
		[Address(RVA = "0x2FECB14", Offset = "0x2FECB14", VA = "0x2FECB14")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000445")]
		[Address(RVA = "0x2FE9D30", Offset = "0x2FE9D30", VA = "0x2FE9D30")]
		private bool IsValid(bool log)
		{
			return default(bool);
		}

		[Token(Token = "0x6000446")]
		[Address(RVA = "0x2FEA930", Offset = "0x2FEA930", VA = "0x2FEA930")]
		private bool TriggerIndexIsValid(int index)
		{
			return default(bool);
		}

		[Token(Token = "0x6000447")]
		[Address(RVA = "0x2FECE04", Offset = "0x2FECE04", VA = "0x2FECE04")]
		public InteractionSystem()
		{
		}
	}
	[Token(Token = "0x2000069")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x14CF9D4", Offset = "0x14CF9D4")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x14CF9D4", Offset = "0x14CF9D4")]
	public class InteractionTarget : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20001B4")]
		public class Multiplier
		{
			[Token(Token = "0x4000AE6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D5F60", Offset = "0x14D5F60")]
			public InteractionObject.WeightCurve.Type curve;

			[Token(Token = "0x4000AE7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D5F98", Offset = "0x14D5F98")]
			public float multiplier;

			[Token(Token = "0x6000CC5")]
			[Address(RVA = "0x2986844", Offset = "0x2986844", VA = "0x2986844")]
			public Multiplier()
			{
			}
		}

		[Token(Token = "0x4000380")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D2EA8", Offset = "0x14D2EA8")]
		public FullBodyBipedEffector effectorType;

		[Token(Token = "0x4000381")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D2EE0", Offset = "0x14D2EE0")]
		public Multiplier[] multipliers;

		[Token(Token = "0x4000382")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D2F18", Offset = "0x14D2F18")]
		public float interactionSpeedMlp;

		[Token(Token = "0x4000383")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D2F50", Offset = "0x14D2F50")]
		public Transform pivot;

		[Token(Token = "0x4000384")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D2F88", Offset = "0x14D2F88")]
		public Vector3 twistAxis;

		[Token(Token = "0x4000385")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D2FC0", Offset = "0x14D2FC0")]
		public float twistWeight;

		[Token(Token = "0x4000386")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D2FF8", Offset = "0x14D2FF8")]
		public float swingWeight;

		[Token(Token = "0x4000387")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D3030", Offset = "0x14D3030")]
		public bool rotateOnce;

		[Token(Token = "0x4000388")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Quaternion defaultLocalRotation;

		[Token(Token = "0x4000389")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Transform lastPivot;

		[Token(Token = "0x6000448")]
		[Address(RVA = "0x2FED2B8", Offset = "0x2FED2B8", VA = "0x2FED2B8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x14D8E74", Offset = "0x14D8E74")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x6000449")]
		[Address(RVA = "0x2FED304", Offset = "0x2FED304", VA = "0x2FED304")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x14D8EAC", Offset = "0x14D8EAC")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x600044A")]
		[Address(RVA = "0x2FED350", Offset = "0x2FED350", VA = "0x2FED350")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x14D8EE4", Offset = "0x14D8EE4")]
		private void OpenTutorial1()
		{
		}

		[Token(Token = "0x600044B")]
		[Address(RVA = "0x2FED39C", Offset = "0x2FED39C", VA = "0x2FED39C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x14D8F1C", Offset = "0x14D8F1C")]
		private void OpenTutorial2()
		{
		}

		[Token(Token = "0x600044C")]
		[Address(RVA = "0x2FED3E8", Offset = "0x2FED3E8", VA = "0x2FED3E8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x14D8F54", Offset = "0x14D8F54")]
		private void OpenTutorial3()
		{
		}

		[Token(Token = "0x600044D")]
		[Address(RVA = "0x2FED434", Offset = "0x2FED434", VA = "0x2FED434")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x14D8F8C", Offset = "0x14D8F8C")]
		private void OpenTutorial4()
		{
		}

		[Token(Token = "0x600044E")]
		[Address(RVA = "0x2FED480", Offset = "0x2FED480", VA = "0x2FED480")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x14D8FC4", Offset = "0x14D8FC4")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600044F")]
		[Address(RVA = "0x2FED4CC", Offset = "0x2FED4CC", VA = "0x2FED4CC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x14D8FFC", Offset = "0x14D8FFC")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000450")]
		[Address(RVA = "0x2FE8E14", Offset = "0x2FE8E14", VA = "0x2FE8E14")]
		public float GetValue(InteractionObject.WeightCurve.Type curveType)
		{
			return default(float);
		}

		[Token(Token = "0x6000451")]
		[Address(RVA = "0x2FE7DB8", Offset = "0x2FE7DB8", VA = "0x2FE7DB8")]
		public void ResetRotation()
		{
		}

		[Token(Token = "0x6000452")]
		[Address(RVA = "0x2FE61B0", Offset = "0x2FE61B0", VA = "0x2FE61B0")]
		public void RotateTo(Vector3 position)
		{
		}

		[Token(Token = "0x6000453")]
		[Address(RVA = "0x2FED518", Offset = "0x2FED518", VA = "0x2FED518")]
		public InteractionTarget()
		{
		}
	}
	[Token(Token = "0x200006A")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x14CFA34", Offset = "0x14CFA34")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x14CFA34", Offset = "0x14CFA34")]
	public class InteractionTrigger : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20001B5")]
		public class CharacterPosition
		{
			[Token(Token = "0x4000AE8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D5FD0", Offset = "0x14D5FD0")]
			public bool use;

			[Token(Token = "0x4000AE9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D6008", Offset = "0x14D6008")]
			public Vector2 offset;

			[Token(Token = "0x4000AEA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D6040", Offset = "0x14D6040")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x14D6040", Offset = "0x14D6040")]
			public float angleOffset;

			[Token(Token = "0x4000AEB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D609C", Offset = "0x14D609C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x14D609C", Offset = "0x14D609C")]
			public float maxAngle;

			[Token(Token = "0x4000AEC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D60F4", Offset = "0x14D60F4")]
			public float radius;

			[Token(Token = "0x4000AED")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D612C", Offset = "0x14D612C")]
			public bool orbit;

			[Token(Token = "0x4000AEE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D6164", Offset = "0x14D6164")]
			public bool fixYAxis;

			[Token(Token = "0x170000B1")]
			public Vector3 offset3D
			{
				[Token(Token = "0x6000CC6")]
				[Address(RVA = "0x29872D4", Offset = "0x29872D4", VA = "0x29872D4")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x170000B2")]
			public Vector3 direction3D
			{
				[Token(Token = "0x6000CC7")]
				[Address(RVA = "0x2987310", Offset = "0x2987310", VA = "0x2987310")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x6000CC8")]
			[Address(RVA = "0x2987408", Offset = "0x2987408", VA = "0x2987408")]
			public bool IsInRange(Transform character, Transform trigger, out float error)
			{
				return default(bool);
			}

			[Token(Token = "0x6000CC9")]
			[Address(RVA = "0x2987A84", Offset = "0x2987A84", VA = "0x2987A84")]
			public CharacterPosition()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20001B6")]
		public class CameraPosition
		{
			[Token(Token = "0x4000AEF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D619C", Offset = "0x14D619C")]
			public Collider lookAtTarget;

			[Token(Token = "0x4000AF0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D61D4", Offset = "0x14D61D4")]
			public Vector3 direction;

			[Token(Token = "0x4000AF1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D620C", Offset = "0x14D620C")]
			public float maxDistance;

			[Token(Token = "0x4000AF2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D6244", Offset = "0x14D6244")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x14D6244", Offset = "0x14D6244")]
			public float maxAngle;

			[Token(Token = "0x4000AF3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D629C", Offset = "0x14D629C")]
			public bool fixYAxis;

			[Token(Token = "0x6000CCA")]
			[Address(RVA = "0x2986DC0", Offset = "0x2986DC0", VA = "0x2986DC0")]
			public Quaternion GetRotation()
			{
				return default(Quaternion);
			}

			[Token(Token = "0x6000CCB")]
			[Address(RVA = "0x2986F68", Offset = "0x2986F68", VA = "0x2986F68")]
			public bool IsInRange(Transform raycastFrom, RaycastHit hit, Transform trigger, out float error)
			{
				return default(bool);
			}

			[Token(Token = "0x6000CCC")]
			[Address(RVA = "0x2987248", Offset = "0x2987248", VA = "0x2987248")]
			public CameraPosition()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20001B7")]
		public class Range
		{
			[Serializable]
			[Token(Token = "0x20001E1")]
			public class Interaction
			{
				[Token(Token = "0x4000BD0")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D7354", Offset = "0x14D7354")]
				public InteractionObject interactionObject;

				[Token(Token = "0x4000BD1")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D738C", Offset = "0x14D738C")]
				public FullBodyBipedEffector[] effectors;

				[Token(Token = "0x6000D5C")]
				[Address(RVA = "0x2987AA8", Offset = "0x2987AA8", VA = "0x2987AA8")]
				public Interaction()
				{
				}
			}

			[Token(Token = "0x4000AF4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[HideInInspector]
			[SerializeField]
			public string name;

			[Token(Token = "0x4000AF5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[HideInInspector]
			[SerializeField]
			public bool show;

			[Token(Token = "0x4000AF6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D6344", Offset = "0x14D6344")]
			public CharacterPosition characterPosition;

			[Token(Token = "0x4000AF7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D637C", Offset = "0x14D637C")]
			public CameraPosition cameraPosition;

			[Token(Token = "0x4000AF8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D63B4", Offset = "0x14D63B4")]
			public Interaction[] interactions;

			[Token(Token = "0x6000CCD")]
			[Address(RVA = "0x2986C3C", Offset = "0x2986C3C", VA = "0x2986C3C")]
			public bool IsInRange(Transform character, Transform raycastFrom, RaycastHit raycastHit, Transform trigger, out float maxError)
			{
				return default(bool);
			}

			[Token(Token = "0x6000CCE")]
			[Address(RVA = "0x2987A98", Offset = "0x2987A98", VA = "0x2987A98")]
			public Range()
			{
			}
		}

		[Token(Token = "0x400038A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D3068", Offset = "0x14D3068")]
		public Range[] ranges;

		[Token(Token = "0x6000454")]
		[Address(RVA = "0x298684C", Offset = "0x298684C", VA = "0x298684C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x14D9034", Offset = "0x14D9034")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x6000455")]
		[Address(RVA = "0x2986898", Offset = "0x2986898", VA = "0x2986898")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x14D906C", Offset = "0x14D906C")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000456")]
		[Address(RVA = "0x29868E4", Offset = "0x29868E4", VA = "0x29868E4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x14D90A4", Offset = "0x14D90A4")]
		private void OpenTutorial4()
		{
		}

		[Token(Token = "0x6000457")]
		[Address(RVA = "0x2986930", Offset = "0x2986930", VA = "0x2986930")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x14D90DC", Offset = "0x14D90DC")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000458")]
		[Address(RVA = "0x298697C", Offset = "0x298697C", VA = "0x298697C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x14D9114", Offset = "0x14D9114")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000459")]
		[Address(RVA = "0x29869C8", Offset = "0x29869C8", VA = "0x29869C8")]
		private void Start()
		{
		}

		[Token(Token = "0x600045A")]
		[Address(RVA = "0x29869CC", Offset = "0x29869CC", VA = "0x29869CC")]
		public int GetBestRangeIndex(Transform character, Transform raycastFrom, RaycastHit raycastHit)
		{
			return default(int);
		}

		[Token(Token = "0x600045B")]
		[Address(RVA = "0x2986D60", Offset = "0x2986D60", VA = "0x2986D60")]
		public InteractionTrigger()
		{
		}
	}
	[Token(Token = "0x200006B")]
	public class GenericPoser : Poser
	{
		[Serializable]
		[Token(Token = "0x20001B8")]
		public class Map
		{
			[Token(Token = "0x4000AF9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform bone;

			[Token(Token = "0x4000AFA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Transform target;

			[Token(Token = "0x4000AFB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private Vector3 defaultLocalPosition;

			[Token(Token = "0x4000AFC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			private Quaternion defaultLocalRotation;

			[Token(Token = "0x6000CCF")]
			[Address(RVA = "0x2D41188", Offset = "0x2D41188", VA = "0x2D41188")]
			public Map(Transform bone, Transform target)
			{
			}

			[Token(Token = "0x6000CD0")]
			[Address(RVA = "0x2D4158C", Offset = "0x2D4158C", VA = "0x2D4158C")]
			public void StoreDefaultState()
			{
			}

			[Token(Token = "0x6000CD1")]
			[Address(RVA = "0x2D41540", Offset = "0x2D41540", VA = "0x2D41540")]
			public void FixTransform()
			{
			}

			[Token(Token = "0x6000CD2")]
			[Address(RVA = "0x2D41338", Offset = "0x2D41338", VA = "0x2D41338")]
			public void Update(float localRotationWeight, float localPositionWeight)
			{
			}
		}

		[Token(Token = "0x400038B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Map[] maps;

		[Token(Token = "0x600045C")]
		[Address(RVA = "0x2D40EA0", Offset = "0x2D40EA0", VA = "0x2D40EA0", Slot = "7")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x14D914C", Offset = "0x14D914C")]
		public override void AutoMapping()
		{
		}

		[Token(Token = "0x600045D")]
		[Address(RVA = "0x2D4122C", Offset = "0x2D4122C", VA = "0x2D4122C", Slot = "8")]
		protected override void InitiatePoser()
		{
		}

		[Token(Token = "0x600045E")]
		[Address(RVA = "0x2D41230", Offset = "0x2D41230", VA = "0x2D41230", Slot = "9")]
		protected override void UpdatePoser()
		{
		}

		[Token(Token = "0x600045F")]
		[Address(RVA = "0x2D414D8", Offset = "0x2D414D8", VA = "0x2D414D8", Slot = "10")]
		protected override void FixPoserTransforms()
		{
		}

		[Token(Token = "0x6000460")]
		[Address(RVA = "0x2D411C4", Offset = "0x2D411C4", VA = "0x2D411C4")]
		private void StoreDefaultState()
		{
		}

		[Token(Token = "0x6000461")]
		[Address(RVA = "0x2D410E8", Offset = "0x2D410E8", VA = "0x2D410E8")]
		private Transform GetTargetNamed(string tName, Transform[] array)
		{
			return null;
		}

		[Token(Token = "0x6000462")]
		[Address(RVA = "0x2D415DC", Offset = "0x2D415DC", VA = "0x2D415DC")]
		public GenericPoser()
		{
		}
	}
	[Token(Token = "0x200006C")]
	public class HandPoser : Poser
	{
		[Token(Token = "0x400038C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		protected Transform[] children;

		[Token(Token = "0x400038D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Transform _poseRoot;

		[Token(Token = "0x400038E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Transform[] poseChildren;

		[Token(Token = "0x400038F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Vector3[] defaultLocalPositions;

		[Token(Token = "0x4000390")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Quaternion[] defaultLocalRotations;

		[Token(Token = "0x6000463")]
		[Address(RVA = "0x2D4B630", Offset = "0x2D4B630", VA = "0x2D4B630", Slot = "7")]
		public override void AutoMapping()
		{
		}

		[Token(Token = "0x6000464")]
		[Address(RVA = "0x2D4B6E4", Offset = "0x2D4B6E4", VA = "0x2D4B6E4", Slot = "8")]
		protected override void InitiatePoser()
		{
		}

		[Token(Token = "0x6000465")]
		[Address(RVA = "0x2D4B89C", Offset = "0x2D4B89C", VA = "0x2D4B89C", Slot = "10")]
		protected override void FixPoserTransforms()
		{
		}

		[Token(Token = "0x6000466")]
		[Address(RVA = "0x2D4B998", Offset = "0x2D4B998", VA = "0x2D4B998", Slot = "9")]
		protected override void UpdatePoser()
		{
		}

		[Token(Token = "0x6000467")]
		[Address(RVA = "0x2D4B740", Offset = "0x2D4B740", VA = "0x2D4B740")]
		protected void StoreDefaultState()
		{
		}

		[Token(Token = "0x6000468")]
		[Address(RVA = "0x2D4BD48", Offset = "0x2D4BD48", VA = "0x2D4BD48")]
		public HandPoser()
		{
		}
	}
	[Token(Token = "0x200006D")]
	public abstract class Poser : SolverManager
	{
		[Token(Token = "0x4000391")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Transform poseRoot;

		[Token(Token = "0x4000392")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x14D30A0", Offset = "0x14D30A0")]
		public float weight;

		[Token(Token = "0x4000393")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x14D30B8", Offset = "0x14D30B8")]
		public float localRotationWeight;

		[Token(Token = "0x4000394")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x14D30D0", Offset = "0x14D30D0")]
		public float localPositionWeight;

		[Token(Token = "0x4000395")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private bool initiated;

		[Token(Token = "0x6000469")]
		public abstract void AutoMapping();

		[Token(Token = "0x600046A")]
		[Address(RVA = "0x298A750", Offset = "0x298A750", VA = "0x298A750")]
		public void UpdateManual()
		{
		}

		[Token(Token = "0x600046B")]
		protected abstract void InitiatePoser();

		[Token(Token = "0x600046C")]
		protected abstract void UpdatePoser();

		[Token(Token = "0x600046D")]
		protected abstract void FixPoserTransforms();

		[Token(Token = "0x600046E")]
		[Address(RVA = "0x298A75C", Offset = "0x298A75C", VA = "0x298A75C", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x600046F")]
		[Address(RVA = "0x298A7B0", Offset = "0x298A7B0", VA = "0x298A7B0", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x6000470")]
		[Address(RVA = "0x298A7EC", Offset = "0x298A7EC", VA = "0x298A7EC", Slot = "6")]
		protected override void FixTransforms()
		{
		}

		[Token(Token = "0x6000471")]
		[Address(RVA = "0x298A804", Offset = "0x298A804", VA = "0x298A804")]
		protected Poser()
		{
		}
	}
	[Token(Token = "0x200006E")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x14CFA94", Offset = "0x14CFA94")]
	public class RagdollUtility : MonoBehaviour
	{
		[Token(Token = "0x20001B9")]
		public class Rigidbone
		{
			[Token(Token = "0x4000AFD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody r;

			[Token(Token = "0x4000AFE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Transform t;

			[Token(Token = "0x4000AFF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Collider collider;

			[Token(Token = "0x4000B00")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Joint joint;

			[Token(Token = "0x4000B01")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Rigidbody c;

			[Token(Token = "0x4000B02")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public bool updateAnchor;

			[Token(Token = "0x4000B03")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public Vector3 deltaPosition;

			[Token(Token = "0x4000B04")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public Quaternion deltaRotation;

			[Token(Token = "0x4000B05")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public float deltaTime;

			[Token(Token = "0x4000B06")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			public Vector3 lastPosition;

			[Token(Token = "0x4000B07")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			public Quaternion lastRotation;

			[Token(Token = "0x6000CD3")]
			[Address(RVA = "0x298ADA0", Offset = "0x298ADA0", VA = "0x298ADA0")]
			public Rigidbone(Rigidbody r)
			{
			}

			[Token(Token = "0x6000CD4")]
			[Address(RVA = "0x298B9AC", Offset = "0x298B9AC", VA = "0x298B9AC")]
			public void RecordVelocity()
			{
			}

			[Token(Token = "0x6000CD5")]
			[Address(RVA = "0x298B790", Offset = "0x298B790", VA = "0x298B790")]
			public void WakeUp(float velocityWeight, float angularVelocityWeight)
			{
			}
		}

		[Token(Token = "0x20001BA")]
		public class Child
		{
			[Token(Token = "0x4000B08")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform t;

			[Token(Token = "0x4000B09")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Vector3 localPosition;

			[Token(Token = "0x4000B0A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			public Quaternion localRotation;

			[Token(Token = "0x6000CD6")]
			[Address(RVA = "0x298AEFC", Offset = "0x298AEFC", VA = "0x298AEFC")]
			public Child(Transform transform)
			{
			}

			[Token(Token = "0x6000CD7")]
			[Address(RVA = "0x298BB44", Offset = "0x298BB44", VA = "0x298BB44")]
			public void FixTransform(float weight)
			{
			}

			[Token(Token = "0x6000CD8")]
			[Address(RVA = "0x298BAF4", Offset = "0x298BAF4", VA = "0x298BAF4")]
			public void StoreLocalState()
			{
			}
		}

		[Token(Token = "0x20001BB")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x14CFEE8", Offset = "0x14CFEE8")]
		private sealed class <DisableRagdollSmooth>d__21 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000B0B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000B0C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000B0D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public RagdollUtility <>4__this;

			[Token(Token = "0x170000B3")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000CDC")]
				[Address(RVA = "0x298C124", Offset = "0x298C124", VA = "0x298C124", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000B4")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000CDE")]
				[Address(RVA = "0x298C18C", Offset = "0x298C18C", VA = "0x298C18C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000CD9")]
			[Address(RVA = "0x298AF5C", Offset = "0x298AF5C", VA = "0x298AF5C")]
			[DebuggerHidden]
			public <DisableRagdollSmooth>d__21(int <>1__state)
			{
			}

			[Token(Token = "0x6000CDA")]
			[Address(RVA = "0x298BEDC", Offset = "0x298BEDC", VA = "0x298BEDC", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000CDB")]
			[Address(RVA = "0x298BEE0", Offset = "0x298BEE0", VA = "0x298BEE0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000CDD")]
			[Address(RVA = "0x298C12C", Offset = "0x298C12C", VA = "0x298C12C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000396")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D30E8", Offset = "0x14D30E8")]
		public IK ik;

		[Token(Token = "0x4000397")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D3120", Offset = "0x14D3120")]
		public float ragdollToAnimationTime;

		[Token(Token = "0x4000398")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D3158", Offset = "0x14D3158")]
		public bool applyIkOnRagdoll;

		[Token(Token = "0x4000399")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D3190", Offset = "0x14D3190")]
		public float applyVelocity;

		[Token(Token = "0x400039A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D31C8", Offset = "0x14D31C8")]
		public float applyAngularVelocity;

		[Token(Token = "0x400039B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Animator animator;

		[Token(Token = "0x400039C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Rigidbone[] rigidbones;

		[Token(Token = "0x400039D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Child[] children;

		[Token(Token = "0x400039E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private bool enableRagdollFlag;

		[Token(Token = "0x400039F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private AnimatorUpdateMode animatorUpdateMode;

		[Token(Token = "0x40003A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private IK[] allIKComponents;

		[Token(Token = "0x40003A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private bool[] fixTransforms;

		[Token(Token = "0x40003A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private float ragdollWeight;

		[Token(Token = "0x40003A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private float ragdollWeightV;

		[Token(Token = "0x40003A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private bool fixedFrame;

		[Token(Token = "0x40003A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private bool[] disabledIKComponents;

		[Token(Token = "0x1700005D")]
		private bool isRagdoll
		{
			[Token(Token = "0x600047D")]
			[Address(RVA = "0x298A864", Offset = "0x298A864", VA = "0x298A864")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700005E")]
		private bool ikUsed
		{
			[Token(Token = "0x600047F")]
			[Address(RVA = "0x298B348", Offset = "0x298B348", VA = "0x298B348")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000472")]
		[Address(RVA = "0x298A82C", Offset = "0x298A82C", VA = "0x298A82C")]
		public void EnableRagdoll()
		{
		}

		[Token(Token = "0x6000473")]
		[Address(RVA = "0x298A8DC", Offset = "0x298A8DC", VA = "0x298A8DC")]
		public void DisableRagdoll()
		{
		}

		[Token(Token = "0x6000474")]
		[Address(RVA = "0x298AA0C", Offset = "0x298AA0C", VA = "0x298AA0C")]
		public void Start()
		{
		}

		[Token(Token = "0x6000475")]
		[Address(RVA = "0x298A99C", Offset = "0x298A99C", VA = "0x298A99C")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x14D9184", Offset = "0x14D9184")]
		private IEnumerator DisableRagdollSmooth()
		{
			return null;
		}

		[Token(Token = "0x6000476")]
		[Address(RVA = "0x298AF88", Offset = "0x298AF88", VA = "0x298AF88")]
		private void Update()
		{
		}

		[Token(Token = "0x6000477")]
		[Address(RVA = "0x298B1D4", Offset = "0x298B1D4", VA = "0x298B1D4")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000478")]
		[Address(RVA = "0x298B28C", Offset = "0x298B28C", VA = "0x298B28C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000479")]
		[Address(RVA = "0x298B4CC", Offset = "0x298B4CC", VA = "0x298B4CC")]
		private void AfterLastIK()
		{
		}

		[Token(Token = "0x600047A")]
		[Address(RVA = "0x298B30C", Offset = "0x298B30C", VA = "0x298B30C")]
		private void AfterAnimation()
		{
		}

		[Token(Token = "0x600047B")]
		[Address(RVA = "0x298B488", Offset = "0x298B488", VA = "0x298B488")]
		private void OnFinalPose()
		{
		}

		[Token(Token = "0x600047C")]
		[Address(RVA = "0x298B568", Offset = "0x298B568", VA = "0x298B568")]
		private void RagdollEnabler()
		{
		}

		[Token(Token = "0x600047E")]
		[Address(RVA = "0x298B500", Offset = "0x298B500", VA = "0x298B500")]
		private void RecordVelocities()
		{
		}

		[Token(Token = "0x6000480")]
		[Address(RVA = "0x298A934", Offset = "0x298A934", VA = "0x298A934")]
		private void StoreLocalState()
		{
		}

		[Token(Token = "0x6000481")]
		[Address(RVA = "0x298B214", Offset = "0x298B214", VA = "0x298B214")]
		private void FixTransforms(float weight)
		{
		}

		[Token(Token = "0x6000482")]
		[Address(RVA = "0x298BD0C", Offset = "0x298BD0C", VA = "0x298BD0C")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000483")]
		[Address(RVA = "0x298BE10", Offset = "0x298BE10", VA = "0x298BE10")]
		public RagdollUtility()
		{
		}
	}
	[Token(Token = "0x200006F")]
	public abstract class RotationLimit : MonoBehaviour
	{
		[Token(Token = "0x40003A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Vector3 axis;

		[Token(Token = "0x40003A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[HideInInspector]
		public Quaternion defaultLocalRotation;

		[Token(Token = "0x40003A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x14D3210", Offset = "0x14D3210")]
		private bool <defaultLocalRotationOverride>k__BackingField;

		[Token(Token = "0x40003A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x35")]
		private bool initiated;

		[Token(Token = "0x40003AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x36")]
		private bool applicationQuit;

		[Token(Token = "0x40003AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x37")]
		private bool defaultLocalRotationSet;

		[Token(Token = "0x1700005F")]
		public Vector3 secondaryAxis
		{
			[Token(Token = "0x6000489")]
			[Address(RVA = "0x298DB6C", Offset = "0x298DB6C", VA = "0x298DB6C")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000060")]
		public Vector3 crossAxis
		{
			[Token(Token = "0x600048A")]
			[Address(RVA = "0x298DBA8", Offset = "0x298DBA8", VA = "0x298DBA8")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000061")]
		public bool defaultLocalRotationOverride
		{
			[Token(Token = "0x600048B")]
			[Address(RVA = "0x298DC78", Offset = "0x298DC78", VA = "0x298DC78")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x14D91E8", Offset = "0x14D91E8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600048C")]
			[Address(RVA = "0x298DC80", Offset = "0x298DC80", VA = "0x298DC80")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x14D91F8", Offset = "0x14D91F8")]
			private set
			{
			}
		}

		[Token(Token = "0x6000484")]
		[Address(RVA = "0x298D7D0", Offset = "0x298D7D0", VA = "0x298D7D0")]
		public void SetDefaultLocalRotation()
		{
		}

		[Token(Token = "0x6000485")]
		[Address(RVA = "0x298D818", Offset = "0x298D818", VA = "0x298D818")]
		public void SetDefaultLocalRotation(Quaternion localRotation)
		{
		}

		[Token(Token = "0x6000486")]
		[Address(RVA = "0x298D830", Offset = "0x298D830", VA = "0x298D830")]
		public Quaternion GetLimitedLocalRotation(Quaternion localRotation, out bool changed)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000487")]
		[Address(RVA = "0x298DAC4", Offset = "0x298DAC4", VA = "0x298DAC4")]
		public bool Apply()
		{
			return default(bool);
		}

		[Token(Token = "0x6000488")]
		[Address(RVA = "0x298DB34", Offset = "0x298DB34", VA = "0x298DB34")]
		public void Disable()
		{
		}

		[Token(Token = "0x600048D")]
		protected abstract Quaternion LimitRotation(Quaternion rotation);

		[Token(Token = "0x600048E")]
		[Address(RVA = "0x298D9D4", Offset = "0x298D9D4", VA = "0x298D9D4")]
		private void Awake()
		{
		}

		[Token(Token = "0x600048F")]
		[Address(RVA = "0x298DC8C", Offset = "0x298DC8C", VA = "0x298DC8C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000490")]
		[Address(RVA = "0x298DC90", Offset = "0x298DC90", VA = "0x298DC90")]
		public void LogWarning(string message)
		{
		}

		[Token(Token = "0x6000491")]
		[Address(RVA = "0x298DCC0", Offset = "0x298DCC0", VA = "0x298DCC0")]
		protected static Quaternion Limit1DOF(Quaternion rotation, Vector3 axis)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000492")]
		[Address(RVA = "0x298DDA4", Offset = "0x298DDA4", VA = "0x298DDA4")]
		protected static Quaternion LimitTwist(Quaternion rotation, Vector3 axis, Vector3 orthoAxis, float twistLimit)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000493")]
		[Address(RVA = "0x298E020", Offset = "0x298E020", VA = "0x298E020")]
		protected static float GetOrthogonalAngle(Vector3 v1, Vector3 v2, Vector3 normal)
		{
			return default(float);
		}

		[Token(Token = "0x6000494")]
		[Address(RVA = "0x298E0DC", Offset = "0x298E0DC", VA = "0x298E0DC")]
		protected RotationLimit()
		{
		}
	}
	[Token(Token = "0x2000070")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x14CFAF8", Offset = "0x14CFAF8")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x14CFAF8", Offset = "0x14CFAF8")]
	public class RotationLimitAngle : RotationLimit
	{
		[Token(Token = "0x40003AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x14D3220", Offset = "0x14D3220")]
		public float limit;

		[Token(Token = "0x40003AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x14D323C", Offset = "0x14D323C")]
		public float twistLimit;

		[Token(Token = "0x6000495")]
		[Address(RVA = "0x298E154", Offset = "0x298E154", VA = "0x298E154")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x14D9208", Offset = "0x14D9208")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x6000496")]
		[Address(RVA = "0x298E1A0", Offset = "0x298E1A0", VA = "0x298E1A0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x14D9240", Offset = "0x14D9240")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000497")]
		[Address(RVA = "0x298E1EC", Offset = "0x298E1EC", VA = "0x298E1EC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x14D9278", Offset = "0x14D9278")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000498")]
		[Address(RVA = "0x298E238", Offset = "0x298E238", VA = "0x298E238")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x14D92B0", Offset = "0x14D92B0")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000499")]
		[Address(RVA = "0x298E284", Offset = "0x298E284", VA = "0x298E284", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600049A")]
		[Address(RVA = "0x298E33C", Offset = "0x298E33C", VA = "0x298E33C")]
		private Quaternion LimitSwing(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600049B")]
		[Address(RVA = "0x298E584", Offset = "0x298E584", VA = "0x298E584")]
		public RotationLimitAngle()
		{
		}
	}
	[Token(Token = "0x2000071")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x14CFB58", Offset = "0x14CFB58")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x14CFB58", Offset = "0x14CFB58")]
	public class RotationLimitHinge : RotationLimit
	{
		[Token(Token = "0x40003AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public bool useLimits;

		[Token(Token = "0x40003AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float min;

		[Token(Token = "0x40003B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float max;

		[Token(Token = "0x40003B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[HideInInspector]
		public float zeroAxisDisplayOffset;

		[Token(Token = "0x40003B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Quaternion lastRotation;

		[Token(Token = "0x40003B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private float lastAngle;

		[Token(Token = "0x600049C")]
		[Address(RVA = "0x298E594", Offset = "0x298E594", VA = "0x298E594")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x14D92E8", Offset = "0x14D92E8")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x600049D")]
		[Address(RVA = "0x298E5E0", Offset = "0x298E5E0", VA = "0x298E5E0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x14D9320", Offset = "0x14D9320")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x600049E")]
		[Address(RVA = "0x298E62C", Offset = "0x298E62C", VA = "0x298E62C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x14D9358", Offset = "0x14D9358")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600049F")]
		[Address(RVA = "0x298E678", Offset = "0x298E678", VA = "0x298E678")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x14D9390", Offset = "0x14D9390")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60004A0")]
		[Address(RVA = "0x298E6C4", Offset = "0x298E6C4", VA = "0x298E6C4", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60004A1")]
		[Address(RVA = "0x298E6EC", Offset = "0x298E6EC", VA = "0x298E6EC")]
		private Quaternion LimitHinge(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60004A2")]
		[Address(RVA = "0x298E9EC", Offset = "0x298E9EC", VA = "0x298E9EC")]
		public RotationLimitHinge()
		{
		}
	}
	[Token(Token = "0x2000072")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x14CFBB8", Offset = "0x14CFBB8")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x14CFBB8", Offset = "0x14CFBB8")]
	public class RotationLimitPolygonal : RotationLimit
	{
		[Serializable]
		[Token(Token = "0x20001BC")]
		public class ReachCone
		{
			[Token(Token = "0x4000B0E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Vector3[] tetrahedron;

			[Token(Token = "0x4000B0F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float volume;

			[Token(Token = "0x4000B10")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public Vector3 S;

			[Token(Token = "0x4000B11")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Vector3 B;

			[Token(Token = "0x170000B5")]
			public Vector3 o
			{
				[Token(Token = "0x6000CDF")]
				[Address(RVA = "0x2990988", Offset = "0x2990988", VA = "0x2990988")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x170000B6")]
			public Vector3 a
			{
				[Token(Token = "0x6000CE0")]
				[Address(RVA = "0x29909C0", Offset = "0x29909C0", VA = "0x29909C0")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x170000B7")]
			public Vector3 b
			{
				[Token(Token = "0x6000CE1")]
				[Address(RVA = "0x29909FC", Offset = "0x29909FC", VA = "0x29909FC")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x170000B8")]
			public Vector3 c
			{
				[Token(Token = "0x6000CE2")]
				[Address(RVA = "0x2990A38", Offset = "0x2990A38", VA = "0x2990A38")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x170000B9")]
			public bool isValid
			{
				[Token(Token = "0x6000CE4")]
				[Address(RVA = "0x298FAEC", Offset = "0x298FAEC", VA = "0x298FAEC")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x6000CE3")]
			[Address(RVA = "0x2990138", Offset = "0x2990138", VA = "0x2990138")]
			public ReachCone(Vector3 _o, Vector3 _a, Vector3 _b, Vector3 _c)
			{
			}

			[Token(Token = "0x6000CE5")]
			[Address(RVA = "0x2990298", Offset = "0x2990298", VA = "0x2990298")]
			public void Calculate()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20001BD")]
		public class LimitPoint
		{
			[Token(Token = "0x4000B12")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Vector3 point;

			[Token(Token = "0x4000B13")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public float tangentWeight;

			[Token(Token = "0x6000CE6")]
			[Address(RVA = "0x298FAFC", Offset = "0x298FAFC", VA = "0x298FAFC")]
			public LimitPoint()
			{
			}
		}

		[Token(Token = "0x40003B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x14D3268", Offset = "0x14D3268")]
		public float twistLimit;

		[Token(Token = "0x40003B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x14D3284", Offset = "0x14D3284")]
		public int smoothIterations;

		[Token(Token = "0x40003B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		[HideInInspector]
		public LimitPoint[] points;

		[Token(Token = "0x40003B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		[HideInInspector]
		public Vector3[] P;

		[Token(Token = "0x40003B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		[HideInInspector]
		public ReachCone[] reachCones;

		[Token(Token = "0x60004A3")]
		[Address(RVA = "0x298EA74", Offset = "0x298EA74", VA = "0x298EA74")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x14D93C8", Offset = "0x14D93C8")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x60004A4")]
		[Address(RVA = "0x298EAC0", Offset = "0x298EAC0", VA = "0x298EAC0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x14D9400", Offset = "0x14D9400")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x60004A5")]
		[Address(RVA = "0x298EB0C", Offset = "0x298EB0C", VA = "0x298EB0C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x14D9438", Offset = "0x14D9438")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60004A6")]
		[Address(RVA = "0x298EB58", Offset = "0x298EB58", VA = "0x298EB58")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x14D9470", Offset = "0x14D9470")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60004A7")]
		[Address(RVA = "0x298EBA4", Offset = "0x298EBA4", VA = "0x298EBA4")]
		public void SetLimitPoints(LimitPoint[] points)
		{
		}

		[Token(Token = "0x60004A8")]
		[Address(RVA = "0x298F088", Offset = "0x298F088", VA = "0x298F088", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60004A9")]
		[Address(RVA = "0x298F180", Offset = "0x298F180", VA = "0x298F180")]
		private void Start()
		{
		}

		[Token(Token = "0x60004AA")]
		[Address(RVA = "0x298F738", Offset = "0x298F738", VA = "0x298F738")]
		public void ResetToDefault()
		{
		}

		[Token(Token = "0x60004AB")]
		[Address(RVA = "0x298EC40", Offset = "0x298EC40", VA = "0x298EC40")]
		public void BuildReachCones()
		{
		}

		[Token(Token = "0x60004AC")]
		[Address(RVA = "0x298FB80", Offset = "0x298FB80", VA = "0x298FB80")]
		private Vector3[] SmoothPoints()
		{
			return null;
		}

		[Token(Token = "0x60004AD")]
		[Address(RVA = "0x2990458", Offset = "0x2990458", VA = "0x2990458")]
		private float GetScalar(int k)
		{
			return default(float);
		}

		[Token(Token = "0x60004AE")]
		[Address(RVA = "0x299049C", Offset = "0x299049C", VA = "0x299049C")]
		private Vector3 PointToTangentPlane(Vector3 p, float r)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60004AF")]
		[Address(RVA = "0x29905E4", Offset = "0x29905E4", VA = "0x29905E4")]
		private Vector3 TangentPointToSphere(Vector3 q, float r)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60004B0")]
		[Address(RVA = "0x298F400", Offset = "0x298F400", VA = "0x298F400")]
		private Quaternion LimitSwing(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60004B1")]
		[Address(RVA = "0x2990774", Offset = "0x2990774", VA = "0x2990774")]
		private int GetReachCone(Vector3 L)
		{
			return default(int);
		}

		[Token(Token = "0x60004B2")]
		[Address(RVA = "0x2990924", Offset = "0x2990924", VA = "0x2990924")]
		public RotationLimitPolygonal()
		{
		}
	}
	[Token(Token = "0x2000073")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x14CFC18", Offset = "0x14CFC18")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x14CFC18", Offset = "0x14CFC18")]
	public class RotationLimitSpline : RotationLimit
	{
		[Token(Token = "0x40003B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x14D3344", Offset = "0x14D3344")]
		public float twistLimit;

		[Token(Token = "0x40003BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		[HideInInspector]
		public AnimationCurve spline;

		[Token(Token = "0x60004B3")]
		[Address(RVA = "0x2990A74", Offset = "0x2990A74", VA = "0x2990A74")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x14D94A8", Offset = "0x14D94A8")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x60004B4")]
		[Address(RVA = "0x2990AC0", Offset = "0x2990AC0", VA = "0x2990AC0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x14D94E0", Offset = "0x14D94E0")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x60004B5")]
		[Address(RVA = "0x2990B0C", Offset = "0x2990B0C", VA = "0x2990B0C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x14D9518", Offset = "0x14D9518")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60004B6")]
		[Address(RVA = "0x2990B58", Offset = "0x2990B58", VA = "0x2990B58")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x14D9550", Offset = "0x14D9550")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60004B7")]
		[Address(RVA = "0x2990BA4", Offset = "0x2990BA4", VA = "0x2990BA4")]
		public void SetSpline(Keyframe[] keyframes)
		{
		}

		[Token(Token = "0x60004B8")]
		[Address(RVA = "0x2990BC0", Offset = "0x2990BC0", VA = "0x2990BC0", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60004B9")]
		[Address(RVA = "0x2990C78", Offset = "0x2990C78", VA = "0x2990C78")]
		public Quaternion LimitSwing(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60004BA")]
		[Address(RVA = "0x2990FA4", Offset = "0x2990FA4", VA = "0x2990FA4")]
		public RotationLimitSpline()
		{
		}
	}
	[Token(Token = "0x2000074")]
	public class AimController : MonoBehaviour
	{
		[Token(Token = "0x20001BE")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x14CFEF8", Offset = "0x14CFEF8")]
		private sealed class <TurnToTarget>d__33 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000B14")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000B15")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000B16")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public AimController <>4__this;

			[Token(Token = "0x170000BA")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000CEA")]
				[Address(RVA = "0x2B14108", Offset = "0x2B14108", VA = "0x2B14108", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000BB")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000CEC")]
				[Address(RVA = "0x2B14170", Offset = "0x2B14170", VA = "0x2B14170", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000CE7")]
			[Address(RVA = "0x2B13EE4", Offset = "0x2B13EE4", VA = "0x2B13EE4")]
			[DebuggerHidden]
			public <TurnToTarget>d__33(int <>1__state)
			{
			}

			[Token(Token = "0x6000CE8")]
			[Address(RVA = "0x2B13FE4", Offset = "0x2B13FE4", VA = "0x2B13FE4", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000CE9")]
			[Address(RVA = "0x2B13FE8", Offset = "0x2B13FE8", VA = "0x2B13FE8", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000CEB")]
			[Address(RVA = "0x2B14110", Offset = "0x2B14110", VA = "0x2B14110", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40003BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D3398", Offset = "0x14D3398")]
		public AimIK ik;

		[Token(Token = "0x40003BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D33D0", Offset = "0x14D33D0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x14D33D0", Offset = "0x14D33D0")]
		public float weight;

		[Token(Token = "0x40003BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x14D3424", Offset = "0x14D3424")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D3424", Offset = "0x14D3424")]
		public Transform target;

		[Token(Token = "0x40003BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D3484", Offset = "0x14D3484")]
		public float targetSwitchSmoothTime;

		[Token(Token = "0x40003BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D34BC", Offset = "0x14D34BC")]
		public float weightSmoothTime;

		[Token(Token = "0x40003C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x14D34F4", Offset = "0x14D34F4")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D34F4", Offset = "0x14D34F4")]
		public bool smoothTurnTowardsTarget;

		[Token(Token = "0x40003C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D3554", Offset = "0x14D3554")]
		public float maxRadiansDelta;

		[Token(Token = "0x40003C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D358C", Offset = "0x14D358C")]
		public float maxMagnitudeDelta;

		[Token(Token = "0x40003C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D35C4", Offset = "0x14D35C4")]
		public float slerpSpeed;

		[Token(Token = "0x40003C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D35FC", Offset = "0x14D35FC")]
		public Vector3 pivotOffsetFromRoot;

		[Token(Token = "0x40003C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D3634", Offset = "0x14D3634")]
		public float minDistance;

		[Token(Token = "0x40003C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D366C", Offset = "0x14D366C")]
		public Vector3 offset;

		[Token(Token = "0x40003C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x14D36A4", Offset = "0x14D36A4")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D36A4", Offset = "0x14D36A4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x14D36A4", Offset = "0x14D36A4")]
		public float maxRootAngle;

		[Token(Token = "0x40003C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D3720", Offset = "0x14D3720")]
		public bool turnToTarget;

		[Token(Token = "0x40003C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D3758", Offset = "0x14D3758")]
		public float turnToTargetTime;

		[Token(Token = "0x40003CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x14D3790", Offset = "0x14D3790")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D3790", Offset = "0x14D3790")]
		public bool useAnimatedAimDirection;

		[Token(Token = "0x40003CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D37F0", Offset = "0x14D37F0")]
		public Vector3 animatedAimDirection;

		[Token(Token = "0x40003CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Transform lastTarget;

		[Token(Token = "0x40003CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private float switchWeight;

		[Token(Token = "0x40003CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private float switchWeightV;

		[Token(Token = "0x40003CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private float weightV;

		[Token(Token = "0x40003D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private Vector3 lastPosition;

		[Token(Token = "0x40003D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private Vector3 dir;

		[Token(Token = "0x40003D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		private bool lastSmoothTowardsTarget;

		[Token(Token = "0x40003D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAD")]
		private bool turningToTarget;

		[Token(Token = "0x40003D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private float turnToTargetMlp;

		[Token(Token = "0x40003D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		private float turnToTargetMlpV;

		[Token(Token = "0x17000062")]
		private Vector3 pivot
		{
			[Token(Token = "0x60004BD")]
			[Address(RVA = "0x2B130E4", Offset = "0x2B130E4", VA = "0x2B130E4")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x60004BB")]
		[Address(RVA = "0x2B12FE8", Offset = "0x2B12FE8", VA = "0x2B12FE8")]
		private void Start()
		{
		}

		[Token(Token = "0x60004BC")]
		[Address(RVA = "0x2B13230", Offset = "0x2B13230", VA = "0x2B13230")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60004BE")]
		[Address(RVA = "0x2B13968", Offset = "0x2B13968", VA = "0x2B13968")]
		private void ApplyMinDistance()
		{
		}

		[Token(Token = "0x60004BF")]
		[Address(RVA = "0x2B13B04", Offset = "0x2B13B04", VA = "0x2B13B04")]
		private void RootRotation()
		{
		}

		[Token(Token = "0x60004C0")]
		[Address(RVA = "0x2B13E74", Offset = "0x2B13E74", VA = "0x2B13E74")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x14D9588", Offset = "0x14D9588")]
		private IEnumerator TurnToTarget()
		{
			return null;
		}

		[Token(Token = "0x60004C1")]
		[Address(RVA = "0x2B13F10", Offset = "0x2B13F10", VA = "0x2B13F10")]
		public AimController()
		{
		}
	}
	[Token(Token = "0x2000075")]
	public class AimPoser : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20001BF")]
		public class Pose
		{
			[Token(Token = "0x4000B17")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public bool visualize;

			[Token(Token = "0x4000B18")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public string name;

			[Token(Token = "0x4000B19")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Vector3 direction;

			[Token(Token = "0x4000B1A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public float yaw;

			[Token(Token = "0x4000B1B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public float pitch;

			[Token(Token = "0x4000B1C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private float angleBuffer;

			[Token(Token = "0x6000CED")]
			[Address(RVA = "0x2B18034", Offset = "0x2B18034", VA = "0x2B18034")]
			public bool IsInDirection(Vector3 d)
			{
				return default(bool);
			}

			[Token(Token = "0x6000CEE")]
			[Address(RVA = "0x2B183A0", Offset = "0x2B183A0", VA = "0x2B183A0")]
			public void SetAngleBuffer(float value)
			{
			}

			[Token(Token = "0x6000CEF")]
			[Address(RVA = "0x2B183A8", Offset = "0x2B183A8", VA = "0x2B183A8")]
			public Pose()
			{
			}
		}

		[Token(Token = "0x40003D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float angleBuffer;

		[Token(Token = "0x40003D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Pose[] poses;

		[Token(Token = "0x60004C2")]
		[Address(RVA = "0x2B17F58", Offset = "0x2B17F58", VA = "0x2B17F58")]
		public Pose GetPose(Vector3 localDirection)
		{
			return null;
		}

		[Token(Token = "0x60004C3")]
		[Address(RVA = "0x2B182CC", Offset = "0x2B182CC", VA = "0x2B182CC")]
		public void SetPoseActive(Pose pose)
		{
		}

		[Token(Token = "0x60004C4")]
		[Address(RVA = "0x2B18338", Offset = "0x2B18338", VA = "0x2B18338")]
		public AimPoser()
		{
		}
	}
	[Token(Token = "0x2000076")]
	public class Amplifier : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x20001C0")]
		public class Body
		{
			[Serializable]
			[Token(Token = "0x20001E2")]
			public class EffectorLink
			{
				[Token(Token = "0x4000BD2")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D73C4", Offset = "0x14D73C4")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x4000BD3")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D73FC", Offset = "0x14D73FC")]
				public float weight;

				[Token(Token = "0x6000D5D")]
				[Address(RVA = "0x2B18998", Offset = "0x2B18998", VA = "0x2B18998")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x4000B1D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D63EC", Offset = "0x14D63EC")]
			public Transform transform;

			[Token(Token = "0x4000B1E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D6424", Offset = "0x14D6424")]
			public Transform relativeTo;

			[Token(Token = "0x4000B1F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D645C", Offset = "0x14D645C")]
			public EffectorLink[] effectorLinks;

			[Token(Token = "0x4000B20")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D6494", Offset = "0x14D6494")]
			public float verticalWeight;

			[Token(Token = "0x4000B21")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D64CC", Offset = "0x14D64CC")]
			public float horizontalWeight;

			[Token(Token = "0x4000B22")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D6504", Offset = "0x14D6504")]
			public float speed;

			[Token(Token = "0x4000B23")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private Vector3 lastRelativePos;

			[Token(Token = "0x4000B24")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private Vector3 smoothDelta;

			[Token(Token = "0x4000B25")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			private bool firstUpdate;

			[Token(Token = "0x6000CF0")]
			[Address(RVA = "0x2B18504", Offset = "0x2B18504", VA = "0x2B18504")]
			public void Update(IKSolverFullBodyBiped solver, float w, float deltaTime)
			{
			}

			[Token(Token = "0x6000CF1")]
			[Address(RVA = "0x2B18970", Offset = "0x2B18970", VA = "0x2B18970")]
			private static Vector3 Multiply(Vector3 v1, Vector3 v2)
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000CF2")]
			[Address(RVA = "0x2B18980", Offset = "0x2B18980", VA = "0x2B18980")]
			public Body()
			{
			}
		}

		[Token(Token = "0x40003D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D3828", Offset = "0x14D3828")]
		public Body[] bodies;

		[Token(Token = "0x60004C5")]
		[Address(RVA = "0x2B183C4", Offset = "0x2B183C4", VA = "0x2B183C4", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x60004C6")]
		[Address(RVA = "0x2B18968", Offset = "0x2B18968", VA = "0x2B18968")]
		public Amplifier()
		{
		}
	}
	[Token(Token = "0x2000077")]
	public class BodyTilt : OffsetModifier
	{
		[Token(Token = "0x40003D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D3860", Offset = "0x14D3860")]
		public float tiltSpeed;

		[Token(Token = "0x40003DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D3898", Offset = "0x14D3898")]
		public float tiltSensitivity;

		[Token(Token = "0x40003DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D38D0", Offset = "0x14D38D0")]
		public OffsetPose poseLeft;

		[Token(Token = "0x40003DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D3908", Offset = "0x14D3908")]
		public OffsetPose poseRight;

		[Token(Token = "0x40003DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float tiltAngle;

		[Token(Token = "0x40003DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Vector3 lastForward;

		[Token(Token = "0x60004C7")]
		[Address(RVA = "0x2B19EA4", Offset = "0x2B19EA4", VA = "0x2B19EA4", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60004C8")]
		[Address(RVA = "0x2B19EEC", Offset = "0x2B19EEC", VA = "0x2B19EEC", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x60004C9")]
		[Address(RVA = "0x2B1A11C", Offset = "0x2B1A11C", VA = "0x2B1A11C")]
		public BodyTilt()
		{
		}
	}
	[Token(Token = "0x2000078")]
	[ExecuteInEditMode]
	public class EditorIK : MonoBehaviour
	{
		[Token(Token = "0x40003DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private IK ik;

		[Token(Token = "0x60004CA")]
		[Address(RVA = "0x2B1D7C8", Offset = "0x2B1D7C8", VA = "0x2B1D7C8")]
		private void Start()
		{
		}

		[Token(Token = "0x60004CB")]
		[Address(RVA = "0x2B1D85C", Offset = "0x2B1D85C", VA = "0x2B1D85C")]
		private void Update()
		{
		}

		[Token(Token = "0x60004CC")]
		[Address(RVA = "0x2B1D92C", Offset = "0x2B1D92C", VA = "0x2B1D92C")]
		public EditorIK()
		{
		}
	}
	[Token(Token = "0x2000079")]
	public class HitReaction : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x20001C1")]
		public abstract class HitPoint
		{
			[Token(Token = "0x4000B26")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D653C", Offset = "0x14D653C")]
			public string name;

			[Token(Token = "0x4000B27")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D6574", Offset = "0x14D6574")]
			public Collider collider;

			[Token(Token = "0x4000B28")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D65AC", Offset = "0x14D65AC")]
			[SerializeField]
			private float crossFadeTime;

			[Token(Token = "0x4000B29")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x14D65F8", Offset = "0x14D65F8")]
			private float <crossFader>k__BackingField;

			[Token(Token = "0x4000B2A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x14D6608", Offset = "0x14D6608")]
			private float <timer>k__BackingField;

			[Token(Token = "0x4000B2B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x14D6618", Offset = "0x14D6618")]
			private Vector3 <force>k__BackingField;

			[Token(Token = "0x4000B2C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x14D6628", Offset = "0x14D6628")]
			private Vector3 <point>k__BackingField;

			[Token(Token = "0x4000B2D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			private float length;

			[Token(Token = "0x4000B2E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private float crossFadeSpeed;

			[Token(Token = "0x4000B2F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			private float lastTime;

			[Token(Token = "0x170000BC")]
			public bool inProgress
			{
				[Token(Token = "0x6000CF3")]
				[Address(RVA = "0x2D4BE0C", Offset = "0x2D4BE0C", VA = "0x2D4BE0C")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x170000BD")]
			protected float crossFader
			{
				[Token(Token = "0x6000CF4")]
				[Address(RVA = "0x2D4C3B4", Offset = "0x2D4C3B4", VA = "0x2D4C3B4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x14D9B8C", Offset = "0x14D9B8C")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000CF5")]
				[Address(RVA = "0x2D4C3BC", Offset = "0x2D4C3BC", VA = "0x2D4C3BC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x14D9B9C", Offset = "0x14D9B9C")]
				private set
				{
				}
			}

			[Token(Token = "0x170000BE")]
			protected float timer
			{
				[Token(Token = "0x6000CF6")]
				[Address(RVA = "0x2D4C3C4", Offset = "0x2D4C3C4", VA = "0x2D4C3C4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x14D9BAC", Offset = "0x14D9BAC")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000CF7")]
				[Address(RVA = "0x2D4C3CC", Offset = "0x2D4C3CC", VA = "0x2D4C3CC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x14D9BBC", Offset = "0x14D9BBC")]
				private set
				{
				}
			}

			[Token(Token = "0x170000BF")]
			protected Vector3 force
			{
				[Token(Token = "0x6000CF8")]
				[Address(RVA = "0x2D4C3D4", Offset = "0x2D4C3D4", VA = "0x2D4C3D4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x14D9BCC", Offset = "0x14D9BCC")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000CF9")]
				[Address(RVA = "0x2D4C3E0", Offset = "0x2D4C3E0", VA = "0x2D4C3E0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x14D9BDC", Offset = "0x14D9BDC")]
				private set
				{
				}
			}

			[Token(Token = "0x170000C0")]
			protected Vector3 point
			{
				[Token(Token = "0x6000CFA")]
				[Address(RVA = "0x2D4C3EC", Offset = "0x2D4C3EC", VA = "0x2D4C3EC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x14D9BEC", Offset = "0x14D9BEC")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000CFB")]
				[Address(RVA = "0x2D4C3F8", Offset = "0x2D4C3F8", VA = "0x2D4C3F8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x14D9BFC", Offset = "0x14D9BFC")]
				private set
				{
				}
			}

			[Token(Token = "0x6000CFC")]
			[Address(RVA = "0x2D4C280", Offset = "0x2D4C280", VA = "0x2D4C280")]
			public void Hit(Vector3 force, Vector3 point)
			{
			}

			[Token(Token = "0x6000CFD")]
			[Address(RVA = "0x2D4BEF4", Offset = "0x2D4BEF4", VA = "0x2D4BEF4")]
			public void Apply(IKSolverFullBodyBiped solver, float weight)
			{
			}

			[Token(Token = "0x6000CFE")]
			protected abstract float GetLength();

			[Token(Token = "0x6000CFF")]
			protected abstract void CrossFadeStart();

			[Token(Token = "0x6000D00")]
			protected abstract void OnApply(IKSolverFullBodyBiped solver, float weight);

			[Token(Token = "0x6000D01")]
			[Address(RVA = "0x2D4C404", Offset = "0x2D4C404", VA = "0x2D4C404")]
			protected HitPoint()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20001C2")]
		public class HitPointEffector : HitPoint
		{
			[Serializable]
			[Token(Token = "0x20001E3")]
			public class EffectorLink
			{
				[Token(Token = "0x4000BD4")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D7434", Offset = "0x14D7434")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x4000BD5")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D746C", Offset = "0x14D746C")]
				public float weight;

				[Token(Token = "0x4000BD6")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				private Vector3 lastValue;

				[Token(Token = "0x4000BD7")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
				private Vector3 current;

				[Token(Token = "0x6000D5E")]
				[Address(RVA = "0x2D4CD70", Offset = "0x2D4CD70", VA = "0x2D4CD70")]
				public void Apply(IKSolverFullBodyBiped solver, Vector3 offset, float crossFader)
				{
				}

				[Token(Token = "0x6000D5F")]
				[Address(RVA = "0x2D4CB64", Offset = "0x2D4CB64", VA = "0x2D4CB64")]
				public void CrossFadeStart()
				{
				}

				[Token(Token = "0x6000D60")]
				[Address(RVA = "0x2D4CEAC", Offset = "0x2D4CEAC", VA = "0x2D4CEAC")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x4000B30")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D6638", Offset = "0x14D6638")]
			public AnimationCurve offsetInForceDirection;

			[Token(Token = "0x4000B31")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D6670", Offset = "0x14D6670")]
			public AnimationCurve offsetInUpDirection;

			[Token(Token = "0x4000B32")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D66A8", Offset = "0x14D66A8")]
			public EffectorLink[] effectorLinks;

			[Token(Token = "0x6000D02")]
			[Address(RVA = "0x2D4C980", Offset = "0x2D4C980", VA = "0x2D4C980", Slot = "4")]
			protected override float GetLength()
			{
				return default(float);
			}

			[Token(Token = "0x6000D03")]
			[Address(RVA = "0x2D4CAF8", Offset = "0x2D4CAF8", VA = "0x2D4CAF8", Slot = "5")]
			protected override void CrossFadeStart()
			{
			}

			[Token(Token = "0x6000D04")]
			[Address(RVA = "0x2D4CB78", Offset = "0x2D4CB78", VA = "0x2D4CB78", Slot = "6")]
			protected override void OnApply(IKSolverFullBodyBiped solver, float weight)
			{
			}

			[Token(Token = "0x6000D05")]
			[Address(RVA = "0x2D4CE98", Offset = "0x2D4CE98", VA = "0x2D4CE98")]
			public HitPointEffector()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20001C3")]
		public class HitPointBone : HitPoint
		{
			[Serializable]
			[Token(Token = "0x20001E4")]
			public class BoneLink
			{
				[Token(Token = "0x4000BD8")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D74A4", Offset = "0x14D74A4")]
				public Transform bone;

				[Token(Token = "0x4000BD9")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D74DC", Offset = "0x14D74DC")]
				[AttributeAttribute(Name = "RangeAttribute", RVA = "0x14D74DC", Offset = "0x14D74DC")]
				public float weight;

				[Token(Token = "0x4000BDA")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
				private Quaternion lastValue;

				[Token(Token = "0x4000BDB")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
				private Quaternion current;

				[Token(Token = "0x6000D61")]
				[Address(RVA = "0x2D4C788", Offset = "0x2D4C788", VA = "0x2D4C788")]
				public void Apply(IKSolverFullBodyBiped solver, Quaternion offset, float crossFader)
				{
				}

				[Token(Token = "0x6000D62")]
				[Address(RVA = "0x2D4C520", Offset = "0x2D4C520", VA = "0x2D4C520")]
				public void CrossFadeStart()
				{
				}

				[Token(Token = "0x6000D63")]
				[Address(RVA = "0x2D4C8F8", Offset = "0x2D4C8F8", VA = "0x2D4C8F8")]
				public BoneLink()
				{
				}
			}

			[Token(Token = "0x4000B33")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D66E0", Offset = "0x14D66E0")]
			public AnimationCurve aroundCenterOfMass;

			[Token(Token = "0x4000B34")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D6718", Offset = "0x14D6718")]
			public BoneLink[] boneLinks;

			[Token(Token = "0x4000B35")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private Rigidbody rigidbody;

			[Token(Token = "0x6000D06")]
			[Address(RVA = "0x2D4C418", Offset = "0x2D4C418", VA = "0x2D4C418", Slot = "4")]
			protected override float GetLength()
			{
				return default(float);
			}

			[Token(Token = "0x6000D07")]
			[Address(RVA = "0x2D4C4BC", Offset = "0x2D4C4BC", VA = "0x2D4C4BC", Slot = "5")]
			protected override void CrossFadeStart()
			{
			}

			[Token(Token = "0x6000D08")]
			[Address(RVA = "0x2D4C52C", Offset = "0x2D4C52C", VA = "0x2D4C52C", Slot = "6")]
			protected override void OnApply(IKSolverFullBodyBiped solver, float weight)
			{
			}

			[Token(Token = "0x6000D09")]
			[Address(RVA = "0x2D4C8E4", Offset = "0x2D4C8E4", VA = "0x2D4C8E4")]
			public HitPointBone()
			{
			}
		}

		[Token(Token = "0x40003E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D3940", Offset = "0x14D3940")]
		public HitPointEffector[] effectorHitPoints;

		[Token(Token = "0x40003E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D3978", Offset = "0x14D3978")]
		public HitPointBone[] boneHitPoints;

		[Token(Token = "0x17000063")]
		public bool inProgress
		{
			[Token(Token = "0x60004CD")]
			[Address(RVA = "0x2D4BD50", Offset = "0x2D4BD50", VA = "0x2D4BD50")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60004CE")]
		[Address(RVA = "0x2D4BE20", Offset = "0x2D4BE20", VA = "0x2D4BE20", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x60004CF")]
		[Address(RVA = "0x2D4C040", Offset = "0x2D4C040", VA = "0x2D4C040")]
		public void Hit(Collider collider, Vector3 force, Vector3 point)
		{
		}

		[Token(Token = "0x60004D0")]
		[Address(RVA = "0x2D4C3AC", Offset = "0x2D4C3AC", VA = "0x2D4C3AC")]
		public HitReaction()
		{
		}
	}
	[Token(Token = "0x200007A")]
	public class HitReactionVRIK : OffsetModifierVRIK
	{
		[Serializable]
		[Token(Token = "0x20001C4")]
		public abstract class Offset
		{
			[Token(Token = "0x4000B36")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D6750", Offset = "0x14D6750")]
			public string name;

			[Token(Token = "0x4000B37")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D6788", Offset = "0x14D6788")]
			public Collider collider;

			[Token(Token = "0x4000B38")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D67C0", Offset = "0x14D67C0")]
			[SerializeField]
			private float crossFadeTime;

			[Token(Token = "0x4000B39")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x14D680C", Offset = "0x14D680C")]
			private float <crossFader>k__BackingField;

			[Token(Token = "0x4000B3A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x14D681C", Offset = "0x14D681C")]
			private float <timer>k__BackingField;

			[Token(Token = "0x4000B3B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x14D682C", Offset = "0x14D682C")]
			private Vector3 <force>k__BackingField;

			[Token(Token = "0x4000B3C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x14D683C", Offset = "0x14D683C")]
			private Vector3 <point>k__BackingField;

			[Token(Token = "0x4000B3D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			private float length;

			[Token(Token = "0x4000B3E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private float crossFadeSpeed;

			[Token(Token = "0x4000B3F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			private float lastTime;

			[Token(Token = "0x170000C1")]
			protected float crossFader
			{
				[Token(Token = "0x6000D0A")]
				[Address(RVA = "0x2D4D464", Offset = "0x2D4D464", VA = "0x2D4D464")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x14D9C0C", Offset = "0x14D9C0C")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000D0B")]
				[Address(RVA = "0x2D4D46C", Offset = "0x2D4D46C", VA = "0x2D4D46C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x14D9C1C", Offset = "0x14D9C1C")]
				private set
				{
				}
			}

			[Token(Token = "0x170000C2")]
			protected float timer
			{
				[Token(Token = "0x6000D0C")]
				[Address(RVA = "0x2D4D474", Offset = "0x2D4D474", VA = "0x2D4D474")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x14D9C2C", Offset = "0x14D9C2C")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000D0D")]
				[Address(RVA = "0x2D4D47C", Offset = "0x2D4D47C", VA = "0x2D4D47C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x14D9C3C", Offset = "0x14D9C3C")]
				private set
				{
				}
			}

			[Token(Token = "0x170000C3")]
			protected Vector3 force
			{
				[Token(Token = "0x6000D0E")]
				[Address(RVA = "0x2D4D484", Offset = "0x2D4D484", VA = "0x2D4D484")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x14D9C4C", Offset = "0x14D9C4C")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000D0F")]
				[Address(RVA = "0x2D4D490", Offset = "0x2D4D490", VA = "0x2D4D490")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x14D9C5C", Offset = "0x14D9C5C")]
				private set
				{
				}
			}

			[Token(Token = "0x170000C4")]
			protected Vector3 point
			{
				[Token(Token = "0x6000D10")]
				[Address(RVA = "0x2D4D49C", Offset = "0x2D4D49C", VA = "0x2D4D49C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x14D9C6C", Offset = "0x14D9C6C")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000D11")]
				[Address(RVA = "0x2D4D4A8", Offset = "0x2D4D4A8", VA = "0x2D4D4A8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x14D9C7C", Offset = "0x14D9C7C")]
				private set
				{
				}
			}

			[Token(Token = "0x6000D12")]
			[Address(RVA = "0x2D4D31C", Offset = "0x2D4D31C", VA = "0x2D4D31C")]
			public void Hit(Vector3 force, AnimationCurve[] curves, Vector3 point)
			{
			}

			[Token(Token = "0x6000D13")]
			[Address(RVA = "0x2D4CF80", Offset = "0x2D4CF80", VA = "0x2D4CF80")]
			public void Apply(VRIK ik, AnimationCurve[] curves, float weight)
			{
			}

			[Token(Token = "0x6000D14")]
			protected abstract float GetLength(AnimationCurve[] curves);

			[Token(Token = "0x6000D15")]
			protected abstract void CrossFadeStart();

			[Token(Token = "0x6000D16")]
			protected abstract void OnApply(VRIK ik, AnimationCurve[] curves, float weight);

			[Token(Token = "0x6000D17")]
			[Address(RVA = "0x2D4D4B4", Offset = "0x2D4D4B4", VA = "0x2D4D4B4")]
			protected Offset()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20001C5")]
		public class PositionOffset : Offset
		{
			[Serializable]
			[Token(Token = "0x20001E5")]
			public class PositionOffsetLink
			{
				[Token(Token = "0x4000BDC")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D7530", Offset = "0x14D7530")]
				public IKSolverVR.PositionOffset positionOffset;

				[Token(Token = "0x4000BDD")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D7568", Offset = "0x14D7568")]
				public float weight;

				[Token(Token = "0x4000BDE")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				private Vector3 lastValue;

				[Token(Token = "0x4000BDF")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
				private Vector3 current;

				[Token(Token = "0x6000D64")]
				[Address(RVA = "0x2D4D970", Offset = "0x2D4D970", VA = "0x2D4D970")]
				public void Apply(VRIK ik, Vector3 offset, float crossFader)
				{
				}

				[Token(Token = "0x6000D65")]
				[Address(RVA = "0x2D4D72C", Offset = "0x2D4D72C", VA = "0x2D4D72C")]
				public void CrossFadeStart()
				{
				}

				[Token(Token = "0x6000D66")]
				[Address(RVA = "0x2D4DA8C", Offset = "0x2D4DA8C", VA = "0x2D4DA8C")]
				public PositionOffsetLink()
				{
				}
			}

			[Token(Token = "0x4000B40")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D684C", Offset = "0x14D684C")]
			public int forceDirCurveIndex;

			[Token(Token = "0x4000B41")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D6884", Offset = "0x14D6884")]
			public int upDirCurveIndex;

			[Token(Token = "0x4000B42")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D68BC", Offset = "0x14D68BC")]
			public PositionOffsetLink[] offsetLinks;

			[Token(Token = "0x6000D18")]
			[Address(RVA = "0x2D4D4C8", Offset = "0x2D4D4C8", VA = "0x2D4D4C8", Slot = "4")]
			protected override float GetLength(AnimationCurve[] curves)
			{
				return default(float);
			}

			[Token(Token = "0x6000D19")]
			[Address(RVA = "0x2D4D6C0", Offset = "0x2D4D6C0", VA = "0x2D4D6C0", Slot = "5")]
			protected override void CrossFadeStart()
			{
			}

			[Token(Token = "0x6000D1A")]
			[Address(RVA = "0x2D4D740", Offset = "0x2D4D740", VA = "0x2D4D740", Slot = "6")]
			protected override void OnApply(VRIK ik, AnimationCurve[] curves, float weight)
			{
			}

			[Token(Token = "0x6000D1B")]
			[Address(RVA = "0x2D4DA70", Offset = "0x2D4DA70", VA = "0x2D4DA70")]
			public PositionOffset()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20001C6")]
		public class RotationOffset : Offset
		{
			[Serializable]
			[Token(Token = "0x20001E6")]
			public class RotationOffsetLink
			{
				[Token(Token = "0x4000BE0")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D75A0", Offset = "0x14D75A0")]
				public IKSolverVR.RotationOffset rotationOffset;

				[Token(Token = "0x4000BE1")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D75D8", Offset = "0x14D75D8")]
				[AttributeAttribute(Name = "RangeAttribute", RVA = "0x14D75D8", Offset = "0x14D75D8")]
				public float weight;

				[Token(Token = "0x4000BE2")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				private Quaternion lastValue;

				[Token(Token = "0x4000BE3")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
				private Quaternion current;

				[Token(Token = "0x6000D67")]
				[Address(RVA = "0x2D4DEF4", Offset = "0x2D4DEF4", VA = "0x2D4DEF4")]
				public void Apply(VRIK ik, Quaternion offset, float crossFader)
				{
				}

				[Token(Token = "0x6000D68")]
				[Address(RVA = "0x2D4DBDC", Offset = "0x2D4DBDC", VA = "0x2D4DBDC")]
				public void CrossFadeStart()
				{
				}

				[Token(Token = "0x6000D69")]
				[Address(RVA = "0x2D4E030", Offset = "0x2D4E030", VA = "0x2D4E030")]
				public RotationOffsetLink()
				{
				}
			}

			[Token(Token = "0x4000B43")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D68F4", Offset = "0x14D68F4")]
			public int curveIndex;

			[Token(Token = "0x4000B44")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D692C", Offset = "0x14D692C")]
			public RotationOffsetLink[] offsetLinks;

			[Token(Token = "0x4000B45")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private Rigidbody rigidbody;

			[Token(Token = "0x6000D1C")]
			[Address(RVA = "0x2D4DA94", Offset = "0x2D4DA94", VA = "0x2D4DA94", Slot = "4")]
			protected override float GetLength(AnimationCurve[] curves)
			{
				return default(float);
			}

			[Token(Token = "0x6000D1D")]
			[Address(RVA = "0x2D4DB78", Offset = "0x2D4DB78", VA = "0x2D4DB78", Slot = "5")]
			protected override void CrossFadeStart()
			{
			}

			[Token(Token = "0x6000D1E")]
			[Address(RVA = "0x2D4DBE8", Offset = "0x2D4DBE8", VA = "0x2D4DBE8", Slot = "6")]
			protected override void OnApply(VRIK ik, AnimationCurve[] curves, float weight)
			{
			}

			[Token(Token = "0x6000D1F")]
			[Address(RVA = "0x2D4E01C", Offset = "0x2D4E01C", VA = "0x2D4E01C")]
			public RotationOffset()
			{
			}
		}

		[Token(Token = "0x40003E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public AnimationCurve[] offsetCurves;

		[Token(Token = "0x40003E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D39B0", Offset = "0x14D39B0")]
		public PositionOffset[] positionOffsets;

		[Token(Token = "0x40003E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D39E8", Offset = "0x14D39E8")]
		public RotationOffset[] rotationOffsets;

		[Token(Token = "0x60004D1")]
		[Address(RVA = "0x2D4CEB4", Offset = "0x2D4CEB4", VA = "0x2D4CEB4", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x60004D2")]
		[Address(RVA = "0x2D4D0D4", Offset = "0x2D4D0D4", VA = "0x2D4D0D4")]
		public void Hit(Collider collider, Vector3 force, Vector3 point)
		{
		}

		[Token(Token = "0x60004D3")]
		[Address(RVA = "0x2D4D45C", Offset = "0x2D4D45C", VA = "0x2D4D45C")]
		public HitReactionVRIK()
		{
		}
	}
	[Token(Token = "0x200007B")]
	public class Inertia : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x20001C7")]
		public class Body
		{
			[Serializable]
			[Token(Token = "0x20001E7")]
			public class EffectorLink
			{
				[Token(Token = "0x4000BE4")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D762C", Offset = "0x14D762C")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x4000BE5")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D7664", Offset = "0x14D7664")]
				public float weight;

				[Token(Token = "0x6000D6A")]
				[Address(RVA = "0x2FE4F70", Offset = "0x2FE4F70", VA = "0x2FE4F70")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x4000B46")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D6964", Offset = "0x14D6964")]
			public Transform transform;

			[Token(Token = "0x4000B47")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D699C", Offset = "0x14D699C")]
			public EffectorLink[] effectorLinks;

			[Token(Token = "0x4000B48")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D69D4", Offset = "0x14D69D4")]
			public float speed;

			[Token(Token = "0x4000B49")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D6A0C", Offset = "0x14D6A0C")]
			public float acceleration;

			[Token(Token = "0x4000B4A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D6A44", Offset = "0x14D6A44")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x14D6A44", Offset = "0x14D6A44")]
			public float matchVelocity;

			[Token(Token = "0x4000B4B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D6A98", Offset = "0x14D6A98")]
			public float gravity;

			[Token(Token = "0x4000B4C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private Vector3 delta;

			[Token(Token = "0x4000B4D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private Vector3 lazyPoint;

			[Token(Token = "0x4000B4E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private Vector3 direction;

			[Token(Token = "0x4000B4F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			private Vector3 lastPosition;

			[Token(Token = "0x4000B50")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private bool firstUpdate;

			[Token(Token = "0x6000D20")]
			[Address(RVA = "0x2FE4A3C", Offset = "0x2FE4A3C", VA = "0x2FE4A3C")]
			public void Reset()
			{
			}

			[Token(Token = "0x6000D21")]
			[Address(RVA = "0x2FE4BD4", Offset = "0x2FE4BD4", VA = "0x2FE4BD4")]
			public void Update(IKSolverFullBodyBiped solver, float weight, float deltaTime)
			{
			}

			[Token(Token = "0x6000D22")]
			[Address(RVA = "0x2FE4F54", Offset = "0x2FE4F54", VA = "0x2FE4F54")]
			public Body()
			{
			}
		}

		[Token(Token = "0x40003E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D3A20", Offset = "0x14D3A20")]
		public Body[] bodies;

		[Token(Token = "0x40003E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D3A58", Offset = "0x14D3A58")]
		public OffsetLimits[] limits;

		[Token(Token = "0x60004D4")]
		[Address(RVA = "0x2FE49C4", Offset = "0x2FE49C4", VA = "0x2FE49C4")]
		public void ResetBodies()
		{
		}

		[Token(Token = "0x60004D5")]
		[Address(RVA = "0x2FE4B18", Offset = "0x2FE4B18", VA = "0x2FE4B18", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x60004D6")]
		[Address(RVA = "0x2FE4F4C", Offset = "0x2FE4F4C", VA = "0x2FE4F4C")]
		public Inertia()
		{
		}
	}
	[Token(Token = "0x200007C")]
	public class LookAtController : MonoBehaviour
	{
		[Token(Token = "0x40003E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public LookAtIK ik;

		[Token(Token = "0x40003E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x14D3A90", Offset = "0x14D3A90")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D3A90", Offset = "0x14D3A90")]
		public Transform target;

		[Token(Token = "0x40003E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x14D3AF0", Offset = "0x14D3AF0")]
		public float weight;

		[Token(Token = "0x40003EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public Vector3 offset;

		[Token(Token = "0x40003EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D3B08", Offset = "0x14D3B08")]
		public float targetSwitchSmoothTime;

		[Token(Token = "0x40003EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D3B40", Offset = "0x14D3B40")]
		public float weightSmoothTime;

		[Token(Token = "0x40003ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x14D3B78", Offset = "0x14D3B78")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D3B78", Offset = "0x14D3B78")]
		public bool smoothTurnTowardsTarget;

		[Token(Token = "0x40003EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D3BD8", Offset = "0x14D3BD8")]
		public float maxRadiansDelta;

		[Token(Token = "0x40003EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D3C10", Offset = "0x14D3C10")]
		public float maxMagnitudeDelta;

		[Token(Token = "0x40003F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D3C48", Offset = "0x14D3C48")]
		public float slerpSpeed;

		[Token(Token = "0x40003F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D3C80", Offset = "0x14D3C80")]
		public Vector3 pivotOffsetFromRoot;

		[Token(Token = "0x40003F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D3CB8", Offset = "0x14D3CB8")]
		public float minDistance;

		[Token(Token = "0x40003F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x14D3CF0", Offset = "0x14D3CF0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D3CF0", Offset = "0x14D3CF0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x14D3CF0", Offset = "0x14D3CF0")]
		public float maxRootAngle;

		[Token(Token = "0x40003F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Transform lastTarget;

		[Token(Token = "0x40003F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private float switchWeight;

		[Token(Token = "0x40003F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private float switchWeightV;

		[Token(Token = "0x40003F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private float weightV;

		[Token(Token = "0x40003F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private Vector3 lastPosition;

		[Token(Token = "0x40003F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Vector3 dir;

		[Token(Token = "0x40003FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private bool lastSmoothTowardsTarget;

		[Token(Token = "0x17000064")]
		private Vector3 pivot
		{
			[Token(Token = "0x60004D9")]
			[Address(RVA = "0x2987ED8", Offset = "0x2987ED8", VA = "0x2987ED8")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x60004D7")]
		[Address(RVA = "0x2987DF0", Offset = "0x2987DF0", VA = "0x2987DF0")]
		private void Start()
		{
		}

		[Token(Token = "0x60004D8")]
		[Address(RVA = "0x2988024", Offset = "0x2988024", VA = "0x2988024")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60004DA")]
		[Address(RVA = "0x29886D8", Offset = "0x29886D8", VA = "0x29886D8")]
		private void ApplyMinDistance()
		{
		}

		[Token(Token = "0x60004DB")]
		[Address(RVA = "0x2988874", Offset = "0x2988874", VA = "0x2988874")]
		private void RootRotation()
		{
		}

		[Token(Token = "0x60004DC")]
		[Address(RVA = "0x2988B90", Offset = "0x2988B90", VA = "0x2988B90")]
		public LookAtController()
		{
		}
	}
	[Token(Token = "0x200007D")]
	public abstract class OffsetModifier : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20001C8")]
		public class OffsetLimits
		{
			[Token(Token = "0x4000B51")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D6AD0", Offset = "0x14D6AD0")]
			public FullBodyBipedEffector effector;

			[Token(Token = "0x4000B52")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D6B08", Offset = "0x14D6B08")]
			public float spring;

			[Token(Token = "0x4000B53")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D6B40", Offset = "0x14D6B40")]
			public bool x;

			[Token(Token = "0x4000B54")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D6B78", Offset = "0x14D6B78")]
			public bool y;

			[Token(Token = "0x4000B55")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D6BB0", Offset = "0x14D6BB0")]
			public bool z;

			[Token(Token = "0x4000B56")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D6BE8", Offset = "0x14D6BE8")]
			public float minX;

			[Token(Token = "0x4000B57")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D6C20", Offset = "0x14D6C20")]
			public float maxX;

			[Token(Token = "0x4000B58")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D6C58", Offset = "0x14D6C58")]
			public float minY;

			[Token(Token = "0x4000B59")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D6C90", Offset = "0x14D6C90")]
			public float maxY;

			[Token(Token = "0x4000B5A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D6CC8", Offset = "0x14D6CC8")]
			public float minZ;

			[Token(Token = "0x4000B5B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D6D00", Offset = "0x14D6D00")]
			public float maxZ;

			[Token(Token = "0x6000D23")]
			[Address(RVA = "0x29890A0", Offset = "0x29890A0", VA = "0x29890A0")]
			public void Apply(IKEffector e, Quaternion rootRotation)
			{
			}

			[Token(Token = "0x6000D24")]
			[Address(RVA = "0x29895B8", Offset = "0x29895B8", VA = "0x29895B8")]
			private float SpringAxis(float value, float min, float max)
			{
				return default(float);
			}

			[Token(Token = "0x6000D25")]
			[Address(RVA = "0x29895E8", Offset = "0x29895E8", VA = "0x29895E8")]
			private float Spring(float value, float limit, bool negative)
			{
				return default(float);
			}

			[Token(Token = "0x6000D26")]
			[Address(RVA = "0x29896C0", Offset = "0x29896C0", VA = "0x29896C0")]
			public OffsetLimits()
			{
			}
		}

		[Token(Token = "0x20001C9")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x14CFF08", Offset = "0x14CFF08")]
		private sealed class <Initiate>d__8 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000B5C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000B5D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000B5E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public OffsetModifier <>4__this;

			[Token(Token = "0x170000C5")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000D2A")]
				[Address(RVA = "0x2989548", Offset = "0x2989548", VA = "0x2989548", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000C6")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000D2C")]
				[Address(RVA = "0x29895B0", Offset = "0x29895B0", VA = "0x29895B0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000D27")]
			[Address(RVA = "0x2988EAC", Offset = "0x2988EAC", VA = "0x2988EAC")]
			[DebuggerHidden]
			public <Initiate>d__8(int <>1__state)
			{
			}

			[Token(Token = "0x6000D28")]
			[Address(RVA = "0x2989408", Offset = "0x2989408", VA = "0x2989408", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000D29")]
			[Address(RVA = "0x298940C", Offset = "0x298940C", VA = "0x298940C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000D2B")]
			[Address(RVA = "0x2989550", Offset = "0x2989550", VA = "0x2989550", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40003FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D3D6C", Offset = "0x14D3D6C")]
		public float weight;

		[Token(Token = "0x40003FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D3DA4", Offset = "0x14D3DA4")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x40003FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		protected float lastTime;

		[Token(Token = "0x17000065")]
		protected float deltaTime
		{
			[Token(Token = "0x60004DD")]
			[Address(RVA = "0x2988DE4", Offset = "0x2988DE4", VA = "0x2988DE4")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x60004DE")]
		protected abstract void OnModifyOffset();

		[Token(Token = "0x60004DF")]
		[Address(RVA = "0x2988E10", Offset = "0x2988E10", VA = "0x2988E10", Slot = "5")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x60004E0")]
		[Address(RVA = "0x2988E3C", Offset = "0x2988E3C", VA = "0x2988E3C")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x14D95EC", Offset = "0x14D95EC")]
		private IEnumerator Initiate()
		{
			return null;
		}

		[Token(Token = "0x60004E1")]
		[Address(RVA = "0x2988ED8", Offset = "0x2988ED8", VA = "0x2988ED8")]
		private void ModifyOffset()
		{
		}

		[Token(Token = "0x60004E2")]
		[Address(RVA = "0x2988FE4", Offset = "0x2988FE4", VA = "0x2988FE4")]
		protected void ApplyLimits(OffsetLimits[] limits)
		{
		}

		[Token(Token = "0x60004E3")]
		[Address(RVA = "0x2989300", Offset = "0x2989300", VA = "0x2989300", Slot = "6")]
		protected virtual void OnDestroy()
		{
		}

		[Token(Token = "0x60004E4")]
		[Address(RVA = "0x29893F8", Offset = "0x29893F8", VA = "0x29893F8")]
		protected OffsetModifier()
		{
		}
	}
	[Token(Token = "0x200007E")]
	public abstract class OffsetModifierVRIK : MonoBehaviour
	{
		[Token(Token = "0x20001CA")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x14CFF18", Offset = "0x14CFF18")]
		private sealed class <Initiate>d__7 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000B5F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000B60")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000B61")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public OffsetModifierVRIK <>4__this;

			[Token(Token = "0x170000C7")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000D30")]
				[Address(RVA = "0x2989B10", Offset = "0x2989B10", VA = "0x2989B10", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000C8")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000D32")]
				[Address(RVA = "0x2989B78", Offset = "0x2989B78", VA = "0x2989B78", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000D2D")]
			[Address(RVA = "0x2989790", Offset = "0x2989790", VA = "0x2989790")]
			[DebuggerHidden]
			public <Initiate>d__7(int <>1__state)
			{
			}

			[Token(Token = "0x6000D2E")]
			[Address(RVA = "0x29899D0", Offset = "0x29899D0", VA = "0x29899D0", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000D2F")]
			[Address(RVA = "0x29899D4", Offset = "0x29899D4", VA = "0x29899D4", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000D31")]
			[Address(RVA = "0x2989B18", Offset = "0x2989B18", VA = "0x2989B18", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40003FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D3DDC", Offset = "0x14D3DDC")]
		public float weight;

		[Token(Token = "0x40003FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D3E14", Offset = "0x14D3E14")]
		public VRIK ik;

		[Token(Token = "0x4000400")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float lastTime;

		[Token(Token = "0x17000066")]
		protected float deltaTime
		{
			[Token(Token = "0x60004E5")]
			[Address(RVA = "0x29896C8", Offset = "0x29896C8", VA = "0x29896C8")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x60004E6")]
		protected abstract void OnModifyOffset();

		[Token(Token = "0x60004E7")]
		[Address(RVA = "0x29896F4", Offset = "0x29896F4", VA = "0x29896F4", Slot = "5")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x60004E8")]
		[Address(RVA = "0x2989720", Offset = "0x2989720", VA = "0x2989720")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x14D9650", Offset = "0x14D9650")]
		private IEnumerator Initiate()
		{
			return null;
		}

		[Token(Token = "0x60004E9")]
		[Address(RVA = "0x29897BC", Offset = "0x29897BC", VA = "0x29897BC")]
		private void ModifyOffset()
		{
		}

		[Token(Token = "0x60004EA")]
		[Address(RVA = "0x29898C8", Offset = "0x29898C8", VA = "0x29898C8", Slot = "6")]
		protected virtual void OnDestroy()
		{
		}

		[Token(Token = "0x60004EB")]
		[Address(RVA = "0x29899C0", Offset = "0x29899C0", VA = "0x29899C0")]
		protected OffsetModifierVRIK()
		{
		}
	}
	[Token(Token = "0x200007F")]
	public class OffsetPose : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20001CB")]
		public class EffectorLink
		{
			[Token(Token = "0x4000B62")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public FullBodyBipedEffector effector;

			[Token(Token = "0x4000B63")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public Vector3 offset;

			[Token(Token = "0x4000B64")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Vector3 pin;

			[Token(Token = "0x4000B65")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public Vector3 pinWeight;

			[Token(Token = "0x6000D33")]
			[Address(RVA = "0x2989C40", Offset = "0x2989C40", VA = "0x2989C40")]
			public void Apply(IKSolverFullBodyBiped solver, float weight, Quaternion rotation)
			{
			}

			[Token(Token = "0x6000D34")]
			[Address(RVA = "0x298A090", Offset = "0x298A090", VA = "0x298A090")]
			public EffectorLink()
			{
			}
		}

		[Token(Token = "0x4000401")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public EffectorLink[] effectorLinks;

		[Token(Token = "0x60004EC")]
		[Address(RVA = "0x2989B80", Offset = "0x2989B80", VA = "0x2989B80")]
		public void Apply(IKSolverFullBodyBiped solver, float weight)
		{
		}

		[Token(Token = "0x60004ED")]
		[Address(RVA = "0x2989F78", Offset = "0x2989F78", VA = "0x2989F78")]
		public void Apply(IKSolverFullBodyBiped solver, float weight, Quaternion rotation)
		{
		}

		[Token(Token = "0x60004EE")]
		[Address(RVA = "0x298A030", Offset = "0x298A030", VA = "0x298A030")]
		public OffsetPose()
		{
		}
	}
	[Token(Token = "0x2000080")]
	public class PenetrationAvoidance : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x20001CC")]
		public class Avoider
		{
			[Serializable]
			[Token(Token = "0x20001E8")]
			public class EffectorLink
			{
				[Token(Token = "0x4000BE6")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D769C", Offset = "0x14D769C")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x4000BE7")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D76D4", Offset = "0x14D76D4")]
				public float weight;

				[Token(Token = "0x6000D6B")]
				[Address(RVA = "0x298A748", Offset = "0x298A748", VA = "0x298A748")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x4000B66")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D6D38", Offset = "0x14D6D38")]
			public Transform[] raycastFrom;

			[Token(Token = "0x4000B67")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D6D70", Offset = "0x14D6D70")]
			public Transform raycastTo;

			[Token(Token = "0x4000B68")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D6DA8", Offset = "0x14D6DA8")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x14D6DA8", Offset = "0x14D6DA8")]
			public float raycastRadius;

			[Token(Token = "0x4000B69")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D6DFC", Offset = "0x14D6DFC")]
			public EffectorLink[] effectors;

			[Token(Token = "0x4000B6A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D6E34", Offset = "0x14D6E34")]
			public float smoothTimeIn;

			[Token(Token = "0x4000B6B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D6E6C", Offset = "0x14D6E6C")]
			public float smoothTimeOut;

			[Token(Token = "0x4000B6C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D6EA4", Offset = "0x14D6EA4")]
			public LayerMask layers;

			[Token(Token = "0x4000B6D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private Vector3 offset;

			[Token(Token = "0x4000B6E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private Vector3 offsetTarget;

			[Token(Token = "0x4000B6F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			private Vector3 offsetV;

			[Token(Token = "0x6000D35")]
			[Address(RVA = "0x298A11C", Offset = "0x298A11C", VA = "0x298A11C")]
			public void Solve(IKSolverFullBodyBiped solver, float weight)
			{
			}

			[Token(Token = "0x6000D36")]
			[Address(RVA = "0x298A328", Offset = "0x298A328", VA = "0x298A328")]
			private Vector3 GetOffsetTarget(IKSolverFullBodyBiped solver)
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000D37")]
			[Address(RVA = "0x298A4C0", Offset = "0x298A4C0", VA = "0x298A4C0")]
			private Vector3 Raycast(Vector3 from, Vector3 to)
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000D38")]
			[Address(RVA = "0x298A734", Offset = "0x298A734", VA = "0x298A734")]
			public Avoider()
			{
			}
		}

		[Token(Token = "0x4000402")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D3E4C", Offset = "0x14D3E4C")]
		public Avoider[] avoiders;

		[Token(Token = "0x60004EF")]
		[Address(RVA = "0x298A098", Offset = "0x298A098", VA = "0x298A098", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x60004F0")]
		[Address(RVA = "0x298A318", Offset = "0x298A318", VA = "0x298A318")]
		public PenetrationAvoidance()
		{
		}
	}
	[Token(Token = "0x2000081")]
	public class Recoil : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x20001CD")]
		public class RecoilOffset
		{
			[Serializable]
			[Token(Token = "0x20001E9")]
			public class EffectorLink
			{
				[Token(Token = "0x4000BE8")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D770C", Offset = "0x14D770C")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x4000BE9")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D7744", Offset = "0x14D7744")]
				public float weight;

				[Token(Token = "0x6000D6C")]
				[Address(RVA = "0x298D7C8", Offset = "0x298D7C8", VA = "0x298D7C8")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x4000B70")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D6EDC", Offset = "0x14D6EDC")]
			public Vector3 offset;

			[Token(Token = "0x4000B71")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D6F14", Offset = "0x14D6F14")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x14D6F14", Offset = "0x14D6F14")]
			public float additivity;

			[Token(Token = "0x4000B72")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D6F68", Offset = "0x14D6F68")]
			public float maxAdditiveOffsetMag;

			[Token(Token = "0x4000B73")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D6FA0", Offset = "0x14D6FA0")]
			public EffectorLink[] effectorLinks;

			[Token(Token = "0x4000B74")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private Vector3 additiveOffset;

			[Token(Token = "0x4000B75")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private Vector3 lastOffset;

			[Token(Token = "0x6000D39")]
			[Address(RVA = "0x298C510", Offset = "0x298C510", VA = "0x298C510")]
			public void Start()
			{
			}

			[Token(Token = "0x6000D3A")]
			[Address(RVA = "0x298D0A0", Offset = "0x298D0A0", VA = "0x298D0A0")]
			public void Apply(IKSolverFullBodyBiped solver, Quaternion rotation, float masterWeight, float length, float timeLeft)
			{
			}

			[Token(Token = "0x6000D3B")]
			[Address(RVA = "0x298D7B4", Offset = "0x298D7B4", VA = "0x298D7B4")]
			public RecoilOffset()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20001CE")]
		public enum Handedness
		{
			[Token(Token = "0x4000B77")]
			Right,
			[Token(Token = "0x4000B78")]
			Left
		}

		[Token(Token = "0x4000403")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D3E84", Offset = "0x14D3E84")]
		public AimIK aimIK;

		[Token(Token = "0x4000404")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D3EBC", Offset = "0x14D3EBC")]
		public bool aimIKSolvedLast;

		[Token(Token = "0x4000405")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D3EF4", Offset = "0x14D3EF4")]
		public Handedness handedness;

		[Token(Token = "0x4000406")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D3F2C", Offset = "0x14D3F2C")]
		public bool twoHanded;

		[Token(Token = "0x4000407")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D3F64", Offset = "0x14D3F64")]
		public AnimationCurve recoilWeight;

		[Token(Token = "0x4000408")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D3F9C", Offset = "0x14D3F9C")]
		public float magnitudeRandom;

		[Token(Token = "0x4000409")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D3FD4", Offset = "0x14D3FD4")]
		public Vector3 rotationRandom;

		[Token(Token = "0x400040A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D400C", Offset = "0x14D400C")]
		public Vector3 handRotationOffset;

		[Token(Token = "0x400040B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D4044", Offset = "0x14D4044")]
		public float blendTime;

		[Token(Token = "0x400040C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x14D407C", Offset = "0x14D407C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D407C", Offset = "0x14D407C")]
		public RecoilOffset[] offsets;

		[Token(Token = "0x400040D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[HideInInspector]
		public Quaternion rotationOffset;

		[Token(Token = "0x400040E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private float magnitudeMlp;

		[Token(Token = "0x400040F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private float endTime;

		[Token(Token = "0x4000410")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Quaternion handRotation;

		[Token(Token = "0x4000411")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private Quaternion secondaryHandRelativeRotation;

		[Token(Token = "0x4000412")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Quaternion randomRotation;

		[Token(Token = "0x4000413")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private float length;

		[Token(Token = "0x4000414")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private bool initiated;

		[Token(Token = "0x4000415")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private float blendWeight;

		[Token(Token = "0x4000416")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		private float w;

		[Token(Token = "0x4000417")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private Quaternion primaryHandRotation;

		[Token(Token = "0x4000418")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private bool handRotationsSet;

		[Token(Token = "0x4000419")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		private Vector3 aimIKAxis;

		[Token(Token = "0x17000067")]
		public bool isFinished
		{
			[Token(Token = "0x60004F1")]
			[Address(RVA = "0x298C2E8", Offset = "0x298C2E8", VA = "0x298C2E8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000068")]
		private IKEffector primaryHandEffector
		{
			[Token(Token = "0x60004F7")]
			[Address(RVA = "0x298D354", Offset = "0x298D354", VA = "0x298D354")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000069")]
		private IKEffector secondaryHandEffector
		{
			[Token(Token = "0x60004F8")]
			[Address(RVA = "0x298D394", Offset = "0x298D394", VA = "0x298D394")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700006A")]
		private Transform primaryHand
		{
			[Token(Token = "0x60004F9")]
			[Address(RVA = "0x298D314", Offset = "0x298D314", VA = "0x298D314")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700006B")]
		private Transform secondaryHand
		{
			[Token(Token = "0x60004FA")]
			[Address(RVA = "0x298D334", Offset = "0x298D334", VA = "0x298D334")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60004F2")]
		[Address(RVA = "0x298C318", Offset = "0x298C318", VA = "0x298C318")]
		public void SetHandRotations(Quaternion leftHandRotation, Quaternion rightHandRotation)
		{
		}

		[Token(Token = "0x60004F3")]
		[Address(RVA = "0x298C344", Offset = "0x298C344", VA = "0x298C344")]
		public void Fire(float magnitude)
		{
		}

		[Token(Token = "0x60004F4")]
		[Address(RVA = "0x298C5C0", Offset = "0x298C5C0", VA = "0x298C5C0", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x60004F5")]
		[Address(RVA = "0x298D3D4", Offset = "0x298D3D4", VA = "0x298D3D4")]
		private void AfterFBBIK()
		{
		}

		[Token(Token = "0x60004F6")]
		[Address(RVA = "0x298D52C", Offset = "0x298D52C", VA = "0x298D52C")]
		private void AfterAimIK()
		{
		}

		[Token(Token = "0x60004FB")]
		[Address(RVA = "0x298D568", Offset = "0x298D568", VA = "0x298D568", Slot = "6")]
		protected override void OnDestroy()
		{
		}

		[Token(Token = "0x60004FC")]
		[Address(RVA = "0x298D700", Offset = "0x298D700", VA = "0x298D700")]
		public Recoil()
		{
		}
	}
	[Token(Token = "0x2000082")]
	public class ShoulderRotator : MonoBehaviour
	{
		[Token(Token = "0x400041A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D40DC", Offset = "0x14D40DC")]
		public float weight;

		[Token(Token = "0x400041B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D4114", Offset = "0x14D4114")]
		public float offset;

		[Token(Token = "0x400041C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private FullBodyBipedIK ik;

		[Token(Token = "0x400041D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool skip;

		[Token(Token = "0x60004FD")]
		[Address(RVA = "0x29918CC", Offset = "0x29918CC", VA = "0x29918CC")]
		private void Start()
		{
		}

		[Token(Token = "0x60004FE")]
		[Address(RVA = "0x29919A0", Offset = "0x29919A0", VA = "0x29919A0")]
		private void RotateShoulders()
		{
		}

		[Token(Token = "0x60004FF")]
		[Address(RVA = "0x2991A8C", Offset = "0x2991A8C", VA = "0x2991A8C")]
		private void RotateShoulder(FullBodyBipedChain chain, float weight, float offset)
		{
		}

		[Token(Token = "0x6000500")]
		[Address(RVA = "0x2991ED4", Offset = "0x2991ED4", VA = "0x2991ED4")]
		private IKMapping.BoneMap GetParentBoneMap(FullBodyBipedChain chain)
		{
			return null;
		}

		[Token(Token = "0x6000501")]
		[Address(RVA = "0x2991F0C", Offset = "0x2991F0C", VA = "0x2991F0C")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000502")]
		[Address(RVA = "0x2992004", Offset = "0x2992004", VA = "0x2992004")]
		public ShoulderRotator()
		{
		}
	}
	[Token(Token = "0x2000083")]
	public static class VRIKCalibrator
	{
		[Serializable]
		[Token(Token = "0x20001CF")]
		public class Settings
		{
			[Token(Token = "0x4000B79")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D6FD8", Offset = "0x14D6FD8")]
			public float scaleMlp;

			[Token(Token = "0x4000B7A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D7010", Offset = "0x14D7010")]
			public Vector3 headTrackerForward;

			[Token(Token = "0x4000B7B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D7048", Offset = "0x14D7048")]
			public Vector3 headTrackerUp;

			[Token(Token = "0x4000B7C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D7080", Offset = "0x14D7080")]
			public Vector3 bodyTrackerForward;

			[Token(Token = "0x4000B7D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D70B8", Offset = "0x14D70B8")]
			public Vector3 bodyTrackerUp;

			[Token(Token = "0x4000B7E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D70F0", Offset = "0x14D70F0")]
			public Vector3 handTrackerForward;

			[Token(Token = "0x4000B7F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D7128", Offset = "0x14D7128")]
			public Vector3 handTrackerUp;

			[Token(Token = "0x4000B80")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D7160", Offset = "0x14D7160")]
			public Vector3 footTrackerForward;

			[Token(Token = "0x4000B81")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D7198", Offset = "0x14D7198")]
			public Vector3 footTrackerUp;

			[Token(Token = "0x4000B82")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
			[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x14D71D0", Offset = "0x14D71D0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D71D0", Offset = "0x14D71D0")]
			public Vector3 headOffset;

			[Token(Token = "0x4000B83")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D7220", Offset = "0x14D7220")]
			public Vector3 handOffset;

			[Token(Token = "0x4000B84")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D7258", Offset = "0x14D7258")]
			public float footForwardOffset;

			[Token(Token = "0x4000B85")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D7290", Offset = "0x14D7290")]
			public float footInwardOffset;

			[Token(Token = "0x4000B86")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14D72C8", Offset = "0x14D72C8")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x14D72C8", Offset = "0x14D72C8")]
			public float footHeadingOffset;

			[Token(Token = "0x4000B87")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x14D7324", Offset = "0x14D7324")]
			public float pelvisPositionWeight;

			[Token(Token = "0x4000B88")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x14D733C", Offset = "0x14D733C")]
			public float pelvisRotationWeight;

			[Token(Token = "0x6000D3C")]
			[Address(RVA = "0x2997010", Offset = "0x2997010", VA = "0x2997010")]
			public Settings()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20001D0")]
		public class CalibrationData
		{
			[Serializable]
			[Token(Token = "0x20001EA")]
			public class Target
			{
				[Token(Token = "0x4000BEA")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				public bool used;

				[Token(Token = "0x4000BEB")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				public Vector3 localPosition;

				[Token(Token = "0x4000BEC")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
				public Quaternion localRotation;

				[Token(Token = "0x6000D6D")]
				[Address(RVA = "0x29960BC", Offset = "0x29960BC", VA = "0x29960BC")]
				public Target(Transform t)
				{
				}

				[Token(Token = "0x6000D6E")]
				[Address(RVA = "0x2996C10", Offset = "0x2996C10", VA = "0x2996C10")]
				public void SetTo(Transform t)
				{
				}
			}

			[Token(Token = "0x4000B89")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float scale;

			[Token(Token = "0x4000B8A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Target head;

			[Token(Token = "0x4000B8B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Target leftHand;

			[Token(Token = "0x4000B8C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Target rightHand;

			[Token(Token = "0x4000B8D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Target pelvis;

			[Token(Token = "0x4000B8E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Target leftFoot;

			[Token(Token = "0x4000B8F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public Target rightFoot;

			[Token(Token = "0x4000B90")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public Target leftLegGoal;

			[Token(Token = "0x4000B91")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public Target rightLegGoal;

			[Token(Token = "0x4000B92")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public Vector3 pelvisTargetRight;

			[Token(Token = "0x4000B93")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			public float pelvisPositionWeight;

			[Token(Token = "0x4000B94")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			public float pelvisRotationWeight;

			[Token(Token = "0x6000D3D")]
			[Address(RVA = "0x2995560", Offset = "0x2995560", VA = "0x2995560")]
			public CalibrationData()
			{
			}
		}

		[Token(Token = "0x6000503")]
		[Address(RVA = "0x2994120", Offset = "0x2994120", VA = "0x2994120")]
		public static void RecalibrateScale(VRIK ik, Settings settings)
		{
		}

		[Token(Token = "0x6000504")]
		[Address(RVA = "0x2994288", Offset = "0x2994288", VA = "0x2994288")]
		public static CalibrationData Calibrate(VRIK ik, Settings settings, Transform headTracker, [Optional] Transform bodyTracker, [Optional] Transform leftHandTracker, [Optional] Transform rightHandTracker, [Optional] Transform leftFootTracker, [Optional] Transform rightFootTracker)
		{
			return null;
		}

		[Token(Token = "0x6000505")]
		[Address(RVA = "0x29956D8", Offset = "0x29956D8", VA = "0x29956D8")]
		private static void CalibrateLeg(Settings settings, Transform tracker, IKSolverVR.Leg leg, Transform lastBone, Vector3 rootForward, bool isLeft)
		{
		}

		[Token(Token = "0x6000506")]
		[Address(RVA = "0x2996180", Offset = "0x2996180", VA = "0x2996180")]
		public static void Calibrate(VRIK ik, CalibrationData data, Transform headTracker, [Optional] Transform bodyTracker, [Optional] Transform leftHandTracker, [Optional] Transform rightHandTracker, [Optional] Transform leftFootTracker, [Optional] Transform rightFootTracker)
		{
		}

		[Token(Token = "0x6000507")]
		[Address(RVA = "0x2996C70", Offset = "0x2996C70", VA = "0x2996C70")]
		private static void CalibrateLeg(CalibrationData data, Transform tracker, IKSolverVR.Leg leg, Transform lastBone, Vector3 rootForward, bool isLeft)
		{
		}
	}
	[Token(Token = "0x2000084")]
	public class VRIKLODController : MonoBehaviour
	{
		[Token(Token = "0x400041E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Renderer LODRenderer;

		[Token(Token = "0x400041F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float LODDistance;

		[Token(Token = "0x4000420")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public bool allowCulled;

		[Token(Token = "0x4000421")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private VRIK ik;

		[Token(Token = "0x6000508")]
		[Address(RVA = "0x2997108", Offset = "0x2997108", VA = "0x2997108")]
		private void Start()
		{
		}

		[Token(Token = "0x6000509")]
		[Address(RVA = "0x2997160", Offset = "0x2997160", VA = "0x2997160")]
		private void Update()
		{
		}

		[Token(Token = "0x600050A")]
		[Address(RVA = "0x2997194", Offset = "0x2997194", VA = "0x2997194")]
		private int GetLODLevel()
		{
			return default(int);
		}

		[Token(Token = "0x600050B")]
		[Address(RVA = "0x299731C", Offset = "0x299731C", VA = "0x299731C")]
		public VRIKLODController()
		{
		}
	}
	[Token(Token = "0x2000085")]
	public class VRIKRootController : MonoBehaviour
	{
		[Token(Token = "0x4000422")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x14D414C", Offset = "0x14D414C")]
		private Vector3 <pelvisTargetRight>k__BackingField;

		[Token(Token = "0x4000423")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Transform pelvisTarget;

		[Token(Token = "0x4000424")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Transform leftFootTarget;

		[Token(Token = "0x4000425")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Transform rightFootTarget;

		[Token(Token = "0x4000426")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private VRIK ik;

		[Token(Token = "0x1700006C")]
		public Vector3 pelvisTargetRight
		{
			[Token(Token = "0x600050C")]
			[Address(RVA = "0x2997334", Offset = "0x2997334", VA = "0x2997334")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x14D96B4", Offset = "0x14D96B4")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x600050D")]
			[Address(RVA = "0x2997340", Offset = "0x2997340", VA = "0x2997340")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x14D96C4", Offset = "0x14D96C4")]
			private set
			{
			}
		}

		[Token(Token = "0x600050E")]
		[Address(RVA = "0x299734C", Offset = "0x299734C", VA = "0x299734C")]
		private void Awake()
		{
		}

		[Token(Token = "0x600050F")]
		[Address(RVA = "0x2995E98", Offset = "0x2995E98", VA = "0x2995E98")]
		public void Calibrate()
		{
		}

		[Token(Token = "0x6000510")]
		[Address(RVA = "0x2996EA0", Offset = "0x2996EA0", VA = "0x2996EA0")]
		public void Calibrate(VRIKCalibrator.CalibrationData data)
		{
		}

		[Token(Token = "0x6000511")]
		[Address(RVA = "0x2997424", Offset = "0x2997424", VA = "0x2997424")]
		private void OnPreUpdate()
		{
		}

		[Token(Token = "0x6000512")]
		[Address(RVA = "0x29978C8", Offset = "0x29978C8", VA = "0x29978C8")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000513")]
		[Address(RVA = "0x29979C0", Offset = "0x29979C0", VA = "0x29979C0")]
		public VRIKRootController()
		{
		}
	}
}
namespace FMOD
{
	[Token(Token = "0x2000086")]
	public class VERSION
	{
		[Token(Token = "0x4000427")]
		public const int number = 131088;

		[Token(Token = "0x4000428")]
		public const string dll = "fmod";

		[Token(Token = "0x6000514")]
		[Address(RVA = "0x23F3EC8", Offset = "0x23F3EC8", VA = "0x23F3EC8")]
		public VERSION()
		{
		}
	}
	[Token(Token = "0x2000087")]
	public class CONSTANTS
	{
		[Token(Token = "0x4000429")]
		public const int MAX_CHANNEL_WIDTH = 32;

		[Token(Token = "0x400042A")]
		public const int MAX_LISTENERS = 8;

		[Token(Token = "0x400042B")]
		public const int REVERB_MAXINSTANCES = 4;

		[Token(Token = "0x400042C")]
		public const int MAX_SYSTEMS = 8;

		[Token(Token = "0x6000515")]
		[Address(RVA = "0x3297448", Offset = "0x3297448", VA = "0x3297448")]
		public CONSTANTS()
		{
		}
	}
	[Token(Token = "0x2000088")]
	public enum RESULT
	{
		[Token(Token = "0x400042E")]
		OK,
		[Token(Token = "0x400042F")]
		ERR_BADCOMMAND,
		[Token(Token = "0x4000430")]
		ERR_CHANNEL_ALLOC,
		[Token(Token = "0x4000431")]
		ERR_CHANNEL_STOLEN,
		[Token(Token = "0x4000432")]
		ERR_DMA,
		[Token(Token = "0x4000433")]
		ERR_DSP_CONNECTION,
		[Token(Token = "0x4000434")]
		ERR_DSP_DONTPROCESS,
		[Token(Token = "0x4000435")]
		ERR_DSP_FORMAT,
		[Token(Token = "0x4000436")]
		ERR_DSP_INUSE,
		[Token(Token = "0x4000437")]
		ERR_DSP_NOTFOUND,
		[Token(Token = "0x4000438")]
		ERR_DSP_RESERVED,
		[Token(Token = "0x4000439")]
		ERR_DSP_SILENCE,
		[Token(Token = "0x400043A")]
		ERR_DSP_TYPE,
		[Token(Token = "0x400043B")]
		ERR_FILE_BAD,
		[Token(Token = "0x400043C")]
		ERR_FILE_COULDNOTSEEK,
		[Token(Token = "0x400043D")]
		ERR_FILE_DISKEJECTED,
		[Token(Token = "0x400043E")]
		ERR_FILE_EOF,
		[Token(Token = "0x400043F")]
		ERR_FILE_ENDOFDATA,
		[Token(Token = "0x4000440")]
		ERR_FILE_NOTFOUND,
		[Token(Token = "0x4000441")]
		ERR_FORMAT,
		[Token(Token = "0x4000442")]
		ERR_HEADER_MISMATCH,
		[Token(Token = "0x4000443")]
		ERR_HTTP,
		[Token(Token = "0x4000444")]
		ERR_HTTP_ACCESS,
		[Token(Token = "0x4000445")]
		ERR_HTTP_PROXY_AUTH,
		[Token(Token = "0x4000446")]
		ERR_HTTP_SERVER_ERROR,
		[Token(Token = "0x4000447")]
		ERR_HTTP_TIMEOUT,
		[Token(Token = "0x4000448")]
		ERR_INITIALIZATION,
		[Token(Token = "0x4000449")]
		ERR_INITIALIZED,
		[Token(Token = "0x400044A")]
		ERR_INTERNAL,
		[Token(Token = "0x400044B")]
		ERR_INVALID_FLOAT,
		[Token(Token = "0x400044C")]
		ERR_INVALID_HANDLE,
		[Token(Token = "0x400044D")]
		ERR_INVALID_PARAM,
		[Token(Token = "0x400044E")]
		ERR_INVALID_POSITION,
		[Token(Token = "0x400044F")]
		ERR_INVALID_SPEAKER,
		[Token(Token = "0x4000450")]
		ERR_INVALID_SYNCPOINT,
		[Token(Token = "0x4000451")]
		ERR_INVALID_THREAD,
		[Token(Token = "0x4000452")]
		ERR_INVALID_VECTOR,
		[Token(Token = "0x4000453")]
		ERR_MAXAUDIBLE,
		[Token(Token = "0x4000454")]
		ERR_MEMORY,
		[Token(Token = "0x4000455")]
		ERR_MEMORY_CANTPOINT,
		[Token(Token = "0x4000456")]
		ERR_NEEDS3D,
		[Token(Token = "0x4000457")]
		ERR_NEEDSHARDWARE,
		[Token(Token = "0x4000458")]
		ERR_NET_CONNECT,
		[Token(Token = "0x4000459")]
		ERR_NET_SOCKET_ERROR,
		[Token(Token = "0x400045A")]
		ERR_NET_URL,
		[Token(Token = "0x400045B")]
		ERR_NET_WOULD_BLOCK,
		[Token(Token = "0x400045C")]
		ERR_NOTREADY,
		[Token(Token = "0x400045D")]
		ERR_OUTPUT_ALLOCATED,
		[Token(Token = "0x400045E")]
		ERR_OUTPUT_CREATEBUFFER,
		[Token(Token = "0x400045F")]
		ERR_OUTPUT_DRIVERCALL,
		[Token(Token = "0x4000460")]
		ERR_OUTPUT_FORMAT,
		[Token(Token = "0x4000461")]
		ERR_OUTPUT_INIT,
		[Token(Token = "0x4000462")]
		ERR_OUTPUT_NODRIVERS,
		[Token(Token = "0x4000463")]
		ERR_PLUGIN,
		[Token(Token = "0x4000464")]
		ERR_PLUGIN_MISSING,
		[Token(Token = "0x4000465")]
		ERR_PLUGIN_RESOURCE,
		[Token(Token = "0x4000466")]
		ERR_PLUGIN_VERSION,
		[Token(Token = "0x4000467")]
		ERR_RECORD,
		[Token(Token = "0x4000468")]
		ERR_REVERB_CHANNELGROUP,
		[Token(Token = "0x4000469")]
		ERR_REVERB_INSTANCE,
		[Token(Token = "0x400046A")]
		ERR_SUBSOUNDS,
		[Token(Token = "0x400046B")]
		ERR_SUBSOUND_ALLOCATED,
		[Token(Token = "0x400046C")]
		ERR_SUBSOUND_CANTMOVE,
		[Token(Token = "0x400046D")]
		ERR_TAGNOTFOUND,
		[Token(Token = "0x400046E")]
		ERR_TOOMANYCHANNELS,
		[Token(Token = "0x400046F")]
		ERR_TRUNCATED,
		[Token(Token = "0x4000470")]
		ERR_UNIMPLEMENTED,
		[Token(Token = "0x4000471")]
		ERR_UNINITIALIZED,
		[Token(Token = "0x4000472")]
		ERR_UNSUPPORTED,
		[Token(Token = "0x4000473")]
		ERR_VERSION,
		[Token(Token = "0x4000474")]
		ERR_EVENT_ALREADY_LOADED,
		[Token(Token = "0x4000475")]
		ERR_EVENT_LIVEUPDATE_BUSY,
		[Token(Token = "0x4000476")]
		ERR_EVENT_LIVEUPDATE_MISMATCH,
		[Token(Token = "0x4000477")]
		ERR_EVENT_LIVEUPDATE_TIMEOUT,
		[Token(Token = "0x4000478")]
		ERR_EVENT_NOTFOUND,
		[Token(Token = "0x4000479")]
		ERR_STUDIO_UNINITIALIZED,
		[Token(Token = "0x400047A")]
		ERR_STUDIO_NOT_LOADED,
		[Token(Token = "0x400047B")]
		ERR_INVALID_STRING,
		[Token(Token = "0x400047C")]
		ERR_ALREADY_LOCKED,
		[Token(Token = "0x400047D")]
		ERR_NOT_LOCKED,
		[Token(Token = "0x400047E")]
		ERR_RECORD_DISCONNECTED,
		[Token(Token = "0x400047F")]
		ERR_TOOMANYSAMPLES
	}
	[Token(Token = "0x2000089")]
	public enum CHANNELCONTROL_TYPE
	{
		[Token(Token = "0x4000481")]
		CHANNEL,
		[Token(Token = "0x4000482")]
		CHANNELGROUP,
		[Token(Token = "0x4000483")]
		MAX
	}
	[Token(Token = "0x200008A")]
	public struct VECTOR
	{
		[Token(Token = "0x4000484")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float x;

		[Token(Token = "0x4000485")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public float y;

		[Token(Token = "0x4000486")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public float z;
	}
	[Token(Token = "0x200008B")]
	public struct ATTRIBUTES_3D
	{
		[Token(Token = "0x4000487")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public VECTOR position;

		[Token(Token = "0x4000488")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public VECTOR velocity;

		[Token(Token = "0x4000489")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public VECTOR forward;

		[Token(Token = "0x400048A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public VECTOR up;
	}
	[Token(Token = "0x200008C")]
	public struct ASYNCREADINFO
	{
		[Token(Token = "0x400048B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public IntPtr handle;

		[Token(Token = "0x400048C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public uint offset;

		[Token(Token = "0x400048D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public uint sizebytes;

		[Token(Token = "0x400048E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int priority;

		[Token(Token = "0x400048F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public IntPtr userdata;

		[Token(Token = "0x4000490")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public IntPtr buffer;

		[Token(Token = "0x4000491")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public uint bytesread;

		[Token(Token = "0x4000492")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public FILE_ASYNCDONE_FUNC done;
	}
	[Token(Token = "0x200008D")]
	public enum OUTPUTTYPE
	{
		[Token(Token = "0x4000494")]
		AUTODETECT,
		[Token(Token = "0x4000495")]
		UNKNOWN,
		[Token(Token = "0x4000496")]
		NOSOUND,
		[Token(Token = "0x4000497")]
		WAVWRITER,
		[Token(Token = "0x4000498")]
		NOSOUND_NRT,
		[Token(Token = "0x4000499")]
		WAVWRITER_NRT,
		[Token(Token = "0x400049A")]
		WASAPI,
		[Token(Token = "0x400049B")]
		ASIO,
		[Token(Token = "0x400049C")]
		PULSEAUDIO,
		[Token(Token = "0x400049D")]
		ALSA,
		[Token(Token = "0x400049E")]
		COREAUDIO,
		[Token(Token = "0x400049F")]
		AUDIOTRACK,
		[Token(Token = "0x40004A0")]
		OPENSL,
		[Token(Token = "0x40004A1")]
		AUDIOOUT,
		[Token(Token = "0x40004A2")]
		AUDIO3D,
		[Token(Token = "0x40004A3")]
		WEBAUDIO,
		[Token(Token = "0x40004A4")]
		NNAUDIO,
		[Token(Token = "0x40004A5")]
		WINSONIC,
		[Token(Token = "0x40004A6")]
		AAUDIO,
		[Token(Token = "0x40004A7")]
		MAX
	}
	[Token(Token = "0x200008E")]
	public enum DEBUG_MODE
	{
		[Token(Token = "0x40004A9")]
		TTY,
		[Token(Token = "0x40004AA")]
		FILE,
		[Token(Token = "0x40004AB")]
		CALLBACK
	}
	[Token(Token = "0x200008F")]
	[Flags]
	public enum DEBUG_FLAGS : uint
	{
		[Token(Token = "0x40004AD")]
		NONE = 0u,
		[Token(Token = "0x40004AE")]
		ERROR = 1u,
		[Token(Token = "0x40004AF")]
		WARNING = 2u,
		[Token(Token = "0x40004B0")]
		LOG = 4u,
		[Token(Token = "0x40004B1")]
		TYPE_MEMORY = 0x100u,
		[Token(Token = "0x40004B2")]
		TYPE_FILE = 0x200u,
		[Token(Token = "0x40004B3")]
		TYPE_CODEC = 0x400u,
		[Token(Token = "0x40004B4")]
		TYPE_TRACE = 0x800u,
		[Token(Token = "0x40004B5")]
		DISPLAY_TIMESTAMPS = 0x10000u,
		[Token(Token = "0x40004B6")]
		DISPLAY_LINENUMBERS = 0x20000u,
		[Token(Token = "0x40004B7")]
		DISPLAY_THREAD = 0x40000u
	}
	[Token(Token = "0x2000090")]
	[Flags]
	public enum MEMORY_TYPE : uint
	{
		[Token(Token = "0x40004B9")]
		NORMAL = 0u,
		[Token(Token = "0x40004BA")]
		STREAM_FILE = 1u,
		[Token(Token = "0x40004BB")]
		STREAM_DECODE = 2u,
		[Token(Token = "0x40004BC")]
		SAMPLEDATA = 4u,
		[Token(Token = "0x40004BD")]
		DSP_BUFFER = 8u,
		[Token(Token = "0x40004BE")]
		PLUGIN = 0x10u,
		[Token(Token = "0x40004BF")]
		PERSISTENT = 0x200000u,
		[Token(Token = "0x40004C0")]
		ALL = uint.MaxValue
	}
	[Token(Token = "0x2000091")]
	public enum SPEAKERMODE
	{
		[Token(Token = "0x40004C2")]
		DEFAULT,
		[Token(Token = "0x40004C3")]
		RAW,
		[Token(Token = "0x40004C4")]
		MONO,
		[Token(Token = "0x40004C5")]
		STEREO,
		[Token(Token = "0x40004C6")]
		QUAD,
		[Token(Token = "0x40004C7")]
		SURROUND,
		[Token(Token = "0x40004C8")]
		_5POINT1,
		[Token(Token = "0x40004C9")]
		_7POINT1,
		[Token(Token = "0x40004CA")]
		_7POINT1POINT4,
		[Token(Token = "0x40004CB")]
		MAX
	}
	[Token(Token = "0x2000092")]
	public enum SPEAKER
	{
		[Token(Token = "0x40004CD")]
		NONE = -1,
		[Token(Token = "0x40004CE")]
		FRONT_LEFT,
		[Token(Token = "0x40004CF")]
		FRONT_RIGHT,
		[Token(Token = "0x40004D0")]
		FRONT_CENTER,
		[Token(Token = "0x40004D1")]
		LOW_FREQUENCY,
		[Token(Token = "0x40004D2")]
		SURROUND_LEFT,
		[Token(Token = "0x40004D3")]
		SURROUND_RIGHT,
		[Token(Token = "0x40004D4")]
		BACK_LEFT,
		[Token(Token = "0x40004D5")]
		BACK_RIGHT,
		[Token(Token = "0x40004D6")]
		TOP_FRONT_LEFT,
		[Token(Token = "0x40004D7")]
		TOP_FRONT_RIGHT,
		[Token(Token = "0x40004D8")]
		TOP_BACK_LEFT,
		[Token(Token = "0x40004D9")]
		TOP_BACK_RIGHT,
		[Token(Token = "0x40004DA")]
		MAX
	}
	[Token(Token = "0x2000093")]
	[Flags]
	public enum CHANNELMASK : uint
	{
		[Token(Token = "0x40004DC")]
		FRONT_LEFT = 1u,
		[Token(Token = "0x40004DD")]
		FRONT_RIGHT = 2u,
		[Token(Token = "0x40004DE")]
		FRONT_CENTER = 4u,
		[Token(Token = "0x40004DF")]
		LOW_FREQUENCY = 8u,
		[Token(Token = "0x40004E0")]
		SURROUND_LEFT = 0x10u,
		[Token(Token = "0x40004E1")]
		SURROUND_RIGHT = 0x20u,
		[Token(Token = "0x40004E2")]
		BACK_LEFT = 0x40u,
		[Token(Token = "0x40004E3")]
		BACK_RIGHT = 0x80u,
		[Token(Token = "0x40004E4")]
		BACK_CENTER = 0x100u,
		[Token(Token = "0x40004E5")]
		MONO = 1u,
		[Token(Token = "0x40004E6")]
		STEREO = 3u,
		[Token(Token = "0x40004E7")]
		LRC = 7u,
		[Token(Token = "0x40004E8")]
		QUAD = 0x33u,
		[Token(Token = "0x40004E9")]
		SURROUND = 0x37u,
		[Token(Token = "0x40004EA")]
		_5POINT1 = 0x3Fu,
		[Token(Token = "0x40004EB")]
		_5POINT1_REARS = 0xCFu,
		[Token(Token = "0x40004EC")]
		_7POINT0 = 0xF7u,
		[Token(Token = "0x40004ED")]
		_7POINT1 = 0xFFu
	}
	[Token(Token = "0x2000094")]
	public enum CHANNELORDER
	{
		[Token(Token = "0x40004EF")]
		DEFAULT,
		[Token(Token = "0x40004F0")]
		WAVEFORMAT,
		[Token(Token = "0x40004F1")]
		PROTOOLS,
		[Token(Token = "0x40004F2")]
		ALLMONO,
		[Token(Token = "0x40004F3")]
		ALLSTEREO,
		[Token(Token = "0x40004F4")]
		ALSA,
		[Token(Token = "0x40004F5")]
		MAX
	}
	[Token(Token = "0x2000095")]
	public enum PLUGINTYPE
	{
		[Token(Token = "0x40004F7")]
		OUTPUT,
		[Token(Token = "0x40004F8")]
		CODEC,
		[Token(Token = "0x40004F9")]
		DSP,
		[Token(Token = "0x40004FA")]
		MAX
	}
	[Token(Token = "0x2000096")]
	public struct PLUGINLIST
	{
		[Token(Token = "0x40004FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private PLUGINTYPE type;

		[Token(Token = "0x40004FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private IntPtr description;
	}
	[Token(Token = "0x2000097")]
	[Flags]
	public enum INITFLAGS : uint
	{
		[Token(Token = "0x40004FE")]
		NORMAL = 0u,
		[Token(Token = "0x40004FF")]
		STREAM_FROM_UPDATE = 1u,
		[Token(Token = "0x4000500")]
		MIX_FROM_UPDATE = 2u,
		[Token(Token = "0x4000501")]
		_3D_RIGHTHANDED = 4u,
		[Token(Token = "0x4000502")]
		CHANNEL_LOWPASS = 0x100u,
		[Token(Token = "0x4000503")]
		CHANNEL_DISTANCEFILTER = 0x200u,
		[Token(Token = "0x4000504")]
		PROFILE_ENABLE = 0x10000u,
		[Token(Token = "0x4000505")]
		VOL0_BECOMES_VIRTUAL = 0x20000u,
		[Token(Token = "0x4000506")]
		GEOMETRY_USECLOSEST = 0x40000u,
		[Token(Token = "0x4000507")]
		PREFER_DOLBY_DOWNMIX = 0x80000u,
		[Token(Token = "0x4000508")]
		THREAD_UNSAFE = 0x100000u,
		[Token(Token = "0x4000509")]
		PROFILE_METER_ALL = 0x200000u,
		[Token(Token = "0x400050A")]
		MEMORY_TRACKING = 0x400000u
	}
	[Token(Token = "0x2000098")]
	public enum SOUND_TYPE
	{
		[Token(Token = "0x400050C")]
		UNKNOWN,
		[Token(Token = "0x400050D")]
		AIFF,
		[Token(Token = "0x400050E")]
		ASF,
		[Token(Token = "0x400050F")]
		DLS,
		[Token(Token = "0x4000510")]
		FLAC,
		[Token(Token = "0x4000511")]
		FSB,
		[Token(Token = "0x4000512")]
		IT,
		[Token(Token = "0x4000513")]
		MIDI,
		[Token(Token = "0x4000514")]
		MOD,
		[Token(Token = "0x4000515")]
		MPEG,
		[Token(Token = "0x4000516")]
		OGGVORBIS,
		[Token(Token = "0x4000517")]
		PLAYLIST,
		[Token(Token = "0x4000518")]
		RAW,
		[Token(Token = "0x4000519")]
		S3M,
		[Token(Token = "0x400051A")]
		USER,
		[Token(Token = "0x400051B")]
		WAV,
		[Token(Token = "0x400051C")]
		XM,
		[Token(Token = "0x400051D")]
		XMA,
		[Token(Token = "0x400051E")]
		AUDIOQUEUE,
		[Token(Token = "0x400051F")]
		AT9,
		[Token(Token = "0x4000520")]
		VORBIS,
		[Token(Token = "0x4000521")]
		MEDIA_FOUNDATION,
		[Token(Token = "0x4000522")]
		MEDIACODEC,
		[Token(Token = "0x4000523")]
		FADPCM,
		[Token(Token = "0x4000524")]
		OPUS,
		[Token(Token = "0x4000525")]
		MAX
	}
	[Token(Token = "0x2000099")]
	public enum SOUND_FORMAT
	{
		[Token(Token = "0x4000527")]
		NONE,
		[Token(Token = "0x4000528")]
		PCM8,
		[Token(Token = "0x4000529")]
		PCM16,
		[Token(Token = "0x400052A")]
		PCM24,
		[Token(Token = "0x400052B")]
		PCM32,
		[Token(Token = "0x400052C")]
		PCMFLOAT,
		[Token(Token = "0x400052D")]
		BITSTREAM,
		[Token(Token = "0x400052E")]
		MAX
	}
	[Token(Token = "0x200009A")]
	[Flags]
	public enum MODE : uint
	{
		[Token(Token = "0x4000530")]
		DEFAULT = 0u,
		[Token(Token = "0x4000531")]
		LOOP_OFF = 1u,
		[Token(Token = "0x4000532")]
		LOOP_NORMAL = 2u,
		[Token(Token = "0x4000533")]
		LOOP_BIDI = 4u,
		[Token(Token = "0x4000534")]
		_2D = 8u,
		[Token(Token = "0x4000535")]
		_3D = 0x10u,
		[Token(Token = "0x4000536")]
		CREATESTREAM = 0x80u,
		[Token(Token = "0x4000537")]
		CREATESAMPLE = 0x100u,
		[Token(Token = "0x4000538")]
		CREATECOMPRESSEDSAMPLE = 0x200u,
		[Token(Token = "0x4000539")]
		OPENUSER = 0x400u,
		[Token(Token = "0x400053A")]
		OPENMEMORY = 0x800u,
		[Token(Token = "0x400053B")]
		OPENMEMORY_POINT = 0x10000000u,
		[Token(Token = "0x400053C")]
		OPENRAW = 0x1000u,
		[Token(Token = "0x400053D")]
		OPENONLY = 0x2000u,
		[Token(Token = "0x400053E")]
		ACCURATETIME = 0x4000u,
		[Token(Token = "0x400053F")]
		MPEGSEARCH = 0x8000u,
		[Token(Token = "0x4000540")]
		NONBLOCKING = 0x10000u,
		[Token(Token = "0x4000541")]
		UNIQUE = 0x20000u,
		[Token(Token = "0x4000542")]
		_3D_HEADRELATIVE = 0x40000u,
		[Token(Token = "0x4000543")]
		_3D_WORLDRELATIVE = 0x80000u,
		[Token(Token = "0x4000544")]
		_3D_INVERSEROLLOFF = 0x100000u,
		[Token(Token = "0x4000545")]
		_3D_LINEARROLLOFF = 0x200000u,
		[Token(Token = "0x4000546")]
		_3D_LINEARSQUAREROLLOFF = 0x400000u,
		[Token(Token = "0x4000547")]
		_3D_INVERSETAPEREDROLLOFF = 0x800000u,
		[Token(Token = "0x4000548")]
		_3D_CUSTOMROLLOFF = 0x4000000u,
		[Token(Token = "0x4000549")]
		_3D_IGNOREGEOMETRY = 0x40000000u,
		[Token(Token = "0x400054A")]
		IGNORETAGS = 0x2000000u,
		[Token(Token = "0x400054B")]
		LOWMEM = 0x8000000u,
		[Token(Token = "0x400054C")]
		VIRTUAL_PLAYFROMSTART = 0x80000000u
	}
	[Token(Token = "0x200009B")]
	public enum OPENSTATE
	{
		[Token(Token = "0x400054E")]
		READY,
		[Token(Token = "0x400054F")]
		LOADING,
		[Token(Token = "0x4000550")]
		ERROR,
		[Token(Token = "0x4000551")]
		CONNECTING,
		[Token(Token = "0x4000552")]
		BUFFERING,
		[Token(Token = "0x4000553")]
		SEEKING,
		[Token(Token = "0x4000554")]
		PLAYING,
		[Token(Token = "0x4000555")]
		SETPOSITION,
		[Token(Token = "0x4000556")]
		MAX
	}
	[Token(Token = "0x200009C")]
	public enum SOUNDGROUP_BEHAVIOR
	{
		[Token(Token = "0x4000558")]
		BEHAVIOR_FAIL,
		[Token(Token = "0x4000559")]
		BEHAVIOR_MUTE,
		[Token(Token = "0x400055A")]
		BEHAVIOR_STEALLOWEST,
		[Token(Token = "0x400055B")]
		MAX
	}
	[Token(Token = "0x200009D")]
	public enum CHANNELCONTROL_CALLBACK_TYPE
	{
		[Token(Token = "0x400055D")]
		END,
		[Token(Token = "0x400055E")]
		VIRTUALVOICE,
		[Token(Token = "0x400055F")]
		SYNCPOINT,
		[Token(Token = "0x4000560")]
		OCCLUSION,
		[Token(Token = "0x4000561")]
		MAX
	}
	[Token(Token = "0x200009E")]
	public struct CHANNELCONTROL_DSP_INDEX
	{
		[Token(Token = "0x4000562")]
		public const int HEAD = -1;

		[Token(Token = "0x4000563")]
		public const int FADER = -2;

		[Token(Token = "0x4000564")]
		public const int TAIL = -3;
	}
	[Token(Token = "0x200009F")]
	public enum ERRORCALLBACK_INSTANCETYPE
	{
		[Token(Token = "0x4000566")]
		NONE,
		[Token(Token = "0x4000567")]
		SYSTEM,
		[Token(Token = "0x4000568")]
		CHANNEL,
		[Token(Token = "0x4000569")]
		CHANNELGROUP,
		[Token(Token = "0x400056A")]
		CHANNELCONTROL,
		[Token(Token = "0x400056B")]
		SOUND,
		[Token(Token = "0x400056C")]
		SOUNDGROUP,
		[Token(Token = "0x400056D")]
		DSP,
		[Token(Token = "0x400056E")]
		DSPCONNECTION,
		[Token(Token = "0x400056F")]
		GEOMETRY,
		[Token(Token = "0x4000570")]
		REVERB3D,
		[Token(Token = "0x4000571")]
		STUDIO_SYSTEM,
		[Token(Token = "0x4000572")]
		STUDIO_EVENTDESCRIPTION,
		[Token(Token = "0x4000573")]
		STUDIO_EVENTINSTANCE,
		[Token(Token = "0x4000574")]
		STUDIO_PARAMETERINSTANCE,
		[Token(Token = "0x4000575")]
		STUDIO_BUS,
		[Token(Token = "0x4000576")]
		STUDIO_VCA,
		[Token(Token = "0x4000577")]
		STUDIO_BANK,
		[Token(Token = "0x4000578")]
		STUDIO_COMMANDREPLAY
	}
	[Token(Token = "0x20000A0")]
	public struct ERRORCALLBACK_INFO
	{
		[Token(Token = "0x4000579")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public RESULT result;

		[Token(Token = "0x400057A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public ERRORCALLBACK_INSTANCETYPE instancetype;

		[Token(Token = "0x400057B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public IntPtr instance;

		[Token(Token = "0x400057C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public StringWrapper functionname;

		[Token(Token = "0x400057D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public StringWrapper functionparams;
	}
	[Token(Token = "0x20000A1")]
	[Flags]
	public enum SYSTEM_CALLBACK_TYPE : uint
	{
		[Token(Token = "0x400057F")]
		DEVICELISTCHANGED = 1u,
		[Token(Token = "0x4000580")]
		DEVICELOST = 2u,
		[Token(Token = "0x4000581")]
		MEMORYALLOCATIONFAILED = 4u,
		[Token(Token = "0x4000582")]
		THREADCREATED = 8u,
		[Token(Token = "0x4000583")]
		BADDSPCONNECTION = 0x10u,
		[Token(Token = "0x4000584")]
		PREMIX = 0x20u,
		[Token(Token = "0x4000585")]
		POSTMIX = 0x40u,
		[Token(Token = "0x4000586")]
		ERROR = 0x80u,
		[Token(Token = "0x4000587")]
		MIDMIX = 0x100u,
		[Token(Token = "0x4000588")]
		THREADDESTROYED = 0x200u,
		[Token(Token = "0x4000589")]
		PREUPDATE = 0x400u,
		[Token(Token = "0x400058A")]
		POSTUPDATE = 0x800u,
		[Token(Token = "0x400058B")]
		RECORDLISTCHANGED = 0x1000u,
		[Token(Token = "0x400058C")]
		ALL = uint.MaxValue
	}
	[Token(Token = "0x20000A2")]
	public delegate RESULT DEBUG_CALLBACK(DEBUG_FLAGS flags, StringWrapper file, int line, StringWrapper func, StringWrapper message);
	[Token(Token = "0x20000A3")]
	public delegate RESULT SYSTEM_CALLBACK(IntPtr system, SYSTEM_CALLBACK_TYPE type, IntPtr commanddata1, IntPtr commanddata2, IntPtr userdata);
	[Token(Token = "0x20000A4")]
	public delegate RESULT CHANNELCONTROL_CALLBACK(IntPtr channelcontrol, CHANNELCONTROL_TYPE controltype, CHANNELCONTROL_CALLBACK_TYPE callbacktype, IntPtr commanddata1, IntPtr commanddata2);
	[Token(Token = "0x20000A5")]
	public delegate RESULT SOUND_NONBLOCK_CALLBACK(IntPtr sound, RESULT result);
	[Token(Token = "0x20000A6")]
	public delegate RESULT SOUND_PCMREAD_CALLBACK(IntPtr sound, IntPtr data, uint datalen);
	[Token(Token = "0x20000A7")]
	public delegate RESULT SOUND_PCMSETPOS_CALLBACK(IntPtr sound, int subsound, uint position, TIMEUNIT postype);
	[Token(Token = "0x20000A8")]
	public delegate RESULT FILE_OPEN_CALLBACK(StringWrapper name, ref uint filesize, ref IntPtr handle, IntPtr userdata);
	[Token(Token = "0x20000A9")]
	public delegate RESULT FILE_CLOSE_CALLBACK(IntPtr handle, IntPtr userdata);
	[Token(Token = "0x20000AA")]
	public delegate RESULT FILE_READ_CALLBACK(IntPtr handle, IntPtr buffer, uint sizebytes, ref uint bytesread, IntPtr userdata);
	[Token(Token = "0x20000AB")]
	public delegate RESULT FILE_SEEK_CALLBACK(IntPtr handle, uint pos, IntPtr userdata);
	[Token(Token = "0x20000AC")]
	public delegate RESULT FILE_ASYNCREAD_CALLBACK(IntPtr info, IntPtr userdata);
	[Token(Token = "0x20000AD")]
	public delegate RESULT FILE_ASYNCCANCEL_CALLBACK(IntPtr info, IntPtr userdata);
	[Token(Token = "0x20000AE")]
	public delegate RESULT FILE_ASYNCDONE_FUNC(IntPtr info, RESULT result);
	[Token(Token = "0x20000AF")]
	public delegate IntPtr MEMORY_ALLOC_CALLBACK(uint size, MEMORY_TYPE type, StringWrapper sourcestr);
	[Token(Token = "0x20000B0")]
	public delegate IntPtr MEMORY_REALLOC_CALLBACK(IntPtr ptr, uint size, MEMORY_TYPE type, StringWrapper sourcestr);
	[Token(Token = "0x20000B1")]
	public delegate void MEMORY_FREE_CALLBACK(IntPtr ptr, MEMORY_TYPE type, StringWrapper sourcestr);
	[Token(Token = "0x20000B2")]
	public delegate float CB_3D_ROLLOFF_CALLBACK(IntPtr channelcontrol, float distance);
	[Token(Token = "0x20000B3")]
	public enum DSP_RESAMPLER
	{
		[Token(Token = "0x400058E")]
		DEFAULT,
		[Token(Token = "0x400058F")]
		NOINTERP,
		[Token(Token = "0x4000590")]
		LINEAR,
		[Token(Token = "0x4000591")]
		CUBIC,
		[Token(Token = "0x4000592")]
		SPLINE,
		[Token(Token = "0x4000593")]
		MAX
	}
	[Token(Token = "0x20000B4")]
	public enum DSPCONNECTION_TYPE
	{
		[Token(Token = "0x4000595")]
		STANDARD,
		[Token(Token = "0x4000596")]
		SIDECHAIN,
		[Token(Token = "0x4000597")]
		SEND,
		[Token(Token = "0x4000598")]
		SEND_SIDECHAIN,
		[Token(Token = "0x4000599")]
		MAX
	}
	[Token(Token = "0x20000B5")]
	public enum TAGTYPE
	{
		[Token(Token = "0x400059B")]
		UNKNOWN,
		[Token(Token = "0x400059C")]
		ID3V1,
		[Token(Token = "0x400059D")]
		ID3V2,
		[Token(Token = "0x400059E")]
		VORBISCOMMENT,
		[Token(Token = "0x400059F")]
		SHOUTCAST,
		[Token(Token = "0x40005A0")]
		ICECAST,
		[Token(Token = "0x40005A1")]
		ASF,
		[Token(Token = "0x40005A2")]
		MIDI,
		[Token(Token = "0x40005A3")]
		PLAYLIST,
		[Token(Token = "0x40005A4")]
		FMOD,
		[Token(Token = "0x40005A5")]
		USER,
		[Token(Token = "0x40005A6")]
		MAX
	}
	[Token(Token = "0x20000B6")]
	public enum TAGDATATYPE
	{
		[Token(Token = "0x40005A8")]
		BINARY,
		[Token(Token = "0x40005A9")]
		INT,
		[Token(Token = "0x40005AA")]
		FLOAT,
		[Token(Token = "0x40005AB")]
		STRING,
		[Token(Token = "0x40005AC")]
		STRING_UTF16,
		[Token(Token = "0x40005AD")]
		STRING_UTF16BE,
		[Token(Token = "0x40005AE")]
		STRING_UTF8,
		[Token(Token = "0x40005AF")]
		MAX
	}
	[Token(Token = "0x20000B7")]
	public struct TAG
	{
		[Token(Token = "0x40005B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public TAGTYPE type;

		[Token(Token = "0x40005B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public TAGDATATYPE datatype;

		[Token(Token = "0x40005B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public StringWrapper name;

		[Token(Token = "0x40005B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public IntPtr data;

		[Token(Token = "0x40005B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public uint datalen;

		[Token(Token = "0x40005B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public bool updated;
	}
	[Token(Token = "0x20000B8")]
	[Flags]
	public enum TIMEUNIT : uint
	{
		[Token(Token = "0x40005B7")]
		MS = 1u,
		[Token(Token = "0x40005B8")]
		PCM = 2u,
		[Token(Token = "0x40005B9")]
		PCMBYTES = 4u,
		[Token(Token = "0x40005BA")]
		RAWBYTES = 8u,
		[Token(Token = "0x40005BB")]
		PCMFRACTION = 0x10u,
		[Token(Token = "0x40005BC")]
		MODORDER = 0x100u,
		[Token(Token = "0x40005BD")]
		MODROW = 0x200u,
		[Token(Token = "0x40005BE")]
		MODPATTERN = 0x400u
	}
	[Token(Token = "0x20000B9")]
	public struct PORT_INDEX
	{
		[Token(Token = "0x40005BF")]
		public const ulong NONE = ulong.MaxValue;
	}
	[Token(Token = "0x20000BA")]
	public struct CREATESOUNDEXINFO
	{
		[Token(Token = "0x40005C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int cbsize;

		[Token(Token = "0x40005C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public uint length;

		[Token(Token = "0x40005C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public uint fileoffset;

		[Token(Token = "0x40005C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public int numchannels;

		[Token(Token = "0x40005C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int defaultfrequency;

		[Token(Token = "0x40005C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public SOUND_FORMAT format;

		[Token(Token = "0x40005C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public uint decodebuffersize;

		[Token(Token = "0x40005C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public int initialsubsound;

		[Token(Token = "0x40005C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public int numsubsounds;

		[Token(Token = "0x40005C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public IntPtr inclusionlist;

		[Token(Token = "0x40005CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public int inclusionlistnum;

		[Token(Token = "0x40005CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public SOUND_PCMREAD_CALLBACK pcmreadcallback;

		[Token(Token = "0x40005CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public SOUND_PCMSETPOS_CALLBACK pcmsetposcallback;

		[Token(Token = "0x40005CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public SOUND_NONBLOCK_CALLBACK nonblockcallback;

		[Token(Token = "0x40005CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public IntPtr dlsname;

		[Token(Token = "0x40005CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public IntPtr encryptionkey;

		[Token(Token = "0x40005D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public int maxpolyphony;

		[Token(Token = "0x40005D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public IntPtr userdata;

		[Token(Token = "0x40005D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public SOUND_TYPE suggestedsoundtype;

		[Token(Token = "0x40005D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public FILE_OPEN_CALLBACK fileuseropen;

		[Token(Token = "0x40005D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public FILE_CLOSE_CALLBACK fileuserclose;

		[Token(Token = "0x40005D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public FILE_READ_CALLBACK fileuserread;

		[Token(Token = "0x40005D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public FILE_SEEK_CALLBACK fileuserseek;

		[Token(Token = "0x40005D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public FILE_ASYNCREAD_CALLBACK fileuserasyncread;

		[Token(Token = "0x40005D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public FILE_ASYNCCANCEL_CALLBACK fileuserasynccancel;

		[Token(Token = "0x40005D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public IntPtr fileuserdata;

		[Token(Token = "0x40005DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public int filebuffersize;

		[Token(Token = "0x40005DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		public CHANNELORDER channelorder;

		[Token(Token = "0x40005DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public IntPtr initialsoundgroup;

		[Token(Token = "0x40005DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public uint initialseekposition;

		[Token(Token = "0x40005DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		public TIMEUNIT initialseekpostype;

		[Token(Token = "0x40005DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public int ignoresetfilesystem;

		[Token(Token = "0x40005E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		public uint audioqueuepolicy;

		[Token(Token = "0x40005E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public uint minmidigranularity;

		[Token(Token = "0x40005E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		public int nonblockthreadid;

		[Token(Token = "0x40005E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		public IntPtr fsbguid;
	}
	[Token(Token = "0x20000BB")]
	public struct REVERB_PROPERTIES
	{
		[Token(Token = "0x40005E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float DecayTime;

		[Token(Token = "0x40005E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public float EarlyDelay;

		[Token(Token = "0x40005E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public float LateDelay;

		[Token(Token = "0x40005E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public float HFReference;

		[Token(Token = "0x40005E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float HFDecayRatio;

		[Token(Token = "0x40005E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public float Diffusion;

		[Token(Token = "0x40005EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float Density;

		[Token(Token = "0x40005EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float LowShelfFrequency;

		[Token(Token = "0x40005EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float LowShelfGain;

		[Token(Token = "0x40005ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float HighCut;

		[Token(Token = "0x40005EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float EarlyLateMix;

		[Token(Token = "0x40005EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float WetLevel;

		[Token(Token = "0x600055A")]
		[Address(RVA = "0x325C10C", Offset = "0x325C10C", VA = "0x325C10C")]
		public REVERB_PROPERTIES(float decayTime, float earlyDelay, float lateDelay, float hfReference, float hfDecayRatio, float diffusion, float density, float lowShelfFrequency, float lowShelfGain, float highCut, float earlyLateMix, float wetLevel)
		{
		}
	}
	[Token(Token = "0x20000BC")]
	public class PRESET
	{
		[Token(Token = "0x600055B")]
		[Address(RVA = "0x325C0E8", Offset = "0x325C0E8", VA = "0x325C0E8")]
		public static REVERB_PROPERTIES OFF()
		{
			return default(REVERB_PROPERTIES);
		}

		[Token(Token = "0x600055C")]
		[Address(RVA = "0x325C138", Offset = "0x325C138", VA = "0x325C138")]
		public static REVERB_PROPERTIES GENERIC()
		{
			return default(REVERB_PROPERTIES);
		}

		[Token(Token = "0x600055D")]
		[Address(RVA = "0x325C15C", Offset = "0x325C15C", VA = "0x325C15C")]
		public static REVERB_PROPERTIES PADDEDCELL()
		{
			return default(REVERB_PROPERTIES);
		}

		[Token(Token = "0x600055E")]
		[Address(RVA = "0x325C180", Offset = "0x325C180", VA = "0x325C180")]
		public static REVERB_PROPERTIES ROOM()
		{
			return default(REVERB_PROPERTIES);
		}

		[Token(Token = "0x600055F")]
		[Address(RVA = "0x325C1A4", Offset = "0x325C1A4", VA = "0x325C1A4")]
		public static REVERB_PROPERTIES BATHROOM()
		{
			return default(REVERB_PROPERTIES);
		}

		[Token(Token = "0x6000560")]
		[Address(RVA = "0x325C1C8", Offset = "0x325C1C8", VA = "0x325C1C8")]
		public static REVERB_PROPERTIES LIVINGROOM()
		{
			return default(REVERB_PROPERTIES);
		}

		[Token(Token = "0x6000561")]
		[Address(RVA = "0x325C1EC", Offset = "0x325C1EC", VA = "0x325C1EC")]
		public static REVERB_PROPERTIES STONEROOM()
		{
			return default(REVERB_PROPERTIES);
		}

		[Token(Token = "0x6000562")]
		[Address(RVA = "0x325C210", Offset = "0x325C210", VA = "0x325C210")]
		public static REVERB_PROPERTIES AUDITORIUM()
		{
			return default(REVERB_PROPERTIES);
		}

		[Token(Token = "0x6000563")]
		[Address(RVA = "0x325C234", Offset = "0x325C234", VA = "0x325C234")]
		public static REVERB_PROPERTIES CONCERTHALL()
		{
			return default(REVERB_PROPERTIES);
		}

		[Token(Token = "0x6000564")]
		[Address(RVA = "0x325C258", Offset = "0x325C258", VA = "0x325C258")]
		public static REVERB_PROPERTIES CAVE()
		{
			return default(REVERB_PROPERTIES);
		}

		[Token(Token = "0x6000565")]
		[Address(RVA = "0x325C27C", Offset = "0x325C27C", VA = "0x325C27C")]
		public static REVERB_PROPERTIES ARENA()
		{
			return default(REVERB_PROPERTIES);
		}

		[Token(Token = "0x6000566")]
		[Address(RVA = "0x325C2A0", Offset = "0x325C2A0", VA = "0x325C2A0")]
		public static REVERB_PROPERTIES HANGAR()
		{
			return default(REVERB_PROPERTIES);
		}

		[Token(Token = "0x6000567")]
		[Address(RVA = "0x325C2C4", Offset = "0x325C2C4", VA = "0x325C2C4")]
		public static REVERB_PROPERTIES CARPETTEDHALLWAY()
		{
			return default(REVERB_PROPERTIES);
		}

		[Token(Token = "0x6000568")]
		[Address(RVA = "0x325C2E8", Offset = "0x325C2E8", VA = "0x325C2E8")]
		public static REVERB_PROPERTIES HALLWAY()
		{
			return default(REVERB_PROPERTIES);
		}

		[Token(Token = "0x6000569")]
		[Address(RVA = "0x325C30C", Offset = "0x325C30C", VA = "0x325C30C")]
		public static REVERB_PROPERTIES STONECORRIDOR()
		{
			return default(REVERB_PROPERTIES);
		}

		[Token(Token = "0x600056A")]
		[Address(RVA = "0x325C330", Offset = "0x325C330", VA = "0x325C330")]
		public static REVERB_PROPERTIES ALLEY()
		{
			return default(REVERB_PROPERTIES);
		}

		[Token(Token = "0x600056B")]
		[Address(RVA = "0x325C354", Offset = "0x325C354", VA = "0x325C354")]
		public static REVERB_PROPERTIES FOREST()
		{
			return default(REVERB_PROPERTIES);
		}

		[Token(Token = "0x600056C")]
		[Address(RVA = "0x325C378", Offset = "0x325C378", VA = "0x325C378")]
		public static REVERB_PROPERTIES CITY()
		{
			return default(REVERB_PROPERTIES);
		}

		[Token(Token = "0x600056D")]
		[Address(RVA = "0x325C39C", Offset = "0x325C39C", VA = "0x325C39C")]
		public static REVERB_PROPERTIES MOUNTAINS()
		{
			return default(REVERB_PROPERTIES);
		}

		[Token(Token = "0x600056E")]
		[Address(RVA = "0x325C3C0", Offset = "0x325C3C0", VA = "0x325C3C0")]
		public static REVERB_PROPERTIES QUARRY()
		{
			return default(REVERB_PROPERTIES);
		}

		[Token(Token = "0x600056F")]
		[Address(RVA = "0x325C3E4", Offset = "0x325C3E4", VA = "0x325C3E4")]
		public static REVERB_PROPERTIES PLAIN()
		{
			return default(REVERB_PROPERTIES);
		}

		[Token(Token = "0x6000570")]
		[Address(RVA = "0x325C408", Offset = "0x325C408", VA = "0x325C408")]
		public static REVERB_PROPERTIES PARKINGLOT()
		{
			return default(REVERB_PROPERTIES);
		}

		[Token(Token = "0x6000571")]
		[Address(RVA = "0x325C42C", Offset = "0x325C42C", VA = "0x325C42C")]
		public static REVERB_PROPERTIES SEWERPIPE()
		{
			return default(REVERB_PROPERTIES);
		}

		[Token(Token = "0x6000572")]
		[Address(RVA = "0x325C450", Offset = "0x325C450", VA = "0x325C450")]
		public static REVERB_PROPERTIES UNDERWATER()
		{
			return default(REVERB_PROPERTIES);
		}

		[Token(Token = "0x6000573")]
		[Address(RVA = "0x325C474", Offset = "0x325C474", VA = "0x325C474")]
		public PRESET()
		{
		}
	}
	[Token(Token = "0x20000BD")]
	public struct ADVANCEDSETTINGS
	{
		[Token(Token = "0x40005F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int cbSize;

		[Token(Token = "0x40005F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public int maxMPEGCodecs;

		[Token(Token = "0x40005F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public int maxADPCMCodecs;

		[Token(Token = "0x40005F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public int maxXMACodecs;

		[Token(Token = "0x40005F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int maxVorbisCodecs;

		[Token(Token = "0x40005F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public int maxAT9Codecs;

		[Token(Token = "0x40005F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int maxFADPCMCodecs;

		[Token(Token = "0x40005F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public int maxPCMCodecs;

		[Token(Token = "0x40005F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public int ASIONumChannels;

		[Token(Token = "0x40005F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public IntPtr ASIOChannelList;

		[Token(Token = "0x40005FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public IntPtr ASIOSpeakerList;

		[Token(Token = "0x40005FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float vol0virtualvol;

		[Token(Token = "0x40005FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public uint defaultDecodeBufferSize;

		[Token(Token = "0x40005FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public ushort profilePort;

		[Token(Token = "0x40005FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public uint geometryMaxFadeTime;

		[Token(Token = "0x40005FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float distanceFilterCenterFreq;

		[Token(Token = "0x4000600")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public int reverb3Dinstance;

		[Token(Token = "0x4000601")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public int DSPBufferPoolSize;

		[Token(Token = "0x4000602")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public uint stackSizeStream;

		[Token(Token = "0x4000603")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public uint stackSizeNonBlocking;

		[Token(Token = "0x4000604")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public uint stackSizeMixer;

		[Token(Token = "0x4000605")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public DSP_RESAMPLER resamplerMethod;

		[Token(Token = "0x4000606")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public uint commandQueueSize;

		[Token(Token = "0x4000607")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public uint randomSeed;
	}
	[Token(Token = "0x20000BE")]
	[Flags]
	public enum DRIVER_STATE : uint
	{
		[Token(Token = "0x4000609")]
		CONNECTED = 1u,
		[Token(Token = "0x400060A")]
		DEFAULT = 2u
	}
	[Token(Token = "0x20000BF")]
	public struct Factory
	{
		[Token(Token = "0x6000574")]
		[Address(RVA = "0x325A678", Offset = "0x325A678", VA = "0x325A678")]
		public static RESULT System_Create(out System system)
		{
			return default(RESULT);
		}

		[PreserveSig]
		[Token(Token = "0x6000575")]
		[Address(RVA = "0x325A67C", Offset = "0x325A67C", VA = "0x325A67C")]
		private static extern RESULT FMOD5_System_Create(out IntPtr system);
	}
	[Token(Token = "0x20000C0")]
	public struct Memory
	{
		[Token(Token = "0x6000576")]
		[Address(RVA = "0x325BF64", Offset = "0x325BF64", VA = "0x325BF64")]
		public static RESULT Initialize(IntPtr poolmem, int poollen, MEMORY_ALLOC_CALLBACK useralloc, MEMORY_REALLOC_CALLBACK userrealloc, MEMORY_FREE_CALLBACK userfree, MEMORY_TYPE memtypeflags = MEMORY_TYPE.ALL)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000577")]
		[Address(RVA = "0x325C048", Offset = "0x325C048", VA = "0x325C048")]
		public static RESULT GetStats(out int currentalloced, out int maxalloced, bool blocking = true)
		{
			return default(RESULT);
		}

		[PreserveSig]
		[Token(Token = "0x6000578")]
		[Address(RVA = "0x325BF68", Offset = "0x325BF68", VA = "0x325BF68")]
		private static extern RESULT FMOD5_Memory_Initialize(IntPtr poolmem, int poollen, MEMORY_ALLOC_CALLBACK useralloc, MEMORY_REALLOC_CALLBACK userrealloc, MEMORY_FREE_CALLBACK userfree, MEMORY_TYPE memtypeflags);

		[PreserveSig]
		[Token(Token = "0x6000579")]
		[Address(RVA = "0x325C050", Offset = "0x325C050", VA = "0x325C050")]
		private static extern RESULT FMOD5_Memory_GetStats(out int currentalloced, out int maxalloced, bool blocking);
	}
	[Token(Token = "0x20000C1")]
	public struct Debug
	{
		[Token(Token = "0x600057A")]
		[Address(RVA = "0x32A9528", Offset = "0x32A9528", VA = "0x32A9528")]
		public static RESULT Initialize(DEBUG_FLAGS flags, DEBUG_MODE mode = DEBUG_MODE.TTY, [Optional] DEBUG_CALLBACK callback, [Optional] string filename)
		{
			return default(RESULT);
		}

		[PreserveSig]
		[Token(Token = "0x600057B")]
		[Address(RVA = "0x32A968C", Offset = "0x32A968C", VA = "0x32A968C")]
		private static extern RESULT FMOD5_Debug_Initialize(DEBUG_FLAGS flags, DEBUG_MODE mode, DEBUG_CALLBACK callback, byte[] filename);
	}
	[Token(Token = "0x20000C2")]
	public struct System
	{
		[Token(Token = "0x400060B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public IntPtr handle;

		[Token(Token = "0x600057C")]
		[Address(RVA = "0x23EE9D0", Offset = "0x23EE9D0", VA = "0x23EE9D0")]
		public RESULT release()
		{
			return default(RESULT);
		}

		[Token(Token = "0x600057D")]
		[Address(RVA = "0x23EEA58", Offset = "0x23EEA58", VA = "0x23EEA58")]
		public RESULT setOutput(OUTPUTTYPE output)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600057E")]
		[Address(RVA = "0x23EEAF0", Offset = "0x23EEAF0", VA = "0x23EEAF0")]
		public RESULT getOutput(out OUTPUTTYPE output)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600057F")]
		[Address(RVA = "0x23EEB88", Offset = "0x23EEB88", VA = "0x23EEB88")]
		public RESULT getNumDrivers(out int numdrivers)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000580")]
		[Address(RVA = "0x23EEC20", Offset = "0x23EEC20", VA = "0x23EEC20")]
		public RESULT getDriverInfo(int id, out string name, int namelen, out Guid guid, out int systemrate, out SPEAKERMODE speakermode, out int speakermodechannels)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000581")]
		[Address(RVA = "0x23EEEEC", Offset = "0x23EEEEC", VA = "0x23EEEEC")]
		public RESULT getDriverInfo(int id, out Guid guid, out int systemrate, out SPEAKERMODE speakermode, out int speakermodechannels)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000582")]
		[Address(RVA = "0x23EEF84", Offset = "0x23EEF84", VA = "0x23EEF84")]
		public RESULT setDriver(int driver)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000583")]
		[Address(RVA = "0x23EF01C", Offset = "0x23EF01C", VA = "0x23EF01C")]
		public RESULT getDriver(out int driver)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000584")]
		[Address(RVA = "0x23EF0B4", Offset = "0x23EF0B4", VA = "0x23EF0B4")]
		public RESULT setSoftwareChannels(int numsoftwarechannels)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000585")]
		[Address(RVA = "0x23EF14C", Offset = "0x23EF14C", VA = "0x23EF14C")]
		public RESULT getSoftwareChannels(out int numsoftwarechannels)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000586")]
		[Address(RVA = "0x23EF1E4", Offset = "0x23EF1E4", VA = "0x23EF1E4")]
		public RESULT setSoftwareFormat(int samplerate, SPEAKERMODE speakermode, int numrawspeakers)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000587")]
		[Address(RVA = "0x23EF294", Offset = "0x23EF294", VA = "0x23EF294")]
		public RESULT getSoftwareFormat(out int samplerate, out SPEAKERMODE speakermode, out int numrawspeakers)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000588")]
		[Address(RVA = "0x23EF344", Offset = "0x23EF344", VA = "0x23EF344")]
		public RESULT setDSPBufferSize(uint bufferlength, int numbuffers)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000589")]
		[Address(RVA = "0x23EF3E4", Offset = "0x23EF3E4", VA = "0x23EF3E4")]
		public RESULT getDSPBufferSize(out uint bufferlength, out int numbuffers)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600058A")]
		[Address(RVA = "0x23EF484", Offset = "0x23EF484", VA = "0x23EF484")]
		public RESULT setFileSystem(FILE_OPEN_CALLBACK useropen, FILE_CLOSE_CALLBACK userclose, FILE_READ_CALLBACK userread, FILE_SEEK_CALLBACK userseek, FILE_ASYNCREAD_CALLBACK userasyncread, FILE_ASYNCCANCEL_CALLBACK userasynccancel, int blockalign)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600058B")]
		[Address(RVA = "0x23EF5A8", Offset = "0x23EF5A8", VA = "0x23EF5A8")]
		public RESULT attachFileSystem(FILE_OPEN_CALLBACK useropen, FILE_CLOSE_CALLBACK userclose, FILE_READ_CALLBACK userread, FILE_SEEK_CALLBACK userseek)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600058C")]
		[Address(RVA = "0x23EF68C", Offset = "0x23EF68C", VA = "0x23EF68C")]
		public RESULT setAdvancedSettings(ref ADVANCEDSETTINGS settings)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600058D")]
		[Address(RVA = "0x23EF7D8", Offset = "0x23EF7D8", VA = "0x23EF7D8")]
		public RESULT getAdvancedSettings(ref ADVANCEDSETTINGS settings)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600058E")]
		[Address(RVA = "0x23EF924", Offset = "0x23EF924", VA = "0x23EF924")]
		public RESULT setCallback(SYSTEM_CALLBACK callback, SYSTEM_CALLBACK_TYPE callbackmask = SYSTEM_CALLBACK_TYPE.ALL)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600058F")]
		[Address(RVA = "0x23EF9CC", Offset = "0x23EF9CC", VA = "0x23EF9CC")]
		public RESULT setPluginPath(string path)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000590")]
		[Address(RVA = "0x23EFBB4", Offset = "0x23EFBB4", VA = "0x23EFBB4")]
		public RESULT loadPlugin(string filename, out uint handle, uint priority = 0u)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000591")]
		[Address(RVA = "0x23EFDCC", Offset = "0x23EFDCC", VA = "0x23EFDCC")]
		public RESULT unloadPlugin(uint handle)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000592")]
		[Address(RVA = "0x23EFE64", Offset = "0x23EFE64", VA = "0x23EFE64")]
		public RESULT getNumNestedPlugins(uint handle, out int count)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000593")]
		[Address(RVA = "0x23EFF04", Offset = "0x23EFF04", VA = "0x23EFF04")]
		public RESULT getNestedPlugin(uint handle, int index, out uint nestedhandle)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000594")]
		[Address(RVA = "0x23EFFB4", Offset = "0x23EFFB4", VA = "0x23EFFB4")]
		public RESULT getNumPlugins(PLUGINTYPE plugintype, out int numplugins)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000595")]
		[Address(RVA = "0x23F0054", Offset = "0x23F0054", VA = "0x23F0054")]
		public RESULT getPluginHandle(PLUGINTYPE plugintype, int index, out uint handle)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000596")]
		[Address(RVA = "0x23F0104", Offset = "0x23F0104", VA = "0x23F0104")]
		public RESULT getPluginInfo(uint handle, out PLUGINTYPE plugintype, out string name, int namelen, out uint version)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000597")]
		[Address(RVA = "0x23F0398", Offset = "0x23F0398", VA = "0x23F0398")]
		public RESULT getPluginInfo(uint handle, out PLUGINTYPE plugintype, out uint version)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000598")]
		[Address(RVA = "0x23F040C", Offset = "0x23F040C", VA = "0x23F040C")]
		public RESULT setOutputByPlugin(uint handle)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000599")]
		[Address(RVA = "0x23F04A4", Offset = "0x23F04A4", VA = "0x23F04A4")]
		public RESULT getOutputByPlugin(out uint handle)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600059A")]
		[Address(RVA = "0x23F053C", Offset = "0x23F053C", VA = "0x23F053C")]
		public RESULT createDSPByPlugin(uint handle, out DSP dsp)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600059B")]
		[Address(RVA = "0x23F05DC", Offset = "0x23F05DC", VA = "0x23F05DC")]
		public RESULT getDSPInfoByPlugin(uint handle, out IntPtr description)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600059C")]
		[Address(RVA = "0x23F067C", Offset = "0x23F067C", VA = "0x23F067C")]
		public RESULT registerDSP(ref DSP_DESCRIPTION description, out uint handle)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600059D")]
		[Address(RVA = "0x23F0778", Offset = "0x23F0778", VA = "0x23F0778")]
		public RESULT init(int maxchannels, INITFLAGS flags, IntPtr extradriverdata)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600059E")]
		[Address(RVA = "0x23F0828", Offset = "0x23F0828", VA = "0x23F0828")]
		public RESULT close()
		{
			return default(RESULT);
		}

		[Token(Token = "0x600059F")]
		[Address(RVA = "0x23F08B0", Offset = "0x23F08B0", VA = "0x23F08B0")]
		public RESULT update()
		{
			return default(RESULT);
		}

		[Token(Token = "0x60005A0")]
		[Address(RVA = "0x23F0938", Offset = "0x23F0938", VA = "0x23F0938")]
		public RESULT setSpeakerPosition(SPEAKER speaker, float x, float y, bool active)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60005A1")]
		[Address(RVA = "0x23F09F4", Offset = "0x23F09F4", VA = "0x23F09F4")]
		public RESULT getSpeakerPosition(SPEAKER speaker, out float x, out float y, out bool active)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60005A2")]
		[Address(RVA = "0x23F0AC0", Offset = "0x23F0AC0", VA = "0x23F0AC0")]
		public RESULT setStreamBufferSize(uint filebuffersize, TIMEUNIT filebuffersizetype)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60005A3")]
		[Address(RVA = "0x23F0B60", Offset = "0x23F0B60", VA = "0x23F0B60")]
		public RESULT getStreamBufferSize(out uint filebuffersize, out TIMEUNIT filebuffersizetype)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60005A4")]
		[Address(RVA = "0x23F0C00", Offset = "0x23F0C00", VA = "0x23F0C00")]
		public RESULT set3DSettings(float dopplerscale, float distancefactor, float rolloffscale)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60005A5")]
		[Address(RVA = "0x23F0CB0", Offset = "0x23F0CB0", VA = "0x23F0CB0")]
		public RESULT get3DSettings(out float dopplerscale, out float distancefactor, out float rolloffscale)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60005A6")]
		[Address(RVA = "0x23F0D60", Offset = "0x23F0D60", VA = "0x23F0D60")]
		public RESULT set3DNumListeners(int numlisteners)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60005A7")]
		[Address(RVA = "0x23F0DF8", Offset = "0x23F0DF8", VA = "0x23F0DF8")]
		public RESULT get3DNumListeners(out int numlisteners)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60005A8")]
		[Address(RVA = "0x23F0E90", Offset = "0x23F0E90", VA = "0x23F0E90")]
		public RESULT set3DListenerAttributes(int listener, ref VECTOR pos, ref VECTOR vel, ref VECTOR forward, ref VECTOR up)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60005A9")]
		[Address(RVA = "0x23F0F58", Offset = "0x23F0F58", VA = "0x23F0F58")]
		public RESULT get3DListenerAttributes(int listener, out VECTOR pos, out VECTOR vel, out VECTOR forward, out VECTOR up)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60005AA")]
		[Address(RVA = "0x23F1020", Offset = "0x23F1020", VA = "0x23F1020")]
		public RESULT set3DRolloffCallback(CB_3D_ROLLOFF_CALLBACK callback)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60005AB")]
		[Address(RVA = "0x23F10C0", Offset = "0x23F10C0", VA = "0x23F10C0")]
		public RESULT mixerSuspend()
		{
			return default(RESULT);
		}

		[Token(Token = "0x60005AC")]
		[Address(RVA = "0x23F1148", Offset = "0x23F1148", VA = "0x23F1148")]
		public RESULT mixerResume()
		{
			return default(RESULT);
		}

		[Token(Token = "0x60005AD")]
		[Address(RVA = "0x23F11D0", Offset = "0x23F11D0", VA = "0x23F11D0")]
		public RESULT getDefaultMixMatrix(SPEAKERMODE sourcespeakermode, SPEAKERMODE targetspeakermode, float[] matrix, int matrixhop)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60005AE")]
		[Address(RVA = "0x23F1290", Offset = "0x23F1290", VA = "0x23F1290")]
		public RESULT getSpeakerModeChannels(SPEAKERMODE mode, out int channels)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60005AF")]
		[Address(RVA = "0x23F1330", Offset = "0x23F1330", VA = "0x23F1330")]
		public RESULT getVersion(out uint version)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60005B0")]
		[Address(RVA = "0x23F13C8", Offset = "0x23F13C8", VA = "0x23F13C8")]
		public RESULT getOutputHandle(out IntPtr handle)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60005B1")]
		[Address(RVA = "0x23F1460", Offset = "0x23F1460", VA = "0x23F1460")]
		public RESULT getChannelsPlaying(out int channels)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60005B2")]
		[Address(RVA = "0x23F1550", Offset = "0x23F1550", VA = "0x23F1550")]
		public RESULT getChannelsPlaying(out int channels, out int realchannels)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60005B3")]
		[Address(RVA = "0x23F15F0", Offset = "0x23F15F0", VA = "0x23F15F0")]
		public RESULT getCPUUsage(out float dsp, out float stream, out float geometry, out float update, out float total)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60005B4")]
		[Address(RVA = "0x23F16B8", Offset = "0x23F16B8", VA = "0x23F16B8")]
		public RESULT getFileUsage(out long sampleBytesRead, out long streamBytesRead, out long otherBytesRead)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60005B5")]
		[Address(RVA = "0x23F1768", Offset = "0x23F1768", VA = "0x23F1768")]
		public RESULT createSound(string name, MODE mode, ref CREATESOUNDEXINFO exinfo, out Sound sound)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60005B6")]
		[Address(RVA = "0x23F19F4", Offset = "0x23F19F4", VA = "0x23F19F4")]
		public RESULT createSound(byte[] data, MODE mode, ref CREATESOUNDEXINFO exinfo, out Sound sound)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60005B7")]
		[Address(RVA = "0x23F19FC", Offset = "0x23F19FC", VA = "0x23F19FC")]
		public RESULT createSound(IntPtr name_or_data, MODE mode, ref CREATESOUNDEXINFO exinfo, out Sound sound)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60005B8")]
		[Address(RVA = "0x23F1B14", Offset = "0x23F1B14", VA = "0x23F1B14")]
		public RESULT createSound(string name, MODE mode, out Sound sound)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60005B9")]
		[Address(RVA = "0x23F1BFC", Offset = "0x23F1BFC", VA = "0x23F1BFC")]
		public RESULT createStream(string name, MODE mode, ref CREATESOUNDEXINFO exinfo, out Sound sound)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60005BA")]
		[Address(RVA = "0x23F1E88", Offset = "0x23F1E88", VA = "0x23F1E88")]
		public RESULT createStream(byte[] data, MODE mode, ref CREATESOUNDEXINFO exinfo, out Sound sound)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60005BB")]
		[Address(RVA = "0x23F1E90", Offset = "0x23F1E90", VA = "0x23F1E90")]
		public RESULT createStream(IntPtr name_or_data, MODE mode, ref CREATESOUNDEXINFO exinfo, out Sound sound)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60005BC")]
		[Address(RVA = "0x23F1FA8", Offset = "0x23F1FA8", VA = "0x23F1FA8")]
		public RESULT createStream(string name, MODE mode, out Sound sound)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60005BD")]
		[Address(RVA = "0x23F2090", Offset = "0x23F2090", VA = "0x23F2090")]
		public RESULT createDSP(ref DSP_DESCRIPTION description, out DSP dsp)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60005BE")]
		[Address(RVA = "0x23F2190", Offset = "0x23F2190", VA = "0x23F2190")]
		public RESULT createDSPByType(DSP_TYPE type, out DSP dsp)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60005BF")]
		[Address(RVA = "0x23F2230", Offset = "0x23F2230", VA = "0x23F2230")]
		public RESULT createChannelGroup(string name, out ChannelGroup channelgroup)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60005C0")]
		[Address(RVA = "0x23F2428", Offset = "0x23F2428", VA = "0x23F2428")]
		public RESULT createSoundGroup(string name, out SoundGroup soundgroup)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60005C1")]
		[Address(RVA = "0x23F2620", Offset = "0x23F2620", VA = "0x23F2620")]
		public RESULT createReverb3D(out Reverb3D reverb)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60005C2")]
		[Address(RVA = "0x23F26B8", Offset = "0x23F26B8", VA = "0x23F26B8")]
		public RESULT playSound(Sound sound, ChannelGroup channelgroup, bool paused, out Channel channel)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60005C3")]
		[Address(RVA = "0x23F2774", Offset = "0x23F2774", VA = "0x23F2774")]
		public RESULT playDSP(DSP dsp, ChannelGroup channelgroup, bool paused, out Channel channel)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60005C4")]
		[Address(RVA = "0x23F2830", Offset = "0x23F2830", VA = "0x23F2830")]
		public RESULT getChannel(int channelid, out Channel channel)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60005C5")]
		[Address(RVA = "0x23F28D0", Offset = "0x23F28D0", VA = "0x23F28D0")]
		public RESULT getMasterChannelGroup(out ChannelGroup channelgroup)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60005C6")]
		[Address(RVA = "0x23F2968", Offset = "0x23F2968", VA = "0x23F2968")]
		public RESULT getMasterSoundGroup(out SoundGroup soundgroup)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60005C7")]
		[Address(RVA = "0x23F2A00", Offset = "0x23F2A00", VA = "0x23F2A00")]
		public RESULT attachChannelGroupToPort(uint portType, ulong portIndex, ChannelGroup channelgroup, bool passThru = false)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60005C8")]
		[Address(RVA = "0x23F2ABC", Offset = "0x23F2ABC", VA = "0x23F2ABC")]
		public RESULT detachChannelGroupFromPort(ChannelGroup channelgroup)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60005C9")]
		[Address(RVA = "0x23F2B54", Offset = "0x23F2B54", VA = "0x23F2B54")]
		public RESULT setReverbProperties(int instance, ref REVERB_PROPERTIES prop)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60005CA")]
		[Address(RVA = "0x23F2BF4", Offset = "0x23F2BF4", VA = "0x23F2BF4")]
		public RESULT getReverbProperties(int instance, out REVERB_PROPERTIES prop)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60005CB")]
		[Address(RVA = "0x23F2C94", Offset = "0x23F2C94", VA = "0x23F2C94")]
		public RESULT lockDSP()
		{
			return default(RESULT);
		}

		[Token(Token = "0x60005CC")]
		[Address(RVA = "0x23F2D1C", Offset = "0x23F2D1C", VA = "0x23F2D1C")]
		public RESULT unlockDSP()
		{
			return default(RESULT);
		}

		[Token(Token = "0x60005CD")]
		[Address(RVA = "0x23F2DA4", Offset = "0x23F2DA4", VA = "0x23F2DA4")]
		public RESULT getRecordNumDrivers(out int numdrivers, out int numconnected)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60005CE")]
		[Address(RVA = "0x23F2E44", Offset = "0x23F2E44", VA = "0x23F2E44")]
		public RESULT getRecordDriverInfo(int id, out string name, int namelen, out Guid guid, out int systemrate, out SPEAKERMODE speakermode, out int speakermodechannels, out DRIVER_STATE state)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60005CF")]
		[Address(RVA = "0x23F3120", Offset = "0x23F3120", VA = "0x23F3120")]
		public RESULT getRecordDriverInfo(int id, out Guid guid, out int systemrate, out SPEAKERMODE speakermode, out int speakermodechannels, out DRIVER_STATE state)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60005D0")]
		[Address(RVA = "0x23F31C0", Offset = "0x23F31C0", VA = "0x23F31C0")]
		public RESULT getRecordPosition(int id, out uint position)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60005D1")]
		[Address(RVA = "0x23F3260", Offset = "0x23F3260", VA = "0x23F3260")]
		public RESULT recordStart(int id, Sound sound, bool loop)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60005D2")]
		[Address(RVA = "0x23F3310", Offset = "0x23F3310", VA = "0x23F3310")]
		public RESULT recordStop(int id)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60005D3")]
		[Address(RVA = "0x23F33A8", Offset = "0x23F33A8", VA = "0x23F33A8")]
		public RESULT isRecording(int id, out bool recording)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60005D4")]
		[Address(RVA = "0x23F345C", Offset = "0x23F345C", VA = "0x23F345C")]
		public RESULT createGeometry(int maxpolygons, int maxvertices, out Geometry geometry)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60005D5")]
		[Address(RVA = "0x23F350C", Offset = "0x23F350C", VA = "0x23F350C")]
		public RESULT setGeometrySettings(float maxworldsize)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60005D6")]
		[Address(RVA = "0x23F35A4", Offset = "0x23F35A4", VA = "0x23F35A4")]
		public RESULT getGeometrySettings(out float maxworldsize)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60005D7")]
		[Address(RVA = "0x23F363C", Offset = "0x23F363C", VA = "0x23F363C")]
		public RESULT loadGeometry(IntPtr data, int datasize, out Geometry geometry)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60005D8")]
		[Address(RVA = "0x23F36EC", Offset = "0x23F36EC", VA = "0x23F36EC")]
		public RESULT getGeometryOcclusion(ref VECTOR listener, ref VECTOR source, out float direct, out float reverb)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60005D9")]
		[Address(RVA = "0x23F37A4", Offset = "0x23F37A4", VA = "0x23F37A4")]
		public RESULT setNetworkProxy(string proxy)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60005DA")]
		[Address(RVA = "0x23F398C", Offset = "0x23F398C", VA = "0x23F398C")]
		public RESULT getNetworkProxy(out string proxy, int proxylen)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60005DB")]
		[Address(RVA = "0x23F3BD8", Offset = "0x23F3BD8", VA = "0x23F3BD8")]
		public RESULT setNetworkTimeout(int timeout)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60005DC")]
		[Address(RVA = "0x23F3C70", Offset = "0x23F3C70", VA = "0x23F3C70")]
		public RESULT getNetworkTimeout(out int timeout)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60005DD")]
		[Address(RVA = "0x23F3D08", Offset = "0x23F3D08", VA = "0x23F3D08")]
		public RESULT setUserData(IntPtr userdata)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60005DE")]
		[Address(RVA = "0x23F3DA0", Offset = "0x23F3DA0", VA = "0x23F3DA0")]
		public RESULT getUserData(out IntPtr userdata)
		{
			return default(RESULT);
		}

		[PreserveSig]
		[Token(Token = "0x60005DF")]
		[Address(RVA = "0x23EE9D8", Offset = "0x23EE9D8", VA = "0x23EE9D8")]
		private static extern RESULT FMOD5_System_Release(IntPtr system);

		[PreserveSig]
		[Token(Token = "0x60005E0")]
		[Address(RVA = "0x23EEA60", Offset = "0x23EEA60", VA = "0x23EEA60")]
		private static extern RESULT FMOD5_System_SetOutput(IntPtr system, OUTPUTTYPE output);

		[PreserveSig]
		[Token(Token = "0x60005E1")]
		[Address(RVA = "0x23EEAF8", Offset = "0x23EEAF8", VA = "0x23EEAF8")]
		private static extern RESULT FMOD5_System_GetOutput(IntPtr system, out OUTPUTTYPE output);

		[PreserveSig]
		[Token(Token = "0x60005E2")]
		[Address(RVA = "0x23EEB90", Offset = "0x23EEB90", VA = "0x23EEB90")]
		private static extern RESULT FMOD5_System_GetNumDrivers(IntPtr system, out int numdrivers);

		[PreserveSig]
		[Token(Token = "0x60005E3")]
		[Address(RVA = "0x23EEE14", Offset = "0x23EEE14", VA = "0x23EEE14")]
		private static extern RESULT FMOD5_System_GetDriverInfo(IntPtr system, int id, IntPtr name, int namelen, out Guid guid, out int systemrate, out SPEAKERMODE speakermode, out int speakermodechannels);

		[PreserveSig]
		[Token(Token = "0x60005E4")]
		[Address(RVA = "0x23EEF8C", Offset = "0x23EEF8C", VA = "0x23EEF8C")]
		private static extern RESULT FMOD5_System_SetDriver(IntPtr system, int driver);

		[PreserveSig]
		[Token(Token = "0x60005E5")]
		[Address(RVA = "0x23EF024", Offset = "0x23EF024", VA = "0x23EF024")]
		private static extern RESULT FMOD5_System_GetDriver(IntPtr system, out int driver);

		[PreserveSig]
		[Token(Token = "0x60005E6")]
		[Address(RVA = "0x23EF0BC", Offset = "0x23EF0BC", VA = "0x23EF0BC")]
		private static extern RESULT FMOD5_System_SetSoftwareChannels(IntPtr system, int numsoftwarechannels);

		[PreserveSig]
		[Token(Token = "0x60005E7")]
		[Address(RVA = "0x23EF154", Offset = "0x23EF154", VA = "0x23EF154")]
		private static extern RESULT FMOD5_System_GetSoftwareChannels(IntPtr system, out int numsoftwarechannels);

		[PreserveSig]
		[Token(Token = "0x60005E8")]
		[Address(RVA = "0x23EF1EC", Offset = "0x23EF1EC", VA = "0x23EF1EC")]
		private static extern RESULT FMOD5_System_SetSoftwareFormat(IntPtr system, int samplerate, SPEAKERMODE speakermode, int numrawspeakers);

		[PreserveSig]
		[Token(Token = "0x60005E9")]
		[Address(RVA = "0x23EF29C", Offset = "0x23EF29C", VA = "0x23EF29C")]
		private static extern RESULT FMOD5_System_GetSoftwareFormat(IntPtr system, out int samplerate, out SPEAKERMODE speakermode, out int numrawspeakers);

		[PreserveSig]
		[Token(Token = "0x60005EA")]
		[Address(RVA = "0x23EF34C", Offset = "0x23EF34C", VA = "0x23EF34C")]
		private static extern RESULT FMOD5_System_SetDSPBufferSize(IntPtr system, uint bufferlength, int numbuffers);

		[PreserveSig]
		[Token(Token = "0x60005EB")]
		[Address(RVA = "0x23EF3EC", Offset = "0x23EF3EC", VA = "0x23EF3EC")]
		private static extern RESULT FMOD5_System_GetDSPBufferSize(IntPtr system, out uint bufferlength, out int numbuffers);

		[PreserveSig]
		[Token(Token = "0x60005EC")]
		[Address(RVA = "0x23EF48C", Offset = "0x23EF48C", VA = "0x23EF48C")]
		private static extern RESULT FMOD5_System_SetFileSystem(IntPtr system, FILE_OPEN_CALLBACK useropen, FILE_CLOSE_CALLBACK userclose, FILE_READ_CALLBACK userread, FILE_SEEK_CALLBACK userseek, FILE_ASYNCREAD_CALLBACK userasyncread, FILE_ASYNCCANCEL_CALLBACK userasynccancel, int blockalign);

		[PreserveSig]
		[Token(Token = "0x60005ED")]
		[Address(RVA = "0x23EF5B0", Offset = "0x23EF5B0", VA = "0x23EF5B0")]
		private static extern RESULT FMOD5_System_AttachFileSystem(IntPtr system, FILE_OPEN_CALLBACK useropen, FILE_CLOSE_CALLBACK userclose, FILE_READ_CALLBACK userread, FILE_SEEK_CALLBACK userseek);

		[PreserveSig]
		[Token(Token = "0x60005EE")]
		[Address(RVA = "0x23EF748", Offset = "0x23EF748", VA = "0x23EF748")]
		private static extern RESULT FMOD5_System_SetAdvancedSettings(IntPtr system, ref ADVANCEDSETTINGS settings);

		[PreserveSig]
		[Token(Token = "0x60005EF")]
		[Address(RVA = "0x23EF894", Offset = "0x23EF894", VA = "0x23EF894")]
		private static extern RESULT FMOD5_System_GetAdvancedSettings(IntPtr system, ref ADVANCEDSETTINGS settings);

		[PreserveSig]
		[Token(Token = "0x60005F0")]
		[Address(RVA = "0x23EF92C", Offset = "0x23EF92C", VA = "0x23EF92C")]
		private static extern RESULT FMOD5_System_SetCallback(IntPtr system, SYSTEM_CALLBACK callback, SYSTEM_CALLBACK_TYPE callbackmask);

		[PreserveSig]
		[Token(Token = "0x60005F1")]
		[Address(RVA = "0x23EFB1C", Offset = "0x23EFB1C", VA = "0x23EFB1C")]
		private static extern RESULT FMOD5_System_SetPluginPath(IntPtr system, byte[] path);

		[PreserveSig]
		[Token(Token = "0x60005F2")]
		[Address(RVA = "0x23EFD1C", Offset = "0x23EFD1C", VA = "0x23EFD1C")]
		private static extern RESULT FMOD5_System_LoadPlugin(IntPtr system, byte[] filename, out uint handle, uint priority);

		[PreserveSig]
		[Token(Token = "0x60005F3")]
		[Address(RVA = "0x23EFDD4", Offset = "0x23EFDD4", VA = "0x23EFDD4")]
		private static extern RESULT FMOD5_System_UnloadPlugin(IntPtr system, uint handle);

		[PreserveSig]
		[Token(Token = "0x60005F4")]
		[Address(RVA = "0x23EFE6C", Offset = "0x23EFE6C", VA = "0x23EFE6C")]
		private static extern RESULT FMOD5_System_GetNumNestedPlugins(IntPtr system, uint handle, out int count);

		[PreserveSig]
		[Token(Token = "0x60005F5")]
		[Address(RVA = "0x23EFF0C", Offset = "0x23EFF0C", VA = "0x23EFF0C")]
		private static extern RESULT FMOD5_System_GetNestedPlugin(IntPtr system, uint handle, int index, out uint nestedhandle);

		[PreserveSig]
		[Token(Token = "0x60005F6")]
		[Address(RVA = "0x23EFFBC", Offset = "0x23EFFBC", VA = "0x23EFFBC")]
		private static extern RESULT FMOD5_System_GetNumPlugins(IntPtr system, PLUGINTYPE plugintype, out int numplugins);

		[PreserveSig]
		[Token(Token = "0x60005F7")]
		[Address(RVA = "0x23F005C", Offset = "0x23F005C", VA = "0x23F005C")]
		private static extern RESULT FMOD5_System_GetPluginHandle(IntPtr system, PLUGINTYPE plugintype, int index, out uint handle);

		[PreserveSig]
		[Token(Token = "0x60005F8")]
		[Address(RVA = "0x23F02D8", Offset = "0x23F02D8", VA = "0x23F02D8")]
		private static extern RESULT FMOD5_System_GetPluginInfo(IntPtr system, uint handle, out PLUGINTYPE plugintype, IntPtr name, int namelen, out uint version);

		[PreserveSig]
		[Token(Token = "0x60005F9")]
		[Address(RVA = "0x23F0414", Offset = "0x23F0414", VA = "0x23F0414")]
		private static extern RESULT FMOD5_System_SetOutputByPlugin(IntPtr system, uint handle);

		[PreserveSig]
		[Token(Token = "0x60005FA")]
		[Address(RVA = "0x23F04AC", Offset = "0x23F04AC", VA = "0x23F04AC")]
		private static extern RESULT FMOD5_System_GetOutputByPlugin(IntPtr system, out uint handle);

		[PreserveSig]
		[Token(Token = "0x60005FB")]
		[Address(RVA = "0x23F0544", Offset = "0x23F0544", VA = "0x23F0544")]
		private static extern RESULT FMOD5_System_CreateDSPByPlugin(IntPtr system, uint handle, out IntPtr dsp);

		[PreserveSig]
		[Token(Token = "0x60005FC")]
		[Address(RVA = "0x23F05E4", Offset = "0x23F05E4", VA = "0x23F05E4")]
		private static extern RESULT FMOD5_System_GetDSPInfoByPlugin(IntPtr system, uint handle, out IntPtr description);

		[PreserveSig]
		[Token(Token = "0x60005FD")]
		[Address(RVA = "0x23F0684", Offset = "0x23F0684", VA = "0x23F0684")]
		private static extern RESULT FMOD5_System_RegisterDSP(IntPtr system, ref DSP_DESCRIPTION description, out uint handle);

		[PreserveSig]
		[Token(Token = "0x60005FE")]
		[Address(RVA = "0x23F0780", Offset = "0x23F0780", VA = "0x23F0780")]
		private static extern RESULT FMOD5_System_Init(IntPtr system, int maxchannels, INITFLAGS flags, IntPtr extradriverdata);

		[PreserveSig]
		[Token(Token = "0x60005FF")]
		[Address(RVA = "0x23F0830", Offset = "0x23F0830", VA = "0x23F0830")]
		private static extern RESULT FMOD5_System_Close(IntPtr system);

		[PreserveSig]
		[Token(Token = "0x6000600")]
		[Address(RVA = "0x23F08B8", Offset = "0x23F08B8", VA = "0x23F08B8")]
		private static extern RESULT FMOD5_System_Update(IntPtr system);

		[PreserveSig]
		[Token(Token = "0x6000601")]
		[Address(RVA = "0x23F0944", Offset = "0x23F0944", VA = "0x23F0944")]
		private static extern RESULT FMOD5_System_SetSpeakerPosition(IntPtr system, SPEAKER speaker, float x, float y, bool active);

		[PreserveSig]
		[Token(Token = "0x6000602")]
		[Address(RVA = "0x23F09FC", Offset = "0x23F09FC", VA = "0x23F09FC")]
		private static extern RESULT FMOD5_System_GetSpeakerPosition(IntPtr system, SPEAKER speaker, out float x, out float y, out bool active);

		[PreserveSig]
		[Token(Token = "0x6000603")]
		[Address(RVA = "0x23F0AC8", Offset = "0x23F0AC8", VA = "0x23F0AC8")]
		private static extern RESULT FMOD5_System_SetStreamBufferSize(IntPtr system, uint filebuffersize, TIMEUNIT filebuffersizetype);

		[PreserveSig]
		[Token(Token = "0x6000604")]
		[Address(RVA = "0x23F0B68", Offset = "0x23F0B68", VA = "0x23F0B68")]
		private static extern RESULT FMOD5_System_GetStreamBufferSize(IntPtr system, out uint filebuffersize, out TIMEUNIT filebuffersizetype);

		[PreserveSig]
		[Token(Token = "0x6000605")]
		[Address(RVA = "0x23F0C08", Offset = "0x23F0C08", VA = "0x23F0C08")]
		private static extern RESULT FMOD5_System_Set3DSettings(IntPtr system, float dopplerscale, float distancefactor, float rolloffscale);

		[PreserveSig]
		[Token(Token = "0x6000606")]
		[Address(RVA = "0x23F0CB8", Offset = "0x23F0CB8", VA = "0x23F0CB8")]
		private static extern RESULT FMOD5_System_Get3DSettings(IntPtr system, out float dopplerscale, out float distancefactor, out float rolloffscale);

		[PreserveSig]
		[Token(Token = "0x6000607")]
		[Address(RVA = "0x23F0D68", Offset = "0x23F0D68", VA = "0x23F0D68")]
		private static extern RESULT FMOD5_System_Set3DNumListeners(IntPtr system, int numlisteners);

		[PreserveSig]
		[Token(Token = "0x6000608")]
		[Address(RVA = "0x23F0E00", Offset = "0x23F0E00", VA = "0x23F0E00")]
		private static extern RESULT FMOD5_System_Get3DNumListeners(IntPtr system, out int numlisteners);

		[PreserveSig]
		[Token(Token = "0x6000609")]
		[Address(RVA = "0x23F0E98", Offset = "0x23F0E98", VA = "0x23F0E98")]
		private static extern RESULT FMOD5_System_Set3DListenerAttributes(IntPtr system, int listener, ref VECTOR pos, ref VECTOR vel, ref VECTOR forward, ref VECTOR up);

		[PreserveSig]
		[Token(Token = "0x600060A")]
		[Address(RVA = "0x23F0F60", Offset = "0x23F0F60", VA = "0x23F0F60")]
		private static extern RESULT FMOD5_System_Get3DListenerAttributes(IntPtr system, int listener, out VECTOR pos, out VECTOR vel, out VECTOR forward, out VECTOR up);

		[PreserveSig]
		[Token(Token = "0x600060B")]
		[Address(RVA = "0x23F1028", Offset = "0x23F1028", VA = "0x23F1028")]
		private static extern RESULT FMOD5_System_Set3DRolloffCallback(IntPtr system, CB_3D_ROLLOFF_CALLBACK callback);

		[PreserveSig]
		[Token(Token = "0x600060C")]
		[Address(RVA = "0x23F10C8", Offset = "0x23F10C8", VA = "0x23F10C8")]
		private static extern RESULT FMOD5_System_MixerSuspend(IntPtr system);

		[PreserveSig]
		[Token(Token = "0x600060D")]
		[Address(RVA = "0x23F1150", Offset = "0x23F1150", VA = "0x23F1150")]
		private static extern RESULT FMOD5_System_MixerResume(IntPtr system);

		[PreserveSig]
		[Token(Token = "0x600060E")]
		[Address(RVA = "0x23F11D8", Offset = "0x23F11D8", VA = "0x23F11D8")]
		private static extern RESULT FMOD5_System_GetDefaultMixMatrix(IntPtr system, SPEAKERMODE sourcespeakermode, SPEAKERMODE targetspeakermode, float[] matrix, int matrixhop);

		[PreserveSig]
		[Token(Token = "0x600060F")]
		[Address(RVA = "0x23F1298", Offset = "0x23F1298", VA = "0x23F1298")]
		private static extern RESULT FMOD5_System_GetSpeakerModeChannels(IntPtr system, SPEAKERMODE mode, out int channels);

		[PreserveSig]
		[Token(Token = "0x6000610")]
		[Address(RVA = "0x23F1338", Offset = "0x23F1338", VA = "0x23F1338")]
		private static extern RESULT FMOD5_System_GetVersion(IntPtr system, out uint version);

		[PreserveSig]
		[Token(Token = "0x6000611")]
		[Address(RVA = "0x23F13D0", Offset = "0x23F13D0", VA = "0x23F13D0")]
		private static extern RESULT FMOD5_System_GetOutputHandle(IntPtr system, out IntPtr handle);

		[PreserveSig]
		[Token(Token = "0x6000612")]
		[Address(RVA = "0x23F14B8", Offset = "0x23F14B8", VA = "0x23F14B8")]
		private static extern RESULT FMOD5_System_GetChannelsPlaying(IntPtr system, out int channels, IntPtr zero);

		[PreserveSig]
		[Token(Token = "0x6000613")]
		[Address(RVA = "0x23F1558", Offset = "0x23F1558", VA = "0x23F1558")]
		private static extern RESULT FMOD5_System_GetChannelsPlaying(IntPtr system, out int channels, out int realchannels);

		[PreserveSig]
		[Token(Token = "0x6000614")]
		[Address(RVA = "0x23F15F8", Offset = "0x23F15F8", VA = "0x23F15F8")]
		private static extern RESULT FMOD5_System_GetCPUUsage(IntPtr system, out float dsp, out float stream, out float geometry, out float update, out float total);

		[PreserveSig]
		[Token(Token = "0x6000615")]
		[Address(RVA = "0x23F16C0", Offset = "0x23F16C0", VA = "0x23F16C0")]
		private static extern RESULT FMOD5_System_GetFileUsage(IntPtr system, out long sampleBytesRead, out long streamBytesRead, out long otherBytesRead);

		[PreserveSig]
		[Token(Token = "0x6000616")]
		[Address(RVA = "0x23F18D8", Offset = "0x23F18D8", VA = "0x23F18D8")]
		private static extern RESULT FMOD5_System_CreateSound(IntPtr system, byte[] name_or_data, MODE mode, ref CREATESOUNDEXINFO exinfo, out IntPtr sound);

		[PreserveSig]
		[Token(Token = "0x6000617")]
		[Address(RVA = "0x23F1A04", Offset = "0x23F1A04", VA = "0x23F1A04")]
		private static extern RESULT FMOD5_System_CreateSound(IntPtr system, IntPtr name_or_data, MODE mode, ref CREATESOUNDEXINFO exinfo, out IntPtr sound);

		[PreserveSig]
		[Token(Token = "0x6000618")]
		[Address(RVA = "0x23F1D6C", Offset = "0x23F1D6C", VA = "0x23F1D6C")]
		private static extern RESULT FMOD5_System_CreateStream(IntPtr system, byte[] name_or_data, MODE mode, ref CREATESOUNDEXINFO exinfo, out IntPtr sound);

		[PreserveSig]
		[Token(Token = "0x6000619")]
		[Address(RVA = "0x23F1E98", Offset = "0x23F1E98", VA = "0x23F1E98")]
		private static extern RESULT FMOD5_System_CreateStream(IntPtr system, IntPtr name_or_data, MODE mode, ref CREATESOUNDEXINFO exinfo, out IntPtr sound);

		[PreserveSig]
		[Token(Token = "0x600061A")]
		[Address(RVA = "0x23F2098", Offset = "0x23F2098", VA = "0x23F2098")]
		private static extern RESULT FMOD5_System_CreateDSP(IntPtr system, ref DSP_DESCRIPTION description, out IntPtr dsp);

		[PreserveSig]
		[Token(Token = "0x600061B")]
		[Address(RVA = "0x23F2198", Offset = "0x23F2198", VA = "0x23F2198")]
		private static extern RESULT FMOD5_System_CreateDSPByType(IntPtr system, DSP_TYPE type, out IntPtr dsp);

		[PreserveSig]
		[Token(Token = "0x600061C")]
		[Address(RVA = "0x23F2388", Offset = "0x23F2388", VA = "0x23F2388")]
		private static extern RESULT FMOD5_System_CreateChannelGroup(IntPtr system, byte[] name, out IntPtr channelgroup);

		[PreserveSig]
		[Token(Token = "0x600061D")]
		[Address(RVA = "0x23F2580", Offset = "0x23F2580", VA = "0x23F2580")]
		private static extern RESULT FMOD5_System_CreateSoundGroup(IntPtr system, byte[] name, out IntPtr soundgroup);

		[PreserveSig]
		[Token(Token = "0x600061E")]
		[Address(RVA = "0x23F2628", Offset = "0x23F2628", VA = "0x23F2628")]
		private static extern RESULT FMOD5_System_CreateReverb3D(IntPtr system, out IntPtr reverb);

		[PreserveSig]
		[Token(Token = "0x600061F")]
		[Address(RVA = "0x23F26C4", Offset = "0x23F26C4", VA = "0x23F26C4")]
		private static extern RESULT FMOD5_System_PlaySound(IntPtr system, IntPtr sound, IntPtr channelgroup, bool paused, out IntPtr channel);

		[PreserveSig]
		[Token(Token = "0x6000620")]
		[Address(RVA = "0x23F2780", Offset = "0x23F2780", VA = "0x23F2780")]
		private static extern RESULT FMOD5_System_PlayDSP(IntPtr system, IntPtr dsp, IntPtr channelgroup, bool paused, out IntPtr channel);

		[PreserveSig]
		[Token(Token = "0x6000621")]
		[Address(RVA = "0x23F2838", Offset = "0x23F2838", VA = "0x23F2838")]
		private static extern RESULT FMOD5_System_GetChannel(IntPtr system, int channelid, out IntPtr channel);

		[PreserveSig]
		[Token(Token = "0x6000622")]
		[Address(RVA = "0x23F28D8", Offset = "0x23F28D8", VA = "0x23F28D8")]
		private static extern RESULT FMOD5_System_GetMasterChannelGroup(IntPtr system, out IntPtr channelgroup);

		[PreserveSig]
		[Token(Token = "0x6000623")]
		[Address(RVA = "0x23F2970", Offset = "0x23F2970", VA = "0x23F2970")]
		private static extern RESULT FMOD5_System_GetMasterSoundGroup(IntPtr system, out IntPtr soundgroup);

		[PreserveSig]
		[Token(Token = "0x6000624")]
		[Address(RVA = "0x23F2A0C", Offset = "0x23F2A0C", VA = "0x23F2A0C")]
		private static extern RESULT FMOD5_System_AttachChannelGroupToPort(IntPtr system, uint portType, ulong portIndex, IntPtr channelgroup, bool passThru);

		[PreserveSig]
		[Token(Token = "0x6000625")]
		[Address(RVA = "0x23F2AC4", Offset = "0x23F2AC4", VA = "0x23F2AC4")]
		private static extern RESULT FMOD5_System_DetachChannelGroupFromPort(IntPtr system, IntPtr channelgroup);

		[PreserveSig]
		[Token(Token = "0x6000626")]
		[Address(RVA = "0x23F2B5C", Offset = "0x23F2B5C", VA = "0x23F2B5C")]
		private static extern RESULT FMOD5_System_SetReverbProperties(IntPtr system, int instance, ref REVERB_PROPERTIES prop);

		[PreserveSig]
		[Token(Token = "0x6000627")]
		[Address(RVA = "0x23F2BFC", Offset = "0x23F2BFC", VA = "0x23F2BFC")]
		private static extern RESULT FMOD5_System_GetReverbProperties(IntPtr system, int instance, out REVERB_PROPERTIES prop);

		[PreserveSig]
		[Token(Token = "0x6000628")]
		[Address(RVA = "0x23F2C9C", Offset = "0x23F2C9C", VA = "0x23F2C9C")]
		private static extern RESULT FMOD5_System_LockDSP(IntPtr system);

		[PreserveSig]
		[Token(Token = "0x6000629")]
		[Address(RVA = "0x23F2D24", Offset = "0x23F2D24", VA = "0x23F2D24")]
		private static extern RESULT FMOD5_System_UnlockDSP(IntPtr system);

		[PreserveSig]
		[Token(Token = "0x600062A")]
		[Address(RVA = "0x23F2DAC", Offset = "0x23F2DAC", VA = "0x23F2DAC")]
		private static extern RESULT FMOD5_System_GetRecordNumDrivers(IntPtr system, out int numdrivers, out int numconnected);

		[PreserveSig]
		[Token(Token = "0x600062B")]
		[Address(RVA = "0x23F3040", Offset = "0x23F3040", VA = "0x23F3040")]
		private static extern RESULT FMOD5_System_GetRecordDriverInfo(IntPtr system, int id, IntPtr name, int namelen, out Guid guid, out int systemrate, out SPEAKERMODE speakermode, out int speakermodechannels, out DRIVER_STATE state);

		[PreserveSig]
		[Token(Token = "0x600062C")]
		[Address(RVA = "0x23F31C8", Offset = "0x23F31C8", VA = "0x23F31C8")]
		private static extern RESULT FMOD5_System_GetRecordPosition(IntPtr system, int id, out uint position);

		[PreserveSig]
		[Token(Token = "0x600062D")]
		[Address(RVA = "0x23F326C", Offset = "0x23F326C", VA = "0x23F326C")]
		private static extern RESULT FMOD5_System_RecordStart(IntPtr system, int id, IntPtr sound, bool loop);

		[PreserveSig]
		[Token(Token = "0x600062E")]
		[Address(RVA = "0x23F3318", Offset = "0x23F3318", VA = "0x23F3318")]
		private static extern RESULT FMOD5_System_RecordStop(IntPtr system, int id);

		[PreserveSig]
		[Token(Token = "0x600062F")]
		[Address(RVA = "0x23F33B0", Offset = "0x23F33B0", VA = "0x23F33B0")]
		private static extern RESULT FMOD5_System_IsRecording(IntPtr system, int id, out bool recording);

		[PreserveSig]
		[Token(Token = "0x6000630")]
		[Address(RVA = "0x23F3464", Offset = "0x23F3464", VA = "0x23F3464")]
		private static extern RESULT FMOD5_System_CreateGeometry(IntPtr system, int maxpolygons, int maxvertices, out IntPtr geometry);

		[PreserveSig]
		[Token(Token = "0x6000631")]
		[Address(RVA = "0x23F3514", Offset = "0x23F3514", VA = "0x23F3514")]
		private static extern RESULT FMOD5_System_SetGeometrySettings(IntPtr system, float maxworldsize);

		[PreserveSig]
		[Token(Token = "0x6000632")]
		[Address(RVA = "0x23F35AC", Offset = "0x23F35AC", VA = "0x23F35AC")]
		private static extern RESULT FMOD5_System_GetGeometrySettings(IntPtr system, out float maxworldsize);

		[PreserveSig]
		[Token(Token = "0x6000633")]
		[Address(RVA = "0x23F3644", Offset = "0x23F3644", VA = "0x23F3644")]
		private static extern RESULT FMOD5_System_LoadGeometry(IntPtr system, IntPtr data, int datasize, out IntPtr geometry);

		[PreserveSig]
		[Token(Token = "0x6000634")]
		[Address(RVA = "0x23F36F4", Offset = "0x23F36F4", VA = "0x23F36F4")]
		private static extern RESULT FMOD5_System_GetGeometryOcclusion(IntPtr system, ref VECTOR listener, ref VECTOR source, out float direct, out float reverb);

		[PreserveSig]
		[Token(Token = "0x6000635")]
		[Address(RVA = "0x23F38F4", Offset = "0x23F38F4", VA = "0x23F38F4")]
		private static extern RESULT FMOD5_System_SetNetworkProxy(IntPtr system, byte[] proxy);

		[PreserveSig]
		[Token(Token = "0x6000636")]
		[Address(RVA = "0x23F3B40", Offset = "0x23F3B40", VA = "0x23F3B40")]
		private static extern RESULT FMOD5_System_GetNetworkProxy(IntPtr system, IntPtr proxy, int proxylen);

		[PreserveSig]
		[Token(Token = "0x6000637")]
		[Address(RVA = "0x23F3BE0", Offset = "0x23F3BE0", VA = "0x23F3BE0")]
		private static extern RESULT FMOD5_System_SetNetworkTimeout(IntPtr system, int timeout);

		[PreserveSig]
		[Token(Token = "0x6000638")]
		[Address(RVA = "0x23F3C78", Offset = "0x23F3C78", VA = "0x23F3C78")]
		private static extern RESULT FMOD5_System_GetNetworkTimeout(IntPtr system, out int timeout);

		[PreserveSig]
		[Token(Token = "0x6000639")]
		[Address(RVA = "0x23F3D10", Offset = "0x23F3D10", VA = "0x23F3D10")]
		private static extern RESULT FMOD5_System_SetUserData(IntPtr system, IntPtr userdata);

		[PreserveSig]
		[Token(Token = "0x600063A")]
		[Address(RVA = "0x23F3DA8", Offset = "0x23F3DA8", VA = "0x23F3DA8")]
		private static extern RESULT FMOD5_System_GetUserData(IntPtr system, out IntPtr userdata);

		[Token(Token = "0x600063B")]
		[Address(RVA = "0x23F3E38", Offset = "0x23F3E38", VA = "0x23F3E38")]
		public bool hasHandle()
		{
			return default(bool);
		}

		[Token(Token = "0x600063C")]
		[Address(RVA = "0x23F3E84", Offset = "0x23F3E84", VA = "0x23F3E84")]
		public void clearHandle()
		{
		}
	}
	[Token(Token = "0x20000C3")]
	public struct Sound
	{
		[Token(Token = "0x400060C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public IntPtr handle;

		[Token(Token = "0x600063D")]
		[Address(RVA = "0x325D980", Offset = "0x325D980", VA = "0x325D980")]
		public RESULT release()
		{
			return default(RESULT);
		}

		[Token(Token = "0x600063E")]
		[Address(RVA = "0x325DA08", Offset = "0x325DA08", VA = "0x325DA08")]
		public RESULT getSystemObject(out System system)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600063F")]
		[Address(RVA = "0x325DAA0", Offset = "0x325DAA0", VA = "0x325DAA0")]
		public RESULT @lock(uint offset, uint length, out IntPtr ptr1, out IntPtr ptr2, out uint len1, out uint len2)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000640")]
		[Address(RVA = "0x325DB70", Offset = "0x325DB70", VA = "0x325DB70")]
		public RESULT unlock(IntPtr ptr1, IntPtr ptr2, uint len1, uint len2)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000641")]
		[Address(RVA = "0x325DC28", Offset = "0x325DC28", VA = "0x325DC28")]
		public RESULT setDefaults(float frequency, int priority)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000642")]
		[Address(RVA = "0x325DCD0", Offset = "0x325DCD0", VA = "0x325DCD0")]
		public RESULT getDefaults(out float frequency, out int priority)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000643")]
		[Address(RVA = "0x325DD70", Offset = "0x325DD70", VA = "0x325DD70")]
		public RESULT set3DMinMaxDistance(float min, float max)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000644")]
		[Address(RVA = "0x325DE10", Offset = "0x325DE10", VA = "0x325DE10")]
		public RESULT get3DMinMaxDistance(out float min, out float max)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000645")]
		[Address(RVA = "0x325DEB0", Offset = "0x325DEB0", VA = "0x325DEB0")]
		public RESULT set3DConeSettings(float insideconeangle, float outsideconeangle, float outsidevolume)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000646")]
		[Address(RVA = "0x325DF60", Offset = "0x325DF60", VA = "0x325DF60")]
		public RESULT get3DConeSettings(out float insideconeangle, out float outsideconeangle, out float outsidevolume)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000647")]
		[Address(RVA = "0x325E010", Offset = "0x325E010", VA = "0x325E010")]
		public RESULT set3DCustomRolloff(ref VECTOR points, int numpoints)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000648")]
		[Address(RVA = "0x325E0B0", Offset = "0x325E0B0", VA = "0x325E0B0")]
		public RESULT get3DCustomRolloff(out IntPtr points, out int numpoints)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000649")]
		[Address(RVA = "0x325E150", Offset = "0x325E150", VA = "0x325E150")]
		public RESULT getSubSound(int index, out Sound subsound)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600064A")]
		[Address(RVA = "0x325E1F0", Offset = "0x325E1F0", VA = "0x325E1F0")]
		public RESULT getSubSoundParent(out Sound parentsound)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600064B")]
		[Address(RVA = "0x325E288", Offset = "0x325E288", VA = "0x325E288")]
		public RESULT getName(out string name, int namelen)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600064C")]
		[Address(RVA = "0x325E94C", Offset = "0x325E94C", VA = "0x325E94C")]
		public RESULT getLength(out uint length, TIMEUNIT lengthtype)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600064D")]
		[Address(RVA = "0x325E9EC", Offset = "0x325E9EC", VA = "0x325E9EC")]
		public RESULT getFormat(out SOUND_TYPE type, out SOUND_FORMAT format, out int channels, out int bits)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600064E")]
		[Address(RVA = "0x325EAA4", Offset = "0x325EAA4", VA = "0x325EAA4")]
		public RESULT getNumSubSounds(out int numsubsounds)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600064F")]
		[Address(RVA = "0x325EB3C", Offset = "0x325EB3C", VA = "0x325EB3C")]
		public RESULT getNumTags(out int numtags, out int numtagsupdated)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000650")]
		[Address(RVA = "0x325EBDC", Offset = "0x325EBDC", VA = "0x325EBDC")]
		public RESULT getTag(string name, int index, out TAG tag)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000651")]
		[Address(RVA = "0x325EF60", Offset = "0x325EF60", VA = "0x325EF60")]
		public RESULT getOpenState(out OPENSTATE openstate, out uint percentbuffered, out bool starving, out bool diskbusy)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000652")]
		[Address(RVA = "0x325F03C", Offset = "0x325F03C", VA = "0x325F03C")]
		public RESULT readData(IntPtr buffer, uint length, out uint read)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000653")]
		[Address(RVA = "0x325F0EC", Offset = "0x325F0EC", VA = "0x325F0EC")]
		public RESULT seekData(uint pcm)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000654")]
		[Address(RVA = "0x325F184", Offset = "0x325F184", VA = "0x325F184")]
		public RESULT setSoundGroup(SoundGroup soundgroup)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000655")]
		[Address(RVA = "0x325F21C", Offset = "0x325F21C", VA = "0x325F21C")]
		public RESULT getSoundGroup(out SoundGroup soundgroup)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000656")]
		[Address(RVA = "0x325F2B4", Offset = "0x325F2B4", VA = "0x325F2B4")]
		public RESULT getNumSyncPoints(out int numsyncpoints)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000657")]
		[Address(RVA = "0x325F34C", Offset = "0x325F34C", VA = "0x325F34C")]
		public RESULT getSyncPoint(int index, out IntPtr point)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000658")]
		[Address(RVA = "0x325F3EC", Offset = "0x325F3EC", VA = "0x325F3EC")]
		public RESULT getSyncPointInfo(IntPtr point, out string name, int namelen, out uint offset, TIMEUNIT offsettype)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000659")]
		[Address(RVA = "0x325F678", Offset = "0x325F678", VA = "0x325F678")]
		public RESULT getSyncPointInfo(IntPtr point, out uint offset, TIMEUNIT offsettype)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600065A")]
		[Address(RVA = "0x325F6EC", Offset = "0x325F6EC", VA = "0x325F6EC")]
		public RESULT addSyncPoint(uint offset, TIMEUNIT offsettype, string name, out IntPtr point)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600065B")]
		[Address(RVA = "0x325F90C", Offset = "0x325F90C", VA = "0x325F90C")]
		public RESULT deleteSyncPoint(IntPtr point)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600065C")]
		[Address(RVA = "0x325F9A4", Offset = "0x325F9A4", VA = "0x325F9A4")]
		public RESULT setMode(MODE mode)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600065D")]
		[Address(RVA = "0x325FA3C", Offset = "0x325FA3C", VA = "0x325FA3C")]
		public RESULT getMode(out MODE mode)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600065E")]
		[Address(RVA = "0x325FAD4", Offset = "0x325FAD4", VA = "0x325FAD4")]
		public RESULT setLoopCount(int loopcount)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600065F")]
		[Address(RVA = "0x325FB6C", Offset = "0x325FB6C", VA = "0x325FB6C")]
		public RESULT getLoopCount(out int loopcount)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000660")]
		[Address(RVA = "0x325FC04", Offset = "0x325FC04", VA = "0x325FC04")]
		public RESULT setLoopPoints(uint loopstart, TIMEUNIT loopstarttype, uint loopend, TIMEUNIT loopendtype)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000661")]
		[Address(RVA = "0x325FCBC", Offset = "0x325FCBC", VA = "0x325FCBC")]
		public RESULT getLoopPoints(out uint loopstart, TIMEUNIT loopstarttype, out uint loopend, TIMEUNIT loopendtype)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000662")]
		[Address(RVA = "0x325FD74", Offset = "0x325FD74", VA = "0x325FD74")]
		public RESULT getMusicNumChannels(out int numchannels)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000663")]
		[Address(RVA = "0x325FE0C", Offset = "0x325FE0C", VA = "0x325FE0C")]
		public RESULT setMusicChannelVolume(int channel, float volume)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000664")]
		[Address(RVA = "0x325FEB4", Offset = "0x325FEB4", VA = "0x325FEB4")]
		public RESULT getMusicChannelVolume(int channel, out float volume)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000665")]
		[Address(RVA = "0x325FF54", Offset = "0x325FF54", VA = "0x325FF54")]
		public RESULT setMusicSpeed(float speed)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000666")]
		[Address(RVA = "0x325FFEC", Offset = "0x325FFEC", VA = "0x325FFEC")]
		public RESULT getMusicSpeed(out float speed)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000667")]
		[Address(RVA = "0x3260084", Offset = "0x3260084", VA = "0x3260084")]
		public RESULT setUserData(IntPtr userdata)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000668")]
		[Address(RVA = "0x326011C", Offset = "0x326011C", VA = "0x326011C")]
		public RESULT getUserData(out IntPtr userdata)
		{
			return default(RESULT);
		}

		[PreserveSig]
		[Token(Token = "0x6000669")]
		[Address(RVA = "0x325D988", Offset = "0x325D988", VA = "0x325D988")]
		private static extern RESULT FMOD5_Sound_Release(IntPtr sound);

		[PreserveSig]
		[Token(Token = "0x600066A")]
		[Address(RVA = "0x325DA10", Offset = "0x325DA10", VA = "0x325DA10")]
		private static extern RESULT FMOD5_Sound_GetSystemObject(IntPtr sound, out IntPtr system);

		[PreserveSig]
		[Token(Token = "0x600066B")]
		[Address(RVA = "0x325DAA8", Offset = "0x325DAA8", VA = "0x325DAA8")]
		private static extern RESULT FMOD5_Sound_Lock(IntPtr sound, uint offset, uint length, out IntPtr ptr1, out IntPtr ptr2, out uint len1, out uint len2);

		[PreserveSig]
		[Token(Token = "0x600066C")]
		[Address(RVA = "0x325DB78", Offset = "0x325DB78", VA = "0x325DB78")]
		private static extern RESULT FMOD5_Sound_Unlock(IntPtr sound, IntPtr ptr1, IntPtr ptr2, uint len1, uint len2);

		[PreserveSig]
		[Token(Token = "0x600066D")]
		[Address(RVA = "0x325DC30", Offset = "0x325DC30", VA = "0x325DC30")]
		private static extern RESULT FMOD5_Sound_SetDefaults(IntPtr sound, float frequency, int priority);

		[PreserveSig]
		[Token(Token = "0x600066E")]
		[Address(RVA = "0x325DCD8", Offset = "0x325DCD8", VA = "0x325DCD8")]
		private static extern RESULT FMOD5_Sound_GetDefaults(IntPtr sound, out float frequency, out int priority);

		[PreserveSig]
		[Token(Token = "0x600066F")]
		[Address(RVA = "0x325DD78", Offset = "0x325DD78", VA = "0x325DD78")]
		private static extern RESULT FMOD5_Sound_Set3DMinMaxDistance(IntPtr sound, float min, float max);

		[PreserveSig]
		[Token(Token = "0x6000670")]
		[Address(RVA = "0x325DE18", Offset = "0x325DE18", VA = "0x325DE18")]
		private static extern RESULT FMOD5_Sound_Get3DMinMaxDistance(IntPtr sound, out float min, out float max);

		[PreserveSig]
		[Token(Token = "0x6000671")]
		[Address(RVA = "0x325DEB8", Offset = "0x325DEB8", VA = "0x325DEB8")]
		private static extern RESULT FMOD5_Sound_Set3DConeSettings(IntPtr sound, float insideconeangle, float outsideconeangle, float outsidevolume);

		[PreserveSig]
		[Token(Token = "0x6000672")]
		[Address(RVA = "0x325DF68", Offset = "0x325DF68", VA = "0x325DF68")]
		private static extern RESULT FMOD5_Sound_Get3DConeSettings(IntPtr sound, out float insideconeangle, out float outsideconeangle, out float outsidevolume);

		[PreserveSig]
		[Token(Token = "0x6000673")]
		[Address(RVA = "0x325E018", Offset = "0x325E018", VA = "0x325E018")]
		private static extern RESULT FMOD5_Sound_Set3DCustomRolloff(IntPtr sound, ref VECTOR points, int numpoints);

		[PreserveSig]
		[Token(Token = "0x6000674")]
		[Address(RVA = "0x325E0B8", Offset = "0x325E0B8", VA = "0x325E0B8")]
		private static extern RESULT FMOD5_Sound_Get3DCustomRolloff(IntPtr sound, out IntPtr points, out int numpoints);

		[PreserveSig]
		[Token(Token = "0x6000675")]
		[Address(RVA = "0x325E158", Offset = "0x325E158", VA = "0x325E158")]
		private static extern RESULT FMOD5_Sound_GetSubSound(IntPtr sound, int index, out IntPtr subsound);

		[PreserveSig]
		[Token(Token = "0x6000676")]
		[Address(RVA = "0x325E1F8", Offset = "0x325E1F8", VA = "0x325E1F8")]
		private static extern RESULT FMOD5_Sound_GetSubSoundParent(IntPtr sound, out IntPtr parentsound);

		[PreserveSig]
		[Token(Token = "0x6000677")]
		[Address(RVA = "0x325E434", Offset = "0x325E434", VA = "0x325E434")]
		private static extern RESULT FMOD5_Sound_GetName(IntPtr sound, IntPtr name, int namelen);

		[PreserveSig]
		[Token(Token = "0x6000678")]
		[Address(RVA = "0x325E954", Offset = "0x325E954", VA = "0x325E954")]
		private static extern RESULT FMOD5_Sound_GetLength(IntPtr sound, out uint length, TIMEUNIT lengthtype);

		[PreserveSig]
		[Token(Token = "0x6000679")]
		[Address(RVA = "0x325E9F4", Offset = "0x325E9F4", VA = "0x325E9F4")]
		private static extern RESULT FMOD5_Sound_GetFormat(IntPtr sound, out SOUND_TYPE type, out SOUND_FORMAT format, out int channels, out int bits);

		[PreserveSig]
		[Token(Token = "0x600067A")]
		[Address(RVA = "0x325EAAC", Offset = "0x325EAAC", VA = "0x325EAAC")]
		private static extern RESULT FMOD5_Sound_GetNumSubSounds(IntPtr sound, out int numsubsounds);

		[PreserveSig]
		[Token(Token = "0x600067B")]
		[Address(RVA = "0x325EB44", Offset = "0x325EB44", VA = "0x325EB44")]
		private static extern RESULT FMOD5_Sound_GetNumTags(IntPtr sound, out int numtags, out int numtagsupdated);

		[PreserveSig]
		[Token(Token = "0x600067C")]
		[Address(RVA = "0x325EE7C", Offset = "0x325EE7C", VA = "0x325EE7C")]
		private static extern RESULT FMOD5_Sound_GetTag(IntPtr sound, byte[] name, int index, out TAG tag);

		[PreserveSig]
		[Token(Token = "0x600067D")]
		[Address(RVA = "0x325EF68", Offset = "0x325EF68", VA = "0x325EF68")]
		private static extern RESULT FMOD5_Sound_GetOpenState(IntPtr sound, out OPENSTATE openstate, out uint percentbuffered, out bool starving, out bool diskbusy);

		[PreserveSig]
		[Token(Token = "0x600067E")]
		[Address(RVA = "0x325F044", Offset = "0x325F044", VA = "0x325F044")]
		private static extern RESULT FMOD5_Sound_ReadData(IntPtr sound, IntPtr buffer, uint length, out uint read);

		[PreserveSig]
		[Token(Token = "0x600067F")]
		[Address(RVA = "0x325F0F4", Offset = "0x325F0F4", VA = "0x325F0F4")]
		private static extern RESULT FMOD5_Sound_SeekData(IntPtr sound, uint pcm);

		[PreserveSig]
		[Token(Token = "0x6000680")]
		[Address(RVA = "0x325F18C", Offset = "0x325F18C", VA = "0x325F18C")]
		private static extern RESULT FMOD5_Sound_SetSoundGroup(IntPtr sound, IntPtr soundgroup);

		[PreserveSig]
		[Token(Token = "0x6000681")]
		[Address(RVA = "0x325F224", Offset = "0x325F224", VA = "0x325F224")]
		private static extern RESULT FMOD5_Sound_GetSoundGroup(IntPtr sound, out IntPtr soundgroup);

		[PreserveSig]
		[Token(Token = "0x6000682")]
		[Address(RVA = "0x325F2BC", Offset = "0x325F2BC", VA = "0x325F2BC")]
		private static extern RESULT FMOD5_Sound_GetNumSyncPoints(IntPtr sound, out int numsyncpoints);

		[PreserveSig]
		[Token(Token = "0x6000683")]
		[Address(RVA = "0x325F354", Offset = "0x325F354", VA = "0x325F354")]
		private static extern RESULT FMOD5_Sound_GetSyncPoint(IntPtr sound, int index, out IntPtr point);

		[PreserveSig]
		[Token(Token = "0x6000684")]
		[Address(RVA = "0x325F5B8", Offset = "0x325F5B8", VA = "0x325F5B8")]
		private static extern RESULT FMOD5_Sound_GetSyncPointInfo(IntPtr sound, IntPtr point, IntPtr name, int namelen, out uint offset, TIMEUNIT offsettype);

		[PreserveSig]
		[Token(Token = "0x6000685")]
		[Address(RVA = "0x325F854", Offset = "0x325F854", VA = "0x325F854")]
		private static extern RESULT FMOD5_Sound_AddSyncPoint(IntPtr sound, uint offset, TIMEUNIT offsettype, byte[] name, out IntPtr point);

		[PreserveSig]
		[Token(Token = "0x6000686")]
		[Address(RVA = "0x325F914", Offset = "0x325F914", VA = "0x325F914")]
		private static extern RESULT FMOD5_Sound_DeleteSyncPoint(IntPtr sound, IntPtr point);

		[PreserveSig]
		[Token(Token = "0x6000687")]
		[Address(RVA = "0x325F9AC", Offset = "0x325F9AC", VA = "0x325F9AC")]
		private static extern RESULT FMOD5_Sound_SetMode(IntPtr sound, MODE mode);

		[PreserveSig]
		[Token(Token = "0x6000688")]
		[Address(RVA = "0x325FA44", Offset = "0x325FA44", VA = "0x325FA44")]
		private static extern RESULT FMOD5_Sound_GetMode(IntPtr sound, out MODE mode);

		[PreserveSig]
		[Token(Token = "0x6000689")]
		[Address(RVA = "0x325FADC", Offset = "0x325FADC", VA = "0x325FADC")]
		private static extern RESULT FMOD5_Sound_SetLoopCount(IntPtr sound, int loopcount);

		[PreserveSig]
		[Token(Token = "0x600068A")]
		[Address(RVA = "0x325FB74", Offset = "0x325FB74", VA = "0x325FB74")]
		private static extern RESULT FMOD5_Sound_GetLoopCount(IntPtr sound, out int loopcount);

		[PreserveSig]
		[Token(Token = "0x600068B")]
		[Address(RVA = "0x325FC0C", Offset = "0x325FC0C", VA = "0x325FC0C")]
		private static extern RESULT FMOD5_Sound_SetLoopPoints(IntPtr sound, uint loopstart, TIMEUNIT loopstarttype, uint loopend, TIMEUNIT loopendtype);

		[PreserveSig]
		[Token(Token = "0x600068C")]
		[Address(RVA = "0x325FCC4", Offset = "0x325FCC4", VA = "0x325FCC4")]
		private static extern RESULT FMOD5_Sound_GetLoopPoints(IntPtr sound, out uint loopstart, TIMEUNIT loopstarttype, out uint loopend, TIMEUNIT loopendtype);

		[PreserveSig]
		[Token(Token = "0x600068D")]
		[Address(RVA = "0x325FD7C", Offset = "0x325FD7C", VA = "0x325FD7C")]
		private static extern RESULT FMOD5_Sound_GetMusicNumChannels(IntPtr sound, out int numchannels);

		[PreserveSig]
		[Token(Token = "0x600068E")]
		[Address(RVA = "0x325FE14", Offset = "0x325FE14", VA = "0x325FE14")]
		private static extern RESULT FMOD5_Sound_SetMusicChannelVolume(IntPtr sound, int channel, float volume);

		[PreserveSig]
		[Token(Token = "0x600068F")]
		[Address(RVA = "0x325FEBC", Offset = "0x325FEBC", VA = "0x325FEBC")]
		private static extern RESULT FMOD5_Sound_GetMusicChannelVolume(IntPtr sound, int channel, out float volume);

		[PreserveSig]
		[Token(Token = "0x6000690")]
		[Address(RVA = "0x325FF5C", Offset = "0x325FF5C", VA = "0x325FF5C")]
		private static extern RESULT FMOD5_Sound_SetMusicSpeed(IntPtr sound, float speed);

		[PreserveSig]
		[Token(Token = "0x6000691")]
		[Address(RVA = "0x325FFF4", Offset = "0x325FFF4", VA = "0x325FFF4")]
		private static extern RESULT FMOD5_Sound_GetMusicSpeed(IntPtr sound, out float speed);

		[PreserveSig]
		[Token(Token = "0x6000692")]
		[Address(RVA = "0x326008C", Offset = "0x326008C", VA = "0x326008C")]
		private static extern RESULT FMOD5_Sound_SetUserData(IntPtr sound, IntPtr userdata);

		[PreserveSig]
		[Token(Token = "0x6000693")]
		[Address(RVA = "0x3260124", Offset = "0x3260124", VA = "0x3260124")]
		private static extern RESULT FMOD5_Sound_GetUserData(IntPtr sound, out IntPtr userdata);

		[Token(Token = "0x6000694")]
		[Address(RVA = "0x32601B4", Offset = "0x32601B4", VA = "0x32601B4")]
		public bool hasHandle()
		{
			return default(bool);
		}

		[Token(Token = "0x6000695")]
		[Address(RVA = "0x3260200", Offset = "0x3260200", VA = "0x3260200")]
		public void clearHandle()
		{
		}
	}
	[Token(Token = "0x20000C4")]
	internal interface IChannelControl
	{
		[Token(Token = "0x6000696")]
		RESULT getSystemObject(out System system);

		[Token(Token = "0x6000697")]
		RESULT stop();

		[Token(Token = "0x6000698")]
		RESULT setPaused(bool paused);

		[Token(Token = "0x6000699")]
		RESULT getPaused(out bool paused);

		[Token(Token = "0x600069A")]
		RESULT setVolume(float volume);

		[Token(Token = "0x600069B")]
		RESULT getVolume(out float volume);

		[Token(Token = "0x600069C")]
		RESULT setVolumeRamp(bool ramp);

		[Token(Token = "0x600069D")]
		RESULT getVolumeRamp(out bool ramp);

		[Token(Token = "0x600069E")]
		RESULT getAudibility(out float audibility);

		[Token(Token = "0x600069F")]
		RESULT setPitch(float pitch);

		[Token(Token = "0x60006A0")]
		RESULT getPitch(out float pitch);

		[Token(Token = "0x60006A1")]
		RESULT setMute(bool mute);

		[Token(Token = "0x60006A2")]
		RESULT getMute(out bool mute);

		[Token(Token = "0x60006A3")]
		RESULT setReverbProperties(int instance, float wet);

		[Token(Token = "0x60006A4")]
		RESULT getReverbProperties(int instance, out float wet);

		[Token(Token = "0x60006A5")]
		RESULT setLowPassGain(float gain);

		[Token(Token = "0x60006A6")]
		RESULT getLowPassGain(out float gain);

		[Token(Token = "0x60006A7")]
		RESULT setMode(MODE mode);

		[Token(Token = "0x60006A8")]
		RESULT getMode(out MODE mode);

		[Token(Token = "0x60006A9")]
		RESULT setCallback(CHANNELCONTROL_CALLBACK callback);

		[Token(Token = "0x60006AA")]
		RESULT isPlaying(out bool isplaying);

		[Token(Token = "0x60006AB")]
		RESULT setPan(float pan);

		[Token(Token = "0x60006AC")]
		RESULT setMixLevelsOutput(float frontleft, float frontright, float center, float lfe, float surroundleft, float surroundright, float backleft, float backright);

		[Token(Token = "0x60006AD")]
		RESULT setMixLevelsInput(float[] levels, int numlevels);

		[Token(Token = "0x60006AE")]
		RESULT setMixMatrix(float[] matrix, int outchannels, int inchannels, int inchannel_hop);

		[Token(Token = "0x60006AF")]
		RESULT getMixMatrix(float[] matrix, out int outchannels, out int inchannels, int inchannel_hop);

		[Token(Token = "0x60006B0")]
		RESULT getDSPClock(out ulong dspclock, out ulong parentclock);

		[Token(Token = "0x60006B1")]
		RESULT setDelay(ulong dspclock_start, ulong dspclock_end, bool stopchannels);

		[Token(Token = "0x60006B2")]
		RESULT getDelay(out ulong dspclock_start, out ulong dspclock_end);

		[Token(Token = "0x60006B3")]
		RESULT getDelay(out ulong dspclock_start, out ulong dspclock_end, out bool stopchannels);

		[Token(Token = "0x60006B4")]
		RESULT addFadePoint(ulong dspclock, float volume);

		[Token(Token = "0x60006B5")]
		RESULT setFadePointRamp(ulong dspclock, float volume);

		[Token(Token = "0x60006B6")]
		RESULT removeFadePoints(ulong dspclock_start, ulong dspclock_end);

		[Token(Token = "0x60006B7")]
		RESULT getFadePoints(ref uint numpoints, ulong[] point_dspclock, float[] point_volume);

		[Token(Token = "0x60006B8")]
		RESULT getDSP(int index, out DSP dsp);

		[Token(Token = "0x60006B9")]
		RESULT addDSP(int index, DSP dsp);

		[Token(Token = "0x60006BA")]
		RESULT removeDSP(DSP dsp);

		[Token(Token = "0x60006BB")]
		RESULT getNumDSPs(out int numdsps);

		[Token(Token = "0x60006BC")]
		RESULT setDSPIndex(DSP dsp, int index);

		[Token(Token = "0x60006BD")]
		RESULT getDSPIndex(DSP dsp, out int index);

		[Token(Token = "0x60006BE")]
		RESULT set3DAttributes(ref VECTOR pos, ref VECTOR vel);

		[Token(Token = "0x60006BF")]
		RESULT get3DAttributes(out VECTOR pos, out VECTOR vel);

		[Token(Token = "0x60006C0")]
		RESULT set3DMinMaxDistance(float mindistance, float maxdistance);

		[Token(Token = "0x60006C1")]
		RESULT get3DMinMaxDistance(out float mindistance, out float maxdistance);

		[Token(Token = "0x60006C2")]
		RESULT set3DConeSettings(float insideconeangle, float outsideconeangle, float outsidevolume);

		[Token(Token = "0x60006C3")]
		RESULT get3DConeSettings(out float insideconeangle, out float outsideconeangle, out float outsidevolume);

		[Token(Token = "0x60006C4")]
		RESULT set3DConeOrientation(ref VECTOR orientation);

		[Token(Token = "0x60006C5")]
		RESULT get3DConeOrientation(out VECTOR orientation);

		[Token(Token = "0x60006C6")]
		RESULT set3DCustomRolloff(ref VECTOR points, int numpoints);

		[Token(Token = "0x60006C7")]
		RESULT get3DCustomRolloff(out IntPtr points, out int numpoints);

		[Token(Token = "0x60006C8")]
		RESULT set3DOcclusion(float directocclusion, float reverbocclusion);

		[Token(Token = "0x60006C9")]
		RESULT get3DOcclusion(out float directocclusion, out float reverbocclusion);

		[Token(Token = "0x60006CA")]
		RESULT set3DSpread(float angle);

		[Token(Token = "0x60006CB")]
		RESULT get3DSpread(out float angle);

		[Token(Token = "0x60006CC")]
		RESULT set3DLevel(float level);

		[Token(Token = "0x60006CD")]
		RESULT get3DLevel(out float level);

		[Token(Token = "0x60006CE")]
		RESULT set3DDopplerLevel(float level);

		[Token(Token = "0x60006CF")]
		RESULT get3DDopplerLevel(out float level);

		[Token(Token = "0x60006D0")]
		RESULT set3DDistanceFilter(bool custom, float customLevel, float centerFreq);

		[Token(Token = "0x60006D1")]
		RESULT get3DDistanceFilter(out bool custom, out float customLevel, out float centerFreq);

		[Token(Token = "0x60006D2")]
		RESULT setUserData(IntPtr userdata);

		[Token(Token = "0x60006D3")]
		RESULT getUserData(out IntPtr userdata);
	}
	[Token(Token = "0x20000C5")]
	public struct Channel : IChannelControl
	{
		[Token(Token = "0x400060D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public IntPtr handle;

		[Token(Token = "0x60006D4")]
		[Address(RVA = "0x3297450", Offset = "0x3297450", VA = "0x3297450")]
		public RESULT setFrequency(float frequency)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60006D5")]
		[Address(RVA = "0x32974E8", Offset = "0x32974E8", VA = "0x32974E8")]
		public RESULT getFrequency(out float frequency)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60006D6")]
		[Address(RVA = "0x3297580", Offset = "0x3297580", VA = "0x3297580")]
		public RESULT setPriority(int priority)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60006D7")]
		[Address(RVA = "0x3297618", Offset = "0x3297618", VA = "0x3297618")]
		public RESULT getPriority(out int priority)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60006D8")]
		[Address(RVA = "0x32976B0", Offset = "0x32976B0", VA = "0x32976B0")]
		public RESULT setPosition(uint position, TIMEUNIT postype)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60006D9")]
		[Address(RVA = "0x3297750", Offset = "0x3297750", VA = "0x3297750")]
		public RESULT getPosition(out uint position, TIMEUNIT postype)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60006DA")]
		[Address(RVA = "0x32977F0", Offset = "0x32977F0", VA = "0x32977F0")]
		public RESULT setChannelGroup(ChannelGroup channelgroup)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60006DB")]
		[Address(RVA = "0x3297888", Offset = "0x3297888", VA = "0x3297888")]
		public RESULT getChannelGroup(out ChannelGroup channelgroup)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60006DC")]
		[Address(RVA = "0x3297920", Offset = "0x3297920", VA = "0x3297920")]
		public RESULT setLoopCount(int loopcount)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60006DD")]
		[Address(RVA = "0x32979B8", Offset = "0x32979B8", VA = "0x32979B8")]
		public RESULT getLoopCount(out int loopcount)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60006DE")]
		[Address(RVA = "0x3297A50", Offset = "0x3297A50", VA = "0x3297A50")]
		public RESULT setLoopPoints(uint loopstart, TIMEUNIT loopstarttype, uint loopend, TIMEUNIT loopendtype)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60006DF")]
		[Address(RVA = "0x3297B08", Offset = "0x3297B08", VA = "0x3297B08")]
		public RESULT getLoopPoints(out uint loopstart, TIMEUNIT loopstarttype, out uint loopend, TIMEUNIT loopendtype)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60006E0")]
		[Address(RVA = "0x3297BC0", Offset = "0x3297BC0", VA = "0x3297BC0")]
		public RESULT isVirtual(out bool isvirtual)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60006E1")]
		[Address(RVA = "0x3297C6C", Offset = "0x3297C6C", VA = "0x3297C6C")]
		public RESULT getCurrentSound(out Sound sound)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60006E2")]
		[Address(RVA = "0x3297D04", Offset = "0x3297D04", VA = "0x3297D04")]
		public RESULT getIndex(out int index)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60006E3")]
		[Address(RVA = "0x3297D9C", Offset = "0x3297D9C", VA = "0x3297D9C", Slot = "4")]
		public RESULT getSystemObject(out System system)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60006E4")]
		[Address(RVA = "0x3297E34", Offset = "0x3297E34", VA = "0x3297E34", Slot = "5")]
		public RESULT stop()
		{
			return default(RESULT);
		}

		[Token(Token = "0x60006E5")]
		[Address(RVA = "0x3297EBC", Offset = "0x3297EBC", VA = "0x3297EBC", Slot = "6")]
		public RESULT setPaused(bool paused)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60006E6")]
		[Address(RVA = "0x3297F58", Offset = "0x3297F58", VA = "0x3297F58", Slot = "7")]
		public RESULT getPaused(out bool paused)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60006E7")]
		[Address(RVA = "0x3298004", Offset = "0x3298004", VA = "0x3298004", Slot = "8")]
		public RESULT setVolume(float volume)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60006E8")]
		[Address(RVA = "0x329809C", Offset = "0x329809C", VA = "0x329809C", Slot = "9")]
		public RESULT getVolume(out float volume)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60006E9")]
		[Address(RVA = "0x3298134", Offset = "0x3298134", VA = "0x3298134", Slot = "10")]
		public RESULT setVolumeRamp(bool ramp)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60006EA")]
		[Address(RVA = "0x32981D0", Offset = "0x32981D0", VA = "0x32981D0", Slot = "11")]
		public RESULT getVolumeRamp(out bool ramp)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60006EB")]
		[Address(RVA = "0x329827C", Offset = "0x329827C", VA = "0x329827C", Slot = "12")]
		public RESULT getAudibility(out float audibility)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60006EC")]
		[Address(RVA = "0x3298314", Offset = "0x3298314", VA = "0x3298314", Slot = "13")]
		public RESULT setPitch(float pitch)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60006ED")]
		[Address(RVA = "0x32983AC", Offset = "0x32983AC", VA = "0x32983AC", Slot = "14")]
		public RESULT getPitch(out float pitch)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60006EE")]
		[Address(RVA = "0x3298444", Offset = "0x3298444", VA = "0x3298444", Slot = "15")]
		public RESULT setMute(bool mute)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60006EF")]
		[Address(RVA = "0x32984E0", Offset = "0x32984E0", VA = "0x32984E0", Slot = "16")]
		public RESULT getMute(out bool mute)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60006F0")]
		[Address(RVA = "0x329858C", Offset = "0x329858C", VA = "0x329858C", Slot = "17")]
		public RESULT setReverbProperties(int instance, float wet)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60006F1")]
		[Address(RVA = "0x3298634", Offset = "0x3298634", VA = "0x3298634", Slot = "18")]
		public RESULT getReverbProperties(int instance, out float wet)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60006F2")]
		[Address(RVA = "0x32986D4", Offset = "0x32986D4", VA = "0x32986D4", Slot = "19")]
		public RESULT setLowPassGain(float gain)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60006F3")]
		[Address(RVA = "0x329876C", Offset = "0x329876C", VA = "0x329876C", Slot = "20")]
		public RESULT getLowPassGain(out float gain)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60006F4")]
		[Address(RVA = "0x3298804", Offset = "0x3298804", VA = "0x3298804", Slot = "21")]
		public RESULT setMode(MODE mode)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60006F5")]
		[Address(RVA = "0x329889C", Offset = "0x329889C", VA = "0x329889C", Slot = "22")]
		public RESULT getMode(out MODE mode)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60006F6")]
		[Address(RVA = "0x3298934", Offset = "0x3298934", VA = "0x3298934", Slot = "23")]
		public RESULT setCallback(CHANNELCONTROL_CALLBACK callback)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60006F7")]
		[Address(RVA = "0x32989D4", Offset = "0x32989D4", VA = "0x32989D4", Slot = "24")]
		public RESULT isPlaying(out bool isplaying)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60006F8")]
		[Address(RVA = "0x3298A80", Offset = "0x3298A80", VA = "0x3298A80", Slot = "25")]
		public RESULT setPan(float pan)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60006F9")]
		[Address(RVA = "0x3298B18", Offset = "0x3298B18", VA = "0x3298B18", Slot = "26")]
		public RESULT setMixLevelsOutput(float frontleft, float frontright, float center, float lfe, float surroundleft, float surroundright, float backleft, float backright)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60006FA")]
		[Address(RVA = "0x3298C00", Offset = "0x3298C00", VA = "0x3298C00", Slot = "27")]
		public RESULT setMixLevelsInput(float[] levels, int numlevels)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60006FB")]
		[Address(RVA = "0x3298CA8", Offset = "0x3298CA8", VA = "0x3298CA8", Slot = "28")]
		public RESULT setMixMatrix(float[] matrix, int outchannels, int inchannels, int inchannel_hop = 0)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60006FC")]
		[Address(RVA = "0x3298D68", Offset = "0x3298D68", VA = "0x3298D68", Slot = "29")]
		public RESULT getMixMatrix(float[] matrix, out int outchannels, out int inchannels, int inchannel_hop = 0)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60006FD")]
		[Address(RVA = "0x3298E28", Offset = "0x3298E28", VA = "0x3298E28", Slot = "30")]
		public RESULT getDSPClock(out ulong dspclock, out ulong parentclock)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60006FE")]
		[Address(RVA = "0x3298EC8", Offset = "0x3298EC8", VA = "0x3298EC8", Slot = "31")]
		public RESULT setDelay(ulong dspclock_start, ulong dspclock_end, bool stopchannels = true)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60006FF")]
		[Address(RVA = "0x3298F7C", Offset = "0x3298F7C", VA = "0x3298F7C", Slot = "32")]
		public RESULT getDelay(out ulong dspclock_start, out ulong dspclock_end)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000700")]
		[Address(RVA = "0x3299084", Offset = "0x3299084", VA = "0x3299084", Slot = "33")]
		public RESULT getDelay(out ulong dspclock_start, out ulong dspclock_end, out bool stopchannels)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000701")]
		[Address(RVA = "0x3299148", Offset = "0x3299148", VA = "0x3299148", Slot = "34")]
		public RESULT addFadePoint(ulong dspclock, float volume)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000702")]
		[Address(RVA = "0x32991F0", Offset = "0x32991F0", VA = "0x32991F0", Slot = "35")]
		public RESULT setFadePointRamp(ulong dspclock, float volume)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000703")]
		[Address(RVA = "0x3299298", Offset = "0x3299298", VA = "0x3299298", Slot = "36")]
		public RESULT removeFadePoints(ulong dspclock_start, ulong dspclock_end)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000704")]
		[Address(RVA = "0x3299338", Offset = "0x3299338", VA = "0x3299338", Slot = "37")]
		public RESULT getFadePoints(ref uint numpoints, ulong[] point_dspclock, float[] point_volume)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000705")]
		[Address(RVA = "0x32993F8", Offset = "0x32993F8", VA = "0x32993F8", Slot = "38")]
		public RESULT getDSP(int index, out DSP dsp)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000706")]
		[Address(RVA = "0x3299494", Offset = "0x3299494", VA = "0x3299494", Slot = "39")]
		public RESULT addDSP(int index, DSP dsp)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000707")]
		[Address(RVA = "0x3299530", Offset = "0x3299530", VA = "0x3299530", Slot = "40")]
		public RESULT removeDSP(DSP dsp)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000708")]
		[Address(RVA = "0x32995C8", Offset = "0x32995C8", VA = "0x32995C8", Slot = "41")]
		public RESULT getNumDSPs(out int numdsps)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000709")]
		[Address(RVA = "0x3299660", Offset = "0x3299660", VA = "0x3299660", Slot = "42")]
		public RESULT setDSPIndex(DSP dsp, int index)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600070A")]
		[Address(RVA = "0x3299700", Offset = "0x3299700", VA = "0x3299700", Slot = "43")]
		public RESULT getDSPIndex(DSP dsp, out int index)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600070B")]
		[Address(RVA = "0x32997A0", Offset = "0x32997A0", VA = "0x32997A0", Slot = "44")]
		public RESULT set3DAttributes(ref VECTOR pos, ref VECTOR vel)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600070C")]
		[Address(RVA = "0x3299840", Offset = "0x3299840", VA = "0x3299840", Slot = "45")]
		public RESULT get3DAttributes(out VECTOR pos, out VECTOR vel)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600070D")]
		[Address(RVA = "0x32998E0", Offset = "0x32998E0", VA = "0x32998E0", Slot = "46")]
		public RESULT set3DMinMaxDistance(float mindistance, float maxdistance)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600070E")]
		[Address(RVA = "0x3299980", Offset = "0x3299980", VA = "0x3299980", Slot = "47")]
		public RESULT get3DMinMaxDistance(out float mindistance, out float maxdistance)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600070F")]
		[Address(RVA = "0x3299A20", Offset = "0x3299A20", VA = "0x3299A20", Slot = "48")]
		public RESULT set3DConeSettings(float insideconeangle, float outsideconeangle, float outsidevolume)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000710")]
		[Address(RVA = "0x3299AD0", Offset = "0x3299AD0", VA = "0x3299AD0", Slot = "49")]
		public RESULT get3DConeSettings(out float insideconeangle, out float outsideconeangle, out float outsidevolume)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000711")]
		[Address(RVA = "0x3299B80", Offset = "0x3299B80", VA = "0x3299B80", Slot = "50")]
		public RESULT set3DConeOrientation(ref VECTOR orientation)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000712")]
		[Address(RVA = "0x3299C18", Offset = "0x3299C18", VA = "0x3299C18", Slot = "51")]
		public RESULT get3DConeOrientation(out VECTOR orientation)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000713")]
		[Address(RVA = "0x3299CB0", Offset = "0x3299CB0", VA = "0x3299CB0", Slot = "52")]
		public RESULT set3DCustomRolloff(ref VECTOR points, int numpoints)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000714")]
		[Address(RVA = "0x3299D50", Offset = "0x3299D50", VA = "0x3299D50", Slot = "53")]
		public RESULT get3DCustomRolloff(out IntPtr points, out int numpoints)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000715")]
		[Address(RVA = "0x3299DF0", Offset = "0x3299DF0", VA = "0x3299DF0", Slot = "54")]
		public RESULT set3DOcclusion(float directocclusion, float reverbocclusion)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000716")]
		[Address(RVA = "0x3299E90", Offset = "0x3299E90", VA = "0x3299E90", Slot = "55")]
		public RESULT get3DOcclusion(out float directocclusion, out float reverbocclusion)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000717")]
		[Address(RVA = "0x3299F30", Offset = "0x3299F30", VA = "0x3299F30", Slot = "56")]
		public RESULT set3DSpread(float angle)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000718")]
		[Address(RVA = "0x3299FC8", Offset = "0x3299FC8", VA = "0x3299FC8", Slot = "57")]
		public RESULT get3DSpread(out float angle)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000719")]
		[Address(RVA = "0x329A060", Offset = "0x329A060", VA = "0x329A060", Slot = "58")]
		public RESULT set3DLevel(float level)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600071A")]
		[Address(RVA = "0x329A0F8", Offset = "0x329A0F8", VA = "0x329A0F8", Slot = "59")]
		public RESULT get3DLevel(out float level)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600071B")]
		[Address(RVA = "0x329A190", Offset = "0x329A190", VA = "0x329A190", Slot = "60")]
		public RESULT set3DDopplerLevel(float level)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600071C")]
		[Address(RVA = "0x329A228", Offset = "0x329A228", VA = "0x329A228", Slot = "61")]
		public RESULT get3DDopplerLevel(out float level)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600071D")]
		[Address(RVA = "0x329A2C0", Offset = "0x329A2C0", VA = "0x329A2C0", Slot = "62")]
		public RESULT set3DDistanceFilter(bool custom, float customLevel, float centerFreq)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600071E")]
		[Address(RVA = "0x329A374", Offset = "0x329A374", VA = "0x329A374", Slot = "63")]
		public RESULT get3DDistanceFilter(out bool custom, out float customLevel, out float centerFreq)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600071F")]
		[Address(RVA = "0x329A438", Offset = "0x329A438", VA = "0x329A438", Slot = "64")]
		public RESULT setUserData(IntPtr userdata)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000720")]
		[Address(RVA = "0x329A4D0", Offset = "0x329A4D0", VA = "0x329A4D0", Slot = "65")]
		public RESULT getUserData(out IntPtr userdata)
		{
			return default(RESULT);
		}

		[PreserveSig]
		[Token(Token = "0x6000721")]
		[Address(RVA = "0x3297458", Offset = "0x3297458", VA = "0x3297458")]
		private static extern RESULT FMOD5_Channel_SetFrequency(IntPtr channel, float frequency);

		[PreserveSig]
		[Token(Token = "0x6000722")]
		[Address(RVA = "0x32974F0", Offset = "0x32974F0", VA = "0x32974F0")]
		private static extern RESULT FMOD5_Channel_GetFrequency(IntPtr channel, out float frequency);

		[PreserveSig]
		[Token(Token = "0x6000723")]
		[Address(RVA = "0x3297588", Offset = "0x3297588", VA = "0x3297588")]
		private static extern RESULT FMOD5_Channel_SetPriority(IntPtr channel, int priority);

		[PreserveSig]
		[Token(Token = "0x6000724")]
		[Address(RVA = "0x3297620", Offset = "0x3297620", VA = "0x3297620")]
		private static extern RESULT FMOD5_Channel_GetPriority(IntPtr channel, out int priority);

		[PreserveSig]
		[Token(Token = "0x6000725")]
		[Address(RVA = "0x32976B8", Offset = "0x32976B8", VA = "0x32976B8")]
		private static extern RESULT FMOD5_Channel_SetPosition(IntPtr channel, uint position, TIMEUNIT postype);

		[PreserveSig]
		[Token(Token = "0x6000726")]
		[Address(RVA = "0x3297758", Offset = "0x3297758", VA = "0x3297758")]
		private static extern RESULT FMOD5_Channel_GetPosition(IntPtr channel, out uint position, TIMEUNIT postype);

		[PreserveSig]
		[Token(Token = "0x6000727")]
		[Address(RVA = "0x32977F8", Offset = "0x32977F8", VA = "0x32977F8")]
		private static extern RESULT FMOD5_Channel_SetChannelGroup(IntPtr channel, IntPtr channelgroup);

		[PreserveSig]
		[Token(Token = "0x6000728")]
		[Address(RVA = "0x3297890", Offset = "0x3297890", VA = "0x3297890")]
		private static extern RESULT FMOD5_Channel_GetChannelGroup(IntPtr channel, out IntPtr channelgroup);

		[PreserveSig]
		[Token(Token = "0x6000729")]
		[Address(RVA = "0x3297928", Offset = "0x3297928", VA = "0x3297928")]
		private static extern RESULT FMOD5_Channel_SetLoopCount(IntPtr channel, int loopcount);

		[PreserveSig]
		[Token(Token = "0x600072A")]
		[Address(RVA = "0x32979C0", Offset = "0x32979C0", VA = "0x32979C0")]
		private static extern RESULT FMOD5_Channel_GetLoopCount(IntPtr channel, out int loopcount);

		[PreserveSig]
		[Token(Token = "0x600072B")]
		[Address(RVA = "0x3297A58", Offset = "0x3297A58", VA = "0x3297A58")]
		private static extern RESULT FMOD5_Channel_SetLoopPoints(IntPtr channel, uint loopstart, TIMEUNIT loopstarttype, uint loopend, TIMEUNIT loopendtype);

		[PreserveSig]
		[Token(Token = "0x600072C")]
		[Address(RVA = "0x3297B10", Offset = "0x3297B10", VA = "0x3297B10")]
		private static extern RESULT FMOD5_Channel_GetLoopPoints(IntPtr channel, out uint loopstart, TIMEUNIT loopstarttype, out uint loopend, TIMEUNIT loopendtype);

		[PreserveSig]
		[Token(Token = "0x600072D")]
		[Address(RVA = "0x3297BC8", Offset = "0x3297BC8", VA = "0x3297BC8")]
		private static extern RESULT FMOD5_Channel_IsVirtual(IntPtr channel, out bool isvirtual);

		[PreserveSig]
		[Token(Token = "0x600072E")]
		[Address(RVA = "0x3297C74", Offset = "0x3297C74", VA = "0x3297C74")]
		private static extern RESULT FMOD5_Channel_GetCurrentSound(IntPtr channel, out IntPtr sound);

		[PreserveSig]
		[Token(Token = "0x600072F")]
		[Address(RVA = "0x3297D0C", Offset = "0x3297D0C", VA = "0x3297D0C")]
		private static extern RESULT FMOD5_Channel_GetIndex(IntPtr channel, out int index);

		[PreserveSig]
		[Token(Token = "0x6000730")]
		[Address(RVA = "0x3297DA4", Offset = "0x3297DA4", VA = "0x3297DA4")]
		private static extern RESULT FMOD5_Channel_GetSystemObject(IntPtr channel, out IntPtr system);

		[PreserveSig]
		[Token(Token = "0x6000731")]
		[Address(RVA = "0x3297E3C", Offset = "0x3297E3C", VA = "0x3297E3C")]
		private static extern RESULT FMOD5_Channel_Stop(IntPtr channel);

		[PreserveSig]
		[Token(Token = "0x6000732")]
		[Address(RVA = "0x3297EC8", Offset = "0x3297EC8", VA = "0x3297EC8")]
		private static extern RESULT FMOD5_Channel_SetPaused(IntPtr channel, bool paused);

		[PreserveSig]
		[Token(Token = "0x6000733")]
		[Address(RVA = "0x3297F60", Offset = "0x3297F60", VA = "0x3297F60")]
		private static extern RESULT FMOD5_Channel_GetPaused(IntPtr channel, out bool paused);

		[PreserveSig]
		[Token(Token = "0x6000734")]
		[Address(RVA = "0x329800C", Offset = "0x329800C", VA = "0x329800C")]
		private static extern RESULT FMOD5_Channel_SetVolume(IntPtr channel, float volume);

		[PreserveSig]
		[Token(Token = "0x6000735")]
		[Address(RVA = "0x32980A4", Offset = "0x32980A4", VA = "0x32980A4")]
		private static extern RESULT FMOD5_Channel_GetVolume(IntPtr channel, out float volume);

		[PreserveSig]
		[Token(Token = "0x6000736")]
		[Address(RVA = "0x3298140", Offset = "0x3298140", VA = "0x3298140")]
		private static extern RESULT FMOD5_Channel_SetVolumeRamp(IntPtr channel, bool ramp);

		[PreserveSig]
		[Token(Token = "0x6000737")]
		[Address(RVA = "0x32981D8", Offset = "0x32981D8", VA = "0x32981D8")]
		private static extern RESULT FMOD5_Channel_GetVolumeRamp(IntPtr channel, out bool ramp);

		[PreserveSig]
		[Token(Token = "0x6000738")]
		[Address(RVA = "0x3298284", Offset = "0x3298284", VA = "0x3298284")]
		private static extern RESULT FMOD5_Channel_GetAudibility(IntPtr channel, out float audibility);

		[PreserveSig]
		[Token(Token = "0x6000739")]
		[Address(RVA = "0x329831C", Offset = "0x329831C", VA = "0x329831C")]
		private static extern RESULT FMOD5_Channel_SetPitch(IntPtr channel, float pitch);

		[PreserveSig]
		[Token(Token = "0x600073A")]
		[Address(RVA = "0x32983B4", Offset = "0x32983B4", VA = "0x32983B4")]
		private static extern RESULT FMOD5_Channel_GetPitch(IntPtr channel, out float pitch);

		[PreserveSig]
		[Token(Token = "0x600073B")]
		[Address(RVA = "0x3298450", Offset = "0x3298450", VA = "0x3298450")]
		private static extern RESULT FMOD5_Channel_SetMute(IntPtr channel, bool mute);

		[PreserveSig]
		[Token(Token = "0x600073C")]
		[Address(RVA = "0x32984E8", Offset = "0x32984E8", VA = "0x32984E8")]
		private static extern RESULT FMOD5_Channel_GetMute(IntPtr channel, out bool mute);

		[PreserveSig]
		[Token(Token = "0x600073D")]
		[Address(RVA = "0x3298594", Offset = "0x3298594", VA = "0x3298594")]
		private static extern RESULT FMOD5_Channel_SetReverbProperties(IntPtr channel, int instance, float wet);

		[PreserveSig]
		[Token(Token = "0x600073E")]
		[Address(RVA = "0x329863C", Offset = "0x329863C", VA = "0x329863C")]
		private static extern RESULT FMOD5_Channel_GetReverbProperties(IntPtr channel, int instance, out float wet);

		[PreserveSig]
		[Token(Token = "0x600073F")]
		[Address(RVA = "0x32986DC", Offset = "0x32986DC", VA = "0x32986DC")]
		private static extern RESULT FMOD5_Channel_SetLowPassGain(IntPtr channel, float gain);

		[PreserveSig]
		[Token(Token = "0x6000740")]
		[Address(RVA = "0x3298774", Offset = "0x3298774", VA = "0x3298774")]
		private static extern RESULT FMOD5_Channel_GetLowPassGain(IntPtr channel, out float gain);

		[PreserveSig]
		[Token(Token = "0x6000741")]
		[Address(RVA = "0x329880C", Offset = "0x329880C", VA = "0x329880C")]
		private static extern RESULT FMOD5_Channel_SetMode(IntPtr channel, MODE mode);

		[PreserveSig]
		[Token(Token = "0x6000742")]
		[Address(RVA = "0x32988A4", Offset = "0x32988A4", VA = "0x32988A4")]
		private static extern RESULT FMOD5_Channel_GetMode(IntPtr channel, out MODE mode);

		[PreserveSig]
		[Token(Token = "0x6000743")]
		[Address(RVA = "0x329893C", Offset = "0x329893C", VA = "0x329893C")]
		private static extern RESULT FMOD5_Channel_SetCallback(IntPtr channel, CHANNELCONTROL_CALLBACK callback);

		[PreserveSig]
		[Token(Token = "0x6000744")]
		[Address(RVA = "0x32989DC", Offset = "0x32989DC", VA = "0x32989DC")]
		private static extern RESULT FMOD5_Channel_IsPlaying(IntPtr channel, out bool isplaying);

		[PreserveSig]
		[Token(Token = "0x6000745")]
		[Address(RVA = "0x3298A88", Offset = "0x3298A88", VA = "0x3298A88")]
		private static extern RESULT FMOD5_Channel_SetPan(IntPtr channel, float pan);

		[PreserveSig]
		[Token(Token = "0x6000746")]
		[Address(RVA = "0x3298B20", Offset = "0x3298B20", VA = "0x3298B20")]
		private static extern RESULT FMOD5_Channel_SetMixLevelsOutput(IntPtr channel, float frontleft, float frontright, float center, float lfe, float surroundleft, float surroundright, float backleft, float backright);

		[PreserveSig]
		[Token(Token = "0x6000747")]
		[Address(RVA = "0x3298C08", Offset = "0x3298C08", VA = "0x3298C08")]
		private static extern RESULT FMOD5_Channel_SetMixLevelsInput(IntPtr channel, float[] levels, int numlevels);

		[PreserveSig]
		[Token(Token = "0x6000748")]
		[Address(RVA = "0x3298CB0", Offset = "0x3298CB0", VA = "0x3298CB0")]
		private static extern RESULT FMOD5_Channel_SetMixMatrix(IntPtr channel, float[] matrix, int outchannels, int inchannels, int inchannel_hop);

		[PreserveSig]
		[Token(Token = "0x6000749")]
		[Address(RVA = "0x3298D70", Offset = "0x3298D70", VA = "0x3298D70")]
		private static extern RESULT FMOD5_Channel_GetMixMatrix(IntPtr channel, float[] matrix, out int outchannels, out int inchannels, int inchannel_hop);

		[PreserveSig]
		[Token(Token = "0x600074A")]
		[Address(RVA = "0x3298E30", Offset = "0x3298E30", VA = "0x3298E30")]
		private static extern RESULT FMOD5_Channel_GetDSPClock(IntPtr channel, out ulong dspclock, out ulong parentclock);

		[PreserveSig]
		[Token(Token = "0x600074B")]
		[Address(RVA = "0x3298ED4", Offset = "0x3298ED4", VA = "0x3298ED4")]
		private static extern RESULT FMOD5_Channel_SetDelay(IntPtr channel, ulong dspclock_start, ulong dspclock_end, bool stopchannels);

		[PreserveSig]
		[Token(Token = "0x600074C")]
		[Address(RVA = "0x3298FDC", Offset = "0x3298FDC", VA = "0x3298FDC")]
		private static extern RESULT FMOD5_Channel_GetDelay(IntPtr channel, out ulong dspclock_start, out ulong dspclock_end, IntPtr zero);

		[PreserveSig]
		[Token(Token = "0x600074D")]
		[Address(RVA = "0x329908C", Offset = "0x329908C", VA = "0x329908C")]
		private static extern RESULT FMOD5_Channel_GetDelay(IntPtr channel, out ulong dspclock_start, out ulong dspclock_end, out bool stopchannels);

		[PreserveSig]
		[Token(Token = "0x600074E")]
		[Address(RVA = "0x3299150", Offset = "0x3299150", VA = "0x3299150")]
		private static extern RESULT FMOD5_Channel_AddFadePoint(IntPtr channel, ulong dspclock, float volume);

		[PreserveSig]
		[Token(Token = "0x600074F")]
		[Address(RVA = "0x32991F8", Offset = "0x32991F8", VA = "0x32991F8")]
		private static extern RESULT FMOD5_Channel_SetFadePointRamp(IntPtr channel, ulong dspclock, float volume);

		[PreserveSig]
		[Token(Token = "0x6000750")]
		[Address(RVA = "0x32992A0", Offset = "0x32992A0", VA = "0x32992A0")]
		private static extern RESULT FMOD5_Channel_RemoveFadePoints(IntPtr channel, ulong dspclock_start, ulong dspclock_end);

		[PreserveSig]
		[Token(Token = "0x6000751")]
		[Address(RVA = "0x3299340", Offset = "0x3299340", VA = "0x3299340")]
		private static extern RESULT FMOD5_Channel_GetFadePoints(IntPtr channel, ref uint numpoints, ulong[] point_dspclock, float[] point_volume);

		[PreserveSig]
		[Token(Token = "0x6000752")]
		[Address(RVA = "0x3299400", Offset = "0x3299400", VA = "0x3299400")]
		private static extern RESULT FMOD5_Channel_GetDSP(IntPtr channel, int index, out IntPtr dsp);

		[PreserveSig]
		[Token(Token = "0x6000753")]
		[Address(RVA = "0x329949C", Offset = "0x329949C", VA = "0x329949C")]
		private static extern RESULT FMOD5_Channel_AddDSP(IntPtr channel, int index, IntPtr dsp);

		[PreserveSig]
		[Token(Token = "0x6000754")]
		[Address(RVA = "0x3299538", Offset = "0x3299538", VA = "0x3299538")]
		private static extern RESULT FMOD5_Channel_RemoveDSP(IntPtr channel, IntPtr dsp);

		[PreserveSig]
		[Token(Token = "0x6000755")]
		[Address(RVA = "0x32995D0", Offset = "0x32995D0", VA = "0x32995D0")]
		private static extern RESULT FMOD5_Channel_GetNumDSPs(IntPtr channel, out int numdsps);

		[PreserveSig]
		[Token(Token = "0x6000756")]
		[Address(RVA = "0x3299668", Offset = "0x3299668", VA = "0x3299668")]
		private static extern RESULT FMOD5_Channel_SetDSPIndex(IntPtr channel, IntPtr dsp, int index);

		[PreserveSig]
		[Token(Token = "0x6000757")]
		[Address(RVA = "0x3299708", Offset = "0x3299708", VA = "0x3299708")]
		private static extern RESULT FMOD5_Channel_GetDSPIndex(IntPtr channel, IntPtr dsp, out int index);

		[PreserveSig]
		[Token(Token = "0x6000758")]
		[Address(RVA = "0x32997A8", Offset = "0x32997A8", VA = "0x32997A8")]
		private static extern RESULT FMOD5_Channel_Set3DAttributes(IntPtr channel, ref VECTOR pos, ref VECTOR vel);

		[PreserveSig]
		[Token(Token = "0x6000759")]
		[Address(RVA = "0x3299848", Offset = "0x3299848", VA = "0x3299848")]
		private static extern RESULT FMOD5_Channel_Get3DAttributes(IntPtr channel, out VECTOR pos, out VECTOR vel);

		[PreserveSig]
		[Token(Token = "0x600075A")]
		[Address(RVA = "0x32998E8", Offset = "0x32998E8", VA = "0x32998E8")]
		private static extern RESULT FMOD5_Channel_Set3DMinMaxDistance(IntPtr channel, float mindistance, float maxdistance);

		[PreserveSig]
		[Token(Token = "0x600075B")]
		[Address(RVA = "0x3299988", Offset = "0x3299988", VA = "0x3299988")]
		private static extern RESULT FMOD5_Channel_Get3DMinMaxDistance(IntPtr channel, out float mindistance, out float maxdistance);

		[PreserveSig]
		[Token(Token = "0x600075C")]
		[Address(RVA = "0x3299A28", Offset = "0x3299A28", VA = "0x3299A28")]
		private static extern RESULT FMOD5_Channel_Set3DConeSettings(IntPtr channel, float insideconeangle, float outsideconeangle, float outsidevolume);

		[PreserveSig]
		[Token(Token = "0x600075D")]
		[Address(RVA = "0x3299AD8", Offset = "0x3299AD8", VA = "0x3299AD8")]
		private static extern RESULT FMOD5_Channel_Get3DConeSettings(IntPtr channel, out float insideconeangle, out float outsideconeangle, out float outsidevolume);

		[PreserveSig]
		[Token(Token = "0x600075E")]
		[Address(RVA = "0x3299B88", Offset = "0x3299B88", VA = "0x3299B88")]
		private static extern RESULT FMOD5_Channel_Set3DConeOrientation(IntPtr channel, ref VECTOR orientation);

		[PreserveSig]
		[Token(Token = "0x600075F")]
		[Address(RVA = "0x3299C20", Offset = "0x3299C20", VA = "0x3299C20")]
		private static extern RESULT FMOD5_Channel_Get3DConeOrientation(IntPtr channel, out VECTOR orientation);

		[PreserveSig]
		[Token(Token = "0x6000760")]
		[Address(RVA = "0x3299CB8", Offset = "0x3299CB8", VA = "0x3299CB8")]
		private static extern RESULT FMOD5_Channel_Set3DCustomRolloff(IntPtr channel, ref VECTOR points, int numpoints);

		[PreserveSig]
		[Token(Token = "0x6000761")]
		[Address(RVA = "0x3299D58", Offset = "0x3299D58", VA = "0x3299D58")]
		private static extern RESULT FMOD5_Channel_Get3DCustomRolloff(IntPtr channel, out IntPtr points, out int numpoints);

		[PreserveSig]
		[Token(Token = "0x6000762")]
		[Address(RVA = "0x3299DF8", Offset = "0x3299DF8", VA = "0x3299DF8")]
		private static extern RESULT FMOD5_Channel_Set3DOcclusion(IntPtr channel, float directocclusion, float reverbocclusion);

		[PreserveSig]
		[Token(Token = "0x6000763")]
		[Address(RVA = "0x3299E98", Offset = "0x3299E98", VA = "0x3299E98")]
		private static extern RESULT FMOD5_Channel_Get3DOcclusion(IntPtr channel, out float directocclusion, out float reverbocclusion);

		[PreserveSig]
		[Token(Token = "0x6000764")]
		[Address(RVA = "0x3299F38", Offset = "0x3299F38", VA = "0x3299F38")]
		private static extern RESULT FMOD5_Channel_Set3DSpread(IntPtr channel, float angle);

		[PreserveSig]
		[Token(Token = "0x6000765")]
		[Address(RVA = "0x3299FD0", Offset = "0x3299FD0", VA = "0x3299FD0")]
		private static extern RESULT FMOD5_Channel_Get3DSpread(IntPtr channel, out float angle);

		[PreserveSig]
		[Token(Token = "0x6000766")]
		[Address(RVA = "0x329A068", Offset = "0x329A068", VA = "0x329A068")]
		private static extern RESULT FMOD5_Channel_Set3DLevel(IntPtr channel, float level);

		[PreserveSig]
		[Token(Token = "0x6000767")]
		[Address(RVA = "0x329A100", Offset = "0x329A100", VA = "0x329A100")]
		private static extern RESULT FMOD5_Channel_Get3DLevel(IntPtr channel, out float level);

		[PreserveSig]
		[Token(Token = "0x6000768")]
		[Address(RVA = "0x329A198", Offset = "0x329A198", VA = "0x329A198")]
		private static extern RESULT FMOD5_Channel_Set3DDopplerLevel(IntPtr channel, float level);

		[PreserveSig]
		[Token(Token = "0x6000769")]
		[Address(RVA = "0x329A230", Offset = "0x329A230", VA = "0x329A230")]
		private static extern RESULT FMOD5_Channel_Get3DDopplerLevel(IntPtr channel, out float level);

		[PreserveSig]
		[Token(Token = "0x600076A")]
		[Address(RVA = "0x329A2CC", Offset = "0x329A2CC", VA = "0x329A2CC")]
		private static extern RESULT FMOD5_Channel_Set3DDistanceFilter(IntPtr channel, bool custom, float customLevel, float centerFreq);

		[PreserveSig]
		[Token(Token = "0x600076B")]
		[Address(RVA = "0x329A37C", Offset = "0x329A37C", VA = "0x329A37C")]
		private static extern RESULT FMOD5_Channel_Get3DDistanceFilter(IntPtr channel, out bool custom, out float customLevel, out float centerFreq);

		[PreserveSig]
		[Token(Token = "0x600076C")]
		[Address(RVA = "0x329A440", Offset = "0x329A440", VA = "0x329A440")]
		private static extern RESULT FMOD5_Channel_SetUserData(IntPtr channel, IntPtr userdata);

		[PreserveSig]
		[Token(Token = "0x600076D")]
		[Address(RVA = "0x329A4D8", Offset = "0x329A4D8", VA = "0x329A4D8")]
		private static extern RESULT FMOD5_Channel_GetUserData(IntPtr channel, out IntPtr userdata);

		[Token(Token = "0x600076E")]
		[Address(RVA = "0x329A568", Offset = "0x329A568", VA = "0x329A568")]
		public bool hasHandle()
		{
			return default(bool);
		}

		[Token(Token = "0x600076F")]
		[Address(RVA = "0x329A5B4", Offset = "0x329A5B4", VA = "0x329A5B4")]
		public void clearHandle()
		{
		}
	}
	[Token(Token = "0x20000C6")]
	public struct ChannelGroup : IChannelControl
	{
		[Token(Token = "0x400060E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public IntPtr handle;

		[Token(Token = "0x6000770")]
		[Address(RVA = "0x329A5F8", Offset = "0x329A5F8", VA = "0x329A5F8")]
		public RESULT release()
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000771")]
		[Address(RVA = "0x329A680", Offset = "0x329A680", VA = "0x329A680")]
		public RESULT addGroup(ChannelGroup group, bool propagatedspclock = true)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000772")]
		[Address(RVA = "0x329A788", Offset = "0x329A788", VA = "0x329A788")]
		public RESULT addGroup(ChannelGroup group, bool propagatedspclock, out DSPConnection connection)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000773")]
		[Address(RVA = "0x329A83C", Offset = "0x329A83C", VA = "0x329A83C")]
		public RESULT getNumGroups(out int numgroups)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000774")]
		[Address(RVA = "0x329A8D4", Offset = "0x329A8D4", VA = "0x329A8D4")]
		public RESULT getGroup(int index, out ChannelGroup group)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000775")]
		[Address(RVA = "0x329A974", Offset = "0x329A974", VA = "0x329A974")]
		public RESULT getParentGroup(out ChannelGroup group)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000776")]
		[Address(RVA = "0x329AA0C", Offset = "0x329AA0C", VA = "0x329AA0C")]
		public RESULT getName(out string name, int namelen)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000777")]
		[Address(RVA = "0x329AC58", Offset = "0x329AC58", VA = "0x329AC58")]
		public RESULT getNumChannels(out int numchannels)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000778")]
		[Address(RVA = "0x329ACF0", Offset = "0x329ACF0", VA = "0x329ACF0")]
		public RESULT getChannel(int index, out Channel channel)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000779")]
		[Address(RVA = "0x329AD90", Offset = "0x329AD90", VA = "0x329AD90", Slot = "4")]
		public RESULT getSystemObject(out System system)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600077A")]
		[Address(RVA = "0x329AE28", Offset = "0x329AE28", VA = "0x329AE28", Slot = "5")]
		public RESULT stop()
		{
			return default(RESULT);
		}

		[Token(Token = "0x600077B")]
		[Address(RVA = "0x329AEB0", Offset = "0x329AEB0", VA = "0x329AEB0", Slot = "6")]
		public RESULT setPaused(bool paused)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600077C")]
		[Address(RVA = "0x329AF4C", Offset = "0x329AF4C", VA = "0x329AF4C", Slot = "7")]
		public RESULT getPaused(out bool paused)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600077D")]
		[Address(RVA = "0x329AFF8", Offset = "0x329AFF8", VA = "0x329AFF8", Slot = "8")]
		public RESULT setVolume(float volume)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600077E")]
		[Address(RVA = "0x329B090", Offset = "0x329B090", VA = "0x329B090", Slot = "9")]
		public RESULT getVolume(out float volume)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600077F")]
		[Address(RVA = "0x329B128", Offset = "0x329B128", VA = "0x329B128", Slot = "10")]
		public RESULT setVolumeRamp(bool ramp)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000780")]
		[Address(RVA = "0x329B1C4", Offset = "0x329B1C4", VA = "0x329B1C4", Slot = "11")]
		public RESULT getVolumeRamp(out bool ramp)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000781")]
		[Address(RVA = "0x329B270", Offset = "0x329B270", VA = "0x329B270", Slot = "12")]
		public RESULT getAudibility(out float audibility)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000782")]
		[Address(RVA = "0x329B308", Offset = "0x329B308", VA = "0x329B308", Slot = "13")]
		public RESULT setPitch(float pitch)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000783")]
		[Address(RVA = "0x329B3A0", Offset = "0x329B3A0", VA = "0x329B3A0", Slot = "14")]
		public RESULT getPitch(out float pitch)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000784")]
		[Address(RVA = "0x329B438", Offset = "0x329B438", VA = "0x329B438", Slot = "15")]
		public RESULT setMute(bool mute)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000785")]
		[Address(RVA = "0x329B4D4", Offset = "0x329B4D4", VA = "0x329B4D4", Slot = "16")]
		public RESULT getMute(out bool mute)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000786")]
		[Address(RVA = "0x329B580", Offset = "0x329B580", VA = "0x329B580", Slot = "17")]
		public RESULT setReverbProperties(int instance, float wet)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000787")]
		[Address(RVA = "0x329B628", Offset = "0x329B628", VA = "0x329B628", Slot = "18")]
		public RESULT getReverbProperties(int instance, out float wet)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000788")]
		[Address(RVA = "0x329B6C8", Offset = "0x329B6C8", VA = "0x329B6C8", Slot = "19")]
		public RESULT setLowPassGain(float gain)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000789")]
		[Address(RVA = "0x329B760", Offset = "0x329B760", VA = "0x329B760", Slot = "20")]
		public RESULT getLowPassGain(out float gain)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600078A")]
		[Address(RVA = "0x329B7F8", Offset = "0x329B7F8", VA = "0x329B7F8", Slot = "21")]
		public RESULT setMode(MODE mode)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600078B")]
		[Address(RVA = "0x329B890", Offset = "0x329B890", VA = "0x329B890", Slot = "22")]
		public RESULT getMode(out MODE mode)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600078C")]
		[Address(RVA = "0x329B928", Offset = "0x329B928", VA = "0x329B928", Slot = "23")]
		public RESULT setCallback(CHANNELCONTROL_CALLBACK callback)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600078D")]
		[Address(RVA = "0x329B9C8", Offset = "0x329B9C8", VA = "0x329B9C8", Slot = "24")]
		public RESULT isPlaying(out bool isplaying)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600078E")]
		[Address(RVA = "0x329BA74", Offset = "0x329BA74", VA = "0x329BA74", Slot = "25")]
		public RESULT setPan(float pan)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600078F")]
		[Address(RVA = "0x329BB0C", Offset = "0x329BB0C", VA = "0x329BB0C", Slot = "26")]
		public RESULT setMixLevelsOutput(float frontleft, float frontright, float center, float lfe, float surroundleft, float surroundright, float backleft, float backright)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000790")]
		[Address(RVA = "0x329BBF4", Offset = "0x329BBF4", VA = "0x329BBF4", Slot = "27")]
		public RESULT setMixLevelsInput(float[] levels, int numlevels)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000791")]
		[Address(RVA = "0x329BC9C", Offset = "0x329BC9C", VA = "0x329BC9C", Slot = "28")]
		public RESULT setMixMatrix(float[] matrix, int outchannels, int inchannels, int inchannel_hop)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000792")]
		[Address(RVA = "0x329BD5C", Offset = "0x329BD5C", VA = "0x329BD5C", Slot = "29")]
		public RESULT getMixMatrix(float[] matrix, out int outchannels, out int inchannels, int inchannel_hop)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000793")]
		[Address(RVA = "0x329BE1C", Offset = "0x329BE1C", VA = "0x329BE1C", Slot = "30")]
		public RESULT getDSPClock(out ulong dspclock, out ulong parentclock)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000794")]
		[Address(RVA = "0x329BEBC", Offset = "0x329BEBC", VA = "0x329BEBC", Slot = "31")]
		public RESULT setDelay(ulong dspclock_start, ulong dspclock_end, bool stopchannels)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000795")]
		[Address(RVA = "0x329BF70", Offset = "0x329BF70", VA = "0x329BF70", Slot = "32")]
		public RESULT getDelay(out ulong dspclock_start, out ulong dspclock_end)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000796")]
		[Address(RVA = "0x329C078", Offset = "0x329C078", VA = "0x329C078", Slot = "33")]
		public RESULT getDelay(out ulong dspclock_start, out ulong dspclock_end, out bool stopchannels)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000797")]
		[Address(RVA = "0x329C13C", Offset = "0x329C13C", VA = "0x329C13C", Slot = "34")]
		public RESULT addFadePoint(ulong dspclock, float volume)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000798")]
		[Address(RVA = "0x329C1E4", Offset = "0x329C1E4", VA = "0x329C1E4", Slot = "35")]
		public RESULT setFadePointRamp(ulong dspclock, float volume)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000799")]
		[Address(RVA = "0x329C28C", Offset = "0x329C28C", VA = "0x329C28C", Slot = "36")]
		public RESULT removeFadePoints(ulong dspclock_start, ulong dspclock_end)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600079A")]
		[Address(RVA = "0x329C32C", Offset = "0x329C32C", VA = "0x329C32C", Slot = "37")]
		public RESULT getFadePoints(ref uint numpoints, ulong[] point_dspclock, float[] point_volume)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600079B")]
		[Address(RVA = "0x329C3E8", Offset = "0x329C3E8", VA = "0x329C3E8", Slot = "38")]
		public RESULT getDSP(int index, out DSP dsp)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600079C")]
		[Address(RVA = "0x329C488", Offset = "0x329C488", VA = "0x329C488", Slot = "39")]
		public RESULT addDSP(int index, DSP dsp)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600079D")]
		[Address(RVA = "0x329C528", Offset = "0x329C528", VA = "0x329C528", Slot = "40")]
		public RESULT removeDSP(DSP dsp)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600079E")]
		[Address(RVA = "0x329C5C0", Offset = "0x329C5C0", VA = "0x329C5C0", Slot = "41")]
		public RESULT getNumDSPs(out int numdsps)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600079F")]
		[Address(RVA = "0x329C658", Offset = "0x329C658", VA = "0x329C658", Slot = "42")]
		public RESULT setDSPIndex(DSP dsp, int index)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60007A0")]
		[Address(RVA = "0x329C6F8", Offset = "0x329C6F8", VA = "0x329C6F8", Slot = "43")]
		public RESULT getDSPIndex(DSP dsp, out int index)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60007A1")]
		[Address(RVA = "0x329C798", Offset = "0x329C798", VA = "0x329C798", Slot = "44")]
		public RESULT set3DAttributes(ref VECTOR pos, ref VECTOR vel)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60007A2")]
		[Address(RVA = "0x329C838", Offset = "0x329C838", VA = "0x329C838", Slot = "45")]
		public RESULT get3DAttributes(out VECTOR pos, out VECTOR vel)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60007A3")]
		[Address(RVA = "0x329C8D8", Offset = "0x329C8D8", VA = "0x329C8D8", Slot = "46")]
		public RESULT set3DMinMaxDistance(float mindistance, float maxdistance)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60007A4")]
		[Address(RVA = "0x329C978", Offset = "0x329C978", VA = "0x329C978", Slot = "47")]
		public RESULT get3DMinMaxDistance(out float mindistance, out float maxdistance)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60007A5")]
		[Address(RVA = "0x329CA18", Offset = "0x329CA18", VA = "0x329CA18", Slot = "48")]
		public RESULT set3DConeSettings(float insideconeangle, float outsideconeangle, float outsidevolume)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60007A6")]
		[Address(RVA = "0x329CAC8", Offset = "0x329CAC8", VA = "0x329CAC8", Slot = "49")]
		public RESULT get3DConeSettings(out float insideconeangle, out float outsideconeangle, out float outsidevolume)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60007A7")]
		[Address(RVA = "0x329CB78", Offset = "0x329CB78", VA = "0x329CB78", Slot = "50")]
		public RESULT set3DConeOrientation(ref VECTOR orientation)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60007A8")]
		[Address(RVA = "0x329CC10", Offset = "0x329CC10", VA = "0x329CC10", Slot = "51")]
		public RESULT get3DConeOrientation(out VECTOR orientation)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60007A9")]
		[Address(RVA = "0x329CCA8", Offset = "0x329CCA8", VA = "0x329CCA8", Slot = "52")]
		public RESULT set3DCustomRolloff(ref VECTOR points, int numpoints)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60007AA")]
		[Address(RVA = "0x329CD48", Offset = "0x329CD48", VA = "0x329CD48", Slot = "53")]
		public RESULT get3DCustomRolloff(out IntPtr points, out int numpoints)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60007AB")]
		[Address(RVA = "0x329CDE8", Offset = "0x329CDE8", VA = "0x329CDE8", Slot = "54")]
		public RESULT set3DOcclusion(float directocclusion, float reverbocclusion)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60007AC")]
		[Address(RVA = "0x329CE88", Offset = "0x329CE88", VA = "0x329CE88", Slot = "55")]
		public RESULT get3DOcclusion(out float directocclusion, out float reverbocclusion)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60007AD")]
		[Address(RVA = "0x329CF28", Offset = "0x329CF28", VA = "0x329CF28", Slot = "56")]
		public RESULT set3DSpread(float angle)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60007AE")]
		[Address(RVA = "0x329CFC0", Offset = "0x329CFC0", VA = "0x329CFC0", Slot = "57")]
		public RESULT get3DSpread(out float angle)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60007AF")]
		[Address(RVA = "0x329D058", Offset = "0x329D058", VA = "0x329D058", Slot = "58")]
		public RESULT set3DLevel(float level)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60007B0")]
		[Address(RVA = "0x329D0F0", Offset = "0x329D0F0", VA = "0x329D0F0", Slot = "59")]
		public RESULT get3DLevel(out float level)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60007B1")]
		[Address(RVA = "0x329D188", Offset = "0x329D188", VA = "0x329D188", Slot = "60")]
		public RESULT set3DDopplerLevel(float level)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60007B2")]
		[Address(RVA = "0x329D220", Offset = "0x329D220", VA = "0x329D220", Slot = "61")]
		public RESULT get3DDopplerLevel(out float level)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60007B3")]
		[Address(RVA = "0x329D2B8", Offset = "0x329D2B8", VA = "0x329D2B8", Slot = "62")]
		public RESULT set3DDistanceFilter(bool custom, float customLevel, float centerFreq)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60007B4")]
		[Address(RVA = "0x329D36C", Offset = "0x329D36C", VA = "0x329D36C", Slot = "63")]
		public RESULT get3DDistanceFilter(out bool custom, out float customLevel, out float centerFreq)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60007B5")]
		[Address(RVA = "0x329D430", Offset = "0x329D430", VA = "0x329D430", Slot = "64")]
		public RESULT setUserData(IntPtr userdata)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60007B6")]
		[Address(RVA = "0x329D4C8", Offset = "0x329D4C8", VA = "0x329D4C8", Slot = "65")]
		public RESULT getUserData(out IntPtr userdata)
		{
			return default(RESULT);
		}

		[PreserveSig]
		[Token(Token = "0x60007B7")]
		[Address(RVA = "0x329A600", Offset = "0x329A600", VA = "0x329A600")]
		private static extern RESULT FMOD5_ChannelGroup_Release(IntPtr channelgroup);

		[PreserveSig]
		[Token(Token = "0x60007B8")]
		[Address(RVA = "0x329A6E0", Offset = "0x329A6E0", VA = "0x329A6E0")]
		private static extern RESULT FMOD5_ChannelGroup_AddGroup(IntPtr channelgroup, IntPtr group, bool propagatedspclock, IntPtr zero);

		[PreserveSig]
		[Token(Token = "0x60007B9")]
		[Address(RVA = "0x329A794", Offset = "0x329A794", VA = "0x329A794")]
		private static extern RESULT FMOD5_ChannelGroup_AddGroup(IntPtr channelgroup, IntPtr group, bool propagatedspclock, out IntPtr connection);

		[PreserveSig]
		[Token(Token = "0x60007BA")]
		[Address(RVA = "0x329A844", Offset = "0x329A844", VA = "0x329A844")]
		private static extern RESULT FMOD5_ChannelGroup_GetNumGroups(IntPtr channelgroup, out int numgroups);

		[PreserveSig]
		[Token(Token = "0x60007BB")]
		[Address(RVA = "0x329A8DC", Offset = "0x329A8DC", VA = "0x329A8DC")]
		private static extern RESULT FMOD5_ChannelGroup_GetGroup(IntPtr channelgroup, int index, out IntPtr group);

		[PreserveSig]
		[Token(Token = "0x60007BC")]
		[Address(RVA = "0x329A97C", Offset = "0x329A97C", VA = "0x329A97C")]
		private static extern RESULT FMOD5_ChannelGroup_GetParentGroup(IntPtr channelgroup, out IntPtr group);

		[PreserveSig]
		[Token(Token = "0x60007BD")]
		[Address(RVA = "0x329ABC0", Offset = "0x329ABC0", VA = "0x329ABC0")]
		private static extern RESULT FMOD5_ChannelGroup_GetName(IntPtr channelgroup, IntPtr name, int namelen);

		[PreserveSig]
		[Token(Token = "0x60007BE")]
		[Address(RVA = "0x329AC60", Offset = "0x329AC60", VA = "0x329AC60")]
		private static extern RESULT FMOD5_ChannelGroup_GetNumChannels(IntPtr channelgroup, out int numchannels);

		[PreserveSig]
		[Token(Token = "0x60007BF")]
		[Address(RVA = "0x329ACF8", Offset = "0x329ACF8", VA = "0x329ACF8")]
		private static extern RESULT FMOD5_ChannelGroup_GetChannel(IntPtr channelgroup, int index, out IntPtr channel);

		[PreserveSig]
		[Token(Token = "0x60007C0")]
		[Address(RVA = "0x329AD98", Offset = "0x329AD98", VA = "0x329AD98")]
		private static extern RESULT FMOD5_ChannelGroup_GetSystemObject(IntPtr channelgroup, out IntPtr system);

		[PreserveSig]
		[Token(Token = "0x60007C1")]
		[Address(RVA = "0x329AE30", Offset = "0x329AE30", VA = "0x329AE30")]
		private static extern RESULT FMOD5_ChannelGroup_Stop(IntPtr channelgroup);

		[PreserveSig]
		[Token(Token = "0x60007C2")]
		[Address(RVA = "0x329AEBC", Offset = "0x329AEBC", VA = "0x329AEBC")]
		private static extern RESULT FMOD5_ChannelGroup_SetPaused(IntPtr channelgroup, bool paused);

		[PreserveSig]
		[Token(Token = "0x60007C3")]
		[Address(RVA = "0x329AF54", Offset = "0x329AF54", VA = "0x329AF54")]
		private static extern RESULT FMOD5_ChannelGroup_GetPaused(IntPtr channelgroup, out bool paused);

		[PreserveSig]
		[Token(Token = "0x60007C4")]
		[Address(RVA = "0x329B000", Offset = "0x329B000", VA = "0x329B000")]
		private static extern RESULT FMOD5_ChannelGroup_SetVolume(IntPtr channelgroup, float volume);

		[PreserveSig]
		[Token(Token = "0x60007C5")]
		[Address(RVA = "0x329B098", Offset = "0x329B098", VA = "0x329B098")]
		private static extern RESULT FMOD5_ChannelGroup_GetVolume(IntPtr channelgroup, out float volume);

		[PreserveSig]
		[Token(Token = "0x60007C6")]
		[Address(RVA = "0x329B134", Offset = "0x329B134", VA = "0x329B134")]
		private static extern RESULT FMOD5_ChannelGroup_SetVolumeRamp(IntPtr channelgroup, bool ramp);

		[PreserveSig]
		[Token(Token = "0x60007C7")]
		[Address(RVA = "0x329B1CC", Offset = "0x329B1CC", VA = "0x329B1CC")]
		private static extern RESULT FMOD5_ChannelGroup_GetVolumeRamp(IntPtr channelgroup, out bool ramp);

		[PreserveSig]
		[Token(Token = "0x60007C8")]
		[Address(RVA = "0x329B278", Offset = "0x329B278", VA = "0x329B278")]
		private static extern RESULT FMOD5_ChannelGroup_GetAudibility(IntPtr channelgroup, out float audibility);

		[PreserveSig]
		[Token(Token = "0x60007C9")]
		[Address(RVA = "0x329B310", Offset = "0x329B310", VA = "0x329B310")]
		private static extern RESULT FMOD5_ChannelGroup_SetPitch(IntPtr channelgroup, float pitch);

		[PreserveSig]
		[Token(Token = "0x60007CA")]
		[Address(RVA = "0x329B3A8", Offset = "0x329B3A8", VA = "0x329B3A8")]
		private static extern RESULT FMOD5_ChannelGroup_GetPitch(IntPtr channelgroup, out float pitch);

		[PreserveSig]
		[Token(Token = "0x60007CB")]
		[Address(RVA = "0x329B444", Offset = "0x329B444", VA = "0x329B444")]
		private static extern RESULT FMOD5_ChannelGroup_SetMute(IntPtr channelgroup, bool mute);

		[PreserveSig]
		[Token(Token = "0x60007CC")]
		[Address(RVA = "0x329B4DC", Offset = "0x329B4DC", VA = "0x329B4DC")]
		private static extern RESULT FMOD5_ChannelGroup_GetMute(IntPtr channelgroup, out bool mute);

		[PreserveSig]
		[Token(Token = "0x60007CD")]
		[Address(RVA = "0x329B588", Offset = "0x329B588", VA = "0x329B588")]
		private static extern RESULT FMOD5_ChannelGroup_SetReverbProperties(IntPtr channelgroup, int instance, float wet);

		[PreserveSig]
		[Token(Token = "0x60007CE")]
		[Address(RVA = "0x329B630", Offset = "0x329B630", VA = "0x329B630")]
		private static extern RESULT FMOD5_ChannelGroup_GetReverbProperties(IntPtr channelgroup, int instance, out float wet);

		[PreserveSig]
		[Token(Token = "0x60007CF")]
		[Address(RVA = "0x329B6D0", Offset = "0x329B6D0", VA = "0x329B6D0")]
		private static extern RESULT FMOD5_ChannelGroup_SetLowPassGain(IntPtr channelgroup, float gain);

		[PreserveSig]
		[Token(Token = "0x60007D0")]
		[Address(RVA = "0x329B768", Offset = "0x329B768", VA = "0x329B768")]
		private static extern RESULT FMOD5_ChannelGroup_GetLowPassGain(IntPtr channelgroup, out float gain);

		[PreserveSig]
		[Token(Token = "0x60007D1")]
		[Address(RVA = "0x329B800", Offset = "0x329B800", VA = "0x329B800")]
		private static extern RESULT FMOD5_ChannelGroup_SetMode(IntPtr channelgroup, MODE mode);

		[PreserveSig]
		[Token(Token = "0x60007D2")]
		[Address(RVA = "0x329B898", Offset = "0x329B898", VA = "0x329B898")]
		private static extern RESULT FMOD5_ChannelGroup_GetMode(IntPtr channelgroup, out MODE mode);

		[PreserveSig]
		[Token(Token = "0x60007D3")]
		[Address(RVA = "0x329B930", Offset = "0x329B930", VA = "0x329B930")]
		private static extern RESULT FMOD5_ChannelGroup_SetCallback(IntPtr channelgroup, CHANNELCONTROL_CALLBACK callback);

		[PreserveSig]
		[Token(Token = "0x60007D4")]
		[Address(RVA = "0x329B9D0", Offset = "0x329B9D0", VA = "0x329B9D0")]
		private static extern RESULT FMOD5_ChannelGroup_IsPlaying(IntPtr channelgroup, out bool isplaying);

		[PreserveSig]
		[Token(Token = "0x60007D5")]
		[Address(RVA = "0x329BA7C", Offset = "0x329BA7C", VA = "0x329BA7C")]
		private static extern RESULT FMOD5_ChannelGroup_SetPan(IntPtr channelgroup, float pan);

		[PreserveSig]
		[Token(Token = "0x60007D6")]
		[Address(RVA = "0x329BB14", Offset = "0x329BB14", VA = "0x329BB14")]
		private static extern RESULT FMOD5_ChannelGroup_SetMixLevelsOutput(IntPtr channelgroup, float frontleft, float frontright, float center, float lfe, float surroundleft, float surroundright, float backleft, float backright);

		[PreserveSig]
		[Token(Token = "0x60007D7")]
		[Address(RVA = "0x329BBFC", Offset = "0x329BBFC", VA = "0x329BBFC")]
		private static extern RESULT FMOD5_ChannelGroup_SetMixLevelsInput(IntPtr channelgroup, float[] levels, int numlevels);

		[PreserveSig]
		[Token(Token = "0x60007D8")]
		[Address(RVA = "0x329BCA4", Offset = "0x329BCA4", VA = "0x329BCA4")]
		private static extern RESULT FMOD5_ChannelGroup_SetMixMatrix(IntPtr channelgroup, float[] matrix, int outchannels, int inchannels, int inchannel_hop);

		[PreserveSig]
		[Token(Token = "0x60007D9")]
		[Address(RVA = "0x329BD64", Offset = "0x329BD64", VA = "0x329BD64")]
		private static extern RESULT FMOD5_ChannelGroup_GetMixMatrix(IntPtr channelgroup, float[] matrix, out int outchannels, out int inchannels, int inchannel_hop);

		[PreserveSig]
		[Token(Token = "0x60007DA")]
		[Address(RVA = "0x329BE24", Offset = "0x329BE24", VA = "0x329BE24")]
		private static extern RESULT FMOD5_ChannelGroup_GetDSPClock(IntPtr channelgroup, out ulong dspclock, out ulong parentclock);

		[PreserveSig]
		[Token(Token = "0x60007DB")]
		[Address(RVA = "0x329BEC8", Offset = "0x329BEC8", VA = "0x329BEC8")]
		private static extern RESULT FMOD5_ChannelGroup_SetDelay(IntPtr channelgroup, ulong dspclock_start, ulong dspclock_end, bool stopchannels);

		[PreserveSig]
		[Token(Token = "0x60007DC")]
		[Address(RVA = "0x329BFD0", Offset = "0x329BFD0", VA = "0x329BFD0")]
		private static extern RESULT FMOD5_ChannelGroup_GetDelay(IntPtr channelgroup, out ulong dspclock_start, out ulong dspclock_end, IntPtr zero);

		[PreserveSig]
		[Token(Token = "0x60007DD")]
		[Address(RVA = "0x329C080", Offset = "0x329C080", VA = "0x329C080")]
		private static extern RESULT FMOD5_ChannelGroup_GetDelay(IntPtr channelgroup, out ulong dspclock_start, out ulong dspclock_end, out bool stopchannels);

		[PreserveSig]
		[Token(Token = "0x60007DE")]
		[Address(RVA = "0x329C144", Offset = "0x329C144", VA = "0x329C144")]
		private static extern RESULT FMOD5_ChannelGroup_AddFadePoint(IntPtr channelgroup, ulong dspclock, float volume);

		[PreserveSig]
		[Token(Token = "0x60007DF")]
		[Address(RVA = "0x329C1EC", Offset = "0x329C1EC", VA = "0x329C1EC")]
		private static extern RESULT FMOD5_ChannelGroup_SetFadePointRamp(IntPtr channelgroup, ulong dspclock, float volume);

		[PreserveSig]
		[Token(Token = "0x60007E0")]
		[Address(RVA = "0x329C294", Offset = "0x329C294", VA = "0x329C294")]
		private static extern RESULT FMOD5_ChannelGroup_RemoveFadePoints(IntPtr channelgroup, ulong dspclock_start, ulong dspclock_end);

		[PreserveSig]
		[Token(Token = "0x60007E1")]
		[Address(RVA = "0x329C334", Offset = "0x329C334", VA = "0x329C334")]
		private static extern RESULT FMOD5_ChannelGroup_GetFadePoints(IntPtr channelgroup, ref uint numpoints, ulong[] point_dspclock, float[] point_volume);

		[PreserveSig]
		[Token(Token = "0x60007E2")]
		[Address(RVA = "0x329C3F0", Offset = "0x329C3F0", VA = "0x329C3F0")]
		private static extern RESULT FMOD5_ChannelGroup_GetDSP(IntPtr channelgroup, int index, out IntPtr dsp);

		[PreserveSig]
		[Token(Token = "0x60007E3")]
		[Address(RVA = "0x329C490", Offset = "0x329C490", VA = "0x329C490")]
		private static extern RESULT FMOD5_ChannelGroup_AddDSP(IntPtr channelgroup, int index, IntPtr dsp);

		[PreserveSig]
		[Token(Token = "0x60007E4")]
		[Address(RVA = "0x329C530", Offset = "0x329C530", VA = "0x329C530")]
		private static extern RESULT FMOD5_ChannelGroup_RemoveDSP(IntPtr channelgroup, IntPtr dsp);

		[PreserveSig]
		[Token(Token = "0x60007E5")]
		[Address(RVA = "0x329C5C8", Offset = "0x329C5C8", VA = "0x329C5C8")]
		private static extern RESULT FMOD5_ChannelGroup_GetNumDSPs(IntPtr channelgroup, out int numdsps);

		[PreserveSig]
		[Token(Token = "0x60007E6")]
		[Address(RVA = "0x329C660", Offset = "0x329C660", VA = "0x329C660")]
		private static extern RESULT FMOD5_ChannelGroup_SetDSPIndex(IntPtr channelgroup, IntPtr dsp, int index);

		[PreserveSig]
		[Token(Token = "0x60007E7")]
		[Address(RVA = "0x329C700", Offset = "0x329C700", VA = "0x329C700")]
		private static extern RESULT FMOD5_ChannelGroup_GetDSPIndex(IntPtr channelgroup, IntPtr dsp, out int index);

		[PreserveSig]
		[Token(Token = "0x60007E8")]
		[Address(RVA = "0x329C7A0", Offset = "0x329C7A0", VA = "0x329C7A0")]
		private static extern RESULT FMOD5_ChannelGroup_Set3DAttributes(IntPtr channelgroup, ref VECTOR pos, ref VECTOR vel);

		[PreserveSig]
		[Token(Token = "0x60007E9")]
		[Address(RVA = "0x329C840", Offset = "0x329C840", VA = "0x329C840")]
		private static extern RESULT FMOD5_ChannelGroup_Get3DAttributes(IntPtr channelgroup, out VECTOR pos, out VECTOR vel);

		[PreserveSig]
		[Token(Token = "0x60007EA")]
		[Address(RVA = "0x329C8E0", Offset = "0x329C8E0", VA = "0x329C8E0")]
		private static extern RESULT FMOD5_ChannelGroup_Set3DMinMaxDistance(IntPtr channelgroup, float mindistance, float maxdistance);

		[PreserveSig]
		[Token(Token = "0x60007EB")]
		[Address(RVA = "0x329C980", Offset = "0x329C980", VA = "0x329C980")]
		private static extern RESULT FMOD5_ChannelGroup_Get3DMinMaxDistance(IntPtr channelgroup, out float mindistance, out float maxdistance);

		[PreserveSig]
		[Token(Token = "0x60007EC")]
		[Address(RVA = "0x329CA20", Offset = "0x329CA20", VA = "0x329CA20")]
		private static extern RESULT FMOD5_ChannelGroup_Set3DConeSettings(IntPtr channelgroup, float insideconeangle, float outsideconeangle, float outsidevolume);

		[PreserveSig]
		[Token(Token = "0x60007ED")]
		[Address(RVA = "0x329CAD0", Offset = "0x329CAD0", VA = "0x329CAD0")]
		private static extern RESULT FMOD5_ChannelGroup_Get3DConeSettings(IntPtr channelgroup, out float insideconeangle, out float outsideconeangle, out float outsidevolume);

		[PreserveSig]
		[Token(Token = "0x60007EE")]
		[Address(RVA = "0x329CB80", Offset = "0x329CB80", VA = "0x329CB80")]
		private static extern RESULT FMOD5_ChannelGroup_Set3DConeOrientation(IntPtr channelgroup, ref VECTOR orientation);

		[PreserveSig]
		[Token(Token = "0x60007EF")]
		[Address(RVA = "0x329CC18", Offset = "0x329CC18", VA = "0x329CC18")]
		private static extern RESULT FMOD5_ChannelGroup_Get3DConeOrientation(IntPtr channelgroup, out VECTOR orientation);

		[PreserveSig]
		[Token(Token = "0x60007F0")]
		[Address(RVA = "0x329CCB0", Offset = "0x329CCB0", VA = "0x329CCB0")]
		private static extern RESULT FMOD5_ChannelGroup_Set3DCustomRolloff(IntPtr channelgroup, ref VECTOR points, int numpoints);

		[PreserveSig]
		[Token(Token = "0x60007F1")]
		[Address(RVA = "0x329CD50", Offset = "0x329CD50", VA = "0x329CD50")]
		private static extern RESULT FMOD5_ChannelGroup_Get3DCustomRolloff(IntPtr channelgroup, out IntPtr points, out int numpoints);

		[PreserveSig]
		[Token(Token = "0x60007F2")]
		[Address(RVA = "0x329CDF0", Offset = "0x329CDF0", VA = "0x329CDF0")]
		private static extern RESULT FMOD5_ChannelGroup_Set3DOcclusion(IntPtr channelgroup, float directocclusion, float reverbocclusion);

		[PreserveSig]
		[Token(Token = "0x60007F3")]
		[Address(RVA = "0x329CE90", Offset = "0x329CE90", VA = "0x329CE90")]
		private static extern RESULT FMOD5_ChannelGroup_Get3DOcclusion(IntPtr channelgroup, out float directocclusion, out float reverbocclusion);

		[PreserveSig]
		[Token(Token = "0x60007F4")]
		[Address(RVA = "0x329CF30", Offset = "0x329CF30", VA = "0x329CF30")]
		private static extern RESULT FMOD5_ChannelGroup_Set3DSpread(IntPtr channelgroup, float angle);

		[PreserveSig]
		[Token(Token = "0x60007F5")]
		[Address(RVA = "0x329CFC8", Offset = "0x329CFC8", VA = "0x329CFC8")]
		private static extern RESULT FMOD5_ChannelGroup_Get3DSpread(IntPtr channelgroup, out float angle);

		[PreserveSig]
		[Token(Token = "0x60007F6")]
		[Address(RVA = "0x329D060", Offset = "0x329D060", VA = "0x329D060")]
		private static extern RESULT FMOD5_ChannelGroup_Set3DLevel(IntPtr channelgroup, float level);

		[PreserveSig]
		[Token(Token = "0x60007F7")]
		[Address(RVA = "0x329D0F8", Offset = "0x329D0F8", VA = "0x329D0F8")]
		private static extern RESULT FMOD5_ChannelGroup_Get3DLevel(IntPtr channelgroup, out float level);

		[PreserveSig]
		[Token(Token = "0x60007F8")]
		[Address(RVA = "0x329D190", Offset = "0x329D190", VA = "0x329D190")]
		private static extern RESULT FMOD5_ChannelGroup_Set3DDopplerLevel(IntPtr channelgroup, float level);

		[PreserveSig]
		[Token(Token = "0x60007F9")]
		[Address(RVA = "0x329D228", Offset = "0x329D228", VA = "0x329D228")]
		private static extern RESULT FMOD5_ChannelGroup_Get3DDopplerLevel(IntPtr channelgroup, out float level);

		[PreserveSig]
		[Token(Token = "0x60007FA")]
		[Address(RVA = "0x329D2C4", Offset = "0x329D2C4", VA = "0x329D2C4")]
		private static extern RESULT FMOD5_ChannelGroup_Set3DDistanceFilter(IntPtr channelgroup, bool custom, float customLevel, float centerFreq);

		[PreserveSig]
		[Token(Token = "0x60007FB")]
		[Address(RVA = "0x329D374", Offset = "0x329D374", VA = "0x329D374")]
		private static extern RESULT FMOD5_ChannelGroup_Get3DDistanceFilter(IntPtr channelgroup, out bool custom, out float customLevel, out float centerFreq);

		[PreserveSig]
		[Token(Token = "0x60007FC")]
		[Address(RVA = "0x329D438", Offset = "0x329D438", VA = "0x329D438")]
		private static extern RESULT FMOD5_ChannelGroup_SetUserData(IntPtr channelgroup, IntPtr userdata);

		[PreserveSig]
		[Token(Token = "0x60007FD")]
		[Address(RVA = "0x329D4D0", Offset = "0x329D4D0", VA = "0x329D4D0")]
		private static extern RESULT FMOD5_ChannelGroup_GetUserData(IntPtr channelgroup, out IntPtr userdata);

		[Token(Token = "0x60007FE")]
		[Address(RVA = "0x329D560", Offset = "0x329D560", VA = "0x329D560")]
		public bool hasHandle()
		{
			return default(bool);
		}

		[Token(Token = "0x60007FF")]
		[Address(RVA = "0x329D5AC", Offset = "0x329D5AC", VA = "0x329D5AC")]
		public void clearHandle()
		{
		}
	}
	[Token(Token = "0x20000C7")]
	public struct SoundGroup
	{
		[Token(Token = "0x400060F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public IntPtr handle;

		[Token(Token = "0x6000800")]
		[Address(RVA = "0x3260244", Offset = "0x3260244", VA = "0x3260244")]
		public RESULT release()
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000801")]
		[Address(RVA = "0x32602CC", Offset = "0x32602CC", VA = "0x32602CC")]
		public RESULT getSystemObject(out System system)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000802")]
		[Address(RVA = "0x3260364", Offset = "0x3260364", VA = "0x3260364")]
		public RESULT setMaxAudible(int maxaudible)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000803")]
		[Address(RVA = "0x32603FC", Offset = "0x32603FC", VA = "0x32603FC")]
		public RESULT getMaxAudible(out int maxaudible)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000804")]
		[Address(RVA = "0x3260494", Offset = "0x3260494", VA = "0x3260494")]
		public RESULT setMaxAudibleBehavior(SOUNDGROUP_BEHAVIOR behavior)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000805")]
		[Address(RVA = "0x326052C", Offset = "0x326052C", VA = "0x326052C")]
		public RESULT getMaxAudibleBehavior(out SOUNDGROUP_BEHAVIOR behavior)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000806")]
		[Address(RVA = "0x32605C4", Offset = "0x32605C4", VA = "0x32605C4")]
		public RESULT setMuteFadeSpeed(float speed)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000807")]
		[Address(RVA = "0x326065C", Offset = "0x326065C", VA = "0x326065C")]
		public RESULT getMuteFadeSpeed(out float speed)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000808")]
		[Address(RVA = "0x32606F4", Offset = "0x32606F4", VA = "0x32606F4")]
		public RESULT setVolume(float volume)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000809")]
		[Address(RVA = "0x326078C", Offset = "0x326078C", VA = "0x326078C")]
		public RESULT getVolume(out float volume)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600080A")]
		[Address(RVA = "0x3260824", Offset = "0x3260824", VA = "0x3260824")]
		public RESULT stop()
		{
			return default(RESULT);
		}

		[Token(Token = "0x600080B")]
		[Address(RVA = "0x32608AC", Offset = "0x32608AC", VA = "0x32608AC")]
		public RESULT getName(out string name, int namelen)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600080C")]
		[Address(RVA = "0x3260AF0", Offset = "0x3260AF0", VA = "0x3260AF0")]
		public RESULT getNumSounds(out int numsounds)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600080D")]
		[Address(RVA = "0x3260B88", Offset = "0x3260B88", VA = "0x3260B88")]
		public RESULT getSound(int index, out Sound sound)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600080E")]
		[Address(RVA = "0x3260C28", Offset = "0x3260C28", VA = "0x3260C28")]
		public RESULT getNumPlaying(out int numplaying)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600080F")]
		[Address(RVA = "0x3260CC0", Offset = "0x3260CC0", VA = "0x3260CC0")]
		public RESULT setUserData(IntPtr userdata)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000810")]
		[Address(RVA = "0x3260D58", Offset = "0x3260D58", VA = "0x3260D58")]
		public RESULT getUserData(out IntPtr userdata)
		{
			return default(RESULT);
		}

		[PreserveSig]
		[Token(Token = "0x6000811")]
		[Address(RVA = "0x326024C", Offset = "0x326024C", VA = "0x326024C")]
		private static extern RESULT FMOD5_SoundGroup_Release(IntPtr soundgroup);

		[PreserveSig]
		[Token(Token = "0x6000812")]
		[Address(RVA = "0x32602D4", Offset = "0x32602D4", VA = "0x32602D4")]
		private static extern RESULT FMOD5_SoundGroup_GetSystemObject(IntPtr soundgroup, out IntPtr system);

		[PreserveSig]
		[Token(Token = "0x6000813")]
		[Address(RVA = "0x326036C", Offset = "0x326036C", VA = "0x326036C")]
		private static extern RESULT FMOD5_SoundGroup_SetMaxAudible(IntPtr soundgroup, int maxaudible);

		[PreserveSig]
		[Token(Token = "0x6000814")]
		[Address(RVA = "0x3260404", Offset = "0x3260404", VA = "0x3260404")]
		private static extern RESULT FMOD5_SoundGroup_GetMaxAudible(IntPtr soundgroup, out int maxaudible);

		[PreserveSig]
		[Token(Token = "0x6000815")]
		[Address(RVA = "0x326049C", Offset = "0x326049C", VA = "0x326049C")]
		private static extern RESULT FMOD5_SoundGroup_SetMaxAudibleBehavior(IntPtr soundgroup, SOUNDGROUP_BEHAVIOR behavior);

		[PreserveSig]
		[Token(Token = "0x6000816")]
		[Address(RVA = "0x3260534", Offset = "0x3260534", VA = "0x3260534")]
		private static extern RESULT FMOD5_SoundGroup_GetMaxAudibleBehavior(IntPtr soundgroup, out SOUNDGROUP_BEHAVIOR behavior);

		[PreserveSig]
		[Token(Token = "0x6000817")]
		[Address(RVA = "0x32605CC", Offset = "0x32605CC", VA = "0x32605CC")]
		private static extern RESULT FMOD5_SoundGroup_SetMuteFadeSpeed(IntPtr soundgroup, float speed);

		[PreserveSig]
		[Token(Token = "0x6000818")]
		[Address(RVA = "0x3260664", Offset = "0x3260664", VA = "0x3260664")]
		private static extern RESULT FMOD5_SoundGroup_GetMuteFadeSpeed(IntPtr soundgroup, out float speed);

		[PreserveSig]
		[Token(Token = "0x6000819")]
		[Address(RVA = "0x32606FC", Offset = "0x32606FC", VA = "0x32606FC")]
		private static extern RESULT FMOD5_SoundGroup_SetVolume(IntPtr soundgroup, float volume);

		[PreserveSig]
		[Token(Token = "0x600081A")]
		[Address(RVA = "0x3260794", Offset = "0x3260794", VA = "0x3260794")]
		private static extern RESULT FMOD5_SoundGroup_GetVolume(IntPtr soundgroup, out float volume);

		[PreserveSig]
		[Token(Token = "0x600081B")]
		[Address(RVA = "0x326082C", Offset = "0x326082C", VA = "0x326082C")]
		private static extern RESULT FMOD5_SoundGroup_Stop(IntPtr soundgroup);

		[PreserveSig]
		[Token(Token = "0x600081C")]
		[Address(RVA = "0x3260A58", Offset = "0x3260A58", VA = "0x3260A58")]
		private static extern RESULT FMOD5_SoundGroup_GetName(IntPtr soundgroup, IntPtr name, int namelen);

		[PreserveSig]
		[Token(Token = "0x600081D")]
		[Address(RVA = "0x3260AF8", Offset = "0x3260AF8", VA = "0x3260AF8")]
		private static extern RESULT FMOD5_SoundGroup_GetNumSounds(IntPtr soundgroup, out int numsounds);

		[PreserveSig]
		[Token(Token = "0x600081E")]
		[Address(RVA = "0x3260B90", Offset = "0x3260B90", VA = "0x3260B90")]
		private static extern RESULT FMOD5_SoundGroup_GetSound(IntPtr soundgroup, int index, out IntPtr sound);

		[PreserveSig]
		[Token(Token = "0x600081F")]
		[Address(RVA = "0x3260C30", Offset = "0x3260C30", VA = "0x3260C30")]
		private static extern RESULT FMOD5_SoundGroup_GetNumPlaying(IntPtr soundgroup, out int numplaying);

		[PreserveSig]
		[Token(Token = "0x6000820")]
		[Address(RVA = "0x3260CC8", Offset = "0x3260CC8", VA = "0x3260CC8")]
		private static extern RESULT FMOD5_SoundGroup_SetUserData(IntPtr soundgroup, IntPtr userdata);

		[PreserveSig]
		[Token(Token = "0x6000821")]
		[Address(RVA = "0x3260D60", Offset = "0x3260D60", VA = "0x3260D60")]
		private static extern RESULT FMOD5_SoundGroup_GetUserData(IntPtr soundgroup, out IntPtr userdata);

		[Token(Token = "0x6000822")]
		[Address(RVA = "0x3260DF0", Offset = "0x3260DF0", VA = "0x3260DF0")]
		public bool hasHandle()
		{
			return default(bool);
		}

		[Token(Token = "0x6000823")]
		[Address(RVA = "0x3260E3C", Offset = "0x3260E3C", VA = "0x3260E3C")]
		public void clearHandle()
		{
		}
	}
	[Token(Token = "0x20000C8")]
	public struct DSP
	{
		[Token(Token = "0x4000610")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public IntPtr handle;

		[Token(Token = "0x6000824")]
		[Address(RVA = "0x329DA18", Offset = "0x329DA18", VA = "0x329DA18")]
		public RESULT release()
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000825")]
		[Address(RVA = "0x329DAA0", Offset = "0x329DAA0", VA = "0x329DAA0")]
		public RESULT getSystemObject(out System system)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000826")]
		[Address(RVA = "0x329DB38", Offset = "0x329DB38", VA = "0x329DB38")]
		public RESULT addInput(DSP input)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000827")]
		[Address(RVA = "0x329DC3C", Offset = "0x329DC3C", VA = "0x329DC3C")]
		public RESULT addInput(DSP input, out DSPConnection connection, DSPCONNECTION_TYPE type = DSPCONNECTION_TYPE.STANDARD)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000828")]
		[Address(RVA = "0x329DCEC", Offset = "0x329DCEC", VA = "0x329DCEC")]
		public RESULT disconnectFrom(DSP target, DSPConnection connection)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000829")]
		[Address(RVA = "0x329DD88", Offset = "0x329DD88", VA = "0x329DD88")]
		public RESULT disconnectAll(bool inputs, bool outputs)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600082A")]
		[Address(RVA = "0x329DE30", Offset = "0x329DE30", VA = "0x329DE30")]
		public RESULT getNumInputs(out int numinputs)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600082B")]
		[Address(RVA = "0x329DEC8", Offset = "0x329DEC8", VA = "0x329DEC8")]
		public RESULT getNumOutputs(out int numoutputs)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600082C")]
		[Address(RVA = "0x329DF60", Offset = "0x329DF60", VA = "0x329DF60")]
		public RESULT getInput(int index, out DSP input, out DSPConnection inputconnection)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600082D")]
		[Address(RVA = "0x329E010", Offset = "0x329E010", VA = "0x329E010")]
		public RESULT getOutput(int index, out DSP output, out DSPConnection outputconnection)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600082E")]
		[Address(RVA = "0x329E0C0", Offset = "0x329E0C0", VA = "0x329E0C0")]
		public RESULT setActive(bool active)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600082F")]
		[Address(RVA = "0x329E15C", Offset = "0x329E15C", VA = "0x329E15C")]
		public RESULT getActive(out bool active)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000830")]
		[Address(RVA = "0x329E208", Offset = "0x329E208", VA = "0x329E208")]
		public RESULT setBypass(bool bypass)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000831")]
		[Address(RVA = "0x329E2A4", Offset = "0x329E2A4", VA = "0x329E2A4")]
		public RESULT getBypass(out bool bypass)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000832")]
		[Address(RVA = "0x329E350", Offset = "0x329E350", VA = "0x329E350")]
		public RESULT setWetDryMix(float prewet, float postwet, float dry)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000833")]
		[Address(RVA = "0x329E400", Offset = "0x329E400", VA = "0x329E400")]
		public RESULT getWetDryMix(out float prewet, out float postwet, out float dry)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000834")]
		[Address(RVA = "0x329E4B0", Offset = "0x329E4B0", VA = "0x329E4B0")]
		public RESULT setChannelFormat(CHANNELMASK channelmask, int numchannels, SPEAKERMODE source_speakermode)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000835")]
		[Address(RVA = "0x329E560", Offset = "0x329E560", VA = "0x329E560")]
		public RESULT getChannelFormat(out CHANNELMASK channelmask, out int numchannels, out SPEAKERMODE source_speakermode)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000836")]
		[Address(RVA = "0x329E610", Offset = "0x329E610", VA = "0x329E610")]
		public RESULT getOutputChannelFormat(CHANNELMASK inmask, int inchannels, SPEAKERMODE inspeakermode, out CHANNELMASK outmask, out int outchannels, out SPEAKERMODE outspeakermode)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000837")]
		[Address(RVA = "0x329E6E0", Offset = "0x329E6E0", VA = "0x329E6E0")]
		public RESULT reset()
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000838")]
		[Address(RVA = "0x329E768", Offset = "0x329E768", VA = "0x329E768")]
		public RESULT setParameterFloat(int index, float value)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000839")]
		[Address(RVA = "0x329E810", Offset = "0x329E810", VA = "0x329E810")]
		public RESULT setParameterInt(int index, int value)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600083A")]
		[Address(RVA = "0x329E8B0", Offset = "0x329E8B0", VA = "0x329E8B0")]
		public RESULT setParameterBool(int index, bool value)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600083B")]
		[Address(RVA = "0x329E954", Offset = "0x329E954", VA = "0x329E954")]
		public RESULT setParameterData(int index, byte[] data)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600083C")]
		[Address(RVA = "0x329EAA0", Offset = "0x329EAA0", VA = "0x329EAA0")]
		public RESULT getParameterFloat(int index, out float value)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600083D")]
		[Address(RVA = "0x329EBB4", Offset = "0x329EBB4", VA = "0x329EBB4")]
		public RESULT getParameterInt(int index, out int value)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600083E")]
		[Address(RVA = "0x329ECC8", Offset = "0x329ECC8", VA = "0x329ECC8")]
		public RESULT getParameterBool(int index, out bool value)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600083F")]
		[Address(RVA = "0x329EDF0", Offset = "0x329EDF0", VA = "0x329EDF0")]
		public RESULT getParameterData(int index, out IntPtr data, out uint length)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000840")]
		[Address(RVA = "0x329EF24", Offset = "0x329EF24", VA = "0x329EF24")]
		public RESULT getNumParameters(out int numparams)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000841")]
		[Address(RVA = "0x329EFBC", Offset = "0x329EFBC", VA = "0x329EFBC")]
		public RESULT getParameterInfo(int index, out DSP_PARAMETER_DESC desc)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000842")]
		[Address(RVA = "0x329F118", Offset = "0x329F118", VA = "0x329F118")]
		public RESULT getDataParameterIndex(int datatype, out int index)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000843")]
		[Address(RVA = "0x329F1B8", Offset = "0x329F1B8", VA = "0x329F1B8")]
		public RESULT showConfigDialog(IntPtr hwnd, bool show)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000844")]
		[Address(RVA = "0x329F25C", Offset = "0x329F25C", VA = "0x329F25C")]
		public RESULT getInfo(out string name, out uint version, out int channels, out int configwidth, out int configheight)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000845")]
		[Address(RVA = "0x329F4F0", Offset = "0x329F4F0", VA = "0x329F4F0")]
		public RESULT getInfo(out uint version, out int channels, out int configwidth, out int configheight)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000846")]
		[Address(RVA = "0x329F568", Offset = "0x329F568", VA = "0x329F568")]
		public RESULT getType(out DSP_TYPE type)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000847")]
		[Address(RVA = "0x329F600", Offset = "0x329F600", VA = "0x329F600")]
		public RESULT getIdle(out bool idle)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000848")]
		[Address(RVA = "0x329F6AC", Offset = "0x329F6AC", VA = "0x329F6AC")]
		public RESULT setUserData(IntPtr userdata)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000849")]
		[Address(RVA = "0x329F744", Offset = "0x329F744", VA = "0x329F744")]
		public RESULT getUserData(out IntPtr userdata)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600084A")]
		[Address(RVA = "0x329F7DC", Offset = "0x329F7DC", VA = "0x329F7DC")]
		public RESULT setMeteringEnabled(bool inputEnabled, bool outputEnabled)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600084B")]
		[Address(RVA = "0x329F884", Offset = "0x329F884", VA = "0x329F884")]
		public RESULT getMeteringEnabled(out bool inputEnabled, out bool outputEnabled)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600084C")]
		[Address(RVA = "0x329F948", Offset = "0x329F948", VA = "0x329F948")]
		public RESULT getMeteringInfo(IntPtr zero, out DSP_METERING_INFO outputInfo)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600084D")]
		[Address(RVA = "0x329FA2C", Offset = "0x329FA2C", VA = "0x329FA2C")]
		public RESULT getMeteringInfo(out DSP_METERING_INFO inputInfo, IntPtr zero)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600084E")]
		[Address(RVA = "0x329FB10", Offset = "0x329FB10", VA = "0x329FB10")]
		public RESULT getMeteringInfo(out DSP_METERING_INFO inputInfo, out DSP_METERING_INFO outputInfo)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600084F")]
		[Address(RVA = "0x329FC14", Offset = "0x329FC14", VA = "0x329FC14")]
		public RESULT getCPUUsage(out uint exclusive, out uint inclusive)
		{
			return default(RESULT);
		}

		[PreserveSig]
		[Token(Token = "0x6000850")]
		[Address(RVA = "0x329DA20", Offset = "0x329DA20", VA = "0x329DA20")]
		private static extern RESULT FMOD5_DSP_Release(IntPtr dsp);

		[PreserveSig]
		[Token(Token = "0x6000851")]
		[Address(RVA = "0x329DAA8", Offset = "0x329DAA8", VA = "0x329DAA8")]
		private static extern RESULT FMOD5_DSP_GetSystemObject(IntPtr dsp, out IntPtr system);

		[PreserveSig]
		[Token(Token = "0x6000852")]
		[Address(RVA = "0x329DB94", Offset = "0x329DB94", VA = "0x329DB94")]
		private static extern RESULT FMOD5_DSP_AddInput(IntPtr dsp, IntPtr input, IntPtr zero, DSPCONNECTION_TYPE type);

		[PreserveSig]
		[Token(Token = "0x6000853")]
		[Address(RVA = "0x329DC44", Offset = "0x329DC44", VA = "0x329DC44")]
		private static extern RESULT FMOD5_DSP_AddInput(IntPtr dsp, IntPtr input, out IntPtr connection, DSPCONNECTION_TYPE type);

		[PreserveSig]
		[Token(Token = "0x6000854")]
		[Address(RVA = "0x329DCF4", Offset = "0x329DCF4", VA = "0x329DCF4")]
		private static extern RESULT FMOD5_DSP_DisconnectFrom(IntPtr dsp, IntPtr target, IntPtr connection);

		[PreserveSig]
		[Token(Token = "0x6000855")]
		[Address(RVA = "0x329DD98", Offset = "0x329DD98", VA = "0x329DD98")]
		private static extern RESULT FMOD5_DSP_DisconnectAll(IntPtr dsp, bool inputs, bool outputs);

		[PreserveSig]
		[Token(Token = "0x6000856")]
		[Address(RVA = "0x329DE38", Offset = "0x329DE38", VA = "0x329DE38")]
		private static extern RESULT FMOD5_DSP_GetNumInputs(IntPtr dsp, out int numinputs);

		[PreserveSig]
		[Token(Token = "0x6000857")]
		[Address(RVA = "0x329DED0", Offset = "0x329DED0", VA = "0x329DED0")]
		private static extern RESULT FMOD5_DSP_GetNumOutputs(IntPtr dsp, out int numoutputs);

		[PreserveSig]
		[Token(Token = "0x6000858")]
		[Address(RVA = "0x329DF68", Offset = "0x329DF68", VA = "0x329DF68")]
		private static extern RESULT FMOD5_DSP_GetInput(IntPtr dsp, int index, out IntPtr input, out IntPtr inputconnection);

		[PreserveSig]
		[Token(Token = "0x6000859")]
		[Address(RVA = "0x329E018", Offset = "0x329E018", VA = "0x329E018")]
		private static extern RESULT FMOD5_DSP_GetOutput(IntPtr dsp, int index, out IntPtr output, out IntPtr outputconnection);

		[PreserveSig]
		[Token(Token = "0x600085A")]
		[Address(RVA = "0x329E0CC", Offset = "0x329E0CC", VA = "0x329E0CC")]
		private static extern RESULT FMOD5_DSP_SetActive(IntPtr dsp, bool active);

		[PreserveSig]
		[Token(Token = "0x600085B")]
		[Address(RVA = "0x329E164", Offset = "0x329E164", VA = "0x329E164")]
		private static extern RESULT FMOD5_DSP_GetActive(IntPtr dsp, out bool active);

		[PreserveSig]
		[Token(Token = "0x600085C")]
		[Address(RVA = "0x329E214", Offset = "0x329E214", VA = "0x329E214")]
		private static extern RESULT FMOD5_DSP_SetBypass(IntPtr dsp, bool bypass);

		[PreserveSig]
		[Token(Token = "0x600085D")]
		[Address(RVA = "0x329E2AC", Offset = "0x329E2AC", VA = "0x329E2AC")]
		private static extern RESULT FMOD5_DSP_GetBypass(IntPtr dsp, out bool bypass);

		[PreserveSig]
		[Token(Token = "0x600085E")]
		[Address(RVA = "0x329E358", Offset = "0x329E358", VA = "0x329E358")]
		private static extern RESULT FMOD5_DSP_SetWetDryMix(IntPtr dsp, float prewet, float postwet, float dry);

		[PreserveSig]
		[Token(Token = "0x600085F")]
		[Address(RVA = "0x329E408", Offset = "0x329E408", VA = "0x329E408")]
		private static extern RESULT FMOD5_DSP_GetWetDryMix(IntPtr dsp, out float prewet, out float postwet, out float dry);

		[PreserveSig]
		[Token(Token = "0x6000860")]
		[Address(RVA = "0x329E4B8", Offset = "0x329E4B8", VA = "0x329E4B8")]
		private static extern RESULT FMOD5_DSP_SetChannelFormat(IntPtr dsp, CHANNELMASK channelmask, int numchannels, SPEAKERMODE source_speakermode);

		[PreserveSig]
		[Token(Token = "0x6000861")]
		[Address(RVA = "0x329E568", Offset = "0x329E568", VA = "0x329E568")]
		private static extern RESULT FMOD5_DSP_GetChannelFormat(IntPtr dsp, out CHANNELMASK channelmask, out int numchannels, out SPEAKERMODE source_speakermode);

		[PreserveSig]
		[Token(Token = "0x6000862")]
		[Address(RVA = "0x329E618", Offset = "0x329E618", VA = "0x329E618")]
		private static extern RESULT FMOD5_DSP_GetOutputChannelFormat(IntPtr dsp, CHANNELMASK inmask, int inchannels, SPEAKERMODE inspeakermode, out CHANNELMASK outmask, out int outchannels, out SPEAKERMODE outspeakermode);

		[PreserveSig]
		[Token(Token = "0x6000863")]
		[Address(RVA = "0x329E6E8", Offset = "0x329E6E8", VA = "0x329E6E8")]
		private static extern RESULT FMOD5_DSP_Reset(IntPtr dsp);

		[PreserveSig]
		[Token(Token = "0x6000864")]
		[Address(RVA = "0x329E770", Offset = "0x329E770", VA = "0x329E770")]
		private static extern RESULT FMOD5_DSP_SetParameterFloat(IntPtr dsp, int index, float value);

		[PreserveSig]
		[Token(Token = "0x6000865")]
		[Address(RVA = "0x329E818", Offset = "0x329E818", VA = "0x329E818")]
		private static extern RESULT FMOD5_DSP_SetParameterInt(IntPtr dsp, int index, int value);

		[PreserveSig]
		[Token(Token = "0x6000866")]
		[Address(RVA = "0x329E8BC", Offset = "0x329E8BC", VA = "0x329E8BC")]
		private static extern RESULT FMOD5_DSP_SetParameterBool(IntPtr dsp, int index, bool value);

		[PreserveSig]
		[Token(Token = "0x6000867")]
		[Address(RVA = "0x329E9F8", Offset = "0x329E9F8", VA = "0x329E9F8")]
		private static extern RESULT FMOD5_DSP_SetParameterData(IntPtr dsp, int index, IntPtr data, uint length);

		[PreserveSig]
		[Token(Token = "0x6000868")]
		[Address(RVA = "0x329EB04", Offset = "0x329EB04", VA = "0x329EB04")]
		private static extern RESULT FMOD5_DSP_GetParameterFloat(IntPtr dsp, int index, out float value, IntPtr valuestr, int valuestrlen);

		[PreserveSig]
		[Token(Token = "0x6000869")]
		[Address(RVA = "0x329EC18", Offset = "0x329EC18", VA = "0x329EC18")]
		private static extern RESULT FMOD5_DSP_GetParameterInt(IntPtr dsp, int index, out int value, IntPtr valuestr, int valuestrlen);

		[PreserveSig]
		[Token(Token = "0x600086A")]
		[Address(RVA = "0x329ED2C", Offset = "0x329ED2C", VA = "0x329ED2C")]
		private static extern RESULT FMOD5_DSP_GetParameterBool(IntPtr dsp, int index, out bool value, IntPtr valuestr, int valuestrlen);

		[PreserveSig]
		[Token(Token = "0x600086B")]
		[Address(RVA = "0x329EE64", Offset = "0x329EE64", VA = "0x329EE64")]
		private static extern RESULT FMOD5_DSP_GetParameterData(IntPtr dsp, int index, out IntPtr data, out uint length, IntPtr valuestr, int valuestrlen);

		[PreserveSig]
		[Token(Token = "0x600086C")]
		[Address(RVA = "0x329EF2C", Offset = "0x329EF2C", VA = "0x329EF2C")]
		private static extern RESULT FMOD5_DSP_GetNumParameters(IntPtr dsp, out int numparams);

		[PreserveSig]
		[Token(Token = "0x600086D")]
		[Address(RVA = "0x329F080", Offset = "0x329F080", VA = "0x329F080")]
		private static extern RESULT FMOD5_DSP_GetParameterInfo(IntPtr dsp, int index, out IntPtr desc);

		[PreserveSig]
		[Token(Token = "0x600086E")]
		[Address(RVA = "0x329F120", Offset = "0x329F120", VA = "0x329F120")]
		private static extern RESULT FMOD5_DSP_GetDataParameterIndex(IntPtr dsp, int datatype, out int index);

		[PreserveSig]
		[Token(Token = "0x600086F")]
		[Address(RVA = "0x329F1C4", Offset = "0x329F1C4", VA = "0x329F1C4")]
		private static extern RESULT FMOD5_DSP_ShowConfigDialog(IntPtr dsp, IntPtr hwnd, bool show);

		[PreserveSig]
		[Token(Token = "0x6000870")]
		[Address(RVA = "0x329F430", Offset = "0x329F430", VA = "0x329F430")]
		private static extern RESULT FMOD5_DSP_GetInfo(IntPtr dsp, IntPtr name, out uint version, out int channels, out int configwidth, out int configheight);

		[PreserveSig]
		[Token(Token = "0x6000871")]
		[Address(RVA = "0x329F570", Offset = "0x329F570", VA = "0x329F570")]
		private static extern RESULT FMOD5_DSP_GetType(IntPtr dsp, out DSP_TYPE type);

		[PreserveSig]
		[Token(Token = "0x6000872")]
		[Address(RVA = "0x329F608", Offset = "0x329F608", VA = "0x329F608")]
		private static extern RESULT FMOD5_DSP_GetIdle(IntPtr dsp, out bool idle);

		[PreserveSig]
		[Token(Token = "0x6000873")]
		[Address(RVA = "0x329F6B4", Offset = "0x329F6B4", VA = "0x329F6B4")]
		private static extern RESULT FMOD5_DSP_SetUserData(IntPtr dsp, IntPtr userdata);

		[PreserveSig]
		[Token(Token = "0x6000874")]
		[Address(RVA = "0x329F74C", Offset = "0x329F74C", VA = "0x329F74C")]
		private static extern RESULT FMOD5_DSP_GetUserData(IntPtr dsp, out IntPtr userdata);

		[PreserveSig]
		[Token(Token = "0x6000875")]
		[Address(RVA = "0x329F7EC", Offset = "0x329F7EC", VA = "0x329F7EC")]
		public static extern RESULT FMOD5_DSP_SetMeteringEnabled(IntPtr dsp, bool inputEnabled, bool outputEnabled);

		[PreserveSig]
		[Token(Token = "0x6000876")]
		[Address(RVA = "0x329F88C", Offset = "0x329F88C", VA = "0x329F88C")]
		public static extern RESULT FMOD5_DSP_GetMeteringEnabled(IntPtr dsp, out bool inputEnabled, out bool outputEnabled);

		[PreserveSig]
		[Token(Token = "0x6000877")]
		[Address(RVA = "0x329F950", Offset = "0x329F950", VA = "0x329F950")]
		public static extern RESULT FMOD5_DSP_GetMeteringInfo(IntPtr dsp, IntPtr zero, out DSP_METERING_INFO outputInfo);

		[PreserveSig]
		[Token(Token = "0x6000878")]
		[Address(RVA = "0x329FA34", Offset = "0x329FA34", VA = "0x329FA34")]
		public static extern RESULT FMOD5_DSP_GetMeteringInfo(IntPtr dsp, out DSP_METERING_INFO inputInfo, IntPtr zero);

		[PreserveSig]
		[Token(Token = "0x6000879")]
		[Address(RVA = "0x329FB18", Offset = "0x329FB18", VA = "0x329FB18")]
		public static extern RESULT FMOD5_DSP_GetMeteringInfo(IntPtr dsp, out DSP_METERING_INFO inputInfo, out DSP_METERING_INFO outputInfo);

		[PreserveSig]
		[Token(Token = "0x600087A")]
		[Address(RVA = "0x329FC1C", Offset = "0x329FC1C", VA = "0x329FC1C")]
		public static extern RESULT FMOD5_DSP_GetCPUUsage(IntPtr dsp, out uint exclusive, out uint inclusive);

		[Token(Token = "0x600087B")]
		[Address(RVA = "0x329FCB4", Offset = "0x329FCB4", VA = "0x329FCB4")]
		public bool hasHandle()
		{
			return default(bool);
		}

		[Token(Token = "0x600087C")]
		[Address(RVA = "0x329FD00", Offset = "0x329FD00", VA = "0x329FD00")]
		public void clearHandle()
		{
		}
	}
	[Token(Token = "0x20000C9")]
	public struct DSPConnection
	{
		[Token(Token = "0x4000611")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public IntPtr handle;

		[Token(Token = "0x600087D")]
		[Address(RVA = "0x329FD44", Offset = "0x329FD44", VA = "0x329FD44")]
		public RESULT getInput(out DSP input)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600087E")]
		[Address(RVA = "0x329FDDC", Offset = "0x329FDDC", VA = "0x329FDDC")]
		public RESULT getOutput(out DSP output)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600087F")]
		[Address(RVA = "0x329FE74", Offset = "0x329FE74", VA = "0x329FE74")]
		public RESULT setMix(float volume)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000880")]
		[Address(RVA = "0x329FF0C", Offset = "0x329FF0C", VA = "0x329FF0C")]
		public RESULT getMix(out float volume)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000881")]
		[Address(RVA = "0x329FFA4", Offset = "0x329FFA4", VA = "0x329FFA4")]
		public RESULT setMixMatrix(float[] matrix, int outchannels, int inchannels, int inchannel_hop = 0)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000882")]
		[Address(RVA = "0x32A0064", Offset = "0x32A0064", VA = "0x32A0064")]
		public RESULT getMixMatrix(float[] matrix, out int outchannels, out int inchannels, int inchannel_hop = 0)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000883")]
		[Address(RVA = "0x32A0124", Offset = "0x32A0124", VA = "0x32A0124")]
		public RESULT getType(out DSPCONNECTION_TYPE type)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000884")]
		[Address(RVA = "0x32A01BC", Offset = "0x32A01BC", VA = "0x32A01BC")]
		public RESULT setUserData(IntPtr userdata)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000885")]
		[Address(RVA = "0x32A0254", Offset = "0x32A0254", VA = "0x32A0254")]
		public RESULT getUserData(out IntPtr userdata)
		{
			return default(RESULT);
		}

		[PreserveSig]
		[Token(Token = "0x6000886")]
		[Address(RVA = "0x329FD4C", Offset = "0x329FD4C", VA = "0x329FD4C")]
		private static extern RESULT FMOD5_DSPConnection_GetInput(IntPtr dspconnection, out IntPtr input);

		[PreserveSig]
		[Token(Token = "0x6000887")]
		[Address(RVA = "0x329FDE4", Offset = "0x329FDE4", VA = "0x329FDE4")]
		private static extern RESULT FMOD5_DSPConnection_GetOutput(IntPtr dspconnection, out IntPtr output);

		[PreserveSig]
		[Token(Token = "0x6000888")]
		[Address(RVA = "0x329FE7C", Offset = "0x329FE7C", VA = "0x329FE7C")]
		private static extern RESULT FMOD5_DSPConnection_SetMix(IntPtr dspconnection, float volume);

		[PreserveSig]
		[Token(Token = "0x6000889")]
		[Address(RVA = "0x329FF14", Offset = "0x329FF14", VA = "0x329FF14")]
		private static extern RESULT FMOD5_DSPConnection_GetMix(IntPtr dspconnection, out float volume);

		[PreserveSig]
		[Token(Token = "0x600088A")]
		[Address(RVA = "0x329FFAC", Offset = "0x329FFAC", VA = "0x329FFAC")]
		private static extern RESULT FMOD5_DSPConnection_SetMixMatrix(IntPtr dspconnection, float[] matrix, int outchannels, int inchannels, int inchannel_hop);

		[PreserveSig]
		[Token(Token = "0x600088B")]
		[Address(RVA = "0x32A006C", Offset = "0x32A006C", VA = "0x32A006C")]
		private static extern RESULT FMOD5_DSPConnection_GetMixMatrix(IntPtr dspconnection, float[] matrix, out int outchannels, out int inchannels, int inchannel_hop);

		[PreserveSig]
		[Token(Token = "0x600088C")]
		[Address(RVA = "0x32A012C", Offset = "0x32A012C", VA = "0x32A012C")]
		private static extern RESULT FMOD5_DSPConnection_GetType(IntPtr dspconnection, out DSPCONNECTION_TYPE type);

		[PreserveSig]
		[Token(Token = "0x600088D")]
		[Address(RVA = "0x32A01C4", Offset = "0x32A01C4", VA = "0x32A01C4")]
		private static extern RESULT FMOD5_DSPConnection_SetUserData(IntPtr dspconnection, IntPtr userdata);

		[PreserveSig]
		[Token(Token = "0x600088E")]
		[Address(RVA = "0x32A025C", Offset = "0x32A025C", VA = "0x32A025C")]
		private static extern RESULT FMOD5_DSPConnection_GetUserData(IntPtr dspconnection, out IntPtr userdata);

		[Token(Token = "0x600088F")]
		[Address(RVA = "0x32A02EC", Offset = "0x32A02EC", VA = "0x32A02EC")]
		public bool hasHandle()
		{
			return default(bool);
		}

		[Token(Token = "0x6000890")]
		[Address(RVA = "0x32A0338", Offset = "0x32A0338", VA = "0x32A0338")]
		public void clearHandle()
		{
		}
	}
	[Token(Token = "0x20000CA")]
	public struct Geometry
	{
		[Token(Token = "0x4000612")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public IntPtr handle;

		[Token(Token = "0x6000891")]
		[Address(RVA = "0x325A6FC", Offset = "0x325A6FC", VA = "0x325A6FC")]
		public RESULT release()
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000892")]
		[Address(RVA = "0x325A784", Offset = "0x325A784", VA = "0x325A784")]
		public RESULT addPolygon(float directocclusion, float reverbocclusion, bool doublesided, int numvertices, VECTOR[] vertices, out int polygonindex)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000893")]
		[Address(RVA = "0x325A860", Offset = "0x325A860", VA = "0x325A860")]
		public RESULT getNumPolygons(out int numpolygons)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000894")]
		[Address(RVA = "0x325A8F8", Offset = "0x325A8F8", VA = "0x325A8F8")]
		public RESULT getMaxPolygons(out int maxpolygons, out int maxvertices)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000895")]
		[Address(RVA = "0x325A998", Offset = "0x325A998", VA = "0x325A998")]
		public RESULT getPolygonNumVertices(int index, out int numvertices)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000896")]
		[Address(RVA = "0x325AA38", Offset = "0x325AA38", VA = "0x325AA38")]
		public RESULT setPolygonVertex(int index, int vertexindex, ref VECTOR vertex)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000897")]
		[Address(RVA = "0x325AAE8", Offset = "0x325AAE8", VA = "0x325AAE8")]
		public RESULT getPolygonVertex(int index, int vertexindex, out VECTOR vertex)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000898")]
		[Address(RVA = "0x325AB98", Offset = "0x325AB98", VA = "0x325AB98")]
		public RESULT setPolygonAttributes(int index, float directocclusion, float reverbocclusion, bool doublesided)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000899")]
		[Address(RVA = "0x325AC54", Offset = "0x325AC54", VA = "0x325AC54")]
		public RESULT getPolygonAttributes(int index, out float directocclusion, out float reverbocclusion, out bool doublesided)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600089A")]
		[Address(RVA = "0x325AD20", Offset = "0x325AD20", VA = "0x325AD20")]
		public RESULT setActive(bool active)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600089B")]
		[Address(RVA = "0x325ADBC", Offset = "0x325ADBC", VA = "0x325ADBC")]
		public RESULT getActive(out bool active)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600089C")]
		[Address(RVA = "0x325AE68", Offset = "0x325AE68", VA = "0x325AE68")]
		public RESULT setRotation(ref VECTOR forward, ref VECTOR up)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600089D")]
		[Address(RVA = "0x325AF08", Offset = "0x325AF08", VA = "0x325AF08")]
		public RESULT getRotation(out VECTOR forward, out VECTOR up)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600089E")]
		[Address(RVA = "0x325AFA8", Offset = "0x325AFA8", VA = "0x325AFA8")]
		public RESULT setPosition(ref VECTOR position)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600089F")]
		[Address(RVA = "0x325B040", Offset = "0x325B040", VA = "0x325B040")]
		public RESULT getPosition(out VECTOR position)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60008A0")]
		[Address(RVA = "0x325B0D8", Offset = "0x325B0D8", VA = "0x325B0D8")]
		public RESULT setScale(ref VECTOR scale)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60008A1")]
		[Address(RVA = "0x325B170", Offset = "0x325B170", VA = "0x325B170")]
		public RESULT getScale(out VECTOR scale)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60008A2")]
		[Address(RVA = "0x325B208", Offset = "0x325B208", VA = "0x325B208")]
		public RESULT save(IntPtr data, out int datasize)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60008A3")]
		[Address(RVA = "0x325B2A8", Offset = "0x325B2A8", VA = "0x325B2A8")]
		public RESULT setUserData(IntPtr userdata)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60008A4")]
		[Address(RVA = "0x325B340", Offset = "0x325B340", VA = "0x325B340")]
		public RESULT getUserData(out IntPtr userdata)
		{
			return default(RESULT);
		}

		[PreserveSig]
		[Token(Token = "0x60008A5")]
		[Address(RVA = "0x325A704", Offset = "0x325A704", VA = "0x325A704")]
		private static extern RESULT FMOD5_Geometry_Release(IntPtr geometry);

		[PreserveSig]
		[Token(Token = "0x60008A6")]
		[Address(RVA = "0x325A790", Offset = "0x325A790", VA = "0x325A790")]
		private static extern RESULT FMOD5_Geometry_AddPolygon(IntPtr geometry, float directocclusion, float reverbocclusion, bool doublesided, int numvertices, VECTOR[] vertices, out int polygonindex);

		[PreserveSig]
		[Token(Token = "0x60008A7")]
		[Address(RVA = "0x325A868", Offset = "0x325A868", VA = "0x325A868")]
		private static extern RESULT FMOD5_Geometry_GetNumPolygons(IntPtr geometry, out int numpolygons);

		[PreserveSig]
		[Token(Token = "0x60008A8")]
		[Address(RVA = "0x325A900", Offset = "0x325A900", VA = "0x325A900")]
		private static extern RESULT FMOD5_Geometry_GetMaxPolygons(IntPtr geometry, out int maxpolygons, out int maxvertices);

		[PreserveSig]
		[Token(Token = "0x60008A9")]
		[Address(RVA = "0x325A9A0", Offset = "0x325A9A0", VA = "0x325A9A0")]
		private static extern RESULT FMOD5_Geometry_GetPolygonNumVertices(IntPtr geometry, int index, out int numvertices);

		[PreserveSig]
		[Token(Token = "0x60008AA")]
		[Address(RVA = "0x325AA40", Offset = "0x325AA40", VA = "0x325AA40")]
		private static extern RESULT FMOD5_Geometry_SetPolygonVertex(IntPtr geometry, int index, int vertexindex, ref VECTOR vertex);

		[PreserveSig]
		[Token(Token = "0x60008AB")]
		[Address(RVA = "0x325AAF0", Offset = "0x325AAF0", VA = "0x325AAF0")]
		private static extern RESULT FMOD5_Geometry_GetPolygonVertex(IntPtr geometry, int index, int vertexindex, out VECTOR vertex);

		[PreserveSig]
		[Token(Token = "0x60008AC")]
		[Address(RVA = "0x325ABA4", Offset = "0x325ABA4", VA = "0x325ABA4")]
		private static extern RESULT FMOD5_Geometry_SetPolygonAttributes(IntPtr geometry, int index, float directocclusion, float reverbocclusion, bool doublesided);

		[PreserveSig]
		[Token(Token = "0x60008AD")]
		[Address(RVA = "0x325AC5C", Offset = "0x325AC5C", VA = "0x325AC5C")]
		private static extern RESULT FMOD5_Geometry_GetPolygonAttributes(IntPtr geometry, int index, out float directocclusion, out float reverbocclusion, out bool doublesided);

		[PreserveSig]
		[Token(Token = "0x60008AE")]
		[Address(RVA = "0x325AD2C", Offset = "0x325AD2C", VA = "0x325AD2C")]
		private static extern RESULT FMOD5_Geometry_SetActive(IntPtr geometry, bool active);

		[PreserveSig]
		[Token(Token = "0x60008AF")]
		[Address(RVA = "0x325ADC4", Offset = "0x325ADC4", VA = "0x325ADC4")]
		private static extern RESULT FMOD5_Geometry_GetActive(IntPtr geometry, out bool active);

		[PreserveSig]
		[Token(Token = "0x60008B0")]
		[Address(RVA = "0x325AE70", Offset = "0x325AE70", VA = "0x325AE70")]
		private static extern RESULT FMOD5_Geometry_SetRotation(IntPtr geometry, ref VECTOR forward, ref VECTOR up);

		[PreserveSig]
		[Token(Token = "0x60008B1")]
		[Address(RVA = "0x325AF10", Offset = "0x325AF10", VA = "0x325AF10")]
		private static extern RESULT FMOD5_Geometry_GetRotation(IntPtr geometry, out VECTOR forward, out VECTOR up);

		[PreserveSig]
		[Token(Token = "0x60008B2")]
		[Address(RVA = "0x325AFB0", Offset = "0x325AFB0", VA = "0x325AFB0")]
		private static extern RESULT FMOD5_Geometry_SetPosition(IntPtr geometry, ref VECTOR position);

		[PreserveSig]
		[Token(Token = "0x60008B3")]
		[Address(RVA = "0x325B048", Offset = "0x325B048", VA = "0x325B048")]
		private static extern RESULT FMOD5_Geometry_GetPosition(IntPtr geometry, out VECTOR position);

		[PreserveSig]
		[Token(Token = "0x60008B4")]
		[Address(RVA = "0x325B0E0", Offset = "0x325B0E0", VA = "0x325B0E0")]
		private static extern RESULT FMOD5_Geometry_SetScale(IntPtr geometry, ref VECTOR scale);

		[PreserveSig]
		[Token(Token = "0x60008B5")]
		[Address(RVA = "0x325B178", Offset = "0x325B178", VA = "0x325B178")]
		private static extern RESULT FMOD5_Geometry_GetScale(IntPtr geometry, out VECTOR scale);

		[PreserveSig]
		[Token(Token = "0x60008B6")]
		[Address(RVA = "0x325B210", Offset = "0x325B210", VA = "0x325B210")]
		private static extern RESULT FMOD5_Geometry_Save(IntPtr geometry, IntPtr data, out int datasize);

		[PreserveSig]
		[Token(Token = "0x60008B7")]
		[Address(RVA = "0x325B2B0", Offset = "0x325B2B0", VA = "0x325B2B0")]
		private static extern RESULT FMOD5_Geometry_SetUserData(IntPtr geometry, IntPtr userdata);

		[PreserveSig]
		[Token(Token = "0x60008B8")]
		[Address(RVA = "0x325B348", Offset = "0x325B348", VA = "0x325B348")]
		private static extern RESULT FMOD5_Geometry_GetUserData(IntPtr geometry, out IntPtr userdata);

		[Token(Token = "0x60008B9")]
		[Address(RVA = "0x325B3D8", Offset = "0x325B3D8", VA = "0x325B3D8")]
		public bool hasHandle()
		{
			return default(bool);
		}

		[Token(Token = "0x60008BA")]
		[Address(RVA = "0x325B424", Offset = "0x325B424", VA = "0x325B424")]
		public void clearHandle()
		{
		}
	}
	[Token(Token = "0x20000CB")]
	public struct Reverb3D
	{
		[Token(Token = "0x4000613")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public IntPtr handle;

		[Token(Token = "0x60008BB")]
		[Address(RVA = "0x325C47C", Offset = "0x325C47C", VA = "0x325C47C")]
		public RESULT release()
		{
			return default(RESULT);
		}

		[Token(Token = "0x60008BC")]
		[Address(RVA = "0x325C504", Offset = "0x325C504", VA = "0x325C504")]
		public RESULT set3DAttributes(ref VECTOR position, float mindistance, float maxdistance)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60008BD")]
		[Address(RVA = "0x325C5B4", Offset = "0x325C5B4", VA = "0x325C5B4")]
		public RESULT get3DAttributes(ref VECTOR position, ref float mindistance, ref float maxdistance)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60008BE")]
		[Address(RVA = "0x325C664", Offset = "0x325C664", VA = "0x325C664")]
		public RESULT setProperties(ref REVERB_PROPERTIES properties)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60008BF")]
		[Address(RVA = "0x325C6FC", Offset = "0x325C6FC", VA = "0x325C6FC")]
		public RESULT getProperties(ref REVERB_PROPERTIES properties)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60008C0")]
		[Address(RVA = "0x325C794", Offset = "0x325C794", VA = "0x325C794")]
		public RESULT setActive(bool active)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60008C1")]
		[Address(RVA = "0x325C830", Offset = "0x325C830", VA = "0x325C830")]
		public RESULT getActive(out bool active)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60008C2")]
		[Address(RVA = "0x325C8DC", Offset = "0x325C8DC", VA = "0x325C8DC")]
		public RESULT setUserData(IntPtr userdata)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60008C3")]
		[Address(RVA = "0x325C974", Offset = "0x325C974", VA = "0x325C974")]
		public RESULT getUserData(out IntPtr userdata)
		{
			return default(RESULT);
		}

		[PreserveSig]
		[Token(Token = "0x60008C4")]
		[Address(RVA = "0x325C484", Offset = "0x325C484", VA = "0x325C484")]
		private static extern RESULT FMOD5_Reverb3D_Release(IntPtr reverb3d);

		[PreserveSig]
		[Token(Token = "0x60008C5")]
		[Address(RVA = "0x325C50C", Offset = "0x325C50C", VA = "0x325C50C")]
		private static extern RESULT FMOD5_Reverb3D_Set3DAttributes(IntPtr reverb3d, ref VECTOR position, float mindistance, float maxdistance);

		[PreserveSig]
		[Token(Token = "0x60008C6")]
		[Address(RVA = "0x325C5BC", Offset = "0x325C5BC", VA = "0x325C5BC")]
		private static extern RESULT FMOD5_Reverb3D_Get3DAttributes(IntPtr reverb3d, ref VECTOR position, ref float mindistance, ref float maxdistance);

		[PreserveSig]
		[Token(Token = "0x60008C7")]
		[Address(RVA = "0x325C66C", Offset = "0x325C66C", VA = "0x325C66C")]
		private static extern RESULT FMOD5_Reverb3D_SetProperties(IntPtr reverb3d, ref REVERB_PROPERTIES properties);

		[PreserveSig]
		[Token(Token = "0x60008C8")]
		[Address(RVA = "0x325C704", Offset = "0x325C704", VA = "0x325C704")]
		private static extern RESULT FMOD5_Reverb3D_GetProperties(IntPtr reverb3d, ref REVERB_PROPERTIES properties);

		[PreserveSig]
		[Token(Token = "0x60008C9")]
		[Address(RVA = "0x325C7A0", Offset = "0x325C7A0", VA = "0x325C7A0")]
		private static extern RESULT FMOD5_Reverb3D_SetActive(IntPtr reverb3d, bool active);

		[PreserveSig]
		[Token(Token = "0x60008CA")]
		[Address(RVA = "0x325C838", Offset = "0x325C838", VA = "0x325C838")]
		private static extern RESULT FMOD5_Reverb3D_GetActive(IntPtr reverb3d, out bool active);

		[PreserveSig]
		[Token(Token = "0x60008CB")]
		[Address(RVA = "0x325C8E4", Offset = "0x325C8E4", VA = "0x325C8E4")]
		private static extern RESULT FMOD5_Reverb3D_SetUserData(IntPtr reverb3d, IntPtr userdata);

		[PreserveSig]
		[Token(Token = "0x60008CC")]
		[Address(RVA = "0x325C97C", Offset = "0x325C97C", VA = "0x325C97C")]
		private static extern RESULT FMOD5_Reverb3D_GetUserData(IntPtr reverb3d, out IntPtr userdata);

		[Token(Token = "0x60008CD")]
		[Address(RVA = "0x325CA0C", Offset = "0x325CA0C", VA = "0x325CA0C")]
		public bool hasHandle()
		{
			return default(bool);
		}

		[Token(Token = "0x60008CE")]
		[Address(RVA = "0x325CA58", Offset = "0x325CA58", VA = "0x325CA58")]
		public void clearHandle()
		{
		}
	}
	[Token(Token = "0x20000CC")]
	public struct StringWrapper
	{
		[Token(Token = "0x4000614")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private IntPtr nativeUtf8Ptr;

		[Token(Token = "0x60008CF")]
		[Address(RVA = "0x326113C", Offset = "0x326113C", VA = "0x326113C")]
		public static implicit operator string(StringWrapper fstring)
		{
			return null;
		}
	}
	[Token(Token = "0x20000CD")]
	public static class StringHelper
	{
		[Token(Token = "0x20001D1")]
		public class ThreadSafeEncoding : IDisposable
		{
			[Token(Token = "0x4000B95")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private UTF8Encoding encoding;

			[Token(Token = "0x4000B96")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private byte[] encodedBuffer;

			[Token(Token = "0x4000B97")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private char[] decodedBuffer;

			[Token(Token = "0x4000B98")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private bool inUse;

			[Token(Token = "0x4000B99")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			private GCHandle gcHandle;

			[Token(Token = "0x6000D3E")]
			[Address(RVA = "0x3260F9C", Offset = "0x3260F9C", VA = "0x3260F9C")]
			public bool InUse()
			{
				return default(bool);
			}

			[Token(Token = "0x6000D3F")]
			[Address(RVA = "0x3260F18", Offset = "0x3260F18", VA = "0x3260F18")]
			public void SetInUse()
			{
			}

			[Token(Token = "0x6000D40")]
			[Address(RVA = "0x3260FA4", Offset = "0x3260FA4", VA = "0x3260FA4")]
			private int roundUpPowerTwo(int number)
			{
				return default(int);
			}

			[Token(Token = "0x6000D41")]
			[Address(RVA = "0x325ED3C", Offset = "0x325ED3C", VA = "0x325ED3C")]
			public byte[] byteFromStringUTF8(string s)
			{
				return null;
			}

			[Token(Token = "0x6000D42")]
			[Address(RVA = "0x3260FBC", Offset = "0x3260FBC", VA = "0x3260FBC")]
			public IntPtr intptrFromStringUTF8(string s)
			{
				return default(IntPtr);
			}

			[Token(Token = "0x6000D43")]
			[Address(RVA = "0x325E73C", Offset = "0x325E73C", VA = "0x325E73C")]
			public string stringFromNative(IntPtr nativePtr)
			{
				return null;
			}

			[Token(Token = "0x6000D44")]
			[Address(RVA = "0x3261048", Offset = "0x3261048", VA = "0x3261048", Slot = "4")]
			public void Dispose()
			{
			}

			[Token(Token = "0x6000D45")]
			[Address(RVA = "0x3260E80", Offset = "0x3260E80", VA = "0x3260E80")]
			public ThreadSafeEncoding()
			{
			}
		}

		[Token(Token = "0x4000615")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static List<ThreadSafeEncoding> encoders;

		[Token(Token = "0x60008D0")]
		[Address(RVA = "0x325E4CC", Offset = "0x325E4CC", VA = "0x325E4CC")]
		public static ThreadSafeEncoding GetFreeHelper()
		{
			return null;
		}
	}
	[Token(Token = "0x20000CE")]
	internal static class Android
	{
		[Token(Token = "0x20001D2")]
		public struct THREADAFFINITY
		{
			[Token(Token = "0x4000B9A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public THREAD mixer;

			[Token(Token = "0x4000B9B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public THREAD stream;

			[Token(Token = "0x4000B9C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public THREAD nonblocking;

			[Token(Token = "0x4000B9D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public THREAD file;

			[Token(Token = "0x4000B9E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public THREAD geometry;

			[Token(Token = "0x4000B9F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public THREAD profiler;

			[Token(Token = "0x4000BA0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public THREAD studioUpdate;

			[Token(Token = "0x4000BA1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public THREAD studioLoadBank;

			[Token(Token = "0x4000BA2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public THREAD studioLoadSample;
		}

		[Token(Token = "0x20001D3")]
		[Flags]
		public enum THREAD : uint
		{
			[Token(Token = "0x4000BA4")]
			DEFAULT = 0u,
			[Token(Token = "0x4000BA5")]
			CORE0 = 1u,
			[Token(Token = "0x4000BA6")]
			CORE1 = 2u,
			[Token(Token = "0x4000BA7")]
			CORE2 = 4u,
			[Token(Token = "0x4000BA8")]
			CORE3 = 8u,
			[Token(Token = "0x4000BA9")]
			CORE4 = 0x10u,
			[Token(Token = "0x4000BAA")]
			CORE5 = 0x20u,
			[Token(Token = "0x4000BAB")]
			CORE6 = 0x40u,
			[Token(Token = "0x4000BAC")]
			CORE7 = 0x80u
		}

		[Token(Token = "0x60008D2")]
		[Address(RVA = "0x3296C50", Offset = "0x3296C50", VA = "0x3296C50")]
		public static RESULT setThreadAffinity(ref THREADAFFINITY affinity)
		{
			return default(RESULT);
		}

		[PreserveSig]
		[Token(Token = "0x60008D3")]
		[Address(RVA = "0x3296C54", Offset = "0x3296C54", VA = "0x3296C54")]
		private static extern RESULT FMOD_Android_SetThreadAffinity(ref THREADAFFINITY affinity);
	}
	[Token(Token = "0x20000CF")]
	public struct DSP_BUFFER_ARRAY
	{
		[Token(Token = "0x4000616")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int numbuffers;

		[Token(Token = "0x4000617")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public int[] buffernumchannels;

		[Token(Token = "0x4000618")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public CHANNELMASK[] bufferchannelmask;

		[Token(Token = "0x4000619")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public IntPtr[] buffers;

		[Token(Token = "0x400061A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public SPEAKERMODE speakermode;
	}
	[Token(Token = "0x20000D0")]
	public enum DSP_PROCESS_OPERATION
	{
		[Token(Token = "0x400061C")]
		PROCESS_PERFORM,
		[Token(Token = "0x400061D")]
		PROCESS_QUERY
	}
	[Token(Token = "0x20000D1")]
	public struct COMPLEX
	{
		[Token(Token = "0x400061E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float real;

		[Token(Token = "0x400061F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public float imag;
	}
	[Token(Token = "0x20000D2")]
	public enum DSP_PAN_SURROUND_FLAGS
	{
		[Token(Token = "0x4000621")]
		DEFAULT,
		[Token(Token = "0x4000622")]
		ROTATION_NOT_BIASED
	}
	[Token(Token = "0x20000D3")]
	public delegate RESULT DSP_CREATECALLBACK(ref DSP_STATE dsp_state);
	[Token(Token = "0x20000D4")]
	public delegate RESULT DSP_RELEASECALLBACK(ref DSP_STATE dsp_state);
	[Token(Token = "0x20000D5")]
	public delegate RESULT DSP_RESETCALLBACK(ref DSP_STATE dsp_state);
	[Token(Token = "0x20000D6")]
	public delegate RESULT DSP_SETPOSITIONCALLBACK(ref DSP_STATE dsp_state, uint pos);
	[Token(Token = "0x20000D7")]
	public delegate RESULT DSP_READCALLBACK(ref DSP_STATE dsp_state, IntPtr inbuffer, IntPtr outbuffer, uint length, int inchannels, ref int outchannels);
	[Token(Token = "0x20000D8")]
	public delegate RESULT DSP_SHOULDIPROCESS_CALLBACK(ref DSP_STATE dsp_state, bool inputsidle, uint length, CHANNELMASK inmask, int inchannels, SPEAKERMODE speakermode);
	[Token(Token = "0x20000D9")]
	public delegate RESULT DSP_PROCESS_CALLBACK(ref DSP_STATE dsp_state, uint length, ref DSP_BUFFER_ARRAY inbufferarray, ref DSP_BUFFER_ARRAY outbufferarray, bool inputsidle, DSP_PROCESS_OPERATION op);
	[Token(Token = "0x20000DA")]
	public delegate RESULT DSP_SETPARAM_FLOAT_CALLBACK(ref DSP_STATE dsp_state, int index, float value);
	[Token(Token = "0x20000DB")]
	public delegate RESULT DSP_SETPARAM_INT_CALLBACK(ref DSP_STATE dsp_state, int index, int value);
	[Token(Token = "0x20000DC")]
	public delegate RESULT DSP_SETPARAM_BOOL_CALLBACK(ref DSP_STATE dsp_state, int index, bool value);
	[Token(Token = "0x20000DD")]
	public delegate RESULT DSP_SETPARAM_DATA_CALLBACK(ref DSP_STATE dsp_state, int index, IntPtr data, uint length);
	[Token(Token = "0x20000DE")]
	public delegate RESULT DSP_GETPARAM_FLOAT_CALLBACK(ref DSP_STATE dsp_state, int index, ref float value, IntPtr valuestr);
	[Token(Token = "0x20000DF")]
	public delegate RESULT DSP_GETPARAM_INT_CALLBACK(ref DSP_STATE dsp_state, int index, ref int value, IntPtr valuestr);
	[Token(Token = "0x20000E0")]
	public delegate RESULT DSP_GETPARAM_BOOL_CALLBACK(ref DSP_STATE dsp_state, int index, ref bool value, IntPtr valuestr);
	[Token(Token = "0x20000E1")]
	public delegate RESULT DSP_GETPARAM_DATA_CALLBACK(ref DSP_STATE dsp_state, int index, ref IntPtr data, ref uint length, IntPtr valuestr);
	[Token(Token = "0x20000E2")]
	public delegate RESULT DSP_SYSTEM_REGISTER_CALLBACK(ref DSP_STATE dsp_state);
	[Token(Token = "0x20000E3")]
	public delegate RESULT DSP_SYSTEM_DEREGISTER_CALLBACK(ref DSP_STATE dsp_state);
	[Token(Token = "0x20000E4")]
	public delegate RESULT DSP_SYSTEM_MIX_CALLBACK(ref DSP_STATE dsp_state, int stage);
	[Token(Token = "0x20000E5")]
	public delegate IntPtr DSP_ALLOC_FUNC(uint size, MEMORY_TYPE type, StringWrapper sourcestr);
	[Token(Token = "0x20000E6")]
	public delegate IntPtr DSP_REALLOC_FUNC(IntPtr ptr, uint size, MEMORY_TYPE type, StringWrapper sourcestr);
	[Token(Token = "0x20000E7")]
	public delegate void DSP_FREE_FUNC(IntPtr ptr, MEMORY_TYPE type, StringWrapper sourcestr);
	[Token(Token = "0x20000E8")]
	public delegate void DSP_LOG_FUNC(DEBUG_FLAGS level, StringWrapper file, int line, StringWrapper function, StringWrapper format);
	[Token(Token = "0x20000E9")]
	public delegate RESULT DSP_GETSAMPLERATE_FUNC(ref DSP_STATE dsp_state, ref int rate);
	[Token(Token = "0x20000EA")]
	public delegate RESULT DSP_GETBLOCKSIZE_FUNC(ref DSP_STATE dsp_state, ref uint blocksize);
	[Token(Token = "0x20000EB")]
	public delegate RESULT DSP_GETSPEAKERMODE_FUNC(ref DSP_STATE dsp_state, ref int speakermode_mixer, ref int speakermode_output);
	[Token(Token = "0x20000EC")]
	public delegate RESULT DSP_GETCLOCK_FUNC(ref DSP_STATE dsp_state, out ulong clock, out uint offset, out uint length);
	[Token(Token = "0x20000ED")]
	public delegate RESULT DSP_GETLISTENERATTRIBUTES_FUNC(ref DSP_STATE dsp_state, ref int numlisteners, IntPtr attributes);
	[Token(Token = "0x20000EE")]
	public delegate RESULT DSP_GETUSERDATA_FUNC(ref DSP_STATE dsp_state, out IntPtr userdata);
	[Token(Token = "0x20000EF")]
	public delegate RESULT DSP_DFT_FFTREAL_FUNC(ref DSP_STATE dsp_state, int size, IntPtr signal, IntPtr dft, IntPtr window, int signalhop);
	[Token(Token = "0x20000F0")]
	public delegate RESULT DSP_DFT_IFFTREAL_FUNC(ref DSP_STATE dsp_state, int size, IntPtr dft, IntPtr signal, IntPtr window, int signalhop);
	[Token(Token = "0x20000F1")]
	public delegate RESULT DSP_PAN_SUMMONOMATRIX_FUNC(ref DSP_STATE dsp_state, int sourceSpeakerMode, float lowFrequencyGain, float overallGain, IntPtr matrix);
	[Token(Token = "0x20000F2")]
	public delegate RESULT DSP_PAN_SUMSTEREOMATRIX_FUNC(ref DSP_STATE dsp_state, int sourceSpeakerMode, float pan, float lowFrequencyGain, float overallGain, int matrixHop, IntPtr matrix);
	[Token(Token = "0x20000F3")]
	public delegate RESULT DSP_PAN_SUMSURROUNDMATRIX_FUNC(ref DSP_STATE dsp_state, int sourceSpeakerMode, int targetSpeakerMode, float direction, float extent, float rotation, float lowFrequencyGain, float overallGain, int matrixHop, IntPtr matrix, DSP_PAN_SURROUND_FLAGS flags);
	[Token(Token = "0x20000F4")]
	public delegate RESULT DSP_PAN_SUMMONOTOSURROUNDMATRIX_FUNC(ref DSP_STATE dsp_state, int targetSpeakerMode, float direction, float extent, float lowFrequencyGain, float overallGain, int matrixHop, IntPtr matrix);
	[Token(Token = "0x20000F5")]
	public delegate RESULT DSP_PAN_SUMSTEREOTOSURROUNDMATRIX_FUNC(ref DSP_STATE dsp_state, int targetSpeakerMode, float direction, float extent, float rotation, float lowFrequencyGain, float overallGain, int matrixHop, IntPtr matrix);
	[Token(Token = "0x20000F6")]
	public delegate RESULT DSP_PAN_GETROLLOFFGAIN_FUNC(ref DSP_STATE dsp_state, DSP_PAN_3D_ROLLOFF_TYPE rolloff, float distance, float mindistance, float maxdistance, out float gain);
	[Token(Token = "0x20000F7")]
	public enum DSP_TYPE
	{
		[Token(Token = "0x4000624")]
		UNKNOWN,
		[Token(Token = "0x4000625")]
		MIXER,
		[Token(Token = "0x4000626")]
		OSCILLATOR,
		[Token(Token = "0x4000627")]
		LOWPASS,
		[Token(Token = "0x4000628")]
		ITLOWPASS,
		[Token(Token = "0x4000629")]
		HIGHPASS,
		[Token(Token = "0x400062A")]
		ECHO,
		[Token(Token = "0x400062B")]
		FADER,
		[Token(Token = "0x400062C")]
		FLANGE,
		[Token(Token = "0x400062D")]
		DISTORTION,
		[Token(Token = "0x400062E")]
		NORMALIZE,
		[Token(Token = "0x400062F")]
		LIMITER,
		[Token(Token = "0x4000630")]
		PARAMEQ,
		[Token(Token = "0x4000631")]
		PITCHSHIFT,
		[Token(Token = "0x4000632")]
		CHORUS,
		[Token(Token = "0x4000633")]
		VSTPLUGIN,
		[Token(Token = "0x4000634")]
		WINAMPPLUGIN,
		[Token(Token = "0x4000635")]
		ITECHO,
		[Token(Token = "0x4000636")]
		COMPRESSOR,
		[Token(Token = "0x4000637")]
		SFXREVERB,
		[Token(Token = "0x4000638")]
		LOWPASS_SIMPLE,
		[Token(Token = "0x4000639")]
		DELAY,
		[Token(Token = "0x400063A")]
		TREMOLO,
		[Token(Token = "0x400063B")]
		LADSPAPLUGIN,
		[Token(Token = "0x400063C")]
		SEND,
		[Token(Token = "0x400063D")]
		RETURN,
		[Token(Token = "0x400063E")]
		HIGHPASS_SIMPLE,
		[Token(Token = "0x400063F")]
		PAN,
		[Token(Token = "0x4000640")]
		THREE_EQ,
		[Token(Token = "0x4000641")]
		FFT,
		[Token(Token = "0x4000642")]
		LOUDNESS_METER,
		[Token(Token = "0x4000643")]
		ENVELOPEFOLLOWER,
		[Token(Token = "0x4000644")]
		CONVOLUTIONREVERB,
		[Token(Token = "0x4000645")]
		CHANNELMIX,
		[Token(Token = "0x4000646")]
		TRANSCEIVER,
		[Token(Token = "0x4000647")]
		OBJECTPAN,
		[Token(Token = "0x4000648")]
		MULTIBAND_EQ,
		[Token(Token = "0x4000649")]
		MAX
	}
	[Token(Token = "0x20000F8")]
	public enum DSP_PARAMETER_TYPE
	{
		[Token(Token = "0x400064B")]
		FLOAT,
		[Token(Token = "0x400064C")]
		INT,
		[Token(Token = "0x400064D")]
		BOOL,
		[Token(Token = "0x400064E")]
		DATA,
		[Token(Token = "0x400064F")]
		MAX
	}
	[Token(Token = "0x20000F9")]
	public enum DSP_PARAMETER_FLOAT_MAPPING_TYPE
	{
		[Token(Token = "0x4000651")]
		DSP_PARAMETER_FLOAT_MAPPING_TYPE_LINEAR,
		[Token(Token = "0x4000652")]
		DSP_PARAMETER_FLOAT_MAPPING_TYPE_AUTO,
		[Token(Token = "0x4000653")]
		DSP_PARAMETER_FLOAT_MAPPING_TYPE_PIECEWISE_LINEAR
	}
	[Token(Token = "0x20000FA")]
	public struct DSP_PARAMETER_FLOAT_MAPPING_PIECEWISE_LINEAR
	{
		[Token(Token = "0x4000654")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int numpoints;

		[Token(Token = "0x4000655")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public IntPtr pointparamvalues;

		[Token(Token = "0x4000656")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public IntPtr pointpositions;
	}
	[Token(Token = "0x20000FB")]
	public struct DSP_PARAMETER_FLOAT_MAPPING
	{
		[Token(Token = "0x4000657")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public DSP_PARAMETER_FLOAT_MAPPING_TYPE type;

		[Token(Token = "0x4000658")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public DSP_PARAMETER_FLOAT_MAPPING_PIECEWISE_LINEAR piecewiselinearmapping;
	}
	[Token(Token = "0x20000FC")]
	public struct DSP_PARAMETER_DESC_FLOAT
	{
		[Token(Token = "0x4000659")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float min;

		[Token(Token = "0x400065A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public float max;

		[Token(Token = "0x400065B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public float defaultval;

		[Token(Token = "0x400065C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public DSP_PARAMETER_FLOAT_MAPPING mapping;
	}
	[Token(Token = "0x20000FD")]
	public struct DSP_PARAMETER_DESC_INT
	{
		[Token(Token = "0x400065D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int min;

		[Token(Token = "0x400065E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public int max;

		[Token(Token = "0x400065F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public int defaultval;

		[Token(Token = "0x4000660")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public bool goestoinf;

		[Token(Token = "0x4000661")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public IntPtr valuenames;
	}
	[Token(Token = "0x20000FE")]
	public struct DSP_PARAMETER_DESC_BOOL
	{
		[Token(Token = "0x4000662")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public bool defaultval;

		[Token(Token = "0x4000663")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public IntPtr valuenames;
	}
	[Token(Token = "0x20000FF")]
	public struct DSP_PARAMETER_DESC_DATA
	{
		[Token(Token = "0x4000664")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int datatype;
	}
	[StructLayout(2)]
	[Token(Token = "0x2000100")]
	public struct DSP_PARAMETER_DESC_UNION
	{
		[Token(Token = "0x4000665")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public DSP_PARAMETER_DESC_FLOAT floatdesc;

		[Token(Token = "0x4000666")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public DSP_PARAMETER_DESC_INT intdesc;

		[Token(Token = "0x4000667")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public DSP_PARAMETER_DESC_BOOL booldesc;

		[Token(Token = "0x4000668")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public DSP_PARAMETER_DESC_DATA datadesc;
	}
	[Token(Token = "0x2000101")]
	public struct DSP_PARAMETER_DESC
	{
		[Token(Token = "0x4000669")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public DSP_PARAMETER_TYPE type;

		[Token(Token = "0x400066A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public byte[] name;

		[Token(Token = "0x400066B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public byte[] label;

		[Token(Token = "0x400066C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string description;

		[Token(Token = "0x400066D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public DSP_PARAMETER_DESC_UNION desc;
	}
	[Token(Token = "0x2000102")]
	public enum DSP_PARAMETER_DATA_TYPE
	{
		[Token(Token = "0x400066F")]
		DSP_PARAMETER_DATA_TYPE_USER = 0,
		[Token(Token = "0x4000670")]
		DSP_PARAMETER_DATA_TYPE_OVERALLGAIN = -1,
		[Token(Token = "0x4000671")]
		DSP_PARAMETER_DATA_TYPE_3DATTRIBUTES = -2,
		[Token(Token = "0x4000672")]
		DSP_PARAMETER_DATA_TYPE_SIDECHAIN = -3,
		[Token(Token = "0x4000673")]
		DSP_PARAMETER_DATA_TYPE_FFT = -4,
		[Token(Token = "0x4000674")]
		DSP_PARAMETER_DATA_TYPE_3DATTRIBUTES_MULTI = -5
	}
	[Token(Token = "0x2000103")]
	public struct DSP_PARAMETER_OVERALLGAIN
	{
		[Token(Token = "0x4000675")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float linear_gain;

		[Token(Token = "0x4000676")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public float linear_gain_additive;
	}
	[Token(Token = "0x2000104")]
	public struct DSP_PARAMETER_3DATTRIBUTES
	{
		[Token(Token = "0x4000677")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public ATTRIBUTES_3D relative;

		[Token(Token = "0x4000678")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public ATTRIBUTES_3D absolute;
	}
	[Token(Token = "0x2000105")]
	public struct DSP_PARAMETER_3DATTRIBUTES_MULTI
	{
		[Token(Token = "0x4000679")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int numlisteners;

		[Token(Token = "0x400067A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public ATTRIBUTES_3D[] relative;

		[Token(Token = "0x400067B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float[] weight;

		[Token(Token = "0x400067C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public ATTRIBUTES_3D absolute;
	}
	[Token(Token = "0x2000106")]
	public struct DSP_PARAMETER_SIDECHAIN
	{
		[Token(Token = "0x400067D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int sidechainenable;
	}
	[Token(Token = "0x2000107")]
	public struct DSP_PARAMETER_FFT
	{
		[Token(Token = "0x400067E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int length;

		[Token(Token = "0x400067F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public int numchannels;

		[Token(Token = "0x4000680")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private IntPtr[] spectrum_internal;

		[Token(Token = "0x1700006D")]
		public float[][] spectrum
		{
			[Token(Token = "0x6000964")]
			[Address(RVA = "0x32A5C30", Offset = "0x32A5C30", VA = "0x32A5C30")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000965")]
		[Address(RVA = "0x32A5D80", Offset = "0x32A5D80", VA = "0x32A5D80")]
		public void GetSpecturmPreAloc(ref float[][] buffer)
		{
		}

		[Token(Token = "0x6000966")]
		[Address(RVA = "0x32A5F5C", Offset = "0x32A5F5C", VA = "0x32A5F5C")]
		public void getSpectrum(ref float[][] buffer)
		{
		}

		[Token(Token = "0x6000967")]
		[Address(RVA = "0x32A6044", Offset = "0x32A6044", VA = "0x32A6044")]
		public void getSpectrum(int channel, ref float[] buffer)
		{
		}
	}
	[Token(Token = "0x2000108")]
	public struct DSP_DESCRIPTION
	{
		[Token(Token = "0x4000681")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public uint pluginsdkversion;

		[Token(Token = "0x4000682")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public char[] name;

		[Token(Token = "0x4000683")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public uint version;

		[Token(Token = "0x4000684")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public int numinputbuffers;

		[Token(Token = "0x4000685")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int numoutputbuffers;

		[Token(Token = "0x4000686")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public DSP_CREATECALLBACK create;

		[Token(Token = "0x4000687")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public DSP_RELEASECALLBACK release;

		[Token(Token = "0x4000688")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public DSP_RESETCALLBACK reset;

		[Token(Token = "0x4000689")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public DSP_READCALLBACK read;

		[Token(Token = "0x400068A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public DSP_PROCESS_CALLBACK process;

		[Token(Token = "0x400068B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public DSP_SETPOSITIONCALLBACK setposition;

		[Token(Token = "0x400068C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public int numparameters;

		[Token(Token = "0x400068D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public IntPtr paramdesc;

		[Token(Token = "0x400068E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public DSP_SETPARAM_FLOAT_CALLBACK setparameterfloat;

		[Token(Token = "0x400068F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public DSP_SETPARAM_INT_CALLBACK setparameterint;

		[Token(Token = "0x4000690")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public DSP_SETPARAM_BOOL_CALLBACK setparameterbool;

		[Token(Token = "0x4000691")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public DSP_SETPARAM_DATA_CALLBACK setparameterdata;

		[Token(Token = "0x4000692")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public DSP_GETPARAM_FLOAT_CALLBACK getparameterfloat;

		[Token(Token = "0x4000693")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public DSP_GETPARAM_INT_CALLBACK getparameterint;

		[Token(Token = "0x4000694")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public DSP_GETPARAM_BOOL_CALLBACK getparameterbool;

		[Token(Token = "0x4000695")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public DSP_GETPARAM_DATA_CALLBACK getparameterdata;

		[Token(Token = "0x4000696")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public DSP_SHOULDIPROCESS_CALLBACK shouldiprocess;

		[Token(Token = "0x4000697")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public IntPtr userdata;

		[Token(Token = "0x4000698")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public DSP_SYSTEM_REGISTER_CALLBACK sys_register;

		[Token(Token = "0x4000699")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public DSP_SYSTEM_DEREGISTER_CALLBACK sys_deregister;

		[Token(Token = "0x400069A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public DSP_SYSTEM_MIX_CALLBACK sys_mix;
	}
	[Token(Token = "0x2000109")]
	public struct DSP_STATE_DFT_FUNCTIONS
	{
		[Token(Token = "0x400069B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public DSP_DFT_FFTREAL_FUNC fftreal;

		[Token(Token = "0x400069C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public DSP_DFT_IFFTREAL_FUNC inversefftreal;
	}
	[Token(Token = "0x200010A")]
	public struct DSP_STATE_PAN_FUNCTIONS
	{
		[Token(Token = "0x400069D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public DSP_PAN_SUMMONOMATRIX_FUNC summonomatrix;

		[Token(Token = "0x400069E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public DSP_PAN_SUMSTEREOMATRIX_FUNC sumstereomatrix;

		[Token(Token = "0x400069F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public DSP_PAN_SUMSURROUNDMATRIX_FUNC sumsurroundmatrix;

		[Token(Token = "0x40006A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public DSP_PAN_SUMMONOTOSURROUNDMATRIX_FUNC summonotosurroundmatrix;

		[Token(Token = "0x40006A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public DSP_PAN_SUMSTEREOTOSURROUNDMATRIX_FUNC sumstereotosurroundmatrix;

		[Token(Token = "0x40006A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public DSP_PAN_GETROLLOFFGAIN_FUNC getrolloffgain;
	}
	[Token(Token = "0x200010B")]
	public struct DSP_STATE_FUNCTIONS
	{
		[Token(Token = "0x40006A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public DSP_ALLOC_FUNC alloc;

		[Token(Token = "0x40006A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public DSP_REALLOC_FUNC realloc;

		[Token(Token = "0x40006A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public DSP_FREE_FUNC free;

		[Token(Token = "0x40006A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public DSP_GETSAMPLERATE_FUNC getsamplerate;

		[Token(Token = "0x40006A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public DSP_GETBLOCKSIZE_FUNC getblocksize;

		[Token(Token = "0x40006A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public IntPtr dft;

		[Token(Token = "0x40006A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public IntPtr pan;

		[Token(Token = "0x40006AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public DSP_GETSPEAKERMODE_FUNC getspeakermode;

		[Token(Token = "0x40006AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public DSP_GETCLOCK_FUNC getclock;

		[Token(Token = "0x40006AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public DSP_GETLISTENERATTRIBUTES_FUNC getlistenerattributes;

		[Token(Token = "0x40006AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public DSP_LOG_FUNC log;

		[Token(Token = "0x40006AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public DSP_GETUSERDATA_FUNC getuserdata;
	}
	[Token(Token = "0x200010C")]
	public struct DSP_STATE
	{
		[Token(Token = "0x40006AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public IntPtr instance;

		[Token(Token = "0x40006B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public IntPtr plugindata;

		[Token(Token = "0x40006B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public uint channelmask;

		[Token(Token = "0x40006B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public int source_speakermode;

		[Token(Token = "0x40006B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public IntPtr sidechaindata;

		[Token(Token = "0x40006B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public int sidechainchannels;

		[Token(Token = "0x40006B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public IntPtr functions;

		[Token(Token = "0x40006B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public int systemobject;
	}
	[Token(Token = "0x200010D")]
	public struct DSP_METERING_INFO
	{
		[Token(Token = "0x40006B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int numsamples;

		[Token(Token = "0x40006B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public float[] peaklevel;

		[Token(Token = "0x40006B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float[] rmslevel;

		[Token(Token = "0x40006BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public short numchannels;
	}
	[Token(Token = "0x200010E")]
	public enum DSP_OSCILLATOR
	{
		[Token(Token = "0x40006BC")]
		TYPE,
		[Token(Token = "0x40006BD")]
		RATE
	}
	[Token(Token = "0x200010F")]
	public enum DSP_LOWPASS
	{
		[Token(Token = "0x40006BF")]
		CUTOFF,
		[Token(Token = "0x40006C0")]
		RESONANCE
	}
	[Token(Token = "0x2000110")]
	public enum DSP_ITLOWPASS
	{
		[Token(Token = "0x40006C2")]
		CUTOFF,
		[Token(Token = "0x40006C3")]
		RESONANCE
	}
	[Token(Token = "0x2000111")]
	public enum DSP_HIGHPASS
	{
		[Token(Token = "0x40006C5")]
		CUTOFF,
		[Token(Token = "0x40006C6")]
		RESONANCE
	}
	[Token(Token = "0x2000112")]
	public enum DSP_ECHO
	{
		[Token(Token = "0x40006C8")]
		DELAY,
		[Token(Token = "0x40006C9")]
		FEEDBACK,
		[Token(Token = "0x40006CA")]
		DRYLEVEL,
		[Token(Token = "0x40006CB")]
		WETLEVEL
	}
	[Token(Token = "0x2000113")]
	public enum DSP_FADER
	{
		[Token(Token = "0x40006CD")]
		GAIN,
		[Token(Token = "0x40006CE")]
		OVERALL_GAIN
	}
	[Token(Token = "0x2000114")]
	public enum DSP_DELAY
	{
		[Token(Token = "0x40006D0")]
		CH0,
		[Token(Token = "0x40006D1")]
		CH1,
		[Token(Token = "0x40006D2")]
		CH2,
		[Token(Token = "0x40006D3")]
		CH3,
		[Token(Token = "0x40006D4")]
		CH4,
		[Token(Token = "0x40006D5")]
		CH5,
		[Token(Token = "0x40006D6")]
		CH6,
		[Token(Token = "0x40006D7")]
		CH7,
		[Token(Token = "0x40006D8")]
		CH8,
		[Token(Token = "0x40006D9")]
		CH9,
		[Token(Token = "0x40006DA")]
		CH10,
		[Token(Token = "0x40006DB")]
		CH11,
		[Token(Token = "0x40006DC")]
		CH12,
		[Token(Token = "0x40006DD")]
		CH13,
		[Token(Token = "0x40006DE")]
		CH14,
		[Token(Token = "0x40006DF")]
		CH15,
		[Token(Token = "0x40006E0")]
		MAXDELAY
	}
	[Token(Token = "0x2000115")]
	public enum DSP_FLANGE
	{
		[Token(Token = "0x40006E2")]
		MIX,
		[Token(Token = "0x40006E3")]
		DEPTH,
		[Token(Token = "0x40006E4")]
		RATE
	}
	[Token(Token = "0x2000116")]
	public enum DSP_TREMOLO
	{
		[Token(Token = "0x40006E6")]
		FREQUENCY,
		[Token(Token = "0x40006E7")]
		DEPTH,
		[Token(Token = "0x40006E8")]
		SHAPE,
		[Token(Token = "0x40006E9")]
		SKEW,
		[Token(Token = "0x40006EA")]
		DUTY,
		[Token(Token = "0x40006EB")]
		SQUARE,
		[Token(Token = "0x40006EC")]
		PHASE,
		[Token(Token = "0x40006ED")]
		SPREAD
	}
	[Token(Token = "0x2000117")]
	public enum DSP_DISTORTION
	{
		[Token(Token = "0x40006EF")]
		LEVEL
	}
	[Token(Token = "0x2000118")]
	public enum DSP_NORMALIZE
	{
		[Token(Token = "0x40006F1")]
		FADETIME,
		[Token(Token = "0x40006F2")]
		THRESHHOLD,
		[Token(Token = "0x40006F3")]
		MAXAMP
	}
	[Token(Token = "0x2000119")]
	public enum DSP_LIMITER
	{
		[Token(Token = "0x40006F5")]
		RELEASETIME,
		[Token(Token = "0x40006F6")]
		CEILING,
		[Token(Token = "0x40006F7")]
		MAXIMIZERGAIN,
		[Token(Token = "0x40006F8")]
		MODE
	}
	[Token(Token = "0x200011A")]
	public enum DSP_PARAMEQ
	{
		[Token(Token = "0x40006FA")]
		CENTER,
		[Token(Token = "0x40006FB")]
		BANDWIDTH,
		[Token(Token = "0x40006FC")]
		GAIN
	}
	[Token(Token = "0x200011B")]
	public enum DSP_MULTIBAND_EQ
	{
		[Token(Token = "0x40006FE")]
		A_FILTER,
		[Token(Token = "0x40006FF")]
		A_FREQUENCY,
		[Token(Token = "0x4000700")]
		A_Q,
		[Token(Token = "0x4000701")]
		A_GAIN,
		[Token(Token = "0x4000702")]
		B_FILTER,
		[Token(Token = "0x4000703")]
		B_FREQUENCY,
		[Token(Token = "0x4000704")]
		B_Q,
		[Token(Token = "0x4000705")]
		B_GAIN,
		[Token(Token = "0x4000706")]
		C_FILTER,
		[Token(Token = "0x4000707")]
		C_FREQUENCY,
		[Token(Token = "0x4000708")]
		C_Q,
		[Token(Token = "0x4000709")]
		C_GAIN,
		[Token(Token = "0x400070A")]
		D_FILTER,
		[Token(Token = "0x400070B")]
		D_FREQUENCY,
		[Token(Token = "0x400070C")]
		D_Q,
		[Token(Token = "0x400070D")]
		D_GAIN,
		[Token(Token = "0x400070E")]
		E_FILTER,
		[Token(Token = "0x400070F")]
		E_FREQUENCY,
		[Token(Token = "0x4000710")]
		E_Q,
		[Token(Token = "0x4000711")]
		E_GAIN
	}
	[Token(Token = "0x200011C")]
	public enum DSP_MULTIBAND_EQ_FILTER_TYPE
	{
		[Token(Token = "0x4000713")]
		DISABLED,
		[Token(Token = "0x4000714")]
		LOWPASS_12DB,
		[Token(Token = "0x4000715")]
		LOWPASS_24DB,
		[Token(Token = "0x4000716")]
		LOWPASS_48DB,
		[Token(Token = "0x4000717")]
		HIGHPASS_12DB,
		[Token(Token = "0x4000718")]
		HIGHPASS_24DB,
		[Token(Token = "0x4000719")]
		HIGHPASS_48DB,
		[Token(Token = "0x400071A")]
		LOWSHELF,
		[Token(Token = "0x400071B")]
		HIGHSHELF,
		[Token(Token = "0x400071C")]
		PEAKING,
		[Token(Token = "0x400071D")]
		BANDPASS,
		[Token(Token = "0x400071E")]
		NOTCH,
		[Token(Token = "0x400071F")]
		ALLPASS
	}
	[Token(Token = "0x200011D")]
	public enum DSP_PITCHSHIFT
	{
		[Token(Token = "0x4000721")]
		PITCH,
		[Token(Token = "0x4000722")]
		FFTSIZE,
		[Token(Token = "0x4000723")]
		OVERLAP,
		[Token(Token = "0x4000724")]
		MAXCHANNELS
	}
	[Token(Token = "0x200011E")]
	public enum DSP_CHORUS
	{
		[Token(Token = "0x4000726")]
		MIX,
		[Token(Token = "0x4000727")]
		RATE,
		[Token(Token = "0x4000728")]
		DEPTH
	}
	[Token(Token = "0x200011F")]
	public enum DSP_ITECHO
	{
		[Token(Token = "0x400072A")]
		WETDRYMIX,
		[Token(Token = "0x400072B")]
		FEEDBACK,
		[Token(Token = "0x400072C")]
		LEFTDELAY,
		[Token(Token = "0x400072D")]
		RIGHTDELAY,
		[Token(Token = "0x400072E")]
		PANDELAY
	}
	[Token(Token = "0x2000120")]
	public enum DSP_COMPRESSOR
	{
		[Token(Token = "0x4000730")]
		THRESHOLD,
		[Token(Token = "0x4000731")]
		RATIO,
		[Token(Token = "0x4000732")]
		ATTACK,
		[Token(Token = "0x4000733")]
		RELEASE,
		[Token(Token = "0x4000734")]
		GAINMAKEUP,
		[Token(Token = "0x4000735")]
		USESIDECHAIN,
		[Token(Token = "0x4000736")]
		LINKED
	}
	[Token(Token = "0x2000121")]
	public enum DSP_SFXREVERB
	{
		[Token(Token = "0x4000738")]
		DECAYTIME,
		[Token(Token = "0x4000739")]
		EARLYDELAY,
		[Token(Token = "0x400073A")]
		LATEDELAY,
		[Token(Token = "0x400073B")]
		HFREFERENCE,
		[Token(Token = "0x400073C")]
		HFDECAYRATIO,
		[Token(Token = "0x400073D")]
		DIFFUSION,
		[Token(Token = "0x400073E")]
		DENSITY,
		[Token(Token = "0x400073F")]
		LOWSHELFFREQUENCY,
		[Token(Token = "0x4000740")]
		LOWSHELFGAIN,
		[Token(Token = "0x4000741")]
		HIGHCUT,
		[Token(Token = "0x4000742")]
		EARLYLATEMIX,
		[Token(Token = "0x4000743")]
		WETLEVEL,
		[Token(Token = "0x4000744")]
		DRYLEVEL
	}
	[Token(Token = "0x2000122")]
	public enum DSP_LOWPASS_SIMPLE
	{
		[Token(Token = "0x4000746")]
		CUTOFF
	}
	[Token(Token = "0x2000123")]
	public enum DSP_SEND
	{
		[Token(Token = "0x4000748")]
		RETURNID,
		[Token(Token = "0x4000749")]
		LEVEL
	}
	[Token(Token = "0x2000124")]
	public enum DSP_RETURN
	{
		[Token(Token = "0x400074B")]
		ID,
		[Token(Token = "0x400074C")]
		INPUT_SPEAKER_MODE
	}
	[Token(Token = "0x2000125")]
	public enum DSP_HIGHPASS_SIMPLE
	{
		[Token(Token = "0x400074E")]
		CUTOFF
	}
	[Token(Token = "0x2000126")]
	public enum DSP_PAN_2D_STEREO_MODE_TYPE
	{
		[Token(Token = "0x4000750")]
		DISTRIBUTED,
		[Token(Token = "0x4000751")]
		DISCRETE
	}
	[Token(Token = "0x2000127")]
	public enum DSP_PAN_MODE_TYPE
	{
		[Token(Token = "0x4000753")]
		MONO,
		[Token(Token = "0x4000754")]
		STEREO,
		[Token(Token = "0x4000755")]
		SURROUND
	}
	[Token(Token = "0x2000128")]
	public enum DSP_PAN_3D_ROLLOFF_TYPE
	{
		[Token(Token = "0x4000757")]
		LINEARSQUARED,
		[Token(Token = "0x4000758")]
		LINEAR,
		[Token(Token = "0x4000759")]
		INVERSE,
		[Token(Token = "0x400075A")]
		INVERSETAPERED,
		[Token(Token = "0x400075B")]
		CUSTOM
	}
	[Token(Token = "0x2000129")]
	public enum DSP_PAN_3D_EXTENT_MODE_TYPE
	{
		[Token(Token = "0x400075D")]
		AUTO,
		[Token(Token = "0x400075E")]
		USER,
		[Token(Token = "0x400075F")]
		OFF
	}
	[Token(Token = "0x200012A")]
	public enum DSP_PAN
	{
		[Token(Token = "0x4000761")]
		MODE,
		[Token(Token = "0x4000762")]
		_2D_STEREO_POSITION,
		[Token(Token = "0x4000763")]
		_2D_DIRECTION,
		[Token(Token = "0x4000764")]
		_2D_EXTENT,
		[Token(Token = "0x4000765")]
		_2D_ROTATION,
		[Token(Token = "0x4000766")]
		_2D_LFE_LEVEL,
		[Token(Token = "0x4000767")]
		_2D_STEREO_MODE,
		[Token(Token = "0x4000768")]
		_2D_STEREO_SEPARATION,
		[Token(Token = "0x4000769")]
		_2D_STEREO_AXIS,
		[Token(Token = "0x400076A")]
		ENABLED_SPEAKERS,
		[Token(Token = "0x400076B")]
		_3D_POSITION,
		[Token(Token = "0x400076C")]
		_3D_ROLLOFF,
		[Token(Token = "0x400076D")]
		_3D_MIN_DISTANCE,
		[Token(Token = "0x400076E")]
		_3D_MAX_DISTANCE,
		[Token(Token = "0x400076F")]
		_3D_EXTENT_MODE,
		[Token(Token = "0x4000770")]
		_3D_SOUND_SIZE,
		[Token(Token = "0x4000771")]
		_3D_MIN_EXTENT,
		[Token(Token = "0x4000772")]
		_3D_PAN_BLEND,
		[Token(Token = "0x4000773")]
		LFE_UPMIX_ENABLED,
		[Token(Token = "0x4000774")]
		OVERALL_GAIN,
		[Token(Token = "0x4000775")]
		SURROUND_SPEAKER_MODE,
		[Token(Token = "0x4000776")]
		_2D_HEIGHT_BLEND
	}
	[Token(Token = "0x200012B")]
	public enum DSP_THREE_EQ_CROSSOVERSLOPE_TYPE
	{
		[Token(Token = "0x4000778")]
		_12DB,
		[Token(Token = "0x4000779")]
		_24DB,
		[Token(Token = "0x400077A")]
		_48DB
	}
	[Token(Token = "0x200012C")]
	public enum DSP_THREE_EQ
	{
		[Token(Token = "0x400077C")]
		LOWGAIN,
		[Token(Token = "0x400077D")]
		MIDGAIN,
		[Token(Token = "0x400077E")]
		HIGHGAIN,
		[Token(Token = "0x400077F")]
		LOWCROSSOVER,
		[Token(Token = "0x4000780")]
		HIGHCROSSOVER,
		[Token(Token = "0x4000781")]
		CROSSOVERSLOPE
	}
	[Token(Token = "0x200012D")]
	public enum DSP_FFT_WINDOW
	{
		[Token(Token = "0x4000783")]
		RECT,
		[Token(Token = "0x4000784")]
		TRIANGLE,
		[Token(Token = "0x4000785")]
		HAMMING,
		[Token(Token = "0x4000786")]
		HANNING,
		[Token(Token = "0x4000787")]
		BLACKMAN,
		[Token(Token = "0x4000788")]
		BLACKMANHARRIS
	}
	[Token(Token = "0x200012E")]
	public enum DSP_FFT
	{
		[Token(Token = "0x400078A")]
		WINDOWSIZE,
		[Token(Token = "0x400078B")]
		WINDOWTYPE,
		[Token(Token = "0x400078C")]
		SPECTRUMDATA,
		[Token(Token = "0x400078D")]
		DOMINANT_FREQ
	}
	[Token(Token = "0x200012F")]
	public enum DSP_ENVELOPEFOLLOWER
	{
		[Token(Token = "0x400078F")]
		ATTACK,
		[Token(Token = "0x4000790")]
		RELEASE,
		[Token(Token = "0x4000791")]
		ENVELOPE,
		[Token(Token = "0x4000792")]
		USESIDECHAIN
	}
	[Token(Token = "0x2000130")]
	public enum DSP_CONVOLUTION_REVERB
	{
		[Token(Token = "0x4000794")]
		IR,
		[Token(Token = "0x4000795")]
		WET,
		[Token(Token = "0x4000796")]
		DRY,
		[Token(Token = "0x4000797")]
		LINKED
	}
	[Token(Token = "0x2000131")]
	public enum DSP_CHANNELMIX_OUTPUT
	{
		[Token(Token = "0x4000799")]
		DEFAULT,
		[Token(Token = "0x400079A")]
		ALLMONO,
		[Token(Token = "0x400079B")]
		ALLSTEREO,
		[Token(Token = "0x400079C")]
		ALLQUAD,
		[Token(Token = "0x400079D")]
		ALL5POINT1,
		[Token(Token = "0x400079E")]
		ALL7POINT1,
		[Token(Token = "0x400079F")]
		ALLLFE,
		[Token(Token = "0x40007A0")]
		ALL7POINT1POINT4
	}
	[Token(Token = "0x2000132")]
	public enum DSP_CHANNELMIX
	{
		[Token(Token = "0x40007A2")]
		OUTPUTGROUPING,
		[Token(Token = "0x40007A3")]
		GAIN_CH0,
		[Token(Token = "0x40007A4")]
		GAIN_CH1,
		[Token(Token = "0x40007A5")]
		GAIN_CH2,
		[Token(Token = "0x40007A6")]
		GAIN_CH3,
		[Token(Token = "0x40007A7")]
		GAIN_CH4,
		[Token(Token = "0x40007A8")]
		GAIN_CH5,
		[Token(Token = "0x40007A9")]
		GAIN_CH6,
		[Token(Token = "0x40007AA")]
		GAIN_CH7,
		[Token(Token = "0x40007AB")]
		GAIN_CH8,
		[Token(Token = "0x40007AC")]
		GAIN_CH9,
		[Token(Token = "0x40007AD")]
		GAIN_CH10,
		[Token(Token = "0x40007AE")]
		GAIN_CH11,
		[Token(Token = "0x40007AF")]
		GAIN_CH12,
		[Token(Token = "0x40007B0")]
		GAIN_CH13,
		[Token(Token = "0x40007B1")]
		GAIN_CH14,
		[Token(Token = "0x40007B2")]
		GAIN_CH15,
		[Token(Token = "0x40007B3")]
		GAIN_CH16,
		[Token(Token = "0x40007B4")]
		GAIN_CH17,
		[Token(Token = "0x40007B5")]
		GAIN_CH18,
		[Token(Token = "0x40007B6")]
		GAIN_CH19,
		[Token(Token = "0x40007B7")]
		GAIN_CH20,
		[Token(Token = "0x40007B8")]
		GAIN_CH21,
		[Token(Token = "0x40007B9")]
		GAIN_CH22,
		[Token(Token = "0x40007BA")]
		GAIN_CH23,
		[Token(Token = "0x40007BB")]
		GAIN_CH24,
		[Token(Token = "0x40007BC")]
		GAIN_CH25,
		[Token(Token = "0x40007BD")]
		GAIN_CH26,
		[Token(Token = "0x40007BE")]
		GAIN_CH27,
		[Token(Token = "0x40007BF")]
		GAIN_CH28,
		[Token(Token = "0x40007C0")]
		GAIN_CH29,
		[Token(Token = "0x40007C1")]
		GAIN_CH30,
		[Token(Token = "0x40007C2")]
		GAIN_CH31,
		[Token(Token = "0x40007C3")]
		OUTPUT_CH0,
		[Token(Token = "0x40007C4")]
		OUTPUT_CH1,
		[Token(Token = "0x40007C5")]
		OUTPUT_CH2,
		[Token(Token = "0x40007C6")]
		OUTPUT_CH3,
		[Token(Token = "0x40007C7")]
		OUTPUT_CH4,
		[Token(Token = "0x40007C8")]
		OUTPUT_CH5,
		[Token(Token = "0x40007C9")]
		OUTPUT_CH6,
		[Token(Token = "0x40007CA")]
		OUTPUT_CH7,
		[Token(Token = "0x40007CB")]
		OUTPUT_CH8,
		[Token(Token = "0x40007CC")]
		OUTPUT_CH9,
		[Token(Token = "0x40007CD")]
		OUTPUT_CH10,
		[Token(Token = "0x40007CE")]
		OUTPUT_CH11,
		[Token(Token = "0x40007CF")]
		OUTPUT_CH12,
		[Token(Token = "0x40007D0")]
		OUTPUT_CH13,
		[Token(Token = "0x40007D1")]
		OUTPUT_CH14,
		[Token(Token = "0x40007D2")]
		OUTPUT_CH15,
		[Token(Token = "0x40007D3")]
		OUTPUT_CH16,
		[Token(Token = "0x40007D4")]
		OUTPUT_CH17,
		[Token(Token = "0x40007D5")]
		OUTPUT_CH18,
		[Token(Token = "0x40007D6")]
		OUTPUT_CH19,
		[Token(Token = "0x40007D7")]
		OUTPUT_CH20,
		[Token(Token = "0x40007D8")]
		OUTPUT_CH21,
		[Token(Token = "0x40007D9")]
		OUTPUT_CH22,
		[Token(Token = "0x40007DA")]
		OUTPUT_CH23,
		[Token(Token = "0x40007DB")]
		OUTPUT_CH24,
		[Token(Token = "0x40007DC")]
		OUTPUT_CH25,
		[Token(Token = "0x40007DD")]
		OUTPUT_CH26,
		[Token(Token = "0x40007DE")]
		OUTPUT_CH27,
		[Token(Token = "0x40007DF")]
		OUTPUT_CH28,
		[Token(Token = "0x40007E0")]
		OUTPUT_CH29,
		[Token(Token = "0x40007E1")]
		OUTPUT_CH30,
		[Token(Token = "0x40007E2")]
		OUTPUT_CH31
	}
	[Token(Token = "0x2000133")]
	public enum DSP_TRANSCEIVER_SPEAKERMODE
	{
		[Token(Token = "0x40007E4")]
		AUTO = -1,
		[Token(Token = "0x40007E5")]
		MONO,
		[Token(Token = "0x40007E6")]
		STEREO,
		[Token(Token = "0x40007E7")]
		SURROUND
	}
	[Token(Token = "0x2000134")]
	public enum DSP_TRANSCEIVER
	{
		[Token(Token = "0x40007E9")]
		TRANSMIT,
		[Token(Token = "0x40007EA")]
		GAIN,
		[Token(Token = "0x40007EB")]
		CHANNEL,
		[Token(Token = "0x40007EC")]
		TRANSMITSPEAKERMODE
	}
	[Token(Token = "0x2000135")]
	public enum DSP_OBJECTPAN
	{
		[Token(Token = "0x40007EE")]
		_3D_POSITION,
		[Token(Token = "0x40007EF")]
		_3D_ROLLOFF,
		[Token(Token = "0x40007F0")]
		_3D_MIN_DISTANCE,
		[Token(Token = "0x40007F1")]
		_3D_MAX_DISTANCE,
		[Token(Token = "0x40007F2")]
		_3D_EXTENT_MODE,
		[Token(Token = "0x40007F3")]
		_3D_SOUND_SIZE,
		[Token(Token = "0x40007F4")]
		_3D_MIN_EXTENT,
		[Token(Token = "0x40007F5")]
		OVERALL_GAIN,
		[Token(Token = "0x40007F6")]
		OUTPUTGAIN
	}
	[Token(Token = "0x2000136")]
	public class Error
	{
		[Token(Token = "0x6000968")]
		[Address(RVA = "0x32A9744", Offset = "0x32A9744", VA = "0x32A9744")]
		public static string String(RESULT errcode)
		{
			return null;
		}

		[Token(Token = "0x6000969")]
		[Address(RVA = "0x32A97A8", Offset = "0x32A97A8", VA = "0x32A97A8")]
		public Error()
		{
		}
	}
}
namespace FMOD.Studio
{
	[Token(Token = "0x2000137")]
	public class STUDIO_VERSION
	{
		[Token(Token = "0x40007F7")]
		public const string dll = "fmodstudio";

		[Token(Token = "0x600096A")]
		[Address(RVA = "0x3268CBC", Offset = "0x3268CBC", VA = "0x3268CBC")]
		public STUDIO_VERSION()
		{
		}
	}
	[Token(Token = "0x2000138")]
	public enum STOP_MODE
	{
		[Token(Token = "0x40007F9")]
		ALLOWFADEOUT,
		[Token(Token = "0x40007FA")]
		IMMEDIATE
	}
	[Token(Token = "0x2000139")]
	public enum LOADING_STATE
	{
		[Token(Token = "0x40007FC")]
		UNLOADING,
		[Token(Token = "0x40007FD")]
		UNLOADED,
		[Token(Token = "0x40007FE")]
		LOADING,
		[Token(Token = "0x40007FF")]
		LOADED,
		[Token(Token = "0x4000800")]
		ERROR
	}
	[Token(Token = "0x200013A")]
	public struct PROGRAMMER_SOUND_PROPERTIES
	{
		[Token(Token = "0x4000801")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public StringWrapper name;

		[Token(Token = "0x4000802")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public IntPtr sound;

		[Token(Token = "0x4000803")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int subsoundIndex;
	}
	[Token(Token = "0x200013B")]
	public struct TIMELINE_MARKER_PROPERTIES
	{
		[Token(Token = "0x4000804")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public StringWrapper name;

		[Token(Token = "0x4000805")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public int position;
	}
	[Token(Token = "0x200013C")]
	public struct TIMELINE_BEAT_PROPERTIES
	{
		[Token(Token = "0x4000806")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int bar;

		[Token(Token = "0x4000807")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public int beat;

		[Token(Token = "0x4000808")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public int position;

		[Token(Token = "0x4000809")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public float tempo;

		[Token(Token = "0x400080A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int timesignatureupper;

		[Token(Token = "0x400080B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public int timesignaturelower;
	}
	[Token(Token = "0x200013D")]
	public struct ADVANCEDSETTINGS
	{
		[Token(Token = "0x400080C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int cbsize;

		[Token(Token = "0x400080D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public int commandqueuesize;

		[Token(Token = "0x400080E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public int handleinitialsize;

		[Token(Token = "0x400080F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public int studioupdateperiod;

		[Token(Token = "0x4000810")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int idlesampledatapoolsize;

		[Token(Token = "0x4000811")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public int streamingscheduledelay;

		[Token(Token = "0x4000812")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public IntPtr encryptionkey;
	}
	[Token(Token = "0x200013E")]
	public struct CPU_USAGE
	{
		[Token(Token = "0x4000813")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float dspusage;

		[Token(Token = "0x4000814")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public float streamusage;

		[Token(Token = "0x4000815")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public float geometryusage;

		[Token(Token = "0x4000816")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public float updateusage;

		[Token(Token = "0x4000817")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float studiousage;
	}
	[Token(Token = "0x200013F")]
	public struct BUFFER_INFO
	{
		[Token(Token = "0x4000818")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int currentusage;

		[Token(Token = "0x4000819")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public int peakusage;

		[Token(Token = "0x400081A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public int capacity;

		[Token(Token = "0x400081B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public int stallcount;

		[Token(Token = "0x400081C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float stalltime;
	}
	[Token(Token = "0x2000140")]
	public struct BUFFER_USAGE
	{
		[Token(Token = "0x400081D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public BUFFER_INFO studiocommandqueue;

		[Token(Token = "0x400081E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public BUFFER_INFO studiohandle;
	}
	[Token(Token = "0x2000141")]
	public struct BANK_INFO
	{
		[Token(Token = "0x400081F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int size;

		[Token(Token = "0x4000820")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public IntPtr userdata;

		[Token(Token = "0x4000821")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int userdatalength;

		[Token(Token = "0x4000822")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public FILE_OPEN_CALLBACK opencallback;

		[Token(Token = "0x4000823")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public FILE_CLOSE_CALLBACK closecallback;

		[Token(Token = "0x4000824")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public FILE_READ_CALLBACK readcallback;

		[Token(Token = "0x4000825")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public FILE_SEEK_CALLBACK seekcallback;
	}
	[Token(Token = "0x2000142")]
	[Flags]
	public enum SYSTEM_CALLBACK_TYPE : uint
	{
		[Token(Token = "0x4000827")]
		PREUPDATE = 1u,
		[Token(Token = "0x4000828")]
		POSTUPDATE = 2u,
		[Token(Token = "0x4000829")]
		BANK_UNLOAD = 4u,
		[Token(Token = "0x400082A")]
		ALL = uint.MaxValue
	}
	[Token(Token = "0x2000143")]
	public delegate RESULT SYSTEM_CALLBACK(IntPtr system, SYSTEM_CALLBACK_TYPE type, IntPtr commanddata, IntPtr userdata);
	[Token(Token = "0x2000144")]
	public enum PARAMETER_TYPE
	{
		[Token(Token = "0x400082C")]
		GAME_CONTROLLED,
		[Token(Token = "0x400082D")]
		AUTOMATIC_DISTANCE,
		[Token(Token = "0x400082E")]
		AUTOMATIC_EVENT_CONE_ANGLE,
		[Token(Token = "0x400082F")]
		AUTOMATIC_EVENT_ORIENTATION,
		[Token(Token = "0x4000830")]
		AUTOMATIC_DIRECTION,
		[Token(Token = "0x4000831")]
		AUTOMATIC_ELEVATION,
		[Token(Token = "0x4000832")]
		AUTOMATIC_LISTENER_ORIENTATION,
		[Token(Token = "0x4000833")]
		AUTOMATIC_SPEED,
		[Token(Token = "0x4000834")]
		MAX
	}
	[Token(Token = "0x2000145")]
	[Flags]
	public enum PARAMETER_FLAGS : uint
	{
		[Token(Token = "0x4000836")]
		READONLY = 1u,
		[Token(Token = "0x4000837")]
		AUTOMATIC = 2u,
		[Token(Token = "0x4000838")]
		GLOBAL = 4u
	}
	[StructLayout(2)]
	[Token(Token = "0x2000146")]
	public struct PARAMETER_ID
	{
		[Token(Token = "0x4000839")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public uint data1;

		[Token(Token = "0x400083A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public uint data2;

		[Token(Token = "0x400083B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public ulong dataL;
	}
	[Token(Token = "0x2000147")]
	public struct PARAMETER_DESCRIPTION
	{
		[Token(Token = "0x400083C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public StringWrapper name;

		[Token(Token = "0x400083D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public PARAMETER_ID id;

		[Token(Token = "0x400083E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float minimum;

		[Token(Token = "0x400083F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public float maximum;

		[Token(Token = "0x4000840")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float defaultvalue;

		[Token(Token = "0x4000841")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public PARAMETER_TYPE type;

		[Token(Token = "0x4000842")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public PARAMETER_FLAGS flags;
	}
	[Token(Token = "0x2000148")]
	internal enum LOAD_MEMORY_MODE
	{
		[Token(Token = "0x4000844")]
		LOAD_MEMORY,
		[Token(Token = "0x4000845")]
		LOAD_MEMORY_POINT
	}
	[Token(Token = "0x2000149")]
	internal enum LOAD_MEMORY_ALIGNMENT
	{
		[Token(Token = "0x4000847")]
		VALUE = 0x20
	}
	[Token(Token = "0x200014A")]
	public struct SOUND_INFO
	{
		[Token(Token = "0x4000848")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public IntPtr name_or_data;

		[Token(Token = "0x4000849")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public MODE mode;

		[Token(Token = "0x400084A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public CREATESOUNDEXINFO exinfo;

		[Token(Token = "0x400084B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		public int subsoundindex;

		[Token(Token = "0x1700006E")]
		public string name
		{
			[Token(Token = "0x600096F")]
			[Address(RVA = "0x3268B58", Offset = "0x3268B58", VA = "0x3268B58")]
			get
			{
				return null;
			}
		}
	}
	[Token(Token = "0x200014B")]
	public enum USER_PROPERTY_TYPE
	{
		[Token(Token = "0x400084D")]
		INTEGER,
		[Token(Token = "0x400084E")]
		BOOLEAN,
		[Token(Token = "0x400084F")]
		FLOAT,
		[Token(Token = "0x4000850")]
		STRING
	}
	[Token(Token = "0x200014C")]
	public struct USER_PROPERTY
	{
		[Token(Token = "0x4000851")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public StringWrapper name;

		[Token(Token = "0x4000852")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public USER_PROPERTY_TYPE type;

		[Token(Token = "0x4000853")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private Union_IntBoolFloatString value;

		[Token(Token = "0x6000970")]
		[Address(RVA = "0x23EE0FC", Offset = "0x23EE0FC", VA = "0x23EE0FC")]
		public int intValue()
		{
			return default(int);
		}

		[Token(Token = "0x6000971")]
		[Address(RVA = "0x23EE114", Offset = "0x23EE114", VA = "0x23EE114")]
		public bool boolValue()
		{
			return default(bool);
		}

		[Token(Token = "0x6000972")]
		[Address(RVA = "0x23EE138", Offset = "0x23EE138", VA = "0x23EE138")]
		public float floatValue()
		{
			return default(float);
		}

		[Token(Token = "0x6000973")]
		[Address(RVA = "0x23EE154", Offset = "0x23EE154", VA = "0x23EE154")]
		public string stringValue()
		{
			return null;
		}
	}
	[StructLayout(2)]
	[Token(Token = "0x200014D")]
	internal struct Union_IntBoolFloatString
	{
		[Token(Token = "0x4000854")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int intvalue;

		[Token(Token = "0x4000855")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public bool boolvalue;

		[Token(Token = "0x4000856")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float floatvalue;

		[Token(Token = "0x4000857")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public StringWrapper stringvalue;
	}
	[Token(Token = "0x200014E")]
	[Flags]
	public enum INITFLAGS : uint
	{
		[Token(Token = "0x4000859")]
		NORMAL = 0u,
		[Token(Token = "0x400085A")]
		LIVEUPDATE = 1u,
		[Token(Token = "0x400085B")]
		ALLOW_MISSING_PLUGINS = 2u,
		[Token(Token = "0x400085C")]
		SYNCHRONOUS_UPDATE = 4u,
		[Token(Token = "0x400085D")]
		DEFERRED_CALLBACKS = 8u,
		[Token(Token = "0x400085E")]
		LOAD_FROM_UPDATE = 0x10u,
		[Token(Token = "0x400085F")]
		MEMORY_TRACKING = 0x20u
	}
	[Token(Token = "0x200014F")]
	[Flags]
	public enum LOAD_BANK_FLAGS : uint
	{
		[Token(Token = "0x4000861")]
		NORMAL = 0u,
		[Token(Token = "0x4000862")]
		NONBLOCKING = 1u,
		[Token(Token = "0x4000863")]
		DECOMPRESS_SAMPLES = 2u,
		[Token(Token = "0x4000864")]
		UNENCRYPTED = 4u
	}
	[Token(Token = "0x2000150")]
	[Flags]
	public enum COMMANDCAPTURE_FLAGS : uint
	{
		[Token(Token = "0x4000866")]
		NORMAL = 0u,
		[Token(Token = "0x4000867")]
		FILEFLUSH = 1u,
		[Token(Token = "0x4000868")]
		SKIP_INITIAL_STATE = 2u
	}
	[Token(Token = "0x2000151")]
	[Flags]
	public enum COMMANDREPLAY_FLAGS : uint
	{
		[Token(Token = "0x400086A")]
		NORMAL = 0u,
		[Token(Token = "0x400086B")]
		SKIP_CLEANUP = 1u,
		[Token(Token = "0x400086C")]
		FAST_FORWARD = 2u,
		[Token(Token = "0x400086D")]
		SKIP_BANK_LOAD = 4u
	}
	[Token(Token = "0x2000152")]
	public enum PLAYBACK_STATE
	{
		[Token(Token = "0x400086F")]
		PLAYING,
		[Token(Token = "0x4000870")]
		SUSTAINING,
		[Token(Token = "0x4000871")]
		STOPPED,
		[Token(Token = "0x4000872")]
		STARTING,
		[Token(Token = "0x4000873")]
		STOPPING
	}
	[Token(Token = "0x2000153")]
	public enum EVENT_PROPERTY
	{
		[Token(Token = "0x4000875")]
		CHANNELPRIORITY,
		[Token(Token = "0x4000876")]
		SCHEDULE_DELAY,
		[Token(Token = "0x4000877")]
		SCHEDULE_LOOKAHEAD,
		[Token(Token = "0x4000878")]
		MINIMUM_DISTANCE,
		[Token(Token = "0x4000879")]
		MAXIMUM_DISTANCE,
		[Token(Token = "0x400087A")]
		COOLDOWN,
		[Token(Token = "0x400087B")]
		MAX
	}
	[Token(Token = "0x2000154")]
	public struct PLUGIN_INSTANCE_PROPERTIES
	{
		[Token(Token = "0x400087C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public IntPtr name;

		[Token(Token = "0x400087D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public IntPtr dsp;
	}
	[Token(Token = "0x2000155")]
	[Flags]
	public enum EVENT_CALLBACK_TYPE : uint
	{
		[Token(Token = "0x400087F")]
		CREATED = 1u,
		[Token(Token = "0x4000880")]
		DESTROYED = 2u,
		[Token(Token = "0x4000881")]
		STARTING = 4u,
		[Token(Token = "0x4000882")]
		STARTED = 8u,
		[Token(Token = "0x4000883")]
		RESTARTED = 0x10u,
		[Token(Token = "0x4000884")]
		STOPPED = 0x20u,
		[Token(Token = "0x4000885")]
		START_FAILED = 0x40u,
		[Token(Token = "0x4000886")]
		CREATE_PROGRAMMER_SOUND = 0x80u,
		[Token(Token = "0x4000887")]
		DESTROY_PROGRAMMER_SOUND = 0x100u,
		[Token(Token = "0x4000888")]
		PLUGIN_CREATED = 0x200u,
		[Token(Token = "0x4000889")]
		PLUGIN_DESTROYED = 0x400u,
		[Token(Token = "0x400088A")]
		TIMELINE_MARKER = 0x800u,
		[Token(Token = "0x400088B")]
		TIMELINE_BEAT = 0x1000u,
		[Token(Token = "0x400088C")]
		SOUND_PLAYED = 0x2000u,
		[Token(Token = "0x400088D")]
		SOUND_STOPPED = 0x4000u,
		[Token(Token = "0x400088E")]
		REAL_TO_VIRTUAL = 0x8000u,
		[Token(Token = "0x400088F")]
		VIRTUAL_TO_REAL = 0x10000u,
		[Token(Token = "0x4000890")]
		ALL = uint.MaxValue
	}
	[Token(Token = "0x2000156")]
	public delegate RESULT EVENT_CALLBACK(EVENT_CALLBACK_TYPE type, EventInstance _event, IntPtr parameters);
	[Token(Token = "0x2000157")]
	public delegate RESULT COMMANDREPLAY_FRAME_CALLBACK(CommandReplay replay, int commandindex, float currenttime, IntPtr userdata);
	[Token(Token = "0x2000158")]
	public delegate RESULT COMMANDREPLAY_LOAD_BANK_CALLBACK(CommandReplay replay, int commandindex, Guid bankguid, StringWrapper bankfilename, LOAD_BANK_FLAGS flags, out Bank bank, IntPtr userdata);
	[Token(Token = "0x2000159")]
	public delegate RESULT COMMANDREPLAY_CREATE_INSTANCE_CALLBACK(CommandReplay replay, int commandindex, EventDescription eventdescription, out EventInstance instance, IntPtr userdata);
	[Token(Token = "0x200015A")]
	public enum INSTANCETYPE
	{
		[Token(Token = "0x4000892")]
		NONE,
		[Token(Token = "0x4000893")]
		SYSTEM,
		[Token(Token = "0x4000894")]
		EVENTDESCRIPTION,
		[Token(Token = "0x4000895")]
		EVENTINSTANCE,
		[Token(Token = "0x4000896")]
		PARAMETERINSTANCE,
		[Token(Token = "0x4000897")]
		BUS,
		[Token(Token = "0x4000898")]
		VCA,
		[Token(Token = "0x4000899")]
		BANK,
		[Token(Token = "0x400089A")]
		COMMANDREPLAY
	}
	[Token(Token = "0x200015B")]
	public struct COMMAND_INFO
	{
		[Token(Token = "0x400089B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public StringWrapper commandname;

		[Token(Token = "0x400089C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public int parentcommandindex;

		[Token(Token = "0x400089D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public int framenumber;

		[Token(Token = "0x400089E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float frametime;

		[Token(Token = "0x400089F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public INSTANCETYPE instancetype;

		[Token(Token = "0x40008A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public INSTANCETYPE outputtype;

		[Token(Token = "0x40008A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public uint instancehandle;

		[Token(Token = "0x40008A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public uint outputhandle;
	}
	[Token(Token = "0x200015C")]
	public struct MEMORY_USAGE
	{
		[Token(Token = "0x40008A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int exclusive;

		[Token(Token = "0x40008A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public int inclusive;

		[Token(Token = "0x40008A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public int sampledata;
	}
	[Token(Token = "0x200015D")]
	public struct Util
	{
		[Token(Token = "0x6000984")]
		[Address(RVA = "0x23EE1C0", Offset = "0x23EE1C0", VA = "0x23EE1C0")]
		public static RESULT parseID(string idString, out Guid id)
		{
			return default(RESULT);
		}

		[PreserveSig]
		[Token(Token = "0x6000985")]
		[Address(RVA = "0x23EE308", Offset = "0x23EE308", VA = "0x23EE308")]
		private static extern RESULT FMOD_Studio_ParseID(byte[] idString, out Guid id);
	}
	[Token(Token = "0x200015E")]
	public struct System
	{
		[Token(Token = "0x40008A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public IntPtr handle;

		[Token(Token = "0x6000986")]
		[Address(RVA = "0x3269090", Offset = "0x3269090", VA = "0x3269090")]
		public static RESULT create(out System system)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000987")]
		[Address(RVA = "0x326912C", Offset = "0x326912C", VA = "0x326912C")]
		public RESULT setAdvancedSettings(ADVANCEDSETTINGS settings)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000988")]
		[Address(RVA = "0x3269280", Offset = "0x3269280", VA = "0x3269280")]
		public RESULT setAdvancedSettings(ADVANCEDSETTINGS settings, string encryptionKey)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000989")]
		[Address(RVA = "0x32693EC", Offset = "0x32693EC", VA = "0x32693EC")]
		public RESULT getAdvancedSettings(out ADVANCEDSETTINGS settings)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600098A")]
		[Address(RVA = "0x3269540", Offset = "0x3269540", VA = "0x3269540")]
		public RESULT initialize(int maxchannels, INITFLAGS studioflags, FMOD.INITFLAGS flags, IntPtr extradriverdata)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600098B")]
		[Address(RVA = "0x32695F8", Offset = "0x32695F8", VA = "0x32695F8")]
		public RESULT release()
		{
			return default(RESULT);
		}

		[Token(Token = "0x600098C")]
		[Address(RVA = "0x3269680", Offset = "0x3269680", VA = "0x3269680")]
		public RESULT update()
		{
			return default(RESULT);
		}

		[Token(Token = "0x600098D")]
		[Address(RVA = "0x3269708", Offset = "0x3269708", VA = "0x3269708")]
		public RESULT getCoreSystem(out FMOD.System coresystem)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600098E")]
		[Address(RVA = "0x32697A0", Offset = "0x32697A0", VA = "0x32697A0")]
		public RESULT getEvent(string path, out EventDescription _event)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600098F")]
		[Address(RVA = "0x3269990", Offset = "0x3269990", VA = "0x3269990")]
		public RESULT getBus(string path, out Bus bus)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000990")]
		[Address(RVA = "0x3269B80", Offset = "0x3269B80", VA = "0x3269B80")]
		public RESULT getVCA(string path, out VCA vca)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000991")]
		[Address(RVA = "0x3269D70", Offset = "0x3269D70", VA = "0x3269D70")]
		public RESULT getBank(string path, out Bank bank)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000992")]
		[Address(RVA = "0x3269F60", Offset = "0x3269F60", VA = "0x3269F60")]
		public RESULT getEventByID(Guid id, out EventDescription _event)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000993")]
		[Address(RVA = "0x326A024", Offset = "0x326A024", VA = "0x326A024")]
		public RESULT getBusByID(Guid id, out Bus bus)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000994")]
		[Address(RVA = "0x326A0E8", Offset = "0x326A0E8", VA = "0x326A0E8")]
		public RESULT getVCAByID(Guid id, out VCA vca)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000995")]
		[Address(RVA = "0x326A1AC", Offset = "0x326A1AC", VA = "0x326A1AC")]
		public RESULT getBankByID(Guid id, out Bank bank)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000996")]
		[Address(RVA = "0x326A270", Offset = "0x326A270", VA = "0x326A270")]
		public RESULT getSoundInfo(string key, out SOUND_INFO info)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000997")]
		[Address(RVA = "0x326A504", Offset = "0x326A504", VA = "0x326A504")]
		public RESULT getParameterDescriptionByName(string name, out PARAMETER_DESCRIPTION parameter)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000998")]
		[Address(RVA = "0x326A6F4", Offset = "0x326A6F4", VA = "0x326A6F4")]
		public RESULT getParameterDescriptionByID(PARAMETER_ID id, out PARAMETER_DESCRIPTION parameter)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000999")]
		[Address(RVA = "0x326A794", Offset = "0x326A794", VA = "0x326A794")]
		public RESULT getParameterByID(PARAMETER_ID id, out float value)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600099A")]
		[Address(RVA = "0x326A7BC", Offset = "0x326A7BC", VA = "0x326A7BC")]
		public RESULT getParameterByID(PARAMETER_ID id, out float value, out float finalvalue)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600099B")]
		[Address(RVA = "0x326A86C", Offset = "0x326A86C", VA = "0x326A86C")]
		public RESULT setParameterByID(PARAMETER_ID id, float value, bool ignoreseekspeed = false)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600099C")]
		[Address(RVA = "0x326A920", Offset = "0x326A920", VA = "0x326A920")]
		public RESULT setParametersByIDs(PARAMETER_ID[] ids, float[] values, int count, bool ignoreseekspeed = false)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600099D")]
		[Address(RVA = "0x326A9EC", Offset = "0x326A9EC", VA = "0x326A9EC")]
		public RESULT getParameterByName(string name, out float value)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600099E")]
		[Address(RVA = "0x326AB70", Offset = "0x326AB70", VA = "0x326AB70")]
		public RESULT getParameterByName(IntPtr name, out float value)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600099F")]
		[Address(RVA = "0x326AA10", Offset = "0x326AA10", VA = "0x326AA10")]
		public RESULT getParameterByName(string name, out float value, out float finalvalue)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60009A0")]
		[Address(RVA = "0x326AB98", Offset = "0x326AB98", VA = "0x326AB98")]
		public RESULT getParameterByName(IntPtr name, out float value, out float finalvalue)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60009A1")]
		[Address(RVA = "0x326ACF8", Offset = "0x326ACF8", VA = "0x326ACF8")]
		public RESULT setParameterByName(string name, float value, bool ignoreseekspeed = false)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60009A2")]
		[Address(RVA = "0x326AF08", Offset = "0x326AF08", VA = "0x326AF08")]
		public RESULT setParameterByName(IntPtr name, float value, bool ignoreseekspeed = false)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60009A3")]
		[Address(RVA = "0x326AFBC", Offset = "0x326AFBC", VA = "0x326AFBC")]
		public RESULT lookupID(string path, out Guid id)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60009A4")]
		[Address(RVA = "0x326B1AC", Offset = "0x326B1AC", VA = "0x326B1AC")]
		public RESULT lookupPath(Guid id, out string path)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60009A5")]
		[Address(RVA = "0x326B4A0", Offset = "0x326B4A0", VA = "0x326B4A0")]
		public RESULT getNumListeners(out int numlisteners)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60009A6")]
		[Address(RVA = "0x326B538", Offset = "0x326B538", VA = "0x326B538")]
		public RESULT setNumListeners(int numlisteners)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60009A7")]
		[Address(RVA = "0x326B5D0", Offset = "0x326B5D0", VA = "0x326B5D0")]
		public RESULT getListenerAttributes(int listener, out ATTRIBUTES_3D attributes)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60009A8")]
		[Address(RVA = "0x326B670", Offset = "0x326B670", VA = "0x326B670")]
		public RESULT setListenerAttributes(int listener, ATTRIBUTES_3D attributes)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60009A9")]
		[Address(RVA = "0x326B710", Offset = "0x326B710", VA = "0x326B710")]
		public RESULT getListenerWeight(int listener, out float weight)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60009AA")]
		[Address(RVA = "0x326B7B0", Offset = "0x326B7B0", VA = "0x326B7B0")]
		public RESULT setListenerWeight(int listener, float weight)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60009AB")]
		[Address(RVA = "0x326B858", Offset = "0x326B858", VA = "0x326B858")]
		public RESULT loadBankFile(string filename, LOAD_BANK_FLAGS flags, out Bank bank)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60009AC")]
		[Address(RVA = "0x326BA68", Offset = "0x326BA68", VA = "0x326BA68")]
		public RESULT loadBankMemory(byte[] buffer, LOAD_BANK_FLAGS flags, out Bank bank)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60009AD")]
		[Address(RVA = "0x326BBB8", Offset = "0x326BBB8", VA = "0x326BBB8")]
		public RESULT loadBankCustom(BANK_INFO info, LOAD_BANK_FLAGS flags, out Bank bank)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60009AE")]
		[Address(RVA = "0x326BD9C", Offset = "0x326BD9C", VA = "0x326BD9C")]
		public RESULT unloadAll()
		{
			return default(RESULT);
		}

		[Token(Token = "0x60009AF")]
		[Address(RVA = "0x326BE24", Offset = "0x326BE24", VA = "0x326BE24")]
		public RESULT flushCommands()
		{
			return default(RESULT);
		}

		[Token(Token = "0x60009B0")]
		[Address(RVA = "0x326BEAC", Offset = "0x326BEAC", VA = "0x326BEAC")]
		public RESULT flushSampleLoading()
		{
			return default(RESULT);
		}

		[Token(Token = "0x60009B1")]
		[Address(RVA = "0x326BF34", Offset = "0x326BF34", VA = "0x326BF34")]
		public RESULT startCommandCapture(string filename, COMMANDCAPTURE_FLAGS flags)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60009B2")]
		[Address(RVA = "0x326C124", Offset = "0x326C124", VA = "0x326C124")]
		public RESULT stopCommandCapture()
		{
			return default(RESULT);
		}

		[Token(Token = "0x60009B3")]
		[Address(RVA = "0x326C1AC", Offset = "0x326C1AC", VA = "0x326C1AC")]
		public RESULT loadCommandReplay(string filename, COMMANDREPLAY_FLAGS flags, out CommandReplay replay)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60009B4")]
		[Address(RVA = "0x326C3BC", Offset = "0x326C3BC", VA = "0x326C3BC")]
		public RESULT getBankCount(out int count)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60009B5")]
		[Address(RVA = "0x326C454", Offset = "0x326C454", VA = "0x326C454")]
		public RESULT getBankList(out Bank[] array)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60009B6")]
		[Address(RVA = "0x326C654", Offset = "0x326C654", VA = "0x326C654")]
		public RESULT getParameterDescriptionCount(out int count)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60009B7")]
		[Address(RVA = "0x326C6EC", Offset = "0x326C6EC", VA = "0x326C6EC")]
		public RESULT getParameterDescriptionList(out PARAMETER_DESCRIPTION[] array)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60009B8")]
		[Address(RVA = "0x326C930", Offset = "0x326C930", VA = "0x326C930")]
		public RESULT getCPUUsage(out CPU_USAGE usage)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60009B9")]
		[Address(RVA = "0x326C9C8", Offset = "0x326C9C8", VA = "0x326C9C8")]
		public RESULT getBufferUsage(out BUFFER_USAGE usage)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60009BA")]
		[Address(RVA = "0x326CA60", Offset = "0x326CA60", VA = "0x326CA60")]
		public RESULT resetBufferUsage()
		{
			return default(RESULT);
		}

		[Token(Token = "0x60009BB")]
		[Address(RVA = "0x326CAE8", Offset = "0x326CAE8", VA = "0x326CAE8")]
		public RESULT setCallback(SYSTEM_CALLBACK callback, SYSTEM_CALLBACK_TYPE callbackmask = SYSTEM_CALLBACK_TYPE.ALL)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60009BC")]
		[Address(RVA = "0x326CB90", Offset = "0x326CB90", VA = "0x326CB90")]
		public RESULT getUserData(out IntPtr userdata)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60009BD")]
		[Address(RVA = "0x326CC28", Offset = "0x326CC28", VA = "0x326CC28")]
		public RESULT setUserData(IntPtr userdata)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60009BE")]
		[Address(RVA = "0x326CCC0", Offset = "0x326CCC0", VA = "0x326CCC0")]
		public RESULT getMemoryUsage(out MEMORY_USAGE memoryusage)
		{
			return default(RESULT);
		}

		[PreserveSig]
		[Token(Token = "0x60009BF")]
		[Address(RVA = "0x326909C", Offset = "0x326909C", VA = "0x326909C")]
		private static extern RESULT FMOD_Studio_System_Create(out IntPtr system, uint headerversion);

		[PreserveSig]
		[Token(Token = "0x60009C0")]
		[Address(RVA = "0x326CD58", Offset = "0x326CD58", VA = "0x326CD58")]
		private static extern bool FMOD_Studio_System_IsValid(IntPtr system);

		[PreserveSig]
		[Token(Token = "0x60009C1")]
		[Address(RVA = "0x32691F0", Offset = "0x32691F0", VA = "0x32691F0")]
		private static extern RESULT FMOD_Studio_System_SetAdvancedSettings(IntPtr system, ref ADVANCEDSETTINGS settings);

		[PreserveSig]
		[Token(Token = "0x60009C2")]
		[Address(RVA = "0x32694B0", Offset = "0x32694B0", VA = "0x32694B0")]
		private static extern RESULT FMOD_Studio_System_GetAdvancedSettings(IntPtr system, out ADVANCEDSETTINGS settings);

		[PreserveSig]
		[Token(Token = "0x60009C3")]
		[Address(RVA = "0x3269548", Offset = "0x3269548", VA = "0x3269548")]
		private static extern RESULT FMOD_Studio_System_Initialize(IntPtr system, int maxchannels, INITFLAGS studioflags, FMOD.INITFLAGS flags, IntPtr extradriverdata);

		[PreserveSig]
		[Token(Token = "0x60009C4")]
		[Address(RVA = "0x3269600", Offset = "0x3269600", VA = "0x3269600")]
		private static extern RESULT FMOD_Studio_System_Release(IntPtr system);

		[PreserveSig]
		[Token(Token = "0x60009C5")]
		[Address(RVA = "0x3269688", Offset = "0x3269688", VA = "0x3269688")]
		private static extern RESULT FMOD_Studio_System_Update(IntPtr system);

		[PreserveSig]
		[Token(Token = "0x60009C6")]
		[Address(RVA = "0x3269710", Offset = "0x3269710", VA = "0x3269710")]
		private static extern RESULT FMOD_Studio_System_GetCoreSystem(IntPtr system, out IntPtr coresystem);

		[PreserveSig]
		[Token(Token = "0x60009C7")]
		[Address(RVA = "0x32698F0", Offset = "0x32698F0", VA = "0x32698F0")]
		private static extern RESULT FMOD_Studio_System_GetEvent(IntPtr system, byte[] path, out IntPtr _event);

		[PreserveSig]
		[Token(Token = "0x60009C8")]
		[Address(RVA = "0x3269AE0", Offset = "0x3269AE0", VA = "0x3269AE0")]
		private static extern RESULT FMOD_Studio_System_GetBus(IntPtr system, byte[] path, out IntPtr bus);

		[PreserveSig]
		[Token(Token = "0x60009C9")]
		[Address(RVA = "0x3269CD0", Offset = "0x3269CD0", VA = "0x3269CD0")]
		private static extern RESULT FMOD_Studio_System_GetVCA(IntPtr system, byte[] path, out IntPtr vca);

		[PreserveSig]
		[Token(Token = "0x60009CA")]
		[Address(RVA = "0x3269EC0", Offset = "0x3269EC0", VA = "0x3269EC0")]
		private static extern RESULT FMOD_Studio_System_GetBank(IntPtr system, byte[] path, out IntPtr bank);

		[PreserveSig]
		[Token(Token = "0x60009CB")]
		[Address(RVA = "0x3269F8C", Offset = "0x3269F8C", VA = "0x3269F8C")]
		private static extern RESULT FMOD_Studio_System_GetEventByID(IntPtr system, ref Guid id, out IntPtr _event);

		[PreserveSig]
		[Token(Token = "0x60009CC")]
		[Address(RVA = "0x326A050", Offset = "0x326A050", VA = "0x326A050")]
		private static extern RESULT FMOD_Studio_System_GetBusByID(IntPtr system, ref Guid id, out IntPtr bus);

		[PreserveSig]
		[Token(Token = "0x60009CD")]
		[Address(RVA = "0x326A114", Offset = "0x326A114", VA = "0x326A114")]
		private static extern RESULT FMOD_Studio_System_GetVCAByID(IntPtr system, ref Guid id, out IntPtr vca);

		[PreserveSig]
		[Token(Token = "0x60009CE")]
		[Address(RVA = "0x326A1D8", Offset = "0x326A1D8", VA = "0x326A1D8")]
		private static extern RESULT FMOD_Studio_System_GetBankByID(IntPtr system, ref Guid id, out IntPtr bank);

		[PreserveSig]
		[Token(Token = "0x60009CF")]
		[Address(RVA = "0x326A3C0", Offset = "0x326A3C0", VA = "0x326A3C0")]
		private static extern RESULT FMOD_Studio_System_GetSoundInfo(IntPtr system, byte[] key, out SOUND_INFO info);

		[PreserveSig]
		[Token(Token = "0x60009D0")]
		[Address(RVA = "0x326A654", Offset = "0x326A654", VA = "0x326A654")]
		private static extern RESULT FMOD_Studio_System_GetParameterDescriptionByName(IntPtr system, byte[] name, out PARAMETER_DESCRIPTION parameter);

		[PreserveSig]
		[Token(Token = "0x60009D1")]
		[Address(RVA = "0x326A6FC", Offset = "0x326A6FC", VA = "0x326A6FC")]
		private static extern RESULT FMOD_Studio_System_GetParameterDescriptionByID(IntPtr system, ulong id, out PARAMETER_DESCRIPTION parameter);

		[PreserveSig]
		[Token(Token = "0x60009D2")]
		[Address(RVA = "0x326A7C4", Offset = "0x326A7C4", VA = "0x326A7C4")]
		private static extern RESULT FMOD_Studio_System_GetParameterByID(IntPtr system, ulong id, out float value, out float finalvalue);

		[PreserveSig]
		[Token(Token = "0x60009D3")]
		[Address(RVA = "0x326A878", Offset = "0x326A878", VA = "0x326A878")]
		private static extern RESULT FMOD_Studio_System_SetParameterByID(IntPtr system, ulong id, float value, bool ignoreseekspeed);

		[PreserveSig]
		[Token(Token = "0x60009D4")]
		[Address(RVA = "0x326A92C", Offset = "0x326A92C", VA = "0x326A92C")]
		private static extern RESULT FMOD_Studio_System_SetParametersByIDs(IntPtr system, PARAMETER_ID[] ids, float[] values, int count, bool ignoreseekspeed);

		[PreserveSig]
		[Token(Token = "0x60009D5")]
		[Address(RVA = "0x326ABA0", Offset = "0x326ABA0", VA = "0x326ABA0")]
		private static extern RESULT FMOD_Studio_System_GetParameterByName(IntPtr system, byte[] name, out float value, out float finalvalue);

		[PreserveSig]
		[Token(Token = "0x60009D6")]
		[Address(RVA = "0x326AC50", Offset = "0x326AC50", VA = "0x326AC50")]
		private static extern RESULT FMOD_Studio_System_GetParameterByName(IntPtr system, IntPtr name, out float value, out float finalvalue);

		[PreserveSig]
		[Token(Token = "0x60009D7")]
		[Address(RVA = "0x326AE58", Offset = "0x326AE58", VA = "0x326AE58")]
		private static extern RESULT FMOD_Studio_System_SetParameterByName(IntPtr system, byte[] name, float value, bool ignoreseekspeed);

		[PreserveSig]
		[Token(Token = "0x60009D8")]
		[Address(RVA = "0x326AF14", Offset = "0x326AF14", VA = "0x326AF14")]
		private static extern RESULT FMOD_Studio_System_SetParameterByName(IntPtr system, IntPtr name, float value, bool ignoreseekspeed);

		[PreserveSig]
		[Token(Token = "0x60009D9")]
		[Address(RVA = "0x326B10C", Offset = "0x326B10C", VA = "0x326B10C")]
		private static extern RESULT FMOD_Studio_System_LookupID(IntPtr system, byte[] path, out Guid id);

		[PreserveSig]
		[Token(Token = "0x60009DA")]
		[Address(RVA = "0x326B3F0", Offset = "0x326B3F0", VA = "0x326B3F0")]
		private static extern RESULT FMOD_Studio_System_LookupPath(IntPtr system, ref Guid id, IntPtr path, int size, out int retrieved);

		[PreserveSig]
		[Token(Token = "0x60009DB")]
		[Address(RVA = "0x326B4A8", Offset = "0x326B4A8", VA = "0x326B4A8")]
		private static extern RESULT FMOD_Studio_System_GetNumListeners(IntPtr system, out int numlisteners);

		[PreserveSig]
		[Token(Token = "0x60009DC")]
		[Address(RVA = "0x326B540", Offset = "0x326B540", VA = "0x326B540")]
		private static extern RESULT FMOD_Studio_System_SetNumListeners(IntPtr system, int numlisteners);

		[PreserveSig]
		[Token(Token = "0x60009DD")]
		[Address(RVA = "0x326B5D8", Offset = "0x326B5D8", VA = "0x326B5D8")]
		private static extern RESULT FMOD_Studio_System_GetListenerAttributes(IntPtr system, int listener, out ATTRIBUTES_3D attributes);

		[PreserveSig]
		[Token(Token = "0x60009DE")]
		[Address(RVA = "0x326B678", Offset = "0x326B678", VA = "0x326B678")]
		private static extern RESULT FMOD_Studio_System_SetListenerAttributes(IntPtr system, int listener, ref ATTRIBUTES_3D attributes);

		[PreserveSig]
		[Token(Token = "0x60009DF")]
		[Address(RVA = "0x326B718", Offset = "0x326B718", VA = "0x326B718")]
		private static extern RESULT FMOD_Studio_System_GetListenerWeight(IntPtr system, int listener, out float weight);

		[PreserveSig]
		[Token(Token = "0x60009E0")]
		[Address(RVA = "0x326B7B8", Offset = "0x326B7B8", VA = "0x326B7B8")]
		private static extern RESULT FMOD_Studio_System_SetListenerWeight(IntPtr system, int listener, float weight);

		[PreserveSig]
		[Token(Token = "0x60009E1")]
		[Address(RVA = "0x326B9B8", Offset = "0x326B9B8", VA = "0x326B9B8")]
		private static extern RESULT FMOD_Studio_System_LoadBankFile(IntPtr system, byte[] filename, LOAD_BANK_FLAGS flags, out IntPtr bank);

		[PreserveSig]
		[Token(Token = "0x60009E2")]
		[Address(RVA = "0x326BAF8", Offset = "0x326BAF8", VA = "0x326BAF8")]
		private static extern RESULT FMOD_Studio_System_LoadBankMemory(IntPtr system, IntPtr buffer, int length, LOAD_MEMORY_MODE mode, LOAD_BANK_FLAGS flags, out IntPtr bank);

		[PreserveSig]
		[Token(Token = "0x60009E3")]
		[Address(RVA = "0x326BC98", Offset = "0x326BC98", VA = "0x326BC98")]
		private static extern RESULT FMOD_Studio_System_LoadBankCustom(IntPtr system, ref BANK_INFO info, LOAD_BANK_FLAGS flags, out IntPtr bank);

		[PreserveSig]
		[Token(Token = "0x60009E4")]
		[Address(RVA = "0x326BDA4", Offset = "0x326BDA4", VA = "0x326BDA4")]
		private static extern RESULT FMOD_Studio_System_UnloadAll(IntPtr system);

		[PreserveSig]
		[Token(Token = "0x60009E5")]
		[Address(RVA = "0x326BE2C", Offset = "0x326BE2C", VA = "0x326BE2C")]
		private static extern RESULT FMOD_Studio_System_FlushCommands(IntPtr system);

		[PreserveSig]
		[Token(Token = "0x60009E6")]
		[Address(RVA = "0x326BEB4", Offset = "0x326BEB4", VA = "0x326BEB4")]
		private static extern RESULT FMOD_Studio_System_FlushSampleLoading(IntPtr system);

		[PreserveSig]
		[Token(Token = "0x60009E7")]
		[Address(RVA = "0x326C084", Offset = "0x326C084", VA = "0x326C084")]
		private static extern RESULT FMOD_Studio_System_StartCommandCapture(IntPtr system, byte[] filename, COMMANDCAPTURE_FLAGS flags);

		[PreserveSig]
		[Token(Token = "0x60009E8")]
		[Address(RVA = "0x326C12C", Offset = "0x326C12C", VA = "0x326C12C")]
		private static extern RESULT FMOD_Studio_System_StopCommandCapture(IntPtr system);

		[PreserveSig]
		[Token(Token = "0x60009E9")]
		[Address(RVA = "0x326C30C", Offset = "0x326C30C", VA = "0x326C30C")]
		private static extern RESULT FMOD_Studio_System_LoadCommandReplay(IntPtr system, byte[] filename, COMMANDREPLAY_FLAGS flags, out IntPtr replay);

		[PreserveSig]
		[Token(Token = "0x60009EA")]
		[Address(RVA = "0x326C3C4", Offset = "0x326C3C4", VA = "0x326C3C4")]
		private static extern RESULT FMOD_Studio_System_GetBankCount(IntPtr system, out int count);

		[PreserveSig]
		[Token(Token = "0x60009EB")]
		[Address(RVA = "0x326C5A4", Offset = "0x326C5A4", VA = "0x326C5A4")]
		private static extern RESULT FMOD_Studio_System_GetBankList(IntPtr system, IntPtr[] array, int capacity, out int count);

		[PreserveSig]
		[Token(Token = "0x60009EC")]
		[Address(RVA = "0x326C65C", Offset = "0x326C65C", VA = "0x326C65C")]
		private static extern RESULT FMOD_Studio_System_GetParameterDescriptionCount(IntPtr system, out int count);

		[PreserveSig]
		[Token(Token = "0x60009ED")]
		[Address(RVA = "0x326C7E0", Offset = "0x326C7E0", VA = "0x326C7E0")]
		private static extern RESULT FMOD_Studio_System_GetParameterDescriptionList(IntPtr system, [Out] PARAMETER_DESCRIPTION[] array, int capacity, out int count);

		[PreserveSig]
		[Token(Token = "0x60009EE")]
		[Address(RVA = "0x326C938", Offset = "0x326C938", VA = "0x326C938")]
		private static extern RESULT FMOD_Studio_System_GetCPUUsage(IntPtr system, out CPU_USAGE usage);

		[PreserveSig]
		[Token(Token = "0x60009EF")]
		[Address(RVA = "0x326C9D0", Offset = "0x326C9D0", VA = "0x326C9D0")]
		private static extern RESULT FMOD_Studio_System_GetBufferUsage(IntPtr system, out BUFFER_USAGE usage);

		[PreserveSig]
		[Token(Token = "0x60009F0")]
		[Address(RVA = "0x326CA68", Offset = "0x326CA68", VA = "0x326CA68")]
		private static extern RESULT FMOD_Studio_System_ResetBufferUsage(IntPtr system);

		[PreserveSig]
		[Token(Token = "0x60009F1")]
		[Address(RVA = "0x326CAF0", Offset = "0x326CAF0", VA = "0x326CAF0")]
		private static extern RESULT FMOD_Studio_System_SetCallback(IntPtr system, SYSTEM_CALLBACK callback, SYSTEM_CALLBACK_TYPE callbackmask);

		[PreserveSig]
		[Token(Token = "0x60009F2")]
		[Address(RVA = "0x326CB98", Offset = "0x326CB98", VA = "0x326CB98")]
		private static extern RESULT FMOD_Studio_System_GetUserData(IntPtr system, out IntPtr userdata);

		[PreserveSig]
		[Token(Token = "0x60009F3")]
		[Address(RVA = "0x326CC30", Offset = "0x326CC30", VA = "0x326CC30")]
		private static extern RESULT FMOD_Studio_System_SetUserData(IntPtr system, IntPtr userdata);

		[PreserveSig]
		[Token(Token = "0x60009F4")]
		[Address(RVA = "0x326CCC8", Offset = "0x326CCC8", VA = "0x326CCC8")]
		private static extern RESULT FMOD_Studio_System_GetMemoryUsage(IntPtr system, out MEMORY_USAGE memoryusage);

		[Token(Token = "0x60009F5")]
		[Address(RVA = "0x326CDE0", Offset = "0x326CDE0", VA = "0x326CDE0")]
		public bool hasHandle()
		{
			return default(bool);
		}

		[Token(Token = "0x60009F6")]
		[Address(RVA = "0x326CE2C", Offset = "0x326CE2C", VA = "0x326CE2C")]
		public void clearHandle()
		{
		}

		[Token(Token = "0x60009F7")]
		[Address(RVA = "0x326CE70", Offset = "0x326CE70", VA = "0x326CE70")]
		public bool isValid()
		{
			return default(bool);
		}
	}
	[Token(Token = "0x200015F")]
	public struct EventDescription
	{
		[Token(Token = "0x40008A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public IntPtr handle;

		[Token(Token = "0x60009F8")]
		[Address(RVA = "0x3265534", Offset = "0x3265534", VA = "0x3265534")]
		public RESULT getID(out Guid id)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60009F9")]
		[Address(RVA = "0x32655CC", Offset = "0x32655CC", VA = "0x32655CC")]
		public RESULT getPath(out string path)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60009FA")]
		[Address(RVA = "0x32658AC", Offset = "0x32658AC", VA = "0x32658AC")]
		public RESULT getParameterDescriptionCount(out int count)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60009FB")]
		[Address(RVA = "0x3265944", Offset = "0x3265944", VA = "0x3265944")]
		public RESULT getParameterDescriptionByIndex(int index, out PARAMETER_DESCRIPTION parameter)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60009FC")]
		[Address(RVA = "0x32659E4", Offset = "0x32659E4", VA = "0x32659E4")]
		public RESULT getParameterDescriptionByName(string name, out PARAMETER_DESCRIPTION parameter)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60009FD")]
		[Address(RVA = "0x3265BD4", Offset = "0x3265BD4", VA = "0x3265BD4")]
		public RESULT getParameterDescriptionByName(IntPtr name, out PARAMETER_DESCRIPTION parameter)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60009FE")]
		[Address(RVA = "0x3265C74", Offset = "0x3265C74", VA = "0x3265C74")]
		public RESULT getParameterDescriptionByID(PARAMETER_ID id, out PARAMETER_DESCRIPTION parameter)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60009FF")]
		[Address(RVA = "0x3265D14", Offset = "0x3265D14", VA = "0x3265D14")]
		public RESULT getUserPropertyCount(out int count)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000A00")]
		[Address(RVA = "0x3265DAC", Offset = "0x3265DAC", VA = "0x3265DAC")]
		public RESULT getUserPropertyByIndex(int index, out USER_PROPERTY property)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000A01")]
		[Address(RVA = "0x3265E98", Offset = "0x3265E98", VA = "0x3265E98")]
		public RESULT getUserProperty(string name, out USER_PROPERTY property)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000A02")]
		[Address(RVA = "0x32660D4", Offset = "0x32660D4", VA = "0x32660D4")]
		public RESULT getUserProperty(IntPtr name, out USER_PROPERTY property)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000A03")]
		[Address(RVA = "0x32661C0", Offset = "0x32661C0", VA = "0x32661C0")]
		public RESULT getLength(out int length)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000A04")]
		[Address(RVA = "0x3266258", Offset = "0x3266258", VA = "0x3266258")]
		public RESULT getMinimumDistance(out float distance)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000A05")]
		[Address(RVA = "0x32662F0", Offset = "0x32662F0", VA = "0x32662F0")]
		public RESULT getMaximumDistance(out float distance)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000A06")]
		[Address(RVA = "0x3266388", Offset = "0x3266388", VA = "0x3266388")]
		public RESULT getSoundSize(out float size)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000A07")]
		[Address(RVA = "0x3266420", Offset = "0x3266420", VA = "0x3266420")]
		public RESULT isSnapshot(out bool snapshot)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000A08")]
		[Address(RVA = "0x32664CC", Offset = "0x32664CC", VA = "0x32664CC")]
		public RESULT isOneshot(out bool oneshot)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000A09")]
		[Address(RVA = "0x3266578", Offset = "0x3266578", VA = "0x3266578")]
		public RESULT isStream(out bool isStream)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000A0A")]
		[Address(RVA = "0x3266624", Offset = "0x3266624", VA = "0x3266624")]
		public RESULT is3D(out bool is3D)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000A0B")]
		[Address(RVA = "0x32666D0", Offset = "0x32666D0", VA = "0x32666D0")]
		public RESULT hasCue(out bool cue)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000A0C")]
		[Address(RVA = "0x326677C", Offset = "0x326677C", VA = "0x326677C")]
		public RESULT createInstance(out EventInstance instance)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000A0D")]
		[Address(RVA = "0x3266814", Offset = "0x3266814", VA = "0x3266814")]
		public RESULT getInstanceCount(out int count)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000A0E")]
		[Address(RVA = "0x32668AC", Offset = "0x32668AC", VA = "0x32668AC")]
		public RESULT getInstanceList(out EventInstance[] array)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000A0F")]
		[Address(RVA = "0x3266AAC", Offset = "0x3266AAC", VA = "0x3266AAC")]
		public RESULT loadSampleData()
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000A10")]
		[Address(RVA = "0x3266B34", Offset = "0x3266B34", VA = "0x3266B34")]
		public RESULT unloadSampleData()
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000A11")]
		[Address(RVA = "0x3266BBC", Offset = "0x3266BBC", VA = "0x3266BBC")]
		public RESULT getSampleLoadingState(out LOADING_STATE state)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000A12")]
		[Address(RVA = "0x3266C54", Offset = "0x3266C54", VA = "0x3266C54")]
		public RESULT releaseAllInstances()
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000A13")]
		[Address(RVA = "0x3266CDC", Offset = "0x3266CDC", VA = "0x3266CDC")]
		public RESULT setCallback(EVENT_CALLBACK callback, EVENT_CALLBACK_TYPE callbackmask = EVENT_CALLBACK_TYPE.ALL)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000A14")]
		[Address(RVA = "0x3266D84", Offset = "0x3266D84", VA = "0x3266D84")]
		public RESULT getUserData(out IntPtr userdata)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000A15")]
		[Address(RVA = "0x3266E1C", Offset = "0x3266E1C", VA = "0x3266E1C")]
		public RESULT setUserData(IntPtr userdata)
		{
			return default(RESULT);
		}

		[PreserveSig]
		[Token(Token = "0x6000A16")]
		[Address(RVA = "0x3266EB4", Offset = "0x3266EB4", VA = "0x3266EB4")]
		private static extern bool FMOD_Studio_EventDescription_IsValid(IntPtr eventdescription);

		[PreserveSig]
		[Token(Token = "0x6000A17")]
		[Address(RVA = "0x326553C", Offset = "0x326553C", VA = "0x326553C")]
		private static extern RESULT FMOD_Studio_EventDescription_GetID(IntPtr eventdescription, out Guid id);

		[PreserveSig]
		[Token(Token = "0x6000A18")]
		[Address(RVA = "0x3265804", Offset = "0x3265804", VA = "0x3265804")]
		private static extern RESULT FMOD_Studio_EventDescription_GetPath(IntPtr eventdescription, IntPtr path, int size, out int retrieved);

		[PreserveSig]
		[Token(Token = "0x6000A19")]
		[Address(RVA = "0x32658B4", Offset = "0x32658B4", VA = "0x32658B4")]
		private static extern RESULT FMOD_Studio_EventDescription_GetParameterDescriptionCount(IntPtr eventdescription, out int count);

		[PreserveSig]
		[Token(Token = "0x6000A1A")]
		[Address(RVA = "0x326594C", Offset = "0x326594C", VA = "0x326594C")]
		private static extern RESULT FMOD_Studio_EventDescription_GetParameterDescriptionByIndex(IntPtr eventdescription, int index, out PARAMETER_DESCRIPTION parameter);

		[PreserveSig]
		[Token(Token = "0x6000A1B")]
		[Address(RVA = "0x3265B34", Offset = "0x3265B34", VA = "0x3265B34")]
		private static extern RESULT FMOD_Studio_EventDescription_GetParameterDescriptionByName(IntPtr eventdescription, byte[] name, out PARAMETER_DESCRIPTION parameter);

		[PreserveSig]
		[Token(Token = "0x6000A1C")]
		[Address(RVA = "0x3265BDC", Offset = "0x3265BDC", VA = "0x3265BDC")]
		private static extern RESULT FMOD_Studio_EventDescription_GetParameterDescriptionByName(IntPtr eventdescription, IntPtr name, out PARAMETER_DESCRIPTION parameter);

		[PreserveSig]
		[Token(Token = "0x6000A1D")]
		[Address(RVA = "0x3265C7C", Offset = "0x3265C7C", VA = "0x3265C7C")]
		private static extern RESULT FMOD_Studio_EventDescription_GetParameterDescriptionByID(IntPtr eventdescription, ulong id, out PARAMETER_DESCRIPTION parameter);

		[PreserveSig]
		[Token(Token = "0x6000A1E")]
		[Address(RVA = "0x3265D1C", Offset = "0x3265D1C", VA = "0x3265D1C")]
		private static extern RESULT FMOD_Studio_EventDescription_GetUserPropertyCount(IntPtr eventdescription, out int count);

		[PreserveSig]
		[Token(Token = "0x6000A1F")]
		[Address(RVA = "0x3265DB4", Offset = "0x3265DB4", VA = "0x3265DB4")]
		private static extern RESULT FMOD_Studio_EventDescription_GetUserPropertyByIndex(IntPtr eventdescription, int index, out USER_PROPERTY property);

		[PreserveSig]
		[Token(Token = "0x6000A20")]
		[Address(RVA = "0x3265FE8", Offset = "0x3265FE8", VA = "0x3265FE8")]
		private static extern RESULT FMOD_Studio_EventDescription_GetUserProperty(IntPtr eventdescription, byte[] name, out USER_PROPERTY property);

		[PreserveSig]
		[Token(Token = "0x6000A21")]
		[Address(RVA = "0x32660DC", Offset = "0x32660DC", VA = "0x32660DC")]
		private static extern RESULT FMOD_Studio_EventDescription_GetUserProperty(IntPtr eventdescription, IntPtr name, out USER_PROPERTY property);

		[PreserveSig]
		[Token(Token = "0x6000A22")]
		[Address(RVA = "0x32661C8", Offset = "0x32661C8", VA = "0x32661C8")]
		private static extern RESULT FMOD_Studio_EventDescription_GetLength(IntPtr eventdescription, out int length);

		[PreserveSig]
		[Token(Token = "0x6000A23")]
		[Address(RVA = "0x3266260", Offset = "0x3266260", VA = "0x3266260")]
		private static extern RESULT FMOD_Studio_EventDescription_GetMinimumDistance(IntPtr eventdescription, out float distance);

		[PreserveSig]
		[Token(Token = "0x6000A24")]
		[Address(RVA = "0x32662F8", Offset = "0x32662F8", VA = "0x32662F8")]
		private static extern RESULT FMOD_Studio_EventDescription_GetMaximumDistance(IntPtr eventdescription, out float distance);

		[PreserveSig]
		[Token(Token = "0x6000A25")]
		[Address(RVA = "0x3266390", Offset = "0x3266390", VA = "0x3266390")]
		private static extern RESULT FMOD_Studio_EventDescription_GetSoundSize(IntPtr eventdescription, out float size);

		[PreserveSig]
		[Token(Token = "0x6000A26")]
		[Address(RVA = "0x3266428", Offset = "0x3266428", VA = "0x3266428")]
		private static extern RESULT FMOD_Studio_EventDescription_IsSnapshot(IntPtr eventdescription, out bool snapshot);

		[PreserveSig]
		[Token(Token = "0x6000A27")]
		[Address(RVA = "0x32664D4", Offset = "0x32664D4", VA = "0x32664D4")]
		private static extern RESULT FMOD_Studio_EventDescription_IsOneshot(IntPtr eventdescription, out bool oneshot);

		[PreserveSig]
		[Token(Token = "0x6000A28")]
		[Address(RVA = "0x3266580", Offset = "0x3266580", VA = "0x3266580")]
		private static extern RESULT FMOD_Studio_EventDescription_IsStream(IntPtr eventdescription, out bool isStream);

		[PreserveSig]
		[Token(Token = "0x6000A29")]
		[Address(RVA = "0x326662C", Offset = "0x326662C", VA = "0x326662C")]
		private static extern RESULT FMOD_Studio_EventDescription_Is3D(IntPtr eventdescription, out bool is3D);

		[PreserveSig]
		[Token(Token = "0x6000A2A")]
		[Address(RVA = "0x32666D8", Offset = "0x32666D8", VA = "0x32666D8")]
		private static extern RESULT FMOD_Studio_EventDescription_HasCue(IntPtr eventdescription, out bool cue);

		[PreserveSig]
		[Token(Token = "0x6000A2B")]
		[Address(RVA = "0x3266784", Offset = "0x3266784", VA = "0x3266784")]
		private static extern RESULT FMOD_Studio_EventDescription_CreateInstance(IntPtr eventdescription, out IntPtr instance);

		[PreserveSig]
		[Token(Token = "0x6000A2C")]
		[Address(RVA = "0x326681C", Offset = "0x326681C", VA = "0x326681C")]
		private static extern RESULT FMOD_Studio_EventDescription_GetInstanceCount(IntPtr eventdescription, out int count);

		[PreserveSig]
		[Token(Token = "0x6000A2D")]
		[Address(RVA = "0x32669FC", Offset = "0x32669FC", VA = "0x32669FC")]
		private static extern RESULT FMOD_Studio_EventDescription_GetInstanceList(IntPtr eventdescription, IntPtr[] array, int capacity, out int count);

		[PreserveSig]
		[Token(Token = "0x6000A2E")]
		[Address(RVA = "0x3266AB4", Offset = "0x3266AB4", VA = "0x3266AB4")]
		private static extern RESULT FMOD_Studio_EventDescription_LoadSampleData(IntPtr eventdescription);

		[PreserveSig]
		[Token(Token = "0x6000A2F")]
		[Address(RVA = "0x3266B3C", Offset = "0x3266B3C", VA = "0x3266B3C")]
		private static extern RESULT FMOD_Studio_EventDescription_UnloadSampleData(IntPtr eventdescription);

		[PreserveSig]
		[Token(Token = "0x6000A30")]
		[Address(RVA = "0x3266BC4", Offset = "0x3266BC4", VA = "0x3266BC4")]
		private static extern RESULT FMOD_Studio_EventDescription_GetSampleLoadingState(IntPtr eventdescription, out LOADING_STATE state);

		[PreserveSig]
		[Token(Token = "0x6000A31")]
		[Address(RVA = "0x3266C5C", Offset = "0x3266C5C", VA = "0x3266C5C")]
		private static extern RESULT FMOD_Studio_EventDescription_ReleaseAllInstances(IntPtr eventdescription);

		[PreserveSig]
		[Token(Token = "0x6000A32")]
		[Address(RVA = "0x3266CE4", Offset = "0x3266CE4", VA = "0x3266CE4")]
		private static extern RESULT FMOD_Studio_EventDescription_SetCallback(IntPtr eventdescription, EVENT_CALLBACK callback, EVENT_CALLBACK_TYPE callbackmask);

		[PreserveSig]
		[Token(Token = "0x6000A33")]
		[Address(RVA = "0x3266D8C", Offset = "0x3266D8C", VA = "0x3266D8C")]
		private static extern RESULT FMOD_Studio_EventDescription_GetUserData(IntPtr eventdescription, out IntPtr userdata);

		[PreserveSig]
		[Token(Token = "0x6000A34")]
		[Address(RVA = "0x3266E24", Offset = "0x3266E24", VA = "0x3266E24")]
		private static extern RESULT FMOD_Studio_EventDescription_SetUserData(IntPtr eventdescription, IntPtr userdata);

		[Token(Token = "0x6000A35")]
		[Address(RVA = "0x3266F3C", Offset = "0x3266F3C", VA = "0x3266F3C")]
		public bool hasHandle()
		{
			return default(bool);
		}

		[Token(Token = "0x6000A36")]
		[Address(RVA = "0x3266F88", Offset = "0x3266F88", VA = "0x3266F88")]
		public void clearHandle()
		{
		}

		[Token(Token = "0x6000A37")]
		[Address(RVA = "0x3266FCC", Offset = "0x3266FCC", VA = "0x3266FCC")]
		public bool isValid()
		{
			return default(bool);
		}
	}
	[Token(Token = "0x2000160")]
	public struct EventInstance
	{
		[Token(Token = "0x40008A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public IntPtr handle;

		[Token(Token = "0x6000A38")]
		[Address(RVA = "0x3267004", Offset = "0x3267004", VA = "0x3267004")]
		public RESULT getDescription(out EventDescription description)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000A39")]
		[Address(RVA = "0x326709C", Offset = "0x326709C", VA = "0x326709C")]
		public RESULT getVolume(out float volume)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000A3A")]
		[Address(RVA = "0x32670C4", Offset = "0x32670C4", VA = "0x32670C4")]
		public RESULT getVolume(out float volume, out float finalvolume)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000A3B")]
		[Address(RVA = "0x3267164", Offset = "0x3267164", VA = "0x3267164")]
		public RESULT setVolume(float volume)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000A3C")]
		[Address(RVA = "0x32671FC", Offset = "0x32671FC", VA = "0x32671FC")]
		public RESULT getPitch(out float pitch)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000A3D")]
		[Address(RVA = "0x3267224", Offset = "0x3267224", VA = "0x3267224")]
		public RESULT getPitch(out float pitch, out float finalpitch)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000A3E")]
		[Address(RVA = "0x32672C4", Offset = "0x32672C4", VA = "0x32672C4")]
		public RESULT setPitch(float pitch)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000A3F")]
		[Address(RVA = "0x326735C", Offset = "0x326735C", VA = "0x326735C")]
		public RESULT get3DAttributes(out ATTRIBUTES_3D attributes)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000A40")]
		[Address(RVA = "0x32673F4", Offset = "0x32673F4", VA = "0x32673F4")]
		public RESULT set3DAttributes(ATTRIBUTES_3D attributes)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000A41")]
		[Address(RVA = "0x326748C", Offset = "0x326748C", VA = "0x326748C")]
		public RESULT getListenerMask(out uint mask)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000A42")]
		[Address(RVA = "0x3267524", Offset = "0x3267524", VA = "0x3267524")]
		public RESULT setListenerMask(uint mask)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000A43")]
		[Address(RVA = "0x32675BC", Offset = "0x32675BC", VA = "0x32675BC")]
		public RESULT getProperty(EVENT_PROPERTY index, out float value)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000A44")]
		[Address(RVA = "0x326765C", Offset = "0x326765C", VA = "0x326765C")]
		public RESULT setProperty(EVENT_PROPERTY index, float value)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000A45")]
		[Address(RVA = "0x3267704", Offset = "0x3267704", VA = "0x3267704")]
		public RESULT getReverbLevel(int index, out float level)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000A46")]
		[Address(RVA = "0x32677A4", Offset = "0x32677A4", VA = "0x32677A4")]
		public RESULT setReverbLevel(int index, float level)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000A47")]
		[Address(RVA = "0x326784C", Offset = "0x326784C", VA = "0x326784C")]
		public RESULT getPaused(out bool paused)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000A48")]
		[Address(RVA = "0x32678F8", Offset = "0x32678F8", VA = "0x32678F8")]
		public RESULT setPaused(bool paused)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000A49")]
		[Address(RVA = "0x3267994", Offset = "0x3267994", VA = "0x3267994")]
		public RESULT start()
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000A4A")]
		[Address(RVA = "0x3267A1C", Offset = "0x3267A1C", VA = "0x3267A1C")]
		public RESULT stop(STOP_MODE mode)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000A4B")]
		[Address(RVA = "0x3267AB4", Offset = "0x3267AB4", VA = "0x3267AB4")]
		public RESULT getTimelinePosition(out int position)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000A4C")]
		[Address(RVA = "0x3267B4C", Offset = "0x3267B4C", VA = "0x3267B4C")]
		public RESULT setTimelinePosition(int position)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000A4D")]
		[Address(RVA = "0x3267BE4", Offset = "0x3267BE4", VA = "0x3267BE4")]
		public RESULT getPlaybackState(out PLAYBACK_STATE state)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000A4E")]
		[Address(RVA = "0x3267C7C", Offset = "0x3267C7C", VA = "0x3267C7C")]
		public RESULT getChannelGroup(out ChannelGroup group)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000A4F")]
		[Address(RVA = "0x3267D14", Offset = "0x3267D14", VA = "0x3267D14")]
		public RESULT release()
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000A50")]
		[Address(RVA = "0x3267D9C", Offset = "0x3267D9C", VA = "0x3267D9C")]
		public RESULT isVirtual(out bool virtualstate)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000A51")]
		[Address(RVA = "0x3267E48", Offset = "0x3267E48", VA = "0x3267E48")]
		public RESULT getParameterByID(PARAMETER_ID id, out float value)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000A52")]
		[Address(RVA = "0x3267E70", Offset = "0x3267E70", VA = "0x3267E70")]
		public RESULT getParameterByID(PARAMETER_ID id, out float value, out float finalvalue)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000A53")]
		[Address(RVA = "0x3267F20", Offset = "0x3267F20", VA = "0x3267F20")]
		public RESULT setParameterByID(PARAMETER_ID id, float value, bool ignoreseekspeed = false)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000A54")]
		[Address(RVA = "0x3267FD4", Offset = "0x3267FD4", VA = "0x3267FD4")]
		public RESULT setParametersByIDs(PARAMETER_ID[] ids, float[] values, int count, bool ignoreseekspeed = false)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000A55")]
		[Address(RVA = "0x32680A0", Offset = "0x32680A0", VA = "0x32680A0")]
		public RESULT getParameterByName(string name, out float value)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000A56")]
		[Address(RVA = "0x32680C4", Offset = "0x32680C4", VA = "0x32680C4")]
		public RESULT getParameterByName(string name, out float value, out float finalvalue)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000A57")]
		[Address(RVA = "0x32682D4", Offset = "0x32682D4", VA = "0x32682D4")]
		public RESULT getParameterByName(IntPtr name, out float value)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000A58")]
		[Address(RVA = "0x32682FC", Offset = "0x32682FC", VA = "0x32682FC")]
		public RESULT getParameterByName(IntPtr name, out float value, out float finalvalue)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000A59")]
		[Address(RVA = "0x32683AC", Offset = "0x32683AC", VA = "0x32683AC")]
		public RESULT setParameterByName(string name, float value, bool ignoreseekspeed = false)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000A5A")]
		[Address(RVA = "0x32685BC", Offset = "0x32685BC", VA = "0x32685BC")]
		public RESULT setParameterByName(IntPtr name, float value, bool ignoreseekspeed = false)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000A5B")]
		[Address(RVA = "0x3268670", Offset = "0x3268670", VA = "0x3268670")]
		public RESULT triggerCue()
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000A5C")]
		[Address(RVA = "0x32686F8", Offset = "0x32686F8", VA = "0x32686F8")]
		public RESULT setCallback(EVENT_CALLBACK callback, EVENT_CALLBACK_TYPE callbackmask = EVENT_CALLBACK_TYPE.ALL)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000A5D")]
		[Address(RVA = "0x32687A0", Offset = "0x32687A0", VA = "0x32687A0")]
		public RESULT getUserData(out IntPtr userdata)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000A5E")]
		[Address(RVA = "0x3268838", Offset = "0x3268838", VA = "0x3268838")]
		public RESULT setUserData(IntPtr userdata)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000A5F")]
		[Address(RVA = "0x32688D0", Offset = "0x32688D0", VA = "0x32688D0")]
		public RESULT getCPUUsage(out uint exclusive, out uint inclusive)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000A60")]
		[Address(RVA = "0x3268970", Offset = "0x3268970", VA = "0x3268970")]
		public RESULT getMemoryUsage(out MEMORY_USAGE memoryusage)
		{
			return default(RESULT);
		}

		[PreserveSig]
		[Token(Token = "0x6000A61")]
		[Address(RVA = "0x3268A08", Offset = "0x3268A08", VA = "0x3268A08")]
		private static extern bool FMOD_Studio_EventInstance_IsValid(IntPtr _event);

		[PreserveSig]
		[Token(Token = "0x6000A62")]
		[Address(RVA = "0x326700C", Offset = "0x326700C", VA = "0x326700C")]
		private static extern RESULT FMOD_Studio_EventInstance_GetDescription(IntPtr _event, out IntPtr description);

		[PreserveSig]
		[Token(Token = "0x6000A63")]
		[Address(RVA = "0x32670CC", Offset = "0x32670CC", VA = "0x32670CC")]
		private static extern RESULT FMOD_Studio_EventInstance_GetVolume(IntPtr _event, out float volume, out float finalvolume);

		[PreserveSig]
		[Token(Token = "0x6000A64")]
		[Address(RVA = "0x326716C", Offset = "0x326716C", VA = "0x326716C")]
		private static extern RESULT FMOD_Studio_EventInstance_SetVolume(IntPtr _event, float volume);

		[PreserveSig]
		[Token(Token = "0x6000A65")]
		[Address(RVA = "0x326722C", Offset = "0x326722C", VA = "0x326722C")]
		private static extern RESULT FMOD_Studio_EventInstance_GetPitch(IntPtr _event, out float pitch, out float finalpitch);

		[PreserveSig]
		[Token(Token = "0x6000A66")]
		[Address(RVA = "0x32672CC", Offset = "0x32672CC", VA = "0x32672CC")]
		private static extern RESULT FMOD_Studio_EventInstance_SetPitch(IntPtr _event, float pitch);

		[PreserveSig]
		[Token(Token = "0x6000A67")]
		[Address(RVA = "0x3267364", Offset = "0x3267364", VA = "0x3267364")]
		private static extern RESULT FMOD_Studio_EventInstance_Get3DAttributes(IntPtr _event, out ATTRIBUTES_3D attributes);

		[PreserveSig]
		[Token(Token = "0x6000A68")]
		[Address(RVA = "0x32673FC", Offset = "0x32673FC", VA = "0x32673FC")]
		private static extern RESULT FMOD_Studio_EventInstance_Set3DAttributes(IntPtr _event, ref ATTRIBUTES_3D attributes);

		[PreserveSig]
		[Token(Token = "0x6000A69")]
		[Address(RVA = "0x3267494", Offset = "0x3267494", VA = "0x3267494")]
		private static extern RESULT FMOD_Studio_EventInstance_GetListenerMask(IntPtr _event, out uint mask);

		[PreserveSig]
		[Token(Token = "0x6000A6A")]
		[Address(RVA = "0x326752C", Offset = "0x326752C", VA = "0x326752C")]
		private static extern RESULT FMOD_Studio_EventInstance_SetListenerMask(IntPtr _event, uint mask);

		[PreserveSig]
		[Token(Token = "0x6000A6B")]
		[Address(RVA = "0x32675C4", Offset = "0x32675C4", VA = "0x32675C4")]
		private static extern RESULT FMOD_Studio_EventInstance_GetProperty(IntPtr _event, EVENT_PROPERTY index, out float value);

		[PreserveSig]
		[Token(Token = "0x6000A6C")]
		[Address(RVA = "0x3267664", Offset = "0x3267664", VA = "0x3267664")]
		private static extern RESULT FMOD_Studio_EventInstance_SetProperty(IntPtr _event, EVENT_PROPERTY index, float value);

		[PreserveSig]
		[Token(Token = "0x6000A6D")]
		[Address(RVA = "0x326770C", Offset = "0x326770C", VA = "0x326770C")]
		private static extern RESULT FMOD_Studio_EventInstance_GetReverbLevel(IntPtr _event, int index, out float level);

		[PreserveSig]
		[Token(Token = "0x6000A6E")]
		[Address(RVA = "0x32677AC", Offset = "0x32677AC", VA = "0x32677AC")]
		private static extern RESULT FMOD_Studio_EventInstance_SetReverbLevel(IntPtr _event, int index, float level);

		[PreserveSig]
		[Token(Token = "0x6000A6F")]
		[Address(RVA = "0x3267854", Offset = "0x3267854", VA = "0x3267854")]
		private static extern RESULT FMOD_Studio_EventInstance_GetPaused(IntPtr _event, out bool paused);

		[PreserveSig]
		[Token(Token = "0x6000A70")]
		[Address(RVA = "0x3267904", Offset = "0x3267904", VA = "0x3267904")]
		private static extern RESULT FMOD_Studio_EventInstance_SetPaused(IntPtr _event, bool paused);

		[PreserveSig]
		[Token(Token = "0x6000A71")]
		[Address(RVA = "0x326799C", Offset = "0x326799C", VA = "0x326799C")]
		private static extern RESULT FMOD_Studio_EventInstance_Start(IntPtr _event);

		[PreserveSig]
		[Token(Token = "0x6000A72")]
		[Address(RVA = "0x3267A24", Offset = "0x3267A24", VA = "0x3267A24")]
		private static extern RESULT FMOD_Studio_EventInstance_Stop(IntPtr _event, STOP_MODE mode);

		[PreserveSig]
		[Token(Token = "0x6000A73")]
		[Address(RVA = "0x3267ABC", Offset = "0x3267ABC", VA = "0x3267ABC")]
		private static extern RESULT FMOD_Studio_EventInstance_GetTimelinePosition(IntPtr _event, out int position);

		[PreserveSig]
		[Token(Token = "0x6000A74")]
		[Address(RVA = "0x3267B54", Offset = "0x3267B54", VA = "0x3267B54")]
		private static extern RESULT FMOD_Studio_EventInstance_SetTimelinePosition(IntPtr _event, int position);

		[PreserveSig]
		[Token(Token = "0x6000A75")]
		[Address(RVA = "0x3267BEC", Offset = "0x3267BEC", VA = "0x3267BEC")]
		private static extern RESULT FMOD_Studio_EventInstance_GetPlaybackState(IntPtr _event, out PLAYBACK_STATE state);

		[PreserveSig]
		[Token(Token = "0x6000A76")]
		[Address(RVA = "0x3267C84", Offset = "0x3267C84", VA = "0x3267C84")]
		private static extern RESULT FMOD_Studio_EventInstance_GetChannelGroup(IntPtr _event, out IntPtr group);

		[PreserveSig]
		[Token(Token = "0x6000A77")]
		[Address(RVA = "0x3267D1C", Offset = "0x3267D1C", VA = "0x3267D1C")]
		private static extern RESULT FMOD_Studio_EventInstance_Release(IntPtr _event);

		[PreserveSig]
		[Token(Token = "0x6000A78")]
		[Address(RVA = "0x3267DA4", Offset = "0x3267DA4", VA = "0x3267DA4")]
		private static extern RESULT FMOD_Studio_EventInstance_IsVirtual(IntPtr _event, out bool virtualstate);

		[PreserveSig]
		[Token(Token = "0x6000A79")]
		[Address(RVA = "0x3268224", Offset = "0x3268224", VA = "0x3268224")]
		private static extern RESULT FMOD_Studio_EventInstance_GetParameterByName(IntPtr _event, byte[] name, out float value, out float finalvalue);

		[PreserveSig]
		[Token(Token = "0x6000A7A")]
		[Address(RVA = "0x3268304", Offset = "0x3268304", VA = "0x3268304")]
		private static extern RESULT FMOD_Studio_EventInstance_GetParameterByName(IntPtr _event, IntPtr name, out float value, out float finalvalue);

		[PreserveSig]
		[Token(Token = "0x6000A7B")]
		[Address(RVA = "0x3267E78", Offset = "0x3267E78", VA = "0x3267E78")]
		private static extern RESULT FMOD_Studio_EventInstance_GetParameterByID(IntPtr _event, ulong id, out float value, out float finalvalue);

		[PreserveSig]
		[Token(Token = "0x6000A7C")]
		[Address(RVA = "0x326850C", Offset = "0x326850C", VA = "0x326850C")]
		private static extern RESULT FMOD_Studio_EventInstance_SetParameterByName(IntPtr _event, byte[] name, float value, bool ignoreseekspeed);

		[PreserveSig]
		[Token(Token = "0x6000A7D")]
		[Address(RVA = "0x32685C8", Offset = "0x32685C8", VA = "0x32685C8")]
		private static extern RESULT FMOD_Studio_EventInstance_SetParameterByName(IntPtr _event, IntPtr name, float value, bool ignoreseekspeed);

		[PreserveSig]
		[Token(Token = "0x6000A7E")]
		[Address(RVA = "0x3267F2C", Offset = "0x3267F2C", VA = "0x3267F2C")]
		private static extern RESULT FMOD_Studio_EventInstance_SetParameterByID(IntPtr _event, ulong id, float value, bool ignoreseekspeed);

		[PreserveSig]
		[Token(Token = "0x6000A7F")]
		[Address(RVA = "0x3267FE0", Offset = "0x3267FE0", VA = "0x3267FE0")]
		private static extern RESULT FMOD_Studio_EventInstance_SetParametersByIDs(IntPtr _event, PARAMETER_ID[] ids, float[] values, int count, bool ignoreseekspeed);

		[PreserveSig]
		[Token(Token = "0x6000A80")]
		[Address(RVA = "0x3268678", Offset = "0x3268678", VA = "0x3268678")]
		private static extern RESULT FMOD_Studio_EventInstance_TriggerCue(IntPtr _event);

		[PreserveSig]
		[Token(Token = "0x6000A81")]
		[Address(RVA = "0x3268700", Offset = "0x3268700", VA = "0x3268700")]
		private static extern RESULT FMOD_Studio_EventInstance_SetCallback(IntPtr _event, EVENT_CALLBACK callback, EVENT_CALLBACK_TYPE callbackmask);

		[PreserveSig]
		[Token(Token = "0x6000A82")]
		[Address(RVA = "0x32687A8", Offset = "0x32687A8", VA = "0x32687A8")]
		private static extern RESULT FMOD_Studio_EventInstance_GetUserData(IntPtr _event, out IntPtr userdata);

		[PreserveSig]
		[Token(Token = "0x6000A83")]
		[Address(RVA = "0x3268840", Offset = "0x3268840", VA = "0x3268840")]
		private static extern RESULT FMOD_Studio_EventInstance_SetUserData(IntPtr _event, IntPtr userdata);

		[PreserveSig]
		[Token(Token = "0x6000A84")]
		[Address(RVA = "0x32688D8", Offset = "0x32688D8", VA = "0x32688D8")]
		private static extern RESULT FMOD_Studio_EventInstance_GetCPUUsage(IntPtr _event, out uint exclusive, out uint inclusive);

		[PreserveSig]
		[Token(Token = "0x6000A85")]
		[Address(RVA = "0x3268978", Offset = "0x3268978", VA = "0x3268978")]
		private static extern RESULT FMOD_Studio_EventInstance_GetMemoryUsage(IntPtr _event, out MEMORY_USAGE memoryusage);

		[Token(Token = "0x6000A86")]
		[Address(RVA = "0x3268A90", Offset = "0x3268A90", VA = "0x3268A90")]
		public bool hasHandle()
		{
			return default(bool);
		}

		[Token(Token = "0x6000A87")]
		[Address(RVA = "0x3268ADC", Offset = "0x3268ADC", VA = "0x3268ADC")]
		public void clearHandle()
		{
		}

		[Token(Token = "0x6000A88")]
		[Address(RVA = "0x3268B20", Offset = "0x3268B20", VA = "0x3268B20")]
		public bool isValid()
		{
			return default(bool);
		}
	}
	[Token(Token = "0x2000161")]
	public struct Bus
	{
		[Token(Token = "0x40008A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public IntPtr handle;

		[Token(Token = "0x6000A89")]
		[Address(RVA = "0x32626D4", Offset = "0x32626D4", VA = "0x32626D4")]
		public RESULT getID(out Guid id)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000A8A")]
		[Address(RVA = "0x326276C", Offset = "0x326276C", VA = "0x326276C")]
		public RESULT getPath(out string path)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000A8B")]
		[Address(RVA = "0x3262A4C", Offset = "0x3262A4C", VA = "0x3262A4C")]
		public RESULT getVolume(out float volume)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000A8C")]
		[Address(RVA = "0x3262A74", Offset = "0x3262A74", VA = "0x3262A74")]
		public RESULT getVolume(out float volume, out float finalvolume)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000A8D")]
		[Address(RVA = "0x3262B14", Offset = "0x3262B14", VA = "0x3262B14")]
		public RESULT setVolume(float volume)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000A8E")]
		[Address(RVA = "0x3262BAC", Offset = "0x3262BAC", VA = "0x3262BAC")]
		public RESULT getPaused(out bool paused)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000A8F")]
		[Address(RVA = "0x3262C58", Offset = "0x3262C58", VA = "0x3262C58")]
		public RESULT setPaused(bool paused)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000A90")]
		[Address(RVA = "0x3262CF4", Offset = "0x3262CF4", VA = "0x3262CF4")]
		public RESULT getMute(out bool mute)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000A91")]
		[Address(RVA = "0x3262DA0", Offset = "0x3262DA0", VA = "0x3262DA0")]
		public RESULT setMute(bool mute)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000A92")]
		[Address(RVA = "0x3262E3C", Offset = "0x3262E3C", VA = "0x3262E3C")]
		public RESULT stopAllEvents(STOP_MODE mode)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000A93")]
		[Address(RVA = "0x3262ED4", Offset = "0x3262ED4", VA = "0x3262ED4")]
		public RESULT lockChannelGroup()
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000A94")]
		[Address(RVA = "0x3262F5C", Offset = "0x3262F5C", VA = "0x3262F5C")]
		public RESULT unlockChannelGroup()
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000A95")]
		[Address(RVA = "0x3262FE4", Offset = "0x3262FE4", VA = "0x3262FE4")]
		public RESULT getChannelGroup(out ChannelGroup group)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000A96")]
		[Address(RVA = "0x326307C", Offset = "0x326307C", VA = "0x326307C")]
		public RESULT getCPUUsage(out uint exclusive, out uint inclusive)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000A97")]
		[Address(RVA = "0x326311C", Offset = "0x326311C", VA = "0x326311C")]
		public RESULT getMemoryUsage(out MEMORY_USAGE memoryusage)
		{
			return default(RESULT);
		}

		[PreserveSig]
		[Token(Token = "0x6000A98")]
		[Address(RVA = "0x32631B4", Offset = "0x32631B4", VA = "0x32631B4")]
		private static extern bool FMOD_Studio_Bus_IsValid(IntPtr bus);

		[PreserveSig]
		[Token(Token = "0x6000A99")]
		[Address(RVA = "0x32626DC", Offset = "0x32626DC", VA = "0x32626DC")]
		private static extern RESULT FMOD_Studio_Bus_GetID(IntPtr bus, out Guid id);

		[PreserveSig]
		[Token(Token = "0x6000A9A")]
		[Address(RVA = "0x32629A4", Offset = "0x32629A4", VA = "0x32629A4")]
		private static extern RESULT FMOD_Studio_Bus_GetPath(IntPtr bus, IntPtr path, int size, out int retrieved);

		[PreserveSig]
		[Token(Token = "0x6000A9B")]
		[Address(RVA = "0x3262A7C", Offset = "0x3262A7C", VA = "0x3262A7C")]
		private static extern RESULT FMOD_Studio_Bus_GetVolume(IntPtr bus, out float volume, out float finalvolume);

		[PreserveSig]
		[Token(Token = "0x6000A9C")]
		[Address(RVA = "0x3262B1C", Offset = "0x3262B1C", VA = "0x3262B1C")]
		private static extern RESULT FMOD_Studio_Bus_SetVolume(IntPtr bus, float volume);

		[PreserveSig]
		[Token(Token = "0x6000A9D")]
		[Address(RVA = "0x3262BB4", Offset = "0x3262BB4", VA = "0x3262BB4")]
		private static extern RESULT FMOD_Studio_Bus_GetPaused(IntPtr bus, out bool paused);

		[PreserveSig]
		[Token(Token = "0x6000A9E")]
		[Address(RVA = "0x3262C64", Offset = "0x3262C64", VA = "0x3262C64")]
		private static extern RESULT FMOD_Studio_Bus_SetPaused(IntPtr bus, bool paused);

		[PreserveSig]
		[Token(Token = "0x6000A9F")]
		[Address(RVA = "0x3262CFC", Offset = "0x3262CFC", VA = "0x3262CFC")]
		private static extern RESULT FMOD_Studio_Bus_GetMute(IntPtr bus, out bool mute);

		[PreserveSig]
		[Token(Token = "0x6000AA0")]
		[Address(RVA = "0x3262DAC", Offset = "0x3262DAC", VA = "0x3262DAC")]
		private static extern RESULT FMOD_Studio_Bus_SetMute(IntPtr bus, bool mute);

		[PreserveSig]
		[Token(Token = "0x6000AA1")]
		[Address(RVA = "0x3262E44", Offset = "0x3262E44", VA = "0x3262E44")]
		private static extern RESULT FMOD_Studio_Bus_StopAllEvents(IntPtr bus, STOP_MODE mode);

		[PreserveSig]
		[Token(Token = "0x6000AA2")]
		[Address(RVA = "0x3262EDC", Offset = "0x3262EDC", VA = "0x3262EDC")]
		private static extern RESULT FMOD_Studio_Bus_LockChannelGroup(IntPtr bus);

		[PreserveSig]
		[Token(Token = "0x6000AA3")]
		[Address(RVA = "0x3262F64", Offset = "0x3262F64", VA = "0x3262F64")]
		private static extern RESULT FMOD_Studio_Bus_UnlockChannelGroup(IntPtr bus);

		[PreserveSig]
		[Token(Token = "0x6000AA4")]
		[Address(RVA = "0x3262FEC", Offset = "0x3262FEC", VA = "0x3262FEC")]
		private static extern RESULT FMOD_Studio_Bus_GetChannelGroup(IntPtr bus, out IntPtr group);

		[PreserveSig]
		[Token(Token = "0x6000AA5")]
		[Address(RVA = "0x3263084", Offset = "0x3263084", VA = "0x3263084")]
		private static extern RESULT FMOD_Studio_Bus_GetCPUUsage(IntPtr bus, out uint exclusive, out uint inclusive);

		[PreserveSig]
		[Token(Token = "0x6000AA6")]
		[Address(RVA = "0x3263124", Offset = "0x3263124", VA = "0x3263124")]
		private static extern RESULT FMOD_Studio_Bus_GetMemoryUsage(IntPtr bus, out MEMORY_USAGE memoryusage);

		[Token(Token = "0x6000AA7")]
		[Address(RVA = "0x326323C", Offset = "0x326323C", VA = "0x326323C")]
		public bool hasHandle()
		{
			return default(bool);
		}

		[Token(Token = "0x6000AA8")]
		[Address(RVA = "0x3263288", Offset = "0x3263288", VA = "0x3263288")]
		public void clearHandle()
		{
		}

		[Token(Token = "0x6000AA9")]
		[Address(RVA = "0x32632CC", Offset = "0x32632CC", VA = "0x32632CC")]
		public bool isValid()
		{
			return default(bool);
		}
	}
	[Token(Token = "0x2000162")]
	public struct VCA
	{
		[Token(Token = "0x40008AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public IntPtr handle;

		[Token(Token = "0x6000AAA")]
		[Address(RVA = "0x23EE3A0", Offset = "0x23EE3A0", VA = "0x23EE3A0")]
		public RESULT getID(out Guid id)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000AAB")]
		[Address(RVA = "0x23EE438", Offset = "0x23EE438", VA = "0x23EE438")]
		public RESULT getPath(out string path)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000AAC")]
		[Address(RVA = "0x23EE720", Offset = "0x23EE720", VA = "0x23EE720")]
		public RESULT getVolume(out float volume)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000AAD")]
		[Address(RVA = "0x23EE748", Offset = "0x23EE748", VA = "0x23EE748")]
		public RESULT getVolume(out float volume, out float finalvolume)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000AAE")]
		[Address(RVA = "0x23EE7E8", Offset = "0x23EE7E8", VA = "0x23EE7E8")]
		public RESULT setVolume(float volume)
		{
			return default(RESULT);
		}

		[PreserveSig]
		[Token(Token = "0x6000AAF")]
		[Address(RVA = "0x23EE880", Offset = "0x23EE880", VA = "0x23EE880")]
		private static extern bool FMOD_Studio_VCA_IsValid(IntPtr vca);

		[PreserveSig]
		[Token(Token = "0x6000AB0")]
		[Address(RVA = "0x23EE3A8", Offset = "0x23EE3A8", VA = "0x23EE3A8")]
		private static extern RESULT FMOD_Studio_VCA_GetID(IntPtr vca, out Guid id);

		[PreserveSig]
		[Token(Token = "0x6000AB1")]
		[Address(RVA = "0x23EE678", Offset = "0x23EE678", VA = "0x23EE678")]
		private static extern RESULT FMOD_Studio_VCA_GetPath(IntPtr vca, IntPtr path, int size, out int retrieved);

		[PreserveSig]
		[Token(Token = "0x6000AB2")]
		[Address(RVA = "0x23EE750", Offset = "0x23EE750", VA = "0x23EE750")]
		private static extern RESULT FMOD_Studio_VCA_GetVolume(IntPtr vca, out float volume, out float finalvolume);

		[PreserveSig]
		[Token(Token = "0x6000AB3")]
		[Address(RVA = "0x23EE7F0", Offset = "0x23EE7F0", VA = "0x23EE7F0")]
		private static extern RESULT FMOD_Studio_VCA_SetVolume(IntPtr vca, float volume);

		[Token(Token = "0x6000AB4")]
		[Address(RVA = "0x23EE908", Offset = "0x23EE908", VA = "0x23EE908")]
		public bool hasHandle()
		{
			return default(bool);
		}

		[Token(Token = "0x6000AB5")]
		[Address(RVA = "0x23EE954", Offset = "0x23EE954", VA = "0x23EE954")]
		public void clearHandle()
		{
		}

		[Token(Token = "0x6000AB6")]
		[Address(RVA = "0x23EE998", Offset = "0x23EE998", VA = "0x23EE998")]
		public bool isValid()
		{
			return default(bool);
		}
	}
	[Token(Token = "0x2000163")]
	public struct Bank
	{
		[Token(Token = "0x40008AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public IntPtr handle;

		[Token(Token = "0x6000AB7")]
		[Address(RVA = "0x326126C", Offset = "0x326126C", VA = "0x326126C")]
		public RESULT getID(out Guid id)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000AB8")]
		[Address(RVA = "0x3261304", Offset = "0x3261304", VA = "0x3261304")]
		public RESULT getPath(out string path)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000AB9")]
		[Address(RVA = "0x32615E4", Offset = "0x32615E4", VA = "0x32615E4")]
		public RESULT unload()
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000ABA")]
		[Address(RVA = "0x326166C", Offset = "0x326166C", VA = "0x326166C")]
		public RESULT loadSampleData()
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000ABB")]
		[Address(RVA = "0x32616F4", Offset = "0x32616F4", VA = "0x32616F4")]
		public RESULT unloadSampleData()
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000ABC")]
		[Address(RVA = "0x326177C", Offset = "0x326177C", VA = "0x326177C")]
		public RESULT getLoadingState(out LOADING_STATE state)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000ABD")]
		[Address(RVA = "0x3261814", Offset = "0x3261814", VA = "0x3261814")]
		public RESULT getSampleLoadingState(out LOADING_STATE state)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000ABE")]
		[Address(RVA = "0x32618AC", Offset = "0x32618AC", VA = "0x32618AC")]
		public RESULT getStringCount(out int count)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000ABF")]
		[Address(RVA = "0x3261944", Offset = "0x3261944", VA = "0x3261944")]
		public RESULT getStringInfo(int index, out Guid id, out string path)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000AC0")]
		[Address(RVA = "0x3261C8C", Offset = "0x3261C8C", VA = "0x3261C8C")]
		public RESULT getEventCount(out int count)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000AC1")]
		[Address(RVA = "0x3261D24", Offset = "0x3261D24", VA = "0x3261D24")]
		public RESULT getEventList(out EventDescription[] array)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000AC2")]
		[Address(RVA = "0x3261F24", Offset = "0x3261F24", VA = "0x3261F24")]
		public RESULT getBusCount(out int count)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000AC3")]
		[Address(RVA = "0x3261FBC", Offset = "0x3261FBC", VA = "0x3261FBC")]
		public RESULT getBusList(out Bus[] array)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000AC4")]
		[Address(RVA = "0x32621BC", Offset = "0x32621BC", VA = "0x32621BC")]
		public RESULT getVCACount(out int count)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000AC5")]
		[Address(RVA = "0x3262254", Offset = "0x3262254", VA = "0x3262254")]
		public RESULT getVCAList(out VCA[] array)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000AC6")]
		[Address(RVA = "0x3262454", Offset = "0x3262454", VA = "0x3262454")]
		public RESULT getUserData(out IntPtr userdata)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000AC7")]
		[Address(RVA = "0x32624EC", Offset = "0x32624EC", VA = "0x32624EC")]
		public RESULT setUserData(IntPtr userdata)
		{
			return default(RESULT);
		}

		[PreserveSig]
		[Token(Token = "0x6000AC8")]
		[Address(RVA = "0x3262584", Offset = "0x3262584", VA = "0x3262584")]
		private static extern bool FMOD_Studio_Bank_IsValid(IntPtr bank);

		[PreserveSig]
		[Token(Token = "0x6000AC9")]
		[Address(RVA = "0x3261274", Offset = "0x3261274", VA = "0x3261274")]
		private static extern RESULT FMOD_Studio_Bank_GetID(IntPtr bank, out Guid id);

		[PreserveSig]
		[Token(Token = "0x6000ACA")]
		[Address(RVA = "0x326153C", Offset = "0x326153C", VA = "0x326153C")]
		private static extern RESULT FMOD_Studio_Bank_GetPath(IntPtr bank, IntPtr path, int size, out int retrieved);

		[PreserveSig]
		[Token(Token = "0x6000ACB")]
		[Address(RVA = "0x32615EC", Offset = "0x32615EC", VA = "0x32615EC")]
		private static extern RESULT FMOD_Studio_Bank_Unload(IntPtr bank);

		[PreserveSig]
		[Token(Token = "0x6000ACC")]
		[Address(RVA = "0x3261674", Offset = "0x3261674", VA = "0x3261674")]
		private static extern RESULT FMOD_Studio_Bank_LoadSampleData(IntPtr bank);

		[PreserveSig]
		[Token(Token = "0x6000ACD")]
		[Address(RVA = "0x32616FC", Offset = "0x32616FC", VA = "0x32616FC")]
		private static extern RESULT FMOD_Studio_Bank_UnloadSampleData(IntPtr bank);

		[PreserveSig]
		[Token(Token = "0x6000ACE")]
		[Address(RVA = "0x3261784", Offset = "0x3261784", VA = "0x3261784")]
		private static extern RESULT FMOD_Studio_Bank_GetLoadingState(IntPtr bank, out LOADING_STATE state);

		[PreserveSig]
		[Token(Token = "0x6000ACF")]
		[Address(RVA = "0x326181C", Offset = "0x326181C", VA = "0x326181C")]
		private static extern RESULT FMOD_Studio_Bank_GetSampleLoadingState(IntPtr bank, out LOADING_STATE state);

		[PreserveSig]
		[Token(Token = "0x6000AD0")]
		[Address(RVA = "0x32618B4", Offset = "0x32618B4", VA = "0x32618B4")]
		private static extern RESULT FMOD_Studio_Bank_GetStringCount(IntPtr bank, out int count);

		[PreserveSig]
		[Token(Token = "0x6000AD1")]
		[Address(RVA = "0x3261BCC", Offset = "0x3261BCC", VA = "0x3261BCC")]
		private static extern RESULT FMOD_Studio_Bank_GetStringInfo(IntPtr bank, int index, out Guid id, IntPtr path, int size, out int retrieved);

		[PreserveSig]
		[Token(Token = "0x6000AD2")]
		[Address(RVA = "0x3261C94", Offset = "0x3261C94", VA = "0x3261C94")]
		private static extern RESULT FMOD_Studio_Bank_GetEventCount(IntPtr bank, out int count);

		[PreserveSig]
		[Token(Token = "0x6000AD3")]
		[Address(RVA = "0x3261E74", Offset = "0x3261E74", VA = "0x3261E74")]
		private static extern RESULT FMOD_Studio_Bank_GetEventList(IntPtr bank, IntPtr[] array, int capacity, out int count);

		[PreserveSig]
		[Token(Token = "0x6000AD4")]
		[Address(RVA = "0x3261F2C", Offset = "0x3261F2C", VA = "0x3261F2C")]
		private static extern RESULT FMOD_Studio_Bank_GetBusCount(IntPtr bank, out int count);

		[PreserveSig]
		[Token(Token = "0x6000AD5")]
		[Address(RVA = "0x326210C", Offset = "0x326210C", VA = "0x326210C")]
		private static extern RESULT FMOD_Studio_Bank_GetBusList(IntPtr bank, IntPtr[] array, int capacity, out int count);

		[PreserveSig]
		[Token(Token = "0x6000AD6")]
		[Address(RVA = "0x32621C4", Offset = "0x32621C4", VA = "0x32621C4")]
		private static extern RESULT FMOD_Studio_Bank_GetVCACount(IntPtr bank, out int count);

		[PreserveSig]
		[Token(Token = "0x6000AD7")]
		[Address(RVA = "0x32623A4", Offset = "0x32623A4", VA = "0x32623A4")]
		private static extern RESULT FMOD_Studio_Bank_GetVCAList(IntPtr bank, IntPtr[] array, int capacity, out int count);

		[PreserveSig]
		[Token(Token = "0x6000AD8")]
		[Address(RVA = "0x326245C", Offset = "0x326245C", VA = "0x326245C")]
		private static extern RESULT FMOD_Studio_Bank_GetUserData(IntPtr bank, out IntPtr userdata);

		[PreserveSig]
		[Token(Token = "0x6000AD9")]
		[Address(RVA = "0x32624F4", Offset = "0x32624F4", VA = "0x32624F4")]
		private static extern RESULT FMOD_Studio_Bank_SetUserData(IntPtr bank, IntPtr userdata);

		[Token(Token = "0x6000ADA")]
		[Address(RVA = "0x326260C", Offset = "0x326260C", VA = "0x326260C")]
		public bool hasHandle()
		{
			return default(bool);
		}

		[Token(Token = "0x6000ADB")]
		[Address(RVA = "0x3262658", Offset = "0x3262658", VA = "0x3262658")]
		public void clearHandle()
		{
		}

		[Token(Token = "0x6000ADC")]
		[Address(RVA = "0x326269C", Offset = "0x326269C", VA = "0x326269C")]
		public bool isValid()
		{
			return default(bool);
		}
	}
	[Token(Token = "0x2000164")]
	public struct CommandReplay
	{
		[Token(Token = "0x40008AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public IntPtr handle;

		[Token(Token = "0x6000ADD")]
		[Address(RVA = "0x3263FF4", Offset = "0x3263FF4", VA = "0x3263FF4")]
		public RESULT getSystem(out System system)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000ADE")]
		[Address(RVA = "0x326408C", Offset = "0x326408C", VA = "0x326408C")]
		public RESULT getLength(out float length)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000ADF")]
		[Address(RVA = "0x3264124", Offset = "0x3264124", VA = "0x3264124")]
		public RESULT getCommandCount(out int count)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000AE0")]
		[Address(RVA = "0x32641BC", Offset = "0x32641BC", VA = "0x32641BC")]
		public RESULT getCommandInfo(int commandIndex, out COMMAND_INFO info)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000AE1")]
		[Address(RVA = "0x326425C", Offset = "0x326425C", VA = "0x326425C")]
		public RESULT getCommandString(int commandIndex, out string buffer)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000AE2")]
		[Address(RVA = "0x3264544", Offset = "0x3264544", VA = "0x3264544")]
		public RESULT getCommandAtTime(float time, out int commandIndex)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000AE3")]
		[Address(RVA = "0x32645EC", Offset = "0x32645EC", VA = "0x32645EC")]
		public RESULT setBankPath(string bankPath)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000AE4")]
		[Address(RVA = "0x32647CC", Offset = "0x32647CC", VA = "0x32647CC")]
		public RESULT start()
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000AE5")]
		[Address(RVA = "0x3264854", Offset = "0x3264854", VA = "0x3264854")]
		public RESULT stop()
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000AE6")]
		[Address(RVA = "0x32648DC", Offset = "0x32648DC", VA = "0x32648DC")]
		public RESULT seekToTime(float time)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000AE7")]
		[Address(RVA = "0x3264974", Offset = "0x3264974", VA = "0x3264974")]
		public RESULT seekToCommand(int commandIndex)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000AE8")]
		[Address(RVA = "0x3264A0C", Offset = "0x3264A0C", VA = "0x3264A0C")]
		public RESULT getPaused(out bool paused)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000AE9")]
		[Address(RVA = "0x3264AB8", Offset = "0x3264AB8", VA = "0x3264AB8")]
		public RESULT setPaused(bool paused)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000AEA")]
		[Address(RVA = "0x3264B54", Offset = "0x3264B54", VA = "0x3264B54")]
		public RESULT getPlaybackState(out PLAYBACK_STATE state)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000AEB")]
		[Address(RVA = "0x3264BEC", Offset = "0x3264BEC", VA = "0x3264BEC")]
		public RESULT getCurrentCommand(out int commandIndex, out float currentTime)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000AEC")]
		[Address(RVA = "0x3264C8C", Offset = "0x3264C8C", VA = "0x3264C8C")]
		public RESULT release()
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000AED")]
		[Address(RVA = "0x3264D14", Offset = "0x3264D14", VA = "0x3264D14")]
		public RESULT setFrameCallback(COMMANDREPLAY_FRAME_CALLBACK callback)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000AEE")]
		[Address(RVA = "0x3264DB4", Offset = "0x3264DB4", VA = "0x3264DB4")]
		public RESULT setLoadBankCallback(COMMANDREPLAY_LOAD_BANK_CALLBACK callback)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000AEF")]
		[Address(RVA = "0x3264E54", Offset = "0x3264E54", VA = "0x3264E54")]
		public RESULT setCreateInstanceCallback(COMMANDREPLAY_CREATE_INSTANCE_CALLBACK callback)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000AF0")]
		[Address(RVA = "0x3264EF4", Offset = "0x3264EF4", VA = "0x3264EF4")]
		public RESULT getUserData(out IntPtr userdata)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000AF1")]
		[Address(RVA = "0x3264F8C", Offset = "0x3264F8C", VA = "0x3264F8C")]
		public RESULT setUserData(IntPtr userdata)
		{
			return default(RESULT);
		}

		[PreserveSig]
		[Token(Token = "0x6000AF2")]
		[Address(RVA = "0x3265024", Offset = "0x3265024", VA = "0x3265024")]
		private static extern bool FMOD_Studio_CommandReplay_IsValid(IntPtr replay);

		[PreserveSig]
		[Token(Token = "0x6000AF3")]
		[Address(RVA = "0x3263FFC", Offset = "0x3263FFC", VA = "0x3263FFC")]
		private static extern RESULT FMOD_Studio_CommandReplay_GetSystem(IntPtr replay, out IntPtr system);

		[PreserveSig]
		[Token(Token = "0x6000AF4")]
		[Address(RVA = "0x3264094", Offset = "0x3264094", VA = "0x3264094")]
		private static extern RESULT FMOD_Studio_CommandReplay_GetLength(IntPtr replay, out float length);

		[PreserveSig]
		[Token(Token = "0x6000AF5")]
		[Address(RVA = "0x326412C", Offset = "0x326412C", VA = "0x326412C")]
		private static extern RESULT FMOD_Studio_CommandReplay_GetCommandCount(IntPtr replay, out int count);

		[PreserveSig]
		[Token(Token = "0x6000AF6")]
		[Address(RVA = "0x32641C4", Offset = "0x32641C4", VA = "0x32641C4")]
		private static extern RESULT FMOD_Studio_CommandReplay_GetCommandInfo(IntPtr replay, int commandindex, out COMMAND_INFO info);

		[PreserveSig]
		[Token(Token = "0x6000AF7")]
		[Address(RVA = "0x326449C", Offset = "0x326449C", VA = "0x326449C")]
		private static extern RESULT FMOD_Studio_CommandReplay_GetCommandString(IntPtr replay, int commandIndex, IntPtr buffer, int length);

		[PreserveSig]
		[Token(Token = "0x6000AF8")]
		[Address(RVA = "0x326454C", Offset = "0x326454C", VA = "0x326454C")]
		private static extern RESULT FMOD_Studio_CommandReplay_GetCommandAtTime(IntPtr replay, float time, out int commandIndex);

		[PreserveSig]
		[Token(Token = "0x6000AF9")]
		[Address(RVA = "0x3264734", Offset = "0x3264734", VA = "0x3264734")]
		private static extern RESULT FMOD_Studio_CommandReplay_SetBankPath(IntPtr replay, byte[] bankPath);

		[PreserveSig]
		[Token(Token = "0x6000AFA")]
		[Address(RVA = "0x32647D4", Offset = "0x32647D4", VA = "0x32647D4")]
		private static extern RESULT FMOD_Studio_CommandReplay_Start(IntPtr replay);

		[PreserveSig]
		[Token(Token = "0x6000AFB")]
		[Address(RVA = "0x326485C", Offset = "0x326485C", VA = "0x326485C")]
		private static extern RESULT FMOD_Studio_CommandReplay_Stop(IntPtr replay);

		[PreserveSig]
		[Token(Token = "0x6000AFC")]
		[Address(RVA = "0x32648E4", Offset = "0x32648E4", VA = "0x32648E4")]
		private static extern RESULT FMOD_Studio_CommandReplay_SeekToTime(IntPtr replay, float time);

		[PreserveSig]
		[Token(Token = "0x6000AFD")]
		[Address(RVA = "0x326497C", Offset = "0x326497C", VA = "0x326497C")]
		private static extern RESULT FMOD_Studio_CommandReplay_SeekToCommand(IntPtr replay, int commandIndex);

		[PreserveSig]
		[Token(Token = "0x6000AFE")]
		[Address(RVA = "0x3264A14", Offset = "0x3264A14", VA = "0x3264A14")]
		private static extern RESULT FMOD_Studio_CommandReplay_GetPaused(IntPtr replay, out bool paused);

		[PreserveSig]
		[Token(Token = "0x6000AFF")]
		[Address(RVA = "0x3264AC4", Offset = "0x3264AC4", VA = "0x3264AC4")]
		private static extern RESULT FMOD_Studio_CommandReplay_SetPaused(IntPtr replay, bool paused);

		[PreserveSig]
		[Token(Token = "0x6000B00")]
		[Address(RVA = "0x3264B5C", Offset = "0x3264B5C", VA = "0x3264B5C")]
		private static extern RESULT FMOD_Studio_CommandReplay_GetPlaybackState(IntPtr replay, out PLAYBACK_STATE state);

		[PreserveSig]
		[Token(Token = "0x6000B01")]
		[Address(RVA = "0x3264BF4", Offset = "0x3264BF4", VA = "0x3264BF4")]
		private static extern RESULT FMOD_Studio_CommandReplay_GetCurrentCommand(IntPtr replay, out int commandIndex, out float currentTime);

		[PreserveSig]
		[Token(Token = "0x6000B02")]
		[Address(RVA = "0x3264C94", Offset = "0x3264C94", VA = "0x3264C94")]
		private static extern RESULT FMOD_Studio_CommandReplay_Release(IntPtr replay);

		[PreserveSig]
		[Token(Token = "0x6000B03")]
		[Address(RVA = "0x3264D1C", Offset = "0x3264D1C", VA = "0x3264D1C")]
		private static extern RESULT FMOD_Studio_CommandReplay_SetFrameCallback(IntPtr replay, COMMANDREPLAY_FRAME_CALLBACK callback);

		[PreserveSig]
		[Token(Token = "0x6000B04")]
		[Address(RVA = "0x3264DBC", Offset = "0x3264DBC", VA = "0x3264DBC")]
		private static extern RESULT FMOD_Studio_CommandReplay_SetLoadBankCallback(IntPtr replay, COMMANDREPLAY_LOAD_BANK_CALLBACK callback);

		[PreserveSig]
		[Token(Token = "0x6000B05")]
		[Address(RVA = "0x3264E5C", Offset = "0x3264E5C", VA = "0x3264E5C")]
		private static extern RESULT FMOD_Studio_CommandReplay_SetCreateInstanceCallback(IntPtr replay, COMMANDREPLAY_CREATE_INSTANCE_CALLBACK callback);

		[PreserveSig]
		[Token(Token = "0x6000B06")]
		[Address(RVA = "0x3264EFC", Offset = "0x3264EFC", VA = "0x3264EFC")]
		private static extern RESULT FMOD_Studio_CommandReplay_GetUserData(IntPtr replay, out IntPtr userdata);

		[PreserveSig]
		[Token(Token = "0x6000B07")]
		[Address(RVA = "0x3264F94", Offset = "0x3264F94", VA = "0x3264F94")]
		private static extern RESULT FMOD_Studio_CommandReplay_SetUserData(IntPtr replay, IntPtr userdata);

		[Token(Token = "0x6000B08")]
		[Address(RVA = "0x32650AC", Offset = "0x32650AC", VA = "0x32650AC")]
		public bool hasHandle()
		{
			return default(bool);
		}

		[Token(Token = "0x6000B09")]
		[Address(RVA = "0x32650F8", Offset = "0x32650F8", VA = "0x32650F8")]
		public void clearHandle()
		{
		}

		[Token(Token = "0x6000B0A")]
		[Address(RVA = "0x326513C", Offset = "0x326513C", VA = "0x326513C")]
		public bool isValid()
		{
			return default(bool);
		}
	}
}
namespace FMODUnity
{
	[Token(Token = "0x2000165")]
	public class FMODRuntimeManagerOnGUIHelper : MonoBehaviour
	{
		[Token(Token = "0x40008AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public RuntimeManager TargetRuntimeManager;

		[Token(Token = "0x6000B0B")]
		[Address(RVA = "0x23F584C", Offset = "0x23F584C", VA = "0x23F584C")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000B0C")]
		[Address(RVA = "0x23F59E4", Offset = "0x23F59E4", VA = "0x23F59E4")]
		public FMODRuntimeManagerOnGUIHelper()
		{
		}
	}
	[Token(Token = "0x2000166")]
	public class BankRefAttribute : PropertyAttribute
	{
		[Token(Token = "0x6000B0D")]
		[Address(RVA = "0x23F5370", Offset = "0x23F5370", VA = "0x23F5370")]
		public BankRefAttribute()
		{
		}
	}
	[Token(Token = "0x2000167")]
	public abstract class EventHandler : MonoBehaviour
	{
		[Token(Token = "0x40008AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string CollisionTag;

		[Token(Token = "0x6000B0E")]
		[Address(RVA = "0x23F542C", Offset = "0x23F542C", VA = "0x23F542C")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000B0F")]
		[Address(RVA = "0x23F543C", Offset = "0x23F543C", VA = "0x23F543C")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000B10")]
		[Address(RVA = "0x23F544C", Offset = "0x23F544C", VA = "0x23F544C")]
		private void OnTriggerEnter(Collider other)
		{
		}

		[Token(Token = "0x6000B11")]
		[Address(RVA = "0x23F54B4", Offset = "0x23F54B4", VA = "0x23F54B4")]
		private void OnTriggerExit(Collider other)
		{
		}

		[Token(Token = "0x6000B12")]
		[Address(RVA = "0x23F551C", Offset = "0x23F551C", VA = "0x23F551C")]
		private void OnTriggerEnter2D(Collider2D other)
		{
		}

		[Token(Token = "0x6000B13")]
		[Address(RVA = "0x23F5584", Offset = "0x23F5584", VA = "0x23F5584")]
		private void OnTriggerExit2D(Collider2D other)
		{
		}

		[Token(Token = "0x6000B14")]
		[Address(RVA = "0x23F55EC", Offset = "0x23F55EC", VA = "0x23F55EC")]
		private void OnCollisionEnter()
		{
		}

		[Token(Token = "0x6000B15")]
		[Address(RVA = "0x23F55FC", Offset = "0x23F55FC", VA = "0x23F55FC")]
		private void OnCollisionExit()
		{
		}

		[Token(Token = "0x6000B16")]
		[Address(RVA = "0x23F560C", Offset = "0x23F560C", VA = "0x23F560C")]
		private void OnCollisionEnter2D()
		{
		}

		[Token(Token = "0x6000B17")]
		[Address(RVA = "0x23F561C", Offset = "0x23F561C", VA = "0x23F561C")]
		private void OnCollisionExit2D()
		{
		}

		[Token(Token = "0x6000B18")]
		[Address(RVA = "0x23F562C", Offset = "0x23F562C", VA = "0x23F562C")]
		private void OnMouseEnter()
		{
		}

		[Token(Token = "0x6000B19")]
		[Address(RVA = "0x23F563C", Offset = "0x23F563C", VA = "0x23F563C")]
		private void OnMouseExit()
		{
		}

		[Token(Token = "0x6000B1A")]
		[Address(RVA = "0x23F564C", Offset = "0x23F564C", VA = "0x23F564C")]
		private void OnMouseDown()
		{
		}

		[Token(Token = "0x6000B1B")]
		[Address(RVA = "0x23F565C", Offset = "0x23F565C", VA = "0x23F565C")]
		private void OnMouseUp()
		{
		}

		[Token(Token = "0x6000B1C")]
		protected abstract void HandleGameEvent(EmitterGameEvent gameEvent);

		[Token(Token = "0x6000B1D")]
		[Address(RVA = "0x23F566C", Offset = "0x23F566C", VA = "0x23F566C")]
		protected EventHandler()
		{
		}
	}
	[Token(Token = "0x2000168")]
	public class EventRefAttribute : PropertyAttribute
	{
		[Token(Token = "0x6000B1E")]
		[Address(RVA = "0x23F5844", Offset = "0x23F5844", VA = "0x23F5844")]
		public EventRefAttribute()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000169")]
	public class ParamRef
	{
		[Token(Token = "0x40008AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string Name;

		[Token(Token = "0x40008B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float Value;

		[Token(Token = "0x40008B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public PARAMETER_ID ID;

		[Token(Token = "0x6000B1F")]
		[Address(RVA = "0x23F59EC", Offset = "0x23F59EC", VA = "0x23F59EC")]
		public ParamRef()
		{
		}
	}
	[Token(Token = "0x200016A")]
	public class ParamRefAttribute : PropertyAttribute
	{
		[Token(Token = "0x6000B20")]
		[Address(RVA = "0x23F59F4", Offset = "0x23F59F4", VA = "0x23F59F4")]
		public ParamRefAttribute()
		{
		}
	}
	[Token(Token = "0x200016B")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x14CFD78", Offset = "0x14CFD78")]
	public class RuntimeManager : MonoBehaviour
	{
		[Token(Token = "0x20001D4")]
		private struct LoadedBank
		{
			[Token(Token = "0x4000BAD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Bank Bank;

			[Token(Token = "0x4000BAE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public int RefCount;
		}

		[Token(Token = "0x20001D5")]
		private class GuidComparer : IEqualityComparer<Guid>
		{
			[Token(Token = "0x6000D46")]
			[Address(RVA = "0x23FBC60", Offset = "0x23FBC60", VA = "0x23FBC60", Slot = "4")]
			private bool System.Collections.Generic.IEqualityComparer<System.Guid>.Equals(Guid x, Guid y)
			{
				return default(bool);
			}

			[Token(Token = "0x6000D47")]
			[Address(RVA = "0x23FBC94", Offset = "0x23FBC94", VA = "0x23FBC94", Slot = "5")]
			private int System.Collections.Generic.IEqualityComparer<System.Guid>.GetHashCode(Guid obj)
			{
				return default(int);
			}

			[Token(Token = "0x6000D48")]
			[Address(RVA = "0x23FB880", Offset = "0x23FB880", VA = "0x23FB880")]
			public GuidComparer()
			{
			}
		}

		[Token(Token = "0x20001D6")]
		private class AttachedInstance
		{
			[Token(Token = "0x4000BAF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public EventInstance instance;

			[Token(Token = "0x4000BB0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Transform transform;

			[Token(Token = "0x4000BB1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Rigidbody rigidBody;

			[Token(Token = "0x4000BB2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Rigidbody2D rigidBody2D;

			[Token(Token = "0x6000D49")]
			[Address(RVA = "0x23F8BF0", Offset = "0x23F8BF0", VA = "0x23F8BF0")]
			public AttachedInstance()
			{
			}
		}

		[Token(Token = "0x20001D7")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x14CFF38", Offset = "0x14CFF38")]
		private sealed class <>c__DisplayClass28_0
		{
			[Token(Token = "0x4000BB3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public EventInstance instance;

			[Token(Token = "0x6000D4A")]
			[Address(RVA = "0x23F8BE8", Offset = "0x23F8BE8", VA = "0x23F8BE8")]
			public <>c__DisplayClass28_0()
			{
			}

			[Token(Token = "0x6000D4B")]
			[Address(RVA = "0x23FB910", Offset = "0x23FB910", VA = "0x23FB910")]
			internal bool <AttachInstanceToGameObject>b__0(AttachedInstance x)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x20001D8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x14CFF48", Offset = "0x14CFF48")]
		private sealed class <>c__DisplayClass29_0
		{
			[Token(Token = "0x4000BB4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public EventInstance instance;

			[Token(Token = "0x6000D4C")]
			[Address(RVA = "0x23F8BF8", Offset = "0x23F8BF8", VA = "0x23F8BF8")]
			public <>c__DisplayClass29_0()
			{
			}

			[Token(Token = "0x6000D4D")]
			[Address(RVA = "0x23FB934", Offset = "0x23FB934", VA = "0x23FB934")]
			internal bool <AttachInstanceToGameObject>b__0(AttachedInstance x)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x20001D9")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x14CFF58", Offset = "0x14CFF58")]
		private sealed class <loadFromWeb>d__43 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000BB5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000BB6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000BB7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public string bankPath;

			[Token(Token = "0x4000BB8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public RuntimeManager <>4__this;

			[Token(Token = "0x4000BB9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public string bankName;

			[Token(Token = "0x4000BBA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public bool loadSamples;

			[Token(Token = "0x4000BBB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private UnityWebRequest <www>5__2;

			[Token(Token = "0x170000C9")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000D51")]
				[Address(RVA = "0x23FBBF0", Offset = "0x23FBBF0", VA = "0x23FBBF0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000CA")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000D53")]
				[Address(RVA = "0x23FBC58", Offset = "0x23FBC58", VA = "0x23FBC58", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000D4E")]
			[Address(RVA = "0x23F96F0", Offset = "0x23F96F0", VA = "0x23F96F0")]
			[DebuggerHidden]
			public <loadFromWeb>d__43(int <>1__state)
			{
			}

			[Token(Token = "0x6000D4F")]
			[Address(RVA = "0x23FB958", Offset = "0x23FB958", VA = "0x23FB958", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000D50")]
			[Address(RVA = "0x23FB95C", Offset = "0x23FB95C", VA = "0x23FB95C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000D52")]
			[Address(RVA = "0x23FBBF8", Offset = "0x23FBBF8", VA = "0x23FBBF8", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40008B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static SystemNotInitializedException initException;

		[Token(Token = "0x40008B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static RuntimeManager instance;

		[Token(Token = "0x40008B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private FMODPlatform fmodPlatform;

		[Token(Token = "0x40008B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private FMOD.Studio.System studioSystem;

		[Token(Token = "0x40008B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private FMOD.System coreSystem;

		[Token(Token = "0x40008B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private DSP mixerHead;

		[Token(Token = "0x40008B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private long[] cachedPointers;

		[Token(Token = "0x40008B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Dictionary<string, LoadedBank> loadedBanks;

		[Token(Token = "0x40008BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Dictionary<string, uint> loadedPlugins;

		[Token(Token = "0x40008BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Dictionary<Guid, EventDescription> cachedDescriptions;

		[Token(Token = "0x40008BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private List<AttachedInstance> attachedInstances;

		[Token(Token = "0x40008BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private bool listenerWarningIssued;

		[Token(Token = "0x40008BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x61")]
		protected bool isOverlayEnabled;

		[Token(Token = "0x40008BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private FMODRuntimeManagerOnGUIHelper overlayDrawer;

		[Token(Token = "0x40008C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Rect windowRect;

		[Token(Token = "0x40008C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private string lastDebugText;

		[Token(Token = "0x40008C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private float lastDebugUpdate;

		[Token(Token = "0x40008C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static List<StudioListener> Listeners;

		[Token(Token = "0x40008C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static int numListeners;

		[Token(Token = "0x1700006F")]
		private static RuntimeManager Instance
		{
			[Token(Token = "0x6000B23")]
			[Address(RVA = "0x23F6D6C", Offset = "0x23F6D6C", VA = "0x23F6D6C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000070")]
		public static FMOD.Studio.System StudioSystem
		{
			[Token(Token = "0x6000B24")]
			[Address(RVA = "0x23F4340", Offset = "0x23F4340", VA = "0x23F4340")]
			get
			{
				return default(FMOD.Studio.System);
			}
		}

		[Token(Token = "0x17000071")]
		public static FMOD.System CoreSystem
		{
			[Token(Token = "0x6000B25")]
			[Address(RVA = "0x23F6EA8", Offset = "0x23F6EA8", VA = "0x23F6EA8")]
			get
			{
				return default(FMOD.System);
			}
		}

		[Token(Token = "0x17000072")]
		public static bool IsInitialized
		{
			[Token(Token = "0x6000B4F")]
			[Address(RVA = "0x23FB52C", Offset = "0x23FB52C", VA = "0x23FB52C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000073")]
		public static bool HasBanksLoaded
		{
			[Token(Token = "0x6000B50")]
			[Address(RVA = "0x23FB3E0", Offset = "0x23FB3E0", VA = "0x23FB3E0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000B21")]
		[Address(RVA = "0x23F5AF4", Offset = "0x23F5AF4", VA = "0x23F5AF4")]
		[AttributeAttribute(Name = "MonoPInvokeCallbackAttribute", RVA = "0x14D96D4", Offset = "0x14D96D4")]
		private static RESULT DEBUG_CALLBACK(DEBUG_FLAGS flags, StringWrapper file, int line, StringWrapper func, StringWrapper message)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000B22")]
		[Address(RVA = "0x23F5CB8", Offset = "0x23F5CB8", VA = "0x23F5CB8")]
		public static void Initialise()
		{
		}

		[Token(Token = "0x6000B26")]
		[Address(RVA = "0x23F6F14", Offset = "0x23F6F14", VA = "0x23F6F14")]
		private void CheckInitResult(RESULT result, string cause)
		{
		}

		[Token(Token = "0x6000B27")]
		[Address(RVA = "0x23F66A4", Offset = "0x23F66A4", VA = "0x23F66A4")]
		private RESULT Initialize()
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000B28")]
		[Address(RVA = "0x23F7DC8", Offset = "0x23F7DC8", VA = "0x23F7DC8")]
		public static int AddListener(StudioListener listener)
		{
			return default(int);
		}

		[Token(Token = "0x6000B29")]
		[Address(RVA = "0x23F81D0", Offset = "0x23F81D0", VA = "0x23F81D0")]
		public static bool RemoveListener(StudioListener listener)
		{
			return default(bool);
		}

		[Token(Token = "0x6000B2A")]
		[Address(RVA = "0x23F84F4", Offset = "0x23F84F4", VA = "0x23F84F4")]
		private void Update()
		{
		}

		[Token(Token = "0x6000B2B")]
		[Address(RVA = "0x23F4820", Offset = "0x23F4820", VA = "0x23F4820")]
		public static void AttachInstanceToGameObject(EventInstance instance, Transform transform, Rigidbody rigidBody)
		{
		}

		[Token(Token = "0x6000B2C")]
		[Address(RVA = "0x23F49C4", Offset = "0x23F49C4", VA = "0x23F49C4")]
		public static void AttachInstanceToGameObject(EventInstance instance, Transform transform, Rigidbody2D rigidBody2D)
		{
		}

		[Token(Token = "0x6000B2D")]
		[Address(RVA = "0x23F8C00", Offset = "0x23F8C00", VA = "0x23F8C00")]
		public static void DetachInstanceFromGameObject(EventInstance instance)
		{
		}

		[Token(Token = "0x6000B2E")]
		[Address(RVA = "0x23F58D8", Offset = "0x23F58D8", VA = "0x23F58D8")]
		public void ExecuteOnGUI()
		{
		}

		[Token(Token = "0x6000B2F")]
		[Address(RVA = "0x23F8CFC", Offset = "0x23F8CFC", VA = "0x23F8CFC")]
		private void Start()
		{
		}

		[Token(Token = "0x6000B30")]
		[Address(RVA = "0x23F8E0C", Offset = "0x23F8E0C", VA = "0x23F8E0C")]
		private void DrawDebugOverlay(int windowID)
		{
		}

		[Token(Token = "0x6000B31")]
		[Address(RVA = "0x23F925C", Offset = "0x23F925C", VA = "0x23F925C")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000B32")]
		[Address(RVA = "0x23F92CC", Offset = "0x23F92CC", VA = "0x23F92CC")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000B33")]
		[Address(RVA = "0x23F9370", Offset = "0x23F9370", VA = "0x23F9370")]
		private void OnApplicationPause(bool pauseStatus)
		{
		}

		[Token(Token = "0x6000B34")]
		[Address(RVA = "0x23F94E0", Offset = "0x23F94E0", VA = "0x23F94E0")]
		private void loadedBankRegister(LoadedBank loadedBank, string bankPath, string bankName, bool loadSamples, RESULT loadResult)
		{
		}

		[Token(Token = "0x6000B35")]
		[Address(RVA = "0x23F9658", Offset = "0x23F9658", VA = "0x23F9658")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x14D9738", Offset = "0x14D9738")]
		private IEnumerator loadFromWeb(string bankPath, string bankName, bool loadSamples)
		{
			return null;
		}

		[Token(Token = "0x6000B36")]
		[Address(RVA = "0x23F971C", Offset = "0x23F971C", VA = "0x23F971C")]
		public static void LoadBank(string bankName, bool loadSamples = false)
		{
		}

		[Token(Token = "0x6000B37")]
		[Address(RVA = "0x23F9C28", Offset = "0x23F9C28", VA = "0x23F9C28")]
		public static void LoadBank(TextAsset asset, bool loadSamples = false)
		{
		}

		[Token(Token = "0x6000B38")]
		[Address(RVA = "0x23F7950", Offset = "0x23F7950", VA = "0x23F7950")]
		private void LoadBanks(Settings fmodSettings)
		{
		}

		[Token(Token = "0x6000B39")]
		[Address(RVA = "0x23F9EE8", Offset = "0x23F9EE8", VA = "0x23F9EE8")]
		public static void UnloadBank(string bankName)
		{
		}

		[Token(Token = "0x6000B3A")]
		[Address(RVA = "0x23FA020", Offset = "0x23FA020", VA = "0x23FA020")]
		public static bool AnyBankLoading()
		{
			return default(bool);
		}

		[Token(Token = "0x6000B3B")]
		[Address(RVA = "0x23F9E78", Offset = "0x23F9E78", VA = "0x23F9E78")]
		public static void WaitForAllLoads()
		{
		}

		[Token(Token = "0x6000B3C")]
		[Address(RVA = "0x23FA170", Offset = "0x23FA170", VA = "0x23FA170")]
		public static Guid PathToGUID(string path)
		{
			return default(Guid);
		}

		[Token(Token = "0x6000B3D")]
		[Address(RVA = "0x23F4710", Offset = "0x23F4710", VA = "0x23F4710")]
		public static EventInstance CreateInstance(string path)
		{
			return default(EventInstance);
		}

		[Token(Token = "0x6000B3E")]
		[Address(RVA = "0x23FA298", Offset = "0x23FA298", VA = "0x23FA298")]
		public static EventInstance CreateInstance(Guid guid)
		{
			return default(EventInstance);
		}

		[Token(Token = "0x6000B3F")]
		[Address(RVA = "0x23FA538", Offset = "0x23FA538", VA = "0x23FA538")]
		public static void PlayOneShot(string path, [Optional] Vector3 position)
		{
		}

		[Token(Token = "0x6000B40")]
		[Address(RVA = "0x23FA69C", Offset = "0x23FA69C", VA = "0x23FA69C")]
		public static void PlayOneShot(Guid guid, [Optional] Vector3 position)
		{
		}

		[Token(Token = "0x6000B41")]
		[Address(RVA = "0x23FA77C", Offset = "0x23FA77C", VA = "0x23FA77C")]
		public static void PlayOneShotAttached(string path, GameObject gameObject)
		{
		}

		[Token(Token = "0x6000B42")]
		[Address(RVA = "0x23FA8C4", Offset = "0x23FA8C4", VA = "0x23FA8C4")]
		public static void PlayOneShotAttached(Guid guid, GameObject gameObject)
		{
		}

		[Token(Token = "0x6000B43")]
		[Address(RVA = "0x23FA9A8", Offset = "0x23FA9A8", VA = "0x23FA9A8")]
		public static EventDescription GetEventDescription(string path)
		{
			return default(EventDescription);
		}

		[Token(Token = "0x6000B44")]
		[Address(RVA = "0x23FA334", Offset = "0x23FA334", VA = "0x23FA334")]
		public static EventDescription GetEventDescription(Guid guid)
		{
			return default(EventDescription);
		}

		[Token(Token = "0x6000B45")]
		[Address(RVA = "0x23FAAB8", Offset = "0x23FAAB8", VA = "0x23FAAB8")]
		public static void SetListenerLocation(GameObject gameObject, [Optional] Rigidbody rigidBody)
		{
		}

		[Token(Token = "0x6000B46")]
		[Address(RVA = "0x23FAC90", Offset = "0x23FAC90", VA = "0x23FAC90")]
		public static void SetListenerLocation(GameObject gameObject, Rigidbody2D rigidBody2D)
		{
		}

		[Token(Token = "0x6000B47")]
		[Address(RVA = "0x23FAE74", Offset = "0x23FAE74", VA = "0x23FAE74")]
		public static void SetListenerLocation(Transform transform)
		{
		}

		[Token(Token = "0x6000B48")]
		[Address(RVA = "0x23FAFB8", Offset = "0x23FAFB8", VA = "0x23FAFB8")]
		public static void SetListenerLocation(int listenerIndex, GameObject gameObject, [Optional] Rigidbody rigidBody)
		{
		}

		[Token(Token = "0x6000B49")]
		[Address(RVA = "0x23FB064", Offset = "0x23FB064", VA = "0x23FB064")]
		public static void SetListenerLocation(int listenerIndex, GameObject gameObject, Rigidbody2D rigidBody2D)
		{
		}

		[Token(Token = "0x6000B4A")]
		[Address(RVA = "0x23FB110", Offset = "0x23FB110", VA = "0x23FB110")]
		public static void SetListenerLocation(int listenerIndex, Transform transform)
		{
		}

		[Token(Token = "0x6000B4B")]
		[Address(RVA = "0x23FB1B4", Offset = "0x23FB1B4", VA = "0x23FB1B4")]
		public static Bus GetBus(string path)
		{
			return default(Bus);
		}

		[Token(Token = "0x6000B4C")]
		[Address(RVA = "0x23FB274", Offset = "0x23FB274", VA = "0x23FB274")]
		public static VCA GetVCA(string path)
		{
			return default(VCA);
		}

		[Token(Token = "0x6000B4D")]
		[Address(RVA = "0x23F941C", Offset = "0x23F941C", VA = "0x23F941C")]
		public static void PauseAllEvents(bool paused)
		{
		}

		[Token(Token = "0x6000B4E")]
		[Address(RVA = "0x23FB468", Offset = "0x23FB468", VA = "0x23FB468")]
		public static void MuteAllEvents(bool muted)
		{
		}

		[Token(Token = "0x6000B51")]
		[Address(RVA = "0x23FB610", Offset = "0x23FB610", VA = "0x23FB610")]
		public static bool HasBankLoaded(string loadedBank)
		{
			return default(bool);
		}

		[Token(Token = "0x6000B52")]
		[Address(RVA = "0x23F77AC", Offset = "0x23F77AC", VA = "0x23F77AC")]
		private void LoadPlugins(Settings fmodSettings)
		{
		}

		[Token(Token = "0x6000B53")]
		[Address(RVA = "0x23F769C", Offset = "0x23F769C", VA = "0x23F769C")]
		private void SetThreadAffinity()
		{
		}

		[Token(Token = "0x6000B54")]
		[Address(RVA = "0x23FB718", Offset = "0x23FB718", VA = "0x23FB718")]
		public RuntimeManager()
		{
		}
	}
	[Token(Token = "0x200016C")]
	public class EventNotFoundException : Exception
	{
		[Token(Token = "0x40008C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public Guid Guid;

		[Token(Token = "0x40008C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public string Path;

		[Token(Token = "0x6000B56")]
		[Address(RVA = "0x23F56C4", Offset = "0x23F56C4", VA = "0x23F56C4")]
		public EventNotFoundException(string path)
		{
		}

		[Token(Token = "0x6000B57")]
		[Address(RVA = "0x23F5770", Offset = "0x23F5770", VA = "0x23F5770")]
		public EventNotFoundException(Guid guid)
		{
		}
	}
	[Token(Token = "0x200016D")]
	public class BusNotFoundException : Exception
	{
		[Token(Token = "0x40008C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public string Path;

		[Token(Token = "0x6000B58")]
		[Address(RVA = "0x23F5378", Offset = "0x23F5378", VA = "0x23F5378")]
		public BusNotFoundException(string path)
		{
		}
	}
	[Token(Token = "0x200016E")]
	public class VCANotFoundException : Exception
	{
		[Token(Token = "0x40008C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public string Path;

		[Token(Token = "0x6000B59")]
		[Address(RVA = "0x23FB334", Offset = "0x23FB334", VA = "0x23FB334")]
		public VCANotFoundException(string path)
		{
		}
	}
	[Token(Token = "0x200016F")]
	public class BankLoadException : Exception
	{
		[Token(Token = "0x40008C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public string Path;

		[Token(Token = "0x40008CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public RESULT Result;

		[Token(Token = "0x6000B5A")]
		[Address(RVA = "0x23F51B8", Offset = "0x23F51B8", VA = "0x23F51B8")]
		public BankLoadException(string path, RESULT result)
		{
		}

		[Token(Token = "0x6000B5B")]
		[Address(RVA = "0x23F52C0", Offset = "0x23F52C0", VA = "0x23F52C0")]
		public BankLoadException(string path, string error)
		{
		}
	}
	[Token(Token = "0x2000170")]
	public class SystemNotInitializedException : Exception
	{
		[Token(Token = "0x40008CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public RESULT Result;

		[Token(Token = "0x40008CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public string Location;

		[Token(Token = "0x6000B5C")]
		[Address(RVA = "0x23F6C64", Offset = "0x23F6C64", VA = "0x23F6C64")]
		public SystemNotInitializedException(RESULT result, string location)
		{
		}

		[Token(Token = "0x6000B5D")]
		[Address(RVA = "0x23F6BE0", Offset = "0x23F6BE0", VA = "0x23F6BE0")]
		public SystemNotInitializedException(Exception inner)
		{
		}
	}
	[Token(Token = "0x2000171")]
	public enum EmitterGameEvent
	{
		[Token(Token = "0x40008CE")]
		None,
		[Token(Token = "0x40008CF")]
		ObjectStart,
		[Token(Token = "0x40008D0")]
		ObjectDestroy,
		[Token(Token = "0x40008D1")]
		TriggerEnter,
		[Token(Token = "0x40008D2")]
		TriggerExit,
		[Token(Token = "0x40008D3")]
		TriggerEnter2D,
		[Token(Token = "0x40008D4")]
		TriggerExit2D,
		[Token(Token = "0x40008D5")]
		CollisionEnter,
		[Token(Token = "0x40008D6")]
		CollisionExit,
		[Token(Token = "0x40008D7")]
		CollisionEnter2D,
		[Token(Token = "0x40008D8")]
		CollisionExit2D,
		[Token(Token = "0x40008D9")]
		ObjectEnable,
		[Token(Token = "0x40008DA")]
		ObjectDisable,
		[Token(Token = "0x40008DB")]
		MouseEnter,
		[Token(Token = "0x40008DC")]
		MouseExit,
		[Token(Token = "0x40008DD")]
		MouseDown,
		[Token(Token = "0x40008DE")]
		MouseUp
	}
	[Token(Token = "0x2000172")]
	public enum LoaderGameEvent
	{
		[Token(Token = "0x40008E0")]
		None,
		[Token(Token = "0x40008E1")]
		ObjectStart,
		[Token(Token = "0x40008E2")]
		ObjectDestroy,
		[Token(Token = "0x40008E3")]
		TriggerEnter,
		[Token(Token = "0x40008E4")]
		TriggerExit,
		[Token(Token = "0x40008E5")]
		TriggerEnter2D,
		[Token(Token = "0x40008E6")]
		TriggerExit2D
	}
	[Token(Token = "0x2000173")]
	public static class RuntimeUtils
	{
		[Token(Token = "0x40008E7")]
		private const string BankExtension = ".bank";

		[Token(Token = "0x6000B5E")]
		[Address(RVA = "0x23FBCBC", Offset = "0x23FBCBC", VA = "0x23FBCBC")]
		public static string GetCommonPlatformPath(string path)
		{
			return null;
		}

		[Token(Token = "0x6000B5F")]
		[Address(RVA = "0x23FBD0C", Offset = "0x23FBD0C", VA = "0x23FBD0C")]
		public static VECTOR ToFMODVector(this Vector3 vec)
		{
			return default(VECTOR);
		}

		[Token(Token = "0x6000B60")]
		[Address(RVA = "0x23F4B68", Offset = "0x23F4B68", VA = "0x23F4B68")]
		public static ATTRIBUTES_3D To3DAttributes(this Vector3 pos)
		{
			return default(ATTRIBUTES_3D);
		}

		[Token(Token = "0x6000B61")]
		[Address(RVA = "0x23FAF0C", Offset = "0x23FAF0C", VA = "0x23FAF0C")]
		public static ATTRIBUTES_3D To3DAttributes(this Transform transform)
		{
			return default(ATTRIBUTES_3D);
		}

		[Token(Token = "0x6000B62")]
		[Address(RVA = "0x23F8994", Offset = "0x23F8994", VA = "0x23F8994")]
		public static ATTRIBUTES_3D To3DAttributes(Transform transform, [Optional] Rigidbody rigidbody)
		{
			return default(ATTRIBUTES_3D);
		}

		[Token(Token = "0x6000B63")]
		[Address(RVA = "0x23FAB60", Offset = "0x23FAB60", VA = "0x23FAB60")]
		public static ATTRIBUTES_3D To3DAttributes(GameObject go, [Optional] Rigidbody rigidbody)
		{
			return default(ATTRIBUTES_3D);
		}

		[Token(Token = "0x6000B64")]
		[Address(RVA = "0x23F8AB8", Offset = "0x23F8AB8", VA = "0x23F8AB8")]
		public static ATTRIBUTES_3D To3DAttributes(Transform transform, Rigidbody2D rigidbody)
		{
			return default(ATTRIBUTES_3D);
		}

		[Token(Token = "0x6000B65")]
		[Address(RVA = "0x23FAD38", Offset = "0x23FAD38", VA = "0x23FAD38")]
		public static ATTRIBUTES_3D To3DAttributes(GameObject go, Rigidbody2D rigidbody)
		{
			return default(ATTRIBUTES_3D);
		}

		[Token(Token = "0x6000B66")]
		[Address(RVA = "0x23F71D8", Offset = "0x23F71D8", VA = "0x23F71D8")]
		internal static FMODPlatform GetCurrentPlatform()
		{
			return default(FMODPlatform);
		}

		[Token(Token = "0x6000B67")]
		[Address(RVA = "0x23F9AF4", Offset = "0x23F9AF4", VA = "0x23F9AF4")]
		internal static string GetBankPath(string bankName)
		{
			return null;
		}

		[Token(Token = "0x6000B68")]
		[Address(RVA = "0x23FB69C", Offset = "0x23FB69C", VA = "0x23FB69C")]
		internal static string GetPluginPath(string pluginName)
		{
			return null;
		}

		[Token(Token = "0x6000B69")]
		[Address(RVA = "0x23F651C", Offset = "0x23F651C", VA = "0x23F651C")]
		public static void EnforceLibraryOrder()
		{
		}

		[Token(Token = "0x6000B6A")]
		[Address(RVA = "0x23F6404", Offset = "0x23F6404", VA = "0x23F6404")]
		public static bool VerifyPlatformLibsExist()
		{
			return default(bool);
		}
	}
	[Serializable]
	[Token(Token = "0x2000174")]
	public enum FMODPlatform
	{
		[Token(Token = "0x40008E9")]
		None,
		[Token(Token = "0x40008EA")]
		PlayInEditor,
		[Token(Token = "0x40008EB")]
		Default,
		[Token(Token = "0x40008EC")]
		Desktop,
		[Token(Token = "0x40008ED")]
		Mobile,
		[Token(Token = "0x40008EE")]
		MobileHigh,
		[Token(Token = "0x40008EF")]
		MobileLow,
		[Token(Token = "0x40008F0")]
		Console,
		[Token(Token = "0x40008F1")]
		Windows,
		[Token(Token = "0x40008F2")]
		Mac,
		[Token(Token = "0x40008F3")]
		Linux,
		[Token(Token = "0x40008F4")]
		iOS,
		[Token(Token = "0x40008F5")]
		Android,
		[Token(Token = "0x40008F6")]
		Deprecated_1,
		[Token(Token = "0x40008F7")]
		XboxOne,
		[Token(Token = "0x40008F8")]
		PS4,
		[Token(Token = "0x40008F9")]
		Deprecated_2,
		[Token(Token = "0x40008FA")]
		Deprecated_3,
		[Token(Token = "0x40008FB")]
		AppleTV,
		[Token(Token = "0x40008FC")]
		UWP,
		[Token(Token = "0x40008FD")]
		Switch,
		[Token(Token = "0x40008FE")]
		WebGL,
		[Token(Token = "0x40008FF")]
		Stadia,
		[Token(Token = "0x4000900")]
		Reserved_1,
		[Token(Token = "0x4000901")]
		Reserved_2,
		[Token(Token = "0x4000902")]
		Count
	}
	[Serializable]
	[Token(Token = "0x2000175")]
	public enum ImportType
	{
		[Token(Token = "0x4000904")]
		StreamingAssets,
		[Token(Token = "0x4000905")]
		AssetBundle,
		[Token(Token = "0x4000906")]
		None
	}
	[Serializable]
	[Token(Token = "0x2000176")]
	public enum BankLoadType
	{
		[Token(Token = "0x4000908")]
		All,
		[Token(Token = "0x4000909")]
		Specified,
		[Token(Token = "0x400090A")]
		None
	}
	[Token(Token = "0x2000177")]
	public class PlatformSettingBase
	{
		[Token(Token = "0x400090B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public FMODPlatform Platform;

		[Token(Token = "0x6000B6B")]
		[Address(RVA = "0x23F5A9C", Offset = "0x23F5A9C", VA = "0x23F5A9C")]
		public PlatformSettingBase()
		{
		}
	}
	[Token(Token = "0x2000178")]
	public class PlatformSetting<T> : PlatformSettingBase
	{
		[Token(Token = "0x400090C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public T Value;

		[Token(Token = "0x6000B6C")]
		public PlatformSetting()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000179")]
	public class PlatformIntSetting : PlatformSetting<int>
	{
		[Token(Token = "0x6000B6D")]
		[Address(RVA = "0x23F5A4C", Offset = "0x23F5A4C", VA = "0x23F5A4C")]
		public PlatformIntSetting()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200017A")]
	public class PlatformStringSetting : PlatformSetting<string>
	{
		[Token(Token = "0x6000B6E")]
		[Address(RVA = "0x23F5AA4", Offset = "0x23F5AA4", VA = "0x23F5AA4")]
		public PlatformStringSetting()
		{
		}
	}
	[Token(Token = "0x200017B")]
	public enum TriStateBool
	{
		[Token(Token = "0x400090E")]
		Disabled,
		[Token(Token = "0x400090F")]
		Enabled,
		[Token(Token = "0x4000910")]
		Development
	}
	[Serializable]
	[Token(Token = "0x200017C")]
	public class PlatformBoolSetting : PlatformSetting<TriStateBool>
	{
		[Token(Token = "0x6000B6F")]
		[Address(RVA = "0x23F59FC", Offset = "0x23F59FC", VA = "0x23F59FC")]
		public PlatformBoolSetting()
		{
		}
	}
	[Token(Token = "0x200017D")]
	public class Settings : ScriptableObject
	{
		[Token(Token = "0x20001DA")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x14CFF68", Offset = "0x14CFF68")]
		private sealed class <>c__DisplayClass36_0<T> where T : PlatformSettingBase
		{
			[Token(Token = "0x4000BBC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public FMODPlatform platform;

			[Token(Token = "0x6000D54")]
			public <>c__DisplayClass36_0()
			{
			}

			[Token(Token = "0x6000D55")]
			internal bool <HasSetting>b__0(T x)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x20001DB")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x14CFF78", Offset = "0x14CFF78")]
		private sealed class <>c__DisplayClass37_0<T, U> where T : PlatformSetting<U>
		{
			[Token(Token = "0x4000BBD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public FMODPlatform platform;

			[Token(Token = "0x6000D56")]
			public <>c__DisplayClass37_0()
			{
			}

			[Token(Token = "0x6000D57")]
			internal bool <GetSetting>b__0(T x)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x20001DC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x14CFF88", Offset = "0x14CFF88")]
		private sealed class <>c__DisplayClass38_0<T, U> where T : PlatformSetting<U>, new()
		{
			[Token(Token = "0x4000BBE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public FMODPlatform platform;

			[Token(Token = "0x6000D58")]
			public <>c__DisplayClass38_0()
			{
			}

			[Token(Token = "0x6000D59")]
			internal bool <SetSetting>b__0(T x)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x20001DD")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x14CFF98", Offset = "0x14CFF98")]
		private sealed class <>c__DisplayClass39_0<T> where T : PlatformSettingBase
		{
			[Token(Token = "0x4000BBF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public FMODPlatform platform;

			[Token(Token = "0x6000D5A")]
			public <>c__DisplayClass39_0()
			{
			}

			[Token(Token = "0x6000D5B")]
			internal bool <RemoveSetting>b__0(T x)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x4000911")]
		private const string SettingsAssetName = "FMODStudioSettings";

		[Token(Token = "0x4000912")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static Settings instance;

		[Token(Token = "0x4000913")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		public bool HasSourceProject;

		[Token(Token = "0x4000914")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		[SerializeField]
		public bool HasPlatforms;

		[Token(Token = "0x4000915")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private string sourceProjectPath;

		[Token(Token = "0x4000916")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private string sourceBankPath;

		[Token(Token = "0x4000917")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		public string SourceBankPathUnformatted;

		[Token(Token = "0x4000918")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		public bool AutomaticEventLoading;

		[Token(Token = "0x4000919")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[SerializeField]
		public BankLoadType BankLoadType;

		[Token(Token = "0x400091A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		public bool AutomaticSampleLoading;

		[Token(Token = "0x400091B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		public string EncryptionKey;

		[Token(Token = "0x400091C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		public ImportType ImportType;

		[Token(Token = "0x400091D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		public string TargetAssetPath;

		[Token(Token = "0x400091E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		public DEBUG_FLAGS LoggingLevel;

		[Token(Token = "0x400091F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		public List<PlatformIntSetting> SpeakerModeSettings;

		[Token(Token = "0x4000920")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		public List<PlatformIntSetting> SampleRateSettings;

		[Token(Token = "0x4000921")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[SerializeField]
		public List<PlatformBoolSetting> LiveUpdateSettings;

		[Token(Token = "0x4000922")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[SerializeField]
		public List<PlatformBoolSetting> OverlaySettings;

		[Token(Token = "0x4000923")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[SerializeField]
		public List<PlatformBoolSetting> LoggingSettings;

		[Token(Token = "0x4000924")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[SerializeField]
		public List<PlatformStringSetting> BankDirectorySettings;

		[Token(Token = "0x4000925")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		[SerializeField]
		public List<PlatformIntSetting> VirtualChannelSettings;

		[Token(Token = "0x4000926")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		[SerializeField]
		public List<PlatformIntSetting> RealChannelSettings;

		[Token(Token = "0x4000927")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[SerializeField]
		public List<string> Plugins;

		[Token(Token = "0x4000928")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[SerializeField]
		public List<string> MasterBanks;

		[Token(Token = "0x4000929")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		[SerializeField]
		public List<string> Banks;

		[Token(Token = "0x400092A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[SerializeField]
		public List<string> BanksToLoad;

		[Token(Token = "0x400092B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[SerializeField]
		public ushort LiveUpdatePort;

		[Token(Token = "0x17000074")]
		public static Settings Instance
		{
			[Token(Token = "0x6000B70")]
			[Address(RVA = "0x23F6FC8", Offset = "0x23F6FC8", VA = "0x23F6FC8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000075")]
		public string SourceProjectPath
		{
			[Token(Token = "0x6000B71")]
			[Address(RVA = "0x23FBD10", Offset = "0x23FBD10", VA = "0x23FBD10")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000B72")]
			[Address(RVA = "0x23FBD18", Offset = "0x23FBD18", VA = "0x23FBD18")]
			set
			{
			}
		}

		[Token(Token = "0x17000076")]
		public string SourceBankPath
		{
			[Token(Token = "0x6000B73")]
			[Address(RVA = "0x23FBD20", Offset = "0x23FBD20", VA = "0x23FBD20")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000B74")]
			[Address(RVA = "0x23FBD28", Offset = "0x23FBD28", VA = "0x23FBD28")]
			set
			{
			}
		}

		[Token(Token = "0x6000B75")]
		[Address(RVA = "0x23FBD30", Offset = "0x23FBD30", VA = "0x23FBD30")]
		public static FMODPlatform GetParent(FMODPlatform platform)
		{
			return default(FMODPlatform);
		}

		[Token(Token = "0x6000B76")]
		public static bool HasSetting<T>(List<T> list, FMODPlatform platform) where T : PlatformSettingBase
		{
			return default(bool);
		}

		[Token(Token = "0x6000B77")]
		public static U GetSetting<T, U>(List<T> list, FMODPlatform platform, U def) where T : PlatformSetting<U>
		{
			return (U)null;
		}

		[Token(Token = "0x6000B78")]
		public static void SetSetting<T, U>(List<T> list, FMODPlatform platform, U value) where T : PlatformSetting<U>, new()
		{
		}

		[Token(Token = "0x6000B79")]
		public static void RemoveSetting<T>(List<T> list, FMODPlatform platform) where T : PlatformSettingBase
		{
		}

		[Token(Token = "0x6000B7A")]
		[Address(RVA = "0x23F7718", Offset = "0x23F7718", VA = "0x23F7718")]
		public bool IsLiveUpdateEnabled(FMODPlatform platform)
		{
			return default(bool);
		}

		[Token(Token = "0x6000B7B")]
		[Address(RVA = "0x23F8D78", Offset = "0x23F8D78", VA = "0x23F8D78")]
		public bool IsOverlayEnabled(FMODPlatform platform)
		{
			return default(bool);
		}

		[Token(Token = "0x6000B7C")]
		[Address(RVA = "0x23F7504", Offset = "0x23F7504", VA = "0x23F7504")]
		public int GetRealChannels(FMODPlatform platform)
		{
			return default(int);
		}

		[Token(Token = "0x6000B7D")]
		[Address(RVA = "0x23F758C", Offset = "0x23F758C", VA = "0x23F758C")]
		public int GetVirtualChannels(FMODPlatform platform)
		{
			return default(int);
		}

		[Token(Token = "0x6000B7E")]
		[Address(RVA = "0x23F7614", Offset = "0x23F7614", VA = "0x23F7614")]
		public int GetSpeakerMode(FMODPlatform platform)
		{
			return default(int);
		}

		[Token(Token = "0x6000B7F")]
		[Address(RVA = "0x23F747C", Offset = "0x23F747C", VA = "0x23F747C")]
		public int GetSampleRate(FMODPlatform platform)
		{
			return default(int);
		}

		[Token(Token = "0x6000B80")]
		[Address(RVA = "0x23FBD54", Offset = "0x23FBD54", VA = "0x23FBD54")]
		public string GetBankPlatform(FMODPlatform platform)
		{
			return null;
		}

		[Token(Token = "0x6000B81")]
		[Address(RVA = "0x23FBE00", Offset = "0x23FBE00", VA = "0x23FBE00")]
		private Settings()
		{
		}
	}
	[Token(Token = "0x200017E")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x14CFDC0", Offset = "0x14CFDC0")]
	public class StudioBankLoader : MonoBehaviour
	{
		[Token(Token = "0x400092C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public LoaderGameEvent LoadEvent;

		[Token(Token = "0x400092D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public LoaderGameEvent UnloadEvent;

		[Token(Token = "0x400092E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[BankRef]
		public List<string> Banks;

		[Token(Token = "0x400092F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string CollisionTag;

		[Token(Token = "0x4000930")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool PreloadSamples;

		[Token(Token = "0x4000931")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
		private bool isQuitting;

		[Token(Token = "0x6000B83")]
		[Address(RVA = "0x23FC130", Offset = "0x23FC130", VA = "0x23FC130")]
		private void HandleGameEvent(LoaderGameEvent gameEvent)
		{
		}

		[Token(Token = "0x6000B84")]
		[Address(RVA = "0x23FC4C4", Offset = "0x23FC4C4", VA = "0x23FC4C4")]
		private void Start()
		{
		}

		[Token(Token = "0x6000B85")]
		[Address(RVA = "0x23FC4EC", Offset = "0x23FC4EC", VA = "0x23FC4EC")]
		private void OnApplicationQuit()
		{
		}

		[Token(Token = "0x6000B86")]
		[Address(RVA = "0x23FC4F8", Offset = "0x23FC4F8", VA = "0x23FC4F8")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000B87")]
		[Address(RVA = "0x23FC50C", Offset = "0x23FC50C", VA = "0x23FC50C")]
		private void OnTriggerEnter(Collider other)
		{
		}

		[Token(Token = "0x6000B88")]
		[Address(RVA = "0x23FC56C", Offset = "0x23FC56C", VA = "0x23FC56C")]
		private void OnTriggerExit(Collider other)
		{
		}

		[Token(Token = "0x6000B89")]
		[Address(RVA = "0x23FC5CC", Offset = "0x23FC5CC", VA = "0x23FC5CC")]
		private void OnTriggerEnter2D(Collider2D other)
		{
		}

		[Token(Token = "0x6000B8A")]
		[Address(RVA = "0x23FC62C", Offset = "0x23FC62C", VA = "0x23FC62C")]
		private void OnTriggerExit2D(Collider2D other)
		{
		}

		[Token(Token = "0x6000B8B")]
		[Address(RVA = "0x23FC180", Offset = "0x23FC180", VA = "0x23FC180")]
		public void Load()
		{
		}

		[Token(Token = "0x6000B8C")]
		[Address(RVA = "0x23FC3B0", Offset = "0x23FC3B0", VA = "0x23FC3B0")]
		public void Unload()
		{
		}

		[Token(Token = "0x6000B8D")]
		[Address(RVA = "0x23FC68C", Offset = "0x23FC68C", VA = "0x23FC68C")]
		public StudioBankLoader()
		{
		}
	}
	[Token(Token = "0x200017F")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x14CFDF8", Offset = "0x14CFDF8")]
	public class StudioEventEmitter : EventHandler
	{
		[Token(Token = "0x4000932")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[EventRef]
		public string Event;

		[Token(Token = "0x4000933")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public EmitterGameEvent PlayEvent;

		[Token(Token = "0x4000934")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public EmitterGameEvent StopEvent;

		[Token(Token = "0x4000935")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool AllowFadeout;

		[Token(Token = "0x4000936")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
		public bool TriggerOnce;

		[Token(Token = "0x4000937")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x32")]
		public bool Preload;

		[Token(Token = "0x4000938")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public ParamRef[] Params;

		[Token(Token = "0x4000939")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public bool OverrideAttenuation;

		[Token(Token = "0x400093A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float OverrideMinDistance;

		[Token(Token = "0x400093B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float OverrideMaxDistance;

		[Token(Token = "0x400093C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		protected EventDescription eventDescription;

		[Token(Token = "0x400093D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		protected EventInstance instance;

		[Token(Token = "0x400093E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private bool hasTriggered;

		[Token(Token = "0x400093F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x61")]
		private bool isQuitting;

		[Token(Token = "0x4000940")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x62")]
		private bool isOneshot;

		[Token(Token = "0x4000941")]
		private const string SnapshotString = "snapshot";

		[Token(Token = "0x17000077")]
		public EventDescription EventDescription
		{
			[Token(Token = "0x6000B8E")]
			[Address(RVA = "0x23FC694", Offset = "0x23FC694", VA = "0x23FC694")]
			get
			{
				return default(EventDescription);
			}
		}

		[Token(Token = "0x17000078")]
		public EventInstance EventInstance
		{
			[Token(Token = "0x6000B8F")]
			[Address(RVA = "0x23FC69C", Offset = "0x23FC69C", VA = "0x23FC69C")]
			get
			{
				return default(EventInstance);
			}
		}

		[Token(Token = "0x6000B90")]
		[Address(RVA = "0x23FC6A4", Offset = "0x23FC6A4", VA = "0x23FC6A4")]
		private void Start()
		{
		}

		[Token(Token = "0x6000B91")]
		[Address(RVA = "0x23FC8B0", Offset = "0x23FC8B0", VA = "0x23FC8B0")]
		private void OnApplicationQuit()
		{
		}

		[Token(Token = "0x6000B92")]
		[Address(RVA = "0x23FC8BC", Offset = "0x23FC8BC", VA = "0x23FC8BC")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000B93")]
		[Address(RVA = "0x23FC9B0", Offset = "0x23FC9B0", VA = "0x23FC9B0", Slot = "4")]
		protected override void HandleGameEvent(EmitterGameEvent gameEvent)
		{
		}

		[Token(Token = "0x6000B94")]
		[Address(RVA = "0x23FC78C", Offset = "0x23FC78C", VA = "0x23FC78C")]
		private void Lookup()
		{
		}

		[Token(Token = "0x6000B95")]
		[Address(RVA = "0x23FCA00", Offset = "0x23FCA00", VA = "0x23FCA00")]
		public void Play()
		{
		}

		[Token(Token = "0x6000B96")]
		[Address(RVA = "0x23FCD34", Offset = "0x23FCD34", VA = "0x23FCD34")]
		public void Stop()
		{
		}

		[Token(Token = "0x6000B97")]
		[Address(RVA = "0x23FCD98", Offset = "0x23FCD98", VA = "0x23FCD98")]
		public void SetParameter(string name, float value, bool ignoreseekspeed = false)
		{
		}

		[Token(Token = "0x6000B98")]
		[Address(RVA = "0x23FCE08", Offset = "0x23FCE08", VA = "0x23FCE08")]
		public void SetParameter(PARAMETER_ID id, float value, bool ignoreseekspeed = false)
		{
		}

		[Token(Token = "0x6000B99")]
		[Address(RVA = "0x23FCE78", Offset = "0x23FCE78", VA = "0x23FCE78")]
		public bool IsPlaying()
		{
			return default(bool);
		}

		[Token(Token = "0x6000B9A")]
		[Address(RVA = "0x23FCECC", Offset = "0x23FCECC", VA = "0x23FCECC")]
		public StudioEventEmitter()
		{
		}
	}
	[Token(Token = "0x2000180")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x14CFE30", Offset = "0x14CFE30")]
	public class StudioGlobalParameterTrigger : EventHandler
	{
		[Token(Token = "0x4000942")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[ParamRef]
		public string parameter;

		[Token(Token = "0x4000943")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public EmitterGameEvent TriggerEvent;

		[Token(Token = "0x4000944")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float value;

		[Token(Token = "0x4000945")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private PARAMETER_DESCRIPTION parameterDescription;

		[Token(Token = "0x17000079")]
		public PARAMETER_DESCRIPTION ParameterDesctription
		{
			[Token(Token = "0x6000B9B")]
			[Address(RVA = "0x23FCF48", Offset = "0x23FCF48", VA = "0x23FCF48")]
			get
			{
				return default(PARAMETER_DESCRIPTION);
			}
		}

		[Token(Token = "0x6000B9C")]
		[Address(RVA = "0x23FCF5C", Offset = "0x23FCF5C", VA = "0x23FCF5C")]
		private RESULT Lookup()
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000B9D")]
		[Address(RVA = "0x23FCFE4", Offset = "0x23FCFE4", VA = "0x23FCFE4")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000B9E")]
		[Address(RVA = "0x23FD028", Offset = "0x23FD028", VA = "0x23FD028", Slot = "4")]
		protected override void HandleGameEvent(EmitterGameEvent gameEvent)
		{
		}

		[Token(Token = "0x6000B9F")]
		[Address(RVA = "0x23FD03C", Offset = "0x23FD03C", VA = "0x23FD03C")]
		public void TriggerParameters()
		{
		}

		[Token(Token = "0x6000BA0")]
		[Address(RVA = "0x23FD150", Offset = "0x23FD150", VA = "0x23FD150")]
		public StudioGlobalParameterTrigger()
		{
		}
	}
	[Token(Token = "0x2000181")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x14CFE68", Offset = "0x14CFE68")]
	public class StudioListener : MonoBehaviour
	{
		[Token(Token = "0x4000946")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Rigidbody rigidBody;

		[Token(Token = "0x4000947")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Rigidbody2D rigidBody2D;

		[Token(Token = "0x4000948")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public int ListenerNumber;

		[Token(Token = "0x6000BA1")]
		[Address(RVA = "0x23FD154", Offset = "0x23FD154", VA = "0x23FD154")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000BA2")]
		[Address(RVA = "0x23FD210", Offset = "0x23FD210", VA = "0x23FD210")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000BA3")]
		[Address(RVA = "0x23FD274", Offset = "0x23FD274", VA = "0x23FD274")]
		private void Update()
		{
		}

		[Token(Token = "0x6000BA4")]
		[Address(RVA = "0x23FD288", Offset = "0x23FD288", VA = "0x23FD288")]
		private void SetListenerLocation()
		{
		}

		[Token(Token = "0x6000BA5")]
		[Address(RVA = "0x23FD384", Offset = "0x23FD384", VA = "0x23FD384")]
		public StudioListener()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000182")]
	public class EmitterRef
	{
		[Token(Token = "0x4000949")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public StudioEventEmitter Target;

		[Token(Token = "0x400094A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public ParamRef[] Params;

		[Token(Token = "0x6000BA6")]
		[Address(RVA = "0x23F5424", Offset = "0x23F5424", VA = "0x23F5424")]
		public EmitterRef()
		{
		}
	}
	[Token(Token = "0x2000183")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x14CFEA0", Offset = "0x14CFEA0")]
	public class StudioParameterTrigger : EventHandler
	{
		[Token(Token = "0x400094B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public EmitterRef[] Emitters;

		[Token(Token = "0x400094C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public EmitterGameEvent TriggerEvent;

		[Token(Token = "0x6000BA7")]
		[Address(RVA = "0x23FD394", Offset = "0x23FD394", VA = "0x23FD394")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000BA8")]
		[Address(RVA = "0x23FD584", Offset = "0x23FD584", VA = "0x23FD584", Slot = "4")]
		protected override void HandleGameEvent(EmitterGameEvent gameEvent)
		{
		}

		[Token(Token = "0x6000BA9")]
		[Address(RVA = "0x23FD598", Offset = "0x23FD598", VA = "0x23FD598")]
		public void TriggerParameters()
		{
		}

		[Token(Token = "0x6000BAA")]
		[Address(RVA = "0x23FD730", Offset = "0x23FD730", VA = "0x23FD730")]
		public StudioParameterTrigger()
		{
		}
	}
}
