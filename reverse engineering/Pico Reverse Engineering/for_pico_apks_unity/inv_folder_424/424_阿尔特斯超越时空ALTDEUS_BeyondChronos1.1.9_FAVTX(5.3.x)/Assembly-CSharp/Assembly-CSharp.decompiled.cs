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
	[Address(RVA = "0x3DF26B0", Offset = "0x3DF26B0", VA = "0x3DF26B0")]
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
		[Address(RVA = "0x3DF26F4", Offset = "0x3DF26F4", VA = "0x3DF26F4", Slot = "9")]
		get
		{
			return default(ClipCaps);
		}
	}

	[Token(Token = "0x6000003")]
	[Address(RVA = "0x3DF26FC", Offset = "0x3DF26FC", VA = "0x3DF26FC", Slot = "6")]
	public override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
	{
		return default(Playable);
	}

	[Token(Token = "0x6000004")]
	[Address(RVA = "0x3DF279C", Offset = "0x3DF279C", VA = "0x3DF279C")]
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
	[Address(RVA = "0x3DF280C", Offset = "0x3DF280C", VA = "0x3DF280C", Slot = "20")]
	public override void ProcessFrame(Playable playable, FrameData info, object playerData)
	{
	}

	[Token(Token = "0x6000006")]
	[Address(RVA = "0x3DF2BF0", Offset = "0x3DF2BF0", VA = "0x3DF2BF0", Slot = "16")]
	public override void OnPlayableDestroy(Playable playable)
	{
	}

	[Token(Token = "0x6000007")]
	[Address(RVA = "0x3DF2CCC", Offset = "0x3DF2CCC", VA = "0x3DF2CCC")]
	public LightControlMixerBehaviour()
	{
	}
}
[Token(Token = "0x2000005")]
[AttributeAttribute(Name = "TrackColorAttribute", RVA = "0x14BDE20", Offset = "0x14BDE20")]
[AttributeAttribute(Name = "TrackClipTypeAttribute", RVA = "0x14BDE20", Offset = "0x14BDE20")]
[AttributeAttribute(Name = "TrackBindingTypeAttribute", RVA = "0x14BDE20", Offset = "0x14BDE20")]
public class LightControlTrack : TrackAsset
{
	[Token(Token = "0x6000008")]
	[Address(RVA = "0x3DF2CD4", Offset = "0x3DF2CD4", VA = "0x3DF2CD4", Slot = "24")]
	public override Playable CreateTrackMixer(PlayableGraph graph, GameObject go, int inputCount)
	{
		return default(Playable);
	}

	[Token(Token = "0x6000009")]
	[Address(RVA = "0x3DF2D6C", Offset = "0x3DF2D6C", VA = "0x3DF2D6C", Slot = "29")]
	public override void GatherProperties(PlayableDirector director, IPropertyCollector driver)
	{
	}

	[Token(Token = "0x600000A")]
	[Address(RVA = "0x3DF2D74", Offset = "0x3DF2D74", VA = "0x3DF2D74")]
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
	[Address(RVA = "0x3DF2DDC", Offset = "0x3DF2DDC", VA = "0x3DF2DDC", Slot = "15")]
	public override void OnPlayableCreate(Playable playable)
	{
	}

	[Token(Token = "0x600000C")]
	[Address(RVA = "0x3DF2DE4", Offset = "0x3DF2DE4", VA = "0x3DF2DE4")]
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
		[Address(RVA = "0x3DF2DEC", Offset = "0x3DF2DEC", VA = "0x3DF2DEC", Slot = "9")]
		get
		{
			return default(ClipCaps);
		}
	}

	[Token(Token = "0x600000E")]
	[Address(RVA = "0x3DF2DF4", Offset = "0x3DF2DF4", VA = "0x3DF2DF4", Slot = "6")]
	public override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
	{
		return default(Playable);
	}

	[Token(Token = "0x600000F")]
	[Address(RVA = "0x3DF2F0C", Offset = "0x3DF2F0C", VA = "0x3DF2F0C")]
	public NavMeshAgentControlClip()
	{
	}
}
[Token(Token = "0x2000008")]
public class NavMeshAgentControlMixerBehaviour : PlayableBehaviour
{
	[Token(Token = "0x6000010")]
	[Address(RVA = "0x3DF2F80", Offset = "0x3DF2F80", VA = "0x3DF2F80", Slot = "20")]
	public override void ProcessFrame(Playable playable, FrameData info, object playerData)
	{
	}

