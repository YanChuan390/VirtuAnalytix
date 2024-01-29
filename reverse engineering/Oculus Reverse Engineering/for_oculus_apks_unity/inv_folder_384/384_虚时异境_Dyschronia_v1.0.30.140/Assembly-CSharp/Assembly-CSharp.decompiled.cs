using System;
using System.Collections.Generic;
using System.Reflection;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;
using UnityEngine.UI;
using UnityEngine.Video;

[assembly: AssemblyVersion("0.0.0.0")]
[Serializable]
[Token(Token = "0x2000002")]
public class LightControlBehaviour : PlayableBehaviour
{
	[Token(Token = "0x4000001")]
	[FieldOffset(Offset = "0x10")]
	public Color color;

	[Token(Token = "0x4000002")]
	[FieldOffset(Offset = "0x20")]
	public float intensity;

	[Token(Token = "0x4000003")]
	[FieldOffset(Offset = "0x24")]
	public float bounceIntensity;

	[Token(Token = "0x4000004")]
	[FieldOffset(Offset = "0x28")]
	public float range;

	[Token(Token = "0x6000001")]
	[Address(RVA = "0x3B4D5D8", Offset = "0x3B4D5D8", VA = "0x3B4D5D8")]
	public LightControlBehaviour()
	{
	}
}
[Serializable]
[Token(Token = "0x2000003")]
public class LightControlClip : PlayableAsset, ITimelineClipAsset
{
	[Token(Token = "0x4000005")]
	[FieldOffset(Offset = "0x18")]
	public LightControlBehaviour template;

	[Token(Token = "0x17000001")]
	public ClipCaps clipCaps
	{
		[Token(Token = "0x6000002")]
		[Address(RVA = "0x3B4D61C", Offset = "0x3B4D61C", VA = "0x3B4D61C", Slot = "9")]
		get
		{
			return default(ClipCaps);
		}
	}

	[Token(Token = "0x6000003")]
	[Address(RVA = "0x3B4D624", Offset = "0x3B4D624", VA = "0x3B4D624", Slot = "6")]
	public override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
	{
		return default(Playable);
	}

	[Token(Token = "0x6000004")]
	[Address(RVA = "0x3B4D6D8", Offset = "0x3B4D6D8", VA = "0x3B4D6D8")]
	public LightControlClip()
	{
	}
}
[Token(Token = "0x2000004")]
public class LightControlMixerBehaviour : PlayableBehaviour
{
	[Token(Token = "0x4000006")]
	[FieldOffset(Offset = "0x10")]
	private Color m_DefaultColor;

	[Token(Token = "0x4000007")]
	[FieldOffset(Offset = "0x20")]
	private float m_DefaultIntensity;

	[Token(Token = "0x4000008")]
	[FieldOffset(Offset = "0x24")]
	private float m_DefaultBounceIntensity;

	[Token(Token = "0x4000009")]
	[FieldOffset(Offset = "0x28")]
	private float m_DefaultRange;

	[Token(Token = "0x400000A")]
	[FieldOffset(Offset = "0x30")]
	private Light m_TrackBinding;

	[Token(Token = "0x400000B")]
	[FieldOffset(Offset = "0x38")]
	private bool m_FirstFrameHappened;

	[Token(Token = "0x6000005")]
	[Address(RVA = "0x3B4D744", Offset = "0x3B4D744", VA = "0x3B4D744", Slot = "20")]
	public override void ProcessFrame(Playable playable, FrameData info, object playerData)
	{
	}

	[Token(Token = "0x6000006")]
	[Address(RVA = "0x3B4DB5C", Offset = "0x3B4DB5C", VA = "0x3B4DB5C", Slot = "16")]
	public override void OnPlayableDestroy(Playable playable)
	{
	}

	[Token(Token = "0x6000007")]
	[Address(RVA = "0x3B4DC34", Offset = "0x3B4DC34", VA = "0x3B4DC34")]
	public LightControlMixerBehaviour()
	{
	}
}
[Token(Token = "0x2000005")]
[AttributeAttribute(Name = "TrackColorAttribute", RVA = "0x11D2830", Offset = "0x11D2830")]
[AttributeAttribute(Name = "TrackClipTypeAttribute", RVA = "0x11D2830", Offset = "0x11D2830")]
[AttributeAttribute(Name = "TrackBindingTypeAttribute", RVA = "0x11D2830", Offset = "0x11D2830")]
public class LightControlTrack : TrackAsset
{
	[Token(Token = "0x6000008")]
	[Address(RVA = "0x3B4DC3C", Offset = "0x3B4DC3C", VA = "0x3B4DC3C", Slot = "24")]
	public override Playable CreateTrackMixer(PlayableGraph graph, GameObject go, int inputCount)
	{
		return default(Playable);
	}

