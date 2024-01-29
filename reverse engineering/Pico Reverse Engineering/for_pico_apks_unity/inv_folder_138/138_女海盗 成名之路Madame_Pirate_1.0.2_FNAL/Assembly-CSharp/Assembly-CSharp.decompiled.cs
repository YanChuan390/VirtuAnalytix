using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading;
using Facebook.Audio;
using Il2CppDummyDll;
using RenderHeads.Media.AVProVideo;
using TBE;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Networking;
using UnityEngine.Playables;
using UnityEngine.Rendering;
using UnityEngine.Timeline;
using UnityEngine.UI;
using UnityEngine.Video;
using UnityEngine.XR;

[assembly: AssemblyVersion("0.0.0.0")]
[Token(Token = "0x2000002")]
public class ColorGamut : MonoBehaviour
{
	[Token(Token = "0x6000001")]
	[Address(RVA = "0xD2D2AC", Offset = "0xD2D2AC", VA = "0xD2D2AC")]
	private void Start()
	{
	}

	[Token(Token = "0x6000002")]
	[Address(RVA = "0xD2D2B0", Offset = "0xD2D2B0", VA = "0xD2D2B0")]
	private void Update()
	{
	}

	[Token(Token = "0x6000003")]
	[Address(RVA = "0xD2D2B4", Offset = "0xD2D2B4", VA = "0xD2D2B4")]
	public ColorGamut()
	{
	}
}
[Serializable]
[Token(Token = "0x2000003")]
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

	[Token(Token = "0x6000004")]
	[Address(RVA = "0xD2FD54", Offset = "0xD2FD54", VA = "0xD2FD54")]
	public LightControlBehaviour()
	{
	}
}
[Serializable]
[Token(Token = "0x2000004")]
public class LightControlClip : PlayableAsset, ITimelineClipAsset
{
	[Token(Token = "0x4000005")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public LightControlBehaviour template;

	[Token(Token = "0x17000001")]
	public ClipCaps clipCaps
	{
		[Token(Token = "0x6000005")]
		[Address(RVA = "0xD2FD98", Offset = "0xD2FD98", VA = "0xD2FD98", Slot = "9")]
		get
		{
			return default(ClipCaps);
		}
	}

	[Token(Token = "0x6000006")]
	[Address(RVA = "0xD2FDA0", Offset = "0xD2FDA0", VA = "0xD2FDA0", Slot = "6")]
	public override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
	{
		return default(Playable);
	}

	[Token(Token = "0x6000007")]
	[Address(RVA = "0xD2FE40", Offset = "0xD2FE40", VA = "0xD2FE40")]
	public LightControlClip()
	{
	}
}
[Token(Token = "0x2000005")]
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

	[Token(Token = "0x6000008")]
	[Address(RVA = "0xD2FEA4", Offset = "0xD2FEA4", VA = "0xD2FEA4", Slot = "20")]
	public override void ProcessFrame(Playable playable, FrameData info, object playerData)
	{
	}

	[Token(Token = "0x6000009")]
	[Address(RVA = "0xD30270", Offset = "0xD30270", VA = "0xD30270", Slot = "16")]
	public override void OnPlayableDestroy(Playable playable)
	{
	}

	[Token(Token = "0x600000A")]
	[Address(RVA = "0xD3034C", Offset = "0xD3034C", VA = "0xD3034C")]
	public LightControlMixerBehaviour()
	{
	}
}
[Token(Token = "0x2000006")]
[AttributeAttribute(Name = "TrackColorAttribute", RVA = "0x61FF38", Offset = "0x61FF38")]
[AttributeAttribute(Name = "TrackClipTypeAttribute", RVA = "0x61FF38", Offset = "0x61FF38")]
[AttributeAttribute(Name = "TrackBindingTypeAttribute", RVA = "0x61FF38", Offset = "0x61FF38")]
public class LightControlTrack : TrackAsset
{
	[Token(Token = "0x600000B")]
	[Address(RVA = "0xD30354", Offset = "0xD30354", VA = "0xD30354", Slot = "24")]
	public override Playable CreateTrackMixer(PlayableGraph graph, GameObject go, int inputCount)
	{
		return default(Playable);
	}

	[Token(Token = "0x600000C")]
	[Address(RVA = "0xD303EC", Offset = "0xD303EC", VA = "0xD303EC", Slot = "29")]
	public override void GatherProperties(PlayableDirector director, IPropertyCollector driver)
	{
	}

	[Token(Token = "0x600000D")]
	[Address(RVA = "0xD303F4", Offset = "0xD303F4", VA = "0xD303F4")]
	public LightControlTrack()
	{
	}
}
[Serializable]
[Token(Token = "0x2000007")]
public class NavMeshAgentControlBehaviour : PlayableBehaviour
{
	[Token(Token = "0x400000C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public Transform destination;

	[Token(Token = "0x400000D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool destinationSet;

	[Token(Token = "0x600000E")]
	[Address(RVA = "0xD30518", Offset = "0xD30518", VA = "0xD30518", Slot = "15")]
	public override void OnPlayableCreate(Playable playable)
	{
	}

	[Token(Token = "0x600000F")]
	[Address(RVA = "0xD30520", Offset = "0xD30520", VA = "0xD30520")]
	public NavMeshAgentControlBehaviour()
	{
	}
}
[Serializable]
[Token(Token = "0x2000008")]
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
		[Token(Token = "0x6000010")]
		[Address(RVA = "0xD30528", Offset = "0xD30528", VA = "0xD30528", Slot = "9")]
		get
		{
			return default(ClipCaps);
		}
	}

	[Token(Token = "0x6000011")]
	[Address(RVA = "0xD30530", Offset = "0xD30530", VA = "0xD30530", Slot = "6")]
	public override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
	{
		return default(Playable);
	}

	[Token(Token = "0x6000012")]
	[Address(RVA = "0xD3063C", Offset = "0xD3063C", VA = "0xD3063C")]
	public NavMeshAgentControlClip()
	{
	}
}
[Token(Token = "0x2000009")]
public class NavMeshAgentControlMixerBehaviour : PlayableBehaviour
{
	[Token(Token = "0x6000013")]
	[Address(RVA = "0xD306A4", Offset = "0xD306A4", VA = "0xD306A4", Slot = "20")]
	public override void ProcessFrame(Playable playable, FrameData info, object playerData)
	{
	}

	[Token(Token = "0x6000014")]
	[Address(RVA = "0xD308D4", Offset = "0xD308D4", VA = "0xD308D4")]
	public NavMeshAgentControlMixerBehaviour()
	{
	}
}
[Token(Token = "0x200000A")]
[AttributeAttribute(Name = "TrackColorAttribute", RVA = "0x61FFEC", Offset = "0x61FFEC")]
[AttributeAttribute(Name = "TrackClipTypeAttribute", RVA = "0x61FFEC", Offset = "0x61FFEC")]
[AttributeAttribute(Name = "TrackBindingTypeAttribute", RVA = "0x61FFEC", Offset = "0x61FFEC")]
public class NavMeshAgentControlTrack : TrackAsset
{
	[Token(Token = "0x6000015")]
	[Address(RVA = "0xD308DC", Offset = "0xD308DC", VA = "0xD308DC", Slot = "24")]
	public override Playable CreateTrackMixer(PlayableGraph graph, GameObject go, int inputCount)
	{
		return default(Playable);
	}

	[Token(Token = "0x6000016")]
	[Address(RVA = "0xD30974", Offset = "0xD30974", VA = "0xD30974")]
	public NavMeshAgentControlTrack()
	{
	}
}
[Serializable]
[Token(Token = "0x200000B")]
public class ScreenFaderBehaviour : PlayableBehaviour
{
	[Token(Token = "0x4000010")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public Color color;

	[Token(Token = "0x6000017")]
	[Address(RVA = "0xD314AC", Offset = "0xD314AC", VA = "0xD314AC")]
	public ScreenFaderBehaviour()
	{
	}
}
[Serializable]
[Token(Token = "0x200000C")]
public class ScreenFaderClip : PlayableAsset, ITimelineClipAsset
{
	[Token(Token = "0x4000011")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public ScreenFaderBehaviour template;

	[Token(Token = "0x17000003")]
	public ClipCaps clipCaps
	{
		[Token(Token = "0x6000018")]
		[Address(RVA = "0xD314E0", Offset = "0xD314E0", VA = "0xD314E0", Slot = "9")]
		get
		{
			return default(ClipCaps);
		}
	}

	[Token(Token = "0x6000019")]
	[Address(RVA = "0xD314E8", Offset = "0xD314E8", VA = "0xD314E8", Slot = "6")]
	public override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
	{
		return default(Playable);
	}

	[Token(Token = "0x600001A")]
	[Address(RVA = "0xD31588", Offset = "0xD31588", VA = "0xD31588")]
	public ScreenFaderClip()
	{
	}
}
[Token(Token = "0x200000D")]
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

	[Token(Token = "0x600001B")]
	[Address(RVA = "0xD315EC", Offset = "0xD315EC", VA = "0xD315EC", Slot = "20")]
	public override void ProcessFrame(Playable playable, FrameData info, object playerData)
	{
	}

	[Token(Token = "0x600001C")]
	[Address(RVA = "0xD31900", Offset = "0xD31900", VA = "0xD31900", Slot = "16")]
	public override void OnPlayableDestroy(Playable playable)
	{
	}

	[Token(Token = "0x600001D")]
	[Address(RVA = "0xD319A8", Offset = "0xD319A8", VA = "0xD319A8")]
	public ScreenFaderMixerBehaviour()
	{
	}
}
[Token(Token = "0x200000E")]
[AttributeAttribute(Name = "TrackColorAttribute", RVA = "0x6200A0", Offset = "0x6200A0")]
[AttributeAttribute(Name = "TrackClipTypeAttribute", RVA = "0x6200A0", Offset = "0x6200A0")]
[AttributeAttribute(Name = "TrackBindingTypeAttribute", RVA = "0x6200A0", Offset = "0x6200A0")]
public class ScreenFaderTrack : TrackAsset
{
	[Token(Token = "0x600001E")]
	[Address(RVA = "0xD319B0", Offset = "0xD319B0", VA = "0xD319B0", Slot = "24")]
	public override Playable CreateTrackMixer(PlayableGraph graph, GameObject go, int inputCount)
	{
		return default(Playable);
	}

	[Token(Token = "0x600001F")]
	[Address(RVA = "0xD31A48", Offset = "0xD31A48", VA = "0xD31A48", Slot = "29")]
	public override void GatherProperties(PlayableDirector director, IPropertyCollector driver)
	{
	}

	[Token(Token = "0x6000020")]
	[Address(RVA = "0xD31A50", Offset = "0xD31A50", VA = "0xD31A50")]
	public ScreenFaderTrack()
	{
	}
}
[Serializable]
[Token(Token = "0x200000F")]
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

	[Token(Token = "0x6000021")]
	[Address(RVA = "0x116534C", Offset = "0x116534C", VA = "0x116534C")]
	public TextSwitcherBehaviour()
	{
	}
}
[Serializable]
[Token(Token = "0x2000010")]
public class TextSwitcherClip : PlayableAsset, ITimelineClipAsset
{
	[Token(Token = "0x4000018")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public TextSwitcherBehaviour template;

	[Token(Token = "0x17000004")]
	public ClipCaps clipCaps
	{
		[Token(Token = "0x6000022")]
		[Address(RVA = "0x1165388", Offset = "0x1165388", VA = "0x1165388", Slot = "9")]
		get
		{
			return default(ClipCaps);
		}
	}

	[Token(Token = "0x6000023")]
	[Address(RVA = "0x1165390", Offset = "0x1165390", VA = "0x1165390", Slot = "6")]
	public override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
	{
		return default(Playable);
	}

	[Token(Token = "0x6000024")]
	[Address(RVA = "0x1165430", Offset = "0x1165430", VA = "0x1165430")]
	public TextSwitcherClip()
	{
	}
}
[Token(Token = "0x2000011")]
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

	[Token(Token = "0x6000025")]
	[Address(RVA = "0x1165494", Offset = "0x1165494", VA = "0x1165494", Slot = "20")]
	public override void ProcessFrame(Playable playable, FrameData info, object playerData)
	{
	}

	[Token(Token = "0x6000026")]
	[Address(RVA = "0x11658C8", Offset = "0x11658C8", VA = "0x11658C8", Slot = "16")]
	public override void OnPlayableDestroy(Playable playable)
	{
	}

	[Token(Token = "0x6000027")]
	[Address(RVA = "0x11659A0", Offset = "0x11659A0", VA = "0x11659A0")]
	public TextSwitcherMixerBehaviour()
	{
	}
}
[Token(Token = "0x2000012")]
[AttributeAttribute(Name = "TrackColorAttribute", RVA = "0x620150", Offset = "0x620150")]
[AttributeAttribute(Name = "TrackClipTypeAttribute", RVA = "0x620150", Offset = "0x620150")]
[AttributeAttribute(Name = "TrackBindingTypeAttribute", RVA = "0x620150", Offset = "0x620150")]
public class TextSwitcherTrack : TrackAsset
{
	[Token(Token = "0x6000028")]
	[Address(RVA = "0x11659A8", Offset = "0x11659A8", VA = "0x11659A8", Slot = "24")]
	public override Playable CreateTrackMixer(PlayableGraph graph, GameObject go, int inputCount)
	{
		return default(Playable);
	}

	[Token(Token = "0x6000029")]
	[Address(RVA = "0x1165A40", Offset = "0x1165A40", VA = "0x1165A40", Slot = "29")]
	public override void GatherProperties(PlayableDirector director, IPropertyCollector driver)
	{
	}

	[Token(Token = "0x600002A")]
	[Address(RVA = "0x1165A48", Offset = "0x1165A48", VA = "0x1165A48")]
	public TextSwitcherTrack()
	{
	}
}
[Serializable]
[Token(Token = "0x2000013")]
public class TimeDilationBehaviour : PlayableBehaviour
{
	[Token(Token = "0x400001E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public float timeScale;

	[Token(Token = "0x600002B")]
	[Address(RVA = "0x1165AB0", Offset = "0x1165AB0", VA = "0x1165AB0")]
	public TimeDilationBehaviour()
	{
	}
}
[Serializable]
[Token(Token = "0x2000014")]
public class TimeDilationClip : PlayableAsset, ITimelineClipAsset
{
	[Token(Token = "0x400001F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public TimeDilationBehaviour template;

	[Token(Token = "0x17000005")]
	public ClipCaps clipCaps
	{
		[Token(Token = "0x600002C")]
		[Address(RVA = "0x1165AC0", Offset = "0x1165AC0", VA = "0x1165AC0", Slot = "9")]
		get
		{
			return default(ClipCaps);
		}
	}

	[Token(Token = "0x600002D")]
	[Address(RVA = "0x1165AC8", Offset = "0x1165AC8", VA = "0x1165AC8", Slot = "6")]
	public override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
	{
		return default(Playable);
	}

	[Token(Token = "0x600002E")]
	[Address(RVA = "0x1165B68", Offset = "0x1165B68", VA = "0x1165B68")]
	public TimeDilationClip()
	{
	}
}
[Token(Token = "0x2000015")]
public class TimeDilationMixerBehaviour : PlayableBehaviour
{
	[Token(Token = "0x4000020")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private readonly float defaultTimeScale;

	[Token(Token = "0x600002F")]
	[Address(RVA = "0x1165BD8", Offset = "0x1165BD8", VA = "0x1165BD8", Slot = "20")]
	public override void ProcessFrame(Playable playable, FrameData info, object playerData)
	{
	}

	[Token(Token = "0x6000030")]
	[Address(RVA = "0x1165DA4", Offset = "0x1165DA4", VA = "0x1165DA4", Slot = "18")]
	public override void OnBehaviourPause(Playable playable, FrameData info)
	{
	}

	[Token(Token = "0x6000031")]
	[Address(RVA = "0x1165DB0", Offset = "0x1165DB0", VA = "0x1165DB0", Slot = "14")]
	public override void OnGraphStop(Playable playable)
	{
	}

	[Token(Token = "0x6000032")]
	[Address(RVA = "0x1165DBC", Offset = "0x1165DBC", VA = "0x1165DBC", Slot = "16")]
	public override void OnPlayableDestroy(Playable playable)
	{
	}

	[Token(Token = "0x6000033")]
	[Address(RVA = "0x1165DC8", Offset = "0x1165DC8", VA = "0x1165DC8")]
	public TimeDilationMixerBehaviour()
	{
	}
}
[Token(Token = "0x2000016")]
[AttributeAttribute(Name = "TrackColorAttribute", RVA = "0x620204", Offset = "0x620204")]
[AttributeAttribute(Name = "TrackClipTypeAttribute", RVA = "0x620204", Offset = "0x620204")]
public class TimeDilationTrack : TrackAsset
{
	[Token(Token = "0x6000034")]
	[Address(RVA = "0x1165DD8", Offset = "0x1165DD8", VA = "0x1165DD8", Slot = "24")]
	public override Playable CreateTrackMixer(PlayableGraph graph, GameObject go, int inputCount)
	{
		return default(Playable);
	}

	[Token(Token = "0x6000035")]
	[Address(RVA = "0x1165E70", Offset = "0x1165E70", VA = "0x1165E70")]
	public TimeDilationTrack()
	{
	}
}
[Serializable]
[Token(Token = "0x2000017")]
public class TransformTweenBehaviour : PlayableBehaviour
{
	[Token(Token = "0x200008D")]
	public enum TweenType
	{
		[Token(Token = "0x400025B")]
		Linear,
		[Token(Token = "0x400025C")]
		Deceleration,
		[Token(Token = "0x400025D")]
		Harmonic,
		[Token(Token = "0x400025E")]
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

	[Token(Token = "0x6000036")]
	[Address(RVA = "0x1165ED8", Offset = "0x1165ED8", VA = "0x1165ED8", Slot = "19")]
	public override void PrepareFrame(Playable playable, FrameData info)
	{
	}

	[Token(Token = "0x6000037")]
	[Address(RVA = "0x1165F80", Offset = "0x1165F80", VA = "0x1165F80")]
	public float EvaluateCurrentCurve(float time)
	{
		return default(float);
	}

	[Token(Token = "0x6000038")]
	[Address(RVA = "0x1166078", Offset = "0x1166078", VA = "0x1166078")]
	private bool IsCustomCurveNormalised()
	{
		return default(bool);
	}

	[Token(Token = "0x6000039")]
	[Address(RVA = "0x11662A0", Offset = "0x11662A0", VA = "0x11662A0")]
	public TransformTweenBehaviour()
	{
	}
}
[Serializable]
[Token(Token = "0x2000018")]
public class TransformTweenClip : PlayableAsset, ITimelineClipAsset
{
	[Token(Token = "0x400002D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public TransformTweenBehaviour template;

	[Token(Token = "0x400002E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public ExposedReference<Transform> startLocation;

	[Token(Token = "0x400002F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public ExposedReference<Transform> endLocation;

	[Token(Token = "0x17000006")]
	public ClipCaps clipCaps
	{
		[Token(Token = "0x600003A")]
		[Address(RVA = "0x1166484", Offset = "0x1166484", VA = "0x1166484", Slot = "9")]
		get
		{
			return default(ClipCaps);
		}
	}

	[Token(Token = "0x600003B")]
	[Address(RVA = "0x116648C", Offset = "0x116648C", VA = "0x116648C", Slot = "6")]
	public override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
	{
		return default(Playable);
	}

	[Token(Token = "0x600003C")]
	[Address(RVA = "0x11665BC", Offset = "0x11665BC", VA = "0x11665BC")]
	public TransformTweenClip()
	{
	}
}
[Token(Token = "0x2000019")]
public class TransformTweenMixerBehaviour : PlayableBehaviour
{
	[Token(Token = "0x4000030")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private bool m_FirstFrameHappened;

	[Token(Token = "0x600003D")]
	[Address(RVA = "0x1166620", Offset = "0x1166620", VA = "0x1166620", Slot = "20")]
	public override void ProcessFrame(Playable playable, FrameData info, object playerData)
	{
	}

	[Token(Token = "0x600003E")]
	[Address(RVA = "0x1166D48", Offset = "0x1166D48", VA = "0x1166D48", Slot = "16")]
	public override void OnPlayableDestroy(Playable playable)
	{
	}

	[Token(Token = "0x600003F")]
	[Address(RVA = "0x1166D34", Offset = "0x1166D34", VA = "0x1166D34")]
	private static Quaternion AddQuaternions(Quaternion first, Quaternion second)
	{
		return default(Quaternion);
	}

	[Token(Token = "0x6000040")]
	[Address(RVA = "0x1166D20", Offset = "0x1166D20", VA = "0x1166D20")]
	private static Quaternion ScaleQuaternion(Quaternion rotation, float multiplier)
	{
		return default(Quaternion);
	}

	[Token(Token = "0x6000041")]
	[Address(RVA = "0x1166D50", Offset = "0x1166D50", VA = "0x1166D50")]
	private static float QuaternionMagnitude(Quaternion rotation)
	{
		return default(float);
	}

	[Token(Token = "0x6000042")]
	[Address(RVA = "0x1166C30", Offset = "0x1166C30", VA = "0x1166C30")]
	private static Quaternion NormalizeQuaternion(Quaternion rotation)
	{
		return default(Quaternion);
	}

	[Token(Token = "0x6000043")]
	[Address(RVA = "0x1166E3C", Offset = "0x1166E3C", VA = "0x1166E3C")]
	public TransformTweenMixerBehaviour()
	{
	}
}
[Token(Token = "0x200001A")]
[AttributeAttribute(Name = "TrackColorAttribute", RVA = "0x620290", Offset = "0x620290")]
[AttributeAttribute(Name = "TrackClipTypeAttribute", RVA = "0x620290", Offset = "0x620290")]
[AttributeAttribute(Name = "TrackBindingTypeAttribute", RVA = "0x620290", Offset = "0x620290")]
public class TransformTweenTrack : TrackAsset
{
	[Token(Token = "0x6000044")]
	[Address(RVA = "0x1166E44", Offset = "0x1166E44", VA = "0x1166E44", Slot = "24")]
	public override Playable CreateTrackMixer(PlayableGraph graph, GameObject go, int inputCount)
	{
		return default(Playable);
	}

	[Token(Token = "0x6000045")]
	[Address(RVA = "0x1166EDC", Offset = "0x1166EDC", VA = "0x1166EDC", Slot = "29")]
	public override void GatherProperties(PlayableDirector director, IPropertyCollector driver)
	{
	}

	[Token(Token = "0x6000046")]
	[Address(RVA = "0x1166EE4", Offset = "0x1166EE4", VA = "0x1166EE4")]
	public TransformTweenTrack()
	{
	}
}
[Token(Token = "0x200001B")]
[ExecuteAlways]
public class EnableTBLinear : MonoBehaviour
{
	[Token(Token = "0x6000047")]
	[Address(RVA = "0xD2D9A4", Offset = "0xD2D9A4", VA = "0xD2D9A4")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000048")]
	[Address(RVA = "0xD2D9F0", Offset = "0xD2D9F0", VA = "0xD2D9F0")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6000049")]
	[Address(RVA = "0xD2DA3C", Offset = "0xD2DA3C", VA = "0xD2DA3C")]
	public EnableTBLinear()
	{
	}
}
[Token(Token = "0x200001C")]
public class FB360ControlTrack : MonoBehaviour, ITimeControl
{
	[Token(Token = "0x4000031")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public SpatDecoderFile spat;

	[Token(Token = "0x4000032")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public string fileName;

	[Token(Token = "0x600004A")]
	[Address(RVA = "0xD2DF60", Offset = "0xD2DF60", VA = "0xD2DF60", Slot = "5")]
	public void OnControlTimeStart()
	{
	}

	[Token(Token = "0x600004B")]
	[Address(RVA = "0xD2DFCC", Offset = "0xD2DFCC", VA = "0xD2DFCC", Slot = "6")]
	public void OnControlTimeStop()
	{
	}

	[Token(Token = "0x600004C")]
	[Address(RVA = "0xD2DFD0", Offset = "0xD2DFD0", VA = "0xD2DFD0", Slot = "4")]
	public void SetTime(double time)
	{
	}

	[Token(Token = "0x600004D")]
	[Address(RVA = "0xD2E110", Offset = "0xD2E110", VA = "0xD2E110")]
	private void Start()
	{
	}

	[Token(Token = "0x600004E")]
	[Address(RVA = "0xD2E114", Offset = "0xD2E114", VA = "0xD2E114")]
	private void Update()
	{
	}

	[Token(Token = "0x600004F")]
	[Address(RVA = "0xD2E118", Offset = "0xD2E118", VA = "0xD2E118")]
	public FB360ControlTrack()
	{
	}
}
[Token(Token = "0x200001D")]
public class LangSelector : MonoBehaviour
{
	[Token(Token = "0x200008E")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x620608", Offset = "0x620608")]
	private sealed class <UIAnimation>d__19 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400025F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000260")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000261")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public LangSelector <>4__this;

		[Token(Token = "0x4000262")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float <currentAlphaEng>5__2;

		[Token(Token = "0x4000263")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private float <currentAlphaCht>5__3;

		[Token(Token = "0x4000264")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float <countDown>5__4;

		[Token(Token = "0x17000087")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600068C")]
			[Address(RVA = "0xD2FCE4", Offset = "0xD2FCE4", VA = "0xD2FCE4", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000088")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600068E")]
			[Address(RVA = "0xD2FD4C", Offset = "0xD2FD4C", VA = "0xD2FD4C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000689")]
		[Address(RVA = "0xD2F68C", Offset = "0xD2F68C", VA = "0xD2F68C")]
		[DebuggerHidden]
		public <UIAnimation>d__19(int <>1__state)
		{
		}

		[Token(Token = "0x600068A")]
		[Address(RVA = "0xD2F9D4", Offset = "0xD2F9D4", VA = "0xD2F9D4", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600068B")]
		[Address(RVA = "0xD2F9D8", Offset = "0xD2F9D8", VA = "0xD2F9D8", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600068D")]
		[Address(RVA = "0xD2FCEC", Offset = "0xD2FCEC", VA = "0xD2FCEC", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000033")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject kffVideo;

	[Token(Token = "0x4000034")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public AudioSource audioSource;

	[Token(Token = "0x4000035")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public AudioClip openingClip;

	[Token(Token = "0x4000036")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public string fileNameCHT;

	[Token(Token = "0x4000037")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public string fileNameENG;

	[Token(Token = "0x4000038")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public float timelineStartSec;

	[Token(Token = "0x4000039")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public PlayableDirector mTimeline;

	[Token(Token = "0x400003A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public FB360ControlTrack fb360;

	[Token(Token = "0x400003B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public GameObject mController;

	[Token(Token = "0x400003C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public GameObject UICanvas;

	[Token(Token = "0x400003D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public RawImage titleImg;

	[Token(Token = "0x400003E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public RawImage engBtn;

	[Token(Token = "0x400003F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public RawImage chtBtn;

	[Token(Token = "0x4000040")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public bool canSeek;

	[Token(Token = "0x4000041")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
	public int seekIndex;

	[Token(Token = "0x4000042")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public float[] seekTimeTable;

	[Token(Token = "0x6000050")]
	[Address(RVA = "0xD2F2AC", Offset = "0xD2F2AC", VA = "0xD2F2AC")]
	private void Start()
	{
	}

	[Token(Token = "0x6000051")]
	[Address(RVA = "0xD2F318", Offset = "0xD2F318", VA = "0xD2F318")]
	private void Update()
	{
	}

	[Token(Token = "0x6000052")]
	[Address(RVA = "0xD2F4E8", Offset = "0xD2F4E8", VA = "0xD2F4E8")]
	public void SelectLang(int selectedLang)
	{
	}

	[Token(Token = "0x6000053")]
	[Address(RVA = "0xD2F61C", Offset = "0xD2F61C", VA = "0xD2F61C")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x620F84", Offset = "0x620F84")]
	private IEnumerator UIAnimation()
	{
		return null;
	}

	[Token(Token = "0x6000054")]
	[Address(RVA = "0xD2F6B8", Offset = "0xD2F6B8", VA = "0xD2F6B8")]
	public void ResetScene()
	{
	}

	[Token(Token = "0x6000055")]
	[Address(RVA = "0xD2F484", Offset = "0xD2F484", VA = "0xD2F484")]
	public void GoToNextChap()
	{
	}

	[Token(Token = "0x6000056")]
	[Address(RVA = "0xD2F8B0", Offset = "0xD2F8B0", VA = "0xD2F8B0")]
	public void SeekTo(float seekTime)
	{
	}

	[Token(Token = "0x6000057")]
	[Address(RVA = "0xD2F954", Offset = "0xD2F954", VA = "0xD2F954")]
	public LangSelector()
	{
	}
}
[Token(Token = "0x200001E")]
[ExecuteAlways]
public class RainControl : MonoBehaviour
{
	[Token(Token = "0x4000043")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public ParticleSystem mParticleSystem;

	[Token(Token = "0x4000044")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float emissionRate;

	[Token(Token = "0x6000058")]
	[Address(RVA = "0xD309DC", Offset = "0xD309DC", VA = "0xD309DC")]
	private void Update()
	{
	}

	[Token(Token = "0x6000059")]
	[Address(RVA = "0xD30A00", Offset = "0xD30A00", VA = "0xD30A00")]
	public RainControl()
	{
	}
}
[Token(Token = "0x200001F")]
public class DoorControl : MonoBehaviour
{
	[Token(Token = "0x4000045")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Transform[] doors;

	[Token(Token = "0x4000046")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float speed;

	[Token(Token = "0x600005A")]
	[Address(RVA = "0xD2D838", Offset = "0xD2D838", VA = "0xD2D838")]
	private void Update()
	{
	}

	[Token(Token = "0x600005B")]
	[Address(RVA = "0xD2D994", Offset = "0xD2D994", VA = "0xD2D994")]
	public DoorControl()
	{
	}
}
[Token(Token = "0x2000020")]
public class SceneControl : MonoBehaviour
{
	[Token(Token = "0x600005C")]
	[Address(RVA = "0xD31300", Offset = "0xD31300", VA = "0xD31300")]
	private void Awake()
	{
	}

	[Token(Token = "0x600005D")]
	[Address(RVA = "0xD3137C", Offset = "0xD3137C", VA = "0xD3137C")]
	private void Update()
	{
	}

	[Token(Token = "0x600005E")]
	[Address(RVA = "0xD314A4", Offset = "0xD314A4", VA = "0xD314A4")]
	public SceneControl()
	{
	}
}
[Token(Token = "0x2000021")]
public class ExitFunction : MonoBehaviour
{
	[Token(Token = "0x200008F")]
	private enum ShowWindowEnum
	{
		[Token(Token = "0x4000266")]
		Hide = 0,
		[Token(Token = "0x4000267")]
		ShowNormal = 1,
		[Token(Token = "0x4000268")]
		ShowMinimized = 2,
		[Token(Token = "0x4000269")]
		ShowMaximized = 3,
		[Token(Token = "0x400026A")]
		Maximize = 3,
		[Token(Token = "0x400026B")]
		ShowNormalNoActivate = 4,
		[Token(Token = "0x400026C")]
		Show = 5,
		[Token(Token = "0x400026D")]
		Minimize = 6,
		[Token(Token = "0x400026E")]
		ShowMinNoActivate = 7,
		[Token(Token = "0x400026F")]
		ShowNoActivate = 8,
		[Token(Token = "0x4000270")]
		Restore = 9,
		[Token(Token = "0x4000271")]
		ShowDefault = 10,
		[Token(Token = "0x4000272")]
		ForceMinimized = 11
	}

	[Token(Token = "0x2000090")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x620618", Offset = "0x620618")]
	private sealed class <CO_QuitApplication>d__9 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000273")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000274")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x17000089")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000692")]
			[Address(RVA = "0xD2DEF0", Offset = "0xD2DEF0", VA = "0xD2DEF0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700008A")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000694")]
			[Address(RVA = "0xD2DF58", Offset = "0xD2DF58", VA = "0xD2DF58", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600068F")]
		[Address(RVA = "0xD2DE1C", Offset = "0xD2DE1C", VA = "0xD2DE1C")]
		[DebuggerHidden]
		public <CO_QuitApplication>d__9(int <>1__state)
		{
		}

		[Token(Token = "0x6000690")]
		[Address(RVA = "0xD2DE50", Offset = "0xD2DE50", VA = "0xD2DE50", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000691")]
		[Address(RVA = "0xD2DE54", Offset = "0xD2DE54", VA = "0xD2DE54", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000693")]
		[Address(RVA = "0xD2DEF8", Offset = "0xD2DEF8", VA = "0xD2DEF8", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000047")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static ExitFunction _instance;

	[Token(Token = "0x17000007")]
	public static ExitFunction Instance
	{
		[Token(Token = "0x600005F")]
		[Address(RVA = "0xD2DA44", Offset = "0xD2DA44", VA = "0xD2DA44")]
		get
		{
			return null;
		}
	}

	[PreserveSig]
	[Token(Token = "0x6000060")]
	[Address(RVA = "0xD2DA94", Offset = "0xD2DA94", VA = "0xD2DA94")]
	public static extern IntPtr FindWindow(string className, string windowTitle);

	[PreserveSig]
	[Token(Token = "0x6000061")]
	[Address(RVA = "0xD2DB50", Offset = "0xD2DB50", VA = "0xD2DB50")]
	private static extern bool ShowWindow(IntPtr hWnd, ShowWindowEnum flags);

	[PreserveSig]
	[Token(Token = "0x6000062")]
	[Address(RVA = "0xD2DBE4", Offset = "0xD2DBE4", VA = "0xD2DBE4")]
	private static extern int SetForegroundWindow(IntPtr hwnd);

	[Token(Token = "0x6000063")]
	[Address(RVA = "0xD2DC64", Offset = "0xD2DC64", VA = "0xD2DC64")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000064")]
	[Address(RVA = "0xD2DCB8", Offset = "0xD2DCB8", VA = "0xD2DCB8")]
	public void ExitExperience()
	{
	}

	[Token(Token = "0x6000065")]
	[Address(RVA = "0xD2DDBC", Offset = "0xD2DDBC", VA = "0xD2DDBC")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x620FE8", Offset = "0x620FE8")]
	private IEnumerator CO_QuitApplication()
	{
		return null;
	}

	[Token(Token = "0x6000066")]
	[Address(RVA = "0xD2DE48", Offset = "0xD2DE48", VA = "0xD2DE48")]
	public ExitFunction()
	{
	}
}
[Token(Token = "0x2000022")]
public class XRControllerInput : MonoBehaviour
{
	[Token(Token = "0x4000048")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x620668", Offset = "0x620668")]
	private XRNode XRController;

	[Token(Token = "0x4000049")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private List<InputDevice> devices;

	[Token(Token = "0x400004A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private InputDevice device;

	[Token(Token = "0x400004B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6206B4", Offset = "0x6206B4")]
	public bool keyboardDebug;

	[Token(Token = "0x400004C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6206EC", Offset = "0x6206EC")]
	public float debugAxisValueIncrement;

	[Token(Token = "0x400004D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x620724", Offset = "0x620724")]
	public float minAxisValue;

	[Token(Token = "0x400004E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	private bool _triggerButton;

	[Token(Token = "0x400004F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private float _triggerValue;

	[Token(Token = "0x4000050")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	private bool _gripButton;

	[Token(Token = "0x4000051")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private float _gripValue;

	[Token(Token = "0x4000052")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	private bool _primary2DAxisButton;

	[Token(Token = "0x4000053")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private Vector2 _primary2DAxisValue;

	[Token(Token = "0x4000054")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private bool _secondary2DAxisButton;

	[Token(Token = "0x4000055")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	private Vector2 _secondary2DAxisValue;

	[Token(Token = "0x4000056")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	private bool _primaryButton;

	[Token(Token = "0x4000057")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6D")]
	private bool _secondaryButton;

	[Token(Token = "0x4000058")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6E")]
	private bool _menuButton;

	[Token(Token = "0x4000059")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6F")]
	public bool triggerButton;

	[Token(Token = "0x400005A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x62075C", Offset = "0x62075C")]
	public float triggerValue;

	[Token(Token = "0x400005B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x620774", Offset = "0x620774")]
	public float stickThreshold;

	[Token(Token = "0x400005C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public bool gripButton;

	[Token(Token = "0x400005D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x62078C", Offset = "0x62078C")]
	public float gripValue;

	[Token(Token = "0x400005E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public bool primary2DAxisButton;

	[Token(Token = "0x400005F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
	[HideInInspector]
	public Vector2 primary2DAxisValue;

	[Token(Token = "0x4000060")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6207B4", Offset = "0x6207B4")]
	public float primary2DAxisXValue;

	[Token(Token = "0x4000061")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6207CC", Offset = "0x6207CC")]
	public float primary2DAxisYValue;

	[Token(Token = "0x4000062")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
	public bool secondary2DAxisButton;

	[Token(Token = "0x4000063")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	[HideInInspector]
	public Vector2 secondary2DAxisValue;

	[Token(Token = "0x4000064")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6207F4", Offset = "0x6207F4")]
	public float secondary2DAxisXValue;

	[Token(Token = "0x4000065")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x62080C", Offset = "0x62080C")]
	public float secondary2DAxisYValue;

	[Token(Token = "0x4000066")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public bool primaryButton;

	[Token(Token = "0x4000067")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA9")]
	public bool secondaryButton;

	[Token(Token = "0x4000068")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xAA")]
	public bool menuButton;

	[Token(Token = "0x4000069")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xAB")]
	private bool _primaryAxisXAllTheWay;

	[Token(Token = "0x400006A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
	private bool _primaryAxisYAllTheWay;

	[Token(Token = "0x400006B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x620824", Offset = "0x620824")]
	public UnityEvent OnTriggerPress;

	[Token(Token = "0x400006C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x62085C", Offset = "0x62085C")]
	public UnityEvent OnTriggerRelease;

	[Token(Token = "0x400006D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x620894", Offset = "0x620894")]
	public UnityEvent OnGripPress;

	[Token(Token = "0x400006E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6208CC", Offset = "0x6208CC")]
	public UnityEvent OnGripRelease;

	[Token(Token = "0x400006F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x620904", Offset = "0x620904")]
	public UnityEvent OnPrimary2DAxisPress;

	[Token(Token = "0x4000070")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x62093C", Offset = "0x62093C")]
	public UnityEvent OnPrimary2DAxisRelease;

	[Token(Token = "0x4000071")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x620974", Offset = "0x620974")]
	public UnityEvent OnSecondary2DAxisPress;

	[Token(Token = "0x4000072")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6209AC", Offset = "0x6209AC")]
	public UnityEvent OnSecondary2DAxisRelease;

	[Token(Token = "0x4000073")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6209E4", Offset = "0x6209E4")]
	public UnityEvent OnPrimaryButtonPress;

	[Token(Token = "0x4000074")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x620A1C", Offset = "0x620A1C")]
	public UnityEvent OnPrimaryButtonRelease;

	[Token(Token = "0x4000075")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x620A54", Offset = "0x620A54")]
	public UnityEvent OnSecondaryButtonPress;

	[Token(Token = "0x4000076")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x620A8C", Offset = "0x620A8C")]
	public UnityEvent OnSecondaryButtonRelease;

	[Token(Token = "0x4000077")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x620AC4", Offset = "0x620AC4")]
	public UnityEvent OnMenuButtonPress;

	[Token(Token = "0x4000078")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x620AFC", Offset = "0x620AFC")]
	public UnityEvent OnMenuButtonRelease;

	[Token(Token = "0x4000079")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
	public UnityEvent OnPrimaryAxisXValuePositive;

	[Token(Token = "0x400007A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
	public UnityEvent OnPrimaryAxisXValueNegative;

	[Token(Token = "0x400007B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
	public UnityEvent OnPrimaryAxisYValuePositive;

	[Token(Token = "0x400007C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
	public UnityEvent OnPrimaryAxisYValuePositiveRelease;

	[Token(Token = "0x400007D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
	public UnityEvent OnPrimaryAxisYValueNegative;

	[Token(Token = "0x400007E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
	public UnityEvent OnPrimaryAxisYValueNegativeRelease;

	[Token(Token = "0x17000008")]
	private bool TriggerButtonAction
	{
		[Token(Token = "0x6000069")]
		[Address(RVA = "0x11685EC", Offset = "0x11685EC", VA = "0x11685EC")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600006A")]
		[Address(RVA = "0x11685F4", Offset = "0x11685F4", VA = "0x11685F4")]
		set
		{
		}
	}

	[Token(Token = "0x17000009")]
	private bool GripButtonAction
	{
		[Token(Token = "0x600006B")]
		[Address(RVA = "0x1168630", Offset = "0x1168630", VA = "0x1168630")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600006C")]
		[Address(RVA = "0x1168638", Offset = "0x1168638", VA = "0x1168638")]
		set
		{
		}
	}

	[Token(Token = "0x1700000A")]
	private bool Primary2DAxisButtonAction
	{
		[Token(Token = "0x600006D")]
		[Address(RVA = "0x1168674", Offset = "0x1168674", VA = "0x1168674")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600006E")]
		[Address(RVA = "0x116867C", Offset = "0x116867C", VA = "0x116867C")]
		set
		{
		}
	}

	[Token(Token = "0x1700000B")]
	private bool Secondary2DAxisButtonAction
	{
		[Token(Token = "0x600006F")]
		[Address(RVA = "0x11686B8", Offset = "0x11686B8", VA = "0x11686B8")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000070")]
		[Address(RVA = "0x11686C0", Offset = "0x11686C0", VA = "0x11686C0")]
		set
		{
		}
	}

	[Token(Token = "0x1700000C")]
	private bool PrimaryButtonAction
	{
		[Token(Token = "0x6000071")]
		[Address(RVA = "0x11686FC", Offset = "0x11686FC", VA = "0x11686FC")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000072")]
		[Address(RVA = "0x1168704", Offset = "0x1168704", VA = "0x1168704")]
		set
		{
		}
	}

	[Token(Token = "0x1700000D")]
	private bool SecondaryButtonAction
	{
		[Token(Token = "0x6000073")]
		[Address(RVA = "0x1168740", Offset = "0x1168740", VA = "0x1168740")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000074")]
		[Address(RVA = "0x1168748", Offset = "0x1168748", VA = "0x1168748")]
		set
		{
		}
	}

	[Token(Token = "0x1700000E")]
	private bool MenuButtonAction
	{
		[Token(Token = "0x6000075")]
		[Address(RVA = "0x1168784", Offset = "0x1168784", VA = "0x1168784")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000076")]
		[Address(RVA = "0x116878C", Offset = "0x116878C", VA = "0x116878C")]
		set
		{
		}
	}

	[Token(Token = "0x1700000F")]
	private float TriggerValueAction
	{
		[Token(Token = "0x6000077")]
		[Address(RVA = "0x11687C8", Offset = "0x11687C8", VA = "0x11687C8")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6000078")]
		[Address(RVA = "0x11687D0", Offset = "0x11687D0", VA = "0x11687D0")]
		set
		{
		}
	}

	[Token(Token = "0x17000010")]
	private float GripValueAction
	{
		[Token(Token = "0x6000079")]
		[Address(RVA = "0x11687E8", Offset = "0x11687E8", VA = "0x11687E8")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x600007A")]
		[Address(RVA = "0x11687F0", Offset = "0x11687F0", VA = "0x11687F0")]
		set
		{
		}
	}

	[Token(Token = "0x17000011")]
	private Vector2 Primary2DAxisValueAction
	{
		[Token(Token = "0x600007B")]
		[Address(RVA = "0x1168808", Offset = "0x1168808", VA = "0x1168808")]
		get
		{
			return default(Vector2);
		}
		[Token(Token = "0x600007C")]
		[Address(RVA = "0x1168810", Offset = "0x1168810", VA = "0x1168810")]
		set
		{
		}
	}

	[Token(Token = "0x17000012")]
	private Vector2 Secondary2DAxisValueAction
	{
		[Token(Token = "0x600007D")]
		[Address(RVA = "0x1168980", Offset = "0x1168980", VA = "0x1168980")]
		get
		{
			return default(Vector2);
		}
		[Token(Token = "0x600007E")]
		[Address(RVA = "0x1168988", Offset = "0x1168988", VA = "0x1168988")]
		set
		{
		}
	}

	[Token(Token = "0x6000067")]
	[Address(RVA = "0x1168548", Offset = "0x1168548", VA = "0x1168548")]
	private void GetDevice()
	{
	}

	[Token(Token = "0x6000068")]
	[Address(RVA = "0x11685B0", Offset = "0x11685B0", VA = "0x11685B0")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x600007F")]
	[Address(RVA = "0x1168A28", Offset = "0x1168A28", VA = "0x1168A28")]
	private void Update()
	{
	}

	[Token(Token = "0x6000080")]
	[Address(RVA = "0x1169064", Offset = "0x1169064", VA = "0x1169064")]
	public XRControllerInput()
	{
	}
}
[Token(Token = "0x2000023")]
public class CrackTrigger : MonoBehaviour
{
	[Token(Token = "0x400007F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Camera mCam;

	[Token(Token = "0x4000080")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public RenderTexture cubemapL;

	[Token(Token = "0x4000081")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public RenderTexture cubemapR;

	[Token(Token = "0x4000082")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public RenderTexture equirect;

	[Token(Token = "0x4000083")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Material mat;

	[Token(Token = "0x6000081")]
	[Address(RVA = "0xD2D2BC", Offset = "0xD2D2BC", VA = "0xD2D2BC")]
	public void Capture360()
	{
	}

	[Token(Token = "0x6000082")]
	[Address(RVA = "0xD2D47C", Offset = "0xD2D47C", VA = "0xD2D47C")]
	[AttributeAttribute(Name = "ContextMenu", RVA = "0x62104C", Offset = "0x62104C")]
	public void SaveEquirect()
	{
	}

	[Token(Token = "0x6000083")]
	[Address(RVA = "0xD2D5A4", Offset = "0xD2D5A4", VA = "0xD2D5A4")]
	public CrackTrigger()
	{
	}
}
[Token(Token = "0x2000024")]
[ExecuteAlways]
public class DOFLimiter : MonoBehaviour
{
	[Token(Token = "0x4000084")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Transform targetCam;

	[Token(Token = "0x4000085")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Vector3 BoxOffset;

	[Token(Token = "0x4000086")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public Vector3 BoxSize;

	[Token(Token = "0x4000087")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public float speed;

	[Token(Token = "0x6000084")]
	[Address(RVA = "0xD2D5AC", Offset = "0xD2D5AC", VA = "0xD2D5AC")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000085")]
	[Address(RVA = "0xD2D5B0", Offset = "0xD2D5B0", VA = "0xD2D5B0")]
	private void OnDrawGizmos()
	{
	}

	[Token(Token = "0x6000086")]
	[Address(RVA = "0xD2D5EC", Offset = "0xD2D5EC", VA = "0xD2D5EC")]
	private void Update()
	{
	}

	[Token(Token = "0x6000087")]
	[Address(RVA = "0xD2D828", Offset = "0xD2D828", VA = "0xD2D828")]
	public DOFLimiter()
	{
	}
}
[Token(Token = "0x2000025")]
[ExecuteAlways]
public class VertexWeight : MonoBehaviour
{
	[Token(Token = "0x4000088")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Transform modulator;

	[Token(Token = "0x4000089")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Material mat;

	[Token(Token = "0x6000088")]
	[Address(RVA = "0x11681F8", Offset = "0x11681F8", VA = "0x11681F8")]
	private void Update()
	{
	}

	[Token(Token = "0x6000089")]
	[Address(RVA = "0x11682B8", Offset = "0x11682B8", VA = "0x11682B8")]
	public VertexWeight()
	{
	}
}
[Token(Token = "0x2000026")]
public class AVProMediaBehaviour : PlayableBehaviour
{
	[Token(Token = "0x400008A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public MediaPlayer mediaPlayer;

	[Token(Token = "0x400008B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public MediaReference reference;

	[Token(Token = "0x400008C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Material liveActionMaterial;

	[Token(Token = "0x400008D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float preloadTime;

	[Token(Token = "0x400008E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public float fadeTime;

	[Token(Token = "0x400008F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public float videoClipStartTime;

	[Token(Token = "0x600008A")]
	[Address(RVA = "0xD2B8FC", Offset = "0xD2B8FC", VA = "0xD2B8FC", Slot = "15")]
	public override void OnPlayableCreate(Playable playable)
	{
	}

	[Token(Token = "0x600008B")]
	[Address(RVA = "0xD2B904", Offset = "0xD2B904", VA = "0xD2B904", Slot = "17")]
	public override void OnBehaviourPlay(Playable playable, FrameData info)
	{
	}

	[Token(Token = "0x600008C")]
	[Address(RVA = "0xD2B938", Offset = "0xD2B938", VA = "0xD2B938", Slot = "18")]
	public override void OnBehaviourPause(Playable playable, FrameData info)
	{
	}

	[Token(Token = "0x600008D")]
	[Address(RVA = "0xD2BA38", Offset = "0xD2BA38", VA = "0xD2BA38", Slot = "20")]
	public override void ProcessFrame(Playable playable, FrameData info, object playerData)
	{
	}

	[Token(Token = "0x600008E")]
	[Address(RVA = "0xD2C004", Offset = "0xD2C004", VA = "0xD2C004")]
	public AVProMediaBehaviour()
	{
	}
}
[Serializable]
[Token(Token = "0x2000027")]
public class AVProMediaClip : PlayableAsset
{
	[Token(Token = "0x4000090")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	public ExposedReference<MediaPlayer> mediaPlayer;

	[Token(Token = "0x4000091")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	public MediaReference reference;

	[Token(Token = "0x4000092")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	public Material liveActionMaterial;

	[Token(Token = "0x4000093")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[SerializeField]
	public float preloadTime;

	[Token(Token = "0x4000094")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	[SerializeField]
	public float fadeTime;

	[Token(Token = "0x4000095")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[SerializeField]
	public float videoStartTime;

	[Token(Token = "0x600008F")]
	[Address(RVA = "0xD2C00C", Offset = "0xD2C00C", VA = "0xD2C00C", Slot = "6")]
	public override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
	{
		return default(Playable);
	}

	[Token(Token = "0x6000090")]
	[Address(RVA = "0xD2C138", Offset = "0xD2C138", VA = "0xD2C138")]
	public AVProMediaClip()
	{
	}
}
[Token(Token = "0x2000028")]
public class AVProMediaMixerBehaviour : PlayableBehaviour
{
	[Token(Token = "0x6000091")]
	[Address(RVA = "0xD2C148", Offset = "0xD2C148", VA = "0xD2C148", Slot = "20")]
	public override void ProcessFrame(Playable playable, FrameData info, object playerData)
	{
	}

	[Token(Token = "0x6000092")]
	[Address(RVA = "0xD2C37C", Offset = "0xD2C37C", VA = "0xD2C37C")]
	public AVProMediaMixerBehaviour()
	{
	}
}
[Token(Token = "0x2000029")]
[AttributeAttribute(Name = "TrackClipTypeAttribute", RVA = "0x620384", Offset = "0x620384")]
public class AVProMediaTrack : TrackAsset
{
	[Token(Token = "0x6000093")]
	[Address(RVA = "0xD2C384", Offset = "0xD2C384", VA = "0xD2C384", Slot = "24")]
	public override Playable CreateTrackMixer(PlayableGraph graph, GameObject go, int inputCount)
	{
		return default(Playable);
	}

	[Token(Token = "0x6000094")]
	[Address(RVA = "0xD2C41C", Offset = "0xD2C41C", VA = "0xD2C41C")]
	public AVProMediaTrack()
	{
	}
}
[Serializable]
[Token(Token = "0x200002A")]
public class BrushMaterialBehaviour : PlayableBehaviour
{
	[Token(Token = "0x4000096")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x620B94", Offset = "0x620B94")]
	public float meshStart;

	[Token(Token = "0x4000097")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x620BAC", Offset = "0x620BAC")]
	public float meshVert;

	[Token(Token = "0x4000098")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x620BC4", Offset = "0x620BC4")]
	public float alphaVal;

	[Token(Token = "0x4000099")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float alphaCutoff;

	[Token(Token = "0x400009A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Color mainColor;

	[Token(Token = "0x6000095")]
	[Address(RVA = "0xD2C484", Offset = "0xD2C484", VA = "0xD2C484")]
	public BrushMaterialBehaviour()
	{
	}
}
[Serializable]
[Token(Token = "0x200002B")]
public class BrushMaterialClip : PlayableAsset, ITimelineClipAsset
{
	[Token(Token = "0x400009B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public BrushMaterialBehaviour template;

	[Token(Token = "0x17000013")]
	public ClipCaps clipCaps
	{
		[Token(Token = "0x6000096")]
		[Address(RVA = "0xD2C4C8", Offset = "0xD2C4C8", VA = "0xD2C4C8", Slot = "9")]
		get
		{
			return default(ClipCaps);
		}
	}

	[Token(Token = "0x6000097")]
	[Address(RVA = "0xD2C4D0", Offset = "0xD2C4D0", VA = "0xD2C4D0", Slot = "6")]
	public override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
	{
		return default(Playable);
	}

	[Token(Token = "0x6000098")]
	[Address(RVA = "0xD2C570", Offset = "0xD2C570", VA = "0xD2C570")]
	public BrushMaterialClip()
	{
	}
}
[Token(Token = "0x200002C")]
public class BrushMaterialMixerBehaviour : PlayableBehaviour
{
	[Token(Token = "0x400009C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public MeshRenderer mBindingMeshRenderer;

	[Token(Token = "0x400009D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Material mDefaulMaterial;

	[Token(Token = "0x400009E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Mesh mMesh;

	[Token(Token = "0x400009F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private Material mMaterial;

	[Token(Token = "0x40000A0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public bool defaultValuePassOn;

	[Token(Token = "0x40000A1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public float d_meshStart;

	[Token(Token = "0x40000A2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public float d_meshVert;

	[Token(Token = "0x40000A3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public float d_AlphaVal;

	[Token(Token = "0x40000A4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public float d_AlphaCutoff;

	[Token(Token = "0x40000A5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	public Color d_MainColor;

	[Token(Token = "0x6000099")]
	[Address(RVA = "0xD2C5D4", Offset = "0xD2C5D4", VA = "0xD2C5D4", Slot = "15")]
	public override void OnPlayableCreate(Playable playable)
	{
	}

	[Token(Token = "0x600009A")]
	[Address(RVA = "0xD2C5D8", Offset = "0xD2C5D8", VA = "0xD2C5D8", Slot = "16")]
	public override void OnPlayableDestroy(Playable playable)
	{
	}

	[Token(Token = "0x600009B")]
	[Address(RVA = "0xD2C708", Offset = "0xD2C708", VA = "0xD2C708", Slot = "20")]
	public override void ProcessFrame(Playable playable, FrameData info, object playerData)
	{
	}

	[Token(Token = "0x600009C")]
	[Address(RVA = "0xD2CB88", Offset = "0xD2CB88", VA = "0xD2CB88")]
	public BrushMaterialMixerBehaviour()
	{
	}
}
[Token(Token = "0x200002D")]
[AttributeAttribute(Name = "TrackColorAttribute", RVA = "0x6203E8", Offset = "0x6203E8")]
[AttributeAttribute(Name = "TrackClipTypeAttribute", RVA = "0x6203E8", Offset = "0x6203E8")]
[AttributeAttribute(Name = "TrackBindingTypeAttribute", RVA = "0x6203E8", Offset = "0x6203E8")]
public class BrushMaterialTrack : TrackAsset
{
	[Token(Token = "0x40000A6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public bool defaultValuePassOn;

	[Token(Token = "0x40000A7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x620BDC", Offset = "0x620BDC")]
	public float meshStart;

	[Token(Token = "0x40000A8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x620BF4", Offset = "0x620BF4")]
	public float meshVert;

	[Token(Token = "0x40000A9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x620C0C", Offset = "0x620C0C")]
	public float AlphaVal;

	[Token(Token = "0x40000AA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	public float AlphaCutoff;

	[Token(Token = "0x40000AB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
	[AttributeAttribute(Name = "ColorUsageAttribute", RVA = "0x620C24", Offset = "0x620C24")]
	public Color MainColor;

	[Token(Token = "0x600009D")]
	[Address(RVA = "0xD2CBBC", Offset = "0xD2CBBC", VA = "0xD2CBBC", Slot = "24")]
	public override Playable CreateTrackMixer(PlayableGraph graph, GameObject go, int inputCount)
	{
		return default(Playable);
	}

	[Token(Token = "0x600009E")]
	[Address(RVA = "0xD2CD84", Offset = "0xD2CD84", VA = "0xD2CD84")]
	public BrushMaterialTrack()
	{
	}
}
[Serializable]
[Token(Token = "0x200002E")]
public class RenderSettingControlBehaviour : PlayableBehaviour
{
	[Token(Token = "0x40000AC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public CameraClearFlags camClearFlag;

	[Token(Token = "0x40000AD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public Color camBackgroundColor;

	[Token(Token = "0x40000AE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Material skyboxMaterial;

	[Token(Token = "0x40000AF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Color skyColor;

	[Token(Token = "0x40000B0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Color equatorColor;

	[Token(Token = "0x40000B1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public Color groundColor;

	[Token(Token = "0x40000B2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x620C3C", Offset = "0x620C3C")]
	public float fSky;

	[Token(Token = "0x40000B3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x620C54", Offset = "0x620C54")]
	public float skyGradLength;

	[Token(Token = "0x40000B4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x620C6C", Offset = "0x620C6C")]
	public float fGround;

	[Token(Token = "0x40000B5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x620C84", Offset = "0x620C84")]
	public float groundGradLength;

	[Token(Token = "0x40000B6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public float exposure;

	[Token(Token = "0x40000B7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	public AmbientMode ambientMode;

	[Token(Token = "0x40000B8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public Color ambientColor;

	[Token(Token = "0x40000B9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public Color ambientEquatorColor;

	[Token(Token = "0x40000BA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public Color ambientGroundColor;

	[Token(Token = "0x40000BB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public Color ambientSkyColor;

	[Token(Token = "0x40000BC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	public float ambientIntensity;

	[Token(Token = "0x40000BD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
	public bool fogOn;

	[Token(Token = "0x40000BE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	public Color fogColor;

	[Token(Token = "0x40000BF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	public float fogDensity;

	[Token(Token = "0x600009F")]
	[Address(RVA = "0xD30A10", Offset = "0xD30A10", VA = "0xD30A10")]
	public RenderSettingControlBehaviour()
	{
	}
}
[Serializable]
[Token(Token = "0x200002F")]
public class RenderSettingControlClip : PlayableAsset, ITimelineClipAsset
{
	[Token(Token = "0x40000C0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public RenderSettingControlBehaviour template;

	[Token(Token = "0x17000014")]
	public ClipCaps clipCaps
	{
		[Token(Token = "0x60000A0")]
		[Address(RVA = "0xD30AC0", Offset = "0xD30AC0", VA = "0xD30AC0", Slot = "9")]
		get
		{
			return default(ClipCaps);
		}
	}

	[Token(Token = "0x60000A1")]
	[Address(RVA = "0xD30AC8", Offset = "0xD30AC8", VA = "0xD30AC8", Slot = "6")]
	public override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
	{
		return default(Playable);
	}

	[Token(Token = "0x60000A2")]
	[Address(RVA = "0xD30B68", Offset = "0xD30B68", VA = "0xD30B68")]
	public RenderSettingControlClip()
	{
	}
}
[Token(Token = "0x2000030")]
public class RenderSettingControlMixerBehaviour : PlayableBehaviour
{
	[Token(Token = "0x60000A3")]
	[Address(RVA = "0xD30BCC", Offset = "0xD30BCC", VA = "0xD30BCC", Slot = "20")]
	public override void ProcessFrame(Playable playable, FrameData info, object playerData)
	{
	}

	[Token(Token = "0x60000A4")]
	[Address(RVA = "0xD311F0", Offset = "0xD311F0", VA = "0xD311F0")]
	public RenderSettingControlMixerBehaviour()
	{
	}
}
[Token(Token = "0x2000031")]
[AttributeAttribute(Name = "TrackColorAttribute", RVA = "0x62049C", Offset = "0x62049C")]
[AttributeAttribute(Name = "TrackClipTypeAttribute", RVA = "0x62049C", Offset = "0x62049C")]
public class RenderSettingControlTrack : TrackAsset
{
	[Token(Token = "0x60000A5")]
	[Address(RVA = "0xD311F8", Offset = "0xD311F8", VA = "0xD311F8", Slot = "24")]
	public override Playable CreateTrackMixer(PlayableGraph graph, GameObject go, int inputCount)
	{
		return default(Playable);
	}

	[Token(Token = "0x60000A6")]
	[Address(RVA = "0xD31290", Offset = "0xD31290", VA = "0xD31290", Slot = "29")]
	public override void GatherProperties(PlayableDirector director, IPropertyCollector driver)
	{
	}

	[Token(Token = "0x60000A7")]
	[Address(RVA = "0xD31298", Offset = "0xD31298", VA = "0xD31298")]
	public RenderSettingControlTrack()
	{
	}
}
[Token(Token = "0x2000032")]
public class ClearBrushes : MonoBehaviour
{
	[Token(Token = "0x40000C1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject Brushes;

	[Token(Token = "0x40000C2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public int CleanTreshold;

	[Token(Token = "0x60000A8")]
	[Address(RVA = "0xD2CDFC", Offset = "0xD2CDFC", VA = "0xD2CDFC")]
	[AttributeAttribute(Name = "ContextMenu", RVA = "0x621084", Offset = "0x621084")]
	public void Cleanup()
	{
	}

	[Token(Token = "0x60000A9")]
	[Address(RVA = "0xD2D29C", Offset = "0xD2D29C", VA = "0xD2D29C")]
	public ClearBrushes()
	{
	}
}
[Token(Token = "0x2000033")]
public class FileLogger : MonoBehaviour
{
	[Token(Token = "0x40000C3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private string path;

	[Token(Token = "0x60000AA")]
	[Address(RVA = "0xD2ECC4", Offset = "0xD2ECC4", VA = "0xD2ECC4")]
	private void Awake()
	{
	}

	[Token(Token = "0x60000AB")]
	[Address(RVA = "0xD2EDA4", Offset = "0xD2EDA4", VA = "0xD2EDA4")]
	private void Start()
	{
	}

	[Token(Token = "0x60000AC")]
	[Address(RVA = "0xD2EE6C", Offset = "0xD2EE6C", VA = "0xD2EE6C")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60000AD")]
	[Address(RVA = "0xD2EEE0", Offset = "0xD2EEE0", VA = "0xD2EEE0")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x60000AE")]
	[Address(RVA = "0xD2EF54", Offset = "0xD2EF54", VA = "0xD2EF54")]
	public void Log(string condition, string stackTrace, LogType type)
	{
	}

	[Token(Token = "0x60000AF")]
	[Address(RVA = "0xD2F220", Offset = "0xD2F220", VA = "0xD2F220")]
	private string GetNowTime()
	{
		return null;
	}

	[Token(Token = "0x60000B0")]
	[Address(RVA = "0xD2F2A4", Offset = "0xD2F2A4", VA = "0xD2F2A4")]
	public FileLogger()
	{
	}
}
[Token(Token = "0x2000034")]
[ExecuteAlways]
public class LockVRHead : MonoBehaviour
{
	[Token(Token = "0x40000C4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool isHeadLock;

	[Token(Token = "0x60000B1")]
	[Address(RVA = "0xD3045C", Offset = "0xD3045C", VA = "0xD3045C")]
	private void Update()
	{
	}

	[Token(Token = "0x60000B2")]
	[Address(RVA = "0xD30510", Offset = "0xD30510", VA = "0xD30510")]
	public LockVRHead()
	{
	}
}
[Token(Token = "0x2000035")]
public class VideoEnvControl : MonoBehaviour
{
	[Token(Token = "0x40000C5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Material videoMaterial;

	[Token(Token = "0x40000C6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Material skyMaterial;

	[Token(Token = "0x60000B3")]
	[Address(RVA = "0x11682C0", Offset = "0x11682C0", VA = "0x11682C0")]
	private void Start()
	{
	}

	[Token(Token = "0x60000B4")]
	[Address(RVA = "0x1168380", Offset = "0x1168380", VA = "0x1168380")]
	public void SetSkyExposure(float v)
	{
	}

	[Token(Token = "0x60000B5")]
	[Address(RVA = "0x11683F0", Offset = "0x11683F0", VA = "0x11683F0")]
	public void SetVideoWidth(float v)
	{
	}

	[Token(Token = "0x60000B6")]
	[Address(RVA = "0x1168460", Offset = "0x1168460", VA = "0x1168460")]
	public void SetVideoWidthRange(float v)
	{
	}

	[Token(Token = "0x60000B7")]
	[Address(RVA = "0x11684D4", Offset = "0x11684D4", VA = "0x11684D4")]
	public void SetVideoTopFade(float v)
	{
	}

	[Token(Token = "0x60000B8")]
	[Address(RVA = "0x1168540", Offset = "0x1168540", VA = "0x1168540")]
	public VideoEnvControl()
	{
	}
}
namespace UnityEngine.Timeline
{
	[Token(Token = "0x2000036")]
	public class VideoPlayableBehaviour : PlayableBehaviour
	{
		[Token(Token = "0x40000C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public VideoPlayer videoPlayer;

		[Token(Token = "0x40000C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public VideoClip videoClip;

		[Token(Token = "0x40000C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool mute;

		[Token(Token = "0x40000CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
		public bool loop;

		[Token(Token = "0x40000CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public double preloadTime;

		[Token(Token = "0x40000CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public double clipInTime;

		[Token(Token = "0x40000CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private bool playedOnce;

		[Token(Token = "0x40000CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x39")]
		private bool preparing;

		[Token(Token = "0x60000B9")]
		[Address(RVA = "0x1166F4C", Offset = "0x1166F4C", VA = "0x1166F4C")]
		public void PrepareVideo()
		{
		}

		[Token(Token = "0x60000BA")]
		[Address(RVA = "0x1167304", Offset = "0x1167304", VA = "0x1167304")]
		private void LoopPointReached(VideoPlayer vp)
		{
		}

		[Token(Token = "0x60000BB")]
		[Address(RVA = "0x1167314", Offset = "0x1167314", VA = "0x1167314", Slot = "19")]
		public override void PrepareFrame(Playable playable, FrameData info)
		{
		}

		[Token(Token = "0x60000BC")]
		[Address(RVA = "0x1167600", Offset = "0x1167600", VA = "0x1167600", Slot = "17")]
		public override void OnBehaviourPlay(Playable playable, FrameData info)
		{
		}

		[Token(Token = "0x60000BD")]
		[Address(RVA = "0x1167760", Offset = "0x1167760", VA = "0x1167760", Slot = "18")]
		public override void OnBehaviourPause(Playable playable, FrameData info)
		{
		}

		[Token(Token = "0x60000BE")]
		[Address(RVA = "0x1167894", Offset = "0x1167894", VA = "0x1167894", Slot = "20")]
		public override void ProcessFrame(Playable playable, FrameData info, object playerData)
		{
		}

		[Token(Token = "0x60000BF")]
		[Address(RVA = "0x1167A88", Offset = "0x1167A88", VA = "0x1167A88", Slot = "13")]
		public override void OnGraphStart(Playable playable)
		{
		}

		[Token(Token = "0x60000C0")]
		[Address(RVA = "0x1167A90", Offset = "0x1167A90", VA = "0x1167A90", Slot = "14")]
		public override void OnGraphStop(Playable playable)
		{
		}

		[Token(Token = "0x60000C1")]
		[Address(RVA = "0x1167AC8", Offset = "0x1167AC8", VA = "0x1167AC8", Slot = "16")]
		public override void OnPlayableDestroy(Playable playable)
		{
		}

		[Token(Token = "0x60000C2")]
		[Address(RVA = "0x11676B4", Offset = "0x11676B4", VA = "0x11676B4")]
		public void PlayVideo()
		{
		}

		[Token(Token = "0x60000C3")]
		[Address(RVA = "0x1167804", Offset = "0x1167804", VA = "0x1167804")]
		public void PauseVideo()
		{
		}

		[Token(Token = "0x60000C4")]
		[Address(RVA = "0x1167270", Offset = "0x1167270", VA = "0x1167270")]
		public void StopVideo()
		{
		}

		[Token(Token = "0x60000C5")]
		[Address(RVA = "0x1167488", Offset = "0x1167488", VA = "0x1167488")]
		private void SyncVideoToPlayable(Playable playable)
		{
		}

		[Token(Token = "0x60000C6")]
		[Address(RVA = "0x1167ACC", Offset = "0x1167ACC", VA = "0x1167ACC")]
		public VideoPlayableBehaviour()
		{
		}
	}
	[Token(Token = "0x2000037")]
	public sealed class VideoSchedulerPlayableBehaviour : PlayableBehaviour
	{
		[Token(Token = "0x40000CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private IEnumerable<TimelineClip> m_Clips;

		[Token(Token = "0x40000D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private PlayableDirector m_Director;

		[Token(Token = "0x17000015")]
		internal PlayableDirector director
		{
			[Token(Token = "0x60000C7")]
			[Address(RVA = "0x1167AE8", Offset = "0x1167AE8", VA = "0x1167AE8")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000C8")]
			[Address(RVA = "0x1167AF0", Offset = "0x1167AF0", VA = "0x1167AF0")]
			set
			{
			}
		}

		[Token(Token = "0x17000016")]
		internal IEnumerable<TimelineClip> clips
		{
			[Token(Token = "0x60000C9")]
			[Address(RVA = "0x1167AF8", Offset = "0x1167AF8", VA = "0x1167AF8")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000CA")]
			[Address(RVA = "0x1167B00", Offset = "0x1167B00", VA = "0x1167B00")]
			set
			{
			}
		}

		[Token(Token = "0x60000CB")]
		[Address(RVA = "0x1167B08", Offset = "0x1167B08", VA = "0x1167B08", Slot = "20")]
		public override void ProcessFrame(Playable playable, FrameData info, object playerData)
		{
		}

		[Token(Token = "0x60000CC")]
		[Address(RVA = "0x1167F08", Offset = "0x1167F08", VA = "0x1167F08")]
		public VideoSchedulerPlayableBehaviour()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000038")]
	public class VideoScriptPlayableAsset : PlayableAsset
	{
		[Token(Token = "0x40000D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public ExposedReference<VideoPlayer> videoPlayer;

		[Token(Token = "0x40000D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		[NotKeyable]
		public VideoClip videoClip;

		[Token(Token = "0x40000D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		[NotKeyable]
		public bool mute;

		[Token(Token = "0x40000D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
		[SerializeField]
		[NotKeyable]
		public bool loop;

		[Token(Token = "0x40000D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		[NotKeyable]
		public double preloadTime;

		[Token(Token = "0x40000D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		[NotKeyable]
		public double clipInTime;

		[Token(Token = "0x60000CD")]
		[Address(RVA = "0x1167F10", Offset = "0x1167F10", VA = "0x1167F10", Slot = "6")]
		public override Playable CreatePlayable(PlayableGraph graph, GameObject go)
		{
			return default(Playable);
		}

		[Token(Token = "0x60000CE")]
		[Address(RVA = "0x116803C", Offset = "0x116803C", VA = "0x116803C")]
		public VideoScriptPlayableAsset()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000039")]
	[AttributeAttribute(Name = "TrackClipTypeAttribute", RVA = "0x620538", Offset = "0x620538")]
	[AttributeAttribute(Name = "TrackColorAttribute", RVA = "0x620538", Offset = "0x620538")]
	public class VideoScriptPlayableTrack : TrackAsset
	{
		[Token(Token = "0x60000CF")]
		[Address(RVA = "0x1168058", Offset = "0x1168058", VA = "0x1168058", Slot = "24")]
		public override Playable CreateTrackMixer(PlayableGraph graph, GameObject go, int inputCount)
		{
			return default(Playable);
		}

		[Token(Token = "0x60000D0")]
		[Address(RVA = "0x1168190", Offset = "0x1168190", VA = "0x1168190")]
		public VideoScriptPlayableTrack()
		{
		}
	}
}
namespace Facebook.Audio
{
	[Token(Token = "0x200003A")]
	public abstract class BootstrapperBase<T> : MonoBehaviour where T : Component
	{
		[Token(Token = "0x40000D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		protected AudioEngineManager audioEngineManager;

		[Token(Token = "0x40000D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Vector3 listenerPos_;

		[Token(Token = "0x40000D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Vector3 listenerFwd_;

		[Token(Token = "0x40000DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Vector3 listenerUp_;

		[Token(Token = "0x40000DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private bool listenerErrorLogged_;

		[Token(Token = "0x40000DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		protected RuntimeOptions runtimeOptions;

		[Token(Token = "0x40000DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		protected bool init;

		[Token(Token = "0x40000DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x620DB4", Offset = "0x620DB4")]
		private AudioListener <UnityListener>k__BackingField;

		[Token(Token = "0x17000017")]
		public AudioListener UnityListener
		{
			[Token(Token = "0x60000D1")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6210BC", Offset = "0x6210BC")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000D2")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6210CC", Offset = "0x6210CC")]
			set
			{
			}
		}

		[Token(Token = "0x17000018")]
		public Vector3 ListenerPos
		{
			[Token(Token = "0x60000D3")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000019")]
		public RuntimeOptions RuntimeOptions
		{
			[Token(Token = "0x60000DB")]
			get
			{
				return default(RuntimeOptions);
			}
		}

		[Token(Token = "0x1700001A")]
		public AudioEngineManager AudioEngineManager
		{
			[Token(Token = "0x60000DC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60000D4")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x60000D5")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x60000D6")]
		public void OnApplicationPause(bool pauseStatus)
		{
		}

		[Token(Token = "0x60000D7")]
		private void UpdatedListenerTransform()
		{
		}

		[Token(Token = "0x60000D8")]
		private static AudioListener FindFirstAudioListener()
		{
			return null;
		}

		[Token(Token = "0x60000D9")]
		protected abstract void InitInternal(RuntimeOptions options, SampleRate sampleRate, AudioDeviceType deviceType, string customDeviceName = "");

		[Token(Token = "0x60000DA")]
		public static void Init(GameObject parentObject, RuntimeOptions options, SampleRate sampleRate, AudioDeviceType deviceType, string customDeviceName = "")
		{
		}

		[Token(Token = "0x60000DD")]
		protected BootstrapperBase()
		{
		}
	}
	[Token(Token = "0x200003B")]
	[AttributeAttribute(Name = "DefaultExecutionOrder", RVA = "0x6205C4", Offset = "0x6205C4")]
	public class FBAudio360Bootstrapper : BootstrapperBase<FBAudio360Bootstrapper>
	{
		[Token(Token = "0x60000DE")]
		[Address(RVA = "0xD2E1C4", Offset = "0xD2E1C4", VA = "0xD2E1C4", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x60000DF")]
		[Address(RVA = "0xD2E278", Offset = "0xD2E278", VA = "0xD2E278", Slot = "6")]
		protected override void InitInternal(RuntimeOptions options, SampleRate sampleRate, AudioDeviceType deviceType, string customDeviceName = "")
		{
		}

		[Token(Token = "0x60000E0")]
		[Address(RVA = "0xD2E4BC", Offset = "0xD2E4BC", VA = "0xD2E4BC")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60000E1")]
		[Address(RVA = "0xD2E504", Offset = "0xD2E504", VA = "0xD2E504")]
		public FBAudio360Bootstrapper()
		{
		}
	}
	[Token(Token = "0x200003C")]
	public abstract class Job
	{
		[Token(Token = "0x40000DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private bool isFinished;

		[Token(Token = "0x40000E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Thread thread;

		[Token(Token = "0x1700001B")]
		public bool IsFinished
		{
			[Token(Token = "0x60000E2")]
			[Address(RVA = "0xD2E554", Offset = "0xD2E554", VA = "0xD2E554")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60000E3")]
		[Address(RVA = "0xD2E578", Offset = "0xD2E578", VA = "0xD2E578")]
		public void Start()
		{
		}

		[Token(Token = "0x60000E4")]
		[Address(RVA = "0xD2E620", Offset = "0xD2E620", VA = "0xD2E620")]
		public void Abort()
		{
		}

		[Token(Token = "0x60000E5")]
		protected abstract void ThreadFunction();

		[Token(Token = "0x60000E6")]
		[Address(RVA = "0xD2E63C", Offset = "0xD2E63C", VA = "0xD2E63C")]
		private void Run()
		{
		}

		[Token(Token = "0x60000E7")]
		[Address(RVA = "0xD2E670", Offset = "0xD2E670", VA = "0xD2E670")]
		protected Job()
		{
		}
	}
	[Token(Token = "0x200003D")]
	public static class ListExtensions
	{
		[Token(Token = "0x60000E8")]
		public static void FastRemoveAt<T>(this List<T> list, int index)
		{
		}
	}
	[Token(Token = "0x200003E")]
	public class SPSCQ<T>
	{
		[Token(Token = "0x2000091")]
		public delegate void Writer(ref T item);

		[Token(Token = "0x2000092")]
		public delegate void Reader(T item);

		[Token(Token = "0x40000E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public readonly uint maxSize;

		[Token(Token = "0x40000E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private T[] data_;

		[Token(Token = "0x40000E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private uint read_;

		[Token(Token = "0x40000E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private uint write_;

		[Token(Token = "0x40000E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private uint size_;

		[Token(Token = "0x1700001C")]
		public uint Count
		{
			[Token(Token = "0x60000EA")]
			get
			{
				return default(uint);
			}
		}

		[Token(Token = "0x60000E9")]
		public SPSCQ(uint maxSize)
		{
		}

		[Token(Token = "0x60000EB")]
		public bool Push(Writer writer)
		{
			return default(bool);
		}

		[Token(Token = "0x60000EC")]
		public bool Pop(Reader reader)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x200003F")]
	public class TPool<T> where T : class
	{
		[Token(Token = "0x2000093")]
		public delegate T CreateObject();

		[Token(Token = "0x40000E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public readonly int maxSize;

		[Token(Token = "0x40000E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private readonly CreateObject createFn_;

		[Token(Token = "0x40000E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private readonly Queue<T> inactive_;

		[Token(Token = "0x40000E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private readonly List<T> active_;

		[Token(Token = "0x1700001D")]
		public int NumUsed
		{
			[Token(Token = "0x60000ED")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700001E")]
		public int NumAvailable
		{
			[Token(Token = "0x60000EE")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x60000EF")]
		public T Get()
		{
			return null;
		}

		[Token(Token = "0x60000F0")]
		public bool Return(T objectToReturn)
		{
			return default(bool);
		}

		[Token(Token = "0x60000F1")]
		public TPool(int initialSize, CreateObject createFn, int maxSize = 0)
		{
		}
	}
	[Token(Token = "0x2000040")]
	public class Const
	{
		[Token(Token = "0x40000EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly float SMALL_NUMBER;

		[Token(Token = "0x40000EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static string DEFAULT_GROUP_COLLECTION;

		[Token(Token = "0x40000EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static string DEFAULT_GROUP;

		[Token(Token = "0x40000ED")]
		public const uint MAX_PHYSICAL_VOICES = 100u;

		[Token(Token = "0x40000EE")]
		public const uint MAX_VIRTUAL_VOICES = 200u;

		[Token(Token = "0x40000EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public static uint DEFAULT_PRIORITY_VALUE;

		[Token(Token = "0x40000F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public static uint MAX_PRIORITY_VALUE;

		[Token(Token = "0x60000F2")]
		[Address(RVA = "0xD2E120", Offset = "0xD2E120", VA = "0xD2E120")]
		public Const()
		{
		}
	}
	[Token(Token = "0x2000041")]
	public class WavSimpleHeader
	{
		[Token(Token = "0x2000094")]
		public enum WavFileFormat
		{
			[Token(Token = "0x4000276")]
			IntegerPcm = 1,
			[Token(Token = "0x4000277")]
			FloatPcm = 3
		}

		[Token(Token = "0x2000095")]
		private class WavFmtChunk
		{
			[Token(Token = "0x4000278")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public readonly char[] fmtId;

			[Token(Token = "0x4000279")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public uint chunkSize;

			[Token(Token = "0x400027A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public ushort formatTag;

			[Token(Token = "0x400027B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1E")]
			public ushort numChannels;

			[Token(Token = "0x400027C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public uint sampleRate;

			[Token(Token = "0x400027D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			public uint bytesPerSecond;

			[Token(Token = "0x400027E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public ushort blockAlign;

			[Token(Token = "0x400027F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2A")]
			public ushort bitsPerSample;

			[Token(Token = "0x60006A1")]
			[Address(RVA = "0xD2E950", Offset = "0xD2E950", VA = "0xD2E950")]
			public void set(uint fileSampleRate, ushort numOfChannels, ushort numBitsPerSample, WavFileFormat format)
			{
			}

			[Token(Token = "0x60006A2")]
			[Address(RVA = "0xD2EB98", Offset = "0xD2EB98", VA = "0xD2EB98")]
			public WavFmtChunk()
			{
			}
		}

		[Token(Token = "0x2000096")]
		private struct WavChunk
		{
			[Token(Token = "0x4000280")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public char[] chunkId;

			[Token(Token = "0x4000281")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public uint chunkSize;

			[Token(Token = "0x60006A3")]
			[Address(RVA = "0xD2E984", Offset = "0xD2E984", VA = "0xD2E984")]
			public static WavChunk MakeDataChunk(uint durationSamples, uint numOfChannels, uint numBitsPerSample)
			{
				return default(WavChunk);
			}
		}

		[Token(Token = "0x40000F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly char[] RiffId;

		[Token(Token = "0x40000F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private uint size_;

		[Token(Token = "0x40000F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static readonly char[] WaveId;

		[Token(Token = "0x40000F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private readonly WavFmtChunk fmt_;

		[Token(Token = "0x40000F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private long fileSizeEndMarker_;

		[Token(Token = "0x40000F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private long dataChunkStartMarker_;

		[Token(Token = "0x40000F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private long dataChunkEndMarker_;

		[Token(Token = "0x60000F4")]
		[Address(RVA = "0xD2E678", Offset = "0xD2E678", VA = "0xD2E678")]
		public void WriteHeader(BinaryWriter writer, uint fileSampleRate, ushort numOfChannels, ushort numBitsPerSample, WavFileFormat format)
		{
		}

		[Token(Token = "0x60000F5")]
		[Address(RVA = "0xD2EA10", Offset = "0xD2EA10", VA = "0xD2EA10")]
		public void UpdateDuration(BinaryWriter writer)
		{
		}

		[Token(Token = "0x60000F6")]
		[Address(RVA = "0xD2EB34", Offset = "0xD2EB34", VA = "0xD2EB34")]
		public WavSimpleHeader()
		{
		}
	}
}
namespace TBE
{
	[Token(Token = "0x2000042")]
	public class AudioEngineManager
	{
		[Token(Token = "0x2000097")]
		public struct Statistics
		{
			[Token(Token = "0x4000282")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public double audioCallbackTimeMs;

			[Token(Token = "0x4000283")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public double decoderThreadTimeMs;

			[Token(Token = "0x4000284")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public uint numActiveAudioObjects;

			[Token(Token = "0x4000285")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public uint numAudioObjectsPlaying;

			[Token(Token = "0x4000286")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public uint numActiveSpatDecoderQueues;

			[Token(Token = "0x4000287")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public uint numSpatDecoderQueuesPlaying;

			[Token(Token = "0x4000288")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float assetMegabytesInMemory;
		}

		[Token(Token = "0x2000098")]
		public class Client
		{
			[Token(Token = "0x400028A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private WeakReference manager_;

			[Token(Token = "0x400028B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private WeakReference nativeEngine_;

			[Token(Token = "0x14000002")]
			public event EventHandler OnInvalid
			{
				[Token(Token = "0x60006A4")]
				[Address(RVA = "0xECC32C", Offset = "0xECC32C", VA = "0xECC32C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6213C0", Offset = "0x6213C0")]
				add
				{
				}
				[Token(Token = "0x60006A5")]
				[Address(RVA = "0xECC3D0", Offset = "0xECC3D0", VA = "0xECC3D0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6213D0", Offset = "0x6213D0")]
				remove
				{
				}
			}

			[Token(Token = "0x60006A6")]
			[Address(RVA = "0xECAC74", Offset = "0xECAC74", VA = "0xECAC74")]
			internal Client(AudioEngineManager engineManager)
			{
			}

			[Token(Token = "0x60006A7")]
			[Address(RVA = "0xECC474", Offset = "0xECC474", VA = "0xECC474", Slot = "1")]
			~Client()
			{
			}

			[Token(Token = "0x60006A8")]
			[Address(RVA = "0xECC5C0", Offset = "0xECC5C0", VA = "0xECC5C0")]
			private void OnEngineDestroy(object sender, EventArgs e)
			{
			}

			[Token(Token = "0x60006A9")]
			[Address(RVA = "0xECC6C8", Offset = "0xECC6C8", VA = "0xECC6C8")]
			public bool GetManager(out AudioEngineManager engineManager)
			{
				return default(bool);
			}

			[Token(Token = "0x60006AA")]
			[Address(RVA = "0xECC780", Offset = "0xECC780", VA = "0xECC780")]
			public bool GetNativeEngine(out AudioEngine engine)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x40000F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private TBVector tempVector_;

		[Token(Token = "0x40000F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private TBVector tempVector2_;

		[Token(Token = "0x40000FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Statistics statistics_;

		[Token(Token = "0x40000FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private RuntimeOptions options_;

		[Token(Token = "0x40000FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x620DD4", Offset = "0x620DD4")]
		private AudioEngine <nativeEngine>k__BackingField;

		[Token(Token = "0x40000FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x620DE4", Offset = "0x620DE4")]
		private float <SampleRate>k__BackingField;

		[Token(Token = "0x40000FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x620DF4", Offset = "0x620DF4")]
		private int <BufferSize>k__BackingField;

		[Token(Token = "0x4000100")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x620E04", Offset = "0x620E04")]
		private Vector3 <ListenerPosition>k__BackingField;

		[Token(Token = "0x4000101")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x620E14", Offset = "0x620E14")]
		private static AudioEngineManager <Instance>k__BackingField;

		[Token(Token = "0x1700001F")]
		public int objectPoolSize
		{
			[Token(Token = "0x6000100")]
			[Address(RVA = "0xECBDC8", Offset = "0xECBDC8", VA = "0xECBDC8")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000020")]
		public int spatFilePoolSize
		{
			[Token(Token = "0x6000101")]
			[Address(RVA = "0xECBDD0", Offset = "0xECBDD0", VA = "0xECBDD0")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000021")]
		public AudioEngine nativeEngine
		{
			[Token(Token = "0x6000102")]
			[Address(RVA = "0xECBDD8", Offset = "0xECBDD8", VA = "0xECBDD8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x62110C", Offset = "0x62110C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000103")]
			[Address(RVA = "0xECBDE0", Offset = "0xECBDE0", VA = "0xECBDE0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x62111C", Offset = "0x62111C")]
			private set
			{
			}
		}

		[Token(Token = "0x17000022")]
		public Statistics Stats
		{
			[Token(Token = "0x6000105")]
			[Address(RVA = "0xECC1BC", Offset = "0xECC1BC", VA = "0xECC1BC")]
			get
			{
				return default(Statistics);
			}
		}

		[Token(Token = "0x17000023")]
		public float SampleRate
		{
			[Token(Token = "0x6000106")]
			[Address(RVA = "0xECC1F4", Offset = "0xECC1F4", VA = "0xECC1F4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x62112C", Offset = "0x62112C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000107")]
			[Address(RVA = "0xECC1FC", Offset = "0xECC1FC", VA = "0xECC1FC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x62113C", Offset = "0x62113C")]
			private set
			{
			}
		}

		[Token(Token = "0x17000024")]
		public int BufferSize
		{
			[Token(Token = "0x6000108")]
			[Address(RVA = "0xECC204", Offset = "0xECC204", VA = "0xECC204")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x62114C", Offset = "0x62114C")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000109")]
			[Address(RVA = "0xECC20C", Offset = "0xECC20C", VA = "0xECC20C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x62115C", Offset = "0x62115C")]
			private set
			{
			}
		}

		[Token(Token = "0x17000025")]
		public Vector3 ListenerPosition
		{
			[Token(Token = "0x600010A")]
			[Address(RVA = "0xECC214", Offset = "0xECC214", VA = "0xECC214")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x62116C", Offset = "0x62116C")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x600010B")]
			[Address(RVA = "0xECC220", Offset = "0xECC220", VA = "0xECC220")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x62117C", Offset = "0x62117C")]
			private set
			{
			}
		}

		[Token(Token = "0x17000026")]
		public static AudioEngineManager Instance
		{
			[Token(Token = "0x600010C")]
			[Address(RVA = "0xECC22C", Offset = "0xECC22C", VA = "0xECC22C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x62118C", Offset = "0x62118C")]
			get
			{
				return null;
			}
			[Token(Token = "0x600010D")]
			[Address(RVA = "0xECC27C", Offset = "0xECC27C", VA = "0xECC27C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x62119C", Offset = "0x62119C")]
			private set
			{
			}
		}

		[Token(Token = "0x14000001")]
		private event EventHandler OnEngineDestroy
		{
			[Token(Token = "0x60000F8")]
			[Address(RVA = "0xECAACC", Offset = "0xECAACC", VA = "0xECAACC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6210EC", Offset = "0x6210EC")]
			add
			{
			}
			[Token(Token = "0x60000F9")]
			[Address(RVA = "0xECAB70", Offset = "0xECAB70", VA = "0xECAB70")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6210FC", Offset = "0x6210FC")]
			remove
			{
			}
		}

		[Token(Token = "0x60000FA")]
		[Address(RVA = "0xECAC14", Offset = "0xECAC14", VA = "0xECAC14")]
		public Client NewClient()
		{
			return null;
		}

		[Token(Token = "0x60000FB")]
		[Address(RVA = "0xECAD4C", Offset = "0xECAD4C", VA = "0xECAD4C")]
		public void SetAudioListener(Vector3 listenerPos, Vector3 listenerForward, Vector3 listenerUp)
		{
		}

		[Token(Token = "0x60000FC")]
		[Address(RVA = "0xECAE38", Offset = "0xECAE38", VA = "0xECAE38")]
		public void Update()
		{
		}

		[Token(Token = "0x60000FD")]
		[Address(RVA = "0xECAE54", Offset = "0xECAE54", VA = "0xECAE54")]
		public bool Init(RuntimeOptions options, SampleRate sampleRate, AudioDeviceType deviceType, string customDeviceName = "")
		{
			return default(bool);
		}

		[Token(Token = "0x60000FE")]
		[Address(RVA = "0xECBCC8", Offset = "0xECBCC8", VA = "0xECBCC8")]
		public void Destroy()
		{
		}

		[Token(Token = "0x60000FF")]
		[Address(RVA = "0xECBDA4", Offset = "0xECBDA4", VA = "0xECBDA4")]
		public void Suspend(bool suspend)
		{
		}

		[Token(Token = "0x6000104")]
		[Address(RVA = "0xECBDE8", Offset = "0xECBDE8", VA = "0xECBDE8")]
		private void UpdateStats()
		{
		}

		[Token(Token = "0x600010E")]
		[Address(RVA = "0xECC2D0", Offset = "0xECC2D0", VA = "0xECC2D0")]
		public static void SetStaticInstance(AudioEngineManager audioEngineManager)
		{
		}

		[Token(Token = "0x600010F")]
		[Address(RVA = "0xECC324", Offset = "0xECC324", VA = "0xECC324")]
		public AudioEngineManager()
		{
		}
	}
	[Token(Token = "0x2000043")]
	[ExecuteInEditMode]
	public class AudioObject : MonoBehaviour
	{
		[Token(Token = "0x2000099")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x620628", Offset = "0x620628")]
		private sealed class <>c__DisplayClass47_0
		{
			[Token(Token = "0x400028C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Event e;

			[Token(Token = "0x60006AB")]
			[Address(RVA = "0xECE57C", Offset = "0xECE57C", VA = "0xECE57C")]
			public <>c__DisplayClass47_0()
			{
			}

			[Token(Token = "0x60006AC")]
			[Address(RVA = "0xED0314", Offset = "0xED0314", VA = "0xED0314")]
			internal void <OnEvent>b__0(ref Event eTarget)
			{
			}
		}

		[Token(Token = "0x4000102")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string file;

		[Token(Token = "0x4000103")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool playOnStart;

		[Token(Token = "0x4000104")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public AudioObjectEventListener events;

		[Token(Token = "0x4000105")]
		private const float KDefaultVolume = 1f;

		[Token(Token = "0x4000106")]
		private const bool KDefaultLoop = false;

		[Token(Token = "0x4000107")]
		private const float KDefaultPitch = 1f;

		[Token(Token = "0x4000108")]
		private const float KDefaultMinDistance = 1f;

		[Token(Token = "0x4000109")]
		private const float KDefaultMaxDistance = 1000f;

		[Token(Token = "0x400010A")]
		private const float KDefaultAttenFactor = 1f;

		[Token(Token = "0x400010B")]
		private const AttenuationMode KDefaultAttenMode = AttenuationMode.LOGARITHMIC;

		[Token(Token = "0x400010C")]
		private const bool KDefaultDirectionality = false;

		[Token(Token = "0x400010D")]
		private const float KDefaulyDirectionalityLevel = 1f;

		[Token(Token = "0x400010E")]
		private const float KDefaulyDirectionalityCone = 150f;

		[Token(Token = "0x400010F")]
		private const bool KDefaultSpatialize = true;

		[Token(Token = "0x4000110")]
		private const bool KDefaultMaxDistanceMute = false;

		[Token(Token = "0x4000111")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float volume_;

		[Token(Token = "0x4000112")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[SerializeField]
		private bool loop_;

		[Token(Token = "0x4000113")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private float pitch_;

		[Token(Token = "0x4000114")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private float minDistance_;

		[Token(Token = "0x4000115")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private float maxDistance_;

		[Token(Token = "0x4000116")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[SerializeField]
		private float attenFactor_;

		[Token(Token = "0x4000117")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private AttenuationMode attenMode_;

		[Token(Token = "0x4000118")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[SerializeField]
		private bool directionality_;

		[Token(Token = "0x4000119")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private float directionalityLevel_;

		[Token(Token = "0x400011A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[SerializeField]
		private float directionalityConeArea_;

		[Token(Token = "0x400011B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private bool spatialise_;

		[Token(Token = "0x400011C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x59")]
		[SerializeField]
		private bool maxDistanceMute_;

		[Token(Token = "0x400011D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private NativeAudioObject nativeObj_;

		[Token(Token = "0x400011E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private AudioEngineManager.Client audioEngineClient_;

		[Token(Token = "0x400011F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private AttenuationProps attenProps_;

		[Token(Token = "0x4000120")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private DirectionalProps directionalProps_;

		[Token(Token = "0x4000121")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private GCHandle thisHandle;

		[Token(Token = "0x4000122")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private IOStream stream;

		[Token(Token = "0x4000123")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Transform customTransform_;

		[Token(Token = "0x4000124")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private readonly SPSCQ<Event> eventQueue_;

		[Token(Token = "0x4000125")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private SPSCQ<Event>.Reader dispatchEvent_;

		[Token(Token = "0x4000126")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private bool attenuationPropsChanged_;

		[Token(Token = "0x4000127")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA9")]
		private bool directionalityPropsChanged_;

		[Token(Token = "0x4000128")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAA")]
		private bool valid_;

		[Token(Token = "0x4000129")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		private Vector3 previousPosition_;

		[Token(Token = "0x400012A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private Quaternion previousRotation_;

		[Token(Token = "0x400012B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private TBVector forwardVector_;

		[Token(Token = "0x400012C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private TBVector upVector_;

		[Token(Token = "0x400012D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private TBVector positionVector_;

		[Token(Token = "0x17000027")]
		public float volume
		{
			[Token(Token = "0x600013B")]
			[Address(RVA = "0xECF75C", Offset = "0xECF75C", VA = "0xECF75C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600013C")]
			[Address(RVA = "0xECF764", Offset = "0xECF764", VA = "0xECF764")]
			set
			{
			}
		}

		[Token(Token = "0x17000028")]
		public float volumeDecibels
		{
			[Token(Token = "0x600013D")]
			[Address(RVA = "0xECF848", Offset = "0xECF848", VA = "0xECF848")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600013E")]
			[Address(RVA = "0xECF8BC", Offset = "0xECF8BC", VA = "0xECF8BC")]
			set
			{
			}
		}

		[Token(Token = "0x17000029")]
		public float pitch
		{
			[Token(Token = "0x600013F")]
			[Address(RVA = "0xECF938", Offset = "0xECF938", VA = "0xECF938")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000140")]
			[Address(RVA = "0xECF984", Offset = "0xECF984", VA = "0xECF984")]
			set
			{
			}
		}

		[Token(Token = "0x1700002A")]
		public bool loop
		{
			[Token(Token = "0x6000141")]
			[Address(RVA = "0xECFA8C", Offset = "0xECFA8C", VA = "0xECFA8C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000142")]
			[Address(RVA = "0xECFA94", Offset = "0xECFA94", VA = "0xECFA94")]
			set
			{
			}
		}

		[Token(Token = "0x1700002B")]
		public float minDistance
		{
			[Token(Token = "0x6000143")]
			[Address(RVA = "0xECFAE4", Offset = "0xECFAE4", VA = "0xECFAE4")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000144")]
			[Address(RVA = "0xECFAEC", Offset = "0xECFAEC", VA = "0xECFAEC")]
			set
			{
			}
		}

		[Token(Token = "0x1700002C")]
		public float maxDistance
		{
			[Token(Token = "0x6000145")]
			[Address(RVA = "0xECFB80", Offset = "0xECFB80", VA = "0xECFB80")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000146")]
			[Address(RVA = "0xECFB88", Offset = "0xECFB88", VA = "0xECFB88")]
			set
			{
			}
		}

		[Token(Token = "0x1700002D")]
		public bool maxDistanceMute
		{
			[Token(Token = "0x6000147")]
			[Address(RVA = "0xECFC1C", Offset = "0xECFC1C", VA = "0xECFC1C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000148")]
			[Address(RVA = "0xECFC24", Offset = "0xECFC24", VA = "0xECFC24")]
			set
			{
			}
		}

		[Token(Token = "0x1700002E")]
		public float attenFactor
		{
			[Token(Token = "0x6000149")]
			[Address(RVA = "0xECFC4C", Offset = "0xECFC4C", VA = "0xECFC4C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600014A")]
			[Address(RVA = "0xECFC54", Offset = "0xECFC54", VA = "0xECFC54")]
			set
			{
			}
		}

		[Token(Token = "0x1700002F")]
		public AttenuationMode attenMode
		{
			[Token(Token = "0x600014B")]
			[Address(RVA = "0xECFCF0", Offset = "0xECFCF0", VA = "0xECFCF0")]
			get
			{
				return default(AttenuationMode);
			}
			[Token(Token = "0x600014C")]
			[Address(RVA = "0xECFD3C", Offset = "0xECFD3C", VA = "0xECFD3C")]
			set
			{
			}
		}

		[Token(Token = "0x17000030")]
		public bool directionality
		{
			[Token(Token = "0x600014D")]
			[Address(RVA = "0xECFD7C", Offset = "0xECFD7C", VA = "0xECFD7C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600014E")]
			[Address(RVA = "0xECFD84", Offset = "0xECFD84", VA = "0xECFD84")]
			set
			{
			}
		}

		[Token(Token = "0x17000031")]
		public float directionalityLevel
		{
			[Token(Token = "0x600014F")]
			[Address(RVA = "0xECFDD4", Offset = "0xECFDD4", VA = "0xECFDD4")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000150")]
			[Address(RVA = "0xECFDDC", Offset = "0xECFDDC", VA = "0xECFDDC")]
			set
			{
			}
		}

		[Token(Token = "0x17000032")]
		public float directionalityConeArea
		{
			[Token(Token = "0x6000151")]
			[Address(RVA = "0xECFE6C", Offset = "0xECFE6C", VA = "0xECFE6C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000152")]
			[Address(RVA = "0xECFE74", Offset = "0xECFE74", VA = "0xECFE74")]
			set
			{
			}
		}

		[Token(Token = "0x17000033")]
		public bool spatialise
		{
			[Token(Token = "0x6000153")]
			[Address(RVA = "0xECFF04", Offset = "0xECFF04", VA = "0xECFF04")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000154")]
			[Address(RVA = "0xECFF0C", Offset = "0xECFF0C", VA = "0xECFF0C")]
			set
			{
			}
		}

		[Token(Token = "0x17000034")]
		public Transform customTransform
		{
			[Token(Token = "0x6000155")]
			[Address(RVA = "0xECFF5C", Offset = "0xECFF5C", VA = "0xECFF5C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000156")]
			[Address(RVA = "0xECFF64", Offset = "0xECFF64", VA = "0xECFF64")]
			set
			{
			}
		}

		[Token(Token = "0x17000035")]
		public NativeAudioObject nativeObject
		{
			[Token(Token = "0x6000157")]
			[Address(RVA = "0xECFF6C", Offset = "0xECFF6C", VA = "0xECFF6C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000110")]
		[Address(RVA = "0xECE36C", Offset = "0xECE36C", VA = "0xECE36C")]
		public static AudioObject AddAsComponent(GameObject gameObject, AudioEngineManager.Client audioEngineClient)
		{
			return null;
		}

		[Token(Token = "0x6000111")]
		[Address(RVA = "0xECE2A4", Offset = "0xECE2A4", VA = "0xECE2A4")]
		[AttributeAttribute(Name = "MonoPInvokeCallbackAttribute", RVA = "0x6211AC", Offset = "0x6211AC")]
		private static void eventCallback(Event e, IntPtr userData)
		{
		}

		[Token(Token = "0x6000112")]
		[Address(RVA = "0xECE544", Offset = "0xECE544", VA = "0xECE544")]
		private void DispatchEvent(Event e)
		{
		}

		[Token(Token = "0x6000113")]
		[Address(RVA = "0xECE480", Offset = "0xECE480", VA = "0xECE480")]
		private void OnEvent(Event e)
		{
		}

		[Token(Token = "0x6000114")]
		[Address(RVA = "0xECE584", Offset = "0xECE584", VA = "0xECE584")]
		public void FlushEvents()
		{
		}

		[Token(Token = "0x6000115")]
		[Address(RVA = "0xECE3E8", Offset = "0xECE3E8", VA = "0xECE3E8")]
		public void setAudioEngineManager(AudioEngineManager.Client audioEngineClient)
		{
		}

		[Token(Token = "0x6000116")]
		[Address(RVA = "0xECE5E8", Offset = "0xECE5E8", VA = "0xECE5E8")]
		private void AudioEngineClientOnInvalid(object sender, EventArgs e)
		{
		}

		[Token(Token = "0x6000117")]
		[Address(RVA = "0xECE5F0", Offset = "0xECE5F0", VA = "0xECE5F0")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000118")]
		[Address(RVA = "0xECE904", Offset = "0xECE904", VA = "0xECE904")]
		private void Start()
		{
		}

		[Token(Token = "0x6000119")]
		[Address(RVA = "0xECEB28", Offset = "0xECEB28", VA = "0xECEB28")]
		private AudioEngine getEngine()
		{
			return null;
		}

		[Token(Token = "0x600011A")]
		[Address(RVA = "0xECE618", Offset = "0xECE618", VA = "0xECE618")]
		private void init()
		{
		}

		[Token(Token = "0x600011B")]
		[Address(RVA = "0xECEBDC", Offset = "0xECEBDC", VA = "0xECEBDC")]
		private void Update()
		{
		}

		[Token(Token = "0x600011C")]
		[Address(RVA = "0xECE8FC", Offset = "0xECE8FC", VA = "0xECE8FC")]
		public void ForceUpdateProps()
		{
		}

		[Token(Token = "0x600011D")]
		[Address(RVA = "0xECEBE4", Offset = "0xECEBE4", VA = "0xECEBE4")]
		private void DoUpdate(bool force)
		{
		}

		[Token(Token = "0x600011E")]
		[Address(RVA = "0xECEF50", Offset = "0xECEF50", VA = "0xECEF50")]
		private void UpdateAttenuationProps(bool force)
		{
		}

		[Token(Token = "0x600011F")]
		[Address(RVA = "0xECEFEC", Offset = "0xECEFEC", VA = "0xECEFEC")]
		private void UpdateDirectionalityProps(bool force)
		{
		}

		[Token(Token = "0x6000120")]
		[Address(RVA = "0xECECF4", Offset = "0xECECF4", VA = "0xECECF4")]
		private void UpdateTransform(bool force)
		{
		}

		[Token(Token = "0x6000121")]
		[Address(RVA = "0xECF0D0", Offset = "0xECF0D0", VA = "0xECF0D0")]
		public bool IsPlaying()
		{
			return default(bool);
		}

		[Token(Token = "0x6000122")]
		[Address(RVA = "0xECEA20", Offset = "0xECEA20", VA = "0xECEA20")]
		public bool open(string fileToplay)
		{
			return default(bool);
		}

		[Token(Token = "0x6000123")]
		[Address(RVA = "0xECF114", Offset = "0xECF114", VA = "0xECF114")]
		public bool open(IOStream streamObject)
		{
			return default(bool);
		}

		[Token(Token = "0x6000124")]
		[Address(RVA = "0xECF164", Offset = "0xECF164", VA = "0xECF164")]
		public bool open(AudioFormatDecoder decoder)
		{
			return default(bool);
		}

		[Token(Token = "0x6000125")]
		[Address(RVA = "0xECF1B0", Offset = "0xECF1B0", VA = "0xECF1B0")]
		public void close()
		{
		}

		[Token(Token = "0x6000126")]
		[Address(RVA = "0xECE9EC", Offset = "0xECE9EC", VA = "0xECE9EC")]
		public bool isOpen()
		{
			return default(bool);
		}

		[Token(Token = "0x6000127")]
		[Address(RVA = "0xECEADC", Offset = "0xECEADC", VA = "0xECEADC")]
		public void play()
		{
		}

		[Token(Token = "0x6000128")]
		[Address(RVA = "0xECF1F4", Offset = "0xECF1F4", VA = "0xECF1F4")]
		public void playScheduled(float millisecondsFromNow)
		{
		}

		[Token(Token = "0x6000129")]
		[Address(RVA = "0xECF254", Offset = "0xECF254", VA = "0xECF254")]
		public void playScheduled(float millisecondsFromNow, float fadeTimeInMs)
		{
		}

		[Token(Token = "0x600012A")]
		[Address(RVA = "0xECF2BC", Offset = "0xECF2BC", VA = "0xECF2BC")]
		public void playWithFade(float fadeDurationInMs)
		{
		}

		[Token(Token = "0x600012B")]
		[Address(RVA = "0xECF31C", Offset = "0xECF31C", VA = "0xECF31C")]
		public void stop()
		{
		}

		[Token(Token = "0x600012C")]
		[Address(RVA = "0xECF34C", Offset = "0xECF34C", VA = "0xECF34C")]
		public void stopScheduled(float millisecondsFromNow)
		{
		}

		[Token(Token = "0x600012D")]
		[Address(RVA = "0xECF37C", Offset = "0xECF37C", VA = "0xECF37C")]
		public void stopScheduled(float millisecondsFromNow, float fadeTimeInMs)
		{
		}

		[Token(Token = "0x600012E")]
		[Address(RVA = "0xECF3AC", Offset = "0xECF3AC", VA = "0xECF3AC")]
		public void stopWithFade(float fadeDurationInMs)
		{
		}

		[Token(Token = "0x600012F")]
		[Address(RVA = "0xECF3DC", Offset = "0xECF3DC", VA = "0xECF3DC")]
		public void pause()
		{
		}

		[Token(Token = "0x6000130")]
		[Address(RVA = "0xECF408", Offset = "0xECF408", VA = "0xECF408")]
		public void pauseScheduled(float millisecondsFromNow)
		{
		}

		[Token(Token = "0x6000131")]
		[Address(RVA = "0xECF434", Offset = "0xECF434", VA = "0xECF434")]
		public void pauseScheduled(float millisecondsFromNow, float fadeTimeInMs)
		{
		}

		[Token(Token = "0x6000132")]
		[Address(RVA = "0xECF460", Offset = "0xECF460", VA = "0xECF460")]
		public void pauseWithFade(float fadeDurationInMs)
		{
		}

		[Token(Token = "0x6000133")]
		[Address(RVA = "0xECF490", Offset = "0xECF490", VA = "0xECF490")]
		public bool seekToMs(float ms)
		{
			return default(bool);
		}

		[Token(Token = "0x6000134")]
		[Address(RVA = "0xECF4D8", Offset = "0xECF4D8", VA = "0xECF4D8")]
		public double getElapsedTimeInMs()
		{
			return default(double);
		}

		[Token(Token = "0x6000135")]
		[Address(RVA = "0xECF50C", Offset = "0xECF50C", VA = "0xECF50C")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x621210", Offset = "0x621210")]
		public double getDurationInMs()
		{
			return default(double);
		}

		[Token(Token = "0x6000136")]
		[Address(RVA = "0xECF54C", Offset = "0xECF54C", VA = "0xECF54C")]
		public double getAssetDurationInMs()
		{
			return default(double);
		}

		[Token(Token = "0x6000137")]
		[Address(RVA = "0xECF58C", Offset = "0xECF58C", VA = "0xECF58C")]
		public PlayState getPlayState()
		{
			return default(PlayState);
		}

		[Token(Token = "0x6000138")]
		[Address(RVA = "0xECF5C0", Offset = "0xECF5C0", VA = "0xECF5C0")]
		public void cancelScheduledParams()
		{
		}

		[Token(Token = "0x6000139")]
		[Address(RVA = "0xECF5F0", Offset = "0xECF5F0", VA = "0xECF5F0")]
		public void resetState()
		{
		}

		[Token(Token = "0x600013A")]
		[Address(RVA = "0xECF664", Offset = "0xECF664", VA = "0xECF664")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000158")]
		[Address(RVA = "0xECFF74", Offset = "0xECFF74", VA = "0xECFF74")]
		public static AudioObject createAndPlayOnObject(GameObject ga, string file)
		{
			return null;
		}

		[Token(Token = "0x6000159")]
		[Address(RVA = "0xED0080", Offset = "0xED0080", VA = "0xED0080")]
		public static AudioObject createOnObject(GameObject ga, string file)
		{
			return null;
		}

		[Token(Token = "0x600015A")]
		[Address(RVA = "0xED0180", Offset = "0xED0180", VA = "0xED0180")]
		public AudioObject()
		{
		}
	}
	[Token(Token = "0x2000044")]
	public class AudioObjectEventListener
	{
		[Token(Token = "0x200009A")]
		public delegate void EventDelegate(Event e, AudioObject obj);

		[Token(Token = "0x400012E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public EventDelegate newEvent;

		[Token(Token = "0x600015B")]
		[Address(RVA = "0xECE56C", Offset = "0xECE56C", VA = "0xECE56C")]
		public void onNewEvent(Event e, AudioObject obj)
		{
		}

		[Token(Token = "0x600015C")]
		[Address(RVA = "0xED0298", Offset = "0xED0298", VA = "0xED0298")]
		public AudioObjectEventListener()
		{
		}
	}
	[Token(Token = "0x2000045")]
	public class EventListener
	{
		[Token(Token = "0x200009B")]
		public delegate void EventDelegate(Event e);

		[Token(Token = "0x400012F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public EventDelegate newEvent;

		[Token(Token = "0x600015D")]
		[Address(RVA = "0xED3174", Offset = "0xED3174", VA = "0xED3174")]
		public void onNewEvent(Event e)
		{
		}

		[Token(Token = "0x600015E")]
		[Address(RVA = "0xED33F4", Offset = "0xED33F4", VA = "0xED33F4")]
		public EventListener()
		{
		}
	}
	[Token(Token = "0x2000046")]
	internal class SpatDecoderFileValidationError : Exception
	{
		[Token(Token = "0x4000130")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public SpatDecoderFile spatDecoderFile;

		[Token(Token = "0x600015F")]
		[Address(RVA = "0xEDB1D0", Offset = "0xEDB1D0", VA = "0xEDB1D0")]
		public SpatDecoderFileValidationError(string message, SpatDecoderFile o)
		{
		}
	}
	[Token(Token = "0x2000047")]
	public class SpatDecoderFile : MonoBehaviour
	{
		[Token(Token = "0x200009C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x620638", Offset = "0x620638")]
		private sealed class <>c__DisplayClass20_0
		{
			[Token(Token = "0x400028D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Event e;

			[Token(Token = "0x60006B5")]
			[Address(RVA = "0xEDAAF4", Offset = "0xEDAAF4", VA = "0xEDAAF4")]
			public <>c__DisplayClass20_0()
			{
			}

			[Token(Token = "0x60006B6")]
			[Address(RVA = "0xEDC358", Offset = "0xEDC358", VA = "0xEDC358")]
			internal void <OnEvent>b__0(ref Event eTarget)
			{
			}
		}

		[Token(Token = "0x4000131")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string file;

		[Token(Token = "0x4000132")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool playOnStart;

		[Token(Token = "0x4000133")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public EventListener events;

		[Token(Token = "0x4000134")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private NativeSpatDecoderFile spat_;

		[Token(Token = "0x4000135")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private AudioEngineManager.Client audioEngineClient_;

		[Token(Token = "0x4000136")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private float volume_;

		[Token(Token = "0x4000137")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[SerializeField]
		private SyncMode syncMode_;

		[Token(Token = "0x4000138")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private bool focus_;

		[Token(Token = "0x4000139")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x49")]
		[SerializeField]
		private bool focusFollowsListener_;

		[Token(Token = "0x400013A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[SerializeField]
		private float offFocusLeveldB_;

		[Token(Token = "0x400013B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private float focusWidth_;

		[Token(Token = "0x400013C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[SerializeField]
		private bool loop_;

		[Token(Token = "0x400013D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x55")]
		[SerializeField]
		private bool useObjectRotation_;

		[Token(Token = "0x400013E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private GCHandle thisHandle;

		[Token(Token = "0x400013F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private IOStream streamA;

		[Token(Token = "0x4000140")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private IOStream streamB;

		[Token(Token = "0x4000141")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Transform customTransform_;

		[Token(Token = "0x4000142")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private readonly SPSCQ<Event> eventQueue_;

		[Token(Token = "0x17000036")]
		public float volume
		{
			[Token(Token = "0x6000186")]
			[Address(RVA = "0xEDBC44", Offset = "0xEDBC44", VA = "0xEDBC44")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000187")]
			[Address(RVA = "0xEDBC90", Offset = "0xEDBC90", VA = "0xEDBC90")]
			set
			{
			}
		}

		[Token(Token = "0x17000037")]
		public float volumeDecibels
		{
			[Token(Token = "0x6000188")]
			[Address(RVA = "0xEDBCE4", Offset = "0xEDBCE4", VA = "0xEDBCE4")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000189")]
			[Address(RVA = "0xEDBD60", Offset = "0xEDBD60", VA = "0xEDBD60")]
			set
			{
			}
		}

		[Token(Token = "0x17000038")]
		public SyncMode syncMode
		{
			[Token(Token = "0x600018A")]
			[Address(RVA = "0xEDBDDC", Offset = "0xEDBDDC", VA = "0xEDBDDC")]
			get
			{
				return default(SyncMode);
			}
			[Token(Token = "0x600018B")]
			[Address(RVA = "0xEDBE28", Offset = "0xEDBE28", VA = "0xEDBE28")]
			set
			{
			}
		}

		[Token(Token = "0x17000039")]
		public bool focus
		{
			[Token(Token = "0x600018C")]
			[Address(RVA = "0xEDBE78", Offset = "0xEDBE78", VA = "0xEDBE78")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600018D")]
			[Address(RVA = "0xEDBE80", Offset = "0xEDBE80", VA = "0xEDBE80")]
			set
			{
			}
		}

		[Token(Token = "0x1700003A")]
		public float offFocusLeveldB
		{
			[Token(Token = "0x600018E")]
			[Address(RVA = "0xEDBED8", Offset = "0xEDBED8", VA = "0xEDBED8")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600018F")]
			[Address(RVA = "0xEDBEE0", Offset = "0xEDBEE0", VA = "0xEDBEE0")]
			set
			{
			}
		}

		[Token(Token = "0x1700003B")]
		public float focusWidth
		{
			[Token(Token = "0x6000190")]
			[Address(RVA = "0xEDBFD8", Offset = "0xEDBFD8", VA = "0xEDBFD8")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000191")]
			[Address(RVA = "0xEDBFE0", Offset = "0xEDBFE0", VA = "0xEDBFE0")]
			set
			{
			}
		}

		[Token(Token = "0x1700003C")]
		public bool loop
		{
			[Token(Token = "0x6000192")]
			[Address(RVA = "0xEDC0D8", Offset = "0xEDC0D8", VA = "0xEDC0D8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000193")]
			[Address(RVA = "0xEDC0E0", Offset = "0xEDC0E0", VA = "0xEDC0E0")]
			set
			{
			}
		}

		[Token(Token = "0x1700003D")]
		public bool useObjectRotation
		{
			[Token(Token = "0x6000194")]
			[Address(RVA = "0xEDC134", Offset = "0xEDC134", VA = "0xEDC134")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000195")]
			[Address(RVA = "0xEDC13C", Offset = "0xEDC13C", VA = "0xEDC13C")]
			set
			{
			}
		}

		[Token(Token = "0x1700003E")]
		public Transform customTransform
		{
			[Token(Token = "0x6000196")]
			[Address(RVA = "0xEDC148", Offset = "0xEDC148", VA = "0xEDC148")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000197")]
			[Address(RVA = "0xEDC150", Offset = "0xEDC150", VA = "0xEDC150")]
			set
			{
			}
		}

		[Token(Token = "0x1700003F")]
		public NativeSpatDecoderFile nativeObject
		{
			[Token(Token = "0x6000198")]
			[Address(RVA = "0xEDC158", Offset = "0xEDC158", VA = "0xEDC158")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000160")]
		[Address(RVA = "0xEDA9C0", Offset = "0xEDA9C0", VA = "0xEDA9C0")]
		public static SpatDecoderFile AddAsComponent(GameObject gameObject, AudioEngineManager.Client audioEngineClient)
		{
			return null;
		}

		[Token(Token = "0x6000161")]
		[Address(RVA = "0xEDA8F8", Offset = "0xEDA8F8", VA = "0xEDA8F8")]
		[AttributeAttribute(Name = "MonoPInvokeCallbackAttribute", RVA = "0x621248", Offset = "0x621248")]
		private static void eventCallback(Event e, IntPtr userData)
		{
		}

		[Token(Token = "0x6000162")]
		[Address(RVA = "0xEDAA30", Offset = "0xEDAA30", VA = "0xEDAA30")]
		private void OnEvent(Event e)
		{
		}

		[Token(Token = "0x6000163")]
		[Address(RVA = "0xEDAAFC", Offset = "0xEDAAFC", VA = "0xEDAAFC")]
		public void setAudioEngineManager(AudioEngineManager.Client audioEngineClient)
		{
		}

		[Token(Token = "0x6000164")]
		[Address(RVA = "0xEDAB04", Offset = "0xEDAB04", VA = "0xEDAB04")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000165")]
		[Address(RVA = "0xEDAC64", Offset = "0xEDAC64", VA = "0xEDAC64")]
		private void Start()
		{
		}

		[Token(Token = "0x6000166")]
		[Address(RVA = "0xEDAF50", Offset = "0xEDAF50", VA = "0xEDAF50")]
		private AudioEngine getEngine()
		{
			return null;
		}

		[Token(Token = "0x6000167")]
		[Address(RVA = "0xEDAFEC", Offset = "0xEDAFEC", VA = "0xEDAFEC")]
		private void Update()
		{
		}

		[Token(Token = "0x6000168")]
		[Address(RVA = "0xEDAD70", Offset = "0xEDAD70", VA = "0xEDAD70")]
		private bool validate()
		{
			return default(bool);
		}

		[Token(Token = "0x6000169")]
		[Address(RVA = "0xEDAB08", Offset = "0xEDAB08", VA = "0xEDAB08")]
		private void init()
		{
		}

		[Token(Token = "0x600016A")]
		[Address(RVA = "0xEDB254", Offset = "0xEDB254", VA = "0xEDB254")]
		public void updateProps()
		{
		}

		[Token(Token = "0x600016B")]
		[Address(RVA = "0xEDAE88", Offset = "0xEDAE88", VA = "0xEDAE88")]
		public bool open(string fileToplay, ChannelMap map = ChannelMap.UNKNOWN)
		{
			return default(bool);
		}

		[Token(Token = "0x600016C")]
		[Address(RVA = "0xEDB334", Offset = "0xEDB334", VA = "0xEDB334")]
		public bool open(IOStream streamObjectA, IOStream streamObjectB, ChannelMap map = ChannelMap.UNKNOWN)
		{
			return default(bool);
		}

		[Token(Token = "0x600016D")]
		[Address(RVA = "0xEDB3A8", Offset = "0xEDB3A8", VA = "0xEDB3A8")]
		public bool open(string fileToplay, AssetDescriptor assetDescriptor, ChannelMap map = ChannelMap.UNKNOWN)
		{
			return default(bool);
		}

		[Token(Token = "0x600016E")]
		[Address(RVA = "0xEDB480", Offset = "0xEDB480", VA = "0xEDB480")]
		public void close()
		{
		}

		[Token(Token = "0x600016F")]
		[Address(RVA = "0xEDAE3C", Offset = "0xEDAE3C", VA = "0xEDAE3C")]
		public bool isOpen()
		{
			return default(bool);
		}

		[Token(Token = "0x6000170")]
		[Address(RVA = "0xEDB4C4", Offset = "0xEDB4C4", VA = "0xEDB4C4")]
		public void play()
		{
		}

		[Token(Token = "0x6000171")]
		[Address(RVA = "0xEDB510", Offset = "0xEDB510", VA = "0xEDB510")]
		public void playScheduled(float millisecondsFromNow)
		{
		}

		[Token(Token = "0x6000172")]
		[Address(RVA = "0xEDB570", Offset = "0xEDB570", VA = "0xEDB570")]
		public void playWithFade(float fadeDurationInMs)
		{
		}

		[Token(Token = "0x6000173")]
		[Address(RVA = "0xEDB5D0", Offset = "0xEDB5D0", VA = "0xEDB5D0")]
		public void stop()
		{
		}

		[Token(Token = "0x6000174")]
		[Address(RVA = "0xEDB618", Offset = "0xEDB618", VA = "0xEDB618")]
		public void stopScheduled(float millisecondsFromNow)
		{
		}

		[Token(Token = "0x6000175")]
		[Address(RVA = "0xEDB674", Offset = "0xEDB674", VA = "0xEDB674")]
		public void stopWithFade(float fadeDurationInMs)
		{
		}

		[Token(Token = "0x6000176")]
		[Address(RVA = "0xEDB6D0", Offset = "0xEDB6D0", VA = "0xEDB6D0")]
		public void pause()
		{
		}

		[Token(Token = "0x6000177")]
		[Address(RVA = "0xEDB714", Offset = "0xEDB714", VA = "0xEDB714")]
		public void pauseScheduled(float millisecondsFromNow)
		{
		}

		[Token(Token = "0x6000178")]
		[Address(RVA = "0xEDB76C", Offset = "0xEDB76C", VA = "0xEDB76C")]
		public void pauseWithFade(float fadeDurationInMs)
		{
		}

		[Token(Token = "0x6000179")]
		[Address(RVA = "0xEDB7C8", Offset = "0xEDB7C8", VA = "0xEDB7C8")]
		public PlayState getPlayState()
		{
			return default(PlayState);
		}

		[Token(Token = "0x600017A")]
		[Address(RVA = "0xEDB814", Offset = "0xEDB814", VA = "0xEDB814")]
		public void seekToMs(float ms)
		{
		}

		[Token(Token = "0x600017B")]
		[Address(RVA = "0xEDB870", Offset = "0xEDB870", VA = "0xEDB870")]
		public void seekToSample(uint sample)
		{
		}

		[Token(Token = "0x600017C")]
		[Address(RVA = "0xEDB8C0", Offset = "0xEDB8C0", VA = "0xEDB8C0")]
		public double getElapsedTimeInMs()
		{
			return default(double);
		}

		[Token(Token = "0x600017D")]
		[Address(RVA = "0xEDB90C", Offset = "0xEDB90C", VA = "0xEDB90C")]
		public uint getElapsedTimeInSamples()
		{
			return default(uint);
		}

		[Token(Token = "0x600017E")]
		[Address(RVA = "0xEDB958", Offset = "0xEDB958", VA = "0xEDB958")]
		public double getAssetDurationInMs()
		{
			return default(double);
		}

		[Token(Token = "0x600017F")]
		[Address(RVA = "0xEDB9A0", Offset = "0xEDB9A0", VA = "0xEDB9A0")]
		public uint getAssetDurationInSamples()
		{
			return default(uint);
		}

		[Token(Token = "0x6000180")]
		[Address(RVA = "0xEDB9EC", Offset = "0xEDB9EC", VA = "0xEDB9EC")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000181")]
		[Address(RVA = "0xEDBA98", Offset = "0xEDBA98", VA = "0xEDBA98")]
		public void setExternalClockInMs(double externalClockInMs)
		{
		}

		[Token(Token = "0x6000182")]
		[Address(RVA = "0xEDBAF4", Offset = "0xEDBAF4", VA = "0xEDBAF4")]
		public void setFreewheelTimeInMs(double freewheelInMs)
		{
		}

		[Token(Token = "0x6000183")]
		[Address(RVA = "0xEDBB50", Offset = "0xEDBB50", VA = "0xEDBB50")]
		public double getFreewheelTimeInMs()
		{
			return default(double);
		}

		[Token(Token = "0x6000184")]
		[Address(RVA = "0xEDBB9C", Offset = "0xEDBB9C", VA = "0xEDBB9C")]
		public void setResyncThresholdMs(double resyncThresholdMs)
		{
		}

		[Token(Token = "0x6000185")]
		[Address(RVA = "0xEDBBF8", Offset = "0xEDBBF8", VA = "0xEDBBF8")]
		public double getResyncThresholdMs()
		{
			return default(double);
		}

		[Token(Token = "0x6000199")]
		[Address(RVA = "0xEDC160", Offset = "0xEDC160", VA = "0xEDC160")]
		public static SpatDecoderFile createOnObject(GameObject ga, string file, ChannelMap map = ChannelMap.TBE_8_2)
		{
			return null;
		}

		[Token(Token = "0x600019A")]
		[Address(RVA = "0xEDC268", Offset = "0xEDC268", VA = "0xEDC268")]
		public SpatDecoderFile()
		{
		}

		[Token(Token = "0x600019B")]
		[Address(RVA = "0xEDC334", Offset = "0xEDC334", VA = "0xEDC334")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6212AC", Offset = "0x6212AC")]
		private void <Update>b__25_0(Event e)
		{
		}
	}
	[Token(Token = "0x2000048")]
	public interface IObject
	{
		[Token(Token = "0x600019C")]
		void onInit();

		[Token(Token = "0x600019D")]
		void onTerminate();

		[Token(Token = "0x600019E")]
		bool mustNotDestroyOnLoad();
	}
	[Token(Token = "0x2000049")]
	public class ObbExtractor
	{
		[Token(Token = "0x200009D")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x620648", Offset = "0x620648")]
		private sealed class <extractFromObb>d__2 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400028E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400028F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000290")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public string[] assetNames;

			[Token(Token = "0x4000291")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public bool forceReplace;

			[Token(Token = "0x4000292")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private string[] <>7__wrap1;

			[Token(Token = "0x4000293")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private int <>7__wrap2;

			[Token(Token = "0x4000294")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private string <name>5__4;

			[Token(Token = "0x4000295")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private UnityWebRequest <request>5__5;

			[Token(Token = "0x1700008B")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60006BB")]
				[Address(RVA = "0xED9DF8", Offset = "0xED9DF8", VA = "0xED9DF8", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700008C")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60006BD")]
				[Address(RVA = "0xED9E60", Offset = "0xED9E60", VA = "0xED9E60", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60006B7")]
			[Address(RVA = "0xED95D8", Offset = "0xED95D8", VA = "0xED95D8")]
			[DebuggerHidden]
			public <extractFromObb>d__2(int <>1__state)
			{
			}

			[Token(Token = "0x60006B8")]
			[Address(RVA = "0xED960C", Offset = "0xED960C", VA = "0xED960C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60006B9")]
			[Address(RVA = "0xED96E8", Offset = "0xED96E8", VA = "0xED96E8", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60006BA")]
			[Address(RVA = "0xED9628", Offset = "0xED9628", VA = "0xED9628")]
			private void <>m__Finally1()
			{
			}

			[Token(Token = "0x60006BC")]
			[Address(RVA = "0xED9E00", Offset = "0xED9E00", VA = "0xED9E00", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x600019F")]
		[Address(RVA = "0xED94D0", Offset = "0xED94D0", VA = "0xED94D0")]
		public static string getStreamingAssetsPath()
		{
			return null;
		}

		[Token(Token = "0x60001A0")]
		[Address(RVA = "0xED94F8", Offset = "0xED94F8", VA = "0xED94F8")]
		public static bool streamingAssetsAreInObb()
		{
			return default(bool);
		}

		[Token(Token = "0x60001A1")]
		[Address(RVA = "0xED9554", Offset = "0xED9554", VA = "0xED9554")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x6212BC", Offset = "0x6212BC")]
		public static IEnumerator extractFromObb(string[] assetNames, bool forceReplace)
		{
			return null;
		}

		[Token(Token = "0x60001A2")]
		[Address(RVA = "0xED9604", Offset = "0xED9604", VA = "0xED9604")]
		public ObbExtractor()
		{
		}
	}
	[Token(Token = "0x200004A")]
	public class Singleton<T> : MonoBehaviour where T : MonoBehaviour, IObject
	{
		[Token(Token = "0x4000143")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static object lock_;

		[Token(Token = "0x4000144")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static T instance_;

		[Token(Token = "0x4000145")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static bool onDestroyCalled_;

		[Token(Token = "0x17000040")]
		public static T Instance
		{
			[Token(Token = "0x60001A3")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001A4")]
		public static void forceResetState()
		{
		}

		[Token(Token = "0x60001A5")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60001A6")]
		public Singleton()
		{
		}
	}
	[Token(Token = "0x200004B")]
	public struct EventTransportMessage
	{
		[Token(Token = "0x4000146")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public EventTransportMessageType type;

		[Token(Token = "0x4000147")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public ulong engineTimeSamples;

		[Token(Token = "0x4000148")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public ulong posSamples;

		[Token(Token = "0x4000149")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public byte channel;

		[Token(Token = "0x400014A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		public byte id;

		[Token(Token = "0x400014B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float value;
	}
	[Token(Token = "0x200004C")]
	public delegate void EventTransportCallback(EventTransportMessage msg, IntPtr u);
	[Token(Token = "0x200004D")]
	public delegate void EventCallback(Event e, IntPtr u);
	[Token(Token = "0x200004E")]
	public delegate void AudioInterleavedCallback(IntPtr floatInterleavedAudio, uint numChannels, uint numSamplesPerChannel, IntPtr userData);
	[Token(Token = "0x200004F")]
	public delegate void AudioObjectBufferCallback(IntPtr floatInterleavedAudio, uint numSamplesInAllChannels, uint numChannels, IntPtr userData);
	[Token(Token = "0x2000050")]
	public delegate void VoiceManagerEventCb(VoiceManagerEvent e, ulong handle, IntPtr u);
	[Token(Token = "0x2000051")]
	public enum LoggerVerbosity
	{
		[Token(Token = "0x400014D")]
		ALL,
		[Token(Token = "0x400014E")]
		WARNINGS_AND_ERRORS,
		[Token(Token = "0x400014F")]
		ERRORS,
		[Token(Token = "0x4000150")]
		INFO
	}
	[Token(Token = "0x2000052")]
	public enum SampleRate
	{
		[Token(Token = "0x4000152")]
		SR_44100,
		[Token(Token = "0x4000153")]
		SR_48000
	}
	[Token(Token = "0x2000053")]
	public enum PathType
	{
		[Token(Token = "0x4000155")]
		STREAMING_ASSETS,
		[Token(Token = "0x4000156")]
		ABSOLUTE
	}
	[Token(Token = "0x2000054")]
	public struct RuntimeOptions
	{
		[Token(Token = "0x4000157")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public bool useFBA;

		[Token(Token = "0x4000158")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1")]
		public bool useVoiceVirtualization;

		[Token(Token = "0x4000159")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2")]
		public bool useNativeVoiceManager;

		[Token(Token = "0x400015A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public uint maxPhysicalVoices;

		[Token(Token = "0x400015B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public uint maxVirtualVoices;

		[Token(Token = "0x400015C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public int audioObjectPoolSize;

		[Token(Token = "0x400015D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int spatDecoderFilePoolSize;

		[Token(Token = "0x400015E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public int spatQueuePoolSize;

		[Token(Token = "0x60001BC")]
		[Address(RVA = "0xEDA8C4", Offset = "0xEDA8C4", VA = "0xEDA8C4")]
		public static RuntimeOptions Create(bool useNativeVoiceManager, uint maxPhysicalVoices = 100u, uint maxVirtualVoices = 200u)
		{
			return default(RuntimeOptions);
		}

		[Token(Token = "0x60001BD")]
		[Address(RVA = "0xEDA8E8", Offset = "0xEDA8E8", VA = "0xEDA8E8")]
		public static RuntimeOptions CreateLegacy(int objectPoolSize, int spatFilePoolSize, int queuePoolSize)
		{
			return default(RuntimeOptions);
		}
	}
	[Token(Token = "0x2000055")]
	public class Utils
	{
		[Token(Token = "0x400015F")]
		public const string DLL = "Audio360CSharp";

		[Token(Token = "0x4000160")]
		public const SampleRate kEngineSampleRate = SampleRate.SR_48000;

		[Token(Token = "0x4000161")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static float kFocusMin;

		[Token(Token = "0x4000162")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public static float kFocusMax;

		[Token(Token = "0x4000163")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static float kFocusWidthMin;

		[Token(Token = "0x4000164")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public static float kFocusWidthMax;

		[Token(Token = "0x4000165")]
		public const uint kEventQueueSize = 32u;

		[Token(Token = "0x4000166")]
		public const uint kTransportEventQueueSize = 32u;

		[Token(Token = "0x4000167")]
		public const uint kVoiceManagerEventQueueSize = 256u;

		[Token(Token = "0x4000168")]
		public const string kSwitchBehaviorContextKey = "Switch_CurrentAudioFile";

		[Token(Token = "0x4000169")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static LoggerVerbosity logVerbosity;

		[Token(Token = "0x17000041")]
		public static float kEngineSampleRateFloat
		{
			[Token(Token = "0x60001BE")]
			[Address(RVA = "0x11627B0", Offset = "0x11627B0", VA = "0x11627B0")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x60001BF")]
		[Address(RVA = "0x116282C", Offset = "0x116282C", VA = "0x116282C")]
		public static Vector3 toVector3(TBVector vector)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60001C0")]
		[Address(RVA = "0x11628A4", Offset = "0x11628A4", VA = "0x11628A4")]
		public static TBVector toTBVector(Vector3 vector)
		{
			return null;
		}

		[Token(Token = "0x60001C1")]
		[Address(RVA = "0x1162924", Offset = "0x1162924", VA = "0x1162924")]
		public static Quaternion toQuaternion(TBQuat quat)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60001C2")]
		[Address(RVA = "0x11629B0", Offset = "0x11629B0", VA = "0x11629B0")]
		public static TBQuat toTBQuat(Quaternion quat)
		{
			return null;
		}

		[Token(Token = "0x60001C3")]
		[Address(RVA = "0x1162A38", Offset = "0x1162A38", VA = "0x1162A38")]
		public static void logError(string messg, UnityEngine.Object context)
		{
		}

		[Token(Token = "0x60001C4")]
		[Address(RVA = "0x1162B14", Offset = "0x1162B14", VA = "0x1162B14")]
		public static void logWarning(string messg, UnityEngine.Object context)
		{
		}

		[Token(Token = "0x60001C5")]
		[Address(RVA = "0x1162C18", Offset = "0x1162C18", VA = "0x1162C18")]
		public static void log(string messg, UnityEngine.Object context)
		{
		}

		[Token(Token = "0x60001C6")]
		[Address(RVA = "0x1162814", Offset = "0x1162814", VA = "0x1162814")]
		public static float toSampleRateFloat(SampleRate sr)
		{
			return default(float);
		}

		[Token(Token = "0x60001C7")]
		[Address(RVA = "0x1162D18", Offset = "0x1162D18", VA = "0x1162D18")]
		public static SampleRate toSampleRateEnum(float sr)
		{
			return default(SampleRate);
		}

		[Token(Token = "0x60001C8")]
		[Address(RVA = "0x1162E08", Offset = "0x1162E08", VA = "0x1162E08")]
		public static string resolvePath(string path, PathType type)
		{
			return null;
		}

		[Token(Token = "0x60001C9")]
		[Address(RVA = "0x1162F28", Offset = "0x1162F28", VA = "0x1162F28")]
		public static float decibelsToLinear(float db)
		{
			return default(float);
		}

		[Token(Token = "0x60001CA")]
		[Address(RVA = "0x1162FA0", Offset = "0x1162FA0", VA = "0x1162FA0")]
		public static float linearToDecibels(float linear)
		{
			return default(float);
		}

		[Token(Token = "0x60001CB")]
		[Address(RVA = "0x1163018", Offset = "0x1163018", VA = "0x1163018")]
		public static long msToSamps(float ms, float sampleRate)
		{
			return default(long);
		}

		[Token(Token = "0x60001CC")]
		[Address(RVA = "0x1163048", Offset = "0x1163048", VA = "0x1163048")]
		public static float sampsToMs(long samples, float sampleRate)
		{
			return default(float);
		}

		[Token(Token = "0x60001CD")]
		[Address(RVA = "0x1163070", Offset = "0x1163070", VA = "0x1163070")]
		public static bool isAmbisonic(ChannelMap map)
		{
			return default(bool);
		}

		[Token(Token = "0x60001CE")]
		[Address(RVA = "0x1163090", Offset = "0x1163090", VA = "0x1163090")]
		public static double usToMs(uint us)
		{
			return default(double);
		}

		[Token(Token = "0x60001CF")]
		[Address(RVA = "0x11630A4", Offset = "0x11630A4", VA = "0x11630A4")]
		public static uint msToUs(double ms)
		{
			return default(uint);
		}

		[Token(Token = "0x60001D0")]
		[Address(RVA = "0x11630C4", Offset = "0x11630C4", VA = "0x11630C4")]
		public static float getDistanceAttenuationGain(float distance, float minDistance, float maxDistance, float factor, bool maxMute, AttenuationMode mode, AnimationCurve customAtenuationCurve)
		{
			return default(float);
		}

		[Token(Token = "0x60001D1")]
		[Address(RVA = "0x11632B4", Offset = "0x11632B4", VA = "0x11632B4")]
		public Utils()
		{
		}
	}
	[Token(Token = "0x2000056")]
	public enum AmbisonicRenderer
	{
		[Token(Token = "0x400016B")]
		VIRTUAL_SPEAKER,
		[Token(Token = "0x400016C")]
		AMBISONIC
	}
	[Token(Token = "0x2000057")]
	public enum AssetAccessMode
	{
		[Token(Token = "0x400016E")]
		FILE,
		[Token(Token = "0x400016F")]
		MEMORY,
		[Token(Token = "0x4000170")]
		DECODED_MEMORY,
		[Token(Token = "0x4000171")]
		INVALID
	}
	[Token(Token = "0x2000058")]
	public class AssetDescriptor : IDisposable
	{
		[Token(Token = "0x4000172")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private HandleRef swigCPtr;

		[Token(Token = "0x4000173")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		protected bool swigCMemOwn;

		[Token(Token = "0x17000042")]
		public uint offsetInBytes
		{
			[Token(Token = "0x60001D9")]
			[Address(RVA = "0xD31F38", Offset = "0xD31F38", VA = "0xD31F38")]
			get
			{
				return default(uint);
			}
			[Token(Token = "0x60001D8")]
			[Address(RVA = "0xD31E2C", Offset = "0xD31E2C", VA = "0xD31E2C")]
			set
			{
			}
		}

		[Token(Token = "0x17000043")]
		public uint lengthInBytes
		{
			[Token(Token = "0x60001DB")]
			[Address(RVA = "0xD32130", Offset = "0xD32130", VA = "0xD32130")]
			get
			{
				return default(uint);
			}
			[Token(Token = "0x60001DA")]
			[Address(RVA = "0xD32024", Offset = "0xD32024", VA = "0xD32024")]
			set
			{
			}
		}

		[Token(Token = "0x60001D3")]
		[Address(RVA = "0xD31AB8", Offset = "0xD31AB8", VA = "0xD31AB8")]
		internal AssetDescriptor(IntPtr cPtr, bool cMemoryOwn)
		{
		}

		[Token(Token = "0x60001D4")]
		[Address(RVA = "0xD31B1C", Offset = "0xD31B1C", VA = "0xD31B1C")]
		public static HandleRef getCPtr(AssetDescriptor obj)
		{
			return default(HandleRef);
		}

		[Token(Token = "0x60001D5")]
		[Address(RVA = "0xD31B90", Offset = "0xD31B90", VA = "0xD31B90", Slot = "1")]
		~AssetDescriptor()
		{
		}

		[Token(Token = "0x60001D6")]
		[Address(RVA = "0xD31C04", Offset = "0xD31C04", VA = "0xD31C04", Slot = "4")]
		public void Dispose()
		{
		}

		[Token(Token = "0x60001D7")]
		[Address(RVA = "0xD31C80", Offset = "0xD31C80", VA = "0xD31C80", Slot = "5")]
		protected virtual void Dispose(bool disposing)
		{
		}

		[Token(Token = "0x60001DC")]
		[Address(RVA = "0xD3221C", Offset = "0xD3221C", VA = "0xD3221C")]
		public AssetDescriptor()
		{
		}

		[Token(Token = "0x60001DD")]
		[Address(RVA = "0xD32300", Offset = "0xD32300", VA = "0xD32300")]
		public AssetDescriptor(uint offset, uint length)
		{
		}
	}
	[Token(Token = "0x2000059")]
	public enum AttenuationMode
	{
		[Token(Token = "0x4000175")]
		LOGARITHMIC,
		[Token(Token = "0x4000176")]
		LINEAR,
		[Token(Token = "0x4000177")]
		CUSTOM
	}
	[Token(Token = "0x200005A")]
	public class AttenuationProps : IDisposable
	{
		[Token(Token = "0x4000178")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private HandleRef swigCPtr;

		[Token(Token = "0x4000179")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		protected bool swigCMemOwn;

		[Token(Token = "0x17000044")]
		public float minimumDistance
		{
			[Token(Token = "0x60001E4")]
			[Address(RVA = "0xD32898", Offset = "0xD32898", VA = "0xD32898")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60001E3")]
			[Address(RVA = "0xD3278C", Offset = "0xD3278C", VA = "0xD3278C")]
			set
			{
			}
		}

		[Token(Token = "0x17000045")]
		public float maximumDistance
		{
			[Token(Token = "0x60001E6")]
			[Address(RVA = "0xD32A90", Offset = "0xD32A90", VA = "0xD32A90")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60001E5")]
			[Address(RVA = "0xD32984", Offset = "0xD32984", VA = "0xD32984")]
			set
			{
			}
		}

		[Token(Token = "0x17000046")]
		public float factor
		{
			[Token(Token = "0x60001E8")]
			[Address(RVA = "0xD32C88", Offset = "0xD32C88", VA = "0xD32C88")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60001E7")]
			[Address(RVA = "0xD32B7C", Offset = "0xD32B7C", VA = "0xD32B7C")]
			set
			{
			}
		}

		[Token(Token = "0x17000047")]
		public bool maxDistanceMute
		{
			[Token(Token = "0x60001EA")]
			[Address(RVA = "0xD32E80", Offset = "0xD32E80", VA = "0xD32E80")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60001E9")]
			[Address(RVA = "0xD32D74", Offset = "0xD32D74", VA = "0xD32D74")]
			set
			{
			}
		}

		[Token(Token = "0x60001DE")]
		[Address(RVA = "0xD32418", Offset = "0xD32418", VA = "0xD32418")]
		internal AttenuationProps(IntPtr cPtr, bool cMemoryOwn)
		{
		}

		[Token(Token = "0x60001DF")]
		[Address(RVA = "0xD3247C", Offset = "0xD3247C", VA = "0xD3247C")]
		public static HandleRef getCPtr(AttenuationProps obj)
		{
			return default(HandleRef);
		}

		[Token(Token = "0x60001E0")]
		[Address(RVA = "0xD324F0", Offset = "0xD324F0", VA = "0xD324F0", Slot = "1")]
		~AttenuationProps()
		{
		}

		[Token(Token = "0x60001E1")]
		[Address(RVA = "0xD32564", Offset = "0xD32564", VA = "0xD32564", Slot = "4")]
		public void Dispose()
		{
		}

		[Token(Token = "0x60001E2")]
		[Address(RVA = "0xD325E0", Offset = "0xD325E0", VA = "0xD325E0", Slot = "5")]
		protected virtual void Dispose(bool disposing)
		{
		}

		[Token(Token = "0x60001EB")]
		[Address(RVA = "0xD32F74", Offset = "0xD32F74", VA = "0xD32F74")]
		public AttenuationProps()
		{
		}

		[Token(Token = "0x60001EC")]
		[Address(RVA = "0xD33058", Offset = "0xD33058", VA = "0xD33058")]
		public AttenuationProps(float minDistanceValue, float maxDistanceValue, float factorValue, bool maxDistMute)
		{
		}

		[Token(Token = "0x60001ED")]
		[Address(RVA = "0xD331A8", Offset = "0xD331A8", VA = "0xD331A8")]
		public AttenuationProps(float minDistanceValue, float maxDistanceValue, float factorValue)
		{
		}
	}
	[Token(Token = "0x200005B")]
	public class Audio360CSharp
	{
		[Token(Token = "0x17000048")]
		public static AudioSettings AudioSettings_default
		{
			[Token(Token = "0x60001EF")]
			[Address(RVA = "0xD333C4", Offset = "0xD333C4", VA = "0xD333C4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000049")]
		public static NetworkSettings NetworkSettings_default
		{
			[Token(Token = "0x60001F0")]
			[Address(RVA = "0xD334D8", Offset = "0xD334D8", VA = "0xD334D8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700004A")]
		public static MemorySettings MemorySettings_default
		{
			[Token(Token = "0x60001F1")]
			[Address(RVA = "0xD335EC", Offset = "0xD335EC", VA = "0xD335EC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700004B")]
		public static EngineInitSettings EngineInitSettings_default
		{
			[Token(Token = "0x60001F2")]
			[Address(RVA = "0xD33700", Offset = "0xD33700", VA = "0xD33700")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700004C")]
		public static uint kMaxStrSize
		{
			[Token(Token = "0x60001F3")]
			[Address(RVA = "0xD33814", Offset = "0xD33814", VA = "0xD33814")]
			get
			{
				return default(uint);
			}
		}

		[Token(Token = "0x1700004D")]
		public static uint IOSTREAM_OPERATION_FAIL
		{
			[Token(Token = "0x60001F4")]
			[Address(RVA = "0xD338E4", Offset = "0xD338E4", VA = "0xD338E4")]
			get
			{
				return default(uint);
			}
		}

		[Token(Token = "0x1700004E")]
		public static uint uninitializedHandle
		{
			[Token(Token = "0x60001F5")]
			[Address(RVA = "0xD339B4", Offset = "0xD339B4", VA = "0xD339B4")]
			get
			{
				return default(uint);
			}
		}

		[Token(Token = "0x1700004F")]
		public static AudioAssetHandle InvalidAudioAssetHandle
		{
			[Token(Token = "0x60001F6")]
			[Address(RVA = "0xD33A84", Offset = "0xD33A84", VA = "0xD33A84")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000050")]
		public static ulong InvalidVoiceHandle
		{
			[Token(Token = "0x60001F7")]
			[Address(RVA = "0xD33B98", Offset = "0xD33B98", VA = "0xD33B98")]
			get
			{
				return default(ulong);
			}
		}

		[Token(Token = "0x17000051")]
		public static uint kMaxTotalVoices
		{
			[Token(Token = "0x60001F8")]
			[Address(RVA = "0xD33C68", Offset = "0xD33C68", VA = "0xD33C68")]
			get
			{
				return default(uint);
			}
		}

		[Token(Token = "0x60001EE")]
		[Address(RVA = "0xD332E0", Offset = "0xD332E0", VA = "0xD332E0")]
		public static int getNumChannelsForMap(ChannelMap map)
		{
			return default(int);
		}

		[Token(Token = "0x60001F9")]
		[Address(RVA = "0xD33D38", Offset = "0xD33D38", VA = "0xD33D38")]
		public Audio360CSharp()
		{
		}
	}
	[Token(Token = "0x200005C")]
	internal class Audio360CSharpPINVOKE
	{
		[Token(Token = "0x200009E")]
		protected class SWIGExceptionHelper
		{
			[Token(Token = "0x20000A6")]
			public delegate void ExceptionDelegate(string message);

			[Token(Token = "0x20000A7")]
			public delegate void ExceptionArgumentDelegate(string message, string paramName);

			[Token(Token = "0x4000296")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static ExceptionDelegate applicationDelegate;

			[Token(Token = "0x4000297")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private static ExceptionDelegate arithmeticDelegate;

			[Token(Token = "0x4000298")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private static ExceptionDelegate divideByZeroDelegate;

			[Token(Token = "0x4000299")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private static ExceptionDelegate indexOutOfRangeDelegate;

			[Token(Token = "0x400029A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private static ExceptionDelegate invalidCastDelegate;

			[Token(Token = "0x400029B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private static ExceptionDelegate invalidOperationDelegate;

			[Token(Token = "0x400029C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private static ExceptionDelegate ioDelegate;

			[Token(Token = "0x400029D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private static ExceptionDelegate nullReferenceDelegate;

			[Token(Token = "0x400029E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private static ExceptionDelegate outOfMemoryDelegate;

			[Token(Token = "0x400029F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private static ExceptionDelegate overflowDelegate;

			[Token(Token = "0x40002A0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			private static ExceptionDelegate systemDelegate;

			[Token(Token = "0x40002A1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private static ExceptionArgumentDelegate argumentDelegate;

			[Token(Token = "0x40002A2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private static ExceptionArgumentDelegate argumentNullDelegate;

			[Token(Token = "0x40002A3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			private static ExceptionArgumentDelegate argumentOutOfRangeDelegate;

			[PreserveSig]
			[Token(Token = "0x60006BE")]
			[Address(RVA = "0xEC4260", Offset = "0xEC4260", VA = "0xEC4260")]
			public static extern void SWIGRegisterExceptionCallbacks_Audio360CSharp(ExceptionDelegate applicationDelegate, ExceptionDelegate arithmeticDelegate, ExceptionDelegate divideByZeroDelegate, ExceptionDelegate indexOutOfRangeDelegate, ExceptionDelegate invalidCastDelegate, ExceptionDelegate invalidOperationDelegate, ExceptionDelegate ioDelegate, ExceptionDelegate nullReferenceDelegate, ExceptionDelegate outOfMemoryDelegate, ExceptionDelegate overflowDelegate, ExceptionDelegate systemExceptionDelegate);

			[PreserveSig]
			[Token(Token = "0x60006BF")]
			[Address(RVA = "0xEC43D4", Offset = "0xEC43D4", VA = "0xEC43D4")]
			public static extern void SWIGRegisterExceptionCallbacksArgument_Audio360CSharp(ExceptionArgumentDelegate argumentDelegate, ExceptionArgumentDelegate argumentNullDelegate, ExceptionArgumentDelegate argumentOutOfRangeDelegate);

			[Token(Token = "0x60006C0")]
			[Address(RVA = "0xEC3948", Offset = "0xEC3948", VA = "0xEC3948")]
			[AttributeAttribute(Name = "MonoPInvokeCallbackAttribute", RVA = "0x621430", Offset = "0x621430")]
			private static void SetPendingApplicationException(string message)
			{
			}

			[Token(Token = "0x60006C1")]
			[Address(RVA = "0xEC39E4", Offset = "0xEC39E4", VA = "0xEC39E4")]
			[AttributeAttribute(Name = "MonoPInvokeCallbackAttribute", RVA = "0x621494", Offset = "0x621494")]
			private static void SetPendingArithmeticException(string message)
			{
			}

			[Token(Token = "0x60006C2")]
			[Address(RVA = "0xEC3A80", Offset = "0xEC3A80", VA = "0xEC3A80")]
			[AttributeAttribute(Name = "MonoPInvokeCallbackAttribute", RVA = "0x6214F8", Offset = "0x6214F8")]
			private static void SetPendingDivideByZeroException(string message)
			{
			}

			[Token(Token = "0x60006C3")]
			[Address(RVA = "0xEC3B1C", Offset = "0xEC3B1C", VA = "0xEC3B1C")]
			[AttributeAttribute(Name = "MonoPInvokeCallbackAttribute", RVA = "0x62155C", Offset = "0x62155C")]
			private static void SetPendingIndexOutOfRangeException(string message)
			{
			}

			[Token(Token = "0x60006C4")]
			[Address(RVA = "0xEC3BB8", Offset = "0xEC3BB8", VA = "0xEC3BB8")]
			[AttributeAttribute(Name = "MonoPInvokeCallbackAttribute", RVA = "0x6215C0", Offset = "0x6215C0")]
			private static void SetPendingInvalidCastException(string message)
			{
			}

			[Token(Token = "0x60006C5")]
			[Address(RVA = "0xEC3C54", Offset = "0xEC3C54", VA = "0xEC3C54")]
			[AttributeAttribute(Name = "MonoPInvokeCallbackAttribute", RVA = "0x621624", Offset = "0x621624")]
			private static void SetPendingInvalidOperationException(string message)
			{
			}

			[Token(Token = "0x60006C6")]
			[Address(RVA = "0xEC3CF0", Offset = "0xEC3CF0", VA = "0xEC3CF0")]
			[AttributeAttribute(Name = "MonoPInvokeCallbackAttribute", RVA = "0x621688", Offset = "0x621688")]
			private static void SetPendingIOException(string message)
			{
			}

			[Token(Token = "0x60006C7")]
			[Address(RVA = "0xEC3D8C", Offset = "0xEC3D8C", VA = "0xEC3D8C")]
			[AttributeAttribute(Name = "MonoPInvokeCallbackAttribute", RVA = "0x6216EC", Offset = "0x6216EC")]
			private static void SetPendingNullReferenceException(string message)
			{
			}

			[Token(Token = "0x60006C8")]
			[Address(RVA = "0xEC3E28", Offset = "0xEC3E28", VA = "0xEC3E28")]
			[AttributeAttribute(Name = "MonoPInvokeCallbackAttribute", RVA = "0x621750", Offset = "0x621750")]
			private static void SetPendingOutOfMemoryException(string message)
			{
			}

			[Token(Token = "0x60006C9")]
			[Address(RVA = "0xEC3EC4", Offset = "0xEC3EC4", VA = "0xEC3EC4")]
			[AttributeAttribute(Name = "MonoPInvokeCallbackAttribute", RVA = "0x6217B4", Offset = "0x6217B4")]
			private static void SetPendingOverflowException(string message)
			{
			}

			[Token(Token = "0x60006CA")]
			[Address(RVA = "0xEC3F60", Offset = "0xEC3F60", VA = "0xEC3F60")]
			[AttributeAttribute(Name = "MonoPInvokeCallbackAttribute", RVA = "0x621818", Offset = "0x621818")]
			private static void SetPendingSystemException(string message)
			{
			}

			[Token(Token = "0x60006CB")]
			[Address(RVA = "0xEC3FFC", Offset = "0xEC3FFC", VA = "0xEC3FFC")]
			[AttributeAttribute(Name = "MonoPInvokeCallbackAttribute", RVA = "0x62187C", Offset = "0x62187C")]
			private static void SetPendingArgumentException(string message, string paramName)
			{
			}

			[Token(Token = "0x60006CC")]
			[Address(RVA = "0xEC40A0", Offset = "0xEC40A0", VA = "0xEC40A0")]
			[AttributeAttribute(Name = "MonoPInvokeCallbackAttribute", RVA = "0x6218E0", Offset = "0x6218E0")]
			private static void SetPendingArgumentNullException(string message, string paramName)
			{
			}

			[Token(Token = "0x60006CD")]
			[Address(RVA = "0xEC4180", Offset = "0xEC4180", VA = "0xEC4180")]
			[AttributeAttribute(Name = "MonoPInvokeCallbackAttribute", RVA = "0x621944", Offset = "0x621944")]
			private static void SetPendingArgumentOutOfRangeException(string message, string paramName)
			{
			}

			[Token(Token = "0x60006CE")]
			[Address(RVA = "0xEC47D0", Offset = "0xEC47D0", VA = "0xEC47D0")]
			static SWIGExceptionHelper()
			{
			}

			[Token(Token = "0x60006CF")]
			[Address(RVA = "0xEC4AEC", Offset = "0xEC4AEC", VA = "0xEC4AEC")]
			public SWIGExceptionHelper()
			{
			}
		}

		[Token(Token = "0x200009F")]
		public class SWIGPendingException
		{
			[Token(Token = "0x40002A4")]
			[ThreadStatic]
			private static Exception pendingException;

			[Token(Token = "0x40002A5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static int numExceptionsPending;

			[Token(Token = "0x40002A6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private static object exceptionsLock;

			[Token(Token = "0x1700008D")]
			public static bool Pending
			{
				[Token(Token = "0x60006D0")]
				[Address(RVA = "0xEC52DC", Offset = "0xEC52DC", VA = "0xEC52DC")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x60006D1")]
			[Address(RVA = "0xEC45F4", Offset = "0xEC45F4", VA = "0xEC45F4")]
			public static void Set(Exception e)
			{
			}

			[Token(Token = "0x60006D2")]
			[Address(RVA = "0xEC448C", Offset = "0xEC448C", VA = "0xEC448C")]
			public static Exception Retrieve()
			{
				return null;
			}

			[Token(Token = "0x60006D3")]
			[Address(RVA = "0xEC537C", Offset = "0xEC537C", VA = "0xEC537C")]
			static SWIGPendingException()
			{
			}

			[Token(Token = "0x60006D4")]
			[Address(RVA = "0xEC53E8", Offset = "0xEC53E8", VA = "0xEC53E8")]
			public SWIGPendingException()
			{
			}
		}

		[Token(Token = "0x20000A0")]
		protected class SWIGStringHelper
		{
			[Token(Token = "0x20000A8")]
			public delegate string SWIGStringDelegate(string message);

			[Token(Token = "0x40002A7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static SWIGStringDelegate stringDelegate;

			[PreserveSig]
			[Token(Token = "0x60006D5")]
			[Address(RVA = "0xEC53F4", Offset = "0xEC53F4", VA = "0xEC53F4")]
			public static extern void SWIGRegisterStringCallback_Audio360CSharp(SWIGStringDelegate stringDelegate);

			[Token(Token = "0x60006D6")]
			[Address(RVA = "0xEC53F0", Offset = "0xEC53F0", VA = "0xEC53F0")]
			[AttributeAttribute(Name = "MonoPInvokeCallbackAttribute", RVA = "0x6219A8", Offset = "0x6219A8")]
			private static string CreateString(string cString)
			{
				return null;
			}

			[Token(Token = "0x60006D7")]
			[Address(RVA = "0xEC5478", Offset = "0xEC5478", VA = "0xEC5478")]
			static SWIGStringHelper()
			{
			}

			[Token(Token = "0x60006D8")]
			[Address(RVA = "0xEC550C", Offset = "0xEC550C", VA = "0xEC550C")]
			public SWIGStringHelper()
			{
			}
		}

		[Token(Token = "0x20000A1")]
		protected class SWIGWStringHelper
		{
			[Token(Token = "0x20000A9")]
			public delegate string SWIGWStringDelegate(IntPtr message);

			[Token(Token = "0x40002A8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static SWIGWStringDelegate wstringDelegate;

			[PreserveSig]
			[Token(Token = "0x60006D9")]
			[Address(RVA = "0xEC5948", Offset = "0xEC5948", VA = "0xEC5948")]
			public static extern void SWIGRegisterWStringCallback_Audio360CSharp(SWIGWStringDelegate wstringDelegate);

			[Token(Token = "0x60006DA")]
			[Address(RVA = "0xEC58E0", Offset = "0xEC58E0", VA = "0xEC58E0")]
			[AttributeAttribute(Name = "MonoPInvokeCallbackAttribute", RVA = "0x621A0C", Offset = "0x621A0C")]
			private static string CreateWString(IntPtr cString)
			{
				return null;
			}

			[Token(Token = "0x60006DB")]
			[Address(RVA = "0xEC59CC", Offset = "0xEC59CC", VA = "0xEC59CC")]
			static SWIGWStringHelper()
			{
			}

			[Token(Token = "0x60006DC")]
			[Address(RVA = "0xEC5A60", Offset = "0xEC5A60", VA = "0xEC5A60")]
			public SWIGWStringHelper()
			{
			}
		}

		[Token(Token = "0x400017A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		protected static SWIGExceptionHelper swigExceptionHelper;

		[Token(Token = "0x400017B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		protected static SWIGStringHelper swigStringHelper;

		[Token(Token = "0x400017C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		protected static SWIGWStringHelper swigWStringHelper;

		[Token(Token = "0x60001FA")]
		[Address(RVA = "0xD33D40", Offset = "0xD33D40", VA = "0xD33D40")]
		static Audio360CSharpPINVOKE()
		{
		}

		[PreserveSig]
		[Token(Token = "0x60001FB")]
		[Address(RVA = "0xD33DFC", Offset = "0xD33DFC", VA = "0xD33DFC")]
		public static extern void TBVector_x_set(HandleRef jarg1, float jarg2);

		[PreserveSig]
		[Token(Token = "0x60001FC")]
		[Address(RVA = "0xD33E8C", Offset = "0xD33E8C", VA = "0xD33E8C")]
		public static extern float TBVector_x_get(HandleRef jarg1);

		[PreserveSig]
		[Token(Token = "0x60001FD")]
		[Address(RVA = "0xD33F0C", Offset = "0xD33F0C", VA = "0xD33F0C")]
		public static extern void TBVector_y_set(HandleRef jarg1, float jarg2);

		[PreserveSig]
		[Token(Token = "0x60001FE")]
		[Address(RVA = "0xD33F9C", Offset = "0xD33F9C", VA = "0xD33F9C")]
		public static extern float TBVector_y_get(HandleRef jarg1);

		[PreserveSig]
		[Token(Token = "0x60001FF")]
		[Address(RVA = "0xD3401C", Offset = "0xD3401C", VA = "0xD3401C")]
		public static extern void TBVector_z_set(HandleRef jarg1, float jarg2);

		[PreserveSig]
		[Token(Token = "0x6000200")]
		[Address(RVA = "0xD340AC", Offset = "0xD340AC", VA = "0xD340AC")]
		public static extern float TBVector_z_get(HandleRef jarg1);

		[PreserveSig]
		[Token(Token = "0x6000201")]
		[Address(RVA = "0xD3412C", Offset = "0xD3412C", VA = "0xD3412C")]
		public static extern IntPtr new_TBVector__SWIG_0();

		[PreserveSig]
		[Token(Token = "0x6000202")]
		[Address(RVA = "0xD341A0", Offset = "0xD341A0", VA = "0xD341A0")]
		public static extern IntPtr new_TBVector__SWIG_1(float jarg1, float jarg2, float jarg3);

		[PreserveSig]
		[Token(Token = "0x6000203")]
		[Address(RVA = "0xD34240", Offset = "0xD34240", VA = "0xD34240")]
		public static extern IntPtr new_TBVector__SWIG_2(float jarg1);

		[PreserveSig]
		[Token(Token = "0x6000204")]
		[Address(RVA = "0xD342C8", Offset = "0xD342C8", VA = "0xD342C8")]
		public static extern IntPtr TBVector_CrossProduct(HandleRef jarg1, HandleRef jarg2);

		[PreserveSig]
		[Token(Token = "0x6000205")]
		[Address(RVA = "0xD34358", Offset = "0xD34358", VA = "0xD34358")]
		public static extern IntPtr TBVector_zero();

		[PreserveSig]
		[Token(Token = "0x6000206")]
		[Address(RVA = "0xD343CC", Offset = "0xD343CC", VA = "0xD343CC")]
		public static extern IntPtr TBVector_forward();

		[PreserveSig]
		[Token(Token = "0x6000207")]
		[Address(RVA = "0xD34440", Offset = "0xD34440", VA = "0xD34440")]
		public static extern IntPtr TBVector_up();

		[PreserveSig]
		[Token(Token = "0x6000208")]
		[Address(RVA = "0xD344B4", Offset = "0xD344B4", VA = "0xD344B4")]
		public static extern float TBVector_DotProduct(HandleRef jarg1, HandleRef jarg2);

		[PreserveSig]
		[Token(Token = "0x6000209")]
		[Address(RVA = "0xD34544", Offset = "0xD34544", VA = "0xD34544")]
		public static extern float TBVector_Angle(HandleRef jarg1, HandleRef jarg2);

		[PreserveSig]
		[Token(Token = "0x600020A")]
		[Address(RVA = "0xD345D4", Offset = "0xD345D4", VA = "0xD345D4")]
		public static extern float TBVector_magnitude(HandleRef jarg1);

		[PreserveSig]
		[Token(Token = "0x600020B")]
		[Address(RVA = "0xD34654", Offset = "0xD34654", VA = "0xD34654")]
		public static extern void TBVector_clampMagnitude(HandleRef jarg1, float jarg2);

		[PreserveSig]
		[Token(Token = "0x600020C")]
		[Address(RVA = "0xD346E4", Offset = "0xD346E4", VA = "0xD346E4")]
		public static extern float TBVector_magSquared(HandleRef jarg1);

		[PreserveSig]
		[Token(Token = "0x600020D")]
		[Address(RVA = "0xD34764", Offset = "0xD34764", VA = "0xD34764")]
		public static extern void TBVector_normalise(HandleRef jarg1);

		[PreserveSig]
		[Token(Token = "0x600020E")]
		[Address(RVA = "0xD347E4", Offset = "0xD347E4", VA = "0xD347E4")]
		public static extern void TBVector_set(HandleRef jarg1, float jarg2, float jarg3, float jarg4);

		[PreserveSig]
		[Token(Token = "0x600020F")]
		[Address(RVA = "0xD3488C", Offset = "0xD3488C", VA = "0xD3488C")]
		public static extern void TBVector_abs__SWIG_0(HandleRef jarg1);

		[PreserveSig]
		[Token(Token = "0x6000210")]
		[Address(RVA = "0xD3490C", Offset = "0xD3490C", VA = "0xD3490C")]
		public static extern IntPtr TBVector_projectOntoPlane(HandleRef jarg1, HandleRef jarg2);

		[PreserveSig]
		[Token(Token = "0x6000211")]
		[Address(RVA = "0xD3499C", Offset = "0xD3499C", VA = "0xD3499C")]
		public static extern void TBVector_rotateByVectors(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3);

		[PreserveSig]
		[Token(Token = "0x6000212")]
		[Address(RVA = "0xD34A34", Offset = "0xD34A34", VA = "0xD34A34")]
		public static extern float TBVector_min_val(HandleRef jarg1);

		[PreserveSig]
		[Token(Token = "0x6000213")]
		[Address(RVA = "0xD34AB4", Offset = "0xD34AB4", VA = "0xD34AB4")]
		public static extern float TBVector_max_val(HandleRef jarg1);

		[PreserveSig]
		[Token(Token = "0x6000214")]
		[Address(RVA = "0xD34B34", Offset = "0xD34B34", VA = "0xD34B34")]
		public static extern string TBVector_toString__SWIG_0(HandleRef jarg1, int jarg2);

		[PreserveSig]
		[Token(Token = "0x6000215")]
		[Address(RVA = "0xD34BDC", Offset = "0xD34BDC", VA = "0xD34BDC")]
		public static extern string TBVector_toString__SWIG_1(HandleRef jarg1);

		[PreserveSig]
		[Token(Token = "0x6000216")]
		[Address(RVA = "0xD34C74", Offset = "0xD34C74", VA = "0xD34C74")]
		public static extern IntPtr TBVector_getVectorFromAziEle(float jarg1, float jarg2);

		[PreserveSig]
		[Token(Token = "0x6000217")]
		[Address(RVA = "0xD34D04", Offset = "0xD34D04", VA = "0xD34D04")]
		public static extern IntPtr TBVector_getVectorFromAziEleDist(float jarg1, float jarg2, float jarg3);

		[PreserveSig]
		[Token(Token = "0x6000218")]
		[Address(RVA = "0xD34DA4", Offset = "0xD34DA4", VA = "0xD34DA4")]
		public static extern IntPtr TBVector_getVectorFromEuler(HandleRef jarg1);

		[PreserveSig]
		[Token(Token = "0x6000219")]
		[Address(RVA = "0xD34E24", Offset = "0xD34E24", VA = "0xD34E24")]
		public static extern void delete_TBVector(HandleRef jarg1);

		[PreserveSig]
		[Token(Token = "0x600021A")]
		[Address(RVA = "0xD34EA4", Offset = "0xD34EA4", VA = "0xD34EA4")]
		public static extern void TBQuat_x_set(HandleRef jarg1, float jarg2);

		[PreserveSig]
		[Token(Token = "0x600021B")]
		[Address(RVA = "0xD34F34", Offset = "0xD34F34", VA = "0xD34F34")]
		public static extern float TBQuat_x_get(HandleRef jarg1);

		[PreserveSig]
		[Token(Token = "0x600021C")]
		[Address(RVA = "0xD34FB4", Offset = "0xD34FB4", VA = "0xD34FB4")]
		public static extern void TBQuat_y_set(HandleRef jarg1, float jarg2);

		[PreserveSig]
		[Token(Token = "0x600021D")]
		[Address(RVA = "0xD35044", Offset = "0xD35044", VA = "0xD35044")]
		public static extern float TBQuat_y_get(HandleRef jarg1);

		[PreserveSig]
		[Token(Token = "0x600021E")]
		[Address(RVA = "0xD350C4", Offset = "0xD350C4", VA = "0xD350C4")]
		public static extern void TBQuat_z_set(HandleRef jarg1, float jarg2);

		[PreserveSig]
		[Token(Token = "0x600021F")]
		[Address(RVA = "0xD35154", Offset = "0xD35154", VA = "0xD35154")]
		public static extern float TBQuat_z_get(HandleRef jarg1);

		[PreserveSig]
		[Token(Token = "0x6000220")]
		[Address(RVA = "0xD351D4", Offset = "0xD351D4", VA = "0xD351D4")]
		public static extern void TBQuat_w_set(HandleRef jarg1, float jarg2);

		[PreserveSig]
		[Token(Token = "0x6000221")]
		[Address(RVA = "0xD35264", Offset = "0xD35264", VA = "0xD35264")]
		public static extern float TBQuat_w_get(HandleRef jarg1);

		[PreserveSig]
		[Token(Token = "0x6000222")]
		[Address(RVA = "0xD352E4", Offset = "0xD352E4", VA = "0xD352E4")]
		public static extern IntPtr new_TBQuat__SWIG_0();

		[PreserveSig]
		[Token(Token = "0x6000223")]
		[Address(RVA = "0xD35358", Offset = "0xD35358", VA = "0xD35358")]
		public static extern IntPtr new_TBQuat__SWIG_1(float jarg1, float jarg2, float jarg3, float jarg4);

		[PreserveSig]
		[Token(Token = "0x6000224")]
		[Address(RVA = "0xD35400", Offset = "0xD35400", VA = "0xD35400")]
		public static extern IntPtr new_TBQuat__SWIG_2(HandleRef jarg1);

		[PreserveSig]
		[Token(Token = "0x6000225")]
		[Address(RVA = "0xD35480", Offset = "0xD35480", VA = "0xD35480")]
		public static extern string TBQuat_toString__SWIG_0(HandleRef jarg1, int jarg2);

		[PreserveSig]
		[Token(Token = "0x6000226")]
		[Address(RVA = "0xD35528", Offset = "0xD35528", VA = "0xD35528")]
		public static extern string TBQuat_toString__SWIG_1(HandleRef jarg1);

		[PreserveSig]
		[Token(Token = "0x6000227")]
		[Address(RVA = "0xD355C0", Offset = "0xD355C0", VA = "0xD355C0")]
		public static extern IntPtr TBQuat_invert(HandleRef jarg1);

		[PreserveSig]
		[Token(Token = "0x6000228")]
		[Address(RVA = "0xD35640", Offset = "0xD35640", VA = "0xD35640")]
		public static extern IntPtr TBQuat_convertFromOpenGLQuaternion(float jarg1, float jarg2, float jarg3, float jarg4);

		[PreserveSig]
		[Token(Token = "0x6000229")]
		[Address(RVA = "0xD356E8", Offset = "0xD356E8", VA = "0xD356E8")]
		public static extern IntPtr TBQuat_getQuatFromEulerAngles(float jarg1, float jarg2, float jarg3);

		[PreserveSig]
		[Token(Token = "0x600022A")]
		[Address(RVA = "0xD35788", Offset = "0xD35788", VA = "0xD35788")]
		public static extern IntPtr TBQuat_getEulerAnglesFromQuat(HandleRef jarg1);

		[PreserveSig]
		[Token(Token = "0x600022B")]
		[Address(RVA = "0xD35808", Offset = "0xD35808", VA = "0xD35808")]
		public static extern IntPtr TBQuat_quatProductUnNormalised(HandleRef jarg1, HandleRef jarg2);

		[PreserveSig]
		[Token(Token = "0x600022C")]
		[Address(RVA = "0xD35898", Offset = "0xD35898", VA = "0xD35898")]
		public static extern IntPtr TBQuat_rotateVectorByQuat(HandleRef jarg1, HandleRef jarg2);

		[PreserveSig]
		[Token(Token = "0x600022D")]
		[Address(RVA = "0xD35928", Offset = "0xD35928", VA = "0xD35928")]
		public static extern IntPtr TBQuat_antiRotateVectorByQuat(HandleRef jarg1, HandleRef jarg2);

		[PreserveSig]
		[Token(Token = "0x600022E")]
		[Address(RVA = "0xD359B8", Offset = "0xD359B8", VA = "0xD359B8")]
		public static extern IntPtr TBQuat_getFromToQuatRotation(HandleRef jarg1, HandleRef jarg2);

		[PreserveSig]
		[Token(Token = "0x600022F")]
		[Address(RVA = "0xD35A48", Offset = "0xD35A48", VA = "0xD35A48")]
		public static extern IntPtr TBQuat_getForwardFromQuat(HandleRef jarg1);

		[PreserveSig]
		[Token(Token = "0x6000230")]
		[Address(RVA = "0xD35AC8", Offset = "0xD35AC8", VA = "0xD35AC8")]
		public static extern IntPtr TBQuat_getUpFromQuat(HandleRef jarg1);

		[PreserveSig]
		[Token(Token = "0x6000231")]
		[Address(RVA = "0xD35B48", Offset = "0xD35B48", VA = "0xD35B48")]
		public static extern IntPtr TBQuat_getRightFromQuat(HandleRef jarg1);

		[PreserveSig]
		[Token(Token = "0x6000232")]
		[Address(RVA = "0xD35BC8", Offset = "0xD35BC8", VA = "0xD35BC8")]
		public static extern IntPtr TBQuat_getQuatFromForwardAndUpVectors(HandleRef jarg1, HandleRef jarg2);

		[PreserveSig]
		[Token(Token = "0x6000233")]
		[Address(RVA = "0xD35C58", Offset = "0xD35C58", VA = "0xD35C58")]
		public static extern IntPtr TBQuat_getQuatFromMatrix(float jarg1, float jarg2, float jarg3, float jarg4, float jarg5, float jarg6, float jarg7, float jarg8, float jarg9);

		[PreserveSig]
		[Token(Token = "0x6000234")]
		[Address(RVA = "0xD35D38", Offset = "0xD35D38", VA = "0xD35D38")]
		public static extern IntPtr TBQuat_identity();

		[PreserveSig]
		[Token(Token = "0x6000235")]
		[Address(RVA = "0xD35DAC", Offset = "0xD35DAC", VA = "0xD35DAC")]
		public static extern void TBQuat_normalise(HandleRef jarg1);

		[PreserveSig]
		[Token(Token = "0x6000236")]
		[Address(RVA = "0xD35E2C", Offset = "0xD35E2C", VA = "0xD35E2C")]
		public static extern IntPtr TBQuat_generateRandomQuat();

		[PreserveSig]
		[Token(Token = "0x6000237")]
		[Address(RVA = "0xD35EA0", Offset = "0xD35EA0", VA = "0xD35EA0")]
		public static extern void delete_TBQuat(HandleRef jarg1);

		[PreserveSig]
		[Token(Token = "0x6000238")]
		[Address(RVA = "0xD35F20", Offset = "0xD35F20", VA = "0xD35F20")]
		public static extern void EngineStatistics_audioCallbackTimeMicroSec_set(HandleRef jarg1, uint jarg2);

		[PreserveSig]
		[Token(Token = "0x6000239")]
		[Address(RVA = "0xD35FB0", Offset = "0xD35FB0", VA = "0xD35FB0")]
		public static extern uint EngineStatistics_audioCallbackTimeMicroSec_get(HandleRef jarg1);

		[PreserveSig]
		[Token(Token = "0x600023A")]
		[Address(RVA = "0xD36030", Offset = "0xD36030", VA = "0xD36030")]
		public static extern void EngineStatistics_decoderThreadTimeMicroSec_set(HandleRef jarg1, uint jarg2);

		[PreserveSig]
		[Token(Token = "0x600023B")]
		[Address(RVA = "0xD360C0", Offset = "0xD360C0", VA = "0xD360C0")]
		public static extern uint EngineStatistics_decoderThreadTimeMicroSec_get(HandleRef jarg1);

		[PreserveSig]
		[Token(Token = "0x600023C")]
		[Address(RVA = "0xD36140", Offset = "0xD36140", VA = "0xD36140")]
		public static extern void EngineStatistics_numActiveAudioObjects_set(HandleRef jarg1, uint jarg2);

		[PreserveSig]
		[Token(Token = "0x600023D")]
		[Address(RVA = "0xD361D0", Offset = "0xD361D0", VA = "0xD361D0")]
		public static extern uint EngineStatistics_numActiveAudioObjects_get(HandleRef jarg1);

		[PreserveSig]
		[Token(Token = "0x600023E")]
		[Address(RVA = "0xD36250", Offset = "0xD36250", VA = "0xD36250")]
		public static extern void EngineStatistics_numAudioObjectsPlaying_set(HandleRef jarg1, uint jarg2);

		[PreserveSig]
		[Token(Token = "0x600023F")]
		[Address(RVA = "0xD362E0", Offset = "0xD362E0", VA = "0xD362E0")]
		public static extern uint EngineStatistics_numAudioObjectsPlaying_get(HandleRef jarg1);

		[PreserveSig]
		[Token(Token = "0x6000240")]
		[Address(RVA = "0xD36360", Offset = "0xD36360", VA = "0xD36360")]
		public static extern void EngineStatistics_numActiveSpatDecoderFiles_set(HandleRef jarg1, uint jarg2);

		[PreserveSig]
		[Token(Token = "0x6000241")]
		[Address(RVA = "0xD363F0", Offset = "0xD363F0", VA = "0xD363F0")]
		public static extern uint EngineStatistics_numActiveSpatDecoderFiles_get(HandleRef jarg1);

		[PreserveSig]
		[Token(Token = "0x6000242")]
		[Address(RVA = "0xD36470", Offset = "0xD36470", VA = "0xD36470")]
		public static extern void EngineStatistics_numSpatDecoderFilesPlaying_set(HandleRef jarg1, uint jarg2);

		[PreserveSig]
		[Token(Token = "0x6000243")]
		[Address(RVA = "0xD36500", Offset = "0xD36500", VA = "0xD36500")]
		public static extern uint EngineStatistics_numSpatDecoderFilesPlaying_get(HandleRef jarg1);

		[PreserveSig]
		[Token(Token = "0x6000244")]
		[Address(RVA = "0xD36580", Offset = "0xD36580", VA = "0xD36580")]
		public static extern void EngineStatistics_numActiveSpatDecoderQueues_set(HandleRef jarg1, uint jarg2);

		[PreserveSig]
		[Token(Token = "0x6000245")]
		[Address(RVA = "0xD36610", Offset = "0xD36610", VA = "0xD36610")]
		public static extern uint EngineStatistics_numActiveSpatDecoderQueues_get(HandleRef jarg1);

		[PreserveSig]
		[Token(Token = "0x6000246")]
		[Address(RVA = "0xD36690", Offset = "0xD36690", VA = "0xD36690")]
		public static extern void EngineStatistics_numSpatDecoderQueuesPlaying_set(HandleRef jarg1, uint jarg2);

		[PreserveSig]
		[Token(Token = "0x6000247")]
		[Address(RVA = "0xD36720", Offset = "0xD36720", VA = "0xD36720")]
		public static extern uint EngineStatistics_numSpatDecoderQueuesPlaying_get(HandleRef jarg1);

		[PreserveSig]
		[Token(Token = "0x6000248")]
		[Address(RVA = "0xD367A0", Offset = "0xD367A0", VA = "0xD367A0")]
		public static extern IntPtr new_EngineStatistics();

		[PreserveSig]
		[Token(Token = "0x6000249")]
		[Address(RVA = "0xD36814", Offset = "0xD36814", VA = "0xD36814")]
		public static extern void delete_EngineStatistics(HandleRef jarg1);

		[PreserveSig]
		[Token(Token = "0x600024A")]
		[Address(RVA = "0xD32808", Offset = "0xD32808", VA = "0xD32808")]
		public static extern void AttenuationProps_minimumDistance_set(HandleRef jarg1, float jarg2);

		[PreserveSig]
		[Token(Token = "0x600024B")]
		[Address(RVA = "0xD32904", Offset = "0xD32904", VA = "0xD32904")]
		public static extern float AttenuationProps_minimumDistance_get(HandleRef jarg1);

		[PreserveSig]
		[Token(Token = "0x600024C")]
		[Address(RVA = "0xD32A00", Offset = "0xD32A00", VA = "0xD32A00")]
		public static extern void AttenuationProps_maximumDistance_set(HandleRef jarg1, float jarg2);

		[PreserveSig]
		[Token(Token = "0x600024D")]
		[Address(RVA = "0xD32AFC", Offset = "0xD32AFC", VA = "0xD32AFC")]
		public static extern float AttenuationProps_maximumDistance_get(HandleRef jarg1);

		[PreserveSig]
		[Token(Token = "0x600024E")]
		[Address(RVA = "0xD32BF8", Offset = "0xD32BF8", VA = "0xD32BF8")]
		public static extern void AttenuationProps_factor_set(HandleRef jarg1, float jarg2);

		[PreserveSig]
		[Token(Token = "0x600024F")]
		[Address(RVA = "0xD32CF4", Offset = "0xD32CF4", VA = "0xD32CF4")]
		public static extern float AttenuationProps_factor_get(HandleRef jarg1);

		[PreserveSig]
		[Token(Token = "0x6000250")]
		[Address(RVA = "0xD32DF0", Offset = "0xD32DF0", VA = "0xD32DF0")]
		public static extern void AttenuationProps_maxDistanceMute_set(HandleRef jarg1, bool jarg2);

		[PreserveSig]
		[Token(Token = "0x6000251")]
		[Address(RVA = "0xD32EEC", Offset = "0xD32EEC", VA = "0xD32EEC")]
		public static extern bool AttenuationProps_maxDistanceMute_get(HandleRef jarg1);

		[PreserveSig]
		[Token(Token = "0x6000252")]
		[Address(RVA = "0xD32FE4", Offset = "0xD32FE4", VA = "0xD32FE4")]
		public static extern IntPtr new_AttenuationProps__SWIG_0();

		[PreserveSig]
		[Token(Token = "0x6000253")]
		[Address(RVA = "0xD33100", Offset = "0xD33100", VA = "0xD33100")]
		public static extern IntPtr new_AttenuationProps__SWIG_1(float jarg1, float jarg2, float jarg3, bool jarg4);

		[PreserveSig]
		[Token(Token = "0x6000254")]
		[Address(RVA = "0xD33240", Offset = "0xD33240", VA = "0xD33240")]
		public static extern IntPtr new_AttenuationProps__SWIG_2(float jarg1, float jarg2, float jarg3);

		[PreserveSig]
		[Token(Token = "0x6000255")]
		[Address(RVA = "0xD3270C", Offset = "0xD3270C", VA = "0xD3270C")]
		public static extern void delete_AttenuationProps(HandleRef jarg1);

		[PreserveSig]
		[Token(Token = "0x6000256")]
		[Address(RVA = "0xD36894", Offset = "0xD36894", VA = "0xD36894")]
		public static extern void DirectionalProps_effectLevel_set(HandleRef jarg1, float jarg2);

		[PreserveSig]
		[Token(Token = "0x6000257")]
		[Address(RVA = "0xD36924", Offset = "0xD36924", VA = "0xD36924")]
		public static extern float DirectionalProps_effectLevel_get(HandleRef jarg1);

		[PreserveSig]
		[Token(Token = "0x6000258")]
		[Address(RVA = "0xD369A4", Offset = "0xD369A4", VA = "0xD369A4")]
		public static extern void DirectionalProps_coneArea_set(HandleRef jarg1, float jarg2);

		[PreserveSig]
		[Token(Token = "0x6000259")]
		[Address(RVA = "0xD36A34", Offset = "0xD36A34", VA = "0xD36A34")]
		public static extern float DirectionalProps_coneArea_get(HandleRef jarg1);

		[PreserveSig]
		[Token(Token = "0x600025A")]
		[Address(RVA = "0xD36AB4", Offset = "0xD36AB4", VA = "0xD36AB4")]
		public static extern IntPtr new_DirectionalProps__SWIG_0();

		[PreserveSig]
		[Token(Token = "0x600025B")]
		[Address(RVA = "0xD36B28", Offset = "0xD36B28", VA = "0xD36B28")]
		public static extern IntPtr new_DirectionalProps__SWIG_1(float jarg1, float jarg2);

		[PreserveSig]
		[Token(Token = "0x600025C")]
		[Address(RVA = "0xD36BB8", Offset = "0xD36BB8", VA = "0xD36BB8")]
		public static extern void DirectionalProps_set(HandleRef jarg1, float jarg2, float jarg3);

		[PreserveSig]
		[Token(Token = "0x600025D")]
		[Address(RVA = "0xD36C50", Offset = "0xD36C50", VA = "0xD36C50")]
		public static extern void delete_DirectionalProps(HandleRef jarg1);

		[PreserveSig]
		[Token(Token = "0x600025E")]
		[Address(RVA = "0xD31EA8", Offset = "0xD31EA8", VA = "0xD31EA8")]
		public static extern void AssetDescriptor_offsetInBytes_set(HandleRef jarg1, uint jarg2);

		[PreserveSig]
		[Token(Token = "0x600025F")]
		[Address(RVA = "0xD31FA4", Offset = "0xD31FA4", VA = "0xD31FA4")]
		public static extern uint AssetDescriptor_offsetInBytes_get(HandleRef jarg1);

		[PreserveSig]
		[Token(Token = "0x6000260")]
		[Address(RVA = "0xD320A0", Offset = "0xD320A0", VA = "0xD320A0")]
		public static extern void AssetDescriptor_lengthInBytes_set(HandleRef jarg1, uint jarg2);

		[PreserveSig]
		[Token(Token = "0x6000261")]
		[Address(RVA = "0xD3219C", Offset = "0xD3219C", VA = "0xD3219C")]
		public static extern uint AssetDescriptor_lengthInBytes_get(HandleRef jarg1);

		[PreserveSig]
		[Token(Token = "0x6000262")]
		[Address(RVA = "0xD3228C", Offset = "0xD3228C", VA = "0xD3228C")]
		public static extern IntPtr new_AssetDescriptor__SWIG_0();

		[PreserveSig]
		[Token(Token = "0x6000263")]
		[Address(RVA = "0xD32388", Offset = "0xD32388", VA = "0xD32388")]
		public static extern IntPtr new_AssetDescriptor__SWIG_1(uint jarg1, uint jarg2);

		[PreserveSig]
		[Token(Token = "0x6000264")]
		[Address(RVA = "0xD31DAC", Offset = "0xD31DAC", VA = "0xD31DAC")]
		public static extern void delete_AssetDescriptor(HandleRef jarg1);

		[PreserveSig]
		[Token(Token = "0x6000265")]
		[Address(RVA = "0xD36CD0", Offset = "0xD36CD0", VA = "0xD36CD0")]
		public static extern void AudioSettings_sampleRate_set(HandleRef jarg1, float jarg2);

		[PreserveSig]
		[Token(Token = "0x6000266")]
		[Address(RVA = "0xD36D60", Offset = "0xD36D60", VA = "0xD36D60")]
		public static extern float AudioSettings_sampleRate_get(HandleRef jarg1);

		[PreserveSig]
		[Token(Token = "0x6000267")]
		[Address(RVA = "0xD36DE0", Offset = "0xD36DE0", VA = "0xD36DE0")]
		public static extern void AudioSettings_bufferSize_set(HandleRef jarg1, int jarg2);

		[PreserveSig]
		[Token(Token = "0x6000268")]
		[Address(RVA = "0xD36E70", Offset = "0xD36E70", VA = "0xD36E70")]
		public static extern int AudioSettings_bufferSize_get(HandleRef jarg1);

		[PreserveSig]
		[Token(Token = "0x6000269")]
		[Address(RVA = "0xD36EF0", Offset = "0xD36EF0", VA = "0xD36EF0")]
		public static extern void AudioSettings_deviceType_set(HandleRef jarg1, int jarg2);

		[PreserveSig]
		[Token(Token = "0x600026A")]
		[Address(RVA = "0xD36F80", Offset = "0xD36F80", VA = "0xD36F80")]
		public static extern int AudioSettings_deviceType_get(HandleRef jarg1);

		[PreserveSig]
		[Token(Token = "0x600026B")]
		[Address(RVA = "0xD37000", Offset = "0xD37000", VA = "0xD37000")]
		public static extern void AudioSettings_customAudioDeviceName_set(HandleRef jarg1, string jarg2);

		[PreserveSig]
		[Token(Token = "0x600026C")]
		[Address(RVA = "0xD370A4", Offset = "0xD370A4", VA = "0xD370A4")]
		public static extern string AudioSettings_customAudioDeviceName_get(HandleRef jarg1);

		[PreserveSig]
		[Token(Token = "0x600026D")]
		[Address(RVA = "0xD3713C", Offset = "0xD3713C", VA = "0xD3713C")]
		public static extern IntPtr new_AudioSettings();

		[PreserveSig]
		[Token(Token = "0x600026E")]
		[Address(RVA = "0xD371B0", Offset = "0xD371B0", VA = "0xD371B0")]
		public static extern void delete_AudioSettings(HandleRef jarg1);

		[PreserveSig]
		[Token(Token = "0x600026F")]
		[Address(RVA = "0xD37230", Offset = "0xD37230", VA = "0xD37230")]
		public static extern void NetworkSettings_streamingBufferSizeBytes_set(HandleRef jarg1, uint jarg2);

		[PreserveSig]
		[Token(Token = "0x6000270")]
		[Address(RVA = "0xD372C0", Offset = "0xD372C0", VA = "0xD372C0")]
		public static extern uint NetworkSettings_streamingBufferSizeBytes_get(HandleRef jarg1);

		[PreserveSig]
		[Token(Token = "0x6000271")]
		[Address(RVA = "0xD37340", Offset = "0xD37340", VA = "0xD37340")]
		public static extern void NetworkSettings_maxDownloadSpeedBytes_set(HandleRef jarg1, long jarg2);

		[PreserveSig]
		[Token(Token = "0x6000272")]
		[Address(RVA = "0xD373D0", Offset = "0xD373D0", VA = "0xD373D0")]
		public static extern long NetworkSettings_maxDownloadSpeedBytes_get(HandleRef jarg1);

		[PreserveSig]
		[Token(Token = "0x6000273")]
		[Address(RVA = "0xD37450", Offset = "0xD37450", VA = "0xD37450")]
		public static extern void NetworkSettings_printDebugInfo_set(HandleRef jarg1, bool jarg2);

		[PreserveSig]
		[Token(Token = "0x6000274")]
		[Address(RVA = "0xD374E0", Offset = "0xD374E0", VA = "0xD374E0")]
		public static extern bool NetworkSettings_printDebugInfo_get(HandleRef jarg1);

		[PreserveSig]
		[Token(Token = "0x6000275")]
		[Address(RVA = "0xD37568", Offset = "0xD37568", VA = "0xD37568")]
		public static extern IntPtr new_NetworkSettings();

		[PreserveSig]
		[Token(Token = "0x6000276")]
		[Address(RVA = "0xD375DC", Offset = "0xD375DC", VA = "0xD375DC")]
		public static extern void delete_NetworkSettings(HandleRef jarg1);

		[PreserveSig]
		[Token(Token = "0x6000277")]
		[Address(RVA = "0xD3765C", Offset = "0xD3765C", VA = "0xD3765C")]
		public static extern void MemorySettings_spatDecoderQueuePoolSize_set(HandleRef jarg1, int jarg2);

		[PreserveSig]
		[Token(Token = "0x6000278")]
		[Address(RVA = "0xD376EC", Offset = "0xD376EC", VA = "0xD376EC")]
		public static extern int MemorySettings_spatDecoderQueuePoolSize_get(HandleRef jarg1);

		[PreserveSig]
		[Token(Token = "0x6000279")]
		[Address(RVA = "0xD3776C", Offset = "0xD3776C", VA = "0xD3776C")]
		public static extern void MemorySettings_spatDecoderFilePoolSize_set(HandleRef jarg1, int jarg2);

		[PreserveSig]
		[Token(Token = "0x600027A")]
		[Address(RVA = "0xD377FC", Offset = "0xD377FC", VA = "0xD377FC")]
		public static extern int MemorySettings_spatDecoderFilePoolSize_get(HandleRef jarg1);

		[PreserveSig]
		[Token(Token = "0x600027B")]
		[Address(RVA = "0xD3787C", Offset = "0xD3787C", VA = "0xD3787C")]
		public static extern void MemorySettings_spatQueueSizePerChannel_set(HandleRef jarg1, int jarg2);

		[PreserveSig]
		[Token(Token = "0x600027C")]
		[Address(RVA = "0xD3790C", Offset = "0xD3790C", VA = "0xD3790C")]
		public static extern int MemorySettings_spatQueueSizePerChannel_get(HandleRef jarg1);

		[PreserveSig]
		[Token(Token = "0x600027D")]
		[Address(RVA = "0xD3798C", Offset = "0xD3798C", VA = "0xD3798C")]
		public static extern void MemorySettings_audioObjectPoolSize_set(HandleRef jarg1, int jarg2);

		[PreserveSig]
		[Token(Token = "0x600027E")]
		[Address(RVA = "0xD37A1C", Offset = "0xD37A1C", VA = "0xD37A1C")]
		public static extern int MemorySettings_audioObjectPoolSize_get(HandleRef jarg1);

		[PreserveSig]
		[Token(Token = "0x600027F")]
		[Address(RVA = "0xD37A9C", Offset = "0xD37A9C", VA = "0xD37A9C")]
		public static extern void MemorySettings_speakersVirtualizersPoolSize_set(HandleRef jarg1, uint jarg2);

		[PreserveSig]
		[Token(Token = "0x6000280")]
		[Address(RVA = "0xD37B2C", Offset = "0xD37B2C", VA = "0xD37B2C")]
		public static extern uint MemorySettings_speakersVirtualizersPoolSize_get(HandleRef jarg1);

		[PreserveSig]
		[Token(Token = "0x6000281")]
		[Address(RVA = "0xD37BAC", Offset = "0xD37BAC", VA = "0xD37BAC")]
		public static extern void MemorySettings_audioAssetManager_set(HandleRef jarg1, HandleRef jarg2);

		[PreserveSig]
		[Token(Token = "0x6000282")]
		[Address(RVA = "0xD37C3C", Offset = "0xD37C3C", VA = "0xD37C3C")]
		public static extern IntPtr MemorySettings_audioAssetManager_get(HandleRef jarg1);

		[PreserveSig]
		[Token(Token = "0x6000283")]
		[Address(RVA = "0xD37CBC", Offset = "0xD37CBC", VA = "0xD37CBC")]
		public static extern IntPtr new_MemorySettings();

		[PreserveSig]
		[Token(Token = "0x6000284")]
		[Address(RVA = "0xD37D30", Offset = "0xD37D30", VA = "0xD37D30")]
		public static extern void delete_MemorySettings(HandleRef jarg1);

		[PreserveSig]
		[Token(Token = "0x6000285")]
		[Address(RVA = "0xD37DB0", Offset = "0xD37DB0", VA = "0xD37DB0")]
		public static extern void PlatformSettings_useAndroidFastPath_set(HandleRef jarg1, bool jarg2);

		[PreserveSig]
		[Token(Token = "0x6000286")]
		[Address(RVA = "0xD37E40", Offset = "0xD37E40", VA = "0xD37E40")]
		public static extern bool PlatformSettings_useAndroidFastPath_get(HandleRef jarg1);

		[PreserveSig]
		[Token(Token = "0x6000287")]
		[Address(RVA = "0xD37EC8", Offset = "0xD37EC8", VA = "0xD37EC8")]
		public static extern IntPtr new_PlatformSettings();

		[PreserveSig]
		[Token(Token = "0x6000288")]
		[Address(RVA = "0xD37F3C", Offset = "0xD37F3C", VA = "0xD37F3C")]
		public static extern void delete_PlatformSettings(HandleRef jarg1);

		[PreserveSig]
		[Token(Token = "0x6000289")]
		[Address(RVA = "0xD37FBC", Offset = "0xD37FBC", VA = "0xD37FBC")]
		public static extern void Experimental_ambisonicRenderer_set(HandleRef jarg1, int jarg2);

		[PreserveSig]
		[Token(Token = "0x600028A")]
		[Address(RVA = "0xD3804C", Offset = "0xD3804C", VA = "0xD3804C")]
		public static extern int Experimental_ambisonicRenderer_get(HandleRef jarg1);

		[PreserveSig]
		[Token(Token = "0x600028B")]
		[Address(RVA = "0xD380CC", Offset = "0xD380CC", VA = "0xD380CC")]
		public static extern void Experimental_useFba_set(HandleRef jarg1, bool jarg2);

		[PreserveSig]
		[Token(Token = "0x600028C")]
		[Address(RVA = "0xD3815C", Offset = "0xD3815C", VA = "0xD3815C")]
		public static extern bool Experimental_useFba_get(HandleRef jarg1);

		[PreserveSig]
		[Token(Token = "0x600028D")]
		[Address(RVA = "0xD381E4", Offset = "0xD381E4", VA = "0xD381E4")]
		public static extern void Experimental_fbaNumThreads_set(HandleRef jarg1, byte jarg2);

		[PreserveSig]
		[Token(Token = "0x600028E")]
		[Address(RVA = "0xD38274", Offset = "0xD38274", VA = "0xD38274")]
		public static extern byte Experimental_fbaNumThreads_get(HandleRef jarg1);

		[PreserveSig]
		[Token(Token = "0x600028F")]
		[Address(RVA = "0xD382F4", Offset = "0xD382F4", VA = "0xD382F4")]
		public static extern IntPtr new_Experimental();

		[PreserveSig]
		[Token(Token = "0x6000290")]
		[Address(RVA = "0xD38368", Offset = "0xD38368", VA = "0xD38368")]
		public static extern void delete_Experimental(HandleRef jarg1);

		[PreserveSig]
		[Token(Token = "0x6000291")]
		[Address(RVA = "0xD383E8", Offset = "0xD383E8", VA = "0xD383E8")]
		public static extern void ThreadSettings_useDecoderThread_set(HandleRef jarg1, bool jarg2);

		[PreserveSig]
		[Token(Token = "0x6000292")]
		[Address(RVA = "0xD38478", Offset = "0xD38478", VA = "0xD38478")]
		public static extern bool ThreadSettings_useDecoderThread_get(HandleRef jarg1);

		[PreserveSig]
		[Token(Token = "0x6000293")]
		[Address(RVA = "0xD38500", Offset = "0xD38500", VA = "0xD38500")]
		public static extern IntPtr new_ThreadSettings();

		[PreserveSig]
		[Token(Token = "0x6000294")]
		[Address(RVA = "0xD38574", Offset = "0xD38574", VA = "0xD38574")]
		public static extern void delete_ThreadSettings(HandleRef jarg1);

		[PreserveSig]
		[Token(Token = "0x6000295")]
		[Address(RVA = "0xD385F4", Offset = "0xD385F4", VA = "0xD385F4")]
		public static extern void VoiceManagerSettings_maxPhysicalVoices_set(HandleRef jarg1, uint jarg2);

		[PreserveSig]
		[Token(Token = "0x6000296")]
		[Address(RVA = "0xD38684", Offset = "0xD38684", VA = "0xD38684")]
		public static extern uint VoiceManagerSettings_maxPhysicalVoices_get(HandleRef jarg1);

		[PreserveSig]
		[Token(Token = "0x6000297")]
		[Address(RVA = "0xD38704", Offset = "0xD38704", VA = "0xD38704")]
		public static extern void VoiceManagerSettings_maxVirtualVoices_set(HandleRef jarg1, uint jarg2);

		[PreserveSig]
		[Token(Token = "0x6000298")]
		[Address(RVA = "0xD38794", Offset = "0xD38794", VA = "0xD38794")]
		public static extern uint VoiceManagerSettings_maxVirtualVoices_get(HandleRef jarg1);

		[PreserveSig]
		[Token(Token = "0x6000299")]
		[Address(RVA = "0xD38814", Offset = "0xD38814", VA = "0xD38814")]
		public static extern IntPtr new_VoiceManagerSettings();

		[PreserveSig]
		[Token(Token = "0x600029A")]
		[Address(RVA = "0xD38888", Offset = "0xD38888", VA = "0xD38888")]
		public static extern void delete_VoiceManagerSettings(HandleRef jarg1);

		[PreserveSig]
		[Token(Token = "0x600029B")]
		[Address(RVA = "0xD38908", Offset = "0xD38908", VA = "0xD38908")]
		public static extern void EngineInitSettings_audioSettings_set(HandleRef jarg1, HandleRef jarg2);

		[PreserveSig]
		[Token(Token = "0x600029C")]
		[Address(RVA = "0xD38998", Offset = "0xD38998", VA = "0xD38998")]
		public static extern IntPtr EngineInitSettings_audioSettings_get(HandleRef jarg1);

		[PreserveSig]
		[Token(Token = "0x600029D")]
		[Address(RVA = "0xD38A18", Offset = "0xD38A18", VA = "0xD38A18")]
		public static extern void EngineInitSettings_memorySettings_set(HandleRef jarg1, HandleRef jarg2);

		[PreserveSig]
		[Token(Token = "0x600029E")]
		[Address(RVA = "0xD38AA8", Offset = "0xD38AA8", VA = "0xD38AA8")]
		public static extern IntPtr EngineInitSettings_memorySettings_get(HandleRef jarg1);

		[PreserveSig]
		[Token(Token = "0x600029F")]
		[Address(RVA = "0xD38B28", Offset = "0xD38B28", VA = "0xD38B28")]
		public static extern void EngineInitSettings_platformSettings_set(HandleRef jarg1, HandleRef jarg2);

		[PreserveSig]
		[Token(Token = "0x60002A0")]
		[Address(RVA = "0xD38BB8", Offset = "0xD38BB8", VA = "0xD38BB8")]
		public static extern IntPtr EngineInitSettings_platformSettings_get(HandleRef jarg1);

		[PreserveSig]
		[Token(Token = "0x60002A1")]
		[Address(RVA = "0xD38C38", Offset = "0xD38C38", VA = "0xD38C38")]
		public static extern void EngineInitSettings_threads_set(HandleRef jarg1, HandleRef jarg2);

		[PreserveSig]
		[Token(Token = "0x60002A2")]
		[Address(RVA = "0xD38CC8", Offset = "0xD38CC8", VA = "0xD38CC8")]
		public static extern IntPtr EngineInitSettings_threads_get(HandleRef jarg1);

		[PreserveSig]
		[Token(Token = "0x60002A3")]
		[Address(RVA = "0xD38D48", Offset = "0xD38D48", VA = "0xD38D48")]
		public static extern void EngineInitSettings_experimental_set(HandleRef jarg1, HandleRef jarg2);

		[PreserveSig]
		[Token(Token = "0x60002A4")]
		[Address(RVA = "0xD38DD8", Offset = "0xD38DD8", VA = "0xD38DD8")]
		public static extern IntPtr EngineInitSettings_experimental_get(HandleRef jarg1);

		[PreserveSig]
		[Token(Token = "0x60002A5")]
		[Address(RVA = "0xD38E58", Offset = "0xD38E58", VA = "0xD38E58")]
		public static extern void EngineInitSettings_voiceManagerSettings_set(HandleRef jarg1, HandleRef jarg2);

		[PreserveSig]
		[Token(Token = "0x60002A6")]
		[Address(RVA = "0xD38EE8", Offset = "0xD38EE8", VA = "0xD38EE8")]
		public static extern IntPtr EngineInitSettings_voiceManagerSettings_get(HandleRef jarg1);

		[PreserveSig]
		[Token(Token = "0x60002A7")]
		[Address(RVA = "0xD38F68", Offset = "0xD38F68", VA = "0xD38F68")]
		public static extern IntPtr new_EngineInitSettings();

		[PreserveSig]
		[Token(Token = "0x60002A8")]
		[Address(RVA = "0xD38FDC", Offset = "0xD38FDC", VA = "0xD38FDC")]
		public static extern void delete_EngineInitSettings(HandleRef jarg1);

		[PreserveSig]
		[Token(Token = "0x60002A9")]
		[Address(RVA = "0xD33344", Offset = "0xD33344", VA = "0xD33344")]
		public static extern int getNumChannelsForMap(int jarg1);

		[PreserveSig]
		[Token(Token = "0x60002AA")]
		[Address(RVA = "0xD3905C", Offset = "0xD3905C", VA = "0xD3905C")]
		public static extern void LoudnessStatistics_integrated_set(HandleRef jarg1, float jarg2);

		[PreserveSig]
		[Token(Token = "0x60002AB")]
		[Address(RVA = "0xD390EC", Offset = "0xD390EC", VA = "0xD390EC")]
		public static extern float LoudnessStatistics_integrated_get(HandleRef jarg1);

		[PreserveSig]
		[Token(Token = "0x60002AC")]
		[Address(RVA = "0xD3916C", Offset = "0xD3916C", VA = "0xD3916C")]
		public static extern void LoudnessStatistics_shortTerm_set(HandleRef jarg1, float jarg2);

		[PreserveSig]
		[Token(Token = "0x60002AD")]
		[Address(RVA = "0xD391FC", Offset = "0xD391FC", VA = "0xD391FC")]
		public static extern float LoudnessStatistics_shortTerm_get(HandleRef jarg1);

		[PreserveSig]
		[Token(Token = "0x60002AE")]
		[Address(RVA = "0xD3927C", Offset = "0xD3927C", VA = "0xD3927C")]
		public static extern void LoudnessStatistics_momentary_set(HandleRef jarg1, float jarg2);

		[PreserveSig]
		[Token(Token = "0x60002AF")]
		[Address(RVA = "0xD3930C", Offset = "0xD3930C", VA = "0xD3930C")]
		public static extern float LoudnessStatistics_momentary_get(HandleRef jarg1);

		[PreserveSig]
		[Token(Token = "0x60002B0")]
		[Address(RVA = "0xD3938C", Offset = "0xD3938C", VA = "0xD3938C")]
		public static extern void LoudnessStatistics_truePeak_set(HandleRef jarg1, float jarg2);

		[PreserveSig]
		[Token(Token = "0x60002B1")]
		[Address(RVA = "0xD3941C", Offset = "0xD3941C", VA = "0xD3941C")]
		public static extern float LoudnessStatistics_truePeak_get(HandleRef jarg1);

		[PreserveSig]
		[Token(Token = "0x60002B2")]
		[Address(RVA = "0xD3949C", Offset = "0xD3949C", VA = "0xD3949C")]
		public static extern IntPtr new_LoudnessStatistics();

		[PreserveSig]
		[Token(Token = "0x60002B3")]
		[Address(RVA = "0xD39510", Offset = "0xD39510", VA = "0xD39510")]
		public static extern void delete_LoudnessStatistics(HandleRef jarg1);

		[PreserveSig]
		[Token(Token = "0x60002B4")]
		[Address(RVA = "0xD33464", Offset = "0xD33464", VA = "0xD33464")]
		public static extern IntPtr AudioSettings_default_get();

		[PreserveSig]
		[Token(Token = "0x60002B5")]
		[Address(RVA = "0xD33578", Offset = "0xD33578", VA = "0xD33578")]
		public static extern IntPtr NetworkSettings_default_get();

		[PreserveSig]
		[Token(Token = "0x60002B6")]
		[Address(RVA = "0xD3368C", Offset = "0xD3368C", VA = "0xD3368C")]
		public static extern IntPtr MemorySettings_default_get();

		[PreserveSig]
		[Token(Token = "0x60002B7")]
		[Address(RVA = "0xD337A0", Offset = "0xD337A0", VA = "0xD337A0")]
		public static extern IntPtr EngineInitSettings_default_get();

		[PreserveSig]
		[Token(Token = "0x60002B8")]
		[Address(RVA = "0xD33870", Offset = "0xD33870", VA = "0xD33870")]
		public static extern uint kMaxStrSize_get();

		[PreserveSig]
		[Token(Token = "0x60002B9")]
		[Address(RVA = "0xD39590", Offset = "0xD39590", VA = "0xD39590")]
		public static extern void delete_AudioEngine(HandleRef jarg1);

		[PreserveSig]
		[Token(Token = "0x60002BA")]
		[Address(RVA = "0xD39610", Offset = "0xD39610", VA = "0xD39610")]
		public static extern int AudioEngine_start(HandleRef jarg1);

		[PreserveSig]
		[Token(Token = "0x60002BB")]
		[Address(RVA = "0xD39690", Offset = "0xD39690", VA = "0xD39690")]
		public static extern int AudioEngine_suspend(HandleRef jarg1);

		[PreserveSig]
		[Token(Token = "0x60002BC")]
		[Address(RVA = "0xD39710", Offset = "0xD39710", VA = "0xD39710")]
		public static extern int AudioEngine_setNumBinaural(HandleRef jarg1, int jarg2);

		[PreserveSig]
		[Token(Token = "0x60002BD")]
		[Address(RVA = "0xD397A0", Offset = "0xD397A0", VA = "0xD397A0")]
		public static extern int AudioEngine_getNumBinaural(HandleRef jarg1);

		[PreserveSig]
		[Token(Token = "0x60002BE")]
		[Address(RVA = "0xD39820", Offset = "0xD39820", VA = "0xD39820")]
		public static extern void AudioEngine_setListenerRotation__SWIG_0(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3);

		[PreserveSig]
		[Token(Token = "0x60002BF")]
		[Address(RVA = "0xD398B8", Offset = "0xD398B8", VA = "0xD398B8")]
		public static extern void AudioEngine_setListenerRotation__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[PreserveSig]
		[Token(Token = "0x60002C0")]
		[Address(RVA = "0xD39948", Offset = "0xD39948", VA = "0xD39948")]
		public static extern void AudioEngine_setListenerRotation__SWIG_2(HandleRef jarg1, float jarg2, float jarg3, float jarg4);

		[PreserveSig]
		[Token(Token = "0x60002C1")]
		[Address(RVA = "0xD399F0", Offset = "0xD399F0", VA = "0xD399F0")]
		public static extern void AudioEngine_setListenerPosition(HandleRef jarg1, HandleRef jarg2);

		[PreserveSig]
		[Token(Token = "0x60002C2")]
		[Address(RVA = "0xD39A80", Offset = "0xD39A80", VA = "0xD39A80")]
		public static extern IntPtr AudioEngine_getListenerPosition(HandleRef jarg1);

		[PreserveSig]
		[Token(Token = "0x60002C3")]
		[Address(RVA = "0xD39B00", Offset = "0xD39B00", VA = "0xD39B00")]
		public static extern IntPtr AudioEngine_getListenerRotation(HandleRef jarg1);

		[PreserveSig]
		[Token(Token = "0x60002C4")]
		[Address(RVA = "0xD39B80", Offset = "0xD39B80", VA = "0xD39B80")]
		public static extern IntPtr AudioEngine_getListenerForward(HandleRef jarg1);

		[PreserveSig]
		[Token(Token = "0x60002C5")]
		[Address(RVA = "0xD39C00", Offset = "0xD39C00", VA = "0xD39C00")]
		public static extern IntPtr AudioEngine_getListenerUp(HandleRef jarg1);

		[PreserveSig]
		[Token(Token = "0x60002C6")]
		[Address(RVA = "0xD39C80", Offset = "0xD39C80", VA = "0xD39C80")]
		public static extern void AudioEngine_setListenerScale(HandleRef jarg1, float jarg2);

		[PreserveSig]
		[Token(Token = "0x60002C7")]
		[Address(RVA = "0xD39D10", Offset = "0xD39D10", VA = "0xD39D10")]
		public static extern float AudioEngine_getListenerScale(HandleRef jarg1);

		[PreserveSig]
		[Token(Token = "0x60002C8")]
		[Address(RVA = "0xD39D90", Offset = "0xD39D90", VA = "0xD39D90")]
		public static extern void AudioEngine_update(HandleRef jarg1);

		[PreserveSig]
		[Token(Token = "0x60002C9")]
		[Address(RVA = "0xD39E10", Offset = "0xD39E10", VA = "0xD39E10")]
		public static extern int AudioEngine_enablePositionalTracking(HandleRef jarg1, bool jarg2, HandleRef jarg3);

		[PreserveSig]
		[Token(Token = "0x60002CA")]
		[Address(RVA = "0xD39EA8", Offset = "0xD39EA8", VA = "0xD39EA8")]
		public static extern bool AudioEngine_positionalTrackingEnabled(HandleRef jarg1);

		[PreserveSig]
		[Token(Token = "0x60002CB")]
		[Address(RVA = "0xD39F30", Offset = "0xD39F30", VA = "0xD39F30")]
		public static extern int AudioEngine_getBufferSize(HandleRef jarg1);

		[PreserveSig]
		[Token(Token = "0x60002CC")]
		[Address(RVA = "0xD39FB0", Offset = "0xD39FB0", VA = "0xD39FB0")]
		public static extern float AudioEngine_getSampleRate(HandleRef jarg1);

		[PreserveSig]
		[Token(Token = "0x60002CD")]
		[Address(RVA = "0xD3A030", Offset = "0xD3A030", VA = "0xD3A030")]
		public static extern int AudioEngine_getAudioMix(HandleRef jarg1, [In] float[] jarg2, int jarg3, int jarg4);

		[PreserveSig]
		[Token(Token = "0x60002CE")]
		[Address(RVA = "0xD3A0E0", Offset = "0xD3A0E0", VA = "0xD3A0E0")]
		public static extern int AudioEngine_setAudioMixCallback(HandleRef jarg1, AudioInterleavedCallback jarg2, IntPtr jarg3);

		[PreserveSig]
		[Token(Token = "0x60002CF")]
		[Address(RVA = "0xD3A180", Offset = "0xD3A180", VA = "0xD3A180")]
		public static extern int AudioEngine_setAudioInputMixCallback(HandleRef jarg1, AudioInterleavedCallback jarg2, IntPtr jarg3);

		[PreserveSig]
		[Token(Token = "0x60002D0")]
		[Address(RVA = "0xD3A220", Offset = "0xD3A220", VA = "0xD3A220")]
		public static extern int AudioEngine_setAudioInputInterleavedCallback(HandleRef jarg1, AudioInterleavedCallback jarg2, IntPtr jarg3);

		[PreserveSig]
		[Token(Token = "0x60002D1")]
		[Address(RVA = "0xD3A2C0", Offset = "0xD3A2C0", VA = "0xD3A2C0")]
		public static extern void AudioEngine_destroySpatDecoderQueue(HandleRef jarg1, HandleRef jarg2);

		[PreserveSig]
		[Token(Token = "0x60002D2")]
		[Address(RVA = "0xD3A350", Offset = "0xD3A350", VA = "0xD3A350")]
		public static extern int AudioEngine_createSpatDecoderFile__SWIG_0(HandleRef jarg1, HandleRef jarg2, int jarg3);

		[PreserveSig]
		[Token(Token = "0x60002D3")]
		[Address(RVA = "0xD3A3E8", Offset = "0xD3A3E8", VA = "0xD3A3E8")]
		public static extern void AudioEngine_destroySpatDecoderFile(HandleRef jarg1, HandleRef jarg2);

		[PreserveSig]
		[Token(Token = "0x60002D4")]
		[Address(RVA = "0xD3A478", Offset = "0xD3A478", VA = "0xD3A478")]
		public static extern int AudioEngine_createAudioObject__SWIG_0(HandleRef jarg1, HandleRef jarg2, int jarg3);

		[PreserveSig]
		[Token(Token = "0x60002D5")]
		[Address(RVA = "0xD3A510", Offset = "0xD3A510", VA = "0xD3A510")]
		public static extern void AudioEngine_destroyAudioObject(HandleRef jarg1, HandleRef jarg2);

		[PreserveSig]
		[Token(Token = "0x60002D6")]
		[Address(RVA = "0xD3A5A0", Offset = "0xD3A5A0", VA = "0xD3A5A0")]
		public static extern void AudioEngine_destroyEventTransport(HandleRef jarg1, HandleRef jarg2);

		[PreserveSig]
		[Token(Token = "0x60002D7")]
		[Address(RVA = "0xD3A630", Offset = "0xD3A630", VA = "0xD3A630")]
		public static extern int AudioEngine_createBus(HandleRef jarg1, out IntPtr jarg2);

		[PreserveSig]
		[Token(Token = "0x60002D8")]
		[Address(RVA = "0xD3A6C0", Offset = "0xD3A6C0", VA = "0xD3A6C0")]
		public static extern int AudioEngine_destroyBus(HandleRef jarg1, ref IntPtr jarg2);

		[PreserveSig]
		[Token(Token = "0x60002D9")]
		[Address(RVA = "0xD3A750", Offset = "0xD3A750", VA = "0xD3A750")]
		public static extern int AudioEngine_connectToMasterBus__SWIG_0(HandleRef jarg1, IntPtr jarg2);

		[PreserveSig]
		[Token(Token = "0x60002DA")]
		[Address(RVA = "0xD3A7E0", Offset = "0xD3A7E0", VA = "0xD3A7E0")]
		public static extern int AudioEngine_connectToMasterBus__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[PreserveSig]
		[Token(Token = "0x60002DB")]
		[Address(RVA = "0xD3A870", Offset = "0xD3A870", VA = "0xD3A870")]
		public static extern int AudioEngine_connect__SWIG_0(HandleRef jarg1, IntPtr jarg2, IntPtr jarg3);

		[PreserveSig]
		[Token(Token = "0x60002DC")]
		[Address(RVA = "0xD3A908", Offset = "0xD3A908", VA = "0xD3A908")]
		public static extern int AudioEngine_connect__SWIG_1(HandleRef jarg1, HandleRef jarg2, IntPtr jarg3);

		[PreserveSig]
		[Token(Token = "0x60002DD")]
		[Address(RVA = "0xD3A9A0", Offset = "0xD3A9A0", VA = "0xD3A9A0")]
		public static extern int AudioEngine_disconnectOutput__SWIG_0(HandleRef jarg1, IntPtr jarg2);

		[PreserveSig]
		[Token(Token = "0x60002DE")]
		[Address(RVA = "0xD3AA30", Offset = "0xD3AA30", VA = "0xD3AA30")]
		public static extern int AudioEngine_disconnectOutput__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[PreserveSig]
		[Token(Token = "0x60002DF")]
		[Address(RVA = "0xD3AAC0", Offset = "0xD3AAC0", VA = "0xD3AAC0")]
		public static extern int AudioEngine_setGain(HandleRef jarg1, IntPtr jarg2, float jarg3, float jarg4);

		[PreserveSig]
		[Token(Token = "0x60002E0")]
		[Address(RVA = "0xD3AB68", Offset = "0xD3AB68", VA = "0xD3AB68")]
		public static extern int AudioEngine_getGain(HandleRef jarg1, IntPtr jarg2, ref float jarg3);

		[PreserveSig]
		[Token(Token = "0x60002E1")]
		[Address(RVA = "0xD3AC00", Offset = "0xD3AC00", VA = "0xD3AC00")]
		public static extern int AudioEngine_AUDIO360_MAX_BUS_NAME_SIZE_get();

		[PreserveSig]
		[Token(Token = "0x60002E2")]
		[Address(RVA = "0xD3AC74", Offset = "0xD3AC74", VA = "0xD3AC74")]
		public static extern int AudioEngine_setName(HandleRef jarg1, IntPtr jarg2, string jarg3);

		[PreserveSig]
		[Token(Token = "0x60002E3")]
		[Address(RVA = "0xD3AD28", Offset = "0xD3AD28", VA = "0xD3AD28")]
		public static extern int AudioEngine_setEventCallback(HandleRef jarg1, EventCallback jarg2, IntPtr jarg3);

		[PreserveSig]
		[Token(Token = "0x60002E4")]
		[Address(RVA = "0xD3ADC8", Offset = "0xD3ADC8", VA = "0xD3ADC8")]
		public static extern void AudioEngine_enableTestTone__SWIG_0(HandleRef jarg1, bool jarg2, float jarg3, float jarg4);

		[PreserveSig]
		[Token(Token = "0x60002E5")]
		[Address(RVA = "0xD3AE70", Offset = "0xD3AE70", VA = "0xD3AE70")]
		public static extern void AudioEngine_enableTestTone__SWIG_1(HandleRef jarg1, bool jarg2, float jarg3);

		[PreserveSig]
		[Token(Token = "0x60002E6")]
		[Address(RVA = "0xD3AF10", Offset = "0xD3AF10", VA = "0xD3AF10")]
		public static extern void AudioEngine_enableTestTone__SWIG_2(HandleRef jarg1, bool jarg2);

		[PreserveSig]
		[Token(Token = "0x60002E7")]
		[Address(RVA = "0xD3AFA0", Offset = "0xD3AFA0", VA = "0xD3AFA0")]
		public static extern int AudioEngine_getVersionMajor(HandleRef jarg1);

		[PreserveSig]
		[Token(Token = "0x60002E8")]
		[Address(RVA = "0xD3B020", Offset = "0xD3B020", VA = "0xD3B020")]
		public static extern int AudioEngine_getVersionMinor(HandleRef jarg1);

		[PreserveSig]
		[Token(Token = "0x60002E9")]
		[Address(RVA = "0xD3B0A0", Offset = "0xD3B0A0", VA = "0xD3B0A0")]
		public static extern int AudioEngine_getVersionPatch(HandleRef jarg1);

		[PreserveSig]
		[Token(Token = "0x60002EA")]
		[Address(RVA = "0xD3B120", Offset = "0xD3B120", VA = "0xD3B120")]
		public static extern string AudioEngine_getVersionHash(HandleRef jarg1);

		[PreserveSig]
		[Token(Token = "0x60002EB")]
		[Address(RVA = "0xD3B1B8", Offset = "0xD3B1B8", VA = "0xD3B1B8")]
		public static extern IntPtr AudioEngine_getRenderedLoudness(HandleRef jarg1);

		[PreserveSig]
		[Token(Token = "0x60002EC")]
		[Address(RVA = "0xD3B238", Offset = "0xD3B238", VA = "0xD3B238")]
		public static extern void AudioEngine_resetLoudness(HandleRef jarg1);

		[PreserveSig]
		[Token(Token = "0x60002ED")]
		[Address(RVA = "0xD3B2B8", Offset = "0xD3B2B8", VA = "0xD3B2B8")]
		public static extern void AudioEngine_enableLoudness__SWIG_0(HandleRef jarg1, bool jarg2);

		[PreserveSig]
		[Token(Token = "0x60002EE")]
		[Address(RVA = "0xD3B348", Offset = "0xD3B348", VA = "0xD3B348")]
		public static extern void AudioEngine_enableLoudness__SWIG_1(HandleRef jarg1);

		[PreserveSig]
		[Token(Token = "0x60002EF")]
		[Address(RVA = "0xD3B3C8", Offset = "0xD3B3C8", VA = "0xD3B3C8")]
		public static extern long AudioEngine_getDSPTime(HandleRef jarg1);

		[PreserveSig]
		[Token(Token = "0x60002F0")]
		[Address(RVA = "0xD3B448", Offset = "0xD3B448", VA = "0xD3B448")]
		public static extern int AudioEngine_setNumOutputBuffers(HandleRef jarg1, uint jarg2);

		[PreserveSig]
		[Token(Token = "0x60002F1")]
		[Address(RVA = "0xD3B4D8", Offset = "0xD3B4D8", VA = "0xD3B4D8")]
		public static extern uint AudioEngine_getNumOutputBuffers(HandleRef jarg1);

		[PreserveSig]
		[Token(Token = "0x60002F2")]
		[Address(RVA = "0xD3B558", Offset = "0xD3B558", VA = "0xD3B558")]
		public static extern int AudioEngine_getOutputLatencySamples(HandleRef jarg1);

		[PreserveSig]
		[Token(Token = "0x60002F3")]
		[Address(RVA = "0xD3B5D8", Offset = "0xD3B5D8", VA = "0xD3B5D8")]
		public static extern double AudioEngine_getOutputLatencyMs(HandleRef jarg1);

		[PreserveSig]
		[Token(Token = "0x60002F4")]
		[Address(RVA = "0xD3B658", Offset = "0xD3B658", VA = "0xD3B658")]
		public static extern string AudioEngine_getOutputAudioDeviceName(HandleRef jarg1);

		[PreserveSig]
		[Token(Token = "0x60002F5")]
		[Address(RVA = "0xD3B6F0", Offset = "0xD3B6F0", VA = "0xD3B6F0")]
		public static extern int AudioEngine_openAudioInput(HandleRef jarg1, string jarg2);

		[PreserveSig]
		[Token(Token = "0x60002F6")]
		[Address(RVA = "0xD3B79C", Offset = "0xD3B79C", VA = "0xD3B79C")]
		public static extern int AudioEngine_mixAudioInput(HandleRef jarg1, bool jarg2);

		[PreserveSig]
		[Token(Token = "0x60002F7")]
		[Address(RVA = "0xD3B82C", Offset = "0xD3B82C", VA = "0xD3B82C")]
		public static extern int AudioEngine_setInputMixGain(HandleRef jarg1, float jarg2);

		[PreserveSig]
		[Token(Token = "0x60002F8")]
		[Address(RVA = "0xD3B8BC", Offset = "0xD3B8BC", VA = "0xD3B8BC")]
		public static extern int AudioEngine_closeAudioInput(HandleRef jarg1);

		[PreserveSig]
		[Token(Token = "0x60002F9")]
		[Address(RVA = "0xD3B93C", Offset = "0xD3B93C", VA = "0xD3B93C")]
		public static extern IntPtr AudioEngine_getAudioAssetManager(HandleRef jarg1);

		[PreserveSig]
		[Token(Token = "0x60002FA")]
		[Address(RVA = "0xD3B9BC", Offset = "0xD3B9BC", VA = "0xD3B9BC")]
		public static extern IntPtr AudioEngine_getVoiceManager(HandleRef jarg1);

		[PreserveSig]
		[Token(Token = "0x60002FB")]
		[Address(RVA = "0xD3BA3C", Offset = "0xD3BA3C", VA = "0xD3BA3C")]
		public static extern void AudioEngine_setMasterVolume(HandleRef jarg1, float jarg2, float jarg3);

		[PreserveSig]
		[Token(Token = "0x60002FC")]
		[Address(RVA = "0xD3BAD4", Offset = "0xD3BAD4", VA = "0xD3BAD4")]
		public static extern float AudioEngine_getMasterVolume(HandleRef jarg1);

		[PreserveSig]
		[Token(Token = "0x60002FD")]
		[Address(RVA = "0xD3BB54", Offset = "0xD3BB54", VA = "0xD3BB54")]
		public static extern void AudioEngine_enableMasterMute(HandleRef jarg1, bool jarg2);

		[PreserveSig]
		[Token(Token = "0x60002FE")]
		[Address(RVA = "0xD3BBE4", Offset = "0xD3BBE4", VA = "0xD3BBE4")]
		public static extern bool AudioEngine_isMasterMuteEnabled(HandleRef jarg1);

		[PreserveSig]
		[Token(Token = "0x60002FF")]
		[Address(RVA = "0xD3BC6C", Offset = "0xD3BC6C", VA = "0xD3BC6C")]
		public static extern IntPtr AudioEngine_getStats(HandleRef jarg1);

		[PreserveSig]
		[Token(Token = "0x6000300")]
		[Address(RVA = "0xD3BCEC", Offset = "0xD3BCEC", VA = "0xD3BCEC")]
		public static extern int AudioEngine_getNumAudioDevices();

		[PreserveSig]
		[Token(Token = "0x6000301")]
		[Address(RVA = "0xD3BD60", Offset = "0xD3BD60", VA = "0xD3BD60")]
		public static extern string AudioEngine_getAudioDeviceName(int jarg1);

		[PreserveSig]
		[Token(Token = "0x6000302")]
		[Address(RVA = "0xD3BDF8", Offset = "0xD3BDF8", VA = "0xD3BDF8")]
		public static extern string AudioEngine_getAudioDeviceNameFromId(string jarg1);

		[PreserveSig]
		[Token(Token = "0x6000303")]
		[Address(RVA = "0xD3BE98", Offset = "0xD3BE98", VA = "0xD3BE98")]
		public static extern int AudioEngine_setMasterReverbBypass(HandleRef jarg1, bool jarg2);

		[PreserveSig]
		[Token(Token = "0x6000304")]
		[Address(RVA = "0xD3BF28", Offset = "0xD3BF28", VA = "0xD3BF28")]
		public static extern bool AudioEngine_getMasterReverbBypass(HandleRef jarg1);

		[PreserveSig]
		[Token(Token = "0x6000305")]
		[Address(RVA = "0xD3BFB0", Offset = "0xD3BFB0", VA = "0xD3BFB0")]
		public static extern int AudioEngine_setMasterReverbWetLevel(HandleRef jarg1, float jarg2);

		[PreserveSig]
		[Token(Token = "0x6000306")]
		[Address(RVA = "0xD3C040", Offset = "0xD3C040", VA = "0xD3C040")]
		public static extern float AudioEngine_getMasterReverbWetLevel(HandleRef jarg1);

		[PreserveSig]
		[Token(Token = "0x6000307")]
		[Address(RVA = "0xD3C0C0", Offset = "0xD3C0C0", VA = "0xD3C0C0")]
		public static extern int AudioEngine_setMasterReverbRoomSize(HandleRef jarg1, float jarg2);

		[PreserveSig]
		[Token(Token = "0x6000308")]
		[Address(RVA = "0xD3C150", Offset = "0xD3C150", VA = "0xD3C150")]
		public static extern float AudioEngine_getMasterReverbRoomSize(HandleRef jarg1);

		[PreserveSig]
		[Token(Token = "0x6000309")]
		[Address(RVA = "0xD3C1D0", Offset = "0xD3C1D0", VA = "0xD3C1D0")]
		public static extern int AudioEngine_setMasterReverbDampening(HandleRef jarg1, float jarg2);

		[PreserveSig]
		[Token(Token = "0x600030A")]
		[Address(RVA = "0xD3C260", Offset = "0xD3C260", VA = "0xD3C260")]
		public static extern float AudioEngine_getMasterReverbDampening(HandleRef jarg1);

		[PreserveSig]
		[Token(Token = "0x600030B")]
		[Address(RVA = "0xD3C2E0", Offset = "0xD3C2E0", VA = "0xD3C2E0")]
		public static extern int AudioEngine_setMasterReverbWidth(HandleRef jarg1, float jarg2);

		[PreserveSig]
		[Token(Token = "0x600030C")]
		[Address(RVA = "0xD3C370", Offset = "0xD3C370", VA = "0xD3C370")]
		public static extern float AudioEngine_getMasterReverbWidth(HandleRef jarg1);

		[PreserveSig]
		[Token(Token = "0x600030D")]
		[Address(RVA = "0xD3C3F0", Offset = "0xD3C3F0", VA = "0xD3C3F0")]
		public static extern bool AudioEngine_saveGraph(HandleRef jarg1, string jarg2);

		[PreserveSig]
		[Token(Token = "0x600030E")]
		[Address(RVA = "0xD3C4A0", Offset = "0xD3C4A0", VA = "0xD3C4A0")]
		public static extern IntPtr AudioEngine_create__SWIG_0(HandleRef jarg1);

		[PreserveSig]
		[Token(Token = "0x600030F")]
		[Address(RVA = "0xD3C520", Offset = "0xD3C520", VA = "0xD3C520")]
		public static extern IntPtr AudioEngine_create__SWIG_1(float jarg1);

		[PreserveSig]
		[Token(Token = "0x6000310")]
		[Address(RVA = "0xD3C5A8", Offset = "0xD3C5A8", VA = "0xD3C5A8")]
		public static extern IntPtr AudioEngine_create__SWIG_2(float jarg1, int jarg2);

		[PreserveSig]
		[Token(Token = "0x6000311")]
		[Address(RVA = "0xD3C638", Offset = "0xD3C638", VA = "0xD3C638")]
		public static extern IntPtr AudioEngine_create__SWIG_3(float jarg1, int jarg2, int jarg3);

		[PreserveSig]
		[Token(Token = "0x6000312")]
		[Address(RVA = "0xD3C6D8", Offset = "0xD3C6D8", VA = "0xD3C6D8")]
		public static extern IntPtr AudioEngine_createSpatDecoderQueue__SWIG_0(HandleRef jarg1);

		[PreserveSig]
		[Token(Token = "0x6000313")]
		[Address(RVA = "0xD3C758", Offset = "0xD3C758", VA = "0xD3C758")]
		public static extern IntPtr AudioEngine_createSpatDecoderQueue__SWIG_1(HandleRef jarg1, int jarg2, int jarg3);

		[PreserveSig]
		[Token(Token = "0x6000314")]
		[Address(RVA = "0xD3C7F0", Offset = "0xD3C7F0", VA = "0xD3C7F0")]
		public static extern IntPtr AudioEngine_createSpatDecoderFile__SWIG_1(HandleRef jarg1);

		[PreserveSig]
		[Token(Token = "0x6000315")]
		[Address(RVA = "0xD3C870", Offset = "0xD3C870", VA = "0xD3C870")]
		public static extern IntPtr AudioEngine_createAudioObject__SWIG_1(HandleRef jarg1);

		[PreserveSig]
		[Token(Token = "0x6000316")]
		[Address(RVA = "0xD3C8F0", Offset = "0xD3C8F0", VA = "0xD3C8F0")]
		public static extern string AudioEngine_getName(HandleRef jarg1, IntPtr jarg2);

		[PreserveSig]
		[Token(Token = "0x6000317")]
		[Address(RVA = "0xD3C998", Offset = "0xD3C998", VA = "0xD3C998")]
		public static extern string AudioEngine_getMasterBusName(HandleRef jarg1);

		[PreserveSig]
		[Token(Token = "0x6000318")]
		[Address(RVA = "0xD3CA30", Offset = "0xD3CA30", VA = "0xD3CA30")]
		public static extern IntPtr AudioEngine_createEventTransport(HandleRef jarg1);

		[PreserveSig]
		[Token(Token = "0x6000319")]
		[Address(RVA = "0xD3CAB0", Offset = "0xD3CAB0", VA = "0xD3CAB0")]
		public static extern int TransportControl_play(HandleRef jarg1);

		[PreserveSig]
		[Token(Token = "0x600031A")]
		[Address(RVA = "0xD3CB30", Offset = "0xD3CB30", VA = "0xD3CB30")]
		public static extern int TransportControl_playScheduled__SWIG_0(HandleRef jarg1, float jarg2);

		[PreserveSig]
		[Token(Token = "0x600031B")]
		[Address(RVA = "0xD3CBC0", Offset = "0xD3CBC0", VA = "0xD3CBC0")]
		public static extern int TransportControl_playScheduled__SWIG_1(HandleRef jarg1, float jarg2, float jarg3);

		[PreserveSig]
		[Token(Token = "0x600031C")]
		[Address(RVA = "0xD3CC58", Offset = "0xD3CC58", VA = "0xD3CC58")]
		public static extern int TransportControl_playWithFade(HandleRef jarg1, float jarg2);

		[PreserveSig]
		[Token(Token = "0x600031D")]
		[Address(RVA = "0xD3CCE8", Offset = "0xD3CCE8", VA = "0xD3CCE8")]
		public static extern int TransportControl_pause(HandleRef jarg1);

		[PreserveSig]
		[Token(Token = "0x600031E")]
		[Address(RVA = "0xD3CD68", Offset = "0xD3CD68", VA = "0xD3CD68")]
		public static extern int TransportControl_pauseScheduled__SWIG_0(HandleRef jarg1, float jarg2);

		[PreserveSig]
		[Token(Token = "0x600031F")]
		[Address(RVA = "0xD3CDF8", Offset = "0xD3CDF8", VA = "0xD3CDF8")]
		public static extern int TransportControl_pauseScheduled__SWIG_1(HandleRef jarg1, float jarg2, float jarg3);

		[PreserveSig]
		[Token(Token = "0x6000320")]
		[Address(RVA = "0xD3CE90", Offset = "0xD3CE90", VA = "0xD3CE90")]
		public static extern int TransportControl_pauseWithFade(HandleRef jarg1, float jarg2);

		[PreserveSig]
		[Token(Token = "0x6000321")]
		[Address(RVA = "0xD3CF20", Offset = "0xD3CF20", VA = "0xD3CF20")]
		public static extern int TransportControl_stop(HandleRef jarg1);

		[PreserveSig]
		[Token(Token = "0x6000322")]
		[Address(RVA = "0xD3CFA0", Offset = "0xD3CFA0", VA = "0xD3CFA0")]
		public static extern int TransportControl_stopScheduled__SWIG_0(HandleRef jarg1, float jarg2);

		[PreserveSig]
		[Token(Token = "0x6000323")]
		[Address(RVA = "0xD3D030", Offset = "0xD3D030", VA = "0xD3D030")]
		public static extern int TransportControl_stopScheduled__SWIG_1(HandleRef jarg1, float jarg2, float jarg3);

		[PreserveSig]
		[Token(Token = "0x6000324")]
		[Address(RVA = "0xD3D0C8", Offset = "0xD3D0C8", VA = "0xD3D0C8")]
		public static extern int TransportControl_stopWithFade(HandleRef jarg1, float jarg2);

		[PreserveSig]
		[Token(Token = "0x6000325")]
		[Address(RVA = "0xD3D158", Offset = "0xD3D158", VA = "0xD3D158")]
		public static extern int TransportControl_getPlayState(HandleRef jarg1);

		[PreserveSig]
		[Token(Token = "0x6000326")]
		[Address(RVA = "0xD3D1D8", Offset = "0xD3D1D8", VA = "0xD3D1D8")]
		public static extern void TransportControl_cancelScheduledParams(HandleRef jarg1);

		[PreserveSig]
		[Token(Token = "0x6000327")]
		[Address(RVA = "0xD3D258", Offset = "0xD3D258", VA = "0xD3D258")]
		public static extern int Object3D_setPosition(HandleRef jarg1, HandleRef jarg2);

		[PreserveSig]
		[Token(Token = "0x6000328")]
		[Address(RVA = "0xD3D2E8", Offset = "0xD3D2E8", VA = "0xD3D2E8")]
		public static extern IntPtr Object3D_getPosition(HandleRef jarg1);

		[PreserveSig]
		[Token(Token = "0x6000329")]
		[Address(RVA = "0xD3D368", Offset = "0xD3D368", VA = "0xD3D368")]
		public static extern int Object3D_setRotation__SWIG_0(HandleRef jarg1, HandleRef jarg2);

		[PreserveSig]
		[Token(Token = "0x600032A")]
		[Address(RVA = "0xD3D3F8", Offset = "0xD3D3F8", VA = "0xD3D3F8")]
		public static extern int Object3D_setRotation__SWIG_1(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3);

		[PreserveSig]
		[Token(Token = "0x600032B")]
		[Address(RVA = "0xD3D490", Offset = "0xD3D490", VA = "0xD3D490")]
		public static extern IntPtr Object3D_getRotation(HandleRef jarg1);

		[PreserveSig]
		[Token(Token = "0x600032C")]
		[Address(RVA = "0xD3D510", Offset = "0xD3D510", VA = "0xD3D510")]
		public static extern void SpatDecoderInterface_enableFocus(HandleRef jarg1, bool jarg2, bool jarg3);

		[PreserveSig]
		[Token(Token = "0x600032D")]
		[Address(RVA = "0xD3D5A8", Offset = "0xD3D5A8", VA = "0xD3D5A8")]
		public static extern void SpatDecoderInterface_setFocusProperties(HandleRef jarg1, float jarg2, float jarg3);

		[PreserveSig]
		[Token(Token = "0x600032E")]
		[Address(RVA = "0xD3D640", Offset = "0xD3D640", VA = "0xD3D640")]
		public static extern void SpatDecoderInterface_setOffFocusLeveldB(HandleRef jarg1, float jarg2);

		[PreserveSig]
		[Token(Token = "0x600032F")]
		[Address(RVA = "0xD3D6D0", Offset = "0xD3D6D0", VA = "0xD3D6D0")]
		public static extern void SpatDecoderInterface_setFocusWidthDegrees(HandleRef jarg1, float jarg2);

		[PreserveSig]
		[Token(Token = "0x6000330")]
		[Address(RVA = "0xD3D760", Offset = "0xD3D760", VA = "0xD3D760")]
		public static extern void SpatDecoderInterface_setFocusOrientationQuat(HandleRef jarg1, HandleRef jarg2);

		[PreserveSig]
		[Token(Token = "0x6000331")]
		[Address(RVA = "0xD3D7F0", Offset = "0xD3D7F0", VA = "0xD3D7F0")]
		public static extern void SpatDecoderInterface_setVolume__SWIG_0(HandleRef jarg1, float jarg2, float jarg3, bool jarg4);

		[PreserveSig]
		[Token(Token = "0x6000332")]
		[Address(RVA = "0xD3D898", Offset = "0xD3D898", VA = "0xD3D898")]
		public static extern void SpatDecoderInterface_setVolume__SWIG_1(HandleRef jarg1, float jarg2, float jarg3);

		[PreserveSig]
		[Token(Token = "0x6000333")]
		[Address(RVA = "0xD3D930", Offset = "0xD3D930", VA = "0xD3D930")]
		public static extern void SpatDecoderInterface_setVolumeDecibels__SWIG_0(HandleRef jarg1, float jarg2, float jarg3, bool jarg4);

		[PreserveSig]
		[Token(Token = "0x6000334")]
		[Address(RVA = "0xD3D9D8", Offset = "0xD3D9D8", VA = "0xD3D9D8")]
		public static extern void SpatDecoderInterface_setVolumeDecibels__SWIG_1(HandleRef jarg1, float jarg2, float jarg3);

		[PreserveSig]
		[Token(Token = "0x6000335")]
		[Address(RVA = "0xD3DA70", Offset = "0xD3DA70", VA = "0xD3DA70")]
		public static extern float SpatDecoderInterface_getVolume(HandleRef jarg1);

		[PreserveSig]
		[Token(Token = "0x6000336")]
		[Address(RVA = "0xD3DAF0", Offset = "0xD3DAF0", VA = "0xD3DAF0")]
		public static extern float SpatDecoderInterface_getVolumeDecibels(HandleRef jarg1);

		[PreserveSig]
		[Token(Token = "0x6000337")]
		[Address(RVA = "0xD3DB70", Offset = "0xD3DB70", VA = "0xD3DB70")]
		public static extern int SpatDecoderInterface_setEventCallback(HandleRef jarg1, EventCallback jarg2, IntPtr jarg3);

		[PreserveSig]
		[Token(Token = "0x6000338")]
		[Address(RVA = "0xD3DC10", Offset = "0xD3DC10", VA = "0xD3DC10")]
		public static extern int SpatDecoderInterface_bypassReverbSend(HandleRef jarg1, bool jarg2);

		[PreserveSig]
		[Token(Token = "0x6000339")]
		[Address(RVA = "0xD3DCA0", Offset = "0xD3DCA0", VA = "0xD3DCA0")]
		public static extern bool SpatDecoderInterface_isReverbSendBypassed(HandleRef jarg1);

		[PreserveSig]
		[Token(Token = "0x600033A")]
		[Address(RVA = "0xD3DD28", Offset = "0xD3DD28", VA = "0xD3DD28")]
		public static extern int SpatDecoderInterface_setReverbSendLevel(HandleRef jarg1, float jarg2);

		[PreserveSig]
		[Token(Token = "0x600033B")]
		[Address(RVA = "0xD3DDB8", Offset = "0xD3DDB8", VA = "0xD3DDB8")]
		public static extern float SpatDecoderInterface_getReverbSendLevel(HandleRef jarg1);

		[PreserveSig]
		[Token(Token = "0x600033C")]
		[Address(RVA = "0xD3DE38", Offset = "0xD3DE38", VA = "0xD3DE38")]
		public static extern int SpatDecoderInterface_addEffectInsert(HandleRef jarg1, int jarg2, int jarg3);

		[PreserveSig]
		[Token(Token = "0x600033D")]
		[Address(RVA = "0xD3DED0", Offset = "0xD3DED0", VA = "0xD3DED0")]
		public static extern int SpatDecoderInterface_removeEffectInsert(HandleRef jarg1, int jarg2);

		[PreserveSig]
		[Token(Token = "0x600033E")]
		[Address(RVA = "0xD3DF60", Offset = "0xD3DF60", VA = "0xD3DF60")]
		public static extern int SpatDecoderInterface_bypassEffectInsert(HandleRef jarg1, int jarg2, bool jarg3);

		[PreserveSig]
		[Token(Token = "0x600033F")]
		[Address(RVA = "0xD3DFF8", Offset = "0xD3DFF8", VA = "0xD3DFF8")]
		public static extern int SpatDecoderInterface_setEffectInsertParam(HandleRef jarg1, int jarg2, int jarg3, float jarg4);

		[PreserveSig]
		[Token(Token = "0x6000340")]
		[Address(RVA = "0xD3E0A0", Offset = "0xD3E0A0", VA = "0xD3E0A0")]
		public static extern float SpatDecoderInterface_getEffectInsertParam(HandleRef jarg1, int jarg2, int jarg3);

		[PreserveSig]
		[Token(Token = "0x6000341")]
		[Address(RVA = "0xD3E138", Offset = "0xD3E138", VA = "0xD3E138")]
		public static extern bool SpatDecoderInterface_isEffectInsertActive(HandleRef jarg1, int jarg2);

		[PreserveSig]
		[Token(Token = "0x6000342")]
		[Address(RVA = "0xD3E1D0", Offset = "0xD3E1D0", VA = "0xD3E1D0")]
		public static extern bool SpatDecoderInterface_isEffectInsertBypassed(HandleRef jarg1, int jarg2);

		[PreserveSig]
		[Token(Token = "0x6000343")]
		[Address(RVA = "0xD3E268", Offset = "0xD3E268", VA = "0xD3E268")]
		public static extern int SpatDecoderInterface_getEffectType(HandleRef jarg1, int jarg2);

		[PreserveSig]
		[Token(Token = "0x6000344")]
		[Address(RVA = "0xD3E2F8", Offset = "0xD3E2F8", VA = "0xD3E2F8")]
		public static extern int NativeSpatDecoderQueue_getFreeSpaceInQueue(HandleRef jarg1, int jarg2);

		[PreserveSig]
		[Token(Token = "0x6000345")]
		[Address(RVA = "0xD3E388", Offset = "0xD3E388", VA = "0xD3E388")]
		public static extern int NativeSpatDecoderQueue_getQueueSize(HandleRef jarg1, int jarg2);

		[PreserveSig]
		[Token(Token = "0x6000346")]
		[Address(RVA = "0xD3E418", Offset = "0xD3E418", VA = "0xD3E418")]
		public static extern int NativeSpatDecoderQueue_enqueueData__SWIG_0(HandleRef jarg1, [In] float[] jarg2, int jarg3, int jarg4);

		[PreserveSig]
		[Token(Token = "0x6000347")]
		[Address(RVA = "0xD3E4C8", Offset = "0xD3E4C8", VA = "0xD3E4C8")]
		public static extern int NativeSpatDecoderQueue_enqueueData__SWIG_1(HandleRef jarg1, [In] short[] jarg2, int jarg3, int jarg4);

		[PreserveSig]
		[Token(Token = "0x6000348")]
		[Address(RVA = "0xD3E578", Offset = "0xD3E578", VA = "0xD3E578")]
		public static extern int NativeSpatDecoderQueue_enqueueSilence(HandleRef jarg1, int jarg2, int jarg3);

		[PreserveSig]
		[Token(Token = "0x6000349")]
		[Address(RVA = "0xD3E610", Offset = "0xD3E610", VA = "0xD3E610")]
		public static extern void NativeSpatDecoderQueue_flushQueue(HandleRef jarg1);

		[PreserveSig]
		[Token(Token = "0x600034A")]
		[Address(RVA = "0xD3E690", Offset = "0xD3E690", VA = "0xD3E690")]
		public static extern ulong NativeSpatDecoderQueue_getNumSamplesDequeuedPerChannel(HandleRef jarg1);

		[PreserveSig]
		[Token(Token = "0x600034B")]
		[Address(RVA = "0xD3E710", Offset = "0xD3E710", VA = "0xD3E710")]
		public static extern void NativeSpatDecoderQueue_setEndOfStream(HandleRef jarg1, bool jarg2);

		[PreserveSig]
		[Token(Token = "0x600034C")]
		[Address(RVA = "0xD3E7A0", Offset = "0xD3E7A0", VA = "0xD3E7A0")]
		public static extern bool NativeSpatDecoderQueue_getEndOfStreamStatus(HandleRef jarg1);

		[PreserveSig]
		[Token(Token = "0x600034D")]
		[Address(RVA = "0xD3E828", Offset = "0xD3E828", VA = "0xD3E828")]
		public static extern int NativeSpatDecoderFile_open__SWIG_0(HandleRef jarg1, string jarg2, int jarg3);

		[PreserveSig]
		[Token(Token = "0x600034E")]
		[Address(RVA = "0xD3E8DC", Offset = "0xD3E8DC", VA = "0xD3E8DC")]
		public static extern int NativeSpatDecoderFile_open__SWIG_1(HandleRef jarg1, string jarg2);

		[PreserveSig]
		[Token(Token = "0x600034F")]
		[Address(RVA = "0xD3E988", Offset = "0xD3E988", VA = "0xD3E988")]
		public static extern int NativeSpatDecoderFile_open__SWIG_2(HandleRef jarg1, string jarg2, HandleRef jarg3, int jarg4);

		[PreserveSig]
		[Token(Token = "0x6000350")]
		[Address(RVA = "0xD3EA4C", Offset = "0xD3EA4C", VA = "0xD3EA4C")]
		public static extern int NativeSpatDecoderFile_open__SWIG_3(HandleRef jarg1, string jarg2, HandleRef jarg3);

		[PreserveSig]
		[Token(Token = "0x6000351")]
		[Address(RVA = "0xD3EB00", Offset = "0xD3EB00", VA = "0xD3EB00")]
		public static extern void NativeSpatDecoderFile_close(HandleRef jarg1);

		[PreserveSig]
		[Token(Token = "0x6000352")]
		[Address(RVA = "0xD3EB80", Offset = "0xD3EB80", VA = "0xD3EB80")]
		public static extern bool NativeSpatDecoderFile_isOpen(HandleRef jarg1);

		[PreserveSig]
		[Token(Token = "0x6000353")]
		[Address(RVA = "0xD3EC08", Offset = "0xD3EC08", VA = "0xD3EC08")]
		public static extern int NativeSpatDecoderFile_seekToSample(HandleRef jarg1, uint jarg2);

		[PreserveSig]
		[Token(Token = "0x6000354")]
		[Address(RVA = "0xD3EC98", Offset = "0xD3EC98", VA = "0xD3EC98")]
		public static extern int NativeSpatDecoderFile_seekToMs(HandleRef jarg1, float jarg2);

		[PreserveSig]
		[Token(Token = "0x6000355")]
		[Address(RVA = "0xD3ED28", Offset = "0xD3ED28", VA = "0xD3ED28")]
		public static extern uint NativeSpatDecoderFile_getElapsedTimeInSamples(HandleRef jarg1);

		[PreserveSig]
		[Token(Token = "0x6000356")]
		[Address(RVA = "0xD3EDA8", Offset = "0xD3EDA8", VA = "0xD3EDA8")]
		public static extern double NativeSpatDecoderFile_getElapsedTimeInMs(HandleRef jarg1);

		[PreserveSig]
		[Token(Token = "0x6000357")]
		[Address(RVA = "0xD3EE28", Offset = "0xD3EE28", VA = "0xD3EE28")]
		public static extern uint NativeSpatDecoderFile_getAssetDurationInSamples(HandleRef jarg1);

		[PreserveSig]
		[Token(Token = "0x6000358")]
		[Address(RVA = "0xD3EEA8", Offset = "0xD3EEA8", VA = "0xD3EEA8")]
		public static extern float NativeSpatDecoderFile_getAssetDurationInMs(HandleRef jarg1);

		[PreserveSig]
		[Token(Token = "0x6000359")]
		[Address(RVA = "0xD3EF28", Offset = "0xD3EF28", VA = "0xD3EF28")]
		public static extern void NativeSpatDecoderFile_setSyncMode(HandleRef jarg1, int jarg2);

		[PreserveSig]
		[Token(Token = "0x600035A")]
		[Address(RVA = "0xD3EFB8", Offset = "0xD3EFB8", VA = "0xD3EFB8")]
		public static extern int NativeSpatDecoderFile_getSyncMode(HandleRef jarg1);

		[PreserveSig]
		[Token(Token = "0x600035B")]
		[Address(RVA = "0xD3F038", Offset = "0xD3F038", VA = "0xD3F038")]
		public static extern void NativeSpatDecoderFile_setExternalClockInMs(HandleRef jarg1, double jarg2);

		[PreserveSig]
		[Token(Token = "0x600035C")]
		[Address(RVA = "0xD3F0C8", Offset = "0xD3F0C8", VA = "0xD3F0C8")]
		public static extern void NativeSpatDecoderFile_setFreewheelTimeInMs(HandleRef jarg1, double jarg2);

		[PreserveSig]
		[Token(Token = "0x600035D")]
		[Address(RVA = "0xD3F158", Offset = "0xD3F158", VA = "0xD3F158")]
		public static extern double NativeSpatDecoderFile_getFreewheelTimeInMs(HandleRef jarg1);

		[PreserveSig]
		[Token(Token = "0x600035E")]
		[Address(RVA = "0xD3F1D8", Offset = "0xD3F1D8", VA = "0xD3F1D8")]
		public static extern void NativeSpatDecoderFile_setResyncThresholdMs(HandleRef jarg1, double jarg2);

		[PreserveSig]
		[Token(Token = "0x600035F")]
		[Address(RVA = "0xD3F268", Offset = "0xD3F268", VA = "0xD3F268")]
		public static extern double NativeSpatDecoderFile_getResyncThresholdMs(HandleRef jarg1);

		[PreserveSig]
		[Token(Token = "0x6000360")]
		[Address(RVA = "0xD3F2E8", Offset = "0xD3F2E8", VA = "0xD3F2E8")]
		public static extern void NativeSpatDecoderFile_applyVolumeFade(HandleRef jarg1, float jarg2, float jarg3, float jarg4);

		[PreserveSig]
		[Token(Token = "0x6000361")]
		[Address(RVA = "0xD3F390", Offset = "0xD3F390", VA = "0xD3F390")]
		public static extern void NativeSpatDecoderFile_enableLooping(HandleRef jarg1, bool jarg2);

		[PreserveSig]
		[Token(Token = "0x6000362")]
		[Address(RVA = "0xD3F420", Offset = "0xD3F420", VA = "0xD3F420")]
		public static extern bool NativeSpatDecoderFile_loopingEnabled(HandleRef jarg1);

		[PreserveSig]
		[Token(Token = "0x6000363")]
		[Address(RVA = "0xD3F4A8", Offset = "0xD3F4A8", VA = "0xD3F4A8")]
		public static extern int NativeSpatDecoderFile_open__SWIG_4(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, bool jarg4, int jarg5);

		[PreserveSig]
		[Token(Token = "0x6000364")]
		[Address(RVA = "0xD3F558", Offset = "0xD3F558", VA = "0xD3F558")]
		public static extern int NativeAudioObject_setAudioBufferCallback(HandleRef jarg1, AudioObjectBufferCallback jarg2, uint jarg3, int jarg4, IntPtr jarg5);

		[PreserveSig]
		[Token(Token = "0x6000365")]
		[Address(RVA = "0xD3F610", Offset = "0xD3F610", VA = "0xD3F610")]
		public static extern int NativeAudioObject_open__SWIG_0(HandleRef jarg1, string jarg2);

		[PreserveSig]
		[Token(Token = "0x6000366")]
		[Address(RVA = "0xD3F6BC", Offset = "0xD3F6BC", VA = "0xD3F6BC")]
		public static extern int NativeAudioObject_open__SWIG_1(HandleRef jarg1, string jarg2, HandleRef jarg3);

		[PreserveSig]
		[Token(Token = "0x6000367")]
		[Address(RVA = "0xD3F770", Offset = "0xD3F770", VA = "0xD3F770")]
		public static extern int NativeAudioObject_open__SWIG_2(HandleRef jarg1, HandleRef jarg2, bool jarg3);

		[PreserveSig]
		[Token(Token = "0x6000368")]
		[Address(RVA = "0xD3F808", Offset = "0xD3F808", VA = "0xD3F808")]
		public static extern int NativeAudioObject_open__SWIG_3(HandleRef jarg1, HandleRef jarg2);

		[PreserveSig]
		[Token(Token = "0x6000369")]
		[Address(RVA = "0xD3F898", Offset = "0xD3F898", VA = "0xD3F898")]
		public static extern void NativeAudioObject_close(HandleRef jarg1);

		[PreserveSig]
		[Token(Token = "0x600036A")]
		[Address(RVA = "0xD3F918", Offset = "0xD3F918", VA = "0xD3F918")]
		public static extern bool NativeAudioObject_isOpen(HandleRef jarg1);

		[PreserveSig]
		[Token(Token = "0x600036B")]
		[Address(RVA = "0xD3F9A0", Offset = "0xD3F9A0", VA = "0xD3F9A0")]
		public static extern int NativeAudioObject_seekToSample(HandleRef jarg1, uint jarg2);

		[PreserveSig]
		[Token(Token = "0x600036C")]
		[Address(RVA = "0xD3FA30", Offset = "0xD3FA30", VA = "0xD3FA30")]
		public static extern int NativeAudioObject_seekToMs(HandleRef jarg1, float jarg2);

		[PreserveSig]
		[Token(Token = "0x600036D")]
		[Address(RVA = "0xD3FAC0", Offset = "0xD3FAC0", VA = "0xD3FAC0")]
		public static extern uint NativeAudioObject_getElapsedTimeInSamples(HandleRef jarg1);

		[PreserveSig]
		[Token(Token = "0x600036E")]
		[Address(RVA = "0xD3FB40", Offset = "0xD3FB40", VA = "0xD3FB40")]
		public static extern double NativeAudioObject_getElapsedTimeInMs(HandleRef jarg1);

		[PreserveSig]
		[Token(Token = "0x600036F")]
		[Address(RVA = "0xD3FBC0", Offset = "0xD3FBC0", VA = "0xD3FBC0")]
		public static extern uint NativeAudioObject_getAssetDurationInSamples(HandleRef jarg1);

		[PreserveSig]
		[Token(Token = "0x6000370")]
		[Address(RVA = "0xD3FC40", Offset = "0xD3FC40", VA = "0xD3FC40")]
		public static extern float NativeAudioObject_getAssetDurationInMs(HandleRef jarg1);

		[PreserveSig]
		[Token(Token = "0x6000371")]
		[Address(RVA = "0xD3FCC0", Offset = "0xD3FCC0", VA = "0xD3FCC0")]
		public static extern int NativeAudioObject_setEventCallback(HandleRef jarg1, EventCallback jarg2, IntPtr jarg3);

		[PreserveSig]
		[Token(Token = "0x6000372")]
		[Address(RVA = "0xD3FD60", Offset = "0xD3FD60", VA = "0xD3FD60")]
		public static extern void NativeAudioObject_shouldSpatialise(HandleRef jarg1, bool jarg2);

		[PreserveSig]
		[Token(Token = "0x6000373")]
		[Address(RVA = "0xD3FDF0", Offset = "0xD3FDF0", VA = "0xD3FDF0")]
		public static extern bool NativeAudioObject_isSpatialised(HandleRef jarg1);

		[PreserveSig]
		[Token(Token = "0x6000374")]
		[Address(RVA = "0xD3FE78", Offset = "0xD3FE78", VA = "0xD3FE78")]
		public static extern void NativeAudioObject_overrideRanking(HandleRef jarg1, bool jarg2);

		[PreserveSig]
		[Token(Token = "0x6000375")]
		[Address(RVA = "0xD3FF08", Offset = "0xD3FF08", VA = "0xD3FF08")]
		public static extern int NativeAudioObject_setSpatialisationType(HandleRef jarg1, int jarg2);

		[PreserveSig]
		[Token(Token = "0x6000376")]
		[Address(RVA = "0xD3FF98", Offset = "0xD3FF98", VA = "0xD3FF98")]
		public static extern int NativeAudioObject_getSpatialisationType(HandleRef jarg1);

		[PreserveSig]
		[Token(Token = "0x6000377")]
		[Address(RVA = "0xD40018", Offset = "0xD40018", VA = "0xD40018")]
		public static extern bool NativeAudioObject_enableLooping(HandleRef jarg1, bool jarg2);

		[PreserveSig]
		[Token(Token = "0x6000378")]
		[Address(RVA = "0xD400B0", Offset = "0xD400B0", VA = "0xD400B0")]
		public static extern bool NativeAudioObject_loopingEnabled(HandleRef jarg1);

		[PreserveSig]
		[Token(Token = "0x6000379")]
		[Address(RVA = "0xD40138", Offset = "0xD40138", VA = "0xD40138")]
		public static extern void NativeAudioObject_setAttenuationMode(HandleRef jarg1, int jarg2);

		[PreserveSig]
		[Token(Token = "0x600037A")]
		[Address(RVA = "0xD401C8", Offset = "0xD401C8", VA = "0xD401C8")]
		public static extern int NativeAudioObject_getAttenuationMode(HandleRef jarg1);

		[PreserveSig]
		[Token(Token = "0x600037B")]
		[Address(RVA = "0xD40248", Offset = "0xD40248", VA = "0xD40248")]
		public static extern void NativeAudioObject_setAttenuationProperties(HandleRef jarg1, HandleRef jarg2);

		[PreserveSig]
		[Token(Token = "0x600037C")]
		[Address(RVA = "0xD402D8", Offset = "0xD402D8", VA = "0xD402D8")]
		public static extern IntPtr NativeAudioObject_getAttenuationProperties(HandleRef jarg1);

		[PreserveSig]
		[Token(Token = "0x600037D")]
		[Address(RVA = "0xD40358", Offset = "0xD40358", VA = "0xD40358")]
		public static extern void NativeAudioObject_setDirectionalityEnabled(HandleRef jarg1, bool jarg2);

		[PreserveSig]
		[Token(Token = "0x600037E")]
		[Address(RVA = "0xD403E8", Offset = "0xD403E8", VA = "0xD403E8")]
		public static extern bool NativeAudioObject_isDirectionalityEnabled(HandleRef jarg1);

		[PreserveSig]
		[Token(Token = "0x600037F")]
		[Address(RVA = "0xD40470", Offset = "0xD40470", VA = "0xD40470")]
		public static extern void NativeAudioObject_setDirectionalProperties(HandleRef jarg1, HandleRef jarg2);

		[PreserveSig]
		[Token(Token = "0x6000380")]
		[Address(RVA = "0xD40500", Offset = "0xD40500", VA = "0xD40500")]
		public static extern IntPtr NativeAudioObject_getDirectionalProperties(HandleRef jarg1);

		[PreserveSig]
		[Token(Token = "0x6000381")]
		[Address(RVA = "0xD40580", Offset = "0xD40580", VA = "0xD40580")]
		public static extern void NativeAudioObject_setPitch(HandleRef jarg1, float jarg2);

		[PreserveSig]
		[Token(Token = "0x6000382")]
		[Address(RVA = "0xD40610", Offset = "0xD40610", VA = "0xD40610")]
		public static extern float NativeAudioObject_getPitch(HandleRef jarg1);

		[PreserveSig]
		[Token(Token = "0x6000383")]
		[Address(RVA = "0xD40690", Offset = "0xD40690", VA = "0xD40690")]
		public static extern IntPtr NativeAudioObject_createEffect(HandleRef jarg1, int jarg2);

		[PreserveSig]
		[Token(Token = "0x6000384")]
		[Address(RVA = "0xD40720", Offset = "0xD40720", VA = "0xD40720")]
		public static extern void NativeAudioObject_destroyEffect(HandleRef jarg1, IntPtr jarg2);

		[PreserveSig]
		[Token(Token = "0x6000385")]
		[Address(RVA = "0xD407B0", Offset = "0xD407B0", VA = "0xD407B0")]
		public static extern int NativeAudioObject_getEffectTypeForHandle(HandleRef jarg1, IntPtr jarg2);

		[PreserveSig]
		[Token(Token = "0x6000386")]
		[Address(RVA = "0xD40840", Offset = "0xD40840", VA = "0xD40840")]
		public static extern int NativeAudioObject_setEffectType(HandleRef jarg1, IntPtr jarg2, int jarg3);

		[PreserveSig]
		[Token(Token = "0x6000387")]
		[Address(RVA = "0xD408D8", Offset = "0xD408D8", VA = "0xD408D8")]
		public static extern int NativeAudioObject_bypassEffect(HandleRef jarg1, IntPtr jarg2, bool jarg3);

		[PreserveSig]
		[Token(Token = "0x6000388")]
		[Address(RVA = "0xD40970", Offset = "0xD40970", VA = "0xD40970")]
		public static extern bool NativeAudioObject_isEffectBypassed(HandleRef jarg1, IntPtr jarg2);

		[PreserveSig]
		[Token(Token = "0x6000389")]
		[Address(RVA = "0xD40A08", Offset = "0xD40A08", VA = "0xD40A08")]
		public static extern int NativeAudioObject_setEffectParam(HandleRef jarg1, IntPtr jarg2, int jarg3, float jarg4);

		[PreserveSig]
		[Token(Token = "0x600038A")]
		[Address(RVA = "0xD40AB0", Offset = "0xD40AB0", VA = "0xD40AB0")]
		public static extern float NativeAudioObject_getEffectParam(HandleRef jarg1, IntPtr jarg2, int jarg3);

		[PreserveSig]
		[Token(Token = "0x600038B")]
		[Address(RVA = "0xD40B48", Offset = "0xD40B48", VA = "0xD40B48")]
		public static extern uint NativeAudioObject_getNumberOfEffects(HandleRef jarg1);

		[PreserveSig]
		[Token(Token = "0x600038C")]
		[Address(RVA = "0xD40BC8", Offset = "0xD40BC8", VA = "0xD40BC8")]
		public static extern IntPtr NativeAudioObject_getEffect(HandleRef jarg1, uint jarg2);

		[PreserveSig]
		[Token(Token = "0x600038D")]
		[Address(RVA = "0xD40C58", Offset = "0xD40C58", VA = "0xD40C58")]
		public static extern IntPtr NativeAudioObject_getOutputBus(HandleRef jarg1);

		[PreserveSig]
		[Token(Token = "0x600038E")]
		[Address(RVA = "0xD40CD8", Offset = "0xD40CD8", VA = "0xD40CD8")]
		public static extern void delete_AudioResampler(HandleRef jarg1);

		[PreserveSig]
		[Token(Token = "0x600038F")]
		[Address(RVA = "0xD40D58", Offset = "0xD40D58", VA = "0xD40D58")]
		public static extern uint AudioResampler_process(HandleRef jarg1, [In] float[] jarg2, uint jarg3, [In] float[] jarg4, uint jarg5, bool jarg6);

		[PreserveSig]
		[Token(Token = "0x6000390")]
		[Address(RVA = "0xD40E28", Offset = "0xD40E28", VA = "0xD40E28")]
		public static extern int AudioResampler_getNumChannels(HandleRef jarg1);

		[PreserveSig]
		[Token(Token = "0x6000391")]
		[Address(RVA = "0xD40EA8", Offset = "0xD40EA8", VA = "0xD40EA8")]
		public static extern float AudioResampler_getInputSampleRate(HandleRef jarg1);

		[PreserveSig]
		[Token(Token = "0x6000392")]
		[Address(RVA = "0xD40F28", Offset = "0xD40F28", VA = "0xD40F28")]
		public static extern float AudioResampler_getOutputSampleRate(HandleRef jarg1);

		[PreserveSig]
		[Token(Token = "0x6000393")]
		[Address(RVA = "0xD40FA8", Offset = "0xD40FA8", VA = "0xD40FA8")]
		public static extern int AudioResampler_getQuality(HandleRef jarg1);

		[PreserveSig]
		[Token(Token = "0x6000394")]
		[Address(RVA = "0xD41028", Offset = "0xD41028", VA = "0xD41028")]
		public static extern void AudioResampler_setRatio(HandleRef jarg1, double jarg2);

		[PreserveSig]
		[Token(Token = "0x6000395")]
		[Address(RVA = "0xD410B8", Offset = "0xD410B8", VA = "0xD410B8")]
		public static extern double AudioResampler_getRatio(HandleRef jarg1);

		[PreserveSig]
		[Token(Token = "0x6000396")]
		[Address(RVA = "0xD41138", Offset = "0xD41138", VA = "0xD41138")]
		public static extern void AudioResampler_reset(HandleRef jarg1);

		[PreserveSig]
		[Token(Token = "0x6000397")]
		[Address(RVA = "0xD411B8", Offset = "0xD411B8", VA = "0xD411B8")]
		public static extern IntPtr AudioResampler_create(uint jarg1, float jarg2, float jarg3, uint jarg4, int jarg5);

		[PreserveSig]
		[Token(Token = "0x6000398")]
		[Address(RVA = "0xD41268", Offset = "0xD41268", VA = "0xD41268")]
		public static extern void delete_AudioFormatEncoder(HandleRef jarg1);

		[PreserveSig]
		[Token(Token = "0x6000399")]
		[Address(RVA = "0xD412E8", Offset = "0xD412E8", VA = "0xD412E8")]
		public static extern uint AudioFormatEncoder_encode(HandleRef jarg1, [In] float[] jarg2, uint jarg3, bool jarg4);

		[PreserveSig]
		[Token(Token = "0x600039A")]
		[Address(RVA = "0xD41398", Offset = "0xD41398", VA = "0xD41398")]
		public static extern int AudioFormatEncoder_getAudioFormat(HandleRef jarg1);

		[PreserveSig]
		[Token(Token = "0x600039B")]
		[Address(RVA = "0xD41418", Offset = "0xD41418", VA = "0xD41418")]
		public static extern int AudioFormatEncoder_getQualityIndex(HandleRef jarg1, ref int jarg2);

		[PreserveSig]
		[Token(Token = "0x600039C")]
		[Address(RVA = "0xD414A8", Offset = "0xD414A8", VA = "0xD414A8")]
		public static extern int AudioFormatEncoder_getBitRate(HandleRef jarg1, ref int jarg2);

		[PreserveSig]
		[Token(Token = "0x600039D")]
		[Address(RVA = "0xD41538", Offset = "0xD41538", VA = "0xD41538")]
		public static extern float AudioFormatEncoder_getOutputSampleRate(HandleRef jarg1);

		[PreserveSig]
		[Token(Token = "0x600039E")]
		[Address(RVA = "0xD415B8", Offset = "0xD415B8", VA = "0xD415B8")]
		public static extern int AudioFormatEncoder_getNumOfChannels(HandleRef jarg1);

		[PreserveSig]
		[Token(Token = "0x600039F")]
		[Address(RVA = "0xD41638", Offset = "0xD41638", VA = "0xD41638")]
		public static extern uint AudioFormatEncoder_getMaxBufferSize(HandleRef jarg1);

		[PreserveSig]
		[Token(Token = "0x60003A0")]
		[Address(RVA = "0xD416B8", Offset = "0xD416B8", VA = "0xD416B8")]
		public static extern int AudioFormatEncoder_getBitRateForQualityIndex(int jarg1, int jarg2, ref int jarg3);

		[PreserveSig]
		[Token(Token = "0x60003A1")]
		[Address(RVA = "0xD41750", Offset = "0xD41750", VA = "0xD41750")]
		public static extern int AudioFormatEncoder_getIndexForQuality(int jarg1, int jarg2, ref int jarg3);

		[PreserveSig]
		[Token(Token = "0x60003A2")]
		[Address(RVA = "0xD417E8", Offset = "0xD417E8", VA = "0xD417E8")]
		public static extern IntPtr AudioFormatEncoder_create(HandleRef jarg1, int jarg2, float jarg3, float jarg4, uint jarg5, int jarg6, int jarg7);

		[PreserveSig]
		[Token(Token = "0x60003A3")]
		[Address(RVA = "0xD33940", Offset = "0xD33940", VA = "0xD33940")]
		public static extern uint IOSTREAM_OPERATION_FAIL_get();

		[PreserveSig]
		[Token(Token = "0x60003A4")]
		[Address(RVA = "0xD418B0", Offset = "0xD418B0", VA = "0xD418B0")]
		public static extern void delete_IOStream(HandleRef jarg1);

		[PreserveSig]
		[Token(Token = "0x60003A5")]
		[Address(RVA = "0xD41930", Offset = "0xD41930", VA = "0xD41930")]
		public static extern uint IOStream_getPosition(HandleRef jarg1);

		[PreserveSig]
		[Token(Token = "0x60003A6")]
		[Address(RVA = "0xD419B0", Offset = "0xD419B0", VA = "0xD419B0")]
		public static extern bool IOStream_setPosition__SWIG_0(HandleRef jarg1, long jarg2);

		[PreserveSig]
		[Token(Token = "0x60003A7")]
		[Address(RVA = "0xD41A48", Offset = "0xD41A48", VA = "0xD41A48")]
		public static extern bool IOStream_setPosition__SWIG_1(HandleRef jarg1, long jarg2, int jarg3);

		[PreserveSig]
		[Token(Token = "0x60003A8")]
		[Address(RVA = "0xD41AE8", Offset = "0xD41AE8", VA = "0xD41AE8")]
		public static extern int IOStream_pushBackByte(HandleRef jarg1, int jarg2);

		[PreserveSig]
		[Token(Token = "0x60003A9")]
		[Address(RVA = "0xD41B78", Offset = "0xD41B78", VA = "0xD41B78")]
		public static extern uint IOStream_getSize(HandleRef jarg1);

		[PreserveSig]
		[Token(Token = "0x60003AA")]
		[Address(RVA = "0xD41BF8", Offset = "0xD41BF8", VA = "0xD41BF8")]
		public static extern bool IOStream_canSeek(HandleRef jarg1);

		[PreserveSig]
		[Token(Token = "0x60003AB")]
		[Address(RVA = "0xD41C80", Offset = "0xD41C80", VA = "0xD41C80")]
		public static extern bool IOStream_ready(HandleRef jarg1);

		[PreserveSig]
		[Token(Token = "0x60003AC")]
		[Address(RVA = "0xD41D08", Offset = "0xD41D08", VA = "0xD41D08")]
		public static extern bool IOStream_endOfStream(HandleRef jarg1);

		[PreserveSig]
		[Token(Token = "0x60003AD")]
		[Address(RVA = "0xD41D90", Offset = "0xD41D90", VA = "0xD41D90")]
		public static extern int IOStream_getFD(HandleRef jarg1);

		[PreserveSig]
		[Token(Token = "0x60003AE")]
		[Address(RVA = "0xD41E10", Offset = "0xD41E10", VA = "0xD41E10")]
		public static extern IntPtr IOStream_createFileStream__SWIG_0(string jarg1, int jarg2, HandleRef jarg3);

		[PreserveSig]
		[Token(Token = "0x60003AF")]
		[Address(RVA = "0xD41EC0", Offset = "0xD41EC0", VA = "0xD41EC0")]
		public static extern IntPtr IOStream_createFileStream__SWIG_1(string jarg1, int jarg2);

		[PreserveSig]
		[Token(Token = "0x60003B0")]
		[Address(RVA = "0xD41F68", Offset = "0xD41F68", VA = "0xD41F68")]
		public static extern IntPtr IOStream_createMemoryStream__SWIG_0(IntPtr jarg1, uint jarg2, uint jarg3);

		[PreserveSig]
		[Token(Token = "0x60003B1")]
		[Address(RVA = "0xD42000", Offset = "0xD42000", VA = "0xD42000")]
		public static extern IntPtr IOStream_createMemoryStream__SWIG_1(IntPtr jarg1, uint jarg2);

		[PreserveSig]
		[Token(Token = "0x60003B2")]
		[Address(RVA = "0xD42090", Offset = "0xD42090", VA = "0xD42090")]
		public static extern uint IOStream_read(HandleRef jarg1, [In] byte[] jarg2, uint jarg3);

		[PreserveSig]
		[Token(Token = "0x60003B3")]
		[Address(RVA = "0xD42130", Offset = "0xD42130", VA = "0xD42130")]
		public static extern uint IOStream_write(HandleRef jarg1, [In] byte[] jarg2, uint jarg3);

		[PreserveSig]
		[Token(Token = "0x60003B4")]
		[Address(RVA = "0xD33A10", Offset = "0xD33A10", VA = "0xD33A10")]
		public static extern uint uninitializedHandle_get();

		[PreserveSig]
		[Token(Token = "0x60003B5")]
		[Address(RVA = "0xD421D0", Offset = "0xD421D0", VA = "0xD421D0")]
		public static extern void AudioAssetHandle_index_set(HandleRef jarg1, uint jarg2);

		[PreserveSig]
		[Token(Token = "0x60003B6")]
		[Address(RVA = "0xD42260", Offset = "0xD42260", VA = "0xD42260")]
		public static extern uint AudioAssetHandle_index_get(HandleRef jarg1);

		[PreserveSig]
		[Token(Token = "0x60003B7")]
		[Address(RVA = "0xD422E0", Offset = "0xD422E0", VA = "0xD422E0")]
		public static extern void AudioAssetHandle_id_set(HandleRef jarg1, uint jarg2);

		[PreserveSig]
		[Token(Token = "0x60003B8")]
		[Address(RVA = "0xD42370", Offset = "0xD42370", VA = "0xD42370")]
		public static extern uint AudioAssetHandle_id_get(HandleRef jarg1);

		[PreserveSig]
		[Token(Token = "0x60003B9")]
		[Address(RVA = "0xD423F0", Offset = "0xD423F0", VA = "0xD423F0")]
		public static extern IntPtr new_AudioAssetHandle();

		[PreserveSig]
		[Token(Token = "0x60003BA")]
		[Address(RVA = "0xD42464", Offset = "0xD42464", VA = "0xD42464")]
		public static extern void delete_AudioAssetHandle(HandleRef jarg1);

		[PreserveSig]
		[Token(Token = "0x60003BB")]
		[Address(RVA = "0xD33B24", Offset = "0xD33B24", VA = "0xD33B24")]
		public static extern IntPtr InvalidAudioAssetHandle_get();

		[PreserveSig]
		[Token(Token = "0x60003BC")]
		[Address(RVA = "0xD424E4", Offset = "0xD424E4", VA = "0xD424E4")]
		public static extern void delete_AudioAssetManager(HandleRef jarg1);

		[PreserveSig]
		[Token(Token = "0x60003BD")]
		[Address(RVA = "0xD42564", Offset = "0xD42564", VA = "0xD42564")]
		public static extern int AudioAssetManager_loadAudio(HandleRef jarg1, HandleRef jarg2, string jarg3, HandleRef jarg4, int jarg5);

		[PreserveSig]
		[Token(Token = "0x60003BE")]
		[Address(RVA = "0xD42630", Offset = "0xD42630", VA = "0xD42630")]
		public static extern IntPtr AudioAssetManager_getNewStream(HandleRef jarg1, HandleRef jarg2);

		[PreserveSig]
		[Token(Token = "0x60003BF")]
		[Address(RVA = "0xD426C0", Offset = "0xD426C0", VA = "0xD426C0")]
		public static extern IntPtr AudioAssetManager_getNewDecoder(HandleRef jarg1, HandleRef jarg2, int jarg3, float jarg4);

		[PreserveSig]
		[Token(Token = "0x60003C0")]
		[Address(RVA = "0xD42768", Offset = "0xD42768", VA = "0xD42768")]
		public static extern bool AudioAssetManager_unloadAudio(HandleRef jarg1, HandleRef jarg2);

		[PreserveSig]
		[Token(Token = "0x60003C1")]
		[Address(RVA = "0xD42800", Offset = "0xD42800", VA = "0xD42800")]
		public static extern int AudioAssetManager_getMode(HandleRef jarg1, HandleRef jarg2);

		[PreserveSig]
		[Token(Token = "0x60003C2")]
		[Address(RVA = "0xD42890", Offset = "0xD42890", VA = "0xD42890")]
		public static extern string AudioAssetManager_getFormat(HandleRef jarg1, HandleRef jarg2);

		[PreserveSig]
		[Token(Token = "0x60003C3")]
		[Address(RVA = "0xD42938", Offset = "0xD42938", VA = "0xD42938")]
		public static extern uint AudioAssetManager_getBytesInMemory(HandleRef jarg1);

		[PreserveSig]
		[Token(Token = "0x60003C4")]
		[Address(RVA = "0xD429B8", Offset = "0xD429B8", VA = "0xD429B8")]
		public static extern void delete_AudioFormatDecoder(HandleRef jarg1);

		[PreserveSig]
		[Token(Token = "0x60003C5")]
		[Address(RVA = "0xD42A38", Offset = "0xD42A38", VA = "0xD42A38")]
		public static extern int AudioFormatDecoder_getNumOfChannels(HandleRef jarg1);

		[PreserveSig]
		[Token(Token = "0x60003C6")]
		[Address(RVA = "0xD42AB8", Offset = "0xD42AB8", VA = "0xD42AB8")]
		public static extern uint AudioFormatDecoder_getNumTotalSamples(HandleRef jarg1);

		[PreserveSig]
		[Token(Token = "0x60003C7")]
		[Address(RVA = "0xD42B38", Offset = "0xD42B38", VA = "0xD42B38")]
		public static extern uint AudioFormatDecoder_getNumSamplesPerChannel(HandleRef jarg1);

		[PreserveSig]
		[Token(Token = "0x60003C8")]
		[Address(RVA = "0xD42BB8", Offset = "0xD42BB8", VA = "0xD42BB8")]
		public static extern double AudioFormatDecoder_getMsPerChannel(HandleRef jarg1);

		[PreserveSig]
		[Token(Token = "0x60003C9")]
		[Address(RVA = "0xD42C38", Offset = "0xD42C38", VA = "0xD42C38")]
		public static extern uint AudioFormatDecoder_getSamplePosition(HandleRef jarg1);

		[PreserveSig]
		[Token(Token = "0x60003CA")]
		[Address(RVA = "0xD42CB8", Offset = "0xD42CB8", VA = "0xD42CB8")]
		public static extern int AudioFormatDecoder_seekToSample(HandleRef jarg1, uint jarg2);

		[PreserveSig]
		[Token(Token = "0x60003CB")]
		[Address(RVA = "0xD42D48", Offset = "0xD42D48", VA = "0xD42D48")]
		public static extern uint AudioFormatDecoder_decode(HandleRef jarg1, [In] float[] jarg2, int jarg3);

		[PreserveSig]
		[Token(Token = "0x60003CC")]
		[Address(RVA = "0xD42DE8", Offset = "0xD42DE8", VA = "0xD42DE8")]
		public static extern float AudioFormatDecoder_getSampleRate(HandleRef jarg1);

		[PreserveSig]
		[Token(Token = "0x60003CD")]
		[Address(RVA = "0xD42E68", Offset = "0xD42E68", VA = "0xD42E68")]
		public static extern float AudioFormatDecoder_getOutputSampleRate(HandleRef jarg1);

		[PreserveSig]
		[Token(Token = "0x60003CE")]
		[Address(RVA = "0xD42EE8", Offset = "0xD42EE8", VA = "0xD42EE8")]
		public static extern int AudioFormatDecoder_getNumBits(HandleRef jarg1);

		[PreserveSig]
		[Token(Token = "0x60003CF")]
		[Address(RVA = "0xD42F68", Offset = "0xD42F68", VA = "0xD42F68")]
		public static extern bool AudioFormatDecoder_endOfStream(HandleRef jarg1);

		[PreserveSig]
		[Token(Token = "0x60003D0")]
		[Address(RVA = "0xD42FF0", Offset = "0xD42FF0", VA = "0xD42FF0")]
		public static extern bool AudioFormatDecoder_decoderError(HandleRef jarg1);

		[PreserveSig]
		[Token(Token = "0x60003D1")]
		[Address(RVA = "0xD43078", Offset = "0xD43078", VA = "0xD43078")]
		public static extern int AudioFormatDecoder_getMaxBufferSizePerChannel(HandleRef jarg1);

		[PreserveSig]
		[Token(Token = "0x60003D2")]
		[Address(RVA = "0xD430F8", Offset = "0xD430F8", VA = "0xD430F8")]
		public static extern string AudioFormatDecoder_getName(HandleRef jarg1);

		[PreserveSig]
		[Token(Token = "0x60003D3")]
		[Address(RVA = "0xD43190", Offset = "0xD43190", VA = "0xD43190")]
		public static extern void AudioFormatDecoder_flush__SWIG_0(HandleRef jarg1, bool jarg2);

		[PreserveSig]
		[Token(Token = "0x60003D4")]
		[Address(RVA = "0xD43220", Offset = "0xD43220", VA = "0xD43220")]
		public static extern void AudioFormatDecoder_flush__SWIG_1(HandleRef jarg1);

		[PreserveSig]
		[Token(Token = "0x60003D5")]
		[Address(RVA = "0xD432A0", Offset = "0xD432A0", VA = "0xD432A0")]
		public static extern int AudioFormatDecoder_getInfo(HandleRef jarg1, int jarg2);

		[PreserveSig]
		[Token(Token = "0x60003D6")]
		[Address(RVA = "0xD43330", Offset = "0xD43330", VA = "0xD43330")]
		public static extern int AudioFormatDecoder_getChannelMap(HandleRef jarg1);

		[PreserveSig]
		[Token(Token = "0x60003D7")]
		[Address(RVA = "0xD433B0", Offset = "0xD433B0", VA = "0xD433B0")]
		public static extern IntPtr AudioFormatDecoder_create__SWIG_0(string jarg1, int jarg2, float jarg3);

		[PreserveSig]
		[Token(Token = "0x60003D8")]
		[Address(RVA = "0xD43468", Offset = "0xD43468", VA = "0xD43468")]
		public static extern IntPtr AudioFormatDecoder_create__SWIG_1(string jarg1, int jarg2);

		[PreserveSig]
		[Token(Token = "0x60003D9")]
		[Address(RVA = "0xD43510", Offset = "0xD43510", VA = "0xD43510")]
		public static extern IntPtr AudioFormatDecoder_create__SWIG_2(HandleRef jarg1, bool jarg2, int jarg3, float jarg4);

		[PreserveSig]
		[Token(Token = "0x60003DA")]
		[Address(RVA = "0xD435B8", Offset = "0xD435B8", VA = "0xD435B8")]
		public static extern IntPtr AudioFormatDecoder_create__SWIG_3(HandleRef jarg1, bool jarg2, int jarg3);

		[PreserveSig]
		[Token(Token = "0x60003DB")]
		[Address(RVA = "0xD43650", Offset = "0xD43650", VA = "0xD43650")]
		public static extern int EventTransport_open__SWIG_0(HandleRef jarg1, string jarg2);

		[PreserveSig]
		[Token(Token = "0x60003DC")]
		[Address(RVA = "0xD436FC", Offset = "0xD436FC", VA = "0xD436FC")]
		public static extern int EventTransport_open__SWIG_1(HandleRef jarg1, IntPtr jarg2, uint jarg3);

		[PreserveSig]
		[Token(Token = "0x60003DD")]
		[Address(RVA = "0xD43794", Offset = "0xD43794", VA = "0xD43794")]
		public static extern int EventTransport_open__SWIG_2(HandleRef jarg1, float jarg2, byte jarg3, byte jarg4, float jarg5);

		[PreserveSig]
		[Token(Token = "0x60003DE")]
		[Address(RVA = "0xD43844", Offset = "0xD43844", VA = "0xD43844")]
		public static extern void EventTransport_close(HandleRef jarg1);

		[PreserveSig]
		[Token(Token = "0x60003DF")]
		[Address(RVA = "0xD438C4", Offset = "0xD438C4", VA = "0xD438C4")]
		public static extern bool EventTransport_isOpen(HandleRef jarg1);

		[PreserveSig]
		[Token(Token = "0x60003E0")]
		[Address(RVA = "0xD4394C", Offset = "0xD4394C", VA = "0xD4394C")]
		public static extern int EventTransport_setEventCallback(HandleRef jarg1, EventTransportCallback jarg2, IntPtr jarg3);

		[PreserveSig]
		[Token(Token = "0x60003E1")]
		[Address(RVA = "0xD439EC", Offset = "0xD439EC", VA = "0xD439EC")]
		public static extern int EventTransport_getEvents(HandleRef jarg1, EventTransportCallback jarg2, IntPtr jarg3, uint jarg4, uint jarg5);

		[PreserveSig]
		[Token(Token = "0x60003E2")]
		[Address(RVA = "0xD43AA4", Offset = "0xD43AA4", VA = "0xD43AA4")]
		public static extern bool EventTransport_enableLooping(HandleRef jarg1, bool jarg2);

		[PreserveSig]
		[Token(Token = "0x60003E3")]
		[Address(RVA = "0xD43B3C", Offset = "0xD43B3C", VA = "0xD43B3C")]
		public static extern bool EventTransport_loopingEnabled(HandleRef jarg1);

		[PreserveSig]
		[Token(Token = "0x60003E4")]
		[Address(RVA = "0xD43BC4", Offset = "0xD43BC4", VA = "0xD43BC4")]
		public static extern void EventTransport_setSpeed(HandleRef jarg1, float jarg2);

		[PreserveSig]
		[Token(Token = "0x60003E5")]
		[Address(RVA = "0xD43C54", Offset = "0xD43C54", VA = "0xD43C54")]
		public static extern float EventTransport_getSpeed(HandleRef jarg1);

		[PreserveSig]
		[Token(Token = "0x60003E6")]
		[Address(RVA = "0xD43CD4", Offset = "0xD43CD4", VA = "0xD43CD4")]
		public static extern int EventTransport_seekToSample(HandleRef jarg1, uint jarg2);

		[PreserveSig]
		[Token(Token = "0x60003E7")]
		[Address(RVA = "0xD43D64", Offset = "0xD43D64", VA = "0xD43D64")]
		public static extern int EventTransport_seekToMs(HandleRef jarg1, float jarg2);

		[PreserveSig]
		[Token(Token = "0x60003E8")]
		[Address(RVA = "0xD43DF4", Offset = "0xD43DF4", VA = "0xD43DF4")]
		public static extern uint EventTransport_getElapsedTimeInSamples(HandleRef jarg1);

		[PreserveSig]
		[Token(Token = "0x60003E9")]
		[Address(RVA = "0xD43E74", Offset = "0xD43E74", VA = "0xD43E74")]
		public static extern float EventTransport_getElapsedTimeInMs(HandleRef jarg1);

		[PreserveSig]
		[Token(Token = "0x60003EA")]
		[Address(RVA = "0xD43EF4", Offset = "0xD43EF4", VA = "0xD43EF4")]
		public static extern float EventTransport_getElapsedTimeInBars(HandleRef jarg1);

		[PreserveSig]
		[Token(Token = "0x60003EB")]
		[Address(RVA = "0xD43F74", Offset = "0xD43F74", VA = "0xD43F74")]
		public static extern uint EventTransport_getAssetDurationInSamples(HandleRef jarg1);

		[PreserveSig]
		[Token(Token = "0x60003EC")]
		[Address(RVA = "0xD43FF4", Offset = "0xD43FF4", VA = "0xD43FF4")]
		public static extern float EventTransport_getAssetDurationInMs(HandleRef jarg1);

		[PreserveSig]
		[Token(Token = "0x60003ED")]
		[Address(RVA = "0xD44074", Offset = "0xD44074", VA = "0xD44074")]
		public static extern float EventTransport_getAssetDurationInBars(HandleRef jarg1);

		[PreserveSig]
		[Token(Token = "0x60003EE")]
		[Address(RVA = "0xD440F4", Offset = "0xD440F4", VA = "0xD440F4")]
		public static extern uint EventTransport_getEventCount(HandleRef jarg1);

		[PreserveSig]
		[Token(Token = "0x60003EF")]
		[Address(RVA = "0xD44174", Offset = "0xD44174", VA = "0xD44174")]
		public static extern float EventTransport_getTempo(HandleRef jarg1);

		[PreserveSig]
		[Token(Token = "0x60003F0")]
		[Address(RVA = "0xD441F4", Offset = "0xD441F4", VA = "0xD441F4")]
		public static extern byte EventTransport_getTimeSignatureNumerator(HandleRef jarg1);

		[PreserveSig]
		[Token(Token = "0x60003F1")]
		[Address(RVA = "0xD44274", Offset = "0xD44274", VA = "0xD44274")]
		public static extern byte EventTransport_getTimeSignatureDenominator(HandleRef jarg1);

		[PreserveSig]
		[Token(Token = "0x60003F2")]
		[Address(RVA = "0xD33BF4", Offset = "0xD33BF4", VA = "0xD33BF4")]
		public static extern ulong InvalidVoiceHandle_get();

		[PreserveSig]
		[Token(Token = "0x60003F3")]
		[Address(RVA = "0xD33CC4", Offset = "0xD33CC4", VA = "0xD33CC4")]
		public static extern uint kMaxTotalVoices_get();

		[PreserveSig]
		[Token(Token = "0x60003F4")]
		[Address(RVA = "0xD442F4", Offset = "0xD442F4", VA = "0xD442F4")]
		public static extern void VoiceParamDescription_min_set(HandleRef jarg1, float jarg2);

		[PreserveSig]
		[Token(Token = "0x60003F5")]
		[Address(RVA = "0xD44384", Offset = "0xD44384", VA = "0xD44384")]
		public static extern float VoiceParamDescription_min_get(HandleRef jarg1);

		[PreserveSig]
		[Token(Token = "0x60003F6")]
		[Address(RVA = "0xD44404", Offset = "0xD44404", VA = "0xD44404")]
		public static extern void VoiceParamDescription_max_set(HandleRef jarg1, float jarg2);

		[PreserveSig]
		[Token(Token = "0x60003F7")]
		[Address(RVA = "0xD44494", Offset = "0xD44494", VA = "0xD44494")]
		public static extern float VoiceParamDescription_max_get(HandleRef jarg1);

		[PreserveSig]
		[Token(Token = "0x60003F8")]
		[Address(RVA = "0xD44514", Offset = "0xD44514", VA = "0xD44514")]
		public static extern void VoiceParamDescription_defaultValue_set(HandleRef jarg1, float jarg2);

		[PreserveSig]
		[Token(Token = "0x60003F9")]
		[Address(RVA = "0xD445A4", Offset = "0xD445A4", VA = "0xD445A4")]
		public static extern float VoiceParamDescription_defaultValue_get(HandleRef jarg1);

		[PreserveSig]
		[Token(Token = "0x60003FA")]
		[Address(RVA = "0xD44624", Offset = "0xD44624", VA = "0xD44624")]
		public static extern void VoiceParamDescription_stepSize_set(HandleRef jarg1, float jarg2);

		[PreserveSig]
		[Token(Token = "0x60003FB")]
		[Address(RVA = "0xD446B4", Offset = "0xD446B4", VA = "0xD446B4")]
		public static extern float VoiceParamDescription_stepSize_get(HandleRef jarg1);

		[PreserveSig]
		[Token(Token = "0x60003FC")]
		[Address(RVA = "0xD44734", Offset = "0xD44734", VA = "0xD44734")]
		public static extern IntPtr new_VoiceParamDescription();

		[PreserveSig]
		[Token(Token = "0x60003FD")]
		[Address(RVA = "0xD447A8", Offset = "0xD447A8", VA = "0xD447A8")]
		public static extern void delete_VoiceParamDescription(HandleRef jarg1);

		[PreserveSig]
		[Token(Token = "0x60003FE")]
		[Address(RVA = "0xD44828", Offset = "0xD44828", VA = "0xD44828")]
		public static extern void delete_VoiceManager(HandleRef jarg1);

		[PreserveSig]
		[Token(Token = "0x60003FF")]
		[Address(RVA = "0xD448A8", Offset = "0xD448A8", VA = "0xD448A8")]
		public static extern uint VoiceManager_getMaxPhysicalVoices(HandleRef jarg1);

		[PreserveSig]
		[Token(Token = "0x6000400")]
		[Address(RVA = "0xD44928", Offset = "0xD44928", VA = "0xD44928")]
		public static extern uint VoiceManager_getMaxVirtualVoices(HandleRef jarg1);

		[PreserveSig]
		[Token(Token = "0x6000401")]
		[Address(RVA = "0xD449A8", Offset = "0xD449A8", VA = "0xD449A8")]
		public static extern uint VoiceManager_getMaxTotalVoices(HandleRef jarg1);

		[PreserveSig]
		[Token(Token = "0x6000402")]
		[Address(RVA = "0xD44A28", Offset = "0xD44A28", VA = "0xD44A28")]
		public static extern uint VoiceManager_getNumPhysicalVoices(HandleRef jarg1);

		[PreserveSig]
		[Token(Token = "0x6000403")]
		[Address(RVA = "0xD44AA8", Offset = "0xD44AA8", VA = "0xD44AA8")]
		public static extern uint VoiceManager_getNumVirtualVoices(HandleRef jarg1);

		[PreserveSig]
		[Token(Token = "0x6000404")]
		[Address(RVA = "0xD44B28", Offset = "0xD44B28", VA = "0xD44B28")]
		public static extern uint VoiceManager_getNumTotalVoices(HandleRef jarg1);

		[PreserveSig]
		[Token(Token = "0x6000405")]
		[Address(RVA = "0xD44BA8", Offset = "0xD44BA8", VA = "0xD44BA8")]
		public static extern int VoiceManager_openVoice(HandleRef jarg1, out ulong jarg2, HandleRef jarg3);

		[PreserveSig]
		[Token(Token = "0x6000406")]
		[Address(RVA = "0xD44C40", Offset = "0xD44C40", VA = "0xD44C40")]
		public static extern int VoiceManager_closeVoice(HandleRef jarg1, ulong jarg2);

		[PreserveSig]
		[Token(Token = "0x6000407")]
		[Address(RVA = "0xD44CD0", Offset = "0xD44CD0", VA = "0xD44CD0")]
		public static extern bool VoiceManager_voiceIsOpen(HandleRef jarg1, ulong jarg2);

		[PreserveSig]
		[Token(Token = "0x6000408")]
		[Address(RVA = "0xD44D68", Offset = "0xD44D68", VA = "0xD44D68")]
		public static extern int VoiceManager_play(HandleRef jarg1, ulong jarg2, float jarg3, float jarg4);

		[PreserveSig]
		[Token(Token = "0x6000409")]
		[Address(RVA = "0xD44E10", Offset = "0xD44E10", VA = "0xD44E10")]
		public static extern int VoiceManager_pause(HandleRef jarg1, ulong jarg2, float jarg3, float jarg4);

		[PreserveSig]
		[Token(Token = "0x600040A")]
		[Address(RVA = "0xD44EB8", Offset = "0xD44EB8", VA = "0xD44EB8")]
		public static extern int VoiceManager_stop(HandleRef jarg1, ulong jarg2, float jarg3, float jarg4);

		[PreserveSig]
		[Token(Token = "0x600040B")]
		[Address(RVA = "0xD44F60", Offset = "0xD44F60", VA = "0xD44F60")]
		public static extern int VoiceManager_getPlayState(HandleRef jarg1, ulong jarg2, out PlayState jarg3);

		[PreserveSig]
		[Token(Token = "0x600040C")]
		[Address(RVA = "0xD44FF8", Offset = "0xD44FF8", VA = "0xD44FF8")]
		public static extern int VoiceManager_seekMs(HandleRef jarg1, ulong jarg2, float jarg3);

		[PreserveSig]
		[Token(Token = "0x600040D")]
		[Address(RVA = "0xD45098", Offset = "0xD45098", VA = "0xD45098")]
		public static extern int VoiceManager_getElapsedTimeMs(HandleRef jarg1, ulong jarg2, ref float jarg3);

		[PreserveSig]
		[Token(Token = "0x600040E")]
		[Address(RVA = "0xD45130", Offset = "0xD45130", VA = "0xD45130")]
		public static extern int VoiceManager_getDurationMs(HandleRef jarg1, ulong jarg2, ref float jarg3);

		[PreserveSig]
		[Token(Token = "0x600040F")]
		[Address(RVA = "0xD451C8", Offset = "0xD451C8", VA = "0xD451C8")]
		public static extern int VoiceManager_setParam(HandleRef jarg1, ulong jarg2, int jarg3, float jarg4);

		[PreserveSig]
		[Token(Token = "0x6000410")]
		[Address(RVA = "0xD45270", Offset = "0xD45270", VA = "0xD45270")]
		public static extern int VoiceManager_getParam(HandleRef jarg1, ulong jarg2, int jarg3, ref float jarg4);

		[PreserveSig]
		[Token(Token = "0x6000411")]
		[Address(RVA = "0xD45318", Offset = "0xD45318", VA = "0xD45318")]
		public static extern int VoiceManager_getParamDescription(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[PreserveSig]
		[Token(Token = "0x6000412")]
		[Address(RVA = "0xD453B0", Offset = "0xD453B0", VA = "0xD453B0")]
		public static extern int VoiceManager_setBus(HandleRef jarg1, ulong jarg2, IntPtr jarg3);

		[PreserveSig]
		[Token(Token = "0x6000413")]
		[Address(RVA = "0xD45448", Offset = "0xD45448", VA = "0xD45448")]
		public static extern int VoiceManager_getBus(HandleRef jarg1, ulong jarg2, out IntPtr jarg3);

		[PreserveSig]
		[Token(Token = "0x6000414")]
		[Address(RVA = "0xD454E0", Offset = "0xD454E0", VA = "0xD454E0")]
		public static extern int VoiceManager_getVoiceMode(HandleRef jarg1, ulong jarg2, out VoiceMode jarg3);

		[PreserveSig]
		[Token(Token = "0x6000415")]
		[Address(RVA = "0xD45578", Offset = "0xD45578", VA = "0xD45578")]
		public static extern int VoiceManager_setEventCallback(HandleRef jarg1, VoiceManagerEventCb jarg2, IntPtr jarg3);

		[PreserveSig]
		[Token(Token = "0x6000416")]
		[Address(RVA = "0xD45618", Offset = "0xD45618", VA = "0xD45618")]
		public static extern IntPtr Object3D_SWIGUpcast(IntPtr jarg1);

		[PreserveSig]
		[Token(Token = "0x6000417")]
		[Address(RVA = "0xD45698", Offset = "0xD45698", VA = "0xD45698")]
		public static extern IntPtr SpatDecoderInterface_SWIGUpcast(IntPtr jarg1);

		[PreserveSig]
		[Token(Token = "0x6000418")]
		[Address(RVA = "0xD45718", Offset = "0xD45718", VA = "0xD45718")]
		public static extern IntPtr NativeSpatDecoderQueue_SWIGUpcast(IntPtr jarg1);

		[PreserveSig]
		[Token(Token = "0x6000419")]
		[Address(RVA = "0xD45798", Offset = "0xD45798", VA = "0xD45798")]
		public static extern IntPtr NativeSpatDecoderFile_SWIGUpcast(IntPtr jarg1);

		[PreserveSig]
		[Token(Token = "0x600041A")]
		[Address(RVA = "0xD45818", Offset = "0xD45818", VA = "0xD45818")]
		public static extern IntPtr NativeAudioObject_SWIGUpcast(IntPtr jarg1);

		[PreserveSig]
		[Token(Token = "0x600041B")]
		[Address(RVA = "0xD45898", Offset = "0xD45898", VA = "0xD45898")]
		public static extern IntPtr EventTransport_SWIGUpcast(IntPtr jarg1);

		[Token(Token = "0x600041C")]
		[Address(RVA = "0xD45918", Offset = "0xD45918", VA = "0xD45918")]
		public Audio360CSharpPINVOKE()
		{
		}
	}
	[Token(Token = "0x200005D")]
	public class AudioAssetHandle : IDisposable
	{
		[Token(Token = "0x400017D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private HandleRef swigCPtr;

		[Token(Token = "0x400017E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		protected bool swigCMemOwn;

		[Token(Token = "0x17000052")]
		public uint index
		{
			[Token(Token = "0x6000423")]
			[Address(RVA = "0xEC60DC", Offset = "0xEC60DC", VA = "0xEC60DC")]
			get
			{
				return default(uint);
			}
			[Token(Token = "0x6000422")]
			[Address(RVA = "0xEC605C", Offset = "0xEC605C", VA = "0xEC605C")]
			set
			{
			}
		}

		[Token(Token = "0x17000053")]
		public uint id
		{
			[Token(Token = "0x6000425")]
			[Address(RVA = "0xEC61CC", Offset = "0xEC61CC", VA = "0xEC61CC")]
			get
			{
				return default(uint);
			}
			[Token(Token = "0x6000424")]
			[Address(RVA = "0xEC614C", Offset = "0xEC614C", VA = "0xEC614C")]
			set
			{
			}
		}

		[Token(Token = "0x600041D")]
		[Address(RVA = "0xEC5D64", Offset = "0xEC5D64", VA = "0xEC5D64")]
		internal AudioAssetHandle(IntPtr cPtr, bool cMemoryOwn)
		{
		}

		[Token(Token = "0x600041E")]
		[Address(RVA = "0xEC5DC8", Offset = "0xEC5DC8", VA = "0xEC5DC8")]
		public static HandleRef getCPtr(AudioAssetHandle obj)
		{
			return default(HandleRef);
		}

		[Token(Token = "0x600041F")]
		[Address(RVA = "0xEC5E3C", Offset = "0xEC5E3C", VA = "0xEC5E3C", Slot = "1")]
		~AudioAssetHandle()
		{
		}

		[Token(Token = "0x6000420")]
		[Address(RVA = "0xEC5EB0", Offset = "0xEC5EB0", VA = "0xEC5EB0", Slot = "4")]
		public void Dispose()
		{
		}

		[Token(Token = "0x6000421")]
		[Address(RVA = "0xEC5F2C", Offset = "0xEC5F2C", VA = "0xEC5F2C", Slot = "5")]
		protected virtual void Dispose(bool disposing)
		{
		}

		[Token(Token = "0x6000426")]
		[Address(RVA = "0xEC623C", Offset = "0xEC623C", VA = "0xEC623C")]
		public AudioAssetHandle()
		{
		}
	}
	[Token(Token = "0x200005E")]
	public class AudioAssetManager : IDisposable
	{
		[Token(Token = "0x400017F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private HandleRef swigCPtr;

		[Token(Token = "0x4000180")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		protected bool swigCMemOwn;

		[Token(Token = "0x6000427")]
		[Address(RVA = "0xEC62B0", Offset = "0xEC62B0", VA = "0xEC62B0")]
		internal AudioAssetManager(IntPtr cPtr, bool cMemoryOwn)
		{
		}

		[Token(Token = "0x6000428")]
		[Address(RVA = "0xEC6314", Offset = "0xEC6314", VA = "0xEC6314")]
		public static HandleRef getCPtr(AudioAssetManager obj)
		{
			return default(HandleRef);
		}

		[Token(Token = "0x6000429")]
		[Address(RVA = "0xEC6388", Offset = "0xEC6388", VA = "0xEC6388", Slot = "1")]
		~AudioAssetManager()
		{
		}

		[Token(Token = "0x600042A")]
		[Address(RVA = "0xEC63FC", Offset = "0xEC63FC", VA = "0xEC63FC", Slot = "4")]
		public void Dispose()
		{
		}

		[Token(Token = "0x600042B")]
		[Address(RVA = "0xEC6478", Offset = "0xEC6478", VA = "0xEC6478", Slot = "5")]
		protected virtual void Dispose(bool disposing)
		{
		}

		[Token(Token = "0x600042C")]
		[Address(RVA = "0xEC65A8", Offset = "0xEC65A8", VA = "0xEC65A8", Slot = "6")]
		public virtual EngineError loadAudio(AudioAssetHandle handle, string fileNameAndPath, AssetDescriptor ad, AssetAccessMode mode)
		{
			return default(EngineError);
		}

		[Token(Token = "0x600042D")]
		[Address(RVA = "0xEC66E8", Offset = "0xEC66E8", VA = "0xEC66E8", Slot = "7")]
		public virtual IOStream getNewStream(AudioAssetHandle handle)
		{
			return null;
		}

		[Token(Token = "0x600042E")]
		[Address(RVA = "0xEC6874", Offset = "0xEC6874", VA = "0xEC6874", Slot = "8")]
		public virtual AudioFormatDecoder getNewDecoder(AudioAssetHandle handle, int bufferSize, float sampleRate)
		{
			return null;
		}

		[Token(Token = "0x600042F")]
		[Address(RVA = "0xEC6A20", Offset = "0xEC6A20", VA = "0xEC6A20", Slot = "9")]
		public virtual bool unloadAudio(AudioAssetHandle handle)
		{
			return default(bool);
		}

		[Token(Token = "0x6000430")]
		[Address(RVA = "0xEC6B18", Offset = "0xEC6B18", VA = "0xEC6B18", Slot = "10")]
		public virtual AssetAccessMode getMode(AudioAssetHandle handle)
		{
			return default(AssetAccessMode);
		}

		[Token(Token = "0x6000431")]
		[Address(RVA = "0xEC6C10", Offset = "0xEC6C10", VA = "0xEC6C10", Slot = "11")]
		public virtual string getFormat(AudioAssetHandle handle)
		{
			return null;
		}

		[Token(Token = "0x6000432")]
		[Address(RVA = "0xEC6D08", Offset = "0xEC6D08", VA = "0xEC6D08", Slot = "12")]
		public virtual uint getBytesInMemory()
		{
			return default(uint);
		}
	}
	[Token(Token = "0x200005F")]
	public enum AudioDeviceType
	{
		[Token(Token = "0x4000182")]
		DEFAULT,
		[Token(Token = "0x4000183")]
		CUSTOM,
		[Token(Token = "0x4000184")]
		DISABLED
	}
	[Token(Token = "0x2000060")]
	public class AudioEngine : IDisposable
	{
		[Token(Token = "0x4000185")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private HandleRef swigCPtr;

		[Token(Token = "0x4000186")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		protected bool swigCMemOwn;

		[Token(Token = "0x4000187")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly int AUDIO360_MAX_BUS_NAME_SIZE;

		[Token(Token = "0x6000433")]
		[Address(RVA = "0xEC6D78", Offset = "0xEC6D78", VA = "0xEC6D78")]
		internal AudioEngine(IntPtr cPtr, bool cMemoryOwn)
		{
		}

		[Token(Token = "0x6000434")]
		[Address(RVA = "0xEC6DDC", Offset = "0xEC6DDC", VA = "0xEC6DDC")]
		public static HandleRef getCPtr(AudioEngine obj)
		{
			return default(HandleRef);
		}

		[Token(Token = "0x6000435")]
		[Address(RVA = "0xEC6E50", Offset = "0xEC6E50", VA = "0xEC6E50", Slot = "1")]
		~AudioEngine()
		{
		}

		[Token(Token = "0x6000436")]
		[Address(RVA = "0xEC6EC4", Offset = "0xEC6EC4", VA = "0xEC6EC4", Slot = "4")]
		public void Dispose()
		{
		}

		[Token(Token = "0x6000437")]
		[Address(RVA = "0xEC6F40", Offset = "0xEC6F40", VA = "0xEC6F40", Slot = "5")]
		protected virtual void Dispose(bool disposing)
		{
		}

		[Token(Token = "0x6000438")]
		[Address(RVA = "0xEC7070", Offset = "0xEC7070", VA = "0xEC7070", Slot = "6")]
		public virtual EngineError start()
		{
			return default(EngineError);
		}

		[Token(Token = "0x6000439")]
		[Address(RVA = "0xEC70E0", Offset = "0xEC70E0", VA = "0xEC70E0", Slot = "7")]
		public virtual EngineError suspend()
		{
			return default(EngineError);
		}

		[Token(Token = "0x600043A")]
		[Address(RVA = "0xEC7150", Offset = "0xEC7150", VA = "0xEC7150", Slot = "8")]
		public virtual EngineError setNumBinaural(int numBinaural)
		{
			return default(EngineError);
		}

		[Token(Token = "0x600043B")]
		[Address(RVA = "0xEC71D0", Offset = "0xEC71D0", VA = "0xEC71D0", Slot = "9")]
		public virtual int getNumBinaural()
		{
			return default(int);
		}

		[Token(Token = "0x600043C")]
		[Address(RVA = "0xEC7240", Offset = "0xEC7240", VA = "0xEC7240", Slot = "10")]
		public virtual void setListenerRotation(TBVector forwardVector, TBVector upVector)
		{
		}

		[Token(Token = "0x600043D")]
		[Address(RVA = "0xEC7358", Offset = "0xEC7358", VA = "0xEC7358", Slot = "11")]
		public virtual void setListenerRotation(TBQuat quat)
		{
		}

		[Token(Token = "0x600043E")]
		[Address(RVA = "0xEC7448", Offset = "0xEC7448", VA = "0xEC7448", Slot = "12")]
		public virtual void setListenerRotation(float yaw, float pitch, float roll)
		{
		}

		[Token(Token = "0x600043F")]
		[Address(RVA = "0xEC74E0", Offset = "0xEC74E0", VA = "0xEC74E0", Slot = "13")]
		public virtual void setListenerPosition(TBVector position)
		{
		}

		[Token(Token = "0x6000440")]
		[Address(RVA = "0xEC75D0", Offset = "0xEC75D0", VA = "0xEC75D0", Slot = "14")]
		public virtual TBVector getListenerPosition()
		{
			return null;
		}

		[Token(Token = "0x6000441")]
		[Address(RVA = "0xEC7674", Offset = "0xEC7674", VA = "0xEC7674", Slot = "15")]
		public virtual TBQuat getListenerRotation()
		{
			return null;
		}

		[Token(Token = "0x6000442")]
		[Address(RVA = "0xEC7718", Offset = "0xEC7718", VA = "0xEC7718", Slot = "16")]
		public virtual TBVector getListenerForward()
		{
			return null;
		}

		[Token(Token = "0x6000443")]
		[Address(RVA = "0xEC77BC", Offset = "0xEC77BC", VA = "0xEC77BC", Slot = "17")]
		public virtual TBVector getListenerUp()
		{
			return null;
		}

		[Token(Token = "0x6000444")]
		[Address(RVA = "0xEC7860", Offset = "0xEC7860", VA = "0xEC7860", Slot = "18")]
		public virtual void setListenerScale(float scale)
		{
		}

		[Token(Token = "0x6000445")]
		[Address(RVA = "0xEC78E0", Offset = "0xEC78E0", VA = "0xEC78E0", Slot = "19")]
		public virtual float getListenerScale()
		{
			return default(float);
		}

		[Token(Token = "0x6000446")]
		[Address(RVA = "0xEC7950", Offset = "0xEC7950", VA = "0xEC7950", Slot = "20")]
		public virtual void update()
		{
		}

		[Token(Token = "0x6000447")]
		[Address(RVA = "0xEC79C0", Offset = "0xEC79C0", VA = "0xEC79C0", Slot = "21")]
		public virtual EngineError enablePositionalTracking(bool enable, TBVector initialListenerPosition)
		{
			return default(EngineError);
		}

		[Token(Token = "0x6000448")]
		[Address(RVA = "0xEC7ACC", Offset = "0xEC7ACC", VA = "0xEC7ACC", Slot = "22")]
		public virtual bool positionalTrackingEnabled()
		{
			return default(bool);
		}

		[Token(Token = "0x6000449")]
		[Address(RVA = "0xEC7B3C", Offset = "0xEC7B3C", VA = "0xEC7B3C", Slot = "23")]
		public virtual int getBufferSize()
		{
			return default(int);
		}

		[Token(Token = "0x600044A")]
		[Address(RVA = "0xEC7BAC", Offset = "0xEC7BAC", VA = "0xEC7BAC", Slot = "24")]
		public virtual float getSampleRate()
		{
			return default(float);
		}

		[Token(Token = "0x600044B")]
		[Address(RVA = "0xEC7C1C", Offset = "0xEC7C1C", VA = "0xEC7C1C", Slot = "25")]
		public virtual EngineError getAudioMix(float[] buffer, int numOfSamples, int numOfChannels)
		{
			return default(EngineError);
		}

		[Token(Token = "0x600044C")]
		[Address(RVA = "0xEC7CB4", Offset = "0xEC7CB4", VA = "0xEC7CB4", Slot = "26")]
		public virtual EngineError setAudioMixCallback(AudioInterleavedCallback callback, IntPtr userData)
		{
			return default(EngineError);
		}

		[Token(Token = "0x600044D")]
		[Address(RVA = "0xEC7D3C", Offset = "0xEC7D3C", VA = "0xEC7D3C", Slot = "27")]
		public virtual EngineError setAudioInputMixCallback(AudioInterleavedCallback callback, IntPtr userData)
		{
			return default(EngineError);
		}

		[Token(Token = "0x600044E")]
		[Address(RVA = "0xEC7DC4", Offset = "0xEC7DC4", VA = "0xEC7DC4", Slot = "28")]
		public virtual EngineError setAudioInputInterleavedCallback(AudioInterleavedCallback callback, IntPtr userData)
		{
			return default(EngineError);
		}

		[Token(Token = "0x600044F")]
		[Address(RVA = "0xEC7E4C", Offset = "0xEC7E4C", VA = "0xEC7E4C", Slot = "29")]
		public virtual void destroySpatDecoderQueue(NativeSpatDecoderQueue spatDecoder)
		{
		}

		[Token(Token = "0x6000450")]
		[Address(RVA = "0xEC7F54", Offset = "0xEC7F54", VA = "0xEC7F54", Slot = "30")]
		public virtual EngineError createSpatDecoderFile(NativeSpatDecoderFile spatDecoder, Options options)
		{
			return default(EngineError);
		}

		[Token(Token = "0x6000451")]
		[Address(RVA = "0xEC806C", Offset = "0xEC806C", VA = "0xEC806C", Slot = "31")]
		public virtual void destroySpatDecoderFile(NativeSpatDecoderFile spatDecoder)
		{
		}

		[Token(Token = "0x6000452")]
		[Address(RVA = "0xEC8100", Offset = "0xEC8100", VA = "0xEC8100", Slot = "32")]
		public virtual EngineError createAudioObject(NativeAudioObject audioObject, Options options)
		{
			return default(EngineError);
		}

		[Token(Token = "0x6000453")]
		[Address(RVA = "0xEC8218", Offset = "0xEC8218", VA = "0xEC8218", Slot = "33")]
		public virtual void destroyAudioObject(NativeAudioObject audioObject)
		{
		}

		[Token(Token = "0x6000454")]
		[Address(RVA = "0xEC82AC", Offset = "0xEC82AC", VA = "0xEC82AC", Slot = "34")]
		public virtual void destroyEventTransport(EventTransport eventTransport)
		{
		}

		[Token(Token = "0x6000455")]
		[Address(RVA = "0xEC83B4", Offset = "0xEC83B4", VA = "0xEC83B4", Slot = "35")]
		public virtual EngineError createBus(out IntPtr bus)
		{
			return default(EngineError);
		}

		[Token(Token = "0x6000456")]
		[Address(RVA = "0xEC8434", Offset = "0xEC8434", VA = "0xEC8434", Slot = "36")]
		public virtual EngineError destroyBus(ref IntPtr busToDestroy)
		{
			return default(EngineError);
		}

		[Token(Token = "0x6000457")]
		[Address(RVA = "0xEC84B4", Offset = "0xEC84B4", VA = "0xEC84B4", Slot = "37")]
		public virtual EngineError connectToMasterBus(IntPtr srcBus)
		{
			return default(EngineError);
		}

		[Token(Token = "0x6000458")]
		[Address(RVA = "0xEC8534", Offset = "0xEC8534", VA = "0xEC8534", Slot = "38")]
		public virtual EngineError connectToMasterBus(NativeAudioObject audioObject)
		{
			return default(EngineError);
		}

		[Token(Token = "0x6000459")]
		[Address(RVA = "0xEC85C8", Offset = "0xEC85C8", VA = "0xEC85C8", Slot = "39")]
		public virtual EngineError connect(IntPtr srcBus, IntPtr destBus)
		{
			return default(EngineError);
		}

		[Token(Token = "0x600045A")]
		[Address(RVA = "0xEC8650", Offset = "0xEC8650", VA = "0xEC8650", Slot = "40")]
		public virtual EngineError connect(NativeAudioObject audioObject, IntPtr destBus)
		{
			return default(EngineError);
		}

		[Token(Token = "0x600045B")]
		[Address(RVA = "0xEC86F4", Offset = "0xEC86F4", VA = "0xEC86F4", Slot = "41")]
		public virtual EngineError disconnectOutput(IntPtr bus)
		{
			return default(EngineError);
		}

		[Token(Token = "0x600045C")]
		[Address(RVA = "0xEC8774", Offset = "0xEC8774", VA = "0xEC8774", Slot = "42")]
		public virtual EngineError disconnectOutput(NativeAudioObject audioObject)
		{
			return default(EngineError);
		}

		[Token(Token = "0x600045D")]
		[Address(RVA = "0xEC8808", Offset = "0xEC8808", VA = "0xEC8808", Slot = "43")]
		public virtual EngineError setGain(IntPtr bus, float gain, float rampTimeMs)
		{
			return default(EngineError);
		}

		[Token(Token = "0x600045E")]
		[Address(RVA = "0xEC88A0", Offset = "0xEC88A0", VA = "0xEC88A0", Slot = "44")]
		public virtual EngineError getGain(IntPtr bus, ref float gain)
		{
			return default(EngineError);
		}

		[Token(Token = "0x600045F")]
		[Address(RVA = "0xEC8928", Offset = "0xEC8928", VA = "0xEC8928", Slot = "45")]
		public virtual EngineError setName(IntPtr bus, string name)
		{
			return default(EngineError);
		}

		[Token(Token = "0x6000460")]
		[Address(RVA = "0xEC89B0", Offset = "0xEC89B0", VA = "0xEC89B0", Slot = "46")]
		public virtual EngineError setEventCallback(EventCallback callback, IntPtr userData)
		{
			return default(EngineError);
		}

		[Token(Token = "0x6000461")]
		[Address(RVA = "0xEC8A38", Offset = "0xEC8A38", VA = "0xEC8A38", Slot = "47")]
		public virtual void enableTestTone(bool enable, float frequency, float gain)
		{
		}

		[Token(Token = "0x6000462")]
		[Address(RVA = "0xEC8AD0", Offset = "0xEC8AD0", VA = "0xEC8AD0", Slot = "48")]
		public virtual void enableTestTone(bool enable, float frequency)
		{
		}

		[Token(Token = "0x6000463")]
		[Address(RVA = "0xEC8B60", Offset = "0xEC8B60", VA = "0xEC8B60", Slot = "49")]
		public virtual void enableTestTone(bool enable)
		{
		}

		[Token(Token = "0x6000464")]
		[Address(RVA = "0xEC8BE0", Offset = "0xEC8BE0", VA = "0xEC8BE0", Slot = "50")]
		public virtual int getVersionMajor()
		{
			return default(int);
		}

		[Token(Token = "0x6000465")]
		[Address(RVA = "0xEC8C50", Offset = "0xEC8C50", VA = "0xEC8C50", Slot = "51")]
		public virtual int getVersionMinor()
		{
			return default(int);
		}

		[Token(Token = "0x6000466")]
		[Address(RVA = "0xEC8CC0", Offset = "0xEC8CC0", VA = "0xEC8CC0", Slot = "52")]
		public virtual int getVersionPatch()
		{
			return default(int);
		}

		[Token(Token = "0x6000467")]
		[Address(RVA = "0xEC8D30", Offset = "0xEC8D30", VA = "0xEC8D30", Slot = "53")]
		public virtual string getVersionHash()
		{
			return null;
		}

		[Token(Token = "0x6000468")]
		[Address(RVA = "0xEC8DA0", Offset = "0xEC8DA0", VA = "0xEC8DA0", Slot = "54")]
		public virtual LoudnessStatistics getRenderedLoudness()
		{
			return null;
		}

		[Token(Token = "0x6000469")]
		[Address(RVA = "0xEC8EA4", Offset = "0xEC8EA4", VA = "0xEC8EA4", Slot = "55")]
		public virtual void resetLoudness()
		{
		}

		[Token(Token = "0x600046A")]
		[Address(RVA = "0xEC8F14", Offset = "0xEC8F14", VA = "0xEC8F14", Slot = "56")]
		public virtual void enableLoudness(bool enabled)
		{
		}

		[Token(Token = "0x600046B")]
		[Address(RVA = "0xEC8F94", Offset = "0xEC8F94", VA = "0xEC8F94", Slot = "57")]
		public virtual void enableLoudness()
		{
		}

		[Token(Token = "0x600046C")]
		[Address(RVA = "0xEC9004", Offset = "0xEC9004", VA = "0xEC9004", Slot = "58")]
		public virtual long getDSPTime()
		{
			return default(long);
		}

		[Token(Token = "0x600046D")]
		[Address(RVA = "0xEC9074", Offset = "0xEC9074", VA = "0xEC9074", Slot = "59")]
		public virtual EngineError setNumOutputBuffers(uint numOfBuffers)
		{
			return default(EngineError);
		}

		[Token(Token = "0x600046E")]
		[Address(RVA = "0xEC90F4", Offset = "0xEC90F4", VA = "0xEC90F4", Slot = "60")]
		public virtual uint getNumOutputBuffers()
		{
			return default(uint);
		}

		[Token(Token = "0x600046F")]
		[Address(RVA = "0xEC9164", Offset = "0xEC9164", VA = "0xEC9164", Slot = "61")]
		public virtual int getOutputLatencySamples()
		{
			return default(int);
		}

		[Token(Token = "0x6000470")]
		[Address(RVA = "0xEC91D4", Offset = "0xEC91D4", VA = "0xEC91D4", Slot = "62")]
		public virtual double getOutputLatencyMs()
		{
			return default(double);
		}

		[Token(Token = "0x6000471")]
		[Address(RVA = "0xEC9244", Offset = "0xEC9244", VA = "0xEC9244", Slot = "63")]
		public virtual string getOutputAudioDeviceName()
		{
			return null;
		}

		[Token(Token = "0x6000472")]
		[Address(RVA = "0xEC92B4", Offset = "0xEC92B4", VA = "0xEC92B4", Slot = "64")]
		public virtual EngineError openAudioInput(string name)
		{
			return default(EngineError);
		}

		[Token(Token = "0x6000473")]
		[Address(RVA = "0xEC9334", Offset = "0xEC9334", VA = "0xEC9334", Slot = "65")]
		public virtual EngineError mixAudioInput(bool shouldMix)
		{
			return default(EngineError);
		}

		[Token(Token = "0x6000474")]
		[Address(RVA = "0xEC93B4", Offset = "0xEC93B4", VA = "0xEC93B4", Slot = "66")]
		public virtual EngineError setInputMixGain(float gain)
		{
			return default(EngineError);
		}

		[Token(Token = "0x6000475")]
		[Address(RVA = "0xEC9434", Offset = "0xEC9434", VA = "0xEC9434", Slot = "67")]
		public virtual EngineError closeAudioInput()
		{
			return default(EngineError);
		}

		[Token(Token = "0x6000476")]
		[Address(RVA = "0xEC94A4", Offset = "0xEC94A4", VA = "0xEC94A4", Slot = "68")]
		public virtual AudioAssetManager getAudioAssetManager()
		{
			return null;
		}

		[Token(Token = "0x6000477")]
		[Address(RVA = "0xEC9554", Offset = "0xEC9554", VA = "0xEC9554", Slot = "69")]
		public virtual VoiceManager getVoiceManager()
		{
			return null;
		}

		[Token(Token = "0x6000478")]
		[Address(RVA = "0xEC9608", Offset = "0xEC9608", VA = "0xEC9608", Slot = "70")]
		public virtual void setMasterVolume(float linearVolume, float rampTimeMs)
		{
		}

		[Token(Token = "0x6000479")]
		[Address(RVA = "0xEC9690", Offset = "0xEC9690", VA = "0xEC9690", Slot = "71")]
		public virtual float getMasterVolume()
		{
			return default(float);
		}

		[Token(Token = "0x600047A")]
		[Address(RVA = "0xEC9700", Offset = "0xEC9700", VA = "0xEC9700", Slot = "72")]
		public virtual void enableMasterMute(bool shouldMute)
		{
		}

		[Token(Token = "0x600047B")]
		[Address(RVA = "0xEC9780", Offset = "0xEC9780", VA = "0xEC9780", Slot = "73")]
		public virtual bool isMasterMuteEnabled()
		{
			return default(bool);
		}

		[Token(Token = "0x600047C")]
		[Address(RVA = "0xEC97F0", Offset = "0xEC97F0", VA = "0xEC97F0", Slot = "74")]
		public virtual EngineStatistics getStats()
		{
			return null;
		}

		[Token(Token = "0x600047D")]
		[Address(RVA = "0xEC98F4", Offset = "0xEC98F4", VA = "0xEC98F4")]
		public static int getNumAudioDevices()
		{
			return default(int);
		}

		[Token(Token = "0x600047E")]
		[Address(RVA = "0xEC9954", Offset = "0xEC9954", VA = "0xEC9954")]
		public static string getAudioDeviceName(int index)
		{
			return null;
		}

		[Token(Token = "0x600047F")]
		[Address(RVA = "0xEC99BC", Offset = "0xEC99BC", VA = "0xEC99BC")]
		public static string getAudioDeviceNameFromId(string id)
		{
			return null;
		}

		[Token(Token = "0x6000480")]
		[Address(RVA = "0xEC9A24", Offset = "0xEC9A24", VA = "0xEC9A24", Slot = "75")]
		public virtual EngineError setMasterReverbBypass(bool bypass)
		{
			return default(EngineError);
		}

		[Token(Token = "0x6000481")]
		[Address(RVA = "0xEC9AA4", Offset = "0xEC9AA4", VA = "0xEC9AA4", Slot = "76")]
		public virtual bool getMasterReverbBypass()
		{
			return default(bool);
		}

		[Token(Token = "0x6000482")]
		[Address(RVA = "0xEC9B14", Offset = "0xEC9B14", VA = "0xEC9B14", Slot = "77")]
		public virtual EngineError setMasterReverbWetLevel(float wetLevel)
		{
			return default(EngineError);
		}

		[Token(Token = "0x6000483")]
		[Address(RVA = "0xEC9B94", Offset = "0xEC9B94", VA = "0xEC9B94", Slot = "78")]
		public virtual float getMasterReverbWetLevel()
		{
			return default(float);
		}

		[Token(Token = "0x6000484")]
		[Address(RVA = "0xEC9C04", Offset = "0xEC9C04", VA = "0xEC9C04", Slot = "79")]
		public virtual EngineError setMasterReverbRoomSize(float roomSize)
		{
			return default(EngineError);
		}

		[Token(Token = "0x6000485")]
		[Address(RVA = "0xEC9C84", Offset = "0xEC9C84", VA = "0xEC9C84", Slot = "80")]
		public virtual float getMasterReverbRoomSize()
		{
			return default(float);
		}

		[Token(Token = "0x6000486")]
		[Address(RVA = "0xEC9CF4", Offset = "0xEC9CF4", VA = "0xEC9CF4", Slot = "81")]
		public virtual EngineError setMasterReverbDampening(float dampening)
		{
			return default(EngineError);
		}

		[Token(Token = "0x6000487")]
		[Address(RVA = "0xEC9D74", Offset = "0xEC9D74", VA = "0xEC9D74", Slot = "82")]
		public virtual float getMasterReverbDampening()
		{
			return default(float);
		}

		[Token(Token = "0x6000488")]
		[Address(RVA = "0xEC9DE4", Offset = "0xEC9DE4", VA = "0xEC9DE4", Slot = "83")]
		public virtual EngineError setMasterReverbWidth(float width)
		{
			return default(EngineError);
		}

		[Token(Token = "0x6000489")]
		[Address(RVA = "0xEC9E64", Offset = "0xEC9E64", VA = "0xEC9E64", Slot = "84")]
		public virtual float getMasterReverbWidth()
		{
			return default(float);
		}

		[Token(Token = "0x600048A")]
		[Address(RVA = "0xEC9ED4", Offset = "0xEC9ED4", VA = "0xEC9ED4", Slot = "85")]
		public virtual bool saveGraph(string path)
		{
			return default(bool);
		}

		[Token(Token = "0x600048B")]
		[Address(RVA = "0xEC9F54", Offset = "0xEC9F54", VA = "0xEC9F54")]
		public static AudioEngine create(EngineInitSettings initSettings)
		{
			return null;
		}

		[Token(Token = "0x600048C")]
		[Address(RVA = "0xECA0D8", Offset = "0xECA0D8", VA = "0xECA0D8")]
		public static AudioEngine create(float sampleRate)
		{
			return null;
		}

		[Token(Token = "0x600048D")]
		[Address(RVA = "0xECA188", Offset = "0xECA188", VA = "0xECA188")]
		public static AudioEngine create(float sampleRate, int bufferSize)
		{
			return null;
		}

		[Token(Token = "0x600048E")]
		[Address(RVA = "0xECA240", Offset = "0xECA240", VA = "0xECA240")]
		public static AudioEngine create(float sampleRate, int bufferSize, int queueSizeInSamples)
		{
			return null;
		}

		[Token(Token = "0x600048F")]
		[Address(RVA = "0xECA308", Offset = "0xECA308", VA = "0xECA308")]
		public NativeSpatDecoderQueue createSpatDecoderQueue()
		{
			return null;
		}

		[Token(Token = "0x6000490")]
		[Address(RVA = "0xECA46C", Offset = "0xECA46C", VA = "0xECA46C")]
		public NativeSpatDecoderQueue createSpatDecoderQueue(ChannelMap map, PCMType type)
		{
			return null;
		}

		[Token(Token = "0x6000491")]
		[Address(RVA = "0xECA534", Offset = "0xECA534", VA = "0xECA534")]
		public NativeSpatDecoderFile createSpatDecoderFile()
		{
			return null;
		}

		[Token(Token = "0x6000492")]
		[Address(RVA = "0xECA698", Offset = "0xECA698", VA = "0xECA698")]
		public NativeAudioObject createAudioObject()
		{
			return null;
		}

		[Token(Token = "0x6000493")]
		[Address(RVA = "0xECA7FC", Offset = "0xECA7FC", VA = "0xECA7FC")]
		public string getName(IntPtr bus)
		{
			return null;
		}

		[Token(Token = "0x6000494")]
		[Address(RVA = "0xECA87C", Offset = "0xECA87C", VA = "0xECA87C")]
		public string getMasterBusName()
		{
			return null;
		}

		[Token(Token = "0x6000495")]
		[Address(RVA = "0xECA8EC", Offset = "0xECA8EC", VA = "0xECA8EC")]
		public EventTransport createEventTransport()
		{
			return null;
		}
	}
	[Token(Token = "0x2000061")]
	public enum AudioFormat
	{
		[Token(Token = "0x4000189")]
		OPUS_FILE,
		[Token(Token = "0x400018A")]
		WAV,
		[Token(Token = "0x400018B")]
		INVALID
	}
	[Token(Token = "0x2000062")]
	public class AudioFormatDecoder : IDisposable
	{
		[Token(Token = "0x20000A2")]
		public enum Info
		{
			[Token(Token = "0x40002AA")]
			PRE_SKIP
		}

		[Token(Token = "0x400018C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private HandleRef swigCPtr;

		[Token(Token = "0x400018D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		protected bool swigCMemOwn;

		[Token(Token = "0x6000497")]
		[Address(RVA = "0xEC69BC", Offset = "0xEC69BC", VA = "0xEC69BC")]
		internal AudioFormatDecoder(IntPtr cPtr, bool cMemoryOwn)
		{
		}

		[Token(Token = "0x6000498")]
		[Address(RVA = "0xECC838", Offset = "0xECC838", VA = "0xECC838")]
		public static HandleRef getCPtr(AudioFormatDecoder obj)
		{
			return default(HandleRef);
		}

		[Token(Token = "0x6000499")]
		[Address(RVA = "0xECC8AC", Offset = "0xECC8AC", VA = "0xECC8AC", Slot = "1")]
		~AudioFormatDecoder()
		{
		}

		[Token(Token = "0x600049A")]
		[Address(RVA = "0xECC920", Offset = "0xECC920", VA = "0xECC920", Slot = "4")]
		public void Dispose()
		{
		}

		[Token(Token = "0x600049B")]
		[Address(RVA = "0xECC99C", Offset = "0xECC99C", VA = "0xECC99C", Slot = "5")]
		protected virtual void Dispose(bool disposing)
		{
		}

		[Token(Token = "0x600049C")]
		[Address(RVA = "0xECCACC", Offset = "0xECCACC", VA = "0xECCACC", Slot = "6")]
		public virtual int getNumOfChannels()
		{
			return default(int);
		}

		[Token(Token = "0x600049D")]
		[Address(RVA = "0xECCB3C", Offset = "0xECCB3C", VA = "0xECCB3C", Slot = "7")]
		public virtual uint getNumTotalSamples()
		{
			return default(uint);
		}

		[Token(Token = "0x600049E")]
		[Address(RVA = "0xECCBAC", Offset = "0xECCBAC", VA = "0xECCBAC", Slot = "8")]
		public virtual uint getNumSamplesPerChannel()
		{
			return default(uint);
		}

		[Token(Token = "0x600049F")]
		[Address(RVA = "0xECCC1C", Offset = "0xECCC1C", VA = "0xECCC1C", Slot = "9")]
		public virtual double getMsPerChannel()
		{
			return default(double);
		}

		[Token(Token = "0x60004A0")]
		[Address(RVA = "0xECCC8C", Offset = "0xECCC8C", VA = "0xECCC8C", Slot = "10")]
		public virtual uint getSamplePosition()
		{
			return default(uint);
		}

		[Token(Token = "0x60004A1")]
		[Address(RVA = "0xECCCFC", Offset = "0xECCCFC", VA = "0xECCCFC", Slot = "11")]
		public virtual EngineError seekToSample(uint samplePosition)
		{
			return default(EngineError);
		}

		[Token(Token = "0x60004A2")]
		[Address(RVA = "0xECCD7C", Offset = "0xECCD7C", VA = "0xECCD7C", Slot = "12")]
		public virtual uint decode(float[] bufferOut, int numOfSamplesInBuffer)
		{
			return default(uint);
		}

		[Token(Token = "0x60004A3")]
		[Address(RVA = "0xECCE04", Offset = "0xECCE04", VA = "0xECCE04", Slot = "13")]
		public virtual float getSampleRate()
		{
			return default(float);
		}

		[Token(Token = "0x60004A4")]
		[Address(RVA = "0xECCE74", Offset = "0xECCE74", VA = "0xECCE74", Slot = "14")]
		public virtual float getOutputSampleRate()
		{
			return default(float);
		}

		[Token(Token = "0x60004A5")]
		[Address(RVA = "0xECCEE4", Offset = "0xECCEE4", VA = "0xECCEE4", Slot = "15")]
		public virtual int getNumBits()
		{
			return default(int);
		}

		[Token(Token = "0x60004A6")]
		[Address(RVA = "0xECCF54", Offset = "0xECCF54", VA = "0xECCF54", Slot = "16")]
		public virtual bool endOfStream()
		{
			return default(bool);
		}

		[Token(Token = "0x60004A7")]
		[Address(RVA = "0xECCFC4", Offset = "0xECCFC4", VA = "0xECCFC4", Slot = "17")]
		public virtual bool decoderError()
		{
			return default(bool);
		}

		[Token(Token = "0x60004A8")]
		[Address(RVA = "0xECD034", Offset = "0xECD034", VA = "0xECD034", Slot = "18")]
		public virtual int getMaxBufferSizePerChannel()
		{
			return default(int);
		}

		[Token(Token = "0x60004A9")]
		[Address(RVA = "0xECD0A4", Offset = "0xECD0A4", VA = "0xECD0A4", Slot = "19")]
		public virtual string getName()
		{
			return null;
		}

		[Token(Token = "0x60004AA")]
		[Address(RVA = "0xECD114", Offset = "0xECD114", VA = "0xECD114", Slot = "20")]
		public virtual void flush(bool resetToZero)
		{
		}

		[Token(Token = "0x60004AB")]
		[Address(RVA = "0xECD194", Offset = "0xECD194", VA = "0xECD194", Slot = "21")]
		public virtual void flush()
		{
		}

		[Token(Token = "0x60004AC")]
		[Address(RVA = "0xECD204", Offset = "0xECD204", VA = "0xECD204", Slot = "22")]
		public virtual int getInfo(Info info)
		{
			return default(int);
		}

		[Token(Token = "0x60004AD")]
		[Address(RVA = "0xECD284", Offset = "0xECD284", VA = "0xECD284", Slot = "23")]
		public virtual ChannelMap getChannelMap()
		{
			return default(ChannelMap);
		}

		[Token(Token = "0x60004AE")]
		[Address(RVA = "0xECD2F4", Offset = "0xECD2F4", VA = "0xECD2F4")]
		public static AudioFormatDecoder create(string file, int maxBufferSizePerChannel, float outputSampleRate)
		{
			return null;
		}

		[Token(Token = "0x60004AF")]
		[Address(RVA = "0xECD3BC", Offset = "0xECD3BC", VA = "0xECD3BC")]
		public static AudioFormatDecoder create(string file, int maxBufferSizePerChannel)
		{
			return null;
		}

		[Token(Token = "0x60004B0")]
		[Address(RVA = "0xECD474", Offset = "0xECD474", VA = "0xECD474")]
		public static AudioFormatDecoder create(IOStream stream, bool decoderOwnsStream, int maxBufferSizePerChannel, float outputSampleRate)
		{
			return null;
		}

		[Token(Token = "0x60004B1")]
		[Address(RVA = "0xECD5CC", Offset = "0xECD5CC", VA = "0xECD5CC")]
		public static AudioFormatDecoder create(IOStream stream, bool decoderOwnsStream, int maxBufferSizePerChannel)
		{
			return null;
		}
	}
	[Token(Token = "0x2000063")]
	public class AudioFormatEncoder : IDisposable
	{
		[Token(Token = "0x400018E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private HandleRef swigCPtr;

		[Token(Token = "0x400018F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		protected bool swigCMemOwn;

		[Token(Token = "0x60004B2")]
		[Address(RVA = "0xECD6A0", Offset = "0xECD6A0", VA = "0xECD6A0")]
		internal AudioFormatEncoder(IntPtr cPtr, bool cMemoryOwn)
		{
		}

		[Token(Token = "0x60004B3")]
		[Address(RVA = "0xECD704", Offset = "0xECD704", VA = "0xECD704")]
		public static HandleRef getCPtr(AudioFormatEncoder obj)
		{
			return default(HandleRef);
		}

		[Token(Token = "0x60004B4")]
		[Address(RVA = "0xECD778", Offset = "0xECD778", VA = "0xECD778", Slot = "1")]
		~AudioFormatEncoder()
		{
		}

		[Token(Token = "0x60004B5")]
		[Address(RVA = "0xECD7EC", Offset = "0xECD7EC", VA = "0xECD7EC", Slot = "4")]
		public void Dispose()
		{
		}

		[Token(Token = "0x60004B6")]
		[Address(RVA = "0xECD868", Offset = "0xECD868", VA = "0xECD868", Slot = "5")]
		protected virtual void Dispose(bool disposing)
		{
		}

		[Token(Token = "0x60004B7")]
		[Address(RVA = "0xECD998", Offset = "0xECD998", VA = "0xECD998", Slot = "6")]
		public virtual uint encode(float[] inputInterleavedAudio, uint totalNumSamples, bool endOfStream)
		{
			return default(uint);
		}

		[Token(Token = "0x60004B8")]
		[Address(RVA = "0xECDA30", Offset = "0xECDA30", VA = "0xECDA30", Slot = "7")]
		public virtual AudioFormat getAudioFormat()
		{
			return default(AudioFormat);
		}

		[Token(Token = "0x60004B9")]
		[Address(RVA = "0xECDAA0", Offset = "0xECDAA0", VA = "0xECDAA0", Slot = "8")]
		public virtual EngineError getQualityIndex(ref int qualityIndex)
		{
			return default(EngineError);
		}

		[Token(Token = "0x60004BA")]
		[Address(RVA = "0xECDB20", Offset = "0xECDB20", VA = "0xECDB20", Slot = "9")]
		public virtual EngineError getBitRate(ref int bitRate)
		{
			return default(EngineError);
		}

		[Token(Token = "0x60004BB")]
		[Address(RVA = "0xECDBA0", Offset = "0xECDBA0", VA = "0xECDBA0", Slot = "10")]
		public virtual float getOutputSampleRate()
		{
			return default(float);
		}

		[Token(Token = "0x60004BC")]
		[Address(RVA = "0xECDC10", Offset = "0xECDC10", VA = "0xECDC10", Slot = "11")]
		public virtual int getNumOfChannels()
		{
			return default(int);
		}

		[Token(Token = "0x60004BD")]
		[Address(RVA = "0xECDC80", Offset = "0xECDC80", VA = "0xECDC80", Slot = "12")]
		public virtual uint getMaxBufferSize()
		{
			return default(uint);
		}

		[Token(Token = "0x60004BE")]
		[Address(RVA = "0xECDCF0", Offset = "0xECDCF0", VA = "0xECDCF0")]
		public static EngineError getBitRateForQualityIndex(AudioFormat format, int qualityIndex, ref int bitRate)
		{
			return default(EngineError);
		}

		[Token(Token = "0x60004BF")]
		[Address(RVA = "0xECDD70", Offset = "0xECDD70", VA = "0xECDD70")]
		public static EngineError getIndexForQuality(AudioFormat format, AudioFormatQuality quality, ref int qualityIndex)
		{
			return default(EngineError);
		}

		[Token(Token = "0x60004C0")]
		[Address(RVA = "0xECDDF0", Offset = "0xECDDF0", VA = "0xECDDF0")]
		public static AudioFormatEncoder create(IOStream outputStream, AudioFormat format, float inputSampleRate, float outputSampleRate, uint maxBufferSize, int numChannels, AudioFormatQuality quality)
		{
			return null;
		}
	}
	[Token(Token = "0x2000064")]
	public enum AudioFormatQuality
	{
		[Token(Token = "0x4000191")]
		LOW,
		[Token(Token = "0x4000192")]
		MEDIUM,
		[Token(Token = "0x4000193")]
		HIGH,
		[Token(Token = "0x4000194")]
		VERY_HIGH
	}
	[Token(Token = "0x2000065")]
	public class AudioResampler : IDisposable
	{
		[Token(Token = "0x20000A3")]
		public enum Quality
		{
			[Token(Token = "0x40002AC")]
			OPTIMAL,
			[Token(Token = "0x40002AD")]
			FAST
		}

		[Token(Token = "0x4000195")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private HandleRef swigCPtr;

		[Token(Token = "0x4000196")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		protected bool swigCMemOwn;

		[Token(Token = "0x60004C1")]
		[Address(RVA = "0xED0A14", Offset = "0xED0A14", VA = "0xED0A14")]
		internal AudioResampler(IntPtr cPtr, bool cMemoryOwn)
		{
		}

		[Token(Token = "0x60004C2")]
		[Address(RVA = "0xED0A78", Offset = "0xED0A78", VA = "0xED0A78")]
		public static HandleRef getCPtr(AudioResampler obj)
		{
			return default(HandleRef);
		}

		[Token(Token = "0x60004C3")]
		[Address(RVA = "0xED0AEC", Offset = "0xED0AEC", VA = "0xED0AEC", Slot = "1")]
		~AudioResampler()
		{
		}

		[Token(Token = "0x60004C4")]
		[Address(RVA = "0xED0B60", Offset = "0xED0B60", VA = "0xED0B60", Slot = "4")]
		public void Dispose()
		{
		}

		[Token(Token = "0x60004C5")]
		[Address(RVA = "0xED0BDC", Offset = "0xED0BDC", VA = "0xED0BDC", Slot = "5")]
		protected virtual void Dispose(bool disposing)
		{
		}

		[Token(Token = "0x60004C6")]
		[Address(RVA = "0xED0D0C", Offset = "0xED0D0C", VA = "0xED0D0C", Slot = "6")]
		public virtual uint process(float[] input, uint totalInputSamples, float[] output, uint totalOutputSamples, bool endOfStream)
		{
			return default(uint);
		}

		[Token(Token = "0x60004C7")]
		[Address(RVA = "0xED0DBC", Offset = "0xED0DBC", VA = "0xED0DBC", Slot = "7")]
		public virtual int getNumChannels()
		{
			return default(int);
		}

		[Token(Token = "0x60004C8")]
		[Address(RVA = "0xED0E2C", Offset = "0xED0E2C", VA = "0xED0E2C", Slot = "8")]
		public virtual float getInputSampleRate()
		{
			return default(float);
		}

		[Token(Token = "0x60004C9")]
		[Address(RVA = "0xED0E9C", Offset = "0xED0E9C", VA = "0xED0E9C", Slot = "9")]
		public virtual float getOutputSampleRate()
		{
			return default(float);
		}

		[Token(Token = "0x60004CA")]
		[Address(RVA = "0xED0F0C", Offset = "0xED0F0C", VA = "0xED0F0C", Slot = "10")]
		public virtual Quality getQuality()
		{
			return default(Quality);
		}

		[Token(Token = "0x60004CB")]
		[Address(RVA = "0xED0F7C", Offset = "0xED0F7C", VA = "0xED0F7C", Slot = "11")]
		public virtual void setRatio(double resamplingRatio)
		{
		}

		[Token(Token = "0x60004CC")]
		[Address(RVA = "0xED0FFC", Offset = "0xED0FFC", VA = "0xED0FFC", Slot = "12")]
		public virtual double getRatio()
		{
			return default(double);
		}

		[Token(Token = "0x60004CD")]
		[Address(RVA = "0xED106C", Offset = "0xED106C", VA = "0xED106C", Slot = "13")]
		public virtual void reset()
		{
		}

		[Token(Token = "0x60004CE")]
		[Address(RVA = "0xED10DC", Offset = "0xED10DC", VA = "0xED10DC")]
		public static AudioResampler create(uint numChannels, float inputSampleRate, float outputSampleRate, uint maxBufferSize, Quality quality)
		{
			return null;
		}
	}
	[Token(Token = "0x2000066")]
	public class AudioSettings : IDisposable
	{
		[Token(Token = "0x4000197")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private HandleRef swigCPtr;

		[Token(Token = "0x4000198")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		protected bool swigCMemOwn;

		[Token(Token = "0x17000054")]
		public float sampleRate
		{
			[Token(Token = "0x60004D5")]
			[Address(RVA = "0xED14AC", Offset = "0xED14AC", VA = "0xED14AC")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60004D4")]
			[Address(RVA = "0xECB774", Offset = "0xECB774", VA = "0xECB774")]
			set
			{
			}
		}

		[Token(Token = "0x17000055")]
		public int bufferSize
		{
			[Token(Token = "0x60004D7")]
			[Address(RVA = "0xED159C", Offset = "0xED159C", VA = "0xED159C")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60004D6")]
			[Address(RVA = "0xED151C", Offset = "0xED151C", VA = "0xED151C")]
			set
			{
			}
		}

		[Token(Token = "0x17000056")]
		public AudioDeviceType deviceType
		{
			[Token(Token = "0x60004D9")]
			[Address(RVA = "0xECB874", Offset = "0xECB874", VA = "0xECB874")]
			get
			{
				return default(AudioDeviceType);
			}
			[Token(Token = "0x60004D8")]
			[Address(RVA = "0xECB7F4", Offset = "0xECB7F4", VA = "0xECB7F4")]
			set
			{
			}
		}

		[Token(Token = "0x17000057")]
		public string customAudioDeviceName
		{
			[Token(Token = "0x60004DB")]
			[Address(RVA = "0xED160C", Offset = "0xED160C", VA = "0xED160C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60004DA")]
			[Address(RVA = "0xECB8E4", Offset = "0xECB8E4", VA = "0xECB8E4")]
			set
			{
			}
		}

		[Token(Token = "0x60004CF")]
		[Address(RVA = "0xED11B4", Offset = "0xED11B4", VA = "0xED11B4")]
		internal AudioSettings(IntPtr cPtr, bool cMemoryOwn)
		{
		}

		[Token(Token = "0x60004D0")]
		[Address(RVA = "0xED1218", Offset = "0xED1218", VA = "0xED1218")]
		public static HandleRef getCPtr(AudioSettings obj)
		{
			return default(HandleRef);
		}

		[Token(Token = "0x60004D1")]
		[Address(RVA = "0xED128C", Offset = "0xED128C", VA = "0xED128C", Slot = "1")]
		~AudioSettings()
		{
		}

		[Token(Token = "0x60004D2")]
		[Address(RVA = "0xED1300", Offset = "0xED1300", VA = "0xED1300", Slot = "4")]
		public void Dispose()
		{
		}

		[Token(Token = "0x60004D3")]
		[Address(RVA = "0xED137C", Offset = "0xED137C", VA = "0xED137C", Slot = "5")]
		protected virtual void Dispose(bool disposing)
		{
		}

		[Token(Token = "0x60004DC")]
		[Address(RVA = "0xED167C", Offset = "0xED167C", VA = "0xED167C")]
		public AudioSettings()
		{
		}
	}
	[Token(Token = "0x2000067")]
	public enum ChannelMap
	{
		[Token(Token = "0x400019A")]
		TBE_8_2,
		[Token(Token = "0x400019B")]
		TBE_8,
		[Token(Token = "0x400019C")]
		TBE_6_2,
		[Token(Token = "0x400019D")]
		TBE_6,
		[Token(Token = "0x400019E")]
		TBE_4_2,
		[Token(Token = "0x400019F")]
		TBE_4,
		[Token(Token = "0x40001A0")]
		TBE_8_PAIR0,
		[Token(Token = "0x40001A1")]
		TBE_8_PAIR1,
		[Token(Token = "0x40001A2")]
		TBE_8_PAIR2,
		[Token(Token = "0x40001A3")]
		TBE_8_PAIR3,
		[Token(Token = "0x40001A4")]
		TBE_CHANNEL0,
		[Token(Token = "0x40001A5")]
		TBE_CHANNEL1,
		[Token(Token = "0x40001A6")]
		TBE_CHANNEL2,
		[Token(Token = "0x40001A7")]
		TBE_CHANNEL3,
		[Token(Token = "0x40001A8")]
		TBE_CHANNEL4,
		[Token(Token = "0x40001A9")]
		TBE_CHANNEL5,
		[Token(Token = "0x40001AA")]
		TBE_CHANNEL6,
		[Token(Token = "0x40001AB")]
		TBE_CHANNEL7,
		[Token(Token = "0x40001AC")]
		HEADLOCKED_STEREO,
		[Token(Token = "0x40001AD")]
		HEADLOCKED_CHANNEL0,
		[Token(Token = "0x40001AE")]
		HEADLOCKED_CHANNEL1,
		[Token(Token = "0x40001AF")]
		AMBIX_4,
		[Token(Token = "0x40001B0")]
		AMBIX_4_2,
		[Token(Token = "0x40001B1")]
		AMBIX_9,
		[Token(Token = "0x40001B2")]
		AMBIX_9_2,
		[Token(Token = "0x40001B3")]
		AMBIX_16,
		[Token(Token = "0x40001B4")]
		AMBIX_16_2,
		[Token(Token = "0x40001B5")]
		MONO,
		[Token(Token = "0x40001B6")]
		STEREO,
		[Token(Token = "0x40001B7")]
		UNKNOWN,
		[Token(Token = "0x40001B8")]
		INVALID
	}
	[Token(Token = "0x2000068")]
	public class DirectionalProps : IDisposable
	{
		[Token(Token = "0x40001B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private HandleRef swigCPtr;

		[Token(Token = "0x40001BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		protected bool swigCMemOwn;

		[Token(Token = "0x17000058")]
		public float effectLevel
		{
			[Token(Token = "0x60004E3")]
			[Address(RVA = "0xED1A68", Offset = "0xED1A68", VA = "0xED1A68")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60004E2")]
			[Address(RVA = "0xED19E8", Offset = "0xED19E8", VA = "0xED19E8")]
			set
			{
			}
		}

		[Token(Token = "0x17000059")]
		public float coneArea
		{
			[Token(Token = "0x60004E5")]
			[Address(RVA = "0xED1B58", Offset = "0xED1B58", VA = "0xED1B58")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60004E4")]
			[Address(RVA = "0xED1AD8", Offset = "0xED1AD8", VA = "0xED1AD8")]
			set
			{
			}
		}

		[Token(Token = "0x60004DD")]
		[Address(RVA = "0xED16F0", Offset = "0xED16F0", VA = "0xED16F0")]
		internal DirectionalProps(IntPtr cPtr, bool cMemoryOwn)
		{
		}

		[Token(Token = "0x60004DE")]
		[Address(RVA = "0xED1754", Offset = "0xED1754", VA = "0xED1754")]
		public static HandleRef getCPtr(DirectionalProps obj)
		{
			return default(HandleRef);
		}

		[Token(Token = "0x60004DF")]
		[Address(RVA = "0xED17C8", Offset = "0xED17C8", VA = "0xED17C8", Slot = "1")]
		~DirectionalProps()
		{
		}

		[Token(Token = "0x60004E0")]
		[Address(RVA = "0xED183C", Offset = "0xED183C", VA = "0xED183C", Slot = "4")]
		public void Dispose()
		{
		}

		[Token(Token = "0x60004E1")]
		[Address(RVA = "0xED18B8", Offset = "0xED18B8", VA = "0xED18B8", Slot = "5")]
		protected virtual void Dispose(bool disposing)
		{
		}

		[Token(Token = "0x60004E6")]
		[Address(RVA = "0xED02A0", Offset = "0xED02A0", VA = "0xED02A0")]
		public DirectionalProps()
		{
		}

		[Token(Token = "0x60004E7")]
		[Address(RVA = "0xED1BC8", Offset = "0xED1BC8", VA = "0xED1BC8")]
		public DirectionalProps(float effectLevelValue, float coneAreaValue)
		{
		}

		[Token(Token = "0x60004E8")]
		[Address(RVA = "0xECF048", Offset = "0xECF048", VA = "0xECF048")]
		public void set(float effectLevelValue, float coneAreaValue)
		{
		}
	}
	[Token(Token = "0x2000069")]
	public enum EffectIndex
	{
		[Token(Token = "0x40001BC")]
		EFFECT_1,
		[Token(Token = "0x40001BD")]
		EFFECT_2,
		[Token(Token = "0x40001BE")]
		EFFECT_3,
		[Token(Token = "0x40001BF")]
		EFFECT_4,
		[Token(Token = "0x40001C0")]
		EFFECT_5,
		[Token(Token = "0x40001C1")]
		NUM_EFFECTS
	}
	[Token(Token = "0x200006A")]
	public enum EffectParam
	{
		[Token(Token = "0x40001C3")]
		FILTER_CENTER_FRQUENCY,
		[Token(Token = "0x40001C4")]
		FILTER_Q,
		[Token(Token = "0x40001C5")]
		FILTER_GAIN
	}
	[Token(Token = "0x200006B")]
	public enum EffectType
	{
		[Token(Token = "0x40001C7")]
		FILTER_LOW_PASS,
		[Token(Token = "0x40001C8")]
		FILTER_HIGH_PASS,
		[Token(Token = "0x40001C9")]
		FILTER_BAND_PASS,
		[Token(Token = "0x40001CA")]
		INVALID
	}
	[Token(Token = "0x200006C")]
	public enum EngineError
	{
		[Token(Token = "0x40001CC")]
		CANNOT_CREATE_VOICE = -29,
		[Token(Token = "0x40001CD")]
		VOICE_LIMIT_REACHED,
		[Token(Token = "0x40001CE")]
		VOICE_NOT_FOUND,
		[Token(Token = "0x40001CF")]
		DECODER_FAIL,
		[Token(Token = "0x40001D0")]
		INVALID_CHANNEL_MAP,
		[Token(Token = "0x40001D1")]
		NOT_INITIALISED,
		[Token(Token = "0x40001D2")]
		INVALID_PARAM,
		[Token(Token = "0x40001D3")]
		INVALID_QUALITY,
		[Token(Token = "0x40001D4")]
		QUEUE_FULL,
		[Token(Token = "0x40001D5")]
		BAD_THREAD,
		[Token(Token = "0x40001D6")]
		NOT_SUPPORTED,
		[Token(Token = "0x40001D7")]
		NO_AUDIO_DEVICE,
		[Token(Token = "0x40001D8")]
		COULD_NOT_CONNECT,
		[Token(Token = "0x40001D9")]
		MEMORY_MAP_FAIL,
		[Token(Token = "0x40001DA")]
		INVALID_URL_FORMAT,
		[Token(Token = "0x40001DB")]
		ERROR_OPENING_TEMP_FILE,
		[Token(Token = "0x40001DC")]
		INVALID_HEADER,
		[Token(Token = "0x40001DD")]
		CURL_FAIL,
		[Token(Token = "0x40001DE")]
		INVALID_CHANNEL_COUNT,
		[Token(Token = "0x40001DF")]
		CANNOT_INIT_DECODER,
		[Token(Token = "0x40001E0")]
		ERROR_OPENING_FILE,
		[Token(Token = "0x40001E1")]
		NO_ASSET,
		[Token(Token = "0x40001E2")]
		CANNOT_ALLOCATE_MEMORY,
		[Token(Token = "0x40001E3")]
		CANNOT_CREATE_AUDIO_DEVICE,
		[Token(Token = "0x40001E4")]
		CANNOT_INITIALISE_CORE,
		[Token(Token = "0x40001E5")]
		INVALID_BUFFER_SIZE,
		[Token(Token = "0x40001E6")]
		INVALID_SAMPLE_RATE,
		[Token(Token = "0x40001E7")]
		NO_OBJECTS_IN_POOL,
		[Token(Token = "0x40001E8")]
		FAIL,
		[Token(Token = "0x40001E9")]
		OK,
		[Token(Token = "0x40001EA")]
		PENDING
	}
	[Token(Token = "0x200006D")]
	public class EngineInitSettings : IDisposable
	{
		[Token(Token = "0x40001EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private HandleRef swigCPtr;

		[Token(Token = "0x40001EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		protected bool swigCMemOwn;

		[Token(Token = "0x1700005A")]
		public AudioSettings audioSettings
		{
			[Token(Token = "0x60004EF")]
			[Address(RVA = "0xECB6C4", Offset = "0xECB6C4", VA = "0xECB6C4")]
			get
			{
				return null;
			}
			[Token(Token = "0x60004EE")]
			[Address(RVA = "0xED1ED8", Offset = "0xED1ED8", VA = "0xED1ED8")]
			set
			{
			}
		}

		[Token(Token = "0x1700005B")]
		public MemorySettings memorySettings
		{
			[Token(Token = "0x60004F1")]
			[Address(RVA = "0xECB594", Offset = "0xECB594", VA = "0xECB594")]
			get
			{
				return null;
			}
			[Token(Token = "0x60004F0")]
			[Address(RVA = "0xED1F6C", Offset = "0xED1F6C", VA = "0xED1F6C")]
			set
			{
			}
		}

		[Token(Token = "0x1700005C")]
		public PlatformSettings platformSettings
		{
			[Token(Token = "0x60004F3")]
			[Address(RVA = "0xED21E0", Offset = "0xED21E0", VA = "0xED21E0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60004F2")]
			[Address(RVA = "0xED20D8", Offset = "0xED20D8", VA = "0xED20D8")]
			set
			{
			}
		}

		[Token(Token = "0x1700005D")]
		public ThreadSettings threads
		{
			[Token(Token = "0x60004F5")]
			[Address(RVA = "0xED238C", Offset = "0xED238C", VA = "0xED238C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60004F4")]
			[Address(RVA = "0xED22F4", Offset = "0xED22F4", VA = "0xED22F4")]
			set
			{
			}
		}

		[Token(Token = "0x1700005E")]
		public Experimental experimental
		{
			[Token(Token = "0x60004F7")]
			[Address(RVA = "0xECBAE4", Offset = "0xECBAE4", VA = "0xECBAE4")]
			get
			{
				return null;
			}
			[Token(Token = "0x60004F6")]
			[Address(RVA = "0xED2440", Offset = "0xED2440", VA = "0xED2440")]
			set
			{
			}
		}

		[Token(Token = "0x1700005F")]
		public VoiceManagerSettings voiceManagerSettings
		{
			[Token(Token = "0x60004F9")]
			[Address(RVA = "0xECBC14", Offset = "0xECBC14", VA = "0xECBC14")]
			get
			{
				return null;
			}
			[Token(Token = "0x60004F8")]
			[Address(RVA = "0xED25AC", Offset = "0xED25AC", VA = "0xED25AC")]
			set
			{
			}
		}

		[Token(Token = "0x60004E9")]
		[Address(RVA = "0xED1C54", Offset = "0xED1C54", VA = "0xED1C54")]
		internal EngineInitSettings(IntPtr cPtr, bool cMemoryOwn)
		{
		}

		[Token(Token = "0x60004EA")]
		[Address(RVA = "0xECA064", Offset = "0xECA064", VA = "0xECA064")]
		public static HandleRef getCPtr(EngineInitSettings obj)
		{
			return default(HandleRef);
		}

		[Token(Token = "0x60004EB")]
		[Address(RVA = "0xED1CB8", Offset = "0xED1CB8", VA = "0xED1CB8", Slot = "1")]
		~EngineInitSettings()
		{
		}

		[Token(Token = "0x60004EC")]
		[Address(RVA = "0xED1D2C", Offset = "0xED1D2C", VA = "0xED1D2C", Slot = "4")]
		public void Dispose()
		{
		}

		[Token(Token = "0x60004ED")]
		[Address(RVA = "0xED1DA8", Offset = "0xED1DA8", VA = "0xED1DA8", Slot = "5")]
		protected virtual void Dispose(bool disposing)
		{
		}

		[Token(Token = "0x60004FA")]
		[Address(RVA = "0xECB520", Offset = "0xECB520", VA = "0xECB520")]
		public EngineInitSettings()
		{
		}
	}
	[Token(Token = "0x200006E")]
	public class EngineStatistics : IDisposable
	{
		[Token(Token = "0x40001ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private HandleRef swigCPtr;

		[Token(Token = "0x40001EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		protected bool swigCMemOwn;

		[Token(Token = "0x17000060")]
		public uint audioCallbackTimeMicroSec
		{
			[Token(Token = "0x6000501")]
			[Address(RVA = "0xECBF1C", Offset = "0xECBF1C", VA = "0xECBF1C")]
			get
			{
				return default(uint);
			}
			[Token(Token = "0x6000500")]
			[Address(RVA = "0xED28D8", Offset = "0xED28D8", VA = "0xED28D8")]
			set
			{
			}
		}

		[Token(Token = "0x17000061")]
		public uint decoderThreadTimeMicroSec
		{
			[Token(Token = "0x6000503")]
			[Address(RVA = "0xECBF8C", Offset = "0xECBF8C", VA = "0xECBF8C")]
			get
			{
				return default(uint);
			}
			[Token(Token = "0x6000502")]
			[Address(RVA = "0xED2958", Offset = "0xED2958", VA = "0xED2958")]
			set
			{
			}
		}

		[Token(Token = "0x17000062")]
		public uint numActiveAudioObjects
		{
			[Token(Token = "0x6000505")]
			[Address(RVA = "0xECBFFC", Offset = "0xECBFFC", VA = "0xECBFFC")]
			get
			{
				return default(uint);
			}
			[Token(Token = "0x6000504")]
			[Address(RVA = "0xED29D8", Offset = "0xED29D8", VA = "0xED29D8")]
			set
			{
			}
		}

		[Token(Token = "0x17000063")]
		public uint numAudioObjectsPlaying
		{
			[Token(Token = "0x6000507")]
			[Address(RVA = "0xECC06C", Offset = "0xECC06C", VA = "0xECC06C")]
			get
			{
				return default(uint);
			}
			[Token(Token = "0x6000506")]
			[Address(RVA = "0xED2A58", Offset = "0xED2A58", VA = "0xED2A58")]
			set
			{
			}
		}

		[Token(Token = "0x17000064")]
		public uint numActiveSpatDecoderFiles
		{
			[Token(Token = "0x6000509")]
			[Address(RVA = "0xED2B58", Offset = "0xED2B58", VA = "0xED2B58")]
			get
			{
				return default(uint);
			}
			[Token(Token = "0x6000508")]
			[Address(RVA = "0xED2AD8", Offset = "0xED2AD8", VA = "0xED2AD8")]
			set
			{
			}
		}

		[Token(Token = "0x17000065")]
		public uint numSpatDecoderFilesPlaying
		{
			[Token(Token = "0x600050B")]
			[Address(RVA = "0xED2C48", Offset = "0xED2C48", VA = "0xED2C48")]
			get
			{
				return default(uint);
			}
			[Token(Token = "0x600050A")]
			[Address(RVA = "0xED2BC8", Offset = "0xED2BC8", VA = "0xED2BC8")]
			set
			{
			}
		}

		[Token(Token = "0x17000066")]
		public uint numActiveSpatDecoderQueues
		{
			[Token(Token = "0x600050D")]
			[Address(RVA = "0xECC0DC", Offset = "0xECC0DC", VA = "0xECC0DC")]
			get
			{
				return default(uint);
			}
			[Token(Token = "0x600050C")]
			[Address(RVA = "0xED2CB8", Offset = "0xED2CB8", VA = "0xED2CB8")]
			set
			{
			}
		}

		[Token(Token = "0x17000067")]
		public uint numSpatDecoderQueuesPlaying
		{
			[Token(Token = "0x600050F")]
			[Address(RVA = "0xECC14C", Offset = "0xECC14C", VA = "0xECC14C")]
			get
			{
				return default(uint);
			}
			[Token(Token = "0x600050E")]
			[Address(RVA = "0xED2D38", Offset = "0xED2D38", VA = "0xED2D38")]
			set
			{
			}
		}

		[Token(Token = "0x60004FB")]
		[Address(RVA = "0xEC9890", Offset = "0xEC9890", VA = "0xEC9890")]
		internal EngineStatistics(IntPtr cPtr, bool cMemoryOwn)
		{
		}

		[Token(Token = "0x60004FC")]
		[Address(RVA = "0xED2644", Offset = "0xED2644", VA = "0xED2644")]
		public static HandleRef getCPtr(EngineStatistics obj)
		{
			return default(HandleRef);
		}

		[Token(Token = "0x60004FD")]
		[Address(RVA = "0xED26B8", Offset = "0xED26B8", VA = "0xED26B8", Slot = "1")]
		~EngineStatistics()
		{
		}

		[Token(Token = "0x60004FE")]
		[Address(RVA = "0xED272C", Offset = "0xED272C", VA = "0xED272C", Slot = "4")]
		public void Dispose()
		{
		}

		[Token(Token = "0x60004FF")]
		[Address(RVA = "0xED27A8", Offset = "0xED27A8", VA = "0xED27A8", Slot = "5")]
		protected virtual void Dispose(bool disposing)
		{
		}

		[Token(Token = "0x6000510")]
		[Address(RVA = "0xED2DB8", Offset = "0xED2DB8", VA = "0xED2DB8")]
		public EngineStatistics()
		{
		}
	}
	[Token(Token = "0x200006F")]
	public enum Event
	{
		[Token(Token = "0x40001F0")]
		ERROR_BUFFER_UNDERRUN,
		[Token(Token = "0x40001F1")]
		ERROR_QUEUE_STARVATION,
		[Token(Token = "0x40001F2")]
		DECODER_INIT,
		[Token(Token = "0x40001F3")]
		END_OF_STREAM,
		[Token(Token = "0x40001F4")]
		LOOPED,
		[Token(Token = "0x40001F5")]
		PLAY_STATE_CHANGED,
		[Token(Token = "0x40001F6")]
		ERROR_DECODER_FAIL,
		[Token(Token = "0x40001F7")]
		INVALID
	}
	[Token(Token = "0x2000070")]
	public class EventTransport : TransportControl
	{
		[Token(Token = "0x40001F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private HandleRef swigCPtr;

		[Token(Token = "0x6000511")]
		[Address(RVA = "0xECA99C", Offset = "0xECA99C", VA = "0xECA99C")]
		internal EventTransport(IntPtr cPtr, bool cMemoryOwn)
		{
		}

		[Token(Token = "0x6000512")]
		[Address(RVA = "0xEC8340", Offset = "0xEC8340", VA = "0xEC8340")]
		public static HandleRef getCPtr(EventTransport obj)
		{
			return default(HandleRef);
		}

		[Token(Token = "0x6000513")]
		[Address(RVA = "0xED34A4", Offset = "0xED34A4", VA = "0xED34A4", Slot = "5")]
		protected override void Dispose(bool disposing)
		{
		}

		[Token(Token = "0x6000514")]
		[Address(RVA = "0xED35EC", Offset = "0xED35EC", VA = "0xED35EC", Slot = "20")]
		public virtual EngineError open(string nameAndPath)
		{
			return default(EngineError);
		}

		[Token(Token = "0x6000515")]
		[Address(RVA = "0xED366C", Offset = "0xED366C", VA = "0xED366C", Slot = "21")]
		public virtual EngineError open(IntPtr buffer, uint size)
		{
			return default(EngineError);
		}

		[Token(Token = "0x6000516")]
		[Address(RVA = "0xED36F4", Offset = "0xED36F4", VA = "0xED36F4", Slot = "22")]
		public virtual EngineError open(float tempo, byte timeSigNumerator, byte timeSigDenominator, float lengthInBars)
		{
			return default(EngineError);
		}

		[Token(Token = "0x6000517")]
		[Address(RVA = "0xED3794", Offset = "0xED3794", VA = "0xED3794", Slot = "23")]
		public virtual void close()
		{
		}

		[Token(Token = "0x6000518")]
		[Address(RVA = "0xED3804", Offset = "0xED3804", VA = "0xED3804", Slot = "24")]
		public virtual bool isOpen()
		{
			return default(bool);
		}

		[Token(Token = "0x6000519")]
		[Address(RVA = "0xED3874", Offset = "0xED3874", VA = "0xED3874", Slot = "25")]
		public virtual EngineError setEventCallback(EventTransportCallback callback, IntPtr userData)
		{
			return default(EngineError);
		}

		[Token(Token = "0x600051A")]
		[Address(RVA = "0xED38FC", Offset = "0xED38FC", VA = "0xED38FC", Slot = "26")]
		public virtual EngineError getEvents(EventTransportCallback callback, IntPtr userData, uint startSample, uint numSamples)
		{
			return default(EngineError);
		}

		[Token(Token = "0x600051B")]
		[Address(RVA = "0xED399C", Offset = "0xED399C", VA = "0xED399C", Slot = "27")]
		public virtual bool enableLooping(bool loop)
		{
			return default(bool);
		}

		[Token(Token = "0x600051C")]
		[Address(RVA = "0xED3A1C", Offset = "0xED3A1C", VA = "0xED3A1C", Slot = "28")]
		public virtual bool loopingEnabled()
		{
			return default(bool);
		}

		[Token(Token = "0x600051D")]
		[Address(RVA = "0xED3A8C", Offset = "0xED3A8C", VA = "0xED3A8C", Slot = "29")]
		public virtual void setSpeed(float speed)
		{
		}

		[Token(Token = "0x600051E")]
		[Address(RVA = "0xED3B0C", Offset = "0xED3B0C", VA = "0xED3B0C", Slot = "30")]
		public virtual float getSpeed()
		{
			return default(float);
		}

		[Token(Token = "0x600051F")]
		[Address(RVA = "0xED3B7C", Offset = "0xED3B7C", VA = "0xED3B7C", Slot = "31")]
		public virtual EngineError seekToSample(uint timeInSamples)
		{
			return default(EngineError);
		}

		[Token(Token = "0x6000520")]
		[Address(RVA = "0xED3BFC", Offset = "0xED3BFC", VA = "0xED3BFC", Slot = "32")]
		public virtual EngineError seekToMs(float timeInMs)
		{
			return default(EngineError);
		}

		[Token(Token = "0x6000521")]
		[Address(RVA = "0xED3C7C", Offset = "0xED3C7C", VA = "0xED3C7C", Slot = "33")]
		public virtual uint getElapsedTimeInSamples()
		{
			return default(uint);
		}

		[Token(Token = "0x6000522")]
		[Address(RVA = "0xED3CEC", Offset = "0xED3CEC", VA = "0xED3CEC", Slot = "34")]
		public virtual float getElapsedTimeInMs()
		{
			return default(float);
		}

		[Token(Token = "0x6000523")]
		[Address(RVA = "0xED3D5C", Offset = "0xED3D5C", VA = "0xED3D5C", Slot = "35")]
		public virtual float getElapsedTimeInBars()
		{
			return default(float);
		}

		[Token(Token = "0x6000524")]
		[Address(RVA = "0xED3DCC", Offset = "0xED3DCC", VA = "0xED3DCC", Slot = "36")]
		public virtual uint getAssetDurationInSamples()
		{
			return default(uint);
		}

		[Token(Token = "0x6000525")]
		[Address(RVA = "0xED3E3C", Offset = "0xED3E3C", VA = "0xED3E3C", Slot = "37")]
		public virtual float getAssetDurationInMs()
		{
			return default(float);
		}

		[Token(Token = "0x6000526")]
		[Address(RVA = "0xED3EAC", Offset = "0xED3EAC", VA = "0xED3EAC", Slot = "38")]
		public virtual float getAssetDurationInBars()
		{
			return default(float);
		}

		[Token(Token = "0x6000527")]
		[Address(RVA = "0xED3F1C", Offset = "0xED3F1C", VA = "0xED3F1C", Slot = "39")]
		public virtual uint getEventCount()
		{
			return default(uint);
		}

		[Token(Token = "0x6000528")]
		[Address(RVA = "0xED3F8C", Offset = "0xED3F8C", VA = "0xED3F8C", Slot = "40")]
		public virtual float getTempo()
		{
			return default(float);
		}

		[Token(Token = "0x6000529")]
		[Address(RVA = "0xED3FFC", Offset = "0xED3FFC", VA = "0xED3FFC", Slot = "41")]
		public virtual byte getTimeSignatureNumerator()
		{
			return default(byte);
		}

		[Token(Token = "0x600052A")]
		[Address(RVA = "0xED406C", Offset = "0xED406C", VA = "0xED406C", Slot = "42")]
		public virtual byte getTimeSignatureDenominator()
		{
			return default(byte);
		}
	}
	[Token(Token = "0x2000071")]
	public enum EventTransportMessageType
	{
		[Token(Token = "0x40001FA")]
		Note,
		[Token(Token = "0x40001FB")]
		Control,
		[Token(Token = "0x40001FC")]
		Tempo,
		[Token(Token = "0x40001FD")]
		TimeSignature,
		[Token(Token = "0x40001FE")]
		Custom
	}
	[Token(Token = "0x2000072")]
	public class Experimental : IDisposable
	{
		[Token(Token = "0x40001FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private HandleRef swigCPtr;

		[Token(Token = "0x4000200")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		protected bool swigCMemOwn;

		[Token(Token = "0x17000068")]
		public AmbisonicRenderer ambisonicRenderer
		{
			[Token(Token = "0x6000531")]
			[Address(RVA = "0xED4728", Offset = "0xED4728", VA = "0xED4728")]
			get
			{
				return default(AmbisonicRenderer);
			}
			[Token(Token = "0x6000530")]
			[Address(RVA = "0xED46A8", Offset = "0xED46A8", VA = "0xED46A8")]
			set
			{
			}
		}

		[Token(Token = "0x17000069")]
		public bool useFba
		{
			[Token(Token = "0x6000533")]
			[Address(RVA = "0xED4798", Offset = "0xED4798", VA = "0xED4798")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000532")]
			[Address(RVA = "0xECBB94", Offset = "0xECBB94", VA = "0xECBB94")]
			set
			{
			}
		}

		[Token(Token = "0x1700006A")]
		public byte fbaNumThreads
		{
			[Token(Token = "0x6000535")]
			[Address(RVA = "0xED4888", Offset = "0xED4888", VA = "0xED4888")]
			get
			{
				return default(byte);
			}
			[Token(Token = "0x6000534")]
			[Address(RVA = "0xED4808", Offset = "0xED4808", VA = "0xED4808")]
			set
			{
			}
		}

		[Token(Token = "0x600052B")]
		[Address(RVA = "0xED2548", Offset = "0xED2548", VA = "0xED2548")]
		internal Experimental(IntPtr cPtr, bool cMemoryOwn)
		{
		}

		[Token(Token = "0x600052C")]
		[Address(RVA = "0xED24D4", Offset = "0xED24D4", VA = "0xED24D4")]
		public static HandleRef getCPtr(Experimental obj)
		{
			return default(HandleRef);
		}

		[Token(Token = "0x600052D")]
		[Address(RVA = "0xED4488", Offset = "0xED4488", VA = "0xED4488", Slot = "1")]
		~Experimental()
		{
		}

		[Token(Token = "0x600052E")]
		[Address(RVA = "0xED44FC", Offset = "0xED44FC", VA = "0xED44FC", Slot = "4")]
		public void Dispose()
		{
		}

		[Token(Token = "0x600052F")]
		[Address(RVA = "0xED4578", Offset = "0xED4578", VA = "0xED4578", Slot = "5")]
		protected virtual void Dispose(bool disposing)
		{
		}

		[Token(Token = "0x6000536")]
		[Address(RVA = "0xED48F8", Offset = "0xED48F8", VA = "0xED48F8")]
		public Experimental()
		{
		}
	}
	[Token(Token = "0x2000073")]
	public class IOStream : IDisposable
	{
		[Token(Token = "0x20000A4")]
		public enum StreamOptions
		{
			[Token(Token = "0x40002AF")]
			READ_BINARY,
			[Token(Token = "0x40002B0")]
			WRITE_BINARY,
			[Token(Token = "0x40002B1")]
			READ_WRITE_BINARY
		}

		[Token(Token = "0x4000201")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private HandleRef swigCPtr;

		[Token(Token = "0x4000202")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		protected bool swigCMemOwn;

		[Token(Token = "0x6000537")]
		[Address(RVA = "0xEC6810", Offset = "0xEC6810", VA = "0xEC6810")]
		internal IOStream(IntPtr cPtr, bool cMemoryOwn)
		{
		}

		[Token(Token = "0x6000538")]
		[Address(RVA = "0xECD558", Offset = "0xECD558", VA = "0xECD558")]
		public static HandleRef getCPtr(IOStream obj)
		{
			return default(HandleRef);
		}

		[Token(Token = "0x6000539")]
		[Address(RVA = "0xED496C", Offset = "0xED496C", VA = "0xED496C", Slot = "1")]
		~IOStream()
		{
		}

		[Token(Token = "0x600053A")]
		[Address(RVA = "0xED49E0", Offset = "0xED49E0", VA = "0xED49E0", Slot = "4")]
		public void Dispose()
		{
		}

		[Token(Token = "0x600053B")]
		[Address(RVA = "0xED4A5C", Offset = "0xED4A5C", VA = "0xED4A5C", Slot = "5")]
		protected virtual void Dispose(bool disposing)
		{
		}

		[Token(Token = "0x600053C")]
		[Address(RVA = "0xED4B8C", Offset = "0xED4B8C", VA = "0xED4B8C", Slot = "6")]
		public virtual uint getPosition()
		{
			return default(uint);
		}

		[Token(Token = "0x600053D")]
		[Address(RVA = "0xED4BFC", Offset = "0xED4BFC", VA = "0xED4BFC", Slot = "7")]
		public virtual bool setPosition(long pos)
		{
			return default(bool);
		}

		[Token(Token = "0x600053E")]
		[Address(RVA = "0xED4C7C", Offset = "0xED4C7C", VA = "0xED4C7C", Slot = "8")]
		public virtual bool setPosition(long pos, int mode)
		{
			return default(bool);
		}

		[Token(Token = "0x600053F")]
		[Address(RVA = "0xED4D04", Offset = "0xED4D04", VA = "0xED4D04", Slot = "9")]
		public virtual int pushBackByte(int c)
		{
			return default(int);
		}

		[Token(Token = "0x6000540")]
		[Address(RVA = "0xED4D84", Offset = "0xED4D84", VA = "0xED4D84", Slot = "10")]
		public virtual uint getSize()
		{
			return default(uint);
		}

		[Token(Token = "0x6000541")]
		[Address(RVA = "0xED4DF4", Offset = "0xED4DF4", VA = "0xED4DF4", Slot = "11")]
		public virtual bool canSeek()
		{
			return default(bool);
		}

		[Token(Token = "0x6000542")]
		[Address(RVA = "0xED4E64", Offset = "0xED4E64", VA = "0xED4E64", Slot = "12")]
		public virtual bool ready()
		{
			return default(bool);
		}

		[Token(Token = "0x6000543")]
		[Address(RVA = "0xED4ED4", Offset = "0xED4ED4", VA = "0xED4ED4", Slot = "13")]
		public virtual bool endOfStream()
		{
			return default(bool);
		}

		[Token(Token = "0x6000544")]
		[Address(RVA = "0xED4F44", Offset = "0xED4F44", VA = "0xED4F44", Slot = "14")]
		public virtual int getFD()
		{
			return default(int);
		}

		[Token(Token = "0x6000545")]
		[Address(RVA = "0xED4FB4", Offset = "0xED4FB4", VA = "0xED4FB4")]
		public static IOStream createFileStream(string file, StreamOptions options, AssetDescriptor ad)
		{
			return null;
		}

		[Token(Token = "0x6000546")]
		[Address(RVA = "0xED50E0", Offset = "0xED50E0", VA = "0xED50E0")]
		public static IOStream createFileStream(string file, StreamOptions options)
		{
			return null;
		}

		[Token(Token = "0x6000547")]
		[Address(RVA = "0xED5198", Offset = "0xED5198", VA = "0xED5198")]
		public static IOStream createMemoryStream(IntPtr buffer, uint sizeInBytes, uint offsetInBytes)
		{
			return null;
		}

		[Token(Token = "0x6000548")]
		[Address(RVA = "0xED5258", Offset = "0xED5258", VA = "0xED5258")]
		public static IOStream createMemoryStream(IntPtr buffer, uint sizeInBytes)
		{
			return null;
		}

		[Token(Token = "0x6000549")]
		[Address(RVA = "0xED5310", Offset = "0xED5310", VA = "0xED5310", Slot = "15")]
		public virtual uint read(byte[] data, uint numBytes)
		{
			return default(uint);
		}

		[Token(Token = "0x600054A")]
		[Address(RVA = "0xED5398", Offset = "0xED5398", VA = "0xED5398", Slot = "16")]
		public virtual uint write(byte[] data, uint numBytes)
		{
			return default(uint);
		}
	}
	[Token(Token = "0x2000074")]
	public class LoudnessStatistics : IDisposable
	{
		[Token(Token = "0x4000203")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private HandleRef swigCPtr;

		[Token(Token = "0x4000204")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		protected bool swigCMemOwn;

		[Token(Token = "0x1700006B")]
		public float integrated
		{
			[Token(Token = "0x6000551")]
			[Address(RVA = "0xED5734", Offset = "0xED5734", VA = "0xED5734")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000550")]
			[Address(RVA = "0xED56B4", Offset = "0xED56B4", VA = "0xED56B4")]
			set
			{
			}
		}

		[Token(Token = "0x1700006C")]
		public float shortTerm
		{
			[Token(Token = "0x6000553")]
			[Address(RVA = "0xED5824", Offset = "0xED5824", VA = "0xED5824")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000552")]
			[Address(RVA = "0xED57A4", Offset = "0xED57A4", VA = "0xED57A4")]
			set
			{
			}
		}

		[Token(Token = "0x1700006D")]
		public float momentary
		{
			[Token(Token = "0x6000555")]
			[Address(RVA = "0xED5914", Offset = "0xED5914", VA = "0xED5914")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000554")]
			[Address(RVA = "0xED5894", Offset = "0xED5894", VA = "0xED5894")]
			set
			{
			}
		}

		[Token(Token = "0x1700006E")]
		public float truePeak
		{
			[Token(Token = "0x6000557")]
			[Address(RVA = "0xED5A04", Offset = "0xED5A04", VA = "0xED5A04")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000556")]
			[Address(RVA = "0xED5984", Offset = "0xED5984", VA = "0xED5984")]
			set
			{
			}
		}

		[Token(Token = "0x600054B")]
		[Address(RVA = "0xEC8E40", Offset = "0xEC8E40", VA = "0xEC8E40")]
		internal LoudnessStatistics(IntPtr cPtr, bool cMemoryOwn)
		{
		}

		[Token(Token = "0x600054C")]
		[Address(RVA = "0xED5420", Offset = "0xED5420", VA = "0xED5420")]
		public static HandleRef getCPtr(LoudnessStatistics obj)
		{
			return default(HandleRef);
		}

		[Token(Token = "0x600054D")]
		[Address(RVA = "0xED5494", Offset = "0xED5494", VA = "0xED5494", Slot = "1")]
		~LoudnessStatistics()
		{
		}

		[Token(Token = "0x600054E")]
		[Address(RVA = "0xED5508", Offset = "0xED5508", VA = "0xED5508", Slot = "4")]
		public void Dispose()
		{
		}

		[Token(Token = "0x600054F")]
		[Address(RVA = "0xED5584", Offset = "0xED5584", VA = "0xED5584", Slot = "5")]
		protected virtual void Dispose(bool disposing)
		{
		}

		[Token(Token = "0x6000558")]
		[Address(RVA = "0xED5A74", Offset = "0xED5A74", VA = "0xED5A74")]
		public LoudnessStatistics()
		{
		}
	}
	[Token(Token = "0x2000075")]
	public class MemorySettings : IDisposable
	{
		[Token(Token = "0x4000205")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private HandleRef swigCPtr;

		[Token(Token = "0x4000206")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		protected bool swigCMemOwn;

		[Token(Token = "0x1700006F")]
		public int spatDecoderQueuePoolSize
		{
			[Token(Token = "0x600055F")]
			[Address(RVA = "0xED5D08", Offset = "0xED5D08", VA = "0xED5D08")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600055E")]
			[Address(RVA = "0xECBA64", Offset = "0xECBA64", VA = "0xECBA64")]
			set
			{
			}
		}

		[Token(Token = "0x17000070")]
		public int spatDecoderFilePoolSize
		{
			[Token(Token = "0x6000561")]
			[Address(RVA = "0xED5D78", Offset = "0xED5D78", VA = "0xED5D78")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000560")]
			[Address(RVA = "0xECB9E4", Offset = "0xECB9E4", VA = "0xECB9E4")]
			set
			{
			}
		}

		[Token(Token = "0x17000071")]
		public int spatQueueSizePerChannel
		{
			[Token(Token = "0x6000563")]
			[Address(RVA = "0xED5DE8", Offset = "0xED5DE8", VA = "0xED5DE8")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000562")]
			[Address(RVA = "0xECB644", Offset = "0xECB644", VA = "0xECB644")]
			set
			{
			}
		}

		[Token(Token = "0x17000072")]
		public int audioObjectPoolSize
		{
			[Token(Token = "0x6000565")]
			[Address(RVA = "0xED5E58", Offset = "0xED5E58", VA = "0xED5E58")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000564")]
			[Address(RVA = "0xECB964", Offset = "0xECB964", VA = "0xECB964")]
			set
			{
			}
		}

		[Token(Token = "0x17000073")]
		public uint speakersVirtualizersPoolSize
		{
			[Token(Token = "0x6000567")]
			[Address(RVA = "0xED5F48", Offset = "0xED5F48", VA = "0xED5F48")]
			get
			{
				return default(uint);
			}
			[Token(Token = "0x6000566")]
			[Address(RVA = "0xED5EC8", Offset = "0xED5EC8", VA = "0xED5EC8")]
			set
			{
			}
		}

		[Token(Token = "0x17000074")]
		public AudioAssetManager audioAssetManager
		{
			[Token(Token = "0x6000569")]
			[Address(RVA = "0xED604C", Offset = "0xED604C", VA = "0xED604C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000568")]
			[Address(RVA = "0xED5FB8", Offset = "0xED5FB8", VA = "0xED5FB8")]
			set
			{
			}
		}

		[Token(Token = "0x6000559")]
		[Address(RVA = "0xED2074", Offset = "0xED2074", VA = "0xED2074")]
		internal MemorySettings(IntPtr cPtr, bool cMemoryOwn)
		{
		}

		[Token(Token = "0x600055A")]
		[Address(RVA = "0xED2000", Offset = "0xED2000", VA = "0xED2000")]
		public static HandleRef getCPtr(MemorySettings obj)
		{
			return default(HandleRef);
		}

		[Token(Token = "0x600055B")]
		[Address(RVA = "0xED5AE8", Offset = "0xED5AE8", VA = "0xED5AE8", Slot = "1")]
		~MemorySettings()
		{
		}

		[Token(Token = "0x600055C")]
		[Address(RVA = "0xED5B5C", Offset = "0xED5B5C", VA = "0xED5B5C", Slot = "4")]
		public void Dispose()
		{
		}

		[Token(Token = "0x600055D")]
		[Address(RVA = "0xED5BD8", Offset = "0xED5BD8", VA = "0xED5BD8", Slot = "5")]
		protected virtual void Dispose(bool disposing)
		{
		}

		[Token(Token = "0x600056A")]
		[Address(RVA = "0xED60FC", Offset = "0xED60FC", VA = "0xED60FC")]
		public MemorySettings()
		{
		}
	}
	[Token(Token = "0x2000076")]
	public class NativeAudioObject : SpatDecoderInterface
	{
		[Token(Token = "0x4000207")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private HandleRef swigCPtr;

		[Token(Token = "0x600056B")]
		[Address(RVA = "0xECA748", Offset = "0xECA748", VA = "0xECA748")]
		internal NativeAudioObject(IntPtr cPtr, bool cMemoryOwn)
		{
		}

		[Token(Token = "0x600056C")]
		[Address(RVA = "0xEC81A4", Offset = "0xEC81A4", VA = "0xEC81A4")]
		public static HandleRef getCPtr(NativeAudioObject obj)
		{
			return default(HandleRef);
		}

		[Token(Token = "0x600056D")]
		[Address(RVA = "0xED6224", Offset = "0xED6224", VA = "0xED6224", Slot = "5")]
		protected override void Dispose(bool disposing)
		{
		}

		[Token(Token = "0x600056E")]
		[Address(RVA = "0xED64AC", Offset = "0xED64AC", VA = "0xED64AC", Slot = "49")]
		public virtual EngineError setAudioBufferCallback(AudioObjectBufferCallback callback, uint numChannels, ChannelMap map, IntPtr userData)
		{
			return default(EngineError);
		}

		[Token(Token = "0x600056F")]
		[Address(RVA = "0xED654C", Offset = "0xED654C", VA = "0xED654C", Slot = "50")]
		public virtual EngineError open(string nameAndPath)
		{
			return default(EngineError);
		}

		[Token(Token = "0x6000570")]
		[Address(RVA = "0xED65CC", Offset = "0xED65CC", VA = "0xED65CC", Slot = "51")]
		public virtual EngineError open(string nameAndPath, AssetDescriptor ad)
		{
			return default(EngineError);
		}

		[Token(Token = "0x6000571")]
		[Address(RVA = "0xED66D8", Offset = "0xED66D8", VA = "0xED66D8", Slot = "52")]
		public virtual EngineError open(IOStream stream, bool shouldOwnStream)
		{
			return default(EngineError);
		}

		[Token(Token = "0x6000572")]
		[Address(RVA = "0xED677C", Offset = "0xED677C", VA = "0xED677C", Slot = "53")]
		public virtual EngineError open(AudioFormatDecoder decoder)
		{
			return default(EngineError);
		}

		[Token(Token = "0x6000573")]
		[Address(RVA = "0xED6810", Offset = "0xED6810", VA = "0xED6810", Slot = "54")]
		public virtual void close()
		{
		}

		[Token(Token = "0x6000574")]
		[Address(RVA = "0xED6880", Offset = "0xED6880", VA = "0xED6880", Slot = "55")]
		public virtual bool isOpen()
		{
			return default(bool);
		}

		[Token(Token = "0x6000575")]
		[Address(RVA = "0xED68F0", Offset = "0xED68F0", VA = "0xED68F0", Slot = "56")]
		public virtual EngineError seekToSample(uint timeInSamples)
		{
			return default(EngineError);
		}

		[Token(Token = "0x6000576")]
		[Address(RVA = "0xED6970", Offset = "0xED6970", VA = "0xED6970", Slot = "57")]
		public virtual EngineError seekToMs(float timeInMs)
		{
			return default(EngineError);
		}

		[Token(Token = "0x6000577")]
		[Address(RVA = "0xED69F0", Offset = "0xED69F0", VA = "0xED69F0", Slot = "58")]
		public virtual uint getElapsedTimeInSamples()
		{
			return default(uint);
		}

		[Token(Token = "0x6000578")]
		[Address(RVA = "0xED6A60", Offset = "0xED6A60", VA = "0xED6A60", Slot = "59")]
		public virtual double getElapsedTimeInMs()
		{
			return default(double);
		}

		[Token(Token = "0x6000579")]
		[Address(RVA = "0xED6AD0", Offset = "0xED6AD0", VA = "0xED6AD0", Slot = "60")]
		public virtual uint getAssetDurationInSamples()
		{
			return default(uint);
		}

		[Token(Token = "0x600057A")]
		[Address(RVA = "0xED6B40", Offset = "0xED6B40", VA = "0xED6B40", Slot = "61")]
		public virtual float getAssetDurationInMs()
		{
			return default(float);
		}

		[Token(Token = "0x600057B")]
		[Address(RVA = "0xED6BB0", Offset = "0xED6BB0", VA = "0xED6BB0", Slot = "36")]
		public override EngineError setEventCallback(EventCallback callback, IntPtr userData)
		{
			return default(EngineError);
		}

		[Token(Token = "0x600057C")]
		[Address(RVA = "0xED6C38", Offset = "0xED6C38", VA = "0xED6C38", Slot = "62")]
		public virtual void shouldSpatialise(bool spatialise)
		{
		}

		[Token(Token = "0x600057D")]
		[Address(RVA = "0xED6CB8", Offset = "0xED6CB8", VA = "0xED6CB8", Slot = "63")]
		public virtual bool isSpatialised()
		{
			return default(bool);
		}

		[Token(Token = "0x600057E")]
		[Address(RVA = "0xED6D28", Offset = "0xED6D28", VA = "0xED6D28", Slot = "64")]
		public virtual void overrideRanking(bool override_)
		{
		}

		[Token(Token = "0x600057F")]
		[Address(RVA = "0xED6DA8", Offset = "0xED6DA8", VA = "0xED6DA8", Slot = "65")]
		public virtual EngineError setSpatialisationType(SpatialisationType spatType)
		{
			return default(EngineError);
		}

		[Token(Token = "0x6000580")]
		[Address(RVA = "0xED6E28", Offset = "0xED6E28", VA = "0xED6E28", Slot = "66")]
		public virtual SpatialisationType getSpatialisationType()
		{
			return default(SpatialisationType);
		}

		[Token(Token = "0x6000581")]
		[Address(RVA = "0xED6E98", Offset = "0xED6E98", VA = "0xED6E98", Slot = "67")]
		public virtual bool enableLooping(bool loop)
		{
			return default(bool);
		}

		[Token(Token = "0x6000582")]
		[Address(RVA = "0xED6F18", Offset = "0xED6F18", VA = "0xED6F18", Slot = "68")]
		public virtual bool loopingEnabled()
		{
			return default(bool);
		}

		[Token(Token = "0x6000583")]
		[Address(RVA = "0xED6F88", Offset = "0xED6F88", VA = "0xED6F88", Slot = "69")]
		public virtual void setAttenuationMode(AttenuationMode mode)
		{
		}

		[Token(Token = "0x6000584")]
		[Address(RVA = "0xED7008", Offset = "0xED7008", VA = "0xED7008", Slot = "70")]
		public virtual AttenuationMode getAttenuationMode()
		{
			return default(AttenuationMode);
		}

		[Token(Token = "0x6000585")]
		[Address(RVA = "0xED7078", Offset = "0xED7078", VA = "0xED7078", Slot = "71")]
		public virtual void setAttenuationProperties(AttenuationProps props)
		{
		}

		[Token(Token = "0x6000586")]
		[Address(RVA = "0xED7168", Offset = "0xED7168", VA = "0xED7168", Slot = "72")]
		public virtual AttenuationProps getAttenuationProperties()
		{
			return null;
		}

		[Token(Token = "0x6000587")]
		[Address(RVA = "0xED720C", Offset = "0xED720C", VA = "0xED720C", Slot = "73")]
		public virtual void setDirectionalityEnabled(bool enable)
		{
		}

		[Token(Token = "0x6000588")]
		[Address(RVA = "0xED728C", Offset = "0xED728C", VA = "0xED728C", Slot = "74")]
		public virtual bool isDirectionalityEnabled()
		{
			return default(bool);
		}

		[Token(Token = "0x6000589")]
		[Address(RVA = "0xED72FC", Offset = "0xED72FC", VA = "0xED72FC", Slot = "75")]
		public virtual void setDirectionalProperties(DirectionalProps props)
		{
		}

		[Token(Token = "0x600058A")]
		[Address(RVA = "0xED73E8", Offset = "0xED73E8", VA = "0xED73E8", Slot = "76")]
		public virtual DirectionalProps getDirectionalProperties()
		{
			return null;
		}

		[Token(Token = "0x600058B")]
		[Address(RVA = "0xED7488", Offset = "0xED7488", VA = "0xED7488", Slot = "77")]
		public virtual void setPitch(float pitch)
		{
		}

		[Token(Token = "0x600058C")]
		[Address(RVA = "0xED7508", Offset = "0xED7508", VA = "0xED7508", Slot = "78")]
		public virtual float getPitch()
		{
			return default(float);
		}

		[Token(Token = "0x600058D")]
		[Address(RVA = "0xED7578", Offset = "0xED7578", VA = "0xED7578", Slot = "79")]
		public virtual IntPtr createEffect(EffectType type)
		{
			return default(IntPtr);
		}

		[Token(Token = "0x600058E")]
		[Address(RVA = "0xED75F8", Offset = "0xED75F8", VA = "0xED75F8", Slot = "80")]
		public virtual void destroyEffect(IntPtr handle)
		{
		}

		[Token(Token = "0x600058F")]
		[Address(RVA = "0xED7678", Offset = "0xED7678", VA = "0xED7678", Slot = "81")]
		public virtual EffectType getEffectTypeForHandle(IntPtr handle)
		{
			return default(EffectType);
		}

		[Token(Token = "0x6000590")]
		[Address(RVA = "0xED76F8", Offset = "0xED76F8", VA = "0xED76F8", Slot = "82")]
		public virtual EngineError setEffectType(IntPtr handle, EffectType type)
		{
			return default(EngineError);
		}

		[Token(Token = "0x6000591")]
		[Address(RVA = "0xED7780", Offset = "0xED7780", VA = "0xED7780", Slot = "83")]
		public virtual EngineError bypassEffect(IntPtr handle, bool bypass)
		{
			return default(EngineError);
		}

		[Token(Token = "0x6000592")]
		[Address(RVA = "0xED7808", Offset = "0xED7808", VA = "0xED7808", Slot = "84")]
		public virtual bool isEffectBypassed(IntPtr handle)
		{
			return default(bool);
		}

		[Token(Token = "0x6000593")]
		[Address(RVA = "0xED7888", Offset = "0xED7888", VA = "0xED7888", Slot = "85")]
		public virtual EngineError setEffectParam(IntPtr handle, EffectParam param, float value)
		{
			return default(EngineError);
		}

		[Token(Token = "0x6000594")]
		[Address(RVA = "0xED7920", Offset = "0xED7920", VA = "0xED7920", Slot = "86")]
		public virtual float getEffectParam(IntPtr handle, EffectParam param)
		{
			return default(float);
		}

		[Token(Token = "0x6000595")]
		[Address(RVA = "0xED79A8", Offset = "0xED79A8", VA = "0xED79A8", Slot = "87")]
		public virtual uint getNumberOfEffects()
		{
			return default(uint);
		}

		[Token(Token = "0x6000596")]
		[Address(RVA = "0xED7A18", Offset = "0xED7A18", VA = "0xED7A18", Slot = "88")]
		public virtual IntPtr getEffect(uint effectIndex)
		{
			return default(IntPtr);
		}

		[Token(Token = "0x6000597")]
		[Address(RVA = "0xED7A98", Offset = "0xED7A98", VA = "0xED7A98", Slot = "89")]
		public virtual IntPtr getOutputBus()
		{
			return default(IntPtr);
		}
	}
	[Token(Token = "0x2000077")]
	public class NativeSpatDecoderFile : SpatDecoderInterface
	{
		[Token(Token = "0x4000208")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private HandleRef swigCPtr;

		[Token(Token = "0x6000598")]
		[Address(RVA = "0xECA5E4", Offset = "0xECA5E4", VA = "0xECA5E4")]
		internal NativeSpatDecoderFile(IntPtr cPtr, bool cMemoryOwn)
		{
		}

		[Token(Token = "0x6000599")]
		[Address(RVA = "0xEC7FF8", Offset = "0xEC7FF8", VA = "0xEC7FF8")]
		public static HandleRef getCPtr(NativeSpatDecoderFile obj)
		{
			return default(HandleRef);
		}

		[Token(Token = "0x600059A")]
		[Address(RVA = "0xED7B08", Offset = "0xED7B08", VA = "0xED7B08", Slot = "5")]
		protected override void Dispose(bool disposing)
		{
		}

		[Token(Token = "0x600059B")]
		[Address(RVA = "0xED7C4C", Offset = "0xED7C4C", VA = "0xED7C4C", Slot = "49")]
		public virtual EngineError open(string nameAndPath, ChannelMap map)
		{
			return default(EngineError);
		}

		[Token(Token = "0x600059C")]
		[Address(RVA = "0xED7CD4", Offset = "0xED7CD4", VA = "0xED7CD4", Slot = "50")]
		public virtual EngineError open(string nameAndPath)
		{
			return default(EngineError);
		}

		[Token(Token = "0x600059D")]
		[Address(RVA = "0xED7D54", Offset = "0xED7D54", VA = "0xED7D54", Slot = "51")]
		public virtual EngineError open(string nameAndPath, AssetDescriptor ad, ChannelMap map)
		{
			return default(EngineError);
		}

		[Token(Token = "0x600059E")]
		[Address(RVA = "0xED7E68", Offset = "0xED7E68", VA = "0xED7E68", Slot = "52")]
		public virtual EngineError open(string nameAndPath, AssetDescriptor ad)
		{
			return default(EngineError);
		}

		[Token(Token = "0x600059F")]
		[Address(RVA = "0xED7F74", Offset = "0xED7F74", VA = "0xED7F74", Slot = "53")]
		public virtual void close()
		{
		}

		[Token(Token = "0x60005A0")]
		[Address(RVA = "0xED7FE4", Offset = "0xED7FE4", VA = "0xED7FE4", Slot = "54")]
		public virtual bool isOpen()
		{
			return default(bool);
		}

		[Token(Token = "0x60005A1")]
		[Address(RVA = "0xED8054", Offset = "0xED8054", VA = "0xED8054", Slot = "55")]
		public virtual EngineError seekToSample(uint timeInSamples)
		{
			return default(EngineError);
		}

		[Token(Token = "0x60005A2")]
		[Address(RVA = "0xED80D4", Offset = "0xED80D4", VA = "0xED80D4", Slot = "56")]
		public virtual EngineError seekToMs(float timeInMs)
		{
			return default(EngineError);
		}

		[Token(Token = "0x60005A3")]
		[Address(RVA = "0xED8154", Offset = "0xED8154", VA = "0xED8154", Slot = "57")]
		public virtual uint getElapsedTimeInSamples()
		{
			return default(uint);
		}

		[Token(Token = "0x60005A4")]
		[Address(RVA = "0xED81C4", Offset = "0xED81C4", VA = "0xED81C4", Slot = "58")]
		public virtual double getElapsedTimeInMs()
		{
			return default(double);
		}

		[Token(Token = "0x60005A5")]
		[Address(RVA = "0xED8234", Offset = "0xED8234", VA = "0xED8234", Slot = "59")]
		public virtual uint getAssetDurationInSamples()
		{
			return default(uint);
		}

		[Token(Token = "0x60005A6")]
		[Address(RVA = "0xED82A4", Offset = "0xED82A4", VA = "0xED82A4", Slot = "60")]
		public virtual float getAssetDurationInMs()
		{
			return default(float);
		}

		[Token(Token = "0x60005A7")]
		[Address(RVA = "0xED8314", Offset = "0xED8314", VA = "0xED8314", Slot = "61")]
		public virtual void setSyncMode(SyncMode syncMode)
		{
		}

		[Token(Token = "0x60005A8")]
		[Address(RVA = "0xED8394", Offset = "0xED8394", VA = "0xED8394", Slot = "62")]
		public virtual SyncMode getSyncMode()
		{
			return default(SyncMode);
		}

		[Token(Token = "0x60005A9")]
		[Address(RVA = "0xED8404", Offset = "0xED8404", VA = "0xED8404", Slot = "63")]
		public virtual void setExternalClockInMs(double externalClockInMs)
		{
		}

		[Token(Token = "0x60005AA")]
		[Address(RVA = "0xED8484", Offset = "0xED8484", VA = "0xED8484", Slot = "64")]
		public virtual void setFreewheelTimeInMs(double freewheelInMs)
		{
		}

		[Token(Token = "0x60005AB")]
		[Address(RVA = "0xED8504", Offset = "0xED8504", VA = "0xED8504", Slot = "65")]
		public virtual double getFreewheelTimeInMs()
		{
			return default(double);
		}

		[Token(Token = "0x60005AC")]
		[Address(RVA = "0xED8574", Offset = "0xED8574", VA = "0xED8574", Slot = "66")]
		public virtual void setResyncThresholdMs(double resyncThresholdMs)
		{
		}

		[Token(Token = "0x60005AD")]
		[Address(RVA = "0xED85F4", Offset = "0xED85F4", VA = "0xED85F4", Slot = "67")]
		public virtual double getResyncThresholdMs()
		{
			return default(double);
		}

		[Token(Token = "0x60005AE")]
		[Address(RVA = "0xED8664", Offset = "0xED8664", VA = "0xED8664", Slot = "68")]
		public virtual void applyVolumeFade(float startLinearGain, float endLinearGain, float fadeDurationMs)
		{
		}

		[Token(Token = "0x60005AF")]
		[Address(RVA = "0xED86FC", Offset = "0xED86FC", VA = "0xED86FC", Slot = "69")]
		public virtual void enableLooping(bool shouldLoop)
		{
		}

		[Token(Token = "0x60005B0")]
		[Address(RVA = "0xED877C", Offset = "0xED877C", VA = "0xED877C", Slot = "70")]
		public virtual bool loopingEnabled()
		{
			return default(bool);
		}

		[Token(Token = "0x60005B1")]
		[Address(RVA = "0xED87EC", Offset = "0xED87EC", VA = "0xED87EC")]
		public EngineError open(IOStream streamA, IOStream streamB, bool ownStreams, ChannelMap map)
		{
			return default(EngineError);
		}
	}
	[Token(Token = "0x2000078")]
	public class NativeSpatDecoderQueue : SpatDecoderInterface
	{
		[Token(Token = "0x4000209")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private HandleRef swigCPtr;

		[Token(Token = "0x60005B2")]
		[Address(RVA = "0xECA3B8", Offset = "0xECA3B8", VA = "0xECA3B8")]
		internal NativeSpatDecoderQueue(IntPtr cPtr, bool cMemoryOwn)
		{
		}

		[Token(Token = "0x60005B3")]
		[Address(RVA = "0xEC7EE0", Offset = "0xEC7EE0", VA = "0xEC7EE0")]
		public static HandleRef getCPtr(NativeSpatDecoderQueue obj)
		{
			return default(HandleRef);
		}

		[Token(Token = "0x60005B4")]
		[Address(RVA = "0xED88C8", Offset = "0xED88C8", VA = "0xED88C8", Slot = "5")]
		protected override void Dispose(bool disposing)
		{
		}

		[Token(Token = "0x60005B5")]
		[Address(RVA = "0xED8A0C", Offset = "0xED8A0C", VA = "0xED8A0C", Slot = "49")]
		public virtual int getFreeSpaceInQueue(ChannelMap channelMap)
		{
			return default(int);
		}

		[Token(Token = "0x60005B6")]
		[Address(RVA = "0xED8A8C", Offset = "0xED8A8C", VA = "0xED8A8C", Slot = "50")]
		public virtual int getQueueSize(ChannelMap channelMap)
		{
			return default(int);
		}

		[Token(Token = "0x60005B7")]
		[Address(RVA = "0xED8B0C", Offset = "0xED8B0C", VA = "0xED8B0C", Slot = "51")]
		public virtual int enqueueData(float[] interleavedBuffer, int numTotalSamples, ChannelMap channelMap)
		{
			return default(int);
		}

		[Token(Token = "0x60005B8")]
		[Address(RVA = "0xED8BA4", Offset = "0xED8BA4", VA = "0xED8BA4", Slot = "52")]
		public virtual int enqueueData(short[] interleavedBuffer, int numTotalSamples, ChannelMap channelMap)
		{
			return default(int);
		}

		[Token(Token = "0x60005B9")]
		[Address(RVA = "0xED8C3C", Offset = "0xED8C3C", VA = "0xED8C3C", Slot = "53")]
		public virtual int enqueueSilence(int numTotalSamples, ChannelMap channelMap)
		{
			return default(int);
		}

		[Token(Token = "0x60005BA")]
		[Address(RVA = "0xED8CC4", Offset = "0xED8CC4", VA = "0xED8CC4", Slot = "54")]
		public virtual void flushQueue()
		{
		}

		[Token(Token = "0x60005BB")]
		[Address(RVA = "0xED8D34", Offset = "0xED8D34", VA = "0xED8D34", Slot = "55")]
		public virtual ulong getNumSamplesDequeuedPerChannel()
		{
			return default(ulong);
		}

		[Token(Token = "0x60005BC")]
		[Address(RVA = "0xED8DA4", Offset = "0xED8DA4", VA = "0xED8DA4", Slot = "56")]
		public virtual void setEndOfStream(bool endOfStream)
		{
		}

		[Token(Token = "0x60005BD")]
		[Address(RVA = "0xED8E24", Offset = "0xED8E24", VA = "0xED8E24", Slot = "57")]
		public virtual bool getEndOfStreamStatus()
		{
			return default(bool);
		}
	}
	[Token(Token = "0x2000079")]
	public class NetworkSettings : IDisposable
	{
		[Token(Token = "0x400020A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private HandleRef swigCPtr;

		[Token(Token = "0x400020B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		protected bool swigCMemOwn;

		[Token(Token = "0x17000075")]
		public uint streamingBufferSizeBytes
		{
			[Token(Token = "0x60005C4")]
			[Address(RVA = "0xED920C", Offset = "0xED920C", VA = "0xED920C")]
			get
			{
				return default(uint);
			}
			[Token(Token = "0x60005C3")]
			[Address(RVA = "0xED918C", Offset = "0xED918C", VA = "0xED918C")]
			set
			{
			}
		}

		[Token(Token = "0x17000076")]
		public long maxDownloadSpeedBytes
		{
			[Token(Token = "0x60005C6")]
			[Address(RVA = "0xED92FC", Offset = "0xED92FC", VA = "0xED92FC")]
			get
			{
				return default(long);
			}
			[Token(Token = "0x60005C5")]
			[Address(RVA = "0xED927C", Offset = "0xED927C", VA = "0xED927C")]
			set
			{
			}
		}

		[Token(Token = "0x17000077")]
		public bool printDebugInfo
		{
			[Token(Token = "0x60005C8")]
			[Address(RVA = "0xED93EC", Offset = "0xED93EC", VA = "0xED93EC")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60005C7")]
			[Address(RVA = "0xED936C", Offset = "0xED936C", VA = "0xED936C")]
			set
			{
			}
		}

		[Token(Token = "0x60005BE")]
		[Address(RVA = "0xED8E94", Offset = "0xED8E94", VA = "0xED8E94")]
		internal NetworkSettings(IntPtr cPtr, bool cMemoryOwn)
		{
		}

		[Token(Token = "0x60005BF")]
		[Address(RVA = "0xED8EF8", Offset = "0xED8EF8", VA = "0xED8EF8")]
		public static HandleRef getCPtr(NetworkSettings obj)
		{
			return default(HandleRef);
		}

		[Token(Token = "0x60005C0")]
		[Address(RVA = "0xED8F6C", Offset = "0xED8F6C", VA = "0xED8F6C", Slot = "1")]
		~NetworkSettings()
		{
		}

		[Token(Token = "0x60005C1")]
		[Address(RVA = "0xED8FE0", Offset = "0xED8FE0", VA = "0xED8FE0", Slot = "4")]
		public void Dispose()
		{
		}

		[Token(Token = "0x60005C2")]
		[Address(RVA = "0xED905C", Offset = "0xED905C", VA = "0xED905C", Slot = "5")]
		protected virtual void Dispose(bool disposing)
		{
		}

		[Token(Token = "0x60005C9")]
		[Address(RVA = "0xED945C", Offset = "0xED945C", VA = "0xED945C")]
		public NetworkSettings()
		{
		}
	}
	[Token(Token = "0x200007A")]
	public class Object3D : TransportControl
	{
		[Token(Token = "0x400020C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private HandleRef swigCPtr;

		[Token(Token = "0x60005CA")]
		[Address(RVA = "0xED9E68", Offset = "0xED9E68", VA = "0xED9E68")]
		internal Object3D(IntPtr cPtr, bool cMemoryOwn)
		{
		}

		[Token(Token = "0x60005CB")]
		[Address(RVA = "0xED9F20", Offset = "0xED9F20", VA = "0xED9F20")]
		public static HandleRef getCPtr(Object3D obj)
		{
			return default(HandleRef);
		}

		[Token(Token = "0x60005CC")]
		[Address(RVA = "0xED9F94", Offset = "0xED9F94", VA = "0xED9F94", Slot = "5")]
		protected override void Dispose(bool disposing)
		{
		}

		[Token(Token = "0x60005CD")]
		[Address(RVA = "0xEDA0DC", Offset = "0xEDA0DC", VA = "0xEDA0DC", Slot = "20")]
		public virtual EngineError setPosition(TBVector position)
		{
			return default(EngineError);
		}

		[Token(Token = "0x60005CE")]
		[Address(RVA = "0xEDA1D8", Offset = "0xEDA1D8", VA = "0xEDA1D8", Slot = "21")]
		public virtual TBVector getPosition()
		{
			return null;
		}

		[Token(Token = "0x60005CF")]
		[Address(RVA = "0xEDA27C", Offset = "0xEDA27C", VA = "0xEDA27C", Slot = "22")]
		public virtual EngineError setRotation(TBQuat rotation)
		{
			return default(EngineError);
		}

		[Token(Token = "0x60005D0")]
		[Address(RVA = "0xEDA378", Offset = "0xEDA378", VA = "0xEDA378", Slot = "23")]
		public virtual EngineError setRotation(TBVector forward, TBVector up)
		{
			return default(EngineError);
		}

		[Token(Token = "0x60005D1")]
		[Address(RVA = "0xEDA49C", Offset = "0xEDA49C", VA = "0xEDA49C", Slot = "24")]
		public virtual TBQuat getRotation()
		{
			return null;
		}
	}
	[Token(Token = "0x200007B")]
	public enum Options
	{
		[Token(Token = "0x400020E")]
		DEFAULT,
		[Token(Token = "0x400020F")]
		DECODE_IN_AUDIO_CALLBACK
	}
	[Token(Token = "0x200007C")]
	public enum PCMType
	{
		[Token(Token = "0x4000211")]
		FLOAT,
		[Token(Token = "0x4000212")]
		INT16,
		[Token(Token = "0x4000213")]
		INT32
	}
	[Token(Token = "0x200007D")]
	public class PlatformSettings : IDisposable
	{
		[Token(Token = "0x4000214")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private HandleRef swigCPtr;

		[Token(Token = "0x4000215")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		protected bool swigCMemOwn;

		[Token(Token = "0x17000078")]
		public bool useAndroidFastPath
		{
			[Token(Token = "0x60005D8")]
			[Address(RVA = "0xEDA7E0", Offset = "0xEDA7E0", VA = "0xEDA7E0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60005D7")]
			[Address(RVA = "0xEDA760", Offset = "0xEDA760", VA = "0xEDA760")]
			set
			{
			}
		}

		[Token(Token = "0x60005D2")]
		[Address(RVA = "0xED2290", Offset = "0xED2290", VA = "0xED2290")]
		internal PlatformSettings(IntPtr cPtr, bool cMemoryOwn)
		{
		}

		[Token(Token = "0x60005D3")]
		[Address(RVA = "0xED216C", Offset = "0xED216C", VA = "0xED216C")]
		public static HandleRef getCPtr(PlatformSettings obj)
		{
			return default(HandleRef);
		}

		[Token(Token = "0x60005D4")]
		[Address(RVA = "0xEDA540", Offset = "0xEDA540", VA = "0xEDA540", Slot = "1")]
		~PlatformSettings()
		{
		}

		[Token(Token = "0x60005D5")]
		[Address(RVA = "0xEDA5B4", Offset = "0xEDA5B4", VA = "0xEDA5B4", Slot = "4")]
		public void Dispose()
		{
		}

		[Token(Token = "0x60005D6")]
		[Address(RVA = "0xEDA630", Offset = "0xEDA630", VA = "0xEDA630", Slot = "5")]
		protected virtual void Dispose(bool disposing)
		{
		}

		[Token(Token = "0x60005D9")]
		[Address(RVA = "0xEDA850", Offset = "0xEDA850", VA = "0xEDA850")]
		public PlatformSettings()
		{
		}
	}
	[Token(Token = "0x200007E")]
	public enum PlayState
	{
		[Token(Token = "0x4000217")]
		PLAYING,
		[Token(Token = "0x4000218")]
		PAUSED,
		[Token(Token = "0x4000219")]
		STOPPED,
		[Token(Token = "0x400021A")]
		INVALID
	}
	[Token(Token = "0x200007F")]
	public class SpatDecoderInterface : Object3D
	{
		[Token(Token = "0x400021B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private HandleRef swigCPtr;

		[Token(Token = "0x60005DA")]
		[Address(RVA = "0xED6170", Offset = "0xED6170", VA = "0xED6170")]
		internal SpatDecoderInterface(IntPtr cPtr, bool cMemoryOwn)
		{
		}

		[Token(Token = "0x60005DB")]
		[Address(RVA = "0xEDC364", Offset = "0xEDC364", VA = "0xEDC364")]
		public static HandleRef getCPtr(SpatDecoderInterface obj)
		{
			return default(HandleRef);
		}

		[Token(Token = "0x60005DC")]
		[Address(RVA = "0xED6368", Offset = "0xED6368", VA = "0xED6368", Slot = "5")]
		protected override void Dispose(bool disposing)
		{
		}

		[Token(Token = "0x60005DD")]
		[Address(RVA = "0xEDC3D8", Offset = "0xEDC3D8", VA = "0xEDC3D8", Slot = "25")]
		public virtual void enableFocus(bool enableFocus, bool followListener)
		{
		}

		[Token(Token = "0x60005DE")]
		[Address(RVA = "0xEDC460", Offset = "0xEDC460", VA = "0xEDC460", Slot = "26")]
		public virtual void setFocusProperties(float offFocusLevel, float focusWidth)
		{
		}

		[Token(Token = "0x60005DF")]
		[Address(RVA = "0xEDC4E8", Offset = "0xEDC4E8", VA = "0xEDC4E8", Slot = "27")]
		public virtual void setOffFocusLeveldB(float offFocusLevelDB)
		{
		}

		[Token(Token = "0x60005E0")]
		[Address(RVA = "0xEDC568", Offset = "0xEDC568", VA = "0xEDC568", Slot = "28")]
		public virtual void setFocusWidthDegrees(float focusWidthDegrees)
		{
		}

		[Token(Token = "0x60005E1")]
		[Address(RVA = "0xEDC5E8", Offset = "0xEDC5E8", VA = "0xEDC5E8", Slot = "29")]
		public virtual void setFocusOrientationQuat(TBQuat focusQuat)
		{
		}

		[Token(Token = "0x60005E2")]
		[Address(RVA = "0xEDC6D8", Offset = "0xEDC6D8", VA = "0xEDC6D8", Slot = "30")]
		public virtual void setVolume(float linearGain, float rampTimeMs, bool forcePreviousRamp)
		{
		}

		[Token(Token = "0x60005E3")]
		[Address(RVA = "0xEDC770", Offset = "0xEDC770", VA = "0xEDC770", Slot = "31")]
		public virtual void setVolume(float linearGain, float rampTimeMs)
		{
		}

		[Token(Token = "0x60005E4")]
		[Address(RVA = "0xEDC7F8", Offset = "0xEDC7F8", VA = "0xEDC7F8", Slot = "32")]
		public virtual void setVolumeDecibels(float dB, float rampTimeMs, bool forcePreviousRamp)
		{
		}

		[Token(Token = "0x60005E5")]
		[Address(RVA = "0xEDC890", Offset = "0xEDC890", VA = "0xEDC890", Slot = "33")]
		public virtual void setVolumeDecibels(float dB, float rampTimeMs)
		{
		}

		[Token(Token = "0x60005E6")]
		[Address(RVA = "0xEDC918", Offset = "0xEDC918", VA = "0xEDC918", Slot = "34")]
		public virtual float getVolume()
		{
			return default(float);
		}

		[Token(Token = "0x60005E7")]
		[Address(RVA = "0xEDC988", Offset = "0xEDC988", VA = "0xEDC988", Slot = "35")]
		public virtual float getVolumeDecibels()
		{
			return default(float);
		}

		[Token(Token = "0x60005E8")]
		[Address(RVA = "0xEDC9F8", Offset = "0xEDC9F8", VA = "0xEDC9F8", Slot = "36")]
		public virtual EngineError setEventCallback(EventCallback callback, IntPtr userData)
		{
			return default(EngineError);
		}

		[Token(Token = "0x60005E9")]
		[Address(RVA = "0xEDCA80", Offset = "0xEDCA80", VA = "0xEDCA80", Slot = "37")]
		public virtual EngineError bypassReverbSend(bool bypass)
		{
			return default(EngineError);
		}

		[Token(Token = "0x60005EA")]
		[Address(RVA = "0xEDCB00", Offset = "0xEDCB00", VA = "0xEDCB00", Slot = "38")]
		public virtual bool isReverbSendBypassed()
		{
			return default(bool);
		}

		[Token(Token = "0x60005EB")]
		[Address(RVA = "0xEDCB70", Offset = "0xEDCB70", VA = "0xEDCB70", Slot = "39")]
		public virtual EngineError setReverbSendLevel(float level)
		{
			return default(EngineError);
		}

		[Token(Token = "0x60005EC")]
		[Address(RVA = "0xEDCBF0", Offset = "0xEDCBF0", VA = "0xEDCBF0", Slot = "40")]
		public virtual float getReverbSendLevel()
		{
			return default(float);
		}

		[Token(Token = "0x60005ED")]
		[Address(RVA = "0xEDCC60", Offset = "0xEDCC60", VA = "0xEDCC60", Slot = "41")]
		public virtual EngineError addEffectInsert(EffectIndex effectIndex, EffectType effectType)
		{
			return default(EngineError);
		}

		[Token(Token = "0x60005EE")]
		[Address(RVA = "0xEDCCE8", Offset = "0xEDCCE8", VA = "0xEDCCE8", Slot = "42")]
		public virtual EngineError removeEffectInsert(EffectIndex effectIndex)
		{
			return default(EngineError);
		}

		[Token(Token = "0x60005EF")]
		[Address(RVA = "0xEDCD68", Offset = "0xEDCD68", VA = "0xEDCD68", Slot = "43")]
		public virtual EngineError bypassEffectInsert(EffectIndex effectIndex, bool bypass)
		{
			return default(EngineError);
		}

		[Token(Token = "0x60005F0")]
		[Address(RVA = "0xEDCDF0", Offset = "0xEDCDF0", VA = "0xEDCDF0", Slot = "44")]
		public virtual EngineError setEffectInsertParam(EffectIndex effectIndex, EffectParam effectParam, float value)
		{
			return default(EngineError);
		}

		[Token(Token = "0x60005F1")]
		[Address(RVA = "0xEDCE88", Offset = "0xEDCE88", VA = "0xEDCE88", Slot = "45")]
		public virtual float getEffectInsertParam(EffectIndex effectIndex, EffectParam effectParam)
		{
			return default(float);
		}

		[Token(Token = "0x60005F2")]
		[Address(RVA = "0xEDCF10", Offset = "0xEDCF10", VA = "0xEDCF10", Slot = "46")]
		public virtual bool isEffectInsertActive(EffectIndex effectIndex)
		{
			return default(bool);
		}

		[Token(Token = "0x60005F3")]
		[Address(RVA = "0xEDCF90", Offset = "0xEDCF90", VA = "0xEDCF90", Slot = "47")]
		public virtual bool isEffectInsertBypassed(EffectIndex effectIndex)
		{
			return default(bool);
		}

		[Token(Token = "0x60005F4")]
		[Address(RVA = "0xEDD010", Offset = "0xEDD010", VA = "0xEDD010", Slot = "48")]
		public virtual EffectType getEffectType(EffectIndex effectIndex)
		{
			return default(EffectType);
		}
	}
	[Token(Token = "0x2000080")]
	public enum SpatialisationType
	{
		[Token(Token = "0x400021D")]
		AMBISONICS,
		[Token(Token = "0x400021E")]
		BINAURAL
	}
	[Token(Token = "0x2000081")]
	public enum SyncMode
	{
		[Token(Token = "0x4000220")]
		INTERNAL,
		[Token(Token = "0x4000221")]
		EXTERNAL
	}
	[Token(Token = "0x2000082")]
	public class TBQuat : IDisposable
	{
		[Token(Token = "0x4000222")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private HandleRef swigCPtr;

		[Token(Token = "0x4000223")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		protected bool swigCMemOwn;

		[Token(Token = "0x17000079")]
		public float x
		{
			[Token(Token = "0x60005FB")]
			[Address(RVA = "0x115ED20", Offset = "0x115ED20", VA = "0x115ED20")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60005FA")]
			[Address(RVA = "0x115ECA0", Offset = "0x115ECA0", VA = "0x115ECA0")]
			set
			{
			}
		}

		[Token(Token = "0x1700007A")]
		public float y
		{
			[Token(Token = "0x60005FD")]
			[Address(RVA = "0x115EE10", Offset = "0x115EE10", VA = "0x115EE10")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60005FC")]
			[Address(RVA = "0x115ED90", Offset = "0x115ED90", VA = "0x115ED90")]
			set
			{
			}
		}

		[Token(Token = "0x1700007B")]
		public float z
		{
			[Token(Token = "0x60005FF")]
			[Address(RVA = "0x115EF00", Offset = "0x115EF00", VA = "0x115EF00")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60005FE")]
			[Address(RVA = "0x115EE80", Offset = "0x115EE80", VA = "0x115EE80")]
			set
			{
			}
		}

		[Token(Token = "0x1700007C")]
		public float w
		{
			[Token(Token = "0x6000601")]
			[Address(RVA = "0x115EFF0", Offset = "0x115EFF0", VA = "0x115EFF0")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000600")]
			[Address(RVA = "0x115EF70", Offset = "0x115EF70", VA = "0x115EF70")]
			set
			{
			}
		}

		[Token(Token = "0x60005F5")]
		[Address(RVA = "0x115E9A8", Offset = "0x115E9A8", VA = "0x115E9A8")]
		internal TBQuat(IntPtr cPtr, bool cMemoryOwn)
		{
		}

		[Token(Token = "0x60005F6")]
		[Address(RVA = "0x115EA0C", Offset = "0x115EA0C", VA = "0x115EA0C")]
		public static HandleRef getCPtr(TBQuat obj)
		{
			return default(HandleRef);
		}

		[Token(Token = "0x60005F7")]
		[Address(RVA = "0x115EA80", Offset = "0x115EA80", VA = "0x115EA80", Slot = "1")]
		~TBQuat()
		{
		}

		[Token(Token = "0x60005F8")]
		[Address(RVA = "0x115EAF4", Offset = "0x115EAF4", VA = "0x115EAF4", Slot = "4")]
		public void Dispose()
		{
		}

		[Token(Token = "0x60005F9")]
		[Address(RVA = "0x115EB70", Offset = "0x115EB70", VA = "0x115EB70", Slot = "5")]
		protected virtual void Dispose(bool disposing)
		{
		}

		[Token(Token = "0x6000602")]
		[Address(RVA = "0x115F060", Offset = "0x115F060", VA = "0x115F060")]
		public TBQuat()
		{
		}

		[Token(Token = "0x6000603")]
		[Address(RVA = "0x115F0D4", Offset = "0x115F0D4", VA = "0x115F0D4")]
		public TBQuat(float xValue, float yValue, float zValue, float wValue)
		{
		}

		[Token(Token = "0x6000604")]
		[Address(RVA = "0x115F178", Offset = "0x115F178", VA = "0x115F178")]
		public TBQuat(TBQuat quat)
		{
		}

		[Token(Token = "0x6000605")]
		[Address(RVA = "0x115F270", Offset = "0x115F270", VA = "0x115F270")]
		public string toString(int precision)
		{
			return null;
		}

		[Token(Token = "0x6000606")]
		[Address(RVA = "0x115F2F0", Offset = "0x115F2F0", VA = "0x115F2F0")]
		public string toString()
		{
			return null;
		}

		[Token(Token = "0x6000607")]
		[Address(RVA = "0x115F360", Offset = "0x115F360", VA = "0x115F360")]
		public TBQuat invert()
		{
			return null;
		}

		[Token(Token = "0x6000608")]
		[Address(RVA = "0x115F400", Offset = "0x115F400", VA = "0x115F400")]
		public static TBQuat convertFromOpenGLQuaternion(float x, float y, float z, float w)
		{
			return null;
		}

		[Token(Token = "0x6000609")]
		[Address(RVA = "0x115F4C0", Offset = "0x115F4C0", VA = "0x115F4C0")]
		public static TBQuat getQuatFromEulerAngles(float x_radians, float y_radians, float z_radians)
		{
			return null;
		}

		[Token(Token = "0x600060A")]
		[Address(RVA = "0x115F578", Offset = "0x115F578", VA = "0x115F578")]
		public static TBVector getEulerAnglesFromQuat(TBQuat q)
		{
			return null;
		}

		[Token(Token = "0x600060B")]
		[Address(RVA = "0x115F6E4", Offset = "0x115F6E4", VA = "0x115F6E4")]
		public static TBQuat quatProductUnNormalised(TBQuat a, TBQuat b)
		{
			return null;
		}

		[Token(Token = "0x600060C")]
		[Address(RVA = "0x115F810", Offset = "0x115F810", VA = "0x115F810")]
		public static TBVector rotateVectorByQuat(TBQuat quat, TBVector vector)
		{
			return null;
		}

		[Token(Token = "0x600060D")]
		[Address(RVA = "0x115F9B0", Offset = "0x115F9B0", VA = "0x115F9B0")]
		public static TBVector antiRotateVectorByQuat(TBQuat rotQuat, TBVector vector)
		{
			return null;
		}

		[Token(Token = "0x600060E")]
		[Address(RVA = "0x115FADC", Offset = "0x115FADC", VA = "0x115FADC")]
		public static TBQuat getFromToQuatRotation(TBVector fromVec, TBVector toVec)
		{
			return null;
		}

		[Token(Token = "0x600060F")]
		[Address(RVA = "0x115FC08", Offset = "0x115FC08", VA = "0x115FC08")]
		public static TBVector getForwardFromQuat(TBQuat quat)
		{
			return null;
		}

		[Token(Token = "0x6000610")]
		[Address(RVA = "0x115FD10", Offset = "0x115FD10", VA = "0x115FD10")]
		public static TBVector getUpFromQuat(TBQuat quat)
		{
			return null;
		}

		[Token(Token = "0x6000611")]
		[Address(RVA = "0x115FE18", Offset = "0x115FE18", VA = "0x115FE18")]
		public static TBVector getRightFromQuat(TBQuat quat)
		{
			return null;
		}

		[Token(Token = "0x6000612")]
		[Address(RVA = "0x115FF20", Offset = "0x115FF20", VA = "0x115FF20")]
		public static TBQuat getQuatFromForwardAndUpVectors(TBVector forwardVector, TBVector upVector)
		{
			return null;
		}

		[Token(Token = "0x6000613")]
		[Address(RVA = "0x116004C", Offset = "0x116004C", VA = "0x116004C")]
		public static TBQuat getQuatFromMatrix(float m00, float m01, float m02, float m10, float m11, float m12, float m20, float m21, float m22)
		{
			return null;
		}

		[Token(Token = "0x6000614")]
		[Address(RVA = "0x1160154", Offset = "0x1160154", VA = "0x1160154")]
		public static TBQuat identity()
		{
			return null;
		}

		[Token(Token = "0x6000615")]
		[Address(RVA = "0x11601E4", Offset = "0x11601E4", VA = "0x11601E4")]
		public void normalise()
		{
		}

		[Token(Token = "0x6000616")]
		[Address(RVA = "0x1160254", Offset = "0x1160254", VA = "0x1160254")]
		public static TBQuat generateRandomQuat()
		{
			return null;
		}
	}
	[Token(Token = "0x2000083")]
	public class TBVector : IDisposable
	{
		[Token(Token = "0x4000224")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private HandleRef swigCPtr;

		[Token(Token = "0x4000225")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		protected bool swigCMemOwn;

		[Token(Token = "0x1700007D")]
		public float x
		{
			[Token(Token = "0x600061D")]
			[Address(RVA = "0x1160584", Offset = "0x1160584", VA = "0x1160584")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600061C")]
			[Address(RVA = "0x1160504", Offset = "0x1160504", VA = "0x1160504")]
			set
			{
			}
		}

		[Token(Token = "0x1700007E")]
		public float y
		{
			[Token(Token = "0x600061F")]
			[Address(RVA = "0x1160674", Offset = "0x1160674", VA = "0x1160674")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600061E")]
			[Address(RVA = "0x11605F4", Offset = "0x11605F4", VA = "0x11605F4")]
			set
			{
			}
		}

		[Token(Token = "0x1700007F")]
		public float z
		{
			[Token(Token = "0x6000621")]
			[Address(RVA = "0x1160764", Offset = "0x1160764", VA = "0x1160764")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000620")]
			[Address(RVA = "0x11606E4", Offset = "0x11606E4", VA = "0x11606E4")]
			set
			{
			}
		}

		[Token(Token = "0x6000617")]
		[Address(RVA = "0x115F680", Offset = "0x115F680", VA = "0x115F680")]
		internal TBVector(IntPtr cPtr, bool cMemoryOwn)
		{
		}

		[Token(Token = "0x6000618")]
		[Address(RVA = "0x115F93C", Offset = "0x115F93C", VA = "0x115F93C")]
		public static HandleRef getCPtr(TBVector obj)
		{
			return default(HandleRef);
		}

		[Token(Token = "0x6000619")]
		[Address(RVA = "0x11602E4", Offset = "0x11602E4", VA = "0x11602E4", Slot = "1")]
		~TBVector()
		{
		}

		[Token(Token = "0x600061A")]
		[Address(RVA = "0x1160358", Offset = "0x1160358", VA = "0x1160358", Slot = "4")]
		public void Dispose()
		{
		}

		[Token(Token = "0x600061B")]
		[Address(RVA = "0x11603D4", Offset = "0x11603D4", VA = "0x11603D4", Slot = "5")]
		protected virtual void Dispose(bool disposing)
		{
		}

		[Token(Token = "0x6000622")]
		[Address(RVA = "0x11607D4", Offset = "0x11607D4", VA = "0x11607D4")]
		public TBVector()
		{
		}

		[Token(Token = "0x6000623")]
		[Address(RVA = "0x1160848", Offset = "0x1160848", VA = "0x1160848")]
		public TBVector(float xValue, float yValue, float zValue)
		{
		}

		[Token(Token = "0x6000624")]
		[Address(RVA = "0x11608E4", Offset = "0x11608E4", VA = "0x11608E4")]
		public TBVector(float value)
		{
		}

		[Token(Token = "0x6000625")]
		[Address(RVA = "0x1160968", Offset = "0x1160968", VA = "0x1160968")]
		public static TBVector CrossProduct(TBVector vectorA, TBVector vectorB)
		{
			return null;
		}

		[Token(Token = "0x6000626")]
		[Address(RVA = "0x1160A94", Offset = "0x1160A94", VA = "0x1160A94")]
		public static TBVector zero()
		{
			return null;
		}

		[Token(Token = "0x6000627")]
		[Address(RVA = "0x1160B24", Offset = "0x1160B24", VA = "0x1160B24")]
		public static TBVector forward()
		{
			return null;
		}

		[Token(Token = "0x6000628")]
		[Address(RVA = "0x1160BB4", Offset = "0x1160BB4", VA = "0x1160BB4")]
		public static TBVector up()
		{
			return null;
		}

		[Token(Token = "0x6000629")]
		[Address(RVA = "0x1160C44", Offset = "0x1160C44", VA = "0x1160C44")]
		public static float DotProduct(TBVector vectorA, TBVector vectorB)
		{
			return default(float);
		}

		[Token(Token = "0x600062A")]
		[Address(RVA = "0x1160D54", Offset = "0x1160D54", VA = "0x1160D54")]
		public static float Angle(TBVector vectorA, TBVector vectorB)
		{
			return default(float);
		}

		[Token(Token = "0x600062B")]
		[Address(RVA = "0x1160E64", Offset = "0x1160E64", VA = "0x1160E64")]
		public static float magnitude(TBVector vector)
		{
			return default(float);
		}

		[Token(Token = "0x600062C")]
		[Address(RVA = "0x1160F50", Offset = "0x1160F50", VA = "0x1160F50")]
		public static void clampMagnitude(TBVector vector, float maxValue)
		{
		}

		[Token(Token = "0x600062D")]
		[Address(RVA = "0x116103C", Offset = "0x116103C", VA = "0x116103C")]
		public static float magSquared(TBVector vector)
		{
			return default(float);
		}

		[Token(Token = "0x600062E")]
		[Address(RVA = "0x1161128", Offset = "0x1161128", VA = "0x1161128")]
		public static void normalise(TBVector vector)
		{
		}

		[Token(Token = "0x600062F")]
		[Address(RVA = "0x1161204", Offset = "0x1161204", VA = "0x1161204")]
		public void set(float xValue, float yValue, float zValue)
		{
		}

		[Token(Token = "0x6000630")]
		[Address(RVA = "0x116129C", Offset = "0x116129C", VA = "0x116129C")]
		public void abs()
		{
		}

		[Token(Token = "0x6000631")]
		[Address(RVA = "0x116130C", Offset = "0x116130C", VA = "0x116130C")]
		public static TBVector projectOntoPlane(TBVector inputVector, TBVector unitNormalToPlane)
		{
			return null;
		}

		[Token(Token = "0x6000632")]
		[Address(RVA = "0x1161438", Offset = "0x1161438", VA = "0x1161438")]
		public static void rotateByVectors(TBVector forwardVector, TBVector upVector, TBVector rotatedVectorOut)
		{
		}

		[Token(Token = "0x6000633")]
		[Address(RVA = "0x116155C", Offset = "0x116155C", VA = "0x116155C")]
		public float min_val()
		{
			return default(float);
		}

		[Token(Token = "0x6000634")]
		[Address(RVA = "0x11615CC", Offset = "0x11615CC", VA = "0x11615CC")]
		public float max_val()
		{
			return default(float);
		}

		[Token(Token = "0x6000635")]
		[Address(RVA = "0x116163C", Offset = "0x116163C", VA = "0x116163C")]
		public string toString(int precision)
		{
			return null;
		}

		[Token(Token = "0x6000636")]
		[Address(RVA = "0x11616BC", Offset = "0x11616BC", VA = "0x11616BC")]
		public string toString()
		{
			return null;
		}

		[Token(Token = "0x6000637")]
		[Address(RVA = "0x116172C", Offset = "0x116172C", VA = "0x116172C")]
		public static TBVector getVectorFromAziEle(float azimuth, float elevation)
		{
			return null;
		}

		[Token(Token = "0x6000638")]
		[Address(RVA = "0x11617D4", Offset = "0x11617D4", VA = "0x11617D4")]
		public static TBVector getVectorFromAziEleDist(float azimuth, float elevation, float dist)
		{
			return null;
		}

		[Token(Token = "0x6000639")]
		[Address(RVA = "0x116188C", Offset = "0x116188C", VA = "0x116188C")]
		public static TBVector getVectorFromEuler(TBVector eulerAngles)
		{
			return null;
		}
	}
	[Token(Token = "0x2000084")]
	public class ThreadSettings : IDisposable
	{
		[Token(Token = "0x4000226")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private HandleRef swigCPtr;

		[Token(Token = "0x4000227")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		protected bool swigCMemOwn;

		[Token(Token = "0x17000080")]
		public bool useDecoderThread
		{
			[Token(Token = "0x6000640")]
			[Address(RVA = "0x1161D0C", Offset = "0x1161D0C", VA = "0x1161D0C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600063F")]
			[Address(RVA = "0x1161C8C", Offset = "0x1161C8C", VA = "0x1161C8C")]
			set
			{
			}
		}

		[Token(Token = "0x600063A")]
		[Address(RVA = "0x1161994", Offset = "0x1161994", VA = "0x1161994")]
		internal ThreadSettings(IntPtr cPtr, bool cMemoryOwn)
		{
		}

		[Token(Token = "0x600063B")]
		[Address(RVA = "0x11619F8", Offset = "0x11619F8", VA = "0x11619F8")]
		public static HandleRef getCPtr(ThreadSettings obj)
		{
			return default(HandleRef);
		}

		[Token(Token = "0x600063C")]
		[Address(RVA = "0x1161A6C", Offset = "0x1161A6C", VA = "0x1161A6C", Slot = "1")]
		~ThreadSettings()
		{
		}

		[Token(Token = "0x600063D")]
		[Address(RVA = "0x1161AE0", Offset = "0x1161AE0", VA = "0x1161AE0", Slot = "4")]
		public void Dispose()
		{
		}

		[Token(Token = "0x600063E")]
		[Address(RVA = "0x1161B5C", Offset = "0x1161B5C", VA = "0x1161B5C", Slot = "5")]
		protected virtual void Dispose(bool disposing)
		{
		}

		[Token(Token = "0x6000641")]
		[Address(RVA = "0x1161D7C", Offset = "0x1161D7C", VA = "0x1161D7C")]
		public ThreadSettings()
		{
		}
	}
	[Token(Token = "0x2000085")]
	public class TransportControl : IDisposable
	{
		[Token(Token = "0x4000228")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private HandleRef swigCPtr;

		[Token(Token = "0x4000229")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		protected bool swigCMemOwn;

		[Token(Token = "0x6000642")]
		[Address(RVA = "0x1161DF0", Offset = "0x1161DF0", VA = "0x1161DF0")]
		internal TransportControl(IntPtr cPtr, bool cMemoryOwn)
		{
		}

		[Token(Token = "0x6000643")]
		[Address(RVA = "0x1161E54", Offset = "0x1161E54", VA = "0x1161E54")]
		public static HandleRef getCPtr(TransportControl obj)
		{
			return default(HandleRef);
		}

		[Token(Token = "0x6000644")]
		[Address(RVA = "0x1161EC8", Offset = "0x1161EC8", VA = "0x1161EC8", Slot = "1")]
		~TransportControl()
		{
		}

		[Token(Token = "0x6000645")]
		[Address(RVA = "0x1161F3C", Offset = "0x1161F3C", VA = "0x1161F3C", Slot = "4")]
		public void Dispose()
		{
		}

		[Token(Token = "0x6000646")]
		[Address(RVA = "0x1161FB8", Offset = "0x1161FB8", VA = "0x1161FB8", Slot = "5")]
		protected virtual void Dispose(bool disposing)
		{
		}

		[Token(Token = "0x6000647")]
		[Address(RVA = "0x11620E8", Offset = "0x11620E8", VA = "0x11620E8", Slot = "6")]
		public virtual EngineError play()
		{
			return default(EngineError);
		}

		[Token(Token = "0x6000648")]
		[Address(RVA = "0x1162158", Offset = "0x1162158", VA = "0x1162158", Slot = "7")]
		public virtual EngineError playScheduled(float millisecondsFromNow)
		{
			return default(EngineError);
		}

		[Token(Token = "0x6000649")]
		[Address(RVA = "0x11621D8", Offset = "0x11621D8", VA = "0x11621D8", Slot = "8")]
		public virtual EngineError playScheduled(float millisecondsFromNow, float fadeDurationInMs)
		{
			return default(EngineError);
		}

		[Token(Token = "0x600064A")]
		[Address(RVA = "0x1162260", Offset = "0x1162260", VA = "0x1162260", Slot = "9")]
		public virtual EngineError playWithFade(float fadeDurationInMs)
		{
			return default(EngineError);
		}

		[Token(Token = "0x600064B")]
		[Address(RVA = "0x11622E0", Offset = "0x11622E0", VA = "0x11622E0", Slot = "10")]
		public virtual EngineError pause()
		{
			return default(EngineError);
		}

		[Token(Token = "0x600064C")]
		[Address(RVA = "0x1162350", Offset = "0x1162350", VA = "0x1162350", Slot = "11")]
		public virtual EngineError pauseScheduled(float millisecondsFromNow)
		{
			return default(EngineError);
		}

		[Token(Token = "0x600064D")]
		[Address(RVA = "0x11623D0", Offset = "0x11623D0", VA = "0x11623D0", Slot = "12")]
		public virtual EngineError pauseScheduled(float millisecondsFromNow, float fadeDurationInMs)
		{
			return default(EngineError);
		}

		[Token(Token = "0x600064E")]
		[Address(RVA = "0x1162458", Offset = "0x1162458", VA = "0x1162458", Slot = "13")]
		public virtual EngineError pauseWithFade(float fadeDurationInMs)
		{
			return default(EngineError);
		}

		[Token(Token = "0x600064F")]
		[Address(RVA = "0x11624D8", Offset = "0x11624D8", VA = "0x11624D8", Slot = "14")]
		public virtual EngineError stop()
		{
			return default(EngineError);
		}

		[Token(Token = "0x6000650")]
		[Address(RVA = "0x1162548", Offset = "0x1162548", VA = "0x1162548", Slot = "15")]
		public virtual EngineError stopScheduled(float millisecondsFromNow)
		{
			return default(EngineError);
		}

		[Token(Token = "0x6000651")]
		[Address(RVA = "0x11625C8", Offset = "0x11625C8", VA = "0x11625C8", Slot = "16")]
		public virtual EngineError stopScheduled(float millisecondsFromNow, float fadeDurationInMs)
		{
			return default(EngineError);
		}

		[Token(Token = "0x6000652")]
		[Address(RVA = "0x1162650", Offset = "0x1162650", VA = "0x1162650", Slot = "17")]
		public virtual EngineError stopWithFade(float fadeDurationInMs)
		{
			return default(EngineError);
		}

		[Token(Token = "0x6000653")]
		[Address(RVA = "0x11626D0", Offset = "0x11626D0", VA = "0x11626D0", Slot = "18")]
		public virtual PlayState getPlayState()
		{
			return default(PlayState);
		}

		[Token(Token = "0x6000654")]
		[Address(RVA = "0x1162740", Offset = "0x1162740", VA = "0x1162740", Slot = "19")]
		public virtual void cancelScheduledParams()
		{
		}
	}
	[Token(Token = "0x2000086")]
	public class VoiceManager : IDisposable
	{
		[Token(Token = "0x400022A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private HandleRef swigCPtr;

		[Token(Token = "0x400022B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		protected bool swigCMemOwn;

		[Token(Token = "0x6000655")]
		[Address(RVA = "0x1163344", Offset = "0x1163344", VA = "0x1163344")]
		internal VoiceManager(IntPtr cPtr, bool cMemoryOwn)
		{
		}

		[Token(Token = "0x6000656")]
		[Address(RVA = "0x11633A8", Offset = "0x11633A8", VA = "0x11633A8")]
		public static HandleRef getCPtr(VoiceManager obj)
		{
			return default(HandleRef);
		}

		[Token(Token = "0x6000657")]
		[Address(RVA = "0x116341C", Offset = "0x116341C", VA = "0x116341C", Slot = "1")]
		~VoiceManager()
		{
		}

		[Token(Token = "0x6000658")]
		[Address(RVA = "0x1163490", Offset = "0x1163490", VA = "0x1163490", Slot = "4")]
		public void Dispose()
		{
		}

		[Token(Token = "0x6000659")]
		[Address(RVA = "0x116350C", Offset = "0x116350C", VA = "0x116350C", Slot = "5")]
		protected virtual void Dispose(bool disposing)
		{
		}

		[Token(Token = "0x600065A")]
		[Address(RVA = "0x116363C", Offset = "0x116363C", VA = "0x116363C", Slot = "6")]
		public virtual uint getMaxPhysicalVoices()
		{
			return default(uint);
		}

		[Token(Token = "0x600065B")]
		[Address(RVA = "0x11636AC", Offset = "0x11636AC", VA = "0x11636AC", Slot = "7")]
		public virtual uint getMaxVirtualVoices()
		{
			return default(uint);
		}

		[Token(Token = "0x600065C")]
		[Address(RVA = "0x116371C", Offset = "0x116371C", VA = "0x116371C", Slot = "8")]
		public virtual uint getMaxTotalVoices()
		{
			return default(uint);
		}

		[Token(Token = "0x600065D")]
		[Address(RVA = "0x116378C", Offset = "0x116378C", VA = "0x116378C", Slot = "9")]
		public virtual uint getNumPhysicalVoices()
		{
			return default(uint);
		}

		[Token(Token = "0x600065E")]
		[Address(RVA = "0x11637FC", Offset = "0x11637FC", VA = "0x11637FC", Slot = "10")]
		public virtual uint getNumVirtualVoices()
		{
			return default(uint);
		}

		[Token(Token = "0x600065F")]
		[Address(RVA = "0x116386C", Offset = "0x116386C", VA = "0x116386C", Slot = "11")]
		public virtual uint getNumTotalVoices()
		{
			return default(uint);
		}

		[Token(Token = "0x6000660")]
		[Address(RVA = "0x11638DC", Offset = "0x11638DC", VA = "0x11638DC", Slot = "12")]
		public virtual EngineError openVoice(out ulong voiceHandle, AudioAssetHandle assetHandle)
		{
			return default(EngineError);
		}

		[Token(Token = "0x6000661")]
		[Address(RVA = "0x11639F0", Offset = "0x11639F0", VA = "0x11639F0", Slot = "13")]
		public virtual EngineError closeVoice(ulong voiceHandle)
		{
			return default(EngineError);
		}

		[Token(Token = "0x6000662")]
		[Address(RVA = "0x1163A70", Offset = "0x1163A70", VA = "0x1163A70", Slot = "14")]
		public virtual bool voiceIsOpen(ulong voiceHandle)
		{
			return default(bool);
		}

		[Token(Token = "0x6000663")]
		[Address(RVA = "0x1163AF0", Offset = "0x1163AF0", VA = "0x1163AF0", Slot = "15")]
		public virtual EngineError play(ulong voiceHandle, float delayMs, float fadeTimeMs)
		{
			return default(EngineError);
		}

		[Token(Token = "0x6000664")]
		[Address(RVA = "0x1163B88", Offset = "0x1163B88", VA = "0x1163B88", Slot = "16")]
		public virtual EngineError pause(ulong voiceHandle, float delayMs, float fadeTimeMs)
		{
			return default(EngineError);
		}

		[Token(Token = "0x6000665")]
		[Address(RVA = "0x1163C20", Offset = "0x1163C20", VA = "0x1163C20", Slot = "17")]
		public virtual EngineError stop(ulong voiceHandle, float delayMs, float fadeTimeMs)
		{
			return default(EngineError);
		}

		[Token(Token = "0x6000666")]
		[Address(RVA = "0x1163CB8", Offset = "0x1163CB8", VA = "0x1163CB8", Slot = "18")]
		public virtual EngineError getPlayState(ulong voiceHandle, out PlayState playState)
		{
			return default(EngineError);
		}

		[Token(Token = "0x6000667")]
		[Address(RVA = "0x1163D40", Offset = "0x1163D40", VA = "0x1163D40", Slot = "19")]
		public virtual EngineError seekMs(ulong voiceHandle, float posMs)
		{
			return default(EngineError);
		}

		[Token(Token = "0x6000668")]
		[Address(RVA = "0x1163DD0", Offset = "0x1163DD0", VA = "0x1163DD0", Slot = "20")]
		public virtual EngineError getElapsedTimeMs(ulong voiceHandle, ref float timeMs)
		{
			return default(EngineError);
		}

		[Token(Token = "0x6000669")]
		[Address(RVA = "0x1163E58", Offset = "0x1163E58", VA = "0x1163E58", Slot = "21")]
		public virtual EngineError getDurationMs(ulong voiceHandle, ref float timeMs)
		{
			return default(EngineError);
		}

		[Token(Token = "0x600066A")]
		[Address(RVA = "0x1163EE0", Offset = "0x1163EE0", VA = "0x1163EE0", Slot = "22")]
		public virtual EngineError setParam(ulong voiceHandle, VoiceParam param, float value)
		{
			return default(EngineError);
		}

		[Token(Token = "0x600066B")]
		[Address(RVA = "0x1163F78", Offset = "0x1163F78", VA = "0x1163F78", Slot = "23")]
		public virtual EngineError getParam(ulong voiceHandle, VoiceParam param, ref float value)
		{
			return default(EngineError);
		}

		[Token(Token = "0x600066C")]
		[Address(RVA = "0x1164010", Offset = "0x1164010", VA = "0x1164010", Slot = "24")]
		public virtual EngineError getParamDescription(VoiceParam param, VoiceParamDescription description)
		{
			return default(EngineError);
		}

		[Token(Token = "0x600066D")]
		[Address(RVA = "0x1164194", Offset = "0x1164194", VA = "0x1164194", Slot = "25")]
		public virtual EngineError setBus(ulong voiceHandle, IntPtr bus)
		{
			return default(EngineError);
		}

		[Token(Token = "0x600066E")]
		[Address(RVA = "0x116421C", Offset = "0x116421C", VA = "0x116421C", Slot = "26")]
		public virtual EngineError getBus(ulong voiceHandle, out IntPtr bus)
		{
			return default(EngineError);
		}

		[Token(Token = "0x600066F")]
		[Address(RVA = "0x11642A4", Offset = "0x11642A4", VA = "0x11642A4", Slot = "27")]
		public virtual EngineError getVoiceMode(ulong voiceHandle, out VoiceMode mode)
		{
			return default(EngineError);
		}

		[Token(Token = "0x6000670")]
		[Address(RVA = "0x116432C", Offset = "0x116432C", VA = "0x116432C", Slot = "28")]
		public virtual EngineError setEventCallback(VoiceManagerEventCb callback, IntPtr userData)
		{
			return default(EngineError);
		}
	}
	[Token(Token = "0x2000087")]
	public enum VoiceManagerEvent
	{
		[Token(Token = "0x400022D")]
		Invalid,
		[Token(Token = "0x400022E")]
		VoiceCreated,
		[Token(Token = "0x400022F")]
		VoiceOpened,
		[Token(Token = "0x4000230")]
		VoiceDestroyed,
		[Token(Token = "0x4000231")]
		VoicePlayStateChanged,
		[Token(Token = "0x4000232")]
		VoiceFinishedPlaying,
		[Token(Token = "0x4000233")]
		VoiceModeChanged,
		[Token(Token = "0x4000234")]
		VoiceError
	}
	[Token(Token = "0x2000088")]
	public class VoiceManagerSettings : IDisposable
	{
		[Token(Token = "0x4000235")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private HandleRef swigCPtr;

		[Token(Token = "0x4000236")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		protected bool swigCMemOwn;

		[Token(Token = "0x17000081")]
		public uint maxPhysicalVoices
		{
			[Token(Token = "0x6000677")]
			[Address(RVA = "0x1164AC0", Offset = "0x1164AC0", VA = "0x1164AC0")]
			get
			{
				return default(uint);
			}
			[Token(Token = "0x6000676")]
			[Address(RVA = "0x1164A40", Offset = "0x1164A40", VA = "0x1164A40")]
			set
			{
			}
		}

		[Token(Token = "0x17000082")]
		public uint maxVirtualVoices
		{
			[Token(Token = "0x6000679")]
			[Address(RVA = "0x1164BB0", Offset = "0x1164BB0", VA = "0x1164BB0")]
			get
			{
				return default(uint);
			}
			[Token(Token = "0x6000678")]
			[Address(RVA = "0x1164B30", Offset = "0x1164B30", VA = "0x1164B30")]
			set
			{
			}
		}

		[Token(Token = "0x6000671")]
		[Address(RVA = "0x1164748", Offset = "0x1164748", VA = "0x1164748")]
		internal VoiceManagerSettings(IntPtr cPtr, bool cMemoryOwn)
		{
		}

		[Token(Token = "0x6000672")]
		[Address(RVA = "0x11647AC", Offset = "0x11647AC", VA = "0x11647AC")]
		public static HandleRef getCPtr(VoiceManagerSettings obj)
		{
			return default(HandleRef);
		}

		[Token(Token = "0x6000673")]
		[Address(RVA = "0x1164820", Offset = "0x1164820", VA = "0x1164820", Slot = "1")]
		~VoiceManagerSettings()
		{
		}

		[Token(Token = "0x6000674")]
		[Address(RVA = "0x1164894", Offset = "0x1164894", VA = "0x1164894", Slot = "4")]
		public void Dispose()
		{
		}

		[Token(Token = "0x6000675")]
		[Address(RVA = "0x1164910", Offset = "0x1164910", VA = "0x1164910", Slot = "5")]
		protected virtual void Dispose(bool disposing)
		{
		}

		[Token(Token = "0x600067A")]
		[Address(RVA = "0x1164C20", Offset = "0x1164C20", VA = "0x1164C20")]
		public VoiceManagerSettings()
		{
		}
	}
	[Token(Token = "0x2000089")]
	public enum VoiceMode
	{
		[Token(Token = "0x4000238")]
		Physical,
		[Token(Token = "0x4000239")]
		Virtual,
		[Token(Token = "0x400023A")]
		Invalid
	}
	[Token(Token = "0x200008A")]
	public enum VoiceParam
	{
		[Token(Token = "0x400023C")]
		Loop,
		[Token(Token = "0x400023D")]
		Volume,
		[Token(Token = "0x400023E")]
		VolumeRampMs,
		[Token(Token = "0x400023F")]
		Pitch,
		[Token(Token = "0x4000240")]
		Spatialise,
		[Token(Token = "0x4000241")]
		AttenuationMode,
		[Token(Token = "0x4000242")]
		CustomAttenuation,
		[Token(Token = "0x4000243")]
		AttenuationProps_MinDistance,
		[Token(Token = "0x4000244")]
		AttenuationProps_MaxDistance,
		[Token(Token = "0x4000245")]
		AttenuationProps_Factor,
		[Token(Token = "0x4000246")]
		AttenuationProps_MaxDistanceMute,
		[Token(Token = "0x4000247")]
		DirectionalityEnabled,
		[Token(Token = "0x4000248")]
		DirectionalProps_EffectLevel,
		[Token(Token = "0x4000249")]
		DirectionalProps_ConeArea,
		[Token(Token = "0x400024A")]
		Position_X,
		[Token(Token = "0x400024B")]
		Position_Y,
		[Token(Token = "0x400024C")]
		Position_Z,
		[Token(Token = "0x400024D")]
		Rotation_X,
		[Token(Token = "0x400024E")]
		Rotation_Y,
		[Token(Token = "0x400024F")]
		Rotation_Z,
		[Token(Token = "0x4000250")]
		Rotation_W,
		[Token(Token = "0x4000251")]
		Priority,
		[Token(Token = "0x4000252")]
		Num_Params
	}
	[Token(Token = "0x200008B")]
	public class VoiceParamDescription : IDisposable
	{
		[Token(Token = "0x4000253")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private HandleRef swigCPtr;

		[Token(Token = "0x4000254")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		protected bool swigCMemOwn;

		[Token(Token = "0x17000083")]
		public float min
		{
			[Token(Token = "0x6000681")]
			[Address(RVA = "0x1164F98", Offset = "0x1164F98", VA = "0x1164F98")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000680")]
			[Address(RVA = "0x1164F18", Offset = "0x1164F18", VA = "0x1164F18")]
			set
			{
			}
		}

		[Token(Token = "0x17000084")]
		public float max
		{
			[Token(Token = "0x6000683")]
			[Address(RVA = "0x1165088", Offset = "0x1165088", VA = "0x1165088")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000682")]
			[Address(RVA = "0x1165008", Offset = "0x1165008", VA = "0x1165008")]
			set
			{
			}
		}

		[Token(Token = "0x17000085")]
		public float defaultValue
		{
			[Token(Token = "0x6000685")]
			[Address(RVA = "0x1165178", Offset = "0x1165178", VA = "0x1165178")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000684")]
			[Address(RVA = "0x11650F8", Offset = "0x11650F8", VA = "0x11650F8")]
			set
			{
			}
		}

		[Token(Token = "0x17000086")]
		public float stepSize
		{
			[Token(Token = "0x6000687")]
			[Address(RVA = "0x1165268", Offset = "0x1165268", VA = "0x1165268")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000686")]
			[Address(RVA = "0x11651E8", Offset = "0x11651E8", VA = "0x11651E8")]
			set
			{
			}
		}

		[Token(Token = "0x600067B")]
		[Address(RVA = "0x1164C94", Offset = "0x1164C94", VA = "0x1164C94")]
		internal VoiceParamDescription(IntPtr cPtr, bool cMemoryOwn)
		{
		}

		[Token(Token = "0x600067C")]
		[Address(RVA = "0x1164120", Offset = "0x1164120", VA = "0x1164120")]
		public static HandleRef getCPtr(VoiceParamDescription obj)
		{
			return default(HandleRef);
		}

		[Token(Token = "0x600067D")]
		[Address(RVA = "0x1164CF8", Offset = "0x1164CF8", VA = "0x1164CF8", Slot = "1")]
		~VoiceParamDescription()
		{
		}

		[Token(Token = "0x600067E")]
		[Address(RVA = "0x1164D6C", Offset = "0x1164D6C", VA = "0x1164D6C", Slot = "4")]
		public void Dispose()
		{
		}

		[Token(Token = "0x600067F")]
		[Address(RVA = "0x1164DE8", Offset = "0x1164DE8", VA = "0x1164DE8", Slot = "5")]
		protected virtual void Dispose(bool disposing)
		{
		}

		[Token(Token = "0x6000688")]
		[Address(RVA = "0x11652D8", Offset = "0x11652D8", VA = "0x11652D8")]
		public VoiceParamDescription()
		{
		}
	}
}