	[Token(Token = "0x6000011")]
	[Address(RVA = "0x3DF31B0", Offset = "0x3DF31B0", VA = "0x3DF31B0")]
	public NavMeshAgentControlMixerBehaviour()
	{
	}
}
[Token(Token = "0x2000009")]
[AttributeAttribute(Name = "TrackColorAttribute", RVA = "0x14BDED4", Offset = "0x14BDED4")]
[AttributeAttribute(Name = "TrackClipTypeAttribute", RVA = "0x14BDED4", Offset = "0x14BDED4")]
[AttributeAttribute(Name = "TrackBindingTypeAttribute", RVA = "0x14BDED4", Offset = "0x14BDED4")]
public class NavMeshAgentControlTrack : TrackAsset
{
	[Token(Token = "0x6000012")]
	[Address(RVA = "0x3DF31B8", Offset = "0x3DF31B8", VA = "0x3DF31B8", Slot = "24")]
	public override Playable CreateTrackMixer(PlayableGraph graph, GameObject go, int inputCount)
	{
		return default(Playable);
	}

	[Token(Token = "0x6000013")]
	[Address(RVA = "0x3DF3250", Offset = "0x3DF3250", VA = "0x3DF3250")]
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
	[Address(RVA = "0x3DF32B8", Offset = "0x3DF32B8", VA = "0x3DF32B8")]
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
		[Address(RVA = "0x3DF32EC", Offset = "0x3DF32EC", VA = "0x3DF32EC", Slot = "9")]
		get
		{
			return default(ClipCaps);
		}
	}

	[Token(Token = "0x6000016")]
	[Address(RVA = "0x3DF32F4", Offset = "0x3DF32F4", VA = "0x3DF32F4", Slot = "6")]
	public override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
	{
		return default(Playable);
	}

	[Token(Token = "0x6000017")]
	[Address(RVA = "0x3DF3394", Offset = "0x3DF3394", VA = "0x3DF3394")]
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
	[Address(RVA = "0x3DF3404", Offset = "0x3DF3404", VA = "0x3DF3404", Slot = "20")]
	public override void ProcessFrame(Playable playable, FrameData info, object playerData)
	{
	}

	[Token(Token = "0x6000019")]
	[Address(RVA = "0x3DF3728", Offset = "0x3DF3728", VA = "0x3DF3728", Slot = "16")]
	public override void OnPlayableDestroy(Playable playable)
	{
	}

	[Token(Token = "0x600001A")]
	[Address(RVA = "0x3DF37D0", Offset = "0x3DF37D0", VA = "0x3DF37D0")]
	public ScreenFaderMixerBehaviour()
	{
	}
}
[Token(Token = "0x200000D")]
[AttributeAttribute(Name = "TrackColorAttribute", RVA = "0x14BDF88", Offset = "0x14BDF88")]
[AttributeAttribute(Name = "TrackClipTypeAttribute", RVA = "0x14BDF88", Offset = "0x14BDF88")]
[AttributeAttribute(Name = "TrackBindingTypeAttribute", RVA = "0x14BDF88", Offset = "0x14BDF88")]
public class ScreenFaderTrack : TrackAsset
{
	[Token(Token = "0x600001B")]
	[Address(RVA = "0x3DF37D8", Offset = "0x3DF37D8", VA = "0x3DF37D8", Slot = "24")]
	public override Playable CreateTrackMixer(PlayableGraph graph, GameObject go, int inputCount)
	{
		return default(Playable);
	}

	[Token(Token = "0x600001C")]
	[Address(RVA = "0x3DF3870", Offset = "0x3DF3870", VA = "0x3DF3870", Slot = "29")]
	public override void GatherProperties(PlayableDirector director, IPropertyCollector driver)
	{
	}