	[Token(Token = "0x6000009")]
	[Address(RVA = "0x3B4DCE8", Offset = "0x3B4DCE8", VA = "0x3B4DCE8", Slot = "29")]
	public override void GatherProperties(PlayableDirector director, IPropertyCollector driver)
	{
	}

	[Token(Token = "0x600000A")]
	[Address(RVA = "0x3B4DCF0", Offset = "0x3B4DCF0", VA = "0x3B4DCF0")]
	public LightControlTrack()
	{
	}
}
[Serializable]
[Token(Token = "0x2000006")]
public class NavMeshAgentControlBehaviour : PlayableBehaviour
{
	[Token(Token = "0x400000C")]
	[FieldOffset(Offset = "0x10")]
	public Transform destination;

	[Token(Token = "0x400000D")]
	[FieldOffset(Offset = "0x18")]
	public bool destinationSet;

	[Token(Token = "0x600000B")]
	[Address(RVA = "0x3B4DD54", Offset = "0x3B4DD54", VA = "0x3B4DD54", Slot = "15")]
	public override void OnPlayableCreate(Playable playable)
	{
	}

	[Token(Token = "0x600000C")]
	[Address(RVA = "0x3B4DD5C", Offset = "0x3B4DD5C", VA = "0x3B4DD5C")]
	public NavMeshAgentControlBehaviour()
	{
	}
}
[Serializable]
[Token(Token = "0x2000007")]
public class NavMeshAgentControlClip : PlayableAsset, ITimelineClipAsset
{
	[Token(Token = "0x400000E")]
	[FieldOffset(Offset = "0x18")]
	public ExposedReference<Transform> destination;

	[Token(Token = "0x400000F")]
	[FieldOffset(Offset = "0x28")]
	[HideInInspector]
	public NavMeshAgentControlBehaviour template;

	[Token(Token = "0x17000002")]
	public ClipCaps clipCaps
	{
		[Token(Token = "0x600000D")]
		[Address(RVA = "0x3B4DD64", Offset = "0x3B4DD64", VA = "0x3B4DD64", Slot = "9")]
		get
		{
			return default(ClipCaps);
		}
	}

	[Token(Token = "0x600000E")]
	[Address(RVA = "0x3B4DD6C", Offset = "0x3B4DD6C", VA = "0x3B4DD6C", Slot = "6")]
	public override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
	{
		return default(Playable);
	}

	[Token(Token = "0x600000F")]
	[Address(RVA = "0x3B4DEB0", Offset = "0x3B4DEB0", VA = "0x3B4DEB0")]
	public NavMeshAgentControlClip()
	{
	}
}
[Token(Token = "0x2000008")]
public class NavMeshAgentControlMixerBehaviour : PlayableBehaviour
{
	[Token(Token = "0x6000010")]
	[Address(RVA = "0x3B4DF20", Offset = "0x3B4DF20", VA = "0x3B4DF20", Slot = "20")]
	public override void ProcessFrame(Playable playable, FrameData info, object playerData)
	{
	}

	[Token(Token = "0x6000011")]
	[Address(RVA = "0x3B4E1A0", Offset = "0x3B4E1A0", VA = "0x3B4E1A0")]
	public NavMeshAgentControlMixerBehaviour()
	{
	}
}
[Token(Token = "0x2000009")]
[AttributeAttribute(Name = "TrackColorAttribute", RVA = "0x11D28EC", Offset = "0x11D28EC")]
[AttributeAttribute(Name = "TrackClipTypeAttribute", RVA = "0x11D28EC", Offset = "0x11D28EC")]
[AttributeAttribute(Name = "TrackBindingTypeAttribute", RVA = "0x11D28EC", Offset = "0x11D28EC")]
public class NavMeshAgentControlTrack : TrackAsset
{
	[Token(Token = "0x6000012")]
	[Address(RVA = "0x3B4E1A8", Offset = "0x3B4E1A8", VA = "0x3B4E1A8", Slot = "24")]
	public override Playable CreateTrackMixer(PlayableGraph graph, GameObject go, int inputCount)
	{
		return default(Playable);
	}

	[Token(Token = "0x6000013")]
	[Address(RVA = "0x3B4E254", Offset = "0x3B4E254", VA = "0x3B4E254")]
	public NavMeshAgentControlTrack()
	{
	}
}
[Serializable]
[Token(Token = "0x200000A")]
public class ScreenFaderBehaviour : PlayableBehaviour
{
	[Token(Token = "0x4000010")]
	[FieldOffset(Offset = "0x10")]
	public Color color;

