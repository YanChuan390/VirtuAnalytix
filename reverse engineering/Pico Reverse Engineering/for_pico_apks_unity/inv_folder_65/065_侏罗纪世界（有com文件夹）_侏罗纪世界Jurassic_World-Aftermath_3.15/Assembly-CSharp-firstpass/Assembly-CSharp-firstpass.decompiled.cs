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
		[Address(RVA = "0x24C131C", Offset = "0x24C131C", VA = "0x24C131C")]
		get
		{
			return default(DSP);
		}
	}

	[Token(Token = "0x6000001")]
	[Address(RVA = "0x24C0EC4", Offset = "0x24C0EC4", VA = "0x24C0EC4")]
	public static void UpdateAudioRoom(FmodResonanceAudioRoom room, bool roomEnabled)
	{
	}

	[Token(Token = "0x6000002")]
	[Address(RVA = "0x24C14B0", Offset = "0x24C14B0", VA = "0x24C14B0")]
	public static bool IsListenerInsideRoom(FmodResonanceAudioRoom room)
	{
		return default(bool);
	}

	[Token(Token = "0x6000004")]
	[Address(RVA = "0x24C1ADC", Offset = "0x24C1ADC", VA = "0x24C1ADC")]
	private static float ConvertAmplitudeFromDb(float db)
	{
		return default(float);
	}

	[Token(Token = "0x6000005")]
	[Address(RVA = "0x24C1B54", Offset = "0x24C1B54", VA = "0x24C1B54")]
	private static void ConvertAudioTransformFromUnity(ref Vector3 position, ref Quaternion rotation)
	{
	}

	[Token(Token = "0x6000006")]
	[Address(RVA = "0x24C13E0", Offset = "0x24C13E0", VA = "0x24C13E0")]
	private static byte[] GetBytes(IntPtr ptr, int length)
	{
		return null;
	}

	[Token(Token = "0x6000007")]
	[Address(RVA = "0x24C1150", Offset = "0x24C1150", VA = "0x24C1150")]
	private static RoomProperties GetRoomProperties(FmodResonanceAudioRoom room)
	{
		return default(RoomProperties);
	}

	[Token(Token = "0x6000008")]
	[Address(RVA = "0x24C1718", Offset = "0x24C1718", VA = "0x24C1718")]
	private static DSP Initialize()
	{
		return default(DSP);
	}
}
[Token(Token = "0x2000003")]
[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x144127C", Offset = "0x144127C")]
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
	[Address(RVA = "0x24C2054", Offset = "0x24C2054", VA = "0x24C2054")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x600000B")]
	[Address(RVA = "0x24C20C4", Offset = "0x24C20C4", VA = "0x24C20C4")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x600000C")]
	[Address(RVA = "0x24C212C", Offset = "0x24C212C", VA = "0x24C212C")]
	private void Update()
	{
	}

	[Token(Token = "0x600000D")]
	[Address(RVA = "0x24C219C", Offset = "0x24C219C", VA = "0x24C219C")]
	private void OnDrawGizmosSelected()
	{
	}

	[Token(Token = "0x600000E")]
	[Address(RVA = "0x24C2268", Offset = "0x24C2268", VA = "0x24C2268")]
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
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x14421B4", Offset = "0x14421B4")]
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
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x144222C", Offset = "0x144222C")]
	private TimelineClip <OwningClip>k__BackingField;

	[Token(Token = "0x17000002")]
	public GameObject TrackTargetObject
	{
		[Token(Token = "0x600000F")]
		[Address(RVA = "0x24B7864", Offset = "0x24B7864", VA = "0x24B7864")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1449988", Offset = "0x1449988")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000010")]
		[Address(RVA = "0x24B786C", Offset = "0x24B786C", VA = "0x24B786C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1449998", Offset = "0x1449998")]
		set
		{
		}
	}

	[Token(Token = "0x17000003")]
	public override double duration
	{
		[Token(Token = "0x6000011")]
		[Address(RVA = "0x24B7874", Offset = "0x24B7874", VA = "0x24B7874", Slot = "7")]
		get
		{
			return default(double);
		}
	}

	[Token(Token = "0x17000004")]
	public ClipCaps clipCaps
	{
		[Token(Token = "0x6000012")]
		[Address(RVA = "0x24B7890", Offset = "0x24B7890", VA = "0x24B7890", Slot = "9")]
		get
		{
			return default(ClipCaps);
		}
	}

	[Token(Token = "0x17000005")]
	public TimelineClip OwningClip
	{
		[Token(Token = "0x6000013")]
		[Address(RVA = "0x24B7898", Offset = "0x24B7898", VA = "0x24B7898")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x14499A8", Offset = "0x14499A8")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000014")]
		[Address(RVA = "0x24B78A0", Offset = "0x24B78A0", VA = "0x24B78A0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x14499B8", Offset = "0x14499B8")]
		set
		{
		}
	}

	[Token(Token = "0x6000015")]
	[Address(RVA = "0x24B78A8", Offset = "0x24B78A8", VA = "0x24B78A8", Slot = "6")]
	public override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
	{
		return default(Playable);
	}

	[Token(Token = "0x6000016")]
	[Address(RVA = "0x24B7B3C", Offset = "0x24B7B3C", VA = "0x24B7B3C")]
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
	[Address(RVA = "0x24B7C18", Offset = "0x24B7C18", VA = "0x24B7C18")]
	protected void PlayEvent()
	{
	}

	[Token(Token = "0x6000018")]
	[Address(RVA = "0x24B83CC", Offset = "0x24B83CC", VA = "0x24B83CC")]
	public void OnEnter()
	{
	}

	[Token(Token = "0x6000019")]
	[Address(RVA = "0x24B8400", Offset = "0x24B8400", VA = "0x24B8400")]
	public void OnExit()
	{
	}

	[Token(Token = "0x600001A")]
	[Address(RVA = "0x24B77D4", Offset = "0x24B77D4", VA = "0x24B77D4")]
	public void UpdateBehaviour(float time)
	{
	}

	[Token(Token = "0x600001B")]
	[Address(RVA = "0x24B845C", Offset = "0x24B845C", VA = "0x24B845C", Slot = "14")]
	public override void OnGraphStop(Playable playable)
	{
	}

	[Token(Token = "0x600001C")]
	[Address(RVA = "0x24B7BB8", Offset = "0x24B7BB8", VA = "0x24B7BB8")]
	public FMODEventPlayableBehavior()
	{
	}
}
[Token(Token = "0x2000007")]
[AttributeAttribute(Name = "TrackColorAttribute", RVA = "0x14412B4", Offset = "0x14412B4")]
[AttributeAttribute(Name = "TrackClipTypeAttribute", RVA = "0x14412B4", Offset = "0x14412B4")]
[AttributeAttribute(Name = "TrackBindingTypeAttribute", RVA = "0x14412B4", Offset = "0x14412B4")]
public class FMODEventTrack : TrackAsset
{
	[Token(Token = "0x600001D")]
	[Address(RVA = "0x24B850C", Offset = "0x24B850C", VA = "0x24B850C", Slot = "24")]
	public override Playable CreateTrackMixer(PlayableGraph graph, GameObject go, int inputCount)
	{
		return default(Playable);
	}

	[Token(Token = "0x600001E")]
	[Address(RVA = "0x24B88E0", Offset = "0x24B88E0", VA = "0x24B88E0")]
	public FMODEventTrack()
	{
	}
}
[Token(Token = "0x2000008")]
public class FMODEventMixerBehaviour : PlayableBehaviour
{
	[Token(Token = "0x600001F")]
	[Address(RVA = "0x24B7660", Offset = "0x24B7660", VA = "0x24B7660", Slot = "20")]
	public override void ProcessFrame(Playable playable, FrameData info, object playerData)
	{
	}

	[Token(Token = "0x6000020")]
	[Address(RVA = "0x24B785C", Offset = "0x24B785C", VA = "0x24B785C")]
	public FMODEventMixerBehaviour()
	{
	}
}
namespace RootMotion
{
	[Token(Token = "0x2000009")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x1441368", Offset = "0x1441368")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x1441368", Offset = "0x1441368")]
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
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x144223C", Offset = "0x144223C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x144223C", Offset = "0x144223C")]
		public int frameRate;

		[Token(Token = "0x4000031")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1442294", Offset = "0x1442294")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1442294", Offset = "0x1442294")]
		public float keyReductionError;

		[Token(Token = "0x4000032")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14422EC", Offset = "0x14422EC")]
		public Mode mode;

		[Token(Token = "0x4000033")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1442324", Offset = "0x1442324")]
		public AnimationClip[] animationClips;

		[Token(Token = "0x4000034")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x144235C", Offset = "0x144235C")]
		public string[] animationStates;

		[Token(Token = "0x4000035")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1442394", Offset = "0x1442394")]
		public bool loop;

		[Token(Token = "0x4000036")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14423CC", Offset = "0x14423CC")]
		public string saveToFolder;

		[Token(Token = "0x4000037")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1442404", Offset = "0x1442404")]
		public string appendName;

		[Token(Token = "0x4000038")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x144243C", Offset = "0x144243C")]
		public string saveName;

		[Token(Token = "0x4000039")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1442474", Offset = "0x1442474")]
		private bool <isBaking>k__BackingField;

		[Token(Token = "0x400003A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1442484", Offset = "0x1442484")]
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
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1442504", Offset = "0x1442504")]
		private float <clipLength>k__BackingField;

		[Token(Token = "0x17000006")]
		public bool isBaking
		{
			[Token(Token = "0x6000025")]
			[Address(RVA = "0x24C3448", Offset = "0x24C3448", VA = "0x24C3448")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1449AA8", Offset = "0x1449AA8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000026")]
			[Address(RVA = "0x24C3450", Offset = "0x24C3450", VA = "0x24C3450")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1449AB8", Offset = "0x1449AB8")]
			private set
			{
			}
		}

		[Token(Token = "0x17000007")]
		public float bakingProgress
		{
			[Token(Token = "0x6000027")]
			[Address(RVA = "0x24C345C", Offset = "0x24C345C", VA = "0x24C345C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1449AC8", Offset = "0x1449AC8")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000028")]
			[Address(RVA = "0x24C3464", Offset = "0x24C3464", VA = "0x24C3464")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1449AD8", Offset = "0x1449AD8")]
			private set
			{
			}
		}

		[Token(Token = "0x17000008")]
		protected float clipLength
		{
			[Token(Token = "0x600002E")]
			[Address(RVA = "0x24C346C", Offset = "0x24C346C", VA = "0x24C346C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1449AE8", Offset = "0x1449AE8")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600002F")]
			[Address(RVA = "0x24C3474", Offset = "0x24C3474", VA = "0x24C3474")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1449AF8", Offset = "0x1449AF8")]
			private set
			{
			}
		}

		[Token(Token = "0x6000021")]
		[Address(RVA = "0x24C3318", Offset = "0x24C3318", VA = "0x24C3318")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x14499C8", Offset = "0x14499C8")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x6000022")]
		[Address(RVA = "0x24C3364", Offset = "0x24C3364", VA = "0x24C3364")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x1449A00", Offset = "0x1449A00")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000023")]
		[Address(RVA = "0x24C33B0", Offset = "0x24C33B0", VA = "0x24C33B0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x1449A38", Offset = "0x1449A38")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000024")]
		[Address(RVA = "0x24C33FC", Offset = "0x24C33FC", VA = "0x24C33FC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x1449A70", Offset = "0x1449A70")]
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
		[Address(RVA = "0x24C347C", Offset = "0x24C347C", VA = "0x24C347C")]
		public void BakeClip()
		{
		}

		[Token(Token = "0x6000031")]
		[Address(RVA = "0x24C3480", Offset = "0x24C3480", VA = "0x24C3480")]
		public void StartBaking()
		{
		}

		[Token(Token = "0x6000032")]
		[Address(RVA = "0x24C3484", Offset = "0x24C3484", VA = "0x24C3484")]
		public void StopBaking()
		{
		}

		[Token(Token = "0x6000033")]
		[Address(RVA = "0x24C3488", Offset = "0x24C3488", VA = "0x24C3488")]
		protected Baker()
		{
		}
	}
	[Token(Token = "0x200000A")]
	public class GenericBaker : Baker
	{
		[Token(Token = "0x400003E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1442514", Offset = "0x1442514")]
		public bool markAsLegacy;

		[Token(Token = "0x400003F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x144254C", Offset = "0x144254C")]
		public Transform root;

		[Token(Token = "0x4000040")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1442584", Offset = "0x1442584")]
		public Transform rootNode;

		[Token(Token = "0x4000041")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14425BC", Offset = "0x14425BC")]
		public Transform[] ignoreList;

		[Token(Token = "0x4000042")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14425F4", Offset = "0x14425F4")]
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
		[Address(RVA = "0x2949ED8", Offset = "0x2949ED8", VA = "0x2949ED8")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000035")]
		[Address(RVA = "0x294A2A4", Offset = "0x294A2A4", VA = "0x294A2A4", Slot = "4")]
		protected override Transform GetCharacterRoot()
		{
			return null;
		}

		[Token(Token = "0x6000036")]
		[Address(RVA = "0x294A2AC", Offset = "0x294A2AC", VA = "0x294A2AC", Slot = "5")]
		protected override void OnStartBaking()
		{
		}

		[Token(Token = "0x6000037")]
		[Address(RVA = "0x294A3BC", Offset = "0x294A3BC", VA = "0x294A3BC", Slot = "6")]
		protected override void OnSetLoopFrame(float time)
		{
		}

		[Token(Token = "0x6000038")]
		[Address(RVA = "0x294A438", Offset = "0x294A438", VA = "0x294A438", Slot = "7")]
		protected override void OnSetCurves(ref AnimationClip clip)
		{
		}

		[Token(Token = "0x6000039")]
		[Address(RVA = "0x294A4B4", Offset = "0x294A4B4", VA = "0x294A4B4", Slot = "8")]
		protected override void OnSetKeyframes(float time, bool lastFrame)
		{
		}

		[Token(Token = "0x600003A")]
		[Address(RVA = "0x294A0F4", Offset = "0x294A0F4", VA = "0x294A0F4")]
		private bool IsIgnored(Transform t)
		{
			return default(bool);
		}

		[Token(Token = "0x600003B")]
		[Address(RVA = "0x294A1CC", Offset = "0x294A1CC", VA = "0x294A1CC")]
		private bool BakePosition(Transform t)
		{
			return default(bool);
		}

		[Token(Token = "0x600003C")]
		[Address(RVA = "0x294A530", Offset = "0x294A530", VA = "0x294A530")]
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
		[Address(RVA = "0x294EA30", Offset = "0x294EA30", VA = "0x294EA30")]
		public TQ(Vector3 translation, Quaternion rotation)
		{
		}
	}
	[Token(Token = "0x200000C")]
	public class AvatarUtility
	{
		[Token(Token = "0x600003E")]
		[Address(RVA = "0x24C2300", Offset = "0x24C2300", VA = "0x24C2300")]
		public static Quaternion GetPostRotation(Avatar avatar, AvatarIKGoal avatarIKGoal)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600003F")]
		[Address(RVA = "0x24C2514", Offset = "0x24C2514", VA = "0x24C2514")]
		public static TQ GetIKGoalTQ(Avatar avatar, float humanScale, AvatarIKGoal avatarIKGoal, TQ bodyPositionRotation, TQ boneTQ)
		{
			return null;
		}

		[Token(Token = "0x6000040")]
		[Address(RVA = "0x24C24F4", Offset = "0x24C24F4", VA = "0x24C24F4")]
		public static HumanBodyBones HumanIDFromAvatarIKGoal(AvatarIKGoal avatarIKGoal)
		{
			return default(HumanBodyBones);
		}

		[Token(Token = "0x6000041")]
		[Address(RVA = "0x24C2B94", Offset = "0x24C2B94", VA = "0x24C2B94")]
		public AvatarUtility()
		{
		}
	}
	[Token(Token = "0x200000D")]
	public static class BakerUtilities
	{
		[Token(Token = "0x6000042")]
		[Address(RVA = "0x24C45CC", Offset = "0x24C45CC", VA = "0x24C45CC")]
		public static void ReduceKeyframes(AnimationCurve curve, float maxError)
		{
		}

		[Token(Token = "0x6000043")]
		[Address(RVA = "0x24C5AA0", Offset = "0x24C5AA0", VA = "0x24C5AA0")]
		public static Keyframe[] GetReducedKeyframes(AnimationCurve curve, float maxError)
		{
			return null;
		}

		[Token(Token = "0x6000044")]
		[Address(RVA = "0x24C3FE0", Offset = "0x24C3FE0", VA = "0x24C3FE0")]
		public static void SetLoopFrame(float time, AnimationCurve curve)
		{
		}

		[Token(Token = "0x6000045")]
		[Address(RVA = "0x24C4614", Offset = "0x24C4614", VA = "0x24C4614")]
		public static void SetTangentMode(AnimationCurve curve)
		{
		}

		[Token(Token = "0x6000046")]
		[Address(RVA = "0x24C3B18", Offset = "0x24C3B18", VA = "0x24C3B18")]
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
		[Address(RVA = "0x24C3548", Offset = "0x24C3548", VA = "0x24C3548")]
		public BakerHumanoidQT(string name)
		{
		}

		[Token(Token = "0x6000048")]
		[Address(RVA = "0x24C3794", Offset = "0x24C3794", VA = "0x24C3794")]
		public BakerHumanoidQT(Transform transform, AvatarIKGoal goal, string name)
		{
		}

		[Token(Token = "0x6000049")]
		[Address(RVA = "0x24C3668", Offset = "0x24C3668", VA = "0x24C3668")]
		public void Reset()
		{
		}

		[Token(Token = "0x600004A")]
		[Address(RVA = "0x24C38CC", Offset = "0x24C38CC", VA = "0x24C38CC")]
		public void SetIKKeyframes(float time, Avatar avatar, float humanScale, Vector3 bodyPosition, Quaternion bodyRotation)
		{
		}

		[Token(Token = "0x600004B")]
		[Address(RVA = "0x24C3D74", Offset = "0x24C3D74", VA = "0x24C3D74")]
		public void SetKeyframes(float time, Vector3 pos, Quaternion rot)
		{
		}

		[Token(Token = "0x600004C")]
		[Address(RVA = "0x24C3E70", Offset = "0x24C3E70", VA = "0x24C3E70")]
		public void MoveLastKeyframes(float time)
		{
		}

		[Token(Token = "0x600004D")]
		[Address(RVA = "0x24C3F6C", Offset = "0x24C3F6C", VA = "0x24C3F6C")]
		public void SetLoopFrame(float time)
		{
		}

		[Token(Token = "0x600004E")]
		[Address(RVA = "0x24C3EE4", Offset = "0x24C3EE4", VA = "0x24C3EE4")]
		private void MoveLastKeyframe(float time, AnimationCurve curve)
		{
		}

		[Token(Token = "0x600004F")]
		[Address(RVA = "0x24C422C", Offset = "0x24C422C", VA = "0x24C422C")]
		public void MultiplyLength(AnimationCurve curve, float mlp)
		{
		}

		[Token(Token = "0x6000050")]
		[Address(RVA = "0x24C42E0", Offset = "0x24C42E0", VA = "0x24C42E0")]
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
		[Address(RVA = "0x24C4618", Offset = "0x24C4618", VA = "0x24C4618")]
		public BakerMuscle(int muscleIndex)
		{
		}

		[Token(Token = "0x6000052")]
		[Address(RVA = "0x24C4688", Offset = "0x24C4688", VA = "0x24C4688")]
		private string MuscleNameToPropertyName(string n)
		{
			return null;
		}

		[Token(Token = "0x6000053")]
		[Address(RVA = "0x24C4D70", Offset = "0x24C4D70", VA = "0x24C4D70")]
		public void MultiplyLength(AnimationCurve curve, float mlp)
		{
		}

		[Token(Token = "0x6000054")]
		[Address(RVA = "0x24C4E24", Offset = "0x24C4E24", VA = "0x24C4E24")]
		public void SetCurves(ref AnimationClip clip, float maxError, float lengthMlp)
		{
		}

		[Token(Token = "0x6000055")]
		[Address(RVA = "0x24C4D10", Offset = "0x24C4D10", VA = "0x24C4D10")]
		public void Reset()
		{
		}

		[Token(Token = "0x6000056")]
		[Address(RVA = "0x24C4F08", Offset = "0x24C4F08", VA = "0x24C4F08")]
		public void SetKeyframe(float time, float[] muscles)
		{
		}

		[Token(Token = "0x6000057")]
		[Address(RVA = "0x24C4F50", Offset = "0x24C4F50", VA = "0x24C4F50")]
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
		[Address(RVA = "0x24C4F58", Offset = "0x24C4F58", VA = "0x24C4F58")]
		public BakerTransform(Transform transform, Transform root, bool recordPosition, bool isRootNode)
		{
		}

		[Token(Token = "0x6000059")]
		[Address(RVA = "0x24C50EC", Offset = "0x24C50EC", VA = "0x24C50EC")]
		public void SetRelativeSpace(Vector3 position, Quaternion rotation)
		{
		}

		[Token(Token = "0x600005A")]
		[Address(RVA = "0x24C5100", Offset = "0x24C5100", VA = "0x24C5100")]
		public void SetCurves(ref AnimationClip clip)
		{
		}

		[Token(Token = "0x600005B")]
		[Address(RVA = "0x24C5390", Offset = "0x24C5390", VA = "0x24C5390")]
		private void AddRootMotionCurves(ref AnimationClip clip)
		{
		}

		[Token(Token = "0x600005C")]
		[Address(RVA = "0x24C4FF4", Offset = "0x24C4FF4", VA = "0x24C4FF4")]
		public void Reset()
		{
		}

		[Token(Token = "0x600005D")]
		[Address(RVA = "0x24C55DC", Offset = "0x24C55DC", VA = "0x24C55DC")]
		public void ReduceKeyframes(float maxError)
		{
		}

		[Token(Token = "0x600005E")]
		[Address(RVA = "0x24C5650", Offset = "0x24C5650", VA = "0x24C5650")]
		public void SetKeyframes(float time)
		{
		}

		[Token(Token = "0x600005F")]
		[Address(RVA = "0x24C589C", Offset = "0x24C589C", VA = "0x24C589C")]
		public void AddLoopFrame(float time)
		{
		}
	}
	[Token(Token = "0x2000011")]
	public class HumanoidBaker : Baker
	{
		[Token(Token = "0x400006A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x144262C", Offset = "0x144262C")]
		public bool bakeHandIK;

		[Token(Token = "0x400006B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1442664", Offset = "0x1442664")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1442664", Offset = "0x1442664")]
		public float IKKeyReductionError;

		[Token(Token = "0x400006C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14426BC", Offset = "0x14426BC")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x14426BC", Offset = "0x14426BC")]
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
		[Address(RVA = "0x294B468", Offset = "0x294B468", VA = "0x294B468")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000061")]
		[Address(RVA = "0x294B894", Offset = "0x294B894", VA = "0x294B894", Slot = "4")]
		protected override Transform GetCharacterRoot()
		{
			return null;
		}

		[Token(Token = "0x6000062")]
		[Address(RVA = "0x294B8B0", Offset = "0x294B8B0", VA = "0x294B8B0", Slot = "5")]
		protected override void OnStartBaking()
		{
		}

		[Token(Token = "0x6000063")]
		[Address(RVA = "0x294B9D0", Offset = "0x294B9D0", VA = "0x294B9D0", Slot = "6")]
		protected override void OnSetLoopFrame(float time)
		{
		}

		[Token(Token = "0x6000064")]
		[Address(RVA = "0x294BAAC", Offset = "0x294BAAC", VA = "0x294BAAC", Slot = "7")]
		protected override void OnSetCurves(ref AnimationClip clip)
		{
		}

		[Token(Token = "0x6000065")]
		[Address(RVA = "0x294BC7C", Offset = "0x294BC7C", VA = "0x294BC7C", Slot = "8")]
		protected override void OnSetKeyframes(float time, bool lastFrame)
		{
		}

		[Token(Token = "0x6000066")]
		[Address(RVA = "0x294BFA4", Offset = "0x294BFA4", VA = "0x294BFA4")]
		private void UpdateHumanPose()
		{
		}

		[Token(Token = "0x6000067")]
		[Address(RVA = "0x294C080", Offset = "0x294C080", VA = "0x294C080")]
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
		[Address(RVA = "0x24C2B9C", Offset = "0x24C2B9C", VA = "0x24C2B9C")]
		public static Vector3 ToVector3(Axis axis)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000069")]
		[Address(RVA = "0x24C2C54", Offset = "0x24C2C54", VA = "0x24C2C54")]
		public static Axis ToAxis(Vector3 v)
		{
			return default(Axis);
		}

		[Token(Token = "0x600006A")]
		[Address(RVA = "0x24C2D00", Offset = "0x24C2D00", VA = "0x24C2D00")]
		public static Axis GetAxisToPoint(Transform t, Vector3 worldPosition)
		{
			return default(Axis);
		}

		[Token(Token = "0x600006B")]
		[Address(RVA = "0x24C2EE4", Offset = "0x24C2EE4", VA = "0x24C2EE4")]
		public static Axis GetAxisToDirection(Transform t, Vector3 direction)
		{
			return default(Axis);
		}

		[Token(Token = "0x600006C")]
		[Address(RVA = "0x24C2E1C", Offset = "0x24C2E1C", VA = "0x24C2E1C")]
		public static Vector3 GetAxisVectorToPoint(Transform t, Vector3 worldPosition)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600006D")]
		[Address(RVA = "0x24C3000", Offset = "0x24C3000", VA = "0x24C3000")]
		public static Vector3 GetAxisVectorToDirection(Transform t, Vector3 direction)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600006E")]
		[Address(RVA = "0x24C3048", Offset = "0x24C3048", VA = "0x24C3048")]
		public static Vector3 GetAxisVectorToDirection(Quaternion r, Vector3 direction)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600006F")]
		[Address(RVA = "0x24C3310", Offset = "0x24C3310", VA = "0x24C3310")]
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
			[Address(RVA = "0x24C6148", Offset = "0x24C6148", VA = "0x24C6148")]
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
			[Address(RVA = "0x24C5ED4", Offset = "0x24C5ED4", VA = "0x24C5ED4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700000A")]
		public static BipedLimbOrientations MaxBiped
		{
			[Token(Token = "0x6000072")]
			[Address(RVA = "0x24C61C0", Offset = "0x24C61C0", VA = "0x24C61C0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000070")]
		[Address(RVA = "0x24C5E88", Offset = "0x24C5E88", VA = "0x24C5E88")]
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
		[Address(RVA = "0x24C6434", Offset = "0x24C6434", VA = "0x24C6434")]
		public static Transform[] GetBonesOfType(BoneType boneType, Transform[] bones)
		{
			return null;
		}

		[Token(Token = "0x6000074")]
		[Address(RVA = "0x24C6734", Offset = "0x24C6734", VA = "0x24C6734")]
		public static Transform[] GetBonesOfSide(BoneSide boneSide, Transform[] bones)
		{
			return null;
		}

		[Token(Token = "0x6000075")]
		[Address(RVA = "0x24C6984", Offset = "0x24C6984", VA = "0x24C6984")]
		public static Transform[] GetBonesOfTypeAndSide(BoneType boneType, BoneSide boneSide, Transform[] bones)
		{
			return null;
		}

		[Token(Token = "0x6000076")]
		[Address(RVA = "0x24C6A08", Offset = "0x24C6A08", VA = "0x24C6A08")]
		public static Transform GetFirstBoneOfTypeAndSide(BoneType boneType, BoneSide boneSide, Transform[] bones)
		{
			return null;
		}

		[Token(Token = "0x6000077")]
		[Address(RVA = "0x24C6AB4", Offset = "0x24C6AB4", VA = "0x24C6AB4")]
		public static Transform GetNamingMatch(Transform[] transforms, params string[][] namings)
		{
			return null;
		}

		[Token(Token = "0x6000078")]
		[Address(RVA = "0x24C65E4", Offset = "0x24C65E4", VA = "0x24C65E4")]
		public static BoneType GetBoneType(string boneName)
		{
			return default(BoneType);
		}

		[Token(Token = "0x6000079")]
		[Address(RVA = "0x24C68E4", Offset = "0x24C68E4", VA = "0x24C68E4")]
		public static BoneSide GetBoneSide(string boneName)
		{
			return default(BoneSide);
		}

		[Token(Token = "0x600007A")]
		[Address(RVA = "0x24C72F4", Offset = "0x24C72F4", VA = "0x24C72F4")]
		public static Transform GetBone(Transform[] transforms, BoneType boneType, BoneSide boneSide = BoneSide.Center, params string[][] namings)
		{
			return null;
		}

		[Token(Token = "0x600007B")]
		[Address(RVA = "0x24C710C", Offset = "0x24C710C", VA = "0x24C710C")]
		private static bool isLeft(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x600007C")]
		[Address(RVA = "0x24C7200", Offset = "0x24C7200", VA = "0x24C7200")]
		private static bool isRight(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x600007D")]
		[Address(RVA = "0x24C6CD4", Offset = "0x24C6CD4", VA = "0x24C6CD4")]
		private static bool isSpine(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x600007E")]
		[Address(RVA = "0x24C6D88", Offset = "0x24C6D88", VA = "0x24C6D88")]
		private static bool isHead(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x600007F")]
		[Address(RVA = "0x24C6E3C", Offset = "0x24C6E3C", VA = "0x24C6E3C")]
		private static bool isArm(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000080")]
		[Address(RVA = "0x24C6EF0", Offset = "0x24C6EF0", VA = "0x24C6EF0")]
		private static bool isLeg(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000081")]
		[Address(RVA = "0x24C6FA4", Offset = "0x24C6FA4", VA = "0x24C6FA4")]
		private static bool isTail(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000082")]
		[Address(RVA = "0x24C7058", Offset = "0x24C7058", VA = "0x24C7058")]
		private static bool isEye(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000083")]
		[Address(RVA = "0x24C7508", Offset = "0x24C7508", VA = "0x24C7508")]
		private static bool isTypeExclude(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000084")]
		[Address(RVA = "0x24C6BE8", Offset = "0x24C6BE8", VA = "0x24C6BE8")]
		private static bool matchesNaming(string boneName, string[] namingConvention)
		{
			return default(bool);
		}

		[Token(Token = "0x6000085")]
		[Address(RVA = "0x24C7478", Offset = "0x24C7478", VA = "0x24C7478")]
		private static bool excludesNaming(string boneName, string[] namingConvention)
		{
			return default(bool);
		}

		[Token(Token = "0x6000086")]
		[Address(RVA = "0x24C7578", Offset = "0x24C7578", VA = "0x24C7578")]
		private static bool matchesLastLetter(string boneName, string[] namingConvention)
		{
			return default(bool);
		}

		[Token(Token = "0x6000087")]
		[Address(RVA = "0x24C7650", Offset = "0x24C7650", VA = "0x24C7650")]
		private static bool LastLetterIs(string boneName, string letter)
		{
			return default(bool);
		}

		[Token(Token = "0x6000088")]
		[Address(RVA = "0x24C73FC", Offset = "0x24C73FC", VA = "0x24C73FC")]
		private static string firstLetter(string boneName)
		{
			return null;
		}

		[Token(Token = "0x6000089")]
		[Address(RVA = "0x24C7384", Offset = "0x24C7384", VA = "0x24C7384")]
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
				[Address(RVA = "0x2A71DC8", Offset = "0x2A71DC8", VA = "0x2A71DC8")]
				get
				{
					return default(AutoDetectParams);
				}
			}

			[Token(Token = "0x6000BAC")]
			[Address(RVA = "0x1577980", Offset = "0x1577980", VA = "0x1577980")]
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
			[Address(RVA = "0x2A6E99C", Offset = "0x2A6E99C", VA = "0x2A6E99C", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700000C")]
		public bool isEmpty
		{
			[Token(Token = "0x600008C")]
			[Address(RVA = "0x2A6ED88", Offset = "0x2A6ED88", VA = "0x2A6ED88")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600008D")]
		[Address(RVA = "0x2A6ED98", Offset = "0x2A6ED98", VA = "0x2A6ED98", Slot = "5")]
		public virtual bool IsEmpty(bool includeRoot)
		{
			return default(bool);
		}

		[Token(Token = "0x600008E")]
		[Address(RVA = "0x2A6F1C4", Offset = "0x2A6F1C4", VA = "0x2A6F1C4", Slot = "6")]
		public virtual bool Contains(Transform t, bool ignoreRoot = false)
		{
			return default(bool);
		}

		[Token(Token = "0x600008F")]
		[Address(RVA = "0x2A6F5FC", Offset = "0x2A6F5FC", VA = "0x2A6F5FC")]
		public static bool AutoDetectReferences(ref BipedReferences references, Transform root, AutoDetectParams autoDetectParams)
		{
			return default(bool);
		}

		[Token(Token = "0x6000090")]
		[Address(RVA = "0x2A6FC0C", Offset = "0x2A6FC0C", VA = "0x2A6FC0C")]
		public static void DetectReferencesByNaming(ref BipedReferences references, Transform root, AutoDetectParams autoDetectParams)
		{
		}

		[Token(Token = "0x6000091")]
		[Address(RVA = "0x2A6F848", Offset = "0x2A6F848", VA = "0x2A6F848")]
		public static void AssignHumanoidReferences(ref BipedReferences references, Animator animator, AutoDetectParams autoDetectParams)
		{
		}

		[Token(Token = "0x6000092")]
		[Address(RVA = "0x2A703C8", Offset = "0x2A703C8", VA = "0x2A703C8")]
		public static bool SetupError(BipedReferences references, ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000093")]
		[Address(RVA = "0x2A704BC", Offset = "0x2A704BC", VA = "0x2A704BC")]
		public static bool SetupWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000094")]
		[Address(RVA = "0x2A70A18", Offset = "0x2A70A18", VA = "0x2A70A18")]
		private static bool IsNeckBone(Transform bone, Transform leftUpperArm)
		{
			return default(bool);
		}

		[Token(Token = "0x6000095")]
		[Address(RVA = "0x2A7081C", Offset = "0x2A7081C", VA = "0x2A7081C")]
		private static bool AddBoneToEyes(Transform bone, ref BipedReferences references, AutoDetectParams autoDetectParams)
		{
			return default(bool);
		}

		[Token(Token = "0x6000096")]
		[Address(RVA = "0x2A70694", Offset = "0x2A70694", VA = "0x2A70694")]
		private static bool AddBoneToSpine(Transform bone, ref BipedReferences references, AutoDetectParams autoDetectParams)
		{
			return default(bool);
		}

		[Token(Token = "0x6000097")]
		[Address(RVA = "0x2A7055C", Offset = "0x2A7055C", VA = "0x2A7055C")]
		private static void DetectLimb(BipedNaming.BoneType boneType, BipedNaming.BoneSide boneSide, ref Transform firstBone, ref Transform secondBone, ref Transform lastBone, Transform[] transforms)
		{
		}

		[Token(Token = "0x6000098")]
		[Address(RVA = "0x2A70920", Offset = "0x2A70920", VA = "0x2A70920")]
		private static void AddBoneToHierarchy(ref Transform[] bones, Transform transform)
		{
		}

		[Token(Token = "0x6000099")]
		[Address(RVA = "0x2A70B14", Offset = "0x2A70B14", VA = "0x2A70B14")]
		private static bool LimbError(Transform bone1, Transform bone2, Transform bone3, ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x600009A")]
		[Address(RVA = "0x2A715B4", Offset = "0x2A715B4", VA = "0x2A715B4")]
		private static bool LimbWarning(Transform bone1, Transform bone2, Transform bone3, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x600009B")]
		[Address(RVA = "0x2A71098", Offset = "0x2A71098", VA = "0x2A71098")]
		private static bool SpineError(BipedReferences references, ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x600009C")]
		[Address(RVA = "0x2A718A8", Offset = "0x2A718A8", VA = "0x2A718A8")]
		private static bool SpineWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x600009D")]
		[Address(RVA = "0x2A713D8", Offset = "0x2A713D8", VA = "0x2A713D8")]
		private static bool EyesError(BipedReferences references, ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x600009E")]
		[Address(RVA = "0x2A718B0", Offset = "0x2A718B0", VA = "0x2A718B0")]
		private static bool EyesWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x600009F")]
		[Address(RVA = "0x2A718B8", Offset = "0x2A718B8", VA = "0x2A718B8")]
		private static bool RootHeightWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x60000A0")]
		[Address(RVA = "0x2A71A78", Offset = "0x2A71A78", VA = "0x2A71A78")]
		private static bool FacingAxisWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x60000A1")]
		[Address(RVA = "0x2A71C90", Offset = "0x2A71C90", VA = "0x2A71C90")]
		private static float GetVerticalOffset(Vector3 p1, Vector3 p2, Quaternion rotation)
		{
			return default(float);
		}

		[Token(Token = "0x60000A2")]
		[Address(RVA = "0x2A6F7D8", Offset = "0x2A6F7D8", VA = "0x2A6F7D8")]
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
		[Address(RVA = "0x2A71DD0", Offset = "0x2A71DD0", VA = "0x2A71DD0")]
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
		[Address(RVA = "0x2A71DD8", Offset = "0x2A71DD8", VA = "0x2A71DD8")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x60000A5")]
		[Address(RVA = "0x2A71F18", Offset = "0x2A71F18", VA = "0x2A71F18")]
		public DemoGUIMessage()
		{
		}
	}
	[Token(Token = "0x2000019")]
	public class Hierarchy
	{
		[Token(Token = "0x60000A6")]
		[Address(RVA = "0x294A598", Offset = "0x294A598", VA = "0x294A598")]
		public static bool HierarchyIsValid(Transform[] bones)
		{
			return default(bool);
		}

		[Token(Token = "0x60000A7")]
		[Address(RVA = "0x294A798", Offset = "0x294A798", VA = "0x294A798")]
		public static UnityEngine.Object ContainsDuplicate(UnityEngine.Object[] objects)
		{
			return null;
		}

		[Token(Token = "0x60000A8")]
		[Address(RVA = "0x294A630", Offset = "0x294A630", VA = "0x294A630")]
		public static bool IsAncestor(Transform transform, Transform ancestor)
		{
			return default(bool);
		}

		[Token(Token = "0x60000A9")]
		[Address(RVA = "0x294A8BC", Offset = "0x294A8BC", VA = "0x294A8BC")]
		public static bool ContainsChild(Transform transform, Transform child)
		{
			return default(bool);
		}

		[Token(Token = "0x60000AA")]
		[Address(RVA = "0x294A9E0", Offset = "0x294A9E0", VA = "0x294A9E0")]
		public static void AddAncestors(Transform transform, Transform blocker, ref Transform[] array)
		{
		}

		[Token(Token = "0x60000AB")]
		[Address(RVA = "0x294AC88", Offset = "0x294AC88", VA = "0x294AC88")]
		public static Transform GetAncestor(Transform transform, int minChildCount)
		{
			return null;
		}

		[Token(Token = "0x60000AC")]
		[Address(RVA = "0x294ADA4", Offset = "0x294ADA4", VA = "0x294ADA4")]
		public static Transform GetFirstCommonAncestor(Transform t1, Transform t2)
		{
			return null;
		}

		[Token(Token = "0x60000AD")]
		[Address(RVA = "0x294AF2C", Offset = "0x294AF2C", VA = "0x294AF2C")]
		public static Transform GetFirstCommonAncestor(Transform[] transforms)
		{
			return null;
		}

		[Token(Token = "0x60000AE")]
		[Address(RVA = "0x294B2C0", Offset = "0x294B2C0", VA = "0x294B2C0")]
		public static Transform GetFirstCommonAncestorRecursive(Transform transform, Transform[] transforms)
		{
			return null;
		}

		[Token(Token = "0x60000AF")]
		[Address(RVA = "0x294B0AC", Offset = "0x294B0AC", VA = "0x294B0AC")]
		public static bool IsCommonAncestor(Transform transform, Transform[] transforms)
		{
			return default(bool);
		}

		[Token(Token = "0x60000B0")]
		[Address(RVA = "0x294B460", Offset = "0x294B460", VA = "0x294B460")]
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
		[Address(RVA = "0x294C134", Offset = "0x294C134", VA = "0x294C134")]
		public InspectorComment(string name)
		{
		}

		[Token(Token = "0x60000B2")]
		[Address(RVA = "0x294C1A4", Offset = "0x294C1A4", VA = "0x294C1A4")]
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
		[Address(RVA = "0x294C214", Offset = "0x294C214", VA = "0x294C214")]
		public static float Float(float t, InterpolationMode mode)
		{
			return default(float);
		}

		[Token(Token = "0x60000B4")]
		[Address(RVA = "0x294CC7C", Offset = "0x294CC7C", VA = "0x294CC7C")]
		public static Vector3 V3(Vector3 v1, Vector3 v2, float t, InterpolationMode mode)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000B5")]
		[Address(RVA = "0x294CD84", Offset = "0x294CD84", VA = "0x294CD84")]
		public static float LerpValue(float value, float target, float increaseSpeed, float decreaseSpeed)
		{
			return default(float);
		}

		[Token(Token = "0x60000B6")]
		[Address(RVA = "0x294C580", Offset = "0x294C580", VA = "0x294C580")]
		private static float None(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000B7")]
		[Address(RVA = "0x294C58C", Offset = "0x294C58C", VA = "0x294C58C")]
		private static float InOutCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000B8")]
		[Address(RVA = "0x294C5B0", Offset = "0x294C5B0", VA = "0x294C5B0")]
		private static float InOutQuintic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000B9")]
		[Address(RVA = "0x294C5EC", Offset = "0x294C5EC", VA = "0x294C5EC")]
		private static float InQuintic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000BA")]
		[Address(RVA = "0x294C604", Offset = "0x294C604", VA = "0x294C604")]
		private static float InQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000BB")]
		[Address(RVA = "0x294C618", Offset = "0x294C618", VA = "0x294C618")]
		private static float InCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000BC")]
		[Address(RVA = "0x294C62C", Offset = "0x294C62C", VA = "0x294C62C")]
		private static float InQuadratic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000BD")]
		[Address(RVA = "0x294C63C", Offset = "0x294C63C", VA = "0x294C63C")]
		private static float OutQuintic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000BE")]
		[Address(RVA = "0x294C684", Offset = "0x294C684", VA = "0x294C684")]
		private static float OutQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000BF")]
		[Address(RVA = "0x294C6BC", Offset = "0x294C6BC", VA = "0x294C6BC")]
		private static float OutCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000C0")]
		[Address(RVA = "0x294C6E4", Offset = "0x294C6E4", VA = "0x294C6E4")]
		private static float OutInCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000C1")]
		[Address(RVA = "0x294CE80", Offset = "0x294CE80", VA = "0x294CE80")]
		private static float OutInQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000C2")]
		[Address(RVA = "0x294C718", Offset = "0x294C718", VA = "0x294C718")]
		private static float BackInCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000C3")]
		[Address(RVA = "0x294C740", Offset = "0x294C740", VA = "0x294C740")]
		private static float BackInQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000C4")]
		[Address(RVA = "0x294C770", Offset = "0x294C770", VA = "0x294C770")]
		private static float OutBackCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000C5")]
		[Address(RVA = "0x294C7A4", Offset = "0x294C7A4", VA = "0x294C7A4")]
		private static float OutBackQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000C6")]
		[Address(RVA = "0x294C7E8", Offset = "0x294C7E8", VA = "0x294C7E8")]
		private static float OutElasticSmall(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000C7")]
		[Address(RVA = "0x294C84C", Offset = "0x294C84C", VA = "0x294C84C")]
		private static float OutElasticBig(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000C8")]
		[Address(RVA = "0x294C8B0", Offset = "0x294C8B0", VA = "0x294C8B0")]
		private static float InElasticSmall(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000C9")]
		[Address(RVA = "0x294C904", Offset = "0x294C904", VA = "0x294C904")]
		private static float InElasticBig(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000CA")]
		[Address(RVA = "0x294C958", Offset = "0x294C958", VA = "0x294C958")]
		private static float InSine(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000CB")]
		[Address(RVA = "0x294C9F0", Offset = "0x294C9F0", VA = "0x294C9F0")]
		private static float OutSine(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000CC")]
		[Address(RVA = "0x294CA84", Offset = "0x294CA84", VA = "0x294CA84")]
		private static float InOutSine(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000CD")]
		[Address(RVA = "0x294CEB4", Offset = "0x294CEB4", VA = "0x294CEB4")]
		private static float InElastic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000CE")]
		[Address(RVA = "0x294CB28", Offset = "0x294CB28", VA = "0x294CB28")]
		private static float OutElastic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000CF")]
		[Address(RVA = "0x294CC0C", Offset = "0x294CC0C", VA = "0x294CC0C")]
		private static float InBack(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000D0")]
		[Address(RVA = "0x294CC3C", Offset = "0x294CC3C", VA = "0x294CC3C")]
		private static float OutBack(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000D1")]
		[Address(RVA = "0x294CF9C", Offset = "0x294CF9C", VA = "0x294CF9C")]
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
		[Address(RVA = "0x294CFA4", Offset = "0x294CFA4", VA = "0x294CFA4")]
		public LargeHeader(string name)
		{
		}

		[Token(Token = "0x60000D3")]
		[Address(RVA = "0x294D014", Offset = "0x294D014", VA = "0x294D014")]
		public LargeHeader(string name, string color)
		{
		}
	}
	[Token(Token = "0x200001E")]
	public static class LayerMaskExtensions
	{
		[Token(Token = "0x60000D4")]
		[Address(RVA = "0x294D084", Offset = "0x294D084", VA = "0x294D084")]
		public static bool Contains(LayerMask mask, int layer)
		{
			return default(bool);
		}

		[Token(Token = "0x60000D5")]
		[Address(RVA = "0x294D0DC", Offset = "0x294D0DC", VA = "0x294D0DC")]
		public static LayerMask Create(params string[] layerNames)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60000D6")]
		[Address(RVA = "0x294D1A8", Offset = "0x294D1A8", VA = "0x294D1A8")]
		public static LayerMask Create(params int[] layerNumbers)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60000D7")]
		[Address(RVA = "0x294D0F4", Offset = "0x294D0F4", VA = "0x294D0F4")]
		public static LayerMask NamesToMask(params string[] layerNames)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60000D8")]
		[Address(RVA = "0x294D1C0", Offset = "0x294D1C0", VA = "0x294D1C0")]
		public static LayerMask LayerNumbersToMask(params int[] layerNumbers)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60000D9")]
		[Address(RVA = "0x294D264", Offset = "0x294D264", VA = "0x294D264")]
		public static LayerMask Inverse(this LayerMask original)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60000DA")]
		[Address(RVA = "0x294D290", Offset = "0x294D290", VA = "0x294D290")]
		public static LayerMask AddToMask(this LayerMask original, params string[] layerNames)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60000DB")]
		[Address(RVA = "0x294D2E0", Offset = "0x294D2E0", VA = "0x294D2E0")]
		public static LayerMask RemoveFromMask(this LayerMask original, params string[] layerNames)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60000DC")]
		[Address(RVA = "0x294D34C", Offset = "0x294D34C", VA = "0x294D34C")]
		public static string[] MaskToNames(this LayerMask original)
		{
			return null;
		}

		[Token(Token = "0x60000DD")]
		[Address(RVA = "0x294D440", Offset = "0x294D440", VA = "0x294D440")]
		public static int[] MaskToNumbers(this LayerMask original)
		{
			return null;
		}

		[Token(Token = "0x60000DE")]
		[Address(RVA = "0x294D518", Offset = "0x294D518", VA = "0x294D518")]
		public static string MaskToString(this LayerMask original)
		{
			return null;
		}

		[Token(Token = "0x60000DF")]
		[Address(RVA = "0x294D578", Offset = "0x294D578", VA = "0x294D578")]
		public static string MaskToString(this LayerMask original, string delimiter)
		{
			return null;
		}
	}
	[Token(Token = "0x200001F")]
	public static class QuaTools
	{
		[Token(Token = "0x60000E0")]
		[Address(RVA = "0x294D5A8", Offset = "0x294D5A8", VA = "0x294D5A8")]
		public static Quaternion Lerp(Quaternion fromRotation, Quaternion toRotation, float weight)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60000E1")]
		[Address(RVA = "0x294D6F4", Offset = "0x294D6F4", VA = "0x294D6F4")]
		public static Quaternion Slerp(Quaternion fromRotation, Quaternion toRotation, float weight)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60000E2")]
		[Address(RVA = "0x294D840", Offset = "0x294D840", VA = "0x294D840")]
		public static Quaternion LinearBlend(Quaternion q, float weight)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60000E3")]
		[Address(RVA = "0x294D954", Offset = "0x294D954", VA = "0x294D954")]
		public static Quaternion SphericalBlend(Quaternion q, float weight)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60000E4")]
		[Address(RVA = "0x294DA68", Offset = "0x294DA68", VA = "0x294DA68")]
		public static Quaternion FromToAroundAxis(Vector3 fromDirection, Vector3 toDirection, Vector3 axis)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60000E5")]
		[Address(RVA = "0x294DBF4", Offset = "0x294DBF4", VA = "0x294DBF4")]
		public static Quaternion RotationToLocalSpace(Quaternion space, Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60000E6")]
		[Address(RVA = "0x293E6A4", Offset = "0x293E6A4", VA = "0x293E6A4")]
		public static Quaternion FromToRotation(Quaternion from, Quaternion to)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60000E7")]
		[Address(RVA = "0x294DCC4", Offset = "0x294DCC4", VA = "0x294DCC4")]
		public static Vector3 GetAxis(Vector3 v)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000E8")]
		[Address(RVA = "0x294DF48", Offset = "0x294DF48", VA = "0x294DF48")]
		public static Quaternion ClampRotation(Quaternion rotation, float clampWeight, int clampSmoothing)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60000E9")]
		[Address(RVA = "0x294E15C", Offset = "0x294E15C", VA = "0x294E15C")]
		public static float ClampAngle(float angle, float clampWeight, int clampSmoothing)
		{
			return default(float);
		}

		[Token(Token = "0x60000EA")]
		[Address(RVA = "0x2947A78", Offset = "0x2947A78", VA = "0x2947A78")]
		public static Quaternion MatchRotation(Quaternion targetRotation, Vector3 targetforwardAxis, Vector3 targetUpAxis, Vector3 forwardAxis, Vector3 upAxis)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60000EB")]
		[Address(RVA = "0x294E2DC", Offset = "0x294E2DC", VA = "0x294E2DC")]
		public static Vector3 ToBiPolar(Vector3 euler)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000EC")]
		[Address(RVA = "0x294E3EC", Offset = "0x294E3EC", VA = "0x294E3EC")]
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
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1442720", Offset = "0x1442720")]
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
			[Address(RVA = "0x294E580", Offset = "0x294E580", VA = "0x294E580")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700000F")]
		private bool isAnimated
		{
			[Token(Token = "0x60000FB")]
			[Address(RVA = "0x294E87C", Offset = "0x294E87C", VA = "0x294E87C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60000F1")]
		[Address(RVA = "0x294E448", Offset = "0x294E448", VA = "0x294E448")]
		public void Disable()
		{
		}

		[Token(Token = "0x60000F2")]
		[Address(RVA = "0x294E4E0", Offset = "0x294E4E0", VA = "0x294E4E0", Slot = "4")]
		protected virtual void InitiateSolver()
		{
		}

		[Token(Token = "0x60000F3")]
		[Address(RVA = "0x294E4E4", Offset = "0x294E4E4", VA = "0x294E4E4", Slot = "5")]
		protected virtual void UpdateSolver()
		{
		}

		[Token(Token = "0x60000F4")]
		[Address(RVA = "0x294E4E8", Offset = "0x294E4E8", VA = "0x294E4E8", Slot = "6")]
		protected virtual void FixTransforms()
		{
		}

		[Token(Token = "0x60000F5")]
		[Address(RVA = "0x294E4EC", Offset = "0x294E4EC", VA = "0x294E4EC")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60000F6")]
		[Address(RVA = "0x294E57C", Offset = "0x294E57C", VA = "0x294E57C")]
		private void Start()
		{
		}

		[Token(Token = "0x60000F8")]
		[Address(RVA = "0x294E524", Offset = "0x294E524", VA = "0x294E524")]
		private void Initiate()
		{
		}

		[Token(Token = "0x60000F9")]
		[Address(RVA = "0x294E830", Offset = "0x294E830", VA = "0x294E830")]
		private void Update()
		{
		}

		[Token(Token = "0x60000FA")]
		[Address(RVA = "0x294E670", Offset = "0x294E670", VA = "0x294E670")]
		private void FindAnimatorRecursive(Transform t, bool findInChildren)
		{
		}

		[Token(Token = "0x60000FC")]
		[Address(RVA = "0x294E938", Offset = "0x294E938", VA = "0x294E938")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60000FD")]
		[Address(RVA = "0x294E994", Offset = "0x294E994", VA = "0x294E994")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60000FE")]
		[Address(RVA = "0x294E9F0", Offset = "0x294E9F0", VA = "0x294E9F0")]
		public void UpdateSolverExternal()
		{
		}

		[Token(Token = "0x60000FF")]
		[Address(RVA = "0x293CD2C", Offset = "0x293CD2C", VA = "0x293CD2C")]
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
		[Address(RVA = "0x294EAA0", Offset = "0x294EAA0", VA = "0x294EAA0")]
		private void OnTriggerEnter(Collider collider)
		{
		}

		[Token(Token = "0x6000101")]
		[Address(RVA = "0x294EB58", Offset = "0x294EB58", VA = "0x294EB58")]
		private void OnTriggerStay(Collider collider)
		{
		}

		[Token(Token = "0x6000102")]
		[Address(RVA = "0x294EC10", Offset = "0x294EC10", VA = "0x294EC10")]
		private void OnTriggerExit(Collider collider)
		{
		}

		[Token(Token = "0x6000103")]
		[Address(RVA = "0x294ECC8", Offset = "0x294ECC8", VA = "0x294ECC8")]
		public TriggerEventBroadcaster()
		{
		}
	}
	[Token(Token = "0x2000023")]
	public static class V3Tools
	{
		[Token(Token = "0x6000104")]
		[Address(RVA = "0x294ECD0", Offset = "0x294ECD0", VA = "0x294ECD0")]
		public static Vector3 Lerp(Vector3 fromVector, Vector3 toVector, float weight)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000105")]
		[Address(RVA = "0x294EDC8", Offset = "0x294EDC8", VA = "0x294EDC8")]
		public static Vector3 Slerp(Vector3 fromVector, Vector3 toVector, float weight)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000106")]
		[Address(RVA = "0x294EEC0", Offset = "0x294EEC0", VA = "0x294EEC0")]
		public static Vector3 ExtractVertical(Vector3 v, Vector3 verticalAxis, float weight)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000107")]
		[Address(RVA = "0x294EFB8", Offset = "0x294EFB8", VA = "0x294EFB8")]
		public static Vector3 ExtractHorizontal(Vector3 v, Vector3 normal, float weight)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000108")]
		[Address(RVA = "0x294F0B8", Offset = "0x294F0B8", VA = "0x294F0B8")]
		public static Vector3 ClampDirection(Vector3 direction, Vector3 normalDirection, float clampWeight, int clampSmoothing)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000109")]
		[Address(RVA = "0x294F2DC", Offset = "0x294F2DC", VA = "0x294F2DC")]
		public static Vector3 ClampDirection(Vector3 direction, Vector3 normalDirection, float clampWeight, int clampSmoothing, out bool changed)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600010A")]
		[Address(RVA = "0x294F518", Offset = "0x294F518", VA = "0x294F518")]
		public static Vector3 ClampDirection(Vector3 direction, Vector3 normalDirection, float clampWeight, int clampSmoothing, out float clampValue)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600010B")]
		[Address(RVA = "0x294F768", Offset = "0x294F768", VA = "0x294F768")]
		public static Vector3 LineToPlane(Vector3 origin, Vector3 direction, Vector3 planeNormal, Vector3 planePoint)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600010C")]
		[Address(RVA = "0x294F968", Offset = "0x294F968", VA = "0x294F968")]
		public static Vector3 PointToPlane(Vector3 point, Vector3 planePosition, Vector3 planeNormal)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600010D")]
		[Address(RVA = "0x294FB44", Offset = "0x294FB44", VA = "0x294FB44")]
		public static Vector3 TransformPointUnscaled(Transform t, Vector3 point)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600010E")]
		[Address(RVA = "0x294FC78", Offset = "0x294FC78", VA = "0x294FC78")]
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
		[Address(RVA = "0x294FDD0", Offset = "0x294FDD0", VA = "0x294FDD0")]
		public static void Log(string message, Logger logger, bool logInEditMode = false)
		{
		}

		[Token(Token = "0x6000110")]
		[Address(RVA = "0x2939094", Offset = "0x2939094", VA = "0x2939094")]
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
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1442758", Offset = "0x1442758")]
		public bool activeTargetSeeking;

		[Token(Token = "0x40000D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1442790", Offset = "0x1442790")]
		public float cornerRadius;

		[Token(Token = "0x40000D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14427C8", Offset = "0x14427C8")]
		public float recalculateOnPathDistance;

		[Token(Token = "0x40000D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1442800", Offset = "0x1442800")]
		public float maxSampleDistance;

		[Token(Token = "0x40000D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1442838", Offset = "0x1442838")]
		public float nextPathInterval;

		[Token(Token = "0x40000D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1442870", Offset = "0x1442870")]
		private Vector3 <normalizedDeltaPosition>k__BackingField;

		[Token(Token = "0x40000D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1442880", Offset = "0x1442880")]
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
			[Address(RVA = "0x2A71F4C", Offset = "0x2A71F4C", VA = "0x2A71F4C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1449B78", Offset = "0x1449B78")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000112")]
			[Address(RVA = "0x2A71F58", Offset = "0x2A71F58", VA = "0x2A71F58")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1449B88", Offset = "0x1449B88")]
			private set
			{
			}
		}

		[Token(Token = "0x17000011")]
		public State state
		{
			[Token(Token = "0x6000113")]
			[Address(RVA = "0x2A71F64", Offset = "0x2A71F64", VA = "0x2A71F64")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1449B98", Offset = "0x1449B98")]
			get
			{
				return default(State);
			}
			[Token(Token = "0x6000114")]
			[Address(RVA = "0x2A71F6C", Offset = "0x2A71F6C", VA = "0x2A71F6C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1449BA8", Offset = "0x1449BA8")]
			private set
			{
			}
		}

		[Token(Token = "0x6000115")]
		[Address(RVA = "0x2A71F74", Offset = "0x2A71F74", VA = "0x2A71F74")]
		public void Initiate(Transform transform)
		{
		}

		[Token(Token = "0x6000116")]
		[Address(RVA = "0x2A72048", Offset = "0x2A72048", VA = "0x2A72048")]
		public void Update(Vector3 targetPosition)
		{
		}

		[Token(Token = "0x6000117")]
		[Address(RVA = "0x2A7258C", Offset = "0x2A7258C", VA = "0x2A7258C")]
		private void CalculatePath(Vector3 targetPosition)
		{
		}

		[Token(Token = "0x6000118")]
		[Address(RVA = "0x2A725FC", Offset = "0x2A725FC", VA = "0x2A725FC")]
		private bool Find(Vector3 targetPosition)
		{
			return default(bool);
		}

		[Token(Token = "0x6000119")]
		[Address(RVA = "0x2A72454", Offset = "0x2A72454", VA = "0x2A72454")]
		private void Stop()
		{
		}

		[Token(Token = "0x600011A")]
		[Address(RVA = "0x2A724C8", Offset = "0x2A724C8", VA = "0x2A724C8")]
		private float HorDistance(Vector3 p1, Vector3 p2)
		{
			return default(float);
		}

		[Token(Token = "0x600011B")]
		[Address(RVA = "0x2A72744", Offset = "0x2A72744", VA = "0x2A72744")]
		public void Visualize()
		{
		}

		[Token(Token = "0x600011C")]
		[Address(RVA = "0x2A728F4", Offset = "0x2A728F4", VA = "0x2A728F4")]
		public Navigator()
		{
		}
	}
}
namespace RootMotion.FinalIK
{
	[Token(Token = "0x2000026")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x14413D8", Offset = "0x14413D8")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x14413D8", Offset = "0x14413D8")]
	public class BipedIK : SolverManager
	{
		[Token(Token = "0x40000DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public BipedReferences references;

		[Token(Token = "0x40000E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public BipedIKSolvers solvers;

		[Token(Token = "0x600011D")]
		[Address(RVA = "0x2A784B8", Offset = "0x2A784B8", VA = "0x2A784B8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x1449BB8", Offset = "0x1449BB8")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x600011E")]
		[Address(RVA = "0x2A78504", Offset = "0x2A78504", VA = "0x2A78504")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x1449BF0", Offset = "0x1449BF0")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x600011F")]
		[Address(RVA = "0x2A78550", Offset = "0x2A78550", VA = "0x2A78550")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x1449C28", Offset = "0x1449C28")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000120")]
		[Address(RVA = "0x2A7859C", Offset = "0x2A7859C", VA = "0x2A7859C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x1449C60", Offset = "0x1449C60")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000121")]
		[Address(RVA = "0x2A785E8", Offset = "0x2A785E8", VA = "0x2A785E8")]
		public float GetIKPositionWeight(AvatarIKGoal goal)
		{
			return default(float);
		}

		[Token(Token = "0x6000122")]
		[Address(RVA = "0x2A78684", Offset = "0x2A78684", VA = "0x2A78684")]
		public float GetIKRotationWeight(AvatarIKGoal goal)
		{
			return default(float);
		}

		[Token(Token = "0x6000123")]
		[Address(RVA = "0x2A786A4", Offset = "0x2A786A4", VA = "0x2A786A4")]
		public void SetIKPositionWeight(AvatarIKGoal goal, float weight)
		{
		}

		[Token(Token = "0x6000124")]
		[Address(RVA = "0x2A786D4", Offset = "0x2A786D4", VA = "0x2A786D4")]
		public void SetIKRotationWeight(AvatarIKGoal goal, float weight)
		{
		}

		[Token(Token = "0x6000125")]
		[Address(RVA = "0x2A78704", Offset = "0x2A78704", VA = "0x2A78704")]
		public void SetIKPosition(AvatarIKGoal goal, Vector3 IKPosition)
		{
		}

		[Token(Token = "0x6000126")]
		[Address(RVA = "0x2A78744", Offset = "0x2A78744", VA = "0x2A78744")]
		public void SetIKRotation(AvatarIKGoal goal, Quaternion IKRotation)
		{
		}

		[Token(Token = "0x6000127")]
		[Address(RVA = "0x2A78788", Offset = "0x2A78788", VA = "0x2A78788")]
		public Vector3 GetIKPosition(AvatarIKGoal goal)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000128")]
		[Address(RVA = "0x2A787AC", Offset = "0x2A787AC", VA = "0x2A787AC")]
		public Quaternion GetIKRotation(AvatarIKGoal goal)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000129")]
		[Address(RVA = "0x2A787D0", Offset = "0x2A787D0", VA = "0x2A787D0")]
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight, float clampWeight, float clampWeightHead, float clampWeightEyes)
		{
		}

		[Token(Token = "0x600012A")]
		[Address(RVA = "0x2A787F8", Offset = "0x2A787F8", VA = "0x2A787F8")]
		public void SetLookAtPosition(Vector3 lookAtPosition)
		{
		}

		[Token(Token = "0x600012B")]
		[Address(RVA = "0x2A78824", Offset = "0x2A78824", VA = "0x2A78824")]
		public void SetSpinePosition(Vector3 spinePosition)
		{
		}

		[Token(Token = "0x600012C")]
		[Address(RVA = "0x2A78850", Offset = "0x2A78850", VA = "0x2A78850")]
		public void SetSpineWeight(float weight)
		{
		}

		[Token(Token = "0x600012D")]
		[Address(RVA = "0x2A78608", Offset = "0x2A78608", VA = "0x2A78608")]
		public IKSolverLimb GetGoalIK(AvatarIKGoal goal)
		{
			return null;
		}

		[Token(Token = "0x600012E")]
		[Address(RVA = "0x2A78878", Offset = "0x2A78878", VA = "0x2A78878")]
		public void InitiateBipedIK()
		{
		}

		[Token(Token = "0x600012F")]
		[Address(RVA = "0x2A78884", Offset = "0x2A78884", VA = "0x2A78884")]
		public void UpdateBipedIK()
		{
		}

		[Token(Token = "0x6000130")]
		[Address(RVA = "0x2A78890", Offset = "0x2A78890", VA = "0x2A78890")]
		public void SetToDefaults()
		{
		}

		[Token(Token = "0x6000131")]
		[Address(RVA = "0x2A78B78", Offset = "0x2A78B78", VA = "0x2A78B78", Slot = "6")]
		protected override void FixTransforms()
		{
		}

		[Token(Token = "0x6000132")]
		[Address(RVA = "0x2A78C20", Offset = "0x2A78C20", VA = "0x2A78C20", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x6000133")]
		[Address(RVA = "0x2A78F64", Offset = "0x2A78F64", VA = "0x2A78F64", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x6000134")]
		[Address(RVA = "0x2A7944C", Offset = "0x2A7944C", VA = "0x2A7944C")]
		public void LogWarning(string message)
		{
		}

		[Token(Token = "0x6000135")]
		[Address(RVA = "0x2A79480", Offset = "0x2A79480", VA = "0x2A79480")]
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
			[Address(RVA = "0x2A78A30", Offset = "0x2A78A30", VA = "0x2A78A30")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000013")]
		public IKSolver[] ikSolvers
		{
			[Token(Token = "0x6000137")]
			[Address(RVA = "0x2A79648", Offset = "0x2A79648", VA = "0x2A79648")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000138")]
		[Address(RVA = "0x2A78DEC", Offset = "0x2A78DEC", VA = "0x2A78DEC")]
		public void AssignReferences(BipedReferences references)
		{
		}

		[Token(Token = "0x6000139")]
		[Address(RVA = "0x2A79500", Offset = "0x2A79500", VA = "0x2A79500")]
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
			[Address(RVA = "0x2A7C88C", Offset = "0x2A7C88C", VA = "0x2A7C88C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600013B")]
		public abstract void UpdateConstraint();

		[Token(Token = "0x600013C")]
		[Address(RVA = "0x2A7C8FC", Offset = "0x2A7C8FC", VA = "0x2A7C8FC")]
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
		[Address(RVA = "0x2A7C904", Offset = "0x2A7C904", VA = "0x2A7C904", Slot = "4")]
		public override void UpdateConstraint()
		{
		}

		[Token(Token = "0x600013E")]
		[Address(RVA = "0x2A7CA10", Offset = "0x2A7CA10", VA = "0x2A7CA10")]
		public ConstraintPosition()
		{
		}

		[Token(Token = "0x600013F")]
		[Address(RVA = "0x2A7CA18", Offset = "0x2A7CA18", VA = "0x2A7CA18")]
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
			[Address(RVA = "0x2A7CBE0", Offset = "0x2A7CBE0", VA = "0x2A7CBE0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000140")]
		[Address(RVA = "0x2A7CA44", Offset = "0x2A7CA44", VA = "0x2A7CA44", Slot = "4")]
		public override void UpdateConstraint()
		{
		}

		[Token(Token = "0x6000141")]
		[Address(RVA = "0x2A7CC9C", Offset = "0x2A7CC9C", VA = "0x2A7CC9C")]
		public ConstraintPositionOffset()
		{
		}

		[Token(Token = "0x6000142")]
		[Address(RVA = "0x2A7CCA4", Offset = "0x2A7CCA4", VA = "0x2A7CCA4")]
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
		[Address(RVA = "0x2A7CCD0", Offset = "0x2A7CCD0", VA = "0x2A7CCD0", Slot = "4")]
		public override void UpdateConstraint()
		{
		}

		[Token(Token = "0x6000145")]
		[Address(RVA = "0x2A7CDF8", Offset = "0x2A7CDF8", VA = "0x2A7CDF8")]
		public ConstraintRotation()
		{
		}

		[Token(Token = "0x6000146")]
		[Address(RVA = "0x2A7CE00", Offset = "0x2A7CE00", VA = "0x2A7CE00")]
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
			[Address(RVA = "0x2A7CFCC", Offset = "0x2A7CFCC", VA = "0x2A7CFCC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000147")]
		[Address(RVA = "0x2A7CE2C", Offset = "0x2A7CE2C", VA = "0x2A7CE2C", Slot = "4")]
		public override void UpdateConstraint()
		{
		}

		[Token(Token = "0x6000148")]
		[Address(RVA = "0x2A7D09C", Offset = "0x2A7D09C", VA = "0x2A7D09C")]
		public ConstraintRotationOffset()
		{
		}

		[Token(Token = "0x6000149")]
		[Address(RVA = "0x2A7D0A4", Offset = "0x2A7D0A4", VA = "0x2A7D0A4")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1442890", Offset = "0x1442890")]
		public float positionWeight;

		[Token(Token = "0x40000FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public Vector3 rotationOffset;

		[Token(Token = "0x40000FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Vector3 rotation;

		[Token(Token = "0x4000100")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x14428A8", Offset = "0x14428A8")]
		public float rotationWeight;

		[Token(Token = "0x600014B")]
		[Address(RVA = "0x2A7D0D0", Offset = "0x2A7D0D0", VA = "0x2A7D0D0")]
		public bool IsValid()
		{
			return default(bool);
		}

		[Token(Token = "0x600014C")]
		[Address(RVA = "0x2A78F10", Offset = "0x2A78F10", VA = "0x2A78F10")]
		public void Initiate(Transform transform)
		{
		}

		[Token(Token = "0x600014D")]
		[Address(RVA = "0x2A790EC", Offset = "0x2A790EC", VA = "0x2A790EC")]
		public void Update()
		{
		}

		[Token(Token = "0x600014E")]
		[Address(RVA = "0x2A79814", Offset = "0x2A79814", VA = "0x2A79814")]
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
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14428C0", Offset = "0x14428C0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x14428C0", Offset = "0x14428C0")]
		public float weight;

		[Token(Token = "0x4000102")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1442914", Offset = "0x1442914")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1442914", Offset = "0x1442914")]
		public float rotationWeight;

		[Token(Token = "0x4000103")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1442968", Offset = "0x1442968")]
		public DOF rotationDOF;

		[Token(Token = "0x4000104")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14429A0", Offset = "0x14429A0")]
		public bool fixBone1Twist;

		[Token(Token = "0x4000105")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14429D8", Offset = "0x14429D8")]
		public Transform bone1;

		[Token(Token = "0x4000106")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1442A10", Offset = "0x1442A10")]
		public Transform bone2;

		[Token(Token = "0x4000107")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1442A48", Offset = "0x1442A48")]
		public Transform bone3;

		[Token(Token = "0x4000108")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1442A80", Offset = "0x1442A80")]
		public Transform tip;

		[Token(Token = "0x4000109")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1442AB8", Offset = "0x1442AB8")]
		public Transform target;

		[Token(Token = "0x400010A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1442AF0", Offset = "0x1442AF0")]
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
			[Address(RVA = "0x2A84408", Offset = "0x2A84408", VA = "0x2A84408")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1449C98", Offset = "0x1449C98")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000150")]
			[Address(RVA = "0x2A84410", Offset = "0x2A84410", VA = "0x2A84410")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1449CA8", Offset = "0x1449CA8")]
			private set
			{
			}
		}

		[Token(Token = "0x17000018")]
		public Vector3 IKPosition
		{
			[Token(Token = "0x6000151")]
			[Address(RVA = "0x2A8441C", Offset = "0x2A8441C", VA = "0x2A8441C")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000152")]
			[Address(RVA = "0x2A8443C", Offset = "0x2A8443C", VA = "0x2A8443C")]
			set
			{
			}
		}

		[Token(Token = "0x17000019")]
		public Quaternion IKRotation
		{
			[Token(Token = "0x6000153")]
			[Address(RVA = "0x2A8445C", Offset = "0x2A8445C", VA = "0x2A8445C")]
			get
			{
				return default(Quaternion);
			}
			[Token(Token = "0x6000154")]
			[Address(RVA = "0x2A8447C", Offset = "0x2A8447C", VA = "0x2A8447C")]
			set
			{
			}
		}

		[Token(Token = "0x6000155")]
		[Address(RVA = "0x2A8449C", Offset = "0x2A8449C", VA = "0x2A8449C")]
		public bool IsValid(ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000156")]
		[Address(RVA = "0x2A8459C", Offset = "0x2A8459C", VA = "0x2A8459C")]
		public void Initiate(Transform hand, int index)
		{
		}

		[Token(Token = "0x6000157")]
		[Address(RVA = "0x2A84B30", Offset = "0x2A84B30", VA = "0x2A84B30")]
		public void FixTransforms()
		{
		}

		[Token(Token = "0x6000158")]
		[Address(RVA = "0x2A84C0C", Offset = "0x2A84C0C", VA = "0x2A84C0C")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000159")]
		[Address(RVA = "0x2A84CD4", Offset = "0x2A84CD4", VA = "0x2A84CD4")]
		public void Update(float masterWeight)
		{
		}

		[Token(Token = "0x600015A")]
		[Address(RVA = "0x2A85418", Offset = "0x2A85418", VA = "0x2A85418")]
		public Finger()
		{
		}
	}
	[Token(Token = "0x200002F")]
	public class FingerRig : SolverManager
	{
		[Token(Token = "0x4000112")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1442B00", Offset = "0x1442B00")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1442B00", Offset = "0x1442B00")]
		public float weight;

		[Token(Token = "0x4000113")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Finger[] fingers;

		[Token(Token = "0x4000114")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1442B54", Offset = "0x1442B54")]
		private bool <initiated>k__BackingField;

		[Token(Token = "0x1700001A")]
		public bool initiated
		{
			[Token(Token = "0x600015B")]
			[Address(RVA = "0x2DB4188", Offset = "0x2DB4188", VA = "0x2DB4188")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1449CB8", Offset = "0x1449CB8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600015C")]
			[Address(RVA = "0x2DB4190", Offset = "0x2DB4190", VA = "0x2DB4190")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1449CC8", Offset = "0x1449CC8")]
			private set
			{
			}
		}

		[Token(Token = "0x600015D")]
		[Address(RVA = "0x2DB419C", Offset = "0x2DB419C", VA = "0x2DB419C")]
		public bool IsValid(ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x600015E")]
		[Address(RVA = "0x2DB4228", Offset = "0x2DB4228", VA = "0x2DB4228")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x1449CD8", Offset = "0x1449CD8")]
		public void AutoDetect()
		{
		}

		[Token(Token = "0x600015F")]
		[Address(RVA = "0x2DB4544", Offset = "0x2DB4544", VA = "0x2DB4544")]
		public void AddFinger(Transform bone1, Transform bone2, Transform bone3, Transform tip, [Optional] Transform target)
		{
		}

		[Token(Token = "0x6000160")]
		[Address(RVA = "0x2DB46B8", Offset = "0x2DB46B8", VA = "0x2DB46B8")]
		public void RemoveFinger(int index)
		{
		}

		[Token(Token = "0x6000161")]
		[Address(RVA = "0x2DB443C", Offset = "0x2DB443C", VA = "0x2DB443C")]
		private void AddChildrenRecursive(Transform parent, ref Transform[] array)
		{
		}

		[Token(Token = "0x6000162")]
		[Address(RVA = "0x2DB4820", Offset = "0x2DB4820", VA = "0x2DB4820", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x6000163")]
		[Address(RVA = "0x2DB48E8", Offset = "0x2DB48E8", VA = "0x2DB48E8")]
		public void UpdateFingerSolvers()
		{
		}

		[Token(Token = "0x6000164")]
		[Address(RVA = "0x2DB4964", Offset = "0x2DB4964", VA = "0x2DB4964")]
		public void FixFingerTransforms()
		{
		}

		[Token(Token = "0x6000165")]
		[Address(RVA = "0x2DB49DC", Offset = "0x2DB49DC", VA = "0x2DB49DC")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000166")]
		[Address(RVA = "0x2DB4A48", Offset = "0x2DB4A48", VA = "0x2DB4A48", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x6000167")]
		[Address(RVA = "0x2DB4A4C", Offset = "0x2DB4A4C", VA = "0x2DB4A4C", Slot = "6")]
		protected override void FixTransforms()
		{
		}

		[Token(Token = "0x6000168")]
		[Address(RVA = "0x2DB4A60", Offset = "0x2DB4A60", VA = "0x2DB4A60")]
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
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1442B64", Offset = "0x1442B64")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1442B64", Offset = "0x1442B64")]
		public float weight;

		[Token(Token = "0x4000116")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1442BB8", Offset = "0x1442BB8")]
		public Grounding solver;

		[Token(Token = "0x4000117")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public GrounderDelegate OnPreGrounder;

		[Token(Token = "0x4000118")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public GrounderDelegate OnPostGrounder;

		[Token(Token = "0x4000119")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1442BF0", Offset = "0x1442BF0")]
		private bool <initiated>k__BackingField;

		[Token(Token = "0x1700001B")]
		public bool initiated
		{
			[Token(Token = "0x600016A")]
			[Address(RVA = "0x2DB5A9C", Offset = "0x2DB5A9C", VA = "0x2DB5A9C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1449D10", Offset = "0x1449D10")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600016B")]
			[Address(RVA = "0x2DB5AA4", Offset = "0x2DB5AA4", VA = "0x2DB5AA4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1449D20", Offset = "0x1449D20")]
			protected set
			{
			}
		}

		[Token(Token = "0x6000169")]
		public abstract void ResetPosition();

		[Token(Token = "0x600016C")]
		[Address(RVA = "0x2DB5AB0", Offset = "0x2DB5AB0", VA = "0x2DB5AB0")]
		protected Vector3 GetSpineOffsetTarget()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600016D")]
		[Address(RVA = "0x2DB5D84", Offset = "0x2DB5D84", VA = "0x2DB5D84")]
		protected void LogWarning(string message)
		{
		}

		[Token(Token = "0x600016E")]
		[Address(RVA = "0x2DB5BF4", Offset = "0x2DB5BF4", VA = "0x2DB5BF4")]
		private Vector3 GetLegSpineBendVector(Grounding.Leg leg)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600016F")]
		[Address(RVA = "0x2DB5DB8", Offset = "0x2DB5DB8", VA = "0x2DB5DB8")]
		private Vector3 GetLegSpineTangent(Grounding.Leg leg)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000170")]
		protected abstract void OpenUserManual();

		[Token(Token = "0x6000171")]
		protected abstract void OpenScriptReference();

		[Token(Token = "0x6000172")]
		[Address(RVA = "0x2DB5FC0", Offset = "0x2DB5FC0", VA = "0x2DB5FC0")]
		protected Grounder()
		{
		}
	}
	[Token(Token = "0x2000031")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x1441438", Offset = "0x1441438")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x1441438", Offset = "0x1441438")]
	public class GrounderBipedIK : Grounder
	{
		[Token(Token = "0x400011A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1442C00", Offset = "0x1442C00")]
		public BipedIK ik;

		[Token(Token = "0x400011B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1442C38", Offset = "0x1442C38")]
		public float spineBend;

		[Token(Token = "0x400011C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1442C70", Offset = "0x1442C70")]
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
		[Address(RVA = "0x2DB6328", Offset = "0x2DB6328", VA = "0x2DB6328", Slot = "5")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x1449D30", Offset = "0x1449D30")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000174")]
		[Address(RVA = "0x2DB6374", Offset = "0x2DB6374", VA = "0x2DB6374", Slot = "6")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x1449D68", Offset = "0x1449D68")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000175")]
		[Address(RVA = "0x2DB63C0", Offset = "0x2DB63C0", VA = "0x2DB63C0", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x6000176")]
		[Address(RVA = "0x2DB64C4", Offset = "0x2DB64C4", VA = "0x2DB64C4")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x6000177")]
		[Address(RVA = "0x2DB6574", Offset = "0x2DB6574", VA = "0x2DB6574")]
		private void Update()
		{
		}

		[Token(Token = "0x6000178")]
		[Address(RVA = "0x2DB6628", Offset = "0x2DB6628", VA = "0x2DB6628")]
		private void Initiate()
		{
		}

		[Token(Token = "0x6000179")]
		[Address(RVA = "0x2DB6B3C", Offset = "0x2DB6B3C", VA = "0x2DB6B3C")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600017A")]
		[Address(RVA = "0x2DB6B90", Offset = "0x2DB6B90", VA = "0x2DB6B90")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x600017B")]
		[Address(RVA = "0x2DB7344", Offset = "0x2DB7344", VA = "0x2DB7344")]
		private void SetLegIK(IKSolverLimb limb, int index)
		{
		}

		[Token(Token = "0x600017C")]
		[Address(RVA = "0x2DB74A4", Offset = "0x2DB74A4", VA = "0x2DB74A4")]
		private void OnPostSolverUpdate()
		{
		}

		[Token(Token = "0x600017D")]
		[Address(RVA = "0x2DB7634", Offset = "0x2DB7634", VA = "0x2DB7634")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600017E")]
		[Address(RVA = "0x2DB77A4", Offset = "0x2DB77A4", VA = "0x2DB77A4")]
		public GrounderBipedIK()
		{
		}
	}
	[Token(Token = "0x2000032")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x1441498", Offset = "0x1441498")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x1441498", Offset = "0x1441498")]
	public class GrounderFBBIK : Grounder
	{
		[Serializable]
		[Token(Token = "0x2000190")]
		public class SpineEffector
		{
			[Token(Token = "0x4000997")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1446548", Offset = "0x1446548")]
			public FullBodyBipedEffector effectorType;

			[Token(Token = "0x4000998")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1446580", Offset = "0x1446580")]
			public float horizontalWeight;

			[Token(Token = "0x4000999")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14465B8", Offset = "0x14465B8")]
			public float verticalWeight;

			[Token(Token = "0x6000BB6")]
			[Address(RVA = "0x2DB860C", Offset = "0x2DB860C", VA = "0x2DB860C")]
			public SpineEffector()
			{
			}

			[Token(Token = "0x6000BB7")]
			[Address(RVA = "0x2DB861C", Offset = "0x2DB861C", VA = "0x2DB861C")]
			public SpineEffector(FullBodyBipedEffector effectorType, float horizontalWeight, float verticalWeight)
			{
			}
		}

		[Token(Token = "0x4000123")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1442CA8", Offset = "0x1442CA8")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x4000124")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1442CE0", Offset = "0x1442CE0")]
		public float spineBend;

		[Token(Token = "0x4000125")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1442D18", Offset = "0x1442D18")]
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
		[Address(RVA = "0x2DB7824", Offset = "0x2DB7824", VA = "0x2DB7824")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x1449DA0", Offset = "0x1449DA0")]
		private void OpenTutorial()
		{
		}

		[Token(Token = "0x6000180")]
		[Address(RVA = "0x2DB7870", Offset = "0x2DB7870", VA = "0x2DB7870", Slot = "5")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x1449DD8", Offset = "0x1449DD8")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000181")]
		[Address(RVA = "0x2DB78BC", Offset = "0x2DB78BC", VA = "0x2DB78BC", Slot = "6")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x1449E10", Offset = "0x1449E10")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000182")]
		[Address(RVA = "0x2DB7908", Offset = "0x2DB7908", VA = "0x2DB7908", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x6000183")]
		[Address(RVA = "0x2DB7988", Offset = "0x2DB7988", VA = "0x2DB7988")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x6000184")]
		[Address(RVA = "0x2DB7A20", Offset = "0x2DB7A20", VA = "0x2DB7A20")]
		private void Update()
		{
		}

		[Token(Token = "0x6000185")]
		[Address(RVA = "0x2DB7CDC", Offset = "0x2DB7CDC", VA = "0x2DB7CDC")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000186")]
		[Address(RVA = "0x2DB7CE8", Offset = "0x2DB7CE8", VA = "0x2DB7CE8")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000187")]
		[Address(RVA = "0x2DB7ADC", Offset = "0x2DB7ADC", VA = "0x2DB7ADC")]
		private void Initiate()
		{
		}

		[Token(Token = "0x6000188")]
		[Address(RVA = "0x2DB7CF4", Offset = "0x2DB7CF4", VA = "0x2DB7CF4")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x6000189")]
		[Address(RVA = "0x2DB8194", Offset = "0x2DB8194", VA = "0x2DB8194")]
		private void SetLegIK(IKEffector effector, Grounding.Leg leg)
		{
		}

		[Token(Token = "0x600018A")]
		[Address(RVA = "0x2DB8354", Offset = "0x2DB8354", VA = "0x2DB8354")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x600018B")]
		[Address(RVA = "0x2DB848C", Offset = "0x2DB848C", VA = "0x2DB848C")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600018C")]
		[Address(RVA = "0x2DB858C", Offset = "0x2DB858C", VA = "0x2DB858C")]
		public GrounderFBBIK()
		{
		}
	}
	[Token(Token = "0x2000033")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x14414F8", Offset = "0x14414F8")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x14414F8", Offset = "0x14414F8")]
	public class GrounderIK : Grounder
	{
		[Token(Token = "0x400012A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public IK[] legs;

		[Token(Token = "0x400012B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1442D50", Offset = "0x1442D50")]
		public Transform pelvis;

		[Token(Token = "0x400012C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1442D88", Offset = "0x1442D88")]
		public Transform characterRoot;

		[Token(Token = "0x400012D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1442DC0", Offset = "0x1442DC0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1442DC0", Offset = "0x1442DC0")]
		public float rootRotationWeight;

		[Token(Token = "0x400012E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1442E14", Offset = "0x1442E14")]
		public float rootRotationSpeed;

		[Token(Token = "0x400012F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1442E4C", Offset = "0x1442E4C")]
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
		[Address(RVA = "0x2DB8664", Offset = "0x2DB8664", VA = "0x2DB8664", Slot = "5")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x1449E48", Offset = "0x1449E48")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x600018E")]
		[Address(RVA = "0x2DB86B0", Offset = "0x2DB86B0", VA = "0x2DB86B0", Slot = "6")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x1449E80", Offset = "0x1449E80")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x600018F")]
		[Address(RVA = "0x2DB86FC", Offset = "0x2DB86FC", VA = "0x2DB86FC", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x6000190")]
		[Address(RVA = "0x2DB8714", Offset = "0x2DB8714", VA = "0x2DB8714")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x6000191")]
		[Address(RVA = "0x2DB8904", Offset = "0x2DB8904", VA = "0x2DB8904")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000192")]
		[Address(RVA = "0x2DB8A04", Offset = "0x2DB8A04", VA = "0x2DB8A04")]
		private void Update()
		{
		}

		[Token(Token = "0x6000193")]
		[Address(RVA = "0x2DB914C", Offset = "0x2DB914C", VA = "0x2DB914C")]
		private void Initiate()
		{
		}

		[Token(Token = "0x6000194")]
		[Address(RVA = "0x2DB9530", Offset = "0x2DB9530", VA = "0x2DB9530")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x6000195")]
		[Address(RVA = "0x2DB97A0", Offset = "0x2DB97A0", VA = "0x2DB97A0")]
		private void SetLegIK(int index)
		{
		}

		[Token(Token = "0x6000196")]
		[Address(RVA = "0x2DB9AC0", Offset = "0x2DB9AC0", VA = "0x2DB9AC0")]
		private void OnPostSolverUpdate()
		{
		}

		[Token(Token = "0x6000197")]
		[Address(RVA = "0x2DB9C5C", Offset = "0x2DB9C5C", VA = "0x2DB9C5C")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000198")]
		[Address(RVA = "0x2DB9E24", Offset = "0x2DB9E24", VA = "0x2DB9E24")]
		public GrounderIK()
		{
		}
	}
	[Token(Token = "0x2000034")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x1441558", Offset = "0x1441558")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x1441558", Offset = "0x1441558")]
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
			[Address(RVA = "0x15856C0", Offset = "0x15856C0", VA = "0x15856C0")]
			public Foot(IKSolver solver, Transform transform)
			{
			}
		}

		[Token(Token = "0x4000138")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1442E84", Offset = "0x1442E84")]
		public Grounding forelegSolver;

		[Token(Token = "0x4000139")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1442EBC", Offset = "0x1442EBC")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1442EBC", Offset = "0x1442EBC")]
		public float rootRotationWeight;

		[Token(Token = "0x400013A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1442F10", Offset = "0x1442F10")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1442F10", Offset = "0x1442F10")]
		public float minRootRotation;

		[Token(Token = "0x400013B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1442F68", Offset = "0x1442F68")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1442F68", Offset = "0x1442F68")]
		public float maxRootRotation;

		[Token(Token = "0x400013C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1442FC0", Offset = "0x1442FC0")]
		public float rootRotationSpeed;

		[Token(Token = "0x400013D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1442FF8", Offset = "0x1442FF8")]
		public float maxLegOffset;

		[Token(Token = "0x400013E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1443030", Offset = "0x1443030")]
		public float maxForeLegOffset;

		[Token(Token = "0x400013F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1443068", Offset = "0x1443068")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1443068", Offset = "0x1443068")]
		public float maintainHeadRotationWeight;

		[Token(Token = "0x4000140")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14430BC", Offset = "0x14430BC")]
		public Transform characterRoot;

		[Token(Token = "0x4000141")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14430F4", Offset = "0x14430F4")]
		public Transform pelvis;

		[Token(Token = "0x4000142")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x144312C", Offset = "0x144312C")]
		public Transform lastSpineBone;

		[Token(Token = "0x4000143")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1443164", Offset = "0x1443164")]
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
		[Address(RVA = "0x2DB9EA4", Offset = "0x2DB9EA4", VA = "0x2DB9EA4", Slot = "5")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x1449EB8", Offset = "0x1449EB8")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x600019A")]
		[Address(RVA = "0x2DB9EF0", Offset = "0x2DB9EF0", VA = "0x2DB9EF0", Slot = "6")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x1449EF0", Offset = "0x1449EF0")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x600019B")]
		[Address(RVA = "0x2DB9F3C", Offset = "0x2DB9F3C", VA = "0x2DB9F3C", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x600019C")]
		[Address(RVA = "0x2DB9F70", Offset = "0x2DB9F70", VA = "0x2DB9F70")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x600019D")]
		[Address(RVA = "0x2DBA0A0", Offset = "0x2DBA0A0", VA = "0x2DBA0A0")]
		private bool IsReadyToInitiateLegs(IK[] ikComponents)
		{
			return default(bool);
		}

		[Token(Token = "0x600019E")]
		[Address(RVA = "0x2DBA260", Offset = "0x2DBA260", VA = "0x2DBA260")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600019F")]
		[Address(RVA = "0x2DBA2C8", Offset = "0x2DBA2C8", VA = "0x2DBA2C8")]
		private void Update()
		{
		}

		[Token(Token = "0x60001A0")]
		[Address(RVA = "0x2DBA380", Offset = "0x2DBA380", VA = "0x2DBA380")]
		private void Initiate()
		{
		}

		[Token(Token = "0x60001A1")]
		[Address(RVA = "0x2DBA680", Offset = "0x2DBA680", VA = "0x2DBA680")]
		private Transform[] InitiateFeet(IK[] ikComponents, ref Foot[] f, int indexOffset)
		{
			return null;
		}

		[Token(Token = "0x60001A2")]
		[Address(RVA = "0x2DBA9E0", Offset = "0x2DBA9E0", VA = "0x2DBA9E0")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60001A3")]
		[Address(RVA = "0x2DBAB2C", Offset = "0x2DBAB2C", VA = "0x2DBAB2C")]
		private void RootRotation()
		{
		}

		[Token(Token = "0x60001A4")]
		[Address(RVA = "0x2DBAFD0", Offset = "0x2DBAFD0", VA = "0x2DBAFD0")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x60001A5")]
		[Address(RVA = "0x2DBB7C0", Offset = "0x2DBB7C0", VA = "0x2DBB7C0")]
		private void UpdateForefeetRoot()
		{
		}

		[Token(Token = "0x60001A6")]
		[Address(RVA = "0x2DBBA80", Offset = "0x2DBBA80", VA = "0x2DBBA80")]
		private void SetFootIK(Foot foot, float maxOffset)
		{
		}

		[Token(Token = "0x60001A7")]
		[Address(RVA = "0x2DBBBE0", Offset = "0x2DBBBE0", VA = "0x2DBBBE0")]
		private void OnPostSolverUpdate()
		{
		}

		[Token(Token = "0x60001A8")]
		[Address(RVA = "0x2DBBEBC", Offset = "0x2DBBEBC", VA = "0x2DBBEBC")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60001A9")]
		[Address(RVA = "0x2DBBEF4", Offset = "0x2DBBEF4", VA = "0x2DBBEF4")]
		private void DestroyLegs(IK[] ikComponents)
		{
		}

		[Token(Token = "0x60001AA")]
		[Address(RVA = "0x2DBC0B4", Offset = "0x2DBC0B4", VA = "0x2DBC0B4")]
		public GrounderQuadruped()
		{
		}
	}
	[Token(Token = "0x2000035")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x14415B8", Offset = "0x14415B8")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x14415B8", Offset = "0x14415B8")]
	public class GrounderVRIK : Grounder
	{
		[Token(Token = "0x4000155")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14431AC", Offset = "0x14431AC")]
		public VRIK ik;

		[Token(Token = "0x4000156")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Transform[] feet;

		[Token(Token = "0x60001AB")]
		[Address(RVA = "0x2DBC1CC", Offset = "0x2DBC1CC", VA = "0x2DBC1CC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x1449F28", Offset = "0x1449F28")]
		private void OpenTutorial()
		{
		}

		[Token(Token = "0x60001AC")]
		[Address(RVA = "0x2DBC218", Offset = "0x2DBC218", VA = "0x2DBC218", Slot = "5")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x1449F60", Offset = "0x1449F60")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60001AD")]
		[Address(RVA = "0x2DBC264", Offset = "0x2DBC264", VA = "0x2DBC264", Slot = "6")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x1449F98", Offset = "0x1449F98")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60001AE")]
		[Address(RVA = "0x2DBC2B0", Offset = "0x2DBC2B0", VA = "0x2DBC2B0", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x60001AF")]
		[Address(RVA = "0x2DBC2C8", Offset = "0x2DBC2C8", VA = "0x2DBC2C8")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x60001B0")]
		[Address(RVA = "0x2DBC360", Offset = "0x2DBC360", VA = "0x2DBC360")]
		private void Update()
		{
		}

		[Token(Token = "0x60001B1")]
		[Address(RVA = "0x2DBC414", Offset = "0x2DBC414", VA = "0x2DBC414")]
		private void Initiate()
		{
		}

		[Token(Token = "0x60001B2")]
		[Address(RVA = "0x2DBC614", Offset = "0x2DBC614", VA = "0x2DBC614")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x60001B3")]
		[Address(RVA = "0x2DBC8A8", Offset = "0x2DBC8A8", VA = "0x2DBC8A8")]
		private void SetLegIK(IKSolverVR.PositionOffset positionOffset, Transform bone, Grounding.Leg leg)
		{
		}

		[Token(Token = "0x60001B4")]
		[Address(RVA = "0x2DBC9B0", Offset = "0x2DBC9B0", VA = "0x2DBC9B0")]
		private void OnPostSolverUpdate()
		{
		}

		[Token(Token = "0x60001B5")]
		[Address(RVA = "0x2DBCBB0", Offset = "0x2DBCBB0", VA = "0x2DBCBB0")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x60001B6")]
		[Address(RVA = "0x2DBCCE8", Offset = "0x2DBCCE8", VA = "0x2DBCCE8")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60001B7")]
		[Address(RVA = "0x2DBCE48", Offset = "0x2DBCE48", VA = "0x2DBCE48")]
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
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x14465F0", Offset = "0x14465F0")]
			private bool <isGrounded>k__BackingField;

			[Token(Token = "0x40009A3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1446600", Offset = "0x1446600")]
			private Vector3 <IKPosition>k__BackingField;

			[Token(Token = "0x40009A4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Quaternion rotationOffset;

			[Token(Token = "0x40009A5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1446610", Offset = "0x1446610")]
			private bool <initiated>k__BackingField;

			[Token(Token = "0x40009A6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1446620", Offset = "0x1446620")]
			private float <heightFromGround>k__BackingField;

			[Token(Token = "0x40009A7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1446630", Offset = "0x1446630")]
			private Vector3 <velocity>k__BackingField;

			[Token(Token = "0x40009A8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1446640", Offset = "0x1446640")]
			private Transform <transform>k__BackingField;

			[Token(Token = "0x40009A9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1446650", Offset = "0x1446650")]
			private float <IKOffset>k__BackingField;

			[Token(Token = "0x40009AA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			public bool invertFootCenter;

			[Token(Token = "0x40009AB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1446660", Offset = "0x1446660")]
			private RaycastHit <heelHit>k__BackingField;

			[Token(Token = "0x40009AC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1446670", Offset = "0x1446670")]
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
				[Address(RVA = "0x2DBE6BC", Offset = "0x2DBE6BC", VA = "0x2DBE6BC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x144B9D8", Offset = "0x144B9D8")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6000BBA")]
				[Address(RVA = "0x2DBE6C4", Offset = "0x2DBE6C4", VA = "0x2DBE6C4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x144B9E8", Offset = "0x144B9E8")]
				private set
				{
				}
			}

			[Token(Token = "0x1700007C")]
			public Vector3 IKPosition
			{
				[Token(Token = "0x6000BBB")]
				[Address(RVA = "0x2DBE6D0", Offset = "0x2DBE6D0", VA = "0x2DBE6D0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x144B9F8", Offset = "0x144B9F8")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000BBC")]
				[Address(RVA = "0x2DBE6DC", Offset = "0x2DBE6DC", VA = "0x2DBE6DC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x144BA08", Offset = "0x144BA08")]
				private set
				{
				}
			}

			[Token(Token = "0x1700007D")]
			public bool initiated
			{
				[Token(Token = "0x6000BBD")]
				[Address(RVA = "0x2DBE6E8", Offset = "0x2DBE6E8", VA = "0x2DBE6E8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x144BA18", Offset = "0x144BA18")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6000BBE")]
				[Address(RVA = "0x2DBE6F0", Offset = "0x2DBE6F0", VA = "0x2DBE6F0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x144BA28", Offset = "0x144BA28")]
				private set
				{
				}
			}

			[Token(Token = "0x1700007E")]
			public float heightFromGround
			{
				[Token(Token = "0x6000BBF")]
				[Address(RVA = "0x2DBE6FC", Offset = "0x2DBE6FC", VA = "0x2DBE6FC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x144BA38", Offset = "0x144BA38")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000BC0")]
				[Address(RVA = "0x2DBE704", Offset = "0x2DBE704", VA = "0x2DBE704")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x144BA48", Offset = "0x144BA48")]
				private set
				{
				}
			}

			[Token(Token = "0x1700007F")]
			public Vector3 velocity
			{
				[Token(Token = "0x6000BC1")]
				[Address(RVA = "0x2DBE70C", Offset = "0x2DBE70C", VA = "0x2DBE70C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x144BA58", Offset = "0x144BA58")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000BC2")]
				[Address(RVA = "0x2DBE718", Offset = "0x2DBE718", VA = "0x2DBE718")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x144BA68", Offset = "0x144BA68")]
				private set
				{
				}
			}

			[Token(Token = "0x17000080")]
			public Transform transform
			{
				[Token(Token = "0x6000BC3")]
				[Address(RVA = "0x2DBE724", Offset = "0x2DBE724", VA = "0x2DBE724")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x144BA78", Offset = "0x144BA78")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000BC4")]
				[Address(RVA = "0x2DBE72C", Offset = "0x2DBE72C", VA = "0x2DBE72C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x144BA88", Offset = "0x144BA88")]
				private set
				{
				}
			}

			[Token(Token = "0x17000081")]
			public float IKOffset
			{
				[Token(Token = "0x6000BC5")]
				[Address(RVA = "0x2DBE734", Offset = "0x2DBE734", VA = "0x2DBE734")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x144BA98", Offset = "0x144BA98")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000BC6")]
				[Address(RVA = "0x2DBE73C", Offset = "0x2DBE73C", VA = "0x2DBE73C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x144BAA8", Offset = "0x144BAA8")]
				private set
				{
				}
			}

			[Token(Token = "0x17000082")]
			public RaycastHit heelHit
			{
				[Token(Token = "0x6000BC7")]
				[Address(RVA = "0x2DBE744", Offset = "0x2DBE744", VA = "0x2DBE744")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x144BAB8", Offset = "0x144BAB8")]
				get
				{
					return default(RaycastHit);
				}
				[Token(Token = "0x6000BC8")]
				[Address(RVA = "0x2DBE75C", Offset = "0x2DBE75C", VA = "0x2DBE75C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x144BAC8", Offset = "0x144BAC8")]
				private set
				{
				}
			}

			[Token(Token = "0x17000083")]
			public RaycastHit capsuleHit
			{
				[Token(Token = "0x6000BC9")]
				[Address(RVA = "0x2DBE77C", Offset = "0x2DBE77C", VA = "0x2DBE77C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x144BAD8", Offset = "0x144BAD8")]
				get
				{
					return default(RaycastHit);
				}
				[Token(Token = "0x6000BCA")]
				[Address(RVA = "0x2DBE794", Offset = "0x2DBE794", VA = "0x2DBE794")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x144BAE8", Offset = "0x144BAE8")]
				private set
				{
				}
			}

			[Token(Token = "0x17000084")]
			public RaycastHit GetHitPoint
			{
				[Token(Token = "0x6000BCB")]
				[Address(RVA = "0x2DBE7B4", Offset = "0x2DBE7B4", VA = "0x2DBE7B4")]
				get
				{
					return default(RaycastHit);
				}
			}

			[Token(Token = "0x17000085")]
			public float stepHeightFromGround
			{
				[Token(Token = "0x6000BD1")]
				[Address(RVA = "0x2DBF570", Offset = "0x2DBF570", VA = "0x2DBF570")]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x17000086")]
			private float rootYOffset
			{
				[Token(Token = "0x6000BDA")]
				[Address(RVA = "0x2DBF848", Offset = "0x2DBF848", VA = "0x2DBF848")]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x6000BCC")]
			[Address(RVA = "0x2DBE7FC", Offset = "0x2DBE7FC", VA = "0x2DBE7FC")]
			public void SetFootPosition(Vector3 position)
			{
			}

			[Token(Token = "0x6000BCD")]
			[Address(RVA = "0x2DBD4E0", Offset = "0x2DBD4E0", VA = "0x2DBD4E0")]
			public void Initiate(Grounding grounding, Transform transform)
			{
			}

			[Token(Token = "0x6000BCE")]
			[Address(RVA = "0x2DBE810", Offset = "0x2DBE810", VA = "0x2DBE810")]
			public void OnEnable()
			{
			}

			[Token(Token = "0x6000BCF")]
			[Address(RVA = "0x2DBE1DC", Offset = "0x2DBE1DC", VA = "0x2DBE1DC")]
			public void Reset()
			{
			}

			[Token(Token = "0x6000BD0")]
			[Address(RVA = "0x2DBD5EC", Offset = "0x2DBD5EC", VA = "0x2DBD5EC")]
			public void Process()
			{
			}

			[Token(Token = "0x6000BD2")]
			[Address(RVA = "0x2DBEFE8", Offset = "0x2DBEFE8", VA = "0x2DBEFE8")]
			private RaycastHit GetCapsuleHit(Vector3 offsetFromHeel)
			{
				return default(RaycastHit);
			}

			[Token(Token = "0x6000BD3")]
			[Address(RVA = "0x2DBE85C", Offset = "0x2DBE85C", VA = "0x2DBE85C")]
			private RaycastHit GetRaycastHit(Vector3 offsetFromHeel)
			{
				return default(RaycastHit);
			}

			[Token(Token = "0x6000BD4")]
			[Address(RVA = "0x2DBF6F0", Offset = "0x2DBF6F0", VA = "0x2DBF6F0")]
			private Vector3 RotateNormal(Vector3 normal)
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000BD5")]
			[Address(RVA = "0x2DBEC94", Offset = "0x2DBEC94", VA = "0x2DBEC94")]
			private void SetFootToPoint(Vector3 normal, Vector3 point)
			{
			}

			[Token(Token = "0x6000BD6")]
			[Address(RVA = "0x2DBED9C", Offset = "0x2DBED9C", VA = "0x2DBED9C")]
			private void SetFootToPlane(Vector3 planeNormal, Vector3 planePoint, Vector3 heelHitPoint)
			{
			}

			[Token(Token = "0x6000BD7")]
			[Address(RVA = "0x2DBF7EC", Offset = "0x2DBF7EC", VA = "0x2DBF7EC")]
			private float GetHeightFromGround(Vector3 hitPoint)
			{
				return default(float);
			}

			[Token(Token = "0x6000BD8")]
			[Address(RVA = "0x2DBF5FC", Offset = "0x2DBF5FC", VA = "0x2DBF5FC")]
			private void RotateFoot()
			{
			}

			[Token(Token = "0x6000BD9")]
			[Address(RVA = "0x2DBF970", Offset = "0x2DBF970", VA = "0x2DBF970")]
			private Quaternion GetRotationOffsetTarget()
			{
				return default(Quaternion);
			}

			[Token(Token = "0x6000BDB")]
			[Address(RVA = "0x2DBD430", Offset = "0x2DBD430", VA = "0x2DBD430")]
			public Leg()
			{
			}
		}

		[Token(Token = "0x2000194")]
		public class Pelvis
		{
			[Token(Token = "0x40009B7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1446680", Offset = "0x1446680")]
			private Vector3 <IKOffset>k__BackingField;

			[Token(Token = "0x40009B8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1446690", Offset = "0x1446690")]
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
				[Address(RVA = "0x2DBFA60", Offset = "0x2DBFA60", VA = "0x2DBFA60")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x144BAF8", Offset = "0x144BAF8")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000BDD")]
				[Address(RVA = "0x2DBFA6C", Offset = "0x2DBFA6C", VA = "0x2DBFA6C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x144BB08", Offset = "0x144BB08")]
				private set
				{
				}
			}

			[Token(Token = "0x17000088")]
			public float heightOffset
			{
				[Token(Token = "0x6000BDE")]
				[Address(RVA = "0x2DBFA78", Offset = "0x2DBFA78", VA = "0x2DBFA78")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x144BB18", Offset = "0x144BB18")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000BDF")]
				[Address(RVA = "0x2DBFA80", Offset = "0x2DBFA80", VA = "0x2DBFA80")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x144BB28", Offset = "0x144BB28")]
				private set
				{
				}
			}

			[Token(Token = "0x6000BE0")]
			[Address(RVA = "0x2DBD5C4", Offset = "0x2DBD5C4", VA = "0x2DBD5C4")]
			public void Initiate(Grounding grounding)
			{
			}

			[Token(Token = "0x6000BE1")]
			[Address(RVA = "0x2DBE12C", Offset = "0x2DBE12C", VA = "0x2DBE12C")]
			public void Reset()
			{
			}

			[Token(Token = "0x6000BE2")]
			[Address(RVA = "0x2DBFA88", Offset = "0x2DBFA88", VA = "0x2DBFA88")]
			public void OnEnable()
			{
			}

			[Token(Token = "0x6000BE3")]
			[Address(RVA = "0x2DBDEC0", Offset = "0x2DBDEC0", VA = "0x2DBDEC0")]
			public void Process(float lowestOffset, float highestOffset, bool isGrounded)
			{
			}

			[Token(Token = "0x6000BE4")]
			[Address(RVA = "0x2DBD4D8", Offset = "0x2DBD4D8", VA = "0x2DBD4D8")]
			public Pelvis()
			{
			}
		}

		[Token(Token = "0x4000157")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14431E4", Offset = "0x14431E4")]
		public LayerMask layers;

		[Token(Token = "0x4000158")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x144321C", Offset = "0x144321C")]
		public float maxStep;

		[Token(Token = "0x4000159")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1443254", Offset = "0x1443254")]
		public float heightOffset;

		[Token(Token = "0x400015A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x144328C", Offset = "0x144328C")]
		public float footSpeed;

		[Token(Token = "0x400015B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14432C4", Offset = "0x14432C4")]
		public float footRadius;

		[Token(Token = "0x400015C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14432FC", Offset = "0x14432FC")]
		[HideInInspector]
		public float footCenterOffset;

		[Token(Token = "0x400015D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1443348", Offset = "0x1443348")]
		public float prediction;

		[Token(Token = "0x400015E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1443380", Offset = "0x1443380")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1443380", Offset = "0x1443380")]
		public float footRotationWeight;

		[Token(Token = "0x400015F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14433D4", Offset = "0x14433D4")]
		public float footRotationSpeed;

		[Token(Token = "0x4000160")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x144340C", Offset = "0x144340C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x144340C", Offset = "0x144340C")]
		public float maxFootRotationAngle;

		[Token(Token = "0x4000161")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1443464", Offset = "0x1443464")]
		public bool rotateSolver;

		[Token(Token = "0x4000162")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x144349C", Offset = "0x144349C")]
		public float pelvisSpeed;

		[Token(Token = "0x4000163")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14434D4", Offset = "0x14434D4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x14434D4", Offset = "0x14434D4")]
		public float pelvisDamper;

		[Token(Token = "0x4000164")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1443528", Offset = "0x1443528")]
		public float lowerPelvisWeight;

		[Token(Token = "0x4000165")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1443560", Offset = "0x1443560")]
		public float liftPelvisWeight;

		[Token(Token = "0x4000166")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1443598", Offset = "0x1443598")]
		public float rootSphereCastRadius;

		[Token(Token = "0x4000167")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14435D0", Offset = "0x14435D0")]
		public bool overstepFallsDown;

		[Token(Token = "0x4000168")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1443608", Offset = "0x1443608")]
		public Quality quality;

		[Token(Token = "0x4000169")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1443640", Offset = "0x1443640")]
		private Leg[] <legs>k__BackingField;

		[Token(Token = "0x400016A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1443650", Offset = "0x1443650")]
		private Pelvis <pelvis>k__BackingField;

		[Token(Token = "0x400016B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1443660", Offset = "0x1443660")]
		private bool <isGrounded>k__BackingField;

		[Token(Token = "0x400016C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1443670", Offset = "0x1443670")]
		private Transform <root>k__BackingField;

		[Token(Token = "0x400016D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1443680", Offset = "0x1443680")]
		private RaycastHit <rootHit>k__BackingField;

		[Token(Token = "0x400016E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		private bool initiated;

		[Token(Token = "0x1700001C")]
		public Leg[] legs
		{
			[Token(Token = "0x60001B8")]
			[Address(RVA = "0x2DBCEA4", Offset = "0x2DBCEA4", VA = "0x2DBCEA4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1449FD0", Offset = "0x1449FD0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001B9")]
			[Address(RVA = "0x2DBCEAC", Offset = "0x2DBCEAC", VA = "0x2DBCEAC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1449FE0", Offset = "0x1449FE0")]
			private set
			{
			}
		}

		[Token(Token = "0x1700001D")]
		public Pelvis pelvis
		{
			[Token(Token = "0x60001BA")]
			[Address(RVA = "0x2DBCEB4", Offset = "0x2DBCEB4", VA = "0x2DBCEB4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1449FF0", Offset = "0x1449FF0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001BB")]
			[Address(RVA = "0x2DBCEBC", Offset = "0x2DBCEBC", VA = "0x2DBCEBC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x144A000", Offset = "0x144A000")]
			private set
			{
			}
		}

		[Token(Token = "0x1700001E")]
		public bool isGrounded
		{
			[Token(Token = "0x60001BC")]
			[Address(RVA = "0x2DBCEC4", Offset = "0x2DBCEC4", VA = "0x2DBCEC4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x144A010", Offset = "0x144A010")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60001BD")]
			[Address(RVA = "0x2DBCECC", Offset = "0x2DBCECC", VA = "0x2DBCECC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x144A020", Offset = "0x144A020")]
			private set
			{
			}
		}

		[Token(Token = "0x1700001F")]
		public Transform root
		{
			[Token(Token = "0x60001BE")]
			[Address(RVA = "0x2DBCED8", Offset = "0x2DBCED8", VA = "0x2DBCED8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x144A030", Offset = "0x144A030")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001BF")]
			[Address(RVA = "0x2DBCEE0", Offset = "0x2DBCEE0", VA = "0x2DBCEE0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x144A040", Offset = "0x144A040")]
			private set
			{
			}
		}

		[Token(Token = "0x17000020")]
		public RaycastHit rootHit
		{
			[Token(Token = "0x60001C0")]
			[Address(RVA = "0x2DBCEE8", Offset = "0x2DBCEE8", VA = "0x2DBCEE8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x144A050", Offset = "0x144A050")]
			get
			{
				return default(RaycastHit);
			}
			[Token(Token = "0x60001C1")]
			[Address(RVA = "0x2DBCF00", Offset = "0x2DBCF00", VA = "0x2DBCF00")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x144A060", Offset = "0x144A060")]
			private set
			{
			}
		}

		[Token(Token = "0x17000021")]
		public bool rootGrounded
		{
			[Token(Token = "0x60001C2")]
			[Address(RVA = "0x2DBCF20", Offset = "0x2DBCF20", VA = "0x2DBCF20")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000022")]
		public Vector3 up
		{
			[Token(Token = "0x60001CA")]
			[Address(RVA = "0x2DB7418", Offset = "0x2DB7418", VA = "0x2DB7418")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000023")]
		private bool useRootRotation
		{
			[Token(Token = "0x60001CD")]
			[Address(RVA = "0x2DBE290", Offset = "0x2DBE290", VA = "0x2DBE290")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60001C3")]
		[Address(RVA = "0x2DBCF74", Offset = "0x2DBCF74", VA = "0x2DBCF74")]
		public RaycastHit GetRootHit(float maxDistanceMlp = 10f)
		{
			return default(RaycastHit);
		}

		[Token(Token = "0x60001C4")]
		[Address(RVA = "0x2DBD354", Offset = "0x2DBD354", VA = "0x2DBD354")]
		public bool IsValid(ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x60001C5")]
		[Address(RVA = "0x2DB68DC", Offset = "0x2DB68DC", VA = "0x2DB68DC")]
		public void Initiate(Transform root, Transform[] feet)
		{
		}

		[Token(Token = "0x60001C6")]
		[Address(RVA = "0x2DB70DC", Offset = "0x2DB70DC", VA = "0x2DB70DC")]
		public void Update()
		{
		}

		[Token(Token = "0x60001C7")]
		[Address(RVA = "0x2DB8F34", Offset = "0x2DB8F34", VA = "0x2DB8F34")]
		public Vector3 GetLegsPlaneNormal()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60001C8")]
		[Address(RVA = "0x2DB6440", Offset = "0x2DB6440", VA = "0x2DB6440")]
		public void Reset()
		{
		}

		[Token(Token = "0x60001C9")]
		[Address(RVA = "0x2DBD5D4", Offset = "0x2DBD5D4", VA = "0x2DBD5D4")]
		public void LogWarning(string message)
		{
		}

		[Token(Token = "0x60001CB")]
		[Address(RVA = "0x2DBE360", Offset = "0x2DBE360", VA = "0x2DBE360")]
		public float GetVerticalOffset(Vector3 p1, Vector3 p2)
		{
			return default(float);
		}

		[Token(Token = "0x60001CC")]
		[Address(RVA = "0x2DBE4C8", Offset = "0x2DBE4C8", VA = "0x2DBE4C8")]
		public Vector3 Flatten(Vector3 v)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60001CE")]
		[Address(RVA = "0x2DBE5CC", Offset = "0x2DBE5CC", VA = "0x2DBE5CC")]
		public Vector3 GetFootCenterOffset()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60001CF")]
		[Address(RVA = "0x2DB6080", Offset = "0x2DB6080", VA = "0x2DB6080")]
		public Grounding()
		{
		}
	}
	[Token(Token = "0x2000037")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x1441618", Offset = "0x1441618")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x1441618", Offset = "0x1441618")]
	public class AimIK : IK
	{
		[Token(Token = "0x400016F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverAim solver;

		[Token(Token = "0x60001D0")]
		[Address(RVA = "0x2A73AF0", Offset = "0x2A73AF0", VA = "0x2A73AF0", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x144A070", Offset = "0x144A070")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60001D1")]
		[Address(RVA = "0x2A73B3C", Offset = "0x2A73B3C", VA = "0x2A73B3C", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x144A0A8", Offset = "0x144A0A8")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60001D2")]
		[Address(RVA = "0x2A73B88", Offset = "0x2A73B88", VA = "0x2A73B88")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x144A0E0", Offset = "0x144A0E0")]
		private void OpenSetupTutorial()
		{
		}

		[Token(Token = "0x60001D3")]
		[Address(RVA = "0x2A73BD4", Offset = "0x2A73BD4", VA = "0x2A73BD4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x144A118", Offset = "0x144A118")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60001D4")]
		[Address(RVA = "0x2A73C20", Offset = "0x2A73C20", VA = "0x2A73C20")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x144A150", Offset = "0x144A150")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60001D5")]
		[Address(RVA = "0x2A73C6C", Offset = "0x2A73C6C", VA = "0x2A73C6C", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x60001D6")]
		[Address(RVA = "0x2A73C74", Offset = "0x2A73C74", VA = "0x2A73C74")]
		public AimIK()
		{
		}
	}
	[Token(Token = "0x2000038")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x1441678", Offset = "0x1441678")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x1441678", Offset = "0x1441678")]
	public class ArmIK : IK
	{
		[Token(Token = "0x4000170")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverArm solver;

		[Token(Token = "0x60001D7")]
		[Address(RVA = "0x2A78318", Offset = "0x2A78318", VA = "0x2A78318", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x144A188", Offset = "0x144A188")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60001D8")]
		[Address(RVA = "0x2A78364", Offset = "0x2A78364", VA = "0x2A78364", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x144A1C0", Offset = "0x144A1C0")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60001D9")]
		[Address(RVA = "0x2A783B0", Offset = "0x2A783B0", VA = "0x2A783B0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x144A1F8", Offset = "0x144A1F8")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60001DA")]
		[Address(RVA = "0x2A783FC", Offset = "0x2A783FC", VA = "0x2A783FC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x144A230", Offset = "0x144A230")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60001DB")]
		[Address(RVA = "0x2A78448", Offset = "0x2A78448", VA = "0x2A78448", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x60001DC")]
		[Address(RVA = "0x2A78450", Offset = "0x2A78450", VA = "0x2A78450")]
		public ArmIK()
		{
		}
	}
	[Token(Token = "0x2000039")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x14416D8", Offset = "0x14416D8")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x14416D8", Offset = "0x14416D8")]
	public class CCDIK : IK
	{
		[Token(Token = "0x4000171")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverCCD solver;

		[Token(Token = "0x60001DD")]
		[Address(RVA = "0x2A79AA8", Offset = "0x2A79AA8", VA = "0x2A79AA8", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x144A268", Offset = "0x144A268")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60001DE")]
		[Address(RVA = "0x2A79AF4", Offset = "0x2A79AF4", VA = "0x2A79AF4", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x144A2A0", Offset = "0x144A2A0")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60001DF")]
		[Address(RVA = "0x2A79B40", Offset = "0x2A79B40", VA = "0x2A79B40")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x144A2D8", Offset = "0x144A2D8")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60001E0")]
		[Address(RVA = "0x2A79B8C", Offset = "0x2A79B8C", VA = "0x2A79B8C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x144A310", Offset = "0x144A310")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60001E1")]
		[Address(RVA = "0x2A79BD8", Offset = "0x2A79BD8", VA = "0x2A79BD8", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x60001E2")]
		[Address(RVA = "0x2A79BE0", Offset = "0x2A79BE0", VA = "0x2A79BE0")]
		public CCDIK()
		{
		}
	}
	[Token(Token = "0x200003A")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x1441738", Offset = "0x1441738")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x1441738", Offset = "0x1441738")]
	public class FABRIK : IK
	{
		[Token(Token = "0x4000172")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverFABRIK solver;

		[Token(Token = "0x60001E3")]
		[Address(RVA = "0x2A7D2AC", Offset = "0x2A7D2AC", VA = "0x2A7D2AC", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x144A348", Offset = "0x144A348")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60001E4")]
		[Address(RVA = "0x2A7D2F8", Offset = "0x2A7D2F8", VA = "0x2A7D2F8", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x144A380", Offset = "0x144A380")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60001E5")]
		[Address(RVA = "0x2A7D344", Offset = "0x2A7D344", VA = "0x2A7D344")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x144A3B8", Offset = "0x144A3B8")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60001E6")]
		[Address(RVA = "0x2A7D390", Offset = "0x2A7D390", VA = "0x2A7D390")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x144A3F0", Offset = "0x144A3F0")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60001E7")]
		[Address(RVA = "0x2A7D3DC", Offset = "0x2A7D3DC", VA = "0x2A7D3DC", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x60001E8")]
		[Address(RVA = "0x2A7D3E4", Offset = "0x2A7D3E4", VA = "0x2A7D3E4")]
		public FABRIK()
		{
		}
	}
	[Token(Token = "0x200003B")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x1441798", Offset = "0x1441798")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x1441798", Offset = "0x1441798")]
	public class FABRIKRoot : IK
	{
		[Token(Token = "0x4000173")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverFABRIKRoot solver;

		[Token(Token = "0x60001E9")]
		[Address(RVA = "0x2A7DA64", Offset = "0x2A7DA64", VA = "0x2A7DA64", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x144A428", Offset = "0x144A428")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60001EA")]
		[Address(RVA = "0x2A7DAB0", Offset = "0x2A7DAB0", VA = "0x2A7DAB0", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x144A460", Offset = "0x144A460")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60001EB")]
		[Address(RVA = "0x2A7DAFC", Offset = "0x2A7DAFC", VA = "0x2A7DAFC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x144A498", Offset = "0x144A498")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60001EC")]
		[Address(RVA = "0x2A7DB48", Offset = "0x2A7DB48", VA = "0x2A7DB48")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x144A4D0", Offset = "0x144A4D0")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60001ED")]
		[Address(RVA = "0x2A7DB94", Offset = "0x2A7DB94", VA = "0x2A7DB94", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x60001EE")]
		[Address(RVA = "0x2A7DB9C", Offset = "0x2A7DB9C", VA = "0x2A7DB9C")]
		public FABRIKRoot()
		{
		}
	}
	[Token(Token = "0x200003C")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x14417F8", Offset = "0x14417F8")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x14417F8", Offset = "0x14417F8")]
	public class FullBodyBipedIK : IK
	{
		[Token(Token = "0x4000174")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public BipedReferences references;

		[Token(Token = "0x4000175")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public IKSolverFullBodyBiped solver;

		[Token(Token = "0x60001EF")]
		[Address(RVA = "0x2DB4AC8", Offset = "0x2DB4AC8", VA = "0x2DB4AC8", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x144A508", Offset = "0x144A508")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60001F0")]
		[Address(RVA = "0x2DB4B14", Offset = "0x2DB4B14", VA = "0x2DB4B14", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x144A540", Offset = "0x144A540")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60001F1")]
		[Address(RVA = "0x2DB4B60", Offset = "0x2DB4B60", VA = "0x2DB4B60")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x144A578", Offset = "0x144A578")]
		private void OpenSetupTutorial()
		{
		}

		[Token(Token = "0x60001F2")]
		[Address(RVA = "0x2DB4BAC", Offset = "0x2DB4BAC", VA = "0x2DB4BAC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x144A5B0", Offset = "0x144A5B0")]
		private void OpenInspectorTutorial()
		{
		}

		[Token(Token = "0x60001F3")]
		[Address(RVA = "0x2DB4BF8", Offset = "0x2DB4BF8", VA = "0x2DB4BF8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x144A5E8", Offset = "0x144A5E8")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60001F4")]
		[Address(RVA = "0x2DB4C44", Offset = "0x2DB4C44", VA = "0x2DB4C44")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x144A620", Offset = "0x144A620")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60001F5")]
		[Address(RVA = "0x2DB4C90", Offset = "0x2DB4C90", VA = "0x2DB4C90")]
		public void SetReferences(BipedReferences references, Transform rootNode)
		{
		}

		[Token(Token = "0x60001F6")]
		[Address(RVA = "0x2DB4CB4", Offset = "0x2DB4CB4", VA = "0x2DB4CB4", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x60001F7")]
		[Address(RVA = "0x2DB4CBC", Offset = "0x2DB4CBC", VA = "0x2DB4CBC")]
		public bool ReferencesError(ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x60001F8")]
		[Address(RVA = "0x2DB4E78", Offset = "0x2DB4E78", VA = "0x2DB4E78")]
		public bool ReferencesWarning(ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x60001F9")]
		[Address(RVA = "0x2DB51CC", Offset = "0x2DB51CC", VA = "0x2DB51CC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x144A658", Offset = "0x144A658")]
		private void Reinitiate()
		{
		}

		[Token(Token = "0x60001FA")]
		[Address(RVA = "0x2DB51EC", Offset = "0x2DB51EC", VA = "0x2DB51EC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x144A690", Offset = "0x144A690")]
		private void AutoDetectReferences()
		{
		}

		[Token(Token = "0x60001FB")]
		[Address(RVA = "0x2DB52C8", Offset = "0x2DB52C8", VA = "0x2DB52C8")]
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
		[Address(RVA = "0x2DC2570", Offset = "0x2DC2570", VA = "0x2DC2570", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x60001FE")]
		[Address(RVA = "0x2DC2664", Offset = "0x2DC2664", VA = "0x2DC2664", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x60001FF")]
		[Address(RVA = "0x2DC2828", Offset = "0x2DC2828", VA = "0x2DC2828", Slot = "6")]
		protected override void FixTransforms()
		{
		}

		[Token(Token = "0x6000200")]
		protected abstract void OpenUserManual();

		[Token(Token = "0x6000201")]
		protected abstract void OpenScriptReference();

		[Token(Token = "0x6000202")]
		[Address(RVA = "0x2DB5350", Offset = "0x2DB5350", VA = "0x2DB5350")]
		protected IK()
		{
		}
	}
	[Token(Token = "0x200003E")]
	public class IKExecutionOrder : MonoBehaviour
	{
		[Token(Token = "0x4000176")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1443690", Offset = "0x1443690")]
		public IK[] IKComponents;

		[Token(Token = "0x4000177")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14436C8", Offset = "0x14436C8")]
		public Animator animator;

		[Token(Token = "0x4000178")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool fixedFrame;

		[Token(Token = "0x17000024")]
		private bool animatePhysics
		{
			[Token(Token = "0x6000203")]
			[Address(RVA = "0x2DC57C8", Offset = "0x2DC57C8", VA = "0x2DC57C8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000204")]
		[Address(RVA = "0x2DC5864", Offset = "0x2DC5864", VA = "0x2DC5864")]
		private void Start()
		{
		}

		[Token(Token = "0x6000205")]
		[Address(RVA = "0x2DC58D4", Offset = "0x2DC58D4", VA = "0x2DC58D4")]
		private void Update()
		{
		}

		[Token(Token = "0x6000206")]
		[Address(RVA = "0x2DC5990", Offset = "0x2DC5990", VA = "0x2DC5990")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000207")]
		[Address(RVA = "0x2DC59CC", Offset = "0x2DC59CC", VA = "0x2DC59CC")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000208")]
		[Address(RVA = "0x2DC5908", Offset = "0x2DC5908", VA = "0x2DC5908")]
		private void FixTransforms()
		{
		}

		[Token(Token = "0x6000209")]
		[Address(RVA = "0x2DC5A58", Offset = "0x2DC5A58", VA = "0x2DC5A58")]
		public IKExecutionOrder()
		{
		}
	}
	[Token(Token = "0x200003F")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x1441858", Offset = "0x1441858")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x1441858", Offset = "0x1441858")]
	public class LegIK : IK
	{
		[Token(Token = "0x4000179")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverLeg solver;

		[Token(Token = "0x600020A")]
		[Address(RVA = "0x2939FC0", Offset = "0x2939FC0", VA = "0x2939FC0", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x144A6C8", Offset = "0x144A6C8")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x600020B")]
		[Address(RVA = "0x293A00C", Offset = "0x293A00C", VA = "0x293A00C", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x144A700", Offset = "0x144A700")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x600020C")]
		[Address(RVA = "0x293A058", Offset = "0x293A058", VA = "0x293A058")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x144A738", Offset = "0x144A738")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600020D")]
		[Address(RVA = "0x293A0A4", Offset = "0x293A0A4", VA = "0x293A0A4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x144A770", Offset = "0x144A770")]
		private void ASThread()
		{
		}

		[Token(Token = "0x600020E")]
		[Address(RVA = "0x293A0F0", Offset = "0x293A0F0", VA = "0x293A0F0", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x600020F")]
		[Address(RVA = "0x293A0F8", Offset = "0x293A0F8", VA = "0x293A0F8")]
		public LegIK()
		{
		}
	}
	[Token(Token = "0x2000040")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x14418B8", Offset = "0x14418B8")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x14418B8", Offset = "0x14418B8")]
	public class LimbIK : IK
	{
		[Token(Token = "0x400017A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverLimb solver;

		[Token(Token = "0x6000210")]
		[Address(RVA = "0x293A160", Offset = "0x293A160", VA = "0x293A160", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x144A7A8", Offset = "0x144A7A8")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000211")]
		[Address(RVA = "0x293A1AC", Offset = "0x293A1AC", VA = "0x293A1AC", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x144A7E0", Offset = "0x144A7E0")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000212")]
		[Address(RVA = "0x293A1F8", Offset = "0x293A1F8", VA = "0x293A1F8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x144A818", Offset = "0x144A818")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000213")]
		[Address(RVA = "0x293A244", Offset = "0x293A244", VA = "0x293A244")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x144A850", Offset = "0x144A850")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000214")]
		[Address(RVA = "0x293A290", Offset = "0x293A290", VA = "0x293A290", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000215")]
		[Address(RVA = "0x293A298", Offset = "0x293A298", VA = "0x293A298")]
		public LimbIK()
		{
		}
	}
	[Token(Token = "0x2000041")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x1441918", Offset = "0x1441918")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x1441918", Offset = "0x1441918")]
	public class LookAtIK : IK
	{
		[Token(Token = "0x400017B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverLookAt solver;

		[Token(Token = "0x6000216")]
		[Address(RVA = "0x293B154", Offset = "0x293B154", VA = "0x293B154", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x144A888", Offset = "0x144A888")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000217")]
		[Address(RVA = "0x293B1A0", Offset = "0x293B1A0", VA = "0x293B1A0", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x144A8C0", Offset = "0x144A8C0")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000218")]
		[Address(RVA = "0x293B1EC", Offset = "0x293B1EC", VA = "0x293B1EC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x144A8F8", Offset = "0x144A8F8")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000219")]
		[Address(RVA = "0x293B238", Offset = "0x293B238", VA = "0x293B238")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x144A930", Offset = "0x144A930")]
		private void ASThread()
		{
		}

		[Token(Token = "0x600021A")]
		[Address(RVA = "0x293B284", Offset = "0x293B284", VA = "0x293B284", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x600021B")]
		[Address(RVA = "0x293B28C", Offset = "0x293B28C", VA = "0x293B28C")]
		public LookAtIK()
		{
		}
	}
	[Token(Token = "0x2000042")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x1441978", Offset = "0x1441978")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x1441978", Offset = "0x1441978")]
	public class TrigonometricIK : IK
	{
		[Token(Token = "0x400017C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverTrigonometric solver;

		[Token(Token = "0x600021C")]
		[Address(RVA = "0x2944528", Offset = "0x2944528", VA = "0x2944528", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x144A968", Offset = "0x144A968")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x600021D")]
		[Address(RVA = "0x2944574", Offset = "0x2944574", VA = "0x2944574", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x144A9A0", Offset = "0x144A9A0")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x600021E")]
		[Address(RVA = "0x29445C0", Offset = "0x29445C0", VA = "0x29445C0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x144A9D8", Offset = "0x144A9D8")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600021F")]
		[Address(RVA = "0x294460C", Offset = "0x294460C", VA = "0x294460C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x144AA10", Offset = "0x144AA10")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000220")]
		[Address(RVA = "0x2944658", Offset = "0x2944658", VA = "0x2944658", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000221")]
		[Address(RVA = "0x2944660", Offset = "0x2944660", VA = "0x2944660")]
		public TrigonometricIK()
		{
		}
	}
	[Token(Token = "0x2000043")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x14419D8", Offset = "0x14419D8")]
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
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14466A0", Offset = "0x14466A0")]
			public Transform chest;

			[Token(Token = "0x40009C2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14466D8", Offset = "0x14466D8")]
			public Transform neck;

			[Token(Token = "0x40009C3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Transform head;

			[Token(Token = "0x40009C4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1446710", Offset = "0x1446710")]
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
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1446748", Offset = "0x1446748")]
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
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1446780", Offset = "0x1446780")]
			public Transform leftThigh;

			[Token(Token = "0x40009CD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14467B8", Offset = "0x14467B8")]
			public Transform leftCalf;

			[Token(Token = "0x40009CE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14467F0", Offset = "0x14467F0")]
			public Transform leftFoot;

			[Token(Token = "0x40009CF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1446828", Offset = "0x1446828")]
			public Transform leftToes;

			[Token(Token = "0x40009D0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1446860", Offset = "0x1446860")]
			public Transform rightThigh;

			[Token(Token = "0x40009D1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1446898", Offset = "0x1446898")]
			public Transform rightCalf;

			[Token(Token = "0x40009D2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14468D0", Offset = "0x14468D0")]
			public Transform rightFoot;

			[Token(Token = "0x40009D3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1446908", Offset = "0x1446908")]
			public Transform rightToes;

			[Token(Token = "0x17000089")]
			public bool isFilled
			{
				[Token(Token = "0x6000BE6")]
				[Address(RVA = "0x2945B60", Offset = "0x2945B60", VA = "0x2945B60")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x1700008A")]
			public bool isEmpty
			{
				[Token(Token = "0x6000BE7")]
				[Address(RVA = "0x29456E4", Offset = "0x29456E4", VA = "0x29456E4")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x6000BE5")]
			[Address(RVA = "0x29461E4", Offset = "0x29461E4", VA = "0x29461E4")]
			public Transform[] GetTransforms()
			{
				return null;
			}

			[Token(Token = "0x6000BE8")]
			[Address(RVA = "0x29452D0", Offset = "0x29452D0", VA = "0x29452D0")]
			public static bool AutoDetectReferences(Transform root, out References references)
			{
				return default(bool);
			}

			[Token(Token = "0x6000BE9")]
			[Address(RVA = "0x29461DC", Offset = "0x29461DC", VA = "0x29461DC")]
			public References()
			{
			}
		}

		[Token(Token = "0x400017D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "ContextMenuItemAttribute", RVA = "0x1443700", Offset = "0x1443700")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1443700", Offset = "0x1443700")]
		public References references;

		[Token(Token = "0x400017E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x144377C", Offset = "0x144377C")]
		public IKSolverVR solver;

		[Token(Token = "0x6000222")]
		[Address(RVA = "0x29451C4", Offset = "0x29451C4", VA = "0x29451C4", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x144AA48", Offset = "0x144AA48")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000223")]
		[Address(RVA = "0x2945210", Offset = "0x2945210", VA = "0x2945210", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x144AA80", Offset = "0x144AA80")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000224")]
		[Address(RVA = "0x294525C", Offset = "0x294525C", VA = "0x294525C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x144AAB8", Offset = "0x144AAB8")]
		private void OpenSetupTutorial()
		{
		}

		[Token(Token = "0x6000225")]
		[Address(RVA = "0x29452A8", Offset = "0x29452A8", VA = "0x29452A8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x144AAF0", Offset = "0x144AAF0")]
		public void AutoDetectReferences()
		{
		}

		[Token(Token = "0x6000226")]
		[Address(RVA = "0x2945640", Offset = "0x2945640", VA = "0x2945640")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x144AB28", Offset = "0x144AB28")]
		public void GuessHandOrientations()
		{
		}

		[Token(Token = "0x6000227")]
		[Address(RVA = "0x2945668", Offset = "0x2945668", VA = "0x2945668", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000228")]
		[Address(RVA = "0x2945670", Offset = "0x2945670", VA = "0x2945670", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x6000229")]
		[Address(RVA = "0x2945FDC", Offset = "0x2945FDC", VA = "0x2945FDC", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x600022A")]
		[Address(RVA = "0x2946154", Offset = "0x2946154", VA = "0x2946154")]
		public VRIK()
		{
		}
	}
	[Token(Token = "0x2000044")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x1441A10", Offset = "0x1441A10")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x1441A10", Offset = "0x1441A10")]
	public class AimIKJ : MonoBehaviour
	{
		[Token(Token = "0x400017F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14437B4", Offset = "0x14437B4")]
		public Transform target;

		[Token(Token = "0x4000180")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14437EC", Offset = "0x14437EC")]
		public Transform poleTarget;

		[Token(Token = "0x4000181")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1443824", Offset = "0x1443824")]
		public Transform aimTransform;

		[Token(Token = "0x4000182")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x144385C", Offset = "0x144385C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x144385C", Offset = "0x144385C")]
		public float axisX;

		[Token(Token = "0x4000183")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14438AC", Offset = "0x14438AC")]
		public float axisY;

		[Token(Token = "0x4000184")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14438E4", Offset = "0x14438E4")]
		public float axisZ;

		[Token(Token = "0x4000185")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x144391C", Offset = "0x144391C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x144391C", Offset = "0x144391C")]
		public float poleAxisX;

		[Token(Token = "0x4000186")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x144396C", Offset = "0x144396C")]
		public float poleAxisY;

		[Token(Token = "0x4000187")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14439A4", Offset = "0x14439A4")]
		public float poleAxisZ;

		[Token(Token = "0x4000188")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x14439DC", Offset = "0x14439DC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14439DC", Offset = "0x14439DC")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x14439DC", Offset = "0x14439DC")]
		public float weight;

		[Token(Token = "0x4000189")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1443A44", Offset = "0x1443A44")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1443A44", Offset = "0x1443A44")]
		public float poleWeight;

		[Token(Token = "0x400018A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1443A98", Offset = "0x1443A98")]
		public float tolerance;

		[Token(Token = "0x400018B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1443AD0", Offset = "0x1443AD0")]
		public int maxIterations;

		[Token(Token = "0x400018C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1443B08", Offset = "0x1443B08")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1443B08", Offset = "0x1443B08")]
		public float clampWeight;

		[Token(Token = "0x400018D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1443B5C", Offset = "0x1443B5C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1443B5C", Offset = "0x1443B5C")]
		public int clampSmoothing;

		[Token(Token = "0x400018E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1443BB0", Offset = "0x1443BB0")]
		public bool useRotationLimits;

		[Token(Token = "0x400018F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x61")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1443BE8", Offset = "0x1443BE8")]
		public bool XY;

		[Token(Token = "0x4000190")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x1443C20", Offset = "0x1443C20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1443C20", Offset = "0x1443C20")]
		public Transform[] bones;

		[Token(Token = "0x4000191")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1443C70", Offset = "0x1443C70")]
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
			[Address(RVA = "0x2A73CDC", Offset = "0x2A73CDC", VA = "0x2A73CDC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x144AB60", Offset = "0x144AB60")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600022C")]
			[Address(RVA = "0x2A73CE4", Offset = "0x2A73CE4", VA = "0x2A73CE4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x144AB70", Offset = "0x144AB70")]
			private set
			{
			}
		}

		[Token(Token = "0x17000026")]
		public Vector3 axis
		{
			[Token(Token = "0x600022D")]
			[Address(RVA = "0x2A73CF0", Offset = "0x2A73CF0", VA = "0x2A73CF0")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x600022E")]
			[Address(RVA = "0x2A73D2C", Offset = "0x2A73D2C", VA = "0x2A73D2C")]
			set
			{
			}
		}

		[Token(Token = "0x17000027")]
		public Vector3 poleAxis
		{
			[Token(Token = "0x600022F")]
			[Address(RVA = "0x2A73D38", Offset = "0x2A73D38", VA = "0x2A73D38")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000230")]
			[Address(RVA = "0x2A73D74", Offset = "0x2A73D74", VA = "0x2A73D74")]
			set
			{
			}
		}

		[Token(Token = "0x6000231")]
		[Address(RVA = "0x2A73D80", Offset = "0x2A73D80", VA = "0x2A73D80")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000232")]
		[Address(RVA = "0x2A74B88", Offset = "0x2A74B88", VA = "0x2A74B88")]
		private void Update()
		{
		}

		[Token(Token = "0x6000233")]
		[Address(RVA = "0x2A74F70", Offset = "0x2A74F70", VA = "0x2A74F70")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000234")]
		[Address(RVA = "0x2A75070", Offset = "0x2A75070", VA = "0x2A75070")]
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
		[Address(RVA = "0x1577994", Offset = "0x1577994", VA = "0x1577994")]
		public void Setup(Animator animator, Transform[] bones, Transform target, Transform poleTarget, Transform aimTransform)
		{
		}

		[Token(Token = "0x6000236")]
		[Address(RVA = "0x157799C", Offset = "0x157799C", VA = "0x157799C")]
		private void SetUpRotationLimits(Animator animator, Transform[] bones)
		{
		}

		[Token(Token = "0x6000237")]
		[Address(RVA = "0x15779A4", Offset = "0x15779A4", VA = "0x15779A4")]
		private void DisposeRotationLimits()
		{
		}

		[Token(Token = "0x6000238")]
		[Address(RVA = "0x15779AC", Offset = "0x15779AC", VA = "0x15779AC", Slot = "5")]
		public void ProcessRootMotion(AnimationStream stream)
		{
		}

		[Token(Token = "0x6000239")]
		[Address(RVA = "0x15779B0", Offset = "0x15779B0", VA = "0x15779B0", Slot = "4")]
		public void ProcessAnimation(AnimationStream stream)
		{
		}

		[Token(Token = "0x600023A")]
		[Address(RVA = "0x15779EC", Offset = "0x15779EC", VA = "0x15779EC")]
		private void Update(AnimationStream s)
		{
		}

		[Token(Token = "0x600023B")]
		[Address(RVA = "0x1577A28", Offset = "0x1577A28", VA = "0x1577A28")]
		private void RotateToTarget(AnimationStream s, Vector3 targetPosition, Vector3 polePosition, int i, float weight, float poleWeight, bool XY, bool useRotationLimits, Vector3 axis, Vector3 poleAxis)
		{
		}

		[Token(Token = "0x600023C")]
		[Address(RVA = "0x1577A8C", Offset = "0x1577A8C", VA = "0x1577A8C")]
		public float GetAngle(AnimationStream s, Vector3 axis, Vector3 IKPosition)
		{
			return default(float);
		}

		[Token(Token = "0x600023D")]
		[Address(RVA = "0x1577AC8", Offset = "0x1577AC8", VA = "0x1577AC8")]
		private Vector3 GetClampedIKPosition(AnimationStream s, float clampWeight, int clampSmoothing, Vector3 IKPosition, Vector3 transformPosition, Vector3 transformAxis)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600023E")]
		[Address(RVA = "0x1577ADC", Offset = "0x1577ADC", VA = "0x1577ADC")]
		private Vector3 GetLocalDirection(AnimationStream s, Vector3 transformAxis)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600023F")]
		[Address(RVA = "0x1577B18", Offset = "0x1577B18", VA = "0x1577B18")]
		private float GetPositionOffset(AnimationStream s, Vector3 localDirection)
		{
			return default(float);
		}

		[Token(Token = "0x6000240")]
		[Address(RVA = "0x1577B20", Offset = "0x1577B20", VA = "0x1577B20")]
		public void Dispose()
		{
		}
	}
	[Token(Token = "0x2000046")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x1441A98", Offset = "0x1441A98")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x1441A98", Offset = "0x1441A98")]
	public class CCDIKJ : MonoBehaviour
	{
		[Token(Token = "0x40001B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1443C80", Offset = "0x1443C80")]
		public Transform target;

		[Token(Token = "0x40001B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1443CB8", Offset = "0x1443CB8")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1443CB8", Offset = "0x1443CB8")]
		public float weight;

		[Token(Token = "0x40001B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1443D0C", Offset = "0x1443D0C")]
		public float tolerance;

		[Token(Token = "0x40001BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1443D44", Offset = "0x1443D44")]
		public int maxIterations;

		[Token(Token = "0x40001BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1443D7C", Offset = "0x1443D7C")]
		public bool useRotationLimits;

		[Token(Token = "0x40001BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2D")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1443DB4", Offset = "0x1443DB4")]
		public bool XY;

		[Token(Token = "0x40001BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1443DEC", Offset = "0x1443DEC")]
		public Transform[] bones;

		[Token(Token = "0x40001BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1443E24", Offset = "0x1443E24")]
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
			[Address(RVA = "0x2A79C48", Offset = "0x2A79C48", VA = "0x2A79C48")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x144AB80", Offset = "0x144AB80")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000242")]
			[Address(RVA = "0x2A79C50", Offset = "0x2A79C50", VA = "0x2A79C50")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x144AB90", Offset = "0x144AB90")]
			private set
			{
			}
		}

		[Token(Token = "0x6000243")]
		[Address(RVA = "0x2A79C5C", Offset = "0x2A79C5C", VA = "0x2A79C5C")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000244")]
		[Address(RVA = "0x2A7A420", Offset = "0x2A7A420", VA = "0x2A7A420")]
		private void Update()
		{
		}

		[Token(Token = "0x6000245")]
		[Address(RVA = "0x2A7A5B8", Offset = "0x2A7A5B8", VA = "0x2A7A5B8")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000246")]
		[Address(RVA = "0x2A7A6CC", Offset = "0x2A7A6CC", VA = "0x2A7A6CC")]
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
		[Address(RVA = "0x1577B28", Offset = "0x1577B28", VA = "0x1577B28")]
		public void Setup(Animator animator, Transform[] bones, Transform target)
		{
		}

		[Token(Token = "0x6000248")]
		[Address(RVA = "0x1577B30", Offset = "0x1577B30", VA = "0x1577B30")]
		private void SetUpRotationLimits(Animator animator, Transform[] bones)
		{
		}

		[Token(Token = "0x6000249")]
		[Address(RVA = "0x1577B38", Offset = "0x1577B38", VA = "0x1577B38")]
		private void DisposeRotationLimits()
		{
		}

		[Token(Token = "0x600024A")]
		[Address(RVA = "0x1577B40", Offset = "0x1577B40", VA = "0x1577B40", Slot = "5")]
		public void ProcessRootMotion(AnimationStream stream)
		{
		}

		[Token(Token = "0x600024B")]
		[Address(RVA = "0x1577B44", Offset = "0x1577B44", VA = "0x1577B44", Slot = "4")]
		public void ProcessAnimation(AnimationStream stream)
		{
		}

		[Token(Token = "0x600024C")]
		[Address(RVA = "0x1577B80", Offset = "0x1577B80", VA = "0x1577B80")]
		private void Update(AnimationStream s)
		{
		}

		[Token(Token = "0x600024D")]
		[Address(RVA = "0x1577BBC", Offset = "0x1577BBC", VA = "0x1577BBC")]
		private void Read(AnimationStream s)
		{
		}

		[Token(Token = "0x600024E")]
		[Address(RVA = "0x1577BF8", Offset = "0x1577BF8", VA = "0x1577BF8")]
		private void Solve(AnimationStream s, Vector3 targetPosition, bool XY, float weight, int it, bool useRotationLimits)
		{
		}

		[Token(Token = "0x600024F")]
		[Address(RVA = "0x1577C3C", Offset = "0x1577C3C", VA = "0x1577C3C")]
		private Vector3 GetLocalDirection(AnimationStream s)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000250")]
		[Address(RVA = "0x1577C78", Offset = "0x1577C78", VA = "0x1577C78")]
		private float GetPositionOffset(AnimationStream s, Vector3 localDirection)
		{
			return default(float);
		}

		[Token(Token = "0x6000251")]
		[Address(RVA = "0x1577C80", Offset = "0x1577C80", VA = "0x1577C80")]
		private Vector3 GetSingularityOffset(AnimationStream s, Vector3 IKPosition, bool useRotationLimits)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000252")]
		[Address(RVA = "0x1577CC0", Offset = "0x1577CC0", VA = "0x1577CC0")]
		private bool SingularityDetected(AnimationStream s, Vector3 IKPosition)
		{
			return default(bool);
		}

		[Token(Token = "0x6000253")]
		[Address(RVA = "0x1577D00", Offset = "0x1577D00", VA = "0x1577D00")]
		public void Dispose()
		{
		}
	}
	[Token(Token = "0x2000048")]
	public class IKJBoneParams : MonoBehaviour
	{
		[Token(Token = "0x40001DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1443E34", Offset = "0x1443E34")]
		public float weight;

		[Token(Token = "0x6000254")]
		[Address(RVA = "0x2DC5A60", Offset = "0x2DC5A60", VA = "0x2DC5A60")]
		public IKJBoneParams()
		{
		}
	}
	[Token(Token = "0x2000049")]
	public static class RotationLimitUtilities
	{
		[Token(Token = "0x6000255")]
		[Address(RVA = "0x29434C0", Offset = "0x29434C0", VA = "0x29434C0")]
		public static Quaternion LimitHinge(Quaternion rotation, float min, float max, bool useLimits, Vector3 axis, ref Quaternion lastRotation, ref float lastAngle)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000256")]
		[Address(RVA = "0x29437E0", Offset = "0x29437E0", VA = "0x29437E0")]
		public static Quaternion Limit1DOF(Quaternion rotation, Vector3 axis)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000257")]
		[Address(RVA = "0x29438C4", Offset = "0x29438C4", VA = "0x29438C4")]
		public static Quaternion LimitAngle(Quaternion rotation, Vector3 axis, Vector3 secondaryAxis, float limit, float twistLimit)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000258")]
		[Address(RVA = "0x294392C", Offset = "0x294392C", VA = "0x294392C")]
		public static Quaternion LimitSwing(Quaternion rotation, Vector3 axis, float limit)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000259")]
		[Address(RVA = "0x2943B60", Offset = "0x2943B60", VA = "0x2943B60")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1443E4C", Offset = "0x1443E4C")]
		public float pull;

		[Token(Token = "0x40001DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1443E64", Offset = "0x1443E64")]
		public float pin;

		[Token(Token = "0x40001DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public int[] children;

		[Token(Token = "0x600025A")]
		[Address(RVA = "0x2A7D44C", Offset = "0x2A7D44C", VA = "0x2A7D44C")]
		public bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x600025B")]
		[Address(RVA = "0x2A7D514", Offset = "0x2A7D514", VA = "0x2A7D514")]
		public void Initiate()
		{
		}

		[Token(Token = "0x600025C")]
		[Address(RVA = "0x2A7D534", Offset = "0x2A7D534", VA = "0x2A7D534")]
		public void Stage1(FABRIKChain[] chain)
		{
		}

		[Token(Token = "0x600025D")]
		[Address(RVA = "0x2A7D904", Offset = "0x2A7D904", VA = "0x2A7D904")]
		public void Stage2(Vector3 rootPosition, FABRIKChain[] chain)
		{
		}

		[Token(Token = "0x600025E")]
		[Address(RVA = "0x2A7D608", Offset = "0x2A7D608", VA = "0x2A7D608")]
		private Vector3 GetCentroid(FABRIKChain[] chain)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600025F")]
		[Address(RVA = "0x2A7D9FC", Offset = "0x2A7D9FC", VA = "0x2A7D9FC")]
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
		[Address(RVA = "0x2A7DC04", Offset = "0x2A7DC04", VA = "0x2A7DC04")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000261")]
		[Address(RVA = "0x2A7E16C", Offset = "0x2A7E16C", VA = "0x2A7E16C")]
		private void OnPostFBBIK()
		{
		}

		[Token(Token = "0x6000262")]
		[Address(RVA = "0x2A7E32C", Offset = "0x2A7E32C", VA = "0x2A7E32C")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000263")]
		[Address(RVA = "0x2A7E424", Offset = "0x2A7E424", VA = "0x2A7E424")]
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
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1446940", Offset = "0x1446940")]
			public Transform transform;

			[Token(Token = "0x40009D5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1446978", Offset = "0x1446978")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1446978", Offset = "0x1446978")]
			public float weight;

			[Token(Token = "0x40009D6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			private Quaternion defaultLocalRotation;

			[Token(Token = "0x6000BEA")]
			[Address(RVA = "0x2A81454", Offset = "0x2A81454", VA = "0x2A81454")]
			public BendBone()
			{
			}

			[Token(Token = "0x6000BEB")]
			[Address(RVA = "0x2A814D4", Offset = "0x2A814D4", VA = "0x2A814D4")]
			public BendBone(Transform transform, float weight)
			{
			}

			[Token(Token = "0x6000BEC")]
			[Address(RVA = "0x2A7EBE4", Offset = "0x2A7EBE4", VA = "0x2A7EBE4")]
			public void StoreDefaultLocalState()
			{
			}

			[Token(Token = "0x6000BED")]
			[Address(RVA = "0x2A7EFE8", Offset = "0x2A7EFE8", VA = "0x2A7EFE8")]
			public void FixTransforms()
			{
			}
		}

		[Token(Token = "0x40001E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1443E7C", Offset = "0x1443E7C")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x40001E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x1443EB4", Offset = "0x1443EB4")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1443EB4", Offset = "0x1443EB4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1443EB4", Offset = "0x1443EB4")]
		public float positionWeight;

		[Token(Token = "0x40001E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1443F2C", Offset = "0x1443F2C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1443F2C", Offset = "0x1443F2C")]
		public float bodyWeight;

		[Token(Token = "0x40001EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1443F80", Offset = "0x1443F80")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1443F80", Offset = "0x1443F80")]
		public float thighWeight;

		[Token(Token = "0x40001EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1443FD4", Offset = "0x1443FD4")]
		public bool handsPullBody;

		[Token(Token = "0x40001EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x144400C", Offset = "0x144400C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x144400C", Offset = "0x144400C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x144400C", Offset = "0x144400C")]
		public float rotationWeight;

		[Token(Token = "0x40001ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1444084", Offset = "0x1444084")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1444084", Offset = "0x1444084")]
		public float bodyClampWeight;

		[Token(Token = "0x40001EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14440D8", Offset = "0x14440D8")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x14440D8", Offset = "0x14440D8")]
		public float headClampWeight;

		[Token(Token = "0x40001EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x144412C", Offset = "0x144412C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x144412C", Offset = "0x144412C")]
		public float bendWeight;

		[Token(Token = "0x40001F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1444180", Offset = "0x1444180")]
		public BendBone[] bendBones;

		[Token(Token = "0x40001F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x14441B8", Offset = "0x14441B8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14441B8", Offset = "0x14441B8")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x14441B8", Offset = "0x14441B8")]
		public float CCDWeight;

		[Token(Token = "0x40001F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1444230", Offset = "0x1444230")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1444230", Offset = "0x1444230")]
		public float roll;

		[Token(Token = "0x40001F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1444284", Offset = "0x1444284")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1444284", Offset = "0x1444284")]
		public float damper;

		[Token(Token = "0x40001F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14442DC", Offset = "0x14442DC")]
		public Transform[] CCDBones;

		[Token(Token = "0x40001F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x1444314", Offset = "0x1444314")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1444314", Offset = "0x1444314")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1444314", Offset = "0x1444314")]
		public float postStretchWeight;

		[Token(Token = "0x40001F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x144438C", Offset = "0x144438C")]
		public float maxStretch;

		[Token(Token = "0x40001F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14443C4", Offset = "0x14443C4")]
		public float stretchDamper;

		[Token(Token = "0x40001F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14443FC", Offset = "0x14443FC")]
		public bool fixHead;

		[Token(Token = "0x40001F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1444434", Offset = "0x1444434")]
		public Transform[] stretchBones;

		[Token(Token = "0x40001FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x144446C", Offset = "0x144446C")]
		public Vector3 chestDirection;

		[Token(Token = "0x40001FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x14444A4", Offset = "0x14444A4")]
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
		[Address(RVA = "0x2A7E42C", Offset = "0x2A7E42C", VA = "0x2A7E42C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000265")]
		[Address(RVA = "0x2A7E75C", Offset = "0x2A7E75C", VA = "0x2A7E75C")]
		private void OnStoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000266")]
		[Address(RVA = "0x2A7EC1C", Offset = "0x2A7EC1C", VA = "0x2A7EC1C")]
		private void OnFixTransforms()
		{
		}

		[Token(Token = "0x6000267")]
		[Address(RVA = "0x2A7F010", Offset = "0x2A7F010", VA = "0x2A7F010")]
		private void OnPreRead()
		{
		}

		[Token(Token = "0x6000268")]
		[Address(RVA = "0x2A7F988", Offset = "0x2A7F988", VA = "0x2A7F988")]
		private void SpineBend()
		{
		}

		[Token(Token = "0x6000269")]
		[Address(RVA = "0x2A7FCD4", Offset = "0x2A7FCD4", VA = "0x2A7FCD4")]
		private void CCDPass()
		{
		}

		[Token(Token = "0x600026A")]
		[Address(RVA = "0x2A80070", Offset = "0x2A80070", VA = "0x2A80070")]
		private void Iterate(int iteration)
		{
		}

		[Token(Token = "0x600026B")]
		[Address(RVA = "0x2A80ADC", Offset = "0x2A80ADC", VA = "0x2A80ADC")]
		private void OnPostUpdate()
		{
		}

		[Token(Token = "0x600026C")]
		[Address(RVA = "0x2A7F6B4", Offset = "0x2A7F6B4", VA = "0x2A7F6B4")]
		private void ChestDirection()
		{
		}

		[Token(Token = "0x600026D")]
		[Address(RVA = "0x2A80CEC", Offset = "0x2A80CEC", VA = "0x2A80CEC")]
		private void PostStretching()
		{
		}

		[Token(Token = "0x600026E")]
		[Address(RVA = "0x2A80998", Offset = "0x2A80998", VA = "0x2A80998")]
		private void LerpSolverPosition(IKEffector effector, Vector3 position, float weight, Vector3 offset)
		{
		}

		[Token(Token = "0x600026F")]
		[Address(RVA = "0x2A807FC", Offset = "0x2A807FC", VA = "0x2A807FC")]
		private void Solve(ref Vector3 pos1, ref Vector3 pos2, float nominalDistance)
		{
		}

		[Token(Token = "0x6000270")]
		[Address(RVA = "0x2A81058", Offset = "0x2A81058", VA = "0x2A81058")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000271")]
		[Address(RVA = "0x2A812D8", Offset = "0x2A812D8", VA = "0x2A812D8")]
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
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x14469EC", Offset = "0x14469EC")]
			private float <nominalDistance>k__BackingField;

			[Token(Token = "0x40009DC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x14469FC", Offset = "0x14469FC")]
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
				[Address(RVA = "0x2A84398", Offset = "0x2A84398", VA = "0x2A84398")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x144BB38", Offset = "0x144BB38")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000BEF")]
				[Address(RVA = "0x2A843A0", Offset = "0x2A843A0", VA = "0x2A843A0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x144BB48", Offset = "0x144BB48")]
				private set
				{
				}
			}

			[Token(Token = "0x1700008C")]
			public bool isRigid
			{
				[Token(Token = "0x6000BF0")]
				[Address(RVA = "0x2A843A8", Offset = "0x2A843A8", VA = "0x2A843A8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x144BB58", Offset = "0x144BB58")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6000BF1")]
				[Address(RVA = "0x2A843B0", Offset = "0x2A843B0", VA = "0x2A843B0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x144BB68", Offset = "0x144BB68")]
				private set
				{
				}
			}

			[Token(Token = "0x6000BF2")]
			[Address(RVA = "0x2A843BC", Offset = "0x2A843BC", VA = "0x2A843BC")]
			public ChildConstraint(Transform bone1, Transform bone2, float pushElasticity = 0f, float pullElasticity = 0f)
			{
			}

			[Token(Token = "0x6000BF3")]
			[Address(RVA = "0x2A8211C", Offset = "0x2A8211C", VA = "0x2A8211C")]
			public void Initiate(IKSolverFullBody solver)
			{
			}

			[Token(Token = "0x6000BF4")]
			[Address(RVA = "0x2A8265C", Offset = "0x2A8265C", VA = "0x2A8265C")]
			public void OnPreSolve(IKSolverFullBody solver)
			{
			}

			[Token(Token = "0x6000BF5")]
			[Address(RVA = "0x2A84094", Offset = "0x2A84094", VA = "0x2A84094")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x14444BC", Offset = "0x14444BC")]
		public float pin;

		[Token(Token = "0x4000216")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x14444D4", Offset = "0x14444D4")]
		public float pull;

		[Token(Token = "0x4000217")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x14444EC", Offset = "0x14444EC")]
		public float push;

		[Token(Token = "0x4000218")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1444504", Offset = "0x1444504")]
		public float pushParent;

		[Token(Token = "0x4000219")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x144451C", Offset = "0x144451C")]
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
		[Address(RVA = "0x2A81578", Offset = "0x2A81578", VA = "0x2A81578")]
		public FBIKChain()
		{
		}

		[Token(Token = "0x6000273")]
		[Address(RVA = "0x2A81644", Offset = "0x2A81644", VA = "0x2A81644")]
		public FBIKChain(float pin, float pull, params Transform[] nodeTransforms)
		{
		}

		[Token(Token = "0x6000274")]
		[Address(RVA = "0x2A81750", Offset = "0x2A81750", VA = "0x2A81750")]
		public void SetNodes(params Transform[] boneTransforms)
		{
		}

		[Token(Token = "0x6000275")]
		[Address(RVA = "0x2A81874", Offset = "0x2A81874", VA = "0x2A81874")]
		public int GetNodeIndex(Transform boneTransform)
		{
			return default(int);
		}

		[Token(Token = "0x6000276")]
		[Address(RVA = "0x2A81950", Offset = "0x2A81950", VA = "0x2A81950")]
		public bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000277")]
		[Address(RVA = "0x2A81A54", Offset = "0x2A81A54", VA = "0x2A81A54")]
		public void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000278")]
		[Address(RVA = "0x2A82174", Offset = "0x2A82174", VA = "0x2A82174")]
		public void ReadPose(IKSolverFullBody solver, bool fullBody)
		{
		}

		[Token(Token = "0x6000279")]
		[Address(RVA = "0x2A81BE4", Offset = "0x2A81BE4", VA = "0x2A81BE4")]
		private void CalculateBoneLengths(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x600027A")]
		[Address(RVA = "0x2A82860", Offset = "0x2A82860", VA = "0x2A82860")]
		public void Reach(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x600027B")]
		[Address(RVA = "0x2A82C04", Offset = "0x2A82C04", VA = "0x2A82C04")]
		public Vector3 Push(IKSolverFullBody solver)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600027C")]
		[Address(RVA = "0x2A82FE8", Offset = "0x2A82FE8", VA = "0x2A82FE8")]
		public void SolveTrigonometric(IKSolverFullBody solver, bool calculateBendDirection = false)
		{
		}

		[Token(Token = "0x600027D")]
		[Address(RVA = "0x2A8356C", Offset = "0x2A8356C", VA = "0x2A8356C")]
		public void Stage1(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x600027E")]
		[Address(RVA = "0x2A83B3C", Offset = "0x2A83B3C", VA = "0x2A83B3C")]
		public void Stage2(IKSolverFullBody solver, Vector3 position)
		{
		}

		[Token(Token = "0x600027F")]
		[Address(RVA = "0x2A83DD4", Offset = "0x2A83DD4", VA = "0x2A83DD4")]
		public void SolveConstraintSystems(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000280")]
		[Address(RVA = "0x2A83A34", Offset = "0x2A83A34", VA = "0x2A83A34")]
		private Vector3 SolveFABRIKJoint(Vector3 pos1, Vector3 pos2, float length)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000281")]
		[Address(RVA = "0x2A83354", Offset = "0x2A83354", VA = "0x2A83354")]
		protected Vector3 GetDirToBendPoint(Vector3 direction, Vector3 bendDirection, float directionMagnitude)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000282")]
		[Address(RVA = "0x2A839BC", Offset = "0x2A839BC", VA = "0x2A839BC")]
		private void SolveChildConstraints(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000283")]
		[Address(RVA = "0x2A83EBC", Offset = "0x2A83EBC", VA = "0x2A83EBC")]
		private void SolveLinearConstraint(IKSolver.Node node1, IKSolver.Node node2, float crossFade, float distance)
		{
		}

		[Token(Token = "0x6000284")]
		[Address(RVA = "0x2A838DC", Offset = "0x2A838DC", VA = "0x2A838DC")]
		public void ForwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x6000285")]
		[Address(RVA = "0x2A83CBC", Offset = "0x2A83CBC", VA = "0x2A83CBC")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1444534", Offset = "0x1444534")]
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
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x144454C", Offset = "0x144454C")]
		private bool <initiated>k__BackingField;

		[Token(Token = "0x400023D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x85")]
		private bool limbOrientationsSet;

		[Token(Token = "0x17000029")]
		public bool initiated
		{
			[Token(Token = "0x6000287")]
			[Address(RVA = "0x2DC2A50", Offset = "0x2DC2A50", VA = "0x2DC2A50")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x144ABA0", Offset = "0x144ABA0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000288")]
			[Address(RVA = "0x2DC2A58", Offset = "0x2DC2A58", VA = "0x2DC2A58")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x144ABB0", Offset = "0x144ABB0")]
			private set
			{
			}
		}

		[Token(Token = "0x6000286")]
		[Address(RVA = "0x2DC2888", Offset = "0x2DC2888", VA = "0x2DC2888")]
		public bool IsValid(IKSolverFullBody solver, Warning.Logger logger)
		{
			return default(bool);
		}

		[Token(Token = "0x6000289")]
		[Address(RVA = "0x2DC2A64", Offset = "0x2DC2A64", VA = "0x2DC2A64")]
		public IKConstraintBend()
		{
		}

		[Token(Token = "0x600028A")]
		[Address(RVA = "0x2DC2AE8", Offset = "0x2DC2AE8", VA = "0x2DC2AE8")]
		public IKConstraintBend(Transform bone1, Transform bone2, Transform bone3)
		{
		}

		[Token(Token = "0x600028B")]
		[Address(RVA = "0x2DC2B94", Offset = "0x2DC2B94", VA = "0x2DC2B94")]
		public void SetBones(Transform bone1, Transform bone2, Transform bone3)
		{
		}

		[Token(Token = "0x600028C")]
		[Address(RVA = "0x2DC2BA0", Offset = "0x2DC2BA0", VA = "0x2DC2BA0")]
		public void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x600028D")]
		[Address(RVA = "0x2DC3090", Offset = "0x2DC3090", VA = "0x2DC3090")]
		public void SetLimbOrientation(Vector3 upper, Vector3 lower, Vector3 last)
		{
		}

		[Token(Token = "0x600028E")]
		[Address(RVA = "0x2DC32C8", Offset = "0x2DC32C8", VA = "0x2DC32C8")]
		public void LimitBend(float solverWeight, float positionWeight)
		{
		}

		[Token(Token = "0x600028F")]
		[Address(RVA = "0x2DC3764", Offset = "0x2DC3764", VA = "0x2DC3764")]
		public Vector3 GetDir(IKSolverFullBody solver)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000290")]
		[Address(RVA = "0x2DC2E50", Offset = "0x2DC2E50", VA = "0x2DC2E50")]
		private Vector3 OrthoToLimb(IKSolverFullBody solver, Vector3 tangent)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000291")]
		[Address(RVA = "0x2DC2F70", Offset = "0x2DC2F70", VA = "0x2DC2F70")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x144455C", Offset = "0x144455C")]
		public float positionWeight;

		[Token(Token = "0x4000241")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1444574", Offset = "0x1444574")]
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
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x144458C", Offset = "0x144458C")]
		private bool <isEndEffector>k__BackingField;

		[Token(Token = "0x4000246")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x51")]
		public bool effectChildNodes;

		[Token(Token = "0x4000247")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x144459C", Offset = "0x144459C")]
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
			[Address(RVA = "0x2DC3DD0", Offset = "0x2DC3DD0", VA = "0x2DC3DD0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x144ABC0", Offset = "0x144ABC0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000294")]
			[Address(RVA = "0x2DC3DD8", Offset = "0x2DC3DD8", VA = "0x2DC3DD8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x144ABD0", Offset = "0x144ABD0")]
			private set
			{
			}
		}

		[Token(Token = "0x6000292")]
		[Address(RVA = "0x2DC3D68", Offset = "0x2DC3D68", VA = "0x2DC3D68")]
		public IKSolver.Node GetNode(IKSolverFullBody solver)
		{
			return null;
		}

		[Token(Token = "0x6000295")]
		[Address(RVA = "0x2DC3DE4", Offset = "0x2DC3DE4", VA = "0x2DC3DE4")]
		public void PinToBone(float positionWeight, float rotationWeight)
		{
		}

		[Token(Token = "0x6000296")]
		[Address(RVA = "0x2DC3EB8", Offset = "0x2DC3EB8", VA = "0x2DC3EB8")]
		public IKEffector()
		{
		}

		[Token(Token = "0x6000297")]
		[Address(RVA = "0x2DC3FF4", Offset = "0x2DC3FF4", VA = "0x2DC3FF4")]
		public IKEffector(Transform bone, Transform[] childBones)
		{
		}

		[Token(Token = "0x6000298")]
		[Address(RVA = "0x2DC414C", Offset = "0x2DC414C", VA = "0x2DC414C")]
		public bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000299")]
		[Address(RVA = "0x2DC443C", Offset = "0x2DC443C", VA = "0x2DC443C")]
		public void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x600029A")]
		[Address(RVA = "0x2DC46DC", Offset = "0x2DC46DC", VA = "0x2DC46DC")]
		public void ResetOffset(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x600029B")]
		[Address(RVA = "0x2DC481C", Offset = "0x2DC481C", VA = "0x2DC481C")]
		public void SetToTarget()
		{
		}

		[Token(Token = "0x600029C")]
		[Address(RVA = "0x2DC48C8", Offset = "0x2DC48C8", VA = "0x2DC48C8")]
		public void OnPreSolve(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x600029D")]
		[Address(RVA = "0x2DC4F1C", Offset = "0x2DC4F1C", VA = "0x2DC4F1C")]
		public void OnPostWrite()
		{
		}

		[Token(Token = "0x600029E")]
		[Address(RVA = "0x2DC4F8C", Offset = "0x2DC4F8C", VA = "0x2DC4F8C")]
		private Quaternion GetPlaneRotation(IKSolverFullBody solver)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600029F")]
		[Address(RVA = "0x2DC51A4", Offset = "0x2DC51A4", VA = "0x2DC51A4")]
		public void Update(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60002A0")]
		[Address(RVA = "0x2DC54EC", Offset = "0x2DC54EC", VA = "0x2DC54EC")]
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
				[Address(RVA = "0x2DC5CDC", Offset = "0x2DC5CDC", VA = "0x2DC5CDC")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x1700008E")]
			public bool isNodeBone
			{
				[Token(Token = "0x6000BFA")]
				[Address(RVA = "0x2DC5E48", Offset = "0x2DC5E48", VA = "0x2DC5E48")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x1700008F")]
			private Quaternion lastAnimatedTargetRotation
			{
				[Token(Token = "0x6000C0E")]
				[Address(RVA = "0x2DC642C", Offset = "0x2DC642C", VA = "0x2DC642C")]
				get
				{
					return default(Quaternion);
				}
			}

			[Token(Token = "0x6000BF6")]
			[Address(RVA = "0x2DC5CB0", Offset = "0x2DC5CB0", VA = "0x2DC5CB0")]
			public void Initiate(Transform transform, IKSolverFullBody solver)
			{
			}

			[Token(Token = "0x6000BF8")]
			[Address(RVA = "0x2DC5DA8", Offset = "0x2DC5DA8", VA = "0x2DC5DA8")]
			public void StoreDefaultLocalState()
			{
			}

			[Token(Token = "0x6000BF9")]
			[Address(RVA = "0x2DC5DF8", Offset = "0x2DC5DF8", VA = "0x2DC5DF8")]
			public void FixTransform(bool position)
			{
			}

			[Token(Token = "0x6000BFB")]
			[Address(RVA = "0x2DC5E58", Offset = "0x2DC5E58", VA = "0x2DC5E58")]
			public void SetLength(BoneMap nextBone)
			{
			}

			[Token(Token = "0x6000BFC")]
			[Address(RVA = "0x2DC5F40", Offset = "0x2DC5F40", VA = "0x2DC5F40")]
			public void SetLocalSwingAxis(BoneMap swingTarget)
			{
			}

			[Token(Token = "0x6000BFD")]
			[Address(RVA = "0x2DC5F48", Offset = "0x2DC5F48", VA = "0x2DC5F48")]
			public void SetLocalSwingAxis(BoneMap bone1, BoneMap bone2)
			{
			}

			[Token(Token = "0x6000BFE")]
			[Address(RVA = "0x2DC60D8", Offset = "0x2DC60D8", VA = "0x2DC60D8")]
			public void SetLocalTwistAxis(Vector3 twistDirection, Vector3 normalDirection)
			{
			}

			[Token(Token = "0x6000BFF")]
			[Address(RVA = "0x2DC61E4", Offset = "0x2DC61E4", VA = "0x2DC61E4")]
			public void SetPlane(IKSolverFullBody solver, Transform planeBone1, Transform planeBone2, Transform planeBone3)
			{
			}

			[Token(Token = "0x6000C00")]
			[Address(RVA = "0x2DC627C", Offset = "0x2DC627C", VA = "0x2DC627C")]
			public void UpdatePlane(bool rotation, bool position)
			{
			}

			[Token(Token = "0x6000C01")]
			[Address(RVA = "0x2DC6650", Offset = "0x2DC6650", VA = "0x2DC6650")]
			public void SetIKPosition()
			{
			}

			[Token(Token = "0x6000C02")]
			[Address(RVA = "0x2DC6688", Offset = "0x2DC6688", VA = "0x2DC6688")]
			public void MaintainRotation()
			{
			}

			[Token(Token = "0x6000C03")]
			[Address(RVA = "0x2DC66C0", Offset = "0x2DC66C0", VA = "0x2DC66C0")]
			public void SetToIKPosition()
			{
			}

			[Token(Token = "0x6000C04")]
			[Address(RVA = "0x2DC66E8", Offset = "0x2DC66E8", VA = "0x2DC66E8")]
			public void FixToNode(IKSolverFullBody solver, float weight, [Optional] IKSolver.Node fixNode)
			{
			}

			[Token(Token = "0x6000C05")]
			[Address(RVA = "0x2DC6814", Offset = "0x2DC6814", VA = "0x2DC6814")]
			public Vector3 GetPlanePosition(IKSolverFullBody solver)
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000C06")]
			[Address(RVA = "0x2DC6B5C", Offset = "0x2DC6B5C", VA = "0x2DC6B5C")]
			public void PositionToPlane(IKSolverFullBody solver)
			{
			}

			[Token(Token = "0x6000C07")]
			[Address(RVA = "0x2DC6B8C", Offset = "0x2DC6B8C", VA = "0x2DC6B8C")]
			public void RotateToPlane(IKSolverFullBody solver, float weight)
			{
			}

			[Token(Token = "0x6000C08")]
			[Address(RVA = "0x2DC6D24", Offset = "0x2DC6D24", VA = "0x2DC6D24")]
			public void Swing(Vector3 swingTarget, float weight)
			{
			}

			[Token(Token = "0x6000C09")]
			[Address(RVA = "0x2DC6D94", Offset = "0x2DC6D94", VA = "0x2DC6D94")]
			public void Swing(Vector3 pos1, Vector3 pos2, float weight)
			{
			}

			[Token(Token = "0x6000C0A")]
			[Address(RVA = "0x2DC6FD8", Offset = "0x2DC6FD8", VA = "0x2DC6FD8")]
			public void Twist(Vector3 twistDirection, Vector3 normalDirection, float weight)
			{
			}

			[Token(Token = "0x6000C0B")]
			[Address(RVA = "0x2DC7200", Offset = "0x2DC7200", VA = "0x2DC7200")]
			public void RotateToMaintain(float weight)
			{
			}

			[Token(Token = "0x6000C0C")]
			[Address(RVA = "0x2DC7318", Offset = "0x2DC7318", VA = "0x2DC7318")]
			public void RotateToEffector(IKSolverFullBody solver, float weight)
			{
			}

			[Token(Token = "0x6000C0D")]
			[Address(RVA = "0x2DC6958", Offset = "0x2DC6958", VA = "0x2DC6958")]
			private Quaternion GetTargetRotation(IKSolverFullBody solver)
			{
				return default(Quaternion);
			}

			[Token(Token = "0x6000C0F")]
			[Address(RVA = "0x2DC74B4", Offset = "0x2DC74B4", VA = "0x2DC74B4")]
			public BoneMap()
			{
			}
		}

		[Token(Token = "0x60002A1")]
		[Address(RVA = "0x2DC5A70", Offset = "0x2DC5A70", VA = "0x2DC5A70", Slot = "4")]
		public virtual bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60002A2")]
		[Address(RVA = "0x2DC5A78", Offset = "0x2DC5A78", VA = "0x2DC5A78", Slot = "5")]
		public virtual void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60002A3")]
		[Address(RVA = "0x2DC5A7C", Offset = "0x2DC5A7C", VA = "0x2DC5A7C")]
		protected bool BoneIsValid(Transform bone, IKSolver solver, ref string message, [Optional] Warning.Logger logger)
		{
			return default(bool);
		}

		[Token(Token = "0x60002A4")]
		[Address(RVA = "0x2DC5BA0", Offset = "0x2DC5BA0", VA = "0x2DC5BA0")]
		protected Vector3 SolveFABRIKJoint(Vector3 pos1, Vector3 pos2, float length)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002A5")]
		[Address(RVA = "0x2DC5CA8", Offset = "0x2DC5CA8", VA = "0x2DC5CA8")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x14445B4", Offset = "0x14445B4")]
		public float maintainRotationWeight;

		[Token(Token = "0x4000260")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private BoneMap boneMap;

		[Token(Token = "0x60002A6")]
		[Address(RVA = "0x2DC74D0", Offset = "0x2DC74D0", VA = "0x2DC74D0", Slot = "4")]
		public override bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60002A7")]
		[Address(RVA = "0x2DC7570", Offset = "0x2DC7570", VA = "0x2DC7570")]
		public IKMappingBone()
		{
		}

		[Token(Token = "0x60002A8")]
		[Address(RVA = "0x2DC75F4", Offset = "0x2DC75F4", VA = "0x2DC75F4")]
		public IKMappingBone(Transform bone)
		{
		}

		[Token(Token = "0x60002A9")]
		[Address(RVA = "0x2DC768C", Offset = "0x2DC768C", VA = "0x2DC768C")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60002AA")]
		[Address(RVA = "0x2DC76A4", Offset = "0x2DC76A4", VA = "0x2DC76A4")]
		public void FixTransforms()
		{
		}

		[Token(Token = "0x60002AB")]
		[Address(RVA = "0x2DC76C0", Offset = "0x2DC76C0", VA = "0x2DC76C0", Slot = "5")]
		public override void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60002AC")]
		[Address(RVA = "0x2DC775C", Offset = "0x2DC775C", VA = "0x2DC775C")]
		public void ReadPose()
		{
		}

		[Token(Token = "0x60002AD")]
		[Address(RVA = "0x2DC7774", Offset = "0x2DC7774", VA = "0x2DC7774")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x14445CC", Offset = "0x14445CC")]
		public float maintainRotationWeight;

		[Token(Token = "0x4000266")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x14445E4", Offset = "0x14445E4")]
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
		[Address(RVA = "0x2DC7798", Offset = "0x2DC7798", VA = "0x2DC7798", Slot = "4")]
		public override bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60002AF")]
		[Address(RVA = "0x2DC781C", Offset = "0x2DC781C", VA = "0x2DC781C")]
		public BoneMap GetBoneMap(BoneMapType boneMap)
		{
			return null;
		}

		[Token(Token = "0x60002B0")]
		[Address(RVA = "0x2DC78F0", Offset = "0x2DC78F0", VA = "0x2DC78F0")]
		public void SetLimbOrientation(Vector3 upper, Vector3 lower)
		{
		}

		[Token(Token = "0x60002B1")]
		[Address(RVA = "0x2DC7C44", Offset = "0x2DC7C44", VA = "0x2DC7C44")]
		public IKMappingLimb()
		{
		}

		[Token(Token = "0x60002B2")]
		[Address(RVA = "0x2DC7D4C", Offset = "0x2DC7D4C", VA = "0x2DC7D4C")]
		public IKMappingLimb(Transform bone1, Transform bone2, Transform bone3, [Optional] Transform parentBone)
		{
		}

		[Token(Token = "0x60002B3")]
		[Address(RVA = "0x2DC7E80", Offset = "0x2DC7E80", VA = "0x2DC7E80")]
		public void SetBones(Transform bone1, Transform bone2, Transform bone3, [Optional] Transform parentBone)
		{
		}

		[Token(Token = "0x60002B4")]
		[Address(RVA = "0x2DC7E8C", Offset = "0x2DC7E8C", VA = "0x2DC7E8C")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60002B5")]
		[Address(RVA = "0x2DC7F34", Offset = "0x2DC7F34", VA = "0x2DC7F34")]
		public void FixTransforms()
		{
		}

		[Token(Token = "0x60002B6")]
		[Address(RVA = "0x2DC7FEC", Offset = "0x2DC7FEC", VA = "0x2DC7FEC", Slot = "5")]
		public override void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60002B7")]
		[Address(RVA = "0x2DC825C", Offset = "0x2DC825C", VA = "0x2DC825C")]
		public void ReadPose()
		{
		}

		[Token(Token = "0x60002B8")]
		[Address(RVA = "0x2DC8314", Offset = "0x2DC8314", VA = "0x2DC8314")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x14445FC", Offset = "0x14445FC")]
		public int iterations;

		[Token(Token = "0x4000272")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1444614", Offset = "0x1444614")]
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
		[Address(RVA = "0x2DC8480", Offset = "0x2DC8480", VA = "0x2DC8480", Slot = "4")]
		public override bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60002BA")]
		[Address(RVA = "0x2DC8770", Offset = "0x2DC8770", VA = "0x2DC8770")]
		public IKMappingSpine()
		{
		}

		[Token(Token = "0x60002BB")]
		[Address(RVA = "0x2DC888C", Offset = "0x2DC888C", VA = "0x2DC888C")]
		public IKMappingSpine(Transform[] spineBones, Transform leftUpperArmBone, Transform rightUpperArmBone, Transform leftThighBone, Transform rightThighBone)
		{
		}

		[Token(Token = "0x60002BC")]
		[Address(RVA = "0x2DC89E4", Offset = "0x2DC89E4", VA = "0x2DC89E4")]
		public void SetBones(Transform[] spineBones, Transform leftUpperArmBone, Transform rightUpperArmBone, Transform leftThighBone, Transform rightThighBone)
		{
		}

		[Token(Token = "0x60002BD")]
		[Address(RVA = "0x2DC89F4", Offset = "0x2DC89F4", VA = "0x2DC89F4")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60002BE")]
		[Address(RVA = "0x2DC8A5C", Offset = "0x2DC8A5C", VA = "0x2DC8A5C")]
		public void FixTransforms()
		{
		}

		[Token(Token = "0x60002BF")]
		[Address(RVA = "0x2DC8ADC", Offset = "0x2DC8ADC", VA = "0x2DC8ADC", Slot = "5")]
		public override void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60002C0")]
		[Address(RVA = "0x2DC9130", Offset = "0x2DC9130", VA = "0x2DC9130")]
		private bool UseFABRIK()
		{
			return default(bool);
		}

		[Token(Token = "0x60002C1")]
		[Address(RVA = "0x2DC9168", Offset = "0x2DC9168", VA = "0x2DC9168")]
		public void ReadPose()
		{
		}

		[Token(Token = "0x60002C2")]
		[Address(RVA = "0x2DC9448", Offset = "0x2DC9448", VA = "0x2DC9448")]
		public void WritePose(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60002C3")]
		[Address(RVA = "0x2DC97FC", Offset = "0x2DC97FC", VA = "0x2DC97FC")]
		public void ForwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x60002C4")]
		[Address(RVA = "0x2DC98E8", Offset = "0x2DC98E8", VA = "0x2DC98E8")]
		private void BackwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x60002C5")]
		[Address(RVA = "0x2DC99B0", Offset = "0x2DC99B0", VA = "0x2DC99B0")]
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
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1446A0C", Offset = "0x1446A0C")]
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
			[Address(RVA = "0x2DCB2CC", Offset = "0x2DCB2CC", VA = "0x2DCB2CC")]
			public void StoreDefaultLocalState()
			{
			}

			[Token(Token = "0x6000C11")]
			[Address(RVA = "0x2DCB31C", Offset = "0x2DCB31C", VA = "0x2DCB31C")]
			public void FixTransform()
			{
			}

			[Token(Token = "0x6000C12")]
			[Address(RVA = "0x2DCB4A4", Offset = "0x2DCB4A4", VA = "0x2DCB4A4")]
			public void UpdateSolverPosition()
			{
			}

			[Token(Token = "0x6000C13")]
			[Address(RVA = "0x2DCB4DC", Offset = "0x2DCB4DC", VA = "0x2DCB4DC")]
			public void UpdateSolverLocalPosition()
			{
			}

			[Token(Token = "0x6000C14")]
			[Address(RVA = "0x2DCB514", Offset = "0x2DCB514", VA = "0x2DCB514")]
			public void UpdateSolverState()
			{
			}

			[Token(Token = "0x6000C15")]
			[Address(RVA = "0x2DCB564", Offset = "0x2DCB564", VA = "0x2DCB564")]
			public void UpdateSolverLocalState()
			{
			}

			[Token(Token = "0x6000C16")]
			[Address(RVA = "0x2DCADA0", Offset = "0x2DCADA0", VA = "0x2DCADA0")]
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
				[Address(RVA = "0x2DCA370", Offset = "0x2DCA370", VA = "0x2DCA370")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000C18")]
				[Address(RVA = "0x2DCA464", Offset = "0x2DCA464", VA = "0x2DCA464")]
				set
				{
				}
			}

			[Token(Token = "0x6000C19")]
			[Address(RVA = "0x2DCA4EC", Offset = "0x2DCA4EC", VA = "0x2DCA4EC")]
			public void Swing(Vector3 swingTarget, float weight = 1f)
			{
			}

			[Token(Token = "0x6000C1A")]
			[Address(RVA = "0x2DCA7AC", Offset = "0x2DCA7AC", VA = "0x2DCA7AC")]
			public static void SolverSwing(Bone[] bones, int index, Vector3 swingTarget, float weight = 1f)
			{
			}

			[Token(Token = "0x6000C1B")]
			[Address(RVA = "0x2DCAA8C", Offset = "0x2DCAA8C", VA = "0x2DCAA8C")]
			public void Swing2D(Vector3 swingTarget, float weight = 1f)
			{
			}

			[Token(Token = "0x6000C1C")]
			[Address(RVA = "0x2DCACF4", Offset = "0x2DCACF4", VA = "0x2DCACF4")]
			public void SetToSolverPosition()
			{
			}

			[Token(Token = "0x6000C1D")]
			[Address(RVA = "0x2DCAD1C", Offset = "0x2DCAD1C", VA = "0x2DCAD1C")]
			public Bone()
			{
			}

			[Token(Token = "0x6000C1E")]
			[Address(RVA = "0x2DCAE20", Offset = "0x2DCAE20", VA = "0x2DCAE20")]
			public Bone(Transform transform)
			{
			}

			[Token(Token = "0x6000C1F")]
			[Address(RVA = "0x2DCAEB8", Offset = "0x2DCAEB8", VA = "0x2DCAEB8")]
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
			[Address(RVA = "0x2DCB268", Offset = "0x2DCB268", VA = "0x2DCB268")]
			public Node()
			{
			}

			[Token(Token = "0x6000C21")]
			[Address(RVA = "0x2DCB26C", Offset = "0x2DCB26C", VA = "0x2DCB26C")]
			public Node(Transform transform)
			{
			}

			[Token(Token = "0x6000C22")]
			[Address(RVA = "0x2DCB294", Offset = "0x2DCB294", VA = "0x2DCB294")]
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
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x144463C", Offset = "0x144463C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x144463C", Offset = "0x144463C")]
		public float IKPositionWeight;

		[Token(Token = "0x400027C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1444690", Offset = "0x1444690")]
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
			[Address(RVA = "0x2DC9DC0", Offset = "0x2DC9DC0", VA = "0x2DC9DC0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x144ABE0", Offset = "0x144ABE0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60002D0")]
			[Address(RVA = "0x2DC9DC8", Offset = "0x2DC9DC8", VA = "0x2DC9DC8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x144ABF0", Offset = "0x144ABF0")]
			private set
			{
			}
		}

		[Token(Token = "0x60002C6")]
		[Address(RVA = "0x2DC9C98", Offset = "0x2DC9C98", VA = "0x2DC9C98")]
		public bool IsValid()
		{
			return default(bool);
		}

		[Token(Token = "0x60002C7")]
		public abstract bool IsValid(ref string message);

		[Token(Token = "0x60002C8")]
		[Address(RVA = "0x2DC26D4", Offset = "0x2DC26D4", VA = "0x2DC26D4")]
		public void Initiate(Transform root)
		{
		}

		[Token(Token = "0x60002C9")]
		[Address(RVA = "0x2DC25F4", Offset = "0x2DC25F4", VA = "0x2DC25F4")]
		public void Update()
		{
		}

		[Token(Token = "0x60002CA")]
		[Address(RVA = "0x2DC9D14", Offset = "0x2DC9D14", VA = "0x2DC9D14", Slot = "5")]
		public virtual Vector3 GetIKPosition()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002CB")]
		[Address(RVA = "0x2DC9D20", Offset = "0x2DC9D20", VA = "0x2DC9D20")]
		public void SetIKPosition(Vector3 position)
		{
		}

		[Token(Token = "0x60002CC")]
		[Address(RVA = "0x2DC9D2C", Offset = "0x2DC9D2C", VA = "0x2DC9D2C")]
		public float GetIKPositionWeight()
		{
			return default(float);
		}

		[Token(Token = "0x60002CD")]
		[Address(RVA = "0x2DC9D34", Offset = "0x2DC9D34", VA = "0x2DC9D34")]
		public void SetIKPositionWeight(float weight)
		{
		}

		[Token(Token = "0x60002CE")]
		[Address(RVA = "0x2DC9DB8", Offset = "0x2DC9DB8", VA = "0x2DC9DB8")]
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
		[Address(RVA = "0x2DC9DD4", Offset = "0x2DC9DD4", VA = "0x2DC9DD4")]
		protected void LogWarning(string message)
		{
		}

		[Token(Token = "0x60002D8")]
		[Address(RVA = "0x2DC9DEC", Offset = "0x2DC9DEC", VA = "0x2DC9DEC")]
		public static Transform ContainsDuplicateBone(Bone[] bones)
		{
			return null;
		}

		[Token(Token = "0x60002D9")]
		[Address(RVA = "0x2DC9F28", Offset = "0x2DC9F28", VA = "0x2DC9F28")]
		public static bool HierarchyIsValid(Bone[] bones)
		{
			return default(bool);
		}

		[Token(Token = "0x60002DA")]
		[Address(RVA = "0x2DC9FD4", Offset = "0x2DC9FD4", VA = "0x2DC9FD4")]
		protected static float PreSolveBones(ref Bone[] bones)
		{
			return default(float);
		}

		[Token(Token = "0x60002DB")]
		[Address(RVA = "0x2DCA358", Offset = "0x2DCA358", VA = "0x2DCA358")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x14446D8", Offset = "0x14446D8")]
		public float poleWeight;

		[Token(Token = "0x4000288")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public Transform poleTarget;

		[Token(Token = "0x4000289")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x14446F0", Offset = "0x14446F0")]
		public float clampWeight;

		[Token(Token = "0x400028A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1444708", Offset = "0x1444708")]
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
			[Address(RVA = "0x2CCB4EC", Offset = "0x2CCB4EC", VA = "0x2CCB4EC")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x1700002D")]
		public Vector3 transformPoleAxis
		{
			[Token(Token = "0x60002DE")]
			[Address(RVA = "0x2CCB5B8", Offset = "0x2CCB5B8", VA = "0x2CCB5B8")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x1700002E")]
		protected override int minBones
		{
			[Token(Token = "0x60002E1")]
			[Address(RVA = "0x2CCC330", Offset = "0x2CCC330", VA = "0x2CCC330", Slot = "12")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700002F")]
		protected override Vector3 localDirection
		{
			[Token(Token = "0x60002E5")]
			[Address(RVA = "0x2CCC8DC", Offset = "0x2CCC8DC", VA = "0x2CCC8DC", Slot = "15")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x60002DC")]
		[Address(RVA = "0x2CCB3EC", Offset = "0x2CCB3EC", VA = "0x2CCB3EC")]
		public float GetAngle()
		{
			return default(float);
		}

		[Token(Token = "0x60002DF")]
		[Address(RVA = "0x2CCB684", Offset = "0x2CCB684", VA = "0x2CCB684", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x60002E0")]
		[Address(RVA = "0x2CCB90C", Offset = "0x2CCB90C", VA = "0x2CCB90C", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x60002E2")]
		[Address(RVA = "0x2CCC27C", Offset = "0x2CCC27C", VA = "0x2CCC27C")]
		private void Solve()
		{
		}

		[Token(Token = "0x60002E3")]
		[Address(RVA = "0x2CCBEA4", Offset = "0x2CCBEA4", VA = "0x2CCBEA4")]
		private Vector3 GetClampedIKPosition()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002E4")]
		[Address(RVA = "0x2CCC338", Offset = "0x2CCC338", VA = "0x2CCC338")]
		private void RotateToTarget(Vector3 targetPosition, Bone bone, float weight)
		{
		}

		[Token(Token = "0x60002E6")]
		[Address(RVA = "0x2CCC950", Offset = "0x2CCC950", VA = "0x2CCC950")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1444720", Offset = "0x1444720")]
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
		[Address(RVA = "0x2CCCA54", Offset = "0x2CCCA54", VA = "0x2CCCA54", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60002E8")]
		[Address(RVA = "0x2CCCDC8", Offset = "0x2CCCDC8", VA = "0x2CCCDC8")]
		public bool SetChain(Transform chest, Transform shoulder, Transform upperArm, Transform forearm, Transform hand, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x60002E9")]
		[Address(RVA = "0x2CCCE38", Offset = "0x2CCCE38", VA = "0x2CCCE38", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x60002EA")]
		[Address(RVA = "0x2CCCF94", Offset = "0x2CCCF94", VA = "0x2CCCF94", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x60002EB")]
		[Address(RVA = "0x2CCD12C", Offset = "0x2CCD12C", VA = "0x2CCD12C", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60002EC")]
		[Address(RVA = "0x2CCD188", Offset = "0x2CCD188", VA = "0x2CCD188", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x60002ED")]
		[Address(RVA = "0x2CCD1F8", Offset = "0x2CCD1F8", VA = "0x2CCD1F8", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x60002EE")]
		[Address(RVA = "0x2CCD568", Offset = "0x2CCD568", VA = "0x2CCD568", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x60002EF")]
		[Address(RVA = "0x2CCD594", Offset = "0x2CCD594", VA = "0x2CCD594")]
		private void Solve()
		{
		}

		[Token(Token = "0x60002F0")]
		[Address(RVA = "0x2CCD25C", Offset = "0x2CCD25C", VA = "0x2CCD25C")]
		private void Read()
		{
		}

		[Token(Token = "0x60002F1")]
		[Address(RVA = "0x2CCD600", Offset = "0x2CCD600", VA = "0x2CCD600")]
		private void Write()
		{
		}

		[Token(Token = "0x60002F2")]
		[Address(RVA = "0x2CCD78C", Offset = "0x2CCD78C", VA = "0x2CCD78C")]
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
		[Address(RVA = "0x2CCD8E4", Offset = "0x2CCD8E4", VA = "0x2CCD8E4")]
		public void FadeOutBoneWeights()
		{
		}

		[Token(Token = "0x60002F4")]
		[Address(RVA = "0x2CCD994", Offset = "0x2CCD994", VA = "0x2CCD994", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x60002F5")]
		[Address(RVA = "0x2CCDF94", Offset = "0x2CCDF94", VA = "0x2CCDF94", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x60002F6")]
		[Address(RVA = "0x2CCE6F4", Offset = "0x2CCE6F4", VA = "0x2CCE6F4")]
		protected void Solve(Vector3 targetPosition)
		{
		}

		[Token(Token = "0x60002F7")]
		[Address(RVA = "0x2CCEE58", Offset = "0x2CCEE58", VA = "0x2CCEE58")]
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
			[Address(RVA = "0x2CD0074", Offset = "0x2CD0074", VA = "0x2CD0074", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60002F8")]
		[Address(RVA = "0x2CCEE5C", Offset = "0x2CCEE5C", VA = "0x2CCEE5C")]
		public void SolveForward(Vector3 position)
		{
		}

		[Token(Token = "0x60002F9")]
		[Address(RVA = "0x2CCF5A0", Offset = "0x2CCF5A0", VA = "0x2CCF5A0")]
		public void SolveBackward(Vector3 position)
		{
		}

		[Token(Token = "0x60002FA")]
		[Address(RVA = "0x2CCF6D4", Offset = "0x2CCF6D4", VA = "0x2CCF6D4", Slot = "5")]
		public override Vector3 GetIKPosition()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002FB")]
		[Address(RVA = "0x2CCF76C", Offset = "0x2CCF76C", VA = "0x2CCF76C", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x60002FC")]
		[Address(RVA = "0x2CCFD10", Offset = "0x2CCFD10", VA = "0x2CCFD10", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x60002FE")]
		[Address(RVA = "0x2CD007C", Offset = "0x2CD007C", VA = "0x2CD007C")]
		private Vector3 SolveJoint(Vector3 pos1, Vector3 pos2, float length)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002FF")]
		[Address(RVA = "0x2CCEF2C", Offset = "0x2CCEF2C", VA = "0x2CCEF2C")]
		private void OnPreSolve()
		{
		}

		[Token(Token = "0x6000300")]
		[Address(RVA = "0x2CCF680", Offset = "0x2CCF680", VA = "0x2CCF680")]
		private void OnPostSolve()
		{
		}

		[Token(Token = "0x6000301")]
		[Address(RVA = "0x2CD0018", Offset = "0x2CD0018", VA = "0x2CD0018")]
		private void Solve(Vector3 targetPosition)
		{
		}

		[Token(Token = "0x6000302")]
		[Address(RVA = "0x2CCF3C8", Offset = "0x2CCF3C8", VA = "0x2CCF3C8")]
		private void ForwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x6000303")]
		[Address(RVA = "0x2CD08C4", Offset = "0x2CD08C4", VA = "0x2CD08C4")]
		private void SolverMove(int index, Vector3 offset)
		{
		}

		[Token(Token = "0x6000304")]
		[Address(RVA = "0x2CD09D4", Offset = "0x2CD09D4", VA = "0x2CD09D4")]
		private void SolverRotate(int index, Quaternion rotation, bool recursive)
		{
		}

		[Token(Token = "0x6000305")]
		[Address(RVA = "0x2CD0B00", Offset = "0x2CD0B00", VA = "0x2CD0B00")]
		private void SolverRotateChildren(int index, Quaternion rotation)
		{
		}

		[Token(Token = "0x6000306")]
		[Address(RVA = "0x2CD0C18", Offset = "0x2CD0C18", VA = "0x2CD0C18")]
		private void SolverMoveChildrenAroundPoint(int index, Quaternion rotation)
		{
		}

		[Token(Token = "0x6000307")]
		[Address(RVA = "0x2CCFA78", Offset = "0x2CCFA78", VA = "0x2CCFA78")]
		private Quaternion GetParentSolverRotation(int index)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000308")]
		[Address(RVA = "0x2CCFBC4", Offset = "0x2CCFBC4", VA = "0x2CCFBC4")]
		private Vector3 GetParentSolverPosition(int index)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000309")]
		[Address(RVA = "0x2CD0E04", Offset = "0x2CD0E04", VA = "0x2CD0E04")]
		private Quaternion GetLimitedRotation(int index, Quaternion q, out bool changed)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600030A")]
		[Address(RVA = "0x2CD0338", Offset = "0x2CD0338", VA = "0x2CD0338")]
		private void LimitForward(int rotateBone, int limitBone)
		{
		}

		[Token(Token = "0x600030B")]
		[Address(RVA = "0x2CCF670", Offset = "0x2CCF670", VA = "0x2CCF670")]
		private void BackwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x600030C")]
		[Address(RVA = "0x2CD1574", Offset = "0x2CD1574", VA = "0x2CD1574")]
		private void BackwardReachUnlimited(Vector3 position)
		{
		}

		[Token(Token = "0x600030D")]
		[Address(RVA = "0x2CD0FDC", Offset = "0x2CD0FDC", VA = "0x2CD0FDC")]
		private void BackwardReachLimited(Vector3 position)
		{
		}

		[Token(Token = "0x600030E")]
		[Address(RVA = "0x2CD0194", Offset = "0x2CD0194", VA = "0x2CD0194")]
		private void MapToSolverPositions()
		{
		}

		[Token(Token = "0x600030F")]
		[Address(RVA = "0x2CD0274", Offset = "0x2CD0274", VA = "0x2CD0274")]
		private void MapToSolverPositionsLimited()
		{
		}

		[Token(Token = "0x6000310")]
		[Address(RVA = "0x2CD1640", Offset = "0x2CD1640", VA = "0x2CD1640")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1444738", Offset = "0x1444738")]
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
		[Address(RVA = "0x2CD16B4", Offset = "0x2CD16B4", VA = "0x2CD16B4", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000312")]
		[Address(RVA = "0x2CD1F80", Offset = "0x2CD1F80", VA = "0x2CD1F80", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000313")]
		[Address(RVA = "0x2CD2018", Offset = "0x2CD2018", VA = "0x2CD2018", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x6000314")]
		[Address(RVA = "0x2CD20B8", Offset = "0x2CD20B8", VA = "0x2CD20B8", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000315")]
		[Address(RVA = "0x2CD21B8", Offset = "0x2CD21B8", VA = "0x2CD21B8")]
		private bool IsRoot(int index)
		{
			return default(bool);
		}

		[Token(Token = "0x6000316")]
		[Address(RVA = "0x2CD2254", Offset = "0x2CD2254", VA = "0x2CD2254", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000317")]
		[Address(RVA = "0x2CD27BC", Offset = "0x2CD27BC", VA = "0x2CD27BC", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x6000318")]
		[Address(RVA = "0x2CD29BC", Offset = "0x2CD29BC", VA = "0x2CD29BC", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x6000319")]
		[Address(RVA = "0x2CD286C", Offset = "0x2CD286C", VA = "0x2CD286C")]
		private void AddPointsToArray(ref Point[] array, FABRIKChain chain)
		{
		}

		[Token(Token = "0x600031A")]
		[Address(RVA = "0x2CD2488", Offset = "0x2CD2488", VA = "0x2CD2488")]
		private Vector3 GetCentroid()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600031B")]
		[Address(RVA = "0x2CD2A54", Offset = "0x2CD2A54", VA = "0x2CD2A54")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1444750", Offset = "0x1444750")]
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
		[Address(RVA = "0x2CD2ABC", Offset = "0x2CD2ABC", VA = "0x2CD2ABC")]
		public IKEffector GetEffector(Transform t)
		{
			return null;
		}

		[Token(Token = "0x600031D")]
		[Address(RVA = "0x2CD2BB0", Offset = "0x2CD2BB0", VA = "0x2CD2BB0")]
		public FBIKChain GetChain(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x600031E")]
		[Address(RVA = "0x2CD2C0C", Offset = "0x2CD2C0C", VA = "0x2CD2C0C")]
		public int GetChainIndex(Transform transform)
		{
			return default(int);
		}

		[Token(Token = "0x600031F")]
		[Address(RVA = "0x2CD2D40", Offset = "0x2CD2D40", VA = "0x2CD2D40")]
		public Node GetNode(int chainIndex, int nodeIndex)
		{
			return null;
		}

		[Token(Token = "0x6000320")]
		[Address(RVA = "0x2CD2D9C", Offset = "0x2CD2D9C", VA = "0x2CD2D9C")]
		public void GetChainAndNodeIndexes(Transform transform, out int chainIndex, out int nodeIndex)
		{
		}

		[Token(Token = "0x6000321")]
		[Address(RVA = "0x2CD2E1C", Offset = "0x2CD2E1C", VA = "0x2CD2E1C", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x6000322")]
		[Address(RVA = "0x2CD2FC4", Offset = "0x2CD2FC4", VA = "0x2CD2FC4", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x6000323")]
		[Address(RVA = "0x2CD3138", Offset = "0x2CD3138", VA = "0x2CD3138", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000324")]
		[Address(RVA = "0x2CD333C", Offset = "0x2CD333C", VA = "0x2CD333C", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000325")]
		[Address(RVA = "0x2CD3410", Offset = "0x2CD3410", VA = "0x2CD3410", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x6000326")]
		[Address(RVA = "0x2CD34F8", Offset = "0x2CD34F8", VA = "0x2CD34F8", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000327")]
		[Address(RVA = "0x2CD366C", Offset = "0x2CD366C", VA = "0x2CD366C", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000328")]
		[Address(RVA = "0x2CD3828", Offset = "0x2CD3828", VA = "0x2CD3828", Slot = "12")]
		protected virtual void ReadPose()
		{
		}

		[Token(Token = "0x6000329")]
		[Address(RVA = "0x2CD3A74", Offset = "0x2CD3A74", VA = "0x2CD3A74", Slot = "13")]
		protected virtual void Solve()
		{
		}

		[Token(Token = "0x600032A")]
		[Address(RVA = "0x2CD3D4C", Offset = "0x2CD3D4C", VA = "0x2CD3D4C", Slot = "14")]
		protected virtual void ApplyBendConstraints()
		{
		}

		[Token(Token = "0x600032B")]
		[Address(RVA = "0x2CD3D90", Offset = "0x2CD3D90", VA = "0x2CD3D90", Slot = "15")]
		protected virtual void WritePose()
		{
		}

		[Token(Token = "0x600032C")]
		[Address(RVA = "0x2CD3E80", Offset = "0x2CD3E80", VA = "0x2CD3E80")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1444768", Offset = "0x1444768")]
		public float spineStiffness;

		[Token(Token = "0x40002C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1444780", Offset = "0x1444780")]
		public float pullBodyVertical;

		[Token(Token = "0x40002C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1444798", Offset = "0x1444798")]
		public float pullBodyHorizontal;

		[Token(Token = "0x40002C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x14447B0", Offset = "0x14447B0")]
		private Vector3 <pullBodyOffset>k__BackingField;

		[Token(Token = "0x40002C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private Vector3 offset;

		[Token(Token = "0x17000031")]
		public IKEffector bodyEffector
		{
			[Token(Token = "0x600032D")]
			[Address(RVA = "0x2CD3F58", Offset = "0x2CD3F58", VA = "0x2CD3F58")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000032")]
		public IKEffector leftShoulderEffector
		{
			[Token(Token = "0x600032E")]
			[Address(RVA = "0x2CD40A0", Offset = "0x2CD40A0", VA = "0x2CD40A0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000033")]
		public IKEffector rightShoulderEffector
		{
			[Token(Token = "0x600032F")]
			[Address(RVA = "0x2CD40A8", Offset = "0x2CD40A8", VA = "0x2CD40A8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000034")]
		public IKEffector leftThighEffector
		{
			[Token(Token = "0x6000330")]
			[Address(RVA = "0x2CD40B0", Offset = "0x2CD40B0", VA = "0x2CD40B0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000035")]
		public IKEffector rightThighEffector
		{
			[Token(Token = "0x6000331")]
			[Address(RVA = "0x2CD40B8", Offset = "0x2CD40B8", VA = "0x2CD40B8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000036")]
		public IKEffector leftHandEffector
		{
			[Token(Token = "0x6000332")]
			[Address(RVA = "0x2CD40C0", Offset = "0x2CD40C0", VA = "0x2CD40C0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000037")]
		public IKEffector rightHandEffector
		{
			[Token(Token = "0x6000333")]
			[Address(RVA = "0x2CD40C8", Offset = "0x2CD40C8", VA = "0x2CD40C8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000038")]
		public IKEffector leftFootEffector
		{
			[Token(Token = "0x6000334")]
			[Address(RVA = "0x2CD40D0", Offset = "0x2CD40D0", VA = "0x2CD40D0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000039")]
		public IKEffector rightFootEffector
		{
			[Token(Token = "0x6000335")]
			[Address(RVA = "0x2CD40D8", Offset = "0x2CD40D8", VA = "0x2CD40D8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700003A")]
		public FBIKChain leftArmChain
		{
			[Token(Token = "0x6000336")]
			[Address(RVA = "0x2CD40E0", Offset = "0x2CD40E0", VA = "0x2CD40E0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700003B")]
		public FBIKChain rightArmChain
		{
			[Token(Token = "0x6000337")]
			[Address(RVA = "0x2CD4118", Offset = "0x2CD4118", VA = "0x2CD4118")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700003C")]
		public FBIKChain leftLegChain
		{
			[Token(Token = "0x6000338")]
			[Address(RVA = "0x2CD4150", Offset = "0x2CD4150", VA = "0x2CD4150")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700003D")]
		public FBIKChain rightLegChain
		{
			[Token(Token = "0x6000339")]
			[Address(RVA = "0x2CD4188", Offset = "0x2CD4188", VA = "0x2CD4188")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700003E")]
		public IKMappingLimb leftArmMapping
		{
			[Token(Token = "0x600033A")]
			[Address(RVA = "0x2CD41C0", Offset = "0x2CD41C0", VA = "0x2CD41C0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700003F")]
		public IKMappingLimb rightArmMapping
		{
			[Token(Token = "0x600033B")]
			[Address(RVA = "0x2CD41F4", Offset = "0x2CD41F4", VA = "0x2CD41F4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000040")]
		public IKMappingLimb leftLegMapping
		{
			[Token(Token = "0x600033C")]
			[Address(RVA = "0x2CD422C", Offset = "0x2CD422C", VA = "0x2CD422C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000041")]
		public IKMappingLimb rightLegMapping
		{
			[Token(Token = "0x600033D")]
			[Address(RVA = "0x2CD4264", Offset = "0x2CD4264", VA = "0x2CD4264")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000042")]
		public IKMappingBone headMapping
		{
			[Token(Token = "0x600033E")]
			[Address(RVA = "0x2CD429C", Offset = "0x2CD429C", VA = "0x2CD429C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000043")]
		public Vector3 pullBodyOffset
		{
			[Token(Token = "0x600034E")]
			[Address(RVA = "0x2CD6260", Offset = "0x2CD6260", VA = "0x2CD6260")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x144AC00", Offset = "0x144AC00")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x600034F")]
			[Address(RVA = "0x2CD626C", Offset = "0x2CD626C", VA = "0x2CD626C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x144AC10", Offset = "0x144AC10")]
			private set
			{
			}
		}

		[Token(Token = "0x600033F")]
		[Address(RVA = "0x2CD42D0", Offset = "0x2CD42D0", VA = "0x2CD42D0")]
		public void SetChainWeights(FullBodyBipedChain c, float pull, float reach = 0f)
		{
		}

		[Token(Token = "0x6000340")]
		[Address(RVA = "0x2CD43DC", Offset = "0x2CD43DC", VA = "0x2CD43DC")]
		public void SetEffectorWeights(FullBodyBipedEffector effector, float positionWeight, float rotationWeight)
		{
		}

		[Token(Token = "0x6000341")]
		[Address(RVA = "0x2CD4324", Offset = "0x2CD4324", VA = "0x2CD4324")]
		public FBIKChain GetChain(FullBodyBipedChain c)
		{
			return null;
		}

		[Token(Token = "0x6000342")]
		[Address(RVA = "0x2CD44B8", Offset = "0x2CD44B8", VA = "0x2CD44B8")]
		public FBIKChain GetChain(FullBodyBipedEffector effector)
		{
			return null;
		}

		[Token(Token = "0x6000343")]
		[Address(RVA = "0x2CD3F60", Offset = "0x2CD3F60", VA = "0x2CD3F60")]
		public IKEffector GetEffector(FullBodyBipedEffector effector)
		{
			return null;
		}

		[Token(Token = "0x6000344")]
		[Address(RVA = "0x2CD4588", Offset = "0x2CD4588", VA = "0x2CD4588")]
		public IKEffector GetEndEffector(FullBodyBipedChain c)
		{
			return null;
		}

		[Token(Token = "0x6000345")]
		[Address(RVA = "0x2CD4640", Offset = "0x2CD4640", VA = "0x2CD4640")]
		public IKMappingLimb GetLimbMapping(FullBodyBipedChain chain)
		{
			return null;
		}

		[Token(Token = "0x6000346")]
		[Address(RVA = "0x2CD46F4", Offset = "0x2CD46F4", VA = "0x2CD46F4")]
		public IKMappingLimb GetLimbMapping(FullBodyBipedEffector effector)
		{
			return null;
		}

		[Token(Token = "0x6000347")]
		[Address(RVA = "0x2CD47A8", Offset = "0x2CD47A8", VA = "0x2CD47A8")]
		public IKMappingSpine GetSpineMapping()
		{
			return null;
		}

		[Token(Token = "0x6000348")]
		[Address(RVA = "0x2CD47B0", Offset = "0x2CD47B0", VA = "0x2CD47B0")]
		public IKMappingBone GetHeadMapping()
		{
			return null;
		}

		[Token(Token = "0x6000349")]
		[Address(RVA = "0x2CD47E4", Offset = "0x2CD47E4", VA = "0x2CD47E4")]
		public IKConstraintBend GetBendConstraint(FullBodyBipedChain limb)
		{
			return null;
		}

		[Token(Token = "0x600034A")]
		[Address(RVA = "0x2CD48AC", Offset = "0x2CD48AC", VA = "0x2CD48AC", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x600034B")]
		[Address(RVA = "0x2CD4A3C", Offset = "0x2CD4A3C", VA = "0x2CD4A3C")]
		public void SetToReferences(BipedReferences references, [Optional] Transform rootNode)
		{
		}

		[Token(Token = "0x600034C")]
		[Address(RVA = "0x2CD5B78", Offset = "0x2CD5B78", VA = "0x2CD5B78")]
		public static Transform DetectRootNodeBone(BipedReferences references)
		{
			return null;
		}

		[Token(Token = "0x600034D")]
		[Address(RVA = "0x2CD600C", Offset = "0x2CD600C", VA = "0x2CD600C")]
		public void SetLimbOrientations(BipedLimbOrientations o)
		{
		}

		[Token(Token = "0x6000350")]
		[Address(RVA = "0x2CD606C", Offset = "0x2CD606C", VA = "0x2CD606C")]
		private void SetLimbOrientation(FullBodyBipedChain chain, BipedLimbOrientations.LimbOrientation limbOrientation)
		{
		}

		[Token(Token = "0x6000351")]
		[Address(RVA = "0x2CD5E8C", Offset = "0x2CD5E8C", VA = "0x2CD5E8C")]
		private static Transform GetLeftClavicle(BipedReferences references)
		{
			return null;
		}

		[Token(Token = "0x6000352")]
		[Address(RVA = "0x2CD5F4C", Offset = "0x2CD5F4C", VA = "0x2CD5F4C")]
		private static Transform GetRightClavicle(BipedReferences references)
		{
			return null;
		}

		[Token(Token = "0x6000353")]
		[Address(RVA = "0x2CD6278", Offset = "0x2CD6278", VA = "0x2CD6278")]
		private static bool Contains(Transform[] array, Transform transform)
		{
			return default(bool);
		}

		[Token(Token = "0x6000354")]
		[Address(RVA = "0x2CD6354", Offset = "0x2CD6354", VA = "0x2CD6354", Slot = "12")]
		protected override void ReadPose()
		{
		}

		[Token(Token = "0x6000355")]
		[Address(RVA = "0x2CD649C", Offset = "0x2CD649C", VA = "0x2CD649C")]
		private void PullBody()
		{
		}

		[Token(Token = "0x6000356")]
		[Address(RVA = "0x2CD662C", Offset = "0x2CD662C", VA = "0x2CD662C")]
		private Vector3 GetBodyOffset()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000357")]
		[Address(RVA = "0x2CD682C", Offset = "0x2CD682C", VA = "0x2CD682C")]
		private Vector3 GetHandBodyPull(IKEffector effector, FBIKChain arm, Vector3 offset)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000358")]
		[Address(RVA = "0x2CD6A2C", Offset = "0x2CD6A2C", VA = "0x2CD6A2C", Slot = "14")]
		protected override void ApplyBendConstraints()
		{
		}

		[Token(Token = "0x6000359")]
		[Address(RVA = "0x2CD6D60", Offset = "0x2CD6D60", VA = "0x2CD6D60", Slot = "15")]
		protected override void WritePose()
		{
		}

		[Token(Token = "0x600035A")]
		[Address(RVA = "0x2CD6E60", Offset = "0x2CD6E60", VA = "0x2CD6E60")]
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
			[Address(RVA = "0x2CD76B0", Offset = "0x2CD76B0", VA = "0x2CD76B0", Slot = "12")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000045")]
		protected virtual bool boneLengthCanBeZero
		{
			[Token(Token = "0x6000363")]
			[Address(RVA = "0x2CD76B8", Offset = "0x2CD76B8", VA = "0x2CD76B8", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000046")]
		protected virtual bool allowCommonParent
		{
			[Token(Token = "0x6000364")]
			[Address(RVA = "0x2CD76C0", Offset = "0x2CD76C0", VA = "0x2CD76C0", Slot = "14")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000047")]
		protected virtual Vector3 localDirection
		{
			[Token(Token = "0x6000368")]
			[Address(RVA = "0x2CD76D0", Offset = "0x2CD76D0", VA = "0x2CD76D0", Slot = "15")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000048")]
		protected float positionOffset
		{
			[Token(Token = "0x6000369")]
			[Address(RVA = "0x2CCE630", Offset = "0x2CCE630", VA = "0x2CCE630")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x600035B")]
		[Address(RVA = "0x2CD6E6C", Offset = "0x2CD6E6C", VA = "0x2CD6E6C")]
		public bool SetChain(Transform[] hierarchy, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x600035C")]
		[Address(RVA = "0x2CD7000", Offset = "0x2CD7000", VA = "0x2CD7000")]
		public void AddBone(Transform bone)
		{
		}

		[Token(Token = "0x600035D")]
		[Address(RVA = "0x2CD713C", Offset = "0x2CD713C", VA = "0x2CD713C", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x600035E")]
		[Address(RVA = "0x2CD71A8", Offset = "0x2CD71A8", VA = "0x2CD71A8", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x600035F")]
		[Address(RVA = "0x2CD7228", Offset = "0x2CD7228", VA = "0x2CD7228", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000360")]
		[Address(RVA = "0x2CD75B4", Offset = "0x2CD75B4", VA = "0x2CD75B4", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x6000361")]
		[Address(RVA = "0x2CD75BC", Offset = "0x2CD75BC", VA = "0x2CD75BC", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x6000365")]
		[Address(RVA = "0x2CD76C8", Offset = "0x2CD76C8", VA = "0x2CD76C8", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000366")]
		[Address(RVA = "0x2CD76CC", Offset = "0x2CD76CC", VA = "0x2CD76CC", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000367")]
		[Address(RVA = "0x2CCDA14", Offset = "0x2CCDA14", VA = "0x2CCDA14")]
		protected void InitiateBones()
		{
		}

		[Token(Token = "0x600036A")]
		[Address(RVA = "0x2CCE28C", Offset = "0x2CCE28C", VA = "0x2CCE28C")]
		protected Vector3 GetSingularityOffset()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600036B")]
		[Address(RVA = "0x2CD7804", Offset = "0x2CD7804", VA = "0x2CD7804")]
		private bool SingularityDetected()
		{
			return default(bool);
		}

		[Token(Token = "0x600036C")]
		[Address(RVA = "0x2CCC9E4", Offset = "0x2CCC9E4", VA = "0x2CCC9E4")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x14447C0", Offset = "0x14447C0")]
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
		[Address(RVA = "0x2CD7AB8", Offset = "0x2CD7AB8", VA = "0x2CD7AB8", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x600036E")]
		[Address(RVA = "0x2CD7E2C", Offset = "0x2CD7E2C", VA = "0x2CD7E2C")]
		public bool SetChain(Transform pelvis, Transform thigh, Transform calf, Transform foot, Transform toe, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x600036F")]
		[Address(RVA = "0x2CD7E9C", Offset = "0x2CD7E9C", VA = "0x2CD7E9C", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x6000370")]
		[Address(RVA = "0x2CD7FF8", Offset = "0x2CD7FF8", VA = "0x2CD7FF8", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x6000371")]
		[Address(RVA = "0x2CD8190", Offset = "0x2CD8190", VA = "0x2CD8190", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000372")]
		[Address(RVA = "0x2CD81EC", Offset = "0x2CD81EC", VA = "0x2CD81EC", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x6000373")]
		[Address(RVA = "0x2CD825C", Offset = "0x2CD825C", VA = "0x2CD825C", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000374")]
		[Address(RVA = "0x2CD85CC", Offset = "0x2CD85CC", VA = "0x2CD85CC", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000375")]
		[Address(RVA = "0x2CD85F8", Offset = "0x2CD85F8", VA = "0x2CD85F8")]
		private void Solve()
		{
		}

		[Token(Token = "0x6000376")]
		[Address(RVA = "0x2CD82C0", Offset = "0x2CD82C0", VA = "0x2CD82C0")]
		private void Read()
		{
		}

		[Token(Token = "0x6000377")]
		[Address(RVA = "0x2CD8700", Offset = "0x2CD8700", VA = "0x2CD8700")]
		private void Write()
		{
		}

		[Token(Token = "0x6000378")]
		[Address(RVA = "0x2CD888C", Offset = "0x2CD888C", VA = "0x2CD888C")]
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
			[Address(RVA = "0x1580B5C", Offset = "0x1580B5C", VA = "0x1580B5C")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x14447D8", Offset = "0x14447D8")]
		public float maintainRotationWeight;

		[Token(Token = "0x40002DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x14447F0", Offset = "0x14447F0")]
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
			[Address(RVA = "0x2CDA0E8", Offset = "0x2CDA0E8", VA = "0x2CDA0E8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000379")]
		[Address(RVA = "0x2CD89E4", Offset = "0x2CD89E4", VA = "0x2CD89E4")]
		public void MaintainRotation()
		{
		}

		[Token(Token = "0x600037A")]
		[Address(RVA = "0x2CD8A34", Offset = "0x2CD8A34", VA = "0x2CD8A34")]
		public void MaintainBend()
		{
		}

		[Token(Token = "0x600037B")]
		[Address(RVA = "0x2CD8B48", Offset = "0x2CD8B48", VA = "0x2CD8B48", Slot = "12")]
		protected override void OnInitiateVirtual()
		{
		}

		[Token(Token = "0x600037C")]
		[Address(RVA = "0x2CD91B8", Offset = "0x2CD91B8", VA = "0x2CD91B8", Slot = "13")]
		protected override void OnUpdateVirtual()
		{
		}

		[Token(Token = "0x600037D")]
		[Address(RVA = "0x2CD9D94", Offset = "0x2CD9D94", VA = "0x2CD9D94", Slot = "14")]
		protected override void OnPostSolveVirtual()
		{
		}

		[Token(Token = "0x600037E")]
		[Address(RVA = "0x2CD9EDC", Offset = "0x2CD9EDC", VA = "0x2CD9EDC")]
		public IKSolverLimb()
		{
		}

		[Token(Token = "0x600037F")]
		[Address(RVA = "0x2CDA060", Offset = "0x2CDA060", VA = "0x2CDA060")]
		public IKSolverLimb(AvatarIKGoal goal)
		{
		}

		[Token(Token = "0x6000381")]
		[Address(RVA = "0x2CD8EC4", Offset = "0x2CD8EC4", VA = "0x2CD8EC4")]
		private void StoreAxisDirections(ref AxisDirection[] axisDirections)
		{
		}

		[Token(Token = "0x6000382")]
		[Address(RVA = "0x2CD92E4", Offset = "0x2CD92E4", VA = "0x2CD92E4")]
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
				[Address(RVA = "0x2CDC1A4", Offset = "0x2CDC1A4", VA = "0x2CDC1A4")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x6000C2C")]
			[Address(RVA = "0x2CDC8F0", Offset = "0x2CDC8F0", VA = "0x2CDC8F0")]
			public LookAtBone()
			{
			}

			[Token(Token = "0x6000C2D")]
			[Address(RVA = "0x2CDB340", Offset = "0x2CDB340", VA = "0x2CDB340")]
			public LookAtBone(Transform transform)
			{
			}

			[Token(Token = "0x6000C2E")]
			[Address(RVA = "0x2CDB67C", Offset = "0x2CDB67C", VA = "0x2CDB67C")]
			public void Initiate(Transform root)
			{
			}

			[Token(Token = "0x6000C2F")]
			[Address(RVA = "0x2CDC5A8", Offset = "0x2CDC5A8", VA = "0x2CDC5A8")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1444808", Offset = "0x1444808")]
		public float bodyWeight;

		[Token(Token = "0x40002F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1444820", Offset = "0x1444820")]
		public float headWeight;

		[Token(Token = "0x40002F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1444838", Offset = "0x1444838")]
		public float eyesWeight;

		[Token(Token = "0x40002F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1444850", Offset = "0x1444850")]
		public float clampWeight;

		[Token(Token = "0x40002F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1444868", Offset = "0x1444868")]
		public float clampWeightHead;

		[Token(Token = "0x40002F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1444880", Offset = "0x1444880")]
		public float clampWeightEyes;

		[Token(Token = "0x40002F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1444898", Offset = "0x1444898")]
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
			[Address(RVA = "0x2CDAAA4", Offset = "0x2CDAAA4", VA = "0x2CDAAA4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700004B")]
		protected bool spineIsEmpty
		{
			[Token(Token = "0x6000392")]
			[Address(RVA = "0x2CDAC7C", Offset = "0x2CDAC7C", VA = "0x2CDAC7C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700004C")]
		protected bool headIsValid
		{
			[Token(Token = "0x6000394")]
			[Address(RVA = "0x2CDAB88", Offset = "0x2CDAB88", VA = "0x2CDAB88")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700004D")]
		protected bool headIsEmpty
		{
			[Token(Token = "0x6000395")]
			[Address(RVA = "0x2CDACA0", Offset = "0x2CDACA0", VA = "0x2CDACA0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700004E")]
		protected bool eyesIsValid
		{
			[Token(Token = "0x6000397")]
			[Address(RVA = "0x2CDAB98", Offset = "0x2CDAB98", VA = "0x2CDAB98")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700004F")]
		protected bool eyesIsEmpty
		{
			[Token(Token = "0x6000398")]
			[Address(RVA = "0x2CDAD1C", Offset = "0x2CDAD1C", VA = "0x2CDAD1C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000383")]
		[Address(RVA = "0x2CDA164", Offset = "0x2CDA164", VA = "0x2CDA164")]
		public void SetLookAtWeight(float weight)
		{
		}

		[Token(Token = "0x6000384")]
		[Address(RVA = "0x2CDA1E8", Offset = "0x2CDA1E8", VA = "0x2CDA1E8")]
		public void SetLookAtWeight(float weight, float bodyWeight)
		{
		}

		[Token(Token = "0x6000385")]
		[Address(RVA = "0x2CDA294", Offset = "0x2CDA294", VA = "0x2CDA294")]
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight)
		{
		}

		[Token(Token = "0x6000386")]
		[Address(RVA = "0x2CDA35C", Offset = "0x2CDA35C", VA = "0x2CDA35C")]
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight)
		{
		}

		[Token(Token = "0x6000387")]
		[Address(RVA = "0x2CDA448", Offset = "0x2CDA448", VA = "0x2CDA448")]
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight, float clampWeight)
		{
		}

		[Token(Token = "0x6000388")]
		[Address(RVA = "0x2CDA554", Offset = "0x2CDA554", VA = "0x2CDA554")]
		public void SetLookAtWeight(float weight, float bodyWeight = 0f, float headWeight = 1f, float eyesWeight = 0.5f, float clampWeight = 0.5f, float clampWeightHead = 0.5f, float clampWeightEyes = 0.3f)
		{
		}

		[Token(Token = "0x6000389")]
		[Address(RVA = "0x2CDA69C", Offset = "0x2CDA69C", VA = "0x2CDA69C", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x600038A")]
		[Address(RVA = "0x2CDA7CC", Offset = "0x2CDA7CC", VA = "0x2CDA7CC", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x600038B")]
		[Address(RVA = "0x2CDA910", Offset = "0x2CDA910", VA = "0x2CDA910", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x600038C")]
		[Address(RVA = "0x2CDAD40", Offset = "0x2CDAD40", VA = "0x2CDAD40", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x600038D")]
		[Address(RVA = "0x2CDAF78", Offset = "0x2CDAF78", VA = "0x2CDAF78", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x600038E")]
		[Address(RVA = "0x2CDB118", Offset = "0x2CDB118", VA = "0x2CDB118")]
		public bool SetChain(Transform[] spine, Transform head, Transform[] eyes, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x600038F")]
		[Address(RVA = "0x2CDB36C", Offset = "0x2CDB36C", VA = "0x2CDB36C", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000390")]
		[Address(RVA = "0x2CDB7B8", Offset = "0x2CDB7B8", VA = "0x2CDB7B8", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000393")]
		[Address(RVA = "0x2CDB8BC", Offset = "0x2CDB8BC", VA = "0x2CDB8BC")]
		protected void SolveSpine()
		{
		}

		[Token(Token = "0x6000396")]
		[Address(RVA = "0x2CDBAE8", Offset = "0x2CDBAE8", VA = "0x2CDBAE8")]
		protected void SolveHead()
		{
		}

		[Token(Token = "0x6000399")]
		[Address(RVA = "0x2CDBD44", Offset = "0x2CDBD44", VA = "0x2CDBD44")]
		protected void SolveEyes()
		{
		}

		[Token(Token = "0x600039A")]
		[Address(RVA = "0x2CDC270", Offset = "0x2CDC270", VA = "0x2CDC270")]
		protected Vector3[] GetForwards(ref Vector3[] forwards, Vector3 baseForward, Vector3 targetForward, int bones, float clamp)
		{
			return null;
		}

		[Token(Token = "0x600039B")]
		[Address(RVA = "0x2CDB1C8", Offset = "0x2CDB1C8", VA = "0x2CDB1C8")]
		protected void SetBones(Transform[] array, ref LookAtBone[] bones)
		{
		}

		[Token(Token = "0x600039C")]
		[Address(RVA = "0x2CDC710", Offset = "0x2CDC710", VA = "0x2CDC710")]
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
			[Address(RVA = "0x2CDDEC8", Offset = "0x2CDDEC8", VA = "0x2CDDEC8")]
			public void Initiate(Vector3 childPosition, Vector3 bendNormal)
			{
			}

			[Token(Token = "0x6000C32")]
			[Address(RVA = "0x2CDEA80", Offset = "0x2CDEA80", VA = "0x2CDEA80")]
			public Quaternion GetRotation(Vector3 direction, Vector3 bendNormal)
			{
				return default(Quaternion);
			}

			[Token(Token = "0x6000C33")]
			[Address(RVA = "0x2CD8A7C", Offset = "0x2CD8A7C", VA = "0x2CD8A7C")]
			public Vector3 GetBendNormalFromCurrentRotation()
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000C34")]
			[Address(RVA = "0x2CDEB48", Offset = "0x2CDEB48", VA = "0x2CDEB48")]
			public TrigonometricBone()
			{
			}
		}

		[Token(Token = "0x40002FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform target;

		[Token(Token = "0x40002FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x14448B0", Offset = "0x14448B0")]
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
		[Address(RVA = "0x2CDC8F8", Offset = "0x2CDC8F8", VA = "0x2CDC8F8")]
		public void SetBendGoalPosition(Vector3 goalPosition, float weight)
		{
		}

		[Token(Token = "0x600039E")]
		[Address(RVA = "0x2CDCAE8", Offset = "0x2CDCAE8", VA = "0x2CDCAE8")]
		public void SetBendPlaneToCurrent()
		{
		}

		[Token(Token = "0x600039F")]
		[Address(RVA = "0x2CDCC9C", Offset = "0x2CDCC9C", VA = "0x2CDCC9C")]
		public void SetIKRotation(Quaternion rotation)
		{
		}

		[Token(Token = "0x60003A0")]
		[Address(RVA = "0x2CDCCA8", Offset = "0x2CDCCA8", VA = "0x2CDCCA8")]
		public void SetIKRotationWeight(float weight)
		{
		}

		[Token(Token = "0x60003A1")]
		[Address(RVA = "0x2CDCD2C", Offset = "0x2CDCD2C", VA = "0x2CDCD2C")]
		public Quaternion GetIKRotation()
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60003A2")]
		[Address(RVA = "0x2CDCD38", Offset = "0x2CDCD38", VA = "0x2CDCD38")]
		public float GetIKRotationWeight()
		{
			return default(float);
		}

		[Token(Token = "0x60003A3")]
		[Address(RVA = "0x2CDCD40", Offset = "0x2CDCD40", VA = "0x2CDCD40", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x60003A4")]
		[Address(RVA = "0x2CDCE44", Offset = "0x2CDCE44", VA = "0x2CDCE44", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x60003A5")]
		[Address(RVA = "0x2CDCF64", Offset = "0x2CDCF64", VA = "0x2CDCF64", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60003A6")]
		[Address(RVA = "0x2CDCFB0", Offset = "0x2CDCFB0", VA = "0x2CDCFB0", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x60003A7")]
		[Address(RVA = "0x2CDD010", Offset = "0x2CDD010", VA = "0x2CDD010", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60003A8")]
		[Address(RVA = "0x2CDD3EC", Offset = "0x2CDD3EC", VA = "0x2CDD3EC")]
		public bool SetChain(Transform bone1, Transform bone2, Transform bone3, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x60003A9")]
		[Address(RVA = "0x2CDD444", Offset = "0x2CDD444", VA = "0x2CDD444")]
		public static void Solve(Transform bone1, Transform bone2, Transform bone3, Vector3 targetPosition, Vector3 bendNormal, float weight)
		{
		}

		[Token(Token = "0x60003AA")]
		[Address(RVA = "0x2CDD9EC", Offset = "0x2CDD9EC", VA = "0x2CDD9EC")]
		private static Vector3 GetDirectionToBendPoint(Vector3 direction, float directionMag, Vector3 bendDirection, float sqrMag1, float sqrMag2)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003AB")]
		[Address(RVA = "0x2CDDC04", Offset = "0x2CDDC04", VA = "0x2CDDC04", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x60003AC")]
		[Address(RVA = "0x2CDDDC0", Offset = "0x2CDDDC0", VA = "0x2CDDDC0")]
		private bool IsDirectHierarchy()
		{
			return default(bool);
		}

		[Token(Token = "0x60003AD")]
		[Address(RVA = "0x2CDDD3C", Offset = "0x2CDDD3C", VA = "0x2CDDD3C")]
		private void InitiateBones()
		{
		}

		[Token(Token = "0x60003AE")]
		[Address(RVA = "0x2CDE068", Offset = "0x2CDE068", VA = "0x2CDE068", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x60003AF")]
		[Address(RVA = "0x2CDEB3C", Offset = "0x2CDEB3C", VA = "0x2CDEB3C", Slot = "12")]
		protected virtual void OnInitiateVirtual()
		{
		}

		[Token(Token = "0x60003B0")]
		[Address(RVA = "0x2CDEB40", Offset = "0x2CDEB40", VA = "0x2CDEB40", Slot = "13")]
		protected virtual void OnUpdateVirtual()
		{
		}

		[Token(Token = "0x60003B1")]
		[Address(RVA = "0x2CDEB44", Offset = "0x2CDEB44", VA = "0x2CDEB44", Slot = "14")]
		protected virtual void OnPostSolveVirtual()
		{
		}

		[Token(Token = "0x60003B2")]
		[Address(RVA = "0x2CDE774", Offset = "0x2CDE774", VA = "0x2CDE774")]
		protected Vector3 GetBendDirection(Vector3 IKPosition, Vector3 bendNormal)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003B3")]
		[Address(RVA = "0x2CD9F50", Offset = "0x2CD9F50", VA = "0x2CD9F50")]
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
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1446A24", Offset = "0x1446A24")]
			public Transform target;

			[Token(Token = "0x4000A1C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1446A5C", Offset = "0x1446A5C")]
			public Transform bendGoal;

			[Token(Token = "0x4000A1D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1446A94", Offset = "0x1446A94")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1446A94", Offset = "0x1446A94")]
			public float positionWeight;

			[Token(Token = "0x4000A1E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1446AE8", Offset = "0x1446AE8")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1446AE8", Offset = "0x1446AE8")]
			public float rotationWeight;

			[Token(Token = "0x4000A1F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1446B3C", Offset = "0x1446B3C")]
			public ShoulderRotationMode shoulderRotationMode;

			[Token(Token = "0x4000A20")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1446B74", Offset = "0x1446B74")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1446B74", Offset = "0x1446B74")]
			public float shoulderRotationWeight;

			[Token(Token = "0x4000A21")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1446BC8", Offset = "0x1446BC8")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1446BC8", Offset = "0x1446BC8")]
			public float shoulderTwistWeight;

			[Token(Token = "0x4000A22")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1446C1C", Offset = "0x1446C1C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1446C1C", Offset = "0x1446C1C")]
			public float bendGoalWeight;

			[Token(Token = "0x4000A23")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1446C70", Offset = "0x1446C70")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1446C70", Offset = "0x1446C70")]
			public float swivelOffset;

			[Token(Token = "0x4000A24")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1446CCC", Offset = "0x1446CCC")]
			public Vector3 wristToPalmAxis;

			[Token(Token = "0x4000A25")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1446D04", Offset = "0x1446D04")]
			public Vector3 palmToThumbAxis;

			[Token(Token = "0x4000A26")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1446D3C", Offset = "0x1446D3C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1446D3C", Offset = "0x1446D3C")]
			public float armLengthMlp;

			[Token(Token = "0x4000A27")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1446D94", Offset = "0x1446D94")]
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
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1446E0C", Offset = "0x1446E0C")]
			private Vector3 <position>k__BackingField;

			[Token(Token = "0x4000A2D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1446E1C", Offset = "0x1446E1C")]
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
				[Address(RVA = "0x2FDD2A4", Offset = "0x2FDD2A4", VA = "0x2FDD2A4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x144BB78", Offset = "0x144BB78")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000C36")]
				[Address(RVA = "0x2FDD2B0", Offset = "0x2FDD2B0", VA = "0x2FDD2B0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x144BB88", Offset = "0x144BB88")]
				private set
				{
				}
			}

			[Token(Token = "0x17000093")]
			public Quaternion rotation
			{
				[Token(Token = "0x6000C37")]
				[Address(RVA = "0x2FDD2BC", Offset = "0x2FDD2BC", VA = "0x2FDD2BC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x144BB98", Offset = "0x144BB98")]
				get
				{
					return default(Quaternion);
				}
				[Token(Token = "0x6000C38")]
				[Address(RVA = "0x2FDD2C8", Offset = "0x2FDD2C8", VA = "0x2FDD2C8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x144BBA8", Offset = "0x144BBA8")]
				private set
				{
				}
			}

			[Token(Token = "0x17000094")]
			private VirtualBone shoulder
			{
				[Token(Token = "0x6000C39")]
				[Address(RVA = "0x2FDD2D4", Offset = "0x2FDD2D4", VA = "0x2FDD2D4")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000095")]
			private VirtualBone upperArm
			{
				[Token(Token = "0x6000C3A")]
				[Address(RVA = "0x2FDD308", Offset = "0x2FDD308", VA = "0x2FDD308")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000096")]
			private VirtualBone forearm
			{
				[Token(Token = "0x6000C3B")]
				[Address(RVA = "0x2FDD348", Offset = "0x2FDD348", VA = "0x2FDD348")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000097")]
			private VirtualBone hand
			{
				[Token(Token = "0x6000C3C")]
				[Address(RVA = "0x2FDD394", Offset = "0x2FDD394", VA = "0x2FDD394")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000C3D")]
			[Address(RVA = "0x2FDD3E0", Offset = "0x2FDD3E0", VA = "0x2FDD3E0", Slot = "4")]
			protected override void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index)
			{
			}

			[Token(Token = "0x6000C3E")]
			[Address(RVA = "0x2FDDD90", Offset = "0x2FDDD90", VA = "0x2FDDD90", Slot = "5")]
			public override void PreSolve()
			{
			}

			[Token(Token = "0x6000C3F")]
			[Address(RVA = "0x2FDDF84", Offset = "0x2FDDF84", VA = "0x2FDDF84", Slot = "7")]
			public override void ApplyOffsets()
			{
			}

			[Token(Token = "0x6000C40")]
			[Address(RVA = "0x2FDE030", Offset = "0x2FDE030", VA = "0x2FDE030")]
			private void Stretching()
			{
			}

			[Token(Token = "0x6000C41")]
			[Address(RVA = "0x2FDE448", Offset = "0x2FDE448", VA = "0x2FDE448")]
			public void Solve(bool isLeft)
			{
			}

			[Token(Token = "0x6000C42")]
			[Address(RVA = "0x2FE09AC", Offset = "0x2FE09AC", VA = "0x2FE09AC", Slot = "8")]
			public override void ResetOffsets()
			{
			}

			[Token(Token = "0x6000C43")]
			[Address(RVA = "0x2FE0A1C", Offset = "0x2FE0A1C", VA = "0x2FE0A1C", Slot = "6")]
			public override void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations)
			{
			}

			[Token(Token = "0x6000C44")]
			[Address(RVA = "0x2FDF99C", Offset = "0x2FDF99C", VA = "0x2FDF99C")]
			private float DamperValue(float value, float min, float max, float weight = 1f)
			{
				return default(float);
			}

			[Token(Token = "0x6000C45")]
			[Address(RVA = "0x2FDFCA8", Offset = "0x2FDFCA8", VA = "0x2FDFCA8")]
			private Vector3 GetBendNormal(Vector3 dir)
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000C46")]
			[Address(RVA = "0x2FE0C3C", Offset = "0x2FE0C3C", VA = "0x2FE0C3C")]
			private void Visualize(VirtualBone bone1, VirtualBone bone2, VirtualBone bone3, Color color)
			{
			}

			[Token(Token = "0x6000C47")]
			[Address(RVA = "0x2FE0D64", Offset = "0x2FE0D64", VA = "0x2FE0D64")]
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
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1446E2C", Offset = "0x1446E2C")]
			private float <sqrMag>k__BackingField;

			[Token(Token = "0x4000A39")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1446E3C", Offset = "0x1446E3C")]
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
				[Address(RVA = "0x2FE0F24", Offset = "0x2FE0F24", VA = "0x2FE0F24")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x144BBB8", Offset = "0x144BBB8")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000C4E")]
				[Address(RVA = "0x2FE0F2C", Offset = "0x2FE0F2C", VA = "0x2FE0F2C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x144BBC8", Offset = "0x144BBC8")]
				private set
				{
				}
			}

			[Token(Token = "0x17000099")]
			public float mag
			{
				[Token(Token = "0x6000C4F")]
				[Address(RVA = "0x2FE0F34", Offset = "0x2FE0F34", VA = "0x2FE0F34")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x144BBD8", Offset = "0x144BBD8")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000C50")]
				[Address(RVA = "0x2FE0F3C", Offset = "0x2FE0F3C", VA = "0x2FE0F3C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x144BBE8", Offset = "0x144BBE8")]
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
			[Address(RVA = "0x2FE0F44", Offset = "0x2FE0F44", VA = "0x2FE0F44")]
			public void SetLOD(int LOD)
			{
			}

			[Token(Token = "0x6000C52")]
			[Address(RVA = "0x2FE0F4C", Offset = "0x2FE0F4C", VA = "0x2FE0F4C")]
			public void Read(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index)
			{
			}

			[Token(Token = "0x6000C53")]
			[Address(RVA = "0x2FE1308", Offset = "0x2FE1308", VA = "0x2FE1308")]
			public void MovePosition(Vector3 position)
			{
			}

			[Token(Token = "0x6000C54")]
			[Address(RVA = "0x2FE1474", Offset = "0x2FE1474", VA = "0x2FE1474")]
			public void MoveRotation(Quaternion rotation)
			{
			}

			[Token(Token = "0x6000C55")]
			[Address(RVA = "0x2FE1704", Offset = "0x2FE1704", VA = "0x2FE1704")]
			public void Translate(Vector3 position, Quaternion rotation)
			{
			}

			[Token(Token = "0x6000C56")]
			[Address(RVA = "0x2FE1758", Offset = "0x2FE1758", VA = "0x2FE1758")]
			public void TranslateRoot(Vector3 newRootPos, Quaternion newRootRot)
			{
			}

			[Token(Token = "0x6000C57")]
			[Address(RVA = "0x2FE080C", Offset = "0x2FE080C", VA = "0x2FE080C")]
			public void RotateTo(VirtualBone bone, Quaternion rotation, float weight = 1f)
			{
			}

			[Token(Token = "0x6000C58")]
			[Address(RVA = "0x2FE1944", Offset = "0x2FE1944", VA = "0x2FE1944")]
			public void Visualize(Color color)
			{
			}

			[Token(Token = "0x6000C59")]
			[Address(RVA = "0x2FE1A88", Offset = "0x2FE1A88", VA = "0x2FE1A88")]
			public void Visualize()
			{
			}

			[Token(Token = "0x6000C5A")]
			[Address(RVA = "0x2FE0E8C", Offset = "0x2FE0E8C", VA = "0x2FE0E8C")]
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
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1446E5C", Offset = "0x1446E5C")]
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
				[Address(RVA = "0x2FE1AB0", Offset = "0x2FE1AB0", VA = "0x2FE1AB0")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x1700009B")]
			public float stepProgress
			{
				[Token(Token = "0x6000C5C")]
				[Address(RVA = "0x2FE1AC4", Offset = "0x2FE1AC4", VA = "0x2FE1AC4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x144BBF8", Offset = "0x144BBF8")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000C5D")]
				[Address(RVA = "0x2FE1ACC", Offset = "0x2FE1ACC", VA = "0x2FE1ACC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x144BC08", Offset = "0x144BC08")]
				private set
				{
				}
			}

			[Token(Token = "0x6000C5E")]
			[Address(RVA = "0x2FE1AD4", Offset = "0x2FE1AD4", VA = "0x2FE1AD4")]
			public Footstep(Quaternion rootRotation, Vector3 footPosition, Quaternion footRotation, Vector3 characterSpaceOffset)
			{
			}

			[Token(Token = "0x6000C5F")]
			[Address(RVA = "0x2FE1C64", Offset = "0x2FE1C64", VA = "0x2FE1C64")]
			public void Reset(Quaternion rootRotation, Vector3 footPosition, Quaternion footRotation)
			{
			}

			[Token(Token = "0x6000C60")]
			[Address(RVA = "0x2FE1CAC", Offset = "0x2FE1CAC", VA = "0x2FE1CAC")]
			public void StepTo(Vector3 p, Quaternion rootRotation, float stepThreshold)
			{
			}

			[Token(Token = "0x6000C61")]
			[Address(RVA = "0x2FE1E6C", Offset = "0x2FE1E6C", VA = "0x2FE1E6C")]
			public void UpdateStepping(Vector3 p, Quaternion rootRotation, float speed)
			{
			}

			[Token(Token = "0x6000C62")]
			[Address(RVA = "0x2FE2044", Offset = "0x2FE2044", VA = "0x2FE2044")]
			public void UpdateStanding(Quaternion rootRotation, float minAngle, float speed)
			{
			}

			[Token(Token = "0x6000C63")]
			[Address(RVA = "0x2FE2230", Offset = "0x2FE2230", VA = "0x2FE2230")]
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
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1446E6C", Offset = "0x1446E6C")]
			public Transform target;

			[Token(Token = "0x4000A4F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1446EA4", Offset = "0x1446EA4")]
			public Transform bendGoal;

			[Token(Token = "0x4000A50")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1446EDC", Offset = "0x1446EDC")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1446EDC", Offset = "0x1446EDC")]
			public float positionWeight;

			[Token(Token = "0x4000A51")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1446F30", Offset = "0x1446F30")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1446F30", Offset = "0x1446F30")]
			public float rotationWeight;

			[Token(Token = "0x4000A52")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1446F84", Offset = "0x1446F84")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1446F84", Offset = "0x1446F84")]
			public float bendGoalWeight;

			[Token(Token = "0x4000A53")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1446FD8", Offset = "0x1446FD8")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1446FD8", Offset = "0x1446FD8")]
			public float swivelOffset;

			[Token(Token = "0x4000A54")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1447034", Offset = "0x1447034")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1447034", Offset = "0x1447034")]
			public float bendToTargetWeight;

			[Token(Token = "0x4000A55")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1447088", Offset = "0x1447088")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1447088", Offset = "0x1447088")]
			public float legLengthMlp;

			[Token(Token = "0x4000A56")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14470E0", Offset = "0x14470E0")]
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
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1447188", Offset = "0x1447188")]
			private Vector3 <position>k__BackingField;

			[Token(Token = "0x4000A5F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1447198", Offset = "0x1447198")]
			private Quaternion <rotation>k__BackingField;

			[Token(Token = "0x4000A60")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x14471A8", Offset = "0x14471A8")]
			private bool <hasToes>k__BackingField;

			[Token(Token = "0x4000A61")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x14471B8", Offset = "0x14471B8")]
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
				[Address(RVA = "0x2FE244C", Offset = "0x2FE244C", VA = "0x2FE244C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x144BC18", Offset = "0x144BC18")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000C65")]
				[Address(RVA = "0x2FE2458", Offset = "0x2FE2458", VA = "0x2FE2458")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x144BC28", Offset = "0x144BC28")]
				private set
				{
				}
			}

			[Token(Token = "0x1700009D")]
			public Quaternion rotation
			{
				[Token(Token = "0x6000C66")]
				[Address(RVA = "0x2FE2464", Offset = "0x2FE2464", VA = "0x2FE2464")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x144BC38", Offset = "0x144BC38")]
				get
				{
					return default(Quaternion);
				}
				[Token(Token = "0x6000C67")]
				[Address(RVA = "0x2FE2470", Offset = "0x2FE2470", VA = "0x2FE2470")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x144BC48", Offset = "0x144BC48")]
				private set
				{
				}
			}

			[Token(Token = "0x1700009E")]
			public bool hasToes
			{
				[Token(Token = "0x6000C68")]
				[Address(RVA = "0x2FE247C", Offset = "0x2FE247C", VA = "0x2FE247C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x144BC58", Offset = "0x144BC58")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6000C69")]
				[Address(RVA = "0x2FE2484", Offset = "0x2FE2484", VA = "0x2FE2484")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x144BC68", Offset = "0x144BC68")]
				private set
				{
				}
			}

			[Token(Token = "0x1700009F")]
			public VirtualBone thigh
			{
				[Token(Token = "0x6000C6A")]
				[Address(RVA = "0x2FE2490", Offset = "0x2FE2490", VA = "0x2FE2490")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000A0")]
			private VirtualBone calf
			{
				[Token(Token = "0x6000C6B")]
				[Address(RVA = "0x2FE24C4", Offset = "0x2FE24C4", VA = "0x2FE24C4")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000A1")]
			private VirtualBone foot
			{
				[Token(Token = "0x6000C6C")]
				[Address(RVA = "0x2FE24FC", Offset = "0x2FE24FC", VA = "0x2FE24FC")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000A2")]
			private VirtualBone toes
			{
				[Token(Token = "0x6000C6D")]
				[Address(RVA = "0x2FE2534", Offset = "0x2FE2534", VA = "0x2FE2534")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000A3")]
			public VirtualBone lastBone
			{
				[Token(Token = "0x6000C6E")]
				[Address(RVA = "0x2FE256C", Offset = "0x2FE256C", VA = "0x2FE256C")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000A4")]
			public Vector3 thighRelativeToPelvis
			{
				[Token(Token = "0x6000C6F")]
				[Address(RVA = "0x2FE25AC", Offset = "0x2FE25AC", VA = "0x2FE25AC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x144BC78", Offset = "0x144BC78")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000C70")]
				[Address(RVA = "0x2FE25B8", Offset = "0x2FE25B8", VA = "0x2FE25B8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x144BC88", Offset = "0x144BC88")]
				private set
				{
				}
			}

			[Token(Token = "0x6000C71")]
			[Address(RVA = "0x2FE25C4", Offset = "0x2FE25C4", VA = "0x2FE25C4", Slot = "4")]
			protected override void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index)
			{
			}

			[Token(Token = "0x6000C72")]
			[Address(RVA = "0x2FE2BE0", Offset = "0x2FE2BE0", VA = "0x2FE2BE0", Slot = "5")]
			public override void PreSolve()
			{
			}

			[Token(Token = "0x6000C73")]
			[Address(RVA = "0x2FE34C8", Offset = "0x2FE34C8", VA = "0x2FE34C8", Slot = "7")]
			public override void ApplyOffsets()
			{
			}

			[Token(Token = "0x6000C74")]
			[Address(RVA = "0x2FE33C4", Offset = "0x2FE33C4", VA = "0x2FE33C4")]
			private void ApplyPositionOffset(Vector3 offset, float weight)
			{
			}

			[Token(Token = "0x6000C75")]
			[Address(RVA = "0x2FE318C", Offset = "0x2FE318C", VA = "0x2FE318C")]
			private void ApplyRotationOffset(Quaternion offset, float weight)
			{
			}

			[Token(Token = "0x6000C76")]
			[Address(RVA = "0x2FE3A80", Offset = "0x2FE3A80", VA = "0x2FE3A80")]
			public void Solve(bool stretch)
			{
			}

			[Token(Token = "0x6000C77")]
			[Address(RVA = "0x2FE41CC", Offset = "0x2FE41CC", VA = "0x2FE41CC")]
			private void FixTwistRotations()
			{
			}

			[Token(Token = "0x6000C78")]
			[Address(RVA = "0x2FE3CA0", Offset = "0x2FE3CA0", VA = "0x2FE3CA0")]
			private void Stretching()
			{
			}

			[Token(Token = "0x6000C79")]
			[Address(RVA = "0x2FE4634", Offset = "0x2FE4634", VA = "0x2FE4634", Slot = "6")]
			public override void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations)
			{
			}

			[Token(Token = "0x6000C7A")]
			[Address(RVA = "0x2FE4850", Offset = "0x2FE4850", VA = "0x2FE4850", Slot = "8")]
			public override void ResetOffsets()
			{
			}

			[Token(Token = "0x6000C7B")]
			[Address(RVA = "0x2FE4900", Offset = "0x2FE4900", VA = "0x2FE4900")]
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
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14471C8", Offset = "0x14471C8")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x14471C8", Offset = "0x14471C8")]
			public float weight;

			[Token(Token = "0x4000A6A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x144721C", Offset = "0x144721C")]
			public float footDistance;

			[Token(Token = "0x4000A6B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1447254", Offset = "0x1447254")]
			public float stepThreshold;

			[Token(Token = "0x4000A6C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x144728C", Offset = "0x144728C")]
			public float angleThreshold;

			[Token(Token = "0x4000A6D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14472C4", Offset = "0x14472C4")]
			public float comAngleMlp;

			[Token(Token = "0x4000A6E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14472FC", Offset = "0x14472FC")]
			public float maxVelocity;

			[Token(Token = "0x4000A6F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1447334", Offset = "0x1447334")]
			public float velocityFactor;

			[Token(Token = "0x4000A70")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x144736C", Offset = "0x144736C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x144736C", Offset = "0x144736C")]
			public float maxLegStretch;

			[Token(Token = "0x4000A71")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14473C4", Offset = "0x14473C4")]
			public float rootSpeed;

			[Token(Token = "0x4000A72")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14473FC", Offset = "0x14473FC")]
			public float stepSpeed;

			[Token(Token = "0x4000A73")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1447434", Offset = "0x1447434")]
			public AnimationCurve stepHeight;

			[Token(Token = "0x4000A74")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x144746C", Offset = "0x144746C")]
			public AnimationCurve heelHeight;

			[Token(Token = "0x4000A75")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14474A4", Offset = "0x14474A4")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x14474A4", Offset = "0x14474A4")]
			public float relaxLegTwistMinAngle;

			[Token(Token = "0x4000A76")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14474FC", Offset = "0x14474FC")]
			public float relaxLegTwistSpeed;

			[Token(Token = "0x4000A77")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1447534", Offset = "0x1447534")]
			public InterpolationMode stepInterpolation;

			[Token(Token = "0x4000A78")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x144756C", Offset = "0x144756C")]
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
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14475E4", Offset = "0x14475E4")]
			public UnityEvent onLeftFootstep;

			[Token(Token = "0x4000A7E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x144761C", Offset = "0x144761C")]
			public UnityEvent onRightFootstep;

			[Token(Token = "0x4000A7F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1447654", Offset = "0x1447654")]
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
				[Address(RVA = "0x2FE49F4", Offset = "0x2FE49F4", VA = "0x2FE49F4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x144BC98", Offset = "0x144BC98")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000C7D")]
				[Address(RVA = "0x2FE4A00", Offset = "0x2FE4A00", VA = "0x2FE4A00")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x144BCA8", Offset = "0x144BCA8")]
				private set
				{
				}
			}

			[Token(Token = "0x170000A6")]
			public Vector3 leftFootstepPosition
			{
				[Token(Token = "0x6000C83")]
				[Address(RVA = "0x2FE6EDC", Offset = "0x2FE6EDC", VA = "0x2FE6EDC")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x170000A7")]
			public Vector3 rightFootstepPosition
			{
				[Token(Token = "0x6000C84")]
				[Address(RVA = "0x2FE6F1C", Offset = "0x2FE6F1C", VA = "0x2FE6F1C")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x170000A8")]
			public Quaternion leftFootstepRotation
			{
				[Token(Token = "0x6000C85")]
				[Address(RVA = "0x2FE6F60", Offset = "0x2FE6F60", VA = "0x2FE6F60")]
				get
				{
					return default(Quaternion);
				}
			}

			[Token(Token = "0x170000A9")]
			public Quaternion rightFootstepRotation
			{
				[Token(Token = "0x6000C86")]
				[Address(RVA = "0x2FE6FA0", Offset = "0x2FE6FA0", VA = "0x2FE6FA0")]
				get
				{
					return default(Quaternion);
				}
			}

			[Token(Token = "0x6000C7E")]
			[Address(RVA = "0x2FE4A0C", Offset = "0x2FE4A0C", VA = "0x2FE4A0C")]
			public void Initiate(Vector3[] positions, Quaternion[] rotations, bool hasToes)
			{
			}

			[Token(Token = "0x6000C7F")]
			[Address(RVA = "0x2FE4D04", Offset = "0x2FE4D04", VA = "0x2FE4D04")]
			public void Reset(Vector3[] positions, Quaternion[] rotations)
			{
			}

			[Token(Token = "0x6000C80")]
			[Address(RVA = "0x2FE4F78", Offset = "0x2FE4F78", VA = "0x2FE4F78")]
			public void AddDeltaRotation(Quaternion delta, Vector3 pivot)
			{
			}

			[Token(Token = "0x6000C81")]
			[Address(RVA = "0x2FE5350", Offset = "0x2FE5350", VA = "0x2FE5350")]
			public void AddDeltaPosition(Vector3 delta)
			{
			}

			[Token(Token = "0x6000C82")]
			[Address(RVA = "0x2FE5500", Offset = "0x2FE5500", VA = "0x2FE5500")]
			public void Solve(VirtualBone rootBone, Spine spine, Leg leftLeg, Leg rightLeg, Arm leftArm, Arm rightArm, int supportLegIndex, out Vector3 leftFootPosition, out Vector3 rightFootPosition, out Quaternion leftFootRotation, out Quaternion rightFootRotation, out float leftFootOffset, out float rightFootOffset, out float leftHeelOffset, out float rightHeelOffset)
			{
			}

			[Token(Token = "0x6000C87")]
			[Address(RVA = "0x2FE6AE8", Offset = "0x2FE6AE8", VA = "0x2FE6AE8")]
			private bool StepBlocked(Vector3 fromPosition, Vector3 toPosition, Vector3 rootPosition)
			{
				return default(bool);
			}

			[Token(Token = "0x6000C88")]
			[Address(RVA = "0x2FE6C8C", Offset = "0x2FE6C8C", VA = "0x2FE6C8C")]
			private bool CanStep()
			{
				return default(bool);
			}

			[Token(Token = "0x6000C89")]
			[Address(RVA = "0x2FE6D10", Offset = "0x2FE6D10", VA = "0x2FE6D10")]
			private static bool GetLineSphereCollision(Vector3 lineStart, Vector3 lineEnd, Vector3 sphereCenter, float sphereRadius)
			{
				return default(bool);
			}

			[Token(Token = "0x6000C8A")]
			[Address(RVA = "0x2FE6FE4", Offset = "0x2FE6FE4", VA = "0x2FE6FE4")]
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
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1447664", Offset = "0x1447664")]
			public Transform headTarget;

			[Token(Token = "0x4000A86")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x144769C", Offset = "0x144769C")]
			public Transform pelvisTarget;

			[Token(Token = "0x4000A87")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14476D4", Offset = "0x14476D4")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x14476D4", Offset = "0x14476D4")]
			public float positionWeight;

			[Token(Token = "0x4000A88")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1447728", Offset = "0x1447728")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1447728", Offset = "0x1447728")]
			public float rotationWeight;

			[Token(Token = "0x4000A89")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x144777C", Offset = "0x144777C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x144777C", Offset = "0x144777C")]
			public float pelvisPositionWeight;

			[Token(Token = "0x4000A8A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14477D0", Offset = "0x14477D0")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x14477D0", Offset = "0x14477D0")]
			public float pelvisRotationWeight;

			[Token(Token = "0x4000A8B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1447824", Offset = "0x1447824")]
			public Transform chestGoal;

			[Token(Token = "0x4000A8C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x144785C", Offset = "0x144785C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x144785C", Offset = "0x144785C")]
			public float chestGoalWeight;

			[Token(Token = "0x4000A8D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14478B0", Offset = "0x14478B0")]
			public float minHeadHeight;

			[Token(Token = "0x4000A8E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14478E8", Offset = "0x14478E8")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x14478E8", Offset = "0x14478E8")]
			public float bodyPosStiffness;

			[Token(Token = "0x4000A8F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x144793C", Offset = "0x144793C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x144793C", Offset = "0x144793C")]
			public float bodyRotStiffness;

			[Token(Token = "0x4000A90")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1447990", Offset = "0x1447990")]
			[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x1447990", Offset = "0x1447990")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1447990", Offset = "0x1447990")]
			public float neckStiffness;

			[Token(Token = "0x4000A91")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1447A08", Offset = "0x1447A08")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1447A08", Offset = "0x1447A08")]
			public float rotateChestByHands;

			[Token(Token = "0x4000A92")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1447A5C", Offset = "0x1447A5C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1447A5C", Offset = "0x1447A5C")]
			public float chestClampWeight;

			[Token(Token = "0x4000A93")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1447AB0", Offset = "0x1447AB0")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1447AB0", Offset = "0x1447AB0")]
			public float headClampWeight;

			[Token(Token = "0x4000A94")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1447B04", Offset = "0x1447B04")]
			public float moveBodyBackWhenCrouching;

			[Token(Token = "0x4000A95")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1447B3C", Offset = "0x1447B3C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1447B3C", Offset = "0x1447B3C")]
			public float maintainPelvisPosition;

			[Token(Token = "0x4000A96")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1447B90", Offset = "0x1447B90")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1447B90", Offset = "0x1447B90")]
			public float maxRootAngle;

			[Token(Token = "0x4000A97")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1447BE8", Offset = "0x1447BE8")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1447BE8", Offset = "0x1447BE8")]
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
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1447D24", Offset = "0x1447D24")]
			private Quaternion <anchorRotation>k__BackingField;

			[Token(Token = "0x4000AA7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x16C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1447D34", Offset = "0x1447D34")]
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
				[Address(RVA = "0x2FE6A68", Offset = "0x2FE6A68", VA = "0x2FE6A68")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000AB")]
			public VirtualBone firstSpineBone
			{
				[Token(Token = "0x6000C8C")]
				[Address(RVA = "0x2FE70C8", Offset = "0x2FE70C8", VA = "0x2FE70C8")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000AC")]
			public VirtualBone chest
			{
				[Token(Token = "0x6000C8D")]
				[Address(RVA = "0x2FE7108", Offset = "0x2FE7108", VA = "0x2FE7108")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000AD")]
			private VirtualBone neck
			{
				[Token(Token = "0x6000C8E")]
				[Address(RVA = "0x2FE715C", Offset = "0x2FE715C", VA = "0x2FE715C")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000AE")]
			public VirtualBone head
			{
				[Token(Token = "0x6000C8F")]
				[Address(RVA = "0x2FE6AA8", Offset = "0x2FE6AA8", VA = "0x2FE6AA8")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000AF")]
			public Quaternion anchorRotation
			{
				[Token(Token = "0x6000C90")]
				[Address(RVA = "0x2FE719C", Offset = "0x2FE719C", VA = "0x2FE719C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x144BCB8", Offset = "0x144BCB8")]
				get
				{
					return default(Quaternion);
				}
				[Token(Token = "0x6000C91")]
				[Address(RVA = "0x2FE71B0", Offset = "0x2FE71B0", VA = "0x2FE71B0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x144BCC8", Offset = "0x144BCC8")]
				private set
				{
				}
			}

			[Token(Token = "0x170000B0")]
			public Quaternion anchorRelativeToHead
			{
				[Token(Token = "0x6000C92")]
				[Address(RVA = "0x2FE71C4", Offset = "0x2FE71C4", VA = "0x2FE71C4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x144BCD8", Offset = "0x144BCD8")]
				get
				{
					return default(Quaternion);
				}
				[Token(Token = "0x6000C93")]
				[Address(RVA = "0x2FE71D8", Offset = "0x2FE71D8", VA = "0x2FE71D8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x144BCE8", Offset = "0x144BCE8")]
				private set
				{
				}
			}

			[Token(Token = "0x6000C94")]
			[Address(RVA = "0x2FE71EC", Offset = "0x2FE71EC", VA = "0x2FE71EC", Slot = "4")]
			protected override void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index)
			{
			}

			[Token(Token = "0x6000C95")]
			[Address(RVA = "0x2FE7CB8", Offset = "0x2FE7CB8", VA = "0x2FE7CB8", Slot = "5")]
			public override void PreSolve()
			{
			}

			[Token(Token = "0x6000C96")]
			[Address(RVA = "0x2FE7EC8", Offset = "0x2FE7EC8", VA = "0x2FE7EC8", Slot = "7")]
			public override void ApplyOffsets()
			{
			}

			[Token(Token = "0x6000C97")]
			[Address(RVA = "0x2FE8540", Offset = "0x2FE8540", VA = "0x2FE8540")]
			private void CalculateChestTargetRotation(VirtualBone rootBone, Arm[] arms)
			{
			}

			[Token(Token = "0x6000C98")]
			[Address(RVA = "0x2FE8B00", Offset = "0x2FE8B00", VA = "0x2FE8B00")]
			public void Solve(VirtualBone rootBone, Leg[] legs, Arm[] arms)
			{
			}

			[Token(Token = "0x6000C99")]
			[Address(RVA = "0x2FE9540", Offset = "0x2FE9540", VA = "0x2FE9540")]
			private void FABRIKPass(Vector3 animatedPelvisPos, Vector3 rootUp, float weight)
			{
			}

			[Token(Token = "0x6000C9A")]
			[Address(RVA = "0x2FE9D6C", Offset = "0x2FE9D6C", VA = "0x2FE9D6C")]
			private void SolvePelvis()
			{
			}

			[Token(Token = "0x6000C9B")]
			[Address(RVA = "0x2FEA554", Offset = "0x2FEA554", VA = "0x2FEA554", Slot = "6")]
			public override void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations)
			{
			}

			[Token(Token = "0x6000C9C")]
			[Address(RVA = "0x2FEA730", Offset = "0x2FEA730", VA = "0x2FEA730", Slot = "8")]
			public override void ResetOffsets()
			{
			}

			[Token(Token = "0x6000C9D")]
			[Address(RVA = "0x2FE8770", Offset = "0x2FE8770", VA = "0x2FE8770")]
			private void AdjustChestByHands(ref Quaternion chestTargetRotation, Arm[] arms)
			{
			}

			[Token(Token = "0x6000C9E")]
			[Address(RVA = "0x2FE99B4", Offset = "0x2FE99B4", VA = "0x2FE99B4")]
			public void InverseTranslateToHead(Leg[] legs, bool limited, bool useCurrentLegMag, Vector3 offset, float w)
			{
			}

			[Token(Token = "0x6000C9F")]
			[Address(RVA = "0x2FE9124", Offset = "0x2FE9124", VA = "0x2FE9124")]
			private void TranslatePelvis(Leg[] legs, Vector3 deltaPosition, Quaternion deltaRotation)
			{
			}

			[Token(Token = "0x6000CA0")]
			[Address(RVA = "0x2FEA82C", Offset = "0x2FEA82C", VA = "0x2FEA82C")]
			private Vector3 LimitPelvisPosition(Leg[] legs, Vector3 pelvisPosition, bool useCurrentLegMag, int it = 2)
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000CA1")]
			[Address(RVA = "0x2FE9B20", Offset = "0x2FE9B20", VA = "0x2FE9B20")]
			private void Bend(VirtualBone[] bones, int firstIndex, int lastIndex, Quaternion targetRotation, float clampWeight, bool uniformWeight, float w)
			{
			}

			[Token(Token = "0x6000CA2")]
			[Address(RVA = "0x2FE9700", Offset = "0x2FE9700", VA = "0x2FE9700")]
			private void Bend(VirtualBone[] bones, int firstIndex, int lastIndex, Quaternion targetRotation, Quaternion rotationOffset, float clampWeight, bool uniformWeight, float w)
			{
			}

			[Token(Token = "0x6000CA3")]
			[Address(RVA = "0x2FEAB54", Offset = "0x2FEAB54", VA = "0x2FEAB54")]
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
			[Address(RVA = "0x2FDDCF4", Offset = "0x2FDDCF4", VA = "0x2FDDCF4")]
			public VirtualBone(Vector3 position, Quaternion rotation)
			{
			}

			[Token(Token = "0x6000CA5")]
			[Address(RVA = "0x2FDDD70", Offset = "0x2FDDD70", VA = "0x2FDDD70")]
			public void Read(Vector3 position, Quaternion rotation)
			{
			}

			[Token(Token = "0x6000CA6")]
			[Address(RVA = "0x2FEAD08", Offset = "0x2FEAD08", VA = "0x2FEAD08")]
			public static void SwingRotation(VirtualBone[] bones, int index, Vector3 swingTarget, float weight = 1f)
			{
			}

			[Token(Token = "0x6000CA7")]
			[Address(RVA = "0x2FE101C", Offset = "0x2FE101C", VA = "0x2FE101C")]
			public static float PreSolve(ref VirtualBone[] bones)
			{
				return default(float);
			}

			[Token(Token = "0x6000CA8")]
			[Address(RVA = "0x2FE151C", Offset = "0x2FE151C", VA = "0x2FE151C")]
			public static void RotateAroundPoint(VirtualBone[] bones, int index, Vector3 point, Quaternion rotation)
			{
			}

			[Token(Token = "0x6000CA9")]
			[Address(RVA = "0x2FEAF98", Offset = "0x2FEAF98", VA = "0x2FEAF98")]
			public static void RotateBy(VirtualBone[] bones, int index, Quaternion rotation)
			{
			}

			[Token(Token = "0x6000CAA")]
			[Address(RVA = "0x2FDFA74", Offset = "0x2FDFA74", VA = "0x2FDFA74")]
			public static void RotateBy(VirtualBone[] bones, Quaternion rotation)
			{
			}

			[Token(Token = "0x6000CAB")]
			[Address(RVA = "0x2FEB1D0", Offset = "0x2FEB1D0", VA = "0x2FEB1D0")]
			public static void RotateTo(VirtualBone[] bones, int index, Quaternion rotation)
			{
			}

			[Token(Token = "0x6000CAC")]
			[Address(RVA = "0x2FE0260", Offset = "0x2FE0260", VA = "0x2FE0260")]
			public static void SolveTrigonometric(VirtualBone[] bones, int first, int second, int third, Vector3 targetPosition, Vector3 bendNormal, float weight)
			{
			}

			[Token(Token = "0x6000CAD")]
			[Address(RVA = "0x2FEB288", Offset = "0x2FEB288", VA = "0x2FEB288")]
			private static Vector3 GetDirectionToBendPoint(Vector3 direction, float directionMag, Vector3 bendDirection, float sqrMag1, float sqrMag2)
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000CAE")]
			[Address(RVA = "0x2FEA0F4", Offset = "0x2FEA0F4", VA = "0x2FEA0F4")]
			public static void SolveFABRIK(VirtualBone[] bones, Vector3 startPosition, Vector3 targetPosition, float weight, float minNormalizedTargetDistance, int iterations, float length, Vector3 startOffset)
			{
			}

			[Token(Token = "0x6000CAF")]
			[Address(RVA = "0x2FEB4A0", Offset = "0x2FEB4A0", VA = "0x2FEB4A0")]
			private static Vector3 SolveFABRIKJoint(Vector3 pos1, Vector3 pos2, float length)
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000CB0")]
			[Address(RVA = "0x2FEB5A8", Offset = "0x2FEB5A8", VA = "0x2FEB5A8")]
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
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14448C8", Offset = "0x14448C8")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x14448C8", Offset = "0x14448C8")]
		public int LOD;

		[Token(Token = "0x4000317")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x144491C", Offset = "0x144491C")]
		public bool plantFeet;

		[Token(Token = "0x4000318")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1444954", Offset = "0x1444954")]
		private VirtualBone <rootBone>k__BackingField;

		[Token(Token = "0x4000319")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1444964", Offset = "0x1444964")]
		public Spine spine;

		[Token(Token = "0x400031A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x144499C", Offset = "0x144499C")]
		public Arm leftArm;

		[Token(Token = "0x400031B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14449D4", Offset = "0x14449D4")]
		public Arm rightArm;

		[Token(Token = "0x400031C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1444A0C", Offset = "0x1444A0C")]
		public Leg leftLeg;

		[Token(Token = "0x400031D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1444A44", Offset = "0x1444A44")]
		public Leg rightLeg;

		[Token(Token = "0x400031E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1444A7C", Offset = "0x1444A7C")]
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
			[Address(RVA = "0x2CE3358", Offset = "0x2CE3358", VA = "0x2CE3358")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x144AC20", Offset = "0x144AC20")]
			get
			{
				return null;
			}
			[Token(Token = "0x60003CE")]
			[Address(RVA = "0x2CE3360", Offset = "0x2CE3360", VA = "0x2CE3360")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x144AC30", Offset = "0x144AC30")]
			private set
			{
			}
		}

		[Token(Token = "0x60003B4")]
		[Address(RVA = "0x2CDEB50", Offset = "0x2CDEB50", VA = "0x2CDEB50")]
		public void SetToReferences(VRIK.References references)
		{
		}

		[Token(Token = "0x60003B5")]
		[Address(RVA = "0x2CDEF8C", Offset = "0x2CDEF8C", VA = "0x2CDEF8C")]
		public void GuessHandOrientations(VRIK.References references, bool onlyIfZero)
		{
		}

		[Token(Token = "0x60003B6")]
		[Address(RVA = "0x2CDEE34", Offset = "0x2CDEE34", VA = "0x2CDEE34")]
		public void DefaultAnimationCurves()
		{
		}

		[Token(Token = "0x60003B7")]
		[Address(RVA = "0x2CDF978", Offset = "0x2CDF978", VA = "0x2CDF978")]
		public void AddPositionOffset(PositionOffset positionOffset, Vector3 value)
		{
		}

		[Token(Token = "0x60003B8")]
		[Address(RVA = "0x2CDFC54", Offset = "0x2CDFC54", VA = "0x2CDFC54")]
		public void AddRotationOffset(RotationOffset rotationOffset, Vector3 value)
		{
		}

		[Token(Token = "0x60003B9")]
		[Address(RVA = "0x2CDFCF8", Offset = "0x2CDFCF8", VA = "0x2CDFCF8")]
		public void AddRotationOffset(RotationOffset rotationOffset, Quaternion value)
		{
		}

		[Token(Token = "0x60003BA")]
		[Address(RVA = "0x2CDFE8C", Offset = "0x2CDFE8C", VA = "0x2CDFE8C")]
		public void AddPlatformMotion(Vector3 deltaPosition, Quaternion deltaRotation, Vector3 platformPivot)
		{
		}

		[Token(Token = "0x60003BB")]
		[Address(RVA = "0x2CE0018", Offset = "0x2CE0018", VA = "0x2CE0018")]
		public void Reset()
		{
		}

		[Token(Token = "0x60003BC")]
		[Address(RVA = "0x2CE083C", Offset = "0x2CE083C", VA = "0x2CE083C", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60003BD")]
		[Address(RVA = "0x2CE09B0", Offset = "0x2CE09B0", VA = "0x2CE09B0", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x60003BE")]
		[Address(RVA = "0x2CE0BB8", Offset = "0x2CE0BB8", VA = "0x2CE0BB8", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x60003BF")]
		[Address(RVA = "0x2CE0C2C", Offset = "0x2CE0C2C", VA = "0x2CE0C2C", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x60003C0")]
		[Address(RVA = "0x2CE0CA0", Offset = "0x2CE0CA0", VA = "0x2CE0CA0", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60003C1")]
		[Address(RVA = "0x2CE0EB4", Offset = "0x2CE0EB4", VA = "0x2CE0EB4")]
		private Vector3 GetNormal(Transform[] transforms)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003C2")]
		[Address(RVA = "0x2CDF22C", Offset = "0x2CDF22C", VA = "0x2CDF22C")]
		private Vector3 GuessWristToPalmAxis(Transform hand, Transform forearm)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003C3")]
		[Address(RVA = "0x2CDF404", Offset = "0x2CDF404", VA = "0x2CDF404")]
		private Vector3 GuessPalmToThumbAxis(Transform hand, Transform forearm)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003C4")]
		[Address(RVA = "0x2CDF854", Offset = "0x2CDF854", VA = "0x2CDF854")]
		private static Keyframe[] GetSineKeyframes(float mag)
		{
			return null;
		}

		[Token(Token = "0x60003C5")]
		[Address(RVA = "0x2CE0190", Offset = "0x2CE0190", VA = "0x2CE0190")]
		private void UpdateSolverTransforms()
		{
		}

		[Token(Token = "0x60003C6")]
		[Address(RVA = "0x2CE1194", Offset = "0x2CE1194", VA = "0x2CE1194", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x60003C7")]
		[Address(RVA = "0x2CE11DC", Offset = "0x2CE11DC", VA = "0x2CE11DC", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x60003C8")]
		[Address(RVA = "0x2CE28E0", Offset = "0x2CE28E0", VA = "0x2CE28E0")]
		private void WriteTransforms()
		{
		}

		[Token(Token = "0x60003C9")]
		[Address(RVA = "0x2CE02F8", Offset = "0x2CE02F8", VA = "0x2CE02F8")]
		private void Read(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs)
		{
		}

		[Token(Token = "0x60003CA")]
		[Address(RVA = "0x2CE16A4", Offset = "0x2CE16A4", VA = "0x2CE16A4")]
		private void Solve()
		{
		}

		[Token(Token = "0x60003CB")]
		[Address(RVA = "0x2CE2CCC", Offset = "0x2CE2CCC", VA = "0x2CE2CCC")]
		private Vector3 GetPosition(int index)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003CC")]
		[Address(RVA = "0x2CE2D14", Offset = "0x2CE2D14", VA = "0x2CE2D14")]
		private Quaternion GetRotation(int index)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60003CF")]
		[Address(RVA = "0x2CE2790", Offset = "0x2CE2790", VA = "0x2CE2790")]
		private void Write()
		{
		}

		[Token(Token = "0x60003D0")]
		[Address(RVA = "0x2CE2D58", Offset = "0x2CE2D58", VA = "0x2CE2D58")]
		private Vector3 GetPelvisOffset()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003D1")]
		[Address(RVA = "0x2CE3368", Offset = "0x2CE3368", VA = "0x2CE3368")]
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
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1444AB4", Offset = "0x1444AB4")]
		public Transform parent;

		[Token(Token = "0x400032B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1444AEC", Offset = "0x1444AEC")]
		public Transform child;

		[Token(Token = "0x400032C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1444B24", Offset = "0x1444B24")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1444B24", Offset = "0x1444B24")]
		public float weight;

		[Token(Token = "0x400032D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1444B78", Offset = "0x1444B78")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1444B78", Offset = "0x1444B78")]
		public float parentChildCrossfade;

		[Token(Token = "0x400032E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1444BCC", Offset = "0x1444BCC")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1444BCC", Offset = "0x1444BCC")]
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
		[Address(RVA = "0x29446C8", Offset = "0x29446C8", VA = "0x29446C8")]
		public void Relax()
		{
		}

		[Token(Token = "0x60003D3")]
		[Address(RVA = "0x2944AA8", Offset = "0x2944AA8", VA = "0x2944AA8")]
		private void Start()
		{
		}

		[Token(Token = "0x60003D4")]
		[Address(RVA = "0x2944F1C", Offset = "0x2944F1C", VA = "0x2944F1C")]
		private void OnPostUpdate()
		{
		}

		[Token(Token = "0x60003D5")]
		[Address(RVA = "0x2944FA4", Offset = "0x2944FA4", VA = "0x2944FA4")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60003D6")]
		[Address(RVA = "0x294502C", Offset = "0x294502C", VA = "0x294502C")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60003D7")]
		[Address(RVA = "0x2945130", Offset = "0x2945130", VA = "0x2945130")]
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
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1444C28", Offset = "0x1444C28")]
		private FullBodyBipedEffector <effectorType>k__BackingField;

		[Token(Token = "0x4000334")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1444C38", Offset = "0x1444C38")]
		private bool <isPaused>k__BackingField;

		[Token(Token = "0x4000335")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1444C48", Offset = "0x1444C48")]
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
			[Address(RVA = "0x2FEBDD0", Offset = "0x2FEBDD0", VA = "0x2FEBDD0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x144AC40", Offset = "0x144AC40")]
			get
			{
				return default(FullBodyBipedEffector);
			}
			[Token(Token = "0x60003D9")]
			[Address(RVA = "0x2FEBDD8", Offset = "0x2FEBDD8", VA = "0x2FEBDD8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x144AC50", Offset = "0x144AC50")]
			private set
			{
			}
		}

		[Token(Token = "0x17000052")]
		public bool isPaused
		{
			[Token(Token = "0x60003DA")]
			[Address(RVA = "0x2FEBDE0", Offset = "0x2FEBDE0", VA = "0x2FEBDE0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x144AC60", Offset = "0x144AC60")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60003DB")]
			[Address(RVA = "0x2FEBDE8", Offset = "0x2FEBDE8", VA = "0x2FEBDE8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x144AC70", Offset = "0x144AC70")]
			private set
			{
			}
		}

		[Token(Token = "0x17000053")]
		public InteractionObject interactionObject
		{
			[Token(Token = "0x60003DC")]
			[Address(RVA = "0x2FEBDF4", Offset = "0x2FEBDF4", VA = "0x2FEBDF4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x144AC80", Offset = "0x144AC80")]
			get
			{
				return null;
			}
			[Token(Token = "0x60003DD")]
			[Address(RVA = "0x2FEBDFC", Offset = "0x2FEBDFC", VA = "0x2FEBDFC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x144AC90", Offset = "0x144AC90")]
			private set
			{
			}
		}

		[Token(Token = "0x17000054")]
		public bool inInteraction
		{
			[Token(Token = "0x60003DE")]
			[Address(RVA = "0x2FEBE04", Offset = "0x2FEBE04", VA = "0x2FEBE04")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000055")]
		public float progress
		{
			[Token(Token = "0x60003E7")]
			[Address(RVA = "0x2FEE7C4", Offset = "0x2FEE7C4", VA = "0x2FEE7C4")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x60003DF")]
		[Address(RVA = "0x2FEBE74", Offset = "0x2FEBE74", VA = "0x2FEBE74")]
		public InteractionEffector(FullBodyBipedEffector effectorType)
		{
		}

		[Token(Token = "0x60003E0")]
		[Address(RVA = "0x2FEBEF8", Offset = "0x2FEBEF8", VA = "0x2FEBEF8")]
		public void Initiate(InteractionSystem interactionSystem)
		{
		}

		[Token(Token = "0x60003E1")]
		[Address(RVA = "0x2FEBF9C", Offset = "0x2FEBF9C", VA = "0x2FEBF9C")]
		private void StoreDefaults()
		{
		}

		[Token(Token = "0x60003E2")]
		[Address(RVA = "0x2FEC114", Offset = "0x2FEC114", VA = "0x2FEC114")]
		public bool ResetToDefaults(float speed)
		{
			return default(bool);
		}

		[Token(Token = "0x60003E3")]
		[Address(RVA = "0x2FEC5C4", Offset = "0x2FEC5C4", VA = "0x2FEC5C4")]
		public bool Pause()
		{
			return default(bool);
		}

		[Token(Token = "0x60003E4")]
		[Address(RVA = "0x2FEC984", Offset = "0x2FEC984", VA = "0x2FEC984")]
		public bool Resume()
		{
			return default(bool);
		}

		[Token(Token = "0x60003E5")]
		[Address(RVA = "0x2FEC9D8", Offset = "0x2FEC9D8", VA = "0x2FEC9D8")]
		public bool Start(InteractionObject interactionObject, string tag, float fadeInTime, bool interrupt)
		{
			return default(bool);
		}

		[Token(Token = "0x60003E6")]
		[Address(RVA = "0x2FED52C", Offset = "0x2FED52C", VA = "0x2FED52C")]
		public void Update(Transform root, float speed)
		{
		}

		[Token(Token = "0x60003E8")]
		[Address(RVA = "0x2FEE00C", Offset = "0x2FEE00C", VA = "0x2FEE00C")]
		private void TriggerUntriggeredEvents(bool checkTime, out bool pickUp, out bool pause)
		{
		}

		[Token(Token = "0x60003E9")]
		[Address(RVA = "0x2FEE234", Offset = "0x2FEE234", VA = "0x2FEE234")]
		private void PickUp(Transform root)
		{
		}

		[Token(Token = "0x60003EA")]
		[Address(RVA = "0x2FEE670", Offset = "0x2FEE670", VA = "0x2FEE670")]
		public bool Stop()
		{
			return default(bool);
		}

		[Token(Token = "0x60003EB")]
		[Address(RVA = "0x2FEECAC", Offset = "0x2FEECAC", VA = "0x2FEECAC")]
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
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1444C58", Offset = "0x1444C58")]
		public LookAtIK ik;

		[Token(Token = "0x4000358")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1444C90", Offset = "0x1444C90")]
		public float lerpSpeed;

		[Token(Token = "0x4000359")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1444CC8", Offset = "0x1444CC8")]
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
		[Address(RVA = "0x2FEEF10", Offset = "0x2FEEF10", VA = "0x2FEEF10")]
		public void Look(Transform target, float time)
		{
		}

		[Token(Token = "0x60003ED")]
		[Address(RVA = "0x2FEF088", Offset = "0x2FEF088", VA = "0x2FEF088")]
		public void OnFixTransforms()
		{
		}

		[Token(Token = "0x60003EE")]
		[Address(RVA = "0x2FEF130", Offset = "0x2FEF130", VA = "0x2FEF130")]
		public void Update()
		{
		}

		[Token(Token = "0x60003EF")]
		[Address(RVA = "0x2FEF374", Offset = "0x2FEF374", VA = "0x2FEF374")]
		public void SolveSpine()
		{
		}

		[Token(Token = "0x60003F0")]
		[Address(RVA = "0x2FEF46C", Offset = "0x2FEF46C", VA = "0x2FEF46C")]
		public void SolveHead()
		{
		}

		[Token(Token = "0x60003F1")]
		[Address(RVA = "0x2FEF538", Offset = "0x2FEF538", VA = "0x2FEF538")]
		public InteractionLookAt()
		{
		}
	}
	[Token(Token = "0x2000067")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x1441B20", Offset = "0x1441B20")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x1441B20", Offset = "0x1441B20")]
	public class InteractionObject : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20001AD")]
		public class InteractionEvent
		{
			[Token(Token = "0x4000AD1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1447D44", Offset = "0x1447D44")]
			public float time;

			[Token(Token = "0x4000AD2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1447D7C", Offset = "0x1447D7C")]
			public bool pause;

			[Token(Token = "0x4000AD3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x15")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1447DB4", Offset = "0x1447DB4")]
			public bool pickUp;

			[Token(Token = "0x4000AD4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1447DEC", Offset = "0x1447DEC")]
			public AnimatorEvent[] animations;

			[Token(Token = "0x4000AD5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1447E24", Offset = "0x1447E24")]
			public Message[] messages;

			[Token(Token = "0x4000AD6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1447E5C", Offset = "0x1447E5C")]
			public UnityEvent unityEvent;

			[Token(Token = "0x6000CB1")]
			[Address(RVA = "0x2FEE800", Offset = "0x2FEE800", VA = "0x2FEE800")]
			public void Activate(Transform t)
			{
			}

			[Token(Token = "0x6000CB2")]
			[Address(RVA = "0x2FF0854", Offset = "0x2FF0854", VA = "0x2FF0854")]
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
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1447E94", Offset = "0x1447E94")]
			public string function;

			[Token(Token = "0x4000AD8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1447ECC", Offset = "0x1447ECC")]
			public GameObject recipient;

			[Token(Token = "0x4000AD9")]
			private const string empty = "";

			[Token(Token = "0x6000CB3")]
			[Address(RVA = "0x2FF0764", Offset = "0x2FF0764", VA = "0x2FF0764")]
			public void Send(Transform t)
			{
			}

			[Token(Token = "0x6000CB4")]
			[Address(RVA = "0x2FF085C", Offset = "0x2FF085C", VA = "0x2FF085C")]
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
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1447F04", Offset = "0x1447F04")]
			public Animator animator;

			[Token(Token = "0x4000ADB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1447F3C", Offset = "0x1447F3C")]
			public Animation animation;

			[Token(Token = "0x4000ADC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1447F74", Offset = "0x1447F74")]
			public string animationState;

			[Token(Token = "0x4000ADD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1447FAC", Offset = "0x1447FAC")]
			public float crossfadeTime;

			[Token(Token = "0x4000ADE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1447FE4", Offset = "0x1447FE4")]
			public int layer;

			[Token(Token = "0x4000ADF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x144801C", Offset = "0x144801C")]
			public bool resetNormalizedTime;

			[Token(Token = "0x4000AE0")]
			private const string empty = "";

			[Token(Token = "0x6000CB5")]
			[Address(RVA = "0x2FF04C4", Offset = "0x2FF04C4", VA = "0x2FF04C4")]
			public void Activate(bool pickUp)
			{
			}

			[Token(Token = "0x6000CB6")]
			[Address(RVA = "0x2FF05B8", Offset = "0x2FF05B8", VA = "0x2FF05B8")]
			private void Activate(Animator animator)
			{
			}

			[Token(Token = "0x6000CB7")]
			[Address(RVA = "0x2FF0670", Offset = "0x2FF0670", VA = "0x2FF0670")]
			private void Activate(Animation animation)
			{
			}

			[Token(Token = "0x6000CB8")]
			[Address(RVA = "0x2FF0750", Offset = "0x2FF0750", VA = "0x2FF0750")]
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
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1448054", Offset = "0x1448054")]
			public Type type;

			[Token(Token = "0x4000AE2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x144808C", Offset = "0x144808C")]
			public AnimationCurve curve;

			[Token(Token = "0x6000CB9")]
			[Address(RVA = "0x2FEFCDC", Offset = "0x2FEFCDC", VA = "0x2FEFCDC")]
			public float GetValue(float timer)
			{
				return default(float);
			}

			[Token(Token = "0x6000CBA")]
			[Address(RVA = "0x2FF0874", Offset = "0x2FF0874", VA = "0x2FF0874")]
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
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14480C4", Offset = "0x14480C4")]
			public WeightCurve.Type curve;

			[Token(Token = "0x4000AE4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14480FC", Offset = "0x14480FC")]
			public float multiplier;

			[Token(Token = "0x4000AE5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1448134", Offset = "0x1448134")]
			public WeightCurve.Type result;

			[Token(Token = "0x6000CBB")]
			[Address(RVA = "0x2FF03BC", Offset = "0x2FF03BC", VA = "0x2FF03BC")]
			public float GetValue(WeightCurve weightCurve, float timer)
			{
				return default(float);
			}

			[Token(Token = "0x6000CBC")]
			[Address(RVA = "0x2FF0864", Offset = "0x2FF0864", VA = "0x2FF0864")]
			public Multiplier()
			{
			}
		}

		[Token(Token = "0x400035F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1444D10", Offset = "0x1444D10")]
		public Transform otherLookAtTarget;

		[Token(Token = "0x4000360")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1444D48", Offset = "0x1444D48")]
		public Transform otherTargetsRoot;

		[Token(Token = "0x4000361")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1444D80", Offset = "0x1444D80")]
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
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1444DB8", Offset = "0x1444DB8")]
		private float <length>k__BackingField;

		[Token(Token = "0x4000366")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1444DC8", Offset = "0x1444DC8")]
		private InteractionSystem <lastUsedInteractionSystem>k__BackingField;

		[Token(Token = "0x4000367")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private InteractionTarget[] targets;

		[Token(Token = "0x17000056")]
		public float length
		{
			[Token(Token = "0x60003FA")]
			[Address(RVA = "0x2FEF7AC", Offset = "0x2FEF7AC", VA = "0x2FEF7AC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x144AE60", Offset = "0x144AE60")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60003FB")]
			[Address(RVA = "0x2FEF7B4", Offset = "0x2FEF7B4", VA = "0x2FEF7B4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x144AE70", Offset = "0x144AE70")]
			private set
			{
			}
		}

		[Token(Token = "0x17000057")]
		public InteractionSystem lastUsedInteractionSystem
		{
			[Token(Token = "0x60003FC")]
			[Address(RVA = "0x2FEF7BC", Offset = "0x2FEF7BC", VA = "0x2FEF7BC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x144AE80", Offset = "0x144AE80")]
			get
			{
				return null;
			}
			[Token(Token = "0x60003FD")]
			[Address(RVA = "0x2FEF7C4", Offset = "0x2FEF7C4", VA = "0x2FEF7C4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x144AE90", Offset = "0x144AE90")]
			private set
			{
			}
		}

		[Token(Token = "0x17000058")]
		public Transform lookAtTarget
		{
			[Token(Token = "0x60003FF")]
			[Address(RVA = "0x2FEF9E0", Offset = "0x2FEF9E0", VA = "0x2FEF9E0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000059")]
		public Transform targetsRoot
		{
			[Token(Token = "0x6000407")]
			[Address(RVA = "0x2FEEB80", Offset = "0x2FEEB80", VA = "0x2FEEB80")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60003F2")]
		[Address(RVA = "0x2FEF54C", Offset = "0x2FEF54C", VA = "0x2FEF54C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x144ACA0", Offset = "0x144ACA0")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x60003F3")]
		[Address(RVA = "0x2FEF598", Offset = "0x2FEF598", VA = "0x2FEF598")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x144ACD8", Offset = "0x144ACD8")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x60003F4")]
		[Address(RVA = "0x2FEF5E4", Offset = "0x2FEF5E4", VA = "0x2FEF5E4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x144AD10", Offset = "0x144AD10")]
		private void OpenTutorial1()
		{
		}

		[Token(Token = "0x60003F5")]
		[Address(RVA = "0x2FEF630", Offset = "0x2FEF630", VA = "0x2FEF630")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x144AD48", Offset = "0x144AD48")]
		private void OpenTutorial2()
		{
		}

		[Token(Token = "0x60003F6")]
		[Address(RVA = "0x2FEF67C", Offset = "0x2FEF67C", VA = "0x2FEF67C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x144AD80", Offset = "0x144AD80")]
		private void OpenTutorial3()
		{
		}

		[Token(Token = "0x60003F7")]
		[Address(RVA = "0x2FEF6C8", Offset = "0x2FEF6C8", VA = "0x2FEF6C8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x144ADB8", Offset = "0x144ADB8")]
		private void OpenTutorial4()
		{
		}

		[Token(Token = "0x60003F8")]
		[Address(RVA = "0x2FEF714", Offset = "0x2FEF714", VA = "0x2FEF714")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x144ADF0", Offset = "0x144ADF0")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60003F9")]
		[Address(RVA = "0x2FEF760", Offset = "0x2FEF760", VA = "0x2FEF760")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x144AE28", Offset = "0x144AE28")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60003FE")]
		[Address(RVA = "0x2FEF7CC", Offset = "0x2FEF7CC", VA = "0x2FEF7CC")]
		public void Initiate()
		{
		}

		[Token(Token = "0x6000400")]
		[Address(RVA = "0x2FEFA70", Offset = "0x2FEFA70", VA = "0x2FEFA70")]
		public InteractionTarget GetTarget(FullBodyBipedEffector effectorType, InteractionSystem interactionSystem)
		{
			return null;
		}

		[Token(Token = "0x6000401")]
		[Address(RVA = "0x2FECF54", Offset = "0x2FECF54", VA = "0x2FECF54")]
		public bool CurveUsed(WeightCurve.Type type)
		{
			return default(bool);
		}

		[Token(Token = "0x6000402")]
		[Address(RVA = "0x2FEFBF4", Offset = "0x2FEFBF4", VA = "0x2FEFBF4")]
		public InteractionTarget[] GetTargets()
		{
			return null;
		}

		[Token(Token = "0x6000403")]
		[Address(RVA = "0x2FECE08", Offset = "0x2FECE08", VA = "0x2FECE08")]
		public Transform GetTarget(FullBodyBipedEffector effectorType, string tag)
		{
			return null;
		}

		[Token(Token = "0x6000404")]
		[Address(RVA = "0x2FECF4C", Offset = "0x2FECF4C", VA = "0x2FECF4C")]
		public void OnStartInteraction(InteractionSystem interactionSystem)
		{
		}

		[Token(Token = "0x6000405")]
		[Address(RVA = "0x2FEDBF0", Offset = "0x2FEDBF0", VA = "0x2FEDBF0")]
		public void Apply(IKSolverFullBodyBiped solver, FullBodyBipedEffector effector, InteractionTarget target, float timer, float weight)
		{
		}

		[Token(Token = "0x6000406")]
		[Address(RVA = "0x2FEE448", Offset = "0x2FEE448", VA = "0x2FEE448")]
		public float GetValue(WeightCurve.Type weightCurveType, InteractionTarget target, float timer)
		{
			return default(float);
		}

		[Token(Token = "0x6000408")]
		[Address(RVA = "0x2FF03F8", Offset = "0x2FF03F8", VA = "0x2FF03F8")]
		private void Start()
		{
		}

		[Token(Token = "0x6000409")]
		[Address(RVA = "0x2FEFCF8", Offset = "0x2FEFCF8", VA = "0x2FEFCF8")]
		private void Apply(IKSolverFullBodyBiped solver, FullBodyBipedEffector effector, WeightCurve.Type type, float value, float weight)
		{
		}

		[Token(Token = "0x600040A")]
		[Address(RVA = "0x2FEFBFC", Offset = "0x2FEFBFC", VA = "0x2FEFBFC")]
		private Transform GetTarget(FullBodyBipedEffector effectorType)
		{
			return null;
		}

		[Token(Token = "0x600040B")]
		[Address(RVA = "0x2FF0354", Offset = "0x2FF0354", VA = "0x2FF0354")]
		private int GetWeightCurveIndex(WeightCurve.Type weightCurveType)
		{
			return default(int);
		}

		[Token(Token = "0x600040C")]
		[Address(RVA = "0x2FF03FC", Offset = "0x2FF03FC", VA = "0x2FF03FC")]
		private int GetMultiplierIndex(WeightCurve.Type weightCurveType)
		{
			return default(int);
		}

		[Token(Token = "0x600040D")]
		[Address(RVA = "0x2FF0464", Offset = "0x2FF0464", VA = "0x2FF0464")]
		public InteractionObject()
		{
		}
	}
	[Token(Token = "0x2000068")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x1441B80", Offset = "0x1441B80")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x1441B80", Offset = "0x1441B80")]
	public class InteractionSystem : MonoBehaviour
	{
		[Token(Token = "0x20001B2")]
		public delegate void InteractionDelegate(FullBodyBipedEffector effectorType, InteractionObject interactionObject);

		[Token(Token = "0x20001B3")]
		public delegate void InteractionEventDelegate(FullBodyBipedEffector effectorType, InteractionObject interactionObject, InteractionObject.InteractionEvent interactionEvent);

		[Token(Token = "0x4000368")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1444DD8", Offset = "0x1444DD8")]
		public string targetTag;

		[Token(Token = "0x4000369")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1444E10", Offset = "0x1444E10")]
		public float fadeInTime;

		[Token(Token = "0x400036A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1444E48", Offset = "0x1444E48")]
		public float speed;

		[Token(Token = "0x400036B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1444E80", Offset = "0x1444E80")]
		public float resetToDefaultsSpeed;

		[Token(Token = "0x400036C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x1444EB8", Offset = "0x1444EB8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1444EB8", Offset = "0x1444EB8")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x1444EB8", Offset = "0x1444EB8")]
		public Collider characterCollider;

		[Token(Token = "0x400036D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1444F3C", Offset = "0x1444F3C")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x1444F3C", Offset = "0x1444F3C")]
		public Transform FPSCamera;

		[Token(Token = "0x400036E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1444F9C", Offset = "0x1444F9C")]
		public LayerMask camRaycastLayers;

		[Token(Token = "0x400036F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1444FD4", Offset = "0x1444FD4")]
		public float camRaycastDistance;

		[Token(Token = "0x4000370")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x144500C", Offset = "0x144500C")]
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
		[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x144501C", Offset = "0x144501C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x144501C", Offset = "0x144501C")]
		[SerializeField]
		private FullBodyBipedIK fullBody;

		[Token(Token = "0x400037B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x144507C", Offset = "0x144507C")]
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
			[Address(RVA = "0x2FF0ADC", Offset = "0x2FF0ADC", VA = "0x2FF0ADC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700005B")]
		public FullBodyBipedIK ik
		{
			[Token(Token = "0x6000430")]
			[Address(RVA = "0x2FF26F4", Offset = "0x2FF26F4", VA = "0x2FF26F4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000431")]
			[Address(RVA = "0x2FF26FC", Offset = "0x2FF26FC", VA = "0x2FF26FC")]
			set
			{
			}
		}

		[Token(Token = "0x1700005C")]
		public List<InteractionTrigger> triggersInRange
		{
			[Token(Token = "0x6000432")]
			[Address(RVA = "0x2FF2704", Offset = "0x2FF2704", VA = "0x2FF2704")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x144B060", Offset = "0x144B060")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000433")]
			[Address(RVA = "0x2FF270C", Offset = "0x2FF270C", VA = "0x2FF270C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x144B070", Offset = "0x144B070")]
			private set
			{
			}
		}

		[Token(Token = "0x600040E")]
		[Address(RVA = "0x2FF087C", Offset = "0x2FF087C", VA = "0x2FF087C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x144AEA0", Offset = "0x144AEA0")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x600040F")]
		[Address(RVA = "0x2FF08C8", Offset = "0x2FF08C8", VA = "0x2FF08C8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x144AED8", Offset = "0x144AED8")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000410")]
		[Address(RVA = "0x2FF0914", Offset = "0x2FF0914", VA = "0x2FF0914")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x144AF10", Offset = "0x144AF10")]
		private void OpenTutorial1()
		{
		}

		[Token(Token = "0x6000411")]
		[Address(RVA = "0x2FF0960", Offset = "0x2FF0960", VA = "0x2FF0960")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x144AF48", Offset = "0x144AF48")]
		private void OpenTutorial2()
		{
		}

		[Token(Token = "0x6000412")]
		[Address(RVA = "0x2FF09AC", Offset = "0x2FF09AC", VA = "0x2FF09AC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x144AF80", Offset = "0x144AF80")]
		private void OpenTutorial3()
		{
		}

		[Token(Token = "0x6000413")]
		[Address(RVA = "0x2FF09F8", Offset = "0x2FF09F8", VA = "0x2FF09F8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x144AFB8", Offset = "0x144AFB8")]
		private void OpenTutorial4()
		{
		}

		[Token(Token = "0x6000414")]
		[Address(RVA = "0x2FF0A44", Offset = "0x2FF0A44", VA = "0x2FF0A44")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x144AFF0", Offset = "0x144AFF0")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000415")]
		[Address(RVA = "0x2FF0A90", Offset = "0x2FF0A90", VA = "0x2FF0A90")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x144B028", Offset = "0x144B028")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000417")]
		[Address(RVA = "0x2FF0C6C", Offset = "0x2FF0C6C", VA = "0x2FF0C6C")]
		public bool IsInInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x6000418")]
		[Address(RVA = "0x2FF0D38", Offset = "0x2FF0D38", VA = "0x2FF0D38")]
		public bool IsPaused(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x6000419")]
		[Address(RVA = "0x2FF0E04", Offset = "0x2FF0E04", VA = "0x2FF0E04")]
		public bool IsPaused()
		{
			return default(bool);
		}

		[Token(Token = "0x600041A")]
		[Address(RVA = "0x2FF0EB0", Offset = "0x2FF0EB0", VA = "0x2FF0EB0")]
		public bool IsInSync()
		{
			return default(bool);
		}

		[Token(Token = "0x600041B")]
		[Address(RVA = "0x2FF0FA8", Offset = "0x2FF0FA8", VA = "0x2FF0FA8")]
		public bool StartInteraction(FullBodyBipedEffector effectorType, InteractionObject interactionObject, bool interrupt)
		{
			return default(bool);
		}

		[Token(Token = "0x600041C")]
		[Address(RVA = "0x2FF10C4", Offset = "0x2FF10C4", VA = "0x2FF10C4")]
		public bool PauseInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x600041D")]
		[Address(RVA = "0x2FF1154", Offset = "0x2FF1154", VA = "0x2FF1154")]
		public bool ResumeInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x600041E")]
		[Address(RVA = "0x2FF11E4", Offset = "0x2FF11E4", VA = "0x2FF11E4")]
		public bool StopInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x600041F")]
		[Address(RVA = "0x2FF1274", Offset = "0x2FF1274", VA = "0x2FF1274")]
		public void PauseAll()
		{
		}

		[Token(Token = "0x6000420")]
		[Address(RVA = "0x2FF12E8", Offset = "0x2FF12E8", VA = "0x2FF12E8")]
		public void ResumeAll()
		{
		}

		[Token(Token = "0x6000421")]
		[Address(RVA = "0x2FF135C", Offset = "0x2FF135C", VA = "0x2FF135C")]
		public void StopAll()
		{
		}

		[Token(Token = "0x6000422")]
		[Address(RVA = "0x2FF13C4", Offset = "0x2FF13C4", VA = "0x2FF13C4")]
		public InteractionObject GetInteractionObject(FullBodyBipedEffector effectorType)
		{
			return null;
		}

		[Token(Token = "0x6000423")]
		[Address(RVA = "0x2FF1450", Offset = "0x2FF1450", VA = "0x2FF1450")]
		public float GetProgress(FullBodyBipedEffector effectorType)
		{
			return default(float);
		}

		[Token(Token = "0x6000424")]
		[Address(RVA = "0x2FF1504", Offset = "0x2FF1504", VA = "0x2FF1504")]
		public float GetMinActiveProgress()
		{
			return default(float);
		}

		[Token(Token = "0x6000425")]
		[Address(RVA = "0x2FF15E8", Offset = "0x2FF15E8", VA = "0x2FF15E8")]
		public bool TriggerInteraction(int index, bool interrupt)
		{
			return default(bool);
		}

		[Token(Token = "0x6000426")]
		[Address(RVA = "0x2FF188C", Offset = "0x2FF188C", VA = "0x2FF188C")]
		public bool TriggerInteraction(int index, bool interrupt, out InteractionObject interactionObject)
		{
			return default(bool);
		}

		[Token(Token = "0x6000427")]
		[Address(RVA = "0x2FF1A64", Offset = "0x2FF1A64", VA = "0x2FF1A64")]
		public bool TriggerInteraction(int index, bool interrupt, out InteractionTarget interactionTarget)
		{
			return default(bool);
		}

		[Token(Token = "0x6000428")]
		[Address(RVA = "0x2FF1CD8", Offset = "0x2FF1CD8", VA = "0x2FF1CD8")]
		public InteractionTrigger.Range GetClosestInteractionRange()
		{
			return null;
		}

		[Token(Token = "0x6000429")]
		[Address(RVA = "0x2FF1FCC", Offset = "0x2FF1FCC", VA = "0x2FF1FCC")]
		public InteractionObject GetClosestInteractionObjectInRange()
		{
			return null;
		}

		[Token(Token = "0x600042A")]
		[Address(RVA = "0x2FF2010", Offset = "0x2FF2010", VA = "0x2FF2010")]
		public InteractionTarget GetClosestInteractionTargetInRange()
		{
			return null;
		}

		[Token(Token = "0x600042B")]
		[Address(RVA = "0x2FF2088", Offset = "0x2FF2088", VA = "0x2FF2088")]
		public InteractionObject[] GetClosestInteractionObjectsInRange()
		{
			return null;
		}

		[Token(Token = "0x600042C")]
		[Address(RVA = "0x2FF21A8", Offset = "0x2FF21A8", VA = "0x2FF21A8")]
		public InteractionTarget[] GetClosestInteractionTargetsInRange()
		{
			return null;
		}

		[Token(Token = "0x600042D")]
		[Address(RVA = "0x2FF2320", Offset = "0x2FF2320", VA = "0x2FF2320")]
		public bool TriggerEffectorsReady(int index)
		{
			return default(bool);
		}

		[Token(Token = "0x600042E")]
		[Address(RVA = "0x2FF25C8", Offset = "0x2FF25C8", VA = "0x2FF25C8")]
		public InteractionTrigger.Range GetTriggerRange(int index)
		{
			return null;
		}

		[Token(Token = "0x600042F")]
		[Address(RVA = "0x2FF1DD8", Offset = "0x2FF1DD8", VA = "0x2FF1DD8")]
		public int GetClosestTriggerIndex()
		{
			return default(int);
		}

		[Token(Token = "0x6000434")]
		[Address(RVA = "0x2FF2714", Offset = "0x2FF2714", VA = "0x2FF2714")]
		public void Start()
		{
		}

		[Token(Token = "0x6000435")]
		[Address(RVA = "0x2FF2DC8", Offset = "0x2FF2DC8", VA = "0x2FF2DC8")]
		private void InteractionPause(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x6000436")]
		[Address(RVA = "0x2FF2DE8", Offset = "0x2FF2DE8", VA = "0x2FF2DE8")]
		private void InteractionResume(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x6000437")]
		[Address(RVA = "0x2FF2E04", Offset = "0x2FF2E04", VA = "0x2FF2E04")]
		private void InteractionStop(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x6000438")]
		[Address(RVA = "0x2FF2E20", Offset = "0x2FF2E20", VA = "0x2FF2E20")]
		private void LookAtInteraction(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x6000439")]
		[Address(RVA = "0x2FF2E80", Offset = "0x2FF2E80", VA = "0x2FF2E80")]
		public void OnTriggerEnter(Collider c)
		{
		}

		[Token(Token = "0x600043A")]
		[Address(RVA = "0x2FF2F9C", Offset = "0x2FF2F9C", VA = "0x2FF2F9C")]
		public void OnTriggerExit(Collider c)
		{
		}

		[Token(Token = "0x600043B")]
		[Address(RVA = "0x2FF3098", Offset = "0x2FF3098", VA = "0x2FF3098")]
		private bool ContactIsInRange(int index, out int bestRangeIndex)
		{
			return default(bool);
		}

		[Token(Token = "0x600043C")]
		[Address(RVA = "0x2FF3240", Offset = "0x2FF3240", VA = "0x2FF3240")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x600043D")]
		[Address(RVA = "0x2FF332C", Offset = "0x2FF332C", VA = "0x2FF332C")]
		public void Update()
		{
		}

		[Token(Token = "0x600043E")]
		[Address(RVA = "0x2FF3578", Offset = "0x2FF3578", VA = "0x2FF3578")]
		private void Raycasting()
		{
		}

		[Token(Token = "0x600043F")]
		[Address(RVA = "0x2FF2B40", Offset = "0x2FF2B40", VA = "0x2FF2B40")]
		private void UpdateTriggerEventBroadcasting()
		{
		}

		[Token(Token = "0x6000440")]
		[Address(RVA = "0x2FF36B8", Offset = "0x2FF36B8", VA = "0x2FF36B8")]
		private void UpdateEffectors()
		{
		}

		[Token(Token = "0x6000441")]
		[Address(RVA = "0x2FF37E4", Offset = "0x2FF37E4", VA = "0x2FF37E4")]
		private void OnPreFBBIK()
		{
		}

		[Token(Token = "0x6000442")]
		[Address(RVA = "0x2FF387C", Offset = "0x2FF387C", VA = "0x2FF387C")]
		private void OnPostFBBIK()
		{
		}

		[Token(Token = "0x6000443")]
		[Address(RVA = "0x2FF3954", Offset = "0x2FF3954", VA = "0x2FF3954")]
		private void OnFixTransforms()
		{
		}

		[Token(Token = "0x6000444")]
		[Address(RVA = "0x2FF396C", Offset = "0x2FF396C", VA = "0x2FF396C")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000445")]
		[Address(RVA = "0x2FF0B88", Offset = "0x2FF0B88", VA = "0x2FF0B88")]
		private bool IsValid(bool log)
		{
			return default(bool);
		}

		[Token(Token = "0x6000446")]
		[Address(RVA = "0x2FF1788", Offset = "0x2FF1788", VA = "0x2FF1788")]
		private bool TriggerIndexIsValid(int index)
		{
			return default(bool);
		}

		[Token(Token = "0x6000447")]
		[Address(RVA = "0x2FF3C5C", Offset = "0x2FF3C5C", VA = "0x2FF3C5C")]
		public InteractionSystem()
		{
		}
	}
	[Token(Token = "0x2000069")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x1441BE0", Offset = "0x1441BE0")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x1441BE0", Offset = "0x1441BE0")]
	public class InteractionTarget : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20001B4")]
		public class Multiplier
		{
			[Token(Token = "0x4000AE6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x144816C", Offset = "0x144816C")]
			public InteractionObject.WeightCurve.Type curve;

			[Token(Token = "0x4000AE7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14481A4", Offset = "0x14481A4")]
			public float multiplier;

			[Token(Token = "0x6000CC5")]
			[Address(RVA = "0x2938D54", Offset = "0x2938D54", VA = "0x2938D54")]
			public Multiplier()
			{
			}
		}

		[Token(Token = "0x4000380")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14450B4", Offset = "0x14450B4")]
		public FullBodyBipedEffector effectorType;

		[Token(Token = "0x4000381")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14450EC", Offset = "0x14450EC")]
		public Multiplier[] multipliers;

		[Token(Token = "0x4000382")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1445124", Offset = "0x1445124")]
		public float interactionSpeedMlp;

		[Token(Token = "0x4000383")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x144515C", Offset = "0x144515C")]
		public Transform pivot;

		[Token(Token = "0x4000384")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1445194", Offset = "0x1445194")]
		public Vector3 twistAxis;

		[Token(Token = "0x4000385")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14451CC", Offset = "0x14451CC")]
		public float twistWeight;

		[Token(Token = "0x4000386")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1445204", Offset = "0x1445204")]
		public float swingWeight;

		[Token(Token = "0x4000387")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x144523C", Offset = "0x144523C")]
		public bool rotateOnce;

		[Token(Token = "0x4000388")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Quaternion defaultLocalRotation;

		[Token(Token = "0x4000389")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Transform lastPivot;

		[Token(Token = "0x6000448")]
		[Address(RVA = "0x2FF4110", Offset = "0x2FF4110", VA = "0x2FF4110")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x144B080", Offset = "0x144B080")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x6000449")]
		[Address(RVA = "0x2FF415C", Offset = "0x2FF415C", VA = "0x2FF415C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x144B0B8", Offset = "0x144B0B8")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x600044A")]
		[Address(RVA = "0x2FF41A8", Offset = "0x2FF41A8", VA = "0x2FF41A8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x144B0F0", Offset = "0x144B0F0")]
		private void OpenTutorial1()
		{
		}

		[Token(Token = "0x600044B")]
		[Address(RVA = "0x2FF41F4", Offset = "0x2FF41F4", VA = "0x2FF41F4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x144B128", Offset = "0x144B128")]
		private void OpenTutorial2()
		{
		}

		[Token(Token = "0x600044C")]
		[Address(RVA = "0x2FF4240", Offset = "0x2FF4240", VA = "0x2FF4240")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x144B160", Offset = "0x144B160")]
		private void OpenTutorial3()
		{
		}

		[Token(Token = "0x600044D")]
		[Address(RVA = "0x2FF428C", Offset = "0x2FF428C", VA = "0x2FF428C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x144B198", Offset = "0x144B198")]
		private void OpenTutorial4()
		{
		}

		[Token(Token = "0x600044E")]
		[Address(RVA = "0x2FF42D8", Offset = "0x2FF42D8", VA = "0x2FF42D8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x144B1D0", Offset = "0x144B1D0")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600044F")]
		[Address(RVA = "0x2FF4324", Offset = "0x2FF4324", VA = "0x2FF4324")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x144B208", Offset = "0x144B208")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000450")]
		[Address(RVA = "0x2FEFC6C", Offset = "0x2FEFC6C", VA = "0x2FEFC6C")]
		public float GetValue(InteractionObject.WeightCurve.Type curveType)
		{
			return default(float);
		}

		[Token(Token = "0x6000451")]
		[Address(RVA = "0x2FEEC10", Offset = "0x2FEEC10", VA = "0x2FEEC10")]
		public void ResetRotation()
		{
		}

		[Token(Token = "0x6000452")]
		[Address(RVA = "0x2FED008", Offset = "0x2FED008", VA = "0x2FED008")]
		public void RotateTo(Vector3 position)
		{
		}

		[Token(Token = "0x6000453")]
		[Address(RVA = "0x2FF4370", Offset = "0x2FF4370", VA = "0x2FF4370")]
		public InteractionTarget()
		{
		}
	}
	[Token(Token = "0x200006A")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x1441C40", Offset = "0x1441C40")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x1441C40", Offset = "0x1441C40")]
	public class InteractionTrigger : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20001B5")]
		public class CharacterPosition
		{
			[Token(Token = "0x4000AE8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14481DC", Offset = "0x14481DC")]
			public bool use;

			[Token(Token = "0x4000AE9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1448214", Offset = "0x1448214")]
			public Vector2 offset;

			[Token(Token = "0x4000AEA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x144824C", Offset = "0x144824C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x144824C", Offset = "0x144824C")]
			public float angleOffset;

			[Token(Token = "0x4000AEB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14482A8", Offset = "0x14482A8")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x14482A8", Offset = "0x14482A8")]
			public float maxAngle;

			[Token(Token = "0x4000AEC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1448300", Offset = "0x1448300")]
			public float radius;

			[Token(Token = "0x4000AED")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1448338", Offset = "0x1448338")]
			public bool orbit;

			[Token(Token = "0x4000AEE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1448370", Offset = "0x1448370")]
			public bool fixYAxis;

			[Token(Token = "0x170000B1")]
			public Vector3 offset3D
			{
				[Token(Token = "0x6000CC6")]
				[Address(RVA = "0x29397E4", Offset = "0x29397E4", VA = "0x29397E4")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x170000B2")]
			public Vector3 direction3D
			{
				[Token(Token = "0x6000CC7")]
				[Address(RVA = "0x2939820", Offset = "0x2939820", VA = "0x2939820")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x6000CC8")]
			[Address(RVA = "0x2939918", Offset = "0x2939918", VA = "0x2939918")]
			public bool IsInRange(Transform character, Transform trigger, out float error)
			{
				return default(bool);
			}

			[Token(Token = "0x6000CC9")]
			[Address(RVA = "0x2939F94", Offset = "0x2939F94", VA = "0x2939F94")]
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
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14483A8", Offset = "0x14483A8")]
			public Collider lookAtTarget;

			[Token(Token = "0x4000AF0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14483E0", Offset = "0x14483E0")]
			public Vector3 direction;

			[Token(Token = "0x4000AF1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1448418", Offset = "0x1448418")]
			public float maxDistance;

			[Token(Token = "0x4000AF2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1448450", Offset = "0x1448450")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1448450", Offset = "0x1448450")]
			public float maxAngle;

			[Token(Token = "0x4000AF3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14484A8", Offset = "0x14484A8")]
			public bool fixYAxis;

			[Token(Token = "0x6000CCA")]
			[Address(RVA = "0x29392D0", Offset = "0x29392D0", VA = "0x29392D0")]
			public Quaternion GetRotation()
			{
				return default(Quaternion);
			}

			[Token(Token = "0x6000CCB")]
			[Address(RVA = "0x2939478", Offset = "0x2939478", VA = "0x2939478")]
			public bool IsInRange(Transform raycastFrom, RaycastHit hit, Transform trigger, out float error)
			{
				return default(bool);
			}

			[Token(Token = "0x6000CCC")]
			[Address(RVA = "0x2939758", Offset = "0x2939758", VA = "0x2939758")]
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
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1449560", Offset = "0x1449560")]
				public InteractionObject interactionObject;

				[Token(Token = "0x4000BD1")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1449598", Offset = "0x1449598")]
				public FullBodyBipedEffector[] effectors;

				[Token(Token = "0x6000D5C")]
				[Address(RVA = "0x2939FB8", Offset = "0x2939FB8", VA = "0x2939FB8")]
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
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1448550", Offset = "0x1448550")]
			public CharacterPosition characterPosition;

			[Token(Token = "0x4000AF7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1448588", Offset = "0x1448588")]
			public CameraPosition cameraPosition;

			[Token(Token = "0x4000AF8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14485C0", Offset = "0x14485C0")]
			public Interaction[] interactions;

			[Token(Token = "0x6000CCD")]
			[Address(RVA = "0x293914C", Offset = "0x293914C", VA = "0x293914C")]
			public bool IsInRange(Transform character, Transform raycastFrom, RaycastHit raycastHit, Transform trigger, out float maxError)
			{
				return default(bool);
			}

			[Token(Token = "0x6000CCE")]
			[Address(RVA = "0x2939FA8", Offset = "0x2939FA8", VA = "0x2939FA8")]
			public Range()
			{
			}
		}

		[Token(Token = "0x400038A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1445274", Offset = "0x1445274")]
		public Range[] ranges;

		[Token(Token = "0x6000454")]
		[Address(RVA = "0x2938D5C", Offset = "0x2938D5C", VA = "0x2938D5C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x144B240", Offset = "0x144B240")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x6000455")]
		[Address(RVA = "0x2938DA8", Offset = "0x2938DA8", VA = "0x2938DA8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x144B278", Offset = "0x144B278")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000456")]
		[Address(RVA = "0x2938DF4", Offset = "0x2938DF4", VA = "0x2938DF4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x144B2B0", Offset = "0x144B2B0")]
		private void OpenTutorial4()
		{
		}

		[Token(Token = "0x6000457")]
		[Address(RVA = "0x2938E40", Offset = "0x2938E40", VA = "0x2938E40")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x144B2E8", Offset = "0x144B2E8")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000458")]
		[Address(RVA = "0x2938E8C", Offset = "0x2938E8C", VA = "0x2938E8C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x144B320", Offset = "0x144B320")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000459")]
		[Address(RVA = "0x2938ED8", Offset = "0x2938ED8", VA = "0x2938ED8")]
		private void Start()
		{
		}

		[Token(Token = "0x600045A")]
		[Address(RVA = "0x2938EDC", Offset = "0x2938EDC", VA = "0x2938EDC")]
		public int GetBestRangeIndex(Transform character, Transform raycastFrom, RaycastHit raycastHit)
		{
			return default(int);
		}

		[Token(Token = "0x600045B")]
		[Address(RVA = "0x2939270", Offset = "0x2939270", VA = "0x2939270")]
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
			[Address(RVA = "0x2DB5640", Offset = "0x2DB5640", VA = "0x2DB5640")]
			public Map(Transform bone, Transform target)
			{
			}

			[Token(Token = "0x6000CD0")]
			[Address(RVA = "0x2DB5A44", Offset = "0x2DB5A44", VA = "0x2DB5A44")]
			public void StoreDefaultState()
			{
			}

			[Token(Token = "0x6000CD1")]
			[Address(RVA = "0x2DB59F8", Offset = "0x2DB59F8", VA = "0x2DB59F8")]
			public void FixTransform()
			{
			}

			[Token(Token = "0x6000CD2")]
			[Address(RVA = "0x2DB57F0", Offset = "0x2DB57F0", VA = "0x2DB57F0")]
			public void Update(float localRotationWeight, float localPositionWeight)
			{
			}
		}

		[Token(Token = "0x400038B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Map[] maps;

		[Token(Token = "0x600045C")]
		[Address(RVA = "0x2DB5358", Offset = "0x2DB5358", VA = "0x2DB5358", Slot = "7")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x144B358", Offset = "0x144B358")]
		public override void AutoMapping()
		{
		}

		[Token(Token = "0x600045D")]
		[Address(RVA = "0x2DB56E4", Offset = "0x2DB56E4", VA = "0x2DB56E4", Slot = "8")]
		protected override void InitiatePoser()
		{
		}

		[Token(Token = "0x600045E")]
		[Address(RVA = "0x2DB56E8", Offset = "0x2DB56E8", VA = "0x2DB56E8", Slot = "9")]
		protected override void UpdatePoser()
		{
		}

		[Token(Token = "0x600045F")]
		[Address(RVA = "0x2DB5990", Offset = "0x2DB5990", VA = "0x2DB5990", Slot = "10")]
		protected override void FixPoserTransforms()
		{
		}

		[Token(Token = "0x6000460")]
		[Address(RVA = "0x2DB567C", Offset = "0x2DB567C", VA = "0x2DB567C")]
		private void StoreDefaultState()
		{
		}

		[Token(Token = "0x6000461")]
		[Address(RVA = "0x2DB55A0", Offset = "0x2DB55A0", VA = "0x2DB55A0")]
		private Transform GetTargetNamed(string tName, Transform[] array)
		{
			return null;
		}

		[Token(Token = "0x6000462")]
		[Address(RVA = "0x2DB5A94", Offset = "0x2DB5A94", VA = "0x2DB5A94")]
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
		[Address(RVA = "0x2DBFAE8", Offset = "0x2DBFAE8", VA = "0x2DBFAE8", Slot = "7")]
		public override void AutoMapping()
		{
		}

		[Token(Token = "0x6000464")]
		[Address(RVA = "0x2DBFB9C", Offset = "0x2DBFB9C", VA = "0x2DBFB9C", Slot = "8")]
		protected override void InitiatePoser()
		{
		}

		[Token(Token = "0x6000465")]
		[Address(RVA = "0x2DBFD54", Offset = "0x2DBFD54", VA = "0x2DBFD54", Slot = "10")]
		protected override void FixPoserTransforms()
		{
		}

		[Token(Token = "0x6000466")]
		[Address(RVA = "0x2DBFE50", Offset = "0x2DBFE50", VA = "0x2DBFE50", Slot = "9")]
		protected override void UpdatePoser()
		{
		}

		[Token(Token = "0x6000467")]
		[Address(RVA = "0x2DBFBF8", Offset = "0x2DBFBF8", VA = "0x2DBFBF8")]
		protected void StoreDefaultState()
		{
		}

		[Token(Token = "0x6000468")]
		[Address(RVA = "0x2DC0200", Offset = "0x2DC0200", VA = "0x2DC0200")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x14452AC", Offset = "0x14452AC")]
		public float weight;

		[Token(Token = "0x4000393")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x14452C4", Offset = "0x14452C4")]
		public float localRotationWeight;

		[Token(Token = "0x4000394")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x14452DC", Offset = "0x14452DC")]
		public float localPositionWeight;

		[Token(Token = "0x4000395")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private bool initiated;

		[Token(Token = "0x6000469")]
		public abstract void AutoMapping();

		[Token(Token = "0x600046A")]
		[Address(RVA = "0x293CC60", Offset = "0x293CC60", VA = "0x293CC60")]
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
		[Address(RVA = "0x293CC6C", Offset = "0x293CC6C", VA = "0x293CC6C", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x600046F")]
		[Address(RVA = "0x293CCC0", Offset = "0x293CCC0", VA = "0x293CCC0", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x6000470")]
		[Address(RVA = "0x293CCFC", Offset = "0x293CCFC", VA = "0x293CCFC", Slot = "6")]
		protected override void FixTransforms()
		{
		}

		[Token(Token = "0x6000471")]
		[Address(RVA = "0x293CD14", Offset = "0x293CD14", VA = "0x293CD14")]
		protected Poser()
		{
		}
	}
	[Token(Token = "0x200006E")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x1441CA0", Offset = "0x1441CA0")]
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
			[Address(RVA = "0x293D2B0", Offset = "0x293D2B0", VA = "0x293D2B0")]
			public Rigidbone(Rigidbody r)
			{
			}

			[Token(Token = "0x6000CD4")]
			[Address(RVA = "0x293DEBC", Offset = "0x293DEBC", VA = "0x293DEBC")]
			public void RecordVelocity()
			{
			}

			[Token(Token = "0x6000CD5")]
			[Address(RVA = "0x293DCA0", Offset = "0x293DCA0", VA = "0x293DCA0")]
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
			[Address(RVA = "0x293D40C", Offset = "0x293D40C", VA = "0x293D40C")]
			public Child(Transform transform)
			{
			}

			[Token(Token = "0x6000CD7")]
			[Address(RVA = "0x293E054", Offset = "0x293E054", VA = "0x293E054")]
			public void FixTransform(float weight)
			{
			}

			[Token(Token = "0x6000CD8")]
			[Address(RVA = "0x293E004", Offset = "0x293E004", VA = "0x293E004")]
			public void StoreLocalState()
			{
			}
		}

		[Token(Token = "0x20001BB")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x14420F4", Offset = "0x14420F4")]
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
				[Address(RVA = "0x293E634", Offset = "0x293E634", VA = "0x293E634", Slot = "4")]
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
				[Address(RVA = "0x293E69C", Offset = "0x293E69C", VA = "0x293E69C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000CD9")]
			[Address(RVA = "0x293D46C", Offset = "0x293D46C", VA = "0x293D46C")]
			[DebuggerHidden]
			public <DisableRagdollSmooth>d__21(int <>1__state)
			{
			}

			[Token(Token = "0x6000CDA")]
			[Address(RVA = "0x293E3EC", Offset = "0x293E3EC", VA = "0x293E3EC", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000CDB")]
			[Address(RVA = "0x293E3F0", Offset = "0x293E3F0", VA = "0x293E3F0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000CDD")]
			[Address(RVA = "0x293E63C", Offset = "0x293E63C", VA = "0x293E63C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000396")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14452F4", Offset = "0x14452F4")]
		public IK ik;

		[Token(Token = "0x4000397")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x144532C", Offset = "0x144532C")]
		public float ragdollToAnimationTime;

		[Token(Token = "0x4000398")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1445364", Offset = "0x1445364")]
		public bool applyIkOnRagdoll;

		[Token(Token = "0x4000399")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x144539C", Offset = "0x144539C")]
		public float applyVelocity;

		[Token(Token = "0x400039A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14453D4", Offset = "0x14453D4")]
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
			[Address(RVA = "0x293CD74", Offset = "0x293CD74", VA = "0x293CD74")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700005E")]
		private bool ikUsed
		{
			[Token(Token = "0x600047F")]
			[Address(RVA = "0x293D858", Offset = "0x293D858", VA = "0x293D858")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000472")]
		[Address(RVA = "0x293CD3C", Offset = "0x293CD3C", VA = "0x293CD3C")]
		public void EnableRagdoll()
		{
		}

		[Token(Token = "0x6000473")]
		[Address(RVA = "0x293CDEC", Offset = "0x293CDEC", VA = "0x293CDEC")]
		public void DisableRagdoll()
		{
		}

		[Token(Token = "0x6000474")]
		[Address(RVA = "0x293CF1C", Offset = "0x293CF1C", VA = "0x293CF1C")]
		public void Start()
		{
		}

		[Token(Token = "0x6000475")]
		[Address(RVA = "0x293CEAC", Offset = "0x293CEAC", VA = "0x293CEAC")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x144B390", Offset = "0x144B390")]
		private IEnumerator DisableRagdollSmooth()
		{
			return null;
		}

		[Token(Token = "0x6000476")]
		[Address(RVA = "0x293D498", Offset = "0x293D498", VA = "0x293D498")]
		private void Update()
		{
		}

		[Token(Token = "0x6000477")]
		[Address(RVA = "0x293D6E4", Offset = "0x293D6E4", VA = "0x293D6E4")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000478")]
		[Address(RVA = "0x293D79C", Offset = "0x293D79C", VA = "0x293D79C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000479")]
		[Address(RVA = "0x293D9DC", Offset = "0x293D9DC", VA = "0x293D9DC")]
		private void AfterLastIK()
		{
		}

		[Token(Token = "0x600047A")]
		[Address(RVA = "0x293D81C", Offset = "0x293D81C", VA = "0x293D81C")]
		private void AfterAnimation()
		{
		}

		[Token(Token = "0x600047B")]
		[Address(RVA = "0x293D998", Offset = "0x293D998", VA = "0x293D998")]
		private void OnFinalPose()
		{
		}

		[Token(Token = "0x600047C")]
		[Address(RVA = "0x293DA78", Offset = "0x293DA78", VA = "0x293DA78")]
		private void RagdollEnabler()
		{
		}

		[Token(Token = "0x600047E")]
		[Address(RVA = "0x293DA10", Offset = "0x293DA10", VA = "0x293DA10")]
		private void RecordVelocities()
		{
		}

		[Token(Token = "0x6000480")]
		[Address(RVA = "0x293CE44", Offset = "0x293CE44", VA = "0x293CE44")]
		private void StoreLocalState()
		{
		}

		[Token(Token = "0x6000481")]
		[Address(RVA = "0x293D724", Offset = "0x293D724", VA = "0x293D724")]
		private void FixTransforms(float weight)
		{
		}

		[Token(Token = "0x6000482")]
		[Address(RVA = "0x293E21C", Offset = "0x293E21C", VA = "0x293E21C")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000483")]
		[Address(RVA = "0x293E320", Offset = "0x293E320", VA = "0x293E320")]
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
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x144541C", Offset = "0x144541C")]
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
			[Address(RVA = "0x294007C", Offset = "0x294007C", VA = "0x294007C")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000060")]
		public Vector3 crossAxis
		{
			[Token(Token = "0x600048A")]
			[Address(RVA = "0x29400B8", Offset = "0x29400B8", VA = "0x29400B8")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000061")]
		public bool defaultLocalRotationOverride
		{
			[Token(Token = "0x600048B")]
			[Address(RVA = "0x2940188", Offset = "0x2940188", VA = "0x2940188")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x144B3F4", Offset = "0x144B3F4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600048C")]
			[Address(RVA = "0x2940190", Offset = "0x2940190", VA = "0x2940190")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x144B404", Offset = "0x144B404")]
			private set
			{
			}
		}

		[Token(Token = "0x6000484")]
		[Address(RVA = "0x293FCE0", Offset = "0x293FCE0", VA = "0x293FCE0")]
		public void SetDefaultLocalRotation()
		{
		}

		[Token(Token = "0x6000485")]
		[Address(RVA = "0x293FD28", Offset = "0x293FD28", VA = "0x293FD28")]
		public void SetDefaultLocalRotation(Quaternion localRotation)
		{
		}

		[Token(Token = "0x6000486")]
		[Address(RVA = "0x293FD40", Offset = "0x293FD40", VA = "0x293FD40")]
		public Quaternion GetLimitedLocalRotation(Quaternion localRotation, out bool changed)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000487")]
		[Address(RVA = "0x293FFD4", Offset = "0x293FFD4", VA = "0x293FFD4")]
		public bool Apply()
		{
			return default(bool);
		}

		[Token(Token = "0x6000488")]
		[Address(RVA = "0x2940044", Offset = "0x2940044", VA = "0x2940044")]
		public void Disable()
		{
		}

		[Token(Token = "0x600048D")]
		protected abstract Quaternion LimitRotation(Quaternion rotation);

		[Token(Token = "0x600048E")]
		[Address(RVA = "0x293FEE4", Offset = "0x293FEE4", VA = "0x293FEE4")]
		private void Awake()
		{
		}

		[Token(Token = "0x600048F")]
		[Address(RVA = "0x294019C", Offset = "0x294019C", VA = "0x294019C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000490")]
		[Address(RVA = "0x29401A0", Offset = "0x29401A0", VA = "0x29401A0")]
		public void LogWarning(string message)
		{
		}

		[Token(Token = "0x6000491")]
		[Address(RVA = "0x29401D0", Offset = "0x29401D0", VA = "0x29401D0")]
		protected static Quaternion Limit1DOF(Quaternion rotation, Vector3 axis)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000492")]
		[Address(RVA = "0x29402B4", Offset = "0x29402B4", VA = "0x29402B4")]
		protected static Quaternion LimitTwist(Quaternion rotation, Vector3 axis, Vector3 orthoAxis, float twistLimit)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000493")]
		[Address(RVA = "0x2940530", Offset = "0x2940530", VA = "0x2940530")]
		protected static float GetOrthogonalAngle(Vector3 v1, Vector3 v2, Vector3 normal)
		{
			return default(float);
		}

		[Token(Token = "0x6000494")]
		[Address(RVA = "0x29405EC", Offset = "0x29405EC", VA = "0x29405EC")]
		protected RotationLimit()
		{
		}
	}
	[Token(Token = "0x2000070")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x1441D04", Offset = "0x1441D04")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x1441D04", Offset = "0x1441D04")]
	public class RotationLimitAngle : RotationLimit
	{
		[Token(Token = "0x40003AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x144542C", Offset = "0x144542C")]
		public float limit;

		[Token(Token = "0x40003AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1445448", Offset = "0x1445448")]
		public float twistLimit;

		[Token(Token = "0x6000495")]
		[Address(RVA = "0x2940664", Offset = "0x2940664", VA = "0x2940664")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x144B414", Offset = "0x144B414")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x6000496")]
		[Address(RVA = "0x29406B0", Offset = "0x29406B0", VA = "0x29406B0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x144B44C", Offset = "0x144B44C")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000497")]
		[Address(RVA = "0x29406FC", Offset = "0x29406FC", VA = "0x29406FC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x144B484", Offset = "0x144B484")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000498")]
		[Address(RVA = "0x2940748", Offset = "0x2940748", VA = "0x2940748")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x144B4BC", Offset = "0x144B4BC")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000499")]
		[Address(RVA = "0x2940794", Offset = "0x2940794", VA = "0x2940794", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600049A")]
		[Address(RVA = "0x294084C", Offset = "0x294084C", VA = "0x294084C")]
		private Quaternion LimitSwing(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600049B")]
		[Address(RVA = "0x2940A94", Offset = "0x2940A94", VA = "0x2940A94")]
		public RotationLimitAngle()
		{
		}
	}
	[Token(Token = "0x2000071")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x1441D64", Offset = "0x1441D64")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x1441D64", Offset = "0x1441D64")]
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
		[Address(RVA = "0x2940AA4", Offset = "0x2940AA4", VA = "0x2940AA4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x144B4F4", Offset = "0x144B4F4")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x600049D")]
		[Address(RVA = "0x2940AF0", Offset = "0x2940AF0", VA = "0x2940AF0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x144B52C", Offset = "0x144B52C")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x600049E")]
		[Address(RVA = "0x2940B3C", Offset = "0x2940B3C", VA = "0x2940B3C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x144B564", Offset = "0x144B564")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600049F")]
		[Address(RVA = "0x2940B88", Offset = "0x2940B88", VA = "0x2940B88")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x144B59C", Offset = "0x144B59C")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60004A0")]
		[Address(RVA = "0x2940BD4", Offset = "0x2940BD4", VA = "0x2940BD4", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60004A1")]
		[Address(RVA = "0x2940BFC", Offset = "0x2940BFC", VA = "0x2940BFC")]
		private Quaternion LimitHinge(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60004A2")]
		[Address(RVA = "0x2940EFC", Offset = "0x2940EFC", VA = "0x2940EFC")]
		public RotationLimitHinge()
		{
		}
	}
	[Token(Token = "0x2000072")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x1441DC4", Offset = "0x1441DC4")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x1441DC4", Offset = "0x1441DC4")]
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
				[Address(RVA = "0x2942E98", Offset = "0x2942E98", VA = "0x2942E98")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x170000B6")]
			public Vector3 a
			{
				[Token(Token = "0x6000CE0")]
				[Address(RVA = "0x2942ED0", Offset = "0x2942ED0", VA = "0x2942ED0")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x170000B7")]
			public Vector3 b
			{
				[Token(Token = "0x6000CE1")]
				[Address(RVA = "0x2942F0C", Offset = "0x2942F0C", VA = "0x2942F0C")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x170000B8")]
			public Vector3 c
			{
				[Token(Token = "0x6000CE2")]
				[Address(RVA = "0x2942F48", Offset = "0x2942F48", VA = "0x2942F48")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x170000B9")]
			public bool isValid
			{
				[Token(Token = "0x6000CE4")]
				[Address(RVA = "0x2941FFC", Offset = "0x2941FFC", VA = "0x2941FFC")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x6000CE3")]
			[Address(RVA = "0x2942648", Offset = "0x2942648", VA = "0x2942648")]
			public ReachCone(Vector3 _o, Vector3 _a, Vector3 _b, Vector3 _c)
			{
			}

			[Token(Token = "0x6000CE5")]
			[Address(RVA = "0x29427A8", Offset = "0x29427A8", VA = "0x29427A8")]
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
			[Address(RVA = "0x294200C", Offset = "0x294200C", VA = "0x294200C")]
			public LimitPoint()
			{
			}
		}

		[Token(Token = "0x40003B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1445474", Offset = "0x1445474")]
		public float twistLimit;

		[Token(Token = "0x40003B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1445490", Offset = "0x1445490")]
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
		[Address(RVA = "0x2940F84", Offset = "0x2940F84", VA = "0x2940F84")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x144B5D4", Offset = "0x144B5D4")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x60004A4")]
		[Address(RVA = "0x2940FD0", Offset = "0x2940FD0", VA = "0x2940FD0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x144B60C", Offset = "0x144B60C")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x60004A5")]
		[Address(RVA = "0x294101C", Offset = "0x294101C", VA = "0x294101C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x144B644", Offset = "0x144B644")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60004A6")]
		[Address(RVA = "0x2941068", Offset = "0x2941068", VA = "0x2941068")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x144B67C", Offset = "0x144B67C")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60004A7")]
		[Address(RVA = "0x29410B4", Offset = "0x29410B4", VA = "0x29410B4")]
		public void SetLimitPoints(LimitPoint[] points)
		{
		}

		[Token(Token = "0x60004A8")]
		[Address(RVA = "0x2941598", Offset = "0x2941598", VA = "0x2941598", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60004A9")]
		[Address(RVA = "0x2941690", Offset = "0x2941690", VA = "0x2941690")]
		private void Start()
		{
		}

		[Token(Token = "0x60004AA")]
		[Address(RVA = "0x2941C48", Offset = "0x2941C48", VA = "0x2941C48")]
		public void ResetToDefault()
		{
		}

		[Token(Token = "0x60004AB")]
		[Address(RVA = "0x2941150", Offset = "0x2941150", VA = "0x2941150")]
		public void BuildReachCones()
		{
		}

		[Token(Token = "0x60004AC")]
		[Address(RVA = "0x2942090", Offset = "0x2942090", VA = "0x2942090")]
		private Vector3[] SmoothPoints()
		{
			return null;
		}

		[Token(Token = "0x60004AD")]
		[Address(RVA = "0x2942968", Offset = "0x2942968", VA = "0x2942968")]
		private float GetScalar(int k)
		{
			return default(float);
		}

		[Token(Token = "0x60004AE")]
		[Address(RVA = "0x29429AC", Offset = "0x29429AC", VA = "0x29429AC")]
		private Vector3 PointToTangentPlane(Vector3 p, float r)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60004AF")]
		[Address(RVA = "0x2942AF4", Offset = "0x2942AF4", VA = "0x2942AF4")]
		private Vector3 TangentPointToSphere(Vector3 q, float r)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60004B0")]
		[Address(RVA = "0x2941910", Offset = "0x2941910", VA = "0x2941910")]
		private Quaternion LimitSwing(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60004B1")]
		[Address(RVA = "0x2942C84", Offset = "0x2942C84", VA = "0x2942C84")]
		private int GetReachCone(Vector3 L)
		{
			return default(int);
		}

		[Token(Token = "0x60004B2")]
		[Address(RVA = "0x2942E34", Offset = "0x2942E34", VA = "0x2942E34")]
		public RotationLimitPolygonal()
		{
		}
	}
	[Token(Token = "0x2000073")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x1441E24", Offset = "0x1441E24")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x1441E24", Offset = "0x1441E24")]
	public class RotationLimitSpline : RotationLimit
	{
		[Token(Token = "0x40003B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1445550", Offset = "0x1445550")]
		public float twistLimit;

		[Token(Token = "0x40003BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		[HideInInspector]
		public AnimationCurve spline;

		[Token(Token = "0x60004B3")]
		[Address(RVA = "0x2942F84", Offset = "0x2942F84", VA = "0x2942F84")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x144B6B4", Offset = "0x144B6B4")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x60004B4")]
		[Address(RVA = "0x2942FD0", Offset = "0x2942FD0", VA = "0x2942FD0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x144B6EC", Offset = "0x144B6EC")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x60004B5")]
		[Address(RVA = "0x294301C", Offset = "0x294301C", VA = "0x294301C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x144B724", Offset = "0x144B724")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60004B6")]
		[Address(RVA = "0x2943068", Offset = "0x2943068", VA = "0x2943068")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x144B75C", Offset = "0x144B75C")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60004B7")]
		[Address(RVA = "0x29430B4", Offset = "0x29430B4", VA = "0x29430B4")]
		public void SetSpline(Keyframe[] keyframes)
		{
		}

		[Token(Token = "0x60004B8")]
		[Address(RVA = "0x29430D0", Offset = "0x29430D0", VA = "0x29430D0", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60004B9")]
		[Address(RVA = "0x2943188", Offset = "0x2943188", VA = "0x2943188")]
		public Quaternion LimitSwing(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60004BA")]
		[Address(RVA = "0x29434B4", Offset = "0x29434B4", VA = "0x29434B4")]
		public RotationLimitSpline()
		{
		}
	}
	[Token(Token = "0x2000074")]
	public class AimController : MonoBehaviour
	{
		[Token(Token = "0x20001BE")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1442104", Offset = "0x1442104")]
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
				[Address(RVA = "0x2A73A80", Offset = "0x2A73A80", VA = "0x2A73A80", Slot = "4")]
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
				[Address(RVA = "0x2A73AE8", Offset = "0x2A73AE8", VA = "0x2A73AE8", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000CE7")]
			[Address(RVA = "0x2A7385C", Offset = "0x2A7385C", VA = "0x2A7385C")]
			[DebuggerHidden]
			public <TurnToTarget>d__33(int <>1__state)
			{
			}

			[Token(Token = "0x6000CE8")]
			[Address(RVA = "0x2A7395C", Offset = "0x2A7395C", VA = "0x2A7395C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000CE9")]
			[Address(RVA = "0x2A73960", Offset = "0x2A73960", VA = "0x2A73960", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000CEB")]
			[Address(RVA = "0x2A73A88", Offset = "0x2A73A88", VA = "0x2A73A88", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40003BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14455A4", Offset = "0x14455A4")]
		public AimIK ik;

		[Token(Token = "0x40003BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14455DC", Offset = "0x14455DC")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x14455DC", Offset = "0x14455DC")]
		public float weight;

		[Token(Token = "0x40003BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x1445630", Offset = "0x1445630")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1445630", Offset = "0x1445630")]
		public Transform target;

		[Token(Token = "0x40003BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1445690", Offset = "0x1445690")]
		public float targetSwitchSmoothTime;

		[Token(Token = "0x40003BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14456C8", Offset = "0x14456C8")]
		public float weightSmoothTime;

		[Token(Token = "0x40003C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x1445700", Offset = "0x1445700")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1445700", Offset = "0x1445700")]
		public bool smoothTurnTowardsTarget;

		[Token(Token = "0x40003C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1445760", Offset = "0x1445760")]
		public float maxRadiansDelta;

		[Token(Token = "0x40003C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1445798", Offset = "0x1445798")]
		public float maxMagnitudeDelta;

		[Token(Token = "0x40003C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14457D0", Offset = "0x14457D0")]
		public float slerpSpeed;

		[Token(Token = "0x40003C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1445808", Offset = "0x1445808")]
		public Vector3 pivotOffsetFromRoot;

		[Token(Token = "0x40003C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1445840", Offset = "0x1445840")]
		public float minDistance;

		[Token(Token = "0x40003C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1445878", Offset = "0x1445878")]
		public Vector3 offset;

		[Token(Token = "0x40003C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x14458B0", Offset = "0x14458B0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14458B0", Offset = "0x14458B0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x14458B0", Offset = "0x14458B0")]
		public float maxRootAngle;

		[Token(Token = "0x40003C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x144592C", Offset = "0x144592C")]
		public bool turnToTarget;

		[Token(Token = "0x40003C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1445964", Offset = "0x1445964")]
		public float turnToTargetTime;

		[Token(Token = "0x40003CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x144599C", Offset = "0x144599C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x144599C", Offset = "0x144599C")]
		public bool useAnimatedAimDirection;

		[Token(Token = "0x40003CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14459FC", Offset = "0x14459FC")]
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
			[Address(RVA = "0x2A72A5C", Offset = "0x2A72A5C", VA = "0x2A72A5C")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x60004BB")]
		[Address(RVA = "0x2A72960", Offset = "0x2A72960", VA = "0x2A72960")]
		private void Start()
		{
		}

		[Token(Token = "0x60004BC")]
		[Address(RVA = "0x2A72BA8", Offset = "0x2A72BA8", VA = "0x2A72BA8")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60004BE")]
		[Address(RVA = "0x2A732E0", Offset = "0x2A732E0", VA = "0x2A732E0")]
		private void ApplyMinDistance()
		{
		}

		[Token(Token = "0x60004BF")]
		[Address(RVA = "0x2A7347C", Offset = "0x2A7347C", VA = "0x2A7347C")]
		private void RootRotation()
		{
		}

		[Token(Token = "0x60004C0")]
		[Address(RVA = "0x2A737EC", Offset = "0x2A737EC", VA = "0x2A737EC")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x144B794", Offset = "0x144B794")]
		private IEnumerator TurnToTarget()
		{
			return null;
		}

		[Token(Token = "0x60004C1")]
		[Address(RVA = "0x2A73888", Offset = "0x2A73888", VA = "0x2A73888")]
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
			[Address(RVA = "0x2A779AC", Offset = "0x2A779AC", VA = "0x2A779AC")]
			public bool IsInDirection(Vector3 d)
			{
				return default(bool);
			}

			[Token(Token = "0x6000CEE")]
			[Address(RVA = "0x2A77D18", Offset = "0x2A77D18", VA = "0x2A77D18")]
			public void SetAngleBuffer(float value)
			{
			}

			[Token(Token = "0x6000CEF")]
			[Address(RVA = "0x2A77D20", Offset = "0x2A77D20", VA = "0x2A77D20")]
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
		[Address(RVA = "0x2A778D0", Offset = "0x2A778D0", VA = "0x2A778D0")]
		public Pose GetPose(Vector3 localDirection)
		{
			return null;
		}

		[Token(Token = "0x60004C3")]
		[Address(RVA = "0x2A77C44", Offset = "0x2A77C44", VA = "0x2A77C44")]
		public void SetPoseActive(Pose pose)
		{
		}

		[Token(Token = "0x60004C4")]
		[Address(RVA = "0x2A77CB0", Offset = "0x2A77CB0", VA = "0x2A77CB0")]
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
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14495D0", Offset = "0x14495D0")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x4000BD3")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1449608", Offset = "0x1449608")]
				public float weight;

				[Token(Token = "0x6000D5D")]
				[Address(RVA = "0x2A78310", Offset = "0x2A78310", VA = "0x2A78310")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x4000B1D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14485F8", Offset = "0x14485F8")]
			public Transform transform;

			[Token(Token = "0x4000B1E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1448630", Offset = "0x1448630")]
			public Transform relativeTo;

			[Token(Token = "0x4000B1F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1448668", Offset = "0x1448668")]
			public EffectorLink[] effectorLinks;

			[Token(Token = "0x4000B20")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14486A0", Offset = "0x14486A0")]
			public float verticalWeight;

			[Token(Token = "0x4000B21")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14486D8", Offset = "0x14486D8")]
			public float horizontalWeight;

			[Token(Token = "0x4000B22")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1448710", Offset = "0x1448710")]
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
			[Address(RVA = "0x2A77E7C", Offset = "0x2A77E7C", VA = "0x2A77E7C")]
			public void Update(IKSolverFullBodyBiped solver, float w, float deltaTime)
			{
			}

			[Token(Token = "0x6000CF1")]
			[Address(RVA = "0x2A782E8", Offset = "0x2A782E8", VA = "0x2A782E8")]
			private static Vector3 Multiply(Vector3 v1, Vector3 v2)
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000CF2")]
			[Address(RVA = "0x2A782F8", Offset = "0x2A782F8", VA = "0x2A782F8")]
			public Body()
			{
			}
		}

		[Token(Token = "0x40003D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1445A34", Offset = "0x1445A34")]
		public Body[] bodies;

		[Token(Token = "0x60004C5")]
		[Address(RVA = "0x2A77D3C", Offset = "0x2A77D3C", VA = "0x2A77D3C", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x60004C6")]
		[Address(RVA = "0x2A782E0", Offset = "0x2A782E0", VA = "0x2A782E0")]
		public Amplifier()
		{
		}
	}
	[Token(Token = "0x2000077")]
	public class BodyTilt : OffsetModifier
	{
		[Token(Token = "0x40003D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1445A6C", Offset = "0x1445A6C")]
		public float tiltSpeed;

		[Token(Token = "0x40003DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1445AA4", Offset = "0x1445AA4")]
		public float tiltSensitivity;

		[Token(Token = "0x40003DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1445ADC", Offset = "0x1445ADC")]
		public OffsetPose poseLeft;

		[Token(Token = "0x40003DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1445B14", Offset = "0x1445B14")]
		public OffsetPose poseRight;

		[Token(Token = "0x40003DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float tiltAngle;

		[Token(Token = "0x40003DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Vector3 lastForward;

		[Token(Token = "0x60004C7")]
		[Address(RVA = "0x2A7981C", Offset = "0x2A7981C", VA = "0x2A7981C", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60004C8")]
		[Address(RVA = "0x2A79864", Offset = "0x2A79864", VA = "0x2A79864", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x60004C9")]
		[Address(RVA = "0x2A79A94", Offset = "0x2A79A94", VA = "0x2A79A94")]
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
		[Address(RVA = "0x2A7D140", Offset = "0x2A7D140", VA = "0x2A7D140")]
		private void Start()
		{
		}

		[Token(Token = "0x60004CB")]
		[Address(RVA = "0x2A7D1D4", Offset = "0x2A7D1D4", VA = "0x2A7D1D4")]
		private void Update()
		{
		}

		[Token(Token = "0x60004CC")]
		[Address(RVA = "0x2A7D2A4", Offset = "0x2A7D2A4", VA = "0x2A7D2A4")]
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
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1448748", Offset = "0x1448748")]
			public string name;

			[Token(Token = "0x4000B27")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1448780", Offset = "0x1448780")]
			public Collider collider;

			[Token(Token = "0x4000B28")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14487B8", Offset = "0x14487B8")]
			[SerializeField]
			private float crossFadeTime;

			[Token(Token = "0x4000B29")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1448804", Offset = "0x1448804")]
			private float <crossFader>k__BackingField;

			[Token(Token = "0x4000B2A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1448814", Offset = "0x1448814")]
			private float <timer>k__BackingField;

			[Token(Token = "0x4000B2B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1448824", Offset = "0x1448824")]
			private Vector3 <force>k__BackingField;

			[Token(Token = "0x4000B2C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1448834", Offset = "0x1448834")]
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
				[Address(RVA = "0x2DC02C4", Offset = "0x2DC02C4", VA = "0x2DC02C4")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x170000BD")]
			protected float crossFader
			{
				[Token(Token = "0x6000CF4")]
				[Address(RVA = "0x2DC086C", Offset = "0x2DC086C", VA = "0x2DC086C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x144BD98", Offset = "0x144BD98")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000CF5")]
				[Address(RVA = "0x2DC0874", Offset = "0x2DC0874", VA = "0x2DC0874")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x144BDA8", Offset = "0x144BDA8")]
				private set
				{
				}
			}

			[Token(Token = "0x170000BE")]
			protected float timer
			{
				[Token(Token = "0x6000CF6")]
				[Address(RVA = "0x2DC087C", Offset = "0x2DC087C", VA = "0x2DC087C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x144BDB8", Offset = "0x144BDB8")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000CF7")]
				[Address(RVA = "0x2DC0884", Offset = "0x2DC0884", VA = "0x2DC0884")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x144BDC8", Offset = "0x144BDC8")]
				private set
				{
				}
			}

			[Token(Token = "0x170000BF")]
			protected Vector3 force
			{
				[Token(Token = "0x6000CF8")]
				[Address(RVA = "0x2DC088C", Offset = "0x2DC088C", VA = "0x2DC088C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x144BDD8", Offset = "0x144BDD8")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000CF9")]
				[Address(RVA = "0x2DC0898", Offset = "0x2DC0898", VA = "0x2DC0898")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x144BDE8", Offset = "0x144BDE8")]
				private set
				{
				}
			}

			[Token(Token = "0x170000C0")]
			protected Vector3 point
			{
				[Token(Token = "0x6000CFA")]
				[Address(RVA = "0x2DC08A4", Offset = "0x2DC08A4", VA = "0x2DC08A4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x144BDF8", Offset = "0x144BDF8")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000CFB")]
				[Address(RVA = "0x2DC08B0", Offset = "0x2DC08B0", VA = "0x2DC08B0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x144BE08", Offset = "0x144BE08")]
				private set
				{
				}
			}

			[Token(Token = "0x6000CFC")]
			[Address(RVA = "0x2DC0738", Offset = "0x2DC0738", VA = "0x2DC0738")]
			public void Hit(Vector3 force, Vector3 point)
			{
			}

			[Token(Token = "0x6000CFD")]
			[Address(RVA = "0x2DC03AC", Offset = "0x2DC03AC", VA = "0x2DC03AC")]
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
			[Address(RVA = "0x2DC08BC", Offset = "0x2DC08BC", VA = "0x2DC08BC")]
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
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1449640", Offset = "0x1449640")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x4000BD5")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1449678", Offset = "0x1449678")]
				public float weight;

				[Token(Token = "0x4000BD6")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				private Vector3 lastValue;

				[Token(Token = "0x4000BD7")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
				private Vector3 current;

				[Token(Token = "0x6000D5E")]
				[Address(RVA = "0x2DC1228", Offset = "0x2DC1228", VA = "0x2DC1228")]
				public void Apply(IKSolverFullBodyBiped solver, Vector3 offset, float crossFader)
				{
				}

				[Token(Token = "0x6000D5F")]
				[Address(RVA = "0x2DC101C", Offset = "0x2DC101C", VA = "0x2DC101C")]
				public void CrossFadeStart()
				{
				}

				[Token(Token = "0x6000D60")]
				[Address(RVA = "0x2DC1364", Offset = "0x2DC1364", VA = "0x2DC1364")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x4000B30")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1448844", Offset = "0x1448844")]
			public AnimationCurve offsetInForceDirection;

			[Token(Token = "0x4000B31")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x144887C", Offset = "0x144887C")]
			public AnimationCurve offsetInUpDirection;

			[Token(Token = "0x4000B32")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14488B4", Offset = "0x14488B4")]
			public EffectorLink[] effectorLinks;

			[Token(Token = "0x6000D02")]
			[Address(RVA = "0x2DC0E38", Offset = "0x2DC0E38", VA = "0x2DC0E38", Slot = "4")]
			protected override float GetLength()
			{
				return default(float);
			}

			[Token(Token = "0x6000D03")]
			[Address(RVA = "0x2DC0FB0", Offset = "0x2DC0FB0", VA = "0x2DC0FB0", Slot = "5")]
			protected override void CrossFadeStart()
			{
			}

			[Token(Token = "0x6000D04")]
			[Address(RVA = "0x2DC1030", Offset = "0x2DC1030", VA = "0x2DC1030", Slot = "6")]
			protected override void OnApply(IKSolverFullBodyBiped solver, float weight)
			{
			}

			[Token(Token = "0x6000D05")]
			[Address(RVA = "0x2DC1350", Offset = "0x2DC1350", VA = "0x2DC1350")]
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
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14496B0", Offset = "0x14496B0")]
				public Transform bone;

				[Token(Token = "0x4000BD9")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14496E8", Offset = "0x14496E8")]
				[AttributeAttribute(Name = "RangeAttribute", RVA = "0x14496E8", Offset = "0x14496E8")]
				public float weight;

				[Token(Token = "0x4000BDA")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
				private Quaternion lastValue;

				[Token(Token = "0x4000BDB")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
				private Quaternion current;

				[Token(Token = "0x6000D61")]
				[Address(RVA = "0x2DC0C40", Offset = "0x2DC0C40", VA = "0x2DC0C40")]
				public void Apply(IKSolverFullBodyBiped solver, Quaternion offset, float crossFader)
				{
				}

				[Token(Token = "0x6000D62")]
				[Address(RVA = "0x2DC09D8", Offset = "0x2DC09D8", VA = "0x2DC09D8")]
				public void CrossFadeStart()
				{
				}

				[Token(Token = "0x6000D63")]
				[Address(RVA = "0x2DC0DB0", Offset = "0x2DC0DB0", VA = "0x2DC0DB0")]
				public BoneLink()
				{
				}
			}

			[Token(Token = "0x4000B33")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14488EC", Offset = "0x14488EC")]
			public AnimationCurve aroundCenterOfMass;

			[Token(Token = "0x4000B34")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1448924", Offset = "0x1448924")]
			public BoneLink[] boneLinks;

			[Token(Token = "0x4000B35")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private Rigidbody rigidbody;

			[Token(Token = "0x6000D06")]
			[Address(RVA = "0x2DC08D0", Offset = "0x2DC08D0", VA = "0x2DC08D0", Slot = "4")]
			protected override float GetLength()
			{
				return default(float);
			}

			[Token(Token = "0x6000D07")]
			[Address(RVA = "0x2DC0974", Offset = "0x2DC0974", VA = "0x2DC0974", Slot = "5")]
			protected override void CrossFadeStart()
			{
			}

			[Token(Token = "0x6000D08")]
			[Address(RVA = "0x2DC09E4", Offset = "0x2DC09E4", VA = "0x2DC09E4", Slot = "6")]
			protected override void OnApply(IKSolverFullBodyBiped solver, float weight)
			{
			}

			[Token(Token = "0x6000D09")]
			[Address(RVA = "0x2DC0D9C", Offset = "0x2DC0D9C", VA = "0x2DC0D9C")]
			public HitPointBone()
			{
			}
		}

		[Token(Token = "0x40003E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1445B4C", Offset = "0x1445B4C")]
		public HitPointEffector[] effectorHitPoints;

		[Token(Token = "0x40003E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1445B84", Offset = "0x1445B84")]
		public HitPointBone[] boneHitPoints;

		[Token(Token = "0x17000063")]
		public bool inProgress
		{
			[Token(Token = "0x60004CD")]
			[Address(RVA = "0x2DC0208", Offset = "0x2DC0208", VA = "0x2DC0208")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60004CE")]
		[Address(RVA = "0x2DC02D8", Offset = "0x2DC02D8", VA = "0x2DC02D8", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x60004CF")]
		[Address(RVA = "0x2DC04F8", Offset = "0x2DC04F8", VA = "0x2DC04F8")]
		public void Hit(Collider collider, Vector3 force, Vector3 point)
		{
		}

		[Token(Token = "0x60004D0")]
		[Address(RVA = "0x2DC0864", Offset = "0x2DC0864", VA = "0x2DC0864")]
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
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x144895C", Offset = "0x144895C")]
			public string name;

			[Token(Token = "0x4000B37")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1448994", Offset = "0x1448994")]
			public Collider collider;

			[Token(Token = "0x4000B38")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14489CC", Offset = "0x14489CC")]
			[SerializeField]
			private float crossFadeTime;

			[Token(Token = "0x4000B39")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1448A18", Offset = "0x1448A18")]
			private float <crossFader>k__BackingField;

			[Token(Token = "0x4000B3A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1448A28", Offset = "0x1448A28")]
			private float <timer>k__BackingField;

			[Token(Token = "0x4000B3B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1448A38", Offset = "0x1448A38")]
			private Vector3 <force>k__BackingField;

			[Token(Token = "0x4000B3C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1448A48", Offset = "0x1448A48")]
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
				[Address(RVA = "0x2DC191C", Offset = "0x2DC191C", VA = "0x2DC191C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x144BE18", Offset = "0x144BE18")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000D0B")]
				[Address(RVA = "0x2DC1924", Offset = "0x2DC1924", VA = "0x2DC1924")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x144BE28", Offset = "0x144BE28")]
				private set
				{
				}
			}

			[Token(Token = "0x170000C2")]
			protected float timer
			{
				[Token(Token = "0x6000D0C")]
				[Address(RVA = "0x2DC192C", Offset = "0x2DC192C", VA = "0x2DC192C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x144BE38", Offset = "0x144BE38")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000D0D")]
				[Address(RVA = "0x2DC1934", Offset = "0x2DC1934", VA = "0x2DC1934")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x144BE48", Offset = "0x144BE48")]
				private set
				{
				}
			}

			[Token(Token = "0x170000C3")]
			protected Vector3 force
			{
				[Token(Token = "0x6000D0E")]
				[Address(RVA = "0x2DC193C", Offset = "0x2DC193C", VA = "0x2DC193C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x144BE58", Offset = "0x144BE58")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000D0F")]
				[Address(RVA = "0x2DC1948", Offset = "0x2DC1948", VA = "0x2DC1948")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x144BE68", Offset = "0x144BE68")]
				private set
				{
				}
			}

			[Token(Token = "0x170000C4")]
			protected Vector3 point
			{
				[Token(Token = "0x6000D10")]
				[Address(RVA = "0x2DC1954", Offset = "0x2DC1954", VA = "0x2DC1954")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x144BE78", Offset = "0x144BE78")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000D11")]
				[Address(RVA = "0x2DC1960", Offset = "0x2DC1960", VA = "0x2DC1960")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x144BE88", Offset = "0x144BE88")]
				private set
				{
				}
			}

			[Token(Token = "0x6000D12")]
			[Address(RVA = "0x2DC17D4", Offset = "0x2DC17D4", VA = "0x2DC17D4")]
			public void Hit(Vector3 force, AnimationCurve[] curves, Vector3 point)
			{
			}

			[Token(Token = "0x6000D13")]
			[Address(RVA = "0x2DC1438", Offset = "0x2DC1438", VA = "0x2DC1438")]
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
			[Address(RVA = "0x2DC196C", Offset = "0x2DC196C", VA = "0x2DC196C")]
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
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x144973C", Offset = "0x144973C")]
				public IKSolverVR.PositionOffset positionOffset;

				[Token(Token = "0x4000BDD")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1449774", Offset = "0x1449774")]
				public float weight;

				[Token(Token = "0x4000BDE")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				private Vector3 lastValue;

				[Token(Token = "0x4000BDF")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
				private Vector3 current;

				[Token(Token = "0x6000D64")]
				[Address(RVA = "0x2DC1E28", Offset = "0x2DC1E28", VA = "0x2DC1E28")]
				public void Apply(VRIK ik, Vector3 offset, float crossFader)
				{
				}

				[Token(Token = "0x6000D65")]
				[Address(RVA = "0x2DC1BE4", Offset = "0x2DC1BE4", VA = "0x2DC1BE4")]
				public void CrossFadeStart()
				{
				}

				[Token(Token = "0x6000D66")]
				[Address(RVA = "0x2DC1F44", Offset = "0x2DC1F44", VA = "0x2DC1F44")]
				public PositionOffsetLink()
				{
				}
			}

			[Token(Token = "0x4000B40")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1448A58", Offset = "0x1448A58")]
			public int forceDirCurveIndex;

			[Token(Token = "0x4000B41")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1448A90", Offset = "0x1448A90")]
			public int upDirCurveIndex;

			[Token(Token = "0x4000B42")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1448AC8", Offset = "0x1448AC8")]
			public PositionOffsetLink[] offsetLinks;

			[Token(Token = "0x6000D18")]
			[Address(RVA = "0x2DC1980", Offset = "0x2DC1980", VA = "0x2DC1980", Slot = "4")]
			protected override float GetLength(AnimationCurve[] curves)
			{
				return default(float);
			}

			[Token(Token = "0x6000D19")]
			[Address(RVA = "0x2DC1B78", Offset = "0x2DC1B78", VA = "0x2DC1B78", Slot = "5")]
			protected override void CrossFadeStart()
			{
			}

			[Token(Token = "0x6000D1A")]
			[Address(RVA = "0x2DC1BF8", Offset = "0x2DC1BF8", VA = "0x2DC1BF8", Slot = "6")]
			protected override void OnApply(VRIK ik, AnimationCurve[] curves, float weight)
			{
			}

			[Token(Token = "0x6000D1B")]
			[Address(RVA = "0x2DC1F28", Offset = "0x2DC1F28", VA = "0x2DC1F28")]
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
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14497AC", Offset = "0x14497AC")]
				public IKSolverVR.RotationOffset rotationOffset;

				[Token(Token = "0x4000BE1")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14497E4", Offset = "0x14497E4")]
				[AttributeAttribute(Name = "RangeAttribute", RVA = "0x14497E4", Offset = "0x14497E4")]
				public float weight;

				[Token(Token = "0x4000BE2")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				private Quaternion lastValue;

				[Token(Token = "0x4000BE3")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
				private Quaternion current;

				[Token(Token = "0x6000D67")]
				[Address(RVA = "0x2DC23AC", Offset = "0x2DC23AC", VA = "0x2DC23AC")]
				public void Apply(VRIK ik, Quaternion offset, float crossFader)
				{
				}

				[Token(Token = "0x6000D68")]
				[Address(RVA = "0x2DC2094", Offset = "0x2DC2094", VA = "0x2DC2094")]
				public void CrossFadeStart()
				{
				}

				[Token(Token = "0x6000D69")]
				[Address(RVA = "0x2DC24E8", Offset = "0x2DC24E8", VA = "0x2DC24E8")]
				public RotationOffsetLink()
				{
				}
			}

			[Token(Token = "0x4000B43")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1448B00", Offset = "0x1448B00")]
			public int curveIndex;

			[Token(Token = "0x4000B44")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1448B38", Offset = "0x1448B38")]
			public RotationOffsetLink[] offsetLinks;

			[Token(Token = "0x4000B45")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private Rigidbody rigidbody;

			[Token(Token = "0x6000D1C")]
			[Address(RVA = "0x2DC1F4C", Offset = "0x2DC1F4C", VA = "0x2DC1F4C", Slot = "4")]
			protected override float GetLength(AnimationCurve[] curves)
			{
				return default(float);
			}

			[Token(Token = "0x6000D1D")]
			[Address(RVA = "0x2DC2030", Offset = "0x2DC2030", VA = "0x2DC2030", Slot = "5")]
			protected override void CrossFadeStart()
			{
			}

			[Token(Token = "0x6000D1E")]
			[Address(RVA = "0x2DC20A0", Offset = "0x2DC20A0", VA = "0x2DC20A0", Slot = "6")]
			protected override void OnApply(VRIK ik, AnimationCurve[] curves, float weight)
			{
			}

			[Token(Token = "0x6000D1F")]
			[Address(RVA = "0x2DC24D4", Offset = "0x2DC24D4", VA = "0x2DC24D4")]
			public RotationOffset()
			{
			}
		}

		[Token(Token = "0x40003E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public AnimationCurve[] offsetCurves;

		[Token(Token = "0x40003E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1445BBC", Offset = "0x1445BBC")]
		public PositionOffset[] positionOffsets;

		[Token(Token = "0x40003E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1445BF4", Offset = "0x1445BF4")]
		public RotationOffset[] rotationOffsets;

		[Token(Token = "0x60004D1")]
		[Address(RVA = "0x2DC136C", Offset = "0x2DC136C", VA = "0x2DC136C", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x60004D2")]
		[Address(RVA = "0x2DC158C", Offset = "0x2DC158C", VA = "0x2DC158C")]
		public void Hit(Collider collider, Vector3 force, Vector3 point)
		{
		}

		[Token(Token = "0x60004D3")]
		[Address(RVA = "0x2DC1914", Offset = "0x2DC1914", VA = "0x2DC1914")]
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
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1449838", Offset = "0x1449838")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x4000BE5")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1449870", Offset = "0x1449870")]
				public float weight;

				[Token(Token = "0x6000D6A")]
				[Address(RVA = "0x2FEBDC8", Offset = "0x2FEBDC8", VA = "0x2FEBDC8")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x4000B46")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1448B70", Offset = "0x1448B70")]
			public Transform transform;

			[Token(Token = "0x4000B47")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1448BA8", Offset = "0x1448BA8")]
			public EffectorLink[] effectorLinks;

			[Token(Token = "0x4000B48")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1448BE0", Offset = "0x1448BE0")]
			public float speed;

			[Token(Token = "0x4000B49")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1448C18", Offset = "0x1448C18")]
			public float acceleration;

			[Token(Token = "0x4000B4A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1448C50", Offset = "0x1448C50")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1448C50", Offset = "0x1448C50")]
			public float matchVelocity;

			[Token(Token = "0x4000B4B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1448CA4", Offset = "0x1448CA4")]
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
			[Address(RVA = "0x2FEB894", Offset = "0x2FEB894", VA = "0x2FEB894")]
			public void Reset()
			{
			}

			[Token(Token = "0x6000D21")]
			[Address(RVA = "0x2FEBA2C", Offset = "0x2FEBA2C", VA = "0x2FEBA2C")]
			public void Update(IKSolverFullBodyBiped solver, float weight, float deltaTime)
			{
			}

			[Token(Token = "0x6000D22")]
			[Address(RVA = "0x2FEBDAC", Offset = "0x2FEBDAC", VA = "0x2FEBDAC")]
			public Body()
			{
			}
		}

		[Token(Token = "0x40003E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1445C2C", Offset = "0x1445C2C")]
		public Body[] bodies;

		[Token(Token = "0x40003E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1445C64", Offset = "0x1445C64")]
		public OffsetLimits[] limits;

		[Token(Token = "0x60004D4")]
		[Address(RVA = "0x2FEB81C", Offset = "0x2FEB81C", VA = "0x2FEB81C")]
		public void ResetBodies()
		{
		}

		[Token(Token = "0x60004D5")]
		[Address(RVA = "0x2FEB970", Offset = "0x2FEB970", VA = "0x2FEB970", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x60004D6")]
		[Address(RVA = "0x2FEBDA4", Offset = "0x2FEBDA4", VA = "0x2FEBDA4")]
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
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x1445C9C", Offset = "0x1445C9C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1445C9C", Offset = "0x1445C9C")]
		public Transform target;

		[Token(Token = "0x40003E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1445CFC", Offset = "0x1445CFC")]
		public float weight;

		[Token(Token = "0x40003EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public Vector3 offset;

		[Token(Token = "0x40003EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1445D14", Offset = "0x1445D14")]
		public float targetSwitchSmoothTime;

		[Token(Token = "0x40003EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1445D4C", Offset = "0x1445D4C")]
		public float weightSmoothTime;

		[Token(Token = "0x40003ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x1445D84", Offset = "0x1445D84")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1445D84", Offset = "0x1445D84")]
		public bool smoothTurnTowardsTarget;

		[Token(Token = "0x40003EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1445DE4", Offset = "0x1445DE4")]
		public float maxRadiansDelta;

		[Token(Token = "0x40003EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1445E1C", Offset = "0x1445E1C")]
		public float maxMagnitudeDelta;

		[Token(Token = "0x40003F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1445E54", Offset = "0x1445E54")]
		public float slerpSpeed;

		[Token(Token = "0x40003F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1445E8C", Offset = "0x1445E8C")]
		public Vector3 pivotOffsetFromRoot;

		[Token(Token = "0x40003F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1445EC4", Offset = "0x1445EC4")]
		public float minDistance;

		[Token(Token = "0x40003F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x1445EFC", Offset = "0x1445EFC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1445EFC", Offset = "0x1445EFC")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1445EFC", Offset = "0x1445EFC")]
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
			[Address(RVA = "0x293A3E8", Offset = "0x293A3E8", VA = "0x293A3E8")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x60004D7")]
		[Address(RVA = "0x293A300", Offset = "0x293A300", VA = "0x293A300")]
		private void Start()
		{
		}

		[Token(Token = "0x60004D8")]
		[Address(RVA = "0x293A534", Offset = "0x293A534", VA = "0x293A534")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60004DA")]
		[Address(RVA = "0x293ABE8", Offset = "0x293ABE8", VA = "0x293ABE8")]
		private void ApplyMinDistance()
		{
		}

		[Token(Token = "0x60004DB")]
		[Address(RVA = "0x293AD84", Offset = "0x293AD84", VA = "0x293AD84")]
		private void RootRotation()
		{
		}

		[Token(Token = "0x60004DC")]
		[Address(RVA = "0x293B0A0", Offset = "0x293B0A0", VA = "0x293B0A0")]
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
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1448CDC", Offset = "0x1448CDC")]
			public FullBodyBipedEffector effector;

			[Token(Token = "0x4000B52")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1448D14", Offset = "0x1448D14")]
			public float spring;

			[Token(Token = "0x4000B53")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1448D4C", Offset = "0x1448D4C")]
			public bool x;

			[Token(Token = "0x4000B54")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1448D84", Offset = "0x1448D84")]
			public bool y;

			[Token(Token = "0x4000B55")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1448DBC", Offset = "0x1448DBC")]
			public bool z;

			[Token(Token = "0x4000B56")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1448DF4", Offset = "0x1448DF4")]
			public float minX;

			[Token(Token = "0x4000B57")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1448E2C", Offset = "0x1448E2C")]
			public float maxX;

			[Token(Token = "0x4000B58")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1448E64", Offset = "0x1448E64")]
			public float minY;

			[Token(Token = "0x4000B59")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1448E9C", Offset = "0x1448E9C")]
			public float maxY;

			[Token(Token = "0x4000B5A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1448ED4", Offset = "0x1448ED4")]
			public float minZ;

			[Token(Token = "0x4000B5B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1448F0C", Offset = "0x1448F0C")]
			public float maxZ;

			[Token(Token = "0x6000D23")]
			[Address(RVA = "0x293B5B0", Offset = "0x293B5B0", VA = "0x293B5B0")]
			public void Apply(IKEffector e, Quaternion rootRotation)
			{
			}

			[Token(Token = "0x6000D24")]
			[Address(RVA = "0x293BAC8", Offset = "0x293BAC8", VA = "0x293BAC8")]
			private float SpringAxis(float value, float min, float max)
			{
				return default(float);
			}

			[Token(Token = "0x6000D25")]
			[Address(RVA = "0x293BAF8", Offset = "0x293BAF8", VA = "0x293BAF8")]
			private float Spring(float value, float limit, bool negative)
			{
				return default(float);
			}

			[Token(Token = "0x6000D26")]
			[Address(RVA = "0x293BBD0", Offset = "0x293BBD0", VA = "0x293BBD0")]
			public OffsetLimits()
			{
			}
		}

		[Token(Token = "0x20001C9")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1442114", Offset = "0x1442114")]
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
				[Address(RVA = "0x293BA58", Offset = "0x293BA58", VA = "0x293BA58", Slot = "4")]
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
				[Address(RVA = "0x293BAC0", Offset = "0x293BAC0", VA = "0x293BAC0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000D27")]
			[Address(RVA = "0x293B3BC", Offset = "0x293B3BC", VA = "0x293B3BC")]
			[DebuggerHidden]
			public <Initiate>d__8(int <>1__state)
			{
			}

			[Token(Token = "0x6000D28")]
			[Address(RVA = "0x293B918", Offset = "0x293B918", VA = "0x293B918", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000D29")]
			[Address(RVA = "0x293B91C", Offset = "0x293B91C", VA = "0x293B91C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000D2B")]
			[Address(RVA = "0x293BA60", Offset = "0x293BA60", VA = "0x293BA60", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40003FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1445F78", Offset = "0x1445F78")]
		public float weight;

		[Token(Token = "0x40003FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1445FB0", Offset = "0x1445FB0")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x40003FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		protected float lastTime;

		[Token(Token = "0x17000065")]
		protected float deltaTime
		{
			[Token(Token = "0x60004DD")]
			[Address(RVA = "0x293B2F4", Offset = "0x293B2F4", VA = "0x293B2F4")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x60004DE")]
		protected abstract void OnModifyOffset();

		[Token(Token = "0x60004DF")]
		[Address(RVA = "0x293B320", Offset = "0x293B320", VA = "0x293B320", Slot = "5")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x60004E0")]
		[Address(RVA = "0x293B34C", Offset = "0x293B34C", VA = "0x293B34C")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x144B7F8", Offset = "0x144B7F8")]
		private IEnumerator Initiate()
		{
			return null;
		}

		[Token(Token = "0x60004E1")]
		[Address(RVA = "0x293B3E8", Offset = "0x293B3E8", VA = "0x293B3E8")]
		private void ModifyOffset()
		{
		}

		[Token(Token = "0x60004E2")]
		[Address(RVA = "0x293B4F4", Offset = "0x293B4F4", VA = "0x293B4F4")]
		protected void ApplyLimits(OffsetLimits[] limits)
		{
		}

		[Token(Token = "0x60004E3")]
		[Address(RVA = "0x293B810", Offset = "0x293B810", VA = "0x293B810", Slot = "6")]
		protected virtual void OnDestroy()
		{
		}

		[Token(Token = "0x60004E4")]
		[Address(RVA = "0x293B908", Offset = "0x293B908", VA = "0x293B908")]
		protected OffsetModifier()
		{
		}
	}
	[Token(Token = "0x200007E")]
	public abstract class OffsetModifierVRIK : MonoBehaviour
	{
		[Token(Token = "0x20001CA")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1442124", Offset = "0x1442124")]
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
				[Address(RVA = "0x293C020", Offset = "0x293C020", VA = "0x293C020", Slot = "4")]
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
				[Address(RVA = "0x293C088", Offset = "0x293C088", VA = "0x293C088", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000D2D")]
			[Address(RVA = "0x293BCA0", Offset = "0x293BCA0", VA = "0x293BCA0")]
			[DebuggerHidden]
			public <Initiate>d__7(int <>1__state)
			{
			}

			[Token(Token = "0x6000D2E")]
			[Address(RVA = "0x293BEE0", Offset = "0x293BEE0", VA = "0x293BEE0", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000D2F")]
			[Address(RVA = "0x293BEE4", Offset = "0x293BEE4", VA = "0x293BEE4", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000D31")]
			[Address(RVA = "0x293C028", Offset = "0x293C028", VA = "0x293C028", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40003FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1445FE8", Offset = "0x1445FE8")]
		public float weight;

		[Token(Token = "0x40003FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1446020", Offset = "0x1446020")]
		public VRIK ik;

		[Token(Token = "0x4000400")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float lastTime;

		[Token(Token = "0x17000066")]
		protected float deltaTime
		{
			[Token(Token = "0x60004E5")]
			[Address(RVA = "0x293BBD8", Offset = "0x293BBD8", VA = "0x293BBD8")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x60004E6")]
		protected abstract void OnModifyOffset();

		[Token(Token = "0x60004E7")]
		[Address(RVA = "0x293BC04", Offset = "0x293BC04", VA = "0x293BC04", Slot = "5")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x60004E8")]
		[Address(RVA = "0x293BC30", Offset = "0x293BC30", VA = "0x293BC30")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x144B85C", Offset = "0x144B85C")]
		private IEnumerator Initiate()
		{
			return null;
		}

		[Token(Token = "0x60004E9")]
		[Address(RVA = "0x293BCCC", Offset = "0x293BCCC", VA = "0x293BCCC")]
		private void ModifyOffset()
		{
		}

		[Token(Token = "0x60004EA")]
		[Address(RVA = "0x293BDD8", Offset = "0x293BDD8", VA = "0x293BDD8", Slot = "6")]
		protected virtual void OnDestroy()
		{
		}

		[Token(Token = "0x60004EB")]
		[Address(RVA = "0x293BED0", Offset = "0x293BED0", VA = "0x293BED0")]
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
			[Address(RVA = "0x293C150", Offset = "0x293C150", VA = "0x293C150")]
			public void Apply(IKSolverFullBodyBiped solver, float weight, Quaternion rotation)
			{
			}

			[Token(Token = "0x6000D34")]
			[Address(RVA = "0x293C5A0", Offset = "0x293C5A0", VA = "0x293C5A0")]
			public EffectorLink()
			{
			}
		}

		[Token(Token = "0x4000401")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public EffectorLink[] effectorLinks;

		[Token(Token = "0x60004EC")]
		[Address(RVA = "0x293C090", Offset = "0x293C090", VA = "0x293C090")]
		public void Apply(IKSolverFullBodyBiped solver, float weight)
		{
		}

		[Token(Token = "0x60004ED")]
		[Address(RVA = "0x293C488", Offset = "0x293C488", VA = "0x293C488")]
		public void Apply(IKSolverFullBodyBiped solver, float weight, Quaternion rotation)
		{
		}

		[Token(Token = "0x60004EE")]
		[Address(RVA = "0x293C540", Offset = "0x293C540", VA = "0x293C540")]
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
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14498A8", Offset = "0x14498A8")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x4000BE7")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14498E0", Offset = "0x14498E0")]
				public float weight;

				[Token(Token = "0x6000D6B")]
				[Address(RVA = "0x293CC58", Offset = "0x293CC58", VA = "0x293CC58")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x4000B66")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1448F44", Offset = "0x1448F44")]
			public Transform[] raycastFrom;

			[Token(Token = "0x4000B67")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1448F7C", Offset = "0x1448F7C")]
			public Transform raycastTo;

			[Token(Token = "0x4000B68")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1448FB4", Offset = "0x1448FB4")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1448FB4", Offset = "0x1448FB4")]
			public float raycastRadius;

			[Token(Token = "0x4000B69")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1449008", Offset = "0x1449008")]
			public EffectorLink[] effectors;

			[Token(Token = "0x4000B6A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1449040", Offset = "0x1449040")]
			public float smoothTimeIn;

			[Token(Token = "0x4000B6B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1449078", Offset = "0x1449078")]
			public float smoothTimeOut;

			[Token(Token = "0x4000B6C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14490B0", Offset = "0x14490B0")]
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
			[Address(RVA = "0x293C62C", Offset = "0x293C62C", VA = "0x293C62C")]
			public void Solve(IKSolverFullBodyBiped solver, float weight)
			{
			}

			[Token(Token = "0x6000D36")]
			[Address(RVA = "0x293C838", Offset = "0x293C838", VA = "0x293C838")]
			private Vector3 GetOffsetTarget(IKSolverFullBodyBiped solver)
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000D37")]
			[Address(RVA = "0x293C9D0", Offset = "0x293C9D0", VA = "0x293C9D0")]
			private Vector3 Raycast(Vector3 from, Vector3 to)
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000D38")]
			[Address(RVA = "0x293CC44", Offset = "0x293CC44", VA = "0x293CC44")]
			public Avoider()
			{
			}
		}

		[Token(Token = "0x4000402")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1446058", Offset = "0x1446058")]
		public Avoider[] avoiders;

		[Token(Token = "0x60004EF")]
		[Address(RVA = "0x293C5A8", Offset = "0x293C5A8", VA = "0x293C5A8", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x60004F0")]
		[Address(RVA = "0x293C828", Offset = "0x293C828", VA = "0x293C828")]
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
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1449918", Offset = "0x1449918")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x4000BE9")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1449950", Offset = "0x1449950")]
				public float weight;

				[Token(Token = "0x6000D6C")]
				[Address(RVA = "0x293FCD8", Offset = "0x293FCD8", VA = "0x293FCD8")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x4000B70")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14490E8", Offset = "0x14490E8")]
			public Vector3 offset;

			[Token(Token = "0x4000B71")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1449120", Offset = "0x1449120")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1449120", Offset = "0x1449120")]
			public float additivity;

			[Token(Token = "0x4000B72")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1449174", Offset = "0x1449174")]
			public float maxAdditiveOffsetMag;

			[Token(Token = "0x4000B73")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14491AC", Offset = "0x14491AC")]
			public EffectorLink[] effectorLinks;

			[Token(Token = "0x4000B74")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private Vector3 additiveOffset;

			[Token(Token = "0x4000B75")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private Vector3 lastOffset;

			[Token(Token = "0x6000D39")]
			[Address(RVA = "0x293EA20", Offset = "0x293EA20", VA = "0x293EA20")]
			public void Start()
			{
			}

			[Token(Token = "0x6000D3A")]
			[Address(RVA = "0x293F5B0", Offset = "0x293F5B0", VA = "0x293F5B0")]
			public void Apply(IKSolverFullBodyBiped solver, Quaternion rotation, float masterWeight, float length, float timeLeft)
			{
			}

			[Token(Token = "0x6000D3B")]
			[Address(RVA = "0x293FCC4", Offset = "0x293FCC4", VA = "0x293FCC4")]
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
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1446090", Offset = "0x1446090")]
		public AimIK aimIK;

		[Token(Token = "0x4000404")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14460C8", Offset = "0x14460C8")]
		public bool aimIKSolvedLast;

		[Token(Token = "0x4000405")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1446100", Offset = "0x1446100")]
		public Handedness handedness;

		[Token(Token = "0x4000406")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1446138", Offset = "0x1446138")]
		public bool twoHanded;

		[Token(Token = "0x4000407")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1446170", Offset = "0x1446170")]
		public AnimationCurve recoilWeight;

		[Token(Token = "0x4000408")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14461A8", Offset = "0x14461A8")]
		public float magnitudeRandom;

		[Token(Token = "0x4000409")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14461E0", Offset = "0x14461E0")]
		public Vector3 rotationRandom;

		[Token(Token = "0x400040A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1446218", Offset = "0x1446218")]
		public Vector3 handRotationOffset;

		[Token(Token = "0x400040B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1446250", Offset = "0x1446250")]
		public float blendTime;

		[Token(Token = "0x400040C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x1446288", Offset = "0x1446288")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1446288", Offset = "0x1446288")]
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
			[Address(RVA = "0x293E7F8", Offset = "0x293E7F8", VA = "0x293E7F8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000068")]
		private IKEffector primaryHandEffector
		{
			[Token(Token = "0x60004F7")]
			[Address(RVA = "0x293F864", Offset = "0x293F864", VA = "0x293F864")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000069")]
		private IKEffector secondaryHandEffector
		{
			[Token(Token = "0x60004F8")]
			[Address(RVA = "0x293F8A4", Offset = "0x293F8A4", VA = "0x293F8A4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700006A")]
		private Transform primaryHand
		{
			[Token(Token = "0x60004F9")]
			[Address(RVA = "0x293F824", Offset = "0x293F824", VA = "0x293F824")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700006B")]
		private Transform secondaryHand
		{
			[Token(Token = "0x60004FA")]
			[Address(RVA = "0x293F844", Offset = "0x293F844", VA = "0x293F844")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60004F2")]
		[Address(RVA = "0x293E828", Offset = "0x293E828", VA = "0x293E828")]
		public void SetHandRotations(Quaternion leftHandRotation, Quaternion rightHandRotation)
		{
		}

		[Token(Token = "0x60004F3")]
		[Address(RVA = "0x293E854", Offset = "0x293E854", VA = "0x293E854")]
		public void Fire(float magnitude)
		{
		}

		[Token(Token = "0x60004F4")]
		[Address(RVA = "0x293EAD0", Offset = "0x293EAD0", VA = "0x293EAD0", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x60004F5")]
		[Address(RVA = "0x293F8E4", Offset = "0x293F8E4", VA = "0x293F8E4")]
		private void AfterFBBIK()
		{
		}

		[Token(Token = "0x60004F6")]
		[Address(RVA = "0x293FA3C", Offset = "0x293FA3C", VA = "0x293FA3C")]
		private void AfterAimIK()
		{
		}

		[Token(Token = "0x60004FB")]
		[Address(RVA = "0x293FA78", Offset = "0x293FA78", VA = "0x293FA78", Slot = "6")]
		protected override void OnDestroy()
		{
		}

		[Token(Token = "0x60004FC")]
		[Address(RVA = "0x293FC10", Offset = "0x293FC10", VA = "0x293FC10")]
		public Recoil()
		{
		}
	}
	[Token(Token = "0x2000082")]
	public class ShoulderRotator : MonoBehaviour
	{
		[Token(Token = "0x400041A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14462E8", Offset = "0x14462E8")]
		public float weight;

		[Token(Token = "0x400041B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1446320", Offset = "0x1446320")]
		public float offset;

		[Token(Token = "0x400041C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private FullBodyBipedIK ik;

		[Token(Token = "0x400041D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool skip;

		[Token(Token = "0x60004FD")]
		[Address(RVA = "0x2943DDC", Offset = "0x2943DDC", VA = "0x2943DDC")]
		private void Start()
		{
		}

		[Token(Token = "0x60004FE")]
		[Address(RVA = "0x2943EB0", Offset = "0x2943EB0", VA = "0x2943EB0")]
		private void RotateShoulders()
		{
		}

		[Token(Token = "0x60004FF")]
		[Address(RVA = "0x2943F9C", Offset = "0x2943F9C", VA = "0x2943F9C")]
		private void RotateShoulder(FullBodyBipedChain chain, float weight, float offset)
		{
		}

		[Token(Token = "0x6000500")]
		[Address(RVA = "0x29443E4", Offset = "0x29443E4", VA = "0x29443E4")]
		private IKMapping.BoneMap GetParentBoneMap(FullBodyBipedChain chain)
		{
			return null;
		}

		[Token(Token = "0x6000501")]
		[Address(RVA = "0x294441C", Offset = "0x294441C", VA = "0x294441C")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000502")]
		[Address(RVA = "0x2944514", Offset = "0x2944514", VA = "0x2944514")]
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
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14491E4", Offset = "0x14491E4")]
			public float scaleMlp;

			[Token(Token = "0x4000B7A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x144921C", Offset = "0x144921C")]
			public Vector3 headTrackerForward;

			[Token(Token = "0x4000B7B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1449254", Offset = "0x1449254")]
			public Vector3 headTrackerUp;

			[Token(Token = "0x4000B7C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x144928C", Offset = "0x144928C")]
			public Vector3 bodyTrackerForward;

			[Token(Token = "0x4000B7D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14492C4", Offset = "0x14492C4")]
			public Vector3 bodyTrackerUp;

			[Token(Token = "0x4000B7E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14492FC", Offset = "0x14492FC")]
			public Vector3 handTrackerForward;

			[Token(Token = "0x4000B7F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1449334", Offset = "0x1449334")]
			public Vector3 handTrackerUp;

			[Token(Token = "0x4000B80")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x144936C", Offset = "0x144936C")]
			public Vector3 footTrackerForward;

			[Token(Token = "0x4000B81")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14493A4", Offset = "0x14493A4")]
			public Vector3 footTrackerUp;

			[Token(Token = "0x4000B82")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
			[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x14493DC", Offset = "0x14493DC")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14493DC", Offset = "0x14493DC")]
			public Vector3 headOffset;

			[Token(Token = "0x4000B83")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x144942C", Offset = "0x144942C")]
			public Vector3 handOffset;

			[Token(Token = "0x4000B84")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1449464", Offset = "0x1449464")]
			public float footForwardOffset;

			[Token(Token = "0x4000B85")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x144949C", Offset = "0x144949C")]
			public float footInwardOffset;

			[Token(Token = "0x4000B86")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x14494D4", Offset = "0x14494D4")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x14494D4", Offset = "0x14494D4")]
			public float footHeadingOffset;

			[Token(Token = "0x4000B87")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1449530", Offset = "0x1449530")]
			public float pelvisPositionWeight;

			[Token(Token = "0x4000B88")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1449548", Offset = "0x1449548")]
			public float pelvisRotationWeight;

			[Token(Token = "0x6000D3C")]
			[Address(RVA = "0x2949520", Offset = "0x2949520", VA = "0x2949520")]
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
				[Address(RVA = "0x29485CC", Offset = "0x29485CC", VA = "0x29485CC")]
				public Target(Transform t)
				{
				}

				[Token(Token = "0x6000D6E")]
				[Address(RVA = "0x2949120", Offset = "0x2949120", VA = "0x2949120")]
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
			[Address(RVA = "0x2947A70", Offset = "0x2947A70", VA = "0x2947A70")]
			public CalibrationData()
			{
			}
		}

		[Token(Token = "0x6000503")]
		[Address(RVA = "0x2946630", Offset = "0x2946630", VA = "0x2946630")]
		public static void RecalibrateScale(VRIK ik, Settings settings)
		{
		}

		[Token(Token = "0x6000504")]
		[Address(RVA = "0x2946798", Offset = "0x2946798", VA = "0x2946798")]
		public static CalibrationData Calibrate(VRIK ik, Settings settings, Transform headTracker, [Optional] Transform bodyTracker, [Optional] Transform leftHandTracker, [Optional] Transform rightHandTracker, [Optional] Transform leftFootTracker, [Optional] Transform rightFootTracker)
		{
			return null;
		}

		[Token(Token = "0x6000505")]
		[Address(RVA = "0x2947BE8", Offset = "0x2947BE8", VA = "0x2947BE8")]
		private static void CalibrateLeg(Settings settings, Transform tracker, IKSolverVR.Leg leg, Transform lastBone, Vector3 rootForward, bool isLeft)
		{
		}

		[Token(Token = "0x6000506")]
		[Address(RVA = "0x2948690", Offset = "0x2948690", VA = "0x2948690")]
		public static void Calibrate(VRIK ik, CalibrationData data, Transform headTracker, [Optional] Transform bodyTracker, [Optional] Transform leftHandTracker, [Optional] Transform rightHandTracker, [Optional] Transform leftFootTracker, [Optional] Transform rightFootTracker)
		{
		}

		[Token(Token = "0x6000507")]
		[Address(RVA = "0x2949180", Offset = "0x2949180", VA = "0x2949180")]
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
		[Address(RVA = "0x2949618", Offset = "0x2949618", VA = "0x2949618")]
		private void Start()
		{
		}

		[Token(Token = "0x6000509")]
		[Address(RVA = "0x2949670", Offset = "0x2949670", VA = "0x2949670")]
		private void Update()
		{
		}

		[Token(Token = "0x600050A")]
		[Address(RVA = "0x29496A4", Offset = "0x29496A4", VA = "0x29496A4")]
		private int GetLODLevel()
		{
			return default(int);
		}

		[Token(Token = "0x600050B")]
		[Address(RVA = "0x294982C", Offset = "0x294982C", VA = "0x294982C")]
		public VRIKLODController()
		{
		}
	}
	[Token(Token = "0x2000085")]
	public class VRIKRootController : MonoBehaviour
	{
		[Token(Token = "0x4000422")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1446358", Offset = "0x1446358")]
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
			[Address(RVA = "0x2949844", Offset = "0x2949844", VA = "0x2949844")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x144B8C0", Offset = "0x144B8C0")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x600050D")]
			[Address(RVA = "0x2949850", Offset = "0x2949850", VA = "0x2949850")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x144B8D0", Offset = "0x144B8D0")]
			private set
			{
			}
		}

		[Token(Token = "0x600050E")]
		[Address(RVA = "0x294985C", Offset = "0x294985C", VA = "0x294985C")]
		private void Awake()
		{
		}

		[Token(Token = "0x600050F")]
		[Address(RVA = "0x29483A8", Offset = "0x29483A8", VA = "0x29483A8")]
		public void Calibrate()
		{
		}

		[Token(Token = "0x6000510")]
		[Address(RVA = "0x29493B0", Offset = "0x29493B0", VA = "0x29493B0")]
		public void Calibrate(VRIKCalibrator.CalibrationData data)
		{
		}

		[Token(Token = "0x6000511")]
		[Address(RVA = "0x2949934", Offset = "0x2949934", VA = "0x2949934")]
		private void OnPreUpdate()
		{
		}

		[Token(Token = "0x6000512")]
		[Address(RVA = "0x2949DD8", Offset = "0x2949DD8", VA = "0x2949DD8")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000513")]
		[Address(RVA = "0x2949ED0", Offset = "0x2949ED0", VA = "0x2949ED0")]
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
		[Address(RVA = "0x24B7658", Offset = "0x24B7658", VA = "0x24B7658")]
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
		[Address(RVA = "0x18036BC", Offset = "0x18036BC", VA = "0x18036BC")]
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
		[Address(RVA = "0x10ED558", Offset = "0x10ED558", VA = "0x10ED558")]
		public REVERB_PROPERTIES(float decayTime, float earlyDelay, float lateDelay, float hfReference, float hfDecayRatio, float diffusion, float density, float lowShelfFrequency, float lowShelfGain, float highCut, float earlyLateMix, float wetLevel)
		{
		}
	}
	[Token(Token = "0x20000BC")]
	public class PRESET
	{
		[Token(Token = "0x600055B")]
		[Address(RVA = "0x17F1104", Offset = "0x17F1104", VA = "0x17F1104")]
		public static REVERB_PROPERTIES OFF()
		{
			return default(REVERB_PROPERTIES);
		}

		[Token(Token = "0x600055C")]
		[Address(RVA = "0x17F1154", Offset = "0x17F1154", VA = "0x17F1154")]
		public static REVERB_PROPERTIES GENERIC()
		{
			return default(REVERB_PROPERTIES);
		}

		[Token(Token = "0x600055D")]
		[Address(RVA = "0x17F1178", Offset = "0x17F1178", VA = "0x17F1178")]
		public static REVERB_PROPERTIES PADDEDCELL()
		{
			return default(REVERB_PROPERTIES);
		}

		[Token(Token = "0x600055E")]
		[Address(RVA = "0x17F119C", Offset = "0x17F119C", VA = "0x17F119C")]
		public static REVERB_PROPERTIES ROOM()
		{
			return default(REVERB_PROPERTIES);
		}

		[Token(Token = "0x600055F")]
		[Address(RVA = "0x17F11C0", Offset = "0x17F11C0", VA = "0x17F11C0")]
		public static REVERB_PROPERTIES BATHROOM()
		{
			return default(REVERB_PROPERTIES);
		}

		[Token(Token = "0x6000560")]
		[Address(RVA = "0x17F11E4", Offset = "0x17F11E4", VA = "0x17F11E4")]
		public static REVERB_PROPERTIES LIVINGROOM()
		{
			return default(REVERB_PROPERTIES);
		}

		[Token(Token = "0x6000561")]
		[Address(RVA = "0x17F1208", Offset = "0x17F1208", VA = "0x17F1208")]
		public static REVERB_PROPERTIES STONEROOM()
		{
			return default(REVERB_PROPERTIES);
		}

		[Token(Token = "0x6000562")]
		[Address(RVA = "0x17F122C", Offset = "0x17F122C", VA = "0x17F122C")]
		public static REVERB_PROPERTIES AUDITORIUM()
		{
			return default(REVERB_PROPERTIES);
		}

		[Token(Token = "0x6000563")]
		[Address(RVA = "0x17F1250", Offset = "0x17F1250", VA = "0x17F1250")]
		public static REVERB_PROPERTIES CONCERTHALL()
		{
			return default(REVERB_PROPERTIES);
		}

		[Token(Token = "0x6000564")]
		[Address(RVA = "0x17F1274", Offset = "0x17F1274", VA = "0x17F1274")]
		public static REVERB_PROPERTIES CAVE()
		{
			return default(REVERB_PROPERTIES);
		}

		[Token(Token = "0x6000565")]
		[Address(RVA = "0x17F1298", Offset = "0x17F1298", VA = "0x17F1298")]
		public static REVERB_PROPERTIES ARENA()
		{
			return default(REVERB_PROPERTIES);
		}

		[Token(Token = "0x6000566")]
		[Address(RVA = "0x17F12BC", Offset = "0x17F12BC", VA = "0x17F12BC")]
		public static REVERB_PROPERTIES HANGAR()
		{
			return default(REVERB_PROPERTIES);
		}

		[Token(Token = "0x6000567")]
		[Address(RVA = "0x17F12E0", Offset = "0x17F12E0", VA = "0x17F12E0")]
		public static REVERB_PROPERTIES CARPETTEDHALLWAY()
		{
			return default(REVERB_PROPERTIES);
		}

		[Token(Token = "0x6000568")]
		[Address(RVA = "0x17F1304", Offset = "0x17F1304", VA = "0x17F1304")]
		public static REVERB_PROPERTIES HALLWAY()
		{
			return default(REVERB_PROPERTIES);
		}

		[Token(Token = "0x6000569")]
		[Address(RVA = "0x17F1328", Offset = "0x17F1328", VA = "0x17F1328")]
		public static REVERB_PROPERTIES STONECORRIDOR()
		{
			return default(REVERB_PROPERTIES);
		}

		[Token(Token = "0x600056A")]
		[Address(RVA = "0x17F134C", Offset = "0x17F134C", VA = "0x17F134C")]
		public static REVERB_PROPERTIES ALLEY()
		{
			return default(REVERB_PROPERTIES);
		}

		[Token(Token = "0x600056B")]
		[Address(RVA = "0x17F1370", Offset = "0x17F1370", VA = "0x17F1370")]
		public static REVERB_PROPERTIES FOREST()
		{
			return default(REVERB_PROPERTIES);
		}

		[Token(Token = "0x600056C")]
		[Address(RVA = "0x17F1394", Offset = "0x17F1394", VA = "0x17F1394")]
		public static REVERB_PROPERTIES CITY()
		{
			return default(REVERB_PROPERTIES);
		}

		[Token(Token = "0x600056D")]
		[Address(RVA = "0x17F13B8", Offset = "0x17F13B8", VA = "0x17F13B8")]
		public static REVERB_PROPERTIES MOUNTAINS()
		{
			return default(REVERB_PROPERTIES);
		}

		[Token(Token = "0x600056E")]
		[Address(RVA = "0x17F13DC", Offset = "0x17F13DC", VA = "0x17F13DC")]
		public static REVERB_PROPERTIES QUARRY()
		{
			return default(REVERB_PROPERTIES);
		}

		[Token(Token = "0x600056F")]
		[Address(RVA = "0x17F1400", Offset = "0x17F1400", VA = "0x17F1400")]
		public static REVERB_PROPERTIES PLAIN()
		{
			return default(REVERB_PROPERTIES);
		}

		[Token(Token = "0x6000570")]
		[Address(RVA = "0x17F1424", Offset = "0x17F1424", VA = "0x17F1424")]
		public static REVERB_PROPERTIES PARKINGLOT()
		{
			return default(REVERB_PROPERTIES);
		}

		[Token(Token = "0x6000571")]
		[Address(RVA = "0x17F1448", Offset = "0x17F1448", VA = "0x17F1448")]
		public static REVERB_PROPERTIES SEWERPIPE()
		{
			return default(REVERB_PROPERTIES);
		}

		[Token(Token = "0x6000572")]
		[Address(RVA = "0x17F146C", Offset = "0x17F146C", VA = "0x17F146C")]
		public static REVERB_PROPERTIES UNDERWATER()
		{
			return default(REVERB_PROPERTIES);
		}

		[Token(Token = "0x6000573")]
		[Address(RVA = "0x17F1490", Offset = "0x17F1490", VA = "0x17F1490")]
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
		[Address(RVA = "0x17EF694", Offset = "0x17EF694", VA = "0x17EF694")]
		public static RESULT System_Create(out System system)
		{
			return default(RESULT);
		}

		[PreserveSig]
		[Token(Token = "0x6000575")]
		[Address(RVA = "0x17EF698", Offset = "0x17EF698", VA = "0x17EF698")]
		private static extern RESULT FMOD5_System_Create(out IntPtr system);
	}
	[Token(Token = "0x20000C0")]
	public struct Memory
	{
		[Token(Token = "0x6000576")]
		[Address(RVA = "0x17F0F80", Offset = "0x17F0F80", VA = "0x17F0F80")]
		public static RESULT Initialize(IntPtr poolmem, int poollen, MEMORY_ALLOC_CALLBACK useralloc, MEMORY_REALLOC_CALLBACK userrealloc, MEMORY_FREE_CALLBACK userfree, MEMORY_TYPE memtypeflags = MEMORY_TYPE.ALL)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000577")]
		[Address(RVA = "0x17F1064", Offset = "0x17F1064", VA = "0x17F1064")]
		public static RESULT GetStats(out int currentalloced, out int maxalloced, bool blocking = true)
		{
			return default(RESULT);
		}

		[PreserveSig]
		[Token(Token = "0x6000578")]
		[Address(RVA = "0x17F0F84", Offset = "0x17F0F84", VA = "0x17F0F84")]
		private static extern RESULT FMOD5_Memory_Initialize(IntPtr poolmem, int poollen, MEMORY_ALLOC_CALLBACK useralloc, MEMORY_REALLOC_CALLBACK userrealloc, MEMORY_FREE_CALLBACK userfree, MEMORY_TYPE memtypeflags);

		[PreserveSig]
		[Token(Token = "0x6000579")]
		[Address(RVA = "0x17F106C", Offset = "0x17F106C", VA = "0x17F106C")]
		private static extern RESULT FMOD5_Memory_GetStats(out int currentalloced, out int maxalloced, bool blocking);
	}
	[Token(Token = "0x20000C1")]
	public struct Debug
	{
		[Token(Token = "0x600057A")]
		[Address(RVA = "0x181579C", Offset = "0x181579C", VA = "0x181579C")]
		public static RESULT Initialize(DEBUG_FLAGS flags, DEBUG_MODE mode = DEBUG_MODE.TTY, [Optional] DEBUG_CALLBACK callback, [Optional] string filename)
		{
			return default(RESULT);
		}

		[PreserveSig]
		[Token(Token = "0x600057B")]
		[Address(RVA = "0x1815900", Offset = "0x1815900", VA = "0x1815900")]
		private static extern RESULT FMOD5_Debug_Initialize(DEBUG_FLAGS flags, DEBUG_MODE mode, DEBUG_CALLBACK callback, byte[] filename);
	}
	[Token(Token = "0x20000C2")]
	public struct System
	{
		[Token(Token = "0x400060B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public IntPtr handle;

		[Token(Token = "0x600057C")]
		[Address(RVA = "0x155E480", Offset = "0x155E480", VA = "0x155E480")]
		public RESULT release()
		{
			return default(RESULT);
		}

		[Token(Token = "0x600057D")]
		[Address(RVA = "0x155E488", Offset = "0x155E488", VA = "0x155E488")]
		public RESULT setOutput(OUTPUTTYPE output)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600057E")]
		[Address(RVA = "0x155E490", Offset = "0x155E490", VA = "0x155E490")]
		public RESULT getOutput(out OUTPUTTYPE output)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600057F")]
		[Address(RVA = "0x155E498", Offset = "0x155E498", VA = "0x155E498")]
		public RESULT getNumDrivers(out int numdrivers)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000580")]
		[Address(RVA = "0x155E4A0", Offset = "0x155E4A0", VA = "0x155E4A0")]
		public RESULT getDriverInfo(int id, out string name, int namelen, out Guid guid, out int systemrate, out SPEAKERMODE speakermode, out int speakermodechannels)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000581")]
		[Address(RVA = "0x155E4A8", Offset = "0x155E4A8", VA = "0x155E4A8")]
		public RESULT getDriverInfo(int id, out Guid guid, out int systemrate, out SPEAKERMODE speakermode, out int speakermodechannels)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000582")]
		[Address(RVA = "0x155E4B0", Offset = "0x155E4B0", VA = "0x155E4B0")]
		public RESULT setDriver(int driver)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000583")]
		[Address(RVA = "0x155E4B8", Offset = "0x155E4B8", VA = "0x155E4B8")]
		public RESULT getDriver(out int driver)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000584")]
		[Address(RVA = "0x155E4C0", Offset = "0x155E4C0", VA = "0x155E4C0")]
		public RESULT setSoftwareChannels(int numsoftwarechannels)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000585")]
		[Address(RVA = "0x155E4C8", Offset = "0x155E4C8", VA = "0x155E4C8")]
		public RESULT getSoftwareChannels(out int numsoftwarechannels)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000586")]
		[Address(RVA = "0x155E4D0", Offset = "0x155E4D0", VA = "0x155E4D0")]
		public RESULT setSoftwareFormat(int samplerate, SPEAKERMODE speakermode, int numrawspeakers)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000587")]
		[Address(RVA = "0x155E4D8", Offset = "0x155E4D8", VA = "0x155E4D8")]
		public RESULT getSoftwareFormat(out int samplerate, out SPEAKERMODE speakermode, out int numrawspeakers)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000588")]
		[Address(RVA = "0x155E4E0", Offset = "0x155E4E0", VA = "0x155E4E0")]
		public RESULT setDSPBufferSize(uint bufferlength, int numbuffers)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000589")]
		[Address(RVA = "0x155E4E8", Offset = "0x155E4E8", VA = "0x155E4E8")]
		public RESULT getDSPBufferSize(out uint bufferlength, out int numbuffers)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600058A")]
		[Address(RVA = "0x155E4F0", Offset = "0x155E4F0", VA = "0x155E4F0")]
		public RESULT setFileSystem(FILE_OPEN_CALLBACK useropen, FILE_CLOSE_CALLBACK userclose, FILE_READ_CALLBACK userread, FILE_SEEK_CALLBACK userseek, FILE_ASYNCREAD_CALLBACK userasyncread, FILE_ASYNCCANCEL_CALLBACK userasynccancel, int blockalign)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600058B")]
		[Address(RVA = "0x155E4F8", Offset = "0x155E4F8", VA = "0x155E4F8")]
		public RESULT attachFileSystem(FILE_OPEN_CALLBACK useropen, FILE_CLOSE_CALLBACK userclose, FILE_READ_CALLBACK userread, FILE_SEEK_CALLBACK userseek)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600058C")]
		[Address(RVA = "0x155E500", Offset = "0x155E500", VA = "0x155E500")]
		public RESULT setAdvancedSettings(ref ADVANCEDSETTINGS settings)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600058D")]
		[Address(RVA = "0x155E508", Offset = "0x155E508", VA = "0x155E508")]
		public RESULT getAdvancedSettings(ref ADVANCEDSETTINGS settings)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600058E")]
		[Address(RVA = "0x155E510", Offset = "0x155E510", VA = "0x155E510")]
		public RESULT setCallback(SYSTEM_CALLBACK callback, SYSTEM_CALLBACK_TYPE callbackmask = SYSTEM_CALLBACK_TYPE.ALL)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600058F")]
		[Address(RVA = "0x155E518", Offset = "0x155E518", VA = "0x155E518")]
		public RESULT setPluginPath(string path)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000590")]
		[Address(RVA = "0x155E520", Offset = "0x155E520", VA = "0x155E520")]
		public RESULT loadPlugin(string filename, out uint handle, uint priority = 0u)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000591")]
		[Address(RVA = "0x155E528", Offset = "0x155E528", VA = "0x155E528")]
		public RESULT unloadPlugin(uint handle)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000592")]
		[Address(RVA = "0x155E530", Offset = "0x155E530", VA = "0x155E530")]
		public RESULT getNumNestedPlugins(uint handle, out int count)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000593")]
		[Address(RVA = "0x155E538", Offset = "0x155E538", VA = "0x155E538")]
		public RESULT getNestedPlugin(uint handle, int index, out uint nestedhandle)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000594")]
		[Address(RVA = "0x155E540", Offset = "0x155E540", VA = "0x155E540")]
		public RESULT getNumPlugins(PLUGINTYPE plugintype, out int numplugins)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000595")]
		[Address(RVA = "0x155E548", Offset = "0x155E548", VA = "0x155E548")]
		public RESULT getPluginHandle(PLUGINTYPE plugintype, int index, out uint handle)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000596")]
		[Address(RVA = "0x155E550", Offset = "0x155E550", VA = "0x155E550")]
		public RESULT getPluginInfo(uint handle, out PLUGINTYPE plugintype, out string name, int namelen, out uint version)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000597")]
		[Address(RVA = "0x155E558", Offset = "0x155E558", VA = "0x155E558")]
		public RESULT getPluginInfo(uint handle, out PLUGINTYPE plugintype, out uint version)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000598")]
		[Address(RVA = "0x155E560", Offset = "0x155E560", VA = "0x155E560")]
		public RESULT setOutputByPlugin(uint handle)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000599")]
		[Address(RVA = "0x155E568", Offset = "0x155E568", VA = "0x155E568")]
		public RESULT getOutputByPlugin(out uint handle)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600059A")]
		[Address(RVA = "0x155E570", Offset = "0x155E570", VA = "0x155E570")]
		public RESULT createDSPByPlugin(uint handle, out DSP dsp)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600059B")]
		[Address(RVA = "0x155E578", Offset = "0x155E578", VA = "0x155E578")]
		public RESULT getDSPInfoByPlugin(uint handle, out IntPtr description)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600059C")]
		[Address(RVA = "0x155E580", Offset = "0x155E580", VA = "0x155E580")]
		public RESULT registerDSP(ref DSP_DESCRIPTION description, out uint handle)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600059D")]
		[Address(RVA = "0x155E588", Offset = "0x155E588", VA = "0x155E588")]
		public RESULT init(int maxchannels, INITFLAGS flags, IntPtr extradriverdata)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600059E")]
		[Address(RVA = "0x155E590", Offset = "0x155E590", VA = "0x155E590")]
		public RESULT close()
		{
			return default(RESULT);
		}

		[Token(Token = "0x600059F")]
		[Address(RVA = "0x155E598", Offset = "0x155E598", VA = "0x155E598")]
		public RESULT update()
		{
			return default(RESULT);
		}

		[Token(Token = "0x60005A0")]
		[Address(RVA = "0x155E5A0", Offset = "0x155E5A0", VA = "0x155E5A0")]
		public RESULT setSpeakerPosition(SPEAKER speaker, float x, float y, bool active)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60005A1")]
		[Address(RVA = "0x155E5AC", Offset = "0x155E5AC", VA = "0x155E5AC")]
		public RESULT getSpeakerPosition(SPEAKER speaker, out float x, out float y, out bool active)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60005A2")]
		[Address(RVA = "0x155E5B4", Offset = "0x155E5B4", VA = "0x155E5B4")]
		public RESULT setStreamBufferSize(uint filebuffersize, TIMEUNIT filebuffersizetype)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60005A3")]
		[Address(RVA = "0x155E5BC", Offset = "0x155E5BC", VA = "0x155E5BC")]
		public RESULT getStreamBufferSize(out uint filebuffersize, out TIMEUNIT filebuffersizetype)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60005A4")]
		[Address(RVA = "0x155E5C4", Offset = "0x155E5C4", VA = "0x155E5C4")]
		public RESULT set3DSettings(float dopplerscale, float distancefactor, float rolloffscale)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60005A5")]
		[Address(RVA = "0x155E5CC", Offset = "0x155E5CC", VA = "0x155E5CC")]
		public RESULT get3DSettings(out float dopplerscale, out float distancefactor, out float rolloffscale)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60005A6")]
		[Address(RVA = "0x155E5D4", Offset = "0x155E5D4", VA = "0x155E5D4")]
		public RESULT set3DNumListeners(int numlisteners)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60005A7")]
		[Address(RVA = "0x155E5DC", Offset = "0x155E5DC", VA = "0x155E5DC")]
		public RESULT get3DNumListeners(out int numlisteners)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60005A8")]
		[Address(RVA = "0x155E5E4", Offset = "0x155E5E4", VA = "0x155E5E4")]
		public RESULT set3DListenerAttributes(int listener, ref VECTOR pos, ref VECTOR vel, ref VECTOR forward, ref VECTOR up)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60005A9")]
		[Address(RVA = "0x155E5EC", Offset = "0x155E5EC", VA = "0x155E5EC")]
		public RESULT get3DListenerAttributes(int listener, out VECTOR pos, out VECTOR vel, out VECTOR forward, out VECTOR up)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60005AA")]
		[Address(RVA = "0x155E5F4", Offset = "0x155E5F4", VA = "0x155E5F4")]
		public RESULT set3DRolloffCallback(CB_3D_ROLLOFF_CALLBACK callback)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60005AB")]
		[Address(RVA = "0x155E5FC", Offset = "0x155E5FC", VA = "0x155E5FC")]
		public RESULT mixerSuspend()
		{
			return default(RESULT);
		}

		[Token(Token = "0x60005AC")]
		[Address(RVA = "0x155E604", Offset = "0x155E604", VA = "0x155E604")]
		public RESULT mixerResume()
		{
			return default(RESULT);
		}

		[Token(Token = "0x60005AD")]
		[Address(RVA = "0x155E60C", Offset = "0x155E60C", VA = "0x155E60C")]
		public RESULT getDefaultMixMatrix(SPEAKERMODE sourcespeakermode, SPEAKERMODE targetspeakermode, float[] matrix, int matrixhop)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60005AE")]
		[Address(RVA = "0x155E614", Offset = "0x155E614", VA = "0x155E614")]
		public RESULT getSpeakerModeChannels(SPEAKERMODE mode, out int channels)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60005AF")]
		[Address(RVA = "0x155E61C", Offset = "0x155E61C", VA = "0x155E61C")]
		public RESULT getVersion(out uint version)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60005B0")]
		[Address(RVA = "0x155E624", Offset = "0x155E624", VA = "0x155E624")]
		public RESULT getOutputHandle(out IntPtr handle)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60005B1")]
		[Address(RVA = "0x155E62C", Offset = "0x155E62C", VA = "0x155E62C")]
		public RESULT getChannelsPlaying(out int channels)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60005B2")]
		[Address(RVA = "0x155E634", Offset = "0x155E634", VA = "0x155E634")]
		public RESULT getChannelsPlaying(out int channels, out int realchannels)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60005B3")]
		[Address(RVA = "0x155E63C", Offset = "0x155E63C", VA = "0x155E63C")]
		public RESULT getCPUUsage(out float dsp, out float stream, out float geometry, out float update, out float total)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60005B4")]
		[Address(RVA = "0x155E644", Offset = "0x155E644", VA = "0x155E644")]
		public RESULT getFileUsage(out long sampleBytesRead, out long streamBytesRead, out long otherBytesRead)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60005B5")]
		[Address(RVA = "0x155E64C", Offset = "0x155E64C", VA = "0x155E64C")]
		public RESULT createSound(string name, MODE mode, ref CREATESOUNDEXINFO exinfo, out Sound sound)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60005B6")]
		[Address(RVA = "0x155E654", Offset = "0x155E654", VA = "0x155E654")]
		public RESULT createSound(byte[] data, MODE mode, ref CREATESOUNDEXINFO exinfo, out Sound sound)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60005B7")]
		[Address(RVA = "0x155E65C", Offset = "0x155E65C", VA = "0x155E65C")]
		public RESULT createSound(IntPtr name_or_data, MODE mode, ref CREATESOUNDEXINFO exinfo, out Sound sound)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60005B8")]
		[Address(RVA = "0x155E664", Offset = "0x155E664", VA = "0x155E664")]
		public RESULT createSound(string name, MODE mode, out Sound sound)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60005B9")]
		[Address(RVA = "0x155E66C", Offset = "0x155E66C", VA = "0x155E66C")]
		public RESULT createStream(string name, MODE mode, ref CREATESOUNDEXINFO exinfo, out Sound sound)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60005BA")]
		[Address(RVA = "0x155E674", Offset = "0x155E674", VA = "0x155E674")]
		public RESULT createStream(byte[] data, MODE mode, ref CREATESOUNDEXINFO exinfo, out Sound sound)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60005BB")]
		[Address(RVA = "0x155E67C", Offset = "0x155E67C", VA = "0x155E67C")]
		public RESULT createStream(IntPtr name_or_data, MODE mode, ref CREATESOUNDEXINFO exinfo, out Sound sound)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60005BC")]
		[Address(RVA = "0x155E684", Offset = "0x155E684", VA = "0x155E684")]
		public RESULT createStream(string name, MODE mode, out Sound sound)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60005BD")]
		[Address(RVA = "0x155E68C", Offset = "0x155E68C", VA = "0x155E68C")]
		public RESULT createDSP(ref DSP_DESCRIPTION description, out DSP dsp)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60005BE")]
		[Address(RVA = "0x155E694", Offset = "0x155E694", VA = "0x155E694")]
		public RESULT createDSPByType(DSP_TYPE type, out DSP dsp)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60005BF")]
		[Address(RVA = "0x155E69C", Offset = "0x155E69C", VA = "0x155E69C")]
		public RESULT createChannelGroup(string name, out ChannelGroup channelgroup)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60005C0")]
		[Address(RVA = "0x155E6A4", Offset = "0x155E6A4", VA = "0x155E6A4")]
		public RESULT createSoundGroup(string name, out SoundGroup soundgroup)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60005C1")]
		[Address(RVA = "0x155E6AC", Offset = "0x155E6AC", VA = "0x155E6AC")]
		public RESULT createReverb3D(out Reverb3D reverb)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60005C2")]
		[Address(RVA = "0x155E6B4", Offset = "0x155E6B4", VA = "0x155E6B4")]
		public RESULT playSound(Sound sound, ChannelGroup channelgroup, bool paused, out Channel channel)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60005C3")]
		[Address(RVA = "0x155E6C0", Offset = "0x155E6C0", VA = "0x155E6C0")]
		public RESULT playDSP(DSP dsp, ChannelGroup channelgroup, bool paused, out Channel channel)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60005C4")]
		[Address(RVA = "0x155E6CC", Offset = "0x155E6CC", VA = "0x155E6CC")]
		public RESULT getChannel(int channelid, out Channel channel)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60005C5")]
		[Address(RVA = "0x155E6D4", Offset = "0x155E6D4", VA = "0x155E6D4")]
		public RESULT getMasterChannelGroup(out ChannelGroup channelgroup)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60005C6")]
		[Address(RVA = "0x155E6DC", Offset = "0x155E6DC", VA = "0x155E6DC")]
		public RESULT getMasterSoundGroup(out SoundGroup soundgroup)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60005C7")]
		[Address(RVA = "0x155E6E4", Offset = "0x155E6E4", VA = "0x155E6E4")]
		public RESULT attachChannelGroupToPort(uint portType, ulong portIndex, ChannelGroup channelgroup, bool passThru = false)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60005C8")]
		[Address(RVA = "0x155E6F0", Offset = "0x155E6F0", VA = "0x155E6F0")]
		public RESULT detachChannelGroupFromPort(ChannelGroup channelgroup)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60005C9")]
		[Address(RVA = "0x155E6F8", Offset = "0x155E6F8", VA = "0x155E6F8")]
		public RESULT setReverbProperties(int instance, ref REVERB_PROPERTIES prop)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60005CA")]
		[Address(RVA = "0x155E700", Offset = "0x155E700", VA = "0x155E700")]
		public RESULT getReverbProperties(int instance, out REVERB_PROPERTIES prop)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60005CB")]
		[Address(RVA = "0x155E708", Offset = "0x155E708", VA = "0x155E708")]
		public RESULT lockDSP()
		{
			return default(RESULT);
		}

		[Token(Token = "0x60005CC")]
		[Address(RVA = "0x155E710", Offset = "0x155E710", VA = "0x155E710")]
		public RESULT unlockDSP()
		{
			return default(RESULT);
		}

		[Token(Token = "0x60005CD")]
		[Address(RVA = "0x155E718", Offset = "0x155E718", VA = "0x155E718")]
		public RESULT getRecordNumDrivers(out int numdrivers, out int numconnected)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60005CE")]
		[Address(RVA = "0x155E720", Offset = "0x155E720", VA = "0x155E720")]
		public RESULT getRecordDriverInfo(int id, out string name, int namelen, out Guid guid, out int systemrate, out SPEAKERMODE speakermode, out int speakermodechannels, out DRIVER_STATE state)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60005CF")]
		[Address(RVA = "0x155E730", Offset = "0x155E730", VA = "0x155E730")]
		public RESULT getRecordDriverInfo(int id, out Guid guid, out int systemrate, out SPEAKERMODE speakermode, out int speakermodechannels, out DRIVER_STATE state)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60005D0")]
		[Address(RVA = "0x155E738", Offset = "0x155E738", VA = "0x155E738")]
		public RESULT getRecordPosition(int id, out uint position)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60005D1")]
		[Address(RVA = "0x155E740", Offset = "0x155E740", VA = "0x155E740")]
		public RESULT recordStart(int id, Sound sound, bool loop)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60005D2")]
		[Address(RVA = "0x155E74C", Offset = "0x155E74C", VA = "0x155E74C")]
		public RESULT recordStop(int id)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60005D3")]
		[Address(RVA = "0x155E754", Offset = "0x155E754", VA = "0x155E754")]
		public RESULT isRecording(int id, out bool recording)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60005D4")]
		[Address(RVA = "0x155E75C", Offset = "0x155E75C", VA = "0x155E75C")]
		public RESULT createGeometry(int maxpolygons, int maxvertices, out Geometry geometry)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60005D5")]
		[Address(RVA = "0x155E764", Offset = "0x155E764", VA = "0x155E764")]
		public RESULT setGeometrySettings(float maxworldsize)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60005D6")]
		[Address(RVA = "0x155E76C", Offset = "0x155E76C", VA = "0x155E76C")]
		public RESULT getGeometrySettings(out float maxworldsize)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60005D7")]
		[Address(RVA = "0x155E774", Offset = "0x155E774", VA = "0x155E774")]
		public RESULT loadGeometry(IntPtr data, int datasize, out Geometry geometry)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60005D8")]
		[Address(RVA = "0x155E77C", Offset = "0x155E77C", VA = "0x155E77C")]
		public RESULT getGeometryOcclusion(ref VECTOR listener, ref VECTOR source, out float direct, out float reverb)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60005D9")]
		[Address(RVA = "0x155E784", Offset = "0x155E784", VA = "0x155E784")]
		public RESULT setNetworkProxy(string proxy)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60005DA")]
		[Address(RVA = "0x155E78C", Offset = "0x155E78C", VA = "0x155E78C")]
		public RESULT getNetworkProxy(out string proxy, int proxylen)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60005DB")]
		[Address(RVA = "0x155E794", Offset = "0x155E794", VA = "0x155E794")]
		public RESULT setNetworkTimeout(int timeout)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60005DC")]
		[Address(RVA = "0x155E79C", Offset = "0x155E79C", VA = "0x155E79C")]
		public RESULT getNetworkTimeout(out int timeout)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60005DD")]
		[Address(RVA = "0x155E7A4", Offset = "0x155E7A4", VA = "0x155E7A4")]
		public RESULT setUserData(IntPtr userdata)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60005DE")]
		[Address(RVA = "0x155E7AC", Offset = "0x155E7AC", VA = "0x155E7AC")]
		public RESULT getUserData(out IntPtr userdata)
		{
			return default(RESULT);
		}

		[PreserveSig]
		[Token(Token = "0x60005DF")]
		[Address(RVA = "0x24B2168", Offset = "0x24B2168", VA = "0x24B2168")]
		private static extern RESULT FMOD5_System_Release(IntPtr system);

		[PreserveSig]
		[Token(Token = "0x60005E0")]
		[Address(RVA = "0x24B21F0", Offset = "0x24B21F0", VA = "0x24B21F0")]
		private static extern RESULT FMOD5_System_SetOutput(IntPtr system, OUTPUTTYPE output);

		[PreserveSig]
		[Token(Token = "0x60005E1")]
		[Address(RVA = "0x24B2288", Offset = "0x24B2288", VA = "0x24B2288")]
		private static extern RESULT FMOD5_System_GetOutput(IntPtr system, out OUTPUTTYPE output);

		[PreserveSig]
		[Token(Token = "0x60005E2")]
		[Address(RVA = "0x24B2320", Offset = "0x24B2320", VA = "0x24B2320")]
		private static extern RESULT FMOD5_System_GetNumDrivers(IntPtr system, out int numdrivers);

		[PreserveSig]
		[Token(Token = "0x60005E3")]
		[Address(RVA = "0x24B25A4", Offset = "0x24B25A4", VA = "0x24B25A4")]
		private static extern RESULT FMOD5_System_GetDriverInfo(IntPtr system, int id, IntPtr name, int namelen, out Guid guid, out int systemrate, out SPEAKERMODE speakermode, out int speakermodechannels);

		[PreserveSig]
		[Token(Token = "0x60005E4")]
		[Address(RVA = "0x24B271C", Offset = "0x24B271C", VA = "0x24B271C")]
		private static extern RESULT FMOD5_System_SetDriver(IntPtr system, int driver);

		[PreserveSig]
		[Token(Token = "0x60005E5")]
		[Address(RVA = "0x24B27B4", Offset = "0x24B27B4", VA = "0x24B27B4")]
		private static extern RESULT FMOD5_System_GetDriver(IntPtr system, out int driver);

		[PreserveSig]
		[Token(Token = "0x60005E6")]
		[Address(RVA = "0x24B284C", Offset = "0x24B284C", VA = "0x24B284C")]
		private static extern RESULT FMOD5_System_SetSoftwareChannels(IntPtr system, int numsoftwarechannels);

		[PreserveSig]
		[Token(Token = "0x60005E7")]
		[Address(RVA = "0x24B28E4", Offset = "0x24B28E4", VA = "0x24B28E4")]
		private static extern RESULT FMOD5_System_GetSoftwareChannels(IntPtr system, out int numsoftwarechannels);

		[PreserveSig]
		[Token(Token = "0x60005E8")]
		[Address(RVA = "0x24B297C", Offset = "0x24B297C", VA = "0x24B297C")]
		private static extern RESULT FMOD5_System_SetSoftwareFormat(IntPtr system, int samplerate, SPEAKERMODE speakermode, int numrawspeakers);

		[PreserveSig]
		[Token(Token = "0x60005E9")]
		[Address(RVA = "0x24B2A2C", Offset = "0x24B2A2C", VA = "0x24B2A2C")]
		private static extern RESULT FMOD5_System_GetSoftwareFormat(IntPtr system, out int samplerate, out SPEAKERMODE speakermode, out int numrawspeakers);

		[PreserveSig]
		[Token(Token = "0x60005EA")]
		[Address(RVA = "0x24B2ADC", Offset = "0x24B2ADC", VA = "0x24B2ADC")]
		private static extern RESULT FMOD5_System_SetDSPBufferSize(IntPtr system, uint bufferlength, int numbuffers);

		[PreserveSig]
		[Token(Token = "0x60005EB")]
		[Address(RVA = "0x24B2B7C", Offset = "0x24B2B7C", VA = "0x24B2B7C")]
		private static extern RESULT FMOD5_System_GetDSPBufferSize(IntPtr system, out uint bufferlength, out int numbuffers);

		[PreserveSig]
		[Token(Token = "0x60005EC")]
		[Address(RVA = "0x24B2C1C", Offset = "0x24B2C1C", VA = "0x24B2C1C")]
		private static extern RESULT FMOD5_System_SetFileSystem(IntPtr system, FILE_OPEN_CALLBACK useropen, FILE_CLOSE_CALLBACK userclose, FILE_READ_CALLBACK userread, FILE_SEEK_CALLBACK userseek, FILE_ASYNCREAD_CALLBACK userasyncread, FILE_ASYNCCANCEL_CALLBACK userasynccancel, int blockalign);

		[PreserveSig]
		[Token(Token = "0x60005ED")]
		[Address(RVA = "0x24B2D40", Offset = "0x24B2D40", VA = "0x24B2D40")]
		private static extern RESULT FMOD5_System_AttachFileSystem(IntPtr system, FILE_OPEN_CALLBACK useropen, FILE_CLOSE_CALLBACK userclose, FILE_READ_CALLBACK userread, FILE_SEEK_CALLBACK userseek);

		[PreserveSig]
		[Token(Token = "0x60005EE")]
		[Address(RVA = "0x24B2ED8", Offset = "0x24B2ED8", VA = "0x24B2ED8")]
		private static extern RESULT FMOD5_System_SetAdvancedSettings(IntPtr system, ref ADVANCEDSETTINGS settings);

		[PreserveSig]
		[Token(Token = "0x60005EF")]
		[Address(RVA = "0x24B3024", Offset = "0x24B3024", VA = "0x24B3024")]
		private static extern RESULT FMOD5_System_GetAdvancedSettings(IntPtr system, ref ADVANCEDSETTINGS settings);

		[PreserveSig]
		[Token(Token = "0x60005F0")]
		[Address(RVA = "0x24B30BC", Offset = "0x24B30BC", VA = "0x24B30BC")]
		private static extern RESULT FMOD5_System_SetCallback(IntPtr system, SYSTEM_CALLBACK callback, SYSTEM_CALLBACK_TYPE callbackmask);

		[PreserveSig]
		[Token(Token = "0x60005F1")]
		[Address(RVA = "0x24B32AC", Offset = "0x24B32AC", VA = "0x24B32AC")]
		private static extern RESULT FMOD5_System_SetPluginPath(IntPtr system, byte[] path);

		[PreserveSig]
		[Token(Token = "0x60005F2")]
		[Address(RVA = "0x24B34AC", Offset = "0x24B34AC", VA = "0x24B34AC")]
		private static extern RESULT FMOD5_System_LoadPlugin(IntPtr system, byte[] filename, out uint handle, uint priority);

		[PreserveSig]
		[Token(Token = "0x60005F3")]
		[Address(RVA = "0x24B3564", Offset = "0x24B3564", VA = "0x24B3564")]
		private static extern RESULT FMOD5_System_UnloadPlugin(IntPtr system, uint handle);

		[PreserveSig]
		[Token(Token = "0x60005F4")]
		[Address(RVA = "0x24B35FC", Offset = "0x24B35FC", VA = "0x24B35FC")]
		private static extern RESULT FMOD5_System_GetNumNestedPlugins(IntPtr system, uint handle, out int count);

		[PreserveSig]
		[Token(Token = "0x60005F5")]
		[Address(RVA = "0x24B369C", Offset = "0x24B369C", VA = "0x24B369C")]
		private static extern RESULT FMOD5_System_GetNestedPlugin(IntPtr system, uint handle, int index, out uint nestedhandle);

		[PreserveSig]
		[Token(Token = "0x60005F6")]
		[Address(RVA = "0x24B374C", Offset = "0x24B374C", VA = "0x24B374C")]
		private static extern RESULT FMOD5_System_GetNumPlugins(IntPtr system, PLUGINTYPE plugintype, out int numplugins);

		[PreserveSig]
		[Token(Token = "0x60005F7")]
		[Address(RVA = "0x24B37EC", Offset = "0x24B37EC", VA = "0x24B37EC")]
		private static extern RESULT FMOD5_System_GetPluginHandle(IntPtr system, PLUGINTYPE plugintype, int index, out uint handle);

		[PreserveSig]
		[Token(Token = "0x60005F8")]
		[Address(RVA = "0x24B3A68", Offset = "0x24B3A68", VA = "0x24B3A68")]
		private static extern RESULT FMOD5_System_GetPluginInfo(IntPtr system, uint handle, out PLUGINTYPE plugintype, IntPtr name, int namelen, out uint version);

		[PreserveSig]
		[Token(Token = "0x60005F9")]
		[Address(RVA = "0x24B3BA4", Offset = "0x24B3BA4", VA = "0x24B3BA4")]
		private static extern RESULT FMOD5_System_SetOutputByPlugin(IntPtr system, uint handle);

		[PreserveSig]
		[Token(Token = "0x60005FA")]
		[Address(RVA = "0x24B3C3C", Offset = "0x24B3C3C", VA = "0x24B3C3C")]
		private static extern RESULT FMOD5_System_GetOutputByPlugin(IntPtr system, out uint handle);

		[PreserveSig]
		[Token(Token = "0x60005FB")]
		[Address(RVA = "0x24B3CD4", Offset = "0x24B3CD4", VA = "0x24B3CD4")]
		private static extern RESULT FMOD5_System_CreateDSPByPlugin(IntPtr system, uint handle, out IntPtr dsp);

		[PreserveSig]
		[Token(Token = "0x60005FC")]
		[Address(RVA = "0x24B3D74", Offset = "0x24B3D74", VA = "0x24B3D74")]
		private static extern RESULT FMOD5_System_GetDSPInfoByPlugin(IntPtr system, uint handle, out IntPtr description);

		[PreserveSig]
		[Token(Token = "0x60005FD")]
		[Address(RVA = "0x24B3E14", Offset = "0x24B3E14", VA = "0x24B3E14")]
		private static extern RESULT FMOD5_System_RegisterDSP(IntPtr system, ref DSP_DESCRIPTION description, out uint handle);

		[PreserveSig]
		[Token(Token = "0x60005FE")]
		[Address(RVA = "0x24B3F10", Offset = "0x24B3F10", VA = "0x24B3F10")]
		private static extern RESULT FMOD5_System_Init(IntPtr system, int maxchannels, INITFLAGS flags, IntPtr extradriverdata);

		[PreserveSig]
		[Token(Token = "0x60005FF")]
		[Address(RVA = "0x24B3FC0", Offset = "0x24B3FC0", VA = "0x24B3FC0")]
		private static extern RESULT FMOD5_System_Close(IntPtr system);

		[PreserveSig]
		[Token(Token = "0x6000600")]
		[Address(RVA = "0x24B4048", Offset = "0x24B4048", VA = "0x24B4048")]
		private static extern RESULT FMOD5_System_Update(IntPtr system);

		[PreserveSig]
		[Token(Token = "0x6000601")]
		[Address(RVA = "0x24B40D4", Offset = "0x24B40D4", VA = "0x24B40D4")]
		private static extern RESULT FMOD5_System_SetSpeakerPosition(IntPtr system, SPEAKER speaker, float x, float y, bool active);

		[PreserveSig]
		[Token(Token = "0x6000602")]
		[Address(RVA = "0x24B418C", Offset = "0x24B418C", VA = "0x24B418C")]
		private static extern RESULT FMOD5_System_GetSpeakerPosition(IntPtr system, SPEAKER speaker, out float x, out float y, out bool active);

		[PreserveSig]
		[Token(Token = "0x6000603")]
		[Address(RVA = "0x24B4258", Offset = "0x24B4258", VA = "0x24B4258")]
		private static extern RESULT FMOD5_System_SetStreamBufferSize(IntPtr system, uint filebuffersize, TIMEUNIT filebuffersizetype);

		[PreserveSig]
		[Token(Token = "0x6000604")]
		[Address(RVA = "0x24B42F8", Offset = "0x24B42F8", VA = "0x24B42F8")]
		private static extern RESULT FMOD5_System_GetStreamBufferSize(IntPtr system, out uint filebuffersize, out TIMEUNIT filebuffersizetype);

		[PreserveSig]
		[Token(Token = "0x6000605")]
		[Address(RVA = "0x24B4398", Offset = "0x24B4398", VA = "0x24B4398")]
		private static extern RESULT FMOD5_System_Set3DSettings(IntPtr system, float dopplerscale, float distancefactor, float rolloffscale);

		[PreserveSig]
		[Token(Token = "0x6000606")]
		[Address(RVA = "0x24B4448", Offset = "0x24B4448", VA = "0x24B4448")]
		private static extern RESULT FMOD5_System_Get3DSettings(IntPtr system, out float dopplerscale, out float distancefactor, out float rolloffscale);

		[PreserveSig]
		[Token(Token = "0x6000607")]
		[Address(RVA = "0x24B44F8", Offset = "0x24B44F8", VA = "0x24B44F8")]
		private static extern RESULT FMOD5_System_Set3DNumListeners(IntPtr system, int numlisteners);

		[PreserveSig]
		[Token(Token = "0x6000608")]
		[Address(RVA = "0x24B4590", Offset = "0x24B4590", VA = "0x24B4590")]
		private static extern RESULT FMOD5_System_Get3DNumListeners(IntPtr system, out int numlisteners);

		[PreserveSig]
		[Token(Token = "0x6000609")]
		[Address(RVA = "0x24B4628", Offset = "0x24B4628", VA = "0x24B4628")]
		private static extern RESULT FMOD5_System_Set3DListenerAttributes(IntPtr system, int listener, ref VECTOR pos, ref VECTOR vel, ref VECTOR forward, ref VECTOR up);

		[PreserveSig]
		[Token(Token = "0x600060A")]
		[Address(RVA = "0x24B46F0", Offset = "0x24B46F0", VA = "0x24B46F0")]
		private static extern RESULT FMOD5_System_Get3DListenerAttributes(IntPtr system, int listener, out VECTOR pos, out VECTOR vel, out VECTOR forward, out VECTOR up);

		[PreserveSig]
		[Token(Token = "0x600060B")]
		[Address(RVA = "0x24B47B8", Offset = "0x24B47B8", VA = "0x24B47B8")]
		private static extern RESULT FMOD5_System_Set3DRolloffCallback(IntPtr system, CB_3D_ROLLOFF_CALLBACK callback);

		[PreserveSig]
		[Token(Token = "0x600060C")]
		[Address(RVA = "0x24B4858", Offset = "0x24B4858", VA = "0x24B4858")]
		private static extern RESULT FMOD5_System_MixerSuspend(IntPtr system);

		[PreserveSig]
		[Token(Token = "0x600060D")]
		[Address(RVA = "0x24B48E0", Offset = "0x24B48E0", VA = "0x24B48E0")]
		private static extern RESULT FMOD5_System_MixerResume(IntPtr system);

		[PreserveSig]
		[Token(Token = "0x600060E")]
		[Address(RVA = "0x24B4968", Offset = "0x24B4968", VA = "0x24B4968")]
		private static extern RESULT FMOD5_System_GetDefaultMixMatrix(IntPtr system, SPEAKERMODE sourcespeakermode, SPEAKERMODE targetspeakermode, float[] matrix, int matrixhop);

		[PreserveSig]
		[Token(Token = "0x600060F")]
		[Address(RVA = "0x24B4A28", Offset = "0x24B4A28", VA = "0x24B4A28")]
		private static extern RESULT FMOD5_System_GetSpeakerModeChannels(IntPtr system, SPEAKERMODE mode, out int channels);

		[PreserveSig]
		[Token(Token = "0x6000610")]
		[Address(RVA = "0x24B4AC8", Offset = "0x24B4AC8", VA = "0x24B4AC8")]
		private static extern RESULT FMOD5_System_GetVersion(IntPtr system, out uint version);

		[PreserveSig]
		[Token(Token = "0x6000611")]
		[Address(RVA = "0x24B4B60", Offset = "0x24B4B60", VA = "0x24B4B60")]
		private static extern RESULT FMOD5_System_GetOutputHandle(IntPtr system, out IntPtr handle);

		[PreserveSig]
		[Token(Token = "0x6000612")]
		[Address(RVA = "0x24B4C48", Offset = "0x24B4C48", VA = "0x24B4C48")]
		private static extern RESULT FMOD5_System_GetChannelsPlaying(IntPtr system, out int channels, IntPtr zero);

		[PreserveSig]
		[Token(Token = "0x6000613")]
		[Address(RVA = "0x24B4CE8", Offset = "0x24B4CE8", VA = "0x24B4CE8")]
		private static extern RESULT FMOD5_System_GetChannelsPlaying(IntPtr system, out int channels, out int realchannels);

		[PreserveSig]
		[Token(Token = "0x6000614")]
		[Address(RVA = "0x24B4D88", Offset = "0x24B4D88", VA = "0x24B4D88")]
		private static extern RESULT FMOD5_System_GetCPUUsage(IntPtr system, out float dsp, out float stream, out float geometry, out float update, out float total);

		[PreserveSig]
		[Token(Token = "0x6000615")]
		[Address(RVA = "0x24B4E50", Offset = "0x24B4E50", VA = "0x24B4E50")]
		private static extern RESULT FMOD5_System_GetFileUsage(IntPtr system, out long sampleBytesRead, out long streamBytesRead, out long otherBytesRead);

		[PreserveSig]
		[Token(Token = "0x6000616")]
		[Address(RVA = "0x24B5068", Offset = "0x24B5068", VA = "0x24B5068")]
		private static extern RESULT FMOD5_System_CreateSound(IntPtr system, byte[] name_or_data, MODE mode, ref CREATESOUNDEXINFO exinfo, out IntPtr sound);

		[PreserveSig]
		[Token(Token = "0x6000617")]
		[Address(RVA = "0x24B5194", Offset = "0x24B5194", VA = "0x24B5194")]
		private static extern RESULT FMOD5_System_CreateSound(IntPtr system, IntPtr name_or_data, MODE mode, ref CREATESOUNDEXINFO exinfo, out IntPtr sound);

		[PreserveSig]
		[Token(Token = "0x6000618")]
		[Address(RVA = "0x24B54FC", Offset = "0x24B54FC", VA = "0x24B54FC")]
		private static extern RESULT FMOD5_System_CreateStream(IntPtr system, byte[] name_or_data, MODE mode, ref CREATESOUNDEXINFO exinfo, out IntPtr sound);

		[PreserveSig]
		[Token(Token = "0x6000619")]
		[Address(RVA = "0x24B5628", Offset = "0x24B5628", VA = "0x24B5628")]
		private static extern RESULT FMOD5_System_CreateStream(IntPtr system, IntPtr name_or_data, MODE mode, ref CREATESOUNDEXINFO exinfo, out IntPtr sound);

		[PreserveSig]
		[Token(Token = "0x600061A")]
		[Address(RVA = "0x24B5828", Offset = "0x24B5828", VA = "0x24B5828")]
		private static extern RESULT FMOD5_System_CreateDSP(IntPtr system, ref DSP_DESCRIPTION description, out IntPtr dsp);

		[PreserveSig]
		[Token(Token = "0x600061B")]
		[Address(RVA = "0x24B5928", Offset = "0x24B5928", VA = "0x24B5928")]
		private static extern RESULT FMOD5_System_CreateDSPByType(IntPtr system, DSP_TYPE type, out IntPtr dsp);

		[PreserveSig]
		[Token(Token = "0x600061C")]
		[Address(RVA = "0x24B5B18", Offset = "0x24B5B18", VA = "0x24B5B18")]
		private static extern RESULT FMOD5_System_CreateChannelGroup(IntPtr system, byte[] name, out IntPtr channelgroup);

		[PreserveSig]
		[Token(Token = "0x600061D")]
		[Address(RVA = "0x24B5D10", Offset = "0x24B5D10", VA = "0x24B5D10")]
		private static extern RESULT FMOD5_System_CreateSoundGroup(IntPtr system, byte[] name, out IntPtr soundgroup);

		[PreserveSig]
		[Token(Token = "0x600061E")]
		[Address(RVA = "0x24B5DB8", Offset = "0x24B5DB8", VA = "0x24B5DB8")]
		private static extern RESULT FMOD5_System_CreateReverb3D(IntPtr system, out IntPtr reverb);

		[PreserveSig]
		[Token(Token = "0x600061F")]
		[Address(RVA = "0x24B5E54", Offset = "0x24B5E54", VA = "0x24B5E54")]
		private static extern RESULT FMOD5_System_PlaySound(IntPtr system, IntPtr sound, IntPtr channelgroup, bool paused, out IntPtr channel);

		[PreserveSig]
		[Token(Token = "0x6000620")]
		[Address(RVA = "0x24B5F10", Offset = "0x24B5F10", VA = "0x24B5F10")]
		private static extern RESULT FMOD5_System_PlayDSP(IntPtr system, IntPtr dsp, IntPtr channelgroup, bool paused, out IntPtr channel);

		[PreserveSig]
		[Token(Token = "0x6000621")]
		[Address(RVA = "0x24B5FC8", Offset = "0x24B5FC8", VA = "0x24B5FC8")]
		private static extern RESULT FMOD5_System_GetChannel(IntPtr system, int channelid, out IntPtr channel);

		[PreserveSig]
		[Token(Token = "0x6000622")]
		[Address(RVA = "0x24B6068", Offset = "0x24B6068", VA = "0x24B6068")]
		private static extern RESULT FMOD5_System_GetMasterChannelGroup(IntPtr system, out IntPtr channelgroup);

		[PreserveSig]
		[Token(Token = "0x6000623")]
		[Address(RVA = "0x24B6100", Offset = "0x24B6100", VA = "0x24B6100")]
		private static extern RESULT FMOD5_System_GetMasterSoundGroup(IntPtr system, out IntPtr soundgroup);

		[PreserveSig]
		[Token(Token = "0x6000624")]
		[Address(RVA = "0x24B619C", Offset = "0x24B619C", VA = "0x24B619C")]
		private static extern RESULT FMOD5_System_AttachChannelGroupToPort(IntPtr system, uint portType, ulong portIndex, IntPtr channelgroup, bool passThru);

		[PreserveSig]
		[Token(Token = "0x6000625")]
		[Address(RVA = "0x24B6254", Offset = "0x24B6254", VA = "0x24B6254")]
		private static extern RESULT FMOD5_System_DetachChannelGroupFromPort(IntPtr system, IntPtr channelgroup);

		[PreserveSig]
		[Token(Token = "0x6000626")]
		[Address(RVA = "0x24B62EC", Offset = "0x24B62EC", VA = "0x24B62EC")]
		private static extern RESULT FMOD5_System_SetReverbProperties(IntPtr system, int instance, ref REVERB_PROPERTIES prop);

		[PreserveSig]
		[Token(Token = "0x6000627")]
		[Address(RVA = "0x24B638C", Offset = "0x24B638C", VA = "0x24B638C")]
		private static extern RESULT FMOD5_System_GetReverbProperties(IntPtr system, int instance, out REVERB_PROPERTIES prop);

		[PreserveSig]
		[Token(Token = "0x6000628")]
		[Address(RVA = "0x24B642C", Offset = "0x24B642C", VA = "0x24B642C")]
		private static extern RESULT FMOD5_System_LockDSP(IntPtr system);

		[PreserveSig]
		[Token(Token = "0x6000629")]
		[Address(RVA = "0x24B64B4", Offset = "0x24B64B4", VA = "0x24B64B4")]
		private static extern RESULT FMOD5_System_UnlockDSP(IntPtr system);

		[PreserveSig]
		[Token(Token = "0x600062A")]
		[Address(RVA = "0x24B653C", Offset = "0x24B653C", VA = "0x24B653C")]
		private static extern RESULT FMOD5_System_GetRecordNumDrivers(IntPtr system, out int numdrivers, out int numconnected);

		[PreserveSig]
		[Token(Token = "0x600062B")]
		[Address(RVA = "0x24B67D0", Offset = "0x24B67D0", VA = "0x24B67D0")]
		private static extern RESULT FMOD5_System_GetRecordDriverInfo(IntPtr system, int id, IntPtr name, int namelen, out Guid guid, out int systemrate, out SPEAKERMODE speakermode, out int speakermodechannels, out DRIVER_STATE state);

		[PreserveSig]
		[Token(Token = "0x600062C")]
		[Address(RVA = "0x24B6958", Offset = "0x24B6958", VA = "0x24B6958")]
		private static extern RESULT FMOD5_System_GetRecordPosition(IntPtr system, int id, out uint position);

		[PreserveSig]
		[Token(Token = "0x600062D")]
		[Address(RVA = "0x24B69FC", Offset = "0x24B69FC", VA = "0x24B69FC")]
		private static extern RESULT FMOD5_System_RecordStart(IntPtr system, int id, IntPtr sound, bool loop);

		[PreserveSig]
		[Token(Token = "0x600062E")]
		[Address(RVA = "0x24B6AA8", Offset = "0x24B6AA8", VA = "0x24B6AA8")]
		private static extern RESULT FMOD5_System_RecordStop(IntPtr system, int id);

		[PreserveSig]
		[Token(Token = "0x600062F")]
		[Address(RVA = "0x24B6B40", Offset = "0x24B6B40", VA = "0x24B6B40")]
		private static extern RESULT FMOD5_System_IsRecording(IntPtr system, int id, out bool recording);

		[PreserveSig]
		[Token(Token = "0x6000630")]
		[Address(RVA = "0x24B6BF4", Offset = "0x24B6BF4", VA = "0x24B6BF4")]
		private static extern RESULT FMOD5_System_CreateGeometry(IntPtr system, int maxpolygons, int maxvertices, out IntPtr geometry);

		[PreserveSig]
		[Token(Token = "0x6000631")]
		[Address(RVA = "0x24B6CA4", Offset = "0x24B6CA4", VA = "0x24B6CA4")]
		private static extern RESULT FMOD5_System_SetGeometrySettings(IntPtr system, float maxworldsize);

		[PreserveSig]
		[Token(Token = "0x6000632")]
		[Address(RVA = "0x24B6D3C", Offset = "0x24B6D3C", VA = "0x24B6D3C")]
		private static extern RESULT FMOD5_System_GetGeometrySettings(IntPtr system, out float maxworldsize);

		[PreserveSig]
		[Token(Token = "0x6000633")]
		[Address(RVA = "0x24B6DD4", Offset = "0x24B6DD4", VA = "0x24B6DD4")]
		private static extern RESULT FMOD5_System_LoadGeometry(IntPtr system, IntPtr data, int datasize, out IntPtr geometry);

		[PreserveSig]
		[Token(Token = "0x6000634")]
		[Address(RVA = "0x24B6E84", Offset = "0x24B6E84", VA = "0x24B6E84")]
		private static extern RESULT FMOD5_System_GetGeometryOcclusion(IntPtr system, ref VECTOR listener, ref VECTOR source, out float direct, out float reverb);

		[PreserveSig]
		[Token(Token = "0x6000635")]
		[Address(RVA = "0x24B7084", Offset = "0x24B7084", VA = "0x24B7084")]
		private static extern RESULT FMOD5_System_SetNetworkProxy(IntPtr system, byte[] proxy);

		[PreserveSig]
		[Token(Token = "0x6000636")]
		[Address(RVA = "0x24B72D0", Offset = "0x24B72D0", VA = "0x24B72D0")]
		private static extern RESULT FMOD5_System_GetNetworkProxy(IntPtr system, IntPtr proxy, int proxylen);

		[PreserveSig]
		[Token(Token = "0x6000637")]
		[Address(RVA = "0x24B7370", Offset = "0x24B7370", VA = "0x24B7370")]
		private static extern RESULT FMOD5_System_SetNetworkTimeout(IntPtr system, int timeout);

		[PreserveSig]
		[Token(Token = "0x6000638")]
		[Address(RVA = "0x24B7408", Offset = "0x24B7408", VA = "0x24B7408")]
		private static extern RESULT FMOD5_System_GetNetworkTimeout(IntPtr system, out int timeout);

		[PreserveSig]
		[Token(Token = "0x6000639")]
		[Address(RVA = "0x24B74A0", Offset = "0x24B74A0", VA = "0x24B74A0")]
		private static extern RESULT FMOD5_System_SetUserData(IntPtr system, IntPtr userdata);

		[PreserveSig]
		[Token(Token = "0x600063A")]
		[Address(RVA = "0x24B7538", Offset = "0x24B7538", VA = "0x24B7538")]
		private static extern RESULT FMOD5_System_GetUserData(IntPtr system, out IntPtr userdata);

		[Token(Token = "0x600063B")]
		[Address(RVA = "0x155E7B4", Offset = "0x155E7B4", VA = "0x155E7B4")]
		public bool hasHandle()
		{
			return default(bool);
		}

		[Token(Token = "0x600063C")]
		[Address(RVA = "0x155E7BC", Offset = "0x155E7BC", VA = "0x155E7BC")]
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
		[Address(RVA = "0x10ED684", Offset = "0x10ED684", VA = "0x10ED684")]
		public RESULT release()
		{
			return default(RESULT);
		}

		[Token(Token = "0x600063E")]
		[Address(RVA = "0x10ED68C", Offset = "0x10ED68C", VA = "0x10ED68C")]
		public RESULT getSystemObject(out System system)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600063F")]
		[Address(RVA = "0x10ED694", Offset = "0x10ED694", VA = "0x10ED694")]
		public RESULT @lock(uint offset, uint length, out IntPtr ptr1, out IntPtr ptr2, out uint len1, out uint len2)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000640")]
		[Address(RVA = "0x10ED69C", Offset = "0x10ED69C", VA = "0x10ED69C")]
		public RESULT unlock(IntPtr ptr1, IntPtr ptr2, uint len1, uint len2)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000641")]
		[Address(RVA = "0x10ED6A4", Offset = "0x10ED6A4", VA = "0x10ED6A4")]
		public RESULT setDefaults(float frequency, int priority)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000642")]
		[Address(RVA = "0x10ED6AC", Offset = "0x10ED6AC", VA = "0x10ED6AC")]
		public RESULT getDefaults(out float frequency, out int priority)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000643")]
		[Address(RVA = "0x10ED6B4", Offset = "0x10ED6B4", VA = "0x10ED6B4")]
		public RESULT set3DMinMaxDistance(float min, float max)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000644")]
		[Address(RVA = "0x10ED6BC", Offset = "0x10ED6BC", VA = "0x10ED6BC")]
		public RESULT get3DMinMaxDistance(out float min, out float max)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000645")]
		[Address(RVA = "0x10ED6C4", Offset = "0x10ED6C4", VA = "0x10ED6C4")]
		public RESULT set3DConeSettings(float insideconeangle, float outsideconeangle, float outsidevolume)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000646")]
		[Address(RVA = "0x10ED6CC", Offset = "0x10ED6CC", VA = "0x10ED6CC")]
		public RESULT get3DConeSettings(out float insideconeangle, out float outsideconeangle, out float outsidevolume)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000647")]
		[Address(RVA = "0x10ED6D4", Offset = "0x10ED6D4", VA = "0x10ED6D4")]
		public RESULT set3DCustomRolloff(ref VECTOR points, int numpoints)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000648")]
		[Address(RVA = "0x10ED6DC", Offset = "0x10ED6DC", VA = "0x10ED6DC")]
		public RESULT get3DCustomRolloff(out IntPtr points, out int numpoints)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000649")]
		[Address(RVA = "0x10ED6E4", Offset = "0x10ED6E4", VA = "0x10ED6E4")]
		public RESULT getSubSound(int index, out Sound subsound)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600064A")]
		[Address(RVA = "0x10ED6EC", Offset = "0x10ED6EC", VA = "0x10ED6EC")]
		public RESULT getSubSoundParent(out Sound parentsound)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600064B")]
		[Address(RVA = "0x10ED6F4", Offset = "0x10ED6F4", VA = "0x10ED6F4")]
		public RESULT getName(out string name, int namelen)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600064C")]
		[Address(RVA = "0x10ED6FC", Offset = "0x10ED6FC", VA = "0x10ED6FC")]
		public RESULT getLength(out uint length, TIMEUNIT lengthtype)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600064D")]
		[Address(RVA = "0x10ED704", Offset = "0x10ED704", VA = "0x10ED704")]
		public RESULT getFormat(out SOUND_TYPE type, out SOUND_FORMAT format, out int channels, out int bits)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600064E")]
		[Address(RVA = "0x10ED70C", Offset = "0x10ED70C", VA = "0x10ED70C")]
		public RESULT getNumSubSounds(out int numsubsounds)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600064F")]
		[Address(RVA = "0x10ED714", Offset = "0x10ED714", VA = "0x10ED714")]
		public RESULT getNumTags(out int numtags, out int numtagsupdated)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000650")]
		[Address(RVA = "0x10ED71C", Offset = "0x10ED71C", VA = "0x10ED71C")]
		public RESULT getTag(string name, int index, out TAG tag)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000651")]
		[Address(RVA = "0x10ED724", Offset = "0x10ED724", VA = "0x10ED724")]
		public RESULT getOpenState(out OPENSTATE openstate, out uint percentbuffered, out bool starving, out bool diskbusy)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000652")]
		[Address(RVA = "0x10ED72C", Offset = "0x10ED72C", VA = "0x10ED72C")]
		public RESULT readData(IntPtr buffer, uint length, out uint read)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000653")]
		[Address(RVA = "0x10ED734", Offset = "0x10ED734", VA = "0x10ED734")]
		public RESULT seekData(uint pcm)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000654")]
		[Address(RVA = "0x10ED73C", Offset = "0x10ED73C", VA = "0x10ED73C")]
		public RESULT setSoundGroup(SoundGroup soundgroup)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000655")]
		[Address(RVA = "0x10ED744", Offset = "0x10ED744", VA = "0x10ED744")]
		public RESULT getSoundGroup(out SoundGroup soundgroup)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000656")]
		[Address(RVA = "0x10ED74C", Offset = "0x10ED74C", VA = "0x10ED74C")]
		public RESULT getNumSyncPoints(out int numsyncpoints)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000657")]
		[Address(RVA = "0x10ED754", Offset = "0x10ED754", VA = "0x10ED754")]
		public RESULT getSyncPoint(int index, out IntPtr point)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000658")]
		[Address(RVA = "0x10ED75C", Offset = "0x10ED75C", VA = "0x10ED75C")]
		public RESULT getSyncPointInfo(IntPtr point, out string name, int namelen, out uint offset, TIMEUNIT offsettype)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000659")]
		[Address(RVA = "0x10ED764", Offset = "0x10ED764", VA = "0x10ED764")]
		public RESULT getSyncPointInfo(IntPtr point, out uint offset, TIMEUNIT offsettype)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600065A")]
		[Address(RVA = "0x10ED76C", Offset = "0x10ED76C", VA = "0x10ED76C")]
		public RESULT addSyncPoint(uint offset, TIMEUNIT offsettype, string name, out IntPtr point)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600065B")]
		[Address(RVA = "0x10ED774", Offset = "0x10ED774", VA = "0x10ED774")]
		public RESULT deleteSyncPoint(IntPtr point)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600065C")]
		[Address(RVA = "0x10ED77C", Offset = "0x10ED77C", VA = "0x10ED77C")]
		public RESULT setMode(MODE mode)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600065D")]
		[Address(RVA = "0x10ED784", Offset = "0x10ED784", VA = "0x10ED784")]
		public RESULT getMode(out MODE mode)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600065E")]
		[Address(RVA = "0x10ED78C", Offset = "0x10ED78C", VA = "0x10ED78C")]
		public RESULT setLoopCount(int loopcount)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600065F")]
		[Address(RVA = "0x10ED794", Offset = "0x10ED794", VA = "0x10ED794")]
		public RESULT getLoopCount(out int loopcount)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000660")]
		[Address(RVA = "0x10ED79C", Offset = "0x10ED79C", VA = "0x10ED79C")]
		public RESULT setLoopPoints(uint loopstart, TIMEUNIT loopstarttype, uint loopend, TIMEUNIT loopendtype)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000661")]
		[Address(RVA = "0x10ED7A4", Offset = "0x10ED7A4", VA = "0x10ED7A4")]
		public RESULT getLoopPoints(out uint loopstart, TIMEUNIT loopstarttype, out uint loopend, TIMEUNIT loopendtype)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000662")]
		[Address(RVA = "0x10ED7AC", Offset = "0x10ED7AC", VA = "0x10ED7AC")]
		public RESULT getMusicNumChannels(out int numchannels)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000663")]
		[Address(RVA = "0x10ED7B4", Offset = "0x10ED7B4", VA = "0x10ED7B4")]
		public RESULT setMusicChannelVolume(int channel, float volume)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000664")]
		[Address(RVA = "0x10ED7BC", Offset = "0x10ED7BC", VA = "0x10ED7BC")]
		public RESULT getMusicChannelVolume(int channel, out float volume)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000665")]
		[Address(RVA = "0x10ED7C4", Offset = "0x10ED7C4", VA = "0x10ED7C4")]
		public RESULT setMusicSpeed(float speed)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000666")]
		[Address(RVA = "0x10ED7CC", Offset = "0x10ED7CC", VA = "0x10ED7CC")]
		public RESULT getMusicSpeed(out float speed)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000667")]
		[Address(RVA = "0x10ED7D4", Offset = "0x10ED7D4", VA = "0x10ED7D4")]
		public RESULT setUserData(IntPtr userdata)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000668")]
		[Address(RVA = "0x10ED7DC", Offset = "0x10ED7DC", VA = "0x10ED7DC")]
		public RESULT getUserData(out IntPtr userdata)
		{
			return default(RESULT);
		}

		[PreserveSig]
		[Token(Token = "0x6000669")]
		[Address(RVA = "0x17F29A4", Offset = "0x17F29A4", VA = "0x17F29A4")]
		private static extern RESULT FMOD5_Sound_Release(IntPtr sound);

		[PreserveSig]
		[Token(Token = "0x600066A")]
		[Address(RVA = "0x17F2A2C", Offset = "0x17F2A2C", VA = "0x17F2A2C")]
		private static extern RESULT FMOD5_Sound_GetSystemObject(IntPtr sound, out IntPtr system);

		[PreserveSig]
		[Token(Token = "0x600066B")]
		[Address(RVA = "0x17F2AC4", Offset = "0x17F2AC4", VA = "0x17F2AC4")]
		private static extern RESULT FMOD5_Sound_Lock(IntPtr sound, uint offset, uint length, out IntPtr ptr1, out IntPtr ptr2, out uint len1, out uint len2);

		[PreserveSig]
		[Token(Token = "0x600066C")]
		[Address(RVA = "0x17F2B94", Offset = "0x17F2B94", VA = "0x17F2B94")]
		private static extern RESULT FMOD5_Sound_Unlock(IntPtr sound, IntPtr ptr1, IntPtr ptr2, uint len1, uint len2);

		[PreserveSig]
		[Token(Token = "0x600066D")]
		[Address(RVA = "0x17F2C4C", Offset = "0x17F2C4C", VA = "0x17F2C4C")]
		private static extern RESULT FMOD5_Sound_SetDefaults(IntPtr sound, float frequency, int priority);

		[PreserveSig]
		[Token(Token = "0x600066E")]
		[Address(RVA = "0x17F2CF4", Offset = "0x17F2CF4", VA = "0x17F2CF4")]
		private static extern RESULT FMOD5_Sound_GetDefaults(IntPtr sound, out float frequency, out int priority);

		[PreserveSig]
		[Token(Token = "0x600066F")]
		[Address(RVA = "0x17F2D94", Offset = "0x17F2D94", VA = "0x17F2D94")]
		private static extern RESULT FMOD5_Sound_Set3DMinMaxDistance(IntPtr sound, float min, float max);

		[PreserveSig]
		[Token(Token = "0x6000670")]
		[Address(RVA = "0x17F2E34", Offset = "0x17F2E34", VA = "0x17F2E34")]
		private static extern RESULT FMOD5_Sound_Get3DMinMaxDistance(IntPtr sound, out float min, out float max);

		[PreserveSig]
		[Token(Token = "0x6000671")]
		[Address(RVA = "0x17F2ED4", Offset = "0x17F2ED4", VA = "0x17F2ED4")]
		private static extern RESULT FMOD5_Sound_Set3DConeSettings(IntPtr sound, float insideconeangle, float outsideconeangle, float outsidevolume);

		[PreserveSig]
		[Token(Token = "0x6000672")]
		[Address(RVA = "0x17F2F84", Offset = "0x17F2F84", VA = "0x17F2F84")]
		private static extern RESULT FMOD5_Sound_Get3DConeSettings(IntPtr sound, out float insideconeangle, out float outsideconeangle, out float outsidevolume);

		[PreserveSig]
		[Token(Token = "0x6000673")]
		[Address(RVA = "0x17F3034", Offset = "0x17F3034", VA = "0x17F3034")]
		private static extern RESULT FMOD5_Sound_Set3DCustomRolloff(IntPtr sound, ref VECTOR points, int numpoints);

		[PreserveSig]
		[Token(Token = "0x6000674")]
		[Address(RVA = "0x17F30D4", Offset = "0x17F30D4", VA = "0x17F30D4")]
		private static extern RESULT FMOD5_Sound_Get3DCustomRolloff(IntPtr sound, out IntPtr points, out int numpoints);

		[PreserveSig]
		[Token(Token = "0x6000675")]
		[Address(RVA = "0x17F3174", Offset = "0x17F3174", VA = "0x17F3174")]
		private static extern RESULT FMOD5_Sound_GetSubSound(IntPtr sound, int index, out IntPtr subsound);

		[PreserveSig]
		[Token(Token = "0x6000676")]
		[Address(RVA = "0x17F3214", Offset = "0x17F3214", VA = "0x17F3214")]
		private static extern RESULT FMOD5_Sound_GetSubSoundParent(IntPtr sound, out IntPtr parentsound);

		[PreserveSig]
		[Token(Token = "0x6000677")]
		[Address(RVA = "0x17F3450", Offset = "0x17F3450", VA = "0x17F3450")]
		private static extern RESULT FMOD5_Sound_GetName(IntPtr sound, IntPtr name, int namelen);

		[PreserveSig]
		[Token(Token = "0x6000678")]
		[Address(RVA = "0x17F3970", Offset = "0x17F3970", VA = "0x17F3970")]
		private static extern RESULT FMOD5_Sound_GetLength(IntPtr sound, out uint length, TIMEUNIT lengthtype);

		[PreserveSig]
		[Token(Token = "0x6000679")]
		[Address(RVA = "0x17F3A10", Offset = "0x17F3A10", VA = "0x17F3A10")]
		private static extern RESULT FMOD5_Sound_GetFormat(IntPtr sound, out SOUND_TYPE type, out SOUND_FORMAT format, out int channels, out int bits);

		[PreserveSig]
		[Token(Token = "0x600067A")]
		[Address(RVA = "0x17F3AC8", Offset = "0x17F3AC8", VA = "0x17F3AC8")]
		private static extern RESULT FMOD5_Sound_GetNumSubSounds(IntPtr sound, out int numsubsounds);

		[PreserveSig]
		[Token(Token = "0x600067B")]
		[Address(RVA = "0x17F3B60", Offset = "0x17F3B60", VA = "0x17F3B60")]
		private static extern RESULT FMOD5_Sound_GetNumTags(IntPtr sound, out int numtags, out int numtagsupdated);

		[PreserveSig]
		[Token(Token = "0x600067C")]
		[Address(RVA = "0x17F3E98", Offset = "0x17F3E98", VA = "0x17F3E98")]
		private static extern RESULT FMOD5_Sound_GetTag(IntPtr sound, byte[] name, int index, out TAG tag);

		[PreserveSig]
		[Token(Token = "0x600067D")]
		[Address(RVA = "0x17F3F84", Offset = "0x17F3F84", VA = "0x17F3F84")]
		private static extern RESULT FMOD5_Sound_GetOpenState(IntPtr sound, out OPENSTATE openstate, out uint percentbuffered, out bool starving, out bool diskbusy);

		[PreserveSig]
		[Token(Token = "0x600067E")]
		[Address(RVA = "0x17F4060", Offset = "0x17F4060", VA = "0x17F4060")]
		private static extern RESULT FMOD5_Sound_ReadData(IntPtr sound, IntPtr buffer, uint length, out uint read);

		[PreserveSig]
		[Token(Token = "0x600067F")]
		[Address(RVA = "0x17F4110", Offset = "0x17F4110", VA = "0x17F4110")]
		private static extern RESULT FMOD5_Sound_SeekData(IntPtr sound, uint pcm);

		[PreserveSig]
		[Token(Token = "0x6000680")]
		[Address(RVA = "0x17F41A8", Offset = "0x17F41A8", VA = "0x17F41A8")]
		private static extern RESULT FMOD5_Sound_SetSoundGroup(IntPtr sound, IntPtr soundgroup);

		[PreserveSig]
		[Token(Token = "0x6000681")]
		[Address(RVA = "0x17F4240", Offset = "0x17F4240", VA = "0x17F4240")]
		private static extern RESULT FMOD5_Sound_GetSoundGroup(IntPtr sound, out IntPtr soundgroup);

		[PreserveSig]
		[Token(Token = "0x6000682")]
		[Address(RVA = "0x17F42D8", Offset = "0x17F42D8", VA = "0x17F42D8")]
		private static extern RESULT FMOD5_Sound_GetNumSyncPoints(IntPtr sound, out int numsyncpoints);

		[PreserveSig]
		[Token(Token = "0x6000683")]
		[Address(RVA = "0x17F4370", Offset = "0x17F4370", VA = "0x17F4370")]
		private static extern RESULT FMOD5_Sound_GetSyncPoint(IntPtr sound, int index, out IntPtr point);

		[PreserveSig]
		[Token(Token = "0x6000684")]
		[Address(RVA = "0x17F45D4", Offset = "0x17F45D4", VA = "0x17F45D4")]
		private static extern RESULT FMOD5_Sound_GetSyncPointInfo(IntPtr sound, IntPtr point, IntPtr name, int namelen, out uint offset, TIMEUNIT offsettype);

		[PreserveSig]
		[Token(Token = "0x6000685")]
		[Address(RVA = "0x17F4870", Offset = "0x17F4870", VA = "0x17F4870")]
		private static extern RESULT FMOD5_Sound_AddSyncPoint(IntPtr sound, uint offset, TIMEUNIT offsettype, byte[] name, out IntPtr point);

		[PreserveSig]
		[Token(Token = "0x6000686")]
		[Address(RVA = "0x17F4930", Offset = "0x17F4930", VA = "0x17F4930")]
		private static extern RESULT FMOD5_Sound_DeleteSyncPoint(IntPtr sound, IntPtr point);

		[PreserveSig]
		[Token(Token = "0x6000687")]
		[Address(RVA = "0x17F49C8", Offset = "0x17F49C8", VA = "0x17F49C8")]
		private static extern RESULT FMOD5_Sound_SetMode(IntPtr sound, MODE mode);

		[PreserveSig]
		[Token(Token = "0x6000688")]
		[Address(RVA = "0x17F4A60", Offset = "0x17F4A60", VA = "0x17F4A60")]
		private static extern RESULT FMOD5_Sound_GetMode(IntPtr sound, out MODE mode);

		[PreserveSig]
		[Token(Token = "0x6000689")]
		[Address(RVA = "0x17F4AF8", Offset = "0x17F4AF8", VA = "0x17F4AF8")]
		private static extern RESULT FMOD5_Sound_SetLoopCount(IntPtr sound, int loopcount);

		[PreserveSig]
		[Token(Token = "0x600068A")]
		[Address(RVA = "0x17F4B90", Offset = "0x17F4B90", VA = "0x17F4B90")]
		private static extern RESULT FMOD5_Sound_GetLoopCount(IntPtr sound, out int loopcount);

		[PreserveSig]
		[Token(Token = "0x600068B")]
		[Address(RVA = "0x17F4C28", Offset = "0x17F4C28", VA = "0x17F4C28")]
		private static extern RESULT FMOD5_Sound_SetLoopPoints(IntPtr sound, uint loopstart, TIMEUNIT loopstarttype, uint loopend, TIMEUNIT loopendtype);

		[PreserveSig]
		[Token(Token = "0x600068C")]
		[Address(RVA = "0x17F4CE0", Offset = "0x17F4CE0", VA = "0x17F4CE0")]
		private static extern RESULT FMOD5_Sound_GetLoopPoints(IntPtr sound, out uint loopstart, TIMEUNIT loopstarttype, out uint loopend, TIMEUNIT loopendtype);

		[PreserveSig]
		[Token(Token = "0x600068D")]
		[Address(RVA = "0x17F4D98", Offset = "0x17F4D98", VA = "0x17F4D98")]
		private static extern RESULT FMOD5_Sound_GetMusicNumChannels(IntPtr sound, out int numchannels);

		[PreserveSig]
		[Token(Token = "0x600068E")]
		[Address(RVA = "0x17F4E30", Offset = "0x17F4E30", VA = "0x17F4E30")]
		private static extern RESULT FMOD5_Sound_SetMusicChannelVolume(IntPtr sound, int channel, float volume);

		[PreserveSig]
		[Token(Token = "0x600068F")]
		[Address(RVA = "0x17F4ED8", Offset = "0x17F4ED8", VA = "0x17F4ED8")]
		private static extern RESULT FMOD5_Sound_GetMusicChannelVolume(IntPtr sound, int channel, out float volume);

		[PreserveSig]
		[Token(Token = "0x6000690")]
		[Address(RVA = "0x17F4F78", Offset = "0x17F4F78", VA = "0x17F4F78")]
		private static extern RESULT FMOD5_Sound_SetMusicSpeed(IntPtr sound, float speed);

		[PreserveSig]
		[Token(Token = "0x6000691")]
		[Address(RVA = "0x17F5010", Offset = "0x17F5010", VA = "0x17F5010")]
		private static extern RESULT FMOD5_Sound_GetMusicSpeed(IntPtr sound, out float speed);

		[PreserveSig]
		[Token(Token = "0x6000692")]
		[Address(RVA = "0x17F50A8", Offset = "0x17F50A8", VA = "0x17F50A8")]
		private static extern RESULT FMOD5_Sound_SetUserData(IntPtr sound, IntPtr userdata);

		[PreserveSig]
		[Token(Token = "0x6000693")]
		[Address(RVA = "0x17F5140", Offset = "0x17F5140", VA = "0x17F5140")]
		private static extern RESULT FMOD5_Sound_GetUserData(IntPtr sound, out IntPtr userdata);

		[Token(Token = "0x6000694")]
		[Address(RVA = "0x10ED7E4", Offset = "0x10ED7E4", VA = "0x10ED7E4")]
		public bool hasHandle()
		{
			return default(bool);
		}

		[Token(Token = "0x6000695")]
		[Address(RVA = "0x10ED7EC", Offset = "0x10ED7EC", VA = "0x10ED7EC")]
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
		[Address(RVA = "0x10EEA98", Offset = "0x10EEA98", VA = "0x10EEA98")]
		public RESULT setFrequency(float frequency)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60006D5")]
		[Address(RVA = "0x10EEAA0", Offset = "0x10EEAA0", VA = "0x10EEAA0")]
		public RESULT getFrequency(out float frequency)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60006D6")]
		[Address(RVA = "0x10EEAA8", Offset = "0x10EEAA8", VA = "0x10EEAA8")]
		public RESULT setPriority(int priority)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60006D7")]
		[Address(RVA = "0x10EEAB0", Offset = "0x10EEAB0", VA = "0x10EEAB0")]
		public RESULT getPriority(out int priority)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60006D8")]
		[Address(RVA = "0x10EEAB8", Offset = "0x10EEAB8", VA = "0x10EEAB8")]
		public RESULT setPosition(uint position, TIMEUNIT postype)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60006D9")]
		[Address(RVA = "0x10EEAC0", Offset = "0x10EEAC0", VA = "0x10EEAC0")]
		public RESULT getPosition(out uint position, TIMEUNIT postype)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60006DA")]
		[Address(RVA = "0x10EEAC8", Offset = "0x10EEAC8", VA = "0x10EEAC8")]
		public RESULT setChannelGroup(ChannelGroup channelgroup)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60006DB")]
		[Address(RVA = "0x10EEAD0", Offset = "0x10EEAD0", VA = "0x10EEAD0")]
		public RESULT getChannelGroup(out ChannelGroup channelgroup)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60006DC")]
		[Address(RVA = "0x10EEAD8", Offset = "0x10EEAD8", VA = "0x10EEAD8")]
		public RESULT setLoopCount(int loopcount)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60006DD")]
		[Address(RVA = "0x10EEAE0", Offset = "0x10EEAE0", VA = "0x10EEAE0")]
		public RESULT getLoopCount(out int loopcount)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60006DE")]
		[Address(RVA = "0x10EEAE8", Offset = "0x10EEAE8", VA = "0x10EEAE8")]
		public RESULT setLoopPoints(uint loopstart, TIMEUNIT loopstarttype, uint loopend, TIMEUNIT loopendtype)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60006DF")]
		[Address(RVA = "0x10EEAF0", Offset = "0x10EEAF0", VA = "0x10EEAF0")]
		public RESULT getLoopPoints(out uint loopstart, TIMEUNIT loopstarttype, out uint loopend, TIMEUNIT loopendtype)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60006E0")]
		[Address(RVA = "0x10EEAF8", Offset = "0x10EEAF8", VA = "0x10EEAF8")]
		public RESULT isVirtual(out bool isvirtual)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60006E1")]
		[Address(RVA = "0x10EEB00", Offset = "0x10EEB00", VA = "0x10EEB00")]
		public RESULT getCurrentSound(out Sound sound)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60006E2")]
		[Address(RVA = "0x10EEB08", Offset = "0x10EEB08", VA = "0x10EEB08")]
		public RESULT getIndex(out int index)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60006E3")]
		[Address(RVA = "0x10EEB10", Offset = "0x10EEB10", VA = "0x10EEB10", Slot = "4")]
		public RESULT getSystemObject(out System system)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60006E4")]
		[Address(RVA = "0x10EEB18", Offset = "0x10EEB18", VA = "0x10EEB18", Slot = "5")]
		public RESULT stop()
		{
			return default(RESULT);
		}

		[Token(Token = "0x60006E5")]
		[Address(RVA = "0x10EEB20", Offset = "0x10EEB20", VA = "0x10EEB20", Slot = "6")]
		public RESULT setPaused(bool paused)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60006E6")]
		[Address(RVA = "0x10EEB2C", Offset = "0x10EEB2C", VA = "0x10EEB2C", Slot = "7")]
		public RESULT getPaused(out bool paused)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60006E7")]
		[Address(RVA = "0x10EEB34", Offset = "0x10EEB34", VA = "0x10EEB34", Slot = "8")]
		public RESULT setVolume(float volume)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60006E8")]
		[Address(RVA = "0x10EEB3C", Offset = "0x10EEB3C", VA = "0x10EEB3C", Slot = "9")]
		public RESULT getVolume(out float volume)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60006E9")]
		[Address(RVA = "0x10EEB44", Offset = "0x10EEB44", VA = "0x10EEB44", Slot = "10")]
		public RESULT setVolumeRamp(bool ramp)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60006EA")]
		[Address(RVA = "0x10EEB50", Offset = "0x10EEB50", VA = "0x10EEB50", Slot = "11")]
		public RESULT getVolumeRamp(out bool ramp)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60006EB")]
		[Address(RVA = "0x10EEB58", Offset = "0x10EEB58", VA = "0x10EEB58", Slot = "12")]
		public RESULT getAudibility(out float audibility)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60006EC")]
		[Address(RVA = "0x10EEB60", Offset = "0x10EEB60", VA = "0x10EEB60", Slot = "13")]
		public RESULT setPitch(float pitch)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60006ED")]
		[Address(RVA = "0x10EEB68", Offset = "0x10EEB68", VA = "0x10EEB68", Slot = "14")]
		public RESULT getPitch(out float pitch)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60006EE")]
		[Address(RVA = "0x10EEB70", Offset = "0x10EEB70", VA = "0x10EEB70", Slot = "15")]
		public RESULT setMute(bool mute)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60006EF")]
		[Address(RVA = "0x10EEB7C", Offset = "0x10EEB7C", VA = "0x10EEB7C", Slot = "16")]
		public RESULT getMute(out bool mute)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60006F0")]
		[Address(RVA = "0x10EEB84", Offset = "0x10EEB84", VA = "0x10EEB84", Slot = "17")]
		public RESULT setReverbProperties(int instance, float wet)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60006F1")]
		[Address(RVA = "0x10EEB8C", Offset = "0x10EEB8C", VA = "0x10EEB8C", Slot = "18")]
		public RESULT getReverbProperties(int instance, out float wet)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60006F2")]
		[Address(RVA = "0x10EEB94", Offset = "0x10EEB94", VA = "0x10EEB94", Slot = "19")]
		public RESULT setLowPassGain(float gain)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60006F3")]
		[Address(RVA = "0x10EEB9C", Offset = "0x10EEB9C", VA = "0x10EEB9C", Slot = "20")]
		public RESULT getLowPassGain(out float gain)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60006F4")]
		[Address(RVA = "0x10EEBA4", Offset = "0x10EEBA4", VA = "0x10EEBA4", Slot = "21")]
		public RESULT setMode(MODE mode)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60006F5")]
		[Address(RVA = "0x10EEBAC", Offset = "0x10EEBAC", VA = "0x10EEBAC", Slot = "22")]
		public RESULT getMode(out MODE mode)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60006F6")]
		[Address(RVA = "0x10EEBB4", Offset = "0x10EEBB4", VA = "0x10EEBB4", Slot = "23")]
		public RESULT setCallback(CHANNELCONTROL_CALLBACK callback)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60006F7")]
		[Address(RVA = "0x10EEBBC", Offset = "0x10EEBBC", VA = "0x10EEBBC", Slot = "24")]
		public RESULT isPlaying(out bool isplaying)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60006F8")]
		[Address(RVA = "0x10EEBC4", Offset = "0x10EEBC4", VA = "0x10EEBC4", Slot = "25")]
		public RESULT setPan(float pan)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60006F9")]
		[Address(RVA = "0x10EEBCC", Offset = "0x10EEBCC", VA = "0x10EEBCC", Slot = "26")]
		public RESULT setMixLevelsOutput(float frontleft, float frontright, float center, float lfe, float surroundleft, float surroundright, float backleft, float backright)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60006FA")]
		[Address(RVA = "0x10EEBD4", Offset = "0x10EEBD4", VA = "0x10EEBD4", Slot = "27")]
		public RESULT setMixLevelsInput(float[] levels, int numlevels)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60006FB")]
		[Address(RVA = "0x10EEBDC", Offset = "0x10EEBDC", VA = "0x10EEBDC", Slot = "28")]
		public RESULT setMixMatrix(float[] matrix, int outchannels, int inchannels, int inchannel_hop = 0)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60006FC")]
		[Address(RVA = "0x10EEBE4", Offset = "0x10EEBE4", VA = "0x10EEBE4", Slot = "29")]
		public RESULT getMixMatrix(float[] matrix, out int outchannels, out int inchannels, int inchannel_hop = 0)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60006FD")]
		[Address(RVA = "0x10EEBEC", Offset = "0x10EEBEC", VA = "0x10EEBEC", Slot = "30")]
		public RESULT getDSPClock(out ulong dspclock, out ulong parentclock)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60006FE")]
		[Address(RVA = "0x10EEBF4", Offset = "0x10EEBF4", VA = "0x10EEBF4", Slot = "31")]
		public RESULT setDelay(ulong dspclock_start, ulong dspclock_end, bool stopchannels = true)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60006FF")]
		[Address(RVA = "0x10EEC00", Offset = "0x10EEC00", VA = "0x10EEC00", Slot = "32")]
		public RESULT getDelay(out ulong dspclock_start, out ulong dspclock_end)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000700")]
		[Address(RVA = "0x10EEC08", Offset = "0x10EEC08", VA = "0x10EEC08", Slot = "33")]
		public RESULT getDelay(out ulong dspclock_start, out ulong dspclock_end, out bool stopchannels)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000701")]
		[Address(RVA = "0x10EEC10", Offset = "0x10EEC10", VA = "0x10EEC10", Slot = "34")]
		public RESULT addFadePoint(ulong dspclock, float volume)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000702")]
		[Address(RVA = "0x10EEC18", Offset = "0x10EEC18", VA = "0x10EEC18", Slot = "35")]
		public RESULT setFadePointRamp(ulong dspclock, float volume)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000703")]
		[Address(RVA = "0x10EEC20", Offset = "0x10EEC20", VA = "0x10EEC20", Slot = "36")]
		public RESULT removeFadePoints(ulong dspclock_start, ulong dspclock_end)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000704")]
		[Address(RVA = "0x10EEC28", Offset = "0x10EEC28", VA = "0x10EEC28", Slot = "37")]
		public RESULT getFadePoints(ref uint numpoints, ulong[] point_dspclock, float[] point_volume)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000705")]
		[Address(RVA = "0x10EEC30", Offset = "0x10EEC30", VA = "0x10EEC30", Slot = "38")]
		public RESULT getDSP(int index, out DSP dsp)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000706")]
		[Address(RVA = "0x10EEC38", Offset = "0x10EEC38", VA = "0x10EEC38", Slot = "39")]
		public RESULT addDSP(int index, DSP dsp)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000707")]
		[Address(RVA = "0x10EEC40", Offset = "0x10EEC40", VA = "0x10EEC40", Slot = "40")]
		public RESULT removeDSP(DSP dsp)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000708")]
		[Address(RVA = "0x10EEC48", Offset = "0x10EEC48", VA = "0x10EEC48", Slot = "41")]
		public RESULT getNumDSPs(out int numdsps)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000709")]
		[Address(RVA = "0x10EEC50", Offset = "0x10EEC50", VA = "0x10EEC50", Slot = "42")]
		public RESULT setDSPIndex(DSP dsp, int index)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600070A")]
		[Address(RVA = "0x10EEC58", Offset = "0x10EEC58", VA = "0x10EEC58", Slot = "43")]
		public RESULT getDSPIndex(DSP dsp, out int index)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600070B")]
		[Address(RVA = "0x10EEC60", Offset = "0x10EEC60", VA = "0x10EEC60", Slot = "44")]
		public RESULT set3DAttributes(ref VECTOR pos, ref VECTOR vel)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600070C")]
		[Address(RVA = "0x10EEC68", Offset = "0x10EEC68", VA = "0x10EEC68", Slot = "45")]
		public RESULT get3DAttributes(out VECTOR pos, out VECTOR vel)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600070D")]
		[Address(RVA = "0x10EEC70", Offset = "0x10EEC70", VA = "0x10EEC70", Slot = "46")]
		public RESULT set3DMinMaxDistance(float mindistance, float maxdistance)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600070E")]
		[Address(RVA = "0x10EEC78", Offset = "0x10EEC78", VA = "0x10EEC78", Slot = "47")]
		public RESULT get3DMinMaxDistance(out float mindistance, out float maxdistance)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600070F")]
		[Address(RVA = "0x10EEC80", Offset = "0x10EEC80", VA = "0x10EEC80", Slot = "48")]
		public RESULT set3DConeSettings(float insideconeangle, float outsideconeangle, float outsidevolume)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000710")]
		[Address(RVA = "0x10EEC88", Offset = "0x10EEC88", VA = "0x10EEC88", Slot = "49")]
		public RESULT get3DConeSettings(out float insideconeangle, out float outsideconeangle, out float outsidevolume)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000711")]
		[Address(RVA = "0x10EEC90", Offset = "0x10EEC90", VA = "0x10EEC90", Slot = "50")]
		public RESULT set3DConeOrientation(ref VECTOR orientation)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000712")]
		[Address(RVA = "0x10EEC98", Offset = "0x10EEC98", VA = "0x10EEC98", Slot = "51")]
		public RESULT get3DConeOrientation(out VECTOR orientation)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000713")]
		[Address(RVA = "0x10EECA0", Offset = "0x10EECA0", VA = "0x10EECA0", Slot = "52")]
		public RESULT set3DCustomRolloff(ref VECTOR points, int numpoints)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000714")]
		[Address(RVA = "0x10EECA8", Offset = "0x10EECA8", VA = "0x10EECA8", Slot = "53")]
		public RESULT get3DCustomRolloff(out IntPtr points, out int numpoints)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000715")]
		[Address(RVA = "0x10EECB0", Offset = "0x10EECB0", VA = "0x10EECB0", Slot = "54")]
		public RESULT set3DOcclusion(float directocclusion, float reverbocclusion)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000716")]
		[Address(RVA = "0x10EECB8", Offset = "0x10EECB8", VA = "0x10EECB8", Slot = "55")]
		public RESULT get3DOcclusion(out float directocclusion, out float reverbocclusion)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000717")]
		[Address(RVA = "0x10EECC0", Offset = "0x10EECC0", VA = "0x10EECC0", Slot = "56")]
		public RESULT set3DSpread(float angle)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000718")]
		[Address(RVA = "0x10EECC8", Offset = "0x10EECC8", VA = "0x10EECC8", Slot = "57")]
		public RESULT get3DSpread(out float angle)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000719")]
		[Address(RVA = "0x10EECD0", Offset = "0x10EECD0", VA = "0x10EECD0", Slot = "58")]
		public RESULT set3DLevel(float level)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600071A")]
		[Address(RVA = "0x10EECD8", Offset = "0x10EECD8", VA = "0x10EECD8", Slot = "59")]
		public RESULT get3DLevel(out float level)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600071B")]
		[Address(RVA = "0x10EECE0", Offset = "0x10EECE0", VA = "0x10EECE0", Slot = "60")]
		public RESULT set3DDopplerLevel(float level)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600071C")]
		[Address(RVA = "0x10EECE8", Offset = "0x10EECE8", VA = "0x10EECE8", Slot = "61")]
		public RESULT get3DDopplerLevel(out float level)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600071D")]
		[Address(RVA = "0x10EECF0", Offset = "0x10EECF0", VA = "0x10EECF0", Slot = "62")]
		public RESULT set3DDistanceFilter(bool custom, float customLevel, float centerFreq)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600071E")]
		[Address(RVA = "0x10EECFC", Offset = "0x10EECFC", VA = "0x10EECFC", Slot = "63")]
		public RESULT get3DDistanceFilter(out bool custom, out float customLevel, out float centerFreq)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600071F")]
		[Address(RVA = "0x10EED04", Offset = "0x10EED04", VA = "0x10EED04", Slot = "64")]
		public RESULT setUserData(IntPtr userdata)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000720")]
		[Address(RVA = "0x10EED0C", Offset = "0x10EED0C", VA = "0x10EED0C", Slot = "65")]
		public RESULT getUserData(out IntPtr userdata)
		{
			return default(RESULT);
		}

		[PreserveSig]
		[Token(Token = "0x6000721")]
		[Address(RVA = "0x18036CC", Offset = "0x18036CC", VA = "0x18036CC")]
		private static extern RESULT FMOD5_Channel_SetFrequency(IntPtr channel, float frequency);

		[PreserveSig]
		[Token(Token = "0x6000722")]
		[Address(RVA = "0x1803764", Offset = "0x1803764", VA = "0x1803764")]
		private static extern RESULT FMOD5_Channel_GetFrequency(IntPtr channel, out float frequency);

		[PreserveSig]
		[Token(Token = "0x6000723")]
		[Address(RVA = "0x18037FC", Offset = "0x18037FC", VA = "0x18037FC")]
		private static extern RESULT FMOD5_Channel_SetPriority(IntPtr channel, int priority);

		[PreserveSig]
		[Token(Token = "0x6000724")]
		[Address(RVA = "0x1803894", Offset = "0x1803894", VA = "0x1803894")]
		private static extern RESULT FMOD5_Channel_GetPriority(IntPtr channel, out int priority);

		[PreserveSig]
		[Token(Token = "0x6000725")]
		[Address(RVA = "0x180392C", Offset = "0x180392C", VA = "0x180392C")]
		private static extern RESULT FMOD5_Channel_SetPosition(IntPtr channel, uint position, TIMEUNIT postype);

		[PreserveSig]
		[Token(Token = "0x6000726")]
		[Address(RVA = "0x18039CC", Offset = "0x18039CC", VA = "0x18039CC")]
		private static extern RESULT FMOD5_Channel_GetPosition(IntPtr channel, out uint position, TIMEUNIT postype);

		[PreserveSig]
		[Token(Token = "0x6000727")]
		[Address(RVA = "0x1803A6C", Offset = "0x1803A6C", VA = "0x1803A6C")]
		private static extern RESULT FMOD5_Channel_SetChannelGroup(IntPtr channel, IntPtr channelgroup);

		[PreserveSig]
		[Token(Token = "0x6000728")]
		[Address(RVA = "0x1803B04", Offset = "0x1803B04", VA = "0x1803B04")]
		private static extern RESULT FMOD5_Channel_GetChannelGroup(IntPtr channel, out IntPtr channelgroup);

		[PreserveSig]
		[Token(Token = "0x6000729")]
		[Address(RVA = "0x1803B9C", Offset = "0x1803B9C", VA = "0x1803B9C")]
		private static extern RESULT FMOD5_Channel_SetLoopCount(IntPtr channel, int loopcount);

		[PreserveSig]
		[Token(Token = "0x600072A")]
		[Address(RVA = "0x1803C34", Offset = "0x1803C34", VA = "0x1803C34")]
		private static extern RESULT FMOD5_Channel_GetLoopCount(IntPtr channel, out int loopcount);

		[PreserveSig]
		[Token(Token = "0x600072B")]
		[Address(RVA = "0x1803CCC", Offset = "0x1803CCC", VA = "0x1803CCC")]
		private static extern RESULT FMOD5_Channel_SetLoopPoints(IntPtr channel, uint loopstart, TIMEUNIT loopstarttype, uint loopend, TIMEUNIT loopendtype);

		[PreserveSig]
		[Token(Token = "0x600072C")]
		[Address(RVA = "0x1803D84", Offset = "0x1803D84", VA = "0x1803D84")]
		private static extern RESULT FMOD5_Channel_GetLoopPoints(IntPtr channel, out uint loopstart, TIMEUNIT loopstarttype, out uint loopend, TIMEUNIT loopendtype);

		[PreserveSig]
		[Token(Token = "0x600072D")]
		[Address(RVA = "0x1803E3C", Offset = "0x1803E3C", VA = "0x1803E3C")]
		private static extern RESULT FMOD5_Channel_IsVirtual(IntPtr channel, out bool isvirtual);

		[PreserveSig]
		[Token(Token = "0x600072E")]
		[Address(RVA = "0x1803EE8", Offset = "0x1803EE8", VA = "0x1803EE8")]
		private static extern RESULT FMOD5_Channel_GetCurrentSound(IntPtr channel, out IntPtr sound);

		[PreserveSig]
		[Token(Token = "0x600072F")]
		[Address(RVA = "0x1803F80", Offset = "0x1803F80", VA = "0x1803F80")]
		private static extern RESULT FMOD5_Channel_GetIndex(IntPtr channel, out int index);

		[PreserveSig]
		[Token(Token = "0x6000730")]
		[Address(RVA = "0x1804018", Offset = "0x1804018", VA = "0x1804018")]
		private static extern RESULT FMOD5_Channel_GetSystemObject(IntPtr channel, out IntPtr system);

		[PreserveSig]
		[Token(Token = "0x6000731")]
		[Address(RVA = "0x18040B0", Offset = "0x18040B0", VA = "0x18040B0")]
		private static extern RESULT FMOD5_Channel_Stop(IntPtr channel);

		[PreserveSig]
		[Token(Token = "0x6000732")]
		[Address(RVA = "0x180413C", Offset = "0x180413C", VA = "0x180413C")]
		private static extern RESULT FMOD5_Channel_SetPaused(IntPtr channel, bool paused);

		[PreserveSig]
		[Token(Token = "0x6000733")]
		[Address(RVA = "0x18041D4", Offset = "0x18041D4", VA = "0x18041D4")]
		private static extern RESULT FMOD5_Channel_GetPaused(IntPtr channel, out bool paused);

		[PreserveSig]
		[Token(Token = "0x6000734")]
		[Address(RVA = "0x1804280", Offset = "0x1804280", VA = "0x1804280")]
		private static extern RESULT FMOD5_Channel_SetVolume(IntPtr channel, float volume);

		[PreserveSig]
		[Token(Token = "0x6000735")]
		[Address(RVA = "0x1804318", Offset = "0x1804318", VA = "0x1804318")]
		private static extern RESULT FMOD5_Channel_GetVolume(IntPtr channel, out float volume);

		[PreserveSig]
		[Token(Token = "0x6000736")]
		[Address(RVA = "0x18043B4", Offset = "0x18043B4", VA = "0x18043B4")]
		private static extern RESULT FMOD5_Channel_SetVolumeRamp(IntPtr channel, bool ramp);

		[PreserveSig]
		[Token(Token = "0x6000737")]
		[Address(RVA = "0x180444C", Offset = "0x180444C", VA = "0x180444C")]
		private static extern RESULT FMOD5_Channel_GetVolumeRamp(IntPtr channel, out bool ramp);

		[PreserveSig]
		[Token(Token = "0x6000738")]
		[Address(RVA = "0x18044F8", Offset = "0x18044F8", VA = "0x18044F8")]
		private static extern RESULT FMOD5_Channel_GetAudibility(IntPtr channel, out float audibility);

		[PreserveSig]
		[Token(Token = "0x6000739")]
		[Address(RVA = "0x1804590", Offset = "0x1804590", VA = "0x1804590")]
		private static extern RESULT FMOD5_Channel_SetPitch(IntPtr channel, float pitch);

		[PreserveSig]
		[Token(Token = "0x600073A")]
		[Address(RVA = "0x1804628", Offset = "0x1804628", VA = "0x1804628")]
		private static extern RESULT FMOD5_Channel_GetPitch(IntPtr channel, out float pitch);

		[PreserveSig]
		[Token(Token = "0x600073B")]
		[Address(RVA = "0x18046C4", Offset = "0x18046C4", VA = "0x18046C4")]
		private static extern RESULT FMOD5_Channel_SetMute(IntPtr channel, bool mute);

		[PreserveSig]
		[Token(Token = "0x600073C")]
		[Address(RVA = "0x180475C", Offset = "0x180475C", VA = "0x180475C")]
		private static extern RESULT FMOD5_Channel_GetMute(IntPtr channel, out bool mute);

		[PreserveSig]
		[Token(Token = "0x600073D")]
		[Address(RVA = "0x1804808", Offset = "0x1804808", VA = "0x1804808")]
		private static extern RESULT FMOD5_Channel_SetReverbProperties(IntPtr channel, int instance, float wet);

		[PreserveSig]
		[Token(Token = "0x600073E")]
		[Address(RVA = "0x18048B0", Offset = "0x18048B0", VA = "0x18048B0")]
		private static extern RESULT FMOD5_Channel_GetReverbProperties(IntPtr channel, int instance, out float wet);

		[PreserveSig]
		[Token(Token = "0x600073F")]
		[Address(RVA = "0x1804950", Offset = "0x1804950", VA = "0x1804950")]
		private static extern RESULT FMOD5_Channel_SetLowPassGain(IntPtr channel, float gain);

		[PreserveSig]
		[Token(Token = "0x6000740")]
		[Address(RVA = "0x18049E8", Offset = "0x18049E8", VA = "0x18049E8")]
		private static extern RESULT FMOD5_Channel_GetLowPassGain(IntPtr channel, out float gain);

		[PreserveSig]
		[Token(Token = "0x6000741")]
		[Address(RVA = "0x1804A80", Offset = "0x1804A80", VA = "0x1804A80")]
		private static extern RESULT FMOD5_Channel_SetMode(IntPtr channel, MODE mode);

		[PreserveSig]
		[Token(Token = "0x6000742")]
		[Address(RVA = "0x1804B18", Offset = "0x1804B18", VA = "0x1804B18")]
		private static extern RESULT FMOD5_Channel_GetMode(IntPtr channel, out MODE mode);

		[PreserveSig]
		[Token(Token = "0x6000743")]
		[Address(RVA = "0x1804BB0", Offset = "0x1804BB0", VA = "0x1804BB0")]
		private static extern RESULT FMOD5_Channel_SetCallback(IntPtr channel, CHANNELCONTROL_CALLBACK callback);

		[PreserveSig]
		[Token(Token = "0x6000744")]
		[Address(RVA = "0x1804C50", Offset = "0x1804C50", VA = "0x1804C50")]
		private static extern RESULT FMOD5_Channel_IsPlaying(IntPtr channel, out bool isplaying);

		[PreserveSig]
		[Token(Token = "0x6000745")]
		[Address(RVA = "0x1804CFC", Offset = "0x1804CFC", VA = "0x1804CFC")]
		private static extern RESULT FMOD5_Channel_SetPan(IntPtr channel, float pan);

		[PreserveSig]
		[Token(Token = "0x6000746")]
		[Address(RVA = "0x1804D94", Offset = "0x1804D94", VA = "0x1804D94")]
		private static extern RESULT FMOD5_Channel_SetMixLevelsOutput(IntPtr channel, float frontleft, float frontright, float center, float lfe, float surroundleft, float surroundright, float backleft, float backright);

		[PreserveSig]
		[Token(Token = "0x6000747")]
		[Address(RVA = "0x1804E7C", Offset = "0x1804E7C", VA = "0x1804E7C")]
		private static extern RESULT FMOD5_Channel_SetMixLevelsInput(IntPtr channel, float[] levels, int numlevels);

		[PreserveSig]
		[Token(Token = "0x6000748")]
		[Address(RVA = "0x1804F24", Offset = "0x1804F24", VA = "0x1804F24")]
		private static extern RESULT FMOD5_Channel_SetMixMatrix(IntPtr channel, float[] matrix, int outchannels, int inchannels, int inchannel_hop);

		[PreserveSig]
		[Token(Token = "0x6000749")]
		[Address(RVA = "0x1804FE4", Offset = "0x1804FE4", VA = "0x1804FE4")]
		private static extern RESULT FMOD5_Channel_GetMixMatrix(IntPtr channel, float[] matrix, out int outchannels, out int inchannels, int inchannel_hop);

		[PreserveSig]
		[Token(Token = "0x600074A")]
		[Address(RVA = "0x18050A4", Offset = "0x18050A4", VA = "0x18050A4")]
		private static extern RESULT FMOD5_Channel_GetDSPClock(IntPtr channel, out ulong dspclock, out ulong parentclock);

		[PreserveSig]
		[Token(Token = "0x600074B")]
		[Address(RVA = "0x1805148", Offset = "0x1805148", VA = "0x1805148")]
		private static extern RESULT FMOD5_Channel_SetDelay(IntPtr channel, ulong dspclock_start, ulong dspclock_end, bool stopchannels);

		[PreserveSig]
		[Token(Token = "0x600074C")]
		[Address(RVA = "0x1805250", Offset = "0x1805250", VA = "0x1805250")]
		private static extern RESULT FMOD5_Channel_GetDelay(IntPtr channel, out ulong dspclock_start, out ulong dspclock_end, IntPtr zero);

		[PreserveSig]
		[Token(Token = "0x600074D")]
		[Address(RVA = "0x1805300", Offset = "0x1805300", VA = "0x1805300")]
		private static extern RESULT FMOD5_Channel_GetDelay(IntPtr channel, out ulong dspclock_start, out ulong dspclock_end, out bool stopchannels);

		[PreserveSig]
		[Token(Token = "0x600074E")]
		[Address(RVA = "0x18053C4", Offset = "0x18053C4", VA = "0x18053C4")]
		private static extern RESULT FMOD5_Channel_AddFadePoint(IntPtr channel, ulong dspclock, float volume);

		[PreserveSig]
		[Token(Token = "0x600074F")]
		[Address(RVA = "0x180546C", Offset = "0x180546C", VA = "0x180546C")]
		private static extern RESULT FMOD5_Channel_SetFadePointRamp(IntPtr channel, ulong dspclock, float volume);

		[PreserveSig]
		[Token(Token = "0x6000750")]
		[Address(RVA = "0x1805514", Offset = "0x1805514", VA = "0x1805514")]
		private static extern RESULT FMOD5_Channel_RemoveFadePoints(IntPtr channel, ulong dspclock_start, ulong dspclock_end);

		[PreserveSig]
		[Token(Token = "0x6000751")]
		[Address(RVA = "0x18055B4", Offset = "0x18055B4", VA = "0x18055B4")]
		private static extern RESULT FMOD5_Channel_GetFadePoints(IntPtr channel, ref uint numpoints, ulong[] point_dspclock, float[] point_volume);

		[PreserveSig]
		[Token(Token = "0x6000752")]
		[Address(RVA = "0x1805674", Offset = "0x1805674", VA = "0x1805674")]
		private static extern RESULT FMOD5_Channel_GetDSP(IntPtr channel, int index, out IntPtr dsp);

		[PreserveSig]
		[Token(Token = "0x6000753")]
		[Address(RVA = "0x1805710", Offset = "0x1805710", VA = "0x1805710")]
		private static extern RESULT FMOD5_Channel_AddDSP(IntPtr channel, int index, IntPtr dsp);

		[PreserveSig]
		[Token(Token = "0x6000754")]
		[Address(RVA = "0x18057AC", Offset = "0x18057AC", VA = "0x18057AC")]
		private static extern RESULT FMOD5_Channel_RemoveDSP(IntPtr channel, IntPtr dsp);

		[PreserveSig]
		[Token(Token = "0x6000755")]
		[Address(RVA = "0x1805844", Offset = "0x1805844", VA = "0x1805844")]
		private static extern RESULT FMOD5_Channel_GetNumDSPs(IntPtr channel, out int numdsps);

		[PreserveSig]
		[Token(Token = "0x6000756")]
		[Address(RVA = "0x18058DC", Offset = "0x18058DC", VA = "0x18058DC")]
		private static extern RESULT FMOD5_Channel_SetDSPIndex(IntPtr channel, IntPtr dsp, int index);

		[PreserveSig]
		[Token(Token = "0x6000757")]
		[Address(RVA = "0x180597C", Offset = "0x180597C", VA = "0x180597C")]
		private static extern RESULT FMOD5_Channel_GetDSPIndex(IntPtr channel, IntPtr dsp, out int index);

		[PreserveSig]
		[Token(Token = "0x6000758")]
		[Address(RVA = "0x1805A1C", Offset = "0x1805A1C", VA = "0x1805A1C")]
		private static extern RESULT FMOD5_Channel_Set3DAttributes(IntPtr channel, ref VECTOR pos, ref VECTOR vel);

		[PreserveSig]
		[Token(Token = "0x6000759")]
		[Address(RVA = "0x1805ABC", Offset = "0x1805ABC", VA = "0x1805ABC")]
		private static extern RESULT FMOD5_Channel_Get3DAttributes(IntPtr channel, out VECTOR pos, out VECTOR vel);

		[PreserveSig]
		[Token(Token = "0x600075A")]
		[Address(RVA = "0x1805B5C", Offset = "0x1805B5C", VA = "0x1805B5C")]
		private static extern RESULT FMOD5_Channel_Set3DMinMaxDistance(IntPtr channel, float mindistance, float maxdistance);

		[PreserveSig]
		[Token(Token = "0x600075B")]
		[Address(RVA = "0x1805BFC", Offset = "0x1805BFC", VA = "0x1805BFC")]
		private static extern RESULT FMOD5_Channel_Get3DMinMaxDistance(IntPtr channel, out float mindistance, out float maxdistance);

		[PreserveSig]
		[Token(Token = "0x600075C")]
		[Address(RVA = "0x1805C9C", Offset = "0x1805C9C", VA = "0x1805C9C")]
		private static extern RESULT FMOD5_Channel_Set3DConeSettings(IntPtr channel, float insideconeangle, float outsideconeangle, float outsidevolume);

		[PreserveSig]
		[Token(Token = "0x600075D")]
		[Address(RVA = "0x1805D4C", Offset = "0x1805D4C", VA = "0x1805D4C")]
		private static extern RESULT FMOD5_Channel_Get3DConeSettings(IntPtr channel, out float insideconeangle, out float outsideconeangle, out float outsidevolume);

		[PreserveSig]
		[Token(Token = "0x600075E")]
		[Address(RVA = "0x1805DFC", Offset = "0x1805DFC", VA = "0x1805DFC")]
		private static extern RESULT FMOD5_Channel_Set3DConeOrientation(IntPtr channel, ref VECTOR orientation);

		[PreserveSig]
		[Token(Token = "0x600075F")]
		[Address(RVA = "0x1805E94", Offset = "0x1805E94", VA = "0x1805E94")]
		private static extern RESULT FMOD5_Channel_Get3DConeOrientation(IntPtr channel, out VECTOR orientation);

		[PreserveSig]
		[Token(Token = "0x6000760")]
		[Address(RVA = "0x1805F2C", Offset = "0x1805F2C", VA = "0x1805F2C")]
		private static extern RESULT FMOD5_Channel_Set3DCustomRolloff(IntPtr channel, ref VECTOR points, int numpoints);

		[PreserveSig]
		[Token(Token = "0x6000761")]
		[Address(RVA = "0x1805FCC", Offset = "0x1805FCC", VA = "0x1805FCC")]
		private static extern RESULT FMOD5_Channel_Get3DCustomRolloff(IntPtr channel, out IntPtr points, out int numpoints);

		[PreserveSig]
		[Token(Token = "0x6000762")]
		[Address(RVA = "0x180606C", Offset = "0x180606C", VA = "0x180606C")]
		private static extern RESULT FMOD5_Channel_Set3DOcclusion(IntPtr channel, float directocclusion, float reverbocclusion);

		[PreserveSig]
		[Token(Token = "0x6000763")]
		[Address(RVA = "0x180610C", Offset = "0x180610C", VA = "0x180610C")]
		private static extern RESULT FMOD5_Channel_Get3DOcclusion(IntPtr channel, out float directocclusion, out float reverbocclusion);

		[PreserveSig]
		[Token(Token = "0x6000764")]
		[Address(RVA = "0x18061AC", Offset = "0x18061AC", VA = "0x18061AC")]
		private static extern RESULT FMOD5_Channel_Set3DSpread(IntPtr channel, float angle);

		[PreserveSig]
		[Token(Token = "0x6000765")]
		[Address(RVA = "0x1806244", Offset = "0x1806244", VA = "0x1806244")]
		private static extern RESULT FMOD5_Channel_Get3DSpread(IntPtr channel, out float angle);

		[PreserveSig]
		[Token(Token = "0x6000766")]
		[Address(RVA = "0x18062DC", Offset = "0x18062DC", VA = "0x18062DC")]
		private static extern RESULT FMOD5_Channel_Set3DLevel(IntPtr channel, float level);

		[PreserveSig]
		[Token(Token = "0x6000767")]
		[Address(RVA = "0x1806374", Offset = "0x1806374", VA = "0x1806374")]
		private static extern RESULT FMOD5_Channel_Get3DLevel(IntPtr channel, out float level);

		[PreserveSig]
		[Token(Token = "0x6000768")]
		[Address(RVA = "0x180640C", Offset = "0x180640C", VA = "0x180640C")]
		private static extern RESULT FMOD5_Channel_Set3DDopplerLevel(IntPtr channel, float level);

		[PreserveSig]
		[Token(Token = "0x6000769")]
		[Address(RVA = "0x18064A4", Offset = "0x18064A4", VA = "0x18064A4")]
		private static extern RESULT FMOD5_Channel_Get3DDopplerLevel(IntPtr channel, out float level);

		[PreserveSig]
		[Token(Token = "0x600076A")]
		[Address(RVA = "0x1806540", Offset = "0x1806540", VA = "0x1806540")]
		private static extern RESULT FMOD5_Channel_Set3DDistanceFilter(IntPtr channel, bool custom, float customLevel, float centerFreq);

		[PreserveSig]
		[Token(Token = "0x600076B")]
		[Address(RVA = "0x18065F0", Offset = "0x18065F0", VA = "0x18065F0")]
		private static extern RESULT FMOD5_Channel_Get3DDistanceFilter(IntPtr channel, out bool custom, out float customLevel, out float centerFreq);

		[PreserveSig]
		[Token(Token = "0x600076C")]
		[Address(RVA = "0x18066B4", Offset = "0x18066B4", VA = "0x18066B4")]
		private static extern RESULT FMOD5_Channel_SetUserData(IntPtr channel, IntPtr userdata);

		[PreserveSig]
		[Token(Token = "0x600076D")]
		[Address(RVA = "0x180674C", Offset = "0x180674C", VA = "0x180674C")]
		private static extern RESULT FMOD5_Channel_GetUserData(IntPtr channel, out IntPtr userdata);

		[Token(Token = "0x600076E")]
		[Address(RVA = "0x10EED14", Offset = "0x10EED14", VA = "0x10EED14")]
		public bool hasHandle()
		{
			return default(bool);
		}

		[Token(Token = "0x600076F")]
		[Address(RVA = "0x10EED1C", Offset = "0x10EED1C", VA = "0x10EED1C")]
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
		[Address(RVA = "0x10EED60", Offset = "0x10EED60", VA = "0x10EED60")]
		public RESULT release()
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000771")]
		[Address(RVA = "0x10EED68", Offset = "0x10EED68", VA = "0x10EED68")]
		public RESULT addGroup(ChannelGroup group, bool propagatedspclock = true)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000772")]
		[Address(RVA = "0x10EED74", Offset = "0x10EED74", VA = "0x10EED74")]
		public RESULT addGroup(ChannelGroup group, bool propagatedspclock, out DSPConnection connection)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000773")]
		[Address(RVA = "0x10EED80", Offset = "0x10EED80", VA = "0x10EED80")]
		public RESULT getNumGroups(out int numgroups)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000774")]
		[Address(RVA = "0x10EED88", Offset = "0x10EED88", VA = "0x10EED88")]
		public RESULT getGroup(int index, out ChannelGroup group)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000775")]
		[Address(RVA = "0x10EED90", Offset = "0x10EED90", VA = "0x10EED90")]
		public RESULT getParentGroup(out ChannelGroup group)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000776")]
		[Address(RVA = "0x10EED98", Offset = "0x10EED98", VA = "0x10EED98")]
		public RESULT getName(out string name, int namelen)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000777")]
		[Address(RVA = "0x10EEDA0", Offset = "0x10EEDA0", VA = "0x10EEDA0")]
		public RESULT getNumChannels(out int numchannels)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000778")]
		[Address(RVA = "0x10EEDA8", Offset = "0x10EEDA8", VA = "0x10EEDA8")]
		public RESULT getChannel(int index, out Channel channel)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000779")]
		[Address(RVA = "0x10EEDB0", Offset = "0x10EEDB0", VA = "0x10EEDB0", Slot = "4")]
		public RESULT getSystemObject(out System system)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600077A")]
		[Address(RVA = "0x10EEDB8", Offset = "0x10EEDB8", VA = "0x10EEDB8", Slot = "5")]
		public RESULT stop()
		{
			return default(RESULT);
		}

		[Token(Token = "0x600077B")]
		[Address(RVA = "0x10EEDC0", Offset = "0x10EEDC0", VA = "0x10EEDC0", Slot = "6")]
		public RESULT setPaused(bool paused)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600077C")]
		[Address(RVA = "0x10EEDCC", Offset = "0x10EEDCC", VA = "0x10EEDCC", Slot = "7")]
		public RESULT getPaused(out bool paused)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600077D")]
		[Address(RVA = "0x10EEDD4", Offset = "0x10EEDD4", VA = "0x10EEDD4", Slot = "8")]
		public RESULT setVolume(float volume)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600077E")]
		[Address(RVA = "0x10EEDDC", Offset = "0x10EEDDC", VA = "0x10EEDDC", Slot = "9")]
		public RESULT getVolume(out float volume)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600077F")]
		[Address(RVA = "0x10EEDE4", Offset = "0x10EEDE4", VA = "0x10EEDE4", Slot = "10")]
		public RESULT setVolumeRamp(bool ramp)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000780")]
		[Address(RVA = "0x10EEDF0", Offset = "0x10EEDF0", VA = "0x10EEDF0", Slot = "11")]
		public RESULT getVolumeRamp(out bool ramp)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000781")]
		[Address(RVA = "0x10EEDF8", Offset = "0x10EEDF8", VA = "0x10EEDF8", Slot = "12")]
		public RESULT getAudibility(out float audibility)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000782")]
		[Address(RVA = "0x10EEE00", Offset = "0x10EEE00", VA = "0x10EEE00", Slot = "13")]
		public RESULT setPitch(float pitch)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000783")]
		[Address(RVA = "0x10EEE08", Offset = "0x10EEE08", VA = "0x10EEE08", Slot = "14")]
		public RESULT getPitch(out float pitch)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000784")]
		[Address(RVA = "0x10EEE10", Offset = "0x10EEE10", VA = "0x10EEE10", Slot = "15")]
		public RESULT setMute(bool mute)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000785")]
		[Address(RVA = "0x10EEE1C", Offset = "0x10EEE1C", VA = "0x10EEE1C", Slot = "16")]
		public RESULT getMute(out bool mute)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000786")]
		[Address(RVA = "0x10EEE24", Offset = "0x10EEE24", VA = "0x10EEE24", Slot = "17")]
		public RESULT setReverbProperties(int instance, float wet)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000787")]
		[Address(RVA = "0x10EEE2C", Offset = "0x10EEE2C", VA = "0x10EEE2C", Slot = "18")]
		public RESULT getReverbProperties(int instance, out float wet)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000788")]
		[Address(RVA = "0x10EEE34", Offset = "0x10EEE34", VA = "0x10EEE34", Slot = "19")]
		public RESULT setLowPassGain(float gain)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000789")]
		[Address(RVA = "0x10EEE3C", Offset = "0x10EEE3C", VA = "0x10EEE3C", Slot = "20")]
		public RESULT getLowPassGain(out float gain)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600078A")]
		[Address(RVA = "0x10EEE44", Offset = "0x10EEE44", VA = "0x10EEE44", Slot = "21")]
		public RESULT setMode(MODE mode)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600078B")]
		[Address(RVA = "0x10EEE4C", Offset = "0x10EEE4C", VA = "0x10EEE4C", Slot = "22")]
		public RESULT getMode(out MODE mode)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600078C")]
		[Address(RVA = "0x10EEE54", Offset = "0x10EEE54", VA = "0x10EEE54", Slot = "23")]
		public RESULT setCallback(CHANNELCONTROL_CALLBACK callback)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600078D")]
		[Address(RVA = "0x10EEE5C", Offset = "0x10EEE5C", VA = "0x10EEE5C", Slot = "24")]
		public RESULT isPlaying(out bool isplaying)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600078E")]
		[Address(RVA = "0x10EEE64", Offset = "0x10EEE64", VA = "0x10EEE64", Slot = "25")]
		public RESULT setPan(float pan)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600078F")]
		[Address(RVA = "0x10EEE6C", Offset = "0x10EEE6C", VA = "0x10EEE6C", Slot = "26")]
		public RESULT setMixLevelsOutput(float frontleft, float frontright, float center, float lfe, float surroundleft, float surroundright, float backleft, float backright)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000790")]
		[Address(RVA = "0x10EEE74", Offset = "0x10EEE74", VA = "0x10EEE74", Slot = "27")]
		public RESULT setMixLevelsInput(float[] levels, int numlevels)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000791")]
		[Address(RVA = "0x10EEE7C", Offset = "0x10EEE7C", VA = "0x10EEE7C", Slot = "28")]
		public RESULT setMixMatrix(float[] matrix, int outchannels, int inchannels, int inchannel_hop)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000792")]
		[Address(RVA = "0x10EEE84", Offset = "0x10EEE84", VA = "0x10EEE84", Slot = "29")]
		public RESULT getMixMatrix(float[] matrix, out int outchannels, out int inchannels, int inchannel_hop)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000793")]
		[Address(RVA = "0x10EEE8C", Offset = "0x10EEE8C", VA = "0x10EEE8C", Slot = "30")]
		public RESULT getDSPClock(out ulong dspclock, out ulong parentclock)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000794")]
		[Address(RVA = "0x10EEE94", Offset = "0x10EEE94", VA = "0x10EEE94", Slot = "31")]
		public RESULT setDelay(ulong dspclock_start, ulong dspclock_end, bool stopchannels)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000795")]
		[Address(RVA = "0x10EEEA0", Offset = "0x10EEEA0", VA = "0x10EEEA0", Slot = "32")]
		public RESULT getDelay(out ulong dspclock_start, out ulong dspclock_end)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000796")]
		[Address(RVA = "0x10EEEA8", Offset = "0x10EEEA8", VA = "0x10EEEA8", Slot = "33")]
		public RESULT getDelay(out ulong dspclock_start, out ulong dspclock_end, out bool stopchannels)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000797")]
		[Address(RVA = "0x10EEEB0", Offset = "0x10EEEB0", VA = "0x10EEEB0", Slot = "34")]
		public RESULT addFadePoint(ulong dspclock, float volume)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000798")]
		[Address(RVA = "0x10EEEB8", Offset = "0x10EEEB8", VA = "0x10EEEB8", Slot = "35")]
		public RESULT setFadePointRamp(ulong dspclock, float volume)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000799")]
		[Address(RVA = "0x10EEEC0", Offset = "0x10EEEC0", VA = "0x10EEEC0", Slot = "36")]
		public RESULT removeFadePoints(ulong dspclock_start, ulong dspclock_end)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600079A")]
		[Address(RVA = "0x10EEEC8", Offset = "0x10EEEC8", VA = "0x10EEEC8", Slot = "37")]
		public RESULT getFadePoints(ref uint numpoints, ulong[] point_dspclock, float[] point_volume)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600079B")]
		[Address(RVA = "0x10EEED0", Offset = "0x10EEED0", VA = "0x10EEED0", Slot = "38")]
		public RESULT getDSP(int index, out DSP dsp)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600079C")]
		[Address(RVA = "0x10EEED8", Offset = "0x10EEED8", VA = "0x10EEED8", Slot = "39")]
		public RESULT addDSP(int index, DSP dsp)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600079D")]
		[Address(RVA = "0x10EEEE0", Offset = "0x10EEEE0", VA = "0x10EEEE0", Slot = "40")]
		public RESULT removeDSP(DSP dsp)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600079E")]
		[Address(RVA = "0x10EEEE8", Offset = "0x10EEEE8", VA = "0x10EEEE8", Slot = "41")]
		public RESULT getNumDSPs(out int numdsps)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600079F")]
		[Address(RVA = "0x10EEEF0", Offset = "0x10EEEF0", VA = "0x10EEEF0", Slot = "42")]
		public RESULT setDSPIndex(DSP dsp, int index)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60007A0")]
		[Address(RVA = "0x10EEEF8", Offset = "0x10EEEF8", VA = "0x10EEEF8", Slot = "43")]
		public RESULT getDSPIndex(DSP dsp, out int index)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60007A1")]
		[Address(RVA = "0x10EEF00", Offset = "0x10EEF00", VA = "0x10EEF00", Slot = "44")]
		public RESULT set3DAttributes(ref VECTOR pos, ref VECTOR vel)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60007A2")]
		[Address(RVA = "0x10EEF08", Offset = "0x10EEF08", VA = "0x10EEF08", Slot = "45")]
		public RESULT get3DAttributes(out VECTOR pos, out VECTOR vel)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60007A3")]
		[Address(RVA = "0x10EEF10", Offset = "0x10EEF10", VA = "0x10EEF10", Slot = "46")]
		public RESULT set3DMinMaxDistance(float mindistance, float maxdistance)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60007A4")]
		[Address(RVA = "0x10EEF18", Offset = "0x10EEF18", VA = "0x10EEF18", Slot = "47")]
		public RESULT get3DMinMaxDistance(out float mindistance, out float maxdistance)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60007A5")]
		[Address(RVA = "0x10EEF20", Offset = "0x10EEF20", VA = "0x10EEF20", Slot = "48")]
		public RESULT set3DConeSettings(float insideconeangle, float outsideconeangle, float outsidevolume)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60007A6")]
		[Address(RVA = "0x10EEF28", Offset = "0x10EEF28", VA = "0x10EEF28", Slot = "49")]
		public RESULT get3DConeSettings(out float insideconeangle, out float outsideconeangle, out float outsidevolume)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60007A7")]
		[Address(RVA = "0x10EEF30", Offset = "0x10EEF30", VA = "0x10EEF30", Slot = "50")]
		public RESULT set3DConeOrientation(ref VECTOR orientation)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60007A8")]
		[Address(RVA = "0x10EEF38", Offset = "0x10EEF38", VA = "0x10EEF38", Slot = "51")]
		public RESULT get3DConeOrientation(out VECTOR orientation)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60007A9")]
		[Address(RVA = "0x10EEF40", Offset = "0x10EEF40", VA = "0x10EEF40", Slot = "52")]
		public RESULT set3DCustomRolloff(ref VECTOR points, int numpoints)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60007AA")]
		[Address(RVA = "0x10EEF48", Offset = "0x10EEF48", VA = "0x10EEF48", Slot = "53")]
		public RESULT get3DCustomRolloff(out IntPtr points, out int numpoints)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60007AB")]
		[Address(RVA = "0x10EEF50", Offset = "0x10EEF50", VA = "0x10EEF50", Slot = "54")]
		public RESULT set3DOcclusion(float directocclusion, float reverbocclusion)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60007AC")]
		[Address(RVA = "0x10EEF58", Offset = "0x10EEF58", VA = "0x10EEF58", Slot = "55")]
		public RESULT get3DOcclusion(out float directocclusion, out float reverbocclusion)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60007AD")]
		[Address(RVA = "0x10EEF60", Offset = "0x10EEF60", VA = "0x10EEF60", Slot = "56")]
		public RESULT set3DSpread(float angle)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60007AE")]
		[Address(RVA = "0x10EEF68", Offset = "0x10EEF68", VA = "0x10EEF68", Slot = "57")]
		public RESULT get3DSpread(out float angle)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60007AF")]
		[Address(RVA = "0x10EEF70", Offset = "0x10EEF70", VA = "0x10EEF70", Slot = "58")]
		public RESULT set3DLevel(float level)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60007B0")]
		[Address(RVA = "0x10EEF78", Offset = "0x10EEF78", VA = "0x10EEF78", Slot = "59")]
		public RESULT get3DLevel(out float level)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60007B1")]
		[Address(RVA = "0x10EEF80", Offset = "0x10EEF80", VA = "0x10EEF80", Slot = "60")]
		public RESULT set3DDopplerLevel(float level)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60007B2")]
		[Address(RVA = "0x10EEF88", Offset = "0x10EEF88", VA = "0x10EEF88", Slot = "61")]
		public RESULT get3DDopplerLevel(out float level)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60007B3")]
		[Address(RVA = "0x10EEF90", Offset = "0x10EEF90", VA = "0x10EEF90", Slot = "62")]
		public RESULT set3DDistanceFilter(bool custom, float customLevel, float centerFreq)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60007B4")]
		[Address(RVA = "0x10EEF9C", Offset = "0x10EEF9C", VA = "0x10EEF9C", Slot = "63")]
		public RESULT get3DDistanceFilter(out bool custom, out float customLevel, out float centerFreq)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60007B5")]
		[Address(RVA = "0x10EEFA4", Offset = "0x10EEFA4", VA = "0x10EEFA4", Slot = "64")]
		public RESULT setUserData(IntPtr userdata)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60007B6")]
		[Address(RVA = "0x10EEFAC", Offset = "0x10EEFAC", VA = "0x10EEFAC", Slot = "65")]
		public RESULT getUserData(out IntPtr userdata)
		{
			return default(RESULT);
		}

		[PreserveSig]
		[Token(Token = "0x60007B7")]
		[Address(RVA = "0x1806874", Offset = "0x1806874", VA = "0x1806874")]
		private static extern RESULT FMOD5_ChannelGroup_Release(IntPtr channelgroup);

		[PreserveSig]
		[Token(Token = "0x60007B8")]
		[Address(RVA = "0x1806954", Offset = "0x1806954", VA = "0x1806954")]
		private static extern RESULT FMOD5_ChannelGroup_AddGroup(IntPtr channelgroup, IntPtr group, bool propagatedspclock, IntPtr zero);

		[PreserveSig]
		[Token(Token = "0x60007B9")]
		[Address(RVA = "0x1806A08", Offset = "0x1806A08", VA = "0x1806A08")]
		private static extern RESULT FMOD5_ChannelGroup_AddGroup(IntPtr channelgroup, IntPtr group, bool propagatedspclock, out IntPtr connection);

		[PreserveSig]
		[Token(Token = "0x60007BA")]
		[Address(RVA = "0x1806AB8", Offset = "0x1806AB8", VA = "0x1806AB8")]
		private static extern RESULT FMOD5_ChannelGroup_GetNumGroups(IntPtr channelgroup, out int numgroups);

		[PreserveSig]
		[Token(Token = "0x60007BB")]
		[Address(RVA = "0x1806B50", Offset = "0x1806B50", VA = "0x1806B50")]
		private static extern RESULT FMOD5_ChannelGroup_GetGroup(IntPtr channelgroup, int index, out IntPtr group);

		[PreserveSig]
		[Token(Token = "0x60007BC")]
		[Address(RVA = "0x1806BF0", Offset = "0x1806BF0", VA = "0x1806BF0")]
		private static extern RESULT FMOD5_ChannelGroup_GetParentGroup(IntPtr channelgroup, out IntPtr group);

		[PreserveSig]
		[Token(Token = "0x60007BD")]
		[Address(RVA = "0x1806E34", Offset = "0x1806E34", VA = "0x1806E34")]
		private static extern RESULT FMOD5_ChannelGroup_GetName(IntPtr channelgroup, IntPtr name, int namelen);

		[PreserveSig]
		[Token(Token = "0x60007BE")]
		[Address(RVA = "0x1806ED4", Offset = "0x1806ED4", VA = "0x1806ED4")]
		private static extern RESULT FMOD5_ChannelGroup_GetNumChannels(IntPtr channelgroup, out int numchannels);

		[PreserveSig]
		[Token(Token = "0x60007BF")]
		[Address(RVA = "0x1806F6C", Offset = "0x1806F6C", VA = "0x1806F6C")]
		private static extern RESULT FMOD5_ChannelGroup_GetChannel(IntPtr channelgroup, int index, out IntPtr channel);

		[PreserveSig]
		[Token(Token = "0x60007C0")]
		[Address(RVA = "0x180700C", Offset = "0x180700C", VA = "0x180700C")]
		private static extern RESULT FMOD5_ChannelGroup_GetSystemObject(IntPtr channelgroup, out IntPtr system);

		[PreserveSig]
		[Token(Token = "0x60007C1")]
		[Address(RVA = "0x18070A4", Offset = "0x18070A4", VA = "0x18070A4")]
		private static extern RESULT FMOD5_ChannelGroup_Stop(IntPtr channelgroup);

		[PreserveSig]
		[Token(Token = "0x60007C2")]
		[Address(RVA = "0x1807130", Offset = "0x1807130", VA = "0x1807130")]
		private static extern RESULT FMOD5_ChannelGroup_SetPaused(IntPtr channelgroup, bool paused);

		[PreserveSig]
		[Token(Token = "0x60007C3")]
		[Address(RVA = "0x18071C8", Offset = "0x18071C8", VA = "0x18071C8")]
		private static extern RESULT FMOD5_ChannelGroup_GetPaused(IntPtr channelgroup, out bool paused);

		[PreserveSig]
		[Token(Token = "0x60007C4")]
		[Address(RVA = "0x1807274", Offset = "0x1807274", VA = "0x1807274")]
		private static extern RESULT FMOD5_ChannelGroup_SetVolume(IntPtr channelgroup, float volume);

		[PreserveSig]
		[Token(Token = "0x60007C5")]
		[Address(RVA = "0x180730C", Offset = "0x180730C", VA = "0x180730C")]
		private static extern RESULT FMOD5_ChannelGroup_GetVolume(IntPtr channelgroup, out float volume);

		[PreserveSig]
		[Token(Token = "0x60007C6")]
		[Address(RVA = "0x18073A8", Offset = "0x18073A8", VA = "0x18073A8")]
		private static extern RESULT FMOD5_ChannelGroup_SetVolumeRamp(IntPtr channelgroup, bool ramp);

		[PreserveSig]
		[Token(Token = "0x60007C7")]
		[Address(RVA = "0x1807440", Offset = "0x1807440", VA = "0x1807440")]
		private static extern RESULT FMOD5_ChannelGroup_GetVolumeRamp(IntPtr channelgroup, out bool ramp);

		[PreserveSig]
		[Token(Token = "0x60007C8")]
		[Address(RVA = "0x18074EC", Offset = "0x18074EC", VA = "0x18074EC")]
		private static extern RESULT FMOD5_ChannelGroup_GetAudibility(IntPtr channelgroup, out float audibility);

		[PreserveSig]
		[Token(Token = "0x60007C9")]
		[Address(RVA = "0x1807584", Offset = "0x1807584", VA = "0x1807584")]
		private static extern RESULT FMOD5_ChannelGroup_SetPitch(IntPtr channelgroup, float pitch);

		[PreserveSig]
		[Token(Token = "0x60007CA")]
		[Address(RVA = "0x180761C", Offset = "0x180761C", VA = "0x180761C")]
		private static extern RESULT FMOD5_ChannelGroup_GetPitch(IntPtr channelgroup, out float pitch);

		[PreserveSig]
		[Token(Token = "0x60007CB")]
		[Address(RVA = "0x18076B8", Offset = "0x18076B8", VA = "0x18076B8")]
		private static extern RESULT FMOD5_ChannelGroup_SetMute(IntPtr channelgroup, bool mute);

		[PreserveSig]
		[Token(Token = "0x60007CC")]
		[Address(RVA = "0x1807750", Offset = "0x1807750", VA = "0x1807750")]
		private static extern RESULT FMOD5_ChannelGroup_GetMute(IntPtr channelgroup, out bool mute);

		[PreserveSig]
		[Token(Token = "0x60007CD")]
		[Address(RVA = "0x18077FC", Offset = "0x18077FC", VA = "0x18077FC")]
		private static extern RESULT FMOD5_ChannelGroup_SetReverbProperties(IntPtr channelgroup, int instance, float wet);

		[PreserveSig]
		[Token(Token = "0x60007CE")]
		[Address(RVA = "0x18078A4", Offset = "0x18078A4", VA = "0x18078A4")]
		private static extern RESULT FMOD5_ChannelGroup_GetReverbProperties(IntPtr channelgroup, int instance, out float wet);

		[PreserveSig]
		[Token(Token = "0x60007CF")]
		[Address(RVA = "0x1807944", Offset = "0x1807944", VA = "0x1807944")]
		private static extern RESULT FMOD5_ChannelGroup_SetLowPassGain(IntPtr channelgroup, float gain);

		[PreserveSig]
		[Token(Token = "0x60007D0")]
		[Address(RVA = "0x18079DC", Offset = "0x18079DC", VA = "0x18079DC")]
		private static extern RESULT FMOD5_ChannelGroup_GetLowPassGain(IntPtr channelgroup, out float gain);

		[PreserveSig]
		[Token(Token = "0x60007D1")]
		[Address(RVA = "0x1807A74", Offset = "0x1807A74", VA = "0x1807A74")]
		private static extern RESULT FMOD5_ChannelGroup_SetMode(IntPtr channelgroup, MODE mode);

		[PreserveSig]
		[Token(Token = "0x60007D2")]
		[Address(RVA = "0x1807B0C", Offset = "0x1807B0C", VA = "0x1807B0C")]
		private static extern RESULT FMOD5_ChannelGroup_GetMode(IntPtr channelgroup, out MODE mode);

		[PreserveSig]
		[Token(Token = "0x60007D3")]
		[Address(RVA = "0x1807BA4", Offset = "0x1807BA4", VA = "0x1807BA4")]
		private static extern RESULT FMOD5_ChannelGroup_SetCallback(IntPtr channelgroup, CHANNELCONTROL_CALLBACK callback);

		[PreserveSig]
		[Token(Token = "0x60007D4")]
		[Address(RVA = "0x1807C44", Offset = "0x1807C44", VA = "0x1807C44")]
		private static extern RESULT FMOD5_ChannelGroup_IsPlaying(IntPtr channelgroup, out bool isplaying);

		[PreserveSig]
		[Token(Token = "0x60007D5")]
		[Address(RVA = "0x1807CF0", Offset = "0x1807CF0", VA = "0x1807CF0")]
		private static extern RESULT FMOD5_ChannelGroup_SetPan(IntPtr channelgroup, float pan);

		[PreserveSig]
		[Token(Token = "0x60007D6")]
		[Address(RVA = "0x1807D88", Offset = "0x1807D88", VA = "0x1807D88")]
		private static extern RESULT FMOD5_ChannelGroup_SetMixLevelsOutput(IntPtr channelgroup, float frontleft, float frontright, float center, float lfe, float surroundleft, float surroundright, float backleft, float backright);

		[PreserveSig]
		[Token(Token = "0x60007D7")]
		[Address(RVA = "0x1807E70", Offset = "0x1807E70", VA = "0x1807E70")]
		private static extern RESULT FMOD5_ChannelGroup_SetMixLevelsInput(IntPtr channelgroup, float[] levels, int numlevels);

		[PreserveSig]
		[Token(Token = "0x60007D8")]
		[Address(RVA = "0x1807F18", Offset = "0x1807F18", VA = "0x1807F18")]
		private static extern RESULT FMOD5_ChannelGroup_SetMixMatrix(IntPtr channelgroup, float[] matrix, int outchannels, int inchannels, int inchannel_hop);

		[PreserveSig]
		[Token(Token = "0x60007D9")]
		[Address(RVA = "0x1807FD8", Offset = "0x1807FD8", VA = "0x1807FD8")]
		private static extern RESULT FMOD5_ChannelGroup_GetMixMatrix(IntPtr channelgroup, float[] matrix, out int outchannels, out int inchannels, int inchannel_hop);

		[PreserveSig]
		[Token(Token = "0x60007DA")]
		[Address(RVA = "0x1808098", Offset = "0x1808098", VA = "0x1808098")]
		private static extern RESULT FMOD5_ChannelGroup_GetDSPClock(IntPtr channelgroup, out ulong dspclock, out ulong parentclock);

		[PreserveSig]
		[Token(Token = "0x60007DB")]
		[Address(RVA = "0x180813C", Offset = "0x180813C", VA = "0x180813C")]
		private static extern RESULT FMOD5_ChannelGroup_SetDelay(IntPtr channelgroup, ulong dspclock_start, ulong dspclock_end, bool stopchannels);

		[PreserveSig]
		[Token(Token = "0x60007DC")]
		[Address(RVA = "0x1808244", Offset = "0x1808244", VA = "0x1808244")]
		private static extern RESULT FMOD5_ChannelGroup_GetDelay(IntPtr channelgroup, out ulong dspclock_start, out ulong dspclock_end, IntPtr zero);

		[PreserveSig]
		[Token(Token = "0x60007DD")]
		[Address(RVA = "0x18082F4", Offset = "0x18082F4", VA = "0x18082F4")]
		private static extern RESULT FMOD5_ChannelGroup_GetDelay(IntPtr channelgroup, out ulong dspclock_start, out ulong dspclock_end, out bool stopchannels);

		[PreserveSig]
		[Token(Token = "0x60007DE")]
		[Address(RVA = "0x18083B8", Offset = "0x18083B8", VA = "0x18083B8")]
		private static extern RESULT FMOD5_ChannelGroup_AddFadePoint(IntPtr channelgroup, ulong dspclock, float volume);

		[PreserveSig]
		[Token(Token = "0x60007DF")]
		[Address(RVA = "0x1808460", Offset = "0x1808460", VA = "0x1808460")]
		private static extern RESULT FMOD5_ChannelGroup_SetFadePointRamp(IntPtr channelgroup, ulong dspclock, float volume);

		[PreserveSig]
		[Token(Token = "0x60007E0")]
		[Address(RVA = "0x1808508", Offset = "0x1808508", VA = "0x1808508")]
		private static extern RESULT FMOD5_ChannelGroup_RemoveFadePoints(IntPtr channelgroup, ulong dspclock_start, ulong dspclock_end);

		[PreserveSig]
		[Token(Token = "0x60007E1")]
		[Address(RVA = "0x18085A8", Offset = "0x18085A8", VA = "0x18085A8")]
		private static extern RESULT FMOD5_ChannelGroup_GetFadePoints(IntPtr channelgroup, ref uint numpoints, ulong[] point_dspclock, float[] point_volume);

		[PreserveSig]
		[Token(Token = "0x60007E2")]
		[Address(RVA = "0x1808664", Offset = "0x1808664", VA = "0x1808664")]
		private static extern RESULT FMOD5_ChannelGroup_GetDSP(IntPtr channelgroup, int index, out IntPtr dsp);

		[PreserveSig]
		[Token(Token = "0x60007E3")]
		[Address(RVA = "0x1808704", Offset = "0x1808704", VA = "0x1808704")]
		private static extern RESULT FMOD5_ChannelGroup_AddDSP(IntPtr channelgroup, int index, IntPtr dsp);

		[PreserveSig]
		[Token(Token = "0x60007E4")]
		[Address(RVA = "0x18087A4", Offset = "0x18087A4", VA = "0x18087A4")]
		private static extern RESULT FMOD5_ChannelGroup_RemoveDSP(IntPtr channelgroup, IntPtr dsp);

		[PreserveSig]
		[Token(Token = "0x60007E5")]
		[Address(RVA = "0x180883C", Offset = "0x180883C", VA = "0x180883C")]
		private static extern RESULT FMOD5_ChannelGroup_GetNumDSPs(IntPtr channelgroup, out int numdsps);

		[PreserveSig]
		[Token(Token = "0x60007E6")]
		[Address(RVA = "0x18088D4", Offset = "0x18088D4", VA = "0x18088D4")]
		private static extern RESULT FMOD5_ChannelGroup_SetDSPIndex(IntPtr channelgroup, IntPtr dsp, int index);

		[PreserveSig]
		[Token(Token = "0x60007E7")]
		[Address(RVA = "0x1808974", Offset = "0x1808974", VA = "0x1808974")]
		private static extern RESULT FMOD5_ChannelGroup_GetDSPIndex(IntPtr channelgroup, IntPtr dsp, out int index);

		[PreserveSig]
		[Token(Token = "0x60007E8")]
		[Address(RVA = "0x1808A14", Offset = "0x1808A14", VA = "0x1808A14")]
		private static extern RESULT FMOD5_ChannelGroup_Set3DAttributes(IntPtr channelgroup, ref VECTOR pos, ref VECTOR vel);

		[PreserveSig]
		[Token(Token = "0x60007E9")]
		[Address(RVA = "0x1808AB4", Offset = "0x1808AB4", VA = "0x1808AB4")]
		private static extern RESULT FMOD5_ChannelGroup_Get3DAttributes(IntPtr channelgroup, out VECTOR pos, out VECTOR vel);

		[PreserveSig]
		[Token(Token = "0x60007EA")]
		[Address(RVA = "0x1808B54", Offset = "0x1808B54", VA = "0x1808B54")]
		private static extern RESULT FMOD5_ChannelGroup_Set3DMinMaxDistance(IntPtr channelgroup, float mindistance, float maxdistance);

		[PreserveSig]
		[Token(Token = "0x60007EB")]
		[Address(RVA = "0x1808BF4", Offset = "0x1808BF4", VA = "0x1808BF4")]
		private static extern RESULT FMOD5_ChannelGroup_Get3DMinMaxDistance(IntPtr channelgroup, out float mindistance, out float maxdistance);

		[PreserveSig]
		[Token(Token = "0x60007EC")]
		[Address(RVA = "0x1808C94", Offset = "0x1808C94", VA = "0x1808C94")]
		private static extern RESULT FMOD5_ChannelGroup_Set3DConeSettings(IntPtr channelgroup, float insideconeangle, float outsideconeangle, float outsidevolume);

		[PreserveSig]
		[Token(Token = "0x60007ED")]
		[Address(RVA = "0x1808D44", Offset = "0x1808D44", VA = "0x1808D44")]
		private static extern RESULT FMOD5_ChannelGroup_Get3DConeSettings(IntPtr channelgroup, out float insideconeangle, out float outsideconeangle, out float outsidevolume);

		[PreserveSig]
		[Token(Token = "0x60007EE")]
		[Address(RVA = "0x1808DF4", Offset = "0x1808DF4", VA = "0x1808DF4")]
		private static extern RESULT FMOD5_ChannelGroup_Set3DConeOrientation(IntPtr channelgroup, ref VECTOR orientation);

		[PreserveSig]
		[Token(Token = "0x60007EF")]
		[Address(RVA = "0x1808E8C", Offset = "0x1808E8C", VA = "0x1808E8C")]
		private static extern RESULT FMOD5_ChannelGroup_Get3DConeOrientation(IntPtr channelgroup, out VECTOR orientation);

		[PreserveSig]
		[Token(Token = "0x60007F0")]
		[Address(RVA = "0x1808F24", Offset = "0x1808F24", VA = "0x1808F24")]
		private static extern RESULT FMOD5_ChannelGroup_Set3DCustomRolloff(IntPtr channelgroup, ref VECTOR points, int numpoints);

		[PreserveSig]
		[Token(Token = "0x60007F1")]
		[Address(RVA = "0x1808FC4", Offset = "0x1808FC4", VA = "0x1808FC4")]
		private static extern RESULT FMOD5_ChannelGroup_Get3DCustomRolloff(IntPtr channelgroup, out IntPtr points, out int numpoints);

		[PreserveSig]
		[Token(Token = "0x60007F2")]
		[Address(RVA = "0x1809064", Offset = "0x1809064", VA = "0x1809064")]
		private static extern RESULT FMOD5_ChannelGroup_Set3DOcclusion(IntPtr channelgroup, float directocclusion, float reverbocclusion);

		[PreserveSig]
		[Token(Token = "0x60007F3")]
		[Address(RVA = "0x1809104", Offset = "0x1809104", VA = "0x1809104")]
		private static extern RESULT FMOD5_ChannelGroup_Get3DOcclusion(IntPtr channelgroup, out float directocclusion, out float reverbocclusion);

		[PreserveSig]
		[Token(Token = "0x60007F4")]
		[Address(RVA = "0x18091A4", Offset = "0x18091A4", VA = "0x18091A4")]
		private static extern RESULT FMOD5_ChannelGroup_Set3DSpread(IntPtr channelgroup, float angle);

		[PreserveSig]
		[Token(Token = "0x60007F5")]
		[Address(RVA = "0x180923C", Offset = "0x180923C", VA = "0x180923C")]
		private static extern RESULT FMOD5_ChannelGroup_Get3DSpread(IntPtr channelgroup, out float angle);

		[PreserveSig]
		[Token(Token = "0x60007F6")]
		[Address(RVA = "0x18092D4", Offset = "0x18092D4", VA = "0x18092D4")]
		private static extern RESULT FMOD5_ChannelGroup_Set3DLevel(IntPtr channelgroup, float level);

		[PreserveSig]
		[Token(Token = "0x60007F7")]
		[Address(RVA = "0x180936C", Offset = "0x180936C", VA = "0x180936C")]
		private static extern RESULT FMOD5_ChannelGroup_Get3DLevel(IntPtr channelgroup, out float level);

		[PreserveSig]
		[Token(Token = "0x60007F8")]
		[Address(RVA = "0x1809404", Offset = "0x1809404", VA = "0x1809404")]
		private static extern RESULT FMOD5_ChannelGroup_Set3DDopplerLevel(IntPtr channelgroup, float level);

		[PreserveSig]
		[Token(Token = "0x60007F9")]
		[Address(RVA = "0x180949C", Offset = "0x180949C", VA = "0x180949C")]
		private static extern RESULT FMOD5_ChannelGroup_Get3DDopplerLevel(IntPtr channelgroup, out float level);

		[PreserveSig]
		[Token(Token = "0x60007FA")]
		[Address(RVA = "0x1809538", Offset = "0x1809538", VA = "0x1809538")]
		private static extern RESULT FMOD5_ChannelGroup_Set3DDistanceFilter(IntPtr channelgroup, bool custom, float customLevel, float centerFreq);

		[PreserveSig]
		[Token(Token = "0x60007FB")]
		[Address(RVA = "0x18095E8", Offset = "0x18095E8", VA = "0x18095E8")]
		private static extern RESULT FMOD5_ChannelGroup_Get3DDistanceFilter(IntPtr channelgroup, out bool custom, out float customLevel, out float centerFreq);

		[PreserveSig]
		[Token(Token = "0x60007FC")]
		[Address(RVA = "0x18096AC", Offset = "0x18096AC", VA = "0x18096AC")]
		private static extern RESULT FMOD5_ChannelGroup_SetUserData(IntPtr channelgroup, IntPtr userdata);

		[PreserveSig]
		[Token(Token = "0x60007FD")]
		[Address(RVA = "0x1809744", Offset = "0x1809744", VA = "0x1809744")]
		private static extern RESULT FMOD5_ChannelGroup_GetUserData(IntPtr channelgroup, out IntPtr userdata);

		[Token(Token = "0x60007FE")]
		[Address(RVA = "0x10EEFB4", Offset = "0x10EEFB4", VA = "0x10EEFB4")]
		public bool hasHandle()
		{
			return default(bool);
		}

		[Token(Token = "0x60007FF")]
		[Address(RVA = "0x10EEFBC", Offset = "0x10EEFBC", VA = "0x10EEFBC")]
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
		[Address(RVA = "0x10ED830", Offset = "0x10ED830", VA = "0x10ED830")]
		public RESULT release()
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000801")]
		[Address(RVA = "0x10ED838", Offset = "0x10ED838", VA = "0x10ED838")]
		public RESULT getSystemObject(out System system)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000802")]
		[Address(RVA = "0x10ED840", Offset = "0x10ED840", VA = "0x10ED840")]
		public RESULT setMaxAudible(int maxaudible)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000803")]
		[Address(RVA = "0x10ED848", Offset = "0x10ED848", VA = "0x10ED848")]
		public RESULT getMaxAudible(out int maxaudible)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000804")]
		[Address(RVA = "0x10ED850", Offset = "0x10ED850", VA = "0x10ED850")]
		public RESULT setMaxAudibleBehavior(SOUNDGROUP_BEHAVIOR behavior)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000805")]
		[Address(RVA = "0x10ED858", Offset = "0x10ED858", VA = "0x10ED858")]
		public RESULT getMaxAudibleBehavior(out SOUNDGROUP_BEHAVIOR behavior)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000806")]
		[Address(RVA = "0x10ED860", Offset = "0x10ED860", VA = "0x10ED860")]
		public RESULT setMuteFadeSpeed(float speed)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000807")]
		[Address(RVA = "0x10ED868", Offset = "0x10ED868", VA = "0x10ED868")]
		public RESULT getMuteFadeSpeed(out float speed)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000808")]
		[Address(RVA = "0x10ED870", Offset = "0x10ED870", VA = "0x10ED870")]
		public RESULT setVolume(float volume)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000809")]
		[Address(RVA = "0x10ED878", Offset = "0x10ED878", VA = "0x10ED878")]
		public RESULT getVolume(out float volume)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600080A")]
		[Address(RVA = "0x10ED880", Offset = "0x10ED880", VA = "0x10ED880")]
		public RESULT stop()
		{
			return default(RESULT);
		}

		[Token(Token = "0x600080B")]
		[Address(RVA = "0x10ED888", Offset = "0x10ED888", VA = "0x10ED888")]
		public RESULT getName(out string name, int namelen)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600080C")]
		[Address(RVA = "0x10ED890", Offset = "0x10ED890", VA = "0x10ED890")]
		public RESULT getNumSounds(out int numsounds)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600080D")]
		[Address(RVA = "0x10ED898", Offset = "0x10ED898", VA = "0x10ED898")]
		public RESULT getSound(int index, out Sound sound)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600080E")]
		[Address(RVA = "0x10ED8A0", Offset = "0x10ED8A0", VA = "0x10ED8A0")]
		public RESULT getNumPlaying(out int numplaying)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600080F")]
		[Address(RVA = "0x10ED8A8", Offset = "0x10ED8A8", VA = "0x10ED8A8")]
		public RESULT setUserData(IntPtr userdata)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000810")]
		[Address(RVA = "0x10ED8B0", Offset = "0x10ED8B0", VA = "0x10ED8B0")]
		public RESULT getUserData(out IntPtr userdata)
		{
			return default(RESULT);
		}

		[PreserveSig]
		[Token(Token = "0x6000811")]
		[Address(RVA = "0x17F5268", Offset = "0x17F5268", VA = "0x17F5268")]
		private static extern RESULT FMOD5_SoundGroup_Release(IntPtr soundgroup);

		[PreserveSig]
		[Token(Token = "0x6000812")]
		[Address(RVA = "0x17F52F0", Offset = "0x17F52F0", VA = "0x17F52F0")]
		private static extern RESULT FMOD5_SoundGroup_GetSystemObject(IntPtr soundgroup, out IntPtr system);

		[PreserveSig]
		[Token(Token = "0x6000813")]
		[Address(RVA = "0x17F5388", Offset = "0x17F5388", VA = "0x17F5388")]
		private static extern RESULT FMOD5_SoundGroup_SetMaxAudible(IntPtr soundgroup, int maxaudible);

		[PreserveSig]
		[Token(Token = "0x6000814")]
		[Address(RVA = "0x17F5420", Offset = "0x17F5420", VA = "0x17F5420")]
		private static extern RESULT FMOD5_SoundGroup_GetMaxAudible(IntPtr soundgroup, out int maxaudible);

		[PreserveSig]
		[Token(Token = "0x6000815")]
		[Address(RVA = "0x17F54B8", Offset = "0x17F54B8", VA = "0x17F54B8")]
		private static extern RESULT FMOD5_SoundGroup_SetMaxAudibleBehavior(IntPtr soundgroup, SOUNDGROUP_BEHAVIOR behavior);

		[PreserveSig]
		[Token(Token = "0x6000816")]
		[Address(RVA = "0x17F5550", Offset = "0x17F5550", VA = "0x17F5550")]
		private static extern RESULT FMOD5_SoundGroup_GetMaxAudibleBehavior(IntPtr soundgroup, out SOUNDGROUP_BEHAVIOR behavior);

		[PreserveSig]
		[Token(Token = "0x6000817")]
		[Address(RVA = "0x17F55E8", Offset = "0x17F55E8", VA = "0x17F55E8")]
		private static extern RESULT FMOD5_SoundGroup_SetMuteFadeSpeed(IntPtr soundgroup, float speed);

		[PreserveSig]
		[Token(Token = "0x6000818")]
		[Address(RVA = "0x17F5680", Offset = "0x17F5680", VA = "0x17F5680")]
		private static extern RESULT FMOD5_SoundGroup_GetMuteFadeSpeed(IntPtr soundgroup, out float speed);

		[PreserveSig]
		[Token(Token = "0x6000819")]
		[Address(RVA = "0x17F5718", Offset = "0x17F5718", VA = "0x17F5718")]
		private static extern RESULT FMOD5_SoundGroup_SetVolume(IntPtr soundgroup, float volume);

		[PreserveSig]
		[Token(Token = "0x600081A")]
		[Address(RVA = "0x17F57B0", Offset = "0x17F57B0", VA = "0x17F57B0")]
		private static extern RESULT FMOD5_SoundGroup_GetVolume(IntPtr soundgroup, out float volume);

		[PreserveSig]
		[Token(Token = "0x600081B")]
		[Address(RVA = "0x17F5848", Offset = "0x17F5848", VA = "0x17F5848")]
		private static extern RESULT FMOD5_SoundGroup_Stop(IntPtr soundgroup);

		[PreserveSig]
		[Token(Token = "0x600081C")]
		[Address(RVA = "0x17F5A74", Offset = "0x17F5A74", VA = "0x17F5A74")]
		private static extern RESULT FMOD5_SoundGroup_GetName(IntPtr soundgroup, IntPtr name, int namelen);

		[PreserveSig]
		[Token(Token = "0x600081D")]
		[Address(RVA = "0x17F5B14", Offset = "0x17F5B14", VA = "0x17F5B14")]
		private static extern RESULT FMOD5_SoundGroup_GetNumSounds(IntPtr soundgroup, out int numsounds);

		[PreserveSig]
		[Token(Token = "0x600081E")]
		[Address(RVA = "0x17F5BAC", Offset = "0x17F5BAC", VA = "0x17F5BAC")]
		private static extern RESULT FMOD5_SoundGroup_GetSound(IntPtr soundgroup, int index, out IntPtr sound);

		[PreserveSig]
		[Token(Token = "0x600081F")]
		[Address(RVA = "0x17F5C4C", Offset = "0x17F5C4C", VA = "0x17F5C4C")]
		private static extern RESULT FMOD5_SoundGroup_GetNumPlaying(IntPtr soundgroup, out int numplaying);

		[PreserveSig]
		[Token(Token = "0x6000820")]
		[Address(RVA = "0x17F5CE4", Offset = "0x17F5CE4", VA = "0x17F5CE4")]
		private static extern RESULT FMOD5_SoundGroup_SetUserData(IntPtr soundgroup, IntPtr userdata);

		[PreserveSig]
		[Token(Token = "0x6000821")]
		[Address(RVA = "0x17F5D7C", Offset = "0x17F5D7C", VA = "0x17F5D7C")]
		private static extern RESULT FMOD5_SoundGroup_GetUserData(IntPtr soundgroup, out IntPtr userdata);

		[Token(Token = "0x6000822")]
		[Address(RVA = "0x10ED8B8", Offset = "0x10ED8B8", VA = "0x10ED8B8")]
		public bool hasHandle()
		{
			return default(bool);
		}

		[Token(Token = "0x6000823")]
		[Address(RVA = "0x10ED8C0", Offset = "0x10ED8C0", VA = "0x10ED8C0")]
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
		[Address(RVA = "0x10EF020", Offset = "0x10EF020", VA = "0x10EF020")]
		public RESULT release()
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000825")]
		[Address(RVA = "0x10EF028", Offset = "0x10EF028", VA = "0x10EF028")]
		public RESULT getSystemObject(out System system)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000826")]
		[Address(RVA = "0x10EF030", Offset = "0x10EF030", VA = "0x10EF030")]
		public RESULT addInput(DSP input)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000827")]
		[Address(RVA = "0x10EF038", Offset = "0x10EF038", VA = "0x10EF038")]
		public RESULT addInput(DSP input, out DSPConnection connection, DSPCONNECTION_TYPE type = DSPCONNECTION_TYPE.STANDARD)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000828")]
		[Address(RVA = "0x10EF040", Offset = "0x10EF040", VA = "0x10EF040")]
		public RESULT disconnectFrom(DSP target, DSPConnection connection)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000829")]
		[Address(RVA = "0x10EF048", Offset = "0x10EF048", VA = "0x10EF048")]
		public RESULT disconnectAll(bool inputs, bool outputs)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600082A")]
		[Address(RVA = "0x10EF058", Offset = "0x10EF058", VA = "0x10EF058")]
		public RESULT getNumInputs(out int numinputs)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600082B")]
		[Address(RVA = "0x10EF060", Offset = "0x10EF060", VA = "0x10EF060")]
		public RESULT getNumOutputs(out int numoutputs)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600082C")]
		[Address(RVA = "0x10EF068", Offset = "0x10EF068", VA = "0x10EF068")]
		public RESULT getInput(int index, out DSP input, out DSPConnection inputconnection)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600082D")]
		[Address(RVA = "0x10EF070", Offset = "0x10EF070", VA = "0x10EF070")]
		public RESULT getOutput(int index, out DSP output, out DSPConnection outputconnection)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600082E")]
		[Address(RVA = "0x10EF078", Offset = "0x10EF078", VA = "0x10EF078")]
		public RESULT setActive(bool active)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600082F")]
		[Address(RVA = "0x10EF084", Offset = "0x10EF084", VA = "0x10EF084")]
		public RESULT getActive(out bool active)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000830")]
		[Address(RVA = "0x10EF08C", Offset = "0x10EF08C", VA = "0x10EF08C")]
		public RESULT setBypass(bool bypass)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000831")]
		[Address(RVA = "0x10EF098", Offset = "0x10EF098", VA = "0x10EF098")]
		public RESULT getBypass(out bool bypass)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000832")]
		[Address(RVA = "0x10EF0A0", Offset = "0x10EF0A0", VA = "0x10EF0A0")]
		public RESULT setWetDryMix(float prewet, float postwet, float dry)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000833")]
		[Address(RVA = "0x10EF0A8", Offset = "0x10EF0A8", VA = "0x10EF0A8")]
		public RESULT getWetDryMix(out float prewet, out float postwet, out float dry)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000834")]
		[Address(RVA = "0x10EF0B0", Offset = "0x10EF0B0", VA = "0x10EF0B0")]
		public RESULT setChannelFormat(CHANNELMASK channelmask, int numchannels, SPEAKERMODE source_speakermode)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000835")]
		[Address(RVA = "0x10EF0B8", Offset = "0x10EF0B8", VA = "0x10EF0B8")]
		public RESULT getChannelFormat(out CHANNELMASK channelmask, out int numchannels, out SPEAKERMODE source_speakermode)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000836")]
		[Address(RVA = "0x10EF0C0", Offset = "0x10EF0C0", VA = "0x10EF0C0")]
		public RESULT getOutputChannelFormat(CHANNELMASK inmask, int inchannels, SPEAKERMODE inspeakermode, out CHANNELMASK outmask, out int outchannels, out SPEAKERMODE outspeakermode)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000837")]
		[Address(RVA = "0x10EF0C8", Offset = "0x10EF0C8", VA = "0x10EF0C8")]
		public RESULT reset()
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000838")]
		[Address(RVA = "0x10EF0D0", Offset = "0x10EF0D0", VA = "0x10EF0D0")]
		public RESULT setParameterFloat(int index, float value)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000839")]
		[Address(RVA = "0x10EF0D8", Offset = "0x10EF0D8", VA = "0x10EF0D8")]
		public RESULT setParameterInt(int index, int value)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600083A")]
		[Address(RVA = "0x10EF0E0", Offset = "0x10EF0E0", VA = "0x10EF0E0")]
		public RESULT setParameterBool(int index, bool value)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600083B")]
		[Address(RVA = "0x10EF0EC", Offset = "0x10EF0EC", VA = "0x10EF0EC")]
		public RESULT setParameterData(int index, byte[] data)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600083C")]
		[Address(RVA = "0x10EF0F4", Offset = "0x10EF0F4", VA = "0x10EF0F4")]
		public RESULT getParameterFloat(int index, out float value)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600083D")]
		[Address(RVA = "0x10EF0FC", Offset = "0x10EF0FC", VA = "0x10EF0FC")]
		public RESULT getParameterInt(int index, out int value)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600083E")]
		[Address(RVA = "0x10EF104", Offset = "0x10EF104", VA = "0x10EF104")]
		public RESULT getParameterBool(int index, out bool value)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600083F")]
		[Address(RVA = "0x10EF10C", Offset = "0x10EF10C", VA = "0x10EF10C")]
		public RESULT getParameterData(int index, out IntPtr data, out uint length)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000840")]
		[Address(RVA = "0x10EF114", Offset = "0x10EF114", VA = "0x10EF114")]
		public RESULT getNumParameters(out int numparams)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000841")]
		[Address(RVA = "0x10EF11C", Offset = "0x10EF11C", VA = "0x10EF11C")]
		public RESULT getParameterInfo(int index, out DSP_PARAMETER_DESC desc)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000842")]
		[Address(RVA = "0x10EF124", Offset = "0x10EF124", VA = "0x10EF124")]
		public RESULT getDataParameterIndex(int datatype, out int index)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000843")]
		[Address(RVA = "0x10EF12C", Offset = "0x10EF12C", VA = "0x10EF12C")]
		public RESULT showConfigDialog(IntPtr hwnd, bool show)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000844")]
		[Address(RVA = "0x10EF138", Offset = "0x10EF138", VA = "0x10EF138")]
		public RESULT getInfo(out string name, out uint version, out int channels, out int configwidth, out int configheight)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000845")]
		[Address(RVA = "0x10EF140", Offset = "0x10EF140", VA = "0x10EF140")]
		public RESULT getInfo(out uint version, out int channels, out int configwidth, out int configheight)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000846")]
		[Address(RVA = "0x10EF148", Offset = "0x10EF148", VA = "0x10EF148")]
		public RESULT getType(out DSP_TYPE type)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000847")]
		[Address(RVA = "0x10EF150", Offset = "0x10EF150", VA = "0x10EF150")]
		public RESULT getIdle(out bool idle)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000848")]
		[Address(RVA = "0x10EF158", Offset = "0x10EF158", VA = "0x10EF158")]
		public RESULT setUserData(IntPtr userdata)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000849")]
		[Address(RVA = "0x10EF160", Offset = "0x10EF160", VA = "0x10EF160")]
		public RESULT getUserData(out IntPtr userdata)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600084A")]
		[Address(RVA = "0x10EF168", Offset = "0x10EF168", VA = "0x10EF168")]
		public RESULT setMeteringEnabled(bool inputEnabled, bool outputEnabled)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600084B")]
		[Address(RVA = "0x10EF178", Offset = "0x10EF178", VA = "0x10EF178")]
		public RESULT getMeteringEnabled(out bool inputEnabled, out bool outputEnabled)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600084C")]
		[Address(RVA = "0x10EF180", Offset = "0x10EF180", VA = "0x10EF180")]
		public RESULT getMeteringInfo(IntPtr zero, out DSP_METERING_INFO outputInfo)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600084D")]
		[Address(RVA = "0x10EF188", Offset = "0x10EF188", VA = "0x10EF188")]
		public RESULT getMeteringInfo(out DSP_METERING_INFO inputInfo, IntPtr zero)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600084E")]
		[Address(RVA = "0x10EF190", Offset = "0x10EF190", VA = "0x10EF190")]
		public RESULT getMeteringInfo(out DSP_METERING_INFO inputInfo, out DSP_METERING_INFO outputInfo)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600084F")]
		[Address(RVA = "0x10EF198", Offset = "0x10EF198", VA = "0x10EF198")]
		public RESULT getCPUUsage(out uint exclusive, out uint inclusive)
		{
			return default(RESULT);
		}

		[PreserveSig]
		[Token(Token = "0x6000850")]
		[Address(RVA = "0x1809C94", Offset = "0x1809C94", VA = "0x1809C94")]
		private static extern RESULT FMOD5_DSP_Release(IntPtr dsp);

		[PreserveSig]
		[Token(Token = "0x6000851")]
		[Address(RVA = "0x1809D1C", Offset = "0x1809D1C", VA = "0x1809D1C")]
		private static extern RESULT FMOD5_DSP_GetSystemObject(IntPtr dsp, out IntPtr system);

		[PreserveSig]
		[Token(Token = "0x6000852")]
		[Address(RVA = "0x1809E08", Offset = "0x1809E08", VA = "0x1809E08")]
		private static extern RESULT FMOD5_DSP_AddInput(IntPtr dsp, IntPtr input, IntPtr zero, DSPCONNECTION_TYPE type);

		[PreserveSig]
		[Token(Token = "0x6000853")]
		[Address(RVA = "0x1809EB8", Offset = "0x1809EB8", VA = "0x1809EB8")]
		private static extern RESULT FMOD5_DSP_AddInput(IntPtr dsp, IntPtr input, out IntPtr connection, DSPCONNECTION_TYPE type);

		[PreserveSig]
		[Token(Token = "0x6000854")]
		[Address(RVA = "0x1809F68", Offset = "0x1809F68", VA = "0x1809F68")]
		private static extern RESULT FMOD5_DSP_DisconnectFrom(IntPtr dsp, IntPtr target, IntPtr connection);

		[PreserveSig]
		[Token(Token = "0x6000855")]
		[Address(RVA = "0x180A00C", Offset = "0x180A00C", VA = "0x180A00C")]
		private static extern RESULT FMOD5_DSP_DisconnectAll(IntPtr dsp, bool inputs, bool outputs);

		[PreserveSig]
		[Token(Token = "0x6000856")]
		[Address(RVA = "0x180A0AC", Offset = "0x180A0AC", VA = "0x180A0AC")]
		private static extern RESULT FMOD5_DSP_GetNumInputs(IntPtr dsp, out int numinputs);

		[PreserveSig]
		[Token(Token = "0x6000857")]
		[Address(RVA = "0x180A144", Offset = "0x180A144", VA = "0x180A144")]
		private static extern RESULT FMOD5_DSP_GetNumOutputs(IntPtr dsp, out int numoutputs);

		[PreserveSig]
		[Token(Token = "0x6000858")]
		[Address(RVA = "0x180A1DC", Offset = "0x180A1DC", VA = "0x180A1DC")]
		private static extern RESULT FMOD5_DSP_GetInput(IntPtr dsp, int index, out IntPtr input, out IntPtr inputconnection);

		[PreserveSig]
		[Token(Token = "0x6000859")]
		[Address(RVA = "0x180A28C", Offset = "0x180A28C", VA = "0x180A28C")]
		private static extern RESULT FMOD5_DSP_GetOutput(IntPtr dsp, int index, out IntPtr output, out IntPtr outputconnection);

		[PreserveSig]
		[Token(Token = "0x600085A")]
		[Address(RVA = "0x180A340", Offset = "0x180A340", VA = "0x180A340")]
		private static extern RESULT FMOD5_DSP_SetActive(IntPtr dsp, bool active);

		[PreserveSig]
		[Token(Token = "0x600085B")]
		[Address(RVA = "0x180A3D8", Offset = "0x180A3D8", VA = "0x180A3D8")]
		private static extern RESULT FMOD5_DSP_GetActive(IntPtr dsp, out bool active);

		[PreserveSig]
		[Token(Token = "0x600085C")]
		[Address(RVA = "0x180A488", Offset = "0x180A488", VA = "0x180A488")]
		private static extern RESULT FMOD5_DSP_SetBypass(IntPtr dsp, bool bypass);

		[PreserveSig]
		[Token(Token = "0x600085D")]
		[Address(RVA = "0x180A520", Offset = "0x180A520", VA = "0x180A520")]
		private static extern RESULT FMOD5_DSP_GetBypass(IntPtr dsp, out bool bypass);

		[PreserveSig]
		[Token(Token = "0x600085E")]
		[Address(RVA = "0x180A5CC", Offset = "0x180A5CC", VA = "0x180A5CC")]
		private static extern RESULT FMOD5_DSP_SetWetDryMix(IntPtr dsp, float prewet, float postwet, float dry);

		[PreserveSig]
		[Token(Token = "0x600085F")]
		[Address(RVA = "0x180A67C", Offset = "0x180A67C", VA = "0x180A67C")]
		private static extern RESULT FMOD5_DSP_GetWetDryMix(IntPtr dsp, out float prewet, out float postwet, out float dry);

		[PreserveSig]
		[Token(Token = "0x6000860")]
		[Address(RVA = "0x180A72C", Offset = "0x180A72C", VA = "0x180A72C")]
		private static extern RESULT FMOD5_DSP_SetChannelFormat(IntPtr dsp, CHANNELMASK channelmask, int numchannels, SPEAKERMODE source_speakermode);

		[PreserveSig]
		[Token(Token = "0x6000861")]
		[Address(RVA = "0x180A7DC", Offset = "0x180A7DC", VA = "0x180A7DC")]
		private static extern RESULT FMOD5_DSP_GetChannelFormat(IntPtr dsp, out CHANNELMASK channelmask, out int numchannels, out SPEAKERMODE source_speakermode);

		[PreserveSig]
		[Token(Token = "0x6000862")]
		[Address(RVA = "0x180A88C", Offset = "0x180A88C", VA = "0x180A88C")]
		private static extern RESULT FMOD5_DSP_GetOutputChannelFormat(IntPtr dsp, CHANNELMASK inmask, int inchannels, SPEAKERMODE inspeakermode, out CHANNELMASK outmask, out int outchannels, out SPEAKERMODE outspeakermode);

		[PreserveSig]
		[Token(Token = "0x6000863")]
		[Address(RVA = "0x180A95C", Offset = "0x180A95C", VA = "0x180A95C")]
		private static extern RESULT FMOD5_DSP_Reset(IntPtr dsp);

		[PreserveSig]
		[Token(Token = "0x6000864")]
		[Address(RVA = "0x180A9E4", Offset = "0x180A9E4", VA = "0x180A9E4")]
		private static extern RESULT FMOD5_DSP_SetParameterFloat(IntPtr dsp, int index, float value);

		[PreserveSig]
		[Token(Token = "0x6000865")]
		[Address(RVA = "0x180AA8C", Offset = "0x180AA8C", VA = "0x180AA8C")]
		private static extern RESULT FMOD5_DSP_SetParameterInt(IntPtr dsp, int index, int value);

		[PreserveSig]
		[Token(Token = "0x6000866")]
		[Address(RVA = "0x180AB30", Offset = "0x180AB30", VA = "0x180AB30")]
		private static extern RESULT FMOD5_DSP_SetParameterBool(IntPtr dsp, int index, bool value);

		[PreserveSig]
		[Token(Token = "0x6000867")]
		[Address(RVA = "0x180AC6C", Offset = "0x180AC6C", VA = "0x180AC6C")]
		private static extern RESULT FMOD5_DSP_SetParameterData(IntPtr dsp, int index, IntPtr data, uint length);

		[PreserveSig]
		[Token(Token = "0x6000868")]
		[Address(RVA = "0x180AD78", Offset = "0x180AD78", VA = "0x180AD78")]
		private static extern RESULT FMOD5_DSP_GetParameterFloat(IntPtr dsp, int index, out float value, IntPtr valuestr, int valuestrlen);

		[PreserveSig]
		[Token(Token = "0x6000869")]
		[Address(RVA = "0x180AE8C", Offset = "0x180AE8C", VA = "0x180AE8C")]
		private static extern RESULT FMOD5_DSP_GetParameterInt(IntPtr dsp, int index, out int value, IntPtr valuestr, int valuestrlen);

		[PreserveSig]
		[Token(Token = "0x600086A")]
		[Address(RVA = "0x180AFA0", Offset = "0x180AFA0", VA = "0x180AFA0")]
		private static extern RESULT FMOD5_DSP_GetParameterBool(IntPtr dsp, int index, out bool value, IntPtr valuestr, int valuestrlen);

		[PreserveSig]
		[Token(Token = "0x600086B")]
		[Address(RVA = "0x180B0D8", Offset = "0x180B0D8", VA = "0x180B0D8")]
		private static extern RESULT FMOD5_DSP_GetParameterData(IntPtr dsp, int index, out IntPtr data, out uint length, IntPtr valuestr, int valuestrlen);

		[PreserveSig]
		[Token(Token = "0x600086C")]
		[Address(RVA = "0x180B1A0", Offset = "0x180B1A0", VA = "0x180B1A0")]
		private static extern RESULT FMOD5_DSP_GetNumParameters(IntPtr dsp, out int numparams);

		[PreserveSig]
		[Token(Token = "0x600086D")]
		[Address(RVA = "0x180B2F4", Offset = "0x180B2F4", VA = "0x180B2F4")]
		private static extern RESULT FMOD5_DSP_GetParameterInfo(IntPtr dsp, int index, out IntPtr desc);

		[PreserveSig]
		[Token(Token = "0x600086E")]
		[Address(RVA = "0x180B394", Offset = "0x180B394", VA = "0x180B394")]
		private static extern RESULT FMOD5_DSP_GetDataParameterIndex(IntPtr dsp, int datatype, out int index);

		[PreserveSig]
		[Token(Token = "0x600086F")]
		[Address(RVA = "0x180B438", Offset = "0x180B438", VA = "0x180B438")]
		private static extern RESULT FMOD5_DSP_ShowConfigDialog(IntPtr dsp, IntPtr hwnd, bool show);

		[PreserveSig]
		[Token(Token = "0x6000870")]
		[Address(RVA = "0x180B6A4", Offset = "0x180B6A4", VA = "0x180B6A4")]
		private static extern RESULT FMOD5_DSP_GetInfo(IntPtr dsp, IntPtr name, out uint version, out int channels, out int configwidth, out int configheight);

		[PreserveSig]
		[Token(Token = "0x6000871")]
		[Address(RVA = "0x180B7E4", Offset = "0x180B7E4", VA = "0x180B7E4")]
		private static extern RESULT FMOD5_DSP_GetType(IntPtr dsp, out DSP_TYPE type);

		[PreserveSig]
		[Token(Token = "0x6000872")]
		[Address(RVA = "0x180B87C", Offset = "0x180B87C", VA = "0x180B87C")]
		private static extern RESULT FMOD5_DSP_GetIdle(IntPtr dsp, out bool idle);

		[PreserveSig]
		[Token(Token = "0x6000873")]
		[Address(RVA = "0x180B928", Offset = "0x180B928", VA = "0x180B928")]
		private static extern RESULT FMOD5_DSP_SetUserData(IntPtr dsp, IntPtr userdata);

		[PreserveSig]
		[Token(Token = "0x6000874")]
		[Address(RVA = "0x180B9C0", Offset = "0x180B9C0", VA = "0x180B9C0")]
		private static extern RESULT FMOD5_DSP_GetUserData(IntPtr dsp, out IntPtr userdata);

		[PreserveSig]
		[Token(Token = "0x6000875")]
		[Address(RVA = "0x180BA60", Offset = "0x180BA60", VA = "0x180BA60")]
		public static extern RESULT FMOD5_DSP_SetMeteringEnabled(IntPtr dsp, bool inputEnabled, bool outputEnabled);

		[PreserveSig]
		[Token(Token = "0x6000876")]
		[Address(RVA = "0x180BB00", Offset = "0x180BB00", VA = "0x180BB00")]
		public static extern RESULT FMOD5_DSP_GetMeteringEnabled(IntPtr dsp, out bool inputEnabled, out bool outputEnabled);

		[PreserveSig]
		[Token(Token = "0x6000877")]
		[Address(RVA = "0x180BBC4", Offset = "0x180BBC4", VA = "0x180BBC4")]
		public static extern RESULT FMOD5_DSP_GetMeteringInfo(IntPtr dsp, IntPtr zero, out DSP_METERING_INFO outputInfo);

		[PreserveSig]
		[Token(Token = "0x6000878")]
		[Address(RVA = "0x180BCA8", Offset = "0x180BCA8", VA = "0x180BCA8")]
		public static extern RESULT FMOD5_DSP_GetMeteringInfo(IntPtr dsp, out DSP_METERING_INFO inputInfo, IntPtr zero);

		[PreserveSig]
		[Token(Token = "0x6000879")]
		[Address(RVA = "0x180BD8C", Offset = "0x180BD8C", VA = "0x180BD8C")]
		public static extern RESULT FMOD5_DSP_GetMeteringInfo(IntPtr dsp, out DSP_METERING_INFO inputInfo, out DSP_METERING_INFO outputInfo);

		[PreserveSig]
		[Token(Token = "0x600087A")]
		[Address(RVA = "0x180BE90", Offset = "0x180BE90", VA = "0x180BE90")]
		public static extern RESULT FMOD5_DSP_GetCPUUsage(IntPtr dsp, out uint exclusive, out uint inclusive);

		[Token(Token = "0x600087B")]
		[Address(RVA = "0x10EF280", Offset = "0x10EF280", VA = "0x10EF280")]
		public bool hasHandle()
		{
			return default(bool);
		}

		[Token(Token = "0x600087C")]
		[Address(RVA = "0x10EF288", Offset = "0x10EF288", VA = "0x10EF288")]
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
		[Address(RVA = "0x10EF2CC", Offset = "0x10EF2CC", VA = "0x10EF2CC")]
		public RESULT getInput(out DSP input)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600087E")]
		[Address(RVA = "0x10EF2D4", Offset = "0x10EF2D4", VA = "0x10EF2D4")]
		public RESULT getOutput(out DSP output)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600087F")]
		[Address(RVA = "0x10EF2DC", Offset = "0x10EF2DC", VA = "0x10EF2DC")]
		public RESULT setMix(float volume)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000880")]
		[Address(RVA = "0x10EF2E4", Offset = "0x10EF2E4", VA = "0x10EF2E4")]
		public RESULT getMix(out float volume)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000881")]
		[Address(RVA = "0x10EF2EC", Offset = "0x10EF2EC", VA = "0x10EF2EC")]
		public RESULT setMixMatrix(float[] matrix, int outchannels, int inchannels, int inchannel_hop = 0)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000882")]
		[Address(RVA = "0x10EF2F4", Offset = "0x10EF2F4", VA = "0x10EF2F4")]
		public RESULT getMixMatrix(float[] matrix, out int outchannels, out int inchannels, int inchannel_hop = 0)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000883")]
		[Address(RVA = "0x10EF2FC", Offset = "0x10EF2FC", VA = "0x10EF2FC")]
		public RESULT getType(out DSPCONNECTION_TYPE type)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000884")]
		[Address(RVA = "0x10EF304", Offset = "0x10EF304", VA = "0x10EF304")]
		public RESULT setUserData(IntPtr userdata)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000885")]
		[Address(RVA = "0x10EF30C", Offset = "0x10EF30C", VA = "0x10EF30C")]
		public RESULT getUserData(out IntPtr userdata)
		{
			return default(RESULT);
		}

		[PreserveSig]
		[Token(Token = "0x6000886")]
		[Address(RVA = "0x180BFC0", Offset = "0x180BFC0", VA = "0x180BFC0")]
		private static extern RESULT FMOD5_DSPConnection_GetInput(IntPtr dspconnection, out IntPtr input);

		[PreserveSig]
		[Token(Token = "0x6000887")]
		[Address(RVA = "0x180C058", Offset = "0x180C058", VA = "0x180C058")]
		private static extern RESULT FMOD5_DSPConnection_GetOutput(IntPtr dspconnection, out IntPtr output);

		[PreserveSig]
		[Token(Token = "0x6000888")]
		[Address(RVA = "0x180C0F0", Offset = "0x180C0F0", VA = "0x180C0F0")]
		private static extern RESULT FMOD5_DSPConnection_SetMix(IntPtr dspconnection, float volume);

		[PreserveSig]
		[Token(Token = "0x6000889")]
		[Address(RVA = "0x180C188", Offset = "0x180C188", VA = "0x180C188")]
		private static extern RESULT FMOD5_DSPConnection_GetMix(IntPtr dspconnection, out float volume);

		[PreserveSig]
		[Token(Token = "0x600088A")]
		[Address(RVA = "0x180C220", Offset = "0x180C220", VA = "0x180C220")]
		private static extern RESULT FMOD5_DSPConnection_SetMixMatrix(IntPtr dspconnection, float[] matrix, int outchannels, int inchannels, int inchannel_hop);

		[PreserveSig]
		[Token(Token = "0x600088B")]
		[Address(RVA = "0x180C2E0", Offset = "0x180C2E0", VA = "0x180C2E0")]
		private static extern RESULT FMOD5_DSPConnection_GetMixMatrix(IntPtr dspconnection, float[] matrix, out int outchannels, out int inchannels, int inchannel_hop);

		[PreserveSig]
		[Token(Token = "0x600088C")]
		[Address(RVA = "0x180C3A0", Offset = "0x180C3A0", VA = "0x180C3A0")]
		private static extern RESULT FMOD5_DSPConnection_GetType(IntPtr dspconnection, out DSPCONNECTION_TYPE type);

		[PreserveSig]
		[Token(Token = "0x600088D")]
		[Address(RVA = "0x180C438", Offset = "0x180C438", VA = "0x180C438")]
		private static extern RESULT FMOD5_DSPConnection_SetUserData(IntPtr dspconnection, IntPtr userdata);

		[PreserveSig]
		[Token(Token = "0x600088E")]
		[Address(RVA = "0x180C4D0", Offset = "0x180C4D0", VA = "0x180C4D0")]
		private static extern RESULT FMOD5_DSPConnection_GetUserData(IntPtr dspconnection, out IntPtr userdata);

		[Token(Token = "0x600088F")]
		[Address(RVA = "0x10EF314", Offset = "0x10EF314", VA = "0x10EF314")]
		public bool hasHandle()
		{
			return default(bool);
		}

		[Token(Token = "0x6000890")]
		[Address(RVA = "0x10EF31C", Offset = "0x10EF31C", VA = "0x10EF31C")]
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
		[Address(RVA = "0x10ED414", Offset = "0x10ED414", VA = "0x10ED414")]
		public RESULT release()
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000892")]
		[Address(RVA = "0x10ED41C", Offset = "0x10ED41C", VA = "0x10ED41C")]
		public RESULT addPolygon(float directocclusion, float reverbocclusion, bool doublesided, int numvertices, VECTOR[] vertices, out int polygonindex)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000893")]
		[Address(RVA = "0x10ED428", Offset = "0x10ED428", VA = "0x10ED428")]
		public RESULT getNumPolygons(out int numpolygons)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000894")]
		[Address(RVA = "0x10ED430", Offset = "0x10ED430", VA = "0x10ED430")]
		public RESULT getMaxPolygons(out int maxpolygons, out int maxvertices)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000895")]
		[Address(RVA = "0x10ED438", Offset = "0x10ED438", VA = "0x10ED438")]
		public RESULT getPolygonNumVertices(int index, out int numvertices)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000896")]
		[Address(RVA = "0x10ED440", Offset = "0x10ED440", VA = "0x10ED440")]
		public RESULT setPolygonVertex(int index, int vertexindex, ref VECTOR vertex)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000897")]
		[Address(RVA = "0x10ED448", Offset = "0x10ED448", VA = "0x10ED448")]
		public RESULT getPolygonVertex(int index, int vertexindex, out VECTOR vertex)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000898")]
		[Address(RVA = "0x10ED450", Offset = "0x10ED450", VA = "0x10ED450")]
		public RESULT setPolygonAttributes(int index, float directocclusion, float reverbocclusion, bool doublesided)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000899")]
		[Address(RVA = "0x10ED45C", Offset = "0x10ED45C", VA = "0x10ED45C")]
		public RESULT getPolygonAttributes(int index, out float directocclusion, out float reverbocclusion, out bool doublesided)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600089A")]
		[Address(RVA = "0x10ED464", Offset = "0x10ED464", VA = "0x10ED464")]
		public RESULT setActive(bool active)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600089B")]
		[Address(RVA = "0x10ED470", Offset = "0x10ED470", VA = "0x10ED470")]
		public RESULT getActive(out bool active)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600089C")]
		[Address(RVA = "0x10ED478", Offset = "0x10ED478", VA = "0x10ED478")]
		public RESULT setRotation(ref VECTOR forward, ref VECTOR up)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600089D")]
		[Address(RVA = "0x10ED480", Offset = "0x10ED480", VA = "0x10ED480")]
		public RESULT getRotation(out VECTOR forward, out VECTOR up)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600089E")]
		[Address(RVA = "0x10ED488", Offset = "0x10ED488", VA = "0x10ED488")]
		public RESULT setPosition(ref VECTOR position)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600089F")]
		[Address(RVA = "0x10ED490", Offset = "0x10ED490", VA = "0x10ED490")]
		public RESULT getPosition(out VECTOR position)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60008A0")]
		[Address(RVA = "0x10ED498", Offset = "0x10ED498", VA = "0x10ED498")]
		public RESULT setScale(ref VECTOR scale)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60008A1")]
		[Address(RVA = "0x10ED4A0", Offset = "0x10ED4A0", VA = "0x10ED4A0")]
		public RESULT getScale(out VECTOR scale)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60008A2")]
		[Address(RVA = "0x10ED4A8", Offset = "0x10ED4A8", VA = "0x10ED4A8")]
		public RESULT save(IntPtr data, out int datasize)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60008A3")]
		[Address(RVA = "0x10ED4B0", Offset = "0x10ED4B0", VA = "0x10ED4B0")]
		public RESULT setUserData(IntPtr userdata)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60008A4")]
		[Address(RVA = "0x10ED4B8", Offset = "0x10ED4B8", VA = "0x10ED4B8")]
		public RESULT getUserData(out IntPtr userdata)
		{
			return default(RESULT);
		}

		[PreserveSig]
		[Token(Token = "0x60008A5")]
		[Address(RVA = "0x17EF720", Offset = "0x17EF720", VA = "0x17EF720")]
		private static extern RESULT FMOD5_Geometry_Release(IntPtr geometry);

		[PreserveSig]
		[Token(Token = "0x60008A6")]
		[Address(RVA = "0x17EF7AC", Offset = "0x17EF7AC", VA = "0x17EF7AC")]
		private static extern RESULT FMOD5_Geometry_AddPolygon(IntPtr geometry, float directocclusion, float reverbocclusion, bool doublesided, int numvertices, VECTOR[] vertices, out int polygonindex);

		[PreserveSig]
		[Token(Token = "0x60008A7")]
		[Address(RVA = "0x17EF884", Offset = "0x17EF884", VA = "0x17EF884")]
		private static extern RESULT FMOD5_Geometry_GetNumPolygons(IntPtr geometry, out int numpolygons);

		[PreserveSig]
		[Token(Token = "0x60008A8")]
		[Address(RVA = "0x17EF91C", Offset = "0x17EF91C", VA = "0x17EF91C")]
		private static extern RESULT FMOD5_Geometry_GetMaxPolygons(IntPtr geometry, out int maxpolygons, out int maxvertices);

		[PreserveSig]
		[Token(Token = "0x60008A9")]
		[Address(RVA = "0x17EF9BC", Offset = "0x17EF9BC", VA = "0x17EF9BC")]
		private static extern RESULT FMOD5_Geometry_GetPolygonNumVertices(IntPtr geometry, int index, out int numvertices);

		[PreserveSig]
		[Token(Token = "0x60008AA")]
		[Address(RVA = "0x17EFA5C", Offset = "0x17EFA5C", VA = "0x17EFA5C")]
		private static extern RESULT FMOD5_Geometry_SetPolygonVertex(IntPtr geometry, int index, int vertexindex, ref VECTOR vertex);

		[PreserveSig]
		[Token(Token = "0x60008AB")]
		[Address(RVA = "0x17EFB0C", Offset = "0x17EFB0C", VA = "0x17EFB0C")]
		private static extern RESULT FMOD5_Geometry_GetPolygonVertex(IntPtr geometry, int index, int vertexindex, out VECTOR vertex);

		[PreserveSig]
		[Token(Token = "0x60008AC")]
		[Address(RVA = "0x17EFBC0", Offset = "0x17EFBC0", VA = "0x17EFBC0")]
		private static extern RESULT FMOD5_Geometry_SetPolygonAttributes(IntPtr geometry, int index, float directocclusion, float reverbocclusion, bool doublesided);

		[PreserveSig]
		[Token(Token = "0x60008AD")]
		[Address(RVA = "0x17EFC78", Offset = "0x17EFC78", VA = "0x17EFC78")]
		private static extern RESULT FMOD5_Geometry_GetPolygonAttributes(IntPtr geometry, int index, out float directocclusion, out float reverbocclusion, out bool doublesided);

		[PreserveSig]
		[Token(Token = "0x60008AE")]
		[Address(RVA = "0x17EFD48", Offset = "0x17EFD48", VA = "0x17EFD48")]
		private static extern RESULT FMOD5_Geometry_SetActive(IntPtr geometry, bool active);

		[PreserveSig]
		[Token(Token = "0x60008AF")]
		[Address(RVA = "0x17EFDE0", Offset = "0x17EFDE0", VA = "0x17EFDE0")]
		private static extern RESULT FMOD5_Geometry_GetActive(IntPtr geometry, out bool active);

		[PreserveSig]
		[Token(Token = "0x60008B0")]
		[Address(RVA = "0x17EFE8C", Offset = "0x17EFE8C", VA = "0x17EFE8C")]
		private static extern RESULT FMOD5_Geometry_SetRotation(IntPtr geometry, ref VECTOR forward, ref VECTOR up);

		[PreserveSig]
		[Token(Token = "0x60008B1")]
		[Address(RVA = "0x17EFF2C", Offset = "0x17EFF2C", VA = "0x17EFF2C")]
		private static extern RESULT FMOD5_Geometry_GetRotation(IntPtr geometry, out VECTOR forward, out VECTOR up);

		[PreserveSig]
		[Token(Token = "0x60008B2")]
		[Address(RVA = "0x17EFFCC", Offset = "0x17EFFCC", VA = "0x17EFFCC")]
		private static extern RESULT FMOD5_Geometry_SetPosition(IntPtr geometry, ref VECTOR position);

		[PreserveSig]
		[Token(Token = "0x60008B3")]
		[Address(RVA = "0x17F0064", Offset = "0x17F0064", VA = "0x17F0064")]
		private static extern RESULT FMOD5_Geometry_GetPosition(IntPtr geometry, out VECTOR position);

		[PreserveSig]
		[Token(Token = "0x60008B4")]
		[Address(RVA = "0x17F00FC", Offset = "0x17F00FC", VA = "0x17F00FC")]
		private static extern RESULT FMOD5_Geometry_SetScale(IntPtr geometry, ref VECTOR scale);

		[PreserveSig]
		[Token(Token = "0x60008B5")]
		[Address(RVA = "0x17F0194", Offset = "0x17F0194", VA = "0x17F0194")]
		private static extern RESULT FMOD5_Geometry_GetScale(IntPtr geometry, out VECTOR scale);

		[PreserveSig]
		[Token(Token = "0x60008B6")]
		[Address(RVA = "0x17F022C", Offset = "0x17F022C", VA = "0x17F022C")]
		private static extern RESULT FMOD5_Geometry_Save(IntPtr geometry, IntPtr data, out int datasize);

		[PreserveSig]
		[Token(Token = "0x60008B7")]
		[Address(RVA = "0x17F02CC", Offset = "0x17F02CC", VA = "0x17F02CC")]
		private static extern RESULT FMOD5_Geometry_SetUserData(IntPtr geometry, IntPtr userdata);

		[PreserveSig]
		[Token(Token = "0x60008B8")]
		[Address(RVA = "0x17F0364", Offset = "0x17F0364", VA = "0x17F0364")]
		private static extern RESULT FMOD5_Geometry_GetUserData(IntPtr geometry, out IntPtr userdata);

		[Token(Token = "0x60008B9")]
		[Address(RVA = "0x10ED4C0", Offset = "0x10ED4C0", VA = "0x10ED4C0")]
		public bool hasHandle()
		{
			return default(bool);
		}

		[Token(Token = "0x60008BA")]
		[Address(RVA = "0x10ED4C8", Offset = "0x10ED4C8", VA = "0x10ED4C8")]
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
		[Address(RVA = "0x10ED584", Offset = "0x10ED584", VA = "0x10ED584")]
		public RESULT release()
		{
			return default(RESULT);
		}

		[Token(Token = "0x60008BC")]
		[Address(RVA = "0x10ED58C", Offset = "0x10ED58C", VA = "0x10ED58C")]
		public RESULT set3DAttributes(ref VECTOR position, float mindistance, float maxdistance)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60008BD")]
		[Address(RVA = "0x10ED594", Offset = "0x10ED594", VA = "0x10ED594")]
		public RESULT get3DAttributes(ref VECTOR position, ref float mindistance, ref float maxdistance)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60008BE")]
		[Address(RVA = "0x10ED59C", Offset = "0x10ED59C", VA = "0x10ED59C")]
		public RESULT setProperties(ref REVERB_PROPERTIES properties)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60008BF")]
		[Address(RVA = "0x10ED5A4", Offset = "0x10ED5A4", VA = "0x10ED5A4")]
		public RESULT getProperties(ref REVERB_PROPERTIES properties)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60008C0")]
		[Address(RVA = "0x10ED5AC", Offset = "0x10ED5AC", VA = "0x10ED5AC")]
		public RESULT setActive(bool active)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60008C1")]
		[Address(RVA = "0x10ED5B8", Offset = "0x10ED5B8", VA = "0x10ED5B8")]
		public RESULT getActive(out bool active)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60008C2")]
		[Address(RVA = "0x10ED5C0", Offset = "0x10ED5C0", VA = "0x10ED5C0")]
		public RESULT setUserData(IntPtr userdata)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60008C3")]
		[Address(RVA = "0x10ED5C8", Offset = "0x10ED5C8", VA = "0x10ED5C8")]
		public RESULT getUserData(out IntPtr userdata)
		{
			return default(RESULT);
		}

		[PreserveSig]
		[Token(Token = "0x60008C4")]
		[Address(RVA = "0x17F14A0", Offset = "0x17F14A0", VA = "0x17F14A0")]
		private static extern RESULT FMOD5_Reverb3D_Release(IntPtr reverb3d);

		[PreserveSig]
		[Token(Token = "0x60008C5")]
		[Address(RVA = "0x17F1528", Offset = "0x17F1528", VA = "0x17F1528")]
		private static extern RESULT FMOD5_Reverb3D_Set3DAttributes(IntPtr reverb3d, ref VECTOR position, float mindistance, float maxdistance);

		[PreserveSig]
		[Token(Token = "0x60008C6")]
		[Address(RVA = "0x17F15D8", Offset = "0x17F15D8", VA = "0x17F15D8")]
		private static extern RESULT FMOD5_Reverb3D_Get3DAttributes(IntPtr reverb3d, ref VECTOR position, ref float mindistance, ref float maxdistance);

		[PreserveSig]
		[Token(Token = "0x60008C7")]
		[Address(RVA = "0x17F1688", Offset = "0x17F1688", VA = "0x17F1688")]
		private static extern RESULT FMOD5_Reverb3D_SetProperties(IntPtr reverb3d, ref REVERB_PROPERTIES properties);

		[PreserveSig]
		[Token(Token = "0x60008C8")]
		[Address(RVA = "0x17F1720", Offset = "0x17F1720", VA = "0x17F1720")]
		private static extern RESULT FMOD5_Reverb3D_GetProperties(IntPtr reverb3d, ref REVERB_PROPERTIES properties);

		[PreserveSig]
		[Token(Token = "0x60008C9")]
		[Address(RVA = "0x17F17BC", Offset = "0x17F17BC", VA = "0x17F17BC")]
		private static extern RESULT FMOD5_Reverb3D_SetActive(IntPtr reverb3d, bool active);

		[PreserveSig]
		[Token(Token = "0x60008CA")]
		[Address(RVA = "0x17F1854", Offset = "0x17F1854", VA = "0x17F1854")]
		private static extern RESULT FMOD5_Reverb3D_GetActive(IntPtr reverb3d, out bool active);

		[PreserveSig]
		[Token(Token = "0x60008CB")]
		[Address(RVA = "0x17F1900", Offset = "0x17F1900", VA = "0x17F1900")]
		private static extern RESULT FMOD5_Reverb3D_SetUserData(IntPtr reverb3d, IntPtr userdata);

		[PreserveSig]
		[Token(Token = "0x60008CC")]
		[Address(RVA = "0x17F1998", Offset = "0x17F1998", VA = "0x17F1998")]
		private static extern RESULT FMOD5_Reverb3D_GetUserData(IntPtr reverb3d, out IntPtr userdata);

		[Token(Token = "0x60008CD")]
		[Address(RVA = "0x10ED5D0", Offset = "0x10ED5D0", VA = "0x10ED5D0")]
		public bool hasHandle()
		{
			return default(bool);
		}

		[Token(Token = "0x60008CE")]
		[Address(RVA = "0x10ED5D8", Offset = "0x10ED5D8", VA = "0x10ED5D8")]
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
		[Address(RVA = "0x17F6158", Offset = "0x17F6158", VA = "0x17F6158")]
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
			[Address(RVA = "0x17F5FB8", Offset = "0x17F5FB8", VA = "0x17F5FB8")]
			public bool InUse()
			{
				return default(bool);
			}

			[Token(Token = "0x6000D3F")]
			[Address(RVA = "0x17F5F34", Offset = "0x17F5F34", VA = "0x17F5F34")]
			public void SetInUse()
			{
			}

			[Token(Token = "0x6000D40")]
			[Address(RVA = "0x17F5FC0", Offset = "0x17F5FC0", VA = "0x17F5FC0")]
			private int roundUpPowerTwo(int number)
			{
				return default(int);
			}

			[Token(Token = "0x6000D41")]
			[Address(RVA = "0x17F3D58", Offset = "0x17F3D58", VA = "0x17F3D58")]
			public byte[] byteFromStringUTF8(string s)
			{
				return null;
			}

			[Token(Token = "0x6000D42")]
			[Address(RVA = "0x17F5FD8", Offset = "0x17F5FD8", VA = "0x17F5FD8")]
			public IntPtr intptrFromStringUTF8(string s)
			{
				return default(IntPtr);
			}

			[Token(Token = "0x6000D43")]
			[Address(RVA = "0x17F3758", Offset = "0x17F3758", VA = "0x17F3758")]
			public string stringFromNative(IntPtr nativePtr)
			{
				return null;
			}

			[Token(Token = "0x6000D44")]
			[Address(RVA = "0x17F6064", Offset = "0x17F6064", VA = "0x17F6064", Slot = "4")]
			public void Dispose()
			{
			}

			[Token(Token = "0x6000D45")]
			[Address(RVA = "0x17F5E9C", Offset = "0x17F5E9C", VA = "0x17F5E9C")]
			public ThreadSafeEncoding()
			{
			}
		}

		[Token(Token = "0x4000615")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static List<ThreadSafeEncoding> encoders;

		[Token(Token = "0x60008D0")]
		[Address(RVA = "0x17F34E8", Offset = "0x17F34E8", VA = "0x17F34E8")]
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
		[Address(RVA = "0x1802EC4", Offset = "0x1802EC4", VA = "0x1802EC4")]
		public static RESULT setThreadAffinity(ref THREADAFFINITY affinity)
		{
			return default(RESULT);
		}

		[PreserveSig]
		[Token(Token = "0x60008D3")]
		[Address(RVA = "0x1802EC8", Offset = "0x1802EC8", VA = "0x1802EC8")]
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
			[Address(RVA = "0x10F0364", Offset = "0x10F0364", VA = "0x10F0364")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000965")]
		[Address(RVA = "0x10F036C", Offset = "0x10F036C", VA = "0x10F036C")]
		public void GetSpecturmPreAloc(ref float[][] buffer)
		{
		}

		[Token(Token = "0x6000966")]
		[Address(RVA = "0x10F0374", Offset = "0x10F0374", VA = "0x10F0374")]
		public void getSpectrum(ref float[][] buffer)
		{
		}

		[Token(Token = "0x6000967")]
		[Address(RVA = "0x10F037C", Offset = "0x10F037C", VA = "0x10F037C")]
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
		[Address(RVA = "0x18159B8", Offset = "0x18159B8", VA = "0x18159B8")]
		public static string String(RESULT errcode)
		{
			return null;
		}

		[Token(Token = "0x6000969")]
		[Address(RVA = "0x1815A1C", Offset = "0x1815A1C", VA = "0x1815A1C")]
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
		[Address(RVA = "0x17FDCD8", Offset = "0x17FDCD8", VA = "0x17FDCD8")]
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
			[Address(RVA = "0x10EE224", Offset = "0x10EE224", VA = "0x10EE224")]
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
		[Address(RVA = "0x155E384", Offset = "0x155E384", VA = "0x155E384")]
		public int intValue()
		{
			return default(int);
		}

		[Token(Token = "0x6000971")]
		[Address(RVA = "0x155E39C", Offset = "0x155E39C", VA = "0x155E39C")]
		public bool boolValue()
		{
			return default(bool);
		}

		[Token(Token = "0x6000972")]
		[Address(RVA = "0x155E3C0", Offset = "0x155E3C0", VA = "0x155E3C0")]
		public float floatValue()
		{
			return default(float);
		}

		[Token(Token = "0x6000973")]
		[Address(RVA = "0x155E3DC", Offset = "0x155E3DC", VA = "0x155E3DC")]
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
		[Address(RVA = "0x24B1950", Offset = "0x24B1950", VA = "0x24B1950")]
		public static RESULT parseID(string idString, out Guid id)
		{
			return default(RESULT);
		}

		[PreserveSig]
		[Token(Token = "0x6000985")]
		[Address(RVA = "0x24B1A98", Offset = "0x24B1A98", VA = "0x24B1A98")]
		private static extern RESULT FMOD_Studio_ParseID(byte[] idString, out Guid id);
	}
	[Token(Token = "0x200015E")]
	public struct System
	{
		[Token(Token = "0x40008A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public IntPtr handle;

		[Token(Token = "0x6000986")]
		[Address(RVA = "0x17FE0AC", Offset = "0x17FE0AC", VA = "0x17FE0AC")]
		public static RESULT create(out System system)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000987")]
		[Address(RVA = "0x10EE248", Offset = "0x10EE248", VA = "0x10EE248")]
		public RESULT setAdvancedSettings(ADVANCEDSETTINGS settings)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000988")]
		[Address(RVA = "0x10EE274", Offset = "0x10EE274", VA = "0x10EE274")]
		public RESULT setAdvancedSettings(ADVANCEDSETTINGS settings, string encryptionKey)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000989")]
		[Address(RVA = "0x10EE2A0", Offset = "0x10EE2A0", VA = "0x10EE2A0")]
		public RESULT getAdvancedSettings(out ADVANCEDSETTINGS settings)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600098A")]
		[Address(RVA = "0x10EE2A8", Offset = "0x10EE2A8", VA = "0x10EE2A8")]
		public RESULT initialize(int maxchannels, INITFLAGS studioflags, FMOD.INITFLAGS flags, IntPtr extradriverdata)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600098B")]
		[Address(RVA = "0x10EE2B0", Offset = "0x10EE2B0", VA = "0x10EE2B0")]
		public RESULT release()
		{
			return default(RESULT);
		}

		[Token(Token = "0x600098C")]
		[Address(RVA = "0x10EE2B8", Offset = "0x10EE2B8", VA = "0x10EE2B8")]
		public RESULT update()
		{
			return default(RESULT);
		}

		[Token(Token = "0x600098D")]
		[Address(RVA = "0x10EE2C0", Offset = "0x10EE2C0", VA = "0x10EE2C0")]
		public RESULT getCoreSystem(out FMOD.System coresystem)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600098E")]
		[Address(RVA = "0x10EE2C8", Offset = "0x10EE2C8", VA = "0x10EE2C8")]
		public RESULT getEvent(string path, out EventDescription _event)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600098F")]
		[Address(RVA = "0x10EE2D0", Offset = "0x10EE2D0", VA = "0x10EE2D0")]
		public RESULT getBus(string path, out Bus bus)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000990")]
		[Address(RVA = "0x10EE2D8", Offset = "0x10EE2D8", VA = "0x10EE2D8")]
		public RESULT getVCA(string path, out VCA vca)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000991")]
		[Address(RVA = "0x10EE2E0", Offset = "0x10EE2E0", VA = "0x10EE2E0")]
		public RESULT getBank(string path, out Bank bank)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000992")]
		[Address(RVA = "0x10EE2E8", Offset = "0x10EE2E8", VA = "0x10EE2E8")]
		public RESULT getEventByID(Guid id, out EventDescription _event)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000993")]
		[Address(RVA = "0x10EE314", Offset = "0x10EE314", VA = "0x10EE314")]
		public RESULT getBusByID(Guid id, out Bus bus)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000994")]
		[Address(RVA = "0x10EE340", Offset = "0x10EE340", VA = "0x10EE340")]
		public RESULT getVCAByID(Guid id, out VCA vca)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000995")]
		[Address(RVA = "0x10EE36C", Offset = "0x10EE36C", VA = "0x10EE36C")]
		public RESULT getBankByID(Guid id, out Bank bank)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000996")]
		[Address(RVA = "0x10EE398", Offset = "0x10EE398", VA = "0x10EE398")]
		public RESULT getSoundInfo(string key, out SOUND_INFO info)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000997")]
		[Address(RVA = "0x10EE3A0", Offset = "0x10EE3A0", VA = "0x10EE3A0")]
		public RESULT getParameterDescriptionByName(string name, out PARAMETER_DESCRIPTION parameter)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000998")]
		[Address(RVA = "0x10EE3A8", Offset = "0x10EE3A8", VA = "0x10EE3A8")]
		public RESULT getParameterDescriptionByID(PARAMETER_ID id, out PARAMETER_DESCRIPTION parameter)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000999")]
		[Address(RVA = "0x10EE3B0", Offset = "0x10EE3B0", VA = "0x10EE3B0")]
		public RESULT getParameterByID(PARAMETER_ID id, out float value)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600099A")]
		[Address(RVA = "0x10EE3D8", Offset = "0x10EE3D8", VA = "0x10EE3D8")]
		public RESULT getParameterByID(PARAMETER_ID id, out float value, out float finalvalue)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600099B")]
		[Address(RVA = "0x10EE3E0", Offset = "0x10EE3E0", VA = "0x10EE3E0")]
		public RESULT setParameterByID(PARAMETER_ID id, float value, bool ignoreseekspeed = false)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600099C")]
		[Address(RVA = "0x10EE3EC", Offset = "0x10EE3EC", VA = "0x10EE3EC")]
		public RESULT setParametersByIDs(PARAMETER_ID[] ids, float[] values, int count, bool ignoreseekspeed = false)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600099D")]
		[Address(RVA = "0x10EE3F8", Offset = "0x10EE3F8", VA = "0x10EE3F8")]
		public RESULT getParameterByName(string name, out float value)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600099E")]
		[Address(RVA = "0x10EE420", Offset = "0x10EE420", VA = "0x10EE420")]
		public RESULT getParameterByName(IntPtr name, out float value)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600099F")]
		[Address(RVA = "0x10EE448", Offset = "0x10EE448", VA = "0x10EE448")]
		public RESULT getParameterByName(string name, out float value, out float finalvalue)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60009A0")]
		[Address(RVA = "0x10EE450", Offset = "0x10EE450", VA = "0x10EE450")]
		public RESULT getParameterByName(IntPtr name, out float value, out float finalvalue)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60009A1")]
		[Address(RVA = "0x10EE458", Offset = "0x10EE458", VA = "0x10EE458")]
		public RESULT setParameterByName(string name, float value, bool ignoreseekspeed = false)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60009A2")]
		[Address(RVA = "0x10EE464", Offset = "0x10EE464", VA = "0x10EE464")]
		public RESULT setParameterByName(IntPtr name, float value, bool ignoreseekspeed = false)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60009A3")]
		[Address(RVA = "0x10EE470", Offset = "0x10EE470", VA = "0x10EE470")]
		public RESULT lookupID(string path, out Guid id)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60009A4")]
		[Address(RVA = "0x10EE478", Offset = "0x10EE478", VA = "0x10EE478")]
		public RESULT lookupPath(Guid id, out string path)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60009A5")]
		[Address(RVA = "0x10EE480", Offset = "0x10EE480", VA = "0x10EE480")]
		public RESULT getNumListeners(out int numlisteners)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60009A6")]
		[Address(RVA = "0x10EE488", Offset = "0x10EE488", VA = "0x10EE488")]
		public RESULT setNumListeners(int numlisteners)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60009A7")]
		[Address(RVA = "0x10EE490", Offset = "0x10EE490", VA = "0x10EE490")]
		public RESULT getListenerAttributes(int listener, out ATTRIBUTES_3D attributes)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60009A8")]
		[Address(RVA = "0x10EE498", Offset = "0x10EE498", VA = "0x10EE498")]
		public RESULT setListenerAttributes(int listener, ATTRIBUTES_3D attributes)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60009A9")]
		[Address(RVA = "0x10EE4CC", Offset = "0x10EE4CC", VA = "0x10EE4CC")]
		public RESULT getListenerWeight(int listener, out float weight)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60009AA")]
		[Address(RVA = "0x10EE4D4", Offset = "0x10EE4D4", VA = "0x10EE4D4")]
		public RESULT setListenerWeight(int listener, float weight)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60009AB")]
		[Address(RVA = "0x10EE4DC", Offset = "0x10EE4DC", VA = "0x10EE4DC")]
		public RESULT loadBankFile(string filename, LOAD_BANK_FLAGS flags, out Bank bank)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60009AC")]
		[Address(RVA = "0x10EE4E4", Offset = "0x10EE4E4", VA = "0x10EE4E4")]
		public RESULT loadBankMemory(byte[] buffer, LOAD_BANK_FLAGS flags, out Bank bank)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60009AD")]
		[Address(RVA = "0x10EE4EC", Offset = "0x10EE4EC", VA = "0x10EE4EC")]
		public RESULT loadBankCustom(BANK_INFO info, LOAD_BANK_FLAGS flags, out Bank bank)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60009AE")]
		[Address(RVA = "0x10EE528", Offset = "0x10EE528", VA = "0x10EE528")]
		public RESULT unloadAll()
		{
			return default(RESULT);
		}

		[Token(Token = "0x60009AF")]
		[Address(RVA = "0x10EE530", Offset = "0x10EE530", VA = "0x10EE530")]
		public RESULT flushCommands()
		{
			return default(RESULT);
		}

		[Token(Token = "0x60009B0")]
		[Address(RVA = "0x10EE538", Offset = "0x10EE538", VA = "0x10EE538")]
		public RESULT flushSampleLoading()
		{
			return default(RESULT);
		}

		[Token(Token = "0x60009B1")]
		[Address(RVA = "0x10EE540", Offset = "0x10EE540", VA = "0x10EE540")]
		public RESULT startCommandCapture(string filename, COMMANDCAPTURE_FLAGS flags)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60009B2")]
		[Address(RVA = "0x10EE548", Offset = "0x10EE548", VA = "0x10EE548")]
		public RESULT stopCommandCapture()
		{
			return default(RESULT);
		}

		[Token(Token = "0x60009B3")]
		[Address(RVA = "0x10EE550", Offset = "0x10EE550", VA = "0x10EE550")]
		public RESULT loadCommandReplay(string filename, COMMANDREPLAY_FLAGS flags, out CommandReplay replay)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60009B4")]
		[Address(RVA = "0x10EE558", Offset = "0x10EE558", VA = "0x10EE558")]
		public RESULT getBankCount(out int count)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60009B5")]
		[Address(RVA = "0x10EE560", Offset = "0x10EE560", VA = "0x10EE560")]
		public RESULT getBankList(out Bank[] array)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60009B6")]
		[Address(RVA = "0x10EE568", Offset = "0x10EE568", VA = "0x10EE568")]
		public RESULT getParameterDescriptionCount(out int count)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60009B7")]
		[Address(RVA = "0x10EE570", Offset = "0x10EE570", VA = "0x10EE570")]
		public RESULT getParameterDescriptionList(out PARAMETER_DESCRIPTION[] array)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60009B8")]
		[Address(RVA = "0x10EE578", Offset = "0x10EE578", VA = "0x10EE578")]
		public RESULT getCPUUsage(out CPU_USAGE usage)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60009B9")]
		[Address(RVA = "0x10EE580", Offset = "0x10EE580", VA = "0x10EE580")]
		public RESULT getBufferUsage(out BUFFER_USAGE usage)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60009BA")]
		[Address(RVA = "0x10EE588", Offset = "0x10EE588", VA = "0x10EE588")]
		public RESULT resetBufferUsage()
		{
			return default(RESULT);
		}

		[Token(Token = "0x60009BB")]
		[Address(RVA = "0x10EE590", Offset = "0x10EE590", VA = "0x10EE590")]
		public RESULT setCallback(SYSTEM_CALLBACK callback, SYSTEM_CALLBACK_TYPE callbackmask = SYSTEM_CALLBACK_TYPE.ALL)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60009BC")]
		[Address(RVA = "0x10EE598", Offset = "0x10EE598", VA = "0x10EE598")]
		public RESULT getUserData(out IntPtr userdata)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60009BD")]
		[Address(RVA = "0x10EE5A0", Offset = "0x10EE5A0", VA = "0x10EE5A0")]
		public RESULT setUserData(IntPtr userdata)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60009BE")]
		[Address(RVA = "0x10EE5A8", Offset = "0x10EE5A8", VA = "0x10EE5A8")]
		public RESULT getMemoryUsage(out MEMORY_USAGE memoryusage)
		{
			return default(RESULT);
		}

		[PreserveSig]
		[Token(Token = "0x60009BF")]
		[Address(RVA = "0x17FE0B8", Offset = "0x17FE0B8", VA = "0x17FE0B8")]
		private static extern RESULT FMOD_Studio_System_Create(out IntPtr system, uint headerversion);

		[PreserveSig]
		[Token(Token = "0x60009C0")]
		[Address(RVA = "0x1801D74", Offset = "0x1801D74", VA = "0x1801D74")]
		private static extern bool FMOD_Studio_System_IsValid(IntPtr system);

		[PreserveSig]
		[Token(Token = "0x60009C1")]
		[Address(RVA = "0x17FE20C", Offset = "0x17FE20C", VA = "0x17FE20C")]
		private static extern RESULT FMOD_Studio_System_SetAdvancedSettings(IntPtr system, ref ADVANCEDSETTINGS settings);

		[PreserveSig]
		[Token(Token = "0x60009C2")]
		[Address(RVA = "0x17FE4CC", Offset = "0x17FE4CC", VA = "0x17FE4CC")]
		private static extern RESULT FMOD_Studio_System_GetAdvancedSettings(IntPtr system, out ADVANCEDSETTINGS settings);

		[PreserveSig]
		[Token(Token = "0x60009C3")]
		[Address(RVA = "0x17FE564", Offset = "0x17FE564", VA = "0x17FE564")]
		private static extern RESULT FMOD_Studio_System_Initialize(IntPtr system, int maxchannels, INITFLAGS studioflags, FMOD.INITFLAGS flags, IntPtr extradriverdata);

		[PreserveSig]
		[Token(Token = "0x60009C4")]
		[Address(RVA = "0x17FE61C", Offset = "0x17FE61C", VA = "0x17FE61C")]
		private static extern RESULT FMOD_Studio_System_Release(IntPtr system);

		[PreserveSig]
		[Token(Token = "0x60009C5")]
		[Address(RVA = "0x17FE6A4", Offset = "0x17FE6A4", VA = "0x17FE6A4")]
		private static extern RESULT FMOD_Studio_System_Update(IntPtr system);

		[PreserveSig]
		[Token(Token = "0x60009C6")]
		[Address(RVA = "0x17FE72C", Offset = "0x17FE72C", VA = "0x17FE72C")]
		private static extern RESULT FMOD_Studio_System_GetCoreSystem(IntPtr system, out IntPtr coresystem);

		[PreserveSig]
		[Token(Token = "0x60009C7")]
		[Address(RVA = "0x17FE90C", Offset = "0x17FE90C", VA = "0x17FE90C")]
		private static extern RESULT FMOD_Studio_System_GetEvent(IntPtr system, byte[] path, out IntPtr _event);

		[PreserveSig]
		[Token(Token = "0x60009C8")]
		[Address(RVA = "0x17FEAFC", Offset = "0x17FEAFC", VA = "0x17FEAFC")]
		private static extern RESULT FMOD_Studio_System_GetBus(IntPtr system, byte[] path, out IntPtr bus);

		[PreserveSig]
		[Token(Token = "0x60009C9")]
		[Address(RVA = "0x17FECEC", Offset = "0x17FECEC", VA = "0x17FECEC")]
		private static extern RESULT FMOD_Studio_System_GetVCA(IntPtr system, byte[] path, out IntPtr vca);

		[PreserveSig]
		[Token(Token = "0x60009CA")]
		[Address(RVA = "0x17FEEDC", Offset = "0x17FEEDC", VA = "0x17FEEDC")]
		private static extern RESULT FMOD_Studio_System_GetBank(IntPtr system, byte[] path, out IntPtr bank);

		[PreserveSig]
		[Token(Token = "0x60009CB")]
		[Address(RVA = "0x17FEFA8", Offset = "0x17FEFA8", VA = "0x17FEFA8")]
		private static extern RESULT FMOD_Studio_System_GetEventByID(IntPtr system, ref Guid id, out IntPtr _event);

		[PreserveSig]
		[Token(Token = "0x60009CC")]
		[Address(RVA = "0x17FF06C", Offset = "0x17FF06C", VA = "0x17FF06C")]
		private static extern RESULT FMOD_Studio_System_GetBusByID(IntPtr system, ref Guid id, out IntPtr bus);

		[PreserveSig]
		[Token(Token = "0x60009CD")]
		[Address(RVA = "0x17FF130", Offset = "0x17FF130", VA = "0x17FF130")]
		private static extern RESULT FMOD_Studio_System_GetVCAByID(IntPtr system, ref Guid id, out IntPtr vca);

		[PreserveSig]
		[Token(Token = "0x60009CE")]
		[Address(RVA = "0x17FF1F4", Offset = "0x17FF1F4", VA = "0x17FF1F4")]
		private static extern RESULT FMOD_Studio_System_GetBankByID(IntPtr system, ref Guid id, out IntPtr bank);

		[PreserveSig]
		[Token(Token = "0x60009CF")]
		[Address(RVA = "0x17FF3DC", Offset = "0x17FF3DC", VA = "0x17FF3DC")]
		private static extern RESULT FMOD_Studio_System_GetSoundInfo(IntPtr system, byte[] key, out SOUND_INFO info);

		[PreserveSig]
		[Token(Token = "0x60009D0")]
		[Address(RVA = "0x17FF670", Offset = "0x17FF670", VA = "0x17FF670")]
		private static extern RESULT FMOD_Studio_System_GetParameterDescriptionByName(IntPtr system, byte[] name, out PARAMETER_DESCRIPTION parameter);

		[PreserveSig]
		[Token(Token = "0x60009D1")]
		[Address(RVA = "0x17FF718", Offset = "0x17FF718", VA = "0x17FF718")]
		private static extern RESULT FMOD_Studio_System_GetParameterDescriptionByID(IntPtr system, ulong id, out PARAMETER_DESCRIPTION parameter);

		[PreserveSig]
		[Token(Token = "0x60009D2")]
		[Address(RVA = "0x17FF7E0", Offset = "0x17FF7E0", VA = "0x17FF7E0")]
		private static extern RESULT FMOD_Studio_System_GetParameterByID(IntPtr system, ulong id, out float value, out float finalvalue);

		[PreserveSig]
		[Token(Token = "0x60009D3")]
		[Address(RVA = "0x17FF894", Offset = "0x17FF894", VA = "0x17FF894")]
		private static extern RESULT FMOD_Studio_System_SetParameterByID(IntPtr system, ulong id, float value, bool ignoreseekspeed);

		[PreserveSig]
		[Token(Token = "0x60009D4")]
		[Address(RVA = "0x17FF948", Offset = "0x17FF948", VA = "0x17FF948")]
		private static extern RESULT FMOD_Studio_System_SetParametersByIDs(IntPtr system, PARAMETER_ID[] ids, float[] values, int count, bool ignoreseekspeed);

		[PreserveSig]
		[Token(Token = "0x60009D5")]
		[Address(RVA = "0x17FFBBC", Offset = "0x17FFBBC", VA = "0x17FFBBC")]
		private static extern RESULT FMOD_Studio_System_GetParameterByName(IntPtr system, byte[] name, out float value, out float finalvalue);

		[PreserveSig]
		[Token(Token = "0x60009D6")]
		[Address(RVA = "0x17FFC6C", Offset = "0x17FFC6C", VA = "0x17FFC6C")]
		private static extern RESULT FMOD_Studio_System_GetParameterByName(IntPtr system, IntPtr name, out float value, out float finalvalue);

		[PreserveSig]
		[Token(Token = "0x60009D7")]
		[Address(RVA = "0x17FFE74", Offset = "0x17FFE74", VA = "0x17FFE74")]
		private static extern RESULT FMOD_Studio_System_SetParameterByName(IntPtr system, byte[] name, float value, bool ignoreseekspeed);

		[PreserveSig]
		[Token(Token = "0x60009D8")]
		[Address(RVA = "0x17FFF30", Offset = "0x17FFF30", VA = "0x17FFF30")]
		private static extern RESULT FMOD_Studio_System_SetParameterByName(IntPtr system, IntPtr name, float value, bool ignoreseekspeed);

		[PreserveSig]
		[Token(Token = "0x60009D9")]
		[Address(RVA = "0x1800128", Offset = "0x1800128", VA = "0x1800128")]
		private static extern RESULT FMOD_Studio_System_LookupID(IntPtr system, byte[] path, out Guid id);

		[PreserveSig]
		[Token(Token = "0x60009DA")]
		[Address(RVA = "0x180040C", Offset = "0x180040C", VA = "0x180040C")]
		private static extern RESULT FMOD_Studio_System_LookupPath(IntPtr system, ref Guid id, IntPtr path, int size, out int retrieved);

		[PreserveSig]
		[Token(Token = "0x60009DB")]
		[Address(RVA = "0x18004C4", Offset = "0x18004C4", VA = "0x18004C4")]
		private static extern RESULT FMOD_Studio_System_GetNumListeners(IntPtr system, out int numlisteners);

		[PreserveSig]
		[Token(Token = "0x60009DC")]
		[Address(RVA = "0x180055C", Offset = "0x180055C", VA = "0x180055C")]
		private static extern RESULT FMOD_Studio_System_SetNumListeners(IntPtr system, int numlisteners);

		[PreserveSig]
		[Token(Token = "0x60009DD")]
		[Address(RVA = "0x18005F4", Offset = "0x18005F4", VA = "0x18005F4")]
		private static extern RESULT FMOD_Studio_System_GetListenerAttributes(IntPtr system, int listener, out ATTRIBUTES_3D attributes);

		[PreserveSig]
		[Token(Token = "0x60009DE")]
		[Address(RVA = "0x1800694", Offset = "0x1800694", VA = "0x1800694")]
		private static extern RESULT FMOD_Studio_System_SetListenerAttributes(IntPtr system, int listener, ref ATTRIBUTES_3D attributes);

		[PreserveSig]
		[Token(Token = "0x60009DF")]
		[Address(RVA = "0x1800734", Offset = "0x1800734", VA = "0x1800734")]
		private static extern RESULT FMOD_Studio_System_GetListenerWeight(IntPtr system, int listener, out float weight);

		[PreserveSig]
		[Token(Token = "0x60009E0")]
		[Address(RVA = "0x18007D4", Offset = "0x18007D4", VA = "0x18007D4")]
		private static extern RESULT FMOD_Studio_System_SetListenerWeight(IntPtr system, int listener, float weight);

		[PreserveSig]
		[Token(Token = "0x60009E1")]
		[Address(RVA = "0x18009D4", Offset = "0x18009D4", VA = "0x18009D4")]
		private static extern RESULT FMOD_Studio_System_LoadBankFile(IntPtr system, byte[] filename, LOAD_BANK_FLAGS flags, out IntPtr bank);

		[PreserveSig]
		[Token(Token = "0x60009E2")]
		[Address(RVA = "0x1800B14", Offset = "0x1800B14", VA = "0x1800B14")]
		private static extern RESULT FMOD_Studio_System_LoadBankMemory(IntPtr system, IntPtr buffer, int length, LOAD_MEMORY_MODE mode, LOAD_BANK_FLAGS flags, out IntPtr bank);

		[PreserveSig]
		[Token(Token = "0x60009E3")]
		[Address(RVA = "0x1800CB4", Offset = "0x1800CB4", VA = "0x1800CB4")]
		private static extern RESULT FMOD_Studio_System_LoadBankCustom(IntPtr system, ref BANK_INFO info, LOAD_BANK_FLAGS flags, out IntPtr bank);

		[PreserveSig]
		[Token(Token = "0x60009E4")]
		[Address(RVA = "0x1800DC0", Offset = "0x1800DC0", VA = "0x1800DC0")]
		private static extern RESULT FMOD_Studio_System_UnloadAll(IntPtr system);

		[PreserveSig]
		[Token(Token = "0x60009E5")]
		[Address(RVA = "0x1800E48", Offset = "0x1800E48", VA = "0x1800E48")]
		private static extern RESULT FMOD_Studio_System_FlushCommands(IntPtr system);

		[PreserveSig]
		[Token(Token = "0x60009E6")]
		[Address(RVA = "0x1800ED0", Offset = "0x1800ED0", VA = "0x1800ED0")]
		private static extern RESULT FMOD_Studio_System_FlushSampleLoading(IntPtr system);

		[PreserveSig]
		[Token(Token = "0x60009E7")]
		[Address(RVA = "0x18010A0", Offset = "0x18010A0", VA = "0x18010A0")]
		private static extern RESULT FMOD_Studio_System_StartCommandCapture(IntPtr system, byte[] filename, COMMANDCAPTURE_FLAGS flags);

		[PreserveSig]
		[Token(Token = "0x60009E8")]
		[Address(RVA = "0x1801148", Offset = "0x1801148", VA = "0x1801148")]
		private static extern RESULT FMOD_Studio_System_StopCommandCapture(IntPtr system);

		[PreserveSig]
		[Token(Token = "0x60009E9")]
		[Address(RVA = "0x1801328", Offset = "0x1801328", VA = "0x1801328")]
		private static extern RESULT FMOD_Studio_System_LoadCommandReplay(IntPtr system, byte[] filename, COMMANDREPLAY_FLAGS flags, out IntPtr replay);

		[PreserveSig]
		[Token(Token = "0x60009EA")]
		[Address(RVA = "0x18013E0", Offset = "0x18013E0", VA = "0x18013E0")]
		private static extern RESULT FMOD_Studio_System_GetBankCount(IntPtr system, out int count);

		[PreserveSig]
		[Token(Token = "0x60009EB")]
		[Address(RVA = "0x18015C0", Offset = "0x18015C0", VA = "0x18015C0")]
		private static extern RESULT FMOD_Studio_System_GetBankList(IntPtr system, IntPtr[] array, int capacity, out int count);

		[PreserveSig]
		[Token(Token = "0x60009EC")]
		[Address(RVA = "0x1801678", Offset = "0x1801678", VA = "0x1801678")]
		private static extern RESULT FMOD_Studio_System_GetParameterDescriptionCount(IntPtr system, out int count);

		[PreserveSig]
		[Token(Token = "0x60009ED")]
		[Address(RVA = "0x18017FC", Offset = "0x18017FC", VA = "0x18017FC")]
		private static extern RESULT FMOD_Studio_System_GetParameterDescriptionList(IntPtr system, [Out] PARAMETER_DESCRIPTION[] array, int capacity, out int count);

		[PreserveSig]
		[Token(Token = "0x60009EE")]
		[Address(RVA = "0x1801954", Offset = "0x1801954", VA = "0x1801954")]
		private static extern RESULT FMOD_Studio_System_GetCPUUsage(IntPtr system, out CPU_USAGE usage);

		[PreserveSig]
		[Token(Token = "0x60009EF")]
		[Address(RVA = "0x18019EC", Offset = "0x18019EC", VA = "0x18019EC")]
		private static extern RESULT FMOD_Studio_System_GetBufferUsage(IntPtr system, out BUFFER_USAGE usage);

		[PreserveSig]
		[Token(Token = "0x60009F0")]
		[Address(RVA = "0x1801A84", Offset = "0x1801A84", VA = "0x1801A84")]
		private static extern RESULT FMOD_Studio_System_ResetBufferUsage(IntPtr system);

		[PreserveSig]
		[Token(Token = "0x60009F1")]
		[Address(RVA = "0x1801B0C", Offset = "0x1801B0C", VA = "0x1801B0C")]
		private static extern RESULT FMOD_Studio_System_SetCallback(IntPtr system, SYSTEM_CALLBACK callback, SYSTEM_CALLBACK_TYPE callbackmask);

		[PreserveSig]
		[Token(Token = "0x60009F2")]
		[Address(RVA = "0x1801BB4", Offset = "0x1801BB4", VA = "0x1801BB4")]
		private static extern RESULT FMOD_Studio_System_GetUserData(IntPtr system, out IntPtr userdata);

		[PreserveSig]
		[Token(Token = "0x60009F3")]
		[Address(RVA = "0x1801C4C", Offset = "0x1801C4C", VA = "0x1801C4C")]
		private static extern RESULT FMOD_Studio_System_SetUserData(IntPtr system, IntPtr userdata);

		[PreserveSig]
		[Token(Token = "0x60009F4")]
		[Address(RVA = "0x1801CE4", Offset = "0x1801CE4", VA = "0x1801CE4")]
		private static extern RESULT FMOD_Studio_System_GetMemoryUsage(IntPtr system, out MEMORY_USAGE memoryusage);

		[Token(Token = "0x60009F5")]
		[Address(RVA = "0x10EE5B0", Offset = "0x10EE5B0", VA = "0x10EE5B0")]
		public bool hasHandle()
		{
			return default(bool);
		}

		[Token(Token = "0x60009F6")]
		[Address(RVA = "0x10EE5B8", Offset = "0x10EE5B8", VA = "0x10EE5B8")]
		public void clearHandle()
		{
		}

		[Token(Token = "0x60009F7")]
		[Address(RVA = "0x10EE5FC", Offset = "0x10EE5FC", VA = "0x10EE5FC")]
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
		[Address(RVA = "0x10EDD84", Offset = "0x10EDD84", VA = "0x10EDD84")]
		public RESULT getID(out Guid id)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60009F9")]
		[Address(RVA = "0x10EDD8C", Offset = "0x10EDD8C", VA = "0x10EDD8C")]
		public RESULT getPath(out string path)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60009FA")]
		[Address(RVA = "0x10EDD94", Offset = "0x10EDD94", VA = "0x10EDD94")]
		public RESULT getParameterDescriptionCount(out int count)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60009FB")]
		[Address(RVA = "0x10EDD9C", Offset = "0x10EDD9C", VA = "0x10EDD9C")]
		public RESULT getParameterDescriptionByIndex(int index, out PARAMETER_DESCRIPTION parameter)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60009FC")]
		[Address(RVA = "0x10EDDA4", Offset = "0x10EDDA4", VA = "0x10EDDA4")]
		public RESULT getParameterDescriptionByName(string name, out PARAMETER_DESCRIPTION parameter)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60009FD")]
		[Address(RVA = "0x10EDDAC", Offset = "0x10EDDAC", VA = "0x10EDDAC")]
		public RESULT getParameterDescriptionByName(IntPtr name, out PARAMETER_DESCRIPTION parameter)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60009FE")]
		[Address(RVA = "0x10EDDB4", Offset = "0x10EDDB4", VA = "0x10EDDB4")]
		public RESULT getParameterDescriptionByID(PARAMETER_ID id, out PARAMETER_DESCRIPTION parameter)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60009FF")]
		[Address(RVA = "0x10EDDBC", Offset = "0x10EDDBC", VA = "0x10EDDBC")]
		public RESULT getUserPropertyCount(out int count)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000A00")]
		[Address(RVA = "0x10EDDC4", Offset = "0x10EDDC4", VA = "0x10EDDC4")]
		public RESULT getUserPropertyByIndex(int index, out USER_PROPERTY property)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000A01")]
		[Address(RVA = "0x10EDDCC", Offset = "0x10EDDCC", VA = "0x10EDDCC")]
		public RESULT getUserProperty(string name, out USER_PROPERTY property)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000A02")]
		[Address(RVA = "0x10EDDD4", Offset = "0x10EDDD4", VA = "0x10EDDD4")]
		public RESULT getUserProperty(IntPtr name, out USER_PROPERTY property)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000A03")]
		[Address(RVA = "0x10EDDDC", Offset = "0x10EDDDC", VA = "0x10EDDDC")]
		public RESULT getLength(out int length)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000A04")]
		[Address(RVA = "0x10EDDE4", Offset = "0x10EDDE4", VA = "0x10EDDE4")]
		public RESULT getMinimumDistance(out float distance)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000A05")]
		[Address(RVA = "0x10EDDEC", Offset = "0x10EDDEC", VA = "0x10EDDEC")]
		public RESULT getMaximumDistance(out float distance)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000A06")]
		[Address(RVA = "0x10EDDF4", Offset = "0x10EDDF4", VA = "0x10EDDF4")]
		public RESULT getSoundSize(out float size)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000A07")]
		[Address(RVA = "0x10EDDFC", Offset = "0x10EDDFC", VA = "0x10EDDFC")]
		public RESULT isSnapshot(out bool snapshot)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000A08")]
		[Address(RVA = "0x10EDE04", Offset = "0x10EDE04", VA = "0x10EDE04")]
		public RESULT isOneshot(out bool oneshot)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000A09")]
		[Address(RVA = "0x10EDE0C", Offset = "0x10EDE0C", VA = "0x10EDE0C")]
		public RESULT isStream(out bool isStream)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000A0A")]
		[Address(RVA = "0x10EDE14", Offset = "0x10EDE14", VA = "0x10EDE14")]
		public RESULT is3D(out bool is3D)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000A0B")]
		[Address(RVA = "0x10EDE1C", Offset = "0x10EDE1C", VA = "0x10EDE1C")]
		public RESULT hasCue(out bool cue)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000A0C")]
		[Address(RVA = "0x10EDE24", Offset = "0x10EDE24", VA = "0x10EDE24")]
		public RESULT createInstance(out EventInstance instance)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000A0D")]
		[Address(RVA = "0x10EDE2C", Offset = "0x10EDE2C", VA = "0x10EDE2C")]
		public RESULT getInstanceCount(out int count)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000A0E")]
		[Address(RVA = "0x10EDE34", Offset = "0x10EDE34", VA = "0x10EDE34")]
		public RESULT getInstanceList(out EventInstance[] array)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000A0F")]
		[Address(RVA = "0x10EDE3C", Offset = "0x10EDE3C", VA = "0x10EDE3C")]
		public RESULT loadSampleData()
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000A10")]
		[Address(RVA = "0x10EDE44", Offset = "0x10EDE44", VA = "0x10EDE44")]
		public RESULT unloadSampleData()
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000A11")]
		[Address(RVA = "0x10EDE4C", Offset = "0x10EDE4C", VA = "0x10EDE4C")]
		public RESULT getSampleLoadingState(out LOADING_STATE state)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000A12")]
		[Address(RVA = "0x10EDE54", Offset = "0x10EDE54", VA = "0x10EDE54")]
		public RESULT releaseAllInstances()
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000A13")]
		[Address(RVA = "0x10EDE5C", Offset = "0x10EDE5C", VA = "0x10EDE5C")]
		public RESULT setCallback(EVENT_CALLBACK callback, EVENT_CALLBACK_TYPE callbackmask = EVENT_CALLBACK_TYPE.ALL)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000A14")]
		[Address(RVA = "0x10EDE64", Offset = "0x10EDE64", VA = "0x10EDE64")]
		public RESULT getUserData(out IntPtr userdata)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000A15")]
		[Address(RVA = "0x10EDE6C", Offset = "0x10EDE6C", VA = "0x10EDE6C")]
		public RESULT setUserData(IntPtr userdata)
		{
			return default(RESULT);
		}

		[PreserveSig]
		[Token(Token = "0x6000A16")]
		[Address(RVA = "0x17FBED0", Offset = "0x17FBED0", VA = "0x17FBED0")]
		private static extern bool FMOD_Studio_EventDescription_IsValid(IntPtr eventdescription);

		[PreserveSig]
		[Token(Token = "0x6000A17")]
		[Address(RVA = "0x17FA558", Offset = "0x17FA558", VA = "0x17FA558")]
		private static extern RESULT FMOD_Studio_EventDescription_GetID(IntPtr eventdescription, out Guid id);

		[PreserveSig]
		[Token(Token = "0x6000A18")]
		[Address(RVA = "0x17FA820", Offset = "0x17FA820", VA = "0x17FA820")]
		private static extern RESULT FMOD_Studio_EventDescription_GetPath(IntPtr eventdescription, IntPtr path, int size, out int retrieved);

		[PreserveSig]
		[Token(Token = "0x6000A19")]
		[Address(RVA = "0x17FA8D0", Offset = "0x17FA8D0", VA = "0x17FA8D0")]
		private static extern RESULT FMOD_Studio_EventDescription_GetParameterDescriptionCount(IntPtr eventdescription, out int count);

		[PreserveSig]
		[Token(Token = "0x6000A1A")]
		[Address(RVA = "0x17FA968", Offset = "0x17FA968", VA = "0x17FA968")]
		private static extern RESULT FMOD_Studio_EventDescription_GetParameterDescriptionByIndex(IntPtr eventdescription, int index, out PARAMETER_DESCRIPTION parameter);

		[PreserveSig]
		[Token(Token = "0x6000A1B")]
		[Address(RVA = "0x17FAB50", Offset = "0x17FAB50", VA = "0x17FAB50")]
		private static extern RESULT FMOD_Studio_EventDescription_GetParameterDescriptionByName(IntPtr eventdescription, byte[] name, out PARAMETER_DESCRIPTION parameter);

		[PreserveSig]
		[Token(Token = "0x6000A1C")]
		[Address(RVA = "0x17FABF8", Offset = "0x17FABF8", VA = "0x17FABF8")]
		private static extern RESULT FMOD_Studio_EventDescription_GetParameterDescriptionByName(IntPtr eventdescription, IntPtr name, out PARAMETER_DESCRIPTION parameter);

		[PreserveSig]
		[Token(Token = "0x6000A1D")]
		[Address(RVA = "0x17FAC98", Offset = "0x17FAC98", VA = "0x17FAC98")]
		private static extern RESULT FMOD_Studio_EventDescription_GetParameterDescriptionByID(IntPtr eventdescription, ulong id, out PARAMETER_DESCRIPTION parameter);

		[PreserveSig]
		[Token(Token = "0x6000A1E")]
		[Address(RVA = "0x17FAD38", Offset = "0x17FAD38", VA = "0x17FAD38")]
		private static extern RESULT FMOD_Studio_EventDescription_GetUserPropertyCount(IntPtr eventdescription, out int count);

		[PreserveSig]
		[Token(Token = "0x6000A1F")]
		[Address(RVA = "0x17FADD0", Offset = "0x17FADD0", VA = "0x17FADD0")]
		private static extern RESULT FMOD_Studio_EventDescription_GetUserPropertyByIndex(IntPtr eventdescription, int index, out USER_PROPERTY property);

		[PreserveSig]
		[Token(Token = "0x6000A20")]
		[Address(RVA = "0x17FB004", Offset = "0x17FB004", VA = "0x17FB004")]
		private static extern RESULT FMOD_Studio_EventDescription_GetUserProperty(IntPtr eventdescription, byte[] name, out USER_PROPERTY property);

		[PreserveSig]
		[Token(Token = "0x6000A21")]
		[Address(RVA = "0x17FB0F8", Offset = "0x17FB0F8", VA = "0x17FB0F8")]
		private static extern RESULT FMOD_Studio_EventDescription_GetUserProperty(IntPtr eventdescription, IntPtr name, out USER_PROPERTY property);

		[PreserveSig]
		[Token(Token = "0x6000A22")]
		[Address(RVA = "0x17FB1E4", Offset = "0x17FB1E4", VA = "0x17FB1E4")]
		private static extern RESULT FMOD_Studio_EventDescription_GetLength(IntPtr eventdescription, out int length);

		[PreserveSig]
		[Token(Token = "0x6000A23")]
		[Address(RVA = "0x17FB27C", Offset = "0x17FB27C", VA = "0x17FB27C")]
		private static extern RESULT FMOD_Studio_EventDescription_GetMinimumDistance(IntPtr eventdescription, out float distance);

		[PreserveSig]
		[Token(Token = "0x6000A24")]
		[Address(RVA = "0x17FB314", Offset = "0x17FB314", VA = "0x17FB314")]
		private static extern RESULT FMOD_Studio_EventDescription_GetMaximumDistance(IntPtr eventdescription, out float distance);

		[PreserveSig]
		[Token(Token = "0x6000A25")]
		[Address(RVA = "0x17FB3AC", Offset = "0x17FB3AC", VA = "0x17FB3AC")]
		private static extern RESULT FMOD_Studio_EventDescription_GetSoundSize(IntPtr eventdescription, out float size);

		[PreserveSig]
		[Token(Token = "0x6000A26")]
		[Address(RVA = "0x17FB444", Offset = "0x17FB444", VA = "0x17FB444")]
		private static extern RESULT FMOD_Studio_EventDescription_IsSnapshot(IntPtr eventdescription, out bool snapshot);

		[PreserveSig]
		[Token(Token = "0x6000A27")]
		[Address(RVA = "0x17FB4F0", Offset = "0x17FB4F0", VA = "0x17FB4F0")]
		private static extern RESULT FMOD_Studio_EventDescription_IsOneshot(IntPtr eventdescription, out bool oneshot);

		[PreserveSig]
		[Token(Token = "0x6000A28")]
		[Address(RVA = "0x17FB59C", Offset = "0x17FB59C", VA = "0x17FB59C")]
		private static extern RESULT FMOD_Studio_EventDescription_IsStream(IntPtr eventdescription, out bool isStream);

		[PreserveSig]
		[Token(Token = "0x6000A29")]
		[Address(RVA = "0x17FB648", Offset = "0x17FB648", VA = "0x17FB648")]
		private static extern RESULT FMOD_Studio_EventDescription_Is3D(IntPtr eventdescription, out bool is3D);

		[PreserveSig]
		[Token(Token = "0x6000A2A")]
		[Address(RVA = "0x17FB6F4", Offset = "0x17FB6F4", VA = "0x17FB6F4")]
		private static extern RESULT FMOD_Studio_EventDescription_HasCue(IntPtr eventdescription, out bool cue);

		[PreserveSig]
		[Token(Token = "0x6000A2B")]
		[Address(RVA = "0x17FB7A0", Offset = "0x17FB7A0", VA = "0x17FB7A0")]
		private static extern RESULT FMOD_Studio_EventDescription_CreateInstance(IntPtr eventdescription, out IntPtr instance);

		[PreserveSig]
		[Token(Token = "0x6000A2C")]
		[Address(RVA = "0x17FB838", Offset = "0x17FB838", VA = "0x17FB838")]
		private static extern RESULT FMOD_Studio_EventDescription_GetInstanceCount(IntPtr eventdescription, out int count);

		[PreserveSig]
		[Token(Token = "0x6000A2D")]
		[Address(RVA = "0x17FBA18", Offset = "0x17FBA18", VA = "0x17FBA18")]
		private static extern RESULT FMOD_Studio_EventDescription_GetInstanceList(IntPtr eventdescription, IntPtr[] array, int capacity, out int count);

		[PreserveSig]
		[Token(Token = "0x6000A2E")]
		[Address(RVA = "0x17FBAD0", Offset = "0x17FBAD0", VA = "0x17FBAD0")]
		private static extern RESULT FMOD_Studio_EventDescription_LoadSampleData(IntPtr eventdescription);

		[PreserveSig]
		[Token(Token = "0x6000A2F")]
		[Address(RVA = "0x17FBB58", Offset = "0x17FBB58", VA = "0x17FBB58")]
		private static extern RESULT FMOD_Studio_EventDescription_UnloadSampleData(IntPtr eventdescription);

		[PreserveSig]
		[Token(Token = "0x6000A30")]
		[Address(RVA = "0x17FBBE0", Offset = "0x17FBBE0", VA = "0x17FBBE0")]
		private static extern RESULT FMOD_Studio_EventDescription_GetSampleLoadingState(IntPtr eventdescription, out LOADING_STATE state);

		[PreserveSig]
		[Token(Token = "0x6000A31")]
		[Address(RVA = "0x17FBC78", Offset = "0x17FBC78", VA = "0x17FBC78")]
		private static extern RESULT FMOD_Studio_EventDescription_ReleaseAllInstances(IntPtr eventdescription);

		[PreserveSig]
		[Token(Token = "0x6000A32")]
		[Address(RVA = "0x17FBD00", Offset = "0x17FBD00", VA = "0x17FBD00")]
		private static extern RESULT FMOD_Studio_EventDescription_SetCallback(IntPtr eventdescription, EVENT_CALLBACK callback, EVENT_CALLBACK_TYPE callbackmask);

		[PreserveSig]
		[Token(Token = "0x6000A33")]
		[Address(RVA = "0x17FBDA8", Offset = "0x17FBDA8", VA = "0x17FBDA8")]
		private static extern RESULT FMOD_Studio_EventDescription_GetUserData(IntPtr eventdescription, out IntPtr userdata);

		[PreserveSig]
		[Token(Token = "0x6000A34")]
		[Address(RVA = "0x17FBE40", Offset = "0x17FBE40", VA = "0x17FBE40")]
		private static extern RESULT FMOD_Studio_EventDescription_SetUserData(IntPtr eventdescription, IntPtr userdata);

		[Token(Token = "0x6000A35")]
		[Address(RVA = "0x10EDE74", Offset = "0x10EDE74", VA = "0x10EDE74")]
		public bool hasHandle()
		{
			return default(bool);
		}

		[Token(Token = "0x6000A36")]
		[Address(RVA = "0x10EDE7C", Offset = "0x10EDE7C", VA = "0x10EDE7C")]
		public void clearHandle()
		{
		}

		[Token(Token = "0x6000A37")]
		[Address(RVA = "0x10EDEC0", Offset = "0x10EDEC0", VA = "0x10EDEC0")]
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
		[Address(RVA = "0x10EDEC8", Offset = "0x10EDEC8", VA = "0x10EDEC8")]
		public RESULT getDescription(out EventDescription description)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000A39")]
		[Address(RVA = "0x10EDED0", Offset = "0x10EDED0", VA = "0x10EDED0")]
		public RESULT getVolume(out float volume)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000A3A")]
		[Address(RVA = "0x10EDEF8", Offset = "0x10EDEF8", VA = "0x10EDEF8")]
		public RESULT getVolume(out float volume, out float finalvolume)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000A3B")]
		[Address(RVA = "0x10EDF00", Offset = "0x10EDF00", VA = "0x10EDF00")]
		public RESULT setVolume(float volume)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000A3C")]
		[Address(RVA = "0x10EDF08", Offset = "0x10EDF08", VA = "0x10EDF08")]
		public RESULT getPitch(out float pitch)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000A3D")]
		[Address(RVA = "0x10EDF30", Offset = "0x10EDF30", VA = "0x10EDF30")]
		public RESULT getPitch(out float pitch, out float finalpitch)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000A3E")]
		[Address(RVA = "0x10EDF38", Offset = "0x10EDF38", VA = "0x10EDF38")]
		public RESULT setPitch(float pitch)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000A3F")]
		[Address(RVA = "0x10EDF40", Offset = "0x10EDF40", VA = "0x10EDF40")]
		public RESULT get3DAttributes(out ATTRIBUTES_3D attributes)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000A40")]
		[Address(RVA = "0x10EDF48", Offset = "0x10EDF48", VA = "0x10EDF48")]
		public RESULT set3DAttributes(ATTRIBUTES_3D attributes)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000A41")]
		[Address(RVA = "0x10EDF7C", Offset = "0x10EDF7C", VA = "0x10EDF7C")]
		public RESULT getListenerMask(out uint mask)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000A42")]
		[Address(RVA = "0x10EDF84", Offset = "0x10EDF84", VA = "0x10EDF84")]
		public RESULT setListenerMask(uint mask)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000A43")]
		[Address(RVA = "0x10EDF8C", Offset = "0x10EDF8C", VA = "0x10EDF8C")]
		public RESULT getProperty(EVENT_PROPERTY index, out float value)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000A44")]
		[Address(RVA = "0x10EDF94", Offset = "0x10EDF94", VA = "0x10EDF94")]
		public RESULT setProperty(EVENT_PROPERTY index, float value)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000A45")]
		[Address(RVA = "0x10EDF9C", Offset = "0x10EDF9C", VA = "0x10EDF9C")]
		public RESULT getReverbLevel(int index, out float level)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000A46")]
		[Address(RVA = "0x10EDFA4", Offset = "0x10EDFA4", VA = "0x10EDFA4")]
		public RESULT setReverbLevel(int index, float level)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000A47")]
		[Address(RVA = "0x10EDFAC", Offset = "0x10EDFAC", VA = "0x10EDFAC")]
		public RESULT getPaused(out bool paused)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000A48")]
		[Address(RVA = "0x10EDFB4", Offset = "0x10EDFB4", VA = "0x10EDFB4")]
		public RESULT setPaused(bool paused)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000A49")]
		[Address(RVA = "0x10EDFC0", Offset = "0x10EDFC0", VA = "0x10EDFC0")]
		public RESULT start()
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000A4A")]
		[Address(RVA = "0x10EDFC8", Offset = "0x10EDFC8", VA = "0x10EDFC8")]
		public RESULT stop(STOP_MODE mode)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000A4B")]
		[Address(RVA = "0x10EDFD0", Offset = "0x10EDFD0", VA = "0x10EDFD0")]
		public RESULT getTimelinePosition(out int position)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000A4C")]
		[Address(RVA = "0x10EDFD8", Offset = "0x10EDFD8", VA = "0x10EDFD8")]
		public RESULT setTimelinePosition(int position)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000A4D")]
		[Address(RVA = "0x10EDFE0", Offset = "0x10EDFE0", VA = "0x10EDFE0")]
		public RESULT getPlaybackState(out PLAYBACK_STATE state)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000A4E")]
		[Address(RVA = "0x10EDFE8", Offset = "0x10EDFE8", VA = "0x10EDFE8")]
		public RESULT getChannelGroup(out ChannelGroup group)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000A4F")]
		[Address(RVA = "0x10EDFF0", Offset = "0x10EDFF0", VA = "0x10EDFF0")]
		public RESULT release()
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000A50")]
		[Address(RVA = "0x10EDFF8", Offset = "0x10EDFF8", VA = "0x10EDFF8")]
		public RESULT isVirtual(out bool virtualstate)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000A51")]
		[Address(RVA = "0x10EE000", Offset = "0x10EE000", VA = "0x10EE000")]
		public RESULT getParameterByID(PARAMETER_ID id, out float value)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000A52")]
		[Address(RVA = "0x10EE028", Offset = "0x10EE028", VA = "0x10EE028")]
		public RESULT getParameterByID(PARAMETER_ID id, out float value, out float finalvalue)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000A53")]
		[Address(RVA = "0x10EE030", Offset = "0x10EE030", VA = "0x10EE030")]
		public RESULT setParameterByID(PARAMETER_ID id, float value, bool ignoreseekspeed = false)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000A54")]
		[Address(RVA = "0x10EE03C", Offset = "0x10EE03C", VA = "0x10EE03C")]
		public RESULT setParametersByIDs(PARAMETER_ID[] ids, float[] values, int count, bool ignoreseekspeed = false)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000A55")]
		[Address(RVA = "0x10EE048", Offset = "0x10EE048", VA = "0x10EE048")]
		public RESULT getParameterByName(string name, out float value)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000A56")]
		[Address(RVA = "0x10EE070", Offset = "0x10EE070", VA = "0x10EE070")]
		public RESULT getParameterByName(string name, out float value, out float finalvalue)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000A57")]
		[Address(RVA = "0x10EE078", Offset = "0x10EE078", VA = "0x10EE078")]
		public RESULT getParameterByName(IntPtr name, out float value)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000A58")]
		[Address(RVA = "0x10EE0A0", Offset = "0x10EE0A0", VA = "0x10EE0A0")]
		public RESULT getParameterByName(IntPtr name, out float value, out float finalvalue)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000A59")]
		[Address(RVA = "0x10EE0A8", Offset = "0x10EE0A8", VA = "0x10EE0A8")]
		public RESULT setParameterByName(string name, float value, bool ignoreseekspeed = false)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000A5A")]
		[Address(RVA = "0x10EE0B4", Offset = "0x10EE0B4", VA = "0x10EE0B4")]
		public RESULT setParameterByName(IntPtr name, float value, bool ignoreseekspeed = false)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000A5B")]
		[Address(RVA = "0x10EE0C0", Offset = "0x10EE0C0", VA = "0x10EE0C0")]
		public RESULT triggerCue()
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000A5C")]
		[Address(RVA = "0x10EE0C8", Offset = "0x10EE0C8", VA = "0x10EE0C8")]
		public RESULT setCallback(EVENT_CALLBACK callback, EVENT_CALLBACK_TYPE callbackmask = EVENT_CALLBACK_TYPE.ALL)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000A5D")]
		[Address(RVA = "0x10EE0D0", Offset = "0x10EE0D0", VA = "0x10EE0D0")]
		public RESULT getUserData(out IntPtr userdata)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000A5E")]
		[Address(RVA = "0x10EE0D8", Offset = "0x10EE0D8", VA = "0x10EE0D8")]
		public RESULT setUserData(IntPtr userdata)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000A5F")]
		[Address(RVA = "0x10EE0E0", Offset = "0x10EE0E0", VA = "0x10EE0E0")]
		public RESULT getCPUUsage(out uint exclusive, out uint inclusive)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000A60")]
		[Address(RVA = "0x10EE0E8", Offset = "0x10EE0E8", VA = "0x10EE0E8")]
		public RESULT getMemoryUsage(out MEMORY_USAGE memoryusage)
		{
			return default(RESULT);
		}

		[PreserveSig]
		[Token(Token = "0x6000A61")]
		[Address(RVA = "0x17FDA24", Offset = "0x17FDA24", VA = "0x17FDA24")]
		private static extern bool FMOD_Studio_EventInstance_IsValid(IntPtr _event);

		[PreserveSig]
		[Token(Token = "0x6000A62")]
		[Address(RVA = "0x17FC028", Offset = "0x17FC028", VA = "0x17FC028")]
		private static extern RESULT FMOD_Studio_EventInstance_GetDescription(IntPtr _event, out IntPtr description);

		[PreserveSig]
		[Token(Token = "0x6000A63")]
		[Address(RVA = "0x17FC0E8", Offset = "0x17FC0E8", VA = "0x17FC0E8")]
		private static extern RESULT FMOD_Studio_EventInstance_GetVolume(IntPtr _event, out float volume, out float finalvolume);

		[PreserveSig]
		[Token(Token = "0x6000A64")]
		[Address(RVA = "0x17FC188", Offset = "0x17FC188", VA = "0x17FC188")]
		private static extern RESULT FMOD_Studio_EventInstance_SetVolume(IntPtr _event, float volume);

		[PreserveSig]
		[Token(Token = "0x6000A65")]
		[Address(RVA = "0x17FC248", Offset = "0x17FC248", VA = "0x17FC248")]
		private static extern RESULT FMOD_Studio_EventInstance_GetPitch(IntPtr _event, out float pitch, out float finalpitch);

		[PreserveSig]
		[Token(Token = "0x6000A66")]
		[Address(RVA = "0x17FC2E8", Offset = "0x17FC2E8", VA = "0x17FC2E8")]
		private static extern RESULT FMOD_Studio_EventInstance_SetPitch(IntPtr _event, float pitch);

		[PreserveSig]
		[Token(Token = "0x6000A67")]
		[Address(RVA = "0x17FC380", Offset = "0x17FC380", VA = "0x17FC380")]
		private static extern RESULT FMOD_Studio_EventInstance_Get3DAttributes(IntPtr _event, out ATTRIBUTES_3D attributes);

		[PreserveSig]
		[Token(Token = "0x6000A68")]
		[Address(RVA = "0x17FC418", Offset = "0x17FC418", VA = "0x17FC418")]
		private static extern RESULT FMOD_Studio_EventInstance_Set3DAttributes(IntPtr _event, ref ATTRIBUTES_3D attributes);

		[PreserveSig]
		[Token(Token = "0x6000A69")]
		[Address(RVA = "0x17FC4B0", Offset = "0x17FC4B0", VA = "0x17FC4B0")]
		private static extern RESULT FMOD_Studio_EventInstance_GetListenerMask(IntPtr _event, out uint mask);

		[PreserveSig]
		[Token(Token = "0x6000A6A")]
		[Address(RVA = "0x17FC548", Offset = "0x17FC548", VA = "0x17FC548")]
		private static extern RESULT FMOD_Studio_EventInstance_SetListenerMask(IntPtr _event, uint mask);

		[PreserveSig]
		[Token(Token = "0x6000A6B")]
		[Address(RVA = "0x17FC5E0", Offset = "0x17FC5E0", VA = "0x17FC5E0")]
		private static extern RESULT FMOD_Studio_EventInstance_GetProperty(IntPtr _event, EVENT_PROPERTY index, out float value);

		[PreserveSig]
		[Token(Token = "0x6000A6C")]
		[Address(RVA = "0x17FC680", Offset = "0x17FC680", VA = "0x17FC680")]
		private static extern RESULT FMOD_Studio_EventInstance_SetProperty(IntPtr _event, EVENT_PROPERTY index, float value);

		[PreserveSig]
		[Token(Token = "0x6000A6D")]
		[Address(RVA = "0x17FC728", Offset = "0x17FC728", VA = "0x17FC728")]
		private static extern RESULT FMOD_Studio_EventInstance_GetReverbLevel(IntPtr _event, int index, out float level);

		[PreserveSig]
		[Token(Token = "0x6000A6E")]
		[Address(RVA = "0x17FC7C8", Offset = "0x17FC7C8", VA = "0x17FC7C8")]
		private static extern RESULT FMOD_Studio_EventInstance_SetReverbLevel(IntPtr _event, int index, float level);

		[PreserveSig]
		[Token(Token = "0x6000A6F")]
		[Address(RVA = "0x17FC870", Offset = "0x17FC870", VA = "0x17FC870")]
		private static extern RESULT FMOD_Studio_EventInstance_GetPaused(IntPtr _event, out bool paused);

		[PreserveSig]
		[Token(Token = "0x6000A70")]
		[Address(RVA = "0x17FC920", Offset = "0x17FC920", VA = "0x17FC920")]
		private static extern RESULT FMOD_Studio_EventInstance_SetPaused(IntPtr _event, bool paused);

		[PreserveSig]
		[Token(Token = "0x6000A71")]
		[Address(RVA = "0x17FC9B8", Offset = "0x17FC9B8", VA = "0x17FC9B8")]
		private static extern RESULT FMOD_Studio_EventInstance_Start(IntPtr _event);

		[PreserveSig]
		[Token(Token = "0x6000A72")]
		[Address(RVA = "0x17FCA40", Offset = "0x17FCA40", VA = "0x17FCA40")]
		private static extern RESULT FMOD_Studio_EventInstance_Stop(IntPtr _event, STOP_MODE mode);

		[PreserveSig]
		[Token(Token = "0x6000A73")]
		[Address(RVA = "0x17FCAD8", Offset = "0x17FCAD8", VA = "0x17FCAD8")]
		private static extern RESULT FMOD_Studio_EventInstance_GetTimelinePosition(IntPtr _event, out int position);

		[PreserveSig]
		[Token(Token = "0x6000A74")]
		[Address(RVA = "0x17FCB70", Offset = "0x17FCB70", VA = "0x17FCB70")]
		private static extern RESULT FMOD_Studio_EventInstance_SetTimelinePosition(IntPtr _event, int position);

		[PreserveSig]
		[Token(Token = "0x6000A75")]
		[Address(RVA = "0x17FCC08", Offset = "0x17FCC08", VA = "0x17FCC08")]
		private static extern RESULT FMOD_Studio_EventInstance_GetPlaybackState(IntPtr _event, out PLAYBACK_STATE state);

		[PreserveSig]
		[Token(Token = "0x6000A76")]
		[Address(RVA = "0x17FCCA0", Offset = "0x17FCCA0", VA = "0x17FCCA0")]
		private static extern RESULT FMOD_Studio_EventInstance_GetChannelGroup(IntPtr _event, out IntPtr group);

		[PreserveSig]
		[Token(Token = "0x6000A77")]
		[Address(RVA = "0x17FCD38", Offset = "0x17FCD38", VA = "0x17FCD38")]
		private static extern RESULT FMOD_Studio_EventInstance_Release(IntPtr _event);

		[PreserveSig]
		[Token(Token = "0x6000A78")]
		[Address(RVA = "0x17FCDC0", Offset = "0x17FCDC0", VA = "0x17FCDC0")]
		private static extern RESULT FMOD_Studio_EventInstance_IsVirtual(IntPtr _event, out bool virtualstate);

		[PreserveSig]
		[Token(Token = "0x6000A79")]
		[Address(RVA = "0x17FD240", Offset = "0x17FD240", VA = "0x17FD240")]
		private static extern RESULT FMOD_Studio_EventInstance_GetParameterByName(IntPtr _event, byte[] name, out float value, out float finalvalue);

		[PreserveSig]
		[Token(Token = "0x6000A7A")]
		[Address(RVA = "0x17FD320", Offset = "0x17FD320", VA = "0x17FD320")]
		private static extern RESULT FMOD_Studio_EventInstance_GetParameterByName(IntPtr _event, IntPtr name, out float value, out float finalvalue);

		[PreserveSig]
		[Token(Token = "0x6000A7B")]
		[Address(RVA = "0x17FCE94", Offset = "0x17FCE94", VA = "0x17FCE94")]
		private static extern RESULT FMOD_Studio_EventInstance_GetParameterByID(IntPtr _event, ulong id, out float value, out float finalvalue);

		[PreserveSig]
		[Token(Token = "0x6000A7C")]
		[Address(RVA = "0x17FD528", Offset = "0x17FD528", VA = "0x17FD528")]
		private static extern RESULT FMOD_Studio_EventInstance_SetParameterByName(IntPtr _event, byte[] name, float value, bool ignoreseekspeed);

		[PreserveSig]
		[Token(Token = "0x6000A7D")]
		[Address(RVA = "0x17FD5E4", Offset = "0x17FD5E4", VA = "0x17FD5E4")]
		private static extern RESULT FMOD_Studio_EventInstance_SetParameterByName(IntPtr _event, IntPtr name, float value, bool ignoreseekspeed);

		[PreserveSig]
		[Token(Token = "0x6000A7E")]
		[Address(RVA = "0x17FCF48", Offset = "0x17FCF48", VA = "0x17FCF48")]
		private static extern RESULT FMOD_Studio_EventInstance_SetParameterByID(IntPtr _event, ulong id, float value, bool ignoreseekspeed);

		[PreserveSig]
		[Token(Token = "0x6000A7F")]
		[Address(RVA = "0x17FCFFC", Offset = "0x17FCFFC", VA = "0x17FCFFC")]
		private static extern RESULT FMOD_Studio_EventInstance_SetParametersByIDs(IntPtr _event, PARAMETER_ID[] ids, float[] values, int count, bool ignoreseekspeed);

		[PreserveSig]
		[Token(Token = "0x6000A80")]
		[Address(RVA = "0x17FD694", Offset = "0x17FD694", VA = "0x17FD694")]
		private static extern RESULT FMOD_Studio_EventInstance_TriggerCue(IntPtr _event);

		[PreserveSig]
		[Token(Token = "0x6000A81")]
		[Address(RVA = "0x17FD71C", Offset = "0x17FD71C", VA = "0x17FD71C")]
		private static extern RESULT FMOD_Studio_EventInstance_SetCallback(IntPtr _event, EVENT_CALLBACK callback, EVENT_CALLBACK_TYPE callbackmask);

		[PreserveSig]
		[Token(Token = "0x6000A82")]
		[Address(RVA = "0x17FD7C4", Offset = "0x17FD7C4", VA = "0x17FD7C4")]
		private static extern RESULT FMOD_Studio_EventInstance_GetUserData(IntPtr _event, out IntPtr userdata);

		[PreserveSig]
		[Token(Token = "0x6000A83")]
		[Address(RVA = "0x17FD85C", Offset = "0x17FD85C", VA = "0x17FD85C")]
		private static extern RESULT FMOD_Studio_EventInstance_SetUserData(IntPtr _event, IntPtr userdata);

		[PreserveSig]
		[Token(Token = "0x6000A84")]
		[Address(RVA = "0x17FD8F4", Offset = "0x17FD8F4", VA = "0x17FD8F4")]
		private static extern RESULT FMOD_Studio_EventInstance_GetCPUUsage(IntPtr _event, out uint exclusive, out uint inclusive);

		[PreserveSig]
		[Token(Token = "0x6000A85")]
		[Address(RVA = "0x17FD994", Offset = "0x17FD994", VA = "0x17FD994")]
		private static extern RESULT FMOD_Studio_EventInstance_GetMemoryUsage(IntPtr _event, out MEMORY_USAGE memoryusage);

		[Token(Token = "0x6000A86")]
		[Address(RVA = "0x10EE0F0", Offset = "0x10EE0F0", VA = "0x10EE0F0")]
		public bool hasHandle()
		{
			return default(bool);
		}

		[Token(Token = "0x6000A87")]
		[Address(RVA = "0x10EE0F8", Offset = "0x10EE0F8", VA = "0x10EE0F8")]
		public void clearHandle()
		{
		}

		[Token(Token = "0x6000A88")]
		[Address(RVA = "0x10EE13C", Offset = "0x10EE13C", VA = "0x10EE13C")]
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
		[Address(RVA = "0x10EDB10", Offset = "0x10EDB10", VA = "0x10EDB10")]
		public RESULT getID(out Guid id)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000A8A")]
		[Address(RVA = "0x10EDB18", Offset = "0x10EDB18", VA = "0x10EDB18")]
		public RESULT getPath(out string path)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000A8B")]
		[Address(RVA = "0x10EDB20", Offset = "0x10EDB20", VA = "0x10EDB20")]
		public RESULT getVolume(out float volume)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000A8C")]
		[Address(RVA = "0x10EDB48", Offset = "0x10EDB48", VA = "0x10EDB48")]
		public RESULT getVolume(out float volume, out float finalvolume)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000A8D")]
		[Address(RVA = "0x10EDB50", Offset = "0x10EDB50", VA = "0x10EDB50")]
		public RESULT setVolume(float volume)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000A8E")]
		[Address(RVA = "0x10EDB58", Offset = "0x10EDB58", VA = "0x10EDB58")]
		public RESULT getPaused(out bool paused)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000A8F")]
		[Address(RVA = "0x10EDB60", Offset = "0x10EDB60", VA = "0x10EDB60")]
		public RESULT setPaused(bool paused)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000A90")]
		[Address(RVA = "0x10EDB6C", Offset = "0x10EDB6C", VA = "0x10EDB6C")]
		public RESULT getMute(out bool mute)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000A91")]
		[Address(RVA = "0x10EDB74", Offset = "0x10EDB74", VA = "0x10EDB74")]
		public RESULT setMute(bool mute)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000A92")]
		[Address(RVA = "0x10EDB80", Offset = "0x10EDB80", VA = "0x10EDB80")]
		public RESULT stopAllEvents(STOP_MODE mode)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000A93")]
		[Address(RVA = "0x10EDB88", Offset = "0x10EDB88", VA = "0x10EDB88")]
		public RESULT lockChannelGroup()
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000A94")]
		[Address(RVA = "0x10EDB90", Offset = "0x10EDB90", VA = "0x10EDB90")]
		public RESULT unlockChannelGroup()
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000A95")]
		[Address(RVA = "0x10EDB98", Offset = "0x10EDB98", VA = "0x10EDB98")]
		public RESULT getChannelGroup(out ChannelGroup group)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000A96")]
		[Address(RVA = "0x10EDBA0", Offset = "0x10EDBA0", VA = "0x10EDBA0")]
		public RESULT getCPUUsage(out uint exclusive, out uint inclusive)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000A97")]
		[Address(RVA = "0x10EDBA8", Offset = "0x10EDBA8", VA = "0x10EDBA8")]
		public RESULT getMemoryUsage(out MEMORY_USAGE memoryusage)
		{
			return default(RESULT);
		}

		[PreserveSig]
		[Token(Token = "0x6000A98")]
		[Address(RVA = "0x17F81D0", Offset = "0x17F81D0", VA = "0x17F81D0")]
		private static extern bool FMOD_Studio_Bus_IsValid(IntPtr bus);

		[PreserveSig]
		[Token(Token = "0x6000A99")]
		[Address(RVA = "0x17F76F8", Offset = "0x17F76F8", VA = "0x17F76F8")]
		private static extern RESULT FMOD_Studio_Bus_GetID(IntPtr bus, out Guid id);

		[PreserveSig]
		[Token(Token = "0x6000A9A")]
		[Address(RVA = "0x17F79C0", Offset = "0x17F79C0", VA = "0x17F79C0")]
		private static extern RESULT FMOD_Studio_Bus_GetPath(IntPtr bus, IntPtr path, int size, out int retrieved);

		[PreserveSig]
		[Token(Token = "0x6000A9B")]
		[Address(RVA = "0x17F7A98", Offset = "0x17F7A98", VA = "0x17F7A98")]
		private static extern RESULT FMOD_Studio_Bus_GetVolume(IntPtr bus, out float volume, out float finalvolume);

		[PreserveSig]
		[Token(Token = "0x6000A9C")]
		[Address(RVA = "0x17F7B38", Offset = "0x17F7B38", VA = "0x17F7B38")]
		private static extern RESULT FMOD_Studio_Bus_SetVolume(IntPtr bus, float volume);

		[PreserveSig]
		[Token(Token = "0x6000A9D")]
		[Address(RVA = "0x17F7BD0", Offset = "0x17F7BD0", VA = "0x17F7BD0")]
		private static extern RESULT FMOD_Studio_Bus_GetPaused(IntPtr bus, out bool paused);

		[PreserveSig]
		[Token(Token = "0x6000A9E")]
		[Address(RVA = "0x17F7C80", Offset = "0x17F7C80", VA = "0x17F7C80")]
		private static extern RESULT FMOD_Studio_Bus_SetPaused(IntPtr bus, bool paused);

		[PreserveSig]
		[Token(Token = "0x6000A9F")]
		[Address(RVA = "0x17F7D18", Offset = "0x17F7D18", VA = "0x17F7D18")]
		private static extern RESULT FMOD_Studio_Bus_GetMute(IntPtr bus, out bool mute);

		[PreserveSig]
		[Token(Token = "0x6000AA0")]
		[Address(RVA = "0x17F7DC8", Offset = "0x17F7DC8", VA = "0x17F7DC8")]
		private static extern RESULT FMOD_Studio_Bus_SetMute(IntPtr bus, bool mute);

		[PreserveSig]
		[Token(Token = "0x6000AA1")]
		[Address(RVA = "0x17F7E60", Offset = "0x17F7E60", VA = "0x17F7E60")]
		private static extern RESULT FMOD_Studio_Bus_StopAllEvents(IntPtr bus, STOP_MODE mode);

		[PreserveSig]
		[Token(Token = "0x6000AA2")]
		[Address(RVA = "0x17F7EF8", Offset = "0x17F7EF8", VA = "0x17F7EF8")]
		private static extern RESULT FMOD_Studio_Bus_LockChannelGroup(IntPtr bus);

		[PreserveSig]
		[Token(Token = "0x6000AA3")]
		[Address(RVA = "0x17F7F80", Offset = "0x17F7F80", VA = "0x17F7F80")]
		private static extern RESULT FMOD_Studio_Bus_UnlockChannelGroup(IntPtr bus);

		[PreserveSig]
		[Token(Token = "0x6000AA4")]
		[Address(RVA = "0x17F8008", Offset = "0x17F8008", VA = "0x17F8008")]
		private static extern RESULT FMOD_Studio_Bus_GetChannelGroup(IntPtr bus, out IntPtr group);

		[PreserveSig]
		[Token(Token = "0x6000AA5")]
		[Address(RVA = "0x17F80A0", Offset = "0x17F80A0", VA = "0x17F80A0")]
		private static extern RESULT FMOD_Studio_Bus_GetCPUUsage(IntPtr bus, out uint exclusive, out uint inclusive);

		[PreserveSig]
		[Token(Token = "0x6000AA6")]
		[Address(RVA = "0x17F8140", Offset = "0x17F8140", VA = "0x17F8140")]
		private static extern RESULT FMOD_Studio_Bus_GetMemoryUsage(IntPtr bus, out MEMORY_USAGE memoryusage);

		[Token(Token = "0x6000AA7")]
		[Address(RVA = "0x10EDBB0", Offset = "0x10EDBB0", VA = "0x10EDBB0")]
		public bool hasHandle()
		{
			return default(bool);
		}

		[Token(Token = "0x6000AA8")]
		[Address(RVA = "0x10EDBB8", Offset = "0x10EDBB8", VA = "0x10EDBB8")]
		public void clearHandle()
		{
		}

		[Token(Token = "0x6000AA9")]
		[Address(RVA = "0x10EDBFC", Offset = "0x10EDBFC", VA = "0x10EDBFC")]
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
		[Address(RVA = "0x155E3E4", Offset = "0x155E3E4", VA = "0x155E3E4")]
		public RESULT getID(out Guid id)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000AAB")]
		[Address(RVA = "0x155E3EC", Offset = "0x155E3EC", VA = "0x155E3EC")]
		public RESULT getPath(out string path)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000AAC")]
		[Address(RVA = "0x155E3F4", Offset = "0x155E3F4", VA = "0x155E3F4")]
		public RESULT getVolume(out float volume)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000AAD")]
		[Address(RVA = "0x155E41C", Offset = "0x155E41C", VA = "0x155E41C")]
		public RESULT getVolume(out float volume, out float finalvolume)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000AAE")]
		[Address(RVA = "0x155E424", Offset = "0x155E424", VA = "0x155E424")]
		public RESULT setVolume(float volume)
		{
			return default(RESULT);
		}

		[PreserveSig]
		[Token(Token = "0x6000AAF")]
		[Address(RVA = "0x24B2010", Offset = "0x24B2010", VA = "0x24B2010")]
		private static extern bool FMOD_Studio_VCA_IsValid(IntPtr vca);

		[PreserveSig]
		[Token(Token = "0x6000AB0")]
		[Address(RVA = "0x24B1B38", Offset = "0x24B1B38", VA = "0x24B1B38")]
		private static extern RESULT FMOD_Studio_VCA_GetID(IntPtr vca, out Guid id);

		[PreserveSig]
		[Token(Token = "0x6000AB1")]
		[Address(RVA = "0x24B1E08", Offset = "0x24B1E08", VA = "0x24B1E08")]
		private static extern RESULT FMOD_Studio_VCA_GetPath(IntPtr vca, IntPtr path, int size, out int retrieved);

		[PreserveSig]
		[Token(Token = "0x6000AB2")]
		[Address(RVA = "0x24B1EE0", Offset = "0x24B1EE0", VA = "0x24B1EE0")]
		private static extern RESULT FMOD_Studio_VCA_GetVolume(IntPtr vca, out float volume, out float finalvolume);

		[PreserveSig]
		[Token(Token = "0x6000AB3")]
		[Address(RVA = "0x24B1F80", Offset = "0x24B1F80", VA = "0x24B1F80")]
		private static extern RESULT FMOD_Studio_VCA_SetVolume(IntPtr vca, float volume);

		[Token(Token = "0x6000AB4")]
		[Address(RVA = "0x155E42C", Offset = "0x155E42C", VA = "0x155E42C")]
		public bool hasHandle()
		{
			return default(bool);
		}

		[Token(Token = "0x6000AB5")]
		[Address(RVA = "0x155E434", Offset = "0x155E434", VA = "0x155E434")]
		public void clearHandle()
		{
		}

		[Token(Token = "0x6000AB6")]
		[Address(RVA = "0x155E478", Offset = "0x155E478", VA = "0x155E478")]
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
		[Address(RVA = "0x10EDA34", Offset = "0x10EDA34", VA = "0x10EDA34")]
		public RESULT getID(out Guid id)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000AB8")]
		[Address(RVA = "0x10EDA3C", Offset = "0x10EDA3C", VA = "0x10EDA3C")]
		public RESULT getPath(out string path)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000AB9")]
		[Address(RVA = "0x10EDA44", Offset = "0x10EDA44", VA = "0x10EDA44")]
		public RESULT unload()
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000ABA")]
		[Address(RVA = "0x10EDA4C", Offset = "0x10EDA4C", VA = "0x10EDA4C")]
		public RESULT loadSampleData()
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000ABB")]
		[Address(RVA = "0x10EDA54", Offset = "0x10EDA54", VA = "0x10EDA54")]
		public RESULT unloadSampleData()
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000ABC")]
		[Address(RVA = "0x10EDA5C", Offset = "0x10EDA5C", VA = "0x10EDA5C")]
		public RESULT getLoadingState(out LOADING_STATE state)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000ABD")]
		[Address(RVA = "0x10EDA64", Offset = "0x10EDA64", VA = "0x10EDA64")]
		public RESULT getSampleLoadingState(out LOADING_STATE state)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000ABE")]
		[Address(RVA = "0x10EDA6C", Offset = "0x10EDA6C", VA = "0x10EDA6C")]
		public RESULT getStringCount(out int count)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000ABF")]
		[Address(RVA = "0x10EDA74", Offset = "0x10EDA74", VA = "0x10EDA74")]
		public RESULT getStringInfo(int index, out Guid id, out string path)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000AC0")]
		[Address(RVA = "0x10EDA7C", Offset = "0x10EDA7C", VA = "0x10EDA7C")]
		public RESULT getEventCount(out int count)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000AC1")]
		[Address(RVA = "0x10EDA84", Offset = "0x10EDA84", VA = "0x10EDA84")]
		public RESULT getEventList(out EventDescription[] array)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000AC2")]
		[Address(RVA = "0x10EDA8C", Offset = "0x10EDA8C", VA = "0x10EDA8C")]
		public RESULT getBusCount(out int count)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000AC3")]
		[Address(RVA = "0x10EDA94", Offset = "0x10EDA94", VA = "0x10EDA94")]
		public RESULT getBusList(out Bus[] array)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000AC4")]
		[Address(RVA = "0x10EDA9C", Offset = "0x10EDA9C", VA = "0x10EDA9C")]
		public RESULT getVCACount(out int count)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000AC5")]
		[Address(RVA = "0x10EDAA4", Offset = "0x10EDAA4", VA = "0x10EDAA4")]
		public RESULT getVCAList(out VCA[] array)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000AC6")]
		[Address(RVA = "0x10EDAAC", Offset = "0x10EDAAC", VA = "0x10EDAAC")]
		public RESULT getUserData(out IntPtr userdata)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000AC7")]
		[Address(RVA = "0x10EDAB4", Offset = "0x10EDAB4", VA = "0x10EDAB4")]
		public RESULT setUserData(IntPtr userdata)
		{
			return default(RESULT);
		}

		[PreserveSig]
		[Token(Token = "0x6000AC8")]
		[Address(RVA = "0x17F75A0", Offset = "0x17F75A0", VA = "0x17F75A0")]
		private static extern bool FMOD_Studio_Bank_IsValid(IntPtr bank);

		[PreserveSig]
		[Token(Token = "0x6000AC9")]
		[Address(RVA = "0x17F6290", Offset = "0x17F6290", VA = "0x17F6290")]
		private static extern RESULT FMOD_Studio_Bank_GetID(IntPtr bank, out Guid id);

		[PreserveSig]
		[Token(Token = "0x6000ACA")]
		[Address(RVA = "0x17F6558", Offset = "0x17F6558", VA = "0x17F6558")]
		private static extern RESULT FMOD_Studio_Bank_GetPath(IntPtr bank, IntPtr path, int size, out int retrieved);

		[PreserveSig]
		[Token(Token = "0x6000ACB")]
		[Address(RVA = "0x17F6608", Offset = "0x17F6608", VA = "0x17F6608")]
		private static extern RESULT FMOD_Studio_Bank_Unload(IntPtr bank);

		[PreserveSig]
		[Token(Token = "0x6000ACC")]
		[Address(RVA = "0x17F6690", Offset = "0x17F6690", VA = "0x17F6690")]
		private static extern RESULT FMOD_Studio_Bank_LoadSampleData(IntPtr bank);

		[PreserveSig]
		[Token(Token = "0x6000ACD")]
		[Address(RVA = "0x17F6718", Offset = "0x17F6718", VA = "0x17F6718")]
		private static extern RESULT FMOD_Studio_Bank_UnloadSampleData(IntPtr bank);

		[PreserveSig]
		[Token(Token = "0x6000ACE")]
		[Address(RVA = "0x17F67A0", Offset = "0x17F67A0", VA = "0x17F67A0")]
		private static extern RESULT FMOD_Studio_Bank_GetLoadingState(IntPtr bank, out LOADING_STATE state);

		[PreserveSig]
		[Token(Token = "0x6000ACF")]
		[Address(RVA = "0x17F6838", Offset = "0x17F6838", VA = "0x17F6838")]
		private static extern RESULT FMOD_Studio_Bank_GetSampleLoadingState(IntPtr bank, out LOADING_STATE state);

		[PreserveSig]
		[Token(Token = "0x6000AD0")]
		[Address(RVA = "0x17F68D0", Offset = "0x17F68D0", VA = "0x17F68D0")]
		private static extern RESULT FMOD_Studio_Bank_GetStringCount(IntPtr bank, out int count);

		[PreserveSig]
		[Token(Token = "0x6000AD1")]
		[Address(RVA = "0x17F6BE8", Offset = "0x17F6BE8", VA = "0x17F6BE8")]
		private static extern RESULT FMOD_Studio_Bank_GetStringInfo(IntPtr bank, int index, out Guid id, IntPtr path, int size, out int retrieved);

		[PreserveSig]
		[Token(Token = "0x6000AD2")]
		[Address(RVA = "0x17F6CB0", Offset = "0x17F6CB0", VA = "0x17F6CB0")]
		private static extern RESULT FMOD_Studio_Bank_GetEventCount(IntPtr bank, out int count);

		[PreserveSig]
		[Token(Token = "0x6000AD3")]
		[Address(RVA = "0x17F6E90", Offset = "0x17F6E90", VA = "0x17F6E90")]
		private static extern RESULT FMOD_Studio_Bank_GetEventList(IntPtr bank, IntPtr[] array, int capacity, out int count);

		[PreserveSig]
		[Token(Token = "0x6000AD4")]
		[Address(RVA = "0x17F6F48", Offset = "0x17F6F48", VA = "0x17F6F48")]
		private static extern RESULT FMOD_Studio_Bank_GetBusCount(IntPtr bank, out int count);

		[PreserveSig]
		[Token(Token = "0x6000AD5")]
		[Address(RVA = "0x17F7128", Offset = "0x17F7128", VA = "0x17F7128")]
		private static extern RESULT FMOD_Studio_Bank_GetBusList(IntPtr bank, IntPtr[] array, int capacity, out int count);

		[PreserveSig]
		[Token(Token = "0x6000AD6")]
		[Address(RVA = "0x17F71E0", Offset = "0x17F71E0", VA = "0x17F71E0")]
		private static extern RESULT FMOD_Studio_Bank_GetVCACount(IntPtr bank, out int count);

		[PreserveSig]
		[Token(Token = "0x6000AD7")]
		[Address(RVA = "0x17F73C0", Offset = "0x17F73C0", VA = "0x17F73C0")]
		private static extern RESULT FMOD_Studio_Bank_GetVCAList(IntPtr bank, IntPtr[] array, int capacity, out int count);

		[PreserveSig]
		[Token(Token = "0x6000AD8")]
		[Address(RVA = "0x17F7478", Offset = "0x17F7478", VA = "0x17F7478")]
		private static extern RESULT FMOD_Studio_Bank_GetUserData(IntPtr bank, out IntPtr userdata);

		[PreserveSig]
		[Token(Token = "0x6000AD9")]
		[Address(RVA = "0x17F7510", Offset = "0x17F7510", VA = "0x17F7510")]
		private static extern RESULT FMOD_Studio_Bank_SetUserData(IntPtr bank, IntPtr userdata);

		[Token(Token = "0x6000ADA")]
		[Address(RVA = "0x10EDABC", Offset = "0x10EDABC", VA = "0x10EDABC")]
		public bool hasHandle()
		{
			return default(bool);
		}

		[Token(Token = "0x6000ADB")]
		[Address(RVA = "0x10EDAC4", Offset = "0x10EDAC4", VA = "0x10EDAC4")]
		public void clearHandle()
		{
		}

		[Token(Token = "0x6000ADC")]
		[Address(RVA = "0x10EDB08", Offset = "0x10EDB08", VA = "0x10EDB08")]
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
		[Address(RVA = "0x10EDC6C", Offset = "0x10EDC6C", VA = "0x10EDC6C")]
		public RESULT getSystem(out System system)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000ADE")]
		[Address(RVA = "0x10EDC74", Offset = "0x10EDC74", VA = "0x10EDC74")]
		public RESULT getLength(out float length)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000ADF")]
		[Address(RVA = "0x10EDC7C", Offset = "0x10EDC7C", VA = "0x10EDC7C")]
		public RESULT getCommandCount(out int count)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000AE0")]
		[Address(RVA = "0x10EDC84", Offset = "0x10EDC84", VA = "0x10EDC84")]
		public RESULT getCommandInfo(int commandIndex, out COMMAND_INFO info)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000AE1")]
		[Address(RVA = "0x10EDC8C", Offset = "0x10EDC8C", VA = "0x10EDC8C")]
		public RESULT getCommandString(int commandIndex, out string buffer)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000AE2")]
		[Address(RVA = "0x10EDC94", Offset = "0x10EDC94", VA = "0x10EDC94")]
		public RESULT getCommandAtTime(float time, out int commandIndex)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000AE3")]
		[Address(RVA = "0x10EDC9C", Offset = "0x10EDC9C", VA = "0x10EDC9C")]
		public RESULT setBankPath(string bankPath)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000AE4")]
		[Address(RVA = "0x10EDCA4", Offset = "0x10EDCA4", VA = "0x10EDCA4")]
		public RESULT start()
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000AE5")]
		[Address(RVA = "0x10EDCAC", Offset = "0x10EDCAC", VA = "0x10EDCAC")]
		public RESULT stop()
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000AE6")]
		[Address(RVA = "0x10EDCB4", Offset = "0x10EDCB4", VA = "0x10EDCB4")]
		public RESULT seekToTime(float time)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000AE7")]
		[Address(RVA = "0x10EDCBC", Offset = "0x10EDCBC", VA = "0x10EDCBC")]
		public RESULT seekToCommand(int commandIndex)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000AE8")]
		[Address(RVA = "0x10EDCC4", Offset = "0x10EDCC4", VA = "0x10EDCC4")]
		public RESULT getPaused(out bool paused)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000AE9")]
		[Address(RVA = "0x10EDCCC", Offset = "0x10EDCCC", VA = "0x10EDCCC")]
		public RESULT setPaused(bool paused)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000AEA")]
		[Address(RVA = "0x10EDCD8", Offset = "0x10EDCD8", VA = "0x10EDCD8")]
		public RESULT getPlaybackState(out PLAYBACK_STATE state)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000AEB")]
		[Address(RVA = "0x10EDCE0", Offset = "0x10EDCE0", VA = "0x10EDCE0")]
		public RESULT getCurrentCommand(out int commandIndex, out float currentTime)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000AEC")]
		[Address(RVA = "0x10EDCE8", Offset = "0x10EDCE8", VA = "0x10EDCE8")]
		public RESULT release()
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000AED")]
		[Address(RVA = "0x10EDCF0", Offset = "0x10EDCF0", VA = "0x10EDCF0")]
		public RESULT setFrameCallback(COMMANDREPLAY_FRAME_CALLBACK callback)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000AEE")]
		[Address(RVA = "0x10EDCF8", Offset = "0x10EDCF8", VA = "0x10EDCF8")]
		public RESULT setLoadBankCallback(COMMANDREPLAY_LOAD_BANK_CALLBACK callback)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000AEF")]
		[Address(RVA = "0x10EDD00", Offset = "0x10EDD00", VA = "0x10EDD00")]
		public RESULT setCreateInstanceCallback(COMMANDREPLAY_CREATE_INSTANCE_CALLBACK callback)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000AF0")]
		[Address(RVA = "0x10EDD08", Offset = "0x10EDD08", VA = "0x10EDD08")]
		public RESULT getUserData(out IntPtr userdata)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000AF1")]
		[Address(RVA = "0x10EDD10", Offset = "0x10EDD10", VA = "0x10EDD10")]
		public RESULT setUserData(IntPtr userdata)
		{
			return default(RESULT);
		}

		[PreserveSig]
		[Token(Token = "0x6000AF2")]
		[Address(RVA = "0x17FA040", Offset = "0x17FA040", VA = "0x17FA040")]
		private static extern bool FMOD_Studio_CommandReplay_IsValid(IntPtr replay);

		[PreserveSig]
		[Token(Token = "0x6000AF3")]
		[Address(RVA = "0x17F9018", Offset = "0x17F9018", VA = "0x17F9018")]
		private static extern RESULT FMOD_Studio_CommandReplay_GetSystem(IntPtr replay, out IntPtr system);

		[PreserveSig]
		[Token(Token = "0x6000AF4")]
		[Address(RVA = "0x17F90B0", Offset = "0x17F90B0", VA = "0x17F90B0")]
		private static extern RESULT FMOD_Studio_CommandReplay_GetLength(IntPtr replay, out float length);

		[PreserveSig]
		[Token(Token = "0x6000AF5")]
		[Address(RVA = "0x17F9148", Offset = "0x17F9148", VA = "0x17F9148")]
		private static extern RESULT FMOD_Studio_CommandReplay_GetCommandCount(IntPtr replay, out int count);

		[PreserveSig]
		[Token(Token = "0x6000AF6")]
		[Address(RVA = "0x17F91E0", Offset = "0x17F91E0", VA = "0x17F91E0")]
		private static extern RESULT FMOD_Studio_CommandReplay_GetCommandInfo(IntPtr replay, int commandindex, out COMMAND_INFO info);

		[PreserveSig]
		[Token(Token = "0x6000AF7")]
		[Address(RVA = "0x17F94B8", Offset = "0x17F94B8", VA = "0x17F94B8")]
		private static extern RESULT FMOD_Studio_CommandReplay_GetCommandString(IntPtr replay, int commandIndex, IntPtr buffer, int length);

		[PreserveSig]
		[Token(Token = "0x6000AF8")]
		[Address(RVA = "0x17F9568", Offset = "0x17F9568", VA = "0x17F9568")]
		private static extern RESULT FMOD_Studio_CommandReplay_GetCommandAtTime(IntPtr replay, float time, out int commandIndex);

		[PreserveSig]
		[Token(Token = "0x6000AF9")]
		[Address(RVA = "0x17F9750", Offset = "0x17F9750", VA = "0x17F9750")]
		private static extern RESULT FMOD_Studio_CommandReplay_SetBankPath(IntPtr replay, byte[] bankPath);

		[PreserveSig]
		[Token(Token = "0x6000AFA")]
		[Address(RVA = "0x17F97F0", Offset = "0x17F97F0", VA = "0x17F97F0")]
		private static extern RESULT FMOD_Studio_CommandReplay_Start(IntPtr replay);

		[PreserveSig]
		[Token(Token = "0x6000AFB")]
		[Address(RVA = "0x17F9878", Offset = "0x17F9878", VA = "0x17F9878")]
		private static extern RESULT FMOD_Studio_CommandReplay_Stop(IntPtr replay);

		[PreserveSig]
		[Token(Token = "0x6000AFC")]
		[Address(RVA = "0x17F9900", Offset = "0x17F9900", VA = "0x17F9900")]
		private static extern RESULT FMOD_Studio_CommandReplay_SeekToTime(IntPtr replay, float time);

		[PreserveSig]
		[Token(Token = "0x6000AFD")]
		[Address(RVA = "0x17F9998", Offset = "0x17F9998", VA = "0x17F9998")]
		private static extern RESULT FMOD_Studio_CommandReplay_SeekToCommand(IntPtr replay, int commandIndex);

		[PreserveSig]
		[Token(Token = "0x6000AFE")]
		[Address(RVA = "0x17F9A30", Offset = "0x17F9A30", VA = "0x17F9A30")]
		private static extern RESULT FMOD_Studio_CommandReplay_GetPaused(IntPtr replay, out bool paused);

		[PreserveSig]
		[Token(Token = "0x6000AFF")]
		[Address(RVA = "0x17F9AE0", Offset = "0x17F9AE0", VA = "0x17F9AE0")]
		private static extern RESULT FMOD_Studio_CommandReplay_SetPaused(IntPtr replay, bool paused);

		[PreserveSig]
		[Token(Token = "0x6000B00")]
		[Address(RVA = "0x17F9B78", Offset = "0x17F9B78", VA = "0x17F9B78")]
		private static extern RESULT FMOD_Studio_CommandReplay_GetPlaybackState(IntPtr replay, out PLAYBACK_STATE state);

		[PreserveSig]
		[Token(Token = "0x6000B01")]
		[Address(RVA = "0x17F9C10", Offset = "0x17F9C10", VA = "0x17F9C10")]
		private static extern RESULT FMOD_Studio_CommandReplay_GetCurrentCommand(IntPtr replay, out int commandIndex, out float currentTime);

		[PreserveSig]
		[Token(Token = "0x6000B02")]
		[Address(RVA = "0x17F9CB0", Offset = "0x17F9CB0", VA = "0x17F9CB0")]
		private static extern RESULT FMOD_Studio_CommandReplay_Release(IntPtr replay);

		[PreserveSig]
		[Token(Token = "0x6000B03")]
		[Address(RVA = "0x17F9D38", Offset = "0x17F9D38", VA = "0x17F9D38")]
		private static extern RESULT FMOD_Studio_CommandReplay_SetFrameCallback(IntPtr replay, COMMANDREPLAY_FRAME_CALLBACK callback);

		[PreserveSig]
		[Token(Token = "0x6000B04")]
		[Address(RVA = "0x17F9DD8", Offset = "0x17F9DD8", VA = "0x17F9DD8")]
		private static extern RESULT FMOD_Studio_CommandReplay_SetLoadBankCallback(IntPtr replay, COMMANDREPLAY_LOAD_BANK_CALLBACK callback);

		[PreserveSig]
		[Token(Token = "0x6000B05")]
		[Address(RVA = "0x17F9E78", Offset = "0x17F9E78", VA = "0x17F9E78")]
		private static extern RESULT FMOD_Studio_CommandReplay_SetCreateInstanceCallback(IntPtr replay, COMMANDREPLAY_CREATE_INSTANCE_CALLBACK callback);

		[PreserveSig]
		[Token(Token = "0x6000B06")]
		[Address(RVA = "0x17F9F18", Offset = "0x17F9F18", VA = "0x17F9F18")]
		private static extern RESULT FMOD_Studio_CommandReplay_GetUserData(IntPtr replay, out IntPtr userdata);

		[PreserveSig]
		[Token(Token = "0x6000B07")]
		[Address(RVA = "0x17F9FB0", Offset = "0x17F9FB0", VA = "0x17F9FB0")]
		private static extern RESULT FMOD_Studio_CommandReplay_SetUserData(IntPtr replay, IntPtr userdata);

		[Token(Token = "0x6000B08")]
		[Address(RVA = "0x10EDD18", Offset = "0x10EDD18", VA = "0x10EDD18")]
		public bool hasHandle()
		{
			return default(bool);
		}

		[Token(Token = "0x6000B09")]
		[Address(RVA = "0x10EDD20", Offset = "0x10EDD20", VA = "0x10EDD20")]
		public void clearHandle()
		{
		}

		[Token(Token = "0x6000B0A")]
		[Address(RVA = "0x10EDD64", Offset = "0x10EDD64", VA = "0x10EDD64")]
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
		[Address(RVA = "0x24B8FDC", Offset = "0x24B8FDC", VA = "0x24B8FDC")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000B0C")]
		[Address(RVA = "0x24B9174", Offset = "0x24B9174", VA = "0x24B9174")]
		public FMODRuntimeManagerOnGUIHelper()
		{
		}
	}
	[Token(Token = "0x2000166")]
	public class BankRefAttribute : PropertyAttribute
	{
		[Token(Token = "0x6000B0D")]
		[Address(RVA = "0x24B8B00", Offset = "0x24B8B00", VA = "0x24B8B00")]
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
		[Address(RVA = "0x24B8BBC", Offset = "0x24B8BBC", VA = "0x24B8BBC")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000B0F")]
		[Address(RVA = "0x24B8BCC", Offset = "0x24B8BCC", VA = "0x24B8BCC")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000B10")]
		[Address(RVA = "0x24B8BDC", Offset = "0x24B8BDC", VA = "0x24B8BDC")]
		private void OnTriggerEnter(Collider other)
		{
		}

		[Token(Token = "0x6000B11")]
		[Address(RVA = "0x24B8C44", Offset = "0x24B8C44", VA = "0x24B8C44")]
		private void OnTriggerExit(Collider other)
		{
		}

		[Token(Token = "0x6000B12")]
		[Address(RVA = "0x24B8CAC", Offset = "0x24B8CAC", VA = "0x24B8CAC")]
		private void OnTriggerEnter2D(Collider2D other)
		{
		}

		[Token(Token = "0x6000B13")]
		[Address(RVA = "0x24B8D14", Offset = "0x24B8D14", VA = "0x24B8D14")]
		private void OnTriggerExit2D(Collider2D other)
		{
		}

		[Token(Token = "0x6000B14")]
		[Address(RVA = "0x24B8D7C", Offset = "0x24B8D7C", VA = "0x24B8D7C")]
		private void OnCollisionEnter()
		{
		}

		[Token(Token = "0x6000B15")]
		[Address(RVA = "0x24B8D8C", Offset = "0x24B8D8C", VA = "0x24B8D8C")]
		private void OnCollisionExit()
		{
		}

		[Token(Token = "0x6000B16")]
		[Address(RVA = "0x24B8D9C", Offset = "0x24B8D9C", VA = "0x24B8D9C")]
		private void OnCollisionEnter2D()
		{
		}

		[Token(Token = "0x6000B17")]
		[Address(RVA = "0x24B8DAC", Offset = "0x24B8DAC", VA = "0x24B8DAC")]
		private void OnCollisionExit2D()
		{
		}

		[Token(Token = "0x6000B18")]
		[Address(RVA = "0x24B8DBC", Offset = "0x24B8DBC", VA = "0x24B8DBC")]
		private void OnMouseEnter()
		{
		}

		[Token(Token = "0x6000B19")]
		[Address(RVA = "0x24B8DCC", Offset = "0x24B8DCC", VA = "0x24B8DCC")]
		private void OnMouseExit()
		{
		}

		[Token(Token = "0x6000B1A")]
		[Address(RVA = "0x24B8DDC", Offset = "0x24B8DDC", VA = "0x24B8DDC")]
		private void OnMouseDown()
		{
		}

		[Token(Token = "0x6000B1B")]
		[Address(RVA = "0x24B8DEC", Offset = "0x24B8DEC", VA = "0x24B8DEC")]
		private void OnMouseUp()
		{
		}

		[Token(Token = "0x6000B1C")]
		protected abstract void HandleGameEvent(EmitterGameEvent gameEvent);

		[Token(Token = "0x6000B1D")]
		[Address(RVA = "0x24B8DFC", Offset = "0x24B8DFC", VA = "0x24B8DFC")]
		protected EventHandler()
		{
		}
	}
	[Token(Token = "0x2000168")]
	public class EventRefAttribute : PropertyAttribute
	{
		[Token(Token = "0x6000B1E")]
		[Address(RVA = "0x24B8FD4", Offset = "0x24B8FD4", VA = "0x24B8FD4")]
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
		[Address(RVA = "0x24B917C", Offset = "0x24B917C", VA = "0x24B917C")]
		public ParamRef()
		{
		}
	}
	[Token(Token = "0x200016A")]
	public class ParamRefAttribute : PropertyAttribute
	{
		[Token(Token = "0x6000B20")]
		[Address(RVA = "0x24B9184", Offset = "0x24B9184", VA = "0x24B9184")]
		public ParamRefAttribute()
		{
		}
	}
	[Token(Token = "0x200016B")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x1441F84", Offset = "0x1441F84")]
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
			[Address(RVA = "0x24BF3F0", Offset = "0x24BF3F0", VA = "0x24BF3F0", Slot = "4")]
			private bool System.Collections.Generic.IEqualityComparer<System.Guid>.Equals(Guid x, Guid y)
			{
				return default(bool);
			}

			[Token(Token = "0x6000D47")]
			[Address(RVA = "0x24BF424", Offset = "0x24BF424", VA = "0x24BF424", Slot = "5")]
			private int System.Collections.Generic.IEqualityComparer<System.Guid>.GetHashCode(Guid obj)
			{
				return default(int);
			}

			[Token(Token = "0x6000D48")]
			[Address(RVA = "0x24BF010", Offset = "0x24BF010", VA = "0x24BF010")]
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
			[Address(RVA = "0x24BC380", Offset = "0x24BC380", VA = "0x24BC380")]
			public AttachedInstance()
			{
			}
		}

		[Token(Token = "0x20001D7")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1442144", Offset = "0x1442144")]
		private sealed class <>c__DisplayClass28_0
		{
			[Token(Token = "0x4000BB3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public EventInstance instance;

			[Token(Token = "0x6000D4A")]
			[Address(RVA = "0x24BC378", Offset = "0x24BC378", VA = "0x24BC378")]
			public <>c__DisplayClass28_0()
			{
			}

			[Token(Token = "0x6000D4B")]
			[Address(RVA = "0x24BF0A0", Offset = "0x24BF0A0", VA = "0x24BF0A0")]
			internal bool <AttachInstanceToGameObject>b__0(AttachedInstance x)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x20001D8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1442154", Offset = "0x1442154")]
		private sealed class <>c__DisplayClass29_0
		{
			[Token(Token = "0x4000BB4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public EventInstance instance;

			[Token(Token = "0x6000D4C")]
			[Address(RVA = "0x24BC388", Offset = "0x24BC388", VA = "0x24BC388")]
			public <>c__DisplayClass29_0()
			{
			}

			[Token(Token = "0x6000D4D")]
			[Address(RVA = "0x24BF0C4", Offset = "0x24BF0C4", VA = "0x24BF0C4")]
			internal bool <AttachInstanceToGameObject>b__0(AttachedInstance x)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x20001D9")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1442164", Offset = "0x1442164")]
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
				[Address(RVA = "0x24BF380", Offset = "0x24BF380", VA = "0x24BF380", Slot = "4")]
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
				[Address(RVA = "0x24BF3E8", Offset = "0x24BF3E8", VA = "0x24BF3E8", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000D4E")]
			[Address(RVA = "0x24BCE80", Offset = "0x24BCE80", VA = "0x24BCE80")]
			[DebuggerHidden]
			public <loadFromWeb>d__43(int <>1__state)
			{
			}

			[Token(Token = "0x6000D4F")]
			[Address(RVA = "0x24BF0E8", Offset = "0x24BF0E8", VA = "0x24BF0E8", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000D50")]
			[Address(RVA = "0x24BF0EC", Offset = "0x24BF0EC", VA = "0x24BF0EC", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000D52")]
			[Address(RVA = "0x24BF388", Offset = "0x24BF388", VA = "0x24BF388", Slot = "8")]
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
			[Address(RVA = "0x24BA4FC", Offset = "0x24BA4FC", VA = "0x24BA4FC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000070")]
		public static FMOD.Studio.System StudioSystem
		{
			[Token(Token = "0x6000B24")]
			[Address(RVA = "0x24B7AD0", Offset = "0x24B7AD0", VA = "0x24B7AD0")]
			get
			{
				return default(FMOD.Studio.System);
			}
		}

		[Token(Token = "0x17000071")]
		public static FMOD.System CoreSystem
		{
			[Token(Token = "0x6000B25")]
			[Address(RVA = "0x24BA638", Offset = "0x24BA638", VA = "0x24BA638")]
			get
			{
				return default(FMOD.System);
			}
		}

		[Token(Token = "0x17000072")]
		public static bool IsInitialized
		{
			[Token(Token = "0x6000B4F")]
			[Address(RVA = "0x24BECBC", Offset = "0x24BECBC", VA = "0x24BECBC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000073")]
		public static bool HasBanksLoaded
		{
			[Token(Token = "0x6000B50")]
			[Address(RVA = "0x24BEB70", Offset = "0x24BEB70", VA = "0x24BEB70")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000B21")]
		[Address(RVA = "0x24B9284", Offset = "0x24B9284", VA = "0x24B9284")]
		[AttributeAttribute(Name = "MonoPInvokeCallbackAttribute", RVA = "0x144B8E0", Offset = "0x144B8E0")]
		private static RESULT DEBUG_CALLBACK(DEBUG_FLAGS flags, StringWrapper file, int line, StringWrapper func, StringWrapper message)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000B22")]
		[Address(RVA = "0x24B9448", Offset = "0x24B9448", VA = "0x24B9448")]
		public static void Initialise()
		{
		}

		[Token(Token = "0x6000B26")]
		[Address(RVA = "0x24BA6A4", Offset = "0x24BA6A4", VA = "0x24BA6A4")]
		private void CheckInitResult(RESULT result, string cause)
		{
		}

		[Token(Token = "0x6000B27")]
		[Address(RVA = "0x24B9E34", Offset = "0x24B9E34", VA = "0x24B9E34")]
		private RESULT Initialize()
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000B28")]
		[Address(RVA = "0x24BB558", Offset = "0x24BB558", VA = "0x24BB558")]
		public static int AddListener(StudioListener listener)
		{
			return default(int);
		}

		[Token(Token = "0x6000B29")]
		[Address(RVA = "0x24BB960", Offset = "0x24BB960", VA = "0x24BB960")]
		public static bool RemoveListener(StudioListener listener)
		{
			return default(bool);
		}

		[Token(Token = "0x6000B2A")]
		[Address(RVA = "0x24BBC84", Offset = "0x24BBC84", VA = "0x24BBC84")]
		private void Update()
		{
		}

		[Token(Token = "0x6000B2B")]
		[Address(RVA = "0x24B7FB0", Offset = "0x24B7FB0", VA = "0x24B7FB0")]
		public static void AttachInstanceToGameObject(EventInstance instance, Transform transform, Rigidbody rigidBody)
		{
		}

		[Token(Token = "0x6000B2C")]
		[Address(RVA = "0x24B8154", Offset = "0x24B8154", VA = "0x24B8154")]
		public static void AttachInstanceToGameObject(EventInstance instance, Transform transform, Rigidbody2D rigidBody2D)
		{
		}

		[Token(Token = "0x6000B2D")]
		[Address(RVA = "0x24BC390", Offset = "0x24BC390", VA = "0x24BC390")]
		public static void DetachInstanceFromGameObject(EventInstance instance)
		{
		}

		[Token(Token = "0x6000B2E")]
		[Address(RVA = "0x24B9068", Offset = "0x24B9068", VA = "0x24B9068")]
		public void ExecuteOnGUI()
		{
		}

		[Token(Token = "0x6000B2F")]
		[Address(RVA = "0x24BC48C", Offset = "0x24BC48C", VA = "0x24BC48C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000B30")]
		[Address(RVA = "0x24BC59C", Offset = "0x24BC59C", VA = "0x24BC59C")]
		private void DrawDebugOverlay(int windowID)
		{
		}

		[Token(Token = "0x6000B31")]
		[Address(RVA = "0x24BC9EC", Offset = "0x24BC9EC", VA = "0x24BC9EC")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000B32")]
		[Address(RVA = "0x24BCA5C", Offset = "0x24BCA5C", VA = "0x24BCA5C")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000B33")]
		[Address(RVA = "0x24BCB00", Offset = "0x24BCB00", VA = "0x24BCB00")]
		private void OnApplicationPause(bool pauseStatus)
		{
		}

		[Token(Token = "0x6000B34")]
		[Address(RVA = "0x24BCC70", Offset = "0x24BCC70", VA = "0x24BCC70")]
		private void loadedBankRegister(LoadedBank loadedBank, string bankPath, string bankName, bool loadSamples, RESULT loadResult)
		{
		}

		[Token(Token = "0x6000B35")]
		[Address(RVA = "0x24BCDE8", Offset = "0x24BCDE8", VA = "0x24BCDE8")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x144B944", Offset = "0x144B944")]
		private IEnumerator loadFromWeb(string bankPath, string bankName, bool loadSamples)
		{
			return null;
		}

		[Token(Token = "0x6000B36")]
		[Address(RVA = "0x24BCEAC", Offset = "0x24BCEAC", VA = "0x24BCEAC")]
		public static void LoadBank(string bankName, bool loadSamples = false)
		{
		}

		[Token(Token = "0x6000B37")]
		[Address(RVA = "0x24BD3B8", Offset = "0x24BD3B8", VA = "0x24BD3B8")]
		public static void LoadBank(TextAsset asset, bool loadSamples = false)
		{
		}

		[Token(Token = "0x6000B38")]
		[Address(RVA = "0x24BB0E0", Offset = "0x24BB0E0", VA = "0x24BB0E0")]
		private void LoadBanks(Settings fmodSettings)
		{
		}

		[Token(Token = "0x6000B39")]
		[Address(RVA = "0x24BD678", Offset = "0x24BD678", VA = "0x24BD678")]
		public static void UnloadBank(string bankName)
		{
		}

		[Token(Token = "0x6000B3A")]
		[Address(RVA = "0x24BD7B0", Offset = "0x24BD7B0", VA = "0x24BD7B0")]
		public static bool AnyBankLoading()
		{
			return default(bool);
		}

		[Token(Token = "0x6000B3B")]
		[Address(RVA = "0x24BD608", Offset = "0x24BD608", VA = "0x24BD608")]
		public static void WaitForAllLoads()
		{
		}

		[Token(Token = "0x6000B3C")]
		[Address(RVA = "0x24BD900", Offset = "0x24BD900", VA = "0x24BD900")]
		public static Guid PathToGUID(string path)
		{
			return default(Guid);
		}

		[Token(Token = "0x6000B3D")]
		[Address(RVA = "0x24B7EA0", Offset = "0x24B7EA0", VA = "0x24B7EA0")]
		public static EventInstance CreateInstance(string path)
		{
			return default(EventInstance);
		}

		[Token(Token = "0x6000B3E")]
		[Address(RVA = "0x24BDA28", Offset = "0x24BDA28", VA = "0x24BDA28")]
		public static EventInstance CreateInstance(Guid guid)
		{
			return default(EventInstance);
		}

		[Token(Token = "0x6000B3F")]
		[Address(RVA = "0x24BDCC8", Offset = "0x24BDCC8", VA = "0x24BDCC8")]
		public static void PlayOneShot(string path, [Optional] Vector3 position)
		{
		}

		[Token(Token = "0x6000B40")]
		[Address(RVA = "0x24BDE2C", Offset = "0x24BDE2C", VA = "0x24BDE2C")]
		public static void PlayOneShot(Guid guid, [Optional] Vector3 position)
		{
		}

		[Token(Token = "0x6000B41")]
		[Address(RVA = "0x24BDF0C", Offset = "0x24BDF0C", VA = "0x24BDF0C")]
		public static void PlayOneShotAttached(string path, GameObject gameObject)
		{
		}

		[Token(Token = "0x6000B42")]
		[Address(RVA = "0x24BE054", Offset = "0x24BE054", VA = "0x24BE054")]
		public static void PlayOneShotAttached(Guid guid, GameObject gameObject)
		{
		}

		[Token(Token = "0x6000B43")]
		[Address(RVA = "0x24BE138", Offset = "0x24BE138", VA = "0x24BE138")]
		public static EventDescription GetEventDescription(string path)
		{
			return default(EventDescription);
		}

		[Token(Token = "0x6000B44")]
		[Address(RVA = "0x24BDAC4", Offset = "0x24BDAC4", VA = "0x24BDAC4")]
		public static EventDescription GetEventDescription(Guid guid)
		{
			return default(EventDescription);
		}

		[Token(Token = "0x6000B45")]
		[Address(RVA = "0x24BE248", Offset = "0x24BE248", VA = "0x24BE248")]
		public static void SetListenerLocation(GameObject gameObject, [Optional] Rigidbody rigidBody)
		{
		}

		[Token(Token = "0x6000B46")]
		[Address(RVA = "0x24BE420", Offset = "0x24BE420", VA = "0x24BE420")]
		public static void SetListenerLocation(GameObject gameObject, Rigidbody2D rigidBody2D)
		{
		}

		[Token(Token = "0x6000B47")]
		[Address(RVA = "0x24BE604", Offset = "0x24BE604", VA = "0x24BE604")]
		public static void SetListenerLocation(Transform transform)
		{
		}

		[Token(Token = "0x6000B48")]
		[Address(RVA = "0x24BE748", Offset = "0x24BE748", VA = "0x24BE748")]
		public static void SetListenerLocation(int listenerIndex, GameObject gameObject, [Optional] Rigidbody rigidBody)
		{
		}

		[Token(Token = "0x6000B49")]
		[Address(RVA = "0x24BE7F4", Offset = "0x24BE7F4", VA = "0x24BE7F4")]
		public static void SetListenerLocation(int listenerIndex, GameObject gameObject, Rigidbody2D rigidBody2D)
		{
		}

		[Token(Token = "0x6000B4A")]
		[Address(RVA = "0x24BE8A0", Offset = "0x24BE8A0", VA = "0x24BE8A0")]
		public static void SetListenerLocation(int listenerIndex, Transform transform)
		{
		}

		[Token(Token = "0x6000B4B")]
		[Address(RVA = "0x24BE944", Offset = "0x24BE944", VA = "0x24BE944")]
		public static Bus GetBus(string path)
		{
			return default(Bus);
		}

		[Token(Token = "0x6000B4C")]
		[Address(RVA = "0x24BEA04", Offset = "0x24BEA04", VA = "0x24BEA04")]
		public static VCA GetVCA(string path)
		{
			return default(VCA);
		}

		[Token(Token = "0x6000B4D")]
		[Address(RVA = "0x24BCBAC", Offset = "0x24BCBAC", VA = "0x24BCBAC")]
		public static void PauseAllEvents(bool paused)
		{
		}

		[Token(Token = "0x6000B4E")]
		[Address(RVA = "0x24BEBF8", Offset = "0x24BEBF8", VA = "0x24BEBF8")]
		public static void MuteAllEvents(bool muted)
		{
		}

		[Token(Token = "0x6000B51")]
		[Address(RVA = "0x24BEDA0", Offset = "0x24BEDA0", VA = "0x24BEDA0")]
		public static bool HasBankLoaded(string loadedBank)
		{
			return default(bool);
		}

		[Token(Token = "0x6000B52")]
		[Address(RVA = "0x24BAF3C", Offset = "0x24BAF3C", VA = "0x24BAF3C")]
		private void LoadPlugins(Settings fmodSettings)
		{
		}

		[Token(Token = "0x6000B53")]
		[Address(RVA = "0x24BAE2C", Offset = "0x24BAE2C", VA = "0x24BAE2C")]
		private void SetThreadAffinity()
		{
		}

		[Token(Token = "0x6000B54")]
		[Address(RVA = "0x24BEEA8", Offset = "0x24BEEA8", VA = "0x24BEEA8")]
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
		[Address(RVA = "0x24B8E54", Offset = "0x24B8E54", VA = "0x24B8E54")]
		public EventNotFoundException(string path)
		{
		}

		[Token(Token = "0x6000B57")]
		[Address(RVA = "0x24B8F00", Offset = "0x24B8F00", VA = "0x24B8F00")]
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
		[Address(RVA = "0x24B8B08", Offset = "0x24B8B08", VA = "0x24B8B08")]
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
		[Address(RVA = "0x24BEAC4", Offset = "0x24BEAC4", VA = "0x24BEAC4")]
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
		[Address(RVA = "0x24B8948", Offset = "0x24B8948", VA = "0x24B8948")]
		public BankLoadException(string path, RESULT result)
		{
		}

		[Token(Token = "0x6000B5B")]
		[Address(RVA = "0x24B8A50", Offset = "0x24B8A50", VA = "0x24B8A50")]
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
		[Address(RVA = "0x24BA3F4", Offset = "0x24BA3F4", VA = "0x24BA3F4")]
		public SystemNotInitializedException(RESULT result, string location)
		{
		}

		[Token(Token = "0x6000B5D")]
		[Address(RVA = "0x24BA370", Offset = "0x24BA370", VA = "0x24BA370")]
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
		[Address(RVA = "0x24BF44C", Offset = "0x24BF44C", VA = "0x24BF44C")]
		public static string GetCommonPlatformPath(string path)
		{
			return null;
		}

		[Token(Token = "0x6000B5F")]
		[Address(RVA = "0x24BF49C", Offset = "0x24BF49C", VA = "0x24BF49C")]
		public static VECTOR ToFMODVector(this Vector3 vec)
		{
			return default(VECTOR);
		}

		[Token(Token = "0x6000B60")]
		[Address(RVA = "0x24B82F8", Offset = "0x24B82F8", VA = "0x24B82F8")]
		public static ATTRIBUTES_3D To3DAttributes(this Vector3 pos)
		{
			return default(ATTRIBUTES_3D);
		}

		[Token(Token = "0x6000B61")]
		[Address(RVA = "0x24BE69C", Offset = "0x24BE69C", VA = "0x24BE69C")]
		public static ATTRIBUTES_3D To3DAttributes(this Transform transform)
		{
			return default(ATTRIBUTES_3D);
		}

		[Token(Token = "0x6000B62")]
		[Address(RVA = "0x24BC124", Offset = "0x24BC124", VA = "0x24BC124")]
		public static ATTRIBUTES_3D To3DAttributes(Transform transform, [Optional] Rigidbody rigidbody)
		{
			return default(ATTRIBUTES_3D);
		}

		[Token(Token = "0x6000B63")]
		[Address(RVA = "0x24BE2F0", Offset = "0x24BE2F0", VA = "0x24BE2F0")]
		public static ATTRIBUTES_3D To3DAttributes(GameObject go, [Optional] Rigidbody rigidbody)
		{
			return default(ATTRIBUTES_3D);
		}

		[Token(Token = "0x6000B64")]
		[Address(RVA = "0x24BC248", Offset = "0x24BC248", VA = "0x24BC248")]
		public static ATTRIBUTES_3D To3DAttributes(Transform transform, Rigidbody2D rigidbody)
		{
			return default(ATTRIBUTES_3D);
		}

		[Token(Token = "0x6000B65")]
		[Address(RVA = "0x24BE4C8", Offset = "0x24BE4C8", VA = "0x24BE4C8")]
		public static ATTRIBUTES_3D To3DAttributes(GameObject go, Rigidbody2D rigidbody)
		{
			return default(ATTRIBUTES_3D);
		}

		[Token(Token = "0x6000B66")]
		[Address(RVA = "0x24BA968", Offset = "0x24BA968", VA = "0x24BA968")]
		internal static FMODPlatform GetCurrentPlatform()
		{
			return default(FMODPlatform);
		}

		[Token(Token = "0x6000B67")]
		[Address(RVA = "0x24BD284", Offset = "0x24BD284", VA = "0x24BD284")]
		internal static string GetBankPath(string bankName)
		{
			return null;
		}

		[Token(Token = "0x6000B68")]
		[Address(RVA = "0x24BEE2C", Offset = "0x24BEE2C", VA = "0x24BEE2C")]
		internal static string GetPluginPath(string pluginName)
		{
			return null;
		}

		[Token(Token = "0x6000B69")]
		[Address(RVA = "0x24B9CAC", Offset = "0x24B9CAC", VA = "0x24B9CAC")]
		public static void EnforceLibraryOrder()
		{
		}

		[Token(Token = "0x6000B6A")]
		[Address(RVA = "0x24B9B94", Offset = "0x24B9B94", VA = "0x24B9B94")]
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
		[Address(RVA = "0x24B922C", Offset = "0x24B922C", VA = "0x24B922C")]
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
		[Address(RVA = "0x24B91DC", Offset = "0x24B91DC", VA = "0x24B91DC")]
		public PlatformIntSetting()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200017A")]
	public class PlatformStringSetting : PlatformSetting<string>
	{
		[Token(Token = "0x6000B6E")]
		[Address(RVA = "0x24B9234", Offset = "0x24B9234", VA = "0x24B9234")]
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
		[Address(RVA = "0x24B918C", Offset = "0x24B918C", VA = "0x24B918C")]
		public PlatformBoolSetting()
		{
		}
	}
	[Token(Token = "0x200017D")]
	public class Settings : ScriptableObject
	{
		[Token(Token = "0x20001DA")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1442174", Offset = "0x1442174")]
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
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1442184", Offset = "0x1442184")]
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
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1442194", Offset = "0x1442194")]
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
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x14421A4", Offset = "0x14421A4")]
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
			[Address(RVA = "0x24BA758", Offset = "0x24BA758", VA = "0x24BA758")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000075")]
		public string SourceProjectPath
		{
			[Token(Token = "0x6000B71")]
			[Address(RVA = "0x24BF4A0", Offset = "0x24BF4A0", VA = "0x24BF4A0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000B72")]
			[Address(RVA = "0x24BF4A8", Offset = "0x24BF4A8", VA = "0x24BF4A8")]
			set
			{
			}
		}

		[Token(Token = "0x17000076")]
		public string SourceBankPath
		{
			[Token(Token = "0x6000B73")]
			[Address(RVA = "0x24BF4B0", Offset = "0x24BF4B0", VA = "0x24BF4B0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000B74")]
			[Address(RVA = "0x24BF4B8", Offset = "0x24BF4B8", VA = "0x24BF4B8")]
			set
			{
			}
		}

		[Token(Token = "0x6000B75")]
		[Address(RVA = "0x24BF4C0", Offset = "0x24BF4C0", VA = "0x24BF4C0")]
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
		[Address(RVA = "0x24BAEA8", Offset = "0x24BAEA8", VA = "0x24BAEA8")]
		public bool IsLiveUpdateEnabled(FMODPlatform platform)
		{
			return default(bool);
		}

		[Token(Token = "0x6000B7B")]
		[Address(RVA = "0x24BC508", Offset = "0x24BC508", VA = "0x24BC508")]
		public bool IsOverlayEnabled(FMODPlatform platform)
		{
			return default(bool);
		}

		[Token(Token = "0x6000B7C")]
		[Address(RVA = "0x24BAC94", Offset = "0x24BAC94", VA = "0x24BAC94")]
		public int GetRealChannels(FMODPlatform platform)
		{
			return default(int);
		}

		[Token(Token = "0x6000B7D")]
		[Address(RVA = "0x24BAD1C", Offset = "0x24BAD1C", VA = "0x24BAD1C")]
		public int GetVirtualChannels(FMODPlatform platform)
		{
			return default(int);
		}

		[Token(Token = "0x6000B7E")]
		[Address(RVA = "0x24BADA4", Offset = "0x24BADA4", VA = "0x24BADA4")]
		public int GetSpeakerMode(FMODPlatform platform)
		{
			return default(int);
		}

		[Token(Token = "0x6000B7F")]
		[Address(RVA = "0x24BAC0C", Offset = "0x24BAC0C", VA = "0x24BAC0C")]
		public int GetSampleRate(FMODPlatform platform)
		{
			return default(int);
		}

		[Token(Token = "0x6000B80")]
		[Address(RVA = "0x24BF4E4", Offset = "0x24BF4E4", VA = "0x24BF4E4")]
		public string GetBankPlatform(FMODPlatform platform)
		{
			return null;
		}

		[Token(Token = "0x6000B81")]
		[Address(RVA = "0x24BF590", Offset = "0x24BF590", VA = "0x24BF590")]
		private Settings()
		{
		}
	}
	[Token(Token = "0x200017E")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x1441FCC", Offset = "0x1441FCC")]
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
		[Address(RVA = "0x24BF8C0", Offset = "0x24BF8C0", VA = "0x24BF8C0")]
		private void HandleGameEvent(LoaderGameEvent gameEvent)
		{
		}

		[Token(Token = "0x6000B84")]
		[Address(RVA = "0x24BFC54", Offset = "0x24BFC54", VA = "0x24BFC54")]
		private void Start()
		{
		}

		[Token(Token = "0x6000B85")]
		[Address(RVA = "0x24BFC7C", Offset = "0x24BFC7C", VA = "0x24BFC7C")]
		private void OnApplicationQuit()
		{
		}

		[Token(Token = "0x6000B86")]
		[Address(RVA = "0x24BFC88", Offset = "0x24BFC88", VA = "0x24BFC88")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000B87")]
		[Address(RVA = "0x24BFC9C", Offset = "0x24BFC9C", VA = "0x24BFC9C")]
		private void OnTriggerEnter(Collider other)
		{
		}

		[Token(Token = "0x6000B88")]
		[Address(RVA = "0x24BFCFC", Offset = "0x24BFCFC", VA = "0x24BFCFC")]
		private void OnTriggerExit(Collider other)
		{
		}

		[Token(Token = "0x6000B89")]
		[Address(RVA = "0x24BFD5C", Offset = "0x24BFD5C", VA = "0x24BFD5C")]
		private void OnTriggerEnter2D(Collider2D other)
		{
		}

		[Token(Token = "0x6000B8A")]
		[Address(RVA = "0x24BFDBC", Offset = "0x24BFDBC", VA = "0x24BFDBC")]
		private void OnTriggerExit2D(Collider2D other)
		{
		}

		[Token(Token = "0x6000B8B")]
		[Address(RVA = "0x24BF910", Offset = "0x24BF910", VA = "0x24BF910")]
		public void Load()
		{
		}

		[Token(Token = "0x6000B8C")]
		[Address(RVA = "0x24BFB40", Offset = "0x24BFB40", VA = "0x24BFB40")]
		public void Unload()
		{
		}

		[Token(Token = "0x6000B8D")]
		[Address(RVA = "0x24BFE1C", Offset = "0x24BFE1C", VA = "0x24BFE1C")]
		public StudioBankLoader()
		{
		}
	}
	[Token(Token = "0x200017F")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x1442004", Offset = "0x1442004")]
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
			[Address(RVA = "0x24BFE24", Offset = "0x24BFE24", VA = "0x24BFE24")]
			get
			{
				return default(EventDescription);
			}
		}

		[Token(Token = "0x17000078")]
		public EventInstance EventInstance
		{
			[Token(Token = "0x6000B8F")]
			[Address(RVA = "0x24BFE2C", Offset = "0x24BFE2C", VA = "0x24BFE2C")]
			get
			{
				return default(EventInstance);
			}
		}

		[Token(Token = "0x6000B90")]
		[Address(RVA = "0x24BFE34", Offset = "0x24BFE34", VA = "0x24BFE34")]
		private void Start()
		{
		}

		[Token(Token = "0x6000B91")]
		[Address(RVA = "0x24C0040", Offset = "0x24C0040", VA = "0x24C0040")]
		private void OnApplicationQuit()
		{
		}

		[Token(Token = "0x6000B92")]
		[Address(RVA = "0x24C004C", Offset = "0x24C004C", VA = "0x24C004C")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000B93")]
		[Address(RVA = "0x24C0140", Offset = "0x24C0140", VA = "0x24C0140", Slot = "4")]
		protected override void HandleGameEvent(EmitterGameEvent gameEvent)
		{
		}

		[Token(Token = "0x6000B94")]
		[Address(RVA = "0x24BFF1C", Offset = "0x24BFF1C", VA = "0x24BFF1C")]
		private void Lookup()
		{
		}

		[Token(Token = "0x6000B95")]
		[Address(RVA = "0x24C0190", Offset = "0x24C0190", VA = "0x24C0190")]
		public void Play()
		{
		}

		[Token(Token = "0x6000B96")]
		[Address(RVA = "0x24C04C4", Offset = "0x24C04C4", VA = "0x24C04C4")]
		public void Stop()
		{
		}

		[Token(Token = "0x6000B97")]
		[Address(RVA = "0x24C0528", Offset = "0x24C0528", VA = "0x24C0528")]
		public void SetParameter(string name, float value, bool ignoreseekspeed = false)
		{
		}

		[Token(Token = "0x6000B98")]
		[Address(RVA = "0x24C0598", Offset = "0x24C0598", VA = "0x24C0598")]
		public void SetParameter(PARAMETER_ID id, float value, bool ignoreseekspeed = false)
		{
		}

		[Token(Token = "0x6000B99")]
		[Address(RVA = "0x24C0608", Offset = "0x24C0608", VA = "0x24C0608")]
		public bool IsPlaying()
		{
			return default(bool);
		}

		[Token(Token = "0x6000B9A")]
		[Address(RVA = "0x24C065C", Offset = "0x24C065C", VA = "0x24C065C")]
		public StudioEventEmitter()
		{
		}
	}
	[Token(Token = "0x2000180")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x144203C", Offset = "0x144203C")]
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
			[Address(RVA = "0x24C06D8", Offset = "0x24C06D8", VA = "0x24C06D8")]
			get
			{
				return default(PARAMETER_DESCRIPTION);
			}
		}

		[Token(Token = "0x6000B9C")]
		[Address(RVA = "0x24C06EC", Offset = "0x24C06EC", VA = "0x24C06EC")]
		private RESULT Lookup()
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000B9D")]
		[Address(RVA = "0x24C0774", Offset = "0x24C0774", VA = "0x24C0774")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000B9E")]
		[Address(RVA = "0x24C07B8", Offset = "0x24C07B8", VA = "0x24C07B8", Slot = "4")]
		protected override void HandleGameEvent(EmitterGameEvent gameEvent)
		{
		}

		[Token(Token = "0x6000B9F")]
		[Address(RVA = "0x24C07CC", Offset = "0x24C07CC", VA = "0x24C07CC")]
		public void TriggerParameters()
		{
		}

		[Token(Token = "0x6000BA0")]
		[Address(RVA = "0x24C08E0", Offset = "0x24C08E0", VA = "0x24C08E0")]
		public StudioGlobalParameterTrigger()
		{
		}
	}
	[Token(Token = "0x2000181")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x1442074", Offset = "0x1442074")]
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
		[Address(RVA = "0x24C08E4", Offset = "0x24C08E4", VA = "0x24C08E4")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000BA2")]
		[Address(RVA = "0x24C09A0", Offset = "0x24C09A0", VA = "0x24C09A0")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000BA3")]
		[Address(RVA = "0x24C0A04", Offset = "0x24C0A04", VA = "0x24C0A04")]
		private void Update()
		{
		}

		[Token(Token = "0x6000BA4")]
		[Address(RVA = "0x24C0A18", Offset = "0x24C0A18", VA = "0x24C0A18")]
		private void SetListenerLocation()
		{
		}

		[Token(Token = "0x6000BA5")]
		[Address(RVA = "0x24C0B14", Offset = "0x24C0B14", VA = "0x24C0B14")]
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
		[Address(RVA = "0x24B8BB4", Offset = "0x24B8BB4", VA = "0x24B8BB4")]
		public EmitterRef()
		{
		}
	}
	[Token(Token = "0x2000183")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x14420AC", Offset = "0x14420AC")]
	public class StudioParameterTrigger : EventHandler
	{
		[Token(Token = "0x400094B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public EmitterRef[] Emitters;

		[Token(Token = "0x400094C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public EmitterGameEvent TriggerEvent;

		[Token(Token = "0x6000BA7")]
		[Address(RVA = "0x24C0B24", Offset = "0x24C0B24", VA = "0x24C0B24")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000BA8")]
		[Address(RVA = "0x24C0D14", Offset = "0x24C0D14", VA = "0x24C0D14", Slot = "4")]
		protected override void HandleGameEvent(EmitterGameEvent gameEvent)
		{
		}

		[Token(Token = "0x6000BA9")]
		[Address(RVA = "0x24C0D28", Offset = "0x24C0D28", VA = "0x24C0D28")]
		public void TriggerParameters()
		{
		}

		[Token(Token = "0x6000BAA")]
		[Address(RVA = "0x24C0EC0", Offset = "0x24C0EC0", VA = "0x24C0EC0")]
		public StudioParameterTrigger()
		{
		}
	}
}