	[Token(Token = "0x600001D")]
	[Address(RVA = "0x3DF3878", Offset = "0x3DF3878", VA = "0x3DF3878")]
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
	[Address(RVA = "0x3DF38E0", Offset = "0x3DF38E0", VA = "0x3DF38E0")]
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
		[Address(RVA = "0x3DF391C", Offset = "0x3DF391C", VA = "0x3DF391C", Slot = "9")]
		get
		{
			return default(ClipCaps);
		}
	}

	[Token(Token = "0x6000020")]
	[Address(RVA = "0x3DF3924", Offset = "0x3DF3924", VA = "0x3DF3924", Slot = "6")]
	public override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
	{
		return default(Playable);
	}

	[Token(Token = "0x6000021")]
	[Address(RVA = "0x3DF39C4", Offset = "0x3DF39C4", VA = "0x3DF39C4")]
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
	[Address(RVA = "0x3DF3A34", Offset = "0x3DF3A34", VA = "0x3DF3A34", Slot = "20")]
	public override void ProcessFrame(Playable playable, FrameData info, object playerData)
	{
	}

	[Token(Token = "0x6000023")]
	[Address(RVA = "0x3DF3EA0", Offset = "0x3DF3EA0", VA = "0x3DF3EA0", Slot = "16")]
	public override void OnPlayableDestroy(Playable playable)
	{
	}

	[Token(Token = "0x6000024")]
	[Address(RVA = "0x3DF3F78", Offset = "0x3DF3F78", VA = "0x3DF3F78")]
	public TextSwitcherMixerBehaviour()
	{
	}
}
[Token(Token = "0x2000011")]
[AttributeAttribute(Name = "TrackColorAttribute", RVA = "0x14BE038", Offset = "0x14BE038")]
[AttributeAttribute(Name = "TrackClipTypeAttribute", RVA = "0x14BE038", Offset = "0x14BE038")]
[AttributeAttribute(Name = "TrackBindingTypeAttribute", RVA = "0x14BE038", Offset = "0x14BE038")]
public class TextSwitcherTrack : TrackAsset
{
	[Token(Token = "0x6000025")]
	[Address(RVA = "0x3DF3F80", Offset = "0x3DF3F80", VA = "0x3DF3F80", Slot = "24")]
	public override Playable CreateTrackMixer(PlayableGraph graph, GameObject go, int inputCount)
	{
		return default(Playable);
	}

	[Token(Token = "0x6000026")]
	[Address(RVA = "0x3DF4018", Offset = "0x3DF4018", VA = "0x3DF4018", Slot = "29")]
	public override void GatherProperties(PlayableDirector director, IPropertyCollector driver)
	{
	}

