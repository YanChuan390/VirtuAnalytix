using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using DG.Tweening.Core;
using DG.Tweening.Plugins;
using DG.Tweening.Plugins.Core.PathCore;
using DG.Tweening.Plugins.Options;
using FIMSpace.FTools;
using Il2CppDummyDll;
using Melanchall.DryWetMidi.Core;
using Melanchall.DryWetMidi.Interaction;
using Melanchall.DryWetMidi.Multimedia;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.EventSystems;
using UnityEngine.Playables;
using UnityEngine.Scripting;
using UnityEngine.Timeline;
using UnityEngine.UI;
using UnityEngine.Video;

[assembly: AssemblyVersion("0.0.0.0")]
[Serializable]
[Token(Token = "0x2000002")]
public class LightControlBehaviour : PlayableBehaviour
{
	[Token(Token = "0x4000001")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public Color color;

	[Token(Token = "0x4000002")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float intensity;

	[Token(Token = "0x4000003")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public float bounceIntensity;

	[Token(Token = "0x4000004")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float range;

	[Token(Token = "0x6000001")]
	[Address(RVA = "0x1A977B0", Offset = "0x1A977B0", VA = "0x1A977B0")]
	public LightControlBehaviour()
	{
	}
}
[Serializable]
[Token(Token = "0x2000003")]
public class LightControlClip : PlayableAsset, ITimelineClipAsset
{
	[Token(Token = "0x4000005")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public LightControlBehaviour template;

	[Token(Token = "0x17000001")]
	public ClipCaps clipCaps
	{
		[Token(Token = "0x6000002")]
		[Address(RVA = "0x1A977F4", Offset = "0x1A977F4", VA = "0x1A977F4", Slot = "9")]
		get
		{
			return default(ClipCaps);
		}
	}

	[Token(Token = "0x6000003")]
	[Address(RVA = "0x1A977FC", Offset = "0x1A977FC", VA = "0x1A977FC", Slot = "6")]
	public override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
	{
		return default(Playable);
	}

	[Token(Token = "0x6000004")]
	[Address(RVA = "0x1A978B0", Offset = "0x1A978B0", VA = "0x1A978B0")]
	public LightControlClip()
	{
	}
}
[Token(Token = "0x2000004")]
public class LightControlMixerBehaviour : PlayableBehaviour
{
	[Token(Token = "0x4000006")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private Color m_DefaultColor;

	[Token(Token = "0x4000007")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private float m_DefaultIntensity;

	[Token(Token = "0x4000008")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	private float m_DefaultBounceIntensity;

	[Token(Token = "0x4000009")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private float m_DefaultRange;

	[Token(Token = "0x400000A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Light m_TrackBinding;

	[Token(Token = "0x400000B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private bool m_FirstFrameHappened;

	[Token(Token = "0x6000005")]
	[Address(RVA = "0x1A9791C", Offset = "0x1A9791C", VA = "0x1A9791C", Slot = "20")]
	public override void ProcessFrame(Playable playable, FrameData info, object playerData)
	{
	}

	[Token(Token = "0x6000006")]
	[Address(RVA = "0x1A97D34", Offset = "0x1A97D34", VA = "0x1A97D34", Slot = "16")]
	public override void OnPlayableDestroy(Playable playable)
	{
	}

	[Token(Token = "0x6000007")]
	[Address(RVA = "0x1A97E0C", Offset = "0x1A97E0C", VA = "0x1A97E0C")]
	public LightControlMixerBehaviour()
	{
	}
}
[Token(Token = "0x2000005")]
[AttributeAttribute(Name = "TrackColorAttribute", RVA = "0x8CA68C", Offset = "0x8CA68C")]
[AttributeAttribute(Name = "TrackClipTypeAttribute", RVA = "0x8CA68C", Offset = "0x8CA68C")]
[AttributeAttribute(Name = "TrackBindingTypeAttribute", RVA = "0x8CA68C", Offset = "0x8CA68C")]
public class LightControlTrack : TrackAsset
{
	[Token(Token = "0x6000008")]
	[Address(RVA = "0x1A97E14", Offset = "0x1A97E14", VA = "0x1A97E14", Slot = "24")]
	public override Playable CreateTrackMixer(PlayableGraph graph, GameObject go, int inputCount)
	{
		return default(Playable);
	}

	[Token(Token = "0x6000009")]
	[Address(RVA = "0x1A97EC0", Offset = "0x1A97EC0", VA = "0x1A97EC0", Slot = "29")]
	public override void GatherProperties(PlayableDirector director, IPropertyCollector driver)
	{
	}

	[Token(Token = "0x600000A")]
	[Address(RVA = "0x1A97EC8", Offset = "0x1A97EC8", VA = "0x1A97EC8")]
	public LightControlTrack()
	{
	}
}
[Serializable]
[Token(Token = "0x2000006")]
public class NavMeshAgentControlBehaviour : PlayableBehaviour
{
	[Token(Token = "0x400000C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public Transform destination;

	[Token(Token = "0x400000D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool destinationSet;

	[Token(Token = "0x600000B")]
	[Address(RVA = "0x1A9BA5C", Offset = "0x1A9BA5C", VA = "0x1A9BA5C", Slot = "15")]
	public override void OnPlayableCreate(Playable playable)
	{
	}

	[Token(Token = "0x600000C")]
	[Address(RVA = "0x1A9BA64", Offset = "0x1A9BA64", VA = "0x1A9BA64")]
	public NavMeshAgentControlBehaviour()
	{
	}
}
[Serializable]
[Token(Token = "0x2000007")]
public class NavMeshAgentControlClip : PlayableAsset, ITimelineClipAsset
{
	[Token(Token = "0x400000E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public ExposedReference<Transform> destination;

	[Token(Token = "0x400000F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[HideInInspector]
	public NavMeshAgentControlBehaviour template;

	[Token(Token = "0x17000002")]
	public ClipCaps clipCaps
	{
		[Token(Token = "0x600000D")]
		[Address(RVA = "0x1A9BA6C", Offset = "0x1A9BA6C", VA = "0x1A9BA6C", Slot = "9")]
		get
		{
			return default(ClipCaps);
		}
	}

	[Token(Token = "0x600000E")]
	[Address(RVA = "0x1A9BA74", Offset = "0x1A9BA74", VA = "0x1A9BA74", Slot = "6")]
	public override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
	{
		return default(Playable);
	}

	[Token(Token = "0x600000F")]
	[Address(RVA = "0x1A9BBB8", Offset = "0x1A9BBB8", VA = "0x1A9BBB8")]
	public NavMeshAgentControlClip()
	{
	}
}
[Token(Token = "0x2000008")]
public class NavMeshAgentControlMixerBehaviour : PlayableBehaviour
{
	[Token(Token = "0x6000010")]
	[Address(RVA = "0x1A9BC28", Offset = "0x1A9BC28", VA = "0x1A9BC28", Slot = "20")]
	public override void ProcessFrame(Playable playable, FrameData info, object playerData)
	{
	}

	[Token(Token = "0x6000011")]
	[Address(RVA = "0x1A9BEA8", Offset = "0x1A9BEA8", VA = "0x1A9BEA8")]
	public NavMeshAgentControlMixerBehaviour()
	{
	}
}
[Token(Token = "0x2000009")]
[AttributeAttribute(Name = "TrackColorAttribute", RVA = "0x8CA748", Offset = "0x8CA748")]
[AttributeAttribute(Name = "TrackClipTypeAttribute", RVA = "0x8CA748", Offset = "0x8CA748")]
[AttributeAttribute(Name = "TrackBindingTypeAttribute", RVA = "0x8CA748", Offset = "0x8CA748")]
public class NavMeshAgentControlTrack : TrackAsset
{
	[Token(Token = "0x6000012")]
	[Address(RVA = "0x1A9BEB0", Offset = "0x1A9BEB0", VA = "0x1A9BEB0", Slot = "24")]
	public override Playable CreateTrackMixer(PlayableGraph graph, GameObject go, int inputCount)
	{
		return default(Playable);
	}

	[Token(Token = "0x6000013")]
	[Address(RVA = "0x1A9BF5C", Offset = "0x1A9BF5C", VA = "0x1A9BF5C")]
	public NavMeshAgentControlTrack()
	{
	}
}
[Serializable]
[Token(Token = "0x200000A")]
public class ScreenFaderBehaviour : PlayableBehaviour
{
	[Token(Token = "0x4000010")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public Color color;

	[Token(Token = "0x6000014")]
	[Address(RVA = "0x1A9D9EC", Offset = "0x1A9D9EC", VA = "0x1A9D9EC")]
	public ScreenFaderBehaviour()
	{
	}
}
[Serializable]
[Token(Token = "0x200000B")]
public class ScreenFaderClip : PlayableAsset, ITimelineClipAsset
{
	[Token(Token = "0x4000011")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public ScreenFaderBehaviour template;

	[Token(Token = "0x17000003")]
	public ClipCaps clipCaps
	{
		[Token(Token = "0x6000015")]
		[Address(RVA = "0x1A9DA20", Offset = "0x1A9DA20", VA = "0x1A9DA20", Slot = "9")]
		get
		{
			return default(ClipCaps);
		}
	}

	[Token(Token = "0x6000016")]
	[Address(RVA = "0x1A9DA28", Offset = "0x1A9DA28", VA = "0x1A9DA28", Slot = "6")]
	public override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
	{
		return default(Playable);
	}

	[Token(Token = "0x6000017")]
	[Address(RVA = "0x1A9DADC", Offset = "0x1A9DADC", VA = "0x1A9DADC")]
	public ScreenFaderClip()
	{
	}
}
[Token(Token = "0x200000C")]
public class ScreenFaderMixerBehaviour : PlayableBehaviour
{
	[Token(Token = "0x4000012")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private Color m_DefaultColor;

	[Token(Token = "0x4000013")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Image m_TrackBinding;

	[Token(Token = "0x4000014")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private bool m_FirstFrameHappened;

	[Token(Token = "0x6000018")]
	[Address(RVA = "0x1A9DB48", Offset = "0x1A9DB48", VA = "0x1A9DB48", Slot = "20")]
	public override void ProcessFrame(Playable playable, FrameData info, object playerData)
	{
	}

	[Token(Token = "0x6000019")]
	[Address(RVA = "0x1A9DE9C", Offset = "0x1A9DE9C", VA = "0x1A9DE9C", Slot = "16")]
	public override void OnPlayableDestroy(Playable playable)
	{
	}

	[Token(Token = "0x600001A")]
	[Address(RVA = "0x1A9DF40", Offset = "0x1A9DF40", VA = "0x1A9DF40")]
	public ScreenFaderMixerBehaviour()
	{
	}
}
[Token(Token = "0x200000D")]
[AttributeAttribute(Name = "TrackBindingTypeAttribute", RVA = "0x8CA804", Offset = "0x8CA804")]
[AttributeAttribute(Name = "TrackClipTypeAttribute", RVA = "0x8CA804", Offset = "0x8CA804")]
[AttributeAttribute(Name = "TrackColorAttribute", RVA = "0x8CA804", Offset = "0x8CA804")]
public class ScreenFaderTrack : TrackAsset
{
	[Token(Token = "0x600001B")]
	[Address(RVA = "0x1A9DF48", Offset = "0x1A9DF48", VA = "0x1A9DF48", Slot = "24")]
	public override Playable CreateTrackMixer(PlayableGraph graph, GameObject go, int inputCount)
	{
		return default(Playable);
	}

	[Token(Token = "0x600001C")]
	[Address(RVA = "0x1A9DFF4", Offset = "0x1A9DFF4", VA = "0x1A9DFF4", Slot = "29")]
	public override void GatherProperties(PlayableDirector director, IPropertyCollector driver)
	{
	}

	[Token(Token = "0x600001D")]
	[Address(RVA = "0x1A9DFFC", Offset = "0x1A9DFFC", VA = "0x1A9DFFC")]
	public ScreenFaderTrack()
	{
	}
}
[Serializable]
[Token(Token = "0x200000E")]
public class TextSwitcherBehaviour : PlayableBehaviour
{
	[Token(Token = "0x4000015")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public Color color;

	[Token(Token = "0x4000016")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public int fontSize;

	[Token(Token = "0x4000017")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public string text;

	[Token(Token = "0x600001E")]
	[Address(RVA = "0x1E330B4", Offset = "0x1E330B4", VA = "0x1E330B4")]
	public TextSwitcherBehaviour()
	{
	}
}
[Serializable]
[Token(Token = "0x200000F")]
public class TextSwitcherClip : PlayableAsset, ITimelineClipAsset
{
	[Token(Token = "0x4000018")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public TextSwitcherBehaviour template;

	[Token(Token = "0x17000004")]
	public ClipCaps clipCaps
	{
		[Token(Token = "0x600001F")]
		[Address(RVA = "0x1E330F0", Offset = "0x1E330F0", VA = "0x1E330F0", Slot = "9")]
		get
		{
			return default(ClipCaps);
		}
	}

	[Token(Token = "0x6000020")]
	[Address(RVA = "0x1E330F8", Offset = "0x1E330F8", VA = "0x1E330F8", Slot = "6")]
	public override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
	{
		return default(Playable);
	}

	[Token(Token = "0x6000021")]
	[Address(RVA = "0x1E331AC", Offset = "0x1E331AC", VA = "0x1E331AC")]
	public TextSwitcherClip()
	{
	}
}
[Token(Token = "0x2000010")]
public class TextSwitcherMixerBehaviour : PlayableBehaviour
{
	[Token(Token = "0x4000019")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private Color m_DefaultColor;

	[Token(Token = "0x400001A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private int m_DefaultFontSize;

	[Token(Token = "0x400001B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private string m_DefaultText;

	[Token(Token = "0x400001C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Text m_TrackBinding;

	[Token(Token = "0x400001D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private bool m_FirstFrameHappened;

	[Token(Token = "0x6000022")]
	[Address(RVA = "0x1174B8C", Offset = "0x1174B8C", VA = "0x1174B8C", Slot = "20")]
	public override void ProcessFrame(Playable playable, FrameData info, object playerData)
	{
	}

	[Token(Token = "0x6000023")]
	[Address(RVA = "0x1175008", Offset = "0x1175008", VA = "0x1175008", Slot = "16")]
	public override void OnPlayableDestroy(Playable playable)
	{
	}

	[Token(Token = "0x6000024")]
	[Address(RVA = "0x11750DC", Offset = "0x11750DC", VA = "0x11750DC")]
	public TextSwitcherMixerBehaviour()
	{
	}
}
[Token(Token = "0x2000011")]
[AttributeAttribute(Name = "TrackColorAttribute", RVA = "0x8CA8BC", Offset = "0x8CA8BC")]
[AttributeAttribute(Name = "TrackClipTypeAttribute", RVA = "0x8CA8BC", Offset = "0x8CA8BC")]
[AttributeAttribute(Name = "TrackBindingTypeAttribute", RVA = "0x8CA8BC", Offset = "0x8CA8BC")]
public class TextSwitcherTrack : TrackAsset
{
	[Token(Token = "0x6000025")]
	[Address(RVA = "0x11750E4", Offset = "0x11750E4", VA = "0x11750E4", Slot = "24")]
	public override Playable CreateTrackMixer(PlayableGraph graph, GameObject go, int inputCount)
	{
		return default(Playable);
	}

	[Token(Token = "0x6000026")]
	[Address(RVA = "0x1175190", Offset = "0x1175190", VA = "0x1175190", Slot = "29")]
	public override void GatherProperties(PlayableDirector director, IPropertyCollector driver)
	{
	}

	[Token(Token = "0x6000027")]
	[Address(RVA = "0x1175198", Offset = "0x1175198", VA = "0x1175198")]
	public TextSwitcherTrack()
	{
	}
}
[Serializable]
[Token(Token = "0x2000012")]
public class TimeDilationBehaviour : PlayableBehaviour
{
	[Token(Token = "0x400001E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public float timeScale;

	[Token(Token = "0x6000028")]
	[Address(RVA = "0x11751FC", Offset = "0x11751FC", VA = "0x11751FC")]
	public TimeDilationBehaviour()
	{
	}
}
[Serializable]
[Token(Token = "0x2000013")]
public class TimeDilationClip : PlayableAsset, ITimelineClipAsset
{
	[Token(Token = "0x400001F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public TimeDilationBehaviour template;

	[Token(Token = "0x17000005")]
	public ClipCaps clipCaps
	{
		[Token(Token = "0x6000029")]
		[Address(RVA = "0x117520C", Offset = "0x117520C", VA = "0x117520C", Slot = "9")]
		get
		{
			return default(ClipCaps);
		}
	}

	[Token(Token = "0x600002A")]
	[Address(RVA = "0x1175214", Offset = "0x1175214", VA = "0x1175214", Slot = "6")]
	public override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
	{
		return default(Playable);
	}

	[Token(Token = "0x600002B")]
	[Address(RVA = "0x11752C8", Offset = "0x11752C8", VA = "0x11752C8")]
	public TimeDilationClip()
	{
	}
}
[Token(Token = "0x2000014")]
public class TimeDilationMixerBehaviour : PlayableBehaviour
{
	[Token(Token = "0x4000020")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private readonly float defaultTimeScale;

	[Token(Token = "0x600002C")]
	[Address(RVA = "0x1175340", Offset = "0x1175340", VA = "0x1175340", Slot = "20")]
	public override void ProcessFrame(Playable playable, FrameData info, object playerData)
	{
	}

	[Token(Token = "0x600002D")]
	[Address(RVA = "0x1175544", Offset = "0x1175544", VA = "0x1175544", Slot = "18")]
	public override void OnBehaviourPause(Playable playable, FrameData info)
	{
	}

	[Token(Token = "0x600002E")]
	[Address(RVA = "0x1175550", Offset = "0x1175550", VA = "0x1175550", Slot = "14")]
	public override void OnGraphStop(Playable playable)
	{
	}

	[Token(Token = "0x600002F")]
	[Address(RVA = "0x117555C", Offset = "0x117555C", VA = "0x117555C", Slot = "16")]
	public override void OnPlayableDestroy(Playable playable)
	{
	}

	[Token(Token = "0x6000030")]
	[Address(RVA = "0x1175568", Offset = "0x1175568", VA = "0x1175568")]
	public TimeDilationMixerBehaviour()
	{
	}
}
[Token(Token = "0x2000015")]
[AttributeAttribute(Name = "TrackColorAttribute", RVA = "0x8CA978", Offset = "0x8CA978")]
[AttributeAttribute(Name = "TrackClipTypeAttribute", RVA = "0x8CA978", Offset = "0x8CA978")]
public class TimeDilationTrack : TrackAsset
{
	[Token(Token = "0x6000031")]
	[Address(RVA = "0x1175578", Offset = "0x1175578", VA = "0x1175578", Slot = "24")]
	public override Playable CreateTrackMixer(PlayableGraph graph, GameObject go, int inputCount)
	{
		return default(Playable);
	}

	[Token(Token = "0x6000032")]
	[Address(RVA = "0x1175624", Offset = "0x1175624", VA = "0x1175624")]
	public TimeDilationTrack()
	{
	}
}
[Serializable]
[Token(Token = "0x2000016")]
public class TransformTweenBehaviour : PlayableBehaviour
{
	[Token(Token = "0x2000017")]
	public enum TweenType
	{
		[Token(Token = "0x400002E")]
		Linear,
		[Token(Token = "0x400002F")]
		Deceleration,
		[Token(Token = "0x4000030")]
		Harmonic,
		[Token(Token = "0x4000031")]
		Custom
	}

	[Token(Token = "0x4000021")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public Transform startLocation;

	[Token(Token = "0x4000022")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Transform endLocation;

	[Token(Token = "0x4000023")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public bool tweenPosition;

	[Token(Token = "0x4000024")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
	public bool tweenRotation;

	[Token(Token = "0x4000025")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public TweenType tweenType;

	[Token(Token = "0x4000026")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public AnimationCurve customCurve;

	[Token(Token = "0x4000027")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Vector3 startingPosition;

	[Token(Token = "0x4000028")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public Quaternion startingRotation;

	[Token(Token = "0x4000029")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private AnimationCurve m_LinearCurve;

	[Token(Token = "0x400002A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private AnimationCurve m_DecelerationCurve;

	[Token(Token = "0x400002B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private AnimationCurve m_HarmonicCurve;

	[Token(Token = "0x400002C")]
	private const float k_RightAngleInRads = (float)Math.PI / 2f;

	[Token(Token = "0x6000033")]
	[Address(RVA = "0x1175688", Offset = "0x1175688", VA = "0x1175688", Slot = "19")]
	public override void PrepareFrame(Playable playable, FrameData info)
	{
	}

	[Token(Token = "0x6000034")]
	[Address(RVA = "0x117572C", Offset = "0x117572C", VA = "0x117572C")]
	public float EvaluateCurrentCurve(float time)
	{
		return default(float);
	}

	[Token(Token = "0x6000035")]
	[Address(RVA = "0x117582C", Offset = "0x117582C", VA = "0x117582C")]
	private bool IsCustomCurveNormalised()
	{
		return default(bool);
	}

	[Token(Token = "0x6000036")]
	[Address(RVA = "0x11759A8", Offset = "0x11759A8", VA = "0x11759A8")]
	public TransformTweenBehaviour()
	{
	}
}
[Serializable]
[Token(Token = "0x2000018")]
public class TransformTweenClip : PlayableAsset, ITimelineClipAsset
{
	[Token(Token = "0x4000032")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public TransformTweenBehaviour template;

	[Token(Token = "0x4000033")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public ExposedReference<Transform> startLocation;

	[Token(Token = "0x4000034")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public ExposedReference<Transform> endLocation;

	[Token(Token = "0x17000006")]
	public ClipCaps clipCaps
	{
		[Token(Token = "0x6000037")]
		[Address(RVA = "0x1175BB0", Offset = "0x1175BB0", VA = "0x1175BB0", Slot = "9")]
		get
		{
			return default(ClipCaps);
		}
	}

	[Token(Token = "0x6000038")]
	[Address(RVA = "0x1175BB8", Offset = "0x1175BB8", VA = "0x1175BB8", Slot = "6")]
	public override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
	{
		return default(Playable);
	}

	[Token(Token = "0x6000039")]
	[Address(RVA = "0x1175D2C", Offset = "0x1175D2C", VA = "0x1175D2C")]
	public TransformTweenClip()
	{
	}
}
[Token(Token = "0x2000019")]
public class TransformTweenMixerBehaviour : PlayableBehaviour
{
	[Token(Token = "0x4000035")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private bool m_FirstFrameHappened;

	[Token(Token = "0x600003A")]
	[Address(RVA = "0x1175D98", Offset = "0x1175D98", VA = "0x1175D98", Slot = "20")]
	public override void ProcessFrame(Playable playable, FrameData info, object playerData)
	{
	}

	[Token(Token = "0x600003B")]
	[Address(RVA = "0x1176488", Offset = "0x1176488", VA = "0x1176488", Slot = "16")]
	public override void OnPlayableDestroy(Playable playable)
	{
	}

	[Token(Token = "0x600003C")]
	[Address(RVA = "0x1176474", Offset = "0x1176474", VA = "0x1176474")]
	private static Quaternion AddQuaternions(Quaternion first, Quaternion second)
	{
		return default(Quaternion);
	}

	[Token(Token = "0x600003D")]
	[Address(RVA = "0x1176460", Offset = "0x1176460", VA = "0x1176460")]
	private static Quaternion ScaleQuaternion(Quaternion rotation, float multiplier)
	{
		return default(Quaternion);
	}

	[Token(Token = "0x600003E")]
	[Address(RVA = "0x1176490", Offset = "0x1176490", VA = "0x1176490")]
	private static float QuaternionMagnitude(Quaternion rotation)
	{
		return default(float);
	}

	[Token(Token = "0x600003F")]
	[Address(RVA = "0x117635C", Offset = "0x117635C", VA = "0x117635C")]
	private static Quaternion NormalizeQuaternion(Quaternion rotation)
	{
		return default(Quaternion);
	}

	[Token(Token = "0x6000040")]
	[Address(RVA = "0x11764D0", Offset = "0x11764D0", VA = "0x11764D0")]
	public TransformTweenMixerBehaviour()
	{
	}
}
[Token(Token = "0x200001A")]
[AttributeAttribute(Name = "TrackBindingTypeAttribute", RVA = "0x8CAA00", Offset = "0x8CAA00")]
[AttributeAttribute(Name = "TrackClipTypeAttribute", RVA = "0x8CAA00", Offset = "0x8CAA00")]
[AttributeAttribute(Name = "TrackColorAttribute", RVA = "0x8CAA00", Offset = "0x8CAA00")]
public class TransformTweenTrack : TrackAsset
{
	[Token(Token = "0x6000041")]
	[Address(RVA = "0x11764D8", Offset = "0x11764D8", VA = "0x11764D8", Slot = "24")]
	public override Playable CreateTrackMixer(PlayableGraph graph, GameObject go, int inputCount)
	{
		return default(Playable);
	}

	[Token(Token = "0x6000042")]
	[Address(RVA = "0x1176584", Offset = "0x1176584", VA = "0x1176584", Slot = "29")]
	public override void GatherProperties(PlayableDirector director, IPropertyCollector driver)
	{
	}

	[Token(Token = "0x6000043")]
	[Address(RVA = "0x117658C", Offset = "0x117658C", VA = "0x117658C")]
	public TransformTweenTrack()
	{
	}
}
[Token(Token = "0x200001B")]
public class AnimateText : MonoBehaviour
{
	[Token(Token = "0x200001C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8CAABC", Offset = "0x8CAABC")]
	private sealed class <DelayNextPage>d__11 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400003E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400003F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000040")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public AnimateText <>4__this;

		[Token(Token = "0x17000007")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600004E")]
			[Address(RVA = "0x117AD20", Offset = "0x117AD20", VA = "0x117AD20", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000008")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000050")]
			[Address(RVA = "0x117AD68", Offset = "0x117AD68", VA = "0x117AD68", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600004B")]
		[Address(RVA = "0x117AC30", Offset = "0x117AC30", VA = "0x117AC30")]
		[DebuggerHidden]
		public <DelayNextPage>d__11(int <>1__state)
		{
		}

		[Token(Token = "0x600004C")]
		[Address(RVA = "0x117AC5C", Offset = "0x117AC5C", VA = "0x117AC5C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600004D")]
		[Address(RVA = "0x117AC60", Offset = "0x117AC60", VA = "0x117AC60", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600004F")]
		[Address(RVA = "0x117AD28", Offset = "0x117AD28", VA = "0x117AD28", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000036")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public EventSetting source;

	[Token(Token = "0x4000037")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Text textUI;

	[Token(Token = "0x4000038")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private float wait;

	[Token(Token = "0x4000039")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public float delay;

	[Token(Token = "0x400003A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private bool begin;

	[Token(Token = "0x400003B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public string wordComplete;

	[Token(Token = "0x400003C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private string showText;

	[Token(Token = "0x400003D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private int i;

	[Token(Token = "0x6000044")]
	[Address(RVA = "0x11CE400", Offset = "0x11CE400", VA = "0x11CE400")]
	private void Start()
	{
	}

	[Token(Token = "0x6000045")]
	[Address(RVA = "0x11CE4F8", Offset = "0x11CE4F8", VA = "0x11CE4F8")]
	private void Update()
	{
	}

	[Token(Token = "0x6000046")]
	[Address(RVA = "0x11CE79C", Offset = "0x11CE79C", VA = "0x11CE79C")]
	private void Baga()
	{
	}

	[Token(Token = "0x6000047")]
	[Address(RVA = "0x11CE7C8", Offset = "0x11CE7C8", VA = "0x11CE7C8")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x8D0C6C", Offset = "0x8D0C6C")]
	private IEnumerator DelayNextPage()
	{
		return null;
	}

	[Token(Token = "0x6000048")]
	[Address(RVA = "0x11CE840", Offset = "0x11CE840", VA = "0x11CE840")]
	public void StartAnimate(string strComplete)
	{
	}

	[Token(Token = "0x6000049")]
	[Address(RVA = "0x11CE6D8", Offset = "0x11CE6D8", VA = "0x11CE6D8")]
	private void DoneText()
	{
	}

	[Token(Token = "0x600004A")]
	[Address(RVA = "0x11CEB48", Offset = "0x11CEB48", VA = "0x11CEB48")]
	public AnimateText()
	{
	}
}
[Token(Token = "0x200001D")]
public class EventActivator : MonoBehaviour
{
	[Token(Token = "0x200001E")]
	public enum StartConditions
	{
		[Token(Token = "0x400004B")]
		KeyTrigger,
		[Token(Token = "0x400004C")]
		Collide,
		[Token(Token = "0x400004D")]
		TriggerEnter,
		[Token(Token = "0x400004E")]
		AutoStart,
		[Token(Token = "0x400004F")]
		None
	}

	[Token(Token = "0x200001F")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8CAACC", Offset = "0x8CAACC")]
	private sealed class <LookPlayer>d__14 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000050")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000051")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000052")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public EventActivator <>4__this;

		[Token(Token = "0x17000009")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000061")]
			[Address(RVA = "0x117F18C", Offset = "0x117F18C", VA = "0x117F18C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700000A")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000063")]
			[Address(RVA = "0x117F1D4", Offset = "0x117F1D4", VA = "0x117F1D4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600005E")]
		[Address(RVA = "0x117EFEC", Offset = "0x117EFEC", VA = "0x117EFEC")]
		[DebuggerHidden]
		public <LookPlayer>d__14(int <>1__state)
		{
		}

		[Token(Token = "0x600005F")]
		[Address(RVA = "0x117F018", Offset = "0x117F018", VA = "0x117F018", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000060")]
		[Address(RVA = "0x117F01C", Offset = "0x117F01C", VA = "0x117F01C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000062")]
		[Address(RVA = "0x117F194", Offset = "0x117F194", VA = "0x117F194", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000041")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[HideInInspector]
	public int runEvent;

	[Token(Token = "0x4000042")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public StartConditions startCondition;

	[Token(Token = "0x4000043")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public bool lookAtPlayer;

	[Token(Token = "0x4000044")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
	public bool lockYAngle;

	[Token(Token = "0x4000045")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x22")]
	private bool onLooking;

	[Token(Token = "0x4000046")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x23")]
	public bool freezePlayerDuringEvent;

	[Token(Token = "0x4000047")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	[HideInInspector]
	public bool eventRunning;

	[Token(Token = "0x4000048")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private Transform mainPlayer;

	[Token(Token = "0x4000049")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static bool globalFreeze;

	[Token(Token = "0x6000051")]
	[Address(RVA = "0x11DF820", Offset = "0x11DF820", VA = "0x11DF820")]
	private void Start()
	{
	}

	[Token(Token = "0x6000052")]
	[Address(RVA = "0x11DF8F0", Offset = "0x11DF8F0", VA = "0x11DF8F0")]
	private void FreezePlayer()
	{
	}

	[Token(Token = "0x6000053")]
	[Address(RVA = "0x11E1674", Offset = "0x11E1674", VA = "0x11E1674")]
	private void Update()
	{
	}

	[Token(Token = "0x6000054")]
	[Address(RVA = "0x11E1858", Offset = "0x11E1858", VA = "0x11E1858")]
	public void ActivateTrigger()
	{
	}

	[Token(Token = "0x6000055")]
	[Address(RVA = "0x11E1930", Offset = "0x11E1930", VA = "0x11E1930")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x8D0D1C", Offset = "0x8D0D1C")]
	private IEnumerator LookPlayer()
	{
		return null;
	}

	[Token(Token = "0x6000056")]
	[Address(RVA = "0x11E1868", Offset = "0x11E1868", VA = "0x11E1868")]
	public void ActivateEvent()
	{
	}

	[Token(Token = "0x6000057")]
	[Address(RVA = "0x11E19A8", Offset = "0x11E19A8", VA = "0x11E19A8")]
	public void ActivateEventId(int id)
	{
	}

	[Token(Token = "0x6000058")]
	[Address(RVA = "0x11E1A4C", Offset = "0x11E1A4C", VA = "0x11E1A4C")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x6000059")]
	[Address(RVA = "0x11E1AE0", Offset = "0x11E1AE0", VA = "0x11E1AE0")]
	private void OnCollisionEnter(Collision other)
	{
	}

	[Token(Token = "0x600005A")]
	[Address(RVA = "0x11E1AF4", Offset = "0x11E1AF4", VA = "0x11E1AF4")]
	private void FindPlayer()
	{
	}

	[Token(Token = "0x600005B")]
	[Address(RVA = "0x11E1BAC", Offset = "0x11E1BAC", VA = "0x11E1BAC")]
	public void EndEvent()
	{
	}

	[Token(Token = "0x600005C")]
	[Address(RVA = "0x11E1C24", Offset = "0x11E1C24", VA = "0x11E1C24")]
	public EventActivator()
	{
	}
}
[Token(Token = "0x2000020")]
[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x8CAADC", Offset = "0x8CAADC")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0x8CAADC", Offset = "0x8CAADC")]
public class EventSetting : MonoBehaviour
{
	[Token(Token = "0x2000021")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8CAB60", Offset = "0x8CAB60")]
	private sealed class <Waiting>d__54 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000086")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000087")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000088")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public EventSetting <>4__this;

		[Token(Token = "0x1700000B")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000075")]
			[Address(RVA = "0x117F2CC", Offset = "0x117F2CC", VA = "0x117F2CC", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700000C")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000077")]
			[Address(RVA = "0x117F314", Offset = "0x117F314", VA = "0x117F314", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000072")]
		[Address(RVA = "0x117F1DC", Offset = "0x117F1DC", VA = "0x117F1DC")]
		[DebuggerHidden]
		public <Waiting>d__54(int <>1__state)
		{
		}

		[Token(Token = "0x6000073")]
		[Address(RVA = "0x117F208", Offset = "0x117F208", VA = "0x117F208", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000074")]
		[Address(RVA = "0x117F20C", Offset = "0x117F20C", VA = "0x117F20C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000076")]
		[Address(RVA = "0x117F2D4", Offset = "0x117F2D4", VA = "0x117F2D4", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000053")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static GameObject mainPlayer;

	[Token(Token = "0x4000054")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public ParametersType type;

	[Token(Token = "0x4000055")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public string message;

	[Token(Token = "0x4000056")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Transform target;

	[Token(Token = "0x4000057")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Transform target2;

	[Token(Token = "0x4000058")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public bool targetIsPlayer;

	[Token(Token = "0x4000059")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public float floatVar;

	[Token(Token = "0x400005A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public float floatVar2;

	[Token(Token = "0x400005B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	public float floatVar3;

	[Token(Token = "0x400005C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public float floatVar4;

	[Token(Token = "0x400005D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	public float floatVar5;

	[Token(Token = "0x400005E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public Vector3 vector3Var;

	[Token(Token = "0x400005F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	public Vector3 vector3Var2;

	[Token(Token = "0x4000060")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public Vector2 vector2Var;

	[Token(Token = "0x4000061")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public Transform objectVar;

	[Token(Token = "0x4000062")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public string msgString;

	[Token(Token = "0x4000063")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public string msgString2;

	[Token(Token = "0x4000064")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public int intVar;

	[Token(Token = "0x4000065")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
	public int intVar2;

	[Token(Token = "0x4000066")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public int intVar3;

	[Token(Token = "0x4000067")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
	public int intVar4;

	[Token(Token = "0x4000068")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public bool boolVar;

	[Token(Token = "0x4000069")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x99")]
	public bool boolVar2;

	[Token(Token = "0x400006A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x9A")]
	public bool boolVar3;

	[Token(Token = "0x400006B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x9B")]
	public bool boolVar4;

	[Token(Token = "0x400006C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
	public bool boolVar5;

	[Token(Token = "0x400006D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x9D")]
	public bool sendBack;

	[Token(Token = "0x400006E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x9E")]
	public bool stopMoving;

	[Token(Token = "0x400006F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public AnimationClip animClip;

	[Token(Token = "0x4000070")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public AudioClip audiClip;

	[Token(Token = "0x4000071")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	public string stringVar;

	[Token(Token = "0x4000072")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	public string stringVar2;

	[Token(Token = "0x4000073")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	public Color colorVar;

	[Token(Token = "0x4000074")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	public Color colorVar2;

	[Token(Token = "0x4000075")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	public Color colorVar3;

	[Token(Token = "0x4000076")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	public Material matVar;

	[Token(Token = "0x4000077")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	public Light lightVar;

	[Token(Token = "0x4000078")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	public float lightIntesity;

	[Token(Token = "0x4000079")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	public Image imageVar;

	[Token(Token = "0x400007A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
	public Image imageVar2;

	[Token(Token = "0x400007B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
	public Image textBoxVar;

	[Token(Token = "0x400007C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
	public Text showText;

	[Token(Token = "0x400007D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
	public Text nameText;

	[Token(Token = "0x400007E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
	public Sprite spriteVar;

	[Token(Token = "0x400007F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public static bool[] globalBoolean;

	[Token(Token = "0x4000080")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public static int[] globalInt;

	[Token(Token = "0x4000081")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
	public IntValueSet math;

	[Token(Token = "0x4000082")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x13C")]
	public ConditionChecker condi;

	[Token(Token = "0x4000083")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
	public CondiCheckForm condiForm;

	[Token(Token = "0x4000084")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
	public string note;

	[Token(Token = "0x4000085")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
	public string noteId;

	[Token(Token = "0x6000064")]
	[Address(RVA = "0x11DF958", Offset = "0x11DF958", VA = "0x11DF958")]
	public void Activate()
	{
	}

	[Token(Token = "0x6000065")]
	[Address(RVA = "0x11E24B8", Offset = "0x11E24B8", VA = "0x11E24B8")]
	public void GoToEvent(int id)
	{
	}

	[Token(Token = "0x6000066")]
	[Address(RVA = "0x11E2580", Offset = "0x11E2580", VA = "0x11E2580")]
	private Transform SetTarget()
	{
		return null;
	}

	[Token(Token = "0x6000067")]
	[Address(RVA = "0x11E2008", Offset = "0x11E2008", VA = "0x11E2008")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x8D0DCC", Offset = "0x8D0DCC")]
	private IEnumerator Waiting()
	{
		return null;
	}

	[Token(Token = "0x6000068")]
	[Address(RVA = "0x11E2080", Offset = "0x11E2080", VA = "0x11E2080")]
	private void SpawnPrefab(int mode)
	{
	}

	[Token(Token = "0x6000069")]
	[Address(RVA = "0x11E2888", Offset = "0x11E2888", VA = "0x11E2888")]
	public void SetSkyFog()
	{
	}

	[Token(Token = "0x600006A")]
	[Address(RVA = "0x11E2924", Offset = "0x11E2924", VA = "0x11E2924")]
	public void SetLight()
	{
	}

	[Token(Token = "0x600006B")]
	[Address(RVA = "0x11E2794", Offset = "0x11E2794", VA = "0x11E2794")]
	public void NextEvent()
	{
	}

	[Token(Token = "0x600006C")]
	[Address(RVA = "0x11E2A14", Offset = "0x11E2A14", VA = "0x11E2A14")]
	private void ShakeCamera()
	{
	}

	[Token(Token = "0x600006D")]
	[Address(RVA = "0x11E2B18", Offset = "0x11E2B18", VA = "0x11E2B18")]
	private bool CheckCondition()
	{
		return default(bool);
	}

	[Token(Token = "0x600006E")]
	[Address(RVA = "0x11E1C30", Offset = "0x11E1C30", VA = "0x11E1C30")]
	private void StartDialogue()
	{
	}

	[Token(Token = "0x600006F")]
	[Address(RVA = "0x11CE978", Offset = "0x11CE978", VA = "0x11CE978")]
	public void FinishDialogue()
	{
	}

	[Token(Token = "0x6000070")]
	[Address(RVA = "0x11E2D98", Offset = "0x11E2D98", VA = "0x11E2D98")]
	public EventSetting()
	{
	}
}
[Token(Token = "0x2000022")]
public enum ParametersType
{
	[Token(Token = "0x400008A")]
	Dialogue,
	[Token(Token = "0x400008B")]
	Wait,
	[Token(Token = "0x400008C")]
	SpawnPrefab,
	[Token(Token = "0x400008D")]
	SpawnPrefabAtObject,
	[Token(Token = "0x400008E")]
	GoToEvent,
	[Token(Token = "0x400008F")]
	MoveObject,
	[Token(Token = "0x4000090")]
	MoveObjectTowards,
	[Token(Token = "0x4000091")]
	EnableObject,
	[Token(Token = "0x4000092")]
	DisableObject,
	[Token(Token = "0x4000093")]
	DeleteObject,
	[Token(Token = "0x4000094")]
	PlayLegacyAnimation,
	[Token(Token = "0x4000095")]
	PlayMecanimAnimation,
	[Token(Token = "0x4000096")]
	ControlBoolean,
	[Token(Token = "0x4000097")]
	ControlVariable,
	[Token(Token = "0x4000098")]
	ConditionCheck,
	[Token(Token = "0x4000099")]
	PlayBGM,
	[Token(Token = "0x400009A")]
	PlayOneShotAudio,
	[Token(Token = "0x400009B")]
	ChangeScene,
	[Token(Token = "0x400009C")]
	SetObjectLocation,
	[Token(Token = "0x400009D")]
	SetObjectRotation,
	[Token(Token = "0x400009E")]
	SetObjectAtObjectPosition,
	[Token(Token = "0x400009F")]
	LookAtTarget,
	[Token(Token = "0x40000A0")]
	StopMovingAndLooking,
	[Token(Token = "0x40000A1")]
	AmbientEditor,
	[Token(Token = "0x40000A2")]
	LightEditor,
	[Token(Token = "0x40000A3")]
	FadeImage,
	[Token(Token = "0x40000A4")]
	MoveImage,
	[Token(Token = "0x40000A5")]
	ScreenShake,
	[Token(Token = "0x40000A6")]
	SetTimeScale,
	[Token(Token = "0x40000A7")]
	SendMessage,
	[Token(Token = "0x40000A8")]
	BreakEvent
}
[Token(Token = "0x2000023")]
public enum IntValueSet
{
	[Token(Token = "0x40000AA")]
	Equal,
	[Token(Token = "0x40000AB")]
	Plus,
	[Token(Token = "0x40000AC")]
	Minus,
	[Token(Token = "0x40000AD")]
	Multiply,
	[Token(Token = "0x40000AE")]
	Divide
}
[Token(Token = "0x2000024")]
public enum ConditionChecker
{
	[Token(Token = "0x40000B0")]
	GreaterOrEqual,
	[Token(Token = "0x40000B1")]
	Greater,
	[Token(Token = "0x40000B2")]
	Equal,
	[Token(Token = "0x40000B3")]
	LessOrEqual,
	[Token(Token = "0x40000B4")]
	Less,
	[Token(Token = "0x40000B5")]
	NotEqual
}
[Token(Token = "0x2000025")]
public enum CondiCheckForm
{
	[Token(Token = "0x40000B7")]
	Variable,
	[Token(Token = "0x40000B8")]
	Boolean
}
[Token(Token = "0x2000026")]
public class FadeImage : MonoBehaviour
{
	[Token(Token = "0x40000B9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool fading;

	[Token(Token = "0x40000BA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public Color startColor;

	[Token(Token = "0x40000BB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public Color endColor;

	[Token(Token = "0x40000BC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public float lerpSpeed;

	[Token(Token = "0x40000BD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private float t;

	[Token(Token = "0x6000078")]
	[Address(RVA = "0x1A94B50", Offset = "0x1A94B50", VA = "0x1A94B50")]
	public void SetFirstColor(Color c)
	{
	}

	[Token(Token = "0x6000079")]
	[Address(RVA = "0x1A94BE8", Offset = "0x1A94BE8", VA = "0x1A94BE8")]
	private void Update()
	{
	}

	[Token(Token = "0x600007A")]
	[Address(RVA = "0x1A94CF8", Offset = "0x1A94CF8", VA = "0x1A94CF8")]
	public FadeImage()
	{
	}
}
[Token(Token = "0x2000027")]
public class MoveImage : MonoBehaviour
{
	[Token(Token = "0x40000BE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool onMoving;

	[Token(Token = "0x40000BF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
	public bool onScaling;

	[Token(Token = "0x40000C0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public Vector3 destinationPosition;

	[Token(Token = "0x40000C1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Vector2 size;

	[Token(Token = "0x40000C2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public float speed;

	[Token(Token = "0x40000C3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public float scalingSpeed;

	[Token(Token = "0x600007B")]
	[Address(RVA = "0x1A9B0A4", Offset = "0x1A9B0A4", VA = "0x1A9B0A4")]
	private void Update()
	{
	}

	[Token(Token = "0x600007C")]
	[Address(RVA = "0x1A9B214", Offset = "0x1A9B214", VA = "0x1A9B214")]
	public MoveImage()
	{
	}
}
[Token(Token = "0x2000028")]
public class MovingLookingEvent : MonoBehaviour
{
	[Token(Token = "0x40000C4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Vector3 destinationPosition;

	[Token(Token = "0x40000C5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Transform destinationObject;

	[Token(Token = "0x40000C6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public float moveSpeed;

	[Token(Token = "0x40000C7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public Vector3 lookToRotation;

	[Token(Token = "0x40000C8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Transform lookAtObject;

	[Token(Token = "0x40000C9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public float lookSpeed;

	[Token(Token = "0x40000CA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	public bool onMoving;

	[Token(Token = "0x40000CB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4D")]
	public bool onLooking;

	[Token(Token = "0x40000CC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4E")]
	public bool useCharacterController;

	[Token(Token = "0x40000CD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4F")]
	public bool lockYAngle;

	[Token(Token = "0x40000CE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public float reachDistance;

	[Token(Token = "0x40000CF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public string sendMsgWhenReact;

	[Token(Token = "0x40000D0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public bool stopWhenReach;

	[Token(Token = "0x40000D1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x61")]
	[HideInInspector]
	public bool stopSending;

	[Token(Token = "0x40000D2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public EventSetting source;

	[Token(Token = "0x600007D")]
	[Address(RVA = "0x1A9B42C", Offset = "0x1A9B42C", VA = "0x1A9B42C")]
	private void Update()
	{
	}

	[Token(Token = "0x600007E")]
	[Address(RVA = "0x1A9B808", Offset = "0x1A9B808", VA = "0x1A9B808")]
	private void MoveTowardsTarget(Vector3 targeta)
	{
	}

	[Token(Token = "0x600007F")]
	[Address(RVA = "0x1A9B9C8", Offset = "0x1A9B9C8", VA = "0x1A9B9C8")]
	public MovingLookingEvent()
	{
	}
}
[Token(Token = "0x2000029")]
[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x8CAB70", Offset = "0x8CAB70")]
public class PlayerActivateEvent : MonoBehaviour
{
	[Token(Token = "0x40000D3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public string triggerKey;

	[Token(Token = "0x40000D4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float checkDistance;

	[Token(Token = "0x40000D5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Transform player;

	[Token(Token = "0x40000D6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private bool showUi;

	[Token(Token = "0x40000D7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public GUIStyle textStyle;

	[Token(Token = "0x40000D8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public EventActivator activateEvent;

	[Token(Token = "0x6000080")]
	[Address(RVA = "0x1A9C4B4", Offset = "0x1A9C4B4", VA = "0x1A9C4B4")]
	private void Start()
	{
	}

	[Token(Token = "0x6000081")]
	[Address(RVA = "0x1A9C568", Offset = "0x1A9C568", VA = "0x1A9C568")]
	private void Update()
	{
	}

	[Token(Token = "0x6000082")]
	[Address(RVA = "0x1A9C6D0", Offset = "0x1A9C6D0", VA = "0x1A9C6D0")]
	private void ActivateEvent()
	{
	}

	[Token(Token = "0x6000083")]
	[Address(RVA = "0x1A9C80C", Offset = "0x1A9C80C", VA = "0x1A9C80C")]
	private void OnGUI()
	{
	}

	[Token(Token = "0x6000084")]
	[Address(RVA = "0x1A9C964", Offset = "0x1A9C964", VA = "0x1A9C964")]
	public PlayerActivateEvent()
	{
	}
}
[Token(Token = "0x200002A")]
public class ShakeScreen : MonoBehaviour
{
	[Token(Token = "0x200002B")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8CABA8", Offset = "0x8CABA8")]
	private sealed class <Shaking>d__4 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40000DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40000DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40000DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ShakeScreen <>4__this;

		[Token(Token = "0x40000DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float val;

		[Token(Token = "0x40000E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float dur;

		[Token(Token = "0x1700000D")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600008C")]
			[Address(RVA = "0x1182ECC", Offset = "0x1182ECC", VA = "0x1182ECC", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700000E")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600008E")]
			[Address(RVA = "0x1182F14", Offset = "0x1182F14", VA = "0x1182F14", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000089")]
		[Address(RVA = "0x1182DBC", Offset = "0x1182DBC", VA = "0x1182DBC")]
		[DebuggerHidden]
		public <Shaking>d__4(int <>1__state)
		{
		}

		[Token(Token = "0x600008A")]
		[Address(RVA = "0x1182DE8", Offset = "0x1182DE8", VA = "0x1182DE8", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600008B")]
		[Address(RVA = "0x1182DEC", Offset = "0x1182DEC", VA = "0x1182DEC", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600008D")]
		[Address(RVA = "0x1182ED4", Offset = "0x1182ED4", VA = "0x1182ED4", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40000D9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool onShaking;

	[Token(Token = "0x40000DA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float shakeValue;

	[Token(Token = "0x40000DB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private float shakingv;

	[Token(Token = "0x6000085")]
	[Address(RVA = "0x1A9E09C", Offset = "0x1A9E09C", VA = "0x1A9E09C")]
	public void Shake(float val, float dur)
	{
	}

	[Token(Token = "0x6000086")]
	[Address(RVA = "0x1A9E0D4", Offset = "0x1A9E0D4", VA = "0x1A9E0D4")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x8D0E7C", Offset = "0x8D0E7C")]
	private IEnumerator Shaking(float val, float dur)
	{
		return null;
	}

	[Token(Token = "0x6000087")]
	[Address(RVA = "0x1A9E160", Offset = "0x1A9E160", VA = "0x1A9E160")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x6000088")]
	[Address(RVA = "0x1A9E214", Offset = "0x1A9E214", VA = "0x1A9E214")]
	public ShakeScreen()
	{
	}
}
[Token(Token = "0x200002C")]
[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x8CABB8", Offset = "0x8CABB8")]
public class SpawnCondition : MonoBehaviour
{
	[Token(Token = "0x200002D")]
	public enum EvAction
	{
		[Token(Token = "0x40000EE")]
		Spawn,
		[Token(Token = "0x40000EF")]
		Enable,
		[Token(Token = "0x40000F0")]
		Disable,
		[Token(Token = "0x40000F1")]
		Delete,
		[Token(Token = "0x40000F2")]
		None
	}

	[Token(Token = "0x200002E")]
	public enum ConditionsChecker
	{
		[Token(Token = "0x40000F4")]
		GreaterOrEqual,
		[Token(Token = "0x40000F5")]
		Greater,
		[Token(Token = "0x40000F6")]
		Equal,
		[Token(Token = "0x40000F7")]
		LessOrEqual,
		[Token(Token = "0x40000F8")]
		Less,
		[Token(Token = "0x40000F9")]
		NotEqual
	}

	[Token(Token = "0x40000E1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public int varId;

	[Token(Token = "0x40000E2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public int conditionValue;

	[Token(Token = "0x40000E3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject targetObject;

	[Token(Token = "0x40000E4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public EvAction eventAction;

	[Token(Token = "0x40000E5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public string sendMsgPass;

	[Token(Token = "0x40000E6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public ConditionsChecker condition;

	[Token(Token = "0x40000E7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public bool keepUpdate;

	[Token(Token = "0x40000E8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3D")]
	public bool checkFromStart;

	[Token(Token = "0x40000E9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3E")]
	public bool stopCheckingWhenPass;

	[Token(Token = "0x40000EA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3F")]
	public bool destroyWhenPass;

	[Token(Token = "0x40000EB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private bool stop;

	[Token(Token = "0x40000EC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public string note;

	[Token(Token = "0x600008F")]
	[Address(RVA = "0x1A9E22C", Offset = "0x1A9E22C", VA = "0x1A9E22C")]
	private void Start()
	{
	}

	[Token(Token = "0x6000090")]
	[Address(RVA = "0x1A9E4FC", Offset = "0x1A9E4FC", VA = "0x1A9E4FC")]
	private void Update()
	{
	}

	[Token(Token = "0x6000091")]
	[Address(RVA = "0x1A9E23C", Offset = "0x1A9E23C", VA = "0x1A9E23C")]
	public void CheckCondition()
	{
	}

	[Token(Token = "0x6000092")]
	[Address(RVA = "0x1A9E514", Offset = "0x1A9E514", VA = "0x1A9E514")]
	private void ConditionPass()
	{
	}

	[Token(Token = "0x6000093")]
	[Address(RVA = "0x1A9E8BC", Offset = "0x1A9E8BC", VA = "0x1A9E8BC")]
	public SpawnCondition()
	{
	}
}
[Token(Token = "0x200002F")]
[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x8CABF0", Offset = "0x8CABF0")]
public class SpawnConditionBool : MonoBehaviour
{
	[Token(Token = "0x2000030")]
	public enum EvAction
	{
		[Token(Token = "0x4000107")]
		Spawn,
		[Token(Token = "0x4000108")]
		Enable,
		[Token(Token = "0x4000109")]
		Disable,
		[Token(Token = "0x400010A")]
		Delete,
		[Token(Token = "0x400010B")]
		None
	}

	[Token(Token = "0x40000FA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public int boolId;

	[Token(Token = "0x40000FB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public bool condition;

	[Token(Token = "0x40000FC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject targetObject;

	[Token(Token = "0x40000FD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public EvAction eventAction;

	[Token(Token = "0x40000FE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public string sendMsgPass;

	[Token(Token = "0x40000FF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public bool keepUpdate;

	[Token(Token = "0x4000100")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x39")]
	public bool checkFromStart;

	[Token(Token = "0x4000101")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3A")]
	public bool stopCheckingWhenPass;

	[Token(Token = "0x4000102")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3B")]
	public bool destroyWhenPass;

	[Token(Token = "0x4000103")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public bool disableWhenFail;

	[Token(Token = "0x4000104")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3D")]
	private bool stop;

	[Token(Token = "0x4000105")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public string note;

	[Token(Token = "0x6000094")]
	[Address(RVA = "0x1A9E938", Offset = "0x1A9E938", VA = "0x1A9E938")]
	private void Start()
	{
	}

	[Token(Token = "0x6000095")]
	[Address(RVA = "0x1A9EA6C", Offset = "0x1A9EA6C", VA = "0x1A9EA6C")]
	private void Update()
	{
	}

	[Token(Token = "0x6000096")]
	[Address(RVA = "0x1A9E948", Offset = "0x1A9E948", VA = "0x1A9E948")]
	public void CheckCondition()
	{
	}

	[Token(Token = "0x6000097")]
	[Address(RVA = "0x1A9EA84", Offset = "0x1A9EA84", VA = "0x1A9EA84")]
	private void ConditionPass()
	{
	}

	[Token(Token = "0x6000098")]
	[Address(RVA = "0x1A9EE2C", Offset = "0x1A9EE2C", VA = "0x1A9EE2C")]
	public SpawnConditionBool()
	{
	}
}
[Token(Token = "0x2000031")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0x8CAC28", Offset = "0x8CAC28")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0x8CAC28", Offset = "0x8CAC28")]
public class AiEnemy : MonoBehaviour
{
	[Token(Token = "0x2000032")]
	public enum AIState
	{
		[Token(Token = "0x4000118")]
		Moving,
		[Token(Token = "0x4000119")]
		Pausing,
		[Token(Token = "0x400011A")]
		Idle
	}

	[Token(Token = "0x2000033")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8CACBC", Offset = "0x8CACBC")]
	private sealed class <Attack>d__15 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400011B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400011C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400011D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public AiEnemy <>4__this;

		[Token(Token = "0x400011E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Status <stat>5__2;

		[Token(Token = "0x1700000F")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60000A3")]
			[Address(RVA = "0x117ABE0", Offset = "0x117ABE0", VA = "0x117ABE0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000010")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60000A5")]
			[Address(RVA = "0x117AC28", Offset = "0x117AC28", VA = "0x117AC28", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60000A0")]
		[Address(RVA = "0x117A80C", Offset = "0x117A80C", VA = "0x117A80C")]
		[DebuggerHidden]
		public <Attack>d__15(int <>1__state)
		{
		}

		[Token(Token = "0x60000A1")]
		[Address(RVA = "0x117A838", Offset = "0x117A838", VA = "0x117A838", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60000A2")]
		[Address(RVA = "0x117A83C", Offset = "0x117A83C", VA = "0x117A83C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60000A4")]
		[Address(RVA = "0x117ABE8", Offset = "0x117ABE8", VA = "0x117ABE8", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x400010C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public AttackSetting attack;

	[Token(Token = "0x400010D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float approachDistance;

	[Token(Token = "0x400010E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public float detectRange;

	[Token(Token = "0x400010F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float lostSight;

	[Token(Token = "0x4000110")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public float speed;

	[Token(Token = "0x4000111")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Transform followTarget;

	[Token(Token = "0x4000112")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[HideInInspector]
	public bool cancelAttack;

	[Token(Token = "0x4000113")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x39")]
	private bool attacking;

	[Token(Token = "0x4000114")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public AIState followState;

	[Token(Token = "0x4000115")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private float distance;

	[Token(Token = "0x4000116")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	private int c;

	[Token(Token = "0x6000099")]
	[Address(RVA = "0x11CD88C", Offset = "0x11CD88C", VA = "0x11CD88C")]
	private void Start()
	{
	}

	[Token(Token = "0x600009A")]
	[Address(RVA = "0x11CD9C8", Offset = "0x11CD9C8", VA = "0x11CD9C8")]
	private Vector3 GetDestination()
	{
		return default(Vector3);
	}

	[Token(Token = "0x600009B")]
	[Address(RVA = "0x11CDA28", Offset = "0x11CDA28", VA = "0x11CDA28")]
	private void Update()
	{
	}

	[Token(Token = "0x600009C")]
	[Address(RVA = "0x11CE134", Offset = "0x11CE134", VA = "0x11CE134")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x8D0F2C", Offset = "0x8D0F2C")]
	private IEnumerator Attack()
	{
		return null;
	}

	[Token(Token = "0x600009D")]
	[Address(RVA = "0x11CE1AC", Offset = "0x11CE1AC", VA = "0x11CE1AC")]
	private void CheckDistance()
	{
	}

	[Token(Token = "0x600009E")]
	[Address(RVA = "0x11CDF50", Offset = "0x11CDF50", VA = "0x11CDF50")]
	private void FindClosestEnemy()
	{
	}

	[Token(Token = "0x600009F")]
	[Address(RVA = "0x11CE3EC", Offset = "0x11CE3EC", VA = "0x11CE3EC")]
	public AiEnemy()
	{
	}
}
[Token(Token = "0x2000034")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0x8CACCC", Offset = "0x8CACCC")]
public class BulletStatus : MonoBehaviour
{
	[Token(Token = "0x400011F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public int damage;

	[Token(Token = "0x4000120")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float duration;

	[Token(Token = "0x4000121")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject hitEffect;

	[Token(Token = "0x4000122")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public bool flinchTarget;

	[Token(Token = "0x4000123")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
	public bool penetrate;

	[Token(Token = "0x4000124")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public string shooterTag;

	[Token(Token = "0x4000125")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[HideInInspector]
	public int totalDamage;

	[Token(Token = "0x60000A6")]
	[Address(RVA = "0x11D2250", Offset = "0x11D2250", VA = "0x11D2250")]
	private void Start()
	{
	}

	[Token(Token = "0x60000A7")]
	[Address(RVA = "0x11D233C", Offset = "0x11D233C", VA = "0x11D233C")]
	public void Setting(int atk, string tag)
	{
	}

	[Token(Token = "0x60000A8")]
	[Address(RVA = "0x11D2378", Offset = "0x11D2378", VA = "0x11D2378")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x60000A9")]
	[Address(RVA = "0x11D2734", Offset = "0x11D2734", VA = "0x11D2734")]
	public BulletStatus()
	{
	}
}
[Token(Token = "0x2000035")]
public class ChangeMaterial : MonoBehaviour
{
	[Token(Token = "0x4000126")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Material swapMaterial;

	[Token(Token = "0x60000AA")]
	[Address(RVA = "0x11D279C", Offset = "0x11D279C", VA = "0x11D279C")]
	public void SwapMaterial()
	{
	}

	[Token(Token = "0x60000AB")]
	[Address(RVA = "0x11D27FC", Offset = "0x11D27FC", VA = "0x11D27FC")]
	public ChangeMaterial()
	{
	}
}
[Token(Token = "0x2000036")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0x8CAD2C", Offset = "0x8CAD2C")]
[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x8CAD2C", Offset = "0x8CAD2C")]
public class CharMotor : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x2000037")]
	public class CharacterMotorMovement
	{
		[Token(Token = "0x4000136")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float maxForwardSpeed;

		[Token(Token = "0x4000137")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public float maxSidewaysSpeed;

		[Token(Token = "0x4000138")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float maxBackwardsSpeed;

		[Token(Token = "0x4000139")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public AnimationCurve slopeSpeedMultiplier;

		[Token(Token = "0x400013A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float maxGroundAcceleration;

		[Token(Token = "0x400013B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float maxAirAcceleration;

		[Token(Token = "0x400013C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float gravity;

		[Token(Token = "0x400013D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float maxFallSpeed;

		[NonSerialized]
		[Token(Token = "0x400013E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public CollisionFlags collisionFlags;

		[NonSerialized]
		[Token(Token = "0x400013F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public Vector3 velocity;

		[NonSerialized]
		[Token(Token = "0x4000140")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Vector3 frameVelocity;

		[NonSerialized]
		[Token(Token = "0x4000141")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public Vector3 hitPoint;

		[NonSerialized]
		[Token(Token = "0x4000142")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Vector3 lastHitPoint;

		[Token(Token = "0x60000C4")]
		[Address(RVA = "0x117B85C", Offset = "0x117B85C", VA = "0x117B85C")]
		public CharacterMotorMovement()
		{
		}
	}

	[Token(Token = "0x2000038")]
	public enum MovementTransferOnJump
	{
		[Token(Token = "0x4000144")]
		None,
		[Token(Token = "0x4000145")]
		InitTransfer,
		[Token(Token = "0x4000146")]
		PermaTransfer,
		[Token(Token = "0x4000147")]
		PermaLocked
	}

	[Serializable]
	[Token(Token = "0x2000039")]
	public class CharacterMotorJumping
	{
		[Token(Token = "0x4000148")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public bool enabled;

		[Token(Token = "0x4000149")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public float baseHeight;

		[Token(Token = "0x400014A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float extraHeight;

		[Token(Token = "0x400014B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float perpAmount;

		[Token(Token = "0x400014C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float steepPerpAmount;

		[NonSerialized]
		[Token(Token = "0x400014D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public bool jumping;

		[NonSerialized]
		[Token(Token = "0x400014E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x25")]
		public bool holdingJumpButton;

		[NonSerialized]
		[Token(Token = "0x400014F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float lastStartTime;

		[NonSerialized]
		[Token(Token = "0x4000150")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float lastButtonDownTime;

		[NonSerialized]
		[Token(Token = "0x4000151")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Vector3 jumpDir;

		[Token(Token = "0x60000C5")]
		[Address(RVA = "0x117B804", Offset = "0x117B804", VA = "0x117B804")]
		public CharacterMotorJumping()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x200003A")]
	public class CharacterMotorMovingPlatform
	{
		[Token(Token = "0x4000152")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public bool enabled;

		[Token(Token = "0x4000153")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public MovementTransferOnJump movementTransfer;

		[NonSerialized]
		[Token(Token = "0x4000154")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform hitPlatform;

		[NonSerialized]
		[Token(Token = "0x4000155")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform activePlatform;

		[NonSerialized]
		[Token(Token = "0x4000156")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Vector3 activeLocalPoint;

		[NonSerialized]
		[Token(Token = "0x4000157")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public Vector3 activeGlobalPoint;

		[NonSerialized]
		[Token(Token = "0x4000158")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Quaternion activeLocalRotation;

		[NonSerialized]
		[Token(Token = "0x4000159")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Quaternion activeGlobalRotation;

		[NonSerialized]
		[Token(Token = "0x400015A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Matrix4x4 lastMatrix;

		[NonSerialized]
		[Token(Token = "0x400015B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public Vector3 platformVelocity;

		[NonSerialized]
		[Token(Token = "0x400015C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		public bool newPlatform;

		[Token(Token = "0x60000C6")]
		[Address(RVA = "0x117BA54", Offset = "0x117BA54", VA = "0x117BA54")]
		public CharacterMotorMovingPlatform()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x200003B")]
	public class CharacterMotorSliding
	{
		[Token(Token = "0x400015D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public bool enabled;

		[Token(Token = "0x400015E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public float slidingSpeed;

		[Token(Token = "0x400015F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float sidewaysControl;

		[Token(Token = "0x4000160")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float speedControl;

		[Token(Token = "0x60000C7")]
		[Address(RVA = "0x117BA64", Offset = "0x117BA64", VA = "0x117BA64")]
		public CharacterMotorSliding()
		{
		}
	}

	[Token(Token = "0x200003C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8CADB0", Offset = "0x8CADB0")]
	private sealed class <SubtractNewPlatformVelocity>d__27 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000161")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000162")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000163")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public CharMotor <>4__this;

		[Token(Token = "0x4000164")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Transform <platform>5__2;

		[Token(Token = "0x17000011")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60000CB")]
			[Address(RVA = "0x117B7B4", Offset = "0x117B7B4", VA = "0x117B7B4", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000012")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60000CD")]
			[Address(RVA = "0x117B7FC", Offset = "0x117B7FC", VA = "0x117B7FC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60000C8")]
		[Address(RVA = "0x117B5AC", Offset = "0x117B5AC", VA = "0x117B5AC")]
		[DebuggerHidden]
		public <SubtractNewPlatformVelocity>d__27(int <>1__state)
		{
		}

		[Token(Token = "0x60000C9")]
		[Address(RVA = "0x117B5D8", Offset = "0x117B5D8", VA = "0x117B5D8", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60000CA")]
		[Address(RVA = "0x117B5DC", Offset = "0x117B5DC", VA = "0x117B5DC", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60000CC")]
		[Address(RVA = "0x117B7BC", Offset = "0x117B7BC", VA = "0x117B7BC", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000127")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool canControl;

	[Token(Token = "0x4000128")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
	public bool useFixedUpdate;

	[Token(Token = "0x4000129")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
	public bool freezeGravity;

	[Token(Token = "0x400012A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float limitVelocityY;

	[NonSerialized]
	[Token(Token = "0x400012B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Vector3 inputMoveDirection;

	[NonSerialized]
	[Token(Token = "0x400012C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public bool inputJump;

	[Token(Token = "0x400012D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public CharacterMotorMovement movement;

	[Token(Token = "0x400012E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public CharacterMotorJumping jumping;

	[Token(Token = "0x400012F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public CharacterMotorMovingPlatform movingPlatform;

	[Token(Token = "0x4000130")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public CharacterMotorSliding sliding;

	[NonSerialized]
	[Token(Token = "0x4000131")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public bool grounded;

	[NonSerialized]
	[Token(Token = "0x4000132")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	public Vector3 groundNormal;

	[Token(Token = "0x4000133")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private Vector3 lastGroundNormal;

	[Token(Token = "0x4000134")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private Transform tr;

	[Token(Token = "0x4000135")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private CharacterController controller;

	[Token(Token = "0x60000AC")]
	[Address(RVA = "0x11D2804", Offset = "0x11D2804", VA = "0x11D2804")]
	private void Awake()
	{
	}

	[Token(Token = "0x60000AD")]
	[Address(RVA = "0x11D287C", Offset = "0x11D287C", VA = "0x11D287C")]
	private void UpdateFunction()
	{
	}

	[Token(Token = "0x60000AE")]
	[Address(RVA = "0x11D385C", Offset = "0x11D385C", VA = "0x11D385C")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x60000AF")]
	[Address(RVA = "0x11D3A18", Offset = "0x11D3A18", VA = "0x11D3A18")]
	private void Update()
	{
	}

	[Token(Token = "0x60000B0")]
	[Address(RVA = "0x11D30A4", Offset = "0x11D30A4", VA = "0x11D30A4")]
	private Vector3 ApplyInputVelocityChange(Vector3 velocity)
	{
		return default(Vector3);
	}

	[Token(Token = "0x60000B1")]
	[Address(RVA = "0x11D3330", Offset = "0x11D3330", VA = "0x11D3330")]
	private Vector3 ApplyGravityAndJumping(Vector3 velocity)
	{
		return default(Vector3);
	}

	[Token(Token = "0x60000B2")]
	[Address(RVA = "0x11D3C58", Offset = "0x11D3C58", VA = "0x11D3C58")]
	private void OnControllerColliderHit(ControllerColliderHit hit)
	{
	}

	[Token(Token = "0x60000B3")]
	[Address(RVA = "0x11D37E4", Offset = "0x11D37E4", VA = "0x11D37E4")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x8D0FDC", Offset = "0x8D0FDC")]
	private IEnumerator SubtractNewPlatformVelocity()
	{
		return null;
	}

	[Token(Token = "0x60000B4")]
	[Address(RVA = "0x11D3724", Offset = "0x11D3724", VA = "0x11D3724")]
	private bool MoveWithPlatform()
	{
		return default(bool);
	}

	[Token(Token = "0x60000B5")]
	[Address(RVA = "0x11D3A74", Offset = "0x11D3A74", VA = "0x11D3A74")]
	private Vector3 GetDesiredHorizontalVelocity()
	{
		return default(Vector3);
	}

	[Token(Token = "0x60000B6")]
	[Address(RVA = "0x11D3B38", Offset = "0x11D3B38", VA = "0x11D3B38")]
	private Vector3 AdjustGroundVelocityToNormal(Vector3 hVelocity, Vector3 groundNormal)
	{
		return default(Vector3);
	}

	[Token(Token = "0x60000B7")]
	[Address(RVA = "0x11D37C8", Offset = "0x11D37C8", VA = "0x11D37C8")]
	private bool IsGroundedTest()
	{
		return default(bool);
	}

	[Token(Token = "0x60000B8")]
	[Address(RVA = "0x11D3BF4", Offset = "0x11D3BF4", VA = "0x11D3BF4")]
	private float GetMaxAcceleration(bool grounded)
	{
		return default(float);
	}

	[Token(Token = "0x60000B9")]
	[Address(RVA = "0x11D3C20", Offset = "0x11D3C20", VA = "0x11D3C20")]
	private float CalculateJumpVerticalSpeed(float targetJumpHeight)
	{
		return default(float);
	}

	[Token(Token = "0x60000BA")]
	[Address(RVA = "0x11D3EE0", Offset = "0x11D3EE0", VA = "0x11D3EE0")]
	private bool IsJumping()
	{
		return default(bool);
	}

	[Token(Token = "0x60000BB")]
	[Address(RVA = "0x11D3EFC", Offset = "0x11D3EFC", VA = "0x11D3EFC")]
	private bool IsSliding()
	{
		return default(bool);
	}

	[Token(Token = "0x60000BC")]
	[Address(RVA = "0x11D3F2C", Offset = "0x11D3F2C", VA = "0x11D3F2C")]
	private bool IsTouchingCeiling()
	{
		return default(bool);
	}

	[Token(Token = "0x60000BD")]
	[Address(RVA = "0x11D3F4C", Offset = "0x11D3F4C", VA = "0x11D3F4C")]
	private bool IsGrounded()
	{
		return default(bool);
	}

	[Token(Token = "0x60000BE")]
	[Address(RVA = "0x11D3A28", Offset = "0x11D3A28", VA = "0x11D3A28")]
	private bool TooSteep()
	{
		return default(bool);
	}

	[Token(Token = "0x60000BF")]
	[Address(RVA = "0x11D3F54", Offset = "0x11D3F54", VA = "0x11D3F54")]
	private Vector3 GetDirection()
	{
		return default(Vector3);
	}

	[Token(Token = "0x60000C0")]
	[Address(RVA = "0x11D3F60", Offset = "0x11D3F60", VA = "0x11D3F60")]
	private void SetControllable(bool controllable)
	{
	}

	[Token(Token = "0x60000C1")]
	[Address(RVA = "0x11D3DF8", Offset = "0x11D3DF8", VA = "0x11D3DF8")]
	private float MaxSpeedInDirection(Vector3 desiredMovementDirection)
	{
		return default(float);
	}

	[Token(Token = "0x60000C2")]
	[Address(RVA = "0x11D3F6C", Offset = "0x11D3F6C", VA = "0x11D3F6C")]
	private void SetVelocity(Vector3 velocity)
	{
	}

	[Token(Token = "0x60000C3")]
	[Address(RVA = "0x11D4008", Offset = "0x11D4008", VA = "0x11D4008")]
	public CharMotor()
	{
	}
}
[Token(Token = "0x200003D")]
public class DestroyObject : MonoBehaviour
{
	[Token(Token = "0x4000165")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float DestoryTime;

	[Token(Token = "0x4000166")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float duration;

	[Token(Token = "0x4000167")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float fadeoutDuring;

	[Token(Token = "0x4000168")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public bool selfDestroy;

	[Token(Token = "0x4000169")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private Transform[] _childTransform;

	[Token(Token = "0x60000CE")]
	[Address(RVA = "0x11DF57C", Offset = "0x11DF57C", VA = "0x11DF57C")]
	private void Start()
	{
	}

	[Token(Token = "0x60000CF")]
	[Address(RVA = "0x11DF634", Offset = "0x11DF634", VA = "0x11DF634")]
	public void DestroyObj()
	{
	}

	[Token(Token = "0x60000D0")]
	[Address(RVA = "0x11DF6BC", Offset = "0x11DF6BC", VA = "0x11DF6BC")]
	public void DoFadeOut()
	{
	}

	[Token(Token = "0x60000D1")]
	[Address(RVA = "0x11DF804", Offset = "0x11DF804", VA = "0x11DF804")]
	public DestroyObject()
	{
	}
}
[Token(Token = "0x200003E")]
public class HealingItem : MonoBehaviour
{
	[Token(Token = "0x400016A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public int amount;

	[Token(Token = "0x60000D2")]
	[Address(RVA = "0x1A95E94", Offset = "0x1A95E94", VA = "0x1A95E94")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x60000D3")]
	[Address(RVA = "0x1A95FD8", Offset = "0x1A95FD8", VA = "0x1A95FD8")]
	public HealingItem()
	{
	}
}
[Token(Token = "0x200003F")]
public class HealthBar : MonoBehaviour
{
	[Token(Token = "0x400016B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Image hpBar;

	[Token(Token = "0x400016C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject player;

	[Token(Token = "0x60000D4")]
	[Address(RVA = "0x1A95FE8", Offset = "0x1A95FE8", VA = "0x1A95FE8")]
	private void Start()
	{
	}

	[Token(Token = "0x60000D5")]
	[Address(RVA = "0x1A96090", Offset = "0x1A96090", VA = "0x1A96090")]
	private void Update()
	{
	}

	[Token(Token = "0x60000D6")]
	[Address(RVA = "0x1A96240", Offset = "0x1A96240", VA = "0x1A96240")]
	public HealthBar()
	{
	}
}
[Token(Token = "0x2000040")]
public class MoveObject : MonoBehaviour
{
	[Token(Token = "0x400016D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float speed;

	[Token(Token = "0x400016E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public Vector3 relativeDirection;

	[Token(Token = "0x400016F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public bool isNotRandomSpeed;

	[Token(Token = "0x60000D7")]
	[Address(RVA = "0x1A9B254", Offset = "0x1A9B254", VA = "0x1A9B254")]
	private void Start()
	{
	}

	[Token(Token = "0x60000D8")]
	[Address(RVA = "0x1A9B294", Offset = "0x1A9B294", VA = "0x1A9B294")]
	private void Update()
	{
	}

	[Token(Token = "0x60000D9")]
	[Address(RVA = "0x1A9B35C", Offset = "0x1A9B35C", VA = "0x1A9B35C")]
	public MoveObject()
	{
	}
}
[Token(Token = "0x2000041")]
public class OrbitCamera : MonoBehaviour
{
	[Token(Token = "0x4000170")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Transform target;

	[Token(Token = "0x4000171")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float distance;

	[Token(Token = "0x4000172")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public float xSpeed;

	[Token(Token = "0x4000173")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float ySpeed;

	[Token(Token = "0x4000174")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public float yMinLimit;

	[Token(Token = "0x4000175")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public float yMaxLimit;

	[Token(Token = "0x4000176")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public float distanceMin;

	[Token(Token = "0x4000177")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public float distanceMax;

	[Token(Token = "0x4000178")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	private float x;

	[Token(Token = "0x4000179")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private float y;

	[Token(Token = "0x400017A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	public bool freeze;

	[Token(Token = "0x60000DA")]
	[Address(RVA = "0x1A9BFC0", Offset = "0x1A9BFC0", VA = "0x1A9BFC0")]
	private void Start()
	{
	}

	[Token(Token = "0x60000DB")]
	[Address(RVA = "0x1A9C000", Offset = "0x1A9C000", VA = "0x1A9C000")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x60000DC")]
	[Address(RVA = "0x1A9C470", Offset = "0x1A9C470", VA = "0x1A9C470")]
	public void SetNewTarget(Transform t)
	{
	}

	[Token(Token = "0x60000DD")]
	[Address(RVA = "0x1A9C440", Offset = "0x1A9C440", VA = "0x1A9C440")]
	public static float ClampAngle(float angle, float min, float max)
	{
		return default(float);
	}

	[Token(Token = "0x60000DE")]
	[Address(RVA = "0x1A9C478", Offset = "0x1A9C478", VA = "0x1A9C478")]
	public void FreezeCamera()
	{
	}

	[Token(Token = "0x60000DF")]
	[Address(RVA = "0x1A9C484", Offset = "0x1A9C484", VA = "0x1A9C484")]
	public void UnFreezeCamera()
	{
	}

	[Token(Token = "0x60000E0")]
	[Address(RVA = "0x1A9C48C", Offset = "0x1A9C48C", VA = "0x1A9C48C")]
	public OrbitCamera()
	{
	}
}
[Token(Token = "0x2000042")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0x8CADC0", Offset = "0x8CADC0")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0x8CADC0", Offset = "0x8CADC0")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0x8CADC0", Offset = "0x8CADC0")]
public class PlayerController : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x2000043")]
	public class LockOn
	{
		[Token(Token = "0x4000187")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public bool enable;

		[Token(Token = "0x4000188")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public float radius;

		[Token(Token = "0x4000189")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float lockOnRange;

		[Token(Token = "0x400018A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[HideInInspector]
		public Transform lockTarget;

		[Token(Token = "0x400018B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[HideInInspector]
		public GameObject target;

		[Token(Token = "0x60000E7")]
		[Address(RVA = "0x1182C5C", Offset = "0x1182C5C", VA = "0x1182C5C")]
		public LockOn()
		{
		}
	}

	[Token(Token = "0x2000044")]
	public enum WhileAtk
	{
		[Token(Token = "0x400018D")]
		MeleeFwd,
		[Token(Token = "0x400018E")]
		Immobile
	}

	[Token(Token = "0x2000045")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8CAE88", Offset = "0x8CAE88")]
	private sealed class <Attacking>d__16 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400018F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000190")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000191")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public PlayerController <>4__this;

		[Token(Token = "0x4000192")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Status <stat>5__2;

		[Token(Token = "0x17000013")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60000EB")]
			[Address(RVA = "0x1182AC0", Offset = "0x1182AC0", VA = "0x1182AC0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000014")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60000ED")]
			[Address(RVA = "0x1182B08", Offset = "0x1182B08", VA = "0x1182B08", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60000E8")]
		[Address(RVA = "0x1182608", Offset = "0x1182608", VA = "0x1182608")]
		[DebuggerHidden]
		public <Attacking>d__16(int <>1__state)
		{
		}

		[Token(Token = "0x60000E9")]
		[Address(RVA = "0x1182634", Offset = "0x1182634", VA = "0x1182634", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60000EA")]
		[Address(RVA = "0x1182638", Offset = "0x1182638", VA = "0x1182638", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60000EC")]
		[Address(RVA = "0x1182AC8", Offset = "0x1182AC8", VA = "0x1182AC8", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000046")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8CAE98", Offset = "0x8CAE98")]
	private sealed class <MeleeDash>d__17 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000193")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000194")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000195")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public PlayerController <>4__this;

		[Token(Token = "0x17000015")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60000F1")]
			[Address(RVA = "0x1182C0C", Offset = "0x1182C0C", VA = "0x1182C0C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000016")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60000F3")]
			[Address(RVA = "0x1182C54", Offset = "0x1182C54", VA = "0x1182C54", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60000EE")]
		[Address(RVA = "0x1182B10", Offset = "0x1182B10", VA = "0x1182B10")]
		[DebuggerHidden]
		public <MeleeDash>d__17(int <>1__state)
		{
		}

		[Token(Token = "0x60000EF")]
		[Address(RVA = "0x1182B3C", Offset = "0x1182B3C", VA = "0x1182B3C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60000F0")]
		[Address(RVA = "0x1182B40", Offset = "0x1182B40", VA = "0x1182B40", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60000F2")]
		[Address(RVA = "0x1182C14", Offset = "0x1182C14", VA = "0x1182C14", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x400017B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private CharMotor motor;

	[Token(Token = "0x400017C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private float moveHorizontal;

	[Token(Token = "0x400017D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	private float moveVertical;

	[Token(Token = "0x400017E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public LockOn autoLockTarget;

	[Token(Token = "0x400017F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public AttackSetting attack;

	[Token(Token = "0x4000180")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public WhileAtk whileAttack;

	[Token(Token = "0x4000181")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	private float nextFire;

	[Token(Token = "0x4000182")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private bool meleefwd;

	[Token(Token = "0x4000183")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x41")]
	public bool cannotAttack;

	[Token(Token = "0x4000184")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x42")]
	public bool combatMode;

	[Token(Token = "0x4000185")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	private int c;

	[Token(Token = "0x4000186")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[HideInInspector]
	public bool onAttack;

	[Token(Token = "0x60000E1")]
	[Address(RVA = "0x1A9C9C8", Offset = "0x1A9C9C8", VA = "0x1A9C9C8")]
	private void Awake()
	{
	}

	[Token(Token = "0x60000E2")]
	[Address(RVA = "0x1A9CBCC", Offset = "0x1A9CBCC", VA = "0x1A9CBCC")]
	private void Update()
	{
	}

	[Token(Token = "0x60000E3")]
	[Address(RVA = "0x1A9D56C", Offset = "0x1A9D56C", VA = "0x1A9D56C")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x8D108C", Offset = "0x8D108C")]
	private IEnumerator Attacking()
	{
		return null;
	}

	[Token(Token = "0x60000E4")]
	[Address(RVA = "0x1A9D5E4", Offset = "0x1A9D5E4", VA = "0x1A9D5E4")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x8D10EC", Offset = "0x8D10EC")]
	private IEnumerator MeleeDash()
	{
		return null;
	}

	[Token(Token = "0x60000E5")]
	[Address(RVA = "0x1A9D27C", Offset = "0x1A9D27C", VA = "0x1A9D27C")]
	public void LockOnEnemy()
	{
	}

	[Token(Token = "0x60000E6")]
	[Address(RVA = "0x1A9D65C", Offset = "0x1A9D65C", VA = "0x1A9D65C")]
	public PlayerController()
	{
	}
}
[Token(Token = "0x2000047")]
public class ReloadScene : MonoBehaviour
{
	[Token(Token = "0x2000048")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8CAEA8", Offset = "0x8CAEA8")]
	private sealed class <DelayLoad>d__2 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000197")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000198")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000199")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ReloadScene <>4__this;

		[Token(Token = "0x17000017")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60000FA")]
			[Address(RVA = "0x1182D6C", Offset = "0x1182D6C", VA = "0x1182D6C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000018")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60000FC")]
			[Address(RVA = "0x1182DB4", Offset = "0x1182DB4", VA = "0x1182DB4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60000F7")]
		[Address(RVA = "0x1182C78", Offset = "0x1182C78", VA = "0x1182C78")]
		[DebuggerHidden]
		public <DelayLoad>d__2(int <>1__state)
		{
		}

		[Token(Token = "0x60000F8")]
		[Address(RVA = "0x1182CA4", Offset = "0x1182CA4", VA = "0x1182CA4", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60000F9")]
		[Address(RVA = "0x1182CA8", Offset = "0x1182CA8", VA = "0x1182CA8", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60000FB")]
		[Address(RVA = "0x1182D74", Offset = "0x1182D74", VA = "0x1182D74", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000196")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float delay;

	[Token(Token = "0x60000F4")]
	[Address(RVA = "0x1A9D664", Offset = "0x1A9D664", VA = "0x1A9D664")]
	private void Start()
	{
	}

	[Token(Token = "0x60000F5")]
	[Address(RVA = "0x1A9D690", Offset = "0x1A9D690", VA = "0x1A9D690")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x8D11EC", Offset = "0x8D11EC")]
	private IEnumerator DelayLoad()
	{
		return null;
	}

	[Token(Token = "0x60000F6")]
	[Address(RVA = "0x1A9D708", Offset = "0x1A9D708", VA = "0x1A9D708")]
	public ReloadScene()
	{
	}
}
[Token(Token = "0x2000049")]
public class RotateObject : MonoBehaviour
{
	[Token(Token = "0x400019A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float rotateX;

	[Token(Token = "0x400019B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float rotateY;

	[Token(Token = "0x400019C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float rotateZ;

	[Token(Token = "0x60000FD")]
	[Address(RVA = "0x1A9D718", Offset = "0x1A9D718", VA = "0x1A9D718")]
	private void Update()
	{
	}

	[Token(Token = "0x60000FE")]
	[Address(RVA = "0x1A9D7A4", Offset = "0x1A9D7A4", VA = "0x1A9D7A4")]
	public RotateObject()
	{
	}
}
[Token(Token = "0x200004A")]
public class SetParent : MonoBehaviour
{
	[Token(Token = "0x400019D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Transform target;

	[Token(Token = "0x60000FF")]
	[Address(RVA = "0x1A9E060", Offset = "0x1A9E060", VA = "0x1A9E060")]
	private void Start()
	{
	}

	[Token(Token = "0x6000100")]
	[Address(RVA = "0x1A9E094", Offset = "0x1A9E094", VA = "0x1A9E094")]
	public SetParent()
	{
	}
}
[Token(Token = "0x200004B")]
public class Status : MonoBehaviour
{
	[Token(Token = "0x200004C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8CAEB8", Offset = "0x8CAEB8")]
	private sealed class <KnockBack>d__14 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40001A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40001A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40001AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Status <>4__this;

		[Token(Token = "0x17000019")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600010C")]
			[Address(RVA = "0x1183018", Offset = "0x1183018", VA = "0x1183018", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700001A")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600010E")]
			[Address(RVA = "0x1183060", Offset = "0x1183060", VA = "0x1183060", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000109")]
		[Address(RVA = "0x1182F1C", Offset = "0x1182F1C", VA = "0x1182F1C")]
		[DebuggerHidden]
		public <KnockBack>d__14(int <>1__state)
		{
		}

		[Token(Token = "0x600010A")]
		[Address(RVA = "0x1182F48", Offset = "0x1182F48", VA = "0x1182F48", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600010B")]
		[Address(RVA = "0x1182F4C", Offset = "0x1182F4C", VA = "0x1182F4C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600010D")]
		[Address(RVA = "0x1183020", Offset = "0x1183020", VA = "0x1183020", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x400019E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Animator animator;

	[Token(Token = "0x400019F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public int attack;

	[Token(Token = "0x40001A0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public int defense;

	[Token(Token = "0x40001A1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public int maxHealth;

	[Token(Token = "0x40001A2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public int health;

	[Token(Token = "0x40001A3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public int freezeGlobalBoolId;

	[Token(Token = "0x40001A4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public GameObject deadPrefab;

	[Token(Token = "0x40001A5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[HideInInspector]
	public bool dead;

	[Token(Token = "0x40001A6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x41")]
	[HideInInspector]
	public bool freeze;

	[Token(Token = "0x40001A7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x42")]
	[HideInInspector]
	public bool flinch;

	[Token(Token = "0x6000101")]
	[Address(RVA = "0x1E24C44", Offset = "0x1E24C44", VA = "0x1E24C44")]
	private void Start()
	{
	}

	[Token(Token = "0x6000102")]
	[Address(RVA = "0x1E24D44", Offset = "0x1E24D44", VA = "0x1E24D44")]
	public void Healing(int amount)
	{
	}

	[Token(Token = "0x6000103")]
	[Address(RVA = "0x1E24D5C", Offset = "0x1E24D5C", VA = "0x1E24D5C")]
	public void OnDamage(int dmg)
	{
	}

	[Token(Token = "0x6000104")]
	[Address(RVA = "0x1E24F4C", Offset = "0x1E24F4C", VA = "0x1E24F4C")]
	public void Flinch()
	{
	}

	[Token(Token = "0x6000105")]
	[Address(RVA = "0x1E25010", Offset = "0x1E25010", VA = "0x1E25010")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x8D129C", Offset = "0x8D129C")]
	private IEnumerator KnockBack()
	{
		return null;
	}

	[Token(Token = "0x6000106")]
	[Address(RVA = "0x1E24D84", Offset = "0x1E24D84", VA = "0x1E24D84")]
	public void Death()
	{
	}

	[Token(Token = "0x6000107")]
	[Address(RVA = "0x1E25088", Offset = "0x1E25088", VA = "0x1E25088")]
	public void DamagePercent(int amount)
	{
	}

	[Token(Token = "0x6000108")]
	[Address(RVA = "0x1E250A4", Offset = "0x1E250A4", VA = "0x1E250A4")]
	public Status()
	{
	}
}
[Serializable]
[Token(Token = "0x200004D")]
public class AttackSetting
{
	[Token(Token = "0x40001AB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public GameObject attackPrefab;

	[Token(Token = "0x40001AC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Transform attackPoint;

	[Token(Token = "0x40001AD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float preAttackDelay;

	[Token(Token = "0x40001AE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public float attackDelay;

	[Token(Token = "0x40001AF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float lastComboDelay;

	[Token(Token = "0x40001B0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public int maxCombo;

	[Token(Token = "0x600010F")]
	[Address(RVA = "0x11CEBC0", Offset = "0x11CEBC0", VA = "0x11CEBC0")]
	public AttackSetting()
	{
	}
}
[Token(Token = "0x200004E")]
public class WeaponTrail : MonoBehaviour
{
	[Token(Token = "0x6000110")]
	[Address(RVA = "0x1179BC0", Offset = "0x1179BC0", VA = "0x1179BC0")]
	private void Update()
	{
	}

	[Token(Token = "0x6000111")]
	[Address(RVA = "0x1179C64", Offset = "0x1179C64", VA = "0x1179C64")]
	public WeaponTrail()
	{
	}
}
[Token(Token = "0x200004F")]
public static class FEasing
{
	[Token(Token = "0x2000050")]
	public enum EFease
	{
		[Token(Token = "0x40001B2")]
		EaseInCubic,
		[Token(Token = "0x40001B3")]
		EaseOutCubic,
		[Token(Token = "0x40001B4")]
		EaseInOutCubic,
		[Token(Token = "0x40001B5")]
		EaseInOutElastic,
		[Token(Token = "0x40001B6")]
		EaseInElastic,
		[Token(Token = "0x40001B7")]
		EaseOutElastic,
		[Token(Token = "0x40001B8")]
		EaseInExpo,
		[Token(Token = "0x40001B9")]
		EaseOutExpo,
		[Token(Token = "0x40001BA")]
		EaseInOutExpo,
		[Token(Token = "0x40001BB")]
		Linear
	}

	[Token(Token = "0x2000051")]
	public delegate float Function(float s, float e, float v, float extraParameter = 1f);

	[Token(Token = "0x6000112")]
	[Address(RVA = "0x1E85B9C", Offset = "0x1E85B9C", VA = "0x1E85B9C")]
	public static float EaseInCubic(float start, float end, float value, float ignore = 1f)
	{
		return default(float);
	}

	[Token(Token = "0x6000113")]
	[Address(RVA = "0x1E85BB4", Offset = "0x1E85BB4", VA = "0x1E85BB4")]
	public static float EaseOutCubic(float start, float end, float value, float ignore = 1f)
	{
		return default(float);
	}

	[Token(Token = "0x6000114")]
	[Address(RVA = "0x1E85BDC", Offset = "0x1E85BDC", VA = "0x1E85BDC")]
	public static float EaseInOutCubic(float start, float end, float value, float ignore = 1f)
	{
		return default(float);
	}

	[Token(Token = "0x6000115")]
	[Address(RVA = "0x1E85C34", Offset = "0x1E85C34", VA = "0x1E85C34")]
	public static float EaseOutElastic(float start, float end, float value, float rangeMul = 1f)
	{
		return default(float);
	}

	[Token(Token = "0x6000116")]
	[Address(RVA = "0x1E85CDC", Offset = "0x1E85CDC", VA = "0x1E85CDC")]
	public static float EaseInElastic(float start, float end, float value, float rangeMul = 1f)
	{
		return default(float);
	}

	[Token(Token = "0x6000117")]
	[Address(RVA = "0x1E85D84", Offset = "0x1E85D84", VA = "0x1E85D84")]
	public static float EaseInOutElastic(float start, float end, float value, float rangeMul = 1f)
	{
		return default(float);
	}

	[Token(Token = "0x6000118")]
	[Address(RVA = "0x1E85E88", Offset = "0x1E85E88", VA = "0x1E85E88")]
	public static float EaseInExpo(float start, float end, float value, float ignore = 1f)
	{
		return default(float);
	}

	[Token(Token = "0x6000119")]
	[Address(RVA = "0x1E85EC4", Offset = "0x1E85EC4", VA = "0x1E85EC4")]
	public static float EaseOutExpo(float start, float end, float value, float ignore = 1f)
	{
		return default(float);
	}

	[Token(Token = "0x600011A")]
	[Address(RVA = "0x1E85F00", Offset = "0x1E85F00", VA = "0x1E85F00")]
	public static float EaseInOutExpo(float start, float end, float value, float ignore = 1f)
	{
		return default(float);
	}

	[Token(Token = "0x600011B")]
	[Address(RVA = "0x1E85F74", Offset = "0x1E85F74", VA = "0x1E85F74")]
	public static float Linear(float start, float end, float value, float ignore = 1f)
	{
		return default(float);
	}

	[Token(Token = "0x600011C")]
	[Address(RVA = "0x1E85F7C", Offset = "0x1E85F7C", VA = "0x1E85F7C")]
	public static Function GetEasingFunction(EFease easingFunction)
	{
		return null;
	}
}
[Token(Token = "0x2000052")]
public class FHierarchyIcons
{
	[Token(Token = "0x6000121")]
	[Address(RVA = "0x1E888B0", Offset = "0x1E888B0", VA = "0x1E888B0")]
	static FHierarchyIcons()
	{
	}

	[Token(Token = "0x6000122")]
	[Address(RVA = "0x1E888B4", Offset = "0x1E888B4", VA = "0x1E888B4")]
	private static void EvaluateIcons(int instanceId, Rect selectionRect)
	{
	}

	[Token(Token = "0x6000123")]
	[Address(RVA = "0x1E888B8", Offset = "0x1E888B8", VA = "0x1E888B8")]
	private static void DrawIcon(string texName, Rect rect)
	{
	}

	[Token(Token = "0x6000124")]
	[Address(RVA = "0x1E888BC", Offset = "0x1E888BC", VA = "0x1E888BC")]
	private static Texture2D GetTex(string name)
	{
		return null;
	}

	[Token(Token = "0x6000125")]
	[Address(RVA = "0x1E888C4", Offset = "0x1E888C4", VA = "0x1E888C4")]
	public FHierarchyIcons()
	{
	}
}
[Token(Token = "0x2000053")]
public interface IFHierarchyIcon
{
	[Token(Token = "0x1700001B")]
	string EditorIconPath
	{
		[Token(Token = "0x6000126")]
		get;
	}
}
[Token(Token = "0x2000054")]
public class FPD_DrawTextureAttribute : PropertyAttribute
{
	[Token(Token = "0x40001BC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public string path;

	[Token(Token = "0x40001BD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float width;

	[Token(Token = "0x40001BE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public float height;

	[Token(Token = "0x40001BF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float labelWidth;

	[Token(Token = "0x40001C0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public float fieldWidth;

	[Token(Token = "0x6000127")]
	[Address(RVA = "0x1A8F108", Offset = "0x1A8F108", VA = "0x1A8F108")]
	public FPD_DrawTextureAttribute(string path, float width, float height, float labelWidth = 0f, float fieldWidth = 0f)
	{
	}
}
[Token(Token = "0x2000055")]
public class FPD_FixedCurveWindowAttribute : PropertyAttribute
{
	[Token(Token = "0x40001C1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public float StartTime;

	[Token(Token = "0x40001C2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float EndTime;

	[Token(Token = "0x40001C3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float StartValue;

	[Token(Token = "0x40001C4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float EndValue;

	[Token(Token = "0x40001C5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public Color Color;

	[Token(Token = "0x6000128")]
	[Address(RVA = "0x1A8F168", Offset = "0x1A8F168", VA = "0x1A8F168")]
	public FPD_FixedCurveWindowAttribute(float startTime = 0f, float startValue = 0f, float endTime = 1f, float endValue = 1f, float r = 0f, float g = 1f, float b = 1f, float a = 1f)
	{
	}
}
[Token(Token = "0x2000056")]
public class FPD_FoldFrameAttribute : PropertyAttribute
{
	[Token(Token = "0x40001C6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public string FrameTitle;

	[Token(Token = "0x40001C7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public string[] VariablesToStore;

	[Token(Token = "0x40001C8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public bool Folded;

	[Token(Token = "0x6000129")]
	[Address(RVA = "0x1A8F204", Offset = "0x1A8F204", VA = "0x1A8F204")]
	public FPD_FoldFrameAttribute(string title, string[] variablesToStore, bool defaultUnfold = false)
	{
	}
}
[Token(Token = "0x2000057")]
public class FPD_FoldableAttribute : PropertyAttribute
{
	[Token(Token = "0x40001C9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public string FoldVariable;

	[Token(Token = "0x600012A")]
	[Address(RVA = "0x1A8F264", Offset = "0x1A8F264", VA = "0x1A8F264")]
	public FPD_FoldableAttribute(string boolFoldVariable)
	{
	}
}
[Token(Token = "0x2000058")]
public class FPD_HeaderAttribute : PropertyAttribute
{
	[Token(Token = "0x40001CA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public string HeaderText;

	[Token(Token = "0x40001CB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float UpperPadding;

	[Token(Token = "0x40001CC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public float BottomPadding;

	[Token(Token = "0x40001CD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float Height;

	[Token(Token = "0x600012B")]
	[Address(RVA = "0x1A8F298", Offset = "0x1A8F298", VA = "0x1A8F298")]
	public FPD_HeaderAttribute(string headerText, float upperPadding = 3f, float bottomPadding = 3f, int addHeight = 2)
	{
	}
}
[Token(Token = "0x2000059")]
[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x8CAEC8", Offset = "0x8CAEC8")]
public class FPD_HideOnBoolAttribute : PropertyAttribute
{
	[Token(Token = "0x40001CE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public string BoolVarName;

	[Token(Token = "0x40001CF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public bool HideInInspector;

	[Token(Token = "0x600012C")]
	[Address(RVA = "0x1A8F2F8", Offset = "0x1A8F2F8", VA = "0x1A8F2F8")]
	public FPD_HideOnBoolAttribute(string boolVariableName)
	{
	}

	[Token(Token = "0x600012D")]
	[Address(RVA = "0x1A8F37C", Offset = "0x1A8F37C", VA = "0x1A8F37C")]
	public FPD_HideOnBoolAttribute(string conditionalSourceField, bool hideInInspector)
	{
	}
}
[Token(Token = "0x200005A")]
public class FPD_LayersAttribute : PropertyAttribute
{
	[Token(Token = "0x600012E")]
	[Address(RVA = "0x1A8F4C4", Offset = "0x1A8F4C4", VA = "0x1A8F4C4")]
	public FPD_LayersAttribute()
	{
	}
}
[Token(Token = "0x200005B")]
public class FPD_OverridableFloatAttribute : PropertyAttribute
{
	[Token(Token = "0x40001D0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public string BoolVarName;

	[Token(Token = "0x40001D1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public string TargetVarName;

	[Token(Token = "0x40001D2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public int LabelWidth;

	[Token(Token = "0x600012F")]
	[Address(RVA = "0x1A8F4CC", Offset = "0x1A8F4CC", VA = "0x1A8F4CC")]
	public FPD_OverridableFloatAttribute(string boolVariableName, string targetVariableName, int labelWidth = 90)
	{
	}
}
[Token(Token = "0x200005C")]
public class BackgroundColorAttribute : PropertyAttribute
{
	[Token(Token = "0x40001D3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public float r;

	[Token(Token = "0x40001D4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float g;

	[Token(Token = "0x40001D5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float b;

	[Token(Token = "0x40001D6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float a;

	[Token(Token = "0x1700001C")]
	public Color Color
	{
		[Token(Token = "0x6000132")]
		[Address(RVA = "0x11CEC5C", Offset = "0x11CEC5C", VA = "0x11CEC5C")]
		get
		{
			return default(Color);
		}
	}

	[Token(Token = "0x6000130")]
	[Address(RVA = "0x11CEBE4", Offset = "0x11CEBE4", VA = "0x11CEBE4")]
	public BackgroundColorAttribute()
	{
	}

	[Token(Token = "0x6000131")]
	[Address(RVA = "0x11CEC10", Offset = "0x11CEC10", VA = "0x11CEC10")]
	public BackgroundColorAttribute(float aR, float aG, float aB, float aA)
	{
	}
}
[Token(Token = "0x200005D")]
public class FPD_WidthAttribute : PropertyAttribute
{
	[Token(Token = "0x40001D7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public float LabelWidth;

	[Token(Token = "0x6000133")]
	[Address(RVA = "0x1A8F6C0", Offset = "0x1A8F6C0", VA = "0x1A8F6C0")]
	public FPD_WidthAttribute(int labelWidth)
	{
	}
}
[Token(Token = "0x200005E")]
public class FPD_IndentAttribute : PropertyAttribute
{
	[Token(Token = "0x40001D8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public int IndentCount;

	[Token(Token = "0x40001D9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public int LabelsWidth;

	[Token(Token = "0x40001DA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public int SpaceAfter;

	[Token(Token = "0x6000134")]
	[Address(RVA = "0x1A8F47C", Offset = "0x1A8F47C", VA = "0x1A8F47C")]
	public FPD_IndentAttribute(int indent = 1, int labelsWidth = 0, int spaceAfter = 0)
	{
	}
}
[Token(Token = "0x200005F")]
public class FPD_HorizontalLineAttribute : PropertyAttribute
{
	[Token(Token = "0x40001DB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public Color color;

	[Token(Token = "0x6000135")]
	[Address(RVA = "0x1A8F408", Offset = "0x1A8F408", VA = "0x1A8F408")]
	public FPD_HorizontalLineAttribute(float r = 0.55f, float g = 0.55f, float b = 0.55f, float a = 0.7f)
	{
	}
}
[Token(Token = "0x2000060")]
public class FPD_PercentageAttribute : PropertyAttribute
{
	[Token(Token = "0x2000061")]
	public enum SuffixMode
	{
		[Token(Token = "0x40001E3")]
		From0to100,
		[Token(Token = "0x40001E4")]
		PercentageUnclamped,
		[Token(Token = "0x40001E5")]
		FromMinToMax,
		[Token(Token = "0x40001E6")]
		FromMinToMaxRounded
	}

	[Token(Token = "0x40001DC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public readonly float Min;

	[Token(Token = "0x40001DD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public readonly float Max;

	[Token(Token = "0x40001DE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public readonly string Suffix;

	[Token(Token = "0x40001DF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public readonly bool from0to100;

	[Token(Token = "0x40001E0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
	public readonly bool editableValue;

	[Token(Token = "0x40001E1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2A")]
	public readonly bool basic;

	[Token(Token = "0x6000136")]
	[Address(RVA = "0x1A8F528", Offset = "0x1A8F528", VA = "0x1A8F528")]
	public FPD_PercentageAttribute(float min, float max, bool goOver100Perc = false, bool editable = true, string suffix = "%", bool basicFromTo = false)
	{
	}
}
[Token(Token = "0x2000062")]
public class FPD_SuffixAttribute : PropertyAttribute
{
	[Token(Token = "0x2000063")]
	public enum SuffixMode
	{
		[Token(Token = "0x40001ED")]
		From0to100,
		[Token(Token = "0x40001EE")]
		PercentageUnclamped,
		[Token(Token = "0x40001EF")]
		FromMinToMax,
		[Token(Token = "0x40001F0")]
		FromMinToMaxRounded
	}

	[Token(Token = "0x40001E7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public readonly float Min;

	[Token(Token = "0x40001E8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public readonly float Max;

	[Token(Token = "0x40001E9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public readonly SuffixMode Mode;

	[Token(Token = "0x40001EA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public readonly string Suffix;

	[Token(Token = "0x40001EB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public readonly bool editableValue;

	[Token(Token = "0x6000137")]
	[Address(RVA = "0x1A8F5AC", Offset = "0x1A8F5AC", VA = "0x1A8F5AC")]
	public FPD_SuffixAttribute(float min, float max, SuffixMode mode = SuffixMode.From0to100, string suffix = "%", bool editable = true)
	{
	}
}
[Token(Token = "0x2000064")]
public class FPD_TabAttribute : PropertyAttribute
{
	[Token(Token = "0x40001F1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public string HeaderText;

	[Token(Token = "0x40001F2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float R;

	[Token(Token = "0x40001F3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public float G;

	[Token(Token = "0x40001F4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float B;

	[Token(Token = "0x40001F5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public string IconContent;

	[Token(Token = "0x40001F6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public string ResourcesIconPath;

	[Token(Token = "0x40001F7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public int IconSize;

	[Token(Token = "0x40001F8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public string FoldVariable;

	[Token(Token = "0x6000138")]
	[Address(RVA = "0x1A8F614", Offset = "0x1A8F614", VA = "0x1A8F614")]
	public FPD_TabAttribute(string headerText, float r = 0.5f, float g = 0.5f, float b = 1f, string iconContent = "", string resourcesIconPath = "", int iconSize = 24, string foldVariable = "")
	{
	}
}
[Token(Token = "0x2000065")]
public class DemoScript : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x2000066")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8CAF00", Offset = "0x8CAF00")]
	private sealed class <>c
	{
		[Token(Token = "0x40001FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly <>c <>9;

		[Token(Token = "0x40001FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static Func<OutputDevice, bool> <>9__5_0;

		[Token(Token = "0x40001FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static Func<OutputDevice, string> <>9__5_1;

		[Token(Token = "0x40001FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public static Func<Note, string> <>9__11_0;

		[Token(Token = "0x6000144")]
		[Address(RVA = "0x117EEC4", Offset = "0x117EEC4", VA = "0x117EEC4")]
		public <>c()
		{
		}

		[Token(Token = "0x6000145")]
		[Address(RVA = "0x117EECC", Offset = "0x117EECC", VA = "0x117EECC")]
		internal bool <InitializeOutputDevice>b__5_0(OutputDevice d)
		{
			return default(bool);
		}

		[Token(Token = "0x6000146")]
		[Address(RVA = "0x117EF30", Offset = "0x117EF30", VA = "0x117EF30")]
		internal string <InitializeOutputDevice>b__5_1(OutputDevice d)
		{
			return null;
		}

		[Token(Token = "0x6000147")]
		[Address(RVA = "0x117EF9C", Offset = "0x117EF9C", VA = "0x117EF9C")]
		internal string <LogNotes>b__11_0(Note n)
		{
			return null;
		}
	}

	[Token(Token = "0x40001F9")]
	private const string OutputDeviceName = "Microsoft GS Wavetable Synth";

	[Token(Token = "0x40001FA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private OutputDevice _outputDevice;

	[Token(Token = "0x40001FB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Playback _playback;

	[Token(Token = "0x6000139")]
	[Address(RVA = "0x11DE858", Offset = "0x11DE858", VA = "0x11DE858")]
	private void Start()
	{
	}

	[Token(Token = "0x600013A")]
	[Address(RVA = "0x11DF0F8", Offset = "0x11DF0F8", VA = "0x11DF0F8")]
	private void OnApplicationQuit()
	{
	}

	[Token(Token = "0x600013B")]
	[Address(RVA = "0x11DE88C", Offset = "0x11DE88C", VA = "0x11DE88C")]
	private void InitializeOutputDevice()
	{
	}

	[Token(Token = "0x600013C")]
	[Address(RVA = "0x11DEC28", Offset = "0x11DEC28", VA = "0x11DEC28")]
	private MidiFile CreateTestFile()
	{
		return null;
	}

	[Token(Token = "0x600013D")]
	[Address(RVA = "0x11DEED0", Offset = "0x11DEED0", VA = "0x11DEED0")]
	private void InitializeFilePlayback(MidiFile midiFile)
	{
	}

	[Token(Token = "0x600013E")]
	[Address(RVA = "0x11DF06C", Offset = "0x11DF06C", VA = "0x11DF06C")]
	private void StartPlayback()
	{
	}

	[Token(Token = "0x600013F")]
	[Address(RVA = "0x11DF2D8", Offset = "0x11DF2D8", VA = "0x11DF2D8")]
	private void OnNotesPlaybackFinished(object sender, NotesEventArgs e)
	{
	}

	[Token(Token = "0x6000140")]
	[Address(RVA = "0x11DF528", Offset = "0x11DF528", VA = "0x11DF528")]
	private void OnNotesPlaybackStarted(object sender, NotesEventArgs e)
	{
	}

	[Token(Token = "0x6000141")]
	[Address(RVA = "0x11DF324", Offset = "0x11DF324", VA = "0x11DF324")]
	private void LogNotes(string title, NotesEventArgs e)
	{
	}

	[Token(Token = "0x6000142")]
	[Address(RVA = "0x11DF574", Offset = "0x11DF574", VA = "0x11DF574")]
	public DemoScript()
	{
	}
}
[Token(Token = "0x2000067")]
public class LookAtTarget : MonoBehaviour
{
	[Token(Token = "0x4000200")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private Transform _target;

	[Token(Token = "0x4000201")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private float _speed;

	[Token(Token = "0x4000202")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	private Vector3 _lookAtTarget;

	[Token(Token = "0x6000148")]
	[Address(RVA = "0x1A97F2C", Offset = "0x1A97F2C", VA = "0x1A97F2C")]
	private void Update()
	{
	}

	[Token(Token = "0x6000149")]
	[Address(RVA = "0x1A97FE4", Offset = "0x1A97FE4", VA = "0x1A97FE4")]
	public LookAtTarget()
	{
	}
}
[Token(Token = "0x2000068")]
public class MouseMove : MonoBehaviour
{
	[Token(Token = "0x4000203")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private float _sensitivity;

	[Token(Token = "0x4000204")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	private Vector3 _originalPos;

	[Token(Token = "0x600014A")]
	[Address(RVA = "0x1A9AF9C", Offset = "0x1A9AF9C", VA = "0x1A9AF9C")]
	private void Start()
	{
	}

	[Token(Token = "0x600014B")]
	[Address(RVA = "0x1A9AFD8", Offset = "0x1A9AFD8", VA = "0x1A9AFD8")]
	private void Update()
	{
	}

	[Token(Token = "0x600014C")]
	[Address(RVA = "0x1A9B094", Offset = "0x1A9B094", VA = "0x1A9B094")]
	public MouseMove()
	{
	}
}
[Token(Token = "0x2000069")]
public class SwooshOnOff : MonoBehaviour
{
	[Token(Token = "0x4000205")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private MeleeWeaponTrail _trail;

	[Token(Token = "0x4000206")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public bool Trail;

	[Token(Token = "0x600014D")]
	[Address(RVA = "0x1E250C0", Offset = "0x1E250C0", VA = "0x1E250C0")]
	private void Start()
	{
	}

	[Token(Token = "0x600014E")]
	[Address(RVA = "0x1E250E0", Offset = "0x1E250E0", VA = "0x1E250E0")]
	private void Update()
	{
	}

	[Token(Token = "0x600014F")]
	[Address(RVA = "0x1E25100", Offset = "0x1E25100", VA = "0x1E25100")]
	public SwooshOnOff()
	{
	}
}
[Token(Token = "0x200006A")]
public class Interpolate
{
	[Token(Token = "0x200006B")]
	public enum EaseType
	{
		[Token(Token = "0x4000208")]
		Linear,
		[Token(Token = "0x4000209")]
		EaseInQuad,
		[Token(Token = "0x400020A")]
		EaseOutQuad,
		[Token(Token = "0x400020B")]
		EaseInOutQuad,
		[Token(Token = "0x400020C")]
		EaseInCubic,
		[Token(Token = "0x400020D")]
		EaseOutCubic,
		[Token(Token = "0x400020E")]
		EaseInOutCubic,
		[Token(Token = "0x400020F")]
		EaseInQuart,
		[Token(Token = "0x4000210")]
		EaseOutQuart,
		[Token(Token = "0x4000211")]
		EaseInOutQuart,
		[Token(Token = "0x4000212")]
		EaseInQuint,
		[Token(Token = "0x4000213")]
		EaseOutQuint,
		[Token(Token = "0x4000214")]
		EaseInOutQuint,
		[Token(Token = "0x4000215")]
		EaseInSine,
		[Token(Token = "0x4000216")]
		EaseOutSine,
		[Token(Token = "0x4000217")]
		EaseInOutSine,
		[Token(Token = "0x4000218")]
		EaseInExpo,
		[Token(Token = "0x4000219")]
		EaseOutExpo,
		[Token(Token = "0x400021A")]
		EaseInOutExpo,
		[Token(Token = "0x400021B")]
		EaseInCirc,
		[Token(Token = "0x400021C")]
		EaseOutCirc,
		[Token(Token = "0x400021D")]
		EaseInOutCirc
	}

	[Token(Token = "0x200006C")]
	public delegate Vector3 ToVector3<T>(T v);

	[Token(Token = "0x200006D")]
	public delegate float Function(float a, float b, float c, float d);

	[Token(Token = "0x200006E")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8CAF10", Offset = "0x8CAF10")]
	private sealed class <NewTimer>d__3 : IEnumerable<float>, IEnumerable, IEnumerator<float>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400021E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400021F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private float <>2__current;

		[Token(Token = "0x4000220")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private int <>l__initialThreadId;

		[Token(Token = "0x4000221")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private float duration;

		[Token(Token = "0x4000222")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float <>3__duration;

		[Token(Token = "0x4000223")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private float <elapsedTime>5__2;

		[Token(Token = "0x1700001D")]
		private float System.Collections.Generic.IEnumerator<System.Single>.Current
		{
			[Token(Token = "0x6000185")]
			[Address(RVA = "0x118212C", Offset = "0x118212C", VA = "0x118212C", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700001E")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000187")]
			[Address(RVA = "0x1182174", Offset = "0x1182174", VA = "0x1182174", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000182")]
		[Address(RVA = "0x1182034", Offset = "0x1182034", VA = "0x1182034")]
		[DebuggerHidden]
		public <NewTimer>d__3(int <>1__state)
		{
		}

		[Token(Token = "0x6000183")]
		[Address(RVA = "0x118206C", Offset = "0x118206C", VA = "0x118206C", Slot = "7")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000184")]
		[Address(RVA = "0x1182070", Offset = "0x1182070", VA = "0x1182070", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000186")]
		[Address(RVA = "0x1182134", Offset = "0x1182134", VA = "0x1182134", Slot = "10")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}

		[Token(Token = "0x6000188")]
		[Address(RVA = "0x11821D4", Offset = "0x11821D4", VA = "0x11821D4", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<float> System.Collections.Generic.IEnumerable<System.Single>.GetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x6000189")]
		[Address(RVA = "0x118227C", Offset = "0x118227C", VA = "0x118227C", Slot = "5")]
		[DebuggerHidden]
		private IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Token(Token = "0x200006F")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8CAF20", Offset = "0x8CAF20")]
	private sealed class <NewCounter>d__6 : IEnumerable<float>, IEnumerable, IEnumerator<float>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000224")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000225")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private float <>2__current;

		[Token(Token = "0x4000226")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private int <>l__initialThreadId;

		[Token(Token = "0x4000227")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private int start;

		[Token(Token = "0x4000228")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public int <>3__start;

		[Token(Token = "0x4000229")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private int step;

		[Token(Token = "0x400022A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public int <>3__step;

		[Token(Token = "0x400022B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private int end;

		[Token(Token = "0x400022C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public int <>3__end;

		[Token(Token = "0x400022D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private int <i>5__2;

		[Token(Token = "0x1700001F")]
		private float System.Collections.Generic.IEnumerator<System.Single>.Current
		{
			[Token(Token = "0x600018D")]
			[Address(RVA = "0x1181A78", Offset = "0x1181A78", VA = "0x1181A78", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000020")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600018F")]
			[Address(RVA = "0x1181AC0", Offset = "0x1181AC0", VA = "0x1181AC0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600018A")]
		[Address(RVA = "0x11819D8", Offset = "0x11819D8", VA = "0x11819D8")]
		[DebuggerHidden]
		public <NewCounter>d__6(int <>1__state)
		{
		}

		[Token(Token = "0x600018B")]
		[Address(RVA = "0x1181A10", Offset = "0x1181A10", VA = "0x1181A10", Slot = "7")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600018C")]
		[Address(RVA = "0x1181A14", Offset = "0x1181A14", VA = "0x1181A14", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600018E")]
		[Address(RVA = "0x1181A80", Offset = "0x1181A80", VA = "0x1181A80", Slot = "10")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}

		[Token(Token = "0x6000190")]
		[Address(RVA = "0x1181B20", Offset = "0x1181B20", VA = "0x1181B20", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<float> System.Collections.Generic.IEnumerable<System.Single>.GetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x6000191")]
		[Address(RVA = "0x1181BD8", Offset = "0x1181BD8", VA = "0x1181BD8", Slot = "5")]
		[DebuggerHidden]
		private IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Token(Token = "0x2000070")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8CAF30", Offset = "0x8CAF30")]
	private sealed class <NewEase>d__9 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400022E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400022F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000230")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Vector3 end;

		[Token(Token = "0x4000231")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public Vector3 start;

		[Token(Token = "0x4000232")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IEnumerable<float> driver;

		[Token(Token = "0x4000233")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Function ease;

		[Token(Token = "0x4000234")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float total;

		[Token(Token = "0x4000235")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Vector3 <distance>5__2;

		[Token(Token = "0x4000236")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private IEnumerator<float> <>7__wrap2;

		[Token(Token = "0x17000021")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000196")]
			[Address(RVA = "0x1181FE4", Offset = "0x1181FE4", VA = "0x1181FE4", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000022")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000198")]
			[Address(RVA = "0x118202C", Offset = "0x118202C", VA = "0x118202C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000192")]
		[Address(RVA = "0x1181BDC", Offset = "0x1181BDC", VA = "0x1181BDC")]
		[DebuggerHidden]
		public <NewEase>d__9(int <>1__state)
		{
		}

		[Token(Token = "0x6000193")]
		[Address(RVA = "0x1181C08", Offset = "0x1181C08", VA = "0x1181C08", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000194")]
		[Address(RVA = "0x1181CE0", Offset = "0x1181CE0", VA = "0x1181CE0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000195")]
		[Address(RVA = "0x1181C24", Offset = "0x1181C24", VA = "0x1181C24")]
		private void <>m__Finally1()
		{
		}

		[Token(Token = "0x6000197")]
		[Address(RVA = "0x1181FEC", Offset = "0x1181FEC", VA = "0x1181FEC", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000071")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8CAF40", Offset = "0x8CAF40")]
	private sealed class <NewBezier>d__16<T> : IEnumerable<Vector3>, IEnumerable, IEnumerator<Vector3>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000237")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int <>1__state;

		[Token(Token = "0x4000238")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Vector3 <>2__current;

		[Token(Token = "0x4000239")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int <>l__initialThreadId;

		[Token(Token = "0x400023A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private IList nodes;

		[Token(Token = "0x400023B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public IList <>3__nodes;

		[Token(Token = "0x400023C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private IEnumerable<float> steps;

		[Token(Token = "0x400023D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public IEnumerable<float> <>3__steps;

		[Token(Token = "0x400023E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private ToVector3<T> toVector3;

		[Token(Token = "0x400023F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public ToVector3<T> <>3__toVector3;

		[Token(Token = "0x4000240")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Function ease;

		[Token(Token = "0x4000241")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Function <>3__ease;

		[Token(Token = "0x4000242")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private float maxStep;

		[Token(Token = "0x4000243")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float <>3__maxStep;

		[Token(Token = "0x4000244")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Vector3[] <points>5__2;

		[Token(Token = "0x4000245")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private IEnumerator<float> <>7__wrap2;

		[Token(Token = "0x17000023")]
		private Vector3 System.Collections.Generic.IEnumerator<UnityEngine.Vector3>.Current
		{
			[Token(Token = "0x600019D")]
			[DebuggerHidden]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000024")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600019F")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000199")]
		[DebuggerHidden]
		public <NewBezier>d__16(int <>1__state)
		{
		}

		[Token(Token = "0x600019A")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600019B")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600019C")]
		private void <>m__Finally1()
		{
		}

		[Token(Token = "0x600019E")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}

		[Token(Token = "0x60001A0")]
		[DebuggerHidden]
		private IEnumerator<Vector3> System.Collections.Generic.IEnumerable<UnityEngine.Vector3>.GetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x60001A1")]
		[DebuggerHidden]
		private IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Token(Token = "0x2000072")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8CAF50", Offset = "0x8CAF50")]
	private sealed class <NewCatmullRom>d__20<T> : IEnumerable<Vector3>, IEnumerable, IEnumerator<Vector3>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000246")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int <>1__state;

		[Token(Token = "0x4000247")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Vector3 <>2__current;

		[Token(Token = "0x4000248")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int <>l__initialThreadId;

		[Token(Token = "0x4000249")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private IList nodes;

		[Token(Token = "0x400024A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public IList <>3__nodes;

		[Token(Token = "0x400024B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private ToVector3<T> toVector3;

		[Token(Token = "0x400024C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public ToVector3<T> <>3__toVector3;

		[Token(Token = "0x400024D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private bool loop;

		[Token(Token = "0x400024E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public bool <>3__loop;

		[Token(Token = "0x400024F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int slices;

		[Token(Token = "0x4000250")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int <>3__slices;

		[Token(Token = "0x4000251")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int <last>5__2;

		[Token(Token = "0x4000252")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int <current>5__3;

		[Token(Token = "0x4000253")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int <previous>5__4;

		[Token(Token = "0x4000254")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int <start>5__5;

		[Token(Token = "0x4000255")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int <end>5__6;

		[Token(Token = "0x4000256")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int <next>5__7;

		[Token(Token = "0x4000257")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int <stepCount>5__8;

		[Token(Token = "0x4000258")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int <step>5__9;

		[Token(Token = "0x17000025")]
		private Vector3 System.Collections.Generic.IEnumerator<UnityEngine.Vector3>.Current
		{
			[Token(Token = "0x60001A5")]
			[DebuggerHidden]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000026")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60001A7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001A2")]
		[DebuggerHidden]
		public <NewCatmullRom>d__20(int <>1__state)
		{
		}

		[Token(Token = "0x60001A3")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60001A4")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60001A6")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}

		[Token(Token = "0x60001A8")]
		[DebuggerHidden]
		private IEnumerator<Vector3> System.Collections.Generic.IEnumerable<UnityEngine.Vector3>.GetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x60001A9")]
		[DebuggerHidden]
		private IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Token(Token = "0x6000150")]
	[Address(RVA = "0x1A96248", Offset = "0x1A96248", VA = "0x1A96248")]
	private static Vector3 Identity(Vector3 v)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000151")]
	[Address(RVA = "0x1A9624C", Offset = "0x1A9624C", VA = "0x1A9624C")]
	private static Vector3 TransformDotPosition(Transform t)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000152")]
	[Address(RVA = "0x1A96264", Offset = "0x1A96264", VA = "0x1A96264")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x8D134C", Offset = "0x8D134C")]
	private static IEnumerable<float> NewTimer(float duration)
	{
		return null;
	}

	[Token(Token = "0x6000153")]
	[Address(RVA = "0x1A962D8", Offset = "0x1A962D8", VA = "0x1A962D8")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x8D13AC", Offset = "0x8D13AC")]
	private static IEnumerable<float> NewCounter(int start, int end, int step)
	{
		return null;
	}

	[Token(Token = "0x6000154")]
	[Address(RVA = "0x1A9635C", Offset = "0x1A9635C", VA = "0x1A9635C")]
	public static IEnumerator NewEase(Function ease, Vector3 start, Vector3 end, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000155")]
	[Address(RVA = "0x1A964C0", Offset = "0x1A964C0", VA = "0x1A964C0")]
	public static IEnumerator NewEase(Function ease, Vector3 start, Vector3 end, int slices)
	{
		return null;
	}

	[Token(Token = "0x6000156")]
	[Address(RVA = "0x1A963E0", Offset = "0x1A963E0", VA = "0x1A963E0")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x8D140C", Offset = "0x8D140C")]
	private static IEnumerator NewEase(Function ease, Vector3 start, Vector3 end, float total, IEnumerable<float> driver)
	{
		return null;
	}

	[Token(Token = "0x6000157")]
	[Address(RVA = "0x1A96544", Offset = "0x1A96544", VA = "0x1A96544")]
	private static Vector3 Ease(Function ease, Vector3 start, Vector3 distance, float elapsedTime, float duration)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000158")]
	[Address(RVA = "0x1A96600", Offset = "0x1A96600", VA = "0x1A96600")]
	public static Function Ease(EaseType type)
	{
		return null;
	}

	[Token(Token = "0x6000159")]
	[Address(RVA = "0x1A969E8", Offset = "0x1A969E8", VA = "0x1A969E8")]
	public static IEnumerable<Vector3> NewBezier(Function ease, Transform[] nodes, float duration)
	{
		return null;
	}

	[Token(Token = "0x600015A")]
	[Address(RVA = "0x1A96AC4", Offset = "0x1A96AC4", VA = "0x1A96AC4")]
	public static IEnumerable<Vector3> NewBezier(Function ease, Transform[] nodes, int slices)
	{
		return null;
	}

	[Token(Token = "0x600015B")]
	[Address(RVA = "0x1A96BAC", Offset = "0x1A96BAC", VA = "0x1A96BAC")]
	public static IEnumerable<Vector3> NewBezier(Function ease, Vector3[] points, float duration)
	{
		return null;
	}

	[Token(Token = "0x600015C")]
	[Address(RVA = "0x1A96C88", Offset = "0x1A96C88", VA = "0x1A96C88")]
	public static IEnumerable<Vector3> NewBezier(Function ease, Vector3[] points, int slices)
	{
		return null;
	}

	[Token(Token = "0x600015D")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x8D146C", Offset = "0x8D146C")]
	private static IEnumerable<Vector3> NewBezier<T>(Function ease, IList nodes, ToVector3<T> toVector3, float maxStep, IEnumerable<float> steps)
	{
		return null;
	}

	[Token(Token = "0x600015E")]
	[Address(RVA = "0x1A96D70", Offset = "0x1A96D70", VA = "0x1A96D70")]
	private static Vector3 Bezier(Function ease, Vector3[] points, float elapsedTime, float duration)
	{
		return default(Vector3);
	}

	[Token(Token = "0x600015F")]
	[Address(RVA = "0x1A96EE0", Offset = "0x1A96EE0", VA = "0x1A96EE0")]
	public static IEnumerable<Vector3> NewCatmullRom(Transform[] nodes, int slices, bool loop)
	{
		return null;
	}

	[Token(Token = "0x6000160")]
	[Address(RVA = "0x1A96FA0", Offset = "0x1A96FA0", VA = "0x1A96FA0")]
	public static IEnumerable<Vector3> NewCatmullRom(Vector3[] points, int slices, bool loop)
	{
		return null;
	}

	[Token(Token = "0x6000161")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x8D14CC", Offset = "0x8D14CC")]
	private static IEnumerable<Vector3> NewCatmullRom<T>(IList nodes, ToVector3<T> toVector3, int slices, bool loop)
	{
		return null;
	}

	[Token(Token = "0x6000162")]
	[Address(RVA = "0x1A97060", Offset = "0x1A97060", VA = "0x1A97060")]
	private static Vector3 CatmullRom(Vector3 previous, Vector3 start, Vector3 end, Vector3 next, float elapsedTime, float duration)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000163")]
	[Address(RVA = "0x1A97120", Offset = "0x1A97120", VA = "0x1A97120")]
	private static float Linear(float start, float distance, float elapsedTime, float duration)
	{
		return default(float);
	}

	[Token(Token = "0x6000164")]
	[Address(RVA = "0x1A97138", Offset = "0x1A97138", VA = "0x1A97138")]
	private static float EaseInQuad(float start, float distance, float elapsedTime, float duration)
	{
		return default(float);
	}

	[Token(Token = "0x6000165")]
	[Address(RVA = "0x1A97158", Offset = "0x1A97158", VA = "0x1A97158")]
	private static float EaseOutQuad(float start, float distance, float elapsedTime, float duration)
	{
		return default(float);
	}

	[Token(Token = "0x6000166")]
	[Address(RVA = "0x1A97180", Offset = "0x1A97180", VA = "0x1A97180")]
	private static float EaseInOutQuad(float start, float distance, float elapsedTime, float duration)
	{
		return default(float);
	}

	[Token(Token = "0x6000167")]
	[Address(RVA = "0x1A971E4", Offset = "0x1A971E4", VA = "0x1A971E4")]
	private static float EaseInCubic(float start, float distance, float elapsedTime, float duration)
	{
		return default(float);
	}

	[Token(Token = "0x6000168")]
	[Address(RVA = "0x1A97208", Offset = "0x1A97208", VA = "0x1A97208")]
	private static float EaseOutCubic(float start, float distance, float elapsedTime, float duration)
	{
		return default(float);
	}

	[Token(Token = "0x6000169")]
	[Address(RVA = "0x1A9723C", Offset = "0x1A9723C", VA = "0x1A9723C")]
	private static float EaseInOutCubic(float start, float distance, float elapsedTime, float duration)
	{
		return default(float);
	}

	[Token(Token = "0x600016A")]
	[Address(RVA = "0x1A972A0", Offset = "0x1A972A0", VA = "0x1A972A0")]
	private static float EaseInQuart(float start, float distance, float elapsedTime, float duration)
	{
		return default(float);
	}

	[Token(Token = "0x600016B")]
	[Address(RVA = "0x1A972C8", Offset = "0x1A972C8", VA = "0x1A972C8")]
	private static float EaseOutQuart(float start, float distance, float elapsedTime, float duration)
	{
		return default(float);
	}

	[Token(Token = "0x600016C")]
	[Address(RVA = "0x1A972FC", Offset = "0x1A972FC", VA = "0x1A972FC")]
	private static float EaseInOutQuart(float start, float distance, float elapsedTime, float duration)
	{
		return default(float);
	}

	[Token(Token = "0x600016D")]
	[Address(RVA = "0x1A97368", Offset = "0x1A97368", VA = "0x1A97368")]
	private static float EaseInQuint(float start, float distance, float elapsedTime, float duration)
	{
		return default(float);
	}

	[Token(Token = "0x600016E")]
	[Address(RVA = "0x1A97394", Offset = "0x1A97394", VA = "0x1A97394")]
	private static float EaseOutQuint(float start, float distance, float elapsedTime, float duration)
	{
		return default(float);
	}

	[Token(Token = "0x600016F")]
	[Address(RVA = "0x1A973D0", Offset = "0x1A973D0", VA = "0x1A973D0")]
	private static float EaseInOutQuint(float start, float distance, float elapsedTime, float duration)
	{
		return default(float);
	}

	[Token(Token = "0x6000170")]
	[Address(RVA = "0x1A97444", Offset = "0x1A97444", VA = "0x1A97444")]
	private static float EaseInSine(float start, float distance, float elapsedTime, float duration)
	{
		return default(float);
	}

	[Token(Token = "0x6000171")]
	[Address(RVA = "0x1A9748C", Offset = "0x1A9748C", VA = "0x1A9748C")]
	private static float EaseOutSine(float start, float distance, float elapsedTime, float duration)
	{
		return default(float);
	}

	[Token(Token = "0x6000172")]
	[Address(RVA = "0x1A974D0", Offset = "0x1A974D0", VA = "0x1A974D0")]
	private static float EaseInOutSine(float start, float distance, float elapsedTime, float duration)
	{
		return default(float);
	}

	[Token(Token = "0x6000173")]
	[Address(RVA = "0x1A97524", Offset = "0x1A97524", VA = "0x1A97524")]
	private static float EaseInExpo(float start, float distance, float elapsedTime, float duration)
	{
		return default(float);
	}

	[Token(Token = "0x6000174")]
	[Address(RVA = "0x1A9756C", Offset = "0x1A9756C", VA = "0x1A9756C")]
	private static float EaseOutExpo(float start, float distance, float elapsedTime, float duration)
	{
		return default(float);
	}

	[Token(Token = "0x6000175")]
	[Address(RVA = "0x1A975B4", Offset = "0x1A975B4", VA = "0x1A975B4")]
	private static float EaseInOutExpo(float start, float distance, float elapsedTime, float duration)
	{
		return default(float);
	}

	[Token(Token = "0x6000176")]
	[Address(RVA = "0x1A97644", Offset = "0x1A97644", VA = "0x1A97644")]
	private static float EaseInCirc(float start, float distance, float elapsedTime, float duration)
	{
		return default(float);
	}

	[Token(Token = "0x6000177")]
	[Address(RVA = "0x1A976A4", Offset = "0x1A976A4", VA = "0x1A976A4")]
	private static float EaseOutCirc(float start, float distance, float elapsedTime, float duration)
	{
		return default(float);
	}

	[Token(Token = "0x6000178")]
	[Address(RVA = "0x1A97708", Offset = "0x1A97708", VA = "0x1A97708")]
	private static float EaseInOutCirc(float start, float distance, float elapsedTime, float duration)
	{
		return default(float);
	}

	[Token(Token = "0x6000179")]
	[Address(RVA = "0x1A977A8", Offset = "0x1A977A8", VA = "0x1A977A8")]
	public Interpolate()
	{
	}
}
[Token(Token = "0x2000073")]
public class MeleeWeaponTrail : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x2000074")]
	public class Point
	{
		[Token(Token = "0x400026E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float timeCreated;

		[Token(Token = "0x400026F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public Vector3 basePosition;

		[Token(Token = "0x4000270")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Vector3 tipPosition;

		[Token(Token = "0x60001B1")]
		[Address(RVA = "0x1182600", Offset = "0x1182600", VA = "0x1182600")]
		public Point()
		{
		}
	}

	[Token(Token = "0x4000259")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private bool _emit;

	[Token(Token = "0x400025A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
	private bool _use;

	[Token(Token = "0x400025B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	[SerializeField]
	private float _emitTime;

	[Token(Token = "0x400025C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Material _material;

	[Token(Token = "0x400025D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private float _lifeTime;

	[Token(Token = "0x400025E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	private Color[] _colors;

	[Token(Token = "0x400025F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[SerializeField]
	private float[] _sizes;

	[Token(Token = "0x4000260")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[SerializeField]
	private float _minVertexDistance;

	[Token(Token = "0x4000261")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	[SerializeField]
	private float _maxVertexDistance;

	[Token(Token = "0x4000262")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private float _minVertexDistanceSqr;

	[Token(Token = "0x4000263")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	private float _maxVertexDistanceSqr;

	[Token(Token = "0x4000264")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[SerializeField]
	private float _maxAngle;

	[Token(Token = "0x4000265")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	[SerializeField]
	private bool _autoDestruct;

	[Token(Token = "0x4000266")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[SerializeField]
	private int subdivisions;

	[Token(Token = "0x4000267")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	[SerializeField]
	private Transform _base;

	[Token(Token = "0x4000268")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	[SerializeField]
	private Transform _tip;

	[Token(Token = "0x4000269")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private List<Point> _points;

	[Token(Token = "0x400026A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private List<Point> _smoothedPoints;

	[Token(Token = "0x400026B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private GameObject _trailObject;

	[Token(Token = "0x400026C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private Mesh _trailMesh;

	[Token(Token = "0x400026D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private Vector3 _lastPosition;

	[Token(Token = "0x17000027")]
	public bool Emit
	{
		[Token(Token = "0x60001AA")]
		[Address(RVA = "0x1A97FF4", Offset = "0x1A97FF4", VA = "0x1A97FF4")]
		set
		{
		}
	}

	[Token(Token = "0x17000028")]
	public bool Use
	{
		[Token(Token = "0x60001AB")]
		[Address(RVA = "0x1A98000", Offset = "0x1A98000", VA = "0x1A98000")]
		set
		{
		}
	}

	[Token(Token = "0x60001AC")]
	[Address(RVA = "0x1A9800C", Offset = "0x1A9800C", VA = "0x1A9800C")]
	private void Start()
	{
	}

	[Token(Token = "0x60001AD")]
	[Address(RVA = "0x1A982F0", Offset = "0x1A982F0", VA = "0x1A982F0")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x60001AE")]
	[Address(RVA = "0x1A98358", Offset = "0x1A98358", VA = "0x1A98358")]
	private void Update()
	{
	}

	[Token(Token = "0x60001AF")]
	[Address(RVA = "0x1A99310", Offset = "0x1A99310", VA = "0x1A99310")]
	private void RemoveOldPoints(List<Point> pointList)
	{
	}

	[Token(Token = "0x60001B0")]
	[Address(RVA = "0x1A995D0", Offset = "0x1A995D0", VA = "0x1A995D0")]
	public MeleeWeaponTrail()
	{
	}
}
[Token(Token = "0x2000075")]
public class Movement : MonoBehaviour
{
	[Token(Token = "0x4000271")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Vector3 movementVector;

	[Token(Token = "0x60001B2")]
	[Address(RVA = "0x1A9B398", Offset = "0x1A9B398", VA = "0x1A9B398")]
	private void Update()
	{
	}

	[Token(Token = "0x60001B3")]
	[Address(RVA = "0x1A9B424", Offset = "0x1A9B424", VA = "0x1A9B424")]
	public Movement()
	{
	}
}
[Token(Token = "0x2000076")]
[ExecuteInEditMode]
public class MobilePostProcessing : MonoBehaviour
{
	[Token(Token = "0x4000272")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool Blur;

	[Token(Token = "0x4000273")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8CBB44", Offset = "0x8CBB44")]
	public float BlurAmount;

	[Token(Token = "0x4000274")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Texture2D BlurMask;

	[Token(Token = "0x4000275")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public bool Bloom;

	[Token(Token = "0x4000276")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public Color BloomColor;

	[Token(Token = "0x4000277")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8CBB5C", Offset = "0x8CBB5C")]
	public float BloomAmount;

	[Token(Token = "0x4000278")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8CBB74", Offset = "0x8CBB74")]
	public float BloomDiffuse;

	[Token(Token = "0x4000279")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8CBB8C", Offset = "0x8CBB8C")]
	public float BloomThreshold;

	[Token(Token = "0x400027A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8CBBA4", Offset = "0x8CBBA4")]
	public float BloomSoftness;

	[Token(Token = "0x400027B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	public bool LUT;

	[Token(Token = "0x400027C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8CBBBC", Offset = "0x8CBBBC")]
	public float LutAmount;

	[Token(Token = "0x400027D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public Texture2D SourceLut;

	[Token(Token = "0x400027E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public bool ImageFiltering;

	[Token(Token = "0x400027F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	public Color Color;

	[Token(Token = "0x4000280")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8CBBD4", Offset = "0x8CBBD4")]
	public float Contrast;

	[Token(Token = "0x4000281")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8CBBEC", Offset = "0x8CBBEC")]
	public float Brightness;

	[Token(Token = "0x4000282")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8CBC04", Offset = "0x8CBC04")]
	public float Saturation;

	[Token(Token = "0x4000283")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8CBC1C", Offset = "0x8CBC1C")]
	public float Exposure;

	[Token(Token = "0x4000284")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8CBC34", Offset = "0x8CBC34")]
	public float Gamma;

	[Token(Token = "0x4000285")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8CBC4C", Offset = "0x8CBC4C")]
	public float Sharpness;

	[Token(Token = "0x4000286")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
	public bool ChromaticAberration;

	[Token(Token = "0x4000287")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public float Offset;

	[Token(Token = "0x4000288")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8CBC64", Offset = "0x8CBC64")]
	public float FishEyeDistortion;

	[Token(Token = "0x4000289")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8CBC7C", Offset = "0x8CBC7C")]
	public float GlitchAmount;

	[Token(Token = "0x400028A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
	public bool Distortion;

	[Token(Token = "0x400028B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8CBC94", Offset = "0x8CBC94")]
	public float LensDistortion;

	[Token(Token = "0x400028C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
	public bool Vignette;

	[Token(Token = "0x400028D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public Color VignetteColor;

	[Token(Token = "0x400028E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8CBCAC", Offset = "0x8CBCAC")]
	public float VignetteAmount;

	[Token(Token = "0x400028F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8CBCC4", Offset = "0x8CBCC4")]
	public float VignetteSoftness;

	[Token(Token = "0x4000290")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static readonly int blurTexString;

	[Token(Token = "0x4000291")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	private static readonly int maskTextureString;

	[Token(Token = "0x4000292")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static readonly int blurAmountString;

	[Token(Token = "0x4000293")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	private static readonly int bloomColorString;

	[Token(Token = "0x4000294")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private static readonly int blDiffuseString;

	[Token(Token = "0x4000295")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	private static readonly int blDataString;

	[Token(Token = "0x4000296")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private static readonly int lutTextureString;

	[Token(Token = "0x4000297")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	private static readonly int lutAmountString;

	[Token(Token = "0x4000298")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private static readonly int colorString;

	[Token(Token = "0x4000299")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	private static readonly int contrastString;

	[Token(Token = "0x400029A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private static readonly int brightnessString;

	[Token(Token = "0x400029B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private static readonly int saturationString;

	[Token(Token = "0x400029C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private static readonly int centralFactorString;

	[Token(Token = "0x400029D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	private static readonly int sideFactorString;

	[Token(Token = "0x400029E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private static readonly int offsetString;

	[Token(Token = "0x400029F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	private static readonly int fishEyeString;

	[Token(Token = "0x40002A0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private static readonly int lensdistortionString;

	[Token(Token = "0x40002A1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	private static readonly int vignetteColorString;

	[Token(Token = "0x40002A2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private static readonly int vignetteAmountString;

	[Token(Token = "0x40002A3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	private static readonly int vignetteSoftnessString;

	[Token(Token = "0x40002A4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private static readonly string bloomKeyword;

	[Token(Token = "0x40002A5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private static readonly string blurKeyword;

	[Token(Token = "0x40002A6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private static readonly string chromaKeyword;

	[Token(Token = "0x40002A7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private static readonly string lutKeyword;

	[Token(Token = "0x40002A8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private static readonly string filterKeyword;

	[Token(Token = "0x40002A9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private static readonly string shaprenKeyword;

	[Token(Token = "0x40002AA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private static readonly string distortionKeyword;

	[Token(Token = "0x40002AB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	public Material material;

	[Token(Token = "0x40002AC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	private Texture2D previous;

	[Token(Token = "0x40002AD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	private Texture3D converted3D;

	[Token(Token = "0x40002AE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	private float t;

	[Token(Token = "0x40002AF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
	private float a;

	[Token(Token = "0x40002B0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	private float knee;

	[Token(Token = "0x40002B1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
	private int numberOfPasses;

	[Token(Token = "0x60001B4")]
	[Address(RVA = "0x1A996AC", Offset = "0x1A996AC", VA = "0x1A996AC")]
	public void Start()
	{
	}

	[Token(Token = "0x60001B5")]
	[Address(RVA = "0x1A99798", Offset = "0x1A99798", VA = "0x1A99798")]
	public void Update()
	{
	}

	[Token(Token = "0x60001B6")]
	[Address(RVA = "0x1A99A38", Offset = "0x1A99A38", VA = "0x1A99A38")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x60001B7")]
	[Address(RVA = "0x1A99844", Offset = "0x1A99844", VA = "0x1A99844")]
	private void Convert3D(Texture2D temp3DTex)
	{
	}

	[Token(Token = "0x60001B8")]
	[Address(RVA = "0x1A99AE8", Offset = "0x1A99AE8", VA = "0x1A99AE8")]
	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
	}

	[Token(Token = "0x60001B9")]
	[Address(RVA = "0x1A9AA64", Offset = "0x1A9AA64", VA = "0x1A9AA64")]
	public MobilePostProcessing()
	{
	}
}
[Token(Token = "0x2000077")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0x8CAF70", Offset = "0x8CAF70")]
public class particleAttractorLinear : MonoBehaviour
{
	[Token(Token = "0x40002B2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private ParticleSystem ps;

	[Token(Token = "0x40002B3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private ParticleSystem.Particle[] m_Particles;

	[Token(Token = "0x40002B4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Transform target;

	[Token(Token = "0x40002B5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public float speed;

	[Token(Token = "0x40002B6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	private int numParticlesAlive;

	[Token(Token = "0x60001BB")]
	[Address(RVA = "0x1179C6C", Offset = "0x1179C6C", VA = "0x1179C6C")]
	private void Start()
	{
	}

	[Token(Token = "0x60001BC")]
	[Address(RVA = "0x1179D50", Offset = "0x1179D50", VA = "0x1179D50")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x60001BD")]
	[Address(RVA = "0x1179EF4", Offset = "0x1179EF4", VA = "0x1179EF4")]
	public particleAttractorLinear()
	{
	}
}
[Token(Token = "0x2000078")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0x8CAFD0", Offset = "0x8CAFD0")]
public class particleAttractorMove : MonoBehaviour
{
	[Token(Token = "0x40002B7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private ParticleSystem ps;

	[Token(Token = "0x40002B8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private ParticleSystem.Particle[] m_Particles;

	[Token(Token = "0x40002B9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Transform target;

	[Token(Token = "0x40002BA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public float speed;

	[Token(Token = "0x40002BB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	private int numParticlesAlive;

	[Token(Token = "0x60001BE")]
	[Address(RVA = "0x1179F04", Offset = "0x1179F04", VA = "0x1179F04")]
	private void Start()
	{
	}

	[Token(Token = "0x60001BF")]
	[Address(RVA = "0x1179FE8", Offset = "0x1179FE8", VA = "0x1179FE8")]
	private void Update()
	{
	}

	[Token(Token = "0x60001C0")]
	[Address(RVA = "0x117A18C", Offset = "0x117A18C", VA = "0x117A18C")]
	public particleAttractorMove()
	{
	}
}
[Token(Token = "0x2000079")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0x8CB030", Offset = "0x8CB030")]
public class particleAttractorSelf : MonoBehaviour
{
	[Token(Token = "0x40002BC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private ParticleSystem ps;

	[Token(Token = "0x40002BD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private ParticleSystem.Particle[] m_Particles;

	[Token(Token = "0x40002BE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float speed;

	[Token(Token = "0x40002BF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private int numParticlesAlive;

	[Token(Token = "0x60001C1")]
	[Address(RVA = "0x117A19C", Offset = "0x117A19C", VA = "0x117A19C")]
	private void Start()
	{
	}

	[Token(Token = "0x60001C2")]
	[Address(RVA = "0x117A280", Offset = "0x117A280", VA = "0x117A280")]
	private void Update()
	{
	}

	[Token(Token = "0x60001C3")]
	[Address(RVA = "0x117A440", Offset = "0x117A440", VA = "0x117A440")]
	public particleAttractorSelf()
	{
	}
}
[Token(Token = "0x200007A")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0x8CB090", Offset = "0x8CB090")]
public class particleAttractorSpherical : MonoBehaviour
{
	[Token(Token = "0x40002C0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private ParticleSystem ps;

	[Token(Token = "0x40002C1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private ParticleSystem.Particle[] m_Particles;

	[Token(Token = "0x40002C2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Transform target;

	[Token(Token = "0x40002C3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public float speed;

	[Token(Token = "0x40002C4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	private int numParticlesAlive;

	[Token(Token = "0x60001C4")]
	[Address(RVA = "0x117A450", Offset = "0x117A450", VA = "0x117A450")]
	private void Start()
	{
	}

	[Token(Token = "0x60001C5")]
	[Address(RVA = "0x117A534", Offset = "0x117A534", VA = "0x117A534")]
	private void Update()
	{
	}

	[Token(Token = "0x60001C6")]
	[Address(RVA = "0x117A6D8", Offset = "0x117A6D8", VA = "0x117A6D8")]
	public particleAttractorSpherical()
	{
	}
}
[Token(Token = "0x200007B")]
public class rotation : MonoBehaviour
{
	[Token(Token = "0x40002C5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float xRotation;

	[Token(Token = "0x40002C6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float yRotation;

	[Token(Token = "0x40002C7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float zRotation;

	[Token(Token = "0x60001C7")]
	[Address(RVA = "0x117A6E8", Offset = "0x117A6E8", VA = "0x117A6E8")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60001C8")]
	[Address(RVA = "0x117A744", Offset = "0x117A744", VA = "0x117A744")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x60001C9")]
	[Address(RVA = "0x117A74C", Offset = "0x117A74C", VA = "0x117A74C")]
	public void clickOn()
	{
	}

	[Token(Token = "0x60001CA")]
	[Address(RVA = "0x117A7A8", Offset = "0x117A7A8", VA = "0x117A7A8")]
	public void clickOff()
	{
	}

	[Token(Token = "0x60001CB")]
	[Address(RVA = "0x117A7B0", Offset = "0x117A7B0", VA = "0x117A7B0")]
	private void rotate()
	{
	}

	[Token(Token = "0x60001CC")]
	[Address(RVA = "0x117A804", Offset = "0x117A804", VA = "0x117A804")]
	public rotation()
	{
	}
}
namespace HelloPico2.Interact.SpineCreator
{
	[Token(Token = "0x200007C")]
	public class FloatingSurround : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x200007D")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8CB0F0", Offset = "0x8CB0F0")]
		private sealed class <>c
		{
			[Token(Token = "0x40002E4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x40002E5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Action<GameObject> <>9__32_0;

			[Token(Token = "0x40002E6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public static Action<GameObject> <>9__32_1;

			[Token(Token = "0x60001D9")]
			[Address(RVA = "0x11818D0", Offset = "0x11818D0", VA = "0x11818D0")]
			public <>c()
			{
			}

			[Token(Token = "0x60001DA")]
			[Address(RVA = "0x11818D8", Offset = "0x11818D8", VA = "0x11818D8")]
			internal void <ClearPreviousObjects>b__32_0(GameObject x)
			{
			}

			[Token(Token = "0x60001DB")]
			[Address(RVA = "0x1181958", Offset = "0x1181958", VA = "0x1181958")]
			internal void <ClearPreviousObjects>b__32_1(GameObject x)
			{
			}
		}

		[Token(Token = "0x40002C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject bigDotPrefab;

		[Token(Token = "0x40002C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject smallDotPrefab;

		[Token(Token = "0x40002CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Transform _bigDotsContainer;

		[Token(Token = "0x40002CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Transform _smallDotsContainer;

		[Token(Token = "0x40002CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private List<GameObject> _bigDotsGameObjects;

		[Token(Token = "0x40002CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private List<GameObject> _smallDotsGameObjects;

		[Token(Token = "0x40002CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x8CBD00", Offset = "0x8CBD00")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8CBD00", Offset = "0x8CBD00")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8CBD00", Offset = "0x8CBD00")]
		public int bigDotCount;

		[Token(Token = "0x40002CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8CBD78", Offset = "0x8CBD78")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8CBD78", Offset = "0x8CBD78")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x8CBD78", Offset = "0x8CBD78")]
		public int smallDotCount;

		[Token(Token = "0x40002D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x8CBDF0", Offset = "0x8CBDF0")]
		public float rotationSpeed;

		[Token(Token = "0x40002D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public float bigDotsRadius;

		[Token(Token = "0x40002D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public float smallDotsRadius;

		[Token(Token = "0x40002D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x8CBE28", Offset = "0x8CBE28")]
		public float animationSpeed;

		[Token(Token = "0x40002D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public float bigRadiusVariation;

		[Token(Token = "0x40002D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public float iterationOffset;

		[Token(Token = "0x40002D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public float sinusMultiplier;

		[Token(Token = "0x40002D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public float cosinusMultiplier;

		[Token(Token = "0x40002D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x8CBE60", Offset = "0x8CBE60")]
		public float waverSpeed;

		[Token(Token = "0x40002D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		public float bigDotsRadiusWaver;

		[Token(Token = "0x40002DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private WaveCreator _bigDotsWaver;

		[Token(Token = "0x40002DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public float smallDotsRadiusWaver;

		[Token(Token = "0x40002DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private WaveCreator _smallDotsWaver;

		[Token(Token = "0x40002DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public float bigRadiusVariationWaver;

		[Token(Token = "0x40002DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private WaveCreator _bigRadiusWaver;

		[Token(Token = "0x40002DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public float sinusMultiplierWaver;

		[Token(Token = "0x40002E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private WaveCreator _sinusWaver;

		[Token(Token = "0x40002E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public float cosinusMultiplierWaver;

		[Token(Token = "0x40002E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private WaveCreator _cosinusWaver;

		[Token(Token = "0x40002E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private float _time;

		[Token(Token = "0x60001CD")]
		[Address(RVA = "0x1A94D44", Offset = "0x1A94D44", VA = "0x1A94D44")]
		private void Start()
		{
		}

		[Token(Token = "0x60001CE")]
		[Address(RVA = "0x1A957D8", Offset = "0x1A957D8", VA = "0x1A957D8")]
		public void ModifyBigDotCount(int amount)
		{
		}

		[Token(Token = "0x60001CF")]
		[Address(RVA = "0x1A95874", Offset = "0x1A95874", VA = "0x1A95874")]
		public void ModifySmallDotCount(int amount)
		{
		}

		[Token(Token = "0x60001D0")]
		[Address(RVA = "0x1A953B0", Offset = "0x1A953B0", VA = "0x1A953B0")]
		private void CreateDotObjects()
		{
		}

		[Token(Token = "0x60001D1")]
		[Address(RVA = "0x1A9518C", Offset = "0x1A9518C", VA = "0x1A9518C")]
		private void ClearPreviousObjects()
		{
		}

		[Token(Token = "0x60001D2")]
		[Address(RVA = "0x1A95090", Offset = "0x1A95090", VA = "0x1A95090")]
		private void SetupWaveCreator()
		{
		}

		[Token(Token = "0x60001D3")]
		[Address(RVA = "0x1A94E08", Offset = "0x1A94E08", VA = "0x1A94E08")]
		private void SetupContainer()
		{
		}

		[Token(Token = "0x60001D4")]
		[Address(RVA = "0x1A95910", Offset = "0x1A95910", VA = "0x1A95910")]
		private void Update()
		{
		}

		[Token(Token = "0x60001D5")]
		[Address(RVA = "0x1A95D00", Offset = "0x1A95D00", VA = "0x1A95D00")]
		private void AnimatingDots(float cosD, float bigD, float bigRadD, float sinD)
		{
		}

		[Token(Token = "0x60001D6")]
		[Address(RVA = "0x1A95AD4", Offset = "0x1A95AD4", VA = "0x1A95AD4")]
		private void RotatingDots(float smallD)
		{
		}

		[Token(Token = "0x60001D7")]
		[Address(RVA = "0x1A95E64", Offset = "0x1A95E64", VA = "0x1A95E64")]
		public FloatingSurround()
		{
		}
	}
	[Token(Token = "0x200007E")]
	public class WaveCreator
	{
		[Token(Token = "0x40002E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float time;

		[Token(Token = "0x40002E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public float timeSpeed;

		[Token(Token = "0x60001DC")]
		[Address(RVA = "0x1179B40", Offset = "0x1179B40", VA = "0x1179B40")]
		public WaveCreator()
		{
		}

		[Token(Token = "0x60001DD")]
		[Address(RVA = "0x1179B80", Offset = "0x1179B80", VA = "0x1179B80")]
		public float GetValue()
		{
			return default(float);
		}
	}
}
namespace FIMSpace
{
	[Token(Token = "0x200007F")]
	public static class FAnimatorMethods
	{
		[Token(Token = "0x60001DE")]
		[Address(RVA = "0x1E81B88", Offset = "0x1E81B88", VA = "0x1E81B88")]
		public static void LerpFloatValue(this Animator animator, string name = "RunWalk", float value = 0f, float deltaSpeed = 8f)
		{
		}

		[Token(Token = "0x60001DF")]
		[Address(RVA = "0x1E81C00", Offset = "0x1E81C00", VA = "0x1E81C00")]
		public static bool CheckAnimationEnd(this Animator animator, int layer = 0, bool reverse = false, bool checkAnimLoop = true)
		{
			return default(bool);
		}

		[Token(Token = "0x60001E0")]
		[Address(RVA = "0x1E81CDC", Offset = "0x1E81CDC", VA = "0x1E81CDC")]
		public static void ResetLayersWeights(this Animator animator, float speed = 10f)
		{
		}

		[Token(Token = "0x60001E1")]
		[Address(RVA = "0x1E81D78", Offset = "0x1E81D78", VA = "0x1E81D78")]
		public static void LerpLayerWeight(this Animator animator, int layer = 0, float newValue = 1f, float speed = 8f)
		{
		}

		[Token(Token = "0x60001E2")]
		[Address(RVA = "0x1E81010", Offset = "0x1E81010", VA = "0x1E81010")]
		public static bool StateExists(this Animator animator, string clipName, int layer = 0)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x2000080")]
	public static class FColorMethods
	{
		[Token(Token = "0x60001E3")]
		[Address(RVA = "0x1E843DC", Offset = "0x1E843DC", VA = "0x1E843DC")]
		public static Color ChangeColorAlpha(this Color color, float alpha)
		{
			return default(Color);
		}

		[Token(Token = "0x60001E4")]
		[Address(RVA = "0x1E84410", Offset = "0x1E84410", VA = "0x1E84410")]
		public static Color ChangeColorsValue(this Color color, float brightenOrDarken = 0f)
		{
			return default(Color);
		}

		[Token(Token = "0x60001E5")]
		[Address(RVA = "0x1E8444C", Offset = "0x1E8444C", VA = "0x1E8444C")]
		public static Color32 HexToColor(this string hex)
		{
			return default(Color32);
		}

		[Token(Token = "0x60001E6")]
		[Address(RVA = "0x1E846A0", Offset = "0x1E846A0", VA = "0x1E846A0")]
		public static string ColorToHex(this Color32 color, bool addHash = true)
		{
			return null;
		}

		[Token(Token = "0x60001E7")]
		[Address(RVA = "0x1E849E0", Offset = "0x1E849E0", VA = "0x1E849E0")]
		public static string ColorToHex(this Color color, bool addHash = true)
		{
			return null;
		}

		[Token(Token = "0x60001E8")]
		[Address(RVA = "0x1E84A60", Offset = "0x1E84A60", VA = "0x1E84A60")]
		public static void LerpMaterialColor(this Material mat, string property, Color targetColor, float deltaMultiplier = 8f)
		{
		}
	}
	[Token(Token = "0x2000081")]
	public static class FDebug
	{
		[Token(Token = "0x60001E9")]
		[Address(RVA = "0x1E84E20", Offset = "0x1E84E20", VA = "0x1E84E20")]
		public static void Log(string log)
		{
		}

		[Token(Token = "0x60001EA")]
		[Address(RVA = "0x1E84EB0", Offset = "0x1E84EB0", VA = "0x1E84EB0")]
		public static void Log(string log, string category)
		{
		}

		[Token(Token = "0x60001EB")]
		[Address(RVA = "0x1E845D0", Offset = "0x1E845D0", VA = "0x1E845D0")]
		public static void LogRed(string log)
		{
		}

		[Token(Token = "0x60001EC")]
		[Address(RVA = "0x1E85230", Offset = "0x1E85230", VA = "0x1E85230")]
		public static void LogOrange(string log)
		{
		}

		[Token(Token = "0x60001ED")]
		[Address(RVA = "0x1E85300", Offset = "0x1E85300", VA = "0x1E85300")]
		public static void LogYellow(string log)
		{
		}

		[Token(Token = "0x60001EE")]
		[Address(RVA = "0x1E85184", Offset = "0x1E85184", VA = "0x1E85184")]
		public static string MarkerColor(string color)
		{
			return null;
		}

		[Token(Token = "0x60001EF")]
		[Address(RVA = "0x1E851EC", Offset = "0x1E851EC", VA = "0x1E851EC")]
		public static string EndColorMarker()
		{
			return null;
		}

		[Token(Token = "0x60001F0")]
		[Address(RVA = "0x1E853D0", Offset = "0x1E853D0", VA = "0x1E853D0")]
		public static void DrawBounds2D(this Bounds b, Color c, float y = 0f, float scale = 1f)
		{
		}

		[Token(Token = "0x60001F1")]
		[Address(RVA = "0x1E85618", Offset = "0x1E85618", VA = "0x1E85618")]
		public static void DrawBounds3D(this Bounds b, Color c, float scale = 1f)
		{
		}
	}
	[Token(Token = "0x2000082")]
	public static class FStringMethods
	{
		[Token(Token = "0x60001F2")]
		[Address(RVA = "0x1A91918", Offset = "0x1A91918", VA = "0x1A91918")]
		public static string IntToString(this int value, int signs)
		{
			return null;
		}

		[Token(Token = "0x60001F3")]
		[Address(RVA = "0x1A919EC", Offset = "0x1A919EC", VA = "0x1A919EC")]
		public static string CapitalizeOnlyFirstLetter(this string text)
		{
			return null;
		}

		[Token(Token = "0x60001F4")]
		[Address(RVA = "0x1A91AC0", Offset = "0x1A91AC0", VA = "0x1A91AC0")]
		public static string CapitalizeFirstLetter(this string text)
		{
			return null;
		}

		[Token(Token = "0x60001F5")]
		[Address(RVA = "0x1A91B54", Offset = "0x1A91B54", VA = "0x1A91B54")]
		public static string ReplaceSpacesWithUnderline(this string text)
		{
			return null;
		}

		[Token(Token = "0x60001F6")]
		[Address(RVA = "0x1A91BE8", Offset = "0x1A91BE8", VA = "0x1A91BE8")]
		public static string GetEndOfStringFromSeparator(this string source, char[] separators, int which = 1, bool fromEnd = false)
		{
			return null;
		}

		[Token(Token = "0x60001F7")]
		[Address(RVA = "0x1A91D38", Offset = "0x1A91D38", VA = "0x1A91D38")]
		public static string GetEndOfStringFromStringSeparator(this string source, string[] separators, int which = 1, bool rest = false)
		{
			return null;
		}
	}
	[Token(Token = "0x2000083")]
	public static class FEngineering
	{
		[Token(Token = "0x40002E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static Plane axis2DProjection;

		[Token(Token = "0x40002EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static PhysicMaterial _slidingMat;

		[Token(Token = "0x40002EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static PhysicMaterial _frictMat;

		[Token(Token = "0x40002EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static PhysicsMaterial2D _slidingMat2D;

		[Token(Token = "0x40002ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static PhysicsMaterial2D _frictMat2D;

		[Token(Token = "0x17000029")]
		public static PhysicMaterial PMSliding
		{
			[Token(Token = "0x6000216")]
			[Address(RVA = "0x1E88420", Offset = "0x1E88420", VA = "0x1E88420")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700002A")]
		public static PhysicMaterial PMFrict
		{
			[Token(Token = "0x6000217")]
			[Address(RVA = "0x1E88560", Offset = "0x1E88560", VA = "0x1E88560")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700002B")]
		public static PhysicsMaterial2D PMSliding2D
		{
			[Token(Token = "0x6000218")]
			[Address(RVA = "0x1E886A0", Offset = "0x1E886A0", VA = "0x1E886A0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700002C")]
		public static PhysicsMaterial2D PMFrict2D
		{
			[Token(Token = "0x6000219")]
			[Address(RVA = "0x1E887A8", Offset = "0x1E887A8", VA = "0x1E887A8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001F8")]
		[Address(RVA = "0x1E871C0", Offset = "0x1E871C0", VA = "0x1E871C0")]
		public static bool VIsZero(this Vector3 vec)
		{
			return default(bool);
		}

		[Token(Token = "0x60001F9")]
		[Address(RVA = "0x1E871F4", Offset = "0x1E871F4", VA = "0x1E871F4")]
		public static bool VIsSame(this Vector3 vec1, Vector3 vec2)
		{
			return default(bool);
		}

		[Token(Token = "0x60001FA")]
		[Address(RVA = "0x1E87218", Offset = "0x1E87218", VA = "0x1E87218")]
		public static Vector3 TransformVector(this Quaternion parentRot, Vector3 parentLossyScale, Vector3 childLocalPos)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60001FB")]
		[Address(RVA = "0x1E87234", Offset = "0x1E87234", VA = "0x1E87234")]
		public static Vector3 TransformInDirection(this Quaternion childRotation, Vector3 parentLossyScale, Vector3 childLocalPos)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60001FC")]
		[Address(RVA = "0x1E87268", Offset = "0x1E87268", VA = "0x1E87268")]
		public static Vector3 InverseTransformVector(this Quaternion tRotation, Vector3 tLossyScale, Vector3 worldPos)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60001FD")]
		[Address(RVA = "0x1E872CC", Offset = "0x1E872CC", VA = "0x1E872CC")]
		public static Vector3 VAxis2DLimit(this Transform parent, Vector3 parentPos, Vector3 childPos, int axis = 3)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60001FE")]
		[Address(RVA = "0x1E873FC", Offset = "0x1E873FC", VA = "0x1E873FC")]
		public static Quaternion QToLocal(this Quaternion parentRotation, Quaternion worldRotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60001FF")]
		[Address(RVA = "0x1E87448", Offset = "0x1E87448", VA = "0x1E87448")]
		public static Quaternion QToWorld(this Quaternion parentRotation, Quaternion localRotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000200")]
		[Address(RVA = "0x1E87450", Offset = "0x1E87450", VA = "0x1E87450")]
		public static Quaternion QRotateChild(this Quaternion offset, Quaternion parentRot, Quaternion childLocalRot)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000201")]
		[Address(RVA = "0x1E87494", Offset = "0x1E87494", VA = "0x1E87494")]
		public static Quaternion ClampRotation(this Vector3 current, Vector3 bounds)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000202")]
		[Address(RVA = "0x1E875AC", Offset = "0x1E875AC", VA = "0x1E875AC")]
		public static Vector3 QToAngularVelocity(this Quaternion deltaRotation, bool fix = false)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000203")]
		[Address(RVA = "0x1E876B4", Offset = "0x1E876B4", VA = "0x1E876B4")]
		public static Vector3 QToAngularVelocity(this Quaternion currentRotation, Quaternion targetRotation, bool fix = false)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000204")]
		[Address(RVA = "0x1E87724", Offset = "0x1E87724", VA = "0x1E87724")]
		public static bool QIsZero(this Quaternion rot)
		{
			return default(bool);
		}

		[Token(Token = "0x6000205")]
		[Address(RVA = "0x1E87748", Offset = "0x1E87748", VA = "0x1E87748")]
		public static bool QIsSame(this Quaternion rot1, Quaternion rot2)
		{
			return default(bool);
		}

		[Token(Token = "0x6000206")]
		[Address(RVA = "0x1E87774", Offset = "0x1E87774", VA = "0x1E87774")]
		public static float WrapAngle(float angle)
		{
			return default(float);
		}

		[Token(Token = "0x6000207")]
		[Address(RVA = "0x1E87518", Offset = "0x1E87518", VA = "0x1E87518")]
		public static Vector3 WrapVector(Vector3 angles)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000208")]
		[Address(RVA = "0x1E877AC", Offset = "0x1E877AC", VA = "0x1E877AC")]
		public static float UnwrapAngle(float angle)
		{
			return default(float);
		}

		[Token(Token = "0x6000209")]
		[Address(RVA = "0x1E877E4", Offset = "0x1E877E4", VA = "0x1E877E4")]
		public static Vector3 UnwrapVector(Vector3 angles)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600020A")]
		[Address(RVA = "0x1E8787C", Offset = "0x1E8787C", VA = "0x1E8787C")]
		public static Quaternion SmoothDampRotation(this Quaternion current, Quaternion target, ref Quaternion velocityRef, float duration, float delta)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600020B")]
		[Address(RVA = "0x1E878B0", Offset = "0x1E878B0", VA = "0x1E878B0")]
		public static Quaternion SmoothDampRotation(this Quaternion current, Quaternion target, ref Quaternion velocityRef, float duration, float maxSpeed, float delta)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600020C")]
		[Address(RVA = "0x1E87AD4", Offset = "0x1E87AD4", VA = "0x1E87AD4")]
		public static bool SameDirection(this float a, float b)
		{
			return default(bool);
		}

		[Token(Token = "0x600020D")]
		[Address(RVA = "0x1E87B04", Offset = "0x1E87B04", VA = "0x1E87B04")]
		public static float PointDisperse01(int index, int baseV = 2)
		{
			return default(float);
		}

		[Token(Token = "0x600020E")]
		[Address(RVA = "0x1E87B7C", Offset = "0x1E87B7C", VA = "0x1E87B7C")]
		public static float PointDisperse(int index, int baseV = 2)
		{
			return default(float);
		}

		[Token(Token = "0x600020F")]
		[Address(RVA = "0x1E87BF8", Offset = "0x1E87BF8", VA = "0x1E87BF8")]
		public static float GetScaler(this Transform transform)
		{
			return default(float);
		}

		[Token(Token = "0x6000210")]
		[Address(RVA = "0x1E87C88", Offset = "0x1E87C88", VA = "0x1E87C88")]
		public static Vector3 PosFromMatrix(this Matrix4x4 m)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000211")]
		[Address(RVA = "0x1E87CA8", Offset = "0x1E87CA8", VA = "0x1E87CA8")]
		public static Quaternion RotFromMatrix(this Matrix4x4 m)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000212")]
		[Address(RVA = "0x1E87D28", Offset = "0x1E87D28", VA = "0x1E87D28")]
		public static Vector3 ScaleFromMatrix(this Matrix4x4 m)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000213")]
		[Address(RVA = "0x1E87DD0", Offset = "0x1E87DD0", VA = "0x1E87DD0")]
		public static Bounds RotateBoundsByMatrix(this Bounds b, Quaternion rotation)
		{
			return default(Bounds);
		}

		[Token(Token = "0x6000214")]
		[Address(RVA = "0x1E881B0", Offset = "0x1E881B0", VA = "0x1E881B0")]
		public static Bounds RotateLocalBounds(this Bounds b, Quaternion rotation)
		{
			return default(Bounds);
		}

		[Token(Token = "0x6000215")]
		[Address(RVA = "0x1E8832C", Offset = "0x1E8832C", VA = "0x1E8832C")]
		public static int[] GetLayermaskValues(int mask, int optionsCount)
		{
			return null;
		}
	}
	[Token(Token = "0x2000084")]
	public static class FLogicMethods
	{
		[Token(Token = "0x600021A")]
		[Address(RVA = "0x2038368", Offset = "0x2038368", VA = "0x2038368")]
		public static float Lerp(this float from, float to, float value)
		{
			return default(float);
		}

		[Token(Token = "0x600021B")]
		[Address(RVA = "0x2038394", Offset = "0x2038394", VA = "0x2038394")]
		public static float InverseLerp(float from, float to, float value)
		{
			return default(float);
		}

		[Token(Token = "0x600021C")]
		[Address(RVA = "0x20383C0", Offset = "0x20383C0", VA = "0x20383C0")]
		public static float InverseLerpUnclamped(float xx, float yy, float value)
		{
			return default(float);
		}

		[Token(Token = "0x600021D")]
		[Address(RVA = "0x20383E0", Offset = "0x20383E0", VA = "0x20383E0")]
		public static float FLerp(float a, float b, float t, float factor = 0.01f)
		{
			return default(float);
		}

		[Token(Token = "0x600021E")]
		[Address(RVA = "0x2038438", Offset = "0x2038438", VA = "0x2038438")]
		public static int IntLerp(int a, int b, float t)
		{
			return default(int);
		}

		[Token(Token = "0x600021F")]
		[Address(RVA = "0x2038490", Offset = "0x2038490", VA = "0x2038490")]
		public static void IntLerp(ref int source, int a, int b, float t)
		{
		}

		[Token(Token = "0x6000220")]
		[Address(RVA = "0x20384F8", Offset = "0x20384F8", VA = "0x20384F8")]
		public static void IntLerp(ref int source, int b, float t)
		{
		}

		[Token(Token = "0x6000221")]
		[Address(RVA = "0x2038564", Offset = "0x2038564", VA = "0x2038564")]
		public static float FAbs(this float value)
		{
			return default(float);
		}

		[Token(Token = "0x6000222")]
		[Address(RVA = "0x2038574", Offset = "0x2038574", VA = "0x2038574")]
		public static float HyperCurve(this float value)
		{
			return default(float);
		}

		[Token(Token = "0x6000223")]
		[Address(RVA = "0x203859C", Offset = "0x203859C", VA = "0x203859C")]
		public static float TopDownDistanceManhattan(this Vector3 a, Vector3 b)
		{
			return default(float);
		}

		[Token(Token = "0x6000224")]
		[Address(RVA = "0x20385CC", Offset = "0x20385CC", VA = "0x20385CC")]
		public static float TopDownDistance(this Vector3 a, Vector3 b)
		{
			return default(float);
		}

		[Token(Token = "0x6000225")]
		[Address(RVA = "0x20385E0", Offset = "0x20385E0", VA = "0x20385E0")]
		public static float DistanceManhattan(this Vector3 a, Vector3 b)
		{
			return default(float);
		}

		[Token(Token = "0x6000226")]
		[Address(RVA = "0x2038624", Offset = "0x2038624", VA = "0x2038624")]
		public static float WrapAngle(float angle)
		{
			return default(float);
		}

		[Token(Token = "0x6000227")]
		[Address(RVA = "0x203865C", Offset = "0x203865C", VA = "0x203865C")]
		public static Vector3 WrapVector(Vector3 angles)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000228")]
		[Address(RVA = "0x20386F0", Offset = "0x20386F0", VA = "0x20386F0")]
		public static float UnwrapAngle(float angle)
		{
			return default(float);
		}

		[Token(Token = "0x6000229")]
		[Address(RVA = "0x2038728", Offset = "0x2038728", VA = "0x2038728")]
		public static Vector3 UnwrapVector(Vector3 angles)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600022A")]
		[Address(RVA = "0x20387C0", Offset = "0x20387C0", VA = "0x20387C0")]
		public static bool IsAlmostEqual(float val, float to, int afterComma = 2, float addRange = 0f)
		{
			return default(bool);
		}

		[Token(Token = "0x600022B")]
		[Address(RVA = "0x203882C", Offset = "0x203882C", VA = "0x203882C")]
		public static Quaternion TopDownAngle(Vector3 from, Vector3 to)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600022C")]
		[Address(RVA = "0x2038840", Offset = "0x2038840", VA = "0x2038840")]
		public static Quaternion TopDownAnglePosition2D(Vector2 from, Vector2 to, float offset = 0f)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600022D")]
		public static bool ContainsIndex<T>(this List<T> list, int i, bool falseIfNull = true) where T : class
		{
			return default(bool);
		}

		[Token(Token = "0x600022E")]
		public static bool ContainsIndex<T>(this T[] list, int i, bool falseIfNull) where T : class
		{
			return default(bool);
		}
	}
	[Token(Token = "0x2000085")]
	public static class FTransformMethods
	{
		[Token(Token = "0x600022F")]
		[Address(RVA = "0x1A93D94", Offset = "0x1A93D94", VA = "0x1A93D94")]
		public static Transform FindChildByNameInDepth(string name, Transform transform, bool findInDeactivated = true, [Optional] string[] additionalContains)
		{
			return null;
		}

		[Token(Token = "0x6000230")]
		public static List<T> FindComponentsInAllChildren<T>(Transform transformToSearchIn, bool includeInactive = false) where T : Component
		{
			return null;
		}

		[Token(Token = "0x6000231")]
		public static T FindComponentInAllChildren<T>(Transform transformToSearchIn) where T : Component
		{
			return null;
		}

		[Token(Token = "0x6000232")]
		public static T FindComponentInAllParents<T>(Transform transformToSearchIn) where T : Component
		{
			return null;
		}

		[Token(Token = "0x6000233")]
		[Address(RVA = "0x1A93F40", Offset = "0x1A93F40", VA = "0x1A93F40")]
		public static void ChangeActiveChildrenInside(Transform parentOfThem, bool active)
		{
		}

		[Token(Token = "0x6000234")]
		[Address(RVA = "0x1A93FCC", Offset = "0x1A93FCC", VA = "0x1A93FCC")]
		public static void ChangeActiveThroughParentTo(Transform start, Transform end, bool active, bool changeParentsChildrenActivation = false)
		{
		}
	}
	[Token(Token = "0x2000086")]
	public static class FVectorMethods
	{
		[Token(Token = "0x6000235")]
		[Address(RVA = "0x1A940EC", Offset = "0x1A940EC", VA = "0x1A940EC")]
		public static Vector3 RandomVector(float rangeA, float rangeB)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000236")]
		[Address(RVA = "0x1A94150", Offset = "0x1A94150", VA = "0x1A94150")]
		public static float VectorSum(Vector3 vector)
		{
			return default(float);
		}

		[Token(Token = "0x6000237")]
		[Address(RVA = "0x1A9415C", Offset = "0x1A9415C", VA = "0x1A9415C")]
		public static Vector3 RandomVectorNoY(float rangeA, float rangeB)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000238")]
		[Address(RVA = "0x1A941AC", Offset = "0x1A941AC", VA = "0x1A941AC")]
		public static Vector3 RandomVectorMinMax(float min, float max)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000239")]
		[Address(RVA = "0x1A9427C", Offset = "0x1A9427C", VA = "0x1A9427C")]
		public static Vector3 RandomVectorNoYMinMax(float min, float max)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600023A")]
		[Address(RVA = "0x1A94318", Offset = "0x1A94318", VA = "0x1A94318")]
		public static Vector3 GetUIPositionFromWorldPosition(Vector3 position, Camera camera, RectTransform canvas)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600023B")]
		[Address(RVA = "0x1A943D4", Offset = "0x1A943D4", VA = "0x1A943D4")]
		public static Vector2 XOZ(this Vector3 toBeFlattened)
		{
			return default(Vector2);
		}

		[Token(Token = "0x600023C")]
		[Address(RVA = "0x1A943DC", Offset = "0x1A943DC", VA = "0x1A943DC")]
		public static float DistanceTopDown(Vector3 from, Vector3 to)
		{
			return default(float);
		}

		[Token(Token = "0x600023D")]
		[Address(RVA = "0x1A943F0", Offset = "0x1A943F0", VA = "0x1A943F0")]
		public static float DistanceTopDownManhattan(Vector3 from, Vector3 to)
		{
			return default(float);
		}

		[Token(Token = "0x600023E")]
		[Address(RVA = "0x1A94400", Offset = "0x1A94400", VA = "0x1A94400")]
		public static Vector3 ChooseDominantAxis(Vector3 axis)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600023F")]
		[Address(RVA = "0x1A94474", Offset = "0x1A94474", VA = "0x1A94474")]
		public static Vector3 GetRounded(Vector3 dir)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000240")]
		[Address(RVA = "0x1A94604", Offset = "0x1A94604", VA = "0x1A94604")]
		public static Vector3 GetCounterAxis(Vector3 axis)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000241")]
		[Address(RVA = "0x1A94618", Offset = "0x1A94618", VA = "0x1A94618")]
		public static Color GetAxisColor(Vector3 axis, float alpha = 0.75f)
		{
			return default(Color);
		}

		[Token(Token = "0x6000242")]
		[Address(RVA = "0x1A94658", Offset = "0x1A94658", VA = "0x1A94658")]
		public static Vector3 FlattenVector(Vector3 v, float to = 90f)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000243")]
		[Address(RVA = "0x1A94808", Offset = "0x1A94808", VA = "0x1A94808")]
		public static Vector3 FlattenVector(Vector3 v, Vector3 to)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000244")]
		[Address(RVA = "0x1A949C8", Offset = "0x1A949C8", VA = "0x1A949C8")]
		public static Vector3Int V3toV3Int(Vector3 v)
		{
			return default(Vector3Int);
		}

		[Token(Token = "0x6000245")]
		[Address(RVA = "0x1A94A28", Offset = "0x1A94A28", VA = "0x1A94A28")]
		public static Vector3 FlattenNormal(Quaternion orientation, [Optional] Vector3? forward, float to = 90f)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000246")]
		[Address(RVA = "0x1A94AFC", Offset = "0x1A94AFC", VA = "0x1A94AFC")]
		public static Vector3 EqualVector(float valueAll)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000247")]
		[Address(RVA = "0x1A94B08", Offset = "0x1A94B08", VA = "0x1A94B08")]
		public static Quaternion FlattenRotation(Quaternion orientation, float to = 90f)
		{
			return default(Quaternion);
		}
	}
	[Token(Token = "0x2000087")]
	public abstract class FImp_ColliderData_Base
	{
		[Token(Token = "0x2000088")]
		public enum EFColliderType
		{
			[Token(Token = "0x40002F8")]
			Box,
			[Token(Token = "0x40002F9")]
			Sphere,
			[Token(Token = "0x40002FA")]
			Capsule,
			[Token(Token = "0x40002FB")]
			Mesh,
			[Token(Token = "0x40002FC")]
			Terrain
		}

		[Token(Token = "0x40002EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8CBE98", Offset = "0x8CBE98")]
		private Transform <Transform>k__BackingField;

		[Token(Token = "0x40002EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8CBEA8", Offset = "0x8CBEA8")]
		private Collider <Collider>k__BackingField;

		[Token(Token = "0x40002F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8CBEB8", Offset = "0x8CBEB8")]
		private Collider2D <Collider2D>k__BackingField;

		[Token(Token = "0x40002F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool Is2D;

		[Token(Token = "0x40002F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8CBEC8", Offset = "0x8CBEC8")]
		private bool <IsStatic>k__BackingField;

		[Token(Token = "0x40002F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8CBED8", Offset = "0x8CBED8")]
		private EFColliderType <ColliderType>k__BackingField;

		[Token(Token = "0x40002F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		protected Vector3 previousPosition;

		[Token(Token = "0x40002F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		protected Quaternion previousRotation;

		[Token(Token = "0x40002F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		protected Vector3 previousScale;

		[Token(Token = "0x1700002D")]
		public Transform Transform
		{
			[Token(Token = "0x6000248")]
			[Address(RVA = "0x1E8A174", Offset = "0x1E8A174", VA = "0x1E8A174")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8D1A6C", Offset = "0x8D1A6C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000249")]
			[Address(RVA = "0x1E8A17C", Offset = "0x1E8A17C", VA = "0x1E8A17C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8D1A7C", Offset = "0x8D1A7C")]
			protected set
			{
			}
		}

		[Token(Token = "0x1700002E")]
		public Collider Collider
		{
			[Token(Token = "0x600024A")]
			[Address(RVA = "0x1E8A184", Offset = "0x1E8A184", VA = "0x1E8A184")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8D1A8C", Offset = "0x8D1A8C")]
			get
			{
				return null;
			}
			[Token(Token = "0x600024B")]
			[Address(RVA = "0x1E8A18C", Offset = "0x1E8A18C", VA = "0x1E8A18C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8D1A9C", Offset = "0x8D1A9C")]
			protected set
			{
			}
		}

		[Token(Token = "0x1700002F")]
		public Collider2D Collider2D
		{
			[Token(Token = "0x600024C")]
			[Address(RVA = "0x1E8A194", Offset = "0x1E8A194", VA = "0x1E8A194")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8D1AAC", Offset = "0x8D1AAC")]
			get
			{
				return null;
			}
			[Token(Token = "0x600024D")]
			[Address(RVA = "0x1E8A19C", Offset = "0x1E8A19C", VA = "0x1E8A19C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8D1ABC", Offset = "0x8D1ABC")]
			protected set
			{
			}
		}

		[Token(Token = "0x17000030")]
		public bool IsStatic
		{
			[Token(Token = "0x600024E")]
			[Address(RVA = "0x1E8A1A4", Offset = "0x1E8A1A4", VA = "0x1E8A1A4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8D1ACC", Offset = "0x8D1ACC")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600024F")]
			[Address(RVA = "0x1E8A1AC", Offset = "0x1E8A1AC", VA = "0x1E8A1AC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8D1ADC", Offset = "0x8D1ADC")]
			private set
			{
			}
		}

		[Token(Token = "0x17000031")]
		public EFColliderType ColliderType
		{
			[Token(Token = "0x6000250")]
			[Address(RVA = "0x1E8A1B8", Offset = "0x1E8A1B8", VA = "0x1E8A1B8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8D1AEC", Offset = "0x8D1AEC")]
			get
			{
				return default(EFColliderType);
			}
			[Token(Token = "0x6000251")]
			[Address(RVA = "0x1E8A1C0", Offset = "0x1E8A1C0", VA = "0x1E8A1C0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8D1AFC", Offset = "0x8D1AFC")]
			protected set
			{
			}
		}

		[Token(Token = "0x6000252")]
		[Address(RVA = "0x1E8A1C8", Offset = "0x1E8A1C8", VA = "0x1E8A1C8")]
		public static FImp_ColliderData_Base GetColliderDataFor(Collider collider)
		{
			return null;
		}

		[Token(Token = "0x6000253")]
		[Address(RVA = "0x1E8A71C", Offset = "0x1E8A71C", VA = "0x1E8A71C")]
		public static FImp_ColliderData_Base GetColliderDataFor(Collider2D collider)
		{
			return null;
		}

		[Token(Token = "0x6000254")]
		[Address(RVA = "0x1E8AB5C", Offset = "0x1E8AB5C", VA = "0x1E8AB5C", Slot = "4")]
		public virtual void RefreshColliderData()
		{
		}

		[Token(Token = "0x6000255")]
		[Address(RVA = "0x1E8ABA0", Offset = "0x1E8ABA0", VA = "0x1E8ABA0", Slot = "5")]
		public virtual bool PushIfInside(ref Vector3 point, float pointRadius, Vector3 pointOffset)
		{
			return default(bool);
		}

		[Token(Token = "0x6000256")]
		[Address(RVA = "0x1E8ACB0", Offset = "0x1E8ACB0", VA = "0x1E8ACB0", Slot = "6")]
		public virtual bool PushIfInside2D(ref Vector3 point, float pointRadius, Vector3 pointOffset)
		{
			return default(bool);
		}

		[Token(Token = "0x6000257")]
		[Address(RVA = "0x1E8ACBC", Offset = "0x1E8ACBC", VA = "0x1E8ACBC")]
		public static bool VIsSame(Vector3 vec1, Vector3 vec2)
		{
			return default(bool);
		}

		[Token(Token = "0x6000258")]
		[Address(RVA = "0x1E8ACE0", Offset = "0x1E8ACE0", VA = "0x1E8ACE0")]
		protected FImp_ColliderData_Base()
		{
		}
	}
	[Token(Token = "0x2000089")]
	public class FImp_ColliderData_Box : FImp_ColliderData_Base
	{
		[Token(Token = "0x40002FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8CBEE8", Offset = "0x8CBEE8")]
		private BoxCollider <Box>k__BackingField;

		[Token(Token = "0x40002FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8CBEF8", Offset = "0x8CBEF8")]
		private BoxCollider2D <Box2D>k__BackingField;

		[Token(Token = "0x40002FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Vector3 boxCenter;

		[Token(Token = "0x4000300")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private Vector3 right;

		[Token(Token = "0x4000301")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Vector3 up;

		[Token(Token = "0x4000302")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private Vector3 forward;

		[Token(Token = "0x4000303")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Vector3 rightN;

		[Token(Token = "0x4000304")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		private Vector3 upN;

		[Token(Token = "0x4000305")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Vector3 forwardN;

		[Token(Token = "0x4000306")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		private Vector3 scales;

		[Token(Token = "0x17000032")]
		public BoxCollider Box
		{
			[Token(Token = "0x6000259")]
			[Address(RVA = "0x1E8AD34", Offset = "0x1E8AD34", VA = "0x1E8AD34")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8D1B0C", Offset = "0x8D1B0C")]
			get
			{
				return null;
			}
			[Token(Token = "0x600025A")]
			[Address(RVA = "0x1E8AD3C", Offset = "0x1E8AD3C", VA = "0x1E8AD3C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8D1B1C", Offset = "0x8D1B1C")]
			private set
			{
			}
		}

		[Token(Token = "0x17000033")]
		public BoxCollider2D Box2D
		{
			[Token(Token = "0x600025B")]
			[Address(RVA = "0x1E8AD44", Offset = "0x1E8AD44", VA = "0x1E8AD44")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8D1B2C", Offset = "0x8D1B2C")]
			get
			{
				return null;
			}
			[Token(Token = "0x600025C")]
			[Address(RVA = "0x1E8AD4C", Offset = "0x1E8AD4C", VA = "0x1E8AD4C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8D1B3C", Offset = "0x8D1B3C")]
			private set
			{
			}
		}

		[Token(Token = "0x600025D")]
		[Address(RVA = "0x1E8A604", Offset = "0x1E8A604", VA = "0x1E8A604")]
		public FImp_ColliderData_Box(BoxCollider collider)
		{
		}

		[Token(Token = "0x600025E")]
		[Address(RVA = "0x1E8AA40", Offset = "0x1E8AA40", VA = "0x1E8AA40")]
		public FImp_ColliderData_Box(BoxCollider2D collider2D)
		{
		}

		[Token(Token = "0x600025F")]
		[Address(RVA = "0x1E8AD54", Offset = "0x1E8AD54", VA = "0x1E8AD54", Slot = "4")]
		public override void RefreshColliderData()
		{
		}

		[Token(Token = "0x6000260")]
		[Address(RVA = "0x1E8B378", Offset = "0x1E8B378", VA = "0x1E8B378", Slot = "5")]
		public override bool PushIfInside(ref Vector3 segmentPosition, float segmentRadius, Vector3 segmentOffset)
		{
			return default(bool);
		}

		[Token(Token = "0x6000261")]
		[Address(RVA = "0x1E8BE00", Offset = "0x1E8BE00", VA = "0x1E8BE00")]
		public static void PushOutFromBoxCollider(BoxCollider box, Collision collision, float segmentColliderRadius, ref Vector3 segmentPosition, bool is2D = false)
		{
		}

		[Token(Token = "0x6000262")]
		[Address(RVA = "0x1E8C464", Offset = "0x1E8C464", VA = "0x1E8C464")]
		public static void PushOutFromBoxCollider(BoxCollider box, float segmentColliderRadius, ref Vector3 segmentPosition, bool is2D = false)
		{
		}

		[Token(Token = "0x6000263")]
		[Address(RVA = "0x1E8C0C0", Offset = "0x1E8C0C0", VA = "0x1E8C0C0")]
		public static void PushOutFromBoxCollider(BoxCollider box, Collision collision, float segmentColliderRadius, ref Vector3 pos, Vector3 right, Vector3 up, Vector3 forward, Vector3 scales, bool is2D = false)
		{
		}

		[Token(Token = "0x6000264")]
		[Address(RVA = "0x1E8D280", Offset = "0x1E8D280", VA = "0x1E8D280")]
		public static void PushOutFromBoxCollider(BoxCollider2D box2D, float segmentColliderRadius, ref Vector3 segmentPosition)
		{
		}

		[Token(Token = "0x6000265")]
		[Address(RVA = "0x1E8BA64", Offset = "0x1E8BA64", VA = "0x1E8BA64")]
		private Vector3 GetNearestPoint(Vector3 point)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000266")]
		[Address(RVA = "0x1E8CB3C", Offset = "0x1E8CB3C", VA = "0x1E8CB3C")]
		private static Vector3 GetNearestPoint(Vector3 point, Vector3 boxCenter, Vector3 right, Vector3 up, Vector3 forward, bool is2D = false)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000267")]
		[Address(RVA = "0x1E8D704", Offset = "0x1E8D704", VA = "0x1E8D704")]
		private static Vector3 GetNearestPoint2D(Vector2 point, Vector2 boxCenter, Vector2 right, Vector2 up)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000268")]
		[Address(RVA = "0x1E8D914", Offset = "0x1E8D914", VA = "0x1E8D914")]
		public static Vector3 GetNearestPointOnBox(BoxCollider boxCollider, Vector3 point, bool is2D = false)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000269")]
		[Address(RVA = "0x1E8B81C", Offset = "0x1E8B81C", VA = "0x1E8B81C")]
		private static float PlaneDistance(Vector3 planeCenter, Vector3 planeNormal, Vector3 point)
		{
			return default(float);
		}

		[Token(Token = "0x600026A")]
		[Address(RVA = "0x1E8D8B0", Offset = "0x1E8D8B0", VA = "0x1E8D8B0")]
		private static Vector3 ProjectPointOnPlane(Vector3 planeNormal, Vector3 point, float distance)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600026B")]
		[Address(RVA = "0x1E8B848", Offset = "0x1E8B848", VA = "0x1E8B848")]
		private static bool SphereInsidePlane(float planeDistance, float pointRadius)
		{
			return default(bool);
		}

		[Token(Token = "0x600026C")]
		[Address(RVA = "0x1E8DD30", Offset = "0x1E8DD30", VA = "0x1E8DD30")]
		private static bool SphereOutsidePlane(float planeDistance, float pointRadius)
		{
			return default(bool);
		}

		[Token(Token = "0x600026D")]
		[Address(RVA = "0x1E8B858", Offset = "0x1E8B858", VA = "0x1E8B858")]
		private static bool SphereIntersectsPlane(float planeDistance, float pointRadius)
		{
			return default(bool);
		}

		[Token(Token = "0x600026E")]
		[Address(RVA = "0x1E8B868", Offset = "0x1E8B868", VA = "0x1E8B868")]
		public static bool IsInsideBoxCollider(BoxCollider collider, Vector3 point, bool is2D = false)
		{
			return default(bool);
		}

		[Token(Token = "0x600026F")]
		[Address(RVA = "0x1E8B984", Offset = "0x1E8B984", VA = "0x1E8B984")]
		public static bool IsInsideBoxCollider(BoxCollider2D collider, Vector3 point)
		{
			return default(bool);
		}

		[Token(Token = "0x6000270")]
		[Address(RVA = "0x1E8CF20", Offset = "0x1E8CF20", VA = "0x1E8CF20")]
		protected static float GetBoxAverageScale(BoxCollider box)
		{
			return default(float);
		}

		[Token(Token = "0x6000271")]
		[Address(RVA = "0x1E8B25C", Offset = "0x1E8B25C", VA = "0x1E8B25C")]
		protected static Vector3 GetBoxCenter(BoxCollider box)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000272")]
		[Address(RVA = "0x1E8B2E8", Offset = "0x1E8B2E8", VA = "0x1E8B2E8")]
		protected static Vector3 GetBoxCenter(BoxCollider2D box)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000273")]
		[Address(RVA = "0x1E8DD3C", Offset = "0x1E8DD3C", VA = "0x1E8DD3C")]
		protected static Vector3 GetTargetPlaneNormal(BoxCollider boxCollider, Vector3 point, bool is2D = false)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000274")]
		[Address(RVA = "0x1E8CF9C", Offset = "0x1E8CF9C", VA = "0x1E8CF9C")]
		protected static Vector3 GetTargetPlaneNormal(BoxCollider boxCollider, Vector3 point, Vector3 right, Vector3 up, Vector3 forward, Vector3 scales, bool is2D = false)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000275")]
		[Address(RVA = "0x1E8DFA0", Offset = "0x1E8DFA0", VA = "0x1E8DFA0")]
		protected static Vector3 GetTargetPlaneNormal(BoxCollider2D boxCollider, Vector2 point, Vector2 right, Vector2 up, Vector2 scales)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000276")]
		[Address(RVA = "0x1E8D170", Offset = "0x1E8D170", VA = "0x1E8D170")]
		protected static Vector3 GetIntersectOnBoxFromInside(BoxCollider boxCollider, Vector3 from, Vector3 to, Vector3 planeNormal)
		{
			return default(Vector3);
		}
	}
	[Token(Token = "0x200008A")]
	public class FImp_ColliderData_Capsule : FImp_ColliderData_Base
	{
		[Token(Token = "0x4000307")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8CBF08", Offset = "0x8CBF08")]
		private CapsuleCollider <Capsule>k__BackingField;

		[Token(Token = "0x4000308")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8CBF18", Offset = "0x8CBF18")]
		private CapsuleCollider2D <Capsule2D>k__BackingField;

		[Token(Token = "0x4000309")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Vector3 Top;

		[Token(Token = "0x400030A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private Vector3 Bottom;

		[Token(Token = "0x400030B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Vector3 Direction;

		[Token(Token = "0x400030C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private float radius;

		[Token(Token = "0x400030D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private float scaleFactor;

		[Token(Token = "0x400030E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private float preRadius;

		[Token(Token = "0x17000034")]
		public CapsuleCollider Capsule
		{
			[Token(Token = "0x6000277")]
			[Address(RVA = "0x1E8E0B0", Offset = "0x1E8E0B0", VA = "0x1E8E0B0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8D1B4C", Offset = "0x8D1B4C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000278")]
			[Address(RVA = "0x1E8E0B8", Offset = "0x1E8E0B8", VA = "0x1E8E0B8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8D1B5C", Offset = "0x8D1B5C")]
			private set
			{
			}
		}

		[Token(Token = "0x17000035")]
		public CapsuleCollider2D Capsule2D
		{
			[Token(Token = "0x6000279")]
			[Address(RVA = "0x1E8E0C0", Offset = "0x1E8E0C0", VA = "0x1E8E0C0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8D1B6C", Offset = "0x8D1B6C")]
			get
			{
				return null;
			}
			[Token(Token = "0x600027A")]
			[Address(RVA = "0x1E8E0C8", Offset = "0x1E8E0C8", VA = "0x1E8E0C8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8D1B7C", Offset = "0x8D1B7C")]
			private set
			{
			}
		}

		[Token(Token = "0x600027B")]
		[Address(RVA = "0x1E8A544", Offset = "0x1E8A544", VA = "0x1E8A544")]
		public FImp_ColliderData_Capsule(CapsuleCollider collider)
		{
		}

		[Token(Token = "0x600027C")]
		[Address(RVA = "0x1E8A97C", Offset = "0x1E8A97C", VA = "0x1E8A97C")]
		public FImp_ColliderData_Capsule(CapsuleCollider2D collider)
		{
		}

		[Token(Token = "0x600027D")]
		[Address(RVA = "0x1E8E3DC", Offset = "0x1E8E3DC", VA = "0x1E8E3DC", Slot = "4")]
		public override void RefreshColliderData()
		{
		}

		[Token(Token = "0x600027E")]
		[Address(RVA = "0x1E8EA18", Offset = "0x1E8EA18", VA = "0x1E8EA18", Slot = "5")]
		public override bool PushIfInside(ref Vector3 point, float pointRadius, Vector3 pointOffset)
		{
			return default(bool);
		}

		[Token(Token = "0x600027F")]
		[Address(RVA = "0x1E8ED0C", Offset = "0x1E8ED0C", VA = "0x1E8ED0C")]
		public static bool PushOutFromCapsuleCollider(CapsuleCollider capsule, float segmentColliderRadius, ref Vector3 pos, Vector3 segmentOffset)
		{
			return default(bool);
		}

		[Token(Token = "0x6000280")]
		[Address(RVA = "0x1E8EA68", Offset = "0x1E8EA68", VA = "0x1E8EA68")]
		public static bool PushOutFromCapsuleCollider(float segmentColliderRadius, ref Vector3 segmentPos, Vector3 capSphereCenter1, Vector3 capSphereCenter2, float capsuleRadius, Vector3 segmentOffset, bool is2D = false)
		{
			return default(bool);
		}

		[Token(Token = "0x6000281")]
		[Address(RVA = "0x1E8E0D0", Offset = "0x1E8E0D0", VA = "0x1E8E0D0")]
		protected static void CalculateCapsuleParameters(CapsuleCollider capsule, ref Vector3 direction, ref float trueRadius, ref float scalerFactor)
		{
		}

		[Token(Token = "0x6000282")]
		[Address(RVA = "0x1E8E604", Offset = "0x1E8E604", VA = "0x1E8E604")]
		private static float GetCapsule2DRadius(CapsuleCollider2D capsule)
		{
			return default(float);
		}

		[Token(Token = "0x6000283")]
		[Address(RVA = "0x1E8EE30", Offset = "0x1E8EE30", VA = "0x1E8EE30")]
		private static float GetCapsule2DHeight(CapsuleCollider2D capsule)
		{
			return default(float);
		}

		[Token(Token = "0x6000284")]
		[Address(RVA = "0x1E8E284", Offset = "0x1E8E284", VA = "0x1E8E284")]
		protected static void CalculateCapsuleParameters(CapsuleCollider2D capsule, ref Vector3 direction, ref float trueRadius, ref float scalerFactor)
		{
		}

		[Token(Token = "0x6000285")]
		[Address(RVA = "0x1E8E650", Offset = "0x1E8E650", VA = "0x1E8E650")]
		protected static void GetCapsuleHeadsPositions(CapsuleCollider capsule, ref Vector3 upper, ref Vector3 bottom, Vector3 direction, float radius, float scalerFactor)
		{
		}

		[Token(Token = "0x6000286")]
		[Address(RVA = "0x1E8E854", Offset = "0x1E8E854", VA = "0x1E8E854")]
		protected static void GetCapsuleHeadsPositions(CapsuleCollider2D capsule, ref Vector3 upper, ref Vector3 bottom, Vector3 direction, float radius, float scalerFactor)
		{
		}
	}
	[Token(Token = "0x200008B")]
	public class FImp_ColliderData_Mesh : FImp_ColliderData_Base
	{
		[Token(Token = "0x400030F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8CBF28", Offset = "0x8CBF28")]
		private MeshCollider <Mesh>k__BackingField;

		[Token(Token = "0x4000310")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8CBF38", Offset = "0x8CBF38")]
		private PolygonCollider2D <Poly2D>k__BackingField;

		[Token(Token = "0x4000311")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private ContactFilter2D filter;

		[Token(Token = "0x4000312")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private RaycastHit2D[] r;

		[Token(Token = "0x17000036")]
		public MeshCollider Mesh
		{
			[Token(Token = "0x6000287")]
			[Address(RVA = "0x203648C", Offset = "0x203648C", VA = "0x203648C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8D1B8C", Offset = "0x8D1B8C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000288")]
			[Address(RVA = "0x2036494", Offset = "0x2036494", VA = "0x2036494")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8D1B9C", Offset = "0x8D1B9C")]
			private set
			{
			}
		}

		[Token(Token = "0x17000037")]
		public PolygonCollider2D Poly2D
		{
			[Token(Token = "0x6000289")]
			[Address(RVA = "0x203649C", Offset = "0x203649C", VA = "0x203649C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8D1BAC", Offset = "0x8D1BAC")]
			get
			{
				return null;
			}
			[Token(Token = "0x600028A")]
			[Address(RVA = "0x20364A4", Offset = "0x20364A4", VA = "0x20364A4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8D1BBC", Offset = "0x8D1BBC")]
			private set
			{
			}
		}

		[Token(Token = "0x600028B")]
		[Address(RVA = "0x20364AC", Offset = "0x20364AC", VA = "0x20364AC")]
		public FImp_ColliderData_Mesh(MeshCollider collider)
		{
		}

		[Token(Token = "0x600028C")]
		[Address(RVA = "0x2036524", Offset = "0x2036524", VA = "0x2036524")]
		public FImp_ColliderData_Mesh(PolygonCollider2D collider)
		{
		}

		[Token(Token = "0x600028D")]
		[Address(RVA = "0x20365F8", Offset = "0x20365F8", VA = "0x20365F8", Slot = "5")]
		public override bool PushIfInside(ref Vector3 segmentPosition, float segmentRadius, Vector3 segmentOffset)
		{
			return default(bool);
		}

		[Token(Token = "0x600028E")]
		[Address(RVA = "0x2036F90", Offset = "0x2036F90", VA = "0x2036F90")]
		public static void PushOutFromMeshCollider(MeshCollider mesh, Collision collision, float segmentColliderRadius, ref Vector3 pos)
		{
		}

		[Token(Token = "0x600028F")]
		[Address(RVA = "0x2037238", Offset = "0x2037238", VA = "0x2037238")]
		public static void PushOutFromMesh(MeshCollider mesh, Collision collision, float pointRadius, ref Vector3 point)
		{
		}
	}
	[Token(Token = "0x200008C")]
	public class FImp_ColliderData_Sphere : FImp_ColliderData_Base
	{
		[Token(Token = "0x4000313")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8CBF48", Offset = "0x8CBF48")]
		private SphereCollider <Sphere>k__BackingField;

		[Token(Token = "0x4000314")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8CBF58", Offset = "0x8CBF58")]
		private CircleCollider2D <Sphere2D>k__BackingField;

		[Token(Token = "0x4000315")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private float SphereRadius;

		[Token(Token = "0x17000038")]
		public SphereCollider Sphere
		{
			[Token(Token = "0x6000290")]
			[Address(RVA = "0x20376B0", Offset = "0x20376B0", VA = "0x20376B0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8D1BCC", Offset = "0x8D1BCC")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000291")]
			[Address(RVA = "0x20376B8", Offset = "0x20376B8", VA = "0x20376B8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8D1BDC", Offset = "0x8D1BDC")]
			private set
			{
			}
		}

		[Token(Token = "0x17000039")]
		public CircleCollider2D Sphere2D
		{
			[Token(Token = "0x6000292")]
			[Address(RVA = "0x20376C0", Offset = "0x20376C0", VA = "0x20376C0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8D1BEC", Offset = "0x8D1BEC")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000293")]
			[Address(RVA = "0x20376C8", Offset = "0x20376C8", VA = "0x20376C8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8D1BFC", Offset = "0x8D1BFC")]
			private set
			{
			}
		}

		[Token(Token = "0x6000294")]
		[Address(RVA = "0x20376D0", Offset = "0x20376D0", VA = "0x20376D0")]
		public FImp_ColliderData_Sphere(SphereCollider collider)
		{
		}

		[Token(Token = "0x6000295")]
		[Address(RVA = "0x2037754", Offset = "0x2037754", VA = "0x2037754")]
		public FImp_ColliderData_Sphere(CircleCollider2D collider)
		{
		}

		[Token(Token = "0x6000296")]
		[Address(RVA = "0x20377E0", Offset = "0x20377E0", VA = "0x20377E0", Slot = "4")]
		public override void RefreshColliderData()
		{
		}

		[Token(Token = "0x6000297")]
		[Address(RVA = "0x20379A0", Offset = "0x20379A0", VA = "0x20379A0", Slot = "5")]
		public override bool PushIfInside(ref Vector3 point, float pointRadius, Vector3 pointOffset)
		{
			return default(bool);
		}

		[Token(Token = "0x6000298")]
		[Address(RVA = "0x2037CAC", Offset = "0x2037CAC", VA = "0x2037CAC")]
		public static bool PushOutFromSphereCollider(SphereCollider sphere, float segmentColliderRadius, ref Vector3 segmentPos, Vector3 segmentOffset)
		{
			return default(bool);
		}

		[Token(Token = "0x6000299")]
		[Address(RVA = "0x20379D4", Offset = "0x20379D4", VA = "0x20379D4")]
		public static bool PushOutFromSphereCollider(SphereCollider sphere, float segmentColliderRadius, ref Vector3 segmentPos, float collidingSphereRadius, Vector3 segmentOffset)
		{
			return default(bool);
		}

		[Token(Token = "0x600029A")]
		[Address(RVA = "0x2037B40", Offset = "0x2037B40", VA = "0x2037B40")]
		public static bool PushOutFromSphereCollider(CircleCollider2D sphere, float segmentColliderRadius, ref Vector3 segmentPos, float collidingSphereRadius, Vector3 segmentOffset)
		{
			return default(bool);
		}

		[Token(Token = "0x600029B")]
		[Address(RVA = "0x2037D0C", Offset = "0x2037D0C", VA = "0x2037D0C")]
		public static float CalculateTrueRadiusOfSphereCollider(SphereCollider sphere)
		{
			return default(float);
		}

		[Token(Token = "0x600029C")]
		[Address(RVA = "0x2037D4C", Offset = "0x2037D4C", VA = "0x2037D4C")]
		public static float CalculateTrueRadiusOfSphereCollider(CircleCollider2D sphere)
		{
			return default(float);
		}

		[Token(Token = "0x600029D")]
		[Address(RVA = "0x20378D4", Offset = "0x20378D4", VA = "0x20378D4")]
		public static float CalculateTrueRadiusOfSphereCollider(Transform transform, float componentRadius)
		{
			return default(float);
		}
	}
	[Token(Token = "0x200008D")]
	public class FImp_ColliderData_Terrain : FImp_ColliderData_Base
	{
		[Token(Token = "0x4000316")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8CBF68", Offset = "0x8CBF68")]
		private TerrainCollider <TerrCollider>k__BackingField;

		[Token(Token = "0x4000317")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8CBF78", Offset = "0x8CBF78")]
		private Terrain <TerrainComponent>k__BackingField;

		[Token(Token = "0x1700003A")]
		public TerrainCollider TerrCollider
		{
			[Token(Token = "0x600029E")]
			[Address(RVA = "0x2037D8C", Offset = "0x2037D8C", VA = "0x2037D8C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8D1C0C", Offset = "0x8D1C0C")]
			get
			{
				return null;
			}
			[Token(Token = "0x600029F")]
			[Address(RVA = "0x2037D94", Offset = "0x2037D94", VA = "0x2037D94")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8D1C1C", Offset = "0x8D1C1C")]
			private set
			{
			}
		}

		[Token(Token = "0x1700003B")]
		public Terrain TerrainComponent
		{
			[Token(Token = "0x60002A0")]
			[Address(RVA = "0x2037D9C", Offset = "0x2037D9C", VA = "0x2037D9C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8D1C2C", Offset = "0x8D1C2C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002A1")]
			[Address(RVA = "0x2037DA4", Offset = "0x2037DA4", VA = "0x2037DA4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8D1C3C", Offset = "0x8D1C3C")]
			private set
			{
			}
		}

		[Token(Token = "0x60002A2")]
		[Address(RVA = "0x2037DAC", Offset = "0x2037DAC", VA = "0x2037DAC")]
		public FImp_ColliderData_Terrain(TerrainCollider collider)
		{
		}

		[Token(Token = "0x60002A3")]
		[Address(RVA = "0x2037E6C", Offset = "0x2037E6C", VA = "0x2037E6C", Slot = "5")]
		public override bool PushIfInside(ref Vector3 segmentPosition, float segmentRadius, Vector3 segmentOffset)
		{
			return default(bool);
		}

		[Token(Token = "0x60002A4")]
		[Address(RVA = "0x20380E4", Offset = "0x20380E4", VA = "0x20380E4")]
		public static void PushOutFromTerrain(TerrainCollider terrainCollider, float segmentRadius, ref Vector3 point)
		{
		}
	}
	[Token(Token = "0x200008E")]
	public static class FEditor_OneShotLog
	{
		[Token(Token = "0x60002A5")]
		[Address(RVA = "0x1E86184", Offset = "0x1E86184", VA = "0x1E86184")]
		public static bool CanDrawLog(string id, int delayToNextCallInSeconds = int.MaxValue, int callLimitBeforeTimeMove = 1, int logSeparation = 0)
		{
			return default(bool);
		}

		[Token(Token = "0x60002A6")]
		[Address(RVA = "0x1E86560", Offset = "0x1E86560", VA = "0x1E86560")]
		public static bool EditorCanDrawLog(string id, int delayToNextCallInSeconds = int.MaxValue, int callLimitBeforeTimeMove = 1, int logSeparation = 0)
		{
			return default(bool);
		}
	}
}
namespace FIMSpace.FEditor
{
	[Token(Token = "0x200008F")]
	public class FEditor_StylesIn
	{
		[Token(Token = "0x1700003C")]
		public static GUIStyle GrayBackground
		{
			[Token(Token = "0x60002A7")]
			[Address(RVA = "0x1E86568", Offset = "0x1E86568", VA = "0x1E86568")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700003D")]
		public static GUIStyle LGrayBackground
		{
			[Token(Token = "0x60002A8")]
			[Address(RVA = "0x1E86734", Offset = "0x1E86734", VA = "0x1E86734")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700003E")]
		public static GUIStyle LBlueBackground
		{
			[Token(Token = "0x60002A9")]
			[Address(RVA = "0x1E8677C", Offset = "0x1E8677C", VA = "0x1E8677C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700003F")]
		public static GUIStyle LNavy
		{
			[Token(Token = "0x60002AA")]
			[Address(RVA = "0x1E867C4", Offset = "0x1E867C4", VA = "0x1E867C4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000040")]
		public static GUIStyle Emerald
		{
			[Token(Token = "0x60002AB")]
			[Address(RVA = "0x1E8680C", Offset = "0x1E8680C", VA = "0x1E8680C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000041")]
		public static GUIStyle GreenBackground
		{
			[Token(Token = "0x60002AC")]
			[Address(RVA = "0x1E86854", Offset = "0x1E86854", VA = "0x1E86854")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000042")]
		public static GUIStyle BlueBackground
		{
			[Token(Token = "0x60002AD")]
			[Address(RVA = "0x1E8689C", Offset = "0x1E8689C", VA = "0x1E8689C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000043")]
		public static GUIStyle RedBackground
		{
			[Token(Token = "0x60002AE")]
			[Address(RVA = "0x1E868E4", Offset = "0x1E868E4", VA = "0x1E868E4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000044")]
		public static GUIStyle YellowBackground
		{
			[Token(Token = "0x60002AF")]
			[Address(RVA = "0x1E8692C", Offset = "0x1E8692C", VA = "0x1E8692C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60002B0")]
		[Address(RVA = "0x1E865B0", Offset = "0x1E865B0", VA = "0x1E865B0")]
		public static GUIStyle Style(Color bgColor)
		{
			return null;
		}

		[Token(Token = "0x60002B1")]
		[Address(RVA = "0x1E86974", Offset = "0x1E86974", VA = "0x1E86974")]
		public static void DrawUILine(Color color, int thickness = 2, int padding = 10)
		{
		}

		[Token(Token = "0x60002B2")]
		[Address(RVA = "0x1E86978", Offset = "0x1E86978", VA = "0x1E86978")]
		public FEditor_StylesIn()
		{
		}
	}
}
namespace FIMSpace.FTools
{
	[Serializable]
	[Token(Token = "0x2000090")]
	public abstract class FIK_ProcessorBase
	{
		[Token(Token = "0x4000318")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8CBF88", Offset = "0x8CBF88")]
		public float IKWeight;

		[Token(Token = "0x4000319")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public Vector3 IKTargetPosition;

		[Token(Token = "0x400031A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Quaternion IKTargetRotation;

		[Token(Token = "0x400031B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Vector3 LastLocalDirection;

		[Token(Token = "0x400031C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public Vector3 LocalDirection;

		[Token(Token = "0x400031D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8CBFA0", Offset = "0x8CBFA0")]
		private float <fullLength>k__BackingField;

		[Token(Token = "0x400031E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8CBFB0", Offset = "0x8CBFB0")]
		private bool <Initialized>k__BackingField;

		[Token(Token = "0x400031F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8CBFC0", Offset = "0x8CBFC0")]
		private FIK_IKBoneBase[] <Bones>k__BackingField;

		[Token(Token = "0x17000045")]
		public float fullLength
		{
			[Token(Token = "0x60002B3")]
			[Address(RVA = "0x1E8A068", Offset = "0x1E8A068", VA = "0x1E8A068")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8D1C4C", Offset = "0x8D1C4C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60002B4")]
			[Address(RVA = "0x1E8A070", Offset = "0x1E8A070", VA = "0x1E8A070")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8D1C5C", Offset = "0x8D1C5C")]
			protected set
			{
			}
		}

		[Token(Token = "0x17000046")]
		public bool Initialized
		{
			[Token(Token = "0x60002B5")]
			[Address(RVA = "0x1E8A078", Offset = "0x1E8A078", VA = "0x1E8A078")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8D1C6C", Offset = "0x8D1C6C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60002B6")]
			[Address(RVA = "0x1E8A080", Offset = "0x1E8A080", VA = "0x1E8A080")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8D1C7C", Offset = "0x8D1C7C")]
			protected set
			{
			}
		}

		[Token(Token = "0x17000047")]
		public FIK_IKBoneBase[] Bones
		{
			[Token(Token = "0x60002B7")]
			[Address(RVA = "0x1E8A08C", Offset = "0x1E8A08C", VA = "0x1E8A08C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8D1C8C", Offset = "0x8D1C8C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002B8")]
			[Address(RVA = "0x1E8A094", Offset = "0x1E8A094", VA = "0x1E8A094")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8D1C9C", Offset = "0x8D1C9C")]
			protected set
			{
			}
		}

		[Token(Token = "0x17000048")]
		public FIK_IKBoneBase StartBone
		{
			[Token(Token = "0x60002B9")]
			[Address(RVA = "0x1E899E0", Offset = "0x1E899E0", VA = "0x1E899E0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000049")]
		public FIK_IKBoneBase EndBone
		{
			[Token(Token = "0x60002BA")]
			[Address(RVA = "0x1E88BBC", Offset = "0x1E88BBC", VA = "0x1E88BBC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60002BB")]
		[Address(RVA = "0x1E8A09C", Offset = "0x1E8A09C", VA = "0x1E8A09C", Slot = "4")]
		public virtual void Init(Transform root)
		{
		}

		[Token(Token = "0x60002BC")]
		[Address(RVA = "0x1E8A0A0", Offset = "0x1E8A0A0", VA = "0x1E8A0A0", Slot = "5")]
		public virtual void PreCalibrate()
		{
		}

		[Token(Token = "0x60002BD")]
		[Address(RVA = "0x1E8A108", Offset = "0x1E8A108", VA = "0x1E8A108", Slot = "6")]
		public virtual void Update()
		{
		}

		[Token(Token = "0x60002BE")]
		[Address(RVA = "0x1E8A10C", Offset = "0x1E8A10C", VA = "0x1E8A10C")]
		public static float EaseInOutQuint(float start, float end, float value)
		{
			return default(float);
		}

		[Token(Token = "0x60002BF")]
		[Address(RVA = "0x1E88BAC", Offset = "0x1E88BAC", VA = "0x1E88BAC")]
		protected FIK_ProcessorBase()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000091")]
	public abstract class FIK_IKBoneBase
	{
		[Token(Token = "0x4000320")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8CBFD0", Offset = "0x8CBFD0")]
		private FIK_IKBoneBase <Child>k__BackingField;

		[Token(Token = "0x4000321")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8CBFE0", Offset = "0x8CBFE0")]
		private Transform <transform>k__BackingField;

		[Token(Token = "0x4000322")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float sqrMagn;

		[Token(Token = "0x4000323")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float BoneLength;

		[Token(Token = "0x4000324")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float MotionWeight;

		[Token(Token = "0x4000325")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public Vector3 InitialLocalPosition;

		[Token(Token = "0x4000326")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Quaternion InitialLocalRotation;

		[Token(Token = "0x4000327")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Quaternion LastKeyLocalRotation;

		[Token(Token = "0x1700004A")]
		public FIK_IKBoneBase Child
		{
			[Token(Token = "0x60002C0")]
			[Address(RVA = "0x1E89E58", Offset = "0x1E89E58", VA = "0x1E89E58")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8D1CAC", Offset = "0x8D1CAC")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002C1")]
			[Address(RVA = "0x1E89E60", Offset = "0x1E89E60", VA = "0x1E89E60")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8D1CBC", Offset = "0x8D1CBC")]
			private set
			{
			}
		}

		[Token(Token = "0x1700004B")]
		public Transform transform
		{
			[Token(Token = "0x60002C2")]
			[Address(RVA = "0x1E89E68", Offset = "0x1E89E68", VA = "0x1E89E68")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8D1CCC", Offset = "0x8D1CCC")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002C3")]
			[Address(RVA = "0x1E89E70", Offset = "0x1E89E70", VA = "0x1E89E70")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8D1CDC", Offset = "0x8D1CDC")]
			protected set
			{
			}
		}

		[Token(Token = "0x60002C4")]
		[Address(RVA = "0x1E89E78", Offset = "0x1E89E78", VA = "0x1E89E78")]
		public FIK_IKBoneBase(Transform t)
		{
		}

		[Token(Token = "0x60002C5")]
		[Address(RVA = "0x1E89F78", Offset = "0x1E89F78", VA = "0x1E89F78", Slot = "4")]
		public virtual void SetChild(FIK_IKBoneBase child)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000092")]
	public class FIK_CCDProcessor : FIK_ProcessorBase
	{
		[Serializable]
		[Token(Token = "0x2000093")]
		public class CCDIKBone : FIK_IKBoneBase
		{
			[Token(Token = "0x4000331")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8CC060", Offset = "0x8CC060")]
			private CCDIKBone <IKParent>k__BackingField;

			[Token(Token = "0x4000332")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8CC070", Offset = "0x8CC070")]
			private CCDIKBone <IKChild>k__BackingField;

			[Token(Token = "0x4000333")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8CC080", Offset = "0x8CC080")]
			public float AngleLimit;

			[Token(Token = "0x4000334")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8CC09C", Offset = "0x8CC09C")]
			public float TwistAngleLimit;

			[Token(Token = "0x4000335")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			public Vector3 ForwardOrientation;

			[Token(Token = "0x4000336")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
			public float FrameWorldLength;

			[Token(Token = "0x4000337")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			public Vector2 HingeLimits;

			[Token(Token = "0x4000338")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
			public Quaternion PreviousHingeRotation;

			[Token(Token = "0x4000339")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			public float PreviousHingeAngle;

			[Token(Token = "0x400033A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
			public Vector3 LastIKLocPosition;

			[Token(Token = "0x400033B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
			public Quaternion LastIKLocRotation;

			[Token(Token = "0x1700004F")]
			public CCDIKBone IKParent
			{
				[Token(Token = "0x60002D4")]
				[Address(RVA = "0x117F69C", Offset = "0x117F69C", VA = "0x117F69C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8D1D0C", Offset = "0x8D1D0C")]
				get
				{
					return null;
				}
				[Token(Token = "0x60002D5")]
				[Address(RVA = "0x117F6A4", Offset = "0x117F6A4", VA = "0x117F6A4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8D1D1C", Offset = "0x8D1D1C")]
				private set
				{
				}
			}

			[Token(Token = "0x17000050")]
			public CCDIKBone IKChild
			{
				[Token(Token = "0x60002D6")]
				[Address(RVA = "0x117F6AC", Offset = "0x117F6AC", VA = "0x117F6AC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8D1D2C", Offset = "0x8D1D2C")]
				get
				{
					return null;
				}
				[Token(Token = "0x60002D7")]
				[Address(RVA = "0x117F6B4", Offset = "0x117F6B4", VA = "0x117F6B4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8D1D3C", Offset = "0x8D1D3C")]
				private set
				{
				}
			}

			[Token(Token = "0x60002D8")]
			[Address(RVA = "0x117F6BC", Offset = "0x117F6BC", VA = "0x117F6BC")]
			public CCDIKBone(Transform t)
			{
			}

			[Token(Token = "0x60002D9")]
			[Address(RVA = "0x117F708", Offset = "0x117F708", VA = "0x117F708")]
			public void Init(CCDIKBone child, CCDIKBone parent)
			{
			}

			[Token(Token = "0x60002DA")]
			[Address(RVA = "0x117F784", Offset = "0x117F784", VA = "0x117F784", Slot = "4")]
			public override void SetChild(FIK_IKBoneBase child)
			{
			}

			[Token(Token = "0x60002DB")]
			[Address(RVA = "0x117F78C", Offset = "0x117F78C", VA = "0x117F78C")]
			public void AngleLimiting()
			{
			}

			[Token(Token = "0x60002DC")]
			[Address(RVA = "0x117F97C", Offset = "0x117F97C", VA = "0x117F97C")]
			private Quaternion LimitSpherical(Quaternion rotation)
			{
				return default(Quaternion);
			}

			[Token(Token = "0x60002DD")]
			[Address(RVA = "0x117FACC", Offset = "0x117FACC", VA = "0x117FACC")]
			private Quaternion LimitZ(Quaternion currentRotation)
			{
				return default(Quaternion);
			}

			[Token(Token = "0x60002DE")]
			[Address(RVA = "0x117FC0C", Offset = "0x117FC0C", VA = "0x117FC0C")]
			private Quaternion LimitHinge(Quaternion rotation)
			{
				return default(Quaternion);
			}
		}

		[Token(Token = "0x4000328")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public CCDIKBone[] IKBones;

		[Token(Token = "0x4000329")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public bool ContinousSolving;

		[Token(Token = "0x400032A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8CBFF0", Offset = "0x8CBFF0")]
		public float SyncWithAnimator;

		[Token(Token = "0x400032B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8CC008", Offset = "0x8CC008")]
		public int ReactionQuality;

		[Token(Token = "0x400032C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8CC020", Offset = "0x8CC020")]
		public float Smoothing;

		[Token(Token = "0x400032D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8CC038", Offset = "0x8CC038")]
		public float MaxStretching;

		[Token(Token = "0x400032E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public AnimationCurve StretchCurve;

		[Token(Token = "0x400032F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public bool Use2D;

		[Token(Token = "0x4000330")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8CC050", Offset = "0x8CC050")]
		private float <ActiveLength>k__BackingField;

		[Token(Token = "0x1700004C")]
		public CCDIKBone StartIKBone
		{
			[Token(Token = "0x60002C6")]
			[Address(RVA = "0x1E888CC", Offset = "0x1E888CC", VA = "0x1E888CC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700004D")]
		public CCDIKBone EndIKBone
		{
			[Token(Token = "0x60002C7")]
			[Address(RVA = "0x1E88900", Offset = "0x1E88900", VA = "0x1E88900")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700004E")]
		public float ActiveLength
		{
			[Token(Token = "0x60002C8")]
			[Address(RVA = "0x1E88940", Offset = "0x1E88940", VA = "0x1E88940")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8D1CEC", Offset = "0x8D1CEC")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60002C9")]
			[Address(RVA = "0x1E88948", Offset = "0x1E88948", VA = "0x1E88948")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8D1CFC", Offset = "0x8D1CFC")]
			private set
			{
			}
		}

		[Token(Token = "0x60002CA")]
		[Address(RVA = "0x1E88950", Offset = "0x1E88950", VA = "0x1E88950")]
		public FIK_CCDProcessor(Transform[] bonesChain)
		{
		}

		[Token(Token = "0x60002CB")]
		[Address(RVA = "0x1E88BFC", Offset = "0x1E88BFC", VA = "0x1E88BFC", Slot = "4")]
		public override void Init(Transform root)
		{
		}

		[Token(Token = "0x60002CC")]
		[Address(RVA = "0x1E88E84", Offset = "0x1E88E84", VA = "0x1E88E84", Slot = "6")]
		public override void Update()
		{
		}

		[Token(Token = "0x60002CD")]
		[Address(RVA = "0x1E8971C", Offset = "0x1E8971C", VA = "0x1E8971C")]
		protected Vector3 GetGoalPivotOffset()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002CE")]
		[Address(RVA = "0x1E89A14", Offset = "0x1E89A14", VA = "0x1E89A14")]
		private bool GoalPivotOffsetDetected()
		{
			return default(bool);
		}

		[Token(Token = "0x60002CF")]
		[Address(RVA = "0x1E8990C", Offset = "0x1E8990C", VA = "0x1E8990C")]
		private Vector3 RefreshLocalDirection()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002D0")]
		[Address(RVA = "0x1E898DC", Offset = "0x1E898DC", VA = "0x1E898DC")]
		private float GetVelocityDifference()
		{
			return default(float);
		}

		[Token(Token = "0x60002D1")]
		[Address(RVA = "0x1E89C08", Offset = "0x1E89C08", VA = "0x1E89C08")]
		public void AutoLimitAngle(float angleLimit = 60f, float twistAngleLimit = 50f)
		{
		}

		[Token(Token = "0x60002D2")]
		[Address(RVA = "0x1E89D24", Offset = "0x1E89D24", VA = "0x1E89D24")]
		public void AutoWeightBones(float baseValue = 1f)
		{
		}

		[Token(Token = "0x60002D3")]
		[Address(RVA = "0x1E89DAC", Offset = "0x1E89DAC", VA = "0x1E89DAC")]
		public void AutoWeightBones(AnimationCurve weightCurve)
		{
		}
	}
	[Token(Token = "0x2000094")]
	public class FElasticTransform
	{
		[Token(Token = "0x400033C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform transform;

		[Token(Token = "0x400033D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private FElasticTransform elChild;

		[Token(Token = "0x400033E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private FElasticTransform elParent;

		[Token(Token = "0x400033F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "FPD_SuffixAttribute", RVA = "0x8CC0B8", Offset = "0x8CC0B8")]
		public float RotationRapidness;

		[Token(Token = "0x4000340")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8CC100", Offset = "0x8CC100")]
		private FMuscle_Vector3 <PositionMuscle>k__BackingField;

		[Token(Token = "0x4000341")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8CC110", Offset = "0x8CC110")]
		private Vector3 <ProceduralPosition>k__BackingField;

		[Token(Token = "0x4000342")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private Quaternion proceduralRotation;

		[Token(Token = "0x4000343")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8CC120", Offset = "0x8CC120")]
		private Vector3 <sourceAnimationPosition>k__BackingField;

		[Token(Token = "0x4000344")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private float delta;

		[Token(Token = "0x17000051")]
		public FMuscle_Vector3 PositionMuscle
		{
			[Token(Token = "0x60002DF")]
			[Address(RVA = "0x1E86980", Offset = "0x1E86980", VA = "0x1E86980")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8D1D4C", Offset = "0x8D1D4C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002E0")]
			[Address(RVA = "0x1E86988", Offset = "0x1E86988", VA = "0x1E86988")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8D1D5C", Offset = "0x8D1D5C")]
			private set
			{
			}
		}

		[Token(Token = "0x17000052")]
		public Vector3 ProceduralPosition
		{
			[Token(Token = "0x60002E1")]
			[Address(RVA = "0x1E86990", Offset = "0x1E86990", VA = "0x1E86990")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8D1D6C", Offset = "0x8D1D6C")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60002E2")]
			[Address(RVA = "0x1E8699C", Offset = "0x1E8699C", VA = "0x1E8699C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8D1D7C", Offset = "0x8D1D7C")]
			private set
			{
			}
		}

		[Token(Token = "0x17000053")]
		public Vector3 sourceAnimationPosition
		{
			[Token(Token = "0x60002E3")]
			[Address(RVA = "0x1E869A8", Offset = "0x1E869A8", VA = "0x1E869A8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8D1D8C", Offset = "0x8D1D8C")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60002E4")]
			[Address(RVA = "0x1E869B4", Offset = "0x1E869B4", VA = "0x1E869B4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8D1D9C", Offset = "0x8D1D9C")]
			private set
			{
			}
		}

		[Token(Token = "0x60002E5")]
		[Address(RVA = "0x1E869C0", Offset = "0x1E869C0", VA = "0x1E869C0")]
		public void Initialize(Transform transform)
		{
		}

		[Token(Token = "0x60002E6")]
		[Address(RVA = "0x1E86AF4", Offset = "0x1E86AF4", VA = "0x1E86AF4")]
		public void OverrideProceduralPosition(Vector3 newPos)
		{
		}

		[Token(Token = "0x60002E7")]
		[Address(RVA = "0x1E86B00", Offset = "0x1E86B00", VA = "0x1E86B00")]
		public void OverrideProceduralPositionHard(Vector3 newPos)
		{
		}

		[Token(Token = "0x60002E8")]
		[Address(RVA = "0x1E86B5C", Offset = "0x1E86B5C", VA = "0x1E86B5C")]
		public void OverrideProceduralRotation(Quaternion newRot)
		{
		}

		[Token(Token = "0x60002E9")]
		[Address(RVA = "0x1E86B68", Offset = "0x1E86B68", VA = "0x1E86B68")]
		public void CaptureSourceAnimation()
		{
		}

		[Token(Token = "0x60002EA")]
		[Address(RVA = "0x1E86BA0", Offset = "0x1E86BA0", VA = "0x1E86BA0")]
		public void SetChild(FElasticTransform child)
		{
		}

		[Token(Token = "0x60002EB")]
		[Address(RVA = "0x1E86BA8", Offset = "0x1E86BA8", VA = "0x1E86BA8")]
		public FElasticTransform GetElasticChild()
		{
			return null;
		}

		[Token(Token = "0x60002EC")]
		[Address(RVA = "0x1E86BB0", Offset = "0x1E86BB0", VA = "0x1E86BB0")]
		public void SetParent(FElasticTransform parent)
		{
		}

		[Token(Token = "0x60002ED")]
		[Address(RVA = "0x1E86BB8", Offset = "0x1E86BB8", VA = "0x1E86BB8")]
		public void UpdateElasticPosition(float delta)
		{
		}

		[Token(Token = "0x60002EE")]
		[Address(RVA = "0x1E86D28", Offset = "0x1E86D28", VA = "0x1E86D28")]
		public void UpdateElasticPosition(float delta, Vector3 influenceOffset)
		{
		}

		[Token(Token = "0x60002EF")]
		[Address(RVA = "0x1E86DAC", Offset = "0x1E86DAC", VA = "0x1E86DAC")]
		public void UpdateElasticRotation(float blending)
		{
		}

		[Token(Token = "0x60002F0")]
		[Address(RVA = "0x1E86FA8", Offset = "0x1E86FA8", VA = "0x1E86FA8")]
		public Vector3 BlendVector(Vector3 target, float blend)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002F1")]
		[Address(RVA = "0x1E86FD8", Offset = "0x1E86FD8", VA = "0x1E86FD8")]
		public Quaternion GetTargetRotation(Vector3 lookPos, Vector3 localOffset, float blending)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60002F2")]
		[Address(RVA = "0x1E870CC", Offset = "0x1E870CC", VA = "0x1E870CC")]
		public Quaternion GetTargetRotation(Vector3 lookPos, Vector3 localOffset, Vector3 pos)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60002F3")]
		[Address(RVA = "0x1E871A0", Offset = "0x1E871A0", VA = "0x1E871A0")]
		public FElasticTransform()
		{
		}
	}
	[Token(Token = "0x2000095")]
	public abstract class FMuscle_Motor
	{
		[Token(Token = "0x4000345")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8CC130", Offset = "0x8CC130")]
		private float <OutValue>k__BackingField;

		[Token(Token = "0x4000346")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		protected float proceduralValue;

		[Token(Token = "0x4000347")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		protected float dampingAcceleration;

		[Token(Token = "0x4000348")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		protected float dynamicAcceleration;

		[Token(Token = "0x4000349")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		protected float accelerationSign;

		[Token(Token = "0x17000054")]
		public float OutValue
		{
			[Token(Token = "0x60002F4")]
			[Address(RVA = "0x20430C8", Offset = "0x20430C8", VA = "0x20430C8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8D1DAC", Offset = "0x8D1DAC")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60002F5")]
			[Address(RVA = "0x20430D0", Offset = "0x20430D0", VA = "0x20430D0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8D1DBC", Offset = "0x8D1DBC")]
			protected set
			{
			}
		}

		[Token(Token = "0x60002F6")]
		[Address(RVA = "0x2042A20", Offset = "0x2042A20", VA = "0x2042A20")]
		public bool IsWorking()
		{
			return default(bool);
		}

		[Token(Token = "0x60002F7")]
		[Address(RVA = "0x2042A80", Offset = "0x2042A80", VA = "0x2042A80")]
		public void Push(float value)
		{
		}

		[Token(Token = "0x60002F8")]
		[Address(RVA = "0x2042978", Offset = "0x2042978", VA = "0x2042978")]
		public void Initialize(float initValue)
		{
		}

		[Token(Token = "0x60002F9")]
		protected abstract float GetDiff(float current, float desired);

		[Token(Token = "0x60002FA")]
		[Address(RVA = "0x2042C38", Offset = "0x2042C38", VA = "0x2042C38")]
		public void Update(float delta, float current, float desired, float acceleration, float accelerationLimit, float damping, float brakePower)
		{
		}

		[Token(Token = "0x60002FB")]
		[Address(RVA = "0x20430D8", Offset = "0x20430D8", VA = "0x20430D8")]
		public void OverrideValue(float newValue)
		{
		}

		[Token(Token = "0x60002FC")]
		[Address(RVA = "0x20430E0", Offset = "0x20430E0", VA = "0x20430E0")]
		public void OffsetValue(float off)
		{
		}

		[Token(Token = "0x60002FD")]
		[Address(RVA = "0x2042818", Offset = "0x2042818", VA = "0x2042818")]
		protected FMuscle_Motor()
		{
		}
	}
	[Token(Token = "0x2000096")]
	public class FMuscle_Float : FMuscle_Motor
	{
		[Token(Token = "0x60002FE")]
		[Address(RVA = "0x20430B8", Offset = "0x20430B8", VA = "0x20430B8", Slot = "4")]
		protected override float GetDiff(float current, float desired)
		{
			return default(float);
		}

		[Token(Token = "0x60002FF")]
		[Address(RVA = "0x20430C0", Offset = "0x20430C0", VA = "0x20430C0")]
		public FMuscle_Float()
		{
		}
	}
	[Token(Token = "0x2000097")]
	public class FMuscle_Angle : FMuscle_Motor
	{
		[Token(Token = "0x6000300")]
		[Address(RVA = "0x2042808", Offset = "0x2042808", VA = "0x2042808", Slot = "4")]
		protected override float GetDiff(float current, float desired)
		{
			return default(float);
		}

		[Token(Token = "0x6000301")]
		[Address(RVA = "0x2042810", Offset = "0x2042810", VA = "0x2042810")]
		public FMuscle_Angle()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000098")]
	public class FMuscle_Vector3
	{
		[Token(Token = "0x2000099")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8CB170", Offset = "0x8CB170")]
		private sealed class <PushImpulseCoroutine>d__24 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000354")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000355")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000356")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float delay;

			[Token(Token = "0x4000357")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public FMuscle_Vector3 <>4__this;

			[Token(Token = "0x4000358")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public bool fadeOutPower;

			[Token(Token = "0x4000359")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			public Vector3 power;

			[Token(Token = "0x400035A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public float duration;

			[Token(Token = "0x400035B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			private float <elapsed>5__2;

			[Token(Token = "0x17000057")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000315")]
				[Address(RVA = "0x1181700", Offset = "0x1181700", VA = "0x1181700", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000058")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000317")]
				[Address(RVA = "0x1181748", Offset = "0x1181748", VA = "0x1181748", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000312")]
			[Address(RVA = "0x118150C", Offset = "0x118150C", VA = "0x118150C")]
			[DebuggerHidden]
			public <PushImpulseCoroutine>d__24(int <>1__state)
			{
			}

			[Token(Token = "0x6000313")]
			[Address(RVA = "0x1181538", Offset = "0x1181538", VA = "0x1181538", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000314")]
			[Address(RVA = "0x118153C", Offset = "0x118153C", VA = "0x118153C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000316")]
			[Address(RVA = "0x1181708", Offset = "0x1181708", VA = "0x1181708", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400034A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[HideInInspector]
		public Vector3 DesiredPosition;

		[Token(Token = "0x400034B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8CC150", Offset = "0x8CC150")]
		private Vector3 <ProceduralPosition>k__BackingField;

		[Token(Token = "0x400034C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8CC160", Offset = "0x8CC160")]
		private bool <Initialized>k__BackingField;

		[Token(Token = "0x400034D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private FMuscle_Float x;

		[Token(Token = "0x400034E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private FMuscle_Float y;

		[Token(Token = "0x400034F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private FMuscle_Float z;

		[Token(Token = "0x4000350")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "FPD_SuffixAttribute", RVA = "0x8CC170", Offset = "0x8CC170")]
		public float Acceleration;

		[Token(Token = "0x4000351")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "FPD_SuffixAttribute", RVA = "0x8CC1BC", Offset = "0x8CC1BC")]
		public float AccelerationLimit;

		[Token(Token = "0x4000352")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "FPD_SuffixAttribute", RVA = "0x8CC208", Offset = "0x8CC208")]
		public float Damping;

		[Token(Token = "0x4000353")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "FPD_SuffixAttribute", RVA = "0x8CC254", Offset = "0x8CC254")]
		public float BrakePower;

		[Token(Token = "0x17000055")]
		public Vector3 ProceduralPosition
		{
			[Token(Token = "0x6000302")]
			[Address(RVA = "0x1A8E9CC", Offset = "0x1A8E9CC", VA = "0x1A8E9CC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8D1DCC", Offset = "0x8D1DCC")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000303")]
			[Address(RVA = "0x1A8E9D8", Offset = "0x1A8E9D8", VA = "0x1A8E9D8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8D1DDC", Offset = "0x8D1DDC")]
			private set
			{
			}
		}

		[Token(Token = "0x17000056")]
		public bool Initialized
		{
			[Token(Token = "0x6000304")]
			[Address(RVA = "0x1A8E9E4", Offset = "0x1A8E9E4", VA = "0x1A8E9E4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8D1DEC", Offset = "0x8D1DEC")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000305")]
			[Address(RVA = "0x1A8E9EC", Offset = "0x1A8E9EC", VA = "0x1A8E9EC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8D1DFC", Offset = "0x8D1DFC")]
			private set
			{
			}
		}

		[Token(Token = "0x6000306")]
		[Address(RVA = "0x1A8E9F8", Offset = "0x1A8E9F8", VA = "0x1A8E9F8")]
		public void Initialize(Vector3 initPosition)
		{
		}

		[Token(Token = "0x6000307")]
		[Address(RVA = "0x1A8EB30", Offset = "0x1A8EB30", VA = "0x1A8EB30")]
		public bool IsWorking()
		{
			return default(bool);
		}

		[Token(Token = "0x6000308")]
		[Address(RVA = "0x1A8EB94", Offset = "0x1A8EB94", VA = "0x1A8EB94")]
		public void Push(Vector3 value)
		{
		}

		[Token(Token = "0x6000309")]
		[Address(RVA = "0x1A8EBF8", Offset = "0x1A8EBF8", VA = "0x1A8EBF8")]
		public void Reset(Vector3 value)
		{
		}

		[Token(Token = "0x600030A")]
		[Address(RVA = "0x1A8EC5C", Offset = "0x1A8EC5C", VA = "0x1A8EC5C")]
		public void Push(float v)
		{
		}

		[Token(Token = "0x600030B")]
		[Address(RVA = "0x1A8ECBC", Offset = "0x1A8ECBC", VA = "0x1A8ECBC")]
		public void MotionInfluence(Vector3 offset)
		{
		}

		[Token(Token = "0x600030C")]
		[Address(RVA = "0x1A8ED50", Offset = "0x1A8ED50", VA = "0x1A8ED50")]
		public void Update(float delta, Vector3 desired, float acceleration, float accelerationLimit, float damping, float brakePower)
		{
		}

		[Token(Token = "0x600030D")]
		[Address(RVA = "0x1A8EE58", Offset = "0x1A8EE58", VA = "0x1A8EE58")]
		public Vector3 Update(float delta, Vector3 desired)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600030E")]
		[Address(RVA = "0x1A8EF28", Offset = "0x1A8EF28", VA = "0x1A8EF28")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x8D1E0C", Offset = "0x8D1E0C")]
		public IEnumerator PushImpulseCoroutine(Vector3 power, float duration, bool fadeOutPower = false, float delay = 0f)
		{
			return null;
		}

		[Token(Token = "0x600030F")]
		[Address(RVA = "0x1A8EFEC", Offset = "0x1A8EFEC", VA = "0x1A8EFEC")]
		public static void Lerp(ref FMuscle_Vector3 source, FMuscle_Vector3 a, FMuscle_Vector3 b, float t)
		{
		}

		[Token(Token = "0x6000310")]
		[Address(RVA = "0x1A8F0B0", Offset = "0x1A8F0B0", VA = "0x1A8F0B0")]
		public void OverrideProceduralPosition(Vector3 newPos)
		{
		}

		[Token(Token = "0x6000311")]
		[Address(RVA = "0x1A8F0F4", Offset = "0x1A8F0F4", VA = "0x1A8F0F4")]
		public FMuscle_Vector3()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200009A")]
	public class FMuscle_Quaternion
	{
		[Token(Token = "0x200009B")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8CB180", Offset = "0x8CB180")]
		private sealed class <PushImpulseCoroutine>d__24 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000366")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000367")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000368")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float delay;

			[Token(Token = "0x4000369")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public FMuscle_Quaternion <>4__this;

			[Token(Token = "0x400036A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public bool fadeOutPower;

			[Token(Token = "0x400036B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			public Quaternion power;

			[Token(Token = "0x400036C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			public float duration;

			[Token(Token = "0x400036D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private float <elapsed>5__2;

			[Token(Token = "0x1700005B")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600032B")]
				[Address(RVA = "0x11814BC", Offset = "0x11814BC", VA = "0x11814BC", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700005C")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600032D")]
				[Address(RVA = "0x1181504", Offset = "0x1181504", VA = "0x1181504", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000328")]
			[Address(RVA = "0x11812E8", Offset = "0x11812E8", VA = "0x11812E8")]
			[DebuggerHidden]
			public <PushImpulseCoroutine>d__24(int <>1__state)
			{
			}

			[Token(Token = "0x6000329")]
			[Address(RVA = "0x1181314", Offset = "0x1181314", VA = "0x1181314", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600032A")]
			[Address(RVA = "0x1181318", Offset = "0x1181318", VA = "0x1181318", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600032C")]
			[Address(RVA = "0x11814C4", Offset = "0x11814C4", VA = "0x11814C4", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400035C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[HideInInspector]
		public Quaternion DesiredRotation;

		[Token(Token = "0x400035D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8CC2AC", Offset = "0x8CC2AC")]
		private Quaternion <ProceduralRotation>k__BackingField;

		[Token(Token = "0x400035E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private FMuscle_Float x;

		[Token(Token = "0x400035F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private FMuscle_Float y;

		[Token(Token = "0x4000360")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private FMuscle_Float z;

		[Token(Token = "0x4000361")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private FMuscle_Float w;

		[Token(Token = "0x4000362")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "FPD_SuffixAttribute", RVA = "0x8CC2BC", Offset = "0x8CC2BC")]
		public float Acceleration;

		[Token(Token = "0x4000363")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "FPD_SuffixAttribute", RVA = "0x8CC308", Offset = "0x8CC308")]
		public float AccelerationLimit;

		[Token(Token = "0x4000364")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "FPD_SuffixAttribute", RVA = "0x8CC354", Offset = "0x8CC354")]
		public float Damping;

		[Token(Token = "0x4000365")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "FPD_SuffixAttribute", RVA = "0x8CC3A0", Offset = "0x8CC3A0")]
		public float BrakePower;

		[Token(Token = "0x17000059")]
		public Quaternion ProceduralRotation
		{
			[Token(Token = "0x6000318")]
			[Address(RVA = "0x20430F0", Offset = "0x20430F0", VA = "0x20430F0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8D1EBC", Offset = "0x8D1EBC")]
			get
			{
				return default(Quaternion);
			}
			[Token(Token = "0x6000319")]
			[Address(RVA = "0x20430FC", Offset = "0x20430FC", VA = "0x20430FC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8D1ECC", Offset = "0x8D1ECC")]
			private set
			{
			}
		}

		[Token(Token = "0x1700005A")]
		public bool IsCorrect
		{
			[Token(Token = "0x600031A")]
			[Address(RVA = "0x2043108", Offset = "0x2043108", VA = "0x2043108")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600031B")]
		[Address(RVA = "0x2043118", Offset = "0x2043118", VA = "0x2043118")]
		public void Initialize(Quaternion initRotation)
		{
		}

		[Token(Token = "0x600031C")]
		[Address(RVA = "0x2043288", Offset = "0x2043288", VA = "0x2043288")]
		public bool IsWorking()
		{
			return default(bool);
		}

		[Token(Token = "0x600031D")]
		[Address(RVA = "0x20432F4", Offset = "0x20432F4", VA = "0x20432F4")]
		public void Push(Quaternion value)
		{
		}

		[Token(Token = "0x600031E")]
		[Address(RVA = "0x2043358", Offset = "0x2043358", VA = "0x2043358")]
		public void Push(float v)
		{
		}

		[Token(Token = "0x600031F")]
		[Address(RVA = "0x20433BC", Offset = "0x20433BC", VA = "0x20433BC")]
		public void Push(Quaternion value, float multiply)
		{
		}

		[Token(Token = "0x6000320")]
		[Address(RVA = "0x2043430", Offset = "0x2043430", VA = "0x2043430")]
		public void Update(float delta, Quaternion desired, float acceleration, float accelerationLimit, float damping, float brakePower)
		{
		}

		[Token(Token = "0x6000321")]
		[Address(RVA = "0x204357C", Offset = "0x204357C", VA = "0x204357C")]
		public void Update(float delta, Quaternion desired)
		{
		}

		[Token(Token = "0x6000322")]
		[Address(RVA = "0x2043688", Offset = "0x2043688", VA = "0x2043688")]
		public void UpdateEnsured(float delta, Quaternion desired)
		{
		}

		[Token(Token = "0x6000323")]
		[Address(RVA = "0x20436F8", Offset = "0x20436F8", VA = "0x20436F8")]
		public static Quaternion EnsureQuaternionContinuity(Quaternion latestRot, Quaternion targetRot)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000324")]
		[Address(RVA = "0x204395C", Offset = "0x204395C", VA = "0x204395C")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x8D1EDC", Offset = "0x8D1EDC")]
		public IEnumerator PushImpulseCoroutine(Quaternion power, float duration, bool fadeOutPower = false, float delay = 0f)
		{
			return null;
		}

		[Token(Token = "0x6000325")]
		[Address(RVA = "0x2043A28", Offset = "0x2043A28", VA = "0x2043A28")]
		public static void Lerp(ref FMuscle_Quaternion source, FMuscle_Quaternion a, FMuscle_Quaternion b, float t)
		{
		}

		[Token(Token = "0x6000326")]
		[Address(RVA = "0x2043AEC", Offset = "0x2043AEC", VA = "0x2043AEC")]
		public void OverrideProceduralRotation(Quaternion rotation)
		{
		}

		[Token(Token = "0x6000327")]
		[Address(RVA = "0x2043B40", Offset = "0x2043B40", VA = "0x2043B40")]
		public FMuscle_Quaternion()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200009C")]
	public class FMuscle_Eulers
	{
		[Token(Token = "0x200009D")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8CB190", Offset = "0x8CB190")]
		private sealed class <PushImpulseCoroutine>d__23 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000377")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000378")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000379")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float delay;

			[Token(Token = "0x400037A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public FMuscle_Eulers <>4__this;

			[Token(Token = "0x400037B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public bool fadeOutPower;

			[Token(Token = "0x400037C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			public Vector3 power;

			[Token(Token = "0x400037D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public float duration;

			[Token(Token = "0x400037E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			private float <elapsed>5__2;

			[Token(Token = "0x1700005F")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000340")]
				[Address(RVA = "0x1181298", Offset = "0x1181298", VA = "0x1181298", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000060")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000342")]
				[Address(RVA = "0x11812E0", Offset = "0x11812E0", VA = "0x11812E0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600033D")]
			[Address(RVA = "0x11810C8", Offset = "0x11810C8", VA = "0x11810C8")]
			[DebuggerHidden]
			public <PushImpulseCoroutine>d__23(int <>1__state)
			{
			}

			[Token(Token = "0x600033E")]
			[Address(RVA = "0x11810F4", Offset = "0x11810F4", VA = "0x11810F4", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600033F")]
			[Address(RVA = "0x11810F8", Offset = "0x11810F8", VA = "0x11810F8", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000341")]
			[Address(RVA = "0x11812A0", Offset = "0x11812A0", VA = "0x11812A0", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400036E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[HideInInspector]
		public Vector3 DesiredEulerAngles;

		[Token(Token = "0x400036F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8CC3F8", Offset = "0x8CC3F8")]
		private Vector3 <ProceduralEulerAngles>k__BackingField;

		[Token(Token = "0x4000370")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private FMuscle_Angle x;

		[Token(Token = "0x4000371")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private FMuscle_Angle y;

		[Token(Token = "0x4000372")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private FMuscle_Angle z;

		[Token(Token = "0x4000373")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "FPD_SuffixAttribute", RVA = "0x8CC408", Offset = "0x8CC408")]
		public float Acceleration;

		[Token(Token = "0x4000374")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "FPD_SuffixAttribute", RVA = "0x8CC454", Offset = "0x8CC454")]
		public float AccelerationLimit;

		[Token(Token = "0x4000375")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "FPD_SuffixAttribute", RVA = "0x8CC4A0", Offset = "0x8CC4A0")]
		public float Damping;

		[Token(Token = "0x4000376")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "FPD_SuffixAttribute", RVA = "0x8CC4EC", Offset = "0x8CC4EC")]
		public float BrakePower;

		[Token(Token = "0x1700005D")]
		public Vector3 ProceduralEulerAngles
		{
			[Token(Token = "0x600032E")]
			[Address(RVA = "0x2042820", Offset = "0x2042820", VA = "0x2042820")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8D1F8C", Offset = "0x8D1F8C")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x600032F")]
			[Address(RVA = "0x204282C", Offset = "0x204282C", VA = "0x204282C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8D1F9C", Offset = "0x8D1F9C")]
			private set
			{
			}
		}

		[Token(Token = "0x1700005E")]
		public Quaternion ProceduralRotation
		{
			[Token(Token = "0x6000330")]
			[Address(RVA = "0x2042838", Offset = "0x2042838", VA = "0x2042838")]
			get
			{
				return default(Quaternion);
			}
		}

		[Token(Token = "0x6000331")]
		[Address(RVA = "0x2042848", Offset = "0x2042848", VA = "0x2042848")]
		public void Initialize(Vector3 initEulerAngles)
		{
		}

		[Token(Token = "0x6000332")]
		[Address(RVA = "0x2042988", Offset = "0x2042988", VA = "0x2042988")]
		public void Initialize(Quaternion initRotation)
		{
		}

		[Token(Token = "0x6000333")]
		[Address(RVA = "0x20429C8", Offset = "0x20429C8", VA = "0x20429C8")]
		public bool IsWorking()
		{
			return default(bool);
		}

		[Token(Token = "0x6000334")]
		[Address(RVA = "0x2042A30", Offset = "0x2042A30", VA = "0x2042A30")]
		public void Push(Vector3 value)
		{
		}

		[Token(Token = "0x6000335")]
		[Address(RVA = "0x2042A90", Offset = "0x2042A90", VA = "0x2042A90")]
		public void Push(float v)
		{
		}

		[Token(Token = "0x6000336")]
		[Address(RVA = "0x2042AE0", Offset = "0x2042AE0", VA = "0x2042AE0")]
		public void Push(Vector3 value, float multiply)
		{
		}

		[Token(Token = "0x6000337")]
		[Address(RVA = "0x2042B3C", Offset = "0x2042B3C", VA = "0x2042B3C")]
		public void Update(float delta, Vector3 desired, float acceleration, float accelerationLimit, float damping, float brakePower)
		{
		}

		[Token(Token = "0x6000338")]
		[Address(RVA = "0x2042DF0", Offset = "0x2042DF0", VA = "0x2042DF0")]
		public Vector3 Update(float delta, Vector3 desired)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000339")]
		[Address(RVA = "0x2042EB4", Offset = "0x2042EB4", VA = "0x2042EB4")]
		public void Update(float delta, Quaternion desired)
		{
		}

		[Token(Token = "0x600033A")]
		[Address(RVA = "0x2042F1C", Offset = "0x2042F1C", VA = "0x2042F1C")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x8D1FAC", Offset = "0x8D1FAC")]
		public IEnumerator PushImpulseCoroutine(Vector3 power, float duration, bool fadeOutPower = false, float delay = 0f)
		{
			return null;
		}

		[Token(Token = "0x600033B")]
		[Address(RVA = "0x2042FE0", Offset = "0x2042FE0", VA = "0x2042FE0")]
		public static void Lerp(ref FMuscle_Eulers source, FMuscle_Eulers a, FMuscle_Eulers b, float t)
		{
		}

		[Token(Token = "0x600033C")]
		[Address(RVA = "0x20430A4", Offset = "0x20430A4", VA = "0x20430A4")]
		public FMuscle_Eulers()
		{
		}
	}
	[Token(Token = "0x200009E")]
	public class UniRotateBone
	{
		[Token(Token = "0x400037F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8CC534", Offset = "0x8CC534")]
		private Transform <transform>k__BackingField;

		[Token(Token = "0x4000380")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8CC544", Offset = "0x8CC544")]
		private Vector3 <initialLocalPosition>k__BackingField;

		[Token(Token = "0x4000381")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8CC554", Offset = "0x8CC554")]
		private Quaternion <initialLocalRotation>k__BackingField;

		[Token(Token = "0x4000382")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8CC564", Offset = "0x8CC564")]
		private Vector3 <right>k__BackingField;

		[Token(Token = "0x4000383")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8CC574", Offset = "0x8CC574")]
		private Vector3 <up>k__BackingField;

		[Token(Token = "0x4000384")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8CC584", Offset = "0x8CC584")]
		private Vector3 <forward>k__BackingField;

		[Token(Token = "0x4000385")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8CC594", Offset = "0x8CC594")]
		private Vector3 <dright>k__BackingField;

		[Token(Token = "0x4000386")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8CC5A4", Offset = "0x8CC5A4")]
		private Vector3 <dup>k__BackingField;

		[Token(Token = "0x4000387")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8CC5B4", Offset = "0x8CC5B4")]
		private Vector3 <dforward>k__BackingField;

		[Token(Token = "0x4000388")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8CC5C4", Offset = "0x8CC5C4")]
		private Vector3 <fromParentForward>k__BackingField;

		[Token(Token = "0x4000389")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8CC5D4", Offset = "0x8CC5D4")]
		private Vector3 <fromParentCross>k__BackingField;

		[Token(Token = "0x400038A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8CC5E4", Offset = "0x8CC5E4")]
		private Vector3 <keyframedPosition>k__BackingField;

		[Token(Token = "0x400038B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8CC5F4", Offset = "0x8CC5F4")]
		private Quaternion <keyframedRotation>k__BackingField;

		[Token(Token = "0x400038C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8CC604", Offset = "0x8CC604")]
		private Quaternion <mapping>k__BackingField;

		[Token(Token = "0x400038D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8CC614", Offset = "0x8CC614")]
		private Quaternion <dmapping>k__BackingField;

		[Token(Token = "0x400038E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8CC624", Offset = "0x8CC624")]
		private Transform <root>k__BackingField;

		[Token(Token = "0x400038F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8CC634", Offset = "0x8CC634")]
		private Vector3 <forwardReference>k__BackingField;

		[Token(Token = "0x4000390")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8CC644", Offset = "0x8CC644")]
		private Vector3 <upReference>k__BackingField;

		[Token(Token = "0x4000391")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8CC654", Offset = "0x8CC654")]
		private Vector3 <rightCrossReference>k__BackingField;

		[Token(Token = "0x4000392")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xFC")]
		private Vector3 dynamicUpReference;

		[Token(Token = "0x17000061")]
		public Transform transform
		{
			[Token(Token = "0x6000343")]
			[Address(RVA = "0x11765F0", Offset = "0x11765F0", VA = "0x11765F0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8D205C", Offset = "0x8D205C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000344")]
			[Address(RVA = "0x11765F8", Offset = "0x11765F8", VA = "0x11765F8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8D206C", Offset = "0x8D206C")]
			protected set
			{
			}
		}

		[Token(Token = "0x17000062")]
		public Vector3 initialLocalPosition
		{
			[Token(Token = "0x6000345")]
			[Address(RVA = "0x1176600", Offset = "0x1176600", VA = "0x1176600")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8D207C", Offset = "0x8D207C")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000346")]
			[Address(RVA = "0x117660C", Offset = "0x117660C", VA = "0x117660C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8D208C", Offset = "0x8D208C")]
			protected set
			{
			}
		}

		[Token(Token = "0x17000063")]
		public Quaternion initialLocalRotation
		{
			[Token(Token = "0x6000347")]
			[Address(RVA = "0x1176618", Offset = "0x1176618", VA = "0x1176618")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8D209C", Offset = "0x8D209C")]
			get
			{
				return default(Quaternion);
			}
			[Token(Token = "0x6000348")]
			[Address(RVA = "0x1176624", Offset = "0x1176624", VA = "0x1176624")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8D20AC", Offset = "0x8D20AC")]
			protected set
			{
			}
		}

		[Token(Token = "0x17000064")]
		public Vector3 right
		{
			[Token(Token = "0x6000349")]
			[Address(RVA = "0x1176630", Offset = "0x1176630", VA = "0x1176630")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8D20BC", Offset = "0x8D20BC")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x600034A")]
			[Address(RVA = "0x117663C", Offset = "0x117663C", VA = "0x117663C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8D20CC", Offset = "0x8D20CC")]
			protected set
			{
			}
		}

		[Token(Token = "0x17000065")]
		public Vector3 up
		{
			[Token(Token = "0x600034B")]
			[Address(RVA = "0x1176648", Offset = "0x1176648", VA = "0x1176648")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8D20DC", Offset = "0x8D20DC")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x600034C")]
			[Address(RVA = "0x1176654", Offset = "0x1176654", VA = "0x1176654")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8D20EC", Offset = "0x8D20EC")]
			protected set
			{
			}
		}

		[Token(Token = "0x17000066")]
		public Vector3 forward
		{
			[Token(Token = "0x600034D")]
			[Address(RVA = "0x1176660", Offset = "0x1176660", VA = "0x1176660")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8D20FC", Offset = "0x8D20FC")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x600034E")]
			[Address(RVA = "0x117666C", Offset = "0x117666C", VA = "0x117666C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8D210C", Offset = "0x8D210C")]
			protected set
			{
			}
		}

		[Token(Token = "0x17000067")]
		public Vector3 dright
		{
			[Token(Token = "0x600034F")]
			[Address(RVA = "0x1176678", Offset = "0x1176678", VA = "0x1176678")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8D211C", Offset = "0x8D211C")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000350")]
			[Address(RVA = "0x1176684", Offset = "0x1176684", VA = "0x1176684")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8D212C", Offset = "0x8D212C")]
			protected set
			{
			}
		}

		[Token(Token = "0x17000068")]
		public Vector3 dup
		{
			[Token(Token = "0x6000351")]
			[Address(RVA = "0x1176690", Offset = "0x1176690", VA = "0x1176690")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8D213C", Offset = "0x8D213C")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000352")]
			[Address(RVA = "0x117669C", Offset = "0x117669C", VA = "0x117669C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8D214C", Offset = "0x8D214C")]
			protected set
			{
			}
		}

		[Token(Token = "0x17000069")]
		public Vector3 dforward
		{
			[Token(Token = "0x6000353")]
			[Address(RVA = "0x11766A8", Offset = "0x11766A8", VA = "0x11766A8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8D215C", Offset = "0x8D215C")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000354")]
			[Address(RVA = "0x11766B4", Offset = "0x11766B4", VA = "0x11766B4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8D216C", Offset = "0x8D216C")]
			protected set
			{
			}
		}

		[Token(Token = "0x1700006A")]
		public Vector3 fromParentForward
		{
			[Token(Token = "0x6000355")]
			[Address(RVA = "0x11766C0", Offset = "0x11766C0", VA = "0x11766C0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8D217C", Offset = "0x8D217C")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000356")]
			[Address(RVA = "0x11766CC", Offset = "0x11766CC", VA = "0x11766CC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8D218C", Offset = "0x8D218C")]
			protected set
			{
			}
		}

		[Token(Token = "0x1700006B")]
		public Vector3 fromParentCross
		{
			[Token(Token = "0x6000357")]
			[Address(RVA = "0x11766D8", Offset = "0x11766D8", VA = "0x11766D8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8D219C", Offset = "0x8D219C")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000358")]
			[Address(RVA = "0x11766E4", Offset = "0x11766E4", VA = "0x11766E4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8D21AC", Offset = "0x8D21AC")]
			protected set
			{
			}
		}

		[Token(Token = "0x1700006C")]
		public Vector3 keyframedPosition
		{
			[Token(Token = "0x6000359")]
			[Address(RVA = "0x11766F0", Offset = "0x11766F0", VA = "0x11766F0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8D21BC", Offset = "0x8D21BC")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x600035A")]
			[Address(RVA = "0x11766FC", Offset = "0x11766FC", VA = "0x11766FC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8D21CC", Offset = "0x8D21CC")]
			protected set
			{
			}
		}

		[Token(Token = "0x1700006D")]
		public Quaternion keyframedRotation
		{
			[Token(Token = "0x600035B")]
			[Address(RVA = "0x1176708", Offset = "0x1176708", VA = "0x1176708")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8D21DC", Offset = "0x8D21DC")]
			get
			{
				return default(Quaternion);
			}
			[Token(Token = "0x600035C")]
			[Address(RVA = "0x1176714", Offset = "0x1176714", VA = "0x1176714")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8D21EC", Offset = "0x8D21EC")]
			protected set
			{
			}
		}

		[Token(Token = "0x1700006E")]
		public Quaternion mapping
		{
			[Token(Token = "0x600035D")]
			[Address(RVA = "0x1176720", Offset = "0x1176720", VA = "0x1176720")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8D21FC", Offset = "0x8D21FC")]
			get
			{
				return default(Quaternion);
			}
			[Token(Token = "0x600035E")]
			[Address(RVA = "0x117672C", Offset = "0x117672C", VA = "0x117672C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8D220C", Offset = "0x8D220C")]
			protected set
			{
			}
		}

		[Token(Token = "0x1700006F")]
		public Quaternion dmapping
		{
			[Token(Token = "0x600035F")]
			[Address(RVA = "0x1176738", Offset = "0x1176738", VA = "0x1176738")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8D221C", Offset = "0x8D221C")]
			get
			{
				return default(Quaternion);
			}
			[Token(Token = "0x6000360")]
			[Address(RVA = "0x1176744", Offset = "0x1176744", VA = "0x1176744")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8D222C", Offset = "0x8D222C")]
			protected set
			{
			}
		}

		[Token(Token = "0x17000070")]
		public Transform root
		{
			[Token(Token = "0x6000361")]
			[Address(RVA = "0x1176750", Offset = "0x1176750", VA = "0x1176750")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8D223C", Offset = "0x8D223C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000362")]
			[Address(RVA = "0x1176758", Offset = "0x1176758", VA = "0x1176758")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8D224C", Offset = "0x8D224C")]
			protected set
			{
			}
		}

		[Token(Token = "0x17000071")]
		public Vector3 forwardReference
		{
			[Token(Token = "0x6000365")]
			[Address(RVA = "0x1176CB4", Offset = "0x1176CB4", VA = "0x1176CB4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8D225C", Offset = "0x8D225C")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000366")]
			[Address(RVA = "0x1176CC0", Offset = "0x1176CC0", VA = "0x1176CC0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8D226C", Offset = "0x8D226C")]
			private set
			{
			}
		}

		[Token(Token = "0x17000072")]
		public Vector3 upReference
		{
			[Token(Token = "0x6000367")]
			[Address(RVA = "0x1176CCC", Offset = "0x1176CCC", VA = "0x1176CCC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8D227C", Offset = "0x8D227C")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000368")]
			[Address(RVA = "0x1176CD8", Offset = "0x1176CD8", VA = "0x1176CD8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8D228C", Offset = "0x8D228C")]
			private set
			{
			}
		}

		[Token(Token = "0x17000073")]
		public Vector3 rightCrossReference
		{
			[Token(Token = "0x6000369")]
			[Address(RVA = "0x1176CE4", Offset = "0x1176CE4", VA = "0x1176CE4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8D229C", Offset = "0x8D229C")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x600036A")]
			[Address(RVA = "0x1176CF0", Offset = "0x1176CF0", VA = "0x1176CF0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8D22AC", Offset = "0x8D22AC")]
			private set
			{
			}
		}

		[Token(Token = "0x6000363")]
		[Address(RVA = "0x1176760", Offset = "0x1176760", VA = "0x1176760")]
		public UniRotateBone(Transform t, Transform root)
		{
		}

		[Token(Token = "0x6000364")]
		[Address(RVA = "0x1176C34", Offset = "0x1176C34", VA = "0x1176C34")]
		public Vector3 GetFromParentForward()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600036B")]
		[Address(RVA = "0x1176CFC", Offset = "0x1176CFC", VA = "0x1176CFC")]
		public Quaternion GetRootCompensateRotation(Quaternion initPelvisInWorld, Quaternion currInWorld, float armsRootCompensate)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600036C")]
		[Address(RVA = "0x1176E50", Offset = "0x1176E50", VA = "0x1176E50")]
		public void RefreshCustomAxis(Vector3 up, Vector3 forward)
		{
		}

		[Token(Token = "0x600036D")]
		[Address(RVA = "0x1176FC8", Offset = "0x1176FC8", VA = "0x1176FC8")]
		public void RefreshCustomAxis(Vector3 up, Vector3 forward, Quaternion customParentRot)
		{
		}

		[Token(Token = "0x600036E")]
		[Address(RVA = "0x1177130", Offset = "0x1177130", VA = "0x1177130")]
		public Quaternion RotateCustomAxis(float x, float y, UniRotateBone oRef)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600036F")]
		[Address(RVA = "0x1177388", Offset = "0x1177388", VA = "0x1177388")]
		public Vector2 GetCustomLookAngles(Vector3 direction, UniRotateBone orientationsReference)
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000370")]
		[Address(RVA = "0x11774F0", Offset = "0x11774F0", VA = "0x11774F0")]
		public static float AngleAroundAxis(Vector3 firstDirection, Vector3 secondDirection, Vector3 axis)
		{
			return default(float);
		}

		[Token(Token = "0x6000371")]
		[Address(RVA = "0x1177624", Offset = "0x1177624", VA = "0x1177624")]
		public Quaternion DynamicMapping()
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000372")]
		[Address(RVA = "0x1177730", Offset = "0x1177730", VA = "0x1177730")]
		public void CaptureKeyframeAnimation()
		{
		}

		[Token(Token = "0x6000373")]
		[Address(RVA = "0x1177780", Offset = "0x1177780", VA = "0x1177780")]
		public void RotateBy(float x, float y, float z)
		{
		}

		[Token(Token = "0x6000374")]
		[Address(RVA = "0x1177904", Offset = "0x1177904", VA = "0x1177904")]
		public void RotateBy(Vector3 angles)
		{
		}

		[Token(Token = "0x6000375")]
		[Address(RVA = "0x1177908", Offset = "0x1177908", VA = "0x1177908")]
		public void RotateBy(Vector3 angles, float blend)
		{
		}

		[Token(Token = "0x6000376")]
		[Address(RVA = "0x11779B0", Offset = "0x11779B0", VA = "0x11779B0")]
		public void RotateByDynamic(float x, float y, float z)
		{
		}

		[Token(Token = "0x6000377")]
		[Address(RVA = "0x1177BD0", Offset = "0x1177BD0", VA = "0x1177BD0")]
		public Quaternion GetAngleRotation(float x, float y, float z)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000378")]
		[Address(RVA = "0x1177D3C", Offset = "0x1177D3C", VA = "0x1177D3C")]
		public Quaternion GetAngleRotationDynamic(float x, float y, float z)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000379")]
		[Address(RVA = "0x1177F48", Offset = "0x1177F48", VA = "0x1177F48")]
		public Quaternion GetAngleRotationDynamic(Vector3 angles)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600037A")]
		[Address(RVA = "0x1177F4C", Offset = "0x1177F4C", VA = "0x1177F4C")]
		public void RotateByDynamic(Vector3 angles, float blend)
		{
		}

		[Token(Token = "0x600037B")]
		[Address(RVA = "0x1177FD8", Offset = "0x1177FD8", VA = "0x1177FD8")]
		public void RotateByDynamic(float x, float y, float z, float blend)
		{
		}

		[Token(Token = "0x600037C")]
		[Address(RVA = "0x1178064", Offset = "0x1178064", VA = "0x1178064")]
		public void RotateByDynamic(float x, float y, float z, Quaternion orientation)
		{
		}

		[Token(Token = "0x600037D")]
		[Address(RVA = "0x11782E0", Offset = "0x11782E0", VA = "0x11782E0")]
		public void RotateXBy(float angle)
		{
		}

		[Token(Token = "0x600037E")]
		[Address(RVA = "0x1178388", Offset = "0x1178388", VA = "0x1178388")]
		public void RotateYBy(float angle)
		{
		}

		[Token(Token = "0x600037F")]
		[Address(RVA = "0x1178430", Offset = "0x1178430", VA = "0x1178430")]
		public void RotateZBy(float angle)
		{
		}

		[Token(Token = "0x6000380")]
		[Address(RVA = "0x11784D8", Offset = "0x11784D8", VA = "0x11784D8")]
		public void PreCalibrate()
		{
		}

		[Token(Token = "0x6000381")]
		[Address(RVA = "0x1178524", Offset = "0x1178524", VA = "0x1178524")]
		public Quaternion RotationTowards(Vector3 toDir)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000382")]
		[Address(RVA = "0x1178618", Offset = "0x1178618", VA = "0x1178618")]
		public Quaternion RotationTowardsDynamic(Vector3 toDir)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000383")]
		[Address(RVA = "0x1177994", Offset = "0x1177994", VA = "0x1177994")]
		public static float BlendAngle(float angle, float blend)
		{
			return default(float);
		}

		[Token(Token = "0x6000384")]
		[Address(RVA = "0x1178738", Offset = "0x1178738", VA = "0x1178738")]
		public Vector3 Dir(Vector3 forward)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000385")]
		[Address(RVA = "0x1178754", Offset = "0x1178754", VA = "0x1178754")]
		public Vector3 IDir(Vector3 forward)
		{
			return default(Vector3);
		}
	}
}
namespace FIMSpace.Basics
{
	[Token(Token = "0x200009F")]
	public class FBasic_FreeCameraBehaviour : MonoBehaviour
	{
		[Token(Token = "0x4000393")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x8CC664", Offset = "0x8CC664")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8CC664", Offset = "0x8CC664")]
		public float SpeedMultiplier;

		[Token(Token = "0x4000394")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8CC6C4", Offset = "0x8CC6C4")]
		public float AccelerationSmothnessValue;

		[Token(Token = "0x4000395")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8CC6FC", Offset = "0x8CC6FC")]
		public float RotationSmothnessValue;

		[Token(Token = "0x4000396")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float MouseSensitivity;

		[Token(Token = "0x4000397")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool NeedRMB;

		[Token(Token = "0x4000398")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private float turboModeMultiply;

		[Token(Token = "0x4000399")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Vector3 speeds;

		[Token(Token = "0x400039A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private float ySpeed;

		[Token(Token = "0x400039B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Vector3 rotation;

		[Token(Token = "0x400039C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private float turbo;

		[Token(Token = "0x6000386")]
		[Address(RVA = "0x1E81E1C", Offset = "0x1E81E1C", VA = "0x1E81E1C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000387")]
		[Address(RVA = "0x1E81E90", Offset = "0x1E81E90", VA = "0x1E81E90")]
		private void Update()
		{
		}

		[Token(Token = "0x6000388")]
		[Address(RVA = "0x1E8236C", Offset = "0x1E8236C", VA = "0x1E8236C")]
		public void FixedUpdate()
		{
		}

		[Token(Token = "0x6000389")]
		[Address(RVA = "0x1E823D4", Offset = "0x1E823D4", VA = "0x1E823D4")]
		public FBasic_FreeCameraBehaviour()
		{
		}
	}
	[Token(Token = "0x20000A0")]
	[AttributeAttribute(Name = "DefaultExecutionOrder", RVA = "0x8CB1A0", Offset = "0x8CB1A0")]
	public class FBasic_TPPCameraBehaviour : MonoBehaviour
	{
		[Token(Token = "0x400039D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x8CC734", Offset = "0x8CC734")]
		public Transform ToFollow;

		[Token(Token = "0x400039E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x8CC76C", Offset = "0x8CC76C")]
		public Vector3 FollowingOffset;

		[Token(Token = "0x400039F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x8CC7A4", Offset = "0x8CC7A4")]
		public Vector3 FollowingOffsetDirection;

		[Token(Token = "0x40003A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x8CC7DC", Offset = "0x8CC7DC")]
		public Vector2 DistanceRanges;

		[Token(Token = "0x40003A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private float targetDistance;

		[Token(Token = "0x40003A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private float animatedDistance;

		[Token(Token = "0x40003A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Vector2 RotationRanges;

		[Token(Token = "0x40003A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Vector2 targetSphericRotation;

		[Token(Token = "0x40003A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Vector2 animatedSphericRotation;

		[Token(Token = "0x40003A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x8CC814", Offset = "0x8CC814")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8CC814", Offset = "0x8CC814")]
		public float RotationSensitivity;

		[Token(Token = "0x40003A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x8CC864", Offset = "0x8CC864")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8CC864", Offset = "0x8CC864")]
		public float RotationSpeed;

		[Token(Token = "0x40003A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8CC8BC", Offset = "0x8CC8BC")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x8CC8BC", Offset = "0x8CC8BC")]
		public float HardFollowValue;

		[Token(Token = "0x40003A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x8CC910", Offset = "0x8CC910")]
		public bool LockCursor;

		[Token(Token = "0x40003AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6D")]
		private bool rotateCamera;

		[Token(Token = "0x40003AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private RaycastHit sightObstacleHit;

		[Token(Token = "0x40003AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x8CC948", Offset = "0x8CC948")]
		public LayerMask SightLayerMask;

		[Token(Token = "0x40003AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private Vector3 targetPosition;

		[Token(Token = "0x40003AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x8CC980", Offset = "0x8CC980")]
		public float CollisionOffset;

		[Token(Token = "0x40003AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public EFUpdateClock UpdateClock;

		[Token(Token = "0x600038A")]
		[Address(RVA = "0x1E82400", Offset = "0x1E82400", VA = "0x1E82400")]
		private void Start()
		{
		}

		[Token(Token = "0x600038B")]
		[Address(RVA = "0x1E82474", Offset = "0x1E82474", VA = "0x1E82474")]
		private void UpdateMethods()
		{
		}

		[Token(Token = "0x600038C")]
		[Address(RVA = "0x1E82B48", Offset = "0x1E82B48", VA = "0x1E82B48")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600038D")]
		[Address(RVA = "0x1E82B5C", Offset = "0x1E82B5C", VA = "0x1E82B5C")]
		private void Update()
		{
		}

		[Token(Token = "0x600038E")]
		[Address(RVA = "0x1E82C40", Offset = "0x1E82C40", VA = "0x1E82C40")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x600038F")]
		[Address(RVA = "0x1E824B0", Offset = "0x1E824B0", VA = "0x1E824B0")]
		private void InputCalculations()
		{
		}

		[Token(Token = "0x6000390")]
		[Address(RVA = "0x1E8259C", Offset = "0x1E8259C", VA = "0x1E8259C")]
		private void ZoomCalculations()
		{
		}

		[Token(Token = "0x6000391")]
		[Address(RVA = "0x1E82668", Offset = "0x1E82668", VA = "0x1E82668")]
		private void FollowCalculations()
		{
		}

		[Token(Token = "0x6000392")]
		[Address(RVA = "0x1E82840", Offset = "0x1E82840", VA = "0x1E82840")]
		private void RaycastCalculations()
		{
		}

		[Token(Token = "0x6000393")]
		[Address(RVA = "0x1E82AF4", Offset = "0x1E82AF4", VA = "0x1E82AF4")]
		private void SwitchCalculations()
		{
		}

		[Token(Token = "0x6000394")]
		[Address(RVA = "0x1E82C54", Offset = "0x1E82C54", VA = "0x1E82C54")]
		private float HelperClampAngle(float angle, float min, float max)
		{
			return default(float);
		}

		[Token(Token = "0x6000395")]
		[Address(RVA = "0x1E82BE8", Offset = "0x1E82BE8", VA = "0x1E82BE8")]
		private void HelperSwitchCursor()
		{
		}

		[Token(Token = "0x6000396")]
		[Address(RVA = "0x1E82C84", Offset = "0x1E82C84", VA = "0x1E82C84")]
		public FBasic_TPPCameraBehaviour()
		{
		}
	}
	[Token(Token = "0x20000A1")]
	public class FBasic_TestGroundMovement : MonoBehaviour
	{
		[Token(Token = "0x40003B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x8CC9B8", Offset = "0x8CC9B8")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x8CC9B8", Offset = "0x8CC9B8")]
		[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x8CC9B8", Offset = "0x8CC9B8")]
		public float RotationYAxis;

		[Token(Token = "0x40003B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8CCA48", Offset = "0x8CCA48")]
		public float FittingSpeed;

		[Token(Token = "0x40003B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float RaycastHeightOffset;

		[Token(Token = "0x40003B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float RaycastCheckRange;

		[Token(Token = "0x40003B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float LookAheadRaycast;

		[Token(Token = "0x40003B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float AheadBlend;

		[Token(Token = "0x40003B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float YOffset;

		[Token(Token = "0x40003B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x8CCA60", Offset = "0x8CCA60")]
		public LayerMask GroundLayerMask;

		[Token(Token = "0x40003B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public bool RelativeLookUp;

		[Token(Token = "0x40003B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8CCA74", Offset = "0x8CCA74")]
		public float RelativeLookUpBias;

		[Token(Token = "0x40003BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8CCA8C", Offset = "0x8CCA8C")]
		private RaycastHit <LastRaycast>k__BackingField;

		[Token(Token = "0x40003BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		protected Quaternion helperRotation;

		[Token(Token = "0x40003BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		protected float delta;

		[Token(Token = "0x40003BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		protected bool fittingEnabled;

		[Token(Token = "0x40003BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x8CCA9C", Offset = "0x8CCA9C")]
		public float BaseSpeed;

		[Token(Token = "0x40003BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public float RotateToTargetSpeed;

		[Token(Token = "0x40003C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		public float SprintingSpeed;

		[Token(Token = "0x40003C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		protected float ActiveSpeed;

		[Token(Token = "0x40003C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		public float AccelerationSpeed;

		[Token(Token = "0x40003C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public float DecelerationSpeed;

		[Token(Token = "0x40003C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		public float JumpPower;

		[Token(Token = "0x40003C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public float gravity;

		[Token(Token = "0x40003C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		public bool MultiplySprintAnimation;

		[Token(Token = "0x40003C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		internal float YVelocity;

		[Token(Token = "0x40003C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		protected bool inAir;

		[Token(Token = "0x40003C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		protected float gravityOffset;

		[Token(Token = "0x40003CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		internal bool MoveForward;

		[Token(Token = "0x40003CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB5")]
		internal bool Sprint;

		[Token(Token = "0x40003CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		internal float RotationOffset;

		[Token(Token = "0x40003CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		protected string lastAnim;

		[Token(Token = "0x40003CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		protected Animator animator;

		[Token(Token = "0x40003CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		protected bool animatorHaveAnimationSpeedProp;

		[Token(Token = "0x40003D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		protected float initialYOffset;

		[Token(Token = "0x40003D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		protected Vector3 holdJumpPosition;

		[Token(Token = "0x40003D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		protected float freezeJumpYPosition;

		[Token(Token = "0x40003D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private bool oneAnimation;

		[Token(Token = "0x40003D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE9")]
		private bool jumpAnimation;

		[Token(Token = "0x17000074")]
		public RaycastHit LastRaycast
		{
			[Token(Token = "0x6000397")]
			[Address(RVA = "0x1E82CD8", Offset = "0x1E82CD8", VA = "0x1E82CD8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8D22BC", Offset = "0x8D22BC")]
			get
			{
				return default(RaycastHit);
			}
			[Token(Token = "0x6000398")]
			[Address(RVA = "0x1E82CEC", Offset = "0x1E82CEC", VA = "0x1E82CEC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8D22CC", Offset = "0x8D22CC")]
			protected set
			{
			}
		}

		[Token(Token = "0x6000399")]
		[Address(RVA = "0x1E82D08", Offset = "0x1E82D08", VA = "0x1E82D08")]
		private Vector3 GetUpVector()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600039A")]
		[Address(RVA = "0x1E82DB8", Offset = "0x1E82DB8", VA = "0x1E82DB8", Slot = "4")]
		protected virtual void FitToGround()
		{
		}

		[Token(Token = "0x600039B")]
		[Address(RVA = "0x1E83234", Offset = "0x1E83234", VA = "0x1E83234")]
		internal void RotationCalculations()
		{
		}

		[Token(Token = "0x600039C")]
		[Address(RVA = "0x1E83300", Offset = "0x1E83300", VA = "0x1E83300")]
		internal RaycastHit CastRay()
		{
			return default(RaycastHit);
		}

		[Token(Token = "0x600039D")]
		[Address(RVA = "0x1E831F8", Offset = "0x1E831F8", VA = "0x1E831F8")]
		internal void RefreshLastRaycast()
		{
		}

		[Token(Token = "0x600039E")]
		[Address(RVA = "0x1E8340C", Offset = "0x1E8340C", VA = "0x1E8340C", Slot = "5")]
		protected virtual void InitMovement()
		{
		}

		[Token(Token = "0x600039F")]
		[Address(RVA = "0x1E83680", Offset = "0x1E83680", VA = "0x1E83680", Slot = "6")]
		protected virtual void UpdateMovement()
		{
		}

		[Token(Token = "0x60003A0")]
		[Address(RVA = "0x1E836E4", Offset = "0x1E836E4", VA = "0x1E836E4", Slot = "7")]
		protected virtual void HandleInput()
		{
		}

		[Token(Token = "0x60003A1")]
		[Address(RVA = "0x1E83844", Offset = "0x1E83844", VA = "0x1E83844", Slot = "8")]
		protected virtual void HandleGravity()
		{
		}

		[Token(Token = "0x60003A2")]
		[Address(RVA = "0x1E83B60", Offset = "0x1E83B60", VA = "0x1E83B60", Slot = "9")]
		protected virtual void HandleAnimations()
		{
		}

		[Token(Token = "0x60003A3")]
		[Address(RVA = "0x1E83D0C", Offset = "0x1E83D0C", VA = "0x1E83D0C")]
		protected void RefreshHitGroundVars(RaycastHit hit)
		{
		}

		[Token(Token = "0x60003A4")]
		[Address(RVA = "0x1E83DB4", Offset = "0x1E83DB4", VA = "0x1E83DB4", Slot = "10")]
		protected virtual void HandleTransforming()
		{
		}

		[Token(Token = "0x60003A5")]
		[Address(RVA = "0x1E840AC", Offset = "0x1E840AC", VA = "0x1E840AC", Slot = "11")]
		protected virtual void HitGround()
		{
		}

		[Token(Token = "0x60003A6")]
		[Address(RVA = "0x1E840F8", Offset = "0x1E840F8", VA = "0x1E840F8", Slot = "12")]
		public virtual void Jump()
		{
		}

		[Token(Token = "0x60003A7")]
		[Address(RVA = "0x1E8419C", Offset = "0x1E8419C", VA = "0x1E8419C", Slot = "13")]
		protected virtual void CrossfadeTo(string animation, float transitionTime = 0.25f)
		{
		}

		[Token(Token = "0x60003A8")]
		[Address(RVA = "0x1E835E0", Offset = "0x1E835E0", VA = "0x1E835E0")]
		public static bool HasParameter(Animator animator, string paramName)
		{
			return default(bool);
		}

		[Token(Token = "0x60003A9")]
		[Address(RVA = "0x1E842AC", Offset = "0x1E842AC", VA = "0x1E842AC")]
		private void Start()
		{
		}

		[Token(Token = "0x60003AA")]
		[Address(RVA = "0x1E842B8", Offset = "0x1E842B8", VA = "0x1E842B8")]
		private void Update()
		{
		}

		[Token(Token = "0x60003AB")]
		[Address(RVA = "0x1E84304", Offset = "0x1E84304", VA = "0x1E84304")]
		public FBasic_TestGroundMovement()
		{
		}
	}
	[Token(Token = "0x20000A2")]
	public class FAnimationClips : Dictionary<string, int>
	{
		[Token(Token = "0x40003D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public readonly Animator Animator;

		[Token(Token = "0x40003D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8CCAD4", Offset = "0x8CCAD4")]
		private string <CurrentAnimation>k__BackingField;

		[Token(Token = "0x40003D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8CCAE4", Offset = "0x8CCAE4")]
		private string <PreviousAnimation>k__BackingField;

		[Token(Token = "0x40003D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public int Layer;

		[Token(Token = "0x17000075")]
		public string CurrentAnimation
		{
			[Token(Token = "0x60003AC")]
			[Address(RVA = "0x1E80C48", Offset = "0x1E80C48", VA = "0x1E80C48")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8D22DC", Offset = "0x8D22DC")]
			get
			{
				return null;
			}
			[Token(Token = "0x60003AD")]
			[Address(RVA = "0x1E80C50", Offset = "0x1E80C50", VA = "0x1E80C50")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8D22EC", Offset = "0x8D22EC")]
			private set
			{
			}
		}

		[Token(Token = "0x17000076")]
		public string PreviousAnimation
		{
			[Token(Token = "0x60003AE")]
			[Address(RVA = "0x1E80C58", Offset = "0x1E80C58", VA = "0x1E80C58")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8D22FC", Offset = "0x8D22FC")]
			get
			{
				return null;
			}
			[Token(Token = "0x60003AF")]
			[Address(RVA = "0x1E80C60", Offset = "0x1E80C60", VA = "0x1E80C60")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8D230C", Offset = "0x8D230C")]
			private set
			{
			}
		}

		[Token(Token = "0x60003B0")]
		[Address(RVA = "0x1E80C68", Offset = "0x1E80C68", VA = "0x1E80C68")]
		public FAnimationClips(Animator animator)
		{
		}

		[Token(Token = "0x60003B1")]
		[Address(RVA = "0x1E80D04", Offset = "0x1E80D04", VA = "0x1E80D04")]
		public void Add(string clipName, bool exactClipName = false)
		{
		}

		[Token(Token = "0x60003B2")]
		[Address(RVA = "0x1E80D18", Offset = "0x1E80D18", VA = "0x1E80D18")]
		public void AddClip(string clipName, bool exactClipName = false)
		{
		}

		[Token(Token = "0x60003B3")]
		[Address(RVA = "0x1E80D2C", Offset = "0x1E80D2C", VA = "0x1E80D2C")]
		public void AddClip(Animator animator, string clipName, bool exactClipName = false)
		{
		}

		[Token(Token = "0x60003B4")]
		[Address(RVA = "0x1E81054", Offset = "0x1E81054", VA = "0x1E81054")]
		public void CrossFadeInFixedTime(string clip, float transitionTime = 0.25f, float timeOffset = 0f, bool startOver = false)
		{
		}

		[Token(Token = "0x60003B5")]
		[Address(RVA = "0x1E812AC", Offset = "0x1E812AC", VA = "0x1E812AC")]
		public void CrossFade(string clip, float transitionTime = 0.25f, float timeOffset = 0f, bool startOver = false)
		{
		}

		[Token(Token = "0x60003B6")]
		[Address(RVA = "0x1E81148", Offset = "0x1E81148", VA = "0x1E81148")]
		private void RefreshClipMemory(string name)
		{
		}

		[Token(Token = "0x60003B7")]
		[Address(RVA = "0x1E813A0", Offset = "0x1E813A0", VA = "0x1E813A0")]
		public void SetFloat(string parameter, float value = 0f, float deltaSpeed = 60f)
		{
		}

		[Token(Token = "0x60003B8")]
		[Address(RVA = "0x1E8143C", Offset = "0x1E8143C", VA = "0x1E8143C")]
		public void SetFloatUnscaledDelta(string parameter, float value = 0f, float deltaSpeed = 60f)
		{
		}

		[Token(Token = "0x60003B9")]
		[Address(RVA = "0x1E811B8", Offset = "0x1E811B8", VA = "0x1E811B8")]
		internal bool IsPlaying(string clip)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x20000A3")]
	public class FAnimator
	{
		[Token(Token = "0x40003D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public readonly Animator Animator;

		[Token(Token = "0x40003DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8CCAF4", Offset = "0x8CCAF4")]
		private string <CurrentAnimation>k__BackingField;

		[Token(Token = "0x40003DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8CCB04", Offset = "0x8CCB04")]
		private string <PreviousAnimation>k__BackingField;

		[Token(Token = "0x40003DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8CCB14", Offset = "0x8CCB14")]
		private int <Layer>k__BackingField;

		[Token(Token = "0x17000077")]
		public string CurrentAnimation
		{
			[Token(Token = "0x60003BA")]
			[Address(RVA = "0x1E814D8", Offset = "0x1E814D8", VA = "0x1E814D8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8D231C", Offset = "0x8D231C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60003BB")]
			[Address(RVA = "0x1E814E0", Offset = "0x1E814E0", VA = "0x1E814E0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8D232C", Offset = "0x8D232C")]
			private set
			{
			}
		}

		[Token(Token = "0x17000078")]
		public string PreviousAnimation
		{
			[Token(Token = "0x60003BC")]
			[Address(RVA = "0x1E814E8", Offset = "0x1E814E8", VA = "0x1E814E8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8D233C", Offset = "0x8D233C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60003BD")]
			[Address(RVA = "0x1E814F0", Offset = "0x1E814F0", VA = "0x1E814F0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8D234C", Offset = "0x8D234C")]
			private set
			{
			}
		}

		[Token(Token = "0x17000079")]
		public int Layer
		{
			[Token(Token = "0x60003BE")]
			[Address(RVA = "0x1E814F8", Offset = "0x1E814F8", VA = "0x1E814F8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8D235C", Offset = "0x8D235C")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60003BF")]
			[Address(RVA = "0x1E81500", Offset = "0x1E81500", VA = "0x1E81500")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8D236C", Offset = "0x8D236C")]
			private set
			{
			}
		}

		[Token(Token = "0x60003C0")]
		[Address(RVA = "0x1E81508", Offset = "0x1E81508", VA = "0x1E81508")]
		public FAnimator(Animator animator, int layer = 0)
		{
		}

		[Token(Token = "0x60003C1")]
		[Address(RVA = "0x1E8159C", Offset = "0x1E8159C", VA = "0x1E8159C")]
		public bool ContainsClip(string clipName, bool exactClipName = false)
		{
			return default(bool);
		}

		[Token(Token = "0x60003C2")]
		[Address(RVA = "0x1E81810", Offset = "0x1E81810", VA = "0x1E81810")]
		public void CrossFadeInFixedTime(string clip, float transitionTime = 0.25f, float timeOffset = 0f, bool startOver = false)
		{
		}

		[Token(Token = "0x60003C3")]
		[Address(RVA = "0x1E819C8", Offset = "0x1E819C8", VA = "0x1E819C8")]
		public void CrossFade(string clip, float transitionTime = 0.25f, float timeOffset = 0f, bool startOver = false)
		{
		}

		[Token(Token = "0x60003C4")]
		[Address(RVA = "0x1E81898", Offset = "0x1E81898", VA = "0x1E81898")]
		private void RefreshClipMemory(string name)
		{
		}

		[Token(Token = "0x60003C5")]
		[Address(RVA = "0x1E81A50", Offset = "0x1E81A50", VA = "0x1E81A50")]
		public void SetFloat(string parameter, float value = 0f, float deltaSpeed = 60f)
		{
		}

		[Token(Token = "0x60003C6")]
		[Address(RVA = "0x1E81AEC", Offset = "0x1E81AEC", VA = "0x1E81AEC")]
		public void SetFloatUnscaledDelta(string parameter, float value = 0f, float deltaSpeed = 60f)
		{
		}

		[Token(Token = "0x60003C7")]
		[Address(RVA = "0x1E81908", Offset = "0x1E81908", VA = "0x1E81908")]
		internal bool IsPlaying(string clip)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x20000A4")]
	public enum EFUpdateClock
	{
		[Token(Token = "0x40003DE")]
		Update,
		[Token(Token = "0x40003DF")]
		LateUpdate,
		[Token(Token = "0x40003E0")]
		FixedUpdate
	}
}
namespace FIMSpace.FTail
{
	[Token(Token = "0x20000A5")]
	[AttributeAttribute(Name = "DefaultExecutionOrder", RVA = "0x8CB1B4", Offset = "0x8CB1B4")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x8CB1B4", Offset = "0x8CB1B4")]
	public class TailAnimator2 : MonoBehaviour, IDropHandler, IEventSystemHandler, IFHierarchyIcon
	{
		[Serializable]
		[Token(Token = "0x20000A6")]
		public class TailSegment
		{
			[Token(Token = "0x40004BB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8CE3FC", Offset = "0x8CE3FC")]
			private TailSegment <ParentBone>k__BackingField;

			[Token(Token = "0x40004BC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8CE40C", Offset = "0x8CE40C")]
			private TailSegment <ChildBone>k__BackingField;

			[Token(Token = "0x40004BD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8CE41C", Offset = "0x8CE41C")]
			private Transform <transform>k__BackingField;

			[Token(Token = "0x40004BE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8CE42C", Offset = "0x8CE42C")]
			private int <Index>k__BackingField;

			[Token(Token = "0x40004BF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8CE43C", Offset = "0x8CE43C")]
			private float <IndexOverlLength>k__BackingField;

			[Token(Token = "0x40004C0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Vector3 ProceduralPosition;

			[Token(Token = "0x40004C1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public Vector3 ProceduralPositionWeightBlended;

			[Token(Token = "0x40004C2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public Quaternion TrueTargetRotation;

			[Token(Token = "0x40004C3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public Quaternion PosRefRotation;

			[Token(Token = "0x40004C4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			public Quaternion PreviousPosReferenceRotation;

			[Token(Token = "0x40004C5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			public Vector3 PreviousPosition;

			[Token(Token = "0x40004C6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
			public float BlendValue;

			[Token(Token = "0x40004C7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8CE44C", Offset = "0x8CE44C")]
			private float <BoneLength>k__BackingField;

			[Token(Token = "0x40004C8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
			public Vector3 BoneDimensionsScaled;

			[Token(Token = "0x40004C9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			public float BoneLengthScaled;

			[Token(Token = "0x40004CA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
			public Vector3 InitialLocalPosition;

			[Token(Token = "0x40004CB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
			public Vector3 InitialLocalPositionInRoot;

			[Token(Token = "0x40004CC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
			public Quaternion InitialLocalRotationInRoot;

			[Token(Token = "0x40004CD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
			public Vector3 LocalOffset;

			[Token(Token = "0x40004CE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
			public Quaternion InitialLocalRotation;

			[Token(Token = "0x40004CF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
			public float ColliderRadius;

			[Token(Token = "0x40004D0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
			public bool CollisionContactFlag;

			[Token(Token = "0x40004D1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
			public float CollisionContactRelevancy;

			[Token(Token = "0x40004D2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
			public Collision collisionContacts;

			[Token(Token = "0x40004D3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
			public Vector3 VelocityHelper;

			[Token(Token = "0x40004D4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
			public Quaternion QVelocityHelper;

			[Token(Token = "0x40004D5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x114")]
			public Vector3 PreviousPush;

			[Token(Token = "0x40004D6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
			public Quaternion Curving;

			[Token(Token = "0x40004D7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
			public Vector3 Gravity;

			[Token(Token = "0x40004D8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x13C")]
			public Vector3 GravityLookOffset;

			[Token(Token = "0x40004D9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
			public float LengthMultiplier;

			[Token(Token = "0x40004DA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14C")]
			public float PositionSpeed;

			[Token(Token = "0x40004DB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
			public float RotationSpeed;

			[Token(Token = "0x40004DC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x154")]
			public float Springiness;

			[Token(Token = "0x40004DD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
			public float Slithery;

			[Token(Token = "0x40004DE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x15C")]
			public float Curling;

			[Token(Token = "0x40004DF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
			public float Slippery;

			[Token(Token = "0x40004E0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8CE45C", Offset = "0x8CE45C")]
			private TailCollisionHelper <CollisionHelper>k__BackingField;

			[Token(Token = "0x40004E1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8CE46C", Offset = "0x8CE46C")]
			private bool <IsDetachable>k__BackingField;

			[Token(Token = "0x40004E2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x174")]
			public Quaternion LastKeyframeLocalRotation;

			[Token(Token = "0x40004E3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x184")]
			public Vector3 LastKeyframeLocalPosition;

			[Token(Token = "0x40004E4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8CE47C", Offset = "0x8CE47C")]
			private Vector3 <LastFinalPosition>k__BackingField;

			[Token(Token = "0x40004E5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x19C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8CE48C", Offset = "0x8CE48C")]
			private Quaternion <LastFinalRotation>k__BackingField;

			[Token(Token = "0x40004E6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1AC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8CE49C", Offset = "0x8CE49C")]
			private float <DeflectionFactor>k__BackingField;

			[Token(Token = "0x40004E7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8CE4AC", Offset = "0x8CE4AC")]
			private Vector3 <Deflection>k__BackingField;

			[Token(Token = "0x40004E8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1BC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8CE4BC", Offset = "0x8CE4BC")]
			private float <DeflectionSmooth>k__BackingField;

			[Token(Token = "0x40004E9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
			private float deflectionSmoothVelo;

			[Token(Token = "0x40004EA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8CE4CC", Offset = "0x8CE4CC")]
			private Vector3 <DeflectionWorldPosition>k__BackingField;

			[Token(Token = "0x40004EB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1D0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8CE4DC", Offset = "0x8CE4DC")]
			private int <DeflectionRelevancy>k__BackingField;

			[Token(Token = "0x40004EC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1D8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8CE4EC", Offset = "0x8CE4EC")]
			private FImp_ColliderData_Base <LatestSelectiveCollision>k__BackingField;

			[Token(Token = "0x17000080")]
			public TailSegment ParentBone
			{
				[Token(Token = "0x6000445")]
				[Address(RVA = "0x11833CC", Offset = "0x11833CC", VA = "0x11833CC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8D243C", Offset = "0x8D243C")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000446")]
				[Address(RVA = "0x11833D4", Offset = "0x11833D4", VA = "0x11833D4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8D244C", Offset = "0x8D244C")]
				private set
				{
				}
			}

			[Token(Token = "0x17000081")]
			public TailSegment ChildBone
			{
				[Token(Token = "0x6000447")]
				[Address(RVA = "0x11833DC", Offset = "0x11833DC", VA = "0x11833DC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8D245C", Offset = "0x8D245C")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000448")]
				[Address(RVA = "0x11833E4", Offset = "0x11833E4", VA = "0x11833E4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8D246C", Offset = "0x8D246C")]
				private set
				{
				}
			}

			[Token(Token = "0x17000082")]
			public Transform transform
			{
				[Token(Token = "0x6000449")]
				[Address(RVA = "0x11833EC", Offset = "0x11833EC", VA = "0x11833EC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8D247C", Offset = "0x8D247C")]
				get
				{
					return null;
				}
				[Token(Token = "0x600044A")]
				[Address(RVA = "0x11833F4", Offset = "0x11833F4", VA = "0x11833F4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8D248C", Offset = "0x8D248C")]
				private set
				{
				}
			}

			[Token(Token = "0x17000083")]
			public int Index
			{
				[Token(Token = "0x600044B")]
				[Address(RVA = "0x11833FC", Offset = "0x11833FC", VA = "0x11833FC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8D249C", Offset = "0x8D249C")]
				get
				{
					return default(int);
				}
				[Token(Token = "0x600044C")]
				[Address(RVA = "0x1183404", Offset = "0x1183404", VA = "0x1183404")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8D24AC", Offset = "0x8D24AC")]
				private set
				{
				}
			}

			[Token(Token = "0x17000084")]
			public float IndexOverlLength
			{
				[Token(Token = "0x600044D")]
				[Address(RVA = "0x118340C", Offset = "0x118340C", VA = "0x118340C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8D24BC", Offset = "0x8D24BC")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x600044E")]
				[Address(RVA = "0x1183414", Offset = "0x1183414", VA = "0x1183414")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8D24CC", Offset = "0x8D24CC")]
				private set
				{
				}
			}

			[Token(Token = "0x17000085")]
			public float BoneLength
			{
				[Token(Token = "0x600044F")]
				[Address(RVA = "0x118341C", Offset = "0x118341C", VA = "0x118341C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8D24DC", Offset = "0x8D24DC")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000450")]
				[Address(RVA = "0x1183424", Offset = "0x1183424", VA = "0x1183424")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8D24EC", Offset = "0x8D24EC")]
				private set
				{
				}
			}

			[Token(Token = "0x17000086")]
			public TailCollisionHelper CollisionHelper
			{
				[Token(Token = "0x6000451")]
				[Address(RVA = "0x118342C", Offset = "0x118342C", VA = "0x118342C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8D24FC", Offset = "0x8D24FC")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000452")]
				[Address(RVA = "0x1183434", Offset = "0x1183434", VA = "0x1183434")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8D250C", Offset = "0x8D250C")]
				internal set
				{
				}
			}

			[Token(Token = "0x17000087")]
			public bool IsDetachable
			{
				[Token(Token = "0x600045B")]
				[Address(RVA = "0x11838F8", Offset = "0x11838F8", VA = "0x11838F8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8D251C", Offset = "0x8D251C")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x600045C")]
				[Address(RVA = "0x1183900", Offset = "0x1183900", VA = "0x1183900")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8D252C", Offset = "0x8D252C")]
				private set
				{
				}
			}

			[Token(Token = "0x17000088")]
			public Vector3 LastFinalPosition
			{
				[Token(Token = "0x6000464")]
				[Address(RVA = "0x1183CD8", Offset = "0x1183CD8", VA = "0x1183CD8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8D253C", Offset = "0x8D253C")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000465")]
				[Address(RVA = "0x1183CE8", Offset = "0x1183CE8", VA = "0x1183CE8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8D254C", Offset = "0x8D254C")]
				private set
				{
				}
			}

			[Token(Token = "0x17000089")]
			public Quaternion LastFinalRotation
			{
				[Token(Token = "0x6000466")]
				[Address(RVA = "0x1183CF8", Offset = "0x1183CF8", VA = "0x1183CF8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8D255C", Offset = "0x8D255C")]
				get
				{
					return default(Quaternion);
				}
				[Token(Token = "0x6000467")]
				[Address(RVA = "0x1183D0C", Offset = "0x1183D0C", VA = "0x1183D0C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8D256C", Offset = "0x8D256C")]
				private set
				{
				}
			}

			[Token(Token = "0x1700008A")]
			public float DeflectionFactor
			{
				[Token(Token = "0x600046B")]
				[Address(RVA = "0x1183DDC", Offset = "0x1183DDC", VA = "0x1183DDC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8D257C", Offset = "0x8D257C")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x600046C")]
				[Address(RVA = "0x1183DE4", Offset = "0x1183DE4", VA = "0x1183DE4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8D258C", Offset = "0x8D258C")]
				private set
				{
				}
			}

			[Token(Token = "0x1700008B")]
			public Vector3 Deflection
			{
				[Token(Token = "0x600046D")]
				[Address(RVA = "0x1183DEC", Offset = "0x1183DEC", VA = "0x1183DEC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8D259C", Offset = "0x8D259C")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x600046E")]
				[Address(RVA = "0x1183DFC", Offset = "0x1183DFC", VA = "0x1183DFC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8D25AC", Offset = "0x8D25AC")]
				private set
				{
				}
			}

			[Token(Token = "0x1700008C")]
			public float DeflectionSmooth
			{
				[Token(Token = "0x600046F")]
				[Address(RVA = "0x1183E0C", Offset = "0x1183E0C", VA = "0x1183E0C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8D25BC", Offset = "0x8D25BC")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000470")]
				[Address(RVA = "0x1183E14", Offset = "0x1183E14", VA = "0x1183E14")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8D25CC", Offset = "0x8D25CC")]
				private set
				{
				}
			}

			[Token(Token = "0x1700008D")]
			public Vector3 DeflectionWorldPosition
			{
				[Token(Token = "0x6000471")]
				[Address(RVA = "0x1183E1C", Offset = "0x1183E1C", VA = "0x1183E1C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8D25DC", Offset = "0x8D25DC")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000472")]
				[Address(RVA = "0x1183E2C", Offset = "0x1183E2C", VA = "0x1183E2C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8D25EC", Offset = "0x8D25EC")]
				private set
				{
				}
			}

			[Token(Token = "0x1700008E")]
			public int DeflectionRelevancy
			{
				[Token(Token = "0x6000473")]
				[Address(RVA = "0x1183E3C", Offset = "0x1183E3C", VA = "0x1183E3C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8D25FC", Offset = "0x8D25FC")]
				get
				{
					return default(int);
				}
				[Token(Token = "0x6000474")]
				[Address(RVA = "0x1183E44", Offset = "0x1183E44", VA = "0x1183E44")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8D260C", Offset = "0x8D260C")]
				private set
				{
				}
			}

			[Token(Token = "0x1700008F")]
			public FImp_ColliderData_Base LatestSelectiveCollision
			{
				[Token(Token = "0x6000475")]
				[Address(RVA = "0x1183E4C", Offset = "0x1183E4C", VA = "0x1183E4C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8D261C", Offset = "0x8D261C")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000476")]
				[Address(RVA = "0x1183E54", Offset = "0x1183E54", VA = "0x1183E54")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8D262C", Offset = "0x8D262C")]
				internal set
				{
				}
			}

			[Token(Token = "0x6000453")]
			[Address(RVA = "0x1183444", Offset = "0x1183444", VA = "0x1183444")]
			public TailSegment()
			{
			}

			[Token(Token = "0x6000454")]
			[Address(RVA = "0x1183618", Offset = "0x1183618", VA = "0x1183618")]
			public TailSegment(Transform transform)
			{
			}

			[Token(Token = "0x6000455")]
			[Address(RVA = "0x1183764", Offset = "0x1183764", VA = "0x1183764")]
			public TailSegment(TailSegment copyFrom)
			{
			}

			[Token(Token = "0x6000456")]
			[Address(RVA = "0x1183750", Offset = "0x1183750", VA = "0x1183750")]
			public void ReInitializeLocalPosRot(Vector3 initLocalPos, Quaternion initLocalRot)
			{
			}

			[Token(Token = "0x6000457")]
			[Address(RVA = "0x118381C", Offset = "0x118381C", VA = "0x118381C")]
			public void SetIndex(int i, int tailSegments)
			{
			}

			[Token(Token = "0x6000458")]
			[Address(RVA = "0x1183840", Offset = "0x1183840", VA = "0x1183840")]
			public void SetParentRef(TailSegment parent)
			{
			}

			[Token(Token = "0x6000459")]
			[Address(RVA = "0x11838B8", Offset = "0x11838B8", VA = "0x11838B8")]
			public void SetChildRef(TailSegment child)
			{
			}

			[Token(Token = "0x600045A")]
			[Address(RVA = "0x11838C0", Offset = "0x11838C0", VA = "0x11838C0")]
			public float GetRadiusScaled()
			{
				return default(float);
			}

			[Token(Token = "0x600045D")]
			[Address(RVA = "0x118390C", Offset = "0x118390C", VA = "0x118390C")]
			public void AssignDetachedRootCoords(Transform root)
			{
			}

			[Token(Token = "0x600045E")]
			[Address(RVA = "0x11839CC", Offset = "0x11839CC", VA = "0x11839CC")]
			internal Vector3 BlendMotionWeight(Vector3 newPosition)
			{
				return default(Vector3);
			}

			[Token(Token = "0x600045F")]
			[Address(RVA = "0x1183ABC", Offset = "0x1183ABC", VA = "0x1183ABC")]
			internal void PreCalibrate()
			{
			}

			[Token(Token = "0x6000460")]
			[Address(RVA = "0x1183B08", Offset = "0x1183B08", VA = "0x1183B08")]
			internal void Validate()
			{
			}

			[Token(Token = "0x6000461")]
			[Address(RVA = "0x1183B24", Offset = "0x1183B24", VA = "0x1183B24")]
			public void RefreshKeyLocalPosition()
			{
			}

			[Token(Token = "0x6000462")]
			[Address(RVA = "0x1183BC8", Offset = "0x1183BC8", VA = "0x1183BC8")]
			public void RefreshKeyLocalPositionAndRotation()
			{
			}

			[Token(Token = "0x6000463")]
			[Address(RVA = "0x1183CB8", Offset = "0x1183CB8", VA = "0x1183CB8")]
			public void RefreshKeyLocalPositionAndRotation(Vector3 p, Quaternion r)
			{
			}

			[Token(Token = "0x6000468")]
			[Address(RVA = "0x1183D20", Offset = "0x1183D20", VA = "0x1183D20")]
			internal Vector3 ParentToFrontOffset()
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000469")]
			[Address(RVA = "0x1183DB8", Offset = "0x1183DB8", VA = "0x1183DB8")]
			public void RefreshFinalPos(Vector3 pos)
			{
			}

			[Token(Token = "0x600046A")]
			[Address(RVA = "0x1183DC8", Offset = "0x1183DC8", VA = "0x1183DC8")]
			public void RefreshFinalRot(Quaternion rot)
			{
			}

			[Token(Token = "0x6000477")]
			[Address(RVA = "0x1183E64", Offset = "0x1183E64", VA = "0x1183E64")]
			public bool CheckDeflectionState(float zeroWhenLower, float smoothTime, float delta)
			{
				return default(bool);
			}

			[Token(Token = "0x6000478")]
			[Address(RVA = "0x1184030", Offset = "0x1184030", VA = "0x1184030")]
			public bool DeflectionRelevant()
			{
				return default(bool);
			}

			[Token(Token = "0x6000479")]
			[Address(RVA = "0x118404C", Offset = "0x118404C", VA = "0x118404C")]
			public bool? DeflectionRestoreState()
			{
				return null;
			}

			[Token(Token = "0x600047A")]
			[Address(RVA = "0x11840EC", Offset = "0x11840EC", VA = "0x11840EC")]
			internal void ParamsFrom(TailSegment other)
			{
			}

			[Token(Token = "0x600047B")]
			[Address(RVA = "0x11841AC", Offset = "0x11841AC", VA = "0x11841AC")]
			internal void ParamsFromAll(TailSegment other)
			{
			}

			[Token(Token = "0x600047C")]
			[Address(RVA = "0x11842D0", Offset = "0x11842D0", VA = "0x11842D0")]
			internal void User_ReassignTransform(Transform t)
			{
			}

			[Token(Token = "0x600047D")]
			[Address(RVA = "0x11842D8", Offset = "0x11842D8", VA = "0x11842D8")]
			public void Reset()
			{
			}
		}

		[Token(Token = "0x20000A7")]
		public enum ECollisionSpace
		{
			[Token(Token = "0x40004EE")]
			World_Slow,
			[Token(Token = "0x40004EF")]
			Selective_Fast
		}

		[Token(Token = "0x20000A8")]
		public enum ECollisionMode
		{
			[Token(Token = "0x40004F1")]
			m_3DCollision,
			[Token(Token = "0x40004F2")]
			m_2DCollision
		}

		[Serializable]
		[Token(Token = "0x20000A9")]
		public class IKBoneSettings
		{
			[Token(Token = "0x40004F3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8CE4FC", Offset = "0x8CE4FC")]
			public float AngleLimit;

			[Token(Token = "0x40004F4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8CE518", Offset = "0x8CE518")]
			public float TwistAngleLimit;

			[Token(Token = "0x600047E")]
			[Address(RVA = "0x11833B8", Offset = "0x11833B8", VA = "0x11833B8")]
			public IKBoneSettings()
			{
			}
		}

		[Token(Token = "0x20000AA")]
		public enum FEWavingType
		{
			[Token(Token = "0x40004F6")]
			Simple,
			[Token(Token = "0x40004F7")]
			Advanced
		}

		[Token(Token = "0x20000AB")]
		public enum EFDeltaType
		{
			[Token(Token = "0x40004F9")]
			DeltaTime,
			[Token(Token = "0x40004FA")]
			SmoothDeltaTime,
			[Token(Token = "0x40004FB")]
			UnscaledDeltaTime,
			[Token(Token = "0x40004FC")]
			FixedDeltaTime,
			[Token(Token = "0x40004FD")]
			SafeDelta
		}

		[Token(Token = "0x20000AC")]
		public enum EAnimationStyle
		{
			[Token(Token = "0x40004FF")]
			Quick,
			[Token(Token = "0x4000500")]
			Accelerating,
			[Token(Token = "0x4000501")]
			Linear
		}

		[Token(Token = "0x20000AD")]
		public enum ETailCategory
		{
			[Token(Token = "0x4000503")]
			Setup,
			[Token(Token = "0x4000504")]
			Tweak,
			[Token(Token = "0x4000505")]
			Features,
			[Token(Token = "0x4000506")]
			Shaping
		}

		[Token(Token = "0x20000AE")]
		public enum ETailFeaturesCategory
		{
			[Token(Token = "0x4000508")]
			Main,
			[Token(Token = "0x4000509")]
			Collisions,
			[Token(Token = "0x400050A")]
			IK,
			[Token(Token = "0x400050B")]
			Experimental
		}

		[Token(Token = "0x20000AF")]
		public enum EFixedMode
		{
			[Token(Token = "0x400050D")]
			None,
			[Token(Token = "0x400050E")]
			Basic,
			[Token(Token = "0x400050F")]
			Late
		}

		[Token(Token = "0x20000B0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8CB204", Offset = "0x8CB204")]
		private sealed class <>c__DisplayClass44_0
		{
			[Token(Token = "0x4000510")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Collider col;

			[Token(Token = "0x600047F")]
			[Address(RVA = "0x1183068", Offset = "0x1183068", VA = "0x1183068")]
			public <>c__DisplayClass44_0()
			{
			}

			[Token(Token = "0x6000480")]
			[Address(RVA = "0x1183070", Offset = "0x1183070", VA = "0x1183070")]
			internal bool <CheckForColliderDuplicatesAndNulls>b__0(Collider o)
			{
				return default(bool);
			}

			[Token(Token = "0x6000481")]
			[Address(RVA = "0x11830E8", Offset = "0x11830E8", VA = "0x11830E8")]
			internal bool <CheckForColliderDuplicatesAndNulls>b__1(Collider o)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x20000B1")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8CB214", Offset = "0x8CB214")]
		private sealed class <>c__DisplayClass45_0
		{
			[Token(Token = "0x4000511")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Collider2D col;

			[Token(Token = "0x6000482")]
			[Address(RVA = "0x1183160", Offset = "0x1183160", VA = "0x1183160")]
			public <>c__DisplayClass45_0()
			{
			}

			[Token(Token = "0x6000483")]
			[Address(RVA = "0x1183168", Offset = "0x1183168", VA = "0x1183168")]
			internal bool <CheckForColliderDuplicatesAndNulls2D>b__0(Collider2D o)
			{
				return default(bool);
			}

			[Token(Token = "0x6000484")]
			[Address(RVA = "0x11831E0", Offset = "0x11831E0", VA = "0x11831E0")]
			internal bool <CheckForColliderDuplicatesAndNulls2D>b__1(Collider2D o)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x20000B2")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8CB224", Offset = "0x8CB224")]
		private sealed class <LateFixed>d__274 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000512")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000513")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000514")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public TailAnimator2 <>4__this;

			[Token(Token = "0x4000515")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private WaitForFixedUpdate <fixedWait>5__2;

			[Token(Token = "0x17000090")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000488")]
				[Address(RVA = "0x1183368", Offset = "0x1183368", VA = "0x1183368", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000091")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600048A")]
				[Address(RVA = "0x11833B0", Offset = "0x11833B0", VA = "0x11833B0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000485")]
			[Address(RVA = "0x1183258", Offset = "0x1183258", VA = "0x1183258")]
			[DebuggerHidden]
			public <LateFixed>d__274(int <>1__state)
			{
			}

			[Token(Token = "0x6000486")]
			[Address(RVA = "0x1183284", Offset = "0x1183284", VA = "0x1183284", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000487")]
			[Address(RVA = "0x1183288", Offset = "0x1183288", VA = "0x1183288", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000489")]
			[Address(RVA = "0x1183370", Offset = "0x1183370", VA = "0x1183370", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40003E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8CCB24", Offset = "0x8CCB24")]
		public bool UseCollision;

		[Token(Token = "0x40003E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8CCB5C", Offset = "0x8CCB5C")]
		public ECollisionSpace CollisionSpace;

		[Token(Token = "0x40003E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ECollisionMode CollisionMode;

		[Token(Token = "0x40003E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8CCB94", Offset = "0x8CCB94")]
		public bool CheapCollision;

		[Token(Token = "0x40003E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x25")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8CCBCC", Offset = "0x8CCBCC")]
		public bool DynamicWorldCollidersInclusion;

		[Token(Token = "0x40003E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8CCC04", Offset = "0x8CCC04")]
		public float InclusionRadius;

		[Token(Token = "0x40003E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public bool IgnoreMeshColliders;

		[Token(Token = "0x40003E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public List<Collider> IncludedColliders;

		[Token(Token = "0x40003E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public List<Collider2D> IncludedColliders2D;

		[Token(Token = "0x40003EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8CCC3C", Offset = "0x8CCC3C")]
		private List<Component> <DynamicAlwaysInclude>k__BackingField;

		[Token(Token = "0x40003EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		protected List<FImp_ColliderData_Base> IncludedCollidersData;

		[Token(Token = "0x40003EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		protected List<FImp_ColliderData_Base> CollidersDataToCheck;

		[Token(Token = "0x40003ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8CCC4C", Offset = "0x8CCC4C")]
		public int CollidersType;

		[Token(Token = "0x40003EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public bool CollideWithOtherTails;

		[Token(Token = "0x40003EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5D")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8CCC84", Offset = "0x8CCC84")]
		public bool CollideWithDisabledColliders;

		[Token(Token = "0x40003F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8CCCBC", Offset = "0x8CCCBC")]
		public float CollisionSlippery;

		[Token(Token = "0x40003F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8CCCD4", Offset = "0x8CCCD4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8CCCD4", Offset = "0x8CCCD4")]
		public float ReflectCollision;

		[Token(Token = "0x40003F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public AnimationCurve CollidersScaleCurve;

		[Token(Token = "0x40003F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public float CollidersScaleMul;

		[Token(Token = "0x40003F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8CCD28", Offset = "0x8CCD28")]
		public float CollisionsAutoCurve;

		[Token(Token = "0x40003F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public List<Collider> IgnoredColliders;

		[Token(Token = "0x40003F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public List<Collider2D> IgnoredColliders2D;

		[Token(Token = "0x40003F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public bool CollidersSameLayer;

		[Token(Token = "0x40003F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x89")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8CCD40", Offset = "0x8CCD40")]
		public bool CollidersAddRigidbody;

		[Token(Token = "0x40003F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		public float RigidbodyMass;

		[Token(Token = "0x40003FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[FPD_Layers]
		public int CollidersLayer;

		[Token(Token = "0x40003FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		public bool UseSlitheryCurve;

		[Token(Token = "0x40003FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		[AttributeAttribute(Name = "FPD_FixedCurveWindowAttribute", RVA = "0x8CCD88", Offset = "0x8CCD88")]
		public AnimationCurve SlitheryCurve;

		[Token(Token = "0x40003FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private float lastSlithery;

		[Token(Token = "0x40003FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Keyframe[] lastSlitheryCurvKeys;

		[Token(Token = "0x40003FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public bool UseCurlingCurve;

		[Token(Token = "0x4000400")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		[AttributeAttribute(Name = "FPD_FixedCurveWindowAttribute", RVA = "0x8CCDC8", Offset = "0x8CCDC8")]
		public AnimationCurve CurlingCurve;

		[Token(Token = "0x4000401")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private float lastCurling;

		[Token(Token = "0x4000402")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private Keyframe[] lastCurlingCurvKeys;

		[Token(Token = "0x4000403")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public bool UseSpringCurve;

		[Token(Token = "0x4000404")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		[AttributeAttribute(Name = "FPD_FixedCurveWindowAttribute", RVA = "0x8CCE04", Offset = "0x8CCE04")]
		public AnimationCurve SpringCurve;

		[Token(Token = "0x4000405")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private float lastSpringiness;

		[Token(Token = "0x4000406")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private Keyframe[] lastSpringCurvKeys;

		[Token(Token = "0x4000407")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		public bool UseSlipperyCurve;

		[Token(Token = "0x4000408")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		[AttributeAttribute(Name = "FPD_FixedCurveWindowAttribute", RVA = "0x8CCE40", Offset = "0x8CCE40")]
		public AnimationCurve SlipperyCurve;

		[Token(Token = "0x4000409")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private float lastSlippery;

		[Token(Token = "0x400040A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private Keyframe[] lastSlipperyCurvKeys;

		[Token(Token = "0x400040B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		public bool UsePosSpeedCurve;

		[Token(Token = "0x400040C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		[AttributeAttribute(Name = "FPD_FixedCurveWindowAttribute", RVA = "0x8CCE7C", Offset = "0x8CCE7C")]
		public AnimationCurve PosCurve;

		[Token(Token = "0x400040D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private float lastPosSpeeds;

		[Token(Token = "0x400040E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		private Keyframe[] lastPosCurvKeys;

		[Token(Token = "0x400040F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		public bool UseRotSpeedCurve;

		[Token(Token = "0x4000410")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		[AttributeAttribute(Name = "FPD_FixedCurveWindowAttribute", RVA = "0x8CCEB8", Offset = "0x8CCEB8")]
		public AnimationCurve RotCurve;

		[Token(Token = "0x4000411")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		private float lastRotSpeeds;

		[Token(Token = "0x4000412")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		private Keyframe[] lastRotCurvKeys;

		[Token(Token = "0x4000413")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8CCEF0", Offset = "0x8CCEF0")]
		public bool UsePartialBlend;

		[Token(Token = "0x4000414")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		[AttributeAttribute(Name = "FPD_FixedCurveWindowAttribute", RVA = "0x8CCF28", Offset = "0x8CCF28")]
		public AnimationCurve BlendCurve;

		[Token(Token = "0x4000415")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		private float lastTailAnimatorAmount;

		[Token(Token = "0x4000416")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		private Keyframe[] lastBlendCurvKeys;

		[Token(Token = "0x4000417")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		private TailSegment _ex_bone;

		[Token(Token = "0x4000418")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
		public bool UseIK;

		[Token(Token = "0x4000419")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x179")]
		private bool ikInitialized;

		[Token(Token = "0x400041A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
		[SerializeField]
		private FIK_CCDProcessor IK;

		[Token(Token = "0x400041B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8CCF70", Offset = "0x8CCF70")]
		public Transform IKTarget;

		[Token(Token = "0x400041C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
		public bool IKAutoWeights;

		[Token(Token = "0x400041D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x194")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8CCFA8", Offset = "0x8CCFA8")]
		public float IKBaseReactionWeight;

		[Token(Token = "0x400041E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
		[AttributeAttribute(Name = "FPD_FixedCurveWindowAttribute", RVA = "0x8CCFC0", Offset = "0x8CCFC0")]
		public AnimationCurve IKReactionWeightCurve;

		[Token(Token = "0x400041F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
		public bool IKAutoAngleLimits;

		[Token(Token = "0x4000420")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A4")]
		[AttributeAttribute(Name = "FPD_SuffixAttribute", RVA = "0x8CCFF8", Offset = "0x8CCFF8")]
		public float IKAutoAngleLimit;

		[Token(Token = "0x4000421")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8CD044", Offset = "0x8CD044")]
		public bool IKContinousSolve;

		[Token(Token = "0x4000422")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1AC")]
		[AttributeAttribute(Name = "FPD_SuffixAttribute", RVA = "0x8CD07C", Offset = "0x8CD07C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8CD07C", Offset = "0x8CD07C")]
		public float IKBlend;

		[Token(Token = "0x4000423")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
		[AttributeAttribute(Name = "FPD_SuffixAttribute", RVA = "0x8CD0EC", Offset = "0x8CD0EC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8CD0EC", Offset = "0x8CD0EC")]
		public float IKAnimatorBlend;

		[Token(Token = "0x4000424")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8CD15C", Offset = "0x8CD15C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8CD15C", Offset = "0x8CD15C")]
		public int IKReactionQuality;

		[Token(Token = "0x4000425")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8CD1B4", Offset = "0x8CD1B4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8CD1B4", Offset = "0x8CD1B4")]
		public float IKSmoothing;

		[Token(Token = "0x4000426")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1BC")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8CD208", Offset = "0x8CD208")]
		public float IKMaxStretching;

		[Token(Token = "0x4000427")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
		[AttributeAttribute(Name = "FPD_FixedCurveWindowAttribute", RVA = "0x8CD220", Offset = "0x8CD220")]
		public AnimationCurve IKStretchCurve;

		[Token(Token = "0x4000428")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C8")]
		public List<IKBoneSettings> IKLimitSettings;

		[Token(Token = "0x4000429")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D0")]
		private Vector3? _IKCustomPos;

		[Token(Token = "0x400042A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E0")]
		private List<TailSegment> _pp_reference;

		[Token(Token = "0x400042B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E8")]
		private TailSegment _pp_ref_rootParent;

		[Token(Token = "0x400042C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F0")]
		private TailSegment _pp_ref_lastChild;

		[Token(Token = "0x400042D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F8")]
		private bool _pp_initialized;

		[Token(Token = "0x400042E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1FC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8CD258", Offset = "0x8CD258")]
		public Quaternion RotationOffset;

		[Token(Token = "0x400042F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8CD290", Offset = "0x8CD290")]
		public Quaternion Curving;

		[Token(Token = "0x4000430")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x21C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8CD2C8", Offset = "0x8CD2C8")]
		public bool UseCurvingCurve;

		[Token(Token = "0x4000431")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x220")]
		[AttributeAttribute(Name = "FPD_FixedCurveWindowAttribute", RVA = "0x8CD300", Offset = "0x8CD300")]
		public AnimationCurve CurvCurve;

		[Token(Token = "0x4000432")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x228")]
		private Quaternion lastCurving;

		[Token(Token = "0x4000433")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x238")]
		private Keyframe[] lastCurvingKeys;

		[Token(Token = "0x4000434")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x240")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8CD334", Offset = "0x8CD334")]
		public float LengthMultiplier;

		[Token(Token = "0x4000435")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x244")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8CD36C", Offset = "0x8CD36C")]
		public bool UseLengthMulCurve;

		[Token(Token = "0x4000436")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x248")]
		[AttributeAttribute(Name = "FPD_FixedCurveWindowAttribute", RVA = "0x8CD3A4", Offset = "0x8CD3A4")]
		public AnimationCurve LengthMulCurve;

		[Token(Token = "0x4000437")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x250")]
		private float lastLengthMul;

		[Token(Token = "0x4000438")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x258")]
		private Keyframe[] lastLengthKeys;

		[Token(Token = "0x4000439")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x260")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8CD3D4", Offset = "0x8CD3D4")]
		public bool UseGravityCurve;

		[Token(Token = "0x400043A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x268")]
		[AttributeAttribute(Name = "FPD_FixedCurveWindowAttribute", RVA = "0x8CD40C", Offset = "0x8CD40C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8CD40C", Offset = "0x8CD40C")]
		public AnimationCurve GravityCurve;

		[Token(Token = "0x400043B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x270")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8CD480", Offset = "0x8CD480")]
		public Vector3 Gravity;

		[Token(Token = "0x400043C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x27C")]
		private Vector3 lastGravity;

		[Token(Token = "0x400043D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x288")]
		private Keyframe[] lastGravityKeys;

		[Token(Token = "0x400043E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x290")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8CD4B8", Offset = "0x8CD4B8")]
		public bool UseWaving;

		[Token(Token = "0x400043F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x291")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8CD4F0", Offset = "0x8CD4F0")]
		public bool CosinusAdd;

		[Token(Token = "0x4000440")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x294")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8CD528", Offset = "0x8CD528")]
		public float FixedCycle;

		[Token(Token = "0x4000441")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x298")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8CD560", Offset = "0x8CD560")]
		public float WavingSpeed;

		[Token(Token = "0x4000442")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x29C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8CD598", Offset = "0x8CD598")]
		public float WavingRange;

		[Token(Token = "0x4000443")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2A0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8CD5D0", Offset = "0x8CD5D0")]
		public Vector3 WavingAxis;

		[Token(Token = "0x4000444")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2AC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8CD608", Offset = "0x8CD608")]
		private Quaternion <WavingRotationOffset>k__BackingField;

		[Token(Token = "0x4000445")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2BC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8CD618", Offset = "0x8CD618")]
		public FEWavingType WavingType;

		[Token(Token = "0x4000446")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8CD650", Offset = "0x8CD650")]
		public float AlternateWave;

		[Token(Token = "0x4000447")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C4")]
		private float _waving_waveTime;

		[Token(Token = "0x4000448")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C8")]
		private float _waving_cosTime;

		[Token(Token = "0x4000449")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2CC")]
		private Vector3 _waving_sustain;

		[Token(Token = "0x400044A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2D8")]
		public bool UseWind;

		[Token(Token = "0x400044B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2DC")]
		[AttributeAttribute(Name = "FPD_SuffixAttribute", RVA = "0x8CD688", Offset = "0x8CD688")]
		public float WindEffectPower;

		[Token(Token = "0x400044C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2E0")]
		[AttributeAttribute(Name = "FPD_SuffixAttribute", RVA = "0x8CD6D0", Offset = "0x8CD6D0")]
		public float WindTurbulencePower;

		[Token(Token = "0x400044D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2E4")]
		[AttributeAttribute(Name = "FPD_SuffixAttribute", RVA = "0x8CD718", Offset = "0x8CD718")]
		public float WindWorldNoisePower;

		[Token(Token = "0x400044E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2E8")]
		public Vector3 WindEffect;

		[Token(Token = "0x400044F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2F8")]
		public List<TailSegment> TailSegments;

		[Token(Token = "0x4000450")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x300")]
		[SerializeField]
		private TailSegment GhostParent;

		[Token(Token = "0x4000451")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x308")]
		[SerializeField]
		private TailSegment GhostChild;

		[Token(Token = "0x4000452")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x310")]
		private Vector3 _limiting_limitPosition;

		[Token(Token = "0x4000453")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x31C")]
		private Vector3 _limiting_influenceOffset;

		[Token(Token = "0x4000454")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x328")]
		private float _limiting_stretchingHelperTooLong;

		[Token(Token = "0x4000455")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x32C")]
		private float _limiting_stretchingHelperTooShort;

		[Token(Token = "0x4000456")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x330")]
		private Quaternion _limiting_angle_ToTargetRot;

		[Token(Token = "0x4000457")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x340")]
		private Quaternion _limiting_angle_targetInLocal;

		[Token(Token = "0x4000458")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x350")]
		private Quaternion _limiting_angle_newLocal;

		[Token(Token = "0x4000459")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x360")]
		private Vector3 _tc_segmentGravityOffset;

		[Token(Token = "0x400045A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x36C")]
		private Vector3 _tc_segmentGravityToParentDir;

		[Token(Token = "0x400045B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x378")]
		private Vector3 _tc_preGravOff;

		[Token(Token = "0x400045C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x384")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8CD780", Offset = "0x8CD780")]
		public bool UseMaxDistance;

		[Token(Token = "0x400045D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x388")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8CD7B8", Offset = "0x8CD7B8")]
		public Transform DistanceFrom;

		[Token(Token = "0x400045E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x390")]
		[HideInInspector]
		public Transform _distanceFrom_Auto;

		[Token(Token = "0x400045F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x398")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8CD800", Offset = "0x8CD800")]
		public float MaximumDistance;

		[Token(Token = "0x4000460")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x39C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8CD838", Offset = "0x8CD838")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8CD838", Offset = "0x8CD838")]
		public float MaxOutDistanceFactor;

		[Token(Token = "0x4000461")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3A0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8CD88C", Offset = "0x8CD88C")]
		public bool DistanceWithoutY;

		[Token(Token = "0x4000462")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3A4")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8CD8C4", Offset = "0x8CD8C4")]
		public Vector3 DistanceMeasurePoint;

		[Token(Token = "0x4000463")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3B0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8CD8FC", Offset = "0x8CD8FC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8CD8FC", Offset = "0x8CD8FC")]
		public float FadeDuration;

		[Token(Token = "0x4000464")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3B4")]
		private bool maxDistanceExceed;

		[Token(Token = "0x4000465")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3B8")]
		private Transform finalDistanceFrom;

		[Token(Token = "0x4000466")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C0")]
		private bool wasCameraSearch;

		[Token(Token = "0x4000467")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C4")]
		private float distanceWeight;

		[Token(Token = "0x4000468")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C8")]
		private int _tc_startI;

		[Token(Token = "0x4000469")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3CC")]
		private int _tc_startII;

		[Token(Token = "0x400046A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3D0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8CD950", Offset = "0x8CD950")]
		private float <_TC_TailLength>k__BackingField;

		[Token(Token = "0x400046B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3D8")]
		private TailSegment _tc_rootBone;

		[Token(Token = "0x400046C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3E0")]
		private Quaternion _tc_lookRot;

		[Token(Token = "0x400046D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3F0")]
		private Quaternion _tc_targetParentRot;

		[Token(Token = "0x400046E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x400")]
		private Quaternion _tc_startBoneRotOffset;

		[Token(Token = "0x400046F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x410")]
		private float _tc_tangle;

		[Token(Token = "0x4000470")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x414")]
		private float _sg_springVelo;

		[Token(Token = "0x4000471")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x418")]
		private float _sg_curly;

		[Token(Token = "0x4000472")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x41C")]
		private Vector3 _sg_push;

		[Token(Token = "0x4000473")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x428")]
		private Vector3 _sg_targetPos;

		[Token(Token = "0x4000474")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x434")]
		private Vector3 _sg_targetChildWorldPosInParentFront;

		[Token(Token = "0x4000475")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x440")]
		private Vector3 _sg_dirToTargetParentFront;

		[Token(Token = "0x4000476")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44C")]
		private Quaternion _sg_orientation;

		[Token(Token = "0x4000477")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x45C")]
		private float _sg_slitFactor;

		[Token(Token = "0x4000478")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x460")]
		private bool wasDisabled;

		[Token(Token = "0x4000479")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x464")]
		private float justDelta;

		[Token(Token = "0x400047A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x468")]
		private float secPeriodDelta;

		[Token(Token = "0x400047B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x46C")]
		private float deltaForLerps;

		[Token(Token = "0x400047C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x470")]
		private float rateDelta;

		[Token(Token = "0x400047D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x474")]
		protected float collectedDelta;

		[Token(Token = "0x400047E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x478")]
		protected int framesToSimulate;

		[Token(Token = "0x400047F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x47C")]
		protected int previousframesToSimulate;

		[Token(Token = "0x4000480")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x480")]
		private bool updateTailAnimator;

		[Token(Token = "0x4000481")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x484")]
		private int startAfterTPoseCounter;

		[Token(Token = "0x4000482")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x488")]
		private bool lateFixedIsRunning;

		[Token(Token = "0x4000483")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x489")]
		private bool fixedAllow;

		[Token(Token = "0x4000484")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8CD960", Offset = "0x8CD960")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8CD960", Offset = "0x8CD960")]
		public float Deflection;

		[Token(Token = "0x4000485")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x490")]
		[AttributeAttribute(Name = "FPD_SuffixAttribute", RVA = "0x8CD9B4", Offset = "0x8CD9B4")]
		public float DeflectionStartAngle;

		[Token(Token = "0x4000486")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x494")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8CDA00", Offset = "0x8CDA00")]
		public float DeflectionSmooth;

		[Token(Token = "0x4000487")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x498")]
		[AttributeAttribute(Name = "FPD_FixedCurveWindowAttribute", RVA = "0x8CDA18", Offset = "0x8CDA18")]
		public AnimationCurve DeflectionFalloff;

		[Token(Token = "0x4000488")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4A0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8CDA54", Offset = "0x8CDA54")]
		public bool DeflectOnlyCollisions;

		[Token(Token = "0x4000489")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4A8")]
		private List<TailSegment> _defl_source;

		[Token(Token = "0x400048A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4B0")]
		private float _defl_treshold;

		[Token(Token = "0x400048B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4B4")]
		public ETailCategory _Editor_Category;

		[Token(Token = "0x400048C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4B8")]
		public ETailFeaturesCategory _Editor_FeaturesCategory;

		[Token(Token = "0x400048D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4BC")]
		public bool DrawGizmos;

		[Token(Token = "0x400048E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8CDA8C", Offset = "0x8CDA8C")]
		public Transform StartBone;

		[Token(Token = "0x400048F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8CDAC4", Offset = "0x8CDAC4")]
		public Transform EndBone;

		[Token(Token = "0x4000490")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4D0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8CDAFC", Offset = "0x8CDAFC")]
		public Vector3 EndBoneJointOffset;

		[Token(Token = "0x4000491")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4E0")]
		public List<Transform> _TransformsGhostChain;

		[Token(Token = "0x4000492")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4E8")]
		public int _GhostChainInitCount;

		[Token(Token = "0x4000493")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4EC")]
		protected bool initialized;

		[Token(Token = "0x4000494")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4F0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8CDB34", Offset = "0x8CDB34")]
		public int UpdateRate;

		[Token(Token = "0x4000495")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4F4")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8CDB6C", Offset = "0x8CDB6C")]
		public EFixedMode AnimatePhysics;

		[Token(Token = "0x4000496")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4F8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8CDBA4", Offset = "0x8CDBA4")]
		public bool InterpolateRate;

		[Token(Token = "0x4000497")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4F9")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8CDBDC", Offset = "0x8CDBDC")]
		public bool Prewarm;

		[Token(Token = "0x4000498")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4FC")]
		internal float OverrideWeight;

		[Token(Token = "0x4000499")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x500")]
		protected float conditionalWeight;

		[Token(Token = "0x400049A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x504")]
		protected bool collisionInitialized;

		[Token(Token = "0x400049B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x505")]
		protected bool forceRefreshCollidersData;

		[Token(Token = "0x400049C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x508")]
		private Vector3 previousWorldPosition;

		[Token(Token = "0x400049D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x518")]
		protected Transform rootTransform;

		[Token(Token = "0x400049E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x520")]
		protected bool preAutoCorrect;

		[Token(Token = "0x400049F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x524")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8CDC14", Offset = "0x8CDC14")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8CDC14", Offset = "0x8CDC14")]
		public float Slithery;

		[Token(Token = "0x40004A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x528")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8CDC6C", Offset = "0x8CDC6C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8CDC6C", Offset = "0x8CDC6C")]
		public float Curling;

		[Token(Token = "0x40004A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x52C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8CDCC0", Offset = "0x8CDCC0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8CDCC0", Offset = "0x8CDCC0")]
		public float Springiness;

		[Token(Token = "0x40004A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x530")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8CDD14", Offset = "0x8CDD14")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8CDD14", Offset = "0x8CDD14")]
		public float MaxStretching;

		[Token(Token = "0x40004A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x534")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8CDD68", Offset = "0x8CDD68")]
		[AttributeAttribute(Name = "FPD_SuffixAttribute", RVA = "0x8CDD68", Offset = "0x8CDD68")]
		public float AngleLimit;

		[Token(Token = "0x40004A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x538")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8CDDDC", Offset = "0x8CDDDC")]
		public Vector3 AngleLimitAxis;

		[Token(Token = "0x40004A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x544")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8CDE14", Offset = "0x8CDE14")]
		public Vector2 LimitAxisRange;

		[Token(Token = "0x40004A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8CDE4C", Offset = "0x8CDE4C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8CDE4C", Offset = "0x8CDE4C")]
		public float LimitSmoothing;

		[Token(Token = "0x40004A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x550")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8CDEA0", Offset = "0x8CDEA0")]
		[AttributeAttribute(Name = "FPD_SuffixAttribute", RVA = "0x8CDEA0", Offset = "0x8CDEA0")]
		public float MotionInfluence;

		[Token(Token = "0x40004A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x554")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8CDF10", Offset = "0x8CDF10")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8CDF10", Offset = "0x8CDF10")]
		public float MotionInfluenceInY;

		[Token(Token = "0x40004A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x558")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8CDF64", Offset = "0x8CDF64")]
		public bool IncludeParent;

		[Token(Token = "0x40004AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x55C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8CDF9C", Offset = "0x8CDF9C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8CDF9C", Offset = "0x8CDF9C")]
		public float UnifyBendiness;

		[Token(Token = "0x40004AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x560")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8CDFF0", Offset = "0x8CDFF0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8CDFF0", Offset = "0x8CDFF0")]
		public float ReactionSpeed;

		[Token(Token = "0x40004AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x564")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8CE044", Offset = "0x8CE044")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8CE044", Offset = "0x8CE044")]
		public float Sustain;

		[Token(Token = "0x40004AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x568")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8CE098", Offset = "0x8CE098")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8CE098", Offset = "0x8CE098")]
		public float RotationRelevancy;

		[Token(Token = "0x40004AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x56C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8CE0EC", Offset = "0x8CE0EC")]
		public EAnimationStyle SmoothingStyle;

		[Token(Token = "0x40004AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x570")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8CE124", Offset = "0x8CE124")]
		public EFDeltaType DeltaType;

		[Token(Token = "0x40004B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x574")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8CE15C", Offset = "0x8CE15C")]
		public bool UpdateAsLast;

		[Token(Token = "0x40004B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x575")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8CE194", Offset = "0x8CE194")]
		public bool DetectZeroKeyframes;

		[Token(Token = "0x40004B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x576")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8CE1CC", Offset = "0x8CE1CC")]
		public bool StartAfterTPose;

		[Token(Token = "0x40004B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x578")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8CE204", Offset = "0x8CE204")]
		public Renderer OptimizeWithMesh;

		[Token(Token = "0x40004B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x580")]
		[AttributeAttribute(Name = "FPD_SuffixAttribute", RVA = "0x8CE23C", Offset = "0x8CE23C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8CE23C", Offset = "0x8CE23C")]
		public float TailAnimatorAmount;

		[Token(Token = "0x40004B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x584")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8CE2AC", Offset = "0x8CE2AC")]
		public bool DetachChildren;

		[Token(Token = "0x40004B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x588")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8CE2E4", Offset = "0x8CE2E4")]
		public int Axis2D;

		[Token(Token = "0x40004B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8CE31C", Offset = "0x8CE31C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8CE31C", Offset = "0x8CE31C")]
		public float Tangle;

		[Token(Token = "0x40004B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x590")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8CE370", Offset = "0x8CE370")]
		public bool AnimateRoll;

		[Token(Token = "0x40004B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x594")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8CE3A8", Offset = "0x8CE3A8")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8CE3A8", Offset = "0x8CE3A8")]
		public float OverrideKeyframeAnimation;

		[Token(Token = "0x40004BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x598")]
		private Transform _baseTransform;

		[Token(Token = "0x1700007A")]
		public List<Component> DynamicAlwaysInclude
		{
			[Token(Token = "0x60003C8")]
			[Address(RVA = "0x1E25110", Offset = "0x1E25110", VA = "0x1E25110")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8D237C", Offset = "0x8D237C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60003C9")]
			[Address(RVA = "0x1E25118", Offset = "0x1E25118", VA = "0x1E25118")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8D238C", Offset = "0x8D238C")]
			private set
			{
			}
		}

		[Token(Token = "0x1700007B")]
		public Quaternion WavingRotationOffset
		{
			[Token(Token = "0x60003EF")]
			[Address(RVA = "0x1E2A578", Offset = "0x1E2A578", VA = "0x1E2A578")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8D239C", Offset = "0x8D239C")]
			get
			{
				return default(Quaternion);
			}
			[Token(Token = "0x60003F0")]
			[Address(RVA = "0x1E2A58C", Offset = "0x1E2A58C", VA = "0x1E2A58C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8D23AC", Offset = "0x8D23AC")]
			private set
			{
			}
		}

		[Token(Token = "0x1700007C")]
		public float _TC_TailLength
		{
			[Token(Token = "0x6000407")]
			[Address(RVA = "0x1E2E778", Offset = "0x1E2E778", VA = "0x1E2E778")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8D23BC", Offset = "0x8D23BC")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000408")]
			[Address(RVA = "0x1E2E780", Offset = "0x1E2E780", VA = "0x1E2E780")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8D23CC", Offset = "0x8D23CC")]
			private set
			{
			}
		}

		[Token(Token = "0x1700007D")]
		public string EditorIconPath
		{
			[Token(Token = "0x6000438")]
			[Address(RVA = "0x1E3117C", Offset = "0x1E3117C", VA = "0x1E3117C", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700007E")]
		public bool IsInitialized
		{
			[Token(Token = "0x600043A")]
			[Address(RVA = "0x1E31204", Offset = "0x1E31204", VA = "0x1E31204")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700007F")]
		public Transform BaseTransform
		{
			[Token(Token = "0x600043D")]
			[Address(RVA = "0x1E2C5B4", Offset = "0x1E2C5B4", VA = "0x1E2C5B4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60003CA")]
		[Address(RVA = "0x1E25120", Offset = "0x1E25120", VA = "0x1E25120")]
		private void RefreshSegmentsColliders()
		{
		}

		[Token(Token = "0x60003CB")]
		[Address(RVA = "0x1E2541C", Offset = "0x1E2541C", VA = "0x1E2541C")]
		private void BeginCollisionsUpdate()
		{
		}

		[Token(Token = "0x60003CC")]
		[Address(RVA = "0x1E259A8", Offset = "0x1E259A8", VA = "0x1E259A8")]
		private void SetupSphereColliders()
		{
		}

		[Token(Token = "0x60003CD")]
		[Address(RVA = "0x1E269D4", Offset = "0x1E269D4", VA = "0x1E269D4")]
		internal void CollisionDetection(int index, Collision collision)
		{
		}

		[Token(Token = "0x60003CE")]
		[Address(RVA = "0x1E26A58", Offset = "0x1E26A58", VA = "0x1E26A58")]
		internal void ExitCollision(int index)
		{
		}

		[Token(Token = "0x60003CF")]
		[Address(RVA = "0x1E26AD8", Offset = "0x1E26AD8", VA = "0x1E26AD8")]
		protected bool UseCollisionContact(int index, ref Vector3 pos)
		{
			return default(bool);
		}

		[Token(Token = "0x60003D0")]
		[Address(RVA = "0x1E2567C", Offset = "0x1E2567C", VA = "0x1E2567C")]
		public void RefreshIncludedCollidersDataList()
		{
		}

		[Token(Token = "0x60003D1")]
		[Address(RVA = "0x1E27190", Offset = "0x1E27190", VA = "0x1E27190")]
		public bool PushIfSegmentInsideCollider(TailSegment bone, ref Vector3 targetPoint)
		{
			return default(bool);
		}

		[Token(Token = "0x60003D2")]
		[Address(RVA = "0x1E251E0", Offset = "0x1E251E0", VA = "0x1E251E0")]
		protected float GetColliderSphereRadiusFor(int i)
		{
			return default(float);
		}

		[Token(Token = "0x60003D3")]
		[Address(RVA = "0x1E267C4", Offset = "0x1E267C4", VA = "0x1E267C4")]
		protected float GetColliderSphereRadiusFor(List<Transform> transforms, int i)
		{
			return default(float);
		}

		[Token(Token = "0x60003D4")]
		[Address(RVA = "0x1E273C4", Offset = "0x1E273C4", VA = "0x1E273C4")]
		public void AddCollider(Collider collider)
		{
		}

		[Token(Token = "0x60003D5")]
		[Address(RVA = "0x1E27464", Offset = "0x1E27464", VA = "0x1E27464")]
		public void AddCollider(Collider2D collider)
		{
		}

		[Token(Token = "0x60003D6")]
		[Address(RVA = "0x1E27504", Offset = "0x1E27504", VA = "0x1E27504")]
		public void CheckForColliderDuplicatesAndNulls()
		{
		}

		[Token(Token = "0x60003D7")]
		[Address(RVA = "0x1E277E0", Offset = "0x1E277E0", VA = "0x1E277E0")]
		public void CheckForColliderDuplicatesAndNulls2D()
		{
		}

		[Token(Token = "0x60003D8")]
		[Address(RVA = "0x1E27A08", Offset = "0x1E27A08", VA = "0x1E27A08")]
		private void TailCalculations_ComputeSegmentCollisions(TailSegment bone, ref Vector3 position)
		{
		}

		[Token(Token = "0x60003D9")]
		[Address(RVA = "0x1E27AF8", Offset = "0x1E27AF8", VA = "0x1E27AF8")]
		private void ExpertParamsUpdate()
		{
		}

		[Token(Token = "0x60003DA")]
		[Address(RVA = "0x1E283B0", Offset = "0x1E283B0", VA = "0x1E283B0")]
		private void ExpertCurvesEndUpdate()
		{
		}

		[Token(Token = "0x60003DB")]
		[Address(RVA = "0x1E27B44", Offset = "0x1E27B44", VA = "0x1E27B44")]
		private void Expert_UpdatePosSpeed()
		{
		}

		[Token(Token = "0x60003DC")]
		[Address(RVA = "0x1E27C78", Offset = "0x1E27C78", VA = "0x1E27C78")]
		private void Expert_UpdateRotSpeed()
		{
		}

		[Token(Token = "0x60003DD")]
		[Address(RVA = "0x1E27DAC", Offset = "0x1E27DAC", VA = "0x1E27DAC")]
		private void Expert_UpdateSpringiness()
		{
		}

		[Token(Token = "0x60003DE")]
		[Address(RVA = "0x1E27EE0", Offset = "0x1E27EE0", VA = "0x1E27EE0")]
		private void Expert_UpdateSlithery()
		{
		}

		[Token(Token = "0x60003DF")]
		[Address(RVA = "0x1E28014", Offset = "0x1E28014", VA = "0x1E28014")]
		private void Expert_UpdateCurling()
		{
		}

		[Token(Token = "0x60003E0")]
		[Address(RVA = "0x1E28148", Offset = "0x1E28148", VA = "0x1E28148")]
		private void Expert_UpdateSlippery()
		{
		}

		[Token(Token = "0x60003E1")]
		[Address(RVA = "0x1E2827C", Offset = "0x1E2827C", VA = "0x1E2827C")]
		private void Expert_UpdateBlending()
		{
		}

		[Token(Token = "0x60003E2")]
		[Address(RVA = "0x1E28570", Offset = "0x1E28570", VA = "0x1E28570")]
		private void InitIK()
		{
		}

		[Token(Token = "0x60003E3")]
		[Address(RVA = "0x1E28938", Offset = "0x1E28938", VA = "0x1E28938")]
		public void IKSetCustomPosition(Vector3? tgt)
		{
		}

		[Token(Token = "0x60003E4")]
		[Address(RVA = "0x1E28940", Offset = "0x1E28940", VA = "0x1E28940")]
		private void UpdateIK()
		{
		}

		[Token(Token = "0x60003E5")]
		[Address(RVA = "0x1E286C0", Offset = "0x1E286C0", VA = "0x1E286C0")]
		public void IK_ApplyLimitBoneSettings()
		{
		}

		[Token(Token = "0x60003E6")]
		[Address(RVA = "0x1E28C60", Offset = "0x1E28C60", VA = "0x1E28C60")]
		public void IK_RefreshLimitSettingsContainer()
		{
		}

		[Token(Token = "0x60003E7")]
		[Address(RVA = "0x1E28D80", Offset = "0x1E28D80", VA = "0x1E28D80")]
		private bool PostProcessingNeeded()
		{
			return default(bool);
		}

		[Token(Token = "0x60003E8")]
		[Address(RVA = "0x1E28DDC", Offset = "0x1E28DDC", VA = "0x1E28DDC")]
		private void PostProcessing_Begin()
		{
		}

		[Token(Token = "0x60003E9")]
		[Address(RVA = "0x1E2922C", Offset = "0x1E2922C", VA = "0x1E2922C")]
		private void PostProcessing_ReferenceUpdate()
		{
		}

		[Token(Token = "0x60003EA")]
		[Address(RVA = "0x1E29D84", Offset = "0x1E29D84", VA = "0x1E29D84")]
		private void ShapingParamsUpdate()
		{
		}

		[Token(Token = "0x60003EB")]
		[Address(RVA = "0x1E29DB0", Offset = "0x1E29DB0", VA = "0x1E29DB0")]
		private void Shaping_UpdateCurving()
		{
		}

		[Token(Token = "0x60003EC")]
		[Address(RVA = "0x1E2A034", Offset = "0x1E2A034", VA = "0x1E2A034")]
		private void Shaping_UpdateGravity()
		{
		}

		[Token(Token = "0x60003ED")]
		[Address(RVA = "0x1E2A368", Offset = "0x1E2A368", VA = "0x1E2A368")]
		private void Shaping_UpdateLengthMultiplier()
		{
		}

		[Token(Token = "0x60003EE")]
		[Address(RVA = "0x1E2A494", Offset = "0x1E2A494", VA = "0x1E2A494")]
		private void ShapingEndUpdate()
		{
		}

		[Token(Token = "0x60003F1")]
		[Address(RVA = "0x1E2A5A0", Offset = "0x1E2A5A0", VA = "0x1E2A5A0")]
		private void Waving_Initialize()
		{
		}

		[Token(Token = "0x60003F2")]
		[Address(RVA = "0x1E2A63C", Offset = "0x1E2A63C", VA = "0x1E2A63C")]
		private void Waving_AutoSwingUpdate()
		{
		}

		[Token(Token = "0x60003F3")]
		[Address(RVA = "0x1E2A86C", Offset = "0x1E2A86C", VA = "0x1E2A86C")]
		private void Waving_SustainUpdate()
		{
		}

		[Token(Token = "0x60003F4")]
		[Address(RVA = "0x1E2AB4C", Offset = "0x1E2AB4C", VA = "0x1E2AB4C")]
		private void WindEffectUpdate()
		{
		}

		[Token(Token = "0x60003F5")]
		[Address(RVA = "0x1E2AED4", Offset = "0x1E2AED4", VA = "0x1E2AED4", Slot = "6")]
		protected virtual void Init()
		{
		}

		[Token(Token = "0x60003F6")]
		[Address(RVA = "0x1E2C6BC", Offset = "0x1E2C6BC", VA = "0x1E2C6BC")]
		public void DetachChildrenTransforms()
		{
		}

		[Token(Token = "0x60003F7")]
		[Address(RVA = "0x1E2C8F0", Offset = "0x1E2C8F0", VA = "0x1E2C8F0")]
		private void InitializePostProcessing()
		{
		}

		[Token(Token = "0x60003F8")]
		[Address(RVA = "0x1E2D4C8", Offset = "0x1E2D4C8", VA = "0x1E2D4C8")]
		protected void StretchingLimiting(TailSegment bone)
		{
		}

		[Token(Token = "0x60003F9")]
		[Address(RVA = "0x1E2D6D0", Offset = "0x1E2D6D0", VA = "0x1E2D6D0")]
		protected Vector3 AngleLimiting(TailSegment child, Vector3 targetPos)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003FA")]
		[Address(RVA = "0x1E2DB40", Offset = "0x1E2DB40", VA = "0x1E2DB40")]
		private void MotionInfluenceLimiting()
		{
		}

		[Token(Token = "0x60003FB")]
		[Address(RVA = "0x1E2DD30", Offset = "0x1E2DD30", VA = "0x1E2DD30")]
		private void CalculateGravityPositionOffsetForSegment(TailSegment bone)
		{
		}

		[Token(Token = "0x60003FC")]
		[Address(RVA = "0x1E2DE48", Offset = "0x1E2DE48", VA = "0x1E2DE48")]
		private void Axis2DLimit(TailSegment child)
		{
		}

		[Token(Token = "0x60003FD")]
		[Address(RVA = "0x1E2DEC8", Offset = "0x1E2DEC8", VA = "0x1E2DEC8")]
		public float GetDistanceMeasure(Vector3 targetPosition)
		{
			return default(float);
		}

		[Token(Token = "0x60003FE")]
		[Address(RVA = "0x1E2DF94", Offset = "0x1E2DF94", VA = "0x1E2DF94")]
		private void MaxDistanceCalculations()
		{
		}

		[Token(Token = "0x60003FF")]
		[Address(RVA = "0x1E2E268", Offset = "0x1E2E268", VA = "0x1E2E268")]
		private Vector3 TailCalculations_SmoothPosition(Vector3 from, Vector3 to, TailSegment bone)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000400")]
		[Address(RVA = "0x1E2E494", Offset = "0x1E2E494", VA = "0x1E2E494")]
		private Vector3 TailCalculations_SmoothPositionLerp(Vector3 from, Vector3 to, float speed)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000401")]
		[Address(RVA = "0x1E2E3C4", Offset = "0x1E2E3C4", VA = "0x1E2E3C4")]
		private Vector3 TailCalculations_SmoothPositionSmoothDamp(Vector3 from, Vector3 to, ref Vector3 velo, float speed)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000402")]
		[Address(RVA = "0x1E2E4C4", Offset = "0x1E2E4C4", VA = "0x1E2E4C4")]
		private Vector3 TailCalculations_SmoothPositionLinear(Vector3 from, Vector3 to, float speed)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000403")]
		[Address(RVA = "0x1E2E4E0", Offset = "0x1E2E4E0", VA = "0x1E2E4E0")]
		private Quaternion TailCalculations_SmoothRotation(Quaternion from, Quaternion to, TailSegment bone)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000404")]
		[Address(RVA = "0x1E2E73C", Offset = "0x1E2E73C", VA = "0x1E2E73C")]
		private Quaternion TailCalculations_SmoothRotationLerp(Quaternion from, Quaternion to, float speed)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000405")]
		[Address(RVA = "0x1E2E65C", Offset = "0x1E2E65C", VA = "0x1E2E65C")]
		private Quaternion TailCalculations_SmoothRotationSmoothDamp(Quaternion from, Quaternion to, ref Quaternion velo, float speed)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000406")]
		[Address(RVA = "0x1E2E754", Offset = "0x1E2E754", VA = "0x1E2E754")]
		private Quaternion TailCalculations_SmoothRotationLinear(Quaternion from, Quaternion to, float speed)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000409")]
		[Address(RVA = "0x1E2E788", Offset = "0x1E2E788", VA = "0x1E2E788")]
		private void TailCalculations_Begin()
		{
		}

		[Token(Token = "0x600040A")]
		[Address(RVA = "0x1E2E8F4", Offset = "0x1E2E8F4", VA = "0x1E2E8F4")]
		private void TailSegments_UpdateRootFeatures()
		{
		}

		[Token(Token = "0x600040B")]
		[Address(RVA = "0x1E29770", Offset = "0x1E29770", VA = "0x1E29770")]
		private void TailCalculations_SegmentPreProcessingStack(TailSegment child)
		{
		}

		[Token(Token = "0x600040C")]
		[Address(RVA = "0x1E2EA04", Offset = "0x1E2EA04", VA = "0x1E2EA04")]
		private void TailCalculations_SegmentPostProcessing(TailSegment bone)
		{
		}

		[Token(Token = "0x600040D")]
		[Address(RVA = "0x1E29B64", Offset = "0x1E29B64", VA = "0x1E29B64")]
		private void TailCalculations_SegmentRotation(TailSegment child, Vector3 localOffset)
		{
		}

		[Token(Token = "0x600040E")]
		[Address(RVA = "0x1E2EDAC", Offset = "0x1E2EDAC", VA = "0x1E2EDAC")]
		private void TailCalculations_SegmentRotationDetached(TailSegment child, Vector3 localOffset)
		{
		}

		[Token(Token = "0x600040F")]
		[Address(RVA = "0x1E2EFC4", Offset = "0x1E2EFC4", VA = "0x1E2EFC4")]
		private void TailCalculations_ApplySegmentMotion(TailSegment child)
		{
		}

		[Token(Token = "0x6000410")]
		[Address(RVA = "0x1E2F048", Offset = "0x1E2F048", VA = "0x1E2F048")]
		private void TailSegment_PrepareBoneLength(TailSegment child)
		{
		}

		[Token(Token = "0x6000411")]
		[Address(RVA = "0x1E294F0", Offset = "0x1E294F0", VA = "0x1E294F0")]
		private void TailSegment_PrepareMotionParameters(TailSegment child)
		{
		}

		[Token(Token = "0x6000412")]
		[Address(RVA = "0x1E29460", Offset = "0x1E29460", VA = "0x1E29460")]
		private void TailSegment_PrepareVelocity(TailSegment child)
		{
		}

		[Token(Token = "0x6000413")]
		[Address(RVA = "0x1E295C8", Offset = "0x1E295C8", VA = "0x1E295C8")]
		private void TailSegment_PrepareRotation(TailSegment child)
		{
		}

		[Token(Token = "0x6000414")]
		[Address(RVA = "0x1E29984", Offset = "0x1E29984", VA = "0x1E29984")]
		private void TailSegment_PrepareRotationDetached(TailSegment child)
		{
		}

		[Token(Token = "0x6000415")]
		[Address(RVA = "0x1E2963C", Offset = "0x1E2963C", VA = "0x1E2963C")]
		private void TailSegment_BaseSwingProcessing(TailSegment child)
		{
		}

		[Token(Token = "0x6000416")]
		[Address(RVA = "0x1E298E8", Offset = "0x1E298E8", VA = "0x1E298E8")]
		private void TailSegment_PreRotationPositionBlend(TailSegment child)
		{
		}

		[Token(Token = "0x6000417")]
		[Address(RVA = "0x1E2F39C", Offset = "0x1E2F39C", VA = "0x1E2F39C")]
		private Quaternion TailSegment_RotationSlithery(TailSegment child)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000418")]
		[Address(RVA = "0x1E2F488", Offset = "0x1E2F488", VA = "0x1E2F488")]
		private Quaternion TailSegment_RotationSlitheryDetached(TailSegment child)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000419")]
		[Address(RVA = "0x1E2F41C", Offset = "0x1E2F41C", VA = "0x1E2F41C")]
		private Quaternion GetSlitheryReferenceRotation(TailSegment child)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600041A")]
		[Address(RVA = "0x1E2F500", Offset = "0x1E2F500", VA = "0x1E2F500")]
		private Quaternion TailSegment_RotationStiff(TailSegment child)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600041B")]
		[Address(RVA = "0x1E2F0C0", Offset = "0x1E2F0C0", VA = "0x1E2F0C0")]
		private Quaternion TailSegment_GetSwingRotation(TailSegment child, float curlFactor)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600041C")]
		[Address(RVA = "0x1E2F1D8", Offset = "0x1E2F1D8", VA = "0x1E2F1D8")]
		private Quaternion TailSegment_GetSwingRotationDetached(TailSegment child, float curlFactor)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600041D")]
		[Address(RVA = "0x1E2F2E8", Offset = "0x1E2F2E8", VA = "0x1E2F2E8")]
		private float TailSegment_GetUnifiedBendinessMultiplier(TailSegment child)
		{
			return default(float);
		}

		[Token(Token = "0x600041E")]
		[Address(RVA = "0x1E28E98", Offset = "0x1E28E98", VA = "0x1E28E98")]
		public void TailSegments_UpdateCoordsForRootBone(TailSegment parent)
		{
		}

		[Token(Token = "0x600041F")]
		[Address(RVA = "0x1E299F8", Offset = "0x1E299F8", VA = "0x1E299F8")]
		public void TailCalculations_UpdateArtificialChildBone(TailSegment child)
		{
		}

		[Token(Token = "0x6000420")]
		[Address(RVA = "0x1E2F728", Offset = "0x1E2F728", VA = "0x1E2F728")]
		public void Editor_TailCalculations_RefreshArtificialParentBone()
		{
		}

		[Token(Token = "0x6000421")]
		[Address(RVA = "0x1E2F824", Offset = "0x1E2F824", VA = "0x1E2F824")]
		private void SimulateTailMotionFrame(bool pp)
		{
		}

		[Token(Token = "0x6000422")]
		[Address(RVA = "0x1E2FB14", Offset = "0x1E2FB14", VA = "0x1E2FB14")]
		private void UpdateTailAlgorithm()
		{
		}

		[Token(Token = "0x6000423")]
		[Address(RVA = "0x1E2D174", Offset = "0x1E2D174", VA = "0x1E2D174")]
		private void CheckIfTailAnimatorShouldBeUpdated()
		{
		}

		[Token(Token = "0x6000424")]
		[Address(RVA = "0x1E30180", Offset = "0x1E30180", VA = "0x1E30180")]
		private void DeltaTimeCalculations()
		{
		}

		[Token(Token = "0x6000425")]
		[Address(RVA = "0x1E30368", Offset = "0x1E30368", VA = "0x1E30368")]
		private void StableUpdateRateCalculations()
		{
		}

		[Token(Token = "0x6000426")]
		[Address(RVA = "0x1E2D444", Offset = "0x1E2D444", VA = "0x1E2D444")]
		private void PreCalibrateBones()
		{
		}

		[Token(Token = "0x6000427")]
		[Address(RVA = "0x1E303D8", Offset = "0x1E303D8", VA = "0x1E303D8")]
		private void CalibrateBones()
		{
		}

		[Token(Token = "0x6000428")]
		[Address(RVA = "0x1E30438", Offset = "0x1E30438", VA = "0x1E30438")]
		public void CheckForNullsInGhostChain()
		{
		}

		[Token(Token = "0x6000429")]
		[Address(RVA = "0x1E303B4", Offset = "0x1E303B4", VA = "0x1E303B4")]
		private float GetClampedSmoothDelta()
		{
			return default(float);
		}

		[Token(Token = "0x600042A")]
		[Address(RVA = "0x1E2F5E4", Offset = "0x1E2F5E4", VA = "0x1E2F5E4")]
		private Quaternion MultiplyQ(Quaternion rotation, float times)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600042B")]
		[Address(RVA = "0x1E305A8", Offset = "0x1E305A8", VA = "0x1E305A8")]
		public float GetValueFromCurve(int i, AnimationCurve c)
		{
			return default(float);
		}

		[Token(Token = "0x600042C")]
		[Address(RVA = "0x1E30668", Offset = "0x1E30668", VA = "0x1E30668")]
		public AnimationCurve ClampCurve(AnimationCurve a, float timeStart, float timeEnd, float lowest, float highest)
		{
			return null;
		}

		[Token(Token = "0x600042D")]
		[Address(RVA = "0x1E307D8", Offset = "0x1E307D8", VA = "0x1E307D8")]
		public void RefreshTransformsList()
		{
		}

		[Token(Token = "0x600042E")]
		[Address(RVA = "0x1E30938", Offset = "0x1E30938", VA = "0x1E30938")]
		public TailSegment GetGhostChild()
		{
			return null;
		}

		[Token(Token = "0x600042F")]
		[Address(RVA = "0x1E30940", Offset = "0x1E30940", VA = "0x1E30940")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x8D23DC", Offset = "0x8D23DC")]
		private IEnumerator LateFixed()
		{
			return null;
		}

		[Token(Token = "0x6000430")]
		[Address(RVA = "0x1E2910C", Offset = "0x1E2910C", VA = "0x1E2910C")]
		private void Deflection_BeginUpdate()
		{
		}

		[Token(Token = "0x6000431")]
		[Address(RVA = "0x1E30A6C", Offset = "0x1E30A6C", VA = "0x1E30A6C")]
		private void Deflection_RemoveDeflectionSource(TailSegment child)
		{
		}

		[Token(Token = "0x6000432")]
		[Address(RVA = "0x1E309B8", Offset = "0x1E309B8", VA = "0x1E309B8")]
		private void Deflection_AddDeflectionSource(TailSegment child)
		{
		}

		[Token(Token = "0x6000433")]
		[Address(RVA = "0x1E2EA8C", Offset = "0x1E2EA8C", VA = "0x1E2EA8C")]
		private void Deflection_SegmentOffsetSimple(TailSegment child, ref Vector3 position)
		{
		}

		[Token(Token = "0x6000434")]
		[Address(RVA = "0x1E30B30", Offset = "0x1E30B30", VA = "0x1E30B30")]
		public void User_SetTailTransforms(List<Transform> list)
		{
		}

		[Token(Token = "0x6000435")]
		[Address(RVA = "0x1E30C00", Offset = "0x1E30C00", VA = "0x1E30C00")]
		public TailSegment User_AddTailTransform(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x6000436")]
		[Address(RVA = "0x1E30E44", Offset = "0x1E30E44", VA = "0x1E30E44")]
		public void User_CutEndSegmentsTo(int fromLastTo)
		{
		}

		[Token(Token = "0x6000437")]
		[Address(RVA = "0x1E300C0", Offset = "0x1E300C0", VA = "0x1E300C0")]
		public void User_ReposeTail()
		{
		}

		[Token(Token = "0x6000439")]
		[Address(RVA = "0x1E31200", Offset = "0x1E31200", VA = "0x1E31200", Slot = "4")]
		public void OnDrop(PointerEventData data)
		{
		}

		[Token(Token = "0x600043B")]
		[Address(RVA = "0x1E3120C", Offset = "0x1E3120C", VA = "0x1E3120C")]
		private void OnValidate()
		{
		}

		[Token(Token = "0x600043C")]
		[Address(RVA = "0x1E2BE60", Offset = "0x1E2BE60", VA = "0x1E2BE60")]
		public void GetGhostChain()
		{
		}

		[Token(Token = "0x600043E")]
		[Address(RVA = "0x1E31280", Offset = "0x1E31280", VA = "0x1E31280")]
		private void Start()
		{
		}

		[Token(Token = "0x600043F")]
		[Address(RVA = "0x1E312EC", Offset = "0x1E312EC", VA = "0x1E312EC")]
		private void Reset()
		{
		}

		[Token(Token = "0x6000440")]
		[Address(RVA = "0x1E2CC74", Offset = "0x1E2CC74", VA = "0x1E2CC74")]
		private void Update()
		{
		}

		[Token(Token = "0x6000441")]
		[Address(RVA = "0x1E31470", Offset = "0x1E31470", VA = "0x1E31470")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000442")]
		[Address(RVA = "0x1E2CD60", Offset = "0x1E2CD60", VA = "0x1E2CD60")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000443")]
		[Address(RVA = "0x1E31530", Offset = "0x1E31530", VA = "0x1E31530")]
		private void EndUpdate()
		{
		}

		[Token(Token = "0x6000444")]
		[Address(RVA = "0x1E3157C", Offset = "0x1E3157C", VA = "0x1E3157C")]
		public TailAnimator2()
		{
		}
	}
	[Token(Token = "0x20000B3")]
	public static class FTail_Skinning
	{
		[Token(Token = "0x600048B")]
		[Address(RVA = "0x1A91EC8", Offset = "0x1A91EC8", VA = "0x1A91EC8")]
		public static FTail_SkinningVertexData[] CalculateVertexWeightingData(Mesh baseMesh, Transform[] bonesCoords, Vector3 spreadOffset, int weightBoneLimit = 2, float spreadValue = 0.8f, float spreadPower = 0.185f)
		{
			return null;
		}

		[Token(Token = "0x600048C")]
		[Address(RVA = "0x1A92100", Offset = "0x1A92100", VA = "0x1A92100")]
		public static FTail_SkinningVertexData[] CalculateVertexWeightingData(Mesh baseMesh, Vector3[] bonesPos, Quaternion[] bonesRot, Vector3 spreadOffset, int weightBoneLimit = 2, float spreadValue = 0.8f, float spreadPower = 0.185f)
		{
			return null;
		}

		[Token(Token = "0x600048D")]
		[Address(RVA = "0x1A929AC", Offset = "0x1A929AC", VA = "0x1A929AC")]
		public static SkinnedMeshRenderer SkinMesh(Mesh baseMesh, Transform skinParent, Transform[] bonesStructure, FTail_SkinningVertexData[] vertData)
		{
			return null;
		}

		[Token(Token = "0x600048E")]
		[Address(RVA = "0x1A92B74", Offset = "0x1A92B74", VA = "0x1A92B74")]
		public static SkinnedMeshRenderer SkinMesh(Mesh baseMesh, Vector3[] bonesPositions, Quaternion[] bonesRotations, FTail_SkinningVertexData[] vertData)
		{
			return null;
		}

		[Token(Token = "0x600048F")]
		[Address(RVA = "0x1A934F8", Offset = "0x1A934F8", VA = "0x1A934F8")]
		public static BoneWeight SetWeightIndex(BoneWeight weight, int bone = 0, int index = 0)
		{
			return default(BoneWeight);
		}

		[Token(Token = "0x6000490")]
		[Address(RVA = "0x1A93574", Offset = "0x1A93574", VA = "0x1A93574")]
		public static BoneWeight SetWeightToBone(BoneWeight weight, int bone = 0, float value = 1f)
		{
			return default(BoneWeight);
		}
	}
	[Serializable]
	[Token(Token = "0x20000B4")]
	public class FTail_SkinningVertexData
	{
		[Serializable]
		[Token(Token = "0x20000B5")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8CB234", Offset = "0x8CB234")]
		private sealed class <>c
		{
			[Token(Token = "0x400051D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x400051E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Comparison<Vector2> <>9__6_0;

			[Token(Token = "0x6000499")]
			[Address(RVA = "0x1181834", Offset = "0x1181834", VA = "0x1181834")]
			public <>c()
			{
			}

			[Token(Token = "0x600049A")]
			[Address(RVA = "0x118183C", Offset = "0x118183C", VA = "0x118183C")]
			internal int <CalculateVertexParameters>b__6_0(Vector2 a, Vector2 b)
			{
				return default(int);
			}
		}

		[Token(Token = "0x4000516")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Vector3 position;

		[Token(Token = "0x4000517")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public int[] bonesIndexes;

		[Token(Token = "0x4000518")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public int allMeshBonesCount;

		[Token(Token = "0x4000519")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float[] weights;

		[Token(Token = "0x400051A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float[] debugDists;

		[Token(Token = "0x400051B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float[] debugDistWeights;

		[Token(Token = "0x400051C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float[] debugWeights;

		[Token(Token = "0x6000491")]
		[Address(RVA = "0x1A923EC", Offset = "0x1A923EC", VA = "0x1A923EC")]
		public FTail_SkinningVertexData(Vector3 pos)
		{
		}

		[Token(Token = "0x6000492")]
		[Address(RVA = "0x1A935E0", Offset = "0x1A935E0", VA = "0x1A935E0")]
		public float DistanceToLine(Vector3 pos, Vector3 lineStart, Vector3 lineEnd)
		{
			return default(float);
		}

		[Token(Token = "0x6000493")]
		[Address(RVA = "0x1A92434", Offset = "0x1A92434", VA = "0x1A92434")]
		public void CalculateVertexParameters(Vector3[] bonesPos, Quaternion[] bonesRot, Vector3[] boneAreas, int maxWeightedBones, float spread, Vector3 spreadOffset, float spreadPower = 1f)
		{
		}

		[Token(Token = "0x6000494")]
		[Address(RVA = "0x1A93718", Offset = "0x1A93718", VA = "0x1A93718")]
		public void AutoSetBoneWeights(float[] weightForBone, float[] distToBone, float spread, float spreadPower, Vector3[] boneAreas)
		{
		}

		[Token(Token = "0x6000495")]
		[Address(RVA = "0x1A93B88", Offset = "0x1A93B88", VA = "0x1A93B88")]
		public static float DistributionIn(float k, float power)
		{
			return default(float);
		}

		[Token(Token = "0x6000496")]
		[Address(RVA = "0x1A93B94", Offset = "0x1A93B94", VA = "0x1A93B94")]
		public static Color GetBoneIndicatorColor(int boneIndex, int bonesCount, float s = 0.9f, float v = 0.9f)
		{
			return default(Color);
		}

		[Token(Token = "0x6000497")]
		[Address(RVA = "0x1A93BF4", Offset = "0x1A93BF4", VA = "0x1A93BF4")]
		public Color GetWeightColor()
		{
			return default(Color);
		}
	}
	[Token(Token = "0x20000B6")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x8CB244", Offset = "0x8CB244")]
	public class TailAnimatorWind : MonoBehaviour, IDropHandler, IEventSystemHandler, IFHierarchyIcon
	{
		[Token(Token = "0x400051F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8CE534", Offset = "0x8CE534")]
		private static TailAnimatorWind <Instance>k__BackingField;

		[Token(Token = "0x4000520")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "FPD_HeaderAttribute", RVA = "0x8CE544", Offset = "0x8CE544")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x8CE544", Offset = "0x8CE544")]
		public float power;

		[Token(Token = "0x4000521")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float additionalTurbulence;

		[Token(Token = "0x4000522")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float additionalTurbSpeed;

		[Token(Token = "0x4000523")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x8CE5B0", Offset = "0x8CE5B0")]
		public WindZone SyncWithUnityWindZone;

		[Token(Token = "0x4000524")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float UnityWindZonePowerMul;

		[Token(Token = "0x4000525")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float UnityWindZoneTurbMul;

		[Token(Token = "0x4000526")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x8CE5C4", Offset = "0x8CE5C4")]
		public Vector3 overrideWind;

		[Token(Token = "0x4000527")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8CE5FC", Offset = "0x8CE5FC")]
		[AttributeAttribute(Name = "FPD_HeaderAttribute", RVA = "0x8CE5FC", Offset = "0x8CE5FC")]
		public float rapidness;

		[Token(Token = "0x4000528")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "FPD_SuffixAttribute", RVA = "0x8CE660", Offset = "0x8CE660")]
		public float changesPower;

		[Token(Token = "0x4000529")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8CE6AC", Offset = "0x8CE6AC")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x8CE6AC", Offset = "0x8CE6AC")]
		public float turbulenceSpeed;

		[Token(Token = "0x400052A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8CE700", Offset = "0x8CE700")]
		[AttributeAttribute(Name = "FPD_HeaderAttribute", RVA = "0x8CE700", Offset = "0x8CE700")]
		public float worldTurb;

		[Token(Token = "0x400052B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8CE76C", Offset = "0x8CE76C")]
		public float worldTurbScale;

		[Token(Token = "0x400052C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public float worldTurbSpeed;

		[Token(Token = "0x400052D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8CE7A4", Offset = "0x8CE7A4")]
		[AttributeAttribute(Name = "FPD_HeaderAttribute", RVA = "0x8CE7A4", Offset = "0x8CE7A4")]
		public bool powerDependOnTailLength;

		[Token(Token = "0x400052E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5D")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8CE810", Offset = "0x8CE810")]
		public bool persistThroughAllScenes;

		[Token(Token = "0x400052F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Vector3 targetWind;

		[Token(Token = "0x4000530")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private Vector3 smoothWind;

		[Token(Token = "0x4000531")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Vector3 windVeloHelper;

		[Token(Token = "0x4000532")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private Quaternion windOrientation;

		[Token(Token = "0x4000533")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private Quaternion smoothWindOrient;

		[Token(Token = "0x4000534")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		private Quaternion smoothWindOrientHelper;

		[Token(Token = "0x4000535")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private float[] randNumbers;

		[Token(Token = "0x4000536")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private float[] randTimes;

		[Token(Token = "0x4000537")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private float[] randSpeeds;

		[Token(Token = "0x4000538")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private int frameOffset;

		[Token(Token = "0x4000539")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		private Vector3 finalAddTurbulence;

		[Token(Token = "0x400053A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private Vector3 addTurbHelper;

		[Token(Token = "0x400053B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
		private Vector3 smoothAddTurbulence;

		[Token(Token = "0x17000092")]
		public string EditorIconPath
		{
			[Token(Token = "0x600049B")]
			[Address(RVA = "0x1E31B38", Offset = "0x1E31B38", VA = "0x1E31B38", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000093")]
		public static TailAnimatorWind Instance
		{
			[Token(Token = "0x600049D")]
			[Address(RVA = "0x1E31B80", Offset = "0x1E31B80", VA = "0x1E31B80")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8D268C", Offset = "0x8D268C")]
			get
			{
				return null;
			}
			[Token(Token = "0x600049E")]
			[Address(RVA = "0x1E31BCC", Offset = "0x1E31BCC", VA = "0x1E31BCC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8D269C", Offset = "0x8D269C")]
			private set
			{
			}
		}

		[Token(Token = "0x600049C")]
		[Address(RVA = "0x1E31B7C", Offset = "0x1E31B7C", VA = "0x1E31B7C", Slot = "4")]
		public void OnDrop(PointerEventData data)
		{
		}

		[Token(Token = "0x600049F")]
		[Address(RVA = "0x1E31C20", Offset = "0x1E31C20", VA = "0x1E31C20")]
		private void Awake()
		{
		}

		[Token(Token = "0x60004A0")]
		[Address(RVA = "0x1E31CF4", Offset = "0x1E31CF4", VA = "0x1E31CF4")]
		public void OnValidate()
		{
		}

		[Token(Token = "0x60004A1")]
		[Address(RVA = "0x1E31D48", Offset = "0x1E31D48", VA = "0x1E31D48")]
		private void Update()
		{
		}

		[Token(Token = "0x60004A2")]
		[Address(RVA = "0x1E2C7F0", Offset = "0x1E2C7F0", VA = "0x1E2C7F0")]
		public static void Refresh()
		{
		}

		[Token(Token = "0x60004A3")]
		[Address(RVA = "0x1E2AC38", Offset = "0x1E2AC38", VA = "0x1E2AC38")]
		public void AffectTailWithWind(TailAnimator2 t)
		{
		}

		[Token(Token = "0x60004A4")]
		[Address(RVA = "0x1E3232C", Offset = "0x1E3232C", VA = "0x1E3232C")]
		private void Start()
		{
		}

		[Token(Token = "0x60004A5")]
		[Address(RVA = "0x1E31D60", Offset = "0x1E31D60", VA = "0x1E31D60")]
		private void ComputeWind()
		{
		}

		[Token(Token = "0x60004A6")]
		[Address(RVA = "0x1E324A8", Offset = "0x1E324A8", VA = "0x1E324A8")]
		private Vector3 GetAddTurbulence()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60004A7")]
		[Address(RVA = "0x1E326D0", Offset = "0x1E326D0", VA = "0x1E326D0")]
		public TailAnimatorWind()
		{
		}
	}
	[Token(Token = "0x20000B7")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x8CB27C", Offset = "0x8CB27C")]
	public class TailCollisionHelper : MonoBehaviour
	{
		[Token(Token = "0x400053C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public TailAnimator2 ParentTail;

		[Token(Token = "0x400053D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Collider TailCollider;

		[Token(Token = "0x400053E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Collider2D TailCollider2D;

		[Token(Token = "0x400053F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public int Index;

		[Token(Token = "0x4000540")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8CE848", Offset = "0x8CE848")]
		private Rigidbody <RigBody>k__BackingField;

		[Token(Token = "0x4000541")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8CE858", Offset = "0x8CE858")]
		private Rigidbody2D <RigBody2D>k__BackingField;

		[Token(Token = "0x4000542")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Transform previousCollision;

		[Token(Token = "0x17000094")]
		internal Rigidbody RigBody
		{
			[Token(Token = "0x60004A8")]
			[Address(RVA = "0x1E327D8", Offset = "0x1E327D8", VA = "0x1E327D8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8D26AC", Offset = "0x8D26AC")]
			get
			{
				return null;
			}
			[Token(Token = "0x60004A9")]
			[Address(RVA = "0x1E327E0", Offset = "0x1E327E0", VA = "0x1E327E0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8D26BC", Offset = "0x8D26BC")]
			private set
			{
			}
		}

		[Token(Token = "0x17000095")]
		internal Rigidbody2D RigBody2D
		{
			[Token(Token = "0x60004AA")]
			[Address(RVA = "0x1E327E8", Offset = "0x1E327E8", VA = "0x1E327E8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8D26CC", Offset = "0x8D26CC")]
			get
			{
				return null;
			}
			[Token(Token = "0x60004AB")]
			[Address(RVA = "0x1E327F0", Offset = "0x1E327F0", VA = "0x1E327F0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8D26DC", Offset = "0x8D26DC")]
			private set
			{
			}
		}

		[Token(Token = "0x60004AC")]
		[Address(RVA = "0x1E264B0", Offset = "0x1E264B0", VA = "0x1E264B0")]
		internal TailCollisionHelper Init(bool addRigidbody = true, float mass = 1f, bool kinematic = false)
		{
			return null;
		}

		[Token(Token = "0x60004AD")]
		[Address(RVA = "0x1E327F8", Offset = "0x1E327F8", VA = "0x1E327F8")]
		private void OnCollisionEnter(Collision collision)
		{
		}

		[Token(Token = "0x60004AE")]
		[Address(RVA = "0x1E32A24", Offset = "0x1E32A24", VA = "0x1E32A24")]
		private void OnCollisionExit(Collision collision)
		{
		}

		[Token(Token = "0x60004AF")]
		[Address(RVA = "0x1E32AF0", Offset = "0x1E32AF0", VA = "0x1E32AF0")]
		private void OnTriggerEnter(Collider other)
		{
		}

		[Token(Token = "0x60004B0")]
		[Address(RVA = "0x1E32CDC", Offset = "0x1E32CDC", VA = "0x1E32CDC")]
		private void OnTriggerExit(Collider other)
		{
		}

		[Token(Token = "0x60004B1")]
		[Address(RVA = "0x1E32DC0", Offset = "0x1E32DC0", VA = "0x1E32DC0")]
		private void OnTriggerEnter2D(Collider2D other)
		{
		}

		[Token(Token = "0x60004B2")]
		[Address(RVA = "0x1E32FC8", Offset = "0x1E32FC8", VA = "0x1E32FC8")]
		private void OnTriggerExit2D(Collider2D other)
		{
		}

		[Token(Token = "0x60004B3")]
		[Address(RVA = "0x1E330AC", Offset = "0x1E330AC", VA = "0x1E330AC")]
		public TailCollisionHelper()
		{
		}
	}
}
namespace FIMSpace.FSpinner
{
	[Token(Token = "0x20000B8")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x8CB2B4", Offset = "0x8CB2B4")]
	public class FSpinner_Creator : FSpinner_CreatorBase
	{
		[Token(Token = "0x4000543")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD9")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x8CE868", Offset = "0x8CE868")]
		public bool PreviewInEditor;

		[Token(Token = "0x4000544")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		internal FSpinner_CreatorLivePreview livePreview;

		[Token(Token = "0x60004B4")]
		[Address(RVA = "0x1A8F6F0", Offset = "0x1A8F6F0", VA = "0x1A8F6F0", Slot = "4")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60004B5")]
		[Address(RVA = "0x1A8FC20", Offset = "0x1A8FC20", VA = "0x1A8FC20", Slot = "6")]
		protected override void OnValidate()
		{
		}

		[Token(Token = "0x60004B6")]
		[Address(RVA = "0x1A90140", Offset = "0x1A90140", VA = "0x1A90140")]
		public FSpinner_Creator()
		{
		}
	}
	[Token(Token = "0x20000B9")]
	public abstract class FSpinner_CreatorBase : MonoBehaviour
	{
		[Token(Token = "0x20000BA")]
		protected class FSpinner_CreatorWaver
		{
			[Token(Token = "0x4000564")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float time;

			[Token(Token = "0x4000565")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public float timeSpeed;

			[Token(Token = "0x60004BC")]
			[Address(RVA = "0x1181750", Offset = "0x1181750", VA = "0x1181750")]
			public FSpinner_CreatorWaver()
			{
			}

			[Token(Token = "0x60004BD")]
			[Address(RVA = "0x1181790", Offset = "0x1181790", VA = "0x1181790")]
			public float GetValue()
			{
				return default(float);
			}
		}

		[Token(Token = "0x4000545")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x8CE8A0", Offset = "0x8CE8A0")]
		public GameObject BigDotPrefab;

		[Token(Token = "0x4000546")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public GameObject SmallDotPrefab;

		[Token(Token = "0x4000547")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8CE8D8", Offset = "0x8CE8D8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8CE8D8", Offset = "0x8CE8D8")]
		public int BigDots;

		[Token(Token = "0x4000548")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8CE92C", Offset = "0x8CE92C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8CE92C", Offset = "0x8CE92C")]
		public int SmallDots;

		[Token(Token = "0x4000549")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x8CE980", Offset = "0x8CE980")]
		public float RotationSpeed;

		[Token(Token = "0x400054A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float BigDotsRadius;

		[Token(Token = "0x400054B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float SmallDotsRadius;

		[Token(Token = "0x400054C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x8CE9B8", Offset = "0x8CE9B8")]
		public float AnimationSpeed;

		[Token(Token = "0x400054D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float BigRadiusVariation;

		[Token(Token = "0x400054E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float IterationOffset;

		[Token(Token = "0x400054F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float SinusMultiplier;

		[Token(Token = "0x4000550")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public float CosinusMultiplier;

		[Token(Token = "0x4000551")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x8CE9F0", Offset = "0x8CE9F0")]
		public float WaversSpeed;

		[Token(Token = "0x4000552")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public float BigDotsRadiusWaver;

		[Token(Token = "0x4000553")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		protected FSpinner_CreatorWaver bigDotsWaver;

		[Token(Token = "0x4000554")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public float SmallDotsRadiusWaver;

		[Token(Token = "0x4000555")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		protected FSpinner_CreatorWaver smallDotsWaver;

		[Token(Token = "0x4000556")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public float BigRadiusVariationWaver;

		[Token(Token = "0x4000557")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		protected FSpinner_CreatorWaver bigRadiusWaver;

		[Token(Token = "0x4000558")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public float SinusMultiplierWaver;

		[Token(Token = "0x4000559")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		protected FSpinner_CreatorWaver sinusWaver;

		[Token(Token = "0x400055A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public float CosinusMultiplierWaver;

		[Token(Token = "0x400055B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		protected FSpinner_CreatorWaver cosinusWaver;

		[Token(Token = "0x400055C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		protected float time;

		[Token(Token = "0x400055D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		protected RectTransform rect;

		[Token(Token = "0x400055E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		protected RectTransform bigDotsContainer;

		[Token(Token = "0x400055F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		protected RectTransform smallDotsContainer;

		[Token(Token = "0x4000560")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		protected List<Image> dotsBigImages;

		[Token(Token = "0x4000561")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		protected List<Image> dotsSmallImages;

		[Token(Token = "0x4000562")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		protected Image dotsCenter;

		[Token(Token = "0x4000563")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		protected bool difference;

		[Token(Token = "0x60004B7")]
		[Address(RVA = "0x1A8F77C", Offset = "0x1A8F77C", VA = "0x1A8F77C", Slot = "4")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x60004B8")]
		[Address(RVA = "0x1A901A0", Offset = "0x1A901A0", VA = "0x1A901A0", Slot = "5")]
		public virtual void AssignObjects()
		{
		}

		[Token(Token = "0x60004B9")]
		[Address(RVA = "0x1A8FE8C", Offset = "0x1A8FE8C", VA = "0x1A8FE8C", Slot = "6")]
		protected virtual void OnValidate()
		{
		}

		[Token(Token = "0x60004BA")]
		[Address(RVA = "0x1A90754", Offset = "0x1A90754", VA = "0x1A90754", Slot = "7")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x60004BB")]
		[Address(RVA = "0x1A90170", Offset = "0x1A90170", VA = "0x1A90170")]
		protected FSpinner_CreatorBase()
		{
		}
	}
	[Token(Token = "0x20000BB")]
	public class FSpinner_CreatorLivePreview : FSpinner_CreatorBase
	{
		[Token(Token = "0x4000566")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		public FSpinner_Creator Parent;

		[Token(Token = "0x4000567")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		public bool RemoveMe;

		[Token(Token = "0x4000568")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private List<GameObject> generatedObjects;

		[Token(Token = "0x4000569")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private List<GameObject> toRemoveEditor;

		[Token(Token = "0x60004BE")]
		[Address(RVA = "0x1A90B68", Offset = "0x1A90B68", VA = "0x1A90B68", Slot = "4")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60004BF")]
		[Address(RVA = "0x1A90CB4", Offset = "0x1A90CB4", VA = "0x1A90CB4", Slot = "6")]
		protected override void OnValidate()
		{
		}

		[Token(Token = "0x60004C0")]
		[Address(RVA = "0x1A90CB8", Offset = "0x1A90CB8", VA = "0x1A90CB8", Slot = "7")]
		protected override void Update()
		{
		}

		[Token(Token = "0x60004C1")]
		[Address(RVA = "0x1A90E34", Offset = "0x1A90E34", VA = "0x1A90E34")]
		protected void UpdateLivePreview()
		{
		}

		[Token(Token = "0x60004C2")]
		[Address(RVA = "0x1A90CF0", Offset = "0x1A90CF0", VA = "0x1A90CF0")]
		private void CheckIfShouldBeRemoved()
		{
		}

		[Token(Token = "0x60004C3")]
		[Address(RVA = "0x1A8FF74", Offset = "0x1A8FF74", VA = "0x1A8FF74")]
		public void ValidateTrigger()
		{
		}

		[Token(Token = "0x60004C4")]
		[Address(RVA = "0x1A916EC", Offset = "0x1A916EC", VA = "0x1A916EC")]
		protected void OnDestroy()
		{
		}

		[Token(Token = "0x60004C5")]
		[Address(RVA = "0x1A918E8", Offset = "0x1A918E8", VA = "0x1A918E8")]
		public FSpinner_CreatorLivePreview()
		{
		}
	}
}
namespace FIMSpace.FLook
{
	[Token(Token = "0x20000BC")]
	[AttributeAttribute(Name = "DefaultExecutionOrder", RVA = "0x8CB2EC", Offset = "0x8CB2EC")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x8CB2EC", Offset = "0x8CB2EC")]
	public class FLookAnimator : MonoBehaviour, IDropHandler, IEventSystemHandler, IFHierarchyIcon
	{
		[Serializable]
		[Token(Token = "0x20000BD")]
		public class CompensationBone
		{
			[Token(Token = "0x4000627")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform Transform;

			[Token(Token = "0x4000628")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private Vector3 compensatedPosition;

			[Token(Token = "0x4000629")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			private Quaternion compensatedRotation;

			[Token(Token = "0x400062A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private Quaternion lastFinalLocalRotation;

			[Token(Token = "0x400062B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			private Quaternion lastKeyframeLocalRotation;

			[Token(Token = "0x400062C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			private Vector3 lastFinalLocalPosition;

			[Token(Token = "0x400062D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private Vector3 lastKeyframeLocalPosition;

			[Token(Token = "0x6000534")]
			[Address(RVA = "0x11807E4", Offset = "0x11807E4", VA = "0x11807E4")]
			public CompensationBone(Transform t)
			{
			}

			[Token(Token = "0x6000535")]
			[Address(RVA = "0x11808A8", Offset = "0x11808A8", VA = "0x11808A8")]
			public void RefreshCompensationFrame()
			{
			}

			[Token(Token = "0x6000536")]
			[Address(RVA = "0x11808F8", Offset = "0x11808F8", VA = "0x11808F8")]
			public void CheckForZeroKeyframes()
			{
			}

			[Token(Token = "0x6000537")]
			[Address(RVA = "0x1180A48", Offset = "0x1180A48", VA = "0x1180A48")]
			public void SetRotationCompensation(float weight)
			{
			}

			[Token(Token = "0x6000538")]
			[Address(RVA = "0x1180AEC", Offset = "0x1180AEC", VA = "0x1180AEC")]
			public void SetPositionCompensation(float weight)
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000BE")]
		public class LookBone
		{
			[Token(Token = "0x400062E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform Transform;

			[Token(Token = "0x400062F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Quaternion animatedStaticRotation;

			[Token(Token = "0x4000630")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Quaternion targetStaticRotation;

			[Token(Token = "0x4000631")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Quaternion localStaticRotation;

			[Token(Token = "0x4000632")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public Quaternion animatedTargetRotation;

			[Token(Token = "0x4000633")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public Quaternion targetRotation;

			[Token(Token = "0x4000634")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			public Vector3 correctionOffset;

			[Token(Token = "0x4000635")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
			public Quaternion finalRotation;

			[Token(Token = "0x4000636")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
			public Quaternion lastKeyframeRotation;

			[Token(Token = "0x4000637")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
			public Quaternion lastFinalLocalRotation;

			[Token(Token = "0x4000638")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
			public Vector3 forward;

			[Token(Token = "0x4000639")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
			public Vector3 right;

			[Token(Token = "0x400063A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
			public Vector3 up;

			[Token(Token = "0x400063B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
			public Vector3 initLocalPos;

			[Token(Token = "0x400063C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
			public Quaternion initLocalRot;

			[Token(Token = "0x400063D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
			public Vector3 targetDelayPosition;

			[Token(Token = "0x400063E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
			public Vector3 animatedDelayPosition;

			[Token(Token = "0x400063F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xFC")]
			public float lookWeight;

			[Token(Token = "0x4000640")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
			public float lookWeightB;

			[Token(Token = "0x4000641")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
			public float motionWeight;

			[Token(Token = "0x170000A1")]
			public Quaternion correctionOffsetQ
			{
				[Token(Token = "0x6000539")]
				[Address(RVA = "0x1180BA0", Offset = "0x1180BA0", VA = "0x1180BA0")]
				get
				{
					return default(Quaternion);
				}
			}

			[Token(Token = "0x600053A")]
			[Address(RVA = "0x1180BB0", Offset = "0x1180BB0", VA = "0x1180BB0")]
			public LookBone(Transform t)
			{
			}

			[Token(Token = "0x600053B")]
			[Address(RVA = "0x1180CBC", Offset = "0x1180CBC", VA = "0x1180CBC")]
			public void RefreshBoneDirections(Transform baseTransform)
			{
			}

			[Token(Token = "0x600053C")]
			[Address(RVA = "0x11803C8", Offset = "0x11803C8", VA = "0x11803C8")]
			public void RefreshStaticRotation(bool hard = true)
			{
			}

			[Token(Token = "0x600053D")]
			[Address(RVA = "0x1180F1C", Offset = "0x1180F1C", VA = "0x1180F1C")]
			internal void CalculateMotion(Quaternion targetLook, float overallWeightMultiplier, float delta, float mainWeight)
			{
			}

			[Token(Token = "0x600053E")]
			[Address(RVA = "0x1181060", Offset = "0x1181060", VA = "0x1181060")]
			internal Quaternion GetTargetRot(Quaternion targetLook, float weight)
			{
				return default(Quaternion);
			}
		}

		[Token(Token = "0x20000BF")]
		public enum EFAxisFixOrder
		{
			[Token(Token = "0x4000643")]
			Parental,
			[Token(Token = "0x4000644")]
			FromBased,
			[Token(Token = "0x4000645")]
			FullManual,
			[Token(Token = "0x4000646")]
			ZYX
		}

		[Token(Token = "0x20000C0")]
		public enum EFHeadLookState
		{
			[Token(Token = "0x4000648")]
			Null,
			[Token(Token = "0x4000649")]
			Following,
			[Token(Token = "0x400064A")]
			OutOfMaxRotation,
			[Token(Token = "0x400064B")]
			ClampedAngle,
			[Token(Token = "0x400064C")]
			OutOfMaxDistance
		}

		[Token(Token = "0x20000C1")]
		public enum EFFollowMode
		{
			[Token(Token = "0x400064E")]
			FollowObject,
			[Token(Token = "0x400064F")]
			LocalOffset,
			[Token(Token = "0x4000650")]
			WorldOffset,
			[Token(Token = "0x4000651")]
			ToFollowSpaceOffset,
			[Token(Token = "0x4000652")]
			FollowJustPosition
		}

		[Token(Token = "0x20000C2")]
		public enum EFDeltaType
		{
			[Token(Token = "0x4000654")]
			DeltaTime,
			[Token(Token = "0x4000655")]
			SmoothDeltaTime,
			[Token(Token = "0x4000656")]
			UnscaledDeltaTime,
			[Token(Token = "0x4000657")]
			FixedDeltaTime
		}

		[Token(Token = "0x20000C3")]
		public enum EFAnimationStyle
		{
			[Token(Token = "0x4000659")]
			SmoothDamp,
			[Token(Token = "0x400065A")]
			FastLerp,
			[Token(Token = "0x400065B")]
			Linear
		}

		[Token(Token = "0x20000C4")]
		public enum EEditorLookCategory
		{
			[Token(Token = "0x400065D")]
			Setup,
			[Token(Token = "0x400065E")]
			Tweak,
			[Token(Token = "0x400065F")]
			Limit,
			[Token(Token = "0x4000660")]
			Features,
			[Token(Token = "0x4000661")]
			Corrections
		}

		[Token(Token = "0x20000C5")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8CB33C", Offset = "0x8CB33C")]
		private sealed class <AnimatePhysicsClock>d__103 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000662")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000663")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000664")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public FLookAnimator <>4__this;

			[Token(Token = "0x170000A2")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000542")]
				[Address(RVA = "0x117FEE4", Offset = "0x117FEE4", VA = "0x117FEE4", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000A3")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000544")]
				[Address(RVA = "0x117FF2C", Offset = "0x117FF2C", VA = "0x117FF2C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600053F")]
			[Address(RVA = "0x117FDF8", Offset = "0x117FDF8", VA = "0x117FDF8")]
			[DebuggerHidden]
			public <AnimatePhysicsClock>d__103(int <>1__state)
			{
			}

			[Token(Token = "0x6000540")]
			[Address(RVA = "0x117FE24", Offset = "0x117FE24", VA = "0x117FE24", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000541")]
			[Address(RVA = "0x117FE28", Offset = "0x117FE28", VA = "0x117FE28", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000543")]
			[Address(RVA = "0x117FEEC", Offset = "0x117FEEC", VA = "0x117FEEC", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x20000C6")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8CB34C", Offset = "0x8CB34C")]
		private sealed class <SwitchLookingTransition>d__106 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000665")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000666")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000667")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public FLookAnimator <>4__this;

			[Token(Token = "0x4000668")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public float transitionTime;

			[Token(Token = "0x4000669")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public bool enableAnimation;

			[Token(Token = "0x400066A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Action callback;

			[Token(Token = "0x400066B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private float <time>5__2;

			[Token(Token = "0x400066C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private float <startBlend>5__3;

			[Token(Token = "0x170000A4")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000548")]
				[Address(RVA = "0x1180794", Offset = "0x1180794", VA = "0x1180794", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000A5")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600054A")]
				[Address(RVA = "0x11807DC", Offset = "0x11807DC", VA = "0x11807DC", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000545")]
			[Address(RVA = "0x1180690", Offset = "0x1180690", VA = "0x1180690")]
			[DebuggerHidden]
			public <SwitchLookingTransition>d__106(int <>1__state)
			{
			}

			[Token(Token = "0x6000546")]
			[Address(RVA = "0x11806BC", Offset = "0x11806BC", VA = "0x11806BC", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000547")]
			[Address(RVA = "0x11806C0", Offset = "0x11806C0", VA = "0x11806C0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000549")]
			[Address(RVA = "0x118079C", Offset = "0x118079C", VA = "0x118079C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x20000C7")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8CB35C", Offset = "0x8CB35C")]
		private sealed class <CResetMomentLookTransform>d__107 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400066D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400066E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400066F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float time;

			[Token(Token = "0x4000670")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public FLookAnimator <>4__this;

			[Token(Token = "0x4000671")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Transform transform;

			[Token(Token = "0x170000A6")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600054E")]
				[Address(RVA = "0x1180640", Offset = "0x1180640", VA = "0x1180640", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000A7")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000550")]
				[Address(RVA = "0x1180688", Offset = "0x1180688", VA = "0x1180688", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600054B")]
			[Address(RVA = "0x11804D4", Offset = "0x11804D4", VA = "0x11804D4")]
			[DebuggerHidden]
			public <CResetMomentLookTransform>d__107(int <>1__state)
			{
			}

			[Token(Token = "0x600054C")]
			[Address(RVA = "0x1180500", Offset = "0x1180500", VA = "0x1180500", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600054D")]
			[Address(RVA = "0x1180504", Offset = "0x1180504", VA = "0x1180504", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600054F")]
			[Address(RVA = "0x1180648", Offset = "0x1180648", VA = "0x1180648", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x20000C8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8CB36C", Offset = "0x8CB36C")]
		private sealed class <CRefreshReferencePose>d__163 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000672")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000673")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000674")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public FLookAnimator <>4__this;

			[Token(Token = "0x4000675")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private float <elapsed>5__2;

			[Token(Token = "0x170000A8")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000554")]
				[Address(RVA = "0x1180484", Offset = "0x1180484", VA = "0x1180484", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000A9")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000556")]
				[Address(RVA = "0x11804CC", Offset = "0x11804CC", VA = "0x11804CC", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000551")]
			[Address(RVA = "0x117FF34", Offset = "0x117FF34", VA = "0x117FF34")]
			[DebuggerHidden]
			public <CRefreshReferencePose>d__163(int <>1__state)
			{
			}

			[Token(Token = "0x6000552")]
			[Address(RVA = "0x117FF60", Offset = "0x117FF60", VA = "0x117FF60", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000553")]
			[Address(RVA = "0x117FF64", Offset = "0x117FF64", VA = "0x117FF64", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000555")]
			[Address(RVA = "0x118048C", Offset = "0x118048C", VA = "0x118048C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400056A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8CEA28", Offset = "0x8CEA28")]
		private Transform <MomentLookTransform>k__BackingField;

		[Token(Token = "0x400056B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private GameObject generatedMomentTarget;

		[Token(Token = "0x400056C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool wasMomentLookTransform;

		[Token(Token = "0x400056D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8CEA38", Offset = "0x8CEA38")]
		public bool BirdMode;

		[Token(Token = "0x400056E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2A")]
		private bool birdModeInitialized;

		[Token(Token = "0x400056F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "FPD_SuffixAttribute", RVA = "0x8CEA70", Offset = "0x8CEA70")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8CEA70", Offset = "0x8CEA70")]
		public float LagRotation;

		[Token(Token = "0x4000570")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "FPD_SuffixAttribute", RVA = "0x8CEAE0", Offset = "0x8CEAE0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8CEAE0", Offset = "0x8CEAE0")]
		public float LagEvery;

		[Token(Token = "0x4000571")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8CEB54", Offset = "0x8CEB54")]
		[AttributeAttribute(Name = "FPD_PercentageAttribute", RVA = "0x8CEB54", Offset = "0x8CEB54")]
		public float DelayPosition;

		[Token(Token = "0x4000572")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8CEBC8", Offset = "0x8CEBC8")]
		public float DelayMaxDistance;

		[Token(Token = "0x4000573")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8CEC00", Offset = "0x8CEC00")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8CEC00", Offset = "0x8CEC00")]
		public float DelayGoSpeed;

		[Token(Token = "0x4000574")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Vector3 BirdTargetPosition;

		[Token(Token = "0x4000575")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Vector3 birdTargetPositionMemory;

		[Token(Token = "0x4000576")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private float lagTimer;

		[Token(Token = "0x4000577")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private float preWeightFaloff;

		[Token(Token = "0x4000578")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private float[] baseWeights;

		[Token(Token = "0x4000579")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private float[] targetWeights;

		[Token(Token = "0x400057A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public bool UseEyes;

		[Token(Token = "0x400057B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8CEC54", Offset = "0x8CEC54")]
		public Transform EyesTarget;

		[Token(Token = "0x400057C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x8CEC8C", Offset = "0x8CEC8C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8CEC8C", Offset = "0x8CEC8C")]
		public Transform LeftEye;

		[Token(Token = "0x400057D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public bool InvertLeftEye;

		[Token(Token = "0x400057E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8CECDC", Offset = "0x8CECDC")]
		public Transform RightEye;

		[Token(Token = "0x400057F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public bool InvertRightEye;

		[Token(Token = "0x4000580")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8CED14", Offset = "0x8CED14")]
		public Transform HeadReference;

		[Token(Token = "0x4000581")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public Vector3 EyesOffsetRotation;

		[Token(Token = "0x4000582")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		public Vector3 LeftEyeOffsetRotation;

		[Token(Token = "0x4000583")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public Vector3 RightEyeOffsetRotation;

		[Token(Token = "0x4000584")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8CED4C", Offset = "0x8CED4C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8CED4C", Offset = "0x8CED4C")]
		public float EyesSpeed;

		[Token(Token = "0x4000585")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		[AttributeAttribute(Name = "FPD_PercentageAttribute", RVA = "0x8CEDA0", Offset = "0x8CEDA0")]
		public float EyesBlend;

		[Token(Token = "0x4000586")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8CEDEC", Offset = "0x8CEDEC")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8CEDEC", Offset = "0x8CEDEC")]
		public Vector2 EyesXRange;

		[Token(Token = "0x4000587")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		public Vector2 EyesYRange;

		[Token(Token = "0x4000588")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8CEE44", Offset = "0x8CEE44")]
		public bool EyesNoKeyframes;

		[Token(Token = "0x4000589")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE5")]
		public bool CustomEyesLogics;

		[Token(Token = "0x400058A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private float EyesOutOfRangeBlend;

		[Token(Token = "0x400058B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private Transform[] eyes;

		[Token(Token = "0x400058C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private Vector3[] eyeForwards;

		[Token(Token = "0x400058D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private Quaternion[] eyesInitLocalRotations;

		[Token(Token = "0x400058E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private Quaternion[] eyesLerpRotations;

		[Token(Token = "0x400058F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private float _eyesBlend;

		[Token(Token = "0x4000590")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x114")]
		private Vector3 headForward;

		[Token(Token = "0x4000591")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8CEE7C", Offset = "0x8CEE7C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8CEE7C", Offset = "0x8CEE7C")]
		public float NoddingTransitions;

		[Token(Token = "0x4000592")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x124")]
		public Vector3 NodAxis;

		[Token(Token = "0x4000593")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8CEED0", Offset = "0x8CEED0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8CEED0", Offset = "0x8CEED0")]
		public float BackBonesNod;

		[Token(Token = "0x4000594")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x134")]
		private float nodProgress;

		[Token(Token = "0x4000595")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		private float nodValue;

		[Token(Token = "0x4000596")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x13C")]
		private float nodPower;

		[Token(Token = "0x4000597")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		private float nodDuration;

		[Token(Token = "0x4000598")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x144")]
		private float smoothingTimer;

		[Token(Token = "0x4000599")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		private float smoothingPower;

		[Token(Token = "0x400059A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14C")]
		private float smoothingTime;

		[Token(Token = "0x400059B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		private float smoothingEffect;

		[Token(Token = "0x400059C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x154")]
		public int ParentalOffsetsV;

		[Token(Token = "0x400059D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		private Vector3 lookFreezeFocusPoint;

		[Token(Token = "0x400059E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x164")]
		private Vector3 smoothLookPosition;

		[Token(Token = "0x400059F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		private Vector3 _velo_smoothLookPosition;

		[Token(Token = "0x40005A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x17C")]
		private Vector3 finalLookPosition;

		[Token(Token = "0x40005A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
		private bool usingAxisCorrection;

		[Token(Token = "0x40005A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18C")]
		private Matrix4x4 axisCorrectionMatrix;

		[Token(Token = "0x40005A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1CC")]
		private float delta;

		[Token(Token = "0x40005A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8CEF24", Offset = "0x8CEF24")]
		public Transform ParentalReferenceBone;

		[Token(Token = "0x40005A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D8")]
		private Quaternion _parentalBackParentRot;

		[Token(Token = "0x40005A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E8")]
		private Vector2 _parentalAngles;

		[Token(Token = "0x40005A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F0")]
		private bool animatePhysicsWorking;

		[Token(Token = "0x40005A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F1")]
		private bool triggerAnimatePhysics;

		[Token(Token = "0x40005A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F4")]
		private int startAfterTPoseCounter;

		[Token(Token = "0x40005AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F8")]
		private Vector3 unclampedLookAngles;

		[Token(Token = "0x40005AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x204")]
		private Vector3 targetLookAngles;

		[Token(Token = "0x40005AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x210")]
		private Vector3 animatedLookAngles;

		[Token(Token = "0x40005AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x21C")]
		private Vector3 finalLookAngles;

		[Token(Token = "0x40005AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x228")]
		private Quaternion lastBaseRotation;

		[Token(Token = "0x40005AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x238")]
		private Vector3 _preLookAboveLookAngles;

		[Token(Token = "0x40005B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x244")]
		private Vector3 _velo_animatedLookAngles;

		[Token(Token = "0x40005B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x250")]
		private float _rememberSideLookHorizontalAngle;

		[Token(Token = "0x40005B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x254")]
		private Vector3 leadBoneInitLocalOffset;

		[Token(Token = "0x40005B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x260")]
		private EFHeadLookState previousState;

		[Token(Token = "0x40005B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x264")]
		private bool _stopLooking;

		[Token(Token = "0x40005B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x268")]
		private Transform activeLookTarget;

		[Token(Token = "0x40005B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x270")]
		private Vector3 activeLookPosition;

		[Token(Token = "0x40005B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x280")]
		private Transform preActiveLookTarget;

		[Token(Token = "0x40005B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x288")]
		private bool isLooking;

		[Token(Token = "0x40005B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x289")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8CEF5C", Offset = "0x8CEF5C")]
		public bool DestroyMomentTargetOnMaxDistance;

		[Token(Token = "0x40005BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28C")]
		private float whenAboveGoBackDuration;

		[Token(Token = "0x40005BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x290")]
		private float whenAboveGoBackTimer;

		[Token(Token = "0x40005BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x294")]
		private float _whenAboveGoBackVelo;

		[Token(Token = "0x40005BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x298")]
		private float _whenAboveGoBackVerticalVelo;

		[Token(Token = "0x40005BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x29C")]
		private Vector2 whenAboveGoBackAngles;

		[Token(Token = "0x40005BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2A4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8CEF94", Offset = "0x8CEF94")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8CEF94", Offset = "0x8CEF94")]
		public float OverrideRotations;

		[Token(Token = "0x40005C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2A8")]
		private bool overrideRefInitialized;

		[Token(Token = "0x40005C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2B0")]
		private UniRotateBone headOv;

		[Token(Token = "0x40005C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2B8")]
		private int lastClipHash;

		[Token(Token = "0x40005C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2BC")]
		private bool refreshReferencePose;

		[Token(Token = "0x40005C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C0")]
		private float monitorTransitionTime;

		[Token(Token = "0x40005C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C8")]
		private List<Quaternion> _monitorTransitionStart;

		[Token(Token = "0x40005C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2D0")]
		public int BackBonesCount;

		[Token(Token = "0x40005C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2D4")]
		public int _preBackBonesCount;

		[Token(Token = "0x40005C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2D8")]
		public List<LookBone> LookBones;

		[Token(Token = "0x40005C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2E0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8CEFE8", Offset = "0x8CEFE8")]
		private EFHeadLookState <LookState>k__BackingField;

		[Token(Token = "0x40005CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2E4")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8CEFF8", Offset = "0x8CEFF8")]
		public bool NoTargetHeadStops;

		[Token(Token = "0x40005CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2E8")]
		private Quaternion targetLookRotation;

		[Token(Token = "0x40005CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2F8")]
		protected bool initialized;

		[Token(Token = "0x40005CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2FC")]
		private float finalMotionWeight;

		[Token(Token = "0x40005CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x300")]
		private float animatedMotionWeight;

		[Token(Token = "0x40005CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x304")]
		private float _velo_animatedMotionWeight;

		[Token(Token = "0x40005D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x308")]
		private float changeTargetSmootherWeight;

		[Token(Token = "0x40005D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30C")]
		private float changeTargetSmootherBones;

		[Token(Token = "0x40005D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x310")]
		private Vector3 preLookDir;

		[Token(Token = "0x40005D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x31C")]
		public bool _editor_hideEyes;

		[Token(Token = "0x40005D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x320")]
		public string _editor_displayName;

		[Token(Token = "0x40005D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x328")]
		public EEditorLookCategory _Editor_Category;

		[Token(Token = "0x40005D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x330")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8CF030", Offset = "0x8CF030")]
		public Transform LeadBone;

		[Token(Token = "0x40005D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x338")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8CF068", Offset = "0x8CF068")]
		public Transform BaseTransform;

		[Token(Token = "0x40005D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x340")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8CF0A0", Offset = "0x8CF0A0")]
		public float FaloffValue;

		[Token(Token = "0x40005D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x344")]
		public float FaloffValueB;

		[Token(Token = "0x40005DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x348")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8CF0D8", Offset = "0x8CF0D8")]
		public bool BigAngleAutomation;

		[Token(Token = "0x40005DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x349")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8CF110", Offset = "0x8CF110")]
		public bool BigAngleAutomationCompensation;

		[Token(Token = "0x40005DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34A")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8CF148", Offset = "0x8CF148")]
		public bool AutoBackbonesWeights;

		[Token(Token = "0x40005DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34B")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8CF180", Offset = "0x8CF180")]
		public bool CurveSpread;

		[Token(Token = "0x40005DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x350")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8CF1B8", Offset = "0x8CF1B8")]
		public AnimationCurve BackBonesFalloff;

		[Token(Token = "0x40005DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x358")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x8CF1F0", Offset = "0x8CF1F0")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x8CF1F0", Offset = "0x8CF1F0")]
		public List<CompensationBone> CompensationBones;

		[Token(Token = "0x40005E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x360")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8CF264", Offset = "0x8CF264")]
		public float CompensationWeight;

		[Token(Token = "0x40005E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x364")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8CF27C", Offset = "0x8CF27C")]
		public float CompensationWeightB;

		[Token(Token = "0x40005E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x368")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8CF294", Offset = "0x8CF294")]
		public float CompensatePositions;

		[Token(Token = "0x40005E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x36C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8CF2AC", Offset = "0x8CF2AC")]
		public float CompensatePositionsB;

		[Token(Token = "0x40005E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x370")]
		private float targetCompensationWeight;

		[Token(Token = "0x40005E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x374")]
		private float targetCompensationPosWeight;

		[Token(Token = "0x40005E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x378")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8CF2C4", Offset = "0x8CF2C4")]
		public bool StartAfterTPose;

		[Token(Token = "0x40005E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x379")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8CF2FC", Offset = "0x8CF2FC")]
		public bool AnimatePhysics;

		[Token(Token = "0x40005E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x380")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8CF334", Offset = "0x8CF334")]
		public Renderer OptimizeWithMesh;

		[Token(Token = "0x40005E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x388")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8CF36C", Offset = "0x8CF36C")]
		public Transform ObjectToFollow;

		[Token(Token = "0x40005EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x390")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8CF3A4", Offset = "0x8CF3A4")]
		public Vector3 FollowOffset;

		[Token(Token = "0x40005EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x39C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8CF3DC", Offset = "0x8CF3DC")]
		public EFFollowMode FollowMode;

		[Token(Token = "0x40005EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3A0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8CF414", Offset = "0x8CF414")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8CF414", Offset = "0x8CF414")]
		public float RotationSpeed;

		[Token(Token = "0x40005ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3A4")]
		private bool instantRotation;

		[Token(Token = "0x40005EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3A8")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8CF468", Offset = "0x8CF468")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8CF468", Offset = "0x8CF468")]
		public float UltraSmoother;

		[Token(Token = "0x40005EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3AC")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x8CF4BC", Offset = "0x8CF4BC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8CF4BC", Offset = "0x8CF4BC")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8CF4BC", Offset = "0x8CF4BC")]
		public float StopLookingAbove;

		[Token(Token = "0x40005F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3B0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8CF540", Offset = "0x8CF540")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8CF540", Offset = "0x8CF540")]
		public float StopLookingAboveFactor;

		[Token(Token = "0x40005F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3B4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8CF598", Offset = "0x8CF598")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8CF598", Offset = "0x8CF598")]
		public float ChangeTargetSmoothing;

		[Token(Token = "0x40005F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3B8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8CF5EC", Offset = "0x8CF5EC")]
		public bool AdvancedFalloff;

		[Token(Token = "0x40005F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3BC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8CF624", Offset = "0x8CF624")]
		public float MaximumDistance;

		[Token(Token = "0x40005F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8CF65C", Offset = "0x8CF65C")]
		[AttributeAttribute(Name = "FPD_SuffixAttribute", RVA = "0x8CF65C", Offset = "0x8CF65C")]
		public float HoldRotateToOppositeUntil;

		[Token(Token = "0x40005F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C4")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8CF6D0", Offset = "0x8CF6D0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8CF6D0", Offset = "0x8CF6D0")]
		public float MaxOutDistanceFactor;

		[Token(Token = "0x40005F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8CF724", Offset = "0x8CF724")]
		public bool Distance2D;

		[Token(Token = "0x40005F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3CC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8CF75C", Offset = "0x8CF75C")]
		public Vector3 DistanceMeasurePoint;

		[Token(Token = "0x40005F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3D8")]
		[AttributeAttribute(Name = "FPD_SuffixAttribute", RVA = "0x8CF794", Offset = "0x8CF794")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8CF794", Offset = "0x8CF794")]
		public float LookWhenAbove;

		[Token(Token = "0x40005F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3DC")]
		private float animatedLookWhenAbove;

		[Token(Token = "0x40005FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3E0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8CF808", Offset = "0x8CF808")]
		[AttributeAttribute(Name = "FPD_SuffixAttribute", RVA = "0x8CF808", Offset = "0x8CF808")]
		public float LookWhenAboveVertical;

		[Token(Token = "0x40005FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3E4")]
		private float animatedLookWhenAboveVertical;

		[Token(Token = "0x40005FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3E8")]
		[AttributeAttribute(Name = "FPD_SuffixAttribute", RVA = "0x8CF87C", Offset = "0x8CF87C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8CF87C", Offset = "0x8CF87C")]
		public float WhenAboveGoBackAfter;

		[Token(Token = "0x40005FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3EC")]
		[AttributeAttribute(Name = "FPD_SuffixAttribute", RVA = "0x8CF8EC", Offset = "0x8CF8EC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8CF8EC", Offset = "0x8CF8EC")]
		public float WhenAboveGoBackAfterVertical;

		[Token(Token = "0x40005FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3F0")]
		[AttributeAttribute(Name = "FPD_SuffixAttribute", RVA = "0x8CF95C", Offset = "0x8CF95C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8CF95C", Offset = "0x8CF95C")]
		public float WhenAboveGoBackDuration;

		[Token(Token = "0x40005FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3F4")]
		[AttributeAttribute(Name = "FPD_SuffixAttribute", RVA = "0x8CF9D0", Offset = "0x8CF9D0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8CF9D0", Offset = "0x8CF9D0")]
		public float StartLookElasticRangeX;

		[Token(Token = "0x4000600")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3F8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8CFA44", Offset = "0x8CFA44")]
		[AttributeAttribute(Name = "FPD_SuffixAttribute", RVA = "0x8CFA44", Offset = "0x8CFA44")]
		public float StartLookElasticRangeY;

		[Token(Token = "0x4000601")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3FC")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x8CFAB8", Offset = "0x8CFAB8")]
		public Vector2 XRotationLimits;

		[Token(Token = "0x4000602")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x404")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8CFAF0", Offset = "0x8CFAF0")]
		[AttributeAttribute(Name = "FPD_SuffixAttribute", RVA = "0x8CFAF0", Offset = "0x8CFAF0")]
		public float XElasticRange;

		[Token(Token = "0x4000603")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x408")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8CFB64", Offset = "0x8CFB64")]
		public bool LimitHolder;

		[Token(Token = "0x4000604")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40C")]
		public Vector2 YRotationLimits;

		[Token(Token = "0x4000605")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x414")]
		[AttributeAttribute(Name = "FPD_SuffixAttribute", RVA = "0x8CFB9C", Offset = "0x8CFB9C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8CFB9C", Offset = "0x8CFB9C")]
		public float YElasticRange;

		[Token(Token = "0x4000606")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x418")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8CFC10", Offset = "0x8CFC10")]
		[AttributeAttribute(Name = "FPD_PercentageAttribute", RVA = "0x8CFC10", Offset = "0x8CFC10")]
		public float LookAnimatorAmount;

		[Token(Token = "0x4000607")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x41C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8CFC84", Offset = "0x8CFC84")]
		public Vector3 StartLookPointOffset;

		[Token(Token = "0x4000608")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x428")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8CFCBC", Offset = "0x8CFCBC")]
		public bool AnchorStartLookPoint;

		[Token(Token = "0x4000609")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x429")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8CFCF4", Offset = "0x8CFCF4")]
		public bool RefreshStartLookPoint;

		[Token(Token = "0x400060A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x42A")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8CFD2C", Offset = "0x8CFD2C")]
		public bool SyncWithAnimator;

		[Token(Token = "0x400060B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x42B")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8CFD64", Offset = "0x8CFD64")]
		public bool MonitorAnimator;

		[Token(Token = "0x400060C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x42C")]
		private Quaternion rootStaticRotation;

		[Token(Token = "0x400060D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x43C")]
		[AttributeAttribute(Name = "FPD_PercentageAttribute", RVA = "0x8CFD9C", Offset = "0x8CFD9C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8CFD9C", Offset = "0x8CFD9C")]
		public float WeightsMultiplier;

		[Token(Token = "0x400060E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x440")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8CFE10", Offset = "0x8CFE10")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8CFE10", Offset = "0x8CFE10")]
		public float MaxRotationSpeed;

		[Token(Token = "0x400060F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x444")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8CFE68", Offset = "0x8CFE68")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8CFE68", Offset = "0x8CFE68")]
		public float BaseRotationCompensation;

		[Token(Token = "0x4000610")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x448")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8CFEBC", Offset = "0x8CFEBC")]
		public bool DetectZeroKeyframes;

		[Token(Token = "0x4000611")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8CFEF4", Offset = "0x8CFEF4")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8CFEF4", Offset = "0x8CFEF4")]
		public float LookAtPositionSmoother;

		[Token(Token = "0x4000612")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x450")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8CFF48", Offset = "0x8CFF48")]
		public EFDeltaType DeltaType;

		[Token(Token = "0x4000613")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x454")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8CFF80", Offset = "0x8CFF80")]
		public float SimulationSpeed;

		[Token(Token = "0x4000614")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x458")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8CFFB8", Offset = "0x8CFFB8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8CFFB8", Offset = "0x8CFFB8")]
		public float OverrideHeadForPerfectLookDirection;

		[Token(Token = "0x4000615")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x45C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D000C", Offset = "0x8D000C")]
		public EFAxisFixOrder FixingPreset;

		[Token(Token = "0x4000616")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x460")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D0044", Offset = "0x8D0044")]
		public Vector3 ModelForwardAxis;

		[Token(Token = "0x4000617")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x46C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D007C", Offset = "0x8D007C")]
		public Vector3 ModelUpAxis;

		[Token(Token = "0x4000618")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x478")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D00B4", Offset = "0x8D00B4")]
		public Vector3 ManualFromAxis;

		[Token(Token = "0x4000619")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x484")]
		public Vector3 ManualToAxis;

		[Token(Token = "0x400061A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x490")]
		public Vector3 FromAuto;

		[Token(Token = "0x400061B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x49C")]
		public Vector3 OffsetAuto;

		[Token(Token = "0x400061C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4A8")]
		public Vector3 parentalReferenceLookForward;

		[Token(Token = "0x400061D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4B4")]
		public Vector3 parentalReferenceUp;

		[Token(Token = "0x400061E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C0")]
		public Vector3 DynamicReferenceUp;

		[Token(Token = "0x400061F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4CC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D00EC", Offset = "0x8D00EC")]
		public Vector3 RotationOffset;

		[Token(Token = "0x4000620")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4D8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D0124", Offset = "0x8D0124")]
		public Vector3 BackBonesAddOffset;

		[Token(Token = "0x4000621")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4E4")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D015C", Offset = "0x8D015C")]
		public Vector3 RotCorrectionMultiplier;

		[Token(Token = "0x4000622")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4F0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D0194", Offset = "0x8D0194")]
		public bool DebugRays;

		[Token(Token = "0x4000623")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4F4")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D01CC", Offset = "0x8D01CC")]
		public EFAnimationStyle AnimationStyle;

		[Token(Token = "0x4000624")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4F8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D0204", Offset = "0x8D0204")]
		public bool ConstantParentalAxisUpdate;

		[Token(Token = "0x4000625")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4F9")]
		private bool updateLookAnimator;

		[Token(Token = "0x4000626")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4FA")]
		private bool wasUpdating;

		[Token(Token = "0x17000096")]
		public Transform MomentLookTransform
		{
			[Token(Token = "0x60004CF")]
			[Address(RVA = "0x2038FB4", Offset = "0x2038FB4", VA = "0x2038FB4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8D26EC", Offset = "0x8D26EC")]
			get
			{
				return null;
			}
			[Token(Token = "0x60004D0")]
			[Address(RVA = "0x2038FBC", Offset = "0x2038FBC", VA = "0x2038FBC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8D26FC", Offset = "0x8D26FC")]
			private set
			{
			}
		}

		[Token(Token = "0x17000097")]
		public EFHeadLookState LookState
		{
			[Token(Token = "0x600050C")]
			[Address(RVA = "0x204130C", Offset = "0x204130C", VA = "0x204130C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8D28C4", Offset = "0x8D28C4")]
			get
			{
				return default(EFHeadLookState);
			}
			[Token(Token = "0x600050D")]
			[Address(RVA = "0x2041314", Offset = "0x2041314", VA = "0x2041314")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8D28D4", Offset = "0x8D28D4")]
			protected set
			{
			}
		}

		[Token(Token = "0x17000098")]
		public string EditorIconPath
		{
			[Token(Token = "0x6000516")]
			[Address(RVA = "0x20420B4", Offset = "0x20420B4", VA = "0x20420B4", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000099")]
		public bool UseBoneOffsetRotation
		{
			[Token(Token = "0x600051C")]
			[Address(RVA = "0x204213C", Offset = "0x204213C", VA = "0x204213C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700009A")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x8D3434", Offset = "0x8D3434")]
		public float BlendToOriginal
		{
			[Token(Token = "0x600051D")]
			[Address(RVA = "0x2042144", Offset = "0x2042144", VA = "0x2042144")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600051E")]
			[Address(RVA = "0x2042154", Offset = "0x2042154", VA = "0x2042154")]
			set
			{
			}
		}

		[Token(Token = "0x1700009B")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x8D346C", Offset = "0x8D346C")]
		public Vector3 LookReferenceOffset
		{
			[Token(Token = "0x600051F")]
			[Address(RVA = "0x2042164", Offset = "0x2042164", VA = "0x2042164")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000520")]
			[Address(RVA = "0x2042174", Offset = "0x2042174", VA = "0x2042174")]
			set
			{
			}
		}

		[Token(Token = "0x1700009C")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x8D34A4", Offset = "0x8D34A4")]
		public bool AnchorReferencePoint
		{
			[Token(Token = "0x6000521")]
			[Address(RVA = "0x2042184", Offset = "0x2042184", VA = "0x2042184")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000522")]
			[Address(RVA = "0x204218C", Offset = "0x204218C", VA = "0x204218C")]
			set
			{
			}
		}

		[Token(Token = "0x1700009D")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x8D34DC", Offset = "0x8D34DC")]
		public bool RefreshAnchor
		{
			[Token(Token = "0x6000523")]
			[Address(RVA = "0x2042198", Offset = "0x2042198", VA = "0x2042198")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000524")]
			[Address(RVA = "0x20421A0", Offset = "0x20421A0", VA = "0x20421A0")]
			set
			{
			}
		}

		[Token(Token = "0x1700009E")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x8D3514", Offset = "0x8D3514")]
		public float MinHeadLookAngle
		{
			[Token(Token = "0x6000525")]
			[Address(RVA = "0x20421AC", Offset = "0x20421AC", VA = "0x20421AC")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000526")]
			[Address(RVA = "0x20421B4", Offset = "0x20421B4", VA = "0x20421B4")]
			set
			{
			}
		}

		[Token(Token = "0x1700009F")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x8D354C", Offset = "0x8D354C")]
		public float MaxRotationDiffrence
		{
			[Token(Token = "0x6000527")]
			[Address(RVA = "0x20421BC", Offset = "0x20421BC", VA = "0x20421BC")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000528")]
			[Address(RVA = "0x20421C4", Offset = "0x20421C4", VA = "0x20421C4")]
			set
			{
			}
		}

		[Token(Token = "0x170000A0")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x8D3584", Offset = "0x8D3584")]
		public bool AnimateWithSource
		{
			[Token(Token = "0x6000529")]
			[Address(RVA = "0x20421CC", Offset = "0x20421CC", VA = "0x20421CC")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600052A")]
			[Address(RVA = "0x20421D4", Offset = "0x20421D4", VA = "0x20421D4")]
			set
			{
			}
		}

		[Token(Token = "0x60004C6")]
		[Address(RVA = "0x20388A4", Offset = "0x20388A4", VA = "0x20388A4")]
		public void SwitchLooking([Optional] bool? enableLooking, float transitionTime = 0.2f, [Optional] Action callback)
		{
		}

		[Token(Token = "0x60004C7")]
		[Address(RVA = "0x2038A18", Offset = "0x2038A18", VA = "0x2038A18")]
		public void SwitchLooking(bool enable = true)
		{
		}

		[Token(Token = "0x60004C8")]
		[Address(RVA = "0x2038A90", Offset = "0x2038A90", VA = "0x2038A90")]
		public void SetLookTarget(Transform transform)
		{
		}

		[Token(Token = "0x60004C9")]
		[Address(RVA = "0x2038AC4", Offset = "0x2038AC4", VA = "0x2038AC4")]
		public void SetLookPosition(Vector3 targetPosition)
		{
		}

		[Token(Token = "0x60004CA")]
		[Address(RVA = "0x2038ADC", Offset = "0x2038ADC", VA = "0x2038ADC")]
		public Vector2 GetUnclampedLookAngles()
		{
			return default(Vector2);
		}

		[Token(Token = "0x60004CB")]
		[Address(RVA = "0x2038AE8", Offset = "0x2038AE8", VA = "0x2038AE8")]
		public Vector2 GetLookAngles()
		{
			return default(Vector2);
		}

		[Token(Token = "0x60004CC")]
		[Address(RVA = "0x2038AF4", Offset = "0x2038AF4", VA = "0x2038AF4")]
		public Vector2 GetTargetLookAngles()
		{
			return default(Vector2);
		}

		[Token(Token = "0x60004CD")]
		[Address(RVA = "0x2038B00", Offset = "0x2038B00", VA = "0x2038B00")]
		public EFHeadLookState GetCurrentLookState()
		{
			return default(EFHeadLookState);
		}

		[Token(Token = "0x60004CE")]
		[Address(RVA = "0x2038B08", Offset = "0x2038B08", VA = "0x2038B08")]
		public Vector2 ComputeAnglesTowards(Vector3 worldPosition)
		{
			return default(Vector2);
		}

		[Token(Token = "0x60004D1")]
		[Address(RVA = "0x2038FC4", Offset = "0x2038FC4", VA = "0x2038FC4")]
		public GameObject SetMomentLookTarget([Optional] Transform parent, [Optional] Vector3? position, [Optional][MetadataOffset(Offset = "0x428BA6")] float? destroyTimer, bool worldPosition = false)
		{
			return null;
		}

		[Token(Token = "0x60004D2")]
		[Address(RVA = "0x20396B0", Offset = "0x20396B0", VA = "0x20396B0")]
		public void SetMomentLookTransform(Transform transform, float timeToLeft = 0f)
		{
		}

		[Token(Token = "0x60004D3")]
		[Address(RVA = "0x20397C8", Offset = "0x20397C8", VA = "0x20397C8")]
		public void ForceDestroyMomentTarget()
		{
		}

		[Token(Token = "0x60004D4")]
		[Address(RVA = "0x20398BC", Offset = "0x20398BC", VA = "0x20398BC")]
		private void InitBirdMode()
		{
		}

		[Token(Token = "0x60004D5")]
		[Address(RVA = "0x2039B6C", Offset = "0x2039B6C", VA = "0x2039B6C")]
		private void CalculateBirdMode()
		{
		}

		[Token(Token = "0x60004D6")]
		[Address(RVA = "0x203A104", Offset = "0x203A104", VA = "0x203A104")]
		public void SetAutoWeightsDefault()
		{
		}

		[Token(Token = "0x60004D7")]
		[Address(RVA = "0x203A5EC", Offset = "0x203A5EC", VA = "0x203A5EC")]
		public void UpdateAutomationWeights()
		{
		}

		[Token(Token = "0x60004D8")]
		[Address(RVA = "0x203A750", Offset = "0x203A750", VA = "0x203A750")]
		public void RefreshBoneMotionWeights()
		{
		}

		[Token(Token = "0x60004D9")]
		[Address(RVA = "0x203A294", Offset = "0x203A294", VA = "0x203A294")]
		public float[] CalculateRotationWeights(float falloff)
		{
			return null;
		}

		[Token(Token = "0x60004DA")]
		[Address(RVA = "0x203A848", Offset = "0x203A848", VA = "0x203A848")]
		private void CalculateWeights(float[] weights)
		{
		}

		[Token(Token = "0x60004DB")]
		[Address(RVA = "0x203A8E4", Offset = "0x203A8E4", VA = "0x203A8E4")]
		public Transform GetHeadReference()
		{
			return null;
		}

		[Token(Token = "0x60004DC")]
		[Address(RVA = "0x203A968", Offset = "0x203A968", VA = "0x203A968")]
		public Transform GetEyesTarget()
		{
			return null;
		}

		[Token(Token = "0x60004DD")]
		[Address(RVA = "0x203AB18", Offset = "0x203AB18", VA = "0x203AB18")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x8D270C", Offset = "0x8D270C")]
		public Transform GetCurrentTarget()
		{
			return null;
		}

		[Token(Token = "0x60004DE")]
		[Address(RVA = "0x203AB1C", Offset = "0x203AB1C", VA = "0x203AB1C")]
		public Vector3 GetEyesTargetPosition()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60004DF")]
		[Address(RVA = "0x203ABB0", Offset = "0x203ABB0", VA = "0x203ABB0")]
		private void InitEyesModule()
		{
		}

		[Token(Token = "0x60004E0")]
		[Address(RVA = "0x203B1EC", Offset = "0x203B1EC", VA = "0x203B1EC")]
		private void UpdateEyesLogics()
		{
		}

		[Token(Token = "0x60004E1")]
		[Address(RVA = "0x203BB88", Offset = "0x203BB88", VA = "0x203BB88")]
		private void NoddingChangeTargetCalculations(float angleAmount)
		{
		}

		[Token(Token = "0x60004E2")]
		[Address(RVA = "0x203BCAC", Offset = "0x203BCAC", VA = "0x203BCAC")]
		private void NoddingCalculations()
		{
		}

		[Token(Token = "0x60004E3")]
		[Address(RVA = "0x203BD2C", Offset = "0x203BD2C", VA = "0x203BD2C")]
		public void SetRotationSmoothing(float smoothingDuration = 0.5f, float smoothingPower = 2f)
		{
		}

		[Token(Token = "0x60004E4")]
		[Address(RVA = "0x203BD44", Offset = "0x203BD44", VA = "0x203BD44")]
		private void UpdateSmoothing()
		{
		}

		[Token(Token = "0x60004E5")]
		[Address(RVA = "0x203BD84", Offset = "0x203BD84", VA = "0x203BD84")]
		private void AnimateBonesUnsynced(Quaternion diffOnMain, Quaternion backTarget, float d)
		{
		}

		[Token(Token = "0x60004E6")]
		[Address(RVA = "0x203C2A8", Offset = "0x203C2A8", VA = "0x203C2A8")]
		private void AnimateBonesSynced(Quaternion diffOnMain, Quaternion backTarget, float d)
		{
		}

		[Token(Token = "0x60004E7")]
		[Address(RVA = "0x203C71C", Offset = "0x203C71C", VA = "0x203C71C")]
		private void AnimateBonesParental(float d)
		{
		}

		[Token(Token = "0x60004E8")]
		[Address(RVA = "0x203D594", Offset = "0x203D594", VA = "0x203D594")]
		private void CalculateLookAnimation()
		{
		}

		[Token(Token = "0x60004E9")]
		[Address(RVA = "0x203EAAC", Offset = "0x203EAAC", VA = "0x203EAAC")]
		private void SetTargetBonesRotations()
		{
		}

		[Token(Token = "0x60004EA")]
		[Address(RVA = "0x203E780", Offset = "0x203E780", VA = "0x203E780")]
		private Quaternion LookRotationParental(Vector3 direction)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60004EB")]
		[Address(RVA = "0x203EE5C", Offset = "0x203EE5C", VA = "0x203EE5C")]
		private Quaternion ParentalRotationMaths(Vector3 referenceRightDir, float xAngle, float yAngle)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60004EC")]
		[Address(RVA = "0x203F080", Offset = "0x203F080", VA = "0x203F080")]
		private void UpdateCorrectionMatrix()
		{
		}

		[Token(Token = "0x60004ED")]
		[Address(RVA = "0x203F250", Offset = "0x203F250", VA = "0x203F250")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x8D2744", Offset = "0x8D2744")]
		private IEnumerator AnimatePhysicsClock()
		{
			return null;
		}

		[Token(Token = "0x60004EE")]
		[Address(RVA = "0x2038968", Offset = "0x2038968", VA = "0x2038968")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x8D27A4", Offset = "0x8D27A4")]
		private IEnumerator SwitchLookingTransition(float transitionTime, bool enableAnimation, [Optional] Action callback)
		{
			return null;
		}

		[Token(Token = "0x60004EF")]
		[Address(RVA = "0x2039724", Offset = "0x2039724", VA = "0x2039724")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x8D2804", Offset = "0x8D2804")]
		private IEnumerator CResetMomentLookTransform(Transform transform, float time)
		{
			return null;
		}

		[Token(Token = "0x60004F0")]
		[Address(RVA = "0x203DCFC", Offset = "0x203DCFC", VA = "0x203DCFC")]
		public Vector2 LimitAnglesCalculations(Vector2 angles)
		{
			return default(Vector2);
		}

		[Token(Token = "0x60004F1")]
		[Address(RVA = "0x203E0C8", Offset = "0x203E0C8", VA = "0x203E0C8")]
		public Vector2 AnimateAnglesTowards(Vector2 angles)
		{
			return default(Vector2);
		}

		[Token(Token = "0x60004F2")]
		[Address(RVA = "0x203F33C", Offset = "0x203F33C", VA = "0x203F33C")]
		public Vector3 GetDistanceMeasurePosition()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60004F3")]
		[Address(RVA = "0x2038CA0", Offset = "0x2038CA0", VA = "0x2038CA0")]
		public Vector3 GetLookStartMeasurePosition()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60004F4")]
		[Address(RVA = "0x203F3B4", Offset = "0x203F3B4", VA = "0x203F3B4")]
		public void RefreshLookStartPositionAnchor()
		{
		}

		[Token(Token = "0x60004F5")]
		[Address(RVA = "0x203F464", Offset = "0x203F464", VA = "0x203F464")]
		private float GetDistanceMeasure(Vector3 targetPosition)
		{
			return default(float);
		}

		[Token(Token = "0x60004F6")]
		[Address(RVA = "0x203F4D8", Offset = "0x203F4D8", VA = "0x203F4D8")]
		private void UpdateLookAnimatorAmountWeight()
		{
		}

		[Token(Token = "0x60004F7")]
		[Address(RVA = "0x203F610", Offset = "0x203F610", VA = "0x203F610")]
		private void EndUpdate()
		{
		}

		[Token(Token = "0x60004F8")]
		[Address(RVA = "0x203DAE8", Offset = "0x203DAE8", VA = "0x203DAE8")]
		private void LookPositionUpdate()
		{
		}

		[Token(Token = "0x60004F9")]
		[Address(RVA = "0x203F770", Offset = "0x203F770", VA = "0x203F770")]
		private void TargetingUpdate()
		{
		}

		[Token(Token = "0x60004FA")]
		[Address(RVA = "0x2039900", Offset = "0x2039900", VA = "0x2039900")]
		public Vector3 GetLookAtPosition()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60004FB")]
		[Address(RVA = "0x203A9F0", Offset = "0x203A9F0", VA = "0x203A9F0")]
		public Transform GetLookAtTransform()
		{
			return null;
		}

		[Token(Token = "0x60004FC")]
		[Address(RVA = "0x203F838", Offset = "0x203F838", VA = "0x203F838")]
		public Vector3 GetForwardPosition()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60004FD")]
		[Address(RVA = "0x2039408", Offset = "0x2039408", VA = "0x2039408")]
		protected void TargetChangedMeasures()
		{
		}

		[Token(Token = "0x60004FE")]
		[Address(RVA = "0x203F8AC", Offset = "0x203F8AC", VA = "0x203F8AC")]
		private void MaxDistanceCalculations()
		{
		}

		[Token(Token = "0x60004FF")]
		[Address(RVA = "0x203F994", Offset = "0x203F994", VA = "0x203F994", Slot = "6")]
		protected virtual void OnTargetChanged()
		{
		}

		[Token(Token = "0x6000500")]
		[Address(RVA = "0x203F998", Offset = "0x203F998", VA = "0x203F998", Slot = "7")]
		protected virtual void OnRangeStateChanged()
		{
		}

		[Token(Token = "0x6000501")]
		[Address(RVA = "0x203F99C", Offset = "0x203F99C", VA = "0x203F99C")]
		private void BeginStateCheck()
		{
		}

		[Token(Token = "0x6000502")]
		[Address(RVA = "0x203DB78", Offset = "0x203DB78", VA = "0x203DB78")]
		private void LookWhenAboveGoBackCalculations()
		{
		}

		[Token(Token = "0x6000503")]
		[Address(RVA = "0x203FA44", Offset = "0x203FA44", VA = "0x203FA44")]
		private void PreCalibrateBones()
		{
		}

		[Token(Token = "0x6000504")]
		[Address(RVA = "0x203FB28", Offset = "0x203FB28", VA = "0x203FB28")]
		private void CalibrateBones()
		{
		}

		[Token(Token = "0x6000505")]
		[Address(RVA = "0x2040248", Offset = "0x2040248", VA = "0x2040248")]
		private void ChangeBonesRotations()
		{
		}

		[Token(Token = "0x6000506")]
		[Address(RVA = "0x20405C8", Offset = "0x20405C8", VA = "0x20405C8")]
		private void CheckOverrideReference()
		{
		}

		[Token(Token = "0x6000507")]
		[Address(RVA = "0x20407F4", Offset = "0x20407F4", VA = "0x20407F4")]
		private void PostAnimatingTweaks()
		{
		}

		[Token(Token = "0x6000508")]
		[Address(RVA = "0x2040A3C", Offset = "0x2040A3C", VA = "0x2040A3C")]
		private void ResetBones(bool onlyIfNull = false)
		{
		}

		[Token(Token = "0x6000509")]
		[Address(RVA = "0x2040D20", Offset = "0x2040D20", VA = "0x2040D20")]
		internal void RefreshLookBones()
		{
		}

		[Token(Token = "0x600050A")]
		[Address(RVA = "0x2040160", Offset = "0x2040160", VA = "0x2040160")]
		private void RefreshReferencePose()
		{
		}

		[Token(Token = "0x600050B")]
		[Address(RVA = "0x2041294", Offset = "0x2041294", VA = "0x2041294")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x8D2864", Offset = "0x8D2864")]
		private IEnumerator CRefreshReferencePose()
		{
			return null;
		}

		[Token(Token = "0x600050E")]
		[Address(RVA = "0x204131C", Offset = "0x204131C", VA = "0x204131C")]
		public void InitializeBaseVariables()
		{
		}

		[Token(Token = "0x600050F")]
		[Address(RVA = "0x2041990", Offset = "0x2041990", VA = "0x2041990")]
		public void FindBaseTransform()
		{
		}

		[Token(Token = "0x6000510")]
		[Address(RVA = "0x2041B50", Offset = "0x2041B50", VA = "0x2041B50")]
		public Vector3 TryFindHeadPositionInTarget(Transform other)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000511")]
		[Address(RVA = "0x203F3B0", Offset = "0x203F3B0", VA = "0x203F3B0")]
		private void _LOG_NoRefs()
		{
		}

		[Token(Token = "0x6000512")]
		[Address(RVA = "0x2041F24", Offset = "0x2041F24", VA = "0x2041F24")]
		private void _Debug_Rays()
		{
		}

		[Token(Token = "0x6000513")]
		[Address(RVA = "0x2038F20", Offset = "0x2038F20", VA = "0x2038F20")]
		private Vector3 WrapVector(Vector3 v)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000514")]
		[Address(RVA = "0x203E630", Offset = "0x203E630", VA = "0x203E630")]
		private Vector3 ConvertFlippedAxes(Vector3 rotations)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000515")]
		[Address(RVA = "0x203ED28", Offset = "0x203ED28", VA = "0x203ED28")]
		public static float AngleAroundAxis(Vector3 firstDirection, Vector3 secondDirection, Vector3 axis)
		{
			return default(float);
		}

		[Token(Token = "0x6000517")]
		[Address(RVA = "0x2042138", Offset = "0x2042138", VA = "0x2042138", Slot = "4")]
		public void OnDrop(PointerEventData data)
		{
		}

		[Token(Token = "0x6000518")]
		[Address(RVA = "0x203F2C8", Offset = "0x203F2C8", VA = "0x203F2C8")]
		private float GetClampedAngle(float current, float limit, float elastic, float sign = 1f)
		{
			return default(float);
		}

		[Token(Token = "0x6000519")]
		[Address(RVA = "0x20415AC", Offset = "0x20415AC", VA = "0x20415AC")]
		private void ComputeBonesRotationsFixVariables()
		{
		}

		[Token(Token = "0x600051A")]
		[Address(RVA = "0x203FFC0", Offset = "0x203FFC0", VA = "0x203FFC0")]
		private void RefreshParentalLookReferenceAxis()
		{
		}

		[Token(Token = "0x600051B")]
		[Address(RVA = "0x203F67C", Offset = "0x203F67C", VA = "0x203F67C")]
		public Vector3 GetCurrentHeadForwardDirection()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600052B")]
		[Address(RVA = "0x20421E0", Offset = "0x20421E0", VA = "0x20421E0")]
		private void Reset()
		{
		}

		[Token(Token = "0x600052C")]
		[Address(RVA = "0x20421E4", Offset = "0x20421E4", VA = "0x20421E4")]
		private void Awake()
		{
		}

		[Token(Token = "0x600052D")]
		[Address(RVA = "0x20421E8", Offset = "0x20421E8", VA = "0x20421E8", Slot = "8")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x600052E")]
		[Address(RVA = "0x2042200", Offset = "0x2042200", VA = "0x2042200")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600052F")]
		[Address(RVA = "0x2042208", Offset = "0x2042208", VA = "0x2042208")]
		public void ResetLook()
		{
		}

		[Token(Token = "0x6000530")]
		[Address(RVA = "0x204223C", Offset = "0x204223C", VA = "0x204223C")]
		private void Update()
		{
		}

		[Token(Token = "0x6000531")]
		[Address(RVA = "0x20423C0", Offset = "0x20423C0", VA = "0x20423C0")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000532")]
		[Address(RVA = "0x20423D8", Offset = "0x20423D8", VA = "0x20423D8", Slot = "9")]
		public virtual void LateUpdate()
		{
		}

		[Token(Token = "0x6000533")]
		[Address(RVA = "0x20424AC", Offset = "0x20424AC", VA = "0x20424AC")]
		public FLookAnimator()
		{
		}
	}
	[Token(Token = "0x20000C9")]
	public class SM_SwitchLookAnimator : StateMachineBehaviour
	{
		[Token(Token = "0x4000676")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D023C", Offset = "0x8D023C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8D023C", Offset = "0x8D023C")]
		public float EnableBackAfter;

		[Token(Token = "0x4000677")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float TransitionDuration;

		[Token(Token = "0x4000678")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private bool enableBackTriggered;

		[Token(Token = "0x6000557")]
		[Address(RVA = "0x1A9D7B4", Offset = "0x1A9D7B4", VA = "0x1A9D7B4", Slot = "4")]
		public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
		{
		}

		[Token(Token = "0x6000558")]
		[Address(RVA = "0x1A9D8C4", Offset = "0x1A9D8C4", VA = "0x1A9D8C4", Slot = "5")]
		public override void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
		{
		}

		[Token(Token = "0x6000559")]
		[Address(RVA = "0x1A9D96C", Offset = "0x1A9D96C", VA = "0x1A9D96C", Slot = "6")]
		public override void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
		{
		}

		[Token(Token = "0x600055A")]
		[Address(RVA = "0x1A9D80C", Offset = "0x1A9D80C", VA = "0x1A9D80C")]
		private void SwitchLook(Animator animator, bool enable)
		{
		}

		[Token(Token = "0x600055B")]
		[Address(RVA = "0x1A9D9D8", Offset = "0x1A9D9D8", VA = "0x1A9D9D8")]
		public SM_SwitchLookAnimator()
		{
		}
	}
}
namespace FIMSpace.BonesStimulation
{
	[Token(Token = "0x20000CA")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x8CB37C", Offset = "0x8CB37C")]
	[AttributeAttribute(Name = "DefaultExecutionOrder", RVA = "0x8CB37C", Offset = "0x8CB37C")]
	public class BonesStimulator : MonoBehaviour, IDropHandler, IEventSystemHandler, IFHierarchyIcon
	{
		[Serializable]
		[Token(Token = "0x20000CB")]
		public class Bone
		{
			[Token(Token = "0x40006C7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8D0B04", Offset = "0x8D0B04")]
			private FElasticTransform <MotionMuscle>k__BackingField;

			[Token(Token = "0x40006C8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8D0B14", Offset = "0x8D0B14")]
			private FMuscle_Quaternion <RotationMuscle>k__BackingField;

			[Token(Token = "0x40006C9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8D0B24", Offset = "0x8D0B24")]
			private FMuscle_Eulers <EulerAnglesMuscle>k__BackingField;

			[Token(Token = "0x40006CA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public float PosMul;

			[Token(Token = "0x40006CB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public float RotMul;

			[Token(Token = "0x40006CC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public float ScaleMul;

			[Token(Token = "0x40006CD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public float[] randomFloats;

			[Token(Token = "0x40006CE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public int[] randomInts;

			[Token(Token = "0x40006CF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public Transform transform;

			[Token(Token = "0x40006D0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8D0B34", Offset = "0x8D0B34")]
			private Bone <Child>k__BackingField;

			[Token(Token = "0x40006D1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8D0B44", Offset = "0x8D0B44")]
			private Bone <Parent>k__BackingField;

			[Token(Token = "0x40006D2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			public float Evaluation;

			[Token(Token = "0x40006D3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			public Vector3 initLocalPos;

			[Token(Token = "0x40006D4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			public Quaternion initLocalRot;

			[Token(Token = "0x40006D5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			public Vector3 initLocalScale;

			[Token(Token = "0x40006D6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
			public Vector3 srcAnimatorLocPosition;

			[Token(Token = "0x40006D7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			public Vector3 srcAnimatorPosition;

			[Token(Token = "0x40006D8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
			public Quaternion srcAnimatorLocRotation;

			[Token(Token = "0x40006D9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
			public Quaternion srcAnimatorRotation;

			[Token(Token = "0x40006DA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
			public bool EnableCollisions;

			[Token(Token = "0x40006DB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
			public float CollisionRadius;

			[Token(Token = "0x40006DC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
			public Vector3 CollisionHelperVector;

			[Token(Token = "0x170000AF")]
			public FElasticTransform MotionMuscle
			{
				[Token(Token = "0x600058A")]
				[Address(RVA = "0x117AE68", Offset = "0x117AE68", VA = "0x117AE68")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8D2AA4", Offset = "0x8D2AA4")]
				get
				{
					return null;
				}
				[Token(Token = "0x600058B")]
				[Address(RVA = "0x117AE70", Offset = "0x117AE70", VA = "0x117AE70")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8D2AB4", Offset = "0x8D2AB4")]
				private set
				{
				}
			}

			[Token(Token = "0x170000B0")]
			public FMuscle_Quaternion RotationMuscle
			{
				[Token(Token = "0x600058C")]
				[Address(RVA = "0x117AE78", Offset = "0x117AE78", VA = "0x117AE78")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8D2AC4", Offset = "0x8D2AC4")]
				get
				{
					return null;
				}
				[Token(Token = "0x600058D")]
				[Address(RVA = "0x117AE80", Offset = "0x117AE80", VA = "0x117AE80")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8D2AD4", Offset = "0x8D2AD4")]
				private set
				{
				}
			}

			[Token(Token = "0x170000B1")]
			public FMuscle_Eulers EulerAnglesMuscle
			{
				[Token(Token = "0x600058E")]
				[Address(RVA = "0x117AE88", Offset = "0x117AE88", VA = "0x117AE88")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8D2AE4", Offset = "0x8D2AE4")]
				get
				{
					return null;
				}
				[Token(Token = "0x600058F")]
				[Address(RVA = "0x117AE90", Offset = "0x117AE90", VA = "0x117AE90")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8D2AF4", Offset = "0x8D2AF4")]
				private set
				{
				}
			}

			[Token(Token = "0x170000B2")]
			public Bone Child
			{
				[Token(Token = "0x6000593")]
				[Address(RVA = "0x117B268", Offset = "0x117B268", VA = "0x117B268")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8D2B04", Offset = "0x8D2B04")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000594")]
				[Address(RVA = "0x117B270", Offset = "0x117B270", VA = "0x117B270")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8D2B14", Offset = "0x8D2B14")]
				private set
				{
				}
			}

			[Token(Token = "0x170000B3")]
			public Bone Parent
			{
				[Token(Token = "0x6000595")]
				[Address(RVA = "0x117B278", Offset = "0x117B278", VA = "0x117B278")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8D2B24", Offset = "0x8D2B24")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000596")]
				[Address(RVA = "0x117B280", Offset = "0x117B280", VA = "0x117B280")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8D2B34", Offset = "0x8D2B34")]
				private set
				{
				}
			}

			[Token(Token = "0x6000590")]
			[Address(RVA = "0x117AE98", Offset = "0x117AE98", VA = "0x117AE98")]
			public void InitMuscles()
			{
			}

			[Token(Token = "0x6000591")]
			[Address(RVA = "0x117B074", Offset = "0x117B074", VA = "0x117B074")]
			public void CaptureAnimation()
			{
			}

			[Token(Token = "0x6000592")]
			[Address(RVA = "0x117B12C", Offset = "0x117B12C", VA = "0x117B12C")]
			public void VibrateInitialize()
			{
			}

			[Token(Token = "0x6000597")]
			[Address(RVA = "0x117B288", Offset = "0x117B288", VA = "0x117B288")]
			public float GetCollisionRadiusScaled()
			{
				return default(float);
			}

			[Token(Token = "0x6000598")]
			[Address(RVA = "0x117B2C0", Offset = "0x117B2C0", VA = "0x117B2C0")]
			public void SetChild(Bone child)
			{
			}

			[Token(Token = "0x6000599")]
			[Address(RVA = "0x117B304", Offset = "0x117B304", VA = "0x117B304")]
			public void SetParent(Bone parent)
			{
			}

			[Token(Token = "0x600059A")]
			[Address(RVA = "0x117B348", Offset = "0x117B348", VA = "0x117B348")]
			public void UpdateInitialCoords()
			{
			}

			[Token(Token = "0x600059B")]
			[Address(RVA = "0x117B408", Offset = "0x117B408", VA = "0x117B408")]
			public void PreCalibrate()
			{
			}

			[Token(Token = "0x600059C")]
			[Address(RVA = "0x117B4B8", Offset = "0x117B4B8", VA = "0x117B4B8")]
			public void PreCalibrateWithScale()
			{
			}

			[Token(Token = "0x600059D")]
			[Address(RVA = "0x117B580", Offset = "0x117B580", VA = "0x117B580")]
			public Bone()
			{
			}
		}

		[Token(Token = "0x20000CC")]
		public enum EStimulationMode
		{
			[Token(Token = "0x40006DE")]
			Muscles,
			[Token(Token = "0x40006DF")]
			Vibrate,
			[Token(Token = "0x40006E0")]
			Squeezing,
			[Token(Token = "0x40006E1")]
			Collisions
		}

		[Token(Token = "0x20000CD")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8CB3CC", Offset = "0x8CB3CC")]
		private sealed class <>c__DisplayClass34_0
		{
			[Token(Token = "0x40006E2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Collider col;

			[Token(Token = "0x600059E")]
			[Address(RVA = "0x117AD70", Offset = "0x117AD70", VA = "0x117AD70")]
			public <>c__DisplayClass34_0()
			{
			}

			[Token(Token = "0x600059F")]
			[Address(RVA = "0x117AD78", Offset = "0x117AD78", VA = "0x117AD78")]
			internal bool <CheckForColliderDuplicates>b__0(Collider o)
			{
				return default(bool);
			}

			[Token(Token = "0x60005A0")]
			[Address(RVA = "0x117ADF0", Offset = "0x117ADF0", VA = "0x117ADF0")]
			internal bool <CheckForColliderDuplicates>b__1(Collider o)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x4000679")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D0290", Offset = "0x8D0290")]
		[AttributeAttribute(Name = "FPD_SuffixAttribute", RVA = "0x8D0290", Offset = "0x8D0290")]
		public float StimulatorAmount;

		[Token(Token = "0x400067A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public List<Bone> Bones;

		[Token(Token = "0x400067B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D0300", Offset = "0x8D0300")]
		public Transform CompensationTransform;

		[Token(Token = "0x400067C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D0338", Offset = "0x8D0338")]
		public bool AnimatePhysics;

		[Token(Token = "0x400067D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D0370", Offset = "0x8D0370")]
		public Renderer HideWith;

		[Token(Token = "0x400067E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D03A8", Offset = "0x8D03A8")]
		public float FadeOutDistance;

		[Token(Token = "0x400067F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D03E0", Offset = "0x8D03E0")]
		public Transform DistanceFrom;

		[Token(Token = "0x4000680")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D0418", Offset = "0x8D0418")]
		public bool AutoHelperOffset;

		[Token(Token = "0x4000681")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public Vector3 HelperOffset;

		[Token(Token = "0x4000682")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[HideInInspector]
		public string _editor_Title;

		[Token(Token = "0x4000683")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[HideInInspector]
		public bool _editor_DrawSetup;

		[Token(Token = "0x4000684")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x69")]
		[HideInInspector]
		public bool _editor_DrawTweaking;

		[Token(Token = "0x4000685")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[HideInInspector]
		public int _editor_DisplayedPreset;

		[Token(Token = "0x4000686")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[HideInInspector]
		public bool _editor_DrawGizmos;

		[Token(Token = "0x4000687")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x71")]
		public bool DrawGizmos;

		[Token(Token = "0x4000688")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		public EStimulationMode _editor_SelCategory;

		[Token(Token = "0x4000689")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private bool collisionInitialized;

		[Token(Token = "0x400068A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x79")]
		private bool forceRefreshCollidersData;

		[Token(Token = "0x400068B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private float _squeeze_time;

		[Token(Token = "0x400068C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		protected float[] _vib_RandomFloats;

		[Token(Token = "0x400068D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		protected float _vib_Time;

		[Token(Token = "0x400068E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		protected float _vib_TrueSpeed;

		[Token(Token = "0x400068F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		protected float _vib_Speed;

		[Token(Token = "0x4000690")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		protected float _vib_Range;

		[Token(Token = "0x4000691")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		protected float _vib_Intensity;

		[Token(Token = "0x4000692")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private float[] _vib_sinuses;

		[Token(Token = "0x4000693")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private float[] _vib_cosinuses;

		[Token(Token = "0x4000694")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private float _vib_blend;

		[Token(Token = "0x4000695")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		private float delta;

		[Token(Token = "0x4000696")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private bool updateStimulator;

		[Token(Token = "0x4000697")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		private float fadeOutBlend;

		[Token(Token = "0x4000698")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private float CustomBlendAmount;

		[Token(Token = "0x4000699")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8D04A0", Offset = "0x8D04A0")]
		private float <CurrentFadeDistance>k__BackingField;

		[Token(Token = "0x400069A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8D04B0", Offset = "0x8D04B0")]
		private Transform <ArtificialHelper>k__BackingField;

		[Token(Token = "0x400069B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8D04C0", Offset = "0x8D04C0")]
		private Bone <ArtificialHelpBone>k__BackingField;

		[Token(Token = "0x400069C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8D04D0", Offset = "0x8D04D0")]
		private bool <Initialized>k__BackingField;

		[Token(Token = "0x400069D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		private Vector3 previousPosition;

		[Token(Token = "0x400069E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private Vector3 influenceOffset;

		[Token(Token = "0x400069F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
		[AttributeAttribute(Name = "FPD_SuffixAttribute", RVA = "0x8D04E0", Offset = "0x8D04E0")]
		public float MovementMuscles;

		[Token(Token = "0x40006A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x8D0528", Offset = "0x8D0528")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8D0528", Offset = "0x8D0528")]
		public float MusclesRapidity;

		[Token(Token = "0x40006A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xFC")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8D056C", Offset = "0x8D056C")]
		public float Damping;

		[Token(Token = "0x40006A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x8D0588", Offset = "0x8D0588")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8D0588", Offset = "0x8D0588")]
		public float Smoothing;

		[Token(Token = "0x40006A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8D05CC", Offset = "0x8D05CC")]
		public float MildRotation;

		[Token(Token = "0x40006A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D05E4", Offset = "0x8D05E4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8D05E4", Offset = "0x8D05E4")]
		[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x8D05E4", Offset = "0x8D05E4")]
		public float MotionInfluence;

		[Token(Token = "0x40006A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10C")]
		[AttributeAttribute(Name = "FPD_SuffixAttribute", RVA = "0x8D064C", Offset = "0x8D064C")]
		public float RotationSpaceMuscles;

		[Token(Token = "0x40006A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D0694", Offset = "0x8D0694")]
		public bool UseEulerRotation;

		[Token(Token = "0x40006A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x111")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D06CC", Offset = "0x8D06CC")]
		public bool EnsureRotation;

		[Token(Token = "0x40006A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x114")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8D0704", Offset = "0x8D0704")]
		public float RotationsRapidity;

		[Token(Token = "0x40006A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8D071C", Offset = "0x8D071C")]
		public float RotationsDamping;

		[Token(Token = "0x40006AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8D0738", Offset = "0x8D0738")]
		public float RotationsSwinginess;

		[Token(Token = "0x40006AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		[AttributeAttribute(Name = "FPD_FixedCurveWindowAttribute", RVA = "0x8D0750", Offset = "0x8D0750")]
		public AnimationCurve MusclesBlend;

		[Token(Token = "0x40006AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		public float MusclesSimulationSpeed;

		[Token(Token = "0x40006AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x12C")]
		[AttributeAttribute(Name = "FPD_SuffixAttribute", RVA = "0x8D0780", Offset = "0x8D0780")]
		public float VibrateAmount;

		[Token(Token = "0x40006AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D07C8", Offset = "0x8D07C8")]
		public float VibrateSpeed;

		[Token(Token = "0x40006AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x134")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D0800", Offset = "0x8D0800")]
		public float VibrateRange;

		[Token(Token = "0x40006B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D0838", Offset = "0x8D0838")]
		public Vector3 VibrateAxis;

		[Token(Token = "0x40006B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x144")]
		public float VibrateRotation;

		[Token(Token = "0x40006B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		public bool UniRotation;

		[Token(Token = "0x40006B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14C")]
		public float VibratePosition;

		[Token(Token = "0x40006B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		public float VibrateScale;

		[Token(Token = "0x40006B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x154")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D0870", Offset = "0x8D0870")]
		public bool DetailedVibrate;

		[Token(Token = "0x40006B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		[AttributeAttribute(Name = "FPD_FixedCurveWindowAttribute", RVA = "0x8D08A8", Offset = "0x8D08A8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D08A8", Offset = "0x8D08A8")]
		public AnimationCurve VibratePosBlend;

		[Token(Token = "0x40006B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		[AttributeAttribute(Name = "FPD_FixedCurveWindowAttribute", RVA = "0x8D091C", Offset = "0x8D091C")]
		public AnimationCurve VibrateRotBlend;

		[Token(Token = "0x40006B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		[AttributeAttribute(Name = "FPD_FixedCurveWindowAttribute", RVA = "0x8D0950", Offset = "0x8D0950")]
		public AnimationCurve VibrateScaleBlend;

		[Token(Token = "0x40006B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		[AttributeAttribute(Name = "FPD_SuffixAttribute", RVA = "0x8D098C", Offset = "0x8D098C")]
		public float SqueezingAmount;

		[Token(Token = "0x40006BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x174")]
		public float SqueezingSpeed;

		[Token(Token = "0x40006BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
		public float SqueezingMultiply;

		[Token(Token = "0x40006BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x17C")]
		public Vector3 SqueezingAxis;

		[Token(Token = "0x40006BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D09D4", Offset = "0x8D09D4")]
		public bool UseCollisions;

		[Token(Token = "0x40006BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x189")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D0A0C", Offset = "0x8D0A0C")]
		public bool MovementMusclesCollision;

		[Token(Token = "0x40006BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
		[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x8D0A44", Offset = "0x8D0A44")]
		[AttributeAttribute(Name = "FPD_FixedCurveWindowAttribute", RVA = "0x8D0A44", Offset = "0x8D0A44")]
		public AnimationCurve CollidersScaleCurve;

		[Token(Token = "0x40006C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
		public float CollidersScaleMul;

		[Token(Token = "0x40006C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19C")]
		[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x8D0AA0", Offset = "0x8D0AA0")]
		public Vector3 OffsetAllColliders;

		[Token(Token = "0x40006C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D0AB4", Offset = "0x8D0AB4")]
		[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x8D0AB4", Offset = "0x8D0AB4")]
		public bool DetailedCollision;

		[Token(Token = "0x40006C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
		public List<Collider> IncludedColliders;

		[Token(Token = "0x40006C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
		protected List<FImp_ColliderData_Base> IncludedCollidersData;

		[Token(Token = "0x40006C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
		protected List<FImp_ColliderData_Base> CollidersDataToCheck;

		[Token(Token = "0x40006C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C8")]
		private float sd_amount;

		[Token(Token = "0x170000AA")]
		public string EditorIconPath
		{
			[Token(Token = "0x6000561")]
			[Address(RVA = "0x11D0338", Offset = "0x11D0338", VA = "0x11D0338", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000AB")]
		public float CurrentFadeDistance
		{
			[Token(Token = "0x6000576")]
			[Address(RVA = "0x11D19E0", Offset = "0x11D19E0", VA = "0x11D19E0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8D2A24", Offset = "0x8D2A24")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000577")]
			[Address(RVA = "0x11D19E8", Offset = "0x11D19E8", VA = "0x11D19E8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8D2A34", Offset = "0x8D2A34")]
			private set
			{
			}
		}

		[Token(Token = "0x170000AC")]
		public Transform ArtificialHelper
		{
			[Token(Token = "0x6000578")]
			[Address(RVA = "0x11D19F0", Offset = "0x11D19F0", VA = "0x11D19F0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8D2A44", Offset = "0x8D2A44")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000579")]
			[Address(RVA = "0x11D19F8", Offset = "0x11D19F8", VA = "0x11D19F8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8D2A54", Offset = "0x8D2A54")]
			private set
			{
			}
		}

		[Token(Token = "0x170000AD")]
		public Bone ArtificialHelpBone
		{
			[Token(Token = "0x600057A")]
			[Address(RVA = "0x11D1A00", Offset = "0x11D1A00", VA = "0x11D1A00")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8D2A64", Offset = "0x8D2A64")]
			get
			{
				return null;
			}
			[Token(Token = "0x600057B")]
			[Address(RVA = "0x11D1A08", Offset = "0x11D1A08", VA = "0x11D1A08")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8D2A74", Offset = "0x8D2A74")]
			private set
			{
			}
		}

		[Token(Token = "0x170000AE")]
		public bool Initialized
		{
			[Token(Token = "0x600057C")]
			[Address(RVA = "0x11D1A10", Offset = "0x11D1A10", VA = "0x11D1A10")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8D2A84", Offset = "0x8D2A84")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600057D")]
			[Address(RVA = "0x11D1A18", Offset = "0x11D1A18", VA = "0x11D1A18")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8D2A94", Offset = "0x8D2A94")]
			private set
			{
			}
		}

		[Token(Token = "0x600055C")]
		[Address(RVA = "0x11CEC94", Offset = "0x11CEC94", VA = "0x11CEC94")]
		private void Start()
		{
		}

		[Token(Token = "0x600055D")]
		[Address(RVA = "0x11CF288", Offset = "0x11CF288", VA = "0x11CF288")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600055E")]
		[Address(RVA = "0x11CF4C8", Offset = "0x11CF4C8", VA = "0x11CF4C8")]
		private void Update()
		{
		}

		[Token(Token = "0x600055F")]
		[Address(RVA = "0x11CF85C", Offset = "0x11CF85C", VA = "0x11CF85C")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000560")]
		[Address(RVA = "0x11CF874", Offset = "0x11CF874", VA = "0x11CF874")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000562")]
		[Address(RVA = "0x11D03BC", Offset = "0x11D03BC", VA = "0x11D03BC", Slot = "4")]
		public void OnDrop(PointerEventData data)
		{
		}

		[Token(Token = "0x6000563")]
		[Address(RVA = "0x11CF95C", Offset = "0x11CF95C", VA = "0x11CF95C")]
		private void PhysicsUpdate()
		{
		}

		[Token(Token = "0x6000564")]
		[Address(RVA = "0x11D00B4", Offset = "0x11D00B4", VA = "0x11D00B4")]
		private void PostPhysics()
		{
		}

		[Token(Token = "0x6000565")]
		[Address(RVA = "0x11D04E4", Offset = "0x11D04E4", VA = "0x11D04E4")]
		public void RefreshCollidersDataList()
		{
		}

		[Token(Token = "0x6000566")]
		[Address(RVA = "0x11D0840", Offset = "0x11D0840", VA = "0x11D0840")]
		protected float GetColliderSphereRadiusFor(int i)
		{
			return default(float);
		}

		[Token(Token = "0x6000567")]
		[Address(RVA = "0x11D08E4", Offset = "0x11D08E4", VA = "0x11D08E4")]
		public void AddCollider(Collider collider)
		{
		}

		[Token(Token = "0x6000568")]
		[Address(RVA = "0x11D03C0", Offset = "0x11D03C0", VA = "0x11D03C0")]
		private void InitColliders()
		{
		}

		[Token(Token = "0x6000569")]
		[Address(RVA = "0x11D0984", Offset = "0x11D0984", VA = "0x11D0984")]
		public void CheckForColliderDuplicates()
		{
		}

		[Token(Token = "0x600056A")]
		[Address(RVA = "0x11D06B4", Offset = "0x11D06B4", VA = "0x11D06B4")]
		public void PushIfSegmentInsideCollider(Bone bone, ref Vector3 targetPoint)
		{
		}

		[Token(Token = "0x600056B")]
		[Address(RVA = "0x11D0068", Offset = "0x11D0068", VA = "0x11D0068")]
		public void UpdateMusclesLogics()
		{
		}

		[Token(Token = "0x600056C")]
		[Address(RVA = "0x11D0BAC", Offset = "0x11D0BAC", VA = "0x11D0BAC")]
		public void UpdateMovementMusclesWith()
		{
		}

		[Token(Token = "0x600056D")]
		[Address(RVA = "0x11D0DBC", Offset = "0x11D0DBC", VA = "0x11D0DBC")]
		public void UpdateRotationSpaceMusclesWith()
		{
		}

		[Token(Token = "0x600056E")]
		[Address(RVA = "0x11D105C", Offset = "0x11D105C", VA = "0x11D105C")]
		public void SqueezeInitialize()
		{
		}

		[Token(Token = "0x600056F")]
		[Address(RVA = "0x11CFEA0", Offset = "0x11CFEA0", VA = "0x11CFEA0")]
		public void UpdateSqueezeLogics()
		{
		}

		[Token(Token = "0x6000570")]
		[Address(RVA = "0x11D1094", Offset = "0x11D1094", VA = "0x11D1094")]
		private void Vibrate_Initialize()
		{
		}

		[Token(Token = "0x6000571")]
		[Address(RVA = "0x11CFB60", Offset = "0x11CFB60", VA = "0x11CFB60")]
		public void UpdateVibrateLogics()
		{
		}

		[Token(Token = "0x6000572")]
		[Address(RVA = "0x11D1978", Offset = "0x11D1978", VA = "0x11D1978")]
		public void Vibrate_ExplosionShake(float value = 12f)
		{
		}

		[Token(Token = "0x6000573")]
		[Address(RVA = "0x11D1120", Offset = "0x11D1120", VA = "0x11D1120")]
		protected void Vibrate_ChooseNewSeed()
		{
		}

		[Token(Token = "0x6000574")]
		[Address(RVA = "0x11D1268", Offset = "0x11D1268", VA = "0x11D1268")]
		private void Vibrate_Calculation(Bone target)
		{
		}

		[Token(Token = "0x6000575")]
		[Address(RVA = "0x11D19D8", Offset = "0x11D19D8", VA = "0x11D19D8")]
		private float Pow2(float toPower)
		{
			return default(float);
		}

		[Token(Token = "0x600057E")]
		[Address(RVA = "0x11CEC98", Offset = "0x11CEC98", VA = "0x11CEC98")]
		public void Initialize()
		{
		}

		[Token(Token = "0x600057F")]
		[Address(RVA = "0x11CF508", Offset = "0x11CF508", VA = "0x11CF508")]
		public void CheckIfCanUpdate()
		{
		}

		[Token(Token = "0x6000580")]
		[Address(RVA = "0x11D1A24", Offset = "0x11D1A24", VA = "0x11D1A24")]
		public Transform GetDistanceMeasureTransform()
		{
			return null;
		}

		[Token(Token = "0x6000581")]
		[Address(RVA = "0x11CF6F8", Offset = "0x11CF6F8", VA = "0x11CF6F8")]
		public void PreCalibrateBones()
		{
		}

		[Token(Token = "0x6000582")]
		[Address(RVA = "0x11CF8C4", Offset = "0x11CF8C4", VA = "0x11CF8C4")]
		public void BeginUpdate()
		{
		}

		[Token(Token = "0x6000583")]
		[Address(RVA = "0x11D1AF8", Offset = "0x11D1AF8", VA = "0x11D1AF8")]
		public void UpdateMuscleSettings(Bone bone)
		{
		}

		[Token(Token = "0x6000584")]
		[Address(RVA = "0x11D1048", Offset = "0x11D1048", VA = "0x11D1048")]
		public float GetEffectBlendWeight()
		{
			return default(float);
		}

		[Token(Token = "0x6000585")]
		[Address(RVA = "0x11D1D40", Offset = "0x11D1D40", VA = "0x11D1D40")]
		public Vector3 GetEndTipWorldOffset()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000586")]
		[Address(RVA = "0x11D1E94", Offset = "0x11D1E94", VA = "0x11D1E94")]
		public Transform GetLastTransform()
		{
			return null;
		}

		[Token(Token = "0x6000587")]
		[Address(RVA = "0x11D1C5C", Offset = "0x11D1C5C", VA = "0x11D1C5C")]
		private void Motion_MotionInfluence()
		{
		}

		[Token(Token = "0x6000588")]
		[Address(RVA = "0x11D1F84", Offset = "0x11D1F84", VA = "0x11D1F84")]
		internal void User_TransitionAmount(float targetAmount, float duration)
		{
		}

		[Token(Token = "0x6000589")]
		[Address(RVA = "0x11D2028", Offset = "0x11D2028", VA = "0x11D2028")]
		public BonesStimulator()
		{
		}
	}
}
namespace DG.Tweening
{
	[Token(Token = "0x20000CE")]
	public static class DOTweenModuleAudio
	{
		[Token(Token = "0x20000CF")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8CB3EC", Offset = "0x8CB3EC")]
		private sealed class <>c__DisplayClass0_0
		{
			[Token(Token = "0x40006E3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public AudioSource target;

			[Token(Token = "0x60005B0")]
			[Address(RVA = "0x117BD7C", Offset = "0x117BD7C", VA = "0x117BD7C")]
			public <>c__DisplayClass0_0()
			{
			}

			[Token(Token = "0x60005B1")]
			[Address(RVA = "0x117BD84", Offset = "0x117BD84", VA = "0x117BD84")]
			internal float <DOFade>b__0()
			{
				return default(float);
			}

			[Token(Token = "0x60005B2")]
			[Address(RVA = "0x117BDA0", Offset = "0x117BDA0", VA = "0x117BDA0")]
			internal void <DOFade>b__1(float x)
			{
			}
		}

		[Token(Token = "0x20000D0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8CB3FC", Offset = "0x8CB3FC")]
		private sealed class <>c__DisplayClass1_0
		{
			[Token(Token = "0x40006E4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public AudioSource target;

			[Token(Token = "0x60005B3")]
			[Address(RVA = "0x117BDBC", Offset = "0x117BDBC", VA = "0x117BDBC")]
			public <>c__DisplayClass1_0()
			{
			}

			[Token(Token = "0x60005B4")]
			[Address(RVA = "0x117BDC4", Offset = "0x117BDC4", VA = "0x117BDC4")]
			internal float <DOPitch>b__0()
			{
				return default(float);
			}

			[Token(Token = "0x60005B5")]
			[Address(RVA = "0x117BDE0", Offset = "0x117BDE0", VA = "0x117BDE0")]
			internal void <DOPitch>b__1(float x)
			{
			}
		}

		[Token(Token = "0x20000D1")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8CB40C", Offset = "0x8CB40C")]
		private sealed class <>c__DisplayClass2_0
		{
			[Token(Token = "0x40006E5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public AudioMixer target;

			[Token(Token = "0x40006E6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public string floatName;

			[Token(Token = "0x60005B6")]
			[Address(RVA = "0x117BDFC", Offset = "0x117BDFC", VA = "0x117BDFC")]
			public <>c__DisplayClass2_0()
			{
			}

			[Token(Token = "0x60005B7")]
			[Address(RVA = "0x117BE04", Offset = "0x117BE04", VA = "0x117BE04")]
			internal float <DOSetFloat>b__0()
			{
				return default(float);
			}

			[Token(Token = "0x60005B8")]
			[Address(RVA = "0x117BE44", Offset = "0x117BE44", VA = "0x117BE44")]
			internal void <DOSetFloat>b__1(float x)
			{
			}
		}

		[Token(Token = "0x60005A1")]
		[Address(RVA = "0x11D4168", Offset = "0x11D4168", VA = "0x11D4168")]
		public static TweenerCore<float, float, FloatOptions> DOFade(this AudioSource target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x60005A2")]
		[Address(RVA = "0x11D4338", Offset = "0x11D4338", VA = "0x11D4338")]
		public static TweenerCore<float, float, FloatOptions> DOPitch(this AudioSource target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x60005A3")]
		[Address(RVA = "0x11D44E0", Offset = "0x11D44E0", VA = "0x11D44E0")]
		public static TweenerCore<float, float, FloatOptions> DOSetFloat(this AudioMixer target, string floatName, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x60005A4")]
		[Address(RVA = "0x11D469C", Offset = "0x11D469C", VA = "0x11D469C")]
		public static int DOComplete(this AudioMixer target, bool withCallbacks = false)
		{
			return default(int);
		}

		[Token(Token = "0x60005A5")]
		[Address(RVA = "0x11D4710", Offset = "0x11D4710", VA = "0x11D4710")]
		public static int DOKill(this AudioMixer target, bool complete = false)
		{
			return default(int);
		}

		[Token(Token = "0x60005A6")]
		[Address(RVA = "0x11D4784", Offset = "0x11D4784", VA = "0x11D4784")]
		public static int DOFlip(this AudioMixer target)
		{
			return default(int);
		}

		[Token(Token = "0x60005A7")]
		[Address(RVA = "0x11D47E8", Offset = "0x11D47E8", VA = "0x11D47E8")]
		public static int DOGoto(this AudioMixer target, float to, bool andPlay = false)
		{
			return default(int);
		}

		[Token(Token = "0x60005A8")]
		[Address(RVA = "0x11D486C", Offset = "0x11D486C", VA = "0x11D486C")]
		public static int DOPause(this AudioMixer target)
		{
			return default(int);
		}

		[Token(Token = "0x60005A9")]
		[Address(RVA = "0x11D48D0", Offset = "0x11D48D0", VA = "0x11D48D0")]
		public static int DOPlay(this AudioMixer target)
		{
			return default(int);
		}

		[Token(Token = "0x60005AA")]
		[Address(RVA = "0x11D4934", Offset = "0x11D4934", VA = "0x11D4934")]
		public static int DOPlayBackwards(this AudioMixer target)
		{
			return default(int);
		}

		[Token(Token = "0x60005AB")]
		[Address(RVA = "0x11D4998", Offset = "0x11D4998", VA = "0x11D4998")]
		public static int DOPlayForward(this AudioMixer target)
		{
			return default(int);
		}

		[Token(Token = "0x60005AC")]
		[Address(RVA = "0x11D49FC", Offset = "0x11D49FC", VA = "0x11D49FC")]
		public static int DORestart(this AudioMixer target)
		{
			return default(int);
		}

		[Token(Token = "0x60005AD")]
		[Address(RVA = "0x11D4A68", Offset = "0x11D4A68", VA = "0x11D4A68")]
		public static int DORewind(this AudioMixer target)
		{
			return default(int);
		}

		[Token(Token = "0x60005AE")]
		[Address(RVA = "0x11D4AD0", Offset = "0x11D4AD0", VA = "0x11D4AD0")]
		public static int DOSmoothRewind(this AudioMixer target)
		{
			return default(int);
		}

		[Token(Token = "0x60005AF")]
		[Address(RVA = "0x11D4B34", Offset = "0x11D4B34", VA = "0x11D4B34")]
		public static int DOTogglePause(this AudioMixer target)
		{
			return default(int);
		}
	}
	[Token(Token = "0x20000D2")]
	public static class DOTweenModulePhysics
	{
		[Token(Token = "0x20000D3")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8CB42C", Offset = "0x8CB42C")]
		private sealed class <>c__DisplayClass0_0
		{
			[Token(Token = "0x40006E7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody target;

			[Token(Token = "0x60005C4")]
			[Address(RVA = "0x117BE68", Offset = "0x117BE68", VA = "0x117BE68")]
			public <>c__DisplayClass0_0()
			{
			}

			[Token(Token = "0x60005C5")]
			[Address(RVA = "0x117BE70", Offset = "0x117BE70", VA = "0x117BE70")]
			internal Vector3 <DOMove>b__0()
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x20000D4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8CB43C", Offset = "0x8CB43C")]
		private sealed class <>c__DisplayClass1_0
		{
			[Token(Token = "0x40006E8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody target;

			[Token(Token = "0x60005C6")]
			[Address(RVA = "0x117BFB0", Offset = "0x117BFB0", VA = "0x117BFB0")]
			public <>c__DisplayClass1_0()
			{
			}

			[Token(Token = "0x60005C7")]
			[Address(RVA = "0x117BFB8", Offset = "0x117BFB8", VA = "0x117BFB8")]
			internal Vector3 <DOMoveX>b__0()
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x20000D5")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8CB44C", Offset = "0x8CB44C")]
		private sealed class <>c__DisplayClass2_0
		{
			[Token(Token = "0x40006E9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody target;

			[Token(Token = "0x60005C8")]
			[Address(RVA = "0x117BFD4", Offset = "0x117BFD4", VA = "0x117BFD4")]
			public <>c__DisplayClass2_0()
			{
			}

			[Token(Token = "0x60005C9")]
			[Address(RVA = "0x117BFDC", Offset = "0x117BFDC", VA = "0x117BFDC")]
			internal Vector3 <DOMoveY>b__0()
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x20000D6")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8CB45C", Offset = "0x8CB45C")]
		private sealed class <>c__DisplayClass3_0
		{
			[Token(Token = "0x40006EA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody target;

			[Token(Token = "0x60005CA")]
			[Address(RVA = "0x117BFF8", Offset = "0x117BFF8", VA = "0x117BFF8")]
			public <>c__DisplayClass3_0()
			{
			}

			[Token(Token = "0x60005CB")]
			[Address(RVA = "0x117C000", Offset = "0x117C000", VA = "0x117C000")]
			internal Vector3 <DOMoveZ>b__0()
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x20000D7")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8CB46C", Offset = "0x8CB46C")]
		private sealed class <>c__DisplayClass4_0
		{
			[Token(Token = "0x40006EB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody target;

			[Token(Token = "0x60005CC")]
			[Address(RVA = "0x117C01C", Offset = "0x117C01C", VA = "0x117C01C")]
			public <>c__DisplayClass4_0()
			{
			}

			[Token(Token = "0x60005CD")]
			[Address(RVA = "0x117C024", Offset = "0x117C024", VA = "0x117C024")]
			internal Quaternion <DORotate>b__0()
			{
				return default(Quaternion);
			}
		}

		[Token(Token = "0x20000D8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8CB47C", Offset = "0x8CB47C")]
		private sealed class <>c__DisplayClass5_0
		{
			[Token(Token = "0x40006EC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody target;

			[Token(Token = "0x60005CE")]
			[Address(RVA = "0x117C040", Offset = "0x117C040", VA = "0x117C040")]
			public <>c__DisplayClass5_0()
			{
			}

			[Token(Token = "0x60005CF")]
			[Address(RVA = "0x117C048", Offset = "0x117C048", VA = "0x117C048")]
			internal Quaternion <DOLookAt>b__0()
			{
				return default(Quaternion);
			}
		}

		[Token(Token = "0x20000D9")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8CB48C", Offset = "0x8CB48C")]
		private sealed class <>c__DisplayClass6_0
		{
			[Token(Token = "0x40006ED")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody target;

			[Token(Token = "0x40006EE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float startPosY;

			[Token(Token = "0x40006EF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public bool offsetYSet;

			[Token(Token = "0x40006F0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float offsetY;

			[Token(Token = "0x40006F1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Sequence s;

			[Token(Token = "0x40006F2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Vector3 endValue;

			[Token(Token = "0x40006F3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public Tween yTween;

			[Token(Token = "0x60005D0")]
			[Address(RVA = "0x117C064", Offset = "0x117C064", VA = "0x117C064")]
			public <>c__DisplayClass6_0()
			{
			}

			[Token(Token = "0x60005D1")]
			[Address(RVA = "0x117C06C", Offset = "0x117C06C", VA = "0x117C06C")]
			internal Vector3 <DOJump>b__0()
			{
				return default(Vector3);
			}

			[Token(Token = "0x60005D2")]
			[Address(RVA = "0x117C088", Offset = "0x117C088", VA = "0x117C088")]
			internal void <DOJump>b__1()
			{
			}

			[Token(Token = "0x60005D3")]
			[Address(RVA = "0x117C0BC", Offset = "0x117C0BC", VA = "0x117C0BC")]
			internal Vector3 <DOJump>b__2()
			{
				return default(Vector3);
			}

			[Token(Token = "0x60005D4")]
			[Address(RVA = "0x117C0D8", Offset = "0x117C0D8", VA = "0x117C0D8")]
			internal Vector3 <DOJump>b__3()
			{
				return default(Vector3);
			}

			[Token(Token = "0x60005D5")]
			[Address(RVA = "0x117C0F4", Offset = "0x117C0F4", VA = "0x117C0F4")]
			internal void <DOJump>b__4()
			{
			}
		}

		[Token(Token = "0x20000DA")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8CB49C", Offset = "0x8CB49C")]
		private sealed class <>c__DisplayClass7_0
		{
			[Token(Token = "0x40006F4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody target;

			[Token(Token = "0x60005D6")]
			[Address(RVA = "0x117C1B4", Offset = "0x117C1B4", VA = "0x117C1B4")]
			public <>c__DisplayClass7_0()
			{
			}

			[Token(Token = "0x60005D7")]
			[Address(RVA = "0x117C1BC", Offset = "0x117C1BC", VA = "0x117C1BC")]
			internal Vector3 <DOPath>b__0()
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x20000DB")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8CB4AC", Offset = "0x8CB4AC")]
		private sealed class <>c__DisplayClass8_0
		{
			[Token(Token = "0x40006F5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform trans;

			[Token(Token = "0x40006F6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Rigidbody target;

			[Token(Token = "0x60005D8")]
			[Address(RVA = "0x117C1D8", Offset = "0x117C1D8", VA = "0x117C1D8")]
			public <>c__DisplayClass8_0()
			{
			}

			[Token(Token = "0x60005D9")]
			[Address(RVA = "0x117C1E0", Offset = "0x117C1E0", VA = "0x117C1E0")]
			internal Vector3 <DOLocalPath>b__0()
			{
				return default(Vector3);
			}

			[Token(Token = "0x60005DA")]
			[Address(RVA = "0x117C1FC", Offset = "0x117C1FC", VA = "0x117C1FC")]
			internal void <DOLocalPath>b__1(Vector3 x)
			{
			}
		}

		[Token(Token = "0x20000DC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8CB4BC", Offset = "0x8CB4BC")]
		private sealed class <>c__DisplayClass9_0
		{
			[Token(Token = "0x40006F7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody target;

			[Token(Token = "0x60005DB")]
			[Address(RVA = "0x117C2FC", Offset = "0x117C2FC", VA = "0x117C2FC")]
			public <>c__DisplayClass9_0()
			{
			}

			[Token(Token = "0x60005DC")]
			[Address(RVA = "0x117C304", Offset = "0x117C304", VA = "0x117C304")]
			internal Vector3 <DOPath>b__0()
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x20000DD")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8CB4CC", Offset = "0x8CB4CC")]
		private sealed class <>c__DisplayClass10_0
		{
			[Token(Token = "0x40006F8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform trans;

			[Token(Token = "0x40006F9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Rigidbody target;

			[Token(Token = "0x60005DD")]
			[Address(RVA = "0x117BE8C", Offset = "0x117BE8C", VA = "0x117BE8C")]
			public <>c__DisplayClass10_0()
			{
			}

			[Token(Token = "0x60005DE")]
			[Address(RVA = "0x117BE94", Offset = "0x117BE94", VA = "0x117BE94")]
			internal Vector3 <DOLocalPath>b__0()
			{
				return default(Vector3);
			}

			[Token(Token = "0x60005DF")]
			[Address(RVA = "0x117BEB0", Offset = "0x117BEB0", VA = "0x117BEB0")]
			internal void <DOLocalPath>b__1(Vector3 x)
			{
			}
		}

		[Token(Token = "0x60005B9")]
		[Address(RVA = "0x11D4B98", Offset = "0x11D4B98", VA = "0x11D4B98")]
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOMove(this Rigidbody target, Vector3 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60005BA")]
		[Address(RVA = "0x11D4D74", Offset = "0x11D4D74", VA = "0x11D4D74")]
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOMoveX(this Rigidbody target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60005BB")]
		[Address(RVA = "0x11D4F44", Offset = "0x11D4F44", VA = "0x11D4F44")]
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOMoveY(this Rigidbody target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60005BC")]
		[Address(RVA = "0x11D5114", Offset = "0x11D5114", VA = "0x11D5114")]
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOMoveZ(this Rigidbody target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60005BD")]
		[Address(RVA = "0x11D52E4", Offset = "0x11D52E4", VA = "0x11D52E4")]
		public static TweenerCore<Quaternion, Vector3, QuaternionOptions> DORotate(this Rigidbody target, Vector3 endValue, float duration, RotateMode mode = RotateMode.Fast)
		{
			return null;
		}

		[Token(Token = "0x60005BE")]
		[Address(RVA = "0x11D54BC", Offset = "0x11D54BC", VA = "0x11D54BC")]
		public static TweenerCore<Quaternion, Vector3, QuaternionOptions> DOLookAt(this Rigidbody target, Vector3 towards, float duration, AxisConstraint axisConstraint = AxisConstraint.None, [Optional] Vector3? up)
		{
			return null;
		}

		[Token(Token = "0x60005BF")]
		[Address(RVA = "0x11D5710", Offset = "0x11D5710", VA = "0x11D5710")]
		public static Sequence DOJump(this Rigidbody target, Vector3 endValue, float jumpPower, int numJumps, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60005C0")]
		[Address(RVA = "0x11D5C44", Offset = "0x11D5C44", VA = "0x11D5C44")]
		public static TweenerCore<Vector3, Path, PathOptions> DOPath(this Rigidbody target, Vector3[] path, float duration, PathType pathType = PathType.Linear, PathMode pathMode = PathMode.Full3D, int resolution = 10, [Optional] Color? gizmoColor)
		{
			return null;
		}

		[Token(Token = "0x60005C1")]
		[Address(RVA = "0x11D5EC0", Offset = "0x11D5EC0", VA = "0x11D5EC0")]
		public static TweenerCore<Vector3, Path, PathOptions> DOLocalPath(this Rigidbody target, Vector3[] path, float duration, PathType pathType = PathType.Linear, PathMode pathMode = PathMode.Full3D, int resolution = 10, [Optional] Color? gizmoColor)
		{
			return null;
		}

		[Token(Token = "0x60005C2")]
		[Address(RVA = "0x11D615C", Offset = "0x11D615C", VA = "0x11D615C")]
		internal static TweenerCore<Vector3, Path, PathOptions> DOPath(this Rigidbody target, Path path, float duration, PathMode pathMode = PathMode.Full3D)
		{
			return null;
		}

		[Token(Token = "0x60005C3")]
		[Address(RVA = "0x11D634C", Offset = "0x11D634C", VA = "0x11D634C")]
		internal static TweenerCore<Vector3, Path, PathOptions> DOLocalPath(this Rigidbody target, Path path, float duration, PathMode pathMode = PathMode.Full3D)
		{
			return null;
		}
	}
	[Token(Token = "0x20000DE")]
	public static class DOTweenModulePhysics2D
	{
		[Token(Token = "0x20000DF")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8CB4EC", Offset = "0x8CB4EC")]
		private sealed class <>c__DisplayClass0_0
		{
			[Token(Token = "0x40006FA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody2D target;

			[Token(Token = "0x60005E9")]
			[Address(RVA = "0x117C320", Offset = "0x117C320", VA = "0x117C320")]
			public <>c__DisplayClass0_0()
			{
			}

			[Token(Token = "0x60005EA")]
			[Address(RVA = "0x117C328", Offset = "0x117C328", VA = "0x117C328")]
			internal Vector2 <DOMove>b__0()
			{
				return default(Vector2);
			}
		}

		[Token(Token = "0x20000E0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8CB4FC", Offset = "0x8CB4FC")]
		private sealed class <>c__DisplayClass1_0
		{
			[Token(Token = "0x40006FB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody2D target;

			[Token(Token = "0x60005EB")]
			[Address(RVA = "0x117C344", Offset = "0x117C344", VA = "0x117C344")]
			public <>c__DisplayClass1_0()
			{
			}

			[Token(Token = "0x60005EC")]
			[Address(RVA = "0x117C34C", Offset = "0x117C34C", VA = "0x117C34C")]
			internal Vector2 <DOMoveX>b__0()
			{
				return default(Vector2);
			}
		}

		[Token(Token = "0x20000E1")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8CB50C", Offset = "0x8CB50C")]
		private sealed class <>c__DisplayClass2_0
		{
			[Token(Token = "0x40006FC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody2D target;

			[Token(Token = "0x60005ED")]
			[Address(RVA = "0x117C368", Offset = "0x117C368", VA = "0x117C368")]
			public <>c__DisplayClass2_0()
			{
			}

			[Token(Token = "0x60005EE")]
			[Address(RVA = "0x117C370", Offset = "0x117C370", VA = "0x117C370")]
			internal Vector2 <DOMoveY>b__0()
			{
				return default(Vector2);
			}
		}

		[Token(Token = "0x20000E2")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8CB51C", Offset = "0x8CB51C")]
		private sealed class <>c__DisplayClass3_0
		{
			[Token(Token = "0x40006FD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody2D target;

			[Token(Token = "0x60005EF")]
			[Address(RVA = "0x117C38C", Offset = "0x117C38C", VA = "0x117C38C")]
			public <>c__DisplayClass3_0()
			{
			}

			[Token(Token = "0x60005F0")]
			[Address(RVA = "0x117C394", Offset = "0x117C394", VA = "0x117C394")]
			internal float <DORotate>b__0()
			{
				return default(float);
			}
		}

		[Token(Token = "0x20000E3")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8CB52C", Offset = "0x8CB52C")]
		private sealed class <>c__DisplayClass4_0
		{
			[Token(Token = "0x40006FE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody2D target;

			[Token(Token = "0x40006FF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float startPosY;

			[Token(Token = "0x4000700")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public bool offsetYSet;

			[Token(Token = "0x4000701")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float offsetY;

			[Token(Token = "0x4000702")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Sequence s;

			[Token(Token = "0x4000703")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Vector2 endValue;

			[Token(Token = "0x4000704")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Tween yTween;

			[Token(Token = "0x60005F1")]
			[Address(RVA = "0x117C3B0", Offset = "0x117C3B0", VA = "0x117C3B0")]
			public <>c__DisplayClass4_0()
			{
			}

			[Token(Token = "0x60005F2")]
			[Address(RVA = "0x117C3B8", Offset = "0x117C3B8", VA = "0x117C3B8")]
			internal Vector2 <DOJump>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x60005F3")]
			[Address(RVA = "0x117C3D4", Offset = "0x117C3D4", VA = "0x117C3D4")]
			internal void <DOJump>b__1(Vector2 x)
			{
			}

			[Token(Token = "0x60005F4")]
			[Address(RVA = "0x117C3F0", Offset = "0x117C3F0", VA = "0x117C3F0")]
			internal void <DOJump>b__2()
			{
			}

			[Token(Token = "0x60005F5")]
			[Address(RVA = "0x117C424", Offset = "0x117C424", VA = "0x117C424")]
			internal Vector2 <DOJump>b__3()
			{
				return default(Vector2);
			}

			[Token(Token = "0x60005F6")]
			[Address(RVA = "0x117C440", Offset = "0x117C440", VA = "0x117C440")]
			internal void <DOJump>b__4(Vector2 x)
			{
			}

			[Token(Token = "0x60005F7")]
			[Address(RVA = "0x117C45C", Offset = "0x117C45C", VA = "0x117C45C")]
			internal void <DOJump>b__5()
			{
			}
		}

		[Token(Token = "0x20000E4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8CB53C", Offset = "0x8CB53C")]
		private sealed class <>c__DisplayClass5_0
		{
			[Token(Token = "0x4000705")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody2D target;

			[Token(Token = "0x60005F8")]
			[Address(RVA = "0x117C514", Offset = "0x117C514", VA = "0x117C514")]
			public <>c__DisplayClass5_0()
			{
			}

			[Token(Token = "0x60005F9")]
			[Address(RVA = "0x117C51C", Offset = "0x117C51C", VA = "0x117C51C")]
			internal Vector3 <DOPath>b__0()
			{
				return default(Vector3);
			}

			[Token(Token = "0x60005FA")]
			[Address(RVA = "0x117C544", Offset = "0x117C544", VA = "0x117C544")]
			internal void <DOPath>b__1(Vector3 x)
			{
			}
		}

		[Token(Token = "0x20000E5")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8CB54C", Offset = "0x8CB54C")]
		private sealed class <>c__DisplayClass6_0
		{
			[Token(Token = "0x4000706")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform trans;

			[Token(Token = "0x4000707")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Rigidbody2D target;

			[Token(Token = "0x60005FB")]
			[Address(RVA = "0x117C560", Offset = "0x117C560", VA = "0x117C560")]
			public <>c__DisplayClass6_0()
			{
			}

			[Token(Token = "0x60005FC")]
			[Address(RVA = "0x117C568", Offset = "0x117C568", VA = "0x117C568")]
			internal Vector3 <DOLocalPath>b__0()
			{
				return default(Vector3);
			}

			[Token(Token = "0x60005FD")]
			[Address(RVA = "0x117C584", Offset = "0x117C584", VA = "0x117C584")]
			internal void <DOLocalPath>b__1(Vector3 x)
			{
			}
		}

		[Token(Token = "0x20000E6")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8CB55C", Offset = "0x8CB55C")]
		private sealed class <>c__DisplayClass7_0
		{
			[Token(Token = "0x4000708")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody2D target;

			[Token(Token = "0x60005FE")]
			[Address(RVA = "0x117C67C", Offset = "0x117C67C", VA = "0x117C67C")]
			public <>c__DisplayClass7_0()
			{
			}

			[Token(Token = "0x60005FF")]
			[Address(RVA = "0x117C684", Offset = "0x117C684", VA = "0x117C684")]
			internal Vector3 <DOPath>b__0()
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000600")]
			[Address(RVA = "0x117C6AC", Offset = "0x117C6AC", VA = "0x117C6AC")]
			internal void <DOPath>b__1(Vector3 x)
			{
			}
		}

		[Token(Token = "0x20000E7")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8CB56C", Offset = "0x8CB56C")]
		private sealed class <>c__DisplayClass8_0
		{
			[Token(Token = "0x4000709")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform trans;

			[Token(Token = "0x400070A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Rigidbody2D target;

			[Token(Token = "0x6000601")]
			[Address(RVA = "0x117C6C8", Offset = "0x117C6C8", VA = "0x117C6C8")]
			public <>c__DisplayClass8_0()
			{
			}

			[Token(Token = "0x6000602")]
			[Address(RVA = "0x117C6D0", Offset = "0x117C6D0", VA = "0x117C6D0")]
			internal Vector3 <DOLocalPath>b__0()
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000603")]
			[Address(RVA = "0x117C6EC", Offset = "0x117C6EC", VA = "0x117C6EC")]
			internal void <DOLocalPath>b__1(Vector3 x)
			{
			}
		}

		[Token(Token = "0x60005E0")]
		[Address(RVA = "0x11D655C", Offset = "0x11D655C", VA = "0x11D655C")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOMove(this Rigidbody2D target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60005E1")]
		[Address(RVA = "0x11D6730", Offset = "0x11D6730", VA = "0x11D6730")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOMoveX(this Rigidbody2D target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60005E2")]
		[Address(RVA = "0x11D68FC", Offset = "0x11D68FC", VA = "0x11D68FC")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOMoveY(this Rigidbody2D target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60005E3")]
		[Address(RVA = "0x11D6AC8", Offset = "0x11D6AC8", VA = "0x11D6AC8")]
		public static TweenerCore<float, float, FloatOptions> DORotate(this Rigidbody2D target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x60005E4")]
		[Address(RVA = "0x11D6C74", Offset = "0x11D6C74", VA = "0x11D6C74")]
		public static Sequence DOJump(this Rigidbody2D target, Vector2 endValue, float jumpPower, int numJumps, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60005E5")]
		[Address(RVA = "0x11D70D0", Offset = "0x11D70D0", VA = "0x11D70D0")]
		public static TweenerCore<Vector3, Path, PathOptions> DOPath(this Rigidbody2D target, Vector2[] path, float duration, PathType pathType = PathType.Linear, PathMode pathMode = PathMode.Full3D, int resolution = 10, [Optional] Color? gizmoColor)
		{
			return null;
		}

		[Token(Token = "0x60005E6")]
		[Address(RVA = "0x11D73D0", Offset = "0x11D73D0", VA = "0x11D73D0")]
		public static TweenerCore<Vector3, Path, PathOptions> DOLocalPath(this Rigidbody2D target, Vector2[] path, float duration, PathType pathType = PathType.Linear, PathMode pathMode = PathMode.Full3D, int resolution = 10, [Optional] Color? gizmoColor)
		{
			return null;
		}

		[Token(Token = "0x60005E7")]
		[Address(RVA = "0x11D76F4", Offset = "0x11D76F4", VA = "0x11D76F4")]
		internal static TweenerCore<Vector3, Path, PathOptions> DOPath(this Rigidbody2D target, Path path, float duration, PathMode pathMode = PathMode.Full3D)
		{
			return null;
		}

		[Token(Token = "0x60005E8")]
		[Address(RVA = "0x11D78E0", Offset = "0x11D78E0", VA = "0x11D78E0")]
		internal static TweenerCore<Vector3, Path, PathOptions> DOLocalPath(this Rigidbody2D target, Path path, float duration, PathMode pathMode = PathMode.Full3D)
		{
			return null;
		}
	}
	[Token(Token = "0x20000E8")]
	public static class DOTweenModuleSprite
	{
		[Token(Token = "0x20000E9")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8CB58C", Offset = "0x8CB58C")]
		private sealed class <>c__DisplayClass0_0
		{
			[Token(Token = "0x400070B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public SpriteRenderer target;

			[Token(Token = "0x6000608")]
			[Address(RVA = "0x117C7E4", Offset = "0x117C7E4", VA = "0x117C7E4")]
			public <>c__DisplayClass0_0()
			{
			}

			[Token(Token = "0x6000609")]
			[Address(RVA = "0x117C7EC", Offset = "0x117C7EC", VA = "0x117C7EC")]
			internal Color <DOColor>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x600060A")]
			[Address(RVA = "0x117C808", Offset = "0x117C808", VA = "0x117C808")]
			internal void <DOColor>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x20000EA")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8CB59C", Offset = "0x8CB59C")]
		private sealed class <>c__DisplayClass1_0
		{
			[Token(Token = "0x400070C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public SpriteRenderer target;

			[Token(Token = "0x600060B")]
			[Address(RVA = "0x117C824", Offset = "0x117C824", VA = "0x117C824")]
			public <>c__DisplayClass1_0()
			{
			}

			[Token(Token = "0x600060C")]
			[Address(RVA = "0x117C82C", Offset = "0x117C82C", VA = "0x117C82C")]
			internal Color <DOFade>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x600060D")]
			[Address(RVA = "0x117C848", Offset = "0x117C848", VA = "0x117C848")]
			internal void <DOFade>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x20000EB")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8CB5AC", Offset = "0x8CB5AC")]
		private sealed class <>c__DisplayClass3_0
		{
			[Token(Token = "0x400070D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Color to;

			[Token(Token = "0x400070E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public SpriteRenderer target;

			[Token(Token = "0x600060E")]
			[Address(RVA = "0x117C864", Offset = "0x117C864", VA = "0x117C864")]
			public <>c__DisplayClass3_0()
			{
			}

			[Token(Token = "0x600060F")]
			[Address(RVA = "0x117C86C", Offset = "0x117C86C", VA = "0x117C86C")]
			internal Color <DOBlendableColor>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x6000610")]
			[Address(RVA = "0x117C878", Offset = "0x117C878", VA = "0x117C878")]
			internal void <DOBlendableColor>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x6000604")]
		[Address(RVA = "0x11D7AF0", Offset = "0x11D7AF0", VA = "0x11D7AF0")]
		public static TweenerCore<Color, Color, ColorOptions> DOColor(this SpriteRenderer target, Color endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000605")]
		[Address(RVA = "0x11D7CC0", Offset = "0x11D7CC0", VA = "0x11D7CC0")]
		public static TweenerCore<Color, Color, ColorOptions> DOFade(this SpriteRenderer target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000606")]
		[Address(RVA = "0x11D7E68", Offset = "0x11D7E68", VA = "0x11D7E68")]
		public static Sequence DOGradientColor(this SpriteRenderer target, Gradient gradient, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000607")]
		[Address(RVA = "0x11D8054", Offset = "0x11D8054", VA = "0x11D8054")]
		public static Tweener DOBlendableColor(this SpriteRenderer target, Color endValue, float duration)
		{
			return null;
		}
	}
	[Token(Token = "0x20000EC")]
	public static class DOTweenModuleUI
	{
		[Token(Token = "0x20000ED")]
		public static class Utils
		{
			[Token(Token = "0x600063B")]
			[Address(RVA = "0x117D94C", Offset = "0x117D94C", VA = "0x117D94C")]
			public static Vector2 SwitchToRectTransform(RectTransform from, RectTransform to)
			{
				return default(Vector2);
			}
		}

		[Token(Token = "0x20000EE")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8CB5CC", Offset = "0x8CB5CC")]
		private sealed class <>c__DisplayClass0_0
		{
			[Token(Token = "0x400070F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public CanvasGroup target;

			[Token(Token = "0x600063C")]
			[Address(RVA = "0x117C924", Offset = "0x117C924", VA = "0x117C924")]
			public <>c__DisplayClass0_0()
			{
			}

			[Token(Token = "0x600063D")]
			[Address(RVA = "0x117C92C", Offset = "0x117C92C", VA = "0x117C92C")]
			internal float <DOFade>b__0()
			{
				return default(float);
			}

			[Token(Token = "0x600063E")]
			[Address(RVA = "0x117C948", Offset = "0x117C948", VA = "0x117C948")]
			internal void <DOFade>b__1(float x)
			{
			}
		}

		[Token(Token = "0x20000EF")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8CB5DC", Offset = "0x8CB5DC")]
		private sealed class <>c__DisplayClass1_0
		{
			[Token(Token = "0x4000710")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Graphic target;

			[Token(Token = "0x600063F")]
			[Address(RVA = "0x117CBEC", Offset = "0x117CBEC", VA = "0x117CBEC")]
			public <>c__DisplayClass1_0()
			{
			}

			[Token(Token = "0x6000640")]
			[Address(RVA = "0x117CBF4", Offset = "0x117CBF4", VA = "0x117CBF4")]
			internal Color <DOColor>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x6000641")]
			[Address(RVA = "0x117CC18", Offset = "0x117CC18", VA = "0x117CC18")]
			internal void <DOColor>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x20000F0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8CB5EC", Offset = "0x8CB5EC")]
		private sealed class <>c__DisplayClass2_0
		{
			[Token(Token = "0x4000711")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Graphic target;

			[Token(Token = "0x6000642")]
			[Address(RVA = "0x117D000", Offset = "0x117D000", VA = "0x117D000")]
			public <>c__DisplayClass2_0()
			{
			}

			[Token(Token = "0x6000643")]
			[Address(RVA = "0x117D008", Offset = "0x117D008", VA = "0x117D008")]
			internal Color <DOFade>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x6000644")]
			[Address(RVA = "0x117D02C", Offset = "0x117D02C", VA = "0x117D02C")]
			internal void <DOFade>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x20000F1")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8CB5FC", Offset = "0x8CB5FC")]
		private sealed class <>c__DisplayClass3_0
		{
			[Token(Token = "0x4000712")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Image target;

			[Token(Token = "0x6000645")]
			[Address(RVA = "0x117D504", Offset = "0x117D504", VA = "0x117D504")]
			public <>c__DisplayClass3_0()
			{
			}

			[Token(Token = "0x6000646")]
			[Address(RVA = "0x117D50C", Offset = "0x117D50C", VA = "0x117D50C")]
			internal Color <DOColor>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x6000647")]
			[Address(RVA = "0x117D530", Offset = "0x117D530", VA = "0x117D530")]
			internal void <DOColor>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x20000F2")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8CB60C", Offset = "0x8CB60C")]
		private sealed class <>c__DisplayClass4_0
		{
			[Token(Token = "0x4000713")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Image target;

			[Token(Token = "0x6000648")]
			[Address(RVA = "0x117D664", Offset = "0x117D664", VA = "0x117D664")]
			public <>c__DisplayClass4_0()
			{
			}

			[Token(Token = "0x6000649")]
			[Address(RVA = "0x117D66C", Offset = "0x117D66C", VA = "0x117D66C")]
			internal Color <DOFade>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x600064A")]
			[Address(RVA = "0x117D690", Offset = "0x117D690", VA = "0x117D690")]
			internal void <DOFade>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x20000F3")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8CB61C", Offset = "0x8CB61C")]
		private sealed class <>c__DisplayClass5_0
		{
			[Token(Token = "0x4000714")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Image target;

			[Token(Token = "0x600064B")]
			[Address(RVA = "0x117D6B4", Offset = "0x117D6B4", VA = "0x117D6B4")]
			public <>c__DisplayClass5_0()
			{
			}

			[Token(Token = "0x600064C")]
			[Address(RVA = "0x117D6BC", Offset = "0x117D6BC", VA = "0x117D6BC")]
			internal float <DOFillAmount>b__0()
			{
				return default(float);
			}

			[Token(Token = "0x600064D")]
			[Address(RVA = "0x117D6D8", Offset = "0x117D6D8", VA = "0x117D6D8")]
			internal void <DOFillAmount>b__1(float x)
			{
			}
		}

		[Token(Token = "0x20000F4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8CB62C", Offset = "0x8CB62C")]
		private sealed class <>c__DisplayClass7_0
		{
			[Token(Token = "0x4000715")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public LayoutElement target;

			[Token(Token = "0x600064E")]
			[Address(RVA = "0x117D6F4", Offset = "0x117D6F4", VA = "0x117D6F4")]
			public <>c__DisplayClass7_0()
			{
			}

			[Token(Token = "0x600064F")]
			[Address(RVA = "0x117D6FC", Offset = "0x117D6FC", VA = "0x117D6FC")]
			internal Vector2 <DOFlexibleSize>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x6000650")]
			[Address(RVA = "0x117D760", Offset = "0x117D760", VA = "0x117D760")]
			internal void <DOFlexibleSize>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x20000F5")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8CB63C", Offset = "0x8CB63C")]
		private sealed class <>c__DisplayClass8_0
		{
			[Token(Token = "0x4000716")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public LayoutElement target;

			[Token(Token = "0x6000651")]
			[Address(RVA = "0x117D7BC", Offset = "0x117D7BC", VA = "0x117D7BC")]
			public <>c__DisplayClass8_0()
			{
			}

			[Token(Token = "0x6000652")]
			[Address(RVA = "0x117D7C4", Offset = "0x117D7C4", VA = "0x117D7C4")]
			internal Vector2 <DOMinSize>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x6000653")]
			[Address(RVA = "0x117D828", Offset = "0x117D828", VA = "0x117D828")]
			internal void <DOMinSize>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x20000F6")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8CB64C", Offset = "0x8CB64C")]
		private sealed class <>c__DisplayClass9_0
		{
			[Token(Token = "0x4000717")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public LayoutElement target;

			[Token(Token = "0x6000654")]
			[Address(RVA = "0x117D884", Offset = "0x117D884", VA = "0x117D884")]
			public <>c__DisplayClass9_0()
			{
			}

			[Token(Token = "0x6000655")]
			[Address(RVA = "0x117D88C", Offset = "0x117D88C", VA = "0x117D88C")]
			internal Vector2 <DOPreferredSize>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x6000656")]
			[Address(RVA = "0x117D8F0", Offset = "0x117D8F0", VA = "0x117D8F0")]
			internal void <DOPreferredSize>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x20000F7")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8CB65C", Offset = "0x8CB65C")]
		private sealed class <>c__DisplayClass10_0
		{
			[Token(Token = "0x4000718")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Outline target;

			[Token(Token = "0x6000657")]
			[Address(RVA = "0x117C964", Offset = "0x117C964", VA = "0x117C964")]
			public <>c__DisplayClass10_0()
			{
			}

			[Token(Token = "0x6000658")]
			[Address(RVA = "0x117C96C", Offset = "0x117C96C", VA = "0x117C96C")]
			internal Color <DOColor>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x6000659")]
			[Address(RVA = "0x117C98C", Offset = "0x117C98C", VA = "0x117C98C")]
			internal void <DOColor>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x20000F8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8CB66C", Offset = "0x8CB66C")]
		private sealed class <>c__DisplayClass11_0
		{
			[Token(Token = "0x4000719")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Outline target;

			[Token(Token = "0x600065A")]
			[Address(RVA = "0x117C9A8", Offset = "0x117C9A8", VA = "0x117C9A8")]
			public <>c__DisplayClass11_0()
			{
			}

			[Token(Token = "0x600065B")]
			[Address(RVA = "0x117C9B0", Offset = "0x117C9B0", VA = "0x117C9B0")]
			internal Color <DOFade>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x600065C")]
			[Address(RVA = "0x117C9D0", Offset = "0x117C9D0", VA = "0x117C9D0")]
			internal void <DOFade>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x20000F9")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8CB67C", Offset = "0x8CB67C")]
		private sealed class <>c__DisplayClass12_0
		{
			[Token(Token = "0x400071A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Outline target;

			[Token(Token = "0x600065D")]
			[Address(RVA = "0x117C9EC", Offset = "0x117C9EC", VA = "0x117C9EC")]
			public <>c__DisplayClass12_0()
			{
			}

			[Token(Token = "0x600065E")]
			[Address(RVA = "0x117C9F4", Offset = "0x117C9F4", VA = "0x117C9F4")]
			internal Vector2 <DOScale>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x600065F")]
			[Address(RVA = "0x117CA10", Offset = "0x117CA10", VA = "0x117CA10")]
			internal void <DOScale>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x20000FA")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8CB68C", Offset = "0x8CB68C")]
		private sealed class <>c__DisplayClass13_0
		{
			[Token(Token = "0x400071B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x6000660")]
			[Address(RVA = "0x117CA2C", Offset = "0x117CA2C", VA = "0x117CA2C")]
			public <>c__DisplayClass13_0()
			{
			}

			[Token(Token = "0x6000661")]
			[Address(RVA = "0x117CA34", Offset = "0x117CA34", VA = "0x117CA34")]
			internal Vector2 <DOAnchorPos>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x6000662")]
			[Address(RVA = "0x117CA50", Offset = "0x117CA50", VA = "0x117CA50")]
			internal void <DOAnchorPos>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x20000FB")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8CB69C", Offset = "0x8CB69C")]
		private sealed class <>c__DisplayClass14_0
		{
			[Token(Token = "0x400071C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x6000663")]
			[Address(RVA = "0x117CA6C", Offset = "0x117CA6C", VA = "0x117CA6C")]
			public <>c__DisplayClass14_0()
			{
			}

			[Token(Token = "0x6000664")]
			[Address(RVA = "0x117CA74", Offset = "0x117CA74", VA = "0x117CA74")]
			internal Vector2 <DOAnchorPosX>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x6000665")]
			[Address(RVA = "0x117CA90", Offset = "0x117CA90", VA = "0x117CA90")]
			internal void <DOAnchorPosX>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x20000FC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8CB6AC", Offset = "0x8CB6AC")]
		private sealed class <>c__DisplayClass15_0
		{
			[Token(Token = "0x400071D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x6000666")]
			[Address(RVA = "0x117CAAC", Offset = "0x117CAAC", VA = "0x117CAAC")]
			public <>c__DisplayClass15_0()
			{
			}

			[Token(Token = "0x6000667")]
			[Address(RVA = "0x117CAB4", Offset = "0x117CAB4", VA = "0x117CAB4")]
			internal Vector2 <DOAnchorPosY>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x6000668")]
			[Address(RVA = "0x117CAD0", Offset = "0x117CAD0", VA = "0x117CAD0")]
			internal void <DOAnchorPosY>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x20000FD")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8CB6BC", Offset = "0x8CB6BC")]
		private sealed class <>c__DisplayClass16_0
		{
			[Token(Token = "0x400071E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x6000669")]
			[Address(RVA = "0x117CAEC", Offset = "0x117CAEC", VA = "0x117CAEC")]
			public <>c__DisplayClass16_0()
			{
			}

			[Token(Token = "0x600066A")]
			[Address(RVA = "0x117CAF4", Offset = "0x117CAF4", VA = "0x117CAF4")]
			internal Vector3 <DOAnchorPos3D>b__0()
			{
				return default(Vector3);
			}

			[Token(Token = "0x600066B")]
			[Address(RVA = "0x117CB10", Offset = "0x117CB10", VA = "0x117CB10")]
			internal void <DOAnchorPos3D>b__1(Vector3 x)
			{
			}
		}

		[Token(Token = "0x20000FE")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8CB6CC", Offset = "0x8CB6CC")]
		private sealed class <>c__DisplayClass17_0
		{
			[Token(Token = "0x400071F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x600066C")]
			[Address(RVA = "0x117CB2C", Offset = "0x117CB2C", VA = "0x117CB2C")]
			public <>c__DisplayClass17_0()
			{
			}

			[Token(Token = "0x600066D")]
			[Address(RVA = "0x117CB34", Offset = "0x117CB34", VA = "0x117CB34")]
			internal Vector3 <DOAnchorPos3DX>b__0()
			{
				return default(Vector3);
			}

			[Token(Token = "0x600066E")]
			[Address(RVA = "0x117CB50", Offset = "0x117CB50", VA = "0x117CB50")]
			internal void <DOAnchorPos3DX>b__1(Vector3 x)
			{
			}
		}

		[Token(Token = "0x20000FF")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8CB6DC", Offset = "0x8CB6DC")]
		private sealed class <>c__DisplayClass18_0
		{
			[Token(Token = "0x4000720")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x600066F")]
			[Address(RVA = "0x117CB6C", Offset = "0x117CB6C", VA = "0x117CB6C")]
			public <>c__DisplayClass18_0()
			{
			}

			[Token(Token = "0x6000670")]
			[Address(RVA = "0x117CB74", Offset = "0x117CB74", VA = "0x117CB74")]
			internal Vector3 <DOAnchorPos3DY>b__0()
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000671")]
			[Address(RVA = "0x117CB90", Offset = "0x117CB90", VA = "0x117CB90")]
			internal void <DOAnchorPos3DY>b__1(Vector3 x)
			{
			}
		}

		[Token(Token = "0x2000100")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8CB6EC", Offset = "0x8CB6EC")]
		private sealed class <>c__DisplayClass19_0
		{
			[Token(Token = "0x4000721")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x6000672")]
			[Address(RVA = "0x117CBAC", Offset = "0x117CBAC", VA = "0x117CBAC")]
			public <>c__DisplayClass19_0()
			{
			}

			[Token(Token = "0x6000673")]
			[Address(RVA = "0x117CBB4", Offset = "0x117CBB4", VA = "0x117CBB4")]
			internal Vector3 <DOAnchorPos3DZ>b__0()
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000674")]
			[Address(RVA = "0x117CBD0", Offset = "0x117CBD0", VA = "0x117CBD0")]
			internal void <DOAnchorPos3DZ>b__1(Vector3 x)
			{
			}
		}

		[Token(Token = "0x2000101")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8CB6FC", Offset = "0x8CB6FC")]
		private sealed class <>c__DisplayClass20_0
		{
			[Token(Token = "0x4000722")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x6000675")]
			[Address(RVA = "0x117CC3C", Offset = "0x117CC3C", VA = "0x117CC3C")]
			public <>c__DisplayClass20_0()
			{
			}

			[Token(Token = "0x6000676")]
			[Address(RVA = "0x117CC44", Offset = "0x117CC44", VA = "0x117CC44")]
			internal Vector2 <DOAnchorMax>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x6000677")]
			[Address(RVA = "0x117CC60", Offset = "0x117CC60", VA = "0x117CC60")]
			internal void <DOAnchorMax>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x2000102")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8CB70C", Offset = "0x8CB70C")]
		private sealed class <>c__DisplayClass21_0
		{
			[Token(Token = "0x4000723")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x6000678")]
			[Address(RVA = "0x117CC7C", Offset = "0x117CC7C", VA = "0x117CC7C")]
			public <>c__DisplayClass21_0()
			{
			}

			[Token(Token = "0x6000679")]
			[Address(RVA = "0x117CC84", Offset = "0x117CC84", VA = "0x117CC84")]
			internal Vector2 <DOAnchorMin>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x600067A")]
			[Address(RVA = "0x117CCA0", Offset = "0x117CCA0", VA = "0x117CCA0")]
			internal void <DOAnchorMin>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x2000103")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8CB71C", Offset = "0x8CB71C")]
		private sealed class <>c__DisplayClass22_0
		{
			[Token(Token = "0x4000724")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x600067B")]
			[Address(RVA = "0x117CCBC", Offset = "0x117CCBC", VA = "0x117CCBC")]
			public <>c__DisplayClass22_0()
			{
			}

			[Token(Token = "0x600067C")]
			[Address(RVA = "0x117CCC4", Offset = "0x117CCC4", VA = "0x117CCC4")]
			internal Vector2 <DOPivot>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x600067D")]
			[Address(RVA = "0x117CCE0", Offset = "0x117CCE0", VA = "0x117CCE0")]
			internal void <DOPivot>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x2000104")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8CB72C", Offset = "0x8CB72C")]
		private sealed class <>c__DisplayClass23_0
		{
			[Token(Token = "0x4000725")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x600067E")]
			[Address(RVA = "0x117CCFC", Offset = "0x117CCFC", VA = "0x117CCFC")]
			public <>c__DisplayClass23_0()
			{
			}

			[Token(Token = "0x600067F")]
			[Address(RVA = "0x117CD04", Offset = "0x117CD04", VA = "0x117CD04")]
			internal Vector2 <DOPivotX>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x6000680")]
			[Address(RVA = "0x117CD20", Offset = "0x117CD20", VA = "0x117CD20")]
			internal void <DOPivotX>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x2000105")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8CB73C", Offset = "0x8CB73C")]
		private sealed class <>c__DisplayClass24_0
		{
			[Token(Token = "0x4000726")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x6000681")]
			[Address(RVA = "0x117CD3C", Offset = "0x117CD3C", VA = "0x117CD3C")]
			public <>c__DisplayClass24_0()
			{
			}

			[Token(Token = "0x6000682")]
			[Address(RVA = "0x117CD44", Offset = "0x117CD44", VA = "0x117CD44")]
			internal Vector2 <DOPivotY>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x6000683")]
			[Address(RVA = "0x117CD60", Offset = "0x117CD60", VA = "0x117CD60")]
			internal void <DOPivotY>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x2000106")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8CB74C", Offset = "0x8CB74C")]
		private sealed class <>c__DisplayClass25_0
		{
			[Token(Token = "0x4000727")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x6000684")]
			[Address(RVA = "0x117CD7C", Offset = "0x117CD7C", VA = "0x117CD7C")]
			public <>c__DisplayClass25_0()
			{
			}

			[Token(Token = "0x6000685")]
			[Address(RVA = "0x117CD84", Offset = "0x117CD84", VA = "0x117CD84")]
			internal Vector2 <DOSizeDelta>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x6000686")]
			[Address(RVA = "0x117CDA0", Offset = "0x117CDA0", VA = "0x117CDA0")]
			internal void <DOSizeDelta>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x2000107")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8CB75C", Offset = "0x8CB75C")]
		private sealed class <>c__DisplayClass26_0
		{
			[Token(Token = "0x4000728")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x6000687")]
			[Address(RVA = "0x117CDBC", Offset = "0x117CDBC", VA = "0x117CDBC")]
			public <>c__DisplayClass26_0()
			{
			}

			[Token(Token = "0x6000688")]
			[Address(RVA = "0x117CDC4", Offset = "0x117CDC4", VA = "0x117CDC4")]
			internal Vector3 <DOPunchAnchorPos>b__0()
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000689")]
			[Address(RVA = "0x117CDEC", Offset = "0x117CDEC", VA = "0x117CDEC")]
			internal void <DOPunchAnchorPos>b__1(Vector3 x)
			{
			}
		}

		[Token(Token = "0x2000108")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8CB76C", Offset = "0x8CB76C")]
		private sealed class <>c__DisplayClass27_0
		{
			[Token(Token = "0x4000729")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x600068A")]
			[Address(RVA = "0x117CE08", Offset = "0x117CE08", VA = "0x117CE08")]
			public <>c__DisplayClass27_0()
			{
			}

			[Token(Token = "0x600068B")]
			[Address(RVA = "0x117CE10", Offset = "0x117CE10", VA = "0x117CE10")]
			internal Vector3 <DOShakeAnchorPos>b__0()
			{
				return default(Vector3);
			}

			[Token(Token = "0x600068C")]
			[Address(RVA = "0x117CE38", Offset = "0x117CE38", VA = "0x117CE38")]
			internal void <DOShakeAnchorPos>b__1(Vector3 x)
			{
			}
		}

		[Token(Token = "0x2000109")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8CB77C", Offset = "0x8CB77C")]
		private sealed class <>c__DisplayClass28_0
		{
			[Token(Token = "0x400072A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x600068D")]
			[Address(RVA = "0x117CE54", Offset = "0x117CE54", VA = "0x117CE54")]
			public <>c__DisplayClass28_0()
			{
			}

			[Token(Token = "0x600068E")]
			[Address(RVA = "0x117CE5C", Offset = "0x117CE5C", VA = "0x117CE5C")]
			internal Vector3 <DOShakeAnchorPos>b__0()
			{
				return default(Vector3);
			}

			[Token(Token = "0x600068F")]
			[Address(RVA = "0x117CE84", Offset = "0x117CE84", VA = "0x117CE84")]
			internal void <DOShakeAnchorPos>b__1(Vector3 x)
			{
			}
		}

		[Token(Token = "0x200010A")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8CB78C", Offset = "0x8CB78C")]
		private sealed class <>c__DisplayClass29_0
		{
			[Token(Token = "0x400072B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x400072C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float startPosY;

			[Token(Token = "0x400072D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public bool offsetYSet;

			[Token(Token = "0x400072E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float offsetY;

			[Token(Token = "0x400072F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Sequence s;

			[Token(Token = "0x4000730")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Vector2 endValue;

			[Token(Token = "0x6000690")]
			[Address(RVA = "0x117CEA0", Offset = "0x117CEA0", VA = "0x117CEA0")]
			public <>c__DisplayClass29_0()
			{
			}

			[Token(Token = "0x6000691")]
			[Address(RVA = "0x117CEA8", Offset = "0x117CEA8", VA = "0x117CEA8")]
			internal Vector2 <DOJumpAnchorPos>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x6000692")]
			[Address(RVA = "0x117CEC4", Offset = "0x117CEC4", VA = "0x117CEC4")]
			internal void <DOJumpAnchorPos>b__1(Vector2 x)
			{
			}

			[Token(Token = "0x6000693")]
			[Address(RVA = "0x117CEE0", Offset = "0x117CEE0", VA = "0x117CEE0")]
			internal void <DOJumpAnchorPos>b__2()
			{
			}

			[Token(Token = "0x6000694")]
			[Address(RVA = "0x117CF14", Offset = "0x117CF14", VA = "0x117CF14")]
			internal Vector2 <DOJumpAnchorPos>b__3()
			{
				return default(Vector2);
			}

			[Token(Token = "0x6000695")]
			[Address(RVA = "0x117CF30", Offset = "0x117CF30", VA = "0x117CF30")]
			internal void <DOJumpAnchorPos>b__4(Vector2 x)
			{
			}

			[Token(Token = "0x6000696")]
			[Address(RVA = "0x117CF4C", Offset = "0x117CF4C", VA = "0x117CF4C")]
			internal void <DOJumpAnchorPos>b__5()
			{
			}
		}

		[Token(Token = "0x200010B")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8CB79C", Offset = "0x8CB79C")]
		private sealed class <>c__DisplayClass30_0
		{
			[Token(Token = "0x4000731")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public ScrollRect target;

			[Token(Token = "0x6000697")]
			[Address(RVA = "0x117D050", Offset = "0x117D050", VA = "0x117D050")]
			public <>c__DisplayClass30_0()
			{
			}

			[Token(Token = "0x6000698")]
			[Address(RVA = "0x117D058", Offset = "0x117D058", VA = "0x117D058")]
			internal Vector2 <DONormalizedPos>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x6000699")]
			[Address(RVA = "0x117D0AC", Offset = "0x117D0AC", VA = "0x117D0AC")]
			internal void <DONormalizedPos>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x200010C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8CB7AC", Offset = "0x8CB7AC")]
		private sealed class <>c__DisplayClass31_0
		{
			[Token(Token = "0x4000732")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public ScrollRect target;

			[Token(Token = "0x600069A")]
			[Address(RVA = "0x117D0F8", Offset = "0x117D0F8", VA = "0x117D0F8")]
			public <>c__DisplayClass31_0()
			{
			}

			[Token(Token = "0x600069B")]
			[Address(RVA = "0x117D100", Offset = "0x117D100", VA = "0x117D100")]
			internal float <DOHorizontalNormalizedPos>b__0()
			{
				return default(float);
			}

			[Token(Token = "0x600069C")]
			[Address(RVA = "0x117D11C", Offset = "0x117D11C", VA = "0x117D11C")]
			internal void <DOHorizontalNormalizedPos>b__1(float x)
			{
			}
		}

		[Token(Token = "0x200010D")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8CB7BC", Offset = "0x8CB7BC")]
		private sealed class <>c__DisplayClass32_0
		{
			[Token(Token = "0x4000733")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public ScrollRect target;

			[Token(Token = "0x600069D")]
			[Address(RVA = "0x117D138", Offset = "0x117D138", VA = "0x117D138")]
			public <>c__DisplayClass32_0()
			{
			}

			[Token(Token = "0x600069E")]
			[Address(RVA = "0x117D140", Offset = "0x117D140", VA = "0x117D140")]
			internal float <DOVerticalNormalizedPos>b__0()
			{
				return default(float);
			}

			[Token(Token = "0x600069F")]
			[Address(RVA = "0x117D15C", Offset = "0x117D15C", VA = "0x117D15C")]
			internal void <DOVerticalNormalizedPos>b__1(float x)
			{
			}
		}

		[Token(Token = "0x200010E")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8CB7CC", Offset = "0x8CB7CC")]
		private sealed class <>c__DisplayClass33_0
		{
			[Token(Token = "0x4000734")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Slider target;

			[Token(Token = "0x60006A0")]
			[Address(RVA = "0x117D178", Offset = "0x117D178", VA = "0x117D178")]
			public <>c__DisplayClass33_0()
			{
			}

			[Token(Token = "0x60006A1")]
			[Address(RVA = "0x117D180", Offset = "0x117D180", VA = "0x117D180")]
			internal float <DOValue>b__0()
			{
				return default(float);
			}

			[Token(Token = "0x60006A2")]
			[Address(RVA = "0x117D1A4", Offset = "0x117D1A4", VA = "0x117D1A4")]
			internal void <DOValue>b__1(float x)
			{
			}
		}

		[Token(Token = "0x200010F")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8CB7DC", Offset = "0x8CB7DC")]
		private sealed class <>c__DisplayClass34_0
		{
			[Token(Token = "0x4000735")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Text target;

			[Token(Token = "0x60006A3")]
			[Address(RVA = "0x117D1C8", Offset = "0x117D1C8", VA = "0x117D1C8")]
			public <>c__DisplayClass34_0()
			{
			}

			[Token(Token = "0x60006A4")]
			[Address(RVA = "0x117D1D0", Offset = "0x117D1D0", VA = "0x117D1D0")]
			internal Color <DOColor>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x60006A5")]
			[Address(RVA = "0x117D1F4", Offset = "0x117D1F4", VA = "0x117D1F4")]
			internal void <DOColor>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x2000110")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8CB7EC", Offset = "0x8CB7EC")]
		private sealed class <>c__DisplayClass35_0
		{
			[Token(Token = "0x4000736")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public int v;

			[Token(Token = "0x4000737")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Text target;

			[Token(Token = "0x4000738")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public bool addThousandsSeparator;

			[Token(Token = "0x4000739")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public CultureInfo cInfo;

			[Token(Token = "0x60006A6")]
			[Address(RVA = "0x117D218", Offset = "0x117D218", VA = "0x117D218")]
			public <>c__DisplayClass35_0()
			{
			}

			[Token(Token = "0x60006A7")]
			[Address(RVA = "0x117D220", Offset = "0x117D220", VA = "0x117D220")]
			internal int <DOCounter>b__0()
			{
				return default(int);
			}

			[Token(Token = "0x60006A8")]
			[Address(RVA = "0x117D228", Offset = "0x117D228", VA = "0x117D228")]
			internal void <DOCounter>b__1(int x)
			{
			}
		}

		[Token(Token = "0x2000111")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8CB7FC", Offset = "0x8CB7FC")]
		private sealed class <>c__DisplayClass36_0
		{
			[Token(Token = "0x400073A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Text target;

			[Token(Token = "0x60006A9")]
			[Address(RVA = "0x117D2C4", Offset = "0x117D2C4", VA = "0x117D2C4")]
			public <>c__DisplayClass36_0()
			{
			}

			[Token(Token = "0x60006AA")]
			[Address(RVA = "0x117D2CC", Offset = "0x117D2CC", VA = "0x117D2CC")]
			internal Color <DOFade>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x60006AB")]
			[Address(RVA = "0x117D2F0", Offset = "0x117D2F0", VA = "0x117D2F0")]
			internal void <DOFade>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x2000112")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8CB80C", Offset = "0x8CB80C")]
		private sealed class <>c__DisplayClass37_0
		{
			[Token(Token = "0x400073B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Text target;

			[Token(Token = "0x60006AC")]
			[Address(RVA = "0x117D314", Offset = "0x117D314", VA = "0x117D314")]
			public <>c__DisplayClass37_0()
			{
			}

			[Token(Token = "0x60006AD")]
			[Address(RVA = "0x117D31C", Offset = "0x117D31C", VA = "0x117D31C")]
			internal string <DOText>b__0()
			{
				return null;
			}

			[Token(Token = "0x60006AE")]
			[Address(RVA = "0x117D340", Offset = "0x117D340", VA = "0x117D340")]
			internal void <DOText>b__1(string x)
			{
			}
		}

		[Token(Token = "0x2000113")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8CB81C", Offset = "0x8CB81C")]
		private sealed class <>c__DisplayClass38_0
		{
			[Token(Token = "0x400073C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Color to;

			[Token(Token = "0x400073D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Graphic target;

			[Token(Token = "0x60006AF")]
			[Address(RVA = "0x117D364", Offset = "0x117D364", VA = "0x117D364")]
			public <>c__DisplayClass38_0()
			{
			}

			[Token(Token = "0x60006B0")]
			[Address(RVA = "0x117D36C", Offset = "0x117D36C", VA = "0x117D36C")]
			internal Color <DOBlendableColor>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x60006B1")]
			[Address(RVA = "0x117D378", Offset = "0x117D378", VA = "0x117D378")]
			internal void <DOBlendableColor>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x2000114")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8CB82C", Offset = "0x8CB82C")]
		private sealed class <>c__DisplayClass39_0
		{
			[Token(Token = "0x400073E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Color to;

			[Token(Token = "0x400073F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Image target;

			[Token(Token = "0x60006B2")]
			[Address(RVA = "0x117D434", Offset = "0x117D434", VA = "0x117D434")]
			public <>c__DisplayClass39_0()
			{
			}

			[Token(Token = "0x60006B3")]
			[Address(RVA = "0x117D43C", Offset = "0x117D43C", VA = "0x117D43C")]
			internal Color <DOBlendableColor>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x60006B4")]
			[Address(RVA = "0x117D448", Offset = "0x117D448", VA = "0x117D448")]
			internal void <DOBlendableColor>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x2000115")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8CB83C", Offset = "0x8CB83C")]
		private sealed class <>c__DisplayClass40_0
		{
			[Token(Token = "0x4000740")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Color to;

			[Token(Token = "0x4000741")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Text target;

			[Token(Token = "0x60006B5")]
			[Address(RVA = "0x117D554", Offset = "0x117D554", VA = "0x117D554")]
			public <>c__DisplayClass40_0()
			{
			}

			[Token(Token = "0x60006B6")]
			[Address(RVA = "0x117D55C", Offset = "0x117D55C", VA = "0x117D55C")]
			internal Color <DOBlendableColor>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x60006B7")]
			[Address(RVA = "0x117D568", Offset = "0x117D568", VA = "0x117D568")]
			internal void <DOBlendableColor>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x2000116")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8CB84C", Offset = "0x8CB84C")]
		private sealed class <>c__DisplayClass41_0
		{
			[Token(Token = "0x4000742")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x60006B8")]
			[Address(RVA = "0x117D624", Offset = "0x117D624", VA = "0x117D624")]
			public <>c__DisplayClass41_0()
			{
			}

			[Token(Token = "0x60006B9")]
			[Address(RVA = "0x117D62C", Offset = "0x117D62C", VA = "0x117D62C")]
			internal Vector2 <DOShapeCircle>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x60006BA")]
			[Address(RVA = "0x117D648", Offset = "0x117D648", VA = "0x117D648")]
			internal void <DOShapeCircle>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x6000611")]
		[Address(RVA = "0x11D82B0", Offset = "0x11D82B0", VA = "0x11D82B0")]
		public static TweenerCore<float, float, FloatOptions> DOFade(this CanvasGroup target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000612")]
		[Address(RVA = "0x11D8458", Offset = "0x11D8458", VA = "0x11D8458")]
		public static TweenerCore<Color, Color, ColorOptions> DOColor(this Graphic target, Color endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000613")]
		[Address(RVA = "0x11D8628", Offset = "0x11D8628", VA = "0x11D8628")]
		public static TweenerCore<Color, Color, ColorOptions> DOFade(this Graphic target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000614")]
		[Address(RVA = "0x11D87D0", Offset = "0x11D87D0", VA = "0x11D87D0")]
		public static TweenerCore<Color, Color, ColorOptions> DOColor(this Image target, Color endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000615")]
		[Address(RVA = "0x11D89A0", Offset = "0x11D89A0", VA = "0x11D89A0")]
		public static TweenerCore<Color, Color, ColorOptions> DOFade(this Image target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000616")]
		[Address(RVA = "0x11D8B48", Offset = "0x11D8B48", VA = "0x11D8B48")]
		public static TweenerCore<float, float, FloatOptions> DOFillAmount(this Image target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000617")]
		[Address(RVA = "0x11D8D14", Offset = "0x11D8D14", VA = "0x11D8D14")]
		public static Sequence DOGradientColor(this Image target, Gradient gradient, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000618")]
		[Address(RVA = "0x11D8F08", Offset = "0x11D8F08", VA = "0x11D8F08")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOFlexibleSize(this LayoutElement target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000619")]
		[Address(RVA = "0x11D90D8", Offset = "0x11D90D8", VA = "0x11D90D8")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOMinSize(this LayoutElement target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x600061A")]
		[Address(RVA = "0x11D92A8", Offset = "0x11D92A8", VA = "0x11D92A8")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOPreferredSize(this LayoutElement target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x600061B")]
		[Address(RVA = "0x11D9478", Offset = "0x11D9478", VA = "0x11D9478")]
		public static TweenerCore<Color, Color, ColorOptions> DOColor(this Outline target, Color endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x600061C")]
		[Address(RVA = "0x11D9648", Offset = "0x11D9648", VA = "0x11D9648")]
		public static TweenerCore<Color, Color, ColorOptions> DOFade(this Outline target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x600061D")]
		[Address(RVA = "0x11D97F0", Offset = "0x11D97F0", VA = "0x11D97F0")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOScale(this Outline target, Vector2 endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x600061E")]
		[Address(RVA = "0x11D99A8", Offset = "0x11D99A8", VA = "0x11D99A8")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOAnchorPos(this RectTransform target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x600061F")]
		[Address(RVA = "0x11D9B78", Offset = "0x11D9B78", VA = "0x11D9B78")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOAnchorPosX(this RectTransform target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000620")]
		[Address(RVA = "0x11D9D40", Offset = "0x11D9D40", VA = "0x11D9D40")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOAnchorPosY(this RectTransform target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000621")]
		[Address(RVA = "0x11D9F08", Offset = "0x11D9F08", VA = "0x11D9F08")]
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOAnchorPos3D(this RectTransform target, Vector3 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000622")]
		[Address(RVA = "0x11DA0E0", Offset = "0x11DA0E0", VA = "0x11DA0E0")]
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOAnchorPos3DX(this RectTransform target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000623")]
		[Address(RVA = "0x11DA2AC", Offset = "0x11DA2AC", VA = "0x11DA2AC")]
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOAnchorPos3DY(this RectTransform target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000624")]
		[Address(RVA = "0x11DA478", Offset = "0x11DA478", VA = "0x11DA478")]
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOAnchorPos3DZ(this RectTransform target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000625")]
		[Address(RVA = "0x11DA644", Offset = "0x11DA644", VA = "0x11DA644")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOAnchorMax(this RectTransform target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000626")]
		[Address(RVA = "0x11DA814", Offset = "0x11DA814", VA = "0x11DA814")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOAnchorMin(this RectTransform target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000627")]
		[Address(RVA = "0x11DA9E4", Offset = "0x11DA9E4", VA = "0x11DA9E4")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOPivot(this RectTransform target, Vector2 endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000628")]
		[Address(RVA = "0x11DAB9C", Offset = "0x11DAB9C", VA = "0x11DAB9C")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOPivotX(this RectTransform target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000629")]
		[Address(RVA = "0x11DAD58", Offset = "0x11DAD58", VA = "0x11DAD58")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOPivotY(this RectTransform target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x600062A")]
		[Address(RVA = "0x11DAF14", Offset = "0x11DAF14", VA = "0x11DAF14")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOSizeDelta(this RectTransform target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x600062B")]
		[Address(RVA = "0x11DB0E4", Offset = "0x11DB0E4", VA = "0x11DB0E4")]
		public static Tweener DOPunchAnchorPos(this RectTransform target, Vector2 punch, float duration, int vibrato = 10, float elasticity = 1f, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x600062C")]
		[Address(RVA = "0x11DB2BC", Offset = "0x11DB2BC", VA = "0x11DB2BC")]
		public static Tweener DOShakeAnchorPos(this RectTransform target, float duration, float strength = 100f, int vibrato = 10, float randomness = 90f, bool snapping = false, bool fadeOut = true)
		{
			return null;
		}

		[Token(Token = "0x600062D")]
		[Address(RVA = "0x11DB4BC", Offset = "0x11DB4BC", VA = "0x11DB4BC")]
		public static Tweener DOShakeAnchorPos(this RectTransform target, float duration, Vector2 strength, int vibrato = 10, float randomness = 90f, bool snapping = false, bool fadeOut = true)
		{
			return null;
		}

		[Token(Token = "0x600062E")]
		[Address(RVA = "0x11DB6C4", Offset = "0x11DB6C4", VA = "0x11DB6C4")]
		public static Sequence DOJumpAnchorPos(this RectTransform target, Vector2 endValue, float jumpPower, int numJumps, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x600062F")]
		[Address(RVA = "0x11DBB18", Offset = "0x11DBB18", VA = "0x11DBB18")]
		public static Tweener DONormalizedPos(this ScrollRect target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000630")]
		[Address(RVA = "0x11DBCDC", Offset = "0x11DBCDC", VA = "0x11DBCDC")]
		public static Tweener DOHorizontalNormalizedPos(this ScrollRect target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000631")]
		[Address(RVA = "0x11DBE90", Offset = "0x11DBE90", VA = "0x11DBE90")]
		public static Tweener DOVerticalNormalizedPos(this ScrollRect target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000632")]
		[Address(RVA = "0x11DC044", Offset = "0x11DC044", VA = "0x11DC044")]
		public static TweenerCore<float, float, FloatOptions> DOValue(this Slider target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000633")]
		[Address(RVA = "0x11DC204", Offset = "0x11DC204", VA = "0x11DC204")]
		public static TweenerCore<Color, Color, ColorOptions> DOColor(this Text target, Color endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000634")]
		[Address(RVA = "0x11DC3D4", Offset = "0x11DC3D4", VA = "0x11DC3D4")]
		public static TweenerCore<int, int, NoOptions> DOCounter(this Text target, int fromValue, int endValue, float duration, bool addThousandsSeparator = true, [Optional] CultureInfo culture)
		{
			return null;
		}

		[Token(Token = "0x6000635")]
		[Address(RVA = "0x11DC5FC", Offset = "0x11DC5FC", VA = "0x11DC5FC")]
		public static TweenerCore<Color, Color, ColorOptions> DOFade(this Text target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000636")]
		[Address(RVA = "0x11DC7A4", Offset = "0x11DC7A4", VA = "0x11DC7A4")]
		public static TweenerCore<string, string, StringOptions> DOText(this Text target, string endValue, float duration, bool richTextEnabled = true, ScrambleMode scrambleMode = ScrambleMode.None, [Optional] string scrambleChars)
		{
			return null;
		}

		[Token(Token = "0x6000637")]
		[Address(RVA = "0x11DC9F8", Offset = "0x11DC9F8", VA = "0x11DC9F8")]
		public static Tweener DOBlendableColor(this Graphic target, Color endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000638")]
		[Address(RVA = "0x11DCC5C", Offset = "0x11DCC5C", VA = "0x11DCC5C")]
		public static Tweener DOBlendableColor(this Image target, Color endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000639")]
		[Address(RVA = "0x11DCEC0", Offset = "0x11DCEC0", VA = "0x11DCEC0")]
		public static Tweener DOBlendableColor(this Text target, Color endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x600063A")]
		[Address(RVA = "0x11DD124", Offset = "0x11DD124", VA = "0x11DD124")]
		public static TweenerCore<Vector2, Vector2, CircleOptions> DOShapeCircle(this RectTransform target, Vector2 center, float endValueDegrees, float duration, bool relativeCenter = false, bool snapping = false)
		{
			return null;
		}
	}
	[Token(Token = "0x2000117")]
	public static class DOTweenModuleUnityVersion
	{
		[Token(Token = "0x2000118")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8CB86C", Offset = "0x8CB86C")]
		private sealed class <>c__DisplayClass8_0
		{
			[Token(Token = "0x4000743")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Material target;

			[Token(Token = "0x4000744")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public int propertyID;

			[Token(Token = "0x60006CB")]
			[Address(RVA = "0x117DB90", Offset = "0x117DB90", VA = "0x117DB90")]
			public <>c__DisplayClass8_0()
			{
			}

			[Token(Token = "0x60006CC")]
			[Address(RVA = "0x117DB98", Offset = "0x117DB98", VA = "0x117DB98")]
			internal Vector2 <DOOffset>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x60006CD")]
			[Address(RVA = "0x117DBBC", Offset = "0x117DBBC", VA = "0x117DBBC")]
			internal void <DOOffset>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x2000119")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8CB87C", Offset = "0x8CB87C")]
		private sealed class <>c__DisplayClass9_0
		{
			[Token(Token = "0x4000745")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Material target;

			[Token(Token = "0x4000746")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public int propertyID;

			[Token(Token = "0x60006CE")]
			[Address(RVA = "0x117DBE0", Offset = "0x117DBE0", VA = "0x117DBE0")]
			public <>c__DisplayClass9_0()
			{
			}

			[Token(Token = "0x60006CF")]
			[Address(RVA = "0x117DBE8", Offset = "0x117DBE8", VA = "0x117DBE8")]
			internal Vector2 <DOTiling>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x60006D0")]
			[Address(RVA = "0x117DC0C", Offset = "0x117DC0C", VA = "0x117DC0C")]
			internal void <DOTiling>b__1(Vector2 x)
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x200011A")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8CB88C", Offset = "0x8CB88C")]
		private struct <AsyncWaitForCompletion>d__10 : IAsyncStateMachine
		{
			[Token(Token = "0x4000747")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x4000748")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Token(Token = "0x4000749")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Tween t;

			[Token(Token = "0x400074A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private YieldAwaitable.YieldAwaiter <>u__1;

			[Token(Token = "0x60006D1")]
			[Address(RVA = "0x117DC30", Offset = "0x117DC30", VA = "0x117DC30", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x60006D2")]
			[Address(RVA = "0x117DE74", Offset = "0x117DE74", VA = "0x117DE74", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x200011B")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8CB89C", Offset = "0x8CB89C")]
		private struct <AsyncWaitForRewind>d__11 : IAsyncStateMachine
		{
			[Token(Token = "0x400074B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x400074C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Token(Token = "0x400074D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Tween t;

			[Token(Token = "0x400074E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private YieldAwaitable.YieldAwaiter <>u__1;

			[Token(Token = "0x60006D3")]
			[Address(RVA = "0x117E584", Offset = "0x117E584", VA = "0x117E584", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x60006D4")]
			[Address(RVA = "0x117E7EC", Offset = "0x117E7EC", VA = "0x117E7EC", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x200011C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8CB8AC", Offset = "0x8CB8AC")]
		private struct <AsyncWaitForKill>d__12 : IAsyncStateMachine
		{
			[Token(Token = "0x400074F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x4000750")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Token(Token = "0x4000751")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Tween t;

			[Token(Token = "0x4000752")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private YieldAwaitable.YieldAwaiter <>u__1;

			[Token(Token = "0x60006D5")]
			[Address(RVA = "0x117E0D8", Offset = "0x117E0D8", VA = "0x117E0D8", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x60006D6")]
			[Address(RVA = "0x117E308", Offset = "0x117E308", VA = "0x117E308", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x200011D")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8CB8BC", Offset = "0x8CB8BC")]
		private struct <AsyncWaitForElapsedLoops>d__13 : IAsyncStateMachine
		{
			[Token(Token = "0x4000753")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x4000754")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Token(Token = "0x4000755")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Tween t;

			[Token(Token = "0x4000756")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public int elapsedLoops;

			[Token(Token = "0x4000757")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			private YieldAwaitable.YieldAwaiter <>u__1;

			[Token(Token = "0x60006D7")]
			[Address(RVA = "0x117DE80", Offset = "0x117DE80", VA = "0x117DE80", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x60006D8")]
			[Address(RVA = "0x117E0CC", Offset = "0x117E0CC", VA = "0x117E0CC", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x200011E")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8CB8CC", Offset = "0x8CB8CC")]
		private struct <AsyncWaitForPosition>d__14 : IAsyncStateMachine
		{
			[Token(Token = "0x4000758")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x4000759")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Token(Token = "0x400075A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Tween t;

			[Token(Token = "0x400075B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public float position;

			[Token(Token = "0x400075C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			private YieldAwaitable.YieldAwaiter <>u__1;

			[Token(Token = "0x60006D9")]
			[Address(RVA = "0x117E314", Offset = "0x117E314", VA = "0x117E314", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x60006DA")]
			[Address(RVA = "0x117E578", Offset = "0x117E578", VA = "0x117E578", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x200011F")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8CB8DC", Offset = "0x8CB8DC")]
		private struct <AsyncWaitForStart>d__15 : IAsyncStateMachine
		{
			[Token(Token = "0x400075D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x400075E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Token(Token = "0x400075F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Tween t;

			[Token(Token = "0x4000760")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private YieldAwaitable.YieldAwaiter <>u__1;

			[Token(Token = "0x60006DB")]
			[Address(RVA = "0x117E7F8", Offset = "0x117E7F8", VA = "0x117E7F8", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x60006DC")]
			[Address(RVA = "0x117EA30", Offset = "0x117EA30", VA = "0x117EA30", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x60006BB")]
		[Address(RVA = "0x11DD334", Offset = "0x11DD334", VA = "0x11DD334")]
		public static Sequence DOGradientColor(this Material target, Gradient gradient, float duration)
		{
			return null;
		}

		[Token(Token = "0x60006BC")]
		[Address(RVA = "0x11DD524", Offset = "0x11DD524", VA = "0x11DD524")]
		public static Sequence DOGradientColor(this Material target, Gradient gradient, string property, float duration)
		{
			return null;
		}

		[Token(Token = "0x60006BD")]
		[Address(RVA = "0x11DD728", Offset = "0x11DD728", VA = "0x11DD728")]
		public static CustomYieldInstruction WaitForCompletion(this Tween t, bool returnCustomYieldInstruction)
		{
			return null;
		}

		[Token(Token = "0x60006BE")]
		[Address(RVA = "0x11DD7E8", Offset = "0x11DD7E8", VA = "0x11DD7E8")]
		public static CustomYieldInstruction WaitForRewind(this Tween t, bool returnCustomYieldInstruction)
		{
			return null;
		}

		[Token(Token = "0x60006BF")]
		[Address(RVA = "0x11DD8A8", Offset = "0x11DD8A8", VA = "0x11DD8A8")]
		public static CustomYieldInstruction WaitForKill(this Tween t, bool returnCustomYieldInstruction)
		{
			return null;
		}

		[Token(Token = "0x60006C0")]
		[Address(RVA = "0x11DD968", Offset = "0x11DD968", VA = "0x11DD968")]
		public static CustomYieldInstruction WaitForElapsedLoops(this Tween t, int elapsedLoops, bool returnCustomYieldInstruction)
		{
			return null;
		}

		[Token(Token = "0x60006C1")]
		[Address(RVA = "0x11DDA38", Offset = "0x11DDA38", VA = "0x11DDA38")]
		public static CustomYieldInstruction WaitForPosition(this Tween t, float position, bool returnCustomYieldInstruction)
		{
			return null;
		}

		[Token(Token = "0x60006C2")]
		[Address(RVA = "0x11DDB08", Offset = "0x11DDB08", VA = "0x11DDB08")]
		public static CustomYieldInstruction WaitForStart(this Tween t, bool returnCustomYieldInstruction)
		{
			return null;
		}

		[Token(Token = "0x60006C3")]
		[Address(RVA = "0x11DDBC8", Offset = "0x11DDBC8", VA = "0x11DDBC8")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOOffset(this Material target, Vector2 endValue, int propertyID, float duration)
		{
			return null;
		}

		[Token(Token = "0x60006C4")]
		[Address(RVA = "0x11DDDF0", Offset = "0x11DDDF0", VA = "0x11DDDF0")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOTiling(this Material target, Vector2 endValue, int propertyID, float duration)
		{
			return null;
		}

		[Token(Token = "0x60006C5")]
		[Address(RVA = "0x11DE018", Offset = "0x11DE018", VA = "0x11DE018")]
		[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0x8D30F4", Offset = "0x8D30F4")]
		public static Task AsyncWaitForCompletion(this Tween t)
		{
			return null;
		}

		[Token(Token = "0x60006C6")]
		[Address(RVA = "0x11DE134", Offset = "0x11DE134", VA = "0x11DE134")]
		[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0x8D3164", Offset = "0x8D3164")]
		public static Task AsyncWaitForRewind(this Tween t)
		{
			return null;
		}

		[Token(Token = "0x60006C7")]
		[Address(RVA = "0x11DE250", Offset = "0x11DE250", VA = "0x11DE250")]
		[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0x8D31D4", Offset = "0x8D31D4")]
		public static Task AsyncWaitForKill(this Tween t)
		{
			return null;
		}

		[Token(Token = "0x60006C8")]
		[Address(RVA = "0x11DE36C", Offset = "0x11DE36C", VA = "0x11DE36C")]
		[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0x8D3244", Offset = "0x8D3244")]
		public static Task AsyncWaitForElapsedLoops(this Tween t, int elapsedLoops)
		{
			return null;
		}

		[Token(Token = "0x60006C9")]
		[Address(RVA = "0x11DE498", Offset = "0x11DE498", VA = "0x11DE498")]
		[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0x8D32B4", Offset = "0x8D32B4")]
		public static Task AsyncWaitForPosition(this Tween t, float position)
		{
			return null;
		}

		[Token(Token = "0x60006CA")]
		[Address(RVA = "0x11DE5C4", Offset = "0x11DE5C4", VA = "0x11DE5C4")]
		[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0x8D3324", Offset = "0x8D3324")]
		public static Task AsyncWaitForStart(this Tween t)
		{
			return null;
		}
	}
	[Token(Token = "0x2000120")]
	public static class DOTweenCYInstruction
	{
		[Token(Token = "0x2000121")]
		public class WaitForCompletion : CustomYieldInstruction
		{
			[Token(Token = "0x4000761")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private readonly Tween t;

			[Token(Token = "0x170000B4")]
			public override bool keepWaiting
			{
				[Token(Token = "0x60006DD")]
				[Address(RVA = "0x117BA84", Offset = "0x117BA84", VA = "0x117BA84", Slot = "7")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x60006DE")]
			[Address(RVA = "0x117BAB8", Offset = "0x117BAB8", VA = "0x117BAB8")]
			public WaitForCompletion(Tween tween)
			{
			}
		}

		[Token(Token = "0x2000122")]
		public class WaitForRewind : CustomYieldInstruction
		{
			[Token(Token = "0x4000762")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private readonly Tween t;

			[Token(Token = "0x170000B5")]
			public override bool keepWaiting
			{
				[Token(Token = "0x60006DF")]
				[Address(RVA = "0x117BC7C", Offset = "0x117BC7C", VA = "0x117BC7C", Slot = "7")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x60006E0")]
			[Address(RVA = "0x117BCE0", Offset = "0x117BCE0", VA = "0x117BCE0")]
			public WaitForRewind(Tween tween)
			{
			}
		}

		[Token(Token = "0x2000123")]
		public class WaitForKill : CustomYieldInstruction
		{
			[Token(Token = "0x4000763")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private readonly Tween t;

			[Token(Token = "0x170000B6")]
			public override bool keepWaiting
			{
				[Token(Token = "0x60006E1")]
				[Address(RVA = "0x117BB80", Offset = "0x117BB80", VA = "0x117BB80", Slot = "7")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x60006E2")]
			[Address(RVA = "0x117BB9C", Offset = "0x117BB9C", VA = "0x117BB9C")]
			public WaitForKill(Tween tween)
			{
			}
		}

		[Token(Token = "0x2000124")]
		public class WaitForElapsedLoops : CustomYieldInstruction
		{
			[Token(Token = "0x4000764")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private readonly Tween t;

			[Token(Token = "0x4000765")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private readonly int elapsedLoops;

			[Token(Token = "0x170000B7")]
			public override bool keepWaiting
			{
				[Token(Token = "0x60006E3")]
				[Address(RVA = "0x117BAEC", Offset = "0x117BAEC", VA = "0x117BAEC", Slot = "7")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x60006E4")]
			[Address(RVA = "0x117BB38", Offset = "0x117BB38", VA = "0x117BB38")]
			public WaitForElapsedLoops(Tween tween, int elapsedLoops)
			{
			}
		}

		[Token(Token = "0x2000125")]
		public class WaitForPosition : CustomYieldInstruction
		{
			[Token(Token = "0x4000766")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private readonly Tween t;

			[Token(Token = "0x4000767")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private readonly float position;

			[Token(Token = "0x170000B8")]
			public override bool keepWaiting
			{
				[Token(Token = "0x60006E5")]
				[Address(RVA = "0x117BBD0", Offset = "0x117BBD0", VA = "0x117BBD0", Slot = "7")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x60006E6")]
			[Address(RVA = "0x117BC34", Offset = "0x117BC34", VA = "0x117BC34")]
			public WaitForPosition(Tween tween, float position)
			{
			}
		}

		[Token(Token = "0x2000126")]
		public class WaitForStart : CustomYieldInstruction
		{
			[Token(Token = "0x4000768")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private readonly Tween t;

			[Token(Token = "0x170000B9")]
			public override bool keepWaiting
			{
				[Token(Token = "0x60006E7")]
				[Address(RVA = "0x117BD14", Offset = "0x117BD14", VA = "0x117BD14", Slot = "7")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x60006E8")]
			[Address(RVA = "0x117BD48", Offset = "0x117BD48", VA = "0x117BD48")]
			public WaitForStart(Tween tween)
			{
			}
		}
	}
	[Token(Token = "0x2000127")]
	public static class DOTweenModuleUtils
	{
		[Token(Token = "0x2000128")]
		public static class Physics
		{
			[Token(Token = "0x60006EB")]
			[Address(RVA = "0x117EA3C", Offset = "0x117EA3C", VA = "0x117EA3C")]
			public static void SetOrientationOnPath(PathOptions options, Tween t, Quaternion newRot, Transform trans)
			{
			}

			[Token(Token = "0x60006EC")]
			[Address(RVA = "0x117EB40", Offset = "0x117EB40", VA = "0x117EB40")]
			public static bool HasRigidbody2D(Component target)
			{
				return default(bool);
			}

			[Token(Token = "0x60006ED")]
			[Address(RVA = "0x117EBD8", Offset = "0x117EBD8", VA = "0x117EBD8")]
			[Preserve]
			public static bool HasRigidbody(Component target)
			{
				return default(bool);
			}

			[Token(Token = "0x60006EE")]
			[Address(RVA = "0x117EC70", Offset = "0x117EC70", VA = "0x117EC70")]
			[Preserve]
			public static TweenerCore<Vector3, Path, PathOptions> CreateDOTweenPathTween(MonoBehaviour target, bool tweenRigidbody, bool isLocal, Path path, float duration, PathMode pathMode)
			{
				return null;
			}
		}

		[Token(Token = "0x4000769")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static bool _initialized;

		[Token(Token = "0x60006E9")]
		[Address(RVA = "0x11DE6E0", Offset = "0x11DE6E0", VA = "0x11DE6E0")]
		[Preserve]
		public static void Init()
		{
		}

		[Token(Token = "0x60006EA")]
		[Address(RVA = "0x11DE7A4", Offset = "0x11DE7A4", VA = "0x11DE7A4")]
		[Preserve]
		private static void Preserver()
		{
		}
	}
}
namespace UnityEngine.Timeline
{
	[Token(Token = "0x2000129")]
	public class VideoPlayableBehaviour : PlayableBehaviour
	{
		[Token(Token = "0x400076A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public VideoPlayer videoPlayer;

		[Token(Token = "0x400076B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public VideoClip videoClip;

		[Token(Token = "0x400076C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool mute;

		[Token(Token = "0x400076D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
		public bool loop;

		[Token(Token = "0x400076E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public double preloadTime;

		[Token(Token = "0x400076F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public double clipInTime;

		[Token(Token = "0x4000770")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private bool playedOnce;

		[Token(Token = "0x4000771")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x39")]
		private bool preparing;

		[Token(Token = "0x60006EF")]
		[Address(RVA = "0x1178770", Offset = "0x1178770", VA = "0x1178770")]
		public void PrepareVideo()
		{
		}

		[Token(Token = "0x60006F0")]
		[Address(RVA = "0x1178B38", Offset = "0x1178B38", VA = "0x1178B38")]
		private void LoopPointReached(VideoPlayer vp)
		{
		}

		[Token(Token = "0x60006F1")]
		[Address(RVA = "0x1178B48", Offset = "0x1178B48", VA = "0x1178B48", Slot = "19")]
		public override void PrepareFrame(Playable playable, FrameData info)
		{
		}

		[Token(Token = "0x60006F2")]
		[Address(RVA = "0x1178E44", Offset = "0x1178E44", VA = "0x1178E44", Slot = "17")]
		public override void OnBehaviourPlay(Playable playable, FrameData info)
		{
		}

		[Token(Token = "0x60006F3")]
		[Address(RVA = "0x1178F9C", Offset = "0x1178F9C", VA = "0x1178F9C", Slot = "18")]
		public override void OnBehaviourPause(Playable playable, FrameData info)
		{
		}

		[Token(Token = "0x60006F4")]
		[Address(RVA = "0x11790C8", Offset = "0x11790C8", VA = "0x11790C8", Slot = "20")]
		public override void ProcessFrame(Playable playable, FrameData info, object playerData)
		{
		}

		[Token(Token = "0x60006F5")]
		[Address(RVA = "0x11792B8", Offset = "0x11792B8", VA = "0x11792B8", Slot = "13")]
		public override void OnGraphStart(Playable playable)
		{
		}

		[Token(Token = "0x60006F6")]
		[Address(RVA = "0x11792C0", Offset = "0x11792C0", VA = "0x11792C0", Slot = "14")]
		public override void OnGraphStop(Playable playable)
		{
		}

		[Token(Token = "0x60006F7")]
		[Address(RVA = "0x11792F8", Offset = "0x11792F8", VA = "0x11792F8", Slot = "16")]
		public override void OnPlayableDestroy(Playable playable)
		{
		}

		[Token(Token = "0x60006F8")]
		[Address(RVA = "0x1178EF4", Offset = "0x1178EF4", VA = "0x1178EF4")]
		public void PlayVideo()
		{
		}

		[Token(Token = "0x60006F9")]
		[Address(RVA = "0x117903C", Offset = "0x117903C", VA = "0x117903C")]
		public void PauseVideo()
		{
		}

		[Token(Token = "0x60006FA")]
		[Address(RVA = "0x1178AA8", Offset = "0x1178AA8", VA = "0x1178AA8")]
		public void StopVideo()
		{
		}

		[Token(Token = "0x60006FB")]
		[Address(RVA = "0x1178CC4", Offset = "0x1178CC4", VA = "0x1178CC4")]
		private void SyncVideoToPlayable(Playable playable)
		{
		}

		[Token(Token = "0x60006FC")]
		[Address(RVA = "0x11792FC", Offset = "0x11792FC", VA = "0x11792FC")]
		public VideoPlayableBehaviour()
		{
		}
	}
	[Token(Token = "0x200012A")]
	public sealed class VideoSchedulerPlayableBehaviour : PlayableBehaviour
	{
		[Token(Token = "0x4000772")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private IEnumerable<TimelineClip> m_Clips;

		[Token(Token = "0x4000773")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private PlayableDirector m_Director;

		[Token(Token = "0x170000BA")]
		internal PlayableDirector director
		{
			[Token(Token = "0x60006FD")]
			[Address(RVA = "0x1179318", Offset = "0x1179318", VA = "0x1179318")]
			get
			{
				return null;
			}
			[Token(Token = "0x60006FE")]
			[Address(RVA = "0x1179320", Offset = "0x1179320", VA = "0x1179320")]
			set
			{
			}
		}

		[Token(Token = "0x170000BB")]
		internal IEnumerable<TimelineClip> clips
		{
			[Token(Token = "0x60006FF")]
			[Address(RVA = "0x1179328", Offset = "0x1179328", VA = "0x1179328")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000700")]
			[Address(RVA = "0x1179330", Offset = "0x1179330", VA = "0x1179330")]
			set
			{
			}
		}

		[Token(Token = "0x6000701")]
		[Address(RVA = "0x1179338", Offset = "0x1179338", VA = "0x1179338", Slot = "20")]
		public override void ProcessFrame(Playable playable, FrameData info, object playerData)
		{
		}

		[Token(Token = "0x6000702")]
		[Address(RVA = "0x11797CC", Offset = "0x11797CC", VA = "0x11797CC")]
		public VideoSchedulerPlayableBehaviour()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200012B")]
	public class VideoScriptPlayableAsset : PlayableAsset
	{
		[Token(Token = "0x4000774")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public ExposedReference<VideoPlayer> videoPlayer;

		[Token(Token = "0x4000775")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[NotKeyable]
		[SerializeField]
		public VideoClip videoClip;

		[Token(Token = "0x4000776")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		[NotKeyable]
		public bool mute;

		[Token(Token = "0x4000777")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
		[SerializeField]
		[NotKeyable]
		public bool loop;

		[Token(Token = "0x4000778")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		[NotKeyable]
		public double preloadTime;

		[Token(Token = "0x4000779")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		[NotKeyable]
		public double clipInTime;

		[Token(Token = "0x6000703")]
		[Address(RVA = "0x11797D4", Offset = "0x11797D4", VA = "0x11797D4", Slot = "6")]
		public override Playable CreatePlayable(PlayableGraph graph, GameObject go)
		{
			return default(Playable);
		}

		[Token(Token = "0x6000704")]
		[Address(RVA = "0x1179940", Offset = "0x1179940", VA = "0x1179940")]
		public VideoScriptPlayableAsset()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200012C")]
	[AttributeAttribute(Name = "TrackClipTypeAttribute", RVA = "0x8CB8EC", Offset = "0x8CB8EC")]
	[AttributeAttribute(Name = "TrackColorAttribute", RVA = "0x8CB8EC", Offset = "0x8CB8EC")]
	public class VideoScriptPlayableTrack : TrackAsset
	{
		[Token(Token = "0x6000705")]
		[Address(RVA = "0x117995C", Offset = "0x117995C", VA = "0x117995C", Slot = "24")]
		public override Playable CreateTrackMixer(PlayableGraph graph, GameObject go, int inputCount)
		{
			return default(Playable);
		}

		[Token(Token = "0x6000706")]
		[Address(RVA = "0x1179ADC", Offset = "0x1179ADC", VA = "0x1179ADC")]
		public VideoScriptPlayableTrack()
		{
		}
	}
}