	[Token(Token = "0x6000014")]
	[Address(RVA = "0x3B4E2B8", Offset = "0x3B4E2B8", VA = "0x3B4E2B8")]
	public ScreenFaderBehaviour()
	{
	}
}
[Serializable]
[Token(Token = "0x200000B")]
public class ScreenFaderClip : PlayableAsset, ITimelineClipAsset
{
	[Token(Token = "0x4000011")]
	[FieldOffset(Offset = "0x18")]
	public ScreenFaderBehaviour template;

	[Token(Token = "0x17000003")]
	public ClipCaps clipCaps
	{
		[Token(Token = "0x6000015")]
		[Address(RVA = "0x3B4E2EC", Offset = "0x3B4E2EC", VA = "0x3B4E2EC", Slot = "9")]
		get
		{
			return default(ClipCaps);
		}
	}

	[Token(Token = "0x6000016")]
	[Address(RVA = "0x3B4E2F4", Offset = "0x3B4E2F4", VA = "0x3B4E2F4", Slot = "6")]
	public override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
	{
		return default(Playable);
	}

	[Token(Token = "0x6000017")]
	[Address(RVA = "0x3B4E3A8", Offset = "0x3B4E3A8", VA = "0x3B4E3A8")]
	public ScreenFaderClip()
	{
	}
}
[Token(Token = "0x200000C")]
public class ScreenFaderMixerBehaviour : PlayableBehaviour
{
	[Token(Token = "0x4000012")]
	[FieldOffset(Offset = "0x10")]
	private Color m_DefaultColor;

	[Token(Token = "0x4000013")]
	[FieldOffset(Offset = "0x20")]
	private Image m_TrackBinding;

	[Token(Token = "0x4000014")]
	[FieldOffset(Offset = "0x28")]
	private bool m_FirstFrameHappened;

	[Token(Token = "0x6000018")]
	[Address(RVA = "0x3B4E414", Offset = "0x3B4E414", VA = "0x3B4E414", Slot = "20")]
	public override void ProcessFrame(Playable playable, FrameData info, object playerData)
	{
	}

	[Token(Token = "0x6000019")]
	[Address(RVA = "0x3B4E768", Offset = "0x3B4E768", VA = "0x3B4E768", Slot = "16")]
	public override void OnPlayableDestroy(Playable playable)
	{
	}

	[Token(Token = "0x600001A")]
	[Address(RVA = "0x3B4E80C", Offset = "0x3B4E80C", VA = "0x3B4E80C")]
	public ScreenFaderMixerBehaviour()
	{
	}
}
[Token(Token = "0x200000D")]
[AttributeAttribute(Name = "TrackColorAttribute", RVA = "0x11D29A8", Offset = "0x11D29A8")]
[AttributeAttribute(Name = "TrackClipTypeAttribute", RVA = "0x11D29A8", Offset = "0x11D29A8")]
[AttributeAttribute(Name = "TrackBindingTypeAttribute", RVA = "0x11D29A8", Offset = "0x11D29A8")]
public class ScreenFaderTrack : TrackAsset
{
	[Token(Token = "0x600001B")]
	[Address(RVA = "0x3B4E814", Offset = "0x3B4E814", VA = "0x3B4E814", Slot = "24")]
	public override Playable CreateTrackMixer(PlayableGraph graph, GameObject go, int inputCount)
	{
		return default(Playable);
	}

	[Token(Token = "0x600001C")]
	[Address(RVA = "0x3B4E8C0", Offset = "0x3B4E8C0", VA = "0x3B4E8C0", Slot = "29")]
	public override void GatherProperties(PlayableDirector director, IPropertyCollector driver)
	{
	}

	[Token(Token = "0x600001D")]
	[Address(RVA = "0x3B4E8C8", Offset = "0x3B4E8C8", VA = "0x3B4E8C8")]
	public ScreenFaderTrack()
	{
	}
}
[Serializable]
[Token(Token = "0x200000E")]
public class TextSwitcherBehaviour : PlayableBehaviour
{
	[Token(Token = "0x4000015")]
	[FieldOffset(Offset = "0x10")]
	public Color color;

	[Token(Token = "0x4000016")]
	[FieldOffset(Offset = "0x20")]
	public int fontSize;

	[Token(Token = "0x4000017")]
	[FieldOffset(Offset = "0x28")]
	public string text;