	[Token(Token = "0x6000027")]
	[Address(RVA = "0x3DF4020", Offset = "0x3DF4020", VA = "0x3DF4020")]
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
	[Address(RVA = "0x3DF4088", Offset = "0x3DF4088", VA = "0x3DF4088")]
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
		[Address(RVA = "0x3DF4098", Offset = "0x3DF4098", VA = "0x3DF4098", Slot = "9")]
		get
		{
			return default(ClipCaps);
		}
	}

	[Token(Token = "0x600002A")]
	[Address(RVA = "0x3DF40A0", Offset = "0x3DF40A0", VA = "0x3DF40A0", Slot = "6")]
	public override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
	{
		return default(Playable);
	}

	[Token(Token = "0x600002B")]
	[Address(RVA = "0x3DF4140", Offset = "0x3DF4140", VA = "0x3DF4140")]
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
	[Address(RVA = "0x3DF41BC", Offset = "0x3DF41BC", VA = "0x3DF41BC", Slot = "20")]
	public override void ProcessFrame(Playable playable, FrameData info, object playerData)
	{
	}

	[Token(Token = "0x600002D")]
	[Address(RVA = "0x3DF4388", Offset = "0x3DF4388", VA = "0x3DF4388", Slot = "18")]
	public override void OnBehaviourPause(Playable playable, FrameData info)
	{
	}

	[Token(Token = "0x600002E")]
	[Address(RVA = "0x3DF4394", Offset = "0x3DF4394", VA = "0x3DF4394", Slot = "14")]
	public override void OnGraphStop(Playable playable)
	{
	}

	[Token(Token = "0x600002F")]
	[Address(RVA = "0x3DF43A0", Offset = "0x3DF43A0", VA = "0x3DF43A0", Slot = "16")]
	public override void OnPlayableDestroy(Playable playable)
	{
	}

	[Token(Token = "0x6000030")]
	[Address(RVA = "0x3DF43AC", Offset = "0x3DF43AC", VA = "0x3DF43AC")]
	public TimeDilationMixerBehaviour()
	{
	}
}
[Token(Token = "0x2000015")]
[AttributeAttribute(Name = "TrackColorAttribute", RVA = "0x14BE0EC", Offset = "0x14BE0EC")]
[AttributeAttribute(Name = "TrackClipTypeAttribute", RVA = "0x14BE0EC", Offset = "0x14BE0EC")]
public class TimeDilationTrack : TrackAsset
{
	[Token(Token = "0x6000031")]
	[Address(RVA = "0x3DF43BC", Offset = "0x3DF43BC", VA = "0x3DF43BC", Slot = "24")]
	public override Playable CreateTrackMixer(PlayableGraph graph, GameObject go, int inputCount)
	{
		return default(Playable);
	}

	[Token(Token = "0x6000032")]
	[Address(RVA = "0x3DF4454", Offset = "0x3DF4454", VA = "0x3DF4454")]
	public TimeDilationTrack()
	{
	}
}
[Serializable]
[Token(Token = "0x2000016")]
public class TransformTweenBehaviour : PlayableBehaviour
{
	[Token(Token = "0x200001E")]
	public enum TweenType
	{
		[Token(Token = "0x4000042")]
		Linear,
		[Token(Token = "0x4000043")]
		Deceleration,
		[Token(Token = "0x4000044")]
		Harmonic,
		[Token(Token = "0x4000045")]
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
	[Address(RVA = "0x3DF44BC", Offset = "0x3DF44BC", VA = "0x3DF44BC", Slot = "19")]
	public override void PrepareFrame(Playable playable, FrameData info)
	{
	}

	[Token(Token = "0x6000034")]
	[Address(RVA = "0x3DF4564", Offset = "0x3DF4564", VA = "0x3DF4564")]
	public float EvaluateCurrentCurve(float time)
	{
		return default(float);
	}

	[Token(Token = "0x6000035")]
	[Address(RVA = "0x3DF465C", Offset = "0x3DF465C", VA = "0x3DF465C")]
	private bool IsCustomCurveNormalised()
	{
		return default(bool);
	}

	[Token(Token = "0x6000036")]
	[Address(RVA = "0x3DF4884", Offset = "0x3DF4884", VA = "0x3DF4884")]
	public TransformTweenBehaviour()
	{
	}
}
[Serializable]
[Token(Token = "0x2000017")]
public class TransformTweenClip : PlayableAsset, ITimelineClipAsset
{
	[Token(Token = "0x400002D")]
	[FieldOffset(Offset = "0x18")]
	public TransformTweenBehaviour template;

	[Token(Token = "0x400002E")]
	[FieldOffset(Offset = "0x20")]
	public ExposedReference<Transform> startLocation;

	[Token(Token = "0x400002F")]
	[FieldOffset(Offset = "0x30")]
	public ExposedReference<Transform> endLocation;

	[Token(Token = "0x17000006")]
	public ClipCaps clipCaps
	{
		[Token(Token = "0x6000037")]
		[Address(RVA = "0x3DF4A98", Offset = "0x3DF4A98", VA = "0x3DF4A98", Slot = "9")]
		get
		{
			return default(ClipCaps);
		}
	}

