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
	[Address(RVA = "0x28CA1A0", Offset = "0x28CA1A0", VA = "0x28CA1A0")]
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
		[Address(RVA = "0x28CA1E4", Offset = "0x28CA1E4", VA = "0x28CA1E4", Slot = "9")]
		get
		{
			return default(ClipCaps);
		}
	}

	[Token(Token = "0x6000003")]
	[Address(RVA = "0x28CA1EC", Offset = "0x28CA1EC", VA = "0x28CA1EC", Slot = "6")]
	public override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
	{
		return default(Playable);
	}

	[Token(Token = "0x6000004")]
	[Address(RVA = "0x28CA28C", Offset = "0x28CA28C", VA = "0x28CA28C")]
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
	[Address(RVA = "0x28CA2FC", Offset = "0x28CA2FC", VA = "0x28CA2FC", Slot = "20")]
	public override void ProcessFrame(Playable playable, FrameData info, object playerData)
	{
	}

	[Token(Token = "0x6000006")]
	[Address(RVA = "0x28CA6E0", Offset = "0x28CA6E0", VA = "0x28CA6E0", Slot = "16")]
	public override void OnPlayableDestroy(Playable playable)
	{
	}

	[Token(Token = "0x6000007")]
	[Address(RVA = "0x28CA7BC", Offset = "0x28CA7BC", VA = "0x28CA7BC")]
	public LightControlMixerBehaviour()
	{
	}
}
[Token(Token = "0x2000005")]
[AttributeAttribute(Name = "TrackColorAttribute", RVA = "0xD15EE4", Offset = "0xD15EE4")]
[AttributeAttribute(Name = "TrackClipTypeAttribute", RVA = "0xD15EE4", Offset = "0xD15EE4")]
[AttributeAttribute(Name = "TrackBindingTypeAttribute", RVA = "0xD15EE4", Offset = "0xD15EE4")]
public class LightControlTrack : TrackAsset
{
	[Token(Token = "0x6000008")]
	[Address(RVA = "0x28CA7C4", Offset = "0x28CA7C4", VA = "0x28CA7C4", Slot = "24")]
	public override Playable CreateTrackMixer(PlayableGraph graph, GameObject go, int inputCount)
	{
		return default(Playable);
	}

	[Token(Token = "0x6000009")]
	[Address(RVA = "0x28CA85C", Offset = "0x28CA85C", VA = "0x28CA85C", Slot = "29")]
	public override void GatherProperties(PlayableDirector director, IPropertyCollector driver)
	{
	}

	[Token(Token = "0x600000A")]
	[Address(RVA = "0x28CA864", Offset = "0x28CA864", VA = "0x28CA864")]
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
	[Address(RVA = "0x28CA8CC", Offset = "0x28CA8CC", VA = "0x28CA8CC", Slot = "15")]
	public override void OnPlayableCreate(Playable playable)
	{
	}

	[Token(Token = "0x600000C")]
	[Address(RVA = "0x28CA8D4", Offset = "0x28CA8D4", VA = "0x28CA8D4")]
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
		[Address(RVA = "0x28CA8DC", Offset = "0x28CA8DC", VA = "0x28CA8DC", Slot = "9")]
		get
		{
			return default(ClipCaps);
		}
	}

	[Token(Token = "0x600000E")]
	[Address(RVA = "0x28CA8E4", Offset = "0x28CA8E4", VA = "0x28CA8E4", Slot = "6")]
	public override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
	{
		return default(Playable);
	}

	[Token(Token = "0x600000F")]
	[Address(RVA = "0x28CA9FC", Offset = "0x28CA9FC", VA = "0x28CA9FC")]
	public NavMeshAgentControlClip()
	{
	}
}
[Token(Token = "0x2000008")]
public class NavMeshAgentControlMixerBehaviour : PlayableBehaviour
{
	[Token(Token = "0x6000010")]
	[Address(RVA = "0x28CAA70", Offset = "0x28CAA70", VA = "0x28CAA70", Slot = "20")]
	public override void ProcessFrame(Playable playable, FrameData info, object playerData)
	{
	}