	[Token(Token = "0x600001E")]
	[Address(RVA = "0x3B4E92C", Offset = "0x3B4E92C", VA = "0x3B4E92C")]
	public TextSwitcherBehaviour()
	{
	}
}
[Serializable]
[Token(Token = "0x200000F")]
public class TextSwitcherClip : PlayableAsset, ITimelineClipAsset
{
	[Token(Token = "0x4000018")]
	[FieldOffset(Offset = "0x18")]
	public TextSwitcherBehaviour template;

	[Token(Token = "0x17000004")]
	public ClipCaps clipCaps
	{
		[Token(Token = "0x600001F")]
		[Address(RVA = "0x3B4E968", Offset = "0x3B4E968", VA = "0x3B4E968", Slot = "9")]
		get
		{
			return default(ClipCaps);
		}
	}

	[Token(Token = "0x6000020")]
	[Address(RVA = "0x3B4E970", Offset = "0x3B4E970", VA = "0x3B4E970", Slot = "6")]
	public override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
	{
		return default(Playable);
	}

	[Token(Token = "0x6000021")]
	[Address(RVA = "0x3B4EA24", Offset = "0x3B4EA24", VA = "0x3B4EA24")]
	public TextSwitcherClip()
	{
	}
}
[Token(Token = "0x2000010")]
public class TextSwitcherMixerBehaviour : PlayableBehaviour
{
	[Token(Token = "0x4000019")]
	[FieldOffset(Offset = "0x10")]
	private Color m_DefaultColor;

	[Token(Token = "0x400001A")]
	[FieldOffset(Offset = "0x20")]
	private int m_DefaultFontSize;

	[Token(Token = "0x400001B")]
	[FieldOffset(Offset = "0x28")]
	private string m_DefaultText;

	[Token(Token = "0x400001C")]
	[FieldOffset(Offset = "0x30")]
	private Text m_TrackBinding;

	[Token(Token = "0x400001D")]
	[FieldOffset(Offset = "0x38")]
	private bool m_FirstFrameHappened;

	[Token(Token = "0x6000022")]
	[Address(RVA = "0x3B4EA90", Offset = "0x3B4EA90", VA = "0x3B4EA90", Slot = "20")]
	public override void ProcessFrame(Playable playable, FrameData info, object playerData)
	{
	}

	[Token(Token = "0x6000023")]
	[Address(RVA = "0x3B4EF0C", Offset = "0x3B4EF0C", VA = "0x3B4EF0C", Slot = "16")]
	public override void OnPlayableDestroy(Playable playable)
	{
	}

	[Token(Token = "0x6000024")]
	[Address(RVA = "0x3B4EFE0", Offset = "0x3B4EFE0", VA = "0x3B4EFE0")]
	public TextSwitcherMixerBehaviour()
	{
	}
}
[Token(Token = "0x2000011")]
[AttributeAttribute(Name = "TrackColorAttribute", RVA = "0x11D2A60", Offset = "0x11D2A60")]
[AttributeAttribute(Name = "TrackClipTypeAttribute", RVA = "0x11D2A60", Offset = "0x11D2A60")]
[AttributeAttribute(Name = "TrackBindingTypeAttribute", RVA = "0x11D2A60", Offset = "0x11D2A60")]
public class TextSwitcherTrack : TrackAsset
{
	[Token(Token = "0x6000025")]
	[Address(RVA = "0x3B4EFE8", Offset = "0x3B4EFE8", VA = "0x3B4EFE8", Slot = "24")]
	public override Playable CreateTrackMixer(PlayableGraph graph, GameObject go, int inputCount)
	{
		return default(Playable);
	}

	[Token(Token = "0x6000026")]
	[Address(RVA = "0x3B4F094", Offset = "0x3B4F094", VA = "0x3B4F094", Slot = "29")]
	public override void GatherProperties(PlayableDirector director, IPropertyCollector driver)
	{
	}

	[Token(Token = "0x6000027")]
	[Address(RVA = "0x3B4F09C", Offset = "0x3B4F09C", VA = "0x3B4F09C")]
	public TextSwitcherTrack()
	{
	}
}
[Serializable]
[Token(Token = "0x2000012")]
public class TimeDilationBehaviour : PlayableBehaviour
{
	[Token(Token = "0x400001E")]
	[FieldOffset(Offset = "0x10")]
	public float timeScale;

	[Token(Token = "0x6000028")]
	[Address(RVA = "0x3B4F100", Offset = "0x3B4F100", VA = "0x3B4F100")]
	public TimeDilationBehaviour()
	{
	}
}
[Serializable]
[Token(Token = "0x2000013")]
public class TimeDilationClip : PlayableAsset, ITimelineClipAsset
{
	[Token(Token = "0x400001F")]
	[FieldOffset(Offset = "0x18")]
	public TimeDilationBehaviour template;