	[Token(Token = "0x6000038")]
	[Address(RVA = "0x3DF4AA0", Offset = "0x3DF4AA0", VA = "0x3DF4AA0", Slot = "6")]
	public override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
	{
		return default(Playable);
	}

	[Token(Token = "0x6000039")]
	[Address(RVA = "0x3DF4BE8", Offset = "0x3DF4BE8", VA = "0x3DF4BE8")]
	public TransformTweenClip()
	{
	}
}
[Token(Token = "0x2000018")]
public class TransformTweenMixerBehaviour : PlayableBehaviour
{
	[Token(Token = "0x4000030")]
	[FieldOffset(Offset = "0x10")]
	private bool m_FirstFrameHappened;

	[Token(Token = "0x600003A")]
	[Address(RVA = "0x3DF4C58", Offset = "0x3DF4C58", VA = "0x3DF4C58", Slot = "20")]
	public override void ProcessFrame(Playable playable, FrameData info, object playerData)
	{
	}

	[Token(Token = "0x600003B")]
	[Address(RVA = "0x3DF5380", Offset = "0x3DF5380", VA = "0x3DF5380", Slot = "16")]
	public override void OnPlayableDestroy(Playable playable)
	{
	}

	[Token(Token = "0x600003C")]
	[Address(RVA = "0x3DF536C", Offset = "0x3DF536C", VA = "0x3DF536C")]
	private static Quaternion AddQuaternions(Quaternion first, Quaternion second)
	{
		return default(Quaternion);
	}

	[Token(Token = "0x600003D")]
	[Address(RVA = "0x3DF5358", Offset = "0x3DF5358", VA = "0x3DF5358")]
	private static Quaternion ScaleQuaternion(Quaternion rotation, float multiplier)
	{
		return default(Quaternion);
	}

	[Token(Token = "0x600003E")]
	[Address(RVA = "0x3DF5388", Offset = "0x3DF5388", VA = "0x3DF5388")]
	private static float QuaternionMagnitude(Quaternion rotation)
	{
		return default(float);
	}

	[Token(Token = "0x600003F")]
	[Address(RVA = "0x3DF5268", Offset = "0x3DF5268", VA = "0x3DF5268")]
	private static Quaternion NormalizeQuaternion(Quaternion rotation)
	{
		return default(Quaternion);
	}

	[Token(Token = "0x6000040")]
	[Address(RVA = "0x3DF5474", Offset = "0x3DF5474", VA = "0x3DF5474")]
	public TransformTweenMixerBehaviour()
	{
	}
}
[Token(Token = "0x2000019")]
[AttributeAttribute(Name = "TrackColorAttribute", RVA = "0x14BE178", Offset = "0x14BE178")]
[AttributeAttribute(Name = "TrackClipTypeAttribute", RVA = "0x14BE178", Offset = "0x14BE178")]
[AttributeAttribute(Name = "TrackBindingTypeAttribute", RVA = "0x14BE178", Offset = "0x14BE178")]
public class TransformTweenTrack : TrackAsset
{
	[Token(Token = "0x6000041")]
	[Address(RVA = "0x3DF547C", Offset = "0x3DF547C", VA = "0x3DF547C", Slot = "24")]
	public override Playable CreateTrackMixer(PlayableGraph graph, GameObject go, int inputCount)
	{
		return default(Playable);
	}

	[Token(Token = "0x6000042")]
	[Address(RVA = "0x3DF5514", Offset = "0x3DF5514", VA = "0x3DF5514", Slot = "29")]
	public override void GatherProperties(PlayableDirector director, IPropertyCollector driver)
	{
	}

	[Token(Token = "0x6000043")]
	[Address(RVA = "0x3DF551C", Offset = "0x3DF551C", VA = "0x3DF551C")]
	public TransformTweenTrack()
	{
	}
}
namespace UnityEngine.Timeline;

[Token(Token = "0x200001A")]
public class VideoPlayableBehaviour : PlayableBehaviour
{
	[Token(Token = "0x4000031")]
	[FieldOffset(Offset = "0x10")]
	public VideoPlayer videoPlayer;