	[Token(Token = "0x6000011")]
	[Address(RVA = "0x28CACA0", Offset = "0x28CACA0", VA = "0x28CACA0")]
	public NavMeshAgentControlMixerBehaviour()
	{
	}
}
[Token(Token = "0x2000009")]
[AttributeAttribute(Name = "TrackColorAttribute", RVA = "0xD15F98", Offset = "0xD15F98")]
[AttributeAttribute(Name = "TrackClipTypeAttribute", RVA = "0xD15F98", Offset = "0xD15F98")]
[AttributeAttribute(Name = "TrackBindingTypeAttribute", RVA = "0xD15F98", Offset = "0xD15F98")]
public class NavMeshAgentControlTrack : TrackAsset
{
	[Token(Token = "0x6000012")]
	[Address(RVA = "0x28CACA8", Offset = "0x28CACA8", VA = "0x28CACA8", Slot = "24")]
	public override Playable CreateTrackMixer(PlayableGraph graph, GameObject go, int inputCount)
	{
		return default(Playable);
	}

	[Token(Token = "0x6000013")]
	[Address(RVA = "0x28CAD40", Offset = "0x28CAD40", VA = "0x28CAD40")]
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
	[Address(RVA = "0x28CADA8", Offset = "0x28CADA8", VA = "0x28CADA8")]
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
		[Address(RVA = "0x28CADDC", Offset = "0x28CADDC", VA = "0x28CADDC", Slot = "9")]
		get
		{
			return default(ClipCaps);
		}
	}

	[Token(Token = "0x6000016")]
	[Address(RVA = "0x28CADE4", Offset = "0x28CADE4", VA = "0x28CADE4", Slot = "6")]
	public override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
	{
		return default(Playable);
	}

	[Token(Token = "0x6000017")]
	[Address(RVA = "0x28CAE84", Offset = "0x28CAE84", VA = "0x28CAE84")]
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
	[Address(RVA = "0x28CAEF4", Offset = "0x28CAEF4", VA = "0x28CAEF4", Slot = "20")]
	public override void ProcessFrame(Playable playable, FrameData info, object playerData)
	{
	}

	[Token(Token = "0x6000019")]
	[Address(RVA = "0x28CB218", Offset = "0x28CB218", VA = "0x28CB218", Slot = "16")]
	public override void OnPlayableDestroy(Playable playable)
	{
	}

	[Token(Token = "0x600001A")]
	[Address(RVA = "0x28CB2C0", Offset = "0x28CB2C0", VA = "0x28CB2C0")]
	public ScreenFaderMixerBehaviour()
	{
	}
}
[Token(Token = "0x200000D")]
[AttributeAttribute(Name = "TrackColorAttribute", RVA = "0xD1604C", Offset = "0xD1604C")]
[AttributeAttribute(Name = "TrackClipTypeAttribute", RVA = "0xD1604C", Offset = "0xD1604C")]
[AttributeAttribute(Name = "TrackBindingTypeAttribute", RVA = "0xD1604C", Offset = "0xD1604C")]
public class ScreenFaderTrack : TrackAsset
{
	[Token(Token = "0x600001B")]
	[Address(RVA = "0x28CB2C8", Offset = "0x28CB2C8", VA = "0x28CB2C8", Slot = "24")]
	public override Playable CreateTrackMixer(PlayableGraph graph, GameObject go, int inputCount)
	{
		return default(Playable);
	}

	[Token(Token = "0x600001C")]
	[Address(RVA = "0x28CB360", Offset = "0x28CB360", VA = "0x28CB360", Slot = "29")]
	public override void GatherProperties(PlayableDirector director, IPropertyCollector driver)
	{
	}