	[Token(Token = "0x17000005")]
	public ClipCaps clipCaps
	{
		[Token(Token = "0x6000029")]
		[Address(RVA = "0x3B4F110", Offset = "0x3B4F110", VA = "0x3B4F110", Slot = "9")]
		get
		{
			return default(ClipCaps);
		}
	}

	[Token(Token = "0x600002A")]
	[Address(RVA = "0x3B4F118", Offset = "0x3B4F118", VA = "0x3B4F118", Slot = "6")]
	public override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
	{
		return default(Playable);
	}

	[Token(Token = "0x600002B")]
	[Address(RVA = "0x3B4F1CC", Offset = "0x3B4F1CC", VA = "0x3B4F1CC")]
	public TimeDilationClip()
	{
	}
}
[Token(Token = "0x2000014")]
public class TimeDilationMixerBehaviour : PlayableBehaviour
{
	[Token(Token = "0x4000020")]
	[FieldOffset(Offset = "0x10")]
	private readonly float defaultTimeScale;

	[Token(Token = "0x600002C")]
	[Address(RVA = "0x3B4F244", Offset = "0x3B4F244", VA = "0x3B4F244", Slot = "20")]
	public override void ProcessFrame(Playable playable, FrameData info, object playerData)
	{
	}

	[Token(Token = "0x600002D")]
	[Address(RVA = "0x3B4F448", Offset = "0x3B4F448", VA = "0x3B4F448", Slot = "18")]
	public override void OnBehaviourPause(Playable playable, FrameData info)
	{
	}

	[Token(Token = "0x600002E")]
	[Address(RVA = "0x3B4F454", Offset = "0x3B4F454", VA = "0x3B4F454", Slot = "14")]
	public override void OnGraphStop(Playable playable)
	{
	}

	[Token(Token = "0x600002F")]
	[Address(RVA = "0x3B4F460", Offset = "0x3B4F460", VA = "0x3B4F460", Slot = "16")]
	public override void OnPlayableDestroy(Playable playable)
	{
	}

	[Token(Token = "0x6000030")]
	[Address(RVA = "0x3B4F46C", Offset = "0x3B4F46C", VA = "0x3B4F46C")]
	public TimeDilationMixerBehaviour()
	{
	}
}
[Token(Token = "0x2000015")]
[AttributeAttribute(Name = "TrackColorAttribute", RVA = "0x11D2B1C", Offset = "0x11D2B1C")]
[AttributeAttribute(Name = "TrackClipTypeAttribute", RVA = "0x11D2B1C", Offset = "0x11D2B1C")]
public class TimeDilationTrack : TrackAsset
{
	[Token(Token = "0x6000031")]
	[Address(RVA = "0x3B4F47C", Offset = "0x3B4F47C", VA = "0x3B4F47C", Slot = "24")]
	public override Playable CreateTrackMixer(PlayableGraph graph, GameObject go, int inputCount)
	{
		return default(Playable);
	}

	[Token(Token = "0x6000032")]
	[Address(RVA = "0x3B4F528", Offset = "0x3B4F528", VA = "0x3B4F528")]
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
	[FieldOffset(Offset = "0x10")]
	public Transform startLocation;

	[Token(Token = "0x4000022")]
	[FieldOffset(Offset = "0x18")]
	public Transform endLocation;

	[Token(Token = "0x4000023")]
	[FieldOffset(Offset = "0x20")]
	public bool tweenPosition;

	[Token(Token = "0x4000024")]
	[FieldOffset(Offset = "0x21")]
	public bool tweenRotation;

	[Token(Token = "0x4000025")]
	[FieldOffset(Offset = "0x24")]
	public TweenType tweenType;

	[Token(Token = "0x4000026")]
	[FieldOffset(Offset = "0x28")]
	public AnimationCurve customCurve;

	[Token(Token = "0x4000027")]
	[FieldOffset(Offset = "0x30")]
	public Vector3 startingPosition;

	[Token(Token = "0x4000028")]
	[FieldOffset(Offset = "0x3C")]
	public Quaternion startingRotation;

	[Token(Token = "0x4000029")]
	[FieldOffset(Offset = "0x50")]
	private AnimationCurve m_LinearCurve;

	[Token(Token = "0x400002A")]
	[FieldOffset(Offset = "0x58")]
	private AnimationCurve m_DecelerationCurve;

	[Token(Token = "0x400002B")]
	[FieldOffset(Offset = "0x60")]
	private AnimationCurve m_HarmonicCurve;

	[Token(Token = "0x400002C")]
	private const float k_RightAngleInRads = (float)Math.PI / 2f;