	[Token(Token = "0x4000032")]
	[FieldOffset(Offset = "0x18")]
	public VideoClip videoClip;

	[Token(Token = "0x4000033")]
	[FieldOffset(Offset = "0x20")]
	public bool mute;

	[Token(Token = "0x4000034")]
	[FieldOffset(Offset = "0x21")]
	public bool loop;

	[Token(Token = "0x4000035")]
	[FieldOffset(Offset = "0x28")]
	public double preloadTime;

	[Token(Token = "0x4000036")]
	[FieldOffset(Offset = "0x30")]
	public double clipInTime;

	[Token(Token = "0x4000037")]
	[FieldOffset(Offset = "0x38")]
	private bool playedOnce;

	[Token(Token = "0x4000038")]
	[FieldOffset(Offset = "0x39")]
	private bool preparing;

	[Token(Token = "0x6000044")]
	[Address(RVA = "0x3DF5584", Offset = "0x3DF5584", VA = "0x3DF5584")]
	public void PrepareVideo()
	{
	}

	[Token(Token = "0x6000045")]
	[Address(RVA = "0x3DF5A04", Offset = "0x3DF5A04", VA = "0x3DF5A04")]
	private void LoopPointReached(VideoPlayer vp)
	{
	}

	[Token(Token = "0x6000046")]
	[Address(RVA = "0x3DF5A14", Offset = "0x3DF5A14", VA = "0x3DF5A14", Slot = "19")]
	public override void PrepareFrame(Playable playable, FrameData info)
	{
	}

	[Token(Token = "0x6000047")]
	[Address(RVA = "0x3DF5CC0", Offset = "0x3DF5CC0", VA = "0x3DF5CC0", Slot = "17")]
	public override void OnBehaviourPlay(Playable playable, FrameData info)
	{
	}

	[Token(Token = "0x6000048")]
	[Address(RVA = "0x3DF5F18", Offset = "0x3DF5F18", VA = "0x3DF5F18", Slot = "18")]
	public override void OnBehaviourPause(Playable playable, FrameData info)
	{
	}

	[Token(Token = "0x6000049")]
	[Address(RVA = "0x3DF60D8", Offset = "0x3DF60D8", VA = "0x3DF60D8", Slot = "20")]
	public override void ProcessFrame(Playable playable, FrameData info, object playerData)
	{
	}

	[Token(Token = "0x600004A")]
	[Address(RVA = "0x3DF634C", Offset = "0x3DF634C", VA = "0x3DF634C", Slot = "13")]
	public override void OnGraphStart(Playable playable)
	{
	}

	[Token(Token = "0x600004B")]
	[Address(RVA = "0x3DF6354", Offset = "0x3DF6354", VA = "0x3DF6354", Slot = "14")]
	public override void OnGraphStop(Playable playable)
	{
	}

	[Token(Token = "0x600004C")]
	[Address(RVA = "0x3DF638C", Offset = "0x3DF638C", VA = "0x3DF638C", Slot = "16")]
	public override void OnPlayableDestroy(Playable playable)
	{
	}

	[Token(Token = "0x600004D")]
	[Address(RVA = "0x3DF5DA8", Offset = "0x3DF5DA8", VA = "0x3DF5DA8")]
	public void PlayVideo()
	{
	}

	[Token(Token = "0x600004E")]
	[Address(RVA = "0x3DF5FF0", Offset = "0x3DF5FF0", VA = "0x3DF5FF0")]
	public void PauseVideo()
	{
	}

	[Token(Token = "0x600004F")]
	[Address(RVA = "0x3DF5970", Offset = "0x3DF5970", VA = "0x3DF5970")]
	public void StopVideo()
	{
	}

	[Token(Token = "0x6000050")]
	[Address(RVA = "0x3DF5B48", Offset = "0x3DF5B48", VA = "0x3DF5B48")]
	private void SyncVideoToPlayable(Playable playable)
	{
	}