	[Token(Token = "0x600001D")]
	[Address(RVA = "0x28CB368", Offset = "0x28CB368", VA = "0x28CB368")]
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
	[Address(RVA = "0x28CB3D0", Offset = "0x28CB3D0", VA = "0x28CB3D0")]
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
		[Address(RVA = "0x28CB40C", Offset = "0x28CB40C", VA = "0x28CB40C", Slot = "9")]
		get
		{
			return default(ClipCaps);
		}
	}

	[Token(Token = "0x6000020")]
	[Address(RVA = "0x28CB414", Offset = "0x28CB414", VA = "0x28CB414", Slot = "6")]
	public override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
	{
		return default(Playable);
	}

	[Token(Token = "0x6000021")]
	[Address(RVA = "0x28CB4B4", Offset = "0x28CB4B4", VA = "0x28CB4B4")]
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
	[Address(RVA = "0x28CB524", Offset = "0x28CB524", VA = "0x28CB524", Slot = "20")]
	public override void ProcessFrame(Playable playable, FrameData info, object playerData)
	{
	}

	[Token(Token = "0x6000023")]
	[Address(RVA = "0x28CB990", Offset = "0x28CB990", VA = "0x28CB990", Slot = "16")]
	public override void OnPlayableDestroy(Playable playable)
	{
	}

	[Token(Token = "0x6000024")]
	[Address(RVA = "0x28CBA68", Offset = "0x28CBA68", VA = "0x28CBA68")]
	public TextSwitcherMixerBehaviour()
	{
	}
}
[Token(Token = "0x2000011")]
[AttributeAttribute(Name = "TrackColorAttribute", RVA = "0xD160FC", Offset = "0xD160FC")]
[AttributeAttribute(Name = "TrackClipTypeAttribute", RVA = "0xD160FC", Offset = "0xD160FC")]
[AttributeAttribute(Name = "TrackBindingTypeAttribute", RVA = "0xD160FC", Offset = "0xD160FC")]
public class TextSwitcherTrack : TrackAsset
{
	[Token(Token = "0x6000025")]
	[Address(RVA = "0x28CBA70", Offset = "0x28CBA70", VA = "0x28CBA70", Slot = "24")]
	public override Playable CreateTrackMixer(PlayableGraph graph, GameObject go, int inputCount)
	{
		return default(Playable);
	}

	[Token(Token = "0x6000026")]
	[Address(RVA = "0x28CBB08", Offset = "0x28CBB08", VA = "0x28CBB08", Slot = "29")]
	public override void GatherProperties(PlayableDirector director, IPropertyCollector driver)
	{
	}