	[Token(Token = "0x6000033")]
	[Address(RVA = "0x3B4F58C", Offset = "0x3B4F58C", VA = "0x3B4F58C", Slot = "19")]
	public override void PrepareFrame(Playable playable, FrameData info)
	{
	}

	[Token(Token = "0x6000034")]
	[Address(RVA = "0x3B4F630", Offset = "0x3B4F630", VA = "0x3B4F630")]
	public float EvaluateCurrentCurve(float time)
	{
		return default(float);
	}

	[Token(Token = "0x6000035")]
	[Address(RVA = "0x3B4F6D0", Offset = "0x3B4F6D0", VA = "0x3B4F6D0")]
	private bool IsCustomCurveNormalised()
	{
		return default(bool);
	}

	[Token(Token = "0x6000036")]
	[Address(RVA = "0x3B4F84C", Offset = "0x3B4F84C", VA = "0x3B4F84C")]
	public TransformTweenBehaviour()
	{
	}
}
[Serializable]
[Token(Token = "0x2000018")]
public class TransformTweenClip : PlayableAsset, ITimelineClipAsset
{
	[Token(Token = "0x4000032")]
	[FieldOffset(Offset = "0x18")]
	public TransformTweenBehaviour template;

	[Token(Token = "0x4000033")]
	[FieldOffset(Offset = "0x20")]
	public ExposedReference<Transform> startLocation;

	[Token(Token = "0x4000034")]
	[FieldOffset(Offset = "0x30")]
	public ExposedReference<Transform> endLocation;

	[Token(Token = "0x17000006")]
	public ClipCaps clipCaps
	{
		[Token(Token = "0x6000037")]
		[Address(RVA = "0x3B4FA54", Offset = "0x3B4FA54", VA = "0x3B4FA54", Slot = "9")]
		get
		{
			return default(ClipCaps);
		}
	}

	[Token(Token = "0x6000038")]
	[Address(RVA = "0x3B4FA5C", Offset = "0x3B4FA5C", VA = "0x3B4FA5C", Slot = "6")]
	public override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
	{
		return default(Playable);
	}

	[Token(Token = "0x6000039")]
	[Address(RVA = "0x3B4FBD0", Offset = "0x3B4FBD0", VA = "0x3B4FBD0")]
	public TransformTweenClip()
	{
	}
}
[Token(Token = "0x2000019")]
public class TransformTweenMixerBehaviour : PlayableBehaviour
{
	[Token(Token = "0x4000035")]
	[FieldOffset(Offset = "0x10")]
	private bool m_FirstFrameHappened;

	[Token(Token = "0x600003A")]
	[Address(RVA = "0x3B4FC3C", Offset = "0x3B4FC3C", VA = "0x3B4FC3C", Slot = "20")]
	public override void ProcessFrame(Playable playable, FrameData info, object playerData)
	{
	}

	[Token(Token = "0x600003B")]
	[Address(RVA = "0x3B502B4", Offset = "0x3B502B4", VA = "0x3B502B4", Slot = "16")]
	public override void OnPlayableDestroy(Playable playable)
	{
	}

	[Token(Token = "0x600003C")]
	[Address(RVA = "0x3B502A0", Offset = "0x3B502A0", VA = "0x3B502A0")]
	private static Quaternion AddQuaternions(Quaternion first, Quaternion second)
	{
		return default(Quaternion);
	}

	[Token(Token = "0x600003D")]
	[Address(RVA = "0x3B5028C", Offset = "0x3B5028C", VA = "0x3B5028C")]
	private static Quaternion ScaleQuaternion(Quaternion rotation, float multiplier)
	{
		return default(Quaternion);
	}

	[Token(Token = "0x600003E")]
	[Address(RVA = "0x3B502BC", Offset = "0x3B502BC", VA = "0x3B502BC")]
	private static float QuaternionMagnitude(Quaternion rotation)
	{
		return default(float);
	}

	[Token(Token = "0x600003F")]
	[Address(RVA = "0x3B50200", Offset = "0x3B50200", VA = "0x3B50200")]
	private static Quaternion NormalizeQuaternion(Quaternion rotation)
	{
		return default(Quaternion);
	}

	[Token(Token = "0x6000040")]
	[Address(RVA = "0x3B502FC", Offset = "0x3B502FC", VA = "0x3B502FC")]
	public TransformTweenMixerBehaviour()
	{
	}
}
[Token(Token = "0x200001A")]
[AttributeAttribute(Name = "TrackClipTypeAttribute", RVA = "0x11D2BA4", Offset = "0x11D2BA4")]
[AttributeAttribute(Name = "TrackColorAttribute", RVA = "0x11D2BA4", Offset = "0x11D2BA4")]
[AttributeAttribute(Name = "TrackBindingTypeAttribute", RVA = "0x11D2BA4", Offset = "0x11D2BA4")]
public class TransformTweenTrack : TrackAsset
{
	[Token(Token = "0x6000041")]
	[Address(RVA = "0x3B50304", Offset = "0x3B50304", VA = "0x3B50304", Slot = "24")]
	public override Playable CreateTrackMixer(PlayableGraph graph, GameObject go, int inputCount)
	{
		return default(Playable);
	}