	[Token(Token = "0x6000051")]
	[Address(RVA = "0x3DF6390", Offset = "0x3DF6390", VA = "0x3DF6390")]
	public VideoPlayableBehaviour()
	{
	}
}
[Token(Token = "0x200001B")]
public sealed class VideoSchedulerPlayableBehaviour : PlayableBehaviour
{
	[Token(Token = "0x4000039")]
	[FieldOffset(Offset = "0x10")]
	private IEnumerable<TimelineClip> m_Clips;

	[Token(Token = "0x400003A")]
	[FieldOffset(Offset = "0x18")]
	private PlayableDirector m_Director;

	[Token(Token = "0x17000007")]
	internal PlayableDirector director
	{
		[Token(Token = "0x6000052")]
		[Address(RVA = "0x3DF63AC", Offset = "0x3DF63AC", VA = "0x3DF63AC")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000053")]
		[Address(RVA = "0x3DF63B4", Offset = "0x3DF63B4", VA = "0x3DF63B4")]
		set
		{
		}
	}

	[Token(Token = "0x17000008")]
	internal IEnumerable<TimelineClip> clips
	{
		[Token(Token = "0x6000054")]
		[Address(RVA = "0x3DF63BC", Offset = "0x3DF63BC", VA = "0x3DF63BC")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000055")]
		[Address(RVA = "0x3DF63C4", Offset = "0x3DF63C4", VA = "0x3DF63C4")]
		set
		{
		}
	}

	[Token(Token = "0x6000056")]
	[Address(RVA = "0x3DF63CC", Offset = "0x3DF63CC", VA = "0x3DF63CC", Slot = "20")]
	public override void ProcessFrame(Playable playable, FrameData info, object playerData)
	{
	}

	[Token(Token = "0x6000057")]
	[Address(RVA = "0x3DF67CC", Offset = "0x3DF67CC", VA = "0x3DF67CC")]
	public VideoSchedulerPlayableBehaviour()
	{
	}
}
[Serializable]
[Token(Token = "0x200001C")]
public class VideoScriptPlayableAsset : PlayableAsset
{
	[Token(Token = "0x400003B")]
	[FieldOffset(Offset = "0x18")]
	public ExposedReference<VideoPlayer> videoPlayer;

	[Token(Token = "0x400003C")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	[NotKeyable]
	public VideoClip videoClip;

	[Token(Token = "0x400003D")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	[NotKeyable]
	public bool mute;

	[Token(Token = "0x400003E")]
	[FieldOffset(Offset = "0x31")]
	[SerializeField]
	[NotKeyable]
	public bool loop;

	[Token(Token = "0x400003F")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	[NotKeyable]
	public double preloadTime;

	[Token(Token = "0x4000040")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	[NotKeyable]
	public double clipInTime;

	[Token(Token = "0x6000058")]
	[Address(RVA = "0x3DF67D4", Offset = "0x3DF67D4", VA = "0x3DF67D4", Slot = "6")]
	public override Playable CreatePlayable(PlayableGraph graph, GameObject go)
	{
		return default(Playable);
	}

	[Token(Token = "0x6000059")]
	[Address(RVA = "0x3DF6914", Offset = "0x3DF6914", VA = "0x3DF6914")]
	public VideoScriptPlayableAsset()
	{
	}
}
[Serializable]
[Token(Token = "0x200001D")]
[AttributeAttribute(Name = "TrackClipTypeAttribute", RVA = "0x14BE22C", Offset = "0x14BE22C")]
[AttributeAttribute(Name = "TrackColorAttribute", RVA = "0x14BE22C", Offset = "0x14BE22C")]
public class VideoScriptPlayableTrack : TrackAsset
{
	[Token(Token = "0x600005A")]
	[Address(RVA = "0x3DF6930", Offset = "0x3DF6930", VA = "0x3DF6930", Slot = "24")]
	public override Playable CreateTrackMixer(PlayableGraph graph, GameObject go, int inputCount)
	{
		return default(Playable);
	}

	[Token(Token = "0x600005B")]
	[Address(RVA = "0x3DF6A84", Offset = "0x3DF6A84", VA = "0x3DF6A84")]
	public VideoScriptPlayableTrack()
	{
	}
}