	[Token(Token = "0x6000027")]
	[Address(RVA = "0x28CBB10", Offset = "0x28CBB10", VA = "0x28CBB10")]
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
	[Address(RVA = "0x28CBB78", Offset = "0x28CBB78", VA = "0x28CBB78")]
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
		[Address(RVA = "0x28CBB88", Offset = "0x28CBB88", VA = "0x28CBB88", Slot = "9")]
		get
		{
			return default(ClipCaps);
		}
	}

	[Token(Token = "0x600002A")]
	[Address(RVA = "0x28CBB90", Offset = "0x28CBB90", VA = "0x28CBB90", Slot = "6")]
	public override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
	{
		return default(Playable);
	}

	[Token(Token = "0x600002B")]
	[Address(RVA = "0x28CBC30", Offset = "0x28CBC30", VA = "0x28CBC30")]
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
	[Address(RVA = "0x28CBCAC", Offset = "0x28CBCAC", VA = "0x28CBCAC", Slot = "20")]
	public override void ProcessFrame(Playable playable, FrameData info, object playerData)
	{
	}

	[Token(Token = "0x600002D")]
	[Address(RVA = "0x28CBE78", Offset = "0x28CBE78", VA = "0x28CBE78", Slot = "18")]
	public override void OnBehaviourPause(Playable playable, FrameData info)
	{
	}

	[Token(Token = "0x600002E")]
	[Address(RVA = "0x28CBE84", Offset = "0x28CBE84", VA = "0x28CBE84", Slot = "14")]
	public override void OnGraphStop(Playable playable)
	{
	}

	[Token(Token = "0x600002F")]
	[Address(RVA = "0x28CBE90", Offset = "0x28CBE90", VA = "0x28CBE90", Slot = "16")]
	public override void OnPlayableDestroy(Playable playable)
	{
	}

	[Token(Token = "0x6000030")]
	[Address(RVA = "0x28CBE9C", Offset = "0x28CBE9C", VA = "0x28CBE9C")]
	public TimeDilationMixerBehaviour()
	{
	}
}
[Token(Token = "0x2000015")]
[AttributeAttribute(Name = "TrackColorAttribute", RVA = "0xD161B0", Offset = "0xD161B0")]
[AttributeAttribute(Name = "TrackClipTypeAttribute", RVA = "0xD161B0", Offset = "0xD161B0")]
public class TimeDilationTrack : TrackAsset
{
	[Token(Token = "0x6000031")]
	[Address(RVA = "0x28CBEAC", Offset = "0x28CBEAC", VA = "0x28CBEAC", Slot = "24")]
	public override Playable CreateTrackMixer(PlayableGraph graph, GameObject go, int inputCount)
	{
		return default(Playable);
	}

	[Token(Token = "0x6000032")]
	[Address(RVA = "0x28CBF44", Offset = "0x28CBF44", VA = "0x28CBF44")]
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
	[Address(RVA = "0x28CBFAC", Offset = "0x28CBFAC", VA = "0x28CBFAC", Slot = "19")]
	public override void PrepareFrame(Playable playable, FrameData info)
	{
	}

	[Token(Token = "0x6000034")]
	[Address(RVA = "0x28CC054", Offset = "0x28CC054", VA = "0x28CC054")]
	public float EvaluateCurrentCurve(float time)
	{
		return default(float);
	}

	[Token(Token = "0x6000035")]
	[Address(RVA = "0x28CC14C", Offset = "0x28CC14C", VA = "0x28CC14C")]
	private bool IsCustomCurveNormalised()
	{
		return default(bool);
	}