	[Token(Token = "0x6000042")]
	[Address(RVA = "0x3B503B0", Offset = "0x3B503B0", VA = "0x3B503B0", Slot = "29")]
	public override void GatherProperties(PlayableDirector director, IPropertyCollector driver)
	{
	}

	[Token(Token = "0x6000043")]
	[Address(RVA = "0x3B503B8", Offset = "0x3B503B8", VA = "0x3B503B8")]
	public TransformTweenTrack()
	{
	}
}
namespace UnityEngine.Timeline;

[Token(Token = "0x200001B")]
public class VideoPlayableBehaviour : PlayableBehaviour
{
	[Token(Token = "0x4000036")]
	[FieldOffset(Offset = "0x10")]
	public VideoPlayer videoPlayer;

	[Token(Token = "0x4000037")]
	[FieldOffset(Offset = "0x18")]
	public VideoClip videoClip;

	[Token(Token = "0x4000038")]
	[FieldOffset(Offset = "0x20")]
	public bool mute;

	[Token(Token = "0x4000039")]
	[FieldOffset(Offset = "0x21")]
	public bool loop;

	[Token(Token = "0x400003A")]
	[FieldOffset(Offset = "0x28")]
	public double preloadTime;

	[Token(Token = "0x400003B")]
	[FieldOffset(Offset = "0x30")]
	public double clipInTime;

	[Token(Token = "0x400003C")]
	[FieldOffset(Offset = "0x38")]
	private bool playedOnce;

	[Token(Token = "0x400003D")]
	[FieldOffset(Offset = "0x39")]
	private bool preparing;

	[Token(Token = "0x6000044")]
	[Address(RVA = "0x3B5041C", Offset = "0x3B5041C", VA = "0x3B5041C")]
	public void PrepareVideo()
	{
	}

	[Token(Token = "0x6000045")]
	[Address(RVA = "0x3B50824", Offset = "0x3B50824", VA = "0x3B50824")]
	private void LoopPointReached(VideoPlayer vp)
	{
	}

	[Token(Token = "0x6000046")]
	[Address(RVA = "0x3B50834", Offset = "0x3B50834", VA = "0x3B50834", Slot = "19")]
	public override void PrepareFrame(Playable playable, FrameData info)
	{
	}

	[Token(Token = "0x6000047")]
	[Address(RVA = "0x3B50AF0", Offset = "0x3B50AF0", VA = "0x3B50AF0", Slot = "17")]
	public override void OnBehaviourPlay(Playable playable, FrameData info)
	{
	}

	[Token(Token = "0x6000048")]
	[Address(RVA = "0x3B50C6C", Offset = "0x3B50C6C", VA = "0x3B50C6C", Slot = "18")]
	public override void OnBehaviourPause(Playable playable, FrameData info)
	{
	}

	[Token(Token = "0x6000049")]
	[Address(RVA = "0x3B50DBC", Offset = "0x3B50DBC", VA = "0x3B50DBC", Slot = "20")]
	public override void ProcessFrame(Playable playable, FrameData info, object playerData)
	{
	}

	[Token(Token = "0x600004A")]
	[Address(RVA = "0x3B50FF8", Offset = "0x3B50FF8", VA = "0x3B50FF8", Slot = "13")]
	public override void OnGraphStart(Playable playable)
	{
	}

	[Token(Token = "0x600004B")]
	[Address(RVA = "0x3B51000", Offset = "0x3B51000", VA = "0x3B51000", Slot = "14")]
	public override void OnGraphStop(Playable playable)
	{
	}

	[Token(Token = "0x600004C")]
	[Address(RVA = "0x3B51038", Offset = "0x3B51038", VA = "0x3B51038", Slot = "16")]
	public override void OnPlayableDestroy(Playable playable)
	{
	}

	[Token(Token = "0x600004D")]
	[Address(RVA = "0x3B50BA0", Offset = "0x3B50BA0", VA = "0x3B50BA0")]
	public void PlayVideo()
	{
	}

	[Token(Token = "0x600004E")]
	[Address(RVA = "0x3B50D0C", Offset = "0x3B50D0C", VA = "0x3B50D0C")]
	public void PauseVideo()
	{
	}

