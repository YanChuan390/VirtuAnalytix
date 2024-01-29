using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Core.PathCore;
using DG.Tweening.Plugins.Options;
using Il2CppDummyDll;
using Oculus.Platform.Models;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.EventSystems;
using UnityEngine.Events;
using UnityEngine.Playables;
using UnityEngine.Scripting;
using UnityEngine.Timeline;
using UnityEngine.UI;
using UnityEngine.Video;
using Valve.VR;

[assembly: AssemblyVersion("0.0.0.0")]
[Token(Token = "0x2000002")]
[ExecuteInEditMode]
public class BoneMapReset : MonoBehaviour
{
	[Token(Token = "0x4000001")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject original;

	[Token(Token = "0x6000001")]
	[Address(RVA = "0x1A26BD8", Offset = "0x1A26BD8", VA = "0x1A26BD8")]
	public void Convert()
	{
	}

	[Token(Token = "0x6000002")]
	[Address(RVA = "0x1A26CBC", Offset = "0x1A26CBC", VA = "0x1A26CBC")]
	private void Reset(SkinnedMeshRenderer targetRenderer, string name)
	{
	}

	[Token(Token = "0x6000003")]
	[Address(RVA = "0x1A26F6C", Offset = "0x1A26F6C", VA = "0x1A26F6C")]
	private GameObject getChildGameObject(GameObject fromGameObject, string withName)
	{
		return null;
	}

	[Token(Token = "0x6000004")]
	[Address(RVA = "0x1A2706C", Offset = "0x1A2706C", VA = "0x1A2706C")]
	public BoneMapReset()
	{
	}
}
[Serializable]
[Token(Token = "0x2000003")]
public class LightControlBehaviour : PlayableBehaviour
{
	[Token(Token = "0x4000002")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public Color color;

	[Token(Token = "0x4000003")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float intensity;

	[Token(Token = "0x4000004")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public float bounceIntensity;

	[Token(Token = "0x4000005")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float range;

	[Token(Token = "0x6000005")]
	[Address(RVA = "0x1A390BC", Offset = "0x1A390BC", VA = "0x1A390BC")]
	public LightControlBehaviour()
	{
	}
}
[Serializable]
[Token(Token = "0x2000004")]
public class LightControlClip : PlayableAsset, ITimelineClipAsset
{
	[Token(Token = "0x4000006")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public LightControlBehaviour template;

	[Token(Token = "0x17000001")]
	public ClipCaps clipCaps
	{
		[Token(Token = "0x6000006")]
		[Address(RVA = "0x1A39100", Offset = "0x1A39100", VA = "0x1A39100", Slot = "9")]
		get
		{
			return default(ClipCaps);
		}
	}

	[Token(Token = "0x6000007")]
	[Address(RVA = "0x1A39108", Offset = "0x1A39108", VA = "0x1A39108", Slot = "6")]
	public override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
	{
		return default(Playable);
	}

	[Token(Token = "0x6000008")]
	[Address(RVA = "0x1A391A8", Offset = "0x1A391A8", VA = "0x1A391A8")]
	public LightControlClip()
	{
	}
}
[Token(Token = "0x2000005")]
public class LightControlMixerBehaviour : PlayableBehaviour
{
	[Token(Token = "0x4000007")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private Color m_DefaultColor;

	[Token(Token = "0x4000008")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private float m_DefaultIntensity;

	[Token(Token = "0x4000009")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	private float m_DefaultBounceIntensity;

	[Token(Token = "0x400000A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private float m_DefaultRange;

	[Token(Token = "0x400000B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Light m_TrackBinding;

	[Token(Token = "0x400000C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private bool m_FirstFrameHappened;

	[Token(Token = "0x6000009")]
	[Address(RVA = "0x1A3920C", Offset = "0x1A3920C", VA = "0x1A3920C", Slot = "20")]
	public override void ProcessFrame(Playable playable, FrameData info, object playerData)
	{
	}

	[Token(Token = "0x600000A")]
	[Address(RVA = "0x1A395D8", Offset = "0x1A395D8", VA = "0x1A395D8", Slot = "16")]
	public override void OnPlayableDestroy(Playable playable)
	{
	}

	[Token(Token = "0x600000B")]
	[Address(RVA = "0x1A396B4", Offset = "0x1A396B4", VA = "0x1A396B4")]
	public LightControlMixerBehaviour()
	{
	}
}
[Token(Token = "0x2000006")]
[AttributeAttribute(Name = "TrackColorAttribute", RVA = "0x1182628", Offset = "0x1182628")]
[AttributeAttribute(Name = "TrackClipTypeAttribute", RVA = "0x1182628", Offset = "0x1182628")]
[AttributeAttribute(Name = "TrackBindingTypeAttribute", RVA = "0x1182628", Offset = "0x1182628")]
public class LightControlTrack : TrackAsset
{
	[Token(Token = "0x600000C")]
	[Address(RVA = "0x1A396BC", Offset = "0x1A396BC", VA = "0x1A396BC", Slot = "24")]
	public override Playable CreateTrackMixer(PlayableGraph graph, GameObject go, int inputCount)
	{
		return default(Playable);
	}

	[Token(Token = "0x600000D")]
	[Address(RVA = "0x1A39754", Offset = "0x1A39754", VA = "0x1A39754", Slot = "29")]
	public override void GatherProperties(PlayableDirector director, IPropertyCollector driver)
	{
	}

	[Token(Token = "0x600000E")]
	[Address(RVA = "0x1A3975C", Offset = "0x1A3975C", VA = "0x1A3975C")]
	public LightControlTrack()
	{
	}
}
[Serializable]
[Token(Token = "0x2000007")]
public class NavMeshAgentControlBehaviour : PlayableBehaviour
{
	[Token(Token = "0x400000D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public Transform destination;

	[Token(Token = "0x400000E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool destinationSet;

	[Token(Token = "0x600000F")]
	[Address(RVA = "0x181BE10", Offset = "0x181BE10", VA = "0x181BE10", Slot = "15")]
	public override void OnPlayableCreate(Playable playable)
	{
	}

	[Token(Token = "0x6000010")]
	[Address(RVA = "0x181BE18", Offset = "0x181BE18", VA = "0x181BE18")]
	public NavMeshAgentControlBehaviour()
	{
	}
}
[Serializable]
[Token(Token = "0x2000008")]
public class NavMeshAgentControlClip : PlayableAsset, ITimelineClipAsset
{
	[Token(Token = "0x400000F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public ExposedReference<Transform> destination;

	[Token(Token = "0x4000010")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[HideInInspector]
	public NavMeshAgentControlBehaviour template;

	[Token(Token = "0x17000002")]
	public ClipCaps clipCaps
	{
		[Token(Token = "0x6000011")]
		[Address(RVA = "0x181BE20", Offset = "0x181BE20", VA = "0x181BE20", Slot = "9")]
		get
		{
			return default(ClipCaps);
		}
	}

	[Token(Token = "0x6000012")]
	[Address(RVA = "0x181BE28", Offset = "0x181BE28", VA = "0x181BE28", Slot = "6")]
	public override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
	{
		return default(Playable);
	}

	[Token(Token = "0x6000013")]
	[Address(RVA = "0x181BF34", Offset = "0x181BF34", VA = "0x181BF34")]
	public NavMeshAgentControlClip()
	{
	}
}
[Token(Token = "0x2000009")]
public class NavMeshAgentControlMixerBehaviour : PlayableBehaviour
{
	[Token(Token = "0x6000014")]
	[Address(RVA = "0x181BF9C", Offset = "0x181BF9C", VA = "0x181BF9C", Slot = "20")]
	public override void ProcessFrame(Playable playable, FrameData info, object playerData)
	{
	}

	[Token(Token = "0x6000015")]
	[Address(RVA = "0x181C1CC", Offset = "0x181C1CC", VA = "0x181C1CC")]
	public NavMeshAgentControlMixerBehaviour()
	{
	}
}
[Token(Token = "0x200000A")]
[AttributeAttribute(Name = "TrackColorAttribute", RVA = "0x11826DC", Offset = "0x11826DC")]
[AttributeAttribute(Name = "TrackClipTypeAttribute", RVA = "0x11826DC", Offset = "0x11826DC")]
[AttributeAttribute(Name = "TrackBindingTypeAttribute", RVA = "0x11826DC", Offset = "0x11826DC")]
public class NavMeshAgentControlTrack : TrackAsset
{
	[Token(Token = "0x6000016")]
	[Address(RVA = "0x181C1D4", Offset = "0x181C1D4", VA = "0x181C1D4", Slot = "24")]
	public override Playable CreateTrackMixer(PlayableGraph graph, GameObject go, int inputCount)
	{
		return default(Playable);
	}

	[Token(Token = "0x6000017")]
	[Address(RVA = "0x181C26C", Offset = "0x181C26C", VA = "0x181C26C")]
	public NavMeshAgentControlTrack()
	{
	}
}
[Serializable]
[Token(Token = "0x200000B")]
public class ScreenFaderBehaviour : PlayableBehaviour
{
	[Token(Token = "0x4000011")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public Color color;

	[Token(Token = "0x6000018")]
	[Address(RVA = "0x333A2B4", Offset = "0x333A2B4", VA = "0x333A2B4")]
	public ScreenFaderBehaviour()
	{
	}
}
[Serializable]
[Token(Token = "0x200000C")]
public class ScreenFaderClip : PlayableAsset, ITimelineClipAsset
{
	[Token(Token = "0x4000012")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public ScreenFaderBehaviour template;

	[Token(Token = "0x17000003")]
	public ClipCaps clipCaps
	{
		[Token(Token = "0x6000019")]
		[Address(RVA = "0x333A2E8", Offset = "0x333A2E8", VA = "0x333A2E8", Slot = "9")]
		get
		{
			return default(ClipCaps);
		}
	}

	[Token(Token = "0x600001A")]
	[Address(RVA = "0x333A2F0", Offset = "0x333A2F0", VA = "0x333A2F0", Slot = "6")]
	public override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
	{
		return default(Playable);
	}

	[Token(Token = "0x600001B")]
	[Address(RVA = "0x333A390", Offset = "0x333A390", VA = "0x333A390")]
	public ScreenFaderClip()
	{
	}
}
[Token(Token = "0x200000D")]
public class ScreenFaderMixerBehaviour : PlayableBehaviour
{
	[Token(Token = "0x4000013")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private Color m_DefaultColor;

	[Token(Token = "0x4000014")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Image m_TrackBinding;

	[Token(Token = "0x4000015")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private bool m_FirstFrameHappened;

	[Token(Token = "0x600001C")]
	[Address(RVA = "0x333A3F4", Offset = "0x333A3F4", VA = "0x333A3F4", Slot = "20")]
	public override void ProcessFrame(Playable playable, FrameData info, object playerData)
	{
	}

	[Token(Token = "0x600001D")]
	[Address(RVA = "0x333A708", Offset = "0x333A708", VA = "0x333A708", Slot = "16")]
	public override void OnPlayableDestroy(Playable playable)
	{
	}

	[Token(Token = "0x600001E")]
	[Address(RVA = "0x333A7B0", Offset = "0x333A7B0", VA = "0x333A7B0")]
	public ScreenFaderMixerBehaviour()
	{
	}
}
[Token(Token = "0x200000E")]
[AttributeAttribute(Name = "TrackColorAttribute", RVA = "0x1182790", Offset = "0x1182790")]
[AttributeAttribute(Name = "TrackClipTypeAttribute", RVA = "0x1182790", Offset = "0x1182790")]
[AttributeAttribute(Name = "TrackBindingTypeAttribute", RVA = "0x1182790", Offset = "0x1182790")]
public class ScreenFaderTrack : TrackAsset
{
	[Token(Token = "0x600001F")]
	[Address(RVA = "0x333A7B8", Offset = "0x333A7B8", VA = "0x333A7B8", Slot = "24")]
	public override Playable CreateTrackMixer(PlayableGraph graph, GameObject go, int inputCount)
	{
		return default(Playable);
	}

	[Token(Token = "0x6000020")]
	[Address(RVA = "0x333A850", Offset = "0x333A850", VA = "0x333A850", Slot = "29")]
	public override void GatherProperties(PlayableDirector director, IPropertyCollector driver)
	{
	}

	[Token(Token = "0x6000021")]
	[Address(RVA = "0x333A858", Offset = "0x333A858", VA = "0x333A858")]
	public ScreenFaderTrack()
	{
	}
}
[Serializable]
[Token(Token = "0x200000F")]
public class TextSwitcherBehaviour : PlayableBehaviour
{
	[Token(Token = "0x4000016")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public Color color;

	[Token(Token = "0x4000017")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public int fontSize;

	[Token(Token = "0x4000018")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public string text;

	[Token(Token = "0x6000022")]
	[Address(RVA = "0x333A8C0", Offset = "0x333A8C0", VA = "0x333A8C0")]
	public TextSwitcherBehaviour()
	{
	}
}
[Serializable]
[Token(Token = "0x2000010")]
public class TextSwitcherClip : PlayableAsset, ITimelineClipAsset
{
	[Token(Token = "0x4000019")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public TextSwitcherBehaviour template;

	[Token(Token = "0x17000004")]
	public ClipCaps clipCaps
	{
		[Token(Token = "0x6000023")]
		[Address(RVA = "0x333A8FC", Offset = "0x333A8FC", VA = "0x333A8FC", Slot = "9")]
		get
		{
			return default(ClipCaps);
		}
	}

	[Token(Token = "0x6000024")]
	[Address(RVA = "0x333A904", Offset = "0x333A904", VA = "0x333A904", Slot = "6")]
	public override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
	{
		return default(Playable);
	}

	[Token(Token = "0x6000025")]
	[Address(RVA = "0x333A9A4", Offset = "0x333A9A4", VA = "0x333A9A4")]
	public TextSwitcherClip()
	{
	}
}
[Token(Token = "0x2000011")]
public class TextSwitcherMixerBehaviour : PlayableBehaviour
{
	[Token(Token = "0x400001A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private Color m_DefaultColor;

	[Token(Token = "0x400001B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private int m_DefaultFontSize;

	[Token(Token = "0x400001C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private string m_DefaultText;

	[Token(Token = "0x400001D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Text m_TrackBinding;

	[Token(Token = "0x400001E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private bool m_FirstFrameHappened;

	[Token(Token = "0x6000026")]
	[Address(RVA = "0x333AA08", Offset = "0x333AA08", VA = "0x333AA08", Slot = "20")]
	public override void ProcessFrame(Playable playable, FrameData info, object playerData)
	{
	}

	[Token(Token = "0x6000027")]
	[Address(RVA = "0x333AE3C", Offset = "0x333AE3C", VA = "0x333AE3C", Slot = "16")]
	public override void OnPlayableDestroy(Playable playable)
	{
	}

	[Token(Token = "0x6000028")]
	[Address(RVA = "0x333AF14", Offset = "0x333AF14", VA = "0x333AF14")]
	public TextSwitcherMixerBehaviour()
	{
	}
}
[Token(Token = "0x2000012")]
[AttributeAttribute(Name = "TrackColorAttribute", RVA = "0x1182840", Offset = "0x1182840")]
[AttributeAttribute(Name = "TrackClipTypeAttribute", RVA = "0x1182840", Offset = "0x1182840")]
[AttributeAttribute(Name = "TrackBindingTypeAttribute", RVA = "0x1182840", Offset = "0x1182840")]
public class TextSwitcherTrack : TrackAsset
{
	[Token(Token = "0x6000029")]
	[Address(RVA = "0x333AF1C", Offset = "0x333AF1C", VA = "0x333AF1C", Slot = "24")]
	public override Playable CreateTrackMixer(PlayableGraph graph, GameObject go, int inputCount)
	{
		return default(Playable);
	}

	[Token(Token = "0x600002A")]
	[Address(RVA = "0x333AFB4", Offset = "0x333AFB4", VA = "0x333AFB4", Slot = "29")]
	public override void GatherProperties(PlayableDirector director, IPropertyCollector driver)
	{
	}

	[Token(Token = "0x600002B")]
	[Address(RVA = "0x333AFBC", Offset = "0x333AFBC", VA = "0x333AFBC")]
	public TextSwitcherTrack()
	{
	}
}
[Serializable]
[Token(Token = "0x2000013")]
public class TimeDilationBehaviour : PlayableBehaviour
{
	[Token(Token = "0x400001F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public float timeScale;

	[Token(Token = "0x600002C")]
	[Address(RVA = "0x333B024", Offset = "0x333B024", VA = "0x333B024")]
	public TimeDilationBehaviour()
	{
	}
}
[Serializable]
[Token(Token = "0x2000014")]
public class TimeDilationClip : PlayableAsset, ITimelineClipAsset
{
	[Token(Token = "0x4000020")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public TimeDilationBehaviour template;

	[Token(Token = "0x17000005")]
	public ClipCaps clipCaps
	{
		[Token(Token = "0x600002D")]
		[Address(RVA = "0x333B034", Offset = "0x333B034", VA = "0x333B034", Slot = "9")]
		get
		{
			return default(ClipCaps);
		}
	}

	[Token(Token = "0x600002E")]
	[Address(RVA = "0x333B03C", Offset = "0x333B03C", VA = "0x333B03C", Slot = "6")]
	public override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
	{
		return default(Playable);
	}

	[Token(Token = "0x600002F")]
	[Address(RVA = "0x333B0DC", Offset = "0x333B0DC", VA = "0x333B0DC")]
	public TimeDilationClip()
	{
	}
}
[Token(Token = "0x2000015")]
public class TimeDilationMixerBehaviour : PlayableBehaviour
{
	[Token(Token = "0x4000021")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private readonly float defaultTimeScale;

	[Token(Token = "0x6000030")]
	[Address(RVA = "0x333B14C", Offset = "0x333B14C", VA = "0x333B14C", Slot = "20")]
	public override void ProcessFrame(Playable playable, FrameData info, object playerData)
	{
	}

	[Token(Token = "0x6000031")]
	[Address(RVA = "0x333B318", Offset = "0x333B318", VA = "0x333B318", Slot = "18")]
	public override void OnBehaviourPause(Playable playable, FrameData info)
	{
	}

	[Token(Token = "0x6000032")]
	[Address(RVA = "0x333B324", Offset = "0x333B324", VA = "0x333B324", Slot = "14")]
	public override void OnGraphStop(Playable playable)
	{
	}

	[Token(Token = "0x6000033")]
	[Address(RVA = "0x333B330", Offset = "0x333B330", VA = "0x333B330", Slot = "16")]
	public override void OnPlayableDestroy(Playable playable)
	{
	}

	[Token(Token = "0x6000034")]
	[Address(RVA = "0x333B33C", Offset = "0x333B33C", VA = "0x333B33C")]
	public TimeDilationMixerBehaviour()
	{
	}
}
[Token(Token = "0x2000016")]
[AttributeAttribute(Name = "TrackColorAttribute", RVA = "0x11828F4", Offset = "0x11828F4")]
[AttributeAttribute(Name = "TrackClipTypeAttribute", RVA = "0x11828F4", Offset = "0x11828F4")]
public class TimeDilationTrack : TrackAsset
{
	[Token(Token = "0x6000035")]
	[Address(RVA = "0x333B34C", Offset = "0x333B34C", VA = "0x333B34C", Slot = "24")]
	public override Playable CreateTrackMixer(PlayableGraph graph, GameObject go, int inputCount)
	{
		return default(Playable);
	}

	[Token(Token = "0x6000036")]
	[Address(RVA = "0x333B3E4", Offset = "0x333B3E4", VA = "0x333B3E4")]
	public TimeDilationTrack()
	{
	}
}
[Serializable]
[Token(Token = "0x2000017")]
public class TransformTweenBehaviour : PlayableBehaviour
{
	[Token(Token = "0x200015F")]
	public enum TweenType
	{
		[Token(Token = "0x4000524")]
		Linear,
		[Token(Token = "0x4000525")]
		Deceleration,
		[Token(Token = "0x4000526")]
		Harmonic,
		[Token(Token = "0x4000527")]
		Custom
	}

	[Token(Token = "0x4000022")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public Transform startLocation;

	[Token(Token = "0x4000023")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Transform endLocation;

	[Token(Token = "0x4000024")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public bool tweenPosition;

	[Token(Token = "0x4000025")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
	public bool tweenRotation;

	[Token(Token = "0x4000026")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public TweenType tweenType;

	[Token(Token = "0x4000027")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public AnimationCurve customCurve;

	[Token(Token = "0x4000028")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Vector3 startingPosition;

	[Token(Token = "0x4000029")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public Quaternion startingRotation;

	[Token(Token = "0x400002A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private AnimationCurve m_LinearCurve;

	[Token(Token = "0x400002B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private AnimationCurve m_DecelerationCurve;

	[Token(Token = "0x400002C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private AnimationCurve m_HarmonicCurve;

	[Token(Token = "0x400002D")]
	private const float k_RightAngleInRads = (float)Math.PI / 2f;

	[Token(Token = "0x6000037")]
	[Address(RVA = "0x333B44C", Offset = "0x333B44C", VA = "0x333B44C", Slot = "19")]
	public override void PrepareFrame(Playable playable, FrameData info)
	{
	}

	[Token(Token = "0x6000038")]
	[Address(RVA = "0x333B4F4", Offset = "0x333B4F4", VA = "0x333B4F4")]
	public float EvaluateCurrentCurve(float time)
	{
		return default(float);
	}

	[Token(Token = "0x6000039")]
	[Address(RVA = "0x333B5EC", Offset = "0x333B5EC", VA = "0x333B5EC")]
	private bool IsCustomCurveNormalised()
	{
		return default(bool);
	}

	[Token(Token = "0x600003A")]
	[Address(RVA = "0x333B814", Offset = "0x333B814", VA = "0x333B814")]
	public TransformTweenBehaviour()
	{
	}
}
[Serializable]
[Token(Token = "0x2000018")]
public class TransformTweenClip : PlayableAsset, ITimelineClipAsset
{
	[Token(Token = "0x400002E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public TransformTweenBehaviour template;

	[Token(Token = "0x400002F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public ExposedReference<Transform> startLocation;

	[Token(Token = "0x4000030")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public ExposedReference<Transform> endLocation;

	[Token(Token = "0x17000006")]
	public ClipCaps clipCaps
	{
		[Token(Token = "0x600003B")]
		[Address(RVA = "0x333B9F8", Offset = "0x333B9F8", VA = "0x333B9F8", Slot = "9")]
		get
		{
			return default(ClipCaps);
		}
	}

	[Token(Token = "0x600003C")]
	[Address(RVA = "0x333BA00", Offset = "0x333BA00", VA = "0x333BA00", Slot = "6")]
	public override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
	{
		return default(Playable);
	}

	[Token(Token = "0x600003D")]
	[Address(RVA = "0x333BB30", Offset = "0x333BB30", VA = "0x333BB30")]
	public TransformTweenClip()
	{
	}
}
[Token(Token = "0x2000019")]
public class TransformTweenMixerBehaviour : PlayableBehaviour
{
	[Token(Token = "0x4000031")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private bool m_FirstFrameHappened;

	[Token(Token = "0x600003E")]
	[Address(RVA = "0x333BB94", Offset = "0x333BB94", VA = "0x333BB94", Slot = "20")]
	public override void ProcessFrame(Playable playable, FrameData info, object playerData)
	{
	}

	[Token(Token = "0x600003F")]
	[Address(RVA = "0x333C2BC", Offset = "0x333C2BC", VA = "0x333C2BC", Slot = "16")]
	public override void OnPlayableDestroy(Playable playable)
	{
	}

	[Token(Token = "0x6000040")]
	[Address(RVA = "0x333C2A8", Offset = "0x333C2A8", VA = "0x333C2A8")]
	private static Quaternion AddQuaternions(Quaternion first, Quaternion second)
	{
		return default(Quaternion);
	}

	[Token(Token = "0x6000041")]
	[Address(RVA = "0x333C294", Offset = "0x333C294", VA = "0x333C294")]
	private static Quaternion ScaleQuaternion(Quaternion rotation, float multiplier)
	{
		return default(Quaternion);
	}

	[Token(Token = "0x6000042")]
	[Address(RVA = "0x333C2C4", Offset = "0x333C2C4", VA = "0x333C2C4")]
	private static float QuaternionMagnitude(Quaternion rotation)
	{
		return default(float);
	}

	[Token(Token = "0x6000043")]
	[Address(RVA = "0x333C1A4", Offset = "0x333C1A4", VA = "0x333C1A4")]
	private static Quaternion NormalizeQuaternion(Quaternion rotation)
	{
		return default(Quaternion);
	}

	[Token(Token = "0x6000044")]
	[Address(RVA = "0x333C3B0", Offset = "0x333C3B0", VA = "0x333C3B0")]
	public TransformTweenMixerBehaviour()
	{
	}
}
[Token(Token = "0x200001A")]
[AttributeAttribute(Name = "TrackColorAttribute", RVA = "0x1182980", Offset = "0x1182980")]
[AttributeAttribute(Name = "TrackClipTypeAttribute", RVA = "0x1182980", Offset = "0x1182980")]
[AttributeAttribute(Name = "TrackBindingTypeAttribute", RVA = "0x1182980", Offset = "0x1182980")]
public class TransformTweenTrack : TrackAsset
{
	[Token(Token = "0x6000045")]
	[Address(RVA = "0x333C3B8", Offset = "0x333C3B8", VA = "0x333C3B8", Slot = "24")]
	public override Playable CreateTrackMixer(PlayableGraph graph, GameObject go, int inputCount)
	{
		return default(Playable);
	}

	[Token(Token = "0x6000046")]
	[Address(RVA = "0x333C450", Offset = "0x333C450", VA = "0x333C450", Slot = "29")]
	public override void GatherProperties(PlayableDirector director, IPropertyCollector driver)
	{
	}

	[Token(Token = "0x6000047")]
	[Address(RVA = "0x333C458", Offset = "0x333C458", VA = "0x333C458")]
	public TransformTweenTrack()
	{
	}
}
[Token(Token = "0x200001B")]
public class DynamicBoneDemo1 : MonoBehaviour
{
	[Token(Token = "0x4000032")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject m_Player;

	[Token(Token = "0x6000048")]
	[Address(RVA = "0x1A36D14", Offset = "0x1A36D14", VA = "0x1A36D14")]
	private void Update()
	{
	}

	[Token(Token = "0x6000049")]
	[Address(RVA = "0x1A36EBC", Offset = "0x1A36EBC", VA = "0x1A36EBC")]
	private void OnGUI()
	{
	}

	[Token(Token = "0x600004A")]
	[Address(RVA = "0x1A3719C", Offset = "0x1A3719C", VA = "0x1A3719C")]
	public DynamicBoneDemo1()
	{
	}
}
[Token(Token = "0x200001C")]
[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x1182A34", Offset = "0x1182A34")]
public class DynamicBone : MonoBehaviour
{
	[Token(Token = "0x2000160")]
	public enum UpdateMode
	{
		[Token(Token = "0x4000529")]
		Normal,
		[Token(Token = "0x400052A")]
		AnimatePhysics,
		[Token(Token = "0x400052B")]
		UnscaledTime
	}

	[Token(Token = "0x2000161")]
	public enum FreezeAxis
	{
		[Token(Token = "0x400052D")]
		None,
		[Token(Token = "0x400052E")]
		X,
		[Token(Token = "0x400052F")]
		Y,
		[Token(Token = "0x4000530")]
		Z
	}

	[Token(Token = "0x2000162")]
	private class Particle
	{
		[Token(Token = "0x4000531")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform m_Transform;

		[Token(Token = "0x4000532")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int m_ParentIndex;

		[Token(Token = "0x4000533")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float m_Damping;

		[Token(Token = "0x4000534")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float m_Elasticity;

		[Token(Token = "0x4000535")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float m_Stiffness;

		[Token(Token = "0x4000536")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float m_Inert;

		[Token(Token = "0x4000537")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float m_Radius;

		[Token(Token = "0x4000538")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float m_BoneLength;

		[Token(Token = "0x4000539")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public Vector3 m_Position;

		[Token(Token = "0x400053A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Vector3 m_PrevPosition;

		[Token(Token = "0x400053B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public Vector3 m_EndOffset;

		[Token(Token = "0x400053C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Vector3 m_InitLocalPosition;

		[Token(Token = "0x400053D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public Quaternion m_InitLocalRotation;

		[Token(Token = "0x6000968")]
		[Address(RVA = "0x1A35948", Offset = "0x1A35948", VA = "0x1A35948")]
		public Particle()
		{
		}
	}

	[Token(Token = "0x4000033")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Transform m_Root;

	[Token(Token = "0x4000034")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float m_UpdateRate;

	[Token(Token = "0x4000035")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public UpdateMode m_UpdateMode;

	[Token(Token = "0x4000036")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x118386C", Offset = "0x118386C")]
	public float m_Damping;

	[Token(Token = "0x4000037")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public AnimationCurve m_DampingDistrib;

	[Token(Token = "0x4000038")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1183884", Offset = "0x1183884")]
	public float m_Elasticity;

	[Token(Token = "0x4000039")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public AnimationCurve m_ElasticityDistrib;

	[Token(Token = "0x400003A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x118389C", Offset = "0x118389C")]
	public float m_Stiffness;

	[Token(Token = "0x400003B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public AnimationCurve m_StiffnessDistrib;

	[Token(Token = "0x400003C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x11838B4", Offset = "0x11838B4")]
	public float m_Inert;

	[Token(Token = "0x400003D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public AnimationCurve m_InertDistrib;

	[Token(Token = "0x400003E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public float m_Radius;

	[Token(Token = "0x400003F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public AnimationCurve m_RadiusDistrib;

	[Token(Token = "0x4000040")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public float m_EndLength;

	[Token(Token = "0x4000041")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	public Vector3 m_EndOffset;

	[Token(Token = "0x4000042")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public Vector3 m_Gravity;

	[Token(Token = "0x4000043")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
	public Vector3 m_Force;

	[Token(Token = "0x4000044")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public List<DynamicBoneColliderBase> m_Colliders;

	[Token(Token = "0x4000045")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public List<Transform> m_Exclusions;

	[Token(Token = "0x4000046")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	public FreezeAxis m_FreezeAxis;

	[Token(Token = "0x4000047")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
	public bool m_DistantDisable;

	[Token(Token = "0x4000048")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	public Transform m_ReferenceObject;

	[Token(Token = "0x4000049")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	public float m_DistanceToObject;

	[Token(Token = "0x400004A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
	private Vector3 m_LocalGravity;

	[Token(Token = "0x400004B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	private Vector3 m_ObjectMove;

	[Token(Token = "0x400004C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
	private Vector3 m_ObjectPrevPosition;

	[Token(Token = "0x400004D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	private float m_BoneTotalLength;

	[Token(Token = "0x400004E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
	private float m_ObjectScale;

	[Token(Token = "0x400004F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	private float m_Time;

	[Token(Token = "0x4000050")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
	private float m_Weight;

	[Token(Token = "0x4000051")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	private bool m_DistantDisabled;

	[Token(Token = "0x4000052")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	private List<Particle> m_Particles;

	[Token(Token = "0x600004B")]
	[Address(RVA = "0x1A33014", Offset = "0x1A33014", VA = "0x1A33014")]
	private void Start()
	{
	}

	[Token(Token = "0x600004C")]
	[Address(RVA = "0x1A33194", Offset = "0x1A33194", VA = "0x1A33194")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x600004D")]
	[Address(RVA = "0x1A331E8", Offset = "0x1A331E8", VA = "0x1A331E8")]
	private void Update()
	{
	}

	[Token(Token = "0x600004E")]
	[Address(RVA = "0x1A33218", Offset = "0x1A33218", VA = "0x1A33218")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x600004F")]
	[Address(RVA = "0x1A331C4", Offset = "0x1A331C4", VA = "0x1A331C4")]
	private void PreUpdate()
	{
	}

	[Token(Token = "0x6000050")]
	[Address(RVA = "0x1A33278", Offset = "0x1A33278", VA = "0x1A33278")]
	private void CheckDistance()
	{
	}

	[Token(Token = "0x6000051")]
	[Address(RVA = "0x1A3391C", Offset = "0x1A3391C", VA = "0x1A3391C")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000052")]
	[Address(RVA = "0x1A33920", Offset = "0x1A33920", VA = "0x1A33920")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6000053")]
	[Address(RVA = "0x1A33924", Offset = "0x1A33924", VA = "0x1A33924")]
	private void OnValidate()
	{
	}

	[Token(Token = "0x6000054")]
	[Address(RVA = "0x1A33A40", Offset = "0x1A33A40", VA = "0x1A33A40")]
	private void OnDrawGizmosSelected()
	{
	}

	[Token(Token = "0x6000055")]
	[Address(RVA = "0x1A33BE4", Offset = "0x1A33BE4", VA = "0x1A33BE4")]
	public void SetWeight(float w)
	{
	}

	[Token(Token = "0x6000056")]
	[Address(RVA = "0x1A33C40", Offset = "0x1A33C40", VA = "0x1A33C40")]
	public float GetWeight()
	{
		return default(float);
	}

	[Token(Token = "0x6000057")]
	[Address(RVA = "0x1A3347C", Offset = "0x1A3347C", VA = "0x1A3347C")]
	private void UpdateDynamicBones(float t)
	{
	}

	[Token(Token = "0x6000058")]
	[Address(RVA = "0x1A33018", Offset = "0x1A33018", VA = "0x1A33018")]
	private void SetupParticles()
	{
	}

	[Token(Token = "0x6000059")]
	[Address(RVA = "0x1A34FF0", Offset = "0x1A34FF0", VA = "0x1A34FF0")]
	private void AppendParticles(Transform b, int parentIndex, float boneLength)
	{
	}

	[Token(Token = "0x600005A")]
	[Address(RVA = "0x1A35668", Offset = "0x1A35668", VA = "0x1A35668")]
	public void UpdateParameters()
	{
	}

	[Token(Token = "0x600005B")]
	[Address(RVA = "0x1A336C0", Offset = "0x1A336C0", VA = "0x1A336C0")]
	private void InitTransforms()
	{
	}

	[Token(Token = "0x600005C")]
	[Address(RVA = "0x1A337C0", Offset = "0x1A337C0", VA = "0x1A337C0")]
	private void ResetParticlesPosition()
	{
	}

	[Token(Token = "0x600005D")]
	[Address(RVA = "0x1A33C48", Offset = "0x1A33C48", VA = "0x1A33C48")]
	private void UpdateParticles1()
	{
	}

	[Token(Token = "0x600005E")]
	[Address(RVA = "0x1A33F58", Offset = "0x1A33F58", VA = "0x1A33F58")]
	private void UpdateParticles2()
	{
	}

	[Token(Token = "0x600005F")]
	[Address(RVA = "0x1A346E4", Offset = "0x1A346E4", VA = "0x1A346E4")]
	private void SkipUpdateParticles()
	{
	}

	[Token(Token = "0x6000060")]
	[Address(RVA = "0x1A35A28", Offset = "0x1A35A28", VA = "0x1A35A28")]
	private static Vector3 MirrorVector(Vector3 v, Vector3 axis)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000061")]
	[Address(RVA = "0x1A34D14", Offset = "0x1A34D14", VA = "0x1A34D14")]
	private void ApplyParticlesToTransforms()
	{
	}

	[Token(Token = "0x6000062")]
	[Address(RVA = "0x1A35B08", Offset = "0x1A35B08", VA = "0x1A35B08")]
	public DynamicBone()
	{
	}
}
[Token(Token = "0x200001D")]
[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x1182A6C", Offset = "0x1182A6C")]
public class DynamicBoneCollider : DynamicBoneColliderBase
{
	[Token(Token = "0x4000053")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public float m_Radius;

	[Token(Token = "0x4000054")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public float m_Height;

	[Token(Token = "0x6000063")]
	[Address(RVA = "0x1A35C28", Offset = "0x1A35C28", VA = "0x1A35C28")]
	private void OnValidate()
	{
	}

	[Token(Token = "0x6000064")]
	[Address(RVA = "0x1A35CC0", Offset = "0x1A35CC0", VA = "0x1A35CC0", Slot = "4")]
	public override void Collide(ref Vector3 particlePosition, float particleRadius)
	{
	}

	[Token(Token = "0x6000065")]
	[Address(RVA = "0x1A35F18", Offset = "0x1A35F18", VA = "0x1A35F18")]
	private static void OutsideSphere(ref Vector3 particlePosition, float particleRadius, Vector3 sphereCenter, float sphereRadius)
	{
	}

	[Token(Token = "0x6000066")]
	[Address(RVA = "0x1A360AC", Offset = "0x1A360AC", VA = "0x1A360AC")]
	private static void InsideSphere(ref Vector3 particlePosition, float particleRadius, Vector3 sphereCenter, float sphereRadius)
	{
	}

	[Token(Token = "0x6000067")]
	[Address(RVA = "0x1A36250", Offset = "0x1A36250", VA = "0x1A36250")]
	private static void OutsideCapsule(ref Vector3 particlePosition, float particleRadius, Vector3 capsuleP0, Vector3 capsuleP1, float capsuleRadius)
	{
	}

	[Token(Token = "0x6000068")]
	[Address(RVA = "0x1A3668C", Offset = "0x1A3668C", VA = "0x1A3668C")]
	private static void InsideCapsule(ref Vector3 particlePosition, float particleRadius, Vector3 capsuleP0, Vector3 capsuleP1, float capsuleRadius)
	{
	}

	[Token(Token = "0x6000069")]
	[Address(RVA = "0x1A36A9C", Offset = "0x1A36A9C", VA = "0x1A36A9C")]
	private void OnDrawGizmosSelected()
	{
	}

	[Token(Token = "0x600006A")]
	[Address(RVA = "0x1A36C84", Offset = "0x1A36C84", VA = "0x1A36C84")]
	public DynamicBoneCollider()
	{
	}
}
[Token(Token = "0x200001E")]
public class DynamicBoneColliderBase : MonoBehaviour
{
	[Token(Token = "0x2000163")]
	public enum Direction
	{
		[Token(Token = "0x400053F")]
		X,
		[Token(Token = "0x4000540")]
		Y,
		[Token(Token = "0x4000541")]
		Z
	}

	[Token(Token = "0x2000164")]
	public enum Bound
	{
		[Token(Token = "0x4000543")]
		Outside,
		[Token(Token = "0x4000544")]
		Inside
	}

	[Token(Token = "0x4000055")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Direction m_Direction;

	[Token(Token = "0x4000056")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public Vector3 m_Center;

	[Token(Token = "0x4000057")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Bound m_Bound;

	[Token(Token = "0x600006B")]
	[Address(RVA = "0x1A36D10", Offset = "0x1A36D10", VA = "0x1A36D10", Slot = "4")]
	public virtual void Collide(ref Vector3 particlePosition, float particleRadius)
	{
	}

	[Token(Token = "0x600006C")]
	[Address(RVA = "0x1A36C90", Offset = "0x1A36C90", VA = "0x1A36C90")]
	public DynamicBoneColliderBase()
	{
	}
}
[Token(Token = "0x200001F")]
[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x1182AA4", Offset = "0x1182AA4")]
public class DynamicBonePlaneCollider : DynamicBoneColliderBase
{
	[Token(Token = "0x600006D")]
	[Address(RVA = "0x1A371A4", Offset = "0x1A371A4", VA = "0x1A371A4")]
	private void OnValidate()
	{
	}

	[Token(Token = "0x600006E")]
	[Address(RVA = "0x1A371A8", Offset = "0x1A371A8", VA = "0x1A371A8", Slot = "4")]
	public override void Collide(ref Vector3 particlePosition, float particleRadius)
	{
	}

	[Token(Token = "0x600006F")]
	[Address(RVA = "0x1A37394", Offset = "0x1A37394", VA = "0x1A37394")]
	private void OnDrawGizmosSelected()
	{
	}

	[Token(Token = "0x6000070")]
	[Address(RVA = "0x1A37558", Offset = "0x1A37558", VA = "0x1A37558")]
	public DynamicBonePlaneCollider()
	{
	}
}
[Token(Token = "0x2000020")]
public class Introduction : MonoBehaviour
{
	[Token(Token = "0x6000071")]
	[Address(RVA = "0x1A38968", Offset = "0x1A38968", VA = "0x1A38968")]
	private void Start()
	{
	}

	[Token(Token = "0x6000072")]
	[Address(RVA = "0x1A3898C", Offset = "0x1A3898C", VA = "0x1A3898C")]
	public void _LoadLevel(string LVL_Name)
	{
	}

	[Token(Token = "0x6000073")]
	[Address(RVA = "0x1A38A58", Offset = "0x1A38A58", VA = "0x1A38A58")]
	public void OpenUrl1()
	{
	}

	[Token(Token = "0x6000074")]
	[Address(RVA = "0x1A38AA4", Offset = "0x1A38AA4", VA = "0x1A38AA4")]
	public void OpenUrl2()
	{
	}

	[Token(Token = "0x6000075")]
	[Address(RVA = "0x1A38AF0", Offset = "0x1A38AF0", VA = "0x1A38AF0")]
	public void OpenDocumentation()
	{
	}

	[Token(Token = "0x6000076")]
	[Address(RVA = "0x1A38B3C", Offset = "0x1A38B3C", VA = "0x1A38B3C")]
	public Introduction()
	{
	}
}
[Token(Token = "0x2000021")]
public class MeshSmoother : MonoBehaviour
{
	[Token(Token = "0x4000058")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private MeshFilter meshfilter;

	[Token(Token = "0x4000059")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Mesh mesh;

	[Token(Token = "0x400005A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private Vector3[] vertices;

	[Token(Token = "0x400005B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private int[] triangles;

	[Token(Token = "0x400005C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private int[] subdivision;

	[Token(Token = "0x400005D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x11838CC", Offset = "0x11838CC")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x11838CC", Offset = "0x11838CC")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x11838CC", Offset = "0x11838CC")]
	public int subdivisionLevel;

	[Token(Token = "0x400005E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x1183944", Offset = "0x1183944")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1183944", Offset = "0x1183944")]
	public int timesToSubdivide;

	[Token(Token = "0x6000077")]
	[Address(RVA = "0x181BC58", Offset = "0x181BC58", VA = "0x181BC58")]
	private void Start()
	{
	}

	[Token(Token = "0x6000078")]
	[Address(RVA = "0x181BD98", Offset = "0x181BD98", VA = "0x181BD98")]
	public MeshSmoother()
	{
	}
}
[Token(Token = "0x2000022")]
public class Perlin
{
	[Token(Token = "0x400005F")]
	private const int B = 256;

	[Token(Token = "0x4000060")]
	private const int BM = 255;

	[Token(Token = "0x4000061")]
	private const int N = 4096;

	[Token(Token = "0x4000062")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private int[] p;

	[Token(Token = "0x4000063")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private float[,] g3;

	[Token(Token = "0x4000064")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private float[,] g2;

	[Token(Token = "0x4000065")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private float[] g1;

	[Token(Token = "0x6000079")]
	[Address(RVA = "0x333961C", Offset = "0x333961C", VA = "0x333961C")]
	private float s_curve(float t)
	{
		return default(float);
	}

	[Token(Token = "0x600007A")]
	[Address(RVA = "0x3339634", Offset = "0x3339634", VA = "0x3339634")]
	private float lerp(float t, float a, float b)
	{
		return default(float);
	}

	[Token(Token = "0x600007B")]
	[Address(RVA = "0x3339644", Offset = "0x3339644", VA = "0x3339644")]
	private void setup(float value, out int b0, out int b1, out float r0, out float r1)
	{
	}

	[Token(Token = "0x600007C")]
	[Address(RVA = "0x3339684", Offset = "0x3339684", VA = "0x3339684")]
	private float at2(float rx, float ry, float x, float y)
	{
		return default(float);
	}

	[Token(Token = "0x600007D")]
	[Address(RVA = "0x3339694", Offset = "0x3339694", VA = "0x3339694")]
	private float at3(float rx, float ry, float rz, float x, float y, float z)
	{
		return default(float);
	}

	[Token(Token = "0x600007E")]
	[Address(RVA = "0x33396AC", Offset = "0x33396AC", VA = "0x33396AC")]
	public float Noise(float arg)
	{
		return default(float);
	}

	[Token(Token = "0x600007F")]
	[Address(RVA = "0x3339778", Offset = "0x3339778", VA = "0x3339778")]
	public float Noise(float x, float y)
	{
		return default(float);
	}

	[Token(Token = "0x6000080")]
	[Address(RVA = "0x333994C", Offset = "0x333994C", VA = "0x333994C")]
	public float Noise(float x, float y, float z)
	{
		return default(float);
	}

	[Token(Token = "0x6000081")]
	[Address(RVA = "0x3339CB8", Offset = "0x3339CB8", VA = "0x3339CB8")]
	private void normalize2(ref float x, ref float y)
	{
	}

	[Token(Token = "0x6000082")]
	[Address(RVA = "0x3339D6C", Offset = "0x3339D6C", VA = "0x3339D6C")]
	private void normalize3(ref float x, ref float y, ref float z)
	{
	}

	[Token(Token = "0x6000083")]
	[Address(RVA = "0x3339E44", Offset = "0x3339E44", VA = "0x3339E44")]
	public Perlin()
	{
	}
}
[Token(Token = "0x2000023")]
public class Examples_VR : MonoBehaviour
{
	[Token(Token = "0x4000066")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Transform CenterToInstantiate;

	[Token(Token = "0x4000067")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Transform Controller;

	[Token(Token = "0x4000068")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public GameObject Head;

	[Token(Token = "0x4000069")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x1183998", Offset = "0x1183998")]
	public SteamVR_Action_Boolean Move;

	[Token(Token = "0x400006A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public SteamVR_Action_Boolean Trigger;

	[Token(Token = "0x400006B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public bool enableMovement;

	[Token(Token = "0x400006C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	public Vector2 touchpad;

	[Token(Token = "0x400006D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	private bool physics;

	[Token(Token = "0x400006E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4D")]
	private bool automovement;

	[Token(Token = "0x6000084")]
	[Address(RVA = "0x1A3755C", Offset = "0x1A3755C", VA = "0x1A3755C")]
	private void Update()
	{
	}

	[Token(Token = "0x6000085")]
	[Address(RVA = "0x1A37E48", Offset = "0x1A37E48", VA = "0x1A37E48")]
	public void _AddObject(int index)
	{
	}

	[Token(Token = "0x6000086")]
	[Address(RVA = "0x1A37770", Offset = "0x1A37770", VA = "0x1A37770")]
	private void _VRGame()
	{
	}

	[Token(Token = "0x6000087")]
	[Address(RVA = "0x1A38150", Offset = "0x1A38150", VA = "0x1A38150")]
	public Examples_VR()
	{
	}
}
[Token(Token = "0x2000024")]
public class BufferedAudioStream
{
	[Token(Token = "0x400006F")]
	private const bool VerboseLogging = false;

	[Token(Token = "0x4000070")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private AudioSource audio;

	[Token(Token = "0x4000071")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private float[] audioBuffer;

	[Token(Token = "0x4000072")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private int writePos;

	[Token(Token = "0x4000073")]
	private const float bufferLengthSeconds = 0.25f;

	[Token(Token = "0x4000074")]
	private const int sampleRate = 48000;

	[Token(Token = "0x4000075")]
	private const int bufferSize = 12000;

	[Token(Token = "0x4000076")]
	private const float playbackDelayTimeSeconds = 0.05f;

	[Token(Token = "0x4000077")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	private float playbackDelayRemaining;

	[Token(Token = "0x4000078")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private float remainingBufferTime;

	[Token(Token = "0x6000088")]
	[Address(RVA = "0x1A277C8", Offset = "0x1A277C8", VA = "0x1A277C8")]
	public BufferedAudioStream(AudioSource audio)
	{
	}

	[Token(Token = "0x6000089")]
	[Address(RVA = "0x1A278D8", Offset = "0x1A278D8", VA = "0x1A278D8")]
	public void Update()
	{
	}

	[Token(Token = "0x600008A")]
	[Address(RVA = "0x1A27888", Offset = "0x1A27888", VA = "0x1A27888")]
	private void Stop()
	{
	}

	[Token(Token = "0x600008B")]
	[Address(RVA = "0x1A27AB0", Offset = "0x1A27AB0", VA = "0x1A27AB0")]
	public void AddData(float[] samples)
	{
	}
}
[Token(Token = "0x2000025")]
public class DebugUIBuilder : MonoBehaviour
{
	[Token(Token = "0x2000165")]
	public delegate void OnClick();

	[Token(Token = "0x2000166")]
	public delegate void OnToggleValueChange(Toggle t);

	[Token(Token = "0x2000167")]
	public delegate void OnSlider(float f);

	[Token(Token = "0x2000168")]
	public delegate bool ActiveUpdate();

	[Token(Token = "0x2000169")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1183410", Offset = "0x1183410")]
	private sealed class <>c__DisplayClass36_0
	{
		[Token(Token = "0x4000545")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public OnClick handler;

		[Token(Token = "0x6000979")]
		[Address(RVA = "0x1A31A34", Offset = "0x1A31A34", VA = "0x1A31A34")]
		public <>c__DisplayClass36_0()
		{
		}

		[Token(Token = "0x600097A")]
		[Address(RVA = "0x1A323D4", Offset = "0x1A323D4", VA = "0x1A323D4")]
		internal void <AddButton>b__0()
		{
		}
	}

	[Token(Token = "0x200016A")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1183420", Offset = "0x1183420")]
	private sealed class <>c__DisplayClass38_0
	{
		[Token(Token = "0x4000546")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public OnSlider onValueChanged;

		[Token(Token = "0x600097B")]
		[Address(RVA = "0x1A31CA8", Offset = "0x1A31CA8", VA = "0x1A31CA8")]
		public <>c__DisplayClass38_0()
		{
		}

		[Token(Token = "0x600097C")]
		[Address(RVA = "0x1A325F8", Offset = "0x1A325F8", VA = "0x1A325F8")]
		internal void <AddSlider>b__0(float f)
		{
		}
	}

	[Token(Token = "0x200016B")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1183430", Offset = "0x1183430")]
	private sealed class <>c__DisplayClass40_0
	{
		[Token(Token = "0x4000547")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public OnToggleValueChange onValueChanged;

		[Token(Token = "0x4000548")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Toggle t;

		[Token(Token = "0x600097D")]
		[Address(RVA = "0x1A31EC0", Offset = "0x1A31EC0", VA = "0x1A31EC0")]
		public <>c__DisplayClass40_0()
		{
		}

		[Token(Token = "0x600097E")]
		[Address(RVA = "0x1A32870", Offset = "0x1A32870", VA = "0x1A32870")]
		internal void <AddToggle>b__0(bool <p0>)
		{
		}
	}

	[Token(Token = "0x200016C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1183440", Offset = "0x1183440")]
	private sealed class <>c__DisplayClass41_0
	{
		[Token(Token = "0x4000549")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public OnToggleValueChange onValueChanged;

		[Token(Token = "0x400054A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Toggle t;

		[Token(Token = "0x600097F")]
		[Address(RVA = "0x1A32054", Offset = "0x1A32054", VA = "0x1A32054")]
		public <>c__DisplayClass41_0()
		{
		}

		[Token(Token = "0x6000980")]
		[Address(RVA = "0x1A32C24", Offset = "0x1A32C24", VA = "0x1A32C24")]
		internal void <AddToggle>b__0(bool <p0>)
		{
		}
	}

	[Token(Token = "0x200016D")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1183450", Offset = "0x1183450")]
	private sealed class <>c__DisplayClass42_0
	{
		[Token(Token = "0x400054B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public OnToggleValueChange handler;

		[Token(Token = "0x400054C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Toggle tb;

		[Token(Token = "0x6000981")]
		[Address(RVA = "0x1A322AC", Offset = "0x1A322AC", VA = "0x1A322AC")]
		public <>c__DisplayClass42_0()
		{
		}

		[Token(Token = "0x6000982")]
		[Address(RVA = "0x1A32C44", Offset = "0x1A32C44", VA = "0x1A32C44")]
		internal void <AddRadio>b__0(bool <p0>)
		{
		}
	}

	[Token(Token = "0x4000079")]
	public const int DEBUG_PANE_CENTER = 0;

	[Token(Token = "0x400007A")]
	public const int DEBUG_PANE_RIGHT = 1;

	[Token(Token = "0x400007B")]
	public const int DEBUG_PANE_LEFT = 2;

	[Token(Token = "0x400007C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private RectTransform buttonPrefab;

	[Token(Token = "0x400007D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private RectTransform labelPrefab;

	[Token(Token = "0x400007E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private RectTransform sliderPrefab;

	[Token(Token = "0x400007F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	private RectTransform dividerPrefab;

	[Token(Token = "0x4000080")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[SerializeField]
	private RectTransform togglePrefab;

	[Token(Token = "0x4000081")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[SerializeField]
	private RectTransform radioPrefab;

	[Token(Token = "0x4000082")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[SerializeField]
	private GameObject uiHelpersToInstantiate;

	[Token(Token = "0x4000083")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[SerializeField]
	private Transform[] targetContentPanels;

	[Token(Token = "0x4000084")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[SerializeField]
	private bool manuallyResizeContentPanels;

	[Token(Token = "0x4000085")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private bool[] reEnable;

	[Token(Token = "0x4000086")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	[SerializeField]
	private List<GameObject> toEnable;

	[Token(Token = "0x4000087")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	[SerializeField]
	private List<GameObject> toDisable;

	[Token(Token = "0x4000088")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static DebugUIBuilder instance;

	[Token(Token = "0x4000089")]
	private const float elementSpacing = 16f;

	[Token(Token = "0x400008A")]
	private const float marginH = 16f;

	[Token(Token = "0x400008B")]
	private const float marginV = 16f;

	[Token(Token = "0x400008C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private Vector2[] insertPositions;

	[Token(Token = "0x400008D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private List<RectTransform>[] insertedElements;

	[Token(Token = "0x400008E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private Vector3 menuOffset;

	[Token(Token = "0x400008F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private OVRCameraRig rig;

	[Token(Token = "0x4000090")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private Dictionary<string, ToggleGroup> radioGroups;

	[Token(Token = "0x4000091")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	private LaserPointer lp;

	[Token(Token = "0x4000092")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	private LineRenderer lr;

	[Token(Token = "0x4000093")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	public LaserPointer.LaserBeamBehavior laserBeamBehavior;

	[Token(Token = "0x600008C")]
	[Address(RVA = "0x1A309A0", Offset = "0x1A309A0", VA = "0x1A309A0")]
	public void Awake()
	{
	}

	[Token(Token = "0x600008D")]
	[Address(RVA = "0x1A30DE4", Offset = "0x1A30DE4", VA = "0x1A30DE4")]
	public void Show()
	{
	}

	[Token(Token = "0x600008E")]
	[Address(RVA = "0x1A313B0", Offset = "0x1A313B0", VA = "0x1A313B0")]
	public void Hide()
	{
	}

	[Token(Token = "0x600008F")]
	[Address(RVA = "0x1A3115C", Offset = "0x1A3115C", VA = "0x1A3115C")]
	private void Relayout()
	{
	}

	[Token(Token = "0x6000090")]
	[Address(RVA = "0x1A31558", Offset = "0x1A31558", VA = "0x1A31558")]
	private void AddRect(RectTransform r, int targetCanvas)
	{
	}

	[Token(Token = "0x6000091")]
	[Address(RVA = "0x1A3180C", Offset = "0x1A3180C", VA = "0x1A3180C")]
	public RectTransform AddButton(string label, OnClick handler, int targetCanvas = 0)
	{
		return null;
	}

	[Token(Token = "0x6000092")]
	[Address(RVA = "0x1A31A3C", Offset = "0x1A31A3C", VA = "0x1A31A3C")]
	public RectTransform AddLabel(string label, int targetCanvas = 0)
	{
		return null;
	}

	[Token(Token = "0x6000093")]
	[Address(RVA = "0x1A31B20", Offset = "0x1A31B20", VA = "0x1A31B20")]
	public RectTransform AddSlider(string label, float min, float max, OnSlider onValueChanged, bool wholeNumbersOnly = false, int targetCanvas = 0)
	{
		return null;
	}

	[Token(Token = "0x6000094")]
	[Address(RVA = "0x1A31CB0", Offset = "0x1A31CB0", VA = "0x1A31CB0")]
	public RectTransform AddDivider(int targetCanvas = 0)
	{
		return null;
	}

	[Token(Token = "0x6000095")]
	[Address(RVA = "0x1A31D4C", Offset = "0x1A31D4C", VA = "0x1A31D4C")]
	public RectTransform AddToggle(string label, OnToggleValueChange onValueChanged, int targetCanvas = 0)
	{
		return null;
	}

	[Token(Token = "0x6000096")]
	[Address(RVA = "0x1A31EC8", Offset = "0x1A31EC8", VA = "0x1A31EC8")]
	public RectTransform AddToggle(string label, OnToggleValueChange onValueChanged, bool defaultValue, int targetCanvas = 0)
	{
		return null;
	}

	[Token(Token = "0x6000097")]
	[Address(RVA = "0x1A3205C", Offset = "0x1A3205C", VA = "0x1A3205C")]
	public RectTransform AddRadio(string label, string group, OnToggleValueChange handler, int targetCanvas = 0)
	{
		return null;
	}

	[Token(Token = "0x6000098")]
	[Address(RVA = "0x1A322B4", Offset = "0x1A322B4", VA = "0x1A322B4")]
	public void ToggleLaserPointer(bool isOn)
	{
	}

	[Token(Token = "0x6000099")]
	[Address(RVA = "0x1A32364", Offset = "0x1A32364", VA = "0x1A32364")]
	public DebugUIBuilder()
	{
	}
}
[Token(Token = "0x2000026")]
public class HandedInputSelector : MonoBehaviour
{
	[Token(Token = "0x4000094")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private OVRCameraRig m_CameraRig;

	[Token(Token = "0x4000095")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private OVRInputModule m_InputModule;

	[Token(Token = "0x600009A")]
	[Address(RVA = "0x1A387D4", Offset = "0x1A387D4", VA = "0x1A387D4")]
	private void Start()
	{
	}

	[Token(Token = "0x600009B")]
	[Address(RVA = "0x1A3885C", Offset = "0x1A3885C", VA = "0x1A3885C")]
	private void Update()
	{
	}

	[Token(Token = "0x600009C")]
	[Address(RVA = "0x1A38924", Offset = "0x1A38924", VA = "0x1A38924")]
	private void SetActiveController(OVRInput.Controller c)
	{
	}

	[Token(Token = "0x600009D")]
	[Address(RVA = "0x1A38960", Offset = "0x1A38960", VA = "0x1A38960")]
	public HandedInputSelector()
	{
	}
}
[Token(Token = "0x2000027")]
public class LaserPointer : OVRCursor
{
	[Token(Token = "0x200016E")]
	public enum LaserBeamBehavior
	{
		[Token(Token = "0x400054E")]
		On,
		[Token(Token = "0x400054F")]
		Off,
		[Token(Token = "0x4000550")]
		OnWhenHitTarget
	}

	[Token(Token = "0x4000096")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject cursorVisual;

	[Token(Token = "0x4000097")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float maxLength;

	[Token(Token = "0x4000098")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	private LaserBeamBehavior _laserBeamBehavior;

	[Token(Token = "0x4000099")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private Vector3 _startPoint;

	[Token(Token = "0x400009A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	private Vector3 _forward;

	[Token(Token = "0x400009B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private Vector3 _endPoint;

	[Token(Token = "0x400009C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	private bool _hitTarget;

	[Token(Token = "0x400009D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private LineRenderer lineRenderer;

	[Token(Token = "0x17000007")]
	public LaserBeamBehavior laserBeamBehavior
	{
		[Token(Token = "0x600009F")]
		[Address(RVA = "0x1A38B44", Offset = "0x1A38B44", VA = "0x1A38B44")]
		get
		{
			return default(LaserBeamBehavior);
		}
		[Token(Token = "0x600009E")]
		[Address(RVA = "0x1A30DA0", Offset = "0x1A30DA0", VA = "0x1A30DA0")]
		set
		{
		}
	}

	[Token(Token = "0x60000A0")]
	[Address(RVA = "0x1A38B4C", Offset = "0x1A38B4C", VA = "0x1A38B4C")]
	private void Awake()
	{
	}

	[Token(Token = "0x60000A1")]
	[Address(RVA = "0x1A38BA4", Offset = "0x1A38BA4", VA = "0x1A38BA4")]
	private void Start()
	{
	}

	[Token(Token = "0x60000A2")]
	[Address(RVA = "0x1A38C38", Offset = "0x1A38C38", VA = "0x1A38C38", Slot = "5")]
	public override void SetCursorStartDest(Vector3 start, Vector3 dest, Vector3 normal)
	{
	}

	[Token(Token = "0x60000A3")]
	[Address(RVA = "0x1A38C54", Offset = "0x1A38C54", VA = "0x1A38C54", Slot = "4")]
	public override void SetCursorRay(Transform t)
	{
	}

	[Token(Token = "0x60000A4")]
	[Address(RVA = "0x1A38CA8", Offset = "0x1A38CA8", VA = "0x1A38CA8")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x60000A5")]
	[Address(RVA = "0x1A38F04", Offset = "0x1A38F04", VA = "0x1A38F04")]
	private void UpdateLaserBeam(Vector3 start, Vector3 end)
	{
	}

	[Token(Token = "0x60000A6")]
	[Address(RVA = "0x1A39018", Offset = "0x1A39018", VA = "0x1A39018")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x60000A7")]
	[Address(RVA = "0x1A390AC", Offset = "0x1A390AC", VA = "0x1A390AC")]
	public LaserPointer()
	{
	}
}
[Token(Token = "0x2000028")]
public class BoundsLockedObject : MonoBehaviour
{
	[Token(Token = "0x400009E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private Vector3 m_initialOffset;

	[Token(Token = "0x400009F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public OVRCameraRig m_playerOrigin;

	[Token(Token = "0x40000A0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public GuardianBoundaryEnforcer m_enforcer;

	[Token(Token = "0x40000A1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private Bounds? m_bounds;

	[Token(Token = "0x60000A8")]
	[Address(RVA = "0x1A27074", Offset = "0x1A27074", VA = "0x1A27074")]
	private void Start()
	{
	}

	[Token(Token = "0x60000A9")]
	[Address(RVA = "0x1A27320", Offset = "0x1A27320", VA = "0x1A27320")]
	private void RefreshDisplay()
	{
	}

	[Token(Token = "0x60000AA")]
	[Address(RVA = "0x1A277C0", Offset = "0x1A277C0", VA = "0x1A277C0")]
	public BoundsLockedObject()
	{
	}
}
[Token(Token = "0x2000029")]
public class GuardianBoundaryDisplay : MonoBehaviour
{
	[Token(Token = "0x40000A2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GuardianBoundaryEnforcer m_enforcer;

	[Token(Token = "0x40000A3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public OVRBoundary.BoundaryType m_boundaryType;

	[Token(Token = "0x40000A4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public GameObject m_errorDisplay;

	[Token(Token = "0x60000AB")]
	[Address(RVA = "0x1A38158", Offset = "0x1A38158", VA = "0x1A38158")]
	private void Start()
	{
	}

	[Token(Token = "0x60000AC")]
	[Address(RVA = "0x1A381E8", Offset = "0x1A381E8", VA = "0x1A381E8")]
	private void RefreshDisplay()
	{
	}

	[Token(Token = "0x60000AD")]
	[Address(RVA = "0x1A38438", Offset = "0x1A38438", VA = "0x1A38438")]
	public GuardianBoundaryDisplay()
	{
	}
}
[Token(Token = "0x200002A")]
public class GuardianBoundaryEnforcer : MonoBehaviour
{
	[Token(Token = "0x40000A6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public bool m_AllowRecenter;

	[Token(Token = "0x40000A7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public OVRCameraRig m_mainCamera;

	[Token(Token = "0x40000A8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Quaternion m_originalTrackerOrientation;

	[Token(Token = "0x40000A9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private int m_framecount;

	[Token(Token = "0x40000AA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	private Quaternion m_orientToOriginalForward;

	[Token(Token = "0x17000008")]
	public Quaternion OrientToOriginalForward
	{
		[Token(Token = "0x60000B0")]
		[Address(RVA = "0x1A384E4", Offset = "0x1A384E4", VA = "0x1A384E4")]
		get
		{
			return default(Quaternion);
		}
	}

	[Token(Token = "0x14000001")]
	public event Action TrackingChanged
	{
		[Token(Token = "0x60000AE")]
		[Address(RVA = "0x1A2727C", Offset = "0x1A2727C", VA = "0x1A2727C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1186618", Offset = "0x1186618")]
		add
		{
		}
		[Token(Token = "0x60000AF")]
		[Address(RVA = "0x1A38440", Offset = "0x1A38440", VA = "0x1A38440")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1186628", Offset = "0x1186628")]
		remove
		{
		}
	}

	[Token(Token = "0x60000B1")]
	[Address(RVA = "0x1A384F0", Offset = "0x1A384F0", VA = "0x1A384F0")]
	private void Start()
	{
	}

	[Token(Token = "0x60000B2")]
	[Address(RVA = "0x1A38648", Offset = "0x1A38648", VA = "0x1A38648")]
	private void Update()
	{
	}

	[Token(Token = "0x60000B3")]
	[Address(RVA = "0x1A387BC", Offset = "0x1A387BC", VA = "0x1A387BC")]
	private void Recentered()
	{
	}

	[Token(Token = "0x60000B4")]
	[Address(RVA = "0x1A387C4", Offset = "0x1A387C4", VA = "0x1A387C4")]
	public GuardianBoundaryEnforcer()
	{
	}
}
namespace Oculus.Platform
{
	[Token(Token = "0x200002B")]
	public class AbuseReportOptions
	{
		[Token(Token = "0x40000AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private IntPtr Handle;

		[Token(Token = "0x60000B5")]
		[Address(RVA = "0x181C2D4", Offset = "0x181C2D4", VA = "0x181C2D4")]
		public AbuseReportOptions()
		{
		}

		[Token(Token = "0x60000B6")]
		[Address(RVA = "0x181C3BC", Offset = "0x181C3BC", VA = "0x181C3BC")]
		public void SetPreventPeopleChooser(bool value)
		{
		}

		[Token(Token = "0x60000B7")]
		[Address(RVA = "0x181C4C4", Offset = "0x181C4C4", VA = "0x181C4C4")]
		public void SetReportType(AbuseReportType value)
		{
		}

		[Token(Token = "0x60000B8")]
		[Address(RVA = "0x181C5CC", Offset = "0x181C5CC", VA = "0x181C5CC")]
		public static explicit operator IntPtr(AbuseReportOptions options)
		{
			return default(IntPtr);
		}

		[Token(Token = "0x60000B9")]
		[Address(RVA = "0x181C61C", Offset = "0x181C61C", VA = "0x181C61C", Slot = "1")]
		~AbuseReportOptions()
		{
		}
	}
	[Token(Token = "0x200002C")]
	public enum AbuseReportType
	{
		[Token(Token = "0x40000AD")]
		[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x1183A68", Offset = "0x1183A68")]
		Unknown,
		[Token(Token = "0x40000AE")]
		[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x1183AA0", Offset = "0x1183AA0")]
		Object,
		[Token(Token = "0x40000AF")]
		[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x1183AD8", Offset = "0x1183AD8")]
		User
	}
	[Token(Token = "0x200002D")]
	public enum AchievementType
	{
		[Token(Token = "0x40000B1")]
		[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x1183B10", Offset = "0x1183B10")]
		Unknown,
		[Token(Token = "0x40000B2")]
		[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x1183B48", Offset = "0x1183B48")]
		Simple,
		[Token(Token = "0x40000B3")]
		[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x1183B80", Offset = "0x1183B80")]
		Bitfield,
		[Token(Token = "0x40000B4")]
		[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x1183BB8", Offset = "0x1183BB8")]
		Count
	}
	[Token(Token = "0x200002E")]
	public class AndroidPlatform
	{
		[Token(Token = "0x60000BA")]
		[Address(RVA = "0x181D86C", Offset = "0x181D86C", VA = "0x181D86C")]
		public bool Initialize(string appId)
		{
			return default(bool);
		}

		[Token(Token = "0x60000BB")]
		[Address(RVA = "0x181D9B8", Offset = "0x181D9B8", VA = "0x181D9B8")]
		public Request<PlatformInitialize> AsyncInitialize(string appId)
		{
			return null;
		}

		[Token(Token = "0x60000BC")]
		[Address(RVA = "0x181DB38", Offset = "0x181DB38", VA = "0x181DB38")]
		public AndroidPlatform()
		{
		}
	}
	[Token(Token = "0x200002F")]
	public class ApplicationOptions
	{
		[Token(Token = "0x40000B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private IntPtr Handle;

		[Token(Token = "0x60000BD")]
		[Address(RVA = "0x181DFE8", Offset = "0x181DFE8", VA = "0x181DFE8")]
		public ApplicationOptions()
		{
		}

		[Token(Token = "0x60000BE")]
		[Address(RVA = "0x181E0D0", Offset = "0x181E0D0", VA = "0x181E0D0")]
		public void SetDeeplinkMessage(string value)
		{
		}

		[Token(Token = "0x60000BF")]
		[Address(RVA = "0x181DE08", Offset = "0x181DE08", VA = "0x181DE08")]
		public static explicit operator IntPtr(ApplicationOptions options)
		{
			return default(IntPtr);
		}

		[Token(Token = "0x60000C0")]
		[Address(RVA = "0x181E1F4", Offset = "0x181E1F4", VA = "0x181E1F4", Slot = "1")]
		~ApplicationOptions()
		{
		}
	}
	[Token(Token = "0x2000030")]
	public class CAPI
	{
		[Token(Token = "0x200016F")]
		public struct ovrKeyValuePair
		{
			[Token(Token = "0x4000551")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public string key_;

			[Token(Token = "0x4000552")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private KeyValuePairType valueType_;

			[Token(Token = "0x4000553")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string stringValue_;

			[Token(Token = "0x4000554")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public int intValue_;

			[Token(Token = "0x4000555")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public double doubleValue_;

			[Token(Token = "0x6000983")]
			[Address(RVA = "0x132C1B8", Offset = "0x132C1B8", VA = "0x132C1B8")]
			public ovrKeyValuePair(string key, string value)
			{
			}

			[Token(Token = "0x6000984")]
			[Address(RVA = "0x132C1D0", Offset = "0x132C1D0", VA = "0x132C1D0")]
			public ovrKeyValuePair(string key, int value)
			{
			}

			[Token(Token = "0x6000985")]
			[Address(RVA = "0x132C1EC", Offset = "0x132C1EC", VA = "0x132C1EC")]
			public ovrKeyValuePair(string key, double value)
			{
			}
		}

		[Token(Token = "0x2000170")]
		public struct ovrMatchmakingCriterion
		{
			[Token(Token = "0x4000556")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public string key_;

			[Token(Token = "0x4000557")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public MatchmakingCriterionImportance importance_;

			[Token(Token = "0x4000558")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public IntPtr parameterArray;

			[Token(Token = "0x4000559")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public uint parameterArrayCount;

			[Token(Token = "0x6000986")]
			[Address(RVA = "0x132C2B8", Offset = "0x132C2B8", VA = "0x132C2B8")]
			public ovrMatchmakingCriterion(string key, MatchmakingCriterionImportance importance)
			{
			}
		}

		[Token(Token = "0x2000171")]
		public struct ovrMatchmakingCustomQueryData
		{
			[Token(Token = "0x400055A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public IntPtr dataArray;

			[Token(Token = "0x400055B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public uint dataArrayCount;

			[Token(Token = "0x400055C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public IntPtr criterionArray;

			[Token(Token = "0x400055D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public uint criterionArrayCount;
		}

		[Token(Token = "0x2000172")]
		public struct OculusInitParams
		{
			[Token(Token = "0x400055E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int sType;

			[Token(Token = "0x400055F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public string email;

			[Token(Token = "0x4000560")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string password;

			[Token(Token = "0x4000561")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public ulong appId;

			[Token(Token = "0x4000562")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public string uriPrefixOverride;
		}

		[Token(Token = "0x2000173")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x1183460", Offset = "0x1183460")]
		public delegate void FilterCallback([In][Out] short[] pcmData, UIntPtr pcmDataLength, int frequency, int numChannels);

		[Token(Token = "0x40000B6")]
		public const string DLL_NAME = "ovrplatformloader";

		[Token(Token = "0x40000B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static UTF8Encoding nativeStringEncoding;

		[Token(Token = "0x40000B8")]
		public const int VoipFilterBufferSize = 480;

		[Token(Token = "0x60000C1")]
		[Address(RVA = "0x181F8DC", Offset = "0x181F8DC", VA = "0x181F8DC")]
		public static IntPtr ArrayOfStructsToIntPtr(Array ar)
		{
			return default(IntPtr);
		}

		[Token(Token = "0x60000C2")]
		[Address(RVA = "0x181FA9C", Offset = "0x181FA9C", VA = "0x181FA9C")]
		public static ovrKeyValuePair[] DictionaryToOVRKeyValuePairs(Dictionary<string, object> dict)
		{
			return null;
		}

		[Token(Token = "0x60000C3")]
		[Address(RVA = "0x181FF48", Offset = "0x181FF48", VA = "0x181FF48")]
		public static byte[] IntPtrToByteArray(IntPtr data, ulong size)
		{
			return null;
		}

		[Token(Token = "0x60000C4")]
		[Address(RVA = "0x1820004", Offset = "0x1820004", VA = "0x1820004")]
		public static Dictionary<string, string> DataStoreFromNative(IntPtr pointer)
		{
			return null;
		}

		[Token(Token = "0x60000C5")]
		[Address(RVA = "0x182030C", Offset = "0x182030C", VA = "0x182030C")]
		public static string StringFromNative(IntPtr pointer)
		{
			return null;
		}

		[Token(Token = "0x60000C6")]
		[Address(RVA = "0x1820424", Offset = "0x1820424", VA = "0x1820424")]
		public static int GetNativeStringLengthNotIncludingNullTerminator(IntPtr pointer)
		{
			return default(int);
		}

		[Token(Token = "0x60000C7")]
		[Address(RVA = "0x18204B0", Offset = "0x18204B0", VA = "0x18204B0")]
		public static DateTime DateTimeFromNative(ulong seconds_since_the_one_true_epoch)
		{
			return default(DateTime);
		}

		[Token(Token = "0x60000C8")]
		[Address(RVA = "0x1820520", Offset = "0x1820520", VA = "0x1820520")]
		public static byte[] BlobFromNative(uint size, IntPtr pointer)
		{
			return null;
		}

		[Token(Token = "0x60000C9")]
		[Address(RVA = "0x1820604", Offset = "0x1820604", VA = "0x1820604")]
		public static byte[] FiledataFromNative(uint size, IntPtr pointer)
		{
			return null;
		}

		[Token(Token = "0x60000CA")]
		[Address(RVA = "0x18206A8", Offset = "0x18206A8", VA = "0x18206A8")]
		public static IntPtr StringToNative(string s)
		{
			return default(IntPtr);
		}

		[PreserveSig]
		[Token(Token = "0x60000CB")]
		[Address(RVA = "0x181D91C", Offset = "0x181D91C", VA = "0x181D91C")]
		public static extern bool ovr_UnityInitWrapper(string appId);

		[PreserveSig]
		[Token(Token = "0x60000CC")]
		[Address(RVA = "0x1820818", Offset = "0x1820818", VA = "0x1820818")]
		public static extern void ovr_UnityInitGlobals(IntPtr loggingCB);

		[PreserveSig]
		[Token(Token = "0x60000CD")]
		[Address(RVA = "0x181DAA0", Offset = "0x181DAA0", VA = "0x181DAA0")]
		public static extern ulong ovr_UnityInitWrapperAsynchronous(string appId);

		[PreserveSig]
		[Token(Token = "0x60000CE")]
		[Address(RVA = "0x1820898", Offset = "0x1820898", VA = "0x1820898")]
		public static extern bool ovr_UnityInitWrapperStandalone(string accessToken, IntPtr loggingCB);

		[PreserveSig]
		[Token(Token = "0x60000CF")]
		[Address(RVA = "0x1820944", Offset = "0x1820944", VA = "0x1820944")]
		public static extern ulong ovr_Platform_InitializeStandaloneOculus(ref OculusInitParams init);

		[PreserveSig]
		[Token(Token = "0x60000D0")]
		[Address(RVA = "0x1820A1C", Offset = "0x1820A1C", VA = "0x1820A1C")]
		public static extern ulong ovr_PlatformInitializeWithAccessToken(ulong appId, string accessToken);

		[PreserveSig]
		[Token(Token = "0x60000D1")]
		[Address(RVA = "0x1820AC8", Offset = "0x1820AC8", VA = "0x1820AC8")]
		public static extern bool ovr_UnityInitWrapperWindows(string appId, IntPtr loggingCB);

		[PreserveSig]
		[Token(Token = "0x60000D2")]
		[Address(RVA = "0x1820B74", Offset = "0x1820B74", VA = "0x1820B74")]
		public static extern ulong ovr_UnityInitWrapperWindowsAsynchronous(string appId, IntPtr loggingCB);

		[PreserveSig]
		[Token(Token = "0x60000D3")]
		[Address(RVA = "0x1820C1C", Offset = "0x1820C1C", VA = "0x1820C1C")]
		public static extern bool ovr_SetDeveloperAccessToken(string accessToken);

		[Token(Token = "0x60000D4")]
		[Address(RVA = "0x1820CB8", Offset = "0x1820CB8", VA = "0x1820CB8")]
		public static string ovr_GetLoggedInUserLocale()
		{
			return null;
		}

		[PreserveSig]
		[Token(Token = "0x60000D5")]
		[Address(RVA = "0x1820D18", Offset = "0x1820D18", VA = "0x1820D18")]
		private static extern IntPtr ovr_GetLoggedInUserLocale_Native();

		[PreserveSig]
		[Token(Token = "0x60000D6")]
		[Address(RVA = "0x1820D8C", Offset = "0x1820D8C", VA = "0x1820D8C")]
		public static extern IntPtr ovr_PopMessage();

		[PreserveSig]
		[Token(Token = "0x60000D7")]
		[Address(RVA = "0x1820E00", Offset = "0x1820E00", VA = "0x1820E00")]
		public static extern void ovr_FreeMessage(IntPtr message);

		[PreserveSig]
		[Token(Token = "0x60000D8")]
		[Address(RVA = "0x1820E80", Offset = "0x1820E80", VA = "0x1820E80")]
		public static extern uint ovr_NetworkingPeer_GetSendPolicy(IntPtr networkingPeer);

		[PreserveSig]
		[Token(Token = "0x60000D9")]
		[Address(RVA = "0x1820F00", Offset = "0x1820F00", VA = "0x1820F00")]
		public static extern IntPtr ovr_Voip_CreateEncoder();

		[PreserveSig]
		[Token(Token = "0x60000DA")]
		[Address(RVA = "0x1820F74", Offset = "0x1820F74", VA = "0x1820F74")]
		public static extern void ovr_Voip_DestroyEncoder(IntPtr encoder);

		[PreserveSig]
		[Token(Token = "0x60000DB")]
		[Address(RVA = "0x1820FF4", Offset = "0x1820FF4", VA = "0x1820FF4")]
		public static extern IntPtr ovr_Voip_CreateDecoder();

		[PreserveSig]
		[Token(Token = "0x60000DC")]
		[Address(RVA = "0x1821068", Offset = "0x1821068", VA = "0x1821068")]
		public static extern void ovr_Voip_DestroyDecoder(IntPtr decoder);

		[PreserveSig]
		[Token(Token = "0x60000DD")]
		[Address(RVA = "0x18210E8", Offset = "0x18210E8", VA = "0x18210E8")]
		public static extern void ovr_VoipDecoder_Decode(IntPtr obj, byte[] compressedData, ulong compressedSize);

		[PreserveSig]
		[Token(Token = "0x60000DE")]
		[Address(RVA = "0x1821188", Offset = "0x1821188", VA = "0x1821188")]
		public static extern IntPtr ovr_Microphone_Create();

		[PreserveSig]
		[Token(Token = "0x60000DF")]
		[Address(RVA = "0x18211FC", Offset = "0x18211FC", VA = "0x18211FC")]
		public static extern void ovr_Microphone_Destroy(IntPtr obj);

		[PreserveSig]
		[Token(Token = "0x60000E0")]
		[Address(RVA = "0x182127C", Offset = "0x182127C", VA = "0x182127C")]
		public static extern void ovr_Voip_SetSystemVoipPassthrough(bool passthrough);

		[PreserveSig]
		[Token(Token = "0x60000E1")]
		[Address(RVA = "0x18212FC", Offset = "0x18212FC", VA = "0x18212FC")]
		public static extern void ovr_Voip_SetSystemVoipMicrophoneMuted(VoipMuteState muted);

		[PreserveSig]
		[Token(Token = "0x60000E2")]
		[Address(RVA = "0x182137C", Offset = "0x182137C", VA = "0x182137C")]
		public static extern void ovr_UnityResetTestPlatform();

		[PreserveSig]
		[Token(Token = "0x60000E3")]
		[Address(RVA = "0x181D64C", Offset = "0x181D64C", VA = "0x181D64C")]
		public static extern ulong ovr_HTTP_GetWithMessageType(string url, int messageType);

		[PreserveSig]
		[Token(Token = "0x60000E4")]
		[Address(RVA = "0x18213EC", Offset = "0x18213EC", VA = "0x18213EC")]
		public static extern void ovr_CrashApplication();

		[PreserveSig]
		[Token(Token = "0x60000E5")]
		[Address(RVA = "0x182145C", Offset = "0x182145C", VA = "0x182145C")]
		public static extern void ovr_Voip_SetMicrophoneFilterCallback(FilterCallback cb);

		[PreserveSig]
		[Token(Token = "0x60000E6")]
		[Address(RVA = "0x18214E0", Offset = "0x18214E0", VA = "0x18214E0")]
		public static extern void ovr_Voip_SetMicrophoneFilterCallbackWithFixedSizeBuffer(FilterCallback cb, UIntPtr bufferSizeElements);

		[Token(Token = "0x60000E7")]
		[Address(RVA = "0x1821574", Offset = "0x1821574", VA = "0x1821574")]
		public static void LogNewEvent(string eventName, Dictionary<string, string> values)
		{
		}

		[PreserveSig]
		[Token(Token = "0x60000E8")]
		[Address(RVA = "0x1821878", Offset = "0x1821878", VA = "0x1821878")]
		public static extern void ovr_Log_NewEvent(IntPtr eventName, IntPtr[] values, UIntPtr length);

		[PreserveSig]
		[Token(Token = "0x60000E9")]
		[Address(RVA = "0x181DF74", Offset = "0x181DF74", VA = "0x181DF74")]
		public static extern IntPtr ovr_ApplicationLifecycle_GetLaunchDetails();

		[Token(Token = "0x60000EA")]
		[Address(RVA = "0x1821918", Offset = "0x1821918", VA = "0x1821918")]
		public static ulong ovr_HTTP_StartTransfer(string url, ovrKeyValuePair[] headers)
		{
			return default(ulong);
		}

		[PreserveSig]
		[Token(Token = "0x60000EB")]
		[Address(RVA = "0x1821A0C", Offset = "0x1821A0C", VA = "0x1821A0C")]
		private static extern ulong ovr_HTTP_StartTransfer_Native(IntPtr url, ovrKeyValuePair[] headers, UIntPtr numItems);

		[PreserveSig]
		[Token(Token = "0x60000EC")]
		[Address(RVA = "0x1821B68", Offset = "0x1821B68", VA = "0x1821B68")]
		public static extern bool ovr_HTTP_Write(ulong transferId, byte[] bytes, UIntPtr length);

		[PreserveSig]
		[Token(Token = "0x60000ED")]
		[Address(RVA = "0x1821C10", Offset = "0x1821C10", VA = "0x1821C10")]
		public static extern void ovr_HTTP_WriteEOM(ulong transferId);

		[Token(Token = "0x60000EE")]
		[Address(RVA = "0x1821C8C", Offset = "0x1821C8C", VA = "0x1821C8C")]
		public static string ovr_Message_GetStringForJavascript(IntPtr message)
		{
			return null;
		}

		[PreserveSig]
		[Token(Token = "0x60000EF")]
		[Address(RVA = "0x1821CF4", Offset = "0x1821CF4", VA = "0x1821CF4")]
		private static extern IntPtr ovr_Message_GetStringForJavascript_Native(IntPtr message);

		[PreserveSig]
		[Token(Token = "0x60000F0")]
		[Address(RVA = "0x1821D74", Offset = "0x1821D74", VA = "0x1821D74")]
		public static extern void ovr_Net_Accept(ulong peerID);

		[PreserveSig]
		[Token(Token = "0x60000F1")]
		[Address(RVA = "0x1821DF4", Offset = "0x1821DF4", VA = "0x1821DF4")]
		public static extern bool ovr_Net_AcceptForCurrentRoom();

		[PreserveSig]
		[Token(Token = "0x60000F2")]
		[Address(RVA = "0x1821E70", Offset = "0x1821E70", VA = "0x1821E70")]
		public static extern void ovr_Net_Close(ulong peerID);

		[PreserveSig]
		[Token(Token = "0x60000F3")]
		[Address(RVA = "0x1821EF0", Offset = "0x1821EF0", VA = "0x1821EF0")]
		public static extern void ovr_Net_CloseForCurrentRoom();

		[PreserveSig]
		[Token(Token = "0x60000F4")]
		[Address(RVA = "0x1821F60", Offset = "0x1821F60", VA = "0x1821F60")]
		public static extern void ovr_Net_Connect(ulong peerID);

		[PreserveSig]
		[Token(Token = "0x60000F5")]
		[Address(RVA = "0x1821FE0", Offset = "0x1821FE0", VA = "0x1821FE0")]
		public static extern bool ovr_Net_IsConnected(ulong peerID);

		[PreserveSig]
		[Token(Token = "0x60000F6")]
		[Address(RVA = "0x1822068", Offset = "0x1822068", VA = "0x1822068")]
		public static extern ulong ovr_Net_Ping(ulong peerID);

		[PreserveSig]
		[Token(Token = "0x60000F7")]
		[Address(RVA = "0x18220E8", Offset = "0x18220E8", VA = "0x18220E8")]
		public static extern IntPtr ovr_Net_ReadPacket();

		[PreserveSig]
		[Token(Token = "0x60000F8")]
		[Address(RVA = "0x182215C", Offset = "0x182215C", VA = "0x182215C")]
		public static extern bool ovr_Net_SendPacket(ulong userID, UIntPtr length, byte[] bytes, SendPolicy policy);

		[PreserveSig]
		[Token(Token = "0x60000F9")]
		[Address(RVA = "0x1822214", Offset = "0x1822214", VA = "0x1822214")]
		public static extern bool ovr_Net_SendPacketToCurrentRoom(UIntPtr length, byte[] bytes, SendPolicy policy);

		[PreserveSig]
		[Token(Token = "0x60000FA")]
		[Address(RVA = "0x18222BC", Offset = "0x18222BC", VA = "0x18222BC")]
		public static extern int ovr_Party_PluginGetSharedMemHandle();

		[PreserveSig]
		[Token(Token = "0x60000FB")]
		[Address(RVA = "0x1822330", Offset = "0x1822330", VA = "0x1822330")]
		public static extern VoipMuteState ovr_Party_PluginGetVoipMicrophoneMuted();

		[PreserveSig]
		[Token(Token = "0x60000FC")]
		[Address(RVA = "0x18223A4", Offset = "0x18223A4", VA = "0x18223A4")]
		public static extern bool ovr_Party_PluginGetVoipPassthrough();

		[PreserveSig]
		[Token(Token = "0x60000FD")]
		[Address(RVA = "0x1822420", Offset = "0x1822420", VA = "0x1822420")]
		public static extern SystemVoipStatus ovr_Party_PluginGetVoipStatus();

		[PreserveSig]
		[Token(Token = "0x60000FE")]
		[Address(RVA = "0x1822494", Offset = "0x1822494", VA = "0x1822494")]
		public static extern void ovr_Voip_Accept(ulong userID);

		[PreserveSig]
		[Token(Token = "0x60000FF")]
		[Address(RVA = "0x1822514", Offset = "0x1822514", VA = "0x1822514")]
		public static extern VoipDtxState ovr_Voip_GetIsConnectionUsingDtx(ulong peerID);

		[PreserveSig]
		[Token(Token = "0x6000100")]
		[Address(RVA = "0x1822594", Offset = "0x1822594", VA = "0x1822594")]
		public static extern VoipBitrate ovr_Voip_GetLocalBitrate(ulong peerID);

		[PreserveSig]
		[Token(Token = "0x6000101")]
		[Address(RVA = "0x1822614", Offset = "0x1822614", VA = "0x1822614")]
		public static extern UIntPtr ovr_Voip_GetOutputBufferMaxSize();

		[PreserveSig]
		[Token(Token = "0x6000102")]
		[Address(RVA = "0x1822688", Offset = "0x1822688", VA = "0x1822688")]
		public static extern UIntPtr ovr_Voip_GetPCM(ulong senderID, short[] outputBuffer, UIntPtr outputBufferNumElements);

		[PreserveSig]
		[Token(Token = "0x6000103")]
		[Address(RVA = "0x1822728", Offset = "0x1822728", VA = "0x1822728")]
		public static extern UIntPtr ovr_Voip_GetPCMFloat(ulong senderID, float[] outputBuffer, UIntPtr outputBufferNumElements);

		[PreserveSig]
		[Token(Token = "0x6000104")]
		[Address(RVA = "0x18227C8", Offset = "0x18227C8", VA = "0x18227C8")]
		public static extern UIntPtr ovr_Voip_GetPCMSize(ulong senderID);

		[PreserveSig]
		[Token(Token = "0x6000105")]
		[Address(RVA = "0x1822848", Offset = "0x1822848", VA = "0x1822848")]
		public static extern UIntPtr ovr_Voip_GetPCMWithTimestamp(ulong senderID, short[] outputBuffer, UIntPtr outputBufferNumElements, uint[] timestamp);

		[PreserveSig]
		[Token(Token = "0x6000106")]
		[Address(RVA = "0x1822900", Offset = "0x1822900", VA = "0x1822900")]
		public static extern UIntPtr ovr_Voip_GetPCMWithTimestampFloat(ulong senderID, float[] outputBuffer, UIntPtr outputBufferNumElements, uint[] timestamp);

		[PreserveSig]
		[Token(Token = "0x6000107")]
		[Address(RVA = "0x18229B8", Offset = "0x18229B8", VA = "0x18229B8")]
		public static extern VoipBitrate ovr_Voip_GetRemoteBitrate(ulong peerID);

		[PreserveSig]
		[Token(Token = "0x6000108")]
		[Address(RVA = "0x1822A38", Offset = "0x1822A38", VA = "0x1822A38")]
		public static extern uint ovr_Voip_GetSyncTimestamp(ulong userID);

		[PreserveSig]
		[Token(Token = "0x6000109")]
		[Address(RVA = "0x1822AB8", Offset = "0x1822AB8", VA = "0x1822AB8")]
		public static extern long ovr_Voip_GetSyncTimestampDifference(uint lhs, uint rhs);

		[PreserveSig]
		[Token(Token = "0x600010A")]
		[Address(RVA = "0x1822B48", Offset = "0x1822B48", VA = "0x1822B48")]
		public static extern VoipMuteState ovr_Voip_GetSystemVoipMicrophoneMuted();

		[PreserveSig]
		[Token(Token = "0x600010B")]
		[Address(RVA = "0x1822BBC", Offset = "0x1822BBC", VA = "0x1822BBC")]
		public static extern SystemVoipStatus ovr_Voip_GetSystemVoipStatus();

		[PreserveSig]
		[Token(Token = "0x600010C")]
		[Address(RVA = "0x1822C30", Offset = "0x1822C30", VA = "0x1822C30")]
		public static extern void ovr_Voip_SetMicrophoneMuted(VoipMuteState state);

		[PreserveSig]
		[Token(Token = "0x600010D")]
		[Address(RVA = "0x1822CB0", Offset = "0x1822CB0", VA = "0x1822CB0")]
		public static extern void ovr_Voip_SetNewConnectionOptions(IntPtr voipOptions);

		[PreserveSig]
		[Token(Token = "0x600010E")]
		[Address(RVA = "0x1822D30", Offset = "0x1822D30", VA = "0x1822D30")]
		public static extern void ovr_Voip_SetOutputSampleRate(VoipSampleRate rate);

		[PreserveSig]
		[Token(Token = "0x600010F")]
		[Address(RVA = "0x1822DB0", Offset = "0x1822DB0", VA = "0x1822DB0")]
		public static extern void ovr_Voip_Start(ulong userID);

		[PreserveSig]
		[Token(Token = "0x6000110")]
		[Address(RVA = "0x1822E30", Offset = "0x1822E30", VA = "0x1822E30")]
		public static extern void ovr_Voip_Stop(ulong userID);

		[Token(Token = "0x6000111")]
		[Address(RVA = "0x181C870", Offset = "0x181C870", VA = "0x181C870")]
		public static ulong ovr_Achievements_AddCount(string name, ulong count)
		{
			return default(ulong);
		}

		[PreserveSig]
		[Token(Token = "0x6000112")]
		[Address(RVA = "0x1822EB0", Offset = "0x1822EB0", VA = "0x1822EB0")]
		private static extern ulong ovr_Achievements_AddCount_Native(IntPtr name, ulong count);

		[Token(Token = "0x6000113")]
		[Address(RVA = "0x181CA48", Offset = "0x181CA48", VA = "0x181CA48")]
		public static ulong ovr_Achievements_AddFields(string name, string fields)
		{
			return default(ulong);
		}

		[PreserveSig]
		[Token(Token = "0x6000114")]
		[Address(RVA = "0x1822F40", Offset = "0x1822F40", VA = "0x1822F40")]
		private static extern ulong ovr_Achievements_AddFields_Native(IntPtr name, IntPtr fields);

		[PreserveSig]
		[Token(Token = "0x6000115")]
		[Address(RVA = "0x181CC24", Offset = "0x181CC24", VA = "0x181CC24")]
		public static extern ulong ovr_Achievements_GetAllDefinitions();

		[PreserveSig]
		[Token(Token = "0x6000116")]
		[Address(RVA = "0x181CDA0", Offset = "0x181CDA0", VA = "0x181CDA0")]
		public static extern ulong ovr_Achievements_GetAllProgress();

		[PreserveSig]
		[Token(Token = "0x6000117")]
		[Address(RVA = "0x181CF40", Offset = "0x181CF40", VA = "0x181CF40")]
		public static extern ulong ovr_Achievements_GetDefinitionsByName(string[] names, int count);

		[PreserveSig]
		[Token(Token = "0x6000118")]
		[Address(RVA = "0x181D1C0", Offset = "0x181D1C0", VA = "0x181D1C0")]
		public static extern ulong ovr_Achievements_GetProgressByName(string[] names, int count);

		[Token(Token = "0x6000119")]
		[Address(RVA = "0x181D42C", Offset = "0x181D42C", VA = "0x181D42C")]
		public static ulong ovr_Achievements_Unlock(string name)
		{
			return default(ulong);
		}

		[PreserveSig]
		[Token(Token = "0x600011A")]
		[Address(RVA = "0x1822FD0", Offset = "0x1822FD0", VA = "0x1822FD0")]
		private static extern ulong ovr_Achievements_Unlock_Native(IntPtr name);

		[PreserveSig]
		[Token(Token = "0x600011B")]
		[Address(RVA = "0x1823050", Offset = "0x1823050", VA = "0x1823050")]
		public static extern ulong ovr_Application_ExecuteCoordinatedLaunch(ulong appID, ulong roomID);

		[PreserveSig]
		[Token(Token = "0x600011C")]
		[Address(RVA = "0x18230E0", Offset = "0x18230E0", VA = "0x18230E0")]
		public static extern ulong ovr_Application_GetInstalledApplications();

		[PreserveSig]
		[Token(Token = "0x600011D")]
		[Address(RVA = "0x181DC48", Offset = "0x181DC48", VA = "0x181DC48")]
		public static extern ulong ovr_Application_GetVersion();

		[PreserveSig]
		[Token(Token = "0x600011E")]
		[Address(RVA = "0x181DE58", Offset = "0x181DE58", VA = "0x181DE58")]
		public static extern ulong ovr_Application_LaunchOtherApp(ulong appID, IntPtr deeplink_options);

		[PreserveSig]
		[Token(Token = "0x600011F")]
		[Address(RVA = "0x1823154", Offset = "0x1823154", VA = "0x1823154")]
		public static extern ulong ovr_ApplicationLifecycle_GetRegisteredPIDs();

		[PreserveSig]
		[Token(Token = "0x6000120")]
		[Address(RVA = "0x18231C8", Offset = "0x18231C8", VA = "0x18231C8")]
		public static extern ulong ovr_ApplicationLifecycle_GetSessionKey();

		[Token(Token = "0x6000121")]
		[Address(RVA = "0x182323C", Offset = "0x182323C", VA = "0x182323C")]
		public static ulong ovr_ApplicationLifecycle_RegisterSessionKey(string sessionKey)
		{
			return default(ulong);
		}

		[PreserveSig]
		[Token(Token = "0x6000122")]
		[Address(RVA = "0x18232E4", Offset = "0x18232E4", VA = "0x18232E4")]
		private static extern ulong ovr_ApplicationLifecycle_RegisterSessionKey_Native(IntPtr sessionKey);

		[PreserveSig]
		[Token(Token = "0x6000123")]
		[Address(RVA = "0x181E440", Offset = "0x181E440", VA = "0x181E440")]
		public static extern ulong ovr_AssetFile_Delete(ulong assetFileID);

		[PreserveSig]
		[Token(Token = "0x6000124")]
		[Address(RVA = "0x181E5D8", Offset = "0x181E5D8", VA = "0x181E5D8")]
		public static extern ulong ovr_AssetFile_DeleteById(ulong assetFileID);

		[Token(Token = "0x6000125")]
		[Address(RVA = "0x181E770", Offset = "0x181E770", VA = "0x181E770")]
		public static ulong ovr_AssetFile_DeleteByName(string assetFileName)
		{
			return default(ulong);
		}

		[PreserveSig]
		[Token(Token = "0x6000126")]
		[Address(RVA = "0x1823364", Offset = "0x1823364", VA = "0x1823364")]
		private static extern ulong ovr_AssetFile_DeleteByName_Native(IntPtr assetFileName);

		[PreserveSig]
		[Token(Token = "0x6000127")]
		[Address(RVA = "0x181E930", Offset = "0x181E930", VA = "0x181E930")]
		public static extern ulong ovr_AssetFile_Download(ulong assetFileID);

		[PreserveSig]
		[Token(Token = "0x6000128")]
		[Address(RVA = "0x181EAC8", Offset = "0x181EAC8", VA = "0x181EAC8")]
		public static extern ulong ovr_AssetFile_DownloadById(ulong assetFileID);

		[Token(Token = "0x6000129")]
		[Address(RVA = "0x181EC60", Offset = "0x181EC60", VA = "0x181EC60")]
		public static ulong ovr_AssetFile_DownloadByName(string assetFileName)
		{
			return default(ulong);
		}

		[PreserveSig]
		[Token(Token = "0x600012A")]
		[Address(RVA = "0x18233E4", Offset = "0x18233E4", VA = "0x18233E4")]
		private static extern ulong ovr_AssetFile_DownloadByName_Native(IntPtr assetFileName);

		[PreserveSig]
		[Token(Token = "0x600012B")]
		[Address(RVA = "0x181EE20", Offset = "0x181EE20", VA = "0x181EE20")]
		public static extern ulong ovr_AssetFile_DownloadCancel(ulong assetFileID);

		[PreserveSig]
		[Token(Token = "0x600012C")]
		[Address(RVA = "0x181EFB8", Offset = "0x181EFB8", VA = "0x181EFB8")]
		public static extern ulong ovr_AssetFile_DownloadCancelById(ulong assetFileID);

		[Token(Token = "0x600012D")]
		[Address(RVA = "0x181F150", Offset = "0x181F150", VA = "0x181F150")]
		public static ulong ovr_AssetFile_DownloadCancelByName(string assetFileName)
		{
			return default(ulong);
		}

		[PreserveSig]
		[Token(Token = "0x600012E")]
		[Address(RVA = "0x1823464", Offset = "0x1823464", VA = "0x1823464")]
		private static extern ulong ovr_AssetFile_DownloadCancelByName_Native(IntPtr assetFileName);

		[PreserveSig]
		[Token(Token = "0x600012F")]
		[Address(RVA = "0x181F300", Offset = "0x181F300", VA = "0x181F300")]
		public static extern ulong ovr_AssetFile_GetList();

		[PreserveSig]
		[Token(Token = "0x6000130")]
		[Address(RVA = "0x181F48C", Offset = "0x181F48C", VA = "0x181F48C")]
		public static extern ulong ovr_AssetFile_Status(ulong assetFileID);

		[PreserveSig]
		[Token(Token = "0x6000131")]
		[Address(RVA = "0x181F624", Offset = "0x181F624", VA = "0x181F624")]
		public static extern ulong ovr_AssetFile_StatusById(ulong assetFileID);

		[Token(Token = "0x6000132")]
		[Address(RVA = "0x181F7BC", Offset = "0x181F7BC", VA = "0x181F7BC")]
		public static ulong ovr_AssetFile_StatusByName(string assetFileName)
		{
			return default(ulong);
		}

		[PreserveSig]
		[Token(Token = "0x6000133")]
		[Address(RVA = "0x18234E4", Offset = "0x18234E4", VA = "0x18234E4")]
		private static extern ulong ovr_AssetFile_StatusByName_Native(IntPtr assetFileName);

		[Token(Token = "0x6000134")]
		[Address(RVA = "0x1823564", Offset = "0x1823564", VA = "0x1823564")]
		public static ulong ovr_Avatar_UpdateMetaData(string avatarMetaData, string imageFilePath)
		{
			return default(ulong);
		}

		[PreserveSig]
		[Token(Token = "0x6000135")]
		[Address(RVA = "0x1823638", Offset = "0x1823638", VA = "0x1823638")]
		private static extern ulong ovr_Avatar_UpdateMetaData_Native(IntPtr avatarMetaData, IntPtr imageFilePath);

		[PreserveSig]
		[Token(Token = "0x6000136")]
		[Address(RVA = "0x18236C8", Offset = "0x18236C8", VA = "0x18236C8")]
		public static extern ulong ovr_Cal_FinalizeApplication(ulong groupingObject, ulong[] userIDs, int numUserIDs, ulong finalized_application_ID);

		[PreserveSig]
		[Token(Token = "0x6000137")]
		[Address(RVA = "0x1823778", Offset = "0x1823778", VA = "0x1823778")]
		public static extern ulong ovr_Cal_GetSuggestedApplications(ulong groupingObject, ulong[] userIDs, int numUserIDs);

		[PreserveSig]
		[Token(Token = "0x6000138")]
		[Address(RVA = "0x1823818", Offset = "0x1823818", VA = "0x1823818")]
		public static extern ulong ovr_Cal_ProposeApplication(ulong groupingObject, ulong[] userIDs, int numUserIDs, ulong proposed_application_ID);

		[Token(Token = "0x6000139")]
		[Address(RVA = "0x18238C8", Offset = "0x18238C8", VA = "0x18238C8")]
		public static ulong ovr_CloudStorage_Delete(string bucket, string key)
		{
			return default(ulong);
		}

		[PreserveSig]
		[Token(Token = "0x600013A")]
		[Address(RVA = "0x182399C", Offset = "0x182399C", VA = "0x182399C")]
		private static extern ulong ovr_CloudStorage_Delete_Native(IntPtr bucket, IntPtr key);

		[Token(Token = "0x600013B")]
		[Address(RVA = "0x1823A2C", Offset = "0x1823A2C", VA = "0x1823A2C")]
		public static ulong ovr_CloudStorage_Load(string bucket, string key)
		{
			return default(ulong);
		}

		[PreserveSig]
		[Token(Token = "0x600013C")]
		[Address(RVA = "0x1823B00", Offset = "0x1823B00", VA = "0x1823B00")]
		private static extern ulong ovr_CloudStorage_Load_Native(IntPtr bucket, IntPtr key);

		[Token(Token = "0x600013D")]
		[Address(RVA = "0x1823B90", Offset = "0x1823B90", VA = "0x1823B90")]
		public static ulong ovr_CloudStorage_LoadBucketMetadata(string bucket)
		{
			return default(ulong);
		}

		[PreserveSig]
		[Token(Token = "0x600013E")]
		[Address(RVA = "0x1823C38", Offset = "0x1823C38", VA = "0x1823C38")]
		private static extern ulong ovr_CloudStorage_LoadBucketMetadata_Native(IntPtr bucket);

		[Token(Token = "0x600013F")]
		[Address(RVA = "0x1823CB8", Offset = "0x1823CB8", VA = "0x1823CB8")]
		public static ulong ovr_CloudStorage_LoadConflictMetadata(string bucket, string key)
		{
			return default(ulong);
		}

		[PreserveSig]
		[Token(Token = "0x6000140")]
		[Address(RVA = "0x1823D8C", Offset = "0x1823D8C", VA = "0x1823D8C")]
		private static extern ulong ovr_CloudStorage_LoadConflictMetadata_Native(IntPtr bucket, IntPtr key);

		[Token(Token = "0x6000141")]
		[Address(RVA = "0x1823E1C", Offset = "0x1823E1C", VA = "0x1823E1C")]
		public static ulong ovr_CloudStorage_LoadHandle(string handle)
		{
			return default(ulong);
		}

		[PreserveSig]
		[Token(Token = "0x6000142")]
		[Address(RVA = "0x1823EC4", Offset = "0x1823EC4", VA = "0x1823EC4")]
		private static extern ulong ovr_CloudStorage_LoadHandle_Native(IntPtr handle);

		[Token(Token = "0x6000143")]
		[Address(RVA = "0x1823F44", Offset = "0x1823F44", VA = "0x1823F44")]
		public static ulong ovr_CloudStorage_LoadMetadata(string bucket, string key)
		{
			return default(ulong);
		}

		[PreserveSig]
		[Token(Token = "0x6000144")]
		[Address(RVA = "0x1824018", Offset = "0x1824018", VA = "0x1824018")]
		private static extern ulong ovr_CloudStorage_LoadMetadata_Native(IntPtr bucket, IntPtr key);

		[Token(Token = "0x6000145")]
		[Address(RVA = "0x18240A8", Offset = "0x18240A8", VA = "0x18240A8")]
		public static ulong ovr_CloudStorage_ResolveKeepLocal(string bucket, string key, string remoteHandle)
		{
			return default(ulong);
		}

		[PreserveSig]
		[Token(Token = "0x6000146")]
		[Address(RVA = "0x182419C", Offset = "0x182419C", VA = "0x182419C")]
		private static extern ulong ovr_CloudStorage_ResolveKeepLocal_Native(IntPtr bucket, IntPtr key, IntPtr remoteHandle);

		[Token(Token = "0x6000147")]
		[Address(RVA = "0x1824234", Offset = "0x1824234", VA = "0x1824234")]
		public static ulong ovr_CloudStorage_ResolveKeepRemote(string bucket, string key, string remoteHandle)
		{
			return default(ulong);
		}

		[PreserveSig]
		[Token(Token = "0x6000148")]
		[Address(RVA = "0x1824328", Offset = "0x1824328", VA = "0x1824328")]
		private static extern ulong ovr_CloudStorage_ResolveKeepRemote_Native(IntPtr bucket, IntPtr key, IntPtr remoteHandle);

		[Token(Token = "0x6000149")]
		[Address(RVA = "0x18243C0", Offset = "0x18243C0", VA = "0x18243C0")]
		public static ulong ovr_CloudStorage_Save(string bucket, string key, byte[] data, uint dataSize, long counter, string extraData)
		{
			return default(ulong);
		}

		[PreserveSig]
		[Token(Token = "0x600014A")]
		[Address(RVA = "0x18244DC", Offset = "0x18244DC", VA = "0x18244DC")]
		private static extern ulong ovr_CloudStorage_Save_Native(IntPtr bucket, IntPtr key, byte[] data, uint dataSize, long counter, IntPtr extraData);

		[PreserveSig]
		[Token(Token = "0x600014B")]
		[Address(RVA = "0x18245A4", Offset = "0x18245A4", VA = "0x18245A4")]
		public static extern ulong ovr_CloudStorage2_GetUserDirectoryPath();

		[PreserveSig]
		[Token(Token = "0x600014C")]
		[Address(RVA = "0x1824618", Offset = "0x1824618", VA = "0x1824618")]
		public static extern ulong ovr_Entitlement_GetIsViewerEntitled();

		[Token(Token = "0x600014D")]
		[Address(RVA = "0x182468C", Offset = "0x182468C", VA = "0x182468C")]
		public static ulong ovr_GraphAPI_Get(string url)
		{
			return default(ulong);
		}

		[PreserveSig]
		[Token(Token = "0x600014E")]
		[Address(RVA = "0x1824734", Offset = "0x1824734", VA = "0x1824734")]
		private static extern ulong ovr_GraphAPI_Get_Native(IntPtr url);

		[Token(Token = "0x600014F")]
		[Address(RVA = "0x18247B4", Offset = "0x18247B4", VA = "0x18247B4")]
		public static ulong ovr_GraphAPI_Post(string url)
		{
			return default(ulong);
		}

		[PreserveSig]
		[Token(Token = "0x6000150")]
		[Address(RVA = "0x182485C", Offset = "0x182485C", VA = "0x182485C")]
		private static extern ulong ovr_GraphAPI_Post_Native(IntPtr url);

		[Token(Token = "0x6000151")]
		[Address(RVA = "0x18248D8", Offset = "0x18248D8", VA = "0x18248D8")]
		public static ulong ovr_HTTP_Get(string url)
		{
			return default(ulong);
		}

		[PreserveSig]
		[Token(Token = "0x6000152")]
		[Address(RVA = "0x1824980", Offset = "0x1824980", VA = "0x1824980")]
		private static extern ulong ovr_HTTP_Get_Native(IntPtr url);

		[Token(Token = "0x6000153")]
		[Address(RVA = "0x1824A00", Offset = "0x1824A00", VA = "0x1824A00")]
		public static ulong ovr_HTTP_GetToFile(string url, string diskFile)
		{
			return default(ulong);
		}

		[PreserveSig]
		[Token(Token = "0x6000154")]
		[Address(RVA = "0x1824AD4", Offset = "0x1824AD4", VA = "0x1824AD4")]
		private static extern ulong ovr_HTTP_GetToFile_Native(IntPtr url, IntPtr diskFile);

		[Token(Token = "0x6000155")]
		[Address(RVA = "0x1824B64", Offset = "0x1824B64", VA = "0x1824B64")]
		public static ulong ovr_HTTP_MultiPartPost(string url, string filepath_param_name, string filepath, string access_token, ovrKeyValuePair[] post_params)
		{
			return default(ulong);
		}

		[PreserveSig]
		[Token(Token = "0x6000156")]
		[Address(RVA = "0x1824CC0", Offset = "0x1824CC0", VA = "0x1824CC0")]
		private static extern ulong ovr_HTTP_MultiPartPost_Native(IntPtr url, IntPtr filepath_param_name, IntPtr filepath, IntPtr access_token, ovrKeyValuePair[] post_params, UIntPtr numItems);

		[Token(Token = "0x6000157")]
		[Address(RVA = "0x1824E4C", Offset = "0x1824E4C", VA = "0x1824E4C")]
		public static ulong ovr_HTTP_Post(string url)
		{
			return default(ulong);
		}

		[PreserveSig]
		[Token(Token = "0x6000158")]
		[Address(RVA = "0x1824EF4", Offset = "0x1824EF4", VA = "0x1824EF4")]
		private static extern ulong ovr_HTTP_Post_Native(IntPtr url);

		[Token(Token = "0x6000159")]
		[Address(RVA = "0x1824F74", Offset = "0x1824F74", VA = "0x1824F74")]
		public static ulong ovr_IAP_ConsumePurchase(string sku)
		{
			return default(ulong);
		}

		[PreserveSig]
		[Token(Token = "0x600015A")]
		[Address(RVA = "0x182501C", Offset = "0x182501C", VA = "0x182501C")]
		private static extern ulong ovr_IAP_ConsumePurchase_Native(IntPtr sku);

		[PreserveSig]
		[Token(Token = "0x600015B")]
		[Address(RVA = "0x182509C", Offset = "0x182509C", VA = "0x182509C")]
		public static extern ulong ovr_IAP_GetProductsBySKU(string[] skus, int count);

		[PreserveSig]
		[Token(Token = "0x600015C")]
		[Address(RVA = "0x18251F0", Offset = "0x18251F0", VA = "0x18251F0")]
		public static extern ulong ovr_IAP_GetViewerPurchases();

		[Token(Token = "0x600015D")]
		[Address(RVA = "0x1825264", Offset = "0x1825264", VA = "0x1825264")]
		public static ulong ovr_IAP_LaunchCheckoutFlow(string sku)
		{
			return default(ulong);
		}

		[PreserveSig]
		[Token(Token = "0x600015E")]
		[Address(RVA = "0x182530C", Offset = "0x182530C", VA = "0x182530C")]
		private static extern ulong ovr_IAP_LaunchCheckoutFlow_Native(IntPtr sku);

		[PreserveSig]
		[Token(Token = "0x600015F")]
		[Address(RVA = "0x182538C", Offset = "0x182538C", VA = "0x182538C")]
		public static extern ulong ovr_LanguagePack_GetCurrent();

		[Token(Token = "0x6000160")]
		[Address(RVA = "0x1825400", Offset = "0x1825400", VA = "0x1825400")]
		public static ulong ovr_LanguagePack_SetCurrent(string tag)
		{
			return default(ulong);
		}

		[PreserveSig]
		[Token(Token = "0x6000161")]
		[Address(RVA = "0x18254A8", Offset = "0x18254A8", VA = "0x18254A8")]
		private static extern ulong ovr_LanguagePack_SetCurrent_Native(IntPtr tag);

		[Token(Token = "0x6000162")]
		[Address(RVA = "0x1825528", Offset = "0x1825528", VA = "0x1825528")]
		public static ulong ovr_Leaderboard_GetEntries(string leaderboardName, int limit, LeaderboardFilterType filter, LeaderboardStartAt startAt)
		{
			return default(ulong);
		}

		[PreserveSig]
		[Token(Token = "0x6000163")]
		[Address(RVA = "0x18255F8", Offset = "0x18255F8", VA = "0x18255F8")]
		private static extern ulong ovr_Leaderboard_GetEntries_Native(IntPtr leaderboardName, int limit, LeaderboardFilterType filter, LeaderboardStartAt startAt);

		[Token(Token = "0x6000164")]
		[Address(RVA = "0x18256A0", Offset = "0x18256A0", VA = "0x18256A0")]
		public static ulong ovr_Leaderboard_GetEntriesAfterRank(string leaderboardName, int limit, ulong afterRank)
		{
			return default(ulong);
		}

		[PreserveSig]
		[Token(Token = "0x6000165")]
		[Address(RVA = "0x1825760", Offset = "0x1825760", VA = "0x1825760")]
		private static extern ulong ovr_Leaderboard_GetEntriesAfterRank_Native(IntPtr leaderboardName, int limit, ulong afterRank);

		[PreserveSig]
		[Token(Token = "0x6000166")]
		[Address(RVA = "0x18257F8", Offset = "0x18257F8", VA = "0x18257F8")]
		public static extern ulong ovr_Leaderboard_GetNextEntries(IntPtr handle);

		[PreserveSig]
		[Token(Token = "0x6000167")]
		[Address(RVA = "0x1825878", Offset = "0x1825878", VA = "0x1825878")]
		public static extern ulong ovr_Leaderboard_GetPreviousEntries(IntPtr handle);

		[Token(Token = "0x6000168")]
		[Address(RVA = "0x18258F8", Offset = "0x18258F8", VA = "0x18258F8")]
		public static ulong ovr_Leaderboard_WriteEntry(string leaderboardName, long score, byte[] extraData, uint extraDataLength, bool forceUpdate)
		{
			return default(ulong);
		}

		[PreserveSig]
		[Token(Token = "0x6000169")]
		[Address(RVA = "0x18259D0", Offset = "0x18259D0", VA = "0x18259D0")]
		private static extern ulong ovr_Leaderboard_WriteEntry_Native(IntPtr leaderboardName, long score, byte[] extraData, uint extraDataLength, bool forceUpdate);

		[PreserveSig]
		[Token(Token = "0x600016A")]
		[Address(RVA = "0x1825A88", Offset = "0x1825A88", VA = "0x1825A88")]
		public static extern ulong ovr_Livestreaming_GetStatus();

		[Token(Token = "0x600016B")]
		[Address(RVA = "0x1825AFC", Offset = "0x1825AFC", VA = "0x1825AFC")]
		public static ulong ovr_Livestreaming_IsAllowedForApplication(string packageName)
		{
			return default(ulong);
		}

		[PreserveSig]
		[Token(Token = "0x600016C")]
		[Address(RVA = "0x1825BA4", Offset = "0x1825BA4", VA = "0x1825BA4")]
		private static extern ulong ovr_Livestreaming_IsAllowedForApplication_Native(IntPtr packageName);

		[PreserveSig]
		[Token(Token = "0x600016D")]
		[Address(RVA = "0x1825C24", Offset = "0x1825C24", VA = "0x1825C24")]
		public static extern ulong ovr_Livestreaming_PauseStream();

		[PreserveSig]
		[Token(Token = "0x600016E")]
		[Address(RVA = "0x1825C98", Offset = "0x1825C98", VA = "0x1825C98")]
		public static extern ulong ovr_Livestreaming_ResumeStream();

		[PreserveSig]
		[Token(Token = "0x600016F")]
		[Address(RVA = "0x1825D0C", Offset = "0x1825D0C", VA = "0x1825D0C")]
		public static extern ulong ovr_Livestreaming_StartPartyStream();

		[PreserveSig]
		[Token(Token = "0x6000170")]
		[Address(RVA = "0x1825D80", Offset = "0x1825D80", VA = "0x1825D80")]
		public static extern ulong ovr_Livestreaming_StopPartyStream();

		[PreserveSig]
		[Token(Token = "0x6000171")]
		[Address(RVA = "0x1825DF4", Offset = "0x1825DF4", VA = "0x1825DF4")]
		public static extern ulong ovr_Livestreaming_StopStream();

		[PreserveSig]
		[Token(Token = "0x6000172")]
		[Address(RVA = "0x1825E68", Offset = "0x1825E68", VA = "0x1825E68")]
		public static extern ulong ovr_Livestreaming_UpdateCommentsOverlayVisibility(bool isVisible);

		[Token(Token = "0x6000173")]
		[Address(RVA = "0x1825EE8", Offset = "0x1825EE8", VA = "0x1825EE8")]
		public static ulong ovr_Matchmaking_Browse(string pool, IntPtr customQueryData)
		{
			return default(ulong);
		}

		[PreserveSig]
		[Token(Token = "0x6000174")]
		[Address(RVA = "0x1825FA0", Offset = "0x1825FA0", VA = "0x1825FA0")]
		private static extern ulong ovr_Matchmaking_Browse_Native(IntPtr pool, IntPtr customQueryData);

		[Token(Token = "0x6000175")]
		[Address(RVA = "0x1826030", Offset = "0x1826030", VA = "0x1826030")]
		public static ulong ovr_Matchmaking_Browse2(string pool, IntPtr matchmakingOptions)
		{
			return default(ulong);
		}

		[PreserveSig]
		[Token(Token = "0x6000176")]
		[Address(RVA = "0x18260E8", Offset = "0x18260E8", VA = "0x18260E8")]
		private static extern ulong ovr_Matchmaking_Browse2_Native(IntPtr pool, IntPtr matchmakingOptions);

		[Token(Token = "0x6000177")]
		[Address(RVA = "0x1826178", Offset = "0x1826178", VA = "0x1826178")]
		public static ulong ovr_Matchmaking_Cancel(string pool, string requestHash)
		{
			return default(ulong);
		}

		[PreserveSig]
		[Token(Token = "0x6000178")]
		[Address(RVA = "0x182624C", Offset = "0x182624C", VA = "0x182624C")]
		private static extern ulong ovr_Matchmaking_Cancel_Native(IntPtr pool, IntPtr requestHash);

		[PreserveSig]
		[Token(Token = "0x6000179")]
		[Address(RVA = "0x18262DC", Offset = "0x18262DC", VA = "0x18262DC")]
		public static extern ulong ovr_Matchmaking_Cancel2();

		[Token(Token = "0x600017A")]
		[Address(RVA = "0x1826350", Offset = "0x1826350", VA = "0x1826350")]
		public static ulong ovr_Matchmaking_CreateAndEnqueueRoom(string pool, uint maxUsers, bool subscribeToUpdates, IntPtr customQueryData)
		{
			return default(ulong);
		}

		[PreserveSig]
		[Token(Token = "0x600017B")]
		[Address(RVA = "0x1826420", Offset = "0x1826420", VA = "0x1826420")]
		private static extern ulong ovr_Matchmaking_CreateAndEnqueueRoom_Native(IntPtr pool, uint maxUsers, bool subscribeToUpdates, IntPtr customQueryData);

		[Token(Token = "0x600017C")]
		[Address(RVA = "0x18264C8", Offset = "0x18264C8", VA = "0x18264C8")]
		public static ulong ovr_Matchmaking_CreateAndEnqueueRoom2(string pool, IntPtr matchmakingOptions)
		{
			return default(ulong);
		}

		[PreserveSig]
		[Token(Token = "0x600017D")]
		[Address(RVA = "0x1826580", Offset = "0x1826580", VA = "0x1826580")]
		private static extern ulong ovr_Matchmaking_CreateAndEnqueueRoom2_Native(IntPtr pool, IntPtr matchmakingOptions);

		[Token(Token = "0x600017E")]
		[Address(RVA = "0x1826610", Offset = "0x1826610", VA = "0x1826610")]
		public static ulong ovr_Matchmaking_CreateRoom(string pool, uint maxUsers, bool subscribeToUpdates)
		{
			return default(ulong);
		}

		[PreserveSig]
		[Token(Token = "0x600017F")]
		[Address(RVA = "0x18266D0", Offset = "0x18266D0", VA = "0x18266D0")]
		private static extern ulong ovr_Matchmaking_CreateRoom_Native(IntPtr pool, uint maxUsers, bool subscribeToUpdates);

		[Token(Token = "0x6000180")]
		[Address(RVA = "0x1826768", Offset = "0x1826768", VA = "0x1826768")]
		public static ulong ovr_Matchmaking_CreateRoom2(string pool, IntPtr matchmakingOptions)
		{
			return default(ulong);
		}

		[PreserveSig]
		[Token(Token = "0x6000181")]
		[Address(RVA = "0x1826820", Offset = "0x1826820", VA = "0x1826820")]
		private static extern ulong ovr_Matchmaking_CreateRoom2_Native(IntPtr pool, IntPtr matchmakingOptions);

		[Token(Token = "0x6000182")]
		[Address(RVA = "0x18268B0", Offset = "0x18268B0", VA = "0x18268B0")]
		public static ulong ovr_Matchmaking_Enqueue(string pool, IntPtr customQueryData)
		{
			return default(ulong);
		}

		[PreserveSig]
		[Token(Token = "0x6000183")]
		[Address(RVA = "0x1826968", Offset = "0x1826968", VA = "0x1826968")]
		private static extern ulong ovr_Matchmaking_Enqueue_Native(IntPtr pool, IntPtr customQueryData);

		[Token(Token = "0x6000184")]
		[Address(RVA = "0x18269F8", Offset = "0x18269F8", VA = "0x18269F8")]
		public static ulong ovr_Matchmaking_Enqueue2(string pool, IntPtr matchmakingOptions)
		{
			return default(ulong);
		}

		[PreserveSig]
		[Token(Token = "0x6000185")]
		[Address(RVA = "0x1826AB0", Offset = "0x1826AB0", VA = "0x1826AB0")]
		private static extern ulong ovr_Matchmaking_Enqueue2_Native(IntPtr pool, IntPtr matchmakingOptions);

		[PreserveSig]
		[Token(Token = "0x6000186")]
		[Address(RVA = "0x1826B40", Offset = "0x1826B40", VA = "0x1826B40")]
		public static extern ulong ovr_Matchmaking_EnqueueRoom(ulong roomID, IntPtr customQueryData);

		[PreserveSig]
		[Token(Token = "0x6000187")]
		[Address(RVA = "0x1826BD0", Offset = "0x1826BD0", VA = "0x1826BD0")]
		public static extern ulong ovr_Matchmaking_EnqueueRoom2(ulong roomID, IntPtr matchmakingOptions);

		[PreserveSig]
		[Token(Token = "0x6000188")]
		[Address(RVA = "0x1826C60", Offset = "0x1826C60", VA = "0x1826C60")]
		public static extern ulong ovr_Matchmaking_GetAdminSnapshot();

		[Token(Token = "0x6000189")]
		[Address(RVA = "0x1826CD4", Offset = "0x1826CD4", VA = "0x1826CD4")]
		public static ulong ovr_Matchmaking_GetStats(string pool, uint maxLevel, MatchmakingStatApproach approach)
		{
			return default(ulong);
		}

		[PreserveSig]
		[Token(Token = "0x600018A")]
		[Address(RVA = "0x1826D94", Offset = "0x1826D94", VA = "0x1826D94")]
		private static extern ulong ovr_Matchmaking_GetStats_Native(IntPtr pool, uint maxLevel, MatchmakingStatApproach approach);

		[PreserveSig]
		[Token(Token = "0x600018B")]
		[Address(RVA = "0x1826E2C", Offset = "0x1826E2C", VA = "0x1826E2C")]
		public static extern ulong ovr_Matchmaking_JoinRoom(ulong roomID, bool subscribeToUpdates);

		[Token(Token = "0x600018C")]
		[Address(RVA = "0x1826EBC", Offset = "0x1826EBC", VA = "0x1826EBC")]
		public static ulong ovr_Matchmaking_ReportResultInsecure(ulong roomID, ovrKeyValuePair[] data)
		{
			return default(ulong);
		}

		[PreserveSig]
		[Token(Token = "0x600018D")]
		[Address(RVA = "0x1826F70", Offset = "0x1826F70", VA = "0x1826F70")]
		private static extern ulong ovr_Matchmaking_ReportResultInsecure_Native(ulong roomID, ovrKeyValuePair[] data, UIntPtr numItems);

		[PreserveSig]
		[Token(Token = "0x600018E")]
		[Address(RVA = "0x18270CC", Offset = "0x18270CC", VA = "0x18270CC")]
		public static extern ulong ovr_Matchmaking_StartMatch(ulong roomID);

		[Token(Token = "0x600018F")]
		[Address(RVA = "0x182714C", Offset = "0x182714C", VA = "0x182714C")]
		public static ulong ovr_Media_ShareToFacebook(string postTextSuggestion, string filePath, MediaContentType contentType)
		{
			return default(ulong);
		}

		[PreserveSig]
		[Token(Token = "0x6000190")]
		[Address(RVA = "0x1827228", Offset = "0x1827228", VA = "0x1827228")]
		private static extern ulong ovr_Media_ShareToFacebook_Native(IntPtr postTextSuggestion, IntPtr filePath, MediaContentType contentType);

		[PreserveSig]
		[Token(Token = "0x6000191")]
		[Address(RVA = "0x18272C0", Offset = "0x18272C0", VA = "0x18272C0")]
		public static extern ulong ovr_Notification_GetRoomInvites();

		[PreserveSig]
		[Token(Token = "0x6000192")]
		[Address(RVA = "0x1827334", Offset = "0x1827334", VA = "0x1827334")]
		public static extern ulong ovr_Notification_MarkAsRead(ulong notificationID);

		[PreserveSig]
		[Token(Token = "0x6000193")]
		[Address(RVA = "0x18273B4", Offset = "0x18273B4", VA = "0x18273B4")]
		public static extern ulong ovr_Party_Create();

		[PreserveSig]
		[Token(Token = "0x6000194")]
		[Address(RVA = "0x1827428", Offset = "0x1827428", VA = "0x1827428")]
		public static extern ulong ovr_Party_GatherInApplication(ulong partyID, ulong appID);

		[PreserveSig]
		[Token(Token = "0x6000195")]
		[Address(RVA = "0x18274B8", Offset = "0x18274B8", VA = "0x18274B8")]
		public static extern ulong ovr_Party_Get(ulong partyID);

		[PreserveSig]
		[Token(Token = "0x6000196")]
		[Address(RVA = "0x1827538", Offset = "0x1827538", VA = "0x1827538")]
		public static extern ulong ovr_Party_GetCurrent();

		[PreserveSig]
		[Token(Token = "0x6000197")]
		[Address(RVA = "0x18275AC", Offset = "0x18275AC", VA = "0x18275AC")]
		public static extern ulong ovr_Party_GetCurrentForUser(ulong userID);

		[PreserveSig]
		[Token(Token = "0x6000198")]
		[Address(RVA = "0x182762C", Offset = "0x182762C", VA = "0x182762C")]
		public static extern ulong ovr_Party_Invite(ulong partyID, ulong userID);

		[PreserveSig]
		[Token(Token = "0x6000199")]
		[Address(RVA = "0x18276B8", Offset = "0x18276B8", VA = "0x18276B8")]
		public static extern ulong ovr_Party_Join(ulong partyID);

		[PreserveSig]
		[Token(Token = "0x600019A")]
		[Address(RVA = "0x1827738", Offset = "0x1827738", VA = "0x1827738")]
		public static extern ulong ovr_Party_Leave(ulong partyID);

		[PreserveSig]
		[Token(Token = "0x600019B")]
		[Address(RVA = "0x18277B8", Offset = "0x18277B8", VA = "0x18277B8")]
		public static extern ulong ovr_Room_CreateAndJoinPrivate(RoomJoinPolicy joinPolicy, uint maxUsers, bool subscribeToUpdates);

		[PreserveSig]
		[Token(Token = "0x600019C")]
		[Address(RVA = "0x1827850", Offset = "0x1827850", VA = "0x1827850")]
		public static extern ulong ovr_Room_CreateAndJoinPrivate2(RoomJoinPolicy joinPolicy, uint maxUsers, IntPtr roomOptions);

		[PreserveSig]
		[Token(Token = "0x600019D")]
		[Address(RVA = "0x18278E8", Offset = "0x18278E8", VA = "0x18278E8")]
		public static extern ulong ovr_Room_Get(ulong roomID);

		[PreserveSig]
		[Token(Token = "0x600019E")]
		[Address(RVA = "0x1827968", Offset = "0x1827968", VA = "0x1827968")]
		public static extern ulong ovr_Room_GetCurrent();

		[PreserveSig]
		[Token(Token = "0x600019F")]
		[Address(RVA = "0x18279DC", Offset = "0x18279DC", VA = "0x18279DC")]
		public static extern ulong ovr_Room_GetCurrentForUser(ulong userID);

		[PreserveSig]
		[Token(Token = "0x60001A0")]
		[Address(RVA = "0x1827A5C", Offset = "0x1827A5C", VA = "0x1827A5C")]
		public static extern ulong ovr_Room_GetInvitableUsers();

		[PreserveSig]
		[Token(Token = "0x60001A1")]
		[Address(RVA = "0x1827AD0", Offset = "0x1827AD0", VA = "0x1827AD0")]
		public static extern ulong ovr_Room_GetInvitableUsers2(IntPtr roomOptions);

		[PreserveSig]
		[Token(Token = "0x60001A2")]
		[Address(RVA = "0x1827B50", Offset = "0x1827B50", VA = "0x1827B50")]
		public static extern ulong ovr_Room_GetModeratedRooms();

		[PreserveSig]
		[Token(Token = "0x60001A3")]
		[Address(RVA = "0x1827BC4", Offset = "0x1827BC4", VA = "0x1827BC4")]
		public static extern ulong ovr_Room_GetSocialRooms(ulong appID);

		[Token(Token = "0x60001A4")]
		[Address(RVA = "0x1827C44", Offset = "0x1827C44", VA = "0x1827C44")]
		public static ulong ovr_Room_InviteUser(ulong roomID, string inviteToken)
		{
			return default(ulong);
		}

		[PreserveSig]
		[Token(Token = "0x60001A5")]
		[Address(RVA = "0x1827D00", Offset = "0x1827D00", VA = "0x1827D00")]
		private static extern ulong ovr_Room_InviteUser_Native(ulong roomID, IntPtr inviteToken);

		[PreserveSig]
		[Token(Token = "0x60001A6")]
		[Address(RVA = "0x1827D90", Offset = "0x1827D90", VA = "0x1827D90")]
		public static extern ulong ovr_Room_Join(ulong roomID, bool subscribeToUpdates);

		[PreserveSig]
		[Token(Token = "0x60001A7")]
		[Address(RVA = "0x1827E20", Offset = "0x1827E20", VA = "0x1827E20")]
		public static extern ulong ovr_Room_Join2(ulong roomID, IntPtr roomOptions);

		[PreserveSig]
		[Token(Token = "0x60001A8")]
		[Address(RVA = "0x1827EB0", Offset = "0x1827EB0", VA = "0x1827EB0")]
		public static extern ulong ovr_Room_KickUser(ulong roomID, ulong userID, int kickDurationSeconds);

		[PreserveSig]
		[Token(Token = "0x60001A9")]
		[Address(RVA = "0x1827F44", Offset = "0x1827F44", VA = "0x1827F44")]
		public static extern ulong ovr_Room_LaunchInvitableUserFlow(ulong roomID);

		[PreserveSig]
		[Token(Token = "0x60001AA")]
		[Address(RVA = "0x1827FC4", Offset = "0x1827FC4", VA = "0x1827FC4")]
		public static extern ulong ovr_Room_Leave(ulong roomID);

		[Token(Token = "0x60001AB")]
		[Address(RVA = "0x1828044", Offset = "0x1828044", VA = "0x1828044")]
		public static ulong ovr_Room_SetDescription(ulong roomID, string description)
		{
			return default(ulong);
		}

		[PreserveSig]
		[Token(Token = "0x60001AC")]
		[Address(RVA = "0x1828100", Offset = "0x1828100", VA = "0x1828100")]
		private static extern ulong ovr_Room_SetDescription_Native(ulong roomID, IntPtr description);

		[Token(Token = "0x60001AD")]
		[Address(RVA = "0x1828190", Offset = "0x1828190", VA = "0x1828190")]
		public static ulong ovr_Room_UpdateDataStore(ulong roomID, ovrKeyValuePair[] data)
		{
			return default(ulong);
		}

		[PreserveSig]
		[Token(Token = "0x60001AE")]
		[Address(RVA = "0x1828244", Offset = "0x1828244", VA = "0x1828244")]
		private static extern ulong ovr_Room_UpdateDataStore_Native(ulong roomID, ovrKeyValuePair[] data, UIntPtr numItems);

		[PreserveSig]
		[Token(Token = "0x60001AF")]
		[Address(RVA = "0x182839C", Offset = "0x182839C", VA = "0x182839C")]
		public static extern ulong ovr_Room_UpdateMembershipLockStatus(ulong roomID, RoomMembershipLockStatus membershipLockStatus);

		[PreserveSig]
		[Token(Token = "0x60001B0")]
		[Address(RVA = "0x182842C", Offset = "0x182842C", VA = "0x182842C")]
		public static extern ulong ovr_Room_UpdateOwner(ulong roomID, ulong userID);

		[PreserveSig]
		[Token(Token = "0x60001B1")]
		[Address(RVA = "0x18284BC", Offset = "0x18284BC", VA = "0x18284BC")]
		public static extern ulong ovr_Room_UpdatePrivateRoomJoinPolicy(ulong roomID, RoomJoinPolicy newJoinPolicy);

		[PreserveSig]
		[Token(Token = "0x60001B2")]
		[Address(RVA = "0x182854C", Offset = "0x182854C", VA = "0x182854C")]
		public static extern ulong ovr_SystemPermissions_GetStatus(PermissionType permType);

		[PreserveSig]
		[Token(Token = "0x60001B3")]
		[Address(RVA = "0x18285CC", Offset = "0x18285CC", VA = "0x18285CC")]
		public static extern ulong ovr_SystemPermissions_LaunchDeeplink(PermissionType permType);

		[Token(Token = "0x60001B4")]
		[Address(RVA = "0x182864C", Offset = "0x182864C", VA = "0x182864C")]
		public static ulong ovr_User_CancelRecordingForReportFlow(string recordingUUID)
		{
			return default(ulong);
		}

		[PreserveSig]
		[Token(Token = "0x60001B5")]
		[Address(RVA = "0x18286F4", Offset = "0x18286F4", VA = "0x18286F4")]
		private static extern ulong ovr_User_CancelRecordingForReportFlow_Native(IntPtr recordingUUID);

		[PreserveSig]
		[Token(Token = "0x60001B6")]
		[Address(RVA = "0x1828774", Offset = "0x1828774", VA = "0x1828774")]
		public static extern ulong ovr_User_Get(ulong userID);

		[PreserveSig]
		[Token(Token = "0x60001B7")]
		[Address(RVA = "0x18287F4", Offset = "0x18287F4", VA = "0x18287F4")]
		public static extern ulong ovr_User_GetAccessToken();

		[PreserveSig]
		[Token(Token = "0x60001B8")]
		[Address(RVA = "0x1828868", Offset = "0x1828868", VA = "0x1828868")]
		public static extern ulong ovr_User_GetLinkedAccounts(IntPtr userOptions);

		[PreserveSig]
		[Token(Token = "0x60001B9")]
		[Address(RVA = "0x18288E8", Offset = "0x18288E8", VA = "0x18288E8")]
		public static extern ulong ovr_User_GetLoggedInUser();

		[PreserveSig]
		[Token(Token = "0x60001BA")]
		[Address(RVA = "0x182895C", Offset = "0x182895C", VA = "0x182895C")]
		public static extern ulong ovr_User_GetLoggedInUserFriends();

		[PreserveSig]
		[Token(Token = "0x60001BB")]
		[Address(RVA = "0x18289D0", Offset = "0x18289D0", VA = "0x18289D0")]
		public static extern ulong ovr_User_GetLoggedInUserFriendsAndRooms();

		[PreserveSig]
		[Token(Token = "0x60001BC")]
		[Address(RVA = "0x1828A44", Offset = "0x1828A44", VA = "0x1828A44")]
		public static extern ulong ovr_User_GetLoggedInUserRecentlyMetUsersAndRooms(IntPtr userOptions);

		[PreserveSig]
		[Token(Token = "0x60001BD")]
		[Address(RVA = "0x1828AC4", Offset = "0x1828AC4", VA = "0x1828AC4")]
		public static extern ulong ovr_User_GetOrgScopedID(ulong userID);

		[PreserveSig]
		[Token(Token = "0x60001BE")]
		[Address(RVA = "0x1828B44", Offset = "0x1828B44", VA = "0x1828B44")]
		public static extern ulong ovr_User_GetSdkAccounts();

		[PreserveSig]
		[Token(Token = "0x60001BF")]
		[Address(RVA = "0x1828BB8", Offset = "0x1828BB8", VA = "0x1828BB8")]
		public static extern ulong ovr_User_GetUserProof();

		[PreserveSig]
		[Token(Token = "0x60001C0")]
		[Address(RVA = "0x1828C2C", Offset = "0x1828C2C", VA = "0x1828C2C")]
		public static extern ulong ovr_User_LaunchBlockFlow(ulong userID);

		[PreserveSig]
		[Token(Token = "0x60001C1")]
		[Address(RVA = "0x1828CAC", Offset = "0x1828CAC", VA = "0x1828CAC")]
		public static extern ulong ovr_User_LaunchFriendRequestFlow(ulong userID);

		[PreserveSig]
		[Token(Token = "0x60001C2")]
		[Address(RVA = "0x1828D2C", Offset = "0x1828D2C", VA = "0x1828D2C")]
		public static extern ulong ovr_User_LaunchProfile(ulong userID);

		[PreserveSig]
		[Token(Token = "0x60001C3")]
		[Address(RVA = "0x1828DAC", Offset = "0x1828DAC", VA = "0x1828DAC")]
		public static extern ulong ovr_User_LaunchReportFlow(ulong userID);

		[PreserveSig]
		[Token(Token = "0x60001C4")]
		[Address(RVA = "0x1828E2C", Offset = "0x1828E2C", VA = "0x1828E2C")]
		public static extern ulong ovr_User_LaunchReportFlow2(ulong optionalUserID, IntPtr abuseReportOptions);

		[PreserveSig]
		[Token(Token = "0x60001C5")]
		[Address(RVA = "0x1828EBC", Offset = "0x1828EBC", VA = "0x1828EBC")]
		public static extern ulong ovr_User_LaunchUnblockFlow(ulong userID);

		[PreserveSig]
		[Token(Token = "0x60001C6")]
		[Address(RVA = "0x1828F3C", Offset = "0x1828F3C", VA = "0x1828F3C")]
		public static extern ulong ovr_User_NewEntitledTestUser();

		[PreserveSig]
		[Token(Token = "0x60001C7")]
		[Address(RVA = "0x1828FB0", Offset = "0x1828FB0", VA = "0x1828FB0")]
		public static extern ulong ovr_User_NewTestUser();

		[PreserveSig]
		[Token(Token = "0x60001C8")]
		[Address(RVA = "0x1829024", Offset = "0x1829024", VA = "0x1829024")]
		public static extern ulong ovr_User_NewTestUserFriends();

		[PreserveSig]
		[Token(Token = "0x60001C9")]
		[Address(RVA = "0x1829098", Offset = "0x1829098", VA = "0x1829098")]
		public static extern ulong ovr_User_StartRecordingForReportFlow();

		[Token(Token = "0x60001CA")]
		[Address(RVA = "0x182910C", Offset = "0x182910C", VA = "0x182910C")]
		public static ulong ovr_User_StopRecordingAndLaunchReportFlow(ulong optionalUserID, string optionalRecordingUUID)
		{
			return default(ulong);
		}

		[PreserveSig]
		[Token(Token = "0x60001CB")]
		[Address(RVA = "0x18291C8", Offset = "0x18291C8", VA = "0x18291C8")]
		private static extern ulong ovr_User_StopRecordingAndLaunchReportFlow_Native(ulong optionalUserID, IntPtr optionalRecordingUUID);

		[Token(Token = "0x60001CC")]
		[Address(RVA = "0x1829258", Offset = "0x1829258", VA = "0x1829258")]
		public static ulong ovr_User_StopRecordingAndLaunchReportFlow2(ulong optionalUserID, string optionalRecordingUUID, IntPtr abuseReportOptions)
		{
			return default(ulong);
		}

		[PreserveSig]
		[Token(Token = "0x60001CD")]
		[Address(RVA = "0x182931C", Offset = "0x182931C", VA = "0x182931C")]
		private static extern ulong ovr_User_StopRecordingAndLaunchReportFlow2_Native(ulong optionalUserID, IntPtr optionalRecordingUUID, IntPtr abuseReportOptions);

		[Token(Token = "0x60001CE")]
		[Address(RVA = "0x18293B4", Offset = "0x18293B4", VA = "0x18293B4")]
		public static ulong ovr_User_TestUserCreateDeviceManifest(string deviceID, ulong[] appIDs, int numAppIDs)
		{
			return default(ulong);
		}

		[PreserveSig]
		[Token(Token = "0x60001CF")]
		[Address(RVA = "0x1829474", Offset = "0x1829474", VA = "0x1829474")]
		private static extern ulong ovr_User_TestUserCreateDeviceManifest_Native(IntPtr deviceID, ulong[] appIDs, int numAppIDs);

		[PreserveSig]
		[Token(Token = "0x60001D0")]
		[Address(RVA = "0x1829514", Offset = "0x1829514", VA = "0x1829514")]
		public static extern ulong ovr_Voip_SetSystemVoipSuppressed(bool suppressed);

		[Token(Token = "0x60001D1")]
		[Address(RVA = "0x1829594", Offset = "0x1829594", VA = "0x1829594")]
		public static string ovr_AbuseReportRecording_GetRecordingUuid(IntPtr obj)
		{
			return null;
		}

		[PreserveSig]
		[Token(Token = "0x60001D2")]
		[Address(RVA = "0x18295FC", Offset = "0x18295FC", VA = "0x18295FC")]
		private static extern IntPtr ovr_AbuseReportRecording_GetRecordingUuid_Native(IntPtr obj);

		[PreserveSig]
		[Token(Token = "0x60001D3")]
		[Address(RVA = "0x182967C", Offset = "0x182967C", VA = "0x182967C")]
		public static extern uint ovr_AchievementDefinition_GetBitfieldLength(IntPtr obj);

		[Token(Token = "0x60001D4")]
		[Address(RVA = "0x18296FC", Offset = "0x18296FC", VA = "0x18296FC")]
		public static string ovr_AchievementDefinition_GetName(IntPtr obj)
		{
			return null;
		}

		[PreserveSig]
		[Token(Token = "0x60001D5")]
		[Address(RVA = "0x1829764", Offset = "0x1829764", VA = "0x1829764")]
		private static extern IntPtr ovr_AchievementDefinition_GetName_Native(IntPtr obj);

		[PreserveSig]
		[Token(Token = "0x60001D6")]
		[Address(RVA = "0x18297E4", Offset = "0x18297E4", VA = "0x18297E4")]
		public static extern ulong ovr_AchievementDefinition_GetTarget(IntPtr obj);

		[PreserveSig]
		[Token(Token = "0x60001D7")]
		[Address(RVA = "0x1829864", Offset = "0x1829864", VA = "0x1829864")]
		public static extern AchievementType ovr_AchievementDefinition_GetType(IntPtr obj);

		[PreserveSig]
		[Token(Token = "0x60001D8")]
		[Address(RVA = "0x18298E4", Offset = "0x18298E4", VA = "0x18298E4")]
		public static extern IntPtr ovr_AchievementDefinitionArray_GetElement(IntPtr obj, UIntPtr index);

		[Token(Token = "0x60001D9")]
		[Address(RVA = "0x1829974", Offset = "0x1829974", VA = "0x1829974")]
		public static string ovr_AchievementDefinitionArray_GetNextUrl(IntPtr obj)
		{
			return null;
		}

		[PreserveSig]
		[Token(Token = "0x60001DA")]
		[Address(RVA = "0x18299DC", Offset = "0x18299DC", VA = "0x18299DC")]
		private static extern IntPtr ovr_AchievementDefinitionArray_GetNextUrl_Native(IntPtr obj);

		[PreserveSig]
		[Token(Token = "0x60001DB")]
		[Address(RVA = "0x1829A5C", Offset = "0x1829A5C", VA = "0x1829A5C")]
		public static extern UIntPtr ovr_AchievementDefinitionArray_GetSize(IntPtr obj);

		[PreserveSig]
		[Token(Token = "0x60001DC")]
		[Address(RVA = "0x1829ADC", Offset = "0x1829ADC", VA = "0x1829ADC")]
		public static extern bool ovr_AchievementDefinitionArray_HasNextPage(IntPtr obj);

		[Token(Token = "0x60001DD")]
		[Address(RVA = "0x1829B64", Offset = "0x1829B64", VA = "0x1829B64")]
		public static string ovr_AchievementProgress_GetBitfield(IntPtr obj)
		{
			return null;
		}

		[PreserveSig]
		[Token(Token = "0x60001DE")]
		[Address(RVA = "0x1829BCC", Offset = "0x1829BCC", VA = "0x1829BCC")]
		private static extern IntPtr ovr_AchievementProgress_GetBitfield_Native(IntPtr obj);

		[PreserveSig]
		[Token(Token = "0x60001DF")]
		[Address(RVA = "0x1829C4C", Offset = "0x1829C4C", VA = "0x1829C4C")]
		public static extern ulong ovr_AchievementProgress_GetCount(IntPtr obj);

		[PreserveSig]
		[Token(Token = "0x60001E0")]
		[Address(RVA = "0x1829CCC", Offset = "0x1829CCC", VA = "0x1829CCC")]
		public static extern bool ovr_AchievementProgress_GetIsUnlocked(IntPtr obj);

		[Token(Token = "0x60001E1")]
		[Address(RVA = "0x1829D54", Offset = "0x1829D54", VA = "0x1829D54")]
		public static string ovr_AchievementProgress_GetName(IntPtr obj)
		{
			return null;
		}

		[PreserveSig]
		[Token(Token = "0x60001E2")]
		[Address(RVA = "0x1829DBC", Offset = "0x1829DBC", VA = "0x1829DBC")]
		private static extern IntPtr ovr_AchievementProgress_GetName_Native(IntPtr obj);

		[Token(Token = "0x60001E3")]
		[Address(RVA = "0x1829E3C", Offset = "0x1829E3C", VA = "0x1829E3C")]
		public static DateTime ovr_AchievementProgress_GetUnlockTime(IntPtr obj)
		{
			return default(DateTime);
		}

		[PreserveSig]
		[Token(Token = "0x60001E4")]
		[Address(RVA = "0x1829EA4", Offset = "0x1829EA4", VA = "0x1829EA4")]
		private static extern ulong ovr_AchievementProgress_GetUnlockTime_Native(IntPtr obj);

		[PreserveSig]
		[Token(Token = "0x60001E5")]
		[Address(RVA = "0x1829F24", Offset = "0x1829F24", VA = "0x1829F24")]
		public static extern IntPtr ovr_AchievementProgressArray_GetElement(IntPtr obj, UIntPtr index);

		[Token(Token = "0x60001E6")]
		[Address(RVA = "0x1829FB4", Offset = "0x1829FB4", VA = "0x1829FB4")]
		public static string ovr_AchievementProgressArray_GetNextUrl(IntPtr obj)
		{
			return null;
		}

		[PreserveSig]
		[Token(Token = "0x60001E7")]
		[Address(RVA = "0x182A01C", Offset = "0x182A01C", VA = "0x182A01C")]
		private static extern IntPtr ovr_AchievementProgressArray_GetNextUrl_Native(IntPtr obj);

		[PreserveSig]
		[Token(Token = "0x60001E8")]
		[Address(RVA = "0x182A09C", Offset = "0x182A09C", VA = "0x182A09C")]
		public static extern UIntPtr ovr_AchievementProgressArray_GetSize(IntPtr obj);

		[PreserveSig]
		[Token(Token = "0x60001E9")]
		[Address(RVA = "0x182A11C", Offset = "0x182A11C", VA = "0x182A11C")]
		public static extern bool ovr_AchievementProgressArray_HasNextPage(IntPtr obj);

		[PreserveSig]
		[Token(Token = "0x60001EA")]
		[Address(RVA = "0x182A1A4", Offset = "0x182A1A4", VA = "0x182A1A4")]
		public static extern bool ovr_AchievementUpdate_GetJustUnlocked(IntPtr obj);

		[Token(Token = "0x60001EB")]
		[Address(RVA = "0x182A22C", Offset = "0x182A22C", VA = "0x182A22C")]
		public static string ovr_AchievementUpdate_GetName(IntPtr obj)
		{
			return null;
		}

		[PreserveSig]
		[Token(Token = "0x60001EC")]
		[Address(RVA = "0x182A294", Offset = "0x182A294", VA = "0x182A294")]
		private static extern IntPtr ovr_AchievementUpdate_GetName_Native(IntPtr obj);

		[PreserveSig]
		[Token(Token = "0x60001ED")]
		[Address(RVA = "0x182A314", Offset = "0x182A314", VA = "0x182A314")]
		public static extern ulong ovr_Application_GetID(IntPtr obj);

		[PreserveSig]
		[Token(Token = "0x60001EE")]
		[Address(RVA = "0x182A394", Offset = "0x182A394", VA = "0x182A394")]
		public static extern int ovr_ApplicationVersion_GetCurrentCode(IntPtr obj);

		[Token(Token = "0x60001EF")]
		[Address(RVA = "0x182A414", Offset = "0x182A414", VA = "0x182A414")]
		public static string ovr_ApplicationVersion_GetCurrentName(IntPtr obj)
		{
			return null;
		}

		[PreserveSig]
		[Token(Token = "0x60001F0")]
		[Address(RVA = "0x182A47C", Offset = "0x182A47C", VA = "0x182A47C")]
		private static extern IntPtr ovr_ApplicationVersion_GetCurrentName_Native(IntPtr obj);

		[PreserveSig]
		[Token(Token = "0x60001F1")]
		[Address(RVA = "0x182A4FC", Offset = "0x182A4FC", VA = "0x182A4FC")]
		public static extern int ovr_ApplicationVersion_GetLatestCode(IntPtr obj);

		[Token(Token = "0x60001F2")]
		[Address(RVA = "0x182A57C", Offset = "0x182A57C", VA = "0x182A57C")]
		public static string ovr_ApplicationVersion_GetLatestName(IntPtr obj)
		{
			return null;
		}

		[PreserveSig]
		[Token(Token = "0x60001F3")]
		[Address(RVA = "0x182A5E4", Offset = "0x182A5E4", VA = "0x182A5E4")]
		private static extern IntPtr ovr_ApplicationVersion_GetLatestName_Native(IntPtr obj);

		[PreserveSig]
		[Token(Token = "0x60001F4")]
		[Address(RVA = "0x182A664", Offset = "0x182A664", VA = "0x182A664")]
		public static extern ulong ovr_AssetDetails_GetAssetId(IntPtr obj);

		[Token(Token = "0x60001F5")]
		[Address(RVA = "0x182A6E4", Offset = "0x182A6E4", VA = "0x182A6E4")]
		public static string ovr_AssetDetails_GetAssetType(IntPtr obj)
		{
			return null;
		}

		[PreserveSig]
		[Token(Token = "0x60001F6")]
		[Address(RVA = "0x182A74C", Offset = "0x182A74C", VA = "0x182A74C")]
		private static extern IntPtr ovr_AssetDetails_GetAssetType_Native(IntPtr obj);

		[Token(Token = "0x60001F7")]
		[Address(RVA = "0x182A7CC", Offset = "0x182A7CC", VA = "0x182A7CC")]
		public static string ovr_AssetDetails_GetDownloadStatus(IntPtr obj)
		{
			return null;
		}

		[PreserveSig]
		[Token(Token = "0x60001F8")]
		[Address(RVA = "0x182A834", Offset = "0x182A834", VA = "0x182A834")]
		private static extern IntPtr ovr_AssetDetails_GetDownloadStatus_Native(IntPtr obj);

		[Token(Token = "0x60001F9")]
		[Address(RVA = "0x182A8B4", Offset = "0x182A8B4", VA = "0x182A8B4")]
		public static string ovr_AssetDetails_GetFilepath(IntPtr obj)
		{
			return null;
		}

		[PreserveSig]
		[Token(Token = "0x60001FA")]
		[Address(RVA = "0x182A91C", Offset = "0x182A91C", VA = "0x182A91C")]
		private static extern IntPtr ovr_AssetDetails_GetFilepath_Native(IntPtr obj);

		[Token(Token = "0x60001FB")]
		[Address(RVA = "0x182A99C", Offset = "0x182A99C", VA = "0x182A99C")]
		public static string ovr_AssetDetails_GetIapStatus(IntPtr obj)
		{
			return null;
		}

		[PreserveSig]
		[Token(Token = "0x60001FC")]
		[Address(RVA = "0x182AA04", Offset = "0x182AA04", VA = "0x182AA04")]
		private static extern IntPtr ovr_AssetDetails_GetIapStatus_Native(IntPtr obj);

		[PreserveSig]
		[Token(Token = "0x60001FD")]
		[Address(RVA = "0x182AA84", Offset = "0x182AA84", VA = "0x182AA84")]
		public static extern IntPtr ovr_AssetDetails_GetLanguage(IntPtr obj);

		[PreserveSig]
		[Token(Token = "0x60001FE")]
		[Address(RVA = "0x182AB04", Offset = "0x182AB04", VA = "0x182AB04")]
		public static extern IntPtr ovr_AssetDetailsArray_GetElement(IntPtr obj, UIntPtr index);

		[PreserveSig]
		[Token(Token = "0x60001FF")]
		[Address(RVA = "0x182AB94", Offset = "0x182AB94", VA = "0x182AB94")]
		public static extern UIntPtr ovr_AssetDetailsArray_GetSize(IntPtr obj);

		[PreserveSig]
		[Token(Token = "0x6000200")]
		[Address(RVA = "0x182AC14", Offset = "0x182AC14", VA = "0x182AC14")]
		public static extern ulong ovr_AssetFileDeleteResult_GetAssetFileId(IntPtr obj);

		[PreserveSig]
		[Token(Token = "0x6000201")]
		[Address(RVA = "0x182AC94", Offset = "0x182AC94", VA = "0x182AC94")]
		public static extern ulong ovr_AssetFileDeleteResult_GetAssetId(IntPtr obj);

		[Token(Token = "0x6000202")]
		[Address(RVA = "0x182AD14", Offset = "0x182AD14", VA = "0x182AD14")]
		public static string ovr_AssetFileDeleteResult_GetFilepath(IntPtr obj)
		{
			return null;
		}

		[PreserveSig]
		[Token(Token = "0x6000203")]
		[Address(RVA = "0x182AD7C", Offset = "0x182AD7C", VA = "0x182AD7C")]
		private static extern IntPtr ovr_AssetFileDeleteResult_GetFilepath_Native(IntPtr obj);

		[PreserveSig]
		[Token(Token = "0x6000204")]
		[Address(RVA = "0x182ADFC", Offset = "0x182ADFC", VA = "0x182ADFC")]
		public static extern bool ovr_AssetFileDeleteResult_GetSuccess(IntPtr obj);

		[PreserveSig]
		[Token(Token = "0x6000205")]
		[Address(RVA = "0x182AE84", Offset = "0x182AE84", VA = "0x182AE84")]
		public static extern ulong ovr_AssetFileDownloadCancelResult_GetAssetFileId(IntPtr obj);

		[PreserveSig]
		[Token(Token = "0x6000206")]
		[Address(RVA = "0x182AF04", Offset = "0x182AF04", VA = "0x182AF04")]
		public static extern ulong ovr_AssetFileDownloadCancelResult_GetAssetId(IntPtr obj);

		[Token(Token = "0x6000207")]
		[Address(RVA = "0x182AF84", Offset = "0x182AF84", VA = "0x182AF84")]
		public static string ovr_AssetFileDownloadCancelResult_GetFilepath(IntPtr obj)
		{
			return null;
		}

		[PreserveSig]
		[Token(Token = "0x6000208")]
		[Address(RVA = "0x182AFEC", Offset = "0x182AFEC", VA = "0x182AFEC")]
		private static extern IntPtr ovr_AssetFileDownloadCancelResult_GetFilepath_Native(IntPtr obj);

		[PreserveSig]
		[Token(Token = "0x6000209")]
		[Address(RVA = "0x182B06C", Offset = "0x182B06C", VA = "0x182B06C")]
		public static extern bool ovr_AssetFileDownloadCancelResult_GetSuccess(IntPtr obj);

		[PreserveSig]
		[Token(Token = "0x600020A")]
		[Address(RVA = "0x182B0F4", Offset = "0x182B0F4", VA = "0x182B0F4")]
		public static extern ulong ovr_AssetFileDownloadResult_GetAssetId(IntPtr obj);

		[Token(Token = "0x600020B")]
		[Address(RVA = "0x182B174", Offset = "0x182B174", VA = "0x182B174")]
		public static string ovr_AssetFileDownloadResult_GetFilepath(IntPtr obj)
		{
			return null;
		}

		[PreserveSig]
		[Token(Token = "0x600020C")]
		[Address(RVA = "0x182B1DC", Offset = "0x182B1DC", VA = "0x182B1DC")]
		private static extern IntPtr ovr_AssetFileDownloadResult_GetFilepath_Native(IntPtr obj);

		[PreserveSig]
		[Token(Token = "0x600020D")]
		[Address(RVA = "0x182B25C", Offset = "0x182B25C", VA = "0x182B25C")]
		public static extern ulong ovr_AssetFileDownloadUpdate_GetAssetFileId(IntPtr obj);

		[PreserveSig]
		[Token(Token = "0x600020E")]
		[Address(RVA = "0x182B2DC", Offset = "0x182B2DC", VA = "0x182B2DC")]
		public static extern ulong ovr_AssetFileDownloadUpdate_GetAssetId(IntPtr obj);

		[PreserveSig]
		[Token(Token = "0x600020F")]
		[Address(RVA = "0x182B35C", Offset = "0x182B35C", VA = "0x182B35C")]
		public static extern uint ovr_AssetFileDownloadUpdate_GetBytesTotal(IntPtr obj);

		[PreserveSig]
		[Token(Token = "0x6000210")]
		[Address(RVA = "0x182B3DC", Offset = "0x182B3DC", VA = "0x182B3DC")]
		public static extern int ovr_AssetFileDownloadUpdate_GetBytesTransferred(IntPtr obj);

		[PreserveSig]
		[Token(Token = "0x6000211")]
		[Address(RVA = "0x182B45C", Offset = "0x182B45C", VA = "0x182B45C")]
		public static extern bool ovr_AssetFileDownloadUpdate_GetCompleted(IntPtr obj);

		[PreserveSig]
		[Token(Token = "0x6000212")]
		[Address(RVA = "0x182B4E4", Offset = "0x182B4E4", VA = "0x182B4E4")]
		public static extern int ovr_CalApplicationFinalized_GetCountdownMS(IntPtr obj);

		[PreserveSig]
		[Token(Token = "0x6000213")]
		[Address(RVA = "0x182B564", Offset = "0x182B564", VA = "0x182B564")]
		public static extern ulong ovr_CalApplicationFinalized_GetID(IntPtr obj);

		[Token(Token = "0x6000214")]
		[Address(RVA = "0x182B5E4", Offset = "0x182B5E4", VA = "0x182B5E4")]
		public static string ovr_CalApplicationFinalized_GetLaunchDetails(IntPtr obj)
		{
			return null;
		}

		[PreserveSig]
		[Token(Token = "0x6000215")]
		[Address(RVA = "0x182B64C", Offset = "0x182B64C", VA = "0x182B64C")]
		private static extern IntPtr ovr_CalApplicationFinalized_GetLaunchDetails_Native(IntPtr obj);

		[PreserveSig]
		[Token(Token = "0x6000216")]
		[Address(RVA = "0x182B6CC", Offset = "0x182B6CC", VA = "0x182B6CC")]
		public static extern ulong ovr_CalApplicationProposed_GetID(IntPtr obj);

		[PreserveSig]
		[Token(Token = "0x6000217")]
		[Address(RVA = "0x182B74C", Offset = "0x182B74C", VA = "0x182B74C")]
		public static extern ulong ovr_CalApplicationSuggestion_GetID(IntPtr obj);

		[Token(Token = "0x6000218")]
		[Address(RVA = "0x182B7CC", Offset = "0x182B7CC", VA = "0x182B7CC")]
		public static string ovr_CalApplicationSuggestion_GetSocialContext(IntPtr obj)
		{
			return null;
		}

		[PreserveSig]
		[Token(Token = "0x6000219")]
		[Address(RVA = "0x182B834", Offset = "0x182B834", VA = "0x182B834")]
		private static extern IntPtr ovr_CalApplicationSuggestion_GetSocialContext_Native(IntPtr obj);

		[PreserveSig]
		[Token(Token = "0x600021A")]
		[Address(RVA = "0x182B8B4", Offset = "0x182B8B4", VA = "0x182B8B4")]
		public static extern IntPtr ovr_CalApplicationSuggestionArray_GetElement(IntPtr obj, UIntPtr index);

		[PreserveSig]
		[Token(Token = "0x600021B")]
		[Address(RVA = "0x182B944", Offset = "0x182B944", VA = "0x182B944")]
		public static extern UIntPtr ovr_CalApplicationSuggestionArray_GetSize(IntPtr obj);

		[Token(Token = "0x600021C")]
		[Address(RVA = "0x182B9C4", Offset = "0x182B9C4", VA = "0x182B9C4")]
		public static string ovr_CloudStorage2UserDirectoryPathResponse_GetPath(IntPtr obj)
		{
			return null;
		}

		[PreserveSig]
		[Token(Token = "0x600021D")]
		[Address(RVA = "0x182BA2C", Offset = "0x182BA2C", VA = "0x182BA2C")]
		private static extern IntPtr ovr_CloudStorage2UserDirectoryPathResponse_GetPath_Native(IntPtr obj);

		[PreserveSig]
		[Token(Token = "0x600021E")]
		[Address(RVA = "0x182BAAC", Offset = "0x182BAAC", VA = "0x182BAAC")]
		public static extern IntPtr ovr_CloudStorageConflictMetadata_GetLocal(IntPtr obj);

		[PreserveSig]
		[Token(Token = "0x600021F")]
		[Address(RVA = "0x182BB2C", Offset = "0x182BB2C", VA = "0x182BB2C")]
		public static extern IntPtr ovr_CloudStorageConflictMetadata_GetRemote(IntPtr obj);

		[Token(Token = "0x6000220")]
		[Address(RVA = "0x182BBAC", Offset = "0x182BBAC", VA = "0x182BBAC")]
		public static string ovr_CloudStorageData_GetBucket(IntPtr obj)
		{
			return null;
		}

		[PreserveSig]
		[Token(Token = "0x6000221")]
		[Address(RVA = "0x182BC14", Offset = "0x182BC14", VA = "0x182BC14")]
		private static extern IntPtr ovr_CloudStorageData_GetBucket_Native(IntPtr obj);

		[Token(Token = "0x6000222")]
		[Address(RVA = "0x182BC94", Offset = "0x182BC94", VA = "0x182BC94")]
		public static byte[] ovr_CloudStorageData_GetData(IntPtr obj)
		{
			return null;
		}

		[PreserveSig]
		[Token(Token = "0x6000223")]
		[Address(RVA = "0x182BD90", Offset = "0x182BD90", VA = "0x182BD90")]
		private static extern IntPtr ovr_CloudStorageData_GetData_Native(IntPtr obj);

		[PreserveSig]
		[Token(Token = "0x6000224")]
		[Address(RVA = "0x182BD10", Offset = "0x182BD10", VA = "0x182BD10")]
		public static extern uint ovr_CloudStorageData_GetDataSize(IntPtr obj);

		[Token(Token = "0x6000225")]
		[Address(RVA = "0x182BE10", Offset = "0x182BE10", VA = "0x182BE10")]
		public static string ovr_CloudStorageData_GetKey(IntPtr obj)
		{
			return null;
		}

		[PreserveSig]
		[Token(Token = "0x6000226")]
		[Address(RVA = "0x182BE78", Offset = "0x182BE78", VA = "0x182BE78")]
		private static extern IntPtr ovr_CloudStorageData_GetKey_Native(IntPtr obj);

		[Token(Token = "0x6000227")]
		[Address(RVA = "0x182BEF8", Offset = "0x182BEF8", VA = "0x182BEF8")]
		public static string ovr_CloudStorageMetadata_GetBucket(IntPtr obj)
		{
			return null;
		}

		[PreserveSig]
		[Token(Token = "0x6000228")]
		[Address(RVA = "0x182BF60", Offset = "0x182BF60", VA = "0x182BF60")]
		private static extern IntPtr ovr_CloudStorageMetadata_GetBucket_Native(IntPtr obj);

		[PreserveSig]
		[Token(Token = "0x6000229")]
		[Address(RVA = "0x182BFE0", Offset = "0x182BFE0", VA = "0x182BFE0")]
		public static extern long ovr_CloudStorageMetadata_GetCounter(IntPtr obj);

		[PreserveSig]
		[Token(Token = "0x600022A")]
		[Address(RVA = "0x182C060", Offset = "0x182C060", VA = "0x182C060")]
		public static extern uint ovr_CloudStorageMetadata_GetDataSize(IntPtr obj);

		[Token(Token = "0x600022B")]
		[Address(RVA = "0x182C0E0", Offset = "0x182C0E0", VA = "0x182C0E0")]
		public static string ovr_CloudStorageMetadata_GetExtraData(IntPtr obj)
		{
			return null;
		}

		[PreserveSig]
		[Token(Token = "0x600022C")]
		[Address(RVA = "0x182C148", Offset = "0x182C148", VA = "0x182C148")]
		private static extern IntPtr ovr_CloudStorageMetadata_GetExtraData_Native(IntPtr obj);

		[Token(Token = "0x600022D")]
		[Address(RVA = "0x182C1C8", Offset = "0x182C1C8", VA = "0x182C1C8")]
		public static string ovr_CloudStorageMetadata_GetKey(IntPtr obj)
		{
			return null;
		}

		[PreserveSig]
		[Token(Token = "0x600022E")]
		[Address(RVA = "0x182C230", Offset = "0x182C230", VA = "0x182C230")]
		private static extern IntPtr ovr_CloudStorageMetadata_GetKey_Native(IntPtr obj);

		[PreserveSig]
		[Token(Token = "0x600022F")]
		[Address(RVA = "0x182C2B0", Offset = "0x182C2B0", VA = "0x182C2B0")]
		public static extern ulong ovr_CloudStorageMetadata_GetSaveTime(IntPtr obj);

		[PreserveSig]
		[Token(Token = "0x6000230")]
		[Address(RVA = "0x182C330", Offset = "0x182C330", VA = "0x182C330")]
		public static extern CloudStorageDataStatus ovr_CloudStorageMetadata_GetStatus(IntPtr obj);

		[Token(Token = "0x6000231")]
		[Address(RVA = "0x182C3B0", Offset = "0x182C3B0", VA = "0x182C3B0")]
		public static string ovr_CloudStorageMetadata_GetVersionHandle(IntPtr obj)
		{
			return null;
		}

		[PreserveSig]
		[Token(Token = "0x6000232")]
		[Address(RVA = "0x182C418", Offset = "0x182C418", VA = "0x182C418")]
		private static extern IntPtr ovr_CloudStorageMetadata_GetVersionHandle_Native(IntPtr obj);

		[PreserveSig]
		[Token(Token = "0x6000233")]
		[Address(RVA = "0x182C498", Offset = "0x182C498", VA = "0x182C498")]
		public static extern IntPtr ovr_CloudStorageMetadataArray_GetElement(IntPtr obj, UIntPtr index);

		[Token(Token = "0x6000234")]
		[Address(RVA = "0x182C528", Offset = "0x182C528", VA = "0x182C528")]
		public static string ovr_CloudStorageMetadataArray_GetNextUrl(IntPtr obj)
		{
			return null;
		}

		[PreserveSig]
		[Token(Token = "0x6000235")]
		[Address(RVA = "0x182C590", Offset = "0x182C590", VA = "0x182C590")]
		private static extern IntPtr ovr_CloudStorageMetadataArray_GetNextUrl_Native(IntPtr obj);

		[PreserveSig]
		[Token(Token = "0x6000236")]
		[Address(RVA = "0x182C610", Offset = "0x182C610", VA = "0x182C610")]
		public static extern UIntPtr ovr_CloudStorageMetadataArray_GetSize(IntPtr obj);

		[PreserveSig]
		[Token(Token = "0x6000237")]
		[Address(RVA = "0x182C690", Offset = "0x182C690", VA = "0x182C690")]
		public static extern bool ovr_CloudStorageMetadataArray_HasNextPage(IntPtr obj);

		[Token(Token = "0x6000238")]
		[Address(RVA = "0x182C718", Offset = "0x182C718", VA = "0x182C718")]
		public static string ovr_CloudStorageUpdateResponse_GetBucket(IntPtr obj)
		{
			return null;
		}

		[PreserveSig]
		[Token(Token = "0x6000239")]
		[Address(RVA = "0x182C780", Offset = "0x182C780", VA = "0x182C780")]
		private static extern IntPtr ovr_CloudStorageUpdateResponse_GetBucket_Native(IntPtr obj);

		[Token(Token = "0x600023A")]
		[Address(RVA = "0x182C800", Offset = "0x182C800", VA = "0x182C800")]
		public static string ovr_CloudStorageUpdateResponse_GetKey(IntPtr obj)
		{
			return null;
		}

		[PreserveSig]
		[Token(Token = "0x600023B")]
		[Address(RVA = "0x182C868", Offset = "0x182C868", VA = "0x182C868")]
		private static extern IntPtr ovr_CloudStorageUpdateResponse_GetKey_Native(IntPtr obj);

		[PreserveSig]
		[Token(Token = "0x600023C")]
		[Address(RVA = "0x182C8E8", Offset = "0x182C8E8", VA = "0x182C8E8")]
		public static extern CloudStorageUpdateStatus ovr_CloudStorageUpdateResponse_GetStatus(IntPtr obj);

		[Token(Token = "0x600023D")]
		[Address(RVA = "0x182C968", Offset = "0x182C968", VA = "0x182C968")]
		public static string ovr_CloudStorageUpdateResponse_GetVersionHandle(IntPtr obj)
		{
			return null;
		}

		[PreserveSig]
		[Token(Token = "0x600023E")]
		[Address(RVA = "0x182C9D0", Offset = "0x182C9D0", VA = "0x182C9D0")]
		private static extern IntPtr ovr_CloudStorageUpdateResponse_GetVersionHandle_Native(IntPtr obj);

		[Token(Token = "0x600023F")]
		[Address(RVA = "0x182CA50", Offset = "0x182CA50", VA = "0x182CA50")]
		public static uint ovr_DataStore_Contains(IntPtr obj, string key)
		{
			return default(uint);
		}

		[PreserveSig]
		[Token(Token = "0x6000240")]
		[Address(RVA = "0x182CB0C", Offset = "0x182CB0C", VA = "0x182CB0C")]
		private static extern uint ovr_DataStore_Contains_Native(IntPtr obj, IntPtr key);

		[Token(Token = "0x6000241")]
		[Address(RVA = "0x18201D4", Offset = "0x18201D4", VA = "0x18201D4")]
		public static string ovr_DataStore_GetKey(IntPtr obj, int index)
		{
			return null;
		}

		[PreserveSig]
		[Token(Token = "0x6000242")]
		[Address(RVA = "0x182CB9C", Offset = "0x182CB9C", VA = "0x182CB9C")]
		private static extern IntPtr ovr_DataStore_GetKey_Native(IntPtr obj, int index);

		[PreserveSig]
		[Token(Token = "0x6000243")]
		[Address(RVA = "0x1820154", Offset = "0x1820154", VA = "0x1820154")]
		public static extern UIntPtr ovr_DataStore_GetNumKeys(IntPtr obj);

		[Token(Token = "0x6000244")]
		[Address(RVA = "0x182024C", Offset = "0x182024C", VA = "0x182024C")]
		public static string ovr_DataStore_GetValue(IntPtr obj, string key)
		{
			return null;
		}

		[PreserveSig]
		[Token(Token = "0x6000245")]
		[Address(RVA = "0x182CC2C", Offset = "0x182CC2C", VA = "0x182CC2C")]
		private static extern IntPtr ovr_DataStore_GetValue_Native(IntPtr obj, IntPtr key);

		[PreserveSig]
		[Token(Token = "0x6000246")]
		[Address(RVA = "0x182CCBC", Offset = "0x182CCBC", VA = "0x182CCBC")]
		public static extern int ovr_Error_GetCode(IntPtr obj);

		[Token(Token = "0x6000247")]
		[Address(RVA = "0x182CD38", Offset = "0x182CD38", VA = "0x182CD38")]
		public static string ovr_Error_GetDisplayableMessage(IntPtr obj)
		{
			return null;
		}

		[PreserveSig]
		[Token(Token = "0x6000248")]
		[Address(RVA = "0x182CDA0", Offset = "0x182CDA0", VA = "0x182CDA0")]
		private static extern IntPtr ovr_Error_GetDisplayableMessage_Native(IntPtr obj);

		[PreserveSig]
		[Token(Token = "0x6000249")]
		[Address(RVA = "0x182CE20", Offset = "0x182CE20", VA = "0x182CE20")]
		public static extern int ovr_Error_GetHttpCode(IntPtr obj);

		[Token(Token = "0x600024A")]
		[Address(RVA = "0x182CEA0", Offset = "0x182CEA0", VA = "0x182CEA0")]
		public static string ovr_Error_GetMessage(IntPtr obj)
		{
			return null;
		}

		[PreserveSig]
		[Token(Token = "0x600024B")]
		[Address(RVA = "0x182CF08", Offset = "0x182CF08", VA = "0x182CF08")]
		private static extern IntPtr ovr_Error_GetMessage_Native(IntPtr obj);

		[PreserveSig]
		[Token(Token = "0x600024C")]
		[Address(RVA = "0x182CF88", Offset = "0x182CF88", VA = "0x182CF88")]
		public static extern IntPtr ovr_HttpTransferUpdate_GetBytes(IntPtr obj);

		[PreserveSig]
		[Token(Token = "0x600024D")]
		[Address(RVA = "0x182D008", Offset = "0x182D008", VA = "0x182D008")]
		public static extern ulong ovr_HttpTransferUpdate_GetID(IntPtr obj);

		[PreserveSig]
		[Token(Token = "0x600024E")]
		[Address(RVA = "0x182D088", Offset = "0x182D088", VA = "0x182D088")]
		public static extern UIntPtr ovr_HttpTransferUpdate_GetSize(IntPtr obj);

		[PreserveSig]
		[Token(Token = "0x600024F")]
		[Address(RVA = "0x182D108", Offset = "0x182D108", VA = "0x182D108")]
		public static extern bool ovr_HttpTransferUpdate_IsCompleted(IntPtr obj);

		[Token(Token = "0x6000250")]
		[Address(RVA = "0x182D190", Offset = "0x182D190", VA = "0x182D190")]
		public static string ovr_InstalledApplication_GetApplicationId(IntPtr obj)
		{
			return null;
		}

		[PreserveSig]
		[Token(Token = "0x6000251")]
		[Address(RVA = "0x182D1F8", Offset = "0x182D1F8", VA = "0x182D1F8")]
		private static extern IntPtr ovr_InstalledApplication_GetApplicationId_Native(IntPtr obj);

		[Token(Token = "0x6000252")]
		[Address(RVA = "0x182D278", Offset = "0x182D278", VA = "0x182D278")]
		public static string ovr_InstalledApplication_GetPackageName(IntPtr obj)
		{
			return null;
		}

		[PreserveSig]
		[Token(Token = "0x6000253")]
		[Address(RVA = "0x182D2E0", Offset = "0x182D2E0", VA = "0x182D2E0")]
		private static extern IntPtr ovr_InstalledApplication_GetPackageName_Native(IntPtr obj);

		[Token(Token = "0x6000254")]
		[Address(RVA = "0x182D360", Offset = "0x182D360", VA = "0x182D360")]
		public static string ovr_InstalledApplication_GetStatus(IntPtr obj)
		{
			return null;
		}

		[PreserveSig]
		[Token(Token = "0x6000255")]
		[Address(RVA = "0x182D3C8", Offset = "0x182D3C8", VA = "0x182D3C8")]
		private static extern IntPtr ovr_InstalledApplication_GetStatus_Native(IntPtr obj);

		[PreserveSig]
		[Token(Token = "0x6000256")]
		[Address(RVA = "0x182D448", Offset = "0x182D448", VA = "0x182D448")]
		public static extern int ovr_InstalledApplication_GetVersionCode(IntPtr obj);

		[Token(Token = "0x6000257")]
		[Address(RVA = "0x182D4C8", Offset = "0x182D4C8", VA = "0x182D4C8")]
		public static string ovr_InstalledApplication_GetVersionName(IntPtr obj)
		{
			return null;
		}

		[PreserveSig]
		[Token(Token = "0x6000258")]
		[Address(RVA = "0x182D530", Offset = "0x182D530", VA = "0x182D530")]
		private static extern IntPtr ovr_InstalledApplication_GetVersionName_Native(IntPtr obj);

		[PreserveSig]
		[Token(Token = "0x6000259")]
		[Address(RVA = "0x182D5B0", Offset = "0x182D5B0", VA = "0x182D5B0")]
		public static extern IntPtr ovr_InstalledApplicationArray_GetElement(IntPtr obj, UIntPtr index);

		[PreserveSig]
		[Token(Token = "0x600025A")]
		[Address(RVA = "0x182D640", Offset = "0x182D640", VA = "0x182D640")]
		public static extern UIntPtr ovr_InstalledApplicationArray_GetSize(IntPtr obj);

		[Token(Token = "0x600025B")]
		[Address(RVA = "0x182D6C0", Offset = "0x182D6C0", VA = "0x182D6C0")]
		public static string ovr_LanguagePackInfo_GetEnglishName(IntPtr obj)
		{
			return null;
		}

		[PreserveSig]
		[Token(Token = "0x600025C")]
		[Address(RVA = "0x182D728", Offset = "0x182D728", VA = "0x182D728")]
		private static extern IntPtr ovr_LanguagePackInfo_GetEnglishName_Native(IntPtr obj);

		[Token(Token = "0x600025D")]
		[Address(RVA = "0x182D7A8", Offset = "0x182D7A8", VA = "0x182D7A8")]
		public static string ovr_LanguagePackInfo_GetNativeName(IntPtr obj)
		{
			return null;
		}

		[PreserveSig]
		[Token(Token = "0x600025E")]
		[Address(RVA = "0x182D810", Offset = "0x182D810", VA = "0x182D810")]
		private static extern IntPtr ovr_LanguagePackInfo_GetNativeName_Native(IntPtr obj);

		[Token(Token = "0x600025F")]
		[Address(RVA = "0x182D890", Offset = "0x182D890", VA = "0x182D890")]
		public static string ovr_LanguagePackInfo_GetTag(IntPtr obj)
		{
			return null;
		}

		[PreserveSig]
		[Token(Token = "0x6000260")]
		[Address(RVA = "0x182D8F8", Offset = "0x182D8F8", VA = "0x182D8F8")]
		private static extern IntPtr ovr_LanguagePackInfo_GetTag_Native(IntPtr obj);

		[PreserveSig]
		[Token(Token = "0x6000261")]
		[Address(RVA = "0x182D978", Offset = "0x182D978", VA = "0x182D978")]
		public static extern bool ovr_LaunchBlockFlowResult_GetDidBlock(IntPtr obj);

		[PreserveSig]
		[Token(Token = "0x6000262")]
		[Address(RVA = "0x182DA00", Offset = "0x182DA00", VA = "0x182DA00")]
		public static extern bool ovr_LaunchBlockFlowResult_GetDidCancel(IntPtr obj);

		[Token(Token = "0x6000263")]
		[Address(RVA = "0x182DA88", Offset = "0x182DA88", VA = "0x182DA88")]
		public static string ovr_LaunchDetails_GetDeeplinkMessage(IntPtr obj)
		{
			return null;
		}

		[PreserveSig]
		[Token(Token = "0x6000264")]
		[Address(RVA = "0x182DAF0", Offset = "0x182DAF0", VA = "0x182DAF0")]
		private static extern IntPtr ovr_LaunchDetails_GetDeeplinkMessage_Native(IntPtr obj);

		[Token(Token = "0x6000265")]
		[Address(RVA = "0x182DB70", Offset = "0x182DB70", VA = "0x182DB70")]
		public static string ovr_LaunchDetails_GetLaunchSource(IntPtr obj)
		{
			return null;
		}

		[PreserveSig]
		[Token(Token = "0x6000266")]
		[Address(RVA = "0x182DBD8", Offset = "0x182DBD8", VA = "0x182DBD8")]
		private static extern IntPtr ovr_LaunchDetails_GetLaunchSource_Native(IntPtr obj);

		[PreserveSig]
		[Token(Token = "0x6000267")]
		[Address(RVA = "0x182DC58", Offset = "0x182DC58", VA = "0x182DC58")]
		public static extern LaunchType ovr_LaunchDetails_GetLaunchType(IntPtr obj);

		[PreserveSig]
		[Token(Token = "0x6000268")]
		[Address(RVA = "0x182DCD8", Offset = "0x182DCD8", VA = "0x182DCD8")]
		public static extern ulong ovr_LaunchDetails_GetRoomID(IntPtr obj);

		[PreserveSig]
		[Token(Token = "0x6000269")]
		[Address(RVA = "0x182DD58", Offset = "0x182DD58", VA = "0x182DD58")]
		public static extern IntPtr ovr_LaunchDetails_GetUsers(IntPtr obj);

		[PreserveSig]
		[Token(Token = "0x600026A")]
		[Address(RVA = "0x182DDD8", Offset = "0x182DDD8", VA = "0x182DDD8")]
		public static extern bool ovr_LaunchFriendRequestFlowResult_GetDidCancel(IntPtr obj);

		[PreserveSig]
		[Token(Token = "0x600026B")]
		[Address(RVA = "0x182DE60", Offset = "0x182DE60", VA = "0x182DE60")]
		public static extern bool ovr_LaunchFriendRequestFlowResult_GetDidSendRequest(IntPtr obj);

		[PreserveSig]
		[Token(Token = "0x600026C")]
		[Address(RVA = "0x182DEE8", Offset = "0x182DEE8", VA = "0x182DEE8")]
		public static extern bool ovr_LaunchReportFlowResult_GetDidCancel(IntPtr obj);

		[PreserveSig]
		[Token(Token = "0x600026D")]
		[Address(RVA = "0x182DF70", Offset = "0x182DF70", VA = "0x182DF70")]
		public static extern ulong ovr_LaunchReportFlowResult_GetUserReportId(IntPtr obj);

		[PreserveSig]
		[Token(Token = "0x600026E")]
		[Address(RVA = "0x182DFF0", Offset = "0x182DFF0", VA = "0x182DFF0")]
		public static extern bool ovr_LaunchUnblockFlowResult_GetDidCancel(IntPtr obj);

		[PreserveSig]
		[Token(Token = "0x600026F")]
		[Address(RVA = "0x182E078", Offset = "0x182E078", VA = "0x182E078")]
		public static extern bool ovr_LaunchUnblockFlowResult_GetDidUnblock(IntPtr obj);

		[Token(Token = "0x6000270")]
		[Address(RVA = "0x182E100", Offset = "0x182E100", VA = "0x182E100")]
		public static byte[] ovr_LeaderboardEntry_GetExtraData(IntPtr obj)
		{
			return null;
		}

		[PreserveSig]
		[Token(Token = "0x6000271")]
		[Address(RVA = "0x182E1FC", Offset = "0x182E1FC", VA = "0x182E1FC")]
		private static extern IntPtr ovr_LeaderboardEntry_GetExtraData_Native(IntPtr obj);

		[PreserveSig]
		[Token(Token = "0x6000272")]
		[Address(RVA = "0x182E17C", Offset = "0x182E17C", VA = "0x182E17C")]
		public static extern uint ovr_LeaderboardEntry_GetExtraDataLength(IntPtr obj);

		[PreserveSig]
		[Token(Token = "0x6000273")]
		[Address(RVA = "0x182E27C", Offset = "0x182E27C", VA = "0x182E27C")]
		public static extern int ovr_LeaderboardEntry_GetRank(IntPtr obj);

		[PreserveSig]
		[Token(Token = "0x6000274")]
		[Address(RVA = "0x182E2FC", Offset = "0x182E2FC", VA = "0x182E2FC")]
		public static extern long ovr_LeaderboardEntry_GetScore(IntPtr obj);

		[Token(Token = "0x6000275")]
		[Address(RVA = "0x182E37C", Offset = "0x182E37C", VA = "0x182E37C")]
		public static DateTime ovr_LeaderboardEntry_GetTimestamp(IntPtr obj)
		{
			return default(DateTime);
		}

		[PreserveSig]
		[Token(Token = "0x6000276")]
		[Address(RVA = "0x182E3E4", Offset = "0x182E3E4", VA = "0x182E3E4")]
		private static extern ulong ovr_LeaderboardEntry_GetTimestamp_Native(IntPtr obj);

		[PreserveSig]
		[Token(Token = "0x6000277")]
		[Address(RVA = "0x182E464", Offset = "0x182E464", VA = "0x182E464")]
		public static extern IntPtr ovr_LeaderboardEntry_GetUser(IntPtr obj);

		[PreserveSig]
		[Token(Token = "0x6000278")]
		[Address(RVA = "0x182E4E4", Offset = "0x182E4E4", VA = "0x182E4E4")]
		public static extern IntPtr ovr_LeaderboardEntryArray_GetElement(IntPtr obj, UIntPtr index);

		[Token(Token = "0x6000279")]
		[Address(RVA = "0x182E574", Offset = "0x182E574", VA = "0x182E574")]
		public static string ovr_LeaderboardEntryArray_GetNextUrl(IntPtr obj)
		{
			return null;
		}

		[PreserveSig]
		[Token(Token = "0x600027A")]
		[Address(RVA = "0x182E5DC", Offset = "0x182E5DC", VA = "0x182E5DC")]
		private static extern IntPtr ovr_LeaderboardEntryArray_GetNextUrl_Native(IntPtr obj);

		[Token(Token = "0x600027B")]
		[Address(RVA = "0x182E65C", Offset = "0x182E65C", VA = "0x182E65C")]
		public static string ovr_LeaderboardEntryArray_GetPreviousUrl(IntPtr obj)
		{
			return null;
		}

		[PreserveSig]
		[Token(Token = "0x600027C")]
		[Address(RVA = "0x182E6C4", Offset = "0x182E6C4", VA = "0x182E6C4")]
		private static extern IntPtr ovr_LeaderboardEntryArray_GetPreviousUrl_Native(IntPtr obj);

		[PreserveSig]
		[Token(Token = "0x600027D")]
		[Address(RVA = "0x182E744", Offset = "0x182E744", VA = "0x182E744")]
		public static extern UIntPtr ovr_LeaderboardEntryArray_GetSize(IntPtr obj);

		[PreserveSig]
		[Token(Token = "0x600027E")]
		[Address(RVA = "0x182E7C4", Offset = "0x182E7C4", VA = "0x182E7C4")]
		public static extern ulong ovr_LeaderboardEntryArray_GetTotalCount(IntPtr obj);

		[PreserveSig]
		[Token(Token = "0x600027F")]
		[Address(RVA = "0x182E844", Offset = "0x182E844", VA = "0x182E844")]
		public static extern bool ovr_LeaderboardEntryArray_HasNextPage(IntPtr obj);

		[PreserveSig]
		[Token(Token = "0x6000280")]
		[Address(RVA = "0x182E8CC", Offset = "0x182E8CC", VA = "0x182E8CC")]
		public static extern bool ovr_LeaderboardEntryArray_HasPreviousPage(IntPtr obj);

		[PreserveSig]
		[Token(Token = "0x6000281")]
		[Address(RVA = "0x182E954", Offset = "0x182E954", VA = "0x182E954")]
		public static extern bool ovr_LeaderboardUpdateStatus_GetDidUpdate(IntPtr obj);

		[Token(Token = "0x6000282")]
		[Address(RVA = "0x182E9DC", Offset = "0x182E9DC", VA = "0x182E9DC")]
		public static string ovr_LinkedAccount_GetAccessToken(IntPtr obj)
		{
			return null;
		}

		[PreserveSig]
		[Token(Token = "0x6000283")]
		[Address(RVA = "0x182EA44", Offset = "0x182EA44", VA = "0x182EA44")]
		private static extern IntPtr ovr_LinkedAccount_GetAccessToken_Native(IntPtr obj);

		[PreserveSig]
		[Token(Token = "0x6000284")]
		[Address(RVA = "0x182EAC4", Offset = "0x182EAC4", VA = "0x182EAC4")]
		public static extern ServiceProvider ovr_LinkedAccount_GetServiceProvider(IntPtr obj);

		[Token(Token = "0x6000285")]
		[Address(RVA = "0x182EB44", Offset = "0x182EB44", VA = "0x182EB44")]
		public static string ovr_LinkedAccount_GetUserId(IntPtr obj)
		{
			return null;
		}

		[PreserveSig]
		[Token(Token = "0x6000286")]
		[Address(RVA = "0x182EBAC", Offset = "0x182EBAC", VA = "0x182EBAC")]
		private static extern IntPtr ovr_LinkedAccount_GetUserId_Native(IntPtr obj);

		[PreserveSig]
		[Token(Token = "0x6000287")]
		[Address(RVA = "0x182EC2C", Offset = "0x182EC2C", VA = "0x182EC2C")]
		public static extern IntPtr ovr_LinkedAccountArray_GetElement(IntPtr obj, UIntPtr index);

		[PreserveSig]
		[Token(Token = "0x6000288")]
		[Address(RVA = "0x182ECBC", Offset = "0x182ECBC", VA = "0x182ECBC")]
		public static extern UIntPtr ovr_LinkedAccountArray_GetSize(IntPtr obj);

		[PreserveSig]
		[Token(Token = "0x6000289")]
		[Address(RVA = "0x182ED3C", Offset = "0x182ED3C", VA = "0x182ED3C")]
		public static extern bool ovr_LivestreamingApplicationStatus_GetStreamingEnabled(IntPtr obj);

		[PreserveSig]
		[Token(Token = "0x600028A")]
		[Address(RVA = "0x182EDC4", Offset = "0x182EDC4", VA = "0x182EDC4")]
		public static extern LivestreamingStartStatus ovr_LivestreamingStartResult_GetStreamingResult(IntPtr obj);

		[PreserveSig]
		[Token(Token = "0x600028B")]
		[Address(RVA = "0x182EE44", Offset = "0x182EE44", VA = "0x182EE44")]
		public static extern bool ovr_LivestreamingStatus_GetCommentsVisible(IntPtr obj);

		[PreserveSig]
		[Token(Token = "0x600028C")]
		[Address(RVA = "0x182EECC", Offset = "0x182EECC", VA = "0x182EECC")]
		public static extern bool ovr_LivestreamingStatus_GetIsPaused(IntPtr obj);

		[PreserveSig]
		[Token(Token = "0x600028D")]
		[Address(RVA = "0x182EF54", Offset = "0x182EF54", VA = "0x182EF54")]
		public static extern bool ovr_LivestreamingStatus_GetLivestreamingEnabled(IntPtr obj);

		[PreserveSig]
		[Token(Token = "0x600028E")]
		[Address(RVA = "0x182EFDC", Offset = "0x182EFDC", VA = "0x182EFDC")]
		public static extern int ovr_LivestreamingStatus_GetLivestreamingType(IntPtr obj);

		[PreserveSig]
		[Token(Token = "0x600028F")]
		[Address(RVA = "0x182F05C", Offset = "0x182F05C", VA = "0x182F05C")]
		public static extern bool ovr_LivestreamingStatus_GetMicEnabled(IntPtr obj);

		[PreserveSig]
		[Token(Token = "0x6000290")]
		[Address(RVA = "0x182F0E4", Offset = "0x182F0E4", VA = "0x182F0E4")]
		public static extern int ovr_LivestreamingVideoStats_GetCommentCount(IntPtr obj);

		[PreserveSig]
		[Token(Token = "0x6000291")]
		[Address(RVA = "0x182F164", Offset = "0x182F164", VA = "0x182F164")]
		public static extern int ovr_LivestreamingVideoStats_GetReactionCount(IntPtr obj);

		[Token(Token = "0x6000292")]
		[Address(RVA = "0x182F1E4", Offset = "0x182F1E4", VA = "0x182F1E4")]
		public static string ovr_LivestreamingVideoStats_GetTotalViews(IntPtr obj)
		{
			return null;
		}

		[PreserveSig]
		[Token(Token = "0x6000293")]
		[Address(RVA = "0x182F24C", Offset = "0x182F24C", VA = "0x182F24C")]
		private static extern IntPtr ovr_LivestreamingVideoStats_GetTotalViews_Native(IntPtr obj);

		[PreserveSig]
		[Token(Token = "0x6000294")]
		[Address(RVA = "0x182F2CC", Offset = "0x182F2CC", VA = "0x182F2CC")]
		public static extern IntPtr ovr_MatchmakingAdminSnapshot_GetCandidates(IntPtr obj);

		[PreserveSig]
		[Token(Token = "0x6000295")]
		[Address(RVA = "0x182F34C", Offset = "0x182F34C", VA = "0x182F34C")]
		public static extern double ovr_MatchmakingAdminSnapshot_GetMyCurrentThreshold(IntPtr obj);

		[PreserveSig]
		[Token(Token = "0x6000296")]
		[Address(RVA = "0x182F3CC", Offset = "0x182F3CC", VA = "0x182F3CC")]
		public static extern bool ovr_MatchmakingAdminSnapshotCandidate_GetCanMatch(IntPtr obj);

		[PreserveSig]
		[Token(Token = "0x6000297")]
		[Address(RVA = "0x182F454", Offset = "0x182F454", VA = "0x182F454")]
		public static extern double ovr_MatchmakingAdminSnapshotCandidate_GetMyTotalScore(IntPtr obj);

		[PreserveSig]
		[Token(Token = "0x6000298")]
		[Address(RVA = "0x182F4D4", Offset = "0x182F4D4", VA = "0x182F4D4")]
		public static extern double ovr_MatchmakingAdminSnapshotCandidate_GetTheirCurrentThreshold(IntPtr obj);

		[PreserveSig]
		[Token(Token = "0x6000299")]
		[Address(RVA = "0x182F554", Offset = "0x182F554", VA = "0x182F554")]
		public static extern double ovr_MatchmakingAdminSnapshotCandidate_GetTheirTotalScore(IntPtr obj);

		[Token(Token = "0x600029A")]
		[Address(RVA = "0x182F5D4", Offset = "0x182F5D4", VA = "0x182F5D4")]
		public static string ovr_MatchmakingAdminSnapshotCandidate_GetTraceId(IntPtr obj)
		{
			return null;
		}

		[PreserveSig]
		[Token(Token = "0x600029B")]
		[Address(RVA = "0x182F63C", Offset = "0x182F63C", VA = "0x182F63C")]
		private static extern IntPtr ovr_MatchmakingAdminSnapshotCandidate_GetTraceId_Native(IntPtr obj);

		[PreserveSig]
		[Token(Token = "0x600029C")]
		[Address(RVA = "0x182F6BC", Offset = "0x182F6BC", VA = "0x182F6BC")]
		public static extern IntPtr ovr_MatchmakingAdminSnapshotCandidateArray_GetElement(IntPtr obj, UIntPtr index);

		[PreserveSig]
		[Token(Token = "0x600029D")]
		[Address(RVA = "0x182F74C", Offset = "0x182F74C", VA = "0x182F74C")]
		public static extern UIntPtr ovr_MatchmakingAdminSnapshotCandidateArray_GetSize(IntPtr obj);

		[PreserveSig]
		[Token(Token = "0x600029E")]
		[Address(RVA = "0x182F7CC", Offset = "0x182F7CC", VA = "0x182F7CC")]
		public static extern IntPtr ovr_MatchmakingBrowseResult_GetEnqueueResult(IntPtr obj);

		[PreserveSig]
		[Token(Token = "0x600029F")]
		[Address(RVA = "0x182F84C", Offset = "0x182F84C", VA = "0x182F84C")]
		public static extern IntPtr ovr_MatchmakingBrowseResult_GetRooms(IntPtr obj);

		[Token(Token = "0x60002A0")]
		[Address(RVA = "0x182F8CC", Offset = "0x182F8CC", VA = "0x182F8CC")]
		public static string ovr_MatchmakingCandidate_GetEntryHash(IntPtr obj)
		{
			return null;
		}

		[PreserveSig]
		[Token(Token = "0x60002A1")]
		[Address(RVA = "0x182F934", Offset = "0x182F934", VA = "0x182F934")]
		private static extern IntPtr ovr_MatchmakingCandidate_GetEntryHash_Native(IntPtr obj);

		[PreserveSig]
		[Token(Token = "0x60002A2")]
		[Address(RVA = "0x182F9B4", Offset = "0x182F9B4", VA = "0x182F9B4")]
		public static extern ulong ovr_MatchmakingCandidate_GetUserId(IntPtr obj);

		[PreserveSig]
		[Token(Token = "0x60002A3")]
		[Address(RVA = "0x182FA34", Offset = "0x182FA34", VA = "0x182FA34")]
		public static extern IntPtr ovr_MatchmakingCandidateArray_GetElement(IntPtr obj, UIntPtr index);

		[Token(Token = "0x60002A4")]
		[Address(RVA = "0x182FAC4", Offset = "0x182FAC4", VA = "0x182FAC4")]
		public static string ovr_MatchmakingCandidateArray_GetNextUrl(IntPtr obj)
		{
			return null;
		}

		[PreserveSig]
		[Token(Token = "0x60002A5")]
		[Address(RVA = "0x182FB2C", Offset = "0x182FB2C", VA = "0x182FB2C")]
		private static extern IntPtr ovr_MatchmakingCandidateArray_GetNextUrl_Native(IntPtr obj);

		[PreserveSig]
		[Token(Token = "0x60002A6")]
		[Address(RVA = "0x182FBAC", Offset = "0x182FBAC", VA = "0x182FBAC")]
		public static extern UIntPtr ovr_MatchmakingCandidateArray_GetSize(IntPtr obj);

		[PreserveSig]
		[Token(Token = "0x60002A7")]
		[Address(RVA = "0x182FC2C", Offset = "0x182FC2C", VA = "0x182FC2C")]
		public static extern bool ovr_MatchmakingCandidateArray_HasNextPage(IntPtr obj);

		[PreserveSig]
		[Token(Token = "0x60002A8")]
		[Address(RVA = "0x182FCB4", Offset = "0x182FCB4", VA = "0x182FCB4")]
		public static extern IntPtr ovr_MatchmakingEnqueueResult_GetAdminSnapshot(IntPtr obj);

		[PreserveSig]
		[Token(Token = "0x60002A9")]
		[Address(RVA = "0x182FD34", Offset = "0x182FD34", VA = "0x182FD34")]
		public static extern uint ovr_MatchmakingEnqueueResult_GetAverageWait(IntPtr obj);

		[PreserveSig]
		[Token(Token = "0x60002AA")]
		[Address(RVA = "0x182FDB4", Offset = "0x182FDB4", VA = "0x182FDB4")]
		public static extern uint ovr_MatchmakingEnqueueResult_GetMatchesInLastHourCount(IntPtr obj);

		[PreserveSig]
		[Token(Token = "0x60002AB")]
		[Address(RVA = "0x182FE34", Offset = "0x182FE34", VA = "0x182FE34")]
		public static extern uint ovr_MatchmakingEnqueueResult_GetMaxExpectedWait(IntPtr obj);

		[Token(Token = "0x60002AC")]
		[Address(RVA = "0x182FEB4", Offset = "0x182FEB4", VA = "0x182FEB4")]
		public static string ovr_MatchmakingEnqueueResult_GetPool(IntPtr obj)
		{
			return null;
		}

		[PreserveSig]
		[Token(Token = "0x60002AD")]
		[Address(RVA = "0x182FF1C", Offset = "0x182FF1C", VA = "0x182FF1C")]
		private static extern IntPtr ovr_MatchmakingEnqueueResult_GetPool_Native(IntPtr obj);

		[PreserveSig]
		[Token(Token = "0x60002AE")]
		[Address(RVA = "0x182FF9C", Offset = "0x182FF9C", VA = "0x182FF9C")]
		public static extern uint ovr_MatchmakingEnqueueResult_GetRecentMatchPercentage(IntPtr obj);

		[Token(Token = "0x60002AF")]
		[Address(RVA = "0x183001C", Offset = "0x183001C", VA = "0x183001C")]
		public static string ovr_MatchmakingEnqueueResult_GetRequestHash(IntPtr obj)
		{
			return null;
		}

		[PreserveSig]
		[Token(Token = "0x60002B0")]
		[Address(RVA = "0x1830084", Offset = "0x1830084", VA = "0x1830084")]
		private static extern IntPtr ovr_MatchmakingEnqueueResult_GetRequestHash_Native(IntPtr obj);

		[PreserveSig]
		[Token(Token = "0x60002B1")]
		[Address(RVA = "0x1830104", Offset = "0x1830104", VA = "0x1830104")]
		public static extern IntPtr ovr_MatchmakingEnqueueResultAndRoom_GetMatchmakingEnqueueResult(IntPtr obj);

		[PreserveSig]
		[Token(Token = "0x60002B2")]
		[Address(RVA = "0x1830184", Offset = "0x1830184", VA = "0x1830184")]
		public static extern IntPtr ovr_MatchmakingEnqueueResultAndRoom_GetRoom(IntPtr obj);

		[PreserveSig]
		[Token(Token = "0x60002B3")]
		[Address(RVA = "0x1830204", Offset = "0x1830204", VA = "0x1830204")]
		public static extern ulong ovr_MatchmakingEnqueuedUser_GetAdditionalUserID(IntPtr obj, uint index);

		[PreserveSig]
		[Token(Token = "0x60002B4")]
		[Address(RVA = "0x1830294", Offset = "0x1830294", VA = "0x1830294")]
		public static extern uint ovr_MatchmakingEnqueuedUser_GetAdditionalUserIDsSize(IntPtr obj);

		[PreserveSig]
		[Token(Token = "0x60002B5")]
		[Address(RVA = "0x1830314", Offset = "0x1830314", VA = "0x1830314")]
		public static extern IntPtr ovr_MatchmakingEnqueuedUser_GetCustomData(IntPtr obj);

		[PreserveSig]
		[Token(Token = "0x60002B6")]
		[Address(RVA = "0x1830394", Offset = "0x1830394", VA = "0x1830394")]
		public static extern IntPtr ovr_MatchmakingEnqueuedUser_GetUser(IntPtr obj);

		[PreserveSig]
		[Token(Token = "0x60002B7")]
		[Address(RVA = "0x1830414", Offset = "0x1830414", VA = "0x1830414")]
		public static extern IntPtr ovr_MatchmakingEnqueuedUserArray_GetElement(IntPtr obj, UIntPtr index);

		[PreserveSig]
		[Token(Token = "0x60002B8")]
		[Address(RVA = "0x18304A4", Offset = "0x18304A4", VA = "0x18304A4")]
		public static extern UIntPtr ovr_MatchmakingEnqueuedUserArray_GetSize(IntPtr obj);

		[PreserveSig]
		[Token(Token = "0x60002B9")]
		[Address(RVA = "0x1830524", Offset = "0x1830524", VA = "0x1830524")]
		public static extern ulong ovr_MatchmakingNotification_GetAddedByUserId(IntPtr obj);

		[PreserveSig]
		[Token(Token = "0x60002BA")]
		[Address(RVA = "0x18305A4", Offset = "0x18305A4", VA = "0x18305A4")]
		public static extern IntPtr ovr_MatchmakingNotification_GetRoom(IntPtr obj);

		[Token(Token = "0x60002BB")]
		[Address(RVA = "0x1830624", Offset = "0x1830624", VA = "0x1830624")]
		public static string ovr_MatchmakingNotification_GetTraceId(IntPtr obj)
		{
			return null;
		}

		[PreserveSig]
		[Token(Token = "0x60002BC")]
		[Address(RVA = "0x183068C", Offset = "0x183068C", VA = "0x183068C")]
		private static extern IntPtr ovr_MatchmakingNotification_GetTraceId_Native(IntPtr obj);

		[PreserveSig]
		[Token(Token = "0x60002BD")]
		[Address(RVA = "0x183070C", Offset = "0x183070C", VA = "0x183070C")]
		public static extern uint ovr_MatchmakingRoom_GetPingTime(IntPtr obj);

		[PreserveSig]
		[Token(Token = "0x60002BE")]
		[Address(RVA = "0x183078C", Offset = "0x183078C", VA = "0x183078C")]
		public static extern IntPtr ovr_MatchmakingRoom_GetRoom(IntPtr obj);

		[PreserveSig]
		[Token(Token = "0x60002BF")]
		[Address(RVA = "0x183080C", Offset = "0x183080C", VA = "0x183080C")]
		public static extern bool ovr_MatchmakingRoom_HasPingTime(IntPtr obj);

		[PreserveSig]
		[Token(Token = "0x60002C0")]
		[Address(RVA = "0x1830894", Offset = "0x1830894", VA = "0x1830894")]
		public static extern IntPtr ovr_MatchmakingRoomArray_GetElement(IntPtr obj, UIntPtr index);

		[PreserveSig]
		[Token(Token = "0x60002C1")]
		[Address(RVA = "0x1830924", Offset = "0x1830924", VA = "0x1830924")]
		public static extern UIntPtr ovr_MatchmakingRoomArray_GetSize(IntPtr obj);

		[PreserveSig]
		[Token(Token = "0x60002C2")]
		[Address(RVA = "0x18309A4", Offset = "0x18309A4", VA = "0x18309A4")]
		public static extern uint ovr_MatchmakingStats_GetDrawCount(IntPtr obj);

		[PreserveSig]
		[Token(Token = "0x60002C3")]
		[Address(RVA = "0x1830A24", Offset = "0x1830A24", VA = "0x1830A24")]
		public static extern uint ovr_MatchmakingStats_GetLossCount(IntPtr obj);

		[PreserveSig]
		[Token(Token = "0x60002C4")]
		[Address(RVA = "0x1830AA4", Offset = "0x1830AA4", VA = "0x1830AA4")]
		public static extern uint ovr_MatchmakingStats_GetSkillLevel(IntPtr obj);

		[PreserveSig]
		[Token(Token = "0x60002C5")]
		[Address(RVA = "0x1830B24", Offset = "0x1830B24", VA = "0x1830B24")]
		public static extern uint ovr_MatchmakingStats_GetWinCount(IntPtr obj);

		[PreserveSig]
		[Token(Token = "0x60002C6")]
		[Address(RVA = "0x1830BA4", Offset = "0x1830BA4", VA = "0x1830BA4")]
		public static extern IntPtr ovr_Message_GetAbuseReportRecording(IntPtr obj);

		[PreserveSig]
		[Token(Token = "0x60002C7")]
		[Address(RVA = "0x1830C24", Offset = "0x1830C24", VA = "0x1830C24")]
		public static extern IntPtr ovr_Message_GetAchievementDefinitionArray(IntPtr obj);

		[PreserveSig]
		[Token(Token = "0x60002C8")]
		[Address(RVA = "0x1830CA4", Offset = "0x1830CA4", VA = "0x1830CA4")]
		public static extern IntPtr ovr_Message_GetAchievementProgressArray(IntPtr obj);

		[PreserveSig]
		[Token(Token = "0x60002C9")]
		[Address(RVA = "0x1830D24", Offset = "0x1830D24", VA = "0x1830D24")]
		public static extern IntPtr ovr_Message_GetAchievementUpdate(IntPtr obj);

		[PreserveSig]
		[Token(Token = "0x60002CA")]
		[Address(RVA = "0x1830DA4", Offset = "0x1830DA4", VA = "0x1830DA4")]
		public static extern IntPtr ovr_Message_GetApplicationVersion(IntPtr obj);

		[PreserveSig]
		[Token(Token = "0x60002CB")]
		[Address(RVA = "0x1830E24", Offset = "0x1830E24", VA = "0x1830E24")]
		public static extern IntPtr ovr_Message_GetAssetDetails(IntPtr obj);

		[PreserveSig]
		[Token(Token = "0x60002CC")]
		[Address(RVA = "0x1830EA4", Offset = "0x1830EA4", VA = "0x1830EA4")]
		public static extern IntPtr ovr_Message_GetAssetDetailsArray(IntPtr obj);

		[PreserveSig]
		[Token(Token = "0x60002CD")]
		[Address(RVA = "0x1830F24", Offset = "0x1830F24", VA = "0x1830F24")]
		public static extern IntPtr ovr_Message_GetAssetFileDeleteResult(IntPtr obj);

		[PreserveSig]
		[Token(Token = "0x60002CE")]
		[Address(RVA = "0x1830FA4", Offset = "0x1830FA4", VA = "0x1830FA4")]
		public static extern IntPtr ovr_Message_GetAssetFileDownloadCancelResult(IntPtr obj);

		[PreserveSig]
		[Token(Token = "0x60002CF")]
		[Address(RVA = "0x1831024", Offset = "0x1831024", VA = "0x1831024")]
		public static extern IntPtr ovr_Message_GetAssetFileDownloadResult(IntPtr obj);

		[PreserveSig]
		[Token(Token = "0x60002D0")]
		[Address(RVA = "0x18310A4", Offset = "0x18310A4", VA = "0x18310A4")]
		public static extern IntPtr ovr_Message_GetAssetFileDownloadUpdate(IntPtr obj);

		[PreserveSig]
		[Token(Token = "0x60002D1")]
		[Address(RVA = "0x1831124", Offset = "0x1831124", VA = "0x1831124")]
		public static extern IntPtr ovr_Message_GetCalApplicationFinalized(IntPtr obj);

		[PreserveSig]
		[Token(Token = "0x60002D2")]
		[Address(RVA = "0x18311A4", Offset = "0x18311A4", VA = "0x18311A4")]
		public static extern IntPtr ovr_Message_GetCalApplicationProposed(IntPtr obj);

		[PreserveSig]
		[Token(Token = "0x60002D3")]
		[Address(RVA = "0x1831224", Offset = "0x1831224", VA = "0x1831224")]
		public static extern IntPtr ovr_Message_GetCalApplicationSuggestionArray(IntPtr obj);

		[PreserveSig]
		[Token(Token = "0x60002D4")]
		[Address(RVA = "0x18312A4", Offset = "0x18312A4", VA = "0x18312A4")]
		public static extern IntPtr ovr_Message_GetCloudStorageConflictMetadata(IntPtr obj);

		[PreserveSig]
		[Token(Token = "0x60002D5")]
		[Address(RVA = "0x1831324", Offset = "0x1831324", VA = "0x1831324")]
		public static extern IntPtr ovr_Message_GetCloudStorageData(IntPtr obj);

		[PreserveSig]
		[Token(Token = "0x60002D6")]
		[Address(RVA = "0x18313A4", Offset = "0x18313A4", VA = "0x18313A4")]
		public static extern IntPtr ovr_Message_GetCloudStorageMetadata(IntPtr obj);

		[PreserveSig]
		[Token(Token = "0x60002D7")]
		[Address(RVA = "0x1831424", Offset = "0x1831424", VA = "0x1831424")]
		public static extern IntPtr ovr_Message_GetCloudStorageMetadataArray(IntPtr obj);

		[PreserveSig]
		[Token(Token = "0x60002D8")]
		[Address(RVA = "0x18314A4", Offset = "0x18314A4", VA = "0x18314A4")]
		public static extern IntPtr ovr_Message_GetCloudStorageUpdateResponse(IntPtr obj);

		[PreserveSig]
		[Token(Token = "0x60002D9")]
		[Address(RVA = "0x1831524", Offset = "0x1831524", VA = "0x1831524")]
		public static extern IntPtr ovr_Message_GetError(IntPtr obj);

		[PreserveSig]
		[Token(Token = "0x60002DA")]
		[Address(RVA = "0x18315A4", Offset = "0x18315A4", VA = "0x18315A4")]
		public static extern IntPtr ovr_Message_GetHttpTransferUpdate(IntPtr obj);

		[PreserveSig]
		[Token(Token = "0x60002DB")]
		[Address(RVA = "0x1831624", Offset = "0x1831624", VA = "0x1831624")]
		public static extern IntPtr ovr_Message_GetInstalledApplicationArray(IntPtr obj);

		[PreserveSig]
		[Token(Token = "0x60002DC")]
		[Address(RVA = "0x18316A4", Offset = "0x18316A4", VA = "0x18316A4")]
		public static extern IntPtr ovr_Message_GetLaunchBlockFlowResult(IntPtr obj);

		[PreserveSig]
		[Token(Token = "0x60002DD")]
		[Address(RVA = "0x1831724", Offset = "0x1831724", VA = "0x1831724")]
		public static extern IntPtr ovr_Message_GetLaunchFriendRequestFlowResult(IntPtr obj);

		[PreserveSig]
		[Token(Token = "0x60002DE")]
		[Address(RVA = "0x18317A4", Offset = "0x18317A4", VA = "0x18317A4")]
		public static extern IntPtr ovr_Message_GetLaunchReportFlowResult(IntPtr obj);

		[PreserveSig]
		[Token(Token = "0x60002DF")]
		[Address(RVA = "0x1831824", Offset = "0x1831824", VA = "0x1831824")]
		public static extern IntPtr ovr_Message_GetLaunchUnblockFlowResult(IntPtr obj);

		[PreserveSig]
		[Token(Token = "0x60002E0")]
		[Address(RVA = "0x18318A4", Offset = "0x18318A4", VA = "0x18318A4")]
		public static extern IntPtr ovr_Message_GetLeaderboardEntryArray(IntPtr obj);

		[PreserveSig]
		[Token(Token = "0x60002E1")]
		[Address(RVA = "0x1831924", Offset = "0x1831924", VA = "0x1831924")]
		public static extern IntPtr ovr_Message_GetLeaderboardUpdateStatus(IntPtr obj);

		[PreserveSig]
		[Token(Token = "0x60002E2")]
		[Address(RVA = "0x18319A4", Offset = "0x18319A4", VA = "0x18319A4")]
		public static extern IntPtr ovr_Message_GetLinkedAccountArray(IntPtr obj);

		[PreserveSig]
		[Token(Token = "0x60002E3")]
		[Address(RVA = "0x1831A24", Offset = "0x1831A24", VA = "0x1831A24")]
		public static extern IntPtr ovr_Message_GetLivestreamingApplicationStatus(IntPtr obj);

		[PreserveSig]
		[Token(Token = "0x60002E4")]
		[Address(RVA = "0x1831AA4", Offset = "0x1831AA4", VA = "0x1831AA4")]
		public static extern IntPtr ovr_Message_GetLivestreamingStartResult(IntPtr obj);

		[PreserveSig]
		[Token(Token = "0x60002E5")]
		[Address(RVA = "0x1831B24", Offset = "0x1831B24", VA = "0x1831B24")]
		public static extern IntPtr ovr_Message_GetLivestreamingStatus(IntPtr obj);

		[PreserveSig]
		[Token(Token = "0x60002E6")]
		[Address(RVA = "0x1831BA4", Offset = "0x1831BA4", VA = "0x1831BA4")]
		public static extern IntPtr ovr_Message_GetLivestreamingVideoStats(IntPtr obj);

		[PreserveSig]
		[Token(Token = "0x60002E7")]
		[Address(RVA = "0x1831C24", Offset = "0x1831C24", VA = "0x1831C24")]
		public static extern IntPtr ovr_Message_GetMatchmakingAdminSnapshot(IntPtr obj);

		[PreserveSig]
		[Token(Token = "0x60002E8")]
		[Address(RVA = "0x1831CA4", Offset = "0x1831CA4", VA = "0x1831CA4")]
		public static extern IntPtr ovr_Message_GetMatchmakingBrowseResult(IntPtr obj);

		[PreserveSig]
		[Token(Token = "0x60002E9")]
		[Address(RVA = "0x1831D24", Offset = "0x1831D24", VA = "0x1831D24")]
		public static extern IntPtr ovr_Message_GetMatchmakingEnqueueResult(IntPtr obj);

		[PreserveSig]
		[Token(Token = "0x60002EA")]
		[Address(RVA = "0x1831DA4", Offset = "0x1831DA4", VA = "0x1831DA4")]
		public static extern IntPtr ovr_Message_GetMatchmakingEnqueueResultAndRoom(IntPtr obj);

		[PreserveSig]
		[Token(Token = "0x60002EB")]
		[Address(RVA = "0x1831E24", Offset = "0x1831E24", VA = "0x1831E24")]
		public static extern IntPtr ovr_Message_GetMatchmakingRoomArray(IntPtr obj);

		[PreserveSig]
		[Token(Token = "0x60002EC")]
		[Address(RVA = "0x1831EA4", Offset = "0x1831EA4", VA = "0x1831EA4")]
		public static extern IntPtr ovr_Message_GetMatchmakingStats(IntPtr obj);

		[PreserveSig]
		[Token(Token = "0x60002ED")]
		[Address(RVA = "0x1831F24", Offset = "0x1831F24", VA = "0x1831F24")]
		public static extern IntPtr ovr_Message_GetNativeMessage(IntPtr obj);

		[PreserveSig]
		[Token(Token = "0x60002EE")]
		[Address(RVA = "0x1831FA4", Offset = "0x1831FA4", VA = "0x1831FA4")]
		public static extern IntPtr ovr_Message_GetNetworkingPeer(IntPtr obj);

		[PreserveSig]
		[Token(Token = "0x60002EF")]
		[Address(RVA = "0x1832024", Offset = "0x1832024", VA = "0x1832024")]
		public static extern IntPtr ovr_Message_GetOrgScopedID(IntPtr obj);

		[PreserveSig]
		[Token(Token = "0x60002F0")]
		[Address(RVA = "0x18320A4", Offset = "0x18320A4", VA = "0x18320A4")]
		public static extern IntPtr ovr_Message_GetParty(IntPtr obj);

		[PreserveSig]
		[Token(Token = "0x60002F1")]
		[Address(RVA = "0x1832124", Offset = "0x1832124", VA = "0x1832124")]
		public static extern IntPtr ovr_Message_GetPartyID(IntPtr obj);

		[PreserveSig]
		[Token(Token = "0x60002F2")]
		[Address(RVA = "0x18321A4", Offset = "0x18321A4", VA = "0x18321A4")]
		public static extern IntPtr ovr_Message_GetPartyUpdateNotification(IntPtr obj);

		[PreserveSig]
		[Token(Token = "0x60002F3")]
		[Address(RVA = "0x1832224", Offset = "0x1832224", VA = "0x1832224")]
		public static extern IntPtr ovr_Message_GetPidArray(IntPtr obj);

		[PreserveSig]
		[Token(Token = "0x60002F4")]
		[Address(RVA = "0x18322A4", Offset = "0x18322A4", VA = "0x18322A4")]
		public static extern IntPtr ovr_Message_GetPingResult(IntPtr obj);

		[PreserveSig]
		[Token(Token = "0x60002F5")]
		[Address(RVA = "0x1832324", Offset = "0x1832324", VA = "0x1832324")]
		public static extern IntPtr ovr_Message_GetPlatformInitialize(IntPtr obj);

		[PreserveSig]
		[Token(Token = "0x60002F6")]
		[Address(RVA = "0x18323A4", Offset = "0x18323A4", VA = "0x18323A4")]
		public static extern IntPtr ovr_Message_GetProductArray(IntPtr obj);

		[PreserveSig]
		[Token(Token = "0x60002F7")]
		[Address(RVA = "0x1832424", Offset = "0x1832424", VA = "0x1832424")]
		public static extern IntPtr ovr_Message_GetPurchase(IntPtr obj);

		[PreserveSig]
		[Token(Token = "0x60002F8")]
		[Address(RVA = "0x18324A4", Offset = "0x18324A4", VA = "0x18324A4")]
		public static extern IntPtr ovr_Message_GetPurchaseArray(IntPtr obj);

		[PreserveSig]
		[Token(Token = "0x60002F9")]
		[Address(RVA = "0x1832524", Offset = "0x1832524", VA = "0x1832524")]
		public static extern ulong ovr_Message_GetRequestID(IntPtr obj);

		[PreserveSig]
		[Token(Token = "0x60002FA")]
		[Address(RVA = "0x18325A4", Offset = "0x18325A4", VA = "0x18325A4")]
		public static extern IntPtr ovr_Message_GetRoom(IntPtr obj);

		[PreserveSig]
		[Token(Token = "0x60002FB")]
		[Address(RVA = "0x1832624", Offset = "0x1832624", VA = "0x1832624")]
		public static extern IntPtr ovr_Message_GetRoomArray(IntPtr obj);

		[PreserveSig]
		[Token(Token = "0x60002FC")]
		[Address(RVA = "0x18326A4", Offset = "0x18326A4", VA = "0x18326A4")]
		public static extern IntPtr ovr_Message_GetRoomInviteNotification(IntPtr obj);

		[PreserveSig]
		[Token(Token = "0x60002FD")]
		[Address(RVA = "0x1832724", Offset = "0x1832724", VA = "0x1832724")]
		public static extern IntPtr ovr_Message_GetRoomInviteNotificationArray(IntPtr obj);

		[PreserveSig]
		[Token(Token = "0x60002FE")]
		[Address(RVA = "0x18327A4", Offset = "0x18327A4", VA = "0x18327A4")]
		public static extern IntPtr ovr_Message_GetSdkAccountArray(IntPtr obj);

		[PreserveSig]
		[Token(Token = "0x60002FF")]
		[Address(RVA = "0x1832824", Offset = "0x1832824", VA = "0x1832824")]
		public static extern IntPtr ovr_Message_GetShareMediaResult(IntPtr obj);

		[Token(Token = "0x6000300")]
		[Address(RVA = "0x18328A4", Offset = "0x18328A4", VA = "0x18328A4")]
		public static string ovr_Message_GetString(IntPtr obj)
		{
			return null;
		}

		[PreserveSig]
		[Token(Token = "0x6000301")]
		[Address(RVA = "0x183290C", Offset = "0x183290C", VA = "0x183290C")]
		private static extern IntPtr ovr_Message_GetString_Native(IntPtr obj);

		[PreserveSig]
		[Token(Token = "0x6000302")]
		[Address(RVA = "0x183298C", Offset = "0x183298C", VA = "0x183298C")]
		public static extern IntPtr ovr_Message_GetSystemPermission(IntPtr obj);

		[PreserveSig]
		[Token(Token = "0x6000303")]
		[Address(RVA = "0x1832A0C", Offset = "0x1832A0C", VA = "0x1832A0C")]
		public static extern IntPtr ovr_Message_GetSystemVoipState(IntPtr obj);

		[PreserveSig]
		[Token(Token = "0x6000304")]
		[Address(RVA = "0x1832A8C", Offset = "0x1832A8C", VA = "0x1832A8C")]
		public static extern Message.MessageType ovr_Message_GetType(IntPtr obj);

		[PreserveSig]
		[Token(Token = "0x6000305")]
		[Address(RVA = "0x1832B0C", Offset = "0x1832B0C", VA = "0x1832B0C")]
		public static extern IntPtr ovr_Message_GetUser(IntPtr obj);

		[PreserveSig]
		[Token(Token = "0x6000306")]
		[Address(RVA = "0x1832B8C", Offset = "0x1832B8C", VA = "0x1832B8C")]
		public static extern IntPtr ovr_Message_GetUserAndRoomArray(IntPtr obj);

		[PreserveSig]
		[Token(Token = "0x6000307")]
		[Address(RVA = "0x1832C0C", Offset = "0x1832C0C", VA = "0x1832C0C")]
		public static extern IntPtr ovr_Message_GetUserArray(IntPtr obj);

		[PreserveSig]
		[Token(Token = "0x6000308")]
		[Address(RVA = "0x1832C8C", Offset = "0x1832C8C", VA = "0x1832C8C")]
		public static extern IntPtr ovr_Message_GetUserProof(IntPtr obj);

		[PreserveSig]
		[Token(Token = "0x6000309")]
		[Address(RVA = "0x1832D0C", Offset = "0x1832D0C", VA = "0x1832D0C")]
		public static extern IntPtr ovr_Message_GetUserReportID(IntPtr obj);

		[PreserveSig]
		[Token(Token = "0x600030A")]
		[Address(RVA = "0x1832D8C", Offset = "0x1832D8C", VA = "0x1832D8C")]
		public static extern bool ovr_Message_IsError(IntPtr obj);

		[PreserveSig]
		[Token(Token = "0x600030B")]
		[Address(RVA = "0x1832E14", Offset = "0x1832E14", VA = "0x1832E14")]
		public static extern UIntPtr ovr_Microphone_GetNumSamplesAvailable(IntPtr obj);

		[PreserveSig]
		[Token(Token = "0x600030C")]
		[Address(RVA = "0x1832E94", Offset = "0x1832E94", VA = "0x1832E94")]
		public static extern UIntPtr ovr_Microphone_GetOutputBufferMaxSize(IntPtr obj);

		[PreserveSig]
		[Token(Token = "0x600030D")]
		[Address(RVA = "0x1832F14", Offset = "0x1832F14", VA = "0x1832F14")]
		public static extern UIntPtr ovr_Microphone_GetPCM(IntPtr obj, short[] outputBuffer, UIntPtr outputBufferNumElements);

		[PreserveSig]
		[Token(Token = "0x600030E")]
		[Address(RVA = "0x1832FB4", Offset = "0x1832FB4", VA = "0x1832FB4")]
		public static extern UIntPtr ovr_Microphone_GetPCMFloat(IntPtr obj, float[] outputBuffer, UIntPtr outputBufferNumElements);

		[PreserveSig]
		[Token(Token = "0x600030F")]
		[Address(RVA = "0x1833054", Offset = "0x1833054", VA = "0x1833054")]
		public static extern UIntPtr ovr_Microphone_ReadData(IntPtr obj, float[] outputBuffer, UIntPtr outputBufferSize);

		[PreserveSig]
		[Token(Token = "0x6000310")]
		[Address(RVA = "0x18330F4", Offset = "0x18330F4", VA = "0x18330F4")]
		public static extern void ovr_Microphone_SetAcceptableRecordingDelayHint(IntPtr obj, UIntPtr delayMs);

		[PreserveSig]
		[Token(Token = "0x6000311")]
		[Address(RVA = "0x1833184", Offset = "0x1833184", VA = "0x1833184")]
		public static extern void ovr_Microphone_Start(IntPtr obj);

		[PreserveSig]
		[Token(Token = "0x6000312")]
		[Address(RVA = "0x1833204", Offset = "0x1833204", VA = "0x1833204")]
		public static extern void ovr_Microphone_Stop(IntPtr obj);

		[PreserveSig]
		[Token(Token = "0x6000313")]
		[Address(RVA = "0x1833284", Offset = "0x1833284", VA = "0x1833284")]
		public static extern ulong ovr_NetworkingPeer_GetID(IntPtr obj);

		[PreserveSig]
		[Token(Token = "0x6000314")]
		[Address(RVA = "0x1833304", Offset = "0x1833304", VA = "0x1833304")]
		public static extern PeerConnectionState ovr_NetworkingPeer_GetState(IntPtr obj);

		[PreserveSig]
		[Token(Token = "0x6000315")]
		[Address(RVA = "0x1833384", Offset = "0x1833384", VA = "0x1833384")]
		public static extern ulong ovr_OrgScopedID_GetID(IntPtr obj);

		[PreserveSig]
		[Token(Token = "0x6000316")]
		[Address(RVA = "0x1833404", Offset = "0x1833404", VA = "0x1833404")]
		public static extern void ovr_Packet_Free(IntPtr obj);

		[PreserveSig]
		[Token(Token = "0x6000317")]
		[Address(RVA = "0x1833484", Offset = "0x1833484", VA = "0x1833484")]
		public static extern IntPtr ovr_Packet_GetBytes(IntPtr obj);

		[PreserveSig]
		[Token(Token = "0x6000318")]
		[Address(RVA = "0x1833504", Offset = "0x1833504", VA = "0x1833504")]
		public static extern SendPolicy ovr_Packet_GetSendPolicy(IntPtr obj);

		[PreserveSig]
		[Token(Token = "0x6000319")]
		[Address(RVA = "0x1833584", Offset = "0x1833584", VA = "0x1833584")]
		public static extern ulong ovr_Packet_GetSenderID(IntPtr obj);

		[PreserveSig]
		[Token(Token = "0x600031A")]
		[Address(RVA = "0x1833604", Offset = "0x1833604", VA = "0x1833604")]
		public static extern UIntPtr ovr_Packet_GetSize(IntPtr obj);

		[PreserveSig]
		[Token(Token = "0x600031B")]
		[Address(RVA = "0x1833684", Offset = "0x1833684", VA = "0x1833684")]
		public static extern ulong ovr_Party_GetID(IntPtr obj);

		[PreserveSig]
		[Token(Token = "0x600031C")]
		[Address(RVA = "0x1833704", Offset = "0x1833704", VA = "0x1833704")]
		public static extern IntPtr ovr_Party_GetInvitedUsers(IntPtr obj);

		[PreserveSig]
		[Token(Token = "0x600031D")]
		[Address(RVA = "0x1833784", Offset = "0x1833784", VA = "0x1833784")]
		public static extern IntPtr ovr_Party_GetLeader(IntPtr obj);

		[PreserveSig]
		[Token(Token = "0x600031E")]
		[Address(RVA = "0x1833804", Offset = "0x1833804", VA = "0x1833804")]
		public static extern IntPtr ovr_Party_GetRoom(IntPtr obj);

		[PreserveSig]
		[Token(Token = "0x600031F")]
		[Address(RVA = "0x1833880", Offset = "0x1833880", VA = "0x1833880")]
		public static extern IntPtr ovr_Party_GetUsers(IntPtr obj);

		[PreserveSig]
		[Token(Token = "0x6000320")]
		[Address(RVA = "0x1833900", Offset = "0x1833900", VA = "0x1833900")]
		public static extern ulong ovr_PartyID_GetID(IntPtr obj);

		[PreserveSig]
		[Token(Token = "0x6000321")]
		[Address(RVA = "0x183397C", Offset = "0x183397C", VA = "0x183397C")]
		public static extern PartyUpdateAction ovr_PartyUpdateNotification_GetAction(IntPtr obj);

		[PreserveSig]
		[Token(Token = "0x6000322")]
		[Address(RVA = "0x18339FC", Offset = "0x18339FC", VA = "0x18339FC")]
		public static extern ulong ovr_PartyUpdateNotification_GetPartyId(IntPtr obj);

		[PreserveSig]
		[Token(Token = "0x6000323")]
		[Address(RVA = "0x1833A7C", Offset = "0x1833A7C", VA = "0x1833A7C")]
		public static extern ulong ovr_PartyUpdateNotification_GetSenderId(IntPtr obj);

		[Token(Token = "0x6000324")]
		[Address(RVA = "0x1833AFC", Offset = "0x1833AFC", VA = "0x1833AFC")]
		public static string ovr_PartyUpdateNotification_GetUpdateTimestamp(IntPtr obj)
		{
			return null;
		}

		[PreserveSig]
		[Token(Token = "0x6000325")]
		[Address(RVA = "0x1833B64", Offset = "0x1833B64", VA = "0x1833B64")]
		private static extern IntPtr ovr_PartyUpdateNotification_GetUpdateTimestamp_Native(IntPtr obj);

		[Token(Token = "0x6000326")]
		[Address(RVA = "0x1833BE4", Offset = "0x1833BE4", VA = "0x1833BE4")]
		public static string ovr_PartyUpdateNotification_GetUserAlias(IntPtr obj)
		{
			return null;
		}

		[PreserveSig]
		[Token(Token = "0x6000327")]
		[Address(RVA = "0x1833C4C", Offset = "0x1833C4C", VA = "0x1833C4C")]
		private static extern IntPtr ovr_PartyUpdateNotification_GetUserAlias_Native(IntPtr obj);

		[PreserveSig]
		[Token(Token = "0x6000328")]
		[Address(RVA = "0x1833CCC", Offset = "0x1833CCC", VA = "0x1833CCC")]
		public static extern ulong ovr_PartyUpdateNotification_GetUserId(IntPtr obj);

		[Token(Token = "0x6000329")]
		[Address(RVA = "0x1833D4C", Offset = "0x1833D4C", VA = "0x1833D4C")]
		public static string ovr_PartyUpdateNotification_GetUserName(IntPtr obj)
		{
			return null;
		}

		[PreserveSig]
		[Token(Token = "0x600032A")]
		[Address(RVA = "0x1833DB4", Offset = "0x1833DB4", VA = "0x1833DB4")]
		private static extern IntPtr ovr_PartyUpdateNotification_GetUserName_Native(IntPtr obj);

		[Token(Token = "0x600032B")]
		[Address(RVA = "0x1833E34", Offset = "0x1833E34", VA = "0x1833E34")]
		public static string ovr_Pid_GetId(IntPtr obj)
		{
			return null;
		}

		[PreserveSig]
		[Token(Token = "0x600032C")]
		[Address(RVA = "0x1833E9C", Offset = "0x1833E9C", VA = "0x1833E9C")]
		private static extern IntPtr ovr_Pid_GetId_Native(IntPtr obj);

		[PreserveSig]
		[Token(Token = "0x600032D")]
		[Address(RVA = "0x1833F1C", Offset = "0x1833F1C", VA = "0x1833F1C")]
		public static extern IntPtr ovr_PidArray_GetElement(IntPtr obj, UIntPtr index);

		[PreserveSig]
		[Token(Token = "0x600032E")]
		[Address(RVA = "0x1833FAC", Offset = "0x1833FAC", VA = "0x1833FAC")]
		public static extern UIntPtr ovr_PidArray_GetSize(IntPtr obj);

		[PreserveSig]
		[Token(Token = "0x600032F")]
		[Address(RVA = "0x183402C", Offset = "0x183402C", VA = "0x183402C")]
		public static extern ulong ovr_PingResult_GetID(IntPtr obj);

		[PreserveSig]
		[Token(Token = "0x6000330")]
		[Address(RVA = "0x18340AC", Offset = "0x18340AC", VA = "0x18340AC")]
		public static extern ulong ovr_PingResult_GetPingTimeUsec(IntPtr obj);

		[PreserveSig]
		[Token(Token = "0x6000331")]
		[Address(RVA = "0x183412C", Offset = "0x183412C", VA = "0x183412C")]
		public static extern bool ovr_PingResult_IsTimeout(IntPtr obj);

		[PreserveSig]
		[Token(Token = "0x6000332")]
		[Address(RVA = "0x18341B4", Offset = "0x18341B4", VA = "0x18341B4")]
		public static extern PlatformInitializeResult ovr_PlatformInitialize_GetResult(IntPtr obj);

		[PreserveSig]
		[Token(Token = "0x6000333")]
		[Address(RVA = "0x1834234", Offset = "0x1834234", VA = "0x1834234")]
		public static extern uint ovr_Price_GetAmountInHundredths(IntPtr obj);

		[Token(Token = "0x6000334")]
		[Address(RVA = "0x18342B4", Offset = "0x18342B4", VA = "0x18342B4")]
		public static string ovr_Price_GetCurrency(IntPtr obj)
		{
			return null;
		}

		[PreserveSig]
		[Token(Token = "0x6000335")]
		[Address(RVA = "0x183431C", Offset = "0x183431C", VA = "0x183431C")]
		private static extern IntPtr ovr_Price_GetCurrency_Native(IntPtr obj);

		[Token(Token = "0x6000336")]
		[Address(RVA = "0x183439C", Offset = "0x183439C", VA = "0x183439C")]
		public static string ovr_Price_GetFormatted(IntPtr obj)
		{
			return null;
		}

		[PreserveSig]
		[Token(Token = "0x6000337")]
		[Address(RVA = "0x1834404", Offset = "0x1834404", VA = "0x1834404")]
		private static extern IntPtr ovr_Price_GetFormatted_Native(IntPtr obj);

		[Token(Token = "0x6000338")]
		[Address(RVA = "0x1834484", Offset = "0x1834484", VA = "0x1834484")]
		public static string ovr_Product_GetDescription(IntPtr obj)
		{
			return null;
		}

		[PreserveSig]
		[Token(Token = "0x6000339")]
		[Address(RVA = "0x18344EC", Offset = "0x18344EC", VA = "0x18344EC")]
		private static extern IntPtr ovr_Product_GetDescription_Native(IntPtr obj);

		[Token(Token = "0x600033A")]
		[Address(RVA = "0x183456C", Offset = "0x183456C", VA = "0x183456C")]
		public static string ovr_Product_GetFormattedPrice(IntPtr obj)
		{
			return null;
		}

		[PreserveSig]
		[Token(Token = "0x600033B")]
		[Address(RVA = "0x18345D4", Offset = "0x18345D4", VA = "0x18345D4")]
		private static extern IntPtr ovr_Product_GetFormattedPrice_Native(IntPtr obj);

		[Token(Token = "0x600033C")]
		[Address(RVA = "0x1834654", Offset = "0x1834654", VA = "0x1834654")]
		public static string ovr_Product_GetName(IntPtr obj)
		{
			return null;
		}

		[PreserveSig]
		[Token(Token = "0x600033D")]
		[Address(RVA = "0x18346BC", Offset = "0x18346BC", VA = "0x18346BC")]
		private static extern IntPtr ovr_Product_GetName_Native(IntPtr obj);

		[Token(Token = "0x600033E")]
		[Address(RVA = "0x183473C", Offset = "0x183473C", VA = "0x183473C")]
		public static string ovr_Product_GetSKU(IntPtr obj)
		{
			return null;
		}

		[PreserveSig]
		[Token(Token = "0x600033F")]
		[Address(RVA = "0x18347A4", Offset = "0x18347A4", VA = "0x18347A4")]
		private static extern IntPtr ovr_Product_GetSKU_Native(IntPtr obj);

		[PreserveSig]
		[Token(Token = "0x6000340")]
		[Address(RVA = "0x1834824", Offset = "0x1834824", VA = "0x1834824")]
		public static extern IntPtr ovr_ProductArray_GetElement(IntPtr obj, UIntPtr index);

		[Token(Token = "0x6000341")]
		[Address(RVA = "0x18348B4", Offset = "0x18348B4", VA = "0x18348B4")]
		public static string ovr_ProductArray_GetNextUrl(IntPtr obj)
		{
			return null;
		}

		[PreserveSig]
		[Token(Token = "0x6000342")]
		[Address(RVA = "0x183491C", Offset = "0x183491C", VA = "0x183491C")]
		private static extern IntPtr ovr_ProductArray_GetNextUrl_Native(IntPtr obj);

		[PreserveSig]
		[Token(Token = "0x6000343")]
		[Address(RVA = "0x183499C", Offset = "0x183499C", VA = "0x183499C")]
		public static extern UIntPtr ovr_ProductArray_GetSize(IntPtr obj);

		[PreserveSig]
		[Token(Token = "0x6000344")]
		[Address(RVA = "0x1834A1C", Offset = "0x1834A1C", VA = "0x1834A1C")]
		public static extern bool ovr_ProductArray_HasNextPage(IntPtr obj);

		[Token(Token = "0x6000345")]
		[Address(RVA = "0x1834AA4", Offset = "0x1834AA4", VA = "0x1834AA4")]
		public static DateTime ovr_Purchase_GetExpirationTime(IntPtr obj)
		{
			return default(DateTime);
		}

		[PreserveSig]
		[Token(Token = "0x6000346")]
		[Address(RVA = "0x1834B0C", Offset = "0x1834B0C", VA = "0x1834B0C")]
		private static extern ulong ovr_Purchase_GetExpirationTime_Native(IntPtr obj);

		[Token(Token = "0x6000347")]
		[Address(RVA = "0x1834B8C", Offset = "0x1834B8C", VA = "0x1834B8C")]
		public static DateTime ovr_Purchase_GetGrantTime(IntPtr obj)
		{
			return default(DateTime);
		}

		[PreserveSig]
		[Token(Token = "0x6000348")]
		[Address(RVA = "0x1834BF4", Offset = "0x1834BF4", VA = "0x1834BF4")]
		private static extern ulong ovr_Purchase_GetGrantTime_Native(IntPtr obj);

		[PreserveSig]
		[Token(Token = "0x6000349")]
		[Address(RVA = "0x1834C74", Offset = "0x1834C74", VA = "0x1834C74")]
		public static extern ulong ovr_Purchase_GetPurchaseID(IntPtr obj);

		[Token(Token = "0x600034A")]
		[Address(RVA = "0x1834CF4", Offset = "0x1834CF4", VA = "0x1834CF4")]
		public static string ovr_Purchase_GetSKU(IntPtr obj)
		{
			return null;
		}

		[PreserveSig]
		[Token(Token = "0x600034B")]
		[Address(RVA = "0x1834D5C", Offset = "0x1834D5C", VA = "0x1834D5C")]
		private static extern IntPtr ovr_Purchase_GetSKU_Native(IntPtr obj);

		[PreserveSig]
		[Token(Token = "0x600034C")]
		[Address(RVA = "0x1834DDC", Offset = "0x1834DDC", VA = "0x1834DDC")]
		public static extern IntPtr ovr_PurchaseArray_GetElement(IntPtr obj, UIntPtr index);

		[Token(Token = "0x600034D")]
		[Address(RVA = "0x1834E6C", Offset = "0x1834E6C", VA = "0x1834E6C")]
		public static string ovr_PurchaseArray_GetNextUrl(IntPtr obj)
		{
			return null;
		}

		[PreserveSig]
		[Token(Token = "0x600034E")]
		[Address(RVA = "0x1834ED4", Offset = "0x1834ED4", VA = "0x1834ED4")]
		private static extern IntPtr ovr_PurchaseArray_GetNextUrl_Native(IntPtr obj);

		[PreserveSig]
		[Token(Token = "0x600034F")]
		[Address(RVA = "0x1834F54", Offset = "0x1834F54", VA = "0x1834F54")]
		public static extern UIntPtr ovr_PurchaseArray_GetSize(IntPtr obj);

		[PreserveSig]
		[Token(Token = "0x6000350")]
		[Address(RVA = "0x1834FD4", Offset = "0x1834FD4", VA = "0x1834FD4")]
		public static extern bool ovr_PurchaseArray_HasNextPage(IntPtr obj);

		[PreserveSig]
		[Token(Token = "0x6000351")]
		[Address(RVA = "0x183505C", Offset = "0x183505C", VA = "0x183505C")]
		public static extern ulong ovr_Room_GetApplicationID(IntPtr obj);

		[PreserveSig]
		[Token(Token = "0x6000352")]
		[Address(RVA = "0x18350DC", Offset = "0x18350DC", VA = "0x18350DC")]
		public static extern IntPtr ovr_Room_GetDataStore(IntPtr obj);

		[Token(Token = "0x6000353")]
		[Address(RVA = "0x183515C", Offset = "0x183515C", VA = "0x183515C")]
		public static string ovr_Room_GetDescription(IntPtr obj)
		{
			return null;
		}

		[PreserveSig]
		[Token(Token = "0x6000354")]
		[Address(RVA = "0x18351C4", Offset = "0x18351C4", VA = "0x18351C4")]
		private static extern IntPtr ovr_Room_GetDescription_Native(IntPtr obj);

		[PreserveSig]
		[Token(Token = "0x6000355")]
		[Address(RVA = "0x1835244", Offset = "0x1835244", VA = "0x1835244")]
		public static extern ulong ovr_Room_GetID(IntPtr obj);

		[PreserveSig]
		[Token(Token = "0x6000356")]
		[Address(RVA = "0x18352C4", Offset = "0x18352C4", VA = "0x18352C4")]
		public static extern IntPtr ovr_Room_GetInvitedUsers(IntPtr obj);

		[PreserveSig]
		[Token(Token = "0x6000357")]
		[Address(RVA = "0x1835344", Offset = "0x1835344", VA = "0x1835344")]
		public static extern bool ovr_Room_GetIsMembershipLocked(IntPtr obj);

		[PreserveSig]
		[Token(Token = "0x6000358")]
		[Address(RVA = "0x18353CC", Offset = "0x18353CC", VA = "0x18353CC")]
		public static extern RoomJoinPolicy ovr_Room_GetJoinPolicy(IntPtr obj);

		[PreserveSig]
		[Token(Token = "0x6000359")]
		[Address(RVA = "0x183544C", Offset = "0x183544C", VA = "0x183544C")]
		public static extern RoomJoinability ovr_Room_GetJoinability(IntPtr obj);

		[PreserveSig]
		[Token(Token = "0x600035A")]
		[Address(RVA = "0x18354CC", Offset = "0x18354CC", VA = "0x18354CC")]
		public static extern IntPtr ovr_Room_GetMatchedUsers(IntPtr obj);

		[PreserveSig]
		[Token(Token = "0x600035B")]
		[Address(RVA = "0x183554C", Offset = "0x183554C", VA = "0x183554C")]
		public static extern uint ovr_Room_GetMaxUsers(IntPtr obj);

		[Token(Token = "0x600035C")]
		[Address(RVA = "0x18355CC", Offset = "0x18355CC", VA = "0x18355CC")]
		public static string ovr_Room_GetName(IntPtr obj)
		{
			return null;
		}

		[PreserveSig]
		[Token(Token = "0x600035D")]
		[Address(RVA = "0x1835634", Offset = "0x1835634", VA = "0x1835634")]
		private static extern IntPtr ovr_Room_GetName_Native(IntPtr obj);

		[PreserveSig]
		[Token(Token = "0x600035E")]
		[Address(RVA = "0x18356B4", Offset = "0x18356B4", VA = "0x18356B4")]
		public static extern IntPtr ovr_Room_GetOwner(IntPtr obj);

		[PreserveSig]
		[Token(Token = "0x600035F")]
		[Address(RVA = "0x1835730", Offset = "0x1835730", VA = "0x1835730")]
		public static extern RoomType ovr_Room_GetType(IntPtr obj);

		[PreserveSig]
		[Token(Token = "0x6000360")]
		[Address(RVA = "0x18357B0", Offset = "0x18357B0", VA = "0x18357B0")]
		public static extern IntPtr ovr_Room_GetUsers(IntPtr obj);

		[PreserveSig]
		[Token(Token = "0x6000361")]
		[Address(RVA = "0x183582C", Offset = "0x183582C", VA = "0x183582C")]
		public static extern uint ovr_Room_GetVersion(IntPtr obj);

		[PreserveSig]
		[Token(Token = "0x6000362")]
		[Address(RVA = "0x18358AC", Offset = "0x18358AC", VA = "0x18358AC")]
		public static extern IntPtr ovr_RoomArray_GetElement(IntPtr obj, UIntPtr index);

		[Token(Token = "0x6000363")]
		[Address(RVA = "0x183593C", Offset = "0x183593C", VA = "0x183593C")]
		public static string ovr_RoomArray_GetNextUrl(IntPtr obj)
		{
			return null;
		}

		[PreserveSig]
		[Token(Token = "0x6000364")]
		[Address(RVA = "0x18359A4", Offset = "0x18359A4", VA = "0x18359A4")]
		private static extern IntPtr ovr_RoomArray_GetNextUrl_Native(IntPtr obj);

		[PreserveSig]
		[Token(Token = "0x6000365")]
		[Address(RVA = "0x1835A24", Offset = "0x1835A24", VA = "0x1835A24")]
		public static extern UIntPtr ovr_RoomArray_GetSize(IntPtr obj);

		[PreserveSig]
		[Token(Token = "0x6000366")]
		[Address(RVA = "0x1835AA4", Offset = "0x1835AA4", VA = "0x1835AA4")]
		public static extern bool ovr_RoomArray_HasNextPage(IntPtr obj);

		[PreserveSig]
		[Token(Token = "0x6000367")]
		[Address(RVA = "0x1835B2C", Offset = "0x1835B2C", VA = "0x1835B2C")]
		public static extern ulong ovr_RoomInviteNotification_GetID(IntPtr obj);

		[PreserveSig]
		[Token(Token = "0x6000368")]
		[Address(RVA = "0x1835BAC", Offset = "0x1835BAC", VA = "0x1835BAC")]
		public static extern ulong ovr_RoomInviteNotification_GetRoomID(IntPtr obj);

		[PreserveSig]
		[Token(Token = "0x6000369")]
		[Address(RVA = "0x1835C2C", Offset = "0x1835C2C", VA = "0x1835C2C")]
		public static extern ulong ovr_RoomInviteNotification_GetSenderID(IntPtr obj);

		[Token(Token = "0x600036A")]
		[Address(RVA = "0x1835CAC", Offset = "0x1835CAC", VA = "0x1835CAC")]
		public static DateTime ovr_RoomInviteNotification_GetSentTime(IntPtr obj)
		{
			return default(DateTime);
		}

		[PreserveSig]
		[Token(Token = "0x600036B")]
		[Address(RVA = "0x1835D14", Offset = "0x1835D14", VA = "0x1835D14")]
		private static extern ulong ovr_RoomInviteNotification_GetSentTime_Native(IntPtr obj);

		[PreserveSig]
		[Token(Token = "0x600036C")]
		[Address(RVA = "0x1835D94", Offset = "0x1835D94", VA = "0x1835D94")]
		public static extern IntPtr ovr_RoomInviteNotificationArray_GetElement(IntPtr obj, UIntPtr index);

		[Token(Token = "0x600036D")]
		[Address(RVA = "0x1835E24", Offset = "0x1835E24", VA = "0x1835E24")]
		public static string ovr_RoomInviteNotificationArray_GetNextUrl(IntPtr obj)
		{
			return null;
		}

		[PreserveSig]
		[Token(Token = "0x600036E")]
		[Address(RVA = "0x1835E8C", Offset = "0x1835E8C", VA = "0x1835E8C")]
		private static extern IntPtr ovr_RoomInviteNotificationArray_GetNextUrl_Native(IntPtr obj);

		[PreserveSig]
		[Token(Token = "0x600036F")]
		[Address(RVA = "0x1835F0C", Offset = "0x1835F0C", VA = "0x1835F0C")]
		public static extern UIntPtr ovr_RoomInviteNotificationArray_GetSize(IntPtr obj);

		[PreserveSig]
		[Token(Token = "0x6000370")]
		[Address(RVA = "0x1835F8C", Offset = "0x1835F8C", VA = "0x1835F8C")]
		public static extern bool ovr_RoomInviteNotificationArray_HasNextPage(IntPtr obj);

		[PreserveSig]
		[Token(Token = "0x6000371")]
		[Address(RVA = "0x1836014", Offset = "0x1836014", VA = "0x1836014")]
		public static extern SdkAccountType ovr_SdkAccount_GetAccountType(IntPtr obj);

		[PreserveSig]
		[Token(Token = "0x6000372")]
		[Address(RVA = "0x1836094", Offset = "0x1836094", VA = "0x1836094")]
		public static extern ulong ovr_SdkAccount_GetUserId(IntPtr obj);

		[PreserveSig]
		[Token(Token = "0x6000373")]
		[Address(RVA = "0x1836114", Offset = "0x1836114", VA = "0x1836114")]
		public static extern IntPtr ovr_SdkAccountArray_GetElement(IntPtr obj, UIntPtr index);

		[PreserveSig]
		[Token(Token = "0x6000374")]
		[Address(RVA = "0x18361A4", Offset = "0x18361A4", VA = "0x18361A4")]
		public static extern UIntPtr ovr_SdkAccountArray_GetSize(IntPtr obj);

		[PreserveSig]
		[Token(Token = "0x6000375")]
		[Address(RVA = "0x1836224", Offset = "0x1836224", VA = "0x1836224")]
		public static extern ShareMediaStatus ovr_ShareMediaResult_GetStatus(IntPtr obj);

		[PreserveSig]
		[Token(Token = "0x6000376")]
		[Address(RVA = "0x18362A4", Offset = "0x18362A4", VA = "0x18362A4")]
		public static extern bool ovr_SystemPermission_GetHasPermission(IntPtr obj);

		[PreserveSig]
		[Token(Token = "0x6000377")]
		[Address(RVA = "0x183632C", Offset = "0x183632C", VA = "0x183632C")]
		public static extern PermissionGrantStatus ovr_SystemPermission_GetPermissionGrantStatus(IntPtr obj);

		[PreserveSig]
		[Token(Token = "0x6000378")]
		[Address(RVA = "0x18363AC", Offset = "0x18363AC", VA = "0x18363AC")]
		public static extern VoipMuteState ovr_SystemVoipState_GetMicrophoneMuted(IntPtr obj);

		[PreserveSig]
		[Token(Token = "0x6000379")]
		[Address(RVA = "0x183642C", Offset = "0x183642C", VA = "0x183642C")]
		public static extern SystemVoipStatus ovr_SystemVoipState_GetStatus(IntPtr obj);

		[Token(Token = "0x600037A")]
		[Address(RVA = "0x18364AC", Offset = "0x18364AC", VA = "0x18364AC")]
		public static string ovr_TestUser_GetAccessToken(IntPtr obj)
		{
			return null;
		}

		[PreserveSig]
		[Token(Token = "0x600037B")]
		[Address(RVA = "0x1836514", Offset = "0x1836514", VA = "0x1836514")]
		private static extern IntPtr ovr_TestUser_GetAccessToken_Native(IntPtr obj);

		[PreserveSig]
		[Token(Token = "0x600037C")]
		[Address(RVA = "0x1836594", Offset = "0x1836594", VA = "0x1836594")]
		public static extern IntPtr ovr_TestUser_GetAppAccessArray(IntPtr obj);

		[PreserveSig]
		[Token(Token = "0x600037D")]
		[Address(RVA = "0x1836614", Offset = "0x1836614", VA = "0x1836614")]
		public static extern IntPtr ovr_TestUser_GetFbAppAccessArray(IntPtr obj);

		[Token(Token = "0x600037E")]
		[Address(RVA = "0x1836694", Offset = "0x1836694", VA = "0x1836694")]
		public static string ovr_TestUser_GetFriendAccessToken(IntPtr obj)
		{
			return null;
		}

		[PreserveSig]
		[Token(Token = "0x600037F")]
		[Address(RVA = "0x18366FC", Offset = "0x18366FC", VA = "0x18366FC")]
		private static extern IntPtr ovr_TestUser_GetFriendAccessToken_Native(IntPtr obj);

		[PreserveSig]
		[Token(Token = "0x6000380")]
		[Address(RVA = "0x183677C", Offset = "0x183677C", VA = "0x183677C")]
		public static extern IntPtr ovr_TestUser_GetFriendAppAccessArray(IntPtr obj);

		[Token(Token = "0x6000381")]
		[Address(RVA = "0x18367FC", Offset = "0x18367FC", VA = "0x18367FC")]
		public static string ovr_TestUser_GetUserAlias(IntPtr obj)
		{
			return null;
		}

		[PreserveSig]
		[Token(Token = "0x6000382")]
		[Address(RVA = "0x1836864", Offset = "0x1836864", VA = "0x1836864")]
		private static extern IntPtr ovr_TestUser_GetUserAlias_Native(IntPtr obj);

		[PreserveSig]
		[Token(Token = "0x6000383")]
		[Address(RVA = "0x18368E4", Offset = "0x18368E4", VA = "0x18368E4")]
		public static extern ulong ovr_TestUser_GetUserFbid(IntPtr obj);

		[PreserveSig]
		[Token(Token = "0x6000384")]
		[Address(RVA = "0x1836964", Offset = "0x1836964", VA = "0x1836964")]
		public static extern ulong ovr_TestUser_GetUserId(IntPtr obj);

		[Token(Token = "0x6000385")]
		[Address(RVA = "0x18369E4", Offset = "0x18369E4", VA = "0x18369E4")]
		public static string ovr_TestUserAppAccess_GetAccessToken(IntPtr obj)
		{
			return null;
		}

		[PreserveSig]
		[Token(Token = "0x6000386")]
		[Address(RVA = "0x1836A4C", Offset = "0x1836A4C", VA = "0x1836A4C")]
		private static extern IntPtr ovr_TestUserAppAccess_GetAccessToken_Native(IntPtr obj);

		[PreserveSig]
		[Token(Token = "0x6000387")]
		[Address(RVA = "0x1836ACC", Offset = "0x1836ACC", VA = "0x1836ACC")]
		public static extern ulong ovr_TestUserAppAccess_GetAppId(IntPtr obj);

		[PreserveSig]
		[Token(Token = "0x6000388")]
		[Address(RVA = "0x1836B4C", Offset = "0x1836B4C", VA = "0x1836B4C")]
		public static extern ulong ovr_TestUserAppAccess_GetUserId(IntPtr obj);

		[PreserveSig]
		[Token(Token = "0x6000389")]
		[Address(RVA = "0x1836BCC", Offset = "0x1836BCC", VA = "0x1836BCC")]
		public static extern IntPtr ovr_TestUserAppAccessArray_GetElement(IntPtr obj, UIntPtr index);

		[PreserveSig]
		[Token(Token = "0x600038A")]
		[Address(RVA = "0x1836C5C", Offset = "0x1836C5C", VA = "0x1836C5C")]
		public static extern UIntPtr ovr_TestUserAppAccessArray_GetSize(IntPtr obj);

		[PreserveSig]
		[Token(Token = "0x600038B")]
		[Address(RVA = "0x1836CDC", Offset = "0x1836CDC", VA = "0x1836CDC")]
		public static extern ulong ovr_User_GetID(IntPtr obj);

		[Token(Token = "0x600038C")]
		[Address(RVA = "0x1836D5C", Offset = "0x1836D5C", VA = "0x1836D5C")]
		public static string ovr_User_GetImageUrl(IntPtr obj)
		{
			return null;
		}

		[PreserveSig]
		[Token(Token = "0x600038D")]
		[Address(RVA = "0x1836DC4", Offset = "0x1836DC4", VA = "0x1836DC4")]
		private static extern IntPtr ovr_User_GetImageUrl_Native(IntPtr obj);

		[Token(Token = "0x600038E")]
		[Address(RVA = "0x1836E44", Offset = "0x1836E44", VA = "0x1836E44")]
		public static string ovr_User_GetInviteToken(IntPtr obj)
		{
			return null;
		}

		[PreserveSig]
		[Token(Token = "0x600038F")]
		[Address(RVA = "0x1836EAC", Offset = "0x1836EAC", VA = "0x1836EAC")]
		private static extern IntPtr ovr_User_GetInviteToken_Native(IntPtr obj);

		[Token(Token = "0x6000390")]
		[Address(RVA = "0x1836F2C", Offset = "0x1836F2C", VA = "0x1836F2C")]
		public static string ovr_User_GetOculusID(IntPtr obj)
		{
			return null;
		}

		[PreserveSig]
		[Token(Token = "0x6000391")]
		[Address(RVA = "0x1836F94", Offset = "0x1836F94", VA = "0x1836F94")]
		private static extern IntPtr ovr_User_GetOculusID_Native(IntPtr obj);

		[Token(Token = "0x6000392")]
		[Address(RVA = "0x1837014", Offset = "0x1837014", VA = "0x1837014")]
		public static string ovr_User_GetPresence(IntPtr obj)
		{
			return null;
		}

		[PreserveSig]
		[Token(Token = "0x6000393")]
		[Address(RVA = "0x183707C", Offset = "0x183707C", VA = "0x183707C")]
		private static extern IntPtr ovr_User_GetPresence_Native(IntPtr obj);

		[PreserveSig]
		[Token(Token = "0x6000394")]
		[Address(RVA = "0x18370FC", Offset = "0x18370FC", VA = "0x18370FC")]
		public static extern UserPresenceStatus ovr_User_GetPresenceStatus(IntPtr obj);

		[Token(Token = "0x6000395")]
		[Address(RVA = "0x183717C", Offset = "0x183717C", VA = "0x183717C")]
		public static string ovr_User_GetSmallImageUrl(IntPtr obj)
		{
			return null;
		}

		[PreserveSig]
		[Token(Token = "0x6000396")]
		[Address(RVA = "0x18371E4", Offset = "0x18371E4", VA = "0x18371E4")]
		private static extern IntPtr ovr_User_GetSmallImageUrl_Native(IntPtr obj);

		[PreserveSig]
		[Token(Token = "0x6000397")]
		[Address(RVA = "0x1837264", Offset = "0x1837264", VA = "0x1837264")]
		public static extern IntPtr ovr_UserAndRoom_GetRoom(IntPtr obj);

		[PreserveSig]
		[Token(Token = "0x6000398")]
		[Address(RVA = "0x18372E4", Offset = "0x18372E4", VA = "0x18372E4")]
		public static extern IntPtr ovr_UserAndRoom_GetUser(IntPtr obj);

		[PreserveSig]
		[Token(Token = "0x6000399")]
		[Address(RVA = "0x1837364", Offset = "0x1837364", VA = "0x1837364")]
		public static extern IntPtr ovr_UserAndRoomArray_GetElement(IntPtr obj, UIntPtr index);

		[Token(Token = "0x600039A")]
		[Address(RVA = "0x18373F4", Offset = "0x18373F4", VA = "0x18373F4")]
		public static string ovr_UserAndRoomArray_GetNextUrl(IntPtr obj)
		{
			return null;
		}

		[PreserveSig]
		[Token(Token = "0x600039B")]
		[Address(RVA = "0x183745C", Offset = "0x183745C", VA = "0x183745C")]
		private static extern IntPtr ovr_UserAndRoomArray_GetNextUrl_Native(IntPtr obj);

		[PreserveSig]
		[Token(Token = "0x600039C")]
		[Address(RVA = "0x18374DC", Offset = "0x18374DC", VA = "0x18374DC")]
		public static extern UIntPtr ovr_UserAndRoomArray_GetSize(IntPtr obj);

		[PreserveSig]
		[Token(Token = "0x600039D")]
		[Address(RVA = "0x183755C", Offset = "0x183755C", VA = "0x183755C")]
		public static extern bool ovr_UserAndRoomArray_HasNextPage(IntPtr obj);

		[PreserveSig]
		[Token(Token = "0x600039E")]
		[Address(RVA = "0x18375E4", Offset = "0x18375E4", VA = "0x18375E4")]
		public static extern IntPtr ovr_UserArray_GetElement(IntPtr obj, UIntPtr index);

		[Token(Token = "0x600039F")]
		[Address(RVA = "0x1837674", Offset = "0x1837674", VA = "0x1837674")]
		public static string ovr_UserArray_GetNextUrl(IntPtr obj)
		{
			return null;
		}

		[PreserveSig]
		[Token(Token = "0x60003A0")]
		[Address(RVA = "0x18376DC", Offset = "0x18376DC", VA = "0x18376DC")]
		private static extern IntPtr ovr_UserArray_GetNextUrl_Native(IntPtr obj);

		[PreserveSig]
		[Token(Token = "0x60003A1")]
		[Address(RVA = "0x183775C", Offset = "0x183775C", VA = "0x183775C")]
		public static extern UIntPtr ovr_UserArray_GetSize(IntPtr obj);

		[PreserveSig]
		[Token(Token = "0x60003A2")]
		[Address(RVA = "0x18377DC", Offset = "0x18377DC", VA = "0x18377DC")]
		public static extern bool ovr_UserArray_HasNextPage(IntPtr obj);

		[Token(Token = "0x60003A3")]
		[Address(RVA = "0x1837864", Offset = "0x1837864", VA = "0x1837864")]
		public static string ovr_UserProof_GetNonce(IntPtr obj)
		{
			return null;
		}

		[PreserveSig]
		[Token(Token = "0x60003A4")]
		[Address(RVA = "0x18378CC", Offset = "0x18378CC", VA = "0x18378CC")]
		private static extern IntPtr ovr_UserProof_GetNonce_Native(IntPtr obj);

		[PreserveSig]
		[Token(Token = "0x60003A5")]
		[Address(RVA = "0x183794C", Offset = "0x183794C", VA = "0x183794C")]
		public static extern bool ovr_UserReportID_GetDidCancel(IntPtr obj);

		[PreserveSig]
		[Token(Token = "0x60003A6")]
		[Address(RVA = "0x18379D4", Offset = "0x18379D4", VA = "0x18379D4")]
		public static extern ulong ovr_UserReportID_GetID(IntPtr obj);

		[PreserveSig]
		[Token(Token = "0x60003A7")]
		[Address(RVA = "0x1837A54", Offset = "0x1837A54", VA = "0x1837A54")]
		public static extern void ovr_VoipDecoder_Decode(IntPtr obj, byte[] compressedData, UIntPtr compressedSize);

		[PreserveSig]
		[Token(Token = "0x60003A8")]
		[Address(RVA = "0x1837AF4", Offset = "0x1837AF4", VA = "0x1837AF4")]
		public static extern UIntPtr ovr_VoipDecoder_GetDecodedPCM(IntPtr obj, float[] outputBuffer, UIntPtr outputBufferSize);

		[PreserveSig]
		[Token(Token = "0x60003A9")]
		[Address(RVA = "0x1837B94", Offset = "0x1837B94", VA = "0x1837B94")]
		public static extern void ovr_VoipEncoder_AddPCM(IntPtr obj, float[] inputData, uint inputSize);

		[PreserveSig]
		[Token(Token = "0x60003AA")]
		[Address(RVA = "0x1837C34", Offset = "0x1837C34", VA = "0x1837C34")]
		public static extern UIntPtr ovr_VoipEncoder_GetCompressedData(IntPtr obj, byte[] outputBuffer, UIntPtr intputSize);

		[PreserveSig]
		[Token(Token = "0x60003AB")]
		[Address(RVA = "0x1837CD4", Offset = "0x1837CD4", VA = "0x1837CD4")]
		public static extern UIntPtr ovr_VoipEncoder_GetCompressedDataSize(IntPtr obj);

		[PreserveSig]
		[Token(Token = "0x60003AC")]
		[Address(RVA = "0x181C348", Offset = "0x181C348", VA = "0x181C348")]
		public static extern IntPtr ovr_AbuseReportOptions_Create();

		[PreserveSig]
		[Token(Token = "0x60003AD")]
		[Address(RVA = "0x181C6D0", Offset = "0x181C6D0", VA = "0x181C6D0")]
		public static extern void ovr_AbuseReportOptions_Destroy(IntPtr handle);

		[PreserveSig]
		[Token(Token = "0x60003AE")]
		[Address(RVA = "0x181C434", Offset = "0x181C434", VA = "0x181C434")]
		public static extern void ovr_AbuseReportOptions_SetPreventPeopleChooser(IntPtr handle, bool value);

		[PreserveSig]
		[Token(Token = "0x60003AF")]
		[Address(RVA = "0x181C53C", Offset = "0x181C53C", VA = "0x181C53C")]
		public static extern void ovr_AbuseReportOptions_SetReportType(IntPtr handle, AbuseReportType value);

		[PreserveSig]
		[Token(Token = "0x60003B0")]
		[Address(RVA = "0x181E05C", Offset = "0x181E05C", VA = "0x181E05C")]
		public static extern IntPtr ovr_ApplicationOptions_Create();

		[PreserveSig]
		[Token(Token = "0x60003B1")]
		[Address(RVA = "0x181E2A8", Offset = "0x181E2A8", VA = "0x181E2A8")]
		public static extern void ovr_ApplicationOptions_Destroy(IntPtr handle);

		[Token(Token = "0x60003B2")]
		[Address(RVA = "0x181E148", Offset = "0x181E148", VA = "0x181E148")]
		public static void ovr_ApplicationOptions_SetDeeplinkMessage(IntPtr handle, string value)
		{
		}

		[PreserveSig]
		[Token(Token = "0x60003B3")]
		[Address(RVA = "0x1837D54", Offset = "0x1837D54", VA = "0x1837D54")]
		private static extern void ovr_ApplicationOptions_SetDeeplinkMessage_Native(IntPtr handle, IntPtr value);

		[PreserveSig]
		[Token(Token = "0x60003B4")]
		[Address(RVA = "0x1837DE4", Offset = "0x1837DE4", VA = "0x1837DE4")]
		public static extern IntPtr ovr_MatchmakingOptions_Create();

		[PreserveSig]
		[Token(Token = "0x60003B5")]
		[Address(RVA = "0x1837E58", Offset = "0x1837E58", VA = "0x1837E58")]
		public static extern void ovr_MatchmakingOptions_Destroy(IntPtr handle);

		[Token(Token = "0x60003B6")]
		[Address(RVA = "0x1837ED8", Offset = "0x1837ED8", VA = "0x1837ED8")]
		public static void ovr_MatchmakingOptions_SetCreateRoomDataStoreString(IntPtr handle, string key, string value)
		{
		}

		[PreserveSig]
		[Token(Token = "0x60003B7")]
		[Address(RVA = "0x1837FA4", Offset = "0x1837FA4", VA = "0x1837FA4")]
		private static extern void ovr_MatchmakingOptions_SetCreateRoomDataStoreString_Native(IntPtr handle, IntPtr key, IntPtr value);

		[PreserveSig]
		[Token(Token = "0x60003B8")]
		[Address(RVA = "0x183803C", Offset = "0x183803C", VA = "0x183803C")]
		public static extern void ovr_MatchmakingOptions_ClearCreateRoomDataStore(IntPtr handle);

		[PreserveSig]
		[Token(Token = "0x60003B9")]
		[Address(RVA = "0x18380BC", Offset = "0x18380BC", VA = "0x18380BC")]
		public static extern void ovr_MatchmakingOptions_SetCreateRoomJoinPolicy(IntPtr handle, RoomJoinPolicy value);

		[PreserveSig]
		[Token(Token = "0x60003BA")]
		[Address(RVA = "0x183814C", Offset = "0x183814C", VA = "0x183814C")]
		public static extern void ovr_MatchmakingOptions_SetCreateRoomMaxUsers(IntPtr handle, uint value);

		[PreserveSig]
		[Token(Token = "0x60003BB")]
		[Address(RVA = "0x18381DC", Offset = "0x18381DC", VA = "0x18381DC")]
		public static extern void ovr_MatchmakingOptions_AddEnqueueAdditionalUser(IntPtr handle, ulong value);

		[PreserveSig]
		[Token(Token = "0x60003BC")]
		[Address(RVA = "0x183826C", Offset = "0x183826C", VA = "0x183826C")]
		public static extern void ovr_MatchmakingOptions_ClearEnqueueAdditionalUsers(IntPtr handle);

		[Token(Token = "0x60003BD")]
		[Address(RVA = "0x18382EC", Offset = "0x18382EC", VA = "0x18382EC")]
		public static void ovr_MatchmakingOptions_SetEnqueueDataSettingsInt(IntPtr handle, string key, int value)
		{
		}

		[PreserveSig]
		[Token(Token = "0x60003BE")]
		[Address(RVA = "0x18383A0", Offset = "0x18383A0", VA = "0x18383A0")]
		private static extern void ovr_MatchmakingOptions_SetEnqueueDataSettingsInt_Native(IntPtr handle, IntPtr key, int value);

		[Token(Token = "0x60003BF")]
		[Address(RVA = "0x1838438", Offset = "0x1838438", VA = "0x1838438")]
		public static void ovr_MatchmakingOptions_SetEnqueueDataSettingsDouble(IntPtr handle, string key, double value)
		{
		}

		[PreserveSig]
		[Token(Token = "0x60003C0")]
		[Address(RVA = "0x18384F4", Offset = "0x18384F4", VA = "0x18384F4")]
		private static extern void ovr_MatchmakingOptions_SetEnqueueDataSettingsDouble_Native(IntPtr handle, IntPtr key, double value);

		[Token(Token = "0x60003C1")]
		[Address(RVA = "0x1838594", Offset = "0x1838594", VA = "0x1838594")]
		public static void ovr_MatchmakingOptions_SetEnqueueDataSettingsString(IntPtr handle, string key, string value)
		{
		}

		[PreserveSig]
		[Token(Token = "0x60003C2")]
		[Address(RVA = "0x1838660", Offset = "0x1838660", VA = "0x1838660")]
		private static extern void ovr_MatchmakingOptions_SetEnqueueDataSettingsString_Native(IntPtr handle, IntPtr key, IntPtr value);

		[PreserveSig]
		[Token(Token = "0x60003C3")]
		[Address(RVA = "0x18386F8", Offset = "0x18386F8", VA = "0x18386F8")]
		public static extern void ovr_MatchmakingOptions_ClearEnqueueDataSettings(IntPtr handle);

		[PreserveSig]
		[Token(Token = "0x60003C4")]
		[Address(RVA = "0x1838778", Offset = "0x1838778", VA = "0x1838778")]
		public static extern void ovr_MatchmakingOptions_SetEnqueueIsDebug(IntPtr handle, bool value);

		[Token(Token = "0x60003C5")]
		[Address(RVA = "0x1838808", Offset = "0x1838808", VA = "0x1838808")]
		public static void ovr_MatchmakingOptions_SetEnqueueQueryKey(IntPtr handle, string value)
		{
		}

		[PreserveSig]
		[Token(Token = "0x60003C6")]
		[Address(RVA = "0x18388B4", Offset = "0x18388B4", VA = "0x18388B4")]
		private static extern void ovr_MatchmakingOptions_SetEnqueueQueryKey_Native(IntPtr handle, IntPtr value);

		[PreserveSig]
		[Token(Token = "0x60003C7")]
		[Address(RVA = "0x1838944", Offset = "0x1838944", VA = "0x1838944")]
		public static extern IntPtr ovr_RoomOptions_Create();

		[PreserveSig]
		[Token(Token = "0x60003C8")]
		[Address(RVA = "0x18389B8", Offset = "0x18389B8", VA = "0x18389B8")]
		public static extern void ovr_RoomOptions_Destroy(IntPtr handle);

		[Token(Token = "0x60003C9")]
		[Address(RVA = "0x1838A38", Offset = "0x1838A38", VA = "0x1838A38")]
		public static void ovr_RoomOptions_SetDataStoreString(IntPtr handle, string key, string value)
		{
		}

		[PreserveSig]
		[Token(Token = "0x60003CA")]
		[Address(RVA = "0x1838B04", Offset = "0x1838B04", VA = "0x1838B04")]
		private static extern void ovr_RoomOptions_SetDataStoreString_Native(IntPtr handle, IntPtr key, IntPtr value);

		[PreserveSig]
		[Token(Token = "0x60003CB")]
		[Address(RVA = "0x1838B9C", Offset = "0x1838B9C", VA = "0x1838B9C")]
		public static extern void ovr_RoomOptions_ClearDataStore(IntPtr handle);

		[PreserveSig]
		[Token(Token = "0x60003CC")]
		[Address(RVA = "0x1838C1C", Offset = "0x1838C1C", VA = "0x1838C1C")]
		public static extern void ovr_RoomOptions_SetExcludeRecentlyMet(IntPtr handle, bool value);

		[PreserveSig]
		[Token(Token = "0x60003CD")]
		[Address(RVA = "0x1838CAC", Offset = "0x1838CAC", VA = "0x1838CAC")]
		public static extern void ovr_RoomOptions_SetMaxUserResults(IntPtr handle, uint value);

		[PreserveSig]
		[Token(Token = "0x60003CE")]
		[Address(RVA = "0x1838D3C", Offset = "0x1838D3C", VA = "0x1838D3C")]
		public static extern void ovr_RoomOptions_SetOrdering(IntPtr handle, UserOrdering value);

		[PreserveSig]
		[Token(Token = "0x60003CF")]
		[Address(RVA = "0x1838DCC", Offset = "0x1838DCC", VA = "0x1838DCC")]
		public static extern void ovr_RoomOptions_SetRecentlyMetTimeWindow(IntPtr handle, TimeWindow value);

		[PreserveSig]
		[Token(Token = "0x60003D0")]
		[Address(RVA = "0x1838E5C", Offset = "0x1838E5C", VA = "0x1838E5C")]
		public static extern void ovr_RoomOptions_SetRoomId(IntPtr handle, ulong value);

		[PreserveSig]
		[Token(Token = "0x60003D1")]
		[Address(RVA = "0x1838EEC", Offset = "0x1838EEC", VA = "0x1838EEC")]
		public static extern void ovr_RoomOptions_SetTurnOffUpdates(IntPtr handle, bool value);

		[PreserveSig]
		[Token(Token = "0x60003D2")]
		[Address(RVA = "0x1838F7C", Offset = "0x1838F7C", VA = "0x1838F7C")]
		public static extern IntPtr ovr_UserOptions_Create();

		[PreserveSig]
		[Token(Token = "0x60003D3")]
		[Address(RVA = "0x1838FF0", Offset = "0x1838FF0", VA = "0x1838FF0")]
		public static extern void ovr_UserOptions_Destroy(IntPtr handle);

		[PreserveSig]
		[Token(Token = "0x60003D4")]
		[Address(RVA = "0x1839070", Offset = "0x1839070", VA = "0x1839070")]
		public static extern void ovr_UserOptions_SetMaxUsers(IntPtr handle, uint value);

		[PreserveSig]
		[Token(Token = "0x60003D5")]
		[Address(RVA = "0x1839100", Offset = "0x1839100", VA = "0x1839100")]
		public static extern void ovr_UserOptions_AddServiceProvider(IntPtr handle, ServiceProvider value);

		[PreserveSig]
		[Token(Token = "0x60003D6")]
		[Address(RVA = "0x1839190", Offset = "0x1839190", VA = "0x1839190")]
		public static extern void ovr_UserOptions_ClearServiceProviders(IntPtr handle);

		[PreserveSig]
		[Token(Token = "0x60003D7")]
		[Address(RVA = "0x1839210", Offset = "0x1839210", VA = "0x1839210")]
		public static extern void ovr_UserOptions_SetTimeWindow(IntPtr handle, TimeWindow value);

		[PreserveSig]
		[Token(Token = "0x60003D8")]
		[Address(RVA = "0x18392A0", Offset = "0x18392A0", VA = "0x18392A0")]
		public static extern IntPtr ovr_VoipOptions_Create();

		[PreserveSig]
		[Token(Token = "0x60003D9")]
		[Address(RVA = "0x1839314", Offset = "0x1839314", VA = "0x1839314")]
		public static extern void ovr_VoipOptions_Destroy(IntPtr handle);

		[PreserveSig]
		[Token(Token = "0x60003DA")]
		[Address(RVA = "0x1839394", Offset = "0x1839394", VA = "0x1839394")]
		public static extern void ovr_VoipOptions_SetBitrateForNewConnections(IntPtr handle, VoipBitrate value);

		[PreserveSig]
		[Token(Token = "0x60003DB")]
		[Address(RVA = "0x1839424", Offset = "0x1839424", VA = "0x1839424")]
		public static extern void ovr_VoipOptions_SetCreateNewConnectionUseDtx(IntPtr handle, VoipDtxState value);

		[Token(Token = "0x60003DC")]
		[Address(RVA = "0x18394B4", Offset = "0x18394B4", VA = "0x18394B4")]
		public CAPI()
		{
		}
	}
	[Token(Token = "0x2000031")]
	public static class Callback
	{
		[Token(Token = "0x2000174")]
		private class RequestCallback
		{
			[Token(Token = "0x4000563")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private Message.Callback messageCallback;

			[Token(Token = "0x600098B")]
			[Address(RVA = "0x1D4633C", Offset = "0x1D4633C", VA = "0x1D4633C")]
			public RequestCallback()
			{
			}

			[Token(Token = "0x600098C")]
			[Address(RVA = "0x1D45C5C", Offset = "0x1D45C5C", VA = "0x1D45C5C")]
			public RequestCallback(Message.Callback callback)
			{
			}

			[Token(Token = "0x600098D")]
			[Address(RVA = "0x1D46344", Offset = "0x1D46344", VA = "0x1D46344", Slot = "4")]
			public virtual void HandleMessage(Message msg)
			{
			}
		}

		[Token(Token = "0x2000175")]
		private sealed class RequestCallback<T> : RequestCallback
		{
			[Token(Token = "0x4000564")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private Message<T>.Callback callback;

			[Token(Token = "0x600098E")]
			public RequestCallback(Message<T>.Callback callback)
			{
			}

			[Token(Token = "0x600098F")]
			public override void HandleMessage(Message msg)
			{
			}
		}

		[Token(Token = "0x40000B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static Dictionary<ulong, RequestCallback> requestIDsToCallbacks;

		[Token(Token = "0x40000BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static Dictionary<Message.MessageType, RequestCallback> notificationCallbacks;

		[Token(Token = "0x40000BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static bool hasRegisteredRoomInviteNotificationHandler;

		[Token(Token = "0x40000BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static List<Message> pendingRoomInviteNotifications;

		[Token(Token = "0x60003DE")]
		internal static void SetNotificationCallback<T>(Message.MessageType type, Message<T>.Callback callback)
		{
		}

		[Token(Token = "0x60003DF")]
		[Address(RVA = "0x1D45B64", Offset = "0x1D45B64", VA = "0x1D45B64")]
		internal static void SetNotificationCallback(Message.MessageType type, Message.Callback callback)
		{
		}

		[Token(Token = "0x60003E0")]
		internal static void OnComplete<T>(Request<T> request, Message<T>.Callback callback)
		{
		}

		[Token(Token = "0x60003E1")]
		[Address(RVA = "0x1D45C88", Offset = "0x1D45C88", VA = "0x1D45C88")]
		internal static void OnComplete(Request request, Message.Callback callback)
		{
		}

		[Token(Token = "0x60003E2")]
		[Address(RVA = "0x1D45D48", Offset = "0x1D45D48", VA = "0x1D45D48")]
		internal static void RunCallbacks()
		{
		}

		[Token(Token = "0x60003E3")]
		[Address(RVA = "0x1D46054", Offset = "0x1D46054", VA = "0x1D46054")]
		internal static void RunLimitedCallbacks(uint limit)
		{
		}

		[Token(Token = "0x60003E4")]
		[Address(RVA = "0x1D460EC", Offset = "0x1D460EC", VA = "0x1D460EC")]
		private static void FlushRoomInviteNotificationQueue()
		{
		}

		[Token(Token = "0x60003E5")]
		[Address(RVA = "0x1D45EB8", Offset = "0x1D45EB8", VA = "0x1D45EB8")]
		private static void HandleMessage(Message msg)
		{
		}
	}
	[Token(Token = "0x2000032")]
	public class CallbackRunner : MonoBehaviour
	{
		[Token(Token = "0x40000BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool IsPersistantBetweenSceneLoads;

		[PreserveSig]
		[Token(Token = "0x60003E7")]
		[Address(RVA = "0x1D466E8", Offset = "0x1D466E8", VA = "0x1D466E8")]
		private static extern void ovr_UnityResetTestPlatform();

		[Token(Token = "0x60003E8")]
		[Address(RVA = "0x1D46758", Offset = "0x1D46758", VA = "0x1D46758")]
		private void Awake()
		{
		}

		[Token(Token = "0x60003E9")]
		[Address(RVA = "0x1D46854", Offset = "0x1D46854", VA = "0x1D46854")]
		private void Update()
		{
		}

		[Token(Token = "0x60003EA")]
		[Address(RVA = "0x1D468E0", Offset = "0x1D468E0", VA = "0x1D468E0")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60003EB")]
		[Address(RVA = "0x1D468E4", Offset = "0x1D468E4", VA = "0x1D468E4")]
		public CallbackRunner()
		{
		}
	}
	[Token(Token = "0x2000033")]
	public enum CloudStorageDataStatus
	{
		[Token(Token = "0x40000BF")]
		[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x1183BF0", Offset = "0x1183BF0")]
		Unknown,
		[Token(Token = "0x40000C0")]
		[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x1183C28", Offset = "0x1183C28")]
		InSync,
		[Token(Token = "0x40000C1")]
		[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x1183C60", Offset = "0x1183C60")]
		NeedsDownload,
		[Token(Token = "0x40000C2")]
		[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x1183C98", Offset = "0x1183C98")]
		RemoteDownloading,
		[Token(Token = "0x40000C3")]
		[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x1183CD0", Offset = "0x1183CD0")]
		NeedsUpload,
		[Token(Token = "0x40000C4")]
		[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x1183D08", Offset = "0x1183D08")]
		LocalUploading,
		[Token(Token = "0x40000C5")]
		[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x1183D40", Offset = "0x1183D40")]
		InConflict
	}
	[Token(Token = "0x2000034")]
	public enum CloudStorageUpdateStatus
	{
		[Token(Token = "0x40000C7")]
		[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x1183D78", Offset = "0x1183D78")]
		Unknown,
		[Token(Token = "0x40000C8")]
		[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x1183DB0", Offset = "0x1183DB0")]
		Ok,
		[Token(Token = "0x40000C9")]
		[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x1183DE8", Offset = "0x1183DE8")]
		BetterVersionStored,
		[Token(Token = "0x40000CA")]
		[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x1183E20", Offset = "0x1183E20")]
		ManualMergeRequired
	}
	[Token(Token = "0x2000035")]
	public interface IVoipPCMSource
	{
		[Token(Token = "0x60003EC")]
		int GetPCM(float[] dest, int length);

		[Token(Token = "0x60003ED")]
		void SetSenderID(ulong senderID);

		[Token(Token = "0x60003EE")]
		void Update();

		[Token(Token = "0x60003EF")]
		int PeekSizeElements();
	}
	[Token(Token = "0x2000036")]
	public enum KeyValuePairType
	{
		[Token(Token = "0x40000CC")]
		[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x1183E58", Offset = "0x1183E58")]
		String,
		[Token(Token = "0x40000CD")]
		[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x1183E90", Offset = "0x1183E90")]
		Int,
		[Token(Token = "0x40000CE")]
		[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x1183EC8", Offset = "0x1183EC8")]
		Double,
		[Token(Token = "0x40000CF")]
		[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x1183F00", Offset = "0x1183F00")]
		Unknown
	}
	[Token(Token = "0x2000037")]
	public enum LaunchType
	{
		[Token(Token = "0x40000D1")]
		[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x1183F38", Offset = "0x1183F38")]
		Unknown,
		[Token(Token = "0x40000D2")]
		[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x1183F70", Offset = "0x1183F70")]
		Normal,
		[Token(Token = "0x40000D3")]
		[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x1183FA8", Offset = "0x1183FA8")]
		Invite,
		[Token(Token = "0x40000D4")]
		[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x1183FE0", Offset = "0x1183FE0")]
		Coordinated,
		[Token(Token = "0x40000D5")]
		[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x1184018", Offset = "0x1184018")]
		Deeplink
	}
	[Token(Token = "0x2000038")]
	public enum LeaderboardFilterType
	{
		[Token(Token = "0x40000D7")]
		[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x1184050", Offset = "0x1184050")]
		None,
		[Token(Token = "0x40000D8")]
		[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x1184088", Offset = "0x1184088")]
		Friends,
		[Token(Token = "0x40000D9")]
		[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x11840C0", Offset = "0x11840C0")]
		Unknown
	}
	[Token(Token = "0x2000039")]
	public enum LeaderboardStartAt
	{
		[Token(Token = "0x40000DB")]
		[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x11840F8", Offset = "0x11840F8")]
		Top,
		[Token(Token = "0x40000DC")]
		[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x1184130", Offset = "0x1184130")]
		CenteredOnViewer,
		[Token(Token = "0x40000DD")]
		[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x1184168", Offset = "0x1184168")]
		CenteredOnViewerOrTop,
		[Token(Token = "0x40000DE")]
		[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x11841A0", Offset = "0x11841A0")]
		Unknown
	}
	[Token(Token = "0x200003A")]
	public enum LivestreamingAudience
	{
		[Token(Token = "0x40000E0")]
		[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x11841D8", Offset = "0x11841D8")]
		Unknown,
		[Token(Token = "0x40000E1")]
		[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x1184210", Offset = "0x1184210")]
		Public,
		[Token(Token = "0x40000E2")]
		[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x1184248", Offset = "0x1184248")]
		Friends,
		[Token(Token = "0x40000E3")]
		[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x1184280", Offset = "0x1184280")]
		OnlyMe
	}
	[Token(Token = "0x200003B")]
	public enum LivestreamingStartStatus
	{
		[Token(Token = "0x40000E5")]
		[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x11842B8", Offset = "0x11842B8")]
		Success = 1,
		[Token(Token = "0x40000E6")]
		[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x11842F0", Offset = "0x11842F0")]
		Unknown = 0,
		[Token(Token = "0x40000E7")]
		[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x1184328", Offset = "0x1184328")]
		NoPackageSet = -1,
		[Token(Token = "0x40000E8")]
		[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x1184360", Offset = "0x1184360")]
		NoFbConnect = -2,
		[Token(Token = "0x40000E9")]
		[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x1184398", Offset = "0x1184398")]
		NoSessionId = -3,
		[Token(Token = "0x40000EA")]
		[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x11843D0", Offset = "0x11843D0")]
		MissingParameters = -4
	}
	[Token(Token = "0x200003C")]
	public enum MatchmakingCriterionImportance
	{
		[Token(Token = "0x40000EC")]
		[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x1184408", Offset = "0x1184408")]
		Required,
		[Token(Token = "0x40000ED")]
		[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x1184440", Offset = "0x1184440")]
		High,
		[Token(Token = "0x40000EE")]
		[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x1184478", Offset = "0x1184478")]
		Medium,
		[Token(Token = "0x40000EF")]
		[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x11844B0", Offset = "0x11844B0")]
		Low,
		[Token(Token = "0x40000F0")]
		[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x11844E8", Offset = "0x11844E8")]
		Unknown
	}
	[Token(Token = "0x200003D")]
	public class MatchmakingOptions
	{
		[Token(Token = "0x40000F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private IntPtr Handle;

		[Token(Token = "0x60003F0")]
		[Address(RVA = "0x1D4AC08", Offset = "0x1D4AC08", VA = "0x1D4AC08")]
		public MatchmakingOptions()
		{
		}

		[Token(Token = "0x60003F1")]
		[Address(RVA = "0x1D4AC80", Offset = "0x1D4AC80", VA = "0x1D4AC80")]
		public void SetCreateRoomDataStore(string key, string value)
		{
		}

		[Token(Token = "0x60003F2")]
		[Address(RVA = "0x1D4AD04", Offset = "0x1D4AD04", VA = "0x1D4AD04")]
		public void ClearCreateRoomDataStore()
		{
		}

		[Token(Token = "0x60003F3")]
		[Address(RVA = "0x1D4AD70", Offset = "0x1D4AD70", VA = "0x1D4AD70")]
		public void SetCreateRoomJoinPolicy(RoomJoinPolicy value)
		{
		}

		[Token(Token = "0x60003F4")]
		[Address(RVA = "0x1D4ADEC", Offset = "0x1D4ADEC", VA = "0x1D4ADEC")]
		public void SetCreateRoomMaxUsers(uint value)
		{
		}

		[Token(Token = "0x60003F5")]
		[Address(RVA = "0x1D4AE68", Offset = "0x1D4AE68", VA = "0x1D4AE68")]
		public void AddEnqueueAdditionalUser(ulong userID)
		{
		}

		[Token(Token = "0x60003F6")]
		[Address(RVA = "0x1D4AEE4", Offset = "0x1D4AEE4", VA = "0x1D4AEE4")]
		public void ClearEnqueueAdditionalUsers()
		{
		}

		[Token(Token = "0x60003F7")]
		[Address(RVA = "0x1D4AF50", Offset = "0x1D4AF50", VA = "0x1D4AF50")]
		public void SetEnqueueDataSettings(string key, int value)
		{
		}

		[Token(Token = "0x60003F8")]
		[Address(RVA = "0x1D4AFD4", Offset = "0x1D4AFD4", VA = "0x1D4AFD4")]
		public void SetEnqueueDataSettings(string key, double value)
		{
		}

		[Token(Token = "0x60003F9")]
		[Address(RVA = "0x1D4B060", Offset = "0x1D4B060", VA = "0x1D4B060")]
		public void SetEnqueueDataSettings(string key, string value)
		{
		}

		[Token(Token = "0x60003FA")]
		[Address(RVA = "0x1D4B0E4", Offset = "0x1D4B0E4", VA = "0x1D4B0E4")]
		public void ClearEnqueueDataSettings()
		{
		}

		[Token(Token = "0x60003FB")]
		[Address(RVA = "0x1D4B150", Offset = "0x1D4B150", VA = "0x1D4B150")]
		public void SetEnqueueIsDebug(bool value)
		{
		}

		[Token(Token = "0x60003FC")]
		[Address(RVA = "0x1D4B1CC", Offset = "0x1D4B1CC", VA = "0x1D4B1CC")]
		public void SetEnqueueQueryKey(string value)
		{
		}

		[Token(Token = "0x60003FD")]
		[Address(RVA = "0x1D49B9C", Offset = "0x1D49B9C", VA = "0x1D49B9C")]
		public static explicit operator IntPtr(MatchmakingOptions options)
		{
			return default(IntPtr);
		}

		[Token(Token = "0x60003FE")]
		[Address(RVA = "0x1D4B248", Offset = "0x1D4B248", VA = "0x1D4B248", Slot = "1")]
		~MatchmakingOptions()
		{
		}
	}
	[Token(Token = "0x200003E")]
	public enum MatchmakingStatApproach
	{
		[Token(Token = "0x40000F3")]
		[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x1184520", Offset = "0x1184520")]
		Unknown,
		[Token(Token = "0x40000F4")]
		[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x1184558", Offset = "0x1184558")]
		Trailing,
		[Token(Token = "0x40000F5")]
		[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x1184590", Offset = "0x1184590")]
		Swingy
	}
	[Token(Token = "0x200003F")]
	public enum MediaContentType
	{
		[Token(Token = "0x40000F7")]
		[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x11845C8", Offset = "0x11845C8")]
		Unknown,
		[Token(Token = "0x40000F8")]
		[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x1184600", Offset = "0x1184600")]
		Photo
	}
	[Token(Token = "0x2000040")]
	public abstract class Message<T> : Message
	{
		[Token(Token = "0x2000176")]
		public new delegate void Callback(Message<T> message);

		[Token(Token = "0x40000F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private T data;

		[Token(Token = "0x17000009")]
		public T Data
		{
			[Token(Token = "0x6000400")]
			get
			{
				return (T)null;
			}
		}

		[Token(Token = "0x60003FF")]
		public Message(IntPtr c_message)
		{
		}

		[Token(Token = "0x6000401")]
		protected abstract T GetDataFromMessage(IntPtr c_message);
	}
	[Token(Token = "0x2000041")]
	public class Message
	{
		[Token(Token = "0x2000177")]
		public delegate void Callback(Message message);

		[Token(Token = "0x2000178")]
		public enum MessageType : uint
		{
			[Token(Token = "0x4000566")]
			Unknown = 0u,
			[Token(Token = "0x4000567")]
			Achievements_AddCount = 65495601u,
			[Token(Token = "0x4000568")]
			Achievements_AddFields = 346693929u,
			[Token(Token = "0x4000569")]
			Achievements_GetAllDefinitions = 64177549u,
			[Token(Token = "0x400056A")]
			Achievements_GetAllProgress = 1335877149u,
			[Token(Token = "0x400056B")]
			Achievements_GetDefinitionsByName = 1653670332u,
			[Token(Token = "0x400056C")]
			Achievements_GetNextAchievementDefinitionArrayPage = 712888917u,
			[Token(Token = "0x400056D")]
			Achievements_GetNextAchievementProgressArrayPage = 792913703u,
			[Token(Token = "0x400056E")]
			Achievements_GetProgressByName = 354837425u,
			[Token(Token = "0x400056F")]
			Achievements_Unlock = 1497156573u,
			[Token(Token = "0x4000570")]
			ApplicationLifecycle_GetRegisteredPIDs = 82169698u,
			[Token(Token = "0x4000571")]
			ApplicationLifecycle_GetSessionKey = 984570141u,
			[Token(Token = "0x4000572")]
			ApplicationLifecycle_RegisterSessionKey = 1303818232u,
			[Token(Token = "0x4000573")]
			Application_GetVersion = 1751583246u,
			[Token(Token = "0x4000574")]
			Application_LaunchOtherApp = 1424151032u,
			[Token(Token = "0x4000575")]
			AssetFile_Delete = 1834842246u,
			[Token(Token = "0x4000576")]
			AssetFile_DeleteById = 1525206354u,
			[Token(Token = "0x4000577")]
			AssetFile_DeleteByName = 1108001231u,
			[Token(Token = "0x4000578")]
			AssetFile_Download = 289710021u,
			[Token(Token = "0x4000579")]
			AssetFile_DownloadById = 755009938u,
			[Token(Token = "0x400057A")]
			AssetFile_DownloadByName = 1664536314u,
			[Token(Token = "0x400057B")]
			AssetFile_DownloadCancel = 134927303u,
			[Token(Token = "0x400057C")]
			AssetFile_DownloadCancelById = 1365611796u,
			[Token(Token = "0x400057D")]
			AssetFile_DownloadCancelByName = 1147858170u,
			[Token(Token = "0x400057E")]
			AssetFile_GetList = 1258057588u,
			[Token(Token = "0x400057F")]
			AssetFile_Status = 47394656u,
			[Token(Token = "0x4000580")]
			AssetFile_StatusById = 1570069816u,
			[Token(Token = "0x4000581")]
			AssetFile_StatusByName = 1104140880u,
			[Token(Token = "0x4000582")]
			CloudStorage_Delete = 685393261u,
			[Token(Token = "0x4000583")]
			CloudStorage_GetNextCloudStorageMetadataArrayPage = 1544004335u,
			[Token(Token = "0x4000584")]
			CloudStorage_Load = 1082420033u,
			[Token(Token = "0x4000585")]
			CloudStorage_LoadBucketMetadata = 1931977997u,
			[Token(Token = "0x4000586")]
			CloudStorage_LoadConflictMetadata = 1146770162u,
			[Token(Token = "0x4000587")]
			CloudStorage_LoadHandle = 845863478u,
			[Token(Token = "0x4000588")]
			CloudStorage_LoadMetadata = 65446546u,
			[Token(Token = "0x4000589")]
			CloudStorage_ResolveKeepLocal = 811109637u,
			[Token(Token = "0x400058A")]
			CloudStorage_ResolveKeepRemote = 1965400838u,
			[Token(Token = "0x400058B")]
			CloudStorage_Save = 1270570030u,
			[Token(Token = "0x400058C")]
			Entitlement_GetIsViewerEntitled = 409688241u,
			[Token(Token = "0x400058D")]
			IAP_ConsumePurchase = 532378329u,
			[Token(Token = "0x400058E")]
			IAP_GetNextProductArrayPage = 467225263u,
			[Token(Token = "0x400058F")]
			IAP_GetNextPurchaseArrayPage = 1196886677u,
			[Token(Token = "0x4000590")]
			IAP_GetProductsBySKU = 2124073717u,
			[Token(Token = "0x4000591")]
			IAP_GetViewerPurchases = 974095385u,
			[Token(Token = "0x4000592")]
			IAP_LaunchCheckoutFlow = 1067126029u,
			[Token(Token = "0x4000593")]
			LanguagePack_GetCurrent = 529592533u,
			[Token(Token = "0x4000594")]
			LanguagePack_SetCurrent = 1531952096u,
			[Token(Token = "0x4000595")]
			Leaderboard_GetEntries = 1572030284u,
			[Token(Token = "0x4000596")]
			Leaderboard_GetEntriesAfterRank = 406293487u,
			[Token(Token = "0x4000597")]
			Leaderboard_GetNextEntries = 1310751961u,
			[Token(Token = "0x4000598")]
			Leaderboard_GetPreviousEntries = 1224858304u,
			[Token(Token = "0x4000599")]
			Leaderboard_WriteEntry = 293587198u,
			[Token(Token = "0x400059A")]
			Livestreaming_GetStatus = 1218079125u,
			[Token(Token = "0x400059B")]
			Livestreaming_PauseStream = 916223619u,
			[Token(Token = "0x400059C")]
			Livestreaming_ResumeStream = 575827343u,
			[Token(Token = "0x400059D")]
			Matchmaking_Browse = 509948616u,
			[Token(Token = "0x400059E")]
			Matchmaking_Browse2 = 1715641947u,
			[Token(Token = "0x400059F")]
			Matchmaking_Cancel = 543705519u,
			[Token(Token = "0x40005A0")]
			Matchmaking_Cancel2 = 285117908u,
			[Token(Token = "0x40005A1")]
			Matchmaking_CreateAndEnqueueRoom = 1615617480u,
			[Token(Token = "0x40005A2")]
			Matchmaking_CreateAndEnqueueRoom2 = 693889755u,
			[Token(Token = "0x40005A3")]
			Matchmaking_CreateRoom = 54203178u,
			[Token(Token = "0x40005A4")]
			Matchmaking_CreateRoom2 = 1231922052u,
			[Token(Token = "0x40005A5")]
			Matchmaking_Enqueue = 1086418033u,
			[Token(Token = "0x40005A6")]
			Matchmaking_Enqueue2 = 303174325u,
			[Token(Token = "0x40005A7")]
			Matchmaking_EnqueueRoom = 1888108644u,
			[Token(Token = "0x40005A8")]
			Matchmaking_EnqueueRoom2 = 1428741028u,
			[Token(Token = "0x40005A9")]
			Matchmaking_GetAdminSnapshot = 1008820116u,
			[Token(Token = "0x40005AA")]
			Matchmaking_GetStats = 1123849272u,
			[Token(Token = "0x40005AB")]
			Matchmaking_JoinRoom = 1295177725u,
			[Token(Token = "0x40005AC")]
			Matchmaking_ReportResultInsecure = 439800205u,
			[Token(Token = "0x40005AD")]
			Matchmaking_StartMatch = 1154746693u,
			[Token(Token = "0x40005AE")]
			Media_ShareToFacebook = 14912239u,
			[Token(Token = "0x40005AF")]
			Notification_GetNextRoomInviteNotificationArrayPage = 102890359u,
			[Token(Token = "0x40005B0")]
			Notification_GetRoomInvites = 1871801234u,
			[Token(Token = "0x40005B1")]
			Notification_MarkAsRead = 1903319523u,
			[Token(Token = "0x40005B2")]
			Party_GetCurrent = 1200830304u,
			[Token(Token = "0x40005B3")]
			Room_CreateAndJoinPrivate = 1977017207u,
			[Token(Token = "0x40005B4")]
			Room_CreateAndJoinPrivate2 = 1513775683u,
			[Token(Token = "0x40005B5")]
			Room_Get = 1704628152u,
			[Token(Token = "0x40005B6")]
			Room_GetCurrent = 161916164u,
			[Token(Token = "0x40005B7")]
			Room_GetCurrentForUser = 234887141u,
			[Token(Token = "0x40005B8")]
			Room_GetInvitableUsers = 506615698u,
			[Token(Token = "0x40005B9")]
			Room_GetInvitableUsers2 = 1330899120u,
			[Token(Token = "0x40005BA")]
			Room_GetModeratedRooms = 159645047u,
			[Token(Token = "0x40005BB")]
			Room_GetNextRoomArrayPage = 1317239238u,
			[Token(Token = "0x40005BC")]
			Room_InviteUser = 1093266451u,
			[Token(Token = "0x40005BD")]
			Room_Join = 382373641u,
			[Token(Token = "0x40005BE")]
			Room_Join2 = 1303059522u,
			[Token(Token = "0x40005BF")]
			Room_KickUser = 1233344310u,
			[Token(Token = "0x40005C0")]
			Room_LaunchInvitableUserFlow = 843047539u,
			[Token(Token = "0x40005C1")]
			Room_Leave = 1916281973u,
			[Token(Token = "0x40005C2")]
			Room_SetDescription = 809796911u,
			[Token(Token = "0x40005C3")]
			Room_UpdateDataStore = 40779816u,
			[Token(Token = "0x40005C4")]
			Room_UpdateMembershipLockStatus = 923514796u,
			[Token(Token = "0x40005C5")]
			Room_UpdateOwner = 850803997u,
			[Token(Token = "0x40005C6")]
			Room_UpdatePrivateRoomJoinPolicy = 289473179u,
			[Token(Token = "0x40005C7")]
			User_Get = 1808768583u,
			[Token(Token = "0x40005C8")]
			User_GetAccessToken = 111696574u,
			[Token(Token = "0x40005C9")]
			User_GetLoggedInUser = 1131361373u,
			[Token(Token = "0x40005CA")]
			User_GetLoggedInUserFriends = 1484532365u,
			[Token(Token = "0x40005CB")]
			User_GetLoggedInUserFriendsAndRooms = 1585908615u,
			[Token(Token = "0x40005CC")]
			User_GetLoggedInUserRecentlyMetUsersAndRooms = 694139440u,
			[Token(Token = "0x40005CD")]
			User_GetNextUserAndRoomArrayPage = 2143146719u,
			[Token(Token = "0x40005CE")]
			User_GetNextUserArrayPage = 645723971u,
			[Token(Token = "0x40005CF")]
			User_GetOrgScopedID = 418426907u,
			[Token(Token = "0x40005D0")]
			User_GetSdkAccounts = 1733454467u,
			[Token(Token = "0x40005D1")]
			User_GetUserProof = 578880643u,
			[Token(Token = "0x40005D2")]
			User_LaunchFriendRequestFlow = 151303576u,
			[Token(Token = "0x40005D3")]
			User_LaunchProfile = 171537047u,
			[Token(Token = "0x40005D4")]
			Voip_SetSystemVoipSuppressed = 1161808298u,
			[Token(Token = "0x40005D5")]
			Notification_ApplicationLifecycle_LaunchIntentChanged = 78859427u,
			[Token(Token = "0x40005D6")]
			Notification_AssetFile_DownloadUpdate = 803015885u,
			[Token(Token = "0x40005D7")]
			Notification_Cal_FinalizeApplication = 1963741337u,
			[Token(Token = "0x40005D8")]
			Notification_Cal_ProposeApplication = 779375093u,
			[Token(Token = "0x40005D9")]
			Notification_HTTP_Transfer = 2111073839u,
			[Token(Token = "0x40005DA")]
			Notification_Livestreaming_StatusChange = 575101294u,
			[Token(Token = "0x40005DB")]
			Notification_Matchmaking_MatchFound = 197393623u,
			[Token(Token = "0x40005DC")]
			Notification_Networking_ConnectionStateChange = 1577243802u,
			[Token(Token = "0x40005DD")]
			Notification_Networking_PeerConnectRequest = 1295114959u,
			[Token(Token = "0x40005DE")]
			Notification_Networking_PingResult = 1360343058u,
			[Token(Token = "0x40005DF")]
			Notification_Party_PartyUpdate = 487688882u,
			[Token(Token = "0x40005E0")]
			Notification_Room_InviteAccepted = 1829794225u,
			[Token(Token = "0x40005E1")]
			Notification_Room_InviteReceived = 1783209300u,
			[Token(Token = "0x40005E2")]
			Notification_Room_RoomUpdate = 1626094639u,
			[Token(Token = "0x40005E3")]
			Notification_Voip_ConnectRequest = 908343318u,
			[Token(Token = "0x40005E4")]
			Notification_Voip_StateChange = 888120928u,
			[Token(Token = "0x40005E5")]
			Notification_Voip_SystemVoipState = 1490179237u,
			[Token(Token = "0x40005E6")]
			Platform_InitializeWithAccessToken = 896085803u,
			[Token(Token = "0x40005E7")]
			Platform_InitializeStandaloneOculus = 1375260172u,
			[Token(Token = "0x40005E8")]
			Platform_InitializeAndroidAsynchronous = 450037684u,
			[Token(Token = "0x40005E9")]
			Platform_InitializeWindowsAsynchronous = 1839708815u
		}

		[Token(Token = "0x2000179")]
		internal delegate Message ExtraMessageTypesHandler(IntPtr messageHandle, MessageType message_type);

		[Token(Token = "0x40000FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private MessageType type;

		[Token(Token = "0x40000FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private ulong requestID;

		[Token(Token = "0x40000FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Error error;

		[Token(Token = "0x40000FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1184638", Offset = "0x1184638")]
		private static ExtraMessageTypesHandler <HandleExtraMessageTypes>k__BackingField;

		[Token(Token = "0x1700000A")]
		public MessageType Type
		{
			[Token(Token = "0x6000404")]
			[Address(RVA = "0x1D4B6B4", Offset = "0x1D4B6B4", VA = "0x1D4B6B4")]
			get
			{
				return default(MessageType);
			}
		}

		[Token(Token = "0x1700000B")]
		public bool IsError
		{
			[Token(Token = "0x6000405")]
			[Address(RVA = "0x1D4B6BC", Offset = "0x1D4B6BC", VA = "0x1D4B6BC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700000C")]
		public ulong RequestID
		{
			[Token(Token = "0x6000406")]
			[Address(RVA = "0x1D4B6CC", Offset = "0x1D4B6CC", VA = "0x1D4B6CC")]
			get
			{
				return default(ulong);
			}
		}

		[Token(Token = "0x1700000D")]
		internal static ExtraMessageTypesHandler HandleExtraMessageTypes
		{
			[Token(Token = "0x6000449")]
			[Address(RVA = "0x1D4E7AC", Offset = "0x1D4E7AC", VA = "0x1D4E7AC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1186648", Offset = "0x1186648")]
			private get
			{
				return null;
			}
			[Token(Token = "0x6000448")]
			[Address(RVA = "0x1D4E758", Offset = "0x1D4E758", VA = "0x1D4E758")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1186638", Offset = "0x1186638")]
			set
			{
			}
		}

		[Token(Token = "0x6000402")]
		[Address(RVA = "0x1D4B434", Offset = "0x1D4B434", VA = "0x1D4B434")]
		public Message(IntPtr c_message)
		{
		}

		[Token(Token = "0x6000403")]
		[Address(RVA = "0x1D4B6AC", Offset = "0x1D4B6AC", VA = "0x1D4B6AC", Slot = "1")]
		~Message()
		{
		}

		[Token(Token = "0x6000407")]
		[Address(RVA = "0x1D4B6D4", Offset = "0x1D4B6D4", VA = "0x1D4B6D4", Slot = "4")]
		public virtual Error GetError()
		{
			return null;
		}

		[Token(Token = "0x6000408")]
		[Address(RVA = "0x1D4B6DC", Offset = "0x1D4B6DC", VA = "0x1D4B6DC", Slot = "5")]
		public virtual PingResult GetPingResult()
		{
			return null;
		}

		[Token(Token = "0x6000409")]
		[Address(RVA = "0x1D4B6E4", Offset = "0x1D4B6E4", VA = "0x1D4B6E4", Slot = "6")]
		public virtual NetworkingPeer GetNetworkingPeer()
		{
			return null;
		}

		[Token(Token = "0x600040A")]
		[Address(RVA = "0x1D4B6EC", Offset = "0x1D4B6EC", VA = "0x1D4B6EC", Slot = "7")]
		public virtual HttpTransferUpdate GetHttpTransferUpdate()
		{
			return null;
		}

		[Token(Token = "0x600040B")]
		[Address(RVA = "0x1D4B6F4", Offset = "0x1D4B6F4", VA = "0x1D4B6F4", Slot = "8")]
		public virtual PlatformInitialize GetPlatformInitialize()
		{
			return null;
		}

		[Token(Token = "0x600040C")]
		[Address(RVA = "0x1D4B6FC", Offset = "0x1D4B6FC", VA = "0x1D4B6FC", Slot = "9")]
		public virtual AbuseReportRecording GetAbuseReportRecording()
		{
			return null;
		}

		[Token(Token = "0x600040D")]
		[Address(RVA = "0x1D4B704", Offset = "0x1D4B704", VA = "0x1D4B704", Slot = "10")]
		public virtual AchievementDefinitionList GetAchievementDefinitions()
		{
			return null;
		}

		[Token(Token = "0x600040E")]
		[Address(RVA = "0x1D4B70C", Offset = "0x1D4B70C", VA = "0x1D4B70C", Slot = "11")]
		public virtual AchievementProgressList GetAchievementProgressList()
		{
			return null;
		}

		[Token(Token = "0x600040F")]
		[Address(RVA = "0x1D4B714", Offset = "0x1D4B714", VA = "0x1D4B714", Slot = "12")]
		public virtual AchievementUpdate GetAchievementUpdate()
		{
			return null;
		}

		[Token(Token = "0x6000410")]
		[Address(RVA = "0x1D4B71C", Offset = "0x1D4B71C", VA = "0x1D4B71C", Slot = "13")]
		public virtual ApplicationVersion GetApplicationVersion()
		{
			return null;
		}

		[Token(Token = "0x6000411")]
		[Address(RVA = "0x1D4B724", Offset = "0x1D4B724", VA = "0x1D4B724", Slot = "14")]
		public virtual AssetDetails GetAssetDetails()
		{
			return null;
		}

		[Token(Token = "0x6000412")]
		[Address(RVA = "0x1D4B72C", Offset = "0x1D4B72C", VA = "0x1D4B72C", Slot = "15")]
		public virtual AssetDetailsList GetAssetDetailsList()
		{
			return null;
		}

		[Token(Token = "0x6000413")]
		[Address(RVA = "0x1D4B734", Offset = "0x1D4B734", VA = "0x1D4B734", Slot = "16")]
		public virtual AssetFileDeleteResult GetAssetFileDeleteResult()
		{
			return null;
		}

		[Token(Token = "0x6000414")]
		[Address(RVA = "0x1D4B73C", Offset = "0x1D4B73C", VA = "0x1D4B73C", Slot = "17")]
		public virtual AssetFileDownloadCancelResult GetAssetFileDownloadCancelResult()
		{
			return null;
		}

		[Token(Token = "0x6000415")]
		[Address(RVA = "0x1D4B744", Offset = "0x1D4B744", VA = "0x1D4B744", Slot = "18")]
		public virtual AssetFileDownloadResult GetAssetFileDownloadResult()
		{
			return null;
		}

		[Token(Token = "0x6000416")]
		[Address(RVA = "0x1D4B74C", Offset = "0x1D4B74C", VA = "0x1D4B74C", Slot = "19")]
		public virtual AssetFileDownloadUpdate GetAssetFileDownloadUpdate()
		{
			return null;
		}

		[Token(Token = "0x6000417")]
		[Address(RVA = "0x1D4B754", Offset = "0x1D4B754", VA = "0x1D4B754", Slot = "20")]
		public virtual CalApplicationFinalized GetCalApplicationFinalized()
		{
			return null;
		}

		[Token(Token = "0x6000418")]
		[Address(RVA = "0x1D4B75C", Offset = "0x1D4B75C", VA = "0x1D4B75C", Slot = "21")]
		public virtual CalApplicationProposed GetCalApplicationProposed()
		{
			return null;
		}

		[Token(Token = "0x6000419")]
		[Address(RVA = "0x1D4B764", Offset = "0x1D4B764", VA = "0x1D4B764", Slot = "22")]
		public virtual CalApplicationSuggestionList GetCalApplicationSuggestionList()
		{
			return null;
		}

		[Token(Token = "0x600041A")]
		[Address(RVA = "0x1D4B76C", Offset = "0x1D4B76C", VA = "0x1D4B76C", Slot = "23")]
		public virtual CloudStorageConflictMetadata GetCloudStorageConflictMetadata()
		{
			return null;
		}

		[Token(Token = "0x600041B")]
		[Address(RVA = "0x1D4B774", Offset = "0x1D4B774", VA = "0x1D4B774", Slot = "24")]
		public virtual CloudStorageData GetCloudStorageData()
		{
			return null;
		}

		[Token(Token = "0x600041C")]
		[Address(RVA = "0x1D4B77C", Offset = "0x1D4B77C", VA = "0x1D4B77C", Slot = "25")]
		public virtual CloudStorageMetadata GetCloudStorageMetadata()
		{
			return null;
		}

		[Token(Token = "0x600041D")]
		[Address(RVA = "0x1D4B784", Offset = "0x1D4B784", VA = "0x1D4B784", Slot = "26")]
		public virtual CloudStorageMetadataList GetCloudStorageMetadataList()
		{
			return null;
		}

		[Token(Token = "0x600041E")]
		[Address(RVA = "0x1D4B78C", Offset = "0x1D4B78C", VA = "0x1D4B78C", Slot = "27")]
		public virtual CloudStorageUpdateResponse GetCloudStorageUpdateResponse()
		{
			return null;
		}

		[Token(Token = "0x600041F")]
		[Address(RVA = "0x1D4B794", Offset = "0x1D4B794", VA = "0x1D4B794", Slot = "28")]
		public virtual InstalledApplicationList GetInstalledApplicationList()
		{
			return null;
		}

		[Token(Token = "0x6000420")]
		[Address(RVA = "0x1D4B79C", Offset = "0x1D4B79C", VA = "0x1D4B79C", Slot = "29")]
		public virtual LaunchBlockFlowResult GetLaunchBlockFlowResult()
		{
			return null;
		}

		[Token(Token = "0x6000421")]
		[Address(RVA = "0x1D4B7A4", Offset = "0x1D4B7A4", VA = "0x1D4B7A4", Slot = "30")]
		public virtual LaunchFriendRequestFlowResult GetLaunchFriendRequestFlowResult()
		{
			return null;
		}

		[Token(Token = "0x6000422")]
		[Address(RVA = "0x1D4B7AC", Offset = "0x1D4B7AC", VA = "0x1D4B7AC", Slot = "31")]
		public virtual LaunchReportFlowResult GetLaunchReportFlowResult()
		{
			return null;
		}

		[Token(Token = "0x6000423")]
		[Address(RVA = "0x1D4B7B4", Offset = "0x1D4B7B4", VA = "0x1D4B7B4", Slot = "32")]
		public virtual LaunchUnblockFlowResult GetLaunchUnblockFlowResult()
		{
			return null;
		}

		[Token(Token = "0x6000424")]
		[Address(RVA = "0x1D4B7BC", Offset = "0x1D4B7BC", VA = "0x1D4B7BC", Slot = "33")]
		public virtual bool GetLeaderboardDidUpdate()
		{
			return default(bool);
		}

		[Token(Token = "0x6000425")]
		[Address(RVA = "0x1D4B7C4", Offset = "0x1D4B7C4", VA = "0x1D4B7C4", Slot = "34")]
		public virtual LeaderboardEntryList GetLeaderboardEntryList()
		{
			return null;
		}

		[Token(Token = "0x6000426")]
		[Address(RVA = "0x1D4B7CC", Offset = "0x1D4B7CC", VA = "0x1D4B7CC", Slot = "35")]
		public virtual LinkedAccountList GetLinkedAccountList()
		{
			return null;
		}

		[Token(Token = "0x6000427")]
		[Address(RVA = "0x1D4B7D4", Offset = "0x1D4B7D4", VA = "0x1D4B7D4", Slot = "36")]
		public virtual LivestreamingApplicationStatus GetLivestreamingApplicationStatus()
		{
			return null;
		}

		[Token(Token = "0x6000428")]
		[Address(RVA = "0x1D4B7DC", Offset = "0x1D4B7DC", VA = "0x1D4B7DC", Slot = "37")]
		public virtual LivestreamingStartResult GetLivestreamingStartResult()
		{
			return null;
		}

		[Token(Token = "0x6000429")]
		[Address(RVA = "0x1D4B7E4", Offset = "0x1D4B7E4", VA = "0x1D4B7E4", Slot = "38")]
		public virtual LivestreamingStatus GetLivestreamingStatus()
		{
			return null;
		}

		[Token(Token = "0x600042A")]
		[Address(RVA = "0x1D4B7EC", Offset = "0x1D4B7EC", VA = "0x1D4B7EC", Slot = "39")]
		public virtual LivestreamingVideoStats GetLivestreamingVideoStats()
		{
			return null;
		}

		[Token(Token = "0x600042B")]
		[Address(RVA = "0x1D4B7F4", Offset = "0x1D4B7F4", VA = "0x1D4B7F4", Slot = "40")]
		public virtual MatchmakingAdminSnapshot GetMatchmakingAdminSnapshot()
		{
			return null;
		}

		[Token(Token = "0x600042C")]
		[Address(RVA = "0x1D4B7FC", Offset = "0x1D4B7FC", VA = "0x1D4B7FC", Slot = "41")]
		public virtual MatchmakingBrowseResult GetMatchmakingBrowseResult()
		{
			return null;
		}

		[Token(Token = "0x600042D")]
		[Address(RVA = "0x1D4B804", Offset = "0x1D4B804", VA = "0x1D4B804", Slot = "42")]
		public virtual MatchmakingEnqueueResult GetMatchmakingEnqueueResult()
		{
			return null;
		}

		[Token(Token = "0x600042E")]
		[Address(RVA = "0x1D4B80C", Offset = "0x1D4B80C", VA = "0x1D4B80C", Slot = "43")]
		public virtual MatchmakingEnqueueResultAndRoom GetMatchmakingEnqueueResultAndRoom()
		{
			return null;
		}

		[Token(Token = "0x600042F")]
		[Address(RVA = "0x1D4B814", Offset = "0x1D4B814", VA = "0x1D4B814", Slot = "44")]
		public virtual MatchmakingStats GetMatchmakingStats()
		{
			return null;
		}

		[Token(Token = "0x6000430")]
		[Address(RVA = "0x1D4B81C", Offset = "0x1D4B81C", VA = "0x1D4B81C", Slot = "45")]
		public virtual OrgScopedID GetOrgScopedID()
		{
			return null;
		}

		[Token(Token = "0x6000431")]
		[Address(RVA = "0x1D4B824", Offset = "0x1D4B824", VA = "0x1D4B824", Slot = "46")]
		public virtual Party GetParty()
		{
			return null;
		}

		[Token(Token = "0x6000432")]
		[Address(RVA = "0x1D4B82C", Offset = "0x1D4B82C", VA = "0x1D4B82C", Slot = "47")]
		public virtual PartyID GetPartyID()
		{
			return null;
		}

		[Token(Token = "0x6000433")]
		[Address(RVA = "0x1D4B834", Offset = "0x1D4B834", VA = "0x1D4B834", Slot = "48")]
		public virtual PartyUpdateNotification GetPartyUpdateNotification()
		{
			return null;
		}

		[Token(Token = "0x6000434")]
		[Address(RVA = "0x1D4B83C", Offset = "0x1D4B83C", VA = "0x1D4B83C", Slot = "49")]
		public virtual PidList GetPidList()
		{
			return null;
		}

		[Token(Token = "0x6000435")]
		[Address(RVA = "0x1D4B844", Offset = "0x1D4B844", VA = "0x1D4B844", Slot = "50")]
		public virtual ProductList GetProductList()
		{
			return null;
		}

		[Token(Token = "0x6000436")]
		[Address(RVA = "0x1D4B84C", Offset = "0x1D4B84C", VA = "0x1D4B84C", Slot = "51")]
		public virtual Purchase GetPurchase()
		{
			return null;
		}

		[Token(Token = "0x6000437")]
		[Address(RVA = "0x1D4B854", Offset = "0x1D4B854", VA = "0x1D4B854", Slot = "52")]
		public virtual PurchaseList GetPurchaseList()
		{
			return null;
		}

		[Token(Token = "0x6000438")]
		[Address(RVA = "0x1D4B85C", Offset = "0x1D4B85C", VA = "0x1D4B85C", Slot = "53")]
		public virtual Room GetRoom()
		{
			return null;
		}

		[Token(Token = "0x6000439")]
		[Address(RVA = "0x1D4B864", Offset = "0x1D4B864", VA = "0x1D4B864", Slot = "54")]
		public virtual RoomInviteNotification GetRoomInviteNotification()
		{
			return null;
		}

		[Token(Token = "0x600043A")]
		[Address(RVA = "0x1D4B86C", Offset = "0x1D4B86C", VA = "0x1D4B86C", Slot = "55")]
		public virtual RoomInviteNotificationList GetRoomInviteNotificationList()
		{
			return null;
		}

		[Token(Token = "0x600043B")]
		[Address(RVA = "0x1D4B874", Offset = "0x1D4B874", VA = "0x1D4B874", Slot = "56")]
		public virtual RoomList GetRoomList()
		{
			return null;
		}

		[Token(Token = "0x600043C")]
		[Address(RVA = "0x1D4B87C", Offset = "0x1D4B87C", VA = "0x1D4B87C", Slot = "57")]
		public virtual SdkAccountList GetSdkAccountList()
		{
			return null;
		}

		[Token(Token = "0x600043D")]
		[Address(RVA = "0x1D4B884", Offset = "0x1D4B884", VA = "0x1D4B884", Slot = "58")]
		public virtual ShareMediaResult GetShareMediaResult()
		{
			return null;
		}

		[Token(Token = "0x600043E")]
		[Address(RVA = "0x1D4B88C", Offset = "0x1D4B88C", VA = "0x1D4B88C", Slot = "59")]
		public virtual string GetString()
		{
			return null;
		}

		[Token(Token = "0x600043F")]
		[Address(RVA = "0x1D4B894", Offset = "0x1D4B894", VA = "0x1D4B894", Slot = "60")]
		public virtual SystemPermission GetSystemPermission()
		{
			return null;
		}

		[Token(Token = "0x6000440")]
		[Address(RVA = "0x1D4B89C", Offset = "0x1D4B89C", VA = "0x1D4B89C", Slot = "61")]
		public virtual SystemVoipState GetSystemVoipState()
		{
			return null;
		}

		[Token(Token = "0x6000441")]
		[Address(RVA = "0x1D4B8A4", Offset = "0x1D4B8A4", VA = "0x1D4B8A4", Slot = "62")]
		public virtual User GetUser()
		{
			return null;
		}

		[Token(Token = "0x6000442")]
		[Address(RVA = "0x1D4B8AC", Offset = "0x1D4B8AC", VA = "0x1D4B8AC", Slot = "63")]
		public virtual UserAndRoomList GetUserAndRoomList()
		{
			return null;
		}

		[Token(Token = "0x6000443")]
		[Address(RVA = "0x1D4B8B4", Offset = "0x1D4B8B4", VA = "0x1D4B8B4", Slot = "64")]
		public virtual UserList GetUserList()
		{
			return null;
		}

		[Token(Token = "0x6000444")]
		[Address(RVA = "0x1D4B8BC", Offset = "0x1D4B8BC", VA = "0x1D4B8BC", Slot = "65")]
		public virtual UserProof GetUserProof()
		{
			return null;
		}

		[Token(Token = "0x6000445")]
		[Address(RVA = "0x1D4B8C4", Offset = "0x1D4B8C4", VA = "0x1D4B8C4", Slot = "66")]
		public virtual UserReportID GetUserReportID()
		{
			return null;
		}

		[Token(Token = "0x6000446")]
		[Address(RVA = "0x1D4B8CC", Offset = "0x1D4B8CC", VA = "0x1D4B8CC")]
		internal static Message ParseMessageHandle(IntPtr messageHandle)
		{
			return null;
		}

		[Token(Token = "0x6000447")]
		[Address(RVA = "0x1D45DC4", Offset = "0x1D45DC4", VA = "0x1D45DC4")]
		public static Message PopMessage()
		{
			return null;
		}
	}
	[Token(Token = "0x2000042")]
	public class MessageWithAbuseReportRecording : Message<AbuseReportRecording>
	{
		[Token(Token = "0x600044A")]
		[Address(RVA = "0x1D4EB88", Offset = "0x1D4EB88", VA = "0x1D4EB88")]
		public MessageWithAbuseReportRecording(IntPtr c_message)
		{
		}

		[Token(Token = "0x600044B")]
		[Address(RVA = "0x1D4EBE8", Offset = "0x1D4EBE8", VA = "0x1D4EBE8", Slot = "9")]
		public override AbuseReportRecording GetAbuseReportRecording()
		{
			return null;
		}

		[Token(Token = "0x600044C")]
		[Address(RVA = "0x1D4EC2C", Offset = "0x1D4EC2C", VA = "0x1D4EC2C", Slot = "67")]
		protected override AbuseReportRecording GetDataFromMessage(IntPtr c_message)
		{
			return null;
		}
	}
	[Token(Token = "0x2000043")]
	public class MessageWithAchievementDefinitions : Message<AchievementDefinitionList>
	{
		[Token(Token = "0x600044D")]
		[Address(RVA = "0x1D4CD28", Offset = "0x1D4CD28", VA = "0x1D4CD28")]
		public MessageWithAchievementDefinitions(IntPtr c_message)
		{
		}

		[Token(Token = "0x600044E")]
		[Address(RVA = "0x1D4ED50", Offset = "0x1D4ED50", VA = "0x1D4ED50", Slot = "10")]
		public override AchievementDefinitionList GetAchievementDefinitions()
		{
			return null;
		}

		[Token(Token = "0x600044F")]
		[Address(RVA = "0x1D4ED94", Offset = "0x1D4ED94", VA = "0x1D4ED94", Slot = "67")]
		protected override AchievementDefinitionList GetDataFromMessage(IntPtr c_message)
		{
			return null;
		}
	}
	[Token(Token = "0x2000044")]
	public class MessageWithAchievementProgressList : Message<AchievementProgressList>
	{
		[Token(Token = "0x6000450")]
		[Address(RVA = "0x1D4CD88", Offset = "0x1D4CD88", VA = "0x1D4CD88")]
		public MessageWithAchievementProgressList(IntPtr c_message)
		{
		}

		[Token(Token = "0x6000451")]
		[Address(RVA = "0x1D4F030", Offset = "0x1D4F030", VA = "0x1D4F030", Slot = "11")]
		public override AchievementProgressList GetAchievementProgressList()
		{
			return null;
		}

		[Token(Token = "0x6000452")]
		[Address(RVA = "0x1D4F074", Offset = "0x1D4F074", VA = "0x1D4F074", Slot = "67")]
		protected override AchievementProgressList GetDataFromMessage(IntPtr c_message)
		{
			return null;
		}
	}
	[Token(Token = "0x2000045")]
	public class MessageWithAchievementUpdate : Message<AchievementUpdate>
	{
		[Token(Token = "0x6000453")]
		[Address(RVA = "0x1D4CDE8", Offset = "0x1D4CDE8", VA = "0x1D4CDE8")]
		public MessageWithAchievementUpdate(IntPtr c_message)
		{
		}

		[Token(Token = "0x6000454")]
		[Address(RVA = "0x1D4F310", Offset = "0x1D4F310", VA = "0x1D4F310", Slot = "12")]
		public override AchievementUpdate GetAchievementUpdate()
		{
			return null;
		}

		[Token(Token = "0x6000455")]
		[Address(RVA = "0x1D4F354", Offset = "0x1D4F354", VA = "0x1D4F354", Slot = "67")]
		protected override AchievementUpdate GetDataFromMessage(IntPtr c_message)
		{
			return null;
		}
	}
	[Token(Token = "0x2000046")]
	public class MessageWithApplicationVersion : Message<ApplicationVersion>
	{
		[Token(Token = "0x6000456")]
		[Address(RVA = "0x1D4CE48", Offset = "0x1D4CE48", VA = "0x1D4CE48")]
		public MessageWithApplicationVersion(IntPtr c_message)
		{
		}

		[Token(Token = "0x6000457")]
		[Address(RVA = "0x1D4F48C", Offset = "0x1D4F48C", VA = "0x1D4F48C", Slot = "13")]
		public override ApplicationVersion GetApplicationVersion()
		{
			return null;
		}

		[Token(Token = "0x6000458")]
		[Address(RVA = "0x1D4F4D0", Offset = "0x1D4F4D0", VA = "0x1D4F4D0", Slot = "67")]
		protected override ApplicationVersion GetDataFromMessage(IntPtr c_message)
		{
			return null;
		}
	}
	[Token(Token = "0x2000047")]
	public class MessageWithAssetDetails : Message<AssetDetails>
	{
		[Token(Token = "0x6000459")]
		[Address(RVA = "0x1D4CEA8", Offset = "0x1D4CEA8", VA = "0x1D4CEA8")]
		public MessageWithAssetDetails(IntPtr c_message)
		{
		}

		[Token(Token = "0x600045A")]
		[Address(RVA = "0x1D4F624", Offset = "0x1D4F624", VA = "0x1D4F624", Slot = "14")]
		public override AssetDetails GetAssetDetails()
		{
			return null;
		}

		[Token(Token = "0x600045B")]
		[Address(RVA = "0x1D4F668", Offset = "0x1D4F668", VA = "0x1D4F668", Slot = "67")]
		protected override AssetDetails GetDataFromMessage(IntPtr c_message)
		{
			return null;
		}
	}
	[Token(Token = "0x2000048")]
	public class MessageWithAssetDetailsList : Message<AssetDetailsList>
	{
		[Token(Token = "0x600045C")]
		[Address(RVA = "0x1D4CF08", Offset = "0x1D4CF08", VA = "0x1D4CF08")]
		public MessageWithAssetDetailsList(IntPtr c_message)
		{
		}

		[Token(Token = "0x600045D")]
		[Address(RVA = "0x1D4F824", Offset = "0x1D4F824", VA = "0x1D4F824", Slot = "15")]
		public override AssetDetailsList GetAssetDetailsList()
		{
			return null;
		}

		[Token(Token = "0x600045E")]
		[Address(RVA = "0x1D4F868", Offset = "0x1D4F868", VA = "0x1D4F868", Slot = "67")]
		protected override AssetDetailsList GetDataFromMessage(IntPtr c_message)
		{
			return null;
		}
	}
	[Token(Token = "0x2000049")]
	public class MessageWithAssetFileDeleteResult : Message<AssetFileDeleteResult>
	{
		[Token(Token = "0x600045F")]
		[Address(RVA = "0x1D4CF68", Offset = "0x1D4CF68", VA = "0x1D4CF68")]
		public MessageWithAssetFileDeleteResult(IntPtr c_message)
		{
		}

		[Token(Token = "0x6000460")]
		[Address(RVA = "0x1D4FAD4", Offset = "0x1D4FAD4", VA = "0x1D4FAD4", Slot = "16")]
		public override AssetFileDeleteResult GetAssetFileDeleteResult()
		{
			return null;
		}

		[Token(Token = "0x6000461")]
		[Address(RVA = "0x1D4FB18", Offset = "0x1D4FB18", VA = "0x1D4FB18", Slot = "67")]
		protected override AssetFileDeleteResult GetDataFromMessage(IntPtr c_message)
		{
			return null;
		}
	}
	[Token(Token = "0x200004A")]
	public class MessageWithAssetFileDownloadCancelResult : Message<AssetFileDownloadCancelResult>
	{
		[Token(Token = "0x6000462")]
		[Address(RVA = "0x1D4CFC8", Offset = "0x1D4CFC8", VA = "0x1D4CFC8")]
		public MessageWithAssetFileDownloadCancelResult(IntPtr c_message)
		{
		}

		[Token(Token = "0x6000463")]
		[Address(RVA = "0x1D4FC70", Offset = "0x1D4FC70", VA = "0x1D4FC70", Slot = "17")]
		public override AssetFileDownloadCancelResult GetAssetFileDownloadCancelResult()
		{
			return null;
		}

		[Token(Token = "0x6000464")]
		[Address(RVA = "0x1D4FCB4", Offset = "0x1D4FCB4", VA = "0x1D4FCB4", Slot = "67")]
		protected override AssetFileDownloadCancelResult GetDataFromMessage(IntPtr c_message)
		{
			return null;
		}
	}
	[Token(Token = "0x200004B")]
	public class MessageWithAssetFileDownloadResult : Message<AssetFileDownloadResult>
	{
		[Token(Token = "0x6000465")]
		[Address(RVA = "0x1D4D028", Offset = "0x1D4D028", VA = "0x1D4D028")]
		public MessageWithAssetFileDownloadResult(IntPtr c_message)
		{
		}

		[Token(Token = "0x6000466")]
		[Address(RVA = "0x1D4FE0C", Offset = "0x1D4FE0C", VA = "0x1D4FE0C", Slot = "18")]
		public override AssetFileDownloadResult GetAssetFileDownloadResult()
		{
			return null;
		}

		[Token(Token = "0x6000467")]
		[Address(RVA = "0x1D4FE50", Offset = "0x1D4FE50", VA = "0x1D4FE50", Slot = "67")]
		protected override AssetFileDownloadResult GetDataFromMessage(IntPtr c_message)
		{
			return null;
		}
	}
	[Token(Token = "0x200004C")]
	public class MessageWithAssetFileDownloadUpdate : Message<AssetFileDownloadUpdate>
	{
		[Token(Token = "0x6000468")]
		[Address(RVA = "0x1D4D088", Offset = "0x1D4D088", VA = "0x1D4D088")]
		public MessageWithAssetFileDownloadUpdate(IntPtr c_message)
		{
		}

		[Token(Token = "0x6000469")]
		[Address(RVA = "0x1D4FF84", Offset = "0x1D4FF84", VA = "0x1D4FF84", Slot = "19")]
		public override AssetFileDownloadUpdate GetAssetFileDownloadUpdate()
		{
			return null;
		}

		[Token(Token = "0x600046A")]
		[Address(RVA = "0x1D4FFC8", Offset = "0x1D4FFC8", VA = "0x1D4FFC8", Slot = "67")]
		protected override AssetFileDownloadUpdate GetDataFromMessage(IntPtr c_message)
		{
			return null;
		}
	}
	[Token(Token = "0x200004D")]
	public class MessageWithCalApplicationFinalized : Message<CalApplicationFinalized>
	{
		[Token(Token = "0x600046B")]
		[Address(RVA = "0x1D4D0E8", Offset = "0x1D4D0E8", VA = "0x1D4D0E8")]
		public MessageWithCalApplicationFinalized(IntPtr c_message)
		{
		}

		[Token(Token = "0x600046C")]
		[Address(RVA = "0x1D50130", Offset = "0x1D50130", VA = "0x1D50130", Slot = "20")]
		public override CalApplicationFinalized GetCalApplicationFinalized()
		{
			return null;
		}

		[Token(Token = "0x600046D")]
		[Address(RVA = "0x1D50174", Offset = "0x1D50174", VA = "0x1D50174", Slot = "67")]
		protected override CalApplicationFinalized GetDataFromMessage(IntPtr c_message)
		{
			return null;
		}
	}
	[Token(Token = "0x200004E")]
	public class MessageWithCalApplicationProposed : Message<CalApplicationProposed>
	{
		[Token(Token = "0x600046E")]
		[Address(RVA = "0x1D4D148", Offset = "0x1D4D148", VA = "0x1D4D148")]
		public MessageWithCalApplicationProposed(IntPtr c_message)
		{
		}

		[Token(Token = "0x600046F")]
		[Address(RVA = "0x1D502B8", Offset = "0x1D502B8", VA = "0x1D502B8", Slot = "21")]
		public override CalApplicationProposed GetCalApplicationProposed()
		{
			return null;
		}

		[Token(Token = "0x6000470")]
		[Address(RVA = "0x1D502FC", Offset = "0x1D502FC", VA = "0x1D502FC", Slot = "67")]
		protected override CalApplicationProposed GetDataFromMessage(IntPtr c_message)
		{
			return null;
		}
	}
	[Token(Token = "0x200004F")]
	public class MessageWithCalApplicationSuggestionList : Message<CalApplicationSuggestionList>
	{
		[Token(Token = "0x6000471")]
		[Address(RVA = "0x1D50420", Offset = "0x1D50420", VA = "0x1D50420")]
		public MessageWithCalApplicationSuggestionList(IntPtr c_message)
		{
		}

		[Token(Token = "0x6000472")]
		[Address(RVA = "0x1D50480", Offset = "0x1D50480", VA = "0x1D50480", Slot = "22")]
		public override CalApplicationSuggestionList GetCalApplicationSuggestionList()
		{
			return null;
		}

		[Token(Token = "0x6000473")]
		[Address(RVA = "0x1D504C4", Offset = "0x1D504C4", VA = "0x1D504C4", Slot = "67")]
		protected override CalApplicationSuggestionList GetDataFromMessage(IntPtr c_message)
		{
			return null;
		}
	}
	[Token(Token = "0x2000050")]
	public class MessageWithCloudStorageConflictMetadata : Message<CloudStorageConflictMetadata>
	{
		[Token(Token = "0x6000474")]
		[Address(RVA = "0x1D4D1A8", Offset = "0x1D4D1A8", VA = "0x1D4D1A8")]
		public MessageWithCloudStorageConflictMetadata(IntPtr c_message)
		{
		}

		[Token(Token = "0x6000475")]
		[Address(RVA = "0x1D50730", Offset = "0x1D50730", VA = "0x1D50730", Slot = "23")]
		public override CloudStorageConflictMetadata GetCloudStorageConflictMetadata()
		{
			return null;
		}

		[Token(Token = "0x6000476")]
		[Address(RVA = "0x1D50774", Offset = "0x1D50774", VA = "0x1D50774", Slot = "67")]
		protected override CloudStorageConflictMetadata GetDataFromMessage(IntPtr c_message)
		{
			return null;
		}
	}
	[Token(Token = "0x2000051")]
	public class MessageWithCloudStorageData : Message<CloudStorageData>
	{
		[Token(Token = "0x6000477")]
		[Address(RVA = "0x1D4D208", Offset = "0x1D4D208", VA = "0x1D4D208")]
		public MessageWithCloudStorageData(IntPtr c_message)
		{
		}

		[Token(Token = "0x6000478")]
		[Address(RVA = "0x1D508F0", Offset = "0x1D508F0", VA = "0x1D508F0", Slot = "24")]
		public override CloudStorageData GetCloudStorageData()
		{
			return null;
		}

		[Token(Token = "0x6000479")]
		[Address(RVA = "0x1D50934", Offset = "0x1D50934", VA = "0x1D50934", Slot = "67")]
		protected override CloudStorageData GetDataFromMessage(IntPtr c_message)
		{
			return null;
		}
	}
	[Token(Token = "0x2000052")]
	public class MessageWithCloudStorageMetadataUnderLocal : Message<CloudStorageMetadata>
	{
		[Token(Token = "0x600047A")]
		[Address(RVA = "0x1D4D268", Offset = "0x1D4D268", VA = "0x1D4D268")]
		public MessageWithCloudStorageMetadataUnderLocal(IntPtr c_message)
		{
		}

		[Token(Token = "0x600047B")]
		[Address(RVA = "0x1D50D68", Offset = "0x1D50D68", VA = "0x1D50D68", Slot = "25")]
		public override CloudStorageMetadata GetCloudStorageMetadata()
		{
			return null;
		}

		[Token(Token = "0x600047C")]
		[Address(RVA = "0x1D50DAC", Offset = "0x1D50DAC", VA = "0x1D50DAC", Slot = "67")]
		protected override CloudStorageMetadata GetDataFromMessage(IntPtr c_message)
		{
			return null;
		}
	}
	[Token(Token = "0x2000053")]
	public class MessageWithCloudStorageMetadataList : Message<CloudStorageMetadataList>
	{
		[Token(Token = "0x600047D")]
		[Address(RVA = "0x1D4D2C8", Offset = "0x1D4D2C8", VA = "0x1D4D2C8")]
		public MessageWithCloudStorageMetadataList(IntPtr c_message)
		{
		}

		[Token(Token = "0x600047E")]
		[Address(RVA = "0x1D50A88", Offset = "0x1D50A88", VA = "0x1D50A88", Slot = "26")]
		public override CloudStorageMetadataList GetCloudStorageMetadataList()
		{
			return null;
		}

		[Token(Token = "0x600047F")]
		[Address(RVA = "0x1D50ACC", Offset = "0x1D50ACC", VA = "0x1D50ACC", Slot = "67")]
		protected override CloudStorageMetadataList GetDataFromMessage(IntPtr c_message)
		{
			return null;
		}
	}
	[Token(Token = "0x2000054")]
	public class MessageWithCloudStorageUpdateResponse : Message<CloudStorageUpdateResponse>
	{
		[Token(Token = "0x6000480")]
		[Address(RVA = "0x1D4D328", Offset = "0x1D4D328", VA = "0x1D4D328")]
		public MessageWithCloudStorageUpdateResponse(IntPtr c_message)
		{
		}

		[Token(Token = "0x6000481")]
		[Address(RVA = "0x1D50F40", Offset = "0x1D50F40", VA = "0x1D50F40", Slot = "27")]
		public override CloudStorageUpdateResponse GetCloudStorageUpdateResponse()
		{
			return null;
		}

		[Token(Token = "0x6000482")]
		[Address(RVA = "0x1D50F84", Offset = "0x1D50F84", VA = "0x1D50F84", Slot = "67")]
		protected override CloudStorageUpdateResponse GetDataFromMessage(IntPtr c_message)
		{
			return null;
		}
	}
	[Token(Token = "0x2000055")]
	public class MessageWithInstalledApplicationList : Message<InstalledApplicationList>
	{
		[Token(Token = "0x6000483")]
		[Address(RVA = "0x1D51300", Offset = "0x1D51300", VA = "0x1D51300")]
		public MessageWithInstalledApplicationList(IntPtr c_message)
		{
		}

		[Token(Token = "0x6000484")]
		[Address(RVA = "0x1D51360", Offset = "0x1D51360", VA = "0x1D51360", Slot = "28")]
		public override InstalledApplicationList GetInstalledApplicationList()
		{
			return null;
		}

		[Token(Token = "0x6000485")]
		[Address(RVA = "0x1D513A4", Offset = "0x1D513A4", VA = "0x1D513A4", Slot = "67")]
		protected override InstalledApplicationList GetDataFromMessage(IntPtr c_message)
		{
			return null;
		}
	}
	[Token(Token = "0x2000056")]
	public class MessageWithLaunchBlockFlowResult : Message<LaunchBlockFlowResult>
	{
		[Token(Token = "0x6000486")]
		[Address(RVA = "0x1D51610", Offset = "0x1D51610", VA = "0x1D51610")]
		public MessageWithLaunchBlockFlowResult(IntPtr c_message)
		{
		}

		[Token(Token = "0x6000487")]
		[Address(RVA = "0x1D51670", Offset = "0x1D51670", VA = "0x1D51670", Slot = "29")]
		public override LaunchBlockFlowResult GetLaunchBlockFlowResult()
		{
			return null;
		}

		[Token(Token = "0x6000488")]
		[Address(RVA = "0x1D516B4", Offset = "0x1D516B4", VA = "0x1D516B4", Slot = "67")]
		protected override LaunchBlockFlowResult GetDataFromMessage(IntPtr c_message)
		{
			return null;
		}
	}
	[Token(Token = "0x2000057")]
	public class MessageWithLaunchFriendRequestFlowResult : Message<LaunchFriendRequestFlowResult>
	{
		[Token(Token = "0x6000489")]
		[Address(RVA = "0x1D4D388", Offset = "0x1D4D388", VA = "0x1D4D388")]
		public MessageWithLaunchFriendRequestFlowResult(IntPtr c_message)
		{
		}

		[Token(Token = "0x600048A")]
		[Address(RVA = "0x1D517F0", Offset = "0x1D517F0", VA = "0x1D517F0", Slot = "30")]
		public override LaunchFriendRequestFlowResult GetLaunchFriendRequestFlowResult()
		{
			return null;
		}

		[Token(Token = "0x600048B")]
		[Address(RVA = "0x1D51834", Offset = "0x1D51834", VA = "0x1D51834", Slot = "67")]
		protected override LaunchFriendRequestFlowResult GetDataFromMessage(IntPtr c_message)
		{
			return null;
		}
	}
	[Token(Token = "0x2000058")]
	public class MessageWithLaunchReportFlowResult : Message<LaunchReportFlowResult>
	{
		[Token(Token = "0x600048C")]
		[Address(RVA = "0x1D51970", Offset = "0x1D51970", VA = "0x1D51970")]
		public MessageWithLaunchReportFlowResult(IntPtr c_message)
		{
		}

		[Token(Token = "0x600048D")]
		[Address(RVA = "0x1D519D0", Offset = "0x1D519D0", VA = "0x1D519D0", Slot = "31")]
		public override LaunchReportFlowResult GetLaunchReportFlowResult()
		{
			return null;
		}

		[Token(Token = "0x600048E")]
		[Address(RVA = "0x1D51A14", Offset = "0x1D51A14", VA = "0x1D51A14", Slot = "67")]
		protected override LaunchReportFlowResult GetDataFromMessage(IntPtr c_message)
		{
			return null;
		}
	}
	[Token(Token = "0x2000059")]
	public class MessageWithLaunchUnblockFlowResult : Message<LaunchUnblockFlowResult>
	{
		[Token(Token = "0x600048F")]
		[Address(RVA = "0x1D51B4C", Offset = "0x1D51B4C", VA = "0x1D51B4C")]
		public MessageWithLaunchUnblockFlowResult(IntPtr c_message)
		{
		}

		[Token(Token = "0x6000490")]
		[Address(RVA = "0x1D51BAC", Offset = "0x1D51BAC", VA = "0x1D51BAC", Slot = "32")]
		public override LaunchUnblockFlowResult GetLaunchUnblockFlowResult()
		{
			return null;
		}

		[Token(Token = "0x6000491")]
		[Address(RVA = "0x1D51BF0", Offset = "0x1D51BF0", VA = "0x1D51BF0", Slot = "67")]
		protected override LaunchUnblockFlowResult GetDataFromMessage(IntPtr c_message)
		{
			return null;
		}
	}
	[Token(Token = "0x200005A")]
	public class MessageWithLeaderboardEntryList : Message<LeaderboardEntryList>
	{
		[Token(Token = "0x6000492")]
		[Address(RVA = "0x1D4D3E8", Offset = "0x1D4D3E8", VA = "0x1D4D3E8")]
		public MessageWithLeaderboardEntryList(IntPtr c_message)
		{
		}

		[Token(Token = "0x6000493")]
		[Address(RVA = "0x1D51DE8", Offset = "0x1D51DE8", VA = "0x1D51DE8", Slot = "34")]
		public override LeaderboardEntryList GetLeaderboardEntryList()
		{
			return null;
		}

		[Token(Token = "0x6000494")]
		[Address(RVA = "0x1D51E2C", Offset = "0x1D51E2C", VA = "0x1D51E2C", Slot = "67")]
		protected override LeaderboardEntryList GetDataFromMessage(IntPtr c_message)
		{
			return null;
		}
	}
	[Token(Token = "0x200005B")]
	public class MessageWithLinkedAccountList : Message<LinkedAccountList>
	{
		[Token(Token = "0x6000495")]
		[Address(RVA = "0x1D520E8", Offset = "0x1D520E8", VA = "0x1D520E8")]
		public MessageWithLinkedAccountList(IntPtr c_message)
		{
		}

		[Token(Token = "0x6000496")]
		[Address(RVA = "0x1D52148", Offset = "0x1D52148", VA = "0x1D52148", Slot = "35")]
		public override LinkedAccountList GetLinkedAccountList()
		{
			return null;
		}

		[Token(Token = "0x6000497")]
		[Address(RVA = "0x1D5218C", Offset = "0x1D5218C", VA = "0x1D5218C", Slot = "67")]
		protected override LinkedAccountList GetDataFromMessage(IntPtr c_message)
		{
			return null;
		}
	}
	[Token(Token = "0x200005C")]
	public class MessageWithLivestreamingApplicationStatus : Message<LivestreamingApplicationStatus>
	{
		[Token(Token = "0x6000498")]
		[Address(RVA = "0x1D523F8", Offset = "0x1D523F8", VA = "0x1D523F8")]
		public MessageWithLivestreamingApplicationStatus(IntPtr c_message)
		{
		}

		[Token(Token = "0x6000499")]
		[Address(RVA = "0x1D52458", Offset = "0x1D52458", VA = "0x1D52458", Slot = "36")]
		public override LivestreamingApplicationStatus GetLivestreamingApplicationStatus()
		{
			return null;
		}

		[Token(Token = "0x600049A")]
		[Address(RVA = "0x1D5249C", Offset = "0x1D5249C", VA = "0x1D5249C", Slot = "67")]
		protected override LivestreamingApplicationStatus GetDataFromMessage(IntPtr c_message)
		{
			return null;
		}
	}
	[Token(Token = "0x200005D")]
	public class MessageWithLivestreamingStartResult : Message<LivestreamingStartResult>
	{
		[Token(Token = "0x600049B")]
		[Address(RVA = "0x1D525C4", Offset = "0x1D525C4", VA = "0x1D525C4")]
		public MessageWithLivestreamingStartResult(IntPtr c_message)
		{
		}

		[Token(Token = "0x600049C")]
		[Address(RVA = "0x1D52624", Offset = "0x1D52624", VA = "0x1D52624", Slot = "37")]
		public override LivestreamingStartResult GetLivestreamingStartResult()
		{
			return null;
		}

		[Token(Token = "0x600049D")]
		[Address(RVA = "0x1D52668", Offset = "0x1D52668", VA = "0x1D52668", Slot = "67")]
		protected override LivestreamingStartResult GetDataFromMessage(IntPtr c_message)
		{
			return null;
		}
	}
	[Token(Token = "0x200005E")]
	public class MessageWithLivestreamingStatus : Message<LivestreamingStatus>
	{
		[Token(Token = "0x600049E")]
		[Address(RVA = "0x1D4D4A8", Offset = "0x1D4D4A8", VA = "0x1D4D4A8")]
		public MessageWithLivestreamingStatus(IntPtr c_message)
		{
		}

		[Token(Token = "0x600049F")]
		[Address(RVA = "0x1D5278C", Offset = "0x1D5278C", VA = "0x1D5278C", Slot = "38")]
		public override LivestreamingStatus GetLivestreamingStatus()
		{
			return null;
		}

		[Token(Token = "0x60004A0")]
		[Address(RVA = "0x1D527D0", Offset = "0x1D527D0", VA = "0x1D527D0", Slot = "67")]
		protected override LivestreamingStatus GetDataFromMessage(IntPtr c_message)
		{
			return null;
		}
	}
	[Token(Token = "0x200005F")]
	public class MessageWithLivestreamingVideoStats : Message<LivestreamingVideoStats>
	{
		[Token(Token = "0x60004A1")]
		[Address(RVA = "0x1D52944", Offset = "0x1D52944", VA = "0x1D52944")]
		public MessageWithLivestreamingVideoStats(IntPtr c_message)
		{
		}

		[Token(Token = "0x60004A2")]
		[Address(RVA = "0x1D529A4", Offset = "0x1D529A4", VA = "0x1D529A4", Slot = "39")]
		public override LivestreamingVideoStats GetLivestreamingVideoStats()
		{
			return null;
		}

		[Token(Token = "0x60004A3")]
		[Address(RVA = "0x1D529E8", Offset = "0x1D529E8", VA = "0x1D529E8", Slot = "67")]
		protected override LivestreamingVideoStats GetDataFromMessage(IntPtr c_message)
		{
			return null;
		}
	}
	[Token(Token = "0x2000060")]
	public class MessageWithMatchmakingAdminSnapshot : Message<MatchmakingAdminSnapshot>
	{
		[Token(Token = "0x60004A4")]
		[Address(RVA = "0x1D4D508", Offset = "0x1D4D508", VA = "0x1D4D508")]
		public MessageWithMatchmakingAdminSnapshot(IntPtr c_message)
		{
		}

		[Token(Token = "0x60004A5")]
		[Address(RVA = "0x1D52B2C", Offset = "0x1D52B2C", VA = "0x1D52B2C", Slot = "40")]
		public override MatchmakingAdminSnapshot GetMatchmakingAdminSnapshot()
		{
			return null;
		}

		[Token(Token = "0x60004A6")]
		[Address(RVA = "0x1D52B70", Offset = "0x1D52B70", VA = "0x1D52B70", Slot = "67")]
		protected override MatchmakingAdminSnapshot GetDataFromMessage(IntPtr c_message)
		{
			return null;
		}
	}
	[Token(Token = "0x2000061")]
	public class MessageWithMatchmakingEnqueueResult : Message<MatchmakingEnqueueResult>
	{
		[Token(Token = "0x60004A7")]
		[Address(RVA = "0x1D4D5C8", Offset = "0x1D4D5C8", VA = "0x1D4D5C8")]
		public MessageWithMatchmakingEnqueueResult(IntPtr c_message)
		{
		}

		[Token(Token = "0x60004A8")]
		[Address(RVA = "0x1D52EE4", Offset = "0x1D52EE4", VA = "0x1D52EE4", Slot = "42")]
		public override MatchmakingEnqueueResult GetMatchmakingEnqueueResult()
		{
			return null;
		}

		[Token(Token = "0x60004A9")]
		[Address(RVA = "0x1D52F28", Offset = "0x1D52F28", VA = "0x1D52F28", Slot = "67")]
		protected override MatchmakingEnqueueResult GetDataFromMessage(IntPtr c_message)
		{
			return null;
		}
	}
	[Token(Token = "0x2000062")]
	public class MessageWithMatchmakingEnqueueResultAndRoom : Message<MatchmakingEnqueueResultAndRoom>
	{
		[Token(Token = "0x60004AA")]
		[Address(RVA = "0x1D4D628", Offset = "0x1D4D628", VA = "0x1D4D628")]
		public MessageWithMatchmakingEnqueueResultAndRoom(IntPtr c_message)
		{
		}

		[Token(Token = "0x60004AB")]
		[Address(RVA = "0x1D53114", Offset = "0x1D53114", VA = "0x1D53114", Slot = "43")]
		public override MatchmakingEnqueueResultAndRoom GetMatchmakingEnqueueResultAndRoom()
		{
			return null;
		}

		[Token(Token = "0x60004AC")]
		[Address(RVA = "0x1D53158", Offset = "0x1D53158", VA = "0x1D53158", Slot = "67")]
		protected override MatchmakingEnqueueResultAndRoom GetDataFromMessage(IntPtr c_message)
		{
			return null;
		}
	}
	[Token(Token = "0x2000063")]
	public class MessageWithMatchmakingStatsUnderMatchmakingStats : Message<MatchmakingStats>
	{
		[Token(Token = "0x60004AD")]
		[Address(RVA = "0x1D4D688", Offset = "0x1D4D688", VA = "0x1D4D688")]
		public MessageWithMatchmakingStatsUnderMatchmakingStats(IntPtr c_message)
		{
		}

		[Token(Token = "0x60004AE")]
		[Address(RVA = "0x1D536A8", Offset = "0x1D536A8", VA = "0x1D536A8", Slot = "44")]
		public override MatchmakingStats GetMatchmakingStats()
		{
			return null;
		}

		[Token(Token = "0x60004AF")]
		[Address(RVA = "0x1D536EC", Offset = "0x1D536EC", VA = "0x1D536EC", Slot = "67")]
		protected override MatchmakingStats GetDataFromMessage(IntPtr c_message)
		{
			return null;
		}
	}
	[Token(Token = "0x2000064")]
	public class MessageWithOrgScopedID : Message<OrgScopedID>
	{
		[Token(Token = "0x60004B0")]
		[Address(RVA = "0x1D4D6E8", Offset = "0x1D4D6E8", VA = "0x1D4D6E8")]
		public MessageWithOrgScopedID(IntPtr c_message)
		{
		}

		[Token(Token = "0x60004B1")]
		[Address(RVA = "0x1D53980", Offset = "0x1D53980", VA = "0x1D53980", Slot = "45")]
		public override OrgScopedID GetOrgScopedID()
		{
			return null;
		}

		[Token(Token = "0x60004B2")]
		[Address(RVA = "0x1D539C4", Offset = "0x1D539C4", VA = "0x1D539C4", Slot = "67")]
		protected override OrgScopedID GetDataFromMessage(IntPtr c_message)
		{
			return null;
		}
	}
	[Token(Token = "0x2000065")]
	public class MessageWithParty : Message<Party>
	{
		[Token(Token = "0x60004B3")]
		[Address(RVA = "0x1D53AE8", Offset = "0x1D53AE8", VA = "0x1D53AE8")]
		public MessageWithParty(IntPtr c_message)
		{
		}

		[Token(Token = "0x60004B4")]
		[Address(RVA = "0x1D53B48", Offset = "0x1D53B48", VA = "0x1D53B48", Slot = "46")]
		public override Party GetParty()
		{
			return null;
		}

		[Token(Token = "0x60004B5")]
		[Address(RVA = "0x1D53B8C", Offset = "0x1D53B8C", VA = "0x1D53B8C", Slot = "67")]
		protected override Party GetDataFromMessage(IntPtr c_message)
		{
			return null;
		}
	}
	[Token(Token = "0x2000066")]
	public class MessageWithPartyUnderCurrentParty : Message<Party>
	{
		[Token(Token = "0x60004B6")]
		[Address(RVA = "0x1D4D748", Offset = "0x1D4D748", VA = "0x1D4D748")]
		public MessageWithPartyUnderCurrentParty(IntPtr c_message)
		{
		}

		[Token(Token = "0x60004B7")]
		[Address(RVA = "0x1D54020", Offset = "0x1D54020", VA = "0x1D54020", Slot = "46")]
		public override Party GetParty()
		{
			return null;
		}

		[Token(Token = "0x60004B8")]
		[Address(RVA = "0x1D54064", Offset = "0x1D54064", VA = "0x1D54064", Slot = "67")]
		protected override Party GetDataFromMessage(IntPtr c_message)
		{
			return null;
		}
	}
	[Token(Token = "0x2000067")]
	public class MessageWithPartyID : Message<PartyID>
	{
		[Token(Token = "0x60004B9")]
		[Address(RVA = "0x1D53E58", Offset = "0x1D53E58", VA = "0x1D53E58")]
		public MessageWithPartyID(IntPtr c_message)
		{
		}

		[Token(Token = "0x60004BA")]
		[Address(RVA = "0x1D53EB8", Offset = "0x1D53EB8", VA = "0x1D53EB8", Slot = "47")]
		public override PartyID GetPartyID()
		{
			return null;
		}

		[Token(Token = "0x60004BB")]
		[Address(RVA = "0x1D53EFC", Offset = "0x1D53EFC", VA = "0x1D53EFC", Slot = "67")]
		protected override PartyID GetDataFromMessage(IntPtr c_message)
		{
			return null;
		}
	}
	[Token(Token = "0x2000068")]
	public class MessageWithPartyUpdateNotification : Message<PartyUpdateNotification>
	{
		[Token(Token = "0x60004BC")]
		[Address(RVA = "0x1D4D7A8", Offset = "0x1D4D7A8", VA = "0x1D4D7A8")]
		public MessageWithPartyUpdateNotification(IntPtr c_message)
		{
		}

		[Token(Token = "0x60004BD")]
		[Address(RVA = "0x1D54100", Offset = "0x1D54100", VA = "0x1D54100", Slot = "48")]
		public override PartyUpdateNotification GetPartyUpdateNotification()
		{
			return null;
		}

		[Token(Token = "0x60004BE")]
		[Address(RVA = "0x1D54144", Offset = "0x1D54144", VA = "0x1D54144", Slot = "67")]
		protected override PartyUpdateNotification GetDataFromMessage(IntPtr c_message)
		{
			return null;
		}
	}
	[Token(Token = "0x2000069")]
	public class MessageWithPidList : Message<PidList>
	{
		[Token(Token = "0x60004BF")]
		[Address(RVA = "0x1D4D808", Offset = "0x1D4D808", VA = "0x1D4D808")]
		public MessageWithPidList(IntPtr c_message)
		{
		}

		[Token(Token = "0x60004C0")]
		[Address(RVA = "0x1D542C8", Offset = "0x1D542C8", VA = "0x1D542C8", Slot = "49")]
		public override PidList GetPidList()
		{
			return null;
		}

		[Token(Token = "0x60004C1")]
		[Address(RVA = "0x1D5430C", Offset = "0x1D5430C", VA = "0x1D5430C", Slot = "67")]
		protected override PidList GetDataFromMessage(IntPtr c_message)
		{
			return null;
		}
	}
	[Token(Token = "0x200006A")]
	public class MessageWithProductList : Message<ProductList>
	{
		[Token(Token = "0x60004C2")]
		[Address(RVA = "0x1D4D868", Offset = "0x1D4D868", VA = "0x1D4D868")]
		public MessageWithProductList(IntPtr c_message)
		{
		}

		[Token(Token = "0x60004C3")]
		[Address(RVA = "0x1D54880", Offset = "0x1D54880", VA = "0x1D54880", Slot = "50")]
		public override ProductList GetProductList()
		{
			return null;
		}

		[Token(Token = "0x60004C4")]
		[Address(RVA = "0x1D548C4", Offset = "0x1D548C4", VA = "0x1D548C4", Slot = "67")]
		protected override ProductList GetDataFromMessage(IntPtr c_message)
		{
			return null;
		}
	}
	[Token(Token = "0x200006B")]
	public class MessageWithPurchase : Message<Purchase>
	{
		[Token(Token = "0x60004C5")]
		[Address(RVA = "0x1D4D8C8", Offset = "0x1D4D8C8", VA = "0x1D4D8C8")]
		public MessageWithPurchase(IntPtr c_message)
		{
		}

		[Token(Token = "0x60004C6")]
		[Address(RVA = "0x1D54B60", Offset = "0x1D54B60", VA = "0x1D54B60", Slot = "51")]
		public override Purchase GetPurchase()
		{
			return null;
		}

		[Token(Token = "0x60004C7")]
		[Address(RVA = "0x1D54BA4", Offset = "0x1D54BA4", VA = "0x1D54BA4", Slot = "67")]
		protected override Purchase GetDataFromMessage(IntPtr c_message)
		{
			return null;
		}
	}
	[Token(Token = "0x200006C")]
	public class MessageWithPurchaseList : Message<PurchaseList>
	{
		[Token(Token = "0x60004C8")]
		[Address(RVA = "0x1D4D928", Offset = "0x1D4D928", VA = "0x1D4D928")]
		public MessageWithPurchaseList(IntPtr c_message)
		{
		}

		[Token(Token = "0x60004C9")]
		[Address(RVA = "0x1D54CF8", Offset = "0x1D54CF8", VA = "0x1D54CF8", Slot = "52")]
		public override PurchaseList GetPurchaseList()
		{
			return null;
		}

		[Token(Token = "0x60004CA")]
		[Address(RVA = "0x1D54D3C", Offset = "0x1D54D3C", VA = "0x1D54D3C", Slot = "67")]
		protected override PurchaseList GetDataFromMessage(IntPtr c_message)
		{
			return null;
		}
	}
	[Token(Token = "0x200006D")]
	public class MessageWithRoom : Message<Room>
	{
		[Token(Token = "0x60004CB")]
		[Address(RVA = "0x1D4D988", Offset = "0x1D4D988", VA = "0x1D4D988")]
		public MessageWithRoom(IntPtr c_message)
		{
		}

		[Token(Token = "0x60004CC")]
		[Address(RVA = "0x1D54FD8", Offset = "0x1D54FD8", VA = "0x1D54FD8", Slot = "53")]
		public override Room GetRoom()
		{
			return null;
		}

		[Token(Token = "0x60004CD")]
		[Address(RVA = "0x1D5501C", Offset = "0x1D5501C", VA = "0x1D5501C", Slot = "67")]
		protected override Room GetDataFromMessage(IntPtr c_message)
		{
			return null;
		}
	}
	[Token(Token = "0x200006E")]
	public class MessageWithRoomUnderCurrentRoom : Message<Room>
	{
		[Token(Token = "0x60004CE")]
		[Address(RVA = "0x1D4D9E8", Offset = "0x1D4D9E8", VA = "0x1D4D9E8")]
		public MessageWithRoomUnderCurrentRoom(IntPtr c_message)
		{
		}

		[Token(Token = "0x60004CF")]
		[Address(RVA = "0x1D55810", Offset = "0x1D55810", VA = "0x1D55810", Slot = "53")]
		public override Room GetRoom()
		{
			return null;
		}

		[Token(Token = "0x60004D0")]
		[Address(RVA = "0x1D55854", Offset = "0x1D55854", VA = "0x1D55854", Slot = "67")]
		protected override Room GetDataFromMessage(IntPtr c_message)
		{
			return null;
		}
	}
	[Token(Token = "0x200006F")]
	public class MessageWithRoomUnderViewerRoom : Message<Room>
	{
		[Token(Token = "0x60004D1")]
		[Address(RVA = "0x1D4DA48", Offset = "0x1D4DA48", VA = "0x1D4DA48")]
		public MessageWithRoomUnderViewerRoom(IntPtr c_message)
		{
		}

		[Token(Token = "0x60004D2")]
		[Address(RVA = "0x1D558F0", Offset = "0x1D558F0", VA = "0x1D558F0", Slot = "53")]
		public override Room GetRoom()
		{
			return null;
		}

		[Token(Token = "0x60004D3")]
		[Address(RVA = "0x1D55934", Offset = "0x1D55934", VA = "0x1D55934", Slot = "67")]
		protected override Room GetDataFromMessage(IntPtr c_message)
		{
			return null;
		}
	}
	[Token(Token = "0x2000070")]
	public class MessageWithRoomList : Message<RoomList>
	{
		[Token(Token = "0x60004D4")]
		[Address(RVA = "0x1D4DAA8", Offset = "0x1D4DAA8", VA = "0x1D4DAA8")]
		public MessageWithRoomList(IntPtr c_message)
		{
		}

		[Token(Token = "0x60004D5")]
		[Address(RVA = "0x1D55530", Offset = "0x1D55530", VA = "0x1D55530", Slot = "56")]
		public override RoomList GetRoomList()
		{
			return null;
		}

		[Token(Token = "0x60004D6")]
		[Address(RVA = "0x1D55574", Offset = "0x1D55574", VA = "0x1D55574", Slot = "67")]
		protected override RoomList GetDataFromMessage(IntPtr c_message)
		{
			return null;
		}
	}
	[Token(Token = "0x2000071")]
	public class MessageWithRoomInviteNotification : Message<RoomInviteNotification>
	{
		[Token(Token = "0x60004D7")]
		[Address(RVA = "0x1D4DB08", Offset = "0x1D4DB08", VA = "0x1D4DB08")]
		public MessageWithRoomInviteNotification(IntPtr c_message)
		{
		}

		[Token(Token = "0x60004D8")]
		[Address(RVA = "0x1D550B8", Offset = "0x1D550B8", VA = "0x1D550B8", Slot = "54")]
		public override RoomInviteNotification GetRoomInviteNotification()
		{
			return null;
		}

		[Token(Token = "0x60004D9")]
		[Address(RVA = "0x1D550FC", Offset = "0x1D550FC", VA = "0x1D550FC", Slot = "67")]
		protected override RoomInviteNotification GetDataFromMessage(IntPtr c_message)
		{
			return null;
		}
	}
	[Token(Token = "0x2000072")]
	public class MessageWithRoomInviteNotificationList : Message<RoomInviteNotificationList>
	{
		[Token(Token = "0x60004DA")]
		[Address(RVA = "0x1D4DB68", Offset = "0x1D4DB68", VA = "0x1D4DB68")]
		public MessageWithRoomInviteNotificationList(IntPtr c_message)
		{
		}

		[Token(Token = "0x60004DB")]
		[Address(RVA = "0x1D55250", Offset = "0x1D55250", VA = "0x1D55250", Slot = "55")]
		public override RoomInviteNotificationList GetRoomInviteNotificationList()
		{
			return null;
		}

		[Token(Token = "0x60004DC")]
		[Address(RVA = "0x1D55294", Offset = "0x1D55294", VA = "0x1D55294", Slot = "67")]
		protected override RoomInviteNotificationList GetDataFromMessage(IntPtr c_message)
		{
			return null;
		}
	}
	[Token(Token = "0x2000073")]
	public class MessageWithSdkAccountList : Message<SdkAccountList>
	{
		[Token(Token = "0x60004DD")]
		[Address(RVA = "0x1D4DBC8", Offset = "0x1D4DBC8", VA = "0x1D4DBC8")]
		public MessageWithSdkAccountList(IntPtr c_message)
		{
		}

		[Token(Token = "0x60004DE")]
		[Address(RVA = "0x1D559D0", Offset = "0x1D559D0", VA = "0x1D559D0", Slot = "57")]
		public override SdkAccountList GetSdkAccountList()
		{
			return null;
		}

		[Token(Token = "0x60004DF")]
		[Address(RVA = "0x1D55A14", Offset = "0x1D55A14", VA = "0x1D55A14", Slot = "67")]
		protected override SdkAccountList GetDataFromMessage(IntPtr c_message)
		{
			return null;
		}
	}
	[Token(Token = "0x2000074")]
	public class MessageWithShareMediaResult : Message<ShareMediaResult>
	{
		[Token(Token = "0x60004E0")]
		[Address(RVA = "0x1D4DC28", Offset = "0x1D4DC28", VA = "0x1D4DC28")]
		public MessageWithShareMediaResult(IntPtr c_message)
		{
		}

		[Token(Token = "0x60004E1")]
		[Address(RVA = "0x1D55C80", Offset = "0x1D55C80", VA = "0x1D55C80", Slot = "58")]
		public override ShareMediaResult GetShareMediaResult()
		{
			return null;
		}

		[Token(Token = "0x60004E2")]
		[Address(RVA = "0x1D55CC4", Offset = "0x1D55CC4", VA = "0x1D55CC4", Slot = "67")]
		protected override ShareMediaResult GetDataFromMessage(IntPtr c_message)
		{
			return null;
		}
	}
	[Token(Token = "0x2000075")]
	public class MessageWithString : Message<string>
	{
		[Token(Token = "0x60004E3")]
		[Address(RVA = "0x1D4DC88", Offset = "0x1D4DC88", VA = "0x1D4DC88")]
		public MessageWithString(IntPtr c_message)
		{
		}

		[Token(Token = "0x60004E4")]
		[Address(RVA = "0x1D55DE8", Offset = "0x1D55DE8", VA = "0x1D55DE8", Slot = "59")]
		public override string GetString()
		{
			return null;
		}

		[Token(Token = "0x60004E5")]
		[Address(RVA = "0x1D55E2C", Offset = "0x1D55E2C", VA = "0x1D55E2C", Slot = "67")]
		protected override string GetDataFromMessage(IntPtr c_message)
		{
			return null;
		}
	}
	[Token(Token = "0x2000076")]
	public class MessageWithSystemPermission : Message<SystemPermission>
	{
		[Token(Token = "0x60004E6")]
		[Address(RVA = "0x1D55E94", Offset = "0x1D55E94", VA = "0x1D55E94")]
		public MessageWithSystemPermission(IntPtr c_message)
		{
		}

		[Token(Token = "0x60004E7")]
		[Address(RVA = "0x1D55EF4", Offset = "0x1D55EF4", VA = "0x1D55EF4", Slot = "60")]
		public override SystemPermission GetSystemPermission()
		{
			return null;
		}

		[Token(Token = "0x60004E8")]
		[Address(RVA = "0x1D55F38", Offset = "0x1D55F38", VA = "0x1D55F38", Slot = "67")]
		protected override SystemPermission GetDataFromMessage(IntPtr c_message)
		{
			return null;
		}
	}
	[Token(Token = "0x2000077")]
	public class MessageWithSystemVoipState : Message<SystemVoipState>
	{
		[Token(Token = "0x60004E9")]
		[Address(RVA = "0x1D4DCE8", Offset = "0x1D4DCE8", VA = "0x1D4DCE8")]
		public MessageWithSystemVoipState(IntPtr c_message)
		{
		}

		[Token(Token = "0x60004EA")]
		[Address(RVA = "0x1D56070", Offset = "0x1D56070", VA = "0x1D56070", Slot = "61")]
		public override SystemVoipState GetSystemVoipState()
		{
			return null;
		}

		[Token(Token = "0x60004EB")]
		[Address(RVA = "0x1D560B4", Offset = "0x1D560B4", VA = "0x1D560B4", Slot = "67")]
		protected override SystemVoipState GetDataFromMessage(IntPtr c_message)
		{
			return null;
		}
	}
	[Token(Token = "0x2000078")]
	public class MessageWithUser : Message<User>
	{
		[Token(Token = "0x60004EC")]
		[Address(RVA = "0x1D4DD48", Offset = "0x1D4DD48", VA = "0x1D4DD48")]
		public MessageWithUser(IntPtr c_message)
		{
		}

		[Token(Token = "0x60004ED")]
		[Address(RVA = "0x1D561E8", Offset = "0x1D561E8", VA = "0x1D561E8", Slot = "62")]
		public override User GetUser()
		{
			return null;
		}

		[Token(Token = "0x60004EE")]
		[Address(RVA = "0x1D5622C", Offset = "0x1D5622C", VA = "0x1D5622C", Slot = "67")]
		protected override User GetDataFromMessage(IntPtr c_message)
		{
			return null;
		}
	}
	[Token(Token = "0x2000079")]
	public class MessageWithUserAndRoomList : Message<UserAndRoomList>
	{
		[Token(Token = "0x60004EF")]
		[Address(RVA = "0x1D4DDA8", Offset = "0x1D4DDA8", VA = "0x1D4DDA8")]
		public MessageWithUserAndRoomList(IntPtr c_message)
		{
		}

		[Token(Token = "0x60004F0")]
		[Address(RVA = "0x1D563B0", Offset = "0x1D563B0", VA = "0x1D563B0", Slot = "63")]
		public override UserAndRoomList GetUserAndRoomList()
		{
			return null;
		}

		[Token(Token = "0x60004F1")]
		[Address(RVA = "0x1D563F4", Offset = "0x1D563F4", VA = "0x1D563F4", Slot = "67")]
		protected override UserAndRoomList GetDataFromMessage(IntPtr c_message)
		{
			return null;
		}
	}
	[Token(Token = "0x200007A")]
	public class MessageWithUserList : Message<UserList>
	{
		[Token(Token = "0x60004F2")]
		[Address(RVA = "0x1D4DE08", Offset = "0x1D4DE08", VA = "0x1D4DE08")]
		public MessageWithUserList(IntPtr c_message)
		{
		}

		[Token(Token = "0x60004F3")]
		[Address(RVA = "0x1D56690", Offset = "0x1D56690", VA = "0x1D56690", Slot = "64")]
		public override UserList GetUserList()
		{
			return null;
		}

		[Token(Token = "0x60004F4")]
		[Address(RVA = "0x1D566D4", Offset = "0x1D566D4", VA = "0x1D566D4", Slot = "67")]
		protected override UserList GetDataFromMessage(IntPtr c_message)
		{
			return null;
		}
	}
	[Token(Token = "0x200007B")]
	public class MessageWithUserProof : Message<UserProof>
	{
		[Token(Token = "0x60004F5")]
		[Address(RVA = "0x1D4DE68", Offset = "0x1D4DE68", VA = "0x1D4DE68")]
		public MessageWithUserProof(IntPtr c_message)
		{
		}

		[Token(Token = "0x60004F6")]
		[Address(RVA = "0x1D56970", Offset = "0x1D56970", VA = "0x1D56970", Slot = "65")]
		public override UserProof GetUserProof()
		{
			return null;
		}

		[Token(Token = "0x60004F7")]
		[Address(RVA = "0x1D569B4", Offset = "0x1D569B4", VA = "0x1D569B4", Slot = "67")]
		protected override UserProof GetDataFromMessage(IntPtr c_message)
		{
			return null;
		}
	}
	[Token(Token = "0x200007C")]
	public class MessageWithUserReportID : Message<UserReportID>
	{
		[Token(Token = "0x60004F8")]
		[Address(RVA = "0x1D56AD8", Offset = "0x1D56AD8", VA = "0x1D56AD8")]
		public MessageWithUserReportID(IntPtr c_message)
		{
		}

		[Token(Token = "0x60004F9")]
		[Address(RVA = "0x1D56B38", Offset = "0x1D56B38", VA = "0x1D56B38", Slot = "66")]
		public override UserReportID GetUserReportID()
		{
			return null;
		}

		[Token(Token = "0x60004FA")]
		[Address(RVA = "0x1D56B7C", Offset = "0x1D56B7C", VA = "0x1D56B7C", Slot = "67")]
		protected override UserReportID GetDataFromMessage(IntPtr c_message)
		{
			return null;
		}
	}
	[Token(Token = "0x200007D")]
	public class MessageWithNetworkingPeer : Message<NetworkingPeer>
	{
		[Token(Token = "0x60004FB")]
		[Address(RVA = "0x1D4DEC8", Offset = "0x1D4DEC8", VA = "0x1D4DEC8")]
		public MessageWithNetworkingPeer(IntPtr c_message)
		{
		}

		[Token(Token = "0x60004FC")]
		[Address(RVA = "0x1D53840", Offset = "0x1D53840", VA = "0x1D53840", Slot = "6")]
		public override NetworkingPeer GetNetworkingPeer()
		{
			return null;
		}

		[Token(Token = "0x60004FD")]
		[Address(RVA = "0x1D53884", Offset = "0x1D53884", VA = "0x1D53884", Slot = "67")]
		protected override NetworkingPeer GetDataFromMessage(IntPtr c_message)
		{
			return null;
		}
	}
	[Token(Token = "0x200007E")]
	public class MessageWithPingResult : Message<PingResult>
	{
		[Token(Token = "0x60004FE")]
		[Address(RVA = "0x1D4DF28", Offset = "0x1D4DF28", VA = "0x1D4DF28")]
		public MessageWithPingResult(IntPtr c_message)
		{
		}

		[Token(Token = "0x60004FF")]
		[Address(RVA = "0x1D54578", Offset = "0x1D54578", VA = "0x1D54578", Slot = "5")]
		public override PingResult GetPingResult()
		{
			return null;
		}

		[Token(Token = "0x6000500")]
		[Address(RVA = "0x1D545BC", Offset = "0x1D545BC", VA = "0x1D545BC", Slot = "67")]
		protected override PingResult GetDataFromMessage(IntPtr c_message)
		{
			return null;
		}
	}
	[Token(Token = "0x200007F")]
	public class MessageWithLeaderboardDidUpdate : Message<bool>
	{
		[Token(Token = "0x6000501")]
		[Address(RVA = "0x1D4D448", Offset = "0x1D4D448", VA = "0x1D4D448")]
		public MessageWithLeaderboardDidUpdate(IntPtr c_message)
		{
		}

		[Token(Token = "0x6000502")]
		[Address(RVA = "0x1D51D2C", Offset = "0x1D51D2C", VA = "0x1D51D2C", Slot = "33")]
		public override bool GetLeaderboardDidUpdate()
		{
			return default(bool);
		}

		[Token(Token = "0x6000503")]
		[Address(RVA = "0x1D51D70", Offset = "0x1D51D70", VA = "0x1D51D70", Slot = "67")]
		protected override bool GetDataFromMessage(IntPtr c_message)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x2000080")]
	public class MessageWithMatchmakingNotification : Message<Room>
	{
		[Token(Token = "0x6000504")]
		[Address(RVA = "0x1D4DF88", Offset = "0x1D4DF88", VA = "0x1D4DF88")]
		public MessageWithMatchmakingNotification(IntPtr c_message)
		{
		}

		[Token(Token = "0x6000505")]
		[Address(RVA = "0x1D532D4", Offset = "0x1D532D4", VA = "0x1D532D4", Slot = "53")]
		public override Room GetRoom()
		{
			return null;
		}

		[Token(Token = "0x6000506")]
		[Address(RVA = "0x1D53318", Offset = "0x1D53318", VA = "0x1D53318", Slot = "67")]
		protected override Room GetDataFromMessage(IntPtr c_message)
		{
			return null;
		}
	}
	[Token(Token = "0x2000081")]
	public class MessageWithMatchmakingBrowseResult : Message<MatchmakingBrowseResult>
	{
		[Token(Token = "0x6000507")]
		[Address(RVA = "0x1D4D568", Offset = "0x1D4D568", VA = "0x1D4D568")]
		public MessageWithMatchmakingBrowseResult(IntPtr c_message)
		{
		}

		[Token(Token = "0x6000508")]
		[Address(RVA = "0x1D52CC8", Offset = "0x1D52CC8", VA = "0x1D52CC8", Slot = "42")]
		public override MatchmakingEnqueueResult GetMatchmakingEnqueueResult()
		{
			return null;
		}

		[Token(Token = "0x6000509")]
		[Address(RVA = "0x1D52D18", Offset = "0x1D52D18", VA = "0x1D52D18", Slot = "56")]
		public override RoomList GetRoomList()
		{
			return null;
		}

		[Token(Token = "0x600050A")]
		[Address(RVA = "0x1D52D68", Offset = "0x1D52D68", VA = "0x1D52D68", Slot = "67")]
		protected override MatchmakingBrowseResult GetDataFromMessage(IntPtr c_message)
		{
			return null;
		}
	}
	[Token(Token = "0x2000082")]
	public class MessageWithHttpTransferUpdate : Message<HttpTransferUpdate>
	{
		[Token(Token = "0x600050B")]
		[Address(RVA = "0x1D4DFE8", Offset = "0x1D4DFE8", VA = "0x1D4DFE8")]
		public MessageWithHttpTransferUpdate(IntPtr c_message)
		{
		}

		[Token(Token = "0x600050C")]
		[Address(RVA = "0x1D510D8", Offset = "0x1D510D8", VA = "0x1D510D8", Slot = "7")]
		public override HttpTransferUpdate GetHttpTransferUpdate()
		{
			return null;
		}

		[Token(Token = "0x600050D")]
		[Address(RVA = "0x1D5111C", Offset = "0x1D5111C", VA = "0x1D5111C", Slot = "67")]
		protected override HttpTransferUpdate GetDataFromMessage(IntPtr c_message)
		{
			return null;
		}
	}
	[Token(Token = "0x2000083")]
	public class MessageWithPlatformInitialize : Message<PlatformInitialize>
	{
		[Token(Token = "0x600050E")]
		[Address(RVA = "0x1D4E048", Offset = "0x1D4E048", VA = "0x1D4E048")]
		public MessageWithPlatformInitialize(IntPtr c_message)
		{
		}

		[Token(Token = "0x600050F")]
		[Address(RVA = "0x1D54718", Offset = "0x1D54718", VA = "0x1D54718", Slot = "8")]
		public override PlatformInitialize GetPlatformInitialize()
		{
			return null;
		}

		[Token(Token = "0x6000510")]
		[Address(RVA = "0x1D5475C", Offset = "0x1D5475C", VA = "0x1D5475C", Slot = "67")]
		protected override PlatformInitialize GetDataFromMessage(IntPtr c_message)
		{
			return null;
		}
	}
	[Token(Token = "0x2000084")]
	public sealed class Packet : IDisposable
	{
		[Token(Token = "0x40000FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly ulong size;

		[Token(Token = "0x40000FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private readonly IntPtr packetHandle;

		[Token(Token = "0x1700000E")]
		public ulong SenderID
		{
			[Token(Token = "0x6000513")]
			[Address(RVA = "0x1D58D48", Offset = "0x1D58D48", VA = "0x1D58D48")]
			get
			{
				return default(ulong);
			}
		}

		[Token(Token = "0x1700000F")]
		public ulong Size
		{
			[Token(Token = "0x6000514")]
			[Address(RVA = "0x1D58DB4", Offset = "0x1D58DB4", VA = "0x1D58DB4")]
			get
			{
				return default(ulong);
			}
		}

		[Token(Token = "0x17000010")]
		public SendPolicy Policy
		{
			[Token(Token = "0x6000515")]
			[Address(RVA = "0x1D58DBC", Offset = "0x1D58DBC", VA = "0x1D58DBC")]
			get
			{
				return default(SendPolicy);
			}
		}

		[Token(Token = "0x6000511")]
		[Address(RVA = "0x1D57D28", Offset = "0x1D57D28", VA = "0x1D57D28")]
		public Packet(IntPtr packetHandle)
		{
		}

		[Token(Token = "0x6000512")]
		[Address(RVA = "0x1D58BF4", Offset = "0x1D58BF4", VA = "0x1D58BF4")]
		public ulong ReadBytes(byte[] destination)
		{
			return default(ulong);
		}

		[Token(Token = "0x6000516")]
		[Address(RVA = "0x1D58E28", Offset = "0x1D58E28", VA = "0x1D58E28", Slot = "1")]
		~Packet()
		{
		}

		[Token(Token = "0x6000517")]
		[Address(RVA = "0x1D58E90", Offset = "0x1D58E90", VA = "0x1D58E90", Slot = "4")]
		public void Dispose()
		{
		}
	}
	[Token(Token = "0x2000085")]
	public enum PartyUpdateAction
	{
		[Token(Token = "0x4000101")]
		[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x1184648", Offset = "0x1184648")]
		Unknown,
		[Token(Token = "0x4000102")]
		[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x1184680", Offset = "0x1184680")]
		Join,
		[Token(Token = "0x4000103")]
		[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x11846B8", Offset = "0x11846B8")]
		Leave,
		[Token(Token = "0x4000104")]
		[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x11846F0", Offset = "0x11846F0")]
		Invite,
		[Token(Token = "0x4000105")]
		[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x1184728", Offset = "0x1184728")]
		Uninvite
	}
	[Token(Token = "0x2000086")]
	public enum PeerConnectionState
	{
		[Token(Token = "0x4000107")]
		[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x1184760", Offset = "0x1184760")]
		Unknown,
		[Token(Token = "0x4000108")]
		[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x1184798", Offset = "0x1184798")]
		Connected,
		[Token(Token = "0x4000109")]
		[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x11847D0", Offset = "0x11847D0")]
		Timeout,
		[Token(Token = "0x400010A")]
		[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x1184808", Offset = "0x1184808")]
		Closed
	}
	[Token(Token = "0x2000087")]
	public enum PermissionGrantStatus
	{
		[Token(Token = "0x400010C")]
		[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x1184840", Offset = "0x1184840")]
		Unknown,
		[Token(Token = "0x400010D")]
		[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x1184878", Offset = "0x1184878")]
		Granted,
		[Token(Token = "0x400010E")]
		[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x11848B0", Offset = "0x11848B0")]
		Denied,
		[Token(Token = "0x400010F")]
		[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x11848E8", Offset = "0x11848E8")]
		Blocked
	}
	[Token(Token = "0x2000088")]
	public enum PermissionType
	{
		[Token(Token = "0x4000111")]
		[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x1184920", Offset = "0x1184920")]
		Unknown,
		[Token(Token = "0x4000112")]
		[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x1184958", Offset = "0x1184958")]
		Microphone,
		[Token(Token = "0x4000113")]
		[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x1184990", Offset = "0x1184990")]
		WriteExternalStorage
	}
	[Token(Token = "0x2000089")]
	public sealed class Core
	{
		[Token(Token = "0x4000114")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static bool IsPlatformInitialized;

		[Token(Token = "0x4000115")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1")]
		public static bool LogMessages;

		[Token(Token = "0x6000518")]
		[Address(RVA = "0x1D47500", Offset = "0x1D47500", VA = "0x1D47500")]
		public static bool IsInitialized()
		{
			return default(bool);
		}

		[Token(Token = "0x6000519")]
		[Address(RVA = "0x1D47568", Offset = "0x1D47568", VA = "0x1D47568")]
		internal static void ForceInitialized()
		{
		}

		[Token(Token = "0x600051A")]
		[Address(RVA = "0x1D475D4", Offset = "0x1D475D4", VA = "0x1D475D4")]
		private static string getAppID([Optional] string appId)
		{
			return null;
		}

		[Token(Token = "0x600051B")]
		[Address(RVA = "0x1D477B8", Offset = "0x1D477B8", VA = "0x1D477B8")]
		public static Request<PlatformInitialize> AsyncInitialize([Optional] string appId)
		{
			return null;
		}

		[Token(Token = "0x600051C")]
		[Address(RVA = "0x1D47A6C", Offset = "0x1D47A6C", VA = "0x1D47A6C")]
		public static void Initialize([Optional] string appId)
		{
		}

		[Token(Token = "0x600051D")]
		[Address(RVA = "0x1D4776C", Offset = "0x1D4776C", VA = "0x1D4776C")]
		private static string GetAppIDFromConfig()
		{
			return null;
		}

		[Token(Token = "0x600051E")]
		[Address(RVA = "0x1D47D84", Offset = "0x1D47D84", VA = "0x1D47D84")]
		public Core()
		{
		}
	}
	[Token(Token = "0x200008A")]
	public static class ApplicationLifecycle
	{
		[Token(Token = "0x6000520")]
		[Address(RVA = "0x181DEE8", Offset = "0x181DEE8", VA = "0x181DEE8")]
		public static LaunchDetails GetLaunchDetails()
		{
			return null;
		}
	}
	[Token(Token = "0x200008B")]
	public static class Rooms
	{
		[Token(Token = "0x6000521")]
		[Address(RVA = "0x1D59A08", Offset = "0x1D59A08", VA = "0x1D59A08")]
		public static Request<Room> UpdateDataStore(ulong roomID, Dictionary<string, string> data)
		{
			return null;
		}

		[Token(Token = "0x6000522")]
		[Address(RVA = "0x1D59C64", Offset = "0x1D59C64", VA = "0x1D59C64")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x1186658", Offset = "0x1186658")]
		public static void SetRoomInviteNotificationCallback(Message<string>.Callback callback)
		{
		}

		[Token(Token = "0x6000523")]
		[Address(RVA = "0x1D59CE0", Offset = "0x1D59CE0", VA = "0x1D59CE0")]
		public static Request<Room> CreateAndJoinPrivate(RoomJoinPolicy joinPolicy, uint maxUsers, bool subscribeToUpdates = false)
		{
			return null;
		}

		[Token(Token = "0x6000524")]
		[Address(RVA = "0x1D59E14", Offset = "0x1D59E14", VA = "0x1D59E14")]
		public static Request<Room> CreateAndJoinPrivate2(RoomJoinPolicy joinPolicy, uint maxUsers, RoomOptions roomOptions)
		{
			return null;
		}

		[Token(Token = "0x6000525")]
		[Address(RVA = "0x1D59F74", Offset = "0x1D59F74", VA = "0x1D59F74")]
		public static Request<Room> Get(ulong roomID)
		{
			return null;
		}

		[Token(Token = "0x6000526")]
		[Address(RVA = "0x1D5A090", Offset = "0x1D5A090", VA = "0x1D5A090")]
		public static Request<Room> GetCurrent()
		{
			return null;
		}

		[Token(Token = "0x6000527")]
		[Address(RVA = "0x1D5A19C", Offset = "0x1D5A19C", VA = "0x1D5A19C")]
		public static Request<Room> GetCurrentForUser(ulong userID)
		{
			return null;
		}

		[Token(Token = "0x6000528")]
		[Address(RVA = "0x1D5A2B8", Offset = "0x1D5A2B8", VA = "0x1D5A2B8")]
		public static Request<UserList> GetInvitableUsers()
		{
			return null;
		}

		[Token(Token = "0x6000529")]
		[Address(RVA = "0x1D5A3C4", Offset = "0x1D5A3C4", VA = "0x1D5A3C4")]
		public static Request<UserList> GetInvitableUsers2([Optional] RoomOptions roomOptions)
		{
			return null;
		}

		[Token(Token = "0x600052A")]
		[Address(RVA = "0x1D5A50C", Offset = "0x1D5A50C", VA = "0x1D5A50C")]
		public static Request<RoomList> GetModeratedRooms()
		{
			return null;
		}

		[Token(Token = "0x600052B")]
		[Address(RVA = "0x1D5A618", Offset = "0x1D5A618", VA = "0x1D5A618")]
		public static Request<Room> InviteUser(ulong roomID, string inviteToken)
		{
			return null;
		}

		[Token(Token = "0x600052C")]
		[Address(RVA = "0x1D5A73C", Offset = "0x1D5A73C", VA = "0x1D5A73C")]
		public static Request<Room> Join(ulong roomID, bool subscribeToUpdates = false)
		{
			return null;
		}

		[Token(Token = "0x600052D")]
		[Address(RVA = "0x1D5A860", Offset = "0x1D5A860", VA = "0x1D5A860")]
		public static Request<Room> Join2(ulong roomID, RoomOptions roomOptions)
		{
			return null;
		}

		[Token(Token = "0x600052E")]
		[Address(RVA = "0x1D5A9B0", Offset = "0x1D5A9B0", VA = "0x1D5A9B0")]
		public static Request<Room> KickUser(ulong roomID, ulong userID, int kickDurationSeconds)
		{
			return null;
		}

		[Token(Token = "0x600052F")]
		[Address(RVA = "0x1D5AAE4", Offset = "0x1D5AAE4", VA = "0x1D5AAE4")]
		public static Request LaunchInvitableUserFlow(ulong roomID)
		{
			return null;
		}

		[Token(Token = "0x6000530")]
		[Address(RVA = "0x1D5ABF8", Offset = "0x1D5ABF8", VA = "0x1D5ABF8")]
		public static Request<Room> Leave(ulong roomID)
		{
			return null;
		}

		[Token(Token = "0x6000531")]
		[Address(RVA = "0x1D5AD14", Offset = "0x1D5AD14", VA = "0x1D5AD14")]
		public static Request<Room> SetDescription(ulong roomID, string description)
		{
			return null;
		}

		[Token(Token = "0x6000532")]
		[Address(RVA = "0x1D5AE38", Offset = "0x1D5AE38", VA = "0x1D5AE38")]
		public static Request<Room> UpdateMembershipLockStatus(ulong roomID, RoomMembershipLockStatus membershipLockStatus)
		{
			return null;
		}

		[Token(Token = "0x6000533")]
		[Address(RVA = "0x1D5AF5C", Offset = "0x1D5AF5C", VA = "0x1D5AF5C")]
		public static Request UpdateOwner(ulong roomID, ulong userID)
		{
			return null;
		}

		[Token(Token = "0x6000534")]
		[Address(RVA = "0x1D5B078", Offset = "0x1D5B078", VA = "0x1D5B078")]
		public static Request<Room> UpdatePrivateRoomJoinPolicy(ulong roomID, RoomJoinPolicy newJoinPolicy)
		{
			return null;
		}

		[Token(Token = "0x6000535")]
		[Address(RVA = "0x1D59C68", Offset = "0x1D59C68", VA = "0x1D59C68")]
		public static void SetRoomInviteAcceptedNotificationCallback(Message<string>.Callback callback)
		{
		}

		[Token(Token = "0x6000536")]
		[Address(RVA = "0x1D5B19C", Offset = "0x1D5B19C", VA = "0x1D5B19C")]
		public static void SetRoomInviteReceivedNotificationCallback(Message<RoomInviteNotification>.Callback callback)
		{
		}

		[Token(Token = "0x6000537")]
		[Address(RVA = "0x1D5B214", Offset = "0x1D5B214", VA = "0x1D5B214")]
		public static void SetUpdateNotificationCallback(Message<Room>.Callback callback)
		{
		}

		[Token(Token = "0x6000538")]
		[Address(RVA = "0x1D5B28C", Offset = "0x1D5B28C", VA = "0x1D5B28C")]
		public static Request<RoomList> GetNextRoomListPage(RoomList list)
		{
			return null;
		}
	}
	[Token(Token = "0x200008C")]
	public static class Matchmaking
	{
		[Token(Token = "0x200017A")]
		public class CustomQuery
		{
			[Token(Token = "0x20001F5")]
			public struct Criterion
			{
				[Token(Token = "0x4000732")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				public string key;

				[Token(Token = "0x4000733")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
				public MatchmakingCriterionImportance importance;

				[Token(Token = "0x4000734")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				public Dictionary<string, object> parameters;

				[Token(Token = "0x6000A90")]
				[Address(RVA = "0x132C354", Offset = "0x132C354", VA = "0x132C354")]
				public Criterion(string key_, MatchmakingCriterionImportance importance_)
				{
				}
			}

			[Token(Token = "0x40005EA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Dictionary<string, object> data;

			[Token(Token = "0x40005EB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Criterion[] criteria;

			[Token(Token = "0x600099C")]
			[Address(RVA = "0x1D49714", Offset = "0x1D49714", VA = "0x1D49714")]
			public IntPtr ToUnmanaged()
			{
				return default(IntPtr);
			}

			[Token(Token = "0x600099D")]
			[Address(RVA = "0x1D4ABF0", Offset = "0x1D4ABF0", VA = "0x1D4ABF0")]
			public CustomQuery()
			{
			}
		}

		[Token(Token = "0x6000539")]
		[Address(RVA = "0x1D49250", Offset = "0x1D49250", VA = "0x1D49250")]
		public static Request ReportResultsInsecure(ulong roomID, Dictionary<string, int> data)
		{
			return null;
		}

		[Token(Token = "0x600053A")]
		[Address(RVA = "0x1D494AC", Offset = "0x1D494AC", VA = "0x1D494AC")]
		public static Request<MatchmakingStats> GetStats(string pool, uint maxLevel, MatchmakingStatApproach approach = MatchmakingStatApproach.Trailing)
		{
			return null;
		}

		[Token(Token = "0x600053B")]
		[Address(RVA = "0x1D495E0", Offset = "0x1D495E0", VA = "0x1D495E0")]
		public static Request<MatchmakingBrowseResult> Browse(string pool, [Optional] CustomQuery customQueryData)
		{
			return null;
		}

		[Token(Token = "0x600053C")]
		[Address(RVA = "0x1D49A4C", Offset = "0x1D49A4C", VA = "0x1D49A4C")]
		public static Request<MatchmakingBrowseResult> Browse2(string pool, [Optional] MatchmakingOptions matchmakingOptions)
		{
			return null;
		}

		[Token(Token = "0x600053D")]
		[Address(RVA = "0x1D49BEC", Offset = "0x1D49BEC", VA = "0x1D49BEC")]
		public static Request Cancel(string pool, string requestHash)
		{
			return null;
		}

		[Token(Token = "0x600053E")]
		[Address(RVA = "0x1D49D08", Offset = "0x1D49D08", VA = "0x1D49D08")]
		public static Request Cancel()
		{
			return null;
		}

		[Token(Token = "0x600053F")]
		[Address(RVA = "0x1D49E0C", Offset = "0x1D49E0C", VA = "0x1D49E0C")]
		public static Request<MatchmakingEnqueueResultAndRoom> CreateAndEnqueueRoom(string pool, uint maxUsers, bool subscribeToUpdates = false, [Optional] CustomQuery customQueryData)
		{
			return null;
		}

		[Token(Token = "0x6000540")]
		[Address(RVA = "0x1D49F58", Offset = "0x1D49F58", VA = "0x1D49F58")]
		public static Request<MatchmakingEnqueueResultAndRoom> CreateAndEnqueueRoom2(string pool, [Optional] MatchmakingOptions matchmakingOptions)
		{
			return null;
		}

		[Token(Token = "0x6000541")]
		[Address(RVA = "0x1D4A0A8", Offset = "0x1D4A0A8", VA = "0x1D4A0A8")]
		public static Request<Room> CreateRoom(string pool, uint maxUsers, bool subscribeToUpdates = false)
		{
			return null;
		}

		[Token(Token = "0x6000542")]
		[Address(RVA = "0x1D4A1DC", Offset = "0x1D4A1DC", VA = "0x1D4A1DC")]
		public static Request<Room> CreateRoom2(string pool, [Optional] MatchmakingOptions matchmakingOptions)
		{
			return null;
		}

		[Token(Token = "0x6000543")]
		[Address(RVA = "0x1D4A32C", Offset = "0x1D4A32C", VA = "0x1D4A32C")]
		public static Request<MatchmakingEnqueueResult> Enqueue(string pool, [Optional] CustomQuery customQueryData)
		{
			return null;
		}

		[Token(Token = "0x6000544")]
		[Address(RVA = "0x1D4A460", Offset = "0x1D4A460", VA = "0x1D4A460")]
		public static Request<MatchmakingEnqueueResult> Enqueue2(string pool, [Optional] MatchmakingOptions matchmakingOptions)
		{
			return null;
		}

		[Token(Token = "0x6000545")]
		[Address(RVA = "0x1D4A5B0", Offset = "0x1D4A5B0", VA = "0x1D4A5B0")]
		public static Request<MatchmakingEnqueueResult> EnqueueRoom(ulong roomID, [Optional] CustomQuery customQueryData)
		{
			return null;
		}

		[Token(Token = "0x6000546")]
		[Address(RVA = "0x1D4A6E4", Offset = "0x1D4A6E4", VA = "0x1D4A6E4")]
		public static Request<MatchmakingEnqueueResult> EnqueueRoom2(ulong roomID, [Optional] MatchmakingOptions matchmakingOptions)
		{
			return null;
		}

		[Token(Token = "0x6000547")]
		[Address(RVA = "0x1D4A834", Offset = "0x1D4A834", VA = "0x1D4A834")]
		public static Request<MatchmakingAdminSnapshot> GetAdminSnapshot()
		{
			return null;
		}

		[Token(Token = "0x6000548")]
		[Address(RVA = "0x1D4A940", Offset = "0x1D4A940", VA = "0x1D4A940")]
		public static Request<Room> JoinRoom(ulong roomID, bool subscribeToUpdates = false)
		{
			return null;
		}

		[Token(Token = "0x6000549")]
		[Address(RVA = "0x1D4AA64", Offset = "0x1D4AA64", VA = "0x1D4AA64")]
		public static Request StartMatch(ulong roomID)
		{
			return null;
		}

		[Token(Token = "0x600054A")]
		[Address(RVA = "0x1D4AB78", Offset = "0x1D4AB78", VA = "0x1D4AB78")]
		public static void SetMatchFoundNotificationCallback(Message<Room>.Callback callback)
		{
		}
	}
	[Token(Token = "0x200008D")]
	public static class Net
	{
		[Token(Token = "0x600054B")]
		[Address(RVA = "0x1D57C18", Offset = "0x1D57C18", VA = "0x1D57C18")]
		public static Packet ReadPacket()
		{
			return null;
		}

		[Token(Token = "0x600054C")]
		[Address(RVA = "0x1D57DE8", Offset = "0x1D57DE8", VA = "0x1D57DE8")]
		public static bool SendPacket(ulong userID, byte[] bytes, SendPolicy policy)
		{
			return default(bool);
		}

		[Token(Token = "0x600054D")]
		[Address(RVA = "0x1D57F34", Offset = "0x1D57F34", VA = "0x1D57F34")]
		public static void Connect(ulong userID)
		{
		}

		[Token(Token = "0x600054E")]
		[Address(RVA = "0x1D58020", Offset = "0x1D58020", VA = "0x1D58020")]
		public static void Accept(ulong userID)
		{
		}

		[Token(Token = "0x600054F")]
		[Address(RVA = "0x1D5810C", Offset = "0x1D5810C", VA = "0x1D5810C")]
		public static void Close(ulong userID)
		{
		}

		[Token(Token = "0x6000550")]
		[Address(RVA = "0x1D581F8", Offset = "0x1D581F8", VA = "0x1D581F8")]
		public static bool IsConnected(ulong userID)
		{
			return default(bool);
		}

		[Token(Token = "0x6000551")]
		[Address(RVA = "0x1D582E8", Offset = "0x1D582E8", VA = "0x1D582E8")]
		public static bool SendPacketToCurrentRoom(byte[] bytes, SendPolicy policy)
		{
			return default(bool);
		}

		[Token(Token = "0x6000552")]
		[Address(RVA = "0x1D58420", Offset = "0x1D58420", VA = "0x1D58420")]
		public static bool AcceptForCurrentRoom()
		{
			return default(bool);
		}

		[Token(Token = "0x6000553")]
		[Address(RVA = "0x1D584FC", Offset = "0x1D584FC", VA = "0x1D584FC")]
		public static void CloseForCurrentRoom()
		{
		}

		[Token(Token = "0x6000554")]
		[Address(RVA = "0x1D585D4", Offset = "0x1D585D4", VA = "0x1D585D4")]
		public static Request<PingResult> Ping(ulong userID)
		{
			return null;
		}

		[Token(Token = "0x6000555")]
		[Address(RVA = "0x1D586F0", Offset = "0x1D586F0", VA = "0x1D586F0")]
		public static void SetConnectionStateChangedCallback(Message<NetworkingPeer>.Callback callback)
		{
		}

		[Token(Token = "0x6000556")]
		[Address(RVA = "0x1D58768", Offset = "0x1D58768", VA = "0x1D58768")]
		public static void SetPeerConnectRequestCallback(Message<NetworkingPeer>.Callback callback)
		{
		}

		[Token(Token = "0x6000557")]
		[Address(RVA = "0x1D587E0", Offset = "0x1D587E0", VA = "0x1D587E0")]
		public static void SetPingResultNotificationCallback(Message<PingResult>.Callback callback)
		{
		}
	}
	[Token(Token = "0x200008E")]
	public static class Leaderboards
	{
		[Token(Token = "0x6000558")]
		[Address(RVA = "0x1D48894", Offset = "0x1D48894", VA = "0x1D48894")]
		public static Request<LeaderboardEntryList> GetNextEntries(LeaderboardEntryList list)
		{
			return null;
		}

		[Token(Token = "0x6000559")]
		[Address(RVA = "0x1D489C4", Offset = "0x1D489C4", VA = "0x1D489C4")]
		public static Request<LeaderboardEntryList> GetPreviousEntries(LeaderboardEntryList list)
		{
			return null;
		}

		[Token(Token = "0x600055A")]
		[Address(RVA = "0x1D48AF4", Offset = "0x1D48AF4", VA = "0x1D48AF4")]
		public static Request<LeaderboardEntryList> GetEntries(string leaderboardName, int limit, LeaderboardFilterType filter, LeaderboardStartAt startAt)
		{
			return null;
		}

		[Token(Token = "0x600055B")]
		[Address(RVA = "0x1D48C30", Offset = "0x1D48C30", VA = "0x1D48C30")]
		public static Request<LeaderboardEntryList> GetEntriesAfterRank(string leaderboardName, int limit, ulong afterRank)
		{
			return null;
		}

		[Token(Token = "0x600055C")]
		[Address(RVA = "0x1D48D64", Offset = "0x1D48D64", VA = "0x1D48D64")]
		public static Request<bool> WriteEntry(string leaderboardName, long score, [Optional] byte[] extraData, bool forceUpdate = false)
		{
			return null;
		}
	}
	[Token(Token = "0x200008F")]
	public static class Voip
	{
		[Token(Token = "0x600055D")]
		[Address(RVA = "0x1F956D8", Offset = "0x1F956D8", VA = "0x1F956D8")]
		public static void Start(ulong userID)
		{
		}

		[Token(Token = "0x600055E")]
		[Address(RVA = "0x1F95A28", Offset = "0x1F95A28", VA = "0x1F95A28")]
		public static void Accept(ulong userID)
		{
		}

		[Token(Token = "0x600055F")]
		[Address(RVA = "0x1F957C4", Offset = "0x1F957C4", VA = "0x1F957C4")]
		public static void Stop(ulong userID)
		{
		}

		[Token(Token = "0x6000560")]
		[Address(RVA = "0x1F97104", Offset = "0x1F97104", VA = "0x1F97104")]
		public static void SetMicrophoneFilterCallback(CAPI.FilterCallback callback)
		{
		}

		[Token(Token = "0x6000561")]
		[Address(RVA = "0x1F97228", Offset = "0x1F97228", VA = "0x1F97228")]
		public static void SetMicrophoneMuted(VoipMuteState state)
		{
		}

		[Token(Token = "0x6000562")]
		[Address(RVA = "0x1F97314", Offset = "0x1F97314", VA = "0x1F97314")]
		public static VoipMuteState GetSystemVoipMicrophoneMuted()
		{
			return default(VoipMuteState);
		}

		[Token(Token = "0x6000563")]
		[Address(RVA = "0x1F973F0", Offset = "0x1F973F0", VA = "0x1F973F0")]
		public static SystemVoipStatus GetSystemVoipStatus()
		{
			return default(SystemVoipStatus);
		}

		[Token(Token = "0x6000564")]
		[Address(RVA = "0x1F974CC", Offset = "0x1F974CC", VA = "0x1F974CC")]
		public static VoipDtxState GetIsConnectionUsingDtx(ulong peerID)
		{
			return default(VoipDtxState);
		}

		[Token(Token = "0x6000565")]
		[Address(RVA = "0x1F975BC", Offset = "0x1F975BC", VA = "0x1F975BC")]
		public static VoipBitrate GetLocalBitrate(ulong peerID)
		{
			return default(VoipBitrate);
		}

		[Token(Token = "0x6000566")]
		[Address(RVA = "0x1F976AC", Offset = "0x1F976AC", VA = "0x1F976AC")]
		public static VoipBitrate GetRemoteBitrate(ulong peerID)
		{
			return default(VoipBitrate);
		}

		[Token(Token = "0x6000567")]
		[Address(RVA = "0x1F9779C", Offset = "0x1F9779C", VA = "0x1F9779C")]
		public static void SetNewConnectionOptions(VoipOptions voipOptions)
		{
		}

		[Token(Token = "0x6000568")]
		[Address(RVA = "0x1F9789C", Offset = "0x1F9789C", VA = "0x1F9789C")]
		public static Request<SystemVoipState> SetSystemVoipSuppressed(bool suppressed)
		{
			return null;
		}

		[Token(Token = "0x6000569")]
		[Address(RVA = "0x1F955E8", Offset = "0x1F955E8", VA = "0x1F955E8")]
		public static void SetVoipConnectRequestCallback(Message<NetworkingPeer>.Callback callback)
		{
		}

		[Token(Token = "0x600056A")]
		[Address(RVA = "0x1F95660", Offset = "0x1F95660", VA = "0x1F95660")]
		public static void SetVoipStateChangeCallback(Message<NetworkingPeer>.Callback callback)
		{
		}

		[Token(Token = "0x600056B")]
		[Address(RVA = "0x1F979B8", Offset = "0x1F979B8", VA = "0x1F979B8")]
		public static void SetSystemVoipStateNotificationCallback(Message<SystemVoipState>.Callback callback)
		{
		}
	}
	[Token(Token = "0x2000090")]
	public static class Achievements
	{
		[Token(Token = "0x600056C")]
		[Address(RVA = "0x181C750", Offset = "0x181C750", VA = "0x181C750")]
		public static Request<AchievementUpdate> AddCount(string name, ulong count)
		{
			return null;
		}

		[Token(Token = "0x600056D")]
		[Address(RVA = "0x181C928", Offset = "0x181C928", VA = "0x181C928")]
		public static Request<AchievementUpdate> AddFields(string name, string fields)
		{
			return null;
		}

		[Token(Token = "0x600056E")]
		[Address(RVA = "0x181CB1C", Offset = "0x181CB1C", VA = "0x181CB1C")]
		public static Request<AchievementDefinitionList> GetAllDefinitions()
		{
			return null;
		}

		[Token(Token = "0x600056F")]
		[Address(RVA = "0x181CC98", Offset = "0x181CC98", VA = "0x181CC98")]
		public static Request<AchievementProgressList> GetAllProgress()
		{
			return null;
		}

		[Token(Token = "0x6000570")]
		[Address(RVA = "0x181CE14", Offset = "0x181CE14", VA = "0x181CE14")]
		public static Request<AchievementDefinitionList> GetDefinitionsByName(string[] names)
		{
			return null;
		}

		[Token(Token = "0x6000571")]
		[Address(RVA = "0x181D094", Offset = "0x181D094", VA = "0x181D094")]
		public static Request<AchievementProgressList> GetProgressByName(string[] names)
		{
			return null;
		}

		[Token(Token = "0x6000572")]
		[Address(RVA = "0x181D314", Offset = "0x181D314", VA = "0x181D314")]
		public static Request<AchievementUpdate> Unlock(string name)
		{
			return null;
		}

		[Token(Token = "0x6000573")]
		[Address(RVA = "0x181D4D4", Offset = "0x181D4D4", VA = "0x181D4D4")]
		public static Request<AchievementDefinitionList> GetNextAchievementDefinitionListPage(AchievementDefinitionList list)
		{
			return null;
		}

		[Token(Token = "0x6000574")]
		[Address(RVA = "0x181D6F4", Offset = "0x181D6F4", VA = "0x181D6F4")]
		public static Request<AchievementProgressList> GetNextAchievementProgressListPage(AchievementProgressList list)
		{
			return null;
		}
	}
	[Token(Token = "0x2000091")]
	public static class Application
	{
		[Token(Token = "0x6000575")]
		[Address(RVA = "0x181DB40", Offset = "0x181DB40", VA = "0x181DB40")]
		public static Request<ApplicationVersion> GetVersion()
		{
			return null;
		}

		[Token(Token = "0x6000576")]
		[Address(RVA = "0x181DCBC", Offset = "0x181DCBC", VA = "0x181DCBC")]
		public static Request<string> LaunchOtherApp(ulong appID, [Optional] ApplicationOptions deeplink_options)
		{
			return null;
		}
	}
	[Token(Token = "0x2000092")]
	public static class AssetFile
	{
		[Token(Token = "0x6000577")]
		[Address(RVA = "0x181E328", Offset = "0x181E328", VA = "0x181E328")]
		public static Request<AssetFileDeleteResult> Delete(ulong assetFileID)
		{
			return null;
		}

		[Token(Token = "0x6000578")]
		[Address(RVA = "0x181E4C0", Offset = "0x181E4C0", VA = "0x181E4C0")]
		public static Request<AssetFileDeleteResult> DeleteById(ulong assetFileID)
		{
			return null;
		}

		[Token(Token = "0x6000579")]
		[Address(RVA = "0x181E658", Offset = "0x181E658", VA = "0x181E658")]
		public static Request<AssetFileDeleteResult> DeleteByName(string assetFileName)
		{
			return null;
		}

		[Token(Token = "0x600057A")]
		[Address(RVA = "0x181E818", Offset = "0x181E818", VA = "0x181E818")]
		public static Request<AssetFileDownloadResult> Download(ulong assetFileID)
		{
			return null;
		}

		[Token(Token = "0x600057B")]
		[Address(RVA = "0x181E9B0", Offset = "0x181E9B0", VA = "0x181E9B0")]
		public static Request<AssetFileDownloadResult> DownloadById(ulong assetFileID)
		{
			return null;
		}

		[Token(Token = "0x600057C")]
		[Address(RVA = "0x181EB48", Offset = "0x181EB48", VA = "0x181EB48")]
		public static Request<AssetFileDownloadResult> DownloadByName(string assetFileName)
		{
			return null;
		}

		[Token(Token = "0x600057D")]
		[Address(RVA = "0x181ED08", Offset = "0x181ED08", VA = "0x181ED08")]
		public static Request<AssetFileDownloadCancelResult> DownloadCancel(ulong assetFileID)
		{
			return null;
		}

		[Token(Token = "0x600057E")]
		[Address(RVA = "0x181EEA0", Offset = "0x181EEA0", VA = "0x181EEA0")]
		public static Request<AssetFileDownloadCancelResult> DownloadCancelById(ulong assetFileID)
		{
			return null;
		}

		[Token(Token = "0x600057F")]
		[Address(RVA = "0x181F038", Offset = "0x181F038", VA = "0x181F038")]
		public static Request<AssetFileDownloadCancelResult> DownloadCancelByName(string assetFileName)
		{
			return null;
		}

		[Token(Token = "0x6000580")]
		[Address(RVA = "0x181F1F8", Offset = "0x181F1F8", VA = "0x181F1F8")]
		public static Request<AssetDetailsList> GetList()
		{
			return null;
		}

		[Token(Token = "0x6000581")]
		[Address(RVA = "0x181F374", Offset = "0x181F374", VA = "0x181F374")]
		public static Request<AssetDetails> Status(ulong assetFileID)
		{
			return null;
		}

		[Token(Token = "0x6000582")]
		[Address(RVA = "0x181F50C", Offset = "0x181F50C", VA = "0x181F50C")]
		public static Request<AssetDetails> StatusById(ulong assetFileID)
		{
			return null;
		}

		[Token(Token = "0x6000583")]
		[Address(RVA = "0x181F6A4", Offset = "0x181F6A4", VA = "0x181F6A4")]
		public static Request<AssetDetails> StatusByName(string assetFileName)
		{
			return null;
		}

		[Token(Token = "0x6000584")]
		[Address(RVA = "0x181F864", Offset = "0x181F864", VA = "0x181F864")]
		public static void SetDownloadUpdateNotificationCallback(Message<AssetFileDownloadUpdate>.Callback callback)
		{
		}
	}
	[Token(Token = "0x2000093")]
	public static class Avatar
	{
	}
	[Token(Token = "0x2000094")]
	public static class Cal
	{
	}
	[Token(Token = "0x2000095")]
	public static class CloudStorage
	{
		[Token(Token = "0x6000585")]
		[Address(RVA = "0x1D468F4", Offset = "0x1D468F4", VA = "0x1D468F4")]
		public static Request<CloudStorageUpdateResponse> Delete(string bucket, string key)
		{
			return null;
		}

		[Token(Token = "0x6000586")]
		[Address(RVA = "0x1D46A18", Offset = "0x1D46A18", VA = "0x1D46A18")]
		public static Request<CloudStorageData> Load(string bucket, string key)
		{
			return null;
		}

		[Token(Token = "0x6000587")]
		[Address(RVA = "0x1D46B3C", Offset = "0x1D46B3C", VA = "0x1D46B3C")]
		public static Request<CloudStorageMetadataList> LoadBucketMetadata(string bucket)
		{
			return null;
		}

		[Token(Token = "0x6000588")]
		[Address(RVA = "0x1D46C58", Offset = "0x1D46C58", VA = "0x1D46C58")]
		public static Request<CloudStorageConflictMetadata> LoadConflictMetadata(string bucket, string key)
		{
			return null;
		}

		[Token(Token = "0x6000589")]
		[Address(RVA = "0x1D46D7C", Offset = "0x1D46D7C", VA = "0x1D46D7C")]
		public static Request<CloudStorageData> LoadHandle(string handle)
		{
			return null;
		}

		[Token(Token = "0x600058A")]
		[Address(RVA = "0x1D46E98", Offset = "0x1D46E98", VA = "0x1D46E98")]
		public static Request<CloudStorageMetadata> LoadMetadata(string bucket, string key)
		{
			return null;
		}

		[Token(Token = "0x600058B")]
		[Address(RVA = "0x1D46FBC", Offset = "0x1D46FBC", VA = "0x1D46FBC")]
		public static Request<CloudStorageUpdateResponse> ResolveKeepLocal(string bucket, string key, string remoteHandle)
		{
			return null;
		}

		[Token(Token = "0x600058C")]
		[Address(RVA = "0x1D470F0", Offset = "0x1D470F0", VA = "0x1D470F0")]
		public static Request<CloudStorageUpdateResponse> ResolveKeepRemote(string bucket, string key, string remoteHandle)
		{
			return null;
		}

		[Token(Token = "0x600058D")]
		[Address(RVA = "0x1D47224", Offset = "0x1D47224", VA = "0x1D47224")]
		public static Request<CloudStorageUpdateResponse> Save(string bucket, string key, byte[] data, long counter, string extraData)
		{
			return null;
		}

		[Token(Token = "0x600058E")]
		[Address(RVA = "0x1D47384", Offset = "0x1D47384", VA = "0x1D47384")]
		public static Request<CloudStorageMetadataList> GetNextCloudStorageMetadataListPage(CloudStorageMetadataList list)
		{
			return null;
		}
	}
	[Token(Token = "0x2000096")]
	public static class CloudStorage2
	{
	}
	[Token(Token = "0x2000097")]
	public static class Entitlements
	{
		[Token(Token = "0x600058F")]
		[Address(RVA = "0x1D47D90", Offset = "0x1D47D90", VA = "0x1D47D90")]
		public static Request IsUserEntitledToApplication()
		{
			return null;
		}
	}
	[Token(Token = "0x2000098")]
	public static class GraphAPI
	{
	}
	[Token(Token = "0x2000099")]
	public static class HTTP
	{
	}
	[Token(Token = "0x200009A")]
	public static class IAP
	{
		[Token(Token = "0x6000590")]
		[Address(RVA = "0x1D47EC0", Offset = "0x1D47EC0", VA = "0x1D47EC0")]
		public static Request ConsumePurchase(string sku)
		{
			return null;
		}

		[Token(Token = "0x6000591")]
		[Address(RVA = "0x1D47FD4", Offset = "0x1D47FD4", VA = "0x1D47FD4")]
		public static Request<ProductList> GetProductsBySKU(string[] skus)
		{
			return null;
		}

		[Token(Token = "0x6000592")]
		[Address(RVA = "0x1D48104", Offset = "0x1D48104", VA = "0x1D48104")]
		public static Request<PurchaseList> GetViewerPurchases()
		{
			return null;
		}

		[Token(Token = "0x6000593")]
		[Address(RVA = "0x1D48210", Offset = "0x1D48210", VA = "0x1D48210")]
		public static Request<Purchase> LaunchCheckoutFlow(string sku)
		{
			return null;
		}

		[Token(Token = "0x6000594")]
		[Address(RVA = "0x1D48374", Offset = "0x1D48374", VA = "0x1D48374")]
		public static Request<ProductList> GetNextProductListPage(ProductList list)
		{
			return null;
		}

		[Token(Token = "0x6000595")]
		[Address(RVA = "0x1D484F0", Offset = "0x1D484F0", VA = "0x1D484F0")]
		public static Request<PurchaseList> GetNextPurchaseListPage(PurchaseList list)
		{
			return null;
		}
	}
	[Token(Token = "0x200009B")]
	public static class LanguagePack
	{
		[Token(Token = "0x6000596")]
		[Address(RVA = "0x1D4866C", Offset = "0x1D4866C", VA = "0x1D4866C")]
		public static Request<AssetDetails> GetCurrent()
		{
			return null;
		}

		[Token(Token = "0x6000597")]
		[Address(RVA = "0x1D48778", Offset = "0x1D48778", VA = "0x1D48778")]
		public static Request<AssetFileDownloadResult> SetCurrent(string tag)
		{
			return null;
		}
	}
	[Token(Token = "0x200009C")]
	public static class Livestreaming
	{
		[Token(Token = "0x6000598")]
		[Address(RVA = "0x1D48EB4", Offset = "0x1D48EB4", VA = "0x1D48EB4")]
		public static Request<LivestreamingStatus> GetStatus()
		{
			return null;
		}

		[Token(Token = "0x6000599")]
		[Address(RVA = "0x1D48FC0", Offset = "0x1D48FC0", VA = "0x1D48FC0")]
		public static Request<LivestreamingStatus> PauseStream()
		{
			return null;
		}

		[Token(Token = "0x600059A")]
		[Address(RVA = "0x1D490CC", Offset = "0x1D490CC", VA = "0x1D490CC")]
		public static Request<LivestreamingStatus> ResumeStream()
		{
			return null;
		}

		[Token(Token = "0x600059B")]
		[Address(RVA = "0x1D491D8", Offset = "0x1D491D8", VA = "0x1D491D8")]
		public static void SetStatusUpdateNotificationCallback(Message<LivestreamingStatus>.Callback callback)
		{
		}
	}
	[Token(Token = "0x200009D")]
	public static class Media
	{
		[Token(Token = "0x600059C")]
		[Address(RVA = "0x1D4B300", Offset = "0x1D4B300", VA = "0x1D4B300")]
		public static Request<ShareMediaResult> ShareToFacebook(string postTextSuggestion, string filePath, MediaContentType contentType)
		{
			return null;
		}
	}
	[Token(Token = "0x200009E")]
	public static class Notifications
	{
		[Token(Token = "0x600059D")]
		[Address(RVA = "0x1D58858", Offset = "0x1D58858", VA = "0x1D58858")]
		public static Request<RoomInviteNotificationList> GetRoomInviteNotifications()
		{
			return null;
		}

		[Token(Token = "0x600059E")]
		[Address(RVA = "0x1D58964", Offset = "0x1D58964", VA = "0x1D58964")]
		public static Request MarkAsRead(ulong notificationID)
		{
			return null;
		}

		[Token(Token = "0x600059F")]
		[Address(RVA = "0x1D58A78", Offset = "0x1D58A78", VA = "0x1D58A78")]
		public static Request<RoomInviteNotificationList> GetNextRoomInviteNotificationListPage(RoomInviteNotificationList list)
		{
			return null;
		}
	}
	[Token(Token = "0x200009F")]
	public static class Parties
	{
		[Token(Token = "0x60005A0")]
		[Address(RVA = "0x1D58F28", Offset = "0x1D58F28", VA = "0x1D58F28")]
		public static Request<Party> GetCurrent()
		{
			return null;
		}

		[Token(Token = "0x60005A1")]
		[Address(RVA = "0x1D59034", Offset = "0x1D59034", VA = "0x1D59034")]
		public static void SetPartyUpdateNotificationCallback(Message<PartyUpdateNotification>.Callback callback)
		{
		}
	}
	[Token(Token = "0x20000A0")]
	public static class Users
	{
		[Token(Token = "0x60005A2")]
		[Address(RVA = "0x1F80600", Offset = "0x1F80600", VA = "0x1F80600")]
		public static Request<User> Get(ulong userID)
		{
			return null;
		}

		[Token(Token = "0x60005A3")]
		[Address(RVA = "0x1F96654", Offset = "0x1F96654", VA = "0x1F96654")]
		public static Request<string> GetAccessToken()
		{
			return null;
		}

		[Token(Token = "0x60005A4")]
		[Address(RVA = "0x1F804F4", Offset = "0x1F804F4", VA = "0x1F804F4")]
		public static Request<User> GetLoggedInUser()
		{
			return null;
		}

		[Token(Token = "0x60005A5")]
		[Address(RVA = "0x1F8071C", Offset = "0x1F8071C", VA = "0x1F8071C")]
		public static Request<UserList> GetLoggedInUserFriends()
		{
			return null;
		}

		[Token(Token = "0x60005A6")]
		[Address(RVA = "0x1F96760", Offset = "0x1F96760", VA = "0x1F96760")]
		public static Request<UserAndRoomList> GetLoggedInUserFriendsAndRooms()
		{
			return null;
		}

		[Token(Token = "0x60005A7")]
		[Address(RVA = "0x1F9686C", Offset = "0x1F9686C", VA = "0x1F9686C")]
		public static Request<UserAndRoomList> GetLoggedInUserRecentlyMetUsersAndRooms([Optional] UserOptions userOptions)
		{
			return null;
		}

		[Token(Token = "0x60005A8")]
		[Address(RVA = "0x1F969B4", Offset = "0x1F969B4", VA = "0x1F969B4")]
		public static Request<OrgScopedID> GetOrgScopedID(ulong userID)
		{
			return null;
		}

		[Token(Token = "0x60005A9")]
		[Address(RVA = "0x1F96AD0", Offset = "0x1F96AD0", VA = "0x1F96AD0")]
		public static Request<SdkAccountList> GetSdkAccounts()
		{
			return null;
		}

		[Token(Token = "0x60005AA")]
		[Address(RVA = "0x1F803E8", Offset = "0x1F803E8", VA = "0x1F803E8")]
		public static Request<UserProof> GetUserProof()
		{
			return null;
		}

		[Token(Token = "0x60005AB")]
		[Address(RVA = "0x1F96BDC", Offset = "0x1F96BDC", VA = "0x1F96BDC")]
		public static Request<LaunchFriendRequestFlowResult> LaunchFriendRequestFlow(ulong userID)
		{
			return null;
		}

		[Token(Token = "0x60005AC")]
		[Address(RVA = "0x1F96CF8", Offset = "0x1F96CF8", VA = "0x1F96CF8")]
		public static Request LaunchProfile(ulong userID)
		{
			return null;
		}

		[Token(Token = "0x60005AD")]
		[Address(RVA = "0x1F96E0C", Offset = "0x1F96E0C", VA = "0x1F96E0C")]
		public static Request<UserAndRoomList> GetNextUserAndRoomListPage(UserAndRoomList list)
		{
			return null;
		}

		[Token(Token = "0x60005AE")]
		[Address(RVA = "0x1F96F88", Offset = "0x1F96F88", VA = "0x1F96F88")]
		public static Request<UserList> GetNextUserListPage(UserList list)
		{
			return null;
		}
	}
	[Token(Token = "0x20000A1")]
	public enum PlatformInitializeResult
	{
		[Token(Token = "0x4000117")]
		[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x11849C8", Offset = "0x11849C8")]
		Success = 0,
		[Token(Token = "0x4000118")]
		[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x1184A00", Offset = "0x1184A00")]
		Uninitialized = -1,
		[Token(Token = "0x4000119")]
		[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x1184A38", Offset = "0x1184A38")]
		PreLoaded = -2,
		[Token(Token = "0x400011A")]
		[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x1184A70", Offset = "0x1184A70")]
		FileInvalid = -3,
		[Token(Token = "0x400011B")]
		[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x1184AA8", Offset = "0x1184AA8")]
		SignatureInvalid = -4,
		[Token(Token = "0x400011C")]
		[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x1184AE0", Offset = "0x1184AE0")]
		UnableToVerify = -5,
		[Token(Token = "0x400011D")]
		[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x1184B18", Offset = "0x1184B18")]
		VersionMismatch = -6,
		[Token(Token = "0x400011E")]
		[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x1184B50", Offset = "0x1184B50")]
		Unknown = -7,
		[Token(Token = "0x400011F")]
		[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x1184B88", Offset = "0x1184B88")]
		InvalidCredentials = -8,
		[Token(Token = "0x4000120")]
		[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x1184BC0", Offset = "0x1184BC0")]
		NotEntitled = -9
	}
	[Token(Token = "0x20000A2")]
	public static class PlatformInternal
	{
		[Token(Token = "0x200017B")]
		public enum MessageTypeInternal : uint
		{
			[Token(Token = "0x40005ED")]
			Application_ExecuteCoordinatedLaunch = 645772532u,
			[Token(Token = "0x40005EE")]
			Application_GetInstalledApplications = 1376744524u,
			[Token(Token = "0x40005EF")]
			Avatar_UpdateMetaData = 2077219214u,
			[Token(Token = "0x40005F0")]
			Cal_FinalizeApplication = 497667029u,
			[Token(Token = "0x40005F1")]
			Cal_GetSuggestedApplications = 1450209301u,
			[Token(Token = "0x40005F2")]
			Cal_ProposeApplication = 1317270237u,
			[Token(Token = "0x40005F3")]
			CloudStorage2_GetUserDirectoryPath = 1990471406u,
			[Token(Token = "0x40005F4")]
			GraphAPI_Get = 822018158u,
			[Token(Token = "0x40005F5")]
			GraphAPI_Post = 1990567876u,
			[Token(Token = "0x40005F6")]
			HTTP_Get = 1874211363u,
			[Token(Token = "0x40005F7")]
			HTTP_GetToFile = 1317133401u,
			[Token(Token = "0x40005F8")]
			HTTP_MultiPartPost = 1480774160u,
			[Token(Token = "0x40005F9")]
			HTTP_Post = 1798743375u,
			[Token(Token = "0x40005FA")]
			Livestreaming_IsAllowedForApplication = 191729014u,
			[Token(Token = "0x40005FB")]
			Livestreaming_StartPartyStream = 2066701532u,
			[Token(Token = "0x40005FC")]
			Livestreaming_StartStream = 1343932350u,
			[Token(Token = "0x40005FD")]
			Livestreaming_StopPartyStream = 661065560u,
			[Token(Token = "0x40005FE")]
			Livestreaming_StopStream = 1155796426u,
			[Token(Token = "0x40005FF")]
			Livestreaming_UpdateCommentsOverlayVisibility = 528318516u,
			[Token(Token = "0x4000600")]
			Livestreaming_UpdateMicStatus = 475495815u,
			[Token(Token = "0x4000601")]
			Party_Create = 450042703u,
			[Token(Token = "0x4000602")]
			Party_GatherInApplication = 1921499523u,
			[Token(Token = "0x4000603")]
			Party_Get = 1586058173u,
			[Token(Token = "0x4000604")]
			Party_GetCurrentForUser = 1489764138u,
			[Token(Token = "0x4000605")]
			Party_Invite = 901104867u,
			[Token(Token = "0x4000606")]
			Party_Join = 1744993395u,
			[Token(Token = "0x4000607")]
			Party_Leave = 848430801u,
			[Token(Token = "0x4000608")]
			Room_CreateOrUpdateAndJoinNamed = 2089683601u,
			[Token(Token = "0x4000609")]
			Room_GetNamedRooms = 125660812u,
			[Token(Token = "0x400060A")]
			Room_GetSocialRooms = 1636310390u,
			[Token(Token = "0x400060B")]
			SystemPermissions_GetStatus = 493497353u,
			[Token(Token = "0x400060C")]
			SystemPermissions_LaunchDeeplink = 442139697u,
			[Token(Token = "0x400060D")]
			User_CancelRecordingForReportFlow = 65065289u,
			[Token(Token = "0x400060E")]
			User_GetLinkedAccounts = 1469314134u,
			[Token(Token = "0x400060F")]
			User_LaunchBlockFlow = 1876305192u,
			[Token(Token = "0x4000610")]
			User_LaunchReportFlow = 1449304081u,
			[Token(Token = "0x4000611")]
			User_LaunchReportFlow2 = 2139314275u,
			[Token(Token = "0x4000612")]
			User_LaunchUnblockFlow = 346172055u,
			[Token(Token = "0x4000613")]
			User_NewEntitledTestUser = 292822787u,
			[Token(Token = "0x4000614")]
			User_NewTestUser = 921194380u,
			[Token(Token = "0x4000615")]
			User_NewTestUserFriends = 517416647u,
			[Token(Token = "0x4000616")]
			User_StartRecordingForReportFlow = 1819161571u,
			[Token(Token = "0x4000617")]
			User_StopRecordingAndLaunchReportFlow = 1618513035u,
			[Token(Token = "0x4000618")]
			User_StopRecordingAndLaunchReportFlow2 = 432190251u,
			[Token(Token = "0x4000619")]
			User_TestUserCreateDeviceManifest = 1701884605u
		}

		[Token(Token = "0x200017C")]
		public static class HTTP
		{
			[Token(Token = "0x600099E")]
			[Address(RVA = "0x1D5910C", Offset = "0x1D5910C", VA = "0x1D5910C")]
			public static void SetHttpTransferUpdateCallback(Message<HttpTransferUpdate>.Callback callback)
			{
			}
		}

		[Token(Token = "0x60005AF")]
		[Address(RVA = "0x1D590AC", Offset = "0x1D590AC", VA = "0x1D590AC")]
		public static void CrashApplication()
		{
		}

		[Token(Token = "0x60005B0")]
		[Address(RVA = "0x1D4E0A8", Offset = "0x1D4E0A8", VA = "0x1D4E0A8")]
		internal static Message ParseMessageHandle(IntPtr messageHandle, Message.MessageType messageType)
		{
			return null;
		}
	}
	[Token(Token = "0x20000A3")]
	public sealed class PlatformSettings : ScriptableObject
	{
		[Token(Token = "0x4000121")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private string ovrAppID;

		[Token(Token = "0x4000122")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private string ovrMobileAppID;

		[Token(Token = "0x4000123")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private bool ovrUseStandalonePlatform;

		[Token(Token = "0x4000124")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
		[SerializeField]
		private bool ovrEnableARM64Support;

		[Token(Token = "0x4000125")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static PlatformSettings instance;

		[Token(Token = "0x17000011")]
		public static string AppID
		{
			[Token(Token = "0x60005B1")]
			[Address(RVA = "0x1D47D64", Offset = "0x1D47D64", VA = "0x1D47D64")]
			get
			{
				return null;
			}
			[Token(Token = "0x60005B2")]
			[Address(RVA = "0x1D59298", Offset = "0x1D59298", VA = "0x1D59298")]
			set
			{
			}
		}

		[Token(Token = "0x17000012")]
		public static string MobileAppID
		{
			[Token(Token = "0x60005B3")]
			[Address(RVA = "0x1D47D44", Offset = "0x1D47D44", VA = "0x1D47D44")]
			get
			{
				return null;
			}
			[Token(Token = "0x60005B4")]
			[Address(RVA = "0x1D592C4", Offset = "0x1D592C4", VA = "0x1D592C4")]
			set
			{
			}
		}

		[Token(Token = "0x17000013")]
		public static bool UseStandalonePlatform
		{
			[Token(Token = "0x60005B5")]
			[Address(RVA = "0x1D47A4C", Offset = "0x1D47A4C", VA = "0x1D47A4C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60005B6")]
			[Address(RVA = "0x1D592F0", Offset = "0x1D592F0", VA = "0x1D592F0")]
			set
			{
			}
		}

		[Token(Token = "0x17000014")]
		public static bool EnableARM64Support
		{
			[Token(Token = "0x60005B7")]
			[Address(RVA = "0x1D59320", Offset = "0x1D59320", VA = "0x1D59320")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60005B8")]
			[Address(RVA = "0x1D59340", Offset = "0x1D59340", VA = "0x1D59340")]
			set
			{
			}
		}

		[Token(Token = "0x17000015")]
		public static PlatformSettings Instance
		{
			[Token(Token = "0x60005B9")]
			[Address(RVA = "0x1D59184", Offset = "0x1D59184", VA = "0x1D59184")]
			get
			{
				return null;
			}
			[Token(Token = "0x60005BA")]
			[Address(RVA = "0x1D59370", Offset = "0x1D59370", VA = "0x1D59370")]
			set
			{
			}
		}

		[Token(Token = "0x60005BB")]
		[Address(RVA = "0x1D593C4", Offset = "0x1D593C4", VA = "0x1D593C4")]
		public PlatformSettings()
		{
		}
	}
	[Token(Token = "0x20000A4")]
	public sealed class Request<T> : Request
	{
		[Token(Token = "0x60005BC")]
		public Request(ulong requestID)
		{
		}

		[Token(Token = "0x60005BD")]
		public Request<T> OnComplete(Message<T>.Callback callback)
		{
			return null;
		}
	}
	[Token(Token = "0x20000A5")]
	public class Request
	{
		[Token(Token = "0x4000126")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1184C38", Offset = "0x1184C38")]
		private ulong <RequestID>k__BackingField;

		[Token(Token = "0x17000016")]
		public ulong RequestID
		{
			[Token(Token = "0x60005BF")]
			[Address(RVA = "0x1D59424", Offset = "0x1D59424", VA = "0x1D59424")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1186690", Offset = "0x1186690")]
			get
			{
				return default(ulong);
			}
			[Token(Token = "0x60005C0")]
			[Address(RVA = "0x1D5942C", Offset = "0x1D5942C", VA = "0x1D5942C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x11866A0", Offset = "0x11866A0")]
			set
			{
			}
		}

		[Token(Token = "0x60005BE")]
		[Address(RVA = "0x1D47E94", Offset = "0x1D47E94", VA = "0x1D47E94")]
		public Request(ulong requestID)
		{
		}

		[Token(Token = "0x60005C1")]
		[Address(RVA = "0x1D59434", Offset = "0x1D59434", VA = "0x1D59434")]
		public Request OnComplete(Message.Callback callback)
		{
			return null;
		}

		[Token(Token = "0x60005C2")]
		[Address(RVA = "0x1D4685C", Offset = "0x1D4685C", VA = "0x1D4685C")]
		public static void RunCallbacks(uint limit = 0u)
		{
		}
	}
	[Token(Token = "0x20000A6")]
	public enum RoomJoinPolicy
	{
		[Token(Token = "0x4000128")]
		[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x1184C48", Offset = "0x1184C48")]
		None,
		[Token(Token = "0x4000129")]
		[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x1184C80", Offset = "0x1184C80")]
		Everyone,
		[Token(Token = "0x400012A")]
		[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x1184CB8", Offset = "0x1184CB8")]
		FriendsOfMembers,
		[Token(Token = "0x400012B")]
		[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x1184CF0", Offset = "0x1184CF0")]
		FriendsOfOwner,
		[Token(Token = "0x400012C")]
		[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x1184D28", Offset = "0x1184D28")]
		InvitedUsers,
		[Token(Token = "0x400012D")]
		[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x1184D60", Offset = "0x1184D60")]
		Unknown
	}
	[Token(Token = "0x20000A7")]
	public enum RoomJoinability
	{
		[Token(Token = "0x400012F")]
		[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x1184D98", Offset = "0x1184D98")]
		Unknown,
		[Token(Token = "0x4000130")]
		[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x1184DD0", Offset = "0x1184DD0")]
		AreIn,
		[Token(Token = "0x4000131")]
		[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x1184E08", Offset = "0x1184E08")]
		AreKicked,
		[Token(Token = "0x4000132")]
		[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x1184E40", Offset = "0x1184E40")]
		CanJoin,
		[Token(Token = "0x4000133")]
		[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x1184E78", Offset = "0x1184E78")]
		IsFull,
		[Token(Token = "0x4000134")]
		[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x1184EB0", Offset = "0x1184EB0")]
		NoViewer,
		[Token(Token = "0x4000135")]
		[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x1184EE8", Offset = "0x1184EE8")]
		PolicyPrevents
	}
	[Token(Token = "0x20000A8")]
	public enum RoomMembershipLockStatus
	{
		[Token(Token = "0x4000137")]
		[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x1184F20", Offset = "0x1184F20")]
		Unknown,
		[Token(Token = "0x4000138")]
		[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x1184F58", Offset = "0x1184F58")]
		Lock,
		[Token(Token = "0x4000139")]
		[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x1184F90", Offset = "0x1184F90")]
		Unlock
	}
	[Token(Token = "0x20000A9")]
	public class RoomOptions
	{
		[Token(Token = "0x400013A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private IntPtr Handle;

		[Token(Token = "0x60005C3")]
		[Address(RVA = "0x1D594B0", Offset = "0x1D594B0", VA = "0x1D594B0")]
		public RoomOptions()
		{
		}

		[Token(Token = "0x60005C4")]
		[Address(RVA = "0x1D59528", Offset = "0x1D59528", VA = "0x1D59528")]
		public void SetDataStore(string key, string value)
		{
		}

		[Token(Token = "0x60005C5")]
		[Address(RVA = "0x1D595AC", Offset = "0x1D595AC", VA = "0x1D595AC")]
		public void ClearDataStore()
		{
		}

		[Token(Token = "0x60005C6")]
		[Address(RVA = "0x1D59618", Offset = "0x1D59618", VA = "0x1D59618")]
		public void SetExcludeRecentlyMet(bool value)
		{
		}

		[Token(Token = "0x60005C7")]
		[Address(RVA = "0x1D59694", Offset = "0x1D59694", VA = "0x1D59694")]
		public void SetMaxUserResults(uint value)
		{
		}

		[Token(Token = "0x60005C8")]
		[Address(RVA = "0x1D59710", Offset = "0x1D59710", VA = "0x1D59710")]
		public void SetOrdering(UserOrdering value)
		{
		}

		[Token(Token = "0x60005C9")]
		[Address(RVA = "0x1D5978C", Offset = "0x1D5978C", VA = "0x1D5978C")]
		public void SetRecentlyMetTimeWindow(TimeWindow value)
		{
		}

		[Token(Token = "0x60005CA")]
		[Address(RVA = "0x1D59808", Offset = "0x1D59808", VA = "0x1D59808")]
		public void SetRoomId(ulong value)
		{
		}

		[Token(Token = "0x60005CB")]
		[Address(RVA = "0x1D59884", Offset = "0x1D59884", VA = "0x1D59884")]
		public void SetTurnOffUpdates(bool value)
		{
		}

		[Token(Token = "0x60005CC")]
		[Address(RVA = "0x1D59900", Offset = "0x1D59900", VA = "0x1D59900")]
		public static explicit operator IntPtr(RoomOptions options)
		{
			return default(IntPtr);
		}

		[Token(Token = "0x60005CD")]
		[Address(RVA = "0x1D59950", Offset = "0x1D59950", VA = "0x1D59950", Slot = "1")]
		~RoomOptions()
		{
		}
	}
	[Token(Token = "0x20000AA")]
	public enum RoomType
	{
		[Token(Token = "0x400013C")]
		[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x1184FC8", Offset = "0x1184FC8")]
		Unknown,
		[Token(Token = "0x400013D")]
		[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x1185000", Offset = "0x1185000")]
		Matchmaking,
		[Token(Token = "0x400013E")]
		[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x1185038", Offset = "0x1185038")]
		Moderated,
		[Token(Token = "0x400013F")]
		[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x1185070", Offset = "0x1185070")]
		Private,
		[Token(Token = "0x4000140")]
		[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x11850A8", Offset = "0x11850A8")]
		Solo
	}
	[Token(Token = "0x20000AB")]
	public enum SdkAccountType
	{
		[Token(Token = "0x4000142")]
		[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x11850E0", Offset = "0x11850E0")]
		Unknown,
		[Token(Token = "0x4000143")]
		[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x1185118", Offset = "0x1185118")]
		Oculus,
		[Token(Token = "0x4000144")]
		[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x1185150", Offset = "0x1185150")]
		FacebookGameroom
	}
	[Token(Token = "0x20000AC")]
	public enum SendPolicy
	{
		[Token(Token = "0x4000146")]
		[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x1185188", Offset = "0x1185188")]
		Unreliable,
		[Token(Token = "0x4000147")]
		[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x11851C0", Offset = "0x11851C0")]
		Reliable,
		[Token(Token = "0x4000148")]
		[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x11851F8", Offset = "0x11851F8")]
		Unknown
	}
	[Token(Token = "0x20000AD")]
	public enum ServiceProvider
	{
		[Token(Token = "0x400014A")]
		[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x1185230", Offset = "0x1185230")]
		Unknown,
		[Token(Token = "0x400014B")]
		[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x1185268", Offset = "0x1185268")]
		Dropbox,
		[Token(Token = "0x400014C")]
		[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x11852A0", Offset = "0x11852A0")]
		Facebook,
		[Token(Token = "0x400014D")]
		[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x11852D8", Offset = "0x11852D8")]
		Google,
		[Token(Token = "0x400014E")]
		[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x1185310", Offset = "0x1185310")]
		Instagram,
		[Token(Token = "0x400014F")]
		[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x1185348", Offset = "0x1185348")]
		RemoteMedia
	}
	[Token(Token = "0x20000AE")]
	public enum ShareMediaStatus
	{
		[Token(Token = "0x4000151")]
		[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x1185380", Offset = "0x1185380")]
		Unknown,
		[Token(Token = "0x4000152")]
		[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x11853B8", Offset = "0x11853B8")]
		Shared,
		[Token(Token = "0x4000153")]
		[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x11853F0", Offset = "0x11853F0")]
		Canceled
	}
	[Token(Token = "0x20000AF")]
	public sealed class StandalonePlatform
	{
		[Token(Token = "0x200017D")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x1183474", Offset = "0x1183474")]
		public delegate void UnityLogDelegate(IntPtr tag, IntPtr msg);

		[Token(Token = "0x60005CE")]
		[Address(RVA = "0x1F95CFC", Offset = "0x1F95CFC", VA = "0x1F95CFC")]
		public Request<PlatformInitialize> InitializeInEditor()
		{
			return null;
		}

		[Token(Token = "0x60005CF")]
		[Address(RVA = "0x1F95EB0", Offset = "0x1F95EB0", VA = "0x1F95EB0")]
		public StandalonePlatform()
		{
		}
	}
	[Token(Token = "0x20000B0")]
	public sealed class StandalonePlatformSettings
	{
		[Token(Token = "0x17000017")]
		public static string OculusPlatformTestUserEmail
		{
			[Token(Token = "0x60005D0")]
			[Address(RVA = "0x1F961F0", Offset = "0x1F961F0", VA = "0x1F961F0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60005D1")]
			[Address(RVA = "0x1F96240", Offset = "0x1F96240", VA = "0x1F96240")]
			set
			{
			}
		}

		[Token(Token = "0x17000018")]
		public static string OculusPlatformTestUserPassword
		{
			[Token(Token = "0x60005D2")]
			[Address(RVA = "0x1F96244", Offset = "0x1F96244", VA = "0x1F96244")]
			get
			{
				return null;
			}
			[Token(Token = "0x60005D3")]
			[Address(RVA = "0x1F96294", Offset = "0x1F96294", VA = "0x1F96294")]
			set
			{
			}
		}

		[Token(Token = "0x17000019")]
		public static string OculusPlatformTestUserAccessToken
		{
			[Token(Token = "0x60005D4")]
			[Address(RVA = "0x1F96298", Offset = "0x1F96298", VA = "0x1F96298")]
			get
			{
				return null;
			}
			[Token(Token = "0x60005D5")]
			[Address(RVA = "0x1F962E8", Offset = "0x1F962E8", VA = "0x1F962E8")]
			set
			{
			}
		}

		[Token(Token = "0x60005D6")]
		[Address(RVA = "0x1F962EC", Offset = "0x1F962EC", VA = "0x1F962EC")]
		public StandalonePlatformSettings()
		{
		}
	}
	[Token(Token = "0x20000B1")]
	public enum SystemVoipStatus
	{
		[Token(Token = "0x4000155")]
		[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x1185428", Offset = "0x1185428")]
		Unknown,
		[Token(Token = "0x4000156")]
		[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x1185460", Offset = "0x1185460")]
		Unavailable,
		[Token(Token = "0x4000157")]
		[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x1185498", Offset = "0x1185498")]
		Suppressed,
		[Token(Token = "0x4000158")]
		[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x11854D0", Offset = "0x11854D0")]
		Active
	}
	[Token(Token = "0x20000B2")]
	public enum TimeWindow
	{
		[Token(Token = "0x400015A")]
		[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x1185508", Offset = "0x1185508")]
		Unknown,
		[Token(Token = "0x400015B")]
		[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x1185540", Offset = "0x1185540")]
		OneHour,
		[Token(Token = "0x400015C")]
		[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x1185578", Offset = "0x1185578")]
		OneDay,
		[Token(Token = "0x400015D")]
		[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x11855B0", Offset = "0x11855B0")]
		OneWeek,
		[Token(Token = "0x400015E")]
		[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x11855E8", Offset = "0x11855E8")]
		ThirtyDays,
		[Token(Token = "0x400015F")]
		[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x1185620", Offset = "0x1185620")]
		NinetyDays
	}
	[Token(Token = "0x20000B3")]
	public class UserOptions
	{
		[Token(Token = "0x4000160")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private IntPtr Handle;

		[Token(Token = "0x60005D7")]
		[Address(RVA = "0x1F962F4", Offset = "0x1F962F4", VA = "0x1F962F4")]
		public UserOptions()
		{
		}

		[Token(Token = "0x60005D8")]
		[Address(RVA = "0x1F9636C", Offset = "0x1F9636C", VA = "0x1F9636C")]
		public void SetMaxUsers(uint value)
		{
		}

		[Token(Token = "0x60005D9")]
		[Address(RVA = "0x1F963E8", Offset = "0x1F963E8", VA = "0x1F963E8")]
		public void AddServiceProvider(ServiceProvider value)
		{
		}

		[Token(Token = "0x60005DA")]
		[Address(RVA = "0x1F96464", Offset = "0x1F96464", VA = "0x1F96464")]
		public void ClearServiceProviders()
		{
		}

		[Token(Token = "0x60005DB")]
		[Address(RVA = "0x1F964D0", Offset = "0x1F964D0", VA = "0x1F964D0")]
		public void SetTimeWindow(TimeWindow value)
		{
		}

		[Token(Token = "0x60005DC")]
		[Address(RVA = "0x1F9654C", Offset = "0x1F9654C", VA = "0x1F9654C")]
		public static explicit operator IntPtr(UserOptions options)
		{
			return default(IntPtr);
		}

		[Token(Token = "0x60005DD")]
		[Address(RVA = "0x1F9659C", Offset = "0x1F9659C", VA = "0x1F9659C", Slot = "1")]
		~UserOptions()
		{
		}
	}
	[Token(Token = "0x20000B4")]
	public enum UserOrdering
	{
		[Token(Token = "0x4000162")]
		[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x1185658", Offset = "0x1185658")]
		Unknown,
		[Token(Token = "0x4000163")]
		[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x1185690", Offset = "0x1185690")]
		None,
		[Token(Token = "0x4000164")]
		[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x11856C8", Offset = "0x11856C8")]
		PresenceAlphabetical
	}
	[Token(Token = "0x20000B5")]
	public enum UserPresenceStatus
	{
		[Token(Token = "0x4000166")]
		[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x1185700", Offset = "0x1185700")]
		Unknown,
		[Token(Token = "0x4000167")]
		[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x1185738", Offset = "0x1185738")]
		Online,
		[Token(Token = "0x4000168")]
		[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x1185770", Offset = "0x1185770")]
		Offline
	}
	[Token(Token = "0x20000B6")]
	public class VoipAudioSourceHiLevel : MonoBehaviour
	{
		[Token(Token = "0x200017E")]
		public class FilterReadDelegate : MonoBehaviour
		{
			[Token(Token = "0x400061A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public VoipAudioSourceHiLevel parent;

			[Token(Token = "0x400061B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private float[] scratchBuffer;

			[Token(Token = "0x60009A3")]
			[Address(RVA = "0x3338660", Offset = "0x3338660", VA = "0x3338660")]
			private void Awake()
			{
			}

			[Token(Token = "0x60009A4")]
			[Address(RVA = "0x3338718", Offset = "0x3338718", VA = "0x3338718")]
			private void OnAudioFilterRead(float[] data, int channels)
			{
			}

			[Token(Token = "0x60009A5")]
			[Address(RVA = "0x3338BE0", Offset = "0x3338BE0", VA = "0x3338BE0")]
			public FilterReadDelegate()
			{
			}
		}

		[Token(Token = "0x4000169")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private int initialPlaybackDelayMS;

		[Token(Token = "0x400016A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public AudioSource audioSource;

		[Token(Token = "0x400016B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float peakAmplitude;

		[Token(Token = "0x400016C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		protected IVoipPCMSource pcmSource;

		[Token(Token = "0x400016D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static int audioSystemPlaybackFrequency;

		[Token(Token = "0x400016E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		private static bool verboseLogging;

		[Token(Token = "0x1700001A")]
		public ulong senderID
		{
			[Token(Token = "0x60005DE")]
			[Address(RVA = "0x3337EC4", Offset = "0x3337EC4", VA = "0x3337EC4")]
			set
			{
			}
		}

		[Token(Token = "0x60005DF")]
		[Address(RVA = "0x3337F88", Offset = "0x3337F88", VA = "0x3337F88")]
		protected void Stop()
		{
		}

		[Token(Token = "0x60005E0")]
		[Address(RVA = "0x3337F8C", Offset = "0x3337F8C", VA = "0x3337F8C")]
		private VoipSampleRate SampleRateToEnum(int rate)
		{
			return default(VoipSampleRate);
		}

		[Token(Token = "0x60005E1")]
		[Address(RVA = "0x3337FC8", Offset = "0x3337FC8", VA = "0x3337FC8")]
		protected void Awake()
		{
		}

		[Token(Token = "0x60005E2")]
		[Address(RVA = "0x3338270", Offset = "0x3338270", VA = "0x3338270")]
		private void Start()
		{
		}

		[Token(Token = "0x60005E3")]
		[Address(RVA = "0x333828C", Offset = "0x333828C", VA = "0x333828C", Slot = "4")]
		protected virtual void CreatePCMSource()
		{
		}

		[Token(Token = "0x60005E4")]
		[Address(RVA = "0x33382F4", Offset = "0x33382F4", VA = "0x33382F4")]
		protected static int MSToElements(int ms)
		{
			return default(int);
		}

		[Token(Token = "0x60005E5")]
		[Address(RVA = "0x333837C", Offset = "0x333837C", VA = "0x333837C")]
		private void Update()
		{
		}

		[Token(Token = "0x60005E6")]
		[Address(RVA = "0x3338654", Offset = "0x3338654", VA = "0x3338654")]
		public VoipAudioSourceHiLevel()
		{
		}
	}
	[Token(Token = "0x20000B7")]
	public enum VoipBitrate
	{
		[Token(Token = "0x4000170")]
		[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x11857A8", Offset = "0x11857A8")]
		Unknown,
		[Token(Token = "0x4000171")]
		[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x11857E0", Offset = "0x11857E0")]
		B16000,
		[Token(Token = "0x4000172")]
		[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x1185818", Offset = "0x1185818")]
		B24000,
		[Token(Token = "0x4000173")]
		[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x1185850", Offset = "0x1185850")]
		B32000,
		[Token(Token = "0x4000174")]
		[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x1185888", Offset = "0x1185888")]
		B64000,
		[Token(Token = "0x4000175")]
		[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x11858C0", Offset = "0x11858C0")]
		B96000,
		[Token(Token = "0x4000176")]
		[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x11858F8", Offset = "0x11858F8")]
		B128000
	}
	[Token(Token = "0x20000B8")]
	public enum VoipDtxState
	{
		[Token(Token = "0x4000178")]
		[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x1185930", Offset = "0x1185930")]
		Unknown,
		[Token(Token = "0x4000179")]
		[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x1185968", Offset = "0x1185968")]
		Enabled,
		[Token(Token = "0x400017A")]
		[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x11859A0", Offset = "0x11859A0")]
		Disabled
	}
	[Token(Token = "0x20000B9")]
	public enum VoipMuteState
	{
		[Token(Token = "0x400017C")]
		[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x11859D8", Offset = "0x11859D8")]
		Unknown,
		[Token(Token = "0x400017D")]
		[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x1185A10", Offset = "0x1185A10")]
		Muted,
		[Token(Token = "0x400017E")]
		[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x1185A48", Offset = "0x1185A48")]
		Unmuted
	}
	[Token(Token = "0x20000BA")]
	public class VoipOptions
	{
		[Token(Token = "0x400017F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private IntPtr Handle;

		[Token(Token = "0x60005E8")]
		[Address(RVA = "0x3338BE8", Offset = "0x3338BE8", VA = "0x3338BE8")]
		public VoipOptions()
		{
		}

		[Token(Token = "0x60005E9")]
		[Address(RVA = "0x3338C60", Offset = "0x3338C60", VA = "0x3338C60")]
		public void SetBitrateForNewConnections(VoipBitrate value)
		{
		}

		[Token(Token = "0x60005EA")]
		[Address(RVA = "0x3338CDC", Offset = "0x3338CDC", VA = "0x3338CDC")]
		public void SetCreateNewConnectionUseDtx(VoipDtxState value)
		{
		}

		[Token(Token = "0x60005EB")]
		[Address(RVA = "0x3338D58", Offset = "0x3338D58", VA = "0x3338D58")]
		public static explicit operator IntPtr(VoipOptions options)
		{
			return default(IntPtr);
		}

		[Token(Token = "0x60005EC")]
		[Address(RVA = "0x3338DA8", Offset = "0x3338DA8", VA = "0x3338DA8", Slot = "1")]
		~VoipOptions()
		{
		}
	}
	[Token(Token = "0x20000BB")]
	public class VoipPCMSourceNative : IVoipPCMSource
	{
		[Token(Token = "0x4000180")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private ulong senderID;

		[Token(Token = "0x60005ED")]
		[Address(RVA = "0x3338E60", Offset = "0x3338E60", VA = "0x3338E60", Slot = "4")]
		public int GetPCM(float[] dest, int length)
		{
			return default(int);
		}

		[Token(Token = "0x60005EE")]
		[Address(RVA = "0x3338F20", Offset = "0x3338F20", VA = "0x3338F20", Slot = "5")]
		public void SetSenderID(ulong senderID)
		{
		}

		[Token(Token = "0x60005EF")]
		[Address(RVA = "0x3338F28", Offset = "0x3338F28", VA = "0x3338F28", Slot = "7")]
		public int PeekSizeElements()
		{
			return default(int);
		}

		[Token(Token = "0x60005F0")]
		[Address(RVA = "0x3338FC8", Offset = "0x3338FC8", VA = "0x3338FC8", Slot = "6")]
		public void Update()
		{
		}

		[Token(Token = "0x60005F1")]
		[Address(RVA = "0x33382EC", Offset = "0x33382EC", VA = "0x33382EC")]
		public VoipPCMSourceNative()
		{
		}
	}
	[Token(Token = "0x20000BC")]
	public enum VoipSampleRate
	{
		[Token(Token = "0x4000182")]
		[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x1185A80", Offset = "0x1185A80")]
		Unknown,
		[Token(Token = "0x4000183")]
		[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x1185AB8", Offset = "0x1185AB8")]
		HZ24000,
		[Token(Token = "0x4000184")]
		[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x1185AF0", Offset = "0x1185AF0")]
		HZ44100,
		[Token(Token = "0x4000185")]
		[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x1185B28", Offset = "0x1185B28")]
		HZ48000
	}
	[Token(Token = "0x20000BD")]
	public class WindowsPlatform
	{
		[Token(Token = "0x200017F")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x1183488", Offset = "0x1183488")]
		public delegate void UnityLogDelegate(IntPtr tag, IntPtr msg);

		[Token(Token = "0x60005F2")]
		[Address(RVA = "0x3338FCC", Offset = "0x3338FCC", VA = "0x3338FCC")]
		private void CPPLogCallback(IntPtr tag, IntPtr message)
		{
		}

		[Token(Token = "0x60005F3")]
		[Address(RVA = "0x33390A4", Offset = "0x33390A4", VA = "0x33390A4")]
		private IntPtr getCallbackPointer()
		{
			return default(IntPtr);
		}

		[Token(Token = "0x60005F4")]
		[Address(RVA = "0x33390E4", Offset = "0x33390E4", VA = "0x33390E4")]
		public bool Initialize(string appId)
		{
			return default(bool);
		}

		[Token(Token = "0x60005F5")]
		[Address(RVA = "0x33391C8", Offset = "0x33391C8", VA = "0x33391C8")]
		public Request<PlatformInitialize> AsyncInitialize(string appId)
		{
			return null;
		}

		[Token(Token = "0x60005F6")]
		[Address(RVA = "0x33392DC", Offset = "0x33392DC", VA = "0x33392DC")]
		public WindowsPlatform()
		{
		}
	}
}
namespace Oculus.Platform.Models
{
	[Token(Token = "0x20000BE")]
	public class AbuseReportRecording
	{
		[Token(Token = "0x4000186")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public readonly string RecordingUuid;

		[Token(Token = "0x60005F7")]
		[Address(RVA = "0x1D4ECC8", Offset = "0x1D4ECC8", VA = "0x1D4ECC8")]
		public AbuseReportRecording(IntPtr o)
		{
		}
	}
	[Token(Token = "0x20000BF")]
	public class AchievementDefinition
	{
		[Token(Token = "0x4000187")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public readonly AchievementType Type;

		[Token(Token = "0x4000188")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public readonly string Name;

		[Token(Token = "0x4000189")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public readonly uint BitfieldLength;

		[Token(Token = "0x400018A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public readonly ulong Target;

		[Token(Token = "0x60005F8")]
		[Address(RVA = "0x1D56CB4", Offset = "0x1D56CB4", VA = "0x1D56CB4")]
		public AchievementDefinition(IntPtr o)
		{
		}
	}
	[Token(Token = "0x20000C0")]
	public class AchievementDefinitionList : DeserializableList<AchievementDefinition>
	{
		[Token(Token = "0x60005F9")]
		[Address(RVA = "0x1D4EE30", Offset = "0x1D4EE30", VA = "0x1D4EE30")]
		public AchievementDefinitionList(IntPtr a)
		{
		}
	}
	[Token(Token = "0x20000C1")]
	public class AchievementProgress
	{
		[Token(Token = "0x400018B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public readonly string Bitfield;

		[Token(Token = "0x400018C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public readonly ulong Count;

		[Token(Token = "0x400018D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public readonly bool IsUnlocked;

		[Token(Token = "0x400018E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public readonly string Name;

		[Token(Token = "0x400018F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public readonly DateTime UnlockTime;

		[Token(Token = "0x60005FA")]
		[Address(RVA = "0x1D56D6C", Offset = "0x1D56D6C", VA = "0x1D56D6C")]
		public AchievementProgress(IntPtr o)
		{
		}
	}
	[Token(Token = "0x20000C2")]
	public class AchievementProgressList : DeserializableList<AchievementProgress>
	{
		[Token(Token = "0x60005FB")]
		[Address(RVA = "0x1D4F110", Offset = "0x1D4F110", VA = "0x1D4F110")]
		public AchievementProgressList(IntPtr a)
		{
		}
	}
	[Token(Token = "0x20000C3")]
	public class AchievementUpdate
	{
		[Token(Token = "0x4000190")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public readonly bool JustUnlocked;

		[Token(Token = "0x4000191")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public readonly string Name;

		[Token(Token = "0x60005FC")]
		[Address(RVA = "0x1D4F3F0", Offset = "0x1D4F3F0", VA = "0x1D4F3F0")]
		public AchievementUpdate(IntPtr o)
		{
		}
	}
	[Token(Token = "0x20000C4")]
	public class ApplicationVersion
	{
		[Token(Token = "0x4000192")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public readonly int CurrentCode;

		[Token(Token = "0x4000193")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public readonly string CurrentName;

		[Token(Token = "0x4000194")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public readonly int LatestCode;

		[Token(Token = "0x4000195")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public readonly string LatestName;

		[Token(Token = "0x60005FD")]
		[Address(RVA = "0x1D4F56C", Offset = "0x1D4F56C", VA = "0x1D4F56C")]
		public ApplicationVersion(IntPtr o)
		{
		}
	}
	[Token(Token = "0x20000C5")]
	public class AssetDetails
	{
		[Token(Token = "0x4000196")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public readonly ulong AssetId;

		[Token(Token = "0x4000197")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public readonly string AssetType;

		[Token(Token = "0x4000198")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public readonly string DownloadStatus;

		[Token(Token = "0x4000199")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public readonly string Filepath;

		[Token(Token = "0x400019A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public readonly string IapStatus;

		[Token(Token = "0x400019B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public readonly LanguagePackInfo LanguageOptional;

		[Token(Token = "0x400019C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x1185B60", Offset = "0x1185B60")]
		public readonly LanguagePackInfo Language;

		[Token(Token = "0x60005FE")]
		[Address(RVA = "0x1D4F704", Offset = "0x1D4F704", VA = "0x1D4F704")]
		public AssetDetails(IntPtr o)
		{
		}
	}
	[Token(Token = "0x20000C6")]
	public class AssetDetailsList : DeserializableList<AssetDetails>
	{
		[Token(Token = "0x60005FF")]
		[Address(RVA = "0x1D4F904", Offset = "0x1D4F904", VA = "0x1D4F904")]
		public AssetDetailsList(IntPtr a)
		{
		}
	}
	[Token(Token = "0x20000C7")]
	public class AssetFileDeleteResult
	{
		[Token(Token = "0x400019D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public readonly ulong AssetFileId;

		[Token(Token = "0x400019E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public readonly ulong AssetId;

		[Token(Token = "0x400019F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public readonly string Filepath;

		[Token(Token = "0x40001A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public readonly bool Success;

		[Token(Token = "0x6000600")]
		[Address(RVA = "0x1D4FBB4", Offset = "0x1D4FBB4", VA = "0x1D4FBB4")]
		public AssetFileDeleteResult(IntPtr o)
		{
		}
	}
	[Token(Token = "0x20000C8")]
	public class AssetFileDownloadCancelResult
	{
		[Token(Token = "0x40001A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public readonly ulong AssetFileId;

		[Token(Token = "0x40001A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public readonly ulong AssetId;

		[Token(Token = "0x40001A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public readonly string Filepath;

		[Token(Token = "0x40001A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public readonly bool Success;

		[Token(Token = "0x6000601")]
		[Address(RVA = "0x1D4FD50", Offset = "0x1D4FD50", VA = "0x1D4FD50")]
		public AssetFileDownloadCancelResult(IntPtr o)
		{
		}
	}
	[Token(Token = "0x20000C9")]
	public class AssetFileDownloadResult
	{
		[Token(Token = "0x40001A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public readonly ulong AssetId;

		[Token(Token = "0x40001A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public readonly string Filepath;

		[Token(Token = "0x6000602")]
		[Address(RVA = "0x1D4FEEC", Offset = "0x1D4FEEC", VA = "0x1D4FEEC")]
		public AssetFileDownloadResult(IntPtr o)
		{
		}
	}
	[Token(Token = "0x20000CA")]
	public class AssetFileDownloadUpdate
	{
		[Token(Token = "0x40001A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public readonly ulong AssetFileId;

		[Token(Token = "0x40001A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public readonly ulong AssetId;

		[Token(Token = "0x40001A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public readonly uint BytesTotal;

		[Token(Token = "0x40001AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public readonly int BytesTransferred;

		[Token(Token = "0x40001AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public readonly bool Completed;

		[Token(Token = "0x6000603")]
		[Address(RVA = "0x1D50064", Offset = "0x1D50064", VA = "0x1D50064")]
		public AssetFileDownloadUpdate(IntPtr o)
		{
		}
	}
	[Token(Token = "0x20000CB")]
	public class CalApplicationFinalized
	{
		[Token(Token = "0x40001AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public readonly int CountdownMS;

		[Token(Token = "0x40001AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public readonly ulong ID;

		[Token(Token = "0x40001AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public readonly string LaunchDetails;

		[Token(Token = "0x6000604")]
		[Address(RVA = "0x1D50210", Offset = "0x1D50210", VA = "0x1D50210")]
		public CalApplicationFinalized(IntPtr o)
		{
		}
	}
	[Token(Token = "0x20000CC")]
	public class CalApplicationProposed
	{
		[Token(Token = "0x40001AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public readonly ulong ID;

		[Token(Token = "0x6000605")]
		[Address(RVA = "0x1D50398", Offset = "0x1D50398", VA = "0x1D50398")]
		public CalApplicationProposed(IntPtr o)
		{
		}
	}
	[Token(Token = "0x20000CD")]
	public class CalApplicationSuggestion
	{
		[Token(Token = "0x40001B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public readonly ulong ID;

		[Token(Token = "0x40001B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public readonly string SocialContext;

		[Token(Token = "0x6000606")]
		[Address(RVA = "0x1D56EE0", Offset = "0x1D56EE0", VA = "0x1D56EE0")]
		public CalApplicationSuggestion(IntPtr o)
		{
		}
	}
	[Token(Token = "0x20000CE")]
	public class CalApplicationSuggestionList : DeserializableList<CalApplicationSuggestion>
	{
		[Token(Token = "0x6000607")]
		[Address(RVA = "0x1D50560", Offset = "0x1D50560", VA = "0x1D50560")]
		public CalApplicationSuggestionList(IntPtr a)
		{
		}
	}
	[Token(Token = "0x20000CF")]
	public class CloudStorageConflictMetadata
	{
		[Token(Token = "0x40001B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public readonly CloudStorageMetadata Local;

		[Token(Token = "0x40001B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public readonly CloudStorageMetadata Remote;

		[Token(Token = "0x6000608")]
		[Address(RVA = "0x1D50810", Offset = "0x1D50810", VA = "0x1D50810")]
		public CloudStorageConflictMetadata(IntPtr o)
		{
		}
	}
	[Token(Token = "0x20000D0")]
	public class CloudStorageData
	{
		[Token(Token = "0x40001B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public readonly string Bucket;

		[Token(Token = "0x40001B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public readonly byte[] Data;

		[Token(Token = "0x40001B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public readonly uint DataSize;

		[Token(Token = "0x40001B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public readonly string Key;

		[Token(Token = "0x6000609")]
		[Address(RVA = "0x1D509D0", Offset = "0x1D509D0", VA = "0x1D509D0")]
		public CloudStorageData(IntPtr o)
		{
		}
	}
	[Token(Token = "0x20000D1")]
	public class CloudStorageMetadata
	{
		[Token(Token = "0x40001B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public readonly string Bucket;

		[Token(Token = "0x40001B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public readonly long Counter;

		[Token(Token = "0x40001BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public readonly uint DataSize;

		[Token(Token = "0x40001BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public readonly string ExtraData;

		[Token(Token = "0x40001BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public readonly string Key;

		[Token(Token = "0x40001BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public readonly ulong SaveTime;

		[Token(Token = "0x40001BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public readonly CloudStorageDataStatus Status;

		[Token(Token = "0x40001BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public readonly string VersionHandle;

		[Token(Token = "0x600060A")]
		[Address(RVA = "0x1D50E48", Offset = "0x1D50E48", VA = "0x1D50E48")]
		public CloudStorageMetadata(IntPtr o)
		{
		}
	}
	[Token(Token = "0x20000D2")]
	public class CloudStorageMetadataList : DeserializableList<CloudStorageMetadata>
	{
		[Token(Token = "0x600060B")]
		[Address(RVA = "0x1D50B68", Offset = "0x1D50B68", VA = "0x1D50B68")]
		public CloudStorageMetadataList(IntPtr a)
		{
		}
	}
	[Token(Token = "0x20000D3")]
	public class CloudStorageUpdateResponse
	{
		[Token(Token = "0x40001C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public readonly string Bucket;

		[Token(Token = "0x40001C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public readonly string Key;

		[Token(Token = "0x40001C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public readonly CloudStorageUpdateStatus Status;

		[Token(Token = "0x40001C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public readonly string VersionHandle;

		[Token(Token = "0x600060C")]
		[Address(RVA = "0x1D51020", Offset = "0x1D51020", VA = "0x1D51020")]
		public CloudStorageUpdateResponse(IntPtr o)
		{
		}
	}
	[Token(Token = "0x20000D4")]
	[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0x1182ADC", Offset = "0x1182ADC")]
	public class DeserializableList<T> : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable
	{
		[Token(Token = "0x40001C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		protected List<T> _Data;

		[Token(Token = "0x40001C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		protected string _NextUrl;

		[Token(Token = "0x40001C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		protected string _PreviousUrl;

		[Token(Token = "0x1700001B")]
		public int Count
		{
			[Token(Token = "0x600060D")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700001C")]
		private bool System.Collections.Generic.ICollection<T>.IsReadOnly
		{
			[Token(Token = "0x600060E")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700001D")]
		public T Item
		{
			[Token(Token = "0x6000610")]
			get
			{
				return (T)null;
			}
			[Token(Token = "0x6000611")]
			set
			{
			}
		}

		[Token(Token = "0x1700001E")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x1186D94", Offset = "0x1186D94")]
		public List<T> Data
		{
			[Token(Token = "0x600061C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700001F")]
		public bool HasNextPage
		{
			[Token(Token = "0x600061D")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000020")]
		public bool HasPreviousPage
		{
			[Token(Token = "0x600061E")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000021")]
		public string NextUrl
		{
			[Token(Token = "0x600061F")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000022")]
		public string PreviousUrl
		{
			[Token(Token = "0x6000620")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600060F")]
		public int IndexOf(T obj)
		{
			return default(int);
		}

		[Token(Token = "0x6000612")]
		public void Add(T item)
		{
		}

		[Token(Token = "0x6000613")]
		public void Clear()
		{
		}

		[Token(Token = "0x6000614")]
		public bool Contains(T item)
		{
			return default(bool);
		}

		[Token(Token = "0x6000615")]
		public void CopyTo(T[] array, int arrayIndex)
		{
		}

		[Token(Token = "0x6000616")]
		public IEnumerator<T> GetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x6000617")]
		public void Insert(int index, T item)
		{
		}

		[Token(Token = "0x6000618")]
		public bool Remove(T item)
		{
			return default(bool);
		}

		[Token(Token = "0x6000619")]
		public void RemoveAt(int index)
		{
		}

		[Token(Token = "0x600061A")]
		private IEnumerator GetEnumerator1()
		{
			return null;
		}

		[Token(Token = "0x600061B")]
		private IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x6000621")]
		public DeserializableList()
		{
		}
	}
	[Token(Token = "0x20000D5")]
	public class Error
	{
		[Token(Token = "0x40001C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public readonly int Code;

		[Token(Token = "0x40001C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public readonly int HttpCode;

		[Token(Token = "0x40001C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public readonly string Message;

		[Token(Token = "0x6000622")]
		[Address(RVA = "0x1D4B66C", Offset = "0x1D4B66C", VA = "0x1D4B66C")]
		public Error(int code, string message, int httpCode)
		{
		}
	}
	[Token(Token = "0x20000D6")]
	public class HttpTransferUpdate
	{
		[Token(Token = "0x40001CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public readonly ulong ID;

		[Token(Token = "0x40001CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public readonly byte[] Payload;

		[Token(Token = "0x40001CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public readonly bool IsCompleted;

		[Token(Token = "0x6000623")]
		[Address(RVA = "0x1D511B8", Offset = "0x1D511B8", VA = "0x1D511B8")]
		public HttpTransferUpdate(IntPtr o)
		{
		}
	}
	[Token(Token = "0x20000D7")]
	public class InstalledApplication
	{
		[Token(Token = "0x40001CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public readonly string ApplicationId;

		[Token(Token = "0x40001CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public readonly string PackageName;

		[Token(Token = "0x40001CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public readonly string Status;

		[Token(Token = "0x40001D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public readonly int VersionCode;

		[Token(Token = "0x40001D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public readonly string VersionName;

		[Token(Token = "0x6000624")]
		[Address(RVA = "0x1D56F78", Offset = "0x1D56F78", VA = "0x1D56F78")]
		public InstalledApplication(IntPtr o)
		{
		}
	}
	[Token(Token = "0x20000D8")]
	public class InstalledApplicationList : DeserializableList<InstalledApplication>
	{
		[Token(Token = "0x6000625")]
		[Address(RVA = "0x1D51440", Offset = "0x1D51440", VA = "0x1D51440")]
		public InstalledApplicationList(IntPtr a)
		{
		}
	}
	[Token(Token = "0x20000D9")]
	public class LanguagePackInfo
	{
		[Token(Token = "0x40001D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public readonly string EnglishName;

		[Token(Token = "0x40001D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public readonly string NativeName;

		[Token(Token = "0x40001D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public readonly string Tag;

		[Token(Token = "0x6000626")]
		[Address(RVA = "0x1D56E38", Offset = "0x1D56E38", VA = "0x1D56E38")]
		public LanguagePackInfo(IntPtr o)
		{
		}
	}
	[Token(Token = "0x20000DA")]
	public class LaunchBlockFlowResult
	{
		[Token(Token = "0x40001D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public readonly bool DidBlock;

		[Token(Token = "0x40001D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11")]
		public readonly bool DidCancel;

		[Token(Token = "0x6000627")]
		[Address(RVA = "0x1D51750", Offset = "0x1D51750", VA = "0x1D51750")]
		public LaunchBlockFlowResult(IntPtr o)
		{
		}
	}
	[Token(Token = "0x20000DB")]
	public class LaunchDetails
	{
		[Token(Token = "0x40001D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public readonly string DeeplinkMessage;

		[Token(Token = "0x40001D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public readonly string LaunchSource;

		[Token(Token = "0x40001D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public readonly LaunchType LaunchType;

		[Token(Token = "0x40001DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public readonly ulong RoomID;

		[Token(Token = "0x40001DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public readonly UserList UsersOptional;

		[Token(Token = "0x40001DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x1185B98", Offset = "0x1185B98")]
		public readonly UserList Users;

		[Token(Token = "0x6000628")]
		[Address(RVA = "0x1D57040", Offset = "0x1D57040", VA = "0x1D57040")]
		public LaunchDetails(IntPtr o)
		{
		}
	}
	[Token(Token = "0x20000DC")]
	public class LaunchFriendRequestFlowResult
	{
		[Token(Token = "0x40001DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public readonly bool DidCancel;

		[Token(Token = "0x40001DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11")]
		public readonly bool DidSendRequest;

		[Token(Token = "0x6000629")]
		[Address(RVA = "0x1D518D0", Offset = "0x1D518D0", VA = "0x1D518D0")]
		public LaunchFriendRequestFlowResult(IntPtr o)
		{
		}
	}
	[Token(Token = "0x20000DD")]
	public class LaunchReportFlowResult
	{
		[Token(Token = "0x40001DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public readonly bool DidCancel;

		[Token(Token = "0x40001E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public readonly ulong UserReportId;

		[Token(Token = "0x600062A")]
		[Address(RVA = "0x1D51AB0", Offset = "0x1D51AB0", VA = "0x1D51AB0")]
		public LaunchReportFlowResult(IntPtr o)
		{
		}
	}
	[Token(Token = "0x20000DE")]
	public class LaunchUnblockFlowResult
	{
		[Token(Token = "0x40001E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public readonly bool DidCancel;

		[Token(Token = "0x40001E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11")]
		public readonly bool DidUnblock;

		[Token(Token = "0x600062B")]
		[Address(RVA = "0x1D51C8C", Offset = "0x1D51C8C", VA = "0x1D51C8C")]
		public LaunchUnblockFlowResult(IntPtr o)
		{
		}
	}
	[Token(Token = "0x20000DF")]
	public class LeaderboardEntry
	{
		[Token(Token = "0x40001E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public readonly byte[] ExtraData;

		[Token(Token = "0x40001E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public readonly int Rank;

		[Token(Token = "0x40001E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public readonly long Score;

		[Token(Token = "0x40001E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public readonly DateTime Timestamp;

		[Token(Token = "0x40001E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public readonly User User;

		[Token(Token = "0x600062C")]
		[Address(RVA = "0x1D57150", Offset = "0x1D57150", VA = "0x1D57150")]
		public LeaderboardEntry(IntPtr o)
		{
		}
	}
	[Token(Token = "0x20000E0")]
	public class LeaderboardEntryList : DeserializableList<LeaderboardEntry>
	{
		[Token(Token = "0x40001E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public readonly ulong TotalCount;

		[Token(Token = "0x600062D")]
		[Address(RVA = "0x1D51EC8", Offset = "0x1D51EC8", VA = "0x1D51EC8")]
		public LeaderboardEntryList(IntPtr a)
		{
		}
	}
	[Token(Token = "0x20000E1")]
	public class LinkedAccount
	{
		[Token(Token = "0x40001E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public readonly string AccessToken;

		[Token(Token = "0x40001EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public readonly ServiceProvider ServiceProvider;

		[Token(Token = "0x40001EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public readonly string UserId;

		[Token(Token = "0x600062E")]
		[Address(RVA = "0x1D5723C", Offset = "0x1D5723C", VA = "0x1D5723C")]
		public LinkedAccount(IntPtr o)
		{
		}
	}
	[Token(Token = "0x20000E2")]
	public class LinkedAccountList : DeserializableList<LinkedAccount>
	{
		[Token(Token = "0x600062F")]
		[Address(RVA = "0x1D52228", Offset = "0x1D52228", VA = "0x1D52228")]
		public LinkedAccountList(IntPtr a)
		{
		}
	}
	[Token(Token = "0x20000E3")]
	public class LivestreamingApplicationStatus
	{
		[Token(Token = "0x40001EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public readonly bool StreamingEnabled;

		[Token(Token = "0x6000630")]
		[Address(RVA = "0x1D52538", Offset = "0x1D52538", VA = "0x1D52538")]
		public LivestreamingApplicationStatus(IntPtr o)
		{
		}
	}
	[Token(Token = "0x20000E4")]
	public class LivestreamingStartResult
	{
		[Token(Token = "0x40001ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public readonly LivestreamingStartStatus StreamingResult;

		[Token(Token = "0x6000631")]
		[Address(RVA = "0x1D52704", Offset = "0x1D52704", VA = "0x1D52704")]
		public LivestreamingStartResult(IntPtr o)
		{
		}
	}
	[Token(Token = "0x20000E5")]
	public class LivestreamingStatus
	{
		[Token(Token = "0x40001EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public readonly bool CommentsVisible;

		[Token(Token = "0x40001EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11")]
		public readonly bool IsPaused;

		[Token(Token = "0x40001F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x12")]
		public readonly bool LivestreamingEnabled;

		[Token(Token = "0x40001F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public readonly int LivestreamingType;

		[Token(Token = "0x40001F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public readonly bool MicEnabled;

		[Token(Token = "0x6000632")]
		[Address(RVA = "0x1D5286C", Offset = "0x1D5286C", VA = "0x1D5286C")]
		public LivestreamingStatus(IntPtr o)
		{
		}
	}
	[Token(Token = "0x20000E6")]
	public class LivestreamingVideoStats
	{
		[Token(Token = "0x40001F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public readonly int CommentCount;

		[Token(Token = "0x40001F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public readonly int ReactionCount;

		[Token(Token = "0x40001F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public readonly string TotalViews;

		[Token(Token = "0x6000633")]
		[Address(RVA = "0x1D52A84", Offset = "0x1D52A84", VA = "0x1D52A84")]
		public LivestreamingVideoStats(IntPtr o)
		{
		}
	}
	[Token(Token = "0x20000E7")]
	public class MatchmakingAdminSnapshot
	{
		[Token(Token = "0x40001F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public readonly MatchmakingAdminSnapshotCandidateList Candidates;

		[Token(Token = "0x40001F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public readonly double MyCurrentThreshold;

		[Token(Token = "0x6000634")]
		[Address(RVA = "0x1D52C0C", Offset = "0x1D52C0C", VA = "0x1D52C0C")]
		public MatchmakingAdminSnapshot(IntPtr o)
		{
		}
	}
	[Token(Token = "0x20000E8")]
	public class MatchmakingAdminSnapshotCandidate
	{
		[Token(Token = "0x40001F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public readonly bool CanMatch;

		[Token(Token = "0x40001F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public readonly double MyTotalScore;

		[Token(Token = "0x40001FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public readonly double TheirCurrentThreshold;

		[Token(Token = "0x40001FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public readonly double TheirTotalScore;

		[Token(Token = "0x40001FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public readonly string TraceId;

		[Token(Token = "0x6000635")]
		[Address(RVA = "0x1D574B4", Offset = "0x1D574B4", VA = "0x1D574B4")]
		public MatchmakingAdminSnapshotCandidate(IntPtr o)
		{
		}
	}
	[Token(Token = "0x20000E9")]
	public class MatchmakingAdminSnapshotCandidateList : DeserializableList<MatchmakingAdminSnapshotCandidate>
	{
		[Token(Token = "0x6000636")]
		[Address(RVA = "0x1D572E4", Offset = "0x1D572E4", VA = "0x1D572E4")]
		public MatchmakingAdminSnapshotCandidateList(IntPtr a)
		{
		}
	}
	[Token(Token = "0x20000EA")]
	public class MatchmakingBrowseResult
	{
		[Token(Token = "0x40001FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public readonly MatchmakingEnqueueResult EnqueueResult;

		[Token(Token = "0x40001FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public readonly RoomList Rooms;

		[Token(Token = "0x6000637")]
		[Address(RVA = "0x1D52E04", Offset = "0x1D52E04", VA = "0x1D52E04")]
		public MatchmakingBrowseResult(IntPtr o)
		{
		}
	}
	[Token(Token = "0x20000EB")]
	public class MatchmakingEnqueueResult
	{
		[Token(Token = "0x40001FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public readonly MatchmakingAdminSnapshot AdminSnapshotOptional;

		[Token(Token = "0x4000200")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x1185BD0", Offset = "0x1185BD0")]
		public readonly MatchmakingAdminSnapshot AdminSnapshot;

		[Token(Token = "0x4000201")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public readonly uint AverageWait;

		[Token(Token = "0x4000202")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public readonly uint MatchesInLastHourCount;

		[Token(Token = "0x4000203")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public readonly uint MaxExpectedWait;

		[Token(Token = "0x4000204")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public readonly string Pool;

		[Token(Token = "0x4000205")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public readonly uint RecentMatchPercentage;

		[Token(Token = "0x4000206")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public readonly string RequestHash;

		[Token(Token = "0x6000638")]
		[Address(RVA = "0x1D52FC4", Offset = "0x1D52FC4", VA = "0x1D52FC4")]
		public MatchmakingEnqueueResult(IntPtr o)
		{
		}
	}
	[Token(Token = "0x20000EC")]
	public class MatchmakingEnqueueResultAndRoom
	{
		[Token(Token = "0x4000207")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public readonly MatchmakingEnqueueResult MatchmakingEnqueueResult;

		[Token(Token = "0x4000208")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public readonly Room Room;

		[Token(Token = "0x6000639")]
		[Address(RVA = "0x1D531F4", Offset = "0x1D531F4", VA = "0x1D531F4")]
		public MatchmakingEnqueueResultAndRoom(IntPtr o)
		{
		}
	}
	[Token(Token = "0x20000ED")]
	public class MatchmakingEnqueuedUser
	{
		[Token(Token = "0x4000209")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public readonly Dictionary<string, string> CustomData;

		[Token(Token = "0x400020A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public readonly User UserOptional;

		[Token(Token = "0x400020B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x1185C08", Offset = "0x1185C08")]
		public readonly User User;

		[Token(Token = "0x600063A")]
		[Address(RVA = "0x1D57580", Offset = "0x1D57580", VA = "0x1D57580")]
		public MatchmakingEnqueuedUser(IntPtr o)
		{
		}
	}
	[Token(Token = "0x20000EE")]
	public class MatchmakingEnqueuedUserList : DeserializableList<MatchmakingEnqueuedUser>
	{
		[Token(Token = "0x600063B")]
		[Address(RVA = "0x1D57668", Offset = "0x1D57668", VA = "0x1D57668")]
		public MatchmakingEnqueuedUserList(IntPtr a)
		{
		}
	}
	[Token(Token = "0x20000EF")]
	public class MatchmakingStats
	{
		[Token(Token = "0x400020C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public readonly uint DrawCount;

		[Token(Token = "0x400020D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public readonly uint LossCount;

		[Token(Token = "0x400020E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public readonly uint SkillLevel;

		[Token(Token = "0x400020F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public readonly uint WinCount;

		[Token(Token = "0x600063C")]
		[Address(RVA = "0x1D53788", Offset = "0x1D53788", VA = "0x1D53788")]
		public MatchmakingStats(IntPtr o)
		{
		}
	}
	[Token(Token = "0x20000F0")]
	public class NetworkingPeer
	{
		[Token(Token = "0x4000210")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1185C40", Offset = "0x1185C40")]
		private ulong <ID>k__BackingField;

		[Token(Token = "0x4000211")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1185C50", Offset = "0x1185C50")]
		private PeerConnectionState <State>k__BackingField;

		[Token(Token = "0x17000023")]
		public ulong ID
		{
			[Token(Token = "0x600063E")]
			[Address(RVA = "0x1D57838", Offset = "0x1D57838", VA = "0x1D57838")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x11866B0", Offset = "0x11866B0")]
			get
			{
				return default(ulong);
			}
			[Token(Token = "0x600063F")]
			[Address(RVA = "0x1D57840", Offset = "0x1D57840", VA = "0x1D57840")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x11866C0", Offset = "0x11866C0")]
			private set
			{
			}
		}

		[Token(Token = "0x17000024")]
		public PeerConnectionState State
		{
			[Token(Token = "0x6000640")]
			[Address(RVA = "0x1D57848", Offset = "0x1D57848", VA = "0x1D57848")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x11866D0", Offset = "0x11866D0")]
			get
			{
				return default(PeerConnectionState);
			}
			[Token(Token = "0x6000641")]
			[Address(RVA = "0x1D57850", Offset = "0x1D57850", VA = "0x1D57850")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x11866E0", Offset = "0x11866E0")]
			private set
			{
			}
		}

		[Token(Token = "0x600063D")]
		[Address(RVA = "0x1D53944", Offset = "0x1D53944", VA = "0x1D53944")]
		public NetworkingPeer(ulong id, PeerConnectionState state)
		{
		}
	}
	[Token(Token = "0x20000F1")]
	public class OrgScopedID
	{
		[Token(Token = "0x4000212")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public readonly ulong ID;

		[Token(Token = "0x6000642")]
		[Address(RVA = "0x1D53A60", Offset = "0x1D53A60", VA = "0x1D53A60")]
		public OrgScopedID(IntPtr o)
		{
		}
	}
	[Token(Token = "0x20000F2")]
	public class Party
	{
		[Token(Token = "0x4000213")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public readonly ulong ID;

		[Token(Token = "0x4000214")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public readonly UserList InvitedUsersOptional;

		[Token(Token = "0x4000215")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x1185C60", Offset = "0x1185C60")]
		public readonly UserList InvitedUsers;

		[Token(Token = "0x4000216")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public readonly User LeaderOptional;

		[Token(Token = "0x4000217")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x1185C98", Offset = "0x1185C98")]
		public readonly User Leader;

		[Token(Token = "0x4000218")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public readonly Room RoomOptional;

		[Token(Token = "0x4000219")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x1185CD0", Offset = "0x1185CD0")]
		public readonly Room Room;

		[Token(Token = "0x400021A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public readonly UserList UsersOptional;

		[Token(Token = "0x400021B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x1185D08", Offset = "0x1185D08")]
		public readonly UserList Users;

		[Token(Token = "0x6000643")]
		[Address(RVA = "0x1D53C28", Offset = "0x1D53C28", VA = "0x1D53C28")]
		public Party(IntPtr o)
		{
		}
	}
	[Token(Token = "0x20000F3")]
	public class PartyID
	{
		[Token(Token = "0x400021C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public readonly ulong ID;

		[Token(Token = "0x6000644")]
		[Address(RVA = "0x1D53F98", Offset = "0x1D53F98", VA = "0x1D53F98")]
		public PartyID(IntPtr o)
		{
		}
	}
	[Token(Token = "0x20000F4")]
	public class PartyUpdateNotification
	{
		[Token(Token = "0x400021D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public readonly PartyUpdateAction Action;

		[Token(Token = "0x400021E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public readonly ulong PartyId;

		[Token(Token = "0x400021F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public readonly ulong SenderId;

		[Token(Token = "0x4000220")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public readonly string UpdateTimestamp;

		[Token(Token = "0x4000221")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public readonly string UserAlias;

		[Token(Token = "0x4000222")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public readonly ulong UserId;

		[Token(Token = "0x4000223")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public readonly string UserName;

		[Token(Token = "0x6000645")]
		[Address(RVA = "0x1D541E0", Offset = "0x1D541E0", VA = "0x1D541E0")]
		public PartyUpdateNotification(IntPtr o)
		{
		}
	}
	[Token(Token = "0x20000F5")]
	public class Pid
	{
		[Token(Token = "0x4000224")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public readonly string Id;

		[Token(Token = "0x6000646")]
		[Address(RVA = "0x1D57858", Offset = "0x1D57858", VA = "0x1D57858")]
		public Pid(IntPtr o)
		{
		}
	}
	[Token(Token = "0x20000F6")]
	public class PidList : DeserializableList<Pid>
	{
		[Token(Token = "0x6000647")]
		[Address(RVA = "0x1D543A8", Offset = "0x1D543A8", VA = "0x1D543A8")]
		public PidList(IntPtr a)
		{
		}
	}
	[Token(Token = "0x20000F7")]
	public class PingResult
	{
		[Token(Token = "0x4000225")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1185D40", Offset = "0x1185D40")]
		private ulong <ID>k__BackingField;

		[Token(Token = "0x4000226")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private ulong? pingTimeUsec;

		[Token(Token = "0x17000025")]
		public ulong ID
		{
			[Token(Token = "0x6000649")]
			[Address(RVA = "0x1D578E0", Offset = "0x1D578E0", VA = "0x1D578E0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x11866F0", Offset = "0x11866F0")]
			get
			{
				return default(ulong);
			}
			[Token(Token = "0x600064A")]
			[Address(RVA = "0x1D578E8", Offset = "0x1D578E8", VA = "0x1D578E8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1186700", Offset = "0x1186700")]
			private set
			{
			}
		}

		[Token(Token = "0x17000026")]
		public ulong PingTimeUsec
		{
			[Token(Token = "0x600064B")]
			[Address(RVA = "0x1D578F0", Offset = "0x1D578F0", VA = "0x1D578F0")]
			get
			{
				return default(ulong);
			}
		}

		[Token(Token = "0x17000027")]
		public bool IsTimeout
		{
			[Token(Token = "0x600064C")]
			[Address(RVA = "0x1D57958", Offset = "0x1D57958", VA = "0x1D57958")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000648")]
		[Address(RVA = "0x1D546D8", Offset = "0x1D546D8", VA = "0x1D546D8")]
		public PingResult(ulong id, ulong? pingTimeUsec)
		{
		}
	}
	[Token(Token = "0x20000F8")]
	public class PlatformInitialize
	{
		[Token(Token = "0x4000227")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public readonly PlatformInitializeResult Result;

		[Token(Token = "0x600064D")]
		[Address(RVA = "0x1D547F8", Offset = "0x1D547F8", VA = "0x1D547F8")]
		public PlatformInitialize(IntPtr o)
		{
		}
	}
	[Token(Token = "0x20000F9")]
	public class Product
	{
		[Token(Token = "0x4000228")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public readonly string Description;

		[Token(Token = "0x4000229")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public readonly string FormattedPrice;

		[Token(Token = "0x400022A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public readonly string Name;

		[Token(Token = "0x400022B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public readonly string Sku;

		[Token(Token = "0x600064E")]
		[Address(RVA = "0x1D579A4", Offset = "0x1D579A4", VA = "0x1D579A4")]
		public Product(IntPtr o)
		{
		}
	}
	[Token(Token = "0x20000FA")]
	public class ProductList : DeserializableList<Product>
	{
		[Token(Token = "0x600064F")]
		[Address(RVA = "0x1D54960", Offset = "0x1D54960", VA = "0x1D54960")]
		public ProductList(IntPtr a)
		{
		}
	}
	[Token(Token = "0x20000FB")]
	public class Purchase
	{
		[Token(Token = "0x400022C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public readonly DateTime ExpirationTime;

		[Token(Token = "0x400022D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public readonly DateTime GrantTime;

		[Token(Token = "0x400022E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public readonly ulong ID;

		[Token(Token = "0x400022F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public readonly string Sku;

		[Token(Token = "0x6000650")]
		[Address(RVA = "0x1D54C40", Offset = "0x1D54C40", VA = "0x1D54C40")]
		public Purchase(IntPtr o)
		{
		}
	}
	[Token(Token = "0x20000FC")]
	public class PurchaseList : DeserializableList<Purchase>
	{
		[Token(Token = "0x6000651")]
		[Address(RVA = "0x1D54DD8", Offset = "0x1D54DD8", VA = "0x1D54DD8")]
		public PurchaseList(IntPtr a)
		{
		}
	}
	[Token(Token = "0x20000FD")]
	public class Room
	{
		[Token(Token = "0x4000230")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public readonly ulong ApplicationID;

		[Token(Token = "0x4000231")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public readonly Dictionary<string, string> DataStore;

		[Token(Token = "0x4000232")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public readonly string Description;

		[Token(Token = "0x4000233")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public readonly ulong ID;

		[Token(Token = "0x4000234")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public readonly UserList InvitedUsersOptional;

		[Token(Token = "0x4000235")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x1185D50", Offset = "0x1185D50")]
		public readonly UserList InvitedUsers;

		[Token(Token = "0x4000236")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public readonly bool IsMembershipLocked;

		[Token(Token = "0x4000237")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public readonly RoomJoinPolicy JoinPolicy;

		[Token(Token = "0x4000238")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public readonly RoomJoinability Joinability;

		[Token(Token = "0x4000239")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public readonly MatchmakingEnqueuedUserList MatchedUsersOptional;

		[Token(Token = "0x400023A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x1185D88", Offset = "0x1185D88")]
		public readonly MatchmakingEnqueuedUserList MatchedUsers;

		[Token(Token = "0x400023B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public readonly uint MaxUsers;

		[Token(Token = "0x400023C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public readonly string Name;

		[Token(Token = "0x400023D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public readonly User OwnerOptional;

		[Token(Token = "0x400023E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x1185DC0", Offset = "0x1185DC0")]
		public readonly User Owner;

		[Token(Token = "0x400023F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public readonly RoomType Type;

		[Token(Token = "0x4000240")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public readonly UserList UsersOptional;

		[Token(Token = "0x4000241")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x1185DF8", Offset = "0x1185DF8")]
		public readonly UserList Users;

		[Token(Token = "0x4000242")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public readonly uint Version;

		[Token(Token = "0x6000652")]
		[Address(RVA = "0x1D533B4", Offset = "0x1D533B4", VA = "0x1D533B4")]
		public Room(IntPtr o)
		{
		}
	}
	[Token(Token = "0x20000FE")]
	public class RoomList : DeserializableList<Room>
	{
		[Token(Token = "0x6000653")]
		[Address(RVA = "0x1D55610", Offset = "0x1D55610", VA = "0x1D55610")]
		public RoomList(IntPtr a)
		{
		}
	}
	[Token(Token = "0x20000FF")]
	public class RoomInviteNotification
	{
		[Token(Token = "0x4000243")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public readonly ulong ID;

		[Token(Token = "0x4000244")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public readonly ulong RoomID;

		[Token(Token = "0x4000245")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public readonly ulong SenderID;

		[Token(Token = "0x4000246")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public readonly DateTime SentTime;

		[Token(Token = "0x6000654")]
		[Address(RVA = "0x1D55198", Offset = "0x1D55198", VA = "0x1D55198")]
		public RoomInviteNotification(IntPtr o)
		{
		}
	}
	[Token(Token = "0x2000100")]
	public class RoomInviteNotificationList : DeserializableList<RoomInviteNotification>
	{
		[Token(Token = "0x6000655")]
		[Address(RVA = "0x1D55330", Offset = "0x1D55330", VA = "0x1D55330")]
		public RoomInviteNotificationList(IntPtr a)
		{
		}
	}
	[Token(Token = "0x2000101")]
	public class SdkAccount
	{
		[Token(Token = "0x4000247")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public readonly SdkAccountType AccountType;

		[Token(Token = "0x4000248")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public readonly ulong UserId;

		[Token(Token = "0x6000656")]
		[Address(RVA = "0x1D57A5C", Offset = "0x1D57A5C", VA = "0x1D57A5C")]
		public SdkAccount(IntPtr o)
		{
		}
	}
	[Token(Token = "0x2000102")]
	public class SdkAccountList : DeserializableList<SdkAccount>
	{
		[Token(Token = "0x6000657")]
		[Address(RVA = "0x1D55AB0", Offset = "0x1D55AB0", VA = "0x1D55AB0")]
		public SdkAccountList(IntPtr a)
		{
		}
	}
	[Token(Token = "0x2000103")]
	public class ShareMediaResult
	{
		[Token(Token = "0x4000249")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public readonly ShareMediaStatus Status;

		[Token(Token = "0x6000658")]
		[Address(RVA = "0x1D55D60", Offset = "0x1D55D60", VA = "0x1D55D60")]
		public ShareMediaResult(IntPtr o)
		{
		}
	}
	[Token(Token = "0x2000104")]
	public class SystemPermission
	{
		[Token(Token = "0x400024A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public readonly bool HasPermission;

		[Token(Token = "0x400024B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public readonly PermissionGrantStatus PermissionGrantStatus;

		[Token(Token = "0x6000659")]
		[Address(RVA = "0x1D55FD4", Offset = "0x1D55FD4", VA = "0x1D55FD4")]
		public SystemPermission(IntPtr o)
		{
		}
	}
	[Token(Token = "0x2000105")]
	public class SystemVoipState
	{
		[Token(Token = "0x400024C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public readonly VoipMuteState MicrophoneMuted;

		[Token(Token = "0x400024D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public readonly SystemVoipStatus Status;

		[Token(Token = "0x600065A")]
		[Address(RVA = "0x1D56150", Offset = "0x1D56150", VA = "0x1D56150")]
		public SystemVoipState(IntPtr o)
		{
		}
	}
	[Token(Token = "0x2000106")]
	public class User
	{
		[Token(Token = "0x400024E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public readonly ulong ID;

		[Token(Token = "0x400024F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public readonly string ImageURL;

		[Token(Token = "0x4000250")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public readonly string InviteToken;

		[Token(Token = "0x4000251")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public readonly string OculusID;

		[Token(Token = "0x4000252")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public readonly string Presence;

		[Token(Token = "0x4000253")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public readonly UserPresenceStatus PresenceStatus;

		[Token(Token = "0x4000254")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public readonly string SmallImageUrl;

		[Token(Token = "0x600065B")]
		[Address(RVA = "0x1D562C8", Offset = "0x1D562C8", VA = "0x1D562C8")]
		public User(IntPtr o)
		{
		}
	}
	[Token(Token = "0x2000107")]
	public class UserList : DeserializableList<User>
	{
		[Token(Token = "0x600065C")]
		[Address(RVA = "0x1D56770", Offset = "0x1D56770", VA = "0x1D56770")]
		public UserList(IntPtr a)
		{
		}
	}
	[Token(Token = "0x2000108")]
	public class UserAndRoom
	{
		[Token(Token = "0x4000255")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public readonly Room RoomOptional;

		[Token(Token = "0x4000256")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x1185E30", Offset = "0x1185E30")]
		public readonly Room Room;

		[Token(Token = "0x4000257")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public readonly User User;

		[Token(Token = "0x600065D")]
		[Address(RVA = "0x1D57AF4", Offset = "0x1D57AF4", VA = "0x1D57AF4")]
		public UserAndRoom(IntPtr o)
		{
		}
	}
	[Token(Token = "0x2000109")]
	public class UserAndRoomList : DeserializableList<UserAndRoom>
	{
		[Token(Token = "0x600065E")]
		[Address(RVA = "0x1D56490", Offset = "0x1D56490", VA = "0x1D56490")]
		public UserAndRoomList(IntPtr a)
		{
		}
	}
	[Token(Token = "0x200010A")]
	public class UserProof
	{
		[Token(Token = "0x4000258")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public readonly string Value;

		[Token(Token = "0x600065F")]
		[Address(RVA = "0x1D56A50", Offset = "0x1D56A50", VA = "0x1D56A50")]
		public UserProof(IntPtr o)
		{
		}
	}
	[Token(Token = "0x200010B")]
	public class UserReportID
	{
		[Token(Token = "0x4000259")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public readonly bool DidCancel;

		[Token(Token = "0x400025A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public readonly ulong ID;

		[Token(Token = "0x6000660")]
		[Address(RVA = "0x1D56C18", Offset = "0x1D56C18", VA = "0x1D56C18")]
		public UserReportID(IntPtr o)
		{
		}
	}
}
namespace Oculus.Platform.Samples.VrVoiceChat
{
	[Token(Token = "0x200010C")]
	public class P2PManager
	{
		[Token(Token = "0x400025B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly float UPDATE_DELAY;

		[Token(Token = "0x400025C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private ulong m_remoteID;

		[Token(Token = "0x400025D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private PeerConnectionState m_state;

		[Token(Token = "0x400025E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private float m_timeForNextUpdate;

		[Token(Token = "0x400025F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		private static readonly byte PACKET_SIZE;

		[Token(Token = "0x4000260")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5")]
		private static readonly byte PACKET_FORMAT;

		[Token(Token = "0x4000261")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private readonly byte[] sendTransformBuffer;

		[Token(Token = "0x4000262")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private readonly byte[] receiveTransformBuffer;

		[Token(Token = "0x4000263")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Vector3 receivedPosition;

		[Token(Token = "0x4000264")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private Vector3 receivedPositionPrior;

		[Token(Token = "0x4000265")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Quaternion receivedRotation;

		[Token(Token = "0x4000266")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Quaternion receivedRotationPrior;

		[Token(Token = "0x4000267")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private float receivedTime;

		[Token(Token = "0x17000028")]
		public bool Connected
		{
			[Token(Token = "0x6000664")]
			[Address(RVA = "0x1F91A90", Offset = "0x1F91A90", VA = "0x1F91A90")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000029")]
		public bool ShouldSendHeadUpdate
		{
			[Token(Token = "0x6000667")]
			[Address(RVA = "0x1F92048", Offset = "0x1F92048", VA = "0x1F92048")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000661")]
		[Address(RVA = "0x1F91798", Offset = "0x1F91798", VA = "0x1F91798")]
		public P2PManager(Transform initialHeadTransform)
		{
		}

		[Token(Token = "0x6000662")]
		[Address(RVA = "0x1F918F0", Offset = "0x1F918F0", VA = "0x1F918F0")]
		public void ConnectTo(ulong userID)
		{
		}

		[Token(Token = "0x6000663")]
		[Address(RVA = "0x1F91A5C", Offset = "0x1F91A5C", VA = "0x1F91A5C")]
		public void Disconnect()
		{
		}

		[Token(Token = "0x6000665")]
		[Address(RVA = "0x1F91AA0", Offset = "0x1F91AA0", VA = "0x1F91AA0")]
		private void PeerConnectRequestCallback(Message<NetworkingPeer> msg)
		{
		}

		[Token(Token = "0x6000666")]
		[Address(RVA = "0x1F91C1C", Offset = "0x1F91C1C", VA = "0x1F91C1C")]
		private void ConnectionStateChangedCallback(Message<NetworkingPeer> msg)
		{
		}

		[Token(Token = "0x6000668")]
		[Address(RVA = "0x1F9208C", Offset = "0x1F9208C", VA = "0x1F9208C")]
		public void SendHeadTransform(Transform headTransform)
		{
		}

		[Token(Token = "0x6000669")]
		[Address(RVA = "0x1F92234", Offset = "0x1F92234", VA = "0x1F92234")]
		private void PackFloat(float f, byte[] buf, ref int offset)
		{
		}

		[Token(Token = "0x600066A")]
		[Address(RVA = "0x1F922DC", Offset = "0x1F922DC", VA = "0x1F922DC")]
		public void GetRemoteHeadTransform(Transform headTransform)
		{
		}
	}
	[Token(Token = "0x200010D")]
	public class PlatformManager : MonoBehaviour
	{
		[Token(Token = "0x2000180")]
		public enum State
		{
			[Token(Token = "0x400061D")]
			INITIALIZING,
			[Token(Token = "0x400061E")]
			WAITING_TO_CALL_OR_ANSWER,
			[Token(Token = "0x400061F")]
			WAITING_FOR_ANSWER,
			[Token(Token = "0x4000620")]
			CONNECTED_IN_A_ROOM,
			[Token(Token = "0x4000621")]
			HANGUP
		}

		[Token(Token = "0x2000181")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x118349C", Offset = "0x118349C")]
		private sealed class <>c__DisplayClass31_0
		{
			[Token(Token = "0x4000622")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RoomManager.Invite invite;

			[Token(Token = "0x60009AA")]
			[Address(RVA = "0x1F94184", Offset = "0x1F94184", VA = "0x1F94184")]
			public <>c__DisplayClass31_0()
			{
			}

			[Token(Token = "0x60009AB")]
			[Address(RVA = "0x1F94198", Offset = "0x1F94198", VA = "0x1F94198")]
			internal void <SetActiveInvites>b__0()
			{
			}
		}

		[Token(Token = "0x4000268")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject m_invitesList;

		[Token(Token = "0x4000269")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject m_invitePrefab;

		[Token(Token = "0x400026A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Camera m_camera;

		[Token(Token = "0x400026B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject m_remoteHead;

		[Token(Token = "0x400026C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private State m_currentState;

		[Token(Token = "0x400026D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static PlatformManager s_instance;

		[Token(Token = "0x400026E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private RoomManager m_roomManager;

		[Token(Token = "0x400026F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private P2PManager m_p2pManager;

		[Token(Token = "0x4000270")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private VoipManager m_voipManager;

		[Token(Token = "0x4000271")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private ulong m_myID;

		[Token(Token = "0x4000272")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private string m_myOculusID;

		[Token(Token = "0x1700002A")]
		public static State CurrentState
		{
			[Token(Token = "0x6000673")]
			[Address(RVA = "0x1F93550", Offset = "0x1F93550", VA = "0x1F93550")]
			get
			{
				return default(State);
			}
		}

		[Token(Token = "0x1700002B")]
		public static ulong MyID
		{
			[Token(Token = "0x6000674")]
			[Address(RVA = "0x1F91984", Offset = "0x1F91984", VA = "0x1F91984")]
			get
			{
				return default(ulong);
			}
		}

		[Token(Token = "0x1700002C")]
		public static string MyOculusID
		{
			[Token(Token = "0x6000675")]
			[Address(RVA = "0x1F935C4", Offset = "0x1F935C4", VA = "0x1F935C4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600066C")]
		[Address(RVA = "0x1F92770", Offset = "0x1F92770", VA = "0x1F92770")]
		private void Update()
		{
		}

		[Token(Token = "0x600066D")]
		[Address(RVA = "0x1F929AC", Offset = "0x1F929AC", VA = "0x1F929AC")]
		private void Awake()
		{
		}

		[Token(Token = "0x600066E")]
		[Address(RVA = "0x1F93080", Offset = "0x1F93080", VA = "0x1F93080")]
		private void Start()
		{
		}

		[Token(Token = "0x600066F")]
		[Address(RVA = "0x1F93118", Offset = "0x1F93118", VA = "0x1F93118")]
		private void IsEntitledCallback(Message msg)
		{
		}

		[Token(Token = "0x6000670")]
		[Address(RVA = "0x1F932B4", Offset = "0x1F932B4", VA = "0x1F932B4")]
		private void GetLoggedInUserCallback(Message<User> msg)
		{
		}

		[Token(Token = "0x6000671")]
		[Address(RVA = "0x1F933DC", Offset = "0x1F933DC", VA = "0x1F933DC")]
		private void OnApplicationQuit()
		{
		}

		[Token(Token = "0x6000672")]
		[Address(RVA = "0x1F93208", Offset = "0x1F93208", VA = "0x1F93208")]
		public static void TerminateWithError(Message msg)
		{
		}

		[Token(Token = "0x6000676")]
		[Address(RVA = "0x1F936D8", Offset = "0x1F936D8", VA = "0x1F936D8")]
		public void CallFriendOnClick()
		{
		}

		[Token(Token = "0x6000677")]
		[Address(RVA = "0x1F93810", Offset = "0x1F93810", VA = "0x1F93810")]
		public void HangupOnClick()
		{
		}

		[Token(Token = "0x6000678")]
		[Address(RVA = "0x1F93828", Offset = "0x1F93828", VA = "0x1F93828")]
		public void QuitOnClick()
		{
		}

		[Token(Token = "0x6000679")]
		[Address(RVA = "0x1F93830", Offset = "0x1F93830", VA = "0x1F93830")]
		public static void AnswerCallOnClick(ulong roomID)
		{
		}

		[Token(Token = "0x600067A")]
		[Address(RVA = "0x1F92BA8", Offset = "0x1F92BA8", VA = "0x1F92BA8")]
		public static void TransitionToState(State newState)
		{
		}

		[Token(Token = "0x600067B")]
		[Address(RVA = "0x1F91E08", Offset = "0x1F91E08", VA = "0x1F91E08")]
		public static void SetBackgroundColorForState()
		{
		}

		[Token(Token = "0x600067C")]
		[Address(RVA = "0x1F93ABC", Offset = "0x1F93ABC", VA = "0x1F93ABC")]
		public static void SetActiveInvites(List<RoomManager.Invite> invites)
		{
		}

		[Token(Token = "0x600067D")]
		[Address(RVA = "0x1F9418C", Offset = "0x1F9418C", VA = "0x1F9418C")]
		public PlatformManager()
		{
		}
	}
	[Token(Token = "0x200010E")]
	public class RoomManager
	{
		[Token(Token = "0x2000182")]
		public struct Invite
		{
			[Token(Token = "0x4000623")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public readonly ulong RoomID;

			[Token(Token = "0x4000624")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public readonly string OwnerID;

			[Token(Token = "0x60009AC")]
			[Address(RVA = "0x133F6DC", Offset = "0x133F6DC", VA = "0x133F6DC")]
			public Invite(ulong roomID, string owner)
			{
			}
		}

		[Token(Token = "0x4000273")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private ulong m_roomID;

		[Token(Token = "0x4000274")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private User m_remoteUser;

		[Token(Token = "0x4000275")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly float INVITE_POLL_FREQ_SECONDS;

		[Token(Token = "0x4000276")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private float m_nextPollTime;

		[Token(Token = "0x4000277")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private HashSet<ulong> m_pendingRoomRequests;

		[Token(Token = "0x4000278")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private List<Invite> m_invites;

		[Token(Token = "0x1700002D")]
		public ulong RemoteUserID
		{
			[Token(Token = "0x6000680")]
			[Address(RVA = "0x1F939D4", Offset = "0x1F939D4", VA = "0x1F939D4")]
			get
			{
				return default(ulong);
			}
		}

		[Token(Token = "0x1700002E")]
		public string RemoteOculusID
		{
			[Token(Token = "0x6000681")]
			[Address(RVA = "0x1F94200", Offset = "0x1F94200", VA = "0x1F94200")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700002F")]
		public bool ShouldPollInviteList
		{
			[Token(Token = "0x6000687")]
			[Address(RVA = "0x1F9282C", Offset = "0x1F9282C", VA = "0x1F9282C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600067F")]
		[Address(RVA = "0x1F92EF8", Offset = "0x1F92EF8", VA = "0x1F92EF8")]
		public RoomManager()
		{
		}

		[Token(Token = "0x6000682")]
		[Address(RVA = "0x1F94264", Offset = "0x1F94264", VA = "0x1F94264")]
		private void LaunchedFromAcceptingInviteCallback(Message<string> msg)
		{
		}

		[Token(Token = "0x6000683")]
		[Address(RVA = "0x1F933B4", Offset = "0x1F933B4", VA = "0x1F933B4")]
		public bool CheckForLaunchInvite()
		{
			return default(bool);
		}

		[Token(Token = "0x6000684")]
		[Address(RVA = "0x1F9375C", Offset = "0x1F9375C", VA = "0x1F9375C")]
		public void CreateRoomAndLaunchInviteMenu()
		{
		}

		[Token(Token = "0x6000685")]
		[Address(RVA = "0x1F94394", Offset = "0x1F94394", VA = "0x1F94394")]
		private void CreateAndJoinPrivateRoomCallback(Message<Room> msg)
		{
		}

		[Token(Token = "0x6000686")]
		[Address(RVA = "0x1F944B4", Offset = "0x1F944B4", VA = "0x1F944B4")]
		private void OnLaunchInviteWorkflowComplete(Message msg)
		{
		}

		[Token(Token = "0x6000688")]
		[Address(RVA = "0x1F9286C", Offset = "0x1F9286C", VA = "0x1F9286C")]
		public void UpdateActiveInvitesList()
		{
		}

		[Token(Token = "0x6000689")]
		[Address(RVA = "0x1F9453C", Offset = "0x1F9453C", VA = "0x1F9453C")]
		private void GetRoomInviteNotificationsCallback(Message msg_untyped)
		{
		}

		[Token(Token = "0x600068A")]
		[Address(RVA = "0x1F948FC", Offset = "0x1F948FC", VA = "0x1F948FC")]
		private void GetRoomInfoCallback(Message<Room> msg)
		{
		}

		[Token(Token = "0x600068B")]
		[Address(RVA = "0x1F93920", Offset = "0x1F93920", VA = "0x1F93920")]
		public void JoinExistingRoom(ulong roomID)
		{
		}

		[Token(Token = "0x600068C")]
		[Address(RVA = "0x1F94A80", Offset = "0x1F94A80", VA = "0x1F94A80")]
		private void JoinRoomCallback(Message<Room> msg)
		{
		}

		[Token(Token = "0x600068D")]
		[Address(RVA = "0x1F94EF4", Offset = "0x1F94EF4", VA = "0x1F94EF4")]
		private void RoomUpdateCallback(Message<Room> msg)
		{
		}

		[Token(Token = "0x600068E")]
		[Address(RVA = "0x1F93430", Offset = "0x1F93430", VA = "0x1F93430")]
		public void LeaveCurrentRoom()
		{
		}
	}
	[Token(Token = "0x200010F")]
	public class VREyeRaycaster : MonoBehaviour
	{
		[Token(Token = "0x4000279")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private EventSystem m_eventSystem;

		[Token(Token = "0x400027A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Button m_currentButton;

		[Token(Token = "0x6000690")]
		[Address(RVA = "0x1F953E0", Offset = "0x1F953E0", VA = "0x1F953E0")]
		private void Update()
		{
		}

		[Token(Token = "0x6000691")]
		[Address(RVA = "0x1F955E0", Offset = "0x1F955E0", VA = "0x1F955E0")]
		public VREyeRaycaster()
		{
		}
	}
	[Token(Token = "0x2000110")]
	public class VoipManager
	{
		[Token(Token = "0x400027B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private ulong m_remoteID;

		[Token(Token = "0x400027C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private PeerConnectionState m_state;

		[Token(Token = "0x400027D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private readonly GameObject m_remoteHead;

		[Token(Token = "0x17000030")]
		public bool Connected
		{
			[Token(Token = "0x6000695")]
			[Address(RVA = "0x1F93AAC", Offset = "0x1F93AAC", VA = "0x1F93AAC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000692")]
		[Address(RVA = "0x1F92FC0", Offset = "0x1F92FC0", VA = "0x1F92FC0")]
		public VoipManager(GameObject remoteHead)
		{
		}

		[Token(Token = "0x6000693")]
		[Address(RVA = "0x1F939EC", Offset = "0x1F939EC", VA = "0x1F939EC")]
		public void ConnectTo(ulong userID)
		{
		}

		[Token(Token = "0x6000694")]
		[Address(RVA = "0x1F934A8", Offset = "0x1F934A8", VA = "0x1F934A8")]
		public void Disconnect()
		{
		}

		[Token(Token = "0x6000696")]
		[Address(RVA = "0x1F958B0", Offset = "0x1F958B0", VA = "0x1F958B0")]
		private void VoipConnectRequestCallback(Message<NetworkingPeer> msg)
		{
		}

		[Token(Token = "0x6000697")]
		[Address(RVA = "0x1F95B14", Offset = "0x1F95B14", VA = "0x1F95B14")]
		private void VoipStateChangedCallback(Message<NetworkingPeer> msg)
		{
		}
	}
}
namespace Oculus.Platform.Samples.VrHoops
{
	[Token(Token = "0x2000111")]
	public class AIPlayer : Player
	{
		[Token(Token = "0x6000698")]
		[Address(RVA = "0x1F87D58", Offset = "0x1F87D58", VA = "0x1F87D58")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000699")]
		[Address(RVA = "0x1F88034", Offset = "0x1F88034", VA = "0x1F88034")]
		public AIPlayer()
		{
		}
	}
	[Token(Token = "0x2000112")]
	public class AchievementsManager
	{
		[Token(Token = "0x400027E")]
		private const string LIKES_TO_WIN = "LIKES_TO_WIN";

		[Token(Token = "0x400027F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private bool m_likesToWinUnlocked;

		[Token(Token = "0x17000031")]
		public bool LikesToWin
		{
			[Token(Token = "0x600069A")]
			[Address(RVA = "0x1F880A8", Offset = "0x1F880A8", VA = "0x1F880A8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600069B")]
		[Address(RVA = "0x1F880B0", Offset = "0x1F880B0", VA = "0x1F880B0")]
		public void CheckForAchievmentUpdates()
		{
		}

		[Token(Token = "0x600069C")]
		[Address(RVA = "0x1F881C0", Offset = "0x1F881C0", VA = "0x1F881C0")]
		public void RecordWinForLocalUser()
		{
		}

		[Token(Token = "0x600069D")]
		[Address(RVA = "0x1F8821C", Offset = "0x1F8821C", VA = "0x1F8821C")]
		public AchievementsManager()
		{
		}

		[Token(Token = "0x600069E")]
		[Address(RVA = "0x1F88224", Offset = "0x1F88224", VA = "0x1F88224")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1186710", Offset = "0x1186710")]
		private void <CheckForAchievmentUpdates>b__4_0(Message<AchievementProgressList> msg)
		{
		}
	}
	[Token(Token = "0x2000113")]
	public class BallEjector : MonoBehaviour
	{
		[Token(Token = "0x600069F")]
		[Address(RVA = "0x1F8845C", Offset = "0x1F8845C", VA = "0x1F8845C")]
		public BallEjector()
		{
		}
	}
	[Token(Token = "0x2000114")]
	public class Camera2DController : MonoBehaviour
	{
		[Token(Token = "0x60006A0")]
		[Address(RVA = "0x1F88464", Offset = "0x1F88464", VA = "0x1F88464")]
		private void Update()
		{
		}

		[Token(Token = "0x60006A1")]
		[Address(RVA = "0x1F886D8", Offset = "0x1F886D8", VA = "0x1F886D8")]
		public Camera2DController()
		{
		}
	}
	[Token(Token = "0x2000115")]
	public class DetectBasket : MonoBehaviour
	{
		[Token(Token = "0x2000183")]
		private enum BasketPhase
		{
			[Token(Token = "0x4000626")]
			NONE,
			[Token(Token = "0x4000627")]
			TOP,
			[Token(Token = "0x4000628")]
			BOTH,
			[Token(Token = "0x4000629")]
			BOTTOM
		}

		[Token(Token = "0x4000280")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private BasketPhase m_phase;

		[Token(Token = "0x4000281")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Player m_owningPlayer;

		[Token(Token = "0x17000032")]
		public Player Player
		{
			[Token(Token = "0x60006A2")]
			[Address(RVA = "0x1F886E0", Offset = "0x1F886E0", VA = "0x1F886E0")]
			set
			{
			}
		}

		[Token(Token = "0x60006A3")]
		[Address(RVA = "0x1F886E8", Offset = "0x1F886E8", VA = "0x1F886E8")]
		private void OnTriggerEnter(Collider other)
		{
		}

		[Token(Token = "0x60006A4")]
		[Address(RVA = "0x1F887C8", Offset = "0x1F887C8", VA = "0x1F887C8")]
		private void OnTriggerExit(Collider other)
		{
		}

		[Token(Token = "0x60006A5")]
		[Address(RVA = "0x1F88980", Offset = "0x1F88980", VA = "0x1F88980")]
		public DetectBasket()
		{
		}
	}
	[Token(Token = "0x2000116")]
	public class FlyText : MonoBehaviour
	{
		[Token(Token = "0x4000282")]
		private const float LIFESPAN = 3f;

		[Token(Token = "0x4000283")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private readonly Vector3 m_movePerFrame;

		[Token(Token = "0x4000284")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private float m_eol;

		[Token(Token = "0x60006A6")]
		[Address(RVA = "0x1F88988", Offset = "0x1F88988", VA = "0x1F88988")]
		private void Start()
		{
		}

		[Token(Token = "0x60006A7")]
		[Address(RVA = "0x1F88A24", Offset = "0x1F88A24", VA = "0x1F88A24")]
		private void Update()
		{
		}

		[Token(Token = "0x60006A8")]
		[Address(RVA = "0x1F88B60", Offset = "0x1F88B60", VA = "0x1F88B60")]
		public FlyText()
		{
		}
	}
	[Token(Token = "0x2000117")]
	public class GoalMover : MonoBehaviour
	{
		[Token(Token = "0x4000285")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private float MAX_OFFSET;

		[Token(Token = "0x4000286")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private float m_speed;

		[Token(Token = "0x4000287")]
		private const float MOVE_TOLERANCE = 0.1f;

		[Token(Token = "0x4000288")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Vector3 m_expectedPosition;

		[Token(Token = "0x4000289")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private Vector3 m_moveDirection;

		[Token(Token = "0x400028A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Vector3 m_nextMoveDirection;

		[Token(Token = "0x17000033")]
		public Vector3 ExpectedPosition
		{
			[Token(Token = "0x60006A9")]
			[Address(RVA = "0x1F88BFC", Offset = "0x1F88BFC", VA = "0x1F88BFC")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60006AA")]
			[Address(RVA = "0x1F88C08", Offset = "0x1F88C08", VA = "0x1F88C08")]
			set
			{
			}
		}

		[Token(Token = "0x17000034")]
		public Vector3 MoveDirection
		{
			[Token(Token = "0x60006AB")]
			[Address(RVA = "0x1F88C14", Offset = "0x1F88C14", VA = "0x1F88C14")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60006AC")]
			[Address(RVA = "0x1F88C20", Offset = "0x1F88C20", VA = "0x1F88C20")]
			set
			{
			}
		}

		[Token(Token = "0x17000035")]
		public Vector3 NextMoveDirection
		{
			[Token(Token = "0x60006AD")]
			[Address(RVA = "0x1F88C2C", Offset = "0x1F88C2C", VA = "0x1F88C2C")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60006AE")]
			[Address(RVA = "0x1F88C38", Offset = "0x1F88C38", VA = "0x1F88C38")]
			set
			{
			}
		}

		[Token(Token = "0x60006AF")]
		[Address(RVA = "0x1F88C44", Offset = "0x1F88C44", VA = "0x1F88C44")]
		private void Start()
		{
		}

		[Token(Token = "0x60006B0")]
		[Address(RVA = "0x1F88DD4", Offset = "0x1F88DD4", VA = "0x1F88DD4")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60006B1")]
		[Address(RVA = "0x1F89100", Offset = "0x1F89100", VA = "0x1F89100")]
		public GoalMover()
		{
		}
	}
	[Token(Token = "0x2000118")]
	public class LeaderboardManager
	{
		[Token(Token = "0x2000184")]
		public delegate void OnMostWinsLeaderboardUpdated(SortedDictionary<int, LeaderboardEntry> entries);

		[Token(Token = "0x2000185")]
		public delegate void OnHighScoreLeaderboardUpdated(SortedDictionary<int, LeaderboardEntry> entries);

		[Token(Token = "0x400028B")]
		private const string MOST_MATCHES_WON = "MOST_MATCHES_WON";

		[Token(Token = "0x400028C")]
		private const string HIGHEST_MATCH_SCORE = "HIGHEST_MATCH_SCORE";

		[Token(Token = "0x400028D")]
		private const int TOP_N_COUNT = 5;

		[Token(Token = "0x400028E")]
		private const float LEADERBOARD_POLL_FREQ = 30f;

		[Token(Token = "0x400028F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private float m_nextCheckTime;

		[Token(Token = "0x4000290")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private SortedDictionary<int, LeaderboardEntry> m_mostWins;

		[Token(Token = "0x4000291")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private bool m_foundLocalUserMostWinsEntry;

		[Token(Token = "0x4000292")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private long m_numWins;

		[Token(Token = "0x4000293")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private OnMostWinsLeaderboardUpdated m_mostWinsCallback;

		[Token(Token = "0x4000294")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private SortedDictionary<int, LeaderboardEntry> m_highScores;

		[Token(Token = "0x4000295")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private bool m_foundLocalUserHighScore;

		[Token(Token = "0x4000296")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private OnHighScoreLeaderboardUpdated m_highScoreCallback;

		[Token(Token = "0x17000036")]
		public OnMostWinsLeaderboardUpdated MostWinsLeaderboardUpdatedCallback
		{
			[Token(Token = "0x60006B3")]
			[Address(RVA = "0x1F89394", Offset = "0x1F89394", VA = "0x1F89394")]
			set
			{
			}
		}

		[Token(Token = "0x17000037")]
		public OnHighScoreLeaderboardUpdated HighScoreLeaderboardUpdatedCallback
		{
			[Token(Token = "0x60006B6")]
			[Address(RVA = "0x1F89B58", Offset = "0x1F89B58", VA = "0x1F89B58")]
			set
			{
			}
		}

		[Token(Token = "0x60006B2")]
		[Address(RVA = "0x1F89114", Offset = "0x1F89114", VA = "0x1F89114")]
		public void CheckForUpdates()
		{
		}

		[Token(Token = "0x60006B4")]
		[Address(RVA = "0x1F8917C", Offset = "0x1F8917C", VA = "0x1F8917C")]
		private void QueryMostWinsLeaderboard()
		{
		}

		[Token(Token = "0x60006B5")]
		[Address(RVA = "0x1F8939C", Offset = "0x1F8939C", VA = "0x1F8939C")]
		private void MostWinsGetEntriesCallback(Message<LeaderboardEntryList> msg)
		{
		}

		[Token(Token = "0x60006B7")]
		[Address(RVA = "0x1F89288", Offset = "0x1F89288", VA = "0x1F89288")]
		private void QueryHighScoreLeaderboard()
		{
		}

		[Token(Token = "0x60006B8")]
		[Address(RVA = "0x1F89B60", Offset = "0x1F89B60", VA = "0x1F89B60")]
		private void HighestScoreGetEntriesCallback(Message<LeaderboardEntryList> msg)
		{
		}

		[Token(Token = "0x60006B9")]
		[Address(RVA = "0x1F8A270", Offset = "0x1F8A270", VA = "0x1F8A270")]
		public void SubmitMatchScores(bool wonMatch, uint score)
		{
		}

		[Token(Token = "0x60006BA")]
		[Address(RVA = "0x1F8A324", Offset = "0x1F8A324", VA = "0x1F8A324")]
		public LeaderboardManager()
		{
		}
	}
	[Token(Token = "0x2000119")]
	public class LocalPlayer : Player
	{
		[Token(Token = "0x17000038")]
		public override uint Score
		{
			[Token(Token = "0x60006BB")]
			[Address(RVA = "0x1F8A3AC", Offset = "0x1F8A3AC", VA = "0x1F8A3AC", Slot = "5")]
			set
			{
			}
		}

		[Token(Token = "0x60006BC")]
		[Address(RVA = "0x1F8A68C", Offset = "0x1F8A68C", VA = "0x1F8A68C")]
		private void Update()
		{
		}

		[Token(Token = "0x60006BD")]
		[Address(RVA = "0x1F8A80C", Offset = "0x1F8A80C", VA = "0x1F8A80C")]
		public LocalPlayer()
		{
		}
	}
	[Token(Token = "0x200011A")]
	public class MatchController : MonoBehaviour
	{
		[Token(Token = "0x2000186")]
		private enum State
		{
			[Token(Token = "0x400062B")]
			UNKNOWN,
			[Token(Token = "0x400062C")]
			NONE,
			[Token(Token = "0x400062D")]
			WAITING_TO_START_PRACTICE,
			[Token(Token = "0x400062E")]
			PRACTICING,
			[Token(Token = "0x400062F")]
			VIEWING_RESULTS_PRACTICE,
			[Token(Token = "0x4000630")]
			WAITING_FOR_MATCH,
			[Token(Token = "0x4000631")]
			WAITING_TO_SETUP_MATCH,
			[Token(Token = "0x4000632")]
			PLAYING_MATCH,
			[Token(Token = "0x4000633")]
			VIEWING_MATCH_RESULTS
		}

		[Token(Token = "0x4000297")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text m_timerText;

		[Token(Token = "0x4000298")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Camera m_camera;

		[Token(Token = "0x4000299")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Transform m_idleCameraTransform;

		[Token(Token = "0x400029A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text m_matchmakeButtonText;

		[Token(Token = "0x400029B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private PlayerArea[] m_playerAreas;

		[Token(Token = "0x400029C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private uint PRACTICE_WARMUP_TIME;

		[Token(Token = "0x400029D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[SerializeField]
		private uint MATCH_WARMUP_TIME;

		[Token(Token = "0x400029E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private uint MATCH_TIME;

		[Token(Token = "0x400029F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[SerializeField]
		private uint MATCH_COOLDOWN_TIME;

		[Token(Token = "0x40002A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject m_mostWinsLeaderboard;

		[Token(Token = "0x40002A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject m_highestScoresLeaderboard;

		[Token(Token = "0x40002A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		private GameObject m_leaderboardEntryPrefab;

		[Token(Token = "0x40002A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private GameObject m_flytext;

		[Token(Token = "0x40002A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private State m_currentState;

		[Token(Token = "0x40002A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private float m_nextStateTransitionTime;

		[Token(Token = "0x40002A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private int m_localSlot;

		[Token(Token = "0x17000039")]
		public float MatchStartTime
		{
			[Token(Token = "0x60006C0")]
			[Address(RVA = "0x1F8B000", Offset = "0x1F8B000", VA = "0x1F8B000")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60006C1")]
			[Address(RVA = "0x1F8B020", Offset = "0x1F8B020", VA = "0x1F8B020")]
			private set
			{
			}
		}

		[Token(Token = "0x60006BE")]
		[Address(RVA = "0x1F8A810", Offset = "0x1F8A810", VA = "0x1F8A810")]
		private void Start()
		{
		}

		[Token(Token = "0x60006BF")]
		[Address(RVA = "0x1F8AD38", Offset = "0x1F8AD38", VA = "0x1F8AD38")]
		private void Update()
		{
		}

		[Token(Token = "0x60006C2")]
		[Address(RVA = "0x1F8AA70", Offset = "0x1F8AA70", VA = "0x1F8AA70")]
		private void TransitionToState(State newState)
		{
		}

		[Token(Token = "0x60006C3")]
		[Address(RVA = "0x1F8AD5C", Offset = "0x1F8AD5C", VA = "0x1F8AD5C")]
		private void UpdateCheckForNextTimedTransition()
		{
		}

		[Token(Token = "0x60006C4")]
		[Address(RVA = "0x1F8AE00", Offset = "0x1F8AE00", VA = "0x1F8AE00")]
		private void UpdateMatchTimer()
		{
		}

		[Token(Token = "0x60006C5")]
		[Address(RVA = "0x1F8B028", Offset = "0x1F8B028", VA = "0x1F8B028")]
		private void SetupForIdle()
		{
		}

		[Token(Token = "0x60006C6")]
		[Address(RVA = "0x1F8B29C", Offset = "0x1F8B29C", VA = "0x1F8B29C")]
		private void SetupForPractice()
		{
		}

		[Token(Token = "0x60006C7")]
		[Address(RVA = "0x1F8B964", Offset = "0x1F8B964", VA = "0x1F8B964")]
		private Player MatchPlayerAddedCallback(int slot, User user)
		{
			return null;
		}

		[Token(Token = "0x60006C8")]
		[Address(RVA = "0x1F8B0D4", Offset = "0x1F8B0D4", VA = "0x1F8B0D4")]
		private void MoveCameraToIdlePosition()
		{
		}

		[Token(Token = "0x60006C9")]
		[Address(RVA = "0x1F8B39C", Offset = "0x1F8B39C", VA = "0x1F8B39C")]
		private void MoveCameraToMatchPosition()
		{
		}

		[Token(Token = "0x60006CA")]
		[Address(RVA = "0x1F8BC08", Offset = "0x1F8BC08", VA = "0x1F8BC08")]
		public void StartPracticeMatch()
		{
		}

		[Token(Token = "0x60006CB")]
		[Address(RVA = "0x1F8BC20", Offset = "0x1F8BC20", VA = "0x1F8BC20")]
		public void PlayOnlineOrCancel()
		{
		}

		[Token(Token = "0x60006CC")]
		[Address(RVA = "0x1F8BDD0", Offset = "0x1F8BDD0", VA = "0x1F8BDD0")]
		private void OnMatchFoundCallback(bool success)
		{
		}

		[Token(Token = "0x60006CD")]
		[Address(RVA = "0x1F8BDE4", Offset = "0x1F8BDE4", VA = "0x1F8BDE4")]
		private float StartTimeOfferCallback(float remoteTime)
		{
			return default(float);
		}

		[Token(Token = "0x60006CE")]
		[Address(RVA = "0x1F8BEE8", Offset = "0x1F8BEE8", VA = "0x1F8BEE8")]
		private void MostWinsLeaderboardCallback(SortedDictionary<int, LeaderboardEntry> entries)
		{
		}

		[Token(Token = "0x60006CF")]
		[Address(RVA = "0x1F8C438", Offset = "0x1F8C438", VA = "0x1F8C438")]
		private void HighestScoreLeaderboardCallback(SortedDictionary<int, LeaderboardEntry> entries)
		{
		}

		[Token(Token = "0x60006D0")]
		[Address(RVA = "0x1F8B520", Offset = "0x1F8B520", VA = "0x1F8B520")]
		private void CalculateMatchResults()
		{
		}

		[Token(Token = "0x60006D1")]
		[Address(RVA = "0x1F8BA6C", Offset = "0x1F8BA6C", VA = "0x1F8BA6C")]
		private void DisplayAchievementFlytext()
		{
		}

		[Token(Token = "0x60006D2")]
		[Address(RVA = "0x1F8CA3C", Offset = "0x1F8CA3C", VA = "0x1F8CA3C")]
		public MatchController()
		{
		}
	}
	[Token(Token = "0x200011B")]
	public class MatchmakingManager
	{
		[Token(Token = "0x2000187")]
		public delegate void OnEnqueueResult(bool successful);

		[Token(Token = "0x2000188")]
		public delegate Player OnMatchPlayerAdded(int slot, User user);

		[Token(Token = "0x40002A7")]
		private const string NORMAL_POOL = "NORMAL_QUICKMATCH";

		[Token(Token = "0x40002A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private ulong m_matchRoom;

		[Token(Token = "0x40002A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private readonly Dictionary<ulong, User> m_remotePlayers;

		[Token(Token = "0x40002AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private OnEnqueueResult m_enqueueCallback;

		[Token(Token = "0x40002AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private OnMatchPlayerAdded m_playerCallback;

		[Token(Token = "0x1700003A")]
		public OnEnqueueResult EnqueueResultCallback
		{
			[Token(Token = "0x60006D4")]
			[Address(RVA = "0x1F8CB90", Offset = "0x1F8CB90", VA = "0x1F8CB90")]
			private get
			{
				return null;
			}
			[Token(Token = "0x60006D5")]
			[Address(RVA = "0x1F8CB98", Offset = "0x1F8CB98", VA = "0x1F8CB98")]
			set
			{
			}
		}

		[Token(Token = "0x1700003B")]
		public OnMatchPlayerAdded MatchPlayerAddedCallback
		{
			[Token(Token = "0x60006D6")]
			[Address(RVA = "0x1F8CBA0", Offset = "0x1F8CBA0", VA = "0x1F8CBA0")]
			private get
			{
				return null;
			}
			[Token(Token = "0x60006D7")]
			[Address(RVA = "0x1F8CBA8", Offset = "0x1F8CBA8", VA = "0x1F8CBA8")]
			set
			{
			}
		}

		[Token(Token = "0x60006D3")]
		[Address(RVA = "0x1F8CAA8", Offset = "0x1F8CAA8", VA = "0x1F8CAA8")]
		public MatchmakingManager()
		{
		}

		[Token(Token = "0x60006D8")]
		[Address(RVA = "0x1F8BCF0", Offset = "0x1F8BCF0", VA = "0x1F8BCF0")]
		public void QueueForMatch()
		{
		}

		[Token(Token = "0x60006D9")]
		[Address(RVA = "0x1F8CBB0", Offset = "0x1F8CBB0", VA = "0x1F8CBB0")]
		private void MatchmakingEnqueueCallback(Message msg)
		{
		}

		[Token(Token = "0x60006DA")]
		[Address(RVA = "0x1F8CEE8", Offset = "0x1F8CEE8", VA = "0x1F8CEE8")]
		private void MatchFoundCallback(Message<Room> msg)
		{
		}

		[Token(Token = "0x60006DB")]
		[Address(RVA = "0x1F8CFB8", Offset = "0x1F8CFB8", VA = "0x1F8CFB8")]
		private void MatchmakingJoinRoomCallback(Message<Room> msg)
		{
		}

		[Token(Token = "0x60006DC")]
		[Address(RVA = "0x1F8D7D4", Offset = "0x1F8D7D4", VA = "0x1F8D7D4")]
		private void MatchmakingRoomUpdateCallback(Message<Room> msg)
		{
		}

		[Token(Token = "0x60006DD")]
		[Address(RVA = "0x1F8B834", Offset = "0x1F8B834", VA = "0x1F8B834")]
		public void EndMatch()
		{
		}

		[Token(Token = "0x60006DE")]
		[Address(RVA = "0x1F8BDA8", Offset = "0x1F8BDA8", VA = "0x1F8BDA8")]
		public void LeaveQueue()
		{
		}
	}
	[Token(Token = "0x200011C")]
	public class P2PManager
	{
		[Token(Token = "0x2000189")]
		private class RemotePlayerData
		{
			[Token(Token = "0x4000634")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public PeerConnectionState state;

			[Token(Token = "0x4000635")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public RemotePlayer player;

			[Token(Token = "0x4000636")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float remoteTimeOffset;

			[Token(Token = "0x4000637")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			public float lastReceivedBallsTime;

			[Token(Token = "0x4000638")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public readonly Dictionary<int, P2PNetworkBall> activeBalls;

			[Token(Token = "0x60009BD")]
			[Address(RVA = "0x1F8F02C", Offset = "0x1F8F02C", VA = "0x1F8F02C")]
			public RemotePlayerData()
			{
			}
		}

		[Token(Token = "0x200018A")]
		public delegate float StartTimeOffer(float remoteTime);

		[Token(Token = "0x40002AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly Dictionary<ulong, RemotePlayerData> m_remotePlayers;

		[Token(Token = "0x40002AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private float m_timeForNextBallUpdate;

		[Token(Token = "0x40002AE")]
		private const byte TIME_SYNC_MESSAGE = 1;

		[Token(Token = "0x40002AF")]
		private const uint TIME_SYNC_MESSAGE_SIZE = 5u;

		[Token(Token = "0x40002B0")]
		private const int TIME_SYNC_MESSAGE_COUNT = 7;

		[Token(Token = "0x40002B1")]
		private const byte START_TIME_MESSAGE = 2;

		[Token(Token = "0x40002B2")]
		private const uint START_TIME_MESSAGE_SIZE = 5u;

		[Token(Token = "0x40002B3")]
		private const byte BACKBOARD_UPDATE_MESSAGE = 3;

		[Token(Token = "0x40002B4")]
		private const uint BACKBOARD_UPDATE_MESSAGE_SIZE = 41u;

		[Token(Token = "0x40002B5")]
		private const byte LOCAL_BALLS_UPDATE_MESSAGE = 4;

		[Token(Token = "0x40002B6")]
		private const uint LOCAL_BALLS_UPDATE_MESSATE_SIZE_MAX = 353u;

		[Token(Token = "0x40002B7")]
		private const float LOCAL_BALLS_UPDATE_DELAY = 0.1f;

		[Token(Token = "0x40002B8")]
		private const byte SCORE_UPDATE_MESSAGE = 5;

		[Token(Token = "0x40002B9")]
		private const uint SCORE_UPDATE_MESSAGE_SIZE = 5u;

		[Token(Token = "0x40002BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private readonly Dictionary<int, P2PNetworkBall> m_localBalls;

		[Token(Token = "0x40002BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private readonly byte[] readBuffer;

		[Token(Token = "0x40002BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private readonly Dictionary<ulong, List<float>> m_remoteSyncTimeCache;

		[Token(Token = "0x40002BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private readonly Dictionary<ulong, float> m_remoteSentTimeCache;

		[Token(Token = "0x40002BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private StartTimeOffer m_startTimeOfferCallback;

		[Token(Token = "0x1700003C")]
		public StartTimeOffer StartTimeOfferCallback
		{
			[Token(Token = "0x60006E8")]
			[Address(RVA = "0x1F8F998", Offset = "0x1F8F998", VA = "0x1F8F998")]
			private get
			{
				return null;
			}
			[Token(Token = "0x60006E9")]
			[Address(RVA = "0x1F8F9A0", Offset = "0x1F8F9A0", VA = "0x1F8F9A0")]
			set
			{
			}
		}

		[Token(Token = "0x60006DF")]
		[Address(RVA = "0x1F8DE50", Offset = "0x1F8DE50", VA = "0x1F8DE50")]
		public P2PManager()
		{
		}

		[Token(Token = "0x60006E0")]
		[Address(RVA = "0x1F8DFC8", Offset = "0x1F8DFC8", VA = "0x1F8DFC8")]
		public void UpdateNetwork()
		{
		}

		[Token(Token = "0x60006E1")]
		[Address(RVA = "0x1F8D624", Offset = "0x1F8D624", VA = "0x1F8D624")]
		public void AddRemotePlayer(RemotePlayer player)
		{
		}

		[Token(Token = "0x60006E2")]
		[Address(RVA = "0x1F8DBF8", Offset = "0x1F8DBF8", VA = "0x1F8DBF8")]
		public void DisconnectAll()
		{
		}

		[Token(Token = "0x60006E3")]
		[Address(RVA = "0x1F8F09C", Offset = "0x1F8F09C", VA = "0x1F8F09C")]
		private void PeerConnectRequestCallback(Message<NetworkingPeer> msg)
		{
		}

		[Token(Token = "0x60006E4")]
		[Address(RVA = "0x1F8F264", Offset = "0x1F8F264", VA = "0x1F8F264")]
		private void ConnectionStateChangedCallback(Message<NetworkingPeer> msg)
		{
		}

		[Token(Token = "0x60006E5")]
		[Address(RVA = "0x1F8F4B4", Offset = "0x1F8F4B4", VA = "0x1F8F4B4")]
		private void SendTimeSyncMessage(ulong remoteID)
		{
		}

		[Token(Token = "0x60006E6")]
		[Address(RVA = "0x1F8E1C4", Offset = "0x1F8E1C4", VA = "0x1F8E1C4")]
		private void ReadTimeSyncMessage(ulong remoteID, byte[] msg)
		{
		}

		[Token(Token = "0x60006E7")]
		[Address(RVA = "0x1F8F8F0", Offset = "0x1F8F8F0", VA = "0x1F8F8F0")]
		private float ShiftRemoteTime(ulong remoteID, float remoteTime)
		{
			return default(float);
		}

		[Token(Token = "0x60006EA")]
		[Address(RVA = "0x1F8F734", Offset = "0x1F8F734", VA = "0x1F8F734")]
		private void OfferMatchStartTime()
		{
		}

		[Token(Token = "0x60006EB")]
		[Address(RVA = "0x1F8E768", Offset = "0x1F8E768", VA = "0x1F8E768")]
		private void ReceiveMatchStartTimeOffer(ulong remoteID, byte[] msg)
		{
		}

		[Token(Token = "0x60006EC")]
		[Address(RVA = "0x1F8FC44", Offset = "0x1F8FC44", VA = "0x1F8FC44")]
		public void SendBackboardUpdate(float time, Vector3 pos, Vector3 moveDir, Vector3 nextMoveDir)
		{
		}

		[Token(Token = "0x60006ED")]
		[Address(RVA = "0x1F8E7C4", Offset = "0x1F8E7C4", VA = "0x1F8E7C4")]
		private void ReceiveBackboardUpdate(ulong remoteID, byte[] msg)
		{
		}

		[Token(Token = "0x60006EE")]
		[Address(RVA = "0x1F8A774", Offset = "0x1F8A774", VA = "0x1F8A774")]
		public void AddNetworkBall(GameObject ball)
		{
		}

		[Token(Token = "0x60006EF")]
		[Address(RVA = "0x1F900AC", Offset = "0x1F900AC", VA = "0x1F900AC")]
		public void RemoveNetworkBall(GameObject ball)
		{
		}

		[Token(Token = "0x60006F0")]
		[Address(RVA = "0x1F8ECDC", Offset = "0x1F8ECDC", VA = "0x1F8ECDC")]
		private void SendLocalBallTransforms()
		{
		}

		[Token(Token = "0x60006F1")]
		[Address(RVA = "0x1F8E900", Offset = "0x1F8E900", VA = "0x1F8E900")]
		private void ReceiveBallTransforms(ulong remoteID, byte[] msg, ulong msgLength)
		{
		}

		[Token(Token = "0x60006F2")]
		[Address(RVA = "0x1F8A514", Offset = "0x1F8A514", VA = "0x1F8A514")]
		public void SendScoreUpdate(uint score)
		{
		}

		[Token(Token = "0x60006F3")]
		[Address(RVA = "0x1F8EC34", Offset = "0x1F8EC34", VA = "0x1F8EC34")]
		private void ReceiveScoredUpdate(ulong remoteID, byte[] msg)
		{
		}

		[Token(Token = "0x60006F4")]
		[Address(RVA = "0x1F8FE3C", Offset = "0x1F8FE3C", VA = "0x1F8FE3C")]
		private void PackVector3(Vector3 vec, byte[] buf, ref int offset)
		{
		}

		[Token(Token = "0x60006F5")]
		[Address(RVA = "0x1F8FE8C", Offset = "0x1F8FE8C", VA = "0x1F8FE8C")]
		private Vector3 UnpackVector3(byte[] buf, ref int offset)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60006F6")]
		[Address(RVA = "0x1F907AC", Offset = "0x1F907AC", VA = "0x1F907AC")]
		private void PackQuaternion(Quaternion quat, byte[] buf, ref int offset)
		{
		}

		[Token(Token = "0x60006F7")]
		[Address(RVA = "0x1F8F600", Offset = "0x1F8F600", VA = "0x1F8F600")]
		private void PackFloat(float value, byte[] buf, ref int offset)
		{
		}

		[Token(Token = "0x60006F8")]
		[Address(RVA = "0x1F8F6A8", Offset = "0x1F8F6A8", VA = "0x1F8F6A8")]
		private float UnpackFloat(byte[] buf, ref int offset)
		{
			return default(float);
		}

		[Token(Token = "0x60006F9")]
		[Address(RVA = "0x1F8FC10", Offset = "0x1F8FC10", VA = "0x1F8FC10")]
		private float UnpackTime(ulong remoteID, byte[] buf, ref int offset)
		{
			return default(float);
		}

		[Token(Token = "0x60006FA")]
		[Address(RVA = "0x1F9019C", Offset = "0x1F9019C", VA = "0x1F9019C")]
		private void PackInt32(int value, byte[] buf, ref int offset)
		{
		}

		[Token(Token = "0x60006FB")]
		[Address(RVA = "0x1F902A4", Offset = "0x1F902A4", VA = "0x1F902A4")]
		private int UnpackInt32(byte[] buf, ref int offset)
		{
			return default(int);
		}

		[Token(Token = "0x60006FC")]
		[Address(RVA = "0x1F9067C", Offset = "0x1F9067C", VA = "0x1F9067C")]
		private void PackUint32(uint value, byte[] buf, ref int offset)
		{
		}

		[Token(Token = "0x60006FD")]
		[Address(RVA = "0x1F9071C", Offset = "0x1F9071C", VA = "0x1F9071C")]
		private uint UnpackUint32(byte[] buf, ref int offset)
		{
			return default(uint);
		}

		[Token(Token = "0x60006FE")]
		[Address(RVA = "0x1F90154", Offset = "0x1F90154", VA = "0x1F90154")]
		private void PackBool(bool value, byte[] buf, ref int offset)
		{
		}

		[Token(Token = "0x60006FF")]
		[Address(RVA = "0x1F90258", Offset = "0x1F90258", VA = "0x1F90258")]
		private bool UnpackBool(byte[] buf, ref int offset)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x200011D")]
	public class P2PNetworkBall : MonoBehaviour
	{
		[Token(Token = "0x40002BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private float lastCollisionTime;

		[Token(Token = "0x40002C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Rigidbody rigidBody;

		[Token(Token = "0x1700003D")]
		public Vector3 velocity
		{
			[Token(Token = "0x6000701")]
			[Address(RVA = "0x1F9023C", Offset = "0x1F9023C", VA = "0x1F9023C")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x6000700")]
		[Address(RVA = "0x1F908D0", Offset = "0x1F908D0", VA = "0x1F908D0")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000702")]
		[Address(RVA = "0x1F90128", Offset = "0x1F90128", VA = "0x1F90128")]
		public bool IsHeld()
		{
			return default(bool);
		}

		[Token(Token = "0x6000703")]
		[Address(RVA = "0x1F90510", Offset = "0x1F90510", VA = "0x1F90510")]
		public void ProcessRemoteUpdate(float remoteTime, bool isHeld, Vector3 pos, Vector3 vel)
		{
		}

		[Token(Token = "0x6000704")]
		[Address(RVA = "0x1F90938", Offset = "0x1F90938", VA = "0x1F90938")]
		private Vector3 estimatePosition(Vector3 startPosition, Vector3 startVelocty, float time)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000705")]
		[Address(RVA = "0x1F90A74", Offset = "0x1F90A74", VA = "0x1F90A74")]
		private Vector3 estimateVelocity(Vector3 startVelocity, float time)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000706")]
		[Address(RVA = "0x1F90BBC", Offset = "0x1F90BBC", VA = "0x1F90BBC")]
		private void OnCollisionEnter(Collision collision)
		{
		}

		[Token(Token = "0x6000707")]
		[Address(RVA = "0x1F90BE4", Offset = "0x1F90BE4", VA = "0x1F90BE4")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000708")]
		[Address(RVA = "0x1F90C24", Offset = "0x1F90C24", VA = "0x1F90C24")]
		public P2PNetworkBall()
		{
		}
	}
	[Token(Token = "0x200011E")]
	public class P2PNetworkGoal : MonoBehaviour
	{
		[Token(Token = "0x40002C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private GoalMover m_goal;

		[Token(Token = "0x40002C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Vector3 m_lastSentMoveDirection;

		[Token(Token = "0x40002C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private bool m_sendUpdates;

		[Token(Token = "0x1700003E")]
		public bool SendUpdates
		{
			[Token(Token = "0x6000709")]
			[Address(RVA = "0x1F90C2C", Offset = "0x1F90C2C", VA = "0x1F90C2C")]
			set
			{
			}
		}

		[Token(Token = "0x600070A")]
		[Address(RVA = "0x1F90C38", Offset = "0x1F90C38", VA = "0x1F90C38")]
		private void Awake()
		{
		}

		[Token(Token = "0x600070B")]
		[Address(RVA = "0x1F90CA0", Offset = "0x1F90CA0", VA = "0x1F90CA0")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x600070C")]
		[Address(RVA = "0x1F90D7C", Offset = "0x1F90D7C", VA = "0x1F90D7C")]
		public void SendBackboardUpdate()
		{
		}

		[Token(Token = "0x600070D")]
		[Address(RVA = "0x1F8FEE4", Offset = "0x1F8FEE4", VA = "0x1F8FEE4")]
		public void RemoteBackboardUpdate(float remoteTime, Vector3 pos, Vector3 moveDir, Vector3 nextMoveDir)
		{
		}

		[Token(Token = "0x600070E")]
		[Address(RVA = "0x1F90E38", Offset = "0x1F90E38", VA = "0x1F90E38")]
		public P2PNetworkGoal()
		{
		}
	}
	[Token(Token = "0x200011F")]
	public class PlatformManager : MonoBehaviour
	{
		[Token(Token = "0x200018B")]
		public enum State
		{
			[Token(Token = "0x400063A")]
			INITIALIZING,
			[Token(Token = "0x400063B")]
			WAITING_TO_PRACTICE_OR_MATCHMAKE,
			[Token(Token = "0x400063C")]
			MATCH_TRANSITION,
			[Token(Token = "0x400063D")]
			PLAYING_A_LOCAL_MATCH,
			[Token(Token = "0x400063E")]
			PLAYING_A_NETWORKED_MATCH
		}

		[Token(Token = "0x40002C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static PlatformManager s_instance;

		[Token(Token = "0x40002C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private MatchmakingManager m_matchmaking;

		[Token(Token = "0x40002C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private P2PManager m_p2p;

		[Token(Token = "0x40002C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private LeaderboardManager m_leaderboards;

		[Token(Token = "0x40002C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private AchievementsManager m_achievements;

		[Token(Token = "0x40002C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private State m_currentState;

		[Token(Token = "0x40002CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private ulong m_myID;

		[Token(Token = "0x40002CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private string m_myOculusID;

		[Token(Token = "0x1700003F")]
		public static MatchmakingManager Matchmaking
		{
			[Token(Token = "0x6000717")]
			[Address(RVA = "0x1F8A988", Offset = "0x1F8A988", VA = "0x1F8A988")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000040")]
		public static P2PManager P2P
		{
			[Token(Token = "0x6000718")]
			[Address(RVA = "0x1F8A4B8", Offset = "0x1F8A4B8", VA = "0x1F8A4B8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000041")]
		public static LeaderboardManager Leaderboards
		{
			[Token(Token = "0x6000719")]
			[Address(RVA = "0x1F8AA14", Offset = "0x1F8AA14", VA = "0x1F8AA14")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000042")]
		public static AchievementsManager Achievements
		{
			[Token(Token = "0x600071A")]
			[Address(RVA = "0x1F8C9E0", Offset = "0x1F8C9E0", VA = "0x1F8C9E0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000043")]
		public static State CurrentState
		{
			[Token(Token = "0x600071B")]
			[Address(RVA = "0x1F88924", Offset = "0x1F88924", VA = "0x1F88924")]
			get
			{
				return default(State);
			}
		}

		[Token(Token = "0x17000044")]
		public static ulong MyID
		{
			[Token(Token = "0x600071C")]
			[Address(RVA = "0x1F89720", Offset = "0x1F89720", VA = "0x1F89720")]
			get
			{
				return default(ulong);
			}
		}

		[Token(Token = "0x17000045")]
		public static string MyOculusID
		{
			[Token(Token = "0x600071D")]
			[Address(RVA = "0x1F8B8B0", Offset = "0x1F8B8B0", VA = "0x1F8B8B0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600070F")]
		[Address(RVA = "0x1F90E40", Offset = "0x1F90E40", VA = "0x1F90E40")]
		private void Update()
		{
		}

		[Token(Token = "0x6000710")]
		[Address(RVA = "0x1F90E74", Offset = "0x1F90E74", VA = "0x1F90E74")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000711")]
		[Address(RVA = "0x1F91030", Offset = "0x1F91030", VA = "0x1F91030")]
		private void Start()
		{
		}

		[Token(Token = "0x6000712")]
		[Address(RVA = "0x1F910C8", Offset = "0x1F910C8", VA = "0x1F910C8")]
		private void IsEntitledCallback(Message msg)
		{
		}

		[Token(Token = "0x6000713")]
		[Address(RVA = "0x1F91198", Offset = "0x1F91198", VA = "0x1F91198")]
		private void GetLoggedInUserCallback(Message<User> msg)
		{
		}

		[Token(Token = "0x6000714")]
		[Address(RVA = "0x1F8DB4C", Offset = "0x1F8DB4C", VA = "0x1F8DB4C")]
		public static void TerminateWithError(Message msg)
		{
		}

		[Token(Token = "0x6000715")]
		[Address(RVA = "0x1F91240", Offset = "0x1F91240", VA = "0x1F91240")]
		public void QuitButtonPressed()
		{
		}

		[Token(Token = "0x6000716")]
		[Address(RVA = "0x1F91248", Offset = "0x1F91248", VA = "0x1F91248")]
		private void OnApplicationQuit()
		{
		}

		[Token(Token = "0x600071E")]
		[Address(RVA = "0x1F8B1EC", Offset = "0x1F8B1EC", VA = "0x1F8B1EC")]
		public static void TransitionToState(State newState)
		{
		}

		[Token(Token = "0x600071F")]
		[Address(RVA = "0x1F9127C", Offset = "0x1F9127C", VA = "0x1F9127C")]
		public PlatformManager()
		{
		}
	}
	[Token(Token = "0x2000120")]
	public abstract class Player : MonoBehaviour
	{
		[Token(Token = "0x40002CC")]
		public const uint MAX_BALLS = 6u;

		[Token(Token = "0x40002CD")]
		private const float INITIAL_FORCE = 870f;

		[Token(Token = "0x40002CE")]
		private const float RESPAWN_SECONDS = 2f;

		[Token(Token = "0x40002CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private uint m_score;

		[Token(Token = "0x40002D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Text m_scoreUI;

		[Token(Token = "0x40002D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private GameObject m_ballPrefab;

		[Token(Token = "0x40002D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private BallEjector m_ballEjector;

		[Token(Token = "0x40002D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Queue<GameObject> m_balls;

		[Token(Token = "0x40002D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private GameObject m_heldBall;

		[Token(Token = "0x40002D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float m_nextSpawnTime;

		[Token(Token = "0x17000046")]
		public virtual uint Score
		{
			[Token(Token = "0x6000720")]
			[Address(RVA = "0x1F91284", Offset = "0x1F91284", VA = "0x1F91284", Slot = "4")]
			get
			{
				return default(uint);
			}
			[Token(Token = "0x6000721")]
			[Address(RVA = "0x1F8A3F4", Offset = "0x1F8A3F4", VA = "0x1F8A3F4", Slot = "5")]
			set
			{
			}
		}

		[Token(Token = "0x17000047")]
		public GameObject BallPrefab
		{
			[Token(Token = "0x6000722")]
			[Address(RVA = "0x1F9128C", Offset = "0x1F9128C", VA = "0x1F9128C")]
			set
			{
			}
		}

		[Token(Token = "0x17000048")]
		protected bool HasBall
		{
			[Token(Token = "0x6000723")]
			[Address(RVA = "0x1F87DBC", Offset = "0x1F87DBC", VA = "0x1F87DBC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000724")]
		[Address(RVA = "0x1F91294", Offset = "0x1F91294", VA = "0x1F91294")]
		private void Start()
		{
		}

		[Token(Token = "0x6000725")]
		[Address(RVA = "0x1F90330", Offset = "0x1F90330", VA = "0x1F90330")]
		public GameObject CreateBall()
		{
			return null;
		}

		[Token(Token = "0x6000726")]
		[Address(RVA = "0x1F87FB8", Offset = "0x1F87FB8", VA = "0x1F87FB8")]
		protected GameObject CheckSpawnBall()
		{
			return null;
		}

		[Token(Token = "0x6000727")]
		[Address(RVA = "0x1F87E2C", Offset = "0x1F87E2C", VA = "0x1F87E2C")]
		protected GameObject ShootBall()
		{
			return null;
		}

		[Token(Token = "0x6000728")]
		[Address(RVA = "0x1F91348", Offset = "0x1F91348", VA = "0x1F91348")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000729")]
		[Address(RVA = "0x1F88038", Offset = "0x1F88038", VA = "0x1F88038")]
		protected Player()
		{
		}
	}
	[Token(Token = "0x2000121")]
	public class PlayerArea : MonoBehaviour
	{
		[Token(Token = "0x40002D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject m_ballPrefab;

		[Token(Token = "0x40002D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private GameObject m_playerHead;

		[Token(Token = "0x40002D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Text m_nameText;

		[Token(Token = "0x40002D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private P2PNetworkGoal m_p2pGoal;

		[Token(Token = "0x17000049")]
		public Player Player
		{
			[Token(Token = "0x600072A")]
			[Address(RVA = "0x1F8C988", Offset = "0x1F8C988", VA = "0x1F8C988")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700004A")]
		public Text NameText
		{
			[Token(Token = "0x600072B")]
			[Address(RVA = "0x1F91474", Offset = "0x1F91474", VA = "0x1F91474")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600072C")]
		[Address(RVA = "0x1F9147C", Offset = "0x1F9147C", VA = "0x1F9147C")]
		private void Awake()
		{
		}

		[Token(Token = "0x600072D")]
		public T SetupForPlayer<T>(string name) where T : Player
		{
			return null;
		}

		[Token(Token = "0x600072E")]
		[Address(RVA = "0x1F91568", Offset = "0x1F91568", VA = "0x1F91568")]
		public PlayerArea()
		{
		}
	}
	[Token(Token = "0x2000122")]
	public class RemotePlayer : Player
	{
		[Token(Token = "0x40002DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private User m_user;

		[Token(Token = "0x40002DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private P2PNetworkGoal m_goal;

		[Token(Token = "0x1700004B")]
		public User User
		{
			[Token(Token = "0x600072F")]
			[Address(RVA = "0x1F91570", Offset = "0x1F91570", VA = "0x1F91570")]
			set
			{
			}
		}

		[Token(Token = "0x1700004C")]
		public ulong ID
		{
			[Token(Token = "0x6000730")]
			[Address(RVA = "0x1F8F010", Offset = "0x1F8F010", VA = "0x1F8F010")]
			get
			{
				return default(ulong);
			}
		}

		[Token(Token = "0x1700004D")]
		public P2PNetworkGoal Goal
		{
			[Token(Token = "0x6000731")]
			[Address(RVA = "0x1F91578", Offset = "0x1F91578", VA = "0x1F91578")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000732")]
			[Address(RVA = "0x1F91580", Offset = "0x1F91580", VA = "0x1F91580")]
			set
			{
			}
		}

		[Token(Token = "0x1700004E")]
		public override uint Score
		{
			[Token(Token = "0x6000733")]
			[Address(RVA = "0x1F91588", Offset = "0x1F91588", VA = "0x1F91588", Slot = "5")]
			set
			{
			}
		}

		[Token(Token = "0x6000734")]
		[Address(RVA = "0x1F907A8", Offset = "0x1F907A8", VA = "0x1F907A8")]
		public void ReceiveRemoteScore(uint score)
		{
		}

		[Token(Token = "0x6000735")]
		[Address(RVA = "0x1F9158C", Offset = "0x1F9158C", VA = "0x1F9158C")]
		public RemotePlayer()
		{
		}
	}
	[Token(Token = "0x2000123")]
	public class VREyeRaycaster : MonoBehaviour
	{
		[Token(Token = "0x40002DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private EventSystem m_eventSystem;

		[Token(Token = "0x40002DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Button m_currentButton;

		[Token(Token = "0x6000736")]
		[Address(RVA = "0x1F91590", Offset = "0x1F91590", VA = "0x1F91590")]
		private void Update()
		{
		}

		[Token(Token = "0x6000737")]
		[Address(RVA = "0x1F91790", Offset = "0x1F91790", VA = "0x1F91790")]
		public VREyeRaycaster()
		{
		}
	}
}
namespace Oculus.Platform.Samples.VrBoardGame
{
	[Token(Token = "0x2000124")]
	public class BoardPosition : MonoBehaviour
	{
		[Token(Token = "0x40002DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1185FC8", Offset = "0x1185FC8")]
		public int x;

		[Token(Token = "0x40002DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[SerializeField]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1186008", Offset = "0x1186008")]
		public int y;

		[Token(Token = "0x6000738")]
		[Address(RVA = "0x1F82C80", Offset = "0x1F82C80", VA = "0x1F82C80")]
		public BoardPosition()
		{
		}
	}
	[Token(Token = "0x2000125")]
	public class EyeCamera : MonoBehaviour
	{
		[Token(Token = "0x40002E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private EventSystem m_eventSystem;

		[Token(Token = "0x40002E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameController m_gameController;

		[Token(Token = "0x40002E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private SphereCollider m_gazeTracker;

		[Token(Token = "0x40002E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Button m_currentButton;

		[Token(Token = "0x40002E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private GamePiece m_currentPiece;

		[Token(Token = "0x40002E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private BoardPosition m_boardPosition;

		[Token(Token = "0x6000739")]
		[Address(RVA = "0x1F82C88", Offset = "0x1F82C88", VA = "0x1F82C88")]
		private void Update()
		{
		}

		[Token(Token = "0x600073A")]
		[Address(RVA = "0x1F83578", Offset = "0x1F83578", VA = "0x1F83578")]
		public EyeCamera()
		{
		}
	}
	[Token(Token = "0x2000126")]
	public class GameBoard : MonoBehaviour
	{
		[Token(Token = "0x200018C")]
		private struct PositionInfo
		{
			[Token(Token = "0x400063F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public GameObject piece;

			[Token(Token = "0x4000640")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public int pieceOwner;

			[Token(Token = "0x4000641")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public int powerPieceOwner;
		}

		[Token(Token = "0x40002E6")]
		public const int LENGTH_X = 3;

		[Token(Token = "0x40002E7")]
		public const int LENGTH_Y = 3;

		[Token(Token = "0x40002E8")]
		public const int MAX_PLAYERS = 2;

		[Token(Token = "0x40002E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Color[] m_playerColors;

		[Token(Token = "0x40002EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Color m_proposedMoveColor;

		[Token(Token = "0x40002EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private int[] m_scores;

		[Token(Token = "0x40002EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private BoardPosition[] m_positions;

		[Token(Token = "0x40002ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private readonly PositionInfo[,] m_pieces;

		[Token(Token = "0x600073B")]
		[Address(RVA = "0x1F83580", Offset = "0x1F83580", VA = "0x1F83580")]
		public void Reset()
		{
		}

		[Token(Token = "0x600073C")]
		[Address(RVA = "0x1F83754", Offset = "0x1F83754", VA = "0x1F83754")]
		public bool IsFull()
		{
			return default(bool);
		}

		[Token(Token = "0x600073D")]
		[Address(RVA = "0x1F83848", Offset = "0x1F83848", VA = "0x1F83848")]
		public bool CanPlayerMoveToPostion(int x, int y)
		{
			return default(bool);
		}

		[Token(Token = "0x600073E")]
		[Address(RVA = "0x1F8390C", Offset = "0x1F8390C", VA = "0x1F8390C")]
		public bool CanPlayerPowerUpPosition(int x, int y)
		{
			return default(bool);
		}

		[Token(Token = "0x600073F")]
		[Address(RVA = "0x1F839D0", Offset = "0x1F839D0", VA = "0x1F839D0")]
		public void AddPiece(int player, GameObject prefab, int x, int y)
		{
		}

		[Token(Token = "0x6000740")]
		[Address(RVA = "0x1F83F88", Offset = "0x1F83F88", VA = "0x1F83F88")]
		public GamePiece AddProposedPiece(GameObject prefab, BoardPosition pos)
		{
			return null;
		}

		[Token(Token = "0x6000741")]
		[Address(RVA = "0x1F84068", Offset = "0x1F84068", VA = "0x1F84068")]
		public void AddPowerPiece(int player, GameObject prefab, int x, int y)
		{
		}

		[Token(Token = "0x6000742")]
		[Address(RVA = "0x1F84228", Offset = "0x1F84228", VA = "0x1F84228")]
		public GamePiece AddProposedPowerPiece(GameObject prefab, BoardPosition pos)
		{
			return null;
		}

		[Token(Token = "0x6000743")]
		[Address(RVA = "0x1F83BC4", Offset = "0x1F83BC4", VA = "0x1F83BC4")]
		private GamePiece Create(GameObject prefab, GameObject parent, BoardPosition pos, Vector3 off)
		{
			return null;
		}

		[Token(Token = "0x6000744")]
		[Address(RVA = "0x1F84364", Offset = "0x1F84364", VA = "0x1F84364")]
		public int GetPlayerScore(int player)
		{
			return default(int);
		}

		[Token(Token = "0x6000745")]
		[Address(RVA = "0x1F83D38", Offset = "0x1F83D38", VA = "0x1F83D38")]
		private void UpdateScores()
		{
		}

		[Token(Token = "0x6000746")]
		[Address(RVA = "0x1F843A0", Offset = "0x1F843A0", VA = "0x1F843A0")]
		public GameBoard()
		{
		}
	}
	[Token(Token = "0x2000127")]
	public class GameController : MonoBehaviour
	{
		[Token(Token = "0x200018D")]
		private enum GameState
		{
			[Token(Token = "0x4000643")]
			None,
			[Token(Token = "0x4000644")]
			PracticingMyTurn,
			[Token(Token = "0x4000645")]
			PracticingAiTurn,
			[Token(Token = "0x4000646")]
			OnlineMatchMyTurn,
			[Token(Token = "0x4000647")]
			OnlineMatchRemoteTurn
		}

		[Token(Token = "0x40002EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private MatchmakingManager m_matchmaking;

		[Token(Token = "0x40002EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameBoard m_board;

		[Token(Token = "0x40002F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GamePiece m_pieceA;

		[Token(Token = "0x40002F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GamePiece m_pieceB;

		[Token(Token = "0x40002F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GamePiece m_powerPiece;

		[Token(Token = "0x40002F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Color m_unusableColor;

		[Token(Token = "0x40002F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Color m_unselectedColor;

		[Token(Token = "0x40002F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Color m_selectedColor;

		[Token(Token = "0x40002F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Color m_highlightedColor;

		[Token(Token = "0x40002F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[SerializeField]
		private Text m_ballCountText;

		[Token(Token = "0x40002F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[SerializeField]
		private Text m_player0Text;

		[Token(Token = "0x40002F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[SerializeField]
		private Text m_player1Text;

		[Token(Token = "0x40002FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private GameState m_state;

		[Token(Token = "0x40002FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private GamePiece m_interestedPiece;

		[Token(Token = "0x40002FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private GamePiece m_selectedPiece;

		[Token(Token = "0x40002FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private GamePiece m_proposedPiece;

		[Token(Token = "0x40002FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private uint m_powerBallcount;

		[Token(Token = "0x40002FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private string m_opponentName;

		[Token(Token = "0x6000747")]
		[Address(RVA = "0x1F84474", Offset = "0x1F84474", VA = "0x1F84474")]
		private void Start()
		{
		}

		[Token(Token = "0x6000748")]
		[Address(RVA = "0x1F845D0", Offset = "0x1F845D0", VA = "0x1F845D0")]
		private void Update()
		{
		}

		[Token(Token = "0x6000749")]
		[Address(RVA = "0x1F8449C", Offset = "0x1F8449C", VA = "0x1F8449C")]
		private void TransitionToState(GameState state)
		{
		}

		[Token(Token = "0x600074A")]
		[Address(RVA = "0x1F849F8", Offset = "0x1F849F8", VA = "0x1F849F8")]
		private void TransitionToNextState()
		{
		}

		[Token(Token = "0x600074B")]
		[Address(RVA = "0x1F845D4", Offset = "0x1F845D4", VA = "0x1F845D4")]
		private void PerFrameStateUpdate()
		{
		}

		[Token(Token = "0x600074C")]
		[Address(RVA = "0x1F85134", Offset = "0x1F85134", VA = "0x1F85134")]
		public void PracticeButtonPressed()
		{
		}

		[Token(Token = "0x600074D")]
		[Address(RVA = "0x1F84C90", Offset = "0x1F84C90", VA = "0x1F84C90")]
		private void MakeAIMove(int player)
		{
		}

		[Token(Token = "0x600074E")]
		[Address(RVA = "0x1F8525C", Offset = "0x1F8525C", VA = "0x1F8525C")]
		public void StartOnlineMatch(string opponentName, bool localUserGoesFirst)
		{
		}

		[Token(Token = "0x600074F")]
		[Address(RVA = "0x1F852BC", Offset = "0x1F852BC", VA = "0x1F852BC")]
		public void MakeRemoteMove(GamePiece.Piece piece, int x, int y)
		{
		}

		[Token(Token = "0x6000750")]
		[Address(RVA = "0x1F85360", Offset = "0x1F85360", VA = "0x1F85360")]
		public void MarkRemoteTurnComplete()
		{
		}

		[Token(Token = "0x6000751")]
		[Address(RVA = "0x1F85374", Offset = "0x1F85374", VA = "0x1F85374")]
		public void RemoteMatchEnded()
		{
		}

		[Token(Token = "0x6000752")]
		[Address(RVA = "0x1F83228", Offset = "0x1F83228", VA = "0x1F83228")]
		public void StartedLookingAtPiece(GamePiece piece)
		{
		}

		[Token(Token = "0x6000753")]
		[Address(RVA = "0x1F83220", Offset = "0x1F83220", VA = "0x1F83220")]
		public void StoppedLookingAtPiece()
		{
		}

		[Token(Token = "0x6000754")]
		[Address(RVA = "0x1F83230", Offset = "0x1F83230", VA = "0x1F83230")]
		public void StartedLookingAtPosition(BoardPosition position)
		{
		}

		[Token(Token = "0x6000755")]
		[Address(RVA = "0x1F834AC", Offset = "0x1F834AC", VA = "0x1F834AC")]
		public void ClearProposedMove()
		{
		}

		[Token(Token = "0x6000756")]
		[Address(RVA = "0x1F84EA0", Offset = "0x1F84EA0", VA = "0x1F84EA0")]
		public void TrySelectPiece()
		{
		}

		[Token(Token = "0x6000757")]
		[Address(RVA = "0x1F84FAC", Offset = "0x1F84FAC", VA = "0x1F84FAC")]
		public void TryPlacePiece()
		{
		}

		[Token(Token = "0x6000758")]
		[Address(RVA = "0x1F855F4", Offset = "0x1F855F4", VA = "0x1F855F4")]
		public void QuitButtonPressed()
		{
		}

		[Token(Token = "0x6000759")]
		[Address(RVA = "0x1F855FC", Offset = "0x1F855FC", VA = "0x1F855FC")]
		public void AddPowerballs(uint count)
		{
		}

		[Token(Token = "0x600075A")]
		[Address(RVA = "0x1F844A4", Offset = "0x1F844A4", VA = "0x1F844A4")]
		private void UpdateScores()
		{
		}

		[Token(Token = "0x600075B")]
		[Address(RVA = "0x1F8468C", Offset = "0x1F8468C", VA = "0x1F8468C")]
		private void UpdateGamePieceColors()
		{
		}

		[Token(Token = "0x600075C")]
		[Address(RVA = "0x1F85750", Offset = "0x1F85750", VA = "0x1F85750")]
		public GameController()
		{
		}
	}
	[Token(Token = "0x2000128")]
	public class GamePiece : MonoBehaviour
	{
		[Token(Token = "0x200018E")]
		public enum Piece
		{
			[Token(Token = "0x4000649")]
			A,
			[Token(Token = "0x400064A")]
			B,
			[Token(Token = "0x400064B")]
			PowerBall
		}

		[Token(Token = "0x4000300")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Piece m_type;

		[Token(Token = "0x4000301")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject m_prefabA;

		[Token(Token = "0x4000302")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject m_prefabB;

		[Token(Token = "0x4000303")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject m_prefabPower;

		[Token(Token = "0x4000304")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private BoardPosition m_position;

		[Token(Token = "0x1700004F")]
		public Piece Type
		{
			[Token(Token = "0x600075D")]
			[Address(RVA = "0x1F857B4", Offset = "0x1F857B4", VA = "0x1F857B4")]
			get
			{
				return default(Piece);
			}
		}

		[Token(Token = "0x17000050")]
		public BoardPosition Position
		{
			[Token(Token = "0x600075E")]
			[Address(RVA = "0x1F857BC", Offset = "0x1F857BC", VA = "0x1F857BC")]
			get
			{
				return null;
			}
			[Token(Token = "0x600075F")]
			[Address(RVA = "0x1F857C4", Offset = "0x1F857C4", VA = "0x1F857C4")]
			set
			{
			}
		}

		[Token(Token = "0x17000051")]
		public GameObject Prefab
		{
			[Token(Token = "0x6000760")]
			[Address(RVA = "0x1F85230", Offset = "0x1F85230", VA = "0x1F85230")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000761")]
		[Address(RVA = "0x1F85338", Offset = "0x1F85338", VA = "0x1F85338")]
		public GameObject PrefabFor(Piece p)
		{
			return null;
		}

		[Token(Token = "0x6000762")]
		[Address(RVA = "0x1F857CC", Offset = "0x1F857CC", VA = "0x1F857CC")]
		public GamePiece()
		{
		}
	}
	[Token(Token = "0x2000129")]
	public class IAPManager : MonoBehaviour
	{
		[Token(Token = "0x4000305")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameController m_gameController;

		[Token(Token = "0x4000306")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text m_priceText;

		[Token(Token = "0x4000307")]
		private const string CONSUMABLE_1 = "PowerballPack1";

		[Token(Token = "0x6000763")]
		[Address(RVA = "0x1F857D4", Offset = "0x1F857D4", VA = "0x1F857D4")]
		private void Start()
		{
		}

		[Token(Token = "0x6000764")]
		[Address(RVA = "0x1F857F8", Offset = "0x1F857F8", VA = "0x1F857F8")]
		public void FetchProductPrices()
		{
		}

		[Token(Token = "0x6000765")]
		[Address(RVA = "0x1F859B0", Offset = "0x1F859B0", VA = "0x1F859B0")]
		private void GetProductsBySKUCallback(Message<ProductList> msg)
		{
		}

		[Token(Token = "0x6000766")]
		[Address(RVA = "0x1F85908", Offset = "0x1F85908", VA = "0x1F85908")]
		public void FetchPurchasedProducts()
		{
		}

		[Token(Token = "0x6000767")]
		[Address(RVA = "0x1F85E50", Offset = "0x1F85E50", VA = "0x1F85E50")]
		private void GetViewerPurchasesCallback(Message<PurchaseList> msg)
		{
		}

		[Token(Token = "0x6000768")]
		[Address(RVA = "0x1F86234", Offset = "0x1F86234", VA = "0x1F86234")]
		public void BuyPowerBallsPressed()
		{
		}

		[Token(Token = "0x6000769")]
		[Address(RVA = "0x1F862E8", Offset = "0x1F862E8", VA = "0x1F862E8")]
		private void LaunchCheckoutFlowCallback(Message<Purchase> msg)
		{
		}

		[Token(Token = "0x600076A")]
		[Address(RVA = "0x1F863D0", Offset = "0x1F863D0", VA = "0x1F863D0")]
		public IAPManager()
		{
		}
	}
	[Token(Token = "0x200012A")]
	public class MatchmakingManager : MonoBehaviour
	{
		[Token(Token = "0x200018F")]
		private enum MatchRoomState
		{
			[Token(Token = "0x400064D")]
			None,
			[Token(Token = "0x400064E")]
			Queued,
			[Token(Token = "0x400064F")]
			Configuring,
			[Token(Token = "0x4000650")]
			MyTurn,
			[Token(Token = "0x4000651")]
			RemoteTurn
		}

		[Token(Token = "0x4000308")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameController m_gameController;

		[Token(Token = "0x4000309")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text m_matchButtonText;

		[Token(Token = "0x400030A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text m_infoText;

		[Token(Token = "0x400030B")]
		private const string POOL = "VR_BOARD_GAME_POOL";

		[Token(Token = "0x400030C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private ulong m_matchRoom;

		[Token(Token = "0x400030D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private User m_remotePlayer;

		[Token(Token = "0x400030E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private float m_lastUpdateTime;

		[Token(Token = "0x400030F")]
		private const float POLL_FREQUENCY = 30f;

		[Token(Token = "0x4000310")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private MatchRoomState m_state;

		[Token(Token = "0x600076B")]
		[Address(RVA = "0x1F863D8", Offset = "0x1F863D8", VA = "0x1F863D8")]
		private void Start()
		{
		}

		[Token(Token = "0x600076C")]
		[Address(RVA = "0x1F86620", Offset = "0x1F86620", VA = "0x1F86620")]
		private void Update()
		{
		}

		[Token(Token = "0x600076D")]
		[Address(RVA = "0x1F86748", Offset = "0x1F86748", VA = "0x1F86748")]
		public void MatchButtonPressed()
		{
		}

		[Token(Token = "0x600076E")]
		[Address(RVA = "0x1F84ADC", Offset = "0x1F84ADC", VA = "0x1F84ADC")]
		public void EndMatch(int localScore, int remoteScore)
		{
		}

		[Token(Token = "0x600076F")]
		[Address(RVA = "0x1F86804", Offset = "0x1F86804", VA = "0x1F86804")]
		private void OnApplicationQuit()
		{
		}

		[Token(Token = "0x6000770")]
		[Address(RVA = "0x1F86498", Offset = "0x1F86498", VA = "0x1F86498")]
		private void TransitionToState(MatchRoomState state)
		{
		}

		[Token(Token = "0x6000771")]
		[Address(RVA = "0x1F86840", Offset = "0x1F86840", VA = "0x1F86840")]
		private void MatchmakingEnqueueCallback(Message untyped_msg)
		{
		}

		[Token(Token = "0x6000772")]
		[Address(RVA = "0x1F86AD0", Offset = "0x1F86AD0", VA = "0x1F86AD0")]
		private void MatchFoundCallback(Message<Room> msg)
		{
		}

		[Token(Token = "0x6000773")]
		[Address(RVA = "0x1F86C20", Offset = "0x1F86C20", VA = "0x1F86C20")]
		private void MatchmakingJoinRoomCallback(Message<Room> msg)
		{
		}

		[Token(Token = "0x6000774")]
		[Address(RVA = "0x1F8736C", Offset = "0x1F8736C", VA = "0x1F8736C")]
		private void MatchmakingRoomUpdateCallback(Message<Room> msg)
		{
		}

		[Token(Token = "0x6000775")]
		[Address(RVA = "0x1F86ED8", Offset = "0x1F86ED8", VA = "0x1F86ED8")]
		private void ProcessRoomData(Room room)
		{
		}

		[Token(Token = "0x6000776")]
		[Address(RVA = "0x1F876E4", Offset = "0x1F876E4", VA = "0x1F876E4")]
		private void ProcessRemoteMove(string moveString)
		{
		}

		[Token(Token = "0x6000777")]
		[Address(RVA = "0x1F853D0", Offset = "0x1F853D0", VA = "0x1F853D0")]
		public void SendLocalMove(GamePiece.Piece piece, int boardX, int boardY)
		{
		}

		[Token(Token = "0x6000778")]
		[Address(RVA = "0x1F878CC", Offset = "0x1F878CC", VA = "0x1F878CC")]
		private void UpdateDataStoreCallback(Message<Room> msg)
		{
		}

		[Token(Token = "0x6000779")]
		[Address(RVA = "0x1F8769C", Offset = "0x1F8769C", VA = "0x1F8769C")]
		private bool DoesLocalUserGoFirst()
		{
			return default(bool);
		}

		[Token(Token = "0x600077A")]
		[Address(RVA = "0x1F87900", Offset = "0x1F87900", VA = "0x1F87900")]
		private void GenericErrorCheckCallback(Message msg)
		{
		}

		[Token(Token = "0x600077B")]
		[Address(RVA = "0x1F879C4", Offset = "0x1F879C4", VA = "0x1F879C4")]
		public MatchmakingManager()
		{
		}
	}
	[Token(Token = "0x200012B")]
	public class PlatformManager : MonoBehaviour
	{
		[Token(Token = "0x4000311")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static PlatformManager s_instance;

		[Token(Token = "0x4000312")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private ulong m_myID;

		[Token(Token = "0x4000313")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private string m_myOculusID;

		[Token(Token = "0x17000052")]
		public static ulong MyID
		{
			[Token(Token = "0x6000781")]
			[Address(RVA = "0x1F86760", Offset = "0x1F86760", VA = "0x1F86760")]
			get
			{
				return default(ulong);
			}
		}

		[Token(Token = "0x17000053")]
		public static string MyOculusID
		{
			[Token(Token = "0x6000782")]
			[Address(RVA = "0x1F8569C", Offset = "0x1F8569C", VA = "0x1F8569C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600077C")]
		[Address(RVA = "0x1F879CC", Offset = "0x1F879CC", VA = "0x1F879CC")]
		private void Awake()
		{
		}

		[Token(Token = "0x600077D")]
		[Address(RVA = "0x1F87B0C", Offset = "0x1F87B0C", VA = "0x1F87B0C")]
		private void Start()
		{
		}

		[Token(Token = "0x600077E")]
		[Address(RVA = "0x1F87BA4", Offset = "0x1F87BA4", VA = "0x1F87BA4")]
		private void IsEntitledCallback(Message msg)
		{
		}

		[Token(Token = "0x600077F")]
		[Address(RVA = "0x1F87C74", Offset = "0x1F87C74", VA = "0x1F87C74")]
		private void GetLoggedInUserCallback(Message<User> msg)
		{
		}

		[Token(Token = "0x6000780")]
		[Address(RVA = "0x1F85DA4", Offset = "0x1F85DA4", VA = "0x1F85DA4")]
		public static void TerminateWithError(Message msg)
		{
		}

		[Token(Token = "0x6000783")]
		[Address(RVA = "0x1F87D50", Offset = "0x1F87D50", VA = "0x1F87D50")]
		public PlatformManager()
		{
		}
	}
}
namespace Oculus.Platform.Samples.SimplePlatformSample
{
	[Token(Token = "0x200012C")]
	public class DataEntry : MonoBehaviour
	{
		[Token(Token = "0x4000314")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Text dataOutput;

		[Token(Token = "0x6000784")]
		[Address(RVA = "0x1F7E4E0", Offset = "0x1F7E4E0", VA = "0x1F7E4E0")]
		private void Start()
		{
		}

		[Token(Token = "0x6000785")]
		[Address(RVA = "0x1F7E5E8", Offset = "0x1F7E5E8", VA = "0x1F7E5E8")]
		private void Update()
		{
		}

		[Token(Token = "0x6000786")]
		[Address(RVA = "0x1F7E6AC", Offset = "0x1F7E6AC", VA = "0x1F7E6AC")]
		private void SubmitCommand(string command)
		{
		}

		[Token(Token = "0x6000787")]
		[Address(RVA = "0x1F80274", Offset = "0x1F80274", VA = "0x1F80274")]
		private void getLeaderboardEntries(string leaderboardName)
		{
		}

		[Token(Token = "0x6000788")]
		[Address(RVA = "0x1F8015C", Offset = "0x1F8015C", VA = "0x1F8015C")]
		private void writeLeaderboardEntry(string leaderboardName, string value)
		{
		}

		[Token(Token = "0x6000789")]
		[Address(RVA = "0x1F800A4", Offset = "0x1F800A4", VA = "0x1F800A4")]
		private void addFieldsAchievement(string achievementName, string fields)
		{
		}

		[Token(Token = "0x600078A")]
		[Address(RVA = "0x1F7FFC0", Offset = "0x1F7FFC0", VA = "0x1F7FFC0")]
		private void addCountAchievement(string achievementName, string count)
		{
		}

		[Token(Token = "0x600078B")]
		[Address(RVA = "0x1F7FF10", Offset = "0x1F7FF10", VA = "0x1F7FF10")]
		private void unlockAchievement(string achievementName)
		{
		}

		[Token(Token = "0x600078C")]
		[Address(RVA = "0x1F7FE08", Offset = "0x1F7FE08", VA = "0x1F7FE08")]
		private void getAchievementProgress(string achievementName)
		{
		}

		[Token(Token = "0x600078D")]
		[Address(RVA = "0x1F7FD00", Offset = "0x1F7FD00", VA = "0x1F7FD00")]
		private void getAchievementDefinition(string achievementName)
		{
		}

		[Token(Token = "0x600078E")]
		[Address(RVA = "0x1F7E550", Offset = "0x1F7E550", VA = "0x1F7E550")]
		private void checkEntitlement()
		{
		}

		[Token(Token = "0x600078F")]
		[Address(RVA = "0x1F7FC48", Offset = "0x1F7FC48", VA = "0x1F7FC48")]
		private void getUserNonce()
		{
		}

		[Token(Token = "0x6000790")]
		[Address(RVA = "0x1F7EE7C", Offset = "0x1F7EE7C", VA = "0x1F7EE7C")]
		private void createAndJoinPrivateRoom(string joinPolicy, string maxUsers)
		{
		}

		[Token(Token = "0x6000791")]
		[Address(RVA = "0x1F7EF88", Offset = "0x1F7EF88", VA = "0x1F7EF88")]
		private void getCurrentRoom()
		{
		}

		[Token(Token = "0x6000792")]
		[Address(RVA = "0x1F7F044", Offset = "0x1F7F044", VA = "0x1F7F044")]
		private void getRoom(string roomID)
		{
		}

		[Token(Token = "0x6000793")]
		[Address(RVA = "0x1F7F140", Offset = "0x1F7F140", VA = "0x1F7F140")]
		private void joinRoom(string roomID)
		{
		}

		[Token(Token = "0x6000794")]
		[Address(RVA = "0x1F7F240", Offset = "0x1F7F240", VA = "0x1F7F240")]
		private void leaveRoom(string roomID)
		{
		}

		[Token(Token = "0x6000795")]
		[Address(RVA = "0x1F7F33C", Offset = "0x1F7F33C", VA = "0x1F7F33C")]
		private void kickUser(string roomID, string userID)
		{
		}

		[Token(Token = "0x6000796")]
		[Address(RVA = "0x1F7F468", Offset = "0x1F7F468", VA = "0x1F7F468")]
		private void getLoggedInUser()
		{
		}

		[Token(Token = "0x6000797")]
		[Address(RVA = "0x1F7F520", Offset = "0x1F7F520", VA = "0x1F7F520")]
		private void getUser(string userID)
		{
		}

		[Token(Token = "0x6000798")]
		[Address(RVA = "0x1F7F618", Offset = "0x1F7F618", VA = "0x1F7F618")]
		private void getLoggedInFriends()
		{
		}

		[Token(Token = "0x6000799")]
		[Address(RVA = "0x1F7F6D0", Offset = "0x1F7F6D0", VA = "0x1F7F6D0")]
		private void getInvitableUsers()
		{
		}

		[Token(Token = "0x600079A")]
		[Address(RVA = "0x1F7F78C", Offset = "0x1F7F78C", VA = "0x1F7F78C")]
		private void inviteUser(string roomID, string inviteToken)
		{
		}

		[Token(Token = "0x600079B")]
		[Address(RVA = "0x1F7F8A0", Offset = "0x1F7F8A0", VA = "0x1F7F8A0")]
		private void setRoomDescription(string roomID, string description)
		{
		}

		[Token(Token = "0x600079C")]
		[Address(RVA = "0x1F7F9B4", Offset = "0x1F7F9B4", VA = "0x1F7F9B4")]
		private void updateRoomDataStore(string roomID, string key, string value)
		{
		}

		[Token(Token = "0x600079D")]
		[Address(RVA = "0x1F80330", Offset = "0x1F80330", VA = "0x1F80330")]
		private void printOutputLine(string newLine)
		{
		}

		[Token(Token = "0x600079E")]
		[Address(RVA = "0x1F80828", Offset = "0x1F80828", VA = "0x1F80828")]
		private void outputRoomDetails(Room room)
		{
		}

		[Token(Token = "0x600079F")]
		[Address(RVA = "0x1F80D58", Offset = "0x1F80D58", VA = "0x1F80D58")]
		private void outputUserArray(UserList users)
		{
		}

		[Token(Token = "0x60007A0")]
		[Address(RVA = "0x1F8124C", Offset = "0x1F8124C", VA = "0x1F8124C")]
		private void userProofCallback(Message<UserProof> msg)
		{
		}

		[Token(Token = "0x60007A1")]
		[Address(RVA = "0x1F81324", Offset = "0x1F81324", VA = "0x1F81324")]
		private void getEntitlementCallback(Message msg)
		{
		}

		[Token(Token = "0x60007A2")]
		[Address(RVA = "0x1F813A4", Offset = "0x1F813A4", VA = "0x1F813A4")]
		private void leaderboardGetCallback(Message<LeaderboardEntryList> msg)
		{
		}

		[Token(Token = "0x60007A3")]
		[Address(RVA = "0x1F81938", Offset = "0x1F81938", VA = "0x1F81938")]
		private void leaderboardWriteCallback(Message msg)
		{
		}

		[Token(Token = "0x60007A4")]
		[Address(RVA = "0x1F81A58", Offset = "0x1F81A58", VA = "0x1F81A58")]
		private void achievementFieldsCallback(Message msg)
		{
		}

		[Token(Token = "0x60007A5")]
		[Address(RVA = "0x1F81B14", Offset = "0x1F81B14", VA = "0x1F81B14")]
		private void achievementCountCallback(Message msg)
		{
		}

		[Token(Token = "0x60007A6")]
		[Address(RVA = "0x1F81BD0", Offset = "0x1F81BD0", VA = "0x1F81BD0")]
		private void achievementUnlockCallback(Message msg)
		{
		}

		[Token(Token = "0x60007A7")]
		[Address(RVA = "0x1F81C8C", Offset = "0x1F81C8C", VA = "0x1F81C8C")]
		private void achievementProgressCallback(Message<AchievementProgressList> msg)
		{
		}

		[Token(Token = "0x60007A8")]
		[Address(RVA = "0x1F82004", Offset = "0x1F82004", VA = "0x1F82004")]
		private void achievementDefinitionCallback(Message<AchievementDefinitionList> msg)
		{
		}

		[Token(Token = "0x60007A9")]
		[Address(RVA = "0x1F823F4", Offset = "0x1F823F4", VA = "0x1F823F4")]
		private void createAndJoinPrivateRoomCallback(Message<Room> msg)
		{
		}

		[Token(Token = "0x60007AA")]
		[Address(RVA = "0x1F824CC", Offset = "0x1F824CC", VA = "0x1F824CC")]
		private void getCurrentRoomCallback(Message<Room> msg)
		{
		}

		[Token(Token = "0x60007AB")]
		[Address(RVA = "0x1F825A4", Offset = "0x1F825A4", VA = "0x1F825A4")]
		private void joinRoomCallback(Message<Room> msg)
		{
		}

		[Token(Token = "0x60007AC")]
		[Address(RVA = "0x1F8267C", Offset = "0x1F8267C", VA = "0x1F8267C")]
		private void leaveRoomCallback(Message<Room> msg)
		{
		}

		[Token(Token = "0x60007AD")]
		[Address(RVA = "0x1F82754", Offset = "0x1F82754", VA = "0x1F82754")]
		private void getUserCallback(Message<User> msg)
		{
		}

		[Token(Token = "0x60007AE")]
		[Address(RVA = "0x1F82A0C", Offset = "0x1F82A0C", VA = "0x1F82A0C")]
		private void getFriendsCallback(Message<UserList> msg)
		{
		}

		[Token(Token = "0x60007AF")]
		[Address(RVA = "0x1F82AE4", Offset = "0x1F82AE4", VA = "0x1F82AE4")]
		private void getInvitableUsersCallback(Message<UserList> msg)
		{
		}

		[Token(Token = "0x60007B0")]
		[Address(RVA = "0x1F82BBC", Offset = "0x1F82BBC", VA = "0x1F82BBC")]
		private void inviteUserCallback(Message msg)
		{
		}

		[Token(Token = "0x60007B1")]
		[Address(RVA = "0x1F82C78", Offset = "0x1F82C78", VA = "0x1F82C78")]
		public DataEntry()
		{
		}
	}
}
namespace Oculus.Platform.Samples.NetChat
{
	[Token(Token = "0x200012D")]
	internal enum states
	{
		[Token(Token = "0x4000316")]
		NOT_INIT,
		[Token(Token = "0x4000317")]
		IDLE,
		[Token(Token = "0x4000318")]
		REQUEST_FIND,
		[Token(Token = "0x4000319")]
		FINDING_ROOM,
		[Token(Token = "0x400031A")]
		REQUEST_CREATE,
		[Token(Token = "0x400031B")]
		REQUEST_JOIN,
		[Token(Token = "0x400031C")]
		REQUEST_LEAVE,
		[Token(Token = "0x400031D")]
		IN_EMPTY_ROOM,
		[Token(Token = "0x400031E")]
		IN_FULL_ROOM
	}
	[Token(Token = "0x200012E")]
	public static class Constants
	{
		[Token(Token = "0x400031F")]
		public const int BUFFER_SIZE = 512;

		[Token(Token = "0x4000320")]
		public const string BOUT_POOL = "bout_pool";

		[Token(Token = "0x4000321")]
		public const string FILTER_POOL = "filter_pool";
	}
	[Token(Token = "0x200012F")]
	public class chatPacket
	{
		[Token(Token = "0x4000322")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x11861F8", Offset = "0x11861F8")]
		private int <packetID>k__BackingField;

		[Token(Token = "0x4000323")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1186208", Offset = "0x1186208")]
		private string <textString>k__BackingField;

		[Token(Token = "0x17000054")]
		public int packetID
		{
			[Token(Token = "0x60007B2")]
			[Address(RVA = "0x1F7DF58", Offset = "0x1F7DF58", VA = "0x1F7DF58")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1186720", Offset = "0x1186720")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60007B3")]
			[Address(RVA = "0x1F7DF60", Offset = "0x1F7DF60", VA = "0x1F7DF60")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1186730", Offset = "0x1186730")]
			set
			{
			}
		}

		[Token(Token = "0x17000055")]
		public string textString
		{
			[Token(Token = "0x60007B4")]
			[Address(RVA = "0x1F7DF68", Offset = "0x1F7DF68", VA = "0x1F7DF68")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1186740", Offset = "0x1186740")]
			get
			{
				return null;
			}
			[Token(Token = "0x60007B5")]
			[Address(RVA = "0x1F7DF70", Offset = "0x1F7DF70", VA = "0x1F7DF70")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1186750", Offset = "0x1186750")]
			set
			{
			}
		}

		[Token(Token = "0x60007B6")]
		[Address(RVA = "0x1F7DF78", Offset = "0x1F7DF78", VA = "0x1F7DF78")]
		public byte[] Serialize()
		{
			return null;
		}

		[Token(Token = "0x60007B7")]
		[Address(RVA = "0x1F7E26C", Offset = "0x1F7E26C", VA = "0x1F7E26C")]
		public static chatPacket Deserialize(byte[] data)
		{
			return null;
		}

		[Token(Token = "0x60007B8")]
		[Address(RVA = "0x1F7E4D8", Offset = "0x1F7E4D8", VA = "0x1F7E4D8")]
		public chatPacket()
		{
		}
	}
	[Token(Token = "0x2000130")]
	public class DataEntry : MonoBehaviour
	{
		[Token(Token = "0x4000324")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Text dataOutput;

		[Token(Token = "0x4000325")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private states currentState;

		[Token(Token = "0x4000326")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private User localUser;

		[Token(Token = "0x4000327")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private User remoteUser;

		[Token(Token = "0x4000328")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Room currentRoom;

		[Token(Token = "0x4000329")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private int lastPacketID;

		[Token(Token = "0x400032A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private bool ratedMatchStarted;

		[Token(Token = "0x60007B9")]
		[Address(RVA = "0x1D5BB38", Offset = "0x1D5BB38", VA = "0x1D5BB38")]
		private void Start()
		{
		}

		[Token(Token = "0x60007BA")]
		[Address(RVA = "0x1D5BCA8", Offset = "0x1D5BCA8", VA = "0x1D5BCA8")]
		private void Update()
		{
		}

		[Token(Token = "0x60007BB")]
		[Address(RVA = "0x1D5BD70", Offset = "0x1D5BD70", VA = "0x1D5BD70")]
		private void SubmitCommand(string command)
		{
		}

		[Token(Token = "0x60007BC")]
		[Address(RVA = "0x1D5D038", Offset = "0x1D5D038", VA = "0x1D5D038")]
		private void printOutputLine(string newLine)
		{
		}

		[Token(Token = "0x60007BD")]
		[Address(RVA = "0x1D5BC24", Offset = "0x1D5BC24", VA = "0x1D5BC24")]
		private void checkEntitlement()
		{
		}

		[Token(Token = "0x60007BE")]
		[Address(RVA = "0x1D5D0F0", Offset = "0x1D5D0F0", VA = "0x1D5D0F0")]
		private void getEntitlementCallback(Message msg)
		{
		}

		[Token(Token = "0x60007BF")]
		[Address(RVA = "0x1D5D1DC", Offset = "0x1D5D1DC", VA = "0x1D5D1DC")]
		private void init(Message<User> msg)
		{
		}

		[Token(Token = "0x60007C0")]
		[Address(RVA = "0x1D5C258", Offset = "0x1D5C258", VA = "0x1D5C258")]
		private void requestCreateRoom()
		{
		}

		[Token(Token = "0x60007C1")]
		[Address(RVA = "0x1D5D2FC", Offset = "0x1D5D2FC", VA = "0x1D5D2FC")]
		private void createRoomResponse(Message<MatchmakingEnqueueResultAndRoom> msg)
		{
		}

		[Token(Token = "0x60007C2")]
		[Address(RVA = "0x1D5C3D4", Offset = "0x1D5C3D4", VA = "0x1D5C3D4")]
		private void requestCreateFilterRoom()
		{
		}

		[Token(Token = "0x60007C3")]
		[Address(RVA = "0x1D5C768", Offset = "0x1D5C768", VA = "0x1D5C768")]
		private void requestFindRoom()
		{
		}

		[Token(Token = "0x60007C4")]
		[Address(RVA = "0x1D5C8DC", Offset = "0x1D5C8DC", VA = "0x1D5C8DC")]
		private void requestFindFilteredRoom()
		{
		}

		[Token(Token = "0x60007C5")]
		[Address(RVA = "0x1D5D430", Offset = "0x1D5D430", VA = "0x1D5D430")]
		private void foundMatch(Message<Room> msg)
		{
		}

		[Token(Token = "0x60007C6")]
		[Address(RVA = "0x1D5D568", Offset = "0x1D5D568", VA = "0x1D5D568")]
		private void joinRoomResponse(Message<Room> msg)
		{
		}

		[Token(Token = "0x60007C7")]
		[Address(RVA = "0x1D5C5F4", Offset = "0x1D5C5F4", VA = "0x1D5C5F4")]
		private void requestFindMatch()
		{
		}

		[Token(Token = "0x60007C8")]
		[Address(RVA = "0x1D5D850", Offset = "0x1D5D850", VA = "0x1D5D850")]
		private void searchingStarted(Message msg)
		{
		}

		[Token(Token = "0x60007C9")]
		[Address(RVA = "0x1D5D920", Offset = "0x1D5D920", VA = "0x1D5D920")]
		private void updateRoom(Message<Room> msg)
		{
		}

		[Token(Token = "0x60007CA")]
		[Address(RVA = "0x1D5CB74", Offset = "0x1D5CB74", VA = "0x1D5CB74")]
		private void sendChat(string chatMessage)
		{
		}

		[Token(Token = "0x60007CB")]
		[Address(RVA = "0x1D5C0CC", Offset = "0x1D5C0CC", VA = "0x1D5C0CC")]
		private void processNetPackets()
		{
		}

		[Token(Token = "0x60007CC")]
		[Address(RVA = "0x1D5CC70", Offset = "0x1D5CC70", VA = "0x1D5CC70")]
		private void requestLeaveRoom()
		{
		}

		[Token(Token = "0x60007CD")]
		[Address(RVA = "0x1D5DC78", Offset = "0x1D5DC78", VA = "0x1D5DC78")]
		private void leaveRoomResponse(Message<Room> msg)
		{
		}

		[Token(Token = "0x60007CE")]
		[Address(RVA = "0x1D5CD98", Offset = "0x1D5CD98", VA = "0x1D5CD98")]
		private void requestStartRatedMatch()
		{
		}

		[Token(Token = "0x60007CF")]
		[Address(RVA = "0x1D5DD4C", Offset = "0x1D5DD4C", VA = "0x1D5DD4C")]
		private void startRatedMatchResponse(Message msg)
		{
		}

		[Token(Token = "0x60007D0")]
		[Address(RVA = "0x1D5CE8C", Offset = "0x1D5CE8C", VA = "0x1D5CE8C")]
		private void requestReportResults()
		{
		}

		[Token(Token = "0x60007D1")]
		[Address(RVA = "0x1D5DE1C", Offset = "0x1D5DE1C", VA = "0x1D5DE1C")]
		private void reportResultsResponse(Message msg)
		{
		}

		[Token(Token = "0x60007D2")]
		[Address(RVA = "0x1D5DED8", Offset = "0x1D5DED8", VA = "0x1D5DED8")]
		public DataEntry()
		{
		}
	}
}
namespace Oculus.Platform.Samples.EntitlementCheck
{
	[Token(Token = "0x2000131")]
	public class EntitlementCheck : MonoBehaviour
	{
		[Token(Token = "0x400032B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool exitAppOnFailure;

		[Token(Token = "0x14000002")]
		public static event Action UserFailedEntitlementCheck
		{
			[Token(Token = "0x60007D3")]
			[Address(RVA = "0x1D5B408", Offset = "0x1D5B408", VA = "0x1D5B408")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1186760", Offset = "0x1186760")]
			add
			{
			}
			[Token(Token = "0x60007D4")]
			[Address(RVA = "0x1D5B4BC", Offset = "0x1D5B4BC", VA = "0x1D5B4BC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1186770", Offset = "0x1186770")]
			remove
			{
			}
		}

		[Token(Token = "0x14000003")]
		public static event Action UserPassedEntitlementCheck
		{
			[Token(Token = "0x60007D5")]
			[Address(RVA = "0x1D5B570", Offset = "0x1D5B570", VA = "0x1D5B570")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1186780", Offset = "0x1186780")]
			add
			{
			}
			[Token(Token = "0x60007D6")]
			[Address(RVA = "0x1D5B628", Offset = "0x1D5B628", VA = "0x1D5B628")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1186790", Offset = "0x1186790")]
			remove
			{
			}
		}

		[Token(Token = "0x60007D7")]
		[Address(RVA = "0x1D5B6E0", Offset = "0x1D5B6E0", VA = "0x1D5B6E0")]
		private void Start()
		{
		}

		[Token(Token = "0x60007D8")]
		[Address(RVA = "0x1D5BB08", Offset = "0x1D5BB08", VA = "0x1D5BB08")]
		private void EntitlementCheckCallback(Message msg)
		{
		}

		[Token(Token = "0x60007D9")]
		[Address(RVA = "0x1D5B88C", Offset = "0x1D5B88C", VA = "0x1D5B88C")]
		private void HandleEntitlementCheckResult(bool result)
		{
		}

		[Token(Token = "0x60007DA")]
		[Address(RVA = "0x1D5BB28", Offset = "0x1D5BB28", VA = "0x1D5BB28")]
		public EntitlementCheck()
		{
		}
	}
}
namespace MD_Plugin
{
	[Token(Token = "0x2000132")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x1182B14", Offset = "0x1182B14")]
	public class MD_MeshColliderRefresher : MonoBehaviour
	{
		[Token(Token = "0x2000190")]
		public enum RefreshType_
		{
			[Token(Token = "0x4000653")]
			Once,
			[Token(Token = "0x4000654")]
			PerFrame,
			[Token(Token = "0x4000655")]
			Interval,
			[Token(Token = "0x4000656")]
			Never
		}

		[Token(Token = "0x400032E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public RefreshType_ RefreshType;

		[Token(Token = "0x400032F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float IntervalSeconds;

		[Token(Token = "0x4000330")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool Convex_MeshCollider;

		[Token(Token = "0x4000331")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
		public bool IgnoreRaycast;

		[Token(Token = "0x4000332")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public Vector3 ColliderOffset;

		[Token(Token = "0x4000333")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float intervalTimer;

		[Token(Token = "0x60007DB")]
		[Address(RVA = "0x246EA4C", Offset = "0x246EA4C", VA = "0x246EA4C")]
		private void Start()
		{
		}

		[Token(Token = "0x60007DC")]
		[Address(RVA = "0x246EE70", Offset = "0x246EE70", VA = "0x246EE70")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60007DD")]
		[Address(RVA = "0x246F310", Offset = "0x246F310", VA = "0x246F310")]
		public static void MeshCollider_UpdateMeshCollider(GameObject Target, bool Convex)
		{
		}

		[Token(Token = "0x60007DE")]
		[Address(RVA = "0x246EEE8", Offset = "0x246EEE8", VA = "0x246EEE8")]
		public void MeshCollider_UpdateMeshCollider()
		{
		}

		[Token(Token = "0x60007DF")]
		[Address(RVA = "0x246F510", Offset = "0x246F510", VA = "0x246F510")]
		public MD_MeshColliderRefresher()
		{
		}
	}
	[Token(Token = "0x2000133")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x1182B4C", Offset = "0x1182B4C")]
	public class MD_MeshEditorRuntime : MonoBehaviour
	{
		[Token(Token = "0x2000191")]
		public enum _VertexControlMode
		{
			[Token(Token = "0x4000658")]
			MoveVertex,
			[Token(Token = "0x4000659")]
			PushVertex,
			[Token(Token = "0x400065A")]
			PullVertex,
			[Token(Token = "0x400065B")]
			SculptVertex
		}

		[Token(Token = "0x2000192")]
		public enum pp_RuntimeFunctions_Internal
		{
			[Token(Token = "0x400065D")]
			UseRaiseOnly,
			[Token(Token = "0x400065E")]
			UseRaiseLowerOnly,
			[Token(Token = "0x400065F")]
			UseRaiseLowerRevertOnly
		}

		[Token(Token = "0x2000193")]
		public enum ppAXIS_MovingTo_
		{
			[Token(Token = "0x4000661")]
			X,
			[Token(Token = "0x4000662")]
			Y,
			[Token(Token = "0x4000663")]
			Z
		}

		[Token(Token = "0x2000194")]
		private static class AxisEditor_Utilities
		{
			[Token(Token = "0x4000664")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static Texture2D GridTexture;

			[Token(Token = "0x60009C2")]
			[Address(RVA = "0x180B69C", Offset = "0x180B69C", VA = "0x180B69C")]
			public static Texture2D GridColor(Color tex)
			{
				return null;
			}

			[Token(Token = "0x60009C3")]
			[Address(RVA = "0x180B7C8", Offset = "0x180B7C8", VA = "0x180B7C8")]
			public static void DrawScreenRectBorder(Rect re, float thic, Color c, Color mainC)
			{
			}

			[Token(Token = "0x60009C4")]
			[Address(RVA = "0x180BB80", Offset = "0x180BB80", VA = "0x180BB80")]
			public static Rect GetScreenRect(Vector3 screenPosition1, Vector3 screenPosition2)
			{
				return default(Rect);
			}

			[Token(Token = "0x60009C5")]
			[Address(RVA = "0x180BA34", Offset = "0x180BA34", VA = "0x180BA34")]
			public static void DrawScreenRect(Rect rect, Color color, Color mainCol)
			{
			}

			[Token(Token = "0x60009C6")]
			[Address(RVA = "0x180BC94", Offset = "0x180BC94", VA = "0x180BC94")]
			public static Bounds GetViewportBounds(Camera camera, Vector3 screenPosition1, Vector3 screenPosition2)
			{
				return default(Bounds);
			}

			[Token(Token = "0x60009C7")]
			[Address(RVA = "0x180BE40", Offset = "0x180BE40", VA = "0x180BE40")]
			public static bool IsInsideSelection(Camera camSender, Vector3 MousePos, GameObject ObjectInsideSelection)
			{
				return default(bool);
			}

			[Token(Token = "0x60009C8")]
			[Address(RVA = "0x180BEF8", Offset = "0x180BEF8", VA = "0x180BEF8")]
			public static Vector3 FindCenterPoint(Transform[] Senders)
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x4000334")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool ppAXIS_EDITOR;

		[Token(Token = "0x4000335")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public _VertexControlMode ppVertexControlMode;

		[Token(Token = "0x4000336")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool ppMobileSuppored;

		[Token(Token = "0x4000337")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public ParticleSystem ppHoldingEffect;

		[Token(Token = "0x4000338")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool ppMakeInterativePoint;

		[Token(Token = "0x4000339")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
		public bool ppAttachToSender;

		[Token(Token = "0x400033A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x32")]
		public bool ppLockAxis_X;

		[Token(Token = "0x400033B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x33")]
		public bool ppLockAxis_Y;

		[Token(Token = "0x400033C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public bool ppLockAxis_Z;

		[Token(Token = "0x400033D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float ppEffectRate;

		[Token(Token = "0x400033E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private float currRate;

		[Token(Token = "0x400033F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public bool ppEnableRigidbodyAfterHit;

		[Token(Token = "0x4000340")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public pp_RuntimeFunctions_Internal pp_SculptingRuntimeFunctions;

		[Token(Token = "0x4000341")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public KeyCode ppInput_Sculpt_Raise;

		[Token(Token = "0x4000342")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public KeyCode ppInput_Sculpt_Lower;

		[Token(Token = "0x4000343")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public KeyCode ppInput_Sculpt_Revert;

		[Token(Token = "0x4000344")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public float ppSculpt_Radius;

		[Token(Token = "0x4000345")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public float ppSculpt_Strength;

		[Token(Token = "0x4000346")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public float ppVertexSpeed;

		[Token(Token = "0x4000347")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public bool ppRaycastSpecificPoints;

		[Token(Token = "0x4000348")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public string ppSpecialTag;

		[Token(Token = "0x4000349")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public KeyCode ppInput;

		[Token(Token = "0x400034A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		public bool ppCursorIsOrigin;

		[Token(Token = "0x400034B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x75")]
		public bool ppLockAndHideCursor;

		[Token(Token = "0x400034C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x76")]
		public bool ppPointRay;

		[Token(Token = "0x400034D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public float ppSphericalRayRadius;

		[Token(Token = "0x400034E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		public bool ppShowGraphic;

		[Token(Token = "0x400034F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private GameObject pp_Graphic_Sphere;

		[Token(Token = "0x4000350")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private LineRenderer pp_Graphic_Point;

		[Token(Token = "0x4000351")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public float ppGraphic_Size;

		[Token(Token = "0x4000352")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public GameObject ppAXIS_AxisObject;

		[Token(Token = "0x4000353")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public MD_MeshProEditor ppAXIS_TargetObject;

		[Token(Token = "0x4000354")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public KeyCode ppAXIS_SelectionInput;

		[Token(Token = "0x4000355")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		public KeyCode ppAXIS_AddPointsInput;

		[Token(Token = "0x4000356")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public KeyCode ppAXIS_RemovePointsInput;

		[Token(Token = "0x4000357")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		public bool ppAXIS_LocalSpace;

		[Token(Token = "0x4000358")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public float ppAXIS_Speed;

		[Token(Token = "0x4000359")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		private Color ppAXIS_StoragePointColor;

		[Token(Token = "0x400035A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		public Color ppAXIS_SelectedPointColor;

		[Token(Token = "0x400035B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		public Color ppAXIS_SelectionGridColor;

		[Token(Token = "0x400035C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
		private bool ppAXIS_Selecting;

		[Token(Token = "0x400035D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xED")]
		private bool ppAXIS_Moving;

		[Token(Token = "0x400035E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		public ppAXIS_MovingTo_ ppAXIS_MovingTo;

		[Token(Token = "0x400035F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
		private Vector3 ppAXIS_CursorPosOrigin;

		[Token(Token = "0x4000360")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		public List<Transform> ppAXIS_TotalPoints;

		[Token(Token = "0x4000361")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		public List<Transform> ppAXIS_SelectedPoints;

		[Token(Token = "0x4000362")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private GameObject ppAXIS_GroupSelector;

		[Token(Token = "0x4000363")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		public List<Transform> ppAXIS_UndoStoredObjects;

		[Token(Token = "0x4000364")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private Camera cam;

		[Token(Token = "0x4000365")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		private GameObject SelectedPoint;

		[Token(Token = "0x4000366")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private ParticleSystem CurrentHoldingEffect;

		[Token(Token = "0x4000367")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		private int storedLayer;

		[Token(Token = "0x4000368")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		private Transform storedparent;

		[Token(Token = "0x4000369")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		private float HitDistance;

		[Token(Token = "0x400036A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		private GameObject RigidTarget;

		[Token(Token = "0x400036B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		private MDM_SculptingPro LastHit;

		[Token(Token = "0x400036C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		private bool UpdatedCollider;

		[Token(Token = "0x60007E0")]
		[Address(RVA = "0x246F594", Offset = "0x246F594", VA = "0x246F594")]
		private void Start()
		{
		}

		[Token(Token = "0x60007E1")]
		[Address(RVA = "0x246FD08", Offset = "0x246FD08", VA = "0x246FD08")]
		private void Update()
		{
		}

		[Token(Token = "0x60007E2")]
		[Address(RVA = "0x246FD18", Offset = "0x246FD18", VA = "0x246FD18")]
		private void InternalProcess_NonAxisEditor()
		{
		}

		[Token(Token = "0x60007E3")]
		[Address(RVA = "0x2470400", Offset = "0x2470400", VA = "0x2470400")]
		private void InternalProcess_AxisEditor()
		{
		}

		[Token(Token = "0x60007E4")]
		[Address(RVA = "0x24730B4", Offset = "0x24730B4", VA = "0x24730B4")]
		private bool InternalAxis_CheckSideFunctions()
		{
			return default(bool);
		}

		[Token(Token = "0x60007E5")]
		[Address(RVA = "0x24730F8", Offset = "0x24730F8", VA = "0x24730F8")]
		private void InternalAxis_RefreshBounds([Optional] Transform center)
		{
		}

		[Token(Token = "0x60007E6")]
		[Address(RVA = "0x24734B8", Offset = "0x24734B8", VA = "0x24734B8")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x60007E7")]
		[Address(RVA = "0x246F918", Offset = "0x246F918", VA = "0x246F918")]
		public void AXIS_SwitchTarget(MD_MeshProEditor Target)
		{
		}

		[Token(Token = "0x60007E8")]
		[Address(RVA = "0x2473610", Offset = "0x2473610", VA = "0x2473610")]
		public void AXIS_Undo()
		{
		}

		[Token(Token = "0x60007E9")]
		[Address(RVA = "0x2473BFC", Offset = "0x2473BFC", VA = "0x2473BFC")]
		public void NON_AXIS_SwitchControlMode(int index)
		{
		}

		[Token(Token = "0x60007EA")]
		[Address(RVA = "0x247153C", Offset = "0x247153C", VA = "0x247153C")]
		public void NON_AXIS_MoveVertex(Ray ray, RaycastHit hit, bool Raycast)
		{
		}

		[Token(Token = "0x60007EB")]
		[Address(RVA = "0x2471D10", Offset = "0x2471D10", VA = "0x2471D10")]
		public void NON_AXIS_PushVertex(Ray ray, RaycastHit hit, bool Raycast)
		{
		}

		[Token(Token = "0x60007EC")]
		[Address(RVA = "0x2473C4C", Offset = "0x2473C4C", VA = "0x2473C4C")]
		private void AddRigidbodyToHitObject()
		{
		}

		[Token(Token = "0x60007ED")]
		[Address(RVA = "0x2472308", Offset = "0x2472308", VA = "0x2472308")]
		public void NON_AXIS_PullVertex(Ray ray, RaycastHit hit, bool Raycast)
		{
		}

		[Token(Token = "0x60007EE")]
		[Address(RVA = "0x247298C", Offset = "0x247298C", VA = "0x247298C")]
		private void NON_AXIS_SculptVertex(Ray ray, RaycastHit hit, bool Raycast)
		{
		}

		[Token(Token = "0x60007EF")]
		[Address(RVA = "0x2473E60", Offset = "0x2473E60", VA = "0x2473E60")]
		public void SS_Funct_ChangeRadius(float size)
		{
		}

		[Token(Token = "0x60007F0")]
		[Address(RVA = "0x2473E68", Offset = "0x2473E68", VA = "0x2473E68")]
		public void SS_Funct_ChangeRadius(Slider size)
		{
		}

		[Token(Token = "0x60007F1")]
		[Address(RVA = "0x2473EA8", Offset = "0x2473EA8", VA = "0x2473EA8")]
		public void SS_Funct_ChangeStrength(float strength)
		{
		}

		[Token(Token = "0x60007F2")]
		[Address(RVA = "0x2473EB0", Offset = "0x2473EB0", VA = "0x2473EB0")]
		public void SS_Funct_ChangeStrength(Slider strength)
		{
		}

		[Token(Token = "0x60007F3")]
		[Address(RVA = "0x2473C0C", Offset = "0x2473C0C", VA = "0x2473C0C")]
		private bool Internal_GetControlInput(bool KeyDown = true)
		{
			return default(bool);
		}

		[Token(Token = "0x60007F4")]
		[Address(RVA = "0x2473EF0", Offset = "0x2473EF0", VA = "0x2473EF0")]
		public MD_MeshEditorRuntime()
		{
		}
	}
	[Token(Token = "0x2000134")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x1182B84", Offset = "0x1182B84")]
	public class MD_MeshPaint : MonoBehaviour
	{
		[Token(Token = "0x2000195")]
		public enum MP_PlatformInternal
		{
			[Token(Token = "0x4000666")]
			PC,
			[Token(Token = "0x4000667")]
			VR,
			[Token(Token = "0x4000668")]
			Mobile
		}

		[Token(Token = "0x2000196")]
		public enum MP_MeshPaintTypeInternal
		{
			[Token(Token = "0x400066A")]
			DrawOnScreen,
			[Token(Token = "0x400066B")]
			DrawOnRaycastHit,
			[Token(Token = "0x400066C")]
			CustomDraw
		}

		[Token(Token = "0x2000197")]
		public enum MP_RotationModeInternal
		{
			[Token(Token = "0x400066E")]
			FollowOneAxis,
			[Token(Token = "0x400066F")]
			FollowSpatialAxis
		}

		[Token(Token = "0x2000198")]
		public enum MP_ShapeTypeInternal
		{
			[Token(Token = "0x4000671")]
			Plane,
			[Token(Token = "0x4000672")]
			Triangle,
			[Token(Token = "0x4000673")]
			Cube
		}

		[Token(Token = "0x2000199")]
		public enum MeshPaintModeInternal
		{
			[Token(Token = "0x4000675")]
			StartPaint,
			[Token(Token = "0x4000676")]
			Painting,
			[Token(Token = "0x4000677")]
			EndPaint
		}

		[Token(Token = "0x400036D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private List<Vector3> internal_vertices;

		[Token(Token = "0x400036E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private List<int> internal_triangles;

		[Token(Token = "0x400036F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private List<Vector2> internal_uvs;

		[Token(Token = "0x4000370")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Transform internal_p1;

		[Token(Token = "0x4000371")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Transform internal_p2;

		[Token(Token = "0x4000372")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Transform internal_p3;

		[Token(Token = "0x4000373")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Transform internal_p4;

		[Token(Token = "0x4000374")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Transform internal_p5;

		[Token(Token = "0x4000375")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Transform internal_p6;

		[Token(Token = "0x4000376")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Transform internal_p7;

		[Token(Token = "0x4000377")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Transform internal_p8;

		[Token(Token = "0x4000378")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Transform internal_BrushHelper;

		[Token(Token = "0x4000379")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Transform internal_BrushRoot;

		[Token(Token = "0x400037A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public MP_PlatformInternal MP_Platform;

		[Token(Token = "0x400037B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		public bool MP_Platform_Oculus;

		[Token(Token = "0x400037C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public KeyCode MP_INPUT_PC_MeshPaintInput;

		[Token(Token = "0x400037D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		public float MP_BrushSize;

		[Token(Token = "0x400037E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public bool MP_SmoothBrushMovement;

		[Token(Token = "0x400037F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		public float MP_BSmoothMSpeed;

		[Token(Token = "0x4000380")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public bool MP_SmoothBrushRotation;

		[Token(Token = "0x4000381")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		public float MP_BSmoothRSpeed;

		[Token(Token = "0x4000382")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public bool MP_DistanceLimitation;

		[Token(Token = "0x4000383")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		public float MP_MinDistanceLimit;

		[Token(Token = "0x4000384")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public bool MP_ConnectMeshOnRelease;

		[Token(Token = "0x4000385")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		public MP_MeshPaintTypeInternal MP_MeshPaintType;

		[Token(Token = "0x4000386")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public MP_RotationModeInternal MP_RotationMode;

		[Token(Token = "0x4000387")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		public Vector3 MP_RotationmodeOffset;

		[Token(Token = "0x4000388")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public MP_ShapeTypeInternal MP_ShapeType;

		[Token(Token = "0x4000389")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		public bool MP_TypeScreen_UseMainCamera;

		[Token(Token = "0x400038A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public Camera MP_TypeScreen_TargetCamera;

		[Token(Token = "0x400038B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public float MP_TypeScreen_Depth;

		[Token(Token = "0x400038C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		public bool MP_TypeRaycast_RaycastFromCursor;

		[Token(Token = "0x400038D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		public Transform MP_TypeRaycast_RaycastOriginFORWARD;

		[Token(Token = "0x400038E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		public LayerMask MP_TypeRaycast_AllowedLayers;

		[Token(Token = "0x400038F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		public bool MP_TypeRaycast_CastAllObjects;

		[Token(Token = "0x4000390")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		public string MP_TypeRaycast_TagForRaycast;

		[Token(Token = "0x4000391")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		public Vector3 MP_TypeRaycast_BrushOffset;

		[Token(Token = "0x4000392")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xFC")]
		public bool MP_TypeRaycast_IgnoreSelfCasting;

		[Token(Token = "0x4000393")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xFD")]
		public bool MP_TypeCustom_DRAW;

		[Token(Token = "0x4000394")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xFE")]
		private bool MP_TypeCustom_DRAWStart;

		[Token(Token = "0x4000395")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xFF")]
		public bool MP_TypeCustom_CustomBrushTransform;

		[Token(Token = "0x4000396")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		public bool MP_TypeCustom_EnableSmartRotation;

		[Token(Token = "0x4000397")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		public Transform MP_TypeCustom_BrushParent;

		[Token(Token = "0x4000398")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		public int MP_CurrentlySelectedAppearanceSlot;

		[Token(Token = "0x4000399")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x114")]
		public bool MP_MaterialSlots;

		[Token(Token = "0x400039A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		public Material[] MP_Color_AvailableMaterials;

		[Token(Token = "0x400039B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		public Color[] MP_Color_AvailableColors;

		[Token(Token = "0x400039C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		public bool MP_FollowBrushTransform;

		[Token(Token = "0x400039D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		public Transform MP_ObjectForFollowing;

		[Token(Token = "0x400039E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		public bool MP_HideCustomBrushIfNotRaycasting;

		[Token(Token = "0x400039F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x139")]
		public bool MP_RefreshMeshCollider;

		[Token(Token = "0x40003A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		private GameObject internal_currentlyTargetMesh;

		[Token(Token = "0x40003A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		private Vector3 internal_ppplastposition;

		[Token(Token = "0x40003A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x154")]
		private Vector3 internal_ppplastpress;

		[Token(Token = "0x40003A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		private Quaternion internal_ppplastrotation;

		[Token(Token = "0x40003A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		private int UVFixer;

		[Token(Token = "0x40003A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x174")]
		public MeshPaintModeInternal MeshPaintMode;

		[Token(Token = "0x60007F5")]
		[Address(RVA = "0x180E6DC", Offset = "0x180E6DC", VA = "0x180E6DC")]
		private void Awake()
		{
		}

		[Token(Token = "0x60007F6")]
		[Address(RVA = "0x180F240", Offset = "0x180F240", VA = "0x180F240")]
		private void Start()
		{
		}

		[Token(Token = "0x60007F7")]
		[Address(RVA = "0x180F420", Offset = "0x180F420", VA = "0x180F420")]
		private void Update()
		{
		}

		[Token(Token = "0x60007F8")]
		[Address(RVA = "0x180F688", Offset = "0x180F688", VA = "0x180F688")]
		private void INTERNAL_UPDATE_DrawOnScreen()
		{
		}

		[Token(Token = "0x60007F9")]
		[Address(RVA = "0x18104D0", Offset = "0x18104D0", VA = "0x18104D0")]
		private Vector3 INTERNAL_GetScreenPosition()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60007FA")]
		[Address(RVA = "0x180FA04", Offset = "0x180FA04", VA = "0x180FA04")]
		private void INTERNAL_UPDATE_DrawOnRaycast()
		{
		}

		[Token(Token = "0x60007FB")]
		[Address(RVA = "0x18105B8", Offset = "0x18105B8", VA = "0x18105B8")]
		private Vector3 INTERNAL_GetRaycastPosition()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60007FC")]
		[Address(RVA = "0x180FE14", Offset = "0x180FE14", VA = "0x180FE14")]
		private void INTERNAL_UPDATE_DrawOnCustom()
		{
		}

		[Token(Token = "0x60007FD")]
		[Address(RVA = "0x1810544", Offset = "0x1810544", VA = "0x1810544")]
		private bool INTERNAL_GetInput(bool Up = false)
		{
			return default(bool);
		}

		[Token(Token = "0x60007FE")]
		[Address(RVA = "0x181085C", Offset = "0x181085C", VA = "0x181085C")]
		private void INTERNAL_ChangeBrushSize(float size)
		{
		}

		[Token(Token = "0x60007FF")]
		[Address(RVA = "0x1810D18", Offset = "0x1810D18", VA = "0x1810D18")]
		private void INTERNAL_Generation_Triangle(Vector3 Position, MeshPaintModeInternal MeshPaintMode)
		{
		}

		[Token(Token = "0x6000800")]
		[Address(RVA = "0x181153C", Offset = "0x181153C", VA = "0x181153C")]
		private void INTERNAL_Generation_Plane(Vector3 Position, MeshPaintModeInternal MeshPaintMode)
		{
		}

		[Token(Token = "0x6000801")]
		[Address(RVA = "0x1811B08", Offset = "0x1811B08", VA = "0x1811B08")]
		private void INTERNAL_Generation_Cube(Vector3 Position, MeshPaintModeInternal MeshPaintMode)
		{
		}

		[Token(Token = "0x6000802")]
		[Address(RVA = "0x1811344", Offset = "0x1811344", VA = "0x1811344")]
		public void PUBLIC_CreateNewPaintPattern(string MeshName = "TargetMesh", bool addCollider = true)
		{
		}

		[Token(Token = "0x6000803")]
		[Address(RVA = "0x1810194", Offset = "0x1810194", VA = "0x1810194")]
		public void PUBLIC_PaintMesh(Vector3 Position, MeshPaintModeInternal MeshPaintMode)
		{
		}

		[Token(Token = "0x6000804")]
		[Address(RVA = "0x18124D0", Offset = "0x18124D0", VA = "0x18124D0")]
		public void PUBLIC_ChangeBrushSize(float size)
		{
		}

		[Token(Token = "0x6000805")]
		[Address(RVA = "0x18124D8", Offset = "0x18124D8", VA = "0x18124D8")]
		public void PUBLIC_IncreaseBrushSize(float size)
		{
		}

		[Token(Token = "0x6000806")]
		[Address(RVA = "0x18124E8", Offset = "0x18124E8", VA = "0x18124E8")]
		public void PUBLIC_DecreaseBrushSize(float size)
		{
		}

		[Token(Token = "0x6000807")]
		[Address(RVA = "0x18124F8", Offset = "0x18124F8", VA = "0x18124F8")]
		public void PUBLIC_ChangeBrushSize(Slider size)
		{
		}

		[Token(Token = "0x6000808")]
		[Address(RVA = "0x1812538", Offset = "0x1812538", VA = "0x1812538")]
		public void PUBLIC_EnableDisableDrawing(bool activation)
		{
		}

		[Token(Token = "0x6000809")]
		[Address(RVA = "0x1812544", Offset = "0x1812544", VA = "0x1812544")]
		public void PUBLIC_ChangeAppearanceIndex(int index)
		{
		}

		[Token(Token = "0x600080A")]
		[Address(RVA = "0x181254C", Offset = "0x181254C", VA = "0x181254C")]
		public void PUBLIC_ChangeShapeType(int ShapeT)
		{
		}

		[Token(Token = "0x600080B")]
		[Address(RVA = "0x1812554", Offset = "0x1812554", VA = "0x1812554")]
		public MD_MeshPaint()
		{
		}
	}
	[Token(Token = "0x2000135")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x1182BBC", Offset = "0x1182BBC")]
	public class MD_MeshProEditor : MonoBehaviour
	{
		[Token(Token = "0x200019A")]
		public enum SelectedModification_
		{
			[Token(Token = "0x4000679")]
			None,
			[Token(Token = "0x400067A")]
			Vertices,
			[Token(Token = "0x400067B")]
			Collider,
			[Token(Token = "0x400067C")]
			Identity,
			[Token(Token = "0x400067D")]
			Mesh
		}

		[Token(Token = "0x40003A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public SelectedModification_ SelectedModification;

		[Token(Token = "0x40003A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public bool ppNewReferenceAfterCopy;

		[Token(Token = "0x40003A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D")]
		public bool ppDynamicMesh;

		[Token(Token = "0x40003A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E")]
		public bool ppAnimationMode;

		[Token(Token = "0x40003AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F")]
		public bool ppOptimizeMesh;

		[Token(Token = "0x40003AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform ppVerticesRoot;

		[Token(Token = "0x40003AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool ppCustomVerticePattern;

		[Token(Token = "0x40003AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
		public bool ppUseCustomColor;

		[Token(Token = "0x40003AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public Color ppCustomVerticeColor;

		[Token(Token = "0x40003AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public GameObject ppVerticePatternObject;

		[Token(Token = "0x40003B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public string ppINFO_MeshName;

		[Token(Token = "0x40003B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public int ppINFO_Vertices;

		[Token(Token = "0x40003B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public int ppINFO_Triangles;

		[Token(Token = "0x40003B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public int ppINFO_Normals;

		[Token(Token = "0x40003B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public int ppINFO_Uvs;

		[Token(Token = "0x40003B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Vector3[] originalVertices;

		[Token(Token = "0x40003B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public int[] originalTriangles;

		[Token(Token = "0x40003B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Vector3[] originalNormals;

		[Token(Token = "0x40003B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Vector2[] originalUVS;

		[Token(Token = "0x40003B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public List<Vector3> verts;

		[Token(Token = "0x40003BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public List<Transform> points;

		[Token(Token = "0x40003BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Material DefaultMaterial;

		[Token(Token = "0x40003BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static int VerticesLimit;

		[Token(Token = "0x40003BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private bool DeselectObjectAfterVerticeLimitAgreement;

		[Token(Token = "0x40003BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x99")]
		public bool _AlreadyAwake;

		[Token(Token = "0x40003BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9A")]
		public bool _BornAsSkinnedMesh;

		[Token(Token = "0x40003C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public MeshFilter meshF;

		[Token(Token = "0x40003C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public bool ppEnablePerformanceSaver;

		[Token(Token = "0x40003C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		public Vector3 ppPerformanceZone;

		[Token(Token = "0x40003C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public float ppPerformanceRadius;

		[Token(Token = "0x40003C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		public Vector3 myStartupBounds;

		[Token(Token = "0x40003C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private Mesh sourceMesh;

		[Token(Token = "0x40003C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private Mesh workingMesh;

		[Token(Token = "0x600080C")]
		[Address(RVA = "0x1812784", Offset = "0x1812784", VA = "0x1812784")]
		private void Awake()
		{
		}

		[Token(Token = "0x600080D")]
		[Address(RVA = "0x1812B00", Offset = "0x1812B00", VA = "0x1812B00")]
		public static bool MD_INTERNAL_TECH_CheckModifiers(GameObject Sender, string ExceptionBehaviour = "")
		{
			return default(bool);
		}

		[Token(Token = "0x600080E")]
		[Address(RVA = "0x1812DCC", Offset = "0x1812DCC", VA = "0x1812DCC")]
		private void MD_INTERNAL_TECH_ResetMeshReference()
		{
		}

		[Token(Token = "0x600080F")]
		[Address(RVA = "0x181304C", Offset = "0x181304C", VA = "0x181304C")]
		private void MD_INTERNAL_TECH_GetMeshInfo()
		{
		}

		[Token(Token = "0x6000810")]
		[Address(RVA = "0x1813FB4", Offset = "0x1813FB4", VA = "0x1813FB4")]
		public void MD_INTERNAL_TECH_SaveMeshToAssets()
		{
		}

		[Token(Token = "0x6000811")]
		[Address(RVA = "0x18140F0", Offset = "0x18140F0", VA = "0x18140F0")]
		private void Update()
		{
		}

		[Token(Token = "0x6000812")]
		[Address(RVA = "0x180DF24", Offset = "0x180DF24", VA = "0x180DF24")]
		public void MD_INTERNAL_FUNCT_UpdateMeshState()
		{
		}

		[Token(Token = "0x6000813")]
		[Address(RVA = "0x1814100", Offset = "0x1814100", VA = "0x1814100")]
		public void MeshEditor_ShowHideVertices(bool Activation)
		{
		}

		[Token(Token = "0x6000814")]
		[Address(RVA = "0x1814234", Offset = "0x1814234", VA = "0x1814234")]
		public void MeshEditor_IgnoreRaycastVertices(bool IgnoreRaycast)
		{
		}

		[Token(Token = "0x6000815")]
		[Address(RVA = "0x1813174", Offset = "0x1813174", VA = "0x1813174")]
		public void MeshEditor_CreateVerticeEditor(bool PassTheVerticeLimit = false)
		{
		}

		[Token(Token = "0x6000816")]
		[Address(RVA = "0x180E454", Offset = "0x180E454", VA = "0x180E454")]
		public void MeshEditor_ClearVerticeEditor()
		{
		}

		[Token(Token = "0x6000817")]
		[Address(RVA = "0x18147F4", Offset = "0x18147F4", VA = "0x18147F4")]
		public void MeshEditor_CombineMesh()
		{
		}

		[Token(Token = "0x6000818")]
		[Address(RVA = "0x1814D78", Offset = "0x1814D78", VA = "0x1814D78")]
		public void MeshEditor_QuickCombineMesh()
		{
		}

		[Token(Token = "0x6000819")]
		[Address(RVA = "0x1815228", Offset = "0x1815228", VA = "0x1815228")]
		public void MeshEditor_CreateNewReference()
		{
		}

		[Token(Token = "0x600081A")]
		[Address(RVA = "0x1815708", Offset = "0x1815708", VA = "0x1815708")]
		public void MeshEditor_RestoreMeshToOriginal()
		{
		}

		[Token(Token = "0x600081B")]
		[Address(RVA = "0x1815910", Offset = "0x1815910", VA = "0x1815910")]
		public void MeshEditor_CompileToMeshFilter()
		{
		}

		[Token(Token = "0x600081C")]
		[Address(RVA = "0x1815DA8", Offset = "0x1815DA8", VA = "0x1815DA8")]
		public void MeshEditor_SmoothMesh(float Intensity = 0.5f)
		{
		}

		[Token(Token = "0x600081D")]
		[Address(RVA = "0x1816148", Offset = "0x1816148", VA = "0x1816148")]
		private static Mesh MD_REQUIRER_SmoothMesh(Mesh mesh)
		{
			return null;
		}

		[Token(Token = "0x600081E")]
		[Address(RVA = "0x1816728", Offset = "0x1816728", VA = "0x1816728")]
		public void MeshEditor_SubdivideMesh(int Level)
		{
		}

		[Token(Token = "0x600081F")]
		[Address(RVA = "0x1816ADC", Offset = "0x1816ADC", VA = "0x1816ADC")]
		public static void MeshEditor_STATIC_CreateNewReference(GameObject EntryObject)
		{
		}

		[Token(Token = "0x6000820")]
		[Address(RVA = "0x1816ED4", Offset = "0x1816ED4", VA = "0x1816ED4")]
		public static void MeshEditor_STATIC_QuickCombineMesh(MeshFilter target)
		{
		}

		[Token(Token = "0x6000821")]
		[Address(RVA = "0x1816E14", Offset = "0x1816E14", VA = "0x1816E14")]
		public MD_MeshProEditor()
		{
		}
	}
	[Token(Token = "0x2000136")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x1182C08", Offset = "0x1182C08")]
	public class MDM_Bend : MonoBehaviour
	{
		[Token(Token = "0x200019B")]
		public enum Direction_
		{
			[Token(Token = "0x400067F")]
			X,
			[Token(Token = "0x4000680")]
			Y,
			[Token(Token = "0x4000681")]
			Z
		}

		[Token(Token = "0x40003C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Direction_ ppBendDirection;

		[Token(Token = "0x40003C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float ppAmount;

		[Token(Token = "0x40003C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private float AmountStorage;

		[Token(Token = "0x40003CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public bool ppCreateNewReference;

		[Token(Token = "0x40003CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private List<Vector3> originalVertices;

		[Token(Token = "0x40003CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private MeshFilter meshF;

		[Token(Token = "0x6000823")]
		[Address(RVA = "0x245DE10", Offset = "0x245DE10", VA = "0x245DE10")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000824")]
		[Address(RVA = "0x245E024", Offset = "0x245E024", VA = "0x245E024")]
		private void Update()
		{
		}

		[Token(Token = "0x6000825")]
		[Address(RVA = "0x245E378", Offset = "0x245E378", VA = "0x245E378")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000826")]
		[Address(RVA = "0x245E1E0", Offset = "0x245E1E0", VA = "0x245E1E0")]
		private Vector3 BendObject(Vector3 origin, float direction)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000827")]
		[Address(RVA = "0x245E384", Offset = "0x245E384", VA = "0x245E384")]
		public void BEND(Slider Entry)
		{
		}

		[Token(Token = "0x6000828")]
		[Address(RVA = "0x245E3C4", Offset = "0x245E3C4", VA = "0x245E3C4")]
		public void BEND(float Entry)
		{
		}

		[Token(Token = "0x6000829")]
		[Address(RVA = "0x245E3CC", Offset = "0x245E3CC", VA = "0x245E3CC")]
		public MDM_Bend()
		{
		}
	}
	[Token(Token = "0x2000137")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x1182C54", Offset = "0x1182C54")]
	[ExecuteInEditMode]
	public class MDM_FFD : MonoBehaviour
	{
		[Token(Token = "0x200019C")]
		public enum FFDType_
		{
			[Token(Token = "0x4000683")]
			OnePointed,
			[Token(Token = "0x4000684")]
			TwoPointed,
			[Token(Token = "0x4000685")]
			ThreePointed,
			[Token(Token = "0x4000686")]
			FourPointed
		}

		[Token(Token = "0x40003CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool ppUpdateEveryFrame;

		[Token(Token = "0x40003CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Vector3[] ppGeneratedPoints;

		[Token(Token = "0x40003CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public List<Vector3> ppGeneratedPointsOrigins;

		[Token(Token = "0x40003D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public MeshFilter meshF;

		[Token(Token = "0x40003D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public FFDType_ FFDType;

		[Token(Token = "0x40003D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Transform ppWeightNode0;

		[Token(Token = "0x40003D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Transform ppWeightNode1;

		[Token(Token = "0x40003D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Transform ppWeightNode2;

		[Token(Token = "0x40003D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform ppWeightNode3;

		[Token(Token = "0x40003D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Vector3 node0;

		[Token(Token = "0x40003D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private Vector3 node1;

		[Token(Token = "0x40003D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Vector3 node2;

		[Token(Token = "0x40003D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private Vector3 node3;

		[Token(Token = "0x40003DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Vector3 node0StartPos;

		[Token(Token = "0x40003DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private Vector3 node1StartPos;

		[Token(Token = "0x40003DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Vector3 node2StartPos;

		[Token(Token = "0x40003DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		private Vector3 node3StartPos;

		[Token(Token = "0x40003DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1186238", Offset = "0x1186238")]
		public float ppWeight;

		[Token(Token = "0x40003DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		public float ppWeightMultiplier;

		[Token(Token = "0x40003E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public float ppWeightDensity;

		[Token(Token = "0x40003E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1186250", Offset = "0x1186250")]
		public float ppWeightEffectorA;

		[Token(Token = "0x40003E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1186268", Offset = "0x1186268")]
		public float ppWeightEffectorB;

		[Token(Token = "0x40003E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1186280", Offset = "0x1186280")]
		public float ppWeightEffectorC;

		[Token(Token = "0x40003E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		public bool ppCreateNewReference;

		[Token(Token = "0x40003E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD9")]
		public bool ppMultithreadingSupported;

		[Token(Token = "0x40003E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private Thread Multithread;

		[Token(Token = "0x40003E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private ManualResetEvent Multithread_ManualEvent;

		[Token(Token = "0x40003E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private bool threadDone;

		[Token(Token = "0x40003E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1186298", Offset = "0x1186298")]
		public int ppMultithreadingProcessDelay;

		[Token(Token = "0x600082A")]
		[Address(RVA = "0x245E444", Offset = "0x245E444", VA = "0x245E444")]
		private void Awake()
		{
		}

		[Token(Token = "0x600082B")]
		[Address(RVA = "0x245E684", Offset = "0x245E684", VA = "0x245E684")]
		private void Start()
		{
		}

		[Token(Token = "0x600082C")]
		[Address(RVA = "0x245E774", Offset = "0x245E774", VA = "0x245E774")]
		private void OnDrawGizmos()
		{
		}

		[Token(Token = "0x600082D")]
		[Address(RVA = "0x245EE84", Offset = "0x245EE84", VA = "0x245EE84")]
		private void Update()
		{
		}

		[Token(Token = "0x600082E")]
		[Address(RVA = "0x245F788", Offset = "0x245F788", VA = "0x245F788")]
		public void FFD_UpdateMesh()
		{
		}

		[Token(Token = "0x600082F")]
		[Address(RVA = "0x246081C", Offset = "0x246081C", VA = "0x246081C")]
		public void FFD_ApplyWeights()
		{
		}

		[Token(Token = "0x6000830")]
		[Address(RVA = "0x24600C4", Offset = "0x24600C4", VA = "0x24600C4")]
		private Vector3 InterpolationOfFourPointedFFD(Vector3 p, Vector3 n0, Vector3 n1, Vector3 n2, Vector3 n3)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000831")]
		[Address(RVA = "0x245FCBC", Offset = "0x245FCBC", VA = "0x245FCBC")]
		private Vector3 InterpolationOfThreePointedFFD(Vector3 p, Vector3 n0, Vector3 n1, Vector3 n2)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000832")]
		[Address(RVA = "0x245FA5C", Offset = "0x245FA5C", VA = "0x245FA5C")]
		private Vector3 InterpolationOfTwoPointedFFD(Vector3 p, Vector3 n0, Vector3 n1)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000833")]
		[Address(RVA = "0x245F970", Offset = "0x245F970", VA = "0x245F970")]
		private Vector3 VecInterpolation(Vector3 A, Vector3 B, float t)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000834")]
		[Address(RVA = "0x2460A4C", Offset = "0x2460A4C", VA = "0x2460A4C")]
		private void ffdThreadWork()
		{
		}

		[Token(Token = "0x6000835")]
		[Address(RVA = "0x2460EC0", Offset = "0x2460EC0", VA = "0x2460EC0")]
		private void OnApplicationQuit()
		{
		}

		[Token(Token = "0x6000836")]
		[Address(RVA = "0x2460F0C", Offset = "0x2460F0C", VA = "0x2460F0C")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000837")]
		[Address(RVA = "0x2460F58", Offset = "0x2460F58", VA = "0x2460F58")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000838")]
		[Address(RVA = "0x2460FA4", Offset = "0x2460FA4", VA = "0x2460FA4")]
		public MDM_FFD()
		{
		}
	}
	[Token(Token = "0x2000138")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x1182CA0", Offset = "0x1182CA0")]
	public class MDM_InteractiveLandscape : MonoBehaviour
	{
		[Token(Token = "0x40003EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool ppDynamicMesh;

		[Token(Token = "0x40003EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		public bool ppAllowRigidbodies;

		[Token(Token = "0x40003EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
		public bool ppMultithreadingSupported;

		[Token(Token = "0x40003ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Thread Multithread;

		[Token(Token = "0x40003EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool ppEnableCustomInteractionSpeed;

		[Token(Token = "0x40003EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
		public bool ppCustomInteraction_Continuous;

		[Token(Token = "0x40003F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float ppInteractionSpeed;

		[Token(Token = "0x40003F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Vector3 ppVerticeDirection;

		[Token(Token = "0x40003F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float ppRadius;

		[Token(Token = "0x40003F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public bool ppFitToObjectSize;

		[Token(Token = "0x40003F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float ppForceDetection;

		[Token(Token = "0x40003F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public bool ppCreateNewReference;

		[Token(Token = "0x40003F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private List<Vector3> originalVertices;

		[Token(Token = "0x40003F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private List<Vector3> storedVertices;

		[Token(Token = "0x40003F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private List<Vector3> startingVertices;

		[Token(Token = "0x40003F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private MeshFilter meshF;

		[Token(Token = "0x40003FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public bool ppRepair;

		[Token(Token = "0x40003FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		public float ppRepairSpeed;

		[Token(Token = "0x40003FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public bool ppCollisionWithSpecificTag;

		[Token(Token = "0x40003FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public string ppCollisionTag;

		[Token(Token = "0x40003FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private bool checkForUpdate_InterSpeed;

		[Token(Token = "0x40003FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x89")]
		private bool checkForUpdate_Repair;

		[Token(Token = "0x4000400")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private Vector3 Thrd_AtPoint;

		[Token(Token = "0x4000401")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private float Thrd_Radius;

		[Token(Token = "0x4000402")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private Vector3 Thrd_Dir;

		[Token(Token = "0x4000403")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Vector3 Thrd_RealPos;

		[Token(Token = "0x4000404")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		private Vector3 Thrd_RealSca;

		[Token(Token = "0x4000405")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private Quaternion Thrd_RealRot;

		[Token(Token = "0x6000839")]
		[Address(RVA = "0x2461068", Offset = "0x2461068", VA = "0x2461068")]
		private void Awake()
		{
		}

		[Token(Token = "0x600083A")]
		[Address(RVA = "0x24612CC", Offset = "0x24612CC", VA = "0x24612CC")]
		private void Start()
		{
		}

		[Token(Token = "0x600083B")]
		[Address(RVA = "0x24613F8", Offset = "0x24613F8", VA = "0x24613F8")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600083C")]
		[Address(RVA = "0x2461AC0", Offset = "0x2461AC0", VA = "0x2461AC0")]
		private void OnCollisionStay(Collision collision)
		{
		}

		[Token(Token = "0x600083D")]
		[Address(RVA = "0x2461F7C", Offset = "0x2461F7C", VA = "0x2461F7C")]
		private void OnCollisionEnter(Collision collision)
		{
		}

		[Token(Token = "0x600083E")]
		[Address(RVA = "0x2461CCC", Offset = "0x2461CCC", VA = "0x2461CCC")]
		public void InteractiveLandscape_ModifyMesh(Vector3 AtPoint, float Radius, Vector3 VerticeDirection)
		{
		}

		[Token(Token = "0x600083F")]
		[Address(RVA = "0x2462138", Offset = "0x2462138", VA = "0x2462138")]
		private void MD_FUNCT_ModifyMesh_Thread()
		{
		}

		[Token(Token = "0x6000840")]
		[Address(RVA = "0x246232C", Offset = "0x246232C", VA = "0x246232C")]
		private Vector3 TransformPoint(Vector3 WorldPos, Quaternion WorldRot, Vector3 WorldScale, Vector3 Point)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000841")]
		[Address(RVA = "0x2462464", Offset = "0x2462464", VA = "0x2462464")]
		private void OnApplicationQuit()
		{
		}

		[Token(Token = "0x6000842")]
		[Address(RVA = "0x24624B0", Offset = "0x24624B0", VA = "0x24624B0")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000843")]
		[Address(RVA = "0x24624FC", Offset = "0x24624FC", VA = "0x24624FC")]
		public void InteractiveLandscape_ModifyMesh(MDM_RaycastEvent RayEvent)
		{
		}

		[Token(Token = "0x6000844")]
		[Address(RVA = "0x24626C0", Offset = "0x24626C0", VA = "0x24626C0")]
		public MDM_InteractiveLandscape()
		{
		}
	}
	[Token(Token = "0x2000139")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x1182CEC", Offset = "0x1182CEC")]
	public class MDM_LandscapeTracking : MonoBehaviour
	{
		[Token(Token = "0x4000406")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Camera LT_virtualTrackCamera;

		[Token(Token = "0x4000407")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public RenderTexture LT_TrackerSource;

		[Token(Token = "0x4000408")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool NotSet;

		[Token(Token = "0x4000409")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float LT_ViewSize;

		[Token(Token = "0x400040A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float LT_VirtCameraHeight;

		[Token(Token = "0x6000845")]
		[Address(RVA = "0x24627DC", Offset = "0x24627DC", VA = "0x24627DC")]
		private void Update()
		{
		}

		[Token(Token = "0x6000846")]
		[Address(RVA = "0x2462A44", Offset = "0x2462A44", VA = "0x2462A44")]
		public MDM_LandscapeTracking()
		{
		}
	}
	[Token(Token = "0x200013A")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x1182D38", Offset = "0x1182D38")]
	public class MDM_MeltController : MonoBehaviour
	{
		[Token(Token = "0x400040B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool ppSelfHeightValue;

		[Token(Token = "0x400040C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform ppTargetHeightValue;

		[Token(Token = "0x400040D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool ppMeltBySurfaceRaycast;

		[Token(Token = "0x400040E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public Vector3 ppRaycastOriginOffset;

		[Token(Token = "0x400040F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Vector3 ppRaycastDirection;

		[Token(Token = "0x4000410")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float ppRaycastDistance;

		[Token(Token = "0x4000411")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public LayerMask ppAllowedLayerMasks;

		[Token(Token = "0x4000412")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public bool ppEnableLinearInterpolationBlend;

		[Token(Token = "0x4000413")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public float ppLinearInterpolationSpeed;

		[Token(Token = "0x4000414")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public bool ppShowEditorGraphic;

		[Token(Token = "0x4000415")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Material ppSelfMaterial;

		[Token(Token = "0x4000416")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Transform ppRealTarget;

		[Token(Token = "0x4000417")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private float targetValue;

		[Token(Token = "0x4000418")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private float targetLerpValue;

		[Token(Token = "0x4000419")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private float starttime;

		[Token(Token = "0x6000847")]
		[Address(RVA = "0x2462A60", Offset = "0x2462A60", VA = "0x2462A60")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x6000848")]
		[Address(RVA = "0x2462C7C", Offset = "0x2462C7C", VA = "0x2462C7C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000849")]
		[Address(RVA = "0x2462CA4", Offset = "0x2462CA4", VA = "0x2462CA4")]
		private void Update()
		{
		}

		[Token(Token = "0x600084A")]
		[Address(RVA = "0x24630C4", Offset = "0x24630C4", VA = "0x24630C4")]
		public MDM_MeltController()
		{
		}
	}
	[Token(Token = "0x200013B")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x1182D84", Offset = "0x1182D84")]
	public class MDM_MeshDamage : MonoBehaviour
	{
		[Token(Token = "0x400041A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool ppDynamicMesh;

		[Token(Token = "0x400041B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Rigidbody ppRigidbody;

		[Token(Token = "0x400041C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool ppAutoForce;

		[Token(Token = "0x400041D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float ppForceAmount;

		[Token(Token = "0x400041E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool ppAutoGenerateRadius;

		[Token(Token = "0x400041F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float ppRadius;

		[Token(Token = "0x4000420")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float ppForceDetection;

		[Token(Token = "0x4000421")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public bool ppContinousDamage;

		[Token(Token = "0x4000422")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3D")]
		public bool ppCollisionWithSpecificTag;

		[Token(Token = "0x4000423")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public string ppCollisionTag;

		[Token(Token = "0x4000424")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public bool ppEnableEvent;

		[Token(Token = "0x4000425")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public UnityEvent ppEvent;

		[Token(Token = "0x4000426")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public bool ppCreateNewReference;

		[Token(Token = "0x4000427")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private List<Vector3> originalVertices;

		[Token(Token = "0x4000428")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private List<Vector3> storedVertices;

		[Token(Token = "0x4000429")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private List<Vector3> startingVertices;

		[Token(Token = "0x400042A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private MeshFilter meshF;

		[Token(Token = "0x600084B")]
		[Address(RVA = "0x2463180", Offset = "0x2463180", VA = "0x2463180")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x600084C")]
		[Address(RVA = "0x24631D0", Offset = "0x24631D0", VA = "0x24631D0")]
		private void Awake()
		{
		}

		[Token(Token = "0x600084D")]
		[Address(RVA = "0x246350C", Offset = "0x246350C", VA = "0x246350C")]
		private void OnCollisionEnter(Collision collision)
		{
		}

		[Token(Token = "0x600084E")]
		[Address(RVA = "0x24637E0", Offset = "0x24637E0", VA = "0x24637E0")]
		public void MeshDamage_ModifyMesh(Vector3 AtPoint, float Radius, float Force)
		{
		}

		[Token(Token = "0x600084F")]
		[Address(RVA = "0x2463B34", Offset = "0x2463B34", VA = "0x2463B34")]
		public void MeshDamage_RefreshVertices()
		{
		}

		[Token(Token = "0x6000850")]
		[Address(RVA = "0x2463BF4", Offset = "0x2463BF4", VA = "0x2463BF4")]
		public void MeshDamage_RepairMesh(float Speed = 0.5f)
		{
		}

		[Token(Token = "0x6000851")]
		[Address(RVA = "0x2463DB0", Offset = "0x2463DB0", VA = "0x2463DB0")]
		public void MeshDamage_ModifyMesh(MDM_RaycastEvent RayEvent)
		{
		}

		[Token(Token = "0x6000852")]
		[Address(RVA = "0x2463F74", Offset = "0x2463F74", VA = "0x2463F74")]
		public MDM_MeshDamage()
		{
		}
	}
	[Token(Token = "0x200013C")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x1182DD0", Offset = "0x1182DD0")]
	public class MDM_MeshFit : MonoBehaviour
	{
		[Token(Token = "0x200019D")]
		public enum MeshFitterMode
		{
			[Token(Token = "0x4000688")]
			FitWholeMesh,
			[Token(Token = "0x4000689")]
			FitSpecificVertices
		}

		[Token(Token = "0x400042B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool ppCreateNewReference;

		[Token(Token = "0x400042C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		public bool UpdateManually;

		[Token(Token = "0x400042D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private MeshFilter meshF;

		[Token(Token = "0x400042E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public List<Vector3> verts;

		[Token(Token = "0x400042F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public List<Transform> points;

		[Token(Token = "0x4000430")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Vector3[] originalVerts;

		[Token(Token = "0x4000431")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Vector3[] startingVerts;

		[Token(Token = "0x4000432")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float ppMODIF_MeshFitterOffset;

		[Token(Token = "0x4000433")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public float ppMODIF_MeshFitterSurfaceDetection;

		[Token(Token = "0x4000434")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public MeshFitterMode ppMODIF_MeshFitterType;

		[Token(Token = "0x4000435")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public bool ppMODIF_MeshFitterContinuousEffect;

		[Token(Token = "0x4000436")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public GameObject[] ppMODIF_MeshFitter_SelectedVertexes;

		[Token(Token = "0x4000437")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public bool GotOriginal;

		[Token(Token = "0x6000853")]
		[Address(RVA = "0x2464054", Offset = "0x2464054", VA = "0x2464054")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000854")]
		[Address(RVA = "0x246425C", Offset = "0x246425C", VA = "0x246425C")]
		private void Update()
		{
		}

		[Token(Token = "0x6000855")]
		[Address(RVA = "0x2464E10", Offset = "0x2464E10", VA = "0x2464E10")]
		public void MD_INTERNAL_RefreshVerticesActivation()
		{
		}

		[Token(Token = "0x6000856")]
		[Address(RVA = "0x2464F9C", Offset = "0x2464F9C", VA = "0x2464F9C")]
		public void MeshFit_ShowHidePoints(bool activation)
		{
		}

		[Token(Token = "0x6000857")]
		[Address(RVA = "0x2465290", Offset = "0x2465290", VA = "0x2465290")]
		public void MeshFit_GeneratePoints()
		{
		}

		[Token(Token = "0x6000858")]
		[Address(RVA = "0x24662CC", Offset = "0x24662CC", VA = "0x24662CC")]
		public void MeshFit_RestoreOriginal()
		{
		}

		[Token(Token = "0x6000859")]
		[Address(RVA = "0x2466140", Offset = "0x2466140", VA = "0x2466140")]
		public void MeshFit_ClearPoints()
		{
		}

		[Token(Token = "0x600085A")]
		[Address(RVA = "0x246634C", Offset = "0x246634C", VA = "0x246634C")]
		public void MeshFit_BakeMesh()
		{
		}

		[Token(Token = "0x600085B")]
		[Address(RVA = "0x246426C", Offset = "0x246426C", VA = "0x246426C")]
		public void MeshFit_UpdateMeshState()
		{
		}

		[Token(Token = "0x600085C")]
		[Address(RVA = "0x2466640", Offset = "0x2466640", VA = "0x2466640")]
		public MDM_MeshFit()
		{
		}
	}
	[Token(Token = "0x200013D")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x1182E1C", Offset = "0x1182E1C")]
	public class MDM_MeshNoise : MonoBehaviour
	{
		[Token(Token = "0x200019E")]
		public enum NoiseType
		{
			[Token(Token = "0x400068B")]
			OverallNoise,
			[Token(Token = "0x400068C")]
			VerticalNoise
		}

		[Token(Token = "0x4000438")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public NoiseType ppNoiseType;

		[Token(Token = "0x4000439")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float ppMeshNoiseAmount;

		[Token(Token = "0x400043A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float ppMeshNoiseSpeed;

		[Token(Token = "0x400043B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float ppMeshNoiseIntensity;

		[Token(Token = "0x400043C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool ppCreateNewReference;

		[Token(Token = "0x400043D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Perlin ppNoise;

		[Token(Token = "0x400043E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Vector3[] originalVertices;

		[Token(Token = "0x400043F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Vector3[] storedVertices;

		[Token(Token = "0x4000440")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private MeshFilter meshF;

		[Token(Token = "0x600085D")]
		[Address(RVA = "0x24666F4", Offset = "0x24666F4", VA = "0x24666F4")]
		private void Awake()
		{
		}

		[Token(Token = "0x600085E")]
		[Address(RVA = "0x24668E8", Offset = "0x24668E8", VA = "0x24668E8")]
		private void NoiseDoubleCheck()
		{
		}

		[Token(Token = "0x600085F")]
		[Address(RVA = "0x24669B8", Offset = "0x24669B8", VA = "0x24669B8")]
		private void Update()
		{
		}

		[Token(Token = "0x6000860")]
		[Address(RVA = "0x2466A10", Offset = "0x2466A10", VA = "0x2466A10")]
		public void MeshNoise_UpdateVerticalNoise()
		{
		}

		[Token(Token = "0x6000861")]
		[Address(RVA = "0x2466BE0", Offset = "0x2466BE0", VA = "0x2466BE0")]
		public void MeshNoise_UpdateOverallNoise()
		{
		}

		[Token(Token = "0x6000862")]
		[Address(RVA = "0x2466E10", Offset = "0x2466E10", VA = "0x2466E10")]
		public MDM_MeshNoise()
		{
		}
	}
	[Token(Token = "0x200013E")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x1182E68", Offset = "0x1182E68")]
	[ExecuteInEditMode]
	public class MDM_Morpher : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x200019F")]
		public class registeredMorphs
		{
			[Token(Token = "0x400068D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public List<Vector3> Vertices;

			[Token(Token = "0x400068E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public List<int> Indexes;

			[Token(Token = "0x60009C9")]
			[Address(RVA = "0x2467558", Offset = "0x2467558", VA = "0x2467558")]
			public registeredMorphs()
			{
			}
		}

		[Token(Token = "0x4000441")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool ppDynamicMesh;

		[Token(Token = "0x4000442")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		public bool ppCreateNewReference;

		[Token(Token = "0x4000443")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
		public bool ppMultithreadingSupported;

		[Token(Token = "0x4000444")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Thread Multithread;

		[Token(Token = "0x4000445")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public List<Vector3> originalVertices;

		[Token(Token = "0x4000446")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Vector3[] threadedVertices;

		[Token(Token = "0x4000447")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public MeshFilter meshF;

		[Token(Token = "0x4000448")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public bool ppInterpolation;

		[Token(Token = "0x4000449")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float ppInterpolationSpeed;

		[Token(Token = "0x400044A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x11862B0", Offset = "0x11862B0")]
		public float ppBlendValue;

		[Token(Token = "0x400044B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		public Mesh[] ppTargetMorphMeshes;

		[Token(Token = "0x400044C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public int ppIndexOfTargetMesh;

		[Token(Token = "0x400044D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public bool ppRestartVertState;

		[Token(Token = "0x400044E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public List<registeredMorphs> RegisteredMorphs;

		[Token(Token = "0x400044F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public bool ModeSwitched;

		[Token(Token = "0x6000863")]
		[Address(RVA = "0x2466E34", Offset = "0x2466E34", VA = "0x2466E34")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000864")]
		[Address(RVA = "0x2467054", Offset = "0x2467054", VA = "0x2467054")]
		private void Start()
		{
		}

		[Token(Token = "0x6000865")]
		[Address(RVA = "0x2467140", Offset = "0x2467140", VA = "0x2467140")]
		public void Morpher_ChangeMeshIndex(int entry)
		{
		}

		[Token(Token = "0x6000866")]
		[Address(RVA = "0x2467214", Offset = "0x2467214", VA = "0x2467214")]
		public void Morpher_SetBlendValue(Slider entry)
		{
		}

		[Token(Token = "0x6000867")]
		[Address(RVA = "0x2467254", Offset = "0x2467254", VA = "0x2467254")]
		public void Morpher_SetBlendValue(float entry)
		{
		}

		[Token(Token = "0x6000868")]
		[Address(RVA = "0x246725C", Offset = "0x246725C", VA = "0x246725C")]
		public void Morpher_SetBlendValue(int entry)
		{
		}

		[Token(Token = "0x6000869")]
		[Address(RVA = "0x2467268", Offset = "0x2467268", VA = "0x2467268")]
		public void Morpher_RefreshTargetMeshes()
		{
		}

		[Token(Token = "0x600086A")]
		[Address(RVA = "0x24675F0", Offset = "0x24675F0", VA = "0x24675F0")]
		private Vector3 VertFunct(Vector3 A, Vector3 B, float dist)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600086B")]
		[Address(RVA = "0x24676DC", Offset = "0x24676DC", VA = "0x24676DC")]
		private void Update()
		{
		}

		[Token(Token = "0x600086C")]
		[Address(RVA = "0x2467C20", Offset = "0x2467C20", VA = "0x2467C20")]
		private void UpdateMorphMesh()
		{
		}

		[Token(Token = "0x600086D")]
		[Address(RVA = "0x24680A8", Offset = "0x24680A8", VA = "0x24680A8")]
		private void OnApplicationQuit()
		{
		}

		[Token(Token = "0x600086E")]
		[Address(RVA = "0x24680F4", Offset = "0x24680F4", VA = "0x24680F4")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600086F")]
		[Address(RVA = "0x2468140", Offset = "0x2468140", VA = "0x2468140")]
		public MDM_Morpher()
		{
		}
	}
	[Token(Token = "0x200013F")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x1182EB4", Offset = "0x1182EB4")]
	public class MDM_RaycastEvent : MonoBehaviour
	{
		[Token(Token = "0x4000450")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool ppUpdateRayPerFrame;

		[Token(Token = "0x4000451")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float ppDistanceRay;

		[Token(Token = "0x4000452")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool ppPointRay;

		[Token(Token = "0x4000453")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float ppSphericalRadius;

		[Token(Token = "0x4000454")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool ppSavePerformanceByRigidbody;

		[Token(Token = "0x4000455")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Rigidbody ppTargetRigidbody;

		[Token(Token = "0x4000456")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float ppTargetVelocitySpeed;

		[Token(Token = "0x4000457")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public bool ppRaycastWithSpecificTag;

		[Token(Token = "0x4000458")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public string ppRaycastTag;

		[Token(Token = "0x4000459")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public UnityEvent ppEventAfterRaycast;

		[Token(Token = "0x400045A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public UnityEvent ppEventAfterRaycastExit;

		[Token(Token = "0x400045B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public RaycastHit[] hits;

		[Token(Token = "0x400045C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private bool RaycastingState;

		[Token(Token = "0x6000870")]
		[Address(RVA = "0x2468208", Offset = "0x2468208", VA = "0x2468208")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x6000871")]
		[Address(RVA = "0x2468410", Offset = "0x2468410", VA = "0x2468410")]
		private void Update()
		{
		}

		[Token(Token = "0x6000872")]
		[Address(RVA = "0x2468684", Offset = "0x2468684", VA = "0x2468684")]
		public bool RayEvent_IsRaycasting()
		{
			return default(bool);
		}

		[Token(Token = "0x6000873")]
		[Address(RVA = "0x2468420", Offset = "0x2468420", VA = "0x2468420")]
		public void RayEvent_UpdateRaycastState()
		{
		}

		[Token(Token = "0x6000874")]
		[Address(RVA = "0x246868C", Offset = "0x246868C", VA = "0x246868C")]
		public MDM_RaycastEvent()
		{
		}
	}
	[Token(Token = "0x2000140")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x1182EEC", Offset = "0x1182EEC")]
	public class MDM_SculptingPro : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20001A0")]
		public class Multithreading_Internal
		{
			[Token(Token = "0x400068F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Vector3 mth_WorldPoint;

			[Token(Token = "0x4000690")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public float mth_Radius;

			[Token(Token = "0x4000691")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float mth_Strength;

			[Token(Token = "0x4000692")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			public SS_State_Internal mth_State;

			[Token(Token = "0x4000693")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Vector3 mth_WorldPos;

			[Token(Token = "0x4000694")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			public Quaternion mth_WorldRot;

			[Token(Token = "0x4000695")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			public Vector3 mth_WorldScale;

			[Token(Token = "0x4000696")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public Vector3 mth_Direction;

			[Token(Token = "0x4000697")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			public SS_NoiseFunctDirections mth_NoiseDirs;

			[Token(Token = "0x4000698")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			public SS_SculptingType_ SS_SculptingType;

			[Token(Token = "0x4000699")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			public int SS_MultithreadingProcessDelay;

			[Token(Token = "0x60009CA")]
			[Address(RVA = "0x246A824", Offset = "0x246A824", VA = "0x246A824")]
			public void SetParams(Vector3 worldPoint, float Radius, float Strength, Vector3 Dir, SS_State_Internal State, Vector3 RealPos, Vector3 RealScale, Quaternion RealRot, SS_NoiseFunctDirections NoiseDirs, SS_SculptingType_ SS_SculptingType__, int SS_MultithreadingProcessDelay_)
			{
			}

			[Token(Token = "0x60009CB")]
			[Address(RVA = "0x2469908", Offset = "0x2469908", VA = "0x2469908")]
			public Multithreading_Internal()
			{
			}
		}

		[Token(Token = "0x20001A1")]
		public enum SS_State_Internal
		{
			[Token(Token = "0x400069B")]
			None,
			[Token(Token = "0x400069C")]
			Raise,
			[Token(Token = "0x400069D")]
			Lower,
			[Token(Token = "0x400069E")]
			Revert,
			[Token(Token = "0x400069F")]
			Noise
		}

		[Token(Token = "0x20001A2")]
		public enum SS_MeshSculptMode_Internal
		{
			[Token(Token = "0x40006A1")]
			VerticesDirection,
			[Token(Token = "0x40006A2")]
			BrushDirection,
			[Token(Token = "0x40006A3")]
			CustomDirection,
			[Token(Token = "0x40006A4")]
			CustomDirectionObject,
			[Token(Token = "0x40006A5")]
			InternalScriptDirection
		}

		[Token(Token = "0x20001A3")]
		public enum SS_CustomDirObjDirection_Internal
		{
			[Token(Token = "0x40006A7")]
			Up,
			[Token(Token = "0x40006A8")]
			Down,
			[Token(Token = "0x40006A9")]
			Forward,
			[Token(Token = "0x40006AA")]
			Back,
			[Token(Token = "0x40006AB")]
			Right,
			[Token(Token = "0x40006AC")]
			Left
		}

		[Token(Token = "0x20001A4")]
		public enum SS_SculptingType_
		{
			[Token(Token = "0x40006AE")]
			Linear,
			[Token(Token = "0x40006AF")]
			Exponential
		}

		[Token(Token = "0x20001A5")]
		public enum SS_NoiseFunctDirections
		{
			[Token(Token = "0x40006B1")]
			XYZ,
			[Token(Token = "0x40006B2")]
			XZ,
			[Token(Token = "0x40006B3")]
			XY,
			[Token(Token = "0x40006B4")]
			YZ,
			[Token(Token = "0x40006B5")]
			Z,
			[Token(Token = "0x40006B6")]
			Y,
			[Token(Token = "0x40006B7")]
			X
		}

		[Token(Token = "0x20001A6")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x11834AC", Offset = "0x11834AC")]
		private sealed class <CheckForThreadDelay>d__58 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40006B8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40006B9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40006BA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float delay;

			[Token(Token = "0x40006BB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			public bool CreateSculptThread;

			[Token(Token = "0x40006BC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public MDM_SculptingPro <>4__this;

			[Token(Token = "0x17000058")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60009CF")]
				[Address(RVA = "0x246BC18", Offset = "0x246BC18", VA = "0x246BC18", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000059")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60009D1")]
				[Address(RVA = "0x246BC80", Offset = "0x246BC80", VA = "0x246BC80", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60009CC")]
			[Address(RVA = "0x246B32C", Offset = "0x246B32C", VA = "0x246B32C")]
			[DebuggerHidden]
			public <CheckForThreadDelay>d__58(int <>1__state)
			{
			}

			[Token(Token = "0x60009CD")]
			[Address(RVA = "0x246BAB0", Offset = "0x246BAB0", VA = "0x246BAB0", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60009CE")]
			[Address(RVA = "0x246BAB4", Offset = "0x246BAB4", VA = "0x246BAB4", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60009D0")]
			[Address(RVA = "0x246BC20", Offset = "0x246BC20", VA = "0x246BC20", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400045D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool SS_AtRuntime;

		[Token(Token = "0x400045E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		public bool SS_InEditMode;

		[Token(Token = "0x400045F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
		public bool SS_MobileSupport;

		[Token(Token = "0x4000460")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B")]
		public bool SS_UseBrushProjection;

		[Token(Token = "0x4000461")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public GameObject SS_BrushProjection;

		[Token(Token = "0x4000462")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float SS_BrushSize;

		[Token(Token = "0x4000463")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float SS_BrushStrength;

		[Token(Token = "0x4000464")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool SS_MultithreadingSupported;

		[Token(Token = "0x4000465")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x11862D8", Offset = "0x11862D8")]
		public int SS_MultithreadingProcessDelay;

		[Token(Token = "0x4000466")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Thread Multithread;

		[Token(Token = "0x4000467")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private ManualResetEvent Multithread_ManualEvent;

		[Token(Token = "0x4000468")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Multithreading_Internal Multithreading_Manager;

		[Token(Token = "0x4000469")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public SS_State_Internal SS_State;

		[Token(Token = "0x400046A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public SS_MeshSculptMode_Internal SS_MeshSculptMode;

		[Token(Token = "0x400046B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Vector3 SS_CustomDirection;

		[Token(Token = "0x400046C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public bool SS_EnableHeightLimitations;

		[Token(Token = "0x400046D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Vector2 SS_HeightLimitations;

		[Token(Token = "0x400046E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public SS_CustomDirObjDirection_Internal SS_CustomDirObjDirection;

		[Token(Token = "0x400046F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public GameObject SS_CustomDirectionObject;

		[Token(Token = "0x4000470")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public bool SS_UpdateColliderAfterRelease;

		[Token(Token = "0x4000471")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		public SS_SculptingType_ SS_SculptingType;

		[Token(Token = "0x4000472")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public bool SS_UseInput;

		[Token(Token = "0x4000473")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x89")]
		public bool SS_UseRaiseFunct;

		[Token(Token = "0x4000474")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8A")]
		public bool SS_UseLowerFunct;

		[Token(Token = "0x4000475")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8B")]
		public bool SS_UseRevertFunct;

		[Token(Token = "0x4000476")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		public bool SS_UseNoiseFunct;

		[Token(Token = "0x4000477")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public SS_NoiseFunctDirections SS_NoiseFunctionDirections;

		[Token(Token = "0x4000478")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		public KeyCode SS_SculptingRaiseInput;

		[Token(Token = "0x4000479")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public KeyCode SS_SculptingLowerInput;

		[Token(Token = "0x400047A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		public KeyCode SS_SculptingRevertInput;

		[Token(Token = "0x400047B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public KeyCode SS_SculptingNoiseInput;

		[Token(Token = "0x400047C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		public bool SS_SculptFromCursor;

		[Token(Token = "0x400047D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public Transform SS_SculptOrigin;

		[Token(Token = "0x400047E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public MeshFilter mesh;

		[Token(Token = "0x400047F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public List<Vector3> StoredVertices;

		[Token(Token = "0x4000480")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public Vector3[] ThreatedPoints;

		[Token(Token = "0x4000481")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public bool SSInternal_Set;

		[Token(Token = "0x4000482")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC9")]
		public bool SSCreateNewReference;

		[Token(Token = "0x4000483")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCA")]
		private bool threadDone;

		[Token(Token = "0x4000484")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static System.Random random;

		[Token(Token = "0x6000875")]
		[Address(RVA = "0x2468708", Offset = "0x2468708", VA = "0x2468708")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000876")]
		[Address(RVA = "0x2468A98", Offset = "0x2468A98", VA = "0x2468A98")]
		private void Start()
		{
		}

		[Token(Token = "0x6000877")]
		[Address(RVA = "0x2468F68", Offset = "0x2468F68", VA = "0x2468F68")]
		private void Update()
		{
		}

		[Token(Token = "0x6000878")]
		[Address(RVA = "0x2469910", Offset = "0x2469910", VA = "0x2469910")]
		private void SS_Funct_ManageControls(RaycastHit hit)
		{
		}

		[Token(Token = "0x6000879")]
		[Address(RVA = "0x246A660", Offset = "0x246A660", VA = "0x246A660")]
		public void SS_Funct_RestoreOriginal()
		{
		}

		[Token(Token = "0x600087A")]
		[Address(RVA = "0x2469C30", Offset = "0x2469C30", VA = "0x2469C30")]
		public void SS_Funct_DoSculpting(Vector3 WorldPoint, Vector3 Direction, float Radius, float Strength, SS_State_Internal State)
		{
		}

		[Token(Token = "0x600087B")]
		[Address(RVA = "0x246A874", Offset = "0x246A874", VA = "0x246A874")]
		private void SS_Funct_DoSculpting_ThreadWorker()
		{
		}

		[Token(Token = "0x600087C")]
		[Address(RVA = "0x246B0B0", Offset = "0x246B0B0", VA = "0x246B0B0")]
		public double GetRandomNumber(double minimum, double maximum)
		{
			return default(double);
		}

		[Token(Token = "0x600087D")]
		[Address(RVA = "0x246AE50", Offset = "0x246AE50", VA = "0x246AE50")]
		private Vector3 TransformPoint(Vector3 WorldPos, Quaternion WorldRot, Vector3 WorldScale, Vector3 Point)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600087E")]
		[Address(RVA = "0x246B148", Offset = "0x246B148", VA = "0x246B148")]
		private Vector3 TransformPointInverse(Vector3 WorldPos, Quaternion WorldRot, Vector3 WorldScale, Vector3 Point)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600087F")]
		[Address(RVA = "0x246AF80", Offset = "0x246AF80", VA = "0x246AF80")]
		private Vector3 TransformDirection(Vector3 WorldPos, Quaternion WorldRot, Vector3 WorldScale, Vector3 Point)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000880")]
		[Address(RVA = "0x2468F38", Offset = "0x2468F38", VA = "0x2468F38")]
		public void CheckForThread(bool CreateSculptThread = true, float Delay = 0.1f)
		{
		}

		[Token(Token = "0x6000881")]
		[Address(RVA = "0x246B298", Offset = "0x246B298", VA = "0x246B298")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x11867A0", Offset = "0x11867A0")]
		private IEnumerator CheckForThreadDelay(bool CreateSculptThread, float delay)
		{
			return null;
		}

		[Token(Token = "0x6000882")]
		[Address(RVA = "0x246B358", Offset = "0x246B358", VA = "0x246B358")]
		private void OnApplicationQuit()
		{
		}

		[Token(Token = "0x6000883")]
		[Address(RVA = "0x246B3A4", Offset = "0x246B3A4", VA = "0x246B3A4")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000884")]
		[Address(RVA = "0x24688CC", Offset = "0x24688CC", VA = "0x24688CC")]
		public void SS_Funct_RefreshMeshCollider()
		{
		}

		[Token(Token = "0x6000885")]
		[Address(RVA = "0x246B3F0", Offset = "0x246B3F0", VA = "0x246B3F0")]
		public void SS_Funct_BakeMesh()
		{
		}

		[Token(Token = "0x6000886")]
		[Address(RVA = "0x246B6BC", Offset = "0x246B6BC", VA = "0x246B6BC")]
		public void SS_Funct_ChangeSize(float size)
		{
		}

		[Token(Token = "0x6000887")]
		[Address(RVA = "0x246B6C4", Offset = "0x246B6C4", VA = "0x246B6C4")]
		public void SS_Funct_ChangeSize(Slider size)
		{
		}

		[Token(Token = "0x6000888")]
		[Address(RVA = "0x246B704", Offset = "0x246B704", VA = "0x246B704")]
		public void SS_Funct_ChangeStrength(float strength)
		{
		}

		[Token(Token = "0x6000889")]
		[Address(RVA = "0x246B70C", Offset = "0x246B70C", VA = "0x246B70C")]
		public void SS_Funct_ChangeStrength(Slider strength)
		{
		}

		[Token(Token = "0x600088A")]
		[Address(RVA = "0x246B74C", Offset = "0x246B74C", VA = "0x246B74C")]
		public void SS_Funct_ChangeBrushState(int StateIndex)
		{
		}

		[Token(Token = "0x600088B")]
		[Address(RVA = "0x246B754", Offset = "0x246B754", VA = "0x246B754")]
		public void SS_Funct_SetBasics(float Radius, float Strength, bool showBrush, Vector3 BrushPoint, Vector3 BrushDirection)
		{
		}

		[Token(Token = "0x600088C")]
		[Address(RVA = "0x2469BA0", Offset = "0x2469BA0", VA = "0x2469BA0")]
		private bool MD_PRIVATE_FUNCT_GetControlInput(KeyCode key)
		{
			return default(bool);
		}

		[Token(Token = "0x600088D")]
		[Address(RVA = "0x246B958", Offset = "0x246B958", VA = "0x246B958")]
		public MDM_SculptingPro()
		{
		}
	}
	[Token(Token = "0x2000141")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x1182F38", Offset = "0x1182F38")]
	[ExecuteInEditMode]
	public class MDM_TunnelCreator : MonoBehaviour
	{
		[Token(Token = "0x4000485")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x11862F0", Offset = "0x11862F0")]
		public int tVertexCount;

		[Token(Token = "0x4000486")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public int tVertexCountInternal;

		[Token(Token = "0x4000487")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float tRadius;

		[Token(Token = "0x4000488")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float tNodeSize;

		[Token(Token = "0x4000489")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool tHemiCylinder;

		[Token(Token = "0x400048A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
		public bool tHemiCylinderVertical;

		[Token(Token = "0x400048B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2A")]
		public bool tRevertNormals;

		[Token(Token = "0x400048C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2B")]
		public bool tUpdateEveryFrame;

		[Token(Token = "0x400048D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public bool tEnableSmartRotation;

		[Token(Token = "0x400048E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2D")]
		public bool tUseCustomUVData;

		[Token(Token = "0x400048F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public MDM_TunnelNodeUVData._UVMode tUVMode;

		[Token(Token = "0x4000490")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public bool tEnableDebug;

		[Token(Token = "0x4000491")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public List<Transform> tNodes;

		[Token(Token = "0x4000492")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public List<Vector3> tVertices;

		[Token(Token = "0x4000493")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public List<int> tTriangles;

		[Token(Token = "0x4000494")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public List<Vector2> tUV;

		[Token(Token = "0x4000495")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Mesh tCurrentMesh;

		[Token(Token = "0x4000496")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Texture2D tc_ICON_ShowW;

		[Token(Token = "0x600088F")]
		[Address(RVA = "0x246BC88", Offset = "0x246BC88", VA = "0x246BC88")]
		private void OnDrawGizmos()
		{
		}

		[Token(Token = "0x6000890")]
		[Address(RVA = "0x246BE18", Offset = "0x246BE18", VA = "0x246BE18")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000891")]
		[Address(RVA = "0x246BEB8", Offset = "0x246BEB8", VA = "0x246BEB8")]
		private void Update()
		{
		}

		[Token(Token = "0x6000892")]
		[Address(RVA = "0x246C194", Offset = "0x246C194", VA = "0x246C194")]
		public void PUBLICtFunct_AddNode(Vector3 toPos, bool GroupOnAdd = true)
		{
		}

		[Token(Token = "0x6000893")]
		[Address(RVA = "0x246C610", Offset = "0x246C610", VA = "0x246C610")]
		public void PUBLICtFunct_RemoveNode()
		{
		}

		[Token(Token = "0x6000894")]
		[Address(RVA = "0x246C834", Offset = "0x246C834", VA = "0x246C834")]
		public void PUBLICtFunct_ClearAll()
		{
		}

		[Token(Token = "0x6000895")]
		[Address(RVA = "0x246BEC8", Offset = "0x246BEC8", VA = "0x246BEC8")]
		public void PUBLICtFunct_RefreshNodes()
		{
		}

		[Token(Token = "0x6000896")]
		[Address(RVA = "0x246CD0C", Offset = "0x246CD0C", VA = "0x246CD0C")]
		public void PUBLICtFunct_ApplyVertexCount()
		{
		}

		[Token(Token = "0x6000897")]
		[Address(RVA = "0x246CEEC", Offset = "0x246CEEC", VA = "0x246CEEC")]
		private void tFunct_ClearAllInternal()
		{
		}

		[Token(Token = "0x6000898")]
		[Address(RVA = "0x246D334", Offset = "0x246D334", VA = "0x246D334")]
		public void PUBLICtFunct_GroupNodesTogether()
		{
		}

		[Token(Token = "0x6000899")]
		[Address(RVA = "0x246D060", Offset = "0x246D060", VA = "0x246D060")]
		public void PUBLICtFunct_UngroupNodes(Transform Detachto)
		{
		}

		[Token(Token = "0x600089A")]
		[Address(RVA = "0x246C3F0", Offset = "0x246C3F0", VA = "0x246C3F0")]
		private void tFunctCreateNodeBlock(Vector3 OriginPosition, bool GroupOnAdd = true)
		{
		}

		[Token(Token = "0x600089B")]
		[Address(RVA = "0x246C650", Offset = "0x246C650", VA = "0x246C650")]
		private void tFunctRemoveNodeBlock()
		{
		}

		[Token(Token = "0x600089C")]
		[Address(RVA = "0x246CA44", Offset = "0x246CA44", VA = "0x246CA44")]
		private void tFunctRefreshMesh(int VertexQueue, int OriginQueue)
		{
		}

		[Token(Token = "0x600089D")]
		[Address(RVA = "0x246D144", Offset = "0x246D144", VA = "0x246D144")]
		private void fFunctUpdateMeshParams(bool deletingMesh = false)
		{
		}

		[Token(Token = "0x600089E")]
		[Address(RVA = "0x246D9F4", Offset = "0x246D9F4", VA = "0x246D9F4")]
		public void PUBLICtFunct_UpdateUVs(MDM_TunnelNodeUVData._UVMode uvMode)
		{
		}

		[Token(Token = "0x600089F")]
		[Address(RVA = "0x246D68C", Offset = "0x246D68C", VA = "0x246D68C")]
		private void tFunctUpdateUVsAtIndex(int originQueue)
		{
		}

		[Token(Token = "0x60008A0")]
		[Address(RVA = "0x246DD34", Offset = "0x246DD34", VA = "0x246DD34")]
		private Vector2 tReturnCorrectUVMode(MDM_TunnelNodeUVData._UVMode uvMode, int v)
		{
			return default(Vector2);
		}

		[Token(Token = "0x60008A1")]
		[Address(RVA = "0x246D408", Offset = "0x246D408", VA = "0x246D408")]
		private void tProcess_CreateVerticePanel(Transform newOrigin)
		{
		}

		[Token(Token = "0x60008A2")]
		[Address(RVA = "0x246D604", Offset = "0x246D604", VA = "0x246D604")]
		private void tProcess_CreateTrianglePanel()
		{
		}

		[Token(Token = "0x60008A3")]
		[Address(RVA = "0x246E040", Offset = "0x246E040", VA = "0x246E040")]
		private void tProcess_CreateFace(int index, int maxAdd, int maxCount)
		{
		}

		[Token(Token = "0x60008A4")]
		[Address(RVA = "0x246D544", Offset = "0x246D544", VA = "0x246D544")]
		private void tProcess_CreateUV()
		{
		}

		[Token(Token = "0x60008A5")]
		[Address(RVA = "0x246E19C", Offset = "0x246E19C", VA = "0x246E19C")]
		public MDM_TunnelCreator()
		{
		}
	}
	[Token(Token = "0x2000142")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x1182F84", Offset = "0x1182F84")]
	public class MDM_TunnelNodeUVData : MonoBehaviour
	{
		[Token(Token = "0x20001A7")]
		public enum _UVMode
		{
			[Token(Token = "0x40006BE")]
			uvXY,
			[Token(Token = "0x40006BF")]
			uvXZ,
			[Token(Token = "0x40006C0")]
			uvYX,
			[Token(Token = "0x40006C1")]
			uvYZ,
			[Token(Token = "0x40006C2")]
			uvZX,
			[Token(Token = "0x40006C3")]
			uvZY
		}

		[Token(Token = "0x4000497")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public _UVMode UVMode;

		[Token(Token = "0x4000498")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x118630C", Offset = "0x118630C")]
		public Vector2 UvOffset;

		[Token(Token = "0x4000499")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public Vector2 UvTransition;

		[Token(Token = "0x400049A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x118631C", Offset = "0x118631C")]
		public float DebugSize;

		[Token(Token = "0x60008A6")]
		[Address(RVA = "0x246E2AC", Offset = "0x246E2AC", VA = "0x246E2AC")]
		private void OnDrawGizmos()
		{
		}

		[Token(Token = "0x60008A7")]
		[Address(RVA = "0x246E2FC", Offset = "0x246E2FC", VA = "0x246E2FC")]
		public MDM_TunnelNodeUVData()
		{
		}
	}
	[Token(Token = "0x2000143")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x1182FBC", Offset = "0x1182FBC")]
	public class MDM_Twist : MonoBehaviour
	{
		[Token(Token = "0x20001A8")]
		public enum Direction_
		{
			[Token(Token = "0x40006C5")]
			X,
			[Token(Token = "0x40006C6")]
			Y,
			[Token(Token = "0x40006C7")]
			Z
		}

		[Token(Token = "0x400049B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Direction_ ppTwistDirection;

		[Token(Token = "0x400049C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float ppAmount;

		[Token(Token = "0x400049D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private float AmountStorage;

		[Token(Token = "0x400049E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public bool ppCreateNewReference;

		[Token(Token = "0x400049F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private List<Vector3> originalVertices;

		[Token(Token = "0x40004A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private MeshFilter meshF;

		[Token(Token = "0x60008A8")]
		[Address(RVA = "0x246E30C", Offset = "0x246E30C", VA = "0x246E30C")]
		private void Awake()
		{
		}

		[Token(Token = "0x60008A9")]
		[Address(RVA = "0x246E508", Offset = "0x246E508", VA = "0x246E508")]
		private void Update()
		{
		}

		[Token(Token = "0x60008AA")]
		[Address(RVA = "0x246E908", Offset = "0x246E908", VA = "0x246E908")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60008AB")]
		[Address(RVA = "0x246E7CC", Offset = "0x246E7CC", VA = "0x246E7CC")]
		private Vector3 TwistObject(Vector3 origin, float direction)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60008AC")]
		[Address(RVA = "0x246E914", Offset = "0x246E914", VA = "0x246E914")]
		public void TWIST(Slider Entry)
		{
		}

		[Token(Token = "0x60008AD")]
		[Address(RVA = "0x246E954", Offset = "0x246E954", VA = "0x246E954")]
		public void TWIST(float Entry)
		{
		}

		[Token(Token = "0x60008AE")]
		[Address(RVA = "0x246E95C", Offset = "0x246E95C", VA = "0x246E95C")]
		public MDM_Twist()
		{
		}
	}
	[Token(Token = "0x2000144")]
	public class MD_Debug
	{
		[Token(Token = "0x20001A9")]
		public enum DebugType
		{
			[Token(Token = "0x40006C9")]
			Error,
			[Token(Token = "0x40006CA")]
			Warning,
			[Token(Token = "0x40006CB")]
			Information
		}

		[Token(Token = "0x40004A1")]
		public const string ORGANISATION = "Matej Vanco";

		[Token(Token = "0x40004A2")]
		public const short VERSION = 13;

		[Token(Token = "0x40004A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static DateTime DATE;

		[Token(Token = "0x60008AF")]
		[Address(RVA = "0x2465F60", Offset = "0x2465F60", VA = "0x2465F60")]
		public static void Debug(MonoBehaviour Sender, string Message, DebugType DType = DebugType.Information)
		{
		}

		[Token(Token = "0x60008B0")]
		[Address(RVA = "0x246E9D4", Offset = "0x246E9D4", VA = "0x246E9D4")]
		public MD_Debug()
		{
		}
	}
	[Token(Token = "0x2000145")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x1183008", Offset = "0x1183008")]
	public class AdvancedPlane : MonoBehaviour
	{
		[Token(Token = "0x40004A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x118632C", Offset = "0x118632C")]
		public int ppPlaneSizeAngle;

		[Token(Token = "0x40004A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1186348", Offset = "0x1186348")]
		public int ppPlaneSize;

		[Token(Token = "0x40004A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Vector3 ppPlaneOffset;

		[Token(Token = "0x40004A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public bool ppDynamicMesh;

		[Token(Token = "0x40004A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2D")]
		public bool ppEnableAngle;

		[Token(Token = "0x40004A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1186364", Offset = "0x1186364")]
		public float ppAngle;

		[Token(Token = "0x40004AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x118637C", Offset = "0x118637C")]
		public float ppAngleDensity;

		[Token(Token = "0x40004AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public bool ppEnableLandscapeFitter;

		[Token(Token = "0x40004AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1186394", Offset = "0x1186394")]
		public float ppTranslationSpeed;

		[Token(Token = "0x40004AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Vector3[] vertx;

		[Token(Token = "0x40004AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private int[] trisx;

		[Token(Token = "0x40004AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Vector2[] uvs;

		[Token(Token = "0x40004B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private MeshFilter meshF;

		[Token(Token = "0x40004B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Vector3 GizmoPosition1;

		[Token(Token = "0x40004B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private Vector3 GizmoPosition2;

		[Token(Token = "0x60008B2")]
		[Address(RVA = "0x1A397C4", Offset = "0x1A397C4", VA = "0x1A397C4")]
		private void Awake()
		{
		}

		[Token(Token = "0x60008B3")]
		[Address(RVA = "0x1A3994C", Offset = "0x1A3994C", VA = "0x1A3994C")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x60008B4")]
		[Address(RVA = "0x1A39A04", Offset = "0x1A39A04", VA = "0x1A39A04")]
		private void Update()
		{
		}

		[Token(Token = "0x60008B5")]
		[Address(RVA = "0x1A39B34", Offset = "0x1A39B34", VA = "0x1A39B34")]
		private void ModifyMesh()
		{
		}

		[Token(Token = "0x60008B6")]
		[Address(RVA = "0x1A3A288", Offset = "0x1A3A288", VA = "0x1A3A288")]
		private void MeshGenerator_NoAngle()
		{
		}

		[Token(Token = "0x60008B7")]
		[Address(RVA = "0x1A39B44", Offset = "0x1A39B44", VA = "0x1A39B44")]
		private void MeshGenerator_Angle()
		{
		}

		[Token(Token = "0x60008B8")]
		[Address(RVA = "0x1A3A8F4", Offset = "0x1A3A8F4", VA = "0x1A3A8F4")]
		private void ModifyMesh_FitToLandscape()
		{
		}

		[Token(Token = "0x60008B9")]
		[Address(RVA = "0x1A3AB24", Offset = "0x1A3AB24", VA = "0x1A3AB24")]
		public AdvancedPlane()
		{
		}
	}
	[Token(Token = "0x2000146")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x1183054", Offset = "0x1183054")]
	public class AdvancedPlaneMesh_Generator : MonoBehaviour
	{
		[Token(Token = "0x60008BA")]
		[Address(RVA = "0x1A3AB40", Offset = "0x1A3AB40", VA = "0x1A3AB40")]
		public static GameObject Generate()
		{
			return null;
		}

		[Token(Token = "0x60008BB")]
		[Address(RVA = "0x1A3B1C8", Offset = "0x1A3B1C8", VA = "0x1A3B1C8")]
		public AdvancedPlaneMesh_Generator()
		{
		}
	}
	[Token(Token = "0x2000147")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x11830A0", Offset = "0x11830A0")]
	public class AdvancedShape : MonoBehaviour
	{
		[Token(Token = "0x20001AA")]
		public enum ShapeType_
		{
			[Token(Token = "0x40006CD")]
			Plane,
			[Token(Token = "0x40006CE")]
			Box,
			[Token(Token = "0x40006CF")]
			Cone,
			[Token(Token = "0x40006D0")]
			Torus,
			[Token(Token = "0x40006D1")]
			Sphere,
			[Token(Token = "0x40006D2")]
			Tube
		}

		[Token(Token = "0x40004B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public ShapeType_ ShapeType;

		[Token(Token = "0x40004B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public bool ppDynamicMesh;

		[Token(Token = "0x40004B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float G_Plane_length;

		[Token(Token = "0x40004B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float G_Plane_width;

		[Token(Token = "0x40004B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x11863B0", Offset = "0x11863B0")]
		public int G_Plane_resX;

		[Token(Token = "0x40004B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float G_Box_length;

		[Token(Token = "0x40004B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float G_Box_height;

		[Token(Token = "0x40004BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float G_Box_width;

		[Token(Token = "0x40004BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float G_Cone_height;

		[Token(Token = "0x40004BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float G_Cone_botRadius;

		[Token(Token = "0x40004BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float G_Cone_topRadius;

		[Token(Token = "0x40004BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x11863CC", Offset = "0x11863CC")]
		public int G_Cone_verticalSides;

		[Token(Token = "0x40004BF")]
		private const int G_Cone_horizontalSides = 1;

		[Token(Token = "0x40004C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float G_Torus_radius0;

		[Token(Token = "0x40004C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public float G_Torus_radius1;

		[Token(Token = "0x40004C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x11863E8", Offset = "0x11863E8")]
		public int G_Torus_segments;

		[Token(Token = "0x40004C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1186404", Offset = "0x1186404")]
		public int G_Torus_sides;

		[Token(Token = "0x40004C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public float G_Sphere_radius0;

		[Token(Token = "0x40004C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1186420", Offset = "0x1186420")]
		public int G_Sphere_segments;

		[Token(Token = "0x40004C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x118643C", Offset = "0x118643C")]
		public int G_Sphere_stack;

		[Token(Token = "0x40004C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1186458", Offset = "0x1186458")]
		public int G_Sphere_sliceMax;

		[Token(Token = "0x40004C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1186474", Offset = "0x1186474")]
		public int G_Sphere_verticalMax;

		[Token(Token = "0x40004C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public float G_Tube_radius0;

		[Token(Token = "0x40004CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public float G_Tube_radius1;

		[Token(Token = "0x40004CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		public float G_Tube_height;

		[Token(Token = "0x40004CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1186490", Offset = "0x1186490")]
		public int G_Tube_segments;

		[Token(Token = "0x40004CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private MeshFilter meshF;

		[Token(Token = "0x60008BC")]
		[Address(RVA = "0x1A3B1D0", Offset = "0x1A3B1D0", VA = "0x1A3B1D0")]
		public static GameObject Generate()
		{
			return null;
		}

		[Token(Token = "0x60008BD")]
		[Address(RVA = "0x1A3B2F0", Offset = "0x1A3B2F0", VA = "0x1A3B2F0")]
		private void Awake()
		{
		}

		[Token(Token = "0x60008BE")]
		[Address(RVA = "0x1A3B488", Offset = "0x1A3B488", VA = "0x1A3B488")]
		private void Update()
		{
		}

		[Token(Token = "0x60008BF")]
		[Address(RVA = "0x1A3B6D4", Offset = "0x1A3B6D4", VA = "0x1A3B6D4")]
		public void GENERATE_Plane(float length, float width, int res)
		{
		}

		[Token(Token = "0x60008C0")]
		[Address(RVA = "0x1A3BBC0", Offset = "0x1A3BBC0", VA = "0x1A3BBC0")]
		public void GENERATE_Box(float Length, float Width, float Height)
		{
		}

		[Token(Token = "0x60008C1")]
		[Address(RVA = "0x1A3C4E4", Offset = "0x1A3C4E4", VA = "0x1A3C4E4")]
		public void GENERATE_Cone(float Height, float BotRadius, float TopRadius, float VerticalSides, float HorizontalSides)
		{
		}

		[Token(Token = "0x60008C2")]
		[Address(RVA = "0x1A3D2D4", Offset = "0x1A3D2D4", VA = "0x1A3D2D4")]
		public void GENERATE_Torus(float Radius1, float Radius2, int Segments, int Sides)
		{
		}

		[Token(Token = "0x60008C3")]
		[Address(RVA = "0x1A3DA18", Offset = "0x1A3DA18", VA = "0x1A3DA18")]
		public void GENERATE_Sphere(float radius, int segments, int stacks, float slicesMax, float verticalMax)
		{
		}

		[Token(Token = "0x60008C4")]
		[Address(RVA = "0x1A3DE9C", Offset = "0x1A3DE9C", VA = "0x1A3DE9C")]
		public void GENERATE_Tube(float oRadius, float iRadius, float height, int sides)
		{
		}

		[Token(Token = "0x60008C5")]
		[Address(RVA = "0x1A3E628", Offset = "0x1A3E628", VA = "0x1A3E628")]
		public AdvancedShape()
		{
		}
	}
	[Token(Token = "0x2000148")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x11830EC", Offset = "0x11830EC")]
	public class CubeMesh_Generator : MonoBehaviour
	{
		[Token(Token = "0x60008C6")]
		[Address(RVA = "0x2459800", Offset = "0x2459800", VA = "0x2459800")]
		public static GameObject Generate()
		{
			return null;
		}

		[Token(Token = "0x60008C7")]
		[Address(RVA = "0x245A978", Offset = "0x245A978", VA = "0x245A978")]
		public CubeMesh_Generator()
		{
		}
	}
	[Token(Token = "0x2000149")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x1183138", Offset = "0x1183138")]
	public class HexagonGrid : MonoBehaviour
	{
		[Token(Token = "0x40004CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Vector3[] verts;

		[Token(Token = "0x40004CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private int[] tris;

		[Token(Token = "0x40004D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Vector2[] uvs;

		[Token(Token = "0x40004D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x11864AC", Offset = "0x11864AC")]
		public int Count;

		[Token(Token = "0x40004D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public Vector3 Offset;

		[Token(Token = "0x40004D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float CellSize;

		[Token(Token = "0x40004D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x11864C8", Offset = "0x11864C8")]
		public float OffsetX;

		[Token(Token = "0x40004D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x11864E4", Offset = "0x11864E4")]
		public float OffsetZ;

		[Token(Token = "0x40004D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public float RandomHeightRange;

		[Token(Token = "0x40004D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public bool PlanarHexagon;

		[Token(Token = "0x40004D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x51")]
		public bool Invert;

		[Token(Token = "0x40004D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x52")]
		public bool ppDynamicMesh;

		[Token(Token = "0x40004DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private MeshFilter meshF;

		[Token(Token = "0x60008C8")]
		[Address(RVA = "0x245A980", Offset = "0x245A980", VA = "0x245A980")]
		public static GameObject InitEditor()
		{
			return null;
		}

		[Token(Token = "0x60008C9")]
		[Address(RVA = "0x245AACC", Offset = "0x245AACC", VA = "0x245AACC")]
		public static GameObject InitEditor_SingleHexa()
		{
			return null;
		}

		[Token(Token = "0x60008CA")]
		[Address(RVA = "0x245B85C", Offset = "0x245B85C", VA = "0x245B85C")]
		public static GameObject InitEditor_SingleHexaSpatial()
		{
			return null;
		}

		[Token(Token = "0x60008CB")]
		[Address(RVA = "0x245DAF4", Offset = "0x245DAF4", VA = "0x245DAF4")]
		private void Awake()
		{
		}

		[Token(Token = "0x60008CC")]
		[Address(RVA = "0x245DC7C", Offset = "0x245DC7C", VA = "0x245DC7C")]
		private void Update()
		{
		}

		[Token(Token = "0x60008CD")]
		[Address(RVA = "0x245ACC8", Offset = "0x245ACC8", VA = "0x245ACC8")]
		public void ModifyMesh_Planar()
		{
		}

		[Token(Token = "0x60008CE")]
		[Address(RVA = "0x245BA5C", Offset = "0x245BA5C", VA = "0x245BA5C")]
		public void ModifyMesh_Spatial(float AddHeightRand = 0f)
		{
		}

		[Token(Token = "0x60008CF")]
		[Address(RVA = "0x245DDE8", Offset = "0x245DDE8", VA = "0x245DDE8")]
		public void hgRandomizeHeight(float Offset)
		{
		}

		[Token(Token = "0x60008D0")]
		[Address(RVA = "0x245DDEC", Offset = "0x245DDEC", VA = "0x245DDEC")]
		public HexagonGrid()
		{
		}
	}
	[Token(Token = "0x200014A")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x1183184", Offset = "0x1183184")]
	public class OctahedronMesh_Generator : MonoBehaviour
	{
		[Token(Token = "0x60008D1")]
		[Address(RVA = "0x181437C", Offset = "0x181437C", VA = "0x181437C")]
		public static GameObject Generate()
		{
			return null;
		}

		[Token(Token = "0x60008D2")]
		[Address(RVA = "0x1819BA0", Offset = "0x1819BA0", VA = "0x1819BA0")]
		public static GameObject Generate(float size)
		{
			return null;
		}

		[Token(Token = "0x60008D3")]
		[Address(RVA = "0x1819A44", Offset = "0x1819A44", VA = "0x1819A44")]
		private static void CreateUV(Vector3[] vertices, Vector2[] uv)
		{
		}

		[Token(Token = "0x60008D4")]
		[Address(RVA = "0x181A074", Offset = "0x181A074", VA = "0x181A074")]
		public OctahedronMesh_Generator()
		{
		}
	}
	[Token(Token = "0x200014B")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x11831D0", Offset = "0x11831D0")]
	public class PlaneMesh_Generator : MonoBehaviour
	{
		[Token(Token = "0x60008D5")]
		[Address(RVA = "0x181A07C", Offset = "0x181A07C", VA = "0x181A07C")]
		public static GameObject Generate()
		{
			return null;
		}

		[Token(Token = "0x60008D6")]
		[Address(RVA = "0x181A884", Offset = "0x181A884", VA = "0x181A884")]
		public PlaneMesh_Generator()
		{
		}
	}
	[Token(Token = "0x200014C")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x118321C", Offset = "0x118321C")]
	public class PlaneMesh_Generator_1S : MonoBehaviour
	{
		[Token(Token = "0x60008D7")]
		[Address(RVA = "0x181A88C", Offset = "0x181A88C", VA = "0x181A88C")]
		public static GameObject Generate()
		{
			return null;
		}

		[Token(Token = "0x60008D8")]
		[Address(RVA = "0x181AEF4", Offset = "0x181AEF4", VA = "0x181AEF4")]
		public PlaneMesh_Generator_1S()
		{
		}
	}
	[Token(Token = "0x200014D")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x1183268", Offset = "0x1183268")]
	public class TriangleMesh_Generator : MonoBehaviour
	{
		[Token(Token = "0x60008D9")]
		[Address(RVA = "0x181AEFC", Offset = "0x181AEFC", VA = "0x181AEFC")]
		public static GameObject Generate()
		{
			return null;
		}

		[Token(Token = "0x60008DA")]
		[Address(RVA = "0x181BC50", Offset = "0x181BC50", VA = "0x181BC50")]
		public TriangleMesh_Generator()
		{
		}
	}
	[Token(Token = "0x200014E")]
	public class MD_SmoothDivisions : MonoBehaviour
	{
		[Token(Token = "0x40004DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static List<Vector3> vertices;

		[Token(Token = "0x40004DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static List<Vector3> normals;

		[Token(Token = "0x40004DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static List<Color> colors;

		[Token(Token = "0x40004DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static List<Vector2> uv;

		[Token(Token = "0x40004DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static List<Vector2> uv2;

		[Token(Token = "0x40004E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static List<Vector2> uv3;

		[Token(Token = "0x40004E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static List<int> indices;

		[Token(Token = "0x40004E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static Dictionary<uint, int> newVectices;

		[Token(Token = "0x60008DB")]
		[Address(RVA = "0x18172E8", Offset = "0x18172E8", VA = "0x18172E8")]
		private static void Clean()
		{
		}

		[Token(Token = "0x60008DC")]
		[Address(RVA = "0x181736C", Offset = "0x181736C", VA = "0x181736C")]
		private static void InitArrays(Mesh mesh)
		{
		}

		[Token(Token = "0x60008DD")]
		[Address(RVA = "0x181757C", Offset = "0x181757C", VA = "0x181757C")]
		private static int GetNewVertex4(int i1, int i2)
		{
			return default(int);
		}

		[Token(Token = "0x60008DE")]
		[Address(RVA = "0x1817B74", Offset = "0x1817B74", VA = "0x1817B74")]
		private static void Mode_Subdivide(Mesh mesh)
		{
		}

		[Token(Token = "0x60008DF")]
		[Address(RVA = "0x1817FF0", Offset = "0x1817FF0", VA = "0x1817FF0")]
		private static int GetVert(int i1, int i2, int i3)
		{
			return default(int);
		}

		[Token(Token = "0x60008E0")]
		[Address(RVA = "0x18187D8", Offset = "0x18187D8", VA = "0x18187D8")]
		private static void Mode_Subdivide2(Mesh mesh)
		{
		}

		[Token(Token = "0x60008E1")]
		[Address(RVA = "0x1816A2C", Offset = "0x1816A2C", VA = "0x1816A2C")]
		public static void Subdivide(Mesh mesh, int level)
		{
		}

		[Token(Token = "0x60008E2")]
		[Address(RVA = "0x1818E54", Offset = "0x1818E54", VA = "0x1818E54")]
		public MD_SmoothDivisions()
		{
		}
	}
	[Token(Token = "0x200014F")]
	public class MD_SmoothFunct : MonoBehaviour
	{
		[Token(Token = "0x60008E3")]
		[Address(RVA = "0x1818E5C", Offset = "0x1818E5C", VA = "0x1818E5C")]
		public static Vector3[] Filter_SmoothFunct(Vector3[] sv, int[] t)
		{
			return null;
		}

		[Token(Token = "0x60008E4")]
		[Address(RVA = "0x1816320", Offset = "0x1816320", VA = "0x1816320")]
		public static Vector3[] HC_Filterer(Vector3[] sv, Vector3[] pv, int[] t, float alpha, float beta)
		{
			return null;
		}

		[Token(Token = "0x60008E5")]
		[Address(RVA = "0x1819874", Offset = "0x1819874", VA = "0x1819874")]
		public MD_SmoothFunct()
		{
		}
	}
	[Token(Token = "0x2000150")]
	public class MD_Smooth_MeshHelpers : MonoBehaviour
	{
		[Token(Token = "0x60008E6")]
		[Address(RVA = "0x1819078", Offset = "0x1819078", VA = "0x1819078")]
		public static List<Vector3> findAdjacentNeighbors(Vector3[] v, int[] t, Vector3 vertex)
		{
			return null;
		}

		[Token(Token = "0x60008E7")]
		[Address(RVA = "0x1819444", Offset = "0x1819444", VA = "0x1819444")]
		public static List<int> AdjIndexes_Near(Vector3[] v, int[] t, Vector3 vertex)
		{
			return null;
		}

		[Token(Token = "0x60008E8")]
		[Address(RVA = "0x181987C", Offset = "0x181987C", VA = "0x181987C")]
		private static bool VertexExist(List<Vector3> AdjVertex, Vector3 v)
		{
			return default(bool);
		}

		[Token(Token = "0x60008E9")]
		[Address(RVA = "0x1819A3C", Offset = "0x1819A3C", VA = "0x1819A3C")]
		public MD_Smooth_MeshHelpers()
		{
		}
	}
	[Token(Token = "0x2000151")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x11832B4", Offset = "0x11832B4")]
	public class MD_MeshEditorRuntime_VR : MonoBehaviour
	{
		[Token(Token = "0x20001AB")]
		public enum _VertexControlMode
		{
			[Token(Token = "0x40006D4")]
			MoveVertex,
			[Token(Token = "0x40006D5")]
			PushVertex,
			[Token(Token = "0x40006D6")]
			PullVertex,
			[Token(Token = "0x40006D7")]
			SculptVertex
		}

		[Token(Token = "0x20001AC")]
		public enum pp_RuntimeFunctions_Internal
		{
			[Token(Token = "0x40006D9")]
			UseRaiseOnly,
			[Token(Token = "0x40006DA")]
			UseRaiseLowerOnly,
			[Token(Token = "0x40006DB")]
			UseRaiseLowerRevertOnly
		}

		[Token(Token = "0x40004E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public _VertexControlMode ppVertexControlMode;

		[Token(Token = "0x40004E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public SteamVR_Input_Sources pInput_Device;

		[Token(Token = "0x40004E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool ppTargetController;

		[Token(Token = "0x40004E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform TargetController;

		[Token(Token = "0x40004E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public ParticleSystem ppHoldingEffect;

		[Token(Token = "0x40004E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public bool ppMakeInterativePoint;

		[Token(Token = "0x40004E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float ppEffectRate;

		[Token(Token = "0x40004EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private float currRate;

		[Token(Token = "0x40004EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public bool ppEnableRigidbodyAfterHit;

		[Token(Token = "0x40004EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public pp_RuntimeFunctions_Internal pp_SculptingRuntimeFunctions;

		[Token(Token = "0x40004ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public SteamVR_Action_Boolean ppInput_Sculpt_Raise;

		[Token(Token = "0x40004EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public SteamVR_Action_Boolean ppInput_Sculpt_Lower;

		[Token(Token = "0x40004EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public SteamVR_Action_Boolean ppInput_Sculpt_Revert;

		[Token(Token = "0x40004F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public float ppSculpt_Radius;

		[Token(Token = "0x40004F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public float ppSculpt_Strength;

		[Token(Token = "0x40004F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public bool UseDebugSizeBySculptingRadius;

		[Token(Token = "0x40004F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		public float ppVertexSpeed;

		[Token(Token = "0x40004F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public bool ppRaycastSpecificPoints;

		[Token(Token = "0x40004F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public string ppSpecialTag;

		[Token(Token = "0x40004F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public SteamVR_Action_Boolean pInput_Action;

		[Token(Token = "0x40004F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public bool ppPointRay;

		[Token(Token = "0x40004F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		public float ppSphericalRayRadius;

		[Token(Token = "0x40004F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public bool ppShowGraphic;

		[Token(Token = "0x40004FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private GameObject pp_Graphic_Sphere;

		[Token(Token = "0x40004FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private LineRenderer pp_Graphic_Point;

		[Token(Token = "0x40004FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public float ppGraphic_Size;

		[Token(Token = "0x40004FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private GameObject SelectedPoint;

		[Token(Token = "0x40004FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private ParticleSystem CurrentHoldingEffect;

		[Token(Token = "0x40004FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private int storedLayer;

		[Token(Token = "0x4000500")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private Transform storedparent;

		[Token(Token = "0x4000501")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private MDM_SculptingPro LastHit;

		[Token(Token = "0x4000502")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private bool UpdatedCollider;

		[Token(Token = "0x60008EA")]
		[Address(RVA = "0x180C084", Offset = "0x180C084", VA = "0x180C084")]
		private void Start()
		{
		}

		[Token(Token = "0x60008EB")]
		[Address(RVA = "0x180C358", Offset = "0x180C358", VA = "0x180C358")]
		private void Update()
		{
		}

		[Token(Token = "0x60008EC")]
		[Address(RVA = "0x180DE60", Offset = "0x180DE60", VA = "0x180DE60")]
		public void MeshRuntimeVR_SwitchControlMode(int index)
		{
		}

		[Token(Token = "0x60008ED")]
		[Address(RVA = "0x180C764", Offset = "0x180C764", VA = "0x180C764")]
		private void MeshRuntimeVR_MoveVertex(Ray ray, RaycastHit hit, bool Raycast)
		{
		}

		[Token(Token = "0x60008EE")]
		[Address(RVA = "0x180CBD8", Offset = "0x180CBD8", VA = "0x180CBD8")]
		private void MeshRuntimeVR_PushVertex(Ray ray, RaycastHit hit, bool Raycast)
		{
		}

		[Token(Token = "0x60008EF")]
		[Address(RVA = "0x180D170", Offset = "0x180D170", VA = "0x180D170")]
		private void MeshRuntimeVR_PullVertex(Ray ray, RaycastHit hit, bool Raycast)
		{
		}

		[Token(Token = "0x60008F0")]
		[Address(RVA = "0x180D724", Offset = "0x180D724", VA = "0x180D724")]
		private void MeshRuntimeVR_SculptVertex(Ray ray, RaycastHit hit, bool Raycast)
		{
		}

		[Token(Token = "0x60008F1")]
		[Address(RVA = "0x180DE70", Offset = "0x180DE70", VA = "0x180DE70")]
		private bool GetControls(int controlIndex)
		{
			return default(bool);
		}

		[Token(Token = "0x60008F2")]
		[Address(RVA = "0x180E5C8", Offset = "0x180E5C8", VA = "0x180E5C8")]
		public void SS_Funct_ChangeRadius(float size)
		{
		}

		[Token(Token = "0x60008F3")]
		[Address(RVA = "0x180E5D0", Offset = "0x180E5D0", VA = "0x180E5D0")]
		public void SS_Funct_ChangeRadius(Slider size)
		{
		}

		[Token(Token = "0x60008F4")]
		[Address(RVA = "0x180E610", Offset = "0x180E610", VA = "0x180E610")]
		public void SS_Funct_AddRadius(float AddValue)
		{
		}

		[Token(Token = "0x60008F5")]
		[Address(RVA = "0x180E620", Offset = "0x180E620", VA = "0x180E620")]
		public void SS_Funct_SubstractRadius(float SbusValue)
		{
		}

		[Token(Token = "0x60008F6")]
		[Address(RVA = "0x180E630", Offset = "0x180E630", VA = "0x180E630")]
		public void SS_Funct_ChangeStrength(float strength)
		{
		}

		[Token(Token = "0x60008F7")]
		[Address(RVA = "0x180E638", Offset = "0x180E638", VA = "0x180E638")]
		public void SS_Funct_ChangeStrength(Slider strength)
		{
		}

		[Token(Token = "0x60008F8")]
		[Address(RVA = "0x180E678", Offset = "0x180E678", VA = "0x180E678")]
		public void SS_Funct_AddStrength(float AddValue)
		{
		}

		[Token(Token = "0x60008F9")]
		[Address(RVA = "0x180E688", Offset = "0x180E688", VA = "0x180E688")]
		public void SS_Funct_SubstractStrength(float SbusValue)
		{
		}

		[Token(Token = "0x60008FA")]
		[Address(RVA = "0x180E698", Offset = "0x180E698", VA = "0x180E698")]
		public MD_MeshEditorRuntime_VR()
		{
		}
	}
	[Token(Token = "0x2000152")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x11832EC", Offset = "0x11832EC")]
	public class MD_MeshPaint_VR_Input : MonoBehaviour
	{
		[Token(Token = "0x4000503")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public MD_MeshPaint TargetMeshPaint;

		[Token(Token = "0x4000504")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public SteamVR_Input_Sources pInput_Device;

		[Token(Token = "0x4000505")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public SteamVR_Action_Boolean pInput_Action;

		[Token(Token = "0x60008FB")]
		[Address(RVA = "0x1812738", Offset = "0x1812738", VA = "0x1812738")]
		private void Update()
		{
		}

		[Token(Token = "0x60008FC")]
		[Address(RVA = "0x181277C", Offset = "0x181277C", VA = "0x181277C")]
		public MD_MeshPaint_VR_Input()
		{
		}
	}
}
namespace DG.Tweening
{
	[Token(Token = "0x2000153")]
	public static class DOTweenModuleAudio
	{
		[Token(Token = "0x20001AD")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x11834BC", Offset = "0x11834BC")]
		private sealed class <>c__DisplayClass0_0
		{
			[Token(Token = "0x40006DC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public AudioSource target;

			[Token(Token = "0x60009D2")]
			[Address(RVA = "0x1A28010", Offset = "0x1A28010", VA = "0x1A28010")]
			public <>c__DisplayClass0_0()
			{
			}

			[Token(Token = "0x60009D3")]
			[Address(RVA = "0x1A287D0", Offset = "0x1A287D0", VA = "0x1A287D0")]
			internal float <DOFade>b__0()
			{
				return default(float);
			}

			[Token(Token = "0x60009D4")]
			[Address(RVA = "0x1A287EC", Offset = "0x1A287EC", VA = "0x1A287EC")]
			internal void <DOFade>b__1(float x)
			{
			}
		}

		[Token(Token = "0x20001AE")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x11834CC", Offset = "0x11834CC")]
		private sealed class <>c__DisplayClass1_0
		{
			[Token(Token = "0x40006DD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public AudioSource target;

			[Token(Token = "0x60009D5")]
			[Address(RVA = "0x1A28154", Offset = "0x1A28154", VA = "0x1A28154")]
			public <>c__DisplayClass1_0()
			{
			}

			[Token(Token = "0x60009D6")]
			[Address(RVA = "0x1A28808", Offset = "0x1A28808", VA = "0x1A28808")]
			internal float <DOPitch>b__0()
			{
				return default(float);
			}

			[Token(Token = "0x60009D7")]
			[Address(RVA = "0x1A28824", Offset = "0x1A28824", VA = "0x1A28824")]
			internal void <DOPitch>b__1(float x)
			{
			}
		}

		[Token(Token = "0x20001AF")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x11834DC", Offset = "0x11834DC")]
		private sealed class <>c__DisplayClass2_0
		{
			[Token(Token = "0x40006DE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public AudioMixer target;

			[Token(Token = "0x40006DF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public string floatName;

			[Token(Token = "0x60009D8")]
			[Address(RVA = "0x1A2829C", Offset = "0x1A2829C", VA = "0x1A2829C")]
			public <>c__DisplayClass2_0()
			{
			}

			[Token(Token = "0x60009D9")]
			[Address(RVA = "0x1A28840", Offset = "0x1A28840", VA = "0x1A28840")]
			internal float <DOSetFloat>b__0()
			{
				return default(float);
			}

			[Token(Token = "0x60009DA")]
			[Address(RVA = "0x1A28880", Offset = "0x1A28880", VA = "0x1A28880")]
			internal void <DOSetFloat>b__1(float x)
			{
			}
		}

		[Token(Token = "0x60008FD")]
		[Address(RVA = "0x1A27EAC", Offset = "0x1A27EAC", VA = "0x1A27EAC")]
		public static TweenerCore<float, float, FloatOptions> DOFade(this AudioSource target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x60008FE")]
		[Address(RVA = "0x1A28018", Offset = "0x1A28018", VA = "0x1A28018")]
		public static TweenerCore<float, float, FloatOptions> DOPitch(this AudioSource target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x60008FF")]
		[Address(RVA = "0x1A2815C", Offset = "0x1A2815C", VA = "0x1A2815C")]
		public static TweenerCore<float, float, FloatOptions> DOSetFloat(this AudioMixer target, string floatName, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000900")]
		[Address(RVA = "0x1A282A4", Offset = "0x1A282A4", VA = "0x1A282A4")]
		public static int DOComplete(this AudioMixer target, bool withCallbacks = false)
		{
			return default(int);
		}

		[Token(Token = "0x6000901")]
		[Address(RVA = "0x1A2831C", Offset = "0x1A2831C", VA = "0x1A2831C")]
		public static int DOKill(this AudioMixer target, bool complete = false)
		{
			return default(int);
		}

		[Token(Token = "0x6000902")]
		[Address(RVA = "0x1A28394", Offset = "0x1A28394", VA = "0x1A28394")]
		public static int DOFlip(this AudioMixer target)
		{
			return default(int);
		}

		[Token(Token = "0x6000903")]
		[Address(RVA = "0x1A283FC", Offset = "0x1A283FC", VA = "0x1A283FC")]
		public static int DOGoto(this AudioMixer target, float to, bool andPlay = false)
		{
			return default(int);
		}

		[Token(Token = "0x6000904")]
		[Address(RVA = "0x1A28484", Offset = "0x1A28484", VA = "0x1A28484")]
		public static int DOPause(this AudioMixer target)
		{
			return default(int);
		}

		[Token(Token = "0x6000905")]
		[Address(RVA = "0x1A284EC", Offset = "0x1A284EC", VA = "0x1A284EC")]
		public static int DOPlay(this AudioMixer target)
		{
			return default(int);
		}

		[Token(Token = "0x6000906")]
		[Address(RVA = "0x1A28554", Offset = "0x1A28554", VA = "0x1A28554")]
		public static int DOPlayBackwards(this AudioMixer target)
		{
			return default(int);
		}

		[Token(Token = "0x6000907")]
		[Address(RVA = "0x1A285BC", Offset = "0x1A285BC", VA = "0x1A285BC")]
		public static int DOPlayForward(this AudioMixer target)
		{
			return default(int);
		}

		[Token(Token = "0x6000908")]
		[Address(RVA = "0x1A28624", Offset = "0x1A28624", VA = "0x1A28624")]
		public static int DORestart(this AudioMixer target)
		{
			return default(int);
		}

		[Token(Token = "0x6000909")]
		[Address(RVA = "0x1A28694", Offset = "0x1A28694", VA = "0x1A28694")]
		public static int DORewind(this AudioMixer target)
		{
			return default(int);
		}

		[Token(Token = "0x600090A")]
		[Address(RVA = "0x1A28700", Offset = "0x1A28700", VA = "0x1A28700")]
		public static int DOSmoothRewind(this AudioMixer target)
		{
			return default(int);
		}

		[Token(Token = "0x600090B")]
		[Address(RVA = "0x1A28768", Offset = "0x1A28768", VA = "0x1A28768")]
		public static int DOTogglePause(this AudioMixer target)
		{
			return default(int);
		}
	}
	[Token(Token = "0x2000154")]
	public static class DOTweenModulePhysics
	{
		[Token(Token = "0x20001B0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x11834EC", Offset = "0x11834EC")]
		private sealed class <>c__DisplayClass0_0
		{
			[Token(Token = "0x40006E0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody target;

			[Token(Token = "0x60009DB")]
			[Address(RVA = "0x1A28A14", Offset = "0x1A28A14", VA = "0x1A28A14")]
			public <>c__DisplayClass0_0()
			{
			}

			[Token(Token = "0x60009DC")]
			[Address(RVA = "0x1A29DB0", Offset = "0x1A29DB0", VA = "0x1A29DB0")]
			internal Vector3 <DOMove>b__0()
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x20001B1")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x11834FC", Offset = "0x11834FC")]
		private sealed class <>c__DisplayClass1_0
		{
			[Token(Token = "0x40006E1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody target;

			[Token(Token = "0x60009DD")]
			[Address(RVA = "0x1A28BA4", Offset = "0x1A28BA4", VA = "0x1A28BA4")]
			public <>c__DisplayClass1_0()
			{
			}

			[Token(Token = "0x60009DE")]
			[Address(RVA = "0x1A29EEC", Offset = "0x1A29EEC", VA = "0x1A29EEC")]
			internal Vector3 <DOMoveX>b__0()
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x20001B2")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x118350C", Offset = "0x118350C")]
		private sealed class <>c__DisplayClass2_0
		{
			[Token(Token = "0x40006E2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody target;

			[Token(Token = "0x60009DF")]
			[Address(RVA = "0x1A28D34", Offset = "0x1A28D34", VA = "0x1A28D34")]
			public <>c__DisplayClass2_0()
			{
			}

			[Token(Token = "0x60009E0")]
			[Address(RVA = "0x1A29F08", Offset = "0x1A29F08", VA = "0x1A29F08")]
			internal Vector3 <DOMoveY>b__0()
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x20001B3")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x118351C", Offset = "0x118351C")]
		private sealed class <>c__DisplayClass3_0
		{
			[Token(Token = "0x40006E3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody target;

			[Token(Token = "0x60009E1")]
			[Address(RVA = "0x1A28EC4", Offset = "0x1A28EC4", VA = "0x1A28EC4")]
			public <>c__DisplayClass3_0()
			{
			}

			[Token(Token = "0x60009E2")]
			[Address(RVA = "0x1A29F24", Offset = "0x1A29F24", VA = "0x1A29F24")]
			internal Vector3 <DOMoveZ>b__0()
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x20001B4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x118352C", Offset = "0x118352C")]
		private sealed class <>c__DisplayClass4_0
		{
			[Token(Token = "0x40006E4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody target;

			[Token(Token = "0x60009E3")]
			[Address(RVA = "0x1A29038", Offset = "0x1A29038", VA = "0x1A29038")]
			public <>c__DisplayClass4_0()
			{
			}

			[Token(Token = "0x60009E4")]
			[Address(RVA = "0x1A29F40", Offset = "0x1A29F40", VA = "0x1A29F40")]
			internal Quaternion <DORotate>b__0()
			{
				return default(Quaternion);
			}
		}

		[Token(Token = "0x20001B5")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x118353C", Offset = "0x118353C")]
		private sealed class <>c__DisplayClass5_0
		{
			[Token(Token = "0x40006E5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody target;

			[Token(Token = "0x60009E5")]
			[Address(RVA = "0x1A29224", Offset = "0x1A29224", VA = "0x1A29224")]
			public <>c__DisplayClass5_0()
			{
			}

			[Token(Token = "0x60009E6")]
			[Address(RVA = "0x1A29F5C", Offset = "0x1A29F5C", VA = "0x1A29F5C")]
			internal Quaternion <DOLookAt>b__0()
			{
				return default(Quaternion);
			}
		}

		[Token(Token = "0x20001B6")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x118354C", Offset = "0x118354C")]
		private sealed class <>c__DisplayClass6_0
		{
			[Token(Token = "0x40006E6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody target;

			[Token(Token = "0x40006E7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float startPosY;

			[Token(Token = "0x40006E8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public bool offsetYSet;

			[Token(Token = "0x40006E9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float offsetY;

			[Token(Token = "0x40006EA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Sequence s;

			[Token(Token = "0x40006EB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Vector3 endValue;

			[Token(Token = "0x40006EC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public Tween yTween;

			[Token(Token = "0x60009E7")]
			[Address(RVA = "0x1A296A0", Offset = "0x1A296A0", VA = "0x1A296A0")]
			public <>c__DisplayClass6_0()
			{
			}

			[Token(Token = "0x60009E8")]
			[Address(RVA = "0x1A29F78", Offset = "0x1A29F78", VA = "0x1A29F78")]
			internal Vector3 <DOJump>b__0()
			{
				return default(Vector3);
			}

			[Token(Token = "0x60009E9")]
			[Address(RVA = "0x1A29F94", Offset = "0x1A29F94", VA = "0x1A29F94")]
			internal void <DOJump>b__1()
			{
			}

			[Token(Token = "0x60009EA")]
			[Address(RVA = "0x1A29FC8", Offset = "0x1A29FC8", VA = "0x1A29FC8")]
			internal Vector3 <DOJump>b__2()
			{
				return default(Vector3);
			}

			[Token(Token = "0x60009EB")]
			[Address(RVA = "0x1A29FE4", Offset = "0x1A29FE4", VA = "0x1A29FE4")]
			internal Vector3 <DOJump>b__3()
			{
				return default(Vector3);
			}

			[Token(Token = "0x60009EC")]
			[Address(RVA = "0x1A2A000", Offset = "0x1A2A000", VA = "0x1A2A000")]
			internal void <DOJump>b__4()
			{
			}
		}

		[Token(Token = "0x20001B7")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x118355C", Offset = "0x118355C")]
		private sealed class <>c__DisplayClass7_0
		{
			[Token(Token = "0x40006ED")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody target;

			[Token(Token = "0x60009ED")]
			[Address(RVA = "0x1A29894", Offset = "0x1A29894", VA = "0x1A29894")]
			public <>c__DisplayClass7_0()
			{
			}

			[Token(Token = "0x60009EE")]
			[Address(RVA = "0x1A2A0C0", Offset = "0x1A2A0C0", VA = "0x1A2A0C0")]
			internal Vector3 <DOPath>b__0()
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x20001B8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x118356C", Offset = "0x118356C")]
		private sealed class <>c__DisplayClass8_0
		{
			[Token(Token = "0x40006EE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform trans;

			[Token(Token = "0x40006EF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Rigidbody target;

			[Token(Token = "0x60009EF")]
			[Address(RVA = "0x1A29A9C", Offset = "0x1A29A9C", VA = "0x1A29A9C")]
			public <>c__DisplayClass8_0()
			{
			}

			[Token(Token = "0x60009F0")]
			[Address(RVA = "0x1A2A0DC", Offset = "0x1A2A0DC", VA = "0x1A2A0DC")]
			internal Vector3 <DOLocalPath>b__0()
			{
				return default(Vector3);
			}

			[Token(Token = "0x60009F1")]
			[Address(RVA = "0x1A2A0F8", Offset = "0x1A2A0F8", VA = "0x1A2A0F8")]
			internal void <DOLocalPath>b__1(Vector3 x)
			{
			}
		}

		[Token(Token = "0x20001B9")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x118357C", Offset = "0x118357C")]
		private sealed class <>c__DisplayClass9_0
		{
			[Token(Token = "0x40006F0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody target;

			[Token(Token = "0x60009F2")]
			[Address(RVA = "0x1A29C1C", Offset = "0x1A29C1C", VA = "0x1A29C1C")]
			public <>c__DisplayClass9_0()
			{
			}

			[Token(Token = "0x60009F3")]
			[Address(RVA = "0x1A2A1FC", Offset = "0x1A2A1FC", VA = "0x1A2A1FC")]
			internal Vector3 <DOPath>b__0()
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x20001BA")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x118358C", Offset = "0x118358C")]
		private sealed class <>c__DisplayClass10_0
		{
			[Token(Token = "0x40006F1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform trans;

			[Token(Token = "0x40006F2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Rigidbody target;

			[Token(Token = "0x60009F4")]
			[Address(RVA = "0x1A29DA8", Offset = "0x1A29DA8", VA = "0x1A29DA8")]
			public <>c__DisplayClass10_0()
			{
			}

			[Token(Token = "0x60009F5")]
			[Address(RVA = "0x1A29DCC", Offset = "0x1A29DCC", VA = "0x1A29DCC")]
			internal Vector3 <DOLocalPath>b__0()
			{
				return default(Vector3);
			}

			[Token(Token = "0x60009F6")]
			[Address(RVA = "0x1A29DE8", Offset = "0x1A29DE8", VA = "0x1A29DE8")]
			internal void <DOLocalPath>b__1(Vector3 x)
			{
			}
		}

		[Token(Token = "0x600090C")]
		[Address(RVA = "0x1A288A4", Offset = "0x1A288A4", VA = "0x1A288A4")]
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOMove(this Rigidbody target, Vector3 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x600090D")]
		[Address(RVA = "0x1A28A1C", Offset = "0x1A28A1C", VA = "0x1A28A1C")]
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOMoveX(this Rigidbody target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x600090E")]
		[Address(RVA = "0x1A28BAC", Offset = "0x1A28BAC", VA = "0x1A28BAC")]
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOMoveY(this Rigidbody target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x600090F")]
		[Address(RVA = "0x1A28D3C", Offset = "0x1A28D3C", VA = "0x1A28D3C")]
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOMoveZ(this Rigidbody target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000910")]
		[Address(RVA = "0x1A28ECC", Offset = "0x1A28ECC", VA = "0x1A28ECC")]
		public static TweenerCore<Quaternion, Vector3, QuaternionOptions> DORotate(this Rigidbody target, Vector3 endValue, float duration, RotateMode mode = RotateMode.Fast)
		{
			return null;
		}

		[Token(Token = "0x6000911")]
		[Address(RVA = "0x1A29040", Offset = "0x1A29040", VA = "0x1A29040")]
		public static TweenerCore<Quaternion, Vector3, QuaternionOptions> DOLookAt(this Rigidbody target, Vector3 towards, float duration, AxisConstraint axisConstraint = AxisConstraint.None, [Optional] Vector3? up)
		{
			return null;
		}

		[Token(Token = "0x6000912")]
		[Address(RVA = "0x1A2922C", Offset = "0x1A2922C", VA = "0x1A2922C")]
		public static Sequence DOJump(this Rigidbody target, Vector3 endValue, float jumpPower, int numJumps, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000913")]
		[Address(RVA = "0x1A296A8", Offset = "0x1A296A8", VA = "0x1A296A8")]
		public static TweenerCore<Vector3, Path, PathOptions> DOPath(this Rigidbody target, Vector3[] path, float duration, PathType pathType = PathType.Linear, PathMode pathMode = PathMode.Full3D, int resolution = 10, [Optional] Color? gizmoColor)
		{
			return null;
		}

		[Token(Token = "0x6000914")]
		[Address(RVA = "0x1A2989C", Offset = "0x1A2989C", VA = "0x1A2989C")]
		public static TweenerCore<Vector3, Path, PathOptions> DOLocalPath(this Rigidbody target, Vector3[] path, float duration, PathType pathType = PathType.Linear, PathMode pathMode = PathMode.Full3D, int resolution = 10, [Optional] Color? gizmoColor)
		{
			return null;
		}

		[Token(Token = "0x6000915")]
		[Address(RVA = "0x1A29AA4", Offset = "0x1A29AA4", VA = "0x1A29AA4")]
		internal static TweenerCore<Vector3, Path, PathOptions> DOPath(this Rigidbody target, Path path, float duration, PathMode pathMode = PathMode.Full3D)
		{
			return null;
		}

		[Token(Token = "0x6000916")]
		[Address(RVA = "0x1A29C24", Offset = "0x1A29C24", VA = "0x1A29C24")]
		internal static TweenerCore<Vector3, Path, PathOptions> DOLocalPath(this Rigidbody target, Path path, float duration, PathMode pathMode = PathMode.Full3D)
		{
			return null;
		}
	}
	[Token(Token = "0x2000155")]
	public static class DOTweenModuleSprite
	{
		[Token(Token = "0x20001BB")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x118359C", Offset = "0x118359C")]
		private sealed class <>c__DisplayClass0_0
		{
			[Token(Token = "0x40006F3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public SpriteRenderer target;

			[Token(Token = "0x60009F7")]
			[Address(RVA = "0x1A2A37C", Offset = "0x1A2A37C", VA = "0x1A2A37C")]
			public <>c__DisplayClass0_0()
			{
			}

			[Token(Token = "0x60009F8")]
			[Address(RVA = "0x1A2A874", Offset = "0x1A2A874", VA = "0x1A2A874")]
			internal Color <DOColor>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x60009F9")]
			[Address(RVA = "0x1A2A890", Offset = "0x1A2A890", VA = "0x1A2A890")]
			internal void <DOColor>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x20001BC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x11835AC", Offset = "0x11835AC")]
		private sealed class <>c__DisplayClass1_0
		{
			[Token(Token = "0x40006F4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public SpriteRenderer target;

			[Token(Token = "0x60009FA")]
			[Address(RVA = "0x1A2A4C0", Offset = "0x1A2A4C0", VA = "0x1A2A4C0")]
			public <>c__DisplayClass1_0()
			{
			}

			[Token(Token = "0x60009FB")]
			[Address(RVA = "0x1A2A8AC", Offset = "0x1A2A8AC", VA = "0x1A2A8AC")]
			internal Color <DOFade>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x60009FC")]
			[Address(RVA = "0x1A2A8C8", Offset = "0x1A2A8C8", VA = "0x1A2A8C8")]
			internal void <DOFade>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x20001BD")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x11835BC", Offset = "0x11835BC")]
		private sealed class <>c__DisplayClass3_0
		{
			[Token(Token = "0x40006F5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Color to;

			[Token(Token = "0x40006F6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public SpriteRenderer target;

			[Token(Token = "0x60009FD")]
			[Address(RVA = "0x1A2A86C", Offset = "0x1A2A86C", VA = "0x1A2A86C")]
			public <>c__DisplayClass3_0()
			{
			}

			[Token(Token = "0x60009FE")]
			[Address(RVA = "0x1A2A8E4", Offset = "0x1A2A8E4", VA = "0x1A2A8E4")]
			internal Color <DOBlendableColor>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x60009FF")]
			[Address(RVA = "0x1A2A8F0", Offset = "0x1A2A8F0", VA = "0x1A2A8F0")]
			internal void <DOBlendableColor>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x6000917")]
		[Address(RVA = "0x1A2A218", Offset = "0x1A2A218", VA = "0x1A2A218")]
		public static TweenerCore<Color, Color, ColorOptions> DOColor(this SpriteRenderer target, Color endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000918")]
		[Address(RVA = "0x1A2A384", Offset = "0x1A2A384", VA = "0x1A2A384")]
		public static TweenerCore<Color, Color, ColorOptions> DOFade(this SpriteRenderer target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000919")]
		[Address(RVA = "0x1A2A4C8", Offset = "0x1A2A4C8", VA = "0x1A2A4C8")]
		public static Sequence DOGradientColor(this SpriteRenderer target, Gradient gradient, float duration)
		{
			return null;
		}

		[Token(Token = "0x600091A")]
		[Address(RVA = "0x1A2A688", Offset = "0x1A2A688", VA = "0x1A2A688")]
		public static Tweener DOBlendableColor(this SpriteRenderer target, Color endValue, float duration)
		{
			return null;
		}
	}
	[Token(Token = "0x2000156")]
	public static class DOTweenModuleUI
	{
		[Token(Token = "0x20001BE")]
		public static class Utils
		{
			[Token(Token = "0x6000A00")]
			[Address(RVA = "0x1A2F75C", Offset = "0x1A2F75C", VA = "0x1A2F75C")]
			public static Vector2 SwitchToRectTransform(RectTransform from, RectTransform to)
			{
				return default(Vector2);
			}
		}

		[Token(Token = "0x20001BF")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x11835CC", Offset = "0x11835CC")]
		private sealed class <>c__DisplayClass0_0
		{
			[Token(Token = "0x40006F7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public CanvasGroup target;

			[Token(Token = "0x6000A01")]
			[Address(RVA = "0x1A2AAD8", Offset = "0x1A2AAD8", VA = "0x1A2AAD8")]
			public <>c__DisplayClass0_0()
			{
			}

			[Token(Token = "0x6000A02")]
			[Address(RVA = "0x1A2E618", Offset = "0x1A2E618", VA = "0x1A2E618")]
			internal float <DOFade>b__0()
			{
				return default(float);
			}

			[Token(Token = "0x6000A03")]
			[Address(RVA = "0x1A2E634", Offset = "0x1A2E634", VA = "0x1A2E634")]
			internal void <DOFade>b__1(float x)
			{
			}
		}

		[Token(Token = "0x20001C0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x11835DC", Offset = "0x11835DC")]
		private sealed class <>c__DisplayClass1_0
		{
			[Token(Token = "0x40006F8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Graphic target;

			[Token(Token = "0x6000A04")]
			[Address(RVA = "0x1A2AC44", Offset = "0x1A2AC44", VA = "0x1A2AC44")]
			public <>c__DisplayClass1_0()
			{
			}

			[Token(Token = "0x6000A05")]
			[Address(RVA = "0x1A2E888", Offset = "0x1A2E888", VA = "0x1A2E888")]
			internal Color <DOColor>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x6000A06")]
			[Address(RVA = "0x1A2E8AC", Offset = "0x1A2E8AC", VA = "0x1A2E8AC")]
			internal void <DOColor>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x20001C1")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x11835EC", Offset = "0x11835EC")]
		private sealed class <>c__DisplayClass2_0
		{
			[Token(Token = "0x40006F9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Graphic target;

			[Token(Token = "0x6000A07")]
			[Address(RVA = "0x1A2AD88", Offset = "0x1A2AD88", VA = "0x1A2AD88")]
			public <>c__DisplayClass2_0()
			{
			}

			[Token(Token = "0x6000A08")]
			[Address(RVA = "0x1A2EF14", Offset = "0x1A2EF14", VA = "0x1A2EF14")]
			internal Color <DOFade>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x6000A09")]
			[Address(RVA = "0x1A2EF38", Offset = "0x1A2EF38", VA = "0x1A2EF38")]
			internal void <DOFade>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x20001C2")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x11835FC", Offset = "0x11835FC")]
		private sealed class <>c__DisplayClass3_0
		{
			[Token(Token = "0x40006FA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Image target;

			[Token(Token = "0x6000A0A")]
			[Address(RVA = "0x1A2AEF4", Offset = "0x1A2AEF4", VA = "0x1A2AEF4")]
			public <>c__DisplayClass3_0()
			{
			}

			[Token(Token = "0x6000A0B")]
			[Address(RVA = "0x1A2F400", Offset = "0x1A2F400", VA = "0x1A2F400")]
			internal Color <DOColor>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x6000A0C")]
			[Address(RVA = "0x1A2F424", Offset = "0x1A2F424", VA = "0x1A2F424")]
			internal void <DOColor>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x20001C3")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x118360C", Offset = "0x118360C")]
		private sealed class <>c__DisplayClass4_0
		{
			[Token(Token = "0x40006FB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Image target;

			[Token(Token = "0x6000A0D")]
			[Address(RVA = "0x1A2B038", Offset = "0x1A2B038", VA = "0x1A2B038")]
			public <>c__DisplayClass4_0()
			{
			}

			[Token(Token = "0x6000A0E")]
			[Address(RVA = "0x1A2F448", Offset = "0x1A2F448", VA = "0x1A2F448")]
			internal Color <DOFade>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x6000A0F")]
			[Address(RVA = "0x1A2F46C", Offset = "0x1A2F46C", VA = "0x1A2F46C")]
			internal void <DOFade>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x20001C4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x118361C", Offset = "0x118361C")]
		private sealed class <>c__DisplayClass5_0
		{
			[Token(Token = "0x40006FC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Image target;

			[Token(Token = "0x6000A10")]
			[Address(RVA = "0x1A2B1A0", Offset = "0x1A2B1A0", VA = "0x1A2B1A0")]
			public <>c__DisplayClass5_0()
			{
			}

			[Token(Token = "0x6000A11")]
			[Address(RVA = "0x1A2F490", Offset = "0x1A2F490", VA = "0x1A2F490")]
			internal float <DOFillAmount>b__0()
			{
				return default(float);
			}

			[Token(Token = "0x6000A12")]
			[Address(RVA = "0x1A2F4AC", Offset = "0x1A2F4AC", VA = "0x1A2F4AC")]
			internal void <DOFillAmount>b__1(float x)
			{
			}
		}

		[Token(Token = "0x20001C5")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x118362C", Offset = "0x118362C")]
		private sealed class <>c__DisplayClass7_0
		{
			[Token(Token = "0x40006FD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public LayoutElement target;

			[Token(Token = "0x6000A13")]
			[Address(RVA = "0x1A2B4CC", Offset = "0x1A2B4CC", VA = "0x1A2B4CC")]
			public <>c__DisplayClass7_0()
			{
			}

			[Token(Token = "0x6000A14")]
			[Address(RVA = "0x1A2F4C8", Offset = "0x1A2F4C8", VA = "0x1A2F4C8")]
			internal Vector2 <DOFlexibleSize>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x6000A15")]
			[Address(RVA = "0x1A2F548", Offset = "0x1A2F548", VA = "0x1A2F548")]
			internal void <DOFlexibleSize>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x20001C6")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x118363C", Offset = "0x118363C")]
		private sealed class <>c__DisplayClass8_0
		{
			[Token(Token = "0x40006FE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public LayoutElement target;

			[Token(Token = "0x6000A16")]
			[Address(RVA = "0x1A2B630", Offset = "0x1A2B630", VA = "0x1A2B630")]
			public <>c__DisplayClass8_0()
			{
			}

			[Token(Token = "0x6000A17")]
			[Address(RVA = "0x1A2F5A4", Offset = "0x1A2F5A4", VA = "0x1A2F5A4")]
			internal Vector2 <DOMinSize>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x6000A18")]
			[Address(RVA = "0x1A2F624", Offset = "0x1A2F624", VA = "0x1A2F624")]
			internal void <DOMinSize>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x20001C7")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x118364C", Offset = "0x118364C")]
		private sealed class <>c__DisplayClass9_0
		{
			[Token(Token = "0x40006FF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public LayoutElement target;

			[Token(Token = "0x6000A19")]
			[Address(RVA = "0x1A2B794", Offset = "0x1A2B794", VA = "0x1A2B794")]
			public <>c__DisplayClass9_0()
			{
			}

			[Token(Token = "0x6000A1A")]
			[Address(RVA = "0x1A2F680", Offset = "0x1A2F680", VA = "0x1A2F680")]
			internal Vector2 <DOPreferredSize>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x6000A1B")]
			[Address(RVA = "0x1A2F700", Offset = "0x1A2F700", VA = "0x1A2F700")]
			internal void <DOPreferredSize>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x20001C8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x118365C", Offset = "0x118365C")]
		private sealed class <>c__DisplayClass10_0
		{
			[Token(Token = "0x4000700")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Outline target;

			[Token(Token = "0x6000A1C")]
			[Address(RVA = "0x1A2B900", Offset = "0x1A2B900", VA = "0x1A2B900")]
			public <>c__DisplayClass10_0()
			{
			}

			[Token(Token = "0x6000A1D")]
			[Address(RVA = "0x1A2E650", Offset = "0x1A2E650", VA = "0x1A2E650")]
			internal Color <DOColor>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x6000A1E")]
			[Address(RVA = "0x1A2E670", Offset = "0x1A2E670", VA = "0x1A2E670")]
			internal void <DOColor>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x20001C9")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x118366C", Offset = "0x118366C")]
		private sealed class <>c__DisplayClass11_0
		{
			[Token(Token = "0x4000701")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Outline target;

			[Token(Token = "0x6000A1F")]
			[Address(RVA = "0x1A2BA44", Offset = "0x1A2BA44", VA = "0x1A2BA44")]
			public <>c__DisplayClass11_0()
			{
			}

			[Token(Token = "0x6000A20")]
			[Address(RVA = "0x1A2E68C", Offset = "0x1A2E68C", VA = "0x1A2E68C")]
			internal Color <DOFade>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x6000A21")]
			[Address(RVA = "0x1A2E6AC", Offset = "0x1A2E6AC", VA = "0x1A2E6AC")]
			internal void <DOFade>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x20001CA")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x118367C", Offset = "0x118367C")]
		private sealed class <>c__DisplayClass12_0
		{
			[Token(Token = "0x4000702")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Outline target;

			[Token(Token = "0x6000A22")]
			[Address(RVA = "0x1A2BB98", Offset = "0x1A2BB98", VA = "0x1A2BB98")]
			public <>c__DisplayClass12_0()
			{
			}

			[Token(Token = "0x6000A23")]
			[Address(RVA = "0x1A2E6C8", Offset = "0x1A2E6C8", VA = "0x1A2E6C8")]
			internal Vector2 <DOScale>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x6000A24")]
			[Address(RVA = "0x1A2E6E4", Offset = "0x1A2E6E4", VA = "0x1A2E6E4")]
			internal void <DOScale>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x20001CB")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x118368C", Offset = "0x118368C")]
		private sealed class <>c__DisplayClass13_0
		{
			[Token(Token = "0x4000703")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x6000A25")]
			[Address(RVA = "0x1A2BCFC", Offset = "0x1A2BCFC", VA = "0x1A2BCFC")]
			public <>c__DisplayClass13_0()
			{
			}

			[Token(Token = "0x6000A26")]
			[Address(RVA = "0x1A2E700", Offset = "0x1A2E700", VA = "0x1A2E700")]
			internal Vector2 <DOAnchorPos>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x6000A27")]
			[Address(RVA = "0x1A2E71C", Offset = "0x1A2E71C", VA = "0x1A2E71C")]
			internal void <DOAnchorPos>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x20001CC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x118369C", Offset = "0x118369C")]
		private sealed class <>c__DisplayClass14_0
		{
			[Token(Token = "0x4000704")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x6000A28")]
			[Address(RVA = "0x1A2BE74", Offset = "0x1A2BE74", VA = "0x1A2BE74")]
			public <>c__DisplayClass14_0()
			{
			}

			[Token(Token = "0x6000A29")]
			[Address(RVA = "0x1A2E738", Offset = "0x1A2E738", VA = "0x1A2E738")]
			internal Vector2 <DOAnchorPosX>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x6000A2A")]
			[Address(RVA = "0x1A2E754", Offset = "0x1A2E754", VA = "0x1A2E754")]
			internal void <DOAnchorPosX>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x20001CD")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x11836AC", Offset = "0x11836AC")]
		private sealed class <>c__DisplayClass15_0
		{
			[Token(Token = "0x4000705")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x6000A2B")]
			[Address(RVA = "0x1A2BFEC", Offset = "0x1A2BFEC", VA = "0x1A2BFEC")]
			public <>c__DisplayClass15_0()
			{
			}

			[Token(Token = "0x6000A2C")]
			[Address(RVA = "0x1A2E770", Offset = "0x1A2E770", VA = "0x1A2E770")]
			internal Vector2 <DOAnchorPosY>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x6000A2D")]
			[Address(RVA = "0x1A2E78C", Offset = "0x1A2E78C", VA = "0x1A2E78C")]
			internal void <DOAnchorPosY>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x20001CE")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x11836BC", Offset = "0x11836BC")]
		private sealed class <>c__DisplayClass16_0
		{
			[Token(Token = "0x4000706")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x6000A2E")]
			[Address(RVA = "0x1A2C158", Offset = "0x1A2C158", VA = "0x1A2C158")]
			public <>c__DisplayClass16_0()
			{
			}

			[Token(Token = "0x6000A2F")]
			[Address(RVA = "0x1A2E7A8", Offset = "0x1A2E7A8", VA = "0x1A2E7A8")]
			internal Vector3 <DOAnchorPos3D>b__0()
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000A30")]
			[Address(RVA = "0x1A2E7C4", Offset = "0x1A2E7C4", VA = "0x1A2E7C4")]
			internal void <DOAnchorPos3D>b__1(Vector3 x)
			{
			}
		}

		[Token(Token = "0x20001CF")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x11836CC", Offset = "0x11836CC")]
		private sealed class <>c__DisplayClass17_0
		{
			[Token(Token = "0x4000707")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x6000A31")]
			[Address(RVA = "0x1A2C2DC", Offset = "0x1A2C2DC", VA = "0x1A2C2DC")]
			public <>c__DisplayClass17_0()
			{
			}

			[Token(Token = "0x6000A32")]
			[Address(RVA = "0x1A2E7E0", Offset = "0x1A2E7E0", VA = "0x1A2E7E0")]
			internal Vector3 <DOAnchorPos3DX>b__0()
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000A33")]
			[Address(RVA = "0x1A2E7FC", Offset = "0x1A2E7FC", VA = "0x1A2E7FC")]
			internal void <DOAnchorPos3DX>b__1(Vector3 x)
			{
			}
		}

		[Token(Token = "0x20001D0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x11836DC", Offset = "0x11836DC")]
		private sealed class <>c__DisplayClass18_0
		{
			[Token(Token = "0x4000708")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x6000A34")]
			[Address(RVA = "0x1A2C460", Offset = "0x1A2C460", VA = "0x1A2C460")]
			public <>c__DisplayClass18_0()
			{
			}

			[Token(Token = "0x6000A35")]
			[Address(RVA = "0x1A2E818", Offset = "0x1A2E818", VA = "0x1A2E818")]
			internal Vector3 <DOAnchorPos3DY>b__0()
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000A36")]
			[Address(RVA = "0x1A2E834", Offset = "0x1A2E834", VA = "0x1A2E834")]
			internal void <DOAnchorPos3DY>b__1(Vector3 x)
			{
			}
		}

		[Token(Token = "0x20001D1")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x11836EC", Offset = "0x11836EC")]
		private sealed class <>c__DisplayClass19_0
		{
			[Token(Token = "0x4000709")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x6000A37")]
			[Address(RVA = "0x1A2C5E4", Offset = "0x1A2C5E4", VA = "0x1A2C5E4")]
			public <>c__DisplayClass19_0()
			{
			}

			[Token(Token = "0x6000A38")]
			[Address(RVA = "0x1A2E850", Offset = "0x1A2E850", VA = "0x1A2E850")]
			internal Vector3 <DOAnchorPos3DZ>b__0()
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000A39")]
			[Address(RVA = "0x1A2E86C", Offset = "0x1A2E86C", VA = "0x1A2E86C")]
			internal void <DOAnchorPos3DZ>b__1(Vector3 x)
			{
			}
		}

		[Token(Token = "0x20001D2")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x11836FC", Offset = "0x11836FC")]
		private sealed class <>c__DisplayClass20_0
		{
			[Token(Token = "0x400070A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x6000A3A")]
			[Address(RVA = "0x1A2C748", Offset = "0x1A2C748", VA = "0x1A2C748")]
			public <>c__DisplayClass20_0()
			{
			}

			[Token(Token = "0x6000A3B")]
			[Address(RVA = "0x1A2E8D0", Offset = "0x1A2E8D0", VA = "0x1A2E8D0")]
			internal Vector2 <DOAnchorMax>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x6000A3C")]
			[Address(RVA = "0x1A2E8EC", Offset = "0x1A2E8EC", VA = "0x1A2E8EC")]
			internal void <DOAnchorMax>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x20001D3")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x118370C", Offset = "0x118370C")]
		private sealed class <>c__DisplayClass21_0
		{
			[Token(Token = "0x400070B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x6000A3D")]
			[Address(RVA = "0x1A2C8AC", Offset = "0x1A2C8AC", VA = "0x1A2C8AC")]
			public <>c__DisplayClass21_0()
			{
			}

			[Token(Token = "0x6000A3E")]
			[Address(RVA = "0x1A2E908", Offset = "0x1A2E908", VA = "0x1A2E908")]
			internal Vector2 <DOAnchorMin>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x6000A3F")]
			[Address(RVA = "0x1A2E924", Offset = "0x1A2E924", VA = "0x1A2E924")]
			internal void <DOAnchorMin>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x20001D4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x118371C", Offset = "0x118371C")]
		private sealed class <>c__DisplayClass22_0
		{
			[Token(Token = "0x400070C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x6000A40")]
			[Address(RVA = "0x1A2CA00", Offset = "0x1A2CA00", VA = "0x1A2CA00")]
			public <>c__DisplayClass22_0()
			{
			}

			[Token(Token = "0x6000A41")]
			[Address(RVA = "0x1A2E940", Offset = "0x1A2E940", VA = "0x1A2E940")]
			internal Vector2 <DOPivot>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x6000A42")]
			[Address(RVA = "0x1A2E95C", Offset = "0x1A2E95C", VA = "0x1A2E95C")]
			internal void <DOPivot>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x20001D5")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x118372C", Offset = "0x118372C")]
		private sealed class <>c__DisplayClass23_0
		{
			[Token(Token = "0x400070D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x6000A43")]
			[Address(RVA = "0x1A2CB6C", Offset = "0x1A2CB6C", VA = "0x1A2CB6C")]
			public <>c__DisplayClass23_0()
			{
			}

			[Token(Token = "0x6000A44")]
			[Address(RVA = "0x1A2E978", Offset = "0x1A2E978", VA = "0x1A2E978")]
			internal Vector2 <DOPivotX>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x6000A45")]
			[Address(RVA = "0x1A2E994", Offset = "0x1A2E994", VA = "0x1A2E994")]
			internal void <DOPivotX>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x20001D6")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x118373C", Offset = "0x118373C")]
		private sealed class <>c__DisplayClass24_0
		{
			[Token(Token = "0x400070E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x6000A46")]
			[Address(RVA = "0x1A2CCD8", Offset = "0x1A2CCD8", VA = "0x1A2CCD8")]
			public <>c__DisplayClass24_0()
			{
			}

			[Token(Token = "0x6000A47")]
			[Address(RVA = "0x1A2E9B0", Offset = "0x1A2E9B0", VA = "0x1A2E9B0")]
			internal Vector2 <DOPivotY>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x6000A48")]
			[Address(RVA = "0x1A2E9CC", Offset = "0x1A2E9CC", VA = "0x1A2E9CC")]
			internal void <DOPivotY>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x20001D7")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x118374C", Offset = "0x118374C")]
		private sealed class <>c__DisplayClass25_0
		{
			[Token(Token = "0x400070F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x6000A49")]
			[Address(RVA = "0x1A2CE3C", Offset = "0x1A2CE3C", VA = "0x1A2CE3C")]
			public <>c__DisplayClass25_0()
			{
			}

			[Token(Token = "0x6000A4A")]
			[Address(RVA = "0x1A2E9E8", Offset = "0x1A2E9E8", VA = "0x1A2E9E8")]
			internal Vector2 <DOSizeDelta>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x6000A4B")]
			[Address(RVA = "0x1A2EA04", Offset = "0x1A2EA04", VA = "0x1A2EA04")]
			internal void <DOSizeDelta>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x20001D8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x118375C", Offset = "0x118375C")]
		private sealed class <>c__DisplayClass26_0
		{
			[Token(Token = "0x4000710")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x6000A4C")]
			[Address(RVA = "0x1A2CFF4", Offset = "0x1A2CFF4", VA = "0x1A2CFF4")]
			public <>c__DisplayClass26_0()
			{
			}

			[Token(Token = "0x6000A4D")]
			[Address(RVA = "0x1A2EA20", Offset = "0x1A2EA20", VA = "0x1A2EA20")]
			internal Vector3 <DOPunchAnchorPos>b__0()
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000A4E")]
			[Address(RVA = "0x1A2EAB0", Offset = "0x1A2EAB0", VA = "0x1A2EAB0")]
			internal void <DOPunchAnchorPos>b__1(Vector3 x)
			{
			}
		}

		[Token(Token = "0x20001D9")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x118376C", Offset = "0x118376C")]
		private sealed class <>c__DisplayClass27_0
		{
			[Token(Token = "0x4000711")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x6000A4F")]
			[Address(RVA = "0x1A2D17C", Offset = "0x1A2D17C", VA = "0x1A2D17C")]
			public <>c__DisplayClass27_0()
			{
			}

			[Token(Token = "0x6000A50")]
			[Address(RVA = "0x1A2EB54", Offset = "0x1A2EB54", VA = "0x1A2EB54")]
			internal Vector3 <DOShakeAnchorPos>b__0()
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000A51")]
			[Address(RVA = "0x1A2EBE4", Offset = "0x1A2EBE4", VA = "0x1A2EBE4")]
			internal void <DOShakeAnchorPos>b__1(Vector3 x)
			{
			}
		}

		[Token(Token = "0x20001DA")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x118377C", Offset = "0x118377C")]
		private sealed class <>c__DisplayClass28_0
		{
			[Token(Token = "0x4000712")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x6000A52")]
			[Address(RVA = "0x1A2D350", Offset = "0x1A2D350", VA = "0x1A2D350")]
			public <>c__DisplayClass28_0()
			{
			}

			[Token(Token = "0x6000A53")]
			[Address(RVA = "0x1A2EC88", Offset = "0x1A2EC88", VA = "0x1A2EC88")]
			internal Vector3 <DOShakeAnchorPos>b__0()
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000A54")]
			[Address(RVA = "0x1A2ED18", Offset = "0x1A2ED18", VA = "0x1A2ED18")]
			internal void <DOShakeAnchorPos>b__1(Vector3 x)
			{
			}
		}

		[Token(Token = "0x20001DB")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x118378C", Offset = "0x118378C")]
		private sealed class <>c__DisplayClass29_0
		{
			[Token(Token = "0x4000713")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x4000714")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float startPosY;

			[Token(Token = "0x4000715")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public bool offsetYSet;

			[Token(Token = "0x4000716")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float offsetY;

			[Token(Token = "0x4000717")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Sequence s;

			[Token(Token = "0x4000718")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Vector2 endValue;

			[Token(Token = "0x6000A55")]
			[Address(RVA = "0x1A2D6D4", Offset = "0x1A2D6D4", VA = "0x1A2D6D4")]
			public <>c__DisplayClass29_0()
			{
			}

			[Token(Token = "0x6000A56")]
			[Address(RVA = "0x1A2EDBC", Offset = "0x1A2EDBC", VA = "0x1A2EDBC")]
			internal Vector2 <DOJumpAnchorPos>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x6000A57")]
			[Address(RVA = "0x1A2EDD8", Offset = "0x1A2EDD8", VA = "0x1A2EDD8")]
			internal void <DOJumpAnchorPos>b__1(Vector2 x)
			{
			}

			[Token(Token = "0x6000A58")]
			[Address(RVA = "0x1A2EDF4", Offset = "0x1A2EDF4", VA = "0x1A2EDF4")]
			internal void <DOJumpAnchorPos>b__2()
			{
			}

			[Token(Token = "0x6000A59")]
			[Address(RVA = "0x1A2EE28", Offset = "0x1A2EE28", VA = "0x1A2EE28")]
			internal Vector2 <DOJumpAnchorPos>b__3()
			{
				return default(Vector2);
			}

			[Token(Token = "0x6000A5A")]
			[Address(RVA = "0x1A2EE44", Offset = "0x1A2EE44", VA = "0x1A2EE44")]
			internal void <DOJumpAnchorPos>b__4(Vector2 x)
			{
			}

			[Token(Token = "0x6000A5B")]
			[Address(RVA = "0x1A2EE60", Offset = "0x1A2EE60", VA = "0x1A2EE60")]
			internal void <DOJumpAnchorPos>b__5()
			{
			}
		}

		[Token(Token = "0x20001DC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x118379C", Offset = "0x118379C")]
		private sealed class <>c__DisplayClass30_0
		{
			[Token(Token = "0x4000719")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public ScrollRect target;

			[Token(Token = "0x6000A5C")]
			[Address(RVA = "0x1A2D82C", Offset = "0x1A2D82C", VA = "0x1A2D82C")]
			public <>c__DisplayClass30_0()
			{
			}

			[Token(Token = "0x6000A5D")]
			[Address(RVA = "0x1A2EF5C", Offset = "0x1A2EF5C", VA = "0x1A2EF5C")]
			internal Vector2 <DONormalizedPos>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x6000A5E")]
			[Address(RVA = "0x1A2EFCC", Offset = "0x1A2EFCC", VA = "0x1A2EFCC")]
			internal void <DONormalizedPos>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x20001DD")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x11837AC", Offset = "0x11837AC")]
		private sealed class <>c__DisplayClass31_0
		{
			[Token(Token = "0x400071A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public ScrollRect target;

			[Token(Token = "0x6000A5F")]
			[Address(RVA = "0x1A2D974", Offset = "0x1A2D974", VA = "0x1A2D974")]
			public <>c__DisplayClass31_0()
			{
			}

			[Token(Token = "0x6000A60")]
			[Address(RVA = "0x1A2F018", Offset = "0x1A2F018", VA = "0x1A2F018")]
			internal float <DOHorizontalNormalizedPos>b__0()
			{
				return default(float);
			}

			[Token(Token = "0x6000A61")]
			[Address(RVA = "0x1A2F034", Offset = "0x1A2F034", VA = "0x1A2F034")]
			internal void <DOHorizontalNormalizedPos>b__1(float x)
			{
			}
		}

		[Token(Token = "0x20001DE")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x11837BC", Offset = "0x11837BC")]
		private sealed class <>c__DisplayClass32_0
		{
			[Token(Token = "0x400071B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public ScrollRect target;

			[Token(Token = "0x6000A62")]
			[Address(RVA = "0x1A2DABC", Offset = "0x1A2DABC", VA = "0x1A2DABC")]
			public <>c__DisplayClass32_0()
			{
			}

			[Token(Token = "0x6000A63")]
			[Address(RVA = "0x1A2F050", Offset = "0x1A2F050", VA = "0x1A2F050")]
			internal float <DOVerticalNormalizedPos>b__0()
			{
				return default(float);
			}

			[Token(Token = "0x6000A64")]
			[Address(RVA = "0x1A2F06C", Offset = "0x1A2F06C", VA = "0x1A2F06C")]
			internal void <DOVerticalNormalizedPos>b__1(float x)
			{
			}
		}

		[Token(Token = "0x20001DF")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x11837CC", Offset = "0x11837CC")]
		private sealed class <>c__DisplayClass33_0
		{
			[Token(Token = "0x400071C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Slider target;

			[Token(Token = "0x6000A65")]
			[Address(RVA = "0x1A2DC10", Offset = "0x1A2DC10", VA = "0x1A2DC10")]
			public <>c__DisplayClass33_0()
			{
			}

			[Token(Token = "0x6000A66")]
			[Address(RVA = "0x1A2F088", Offset = "0x1A2F088", VA = "0x1A2F088")]
			internal float <DOValue>b__0()
			{
				return default(float);
			}

			[Token(Token = "0x6000A67")]
			[Address(RVA = "0x1A2F0AC", Offset = "0x1A2F0AC", VA = "0x1A2F0AC")]
			internal void <DOValue>b__1(float x)
			{
			}
		}

		[Token(Token = "0x20001E0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x11837DC", Offset = "0x11837DC")]
		private sealed class <>c__DisplayClass34_0
		{
			[Token(Token = "0x400071D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Text target;

			[Token(Token = "0x6000A68")]
			[Address(RVA = "0x1A2DD7C", Offset = "0x1A2DD7C", VA = "0x1A2DD7C")]
			public <>c__DisplayClass34_0()
			{
			}

			[Token(Token = "0x6000A69")]
			[Address(RVA = "0x1A2F0D0", Offset = "0x1A2F0D0", VA = "0x1A2F0D0")]
			internal Color <DOColor>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x6000A6A")]
			[Address(RVA = "0x1A2F0F4", Offset = "0x1A2F0F4", VA = "0x1A2F0F4")]
			internal void <DOColor>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x20001E1")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x11837EC", Offset = "0x11837EC")]
		private sealed class <>c__DisplayClass35_0
		{
			[Token(Token = "0x400071E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Text target;

			[Token(Token = "0x6000A6B")]
			[Address(RVA = "0x1A2DEC0", Offset = "0x1A2DEC0", VA = "0x1A2DEC0")]
			public <>c__DisplayClass35_0()
			{
			}

			[Token(Token = "0x6000A6C")]
			[Address(RVA = "0x1A2F118", Offset = "0x1A2F118", VA = "0x1A2F118")]
			internal Color <DOFade>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x6000A6D")]
			[Address(RVA = "0x1A2F13C", Offset = "0x1A2F13C", VA = "0x1A2F13C")]
			internal void <DOFade>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x20001E2")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x11837FC", Offset = "0x11837FC")]
		private sealed class <>c__DisplayClass36_0
		{
			[Token(Token = "0x400071F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Text target;

			[Token(Token = "0x6000A6E")]
			[Address(RVA = "0x1A2E034", Offset = "0x1A2E034", VA = "0x1A2E034")]
			public <>c__DisplayClass36_0()
			{
			}

			[Token(Token = "0x6000A6F")]
			[Address(RVA = "0x1A2F160", Offset = "0x1A2F160", VA = "0x1A2F160")]
			internal string <DOText>b__0()
			{
				return null;
			}

			[Token(Token = "0x6000A70")]
			[Address(RVA = "0x1A2F184", Offset = "0x1A2F184", VA = "0x1A2F184")]
			internal void <DOText>b__1(string x)
			{
			}
		}

		[Token(Token = "0x20001E3")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x118380C", Offset = "0x118380C")]
		private sealed class <>c__DisplayClass37_0
		{
			[Token(Token = "0x4000720")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Color to;

			[Token(Token = "0x4000721")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Graphic target;

			[Token(Token = "0x6000A71")]
			[Address(RVA = "0x1A2E228", Offset = "0x1A2E228", VA = "0x1A2E228")]
			public <>c__DisplayClass37_0()
			{
			}

			[Token(Token = "0x6000A72")]
			[Address(RVA = "0x1A2F1A8", Offset = "0x1A2F1A8", VA = "0x1A2F1A8")]
			internal Color <DOBlendableColor>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x6000A73")]
			[Address(RVA = "0x1A2F1B4", Offset = "0x1A2F1B4", VA = "0x1A2F1B4")]
			internal void <DOBlendableColor>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x20001E4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x118381C", Offset = "0x118381C")]
		private sealed class <>c__DisplayClass38_0
		{
			[Token(Token = "0x4000722")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Color to;

			[Token(Token = "0x4000723")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Image target;

			[Token(Token = "0x6000A74")]
			[Address(RVA = "0x1A2E41C", Offset = "0x1A2E41C", VA = "0x1A2E41C")]
			public <>c__DisplayClass38_0()
			{
			}

			[Token(Token = "0x6000A75")]
			[Address(RVA = "0x1A2F270", Offset = "0x1A2F270", VA = "0x1A2F270")]
			internal Color <DOBlendableColor>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x6000A76")]
			[Address(RVA = "0x1A2F27C", Offset = "0x1A2F27C", VA = "0x1A2F27C")]
			internal void <DOBlendableColor>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x20001E5")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x118382C", Offset = "0x118382C")]
		private sealed class <>c__DisplayClass39_0
		{
			[Token(Token = "0x4000724")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Color to;

			[Token(Token = "0x4000725")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Text target;

			[Token(Token = "0x6000A77")]
			[Address(RVA = "0x1A2E610", Offset = "0x1A2E610", VA = "0x1A2E610")]
			public <>c__DisplayClass39_0()
			{
			}

			[Token(Token = "0x6000A78")]
			[Address(RVA = "0x1A2F338", Offset = "0x1A2F338", VA = "0x1A2F338")]
			internal Color <DOBlendableColor>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x6000A79")]
			[Address(RVA = "0x1A2F344", Offset = "0x1A2F344", VA = "0x1A2F344")]
			internal void <DOBlendableColor>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x600091B")]
		[Address(RVA = "0x1A2A99C", Offset = "0x1A2A99C", VA = "0x1A2A99C")]
		public static TweenerCore<float, float, FloatOptions> DOFade(this CanvasGroup target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x600091C")]
		[Address(RVA = "0x1A2AAE0", Offset = "0x1A2AAE0", VA = "0x1A2AAE0")]
		public static TweenerCore<Color, Color, ColorOptions> DOColor(this Graphic target, Color endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x600091D")]
		[Address(RVA = "0x1A2AC4C", Offset = "0x1A2AC4C", VA = "0x1A2AC4C")]
		public static TweenerCore<Color, Color, ColorOptions> DOFade(this Graphic target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x600091E")]
		[Address(RVA = "0x1A2AD90", Offset = "0x1A2AD90", VA = "0x1A2AD90")]
		public static TweenerCore<Color, Color, ColorOptions> DOColor(this Image target, Color endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x600091F")]
		[Address(RVA = "0x1A2AEFC", Offset = "0x1A2AEFC", VA = "0x1A2AEFC")]
		public static TweenerCore<Color, Color, ColorOptions> DOFade(this Image target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000920")]
		[Address(RVA = "0x1A2B040", Offset = "0x1A2B040", VA = "0x1A2B040")]
		public static TweenerCore<float, float, FloatOptions> DOFillAmount(this Image target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000921")]
		[Address(RVA = "0x1A2B1A8", Offset = "0x1A2B1A8", VA = "0x1A2B1A8")]
		public static Sequence DOGradientColor(this Image target, Gradient gradient, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000922")]
		[Address(RVA = "0x1A2B370", Offset = "0x1A2B370", VA = "0x1A2B370")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOFlexibleSize(this LayoutElement target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000923")]
		[Address(RVA = "0x1A2B4D4", Offset = "0x1A2B4D4", VA = "0x1A2B4D4")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOMinSize(this LayoutElement target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000924")]
		[Address(RVA = "0x1A2B638", Offset = "0x1A2B638", VA = "0x1A2B638")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOPreferredSize(this LayoutElement target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000925")]
		[Address(RVA = "0x1A2B79C", Offset = "0x1A2B79C", VA = "0x1A2B79C")]
		public static TweenerCore<Color, Color, ColorOptions> DOColor(this Outline target, Color endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000926")]
		[Address(RVA = "0x1A2B908", Offset = "0x1A2B908", VA = "0x1A2B908")]
		public static TweenerCore<Color, Color, ColorOptions> DOFade(this Outline target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000927")]
		[Address(RVA = "0x1A2BA4C", Offset = "0x1A2BA4C", VA = "0x1A2BA4C")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOScale(this Outline target, Vector2 endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000928")]
		[Address(RVA = "0x1A2BBA0", Offset = "0x1A2BBA0", VA = "0x1A2BBA0")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOAnchorPos(this RectTransform target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000929")]
		[Address(RVA = "0x1A2BD04", Offset = "0x1A2BD04", VA = "0x1A2BD04")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOAnchorPosX(this RectTransform target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x600092A")]
		[Address(RVA = "0x1A2BE7C", Offset = "0x1A2BE7C", VA = "0x1A2BE7C")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOAnchorPosY(this RectTransform target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x600092B")]
		[Address(RVA = "0x1A2BFF4", Offset = "0x1A2BFF4", VA = "0x1A2BFF4")]
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOAnchorPos3D(this RectTransform target, Vector3 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x600092C")]
		[Address(RVA = "0x1A2C160", Offset = "0x1A2C160", VA = "0x1A2C160")]
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOAnchorPos3DX(this RectTransform target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x600092D")]
		[Address(RVA = "0x1A2C2E4", Offset = "0x1A2C2E4", VA = "0x1A2C2E4")]
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOAnchorPos3DY(this RectTransform target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x600092E")]
		[Address(RVA = "0x1A2C468", Offset = "0x1A2C468", VA = "0x1A2C468")]
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOAnchorPos3DZ(this RectTransform target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x600092F")]
		[Address(RVA = "0x1A2C5EC", Offset = "0x1A2C5EC", VA = "0x1A2C5EC")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOAnchorMax(this RectTransform target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000930")]
		[Address(RVA = "0x1A2C750", Offset = "0x1A2C750", VA = "0x1A2C750")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOAnchorMin(this RectTransform target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000931")]
		[Address(RVA = "0x1A2C8B4", Offset = "0x1A2C8B4", VA = "0x1A2C8B4")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOPivot(this RectTransform target, Vector2 endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000932")]
		[Address(RVA = "0x1A2CA08", Offset = "0x1A2CA08", VA = "0x1A2CA08")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOPivotX(this RectTransform target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000933")]
		[Address(RVA = "0x1A2CB74", Offset = "0x1A2CB74", VA = "0x1A2CB74")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOPivotY(this RectTransform target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000934")]
		[Address(RVA = "0x1A2CCE0", Offset = "0x1A2CCE0", VA = "0x1A2CCE0")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOSizeDelta(this RectTransform target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000935")]
		[Address(RVA = "0x1A2CE44", Offset = "0x1A2CE44", VA = "0x1A2CE44")]
		public static Tweener DOPunchAnchorPos(this RectTransform target, Vector2 punch, float duration, int vibrato = 10, float elasticity = 1f, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000936")]
		[Address(RVA = "0x1A2CFFC", Offset = "0x1A2CFFC", VA = "0x1A2CFFC")]
		public static Tweener DOShakeAnchorPos(this RectTransform target, float duration, float strength = 100f, int vibrato = 10, float randomness = 90f, bool snapping = false, bool fadeOut = true)
		{
			return null;
		}

		[Token(Token = "0x6000937")]
		[Address(RVA = "0x1A2D184", Offset = "0x1A2D184", VA = "0x1A2D184")]
		public static Tweener DOShakeAnchorPos(this RectTransform target, float duration, Vector2 strength, int vibrato = 10, float randomness = 90f, bool snapping = false, bool fadeOut = true)
		{
			return null;
		}

		[Token(Token = "0x6000938")]
		[Address(RVA = "0x1A2D358", Offset = "0x1A2D358", VA = "0x1A2D358")]
		public static Sequence DOJumpAnchorPos(this RectTransform target, Vector2 endValue, float jumpPower, int numJumps, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000939")]
		[Address(RVA = "0x1A2D6DC", Offset = "0x1A2D6DC", VA = "0x1A2D6DC")]
		public static Tweener DONormalizedPos(this ScrollRect target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x600093A")]
		[Address(RVA = "0x1A2D834", Offset = "0x1A2D834", VA = "0x1A2D834")]
		public static Tweener DOHorizontalNormalizedPos(this ScrollRect target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x600093B")]
		[Address(RVA = "0x1A2D97C", Offset = "0x1A2D97C", VA = "0x1A2D97C")]
		public static Tweener DOVerticalNormalizedPos(this ScrollRect target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x600093C")]
		[Address(RVA = "0x1A2DAC4", Offset = "0x1A2DAC4", VA = "0x1A2DAC4")]
		public static TweenerCore<float, float, FloatOptions> DOValue(this Slider target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x600093D")]
		[Address(RVA = "0x1A2DC18", Offset = "0x1A2DC18", VA = "0x1A2DC18")]
		public static TweenerCore<Color, Color, ColorOptions> DOColor(this Text target, Color endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x600093E")]
		[Address(RVA = "0x1A2DD84", Offset = "0x1A2DD84", VA = "0x1A2DD84")]
		public static TweenerCore<Color, Color, ColorOptions> DOFade(this Text target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x600093F")]
		[Address(RVA = "0x1A2DEC8", Offset = "0x1A2DEC8", VA = "0x1A2DEC8")]
		public static TweenerCore<string, string, StringOptions> DOText(this Text target, string endValue, float duration, bool richTextEnabled = true, ScrambleMode scrambleMode = ScrambleMode.None, [Optional] string scrambleChars)
		{
			return null;
		}

		[Token(Token = "0x6000940")]
		[Address(RVA = "0x1A2E03C", Offset = "0x1A2E03C", VA = "0x1A2E03C")]
		public static Tweener DOBlendableColor(this Graphic target, Color endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000941")]
		[Address(RVA = "0x1A2E230", Offset = "0x1A2E230", VA = "0x1A2E230")]
		public static Tweener DOBlendableColor(this Image target, Color endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000942")]
		[Address(RVA = "0x1A2E424", Offset = "0x1A2E424", VA = "0x1A2E424")]
		public static Tweener DOBlendableColor(this Text target, Color endValue, float duration)
		{
			return null;
		}
	}
	[Token(Token = "0x2000157")]
	public static class DOTweenModuleUnityVersion
	{
		[Token(Token = "0x20001E6")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x118383C", Offset = "0x118383C")]
		private sealed class <>c__DisplayClass8_0
		{
			[Token(Token = "0x4000726")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Material target;

			[Token(Token = "0x4000727")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public int propertyID;

			[Token(Token = "0x6000A7A")]
			[Address(RVA = "0x1A30338", Offset = "0x1A30338", VA = "0x1A30338")]
			public <>c__DisplayClass8_0()
			{
			}

			[Token(Token = "0x6000A7B")]
			[Address(RVA = "0x1A304E4", Offset = "0x1A304E4", VA = "0x1A304E4")]
			internal Vector2 <DOOffset>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x6000A7C")]
			[Address(RVA = "0x1A30508", Offset = "0x1A30508", VA = "0x1A30508")]
			internal void <DOOffset>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x20001E7")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x118384C", Offset = "0x118384C")]
		private sealed class <>c__DisplayClass9_0
		{
			[Token(Token = "0x4000728")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Material target;

			[Token(Token = "0x4000729")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public int propertyID;

			[Token(Token = "0x6000A7D")]
			[Address(RVA = "0x1A304DC", Offset = "0x1A304DC", VA = "0x1A304DC")]
			public <>c__DisplayClass9_0()
			{
			}

			[Token(Token = "0x6000A7E")]
			[Address(RVA = "0x1A3052C", Offset = "0x1A3052C", VA = "0x1A3052C")]
			internal Vector2 <DOTiling>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x6000A7F")]
			[Address(RVA = "0x1A30550", Offset = "0x1A30550", VA = "0x1A30550")]
			internal void <DOTiling>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x6000943")]
		[Address(RVA = "0x1A2FA08", Offset = "0x1A2FA08", VA = "0x1A2FA08")]
		public static Sequence DOGradientColor(this Material target, Gradient gradient, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000944")]
		[Address(RVA = "0x1A2FBCC", Offset = "0x1A2FBCC", VA = "0x1A2FBCC")]
		public static Sequence DOGradientColor(this Material target, Gradient gradient, string property, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000945")]
		[Address(RVA = "0x1A2FDA4", Offset = "0x1A2FDA4", VA = "0x1A2FDA4")]
		public static CustomYieldInstruction WaitForCompletion(this Tween t, bool returnCustomYieldInstruction)
		{
			return null;
		}

		[Token(Token = "0x6000946")]
		[Address(RVA = "0x1A2FE48", Offset = "0x1A2FE48", VA = "0x1A2FE48")]
		public static CustomYieldInstruction WaitForRewind(this Tween t, bool returnCustomYieldInstruction)
		{
			return null;
		}

		[Token(Token = "0x6000947")]
		[Address(RVA = "0x1A2FEEC", Offset = "0x1A2FEEC", VA = "0x1A2FEEC")]
		public static CustomYieldInstruction WaitForKill(this Tween t, bool returnCustomYieldInstruction)
		{
			return null;
		}

		[Token(Token = "0x6000948")]
		[Address(RVA = "0x1A2FF90", Offset = "0x1A2FF90", VA = "0x1A2FF90")]
		public static CustomYieldInstruction WaitForElapsedLoops(this Tween t, int elapsedLoops, bool returnCustomYieldInstruction)
		{
			return null;
		}

		[Token(Token = "0x6000949")]
		[Address(RVA = "0x1A30044", Offset = "0x1A30044", VA = "0x1A30044")]
		public static CustomYieldInstruction WaitForPosition(this Tween t, float position, bool returnCustomYieldInstruction)
		{
			return null;
		}

		[Token(Token = "0x600094A")]
		[Address(RVA = "0x1A300F8", Offset = "0x1A300F8", VA = "0x1A300F8")]
		public static CustomYieldInstruction WaitForStart(this Tween t, bool returnCustomYieldInstruction)
		{
			return null;
		}

		[Token(Token = "0x600094B")]
		[Address(RVA = "0x1A3019C", Offset = "0x1A3019C", VA = "0x1A3019C")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOOffset(this Material target, Vector2 endValue, int propertyID, float duration)
		{
			return null;
		}

		[Token(Token = "0x600094C")]
		[Address(RVA = "0x1A30340", Offset = "0x1A30340", VA = "0x1A30340")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOTiling(this Material target, Vector2 endValue, int propertyID, float duration)
		{
			return null;
		}
	}
	[Token(Token = "0x2000158")]
	public static class DOTweenCYInstruction
	{
		[Token(Token = "0x20001E8")]
		public class WaitForCompletion : CustomYieldInstruction
		{
			[Token(Token = "0x400072A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private readonly Tween t;

			[Token(Token = "0x1700005A")]
			public override bool keepWaiting
			{
				[Token(Token = "0x6000A80")]
				[Address(RVA = "0x1A27BEC", Offset = "0x1A27BEC", VA = "0x1A27BEC", Slot = "7")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x6000A81")]
			[Address(RVA = "0x1A27C20", Offset = "0x1A27C20", VA = "0x1A27C20")]
			public WaitForCompletion(Tween tween)
			{
			}
		}

		[Token(Token = "0x20001E9")]
		public class WaitForRewind : CustomYieldInstruction
		{
			[Token(Token = "0x400072B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private readonly Tween t;

			[Token(Token = "0x1700005B")]
			public override bool keepWaiting
			{
				[Token(Token = "0x6000A82")]
				[Address(RVA = "0x1A27DBC", Offset = "0x1A27DBC", VA = "0x1A27DBC", Slot = "7")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x6000A83")]
			[Address(RVA = "0x1A27E20", Offset = "0x1A27E20", VA = "0x1A27E20")]
			public WaitForRewind(Tween tween)
			{
			}
		}

		[Token(Token = "0x20001EA")]
		public class WaitForKill : CustomYieldInstruction
		{
			[Token(Token = "0x400072C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private readonly Tween t;

			[Token(Token = "0x1700005C")]
			public override bool keepWaiting
			{
				[Token(Token = "0x6000A84")]
				[Address(RVA = "0x1A27CD4", Offset = "0x1A27CD4", VA = "0x1A27CD4", Slot = "7")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x6000A85")]
			[Address(RVA = "0x1A27CF0", Offset = "0x1A27CF0", VA = "0x1A27CF0")]
			public WaitForKill(Tween tween)
			{
			}
		}

		[Token(Token = "0x20001EB")]
		public class WaitForElapsedLoops : CustomYieldInstruction
		{
			[Token(Token = "0x400072D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private readonly Tween t;

			[Token(Token = "0x400072E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private readonly int elapsedLoops;

			[Token(Token = "0x1700005D")]
			public override bool keepWaiting
			{
				[Token(Token = "0x6000A86")]
				[Address(RVA = "0x1A27C4C", Offset = "0x1A27C4C", VA = "0x1A27C4C", Slot = "7")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x6000A87")]
			[Address(RVA = "0x1A27C98", Offset = "0x1A27C98", VA = "0x1A27C98")]
			public WaitForElapsedLoops(Tween tween, int elapsedLoops)
			{
			}
		}

		[Token(Token = "0x20001EC")]
		public class WaitForPosition : CustomYieldInstruction
		{
			[Token(Token = "0x400072F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private readonly Tween t;

			[Token(Token = "0x4000730")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private readonly float position;

			[Token(Token = "0x1700005E")]
			public override bool keepWaiting
			{
				[Token(Token = "0x6000A88")]
				[Address(RVA = "0x1A27D1C", Offset = "0x1A27D1C", VA = "0x1A27D1C", Slot = "7")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x6000A89")]
			[Address(RVA = "0x1A27D80", Offset = "0x1A27D80", VA = "0x1A27D80")]
			public WaitForPosition(Tween tween, float position)
			{
			}
		}

		[Token(Token = "0x20001ED")]
		public class WaitForStart : CustomYieldInstruction
		{
			[Token(Token = "0x4000731")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private readonly Tween t;

			[Token(Token = "0x1700005F")]
			public override bool keepWaiting
			{
				[Token(Token = "0x6000A8A")]
				[Address(RVA = "0x1A27E4C", Offset = "0x1A27E4C", VA = "0x1A27E4C", Slot = "7")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x6000A8B")]
			[Address(RVA = "0x1A27E80", Offset = "0x1A27E80", VA = "0x1A27E80")]
			public WaitForStart(Tween tween)
			{
			}
		}
	}
	[Token(Token = "0x2000159")]
	public static class DOTweenModuleUtils
	{
		[Token(Token = "0x20001EE")]
		public static class Physics
		{
			[Token(Token = "0x6000A8C")]
			[Address(RVA = "0x1A306B8", Offset = "0x1A306B8", VA = "0x1A306B8")]
			public static void SetOrientationOnPath(PathOptions options, Tween t, Quaternion newRot, Transform trans)
			{
			}

			[Token(Token = "0x6000A8D")]
			[Address(RVA = "0x1A307C0", Offset = "0x1A307C0", VA = "0x1A307C0")]
			public static bool HasRigidbody2D(Component target)
			{
				return default(bool);
			}

			[Token(Token = "0x6000A8E")]
			[Address(RVA = "0x1A307C8", Offset = "0x1A307C8", VA = "0x1A307C8")]
			[Preserve]
			public static bool HasRigidbody(Component target)
			{
				return default(bool);
			}

			[Token(Token = "0x6000A8F")]
			[Address(RVA = "0x1A30858", Offset = "0x1A30858", VA = "0x1A30858")]
			[Preserve]
			public static TweenerCore<Vector3, Path, PathOptions> CreateDOTweenPathTween(MonoBehaviour target, bool tweenRigidbody, bool isLocal, Path path, float duration, PathMode pathMode)
			{
				return null;
			}
		}

		[Token(Token = "0x4000506")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static bool _initialized;

		[Token(Token = "0x600094D")]
		[Address(RVA = "0x1A30574", Offset = "0x1A30574", VA = "0x1A30574")]
		[Preserve]
		public static void Init()
		{
		}

		[Token(Token = "0x600094E")]
		[Address(RVA = "0x1A30618", Offset = "0x1A30618", VA = "0x1A30618")]
		[Preserve]
		private static void Preserver()
		{
		}
	}
}
namespace UnityEngine.Timeline
{
	[Token(Token = "0x200015A")]
	public class VideoPlayableBehaviour : PlayableBehaviour
	{
		[Token(Token = "0x4000507")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public VideoPlayer videoPlayer;

		[Token(Token = "0x4000508")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public VideoClip videoClip;

		[Token(Token = "0x4000509")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool mute;

		[Token(Token = "0x400050A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
		public bool loop;

		[Token(Token = "0x400050B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public double preloadTime;

		[Token(Token = "0x400050C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public double clipInTime;

		[Token(Token = "0x400050D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private bool playedOnce;

		[Token(Token = "0x400050E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x39")]
		private bool preparing;

		[Token(Token = "0x600094F")]
		[Address(RVA = "0x333C4C0", Offset = "0x333C4C0", VA = "0x333C4C0")]
		public void PrepareVideo()
		{
		}

		[Token(Token = "0x6000950")]
		[Address(RVA = "0x333C878", Offset = "0x333C878", VA = "0x333C878")]
		private void LoopPointReached(VideoPlayer vp)
		{
		}

		[Token(Token = "0x6000951")]
		[Address(RVA = "0x333C888", Offset = "0x333C888", VA = "0x333C888", Slot = "19")]
		public override void PrepareFrame(Playable playable, FrameData info)
		{
		}

		[Token(Token = "0x6000952")]
		[Address(RVA = "0x333CB74", Offset = "0x333CB74", VA = "0x333CB74", Slot = "17")]
		public override void OnBehaviourPlay(Playable playable, FrameData info)
		{
		}

		[Token(Token = "0x6000953")]
		[Address(RVA = "0x333CCD4", Offset = "0x333CCD4", VA = "0x333CCD4", Slot = "18")]
		public override void OnBehaviourPause(Playable playable, FrameData info)
		{
		}

		[Token(Token = "0x6000954")]
		[Address(RVA = "0x333CE08", Offset = "0x333CE08", VA = "0x333CE08", Slot = "20")]
		public override void ProcessFrame(Playable playable, FrameData info, object playerData)
		{
		}

		[Token(Token = "0x6000955")]
		[Address(RVA = "0x333CFFC", Offset = "0x333CFFC", VA = "0x333CFFC", Slot = "13")]
		public override void OnGraphStart(Playable playable)
		{
		}

		[Token(Token = "0x6000956")]
		[Address(RVA = "0x333D004", Offset = "0x333D004", VA = "0x333D004", Slot = "14")]
		public override void OnGraphStop(Playable playable)
		{
		}

		[Token(Token = "0x6000957")]
		[Address(RVA = "0x333D03C", Offset = "0x333D03C", VA = "0x333D03C", Slot = "16")]
		public override void OnPlayableDestroy(Playable playable)
		{
		}

		[Token(Token = "0x6000958")]
		[Address(RVA = "0x333CC28", Offset = "0x333CC28", VA = "0x333CC28")]
		public void PlayVideo()
		{
		}

		[Token(Token = "0x6000959")]
		[Address(RVA = "0x333CD78", Offset = "0x333CD78", VA = "0x333CD78")]
		public void PauseVideo()
		{
		}

		[Token(Token = "0x600095A")]
		[Address(RVA = "0x333C7E4", Offset = "0x333C7E4", VA = "0x333C7E4")]
		public void StopVideo()
		{
		}

		[Token(Token = "0x600095B")]
		[Address(RVA = "0x333C9FC", Offset = "0x333C9FC", VA = "0x333C9FC")]
		private void SyncVideoToPlayable(Playable playable)
		{
		}

		[Token(Token = "0x600095C")]
		[Address(RVA = "0x333D040", Offset = "0x333D040", VA = "0x333D040")]
		public VideoPlayableBehaviour()
		{
		}
	}
	[Token(Token = "0x200015B")]
	public sealed class VideoSchedulerPlayableBehaviour : PlayableBehaviour
	{
		[Token(Token = "0x400050F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private IEnumerable<TimelineClip> m_Clips;

		[Token(Token = "0x4000510")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private PlayableDirector m_Director;

		[Token(Token = "0x17000056")]
		internal PlayableDirector director
		{
			[Token(Token = "0x600095D")]
			[Address(RVA = "0x333D05C", Offset = "0x333D05C", VA = "0x333D05C")]
			get
			{
				return null;
			}
			[Token(Token = "0x600095E")]
			[Address(RVA = "0x333D064", Offset = "0x333D064", VA = "0x333D064")]
			set
			{
			}
		}

		[Token(Token = "0x17000057")]
		internal IEnumerable<TimelineClip> clips
		{
			[Token(Token = "0x600095F")]
			[Address(RVA = "0x333D06C", Offset = "0x333D06C", VA = "0x333D06C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000960")]
			[Address(RVA = "0x333D074", Offset = "0x333D074", VA = "0x333D074")]
			set
			{
			}
		}

		[Token(Token = "0x6000961")]
		[Address(RVA = "0x333D07C", Offset = "0x333D07C", VA = "0x333D07C", Slot = "20")]
		public override void ProcessFrame(Playable playable, FrameData info, object playerData)
		{
		}

		[Token(Token = "0x6000962")]
		[Address(RVA = "0x333D47C", Offset = "0x333D47C", VA = "0x333D47C")]
		public VideoSchedulerPlayableBehaviour()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200015C")]
	public class VideoScriptPlayableAsset : PlayableAsset
	{
		[Token(Token = "0x4000511")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public ExposedReference<VideoPlayer> videoPlayer;

		[Token(Token = "0x4000512")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		[NotKeyable]
		public VideoClip videoClip;

		[Token(Token = "0x4000513")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		[NotKeyable]
		public bool mute;

		[Token(Token = "0x4000514")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
		[SerializeField]
		[NotKeyable]
		public bool loop;

		[Token(Token = "0x4000515")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		[NotKeyable]
		public double preloadTime;

		[Token(Token = "0x4000516")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		[NotKeyable]
		public double clipInTime;

		[Token(Token = "0x6000963")]
		[Address(RVA = "0x333D484", Offset = "0x333D484", VA = "0x333D484", Slot = "6")]
		public override Playable CreatePlayable(PlayableGraph graph, GameObject go)
		{
			return default(Playable);
		}

		[Token(Token = "0x6000964")]
		[Address(RVA = "0x333D5B0", Offset = "0x333D5B0", VA = "0x333D5B0")]
		public VideoScriptPlayableAsset()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200015D")]
	[AttributeAttribute(Name = "TrackClipTypeAttribute", RVA = "0x1183374", Offset = "0x1183374")]
	[AttributeAttribute(Name = "TrackColorAttribute", RVA = "0x1183374", Offset = "0x1183374")]
	public class VideoScriptPlayableTrack : TrackAsset
	{
		[Token(Token = "0x6000965")]
		[Address(RVA = "0x333D5CC", Offset = "0x333D5CC", VA = "0x333D5CC", Slot = "24")]
		public override Playable CreateTrackMixer(PlayableGraph graph, GameObject go, int inputCount)
		{
			return default(Playable);
		}

		[Token(Token = "0x6000966")]
		[Address(RVA = "0x333D704", Offset = "0x333D704", VA = "0x333D704")]
		public VideoScriptPlayableTrack()
		{
		}
	}
}