	[Token(Token = "0x6000036")]
	[Address(RVA = "0x28CC374", Offset = "0x28CC374", VA = "0x28CC374")]
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
		[Address(RVA = "0x28CC588", Offset = "0x28CC588", VA = "0x28CC588", Slot = "9")]
		get
		{
			return default(ClipCaps);
		}
	}

	[Token(Token = "0x6000038")]
	[Address(RVA = "0x28CC590", Offset = "0x28CC590", VA = "0x28CC590", Slot = "6")]
	public override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
	{
		return default(Playable);
	}

	[Token(Token = "0x6000039")]
	[Address(RVA = "0x28CC6D8", Offset = "0x28CC6D8", VA = "0x28CC6D8")]
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
	[Address(RVA = "0x28CC748", Offset = "0x28CC748", VA = "0x28CC748", Slot = "20")]
	public override void ProcessFrame(Playable playable, FrameData info, object playerData)
	{
	}

	[Token(Token = "0x600003B")]
	[Address(RVA = "0x28CCE70", Offset = "0x28CCE70", VA = "0x28CCE70", Slot = "16")]
	public override void OnPlayableDestroy(Playable playable)
	{
	}

	[Token(Token = "0x600003C")]
	[Address(RVA = "0x28CCE5C", Offset = "0x28CCE5C", VA = "0x28CCE5C")]
	private static Quaternion AddQuaternions(Quaternion first, Quaternion second)
	{
		return default(Quaternion);
	}

	[Token(Token = "0x600003D")]
	[Address(RVA = "0x28CCE48", Offset = "0x28CCE48", VA = "0x28CCE48")]
	private static Quaternion ScaleQuaternion(Quaternion rotation, float multiplier)
	{
		return default(Quaternion);
	}

	[Token(Token = "0x600003E")]
	[Address(RVA = "0x28CCE78", Offset = "0x28CCE78", VA = "0x28CCE78")]
	private static float QuaternionMagnitude(Quaternion rotation)
	{
		return default(float);
	}

	[Token(Token = "0x600003F")]
	[Address(RVA = "0x28CCD58", Offset = "0x28CCD58", VA = "0x28CCD58")]
	private static Quaternion NormalizeQuaternion(Quaternion rotation)
	{
		return default(Quaternion);
	}

	[Token(Token = "0x6000040")]
	[Address(RVA = "0x28CCF64", Offset = "0x28CCF64", VA = "0x28CCF64")]
	public TransformTweenMixerBehaviour()
	{
	}
}
[Token(Token = "0x2000019")]
[AttributeAttribute(Name = "TrackColorAttribute", RVA = "0xD1623C", Offset = "0xD1623C")]
[AttributeAttribute(Name = "TrackClipTypeAttribute", RVA = "0xD1623C", Offset = "0xD1623C")]
[AttributeAttribute(Name = "TrackBindingTypeAttribute", RVA = "0xD1623C", Offset = "0xD1623C")]
public class TransformTweenTrack : TrackAsset
{
	[Token(Token = "0x6000041")]
	[Address(RVA = "0x28CCF6C", Offset = "0x28CCF6C", VA = "0x28CCF6C", Slot = "24")]
	public override Playable CreateTrackMixer(PlayableGraph graph, GameObject go, int inputCount)
	{
		return default(Playable);
	}

	[Token(Token = "0x6000042")]
	[Address(RVA = "0x28CD004", Offset = "0x28CD004", VA = "0x28CD004", Slot = "29")]
	public override void GatherProperties(PlayableDirector director, IPropertyCollector driver)
	{
	}

	[Token(Token = "0x6000043")]
	[Address(RVA = "0x28CD00C", Offset = "0x28CD00C", VA = "0x28CD00C")]
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
	[Address(RVA = "0x28CD074", Offset = "0x28CD074", VA = "0x28CD074")]
	public void PrepareVideo()
	{
	}

	[Token(Token = "0x6000045")]
	[Address(RVA = "0x28CD4F4", Offset = "0x28CD4F4", VA = "0x28CD4F4")]
	private void LoopPointReached(VideoPlayer vp)
	{
	}

	[Token(Token = "0x6000046")]
	[Address(RVA = "0x28CD504", Offset = "0x28CD504", VA = "0x28CD504", Slot = "19")]
	public override void PrepareFrame(Playable playable, FrameData info)
	{
	}

	[Token(Token = "0x6000047")]
	[Address(RVA = "0x28CD7B0", Offset = "0x28CD7B0", VA = "0x28CD7B0", Slot = "17")]
	public override void OnBehaviourPlay(Playable playable, FrameData info)
	{
	}

	[Token(Token = "0x6000048")]
	[Address(RVA = "0x28CDA08", Offset = "0x28CDA08", VA = "0x28CDA08", Slot = "18")]
	public override void OnBehaviourPause(Playable playable, FrameData info)
	{
	}

	[Token(Token = "0x6000049")]
	[Address(RVA = "0x28CDBC8", Offset = "0x28CDBC8", VA = "0x28CDBC8", Slot = "20")]
	public override void ProcessFrame(Playable playable, FrameData info, object playerData)
	{
	}

	[Token(Token = "0x600004A")]
	[Address(RVA = "0x28CDE3C", Offset = "0x28CDE3C", VA = "0x28CDE3C", Slot = "13")]
	public override void OnGraphStart(Playable playable)
	{
	}