	[Token(Token = "0x600004F")]
	[Address(RVA = "0x3B50794", Offset = "0x3B50794", VA = "0x3B50794")]
	public void StopVideo()
	{
	}

	[Token(Token = "0x6000050")]
	[Address(RVA = "0x3B50970", Offset = "0x3B50970", VA = "0x3B50970")]
	private void SyncVideoToPlayable(Playable playable)
	{
	}

	[Token(Token = "0x6000051")]
	[Address(RVA = "0x3B5103C", Offset = "0x3B5103C", VA = "0x3B5103C")]
	public VideoPlayableBehaviour()
	{
	}
}
[Token(Token = "0x200001C")]
public sealed class VideoSchedulerPlayableBehaviour : PlayableBehaviour
{
	[Token(Token = "0x400003E")]
	[FieldOffset(Offset = "0x10")]
	private IEnumerable<TimelineClip> m_Clips;

	[Token(Token = "0x400003F")]
	[FieldOffset(Offset = "0x18")]
	private PlayableDirector m_Director;

	[Token(Token = "0x17000007")]
	internal PlayableDirector director
	{
		[Token(Token = "0x6000052")]
		[Address(RVA = "0x3B51058", Offset = "0x3B51058", VA = "0x3B51058")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000053")]
		[Address(RVA = "0x3B51060", Offset = "0x3B51060", VA = "0x3B51060")]
		set
		{
		}
	}

	[Token(Token = "0x17000008")]
	internal IEnumerable<TimelineClip> clips
	{
		[Token(Token = "0x6000054")]
		[Address(RVA = "0x3B51068", Offset = "0x3B51068", VA = "0x3B51068")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000055")]
		[Address(RVA = "0x3B51070", Offset = "0x3B51070", VA = "0x3B51070")]
		set
		{
		}
	}

	[Token(Token = "0x6000056")]
	[Address(RVA = "0x3B51078", Offset = "0x3B51078", VA = "0x3B51078", Slot = "20")]
	public override void ProcessFrame(Playable playable, FrameData info, object playerData)
	{
	}

	[Token(Token = "0x6000057")]
	[Address(RVA = "0x3B5150C", Offset = "0x3B5150C", VA = "0x3B5150C")]
	public VideoSchedulerPlayableBehaviour()
	{
	}
}
[Serializable]
[Token(Token = "0x200001D")]
public class VideoScriptPlayableAsset : PlayableAsset
{
	[Token(Token = "0x4000040")]
	[FieldOffset(Offset = "0x18")]
	public ExposedReference<VideoPlayer> videoPlayer;

	[Token(Token = "0x4000041")]
	[FieldOffset(Offset = "0x28")]
	[NotKeyable]
	[SerializeField]
	public VideoClip videoClip;

	[Token(Token = "0x4000042")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	[NotKeyable]
	public bool mute;

	[Token(Token = "0x4000043")]
	[FieldOffset(Offset = "0x31")]
	[SerializeField]
	[NotKeyable]
	public bool loop;

	[Token(Token = "0x4000044")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	[NotKeyable]
	public double preloadTime;

	[Token(Token = "0x4000045")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	[NotKeyable]
	public double clipInTime;

	[Token(Token = "0x6000058")]
	[Address(RVA = "0x3B51514", Offset = "0x3B51514", VA = "0x3B51514", Slot = "6")]
	public override Playable CreatePlayable(PlayableGraph graph, GameObject go)
	{
		return default(Playable);
	}

	[Token(Token = "0x6000059")]
	[Address(RVA = "0x3B51680", Offset = "0x3B51680", VA = "0x3B51680")]
	public VideoScriptPlayableAsset()
	{
	}
}
[Serializable]
[Token(Token = "0x200001E")]
[AttributeAttribute(Name = "TrackClipTypeAttribute", RVA = "0x11D2C60", Offset = "0x11D2C60")]
[AttributeAttribute(Name = "TrackColorAttribute", RVA = "0x11D2C60", Offset = "0x11D2C60")]
public class VideoScriptPlayableTrack : TrackAsset
{
	[Token(Token = "0x600005A")]
	[Address(RVA = "0x3B5169C", Offset = "0x3B5169C", VA = "0x3B5169C", Slot = "24")]
	public override Playable CreateTrackMixer(PlayableGraph graph, GameObject go, int inputCount)
	{
		return default(Playable);
	}

	[Token(Token = "0x600005B")]
	[Address(RVA = "0x3B5181C", Offset = "0x3B5181C", VA = "0x3B5181C")]
	public VideoScriptPlayableTrack()
	{
	}
}
