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
using HellTap.MeshDecimator.Algorithms;
using HellTap.MeshDecimator.Collections;
using HellTap.MeshDecimator.Math;
using HellTap.MeshDecimator.Unity;
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
	[Token(Token = "0x2000132")]
	private struct RoomProperties
	{
		[Token(Token = "0x4000601")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float positionX;

		[Token(Token = "0x4000602")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public float positionY;

		[Token(Token = "0x4000603")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public float positionZ;

		[Token(Token = "0x4000604")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public float rotationX;

		[Token(Token = "0x4000605")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float rotationY;

		[Token(Token = "0x4000606")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public float rotationZ;

		[Token(Token = "0x4000607")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float rotationW;

		[Token(Token = "0x4000608")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float dimensionsX;

		[Token(Token = "0x4000609")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float dimensionsY;

		[Token(Token = "0x400060A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float dimensionsZ;

		[Token(Token = "0x400060B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public FmodResonanceAudioRoom.SurfaceMaterial materialLeft;

		[Token(Token = "0x400060C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public FmodResonanceAudioRoom.SurfaceMaterial materialRight;

		[Token(Token = "0x400060D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public FmodResonanceAudioRoom.SurfaceMaterial materialBottom;

		[Token(Token = "0x400060E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public FmodResonanceAudioRoom.SurfaceMaterial materialTop;

		[Token(Token = "0x400060F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public FmodResonanceAudioRoom.SurfaceMaterial materialFront;

		[Token(Token = "0x4000610")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public FmodResonanceAudioRoom.SurfaceMaterial materialBack;

		[Token(Token = "0x4000611")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float reflectionScalar;

		[Token(Token = "0x4000612")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float reverbGain;

		[Token(Token = "0x4000613")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float reverbTime;

		[Token(Token = "0x4000614")]
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
		[Address(RVA = "0xFCF234", Offset = "0xFCF234", VA = "0xFCF234")]
		get
		{
			return default(DSP);
		}
	}

	[Token(Token = "0x6000001")]
	[Address(RVA = "0xFCEDDC", Offset = "0xFCEDDC", VA = "0xFCEDDC")]
	public static void UpdateAudioRoom(FmodResonanceAudioRoom room, bool roomEnabled)
	{
	}

	[Token(Token = "0x6000002")]
	[Address(RVA = "0xFCF3C8", Offset = "0xFCF3C8", VA = "0xFCF3C8")]
	public static bool IsListenerInsideRoom(FmodResonanceAudioRoom room)
	{
		return default(bool);
	}

	[Token(Token = "0x6000004")]
	[Address(RVA = "0xFCF9F4", Offset = "0xFCF9F4", VA = "0xFCF9F4")]
	private static float ConvertAmplitudeFromDb(float db)
	{
		return default(float);
	}

	[Token(Token = "0x6000005")]
	[Address(RVA = "0xFCFA6C", Offset = "0xFCFA6C", VA = "0xFCFA6C")]
	private static void ConvertAudioTransformFromUnity(ref UnityEngine.Vector3 position, ref Quaternion rotation)
	{
	}

	[Token(Token = "0x6000006")]
	[Address(RVA = "0xFCF2F8", Offset = "0xFCF2F8", VA = "0xFCF2F8")]
	private static byte[] GetBytes(IntPtr ptr, int length)
	{
		return null;
	}

	[Token(Token = "0x6000007")]
	[Address(RVA = "0xFCF068", Offset = "0xFCF068", VA = "0xFCF068")]
	private static RoomProperties GetRoomProperties(FmodResonanceAudioRoom room)
	{
		return default(RoomProperties);
	}

	[Token(Token = "0x6000008")]
	[Address(RVA = "0xFCF630", Offset = "0xFCF630", VA = "0xFCF630")]
	private static DSP Initialize()
	{
		return default(DSP);
	}
}
[Token(Token = "0x2000003")]
[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xC84B04", Offset = "0xC84B04")]
public class FmodResonanceAudioRoom : MonoBehaviour
{
	[Token(Token = "0x2000133")]
	public enum SurfaceMaterial
	{
		[Token(Token = "0x4000616")]
		Transparent,
		[Token(Token = "0x4000617")]
		AcousticCeilingTiles,
		[Token(Token = "0x4000618")]
		BrickBare,
		[Token(Token = "0x4000619")]
		BrickPainted,
		[Token(Token = "0x400061A")]
		ConcreteBlockCoarse,
		[Token(Token = "0x400061B")]
		ConcreteBlockPainted,
		[Token(Token = "0x400061C")]
		CurtainHeavy,
		[Token(Token = "0x400061D")]
		FiberglassInsulation,
		[Token(Token = "0x400061E")]
		GlassThin,
		[Token(Token = "0x400061F")]
		GlassThick,
		[Token(Token = "0x4000620")]
		Grass,
		[Token(Token = "0x4000621")]
		LinoleumOnConcrete,
		[Token(Token = "0x4000622")]
		Marble,
		[Token(Token = "0x4000623")]
		Metal,
		[Token(Token = "0x4000624")]
		ParquetOnConcrete,
		[Token(Token = "0x4000625")]
		PlasterRough,
		[Token(Token = "0x4000626")]
		PlasterSmooth,
		[Token(Token = "0x4000627")]
		PlywoodPanel,
		[Token(Token = "0x4000628")]
		PolishedConcreteOrTile,
		[Token(Token = "0x4000629")]
		Sheetrock,
		[Token(Token = "0x400062A")]
		WaterOrIceSurface,
		[Token(Token = "0x400062B")]
		WoodCeiling,
		[Token(Token = "0x400062C")]
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
	public UnityEngine.Vector3 size;

	[Token(Token = "0x600000A")]
	[Address(RVA = "0xFCFF7C", Offset = "0xFCFF7C", VA = "0xFCFF7C")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x600000B")]
	[Address(RVA = "0xFCFFEC", Offset = "0xFCFFEC", VA = "0xFCFFEC")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x600000C")]
	[Address(RVA = "0xFD0054", Offset = "0xFD0054", VA = "0xFD0054")]
	private void Update()
	{
	}

	[Token(Token = "0x600000D")]
	[Address(RVA = "0xFD00C4", Offset = "0xFD00C4", VA = "0xFD00C4")]
	private void OnDrawGizmosSelected()
	{
	}

	[Token(Token = "0x600000E")]
	[Address(RVA = "0xFD0190", Offset = "0xFD0190", VA = "0xFD0190")]
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
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xC854AC", Offset = "0xC854AC")]
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
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xC85514", Offset = "0xC85514")]
	private TimelineClip <OwningClip>k__BackingField;

	[Token(Token = "0x17000002")]
	public GameObject TrackTargetObject
	{
		[Token(Token = "0x600000F")]
		[Address(RVA = "0xFC5430", Offset = "0xFC5430", VA = "0xFC5430")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xC868B0", Offset = "0xC868B0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000010")]
		[Address(RVA = "0xFC5438", Offset = "0xFC5438", VA = "0xFC5438")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xC868C0", Offset = "0xC868C0")]
		set
		{
		}
	}

	[Token(Token = "0x17000003")]
	public override double duration
	{
		[Token(Token = "0x6000011")]
		[Address(RVA = "0xFC5440", Offset = "0xFC5440", VA = "0xFC5440", Slot = "7")]
		get
		{
			return default(double);
		}
	}

	[Token(Token = "0x17000004")]
	public ClipCaps clipCaps
	{
		[Token(Token = "0x6000012")]
		[Address(RVA = "0xFC545C", Offset = "0xFC545C", VA = "0xFC545C", Slot = "9")]
		get
		{
			return default(ClipCaps);
		}
	}

	[Token(Token = "0x17000005")]
	public TimelineClip OwningClip
	{
		[Token(Token = "0x6000013")]
		[Address(RVA = "0xFC5464", Offset = "0xFC5464", VA = "0xFC5464")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xC868D0", Offset = "0xC868D0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000014")]
		[Address(RVA = "0xFC546C", Offset = "0xFC546C", VA = "0xFC546C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xC868E0", Offset = "0xC868E0")]
		set
		{
		}
	}

	[Token(Token = "0x6000015")]
	[Address(RVA = "0xFC5474", Offset = "0xFC5474", VA = "0xFC5474", Slot = "6")]
	public override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
	{
		return default(Playable);
	}

	[Token(Token = "0x6000016")]
	[Address(RVA = "0xFC571C", Offset = "0xFC571C", VA = "0xFC571C")]
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
	[Address(RVA = "0xFC581C", Offset = "0xFC581C", VA = "0xFC581C")]
	protected void PlayEvent()
	{
	}

	[Token(Token = "0x6000018")]
	[Address(RVA = "0xFC5FF8", Offset = "0xFC5FF8", VA = "0xFC5FF8")]
	public void OnEnter()
	{
	}

	[Token(Token = "0x6000019")]
	[Address(RVA = "0xFC602C", Offset = "0xFC602C", VA = "0xFC602C")]
	public void OnExit()
	{
	}

	[Token(Token = "0x600001A")]
	[Address(RVA = "0xFC53AC", Offset = "0xFC53AC", VA = "0xFC53AC")]
	public void UpdateBehaviour(float time)
	{
	}

	[Token(Token = "0x600001B")]
	[Address(RVA = "0xFC6094", Offset = "0xFC6094", VA = "0xFC6094", Slot = "14")]
	public override void OnGraphStop(Playable playable)
	{
	}

	[Token(Token = "0x600001C")]
	[Address(RVA = "0xFC57B0", Offset = "0xFC57B0", VA = "0xFC57B0")]
	public FMODEventPlayableBehavior()
	{
	}
}
[Token(Token = "0x2000007")]
[AttributeAttribute(Name = "TrackColorAttribute", RVA = "0xC84B3C", Offset = "0xC84B3C")]
[AttributeAttribute(Name = "TrackClipTypeAttribute", RVA = "0xC84B3C", Offset = "0xC84B3C")]
[AttributeAttribute(Name = "TrackBindingTypeAttribute", RVA = "0xC84B3C", Offset = "0xC84B3C")]
public class FMODEventTrack : TrackAsset
{
	[Token(Token = "0x600001D")]
	[Address(RVA = "0xFC6148", Offset = "0xFC6148", VA = "0xFC6148", Slot = "23")]
	public override Playable CreateTrackMixer(PlayableGraph graph, GameObject go, int inputCount)
	{
		return default(Playable);
	}

	[Token(Token = "0x600001E")]
	[Address(RVA = "0xFC653C", Offset = "0xFC653C", VA = "0xFC653C")]
	public FMODEventTrack()
	{
	}
}
[Token(Token = "0x2000008")]
public class FMODEventMixerBehaviour : PlayableBehaviour
{
	[Token(Token = "0x600001F")]
	[Address(RVA = "0xFC5238", Offset = "0xFC5238", VA = "0xFC5238", Slot = "20")]
	public override void ProcessFrame(Playable playable, FrameData info, object playerData)
	{
	}

	[Token(Token = "0x6000020")]
	[Address(RVA = "0xFC5428", Offset = "0xFC5428", VA = "0xFC5428")]
	public FMODEventMixerBehaviour()
	{
	}
}
namespace PlayerLogToErrorLog
{
	[Token(Token = "0x2000009")]
	public static class ProcessStarter
	{
		[Token(Token = "0x2000134")]
		[Flags]
		private enum ProcessAccessRights : uint
		{
			[Token(Token = "0x400062E")]
			PROCESS_CREATE_PROCESS = 0x80u,
			[Token(Token = "0x400062F")]
			PROCESS_CREATE_THREAD = 2u,
			[Token(Token = "0x4000630")]
			PROCESS_DUP_HANDLE = 0x40u,
			[Token(Token = "0x4000631")]
			PROCESS_QUERY_INFORMATION = 0x400u,
			[Token(Token = "0x4000632")]
			PROCESS_QUERY_LIMITED_INFORMATION = 0x1000u,
			[Token(Token = "0x4000633")]
			PROCESS_SET_INFORMATION = 0x200u,
			[Token(Token = "0x4000634")]
			PROCESS_SET_QUOTA = 0x100u,
			[Token(Token = "0x4000635")]
			PROCESS_SUSPEND_RESUME = 0x800u,
			[Token(Token = "0x4000636")]
			PROCESS_TERMINATE = 1u,
			[Token(Token = "0x4000637")]
			PROCESS_VM_OPERATION = 8u,
			[Token(Token = "0x4000638")]
			PROCESS_VM_READ = 0x10u,
			[Token(Token = "0x4000639")]
			PROCESS_VM_WRITE = 0x20u,
			[Token(Token = "0x400063A")]
			DELETE = 0x10000u,
			[Token(Token = "0x400063B")]
			READ_CONTROL = 0x20000u,
			[Token(Token = "0x400063C")]
			SYNCHRONIZE = 0x100000u,
			[Token(Token = "0x400063D")]
			WRITE_DAC = 0x40000u,
			[Token(Token = "0x400063E")]
			WRITE_OWNER = 0x80000u,
			[Token(Token = "0x400063F")]
			STANDARD_RIGHTS_REQUIRED = 0xF0000u,
			[Token(Token = "0x4000640")]
			PROCESS_ALL_ACCESS = 0x1F0FFFu
		}

		[Token(Token = "0x2000135")]
		private struct PROCESS_INFORMATION
		{
			[Token(Token = "0x4000641")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal IntPtr hProcess;

			[Token(Token = "0x4000642")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			internal IntPtr hThread;

			[Token(Token = "0x4000643")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal uint dwProcessId;

			[Token(Token = "0x4000644")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			internal uint dwThreadId;
		}

		[Token(Token = "0x2000136")]
		private struct STARTUPINFO
		{
			[Token(Token = "0x4000645")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal uint cb;

			[Token(Token = "0x4000646")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			internal IntPtr lpReserved;

			[Token(Token = "0x4000647")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal IntPtr lpDesktop;

			[Token(Token = "0x4000648")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			internal IntPtr lpTitle;

			[Token(Token = "0x4000649")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			internal uint dwX;

			[Token(Token = "0x400064A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			internal uint dwY;

			[Token(Token = "0x400064B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			internal uint dwXSize;

			[Token(Token = "0x400064C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			internal uint dwYSize;

			[Token(Token = "0x400064D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			internal uint dwXCountChars;

			[Token(Token = "0x400064E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			internal uint dwYCountChars;

			[Token(Token = "0x400064F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			internal uint dwFillAttribute;

			[Token(Token = "0x4000650")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			internal uint dwFlags;

			[Token(Token = "0x4000651")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			internal ushort wShowWindow;

			[Token(Token = "0x4000652")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x42")]
			internal ushort cbReserved2;

			[Token(Token = "0x4000653")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			internal IntPtr lpReserved2;

			[Token(Token = "0x4000654")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			internal IntPtr hStdInput;

			[Token(Token = "0x4000655")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			internal IntPtr hStdOutput;

			[Token(Token = "0x4000656")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			internal IntPtr hStdError;
		}

		[Token(Token = "0x2000137")]
		[Flags]
		private enum ProcessCreationFlags : uint
		{
			[Token(Token = "0x4000658")]
			NONE = 0u,
			[Token(Token = "0x4000659")]
			CREATE_BREAKAWAY_FROM_JOB = 0x1000000u,
			[Token(Token = "0x400065A")]
			CREATE_DEFAULT_ERROR_MODE = 0x4000000u,
			[Token(Token = "0x400065B")]
			CREATE_NEW_CONSOLE = 0x10u,
			[Token(Token = "0x400065C")]
			CREATE_NEW_PROCESS_GROUP = 0x200u,
			[Token(Token = "0x400065D")]
			CREATE_NO_WINDOW = 0x8000000u,
			[Token(Token = "0x400065E")]
			CREATE_PROTECTED_PROCESS = 0x40000u,
			[Token(Token = "0x400065F")]
			CREATE_PRESERVE_CODE_AUTHZ_LEVEL = 0x2000000u,
			[Token(Token = "0x4000660")]
			CREATE_SECURE_PROCESS = 0x400000u,
			[Token(Token = "0x4000661")]
			CREATE_SEPARATE_WOW_VDM = 0x800u,
			[Token(Token = "0x4000662")]
			CREATE_SHARED_WOW_VDM = 0x1000u,
			[Token(Token = "0x4000663")]
			CREATE_SUSPENDED = 4u,
			[Token(Token = "0x4000664")]
			CREATE_UNICODE_ENVIRONMENT = 0x400u,
			[Token(Token = "0x4000665")]
			DEBUG_ONLY_THIS_PROCESS = 2u,
			[Token(Token = "0x4000666")]
			DEBUG_PROCESS = 1u,
			[Token(Token = "0x4000667")]
			DETACHED_PROCESS = 8u,
			[Token(Token = "0x4000668")]
			EXTENDED_STARTUPINFO_PRESENT = 0x80000u,
			[Token(Token = "0x4000669")]
			INHERIT_PARENT_AFFINITY = 0x10000u
		}

		[PreserveSig]
		[Token(Token = "0x6000021")]
		[Address(RVA = "0x1633A00", Offset = "0x1633A00", VA = "0x1633A00")]
		private static extern bool CreateProcessW(string lpApplicationName, [In] string lpCommandLine, IntPtr procSecAttrs, IntPtr threadSecAttrs, bool bInheritHandles, ProcessCreationFlags dwCreationFlags, IntPtr lpEnvironment, string lpCurrentDirectory, ref STARTUPINFO lpStartupInfo, ref PROCESS_INFORMATION lpProcessInformation);

		[PreserveSig]
		[Token(Token = "0x6000022")]
		[Address(RVA = "0x1633B0C", Offset = "0x1633B0C", VA = "0x1633B0C")]
		private static extern bool CloseHandle(IntPtr hObject);

		[PreserveSig]
		[Token(Token = "0x6000023")]
		[Address(RVA = "0x1633B9C", Offset = "0x1633B9C", VA = "0x1633B9C")]
		private static extern bool TerminateProcess(IntPtr processHandle, uint exitCode);

		[PreserveSig]
		[Token(Token = "0x6000024")]
		[Address(RVA = "0x1633C38", Offset = "0x1633C38", VA = "0x1633C38")]
		private static extern IntPtr OpenProcess(ProcessAccessRights access, bool inherit, uint processId);

		[Token(Token = "0x6000025")]
		[Address(RVA = "0x1633CD8", Offset = "0x1633CD8", VA = "0x1633CD8")]
		public static uint Start(string path, string dir, bool hidden = false)
		{
			return default(uint);
		}

		[Token(Token = "0x6000026")]
		[Address(RVA = "0x1633E20", Offset = "0x1633E20", VA = "0x1633E20")]
		public static int KillProcess(uint pid)
		{
			return default(int);
		}
	}
}
namespace HellTap.MeshDecimator
{
	[Token(Token = "0x200000A")]
	public struct BoneWeight : IEquatable<BoneWeight>
	{
		[Token(Token = "0x400002E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int boneIndex0;

		[Token(Token = "0x400002F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public int boneIndex1;

		[Token(Token = "0x4000030")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public int boneIndex2;

		[Token(Token = "0x4000031")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public int boneIndex3;

		[Token(Token = "0x4000032")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float boneWeight0;

		[Token(Token = "0x4000033")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public float boneWeight1;

		[Token(Token = "0x4000034")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float boneWeight2;

		[Token(Token = "0x4000035")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float boneWeight3;

		[Token(Token = "0x6000027")]
		[Address(RVA = "0x1524534", Offset = "0x1524534", VA = "0x1524534")]
		public BoneWeight(int boneIndex0, int boneIndex1, int boneIndex2, int boneIndex3, float boneWeight0, float boneWeight1, float boneWeight2, float boneWeight3)
		{
		}

		[Token(Token = "0x6000028")]
		[Address(RVA = "0x1524548", Offset = "0x1524548", VA = "0x1524548")]
		public static bool operator ==(BoneWeight lhs, BoneWeight rhs)
		{
			return default(bool);
		}

		[Token(Token = "0x6000029")]
		[Address(RVA = "0x152474C", Offset = "0x152474C", VA = "0x152474C")]
		public static bool operator !=(BoneWeight lhs, BoneWeight rhs)
		{
			return default(bool);
		}

		[Token(Token = "0x600002A")]
		[Address(RVA = "0x1524788", Offset = "0x1524788", VA = "0x1524788")]
		private void MergeBoneWeight(int boneIndex, float weight)
		{
		}

		[Token(Token = "0x600002B")]
		[Address(RVA = "0x1524874", Offset = "0x1524874", VA = "0x1524874")]
		private void Normalize()
		{
		}

		[Token(Token = "0x600002C")]
		[Address(RVA = "0x1524948", Offset = "0x1524948", VA = "0x1524948", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x600002D")]
		[Address(RVA = "0x1524A10", Offset = "0x1524A10", VA = "0x1524A10", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x600002E")]
		[Address(RVA = "0x1524B08", Offset = "0x1524B08", VA = "0x1524B08", Slot = "4")]
		public bool Equals(BoneWeight other)
		{
			return default(bool);
		}

		[Token(Token = "0x600002F")]
		[Address(RVA = "0x1524B94", Offset = "0x1524B94", VA = "0x1524B94", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000030")]
		[Address(RVA = "0x1524EA0", Offset = "0x1524EA0", VA = "0x1524EA0")]
		public static void Merge(ref BoneWeight a, ref BoneWeight b)
		{
		}
	}
	[Token(Token = "0x200000B")]
	public interface ILogger
	{
		[Token(Token = "0x6000031")]
		void LogVerbose(string text);

		[Token(Token = "0x6000032")]
		void LogWarning(string text);

		[Token(Token = "0x6000033")]
		void LogError(string text);
	}
	[Token(Token = "0x200000C")]
	public static class Logging
	{
		[Token(Token = "0x4000036")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static ILogger logger;

		[Token(Token = "0x4000037")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static object syncObj;

		[Token(Token = "0x17000006")]
		public static ILogger Logger
		{
			[Token(Token = "0x6000034")]
			[Address(RVA = "0x15250C8", Offset = "0x15250C8", VA = "0x15250C8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000035")]
			[Address(RVA = "0x1525130", Offset = "0x1525130", VA = "0x1525130")]
			set
			{
			}
		}

		[Token(Token = "0x6000036")]
		[Address(RVA = "0x1525230", Offset = "0x1525230", VA = "0x1525230")]
		static Logging()
		{
		}

		[Token(Token = "0x6000037")]
		[Address(RVA = "0x15252E4", Offset = "0x15252E4", VA = "0x15252E4")]
		public static void LogVerbose(string text)
		{
		}

		[Token(Token = "0x6000038")]
		[Address(RVA = "0x1525480", Offset = "0x1525480", VA = "0x1525480")]
		public static void LogVerbose(string format, params object[] args)
		{
		}

		[Token(Token = "0x6000039")]
		[Address(RVA = "0x1525508", Offset = "0x1525508", VA = "0x1525508")]
		public static void LogWarning(string text)
		{
		}

		[Token(Token = "0x600003A")]
		[Address(RVA = "0x15256A8", Offset = "0x15256A8", VA = "0x15256A8")]
		public static void LogWarning(string format, params object[] args)
		{
		}

		[Token(Token = "0x600003B")]
		[Address(RVA = "0x1525730", Offset = "0x1525730", VA = "0x1525730")]
		public static void LogError(string text)
		{
		}

		[Token(Token = "0x600003C")]
		[Address(RVA = "0x15258D0", Offset = "0x15258D0", VA = "0x15258D0")]
		public static void LogError(string format, params object[] args)
		{
		}
	}
	[Token(Token = "0x200000D")]
	public sealed class Mesh
	{
		[Token(Token = "0x4000038")]
		public const int UVChannelCount = 4;

		[Token(Token = "0x4000039")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private Vector3d[] vertices;

		[Token(Token = "0x400003A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private int[][] indices;

		[Token(Token = "0x400003B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private HellTap.MeshDecimator.Math.Vector3[] normals;

		[Token(Token = "0x400003C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private HellTap.MeshDecimator.Math.Vector4[] tangents;

		[Token(Token = "0x400003D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private HellTap.MeshDecimator.Math.Vector2[][] uvs2D;

		[Token(Token = "0x400003E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private HellTap.MeshDecimator.Math.Vector3[][] uvs3D;

		[Token(Token = "0x400003F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private HellTap.MeshDecimator.Math.Vector4[][] uvs4D;

		[Token(Token = "0x4000040")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private HellTap.MeshDecimator.Math.Vector4[] colors;

		[Token(Token = "0x4000041")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private BoneWeight[] boneWeights;

		[Token(Token = "0x4000042")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly int[] emptyIndices;

		[Token(Token = "0x17000007")]
		public int VertexCount
		{
			[Token(Token = "0x600003D")]
			[Address(RVA = "0x152BE04", Offset = "0x152BE04", VA = "0x152BE04")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000008")]
		public int SubMeshCount
		{
			[Token(Token = "0x600003E")]
			[Address(RVA = "0x152BE20", Offset = "0x152BE20", VA = "0x152BE20")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600003F")]
			[Address(RVA = "0x152BE3C", Offset = "0x152BE3C", VA = "0x152BE3C")]
			set
			{
			}
		}

		[Token(Token = "0x17000009")]
		public int TriangleCount
		{
			[Token(Token = "0x6000040")]
			[Address(RVA = "0x152BF28", Offset = "0x152BF28", VA = "0x152BF28")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700000A")]
		public Vector3d[] Vertices
		{
			[Token(Token = "0x6000041")]
			[Address(RVA = "0x152BFB4", Offset = "0x152BFB4", VA = "0x152BFB4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000042")]
			[Address(RVA = "0x152BFBC", Offset = "0x152BFBC", VA = "0x152BFBC")]
			set
			{
			}
		}

		[Token(Token = "0x1700000B")]
		public int[] Indices
		{
			[Token(Token = "0x6000043")]
			[Address(RVA = "0x152C0E0", Offset = "0x152C0E0", VA = "0x152C0E0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000044")]
			[Address(RVA = "0x152C22C", Offset = "0x152C22C", VA = "0x152C22C")]
			set
			{
			}
		}

		[Token(Token = "0x1700000C")]
		public HellTap.MeshDecimator.Math.Vector3[] Normals
		{
			[Token(Token = "0x6000045")]
			[Address(RVA = "0x152C4A0", Offset = "0x152C4A0", VA = "0x152C4A0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000046")]
			[Address(RVA = "0x152C4A8", Offset = "0x152C4A8", VA = "0x152C4A8")]
			set
			{
			}
		}

		[Token(Token = "0x1700000D")]
		public HellTap.MeshDecimator.Math.Vector4[] Tangents
		{
			[Token(Token = "0x6000047")]
			[Address(RVA = "0x152C5C4", Offset = "0x152C5C4", VA = "0x152C5C4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000048")]
			[Address(RVA = "0x152C5CC", Offset = "0x152C5CC", VA = "0x152C5CC")]
			set
			{
			}
		}

		[Token(Token = "0x1700000E")]
		public HellTap.MeshDecimator.Math.Vector2[] UV1
		{
			[Token(Token = "0x6000049")]
			[Address(RVA = "0x152C6E8", Offset = "0x152C6E8", VA = "0x152C6E8")]
			get
			{
				return null;
			}
			[Token(Token = "0x600004A")]
			[Address(RVA = "0x152C7B0", Offset = "0x152C7B0", VA = "0x152C7B0")]
			set
			{
			}
		}

		[Token(Token = "0x1700000F")]
		public HellTap.MeshDecimator.Math.Vector2[] UV2
		{
			[Token(Token = "0x600004B")]
			[Address(RVA = "0x152CA50", Offset = "0x152CA50", VA = "0x152CA50")]
			get
			{
				return null;
			}
			[Token(Token = "0x600004C")]
			[Address(RVA = "0x152CA58", Offset = "0x152CA58", VA = "0x152CA58")]
			set
			{
			}
		}

		[Token(Token = "0x17000010")]
		public HellTap.MeshDecimator.Math.Vector2[] UV3
		{
			[Token(Token = "0x600004D")]
			[Address(RVA = "0x152CA64", Offset = "0x152CA64", VA = "0x152CA64")]
			get
			{
				return null;
			}
			[Token(Token = "0x600004E")]
			[Address(RVA = "0x152CA6C", Offset = "0x152CA6C", VA = "0x152CA6C")]
			set
			{
			}
		}

		[Token(Token = "0x17000011")]
		public HellTap.MeshDecimator.Math.Vector2[] UV4
		{
			[Token(Token = "0x600004F")]
			[Address(RVA = "0x152CA78", Offset = "0x152CA78", VA = "0x152CA78")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000050")]
			[Address(RVA = "0x152CA80", Offset = "0x152CA80", VA = "0x152CA80")]
			set
			{
			}
		}

		[Token(Token = "0x17000012")]
		public HellTap.MeshDecimator.Math.Vector4[] Colors
		{
			[Token(Token = "0x6000051")]
			[Address(RVA = "0x152CA8C", Offset = "0x152CA8C", VA = "0x152CA8C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000052")]
			[Address(RVA = "0x152CA94", Offset = "0x152CA94", VA = "0x152CA94")]
			set
			{
			}
		}

		[Token(Token = "0x17000013")]
		public BoneWeight[] BoneWeights
		{
			[Token(Token = "0x6000053")]
			[Address(RVA = "0x152CBB0", Offset = "0x152CBB0", VA = "0x152CBB0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000054")]
			[Address(RVA = "0x152CBB8", Offset = "0x152CBB8", VA = "0x152CBB8")]
			set
			{
			}
		}

		[Token(Token = "0x6000055")]
		[Address(RVA = "0x152CCD4", Offset = "0x152CCD4", VA = "0x152CCD4")]
		public Mesh(Vector3d[] vertices, int[] indices)
		{
		}

		[Token(Token = "0x6000056")]
		[Address(RVA = "0x152CE70", Offset = "0x152CE70", VA = "0x152CE70")]
		public Mesh(Vector3d[] vertices, int[][] indices)
		{
		}

		[Token(Token = "0x6000057")]
		[Address(RVA = "0x152C05C", Offset = "0x152C05C", VA = "0x152C05C")]
		private void ClearVertexAttributes()
		{
		}

		[Token(Token = "0x6000058")]
		[Address(RVA = "0x152D038", Offset = "0x152D038", VA = "0x152D038")]
		public void RecalculateNormals()
		{
		}

		[Token(Token = "0x6000059")]
		[Address(RVA = "0x152D374", Offset = "0x152D374", VA = "0x152D374")]
		public void RecalculateTangents()
		{
		}

		[Token(Token = "0x600005A")]
		[Address(RVA = "0x152DA84", Offset = "0x152DA84", VA = "0x152DA84")]
		public int GetTriangleCount(int subMeshIndex)
		{
			return default(int);
		}

		[Token(Token = "0x600005B")]
		[Address(RVA = "0x152DB54", Offset = "0x152DB54", VA = "0x152DB54")]
		public int[] GetIndices(int subMeshIndex)
		{
			return null;
		}

		[Token(Token = "0x600005C")]
		[Address(RVA = "0x152C330", Offset = "0x152C330", VA = "0x152C330")]
		public void SetIndices(int subMeshIndex, int[] indices)
		{
		}

		[Token(Token = "0x600005D")]
		[Address(RVA = "0x152DC34", Offset = "0x152DC34", VA = "0x152DC34")]
		public int GetUVDimension(int channel)
		{
			return default(int);
		}

		[Token(Token = "0x600005E")]
		[Address(RVA = "0x152C6F0", Offset = "0x152C6F0", VA = "0x152C6F0")]
		public HellTap.MeshDecimator.Math.Vector2[] GetUVs2D(int channel)
		{
			return null;
		}

		[Token(Token = "0x600005F")]
		[Address(RVA = "0x152DD4C", Offset = "0x152DD4C", VA = "0x152DD4C")]
		public HellTap.MeshDecimator.Math.Vector3[] GetUVs3D(int channel)
		{
			return null;
		}

		[Token(Token = "0x6000060")]
		[Address(RVA = "0x152DE0C", Offset = "0x152DE0C", VA = "0x152DE0C")]
		public HellTap.MeshDecimator.Math.Vector4[] GetUVs4D(int channel)
		{
			return null;
		}

		[Token(Token = "0x6000061")]
		[Address(RVA = "0x152DECC", Offset = "0x152DECC", VA = "0x152DECC")]
		public void GetUVs(int channel, List<HellTap.MeshDecimator.Math.Vector2> uvs)
		{
		}

		[Token(Token = "0x6000062")]
		[Address(RVA = "0x152DFF0", Offset = "0x152DFF0", VA = "0x152DFF0")]
		public void GetUVs(int channel, List<HellTap.MeshDecimator.Math.Vector3> uvs)
		{
		}

		[Token(Token = "0x6000063")]
		[Address(RVA = "0x152E114", Offset = "0x152E114", VA = "0x152E114")]
		public void GetUVs(int channel, List<HellTap.MeshDecimator.Math.Vector4> uvs)
		{
		}

		[Token(Token = "0x6000064")]
		[Address(RVA = "0x152C7BC", Offset = "0x152C7BC", VA = "0x152C7BC")]
		public void SetUVs(int channel, HellTap.MeshDecimator.Math.Vector2[] uvs)
		{
		}

		[Token(Token = "0x6000065")]
		[Address(RVA = "0x152E238", Offset = "0x152E238", VA = "0x152E238")]
		public void SetUVs(int channel, HellTap.MeshDecimator.Math.Vector3[] uvs)
		{
		}

		[Token(Token = "0x6000066")]
		[Address(RVA = "0x152E4CC", Offset = "0x152E4CC", VA = "0x152E4CC")]
		public void SetUVs(int channel, HellTap.MeshDecimator.Math.Vector4[] uvs)
		{
		}

		[Token(Token = "0x6000067")]
		[Address(RVA = "0x152E760", Offset = "0x152E760", VA = "0x152E760")]
		public void SetUVs(int channel, List<HellTap.MeshDecimator.Math.Vector2> uvs)
		{
		}

		[Token(Token = "0x6000068")]
		[Address(RVA = "0x152EA00", Offset = "0x152EA00", VA = "0x152EA00")]
		public void SetUVs(int channel, List<HellTap.MeshDecimator.Math.Vector3> uvs)
		{
		}

		[Token(Token = "0x6000069")]
		[Address(RVA = "0x152ECA0", Offset = "0x152ECA0", VA = "0x152ECA0")]
		public void SetUVs(int channel, List<HellTap.MeshDecimator.Math.Vector4> uvs)
		{
		}

		[Token(Token = "0x600006A")]
		[Address(RVA = "0x152EF40", Offset = "0x152EF40", VA = "0x152EF40", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Token(Token = "0x200000E")]
	public enum Algorithm
	{
		[Token(Token = "0x4000044")]
		Default,
		[Token(Token = "0x4000045")]
		FastQuadricMesh
	}
	[Token(Token = "0x200000F")]
	public static class MeshDecimation
	{
		[Token(Token = "0x600006C")]
		[Address(RVA = "0x152F038", Offset = "0x152F038", VA = "0x152F038")]
		public static DecimationAlgorithm CreateAlgorithm(Algorithm algorithm, bool preserveBorders = false, bool preserveSeams = false, bool preserveFoldovers = false)
		{
			return null;
		}

		[Token(Token = "0x600006D")]
		[Address(RVA = "0x152F110", Offset = "0x152F110", VA = "0x152F110")]
		public static Mesh DecimateMesh(Mesh mesh, int targetTriangleCount)
		{
			return null;
		}

		[Token(Token = "0x600006E")]
		[Address(RVA = "0x152F12C", Offset = "0x152F12C", VA = "0x152F12C")]
		public static Mesh DecimateMesh(Algorithm algorithm, Mesh mesh, int targetTriangleCount, bool preserveBorders = false, bool preserveSeams = false, bool preserveFoldovers = false)
		{
			return null;
		}

		[Token(Token = "0x600006F")]
		[Address(RVA = "0x152F1F4", Offset = "0x152F1F4", VA = "0x152F1F4")]
		public static Mesh DecimateMesh(DecimationAlgorithm algorithm, Mesh mesh, int targetTriangleCount)
		{
			return null;
		}

		[Token(Token = "0x6000070")]
		[Address(RVA = "0x152F2EC", Offset = "0x152F2EC", VA = "0x152F2EC")]
		public static Mesh DecimateMeshLossless(Mesh mesh)
		{
			return null;
		}

		[Token(Token = "0x6000071")]
		[Address(RVA = "0x152F304", Offset = "0x152F304", VA = "0x152F304")]
		public static Mesh DecimateMeshLossless(Algorithm algorithm, Mesh mesh, bool preserveBorders = false, bool preserveSeams = false, bool preserveFoldovers = false)
		{
			return null;
		}

		[Token(Token = "0x6000072")]
		[Address(RVA = "0x152F3BC", Offset = "0x152F3BC", VA = "0x152F3BC")]
		public static Mesh DecimateMeshLossless(DecimationAlgorithm algorithm, Mesh mesh)
		{
			return null;
		}
	}
}
namespace HellTap.MeshDecimator.Math
{
	[Token(Token = "0x2000010")]
	public static class MathHelper
	{
		[Token(Token = "0x4000046")]
		public const float PI = (float)System.Math.PI;

		[Token(Token = "0x4000047")]
		public const double PId = System.Math.PI;

		[Token(Token = "0x4000048")]
		public const float Deg2Rad = (float)System.Math.PI / 180f;

		[Token(Token = "0x4000049")]
		public const double Deg2Radd = System.Math.PI / 180.0;

		[Token(Token = "0x400004A")]
		public const float Rad2Deg = 180f / (float)System.Math.PI;

		[Token(Token = "0x400004B")]
		public const double Rad2Degd = 180.0 / System.Math.PI;

		[Token(Token = "0x6000073")]
		[Address(RVA = "0x1525958", Offset = "0x1525958", VA = "0x1525958")]
		public static int Min(int val1, int val2)
		{
			return default(int);
		}

		[Token(Token = "0x6000074")]
		[Address(RVA = "0x1525964", Offset = "0x1525964", VA = "0x1525964")]
		public static int Min(int val1, int val2, int val3)
		{
			return default(int);
		}

		[Token(Token = "0x6000075")]
		[Address(RVA = "0x1525984", Offset = "0x1525984", VA = "0x1525984")]
		public static float Min(float val1, float val2)
		{
			return default(float);
		}

		[Token(Token = "0x6000076")]
		[Address(RVA = "0x1525990", Offset = "0x1525990", VA = "0x1525990")]
		public static float Min(float val1, float val2, float val3)
		{
			return default(float);
		}

		[Token(Token = "0x6000077")]
		[Address(RVA = "0x15259B0", Offset = "0x15259B0", VA = "0x15259B0")]
		public static double Min(double val1, double val2)
		{
			return default(double);
		}

		[Token(Token = "0x6000078")]
		[Address(RVA = "0x15259BC", Offset = "0x15259BC", VA = "0x15259BC")]
		public static double Min(double val1, double val2, double val3)
		{
			return default(double);
		}

		[Token(Token = "0x6000079")]
		[Address(RVA = "0x15259DC", Offset = "0x15259DC", VA = "0x15259DC")]
		public static int Max(int val1, int val2)
		{
			return default(int);
		}

		[Token(Token = "0x600007A")]
		[Address(RVA = "0x15259E8", Offset = "0x15259E8", VA = "0x15259E8")]
		public static int Max(int val1, int val2, int val3)
		{
			return default(int);
		}

		[Token(Token = "0x600007B")]
		[Address(RVA = "0x1525A08", Offset = "0x1525A08", VA = "0x1525A08")]
		public static float Max(float val1, float val2)
		{
			return default(float);
		}

		[Token(Token = "0x600007C")]
		[Address(RVA = "0x1525A14", Offset = "0x1525A14", VA = "0x1525A14")]
		public static float Max(float val1, float val2, float val3)
		{
			return default(float);
		}

		[Token(Token = "0x600007D")]
		[Address(RVA = "0x1525A34", Offset = "0x1525A34", VA = "0x1525A34")]
		public static double Max(double val1, double val2)
		{
			return default(double);
		}

		[Token(Token = "0x600007E")]
		[Address(RVA = "0x1525A40", Offset = "0x1525A40", VA = "0x1525A40")]
		public static double Max(double val1, double val2, double val3)
		{
			return default(double);
		}

		[Token(Token = "0x600007F")]
		[Address(RVA = "0x1525A60", Offset = "0x1525A60", VA = "0x1525A60")]
		public static float Clamp(float value, float min, float max)
		{
			return default(float);
		}

		[Token(Token = "0x6000080")]
		[Address(RVA = "0x1525A7C", Offset = "0x1525A7C", VA = "0x1525A7C")]
		public static double Clamp(double value, double min, double max)
		{
			return default(double);
		}

		[Token(Token = "0x6000081")]
		[Address(RVA = "0x1525A98", Offset = "0x1525A98", VA = "0x1525A98")]
		public static float Clamp01(float value)
		{
			return default(float);
		}

		[Token(Token = "0x6000082")]
		[Address(RVA = "0x1525AB4", Offset = "0x1525AB4", VA = "0x1525AB4")]
		public static double Clamp01(double value)
		{
			return default(double);
		}

		[Token(Token = "0x6000083")]
		[Address(RVA = "0x1525AD0", Offset = "0x1525AD0", VA = "0x1525AD0")]
		public static float TriangleArea(ref Vector3 p0, ref Vector3 p1, ref Vector3 p2)
		{
			return default(float);
		}

		[Token(Token = "0x6000084")]
		[Address(RVA = "0x1525DF4", Offset = "0x1525DF4", VA = "0x1525DF4")]
		public static double TriangleArea(ref Vector3d p0, ref Vector3d p1, ref Vector3d p2)
		{
			return default(double);
		}
	}
	[Token(Token = "0x2000011")]
	[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0xC84BF0", Offset = "0xC84BF0")]
	public struct SymmetricMatrix
	{
		[Token(Token = "0x400004C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public double m0;

		[Token(Token = "0x400004D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public double m1;

		[Token(Token = "0x400004E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public double m2;

		[Token(Token = "0x400004F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public double m3;

		[Token(Token = "0x4000050")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public double m4;

		[Token(Token = "0x4000051")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public double m5;

		[Token(Token = "0x4000052")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public double m6;

		[Token(Token = "0x4000053")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public double m7;

		[Token(Token = "0x4000054")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public double m8;

		[Token(Token = "0x4000055")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public double m9;

		[Token(Token = "0x17000014")]
		public double Item
		{
			[Token(Token = "0x6000085")]
			[Address(RVA = "0x1526124", Offset = "0x1526124", VA = "0x1526124")]
			get
			{
				return default(double);
			}
		}

		[Token(Token = "0x6000086")]
		[Address(RVA = "0x1526208", Offset = "0x1526208", VA = "0x1526208")]
		public SymmetricMatrix(double c)
		{
		}

		[Token(Token = "0x6000087")]
		[Address(RVA = "0x1526220", Offset = "0x1526220", VA = "0x1526220")]
		public SymmetricMatrix(double m0, double m1, double m2, double m3, double m4, double m5, double m6, double m7, double m8, double m9)
		{
		}

		[Token(Token = "0x6000088")]
		[Address(RVA = "0x152623C", Offset = "0x152623C", VA = "0x152623C")]
		public SymmetricMatrix(double a, double b, double c, double d)
		{
		}

		[Token(Token = "0x6000089")]
		[Address(RVA = "0x152627C", Offset = "0x152627C", VA = "0x152627C")]
		public static SymmetricMatrix operator +(SymmetricMatrix a, SymmetricMatrix b)
		{
			return default(SymmetricMatrix);
		}

		[Token(Token = "0x600008A")]
		[Address(RVA = "0x15262B8", Offset = "0x15262B8", VA = "0x15262B8")]
		internal double Determinant1()
		{
			return default(double);
		}

		[Token(Token = "0x600008B")]
		[Address(RVA = "0x1526310", Offset = "0x1526310", VA = "0x1526310")]
		internal double Determinant2()
		{
			return default(double);
		}

		[Token(Token = "0x600008C")]
		[Address(RVA = "0x152636C", Offset = "0x152636C", VA = "0x152636C")]
		internal double Determinant3()
		{
			return default(double);
		}

		[Token(Token = "0x600008D")]
		[Address(RVA = "0x15263C4", Offset = "0x15263C4", VA = "0x15263C4")]
		internal double Determinant4()
		{
			return default(double);
		}

		[Token(Token = "0x600008E")]
		[Address(RVA = "0x1526420", Offset = "0x1526420", VA = "0x1526420")]
		public double Determinant(int a11, int a12, int a13, int a21, int a22, int a23, int a31, int a32, int a33)
		{
			return default(double);
		}
	}
	[Token(Token = "0x2000012")]
	[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0xC84C28", Offset = "0xC84C28")]
	public struct Vector2 : IEquatable<Vector2>
	{
		[Token(Token = "0x4000056")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly Vector2 zero;

		[Token(Token = "0x4000057")]
		public const float Epsilon = 9.9999994E-11f;

		[Token(Token = "0x4000058")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float x;

		[Token(Token = "0x4000059")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public float y;

		[Token(Token = "0x17000015")]
		public float Magnitude
		{
			[Token(Token = "0x600008F")]
			[Address(RVA = "0x152661C", Offset = "0x152661C", VA = "0x152661C")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000016")]
		public float MagnitudeSqr
		{
			[Token(Token = "0x6000090")]
			[Address(RVA = "0x15266B4", Offset = "0x15266B4", VA = "0x15266B4")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000017")]
		public Vector2 Normalized
		{
			[Token(Token = "0x6000091")]
			[Address(RVA = "0x15266C8", Offset = "0x15266C8", VA = "0x15266C8")]
			get
			{
				return default(Vector2);
			}
		}

		[Token(Token = "0x17000018")]
		public float Item
		{
			[Token(Token = "0x6000092")]
			[Address(RVA = "0x15267EC", Offset = "0x15267EC", VA = "0x15267EC")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000093")]
			[Address(RVA = "0x1526888", Offset = "0x1526888", VA = "0x1526888")]
			set
			{
			}
		}

		[Token(Token = "0x6000094")]
		[Address(RVA = "0x1526930", Offset = "0x1526930", VA = "0x1526930")]
		public Vector2(float value)
		{
		}

		[Token(Token = "0x6000095")]
		[Address(RVA = "0x1526938", Offset = "0x1526938", VA = "0x1526938")]
		public Vector2(float x, float y)
		{
		}

		[Token(Token = "0x6000096")]
		[Address(RVA = "0x1526940", Offset = "0x1526940", VA = "0x1526940")]
		public static Vector2 operator +(Vector2 a, Vector2 b)
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000097")]
		[Address(RVA = "0x152694C", Offset = "0x152694C", VA = "0x152694C")]
		public static Vector2 operator -(Vector2 a, Vector2 b)
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000098")]
		[Address(RVA = "0x1526958", Offset = "0x1526958", VA = "0x1526958")]
		public static Vector2 operator *(Vector2 a, float d)
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000099")]
		[Address(RVA = "0x1526964", Offset = "0x1526964", VA = "0x1526964")]
		public static Vector2 operator *(float d, Vector2 a)
		{
			return default(Vector2);
		}

		[Token(Token = "0x600009A")]
		[Address(RVA = "0x1526974", Offset = "0x1526974", VA = "0x1526974")]
		public static Vector2 operator /(Vector2 a, float d)
		{
			return default(Vector2);
		}

		[Token(Token = "0x600009B")]
		[Address(RVA = "0x1526980", Offset = "0x1526980", VA = "0x1526980")]
		public static Vector2 operator -(Vector2 a)
		{
			return default(Vector2);
		}

		[Token(Token = "0x600009C")]
		[Address(RVA = "0x152698C", Offset = "0x152698C", VA = "0x152698C")]
		public static bool operator ==(Vector2 lhs, Vector2 rhs)
		{
			return default(bool);
		}

		[Token(Token = "0x600009D")]
		[Address(RVA = "0x1526A2C", Offset = "0x1526A2C", VA = "0x1526A2C")]
		public static bool operator !=(Vector2 lhs, Vector2 rhs)
		{
			return default(bool);
		}

		[Token(Token = "0x600009E")]
		[Address(RVA = "0x1526ACC", Offset = "0x1526ACC", VA = "0x1526ACC")]
		public static explicit operator Vector2(Vector2d v)
		{
			return default(Vector2);
		}

		[Token(Token = "0x600009F")]
		[Address(RVA = "0x1526AD8", Offset = "0x1526AD8", VA = "0x1526AD8")]
		public static implicit operator Vector2(Vector2i v)
		{
			return default(Vector2);
		}

		[Token(Token = "0x60000A0")]
		[Address(RVA = "0x1526AE8", Offset = "0x1526AE8", VA = "0x1526AE8")]
		public void Set(float x, float y)
		{
		}

		[Token(Token = "0x60000A1")]
		[Address(RVA = "0x1526AF0", Offset = "0x1526AF0", VA = "0x1526AF0")]
		public void Scale(ref Vector2 scale)
		{
		}

		[Token(Token = "0x60000A2")]
		[Address(RVA = "0x1526B10", Offset = "0x1526B10", VA = "0x1526B10")]
		public void Normalize()
		{
		}

		[Token(Token = "0x60000A3")]
		[Address(RVA = "0x1526B58", Offset = "0x1526B58", VA = "0x1526B58")]
		public void Clamp(float min, float max)
		{
		}

		[Token(Token = "0x60000A4")]
		[Address(RVA = "0x1526B98", Offset = "0x1526B98", VA = "0x1526B98", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x60000A5")]
		[Address(RVA = "0x1526BD0", Offset = "0x1526BD0", VA = "0x1526BD0", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Token(Token = "0x60000A6")]
		[Address(RVA = "0x1526C68", Offset = "0x1526C68", VA = "0x1526C68", Slot = "4")]
		public bool Equals(Vector2 other)
		{
			return default(bool);
		}

		[Token(Token = "0x60000A7")]
		[Address(RVA = "0x1526C8C", Offset = "0x1526C8C", VA = "0x1526C8C", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x60000A8")]
		[Address(RVA = "0x1526D58", Offset = "0x1526D58", VA = "0x1526D58")]
		public string ToString(string format)
		{
			return null;
		}

		[Token(Token = "0x60000A9")]
		[Address(RVA = "0x1526E20", Offset = "0x1526E20", VA = "0x1526E20")]
		public static float Dot(ref Vector2 lhs, ref Vector2 rhs)
		{
			return default(float);
		}

		[Token(Token = "0x60000AA")]
		[Address(RVA = "0x1526E34", Offset = "0x1526E34", VA = "0x1526E34")]
		public static void Lerp(ref Vector2 a, ref Vector2 b, float t, out Vector2 result)
		{
		}

		[Token(Token = "0x60000AB")]
		[Address(RVA = "0x1526E50", Offset = "0x1526E50", VA = "0x1526E50")]
		public static void Scale(ref Vector2 a, ref Vector2 b, out Vector2 result)
		{
		}

		[Token(Token = "0x60000AC")]
		[Address(RVA = "0x1526744", Offset = "0x1526744", VA = "0x1526744")]
		public static void Normalize(ref Vector2 value, out Vector2 result)
		{
		}
	}
	[Token(Token = "0x2000013")]
	[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0xC84C60", Offset = "0xC84C60")]
	public struct Vector2d : IEquatable<Vector2d>
	{
		[Token(Token = "0x400005A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly Vector2d zero;

		[Token(Token = "0x400005B")]
		public const double Epsilon = double.Epsilon;

		[Token(Token = "0x400005C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public double x;

		[Token(Token = "0x400005D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public double y;

		[Token(Token = "0x17000019")]
		public double Magnitude
		{
			[Token(Token = "0x60000AE")]
			[Address(RVA = "0x1526EB4", Offset = "0x1526EB4", VA = "0x1526EB4")]
			get
			{
				return default(double);
			}
		}

		[Token(Token = "0x1700001A")]
		public double MagnitudeSqr
		{
			[Token(Token = "0x60000AF")]
			[Address(RVA = "0x1526F4C", Offset = "0x1526F4C", VA = "0x1526F4C")]
			get
			{
				return default(double);
			}
		}

		[Token(Token = "0x1700001B")]
		public Vector2d Normalized
		{
			[Token(Token = "0x60000B0")]
			[Address(RVA = "0x1526F60", Offset = "0x1526F60", VA = "0x1526F60")]
			get
			{
				return default(Vector2d);
			}
		}

		[Token(Token = "0x1700001C")]
		public double Item
		{
			[Token(Token = "0x60000B1")]
			[Address(RVA = "0x1527080", Offset = "0x1527080", VA = "0x1527080")]
			get
			{
				return default(double);
			}
			[Token(Token = "0x60000B2")]
			[Address(RVA = "0x152711C", Offset = "0x152711C", VA = "0x152711C")]
			set
			{
			}
		}

		[Token(Token = "0x60000B3")]
		[Address(RVA = "0x15271C4", Offset = "0x15271C4", VA = "0x15271C4")]
		public Vector2d(double value)
		{
		}

		[Token(Token = "0x60000B4")]
		[Address(RVA = "0x15271CC", Offset = "0x15271CC", VA = "0x15271CC")]
		public Vector2d(double x, double y)
		{
		}

		[Token(Token = "0x60000B5")]
		[Address(RVA = "0x15271D4", Offset = "0x15271D4", VA = "0x15271D4")]
		public static Vector2d operator +(Vector2d a, Vector2d b)
		{
			return default(Vector2d);
		}

		[Token(Token = "0x60000B6")]
		[Address(RVA = "0x15271E0", Offset = "0x15271E0", VA = "0x15271E0")]
		public static Vector2d operator -(Vector2d a, Vector2d b)
		{
			return default(Vector2d);
		}

		[Token(Token = "0x60000B7")]
		[Address(RVA = "0x15271EC", Offset = "0x15271EC", VA = "0x15271EC")]
		public static Vector2d operator *(Vector2d a, double d)
		{
			return default(Vector2d);
		}

		[Token(Token = "0x60000B8")]
		[Address(RVA = "0x15271F8", Offset = "0x15271F8", VA = "0x15271F8")]
		public static Vector2d operator *(double d, Vector2d a)
		{
			return default(Vector2d);
		}

		[Token(Token = "0x60000B9")]
		[Address(RVA = "0x1527208", Offset = "0x1527208", VA = "0x1527208")]
		public static Vector2d operator /(Vector2d a, double d)
		{
			return default(Vector2d);
		}

		[Token(Token = "0x60000BA")]
		[Address(RVA = "0x1527214", Offset = "0x1527214", VA = "0x1527214")]
		public static Vector2d operator -(Vector2d a)
		{
			return default(Vector2d);
		}

		[Token(Token = "0x60000BB")]
		[Address(RVA = "0x1527220", Offset = "0x1527220", VA = "0x1527220")]
		public static bool operator ==(Vector2d lhs, Vector2d rhs)
		{
			return default(bool);
		}

		[Token(Token = "0x60000BC")]
		[Address(RVA = "0x15272C0", Offset = "0x15272C0", VA = "0x15272C0")]
		public static bool operator !=(Vector2d lhs, Vector2d rhs)
		{
			return default(bool);
		}

		[Token(Token = "0x60000BD")]
		[Address(RVA = "0x1527360", Offset = "0x1527360", VA = "0x1527360")]
		public static implicit operator Vector2d(Vector2 v)
		{
			return default(Vector2d);
		}

		[Token(Token = "0x60000BE")]
		[Address(RVA = "0x152736C", Offset = "0x152736C", VA = "0x152736C")]
		public static implicit operator Vector2d(Vector2i v)
		{
			return default(Vector2d);
		}

		[Token(Token = "0x60000BF")]
		[Address(RVA = "0x152737C", Offset = "0x152737C", VA = "0x152737C")]
		public void Set(double x, double y)
		{
		}

		[Token(Token = "0x60000C0")]
		[Address(RVA = "0x1527384", Offset = "0x1527384", VA = "0x1527384")]
		public void Scale(ref Vector2d scale)
		{
		}

		[Token(Token = "0x60000C1")]
		[Address(RVA = "0x15273A4", Offset = "0x15273A4", VA = "0x15273A4")]
		public void Normalize()
		{
		}

		[Token(Token = "0x60000C2")]
		[Address(RVA = "0x15273EC", Offset = "0x15273EC", VA = "0x15273EC")]
		public void Clamp(double min, double max)
		{
		}

		[Token(Token = "0x60000C3")]
		[Address(RVA = "0x152742C", Offset = "0x152742C", VA = "0x152742C", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x60000C4")]
		[Address(RVA = "0x1527464", Offset = "0x1527464", VA = "0x1527464", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Token(Token = "0x60000C5")]
		[Address(RVA = "0x15274FC", Offset = "0x15274FC", VA = "0x15274FC", Slot = "4")]
		public bool Equals(Vector2d other)
		{
			return default(bool);
		}

		[Token(Token = "0x60000C6")]
		[Address(RVA = "0x1527520", Offset = "0x1527520", VA = "0x1527520", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x60000C7")]
		[Address(RVA = "0x15275EC", Offset = "0x15275EC", VA = "0x15275EC")]
		public string ToString(string format)
		{
			return null;
		}

		[Token(Token = "0x60000C8")]
		[Address(RVA = "0x15276B4", Offset = "0x15276B4", VA = "0x15276B4")]
		public static double Dot(ref Vector2d lhs, ref Vector2d rhs)
		{
			return default(double);
		}

		[Token(Token = "0x60000C9")]
		[Address(RVA = "0x15276C8", Offset = "0x15276C8", VA = "0x15276C8")]
		public static void Lerp(ref Vector2d a, ref Vector2d b, double t, out Vector2d result)
		{
		}

		[Token(Token = "0x60000CA")]
		[Address(RVA = "0x15276E4", Offset = "0x15276E4", VA = "0x15276E4")]
		public static void Scale(ref Vector2d a, ref Vector2d b, out Vector2d result)
		{
		}

		[Token(Token = "0x60000CB")]
		[Address(RVA = "0x1526FDC", Offset = "0x1526FDC", VA = "0x1526FDC")]
		public static void Normalize(ref Vector2d value, out Vector2d result)
		{
		}
	}
	[Token(Token = "0x2000014")]
	[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0xC84C98", Offset = "0xC84C98")]
	public struct Vector2i : IEquatable<Vector2i>
	{
		[Token(Token = "0x400005E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly Vector2i zero;

		[Token(Token = "0x400005F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int x;

		[Token(Token = "0x4000060")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public int y;

		[Token(Token = "0x1700001D")]
		public int Magnitude
		{
			[Token(Token = "0x60000CD")]
			[Address(RVA = "0x1527748", Offset = "0x1527748", VA = "0x1527748")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700001E")]
		public int MagnitudeSqr
		{
			[Token(Token = "0x60000CE")]
			[Address(RVA = "0x15277D0", Offset = "0x15277D0", VA = "0x15277D0")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700001F")]
		public int Item
		{
			[Token(Token = "0x60000CF")]
			[Address(RVA = "0x15277E0", Offset = "0x15277E0", VA = "0x15277E0")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60000D0")]
			[Address(RVA = "0x152787C", Offset = "0x152787C", VA = "0x152787C")]
			set
			{
			}
		}

		[Token(Token = "0x60000D1")]
		[Address(RVA = "0x152791C", Offset = "0x152791C", VA = "0x152791C")]
		public Vector2i(int value)
		{
		}

		[Token(Token = "0x60000D2")]
		[Address(RVA = "0x1527924", Offset = "0x1527924", VA = "0x1527924")]
		public Vector2i(int x, int y)
		{
		}

		[Token(Token = "0x60000D3")]
		[Address(RVA = "0x152792C", Offset = "0x152792C", VA = "0x152792C")]
		public static Vector2i operator +(Vector2i a, Vector2i b)
		{
			return default(Vector2i);
		}

		[Token(Token = "0x60000D4")]
		[Address(RVA = "0x1527944", Offset = "0x1527944", VA = "0x1527944")]
		public static Vector2i operator -(Vector2i a, Vector2i b)
		{
			return default(Vector2i);
		}

		[Token(Token = "0x60000D5")]
		[Address(RVA = "0x152795C", Offset = "0x152795C", VA = "0x152795C")]
		public static Vector2i operator *(Vector2i a, int d)
		{
			return default(Vector2i);
		}

		[Token(Token = "0x60000D6")]
		[Address(RVA = "0x1527970", Offset = "0x1527970", VA = "0x1527970")]
		public static Vector2i operator *(int d, Vector2i a)
		{
			return default(Vector2i);
		}

		[Token(Token = "0x60000D7")]
		[Address(RVA = "0x1527988", Offset = "0x1527988", VA = "0x1527988")]
		public static Vector2i operator /(Vector2i a, int d)
		{
			return default(Vector2i);
		}

		[Token(Token = "0x60000D8")]
		[Address(RVA = "0x152799C", Offset = "0x152799C", VA = "0x152799C")]
		public static Vector2i operator -(Vector2i a)
		{
			return default(Vector2i);
		}

		[Token(Token = "0x60000D9")]
		[Address(RVA = "0x15279B0", Offset = "0x15279B0", VA = "0x15279B0")]
		public static bool operator ==(Vector2i lhs, Vector2i rhs)
		{
			return default(bool);
		}

		[Token(Token = "0x60000DA")]
		[Address(RVA = "0x15279D0", Offset = "0x15279D0", VA = "0x15279D0")]
		public static bool operator !=(Vector2i lhs, Vector2i rhs)
		{
			return default(bool);
		}

		[Token(Token = "0x60000DB")]
		[Address(RVA = "0x15279F0", Offset = "0x15279F0", VA = "0x15279F0")]
		public static explicit operator Vector2i(Vector2 v)
		{
			return default(Vector2i);
		}

		[Token(Token = "0x60000DC")]
		[Address(RVA = "0x1527A00", Offset = "0x1527A00", VA = "0x1527A00")]
		public static explicit operator Vector2i(Vector2d v)
		{
			return default(Vector2i);
		}

		[Token(Token = "0x60000DD")]
		[Address(RVA = "0x1527A10", Offset = "0x1527A10", VA = "0x1527A10")]
		public void Set(int x, int y)
		{
		}

		[Token(Token = "0x60000DE")]
		[Address(RVA = "0x1527A18", Offset = "0x1527A18", VA = "0x1527A18")]
		public void Scale(ref Vector2i scale)
		{
		}

		[Token(Token = "0x60000DF")]
		[Address(RVA = "0x1527A38", Offset = "0x1527A38", VA = "0x1527A38")]
		public void Clamp(int min, int max)
		{
		}

		[Token(Token = "0x60000E0")]
		[Address(RVA = "0x1527A78", Offset = "0x1527A78", VA = "0x1527A78", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x60000E1")]
		[Address(RVA = "0x1527AB0", Offset = "0x1527AB0", VA = "0x1527AB0", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Token(Token = "0x60000E2")]
		[Address(RVA = "0x1527B48", Offset = "0x1527B48", VA = "0x1527B48", Slot = "4")]
		public bool Equals(Vector2i other)
		{
			return default(bool);
		}

		[Token(Token = "0x60000E3")]
		[Address(RVA = "0x1527B70", Offset = "0x1527B70", VA = "0x1527B70", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x60000E4")]
		[Address(RVA = "0x1527C24", Offset = "0x1527C24", VA = "0x1527C24")]
		public string ToString(string format)
		{
			return null;
		}

		[Token(Token = "0x60000E5")]
		[Address(RVA = "0x1527CEC", Offset = "0x1527CEC", VA = "0x1527CEC")]
		public static void Scale(ref Vector2i a, ref Vector2i b, out Vector2i result)
		{
		}
	}
	[Token(Token = "0x2000015")]
	[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0xC84CD0", Offset = "0xC84CD0")]
	public struct Vector3 : IEquatable<Vector3>
	{
		[Token(Token = "0x4000061")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly Vector3 zero;

		[Token(Token = "0x4000062")]
		public const float Epsilon = 9.9999994E-11f;

		[Token(Token = "0x4000063")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float x;

		[Token(Token = "0x4000064")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public float y;

		[Token(Token = "0x4000065")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public float z;

		[Token(Token = "0x17000020")]
		public float Magnitude
		{
			[Token(Token = "0x60000E7")]
			[Address(RVA = "0x1525C38", Offset = "0x1525C38", VA = "0x1525C38")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000021")]
		public float MagnitudeSqr
		{
			[Token(Token = "0x60000E8")]
			[Address(RVA = "0x1527D58", Offset = "0x1527D58", VA = "0x1527D58")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000022")]
		public Vector3 Normalized
		{
			[Token(Token = "0x60000E9")]
			[Address(RVA = "0x1527D78", Offset = "0x1527D78", VA = "0x1527D78")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000023")]
		public float Item
		{
			[Token(Token = "0x60000EA")]
			[Address(RVA = "0x1527EB8", Offset = "0x1527EB8", VA = "0x1527EB8")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60000EB")]
			[Address(RVA = "0x1527F64", Offset = "0x1527F64", VA = "0x1527F64")]
			set
			{
			}
		}

		[Token(Token = "0x60000EC")]
		[Address(RVA = "0x152801C", Offset = "0x152801C", VA = "0x152801C")]
		public Vector3(float value)
		{
		}

		[Token(Token = "0x60000ED")]
		[Address(RVA = "0x1528028", Offset = "0x1528028", VA = "0x1528028")]
		public Vector3(float x, float y, float z)
		{
		}

		[Token(Token = "0x60000EE")]
		[Address(RVA = "0x1528034", Offset = "0x1528034", VA = "0x1528034")]
		public Vector3(Vector3d vector)
		{
		}

		[Token(Token = "0x60000EF")]
		[Address(RVA = "0x152804C", Offset = "0x152804C", VA = "0x152804C")]
		public static Vector3 operator +(Vector3 a, Vector3 b)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000F0")]
		[Address(RVA = "0x1525C28", Offset = "0x1525C28", VA = "0x1525C28")]
		public static Vector3 operator -(Vector3 a, Vector3 b)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000F1")]
		[Address(RVA = "0x152805C", Offset = "0x152805C", VA = "0x152805C")]
		public static Vector3 operator *(Vector3 a, float d)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000F2")]
		[Address(RVA = "0x152806C", Offset = "0x152806C", VA = "0x152806C")]
		public static Vector3 operator *(float d, Vector3 a)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000F3")]
		[Address(RVA = "0x1528080", Offset = "0x1528080", VA = "0x1528080")]
		public static Vector3 operator /(Vector3 a, float d)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000F4")]
		[Address(RVA = "0x1528090", Offset = "0x1528090", VA = "0x1528090")]
		public static Vector3 operator -(Vector3 a)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000F5")]
		[Address(RVA = "0x15280A0", Offset = "0x15280A0", VA = "0x15280A0")]
		public static bool operator ==(Vector3 lhs, Vector3 rhs)
		{
			return default(bool);
		}

		[Token(Token = "0x60000F6")]
		[Address(RVA = "0x152815C", Offset = "0x152815C", VA = "0x152815C")]
		public static bool operator !=(Vector3 lhs, Vector3 rhs)
		{
			return default(bool);
		}

		[Token(Token = "0x60000F7")]
		[Address(RVA = "0x1528218", Offset = "0x1528218", VA = "0x1528218")]
		public static explicit operator Vector3(Vector3d v)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000F8")]
		[Address(RVA = "0x1528228", Offset = "0x1528228", VA = "0x1528228")]
		public static implicit operator Vector3(Vector3i v)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000F9")]
		[Address(RVA = "0x152823C", Offset = "0x152823C", VA = "0x152823C")]
		public void Set(float x, float y, float z)
		{
		}

		[Token(Token = "0x60000FA")]
		[Address(RVA = "0x1528248", Offset = "0x1528248", VA = "0x1528248")]
		public void Scale(ref Vector3 scale)
		{
		}

		[Token(Token = "0x60000FB")]
		[Address(RVA = "0x1528278", Offset = "0x1528278", VA = "0x1528278")]
		public void Normalize()
		{
		}

		[Token(Token = "0x60000FC")]
		[Address(RVA = "0x15282D0", Offset = "0x15282D0", VA = "0x15282D0")]
		public void Clamp(float min, float max)
		{
		}

		[Token(Token = "0x60000FD")]
		[Address(RVA = "0x1528330", Offset = "0x1528330", VA = "0x1528330", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x60000FE")]
		[Address(RVA = "0x1528384", Offset = "0x1528384", VA = "0x1528384", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Token(Token = "0x60000FF")]
		[Address(RVA = "0x152842C", Offset = "0x152842C", VA = "0x152842C", Slot = "4")]
		public bool Equals(Vector3 other)
		{
			return default(bool);
		}

		[Token(Token = "0x6000100")]
		[Address(RVA = "0x152845C", Offset = "0x152845C", VA = "0x152845C", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000101")]
		[Address(RVA = "0x1528550", Offset = "0x1528550", VA = "0x1528550")]
		public string ToString(string format)
		{
			return null;
		}

		[Token(Token = "0x6000102")]
		[Address(RVA = "0x1528640", Offset = "0x1528640", VA = "0x1528640")]
		public static float Dot(ref Vector3 lhs, ref Vector3 rhs)
		{
			return default(float);
		}

		[Token(Token = "0x6000103")]
		[Address(RVA = "0x1528668", Offset = "0x1528668", VA = "0x1528668")]
		public static void Cross(ref Vector3 lhs, ref Vector3 rhs, out Vector3 result)
		{
		}

		[Token(Token = "0x6000104")]
		[Address(RVA = "0x1525CE8", Offset = "0x1525CE8", VA = "0x1525CE8")]
		public static float Angle(ref Vector3 from, ref Vector3 to)
		{
			return default(float);
		}

		[Token(Token = "0x6000105")]
		[Address(RVA = "0x15286A8", Offset = "0x15286A8", VA = "0x15286A8")]
		public static void Lerp(ref Vector3 a, ref Vector3 b, float t, out Vector3 result)
		{
		}

		[Token(Token = "0x6000106")]
		[Address(RVA = "0x15286DC", Offset = "0x15286DC", VA = "0x15286DC")]
		public static void Scale(ref Vector3 a, ref Vector3 b, out Vector3 result)
		{
		}

		[Token(Token = "0x6000107")]
		[Address(RVA = "0x1527DFC", Offset = "0x1527DFC", VA = "0x1527DFC")]
		public static void Normalize(ref Vector3 value, out Vector3 result)
		{
		}

		[Token(Token = "0x6000108")]
		[Address(RVA = "0x1528700", Offset = "0x1528700", VA = "0x1528700")]
		public static void OrthoNormalize(ref Vector3 normal, ref Vector3 tangent)
		{
		}
	}
	[Token(Token = "0x2000016")]
	[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0xC84D08", Offset = "0xC84D08")]
	public struct Vector3d : IEquatable<Vector3d>
	{
		[Token(Token = "0x4000066")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly Vector3d zero;

		[Token(Token = "0x4000067")]
		public const double Epsilon = double.Epsilon;

		[Token(Token = "0x4000068")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public double x;

		[Token(Token = "0x4000069")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public double y;

		[Token(Token = "0x400006A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public double z;

		[Token(Token = "0x17000024")]
		public double Magnitude
		{
			[Token(Token = "0x600010A")]
			[Address(RVA = "0x1525F6C", Offset = "0x1525F6C", VA = "0x1525F6C")]
			get
			{
				return default(double);
			}
		}

		[Token(Token = "0x17000025")]
		public double MagnitudeSqr
		{
			[Token(Token = "0x600010B")]
			[Address(RVA = "0x1528840", Offset = "0x1528840", VA = "0x1528840")]
			get
			{
				return default(double);
			}
		}

		[Token(Token = "0x17000026")]
		public Vector3d Normalized
		{
			[Token(Token = "0x600010C")]
			[Address(RVA = "0x1528860", Offset = "0x1528860", VA = "0x1528860")]
			get
			{
				return default(Vector3d);
			}
		}

		[Token(Token = "0x17000027")]
		public double Item
		{
			[Token(Token = "0x600010D")]
			[Address(RVA = "0x15289A0", Offset = "0x15289A0", VA = "0x15289A0")]
			get
			{
				return default(double);
			}
			[Token(Token = "0x600010E")]
			[Address(RVA = "0x1528A4C", Offset = "0x1528A4C", VA = "0x1528A4C")]
			set
			{
			}
		}

		[Token(Token = "0x600010F")]
		[Address(RVA = "0x1528B04", Offset = "0x1528B04", VA = "0x1528B04")]
		public Vector3d(double value)
		{
		}

		[Token(Token = "0x6000110")]
		[Address(RVA = "0x1528B10", Offset = "0x1528B10", VA = "0x1528B10")]
		public Vector3d(double x, double y, double z)
		{
		}

		[Token(Token = "0x6000111")]
		[Address(RVA = "0x1528B1C", Offset = "0x1528B1C", VA = "0x1528B1C")]
		public Vector3d(Vector3 vector)
		{
		}

		[Token(Token = "0x6000112")]
		[Address(RVA = "0x1528B34", Offset = "0x1528B34", VA = "0x1528B34")]
		public static Vector3d operator +(Vector3d a, Vector3d b)
		{
			return default(Vector3d);
		}

		[Token(Token = "0x6000113")]
		[Address(RVA = "0x1525F5C", Offset = "0x1525F5C", VA = "0x1525F5C")]
		public static Vector3d operator -(Vector3d a, Vector3d b)
		{
			return default(Vector3d);
		}

		[Token(Token = "0x6000114")]
		[Address(RVA = "0x1528B44", Offset = "0x1528B44", VA = "0x1528B44")]
		public static Vector3d operator *(Vector3d a, double d)
		{
			return default(Vector3d);
		}

		[Token(Token = "0x6000115")]
		[Address(RVA = "0x1528B54", Offset = "0x1528B54", VA = "0x1528B54")]
		public static Vector3d operator *(double d, Vector3d a)
		{
			return default(Vector3d);
		}

		[Token(Token = "0x6000116")]
		[Address(RVA = "0x1528B68", Offset = "0x1528B68", VA = "0x1528B68")]
		public static Vector3d operator /(Vector3d a, double d)
		{
			return default(Vector3d);
		}

		[Token(Token = "0x6000117")]
		[Address(RVA = "0x1528B78", Offset = "0x1528B78", VA = "0x1528B78")]
		public static Vector3d operator -(Vector3d a)
		{
			return default(Vector3d);
		}

		[Token(Token = "0x6000118")]
		[Address(RVA = "0x1528B88", Offset = "0x1528B88", VA = "0x1528B88")]
		public static bool operator ==(Vector3d lhs, Vector3d rhs)
		{
			return default(bool);
		}

		[Token(Token = "0x6000119")]
		[Address(RVA = "0x1528C44", Offset = "0x1528C44", VA = "0x1528C44")]
		public static bool operator !=(Vector3d lhs, Vector3d rhs)
		{
			return default(bool);
		}

		[Token(Token = "0x600011A")]
		[Address(RVA = "0x1528D00", Offset = "0x1528D00", VA = "0x1528D00")]
		public static implicit operator Vector3d(Vector3 v)
		{
			return default(Vector3d);
		}

		[Token(Token = "0x600011B")]
		[Address(RVA = "0x1528D10", Offset = "0x1528D10", VA = "0x1528D10")]
		public static implicit operator Vector3d(Vector3i v)
		{
			return default(Vector3d);
		}

		[Token(Token = "0x600011C")]
		[Address(RVA = "0x1528D24", Offset = "0x1528D24", VA = "0x1528D24")]
		public void Set(double x, double y, double z)
		{
		}

		[Token(Token = "0x600011D")]
		[Address(RVA = "0x1528D30", Offset = "0x1528D30", VA = "0x1528D30")]
		public void Scale(ref Vector3d scale)
		{
		}

		[Token(Token = "0x600011E")]
		[Address(RVA = "0x1528D60", Offset = "0x1528D60", VA = "0x1528D60")]
		public void Normalize()
		{
		}

		[Token(Token = "0x600011F")]
		[Address(RVA = "0x1528DB8", Offset = "0x1528DB8", VA = "0x1528DB8")]
		public void Clamp(double min, double max)
		{
		}

		[Token(Token = "0x6000120")]
		[Address(RVA = "0x1528E18", Offset = "0x1528E18", VA = "0x1528E18", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x6000121")]
		[Address(RVA = "0x1528E6C", Offset = "0x1528E6C", VA = "0x1528E6C", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Token(Token = "0x6000122")]
		[Address(RVA = "0x1528F14", Offset = "0x1528F14", VA = "0x1528F14", Slot = "4")]
		public bool Equals(Vector3d other)
		{
			return default(bool);
		}

		[Token(Token = "0x6000123")]
		[Address(RVA = "0x1528F44", Offset = "0x1528F44", VA = "0x1528F44", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000124")]
		[Address(RVA = "0x1529038", Offset = "0x1529038", VA = "0x1529038")]
		public string ToString(string format)
		{
			return null;
		}

		[Token(Token = "0x6000125")]
		[Address(RVA = "0x1529128", Offset = "0x1529128", VA = "0x1529128")]
		public static double Dot(ref Vector3d lhs, ref Vector3d rhs)
		{
			return default(double);
		}

		[Token(Token = "0x6000126")]
		[Address(RVA = "0x1529150", Offset = "0x1529150", VA = "0x1529150")]
		public static void Cross(ref Vector3d lhs, ref Vector3d rhs, out Vector3d result)
		{
		}

		[Token(Token = "0x6000127")]
		[Address(RVA = "0x152601C", Offset = "0x152601C", VA = "0x152601C")]
		public static double Angle(ref Vector3d from, ref Vector3d to)
		{
			return default(double);
		}

		[Token(Token = "0x6000128")]
		[Address(RVA = "0x1529190", Offset = "0x1529190", VA = "0x1529190")]
		public static void Lerp(ref Vector3d a, ref Vector3d b, double t, out Vector3d result)
		{
		}

		[Token(Token = "0x6000129")]
		[Address(RVA = "0x15291C4", Offset = "0x15291C4", VA = "0x15291C4")]
		public static void Scale(ref Vector3d a, ref Vector3d b, out Vector3d result)
		{
		}

		[Token(Token = "0x600012A")]
		[Address(RVA = "0x15288E4", Offset = "0x15288E4", VA = "0x15288E4")]
		public static void Normalize(ref Vector3d value, out Vector3d result)
		{
		}
	}
	[Token(Token = "0x2000017")]
	[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0xC84D40", Offset = "0xC84D40")]
	public struct Vector3i : IEquatable<Vector3i>
	{
		[Token(Token = "0x400006B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly Vector3i zero;

		[Token(Token = "0x400006C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int x;

		[Token(Token = "0x400006D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public int y;

		[Token(Token = "0x400006E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public int z;

		[Token(Token = "0x17000028")]
		public int Magnitude
		{
			[Token(Token = "0x600012C")]
			[Address(RVA = "0x152923C", Offset = "0x152923C", VA = "0x152923C")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000029")]
		public int MagnitudeSqr
		{
			[Token(Token = "0x600012D")]
			[Address(RVA = "0x15292D4", Offset = "0x15292D4", VA = "0x15292D4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700002A")]
		public int Item
		{
			[Token(Token = "0x600012E")]
			[Address(RVA = "0x15292EC", Offset = "0x15292EC", VA = "0x15292EC")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600012F")]
			[Address(RVA = "0x1529398", Offset = "0x1529398", VA = "0x1529398")]
			set
			{
			}
		}

		[Token(Token = "0x6000130")]
		[Address(RVA = "0x1529448", Offset = "0x1529448", VA = "0x1529448")]
		public Vector3i(int value)
		{
		}

		[Token(Token = "0x6000131")]
		[Address(RVA = "0x1529454", Offset = "0x1529454", VA = "0x1529454")]
		public Vector3i(int x, int y, int z)
		{
		}

		[Token(Token = "0x6000132")]
		[Address(RVA = "0x1529460", Offset = "0x1529460", VA = "0x1529460")]
		public static Vector3i operator +(Vector3i a, Vector3i b)
		{
			return default(Vector3i);
		}

		[Token(Token = "0x6000133")]
		[Address(RVA = "0x152947C", Offset = "0x152947C", VA = "0x152947C")]
		public static Vector3i operator -(Vector3i a, Vector3i b)
		{
			return default(Vector3i);
		}

		[Token(Token = "0x6000134")]
		[Address(RVA = "0x1529498", Offset = "0x1529498", VA = "0x1529498")]
		public static Vector3i operator *(Vector3i a, int d)
		{
			return default(Vector3i);
		}

		[Token(Token = "0x6000135")]
		[Address(RVA = "0x15294B0", Offset = "0x15294B0", VA = "0x15294B0")]
		public static Vector3i operator *(int d, Vector3i a)
		{
			return default(Vector3i);
		}

		[Token(Token = "0x6000136")]
		[Address(RVA = "0x15294CC", Offset = "0x15294CC", VA = "0x15294CC")]
		public static Vector3i operator /(Vector3i a, int d)
		{
			return default(Vector3i);
		}

		[Token(Token = "0x6000137")]
		[Address(RVA = "0x15294E4", Offset = "0x15294E4", VA = "0x15294E4")]
		public static Vector3i operator -(Vector3i a)
		{
			return default(Vector3i);
		}

		[Token(Token = "0x6000138")]
		[Address(RVA = "0x15294FC", Offset = "0x15294FC", VA = "0x15294FC")]
		public static bool operator ==(Vector3i lhs, Vector3i rhs)
		{
			return default(bool);
		}

		[Token(Token = "0x6000139")]
		[Address(RVA = "0x152952C", Offset = "0x152952C", VA = "0x152952C")]
		public static bool operator !=(Vector3i lhs, Vector3i rhs)
		{
			return default(bool);
		}

		[Token(Token = "0x600013A")]
		[Address(RVA = "0x152955C", Offset = "0x152955C", VA = "0x152955C")]
		public static implicit operator Vector3i(Vector3 v)
		{
			return default(Vector3i);
		}

		[Token(Token = "0x600013B")]
		[Address(RVA = "0x1529570", Offset = "0x1529570", VA = "0x1529570")]
		public static explicit operator Vector3i(Vector3d v)
		{
			return default(Vector3i);
		}

		[Token(Token = "0x600013C")]
		[Address(RVA = "0x1529584", Offset = "0x1529584", VA = "0x1529584")]
		public void Set(int x, int y, int z)
		{
		}

		[Token(Token = "0x600013D")]
		[Address(RVA = "0x1529590", Offset = "0x1529590", VA = "0x1529590")]
		public void Scale(ref Vector3i scale)
		{
		}

		[Token(Token = "0x600013E")]
		[Address(RVA = "0x15295C0", Offset = "0x15295C0", VA = "0x15295C0")]
		public void Clamp(int min, int max)
		{
		}

		[Token(Token = "0x600013F")]
		[Address(RVA = "0x1529620", Offset = "0x1529620", VA = "0x1529620", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x6000140")]
		[Address(RVA = "0x1529674", Offset = "0x1529674", VA = "0x1529674", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Token(Token = "0x6000141")]
		[Address(RVA = "0x152971C", Offset = "0x152971C", VA = "0x152971C", Slot = "4")]
		public bool Equals(Vector3i other)
		{
			return default(bool);
		}

		[Token(Token = "0x6000142")]
		[Address(RVA = "0x1529750", Offset = "0x1529750", VA = "0x1529750", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000143")]
		[Address(RVA = "0x1529830", Offset = "0x1529830", VA = "0x1529830")]
		public string ToString(string format)
		{
			return null;
		}

		[Token(Token = "0x6000144")]
		[Address(RVA = "0x1529920", Offset = "0x1529920", VA = "0x1529920")]
		public static void Scale(ref Vector3i a, ref Vector3i b, out Vector3i result)
		{
		}
	}
	[Token(Token = "0x2000018")]
	[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0xC84D78", Offset = "0xC84D78")]
	public struct Vector4 : IEquatable<Vector4>
	{
		[Token(Token = "0x400006F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly Vector4 zero;

		[Token(Token = "0x4000070")]
		public const float Epsilon = 9.9999994E-11f;

		[Token(Token = "0x4000071")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float x;

		[Token(Token = "0x4000072")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public float y;

		[Token(Token = "0x4000073")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public float z;

		[Token(Token = "0x4000074")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public float w;

		[Token(Token = "0x1700002B")]
		public float Magnitude
		{
			[Token(Token = "0x6000146")]
			[Address(RVA = "0x1529998", Offset = "0x1529998", VA = "0x1529998")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700002C")]
		public float MagnitudeSqr
		{
			[Token(Token = "0x6000147")]
			[Address(RVA = "0x1529A50", Offset = "0x1529A50", VA = "0x1529A50")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700002D")]
		public Vector4 Normalized
		{
			[Token(Token = "0x6000148")]
			[Address(RVA = "0x1529A78", Offset = "0x1529A78", VA = "0x1529A78")]
			get
			{
				return default(Vector4);
			}
		}

		[Token(Token = "0x1700002E")]
		public float Item
		{
			[Token(Token = "0x6000149")]
			[Address(RVA = "0x1529B9C", Offset = "0x1529B9C", VA = "0x1529B9C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600014A")]
			[Address(RVA = "0x1529C5C", Offset = "0x1529C5C", VA = "0x1529C5C")]
			set
			{
			}
		}

		[Token(Token = "0x600014B")]
		[Address(RVA = "0x1529D28", Offset = "0x1529D28", VA = "0x1529D28")]
		public Vector4(float value)
		{
		}

		[Token(Token = "0x600014C")]
		[Address(RVA = "0x1524668", Offset = "0x1524668", VA = "0x1524668")]
		public Vector4(float x, float y, float z, float w)
		{
		}

		[Token(Token = "0x600014D")]
		[Address(RVA = "0x1529D34", Offset = "0x1529D34", VA = "0x1529D34")]
		public static Vector4 operator +(Vector4 a, Vector4 b)
		{
			return default(Vector4);
		}

		[Token(Token = "0x600014E")]
		[Address(RVA = "0x1529D48", Offset = "0x1529D48", VA = "0x1529D48")]
		public static Vector4 operator -(Vector4 a, Vector4 b)
		{
			return default(Vector4);
		}

		[Token(Token = "0x600014F")]
		[Address(RVA = "0x1529D5C", Offset = "0x1529D5C", VA = "0x1529D5C")]
		public static Vector4 operator *(Vector4 a, float d)
		{
			return default(Vector4);
		}

		[Token(Token = "0x6000150")]
		[Address(RVA = "0x1529D70", Offset = "0x1529D70", VA = "0x1529D70")]
		public static Vector4 operator *(float d, Vector4 a)
		{
			return default(Vector4);
		}

		[Token(Token = "0x6000151")]
		[Address(RVA = "0x1529D88", Offset = "0x1529D88", VA = "0x1529D88")]
		public static Vector4 operator /(Vector4 a, float d)
		{
			return default(Vector4);
		}

		[Token(Token = "0x6000152")]
		[Address(RVA = "0x1529D9C", Offset = "0x1529D9C", VA = "0x1529D9C")]
		public static Vector4 operator -(Vector4 a)
		{
			return default(Vector4);
		}

		[Token(Token = "0x6000153")]
		[Address(RVA = "0x1524674", Offset = "0x1524674", VA = "0x1524674")]
		public static bool operator ==(Vector4 lhs, Vector4 rhs)
		{
			return default(bool);
		}

		[Token(Token = "0x6000154")]
		[Address(RVA = "0x1529DB0", Offset = "0x1529DB0", VA = "0x1529DB0")]
		public static bool operator !=(Vector4 lhs, Vector4 rhs)
		{
			return default(bool);
		}

		[Token(Token = "0x6000155")]
		[Address(RVA = "0x1529E88", Offset = "0x1529E88", VA = "0x1529E88")]
		public static explicit operator Vector4(Vector4d v)
		{
			return default(Vector4);
		}

		[Token(Token = "0x6000156")]
		[Address(RVA = "0x1529E9C", Offset = "0x1529E9C", VA = "0x1529E9C")]
		public static implicit operator Vector4(Vector4i v)
		{
			return default(Vector4);
		}

		[Token(Token = "0x6000157")]
		[Address(RVA = "0x1529EB8", Offset = "0x1529EB8", VA = "0x1529EB8")]
		public void Set(float x, float y, float z, float w)
		{
		}

		[Token(Token = "0x6000158")]
		[Address(RVA = "0x1529EC4", Offset = "0x1529EC4", VA = "0x1529EC4")]
		public void Scale(ref Vector4 scale)
		{
		}

		[Token(Token = "0x6000159")]
		[Address(RVA = "0x1529F00", Offset = "0x1529F00", VA = "0x1529F00")]
		public void Normalize()
		{
		}

		[Token(Token = "0x600015A")]
		[Address(RVA = "0x1529F48", Offset = "0x1529F48", VA = "0x1529F48")]
		public void Clamp(float min, float max)
		{
		}

		[Token(Token = "0x600015B")]
		[Address(RVA = "0x1529FC8", Offset = "0x1529FC8", VA = "0x1529FC8", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x600015C")]
		[Address(RVA = "0x152A030", Offset = "0x152A030", VA = "0x152A030", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Token(Token = "0x600015D")]
		[Address(RVA = "0x152A0E8", Offset = "0x152A0E8", VA = "0x152A0E8", Slot = "4")]
		public bool Equals(Vector4 other)
		{
			return default(bool);
		}

		[Token(Token = "0x600015E")]
		[Address(RVA = "0x152A124", Offset = "0x152A124", VA = "0x152A124", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x600015F")]
		[Address(RVA = "0x152A33C", Offset = "0x152A33C", VA = "0x152A33C")]
		public string ToString(string format)
		{
			return null;
		}

		[Token(Token = "0x6000160")]
		[Address(RVA = "0x152A550", Offset = "0x152A550", VA = "0x152A550")]
		public static float Dot(ref Vector4 lhs, ref Vector4 rhs)
		{
			return default(float);
		}

		[Token(Token = "0x6000161")]
		[Address(RVA = "0x152A580", Offset = "0x152A580", VA = "0x152A580")]
		public static void Lerp(ref Vector4 a, ref Vector4 b, float t, out Vector4 result)
		{
		}

		[Token(Token = "0x6000162")]
		[Address(RVA = "0x152A59C", Offset = "0x152A59C", VA = "0x152A59C")]
		public static void Scale(ref Vector4 a, ref Vector4 b, out Vector4 result)
		{
		}

		[Token(Token = "0x6000163")]
		[Address(RVA = "0x1529AF8", Offset = "0x1529AF8", VA = "0x1529AF8")]
		public static void Normalize(ref Vector4 value, out Vector4 result)
		{
		}
	}
	[Token(Token = "0x2000019")]
	[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0xC84DB0", Offset = "0xC84DB0")]
	public struct Vector4d : IEquatable<Vector4d>
	{
		[Token(Token = "0x4000075")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly Vector4d zero;

		[Token(Token = "0x4000076")]
		public const double Epsilon = double.Epsilon;

		[Token(Token = "0x4000077")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public double x;

		[Token(Token = "0x4000078")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public double y;

		[Token(Token = "0x4000079")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public double z;

		[Token(Token = "0x400007A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public double w;

		[Token(Token = "0x1700002F")]
		public double Magnitude
		{
			[Token(Token = "0x6000165")]
			[Address(RVA = "0x152A600", Offset = "0x152A600", VA = "0x152A600")]
			get
			{
				return default(double);
			}
		}

		[Token(Token = "0x17000030")]
		public double MagnitudeSqr
		{
			[Token(Token = "0x6000166")]
			[Address(RVA = "0x152A6B8", Offset = "0x152A6B8", VA = "0x152A6B8")]
			get
			{
				return default(double);
			}
		}

		[Token(Token = "0x17000031")]
		public Vector4d Normalized
		{
			[Token(Token = "0x6000167")]
			[Address(RVA = "0x152A6E0", Offset = "0x152A6E0", VA = "0x152A6E0")]
			get
			{
				return default(Vector4d);
			}
		}

		[Token(Token = "0x17000032")]
		public double Item
		{
			[Token(Token = "0x6000168")]
			[Address(RVA = "0x152A810", Offset = "0x152A810", VA = "0x152A810")]
			get
			{
				return default(double);
			}
			[Token(Token = "0x6000169")]
			[Address(RVA = "0x152A8D0", Offset = "0x152A8D0", VA = "0x152A8D0")]
			set
			{
			}
		}

		[Token(Token = "0x600016A")]
		[Address(RVA = "0x152A99C", Offset = "0x152A99C", VA = "0x152A99C")]
		public Vector4d(double value)
		{
		}

		[Token(Token = "0x600016B")]
		[Address(RVA = "0x152A9A8", Offset = "0x152A9A8", VA = "0x152A9A8")]
		public Vector4d(double x, double y, double z, double w)
		{
		}

		[Token(Token = "0x600016C")]
		[Address(RVA = "0x152A9B4", Offset = "0x152A9B4", VA = "0x152A9B4")]
		public static Vector4d operator +(Vector4d a, Vector4d b)
		{
			return default(Vector4d);
		}

		[Token(Token = "0x600016D")]
		[Address(RVA = "0x152A9C8", Offset = "0x152A9C8", VA = "0x152A9C8")]
		public static Vector4d operator -(Vector4d a, Vector4d b)
		{
			return default(Vector4d);
		}

		[Token(Token = "0x600016E")]
		[Address(RVA = "0x152A9DC", Offset = "0x152A9DC", VA = "0x152A9DC")]
		public static Vector4d operator *(Vector4d a, double d)
		{
			return default(Vector4d);
		}

		[Token(Token = "0x600016F")]
		[Address(RVA = "0x152A9F0", Offset = "0x152A9F0", VA = "0x152A9F0")]
		public static Vector4d operator *(double d, Vector4d a)
		{
			return default(Vector4d);
		}

		[Token(Token = "0x6000170")]
		[Address(RVA = "0x152AA08", Offset = "0x152AA08", VA = "0x152AA08")]
		public static Vector4d operator /(Vector4d a, double d)
		{
			return default(Vector4d);
		}

		[Token(Token = "0x6000171")]
		[Address(RVA = "0x152AA1C", Offset = "0x152AA1C", VA = "0x152AA1C")]
		public static Vector4d operator -(Vector4d a)
		{
			return default(Vector4d);
		}

		[Token(Token = "0x6000172")]
		[Address(RVA = "0x152AA30", Offset = "0x152AA30", VA = "0x152AA30")]
		public static bool operator ==(Vector4d lhs, Vector4d rhs)
		{
			return default(bool);
		}

		[Token(Token = "0x6000173")]
		[Address(RVA = "0x152AB08", Offset = "0x152AB08", VA = "0x152AB08")]
		public static bool operator !=(Vector4d lhs, Vector4d rhs)
		{
			return default(bool);
		}

		[Token(Token = "0x6000174")]
		[Address(RVA = "0x152ABE0", Offset = "0x152ABE0", VA = "0x152ABE0")]
		public static implicit operator Vector4d(Vector4 v)
		{
			return default(Vector4d);
		}

		[Token(Token = "0x6000175")]
		[Address(RVA = "0x152ABF4", Offset = "0x152ABF4", VA = "0x152ABF4")]
		public static implicit operator Vector4d(Vector4i v)
		{
			return default(Vector4d);
		}

		[Token(Token = "0x6000176")]
		[Address(RVA = "0x152AC10", Offset = "0x152AC10", VA = "0x152AC10")]
		public void Set(double x, double y, double z, double w)
		{
		}

		[Token(Token = "0x6000177")]
		[Address(RVA = "0x152AC1C", Offset = "0x152AC1C", VA = "0x152AC1C")]
		public void Scale(ref Vector4d scale)
		{
		}

		[Token(Token = "0x6000178")]
		[Address(RVA = "0x152AC58", Offset = "0x152AC58", VA = "0x152AC58")]
		public void Normalize()
		{
		}

		[Token(Token = "0x6000179")]
		[Address(RVA = "0x152ACAC", Offset = "0x152ACAC", VA = "0x152ACAC")]
		public void Clamp(double min, double max)
		{
		}

		[Token(Token = "0x600017A")]
		[Address(RVA = "0x152AD2C", Offset = "0x152AD2C", VA = "0x152AD2C", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x600017B")]
		[Address(RVA = "0x152AD94", Offset = "0x152AD94", VA = "0x152AD94", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Token(Token = "0x600017C")]
		[Address(RVA = "0x152AE4C", Offset = "0x152AE4C", VA = "0x152AE4C", Slot = "4")]
		public bool Equals(Vector4d other)
		{
			return default(bool);
		}

		[Token(Token = "0x600017D")]
		[Address(RVA = "0x152AE88", Offset = "0x152AE88", VA = "0x152AE88", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x600017E")]
		[Address(RVA = "0x152B0A0", Offset = "0x152B0A0", VA = "0x152B0A0")]
		public string ToString(string format)
		{
			return null;
		}

		[Token(Token = "0x600017F")]
		[Address(RVA = "0x152B2B4", Offset = "0x152B2B4", VA = "0x152B2B4")]
		public static double Dot(ref Vector4d lhs, ref Vector4d rhs)
		{
			return default(double);
		}

		[Token(Token = "0x6000180")]
		[Address(RVA = "0x152B2E4", Offset = "0x152B2E4", VA = "0x152B2E4")]
		public static void Lerp(ref Vector4d a, ref Vector4d b, double t, out Vector4d result)
		{
		}

		[Token(Token = "0x6000181")]
		[Address(RVA = "0x152B30C", Offset = "0x152B30C", VA = "0x152B30C")]
		public static void Scale(ref Vector4d a, ref Vector4d b, out Vector4d result)
		{
		}

		[Token(Token = "0x6000182")]
		[Address(RVA = "0x152A764", Offset = "0x152A764", VA = "0x152A764")]
		public static void Normalize(ref Vector4d value, out Vector4d result)
		{
		}
	}
	[Token(Token = "0x200001A")]
	[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0xC84DE8", Offset = "0xC84DE8")]
	public struct Vector4i : IEquatable<Vector4i>
	{
		[Token(Token = "0x400007B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly Vector4i zero;

		[Token(Token = "0x400007C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int x;

		[Token(Token = "0x400007D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public int y;

		[Token(Token = "0x400007E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public int z;

		[Token(Token = "0x400007F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public int w;

		[Token(Token = "0x17000033")]
		public int Magnitude
		{
			[Token(Token = "0x6000184")]
			[Address(RVA = "0x152B378", Offset = "0x152B378", VA = "0x152B378")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000034")]
		public int MagnitudeSqr
		{
			[Token(Token = "0x6000185")]
			[Address(RVA = "0x152B414", Offset = "0x152B414", VA = "0x152B414")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000035")]
		public int Item
		{
			[Token(Token = "0x6000186")]
			[Address(RVA = "0x152B428", Offset = "0x152B428", VA = "0x152B428")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000187")]
			[Address(RVA = "0x152B4E8", Offset = "0x152B4E8", VA = "0x152B4E8")]
			set
			{
			}
		}

		[Token(Token = "0x6000188")]
		[Address(RVA = "0x152B5AC", Offset = "0x152B5AC", VA = "0x152B5AC")]
		public Vector4i(int value)
		{
		}

		[Token(Token = "0x6000189")]
		[Address(RVA = "0x152B5B8", Offset = "0x152B5B8", VA = "0x152B5B8")]
		public Vector4i(int x, int y, int z, int w)
		{
		}

		[Token(Token = "0x600018A")]
		[Address(RVA = "0x152B5C4", Offset = "0x152B5C4", VA = "0x152B5C4")]
		public static Vector4i operator +(Vector4i a, Vector4i b)
		{
			return default(Vector4i);
		}

		[Token(Token = "0x600018B")]
		[Address(RVA = "0x152B5F0", Offset = "0x152B5F0", VA = "0x152B5F0")]
		public static Vector4i operator -(Vector4i a, Vector4i b)
		{
			return default(Vector4i);
		}

		[Token(Token = "0x600018C")]
		[Address(RVA = "0x152B61C", Offset = "0x152B61C", VA = "0x152B61C")]
		public static Vector4i operator *(Vector4i a, int d)
		{
			return default(Vector4i);
		}

		[Token(Token = "0x600018D")]
		[Address(RVA = "0x152B640", Offset = "0x152B640", VA = "0x152B640")]
		public static Vector4i operator *(int d, Vector4i a)
		{
			return default(Vector4i);
		}

		[Token(Token = "0x600018E")]
		[Address(RVA = "0x152B668", Offset = "0x152B668", VA = "0x152B668")]
		public static Vector4i operator /(Vector4i a, int d)
		{
			return default(Vector4i);
		}

		[Token(Token = "0x600018F")]
		[Address(RVA = "0x152B68C", Offset = "0x152B68C", VA = "0x152B68C")]
		public static Vector4i operator -(Vector4i a)
		{
			return default(Vector4i);
		}

		[Token(Token = "0x6000190")]
		[Address(RVA = "0x152B6B0", Offset = "0x152B6B0", VA = "0x152B6B0")]
		public static bool operator ==(Vector4i lhs, Vector4i rhs)
		{
			return default(bool);
		}

		[Token(Token = "0x6000191")]
		[Address(RVA = "0x152B6EC", Offset = "0x152B6EC", VA = "0x152B6EC")]
		public static bool operator !=(Vector4i lhs, Vector4i rhs)
		{
			return default(bool);
		}

		[Token(Token = "0x6000192")]
		[Address(RVA = "0x152B728", Offset = "0x152B728", VA = "0x152B728")]
		public static explicit operator Vector4i(Vector4 v)
		{
			return default(Vector4i);
		}

		[Token(Token = "0x6000193")]
		[Address(RVA = "0x152B744", Offset = "0x152B744", VA = "0x152B744")]
		public static explicit operator Vector4i(Vector4d v)
		{
			return default(Vector4i);
		}

		[Token(Token = "0x6000194")]
		[Address(RVA = "0x152B760", Offset = "0x152B760", VA = "0x152B760")]
		public void Set(int x, int y, int z, int w)
		{
		}

		[Token(Token = "0x6000195")]
		[Address(RVA = "0x152B76C", Offset = "0x152B76C", VA = "0x152B76C")]
		public void Scale(ref Vector4i scale)
		{
		}

		[Token(Token = "0x6000196")]
		[Address(RVA = "0x152B7A8", Offset = "0x152B7A8", VA = "0x152B7A8")]
		public void Clamp(int min, int max)
		{
		}

		[Token(Token = "0x6000197")]
		[Address(RVA = "0x152B828", Offset = "0x152B828", VA = "0x152B828", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x6000198")]
		[Address(RVA = "0x152B890", Offset = "0x152B890", VA = "0x152B890", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Token(Token = "0x6000199")]
		[Address(RVA = "0x152B948", Offset = "0x152B948", VA = "0x152B948", Slot = "4")]
		public bool Equals(Vector4i other)
		{
			return default(bool);
		}

		[Token(Token = "0x600019A")]
		[Address(RVA = "0x152B98C", Offset = "0x152B98C", VA = "0x152B98C", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x600019B")]
		[Address(RVA = "0x152BB8C", Offset = "0x152BB8C", VA = "0x152BB8C")]
		public string ToString(string format)
		{
			return null;
		}

		[Token(Token = "0x600019C")]
		[Address(RVA = "0x152BDA0", Offset = "0x152BDA0", VA = "0x152BDA0")]
		public static void Scale(ref Vector4i a, ref Vector4i b, out Vector4i result)
		{
		}
	}
}
namespace HellTap.MeshDecimator.Loggers
{
	[Token(Token = "0x200001B")]
	public sealed class ConsoleLogger : ILogger
	{
		[Token(Token = "0x600019E")]
		[Address(RVA = "0x1524F28", Offset = "0x1524F28", VA = "0x1524F28", Slot = "4")]
		public void LogVerbose(string text)
		{
		}

		[Token(Token = "0x600019F")]
		[Address(RVA = "0x1524F90", Offset = "0x1524F90", VA = "0x1524F90", Slot = "5")]
		public void LogWarning(string text)
		{
		}

		[Token(Token = "0x60001A0")]
		[Address(RVA = "0x1524FF8", Offset = "0x1524FF8", VA = "0x1524FF8", Slot = "6")]
		public void LogError(string text)
		{
		}

		[Token(Token = "0x60001A1")]
		[Address(RVA = "0x15250C0", Offset = "0x15250C0", VA = "0x15250C0")]
		public ConsoleLogger()
		{
		}
	}
}
namespace HellTap.MeshDecimator.Collections
{
	[Token(Token = "0x200001C")]
	[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0xC84E20", Offset = "0xC84E20")]
	internal sealed class ResizableArray<T>
	{
		[Token(Token = "0x4000080")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private T[] items;

		[Token(Token = "0x4000081")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int length;

		[Token(Token = "0x4000082")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static T[] emptyArr;

		[Token(Token = "0x17000036")]
		public int Length
		{
			[Token(Token = "0x60001A2")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000037")]
		public T[] Data
		{
			[Token(Token = "0x60001A3")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000038")]
		public T Item
		{
			[Token(Token = "0x60001A4")]
			get
			{
				return (T)null;
			}
			[Token(Token = "0x60001A5")]
			set
			{
			}
		}

		[Token(Token = "0x60001A6")]
		public ResizableArray(int capacity)
		{
		}

		[Token(Token = "0x60001A7")]
		public ResizableArray(int capacity, int length)
		{
		}

		[Token(Token = "0x60001A8")]
		private void IncreaseCapacity(int capacity)
		{
		}

		[Token(Token = "0x60001A9")]
		public void Clear()
		{
		}

		[Token(Token = "0x60001AA")]
		public void Resize(int length, bool trimExess = false)
		{
		}

		[Token(Token = "0x60001AB")]
		public void TrimExcess()
		{
		}

		[Token(Token = "0x60001AC")]
		public void Add(T item)
		{
		}
	}
	[Token(Token = "0x200001D")]
	[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0xC84E58", Offset = "0xC84E58")]
	internal sealed class UVChannels<TVec>
	{
		[Token(Token = "0x4000083")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private ResizableArray<TVec>[] channels;

		[Token(Token = "0x4000084")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private TVec[][] channelsData;

		[Token(Token = "0x17000039")]
		public TVec[][] Data
		{
			[Token(Token = "0x60001AE")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700003A")]
		public ResizableArray<TVec> Item
		{
			[Token(Token = "0x60001AF")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001B0")]
			set
			{
			}
		}

		[Token(Token = "0x60001B1")]
		public UVChannels()
		{
		}

		[Token(Token = "0x60001B2")]
		public void Resize(int capacity, bool trimExess = false)
		{
		}
	}
}
namespace HellTap.MeshDecimator.Algorithms
{
	[Token(Token = "0x200001E")]
	public abstract class DecimationAlgorithm
	{
		[Token(Token = "0x2000138")]
		public delegate void StatusReportCallback(int iteration, int originalTris, int currentTris, int targetTris);

		[Token(Token = "0x4000085")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private bool preserveBorders;

		[Token(Token = "0x4000086")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private int maxVertexCount;

		[Token(Token = "0x4000087")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private bool verbose;

		[Token(Token = "0x4000088")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private StatusReportCallback statusReportInvoker;

		[Token(Token = "0x1700003B")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0xC86D68", Offset = "0xC86D68")]
		public bool KeepBorders
		{
			[Token(Token = "0x60001B3")]
			[Address(RVA = "0xFD0228", Offset = "0xFD0228", VA = "0xFD0228")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60001B4")]
			[Address(RVA = "0xFD0230", Offset = "0xFD0230", VA = "0xFD0230")]
			set
			{
			}
		}

		[Token(Token = "0x1700003C")]
		public bool PreserveBorders
		{
			[Token(Token = "0x60001B5")]
			[Address(RVA = "0xFD023C", Offset = "0xFD023C", VA = "0xFD023C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60001B6")]
			[Address(RVA = "0xFD0244", Offset = "0xFD0244", VA = "0xFD0244")]
			set
			{
			}
		}

		[Token(Token = "0x1700003D")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0xC86DA4", Offset = "0xC86DA4")]
		public bool KeepLinkedVertices
		{
			[Token(Token = "0x60001B7")]
			[Address(RVA = "0xFD0250", Offset = "0xFD0250", VA = "0xFD0250")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60001B8")]
			[Address(RVA = "0xFD0258", Offset = "0xFD0258", VA = "0xFD0258")]
			set
			{
			}
		}

		[Token(Token = "0x1700003E")]
		public int MaxVertexCount
		{
			[Token(Token = "0x60001B9")]
			[Address(RVA = "0xFD025C", Offset = "0xFD025C", VA = "0xFD025C")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60001BA")]
			[Address(RVA = "0xFD0264", Offset = "0xFD0264", VA = "0xFD0264")]
			set
			{
			}
		}

		[Token(Token = "0x1700003F")]
		public bool Verbose
		{
			[Token(Token = "0x60001BB")]
			[Address(RVA = "0xFD0294", Offset = "0xFD0294", VA = "0xFD0294")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60001BC")]
			[Address(RVA = "0xFD029C", Offset = "0xFD029C", VA = "0xFD029C")]
			set
			{
			}
		}

		[Token(Token = "0x14000001")]
		public event StatusReportCallback StatusReport
		{
			[Token(Token = "0x60001BD")]
			[Address(RVA = "0xFD02A8", Offset = "0xFD02A8", VA = "0xFD02A8")]
			add
			{
			}
			[Token(Token = "0x60001BE")]
			[Address(RVA = "0xFD0338", Offset = "0xFD0338", VA = "0xFD0338")]
			remove
			{
			}
		}

		[Token(Token = "0x60001BF")]
		[Address(RVA = "0xFD03C8", Offset = "0xFD03C8", VA = "0xFD03C8")]
		protected void ReportStatus(int iteration, int originalTris, int currentTris, int targetTris)
		{
		}

		[Token(Token = "0x60001C0")]
		public abstract void Initialize(Mesh mesh);

		[Token(Token = "0x60001C1")]
		public abstract void DecimateMesh(int targetTrisCount);

		[Token(Token = "0x60001C2")]
		public abstract void DecimateMeshLossless();

		[Token(Token = "0x60001C3")]
		public abstract Mesh ToMesh();

		[Token(Token = "0x60001C4")]
		[Address(RVA = "0xFD068C", Offset = "0xFD068C", VA = "0xFD068C")]
		protected DecimationAlgorithm()
		{
		}
	}
	[Token(Token = "0x200001F")]
	public sealed class FastQuadricMeshSimplification : DecimationAlgorithm
	{
		[Token(Token = "0x2000139")]
		[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0xC85344", Offset = "0xC85344")]
		private struct Triangle
		{
			[Token(Token = "0x400066A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int v0;

			[Token(Token = "0x400066B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public int v1;

			[Token(Token = "0x400066C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public int v2;

			[Token(Token = "0x400066D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public int subMeshIndex;

			[Token(Token = "0x400066E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public int va0;

			[Token(Token = "0x400066F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public int va1;

			[Token(Token = "0x4000670")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public int va2;

			[Token(Token = "0x4000671")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public double err0;

			[Token(Token = "0x4000672")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public double err1;

			[Token(Token = "0x4000673")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public double err2;

			[Token(Token = "0x4000674")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public double err3;

			[Token(Token = "0x4000675")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public bool deleted;

			[Token(Token = "0x4000676")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x41")]
			public bool dirty;

			[Token(Token = "0x4000677")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public Vector3d n;

			[Token(Token = "0x17000060")]
			public int Item
			{
				[Token(Token = "0x60008FF")]
				[Address(RVA = "0x15242B4", Offset = "0x15242B4", VA = "0x15242B4")]
				get
				{
					return default(int);
				}
				[Token(Token = "0x6000900")]
				[Address(RVA = "0x15242D4", Offset = "0x15242D4", VA = "0x15242D4")]
				set
				{
				}
			}

			[Token(Token = "0x6000901")]
			[Address(RVA = "0x152437C", Offset = "0x152437C", VA = "0x152437C")]
			public Triangle(int v0, int v1, int v2, int subMeshIndex)
			{
			}

			[Token(Token = "0x6000902")]
			[Address(RVA = "0x15243A4", Offset = "0x15243A4", VA = "0x15243A4")]
			public void GetAttributeIndices(int[] attributeIndices)
			{
			}

			[Token(Token = "0x6000903")]
			[Address(RVA = "0x15243F8", Offset = "0x15243F8", VA = "0x15243F8")]
			public void SetAttributeIndex(int index, int value)
			{
			}

			[Token(Token = "0x6000904")]
			[Address(RVA = "0x15244A0", Offset = "0x15244A0", VA = "0x15244A0")]
			public void GetErrors(double[] err)
			{
			}
		}

		[Token(Token = "0x200013A")]
		private struct Vertex
		{
			[Token(Token = "0x4000678")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Vector3d p;

			[Token(Token = "0x4000679")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public int tstart;

			[Token(Token = "0x400067A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public int tcount;

			[Token(Token = "0x400067B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public SymmetricMatrix q;

			[Token(Token = "0x400067C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			public bool border;

			[Token(Token = "0x400067D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x71")]
			public bool seam;

			[Token(Token = "0x400067E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x72")]
			public bool foldover;

			[Token(Token = "0x6000905")]
			[Address(RVA = "0x15244F4", Offset = "0x15244F4", VA = "0x15244F4")]
			public Vertex(Vector3d p)
			{
			}
		}

		[Token(Token = "0x200013B")]
		private struct Ref
		{
			[Token(Token = "0x400067F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int tid;

			[Token(Token = "0x4000680")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public int tvertex;

			[Token(Token = "0x6000906")]
			[Address(RVA = "0x15242AC", Offset = "0x15242AC", VA = "0x15242AC")]
			public void Set(int tid, int tvertex)
			{
			}
		}

		[Token(Token = "0x200013C")]
		private struct BorderVertex
		{
			[Token(Token = "0x4000681")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int index;

			[Token(Token = "0x4000682")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public int hash;

			[Token(Token = "0x6000907")]
			[Address(RVA = "0x1524204", Offset = "0x1524204", VA = "0x1524204")]
			public BorderVertex(int index, int hash)
			{
			}
		}

		[Token(Token = "0x200013D")]
		private class BorderVertexComparer : IComparer<BorderVertex>
		{
			[Token(Token = "0x4000683")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly BorderVertexComparer instance;

			[Token(Token = "0x6000908")]
			[Address(RVA = "0x152420C", Offset = "0x152420C", VA = "0x152420C", Slot = "4")]
			public int Compare(BorderVertex x, BorderVertex y)
			{
				return default(int);
			}

			[Token(Token = "0x6000909")]
			[Address(RVA = "0x152423C", Offset = "0x152423C", VA = "0x152423C")]
			public BorderVertexComparer()
			{
			}
		}

		[Token(Token = "0x4000089")]
		private const double DoubleEpsilon = 0.001;

		[Token(Token = "0x400008A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool preserveSeams;

		[Token(Token = "0x400008B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
		private bool preserveFoldovers;

		[Token(Token = "0x400008C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2A")]
		private bool enableSmartLink;

		[Token(Token = "0x400008D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private int maxIterationCount;

		[Token(Token = "0x400008E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private double agressiveness;

		[Token(Token = "0x400008F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private double vertexLinkDistanceSqr;

		[Token(Token = "0x4000090")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private int subMeshCount;

		[Token(Token = "0x4000091")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private ResizableArray<Triangle> triangles;

		[Token(Token = "0x4000092")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private ResizableArray<Vertex> vertices;

		[Token(Token = "0x4000093")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private ResizableArray<Ref> refs;

		[Token(Token = "0x4000094")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private ResizableArray<HellTap.MeshDecimator.Math.Vector3> vertNormals;

		[Token(Token = "0x4000095")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private ResizableArray<HellTap.MeshDecimator.Math.Vector4> vertTangents;

		[Token(Token = "0x4000096")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private UVChannels<HellTap.MeshDecimator.Math.Vector2> vertUV2D;

		[Token(Token = "0x4000097")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private UVChannels<HellTap.MeshDecimator.Math.Vector3> vertUV3D;

		[Token(Token = "0x4000098")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private UVChannels<HellTap.MeshDecimator.Math.Vector4> vertUV4D;

		[Token(Token = "0x4000099")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private ResizableArray<HellTap.MeshDecimator.Math.Vector4> vertColors;

		[Token(Token = "0x400009A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private ResizableArray<BoneWeight> vertBoneWeights;

		[Token(Token = "0x400009B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private int remainingVertices;

		[Token(Token = "0x400009C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private double[] errArr;

		[Token(Token = "0x400009D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private int[] attributeIndexArr;

		[Token(Token = "0x17000040")]
		public bool PreserveSeams
		{
			[Token(Token = "0x60001C5")]
			[Address(RVA = "0xFD0784", Offset = "0xFD0784", VA = "0xFD0784")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60001C6")]
			[Address(RVA = "0xFD078C", Offset = "0xFD078C", VA = "0xFD078C")]
			set
			{
			}
		}

		[Token(Token = "0x17000041")]
		public bool PreserveFoldovers
		{
			[Token(Token = "0x60001C7")]
			[Address(RVA = "0xFD0798", Offset = "0xFD0798", VA = "0xFD0798")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60001C8")]
			[Address(RVA = "0xFD07A0", Offset = "0xFD07A0", VA = "0xFD07A0")]
			set
			{
			}
		}

		[Token(Token = "0x17000042")]
		public bool EnableSmartLink
		{
			[Token(Token = "0x60001C9")]
			[Address(RVA = "0xFD07AC", Offset = "0xFD07AC", VA = "0xFD07AC")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60001CA")]
			[Address(RVA = "0xFD07B4", Offset = "0xFD07B4", VA = "0xFD07B4")]
			set
			{
			}
		}

		[Token(Token = "0x17000043")]
		public int MaxIterationCount
		{
			[Token(Token = "0x60001CB")]
			[Address(RVA = "0xFD07C0", Offset = "0xFD07C0", VA = "0xFD07C0")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60001CC")]
			[Address(RVA = "0xFD07C8", Offset = "0xFD07C8", VA = "0xFD07C8")]
			set
			{
			}
		}

		[Token(Token = "0x17000044")]
		public double Agressiveness
		{
			[Token(Token = "0x60001CD")]
			[Address(RVA = "0xFD07D0", Offset = "0xFD07D0", VA = "0xFD07D0")]
			get
			{
				return default(double);
			}
			[Token(Token = "0x60001CE")]
			[Address(RVA = "0xFD07D8", Offset = "0xFD07D8", VA = "0xFD07D8")]
			set
			{
			}
		}

		[Token(Token = "0x17000045")]
		public double VertexLinkDistanceSqr
		{
			[Token(Token = "0x60001CF")]
			[Address(RVA = "0xFD07E0", Offset = "0xFD07E0", VA = "0xFD07E0")]
			get
			{
				return default(double);
			}
			[Token(Token = "0x60001D0")]
			[Address(RVA = "0xFD07E8", Offset = "0xFD07E8", VA = "0xFD07E8")]
			set
			{
			}
		}

		[Token(Token = "0x60001D1")]
		[Address(RVA = "0xFD07F0", Offset = "0xFD07F0", VA = "0xFD07F0")]
		public FastQuadricMeshSimplification(bool preserveBorders = false, bool preserveSeams = false, bool preserveFoldovers = false)
		{
		}

		[Token(Token = "0x60001D2")]
		private ResizableArray<T> InitializeVertexAttribute<T>(T[] attributeValues, string attributeName)
		{
			return null;
		}

		[Token(Token = "0x60001D3")]
		[Address(RVA = "0xFD097C", Offset = "0xFD097C", VA = "0xFD097C")]
		private double VertexError(ref SymmetricMatrix q, double x, double y, double z)
		{
			return default(double);
		}

		[Token(Token = "0x60001D4")]
		[Address(RVA = "0xFD0A0C", Offset = "0xFD0A0C", VA = "0xFD0A0C")]
		private double CalculateError(ref Vertex vert0, ref Vertex vert1, out Vector3d result, out int resultIndex)
		{
			return default(double);
		}

		[Token(Token = "0x60001D5")]
		[Address(RVA = "0xFD0CF4", Offset = "0xFD0CF4", VA = "0xFD0CF4")]
		private bool Flipped(ref Vector3d p, int i0, int i1, ref Vertex v0, bool[] deleted)
		{
			return default(bool);
		}

		[Token(Token = "0x60001D6")]
		[Address(RVA = "0xFD10D8", Offset = "0xFD10D8", VA = "0xFD10D8")]
		private void UpdateTriangles(int i0, int ia0, ref Vertex v, ResizableArray<bool> deleted, ref int deletedTriangles)
		{
		}

		[Token(Token = "0x60001D7")]
		[Address(RVA = "0xFD13D4", Offset = "0xFD13D4", VA = "0xFD13D4")]
		private void MoveVertexAttributes(int i0, int i1)
		{
		}

		[Token(Token = "0x60001D8")]
		[Address(RVA = "0xFD1670", Offset = "0xFD1670", VA = "0xFD1670")]
		private void MergeVertexAttributes(int i0, int i1)
		{
		}

		[Token(Token = "0x60001D9")]
		[Address(RVA = "0xFD1BFC", Offset = "0xFD1BFC", VA = "0xFD1BFC")]
		private bool AreUVsTheSame(int channel, int indexA, int indexB)
		{
			return default(bool);
		}

		[Token(Token = "0x60001DA")]
		[Address(RVA = "0xFD1EBC", Offset = "0xFD1EBC", VA = "0xFD1EBC")]
		private void RemoveVertexPass(int startTrisCount, int targetTrisCount, double threshold, ResizableArray<bool> deleted0, ResizableArray<bool> deleted1, ref int deletedTris)
		{
		}

		[Token(Token = "0x60001DB")]
		[Address(RVA = "0xFD24EC", Offset = "0xFD24EC", VA = "0xFD24EC")]
		private void UpdateMesh(int iteration)
		{
		}

		[Token(Token = "0x60001DC")]
		[Address(RVA = "0xFD324C", Offset = "0xFD324C", VA = "0xFD324C")]
		private void UpdateReferences()
		{
		}

		[Token(Token = "0x60001DD")]
		[Address(RVA = "0xFD35C4", Offset = "0xFD35C4", VA = "0xFD35C4")]
		private void CompactMesh()
		{
		}

		[Token(Token = "0x60001DE")]
		[Address(RVA = "0xFD3F08", Offset = "0xFD3F08", VA = "0xFD3F08", Slot = "4")]
		public override void Initialize(Mesh mesh)
		{
		}

		[Token(Token = "0x60001DF")]
		[Address(RVA = "0xFD457C", Offset = "0xFD457C", VA = "0xFD457C", Slot = "5")]
		public override void DecimateMesh(int targetTrisCount)
		{
		}

		[Token(Token = "0x60001E0")]
		[Address(RVA = "0xFD4978", Offset = "0xFD4978", VA = "0xFD4978", Slot = "6")]
		public override void DecimateMeshLossless()
		{
		}

		[Token(Token = "0x60001E1")]
		[Address(RVA = "0xFD4BDC", Offset = "0xFD4BDC", VA = "0xFD4BDC", Slot = "7")]
		public override Mesh ToMesh()
		{
			return null;
		}
	}
}
namespace HellTap.MeshDecimator.Unity
{
	[Token(Token = "0x2000020")]
	public sealed class DecimatedObject : MonoBehaviour
	{
		[Token(Token = "0x400009E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private LODSettings[] levels;

		[Token(Token = "0x400009F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private bool generated;

		[Token(Token = "0x17000046")]
		public LODSettings[] Levels
		{
			[Token(Token = "0x60001E2")]
			[Address(RVA = "0x152F4A0", Offset = "0x152F4A0", VA = "0x152F4A0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001E3")]
			[Address(RVA = "0x152F4A8", Offset = "0x152F4A8", VA = "0x152F4A8")]
			set
			{
			}
		}

		[Token(Token = "0x17000047")]
		public bool IsGenerated
		{
			[Token(Token = "0x60001E4")]
			[Address(RVA = "0x152F4B0", Offset = "0x152F4B0", VA = "0x152F4B0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60001E5")]
		[Address(RVA = "0x152F4B8", Offset = "0x152F4B8", VA = "0x152F4B8")]
		private void Reset()
		{
		}

		[Token(Token = "0x60001E6")]
		[Address(RVA = "0x152F880", Offset = "0x152F880", VA = "0x152F880")]
		public void GenerateLODs([Optional] LODStatusReportCallback statusCallback)
		{
		}

		[Token(Token = "0x60001E7")]
		[Address(RVA = "0x152F854", Offset = "0x152F854", VA = "0x152F854")]
		public void ResetLODs()
		{
		}

		[Token(Token = "0x60001E8")]
		[Address(RVA = "0x1530EE8", Offset = "0x1530EE8", VA = "0x1530EE8")]
		public DecimatedObject()
		{
		}
	}
	[Token(Token = "0x2000021")]
	public delegate void LODStatusReportCallback(int lodLevel, int iteration, int originalTris, int currentTris, int targetTris);
	[Serializable]
	[Token(Token = "0x2000022")]
	public struct LODSettings
	{
		[Token(Token = "0x40000A0")]
		private const string _UNTAGGED = "Untagged";

		[Token(Token = "0x40000A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xC85544", Offset = "0xC85544")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xC85544", Offset = "0xC85544")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xC85544", Offset = "0xC85544")]
		public float lodDistancePercentage;

		[Token(Token = "0x40000A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xC855C4", Offset = "0xC855C4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xC855C4", Offset = "0xC855C4")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xC855C4", Offset = "0xC855C4")]
		public float quality;

		[Token(Token = "0x40000A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		[HideInInspector]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xC85640", Offset = "0xC85640")]
		public bool combineMeshes;

		[Token(Token = "0x40000A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xC8568C", Offset = "0xC8568C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xC8568C", Offset = "0xC8568C")]
		public SkinQuality skinQuality;

		[Token(Token = "0x40000A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xC856EC", Offset = "0xC856EC")]
		public bool receiveShadows;

		[Token(Token = "0x40000A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xC85724", Offset = "0xC85724")]
		public ShadowCastingMode shadowCasting;

		[Token(Token = "0x40000A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xC8575C", Offset = "0xC8575C")]
		public MotionVectorGenerationMode motionVectors;

		[Token(Token = "0x40000A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xC85794", Offset = "0xC85794")]
		public bool skinnedMotionVectors;

		[Token(Token = "0x40000A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xC857CC", Offset = "0xC857CC")]
		public LightProbeUsage lightProbeUsage;

		[Token(Token = "0x40000AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xC85804", Offset = "0xC85804")]
		public ReflectionProbeUsage reflectionProbeUsage;

		[Token(Token = "0x40000AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xC8583C", Offset = "0xC8583C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xC8583C", Offset = "0xC8583C")]
		public string tag;

		[Token(Token = "0x40000AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xC8589C", Offset = "0xC8589C")]
		public int layer;

		[Token(Token = "0x60001ED")]
		[Address(RVA = "0x153390C", Offset = "0x153390C", VA = "0x153390C")]
		public LODSettings(float quality, float lodDistancePercentage = 0.8f)
		{
		}

		[Token(Token = "0x60001EE")]
		[Address(RVA = "0x153399C", Offset = "0x153399C", VA = "0x153399C")]
		public LODSettings(float quality, float lodDistancePercentage, SkinQuality skinQuality)
		{
		}

		[Token(Token = "0x60001EF")]
		[Address(RVA = "0x152F6E4", Offset = "0x152F6E4", VA = "0x152F6E4")]
		public LODSettings(float quality, float lodDistancePercentage, SkinQuality skinQuality, bool receiveShadows, ShadowCastingMode shadowCasting)
		{
		}

		[Token(Token = "0x60001F0")]
		[Address(RVA = "0x152F794", Offset = "0x152F794", VA = "0x152F794")]
		public LODSettings(float quality, float lodDistancePercentage, SkinQuality skinQuality, bool receiveShadows, ShadowCastingMode shadowCasting, MotionVectorGenerationMode motionVectors, bool skinnedMotionVectors)
		{
		}

		[Token(Token = "0x60001F1")]
		[Address(RVA = "0x1533A38", Offset = "0x1533A38", VA = "0x1533A38")]
		public LODSettings(float quality, float lodDistancePercentage, SkinQuality skinQuality, bool receiveShadows, ShadowCastingMode shadowCasting, MotionVectorGenerationMode motionVectors, bool skinnedMotionVectors, LightProbeUsage lightProbeUsage, ReflectionProbeUsage reflectionProbeUsage)
		{
		}

		[Token(Token = "0x60001F2")]
		[Address(RVA = "0x1533B04", Offset = "0x1533B04", VA = "0x1533B04")]
		public LODSettings(float quality, float lodDistancePercentage, SkinQuality skinQuality, bool receiveShadows, ShadowCastingMode shadowCasting, MotionVectorGenerationMode motionVectors, bool skinnedMotionVectors, LightProbeUsage lightProbeUsage, ReflectionProbeUsage reflectionProbeUsage, string tag, int layer)
		{
		}
	}
	[Token(Token = "0x2000023")]
	public static class LODGenerator
	{
		[Token(Token = "0x200013E")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xC8537C", Offset = "0xC8537C")]
		private sealed class <>c__DisplayClass8_0
		{
			[Token(Token = "0x4000684")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public LODStatusReportCallback statusCallback;

			[Token(Token = "0x600090B")]
			[Address(RVA = "0x15335EC", Offset = "0x15335EC", VA = "0x15335EC")]
			public <>c__DisplayClass8_0()
			{
			}
		}

		[Token(Token = "0x200013F")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xC8538C", Offset = "0xC8538C")]
		private sealed class <>c__DisplayClass8_1
		{
			[Token(Token = "0x4000685")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public int levelIndex;

			[Token(Token = "0x4000686")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public <>c__DisplayClass8_0 CS$<>8__locals1;

			[Token(Token = "0x600090C")]
			[Address(RVA = "0x15335F4", Offset = "0x15335F4", VA = "0x15335F4")]
			public <>c__DisplayClass8_1()
			{
			}

			[Token(Token = "0x600090D")]
			[Address(RVA = "0x1533600", Offset = "0x1533600", VA = "0x1533600")]
			internal void <GenerateLODs>b__0(int iteration, int originalTris, int currentTris, int targetTris)
			{
			}
		}

		[Token(Token = "0x40000AD")]
		private const string ParentGameObjectName = "_LOD_";

		[Token(Token = "0x60001F3")]
		[Address(RVA = "0x1530EF0", Offset = "0x1530EF0", VA = "0x1530EF0")]
		private static Renderer[] CombineRenderers(MeshRenderer[] meshRenderers, SkinnedMeshRenderer[] skinnedRenderers)
		{
			return null;
		}

		[Token(Token = "0x60001F4")]
		[Address(RVA = "0x1530FA4", Offset = "0x1530FA4", VA = "0x1530FA4")]
		private static UnityEngine.Mesh GenerateStaticLOD(Transform transform, MeshRenderer renderer, float quality, out Material[] materials, DecimationAlgorithm.StatusReportCallback statusCallback, bool preserveBorders = false, bool preserveSeams = false, bool preserveFoldovers = false)
		{
			return null;
		}

		[Token(Token = "0x60001F5")]
		[Address(RVA = "0x15317A4", Offset = "0x15317A4", VA = "0x15317A4")]
		private static UnityEngine.Mesh GenerateStaticLOD(Transform transform, MeshRenderer[] renderers, float quality, out Material[] materials, DecimationAlgorithm.StatusReportCallback statusCallback, bool preserveBorders = false, bool preserveSeams = false, bool preserveFoldovers = false)
		{
			return null;
		}

		[Token(Token = "0x60001F6")]
		[Address(RVA = "0x1531C14", Offset = "0x1531C14", VA = "0x1531C14")]
		private static UnityEngine.Mesh GenerateSkinnedLOD(Transform transform, SkinnedMeshRenderer renderer, float quality, out Material[] materials, out Transform[] mergedBones, DecimationAlgorithm.StatusReportCallback statusCallback, bool preserveBorders = false, bool preserveSeams = false, bool preserveFoldovers = false)
		{
			return null;
		}

		[Token(Token = "0x60001F7")]
		[Address(RVA = "0x1531E00", Offset = "0x1531E00", VA = "0x1531E00")]
		private static UnityEngine.Mesh GenerateSkinnedLOD(Transform transform, SkinnedMeshRenderer[] renderers, float quality, out Material[] materials, out Transform[] mergedBones, DecimationAlgorithm.StatusReportCallback statusCallback, bool preserveBorders = false, bool preserveSeams = false, bool preserveFoldovers = false)
		{
			return null;
		}

		[Token(Token = "0x60001F8")]
		[Address(RVA = "0x15332F0", Offset = "0x15332F0", VA = "0x15332F0")]
		private static Transform FindRootBone(Transform transform, Transform[] transforms)
		{
			return null;
		}

		[Token(Token = "0x60001F9")]
		[Address(RVA = "0x1533410", Offset = "0x1533410", VA = "0x1533410")]
		private static void SetupLODRenderer(Renderer renderer, LODSettings settings)
		{
		}

		[Token(Token = "0x60001FA")]
		[Address(RVA = "0x152F8D4", Offset = "0x152F8D4", VA = "0x152F8D4")]
		public static void GenerateLODs(GameObject gameObj, LODSettings[] levels, [Optional] LODStatusReportCallback statusCallback, bool preserveBorders = false, bool preserveSeams = false, bool preserveFoldovers = false)
		{
		}

		[Token(Token = "0x60001FB")]
		[Address(RVA = "0x15335FC", Offset = "0x15335FC", VA = "0x15335FC")]
		private static void CopyStaticFlags(GameObject source, GameObject destination)
		{
		}

		[Token(Token = "0x60001FC")]
		[Address(RVA = "0x1530CAC", Offset = "0x1530CAC", VA = "0x1530CAC")]
		public static void DestroyLODs(GameObject gameObj)
		{
		}
	}
	[Token(Token = "0x2000024")]
	public static class MeshDecimatorUtility
	{
		[Token(Token = "0x60001FD")]
		[Address(RVA = "0x1533DA0", Offset = "0x1533DA0", VA = "0x1533DA0")]
		static MeshDecimatorUtility()
		{
		}

		[Token(Token = "0x60001FE")]
		[Address(RVA = "0x1533F00", Offset = "0x1533F00", VA = "0x1533F00")]
		private static Vector3d[] ToSimplifyVertices(UnityEngine.Vector3[] vertices)
		{
			return null;
		}

		[Token(Token = "0x60001FF")]
		[Address(RVA = "0x1533FC4", Offset = "0x1533FC4", VA = "0x1533FC4")]
		private static HellTap.MeshDecimator.Math.Vector2[] ToSimplifyVec(UnityEngine.Vector2[] vectors)
		{
			return null;
		}

		[Token(Token = "0x6000200")]
		[Address(RVA = "0x1534080", Offset = "0x1534080", VA = "0x1534080")]
		private static HellTap.MeshDecimator.Math.Vector3[] ToSimplifyVec(UnityEngine.Vector3[] vectors)
		{
			return null;
		}

		[Token(Token = "0x6000201")]
		[Address(RVA = "0x1534144", Offset = "0x1534144", VA = "0x1534144")]
		private static HellTap.MeshDecimator.Math.Vector4[] ToSimplifyVec(UnityEngine.Vector4[] vectors)
		{
			return null;
		}

		[Token(Token = "0x6000202")]
		[Address(RVA = "0x1534200", Offset = "0x1534200", VA = "0x1534200")]
		private static HellTap.MeshDecimator.Math.Vector4[] ToSimplifyVec(Color[] colors)
		{
			return null;
		}

		[Token(Token = "0x6000203")]
		[Address(RVA = "0x15342BC", Offset = "0x15342BC", VA = "0x15342BC")]
		private static BoneWeight[] ToSimplifyBoneWeights(UnityEngine.BoneWeight[] boneWeights)
		{
			return null;
		}

		[Token(Token = "0x6000204")]
		[Address(RVA = "0x1534454", Offset = "0x1534454", VA = "0x1534454")]
		private static UnityEngine.Vector3[] FromSimplifyVertices(Vector3d[] vertices)
		{
			return null;
		}

		[Token(Token = "0x6000205")]
		[Address(RVA = "0x153455C", Offset = "0x153455C", VA = "0x153455C")]
		private static UnityEngine.Vector2[] FromSimplifyVec(HellTap.MeshDecimator.Math.Vector2[] vectors)
		{
			return null;
		}

		[Token(Token = "0x6000206")]
		[Address(RVA = "0x1534648", Offset = "0x1534648", VA = "0x1534648")]
		private static UnityEngine.Vector3[] FromSimplifyVec(HellTap.MeshDecimator.Math.Vector3[] vectors)
		{
			return null;
		}

		[Token(Token = "0x6000207")]
		[Address(RVA = "0x153474C", Offset = "0x153474C", VA = "0x153474C")]
		private static UnityEngine.Vector4[] FromSimplifyVec(HellTap.MeshDecimator.Math.Vector4[] vectors)
		{
			return null;
		}

		[Token(Token = "0x6000208")]
		[Address(RVA = "0x1534844", Offset = "0x1534844", VA = "0x1534844")]
		private static Color[] FromSimplifyColor(HellTap.MeshDecimator.Math.Vector4[] vectors)
		{
			return null;
		}

		[Token(Token = "0x6000209")]
		[Address(RVA = "0x153493C", Offset = "0x153493C", VA = "0x153493C")]
		private static UnityEngine.BoneWeight[] FromSimplifyBoneWeights(BoneWeight[] boneWeights)
		{
			return null;
		}

		[Token(Token = "0x600020A")]
		[Address(RVA = "0x1534AE0", Offset = "0x1534AE0", VA = "0x1534AE0")]
		private static void AddToList(List<Vector3d> list, UnityEngine.Vector3[] arr, int previousVertexCount, int totalVertexCount)
		{
		}

		[Token(Token = "0x600020B")]
		[Address(RVA = "0x1534BA8", Offset = "0x1534BA8", VA = "0x1534BA8")]
		private static void AddToList(ref List<HellTap.MeshDecimator.Math.Vector2> list, UnityEngine.Vector2[] arr, int previousVertexCount, int currentVertexCount, int totalVertexCount, HellTap.MeshDecimator.Math.Vector2 defaultValue)
		{
		}

		[Token(Token = "0x600020C")]
		[Address(RVA = "0x1534D40", Offset = "0x1534D40", VA = "0x1534D40")]
		private static void AddToList(ref List<HellTap.MeshDecimator.Math.Vector3> list, UnityEngine.Vector3[] arr, int previousVertexCount, int currentVertexCount, int totalVertexCount, HellTap.MeshDecimator.Math.Vector3 defaultValue)
		{
		}

		[Token(Token = "0x600020D")]
		[Address(RVA = "0x1534EEC", Offset = "0x1534EEC", VA = "0x1534EEC")]
		private static void AddToList(ref List<HellTap.MeshDecimator.Math.Vector4> list, UnityEngine.Vector4[] arr, int previousVertexCount, int currentVertexCount, int totalVertexCount, HellTap.MeshDecimator.Math.Vector4 defaultValue)
		{
		}

		[Token(Token = "0x600020E")]
		[Address(RVA = "0x15350A8", Offset = "0x15350A8", VA = "0x15350A8")]
		private static void AddToList(ref List<HellTap.MeshDecimator.Math.Vector4> list, Color[] arr, int previousVertexCount, int currentVertexCount, int totalVertexCount)
		{
		}

		[Token(Token = "0x600020F")]
		[Address(RVA = "0x1535244", Offset = "0x1535244", VA = "0x1535244")]
		private static void AddToList(ref List<BoneWeight> list, UnityEngine.BoneWeight[] arr, int previousVertexCount, int currentVertexCount, int totalVertexCount)
		{
		}

		[Token(Token = "0x6000210")]
		[Address(RVA = "0x15354B4", Offset = "0x15354B4", VA = "0x15354B4")]
		private static void TransformVertices(UnityEngine.Vector3[] vertices, ref Matrix4x4 transform)
		{
		}

		[Token(Token = "0x6000211")]
		[Address(RVA = "0x1535544", Offset = "0x1535544", VA = "0x1535544")]
		private static void TransformVertices(UnityEngine.Vector3[] vertices, UnityEngine.BoneWeight[] boneWeights, Matrix4x4[] oldBindposes, Matrix4x4[] newBindposes)
		{
		}

		[Token(Token = "0x6000212")]
		[Address(RVA = "0x1535C10", Offset = "0x1535C10", VA = "0x1535C10")]
		private static Matrix4x4 ScaleMatrix(ref Matrix4x4 m, float scale)
		{
			return default(Matrix4x4);
		}

		[Token(Token = "0x6000213")]
		private static T[] MergeArrays<T>(T[] arr1, T[] arr2)
		{
			return null;
		}

		[Token(Token = "0x6000214")]
		[Address(RVA = "0x1535C34", Offset = "0x1535C34", VA = "0x1535C34")]
		private static void RemapBones(UnityEngine.BoneWeight[] boneWeights, int[] boneIndices)
		{
		}

		[Token(Token = "0x6000215")]
		[Address(RVA = "0x1535DE0", Offset = "0x1535DE0", VA = "0x1535DE0")]
		private static UnityEngine.Mesh CreateMesh(Matrix4x4[] bindposes, UnityEngine.Vector3[] vertices, Mesh destMesh, bool recalculateNormals)
		{
			return null;
		}

		[Token(Token = "0x6000216")]
		[Address(RVA = "0x1531184", Offset = "0x1531184", VA = "0x1531184")]
		public static UnityEngine.Mesh DecimateMesh(UnityEngine.Mesh mesh, Matrix4x4 transform, float quality, bool recalculateNormals, [Optional] DecimationAlgorithm.StatusReportCallback statusCallback, bool preserveBorders = false, bool preserveSeams = false, bool preserveFoldovers = false)
		{
			return null;
		}

		[Token(Token = "0x6000217")]
		[Address(RVA = "0x1531B3C", Offset = "0x1531B3C", VA = "0x1531B3C")]
		public static UnityEngine.Mesh DecimateMeshes(UnityEngine.Mesh[] meshes, Matrix4x4[] transforms, Material[][] materials, float quality, bool recalculateNormals, out Material[] resultMaterials, [Optional] DecimationAlgorithm.StatusReportCallback statusCallback, bool preserveBorders = false, bool preserveSeams = false, bool preserveFoldovers = false)
		{
			return null;
		}

		[Token(Token = "0x6000218")]
		[Address(RVA = "0x1532204", Offset = "0x1532204", VA = "0x1532204")]
		public static UnityEngine.Mesh DecimateMeshes(UnityEngine.Mesh[] meshes, Matrix4x4[] transforms, Material[][] materials, Transform[][] meshBones, float quality, bool recalculateNormals, out Material[] resultMaterials, out Transform[] mergedBones, [Optional] DecimationAlgorithm.StatusReportCallback statusCallback, bool preserveBorders = false, bool preserveSeams = false, bool preserveFoldovers = false)
		{
			return null;
		}
	}
}
namespace HellTap.MeshDecimator.Unity.Loggers
{
	[Token(Token = "0x2000025")]
	public sealed class UnityLogger : ILogger
	{
		[Token(Token = "0x6000219")]
		[Address(RVA = "0x1533C60", Offset = "0x1533C60", VA = "0x1533C60", Slot = "4")]
		public void LogVerbose(string text)
		{
		}

		[Token(Token = "0x600021A")]
		[Address(RVA = "0x1533CC8", Offset = "0x1533CC8", VA = "0x1533CC8", Slot = "5")]
		public void LogWarning(string text)
		{
		}

		[Token(Token = "0x600021B")]
		[Address(RVA = "0x1533D30", Offset = "0x1533D30", VA = "0x1533D30", Slot = "6")]
		public void LogError(string text)
		{
		}

		[Token(Token = "0x600021C")]
		[Address(RVA = "0x1533D98", Offset = "0x1533D98", VA = "0x1533D98")]
		public UnityLogger()
		{
		}
	}
}
namespace HellTap.MeshKit
{
	[Token(Token = "0x2000026")]
	[ExecuteInEditMode]
	[DisallowMultipleComponent]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xC84E90", Offset = "0xC84E90")]
	public class AutoLODAtRuntime : MonoBehaviour
	{
		[Token(Token = "0x40000AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xC858D4", Offset = "0xC858D4")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xC858D4", Offset = "0xC858D4")]
		public MeshKit.AutoLODSettings[] levels;

		[Token(Token = "0x40000AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xC85934", Offset = "0xC85934")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xC85934", Offset = "0xC85934")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xC85934", Offset = "0xC85934")]
		public float cullingDistancePercentage;

		[Token(Token = "0x40000B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xC859B0", Offset = "0xC859B0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xC859B0", Offset = "0xC859B0")]
		public bool preserveBorders;

		[Token(Token = "0x40000B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x25")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xC85A10", Offset = "0xC85A10")]
		public bool preserveSeams;

		[Token(Token = "0x40000B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x26")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xC85A48", Offset = "0xC85A48")]
		public bool preserveFoldovers;

		[Token(Token = "0x600021D")]
		[Address(RVA = "0x1626BD0", Offset = "0x1626BD0", VA = "0x1626BD0")]
		private void Start()
		{
		}

		[Token(Token = "0x600021E")]
		[Address(RVA = "0x1626D90", Offset = "0x1626D90", VA = "0x1626D90")]
		public AutoLODAtRuntime()
		{
		}
	}
	[Token(Token = "0x2000027")]
	[DisallowMultipleComponent]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xC84EEC", Offset = "0xC84EEC")]
	public class CombineChildrenAtRuntime : MonoBehaviour
	{
		[Token(Token = "0x40000B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xC85A80", Offset = "0xC85A80")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xC85A80", Offset = "0xC85A80")]
		public bool seperateSubMeshesFirst;

		[Token(Token = "0x40000B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xC85AE0", Offset = "0xC85AE0")]
		public bool stripUnusedVertices;

		[Token(Token = "0x40000B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xC85B18", Offset = "0xC85B18")]
		public bool onlySeperateEnabledRenderers;

		[Token(Token = "0x40000B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xC85B50", Offset = "0xC85B50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xC85B50", Offset = "0xC85B50")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xC85B50", Offset = "0xC85B50")]
		public int maximumVerticesPerObject;

		[Token(Token = "0x40000B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xC85BD0", Offset = "0xC85BD0")]
		public bool onlyCombineEnabledRenderers;

		[Token(Token = "0x40000B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xC85C08", Offset = "0xC85C08")]
		public bool optimizeCombinedMeshes;

		[Token(Token = "0x40000B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x22")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xC85C40", Offset = "0xC85C40")]
		public bool createMeshCollidersOnNewObjects;

		[Token(Token = "0x40000BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xC85C78", Offset = "0xC85C78")]
		public int createNewObjectsWithLayer;

		[Token(Token = "0x40000BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xC85CB0", Offset = "0xC85CB0")]
		public string createNewObjectsWithTag;

		[Token(Token = "0x40000BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xC85CE8", Offset = "0xC85CE8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xC85CE8", Offset = "0xC85CE8")]
		public bool destroyOriginalObjects;

		[Token(Token = "0x40000BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xC85D48", Offset = "0xC85D48")]
		public bool destroyObjectsWithDisabledRenderers;

		[Token(Token = "0x40000BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x32")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xC85D80", Offset = "0xC85D80")]
		public bool destroyEmptyObjects;

		[Token(Token = "0x600021F")]
		[Address(RVA = "0x1627140", Offset = "0x1627140", VA = "0x1627140")]
		private void Start()
		{
		}

		[Token(Token = "0x6000220")]
		[Address(RVA = "0x1627CB4", Offset = "0x1627CB4", VA = "0x1627CB4")]
		public CombineChildrenAtRuntime()
		{
		}
	}
	[Token(Token = "0x2000028")]
	[DisallowMultipleComponent]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xC84F38", Offset = "0xC84F38")]
	public class DecimateMeshAtRuntime : MonoBehaviour
	{
		[Token(Token = "0x40000BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xC85DB8", Offset = "0xC85DB8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xC85DB8", Offset = "0xC85DB8")]
		public bool applyToChildren;

		[Token(Token = "0x40000C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xC85E18", Offset = "0xC85E18")]
		public bool applyToMeshFilters;

		[Token(Token = "0x40000C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xC85E50", Offset = "0xC85E50")]
		public bool applyToSkinnedMeshRenderers;

		[Token(Token = "0x40000C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xC85E88", Offset = "0xC85E88")]
		public bool onlyApplyToEnabledRenderers;

		[Token(Token = "0x40000C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xC85EC0", Offset = "0xC85EC0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xC85EC0", Offset = "0xC85EC0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xC85EC0", Offset = "0xC85EC0")]
		public float decimatorQuality;

		[Token(Token = "0x40000C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xC85F38", Offset = "0xC85F38")]
		public bool recalculateNormals;

		[Token(Token = "0x40000C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xC85F70", Offset = "0xC85F70")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xC85F70", Offset = "0xC85F70")]
		public bool preserveBorders;

		[Token(Token = "0x40000C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x22")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xC85FD0", Offset = "0xC85FD0")]
		public bool preserveSeams;

		[Token(Token = "0x40000C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x23")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xC86008", Offset = "0xC86008")]
		public bool preserveFoldovers;

		[Token(Token = "0x6000221")]
		[Address(RVA = "0x1627D38", Offset = "0x1627D38", VA = "0x1627D38")]
		private void Start()
		{
		}

		[Token(Token = "0x6000222")]
		[Address(RVA = "0x1627F84", Offset = "0x1627F84", VA = "0x1627F84")]
		public DecimateMeshAtRuntime()
		{
		}
	}
	[Token(Token = "0x2000029")]
	[DisallowMultipleComponent]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xC84F84", Offset = "0xC84F84")]
	public class InvertMeshAtRuntime : MonoBehaviour
	{
		[Token(Token = "0x40000C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xC86040", Offset = "0xC86040")]
		public bool applyToChildren;

		[Token(Token = "0x40000C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xC86078", Offset = "0xC86078")]
		public bool applyToMeshFilters;

		[Token(Token = "0x40000CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xC860B0", Offset = "0xC860B0")]
		public bool applyToSkinnedMeshRenderers;

		[Token(Token = "0x40000CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xC860E8", Offset = "0xC860E8")]
		public bool onlyApplyToEnabledRenderers;

		[Token(Token = "0x6000223")]
		[Address(RVA = "0x1627F9C", Offset = "0x1627F9C", VA = "0x1627F9C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000224")]
		[Address(RVA = "0x162813C", Offset = "0x162813C", VA = "0x162813C")]
		public InvertMeshAtRuntime()
		{
		}
	}
	[Token(Token = "0x200002A")]
	[DisallowMultipleComponent]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xC84FD0", Offset = "0xC84FD0")]
	public class MakeDoubleSidedAtRuntime : MonoBehaviour
	{
		[Token(Token = "0x40000CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xC86120", Offset = "0xC86120")]
		public bool applyToChildren;

		[Token(Token = "0x40000CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xC86158", Offset = "0xC86158")]
		public bool applyToMeshFilters;

		[Token(Token = "0x40000CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xC86190", Offset = "0xC86190")]
		public bool applyToSkinnedMeshRenderers;

		[Token(Token = "0x40000CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xC861C8", Offset = "0xC861C8")]
		public bool onlyApplyToEnabledRenderers;

		[Token(Token = "0x6000225")]
		[Address(RVA = "0x1628154", Offset = "0x1628154", VA = "0x1628154")]
		private void Start()
		{
		}

		[Token(Token = "0x6000226")]
		[Address(RVA = "0x16282F4", Offset = "0x16282F4", VA = "0x16282F4")]
		public MakeDoubleSidedAtRuntime()
		{
		}
	}
	[Token(Token = "0x200002B")]
	[DisallowMultipleComponent]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xC8501C", Offset = "0xC8501C")]
	public class SeperateChildrenAtRuntime : MonoBehaviour
	{
		[Token(Token = "0x40000D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xC86200", Offset = "0xC86200")]
		public bool stripUnusedVertices;

		[Token(Token = "0x40000D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xC86238", Offset = "0xC86238")]
		public bool onlyApplyToEnabledRenderers;

		[Token(Token = "0x6000227")]
		[Address(RVA = "0x163392C", Offset = "0x163392C", VA = "0x163392C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000228")]
		[Address(RVA = "0x16339F0", Offset = "0x16339F0", VA = "0x16339F0")]
		public SeperateChildrenAtRuntime()
		{
		}
	}
	[Token(Token = "0x200002C")]
	public class MeshKit : MonoBehaviour
	{
		[Token(Token = "0x2000140")]
		public class BatchMeshes
		{
			[Token(Token = "0x4000687")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Material[] key;

			[Token(Token = "0x4000688")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Mesh originalMesh;

			[Token(Token = "0x4000689")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Mesh[] splitMeshes;

			[Token(Token = "0x400068A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public ArrayList gos;

			[Token(Token = "0x600090E")]
			[Address(RVA = "0x162CB58", Offset = "0x162CB58", VA = "0x162CB58")]
			public BatchMeshes()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000141")]
		public class AutoLODSettings
		{
			[Token(Token = "0x400068B")]
			private const string _UNTAGGED = "Untagged";

			[Token(Token = "0x400068C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xC8656C", Offset = "0xC8656C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xC8656C", Offset = "0xC8656C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xC8656C", Offset = "0xC8656C")]
			public float lodDistancePercentage;

			[Token(Token = "0x400068D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xC865EC", Offset = "0xC865EC")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xC865EC", Offset = "0xC865EC")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xC865EC", Offset = "0xC865EC")]
			public float quality;

			[Token(Token = "0x400068E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xC86668", Offset = "0xC86668")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xC86668", Offset = "0xC86668")]
			public SkinQuality skinQuality;

			[Token(Token = "0x400068F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xC866C8", Offset = "0xC866C8")]
			public bool receiveShadows;

			[Token(Token = "0x4000690")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xC86700", Offset = "0xC86700")]
			public ShadowCastingMode shadowCasting;

			[Token(Token = "0x4000691")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xC86738", Offset = "0xC86738")]
			public MotionVectorGenerationMode motionVectors;

			[Token(Token = "0x4000692")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xC86770", Offset = "0xC86770")]
			public bool skinnedMotionVectors;

			[Token(Token = "0x4000693")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xC867A8", Offset = "0xC867A8")]
			public LightProbeUsage lightProbeUsage;

			[Token(Token = "0x4000694")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xC867E0", Offset = "0xC867E0")]
			public ReflectionProbeUsage reflectionProbeUsage;

			[Token(Token = "0x4000695")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xC86818", Offset = "0xC86818")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xC86818", Offset = "0xC86818")]
			public string tag;

			[Token(Token = "0x4000696")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xC86878", Offset = "0xC86878")]
			public int layer;

			[Token(Token = "0x600090F")]
			[Address(RVA = "0x1626F94", Offset = "0x1626F94", VA = "0x1626F94")]
			public AutoLODSettings(float lodDistancePercentageValue, float qualityValue = 0.8f)
			{
			}

			[Token(Token = "0x6000910")]
			[Address(RVA = "0x1627054", Offset = "0x1627054", VA = "0x1627054")]
			public AutoLODSettings(float lodDistancePercentage, float quality, SkinQuality skinQuality, bool receiveShadows, ShadowCastingMode shadowCasting, MotionVectorGenerationMode motionVectors, bool skinnedMotionVectors, LightProbeUsage lightProbeUsage = LightProbeUsage.BlendProbes, ReflectionProbeUsage reflectionProbeUsage = ReflectionProbeUsage.BlendProbes, string tag = "Untagged", int layer = 0)
			{
			}

			[Token(Token = "0x6000911")]
			[Address(RVA = "0x162E080", Offset = "0x162E080", VA = "0x162E080")]
			public LODSettings ToLODSettings()
			{
				return default(LODSettings);
			}
		}

		[Token(Token = "0x2000142")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xC8539C", Offset = "0xC8539C")]
		private sealed class <InvertMeshAtRuntime>d__13 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000697")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000698")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000699")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public bool recursive;

			[Token(Token = "0x400069A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
			public bool optionUseMeshFilters;

			[Token(Token = "0x400069B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public GameObject go;

			[Token(Token = "0x400069C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public bool enabledRenderersOnly;

			[Token(Token = "0x400069D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
			public bool optionUseSkinnedMeshRenderers;

			[Token(Token = "0x400069E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private MeshFilter[] <>7__wrap1;

			[Token(Token = "0x400069F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private int <>7__wrap2;

			[Token(Token = "0x40006A0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private SkinnedMeshRenderer[] <>7__wrap3;

			[Token(Token = "0x17000061")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000915")]
				[Address(RVA = "0x16325C0", Offset = "0x16325C0", VA = "0x16325C0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000062")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000917")]
				[Address(RVA = "0x1632628", Offset = "0x1632628", VA = "0x1632628", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000912")]
			[Address(RVA = "0x162C4E0", Offset = "0x162C4E0", VA = "0x162C4E0")]
			[DebuggerHidden]
			public <InvertMeshAtRuntime>d__13(int <>1__state)
			{
			}

			[Token(Token = "0x6000913")]
			[Address(RVA = "0x1631D0C", Offset = "0x1631D0C", VA = "0x1631D0C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000914")]
			[Address(RVA = "0x1631D10", Offset = "0x1631D10", VA = "0x1631D10", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000916")]
			[Address(RVA = "0x16325C8", Offset = "0x16325C8", VA = "0x16325C8", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x2000143")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xC853AC", Offset = "0xC853AC")]
		private sealed class <MakeDoubleSidedAtRuntime>d__15 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40006A1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40006A2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40006A3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public bool recursive;

			[Token(Token = "0x40006A4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
			public bool optionUseMeshFilters;

			[Token(Token = "0x40006A5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public GameObject go;

			[Token(Token = "0x40006A6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public bool enabledRenderersOnly;

			[Token(Token = "0x40006A7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
			public bool optionUseSkinnedMeshRenderers;

			[Token(Token = "0x40006A8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private MeshFilter[] <>7__wrap1;

			[Token(Token = "0x40006A9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private int <>7__wrap2;

			[Token(Token = "0x40006AA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private SkinnedMeshRenderer[] <>7__wrap3;

			[Token(Token = "0x17000063")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600091B")]
				[Address(RVA = "0x1632EE4", Offset = "0x1632EE4", VA = "0x1632EE4", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000064")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600091D")]
				[Address(RVA = "0x1632F4C", Offset = "0x1632F4C", VA = "0x1632F4C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000918")]
			[Address(RVA = "0x162C5C8", Offset = "0x162C5C8", VA = "0x162C5C8")]
			[DebuggerHidden]
			public <MakeDoubleSidedAtRuntime>d__15(int <>1__state)
			{
			}

			[Token(Token = "0x6000919")]
			[Address(RVA = "0x1632630", Offset = "0x1632630", VA = "0x1632630", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600091A")]
			[Address(RVA = "0x1632634", Offset = "0x1632634", VA = "0x1632634", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600091C")]
			[Address(RVA = "0x1632EEC", Offset = "0x1632EEC", VA = "0x1632EEC", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x2000144")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xC853BC", Offset = "0xC853BC")]
		private sealed class <CombineChildrenAtRuntime>d__17 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40006AB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40006AC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40006AD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public int userMaxVertices;

			[Token(Token = "0x40006AE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public GameObject go;

			[Token(Token = "0x40006AF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public bool enabledRenderersOnly;

			[Token(Token = "0x40006B0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			public int createNewObjectsWithLayer;

			[Token(Token = "0x40006B1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public string createNewObjectsWithTag;

			[Token(Token = "0x40006B2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public bool createNewObjectsWithMeshColliders;

			[Token(Token = "0x40006B3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x41")]
			public bool deleteSourceObjects;

			[Token(Token = "0x40006B4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x42")]
			public bool deleteObjectsWithDisabledRenderers;

			[Token(Token = "0x40006B5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x43")]
			public bool deleteEmptyObjects;

			[Token(Token = "0x40006B6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			private bool <foundEmptyObjects>5__2;

			[Token(Token = "0x17000065")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000921")]
				[Address(RVA = "0x1631314", Offset = "0x1631314", VA = "0x1631314", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000066")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000923")]
				[Address(RVA = "0x163137C", Offset = "0x163137C", VA = "0x163137C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600091E")]
			[Address(RVA = "0x162C6F0", Offset = "0x162C6F0", VA = "0x162C6F0")]
			[DebuggerHidden]
			public <CombineChildrenAtRuntime>d__17(int <>1__state)
			{
			}

			[Token(Token = "0x600091F")]
			[Address(RVA = "0x162E840", Offset = "0x162E840", VA = "0x162E840", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000920")]
			[Address(RVA = "0x162E844", Offset = "0x162E844", VA = "0x162E844", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000922")]
			[Address(RVA = "0x163131C", Offset = "0x163131C", VA = "0x163131C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x2000145")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xC853CC", Offset = "0xC853CC")]
		private sealed class <DecimateMeshAtRuntime>d__26 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40006B7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40006B8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40006B9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public bool recursive;

			[Token(Token = "0x40006BA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
			public bool optionUseMeshFilters;

			[Token(Token = "0x40006BB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public GameObject go;

			[Token(Token = "0x40006BC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public bool optionUseSkinnedMeshRenderers;

			[Token(Token = "0x40006BD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
			public bool enabledRenderersOnly;

			[Token(Token = "0x40006BE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			public float quality;

			[Token(Token = "0x40006BF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public bool recalculateNormals;

			[Token(Token = "0x40006C0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x39")]
			public bool preserveBorders;

			[Token(Token = "0x40006C1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3A")]
			public bool preserveSeams;

			[Token(Token = "0x40006C2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3B")]
			public bool preserveFoldovers;

			[Token(Token = "0x40006C3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private MeshFilter[] <>7__wrap1;

			[Token(Token = "0x40006C4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private int <>7__wrap2;

			[Token(Token = "0x40006C5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			private SkinnedMeshRenderer[] <>7__wrap3;

			[Token(Token = "0x17000067")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000927")]
				[Address(RVA = "0x1631C9C", Offset = "0x1631C9C", VA = "0x1631C9C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000068")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000929")]
				[Address(RVA = "0x1631D04", Offset = "0x1631D04", VA = "0x1631D04", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000924")]
			[Address(RVA = "0x162DF14", Offset = "0x162DF14", VA = "0x162DF14")]
			[DebuggerHidden]
			public <DecimateMeshAtRuntime>d__26(int <>1__state)
			{
			}

			[Token(Token = "0x6000925")]
			[Address(RVA = "0x1631384", Offset = "0x1631384", VA = "0x1631384", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000926")]
			[Address(RVA = "0x1631388", Offset = "0x1631388", VA = "0x1631388", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000928")]
			[Address(RVA = "0x1631CA4", Offset = "0x1631CA4", VA = "0x1631CA4", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40000D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static bool debug;

		[Token(Token = "0x40000D3")]
		private const int maxVertices = 65534;

		[Token(Token = "0x40000D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static MeshKit _instance;

		[Token(Token = "0x17000048")]
		public static MeshKit com
		{
			[Token(Token = "0x6000229")]
			[Address(RVA = "0x162830C", Offset = "0x162830C", VA = "0x162830C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600022A")]
		[Address(RVA = "0x1628544", Offset = "0x1628544", VA = "0x1628544")]
		public static Mesh RebuildMesh(Mesh m, bool optionStripNormals, bool optionStripTangents, bool optionStripColors, bool optionStripUV2, bool optionStripUV3, bool optionStripUV4, bool optionStripUV5, bool optionStripUV6, bool optionStripUV7, bool optionStripUV8, bool optionRebuildNormals, bool optionRebuildTangents, float rebuildNormalsAngle = -1f)
		{
			return null;
		}

		[Token(Token = "0x600022B")]
		[Address(RVA = "0x1629A98", Offset = "0x1629A98", VA = "0x1629A98")]
		public static Mesh StripUnusedVertices(Mesh m, bool optimize)
		{
			return null;
		}

		[Token(Token = "0x600022C")]
		[Address(RVA = "0x1629B40", Offset = "0x1629B40", VA = "0x1629B40")]
		public static Mesh Strip(Mesh m, bool optimize, bool stripNormals, bool stripTangents, bool stripColors, bool stripUV, bool stripUV2, bool stripUV3, bool stripUV4, bool stripUV5, bool stripUV6, bool stripUV7, bool stripUV8, bool stripBoneWeights, bool stripBindPoses)
		{
			return null;
		}

		[Token(Token = "0x600022D")]
		[Address(RVA = "0x162AB18", Offset = "0x162AB18", VA = "0x162AB18")]
		public static Mesh[] SplitMesh(Mesh mesh, bool stripUnusedVertices)
		{
			return null;
		}

		[Token(Token = "0x600022E")]
		[Address(RVA = "0x1629460", Offset = "0x1629460", VA = "0x1629460")]
		public static Mesh CreateTangents(Mesh mesh)
		{
			return null;
		}

		[Token(Token = "0x600022F")]
		[Address(RVA = "0x162B168", Offset = "0x162B168", VA = "0x162B168")]
		public static Mesh InvertMesh(Mesh mesh)
		{
			return null;
		}

		[Token(Token = "0x6000230")]
		[Address(RVA = "0x162B344", Offset = "0x162B344", VA = "0x162B344")]
		public static Mesh MakeDoubleSidedMesh(Mesh mesh)
		{
			return null;
		}

		[Token(Token = "0x6000231")]
		[Address(RVA = "0x1628080", Offset = "0x1628080", VA = "0x1628080")]
		public static void InvertMesh(GameObject go, bool recursive, bool optionUseMeshFilters, bool optionUseSkinnedMeshRenderers, bool enabledRenderersOnly)
		{
		}

		[Token(Token = "0x6000232")]
		[Address(RVA = "0x162C424", Offset = "0x162C424", VA = "0x162C424")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xC868F0", Offset = "0xC868F0")]
		public IEnumerator InvertMeshAtRuntime(GameObject go, bool recursive, bool optionUseMeshFilters, bool optionUseSkinnedMeshRenderers, bool enabledRenderersOnly)
		{
			return null;
		}

		[Token(Token = "0x6000233")]
		[Address(RVA = "0x1628238", Offset = "0x1628238", VA = "0x1628238")]
		public static void MakeDoubleSided(GameObject go, bool recursive, bool optionUseMeshFilters, bool optionUseSkinnedMeshRenderers, bool enabledRenderersOnly)
		{
		}

		[Token(Token = "0x6000234")]
		[Address(RVA = "0x162C50C", Offset = "0x162C50C", VA = "0x162C50C")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xC86954", Offset = "0xC86954")]
		public IEnumerator MakeDoubleSidedAtRuntime(GameObject go, bool recursive, bool optionUseMeshFilters, bool optionUseSkinnedMeshRenderers, bool enabledRenderersOnly)
		{
			return null;
		}

		[Token(Token = "0x6000235")]
		[Address(RVA = "0x1627BB4", Offset = "0x1627BB4", VA = "0x1627BB4")]
		public static void CombineChildren(GameObject go, bool optimizeMeshes, int createNewObjectsWithLayer, string createNewObjectsWithTag, bool enabledRenderersOnly, bool createNewObjectsWithMeshColliders, bool deleteSourceObjects, bool deleteObjectsWithDisabledRenderers, bool deleteEmptyObjects, int userMaxVertices = 65534)
		{
		}

		[Token(Token = "0x6000236")]
		[Address(RVA = "0x162C5F4", Offset = "0x162C5F4", VA = "0x162C5F4")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xC869B8", Offset = "0xC869B8")]
		public IEnumerator CombineChildrenAtRuntime(GameObject go, bool optimizeMeshes, int createNewObjectsWithLayer, string createNewObjectsWithTag, bool enabledRenderersOnly, bool createNewObjectsWithMeshColliders, bool deleteSourceObjects, bool deleteObjectsWithDisabledRenderers, bool deleteEmptyObjects, int userMaxVertices = 65534)
		{
			return null;
		}

		[Token(Token = "0x6000237")]
		[Address(RVA = "0x162C71C", Offset = "0x162C71C", VA = "0x162C71C")]
		public static bool ListContains(ArrayList list, Material[] key, Mesh originalMesh, MeshFilter mf)
		{
			return default(bool);
		}

		[Token(Token = "0x6000238")]
		[Address(RVA = "0x16272A4", Offset = "0x16272A4", VA = "0x16272A4")]
		public static void SeparateMeshes(GameObject go, bool onlyApplyToEnabledRenderers, bool stripUnusedVertices)
		{
		}

		[Token(Token = "0x6000239")]
		[Address(RVA = "0x162CB60", Offset = "0x162CB60", VA = "0x162CB60")]
		public static void RebuildSeparatedObjects(BatchMeshes bm)
		{
		}

		[Token(Token = "0x600023A")]
		[Address(RVA = "0x162D22C", Offset = "0x162D22C", VA = "0x162D22C")]
		public static void Rebuild(GameObject go, bool recursive, bool optionUseMeshFilters, bool optionUseSkinnedMeshRenderers, bool optionStripNormals, bool optionStripTangents, bool optionStripColors, bool optionStripUV2, bool optionStripUV3, bool optionStripUV4, bool optionStripUV5, bool optionStripUV6, bool optionStripUV7, bool optionStripUV8, bool optionRebuildNormals, bool optionRebuildTangents, float rebuildNormalsAngle = -1f)
		{
		}

		[Token(Token = "0x600023B")]
		[Address(RVA = "0x162D7F8", Offset = "0x162D7F8", VA = "0x162D7F8")]
		public static Mesh DecimateMesh(SkinnedMeshRenderer smr, float quality, bool recalculateNormals, bool preserveBorders = false, bool preserveSeams = false, bool preserveFoldovers = false)
		{
			return null;
		}

		[Token(Token = "0x600023C")]
		[Address(RVA = "0x162DB00", Offset = "0x162DB00", VA = "0x162DB00")]
		public static Mesh DecimateMesh(MeshFilter mf, float quality, bool recalculateNormals, bool preserveBorders = false, bool preserveSeams = false, bool preserveFoldovers = false)
		{
			return null;
		}

		[Token(Token = "0x600023D")]
		[Address(RVA = "0x1627E78", Offset = "0x1627E78", VA = "0x1627E78")]
		public static void DecimateMesh(GameObject go, bool recursive, bool optionUseMeshFilters, bool optionUseSkinnedMeshRenderers, bool enabledRenderersOnly, float quality, bool recalculateNormals, bool preserveBorders = false, bool preserveSeams = false, bool preserveFoldovers = false)
		{
		}

		[Token(Token = "0x600023E")]
		[Address(RVA = "0x162DE08", Offset = "0x162DE08", VA = "0x162DE08")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xC86A1C", Offset = "0xC86A1C")]
		public IEnumerator DecimateMeshAtRuntime(GameObject go, bool recursive, bool optionUseMeshFilters, bool optionUseSkinnedMeshRenderers, bool enabledRenderersOnly, float quality, bool recalculateNormals, bool preserveBorders = false, bool preserveSeams = false, bool preserveFoldovers = false)
		{
			return null;
		}

		[Token(Token = "0x600023F")]
		[Address(RVA = "0x162DF40", Offset = "0x162DF40", VA = "0x162DF40")]
		public static LODSettings[] AutoLODSetttingsToLODSettings(AutoLODSettings[] autoLODSettings)
		{
			return null;
		}

		[Token(Token = "0x6000240")]
		[Address(RVA = "0x162E0DC", Offset = "0x162E0DC", VA = "0x162E0DC")]
		public static void AutoLOD(GameObject go, bool preserveBorders = false, bool preserveSeams = false, bool preserveFoldovers = false)
		{
		}

		[Token(Token = "0x6000241")]
		[Address(RVA = "0x1626CE4", Offset = "0x1626CE4", VA = "0x1626CE4")]
		public static void AutoLOD(GameObject go, AutoLODSettings[] levels, float cullingDistance = 1f, bool preserveBorders = false, bool preserveSeams = false, bool preserveFoldovers = false)
		{
		}

		[Token(Token = "0x6000242")]
		[Address(RVA = "0x162E344", Offset = "0x162E344", VA = "0x162E344")]
		public static void AutoLOD(GameObject go, LODSettings[] levels, float cullingDistance = 1f, bool preserveBorders = false, bool preserveSeams = false, bool preserveFoldovers = false)
		{
		}

		[Token(Token = "0x6000243")]
		[Address(RVA = "0x162E7E4", Offset = "0x162E7E4", VA = "0x162E7E4")]
		public MeshKit()
		{
		}
	}
	[Token(Token = "0x200002D")]
	public static class Arrays
	{
		[Token(Token = "0x6000245")]
		public static bool AddItem<T>(ref T[] _arr, T item)
		{
			return default(bool);
		}

		[Token(Token = "0x6000246")]
		public static void AddItemFastest<T>(ref T[] _arr, T item)
		{
		}

		[Token(Token = "0x6000247")]
		public static bool AddItemIfNotPresent<T>(ref T[] _arr, T item)
		{
			return default(bool);
		}

		[Token(Token = "0x6000248")]
		public static bool RemoveItem<T>(ref T[] _arr, ref T item, bool onlyRemoveFirstInstance = false)
		{
			return default(bool);
		}

		[Token(Token = "0x6000249")]
		public static bool RemoveFirstItem<T>(ref T[] _arr)
		{
			return default(bool);
		}

		[Token(Token = "0x600024A")]
		public static bool RemoveItemAtIndex<T>(ref T[] _arr, int index)
		{
			return default(bool);
		}

		[Token(Token = "0x600024B")]
		public static int ItemExistsAtIndex<T>(ref T[] _arr, ref T item)
		{
			return default(int);
		}

		[Token(Token = "0x600024C")]
		public static bool ItemExists<T>(T[] _arr, T item)
		{
			return default(bool);
		}

		[Token(Token = "0x600024D")]
		public static T[] Concat<T>(this T[] a, T[] b)
		{
			return null;
		}

		[Token(Token = "0x600024E")]
		public static T[] Combine<T>(T[] a, T[] b)
		{
			return null;
		}

		[Token(Token = "0x600024F")]
		public static bool Clear<T>(ref T[] arr)
		{
			return default(bool);
		}

		[Token(Token = "0x6000250")]
		public static bool Shift<T>(ref T[] _arr, int id, bool moveUp)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x200002E")]
	[DisallowMultipleComponent]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xC85078", Offset = "0xC85078")]
	public sealed class MeshKitAutoLOD : MonoBehaviour
	{
		[Token(Token = "0x40000D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[HideInInspector]
		public bool advancedMode;

		[Token(Token = "0x40000D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		[HideInInspector]
		public bool preserveBorders;

		[Token(Token = "0x40000D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
		[HideInInspector]
		public bool preserveSeams;

		[Token(Token = "0x40000D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B")]
		[HideInInspector]
		public bool preserveFoldovers;

		[Token(Token = "0x40000D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[HideInInspector]
		public LODSettings[] levels;

		[Token(Token = "0x40000DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[HideInInspector]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xC862C0", Offset = "0xC862C0")]
		public float cullingDistance;

		[Token(Token = "0x40000DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[HideInInspector]
		public bool generated;

		[Token(Token = "0x17000049")]
		public LODSettings[] Levels
		{
			[Token(Token = "0x6000251")]
			[Address(RVA = "0x1632F54", Offset = "0x1632F54", VA = "0x1632F54")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000252")]
			[Address(RVA = "0x1633178", Offset = "0x1633178", VA = "0x1633178")]
			set
			{
			}
		}

		[Token(Token = "0x1700004A")]
		public bool IsGenerated
		{
			[Token(Token = "0x6000253")]
			[Address(RVA = "0x1633180", Offset = "0x1633180", VA = "0x1633180")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000254")]
		[Address(RVA = "0x1633188", Offset = "0x1633188", VA = "0x1633188")]
		public void Reset()
		{
		}

		[Token(Token = "0x6000255")]
		[Address(RVA = "0x1633400", Offset = "0x1633400", VA = "0x1633400")]
		public void GenerateLODs([Optional] LODStatusReportCallback statusCallback)
		{
		}

		[Token(Token = "0x6000256")]
		[Address(RVA = "0x16333CC", Offset = "0x16333CC", VA = "0x16333CC")]
		public void ResetLODs()
		{
		}

		[Token(Token = "0x6000257")]
		[Address(RVA = "0x1633470", Offset = "0x1633470", VA = "0x1633470")]
		public MeshKitAutoLOD()
		{
		}
	}
	[Token(Token = "0x200002F")]
	public static class MeshKitNormals
	{
		[Token(Token = "0x2000146")]
		private struct VertexKey
		{
			[Token(Token = "0x40006C6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private readonly long _x;

			[Token(Token = "0x40006C7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private readonly long _y;

			[Token(Token = "0x40006C8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private readonly long _z;

			[Token(Token = "0x40006C9")]
			private const int Tolerance = 100000;

			[Token(Token = "0x600092A")]
			[Address(RVA = "0x1633480", Offset = "0x1633480", VA = "0x1633480")]
			public VertexKey(UnityEngine.Vector3 position)
			{
			}

			[Token(Token = "0x600092B")]
			[Address(RVA = "0x1633824", Offset = "0x1633824", VA = "0x1633824", Slot = "0")]
			public override bool Equals(object obj)
			{
				return default(bool);
			}

			[Token(Token = "0x600092C")]
			[Address(RVA = "0x16338DC", Offset = "0x16338DC", VA = "0x16338DC", Slot = "2")]
			public override int GetHashCode()
			{
				return default(int);
			}
		}

		[Token(Token = "0x2000147")]
		private sealed class VertexEntry
		{
			[Token(Token = "0x40006CA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public int[] TriangleIndex;

			[Token(Token = "0x40006CB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public int[] VertexIndex;

			[Token(Token = "0x40006CC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private int _reserved;

			[Token(Token = "0x40006CD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			private int _count;

			[Token(Token = "0x17000069")]
			public int Count
			{
				[Token(Token = "0x600092D")]
				[Address(RVA = "0x163381C", Offset = "0x163381C", VA = "0x163381C")]
				get
				{
					return default(int);
				}
			}

			[Token(Token = "0x600092E")]
			[Address(RVA = "0x1633724", Offset = "0x1633724", VA = "0x1633724")]
			public void Add(int vertIndex, int triIndex)
			{
			}

			[Token(Token = "0x600092F")]
			[Address(RVA = "0x163368C", Offset = "0x163368C", VA = "0x163368C")]
			public VertexEntry()
			{
			}
		}

		[Token(Token = "0x6000258")]
		[Address(RVA = "0x1628A24", Offset = "0x1628A24", VA = "0x1628A24")]
		public static void RecalculateNormalsBasedOnAngleThreshold(this Mesh mesh, float angle)
		{
		}
	}
}
namespace FMOD
{
	[Token(Token = "0x2000030")]
	public class VERSION
	{
		[Token(Token = "0x40000DC")]
		public const int number = 131078;

		[Token(Token = "0x40000DD")]
		public const string dll = "fmod";

		[Token(Token = "0x6000259")]
		[Address(RVA = "0xFC5230", Offset = "0xFC5230", VA = "0xFC5230")]
		public VERSION()
		{
		}
	}
	[Token(Token = "0x2000031")]
	public class CONSTANTS
	{
		[Token(Token = "0x40000DE")]
		public const int MAX_CHANNEL_WIDTH = 32;

		[Token(Token = "0x40000DF")]
		public const int MAX_LISTENERS = 8;

		[Token(Token = "0x40000E0")]
		public const int REVERB_MAXINSTANCES = 4;

		[Token(Token = "0x40000E1")]
		public const int MAX_SYSTEMS = 8;

		[Token(Token = "0x600025A")]
		[Address(RVA = "0x156D6BC", Offset = "0x156D6BC", VA = "0x156D6BC")]
		public CONSTANTS()
		{
		}
	}
	[Token(Token = "0x2000032")]
	public enum RESULT
	{
		[Token(Token = "0x40000E3")]
		OK,
		[Token(Token = "0x40000E4")]
		ERR_BADCOMMAND,
		[Token(Token = "0x40000E5")]
		ERR_CHANNEL_ALLOC,
		[Token(Token = "0x40000E6")]
		ERR_CHANNEL_STOLEN,
		[Token(Token = "0x40000E7")]
		ERR_DMA,
		[Token(Token = "0x40000E8")]
		ERR_DSP_CONNECTION,
		[Token(Token = "0x40000E9")]
		ERR_DSP_DONTPROCESS,
		[Token(Token = "0x40000EA")]
		ERR_DSP_FORMAT,
		[Token(Token = "0x40000EB")]
		ERR_DSP_INUSE,
		[Token(Token = "0x40000EC")]
		ERR_DSP_NOTFOUND,
		[Token(Token = "0x40000ED")]
		ERR_DSP_RESERVED,
		[Token(Token = "0x40000EE")]
		ERR_DSP_SILENCE,
		[Token(Token = "0x40000EF")]
		ERR_DSP_TYPE,
		[Token(Token = "0x40000F0")]
		ERR_FILE_BAD,
		[Token(Token = "0x40000F1")]
		ERR_FILE_COULDNOTSEEK,
		[Token(Token = "0x40000F2")]
		ERR_FILE_DISKEJECTED,
		[Token(Token = "0x40000F3")]
		ERR_FILE_EOF,
		[Token(Token = "0x40000F4")]
		ERR_FILE_ENDOFDATA,
		[Token(Token = "0x40000F5")]
		ERR_FILE_NOTFOUND,
		[Token(Token = "0x40000F6")]
		ERR_FORMAT,
		[Token(Token = "0x40000F7")]
		ERR_HEADER_MISMATCH,
		[Token(Token = "0x40000F8")]
		ERR_HTTP,
		[Token(Token = "0x40000F9")]
		ERR_HTTP_ACCESS,
		[Token(Token = "0x40000FA")]
		ERR_HTTP_PROXY_AUTH,
		[Token(Token = "0x40000FB")]
		ERR_HTTP_SERVER_ERROR,
		[Token(Token = "0x40000FC")]
		ERR_HTTP_TIMEOUT,
		[Token(Token = "0x40000FD")]
		ERR_INITIALIZATION,
		[Token(Token = "0x40000FE")]
		ERR_INITIALIZED,
		[Token(Token = "0x40000FF")]
		ERR_INTERNAL,
		[Token(Token = "0x4000100")]
		ERR_INVALID_FLOAT,
		[Token(Token = "0x4000101")]
		ERR_INVALID_HANDLE,
		[Token(Token = "0x4000102")]
		ERR_INVALID_PARAM,
		[Token(Token = "0x4000103")]
		ERR_INVALID_POSITION,
		[Token(Token = "0x4000104")]
		ERR_INVALID_SPEAKER,
		[Token(Token = "0x4000105")]
		ERR_INVALID_SYNCPOINT,
		[Token(Token = "0x4000106")]
		ERR_INVALID_THREAD,
		[Token(Token = "0x4000107")]
		ERR_INVALID_VECTOR,
		[Token(Token = "0x4000108")]
		ERR_MAXAUDIBLE,
		[Token(Token = "0x4000109")]
		ERR_MEMORY,
		[Token(Token = "0x400010A")]
		ERR_MEMORY_CANTPOINT,
		[Token(Token = "0x400010B")]
		ERR_NEEDS3D,
		[Token(Token = "0x400010C")]
		ERR_NEEDSHARDWARE,
		[Token(Token = "0x400010D")]
		ERR_NET_CONNECT,
		[Token(Token = "0x400010E")]
		ERR_NET_SOCKET_ERROR,
		[Token(Token = "0x400010F")]
		ERR_NET_URL,
		[Token(Token = "0x4000110")]
		ERR_NET_WOULD_BLOCK,
		[Token(Token = "0x4000111")]
		ERR_NOTREADY,
		[Token(Token = "0x4000112")]
		ERR_OUTPUT_ALLOCATED,
		[Token(Token = "0x4000113")]
		ERR_OUTPUT_CREATEBUFFER,
		[Token(Token = "0x4000114")]
		ERR_OUTPUT_DRIVERCALL,
		[Token(Token = "0x4000115")]
		ERR_OUTPUT_FORMAT,
		[Token(Token = "0x4000116")]
		ERR_OUTPUT_INIT,
		[Token(Token = "0x4000117")]
		ERR_OUTPUT_NODRIVERS,
		[Token(Token = "0x4000118")]
		ERR_PLUGIN,
		[Token(Token = "0x4000119")]
		ERR_PLUGIN_MISSING,
		[Token(Token = "0x400011A")]
		ERR_PLUGIN_RESOURCE,
		[Token(Token = "0x400011B")]
		ERR_PLUGIN_VERSION,
		[Token(Token = "0x400011C")]
		ERR_RECORD,
		[Token(Token = "0x400011D")]
		ERR_REVERB_CHANNELGROUP,
		[Token(Token = "0x400011E")]
		ERR_REVERB_INSTANCE,
		[Token(Token = "0x400011F")]
		ERR_SUBSOUNDS,
		[Token(Token = "0x4000120")]
		ERR_SUBSOUND_ALLOCATED,
		[Token(Token = "0x4000121")]
		ERR_SUBSOUND_CANTMOVE,
		[Token(Token = "0x4000122")]
		ERR_TAGNOTFOUND,
		[Token(Token = "0x4000123")]
		ERR_TOOMANYCHANNELS,
		[Token(Token = "0x4000124")]
		ERR_TRUNCATED,
		[Token(Token = "0x4000125")]
		ERR_UNIMPLEMENTED,
		[Token(Token = "0x4000126")]
		ERR_UNINITIALIZED,
		[Token(Token = "0x4000127")]
		ERR_UNSUPPORTED,
		[Token(Token = "0x4000128")]
		ERR_VERSION,
		[Token(Token = "0x4000129")]
		ERR_EVENT_ALREADY_LOADED,
		[Token(Token = "0x400012A")]
		ERR_EVENT_LIVEUPDATE_BUSY,
		[Token(Token = "0x400012B")]
		ERR_EVENT_LIVEUPDATE_MISMATCH,
		[Token(Token = "0x400012C")]
		ERR_EVENT_LIVEUPDATE_TIMEOUT,
		[Token(Token = "0x400012D")]
		ERR_EVENT_NOTFOUND,
		[Token(Token = "0x400012E")]
		ERR_STUDIO_UNINITIALIZED,
		[Token(Token = "0x400012F")]
		ERR_STUDIO_NOT_LOADED,
		[Token(Token = "0x4000130")]
		ERR_INVALID_STRING,
		[Token(Token = "0x4000131")]
		ERR_ALREADY_LOCKED,
		[Token(Token = "0x4000132")]
		ERR_NOT_LOCKED,
		[Token(Token = "0x4000133")]
		ERR_RECORD_DISCONNECTED,
		[Token(Token = "0x4000134")]
		ERR_TOOMANYSAMPLES
	}
	[Token(Token = "0x2000033")]
	public enum CHANNELCONTROL_TYPE
	{
		[Token(Token = "0x4000136")]
		CHANNEL,
		[Token(Token = "0x4000137")]
		CHANNELGROUP,
		[Token(Token = "0x4000138")]
		MAX
	}
	[Token(Token = "0x2000034")]
	public struct VECTOR
	{
		[Token(Token = "0x4000139")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float x;

		[Token(Token = "0x400013A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public float y;

		[Token(Token = "0x400013B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public float z;
	}
	[Token(Token = "0x2000035")]
	public struct ATTRIBUTES_3D
	{
		[Token(Token = "0x400013C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public VECTOR position;

		[Token(Token = "0x400013D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public VECTOR velocity;

		[Token(Token = "0x400013E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public VECTOR forward;

		[Token(Token = "0x400013F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public VECTOR up;
	}
	[Token(Token = "0x2000036")]
	public struct ASYNCREADINFO
	{
		[Token(Token = "0x4000140")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public IntPtr handle;

		[Token(Token = "0x4000141")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public uint offset;

		[Token(Token = "0x4000142")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public uint sizebytes;

		[Token(Token = "0x4000143")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int priority;

		[Token(Token = "0x4000144")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public IntPtr userdata;

		[Token(Token = "0x4000145")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public IntPtr buffer;

		[Token(Token = "0x4000146")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public uint bytesread;

		[Token(Token = "0x4000147")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public FILE_ASYNCDONE_FUNC done;
	}
	[Token(Token = "0x2000037")]
	public enum OUTPUTTYPE
	{
		[Token(Token = "0x4000149")]
		AUTODETECT,
		[Token(Token = "0x400014A")]
		UNKNOWN,
		[Token(Token = "0x400014B")]
		NOSOUND,
		[Token(Token = "0x400014C")]
		WAVWRITER,
		[Token(Token = "0x400014D")]
		NOSOUND_NRT,
		[Token(Token = "0x400014E")]
		WAVWRITER_NRT,
		[Token(Token = "0x400014F")]
		WASAPI,
		[Token(Token = "0x4000150")]
		ASIO,
		[Token(Token = "0x4000151")]
		PULSEAUDIO,
		[Token(Token = "0x4000152")]
		ALSA,
		[Token(Token = "0x4000153")]
		COREAUDIO,
		[Token(Token = "0x4000154")]
		AUDIOTRACK,
		[Token(Token = "0x4000155")]
		OPENSL,
		[Token(Token = "0x4000156")]
		AUDIOOUT,
		[Token(Token = "0x4000157")]
		AUDIO3D,
		[Token(Token = "0x4000158")]
		WEBAUDIO,
		[Token(Token = "0x4000159")]
		NNAUDIO,
		[Token(Token = "0x400015A")]
		WINSONIC,
		[Token(Token = "0x400015B")]
		AAUDIO,
		[Token(Token = "0x400015C")]
		MAX
	}
	[Token(Token = "0x2000038")]
	public enum DEBUG_MODE
	{
		[Token(Token = "0x400015E")]
		TTY,
		[Token(Token = "0x400015F")]
		FILE,
		[Token(Token = "0x4000160")]
		CALLBACK
	}
	[Token(Token = "0x2000039")]
	[Flags]
	public enum DEBUG_FLAGS : uint
	{
		[Token(Token = "0x4000162")]
		NONE = 0u,
		[Token(Token = "0x4000163")]
		ERROR = 1u,
		[Token(Token = "0x4000164")]
		WARNING = 2u,
		[Token(Token = "0x4000165")]
		LOG = 4u,
		[Token(Token = "0x4000166")]
		TYPE_MEMORY = 0x100u,
		[Token(Token = "0x4000167")]
		TYPE_FILE = 0x200u,
		[Token(Token = "0x4000168")]
		TYPE_CODEC = 0x400u,
		[Token(Token = "0x4000169")]
		TYPE_TRACE = 0x800u,
		[Token(Token = "0x400016A")]
		DISPLAY_TIMESTAMPS = 0x10000u,
		[Token(Token = "0x400016B")]
		DISPLAY_LINENUMBERS = 0x20000u,
		[Token(Token = "0x400016C")]
		DISPLAY_THREAD = 0x40000u
	}
	[Token(Token = "0x200003A")]
	[Flags]
	public enum MEMORY_TYPE : uint
	{
		[Token(Token = "0x400016E")]
		NORMAL = 0u,
		[Token(Token = "0x400016F")]
		STREAM_FILE = 1u,
		[Token(Token = "0x4000170")]
		STREAM_DECODE = 2u,
		[Token(Token = "0x4000171")]
		SAMPLEDATA = 4u,
		[Token(Token = "0x4000172")]
		DSP_BUFFER = 8u,
		[Token(Token = "0x4000173")]
		PLUGIN = 0x10u,
		[Token(Token = "0x4000174")]
		PERSISTENT = 0x200000u,
		[Token(Token = "0x4000175")]
		ALL = uint.MaxValue
	}
	[Token(Token = "0x200003B")]
	public enum SPEAKERMODE
	{
		[Token(Token = "0x4000177")]
		DEFAULT,
		[Token(Token = "0x4000178")]
		RAW,
		[Token(Token = "0x4000179")]
		MONO,
		[Token(Token = "0x400017A")]
		STEREO,
		[Token(Token = "0x400017B")]
		QUAD,
		[Token(Token = "0x400017C")]
		SURROUND,
		[Token(Token = "0x400017D")]
		_5POINT1,
		[Token(Token = "0x400017E")]
		_7POINT1,
		[Token(Token = "0x400017F")]
		_7POINT1POINT4,
		[Token(Token = "0x4000180")]
		MAX
	}
	[Token(Token = "0x200003C")]
	public enum SPEAKER
	{
		[Token(Token = "0x4000182")]
		NONE = -1,
		[Token(Token = "0x4000183")]
		FRONT_LEFT,
		[Token(Token = "0x4000184")]
		FRONT_RIGHT,
		[Token(Token = "0x4000185")]
		FRONT_CENTER,
		[Token(Token = "0x4000186")]
		LOW_FREQUENCY,
		[Token(Token = "0x4000187")]
		SURROUND_LEFT,
		[Token(Token = "0x4000188")]
		SURROUND_RIGHT,
		[Token(Token = "0x4000189")]
		BACK_LEFT,
		[Token(Token = "0x400018A")]
		BACK_RIGHT,
		[Token(Token = "0x400018B")]
		TOP_FRONT_LEFT,
		[Token(Token = "0x400018C")]
		TOP_FRONT_RIGHT,
		[Token(Token = "0x400018D")]
		TOP_BACK_LEFT,
		[Token(Token = "0x400018E")]
		TOP_BACK_RIGHT,
		[Token(Token = "0x400018F")]
		MAX
	}
	[Token(Token = "0x200003D")]
	[Flags]
	public enum CHANNELMASK : uint
	{
		[Token(Token = "0x4000191")]
		FRONT_LEFT = 1u,
		[Token(Token = "0x4000192")]
		FRONT_RIGHT = 2u,
		[Token(Token = "0x4000193")]
		FRONT_CENTER = 4u,
		[Token(Token = "0x4000194")]
		LOW_FREQUENCY = 8u,
		[Token(Token = "0x4000195")]
		SURROUND_LEFT = 0x10u,
		[Token(Token = "0x4000196")]
		SURROUND_RIGHT = 0x20u,
		[Token(Token = "0x4000197")]
		BACK_LEFT = 0x40u,
		[Token(Token = "0x4000198")]
		BACK_RIGHT = 0x80u,
		[Token(Token = "0x4000199")]
		BACK_CENTER = 0x100u,
		[Token(Token = "0x400019A")]
		MONO = 1u,
		[Token(Token = "0x400019B")]
		STEREO = 3u,
		[Token(Token = "0x400019C")]
		LRC = 7u,
		[Token(Token = "0x400019D")]
		QUAD = 0x33u,
		[Token(Token = "0x400019E")]
		SURROUND = 0x37u,
		[Token(Token = "0x400019F")]
		_5POINT1 = 0x3Fu,
		[Token(Token = "0x40001A0")]
		_5POINT1_REARS = 0xCFu,
		[Token(Token = "0x40001A1")]
		_7POINT0 = 0xF7u,
		[Token(Token = "0x40001A2")]
		_7POINT1 = 0xFFu
	}
	[Token(Token = "0x200003E")]
	public enum CHANNELORDER
	{
		[Token(Token = "0x40001A4")]
		DEFAULT,
		[Token(Token = "0x40001A5")]
		WAVEFORMAT,
		[Token(Token = "0x40001A6")]
		PROTOOLS,
		[Token(Token = "0x40001A7")]
		ALLMONO,
		[Token(Token = "0x40001A8")]
		ALLSTEREO,
		[Token(Token = "0x40001A9")]
		ALSA,
		[Token(Token = "0x40001AA")]
		MAX
	}
	[Token(Token = "0x200003F")]
	public enum PLUGINTYPE
	{
		[Token(Token = "0x40001AC")]
		OUTPUT,
		[Token(Token = "0x40001AD")]
		CODEC,
		[Token(Token = "0x40001AE")]
		DSP,
		[Token(Token = "0x40001AF")]
		MAX
	}
	[Token(Token = "0x2000040")]
	public struct PLUGINLIST
	{
		[Token(Token = "0x40001B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private PLUGINTYPE type;

		[Token(Token = "0x40001B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private IntPtr description;
	}
	[Token(Token = "0x2000041")]
	[Flags]
	public enum INITFLAGS : uint
	{
		[Token(Token = "0x40001B3")]
		NORMAL = 0u,
		[Token(Token = "0x40001B4")]
		STREAM_FROM_UPDATE = 1u,
		[Token(Token = "0x40001B5")]
		MIX_FROM_UPDATE = 2u,
		[Token(Token = "0x40001B6")]
		_3D_RIGHTHANDED = 4u,
		[Token(Token = "0x40001B7")]
		CHANNEL_LOWPASS = 0x100u,
		[Token(Token = "0x40001B8")]
		CHANNEL_DISTANCEFILTER = 0x200u,
		[Token(Token = "0x40001B9")]
		PROFILE_ENABLE = 0x10000u,
		[Token(Token = "0x40001BA")]
		VOL0_BECOMES_VIRTUAL = 0x20000u,
		[Token(Token = "0x40001BB")]
		GEOMETRY_USECLOSEST = 0x40000u,
		[Token(Token = "0x40001BC")]
		PREFER_DOLBY_DOWNMIX = 0x80000u,
		[Token(Token = "0x40001BD")]
		THREAD_UNSAFE = 0x100000u,
		[Token(Token = "0x40001BE")]
		PROFILE_METER_ALL = 0x200000u
	}
	[Token(Token = "0x2000042")]
	public enum SOUND_TYPE
	{
		[Token(Token = "0x40001C0")]
		UNKNOWN,
		[Token(Token = "0x40001C1")]
		AIFF,
		[Token(Token = "0x40001C2")]
		ASF,
		[Token(Token = "0x40001C3")]
		DLS,
		[Token(Token = "0x40001C4")]
		FLAC,
		[Token(Token = "0x40001C5")]
		FSB,
		[Token(Token = "0x40001C6")]
		IT,
		[Token(Token = "0x40001C7")]
		MIDI,
		[Token(Token = "0x40001C8")]
		MOD,
		[Token(Token = "0x40001C9")]
		MPEG,
		[Token(Token = "0x40001CA")]
		OGGVORBIS,
		[Token(Token = "0x40001CB")]
		PLAYLIST,
		[Token(Token = "0x40001CC")]
		RAW,
		[Token(Token = "0x40001CD")]
		S3M,
		[Token(Token = "0x40001CE")]
		USER,
		[Token(Token = "0x40001CF")]
		WAV,
		[Token(Token = "0x40001D0")]
		XM,
		[Token(Token = "0x40001D1")]
		XMA,
		[Token(Token = "0x40001D2")]
		AUDIOQUEUE,
		[Token(Token = "0x40001D3")]
		AT9,
		[Token(Token = "0x40001D4")]
		VORBIS,
		[Token(Token = "0x40001D5")]
		MEDIA_FOUNDATION,
		[Token(Token = "0x40001D6")]
		MEDIACODEC,
		[Token(Token = "0x40001D7")]
		FADPCM,
		[Token(Token = "0x40001D8")]
		OPUS,
		[Token(Token = "0x40001D9")]
		MAX
	}
	[Token(Token = "0x2000043")]
	public enum SOUND_FORMAT
	{
		[Token(Token = "0x40001DB")]
		NONE,
		[Token(Token = "0x40001DC")]
		PCM8,
		[Token(Token = "0x40001DD")]
		PCM16,
		[Token(Token = "0x40001DE")]
		PCM24,
		[Token(Token = "0x40001DF")]
		PCM32,
		[Token(Token = "0x40001E0")]
		PCMFLOAT,
		[Token(Token = "0x40001E1")]
		BITSTREAM,
		[Token(Token = "0x40001E2")]
		MAX
	}
	[Token(Token = "0x2000044")]
	[Flags]
	public enum MODE : uint
	{
		[Token(Token = "0x40001E4")]
		DEFAULT = 0u,
		[Token(Token = "0x40001E5")]
		LOOP_OFF = 1u,
		[Token(Token = "0x40001E6")]
		LOOP_NORMAL = 2u,
		[Token(Token = "0x40001E7")]
		LOOP_BIDI = 4u,
		[Token(Token = "0x40001E8")]
		_2D = 8u,
		[Token(Token = "0x40001E9")]
		_3D = 0x10u,
		[Token(Token = "0x40001EA")]
		CREATESTREAM = 0x80u,
		[Token(Token = "0x40001EB")]
		CREATESAMPLE = 0x100u,
		[Token(Token = "0x40001EC")]
		CREATECOMPRESSEDSAMPLE = 0x200u,
		[Token(Token = "0x40001ED")]
		OPENUSER = 0x400u,
		[Token(Token = "0x40001EE")]
		OPENMEMORY = 0x800u,
		[Token(Token = "0x40001EF")]
		OPENMEMORY_POINT = 0x10000000u,
		[Token(Token = "0x40001F0")]
		OPENRAW = 0x1000u,
		[Token(Token = "0x40001F1")]
		OPENONLY = 0x2000u,
		[Token(Token = "0x40001F2")]
		ACCURATETIME = 0x4000u,
		[Token(Token = "0x40001F3")]
		MPEGSEARCH = 0x8000u,
		[Token(Token = "0x40001F4")]
		NONBLOCKING = 0x10000u,
		[Token(Token = "0x40001F5")]
		UNIQUE = 0x20000u,
		[Token(Token = "0x40001F6")]
		_3D_HEADRELATIVE = 0x40000u,
		[Token(Token = "0x40001F7")]
		_3D_WORLDRELATIVE = 0x80000u,
		[Token(Token = "0x40001F8")]
		_3D_INVERSEROLLOFF = 0x100000u,
		[Token(Token = "0x40001F9")]
		_3D_LINEARROLLOFF = 0x200000u,
		[Token(Token = "0x40001FA")]
		_3D_LINEARSQUAREROLLOFF = 0x400000u,
		[Token(Token = "0x40001FB")]
		_3D_INVERSETAPEREDROLLOFF = 0x800000u,
		[Token(Token = "0x40001FC")]
		_3D_CUSTOMROLLOFF = 0x4000000u,
		[Token(Token = "0x40001FD")]
		_3D_IGNOREGEOMETRY = 0x40000000u,
		[Token(Token = "0x40001FE")]
		IGNORETAGS = 0x2000000u,
		[Token(Token = "0x40001FF")]
		LOWMEM = 0x8000000u,
		[Token(Token = "0x4000200")]
		VIRTUAL_PLAYFROMSTART = 0x80000000u
	}
	[Token(Token = "0x2000045")]
	public enum OPENSTATE
	{
		[Token(Token = "0x4000202")]
		READY,
		[Token(Token = "0x4000203")]
		LOADING,
		[Token(Token = "0x4000204")]
		ERROR,
		[Token(Token = "0x4000205")]
		CONNECTING,
		[Token(Token = "0x4000206")]
		BUFFERING,
		[Token(Token = "0x4000207")]
		SEEKING,
		[Token(Token = "0x4000208")]
		PLAYING,
		[Token(Token = "0x4000209")]
		SETPOSITION,
		[Token(Token = "0x400020A")]
		MAX
	}
	[Token(Token = "0x2000046")]
	public enum SOUNDGROUP_BEHAVIOR
	{
		[Token(Token = "0x400020C")]
		BEHAVIOR_FAIL,
		[Token(Token = "0x400020D")]
		BEHAVIOR_MUTE,
		[Token(Token = "0x400020E")]
		BEHAVIOR_STEALLOWEST,
		[Token(Token = "0x400020F")]
		MAX
	}
	[Token(Token = "0x2000047")]
	public enum CHANNELCONTROL_CALLBACK_TYPE
	{
		[Token(Token = "0x4000211")]
		END,
		[Token(Token = "0x4000212")]
		VIRTUALVOICE,
		[Token(Token = "0x4000213")]
		SYNCPOINT,
		[Token(Token = "0x4000214")]
		OCCLUSION,
		[Token(Token = "0x4000215")]
		MAX
	}
	[Token(Token = "0x2000048")]
	public struct CHANNELCONTROL_DSP_INDEX
	{
		[Token(Token = "0x4000216")]
		public const int HEAD = -1;

		[Token(Token = "0x4000217")]
		public const int FADER = -2;

		[Token(Token = "0x4000218")]
		public const int TAIL = -3;
	}
	[Token(Token = "0x2000049")]
	public enum ERRORCALLBACK_INSTANCETYPE
	{
		[Token(Token = "0x400021A")]
		NONE,
		[Token(Token = "0x400021B")]
		SYSTEM,
		[Token(Token = "0x400021C")]
		CHANNEL,
		[Token(Token = "0x400021D")]
		CHANNELGROUP,
		[Token(Token = "0x400021E")]
		CHANNELCONTROL,
		[Token(Token = "0x400021F")]
		SOUND,
		[Token(Token = "0x4000220")]
		SOUNDGROUP,
		[Token(Token = "0x4000221")]
		DSP,
		[Token(Token = "0x4000222")]
		DSPCONNECTION,
		[Token(Token = "0x4000223")]
		GEOMETRY,
		[Token(Token = "0x4000224")]
		REVERB3D,
		[Token(Token = "0x4000225")]
		STUDIO_SYSTEM,
		[Token(Token = "0x4000226")]
		STUDIO_EVENTDESCRIPTION,
		[Token(Token = "0x4000227")]
		STUDIO_EVENTINSTANCE,
		[Token(Token = "0x4000228")]
		STUDIO_PARAMETERINSTANCE,
		[Token(Token = "0x4000229")]
		STUDIO_BUS,
		[Token(Token = "0x400022A")]
		STUDIO_VCA,
		[Token(Token = "0x400022B")]
		STUDIO_BANK,
		[Token(Token = "0x400022C")]
		STUDIO_COMMANDREPLAY
	}
	[Token(Token = "0x200004A")]
	public struct ERRORCALLBACK_INFO
	{
		[Token(Token = "0x400022D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public RESULT result;

		[Token(Token = "0x400022E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public ERRORCALLBACK_INSTANCETYPE instancetype;

		[Token(Token = "0x400022F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public IntPtr instance;

		[Token(Token = "0x4000230")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public StringWrapper functionname;

		[Token(Token = "0x4000231")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public StringWrapper functionparams;
	}
	[Token(Token = "0x200004B")]
	[Flags]
	public enum SYSTEM_CALLBACK_TYPE : uint
	{
		[Token(Token = "0x4000233")]
		DEVICELISTCHANGED = 1u,
		[Token(Token = "0x4000234")]
		DEVICELOST = 2u,
		[Token(Token = "0x4000235")]
		MEMORYALLOCATIONFAILED = 4u,
		[Token(Token = "0x4000236")]
		THREADCREATED = 8u,
		[Token(Token = "0x4000237")]
		BADDSPCONNECTION = 0x10u,
		[Token(Token = "0x4000238")]
		PREMIX = 0x20u,
		[Token(Token = "0x4000239")]
		POSTMIX = 0x40u,
		[Token(Token = "0x400023A")]
		ERROR = 0x80u,
		[Token(Token = "0x400023B")]
		MIDMIX = 0x100u,
		[Token(Token = "0x400023C")]
		THREADDESTROYED = 0x200u,
		[Token(Token = "0x400023D")]
		PREUPDATE = 0x400u,
		[Token(Token = "0x400023E")]
		POSTUPDATE = 0x800u,
		[Token(Token = "0x400023F")]
		RECORDLISTCHANGED = 0x1000u,
		[Token(Token = "0x4000240")]
		ALL = uint.MaxValue
	}
	[Token(Token = "0x200004C")]
	public delegate RESULT DEBUG_CALLBACK(DEBUG_FLAGS flags, StringWrapper file, int line, StringWrapper func, StringWrapper message);
	[Token(Token = "0x200004D")]
	public delegate RESULT SYSTEM_CALLBACK(IntPtr system, SYSTEM_CALLBACK_TYPE type, IntPtr commanddata1, IntPtr commanddata2, IntPtr userdata);
	[Token(Token = "0x200004E")]
	public delegate RESULT CHANNELCONTROL_CALLBACK(IntPtr channelcontrol, CHANNELCONTROL_TYPE controltype, CHANNELCONTROL_CALLBACK_TYPE callbacktype, IntPtr commanddata1, IntPtr commanddata2);
	[Token(Token = "0x200004F")]
	public delegate RESULT SOUND_NONBLOCK_CALLBACK(IntPtr sound, RESULT result);
	[Token(Token = "0x2000050")]
	public delegate RESULT SOUND_PCMREAD_CALLBACK(IntPtr sound, IntPtr data, uint datalen);
	[Token(Token = "0x2000051")]
	public delegate RESULT SOUND_PCMSETPOS_CALLBACK(IntPtr sound, int subsound, uint position, TIMEUNIT postype);
	[Token(Token = "0x2000052")]
	public delegate RESULT FILE_OPEN_CALLBACK(StringWrapper name, ref uint filesize, ref IntPtr handle, IntPtr userdata);
	[Token(Token = "0x2000053")]
	public delegate RESULT FILE_CLOSE_CALLBACK(IntPtr handle, IntPtr userdata);
	[Token(Token = "0x2000054")]
	public delegate RESULT FILE_READ_CALLBACK(IntPtr handle, IntPtr buffer, uint sizebytes, ref uint bytesread, IntPtr userdata);
	[Token(Token = "0x2000055")]
	public delegate RESULT FILE_SEEK_CALLBACK(IntPtr handle, uint pos, IntPtr userdata);
	[Token(Token = "0x2000056")]
	public delegate RESULT FILE_ASYNCREAD_CALLBACK(IntPtr info, IntPtr userdata);
	[Token(Token = "0x2000057")]
	public delegate RESULT FILE_ASYNCCANCEL_CALLBACK(IntPtr info, IntPtr userdata);
	[Token(Token = "0x2000058")]
	public delegate RESULT FILE_ASYNCDONE_FUNC(IntPtr info, RESULT result);
	[Token(Token = "0x2000059")]
	public delegate IntPtr MEMORY_ALLOC_CALLBACK(uint size, MEMORY_TYPE type, StringWrapper sourcestr);
	[Token(Token = "0x200005A")]
	public delegate IntPtr MEMORY_REALLOC_CALLBACK(IntPtr ptr, uint size, MEMORY_TYPE type, StringWrapper sourcestr);
	[Token(Token = "0x200005B")]
	public delegate void MEMORY_FREE_CALLBACK(IntPtr ptr, MEMORY_TYPE type, StringWrapper sourcestr);
	[Token(Token = "0x200005C")]
	public delegate float CB_3D_ROLLOFF_CALLBACK(IntPtr channelcontrol, float distance);
	[Token(Token = "0x200005D")]
	public enum DSP_RESAMPLER
	{
		[Token(Token = "0x4000242")]
		DEFAULT,
		[Token(Token = "0x4000243")]
		NOINTERP,
		[Token(Token = "0x4000244")]
		LINEAR,
		[Token(Token = "0x4000245")]
		CUBIC,
		[Token(Token = "0x4000246")]
		SPLINE,
		[Token(Token = "0x4000247")]
		MAX
	}
	[Token(Token = "0x200005E")]
	public enum DSPCONNECTION_TYPE
	{
		[Token(Token = "0x4000249")]
		STANDARD,
		[Token(Token = "0x400024A")]
		SIDECHAIN,
		[Token(Token = "0x400024B")]
		SEND,
		[Token(Token = "0x400024C")]
		SEND_SIDECHAIN,
		[Token(Token = "0x400024D")]
		MAX
	}
	[Token(Token = "0x200005F")]
	public enum TAGTYPE
	{
		[Token(Token = "0x400024F")]
		UNKNOWN,
		[Token(Token = "0x4000250")]
		ID3V1,
		[Token(Token = "0x4000251")]
		ID3V2,
		[Token(Token = "0x4000252")]
		VORBISCOMMENT,
		[Token(Token = "0x4000253")]
		SHOUTCAST,
		[Token(Token = "0x4000254")]
		ICECAST,
		[Token(Token = "0x4000255")]
		ASF,
		[Token(Token = "0x4000256")]
		MIDI,
		[Token(Token = "0x4000257")]
		PLAYLIST,
		[Token(Token = "0x4000258")]
		FMOD,
		[Token(Token = "0x4000259")]
		USER,
		[Token(Token = "0x400025A")]
		MAX
	}
	[Token(Token = "0x2000060")]
	public enum TAGDATATYPE
	{
		[Token(Token = "0x400025C")]
		BINARY,
		[Token(Token = "0x400025D")]
		INT,
		[Token(Token = "0x400025E")]
		FLOAT,
		[Token(Token = "0x400025F")]
		STRING,
		[Token(Token = "0x4000260")]
		STRING_UTF16,
		[Token(Token = "0x4000261")]
		STRING_UTF16BE,
		[Token(Token = "0x4000262")]
		STRING_UTF8,
		[Token(Token = "0x4000263")]
		MAX
	}
	[Token(Token = "0x2000061")]
	public struct TAG
	{
		[Token(Token = "0x4000264")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public TAGTYPE type;

		[Token(Token = "0x4000265")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public TAGDATATYPE datatype;

		[Token(Token = "0x4000266")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public StringWrapper name;

		[Token(Token = "0x4000267")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public IntPtr data;

		[Token(Token = "0x4000268")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public uint datalen;

		[Token(Token = "0x4000269")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public bool updated;
	}
	[Token(Token = "0x2000062")]
	[Flags]
	public enum TIMEUNIT : uint
	{
		[Token(Token = "0x400026B")]
		MS = 1u,
		[Token(Token = "0x400026C")]
		PCM = 2u,
		[Token(Token = "0x400026D")]
		PCMBYTES = 4u,
		[Token(Token = "0x400026E")]
		RAWBYTES = 8u,
		[Token(Token = "0x400026F")]
		PCMFRACTION = 0x10u,
		[Token(Token = "0x4000270")]
		MODORDER = 0x100u,
		[Token(Token = "0x4000271")]
		MODROW = 0x200u,
		[Token(Token = "0x4000272")]
		MODPATTERN = 0x400u
	}
	[Token(Token = "0x2000063")]
	public struct PORT_INDEX
	{
		[Token(Token = "0x4000273")]
		public const ulong NONE = ulong.MaxValue;
	}
	[Token(Token = "0x2000064")]
	public struct CREATESOUNDEXINFO
	{
		[Token(Token = "0x4000274")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int cbsize;

		[Token(Token = "0x4000275")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public uint length;

		[Token(Token = "0x4000276")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public uint fileoffset;

		[Token(Token = "0x4000277")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public int numchannels;

		[Token(Token = "0x4000278")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int defaultfrequency;

		[Token(Token = "0x4000279")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public SOUND_FORMAT format;

		[Token(Token = "0x400027A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public uint decodebuffersize;

		[Token(Token = "0x400027B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public int initialsubsound;

		[Token(Token = "0x400027C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public int numsubsounds;

		[Token(Token = "0x400027D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public IntPtr inclusionlist;

		[Token(Token = "0x400027E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public int inclusionlistnum;

		[Token(Token = "0x400027F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public SOUND_PCMREAD_CALLBACK pcmreadcallback;

		[Token(Token = "0x4000280")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public SOUND_PCMSETPOS_CALLBACK pcmsetposcallback;

		[Token(Token = "0x4000281")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public SOUND_NONBLOCK_CALLBACK nonblockcallback;

		[Token(Token = "0x4000282")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public IntPtr dlsname;

		[Token(Token = "0x4000283")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public IntPtr encryptionkey;

		[Token(Token = "0x4000284")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public int maxpolyphony;

		[Token(Token = "0x4000285")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public IntPtr userdata;

		[Token(Token = "0x4000286")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public SOUND_TYPE suggestedsoundtype;

		[Token(Token = "0x4000287")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public FILE_OPEN_CALLBACK fileuseropen;

		[Token(Token = "0x4000288")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public FILE_CLOSE_CALLBACK fileuserclose;

		[Token(Token = "0x4000289")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public FILE_READ_CALLBACK fileuserread;

		[Token(Token = "0x400028A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public FILE_SEEK_CALLBACK fileuserseek;

		[Token(Token = "0x400028B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public FILE_ASYNCREAD_CALLBACK fileuserasyncread;

		[Token(Token = "0x400028C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public FILE_ASYNCCANCEL_CALLBACK fileuserasynccancel;

		[Token(Token = "0x400028D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public IntPtr fileuserdata;

		[Token(Token = "0x400028E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public int filebuffersize;

		[Token(Token = "0x400028F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		public CHANNELORDER channelorder;

		[Token(Token = "0x4000290")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public IntPtr initialsoundgroup;

		[Token(Token = "0x4000291")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public uint initialseekposition;

		[Token(Token = "0x4000292")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		public TIMEUNIT initialseekpostype;

		[Token(Token = "0x4000293")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public int ignoresetfilesystem;

		[Token(Token = "0x4000294")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		public uint audioqueuepolicy;

		[Token(Token = "0x4000295")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public uint minmidigranularity;

		[Token(Token = "0x4000296")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		public int nonblockthreadid;

		[Token(Token = "0x4000297")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		public IntPtr fsbguid;
	}
	[Token(Token = "0x2000065")]
	public struct REVERB_PROPERTIES
	{
		[Token(Token = "0x4000298")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float DecayTime;

		[Token(Token = "0x4000299")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public float EarlyDelay;

		[Token(Token = "0x400029A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public float LateDelay;

		[Token(Token = "0x400029B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public float HFReference;

		[Token(Token = "0x400029C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float HFDecayRatio;

		[Token(Token = "0x400029D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public float Diffusion;

		[Token(Token = "0x400029E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float Density;

		[Token(Token = "0x400029F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float LowShelfFrequency;

		[Token(Token = "0x40002A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float LowShelfGain;

		[Token(Token = "0x40002A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float HighCut;

		[Token(Token = "0x40002A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float EarlyLateMix;

		[Token(Token = "0x40002A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float WetLevel;

		[Token(Token = "0x600029F")]
		[Address(RVA = "0x158309C", Offset = "0x158309C", VA = "0x158309C")]
		public REVERB_PROPERTIES(float decayTime, float earlyDelay, float lateDelay, float hfReference, float hfDecayRatio, float diffusion, float density, float lowShelfFrequency, float lowShelfGain, float highCut, float earlyLateMix, float wetLevel)
		{
		}
	}
	[Token(Token = "0x2000066")]
	public class PRESET
	{
		[Token(Token = "0x60002A0")]
		[Address(RVA = "0x1583078", Offset = "0x1583078", VA = "0x1583078")]
		public static REVERB_PROPERTIES OFF()
		{
			return default(REVERB_PROPERTIES);
		}

		[Token(Token = "0x60002A1")]
		[Address(RVA = "0x15830C8", Offset = "0x15830C8", VA = "0x15830C8")]
		public static REVERB_PROPERTIES GENERIC()
		{
			return default(REVERB_PROPERTIES);
		}

		[Token(Token = "0x60002A2")]
		[Address(RVA = "0x15830EC", Offset = "0x15830EC", VA = "0x15830EC")]
		public static REVERB_PROPERTIES PADDEDCELL()
		{
			return default(REVERB_PROPERTIES);
		}

		[Token(Token = "0x60002A3")]
		[Address(RVA = "0x1583110", Offset = "0x1583110", VA = "0x1583110")]
		public static REVERB_PROPERTIES ROOM()
		{
			return default(REVERB_PROPERTIES);
		}

		[Token(Token = "0x60002A4")]
		[Address(RVA = "0x1583134", Offset = "0x1583134", VA = "0x1583134")]
		public static REVERB_PROPERTIES BATHROOM()
		{
			return default(REVERB_PROPERTIES);
		}

		[Token(Token = "0x60002A5")]
		[Address(RVA = "0x1583158", Offset = "0x1583158", VA = "0x1583158")]
		public static REVERB_PROPERTIES LIVINGROOM()
		{
			return default(REVERB_PROPERTIES);
		}

		[Token(Token = "0x60002A6")]
		[Address(RVA = "0x158317C", Offset = "0x158317C", VA = "0x158317C")]
		public static REVERB_PROPERTIES STONEROOM()
		{
			return default(REVERB_PROPERTIES);
		}

		[Token(Token = "0x60002A7")]
		[Address(RVA = "0x15831A0", Offset = "0x15831A0", VA = "0x15831A0")]
		public static REVERB_PROPERTIES AUDITORIUM()
		{
			return default(REVERB_PROPERTIES);
		}

		[Token(Token = "0x60002A8")]
		[Address(RVA = "0x15831C4", Offset = "0x15831C4", VA = "0x15831C4")]
		public static REVERB_PROPERTIES CONCERTHALL()
		{
			return default(REVERB_PROPERTIES);
		}

		[Token(Token = "0x60002A9")]
		[Address(RVA = "0x15831E8", Offset = "0x15831E8", VA = "0x15831E8")]
		public static REVERB_PROPERTIES CAVE()
		{
			return default(REVERB_PROPERTIES);
		}

		[Token(Token = "0x60002AA")]
		[Address(RVA = "0x158320C", Offset = "0x158320C", VA = "0x158320C")]
		public static REVERB_PROPERTIES ARENA()
		{
			return default(REVERB_PROPERTIES);
		}

		[Token(Token = "0x60002AB")]
		[Address(RVA = "0x1583230", Offset = "0x1583230", VA = "0x1583230")]
		public static REVERB_PROPERTIES HANGAR()
		{
			return default(REVERB_PROPERTIES);
		}

		[Token(Token = "0x60002AC")]
		[Address(RVA = "0x1583254", Offset = "0x1583254", VA = "0x1583254")]
		public static REVERB_PROPERTIES CARPETTEDHALLWAY()
		{
			return default(REVERB_PROPERTIES);
		}

		[Token(Token = "0x60002AD")]
		[Address(RVA = "0x1583278", Offset = "0x1583278", VA = "0x1583278")]
		public static REVERB_PROPERTIES HALLWAY()
		{
			return default(REVERB_PROPERTIES);
		}

		[Token(Token = "0x60002AE")]
		[Address(RVA = "0x158329C", Offset = "0x158329C", VA = "0x158329C")]
		public static REVERB_PROPERTIES STONECORRIDOR()
		{
			return default(REVERB_PROPERTIES);
		}

		[Token(Token = "0x60002AF")]
		[Address(RVA = "0x15832C0", Offset = "0x15832C0", VA = "0x15832C0")]
		public static REVERB_PROPERTIES ALLEY()
		{
			return default(REVERB_PROPERTIES);
		}

		[Token(Token = "0x60002B0")]
		[Address(RVA = "0x15832E4", Offset = "0x15832E4", VA = "0x15832E4")]
		public static REVERB_PROPERTIES FOREST()
		{
			return default(REVERB_PROPERTIES);
		}

		[Token(Token = "0x60002B1")]
		[Address(RVA = "0x1583308", Offset = "0x1583308", VA = "0x1583308")]
		public static REVERB_PROPERTIES CITY()
		{
			return default(REVERB_PROPERTIES);
		}

		[Token(Token = "0x60002B2")]
		[Address(RVA = "0x158332C", Offset = "0x158332C", VA = "0x158332C")]
		public static REVERB_PROPERTIES MOUNTAINS()
		{
			return default(REVERB_PROPERTIES);
		}

		[Token(Token = "0x60002B3")]
		[Address(RVA = "0x1583350", Offset = "0x1583350", VA = "0x1583350")]
		public static REVERB_PROPERTIES QUARRY()
		{
			return default(REVERB_PROPERTIES);
		}

		[Token(Token = "0x60002B4")]
		[Address(RVA = "0x1583374", Offset = "0x1583374", VA = "0x1583374")]
		public static REVERB_PROPERTIES PLAIN()
		{
			return default(REVERB_PROPERTIES);
		}

		[Token(Token = "0x60002B5")]
		[Address(RVA = "0x1583398", Offset = "0x1583398", VA = "0x1583398")]
		public static REVERB_PROPERTIES PARKINGLOT()
		{
			return default(REVERB_PROPERTIES);
		}

		[Token(Token = "0x60002B6")]
		[Address(RVA = "0x15833BC", Offset = "0x15833BC", VA = "0x15833BC")]
		public static REVERB_PROPERTIES SEWERPIPE()
		{
			return default(REVERB_PROPERTIES);
		}

		[Token(Token = "0x60002B7")]
		[Address(RVA = "0x15833E0", Offset = "0x15833E0", VA = "0x15833E0")]
		public static REVERB_PROPERTIES UNDERWATER()
		{
			return default(REVERB_PROPERTIES);
		}

		[Token(Token = "0x60002B8")]
		[Address(RVA = "0x1583404", Offset = "0x1583404", VA = "0x1583404")]
		public PRESET()
		{
		}
	}
	[Token(Token = "0x2000067")]
	public struct ADVANCEDSETTINGS
	{
		[Token(Token = "0x40002A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int cbSize;

		[Token(Token = "0x40002A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public int maxMPEGCodecs;

		[Token(Token = "0x40002A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public int maxADPCMCodecs;

		[Token(Token = "0x40002A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public int maxXMACodecs;

		[Token(Token = "0x40002A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int maxVorbisCodecs;

		[Token(Token = "0x40002A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public int maxAT9Codecs;

		[Token(Token = "0x40002AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int maxFADPCMCodecs;

		[Token(Token = "0x40002AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public int maxPCMCodecs;

		[Token(Token = "0x40002AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public int ASIONumChannels;

		[Token(Token = "0x40002AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public IntPtr ASIOChannelList;

		[Token(Token = "0x40002AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public IntPtr ASIOSpeakerList;

		[Token(Token = "0x40002AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float vol0virtualvol;

		[Token(Token = "0x40002B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public uint defaultDecodeBufferSize;

		[Token(Token = "0x40002B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public ushort profilePort;

		[Token(Token = "0x40002B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public uint geometryMaxFadeTime;

		[Token(Token = "0x40002B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float distanceFilterCenterFreq;

		[Token(Token = "0x40002B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public int reverb3Dinstance;

		[Token(Token = "0x40002B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public int DSPBufferPoolSize;

		[Token(Token = "0x40002B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public uint stackSizeStream;

		[Token(Token = "0x40002B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public uint stackSizeNonBlocking;

		[Token(Token = "0x40002B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public uint stackSizeMixer;

		[Token(Token = "0x40002B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public DSP_RESAMPLER resamplerMethod;

		[Token(Token = "0x40002BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public uint commandQueueSize;

		[Token(Token = "0x40002BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public uint randomSeed;
	}
	[Token(Token = "0x2000068")]
	[Flags]
	public enum DRIVER_STATE : uint
	{
		[Token(Token = "0x40002BD")]
		CONNECTED = 1u,
		[Token(Token = "0x40002BE")]
		DEFAULT = 2u
	}
	[Token(Token = "0x2000069")]
	public struct Factory
	{
		[Token(Token = "0x60002B9")]
		[Address(RVA = "0x15815FC", Offset = "0x15815FC", VA = "0x15815FC")]
		public static RESULT System_Create(out System system)
		{
			return default(RESULT);
		}

		[PreserveSig]
		[Token(Token = "0x60002BA")]
		[Address(RVA = "0x1581600", Offset = "0x1581600", VA = "0x1581600")]
		private static extern RESULT FMOD5_System_Create(out IntPtr system);
	}
	[Token(Token = "0x200006A")]
	public struct Memory
	{
		[Token(Token = "0x60002BB")]
		[Address(RVA = "0x1582EF4", Offset = "0x1582EF4", VA = "0x1582EF4")]
		public static RESULT Initialize(IntPtr poolmem, int poollen, MEMORY_ALLOC_CALLBACK useralloc, MEMORY_REALLOC_CALLBACK userrealloc, MEMORY_FREE_CALLBACK userfree, MEMORY_TYPE memtypeflags = MEMORY_TYPE.ALL)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60002BC")]
		[Address(RVA = "0x1582FD8", Offset = "0x1582FD8", VA = "0x1582FD8")]
		public static RESULT GetStats(out int currentalloced, out int maxalloced, bool blocking = true)
		{
			return default(RESULT);
		}

		[PreserveSig]
		[Token(Token = "0x60002BD")]
		[Address(RVA = "0x1582EF8", Offset = "0x1582EF8", VA = "0x1582EF8")]
		private static extern RESULT FMOD5_Memory_Initialize(IntPtr poolmem, int poollen, MEMORY_ALLOC_CALLBACK useralloc, MEMORY_REALLOC_CALLBACK userrealloc, MEMORY_FREE_CALLBACK userfree, MEMORY_TYPE memtypeflags);

		[PreserveSig]
		[Token(Token = "0x60002BE")]
		[Address(RVA = "0x1582FE0", Offset = "0x1582FE0", VA = "0x1582FE0")]
		private static extern RESULT FMOD5_Memory_GetStats(out int currentalloced, out int maxalloced, bool blocking);
	}
	[Token(Token = "0x200006B")]
	public struct Debug
	{
		[Token(Token = "0x60002BF")]
		[Address(RVA = "0x157F670", Offset = "0x157F670", VA = "0x157F670")]
		public static RESULT Initialize(DEBUG_FLAGS flags, DEBUG_MODE mode = DEBUG_MODE.TTY, [Optional] DEBUG_CALLBACK callback, [Optional] string filename)
		{
			return default(RESULT);
		}

		[PreserveSig]
		[Token(Token = "0x60002C0")]
		[Address(RVA = "0x157FB8C", Offset = "0x157FB8C", VA = "0x157FB8C")]
		private static extern RESULT FMOD5_Debug_Initialize(DEBUG_FLAGS flags, DEBUG_MODE mode, DEBUG_CALLBACK callback, byte[] filename);
	}
	[Token(Token = "0x200006C")]
	public struct System
	{
		[Token(Token = "0x40002BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public IntPtr handle;

		[Token(Token = "0x60002C1")]
		[Address(RVA = "0xFBFCC0", Offset = "0xFBFCC0", VA = "0xFBFCC0")]
		public RESULT release()
		{
			return default(RESULT);
		}

		[Token(Token = "0x60002C2")]
		[Address(RVA = "0xFBFD48", Offset = "0xFBFD48", VA = "0xFBFD48")]
		public RESULT setOutput(OUTPUTTYPE output)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60002C3")]
		[Address(RVA = "0xFBFDE0", Offset = "0xFBFDE0", VA = "0xFBFDE0")]
		public RESULT getOutput(out OUTPUTTYPE output)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60002C4")]
		[Address(RVA = "0xFBFE78", Offset = "0xFBFE78", VA = "0xFBFE78")]
		public RESULT getNumDrivers(out int numdrivers)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60002C5")]
		[Address(RVA = "0xFBFF10", Offset = "0xFBFF10", VA = "0xFBFF10")]
		public RESULT getDriverInfo(int id, out string name, int namelen, out Guid guid, out int systemrate, out SPEAKERMODE speakermode, out int speakermodechannels)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60002C6")]
		[Address(RVA = "0xFC01E8", Offset = "0xFC01E8", VA = "0xFC01E8")]
		public RESULT getDriverInfo(int id, out Guid guid, out int systemrate, out SPEAKERMODE speakermode, out int speakermodechannels)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60002C7")]
		[Address(RVA = "0xFC0280", Offset = "0xFC0280", VA = "0xFC0280")]
		public RESULT setDriver(int driver)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60002C8")]
		[Address(RVA = "0xFC0318", Offset = "0xFC0318", VA = "0xFC0318")]
		public RESULT getDriver(out int driver)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60002C9")]
		[Address(RVA = "0xFC03B0", Offset = "0xFC03B0", VA = "0xFC03B0")]
		public RESULT setSoftwareChannels(int numsoftwarechannels)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60002CA")]
		[Address(RVA = "0xFC0448", Offset = "0xFC0448", VA = "0xFC0448")]
		public RESULT getSoftwareChannels(out int numsoftwarechannels)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60002CB")]
		[Address(RVA = "0xFC04E0", Offset = "0xFC04E0", VA = "0xFC04E0")]
		public RESULT setSoftwareFormat(int samplerate, SPEAKERMODE speakermode, int numrawspeakers)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60002CC")]
		[Address(RVA = "0xFC0590", Offset = "0xFC0590", VA = "0xFC0590")]
		public RESULT getSoftwareFormat(out int samplerate, out SPEAKERMODE speakermode, out int numrawspeakers)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60002CD")]
		[Address(RVA = "0xFC0640", Offset = "0xFC0640", VA = "0xFC0640")]
		public RESULT setDSPBufferSize(uint bufferlength, int numbuffers)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60002CE")]
		[Address(RVA = "0xFC06E0", Offset = "0xFC06E0", VA = "0xFC06E0")]
		public RESULT getDSPBufferSize(out uint bufferlength, out int numbuffers)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60002CF")]
		[Address(RVA = "0xFC0780", Offset = "0xFC0780", VA = "0xFC0780")]
		public RESULT setFileSystem(FILE_OPEN_CALLBACK useropen, FILE_CLOSE_CALLBACK userclose, FILE_READ_CALLBACK userread, FILE_SEEK_CALLBACK userseek, FILE_ASYNCREAD_CALLBACK userasyncread, FILE_ASYNCCANCEL_CALLBACK userasynccancel, int blockalign)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60002D0")]
		[Address(RVA = "0xFC08A4", Offset = "0xFC08A4", VA = "0xFC08A4")]
		public RESULT attachFileSystem(FILE_OPEN_CALLBACK useropen, FILE_CLOSE_CALLBACK userclose, FILE_READ_CALLBACK userread, FILE_SEEK_CALLBACK userseek)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60002D1")]
		[Address(RVA = "0xFC0988", Offset = "0xFC0988", VA = "0xFC0988")]
		public RESULT setAdvancedSettings(ref ADVANCEDSETTINGS settings)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60002D2")]
		[Address(RVA = "0xFC0AD4", Offset = "0xFC0AD4", VA = "0xFC0AD4")]
		public RESULT getAdvancedSettings(ref ADVANCEDSETTINGS settings)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60002D3")]
		[Address(RVA = "0xFC0C20", Offset = "0xFC0C20", VA = "0xFC0C20")]
		public RESULT setCallback(SYSTEM_CALLBACK callback, SYSTEM_CALLBACK_TYPE callbackmask = SYSTEM_CALLBACK_TYPE.ALL)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60002D4")]
		[Address(RVA = "0xFC0CC8", Offset = "0xFC0CC8", VA = "0xFC0CC8")]
		public RESULT setPluginPath(string path)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60002D5")]
		[Address(RVA = "0xFC0EB0", Offset = "0xFC0EB0", VA = "0xFC0EB0")]
		public RESULT loadPlugin(string filename, out uint handle, uint priority = 0u)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60002D6")]
		[Address(RVA = "0xFC10C8", Offset = "0xFC10C8", VA = "0xFC10C8")]
		public RESULT unloadPlugin(uint handle)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60002D7")]
		[Address(RVA = "0xFC1160", Offset = "0xFC1160", VA = "0xFC1160")]
		public RESULT getNumNestedPlugins(uint handle, out int count)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60002D8")]
		[Address(RVA = "0xFC1200", Offset = "0xFC1200", VA = "0xFC1200")]
		public RESULT getNestedPlugin(uint handle, int index, out uint nestedhandle)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60002D9")]
		[Address(RVA = "0xFC12B0", Offset = "0xFC12B0", VA = "0xFC12B0")]
		public RESULT getNumPlugins(PLUGINTYPE plugintype, out int numplugins)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60002DA")]
		[Address(RVA = "0xFC1350", Offset = "0xFC1350", VA = "0xFC1350")]
		public RESULT getPluginHandle(PLUGINTYPE plugintype, int index, out uint handle)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60002DB")]
		[Address(RVA = "0xFC1400", Offset = "0xFC1400", VA = "0xFC1400")]
		public RESULT getPluginInfo(uint handle, out PLUGINTYPE plugintype, out string name, int namelen, out uint version)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60002DC")]
		[Address(RVA = "0xFC16A0", Offset = "0xFC16A0", VA = "0xFC16A0")]
		public RESULT getPluginInfo(uint handle, out PLUGINTYPE plugintype, out uint version)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60002DD")]
		[Address(RVA = "0xFC1714", Offset = "0xFC1714", VA = "0xFC1714")]
		public RESULT setOutputByPlugin(uint handle)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60002DE")]
		[Address(RVA = "0xFC17AC", Offset = "0xFC17AC", VA = "0xFC17AC")]
		public RESULT getOutputByPlugin(out uint handle)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60002DF")]
		[Address(RVA = "0xFC1844", Offset = "0xFC1844", VA = "0xFC1844")]
		public RESULT createDSPByPlugin(uint handle, out DSP dsp)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60002E0")]
		[Address(RVA = "0xFC18E4", Offset = "0xFC18E4", VA = "0xFC18E4")]
		public RESULT getDSPInfoByPlugin(uint handle, out IntPtr description)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60002E1")]
		[Address(RVA = "0xFC1984", Offset = "0xFC1984", VA = "0xFC1984")]
		public RESULT registerDSP(ref DSP_DESCRIPTION description, out uint handle)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60002E2")]
		[Address(RVA = "0xFC1A8C", Offset = "0xFC1A8C", VA = "0xFC1A8C")]
		public RESULT init(int maxchannels, INITFLAGS flags, IntPtr extradriverdata)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60002E3")]
		[Address(RVA = "0xFC1B3C", Offset = "0xFC1B3C", VA = "0xFC1B3C")]
		public RESULT close()
		{
			return default(RESULT);
		}

		[Token(Token = "0x60002E4")]
		[Address(RVA = "0xFC1BC4", Offset = "0xFC1BC4", VA = "0xFC1BC4")]
		public RESULT update()
		{
			return default(RESULT);
		}

		[Token(Token = "0x60002E5")]
		[Address(RVA = "0xFC1C4C", Offset = "0xFC1C4C", VA = "0xFC1C4C")]
		public RESULT setSpeakerPosition(SPEAKER speaker, float x, float y, bool active)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60002E6")]
		[Address(RVA = "0xFC1D08", Offset = "0xFC1D08", VA = "0xFC1D08")]
		public RESULT getSpeakerPosition(SPEAKER speaker, out float x, out float y, out bool active)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60002E7")]
		[Address(RVA = "0xFC1DD4", Offset = "0xFC1DD4", VA = "0xFC1DD4")]
		public RESULT setStreamBufferSize(uint filebuffersize, TIMEUNIT filebuffersizetype)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60002E8")]
		[Address(RVA = "0xFC1E74", Offset = "0xFC1E74", VA = "0xFC1E74")]
		public RESULT getStreamBufferSize(out uint filebuffersize, out TIMEUNIT filebuffersizetype)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60002E9")]
		[Address(RVA = "0xFC1F14", Offset = "0xFC1F14", VA = "0xFC1F14")]
		public RESULT set3DSettings(float dopplerscale, float distancefactor, float rolloffscale)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60002EA")]
		[Address(RVA = "0xFC1FC4", Offset = "0xFC1FC4", VA = "0xFC1FC4")]
		public RESULT get3DSettings(out float dopplerscale, out float distancefactor, out float rolloffscale)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60002EB")]
		[Address(RVA = "0xFC2074", Offset = "0xFC2074", VA = "0xFC2074")]
		public RESULT set3DNumListeners(int numlisteners)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60002EC")]
		[Address(RVA = "0xFC210C", Offset = "0xFC210C", VA = "0xFC210C")]
		public RESULT get3DNumListeners(out int numlisteners)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60002ED")]
		[Address(RVA = "0xFC21A4", Offset = "0xFC21A4", VA = "0xFC21A4")]
		public RESULT set3DListenerAttributes(int listener, ref VECTOR pos, ref VECTOR vel, ref VECTOR forward, ref VECTOR up)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60002EE")]
		[Address(RVA = "0xFC226C", Offset = "0xFC226C", VA = "0xFC226C")]
		public RESULT get3DListenerAttributes(int listener, out VECTOR pos, out VECTOR vel, out VECTOR forward, out VECTOR up)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60002EF")]
		[Address(RVA = "0xFC2334", Offset = "0xFC2334", VA = "0xFC2334")]
		public RESULT set3DRolloffCallback(CB_3D_ROLLOFF_CALLBACK callback)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60002F0")]
		[Address(RVA = "0xFC23D4", Offset = "0xFC23D4", VA = "0xFC23D4")]
		public RESULT mixerSuspend()
		{
			return default(RESULT);
		}

		[Token(Token = "0x60002F1")]
		[Address(RVA = "0xFC245C", Offset = "0xFC245C", VA = "0xFC245C")]
		public RESULT mixerResume()
		{
			return default(RESULT);
		}

		[Token(Token = "0x60002F2")]
		[Address(RVA = "0xFC24E4", Offset = "0xFC24E4", VA = "0xFC24E4")]
		public RESULT getDefaultMixMatrix(SPEAKERMODE sourcespeakermode, SPEAKERMODE targetspeakermode, float[] matrix, int matrixhop)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60002F3")]
		[Address(RVA = "0xFC25A4", Offset = "0xFC25A4", VA = "0xFC25A4")]
		public RESULT getSpeakerModeChannels(SPEAKERMODE mode, out int channels)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60002F4")]
		[Address(RVA = "0xFC2644", Offset = "0xFC2644", VA = "0xFC2644")]
		public RESULT getVersion(out uint version)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60002F5")]
		[Address(RVA = "0xFC26DC", Offset = "0xFC26DC", VA = "0xFC26DC")]
		public RESULT getOutputHandle(out IntPtr handle)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60002F6")]
		[Address(RVA = "0xFC2774", Offset = "0xFC2774", VA = "0xFC2774")]
		public RESULT getChannelsPlaying(out int channels)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60002F7")]
		[Address(RVA = "0xFC2864", Offset = "0xFC2864", VA = "0xFC2864")]
		public RESULT getChannelsPlaying(out int channels, out int realchannels)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60002F8")]
		[Address(RVA = "0xFC2904", Offset = "0xFC2904", VA = "0xFC2904")]
		public RESULT getCPUUsage(out float dsp, out float stream, out float geometry, out float update, out float total)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60002F9")]
		[Address(RVA = "0xFC29CC", Offset = "0xFC29CC", VA = "0xFC29CC")]
		public RESULT getFileUsage(out long sampleBytesRead, out long streamBytesRead, out long otherBytesRead)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60002FA")]
		[Address(RVA = "0xFC2A7C", Offset = "0xFC2A7C", VA = "0xFC2A7C")]
		public RESULT createSound(string name, MODE mode, ref CREATESOUNDEXINFO exinfo, out Sound sound)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60002FB")]
		[Address(RVA = "0xFC2D14", Offset = "0xFC2D14", VA = "0xFC2D14")]
		public RESULT createSound(byte[] data, MODE mode, ref CREATESOUNDEXINFO exinfo, out Sound sound)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60002FC")]
		[Address(RVA = "0xFC2D1C", Offset = "0xFC2D1C", VA = "0xFC2D1C")]
		public RESULT createSound(IntPtr name_or_data, MODE mode, ref CREATESOUNDEXINFO exinfo, out Sound sound)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60002FD")]
		[Address(RVA = "0xFC2E40", Offset = "0xFC2E40", VA = "0xFC2E40")]
		public RESULT createSound(string name, MODE mode, out Sound sound)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60002FE")]
		[Address(RVA = "0xFC2F28", Offset = "0xFC2F28", VA = "0xFC2F28")]
		public RESULT createStream(string name, MODE mode, ref CREATESOUNDEXINFO exinfo, out Sound sound)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60002FF")]
		[Address(RVA = "0xFC31C0", Offset = "0xFC31C0", VA = "0xFC31C0")]
		public RESULT createStream(byte[] data, MODE mode, ref CREATESOUNDEXINFO exinfo, out Sound sound)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000300")]
		[Address(RVA = "0xFC31C8", Offset = "0xFC31C8", VA = "0xFC31C8")]
		public RESULT createStream(IntPtr name_or_data, MODE mode, ref CREATESOUNDEXINFO exinfo, out Sound sound)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000301")]
		[Address(RVA = "0xFC32EC", Offset = "0xFC32EC", VA = "0xFC32EC")]
		public RESULT createStream(string name, MODE mode, out Sound sound)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000302")]
		[Address(RVA = "0xFC33D4", Offset = "0xFC33D4", VA = "0xFC33D4")]
		public RESULT createDSP(ref DSP_DESCRIPTION description, out DSP dsp)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000303")]
		[Address(RVA = "0xFC34E0", Offset = "0xFC34E0", VA = "0xFC34E0")]
		public RESULT createDSPByType(DSP_TYPE type, out DSP dsp)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000304")]
		[Address(RVA = "0xFC3580", Offset = "0xFC3580", VA = "0xFC3580")]
		public RESULT createChannelGroup(string name, out ChannelGroup channelgroup)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000305")]
		[Address(RVA = "0xFC3778", Offset = "0xFC3778", VA = "0xFC3778")]
		public RESULT createSoundGroup(string name, out SoundGroup soundgroup)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000306")]
		[Address(RVA = "0xFC3970", Offset = "0xFC3970", VA = "0xFC3970")]
		public RESULT createReverb3D(out Reverb3D reverb)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000307")]
		[Address(RVA = "0xFC3A08", Offset = "0xFC3A08", VA = "0xFC3A08")]
		public RESULT playSound(Sound sound, ChannelGroup channelgroup, bool paused, out Channel channel)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000308")]
		[Address(RVA = "0xFC3AC4", Offset = "0xFC3AC4", VA = "0xFC3AC4")]
		public RESULT playDSP(DSP dsp, ChannelGroup channelgroup, bool paused, out Channel channel)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000309")]
		[Address(RVA = "0xFC3B80", Offset = "0xFC3B80", VA = "0xFC3B80")]
		public RESULT getChannel(int channelid, out Channel channel)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600030A")]
		[Address(RVA = "0xFC3C20", Offset = "0xFC3C20", VA = "0xFC3C20")]
		public RESULT getMasterChannelGroup(out ChannelGroup channelgroup)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600030B")]
		[Address(RVA = "0xFC3CB8", Offset = "0xFC3CB8", VA = "0xFC3CB8")]
		public RESULT getMasterSoundGroup(out SoundGroup soundgroup)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600030C")]
		[Address(RVA = "0xFC3D50", Offset = "0xFC3D50", VA = "0xFC3D50")]
		public RESULT attachChannelGroupToPort(uint portType, ulong portIndex, ChannelGroup channelgroup, bool passThru = false)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600030D")]
		[Address(RVA = "0xFC3E0C", Offset = "0xFC3E0C", VA = "0xFC3E0C")]
		public RESULT detachChannelGroupFromPort(ChannelGroup channelgroup)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600030E")]
		[Address(RVA = "0xFC3EA4", Offset = "0xFC3EA4", VA = "0xFC3EA4")]
		public RESULT setReverbProperties(int instance, ref REVERB_PROPERTIES prop)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600030F")]
		[Address(RVA = "0xFC3F44", Offset = "0xFC3F44", VA = "0xFC3F44")]
		public RESULT getReverbProperties(int instance, out REVERB_PROPERTIES prop)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000310")]
		[Address(RVA = "0xFC3FE4", Offset = "0xFC3FE4", VA = "0xFC3FE4")]
		public RESULT lockDSP()
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000311")]
		[Address(RVA = "0xFC406C", Offset = "0xFC406C", VA = "0xFC406C")]
		public RESULT unlockDSP()
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000312")]
		[Address(RVA = "0xFC40F4", Offset = "0xFC40F4", VA = "0xFC40F4")]
		public RESULT getRecordNumDrivers(out int numdrivers, out int numconnected)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000313")]
		[Address(RVA = "0xFC4194", Offset = "0xFC4194", VA = "0xFC4194")]
		public RESULT getRecordDriverInfo(int id, out string name, int namelen, out Guid guid, out int systemrate, out SPEAKERMODE speakermode, out int speakermodechannels, out DRIVER_STATE state)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000314")]
		[Address(RVA = "0xFC447C", Offset = "0xFC447C", VA = "0xFC447C")]
		public RESULT getRecordDriverInfo(int id, out Guid guid, out int systemrate, out SPEAKERMODE speakermode, out int speakermodechannels, out DRIVER_STATE state)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000315")]
		[Address(RVA = "0xFC451C", Offset = "0xFC451C", VA = "0xFC451C")]
		public RESULT getRecordPosition(int id, out uint position)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000316")]
		[Address(RVA = "0xFC45BC", Offset = "0xFC45BC", VA = "0xFC45BC")]
		public RESULT recordStart(int id, Sound sound, bool loop)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000317")]
		[Address(RVA = "0xFC466C", Offset = "0xFC466C", VA = "0xFC466C")]
		public RESULT recordStop(int id)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000318")]
		[Address(RVA = "0xFC4704", Offset = "0xFC4704", VA = "0xFC4704")]
		public RESULT isRecording(int id, out bool recording)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000319")]
		[Address(RVA = "0xFC47B8", Offset = "0xFC47B8", VA = "0xFC47B8")]
		public RESULT createGeometry(int maxpolygons, int maxvertices, out Geometry geometry)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600031A")]
		[Address(RVA = "0xFC4868", Offset = "0xFC4868", VA = "0xFC4868")]
		public RESULT setGeometrySettings(float maxworldsize)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600031B")]
		[Address(RVA = "0xFC4900", Offset = "0xFC4900", VA = "0xFC4900")]
		public RESULT getGeometrySettings(out float maxworldsize)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600031C")]
		[Address(RVA = "0xFC4998", Offset = "0xFC4998", VA = "0xFC4998")]
		public RESULT loadGeometry(IntPtr data, int datasize, out Geometry geometry)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600031D")]
		[Address(RVA = "0xFC4A48", Offset = "0xFC4A48", VA = "0xFC4A48")]
		public RESULT getGeometryOcclusion(ref VECTOR listener, ref VECTOR source, out float direct, out float reverb)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600031E")]
		[Address(RVA = "0xFC4B00", Offset = "0xFC4B00", VA = "0xFC4B00")]
		public RESULT setNetworkProxy(string proxy)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600031F")]
		[Address(RVA = "0xFC4CE8", Offset = "0xFC4CE8", VA = "0xFC4CE8")]
		public RESULT getNetworkProxy(out string proxy, int proxylen)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000320")]
		[Address(RVA = "0xFC4F40", Offset = "0xFC4F40", VA = "0xFC4F40")]
		public RESULT setNetworkTimeout(int timeout)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000321")]
		[Address(RVA = "0xFC4FD8", Offset = "0xFC4FD8", VA = "0xFC4FD8")]
		public RESULT getNetworkTimeout(out int timeout)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000322")]
		[Address(RVA = "0xFC5070", Offset = "0xFC5070", VA = "0xFC5070")]
		public RESULT setUserData(IntPtr userdata)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000323")]
		[Address(RVA = "0xFC5108", Offset = "0xFC5108", VA = "0xFC5108")]
		public RESULT getUserData(out IntPtr userdata)
		{
			return default(RESULT);
		}

		[PreserveSig]
		[Token(Token = "0x6000324")]
		[Address(RVA = "0xFBFCC8", Offset = "0xFBFCC8", VA = "0xFBFCC8")]
		private static extern RESULT FMOD5_System_Release(IntPtr system);

		[PreserveSig]
		[Token(Token = "0x6000325")]
		[Address(RVA = "0xFBFD50", Offset = "0xFBFD50", VA = "0xFBFD50")]
		private static extern RESULT FMOD5_System_SetOutput(IntPtr system, OUTPUTTYPE output);

		[PreserveSig]
		[Token(Token = "0x6000326")]
		[Address(RVA = "0xFBFDE8", Offset = "0xFBFDE8", VA = "0xFBFDE8")]
		private static extern RESULT FMOD5_System_GetOutput(IntPtr system, out OUTPUTTYPE output);

		[PreserveSig]
		[Token(Token = "0x6000327")]
		[Address(RVA = "0xFBFE80", Offset = "0xFBFE80", VA = "0xFBFE80")]
		private static extern RESULT FMOD5_System_GetNumDrivers(IntPtr system, out int numdrivers);

		[PreserveSig]
		[Token(Token = "0x6000328")]
		[Address(RVA = "0xFC0110", Offset = "0xFC0110", VA = "0xFC0110")]
		private static extern RESULT FMOD5_System_GetDriverInfo(IntPtr system, int id, IntPtr name, int namelen, out Guid guid, out int systemrate, out SPEAKERMODE speakermode, out int speakermodechannels);

		[PreserveSig]
		[Token(Token = "0x6000329")]
		[Address(RVA = "0xFC0288", Offset = "0xFC0288", VA = "0xFC0288")]
		private static extern RESULT FMOD5_System_SetDriver(IntPtr system, int driver);

		[PreserveSig]
		[Token(Token = "0x600032A")]
		[Address(RVA = "0xFC0320", Offset = "0xFC0320", VA = "0xFC0320")]
		private static extern RESULT FMOD5_System_GetDriver(IntPtr system, out int driver);

		[PreserveSig]
		[Token(Token = "0x600032B")]
		[Address(RVA = "0xFC03B8", Offset = "0xFC03B8", VA = "0xFC03B8")]
		private static extern RESULT FMOD5_System_SetSoftwareChannels(IntPtr system, int numsoftwarechannels);

		[PreserveSig]
		[Token(Token = "0x600032C")]
		[Address(RVA = "0xFC0450", Offset = "0xFC0450", VA = "0xFC0450")]
		private static extern RESULT FMOD5_System_GetSoftwareChannels(IntPtr system, out int numsoftwarechannels);

		[PreserveSig]
		[Token(Token = "0x600032D")]
		[Address(RVA = "0xFC04E8", Offset = "0xFC04E8", VA = "0xFC04E8")]
		private static extern RESULT FMOD5_System_SetSoftwareFormat(IntPtr system, int samplerate, SPEAKERMODE speakermode, int numrawspeakers);

		[PreserveSig]
		[Token(Token = "0x600032E")]
		[Address(RVA = "0xFC0598", Offset = "0xFC0598", VA = "0xFC0598")]
		private static extern RESULT FMOD5_System_GetSoftwareFormat(IntPtr system, out int samplerate, out SPEAKERMODE speakermode, out int numrawspeakers);

		[PreserveSig]
		[Token(Token = "0x600032F")]
		[Address(RVA = "0xFC0648", Offset = "0xFC0648", VA = "0xFC0648")]
		private static extern RESULT FMOD5_System_SetDSPBufferSize(IntPtr system, uint bufferlength, int numbuffers);

		[PreserveSig]
		[Token(Token = "0x6000330")]
		[Address(RVA = "0xFC06E8", Offset = "0xFC06E8", VA = "0xFC06E8")]
		private static extern RESULT FMOD5_System_GetDSPBufferSize(IntPtr system, out uint bufferlength, out int numbuffers);

		[PreserveSig]
		[Token(Token = "0x6000331")]
		[Address(RVA = "0xFC0788", Offset = "0xFC0788", VA = "0xFC0788")]
		private static extern RESULT FMOD5_System_SetFileSystem(IntPtr system, FILE_OPEN_CALLBACK useropen, FILE_CLOSE_CALLBACK userclose, FILE_READ_CALLBACK userread, FILE_SEEK_CALLBACK userseek, FILE_ASYNCREAD_CALLBACK userasyncread, FILE_ASYNCCANCEL_CALLBACK userasynccancel, int blockalign);

		[PreserveSig]
		[Token(Token = "0x6000332")]
		[Address(RVA = "0xFC08AC", Offset = "0xFC08AC", VA = "0xFC08AC")]
		private static extern RESULT FMOD5_System_AttachFileSystem(IntPtr system, FILE_OPEN_CALLBACK useropen, FILE_CLOSE_CALLBACK userclose, FILE_READ_CALLBACK userread, FILE_SEEK_CALLBACK userseek);

		[PreserveSig]
		[Token(Token = "0x6000333")]
		[Address(RVA = "0xFC0A44", Offset = "0xFC0A44", VA = "0xFC0A44")]
		private static extern RESULT FMOD5_System_SetAdvancedSettings(IntPtr system, ref ADVANCEDSETTINGS settings);

		[PreserveSig]
		[Token(Token = "0x6000334")]
		[Address(RVA = "0xFC0B90", Offset = "0xFC0B90", VA = "0xFC0B90")]
		private static extern RESULT FMOD5_System_GetAdvancedSettings(IntPtr system, ref ADVANCEDSETTINGS settings);

		[PreserveSig]
		[Token(Token = "0x6000335")]
		[Address(RVA = "0xFC0C28", Offset = "0xFC0C28", VA = "0xFC0C28")]
		private static extern RESULT FMOD5_System_SetCallback(IntPtr system, SYSTEM_CALLBACK callback, SYSTEM_CALLBACK_TYPE callbackmask);

		[PreserveSig]
		[Token(Token = "0x6000336")]
		[Address(RVA = "0xFC0E18", Offset = "0xFC0E18", VA = "0xFC0E18")]
		private static extern RESULT FMOD5_System_SetPluginPath(IntPtr system, byte[] path);

		[PreserveSig]
		[Token(Token = "0x6000337")]
		[Address(RVA = "0xFC1018", Offset = "0xFC1018", VA = "0xFC1018")]
		private static extern RESULT FMOD5_System_LoadPlugin(IntPtr system, byte[] filename, out uint handle, uint priority);

		[PreserveSig]
		[Token(Token = "0x6000338")]
		[Address(RVA = "0xFC10D0", Offset = "0xFC10D0", VA = "0xFC10D0")]
		private static extern RESULT FMOD5_System_UnloadPlugin(IntPtr system, uint handle);

		[PreserveSig]
		[Token(Token = "0x6000339")]
		[Address(RVA = "0xFC1168", Offset = "0xFC1168", VA = "0xFC1168")]
		private static extern RESULT FMOD5_System_GetNumNestedPlugins(IntPtr system, uint handle, out int count);

		[PreserveSig]
		[Token(Token = "0x600033A")]
		[Address(RVA = "0xFC1208", Offset = "0xFC1208", VA = "0xFC1208")]
		private static extern RESULT FMOD5_System_GetNestedPlugin(IntPtr system, uint handle, int index, out uint nestedhandle);

		[PreserveSig]
		[Token(Token = "0x600033B")]
		[Address(RVA = "0xFC12B8", Offset = "0xFC12B8", VA = "0xFC12B8")]
		private static extern RESULT FMOD5_System_GetNumPlugins(IntPtr system, PLUGINTYPE plugintype, out int numplugins);

		[PreserveSig]
		[Token(Token = "0x600033C")]
		[Address(RVA = "0xFC1358", Offset = "0xFC1358", VA = "0xFC1358")]
		private static extern RESULT FMOD5_System_GetPluginHandle(IntPtr system, PLUGINTYPE plugintype, int index, out uint handle);

		[PreserveSig]
		[Token(Token = "0x600033D")]
		[Address(RVA = "0xFC15E0", Offset = "0xFC15E0", VA = "0xFC15E0")]
		private static extern RESULT FMOD5_System_GetPluginInfo(IntPtr system, uint handle, out PLUGINTYPE plugintype, IntPtr name, int namelen, out uint version);

		[PreserveSig]
		[Token(Token = "0x600033E")]
		[Address(RVA = "0xFC171C", Offset = "0xFC171C", VA = "0xFC171C")]
		private static extern RESULT FMOD5_System_SetOutputByPlugin(IntPtr system, uint handle);

		[PreserveSig]
		[Token(Token = "0x600033F")]
		[Address(RVA = "0xFC17B4", Offset = "0xFC17B4", VA = "0xFC17B4")]
		private static extern RESULT FMOD5_System_GetOutputByPlugin(IntPtr system, out uint handle);

		[PreserveSig]
		[Token(Token = "0x6000340")]
		[Address(RVA = "0xFC184C", Offset = "0xFC184C", VA = "0xFC184C")]
		private static extern RESULT FMOD5_System_CreateDSPByPlugin(IntPtr system, uint handle, out IntPtr dsp);

		[PreserveSig]
		[Token(Token = "0x6000341")]
		[Address(RVA = "0xFC18EC", Offset = "0xFC18EC", VA = "0xFC18EC")]
		private static extern RESULT FMOD5_System_GetDSPInfoByPlugin(IntPtr system, uint handle, out IntPtr description);

		[PreserveSig]
		[Token(Token = "0x6000342")]
		[Address(RVA = "0xFC198C", Offset = "0xFC198C", VA = "0xFC198C")]
		private static extern RESULT FMOD5_System_RegisterDSP(IntPtr system, ref DSP_DESCRIPTION description, out uint handle);

		[PreserveSig]
		[Token(Token = "0x6000343")]
		[Address(RVA = "0xFC1A94", Offset = "0xFC1A94", VA = "0xFC1A94")]
		private static extern RESULT FMOD5_System_Init(IntPtr system, int maxchannels, INITFLAGS flags, IntPtr extradriverdata);

		[PreserveSig]
		[Token(Token = "0x6000344")]
		[Address(RVA = "0xFC1B44", Offset = "0xFC1B44", VA = "0xFC1B44")]
		private static extern RESULT FMOD5_System_Close(IntPtr system);

		[PreserveSig]
		[Token(Token = "0x6000345")]
		[Address(RVA = "0xFC1BCC", Offset = "0xFC1BCC", VA = "0xFC1BCC")]
		private static extern RESULT FMOD5_System_Update(IntPtr system);

		[PreserveSig]
		[Token(Token = "0x6000346")]
		[Address(RVA = "0xFC1C58", Offset = "0xFC1C58", VA = "0xFC1C58")]
		private static extern RESULT FMOD5_System_SetSpeakerPosition(IntPtr system, SPEAKER speaker, float x, float y, bool active);

		[PreserveSig]
		[Token(Token = "0x6000347")]
		[Address(RVA = "0xFC1D10", Offset = "0xFC1D10", VA = "0xFC1D10")]
		private static extern RESULT FMOD5_System_GetSpeakerPosition(IntPtr system, SPEAKER speaker, out float x, out float y, out bool active);

		[PreserveSig]
		[Token(Token = "0x6000348")]
		[Address(RVA = "0xFC1DDC", Offset = "0xFC1DDC", VA = "0xFC1DDC")]
		private static extern RESULT FMOD5_System_SetStreamBufferSize(IntPtr system, uint filebuffersize, TIMEUNIT filebuffersizetype);

		[PreserveSig]
		[Token(Token = "0x6000349")]
		[Address(RVA = "0xFC1E7C", Offset = "0xFC1E7C", VA = "0xFC1E7C")]
		private static extern RESULT FMOD5_System_GetStreamBufferSize(IntPtr system, out uint filebuffersize, out TIMEUNIT filebuffersizetype);

		[PreserveSig]
		[Token(Token = "0x600034A")]
		[Address(RVA = "0xFC1F1C", Offset = "0xFC1F1C", VA = "0xFC1F1C")]
		private static extern RESULT FMOD5_System_Set3DSettings(IntPtr system, float dopplerscale, float distancefactor, float rolloffscale);

		[PreserveSig]
		[Token(Token = "0x600034B")]
		[Address(RVA = "0xFC1FCC", Offset = "0xFC1FCC", VA = "0xFC1FCC")]
		private static extern RESULT FMOD5_System_Get3DSettings(IntPtr system, out float dopplerscale, out float distancefactor, out float rolloffscale);

		[PreserveSig]
		[Token(Token = "0x600034C")]
		[Address(RVA = "0xFC207C", Offset = "0xFC207C", VA = "0xFC207C")]
		private static extern RESULT FMOD5_System_Set3DNumListeners(IntPtr system, int numlisteners);

		[PreserveSig]
		[Token(Token = "0x600034D")]
		[Address(RVA = "0xFC2114", Offset = "0xFC2114", VA = "0xFC2114")]
		private static extern RESULT FMOD5_System_Get3DNumListeners(IntPtr system, out int numlisteners);

		[PreserveSig]
		[Token(Token = "0x600034E")]
		[Address(RVA = "0xFC21AC", Offset = "0xFC21AC", VA = "0xFC21AC")]
		private static extern RESULT FMOD5_System_Set3DListenerAttributes(IntPtr system, int listener, ref VECTOR pos, ref VECTOR vel, ref VECTOR forward, ref VECTOR up);

		[PreserveSig]
		[Token(Token = "0x600034F")]
		[Address(RVA = "0xFC2274", Offset = "0xFC2274", VA = "0xFC2274")]
		private static extern RESULT FMOD5_System_Get3DListenerAttributes(IntPtr system, int listener, out VECTOR pos, out VECTOR vel, out VECTOR forward, out VECTOR up);

		[PreserveSig]
		[Token(Token = "0x6000350")]
		[Address(RVA = "0xFC233C", Offset = "0xFC233C", VA = "0xFC233C")]
		private static extern RESULT FMOD5_System_Set3DRolloffCallback(IntPtr system, CB_3D_ROLLOFF_CALLBACK callback);

		[PreserveSig]
		[Token(Token = "0x6000351")]
		[Address(RVA = "0xFC23DC", Offset = "0xFC23DC", VA = "0xFC23DC")]
		private static extern RESULT FMOD5_System_MixerSuspend(IntPtr system);

		[PreserveSig]
		[Token(Token = "0x6000352")]
		[Address(RVA = "0xFC2464", Offset = "0xFC2464", VA = "0xFC2464")]
		private static extern RESULT FMOD5_System_MixerResume(IntPtr system);

		[PreserveSig]
		[Token(Token = "0x6000353")]
		[Address(RVA = "0xFC24EC", Offset = "0xFC24EC", VA = "0xFC24EC")]
		private static extern RESULT FMOD5_System_GetDefaultMixMatrix(IntPtr system, SPEAKERMODE sourcespeakermode, SPEAKERMODE targetspeakermode, float[] matrix, int matrixhop);

		[PreserveSig]
		[Token(Token = "0x6000354")]
		[Address(RVA = "0xFC25AC", Offset = "0xFC25AC", VA = "0xFC25AC")]
		private static extern RESULT FMOD5_System_GetSpeakerModeChannels(IntPtr system, SPEAKERMODE mode, out int channels);

		[PreserveSig]
		[Token(Token = "0x6000355")]
		[Address(RVA = "0xFC264C", Offset = "0xFC264C", VA = "0xFC264C")]
		private static extern RESULT FMOD5_System_GetVersion(IntPtr system, out uint version);

		[PreserveSig]
		[Token(Token = "0x6000356")]
		[Address(RVA = "0xFC26E4", Offset = "0xFC26E4", VA = "0xFC26E4")]
		private static extern RESULT FMOD5_System_GetOutputHandle(IntPtr system, out IntPtr handle);

		[PreserveSig]
		[Token(Token = "0x6000357")]
		[Address(RVA = "0xFC27CC", Offset = "0xFC27CC", VA = "0xFC27CC")]
		private static extern RESULT FMOD5_System_GetChannelsPlaying(IntPtr system, out int channels, IntPtr zero);

		[PreserveSig]
		[Token(Token = "0x6000358")]
		[Address(RVA = "0xFC286C", Offset = "0xFC286C", VA = "0xFC286C")]
		private static extern RESULT FMOD5_System_GetChannelsPlaying(IntPtr system, out int channels, out int realchannels);

		[PreserveSig]
		[Token(Token = "0x6000359")]
		[Address(RVA = "0xFC290C", Offset = "0xFC290C", VA = "0xFC290C")]
		private static extern RESULT FMOD5_System_GetCPUUsage(IntPtr system, out float dsp, out float stream, out float geometry, out float update, out float total);

		[PreserveSig]
		[Token(Token = "0x600035A")]
		[Address(RVA = "0xFC29D4", Offset = "0xFC29D4", VA = "0xFC29D4")]
		private static extern RESULT FMOD5_System_GetFileUsage(IntPtr system, out long sampleBytesRead, out long streamBytesRead, out long otherBytesRead);

		[PreserveSig]
		[Token(Token = "0x600035B")]
		[Address(RVA = "0xFC2BEC", Offset = "0xFC2BEC", VA = "0xFC2BEC")]
		private static extern RESULT FMOD5_System_CreateSound(IntPtr system, byte[] name_or_data, MODE mode, ref CREATESOUNDEXINFO exinfo, out IntPtr sound);

		[PreserveSig]
		[Token(Token = "0x600035C")]
		[Address(RVA = "0xFC2D24", Offset = "0xFC2D24", VA = "0xFC2D24")]
		private static extern RESULT FMOD5_System_CreateSound(IntPtr system, IntPtr name_or_data, MODE mode, ref CREATESOUNDEXINFO exinfo, out IntPtr sound);

		[PreserveSig]
		[Token(Token = "0x600035D")]
		[Address(RVA = "0xFC3098", Offset = "0xFC3098", VA = "0xFC3098")]
		private static extern RESULT FMOD5_System_CreateStream(IntPtr system, byte[] name_or_data, MODE mode, ref CREATESOUNDEXINFO exinfo, out IntPtr sound);

		[PreserveSig]
		[Token(Token = "0x600035E")]
		[Address(RVA = "0xFC31D0", Offset = "0xFC31D0", VA = "0xFC31D0")]
		private static extern RESULT FMOD5_System_CreateStream(IntPtr system, IntPtr name_or_data, MODE mode, ref CREATESOUNDEXINFO exinfo, out IntPtr sound);

		[PreserveSig]
		[Token(Token = "0x600035F")]
		[Address(RVA = "0xFC33DC", Offset = "0xFC33DC", VA = "0xFC33DC")]
		private static extern RESULT FMOD5_System_CreateDSP(IntPtr system, ref DSP_DESCRIPTION description, out IntPtr dsp);

		[PreserveSig]
		[Token(Token = "0x6000360")]
		[Address(RVA = "0xFC34E8", Offset = "0xFC34E8", VA = "0xFC34E8")]
		private static extern RESULT FMOD5_System_CreateDSPByType(IntPtr system, DSP_TYPE type, out IntPtr dsp);

		[PreserveSig]
		[Token(Token = "0x6000361")]
		[Address(RVA = "0xFC36D8", Offset = "0xFC36D8", VA = "0xFC36D8")]
		private static extern RESULT FMOD5_System_CreateChannelGroup(IntPtr system, byte[] name, out IntPtr channelgroup);

		[PreserveSig]
		[Token(Token = "0x6000362")]
		[Address(RVA = "0xFC38D0", Offset = "0xFC38D0", VA = "0xFC38D0")]
		private static extern RESULT FMOD5_System_CreateSoundGroup(IntPtr system, byte[] name, out IntPtr soundgroup);

		[PreserveSig]
		[Token(Token = "0x6000363")]
		[Address(RVA = "0xFC3978", Offset = "0xFC3978", VA = "0xFC3978")]
		private static extern RESULT FMOD5_System_CreateReverb3D(IntPtr system, out IntPtr reverb);

		[PreserveSig]
		[Token(Token = "0x6000364")]
		[Address(RVA = "0xFC3A14", Offset = "0xFC3A14", VA = "0xFC3A14")]
		private static extern RESULT FMOD5_System_PlaySound(IntPtr system, IntPtr sound, IntPtr channelgroup, bool paused, out IntPtr channel);

		[PreserveSig]
		[Token(Token = "0x6000365")]
		[Address(RVA = "0xFC3AD0", Offset = "0xFC3AD0", VA = "0xFC3AD0")]
		private static extern RESULT FMOD5_System_PlayDSP(IntPtr system, IntPtr dsp, IntPtr channelgroup, bool paused, out IntPtr channel);

		[PreserveSig]
		[Token(Token = "0x6000366")]
		[Address(RVA = "0xFC3B88", Offset = "0xFC3B88", VA = "0xFC3B88")]
		private static extern RESULT FMOD5_System_GetChannel(IntPtr system, int channelid, out IntPtr channel);

		[PreserveSig]
		[Token(Token = "0x6000367")]
		[Address(RVA = "0xFC3C28", Offset = "0xFC3C28", VA = "0xFC3C28")]
		private static extern RESULT FMOD5_System_GetMasterChannelGroup(IntPtr system, out IntPtr channelgroup);

		[PreserveSig]
		[Token(Token = "0x6000368")]
		[Address(RVA = "0xFC3CC0", Offset = "0xFC3CC0", VA = "0xFC3CC0")]
		private static extern RESULT FMOD5_System_GetMasterSoundGroup(IntPtr system, out IntPtr soundgroup);

		[PreserveSig]
		[Token(Token = "0x6000369")]
		[Address(RVA = "0xFC3D5C", Offset = "0xFC3D5C", VA = "0xFC3D5C")]
		private static extern RESULT FMOD5_System_AttachChannelGroupToPort(IntPtr system, uint portType, ulong portIndex, IntPtr channelgroup, bool passThru);

		[PreserveSig]
		[Token(Token = "0x600036A")]
		[Address(RVA = "0xFC3E14", Offset = "0xFC3E14", VA = "0xFC3E14")]
		private static extern RESULT FMOD5_System_DetachChannelGroupFromPort(IntPtr system, IntPtr channelgroup);

		[PreserveSig]
		[Token(Token = "0x600036B")]
		[Address(RVA = "0xFC3EAC", Offset = "0xFC3EAC", VA = "0xFC3EAC")]
		private static extern RESULT FMOD5_System_SetReverbProperties(IntPtr system, int instance, ref REVERB_PROPERTIES prop);

		[PreserveSig]
		[Token(Token = "0x600036C")]
		[Address(RVA = "0xFC3F4C", Offset = "0xFC3F4C", VA = "0xFC3F4C")]
		private static extern RESULT FMOD5_System_GetReverbProperties(IntPtr system, int instance, out REVERB_PROPERTIES prop);

		[PreserveSig]
		[Token(Token = "0x600036D")]
		[Address(RVA = "0xFC3FEC", Offset = "0xFC3FEC", VA = "0xFC3FEC")]
		private static extern RESULT FMOD5_System_LockDSP(IntPtr system);

		[PreserveSig]
		[Token(Token = "0x600036E")]
		[Address(RVA = "0xFC4074", Offset = "0xFC4074", VA = "0xFC4074")]
		private static extern RESULT FMOD5_System_UnlockDSP(IntPtr system);

		[PreserveSig]
		[Token(Token = "0x600036F")]
		[Address(RVA = "0xFC40FC", Offset = "0xFC40FC", VA = "0xFC40FC")]
		private static extern RESULT FMOD5_System_GetRecordNumDrivers(IntPtr system, out int numdrivers, out int numconnected);

		[PreserveSig]
		[Token(Token = "0x6000370")]
		[Address(RVA = "0xFC439C", Offset = "0xFC439C", VA = "0xFC439C")]
		private static extern RESULT FMOD5_System_GetRecordDriverInfo(IntPtr system, int id, IntPtr name, int namelen, out Guid guid, out int systemrate, out SPEAKERMODE speakermode, out int speakermodechannels, out DRIVER_STATE state);

		[PreserveSig]
		[Token(Token = "0x6000371")]
		[Address(RVA = "0xFC4524", Offset = "0xFC4524", VA = "0xFC4524")]
		private static extern RESULT FMOD5_System_GetRecordPosition(IntPtr system, int id, out uint position);

		[PreserveSig]
		[Token(Token = "0x6000372")]
		[Address(RVA = "0xFC45C8", Offset = "0xFC45C8", VA = "0xFC45C8")]
		private static extern RESULT FMOD5_System_RecordStart(IntPtr system, int id, IntPtr sound, bool loop);

		[PreserveSig]
		[Token(Token = "0x6000373")]
		[Address(RVA = "0xFC4674", Offset = "0xFC4674", VA = "0xFC4674")]
		private static extern RESULT FMOD5_System_RecordStop(IntPtr system, int id);

		[PreserveSig]
		[Token(Token = "0x6000374")]
		[Address(RVA = "0xFC470C", Offset = "0xFC470C", VA = "0xFC470C")]
		private static extern RESULT FMOD5_System_IsRecording(IntPtr system, int id, out bool recording);

		[PreserveSig]
		[Token(Token = "0x6000375")]
		[Address(RVA = "0xFC47C0", Offset = "0xFC47C0", VA = "0xFC47C0")]
		private static extern RESULT FMOD5_System_CreateGeometry(IntPtr system, int maxpolygons, int maxvertices, out IntPtr geometry);

		[PreserveSig]
		[Token(Token = "0x6000376")]
		[Address(RVA = "0xFC4870", Offset = "0xFC4870", VA = "0xFC4870")]
		private static extern RESULT FMOD5_System_SetGeometrySettings(IntPtr system, float maxworldsize);

		[PreserveSig]
		[Token(Token = "0x6000377")]
		[Address(RVA = "0xFC4908", Offset = "0xFC4908", VA = "0xFC4908")]
		private static extern RESULT FMOD5_System_GetGeometrySettings(IntPtr system, out float maxworldsize);

		[PreserveSig]
		[Token(Token = "0x6000378")]
		[Address(RVA = "0xFC49A0", Offset = "0xFC49A0", VA = "0xFC49A0")]
		private static extern RESULT FMOD5_System_LoadGeometry(IntPtr system, IntPtr data, int datasize, out IntPtr geometry);

		[PreserveSig]
		[Token(Token = "0x6000379")]
		[Address(RVA = "0xFC4A50", Offset = "0xFC4A50", VA = "0xFC4A50")]
		private static extern RESULT FMOD5_System_GetGeometryOcclusion(IntPtr system, ref VECTOR listener, ref VECTOR source, out float direct, out float reverb);

		[PreserveSig]
		[Token(Token = "0x600037A")]
		[Address(RVA = "0xFC4C50", Offset = "0xFC4C50", VA = "0xFC4C50")]
		private static extern RESULT FMOD5_System_SetNetworkProxy(IntPtr system, byte[] proxy);

		[PreserveSig]
		[Token(Token = "0x600037B")]
		[Address(RVA = "0xFC4EA8", Offset = "0xFC4EA8", VA = "0xFC4EA8")]
		private static extern RESULT FMOD5_System_GetNetworkProxy(IntPtr system, IntPtr proxy, int proxylen);

		[PreserveSig]
		[Token(Token = "0x600037C")]
		[Address(RVA = "0xFC4F48", Offset = "0xFC4F48", VA = "0xFC4F48")]
		private static extern RESULT FMOD5_System_SetNetworkTimeout(IntPtr system, int timeout);

		[PreserveSig]
		[Token(Token = "0x600037D")]
		[Address(RVA = "0xFC4FE0", Offset = "0xFC4FE0", VA = "0xFC4FE0")]
		private static extern RESULT FMOD5_System_GetNetworkTimeout(IntPtr system, out int timeout);

		[PreserveSig]
		[Token(Token = "0x600037E")]
		[Address(RVA = "0xFC5078", Offset = "0xFC5078", VA = "0xFC5078")]
		private static extern RESULT FMOD5_System_SetUserData(IntPtr system, IntPtr userdata);

		[PreserveSig]
		[Token(Token = "0x600037F")]
		[Address(RVA = "0xFC5110", Offset = "0xFC5110", VA = "0xFC5110")]
		private static extern RESULT FMOD5_System_GetUserData(IntPtr system, out IntPtr userdata);

		[Token(Token = "0x6000380")]
		[Address(RVA = "0xFC51A0", Offset = "0xFC51A0", VA = "0xFC51A0")]
		public bool hasHandle()
		{
			return default(bool);
		}

		[Token(Token = "0x6000381")]
		[Address(RVA = "0xFC51EC", Offset = "0xFC51EC", VA = "0xFC51EC")]
		public void clearHandle()
		{
		}
	}
	[Token(Token = "0x200006D")]
	public struct Sound
	{
		[Token(Token = "0x40002C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public IntPtr handle;

		[Token(Token = "0x6000382")]
		[Address(RVA = "0x1584920", Offset = "0x1584920", VA = "0x1584920")]
		public RESULT release()
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000383")]
		[Address(RVA = "0x15849A8", Offset = "0x15849A8", VA = "0x15849A8")]
		public RESULT getSystemObject(out System system)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000384")]
		[Address(RVA = "0x1584A40", Offset = "0x1584A40", VA = "0x1584A40")]
		public RESULT @lock(uint offset, uint length, out IntPtr ptr1, out IntPtr ptr2, out uint len1, out uint len2)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000385")]
		[Address(RVA = "0x1584B10", Offset = "0x1584B10", VA = "0x1584B10")]
		public RESULT unlock(IntPtr ptr1, IntPtr ptr2, uint len1, uint len2)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000386")]
		[Address(RVA = "0x1584BC8", Offset = "0x1584BC8", VA = "0x1584BC8")]
		public RESULT setDefaults(float frequency, int priority)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000387")]
		[Address(RVA = "0x1584C70", Offset = "0x1584C70", VA = "0x1584C70")]
		public RESULT getDefaults(out float frequency, out int priority)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000388")]
		[Address(RVA = "0x1584D10", Offset = "0x1584D10", VA = "0x1584D10")]
		public RESULT set3DMinMaxDistance(float min, float max)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000389")]
		[Address(RVA = "0x1584DB0", Offset = "0x1584DB0", VA = "0x1584DB0")]
		public RESULT get3DMinMaxDistance(out float min, out float max)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600038A")]
		[Address(RVA = "0x1584E50", Offset = "0x1584E50", VA = "0x1584E50")]
		public RESULT set3DConeSettings(float insideconeangle, float outsideconeangle, float outsidevolume)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600038B")]
		[Address(RVA = "0x1584F00", Offset = "0x1584F00", VA = "0x1584F00")]
		public RESULT get3DConeSettings(out float insideconeangle, out float outsideconeangle, out float outsidevolume)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600038C")]
		[Address(RVA = "0x1584FB0", Offset = "0x1584FB0", VA = "0x1584FB0")]
		public RESULT set3DCustomRolloff(ref VECTOR points, int numpoints)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600038D")]
		[Address(RVA = "0x1585050", Offset = "0x1585050", VA = "0x1585050")]
		public RESULT get3DCustomRolloff(out IntPtr points, out int numpoints)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600038E")]
		[Address(RVA = "0x15850F0", Offset = "0x15850F0", VA = "0x15850F0")]
		public RESULT getSubSound(int index, out Sound subsound)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600038F")]
		[Address(RVA = "0x1585190", Offset = "0x1585190", VA = "0x1585190")]
		public RESULT getSubSoundParent(out Sound parentsound)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000390")]
		[Address(RVA = "0x1585228", Offset = "0x1585228", VA = "0x1585228")]
		public RESULT getName(out string name, int namelen)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000391")]
		[Address(RVA = "0x15856A8", Offset = "0x15856A8", VA = "0x15856A8")]
		public RESULT getLength(out uint length, TIMEUNIT lengthtype)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000392")]
		[Address(RVA = "0x1585748", Offset = "0x1585748", VA = "0x1585748")]
		public RESULT getFormat(out SOUND_TYPE type, out SOUND_FORMAT format, out int channels, out int bits)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000393")]
		[Address(RVA = "0x1585800", Offset = "0x1585800", VA = "0x1585800")]
		public RESULT getNumSubSounds(out int numsubsounds)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000394")]
		[Address(RVA = "0x1585898", Offset = "0x1585898", VA = "0x1585898")]
		public RESULT getNumTags(out int numtags, out int numtagsupdated)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000395")]
		[Address(RVA = "0x1585938", Offset = "0x1585938", VA = "0x1585938")]
		public RESULT getTag(string name, int index, out TAG tag)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000396")]
		[Address(RVA = "0x1585B7C", Offset = "0x1585B7C", VA = "0x1585B7C")]
		public RESULT getOpenState(out OPENSTATE openstate, out uint percentbuffered, out bool starving, out bool diskbusy)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000397")]
		[Address(RVA = "0x1585C58", Offset = "0x1585C58", VA = "0x1585C58")]
		public RESULT readData(IntPtr buffer, uint length, out uint read)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000398")]
		[Address(RVA = "0x1585D08", Offset = "0x1585D08", VA = "0x1585D08")]
		public RESULT seekData(uint pcm)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000399")]
		[Address(RVA = "0x1585DA0", Offset = "0x1585DA0", VA = "0x1585DA0")]
		public RESULT setSoundGroup(SoundGroup soundgroup)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600039A")]
		[Address(RVA = "0x1585E38", Offset = "0x1585E38", VA = "0x1585E38")]
		public RESULT getSoundGroup(out SoundGroup soundgroup)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600039B")]
		[Address(RVA = "0x1585ED0", Offset = "0x1585ED0", VA = "0x1585ED0")]
		public RESULT getNumSyncPoints(out int numsyncpoints)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600039C")]
		[Address(RVA = "0x1585F68", Offset = "0x1585F68", VA = "0x1585F68")]
		public RESULT getSyncPoint(int index, out IntPtr point)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600039D")]
		[Address(RVA = "0x1586008", Offset = "0x1586008", VA = "0x1586008")]
		public RESULT getSyncPointInfo(IntPtr point, out string name, int namelen, out uint offset, TIMEUNIT offsettype)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600039E")]
		[Address(RVA = "0x15862A0", Offset = "0x15862A0", VA = "0x15862A0")]
		public RESULT getSyncPointInfo(IntPtr point, out uint offset, TIMEUNIT offsettype)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600039F")]
		[Address(RVA = "0x1586314", Offset = "0x1586314", VA = "0x1586314")]
		public RESULT addSyncPoint(uint offset, TIMEUNIT offsettype, string name, out IntPtr point)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60003A0")]
		[Address(RVA = "0x1586534", Offset = "0x1586534", VA = "0x1586534")]
		public RESULT deleteSyncPoint(IntPtr point)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60003A1")]
		[Address(RVA = "0x15865CC", Offset = "0x15865CC", VA = "0x15865CC")]
		public RESULT setMode(MODE mode)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60003A2")]
		[Address(RVA = "0x1586664", Offset = "0x1586664", VA = "0x1586664")]
		public RESULT getMode(out MODE mode)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60003A3")]
		[Address(RVA = "0x15866FC", Offset = "0x15866FC", VA = "0x15866FC")]
		public RESULT setLoopCount(int loopcount)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60003A4")]
		[Address(RVA = "0x1586794", Offset = "0x1586794", VA = "0x1586794")]
		public RESULT getLoopCount(out int loopcount)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60003A5")]
		[Address(RVA = "0x158682C", Offset = "0x158682C", VA = "0x158682C")]
		public RESULT setLoopPoints(uint loopstart, TIMEUNIT loopstarttype, uint loopend, TIMEUNIT loopendtype)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60003A6")]
		[Address(RVA = "0x15868E4", Offset = "0x15868E4", VA = "0x15868E4")]
		public RESULT getLoopPoints(out uint loopstart, TIMEUNIT loopstarttype, out uint loopend, TIMEUNIT loopendtype)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60003A7")]
		[Address(RVA = "0x158699C", Offset = "0x158699C", VA = "0x158699C")]
		public RESULT getMusicNumChannels(out int numchannels)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60003A8")]
		[Address(RVA = "0x1586A34", Offset = "0x1586A34", VA = "0x1586A34")]
		public RESULT setMusicChannelVolume(int channel, float volume)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60003A9")]
		[Address(RVA = "0x1586ADC", Offset = "0x1586ADC", VA = "0x1586ADC")]
		public RESULT getMusicChannelVolume(int channel, out float volume)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60003AA")]
		[Address(RVA = "0x1586B7C", Offset = "0x1586B7C", VA = "0x1586B7C")]
		public RESULT setMusicSpeed(float speed)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60003AB")]
		[Address(RVA = "0x1586C14", Offset = "0x1586C14", VA = "0x1586C14")]
		public RESULT getMusicSpeed(out float speed)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60003AC")]
		[Address(RVA = "0x1586CAC", Offset = "0x1586CAC", VA = "0x1586CAC")]
		public RESULT setUserData(IntPtr userdata)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60003AD")]
		[Address(RVA = "0x1586D44", Offset = "0x1586D44", VA = "0x1586D44")]
		public RESULT getUserData(out IntPtr userdata)
		{
			return default(RESULT);
		}

		[PreserveSig]
		[Token(Token = "0x60003AE")]
		[Address(RVA = "0x1584928", Offset = "0x1584928", VA = "0x1584928")]
		private static extern RESULT FMOD5_Sound_Release(IntPtr sound);

		[PreserveSig]
		[Token(Token = "0x60003AF")]
		[Address(RVA = "0x15849B0", Offset = "0x15849B0", VA = "0x15849B0")]
		private static extern RESULT FMOD5_Sound_GetSystemObject(IntPtr sound, out IntPtr system);

		[PreserveSig]
		[Token(Token = "0x60003B0")]
		[Address(RVA = "0x1584A48", Offset = "0x1584A48", VA = "0x1584A48")]
		private static extern RESULT FMOD5_Sound_Lock(IntPtr sound, uint offset, uint length, out IntPtr ptr1, out IntPtr ptr2, out uint len1, out uint len2);

		[PreserveSig]
		[Token(Token = "0x60003B1")]
		[Address(RVA = "0x1584B18", Offset = "0x1584B18", VA = "0x1584B18")]
		private static extern RESULT FMOD5_Sound_Unlock(IntPtr sound, IntPtr ptr1, IntPtr ptr2, uint len1, uint len2);

		[PreserveSig]
		[Token(Token = "0x60003B2")]
		[Address(RVA = "0x1584BD0", Offset = "0x1584BD0", VA = "0x1584BD0")]
		private static extern RESULT FMOD5_Sound_SetDefaults(IntPtr sound, float frequency, int priority);

		[PreserveSig]
		[Token(Token = "0x60003B3")]
		[Address(RVA = "0x1584C78", Offset = "0x1584C78", VA = "0x1584C78")]
		private static extern RESULT FMOD5_Sound_GetDefaults(IntPtr sound, out float frequency, out int priority);

		[PreserveSig]
		[Token(Token = "0x60003B4")]
		[Address(RVA = "0x1584D18", Offset = "0x1584D18", VA = "0x1584D18")]
		private static extern RESULT FMOD5_Sound_Set3DMinMaxDistance(IntPtr sound, float min, float max);

		[PreserveSig]
		[Token(Token = "0x60003B5")]
		[Address(RVA = "0x1584DB8", Offset = "0x1584DB8", VA = "0x1584DB8")]
		private static extern RESULT FMOD5_Sound_Get3DMinMaxDistance(IntPtr sound, out float min, out float max);

		[PreserveSig]
		[Token(Token = "0x60003B6")]
		[Address(RVA = "0x1584E58", Offset = "0x1584E58", VA = "0x1584E58")]
		private static extern RESULT FMOD5_Sound_Set3DConeSettings(IntPtr sound, float insideconeangle, float outsideconeangle, float outsidevolume);

		[PreserveSig]
		[Token(Token = "0x60003B7")]
		[Address(RVA = "0x1584F08", Offset = "0x1584F08", VA = "0x1584F08")]
		private static extern RESULT FMOD5_Sound_Get3DConeSettings(IntPtr sound, out float insideconeangle, out float outsideconeangle, out float outsidevolume);

		[PreserveSig]
		[Token(Token = "0x60003B8")]
		[Address(RVA = "0x1584FB8", Offset = "0x1584FB8", VA = "0x1584FB8")]
		private static extern RESULT FMOD5_Sound_Set3DCustomRolloff(IntPtr sound, ref VECTOR points, int numpoints);

		[PreserveSig]
		[Token(Token = "0x60003B9")]
		[Address(RVA = "0x1585058", Offset = "0x1585058", VA = "0x1585058")]
		private static extern RESULT FMOD5_Sound_Get3DCustomRolloff(IntPtr sound, out IntPtr points, out int numpoints);

		[PreserveSig]
		[Token(Token = "0x60003BA")]
		[Address(RVA = "0x15850F8", Offset = "0x15850F8", VA = "0x15850F8")]
		private static extern RESULT FMOD5_Sound_GetSubSound(IntPtr sound, int index, out IntPtr subsound);

		[PreserveSig]
		[Token(Token = "0x60003BB")]
		[Address(RVA = "0x1585198", Offset = "0x1585198", VA = "0x1585198")]
		private static extern RESULT FMOD5_Sound_GetSubSoundParent(IntPtr sound, out IntPtr parentsound);

		[PreserveSig]
		[Token(Token = "0x60003BC")]
		[Address(RVA = "0x15853E0", Offset = "0x15853E0", VA = "0x15853E0")]
		private static extern RESULT FMOD5_Sound_GetName(IntPtr sound, IntPtr name, int namelen);

		[PreserveSig]
		[Token(Token = "0x60003BD")]
		[Address(RVA = "0x15856B0", Offset = "0x15856B0", VA = "0x15856B0")]
		private static extern RESULT FMOD5_Sound_GetLength(IntPtr sound, out uint length, TIMEUNIT lengthtype);

		[PreserveSig]
		[Token(Token = "0x60003BE")]
		[Address(RVA = "0x1585750", Offset = "0x1585750", VA = "0x1585750")]
		private static extern RESULT FMOD5_Sound_GetFormat(IntPtr sound, out SOUND_TYPE type, out SOUND_FORMAT format, out int channels, out int bits);

		[PreserveSig]
		[Token(Token = "0x60003BF")]
		[Address(RVA = "0x1585808", Offset = "0x1585808", VA = "0x1585808")]
		private static extern RESULT FMOD5_Sound_GetNumSubSounds(IntPtr sound, out int numsubsounds);

		[PreserveSig]
		[Token(Token = "0x60003C0")]
		[Address(RVA = "0x15858A0", Offset = "0x15858A0", VA = "0x15858A0")]
		private static extern RESULT FMOD5_Sound_GetNumTags(IntPtr sound, out int numtags, out int numtagsupdated);

		[PreserveSig]
		[Token(Token = "0x60003C1")]
		[Address(RVA = "0x1585A98", Offset = "0x1585A98", VA = "0x1585A98")]
		private static extern RESULT FMOD5_Sound_GetTag(IntPtr sound, byte[] name, int index, out TAG tag);

		[PreserveSig]
		[Token(Token = "0x60003C2")]
		[Address(RVA = "0x1585B84", Offset = "0x1585B84", VA = "0x1585B84")]
		private static extern RESULT FMOD5_Sound_GetOpenState(IntPtr sound, out OPENSTATE openstate, out uint percentbuffered, out bool starving, out bool diskbusy);

		[PreserveSig]
		[Token(Token = "0x60003C3")]
		[Address(RVA = "0x1585C60", Offset = "0x1585C60", VA = "0x1585C60")]
		private static extern RESULT FMOD5_Sound_ReadData(IntPtr sound, IntPtr buffer, uint length, out uint read);

		[PreserveSig]
		[Token(Token = "0x60003C4")]
		[Address(RVA = "0x1585D10", Offset = "0x1585D10", VA = "0x1585D10")]
		private static extern RESULT FMOD5_Sound_SeekData(IntPtr sound, uint pcm);

		[PreserveSig]
		[Token(Token = "0x60003C5")]
		[Address(RVA = "0x1585DA8", Offset = "0x1585DA8", VA = "0x1585DA8")]
		private static extern RESULT FMOD5_Sound_SetSoundGroup(IntPtr sound, IntPtr soundgroup);

		[PreserveSig]
		[Token(Token = "0x60003C6")]
		[Address(RVA = "0x1585E40", Offset = "0x1585E40", VA = "0x1585E40")]
		private static extern RESULT FMOD5_Sound_GetSoundGroup(IntPtr sound, out IntPtr soundgroup);

		[PreserveSig]
		[Token(Token = "0x60003C7")]
		[Address(RVA = "0x1585ED8", Offset = "0x1585ED8", VA = "0x1585ED8")]
		private static extern RESULT FMOD5_Sound_GetNumSyncPoints(IntPtr sound, out int numsyncpoints);

		[PreserveSig]
		[Token(Token = "0x60003C8")]
		[Address(RVA = "0x1585F70", Offset = "0x1585F70", VA = "0x1585F70")]
		private static extern RESULT FMOD5_Sound_GetSyncPoint(IntPtr sound, int index, out IntPtr point);

		[PreserveSig]
		[Token(Token = "0x60003C9")]
		[Address(RVA = "0x15861E0", Offset = "0x15861E0", VA = "0x15861E0")]
		private static extern RESULT FMOD5_Sound_GetSyncPointInfo(IntPtr sound, IntPtr point, IntPtr name, int namelen, out uint offset, TIMEUNIT offsettype);

		[PreserveSig]
		[Token(Token = "0x60003CA")]
		[Address(RVA = "0x158647C", Offset = "0x158647C", VA = "0x158647C")]
		private static extern RESULT FMOD5_Sound_AddSyncPoint(IntPtr sound, uint offset, TIMEUNIT offsettype, byte[] name, out IntPtr point);

		[PreserveSig]
		[Token(Token = "0x60003CB")]
		[Address(RVA = "0x158653C", Offset = "0x158653C", VA = "0x158653C")]
		private static extern RESULT FMOD5_Sound_DeleteSyncPoint(IntPtr sound, IntPtr point);

		[PreserveSig]
		[Token(Token = "0x60003CC")]
		[Address(RVA = "0x15865D4", Offset = "0x15865D4", VA = "0x15865D4")]
		private static extern RESULT FMOD5_Sound_SetMode(IntPtr sound, MODE mode);

		[PreserveSig]
		[Token(Token = "0x60003CD")]
		[Address(RVA = "0x158666C", Offset = "0x158666C", VA = "0x158666C")]
		private static extern RESULT FMOD5_Sound_GetMode(IntPtr sound, out MODE mode);

		[PreserveSig]
		[Token(Token = "0x60003CE")]
		[Address(RVA = "0x1586704", Offset = "0x1586704", VA = "0x1586704")]
		private static extern RESULT FMOD5_Sound_SetLoopCount(IntPtr sound, int loopcount);

		[PreserveSig]
		[Token(Token = "0x60003CF")]
		[Address(RVA = "0x158679C", Offset = "0x158679C", VA = "0x158679C")]
		private static extern RESULT FMOD5_Sound_GetLoopCount(IntPtr sound, out int loopcount);

		[PreserveSig]
		[Token(Token = "0x60003D0")]
		[Address(RVA = "0x1586834", Offset = "0x1586834", VA = "0x1586834")]
		private static extern RESULT FMOD5_Sound_SetLoopPoints(IntPtr sound, uint loopstart, TIMEUNIT loopstarttype, uint loopend, TIMEUNIT loopendtype);

		[PreserveSig]
		[Token(Token = "0x60003D1")]
		[Address(RVA = "0x15868EC", Offset = "0x15868EC", VA = "0x15868EC")]
		private static extern RESULT FMOD5_Sound_GetLoopPoints(IntPtr sound, out uint loopstart, TIMEUNIT loopstarttype, out uint loopend, TIMEUNIT loopendtype);

		[PreserveSig]
		[Token(Token = "0x60003D2")]
		[Address(RVA = "0x15869A4", Offset = "0x15869A4", VA = "0x15869A4")]
		private static extern RESULT FMOD5_Sound_GetMusicNumChannels(IntPtr sound, out int numchannels);

		[PreserveSig]
		[Token(Token = "0x60003D3")]
		[Address(RVA = "0x1586A3C", Offset = "0x1586A3C", VA = "0x1586A3C")]
		private static extern RESULT FMOD5_Sound_SetMusicChannelVolume(IntPtr sound, int channel, float volume);

		[PreserveSig]
		[Token(Token = "0x60003D4")]
		[Address(RVA = "0x1586AE4", Offset = "0x1586AE4", VA = "0x1586AE4")]
		private static extern RESULT FMOD5_Sound_GetMusicChannelVolume(IntPtr sound, int channel, out float volume);

		[PreserveSig]
		[Token(Token = "0x60003D5")]
		[Address(RVA = "0x1586B84", Offset = "0x1586B84", VA = "0x1586B84")]
		private static extern RESULT FMOD5_Sound_SetMusicSpeed(IntPtr sound, float speed);

		[PreserveSig]
		[Token(Token = "0x60003D6")]
		[Address(RVA = "0x1586C1C", Offset = "0x1586C1C", VA = "0x1586C1C")]
		private static extern RESULT FMOD5_Sound_GetMusicSpeed(IntPtr sound, out float speed);

		[PreserveSig]
		[Token(Token = "0x60003D7")]
		[Address(RVA = "0x1586CB4", Offset = "0x1586CB4", VA = "0x1586CB4")]
		private static extern RESULT FMOD5_Sound_SetUserData(IntPtr sound, IntPtr userdata);

		[PreserveSig]
		[Token(Token = "0x60003D8")]
		[Address(RVA = "0x1586D4C", Offset = "0x1586D4C", VA = "0x1586D4C")]
		private static extern RESULT FMOD5_Sound_GetUserData(IntPtr sound, out IntPtr userdata);

		[Token(Token = "0x60003D9")]
		[Address(RVA = "0x1586DDC", Offset = "0x1586DDC", VA = "0x1586DDC")]
		public bool hasHandle()
		{
			return default(bool);
		}

		[Token(Token = "0x60003DA")]
		[Address(RVA = "0x1586E28", Offset = "0x1586E28", VA = "0x1586E28")]
		public void clearHandle()
		{
		}
	}
	[Token(Token = "0x200006E")]
	internal interface IChannelControl
	{
		[Token(Token = "0x60003DB")]
		RESULT getSystemObject(out System system);

		[Token(Token = "0x60003DC")]
		RESULT stop();

		[Token(Token = "0x60003DD")]
		RESULT setPaused(bool paused);

		[Token(Token = "0x60003DE")]
		RESULT getPaused(out bool paused);

		[Token(Token = "0x60003DF")]
		RESULT setVolume(float volume);

		[Token(Token = "0x60003E0")]
		RESULT getVolume(out float volume);

		[Token(Token = "0x60003E1")]
		RESULT setVolumeRamp(bool ramp);

		[Token(Token = "0x60003E2")]
		RESULT getVolumeRamp(out bool ramp);

		[Token(Token = "0x60003E3")]
		RESULT getAudibility(out float audibility);

		[Token(Token = "0x60003E4")]
		RESULT setPitch(float pitch);

		[Token(Token = "0x60003E5")]
		RESULT getPitch(out float pitch);

		[Token(Token = "0x60003E6")]
		RESULT setMute(bool mute);

		[Token(Token = "0x60003E7")]
		RESULT getMute(out bool mute);

		[Token(Token = "0x60003E8")]
		RESULT setReverbProperties(int instance, float wet);

		[Token(Token = "0x60003E9")]
		RESULT getReverbProperties(int instance, out float wet);

		[Token(Token = "0x60003EA")]
		RESULT setLowPassGain(float gain);

		[Token(Token = "0x60003EB")]
		RESULT getLowPassGain(out float gain);

		[Token(Token = "0x60003EC")]
		RESULT setMode(MODE mode);

		[Token(Token = "0x60003ED")]
		RESULT getMode(out MODE mode);

		[Token(Token = "0x60003EE")]
		RESULT setCallback(CHANNELCONTROL_CALLBACK callback);

		[Token(Token = "0x60003EF")]
		RESULT isPlaying(out bool isplaying);

		[Token(Token = "0x60003F0")]
		RESULT setPan(float pan);

		[Token(Token = "0x60003F1")]
		RESULT setMixLevelsOutput(float frontleft, float frontright, float center, float lfe, float surroundleft, float surroundright, float backleft, float backright);

		[Token(Token = "0x60003F2")]
		RESULT setMixLevelsInput(float[] levels, int numlevels);

		[Token(Token = "0x60003F3")]
		RESULT setMixMatrix(float[] matrix, int outchannels, int inchannels, int inchannel_hop);

		[Token(Token = "0x60003F4")]
		RESULT getMixMatrix(float[] matrix, out int outchannels, out int inchannels, int inchannel_hop);

		[Token(Token = "0x60003F5")]
		RESULT getDSPClock(out ulong dspclock, out ulong parentclock);

		[Token(Token = "0x60003F6")]
		RESULT setDelay(ulong dspclock_start, ulong dspclock_end, bool stopchannels);

		[Token(Token = "0x60003F7")]
		RESULT getDelay(out ulong dspclock_start, out ulong dspclock_end);

		[Token(Token = "0x60003F8")]
		RESULT getDelay(out ulong dspclock_start, out ulong dspclock_end, out bool stopchannels);

		[Token(Token = "0x60003F9")]
		RESULT addFadePoint(ulong dspclock, float volume);

		[Token(Token = "0x60003FA")]
		RESULT setFadePointRamp(ulong dspclock, float volume);

		[Token(Token = "0x60003FB")]
		RESULT removeFadePoints(ulong dspclock_start, ulong dspclock_end);

		[Token(Token = "0x60003FC")]
		RESULT getFadePoints(ref uint numpoints, ulong[] point_dspclock, float[] point_volume);

		[Token(Token = "0x60003FD")]
		RESULT getDSP(int index, out DSP dsp);

		[Token(Token = "0x60003FE")]
		RESULT addDSP(int index, DSP dsp);

		[Token(Token = "0x60003FF")]
		RESULT removeDSP(DSP dsp);

		[Token(Token = "0x6000400")]
		RESULT getNumDSPs(out int numdsps);

		[Token(Token = "0x6000401")]
		RESULT setDSPIndex(DSP dsp, int index);

		[Token(Token = "0x6000402")]
		RESULT getDSPIndex(DSP dsp, out int index);

		[Token(Token = "0x6000403")]
		RESULT set3DAttributes(ref VECTOR pos, ref VECTOR vel);

		[Token(Token = "0x6000404")]
		RESULT get3DAttributes(out VECTOR pos, out VECTOR vel);

		[Token(Token = "0x6000405")]
		RESULT set3DMinMaxDistance(float mindistance, float maxdistance);

		[Token(Token = "0x6000406")]
		RESULT get3DMinMaxDistance(out float mindistance, out float maxdistance);

		[Token(Token = "0x6000407")]
		RESULT set3DConeSettings(float insideconeangle, float outsideconeangle, float outsidevolume);

		[Token(Token = "0x6000408")]
		RESULT get3DConeSettings(out float insideconeangle, out float outsideconeangle, out float outsidevolume);

		[Token(Token = "0x6000409")]
		RESULT set3DConeOrientation(ref VECTOR orientation);

		[Token(Token = "0x600040A")]
		RESULT get3DConeOrientation(out VECTOR orientation);

		[Token(Token = "0x600040B")]
		RESULT set3DCustomRolloff(ref VECTOR points, int numpoints);

		[Token(Token = "0x600040C")]
		RESULT get3DCustomRolloff(out IntPtr points, out int numpoints);

		[Token(Token = "0x600040D")]
		RESULT set3DOcclusion(float directocclusion, float reverbocclusion);

		[Token(Token = "0x600040E")]
		RESULT get3DOcclusion(out float directocclusion, out float reverbocclusion);

		[Token(Token = "0x600040F")]
		RESULT set3DSpread(float angle);

		[Token(Token = "0x6000410")]
		RESULT get3DSpread(out float angle);

		[Token(Token = "0x6000411")]
		RESULT set3DLevel(float level);

		[Token(Token = "0x6000412")]
		RESULT get3DLevel(out float level);

		[Token(Token = "0x6000413")]
		RESULT set3DDopplerLevel(float level);

		[Token(Token = "0x6000414")]
		RESULT get3DDopplerLevel(out float level);

		[Token(Token = "0x6000415")]
		RESULT set3DDistanceFilter(bool custom, float customLevel, float centerFreq);

		[Token(Token = "0x6000416")]
		RESULT get3DDistanceFilter(out bool custom, out float customLevel, out float centerFreq);

		[Token(Token = "0x6000417")]
		RESULT setUserData(IntPtr userdata);

		[Token(Token = "0x6000418")]
		RESULT getUserData(out IntPtr userdata);
	}
	[Token(Token = "0x200006F")]
	public struct Channel : IChannelControl
	{
		[Token(Token = "0x40002C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public IntPtr handle;

		[Token(Token = "0x6000419")]
		[Address(RVA = "0x156D6C4", Offset = "0x156D6C4", VA = "0x156D6C4")]
		public RESULT setFrequency(float frequency)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600041A")]
		[Address(RVA = "0x156D75C", Offset = "0x156D75C", VA = "0x156D75C")]
		public RESULT getFrequency(out float frequency)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600041B")]
		[Address(RVA = "0x156D7F4", Offset = "0x156D7F4", VA = "0x156D7F4")]
		public RESULT setPriority(int priority)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600041C")]
		[Address(RVA = "0x156D88C", Offset = "0x156D88C", VA = "0x156D88C")]
		public RESULT getPriority(out int priority)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600041D")]
		[Address(RVA = "0x156D924", Offset = "0x156D924", VA = "0x156D924")]
		public RESULT setPosition(uint position, TIMEUNIT postype)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600041E")]
		[Address(RVA = "0x156D9C4", Offset = "0x156D9C4", VA = "0x156D9C4")]
		public RESULT getPosition(out uint position, TIMEUNIT postype)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600041F")]
		[Address(RVA = "0x156DA64", Offset = "0x156DA64", VA = "0x156DA64")]
		public RESULT setChannelGroup(ChannelGroup channelgroup)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000420")]
		[Address(RVA = "0x156DAFC", Offset = "0x156DAFC", VA = "0x156DAFC")]
		public RESULT getChannelGroup(out ChannelGroup channelgroup)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000421")]
		[Address(RVA = "0x156DB94", Offset = "0x156DB94", VA = "0x156DB94")]
		public RESULT setLoopCount(int loopcount)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000422")]
		[Address(RVA = "0x156DC2C", Offset = "0x156DC2C", VA = "0x156DC2C")]
		public RESULT getLoopCount(out int loopcount)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000423")]
		[Address(RVA = "0x156DCC4", Offset = "0x156DCC4", VA = "0x156DCC4")]
		public RESULT setLoopPoints(uint loopstart, TIMEUNIT loopstarttype, uint loopend, TIMEUNIT loopendtype)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000424")]
		[Address(RVA = "0x156DD7C", Offset = "0x156DD7C", VA = "0x156DD7C")]
		public RESULT getLoopPoints(out uint loopstart, TIMEUNIT loopstarttype, out uint loopend, TIMEUNIT loopendtype)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000425")]
		[Address(RVA = "0x156DE34", Offset = "0x156DE34", VA = "0x156DE34")]
		public RESULT isVirtual(out bool isvirtual)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000426")]
		[Address(RVA = "0x156DEE0", Offset = "0x156DEE0", VA = "0x156DEE0")]
		public RESULT getCurrentSound(out Sound sound)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000427")]
		[Address(RVA = "0x156DF78", Offset = "0x156DF78", VA = "0x156DF78")]
		public RESULT getIndex(out int index)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000428")]
		[Address(RVA = "0x156E010", Offset = "0x156E010", VA = "0x156E010", Slot = "4")]
		public RESULT getSystemObject(out System system)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000429")]
		[Address(RVA = "0x156E0A8", Offset = "0x156E0A8", VA = "0x156E0A8", Slot = "5")]
		public RESULT stop()
		{
			return default(RESULT);
		}

		[Token(Token = "0x600042A")]
		[Address(RVA = "0x156E130", Offset = "0x156E130", VA = "0x156E130", Slot = "6")]
		public RESULT setPaused(bool paused)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600042B")]
		[Address(RVA = "0x156E1CC", Offset = "0x156E1CC", VA = "0x156E1CC", Slot = "7")]
		public RESULT getPaused(out bool paused)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600042C")]
		[Address(RVA = "0x156E278", Offset = "0x156E278", VA = "0x156E278", Slot = "8")]
		public RESULT setVolume(float volume)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600042D")]
		[Address(RVA = "0x156E310", Offset = "0x156E310", VA = "0x156E310", Slot = "9")]
		public RESULT getVolume(out float volume)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600042E")]
		[Address(RVA = "0x156E3A8", Offset = "0x156E3A8", VA = "0x156E3A8", Slot = "10")]
		public RESULT setVolumeRamp(bool ramp)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600042F")]
		[Address(RVA = "0x156E444", Offset = "0x156E444", VA = "0x156E444", Slot = "11")]
		public RESULT getVolumeRamp(out bool ramp)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000430")]
		[Address(RVA = "0x156E4F0", Offset = "0x156E4F0", VA = "0x156E4F0", Slot = "12")]
		public RESULT getAudibility(out float audibility)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000431")]
		[Address(RVA = "0x156E588", Offset = "0x156E588", VA = "0x156E588", Slot = "13")]
		public RESULT setPitch(float pitch)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000432")]
		[Address(RVA = "0x156E620", Offset = "0x156E620", VA = "0x156E620", Slot = "14")]
		public RESULT getPitch(out float pitch)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000433")]
		[Address(RVA = "0x156E6B8", Offset = "0x156E6B8", VA = "0x156E6B8", Slot = "15")]
		public RESULT setMute(bool mute)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000434")]
		[Address(RVA = "0x156E754", Offset = "0x156E754", VA = "0x156E754", Slot = "16")]
		public RESULT getMute(out bool mute)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000435")]
		[Address(RVA = "0x156E800", Offset = "0x156E800", VA = "0x156E800", Slot = "17")]
		public RESULT setReverbProperties(int instance, float wet)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000436")]
		[Address(RVA = "0x156E8A8", Offset = "0x156E8A8", VA = "0x156E8A8", Slot = "18")]
		public RESULT getReverbProperties(int instance, out float wet)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000437")]
		[Address(RVA = "0x156E948", Offset = "0x156E948", VA = "0x156E948", Slot = "19")]
		public RESULT setLowPassGain(float gain)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000438")]
		[Address(RVA = "0x156E9E0", Offset = "0x156E9E0", VA = "0x156E9E0", Slot = "20")]
		public RESULT getLowPassGain(out float gain)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000439")]
		[Address(RVA = "0x156EA78", Offset = "0x156EA78", VA = "0x156EA78", Slot = "21")]
		public RESULT setMode(MODE mode)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600043A")]
		[Address(RVA = "0x156EB10", Offset = "0x156EB10", VA = "0x156EB10", Slot = "22")]
		public RESULT getMode(out MODE mode)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600043B")]
		[Address(RVA = "0x156EBA8", Offset = "0x156EBA8", VA = "0x156EBA8", Slot = "23")]
		public RESULT setCallback(CHANNELCONTROL_CALLBACK callback)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600043C")]
		[Address(RVA = "0x156EC48", Offset = "0x156EC48", VA = "0x156EC48", Slot = "24")]
		public RESULT isPlaying(out bool isplaying)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600043D")]
		[Address(RVA = "0x156ECF4", Offset = "0x156ECF4", VA = "0x156ECF4", Slot = "25")]
		public RESULT setPan(float pan)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600043E")]
		[Address(RVA = "0x156ED8C", Offset = "0x156ED8C", VA = "0x156ED8C", Slot = "26")]
		public RESULT setMixLevelsOutput(float frontleft, float frontright, float center, float lfe, float surroundleft, float surroundright, float backleft, float backright)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600043F")]
		[Address(RVA = "0x156EE74", Offset = "0x156EE74", VA = "0x156EE74", Slot = "27")]
		public RESULT setMixLevelsInput(float[] levels, int numlevels)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000440")]
		[Address(RVA = "0x156EF1C", Offset = "0x156EF1C", VA = "0x156EF1C", Slot = "28")]
		public RESULT setMixMatrix(float[] matrix, int outchannels, int inchannels, int inchannel_hop = 0)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000441")]
		[Address(RVA = "0x156EFDC", Offset = "0x156EFDC", VA = "0x156EFDC", Slot = "29")]
		public RESULT getMixMatrix(float[] matrix, out int outchannels, out int inchannels, int inchannel_hop = 0)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000442")]
		[Address(RVA = "0x156F09C", Offset = "0x156F09C", VA = "0x156F09C", Slot = "30")]
		public RESULT getDSPClock(out ulong dspclock, out ulong parentclock)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000443")]
		[Address(RVA = "0x156F13C", Offset = "0x156F13C", VA = "0x156F13C", Slot = "31")]
		public RESULT setDelay(ulong dspclock_start, ulong dspclock_end, bool stopchannels = true)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000444")]
		[Address(RVA = "0x156F1F0", Offset = "0x156F1F0", VA = "0x156F1F0", Slot = "32")]
		public RESULT getDelay(out ulong dspclock_start, out ulong dspclock_end)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000445")]
		[Address(RVA = "0x156F2F8", Offset = "0x156F2F8", VA = "0x156F2F8", Slot = "33")]
		public RESULT getDelay(out ulong dspclock_start, out ulong dspclock_end, out bool stopchannels)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000446")]
		[Address(RVA = "0x156F3BC", Offset = "0x156F3BC", VA = "0x156F3BC", Slot = "34")]
		public RESULT addFadePoint(ulong dspclock, float volume)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000447")]
		[Address(RVA = "0x156F464", Offset = "0x156F464", VA = "0x156F464", Slot = "35")]
		public RESULT setFadePointRamp(ulong dspclock, float volume)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000448")]
		[Address(RVA = "0x156F50C", Offset = "0x156F50C", VA = "0x156F50C", Slot = "36")]
		public RESULT removeFadePoints(ulong dspclock_start, ulong dspclock_end)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000449")]
		[Address(RVA = "0x156F5AC", Offset = "0x156F5AC", VA = "0x156F5AC", Slot = "37")]
		public RESULT getFadePoints(ref uint numpoints, ulong[] point_dspclock, float[] point_volume)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600044A")]
		[Address(RVA = "0x156F66C", Offset = "0x156F66C", VA = "0x156F66C", Slot = "38")]
		public RESULT getDSP(int index, out DSP dsp)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600044B")]
		[Address(RVA = "0x156F708", Offset = "0x156F708", VA = "0x156F708", Slot = "39")]
		public RESULT addDSP(int index, DSP dsp)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600044C")]
		[Address(RVA = "0x156F7A4", Offset = "0x156F7A4", VA = "0x156F7A4", Slot = "40")]
		public RESULT removeDSP(DSP dsp)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600044D")]
		[Address(RVA = "0x156F83C", Offset = "0x156F83C", VA = "0x156F83C", Slot = "41")]
		public RESULT getNumDSPs(out int numdsps)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600044E")]
		[Address(RVA = "0x156F8D4", Offset = "0x156F8D4", VA = "0x156F8D4", Slot = "42")]
		public RESULT setDSPIndex(DSP dsp, int index)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600044F")]
		[Address(RVA = "0x156F974", Offset = "0x156F974", VA = "0x156F974", Slot = "43")]
		public RESULT getDSPIndex(DSP dsp, out int index)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000450")]
		[Address(RVA = "0x156FA14", Offset = "0x156FA14", VA = "0x156FA14", Slot = "44")]
		public RESULT set3DAttributes(ref VECTOR pos, ref VECTOR vel)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000451")]
		[Address(RVA = "0x156FAB4", Offset = "0x156FAB4", VA = "0x156FAB4", Slot = "45")]
		public RESULT get3DAttributes(out VECTOR pos, out VECTOR vel)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000452")]
		[Address(RVA = "0x156FB54", Offset = "0x156FB54", VA = "0x156FB54", Slot = "46")]
		public RESULT set3DMinMaxDistance(float mindistance, float maxdistance)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000453")]
		[Address(RVA = "0x156FBF4", Offset = "0x156FBF4", VA = "0x156FBF4", Slot = "47")]
		public RESULT get3DMinMaxDistance(out float mindistance, out float maxdistance)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000454")]
		[Address(RVA = "0x156FC94", Offset = "0x156FC94", VA = "0x156FC94", Slot = "48")]
		public RESULT set3DConeSettings(float insideconeangle, float outsideconeangle, float outsidevolume)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000455")]
		[Address(RVA = "0x156FD44", Offset = "0x156FD44", VA = "0x156FD44", Slot = "49")]
		public RESULT get3DConeSettings(out float insideconeangle, out float outsideconeangle, out float outsidevolume)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000456")]
		[Address(RVA = "0x156FDF4", Offset = "0x156FDF4", VA = "0x156FDF4", Slot = "50")]
		public RESULT set3DConeOrientation(ref VECTOR orientation)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000457")]
		[Address(RVA = "0x156FE8C", Offset = "0x156FE8C", VA = "0x156FE8C", Slot = "51")]
		public RESULT get3DConeOrientation(out VECTOR orientation)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000458")]
		[Address(RVA = "0x156FF24", Offset = "0x156FF24", VA = "0x156FF24", Slot = "52")]
		public RESULT set3DCustomRolloff(ref VECTOR points, int numpoints)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000459")]
		[Address(RVA = "0x156FFC4", Offset = "0x156FFC4", VA = "0x156FFC4", Slot = "53")]
		public RESULT get3DCustomRolloff(out IntPtr points, out int numpoints)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600045A")]
		[Address(RVA = "0x1570064", Offset = "0x1570064", VA = "0x1570064", Slot = "54")]
		public RESULT set3DOcclusion(float directocclusion, float reverbocclusion)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600045B")]
		[Address(RVA = "0x1570104", Offset = "0x1570104", VA = "0x1570104", Slot = "55")]
		public RESULT get3DOcclusion(out float directocclusion, out float reverbocclusion)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600045C")]
		[Address(RVA = "0x15701A4", Offset = "0x15701A4", VA = "0x15701A4", Slot = "56")]
		public RESULT set3DSpread(float angle)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600045D")]
		[Address(RVA = "0x157023C", Offset = "0x157023C", VA = "0x157023C", Slot = "57")]
		public RESULT get3DSpread(out float angle)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600045E")]
		[Address(RVA = "0x15702D4", Offset = "0x15702D4", VA = "0x15702D4", Slot = "58")]
		public RESULT set3DLevel(float level)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600045F")]
		[Address(RVA = "0x157036C", Offset = "0x157036C", VA = "0x157036C", Slot = "59")]
		public RESULT get3DLevel(out float level)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000460")]
		[Address(RVA = "0x1570404", Offset = "0x1570404", VA = "0x1570404", Slot = "60")]
		public RESULT set3DDopplerLevel(float level)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000461")]
		[Address(RVA = "0x157049C", Offset = "0x157049C", VA = "0x157049C", Slot = "61")]
		public RESULT get3DDopplerLevel(out float level)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000462")]
		[Address(RVA = "0x1570534", Offset = "0x1570534", VA = "0x1570534", Slot = "62")]
		public RESULT set3DDistanceFilter(bool custom, float customLevel, float centerFreq)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000463")]
		[Address(RVA = "0x15705E8", Offset = "0x15705E8", VA = "0x15705E8", Slot = "63")]
		public RESULT get3DDistanceFilter(out bool custom, out float customLevel, out float centerFreq)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000464")]
		[Address(RVA = "0x15706AC", Offset = "0x15706AC", VA = "0x15706AC", Slot = "64")]
		public RESULT setUserData(IntPtr userdata)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000465")]
		[Address(RVA = "0x1570744", Offset = "0x1570744", VA = "0x1570744", Slot = "65")]
		public RESULT getUserData(out IntPtr userdata)
		{
			return default(RESULT);
		}

		[PreserveSig]
		[Token(Token = "0x6000466")]
		[Address(RVA = "0x156D6CC", Offset = "0x156D6CC", VA = "0x156D6CC")]
		private static extern RESULT FMOD5_Channel_SetFrequency(IntPtr channel, float frequency);

		[PreserveSig]
		[Token(Token = "0x6000467")]
		[Address(RVA = "0x156D764", Offset = "0x156D764", VA = "0x156D764")]
		private static extern RESULT FMOD5_Channel_GetFrequency(IntPtr channel, out float frequency);

		[PreserveSig]
		[Token(Token = "0x6000468")]
		[Address(RVA = "0x156D7FC", Offset = "0x156D7FC", VA = "0x156D7FC")]
		private static extern RESULT FMOD5_Channel_SetPriority(IntPtr channel, int priority);

		[PreserveSig]
		[Token(Token = "0x6000469")]
		[Address(RVA = "0x156D894", Offset = "0x156D894", VA = "0x156D894")]
		private static extern RESULT FMOD5_Channel_GetPriority(IntPtr channel, out int priority);

		[PreserveSig]
		[Token(Token = "0x600046A")]
		[Address(RVA = "0x156D92C", Offset = "0x156D92C", VA = "0x156D92C")]
		private static extern RESULT FMOD5_Channel_SetPosition(IntPtr channel, uint position, TIMEUNIT postype);

		[PreserveSig]
		[Token(Token = "0x600046B")]
		[Address(RVA = "0x156D9CC", Offset = "0x156D9CC", VA = "0x156D9CC")]
		private static extern RESULT FMOD5_Channel_GetPosition(IntPtr channel, out uint position, TIMEUNIT postype);

		[PreserveSig]
		[Token(Token = "0x600046C")]
		[Address(RVA = "0x156DA6C", Offset = "0x156DA6C", VA = "0x156DA6C")]
		private static extern RESULT FMOD5_Channel_SetChannelGroup(IntPtr channel, IntPtr channelgroup);

		[PreserveSig]
		[Token(Token = "0x600046D")]
		[Address(RVA = "0x156DB04", Offset = "0x156DB04", VA = "0x156DB04")]
		private static extern RESULT FMOD5_Channel_GetChannelGroup(IntPtr channel, out IntPtr channelgroup);

		[PreserveSig]
		[Token(Token = "0x600046E")]
		[Address(RVA = "0x156DB9C", Offset = "0x156DB9C", VA = "0x156DB9C")]
		private static extern RESULT FMOD5_Channel_SetLoopCount(IntPtr channel, int loopcount);

		[PreserveSig]
		[Token(Token = "0x600046F")]
		[Address(RVA = "0x156DC34", Offset = "0x156DC34", VA = "0x156DC34")]
		private static extern RESULT FMOD5_Channel_GetLoopCount(IntPtr channel, out int loopcount);

		[PreserveSig]
		[Token(Token = "0x6000470")]
		[Address(RVA = "0x156DCCC", Offset = "0x156DCCC", VA = "0x156DCCC")]
		private static extern RESULT FMOD5_Channel_SetLoopPoints(IntPtr channel, uint loopstart, TIMEUNIT loopstarttype, uint loopend, TIMEUNIT loopendtype);

		[PreserveSig]
		[Token(Token = "0x6000471")]
		[Address(RVA = "0x156DD84", Offset = "0x156DD84", VA = "0x156DD84")]
		private static extern RESULT FMOD5_Channel_GetLoopPoints(IntPtr channel, out uint loopstart, TIMEUNIT loopstarttype, out uint loopend, TIMEUNIT loopendtype);

		[PreserveSig]
		[Token(Token = "0x6000472")]
		[Address(RVA = "0x156DE3C", Offset = "0x156DE3C", VA = "0x156DE3C")]
		private static extern RESULT FMOD5_Channel_IsVirtual(IntPtr channel, out bool isvirtual);

		[PreserveSig]
		[Token(Token = "0x6000473")]
		[Address(RVA = "0x156DEE8", Offset = "0x156DEE8", VA = "0x156DEE8")]
		private static extern RESULT FMOD5_Channel_GetCurrentSound(IntPtr channel, out IntPtr sound);

		[PreserveSig]
		[Token(Token = "0x6000474")]
		[Address(RVA = "0x156DF80", Offset = "0x156DF80", VA = "0x156DF80")]
		private static extern RESULT FMOD5_Channel_GetIndex(IntPtr channel, out int index);

		[PreserveSig]
		[Token(Token = "0x6000475")]
		[Address(RVA = "0x156E018", Offset = "0x156E018", VA = "0x156E018")]
		private static extern RESULT FMOD5_Channel_GetSystemObject(IntPtr channel, out IntPtr system);

		[PreserveSig]
		[Token(Token = "0x6000476")]
		[Address(RVA = "0x156E0B0", Offset = "0x156E0B0", VA = "0x156E0B0")]
		private static extern RESULT FMOD5_Channel_Stop(IntPtr channel);

		[PreserveSig]
		[Token(Token = "0x6000477")]
		[Address(RVA = "0x156E13C", Offset = "0x156E13C", VA = "0x156E13C")]
		private static extern RESULT FMOD5_Channel_SetPaused(IntPtr channel, bool paused);

		[PreserveSig]
		[Token(Token = "0x6000478")]
		[Address(RVA = "0x156E1D4", Offset = "0x156E1D4", VA = "0x156E1D4")]
		private static extern RESULT FMOD5_Channel_GetPaused(IntPtr channel, out bool paused);

		[PreserveSig]
		[Token(Token = "0x6000479")]
		[Address(RVA = "0x156E280", Offset = "0x156E280", VA = "0x156E280")]
		private static extern RESULT FMOD5_Channel_SetVolume(IntPtr channel, float volume);

		[PreserveSig]
		[Token(Token = "0x600047A")]
		[Address(RVA = "0x156E318", Offset = "0x156E318", VA = "0x156E318")]
		private static extern RESULT FMOD5_Channel_GetVolume(IntPtr channel, out float volume);

		[PreserveSig]
		[Token(Token = "0x600047B")]
		[Address(RVA = "0x156E3B4", Offset = "0x156E3B4", VA = "0x156E3B4")]
		private static extern RESULT FMOD5_Channel_SetVolumeRamp(IntPtr channel, bool ramp);

		[PreserveSig]
		[Token(Token = "0x600047C")]
		[Address(RVA = "0x156E44C", Offset = "0x156E44C", VA = "0x156E44C")]
		private static extern RESULT FMOD5_Channel_GetVolumeRamp(IntPtr channel, out bool ramp);

		[PreserveSig]
		[Token(Token = "0x600047D")]
		[Address(RVA = "0x156E4F8", Offset = "0x156E4F8", VA = "0x156E4F8")]
		private static extern RESULT FMOD5_Channel_GetAudibility(IntPtr channel, out float audibility);

		[PreserveSig]
		[Token(Token = "0x600047E")]
		[Address(RVA = "0x156E590", Offset = "0x156E590", VA = "0x156E590")]
		private static extern RESULT FMOD5_Channel_SetPitch(IntPtr channel, float pitch);

		[PreserveSig]
		[Token(Token = "0x600047F")]
		[Address(RVA = "0x156E628", Offset = "0x156E628", VA = "0x156E628")]
		private static extern RESULT FMOD5_Channel_GetPitch(IntPtr channel, out float pitch);

		[PreserveSig]
		[Token(Token = "0x6000480")]
		[Address(RVA = "0x156E6C4", Offset = "0x156E6C4", VA = "0x156E6C4")]
		private static extern RESULT FMOD5_Channel_SetMute(IntPtr channel, bool mute);

		[PreserveSig]
		[Token(Token = "0x6000481")]
		[Address(RVA = "0x156E75C", Offset = "0x156E75C", VA = "0x156E75C")]
		private static extern RESULT FMOD5_Channel_GetMute(IntPtr channel, out bool mute);

		[PreserveSig]
		[Token(Token = "0x6000482")]
		[Address(RVA = "0x156E808", Offset = "0x156E808", VA = "0x156E808")]
		private static extern RESULT FMOD5_Channel_SetReverbProperties(IntPtr channel, int instance, float wet);

		[PreserveSig]
		[Token(Token = "0x6000483")]
		[Address(RVA = "0x156E8B0", Offset = "0x156E8B0", VA = "0x156E8B0")]
		private static extern RESULT FMOD5_Channel_GetReverbProperties(IntPtr channel, int instance, out float wet);

		[PreserveSig]
		[Token(Token = "0x6000484")]
		[Address(RVA = "0x156E950", Offset = "0x156E950", VA = "0x156E950")]
		private static extern RESULT FMOD5_Channel_SetLowPassGain(IntPtr channel, float gain);

		[PreserveSig]
		[Token(Token = "0x6000485")]
		[Address(RVA = "0x156E9E8", Offset = "0x156E9E8", VA = "0x156E9E8")]
		private static extern RESULT FMOD5_Channel_GetLowPassGain(IntPtr channel, out float gain);

		[PreserveSig]
		[Token(Token = "0x6000486")]
		[Address(RVA = "0x156EA80", Offset = "0x156EA80", VA = "0x156EA80")]
		private static extern RESULT FMOD5_Channel_SetMode(IntPtr channel, MODE mode);

		[PreserveSig]
		[Token(Token = "0x6000487")]
		[Address(RVA = "0x156EB18", Offset = "0x156EB18", VA = "0x156EB18")]
		private static extern RESULT FMOD5_Channel_GetMode(IntPtr channel, out MODE mode);

		[PreserveSig]
		[Token(Token = "0x6000488")]
		[Address(RVA = "0x156EBB0", Offset = "0x156EBB0", VA = "0x156EBB0")]
		private static extern RESULT FMOD5_Channel_SetCallback(IntPtr channel, CHANNELCONTROL_CALLBACK callback);

		[PreserveSig]
		[Token(Token = "0x6000489")]
		[Address(RVA = "0x156EC50", Offset = "0x156EC50", VA = "0x156EC50")]
		private static extern RESULT FMOD5_Channel_IsPlaying(IntPtr channel, out bool isplaying);

		[PreserveSig]
		[Token(Token = "0x600048A")]
		[Address(RVA = "0x156ECFC", Offset = "0x156ECFC", VA = "0x156ECFC")]
		private static extern RESULT FMOD5_Channel_SetPan(IntPtr channel, float pan);

		[PreserveSig]
		[Token(Token = "0x600048B")]
		[Address(RVA = "0x156ED94", Offset = "0x156ED94", VA = "0x156ED94")]
		private static extern RESULT FMOD5_Channel_SetMixLevelsOutput(IntPtr channel, float frontleft, float frontright, float center, float lfe, float surroundleft, float surroundright, float backleft, float backright);

		[PreserveSig]
		[Token(Token = "0x600048C")]
		[Address(RVA = "0x156EE7C", Offset = "0x156EE7C", VA = "0x156EE7C")]
		private static extern RESULT FMOD5_Channel_SetMixLevelsInput(IntPtr channel, float[] levels, int numlevels);

		[PreserveSig]
		[Token(Token = "0x600048D")]
		[Address(RVA = "0x156EF24", Offset = "0x156EF24", VA = "0x156EF24")]
		private static extern RESULT FMOD5_Channel_SetMixMatrix(IntPtr channel, float[] matrix, int outchannels, int inchannels, int inchannel_hop);

		[PreserveSig]
		[Token(Token = "0x600048E")]
		[Address(RVA = "0x156EFE4", Offset = "0x156EFE4", VA = "0x156EFE4")]
		private static extern RESULT FMOD5_Channel_GetMixMatrix(IntPtr channel, float[] matrix, out int outchannels, out int inchannels, int inchannel_hop);

		[PreserveSig]
		[Token(Token = "0x600048F")]
		[Address(RVA = "0x156F0A4", Offset = "0x156F0A4", VA = "0x156F0A4")]
		private static extern RESULT FMOD5_Channel_GetDSPClock(IntPtr channel, out ulong dspclock, out ulong parentclock);

		[PreserveSig]
		[Token(Token = "0x6000490")]
		[Address(RVA = "0x156F148", Offset = "0x156F148", VA = "0x156F148")]
		private static extern RESULT FMOD5_Channel_SetDelay(IntPtr channel, ulong dspclock_start, ulong dspclock_end, bool stopchannels);

		[PreserveSig]
		[Token(Token = "0x6000491")]
		[Address(RVA = "0x156F250", Offset = "0x156F250", VA = "0x156F250")]
		private static extern RESULT FMOD5_Channel_GetDelay(IntPtr channel, out ulong dspclock_start, out ulong dspclock_end, IntPtr zero);

		[PreserveSig]
		[Token(Token = "0x6000492")]
		[Address(RVA = "0x156F300", Offset = "0x156F300", VA = "0x156F300")]
		private static extern RESULT FMOD5_Channel_GetDelay(IntPtr channel, out ulong dspclock_start, out ulong dspclock_end, out bool stopchannels);

		[PreserveSig]
		[Token(Token = "0x6000493")]
		[Address(RVA = "0x156F3C4", Offset = "0x156F3C4", VA = "0x156F3C4")]
		private static extern RESULT FMOD5_Channel_AddFadePoint(IntPtr channel, ulong dspclock, float volume);

		[PreserveSig]
		[Token(Token = "0x6000494")]
		[Address(RVA = "0x156F46C", Offset = "0x156F46C", VA = "0x156F46C")]
		private static extern RESULT FMOD5_Channel_SetFadePointRamp(IntPtr channel, ulong dspclock, float volume);

		[PreserveSig]
		[Token(Token = "0x6000495")]
		[Address(RVA = "0x156F514", Offset = "0x156F514", VA = "0x156F514")]
		private static extern RESULT FMOD5_Channel_RemoveFadePoints(IntPtr channel, ulong dspclock_start, ulong dspclock_end);

		[PreserveSig]
		[Token(Token = "0x6000496")]
		[Address(RVA = "0x156F5B4", Offset = "0x156F5B4", VA = "0x156F5B4")]
		private static extern RESULT FMOD5_Channel_GetFadePoints(IntPtr channel, ref uint numpoints, ulong[] point_dspclock, float[] point_volume);

		[PreserveSig]
		[Token(Token = "0x6000497")]
		[Address(RVA = "0x156F674", Offset = "0x156F674", VA = "0x156F674")]
		private static extern RESULT FMOD5_Channel_GetDSP(IntPtr channel, int index, out IntPtr dsp);

		[PreserveSig]
		[Token(Token = "0x6000498")]
		[Address(RVA = "0x156F710", Offset = "0x156F710", VA = "0x156F710")]
		private static extern RESULT FMOD5_Channel_AddDSP(IntPtr channel, int index, IntPtr dsp);

		[PreserveSig]
		[Token(Token = "0x6000499")]
		[Address(RVA = "0x156F7AC", Offset = "0x156F7AC", VA = "0x156F7AC")]
		private static extern RESULT FMOD5_Channel_RemoveDSP(IntPtr channel, IntPtr dsp);

		[PreserveSig]
		[Token(Token = "0x600049A")]
		[Address(RVA = "0x156F844", Offset = "0x156F844", VA = "0x156F844")]
		private static extern RESULT FMOD5_Channel_GetNumDSPs(IntPtr channel, out int numdsps);

		[PreserveSig]
		[Token(Token = "0x600049B")]
		[Address(RVA = "0x156F8DC", Offset = "0x156F8DC", VA = "0x156F8DC")]
		private static extern RESULT FMOD5_Channel_SetDSPIndex(IntPtr channel, IntPtr dsp, int index);

		[PreserveSig]
		[Token(Token = "0x600049C")]
		[Address(RVA = "0x156F97C", Offset = "0x156F97C", VA = "0x156F97C")]
		private static extern RESULT FMOD5_Channel_GetDSPIndex(IntPtr channel, IntPtr dsp, out int index);

		[PreserveSig]
		[Token(Token = "0x600049D")]
		[Address(RVA = "0x156FA1C", Offset = "0x156FA1C", VA = "0x156FA1C")]
		private static extern RESULT FMOD5_Channel_Set3DAttributes(IntPtr channel, ref VECTOR pos, ref VECTOR vel);

		[PreserveSig]
		[Token(Token = "0x600049E")]
		[Address(RVA = "0x156FABC", Offset = "0x156FABC", VA = "0x156FABC")]
		private static extern RESULT FMOD5_Channel_Get3DAttributes(IntPtr channel, out VECTOR pos, out VECTOR vel);

		[PreserveSig]
		[Token(Token = "0x600049F")]
		[Address(RVA = "0x156FB5C", Offset = "0x156FB5C", VA = "0x156FB5C")]
		private static extern RESULT FMOD5_Channel_Set3DMinMaxDistance(IntPtr channel, float mindistance, float maxdistance);

		[PreserveSig]
		[Token(Token = "0x60004A0")]
		[Address(RVA = "0x156FBFC", Offset = "0x156FBFC", VA = "0x156FBFC")]
		private static extern RESULT FMOD5_Channel_Get3DMinMaxDistance(IntPtr channel, out float mindistance, out float maxdistance);

		[PreserveSig]
		[Token(Token = "0x60004A1")]
		[Address(RVA = "0x156FC9C", Offset = "0x156FC9C", VA = "0x156FC9C")]
		private static extern RESULT FMOD5_Channel_Set3DConeSettings(IntPtr channel, float insideconeangle, float outsideconeangle, float outsidevolume);

		[PreserveSig]
		[Token(Token = "0x60004A2")]
		[Address(RVA = "0x156FD4C", Offset = "0x156FD4C", VA = "0x156FD4C")]
		private static extern RESULT FMOD5_Channel_Get3DConeSettings(IntPtr channel, out float insideconeangle, out float outsideconeangle, out float outsidevolume);

		[PreserveSig]
		[Token(Token = "0x60004A3")]
		[Address(RVA = "0x156FDFC", Offset = "0x156FDFC", VA = "0x156FDFC")]
		private static extern RESULT FMOD5_Channel_Set3DConeOrientation(IntPtr channel, ref VECTOR orientation);

		[PreserveSig]
		[Token(Token = "0x60004A4")]
		[Address(RVA = "0x156FE94", Offset = "0x156FE94", VA = "0x156FE94")]
		private static extern RESULT FMOD5_Channel_Get3DConeOrientation(IntPtr channel, out VECTOR orientation);

		[PreserveSig]
		[Token(Token = "0x60004A5")]
		[Address(RVA = "0x156FF2C", Offset = "0x156FF2C", VA = "0x156FF2C")]
		private static extern RESULT FMOD5_Channel_Set3DCustomRolloff(IntPtr channel, ref VECTOR points, int numpoints);

		[PreserveSig]
		[Token(Token = "0x60004A6")]
		[Address(RVA = "0x156FFCC", Offset = "0x156FFCC", VA = "0x156FFCC")]
		private static extern RESULT FMOD5_Channel_Get3DCustomRolloff(IntPtr channel, out IntPtr points, out int numpoints);

		[PreserveSig]
		[Token(Token = "0x60004A7")]
		[Address(RVA = "0x157006C", Offset = "0x157006C", VA = "0x157006C")]
		private static extern RESULT FMOD5_Channel_Set3DOcclusion(IntPtr channel, float directocclusion, float reverbocclusion);

		[PreserveSig]
		[Token(Token = "0x60004A8")]
		[Address(RVA = "0x157010C", Offset = "0x157010C", VA = "0x157010C")]
		private static extern RESULT FMOD5_Channel_Get3DOcclusion(IntPtr channel, out float directocclusion, out float reverbocclusion);

		[PreserveSig]
		[Token(Token = "0x60004A9")]
		[Address(RVA = "0x15701AC", Offset = "0x15701AC", VA = "0x15701AC")]
		private static extern RESULT FMOD5_Channel_Set3DSpread(IntPtr channel, float angle);

		[PreserveSig]
		[Token(Token = "0x60004AA")]
		[Address(RVA = "0x1570244", Offset = "0x1570244", VA = "0x1570244")]
		private static extern RESULT FMOD5_Channel_Get3DSpread(IntPtr channel, out float angle);

		[PreserveSig]
		[Token(Token = "0x60004AB")]
		[Address(RVA = "0x15702DC", Offset = "0x15702DC", VA = "0x15702DC")]
		private static extern RESULT FMOD5_Channel_Set3DLevel(IntPtr channel, float level);

		[PreserveSig]
		[Token(Token = "0x60004AC")]
		[Address(RVA = "0x1570374", Offset = "0x1570374", VA = "0x1570374")]
		private static extern RESULT FMOD5_Channel_Get3DLevel(IntPtr channel, out float level);

		[PreserveSig]
		[Token(Token = "0x60004AD")]
		[Address(RVA = "0x157040C", Offset = "0x157040C", VA = "0x157040C")]
		private static extern RESULT FMOD5_Channel_Set3DDopplerLevel(IntPtr channel, float level);

		[PreserveSig]
		[Token(Token = "0x60004AE")]
		[Address(RVA = "0x15704A4", Offset = "0x15704A4", VA = "0x15704A4")]
		private static extern RESULT FMOD5_Channel_Get3DDopplerLevel(IntPtr channel, out float level);

		[PreserveSig]
		[Token(Token = "0x60004AF")]
		[Address(RVA = "0x1570540", Offset = "0x1570540", VA = "0x1570540")]
		private static extern RESULT FMOD5_Channel_Set3DDistanceFilter(IntPtr channel, bool custom, float customLevel, float centerFreq);

		[PreserveSig]
		[Token(Token = "0x60004B0")]
		[Address(RVA = "0x15705F0", Offset = "0x15705F0", VA = "0x15705F0")]
		private static extern RESULT FMOD5_Channel_Get3DDistanceFilter(IntPtr channel, out bool custom, out float customLevel, out float centerFreq);

		[PreserveSig]
		[Token(Token = "0x60004B1")]
		[Address(RVA = "0x15706B4", Offset = "0x15706B4", VA = "0x15706B4")]
		private static extern RESULT FMOD5_Channel_SetUserData(IntPtr channel, IntPtr userdata);

		[PreserveSig]
		[Token(Token = "0x60004B2")]
		[Address(RVA = "0x157074C", Offset = "0x157074C", VA = "0x157074C")]
		private static extern RESULT FMOD5_Channel_GetUserData(IntPtr channel, out IntPtr userdata);

		[Token(Token = "0x60004B3")]
		[Address(RVA = "0x15707DC", Offset = "0x15707DC", VA = "0x15707DC")]
		public bool hasHandle()
		{
			return default(bool);
		}

		[Token(Token = "0x60004B4")]
		[Address(RVA = "0x1570828", Offset = "0x1570828", VA = "0x1570828")]
		public void clearHandle()
		{
		}
	}
	[Token(Token = "0x2000070")]
	public struct ChannelGroup : IChannelControl
	{
		[Token(Token = "0x40002C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public IntPtr handle;

		[Token(Token = "0x60004B5")]
		[Address(RVA = "0x157086C", Offset = "0x157086C", VA = "0x157086C")]
		public RESULT release()
		{
			return default(RESULT);
		}

		[Token(Token = "0x60004B6")]
		[Address(RVA = "0x15708F4", Offset = "0x15708F4", VA = "0x15708F4")]
		public RESULT addGroup(ChannelGroup group, bool propagatedspclock = true)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60004B7")]
		[Address(RVA = "0x15709FC", Offset = "0x15709FC", VA = "0x15709FC")]
		public RESULT addGroup(ChannelGroup group, bool propagatedspclock, out DSPConnection connection)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60004B8")]
		[Address(RVA = "0x1570AB0", Offset = "0x1570AB0", VA = "0x1570AB0")]
		public RESULT getNumGroups(out int numgroups)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60004B9")]
		[Address(RVA = "0x1570B48", Offset = "0x1570B48", VA = "0x1570B48")]
		public RESULT getGroup(int index, out ChannelGroup group)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60004BA")]
		[Address(RVA = "0x1570BE8", Offset = "0x1570BE8", VA = "0x1570BE8")]
		public RESULT getParentGroup(out ChannelGroup group)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60004BB")]
		[Address(RVA = "0x1570C80", Offset = "0x1570C80", VA = "0x1570C80")]
		public RESULT getName(out string name, int namelen)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60004BC")]
		[Address(RVA = "0x1570ED8", Offset = "0x1570ED8", VA = "0x1570ED8")]
		public RESULT getNumChannels(out int numchannels)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60004BD")]
		[Address(RVA = "0x1570F70", Offset = "0x1570F70", VA = "0x1570F70")]
		public RESULT getChannel(int index, out Channel channel)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60004BE")]
		[Address(RVA = "0x1571010", Offset = "0x1571010", VA = "0x1571010", Slot = "4")]
		public RESULT getSystemObject(out System system)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60004BF")]
		[Address(RVA = "0x15710A8", Offset = "0x15710A8", VA = "0x15710A8", Slot = "5")]
		public RESULT stop()
		{
			return default(RESULT);
		}

		[Token(Token = "0x60004C0")]
		[Address(RVA = "0x1571130", Offset = "0x1571130", VA = "0x1571130", Slot = "6")]
		public RESULT setPaused(bool paused)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60004C1")]
		[Address(RVA = "0x15711CC", Offset = "0x15711CC", VA = "0x15711CC", Slot = "7")]
		public RESULT getPaused(out bool paused)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60004C2")]
		[Address(RVA = "0x1571278", Offset = "0x1571278", VA = "0x1571278", Slot = "8")]
		public RESULT setVolume(float volume)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60004C3")]
		[Address(RVA = "0x1571310", Offset = "0x1571310", VA = "0x1571310", Slot = "9")]
		public RESULT getVolume(out float volume)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60004C4")]
		[Address(RVA = "0x15713A8", Offset = "0x15713A8", VA = "0x15713A8", Slot = "10")]
		public RESULT setVolumeRamp(bool ramp)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60004C5")]
		[Address(RVA = "0x1571444", Offset = "0x1571444", VA = "0x1571444", Slot = "11")]
		public RESULT getVolumeRamp(out bool ramp)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60004C6")]
		[Address(RVA = "0x15714F0", Offset = "0x15714F0", VA = "0x15714F0", Slot = "12")]
		public RESULT getAudibility(out float audibility)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60004C7")]
		[Address(RVA = "0x1571588", Offset = "0x1571588", VA = "0x1571588", Slot = "13")]
		public RESULT setPitch(float pitch)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60004C8")]
		[Address(RVA = "0x1571620", Offset = "0x1571620", VA = "0x1571620", Slot = "14")]
		public RESULT getPitch(out float pitch)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60004C9")]
		[Address(RVA = "0x15716B8", Offset = "0x15716B8", VA = "0x15716B8", Slot = "15")]
		public RESULT setMute(bool mute)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60004CA")]
		[Address(RVA = "0x1571754", Offset = "0x1571754", VA = "0x1571754", Slot = "16")]
		public RESULT getMute(out bool mute)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60004CB")]
		[Address(RVA = "0x1571800", Offset = "0x1571800", VA = "0x1571800", Slot = "17")]
		public RESULT setReverbProperties(int instance, float wet)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60004CC")]
		[Address(RVA = "0x15718A8", Offset = "0x15718A8", VA = "0x15718A8", Slot = "18")]
		public RESULT getReverbProperties(int instance, out float wet)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60004CD")]
		[Address(RVA = "0x1571948", Offset = "0x1571948", VA = "0x1571948", Slot = "19")]
		public RESULT setLowPassGain(float gain)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60004CE")]
		[Address(RVA = "0x15719E0", Offset = "0x15719E0", VA = "0x15719E0", Slot = "20")]
		public RESULT getLowPassGain(out float gain)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60004CF")]
		[Address(RVA = "0x1571A78", Offset = "0x1571A78", VA = "0x1571A78", Slot = "21")]
		public RESULT setMode(MODE mode)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60004D0")]
		[Address(RVA = "0x1571B10", Offset = "0x1571B10", VA = "0x1571B10", Slot = "22")]
		public RESULT getMode(out MODE mode)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60004D1")]
		[Address(RVA = "0x1571BA8", Offset = "0x1571BA8", VA = "0x1571BA8", Slot = "23")]
		public RESULT setCallback(CHANNELCONTROL_CALLBACK callback)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60004D2")]
		[Address(RVA = "0x1571C48", Offset = "0x1571C48", VA = "0x1571C48", Slot = "24")]
		public RESULT isPlaying(out bool isplaying)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60004D3")]
		[Address(RVA = "0x1571CF4", Offset = "0x1571CF4", VA = "0x1571CF4", Slot = "25")]
		public RESULT setPan(float pan)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60004D4")]
		[Address(RVA = "0x1571D8C", Offset = "0x1571D8C", VA = "0x1571D8C", Slot = "26")]
		public RESULT setMixLevelsOutput(float frontleft, float frontright, float center, float lfe, float surroundleft, float surroundright, float backleft, float backright)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60004D5")]
		[Address(RVA = "0x1571E74", Offset = "0x1571E74", VA = "0x1571E74", Slot = "27")]
		public RESULT setMixLevelsInput(float[] levels, int numlevels)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60004D6")]
		[Address(RVA = "0x1571F1C", Offset = "0x1571F1C", VA = "0x1571F1C", Slot = "28")]
		public RESULT setMixMatrix(float[] matrix, int outchannels, int inchannels, int inchannel_hop)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60004D7")]
		[Address(RVA = "0x1571FDC", Offset = "0x1571FDC", VA = "0x1571FDC", Slot = "29")]
		public RESULT getMixMatrix(float[] matrix, out int outchannels, out int inchannels, int inchannel_hop)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60004D8")]
		[Address(RVA = "0x157209C", Offset = "0x157209C", VA = "0x157209C", Slot = "30")]
		public RESULT getDSPClock(out ulong dspclock, out ulong parentclock)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60004D9")]
		[Address(RVA = "0x157213C", Offset = "0x157213C", VA = "0x157213C", Slot = "31")]
		public RESULT setDelay(ulong dspclock_start, ulong dspclock_end, bool stopchannels)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60004DA")]
		[Address(RVA = "0x15721F0", Offset = "0x15721F0", VA = "0x15721F0", Slot = "32")]
		public RESULT getDelay(out ulong dspclock_start, out ulong dspclock_end)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60004DB")]
		[Address(RVA = "0x15722F8", Offset = "0x15722F8", VA = "0x15722F8", Slot = "33")]
		public RESULT getDelay(out ulong dspclock_start, out ulong dspclock_end, out bool stopchannels)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60004DC")]
		[Address(RVA = "0x15723BC", Offset = "0x15723BC", VA = "0x15723BC", Slot = "34")]
		public RESULT addFadePoint(ulong dspclock, float volume)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60004DD")]
		[Address(RVA = "0x1572464", Offset = "0x1572464", VA = "0x1572464", Slot = "35")]
		public RESULT setFadePointRamp(ulong dspclock, float volume)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60004DE")]
		[Address(RVA = "0x157250C", Offset = "0x157250C", VA = "0x157250C", Slot = "36")]
		public RESULT removeFadePoints(ulong dspclock_start, ulong dspclock_end)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60004DF")]
		[Address(RVA = "0x15725AC", Offset = "0x15725AC", VA = "0x15725AC", Slot = "37")]
		public RESULT getFadePoints(ref uint numpoints, ulong[] point_dspclock, float[] point_volume)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60004E0")]
		[Address(RVA = "0x1572668", Offset = "0x1572668", VA = "0x1572668", Slot = "38")]
		public RESULT getDSP(int index, out DSP dsp)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60004E1")]
		[Address(RVA = "0x1572708", Offset = "0x1572708", VA = "0x1572708", Slot = "39")]
		public RESULT addDSP(int index, DSP dsp)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60004E2")]
		[Address(RVA = "0x15727A8", Offset = "0x15727A8", VA = "0x15727A8", Slot = "40")]
		public RESULT removeDSP(DSP dsp)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60004E3")]
		[Address(RVA = "0x1572840", Offset = "0x1572840", VA = "0x1572840", Slot = "41")]
		public RESULT getNumDSPs(out int numdsps)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60004E4")]
		[Address(RVA = "0x15728D8", Offset = "0x15728D8", VA = "0x15728D8", Slot = "42")]
		public RESULT setDSPIndex(DSP dsp, int index)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60004E5")]
		[Address(RVA = "0x1572978", Offset = "0x1572978", VA = "0x1572978", Slot = "43")]
		public RESULT getDSPIndex(DSP dsp, out int index)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60004E6")]
		[Address(RVA = "0x1572A18", Offset = "0x1572A18", VA = "0x1572A18", Slot = "44")]
		public RESULT set3DAttributes(ref VECTOR pos, ref VECTOR vel)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60004E7")]
		[Address(RVA = "0x1572AB8", Offset = "0x1572AB8", VA = "0x1572AB8", Slot = "45")]
		public RESULT get3DAttributes(out VECTOR pos, out VECTOR vel)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60004E8")]
		[Address(RVA = "0x1572B58", Offset = "0x1572B58", VA = "0x1572B58", Slot = "46")]
		public RESULT set3DMinMaxDistance(float mindistance, float maxdistance)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60004E9")]
		[Address(RVA = "0x1572BF8", Offset = "0x1572BF8", VA = "0x1572BF8", Slot = "47")]
		public RESULT get3DMinMaxDistance(out float mindistance, out float maxdistance)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60004EA")]
		[Address(RVA = "0x1572C98", Offset = "0x1572C98", VA = "0x1572C98", Slot = "48")]
		public RESULT set3DConeSettings(float insideconeangle, float outsideconeangle, float outsidevolume)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60004EB")]
		[Address(RVA = "0x1572D48", Offset = "0x1572D48", VA = "0x1572D48", Slot = "49")]
		public RESULT get3DConeSettings(out float insideconeangle, out float outsideconeangle, out float outsidevolume)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60004EC")]
		[Address(RVA = "0x1572DF8", Offset = "0x1572DF8", VA = "0x1572DF8", Slot = "50")]
		public RESULT set3DConeOrientation(ref VECTOR orientation)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60004ED")]
		[Address(RVA = "0x1572E90", Offset = "0x1572E90", VA = "0x1572E90", Slot = "51")]
		public RESULT get3DConeOrientation(out VECTOR orientation)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60004EE")]
		[Address(RVA = "0x1572F28", Offset = "0x1572F28", VA = "0x1572F28", Slot = "52")]
		public RESULT set3DCustomRolloff(ref VECTOR points, int numpoints)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60004EF")]
		[Address(RVA = "0x1572FC8", Offset = "0x1572FC8", VA = "0x1572FC8", Slot = "53")]
		public RESULT get3DCustomRolloff(out IntPtr points, out int numpoints)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60004F0")]
		[Address(RVA = "0x1573068", Offset = "0x1573068", VA = "0x1573068", Slot = "54")]
		public RESULT set3DOcclusion(float directocclusion, float reverbocclusion)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60004F1")]
		[Address(RVA = "0x1573108", Offset = "0x1573108", VA = "0x1573108", Slot = "55")]
		public RESULT get3DOcclusion(out float directocclusion, out float reverbocclusion)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60004F2")]
		[Address(RVA = "0x15731A8", Offset = "0x15731A8", VA = "0x15731A8", Slot = "56")]
		public RESULT set3DSpread(float angle)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60004F3")]
		[Address(RVA = "0x1573240", Offset = "0x1573240", VA = "0x1573240", Slot = "57")]
		public RESULT get3DSpread(out float angle)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60004F4")]
		[Address(RVA = "0x15732D8", Offset = "0x15732D8", VA = "0x15732D8", Slot = "58")]
		public RESULT set3DLevel(float level)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60004F5")]
		[Address(RVA = "0x1573370", Offset = "0x1573370", VA = "0x1573370", Slot = "59")]
		public RESULT get3DLevel(out float level)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60004F6")]
		[Address(RVA = "0x1573408", Offset = "0x1573408", VA = "0x1573408", Slot = "60")]
		public RESULT set3DDopplerLevel(float level)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60004F7")]
		[Address(RVA = "0x15734A0", Offset = "0x15734A0", VA = "0x15734A0", Slot = "61")]
		public RESULT get3DDopplerLevel(out float level)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60004F8")]
		[Address(RVA = "0x1573538", Offset = "0x1573538", VA = "0x1573538", Slot = "62")]
		public RESULT set3DDistanceFilter(bool custom, float customLevel, float centerFreq)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60004F9")]
		[Address(RVA = "0x15735EC", Offset = "0x15735EC", VA = "0x15735EC", Slot = "63")]
		public RESULT get3DDistanceFilter(out bool custom, out float customLevel, out float centerFreq)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60004FA")]
		[Address(RVA = "0x15736B0", Offset = "0x15736B0", VA = "0x15736B0", Slot = "64")]
		public RESULT setUserData(IntPtr userdata)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60004FB")]
		[Address(RVA = "0x1573748", Offset = "0x1573748", VA = "0x1573748", Slot = "65")]
		public RESULT getUserData(out IntPtr userdata)
		{
			return default(RESULT);
		}

		[PreserveSig]
		[Token(Token = "0x60004FC")]
		[Address(RVA = "0x1570874", Offset = "0x1570874", VA = "0x1570874")]
		private static extern RESULT FMOD5_ChannelGroup_Release(IntPtr channelgroup);

		[PreserveSig]
		[Token(Token = "0x60004FD")]
		[Address(RVA = "0x1570954", Offset = "0x1570954", VA = "0x1570954")]
		private static extern RESULT FMOD5_ChannelGroup_AddGroup(IntPtr channelgroup, IntPtr group, bool propagatedspclock, IntPtr zero);

		[PreserveSig]
		[Token(Token = "0x60004FE")]
		[Address(RVA = "0x1570A08", Offset = "0x1570A08", VA = "0x1570A08")]
		private static extern RESULT FMOD5_ChannelGroup_AddGroup(IntPtr channelgroup, IntPtr group, bool propagatedspclock, out IntPtr connection);

		[PreserveSig]
		[Token(Token = "0x60004FF")]
		[Address(RVA = "0x1570AB8", Offset = "0x1570AB8", VA = "0x1570AB8")]
		private static extern RESULT FMOD5_ChannelGroup_GetNumGroups(IntPtr channelgroup, out int numgroups);

		[PreserveSig]
		[Token(Token = "0x6000500")]
		[Address(RVA = "0x1570B50", Offset = "0x1570B50", VA = "0x1570B50")]
		private static extern RESULT FMOD5_ChannelGroup_GetGroup(IntPtr channelgroup, int index, out IntPtr group);

		[PreserveSig]
		[Token(Token = "0x6000501")]
		[Address(RVA = "0x1570BF0", Offset = "0x1570BF0", VA = "0x1570BF0")]
		private static extern RESULT FMOD5_ChannelGroup_GetParentGroup(IntPtr channelgroup, out IntPtr group);

		[PreserveSig]
		[Token(Token = "0x6000502")]
		[Address(RVA = "0x1570E40", Offset = "0x1570E40", VA = "0x1570E40")]
		private static extern RESULT FMOD5_ChannelGroup_GetName(IntPtr channelgroup, IntPtr name, int namelen);

		[PreserveSig]
		[Token(Token = "0x6000503")]
		[Address(RVA = "0x1570EE0", Offset = "0x1570EE0", VA = "0x1570EE0")]
		private static extern RESULT FMOD5_ChannelGroup_GetNumChannels(IntPtr channelgroup, out int numchannels);

		[PreserveSig]
		[Token(Token = "0x6000504")]
		[Address(RVA = "0x1570F78", Offset = "0x1570F78", VA = "0x1570F78")]
		private static extern RESULT FMOD5_ChannelGroup_GetChannel(IntPtr channelgroup, int index, out IntPtr channel);

		[PreserveSig]
		[Token(Token = "0x6000505")]
		[Address(RVA = "0x1571018", Offset = "0x1571018", VA = "0x1571018")]
		private static extern RESULT FMOD5_ChannelGroup_GetSystemObject(IntPtr channelgroup, out IntPtr system);

		[PreserveSig]
		[Token(Token = "0x6000506")]
		[Address(RVA = "0x15710B0", Offset = "0x15710B0", VA = "0x15710B0")]
		private static extern RESULT FMOD5_ChannelGroup_Stop(IntPtr channelgroup);

		[PreserveSig]
		[Token(Token = "0x6000507")]
		[Address(RVA = "0x157113C", Offset = "0x157113C", VA = "0x157113C")]
		private static extern RESULT FMOD5_ChannelGroup_SetPaused(IntPtr channelgroup, bool paused);

		[PreserveSig]
		[Token(Token = "0x6000508")]
		[Address(RVA = "0x15711D4", Offset = "0x15711D4", VA = "0x15711D4")]
		private static extern RESULT FMOD5_ChannelGroup_GetPaused(IntPtr channelgroup, out bool paused);

		[PreserveSig]
		[Token(Token = "0x6000509")]
		[Address(RVA = "0x1571280", Offset = "0x1571280", VA = "0x1571280")]
		private static extern RESULT FMOD5_ChannelGroup_SetVolume(IntPtr channelgroup, float volume);

		[PreserveSig]
		[Token(Token = "0x600050A")]
		[Address(RVA = "0x1571318", Offset = "0x1571318", VA = "0x1571318")]
		private static extern RESULT FMOD5_ChannelGroup_GetVolume(IntPtr channelgroup, out float volume);

		[PreserveSig]
		[Token(Token = "0x600050B")]
		[Address(RVA = "0x15713B4", Offset = "0x15713B4", VA = "0x15713B4")]
		private static extern RESULT FMOD5_ChannelGroup_SetVolumeRamp(IntPtr channelgroup, bool ramp);

		[PreserveSig]
		[Token(Token = "0x600050C")]
		[Address(RVA = "0x157144C", Offset = "0x157144C", VA = "0x157144C")]
		private static extern RESULT FMOD5_ChannelGroup_GetVolumeRamp(IntPtr channelgroup, out bool ramp);

		[PreserveSig]
		[Token(Token = "0x600050D")]
		[Address(RVA = "0x15714F8", Offset = "0x15714F8", VA = "0x15714F8")]
		private static extern RESULT FMOD5_ChannelGroup_GetAudibility(IntPtr channelgroup, out float audibility);

		[PreserveSig]
		[Token(Token = "0x600050E")]
		[Address(RVA = "0x1571590", Offset = "0x1571590", VA = "0x1571590")]
		private static extern RESULT FMOD5_ChannelGroup_SetPitch(IntPtr channelgroup, float pitch);

		[PreserveSig]
		[Token(Token = "0x600050F")]
		[Address(RVA = "0x1571628", Offset = "0x1571628", VA = "0x1571628")]
		private static extern RESULT FMOD5_ChannelGroup_GetPitch(IntPtr channelgroup, out float pitch);

		[PreserveSig]
		[Token(Token = "0x6000510")]
		[Address(RVA = "0x15716C4", Offset = "0x15716C4", VA = "0x15716C4")]
		private static extern RESULT FMOD5_ChannelGroup_SetMute(IntPtr channelgroup, bool mute);

		[PreserveSig]
		[Token(Token = "0x6000511")]
		[Address(RVA = "0x157175C", Offset = "0x157175C", VA = "0x157175C")]
		private static extern RESULT FMOD5_ChannelGroup_GetMute(IntPtr channelgroup, out bool mute);

		[PreserveSig]
		[Token(Token = "0x6000512")]
		[Address(RVA = "0x1571808", Offset = "0x1571808", VA = "0x1571808")]
		private static extern RESULT FMOD5_ChannelGroup_SetReverbProperties(IntPtr channelgroup, int instance, float wet);

		[PreserveSig]
		[Token(Token = "0x6000513")]
		[Address(RVA = "0x15718B0", Offset = "0x15718B0", VA = "0x15718B0")]
		private static extern RESULT FMOD5_ChannelGroup_GetReverbProperties(IntPtr channelgroup, int instance, out float wet);

		[PreserveSig]
		[Token(Token = "0x6000514")]
		[Address(RVA = "0x1571950", Offset = "0x1571950", VA = "0x1571950")]
		private static extern RESULT FMOD5_ChannelGroup_SetLowPassGain(IntPtr channelgroup, float gain);

		[PreserveSig]
		[Token(Token = "0x6000515")]
		[Address(RVA = "0x15719E8", Offset = "0x15719E8", VA = "0x15719E8")]
		private static extern RESULT FMOD5_ChannelGroup_GetLowPassGain(IntPtr channelgroup, out float gain);

		[PreserveSig]
		[Token(Token = "0x6000516")]
		[Address(RVA = "0x1571A80", Offset = "0x1571A80", VA = "0x1571A80")]
		private static extern RESULT FMOD5_ChannelGroup_SetMode(IntPtr channelgroup, MODE mode);

		[PreserveSig]
		[Token(Token = "0x6000517")]
		[Address(RVA = "0x1571B18", Offset = "0x1571B18", VA = "0x1571B18")]
		private static extern RESULT FMOD5_ChannelGroup_GetMode(IntPtr channelgroup, out MODE mode);

		[PreserveSig]
		[Token(Token = "0x6000518")]
		[Address(RVA = "0x1571BB0", Offset = "0x1571BB0", VA = "0x1571BB0")]
		private static extern RESULT FMOD5_ChannelGroup_SetCallback(IntPtr channelgroup, CHANNELCONTROL_CALLBACK callback);

		[PreserveSig]
		[Token(Token = "0x6000519")]
		[Address(RVA = "0x1571C50", Offset = "0x1571C50", VA = "0x1571C50")]
		private static extern RESULT FMOD5_ChannelGroup_IsPlaying(IntPtr channelgroup, out bool isplaying);

		[PreserveSig]
		[Token(Token = "0x600051A")]
		[Address(RVA = "0x1571CFC", Offset = "0x1571CFC", VA = "0x1571CFC")]
		private static extern RESULT FMOD5_ChannelGroup_SetPan(IntPtr channelgroup, float pan);

		[PreserveSig]
		[Token(Token = "0x600051B")]
		[Address(RVA = "0x1571D94", Offset = "0x1571D94", VA = "0x1571D94")]
		private static extern RESULT FMOD5_ChannelGroup_SetMixLevelsOutput(IntPtr channelgroup, float frontleft, float frontright, float center, float lfe, float surroundleft, float surroundright, float backleft, float backright);

		[PreserveSig]
		[Token(Token = "0x600051C")]
		[Address(RVA = "0x1571E7C", Offset = "0x1571E7C", VA = "0x1571E7C")]
		private static extern RESULT FMOD5_ChannelGroup_SetMixLevelsInput(IntPtr channelgroup, float[] levels, int numlevels);

		[PreserveSig]
		[Token(Token = "0x600051D")]
		[Address(RVA = "0x1571F24", Offset = "0x1571F24", VA = "0x1571F24")]
		private static extern RESULT FMOD5_ChannelGroup_SetMixMatrix(IntPtr channelgroup, float[] matrix, int outchannels, int inchannels, int inchannel_hop);

		[PreserveSig]
		[Token(Token = "0x600051E")]
		[Address(RVA = "0x1571FE4", Offset = "0x1571FE4", VA = "0x1571FE4")]
		private static extern RESULT FMOD5_ChannelGroup_GetMixMatrix(IntPtr channelgroup, float[] matrix, out int outchannels, out int inchannels, int inchannel_hop);

		[PreserveSig]
		[Token(Token = "0x600051F")]
		[Address(RVA = "0x15720A4", Offset = "0x15720A4", VA = "0x15720A4")]
		private static extern RESULT FMOD5_ChannelGroup_GetDSPClock(IntPtr channelgroup, out ulong dspclock, out ulong parentclock);

		[PreserveSig]
		[Token(Token = "0x6000520")]
		[Address(RVA = "0x1572148", Offset = "0x1572148", VA = "0x1572148")]
		private static extern RESULT FMOD5_ChannelGroup_SetDelay(IntPtr channelgroup, ulong dspclock_start, ulong dspclock_end, bool stopchannels);

		[PreserveSig]
		[Token(Token = "0x6000521")]
		[Address(RVA = "0x1572250", Offset = "0x1572250", VA = "0x1572250")]
		private static extern RESULT FMOD5_ChannelGroup_GetDelay(IntPtr channelgroup, out ulong dspclock_start, out ulong dspclock_end, IntPtr zero);

		[PreserveSig]
		[Token(Token = "0x6000522")]
		[Address(RVA = "0x1572300", Offset = "0x1572300", VA = "0x1572300")]
		private static extern RESULT FMOD5_ChannelGroup_GetDelay(IntPtr channelgroup, out ulong dspclock_start, out ulong dspclock_end, out bool stopchannels);

		[PreserveSig]
		[Token(Token = "0x6000523")]
		[Address(RVA = "0x15723C4", Offset = "0x15723C4", VA = "0x15723C4")]
		private static extern RESULT FMOD5_ChannelGroup_AddFadePoint(IntPtr channelgroup, ulong dspclock, float volume);

		[PreserveSig]
		[Token(Token = "0x6000524")]
		[Address(RVA = "0x157246C", Offset = "0x157246C", VA = "0x157246C")]
		private static extern RESULT FMOD5_ChannelGroup_SetFadePointRamp(IntPtr channelgroup, ulong dspclock, float volume);

		[PreserveSig]
		[Token(Token = "0x6000525")]
		[Address(RVA = "0x1572514", Offset = "0x1572514", VA = "0x1572514")]
		private static extern RESULT FMOD5_ChannelGroup_RemoveFadePoints(IntPtr channelgroup, ulong dspclock_start, ulong dspclock_end);

		[PreserveSig]
		[Token(Token = "0x6000526")]
		[Address(RVA = "0x15725B4", Offset = "0x15725B4", VA = "0x15725B4")]
		private static extern RESULT FMOD5_ChannelGroup_GetFadePoints(IntPtr channelgroup, ref uint numpoints, ulong[] point_dspclock, float[] point_volume);

		[PreserveSig]
		[Token(Token = "0x6000527")]
		[Address(RVA = "0x1572670", Offset = "0x1572670", VA = "0x1572670")]
		private static extern RESULT FMOD5_ChannelGroup_GetDSP(IntPtr channelgroup, int index, out IntPtr dsp);

		[PreserveSig]
		[Token(Token = "0x6000528")]
		[Address(RVA = "0x1572710", Offset = "0x1572710", VA = "0x1572710")]
		private static extern RESULT FMOD5_ChannelGroup_AddDSP(IntPtr channelgroup, int index, IntPtr dsp);

		[PreserveSig]
		[Token(Token = "0x6000529")]
		[Address(RVA = "0x15727B0", Offset = "0x15727B0", VA = "0x15727B0")]
		private static extern RESULT FMOD5_ChannelGroup_RemoveDSP(IntPtr channelgroup, IntPtr dsp);

		[PreserveSig]
		[Token(Token = "0x600052A")]
		[Address(RVA = "0x1572848", Offset = "0x1572848", VA = "0x1572848")]
		private static extern RESULT FMOD5_ChannelGroup_GetNumDSPs(IntPtr channelgroup, out int numdsps);

		[PreserveSig]
		[Token(Token = "0x600052B")]
		[Address(RVA = "0x15728E0", Offset = "0x15728E0", VA = "0x15728E0")]
		private static extern RESULT FMOD5_ChannelGroup_SetDSPIndex(IntPtr channelgroup, IntPtr dsp, int index);

		[PreserveSig]
		[Token(Token = "0x600052C")]
		[Address(RVA = "0x1572980", Offset = "0x1572980", VA = "0x1572980")]
		private static extern RESULT FMOD5_ChannelGroup_GetDSPIndex(IntPtr channelgroup, IntPtr dsp, out int index);

		[PreserveSig]
		[Token(Token = "0x600052D")]
		[Address(RVA = "0x1572A20", Offset = "0x1572A20", VA = "0x1572A20")]
		private static extern RESULT FMOD5_ChannelGroup_Set3DAttributes(IntPtr channelgroup, ref VECTOR pos, ref VECTOR vel);

		[PreserveSig]
		[Token(Token = "0x600052E")]
		[Address(RVA = "0x1572AC0", Offset = "0x1572AC0", VA = "0x1572AC0")]
		private static extern RESULT FMOD5_ChannelGroup_Get3DAttributes(IntPtr channelgroup, out VECTOR pos, out VECTOR vel);

		[PreserveSig]
		[Token(Token = "0x600052F")]
		[Address(RVA = "0x1572B60", Offset = "0x1572B60", VA = "0x1572B60")]
		private static extern RESULT FMOD5_ChannelGroup_Set3DMinMaxDistance(IntPtr channelgroup, float mindistance, float maxdistance);

		[PreserveSig]
		[Token(Token = "0x6000530")]
		[Address(RVA = "0x1572C00", Offset = "0x1572C00", VA = "0x1572C00")]
		private static extern RESULT FMOD5_ChannelGroup_Get3DMinMaxDistance(IntPtr channelgroup, out float mindistance, out float maxdistance);

		[PreserveSig]
		[Token(Token = "0x6000531")]
		[Address(RVA = "0x1572CA0", Offset = "0x1572CA0", VA = "0x1572CA0")]
		private static extern RESULT FMOD5_ChannelGroup_Set3DConeSettings(IntPtr channelgroup, float insideconeangle, float outsideconeangle, float outsidevolume);

		[PreserveSig]
		[Token(Token = "0x6000532")]
		[Address(RVA = "0x1572D50", Offset = "0x1572D50", VA = "0x1572D50")]
		private static extern RESULT FMOD5_ChannelGroup_Get3DConeSettings(IntPtr channelgroup, out float insideconeangle, out float outsideconeangle, out float outsidevolume);

		[PreserveSig]
		[Token(Token = "0x6000533")]
		[Address(RVA = "0x1572E00", Offset = "0x1572E00", VA = "0x1572E00")]
		private static extern RESULT FMOD5_ChannelGroup_Set3DConeOrientation(IntPtr channelgroup, ref VECTOR orientation);

		[PreserveSig]
		[Token(Token = "0x6000534")]
		[Address(RVA = "0x1572E98", Offset = "0x1572E98", VA = "0x1572E98")]
		private static extern RESULT FMOD5_ChannelGroup_Get3DConeOrientation(IntPtr channelgroup, out VECTOR orientation);

		[PreserveSig]
		[Token(Token = "0x6000535")]
		[Address(RVA = "0x1572F30", Offset = "0x1572F30", VA = "0x1572F30")]
		private static extern RESULT FMOD5_ChannelGroup_Set3DCustomRolloff(IntPtr channelgroup, ref VECTOR points, int numpoints);

		[PreserveSig]
		[Token(Token = "0x6000536")]
		[Address(RVA = "0x1572FD0", Offset = "0x1572FD0", VA = "0x1572FD0")]
		private static extern RESULT FMOD5_ChannelGroup_Get3DCustomRolloff(IntPtr channelgroup, out IntPtr points, out int numpoints);

		[PreserveSig]
		[Token(Token = "0x6000537")]
		[Address(RVA = "0x1573070", Offset = "0x1573070", VA = "0x1573070")]
		private static extern RESULT FMOD5_ChannelGroup_Set3DOcclusion(IntPtr channelgroup, float directocclusion, float reverbocclusion);

		[PreserveSig]
		[Token(Token = "0x6000538")]
		[Address(RVA = "0x1573110", Offset = "0x1573110", VA = "0x1573110")]
		private static extern RESULT FMOD5_ChannelGroup_Get3DOcclusion(IntPtr channelgroup, out float directocclusion, out float reverbocclusion);

		[PreserveSig]
		[Token(Token = "0x6000539")]
		[Address(RVA = "0x15731B0", Offset = "0x15731B0", VA = "0x15731B0")]
		private static extern RESULT FMOD5_ChannelGroup_Set3DSpread(IntPtr channelgroup, float angle);

		[PreserveSig]
		[Token(Token = "0x600053A")]
		[Address(RVA = "0x1573248", Offset = "0x1573248", VA = "0x1573248")]
		private static extern RESULT FMOD5_ChannelGroup_Get3DSpread(IntPtr channelgroup, out float angle);

		[PreserveSig]
		[Token(Token = "0x600053B")]
		[Address(RVA = "0x15732E0", Offset = "0x15732E0", VA = "0x15732E0")]
		private static extern RESULT FMOD5_ChannelGroup_Set3DLevel(IntPtr channelgroup, float level);

		[PreserveSig]
		[Token(Token = "0x600053C")]
		[Address(RVA = "0x1573378", Offset = "0x1573378", VA = "0x1573378")]
		private static extern RESULT FMOD5_ChannelGroup_Get3DLevel(IntPtr channelgroup, out float level);

		[PreserveSig]
		[Token(Token = "0x600053D")]
		[Address(RVA = "0x1573410", Offset = "0x1573410", VA = "0x1573410")]
		private static extern RESULT FMOD5_ChannelGroup_Set3DDopplerLevel(IntPtr channelgroup, float level);

		[PreserveSig]
		[Token(Token = "0x600053E")]
		[Address(RVA = "0x15734A8", Offset = "0x15734A8", VA = "0x15734A8")]
		private static extern RESULT FMOD5_ChannelGroup_Get3DDopplerLevel(IntPtr channelgroup, out float level);

		[PreserveSig]
		[Token(Token = "0x600053F")]
		[Address(RVA = "0x1573544", Offset = "0x1573544", VA = "0x1573544")]
		private static extern RESULT FMOD5_ChannelGroup_Set3DDistanceFilter(IntPtr channelgroup, bool custom, float customLevel, float centerFreq);

		[PreserveSig]
		[Token(Token = "0x6000540")]
		[Address(RVA = "0x15735F4", Offset = "0x15735F4", VA = "0x15735F4")]
		private static extern RESULT FMOD5_ChannelGroup_Get3DDistanceFilter(IntPtr channelgroup, out bool custom, out float customLevel, out float centerFreq);

		[PreserveSig]
		[Token(Token = "0x6000541")]
		[Address(RVA = "0x15736B8", Offset = "0x15736B8", VA = "0x15736B8")]
		private static extern RESULT FMOD5_ChannelGroup_SetUserData(IntPtr channelgroup, IntPtr userdata);

		[PreserveSig]
		[Token(Token = "0x6000542")]
		[Address(RVA = "0x1573750", Offset = "0x1573750", VA = "0x1573750")]
		private static extern RESULT FMOD5_ChannelGroup_GetUserData(IntPtr channelgroup, out IntPtr userdata);

		[Token(Token = "0x6000543")]
		[Address(RVA = "0x15737E0", Offset = "0x15737E0", VA = "0x15737E0")]
		public bool hasHandle()
		{
			return default(bool);
		}

		[Token(Token = "0x6000544")]
		[Address(RVA = "0x157382C", Offset = "0x157382C", VA = "0x157382C")]
		public void clearHandle()
		{
		}
	}
	[Token(Token = "0x2000071")]
	public struct SoundGroup
	{
		[Token(Token = "0x40002C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public IntPtr handle;

		[Token(Token = "0x6000545")]
		[Address(RVA = "0x1586E6C", Offset = "0x1586E6C", VA = "0x1586E6C")]
		public RESULT release()
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000546")]
		[Address(RVA = "0x1586EF4", Offset = "0x1586EF4", VA = "0x1586EF4")]
		public RESULT getSystemObject(out System system)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000547")]
		[Address(RVA = "0x1586F8C", Offset = "0x1586F8C", VA = "0x1586F8C")]
		public RESULT setMaxAudible(int maxaudible)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000548")]
		[Address(RVA = "0x1587024", Offset = "0x1587024", VA = "0x1587024")]
		public RESULT getMaxAudible(out int maxaudible)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000549")]
		[Address(RVA = "0x15870BC", Offset = "0x15870BC", VA = "0x15870BC")]
		public RESULT setMaxAudibleBehavior(SOUNDGROUP_BEHAVIOR behavior)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600054A")]
		[Address(RVA = "0x1587154", Offset = "0x1587154", VA = "0x1587154")]
		public RESULT getMaxAudibleBehavior(out SOUNDGROUP_BEHAVIOR behavior)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600054B")]
		[Address(RVA = "0x15871EC", Offset = "0x15871EC", VA = "0x15871EC")]
		public RESULT setMuteFadeSpeed(float speed)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600054C")]
		[Address(RVA = "0x1587284", Offset = "0x1587284", VA = "0x1587284")]
		public RESULT getMuteFadeSpeed(out float speed)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600054D")]
		[Address(RVA = "0x158731C", Offset = "0x158731C", VA = "0x158731C")]
		public RESULT setVolume(float volume)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600054E")]
		[Address(RVA = "0x15873B4", Offset = "0x15873B4", VA = "0x15873B4")]
		public RESULT getVolume(out float volume)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600054F")]
		[Address(RVA = "0x158744C", Offset = "0x158744C", VA = "0x158744C")]
		public RESULT stop()
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000550")]
		[Address(RVA = "0x15874D4", Offset = "0x15874D4", VA = "0x15874D4")]
		public RESULT getName(out string name, int namelen)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000551")]
		[Address(RVA = "0x1587724", Offset = "0x1587724", VA = "0x1587724")]
		public RESULT getNumSounds(out int numsounds)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000552")]
		[Address(RVA = "0x15877BC", Offset = "0x15877BC", VA = "0x15877BC")]
		public RESULT getSound(int index, out Sound sound)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000553")]
		[Address(RVA = "0x158785C", Offset = "0x158785C", VA = "0x158785C")]
		public RESULT getNumPlaying(out int numplaying)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000554")]
		[Address(RVA = "0x15878F4", Offset = "0x15878F4", VA = "0x15878F4")]
		public RESULT setUserData(IntPtr userdata)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000555")]
		[Address(RVA = "0x158798C", Offset = "0x158798C", VA = "0x158798C")]
		public RESULT getUserData(out IntPtr userdata)
		{
			return default(RESULT);
		}

		[PreserveSig]
		[Token(Token = "0x6000556")]
		[Address(RVA = "0x1586E74", Offset = "0x1586E74", VA = "0x1586E74")]
		private static extern RESULT FMOD5_SoundGroup_Release(IntPtr soundgroup);

		[PreserveSig]
		[Token(Token = "0x6000557")]
		[Address(RVA = "0x1586EFC", Offset = "0x1586EFC", VA = "0x1586EFC")]
		private static extern RESULT FMOD5_SoundGroup_GetSystemObject(IntPtr soundgroup, out IntPtr system);

		[PreserveSig]
		[Token(Token = "0x6000558")]
		[Address(RVA = "0x1586F94", Offset = "0x1586F94", VA = "0x1586F94")]
		private static extern RESULT FMOD5_SoundGroup_SetMaxAudible(IntPtr soundgroup, int maxaudible);

		[PreserveSig]
		[Token(Token = "0x6000559")]
		[Address(RVA = "0x158702C", Offset = "0x158702C", VA = "0x158702C")]
		private static extern RESULT FMOD5_SoundGroup_GetMaxAudible(IntPtr soundgroup, out int maxaudible);

		[PreserveSig]
		[Token(Token = "0x600055A")]
		[Address(RVA = "0x15870C4", Offset = "0x15870C4", VA = "0x15870C4")]
		private static extern RESULT FMOD5_SoundGroup_SetMaxAudibleBehavior(IntPtr soundgroup, SOUNDGROUP_BEHAVIOR behavior);

		[PreserveSig]
		[Token(Token = "0x600055B")]
		[Address(RVA = "0x158715C", Offset = "0x158715C", VA = "0x158715C")]
		private static extern RESULT FMOD5_SoundGroup_GetMaxAudibleBehavior(IntPtr soundgroup, out SOUNDGROUP_BEHAVIOR behavior);

		[PreserveSig]
		[Token(Token = "0x600055C")]
		[Address(RVA = "0x15871F4", Offset = "0x15871F4", VA = "0x15871F4")]
		private static extern RESULT FMOD5_SoundGroup_SetMuteFadeSpeed(IntPtr soundgroup, float speed);

		[PreserveSig]
		[Token(Token = "0x600055D")]
		[Address(RVA = "0x158728C", Offset = "0x158728C", VA = "0x158728C")]
		private static extern RESULT FMOD5_SoundGroup_GetMuteFadeSpeed(IntPtr soundgroup, out float speed);

		[PreserveSig]
		[Token(Token = "0x600055E")]
		[Address(RVA = "0x1587324", Offset = "0x1587324", VA = "0x1587324")]
		private static extern RESULT FMOD5_SoundGroup_SetVolume(IntPtr soundgroup, float volume);

		[PreserveSig]
		[Token(Token = "0x600055F")]
		[Address(RVA = "0x15873BC", Offset = "0x15873BC", VA = "0x15873BC")]
		private static extern RESULT FMOD5_SoundGroup_GetVolume(IntPtr soundgroup, out float volume);

		[PreserveSig]
		[Token(Token = "0x6000560")]
		[Address(RVA = "0x1587454", Offset = "0x1587454", VA = "0x1587454")]
		private static extern RESULT FMOD5_SoundGroup_Stop(IntPtr soundgroup);

		[PreserveSig]
		[Token(Token = "0x6000561")]
		[Address(RVA = "0x158768C", Offset = "0x158768C", VA = "0x158768C")]
		private static extern RESULT FMOD5_SoundGroup_GetName(IntPtr soundgroup, IntPtr name, int namelen);

		[PreserveSig]
		[Token(Token = "0x6000562")]
		[Address(RVA = "0x158772C", Offset = "0x158772C", VA = "0x158772C")]
		private static extern RESULT FMOD5_SoundGroup_GetNumSounds(IntPtr soundgroup, out int numsounds);

		[PreserveSig]
		[Token(Token = "0x6000563")]
		[Address(RVA = "0x15877C4", Offset = "0x15877C4", VA = "0x15877C4")]
		private static extern RESULT FMOD5_SoundGroup_GetSound(IntPtr soundgroup, int index, out IntPtr sound);

		[PreserveSig]
		[Token(Token = "0x6000564")]
		[Address(RVA = "0x1587864", Offset = "0x1587864", VA = "0x1587864")]
		private static extern RESULT FMOD5_SoundGroup_GetNumPlaying(IntPtr soundgroup, out int numplaying);

		[PreserveSig]
		[Token(Token = "0x6000565")]
		[Address(RVA = "0x15878FC", Offset = "0x15878FC", VA = "0x15878FC")]
		private static extern RESULT FMOD5_SoundGroup_SetUserData(IntPtr soundgroup, IntPtr userdata);

		[PreserveSig]
		[Token(Token = "0x6000566")]
		[Address(RVA = "0x1587994", Offset = "0x1587994", VA = "0x1587994")]
		private static extern RESULT FMOD5_SoundGroup_GetUserData(IntPtr soundgroup, out IntPtr userdata);

		[Token(Token = "0x6000567")]
		[Address(RVA = "0x1587A24", Offset = "0x1587A24", VA = "0x1587A24")]
		public bool hasHandle()
		{
			return default(bool);
		}

		[Token(Token = "0x6000568")]
		[Address(RVA = "0x1587A70", Offset = "0x1587A70", VA = "0x1587A70")]
		public void clearHandle()
		{
		}
	}
	[Token(Token = "0x2000072")]
	public struct DSP
	{
		[Token(Token = "0x40002C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public IntPtr handle;

		[Token(Token = "0x6000569")]
		[Address(RVA = "0x1573C9C", Offset = "0x1573C9C", VA = "0x1573C9C")]
		public RESULT release()
		{
			return default(RESULT);
		}

		[Token(Token = "0x600056A")]
		[Address(RVA = "0x1573D24", Offset = "0x1573D24", VA = "0x1573D24")]
		public RESULT getSystemObject(out System system)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600056B")]
		[Address(RVA = "0x1573DBC", Offset = "0x1573DBC", VA = "0x1573DBC")]
		public RESULT addInput(DSP input)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600056C")]
		[Address(RVA = "0x1573EC0", Offset = "0x1573EC0", VA = "0x1573EC0")]
		public RESULT addInput(DSP input, out DSPConnection connection, DSPCONNECTION_TYPE type = DSPCONNECTION_TYPE.STANDARD)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600056D")]
		[Address(RVA = "0x1573F70", Offset = "0x1573F70", VA = "0x1573F70")]
		public RESULT disconnectFrom(DSP target, DSPConnection connection)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600056E")]
		[Address(RVA = "0x157400C", Offset = "0x157400C", VA = "0x157400C")]
		public RESULT disconnectAll(bool inputs, bool outputs)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600056F")]
		[Address(RVA = "0x15740B4", Offset = "0x15740B4", VA = "0x15740B4")]
		public RESULT getNumInputs(out int numinputs)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000570")]
		[Address(RVA = "0x157414C", Offset = "0x157414C", VA = "0x157414C")]
		public RESULT getNumOutputs(out int numoutputs)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000571")]
		[Address(RVA = "0x15741E4", Offset = "0x15741E4", VA = "0x15741E4")]
		public RESULT getInput(int index, out DSP input, out DSPConnection inputconnection)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000572")]
		[Address(RVA = "0x1574294", Offset = "0x1574294", VA = "0x1574294")]
		public RESULT getOutput(int index, out DSP output, out DSPConnection outputconnection)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000573")]
		[Address(RVA = "0x1574344", Offset = "0x1574344", VA = "0x1574344")]
		public RESULT setActive(bool active)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000574")]
		[Address(RVA = "0x15743E0", Offset = "0x15743E0", VA = "0x15743E0")]
		public RESULT getActive(out bool active)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000575")]
		[Address(RVA = "0x157448C", Offset = "0x157448C", VA = "0x157448C")]
		public RESULT setBypass(bool bypass)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000576")]
		[Address(RVA = "0x1574528", Offset = "0x1574528", VA = "0x1574528")]
		public RESULT getBypass(out bool bypass)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000577")]
		[Address(RVA = "0x15745D4", Offset = "0x15745D4", VA = "0x15745D4")]
		public RESULT setWetDryMix(float prewet, float postwet, float dry)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000578")]
		[Address(RVA = "0x1574684", Offset = "0x1574684", VA = "0x1574684")]
		public RESULT getWetDryMix(out float prewet, out float postwet, out float dry)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000579")]
		[Address(RVA = "0x1574734", Offset = "0x1574734", VA = "0x1574734")]
		public RESULT setChannelFormat(CHANNELMASK channelmask, int numchannels, SPEAKERMODE source_speakermode)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600057A")]
		[Address(RVA = "0x15747E4", Offset = "0x15747E4", VA = "0x15747E4")]
		public RESULT getChannelFormat(out CHANNELMASK channelmask, out int numchannels, out SPEAKERMODE source_speakermode)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600057B")]
		[Address(RVA = "0x1574894", Offset = "0x1574894", VA = "0x1574894")]
		public RESULT getOutputChannelFormat(CHANNELMASK inmask, int inchannels, SPEAKERMODE inspeakermode, out CHANNELMASK outmask, out int outchannels, out SPEAKERMODE outspeakermode)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600057C")]
		[Address(RVA = "0x1574964", Offset = "0x1574964", VA = "0x1574964")]
		public RESULT reset()
		{
			return default(RESULT);
		}

		[Token(Token = "0x600057D")]
		[Address(RVA = "0x15749EC", Offset = "0x15749EC", VA = "0x15749EC")]
		public RESULT setParameterFloat(int index, float value)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600057E")]
		[Address(RVA = "0x1574A94", Offset = "0x1574A94", VA = "0x1574A94")]
		public RESULT setParameterInt(int index, int value)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600057F")]
		[Address(RVA = "0x1574B34", Offset = "0x1574B34", VA = "0x1574B34")]
		public RESULT setParameterBool(int index, bool value)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000580")]
		[Address(RVA = "0x1574BD8", Offset = "0x1574BD8", VA = "0x1574BD8")]
		public RESULT setParameterData(int index, byte[] data)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000581")]
		[Address(RVA = "0x1574D24", Offset = "0x1574D24", VA = "0x1574D24")]
		public RESULT getParameterFloat(int index, out float value)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000582")]
		[Address(RVA = "0x1574E38", Offset = "0x1574E38", VA = "0x1574E38")]
		public RESULT getParameterInt(int index, out int value)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000583")]
		[Address(RVA = "0x1574F4C", Offset = "0x1574F4C", VA = "0x1574F4C")]
		public RESULT getParameterBool(int index, out bool value)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000584")]
		[Address(RVA = "0x1575074", Offset = "0x1575074", VA = "0x1575074")]
		public RESULT getParameterData(int index, out IntPtr data, out uint length)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000585")]
		[Address(RVA = "0x15751A8", Offset = "0x15751A8", VA = "0x15751A8")]
		public RESULT getNumParameters(out int numparams)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000586")]
		[Address(RVA = "0x1575240", Offset = "0x1575240", VA = "0x1575240")]
		public RESULT getParameterInfo(int index, out DSP_PARAMETER_DESC desc)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000587")]
		[Address(RVA = "0x1575340", Offset = "0x1575340", VA = "0x1575340")]
		public RESULT getDataParameterIndex(int datatype, out int index)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000588")]
		[Address(RVA = "0x15753E0", Offset = "0x15753E0", VA = "0x15753E0")]
		public RESULT showConfigDialog(IntPtr hwnd, bool show)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000589")]
		[Address(RVA = "0x1575484", Offset = "0x1575484", VA = "0x1575484")]
		public RESULT getInfo(out string name, out uint version, out int channels, out int configwidth, out int configheight)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600058A")]
		[Address(RVA = "0x1575724", Offset = "0x1575724", VA = "0x1575724")]
		public RESULT getInfo(out uint version, out int channels, out int configwidth, out int configheight)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600058B")]
		[Address(RVA = "0x157579C", Offset = "0x157579C", VA = "0x157579C")]
		public RESULT getType(out DSP_TYPE type)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600058C")]
		[Address(RVA = "0x1575834", Offset = "0x1575834", VA = "0x1575834")]
		public RESULT getIdle(out bool idle)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600058D")]
		[Address(RVA = "0x15758E0", Offset = "0x15758E0", VA = "0x15758E0")]
		public RESULT setUserData(IntPtr userdata)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600058E")]
		[Address(RVA = "0x1575978", Offset = "0x1575978", VA = "0x1575978")]
		public RESULT getUserData(out IntPtr userdata)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600058F")]
		[Address(RVA = "0x1575A10", Offset = "0x1575A10", VA = "0x1575A10")]
		public RESULT setMeteringEnabled(bool inputEnabled, bool outputEnabled)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000590")]
		[Address(RVA = "0x1575AB8", Offset = "0x1575AB8", VA = "0x1575AB8")]
		public RESULT getMeteringEnabled(out bool inputEnabled, out bool outputEnabled)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000591")]
		[Address(RVA = "0x1575B7C", Offset = "0x1575B7C", VA = "0x1575B7C")]
		public RESULT getMeteringInfo(IntPtr zero, out DSP_METERING_INFO outputInfo)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000592")]
		[Address(RVA = "0x1575C6C", Offset = "0x1575C6C", VA = "0x1575C6C")]
		public RESULT getMeteringInfo(out DSP_METERING_INFO inputInfo, IntPtr zero)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000593")]
		[Address(RVA = "0x1575D5C", Offset = "0x1575D5C", VA = "0x1575D5C")]
		public RESULT getMeteringInfo(out DSP_METERING_INFO inputInfo, out DSP_METERING_INFO outputInfo)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000594")]
		[Address(RVA = "0x1575E7C", Offset = "0x1575E7C", VA = "0x1575E7C")]
		public RESULT getCPUUsage(out uint exclusive, out uint inclusive)
		{
			return default(RESULT);
		}

		[PreserveSig]
		[Token(Token = "0x6000595")]
		[Address(RVA = "0x1573CA4", Offset = "0x1573CA4", VA = "0x1573CA4")]
		private static extern RESULT FMOD5_DSP_Release(IntPtr dsp);

		[PreserveSig]
		[Token(Token = "0x6000596")]
		[Address(RVA = "0x1573D2C", Offset = "0x1573D2C", VA = "0x1573D2C")]
		private static extern RESULT FMOD5_DSP_GetSystemObject(IntPtr dsp, out IntPtr system);

		[PreserveSig]
		[Token(Token = "0x6000597")]
		[Address(RVA = "0x1573E18", Offset = "0x1573E18", VA = "0x1573E18")]
		private static extern RESULT FMOD5_DSP_AddInput(IntPtr dsp, IntPtr input, IntPtr zero, DSPCONNECTION_TYPE type);

		[PreserveSig]
		[Token(Token = "0x6000598")]
		[Address(RVA = "0x1573EC8", Offset = "0x1573EC8", VA = "0x1573EC8")]
		private static extern RESULT FMOD5_DSP_AddInput(IntPtr dsp, IntPtr input, out IntPtr connection, DSPCONNECTION_TYPE type);

		[PreserveSig]
		[Token(Token = "0x6000599")]
		[Address(RVA = "0x1573F78", Offset = "0x1573F78", VA = "0x1573F78")]
		private static extern RESULT FMOD5_DSP_DisconnectFrom(IntPtr dsp, IntPtr target, IntPtr connection);

		[PreserveSig]
		[Token(Token = "0x600059A")]
		[Address(RVA = "0x157401C", Offset = "0x157401C", VA = "0x157401C")]
		private static extern RESULT FMOD5_DSP_DisconnectAll(IntPtr dsp, bool inputs, bool outputs);

		[PreserveSig]
		[Token(Token = "0x600059B")]
		[Address(RVA = "0x15740BC", Offset = "0x15740BC", VA = "0x15740BC")]
		private static extern RESULT FMOD5_DSP_GetNumInputs(IntPtr dsp, out int numinputs);

		[PreserveSig]
		[Token(Token = "0x600059C")]
		[Address(RVA = "0x1574154", Offset = "0x1574154", VA = "0x1574154")]
		private static extern RESULT FMOD5_DSP_GetNumOutputs(IntPtr dsp, out int numoutputs);

		[PreserveSig]
		[Token(Token = "0x600059D")]
		[Address(RVA = "0x15741EC", Offset = "0x15741EC", VA = "0x15741EC")]
		private static extern RESULT FMOD5_DSP_GetInput(IntPtr dsp, int index, out IntPtr input, out IntPtr inputconnection);

		[PreserveSig]
		[Token(Token = "0x600059E")]
		[Address(RVA = "0x157429C", Offset = "0x157429C", VA = "0x157429C")]
		private static extern RESULT FMOD5_DSP_GetOutput(IntPtr dsp, int index, out IntPtr output, out IntPtr outputconnection);

		[PreserveSig]
		[Token(Token = "0x600059F")]
		[Address(RVA = "0x1574350", Offset = "0x1574350", VA = "0x1574350")]
		private static extern RESULT FMOD5_DSP_SetActive(IntPtr dsp, bool active);

		[PreserveSig]
		[Token(Token = "0x60005A0")]
		[Address(RVA = "0x15743E8", Offset = "0x15743E8", VA = "0x15743E8")]
		private static extern RESULT FMOD5_DSP_GetActive(IntPtr dsp, out bool active);

		[PreserveSig]
		[Token(Token = "0x60005A1")]
		[Address(RVA = "0x1574498", Offset = "0x1574498", VA = "0x1574498")]
		private static extern RESULT FMOD5_DSP_SetBypass(IntPtr dsp, bool bypass);

		[PreserveSig]
		[Token(Token = "0x60005A2")]
		[Address(RVA = "0x1574530", Offset = "0x1574530", VA = "0x1574530")]
		private static extern RESULT FMOD5_DSP_GetBypass(IntPtr dsp, out bool bypass);

		[PreserveSig]
		[Token(Token = "0x60005A3")]
		[Address(RVA = "0x15745DC", Offset = "0x15745DC", VA = "0x15745DC")]
		private static extern RESULT FMOD5_DSP_SetWetDryMix(IntPtr dsp, float prewet, float postwet, float dry);

		[PreserveSig]
		[Token(Token = "0x60005A4")]
		[Address(RVA = "0x157468C", Offset = "0x157468C", VA = "0x157468C")]
		private static extern RESULT FMOD5_DSP_GetWetDryMix(IntPtr dsp, out float prewet, out float postwet, out float dry);

		[PreserveSig]
		[Token(Token = "0x60005A5")]
		[Address(RVA = "0x157473C", Offset = "0x157473C", VA = "0x157473C")]
		private static extern RESULT FMOD5_DSP_SetChannelFormat(IntPtr dsp, CHANNELMASK channelmask, int numchannels, SPEAKERMODE source_speakermode);

		[PreserveSig]
		[Token(Token = "0x60005A6")]
		[Address(RVA = "0x15747EC", Offset = "0x15747EC", VA = "0x15747EC")]
		private static extern RESULT FMOD5_DSP_GetChannelFormat(IntPtr dsp, out CHANNELMASK channelmask, out int numchannels, out SPEAKERMODE source_speakermode);

		[PreserveSig]
		[Token(Token = "0x60005A7")]
		[Address(RVA = "0x157489C", Offset = "0x157489C", VA = "0x157489C")]
		private static extern RESULT FMOD5_DSP_GetOutputChannelFormat(IntPtr dsp, CHANNELMASK inmask, int inchannels, SPEAKERMODE inspeakermode, out CHANNELMASK outmask, out int outchannels, out SPEAKERMODE outspeakermode);

		[PreserveSig]
		[Token(Token = "0x60005A8")]
		[Address(RVA = "0x157496C", Offset = "0x157496C", VA = "0x157496C")]
		private static extern RESULT FMOD5_DSP_Reset(IntPtr dsp);

		[PreserveSig]
		[Token(Token = "0x60005A9")]
		[Address(RVA = "0x15749F4", Offset = "0x15749F4", VA = "0x15749F4")]
		private static extern RESULT FMOD5_DSP_SetParameterFloat(IntPtr dsp, int index, float value);

		[PreserveSig]
		[Token(Token = "0x60005AA")]
		[Address(RVA = "0x1574A9C", Offset = "0x1574A9C", VA = "0x1574A9C")]
		private static extern RESULT FMOD5_DSP_SetParameterInt(IntPtr dsp, int index, int value);

		[PreserveSig]
		[Token(Token = "0x60005AB")]
		[Address(RVA = "0x1574B40", Offset = "0x1574B40", VA = "0x1574B40")]
		private static extern RESULT FMOD5_DSP_SetParameterBool(IntPtr dsp, int index, bool value);

		[PreserveSig]
		[Token(Token = "0x60005AC")]
		[Address(RVA = "0x1574C7C", Offset = "0x1574C7C", VA = "0x1574C7C")]
		private static extern RESULT FMOD5_DSP_SetParameterData(IntPtr dsp, int index, IntPtr data, uint length);

		[PreserveSig]
		[Token(Token = "0x60005AD")]
		[Address(RVA = "0x1574D88", Offset = "0x1574D88", VA = "0x1574D88")]
		private static extern RESULT FMOD5_DSP_GetParameterFloat(IntPtr dsp, int index, out float value, IntPtr valuestr, int valuestrlen);

		[PreserveSig]
		[Token(Token = "0x60005AE")]
		[Address(RVA = "0x1574E9C", Offset = "0x1574E9C", VA = "0x1574E9C")]
		private static extern RESULT FMOD5_DSP_GetParameterInt(IntPtr dsp, int index, out int value, IntPtr valuestr, int valuestrlen);

		[PreserveSig]
		[Token(Token = "0x60005AF")]
		[Address(RVA = "0x1574FB0", Offset = "0x1574FB0", VA = "0x1574FB0")]
		private static extern RESULT FMOD5_DSP_GetParameterBool(IntPtr dsp, int index, out bool value, IntPtr valuestr, int valuestrlen);

		[PreserveSig]
		[Token(Token = "0x60005B0")]
		[Address(RVA = "0x15750E8", Offset = "0x15750E8", VA = "0x15750E8")]
		private static extern RESULT FMOD5_DSP_GetParameterData(IntPtr dsp, int index, out IntPtr data, out uint length, IntPtr valuestr, int valuestrlen);

		[PreserveSig]
		[Token(Token = "0x60005B1")]
		[Address(RVA = "0x15751B0", Offset = "0x15751B0", VA = "0x15751B0")]
		private static extern RESULT FMOD5_DSP_GetNumParameters(IntPtr dsp, out int numparams);

		[PreserveSig]
		[Token(Token = "0x60005B2")]
		[Address(RVA = "0x1575248", Offset = "0x1575248", VA = "0x1575248")]
		private static extern RESULT FMOD5_DSP_GetParameterInfo(IntPtr dsp, int index, out DSP_PARAMETER_DESC desc);

		[PreserveSig]
		[Token(Token = "0x60005B3")]
		[Address(RVA = "0x1575348", Offset = "0x1575348", VA = "0x1575348")]
		private static extern RESULT FMOD5_DSP_GetDataParameterIndex(IntPtr dsp, int datatype, out int index);

		[PreserveSig]
		[Token(Token = "0x60005B4")]
		[Address(RVA = "0x15753EC", Offset = "0x15753EC", VA = "0x15753EC")]
		private static extern RESULT FMOD5_DSP_ShowConfigDialog(IntPtr dsp, IntPtr hwnd, bool show);

		[PreserveSig]
		[Token(Token = "0x60005B5")]
		[Address(RVA = "0x1575664", Offset = "0x1575664", VA = "0x1575664")]
		private static extern RESULT FMOD5_DSP_GetInfo(IntPtr dsp, IntPtr name, out uint version, out int channels, out int configwidth, out int configheight);

		[PreserveSig]
		[Token(Token = "0x60005B6")]
		[Address(RVA = "0x15757A4", Offset = "0x15757A4", VA = "0x15757A4")]
		private static extern RESULT FMOD5_DSP_GetType(IntPtr dsp, out DSP_TYPE type);

		[PreserveSig]
		[Token(Token = "0x60005B7")]
		[Address(RVA = "0x157583C", Offset = "0x157583C", VA = "0x157583C")]
		private static extern RESULT FMOD5_DSP_GetIdle(IntPtr dsp, out bool idle);

		[PreserveSig]
		[Token(Token = "0x60005B8")]
		[Address(RVA = "0x15758E8", Offset = "0x15758E8", VA = "0x15758E8")]
		private static extern RESULT FMOD5_DSP_SetUserData(IntPtr dsp, IntPtr userdata);

		[PreserveSig]
		[Token(Token = "0x60005B9")]
		[Address(RVA = "0x1575980", Offset = "0x1575980", VA = "0x1575980")]
		private static extern RESULT FMOD5_DSP_GetUserData(IntPtr dsp, out IntPtr userdata);

		[PreserveSig]
		[Token(Token = "0x60005BA")]
		[Address(RVA = "0x1575A20", Offset = "0x1575A20", VA = "0x1575A20")]
		public static extern RESULT FMOD5_DSP_SetMeteringEnabled(IntPtr dsp, bool inputEnabled, bool outputEnabled);

		[PreserveSig]
		[Token(Token = "0x60005BB")]
		[Address(RVA = "0x1575AC0", Offset = "0x1575AC0", VA = "0x1575AC0")]
		public static extern RESULT FMOD5_DSP_GetMeteringEnabled(IntPtr dsp, out bool inputEnabled, out bool outputEnabled);

		[PreserveSig]
		[Token(Token = "0x60005BC")]
		[Address(RVA = "0x1575B84", Offset = "0x1575B84", VA = "0x1575B84")]
		public static extern RESULT FMOD5_DSP_GetMeteringInfo(IntPtr dsp, IntPtr zero, out DSP_METERING_INFO outputInfo);

		[PreserveSig]
		[Token(Token = "0x60005BD")]
		[Address(RVA = "0x1575C74", Offset = "0x1575C74", VA = "0x1575C74")]
		public static extern RESULT FMOD5_DSP_GetMeteringInfo(IntPtr dsp, out DSP_METERING_INFO inputInfo, IntPtr zero);

		[PreserveSig]
		[Token(Token = "0x60005BE")]
		[Address(RVA = "0x1575D64", Offset = "0x1575D64", VA = "0x1575D64")]
		public static extern RESULT FMOD5_DSP_GetMeteringInfo(IntPtr dsp, out DSP_METERING_INFO inputInfo, out DSP_METERING_INFO outputInfo);

		[PreserveSig]
		[Token(Token = "0x60005BF")]
		[Address(RVA = "0x1575E84", Offset = "0x1575E84", VA = "0x1575E84")]
		public static extern RESULT FMOD5_DSP_GetCPUUsage(IntPtr dsp, out uint exclusive, out uint inclusive);

		[Token(Token = "0x60005C0")]
		[Address(RVA = "0x1575F1C", Offset = "0x1575F1C", VA = "0x1575F1C")]
		public bool hasHandle()
		{
			return default(bool);
		}

		[Token(Token = "0x60005C1")]
		[Address(RVA = "0x1575F68", Offset = "0x1575F68", VA = "0x1575F68")]
		public void clearHandle()
		{
		}
	}
	[Token(Token = "0x2000073")]
	public struct DSPConnection
	{
		[Token(Token = "0x40002C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public IntPtr handle;

		[Token(Token = "0x60005C2")]
		[Address(RVA = "0x1575FAC", Offset = "0x1575FAC", VA = "0x1575FAC")]
		public RESULT getInput(out DSP input)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60005C3")]
		[Address(RVA = "0x1576044", Offset = "0x1576044", VA = "0x1576044")]
		public RESULT getOutput(out DSP output)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60005C4")]
		[Address(RVA = "0x15760DC", Offset = "0x15760DC", VA = "0x15760DC")]
		public RESULT setMix(float volume)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60005C5")]
		[Address(RVA = "0x1576174", Offset = "0x1576174", VA = "0x1576174")]
		public RESULT getMix(out float volume)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60005C6")]
		[Address(RVA = "0x157620C", Offset = "0x157620C", VA = "0x157620C")]
		public RESULT setMixMatrix(float[] matrix, int outchannels, int inchannels, int inchannel_hop = 0)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60005C7")]
		[Address(RVA = "0x15762CC", Offset = "0x15762CC", VA = "0x15762CC")]
		public RESULT getMixMatrix(float[] matrix, out int outchannels, out int inchannels, int inchannel_hop = 0)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60005C8")]
		[Address(RVA = "0x157638C", Offset = "0x157638C", VA = "0x157638C")]
		public RESULT getType(out DSPCONNECTION_TYPE type)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60005C9")]
		[Address(RVA = "0x1576424", Offset = "0x1576424", VA = "0x1576424")]
		public RESULT setUserData(IntPtr userdata)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60005CA")]
		[Address(RVA = "0x15764BC", Offset = "0x15764BC", VA = "0x15764BC")]
		public RESULT getUserData(out IntPtr userdata)
		{
			return default(RESULT);
		}

		[PreserveSig]
		[Token(Token = "0x60005CB")]
		[Address(RVA = "0x1575FB4", Offset = "0x1575FB4", VA = "0x1575FB4")]
		private static extern RESULT FMOD5_DSPConnection_GetInput(IntPtr dspconnection, out IntPtr input);

		[PreserveSig]
		[Token(Token = "0x60005CC")]
		[Address(RVA = "0x157604C", Offset = "0x157604C", VA = "0x157604C")]
		private static extern RESULT FMOD5_DSPConnection_GetOutput(IntPtr dspconnection, out IntPtr output);

		[PreserveSig]
		[Token(Token = "0x60005CD")]
		[Address(RVA = "0x15760E4", Offset = "0x15760E4", VA = "0x15760E4")]
		private static extern RESULT FMOD5_DSPConnection_SetMix(IntPtr dspconnection, float volume);

		[PreserveSig]
		[Token(Token = "0x60005CE")]
		[Address(RVA = "0x157617C", Offset = "0x157617C", VA = "0x157617C")]
		private static extern RESULT FMOD5_DSPConnection_GetMix(IntPtr dspconnection, out float volume);

		[PreserveSig]
		[Token(Token = "0x60005CF")]
		[Address(RVA = "0x1576214", Offset = "0x1576214", VA = "0x1576214")]
		private static extern RESULT FMOD5_DSPConnection_SetMixMatrix(IntPtr dspconnection, float[] matrix, int outchannels, int inchannels, int inchannel_hop);

		[PreserveSig]
		[Token(Token = "0x60005D0")]
		[Address(RVA = "0x15762D4", Offset = "0x15762D4", VA = "0x15762D4")]
		private static extern RESULT FMOD5_DSPConnection_GetMixMatrix(IntPtr dspconnection, float[] matrix, out int outchannels, out int inchannels, int inchannel_hop);

		[PreserveSig]
		[Token(Token = "0x60005D1")]
		[Address(RVA = "0x1576394", Offset = "0x1576394", VA = "0x1576394")]
		private static extern RESULT FMOD5_DSPConnection_GetType(IntPtr dspconnection, out DSPCONNECTION_TYPE type);

		[PreserveSig]
		[Token(Token = "0x60005D2")]
		[Address(RVA = "0x157642C", Offset = "0x157642C", VA = "0x157642C")]
		private static extern RESULT FMOD5_DSPConnection_SetUserData(IntPtr dspconnection, IntPtr userdata);

		[PreserveSig]
		[Token(Token = "0x60005D3")]
		[Address(RVA = "0x15764C4", Offset = "0x15764C4", VA = "0x15764C4")]
		private static extern RESULT FMOD5_DSPConnection_GetUserData(IntPtr dspconnection, out IntPtr userdata);

		[Token(Token = "0x60005D4")]
		[Address(RVA = "0x1576554", Offset = "0x1576554", VA = "0x1576554")]
		public bool hasHandle()
		{
			return default(bool);
		}

		[Token(Token = "0x60005D5")]
		[Address(RVA = "0x15765A0", Offset = "0x15765A0", VA = "0x15765A0")]
		public void clearHandle()
		{
		}
	}
	[Token(Token = "0x2000074")]
	public struct Geometry
	{
		[Token(Token = "0x40002C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public IntPtr handle;

		[Token(Token = "0x60005D6")]
		[Address(RVA = "0x1581680", Offset = "0x1581680", VA = "0x1581680")]
		public RESULT release()
		{
			return default(RESULT);
		}

		[Token(Token = "0x60005D7")]
		[Address(RVA = "0x1581708", Offset = "0x1581708", VA = "0x1581708")]
		public RESULT addPolygon(float directocclusion, float reverbocclusion, bool doublesided, int numvertices, VECTOR[] vertices, out int polygonindex)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60005D8")]
		[Address(RVA = "0x15817E4", Offset = "0x15817E4", VA = "0x15817E4")]
		public RESULT getNumPolygons(out int numpolygons)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60005D9")]
		[Address(RVA = "0x158187C", Offset = "0x158187C", VA = "0x158187C")]
		public RESULT getMaxPolygons(out int maxpolygons, out int maxvertices)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60005DA")]
		[Address(RVA = "0x158191C", Offset = "0x158191C", VA = "0x158191C")]
		public RESULT getPolygonNumVertices(int index, out int numvertices)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60005DB")]
		[Address(RVA = "0x15819BC", Offset = "0x15819BC", VA = "0x15819BC")]
		public RESULT setPolygonVertex(int index, int vertexindex, ref VECTOR vertex)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60005DC")]
		[Address(RVA = "0x1581A6C", Offset = "0x1581A6C", VA = "0x1581A6C")]
		public RESULT getPolygonVertex(int index, int vertexindex, out VECTOR vertex)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60005DD")]
		[Address(RVA = "0x1581B1C", Offset = "0x1581B1C", VA = "0x1581B1C")]
		public RESULT setPolygonAttributes(int index, float directocclusion, float reverbocclusion, bool doublesided)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60005DE")]
		[Address(RVA = "0x1581BD8", Offset = "0x1581BD8", VA = "0x1581BD8")]
		public RESULT getPolygonAttributes(int index, out float directocclusion, out float reverbocclusion, out bool doublesided)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60005DF")]
		[Address(RVA = "0x1581CA4", Offset = "0x1581CA4", VA = "0x1581CA4")]
		public RESULT setActive(bool active)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60005E0")]
		[Address(RVA = "0x1581D40", Offset = "0x1581D40", VA = "0x1581D40")]
		public RESULT getActive(out bool active)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60005E1")]
		[Address(RVA = "0x1581DEC", Offset = "0x1581DEC", VA = "0x1581DEC")]
		public RESULT setRotation(ref VECTOR forward, ref VECTOR up)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60005E2")]
		[Address(RVA = "0x1581E8C", Offset = "0x1581E8C", VA = "0x1581E8C")]
		public RESULT getRotation(out VECTOR forward, out VECTOR up)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60005E3")]
		[Address(RVA = "0x1581F2C", Offset = "0x1581F2C", VA = "0x1581F2C")]
		public RESULT setPosition(ref VECTOR position)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60005E4")]
		[Address(RVA = "0x1581FC4", Offset = "0x1581FC4", VA = "0x1581FC4")]
		public RESULT getPosition(out VECTOR position)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60005E5")]
		[Address(RVA = "0x158205C", Offset = "0x158205C", VA = "0x158205C")]
		public RESULT setScale(ref VECTOR scale)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60005E6")]
		[Address(RVA = "0x15820F4", Offset = "0x15820F4", VA = "0x15820F4")]
		public RESULT getScale(out VECTOR scale)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60005E7")]
		[Address(RVA = "0x158218C", Offset = "0x158218C", VA = "0x158218C")]
		public RESULT save(IntPtr data, out int datasize)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60005E8")]
		[Address(RVA = "0x158222C", Offset = "0x158222C", VA = "0x158222C")]
		public RESULT setUserData(IntPtr userdata)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60005E9")]
		[Address(RVA = "0x15822C4", Offset = "0x15822C4", VA = "0x15822C4")]
		public RESULT getUserData(out IntPtr userdata)
		{
			return default(RESULT);
		}

		[PreserveSig]
		[Token(Token = "0x60005EA")]
		[Address(RVA = "0x1581688", Offset = "0x1581688", VA = "0x1581688")]
		private static extern RESULT FMOD5_Geometry_Release(IntPtr geometry);

		[PreserveSig]
		[Token(Token = "0x60005EB")]
		[Address(RVA = "0x1581714", Offset = "0x1581714", VA = "0x1581714")]
		private static extern RESULT FMOD5_Geometry_AddPolygon(IntPtr geometry, float directocclusion, float reverbocclusion, bool doublesided, int numvertices, VECTOR[] vertices, out int polygonindex);

		[PreserveSig]
		[Token(Token = "0x60005EC")]
		[Address(RVA = "0x15817EC", Offset = "0x15817EC", VA = "0x15817EC")]
		private static extern RESULT FMOD5_Geometry_GetNumPolygons(IntPtr geometry, out int numpolygons);

		[PreserveSig]
		[Token(Token = "0x60005ED")]
		[Address(RVA = "0x1581884", Offset = "0x1581884", VA = "0x1581884")]
		private static extern RESULT FMOD5_Geometry_GetMaxPolygons(IntPtr geometry, out int maxpolygons, out int maxvertices);

		[PreserveSig]
		[Token(Token = "0x60005EE")]
		[Address(RVA = "0x1581924", Offset = "0x1581924", VA = "0x1581924")]
		private static extern RESULT FMOD5_Geometry_GetPolygonNumVertices(IntPtr geometry, int index, out int numvertices);

		[PreserveSig]
		[Token(Token = "0x60005EF")]
		[Address(RVA = "0x15819C4", Offset = "0x15819C4", VA = "0x15819C4")]
		private static extern RESULT FMOD5_Geometry_SetPolygonVertex(IntPtr geometry, int index, int vertexindex, ref VECTOR vertex);

		[PreserveSig]
		[Token(Token = "0x60005F0")]
		[Address(RVA = "0x1581A74", Offset = "0x1581A74", VA = "0x1581A74")]
		private static extern RESULT FMOD5_Geometry_GetPolygonVertex(IntPtr geometry, int index, int vertexindex, out VECTOR vertex);

		[PreserveSig]
		[Token(Token = "0x60005F1")]
		[Address(RVA = "0x1581B28", Offset = "0x1581B28", VA = "0x1581B28")]
		private static extern RESULT FMOD5_Geometry_SetPolygonAttributes(IntPtr geometry, int index, float directocclusion, float reverbocclusion, bool doublesided);

		[PreserveSig]
		[Token(Token = "0x60005F2")]
		[Address(RVA = "0x1581BE0", Offset = "0x1581BE0", VA = "0x1581BE0")]
		private static extern RESULT FMOD5_Geometry_GetPolygonAttributes(IntPtr geometry, int index, out float directocclusion, out float reverbocclusion, out bool doublesided);

		[PreserveSig]
		[Token(Token = "0x60005F3")]
		[Address(RVA = "0x1581CB0", Offset = "0x1581CB0", VA = "0x1581CB0")]
		private static extern RESULT FMOD5_Geometry_SetActive(IntPtr geometry, bool active);

		[PreserveSig]
		[Token(Token = "0x60005F4")]
		[Address(RVA = "0x1581D48", Offset = "0x1581D48", VA = "0x1581D48")]
		private static extern RESULT FMOD5_Geometry_GetActive(IntPtr geometry, out bool active);

		[PreserveSig]
		[Token(Token = "0x60005F5")]
		[Address(RVA = "0x1581DF4", Offset = "0x1581DF4", VA = "0x1581DF4")]
		private static extern RESULT FMOD5_Geometry_SetRotation(IntPtr geometry, ref VECTOR forward, ref VECTOR up);

		[PreserveSig]
		[Token(Token = "0x60005F6")]
		[Address(RVA = "0x1581E94", Offset = "0x1581E94", VA = "0x1581E94")]
		private static extern RESULT FMOD5_Geometry_GetRotation(IntPtr geometry, out VECTOR forward, out VECTOR up);

		[PreserveSig]
		[Token(Token = "0x60005F7")]
		[Address(RVA = "0x1581F34", Offset = "0x1581F34", VA = "0x1581F34")]
		private static extern RESULT FMOD5_Geometry_SetPosition(IntPtr geometry, ref VECTOR position);

		[PreserveSig]
		[Token(Token = "0x60005F8")]
		[Address(RVA = "0x1581FCC", Offset = "0x1581FCC", VA = "0x1581FCC")]
		private static extern RESULT FMOD5_Geometry_GetPosition(IntPtr geometry, out VECTOR position);

		[PreserveSig]
		[Token(Token = "0x60005F9")]
		[Address(RVA = "0x1582064", Offset = "0x1582064", VA = "0x1582064")]
		private static extern RESULT FMOD5_Geometry_SetScale(IntPtr geometry, ref VECTOR scale);

		[PreserveSig]
		[Token(Token = "0x60005FA")]
		[Address(RVA = "0x15820FC", Offset = "0x15820FC", VA = "0x15820FC")]
		private static extern RESULT FMOD5_Geometry_GetScale(IntPtr geometry, out VECTOR scale);

		[PreserveSig]
		[Token(Token = "0x60005FB")]
		[Address(RVA = "0x1582194", Offset = "0x1582194", VA = "0x1582194")]
		private static extern RESULT FMOD5_Geometry_Save(IntPtr geometry, IntPtr data, out int datasize);

		[PreserveSig]
		[Token(Token = "0x60005FC")]
		[Address(RVA = "0x1582234", Offset = "0x1582234", VA = "0x1582234")]
		private static extern RESULT FMOD5_Geometry_SetUserData(IntPtr geometry, IntPtr userdata);

		[PreserveSig]
		[Token(Token = "0x60005FD")]
		[Address(RVA = "0x15822CC", Offset = "0x15822CC", VA = "0x15822CC")]
		private static extern RESULT FMOD5_Geometry_GetUserData(IntPtr geometry, out IntPtr userdata);

		[Token(Token = "0x60005FE")]
		[Address(RVA = "0x158235C", Offset = "0x158235C", VA = "0x158235C")]
		public bool hasHandle()
		{
			return default(bool);
		}

		[Token(Token = "0x60005FF")]
		[Address(RVA = "0x15823A8", Offset = "0x15823A8", VA = "0x15823A8")]
		public void clearHandle()
		{
		}
	}
	[Token(Token = "0x2000075")]
	public struct Reverb3D
	{
		[Token(Token = "0x40002C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public IntPtr handle;

		[Token(Token = "0x6000600")]
		[Address(RVA = "0x158340C", Offset = "0x158340C", VA = "0x158340C")]
		public RESULT release()
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000601")]
		[Address(RVA = "0x1583494", Offset = "0x1583494", VA = "0x1583494")]
		public RESULT set3DAttributes(ref VECTOR position, float mindistance, float maxdistance)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000602")]
		[Address(RVA = "0x1583544", Offset = "0x1583544", VA = "0x1583544")]
		public RESULT get3DAttributes(ref VECTOR position, ref float mindistance, ref float maxdistance)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000603")]
		[Address(RVA = "0x15835F4", Offset = "0x15835F4", VA = "0x15835F4")]
		public RESULT setProperties(ref REVERB_PROPERTIES properties)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000604")]
		[Address(RVA = "0x158368C", Offset = "0x158368C", VA = "0x158368C")]
		public RESULT getProperties(ref REVERB_PROPERTIES properties)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000605")]
		[Address(RVA = "0x1583724", Offset = "0x1583724", VA = "0x1583724")]
		public RESULT setActive(bool active)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000606")]
		[Address(RVA = "0x15837C0", Offset = "0x15837C0", VA = "0x15837C0")]
		public RESULT getActive(out bool active)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000607")]
		[Address(RVA = "0x158386C", Offset = "0x158386C", VA = "0x158386C")]
		public RESULT setUserData(IntPtr userdata)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000608")]
		[Address(RVA = "0x1583904", Offset = "0x1583904", VA = "0x1583904")]
		public RESULT getUserData(out IntPtr userdata)
		{
			return default(RESULT);
		}

		[PreserveSig]
		[Token(Token = "0x6000609")]
		[Address(RVA = "0x1583414", Offset = "0x1583414", VA = "0x1583414")]
		private static extern RESULT FMOD5_Reverb3D_Release(IntPtr reverb3d);

		[PreserveSig]
		[Token(Token = "0x600060A")]
		[Address(RVA = "0x158349C", Offset = "0x158349C", VA = "0x158349C")]
		private static extern RESULT FMOD5_Reverb3D_Set3DAttributes(IntPtr reverb3d, ref VECTOR position, float mindistance, float maxdistance);

		[PreserveSig]
		[Token(Token = "0x600060B")]
		[Address(RVA = "0x158354C", Offset = "0x158354C", VA = "0x158354C")]
		private static extern RESULT FMOD5_Reverb3D_Get3DAttributes(IntPtr reverb3d, ref VECTOR position, ref float mindistance, ref float maxdistance);

		[PreserveSig]
		[Token(Token = "0x600060C")]
		[Address(RVA = "0x15835FC", Offset = "0x15835FC", VA = "0x15835FC")]
		private static extern RESULT FMOD5_Reverb3D_SetProperties(IntPtr reverb3d, ref REVERB_PROPERTIES properties);

		[PreserveSig]
		[Token(Token = "0x600060D")]
		[Address(RVA = "0x1583694", Offset = "0x1583694", VA = "0x1583694")]
		private static extern RESULT FMOD5_Reverb3D_GetProperties(IntPtr reverb3d, ref REVERB_PROPERTIES properties);

		[PreserveSig]
		[Token(Token = "0x600060E")]
		[Address(RVA = "0x1583730", Offset = "0x1583730", VA = "0x1583730")]
		private static extern RESULT FMOD5_Reverb3D_SetActive(IntPtr reverb3d, bool active);

		[PreserveSig]
		[Token(Token = "0x600060F")]
		[Address(RVA = "0x15837C8", Offset = "0x15837C8", VA = "0x15837C8")]
		private static extern RESULT FMOD5_Reverb3D_GetActive(IntPtr reverb3d, out bool active);

		[PreserveSig]
		[Token(Token = "0x6000610")]
		[Address(RVA = "0x1583874", Offset = "0x1583874", VA = "0x1583874")]
		private static extern RESULT FMOD5_Reverb3D_SetUserData(IntPtr reverb3d, IntPtr userdata);

		[PreserveSig]
		[Token(Token = "0x6000611")]
		[Address(RVA = "0x158390C", Offset = "0x158390C", VA = "0x158390C")]
		private static extern RESULT FMOD5_Reverb3D_GetUserData(IntPtr reverb3d, out IntPtr userdata);

		[Token(Token = "0x6000612")]
		[Address(RVA = "0x158399C", Offset = "0x158399C", VA = "0x158399C")]
		public bool hasHandle()
		{
			return default(bool);
		}

		[Token(Token = "0x6000613")]
		[Address(RVA = "0x15839E8", Offset = "0x15839E8", VA = "0x15839E8")]
		public void clearHandle()
		{
		}
	}
	[Token(Token = "0x2000076")]
	public struct StringWrapper
	{
		[Token(Token = "0x40002C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private IntPtr nativeUtf8Ptr;

		[Token(Token = "0x6000614")]
		[Address(RVA = "0x1587D98", Offset = "0x1587D98", VA = "0x1587D98")]
		public static implicit operator string(StringWrapper fstring)
		{
			return null;
		}
	}
	[Token(Token = "0x2000077")]
	internal static class StringHelper
	{
		[Token(Token = "0x2000148")]
		public class ThreadSafeEncoding : IDisposable
		{
			[Token(Token = "0x40006CE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private UTF8Encoding encoding;

			[Token(Token = "0x40006CF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private byte[] encodedBuffer;

			[Token(Token = "0x40006D0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private char[] decodedBuffer;

			[Token(Token = "0x40006D1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private bool inUse;

			[Token(Token = "0x40006D2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			private GCHandle gcHandle;

			[Token(Token = "0x6000930")]
			[Address(RVA = "0x1587BF8", Offset = "0x1587BF8", VA = "0x1587BF8")]
			public bool InUse()
			{
				return default(bool);
			}

			[Token(Token = "0x6000931")]
			[Address(RVA = "0x1587B70", Offset = "0x1587B70", VA = "0x1587B70")]
			public void SetInUse()
			{
			}

			[Token(Token = "0x6000932")]
			[Address(RVA = "0x1587C00", Offset = "0x1587C00", VA = "0x1587C00")]
			private int roundUpPowerTwo(int number)
			{
				return default(int);
			}

			[Token(Token = "0x6000933")]
			[Address(RVA = "0x157FA3C", Offset = "0x157FA3C", VA = "0x157FA3C")]
			public byte[] byteFromStringUTF8(string s)
			{
				return null;
			}

			[Token(Token = "0x6000934")]
			[Address(RVA = "0x1587C18", Offset = "0x1587C18", VA = "0x1587C18")]
			public IntPtr intptrFromStringUTF8(string s)
			{
				return default(IntPtr);
			}

			[Token(Token = "0x6000935")]
			[Address(RVA = "0x1585478", Offset = "0x1585478", VA = "0x1585478")]
			public string stringFromNative(IntPtr nativePtr)
			{
				return null;
			}

			[Token(Token = "0x6000936")]
			[Address(RVA = "0x1587CA4", Offset = "0x1587CA4", VA = "0x1587CA4", Slot = "4")]
			public void Dispose()
			{
			}

			[Token(Token = "0x6000937")]
			[Address(RVA = "0x1587AB4", Offset = "0x1587AB4", VA = "0x1587AB4")]
			public ThreadSafeEncoding()
			{
			}
		}

		[Token(Token = "0x40002C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static List<ThreadSafeEncoding> encoders;

		[Token(Token = "0x6000615")]
		[Address(RVA = "0x157F7CC", Offset = "0x157F7CC", VA = "0x157F7CC")]
		public static ThreadSafeEncoding GetFreeHelper()
		{
			return null;
		}
	}
	[Token(Token = "0x2000078")]
	internal static class Android
	{
		[Token(Token = "0x2000149")]
		public struct THREADAFFINITY
		{
			[Token(Token = "0x40006D3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public THREAD mixer;

			[Token(Token = "0x40006D4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public THREAD stream;

			[Token(Token = "0x40006D5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public THREAD nonblocking;

			[Token(Token = "0x40006D6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public THREAD file;

			[Token(Token = "0x40006D7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public THREAD geometry;

			[Token(Token = "0x40006D8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public THREAD profiler;

			[Token(Token = "0x40006D9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public THREAD studioUpdate;

			[Token(Token = "0x40006DA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public THREAD studioLoadBank;

			[Token(Token = "0x40006DB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public THREAD studioLoadSample;
		}

		[Token(Token = "0x200014A")]
		[Flags]
		public enum THREAD : uint
		{
			[Token(Token = "0x40006DD")]
			DEFAULT = 0u,
			[Token(Token = "0x40006DE")]
			CORE0 = 1u,
			[Token(Token = "0x40006DF")]
			CORE1 = 2u,
			[Token(Token = "0x40006E0")]
			CORE2 = 4u,
			[Token(Token = "0x40006E1")]
			CORE3 = 8u,
			[Token(Token = "0x40006E2")]
			CORE4 = 0x10u,
			[Token(Token = "0x40006E3")]
			CORE5 = 0x20u,
			[Token(Token = "0x40006E4")]
			CORE6 = 0x40u,
			[Token(Token = "0x40006E5")]
			CORE7 = 0x80u
		}

		[Token(Token = "0x6000617")]
		[Address(RVA = "0x156CEBC", Offset = "0x156CEBC", VA = "0x156CEBC")]
		public static RESULT setThreadAffinity(ref THREADAFFINITY affinity)
		{
			return default(RESULT);
		}

		[PreserveSig]
		[Token(Token = "0x6000618")]
		[Address(RVA = "0x156CEC0", Offset = "0x156CEC0", VA = "0x156CEC0")]
		private static extern RESULT FMOD_Android_SetThreadAffinity(ref THREADAFFINITY affinity);
	}
	[Token(Token = "0x2000079")]
	public struct DSP_BUFFER_ARRAY
	{
		[Token(Token = "0x40002CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int numbuffers;

		[Token(Token = "0x40002CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public int[] buffernumchannels;

		[Token(Token = "0x40002CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public CHANNELMASK[] bufferchannelmask;

		[Token(Token = "0x40002CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public IntPtr[] buffers;

		[Token(Token = "0x40002CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public SPEAKERMODE speakermode;
	}
	[Token(Token = "0x200007A")]
	public enum DSP_PROCESS_OPERATION
	{
		[Token(Token = "0x40002D0")]
		PROCESS_PERFORM,
		[Token(Token = "0x40002D1")]
		PROCESS_QUERY
	}
	[Token(Token = "0x200007B")]
	public struct COMPLEX
	{
		[Token(Token = "0x40002D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float real;

		[Token(Token = "0x40002D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public float imag;
	}
	[Token(Token = "0x200007C")]
	public enum DSP_PAN_SURROUND_FLAGS
	{
		[Token(Token = "0x40002D5")]
		DEFAULT,
		[Token(Token = "0x40002D6")]
		ROTATION_NOT_BIASED
	}
	[Token(Token = "0x200007D")]
	public delegate RESULT DSP_CREATECALLBACK(ref DSP_STATE dsp_state);
	[Token(Token = "0x200007E")]
	public delegate RESULT DSP_RELEASECALLBACK(ref DSP_STATE dsp_state);
	[Token(Token = "0x200007F")]
	public delegate RESULT DSP_RESETCALLBACK(ref DSP_STATE dsp_state);
	[Token(Token = "0x2000080")]
	public delegate RESULT DSP_SETPOSITIONCALLBACK(ref DSP_STATE dsp_state, uint pos);
	[Token(Token = "0x2000081")]
	public delegate RESULT DSP_READCALLBACK(ref DSP_STATE dsp_state, IntPtr inbuffer, IntPtr outbuffer, uint length, int inchannels, ref int outchannels);
	[Token(Token = "0x2000082")]
	public delegate RESULT DSP_SHOULDIPROCESS_CALLBACK(ref DSP_STATE dsp_state, bool inputsidle, uint length, CHANNELMASK inmask, int inchannels, SPEAKERMODE speakermode);
	[Token(Token = "0x2000083")]
	public delegate RESULT DSP_PROCESS_CALLBACK(ref DSP_STATE dsp_state, uint length, ref DSP_BUFFER_ARRAY inbufferarray, ref DSP_BUFFER_ARRAY outbufferarray, bool inputsidle, DSP_PROCESS_OPERATION op);
	[Token(Token = "0x2000084")]
	public delegate RESULT DSP_SETPARAM_FLOAT_CALLBACK(ref DSP_STATE dsp_state, int index, float value);
	[Token(Token = "0x2000085")]
	public delegate RESULT DSP_SETPARAM_INT_CALLBACK(ref DSP_STATE dsp_state, int index, int value);
	[Token(Token = "0x2000086")]
	public delegate RESULT DSP_SETPARAM_BOOL_CALLBACK(ref DSP_STATE dsp_state, int index, bool value);
	[Token(Token = "0x2000087")]
	public delegate RESULT DSP_SETPARAM_DATA_CALLBACK(ref DSP_STATE dsp_state, int index, IntPtr data, uint length);
	[Token(Token = "0x2000088")]
	public delegate RESULT DSP_GETPARAM_FLOAT_CALLBACK(ref DSP_STATE dsp_state, int index, ref float value, IntPtr valuestr);
	[Token(Token = "0x2000089")]
	public delegate RESULT DSP_GETPARAM_INT_CALLBACK(ref DSP_STATE dsp_state, int index, ref int value, IntPtr valuestr);
	[Token(Token = "0x200008A")]
	public delegate RESULT DSP_GETPARAM_BOOL_CALLBACK(ref DSP_STATE dsp_state, int index, ref bool value, IntPtr valuestr);
	[Token(Token = "0x200008B")]
	public delegate RESULT DSP_GETPARAM_DATA_CALLBACK(ref DSP_STATE dsp_state, int index, ref IntPtr data, ref uint length, IntPtr valuestr);
	[Token(Token = "0x200008C")]
	public delegate RESULT DSP_SYSTEM_REGISTER_CALLBACK(ref DSP_STATE dsp_state);
	[Token(Token = "0x200008D")]
	public delegate RESULT DSP_SYSTEM_DEREGISTER_CALLBACK(ref DSP_STATE dsp_state);
	[Token(Token = "0x200008E")]
	public delegate RESULT DSP_SYSTEM_MIX_CALLBACK(ref DSP_STATE dsp_state, int stage);
	[Token(Token = "0x200008F")]
	public delegate IntPtr DSP_ALLOC_FUNC(uint size, MEMORY_TYPE type, StringWrapper sourcestr);
	[Token(Token = "0x2000090")]
	public delegate IntPtr DSP_REALLOC_FUNC(IntPtr ptr, uint size, MEMORY_TYPE type, StringWrapper sourcestr);
	[Token(Token = "0x2000091")]
	public delegate void DSP_FREE_FUNC(IntPtr ptr, MEMORY_TYPE type, StringWrapper sourcestr);
	[Token(Token = "0x2000092")]
	public delegate void DSP_LOG_FUNC(DEBUG_FLAGS level, StringWrapper file, int line, StringWrapper function, StringWrapper format);
	[Token(Token = "0x2000093")]
	public delegate RESULT DSP_GETSAMPLERATE_FUNC(ref DSP_STATE dsp_state, ref int rate);
	[Token(Token = "0x2000094")]
	public delegate RESULT DSP_GETBLOCKSIZE_FUNC(ref DSP_STATE dsp_state, ref uint blocksize);
	[Token(Token = "0x2000095")]
	public delegate RESULT DSP_GETSPEAKERMODE_FUNC(ref DSP_STATE dsp_state, ref int speakermode_mixer, ref int speakermode_output);
	[Token(Token = "0x2000096")]
	public delegate RESULT DSP_GETCLOCK_FUNC(ref DSP_STATE dsp_state, out ulong clock, out uint offset, out uint length);
	[Token(Token = "0x2000097")]
	public delegate RESULT DSP_GETLISTENERATTRIBUTES_FUNC(ref DSP_STATE dsp_state, ref int numlisteners, IntPtr attributes);
	[Token(Token = "0x2000098")]
	public delegate RESULT DSP_GETUSERDATA_FUNC(ref DSP_STATE dsp_state, out IntPtr userdata);
	[Token(Token = "0x2000099")]
	public delegate RESULT DSP_DFT_FFTREAL_FUNC(ref DSP_STATE dsp_state, int size, IntPtr signal, IntPtr dft, IntPtr window, int signalhop);
	[Token(Token = "0x200009A")]
	public delegate RESULT DSP_DFT_IFFTREAL_FUNC(ref DSP_STATE dsp_state, int size, IntPtr dft, IntPtr signal, IntPtr window, int signalhop);
	[Token(Token = "0x200009B")]
	public delegate RESULT DSP_PAN_SUMMONOMATRIX_FUNC(ref DSP_STATE dsp_state, int sourceSpeakerMode, float lowFrequencyGain, float overallGain, IntPtr matrix);
	[Token(Token = "0x200009C")]
	public delegate RESULT DSP_PAN_SUMSTEREOMATRIX_FUNC(ref DSP_STATE dsp_state, int sourceSpeakerMode, float pan, float lowFrequencyGain, float overallGain, int matrixHop, IntPtr matrix);
	[Token(Token = "0x200009D")]
	public delegate RESULT DSP_PAN_SUMSURROUNDMATRIX_FUNC(ref DSP_STATE dsp_state, int sourceSpeakerMode, int targetSpeakerMode, float direction, float extent, float rotation, float lowFrequencyGain, float overallGain, int matrixHop, IntPtr matrix, DSP_PAN_SURROUND_FLAGS flags);
	[Token(Token = "0x200009E")]
	public delegate RESULT DSP_PAN_SUMMONOTOSURROUNDMATRIX_FUNC(ref DSP_STATE dsp_state, int targetSpeakerMode, float direction, float extent, float lowFrequencyGain, float overallGain, int matrixHop, IntPtr matrix);
	[Token(Token = "0x200009F")]
	public delegate RESULT DSP_PAN_SUMSTEREOTOSURROUNDMATRIX_FUNC(ref DSP_STATE dsp_state, int targetSpeakerMode, float direction, float extent, float rotation, float lowFrequencyGain, float overallGain, int matrixHop, IntPtr matrix);
	[Token(Token = "0x20000A0")]
	public delegate RESULT DSP_PAN_GETROLLOFFGAIN_FUNC(ref DSP_STATE dsp_state, DSP_PAN_3D_ROLLOFF_TYPE rolloff, float distance, float mindistance, float maxdistance, out float gain);
	[Token(Token = "0x20000A1")]
	public enum DSP_TYPE
	{
		[Token(Token = "0x40002D8")]
		UNKNOWN,
		[Token(Token = "0x40002D9")]
		MIXER,
		[Token(Token = "0x40002DA")]
		OSCILLATOR,
		[Token(Token = "0x40002DB")]
		LOWPASS,
		[Token(Token = "0x40002DC")]
		ITLOWPASS,
		[Token(Token = "0x40002DD")]
		HIGHPASS,
		[Token(Token = "0x40002DE")]
		ECHO,
		[Token(Token = "0x40002DF")]
		FADER,
		[Token(Token = "0x40002E0")]
		FLANGE,
		[Token(Token = "0x40002E1")]
		DISTORTION,
		[Token(Token = "0x40002E2")]
		NORMALIZE,
		[Token(Token = "0x40002E3")]
		LIMITER,
		[Token(Token = "0x40002E4")]
		PARAMEQ,
		[Token(Token = "0x40002E5")]
		PITCHSHIFT,
		[Token(Token = "0x40002E6")]
		CHORUS,
		[Token(Token = "0x40002E7")]
		VSTPLUGIN,
		[Token(Token = "0x40002E8")]
		WINAMPPLUGIN,
		[Token(Token = "0x40002E9")]
		ITECHO,
		[Token(Token = "0x40002EA")]
		COMPRESSOR,
		[Token(Token = "0x40002EB")]
		SFXREVERB,
		[Token(Token = "0x40002EC")]
		LOWPASS_SIMPLE,
		[Token(Token = "0x40002ED")]
		DELAY,
		[Token(Token = "0x40002EE")]
		TREMOLO,
		[Token(Token = "0x40002EF")]
		LADSPAPLUGIN,
		[Token(Token = "0x40002F0")]
		SEND,
		[Token(Token = "0x40002F1")]
		RETURN,
		[Token(Token = "0x40002F2")]
		HIGHPASS_SIMPLE,
		[Token(Token = "0x40002F3")]
		PAN,
		[Token(Token = "0x40002F4")]
		THREE_EQ,
		[Token(Token = "0x40002F5")]
		FFT,
		[Token(Token = "0x40002F6")]
		LOUDNESS_METER,
		[Token(Token = "0x40002F7")]
		ENVELOPEFOLLOWER,
		[Token(Token = "0x40002F8")]
		CONVOLUTIONREVERB,
		[Token(Token = "0x40002F9")]
		CHANNELMIX,
		[Token(Token = "0x40002FA")]
		TRANSCEIVER,
		[Token(Token = "0x40002FB")]
		OBJECTPAN,
		[Token(Token = "0x40002FC")]
		MULTIBAND_EQ,
		[Token(Token = "0x40002FD")]
		MAX
	}
	[Token(Token = "0x20000A2")]
	public enum DSP_PARAMETER_TYPE
	{
		[Token(Token = "0x40002FF")]
		FLOAT,
		[Token(Token = "0x4000300")]
		INT,
		[Token(Token = "0x4000301")]
		BOOL,
		[Token(Token = "0x4000302")]
		DATA,
		[Token(Token = "0x4000303")]
		MAX
	}
	[Token(Token = "0x20000A3")]
	public enum DSP_PARAMETER_FLOAT_MAPPING_TYPE
	{
		[Token(Token = "0x4000305")]
		DSP_PARAMETER_FLOAT_MAPPING_TYPE_LINEAR,
		[Token(Token = "0x4000306")]
		DSP_PARAMETER_FLOAT_MAPPING_TYPE_AUTO,
		[Token(Token = "0x4000307")]
		DSP_PARAMETER_FLOAT_MAPPING_TYPE_PIECEWISE_LINEAR
	}
	[Token(Token = "0x20000A4")]
	public struct DSP_PARAMETER_FLOAT_MAPPING_PIECEWISE_LINEAR
	{
		[Token(Token = "0x4000308")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int numpoints;

		[Token(Token = "0x4000309")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public IntPtr pointparamvalues;

		[Token(Token = "0x400030A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public IntPtr pointpositions;
	}
	[Token(Token = "0x20000A5")]
	public struct DSP_PARAMETER_FLOAT_MAPPING
	{
		[Token(Token = "0x400030B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public DSP_PARAMETER_FLOAT_MAPPING_TYPE type;

		[Token(Token = "0x400030C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public DSP_PARAMETER_FLOAT_MAPPING_PIECEWISE_LINEAR piecewiselinearmapping;
	}
	[Token(Token = "0x20000A6")]
	public struct DSP_PARAMETER_DESC_FLOAT
	{
		[Token(Token = "0x400030D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float min;

		[Token(Token = "0x400030E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public float max;

		[Token(Token = "0x400030F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public float defaultval;

		[Token(Token = "0x4000310")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public DSP_PARAMETER_FLOAT_MAPPING mapping;
	}
	[Token(Token = "0x20000A7")]
	public struct DSP_PARAMETER_DESC_INT
	{
		[Token(Token = "0x4000311")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int min;

		[Token(Token = "0x4000312")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public int max;

		[Token(Token = "0x4000313")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public int defaultval;

		[Token(Token = "0x4000314")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public bool goestoinf;

		[Token(Token = "0x4000315")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public IntPtr valuenames;
	}
	[Token(Token = "0x20000A8")]
	public struct DSP_PARAMETER_DESC_BOOL
	{
		[Token(Token = "0x4000316")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public bool defaultval;

		[Token(Token = "0x4000317")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public IntPtr valuenames;
	}
	[Token(Token = "0x20000A9")]
	public struct DSP_PARAMETER_DESC_DATA
	{
		[Token(Token = "0x4000318")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int datatype;
	}
	[StructLayout(2)]
	[Token(Token = "0x20000AA")]
	public struct DSP_PARAMETER_DESC_UNION
	{
		[Token(Token = "0x4000319")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public DSP_PARAMETER_DESC_FLOAT floatdesc;

		[Token(Token = "0x400031A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public DSP_PARAMETER_DESC_INT intdesc;

		[Token(Token = "0x400031B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public DSP_PARAMETER_DESC_BOOL booldesc;

		[Token(Token = "0x400031C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public DSP_PARAMETER_DESC_DATA datadesc;
	}
	[Token(Token = "0x20000AB")]
	public struct DSP_PARAMETER_DESC
	{
		[Token(Token = "0x400031D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public DSP_PARAMETER_TYPE type;

		[Token(Token = "0x400031E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public char[] name;

		[Token(Token = "0x400031F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public char[] label;

		[Token(Token = "0x4000320")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string description;

		[Token(Token = "0x4000321")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public DSP_PARAMETER_DESC_UNION desc;
	}
	[Token(Token = "0x20000AC")]
	public enum DSP_PARAMETER_DATA_TYPE
	{
		[Token(Token = "0x4000323")]
		DSP_PARAMETER_DATA_TYPE_USER = 0,
		[Token(Token = "0x4000324")]
		DSP_PARAMETER_DATA_TYPE_OVERALLGAIN = -1,
		[Token(Token = "0x4000325")]
		DSP_PARAMETER_DATA_TYPE_3DATTRIBUTES = -2,
		[Token(Token = "0x4000326")]
		DSP_PARAMETER_DATA_TYPE_SIDECHAIN = -3,
		[Token(Token = "0x4000327")]
		DSP_PARAMETER_DATA_TYPE_FFT = -4,
		[Token(Token = "0x4000328")]
		DSP_PARAMETER_DATA_TYPE_3DATTRIBUTES_MULTI = -5
	}
	[Token(Token = "0x20000AD")]
	public struct DSP_PARAMETER_OVERALLGAIN
	{
		[Token(Token = "0x4000329")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float linear_gain;

		[Token(Token = "0x400032A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public float linear_gain_additive;
	}
	[Token(Token = "0x20000AE")]
	public struct DSP_PARAMETER_3DATTRIBUTES
	{
		[Token(Token = "0x400032B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public ATTRIBUTES_3D relative;

		[Token(Token = "0x400032C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public ATTRIBUTES_3D absolute;
	}
	[Token(Token = "0x20000AF")]
	public struct DSP_PARAMETER_3DATTRIBUTES_MULTI
	{
		[Token(Token = "0x400032D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int numlisteners;

		[Token(Token = "0x400032E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public ATTRIBUTES_3D[] relative;

		[Token(Token = "0x400032F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float[] weight;

		[Token(Token = "0x4000330")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public ATTRIBUTES_3D absolute;
	}
	[Token(Token = "0x20000B0")]
	public struct DSP_PARAMETER_SIDECHAIN
	{
		[Token(Token = "0x4000331")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int sidechainenable;
	}
	[Token(Token = "0x20000B1")]
	public struct DSP_PARAMETER_FFT
	{
		[Token(Token = "0x4000332")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int length;

		[Token(Token = "0x4000333")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public int numchannels;

		[Token(Token = "0x4000334")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private IntPtr[] spectrum_internal;

		[Token(Token = "0x1700004B")]
		public float[][] spectrum
		{
			[Token(Token = "0x60006A9")]
			[Address(RVA = "0x157BEF0", Offset = "0x157BEF0", VA = "0x157BEF0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60006AA")]
		[Address(RVA = "0x157C06C", Offset = "0x157C06C", VA = "0x157C06C")]
		public void getSpectrum(ref float[][] buffer)
		{
		}

		[Token(Token = "0x60006AB")]
		[Address(RVA = "0x157C154", Offset = "0x157C154", VA = "0x157C154")]
		public void getSpectrum(int channel, ref float[] buffer)
		{
		}
	}
	[Token(Token = "0x20000B2")]
	public struct DSP_DESCRIPTION
	{
		[Token(Token = "0x4000335")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public uint pluginsdkversion;

		[Token(Token = "0x4000336")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public char[] name;

		[Token(Token = "0x4000337")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public uint version;

		[Token(Token = "0x4000338")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public int numinputbuffers;

		[Token(Token = "0x4000339")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int numoutputbuffers;

		[Token(Token = "0x400033A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public DSP_CREATECALLBACK create;

		[Token(Token = "0x400033B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public DSP_RELEASECALLBACK release;

		[Token(Token = "0x400033C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public DSP_RESETCALLBACK reset;

		[Token(Token = "0x400033D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public DSP_READCALLBACK read;

		[Token(Token = "0x400033E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public DSP_PROCESS_CALLBACK process;

		[Token(Token = "0x400033F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public DSP_SETPOSITIONCALLBACK setposition;

		[Token(Token = "0x4000340")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public int numparameters;

		[Token(Token = "0x4000341")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public IntPtr paramdesc;

		[Token(Token = "0x4000342")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public DSP_SETPARAM_FLOAT_CALLBACK setparameterfloat;

		[Token(Token = "0x4000343")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public DSP_SETPARAM_INT_CALLBACK setparameterint;

		[Token(Token = "0x4000344")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public DSP_SETPARAM_BOOL_CALLBACK setparameterbool;

		[Token(Token = "0x4000345")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public DSP_SETPARAM_DATA_CALLBACK setparameterdata;

		[Token(Token = "0x4000346")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public DSP_GETPARAM_FLOAT_CALLBACK getparameterfloat;

		[Token(Token = "0x4000347")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public DSP_GETPARAM_INT_CALLBACK getparameterint;

		[Token(Token = "0x4000348")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public DSP_GETPARAM_BOOL_CALLBACK getparameterbool;

		[Token(Token = "0x4000349")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public DSP_GETPARAM_DATA_CALLBACK getparameterdata;

		[Token(Token = "0x400034A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public DSP_SHOULDIPROCESS_CALLBACK shouldiprocess;

		[Token(Token = "0x400034B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public IntPtr userdata;

		[Token(Token = "0x400034C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public DSP_SYSTEM_REGISTER_CALLBACK sys_register;

		[Token(Token = "0x400034D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public DSP_SYSTEM_DEREGISTER_CALLBACK sys_deregister;

		[Token(Token = "0x400034E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public DSP_SYSTEM_MIX_CALLBACK sys_mix;
	}
	[Token(Token = "0x20000B3")]
	public struct DSP_STATE_DFT_FUNCTIONS
	{
		[Token(Token = "0x400034F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public DSP_DFT_FFTREAL_FUNC fftreal;

		[Token(Token = "0x4000350")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public DSP_DFT_IFFTREAL_FUNC inversefftreal;
	}
	[Token(Token = "0x20000B4")]
	public struct DSP_STATE_PAN_FUNCTIONS
	{
		[Token(Token = "0x4000351")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public DSP_PAN_SUMMONOMATRIX_FUNC summonomatrix;

		[Token(Token = "0x4000352")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public DSP_PAN_SUMSTEREOMATRIX_FUNC sumstereomatrix;

		[Token(Token = "0x4000353")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public DSP_PAN_SUMSURROUNDMATRIX_FUNC sumsurroundmatrix;

		[Token(Token = "0x4000354")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public DSP_PAN_SUMMONOTOSURROUNDMATRIX_FUNC summonotosurroundmatrix;

		[Token(Token = "0x4000355")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public DSP_PAN_SUMSTEREOTOSURROUNDMATRIX_FUNC sumstereotosurroundmatrix;

		[Token(Token = "0x4000356")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public DSP_PAN_GETROLLOFFGAIN_FUNC getrolloffgain;
	}
	[Token(Token = "0x20000B5")]
	public struct DSP_STATE_FUNCTIONS
	{
		[Token(Token = "0x4000357")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public DSP_ALLOC_FUNC alloc;

		[Token(Token = "0x4000358")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public DSP_REALLOC_FUNC realloc;

		[Token(Token = "0x4000359")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public DSP_FREE_FUNC free;

		[Token(Token = "0x400035A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public DSP_GETSAMPLERATE_FUNC getsamplerate;

		[Token(Token = "0x400035B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public DSP_GETBLOCKSIZE_FUNC getblocksize;

		[Token(Token = "0x400035C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public IntPtr dft;

		[Token(Token = "0x400035D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public IntPtr pan;

		[Token(Token = "0x400035E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public DSP_GETSPEAKERMODE_FUNC getspeakermode;

		[Token(Token = "0x400035F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public DSP_GETCLOCK_FUNC getclock;

		[Token(Token = "0x4000360")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public DSP_GETLISTENERATTRIBUTES_FUNC getlistenerattributes;

		[Token(Token = "0x4000361")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public DSP_LOG_FUNC log;

		[Token(Token = "0x4000362")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public DSP_GETUSERDATA_FUNC getuserdata;
	}
	[Token(Token = "0x20000B6")]
	public struct DSP_STATE
	{
		[Token(Token = "0x4000363")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public IntPtr instance;

		[Token(Token = "0x4000364")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public IntPtr plugindata;

		[Token(Token = "0x4000365")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public uint channelmask;

		[Token(Token = "0x4000366")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public int source_speakermode;

		[Token(Token = "0x4000367")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public IntPtr sidechaindata;

		[Token(Token = "0x4000368")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public int sidechainchannels;

		[Token(Token = "0x4000369")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public IntPtr functions;

		[Token(Token = "0x400036A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public int systemobject;
	}
	[Token(Token = "0x20000B7")]
	public struct DSP_METERING_INFO
	{
		[Token(Token = "0x400036B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int numsamples;

		[Token(Token = "0x400036C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public float[] peaklevel;

		[Token(Token = "0x400036D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float[] rmslevel;

		[Token(Token = "0x400036E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public short numchannels;
	}
	[Token(Token = "0x20000B8")]
	public enum DSP_OSCILLATOR
	{
		[Token(Token = "0x4000370")]
		TYPE,
		[Token(Token = "0x4000371")]
		RATE
	}
	[Token(Token = "0x20000B9")]
	public enum DSP_LOWPASS
	{
		[Token(Token = "0x4000373")]
		CUTOFF,
		[Token(Token = "0x4000374")]
		RESONANCE
	}
	[Token(Token = "0x20000BA")]
	public enum DSP_ITLOWPASS
	{
		[Token(Token = "0x4000376")]
		CUTOFF,
		[Token(Token = "0x4000377")]
		RESONANCE
	}
	[Token(Token = "0x20000BB")]
	public enum DSP_HIGHPASS
	{
		[Token(Token = "0x4000379")]
		CUTOFF,
		[Token(Token = "0x400037A")]
		RESONANCE
	}
	[Token(Token = "0x20000BC")]
	public enum DSP_ECHO
	{
		[Token(Token = "0x400037C")]
		DELAY,
		[Token(Token = "0x400037D")]
		FEEDBACK,
		[Token(Token = "0x400037E")]
		DRYLEVEL,
		[Token(Token = "0x400037F")]
		WETLEVEL
	}
	[Token(Token = "0x20000BD")]
	public enum DSP_FADER
	{
		[Token(Token = "0x4000381")]
		GAIN,
		[Token(Token = "0x4000382")]
		OVERALL_GAIN
	}
	[Token(Token = "0x20000BE")]
	public enum DSP_DELAY
	{
		[Token(Token = "0x4000384")]
		CH0,
		[Token(Token = "0x4000385")]
		CH1,
		[Token(Token = "0x4000386")]
		CH2,
		[Token(Token = "0x4000387")]
		CH3,
		[Token(Token = "0x4000388")]
		CH4,
		[Token(Token = "0x4000389")]
		CH5,
		[Token(Token = "0x400038A")]
		CH6,
		[Token(Token = "0x400038B")]
		CH7,
		[Token(Token = "0x400038C")]
		CH8,
		[Token(Token = "0x400038D")]
		CH9,
		[Token(Token = "0x400038E")]
		CH10,
		[Token(Token = "0x400038F")]
		CH11,
		[Token(Token = "0x4000390")]
		CH12,
		[Token(Token = "0x4000391")]
		CH13,
		[Token(Token = "0x4000392")]
		CH14,
		[Token(Token = "0x4000393")]
		CH15,
		[Token(Token = "0x4000394")]
		MAXDELAY
	}
	[Token(Token = "0x20000BF")]
	public enum DSP_FLANGE
	{
		[Token(Token = "0x4000396")]
		MIX,
		[Token(Token = "0x4000397")]
		DEPTH,
		[Token(Token = "0x4000398")]
		RATE
	}
	[Token(Token = "0x20000C0")]
	public enum DSP_TREMOLO
	{
		[Token(Token = "0x400039A")]
		FREQUENCY,
		[Token(Token = "0x400039B")]
		DEPTH,
		[Token(Token = "0x400039C")]
		SHAPE,
		[Token(Token = "0x400039D")]
		SKEW,
		[Token(Token = "0x400039E")]
		DUTY,
		[Token(Token = "0x400039F")]
		SQUARE,
		[Token(Token = "0x40003A0")]
		PHASE,
		[Token(Token = "0x40003A1")]
		SPREAD
	}
	[Token(Token = "0x20000C1")]
	public enum DSP_DISTORTION
	{
		[Token(Token = "0x40003A3")]
		LEVEL
	}
	[Token(Token = "0x20000C2")]
	public enum DSP_NORMALIZE
	{
		[Token(Token = "0x40003A5")]
		FADETIME,
		[Token(Token = "0x40003A6")]
		THRESHHOLD,
		[Token(Token = "0x40003A7")]
		MAXAMP
	}
	[Token(Token = "0x20000C3")]
	public enum DSP_LIMITER
	{
		[Token(Token = "0x40003A9")]
		RELEASETIME,
		[Token(Token = "0x40003AA")]
		CEILING,
		[Token(Token = "0x40003AB")]
		MAXIMIZERGAIN,
		[Token(Token = "0x40003AC")]
		MODE
	}
	[Token(Token = "0x20000C4")]
	public enum DSP_PARAMEQ
	{
		[Token(Token = "0x40003AE")]
		CENTER,
		[Token(Token = "0x40003AF")]
		BANDWIDTH,
		[Token(Token = "0x40003B0")]
		GAIN
	}
	[Token(Token = "0x20000C5")]
	public enum DSP_MULTIBAND_EQ
	{
		[Token(Token = "0x40003B2")]
		A_FILTER,
		[Token(Token = "0x40003B3")]
		A_FREQUENCY,
		[Token(Token = "0x40003B4")]
		A_Q,
		[Token(Token = "0x40003B5")]
		A_GAIN,
		[Token(Token = "0x40003B6")]
		B_FILTER,
		[Token(Token = "0x40003B7")]
		B_FREQUENCY,
		[Token(Token = "0x40003B8")]
		B_Q,
		[Token(Token = "0x40003B9")]
		B_GAIN,
		[Token(Token = "0x40003BA")]
		C_FILTER,
		[Token(Token = "0x40003BB")]
		C_FREQUENCY,
		[Token(Token = "0x40003BC")]
		C_Q,
		[Token(Token = "0x40003BD")]
		C_GAIN,
		[Token(Token = "0x40003BE")]
		D_FILTER,
		[Token(Token = "0x40003BF")]
		D_FREQUENCY,
		[Token(Token = "0x40003C0")]
		D_Q,
		[Token(Token = "0x40003C1")]
		D_GAIN,
		[Token(Token = "0x40003C2")]
		E_FILTER,
		[Token(Token = "0x40003C3")]
		E_FREQUENCY,
		[Token(Token = "0x40003C4")]
		E_Q,
		[Token(Token = "0x40003C5")]
		E_GAIN
	}
	[Token(Token = "0x20000C6")]
	public enum DSP_MULTIBAND_EQ_FILTER_TYPE
	{
		[Token(Token = "0x40003C7")]
		DISABLED,
		[Token(Token = "0x40003C8")]
		LOWPASS_12DB,
		[Token(Token = "0x40003C9")]
		LOWPASS_24DB,
		[Token(Token = "0x40003CA")]
		LOWPASS_48DB,
		[Token(Token = "0x40003CB")]
		HIGHPASS_12DB,
		[Token(Token = "0x40003CC")]
		HIGHPASS_24DB,
		[Token(Token = "0x40003CD")]
		HIGHPASS_48DB,
		[Token(Token = "0x40003CE")]
		LOWSHELF,
		[Token(Token = "0x40003CF")]
		HIGHSHELF,
		[Token(Token = "0x40003D0")]
		PEAKING,
		[Token(Token = "0x40003D1")]
		BANDPASS,
		[Token(Token = "0x40003D2")]
		NOTCH,
		[Token(Token = "0x40003D3")]
		ALLPASS
	}
	[Token(Token = "0x20000C7")]
	public enum DSP_PITCHSHIFT
	{
		[Token(Token = "0x40003D5")]
		PITCH,
		[Token(Token = "0x40003D6")]
		FFTSIZE,
		[Token(Token = "0x40003D7")]
		OVERLAP,
		[Token(Token = "0x40003D8")]
		MAXCHANNELS
	}
	[Token(Token = "0x20000C8")]
	public enum DSP_CHORUS
	{
		[Token(Token = "0x40003DA")]
		MIX,
		[Token(Token = "0x40003DB")]
		RATE,
		[Token(Token = "0x40003DC")]
		DEPTH
	}
	[Token(Token = "0x20000C9")]
	public enum DSP_ITECHO
	{
		[Token(Token = "0x40003DE")]
		WETDRYMIX,
		[Token(Token = "0x40003DF")]
		FEEDBACK,
		[Token(Token = "0x40003E0")]
		LEFTDELAY,
		[Token(Token = "0x40003E1")]
		RIGHTDELAY,
		[Token(Token = "0x40003E2")]
		PANDELAY
	}
	[Token(Token = "0x20000CA")]
	public enum DSP_COMPRESSOR
	{
		[Token(Token = "0x40003E4")]
		THRESHOLD,
		[Token(Token = "0x40003E5")]
		RATIO,
		[Token(Token = "0x40003E6")]
		ATTACK,
		[Token(Token = "0x40003E7")]
		RELEASE,
		[Token(Token = "0x40003E8")]
		GAINMAKEUP,
		[Token(Token = "0x40003E9")]
		USESIDECHAIN,
		[Token(Token = "0x40003EA")]
		LINKED
	}
	[Token(Token = "0x20000CB")]
	public enum DSP_SFXREVERB
	{
		[Token(Token = "0x40003EC")]
		DECAYTIME,
		[Token(Token = "0x40003ED")]
		EARLYDELAY,
		[Token(Token = "0x40003EE")]
		LATEDELAY,
		[Token(Token = "0x40003EF")]
		HFREFERENCE,
		[Token(Token = "0x40003F0")]
		HFDECAYRATIO,
		[Token(Token = "0x40003F1")]
		DIFFUSION,
		[Token(Token = "0x40003F2")]
		DENSITY,
		[Token(Token = "0x40003F3")]
		LOWSHELFFREQUENCY,
		[Token(Token = "0x40003F4")]
		LOWSHELFGAIN,
		[Token(Token = "0x40003F5")]
		HIGHCUT,
		[Token(Token = "0x40003F6")]
		EARLYLATEMIX,
		[Token(Token = "0x40003F7")]
		WETLEVEL,
		[Token(Token = "0x40003F8")]
		DRYLEVEL
	}
	[Token(Token = "0x20000CC")]
	public enum DSP_LOWPASS_SIMPLE
	{
		[Token(Token = "0x40003FA")]
		CUTOFF
	}
	[Token(Token = "0x20000CD")]
	public enum DSP_SEND
	{
		[Token(Token = "0x40003FC")]
		RETURNID,
		[Token(Token = "0x40003FD")]
		LEVEL
	}
	[Token(Token = "0x20000CE")]
	public enum DSP_RETURN
	{
		[Token(Token = "0x40003FF")]
		ID,
		[Token(Token = "0x4000400")]
		INPUT_SPEAKER_MODE
	}
	[Token(Token = "0x20000CF")]
	public enum DSP_HIGHPASS_SIMPLE
	{
		[Token(Token = "0x4000402")]
		CUTOFF
	}
	[Token(Token = "0x20000D0")]
	public enum DSP_PAN_2D_STEREO_MODE_TYPE
	{
		[Token(Token = "0x4000404")]
		DISTRIBUTED,
		[Token(Token = "0x4000405")]
		DISCRETE
	}
	[Token(Token = "0x20000D1")]
	public enum DSP_PAN_MODE_TYPE
	{
		[Token(Token = "0x4000407")]
		MONO,
		[Token(Token = "0x4000408")]
		STEREO,
		[Token(Token = "0x4000409")]
		SURROUND
	}
	[Token(Token = "0x20000D2")]
	public enum DSP_PAN_3D_ROLLOFF_TYPE
	{
		[Token(Token = "0x400040B")]
		LINEARSQUARED,
		[Token(Token = "0x400040C")]
		LINEAR,
		[Token(Token = "0x400040D")]
		INVERSE,
		[Token(Token = "0x400040E")]
		INVERSETAPERED,
		[Token(Token = "0x400040F")]
		CUSTOM
	}
	[Token(Token = "0x20000D3")]
	public enum DSP_PAN_3D_EXTENT_MODE_TYPE
	{
		[Token(Token = "0x4000411")]
		AUTO,
		[Token(Token = "0x4000412")]
		USER,
		[Token(Token = "0x4000413")]
		OFF
	}
	[Token(Token = "0x20000D4")]
	public enum DSP_PAN
	{
		[Token(Token = "0x4000415")]
		MODE,
		[Token(Token = "0x4000416")]
		_2D_STEREO_POSITION,
		[Token(Token = "0x4000417")]
		_2D_DIRECTION,
		[Token(Token = "0x4000418")]
		_2D_EXTENT,
		[Token(Token = "0x4000419")]
		_2D_ROTATION,
		[Token(Token = "0x400041A")]
		_2D_LFE_LEVEL,
		[Token(Token = "0x400041B")]
		_2D_STEREO_MODE,
		[Token(Token = "0x400041C")]
		_2D_STEREO_SEPARATION,
		[Token(Token = "0x400041D")]
		_2D_STEREO_AXIS,
		[Token(Token = "0x400041E")]
		ENABLED_SPEAKERS,
		[Token(Token = "0x400041F")]
		_3D_POSITION,
		[Token(Token = "0x4000420")]
		_3D_ROLLOFF,
		[Token(Token = "0x4000421")]
		_3D_MIN_DISTANCE,
		[Token(Token = "0x4000422")]
		_3D_MAX_DISTANCE,
		[Token(Token = "0x4000423")]
		_3D_EXTENT_MODE,
		[Token(Token = "0x4000424")]
		_3D_SOUND_SIZE,
		[Token(Token = "0x4000425")]
		_3D_MIN_EXTENT,
		[Token(Token = "0x4000426")]
		_3D_PAN_BLEND,
		[Token(Token = "0x4000427")]
		LFE_UPMIX_ENABLED,
		[Token(Token = "0x4000428")]
		OVERALL_GAIN,
		[Token(Token = "0x4000429")]
		SURROUND_SPEAKER_MODE,
		[Token(Token = "0x400042A")]
		_2D_HEIGHT_BLEND
	}
	[Token(Token = "0x20000D5")]
	public enum DSP_THREE_EQ_CROSSOVERSLOPE_TYPE
	{
		[Token(Token = "0x400042C")]
		_12DB,
		[Token(Token = "0x400042D")]
		_24DB,
		[Token(Token = "0x400042E")]
		_48DB
	}
	[Token(Token = "0x20000D6")]
	public enum DSP_THREE_EQ
	{
		[Token(Token = "0x4000430")]
		LOWGAIN,
		[Token(Token = "0x4000431")]
		MIDGAIN,
		[Token(Token = "0x4000432")]
		HIGHGAIN,
		[Token(Token = "0x4000433")]
		LOWCROSSOVER,
		[Token(Token = "0x4000434")]
		HIGHCROSSOVER,
		[Token(Token = "0x4000435")]
		CROSSOVERSLOPE
	}
	[Token(Token = "0x20000D7")]
	public enum DSP_FFT_WINDOW
	{
		[Token(Token = "0x4000437")]
		RECT,
		[Token(Token = "0x4000438")]
		TRIANGLE,
		[Token(Token = "0x4000439")]
		HAMMING,
		[Token(Token = "0x400043A")]
		HANNING,
		[Token(Token = "0x400043B")]
		BLACKMAN,
		[Token(Token = "0x400043C")]
		BLACKMANHARRIS
	}
	[Token(Token = "0x20000D8")]
	public enum DSP_FFT
	{
		[Token(Token = "0x400043E")]
		WINDOWSIZE,
		[Token(Token = "0x400043F")]
		WINDOWTYPE,
		[Token(Token = "0x4000440")]
		SPECTRUMDATA,
		[Token(Token = "0x4000441")]
		DOMINANT_FREQ
	}
	[Token(Token = "0x20000D9")]
	public enum DSP_ENVELOPEFOLLOWER
	{
		[Token(Token = "0x4000443")]
		ATTACK,
		[Token(Token = "0x4000444")]
		RELEASE,
		[Token(Token = "0x4000445")]
		ENVELOPE,
		[Token(Token = "0x4000446")]
		USESIDECHAIN
	}
	[Token(Token = "0x20000DA")]
	public enum DSP_CONVOLUTION_REVERB
	{
		[Token(Token = "0x4000448")]
		IR,
		[Token(Token = "0x4000449")]
		WET,
		[Token(Token = "0x400044A")]
		DRY,
		[Token(Token = "0x400044B")]
		LINKED
	}
	[Token(Token = "0x20000DB")]
	public enum DSP_CHANNELMIX_OUTPUT
	{
		[Token(Token = "0x400044D")]
		DEFAULT,
		[Token(Token = "0x400044E")]
		ALLMONO,
		[Token(Token = "0x400044F")]
		ALLSTEREO,
		[Token(Token = "0x4000450")]
		ALLQUAD,
		[Token(Token = "0x4000451")]
		ALL5POINT1,
		[Token(Token = "0x4000452")]
		ALL7POINT1,
		[Token(Token = "0x4000453")]
		ALLLFE,
		[Token(Token = "0x4000454")]
		ALL7POINT1POINT4
	}
	[Token(Token = "0x20000DC")]
	public enum DSP_CHANNELMIX
	{
		[Token(Token = "0x4000456")]
		OUTPUTGROUPING,
		[Token(Token = "0x4000457")]
		GAIN_CH0,
		[Token(Token = "0x4000458")]
		GAIN_CH1,
		[Token(Token = "0x4000459")]
		GAIN_CH2,
		[Token(Token = "0x400045A")]
		GAIN_CH3,
		[Token(Token = "0x400045B")]
		GAIN_CH4,
		[Token(Token = "0x400045C")]
		GAIN_CH5,
		[Token(Token = "0x400045D")]
		GAIN_CH6,
		[Token(Token = "0x400045E")]
		GAIN_CH7,
		[Token(Token = "0x400045F")]
		GAIN_CH8,
		[Token(Token = "0x4000460")]
		GAIN_CH9,
		[Token(Token = "0x4000461")]
		GAIN_CH10,
		[Token(Token = "0x4000462")]
		GAIN_CH11,
		[Token(Token = "0x4000463")]
		GAIN_CH12,
		[Token(Token = "0x4000464")]
		GAIN_CH13,
		[Token(Token = "0x4000465")]
		GAIN_CH14,
		[Token(Token = "0x4000466")]
		GAIN_CH15,
		[Token(Token = "0x4000467")]
		GAIN_CH16,
		[Token(Token = "0x4000468")]
		GAIN_CH17,
		[Token(Token = "0x4000469")]
		GAIN_CH18,
		[Token(Token = "0x400046A")]
		GAIN_CH19,
		[Token(Token = "0x400046B")]
		GAIN_CH20,
		[Token(Token = "0x400046C")]
		GAIN_CH21,
		[Token(Token = "0x400046D")]
		GAIN_CH22,
		[Token(Token = "0x400046E")]
		GAIN_CH23,
		[Token(Token = "0x400046F")]
		GAIN_CH24,
		[Token(Token = "0x4000470")]
		GAIN_CH25,
		[Token(Token = "0x4000471")]
		GAIN_CH26,
		[Token(Token = "0x4000472")]
		GAIN_CH27,
		[Token(Token = "0x4000473")]
		GAIN_CH28,
		[Token(Token = "0x4000474")]
		GAIN_CH29,
		[Token(Token = "0x4000475")]
		GAIN_CH30,
		[Token(Token = "0x4000476")]
		GAIN_CH31,
		[Token(Token = "0x4000477")]
		OUTPUT_CH0,
		[Token(Token = "0x4000478")]
		OUTPUT_CH1,
		[Token(Token = "0x4000479")]
		OUTPUT_CH2,
		[Token(Token = "0x400047A")]
		OUTPUT_CH3,
		[Token(Token = "0x400047B")]
		OUTPUT_CH4,
		[Token(Token = "0x400047C")]
		OUTPUT_CH5,
		[Token(Token = "0x400047D")]
		OUTPUT_CH6,
		[Token(Token = "0x400047E")]
		OUTPUT_CH7,
		[Token(Token = "0x400047F")]
		OUTPUT_CH8,
		[Token(Token = "0x4000480")]
		OUTPUT_CH9,
		[Token(Token = "0x4000481")]
		OUTPUT_CH10,
		[Token(Token = "0x4000482")]
		OUTPUT_CH11,
		[Token(Token = "0x4000483")]
		OUTPUT_CH12,
		[Token(Token = "0x4000484")]
		OUTPUT_CH13,
		[Token(Token = "0x4000485")]
		OUTPUT_CH14,
		[Token(Token = "0x4000486")]
		OUTPUT_CH15,
		[Token(Token = "0x4000487")]
		OUTPUT_CH16,
		[Token(Token = "0x4000488")]
		OUTPUT_CH17,
		[Token(Token = "0x4000489")]
		OUTPUT_CH18,
		[Token(Token = "0x400048A")]
		OUTPUT_CH19,
		[Token(Token = "0x400048B")]
		OUTPUT_CH20,
		[Token(Token = "0x400048C")]
		OUTPUT_CH21,
		[Token(Token = "0x400048D")]
		OUTPUT_CH22,
		[Token(Token = "0x400048E")]
		OUTPUT_CH23,
		[Token(Token = "0x400048F")]
		OUTPUT_CH24,
		[Token(Token = "0x4000490")]
		OUTPUT_CH25,
		[Token(Token = "0x4000491")]
		OUTPUT_CH26,
		[Token(Token = "0x4000492")]
		OUTPUT_CH27,
		[Token(Token = "0x4000493")]
		OUTPUT_CH28,
		[Token(Token = "0x4000494")]
		OUTPUT_CH29,
		[Token(Token = "0x4000495")]
		OUTPUT_CH30,
		[Token(Token = "0x4000496")]
		OUTPUT_CH31
	}
	[Token(Token = "0x20000DD")]
	public enum DSP_TRANSCEIVER_SPEAKERMODE
	{
		[Token(Token = "0x4000498")]
		AUTO = -1,
		[Token(Token = "0x4000499")]
		MONO,
		[Token(Token = "0x400049A")]
		STEREO,
		[Token(Token = "0x400049B")]
		SURROUND
	}
	[Token(Token = "0x20000DE")]
	public enum DSP_TRANSCEIVER
	{
		[Token(Token = "0x400049D")]
		TRANSMIT,
		[Token(Token = "0x400049E")]
		GAIN,
		[Token(Token = "0x400049F")]
		CHANNEL,
		[Token(Token = "0x40004A0")]
		TRANSMITSPEAKERMODE
	}
	[Token(Token = "0x20000DF")]
	public enum DSP_OBJECTPAN
	{
		[Token(Token = "0x40004A2")]
		_3D_POSITION,
		[Token(Token = "0x40004A3")]
		_3D_ROLLOFF,
		[Token(Token = "0x40004A4")]
		_3D_MIN_DISTANCE,
		[Token(Token = "0x40004A5")]
		_3D_MAX_DISTANCE,
		[Token(Token = "0x40004A6")]
		_3D_EXTENT_MODE,
		[Token(Token = "0x40004A7")]
		_3D_SOUND_SIZE,
		[Token(Token = "0x40004A8")]
		_3D_MIN_EXTENT,
		[Token(Token = "0x40004A9")]
		OVERALL_GAIN,
		[Token(Token = "0x40004AA")]
		OUTPUTGAIN
	}
	[Token(Token = "0x20000E0")]
	public class Error
	{
		[Token(Token = "0x60006AC")]
		[Address(RVA = "0x157FC44", Offset = "0x157FC44", VA = "0x157FC44")]
		public static string String(RESULT errcode)
		{
			return null;
		}

		[Token(Token = "0x60006AD")]
		[Address(RVA = "0x157FCA8", Offset = "0x157FCA8", VA = "0x157FCA8")]
		public Error()
		{
		}
	}
}
namespace FMOD.Studio
{
	[Token(Token = "0x20000E1")]
	public class STUDIO_VERSION
	{
		[Token(Token = "0x40004AB")]
		public const string dll = "fmodstudio";

		[Token(Token = "0x60006AE")]
		[Address(RVA = "0x158F5B8", Offset = "0x158F5B8", VA = "0x158F5B8")]
		public STUDIO_VERSION()
		{
		}
	}
	[Token(Token = "0x20000E2")]
	public enum STOP_MODE
	{
		[Token(Token = "0x40004AD")]
		ALLOWFADEOUT,
		[Token(Token = "0x40004AE")]
		IMMEDIATE
	}
	[Token(Token = "0x20000E3")]
	public enum LOADING_STATE
	{
		[Token(Token = "0x40004B0")]
		UNLOADING,
		[Token(Token = "0x40004B1")]
		UNLOADED,
		[Token(Token = "0x40004B2")]
		LOADING,
		[Token(Token = "0x40004B3")]
		LOADED,
		[Token(Token = "0x40004B4")]
		ERROR
	}
	[Token(Token = "0x20000E4")]
	public struct PROGRAMMER_SOUND_PROPERTIES
	{
		[Token(Token = "0x40004B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public StringWrapper name;

		[Token(Token = "0x40004B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public IntPtr sound;

		[Token(Token = "0x40004B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int subsoundIndex;
	}
	[Token(Token = "0x20000E5")]
	public struct TIMELINE_MARKER_PROPERTIES
	{
		[Token(Token = "0x40004B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public StringWrapper name;

		[Token(Token = "0x40004B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public int position;
	}
	[Token(Token = "0x20000E6")]
	public struct TIMELINE_BEAT_PROPERTIES
	{
		[Token(Token = "0x40004BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int bar;

		[Token(Token = "0x40004BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public int beat;

		[Token(Token = "0x40004BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public int position;

		[Token(Token = "0x40004BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public float tempo;

		[Token(Token = "0x40004BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int timesignatureupper;

		[Token(Token = "0x40004BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public int timesignaturelower;
	}
	[Token(Token = "0x20000E7")]
	public struct ADVANCEDSETTINGS
	{
		[Token(Token = "0x40004C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int cbsize;

		[Token(Token = "0x40004C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public int commandqueuesize;

		[Token(Token = "0x40004C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public int handleinitialsize;

		[Token(Token = "0x40004C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public int studioupdateperiod;

		[Token(Token = "0x40004C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int idlesampledatapoolsize;

		[Token(Token = "0x40004C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public int streamingscheduledelay;

		[Token(Token = "0x40004C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public IntPtr encryptionkey;
	}
	[Token(Token = "0x20000E8")]
	public struct CPU_USAGE
	{
		[Token(Token = "0x40004C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float dspusage;

		[Token(Token = "0x40004C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public float streamusage;

		[Token(Token = "0x40004C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public float geometryusage;

		[Token(Token = "0x40004CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public float updateusage;

		[Token(Token = "0x40004CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float studiousage;
	}
	[Token(Token = "0x20000E9")]
	public struct BUFFER_INFO
	{
		[Token(Token = "0x40004CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int currentusage;

		[Token(Token = "0x40004CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public int peakusage;

		[Token(Token = "0x40004CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public int capacity;

		[Token(Token = "0x40004CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public int stallcount;

		[Token(Token = "0x40004D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float stalltime;
	}
	[Token(Token = "0x20000EA")]
	public struct BUFFER_USAGE
	{
		[Token(Token = "0x40004D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public BUFFER_INFO studiocommandqueue;

		[Token(Token = "0x40004D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public BUFFER_INFO studiohandle;
	}
	[Token(Token = "0x20000EB")]
	public struct BANK_INFO
	{
		[Token(Token = "0x40004D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int size;

		[Token(Token = "0x40004D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public IntPtr userdata;

		[Token(Token = "0x40004D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int userdatalength;

		[Token(Token = "0x40004D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public FILE_OPEN_CALLBACK opencallback;

		[Token(Token = "0x40004D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public FILE_CLOSE_CALLBACK closecallback;

		[Token(Token = "0x40004D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public FILE_READ_CALLBACK readcallback;

		[Token(Token = "0x40004D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public FILE_SEEK_CALLBACK seekcallback;
	}
	[Token(Token = "0x20000EC")]
	[Flags]
	public enum SYSTEM_CALLBACK_TYPE : uint
	{
		[Token(Token = "0x40004DB")]
		PREUPDATE = 1u,
		[Token(Token = "0x40004DC")]
		POSTUPDATE = 2u,
		[Token(Token = "0x40004DD")]
		BANK_UNLOAD = 4u,
		[Token(Token = "0x40004DE")]
		ALL = uint.MaxValue
	}
	[Token(Token = "0x20000ED")]
	public delegate RESULT SYSTEM_CALLBACK(IntPtr system, SYSTEM_CALLBACK_TYPE type, IntPtr commanddata, IntPtr userdata);
	[Token(Token = "0x20000EE")]
	public enum PARAMETER_TYPE
	{
		[Token(Token = "0x40004E0")]
		GAME_CONTROLLED,
		[Token(Token = "0x40004E1")]
		AUTOMATIC_DISTANCE,
		[Token(Token = "0x40004E2")]
		AUTOMATIC_EVENT_CONE_ANGLE,
		[Token(Token = "0x40004E3")]
		AUTOMATIC_EVENT_ORIENTATION,
		[Token(Token = "0x40004E4")]
		AUTOMATIC_DIRECTION,
		[Token(Token = "0x40004E5")]
		AUTOMATIC_ELEVATION,
		[Token(Token = "0x40004E6")]
		AUTOMATIC_LISTENER_ORIENTATION,
		[Token(Token = "0x40004E7")]
		AUTOMATIC_SPEED,
		[Token(Token = "0x40004E8")]
		MAX
	}
	[Token(Token = "0x20000EF")]
	[Flags]
	public enum PARAMETER_FLAGS : uint
	{
		[Token(Token = "0x40004EA")]
		READONLY = 1u,
		[Token(Token = "0x40004EB")]
		AUTOMATIC = 2u,
		[Token(Token = "0x40004EC")]
		GLOBAL = 4u
	}
	[Token(Token = "0x20000F0")]
	public struct PARAMETER_ID
	{
		[Token(Token = "0x40004ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public uint data1;

		[Token(Token = "0x40004EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public uint data2;
	}
	[Token(Token = "0x20000F1")]
	public struct PARAMETER_DESCRIPTION
	{
		[Token(Token = "0x40004EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public StringWrapper name;

		[Token(Token = "0x40004F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public PARAMETER_ID id;

		[Token(Token = "0x40004F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float minimum;

		[Token(Token = "0x40004F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public float maximum;

		[Token(Token = "0x40004F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float defaultvalue;

		[Token(Token = "0x40004F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public PARAMETER_TYPE type;

		[Token(Token = "0x40004F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public PARAMETER_FLAGS flags;
	}
	[Token(Token = "0x20000F2")]
	internal enum LOAD_MEMORY_MODE
	{
		[Token(Token = "0x40004F7")]
		LOAD_MEMORY,
		[Token(Token = "0x40004F8")]
		LOAD_MEMORY_POINT
	}
	[Token(Token = "0x20000F3")]
	internal enum LOAD_MEMORY_ALIGNMENT
	{
		[Token(Token = "0x40004FA")]
		VALUE = 0x20
	}
	[Token(Token = "0x20000F4")]
	public struct SOUND_INFO
	{
		[Token(Token = "0x40004FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public IntPtr name_or_data;

		[Token(Token = "0x40004FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public MODE mode;

		[Token(Token = "0x40004FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public CREATESOUNDEXINFO exinfo;

		[Token(Token = "0x40004FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		public int subsoundindex;

		[Token(Token = "0x1700004C")]
		public string name
		{
			[Token(Token = "0x60006B3")]
			[Address(RVA = "0x158F454", Offset = "0x158F454", VA = "0x158F454")]
			get
			{
				return null;
			}
		}
	}
	[Token(Token = "0x20000F5")]
	public enum USER_PROPERTY_TYPE
	{
		[Token(Token = "0x4000500")]
		INTEGER,
		[Token(Token = "0x4000501")]
		BOOLEAN,
		[Token(Token = "0x4000502")]
		FLOAT,
		[Token(Token = "0x4000503")]
		STRING
	}
	[Token(Token = "0x20000F6")]
	public struct USER_PROPERTY
	{
		[Token(Token = "0x4000504")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public StringWrapper name;

		[Token(Token = "0x4000505")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public USER_PROPERTY_TYPE type;

		[Token(Token = "0x4000506")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private Union_IntBoolFloatString value;

		[Token(Token = "0x60006B4")]
		[Address(RVA = "0xFBF3D4", Offset = "0xFBF3D4", VA = "0xFBF3D4")]
		public int intValue()
		{
			return default(int);
		}

		[Token(Token = "0x60006B5")]
		[Address(RVA = "0xFBF3EC", Offset = "0xFBF3EC", VA = "0xFBF3EC")]
		public bool boolValue()
		{
			return default(bool);
		}

		[Token(Token = "0x60006B6")]
		[Address(RVA = "0xFBF410", Offset = "0xFBF410", VA = "0xFBF410")]
		public float floatValue()
		{
			return default(float);
		}

		[Token(Token = "0x60006B7")]
		[Address(RVA = "0xFBF42C", Offset = "0xFBF42C", VA = "0xFBF42C")]
		public string stringValue()
		{
			return null;
		}
	}
	[StructLayout(2)]
	[Token(Token = "0x20000F7")]
	internal struct Union_IntBoolFloatString
	{
		[Token(Token = "0x4000507")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int intvalue;

		[Token(Token = "0x4000508")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public bool boolvalue;

		[Token(Token = "0x4000509")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float floatvalue;

		[Token(Token = "0x400050A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public StringWrapper stringvalue;
	}
	[Token(Token = "0x20000F8")]
	[Flags]
	public enum INITFLAGS : uint
	{
		[Token(Token = "0x400050C")]
		NORMAL = 0u,
		[Token(Token = "0x400050D")]
		LIVEUPDATE = 1u,
		[Token(Token = "0x400050E")]
		ALLOW_MISSING_PLUGINS = 2u,
		[Token(Token = "0x400050F")]
		SYNCHRONOUS_UPDATE = 4u,
		[Token(Token = "0x4000510")]
		DEFERRED_CALLBACKS = 8u,
		[Token(Token = "0x4000511")]
		LOAD_FROM_UPDATE = 0x10u
	}
	[Token(Token = "0x20000F9")]
	[Flags]
	public enum LOAD_BANK_FLAGS : uint
	{
		[Token(Token = "0x4000513")]
		NORMAL = 0u,
		[Token(Token = "0x4000514")]
		NONBLOCKING = 1u,
		[Token(Token = "0x4000515")]
		DECOMPRESS_SAMPLES = 2u,
		[Token(Token = "0x4000516")]
		UNENCRYPTED = 4u
	}
	[Token(Token = "0x20000FA")]
	[Flags]
	public enum COMMANDCAPTURE_FLAGS : uint
	{
		[Token(Token = "0x4000518")]
		NORMAL = 0u,
		[Token(Token = "0x4000519")]
		FILEFLUSH = 1u,
		[Token(Token = "0x400051A")]
		SKIP_INITIAL_STATE = 2u
	}
	[Token(Token = "0x20000FB")]
	[Flags]
	public enum COMMANDREPLAY_FLAGS : uint
	{
		[Token(Token = "0x400051C")]
		NORMAL = 0u,
		[Token(Token = "0x400051D")]
		SKIP_CLEANUP = 1u,
		[Token(Token = "0x400051E")]
		FAST_FORWARD = 2u,
		[Token(Token = "0x400051F")]
		SKIP_BANK_LOAD = 4u
	}
	[Token(Token = "0x20000FC")]
	public enum PLAYBACK_STATE
	{
		[Token(Token = "0x4000521")]
		PLAYING,
		[Token(Token = "0x4000522")]
		SUSTAINING,
		[Token(Token = "0x4000523")]
		STOPPED,
		[Token(Token = "0x4000524")]
		STARTING,
		[Token(Token = "0x4000525")]
		STOPPING
	}
	[Token(Token = "0x20000FD")]
	public enum EVENT_PROPERTY
	{
		[Token(Token = "0x4000527")]
		CHANNELPRIORITY,
		[Token(Token = "0x4000528")]
		SCHEDULE_DELAY,
		[Token(Token = "0x4000529")]
		SCHEDULE_LOOKAHEAD,
		[Token(Token = "0x400052A")]
		MINIMUM_DISTANCE,
		[Token(Token = "0x400052B")]
		MAXIMUM_DISTANCE,
		[Token(Token = "0x400052C")]
		MAX
	}
	[Token(Token = "0x20000FE")]
	public struct PLUGIN_INSTANCE_PROPERTIES
	{
		[Token(Token = "0x400052D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public IntPtr name;

		[Token(Token = "0x400052E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public IntPtr dsp;
	}
	[Token(Token = "0x20000FF")]
	[Flags]
	public enum EVENT_CALLBACK_TYPE : uint
	{
		[Token(Token = "0x4000530")]
		CREATED = 1u,
		[Token(Token = "0x4000531")]
		DESTROYED = 2u,
		[Token(Token = "0x4000532")]
		STARTING = 4u,
		[Token(Token = "0x4000533")]
		STARTED = 8u,
		[Token(Token = "0x4000534")]
		RESTARTED = 0x10u,
		[Token(Token = "0x4000535")]
		STOPPED = 0x20u,
		[Token(Token = "0x4000536")]
		START_FAILED = 0x40u,
		[Token(Token = "0x4000537")]
		CREATE_PROGRAMMER_SOUND = 0x80u,
		[Token(Token = "0x4000538")]
		DESTROY_PROGRAMMER_SOUND = 0x100u,
		[Token(Token = "0x4000539")]
		PLUGIN_CREATED = 0x200u,
		[Token(Token = "0x400053A")]
		PLUGIN_DESTROYED = 0x400u,
		[Token(Token = "0x400053B")]
		TIMELINE_MARKER = 0x800u,
		[Token(Token = "0x400053C")]
		TIMELINE_BEAT = 0x1000u,
		[Token(Token = "0x400053D")]
		SOUND_PLAYED = 0x2000u,
		[Token(Token = "0x400053E")]
		SOUND_STOPPED = 0x4000u,
		[Token(Token = "0x400053F")]
		REAL_TO_VIRTUAL = 0x8000u,
		[Token(Token = "0x4000540")]
		VIRTUAL_TO_REAL = 0x10000u,
		[Token(Token = "0x4000541")]
		ALL = uint.MaxValue
	}
	[Token(Token = "0x2000100")]
	public delegate RESULT EVENT_CALLBACK(EVENT_CALLBACK_TYPE type, EventInstance _event, IntPtr parameters);
	[Token(Token = "0x2000101")]
	public delegate RESULT COMMANDREPLAY_FRAME_CALLBACK(CommandReplay replay, int commandindex, float currenttime, IntPtr userdata);
	[Token(Token = "0x2000102")]
	public delegate RESULT COMMANDREPLAY_LOAD_BANK_CALLBACK(CommandReplay replay, int commandindex, Guid bankguid, StringWrapper bankfilename, LOAD_BANK_FLAGS flags, out Bank bank, IntPtr userdata);
	[Token(Token = "0x2000103")]
	public delegate RESULT COMMANDREPLAY_CREATE_INSTANCE_CALLBACK(CommandReplay replay, int commandindex, EventDescription eventdescription, out EventInstance instance, IntPtr userdata);
	[Token(Token = "0x2000104")]
	public enum INSTANCETYPE
	{
		[Token(Token = "0x4000543")]
		NONE,
		[Token(Token = "0x4000544")]
		SYSTEM,
		[Token(Token = "0x4000545")]
		EVENTDESCRIPTION,
		[Token(Token = "0x4000546")]
		EVENTINSTANCE,
		[Token(Token = "0x4000547")]
		PARAMETERINSTANCE,
		[Token(Token = "0x4000548")]
		BUS,
		[Token(Token = "0x4000549")]
		VCA,
		[Token(Token = "0x400054A")]
		BANK,
		[Token(Token = "0x400054B")]
		COMMANDREPLAY
	}
	[Token(Token = "0x2000105")]
	public struct COMMAND_INFO
	{
		[Token(Token = "0x400054C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public StringWrapper commandname;

		[Token(Token = "0x400054D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public int parentcommandindex;

		[Token(Token = "0x400054E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public int framenumber;

		[Token(Token = "0x400054F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float frametime;

		[Token(Token = "0x4000550")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public INSTANCETYPE instancetype;

		[Token(Token = "0x4000551")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public INSTANCETYPE outputtype;

		[Token(Token = "0x4000552")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public uint instancehandle;

		[Token(Token = "0x4000553")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public uint outputhandle;
	}
	[Token(Token = "0x2000106")]
	public struct Util
	{
		[Token(Token = "0x60006C8")]
		[Address(RVA = "0xFBF498", Offset = "0xFBF498", VA = "0xFBF498")]
		public static RESULT parseID(string idString, out Guid id)
		{
			return default(RESULT);
		}

		[PreserveSig]
		[Token(Token = "0x60006C9")]
		[Address(RVA = "0xFBF5E0", Offset = "0xFBF5E0", VA = "0xFBF5E0")]
		private static extern RESULT FMOD_Studio_ParseID(byte[] idString, out Guid id);
	}
	[Token(Token = "0x2000107")]
	public struct System
	{
		[Token(Token = "0x4000554")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public IntPtr handle;

		[Token(Token = "0x60006CA")]
		[Address(RVA = "0x158F990", Offset = "0x158F990", VA = "0x158F990")]
		public static RESULT create(out System system)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60006CB")]
		[Address(RVA = "0x158FA2C", Offset = "0x158FA2C", VA = "0x158FA2C")]
		public RESULT setAdvancedSettings(ADVANCEDSETTINGS settings)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60006CC")]
		[Address(RVA = "0x158FB80", Offset = "0x158FB80", VA = "0x158FB80")]
		public RESULT setAdvancedSettings(ADVANCEDSETTINGS settings, string encryptionKey)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60006CD")]
		[Address(RVA = "0x158FCEC", Offset = "0x158FCEC", VA = "0x158FCEC")]
		public RESULT getAdvancedSettings(out ADVANCEDSETTINGS settings)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60006CE")]
		[Address(RVA = "0x158FE40", Offset = "0x158FE40", VA = "0x158FE40")]
		public RESULT initialize(int maxchannels, INITFLAGS studioflags, FMOD.INITFLAGS flags, IntPtr extradriverdata)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60006CF")]
		[Address(RVA = "0x158FEF8", Offset = "0x158FEF8", VA = "0x158FEF8")]
		public RESULT release()
		{
			return default(RESULT);
		}

		[Token(Token = "0x60006D0")]
		[Address(RVA = "0x158FF80", Offset = "0x158FF80", VA = "0x158FF80")]
		public RESULT update()
		{
			return default(RESULT);
		}

		[Token(Token = "0x60006D1")]
		[Address(RVA = "0x1590008", Offset = "0x1590008", VA = "0x1590008")]
		public RESULT getCoreSystem(out FMOD.System coresystem)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60006D2")]
		[Address(RVA = "0x15900A0", Offset = "0x15900A0", VA = "0x15900A0")]
		public RESULT getEvent(string path, out EventDescription _event)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60006D3")]
		[Address(RVA = "0x1590290", Offset = "0x1590290", VA = "0x1590290")]
		public RESULT getBus(string path, out Bus bus)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60006D4")]
		[Address(RVA = "0x1590480", Offset = "0x1590480", VA = "0x1590480")]
		public RESULT getVCA(string path, out VCA vca)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60006D5")]
		[Address(RVA = "0x1590670", Offset = "0x1590670", VA = "0x1590670")]
		public RESULT getBank(string path, out Bank bank)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60006D6")]
		[Address(RVA = "0x1590860", Offset = "0x1590860", VA = "0x1590860")]
		public RESULT getEventByID(Guid id, out EventDescription _event)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60006D7")]
		[Address(RVA = "0x1590924", Offset = "0x1590924", VA = "0x1590924")]
		public RESULT getBusByID(Guid id, out Bus bus)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60006D8")]
		[Address(RVA = "0x15909E8", Offset = "0x15909E8", VA = "0x15909E8")]
		public RESULT getVCAByID(Guid id, out VCA vca)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60006D9")]
		[Address(RVA = "0x1590AAC", Offset = "0x1590AAC", VA = "0x1590AAC")]
		public RESULT getBankByID(Guid id, out Bank bank)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60006DA")]
		[Address(RVA = "0x1590B70", Offset = "0x1590B70", VA = "0x1590B70")]
		public RESULT getSoundInfo(string key, out SOUND_INFO info)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60006DB")]
		[Address(RVA = "0x1590DC8", Offset = "0x1590DC8", VA = "0x1590DC8")]
		public RESULT getParameterDescriptionByName(string name, out PARAMETER_DESCRIPTION parameter)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60006DC")]
		[Address(RVA = "0x1590FB8", Offset = "0x1590FB8", VA = "0x1590FB8")]
		public RESULT getParameterDescriptionByID(PARAMETER_ID id, out PARAMETER_DESCRIPTION parameter)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60006DD")]
		[Address(RVA = "0x1591058", Offset = "0x1591058", VA = "0x1591058")]
		public RESULT getParameterByID(PARAMETER_ID id, out float value)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60006DE")]
		[Address(RVA = "0x1591080", Offset = "0x1591080", VA = "0x1591080")]
		public RESULT getParameterByID(PARAMETER_ID id, out float value, out float finalvalue)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60006DF")]
		[Address(RVA = "0x1591130", Offset = "0x1591130", VA = "0x1591130")]
		public RESULT setParameterByID(PARAMETER_ID id, float value, bool ignoreseekspeed = false)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60006E0")]
		[Address(RVA = "0x15911E4", Offset = "0x15911E4", VA = "0x15911E4")]
		public RESULT setParametersByIDs(PARAMETER_ID[] ids, float[] values, int count, bool ignoreseekspeed = false)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60006E1")]
		[Address(RVA = "0x15912B0", Offset = "0x15912B0", VA = "0x15912B0")]
		public RESULT getParameterByName(string name, out float value)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60006E2")]
		[Address(RVA = "0x15912D4", Offset = "0x15912D4", VA = "0x15912D4")]
		public RESULT getParameterByName(string name, out float value, out float finalvalue)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60006E3")]
		[Address(RVA = "0x15914E4", Offset = "0x15914E4", VA = "0x15914E4")]
		public RESULT setParameterByName(string name, float value, bool ignoreseekspeed = false)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60006E4")]
		[Address(RVA = "0x15916F4", Offset = "0x15916F4", VA = "0x15916F4")]
		public RESULT lookupID(string path, out Guid id)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60006E5")]
		[Address(RVA = "0x15918E4", Offset = "0x15918E4", VA = "0x15918E4")]
		public RESULT lookupPath(Guid id, out string path)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60006E6")]
		[Address(RVA = "0x1591BF0", Offset = "0x1591BF0", VA = "0x1591BF0")]
		public RESULT getNumListeners(out int numlisteners)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60006E7")]
		[Address(RVA = "0x1591C88", Offset = "0x1591C88", VA = "0x1591C88")]
		public RESULT setNumListeners(int numlisteners)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60006E8")]
		[Address(RVA = "0x1591D20", Offset = "0x1591D20", VA = "0x1591D20")]
		public RESULT getListenerAttributes(int listener, out ATTRIBUTES_3D attributes)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60006E9")]
		[Address(RVA = "0x1591DC0", Offset = "0x1591DC0", VA = "0x1591DC0")]
		public RESULT setListenerAttributes(int listener, ATTRIBUTES_3D attributes)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60006EA")]
		[Address(RVA = "0x1591E60", Offset = "0x1591E60", VA = "0x1591E60")]
		public RESULT getListenerWeight(int listener, out float weight)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60006EB")]
		[Address(RVA = "0x1591F00", Offset = "0x1591F00", VA = "0x1591F00")]
		public RESULT setListenerWeight(int listener, float weight)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60006EC")]
		[Address(RVA = "0x1591FA8", Offset = "0x1591FA8", VA = "0x1591FA8")]
		public RESULT loadBankFile(string filename, LOAD_BANK_FLAGS flags, out Bank bank)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60006ED")]
		[Address(RVA = "0x15921B8", Offset = "0x15921B8", VA = "0x15921B8")]
		public RESULT loadBankMemory(byte[] buffer, LOAD_BANK_FLAGS flags, out Bank bank)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60006EE")]
		[Address(RVA = "0x1592308", Offset = "0x1592308", VA = "0x1592308")]
		public RESULT loadBankCustom(BANK_INFO info, LOAD_BANK_FLAGS flags, out Bank bank)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60006EF")]
		[Address(RVA = "0x15924F8", Offset = "0x15924F8", VA = "0x15924F8")]
		public RESULT unloadAll()
		{
			return default(RESULT);
		}

		[Token(Token = "0x60006F0")]
		[Address(RVA = "0x1592580", Offset = "0x1592580", VA = "0x1592580")]
		public RESULT flushCommands()
		{
			return default(RESULT);
		}

		[Token(Token = "0x60006F1")]
		[Address(RVA = "0x1592608", Offset = "0x1592608", VA = "0x1592608")]
		public RESULT flushSampleLoading()
		{
			return default(RESULT);
		}

		[Token(Token = "0x60006F2")]
		[Address(RVA = "0x1592690", Offset = "0x1592690", VA = "0x1592690")]
		public RESULT startCommandCapture(string filename, COMMANDCAPTURE_FLAGS flags)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60006F3")]
		[Address(RVA = "0x1592880", Offset = "0x1592880", VA = "0x1592880")]
		public RESULT stopCommandCapture()
		{
			return default(RESULT);
		}

		[Token(Token = "0x60006F4")]
		[Address(RVA = "0x1592908", Offset = "0x1592908", VA = "0x1592908")]
		public RESULT loadCommandReplay(string filename, COMMANDREPLAY_FLAGS flags, out CommandReplay replay)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60006F5")]
		[Address(RVA = "0x1592B18", Offset = "0x1592B18", VA = "0x1592B18")]
		public RESULT getBankCount(out int count)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60006F6")]
		[Address(RVA = "0x1592BB0", Offset = "0x1592BB0", VA = "0x1592BB0")]
		public RESULT getBankList(out Bank[] array)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60006F7")]
		[Address(RVA = "0x1592DC8", Offset = "0x1592DC8", VA = "0x1592DC8")]
		public RESULT getParameterDescriptionCount(out int count)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60006F8")]
		[Address(RVA = "0x1592E60", Offset = "0x1592E60", VA = "0x1592E60")]
		public RESULT getParameterDescriptionList(out PARAMETER_DESCRIPTION[] array)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60006F9")]
		[Address(RVA = "0x15930B8", Offset = "0x15930B8", VA = "0x15930B8")]
		public RESULT getCPUUsage(out CPU_USAGE usage)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60006FA")]
		[Address(RVA = "0x1593150", Offset = "0x1593150", VA = "0x1593150")]
		public RESULT getBufferUsage(out BUFFER_USAGE usage)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60006FB")]
		[Address(RVA = "0x15931E8", Offset = "0x15931E8", VA = "0x15931E8")]
		public RESULT resetBufferUsage()
		{
			return default(RESULT);
		}

		[Token(Token = "0x60006FC")]
		[Address(RVA = "0x1593270", Offset = "0x1593270", VA = "0x1593270")]
		public RESULT setCallback(SYSTEM_CALLBACK callback, SYSTEM_CALLBACK_TYPE callbackmask = SYSTEM_CALLBACK_TYPE.ALL)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60006FD")]
		[Address(RVA = "0x1593318", Offset = "0x1593318", VA = "0x1593318")]
		public RESULT getUserData(out IntPtr userdata)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60006FE")]
		[Address(RVA = "0x15933B0", Offset = "0x15933B0", VA = "0x15933B0")]
		public RESULT setUserData(IntPtr userdata)
		{
			return default(RESULT);
		}

		[PreserveSig]
		[Token(Token = "0x60006FF")]
		[Address(RVA = "0x158F99C", Offset = "0x158F99C", VA = "0x158F99C")]
		private static extern RESULT FMOD_Studio_System_Create(out IntPtr system, uint headerversion);

		[PreserveSig]
		[Token(Token = "0x6000700")]
		[Address(RVA = "0x1593448", Offset = "0x1593448", VA = "0x1593448")]
		private static extern bool FMOD_Studio_System_IsValid(IntPtr system);

		[PreserveSig]
		[Token(Token = "0x6000701")]
		[Address(RVA = "0x158FAF0", Offset = "0x158FAF0", VA = "0x158FAF0")]
		private static extern RESULT FMOD_Studio_System_SetAdvancedSettings(IntPtr system, ref ADVANCEDSETTINGS settings);

		[PreserveSig]
		[Token(Token = "0x6000702")]
		[Address(RVA = "0x158FDB0", Offset = "0x158FDB0", VA = "0x158FDB0")]
		private static extern RESULT FMOD_Studio_System_GetAdvancedSettings(IntPtr system, out ADVANCEDSETTINGS settings);

		[PreserveSig]
		[Token(Token = "0x6000703")]
		[Address(RVA = "0x158FE48", Offset = "0x158FE48", VA = "0x158FE48")]
		private static extern RESULT FMOD_Studio_System_Initialize(IntPtr system, int maxchannels, INITFLAGS studioflags, FMOD.INITFLAGS flags, IntPtr extradriverdata);

		[PreserveSig]
		[Token(Token = "0x6000704")]
		[Address(RVA = "0x158FF00", Offset = "0x158FF00", VA = "0x158FF00")]
		private static extern RESULT FMOD_Studio_System_Release(IntPtr system);

		[PreserveSig]
		[Token(Token = "0x6000705")]
		[Address(RVA = "0x158FF88", Offset = "0x158FF88", VA = "0x158FF88")]
		private static extern RESULT FMOD_Studio_System_Update(IntPtr system);

		[PreserveSig]
		[Token(Token = "0x6000706")]
		[Address(RVA = "0x1590010", Offset = "0x1590010", VA = "0x1590010")]
		private static extern RESULT FMOD_Studio_System_GetCoreSystem(IntPtr system, out IntPtr coresystem);

		[PreserveSig]
		[Token(Token = "0x6000707")]
		[Address(RVA = "0x15901F0", Offset = "0x15901F0", VA = "0x15901F0")]
		private static extern RESULT FMOD_Studio_System_GetEvent(IntPtr system, byte[] path, out IntPtr _event);

		[PreserveSig]
		[Token(Token = "0x6000708")]
		[Address(RVA = "0x15903E0", Offset = "0x15903E0", VA = "0x15903E0")]
		private static extern RESULT FMOD_Studio_System_GetBus(IntPtr system, byte[] path, out IntPtr bus);

		[PreserveSig]
		[Token(Token = "0x6000709")]
		[Address(RVA = "0x15905D0", Offset = "0x15905D0", VA = "0x15905D0")]
		private static extern RESULT FMOD_Studio_System_GetVCA(IntPtr system, byte[] path, out IntPtr vca);

		[PreserveSig]
		[Token(Token = "0x600070A")]
		[Address(RVA = "0x15907C0", Offset = "0x15907C0", VA = "0x15907C0")]
		private static extern RESULT FMOD_Studio_System_GetBank(IntPtr system, byte[] path, out IntPtr bank);

		[PreserveSig]
		[Token(Token = "0x600070B")]
		[Address(RVA = "0x159088C", Offset = "0x159088C", VA = "0x159088C")]
		private static extern RESULT FMOD_Studio_System_GetEventByID(IntPtr system, ref Guid id, out IntPtr _event);

		[PreserveSig]
		[Token(Token = "0x600070C")]
		[Address(RVA = "0x1590950", Offset = "0x1590950", VA = "0x1590950")]
		private static extern RESULT FMOD_Studio_System_GetBusByID(IntPtr system, ref Guid id, out IntPtr bus);

		[PreserveSig]
		[Token(Token = "0x600070D")]
		[Address(RVA = "0x1590A14", Offset = "0x1590A14", VA = "0x1590A14")]
		private static extern RESULT FMOD_Studio_System_GetVCAByID(IntPtr system, ref Guid id, out IntPtr vca);

		[PreserveSig]
		[Token(Token = "0x600070E")]
		[Address(RVA = "0x1590AD8", Offset = "0x1590AD8", VA = "0x1590AD8")]
		private static extern RESULT FMOD_Studio_System_GetBankByID(IntPtr system, ref Guid id, out IntPtr bank);

		[PreserveSig]
		[Token(Token = "0x600070F")]
		[Address(RVA = "0x1590CC0", Offset = "0x1590CC0", VA = "0x1590CC0")]
		private static extern RESULT FMOD_Studio_System_GetSoundInfo(IntPtr system, byte[] key, out SOUND_INFO info);

		[PreserveSig]
		[Token(Token = "0x6000710")]
		[Address(RVA = "0x1590F18", Offset = "0x1590F18", VA = "0x1590F18")]
		private static extern RESULT FMOD_Studio_System_GetParameterDescriptionByName(IntPtr system, byte[] name, out PARAMETER_DESCRIPTION parameter);

		[PreserveSig]
		[Token(Token = "0x6000711")]
		[Address(RVA = "0x1590FC0", Offset = "0x1590FC0", VA = "0x1590FC0")]
		private static extern RESULT FMOD_Studio_System_GetParameterDescriptionByID(IntPtr system, PARAMETER_ID id, out PARAMETER_DESCRIPTION parameter);

		[PreserveSig]
		[Token(Token = "0x6000712")]
		[Address(RVA = "0x1591088", Offset = "0x1591088", VA = "0x1591088")]
		private static extern RESULT FMOD_Studio_System_GetParameterByID(IntPtr system, PARAMETER_ID id, out float value, out float finalvalue);

		[PreserveSig]
		[Token(Token = "0x6000713")]
		[Address(RVA = "0x159113C", Offset = "0x159113C", VA = "0x159113C")]
		private static extern RESULT FMOD_Studio_System_SetParameterByID(IntPtr system, PARAMETER_ID id, float value, bool ignoreseekspeed);

		[PreserveSig]
		[Token(Token = "0x6000714")]
		[Address(RVA = "0x15911F0", Offset = "0x15911F0", VA = "0x15911F0")]
		private static extern RESULT FMOD_Studio_System_SetParametersByIDs(IntPtr system, PARAMETER_ID[] ids, float[] values, int count, bool ignoreseekspeed);

		[PreserveSig]
		[Token(Token = "0x6000715")]
		[Address(RVA = "0x1591434", Offset = "0x1591434", VA = "0x1591434")]
		private static extern RESULT FMOD_Studio_System_GetParameterByName(IntPtr system, byte[] name, out float value, out float finalvalue);

		[PreserveSig]
		[Token(Token = "0x6000716")]
		[Address(RVA = "0x1591644", Offset = "0x1591644", VA = "0x1591644")]
		private static extern RESULT FMOD_Studio_System_SetParameterByName(IntPtr system, byte[] name, float value, bool ignoreseekspeed);

		[PreserveSig]
		[Token(Token = "0x6000717")]
		[Address(RVA = "0x1591844", Offset = "0x1591844", VA = "0x1591844")]
		private static extern RESULT FMOD_Studio_System_LookupID(IntPtr system, byte[] path, out Guid id);

		[PreserveSig]
		[Token(Token = "0x6000718")]
		[Address(RVA = "0x1591B40", Offset = "0x1591B40", VA = "0x1591B40")]
		private static extern RESULT FMOD_Studio_System_LookupPath(IntPtr system, ref Guid id, IntPtr path, int size, out int retrieved);

		[PreserveSig]
		[Token(Token = "0x6000719")]
		[Address(RVA = "0x1591BF8", Offset = "0x1591BF8", VA = "0x1591BF8")]
		private static extern RESULT FMOD_Studio_System_GetNumListeners(IntPtr system, out int numlisteners);

		[PreserveSig]
		[Token(Token = "0x600071A")]
		[Address(RVA = "0x1591C90", Offset = "0x1591C90", VA = "0x1591C90")]
		private static extern RESULT FMOD_Studio_System_SetNumListeners(IntPtr system, int numlisteners);

		[PreserveSig]
		[Token(Token = "0x600071B")]
		[Address(RVA = "0x1591D28", Offset = "0x1591D28", VA = "0x1591D28")]
		private static extern RESULT FMOD_Studio_System_GetListenerAttributes(IntPtr system, int listener, out ATTRIBUTES_3D attributes);

		[PreserveSig]
		[Token(Token = "0x600071C")]
		[Address(RVA = "0x1591DC8", Offset = "0x1591DC8", VA = "0x1591DC8")]
		private static extern RESULT FMOD_Studio_System_SetListenerAttributes(IntPtr system, int listener, ref ATTRIBUTES_3D attributes);

		[PreserveSig]
		[Token(Token = "0x600071D")]
		[Address(RVA = "0x1591E68", Offset = "0x1591E68", VA = "0x1591E68")]
		private static extern RESULT FMOD_Studio_System_GetListenerWeight(IntPtr system, int listener, out float weight);

		[PreserveSig]
		[Token(Token = "0x600071E")]
		[Address(RVA = "0x1591F08", Offset = "0x1591F08", VA = "0x1591F08")]
		private static extern RESULT FMOD_Studio_System_SetListenerWeight(IntPtr system, int listener, float weight);

		[PreserveSig]
		[Token(Token = "0x600071F")]
		[Address(RVA = "0x1592108", Offset = "0x1592108", VA = "0x1592108")]
		private static extern RESULT FMOD_Studio_System_LoadBankFile(IntPtr system, byte[] filename, LOAD_BANK_FLAGS flags, out IntPtr bank);

		[PreserveSig]
		[Token(Token = "0x6000720")]
		[Address(RVA = "0x1592248", Offset = "0x1592248", VA = "0x1592248")]
		private static extern RESULT FMOD_Studio_System_LoadBankMemory(IntPtr system, IntPtr buffer, int length, LOAD_MEMORY_MODE mode, LOAD_BANK_FLAGS flags, out IntPtr bank);

		[PreserveSig]
		[Token(Token = "0x6000721")]
		[Address(RVA = "0x15923E8", Offset = "0x15923E8", VA = "0x15923E8")]
		private static extern RESULT FMOD_Studio_System_LoadBankCustom(IntPtr system, ref BANK_INFO info, LOAD_BANK_FLAGS flags, out IntPtr bank);

		[PreserveSig]
		[Token(Token = "0x6000722")]
		[Address(RVA = "0x1592500", Offset = "0x1592500", VA = "0x1592500")]
		private static extern RESULT FMOD_Studio_System_UnloadAll(IntPtr system);

		[PreserveSig]
		[Token(Token = "0x6000723")]
		[Address(RVA = "0x1592588", Offset = "0x1592588", VA = "0x1592588")]
		private static extern RESULT FMOD_Studio_System_FlushCommands(IntPtr system);

		[PreserveSig]
		[Token(Token = "0x6000724")]
		[Address(RVA = "0x1592610", Offset = "0x1592610", VA = "0x1592610")]
		private static extern RESULT FMOD_Studio_System_FlushSampleLoading(IntPtr system);

		[PreserveSig]
		[Token(Token = "0x6000725")]
		[Address(RVA = "0x15927E0", Offset = "0x15927E0", VA = "0x15927E0")]
		private static extern RESULT FMOD_Studio_System_StartCommandCapture(IntPtr system, byte[] filename, COMMANDCAPTURE_FLAGS flags);

		[PreserveSig]
		[Token(Token = "0x6000726")]
		[Address(RVA = "0x1592888", Offset = "0x1592888", VA = "0x1592888")]
		private static extern RESULT FMOD_Studio_System_StopCommandCapture(IntPtr system);

		[PreserveSig]
		[Token(Token = "0x6000727")]
		[Address(RVA = "0x1592A68", Offset = "0x1592A68", VA = "0x1592A68")]
		private static extern RESULT FMOD_Studio_System_LoadCommandReplay(IntPtr system, byte[] filename, COMMANDREPLAY_FLAGS flags, out IntPtr replay);

		[PreserveSig]
		[Token(Token = "0x6000728")]
		[Address(RVA = "0x1592B20", Offset = "0x1592B20", VA = "0x1592B20")]
		private static extern RESULT FMOD_Studio_System_GetBankCount(IntPtr system, out int count);

		[PreserveSig]
		[Token(Token = "0x6000729")]
		[Address(RVA = "0x1592D18", Offset = "0x1592D18", VA = "0x1592D18")]
		private static extern RESULT FMOD_Studio_System_GetBankList(IntPtr system, IntPtr[] array, int capacity, out int count);

		[PreserveSig]
		[Token(Token = "0x600072A")]
		[Address(RVA = "0x1592DD0", Offset = "0x1592DD0", VA = "0x1592DD0")]
		private static extern RESULT FMOD_Studio_System_GetParameterDescriptionCount(IntPtr system, out int count);

		[PreserveSig]
		[Token(Token = "0x600072B")]
		[Address(RVA = "0x1592F68", Offset = "0x1592F68", VA = "0x1592F68")]
		private static extern RESULT FMOD_Studio_System_GetParameterDescriptionList(IntPtr system, [Out] PARAMETER_DESCRIPTION[] array, int capacity, out int count);

		[PreserveSig]
		[Token(Token = "0x600072C")]
		[Address(RVA = "0x15930C0", Offset = "0x15930C0", VA = "0x15930C0")]
		private static extern RESULT FMOD_Studio_System_GetCPUUsage(IntPtr system, out CPU_USAGE usage);

		[PreserveSig]
		[Token(Token = "0x600072D")]
		[Address(RVA = "0x1593158", Offset = "0x1593158", VA = "0x1593158")]
		private static extern RESULT FMOD_Studio_System_GetBufferUsage(IntPtr system, out BUFFER_USAGE usage);

		[PreserveSig]
		[Token(Token = "0x600072E")]
		[Address(RVA = "0x15931F0", Offset = "0x15931F0", VA = "0x15931F0")]
		private static extern RESULT FMOD_Studio_System_ResetBufferUsage(IntPtr system);

		[PreserveSig]
		[Token(Token = "0x600072F")]
		[Address(RVA = "0x1593278", Offset = "0x1593278", VA = "0x1593278")]
		private static extern RESULT FMOD_Studio_System_SetCallback(IntPtr system, SYSTEM_CALLBACK callback, SYSTEM_CALLBACK_TYPE callbackmask);

		[PreserveSig]
		[Token(Token = "0x6000730")]
		[Address(RVA = "0x1593320", Offset = "0x1593320", VA = "0x1593320")]
		private static extern RESULT FMOD_Studio_System_GetUserData(IntPtr system, out IntPtr userdata);

		[PreserveSig]
		[Token(Token = "0x6000731")]
		[Address(RVA = "0x15933B8", Offset = "0x15933B8", VA = "0x15933B8")]
		private static extern RESULT FMOD_Studio_System_SetUserData(IntPtr system, IntPtr userdata);

		[Token(Token = "0x6000732")]
		[Address(RVA = "0x15934D0", Offset = "0x15934D0", VA = "0x15934D0")]
		public bool hasHandle()
		{
			return default(bool);
		}

		[Token(Token = "0x6000733")]
		[Address(RVA = "0x159351C", Offset = "0x159351C", VA = "0x159351C")]
		public void clearHandle()
		{
		}

		[Token(Token = "0x6000734")]
		[Address(RVA = "0x1593560", Offset = "0x1593560", VA = "0x1593560")]
		public bool isValid()
		{
			return default(bool);
		}
	}
	[Token(Token = "0x2000108")]
	public struct EventDescription
	{
		[Token(Token = "0x4000555")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public IntPtr handle;

		[Token(Token = "0x6000735")]
		[Address(RVA = "0x158C1B0", Offset = "0x158C1B0", VA = "0x158C1B0")]
		public RESULT getID(out Guid id)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000736")]
		[Address(RVA = "0x158C248", Offset = "0x158C248", VA = "0x158C248")]
		public RESULT getPath(out string path)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000737")]
		[Address(RVA = "0x158C540", Offset = "0x158C540", VA = "0x158C540")]
		public RESULT getParameterDescriptionCount(out int count)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000738")]
		[Address(RVA = "0x158C5D8", Offset = "0x158C5D8", VA = "0x158C5D8")]
		public RESULT getParameterDescriptionByIndex(int index, out PARAMETER_DESCRIPTION parameter)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000739")]
		[Address(RVA = "0x158C678", Offset = "0x158C678", VA = "0x158C678")]
		public RESULT getParameterDescriptionByName(string name, out PARAMETER_DESCRIPTION parameter)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600073A")]
		[Address(RVA = "0x158C868", Offset = "0x158C868", VA = "0x158C868")]
		public RESULT getParameterDescriptionByID(PARAMETER_ID id, out PARAMETER_DESCRIPTION parameter)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600073B")]
		[Address(RVA = "0x158C908", Offset = "0x158C908", VA = "0x158C908")]
		public RESULT getUserPropertyCount(out int count)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600073C")]
		[Address(RVA = "0x158C9A0", Offset = "0x158C9A0", VA = "0x158C9A0")]
		public RESULT getUserPropertyByIndex(int index, out USER_PROPERTY property)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600073D")]
		[Address(RVA = "0x158CA8C", Offset = "0x158CA8C", VA = "0x158CA8C")]
		public RESULT getUserProperty(string name, out USER_PROPERTY property)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600073E")]
		[Address(RVA = "0x158CCC8", Offset = "0x158CCC8", VA = "0x158CCC8")]
		public RESULT getLength(out int length)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600073F")]
		[Address(RVA = "0x158CD60", Offset = "0x158CD60", VA = "0x158CD60")]
		public RESULT getMinimumDistance(out float distance)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000740")]
		[Address(RVA = "0x158CDF8", Offset = "0x158CDF8", VA = "0x158CDF8")]
		public RESULT getMaximumDistance(out float distance)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000741")]
		[Address(RVA = "0x158CE90", Offset = "0x158CE90", VA = "0x158CE90")]
		public RESULT getSoundSize(out float size)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000742")]
		[Address(RVA = "0x158CF28", Offset = "0x158CF28", VA = "0x158CF28")]
		public RESULT isSnapshot(out bool snapshot)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000743")]
		[Address(RVA = "0x158CFD4", Offset = "0x158CFD4", VA = "0x158CFD4")]
		public RESULT isOneshot(out bool oneshot)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000744")]
		[Address(RVA = "0x158D080", Offset = "0x158D080", VA = "0x158D080")]
		public RESULT isStream(out bool isStream)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000745")]
		[Address(RVA = "0x158D12C", Offset = "0x158D12C", VA = "0x158D12C")]
		public RESULT is3D(out bool is3D)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000746")]
		[Address(RVA = "0x158D1D8", Offset = "0x158D1D8", VA = "0x158D1D8")]
		public RESULT hasCue(out bool cue)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000747")]
		[Address(RVA = "0x158D284", Offset = "0x158D284", VA = "0x158D284")]
		public RESULT createInstance(out EventInstance instance)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000748")]
		[Address(RVA = "0x158D31C", Offset = "0x158D31C", VA = "0x158D31C")]
		public RESULT getInstanceCount(out int count)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000749")]
		[Address(RVA = "0x158D3B4", Offset = "0x158D3B4", VA = "0x158D3B4")]
		public RESULT getInstanceList(out EventInstance[] array)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600074A")]
		[Address(RVA = "0x158D5CC", Offset = "0x158D5CC", VA = "0x158D5CC")]
		public RESULT loadSampleData()
		{
			return default(RESULT);
		}

		[Token(Token = "0x600074B")]
		[Address(RVA = "0x158D654", Offset = "0x158D654", VA = "0x158D654")]
		public RESULT unloadSampleData()
		{
			return default(RESULT);
		}

		[Token(Token = "0x600074C")]
		[Address(RVA = "0x158D6DC", Offset = "0x158D6DC", VA = "0x158D6DC")]
		public RESULT getSampleLoadingState(out LOADING_STATE state)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600074D")]
		[Address(RVA = "0x158D774", Offset = "0x158D774", VA = "0x158D774")]
		public RESULT releaseAllInstances()
		{
			return default(RESULT);
		}

		[Token(Token = "0x600074E")]
		[Address(RVA = "0x158D7FC", Offset = "0x158D7FC", VA = "0x158D7FC")]
		public RESULT setCallback(EVENT_CALLBACK callback, EVENT_CALLBACK_TYPE callbackmask = EVENT_CALLBACK_TYPE.ALL)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600074F")]
		[Address(RVA = "0x158D8A4", Offset = "0x158D8A4", VA = "0x158D8A4")]
		public RESULT getUserData(out IntPtr userdata)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000750")]
		[Address(RVA = "0x158D93C", Offset = "0x158D93C", VA = "0x158D93C")]
		public RESULT setUserData(IntPtr userdata)
		{
			return default(RESULT);
		}

		[PreserveSig]
		[Token(Token = "0x6000751")]
		[Address(RVA = "0x158D9D4", Offset = "0x158D9D4", VA = "0x158D9D4")]
		private static extern bool FMOD_Studio_EventDescription_IsValid(IntPtr eventdescription);

		[PreserveSig]
		[Token(Token = "0x6000752")]
		[Address(RVA = "0x158C1B8", Offset = "0x158C1B8", VA = "0x158C1B8")]
		private static extern RESULT FMOD_Studio_EventDescription_GetID(IntPtr eventdescription, out Guid id);

		[PreserveSig]
		[Token(Token = "0x6000753")]
		[Address(RVA = "0x158C498", Offset = "0x158C498", VA = "0x158C498")]
		private static extern RESULT FMOD_Studio_EventDescription_GetPath(IntPtr eventdescription, IntPtr path, int size, out int retrieved);

		[PreserveSig]
		[Token(Token = "0x6000754")]
		[Address(RVA = "0x158C548", Offset = "0x158C548", VA = "0x158C548")]
		private static extern RESULT FMOD_Studio_EventDescription_GetParameterDescriptionCount(IntPtr eventdescription, out int count);

		[PreserveSig]
		[Token(Token = "0x6000755")]
		[Address(RVA = "0x158C5E0", Offset = "0x158C5E0", VA = "0x158C5E0")]
		private static extern RESULT FMOD_Studio_EventDescription_GetParameterDescriptionByIndex(IntPtr eventdescription, int index, out PARAMETER_DESCRIPTION parameter);

		[PreserveSig]
		[Token(Token = "0x6000756")]
		[Address(RVA = "0x158C7C8", Offset = "0x158C7C8", VA = "0x158C7C8")]
		private static extern RESULT FMOD_Studio_EventDescription_GetParameterDescriptionByName(IntPtr eventdescription, byte[] name, out PARAMETER_DESCRIPTION parameter);

		[PreserveSig]
		[Token(Token = "0x6000757")]
		[Address(RVA = "0x158C870", Offset = "0x158C870", VA = "0x158C870")]
		private static extern RESULT FMOD_Studio_EventDescription_GetParameterDescriptionByID(IntPtr eventdescription, PARAMETER_ID id, out PARAMETER_DESCRIPTION parameter);

		[PreserveSig]
		[Token(Token = "0x6000758")]
		[Address(RVA = "0x158C910", Offset = "0x158C910", VA = "0x158C910")]
		private static extern RESULT FMOD_Studio_EventDescription_GetUserPropertyCount(IntPtr eventdescription, out int count);

		[PreserveSig]
		[Token(Token = "0x6000759")]
		[Address(RVA = "0x158C9A8", Offset = "0x158C9A8", VA = "0x158C9A8")]
		private static extern RESULT FMOD_Studio_EventDescription_GetUserPropertyByIndex(IntPtr eventdescription, int index, out USER_PROPERTY property);

		[PreserveSig]
		[Token(Token = "0x600075A")]
		[Address(RVA = "0x158CBDC", Offset = "0x158CBDC", VA = "0x158CBDC")]
		private static extern RESULT FMOD_Studio_EventDescription_GetUserProperty(IntPtr eventdescription, byte[] name, out USER_PROPERTY property);

		[PreserveSig]
		[Token(Token = "0x600075B")]
		[Address(RVA = "0x158CCD0", Offset = "0x158CCD0", VA = "0x158CCD0")]
		private static extern RESULT FMOD_Studio_EventDescription_GetLength(IntPtr eventdescription, out int length);

		[PreserveSig]
		[Token(Token = "0x600075C")]
		[Address(RVA = "0x158CD68", Offset = "0x158CD68", VA = "0x158CD68")]
		private static extern RESULT FMOD_Studio_EventDescription_GetMinimumDistance(IntPtr eventdescription, out float distance);

		[PreserveSig]
		[Token(Token = "0x600075D")]
		[Address(RVA = "0x158CE00", Offset = "0x158CE00", VA = "0x158CE00")]
		private static extern RESULT FMOD_Studio_EventDescription_GetMaximumDistance(IntPtr eventdescription, out float distance);

		[PreserveSig]
		[Token(Token = "0x600075E")]
		[Address(RVA = "0x158CE98", Offset = "0x158CE98", VA = "0x158CE98")]
		private static extern RESULT FMOD_Studio_EventDescription_GetSoundSize(IntPtr eventdescription, out float size);

		[PreserveSig]
		[Token(Token = "0x600075F")]
		[Address(RVA = "0x158CF30", Offset = "0x158CF30", VA = "0x158CF30")]
		private static extern RESULT FMOD_Studio_EventDescription_IsSnapshot(IntPtr eventdescription, out bool snapshot);

		[PreserveSig]
		[Token(Token = "0x6000760")]
		[Address(RVA = "0x158CFDC", Offset = "0x158CFDC", VA = "0x158CFDC")]
		private static extern RESULT FMOD_Studio_EventDescription_IsOneshot(IntPtr eventdescription, out bool oneshot);

		[PreserveSig]
		[Token(Token = "0x6000761")]
		[Address(RVA = "0x158D088", Offset = "0x158D088", VA = "0x158D088")]
		private static extern RESULT FMOD_Studio_EventDescription_IsStream(IntPtr eventdescription, out bool isStream);

		[PreserveSig]
		[Token(Token = "0x6000762")]
		[Address(RVA = "0x158D134", Offset = "0x158D134", VA = "0x158D134")]
		private static extern RESULT FMOD_Studio_EventDescription_Is3D(IntPtr eventdescription, out bool is3D);

		[PreserveSig]
		[Token(Token = "0x6000763")]
		[Address(RVA = "0x158D1E0", Offset = "0x158D1E0", VA = "0x158D1E0")]
		private static extern RESULT FMOD_Studio_EventDescription_HasCue(IntPtr eventdescription, out bool cue);

		[PreserveSig]
		[Token(Token = "0x6000764")]
		[Address(RVA = "0x158D28C", Offset = "0x158D28C", VA = "0x158D28C")]
		private static extern RESULT FMOD_Studio_EventDescription_CreateInstance(IntPtr eventdescription, out IntPtr instance);

		[PreserveSig]
		[Token(Token = "0x6000765")]
		[Address(RVA = "0x158D324", Offset = "0x158D324", VA = "0x158D324")]
		private static extern RESULT FMOD_Studio_EventDescription_GetInstanceCount(IntPtr eventdescription, out int count);

		[PreserveSig]
		[Token(Token = "0x6000766")]
		[Address(RVA = "0x158D51C", Offset = "0x158D51C", VA = "0x158D51C")]
		private static extern RESULT FMOD_Studio_EventDescription_GetInstanceList(IntPtr eventdescription, IntPtr[] array, int capacity, out int count);

		[PreserveSig]
		[Token(Token = "0x6000767")]
		[Address(RVA = "0x158D5D4", Offset = "0x158D5D4", VA = "0x158D5D4")]
		private static extern RESULT FMOD_Studio_EventDescription_LoadSampleData(IntPtr eventdescription);

		[PreserveSig]
		[Token(Token = "0x6000768")]
		[Address(RVA = "0x158D65C", Offset = "0x158D65C", VA = "0x158D65C")]
		private static extern RESULT FMOD_Studio_EventDescription_UnloadSampleData(IntPtr eventdescription);

		[PreserveSig]
		[Token(Token = "0x6000769")]
		[Address(RVA = "0x158D6E4", Offset = "0x158D6E4", VA = "0x158D6E4")]
		private static extern RESULT FMOD_Studio_EventDescription_GetSampleLoadingState(IntPtr eventdescription, out LOADING_STATE state);

		[PreserveSig]
		[Token(Token = "0x600076A")]
		[Address(RVA = "0x158D77C", Offset = "0x158D77C", VA = "0x158D77C")]
		private static extern RESULT FMOD_Studio_EventDescription_ReleaseAllInstances(IntPtr eventdescription);

		[PreserveSig]
		[Token(Token = "0x600076B")]
		[Address(RVA = "0x158D804", Offset = "0x158D804", VA = "0x158D804")]
		private static extern RESULT FMOD_Studio_EventDescription_SetCallback(IntPtr eventdescription, EVENT_CALLBACK callback, EVENT_CALLBACK_TYPE callbackmask);

		[PreserveSig]
		[Token(Token = "0x600076C")]
		[Address(RVA = "0x158D8AC", Offset = "0x158D8AC", VA = "0x158D8AC")]
		private static extern RESULT FMOD_Studio_EventDescription_GetUserData(IntPtr eventdescription, out IntPtr userdata);

		[PreserveSig]
		[Token(Token = "0x600076D")]
		[Address(RVA = "0x158D944", Offset = "0x158D944", VA = "0x158D944")]
		private static extern RESULT FMOD_Studio_EventDescription_SetUserData(IntPtr eventdescription, IntPtr userdata);

		[Token(Token = "0x600076E")]
		[Address(RVA = "0x158DA5C", Offset = "0x158DA5C", VA = "0x158DA5C")]
		public bool hasHandle()
		{
			return default(bool);
		}

		[Token(Token = "0x600076F")]
		[Address(RVA = "0x158DAA8", Offset = "0x158DAA8", VA = "0x158DAA8")]
		public void clearHandle()
		{
		}

		[Token(Token = "0x6000770")]
		[Address(RVA = "0x158DAEC", Offset = "0x158DAEC", VA = "0x158DAEC")]
		public bool isValid()
		{
			return default(bool);
		}
	}
	[Token(Token = "0x2000109")]
	public struct EventInstance
	{
		[Token(Token = "0x4000556")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public IntPtr handle;

		[Token(Token = "0x6000771")]
		[Address(RVA = "0x158DB24", Offset = "0x158DB24", VA = "0x158DB24")]
		public RESULT getDescription(out EventDescription description)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000772")]
		[Address(RVA = "0x158DBBC", Offset = "0x158DBBC", VA = "0x158DBBC")]
		public RESULT getVolume(out float volume)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000773")]
		[Address(RVA = "0x158DBE4", Offset = "0x158DBE4", VA = "0x158DBE4")]
		public RESULT getVolume(out float volume, out float finalvolume)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000774")]
		[Address(RVA = "0x158DC84", Offset = "0x158DC84", VA = "0x158DC84")]
		public RESULT setVolume(float volume)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000775")]
		[Address(RVA = "0x158DD1C", Offset = "0x158DD1C", VA = "0x158DD1C")]
		public RESULT getPitch(out float pitch)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000776")]
		[Address(RVA = "0x158DD44", Offset = "0x158DD44", VA = "0x158DD44")]
		public RESULT getPitch(out float pitch, out float finalpitch)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000777")]
		[Address(RVA = "0x158DDE4", Offset = "0x158DDE4", VA = "0x158DDE4")]
		public RESULT setPitch(float pitch)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000778")]
		[Address(RVA = "0x158DE7C", Offset = "0x158DE7C", VA = "0x158DE7C")]
		public RESULT get3DAttributes(out ATTRIBUTES_3D attributes)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000779")]
		[Address(RVA = "0x158DF14", Offset = "0x158DF14", VA = "0x158DF14")]
		public RESULT set3DAttributes(ATTRIBUTES_3D attributes)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600077A")]
		[Address(RVA = "0x158DFAC", Offset = "0x158DFAC", VA = "0x158DFAC")]
		public RESULT getListenerMask(out uint mask)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600077B")]
		[Address(RVA = "0x158E044", Offset = "0x158E044", VA = "0x158E044")]
		public RESULT setListenerMask(uint mask)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600077C")]
		[Address(RVA = "0x158E0DC", Offset = "0x158E0DC", VA = "0x158E0DC")]
		public RESULT getProperty(EVENT_PROPERTY index, out float value)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600077D")]
		[Address(RVA = "0x158E17C", Offset = "0x158E17C", VA = "0x158E17C")]
		public RESULT setProperty(EVENT_PROPERTY index, float value)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600077E")]
		[Address(RVA = "0x158E224", Offset = "0x158E224", VA = "0x158E224")]
		public RESULT getReverbLevel(int index, out float level)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600077F")]
		[Address(RVA = "0x158E2C4", Offset = "0x158E2C4", VA = "0x158E2C4")]
		public RESULT setReverbLevel(int index, float level)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000780")]
		[Address(RVA = "0x158E36C", Offset = "0x158E36C", VA = "0x158E36C")]
		public RESULT getPaused(out bool paused)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000781")]
		[Address(RVA = "0x158E418", Offset = "0x158E418", VA = "0x158E418")]
		public RESULT setPaused(bool paused)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000782")]
		[Address(RVA = "0x158E4B4", Offset = "0x158E4B4", VA = "0x158E4B4")]
		public RESULT start()
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000783")]
		[Address(RVA = "0x158E53C", Offset = "0x158E53C", VA = "0x158E53C")]
		public RESULT stop(STOP_MODE mode)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000784")]
		[Address(RVA = "0x158E5D4", Offset = "0x158E5D4", VA = "0x158E5D4")]
		public RESULT getTimelinePosition(out int position)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000785")]
		[Address(RVA = "0x158E66C", Offset = "0x158E66C", VA = "0x158E66C")]
		public RESULT setTimelinePosition(int position)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000786")]
		[Address(RVA = "0x158E704", Offset = "0x158E704", VA = "0x158E704")]
		public RESULT getPlaybackState(out PLAYBACK_STATE state)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000787")]
		[Address(RVA = "0x158E79C", Offset = "0x158E79C", VA = "0x158E79C")]
		public RESULT getChannelGroup(out ChannelGroup group)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000788")]
		[Address(RVA = "0x158E834", Offset = "0x158E834", VA = "0x158E834")]
		public RESULT release()
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000789")]
		[Address(RVA = "0x158E8BC", Offset = "0x158E8BC", VA = "0x158E8BC")]
		public RESULT isVirtual(out bool virtualstate)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600078A")]
		[Address(RVA = "0x158E968", Offset = "0x158E968", VA = "0x158E968")]
		public RESULT getParameterByID(PARAMETER_ID id, out float value)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600078B")]
		[Address(RVA = "0x158E990", Offset = "0x158E990", VA = "0x158E990")]
		public RESULT getParameterByID(PARAMETER_ID id, out float value, out float finalvalue)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600078C")]
		[Address(RVA = "0x158EA40", Offset = "0x158EA40", VA = "0x158EA40")]
		public RESULT setParameterByID(PARAMETER_ID id, float value, bool ignoreseekspeed = false)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600078D")]
		[Address(RVA = "0x158EAF4", Offset = "0x158EAF4", VA = "0x158EAF4")]
		public RESULT setParametersByIDs(PARAMETER_ID[] ids, float[] values, int count, bool ignoreseekspeed = false)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600078E")]
		[Address(RVA = "0x158EBC0", Offset = "0x158EBC0", VA = "0x158EBC0")]
		public RESULT getParameterByName(string name, out float value)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600078F")]
		[Address(RVA = "0x158EBE4", Offset = "0x158EBE4", VA = "0x158EBE4")]
		public RESULT getParameterByName(string name, out float value, out float finalvalue)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000790")]
		[Address(RVA = "0x158EDF4", Offset = "0x158EDF4", VA = "0x158EDF4")]
		public RESULT setParameterByName(string name, float value, bool ignoreseekspeed = false)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000791")]
		[Address(RVA = "0x158F004", Offset = "0x158F004", VA = "0x158F004")]
		public RESULT triggerCue()
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000792")]
		[Address(RVA = "0x158F08C", Offset = "0x158F08C", VA = "0x158F08C")]
		public RESULT setCallback(EVENT_CALLBACK callback, EVENT_CALLBACK_TYPE callbackmask = EVENT_CALLBACK_TYPE.ALL)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000793")]
		[Address(RVA = "0x158F134", Offset = "0x158F134", VA = "0x158F134")]
		public RESULT getUserData(out IntPtr userdata)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000794")]
		[Address(RVA = "0x158F1CC", Offset = "0x158F1CC", VA = "0x158F1CC")]
		public RESULT setUserData(IntPtr userdata)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000795")]
		[Address(RVA = "0x158F264", Offset = "0x158F264", VA = "0x158F264")]
		public RESULT getCPUUsage(out uint exclusive, out uint inclusive)
		{
			return default(RESULT);
		}

		[PreserveSig]
		[Token(Token = "0x6000796")]
		[Address(RVA = "0x158F304", Offset = "0x158F304", VA = "0x158F304")]
		private static extern bool FMOD_Studio_EventInstance_IsValid(IntPtr _event);

		[PreserveSig]
		[Token(Token = "0x6000797")]
		[Address(RVA = "0x158DB2C", Offset = "0x158DB2C", VA = "0x158DB2C")]
		private static extern RESULT FMOD_Studio_EventInstance_GetDescription(IntPtr _event, out IntPtr description);

		[PreserveSig]
		[Token(Token = "0x6000798")]
		[Address(RVA = "0x158DBEC", Offset = "0x158DBEC", VA = "0x158DBEC")]
		private static extern RESULT FMOD_Studio_EventInstance_GetVolume(IntPtr _event, out float volume, out float finalvolume);

		[PreserveSig]
		[Token(Token = "0x6000799")]
		[Address(RVA = "0x158DC8C", Offset = "0x158DC8C", VA = "0x158DC8C")]
		private static extern RESULT FMOD_Studio_EventInstance_SetVolume(IntPtr _event, float volume);

		[PreserveSig]
		[Token(Token = "0x600079A")]
		[Address(RVA = "0x158DD4C", Offset = "0x158DD4C", VA = "0x158DD4C")]
		private static extern RESULT FMOD_Studio_EventInstance_GetPitch(IntPtr _event, out float pitch, out float finalpitch);

		[PreserveSig]
		[Token(Token = "0x600079B")]
		[Address(RVA = "0x158DDEC", Offset = "0x158DDEC", VA = "0x158DDEC")]
		private static extern RESULT FMOD_Studio_EventInstance_SetPitch(IntPtr _event, float pitch);

		[PreserveSig]
		[Token(Token = "0x600079C")]
		[Address(RVA = "0x158DE84", Offset = "0x158DE84", VA = "0x158DE84")]
		private static extern RESULT FMOD_Studio_EventInstance_Get3DAttributes(IntPtr _event, out ATTRIBUTES_3D attributes);

		[PreserveSig]
		[Token(Token = "0x600079D")]
		[Address(RVA = "0x158DF1C", Offset = "0x158DF1C", VA = "0x158DF1C")]
		private static extern RESULT FMOD_Studio_EventInstance_Set3DAttributes(IntPtr _event, ref ATTRIBUTES_3D attributes);

		[PreserveSig]
		[Token(Token = "0x600079E")]
		[Address(RVA = "0x158DFB4", Offset = "0x158DFB4", VA = "0x158DFB4")]
		private static extern RESULT FMOD_Studio_EventInstance_GetListenerMask(IntPtr _event, out uint mask);

		[PreserveSig]
		[Token(Token = "0x600079F")]
		[Address(RVA = "0x158E04C", Offset = "0x158E04C", VA = "0x158E04C")]
		private static extern RESULT FMOD_Studio_EventInstance_SetListenerMask(IntPtr _event, uint mask);

		[PreserveSig]
		[Token(Token = "0x60007A0")]
		[Address(RVA = "0x158E0E4", Offset = "0x158E0E4", VA = "0x158E0E4")]
		private static extern RESULT FMOD_Studio_EventInstance_GetProperty(IntPtr _event, EVENT_PROPERTY index, out float value);

		[PreserveSig]
		[Token(Token = "0x60007A1")]
		[Address(RVA = "0x158E184", Offset = "0x158E184", VA = "0x158E184")]
		private static extern RESULT FMOD_Studio_EventInstance_SetProperty(IntPtr _event, EVENT_PROPERTY index, float value);

		[PreserveSig]
		[Token(Token = "0x60007A2")]
		[Address(RVA = "0x158E22C", Offset = "0x158E22C", VA = "0x158E22C")]
		private static extern RESULT FMOD_Studio_EventInstance_GetReverbLevel(IntPtr _event, int index, out float level);

		[PreserveSig]
		[Token(Token = "0x60007A3")]
		[Address(RVA = "0x158E2CC", Offset = "0x158E2CC", VA = "0x158E2CC")]
		private static extern RESULT FMOD_Studio_EventInstance_SetReverbLevel(IntPtr _event, int index, float level);

		[PreserveSig]
		[Token(Token = "0x60007A4")]
		[Address(RVA = "0x158E374", Offset = "0x158E374", VA = "0x158E374")]
		private static extern RESULT FMOD_Studio_EventInstance_GetPaused(IntPtr _event, out bool paused);

		[PreserveSig]
		[Token(Token = "0x60007A5")]
		[Address(RVA = "0x158E424", Offset = "0x158E424", VA = "0x158E424")]
		private static extern RESULT FMOD_Studio_EventInstance_SetPaused(IntPtr _event, bool paused);

		[PreserveSig]
		[Token(Token = "0x60007A6")]
		[Address(RVA = "0x158E4BC", Offset = "0x158E4BC", VA = "0x158E4BC")]
		private static extern RESULT FMOD_Studio_EventInstance_Start(IntPtr _event);

		[PreserveSig]
		[Token(Token = "0x60007A7")]
		[Address(RVA = "0x158E544", Offset = "0x158E544", VA = "0x158E544")]
		private static extern RESULT FMOD_Studio_EventInstance_Stop(IntPtr _event, STOP_MODE mode);

		[PreserveSig]
		[Token(Token = "0x60007A8")]
		[Address(RVA = "0x158E5DC", Offset = "0x158E5DC", VA = "0x158E5DC")]
		private static extern RESULT FMOD_Studio_EventInstance_GetTimelinePosition(IntPtr _event, out int position);

		[PreserveSig]
		[Token(Token = "0x60007A9")]
		[Address(RVA = "0x158E674", Offset = "0x158E674", VA = "0x158E674")]
		private static extern RESULT FMOD_Studio_EventInstance_SetTimelinePosition(IntPtr _event, int position);

		[PreserveSig]
		[Token(Token = "0x60007AA")]
		[Address(RVA = "0x158E70C", Offset = "0x158E70C", VA = "0x158E70C")]
		private static extern RESULT FMOD_Studio_EventInstance_GetPlaybackState(IntPtr _event, out PLAYBACK_STATE state);

		[PreserveSig]
		[Token(Token = "0x60007AB")]
		[Address(RVA = "0x158E7A4", Offset = "0x158E7A4", VA = "0x158E7A4")]
		private static extern RESULT FMOD_Studio_EventInstance_GetChannelGroup(IntPtr _event, out IntPtr group);

		[PreserveSig]
		[Token(Token = "0x60007AC")]
		[Address(RVA = "0x158E83C", Offset = "0x158E83C", VA = "0x158E83C")]
		private static extern RESULT FMOD_Studio_EventInstance_Release(IntPtr _event);

		[PreserveSig]
		[Token(Token = "0x60007AD")]
		[Address(RVA = "0x158E8C4", Offset = "0x158E8C4", VA = "0x158E8C4")]
		private static extern RESULT FMOD_Studio_EventInstance_IsVirtual(IntPtr _event, out bool virtualstate);

		[PreserveSig]
		[Token(Token = "0x60007AE")]
		[Address(RVA = "0x158ED44", Offset = "0x158ED44", VA = "0x158ED44")]
		private static extern RESULT FMOD_Studio_EventInstance_GetParameterByName(IntPtr _event, byte[] name, out float value, out float finalvalue);

		[PreserveSig]
		[Token(Token = "0x60007AF")]
		[Address(RVA = "0x158EF54", Offset = "0x158EF54", VA = "0x158EF54")]
		private static extern RESULT FMOD_Studio_EventInstance_SetParameterByName(IntPtr _event, byte[] name, float value, bool ignoreseekspeed);

		[PreserveSig]
		[Token(Token = "0x60007B0")]
		[Address(RVA = "0x158E998", Offset = "0x158E998", VA = "0x158E998")]
		private static extern RESULT FMOD_Studio_EventInstance_GetParameterByID(IntPtr _event, PARAMETER_ID id, out float value, out float finalvalue);

		[PreserveSig]
		[Token(Token = "0x60007B1")]
		[Address(RVA = "0x158EA4C", Offset = "0x158EA4C", VA = "0x158EA4C")]
		private static extern RESULT FMOD_Studio_EventInstance_SetParameterByID(IntPtr _event, PARAMETER_ID id, float value, bool ignoreseekspeed);

		[PreserveSig]
		[Token(Token = "0x60007B2")]
		[Address(RVA = "0x158EB00", Offset = "0x158EB00", VA = "0x158EB00")]
		private static extern RESULT FMOD_Studio_EventInstance_SetParametersByIDs(IntPtr _event, PARAMETER_ID[] ids, float[] values, int count, bool ignoreseekspeed);

		[PreserveSig]
		[Token(Token = "0x60007B3")]
		[Address(RVA = "0x158F00C", Offset = "0x158F00C", VA = "0x158F00C")]
		private static extern RESULT FMOD_Studio_EventInstance_TriggerCue(IntPtr _event);

		[PreserveSig]
		[Token(Token = "0x60007B4")]
		[Address(RVA = "0x158F094", Offset = "0x158F094", VA = "0x158F094")]
		private static extern RESULT FMOD_Studio_EventInstance_SetCallback(IntPtr _event, EVENT_CALLBACK callback, EVENT_CALLBACK_TYPE callbackmask);

		[PreserveSig]
		[Token(Token = "0x60007B5")]
		[Address(RVA = "0x158F13C", Offset = "0x158F13C", VA = "0x158F13C")]
		private static extern RESULT FMOD_Studio_EventInstance_GetUserData(IntPtr _event, out IntPtr userdata);

		[PreserveSig]
		[Token(Token = "0x60007B6")]
		[Address(RVA = "0x158F1D4", Offset = "0x158F1D4", VA = "0x158F1D4")]
		private static extern RESULT FMOD_Studio_EventInstance_SetUserData(IntPtr _event, IntPtr userdata);

		[PreserveSig]
		[Token(Token = "0x60007B7")]
		[Address(RVA = "0x158F26C", Offset = "0x158F26C", VA = "0x158F26C")]
		private static extern RESULT FMOD_Studio_EventInstance_GetCPUUsage(IntPtr _event, out uint exclusive, out uint inclusive);

		[Token(Token = "0x60007B8")]
		[Address(RVA = "0x158F38C", Offset = "0x158F38C", VA = "0x158F38C")]
		public bool hasHandle()
		{
			return default(bool);
		}

		[Token(Token = "0x60007B9")]
		[Address(RVA = "0x158F3D8", Offset = "0x158F3D8", VA = "0x158F3D8")]
		public void clearHandle()
		{
		}

		[Token(Token = "0x60007BA")]
		[Address(RVA = "0x158F41C", Offset = "0x158F41C", VA = "0x158F41C")]
		public bool isValid()
		{
			return default(bool);
		}
	}
	[Token(Token = "0x200010A")]
	public struct Bus
	{
		[Token(Token = "0x4000557")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public IntPtr handle;

		[Token(Token = "0x60007BB")]
		[Address(RVA = "0x15893A8", Offset = "0x15893A8", VA = "0x15893A8")]
		public RESULT getID(out Guid id)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60007BC")]
		[Address(RVA = "0x1589440", Offset = "0x1589440", VA = "0x1589440")]
		public RESULT getPath(out string path)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60007BD")]
		[Address(RVA = "0x1589738", Offset = "0x1589738", VA = "0x1589738")]
		public RESULT getVolume(out float volume)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60007BE")]
		[Address(RVA = "0x1589760", Offset = "0x1589760", VA = "0x1589760")]
		public RESULT getVolume(out float volume, out float finalvolume)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60007BF")]
		[Address(RVA = "0x1589800", Offset = "0x1589800", VA = "0x1589800")]
		public RESULT setVolume(float volume)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60007C0")]
		[Address(RVA = "0x1589898", Offset = "0x1589898", VA = "0x1589898")]
		public RESULT getPaused(out bool paused)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60007C1")]
		[Address(RVA = "0x1589944", Offset = "0x1589944", VA = "0x1589944")]
		public RESULT setPaused(bool paused)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60007C2")]
		[Address(RVA = "0x15899E0", Offset = "0x15899E0", VA = "0x15899E0")]
		public RESULT getMute(out bool mute)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60007C3")]
		[Address(RVA = "0x1589A8C", Offset = "0x1589A8C", VA = "0x1589A8C")]
		public RESULT setMute(bool mute)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60007C4")]
		[Address(RVA = "0x1589B28", Offset = "0x1589B28", VA = "0x1589B28")]
		public RESULT stopAllEvents(STOP_MODE mode)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60007C5")]
		[Address(RVA = "0x1589BC0", Offset = "0x1589BC0", VA = "0x1589BC0")]
		public RESULT lockChannelGroup()
		{
			return default(RESULT);
		}

		[Token(Token = "0x60007C6")]
		[Address(RVA = "0x1589C48", Offset = "0x1589C48", VA = "0x1589C48")]
		public RESULT unlockChannelGroup()
		{
			return default(RESULT);
		}

		[Token(Token = "0x60007C7")]
		[Address(RVA = "0x1589CD0", Offset = "0x1589CD0", VA = "0x1589CD0")]
		public RESULT getChannelGroup(out ChannelGroup group)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60007C8")]
		[Address(RVA = "0x1589D68", Offset = "0x1589D68", VA = "0x1589D68")]
		public RESULT getCPUUsage(out uint exclusive, out uint inclusive)
		{
			return default(RESULT);
		}

		[PreserveSig]
		[Token(Token = "0x60007C9")]
		[Address(RVA = "0x1589E08", Offset = "0x1589E08", VA = "0x1589E08")]
		private static extern bool FMOD_Studio_Bus_IsValid(IntPtr bus);

		[PreserveSig]
		[Token(Token = "0x60007CA")]
		[Address(RVA = "0x15893B0", Offset = "0x15893B0", VA = "0x15893B0")]
		private static extern RESULT FMOD_Studio_Bus_GetID(IntPtr bus, out Guid id);

		[PreserveSig]
		[Token(Token = "0x60007CB")]
		[Address(RVA = "0x1589690", Offset = "0x1589690", VA = "0x1589690")]
		private static extern RESULT FMOD_Studio_Bus_GetPath(IntPtr bus, IntPtr path, int size, out int retrieved);

		[PreserveSig]
		[Token(Token = "0x60007CC")]
		[Address(RVA = "0x1589768", Offset = "0x1589768", VA = "0x1589768")]
		private static extern RESULT FMOD_Studio_Bus_GetVolume(IntPtr bus, out float volume, out float finalvolume);

		[PreserveSig]
		[Token(Token = "0x60007CD")]
		[Address(RVA = "0x1589808", Offset = "0x1589808", VA = "0x1589808")]
		private static extern RESULT FMOD_Studio_Bus_SetVolume(IntPtr bus, float volume);

		[PreserveSig]
		[Token(Token = "0x60007CE")]
		[Address(RVA = "0x15898A0", Offset = "0x15898A0", VA = "0x15898A0")]
		private static extern RESULT FMOD_Studio_Bus_GetPaused(IntPtr bus, out bool paused);

		[PreserveSig]
		[Token(Token = "0x60007CF")]
		[Address(RVA = "0x1589950", Offset = "0x1589950", VA = "0x1589950")]
		private static extern RESULT FMOD_Studio_Bus_SetPaused(IntPtr bus, bool paused);

		[PreserveSig]
		[Token(Token = "0x60007D0")]
		[Address(RVA = "0x15899E8", Offset = "0x15899E8", VA = "0x15899E8")]
		private static extern RESULT FMOD_Studio_Bus_GetMute(IntPtr bus, out bool mute);

		[PreserveSig]
		[Token(Token = "0x60007D1")]
		[Address(RVA = "0x1589A98", Offset = "0x1589A98", VA = "0x1589A98")]
		private static extern RESULT FMOD_Studio_Bus_SetMute(IntPtr bus, bool mute);

		[PreserveSig]
		[Token(Token = "0x60007D2")]
		[Address(RVA = "0x1589B30", Offset = "0x1589B30", VA = "0x1589B30")]
		private static extern RESULT FMOD_Studio_Bus_StopAllEvents(IntPtr bus, STOP_MODE mode);

		[PreserveSig]
		[Token(Token = "0x60007D3")]
		[Address(RVA = "0x1589BC8", Offset = "0x1589BC8", VA = "0x1589BC8")]
		private static extern RESULT FMOD_Studio_Bus_LockChannelGroup(IntPtr bus);

		[PreserveSig]
		[Token(Token = "0x60007D4")]
		[Address(RVA = "0x1589C50", Offset = "0x1589C50", VA = "0x1589C50")]
		private static extern RESULT FMOD_Studio_Bus_UnlockChannelGroup(IntPtr bus);

		[PreserveSig]
		[Token(Token = "0x60007D5")]
		[Address(RVA = "0x1589CD8", Offset = "0x1589CD8", VA = "0x1589CD8")]
		private static extern RESULT FMOD_Studio_Bus_GetChannelGroup(IntPtr bus, out IntPtr group);

		[PreserveSig]
		[Token(Token = "0x60007D6")]
		[Address(RVA = "0x1589D70", Offset = "0x1589D70", VA = "0x1589D70")]
		private static extern RESULT FMOD_Studio_Bus_GetCPUUsage(IntPtr bus, out uint exclusive, out uint inclusive);

		[Token(Token = "0x60007D7")]
		[Address(RVA = "0x1589E90", Offset = "0x1589E90", VA = "0x1589E90")]
		public bool hasHandle()
		{
			return default(bool);
		}

		[Token(Token = "0x60007D8")]
		[Address(RVA = "0x1589EDC", Offset = "0x1589EDC", VA = "0x1589EDC")]
		public void clearHandle()
		{
		}

		[Token(Token = "0x60007D9")]
		[Address(RVA = "0x1589F20", Offset = "0x1589F20", VA = "0x1589F20")]
		public bool isValid()
		{
			return default(bool);
		}
	}
	[Token(Token = "0x200010B")]
	public struct VCA
	{
		[Token(Token = "0x4000558")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public IntPtr handle;

		[Token(Token = "0x60007DA")]
		[Address(RVA = "0xFBF678", Offset = "0xFBF678", VA = "0xFBF678")]
		public RESULT getID(out Guid id)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60007DB")]
		[Address(RVA = "0xFBF710", Offset = "0xFBF710", VA = "0xFBF710")]
		public RESULT getPath(out string path)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60007DC")]
		[Address(RVA = "0xFBFA10", Offset = "0xFBFA10", VA = "0xFBFA10")]
		public RESULT getVolume(out float volume)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60007DD")]
		[Address(RVA = "0xFBFA38", Offset = "0xFBFA38", VA = "0xFBFA38")]
		public RESULT getVolume(out float volume, out float finalvolume)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60007DE")]
		[Address(RVA = "0xFBFAD8", Offset = "0xFBFAD8", VA = "0xFBFAD8")]
		public RESULT setVolume(float volume)
		{
			return default(RESULT);
		}

		[PreserveSig]
		[Token(Token = "0x60007DF")]
		[Address(RVA = "0xFBFB70", Offset = "0xFBFB70", VA = "0xFBFB70")]
		private static extern bool FMOD_Studio_VCA_IsValid(IntPtr vca);

		[PreserveSig]
		[Token(Token = "0x60007E0")]
		[Address(RVA = "0xFBF680", Offset = "0xFBF680", VA = "0xFBF680")]
		private static extern RESULT FMOD_Studio_VCA_GetID(IntPtr vca, out Guid id);

		[PreserveSig]
		[Token(Token = "0x60007E1")]
		[Address(RVA = "0xFBF968", Offset = "0xFBF968", VA = "0xFBF968")]
		private static extern RESULT FMOD_Studio_VCA_GetPath(IntPtr vca, IntPtr path, int size, out int retrieved);

		[PreserveSig]
		[Token(Token = "0x60007E2")]
		[Address(RVA = "0xFBFA40", Offset = "0xFBFA40", VA = "0xFBFA40")]
		private static extern RESULT FMOD_Studio_VCA_GetVolume(IntPtr vca, out float volume, out float finalvolume);

		[PreserveSig]
		[Token(Token = "0x60007E3")]
		[Address(RVA = "0xFBFAE0", Offset = "0xFBFAE0", VA = "0xFBFAE0")]
		private static extern RESULT FMOD_Studio_VCA_SetVolume(IntPtr vca, float volume);

		[Token(Token = "0x60007E4")]
		[Address(RVA = "0xFBFBF8", Offset = "0xFBFBF8", VA = "0xFBFBF8")]
		public bool hasHandle()
		{
			return default(bool);
		}

		[Token(Token = "0x60007E5")]
		[Address(RVA = "0xFBFC44", Offset = "0xFBFC44", VA = "0xFBFC44")]
		public void clearHandle()
		{
		}

		[Token(Token = "0x60007E6")]
		[Address(RVA = "0xFBFC88", Offset = "0xFBFC88", VA = "0xFBFC88")]
		public bool isValid()
		{
			return default(bool);
		}
	}
	[Token(Token = "0x200010C")]
	public struct Bank
	{
		[Token(Token = "0x4000559")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public IntPtr handle;

		[Token(Token = "0x60007E7")]
		[Address(RVA = "0x1587EC8", Offset = "0x1587EC8", VA = "0x1587EC8")]
		public RESULT getID(out Guid id)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60007E8")]
		[Address(RVA = "0x1587F60", Offset = "0x1587F60", VA = "0x1587F60")]
		public RESULT getPath(out string path)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60007E9")]
		[Address(RVA = "0x1588258", Offset = "0x1588258", VA = "0x1588258")]
		public RESULT unload()
		{
			return default(RESULT);
		}

		[Token(Token = "0x60007EA")]
		[Address(RVA = "0x15882E0", Offset = "0x15882E0", VA = "0x15882E0")]
		public RESULT loadSampleData()
		{
			return default(RESULT);
		}

		[Token(Token = "0x60007EB")]
		[Address(RVA = "0x1588368", Offset = "0x1588368", VA = "0x1588368")]
		public RESULT unloadSampleData()
		{
			return default(RESULT);
		}

		[Token(Token = "0x60007EC")]
		[Address(RVA = "0x15883F0", Offset = "0x15883F0", VA = "0x15883F0")]
		public RESULT getLoadingState(out LOADING_STATE state)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60007ED")]
		[Address(RVA = "0x1588488", Offset = "0x1588488", VA = "0x1588488")]
		public RESULT getSampleLoadingState(out LOADING_STATE state)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60007EE")]
		[Address(RVA = "0x1588520", Offset = "0x1588520", VA = "0x1588520")]
		public RESULT getStringCount(out int count)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60007EF")]
		[Address(RVA = "0x15885B8", Offset = "0x15885B8", VA = "0x15885B8")]
		public RESULT getStringInfo(int index, out Guid id, out string path)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60007F0")]
		[Address(RVA = "0x1588918", Offset = "0x1588918", VA = "0x1588918")]
		public RESULT getEventCount(out int count)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60007F1")]
		[Address(RVA = "0x15889B0", Offset = "0x15889B0", VA = "0x15889B0")]
		public RESULT getEventList(out EventDescription[] array)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60007F2")]
		[Address(RVA = "0x1588BC8", Offset = "0x1588BC8", VA = "0x1588BC8")]
		public RESULT getBusCount(out int count)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60007F3")]
		[Address(RVA = "0x1588C60", Offset = "0x1588C60", VA = "0x1588C60")]
		public RESULT getBusList(out Bus[] array)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60007F4")]
		[Address(RVA = "0x1588E78", Offset = "0x1588E78", VA = "0x1588E78")]
		public RESULT getVCACount(out int count)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60007F5")]
		[Address(RVA = "0x1588F10", Offset = "0x1588F10", VA = "0x1588F10")]
		public RESULT getVCAList(out VCA[] array)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60007F6")]
		[Address(RVA = "0x1589128", Offset = "0x1589128", VA = "0x1589128")]
		public RESULT getUserData(out IntPtr userdata)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60007F7")]
		[Address(RVA = "0x15891C0", Offset = "0x15891C0", VA = "0x15891C0")]
		public RESULT setUserData(IntPtr userdata)
		{
			return default(RESULT);
		}

		[PreserveSig]
		[Token(Token = "0x60007F8")]
		[Address(RVA = "0x1589258", Offset = "0x1589258", VA = "0x1589258")]
		private static extern bool FMOD_Studio_Bank_IsValid(IntPtr bank);

		[PreserveSig]
		[Token(Token = "0x60007F9")]
		[Address(RVA = "0x1587ED0", Offset = "0x1587ED0", VA = "0x1587ED0")]
		private static extern RESULT FMOD_Studio_Bank_GetID(IntPtr bank, out Guid id);

		[PreserveSig]
		[Token(Token = "0x60007FA")]
		[Address(RVA = "0x15881B0", Offset = "0x15881B0", VA = "0x15881B0")]
		private static extern RESULT FMOD_Studio_Bank_GetPath(IntPtr bank, IntPtr path, int size, out int retrieved);

		[PreserveSig]
		[Token(Token = "0x60007FB")]
		[Address(RVA = "0x1588260", Offset = "0x1588260", VA = "0x1588260")]
		private static extern RESULT FMOD_Studio_Bank_Unload(IntPtr bank);

		[PreserveSig]
		[Token(Token = "0x60007FC")]
		[Address(RVA = "0x15882E8", Offset = "0x15882E8", VA = "0x15882E8")]
		private static extern RESULT FMOD_Studio_Bank_LoadSampleData(IntPtr bank);

		[PreserveSig]
		[Token(Token = "0x60007FD")]
		[Address(RVA = "0x1588370", Offset = "0x1588370", VA = "0x1588370")]
		private static extern RESULT FMOD_Studio_Bank_UnloadSampleData(IntPtr bank);

		[PreserveSig]
		[Token(Token = "0x60007FE")]
		[Address(RVA = "0x15883F8", Offset = "0x15883F8", VA = "0x15883F8")]
		private static extern RESULT FMOD_Studio_Bank_GetLoadingState(IntPtr bank, out LOADING_STATE state);

		[PreserveSig]
		[Token(Token = "0x60007FF")]
		[Address(RVA = "0x1588490", Offset = "0x1588490", VA = "0x1588490")]
		private static extern RESULT FMOD_Studio_Bank_GetSampleLoadingState(IntPtr bank, out LOADING_STATE state);

		[PreserveSig]
		[Token(Token = "0x6000800")]
		[Address(RVA = "0x1588528", Offset = "0x1588528", VA = "0x1588528")]
		private static extern RESULT FMOD_Studio_Bank_GetStringCount(IntPtr bank, out int count);

		[PreserveSig]
		[Token(Token = "0x6000801")]
		[Address(RVA = "0x1588858", Offset = "0x1588858", VA = "0x1588858")]
		private static extern RESULT FMOD_Studio_Bank_GetStringInfo(IntPtr bank, int index, out Guid id, IntPtr path, int size, out int retrieved);

		[PreserveSig]
		[Token(Token = "0x6000802")]
		[Address(RVA = "0x1588920", Offset = "0x1588920", VA = "0x1588920")]
		private static extern RESULT FMOD_Studio_Bank_GetEventCount(IntPtr bank, out int count);

		[PreserveSig]
		[Token(Token = "0x6000803")]
		[Address(RVA = "0x1588B18", Offset = "0x1588B18", VA = "0x1588B18")]
		private static extern RESULT FMOD_Studio_Bank_GetEventList(IntPtr bank, IntPtr[] array, int capacity, out int count);

		[PreserveSig]
		[Token(Token = "0x6000804")]
		[Address(RVA = "0x1588BD0", Offset = "0x1588BD0", VA = "0x1588BD0")]
		private static extern RESULT FMOD_Studio_Bank_GetBusCount(IntPtr bank, out int count);

		[PreserveSig]
		[Token(Token = "0x6000805")]
		[Address(RVA = "0x1588DC8", Offset = "0x1588DC8", VA = "0x1588DC8")]
		private static extern RESULT FMOD_Studio_Bank_GetBusList(IntPtr bank, IntPtr[] array, int capacity, out int count);

		[PreserveSig]
		[Token(Token = "0x6000806")]
		[Address(RVA = "0x1588E80", Offset = "0x1588E80", VA = "0x1588E80")]
		private static extern RESULT FMOD_Studio_Bank_GetVCACount(IntPtr bank, out int count);

		[PreserveSig]
		[Token(Token = "0x6000807")]
		[Address(RVA = "0x1589078", Offset = "0x1589078", VA = "0x1589078")]
		private static extern RESULT FMOD_Studio_Bank_GetVCAList(IntPtr bank, IntPtr[] array, int capacity, out int count);

		[PreserveSig]
		[Token(Token = "0x6000808")]
		[Address(RVA = "0x1589130", Offset = "0x1589130", VA = "0x1589130")]
		private static extern RESULT FMOD_Studio_Bank_GetUserData(IntPtr bank, out IntPtr userdata);

		[PreserveSig]
		[Token(Token = "0x6000809")]
		[Address(RVA = "0x15891C8", Offset = "0x15891C8", VA = "0x15891C8")]
		private static extern RESULT FMOD_Studio_Bank_SetUserData(IntPtr bank, IntPtr userdata);

		[Token(Token = "0x600080A")]
		[Address(RVA = "0x15892E0", Offset = "0x15892E0", VA = "0x15892E0")]
		public bool hasHandle()
		{
			return default(bool);
		}

		[Token(Token = "0x600080B")]
		[Address(RVA = "0x158932C", Offset = "0x158932C", VA = "0x158932C")]
		public void clearHandle()
		{
		}

		[Token(Token = "0x600080C")]
		[Address(RVA = "0x1589370", Offset = "0x1589370", VA = "0x1589370")]
		public bool isValid()
		{
			return default(bool);
		}
	}
	[Token(Token = "0x200010D")]
	public struct CommandReplay
	{
		[Token(Token = "0x400055A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public IntPtr handle;

		[Token(Token = "0x600080D")]
		[Address(RVA = "0x158AC54", Offset = "0x158AC54", VA = "0x158AC54")]
		public RESULT getSystem(out System system)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600080E")]
		[Address(RVA = "0x158ACEC", Offset = "0x158ACEC", VA = "0x158ACEC")]
		public RESULT getLength(out float length)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600080F")]
		[Address(RVA = "0x158AD84", Offset = "0x158AD84", VA = "0x158AD84")]
		public RESULT getCommandCount(out int count)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000810")]
		[Address(RVA = "0x158AE1C", Offset = "0x158AE1C", VA = "0x158AE1C")]
		public RESULT getCommandInfo(int commandIndex, out COMMAND_INFO info)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000811")]
		[Address(RVA = "0x158AEBC", Offset = "0x158AEBC", VA = "0x158AEBC")]
		public RESULT getCommandString(int commandIndex, out string buffer)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000812")]
		[Address(RVA = "0x158B1BC", Offset = "0x158B1BC", VA = "0x158B1BC")]
		public RESULT getCommandAtTime(float time, out int commandIndex)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000813")]
		[Address(RVA = "0x158B264", Offset = "0x158B264", VA = "0x158B264")]
		public RESULT setBankPath(string bankPath)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000814")]
		[Address(RVA = "0x158B444", Offset = "0x158B444", VA = "0x158B444")]
		public RESULT start()
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000815")]
		[Address(RVA = "0x158B4CC", Offset = "0x158B4CC", VA = "0x158B4CC")]
		public RESULT stop()
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000816")]
		[Address(RVA = "0x158B554", Offset = "0x158B554", VA = "0x158B554")]
		public RESULT seekToTime(float time)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000817")]
		[Address(RVA = "0x158B5EC", Offset = "0x158B5EC", VA = "0x158B5EC")]
		public RESULT seekToCommand(int commandIndex)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000818")]
		[Address(RVA = "0x158B684", Offset = "0x158B684", VA = "0x158B684")]
		public RESULT getPaused(out bool paused)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000819")]
		[Address(RVA = "0x158B730", Offset = "0x158B730", VA = "0x158B730")]
		public RESULT setPaused(bool paused)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600081A")]
		[Address(RVA = "0x158B7CC", Offset = "0x158B7CC", VA = "0x158B7CC")]
		public RESULT getPlaybackState(out PLAYBACK_STATE state)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600081B")]
		[Address(RVA = "0x158B864", Offset = "0x158B864", VA = "0x158B864")]
		public RESULT getCurrentCommand(out int commandIndex, out float currentTime)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600081C")]
		[Address(RVA = "0x158B904", Offset = "0x158B904", VA = "0x158B904")]
		public RESULT release()
		{
			return default(RESULT);
		}

		[Token(Token = "0x600081D")]
		[Address(RVA = "0x158B98C", Offset = "0x158B98C", VA = "0x158B98C")]
		public RESULT setFrameCallback(COMMANDREPLAY_FRAME_CALLBACK callback)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600081E")]
		[Address(RVA = "0x158BA2C", Offset = "0x158BA2C", VA = "0x158BA2C")]
		public RESULT setLoadBankCallback(COMMANDREPLAY_LOAD_BANK_CALLBACK callback)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600081F")]
		[Address(RVA = "0x158BACC", Offset = "0x158BACC", VA = "0x158BACC")]
		public RESULT setCreateInstanceCallback(COMMANDREPLAY_CREATE_INSTANCE_CALLBACK callback)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000820")]
		[Address(RVA = "0x158BB6C", Offset = "0x158BB6C", VA = "0x158BB6C")]
		public RESULT getUserData(out IntPtr userdata)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000821")]
		[Address(RVA = "0x158BC04", Offset = "0x158BC04", VA = "0x158BC04")]
		public RESULT setUserData(IntPtr userdata)
		{
			return default(RESULT);
		}

		[PreserveSig]
		[Token(Token = "0x6000822")]
		[Address(RVA = "0x158BC9C", Offset = "0x158BC9C", VA = "0x158BC9C")]
		private static extern bool FMOD_Studio_CommandReplay_IsValid(IntPtr replay);

		[PreserveSig]
		[Token(Token = "0x6000823")]
		[Address(RVA = "0x158AC5C", Offset = "0x158AC5C", VA = "0x158AC5C")]
		private static extern RESULT FMOD_Studio_CommandReplay_GetSystem(IntPtr replay, out IntPtr system);

		[PreserveSig]
		[Token(Token = "0x6000824")]
		[Address(RVA = "0x158ACF4", Offset = "0x158ACF4", VA = "0x158ACF4")]
		private static extern RESULT FMOD_Studio_CommandReplay_GetLength(IntPtr replay, out float length);

		[PreserveSig]
		[Token(Token = "0x6000825")]
		[Address(RVA = "0x158AD8C", Offset = "0x158AD8C", VA = "0x158AD8C")]
		private static extern RESULT FMOD_Studio_CommandReplay_GetCommandCount(IntPtr replay, out int count);

		[PreserveSig]
		[Token(Token = "0x6000826")]
		[Address(RVA = "0x158AE24", Offset = "0x158AE24", VA = "0x158AE24")]
		private static extern RESULT FMOD_Studio_CommandReplay_GetCommandInfo(IntPtr replay, int commandindex, out COMMAND_INFO info);

		[PreserveSig]
		[Token(Token = "0x6000827")]
		[Address(RVA = "0x158B114", Offset = "0x158B114", VA = "0x158B114")]
		private static extern RESULT FMOD_Studio_CommandReplay_GetCommandString(IntPtr replay, int commandIndex, IntPtr buffer, int length);

		[PreserveSig]
		[Token(Token = "0x6000828")]
		[Address(RVA = "0x158B1C4", Offset = "0x158B1C4", VA = "0x158B1C4")]
		private static extern RESULT FMOD_Studio_CommandReplay_GetCommandAtTime(IntPtr replay, float time, out int commandIndex);

		[PreserveSig]
		[Token(Token = "0x6000829")]
		[Address(RVA = "0x158B3AC", Offset = "0x158B3AC", VA = "0x158B3AC")]
		private static extern RESULT FMOD_Studio_CommandReplay_SetBankPath(IntPtr replay, byte[] bankPath);

		[PreserveSig]
		[Token(Token = "0x600082A")]
		[Address(RVA = "0x158B44C", Offset = "0x158B44C", VA = "0x158B44C")]
		private static extern RESULT FMOD_Studio_CommandReplay_Start(IntPtr replay);

		[PreserveSig]
		[Token(Token = "0x600082B")]
		[Address(RVA = "0x158B4D4", Offset = "0x158B4D4", VA = "0x158B4D4")]
		private static extern RESULT FMOD_Studio_CommandReplay_Stop(IntPtr replay);

		[PreserveSig]
		[Token(Token = "0x600082C")]
		[Address(RVA = "0x158B55C", Offset = "0x158B55C", VA = "0x158B55C")]
		private static extern RESULT FMOD_Studio_CommandReplay_SeekToTime(IntPtr replay, float time);

		[PreserveSig]
		[Token(Token = "0x600082D")]
		[Address(RVA = "0x158B5F4", Offset = "0x158B5F4", VA = "0x158B5F4")]
		private static extern RESULT FMOD_Studio_CommandReplay_SeekToCommand(IntPtr replay, int commandIndex);

		[PreserveSig]
		[Token(Token = "0x600082E")]
		[Address(RVA = "0x158B68C", Offset = "0x158B68C", VA = "0x158B68C")]
		private static extern RESULT FMOD_Studio_CommandReplay_GetPaused(IntPtr replay, out bool paused);

		[PreserveSig]
		[Token(Token = "0x600082F")]
		[Address(RVA = "0x158B73C", Offset = "0x158B73C", VA = "0x158B73C")]
		private static extern RESULT FMOD_Studio_CommandReplay_SetPaused(IntPtr replay, bool paused);

		[PreserveSig]
		[Token(Token = "0x6000830")]
		[Address(RVA = "0x158B7D4", Offset = "0x158B7D4", VA = "0x158B7D4")]
		private static extern RESULT FMOD_Studio_CommandReplay_GetPlaybackState(IntPtr replay, out PLAYBACK_STATE state);

		[PreserveSig]
		[Token(Token = "0x6000831")]
		[Address(RVA = "0x158B86C", Offset = "0x158B86C", VA = "0x158B86C")]
		private static extern RESULT FMOD_Studio_CommandReplay_GetCurrentCommand(IntPtr replay, out int commandIndex, out float currentTime);

		[PreserveSig]
		[Token(Token = "0x6000832")]
		[Address(RVA = "0x158B90C", Offset = "0x158B90C", VA = "0x158B90C")]
		private static extern RESULT FMOD_Studio_CommandReplay_Release(IntPtr replay);

		[PreserveSig]
		[Token(Token = "0x6000833")]
		[Address(RVA = "0x158B994", Offset = "0x158B994", VA = "0x158B994")]
		private static extern RESULT FMOD_Studio_CommandReplay_SetFrameCallback(IntPtr replay, COMMANDREPLAY_FRAME_CALLBACK callback);

		[PreserveSig]
		[Token(Token = "0x6000834")]
		[Address(RVA = "0x158BA34", Offset = "0x158BA34", VA = "0x158BA34")]
		private static extern RESULT FMOD_Studio_CommandReplay_SetLoadBankCallback(IntPtr replay, COMMANDREPLAY_LOAD_BANK_CALLBACK callback);

		[PreserveSig]
		[Token(Token = "0x6000835")]
		[Address(RVA = "0x158BAD4", Offset = "0x158BAD4", VA = "0x158BAD4")]
		private static extern RESULT FMOD_Studio_CommandReplay_SetCreateInstanceCallback(IntPtr replay, COMMANDREPLAY_CREATE_INSTANCE_CALLBACK callback);

		[PreserveSig]
		[Token(Token = "0x6000836")]
		[Address(RVA = "0x158BB74", Offset = "0x158BB74", VA = "0x158BB74")]
		private static extern RESULT FMOD_Studio_CommandReplay_GetUserData(IntPtr replay, out IntPtr userdata);

		[PreserveSig]
		[Token(Token = "0x6000837")]
		[Address(RVA = "0x158BC0C", Offset = "0x158BC0C", VA = "0x158BC0C")]
		private static extern RESULT FMOD_Studio_CommandReplay_SetUserData(IntPtr replay, IntPtr userdata);

		[Token(Token = "0x6000838")]
		[Address(RVA = "0x158BD24", Offset = "0x158BD24", VA = "0x158BD24")]
		public bool hasHandle()
		{
			return default(bool);
		}

		[Token(Token = "0x6000839")]
		[Address(RVA = "0x158BD70", Offset = "0x158BD70", VA = "0x158BD70")]
		public void clearHandle()
		{
		}

		[Token(Token = "0x600083A")]
		[Address(RVA = "0x158BDB4", Offset = "0x158BDB4", VA = "0x158BDB4")]
		public bool isValid()
		{
			return default(bool);
		}
	}
}
namespace FMODUnity
{
	[Token(Token = "0x200010E")]
	public class BankRefAttribute : PropertyAttribute
	{
		[Token(Token = "0x600083B")]
		[Address(RVA = "0xFC6774", Offset = "0xFC6774", VA = "0xFC6774")]
		public BankRefAttribute()
		{
		}
	}
	[Token(Token = "0x200010F")]
	public abstract class EventHandler : MonoBehaviour
	{
		[Token(Token = "0x400055B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string CollisionTag;

		[Token(Token = "0x600083C")]
		[Address(RVA = "0xFC6838", Offset = "0xFC6838", VA = "0xFC6838")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600083D")]
		[Address(RVA = "0xFC6848", Offset = "0xFC6848", VA = "0xFC6848")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600083E")]
		[Address(RVA = "0xFC6858", Offset = "0xFC6858", VA = "0xFC6858")]
		private void OnTriggerEnter(Collider other)
		{
		}

		[Token(Token = "0x600083F")]
		[Address(RVA = "0xFC68C0", Offset = "0xFC68C0", VA = "0xFC68C0")]
		private void OnTriggerExit(Collider other)
		{
		}

		[Token(Token = "0x6000840")]
		[Address(RVA = "0xFC6928", Offset = "0xFC6928", VA = "0xFC6928")]
		private void OnTriggerEnter2D(Collider2D other)
		{
		}

		[Token(Token = "0x6000841")]
		[Address(RVA = "0xFC6990", Offset = "0xFC6990", VA = "0xFC6990")]
		private void OnTriggerExit2D(Collider2D other)
		{
		}

		[Token(Token = "0x6000842")]
		[Address(RVA = "0xFC69F8", Offset = "0xFC69F8", VA = "0xFC69F8")]
		private void OnCollisionEnter()
		{
		}

		[Token(Token = "0x6000843")]
		[Address(RVA = "0xFC6A08", Offset = "0xFC6A08", VA = "0xFC6A08")]
		private void OnCollisionExit()
		{
		}

		[Token(Token = "0x6000844")]
		[Address(RVA = "0xFC6A18", Offset = "0xFC6A18", VA = "0xFC6A18")]
		private void OnCollisionEnter2D()
		{
		}

		[Token(Token = "0x6000845")]
		[Address(RVA = "0xFC6A28", Offset = "0xFC6A28", VA = "0xFC6A28")]
		private void OnCollisionExit2D()
		{
		}

		[Token(Token = "0x6000846")]
		[Address(RVA = "0xFC6A38", Offset = "0xFC6A38", VA = "0xFC6A38")]
		private void OnMouseEnter()
		{
		}

		[Token(Token = "0x6000847")]
		[Address(RVA = "0xFC6A48", Offset = "0xFC6A48", VA = "0xFC6A48")]
		private void OnMouseExit()
		{
		}

		[Token(Token = "0x6000848")]
		[Address(RVA = "0xFC6A58", Offset = "0xFC6A58", VA = "0xFC6A58")]
		private void OnMouseDown()
		{
		}

		[Token(Token = "0x6000849")]
		[Address(RVA = "0xFC6A68", Offset = "0xFC6A68", VA = "0xFC6A68")]
		private void OnMouseUp()
		{
		}

		[Token(Token = "0x600084A")]
		protected abstract void HandleGameEvent(EmitterGameEvent gameEvent);

		[Token(Token = "0x600084B")]
		[Address(RVA = "0xFC6A78", Offset = "0xFC6A78", VA = "0xFC6A78")]
		protected EventHandler()
		{
		}
	}
	[Token(Token = "0x2000110")]
	public class EventRefAttribute : PropertyAttribute
	{
		[Token(Token = "0x600084C")]
		[Address(RVA = "0xFC6C60", Offset = "0xFC6C60", VA = "0xFC6C60")]
		public EventRefAttribute()
		{
		}
	}
	[Token(Token = "0x2000111")]
	public class FMODRuntimeManagerOnGUIHelper : MonoBehaviour
	{
		[Token(Token = "0x400055C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public RuntimeManager TargetRuntimeManager;

		[Token(Token = "0x600084D")]
		[Address(RVA = "0xFC6C68", Offset = "0xFC6C68", VA = "0xFC6C68")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x600084E")]
		[Address(RVA = "0xFC6E00", Offset = "0xFC6E00", VA = "0xFC6E00")]
		public FMODRuntimeManagerOnGUIHelper()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000112")]
	public class ParamRef
	{
		[Token(Token = "0x400055D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string Name;

		[Token(Token = "0x400055E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float Value;

		[Token(Token = "0x400055F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public PARAMETER_ID ID;

		[Token(Token = "0x600084F")]
		[Address(RVA = "0xFC6E08", Offset = "0xFC6E08", VA = "0xFC6E08")]
		public ParamRef()
		{
		}
	}
	[Token(Token = "0x2000113")]
	public class ParamRefAttribute : PropertyAttribute
	{
		[Token(Token = "0x6000850")]
		[Address(RVA = "0xFC6E10", Offset = "0xFC6E10", VA = "0xFC6E10")]
		public ParamRefAttribute()
		{
		}
	}
	[Token(Token = "0x2000114")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xC851C4", Offset = "0xC851C4")]
	public class RuntimeManager : MonoBehaviour
	{
		[Token(Token = "0x200014B")]
		private struct LoadedBank
		{
			[Token(Token = "0x40006E6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Bank Bank;

			[Token(Token = "0x40006E7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public int RefCount;
		}

		[Token(Token = "0x200014C")]
		private class GuidComparer : IEqualityComparer<Guid>
		{
			[Token(Token = "0x6000938")]
			[Address(RVA = "0xFCD04C", Offset = "0xFCD04C", VA = "0xFCD04C", Slot = "4")]
			private bool System.Collections.Generic.IEqualityComparer<System.Guid>.Equals(Guid x, Guid y)
			{
				return default(bool);
			}

			[Token(Token = "0x6000939")]
			[Address(RVA = "0xFCD080", Offset = "0xFCD080", VA = "0xFCD080", Slot = "5")]
			private int System.Collections.Generic.IEqualityComparer<System.Guid>.GetHashCode(Guid obj)
			{
				return default(int);
			}

			[Token(Token = "0x600093A")]
			[Address(RVA = "0xFCCC18", Offset = "0xFCCC18", VA = "0xFCCC18")]
			public GuidComparer()
			{
			}
		}

		[Token(Token = "0x200014D")]
		private class AttachedInstance
		{
			[Token(Token = "0x40006E8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public EventInstance instance;

			[Token(Token = "0x40006E9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Transform transform;

			[Token(Token = "0x40006EA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Rigidbody rigidBody;

			[Token(Token = "0x40006EB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Rigidbody2D rigidBody2D;

			[Token(Token = "0x600093B")]
			[Address(RVA = "0xFC9EF8", Offset = "0xFC9EF8", VA = "0xFC9EF8")]
			public AttachedInstance()
			{
			}
		}

		[Token(Token = "0x200014E")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xC853EC", Offset = "0xC853EC")]
		private sealed class <>c__DisplayClass27_0
		{
			[Token(Token = "0x40006EC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public EventInstance instance;

			[Token(Token = "0x600093C")]
			[Address(RVA = "0xFC9EF0", Offset = "0xFC9EF0", VA = "0xFC9EF0")]
			public <>c__DisplayClass27_0()
			{
			}

			[Token(Token = "0x600093D")]
			[Address(RVA = "0xFCCCBC", Offset = "0xFCCCBC", VA = "0xFCCCBC")]
			internal bool <AttachInstanceToGameObject>b__0(AttachedInstance x)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x200014F")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xC853FC", Offset = "0xC853FC")]
		private sealed class <>c__DisplayClass28_0
		{
			[Token(Token = "0x40006ED")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public EventInstance instance;

			[Token(Token = "0x600093E")]
			[Address(RVA = "0xFC9F00", Offset = "0xFC9F00", VA = "0xFC9F00")]
			public <>c__DisplayClass28_0()
			{
			}

			[Token(Token = "0x600093F")]
			[Address(RVA = "0xFCCCE0", Offset = "0xFCCCE0", VA = "0xFCCCE0")]
			internal bool <AttachInstanceToGameObject>b__0(AttachedInstance x)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x2000150")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xC8540C", Offset = "0xC8540C")]
		private sealed class <loadFromWeb>d__42 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40006EE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40006EF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40006F0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public string bankPath;

			[Token(Token = "0x40006F1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public RuntimeManager <>4__this;

			[Token(Token = "0x40006F2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public string bankName;

			[Token(Token = "0x40006F3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public bool loadSamples;

			[Token(Token = "0x40006F4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private UnityWebRequest <www>5__2;

			[Token(Token = "0x1700006A")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000943")]
				[Address(RVA = "0xFCCFDC", Offset = "0xFCCFDC", VA = "0xFCCFDC", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700006B")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000945")]
				[Address(RVA = "0xFCD044", Offset = "0xFCD044", VA = "0xFCD044", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000940")]
			[Address(RVA = "0xFCAA44", Offset = "0xFCAA44", VA = "0xFCAA44")]
			[DebuggerHidden]
			public <loadFromWeb>d__42(int <>1__state)
			{
			}

			[Token(Token = "0x6000941")]
			[Address(RVA = "0xFCCD04", Offset = "0xFCCD04", VA = "0xFCCD04", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000942")]
			[Address(RVA = "0xFCCD08", Offset = "0xFCCD08", VA = "0xFCCD08", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000944")]
			[Address(RVA = "0xFCCFE4", Offset = "0xFCCFE4", VA = "0xFCCFE4", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000560")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static SystemNotInitializedException initException;

		[Token(Token = "0x4000561")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static RuntimeManager instance;

		[Token(Token = "0x4000562")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private FMODPlatform fmodPlatform;

		[Token(Token = "0x4000563")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private FMOD.Studio.System studioSystem;

		[Token(Token = "0x4000564")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private FMOD.System coreSystem;

		[Token(Token = "0x4000565")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private DSP mixerHead;

		[Token(Token = "0x4000566")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private long[] cachedPointers;

		[Token(Token = "0x4000567")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Dictionary<string, LoadedBank> loadedBanks;

		[Token(Token = "0x4000568")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Dictionary<string, uint> loadedPlugins;

		[Token(Token = "0x4000569")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Dictionary<Guid, EventDescription> cachedDescriptions;

		[Token(Token = "0x400056A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private List<AttachedInstance> attachedInstances;

		[Token(Token = "0x400056B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private bool listenerWarningIssued;

		[Token(Token = "0x400056C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x61")]
		protected bool isOverlayEnabled;

		[Token(Token = "0x400056D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private FMODRuntimeManagerOnGUIHelper overlayDrawer;

		[Token(Token = "0x400056E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Rect windowRect;

		[Token(Token = "0x400056F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private string lastDebugText;

		[Token(Token = "0x4000570")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private float lastDebugUpdate;

		[Token(Token = "0x4000571")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static List<StudioListener> Listeners;

		[Token(Token = "0x4000572")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static int numListeners;

		[Token(Token = "0x1700004D")]
		private static RuntimeManager Instance
		{
			[Token(Token = "0x6000852")]
			[Address(RVA = "0xFC70D4", Offset = "0xFC70D4", VA = "0xFC70D4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700004E")]
		public static FMOD.Studio.System StudioSystem
		{
			[Token(Token = "0x6000853")]
			[Address(RVA = "0xFC56B0", Offset = "0xFC56B0", VA = "0xFC56B0")]
			get
			{
				return default(FMOD.Studio.System);
			}
		}

		[Token(Token = "0x1700004F")]
		public static FMOD.System CoreSystem
		{
			[Token(Token = "0x6000854")]
			[Address(RVA = "0xFC8190", Offset = "0xFC8190", VA = "0xFC8190")]
			get
			{
				return default(FMOD.System);
			}
		}

		[Token(Token = "0x17000050")]
		public static bool IsInitialized
		{
			[Token(Token = "0x600087E")]
			[Address(RVA = "0xFCC888", Offset = "0xFCC888", VA = "0xFCC888")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000051")]
		public static bool HasBanksLoaded
		{
			[Token(Token = "0x600087F")]
			[Address(RVA = "0xFCC73C", Offset = "0xFCC73C", VA = "0xFCC73C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000851")]
		[Address(RVA = "0xFC6F10", Offset = "0xFC6F10", VA = "0xFC6F10")]
		[AttributeAttribute(Name = "MonoPInvokeCallbackAttribute", RVA = "0xC86AA0", Offset = "0xC86AA0")]
		private static RESULT DEBUG_CALLBACK(DEBUG_FLAGS flags, StringWrapper file, int line, StringWrapper func, StringWrapper message)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000855")]
		[Address(RVA = "0xFC81FC", Offset = "0xFC81FC", VA = "0xFC81FC")]
		private void CheckInitResult(RESULT result, string cause)
		{
		}

		[Token(Token = "0x6000856")]
		[Address(RVA = "0xFC7ABC", Offset = "0xFC7ABC", VA = "0xFC7ABC")]
		private RESULT Initialize()
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000857")]
		[Address(RVA = "0xFC90BC", Offset = "0xFC90BC", VA = "0xFC90BC")]
		public static int AddListener(StudioListener listener)
		{
			return default(int);
		}

		[Token(Token = "0x6000858")]
		[Address(RVA = "0xFC94C4", Offset = "0xFC94C4", VA = "0xFC94C4")]
		public static bool RemoveListener(StudioListener listener)
		{
			return default(bool);
		}

		[Token(Token = "0x6000859")]
		[Address(RVA = "0xFC97E8", Offset = "0xFC97E8", VA = "0xFC97E8")]
		private void Update()
		{
		}

		[Token(Token = "0x600085A")]
		[Address(RVA = "0xFC5B9C", Offset = "0xFC5B9C", VA = "0xFC5B9C")]
		public static void AttachInstanceToGameObject(EventInstance instance, Transform transform, Rigidbody rigidBody)
		{
		}

		[Token(Token = "0x600085B")]
		[Address(RVA = "0xFC5D58", Offset = "0xFC5D58", VA = "0xFC5D58")]
		public static void AttachInstanceToGameObject(EventInstance instance, Transform transform, Rigidbody2D rigidBody2D)
		{
		}

		[Token(Token = "0x600085C")]
		[Address(RVA = "0xFC9F08", Offset = "0xFC9F08", VA = "0xFC9F08")]
		public static void DetachInstanceFromGameObject(EventInstance instance)
		{
		}

		[Token(Token = "0x600085D")]
		[Address(RVA = "0xFC6CF4", Offset = "0xFC6CF4", VA = "0xFC6CF4")]
		public void ExecuteOnGUI()
		{
		}

		[Token(Token = "0x600085E")]
		[Address(RVA = "0xFCA004", Offset = "0xFCA004", VA = "0xFCA004")]
		private void Start()
		{
		}

		[Token(Token = "0x600085F")]
		[Address(RVA = "0xFCA114", Offset = "0xFCA114", VA = "0xFCA114")]
		private void DrawDebugOverlay(int windowID)
		{
		}

		[Token(Token = "0x6000860")]
		[Address(RVA = "0xFCA57C", Offset = "0xFCA57C", VA = "0xFCA57C")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000861")]
		[Address(RVA = "0xFCA5EC", Offset = "0xFCA5EC", VA = "0xFCA5EC")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000862")]
		[Address(RVA = "0xFCA69C", Offset = "0xFCA69C", VA = "0xFCA69C")]
		private void OnApplicationPause(bool pauseStatus)
		{
		}

		[Token(Token = "0x6000863")]
		[Address(RVA = "0xFCA80C", Offset = "0xFCA80C", VA = "0xFCA80C")]
		private void loadedBankRegister(LoadedBank loadedBank, string bankPath, string bankName, bool loadSamples, RESULT loadResult)
		{
		}

		[Token(Token = "0x6000864")]
		[Address(RVA = "0xFCA984", Offset = "0xFCA984", VA = "0xFCA984")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xC86B04", Offset = "0xC86B04")]
		private IEnumerator loadFromWeb(string bankPath, string bankName, bool loadSamples)
		{
			return null;
		}

		[Token(Token = "0x6000865")]
		[Address(RVA = "0xFCAA70", Offset = "0xFCAA70", VA = "0xFCAA70")]
		public static void LoadBank(string bankName, bool loadSamples = false)
		{
		}

		[Token(Token = "0x6000866")]
		[Address(RVA = "0xFCAF7C", Offset = "0xFCAF7C", VA = "0xFCAF7C")]
		public static void LoadBank(TextAsset asset, bool loadSamples = false)
		{
		}

		[Token(Token = "0x6000867")]
		[Address(RVA = "0xFC8C44", Offset = "0xFC8C44", VA = "0xFC8C44")]
		private void LoadBanks(Settings fmodSettings)
		{
		}

		[Token(Token = "0x6000868")]
		[Address(RVA = "0xFCB23C", Offset = "0xFCB23C", VA = "0xFCB23C")]
		public static void UnloadBank(string bankName)
		{
		}

		[Token(Token = "0x6000869")]
		[Address(RVA = "0xFCB374", Offset = "0xFCB374", VA = "0xFCB374")]
		public static bool AnyBankLoading()
		{
			return default(bool);
		}

		[Token(Token = "0x600086A")]
		[Address(RVA = "0xFCB1CC", Offset = "0xFCB1CC", VA = "0xFCB1CC")]
		public static void WaitForAllLoads()
		{
		}

		[Token(Token = "0x600086B")]
		[Address(RVA = "0xFCB4C4", Offset = "0xFCB4C4", VA = "0xFCB4C4")]
		public static Guid PathToGUID(string path)
		{
			return default(Guid);
		}

		[Token(Token = "0x600086C")]
		[Address(RVA = "0xFC5A8C", Offset = "0xFC5A8C", VA = "0xFC5A8C")]
		public static EventInstance CreateInstance(string path)
		{
			return default(EventInstance);
		}

		[Token(Token = "0x600086D")]
		[Address(RVA = "0xFCB5EC", Offset = "0xFCB5EC", VA = "0xFCB5EC")]
		public static EventInstance CreateInstance(Guid guid)
		{
			return default(EventInstance);
		}

		[Token(Token = "0x600086E")]
		[Address(RVA = "0xFCB88C", Offset = "0xFCB88C", VA = "0xFCB88C")]
		public static void PlayOneShot(string path, [Optional] UnityEngine.Vector3 position)
		{
		}

		[Token(Token = "0x600086F")]
		[Address(RVA = "0xFCB9F0", Offset = "0xFCB9F0", VA = "0xFCB9F0")]
		public static void PlayOneShot(Guid guid, [Optional] UnityEngine.Vector3 position)
		{
		}

		[Token(Token = "0x6000870")]
		[Address(RVA = "0xFCBAD0", Offset = "0xFCBAD0", VA = "0xFCBAD0")]
		public static void PlayOneShotAttached(string path, GameObject gameObject)
		{
		}

		[Token(Token = "0x6000871")]
		[Address(RVA = "0xFCBC18", Offset = "0xFCBC18", VA = "0xFCBC18")]
		public static void PlayOneShotAttached(Guid guid, GameObject gameObject)
		{
		}

		[Token(Token = "0x6000872")]
		[Address(RVA = "0xFCBCFC", Offset = "0xFCBCFC", VA = "0xFCBCFC")]
		public static EventDescription GetEventDescription(string path)
		{
			return default(EventDescription);
		}

		[Token(Token = "0x6000873")]
		[Address(RVA = "0xFCB688", Offset = "0xFCB688", VA = "0xFCB688")]
		public static EventDescription GetEventDescription(Guid guid)
		{
			return default(EventDescription);
		}

		[Token(Token = "0x6000874")]
		[Address(RVA = "0xFCBE0C", Offset = "0xFCBE0C", VA = "0xFCBE0C")]
		public static void SetListenerLocation(GameObject gameObject, [Optional] Rigidbody rigidBody)
		{
		}

		[Token(Token = "0x6000875")]
		[Address(RVA = "0xFCBFE4", Offset = "0xFCBFE4", VA = "0xFCBFE4")]
		public static void SetListenerLocation(GameObject gameObject, Rigidbody2D rigidBody2D)
		{
		}

		[Token(Token = "0x6000876")]
		[Address(RVA = "0xFCC1C8", Offset = "0xFCC1C8", VA = "0xFCC1C8")]
		public static void SetListenerLocation(Transform transform)
		{
		}

		[Token(Token = "0x6000877")]
		[Address(RVA = "0xFCC30C", Offset = "0xFCC30C", VA = "0xFCC30C")]
		public static void SetListenerLocation(int listenerIndex, GameObject gameObject, [Optional] Rigidbody rigidBody)
		{
		}

		[Token(Token = "0x6000878")]
		[Address(RVA = "0xFCC3B8", Offset = "0xFCC3B8", VA = "0xFCC3B8")]
		public static void SetListenerLocation(int listenerIndex, GameObject gameObject, Rigidbody2D rigidBody2D)
		{
		}

		[Token(Token = "0x6000879")]
		[Address(RVA = "0xFCC464", Offset = "0xFCC464", VA = "0xFCC464")]
		public static void SetListenerLocation(int listenerIndex, Transform transform)
		{
		}

		[Token(Token = "0x600087A")]
		[Address(RVA = "0xFCC508", Offset = "0xFCC508", VA = "0xFCC508")]
		public static Bus GetBus(string path)
		{
			return default(Bus);
		}

		[Token(Token = "0x600087B")]
		[Address(RVA = "0xFCC5C8", Offset = "0xFCC5C8", VA = "0xFCC5C8")]
		public static VCA GetVCA(string path)
		{
			return default(VCA);
		}

		[Token(Token = "0x600087C")]
		[Address(RVA = "0xFCA748", Offset = "0xFCA748", VA = "0xFCA748")]
		public static void PauseAllEvents(bool paused)
		{
		}

		[Token(Token = "0x600087D")]
		[Address(RVA = "0xFCC7C4", Offset = "0xFCC7C4", VA = "0xFCC7C4")]
		public static void MuteAllEvents(bool muted)
		{
		}

		[Token(Token = "0x6000880")]
		[Address(RVA = "0xFCC96C", Offset = "0xFCC96C", VA = "0xFCC96C")]
		public static bool HasBankLoaded(string loadedBank)
		{
			return default(bool);
		}

		[Token(Token = "0x6000881")]
		[Address(RVA = "0xFC8AA0", Offset = "0xFC8AA0", VA = "0xFC8AA0")]
		private void LoadPlugins(Settings fmodSettings)
		{
		}

		[Token(Token = "0x6000882")]
		[Address(RVA = "0xFC8990", Offset = "0xFC8990", VA = "0xFC8990")]
		private void SetThreadAffinity()
		{
		}

		[Token(Token = "0x6000883")]
		[Address(RVA = "0xFCCA74", Offset = "0xFCCA74", VA = "0xFCCA74")]
		public RuntimeManager()
		{
		}
	}
	[Token(Token = "0x2000115")]
	public class EventNotFoundException : Exception
	{
		[Token(Token = "0x4000573")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public Guid Guid;

		[Token(Token = "0x4000574")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public string Path;

		[Token(Token = "0x6000885")]
		[Address(RVA = "0xFC6AD8", Offset = "0xFC6AD8", VA = "0xFC6AD8")]
		public EventNotFoundException(string path)
		{
		}

		[Token(Token = "0x6000886")]
		[Address(RVA = "0xFC6B8C", Offset = "0xFC6B8C", VA = "0xFC6B8C")]
		public EventNotFoundException(Guid guid)
		{
		}
	}
	[Token(Token = "0x2000116")]
	public class BusNotFoundException : Exception
	{
		[Token(Token = "0x4000575")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public string Path;

		[Token(Token = "0x6000887")]
		[Address(RVA = "0xFC677C", Offset = "0xFC677C", VA = "0xFC677C")]
		public BusNotFoundException(string path)
		{
		}
	}
	[Token(Token = "0x2000117")]
	public class VCANotFoundException : Exception
	{
		[Token(Token = "0x4000576")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public string Path;

		[Token(Token = "0x6000888")]
		[Address(RVA = "0xFCC688", Offset = "0xFCC688", VA = "0xFCC688")]
		public VCANotFoundException(string path)
		{
		}
	}
	[Token(Token = "0x2000118")]
	public class BankLoadException : Exception
	{
		[Token(Token = "0x4000577")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public string Path;

		[Token(Token = "0x4000578")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public RESULT Result;

		[Token(Token = "0x6000889")]
		[Address(RVA = "0xFC65A4", Offset = "0xFC65A4", VA = "0xFC65A4")]
		public BankLoadException(string path, RESULT result)
		{
		}

		[Token(Token = "0x600088A")]
		[Address(RVA = "0xFC66B8", Offset = "0xFC66B8", VA = "0xFC66B8")]
		public BankLoadException(string path, string error)
		{
		}
	}
	[Token(Token = "0x2000119")]
	public class SystemNotInitializedException : Exception
	{
		[Token(Token = "0x4000579")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public RESULT Result;

		[Token(Token = "0x400057A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public string Location;

		[Token(Token = "0x600088B")]
		[Address(RVA = "0xFC807C", Offset = "0xFC807C", VA = "0xFC807C")]
		public SystemNotInitializedException(RESULT result, string location)
		{
		}

		[Token(Token = "0x600088C")]
		[Address(RVA = "0xFC7FF8", Offset = "0xFC7FF8", VA = "0xFC7FF8")]
		public SystemNotInitializedException(Exception inner)
		{
		}
	}
	[Token(Token = "0x200011A")]
	public enum EmitterGameEvent
	{
		[Token(Token = "0x400057C")]
		None,
		[Token(Token = "0x400057D")]
		ObjectStart,
		[Token(Token = "0x400057E")]
		ObjectDestroy,
		[Token(Token = "0x400057F")]
		TriggerEnter,
		[Token(Token = "0x4000580")]
		TriggerExit,
		[Token(Token = "0x4000581")]
		TriggerEnter2D,
		[Token(Token = "0x4000582")]
		TriggerExit2D,
		[Token(Token = "0x4000583")]
		CollisionEnter,
		[Token(Token = "0x4000584")]
		CollisionExit,
		[Token(Token = "0x4000585")]
		CollisionEnter2D,
		[Token(Token = "0x4000586")]
		CollisionExit2D,
		[Token(Token = "0x4000587")]
		ObjectEnable,
		[Token(Token = "0x4000588")]
		ObjectDisable,
		[Token(Token = "0x4000589")]
		MouseEnter,
		[Token(Token = "0x400058A")]
		MouseExit,
		[Token(Token = "0x400058B")]
		MouseDown,
		[Token(Token = "0x400058C")]
		MouseUp
	}
	[Token(Token = "0x200011B")]
	public enum LoaderGameEvent
	{
		[Token(Token = "0x400058E")]
		None,
		[Token(Token = "0x400058F")]
		ObjectStart,
		[Token(Token = "0x4000590")]
		ObjectDestroy,
		[Token(Token = "0x4000591")]
		TriggerEnter,
		[Token(Token = "0x4000592")]
		TriggerExit,
		[Token(Token = "0x4000593")]
		TriggerEnter2D,
		[Token(Token = "0x4000594")]
		TriggerExit2D
	}
	[Token(Token = "0x200011C")]
	public static class RuntimeUtils
	{
		[Token(Token = "0x4000595")]
		private const string BankExtension = ".bank";

		[Token(Token = "0x600088D")]
		[Address(RVA = "0xFCD0A8", Offset = "0xFCD0A8", VA = "0xFCD0A8")]
		public static string GetCommonPlatformPath(string path)
		{
			return null;
		}

		[Token(Token = "0x600088E")]
		[Address(RVA = "0xFCD0F8", Offset = "0xFCD0F8", VA = "0xFCD0F8")]
		public static VECTOR ToFMODVector(this UnityEngine.Vector3 vec)
		{
			return default(VECTOR);
		}

		[Token(Token = "0x600088F")]
		[Address(RVA = "0xFC5F24", Offset = "0xFC5F24", VA = "0xFC5F24")]
		public static ATTRIBUTES_3D To3DAttributes(this UnityEngine.Vector3 pos)
		{
			return default(ATTRIBUTES_3D);
		}

		[Token(Token = "0x6000890")]
		[Address(RVA = "0xFCC260", Offset = "0xFCC260", VA = "0xFCC260")]
		public static ATTRIBUTES_3D To3DAttributes(this Transform transform)
		{
			return default(ATTRIBUTES_3D);
		}

		[Token(Token = "0x6000891")]
		[Address(RVA = "0xFC9C9C", Offset = "0xFC9C9C", VA = "0xFC9C9C")]
		public static ATTRIBUTES_3D To3DAttributes(Transform transform, [Optional] Rigidbody rigidbody)
		{
			return default(ATTRIBUTES_3D);
		}

		[Token(Token = "0x6000892")]
		[Address(RVA = "0xFCBEB4", Offset = "0xFCBEB4", VA = "0xFCBEB4")]
		public static ATTRIBUTES_3D To3DAttributes(GameObject go, [Optional] Rigidbody rigidbody)
		{
			return default(ATTRIBUTES_3D);
		}

		[Token(Token = "0x6000893")]
		[Address(RVA = "0xFC9DC0", Offset = "0xFC9DC0", VA = "0xFC9DC0")]
		public static ATTRIBUTES_3D To3DAttributes(Transform transform, Rigidbody2D rigidbody)
		{
			return default(ATTRIBUTES_3D);
		}

		[Token(Token = "0x6000894")]
		[Address(RVA = "0xFCC08C", Offset = "0xFCC08C", VA = "0xFCC08C")]
		public static ATTRIBUTES_3D To3DAttributes(GameObject go, Rigidbody2D rigidbody)
		{
			return default(ATTRIBUTES_3D);
		}

		[Token(Token = "0x6000895")]
		[Address(RVA = "0xFC84CC", Offset = "0xFC84CC", VA = "0xFC84CC")]
		internal static FMODPlatform GetCurrentPlatform()
		{
			return default(FMODPlatform);
		}

		[Token(Token = "0x6000896")]
		[Address(RVA = "0xFCAE48", Offset = "0xFCAE48", VA = "0xFCAE48")]
		public static string GetBankPath(string bankName)
		{
			return null;
		}

		[Token(Token = "0x6000897")]
		[Address(RVA = "0xFCC9F8", Offset = "0xFCC9F8", VA = "0xFCC9F8")]
		internal static string GetPluginPath(string pluginName)
		{
			return null;
		}

		[Token(Token = "0x6000898")]
		[Address(RVA = "0xFC7914", Offset = "0xFC7914", VA = "0xFC7914")]
		public static void EnforceLibraryOrder()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200011D")]
	public enum FMODPlatform
	{
		[Token(Token = "0x4000597")]
		None,
		[Token(Token = "0x4000598")]
		PlayInEditor,
		[Token(Token = "0x4000599")]
		Default,
		[Token(Token = "0x400059A")]
		Desktop,
		[Token(Token = "0x400059B")]
		Mobile,
		[Token(Token = "0x400059C")]
		MobileHigh,
		[Token(Token = "0x400059D")]
		MobileLow,
		[Token(Token = "0x400059E")]
		Console,
		[Token(Token = "0x400059F")]
		Windows,
		[Token(Token = "0x40005A0")]
		Mac,
		[Token(Token = "0x40005A1")]
		Linux,
		[Token(Token = "0x40005A2")]
		iOS,
		[Token(Token = "0x40005A3")]
		Android,
		[Token(Token = "0x40005A4")]
		Deprecated_1,
		[Token(Token = "0x40005A5")]
		XboxOne,
		[Token(Token = "0x40005A6")]
		PS4,
		[Token(Token = "0x40005A7")]
		Deprecated_2,
		[Token(Token = "0x40005A8")]
		Deprecated_3,
		[Token(Token = "0x40005A9")]
		AppleTV,
		[Token(Token = "0x40005AA")]
		UWP,
		[Token(Token = "0x40005AB")]
		Switch,
		[Token(Token = "0x40005AC")]
		WebGL,
		[Token(Token = "0x40005AD")]
		Stadia,
		[Token(Token = "0x40005AE")]
		Count
	}
	[Serializable]
	[Token(Token = "0x200011E")]
	public enum ImportType
	{
		[Token(Token = "0x40005B0")]
		StreamingAssets,
		[Token(Token = "0x40005B1")]
		AssetBundle
	}
	[Serializable]
	[Token(Token = "0x200011F")]
	public enum BankLoadType
	{
		[Token(Token = "0x40005B3")]
		All,
		[Token(Token = "0x40005B4")]
		Specified,
		[Token(Token = "0x40005B5")]
		None
	}
	[Token(Token = "0x2000120")]
	public class PlatformSettingBase
	{
		[Token(Token = "0x40005B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public FMODPlatform Platform;

		[Token(Token = "0x6000899")]
		[Address(RVA = "0xFC6EB8", Offset = "0xFC6EB8", VA = "0xFC6EB8")]
		public PlatformSettingBase()
		{
		}
	}
	[Token(Token = "0x2000121")]
	public class PlatformSetting<T> : PlatformSettingBase
	{
		[Token(Token = "0x40005B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public T Value;

		[Token(Token = "0x600089A")]
		public PlatformSetting()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000122")]
	public class PlatformIntSetting : PlatformSetting<int>
	{
		[Token(Token = "0x600089B")]
		[Address(RVA = "0xFC6E68", Offset = "0xFC6E68", VA = "0xFC6E68")]
		public PlatformIntSetting()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000123")]
	public class PlatformStringSetting : PlatformSetting<string>
	{
		[Token(Token = "0x600089C")]
		[Address(RVA = "0xFC6EC0", Offset = "0xFC6EC0", VA = "0xFC6EC0")]
		public PlatformStringSetting()
		{
		}
	}
	[Token(Token = "0x2000124")]
	public enum TriStateBool
	{
		[Token(Token = "0x40005B9")]
		Disabled,
		[Token(Token = "0x40005BA")]
		Enabled,
		[Token(Token = "0x40005BB")]
		Development
	}
	[Serializable]
	[Token(Token = "0x2000125")]
	public class PlatformBoolSetting : PlatformSetting<TriStateBool>
	{
		[Token(Token = "0x600089D")]
		[Address(RVA = "0xFC6E18", Offset = "0xFC6E18", VA = "0xFC6E18")]
		public PlatformBoolSetting()
		{
		}
	}
	[Token(Token = "0x2000126")]
	public class Settings : ScriptableObject
	{
		[Token(Token = "0x2000151")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xC8541C", Offset = "0xC8541C")]
		private sealed class <>c__DisplayClass37_0<T> where T : PlatformSettingBase
		{
			[Token(Token = "0x40006F5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public FMODPlatform platform;

			[Token(Token = "0x6000946")]
			public <>c__DisplayClass37_0()
			{
			}

			[Token(Token = "0x6000947")]
			internal bool <HasSetting>b__0(T x)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x2000152")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xC8542C", Offset = "0xC8542C")]
		private sealed class <>c__DisplayClass38_0<T, U> where T : PlatformSetting<U>
		{
			[Token(Token = "0x40006F6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public FMODPlatform platform;

			[Token(Token = "0x6000948")]
			public <>c__DisplayClass38_0()
			{
			}

			[Token(Token = "0x6000949")]
			internal bool <GetSetting>b__0(T x)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x2000153")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xC8543C", Offset = "0xC8543C")]
		private sealed class <>c__DisplayClass39_0<T, U> where T : PlatformSetting<U>, new()
		{
			[Token(Token = "0x40006F7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public FMODPlatform platform;

			[Token(Token = "0x600094A")]
			public <>c__DisplayClass39_0()
			{
			}

			[Token(Token = "0x600094B")]
			internal bool <SetSetting>b__0(T x)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x2000154")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xC8544C", Offset = "0xC8544C")]
		private sealed class <>c__DisplayClass40_0<T> where T : PlatformSettingBase
		{
			[Token(Token = "0x40006F8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public FMODPlatform platform;

			[Token(Token = "0x600094C")]
			public <>c__DisplayClass40_0()
			{
			}

			[Token(Token = "0x600094D")]
			internal bool <RemoveSetting>b__0(T x)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x40005BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private bool SwitchSettingsMigration;

		[Token(Token = "0x40005BD")]
		private const string SettingsAssetName = "FMODStudioSettings";

		[Token(Token = "0x40005BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static Settings instance;

		[Token(Token = "0x40005BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		[SerializeField]
		public bool HasSourceProject;

		[Token(Token = "0x40005C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
		[SerializeField]
		public bool HasPlatforms;

		[Token(Token = "0x40005C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private string sourceProjectPath;

		[Token(Token = "0x40005C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private string sourceBankPath;

		[Token(Token = "0x40005C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		public string SourceBankPathUnformatted;

		[Token(Token = "0x40005C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		public bool AutomaticEventLoading;

		[Token(Token = "0x40005C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[SerializeField]
		public BankLoadType BankLoadType;

		[Token(Token = "0x40005C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		public bool AutomaticSampleLoading;

		[Token(Token = "0x40005C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		public string EncryptionKey;

		[Token(Token = "0x40005C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		public ImportType ImportType;

		[Token(Token = "0x40005C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		public string TargetAssetPath;

		[Token(Token = "0x40005CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		public DEBUG_FLAGS LoggingLevel;

		[Token(Token = "0x40005CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		public List<PlatformIntSetting> SpeakerModeSettings;

		[Token(Token = "0x40005CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		public List<PlatformIntSetting> SampleRateSettings;

		[Token(Token = "0x40005CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[SerializeField]
		public List<PlatformBoolSetting> LiveUpdateSettings;

		[Token(Token = "0x40005CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[SerializeField]
		public List<PlatformBoolSetting> OverlaySettings;

		[Token(Token = "0x40005CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[SerializeField]
		public List<PlatformBoolSetting> LoggingSettings;

		[Token(Token = "0x40005D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[SerializeField]
		public List<PlatformStringSetting> BankDirectorySettings;

		[Token(Token = "0x40005D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		[SerializeField]
		public List<PlatformIntSetting> VirtualChannelSettings;

		[Token(Token = "0x40005D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		[SerializeField]
		public List<PlatformIntSetting> RealChannelSettings;

		[Token(Token = "0x40005D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[SerializeField]
		public List<string> Plugins;

		[Token(Token = "0x40005D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[SerializeField]
		public List<string> MasterBanks;

		[Token(Token = "0x40005D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		[SerializeField]
		public List<string> Banks;

		[Token(Token = "0x40005D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[SerializeField]
		public List<string> BanksToLoad;

		[Token(Token = "0x40005D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[SerializeField]
		public ushort LiveUpdatePort;

		[Token(Token = "0x17000052")]
		public static Settings Instance
		{
			[Token(Token = "0x600089E")]
			[Address(RVA = "0xFC82B0", Offset = "0xFC82B0", VA = "0xFC82B0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000053")]
		public string SourceProjectPath
		{
			[Token(Token = "0x600089F")]
			[Address(RVA = "0xFCD0FC", Offset = "0xFCD0FC", VA = "0xFCD0FC")]
			get
			{
				return null;
			}
			[Token(Token = "0x60008A0")]
			[Address(RVA = "0xFCD104", Offset = "0xFCD104", VA = "0xFCD104")]
			set
			{
			}
		}

		[Token(Token = "0x17000054")]
		public string SourceBankPath
		{
			[Token(Token = "0x60008A1")]
			[Address(RVA = "0xFCD10C", Offset = "0xFCD10C", VA = "0xFCD10C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60008A2")]
			[Address(RVA = "0xFCD114", Offset = "0xFCD114", VA = "0xFCD114")]
			set
			{
			}
		}

		[Token(Token = "0x60008A3")]
		[Address(RVA = "0xFCD11C", Offset = "0xFCD11C", VA = "0xFCD11C")]
		public static FMODPlatform GetParent(FMODPlatform platform)
		{
			return default(FMODPlatform);
		}

		[Token(Token = "0x60008A4")]
		public static bool HasSetting<T>(List<T> list, FMODPlatform platform) where T : PlatformSettingBase
		{
			return default(bool);
		}

		[Token(Token = "0x60008A5")]
		public static U GetSetting<T, U>(List<T> list, FMODPlatform platform, U def) where T : PlatformSetting<U>
		{
			return (U)null;
		}

		[Token(Token = "0x60008A6")]
		public static void SetSetting<T, U>(List<T> list, FMODPlatform platform, U value) where T : PlatformSetting<U>, new()
		{
		}

		[Token(Token = "0x60008A7")]
		public static void RemoveSetting<T>(List<T> list, FMODPlatform platform) where T : PlatformSettingBase
		{
		}

		[Token(Token = "0x60008A8")]
		[Address(RVA = "0xFC8A0C", Offset = "0xFC8A0C", VA = "0xFC8A0C")]
		public bool IsLiveUpdateEnabled(FMODPlatform platform)
		{
			return default(bool);
		}

		[Token(Token = "0x60008A9")]
		[Address(RVA = "0xFCA080", Offset = "0xFCA080", VA = "0xFCA080")]
		public bool IsOverlayEnabled(FMODPlatform platform)
		{
			return default(bool);
		}

		[Token(Token = "0x60008AA")]
		[Address(RVA = "0xFC87F8", Offset = "0xFC87F8", VA = "0xFC87F8")]
		public int GetRealChannels(FMODPlatform platform)
		{
			return default(int);
		}

		[Token(Token = "0x60008AB")]
		[Address(RVA = "0xFC8880", Offset = "0xFC8880", VA = "0xFC8880")]
		public int GetVirtualChannels(FMODPlatform platform)
		{
			return default(int);
		}

		[Token(Token = "0x60008AC")]
		[Address(RVA = "0xFC8908", Offset = "0xFC8908", VA = "0xFC8908")]
		public int GetSpeakerMode(FMODPlatform platform)
		{
			return default(int);
		}

		[Token(Token = "0x60008AD")]
		[Address(RVA = "0xFC8770", Offset = "0xFC8770", VA = "0xFC8770")]
		public int GetSampleRate(FMODPlatform platform)
		{
			return default(int);
		}

		[Token(Token = "0x60008AE")]
		[Address(RVA = "0xFCD140", Offset = "0xFCD140", VA = "0xFCD140")]
		public string GetBankPlatform(FMODPlatform platform)
		{
			return null;
		}

		[Token(Token = "0x60008AF")]
		[Address(RVA = "0xFCD1EC", Offset = "0xFCD1EC", VA = "0xFCD1EC")]
		private Settings()
		{
		}

		[Token(Token = "0x60008B0")]
		[Address(RVA = "0xFCD5AC", Offset = "0xFCD5AC", VA = "0xFCD5AC")]
		private void OnEnable()
		{
		}
	}
	[Token(Token = "0x2000127")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xC8520C", Offset = "0xC8520C")]
	public class StudioBankLoader : MonoBehaviour
	{
		[Token(Token = "0x40005D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public LoaderGameEvent LoadEvent;

		[Token(Token = "0x40005D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public LoaderGameEvent UnloadEvent;

		[Token(Token = "0x40005DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[BankRef]
		public List<string> Banks;

		[Token(Token = "0x40005DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string CollisionTag;

		[Token(Token = "0x40005DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool PreloadSamples;

		[Token(Token = "0x40005DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
		private bool isQuitting;

		[Token(Token = "0x60008B2")]
		[Address(RVA = "0xFCD7AC", Offset = "0xFCD7AC", VA = "0xFCD7AC")]
		private void HandleGameEvent(LoaderGameEvent gameEvent)
		{
		}

		[Token(Token = "0x60008B3")]
		[Address(RVA = "0xFCDB40", Offset = "0xFCDB40", VA = "0xFCDB40")]
		private void Start()
		{
		}

		[Token(Token = "0x60008B4")]
		[Address(RVA = "0xFCDB68", Offset = "0xFCDB68", VA = "0xFCDB68")]
		private void OnApplicationQuit()
		{
		}

		[Token(Token = "0x60008B5")]
		[Address(RVA = "0xFCDB74", Offset = "0xFCDB74", VA = "0xFCDB74")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60008B6")]
		[Address(RVA = "0xFCDB88", Offset = "0xFCDB88", VA = "0xFCDB88")]
		private void OnTriggerEnter(Collider other)
		{
		}

		[Token(Token = "0x60008B7")]
		[Address(RVA = "0xFCDBE8", Offset = "0xFCDBE8", VA = "0xFCDBE8")]
		private void OnTriggerExit(Collider other)
		{
		}

		[Token(Token = "0x60008B8")]
		[Address(RVA = "0xFCDC48", Offset = "0xFCDC48", VA = "0xFCDC48")]
		private void OnTriggerEnter2D(Collider2D other)
		{
		}

		[Token(Token = "0x60008B9")]
		[Address(RVA = "0xFCDCA8", Offset = "0xFCDCA8", VA = "0xFCDCA8")]
		private void OnTriggerExit2D(Collider2D other)
		{
		}

		[Token(Token = "0x60008BA")]
		[Address(RVA = "0xFCD7FC", Offset = "0xFCD7FC", VA = "0xFCD7FC")]
		public void Load()
		{
		}

		[Token(Token = "0x60008BB")]
		[Address(RVA = "0xFCDA2C", Offset = "0xFCDA2C", VA = "0xFCDA2C")]
		public void Unload()
		{
		}

		[Token(Token = "0x60008BC")]
		[Address(RVA = "0xFCDD08", Offset = "0xFCDD08", VA = "0xFCDD08")]
		public StudioBankLoader()
		{
		}
	}
	[Token(Token = "0x2000128")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xC85244", Offset = "0xC85244")]
	public class StudioEventEmitter : EventHandler
	{
		[Token(Token = "0x40005DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[EventRef]
		public string Event;

		[Token(Token = "0x40005DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public EmitterGameEvent PlayEvent;

		[Token(Token = "0x40005E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public EmitterGameEvent StopEvent;

		[Token(Token = "0x40005E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool AllowFadeout;

		[Token(Token = "0x40005E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
		public bool TriggerOnce;

		[Token(Token = "0x40005E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x32")]
		public bool Preload;

		[Token(Token = "0x40005E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public ParamRef[] Params;

		[Token(Token = "0x40005E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public bool OverrideAttenuation;

		[Token(Token = "0x40005E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float OverrideMinDistance;

		[Token(Token = "0x40005E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float OverrideMaxDistance;

		[Token(Token = "0x40005E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		protected EventDescription eventDescription;

		[Token(Token = "0x40005E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		protected EventInstance instance;

		[Token(Token = "0x40005EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private bool hasTriggered;

		[Token(Token = "0x40005EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x61")]
		private bool isQuitting;

		[Token(Token = "0x40005EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x62")]
		private bool isOneshot;

		[Token(Token = "0x40005ED")]
		private const string SnapshotString = "snapshot";

		[Token(Token = "0x17000055")]
		public EventDescription EventDescription
		{
			[Token(Token = "0x60008BD")]
			[Address(RVA = "0xFCDD10", Offset = "0xFCDD10", VA = "0xFCDD10")]
			get
			{
				return default(EventDescription);
			}
		}

		[Token(Token = "0x17000056")]
		public EventInstance EventInstance
		{
			[Token(Token = "0x60008BE")]
			[Address(RVA = "0xFCDD18", Offset = "0xFCDD18", VA = "0xFCDD18")]
			get
			{
				return default(EventInstance);
			}
		}

		[Token(Token = "0x60008BF")]
		[Address(RVA = "0xFCDD20", Offset = "0xFCDD20", VA = "0xFCDD20")]
		private void Start()
		{
		}

		[Token(Token = "0x60008C0")]
		[Address(RVA = "0xFCDF2C", Offset = "0xFCDF2C", VA = "0xFCDF2C")]
		private void OnApplicationQuit()
		{
		}

		[Token(Token = "0x60008C1")]
		[Address(RVA = "0xFCDF38", Offset = "0xFCDF38", VA = "0xFCDF38")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60008C2")]
		[Address(RVA = "0xFCE02C", Offset = "0xFCE02C", VA = "0xFCE02C", Slot = "4")]
		protected override void HandleGameEvent(EmitterGameEvent gameEvent)
		{
		}

		[Token(Token = "0x60008C3")]
		[Address(RVA = "0xFCDE08", Offset = "0xFCDE08", VA = "0xFCDE08")]
		private void Lookup()
		{
		}

		[Token(Token = "0x60008C4")]
		[Address(RVA = "0xFCE07C", Offset = "0xFCE07C", VA = "0xFCE07C")]
		public void Play()
		{
		}

		[Token(Token = "0x60008C5")]
		[Address(RVA = "0xFCE3B0", Offset = "0xFCE3B0", VA = "0xFCE3B0")]
		public void Stop()
		{
		}

		[Token(Token = "0x60008C6")]
		[Address(RVA = "0xFCE414", Offset = "0xFCE414", VA = "0xFCE414")]
		public void SetParameter(string name, float value, bool ignoreseekspeed = false)
		{
		}

		[Token(Token = "0x60008C7")]
		[Address(RVA = "0xFCE484", Offset = "0xFCE484", VA = "0xFCE484")]
		public void SetParameter(PARAMETER_ID id, float value, bool ignoreseekspeed = false)
		{
		}

		[Token(Token = "0x60008C8")]
		[Address(RVA = "0xFCE4F4", Offset = "0xFCE4F4", VA = "0xFCE4F4")]
		public bool IsPlaying()
		{
			return default(bool);
		}

		[Token(Token = "0x60008C9")]
		[Address(RVA = "0xFCE548", Offset = "0xFCE548", VA = "0xFCE548")]
		public StudioEventEmitter()
		{
		}
	}
	[Token(Token = "0x2000129")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xC8527C", Offset = "0xC8527C")]
	public class StudioGlobalParameterTrigger : EventHandler
	{
		[Token(Token = "0x40005EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[ParamRef]
		public string parameter;

		[Token(Token = "0x40005EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public EmitterGameEvent TriggerEvent;

		[Token(Token = "0x40005F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float value;

		[Token(Token = "0x40005F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private PARAMETER_DESCRIPTION parameterDescription;

		[Token(Token = "0x17000057")]
		public PARAMETER_DESCRIPTION ParameterDesctription
		{
			[Token(Token = "0x60008CA")]
			[Address(RVA = "0xFCE5D8", Offset = "0xFCE5D8", VA = "0xFCE5D8")]
			get
			{
				return default(PARAMETER_DESCRIPTION);
			}
		}

		[Token(Token = "0x60008CB")]
		[Address(RVA = "0xFCE5EC", Offset = "0xFCE5EC", VA = "0xFCE5EC")]
		private RESULT Lookup()
		{
			return default(RESULT);
		}

		[Token(Token = "0x60008CC")]
		[Address(RVA = "0xFCE674", Offset = "0xFCE674", VA = "0xFCE674")]
		private void Awake()
		{
		}

		[Token(Token = "0x60008CD")]
		[Address(RVA = "0xFCE6B8", Offset = "0xFCE6B8", VA = "0xFCE6B8", Slot = "4")]
		protected override void HandleGameEvent(EmitterGameEvent gameEvent)
		{
		}

		[Token(Token = "0x60008CE")]
		[Address(RVA = "0xFCE6CC", Offset = "0xFCE6CC", VA = "0xFCE6CC")]
		public void TriggerParameters()
		{
		}

		[Token(Token = "0x60008CF")]
		[Address(RVA = "0xFCE7E0", Offset = "0xFCE7E0", VA = "0xFCE7E0")]
		public StudioGlobalParameterTrigger()
		{
		}
	}
	[Token(Token = "0x200012A")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xC852B4", Offset = "0xC852B4")]
	public class StudioListener : MonoBehaviour
	{
		[Token(Token = "0x40005F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Rigidbody rigidBody;

		[Token(Token = "0x40005F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Rigidbody2D rigidBody2D;

		[Token(Token = "0x40005F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public int ListenerNumber;

		[Token(Token = "0x60008D0")]
		[Address(RVA = "0xFCE7E4", Offset = "0xFCE7E4", VA = "0xFCE7E4")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60008D1")]
		[Address(RVA = "0xFCE8B8", Offset = "0xFCE8B8", VA = "0xFCE8B8")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60008D2")]
		[Address(RVA = "0xFCE91C", Offset = "0xFCE91C", VA = "0xFCE91C")]
		private void Update()
		{
		}

		[Token(Token = "0x60008D3")]
		[Address(RVA = "0xFCE930", Offset = "0xFCE930", VA = "0xFCE930")]
		private void SetListenerLocation()
		{
		}

		[Token(Token = "0x60008D4")]
		[Address(RVA = "0xFCEA2C", Offset = "0xFCEA2C", VA = "0xFCEA2C")]
		public StudioListener()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200012B")]
	public class EmitterRef
	{
		[Token(Token = "0x40005F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public StudioEventEmitter Target;

		[Token(Token = "0x40005F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public ParamRef[] Params;

		[Token(Token = "0x60008D5")]
		[Address(RVA = "0xFC6830", Offset = "0xFC6830", VA = "0xFC6830")]
		public EmitterRef()
		{
		}
	}
	[Token(Token = "0x200012C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xC852EC", Offset = "0xC852EC")]
	public class StudioParameterTrigger : EventHandler
	{
		[Token(Token = "0x40005F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public EmitterRef[] Emitters;

		[Token(Token = "0x40005F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public EmitterGameEvent TriggerEvent;

		[Token(Token = "0x60008D6")]
		[Address(RVA = "0xFCEA3C", Offset = "0xFCEA3C", VA = "0xFCEA3C")]
		private void Awake()
		{
		}

		[Token(Token = "0x60008D7")]
		[Address(RVA = "0xFCEC2C", Offset = "0xFCEC2C", VA = "0xFCEC2C", Slot = "4")]
		protected override void HandleGameEvent(EmitterGameEvent gameEvent)
		{
		}

		[Token(Token = "0x60008D8")]
		[Address(RVA = "0xFCEC40", Offset = "0xFCEC40", VA = "0xFCEC40")]
		public void TriggerParameters()
		{
		}

		[Token(Token = "0x60008D9")]
		[Address(RVA = "0xFCEDD8", Offset = "0xFCEDD8", VA = "0xFCEDD8")]
		public StudioParameterTrigger()
		{
		}
	}
}
namespace ChickenBuilder
{
	[Token(Token = "0x200012D")]
	public class BuildParameters : ScriptableObject
	{
		[Token(Token = "0x2000155")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xC8545C", Offset = "0xC8545C")]
		private sealed class <>c__DisplayClass6_0
		{
			[Token(Token = "0x40006F9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Parameter parameter;

			[Token(Token = "0x600094E")]
			[Address(RVA = "0x156C1C0", Offset = "0x156C1C0", VA = "0x156C1C0")]
			public <>c__DisplayClass6_0()
			{
			}

			[Token(Token = "0x600094F")]
			[Address(RVA = "0x156C61C", Offset = "0x156C61C", VA = "0x156C61C")]
			internal bool <SetParameter>b__0(Parameter p)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x2000156")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xC8546C", Offset = "0xC8546C")]
		private sealed class <>c__DisplayClass7_0
		{
			[Token(Token = "0x40006FA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Parameter parameter;

			[Token(Token = "0x6000950")]
			[Address(RVA = "0x156C2F8", Offset = "0x156C2F8", VA = "0x156C2F8")]
			public <>c__DisplayClass7_0()
			{
			}

			[Token(Token = "0x6000951")]
			[Address(RVA = "0x156C648", Offset = "0x156C648", VA = "0x156C648")]
			internal bool <SetTemporaryParameter>b__0(Parameter p)
			{
				return default(bool);
			}
		}

		[Serializable]
		[Token(Token = "0x2000157")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xC8547C", Offset = "0xC8547C")]
		private sealed class <>c
		{
			[Token(Token = "0x40006FB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x40006FC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Action<Parameter> <>9__8_0;

			[Token(Token = "0x6000953")]
			[Address(RVA = "0x156C60C", Offset = "0x156C60C", VA = "0x156C60C")]
			public <>c()
			{
			}

			[Token(Token = "0x6000954")]
			[Address(RVA = "0x156C614", Offset = "0x156C614", VA = "0x156C614")]
			internal void <SetTemporaryParameters>b__8_0(Parameter p)
			{
			}
		}

		[Token(Token = "0x2000158")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xC8548C", Offset = "0xC8548C")]
		private sealed class <>c__DisplayClass10_0<T>
		{
			[Token(Token = "0x40006FD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public string key;

			[Token(Token = "0x6000955")]
			public <>c__DisplayClass10_0()
			{
			}

			[Token(Token = "0x6000956")]
			internal bool <GetParameter>b__0(Parameter p)
			{
				return default(bool);
			}

			[Token(Token = "0x6000957")]
			internal bool <GetParameter>b__1(Parameter p)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x2000159")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xC8549C", Offset = "0xC8549C")]
		private sealed class <>c__DisplayClass11_0<T>
		{
			[Token(Token = "0x40006FE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public string key;

			[Token(Token = "0x6000958")]
			public <>c__DisplayClass11_0()
			{
			}

			[Token(Token = "0x6000959")]
			internal bool <GetParameter>b__0(Parameter p)
			{
				return default(bool);
			}

			[Token(Token = "0x600095A")]
			internal bool <GetParameter>b__1(Parameter p)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x40005F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Parameters data;

		[Token(Token = "0x40005FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static BuildParameters _instance;

		[Token(Token = "0x17000058")]
		private static BuildParameters instance
		{
			[Token(Token = "0x60008DA")]
			[Address(RVA = "0x156BEC8", Offset = "0x156BEC8", VA = "0x156BEC8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000059")]
		public static bool Exists
		{
			[Token(Token = "0x60008DB")]
			[Address(RVA = "0x156C020", Offset = "0x156C020", VA = "0x156C020")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60008DC")]
		[Address(RVA = "0x156C094", Offset = "0x156C094", VA = "0x156C094")]
		public static void SetParameter(Parameter parameter)
		{
		}

		[Token(Token = "0x60008DD")]
		[Address(RVA = "0x156C1CC", Offset = "0x156C1CC", VA = "0x156C1CC")]
		public static void SetTemporaryParameter(Parameter parameter)
		{
		}

		[Token(Token = "0x60008DE")]
		[Address(RVA = "0x156C300", Offset = "0x156C300", VA = "0x156C300")]
		public static void SetTemporaryParameters(List<Parameter> overrides)
		{
		}

		[Token(Token = "0x60008DF")]
		[Address(RVA = "0x156C400", Offset = "0x156C400", VA = "0x156C400")]
		public static void ClearTemporaryParameters()
		{
		}

		[Token(Token = "0x60008E0")]
		public static T GetParameter<T>(string key)
		{
			return (T)null;
		}

		[Token(Token = "0x60008E1")]
		public static T GetParameter<T>(string key, T defaultValue)
		{
			return (T)null;
		}

		[Token(Token = "0x60008E2")]
		[Address(RVA = "0x156C464", Offset = "0x156C464", VA = "0x156C464")]
		private static object ConvertArgumentValue(Type type, string value)
		{
			return null;
		}

		[Token(Token = "0x60008E3")]
		[Address(RVA = "0x156C550", Offset = "0x156C550", VA = "0x156C550")]
		private static object GetDefault(Type type)
		{
			return null;
		}

		[Token(Token = "0x60008E4")]
		[Address(RVA = "0x156C598", Offset = "0x156C598", VA = "0x156C598")]
		public static void Select()
		{
		}

		[Token(Token = "0x60008E5")]
		[Address(RVA = "0x156C1C8", Offset = "0x156C1C8", VA = "0x156C1C8")]
		private static void MarkDirty()
		{
		}

		[Token(Token = "0x60008E6")]
		[Address(RVA = "0x156C59C", Offset = "0x156C59C", VA = "0x156C59C")]
		public BuildParameters()
		{
		}
	}
	[Token(Token = "0x200012E")]
	public class DefaultParameterAttribute : Attribute
	{
		[Token(Token = "0x60008E7")]
		[Address(RVA = "0x156CB08", Offset = "0x156CB08", VA = "0x156CB08")]
		public DefaultParameterAttribute()
		{
		}
	}
	[Token(Token = "0x200012F")]
	public static class ChickenBuilderHelper
	{
		[Token(Token = "0x40005FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static Dictionary<Type, object[]> data;

		[Token(Token = "0x60008E8")]
		[Address(RVA = "0x156C674", Offset = "0x156C674", VA = "0x156C674")]
		public static string GetBundleVersionFromTime()
		{
			return null;
		}

		[Token(Token = "0x60008E9")]
		public static T Get<T>(Func<T, bool> where) where T : ScriptableObject
		{
			return null;
		}

		[Token(Token = "0x60008EA")]
		[Address(RVA = "0x156C708", Offset = "0x156C708", VA = "0x156C708")]
		public static ScriptableObject[] Get(Type type)
		{
			return null;
		}

		[Token(Token = "0x60008EB")]
		public static T GetSingle<T>() where T : ScriptableObject
		{
			return null;
		}

		[Token(Token = "0x60008EC")]
		public static T[] Get<T>(string path = "") where T : ScriptableObject
		{
			return null;
		}

		[Token(Token = "0x60008ED")]
		[Address(RVA = "0x156C778", Offset = "0x156C778", VA = "0x156C778")]
		public static ScriptableObject[] Get(Type type, string path)
		{
			return null;
		}

		[Token(Token = "0x60008EE")]
		[Address(RVA = "0x156C93C", Offset = "0x156C93C", VA = "0x156C93C")]
		public static void LoadData(params Type[] types)
		{
		}

		[Token(Token = "0x60008EF")]
		private static T[] FindAssetsByTypeAsArray<T>(string path) where T : UnityEngine.Object
		{
			return null;
		}

		[Token(Token = "0x60008F0")]
		[Address(RVA = "0x156C8B8", Offset = "0x156C8B8", VA = "0x156C8B8")]
		private static ScriptableObject[] FindAssetsByTypeAsArray(Type type, string path)
		{
			return null;
		}
	}
	[Serializable]
	[Token(Token = "0x2000130")]
	public class Parameter
	{
		[Token(Token = "0x40005FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string Key;

		[Token(Token = "0x40005FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string Value;

		[Token(Token = "0x40005FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[HideInInspector]
		public bool IsEditable;

		[Token(Token = "0x60008F2")]
		[Address(RVA = "0x156CB10", Offset = "0x156CB10", VA = "0x156CB10")]
		public Parameter(string key, string value)
		{
		}

		[Token(Token = "0x60008F3")]
		[Address(RVA = "0x156CB18", Offset = "0x156CB18", VA = "0x156CB18")]
		public Parameter(string key, string value, bool editable)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000131")]
	public class Parameters
	{
		[Token(Token = "0x40005FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[SerializeField]
		public List<Parameter> List;

		[Token(Token = "0x4000600")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		[HideInInspector]
		public List<Parameter> TemporaryList;

		[Token(Token = "0x1700005A")]
		[DefaultParameter]
		public static string BundleIdentifier
		{
			[Token(Token = "0x60008F4")]
			[Address(RVA = "0x156CB80", Offset = "0x156CB80", VA = "0x156CB80")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700005B")]
		[DefaultParameter]
		public static int BundleVersionCode
		{
			[Token(Token = "0x60008F5")]
			[Address(RVA = "0x156CBE0", Offset = "0x156CBE0", VA = "0x156CBE0")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700005C")]
		[DefaultParameter]
		public static int BuildVersionMajor
		{
			[Token(Token = "0x60008F6")]
			[Address(RVA = "0x156CC68", Offset = "0x156CC68", VA = "0x156CC68")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700005D")]
		[DefaultParameter]
		public static int BuildVersionMinor
		{
			[Token(Token = "0x60008F7")]
			[Address(RVA = "0x156CCC0", Offset = "0x156CCC0", VA = "0x156CCC0")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700005E")]
		[DefaultParameter]
		public static int BuildVersionPatch
		{
			[Token(Token = "0x60008F8")]
			[Address(RVA = "0x156CD18", Offset = "0x156CD18", VA = "0x156CD18")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700005F")]
		public static string BuildVersion
		{
			[Token(Token = "0x60008F9")]
			[Address(RVA = "0x156CD78", Offset = "0x156CD78", VA = "0x156CD78")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60008FA")]
		[Address(RVA = "0x156CE40", Offset = "0x156CE40", VA = "0x156CE40")]
		public Parameters()
		{
		}
	}
}