	[Token(Token = "0x600004B")]
	[Address(RVA = "0x28CDE44", Offset = "0x28CDE44", VA = "0x28CDE44", Slot = "14")]
	public override void OnGraphStop(Playable playable)
	{
	}

	[Token(Token = "0x600004C")]
	[Address(RVA = "0x28CDE7C", Offset = "0x28CDE7C", VA = "0x28CDE7C", Slot = "16")]
	public override void OnPlayableDestroy(Playable playable)
	{
	}

	[Token(Token = "0x600004D")]
	[Address(RVA = "0x28CD898", Offset = "0x28CD898", VA = "0x28CD898")]
	public void PlayVideo()
	{
	}

	[Token(Token = "0x600004E")]
	[Address(RVA = "0x28CDAE0", Offset = "0x28CDAE0", VA = "0x28CDAE0")]
	public void PauseVideo()
	{
	}

	[Token(Token = "0x600004F")]
	[Address(RVA = "0x28CD460", Offset = "0x28CD460", VA = "0x28CD460")]
	public void StopVideo()
	{
	}

	[Token(Token = "0x6000050")]
	[Address(RVA = "0x28CD638", Offset = "0x28CD638", VA = "0x28CD638")]
	private void SyncVideoToPlayable(Playable playable)
	{
	}

	[Token(Token = "0x6000051")]
	[Address(RVA = "0x28CDE80", Offset = "0x28CDE80", VA = "0x28CDE80")]
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
		[Address(RVA = "0x28CDE9C", Offset = "0x28CDE9C", VA = "0x28CDE9C")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000053")]
		[Address(RVA = "0x28CDEA4", Offset = "0x28CDEA4", VA = "0x28CDEA4")]
		set
		{
		}
	}

	[Token(Token = "0x17000008")]
	internal IEnumerable<TimelineClip> clips
	{
		[Token(Token = "0x6000054")]
		[Address(RVA = "0x28CDEAC", Offset = "0x28CDEAC", VA = "0x28CDEAC")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000055")]
		[Address(RVA = "0x28CDEB4", Offset = "0x28CDEB4", VA = "0x28CDEB4")]
		set
		{
		}
	}

	[Token(Token = "0x6000056")]
	[Address(RVA = "0x28CDEBC", Offset = "0x28CDEBC", VA = "0x28CDEBC", Slot = "20")]
	public override void ProcessFrame(Playable playable, FrameData info, object playerData)
	{
	}

	[Token(Token = "0x6000057")]
	[Address(RVA = "0x28CE2BC", Offset = "0x28CE2BC", VA = "0x28CE2BC")]
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
	[Address(RVA = "0x28CE2C4", Offset = "0x28CE2C4", VA = "0x28CE2C4", Slot = "6")]
	public override Playable CreatePlayable(PlayableGraph graph, GameObject go)
	{
		return default(Playable);
	}

	[Token(Token = "0x6000059")]
	[Address(RVA = "0x28CE404", Offset = "0x28CE404", VA = "0x28CE404")]
	public VideoScriptPlayableAsset()
	{
	}
}
[Serializable]
[Token(Token = "0x200001D")]
[AttributeAttribute(Name = "TrackClipTypeAttribute", RVA = "0xD162F0", Offset = "0xD162F0")]
[AttributeAttribute(Name = "TrackColorAttribute", RVA = "0xD162F0", Offset = "0xD162F0")]
public class VideoScriptPlayableTrack : TrackAsset
{
	[Token(Token = "0x600005A")]
	[Address(RVA = "0x28CE420", Offset = "0x28CE420", VA = "0x28CE420", Slot = "24")]
	public override Playable CreateTrackMixer(PlayableGraph graph, GameObject go, int inputCount)
	{
		return default(Playable);
	}

	[Token(Token = "0x600005B")]
	[Address(RVA = "0x28CE574", Offset = "0x28CE574", VA = "0x28CE574")]
	public VideoScriptPlayableTrack()
	{
	}
}
